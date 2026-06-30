# Runtime Instance-Value Real-Name Extraction

How sampled, per-instance runtime values become ranked PascalCase class-name
candidates, and how those candidates plug into the existing naming gate without
inflating coverage.

## The problem this solves

Beebyte stripped the compile-time class names at build time. This is not
recoverable from the binary: the on-disk IL2CPP metadata stores the same `ÌÍÎÏ`
garbage, so structural reversing (field layout, call graph, vtable shape) can
only label a class's *role* — `BaseClass290Impl_828C`, `DataOnly4f` — never its
authored name.

What obfuscation cannot strip is the data a *live* instance carries. At runtime
a class still:

- (de)serialises JSON whose keys ARE its own field names,
- is attached to a `GameObject` the developer named,
- holds string values drawn from the product's domain,
- prints a `ToString()` that often leads with its type name.

The runtime sampler captures that. This module is the scoring core that turns
the captured values into candidate names. It is deliberately independent of
*how* the values were captured — its only contract is the input schema below.

## Input schema

`output/p2_research/runtime_instance_values.json`:

```json
[{
  "obf_class": "BaseClass290Impl_828C",
  "instances": [{
    "fields":          {"f_3A": "https://api.vrchat.cloud/...", "f_91": "FavoritesPanel"},
    "strings":         ["avatar_tune", "..."],
    "json_keys":       ["avatarId", "performanceRating"],
    "tostring":        "AvatarPerformanceData (Clone)",
    "gameobject_name": "AvatarTuneButton"
  }]
}]
```

## Signal hierarchy (strongest leak first)

| Rank | Signal            | Weight | Why this rank |
|------|-------------------|--------|---------------|
| 1    | `json_keys`       | 4.0    | The keys ARE the object's own field names. When a class serialises `{avatarPerformance, performanceRating}`, those tokens are the closest thing to a recovered developer symbol — not data *about* the object, but the object's own schema. A schema repeated across instances is a DTO fingerprint. |
| 2    | `gameobject_name` | 3.0    | A developer-authored identifier, but describes the scene node the component sits on, not necessarily the class — a `FavoritesPanel` GameObject may host several components. Strong, but one step removed from the type. |
| 3    | `strings`          | 1.5    | Recurring business words in string field *values*. This is data, not identifiers (a URL, a label, a localisation key), so it corroborates rather than names. Only words seen in >=2 instances survive. |
| 4    | `tostring`         | 1.0    | The leading token of `ToString()`. For records/DTOs the default is `<Namespace>.<TypeName>`, which is gold — but it is just as often overridden to print a value, so it is weakest and used mainly to corroborate. |

### Why JSON keys are the strongest leak

Every other signal describes the object from the *outside* (where it lives, what
it displays, what it stringifies to). JSON keys come from the *inside*: they are
literally the names the original developer gave the class's serialised members.
A class that consistently round-trips `avatarPerformance` / `performanceRating`
is, with very high probability, the type those members belong to. The keys
survive obfuscation because serialisation contracts are wire formats — renaming
them would break the server, so Beebyte leaves them intact. That makes them the
single richest source of recovered identifiers in the whole runtime sample.

## Scoring

For each `obf_class` we aggregate signals **across instances**, because
consistency is the entire point — a one-off value is probably incidental, a
value present in most instances is structural.

```
candidate_score = sum_over_signals( weight * recurrence )
recurrence       = (# instances exhibiting the signal) / (# instances)
confidence       = min(1.0, score / SATURATION)        # SATURATION = 5.0
```

Three refinements, each mirroring an existing pipeline lesson:

- **Dominant JSON key** — among competing keys we pick the one most corroborated
  by the *other* signals (its words echoed in `gameobject_name` / `strings` /
  `tostring`), then by token richness. This is the same token-overlap principle
  `grade_evidence.py` uses for its "A" grade: a name backed by the binary's own
  symbols. It is also what makes `avatarPerformance` win over `performanceRating`
  when both keys are equally frequent — `AvatarPerformance` is echoed by the
  `AvatarTuneButton` GameObject and `avatar_tune` strings.
- **Schema -> DTO name** — a bag of keys describes a data object, so a json-key
  candidate gets a `Data` role suffix (`avatarPerformance` -> `AvatarPerformanceData`)
  unless the recovered word already ends in a structural-role suffix (`...Info`,
  `...Settings`, `...Request`, `...Panel`, etc.).
- **Cross-signal corroboration** — when a weaker candidate's words are a subset
  of a stronger one's, it folds 25% of its score into the stronger candidate
  rather than competing. Independent signals agreeing is strong evidence.

## Anti-inflation gate (the item-20 / 562-name lesson)

History: 562 names were once accepted and later audited back down because they
were *structural, not real* — the reported class coverage inflated from a true
~45% to 62.8% by counting placeholders as semantic. This scorer is built to not
repeat that. **It prefers `null` over a plausible-but-structural guess.**

Every surviving candidate must clear the SAME gate the rest of the pipeline
uses, before `proposed_name` is set:

1. **`name_quality.is_weak_name(name) == False`** — the canonical, single-source
   criterion. Rejects legacy weak prefixes, structural placeholders
   (`BaseClassN`, `k__BackingField`, stacked `Impl/Sibling/Derived`), and
   generic-BCL-word-only labels (`Delegate`, `Object`). Imported directly; this
   module never forks the criterion.
2. **`VALID` format** — `^[A-Z][A-Za-z0-9]{2,}$`, the exact regex
   `gate_decompile_names.py` enforces. No hex tails, no leading digit.
3. **Confidence floor** — `confidence >= 0.45`. Thin evidence (a single generic
   key, one unsupported string) falls below the floor and yields `null`.
4. **Generic-noise filtering up front** — `id`, `name`, `value`, `count`,
   `url`, `true`/`false`, `http...`, etc. are stripped during tokenisation, and
   Unity default object names (`GameObject`, `Cube`, `Canvas`, `Root`, ...) are
   discarded, so they can never form or pad a candidate.

When any check fails, `proposed_name` is `null` and the row records the evidence
anyway (so a human can audit *why* it fell short).

## Output — plugs into the existing pipeline unchanged

Rows have the exact shape `gate_decompile_names.py` consumes:

```json
{
  "obf_class": "BaseClass290Impl_828C",
  "proposed_name": "AvatarPerformanceData",   // null when evidence insufficient
  "confidence": 0.85,
  "evidence": [
    {"source": "json_keys", "weight": 4.0, "recurrence": 1.0,
     "detail": "json key 'avatarPerformance' in 2/2 instances"}
  ]
}
```

The file is written to
`output/p2_research/naming_results/runtime_sampler_slice_realnames.json` —
inside `naming_results/` with a `slice_*` name so the gate's existing
`*slice_*.json` glob picks it up with no code change. From there
`gate_decompile_names.py` re-applies `is_weak_name`, the `VALID` format, the
distinctive-callee signal requirement, and the `obfclass_to_original` map before
anything reaches `decompile_class_names.json` -> `apply_class_names.py`. This
module's gate is the *first* line of defence; the central gate remains the
authority, so a runtime candidate can never bypass the coverage criterion.

## Usage

```bash
python tools/runtime_sampler/extract_realnames.py        # default in/out paths
python tools/runtime_sampler/extract_realnames.py \
    --input  output/p2_research/runtime_instance_values.json \
    --output output/p2_research/naming_results/runtime_sampler_slice_realnames.json

python tools/runtime_sampler/test_extract_realnames.py   # behaviour lock
```

The test pins the contract: a clean DTO resolves to the right name, a noise-only
class yields `null`, JSON keys outrank GameObject names, and every accepted row
clears `is_weak_name` + the gate format.
