"""Analyze all-weak generic source-type groups via call-graph signal.

Read-only analysis. For each multi-instance, all-weak group (generic source
type with no name on any instance), disassemble a representative instance's
methods from the current-build minidump and rank the named classes it calls.
Classify naming confidence conservatively. Writes a proposal file for review;
does NOT apply names.
"""
import sys, json, collections, re
sys.stdout.reconfigure(encoding="utf-8", errors="replace")
from pathlib import Path
ROOT = Path(__file__).resolve().parent.parent
sys.path.insert(0, str(ROOT / "tools"))
from extract_precise_dump import DumpReader
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from name_quality import is_weak_name

DUMP = ROOT / "output" / "deobfuscated_dump.json"
DMP = ROOT / "dumps" / "VRChat_32984_20260629_180349_full.dmp"
OUT = ROOT / "output" / "generic_group_callgraph.json"
SCAN = 2000  # hard cap; real stop is function-boundary detection


def iter_func(md, code, va):
    """Yield instructions until the function ends. Without this, short methods
    overrun into neighbouring functions and contaminate the call-graph signal
    (verified: an 800-byte flat scan invented Sprite/Texture2D/Graphic callees
    that vanish once boundaries are respected)."""
    seen_ret = False
    for insn in md.disasm(code, va):
        if seen_ret and insn.mnemonic in ("int3", "nop"):
            return
        yield insn
        seen_ret = (insn.mnemonic == "ret")

# Callees that carry no domain meaning (framework/runtime/primitive).
GENERIC_CALLEE = re.compile(
    r'^(Type|Struct|Mono|Service|Major|Static|Record|DataOnly|Unknown|Empty|'
    r'LargeClass|Class_|Obf_|BaseClass|k__|Backing|Delegate|Enum|Sibling|'
    r'Derived|Related|Impl|Pointer|UnityObjectWrapper|PropertyAttribute)|'
    r'^(System|Object|Component|Array|String|Time|Func`|Action`|List`|'
    r'Dictionary`|Nullable`|IEnumerable|IEnumerator|ValueType|Exception|'
    r'ThrowHelper|ArgumentNullException|RuntimeHelpers|Span`|Memory`|'
    r'Task`|ValueTask|IDisposable|EqualityComparer|Comparer`)$')


def main():
    d = json.load(open(DUMP, encoding="utf-8"))
    allc = [c for cl in d["namespaces"].values() if isinstance(cl, list)
            for c in cl if c.get("original_name")]
    byname = collections.defaultdict(list)
    for c in allc:
        byname[c["original_name"]].append(c)

    va2cls = {}
    for cl in d["namespaces"].values():
        if not isinstance(cl, list):
            continue
        for c in cl:
            for m, va in c.get("method_pointers", {}).items():
                try:
                    va2cls[int(va, 16)] = c.get("name", "")
                except (ValueError, TypeError):
                    pass

    groups = [(n, cs) for n, cs in byname.items()
              if len(cs) > 1 and all(is_weak_name(c["name"]) for c in cs)]
    groups.sort(key=lambda x: -len(x[1]))

    dr = DumpReader(str(DMP))
    md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True

    proposals = []
    for n, cs in groups:
        rep = cs[0]
        callee = collections.Counter()
        for m, va_hex in rep.get("method_pointers", {}).items():
            try:
                va = int(va_hex, 16)
            except (ValueError, TypeError):
                continue
            fo = dr.v2f(va)
            if fo is None:
                continue
            for insn in iter_func(md, dr.mm[fo:fo + SCAN], va):
                if insn.mnemonic == "call" and insn.operands and insn.operands[0].type == 2:
                    cn = va2cls.get(insn.operands[0].imm)
                    if cn and not GENERIC_CALLEE.match(cn):
                        callee[cn] += 1
        domain = callee.most_common(5)
        # Confidence: dominant domain callee with strong, concentrated signal.
        conf = "none"
        if domain:
            top_n = domain[0][1]
            total = sum(callee.values())
            share = top_n / total if total else 0
            if top_n >= 4 and share >= 0.5:
                conf = "strong"
            elif top_n >= 3:
                conf = "medium"
            elif top_n >= 2:
                conf = "weak"
        proposals.append({
            "original_name": n,
            "instances": len(cs),
            "current_name": rep["name"],
            "parent": rep.get("parent"),
            "n_methods": len(rep.get("methods", [])),
            "domain_callees": domain,
            "confidence": conf,
        })

    json.dump(proposals, open(OUT, "w", encoding="utf-8"),
              ensure_ascii=False, indent=1)

    by_conf = collections.Counter(p["confidence"] for p in proposals)
    inst_by_conf = collections.Counter()
    for p in proposals:
        inst_by_conf[p["confidence"]] += p["instances"]
    print(f"all-weak generic groups: {len(groups)}  "
          f"(occupying {sum(p['instances'] for p in proposals)} instances)")
    print(f"confidence  groups  instances")
    for k in ["strong", "medium", "weak", "none"]:
        print(f"  {k:8}  {by_conf[k]:5}   {inst_by_conf[k]}")
    print(f"\nSTRONG groups (dominant domain callee):")
    for p in sorted(proposals, key=lambda x: -x["instances"]):
        if p["confidence"] == "strong":
            print(f"  {p['instances']:4} inst  {p['current_name'][:26]:26} "
                  f"-> {p['domain_callees'][:3]}")
    print(f"\nMEDIUM groups:")
    for p in sorted(proposals, key=lambda x: -x["instances"]):
        if p["confidence"] == "medium":
            print(f"  {p['instances']:4} inst  {p['current_name'][:26]:26} "
                  f"-> {p['domain_callees'][:3]}")
    print(f"\nWrote -> {OUT}")


if __name__ == "__main__":
    main()
