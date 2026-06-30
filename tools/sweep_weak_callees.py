"""Sweep ALL weak-named obfuscated classes; for each, extract its dominant
domain callee via function-boundary disassembly. Aggregate to discover which
callees are discriminative (concentrated, exclusive) enough to name from.

Read-only. Writes output/weak_class_callees.json for the naming step to consume.
"""
import sys, json, collections, bisect
sys.stdout.reconfigure(encoding="utf-8", errors="replace")
from pathlib import Path
ROOT = Path(__file__).resolve().parent.parent
sys.path.insert(0, str(ROOT / "tools"))
from extract_precise_dump import DumpReader
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from name_quality import is_weak_name
from callgraph_boundary import iter_func, GENERIC_CALLEE, build_va2cls, next_va_for
from propose_callee_names import score_proposals

DUMP = ROOT / "output" / "deobfuscated_dump.json"
DMP = ROOT / "dumps" / "VRChat_32984_20260629_180349_full.dmp"
OUT = ROOT / "output" / "weak_class_callees.json"
SUMMARY = ROOT / "output" / "weak_class_callees.summary.json"
SCAN = 2000


def main():
    d = json.load(open(DUMP, encoding="utf-8"))
    va2cls, all_vas = build_va2cls(d)
    weak_classes = []
    for cl in d["namespaces"].values():
        if not isinstance(cl, list):
            continue
        for c in cl:
            if c.get("original_name") and is_weak_name(c.get("name", "")):
                weak_classes.append(c)

    dr = DumpReader(str(DMP))
    md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True

    # Dedup to source types: scan one representative per original_name.
    by_src = {}
    for c in weak_classes:
        by_src.setdefault(c["original_name"], c)

    results = {}
    callee_freq = collections.Counter()  # how many source types call X dominantly
    n = 0
    for orig, c in by_src.items():
        n += 1
        if n % 500 == 0:
            print(f"  {n}/{len(by_src)} source types scanned", flush=True)
        callee = collections.Counter()
        for m, va_hex in c.get("method_pointers", {}).items():
            try:
                va = int(va_hex, 16)
            except (ValueError, TypeError):
                continue
            fo = dr.v2f(va)
            if fo is None:
                continue
            next_va = next_va_for(all_vas, va)
            for insn in iter_func(md, dr.mm[fo:fo + SCAN], va, next_va):
                if insn.mnemonic == "call" and insn.operands and insn.operands[0].type == 2:
                    cn = va2cls.get(insn.operands[0].imm)
                    if cn and not GENERIC_CALLEE.match(cn):
                        callee[cn] += 1
        if callee:
            top = callee.most_common(5)
            results[orig] = {"current": c["name"], "callees": top}
            callee_freq[top[0][0]] += 1

    json.dump(results, open(OUT, "w", encoding="utf-8"),
              ensure_ascii=False, indent=1)

    # Lightweight content fingerprint of this sweep so a regenerated file can be
    # checked against committed conclusions WITHOUT re-reading the 700MB dump.
    # The drift guard in test_name_quality.py compares this to the locked
    # VERIFIED hit distribution (6 templates / 11 instances).
    _, by_template = score_proposals(results)
    summary = {
        "source_types_with_callee": len(results),
        "named_instances": sum(by_template.values()),
        "by_template": dict(sorted(by_template.items())),
    }
    json.dump(summary, open(SUMMARY, "w", encoding="utf-8"),
              ensure_ascii=False, indent=1)

    print(f"\nscanned {len(by_src)} weak source types; {len(results)} have a domain callee")
    print(f"\nmost common dominant callees (how many source types -> discriminative?):")
    for cn, cnt in callee_freq.most_common(30):
        print(f"  {cnt:5}  {cn}")
    print(f"\nfingerprint: {summary['named_instances']} named instances across "
          f"{len(summary['by_template'])} templates -> {SUMMARY.name}")
    print(f"Wrote -> {OUT}")


if __name__ == "__main__":
    main()
