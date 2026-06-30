#!/usr/bin/env python
"""Recover real class names from RUNTIME INSTANCE-VALUE samples.

Beebyte stripped the compile-time class names (the disk metadata stores the same
ÌÍÎÏ garbage), so structural reversing can only label a class's *role*. What it
CANNOT destroy is the data a live instance carries: the JSON it (de)serialises,
the GameObject it is attached to, the strings it holds. This module turns that
sampled, per-instance evidence into ranked PascalCase class-name candidates.

Signal hierarchy (strongest first) — see EXTRACT_DESIGN.md for the rationale:
  1. json_keys   (w=4.0) the keys ARE the object's own field names — the closest
                 thing to a recovered symbol. A schema repeated across instances
                 is a DTO fingerprint.
  2. gameobject  (w=3.0) GameObject.name is a developer-authored identifier.
  3. strings     (w=1.5) recurring business words in string field VALUES; data,
                 not identifiers, so corroborating only.
  4. tostring    (w=1.0) leading token of ToString() — often "<TypeName> (...)".

A candidate's score is sum(weight * recurrence) where recurrence is the fraction
of instances exhibiting that signal: consistency across instances is the whole
point, a one-off value barely moves the score. Confidence saturates the score.

ANTI-INFLATION (item 20 / the 562-name rollback): every surviving candidate must
clear the SAME gate the rest of the pipeline uses — name_quality.is_weak_name
(False) and the gate's VALID PascalCase format — plus a confidence floor. When
the evidence is thin we emit proposed_name=null. Prefer null over a structural
guess. Output rows are {obf_class, proposed_name, confidence, evidence[]}, the
exact shape gate_decompile_names.py consumes, so candidates plug straight in.
"""
import argparse
import json
import re
import sys
from collections import Counter, defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
sys.path.insert(0, str(Path(__file__).resolve().parent.parent))
from name_quality import is_weak_name

BASE = Path(__file__).resolve().parent.parent.parent
DEFAULT_IN = BASE / "output" / "p2_research" / "runtime_instance_values.json"
# Land in naming_results/ with a slice_* name so gate_decompile_names.py picks
# the rows up unchanged (it globs "*slice_*.json").
DEFAULT_OUT = (BASE / "output" / "p2_research" / "naming_results"
               / "runtime_sampler_slice_realnames.json")

# Signal weights and the score->confidence saturation point.
W_JSON = 4.0
W_GAMEOBJECT = 3.0
W_STRINGS = 1.5
W_TOSTRING = 1.0
SATURATION = 5.0          # score >= this -> confidence 1.0
CONF_FLOOR = 0.45         # below this -> proposed_name=null (prefer null)
MAX_TOKENS = 4            # cap synthesised name length

# Gate's accepted identifier shape (mirrors gate_decompile_names.VALID).
VALID = re.compile(r"^[A-Z][A-Za-z0-9]{2,}$")

# Generic / structural tokens that carry no domain meaning. Dropped during
# tokenisation so they never form (or pad) a candidate. Lowercased.
GENERIC = {
    "id", "ids", "name", "names", "value", "values", "count", "item", "items",
    "url", "urls", "uri", "type", "types", "data", "key", "keys", "index",
    "idx", "list", "array", "object", "objects", "string", "str", "int",
    "integer", "bool", "boolean", "null", "none", "true", "false", "http",
    "https", "www", "com", "get", "set", "is", "has", "the", "of", "to", "in",
    "on", "at", "by", "for", "and", "or", "guid", "uuid", "hash", "tag", "tags",
    "flag", "flags", "num", "number", "size", "len", "length", "total",
    "status", "code", "error", "msg", "message", "text", "label", "title",
    "desc", "description", "info", "ok", "yes", "no", "field", "prop",
    "property", "version", "ver", "result", "results",
}
# Noun suffixes that already mark a structural role; a json-derived DTO name that
# ends in one of these does NOT get a redundant "Data" appended.
SEMANTIC_SUFFIX = (
    "Data", "Info", "Settings", "Config", "State", "Request", "Response",
    "Result", "Model", "Dto", "Entry", "Record", "Stats", "Rating", "Panel",
    "Button", "View", "Manager", "Controller", "Service", "Provider",
    "Handler", "Event", "Message", "Payload", "Descriptor", "Context",
)
_NUMERIC = re.compile(r"^[0-9a-fA-F]+$")
_CLONE = re.compile(r"\s*\(clone\)\s*$", re.IGNORECASE)
_TRAIL_NUM = re.compile(r"[ _\-]?\d+$")
# Unity's default / placeholder object names — developer never authored these,
# so they are noise, not a recovered identifier. Compared on the cleaned, lower
# name (trailing "(1)" / "(Clone)" already stripped).
DEFAULT_GO_NAMES = {
    "gameobject", "new game object", "game object", "object", "cube", "sphere",
    "capsule", "cylinder", "plane", "quad", "canvas", "text", "image", "panel",
    "empty", "root", "container", "group", "default", "untitled",
}


def split_tokens(s):
    """Split a snake_case / camelCase / spaced identifier into lower tokens."""
    if not s:
        return []
    out = []
    for part in re.split(r"[_\-\s\./:]+", s.strip()):
        # split camelCase / PascalCase / ALLCAPS runs into words
        out += re.findall(r"[A-Z]+(?=[A-Z][a-z])|[A-Z]?[a-z0-9]+|[A-Z]+", part)
    return [t.lower() for t in out if t]


def meaningful_tokens(s):
    """Domain tokens only: drop generic noise, pure numbers, and 1-char tokens."""
    toks = []
    for t in split_tokens(s):
        if t in GENERIC or len(t) < 2 or _NUMERIC.match(t):
            continue
        toks.append(t)
    return toks


def to_pascal(tokens):
    """Join already-meaningful tokens into a PascalCase identifier."""
    return "".join(t[:1].upper() + t[1:] for t in tokens[:MAX_TOKENS])


def _corroboration_bag(instances):
    """Domain tokens seen in NON-json signals (gameobject/strings/tostring).

    Used to break ties between equally-supported JSON keys: the key whose words
    are echoed elsewhere in the instance is the real class subject (mirrors
    grade_evidence's token-overlap "A" grade)."""
    bag = Counter()
    for inst in instances:
        for src in ("gameobject_name", "tostring"):
            for t in meaningful_tokens(inst.get(src) or ""):
                bag[t] += 1
        for s in inst.get("strings") or []:
            for t in meaningful_tokens(s):
                bag[t] += 1
    return bag


def _dominant_key(instances):
    """Pick the single most class-defining JSON key across instances.

    Ranked by: cross-signal corroboration (words echoed by gameobject/strings/
    tostring), then domain-token count (multi-word keys are more distinctive),
    then key length, then instance support, then key text (deterministic
    tiebreak). Returns (key, support) or (None, 0)."""
    support = Counter()
    for inst in instances:
        for k in set(inst.get("json_keys") or []):
            if meaningful_tokens(k):
                support[k] += 1
    if not support:
        return None, 0
    bag = _corroboration_bag(instances)

    def corroboration(k):
        return sum(bag[t] for t in meaningful_tokens(k))

    best = max(support,
               key=lambda k: (corroboration(k), len(meaningful_tokens(k)),
                              len(k), support[k], k))
    return best, support[best]


def _candidate_from_json(instances, n):
    key, support = _dominant_key(instances)
    if not key:
        return None
    toks = meaningful_tokens(key)
    name = to_pascal(toks)
    # DTO role marker: a bag of keys describes a data object. Add "Data" unless
    # the recovered word already ends in a structural-role suffix.
    if not name.endswith(SEMANTIC_SUFFIX):
        name = name + "Data"
    return {
        "name": name, "source": "json_keys", "weight": W_JSON,
        "recurrence": support / n,
        "evidence": f"json key '{key}' in {support}/{n} instances",
    }


def _candidate_from_gameobject(instances, n):
    names = Counter()
    for inst in instances:
        raw = inst.get("gameobject_name")
        if not raw:
            continue
        cleaned = _TRAIL_NUM.sub("", _CLONE.sub("", raw)).strip()
        if cleaned.lower() in DEFAULT_GO_NAMES:
            continue
        toks = meaningful_tokens(cleaned)
        if toks:
            names[to_pascal(toks)] += 1
    if not names:
        return None
    name, support = names.most_common(1)[0]
    return {
        "name": name, "source": "gameobject", "weight": W_GAMEOBJECT,
        "recurrence": support / n,
        "evidence": f"GameObject.name -> '{name}' in {support}/{n} instances",
    }


def _candidate_from_strings(instances, n):
    """Recurring business words across string field values + ToString text."""
    tok_support = Counter()
    first_seen = {}
    for i, inst in enumerate(instances):
        seen = set()
        for s in inst.get("strings") or []:
            for t in meaningful_tokens(s):
                seen.add(t)
        for t in seen:
            tok_support[t] += 1
            first_seen.setdefault(t, i)
    # keep words present in at least two instances (or all, when only one)
    floor = 2 if n > 1 else 1
    kept = [t for t, c in tok_support.items() if c >= floor]
    if not kept:
        return None
    kept.sort(key=lambda t: (-tok_support[t], first_seen[t]))
    top = kept[:MAX_TOKENS]
    name = to_pascal(top)
    support = max(tok_support[t] for t in top)
    return {
        "name": name, "source": "strings", "weight": W_STRINGS,
        "recurrence": support / n,
        "evidence": f"recurring words {top} across string values",
    }


def _candidate_from_tostring(instances, n):
    prefixes = Counter()
    for inst in instances:
        ts = inst.get("tostring")
        if not ts:
            continue
        # "Foo.Bar (clone)" / "Foo: ..." -> leading identifier
        head = re.split(r"[ :(\[{,]", ts.strip(), maxsplit=1)[0]
        toks = meaningful_tokens(head)
        if toks:
            prefixes[to_pascal(toks)] += 1
    if not prefixes:
        return None
    name, support = prefixes.most_common(1)[0]
    return {
        "name": name, "source": "tostring", "weight": W_TOSTRING,
        "recurrence": support / n,
        "evidence": f"ToString prefix '{name}' in {support}/{n} instances",
    }


def score_class(obf_class, instances):
    """Aggregate signals across instances into a single gated candidate row.

    Returns the pipeline row {obf_class, proposed_name, confidence, evidence[]}.
    proposed_name is null when evidence is insufficient or fails the gate."""
    instances = instances or []
    n = len(instances)
    row = {"obf_class": obf_class, "proposed_name": None,
           "confidence": 0.0, "evidence": []}
    if n == 0:
        return row

    raw = [c for c in (
        _candidate_from_json(instances, n),
        _candidate_from_gameobject(instances, n),
        _candidate_from_strings(instances, n),
        _candidate_from_tostring(instances, n),
    ) if c]
    if not raw:
        return row

    # Merge candidates by name; corroboration from multiple signals stacks score.
    merged = defaultdict(lambda: {"score": 0.0, "evidence": []})
    for c in raw:
        m = merged[c["name"]]
        m["score"] += c["weight"] * c["recurrence"]
        m["evidence"].append({
            "source": c["source"], "weight": c["weight"],
            "recurrence": round(c["recurrence"], 3), "detail": c["evidence"],
        })
    # Token-overlap corroboration: a weaker candidate whose words are a subset of
    # a stronger one's reinforces the stronger one (grade_evidence "A" logic).
    names = list(merged)
    for a in names:
        ta = set(re.findall(r"[A-Z][a-z0-9]*", a))
        for b in names:
            if a is b:
                continue
            tb = set(re.findall(r"[A-Z][a-z0-9]*", b))
            if ta < tb:  # a's words fully contained in b -> fold a into b
                merged[b]["score"] += merged[a]["score"] * 0.25

    ranked = sorted(merged.items(), key=lambda kv: kv[1]["score"], reverse=True)
    best_name, best = ranked[0]
    confidence = round(min(1.0, best["score"] / SATURATION), 3)

    # --- the gate: prefer null over a structural / low-evidence guess ---
    ev = best["evidence"]
    if (VALID.match(best_name)
            and not is_weak_name(best_name)
            and confidence >= CONF_FLOOR):
        row["proposed_name"] = best_name
    row["confidence"] = confidence
    row["evidence"] = ev
    return row


def main():
    ap = argparse.ArgumentParser(description=__doc__)
    ap.add_argument("--input", type=Path, default=DEFAULT_IN)
    ap.add_argument("--output", type=Path, default=DEFAULT_OUT)
    args = ap.parse_args()

    if not args.input.exists():
        print(f"[extract_realnames] no sampled data at {args.input}")
        print("  run the runtime sampler first; nothing to score.")
        return 0

    samples = json.load(open(args.input, encoding="utf-8"))
    rows = [score_class(s.get("obf_class"), s.get("instances"))
            for s in samples]

    named = [r for r in rows if r["proposed_name"]]
    args.output.parent.mkdir(parents=True, exist_ok=True)
    json.dump(rows, open(args.output, "w", encoding="utf-8"),
              ensure_ascii=False, indent=2)

    print(f"scored {len(rows)} classes, {len(named)} pass the gate "
          f"({len(rows) - len(named)} -> null)")
    by_src = Counter(e["source"] for r in named for e in r["evidence"])
    print("winning-signal evidence sources:",
          json.dumps(dict(by_src), ensure_ascii=False))
    for r in sorted(named, key=lambda r: -r["confidence"])[:15]:
        print(f"  {r['confidence']:.2f}  {r['obf_class']:<28} -> "
              f"{r['proposed_name']}")
    print(f"wrote {len(rows)} rows -> {args.output}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
