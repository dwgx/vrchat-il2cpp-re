# VRChat IL2CPP Deobfuscation Coverage Report

Build: 2026-06-05 (June 5) | Status: v2.3, post full 122-batch quality audit

> Canonical machine-readable numbers: `output/coverage_stats.json`
> (regenerated every pipeline run by `tools/compute_final_stats.py`, Stage 3c).
> Auto-generated pipeline summary: `output/pipeline_coverage_report.md`.
> This file is a human-readable snapshot consistent with both.

---

## Executive Summary

| Metric | Count | Coverage |
|--------|------:|----------|
| Total classes | 88,400 | - |
| Obfuscated classes | 11,503 | 13.0% of total |
| -- Semantic names | 7,813 | 67.9% of obfuscated |
| -- Fallback names | 3,690 | 32.1% of obfuscated |
| Still raw-obfuscated classes | 0 | 0.0% |
| Total methods | 528,135 | - |
| Semantic method names | 478,923 | **90.7%** |
| Hash-fallback methods (m_XXX) | 49,212 | 9.3% |
| Still raw-obfuscated methods | 0 | 0.0% |
| Total fields | 71,972 | - (was 2,870 before v2.4 runtime recovery) |
| Typed/semantic fields | 66,282 | **92.1%** |
| Hash-fallback fields | 5,690 | 7.9% |
| cross_version method mappings | 39,623 | - |

**Bottom line:** No raw Beebyte identifiers remain. 90.7% of all methods carry semantic
names; the remaining 9.3% use stable `m_XXX` hash fallbacks (mostly compiler-generated
closures/lambdas and highly generic methods where any name would be a guess). A full
122-batch quality audit removed ~13,777 low-confidence predictions and fixed 137,
trading ~3.4% raw coverage for materially higher precision.

---

## Naming Source Contribution

| Source | Approx. names | Confidence |
|--------|--------------:|------------|
| RVA propagation (v2 + cascade) | ~15,500 | Highest (zero hallucination — same function pointer = same function) |
| Cross-version lifts (body-hash, vtable, typedef, same-name) | large | High (structural/signature match across builds) |
| Sibling-context LLM inference | ~13,500 | Medium (class-context guided) |
| LLM mega-batches (Hex-Rays pseudocode) | ~2,800 | Medium-high (evidence-backed) |
| Metadata strings / IDA string refs | moderate | High |
| Quality audit | −13,777 / +137 | Removed low-confidence, fixed mislabels |

---

## Where the Remaining Gap Is

The unresolved ~49K hash methods and 3,690 fallback classes concentrate in:

1. **Global namespace** — compiler artifacts: `<>c` display/closure classes, async state
   machines, generated enumerators, lambdas. Naming these is largely noise; the audit
   specifically removed prior guesses here.
2. **Generic/template families** — `System.Collections.Generic`, value-type specializations.
3. **Large network/UI components** — a smaller pocket where real names are recoverable
   with more Hex-Rays pseudocode (mega-batch route).
4. **Fields** — only 2,870 fields were captured by the minidump extraction vs ~70K+
   expected. This is the single biggest *recoverable* gap and requires runtime Frida
   field-type extraction (see below).

---

## Prioritized High-Value Targets (by ROI)

1. **Runtime field extraction (highest value).** Run `extract_field_types_v2.py` against
   an offline VRChat process to populate `field_types.json`. This both fills the field
   gap and supplies strong context for further method naming. *Frida JS offsets must be
   updated to the current build first.*
2. **More Hex-Rays pseudocode → mega-batch.** Decompile additional high-value network/UI
   functions and run the LLM mega-batch route for evidence-backed method names.
3. **Cross-version lifting on the next build.** When VRChat updates, build a fresh
   old→new class map and lift stable names forward (often the cheapest large win).

**Do NOT pursue:** neighbor-batch inference (proven <1 useful prediction/batch) or
brute-force naming of `<>c`/lambda hash methods (the audit will just remove them again).

---

## Output Artifacts

| File | Purpose |
|------|---------|
| `output/coverage_stats.json` | Canonical machine-readable numbers (this report's source of truth) |
| `output/pipeline_coverage_report.md` | Auto-generated per-run pipeline summary |
| `output/deobfuscated_dump.json` | Full deobfuscated dump (classes/methods/fields, original names) |
| `output/deobfuscated_dump.cs` | C# stub with **RVA** method offsets + field types/offsets |
| `output/name_mapping.json` | obf→semantic maps (classes/methods/fields) for IDA/Ghidra |
| `output/src/` | 1,538 RVA-annotated C# source files organized by namespace |
| `output/ida_apply_names.py` | IDAPython rename script (226,911 renames, auto image-base) |
