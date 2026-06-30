"""Independent precision audit of the callgraph_inferred class names.

For every class currently named via callgraph inference, re-disassemble its
method bodies FRESH with strict function-boundary stopping (no fixed-size
window that can overrun into a neighbouring function), recompute the dominant
domain callee + concentration, and confirm it still maps to the assigned name
at the required min-count and >=50% concentration.

Read-only. Reports pass / drift / fail counts; writes a per-class audit.
"""
import sys, json, collections, bisect
sys.stdout.reconfigure(encoding="utf-8", errors="replace")
from pathlib import Path
ROOT = Path(__file__).resolve().parent.parent
sys.path.insert(0, str(ROOT / "tools"))
from extract_precise_dump import DumpReader
from capstone import Cs, CS_ARCH_X86, CS_MODE_64
from callgraph_boundary import iter_func, GENERIC_CALLEE, build_va2cls, next_va_for

DUMP = ROOT / "output" / "deobfuscated_dump.json"
DMP = ROOT / "dumps" / "VRChat_32984_20260629_180349_full.dmp"
OUT = ROOT / "output" / "callgraph_precision_audit.json"
HARD_CAP = 4096  # absolute ceiling; real stop is the ret/boundary heuristic

# callee -> (assigned_name, min_count). Mirror of propose_callee_names.py.
# Under the strict next-VA boundary (2026-06) only the 6 marked VERIFIED still
# back a passing class on this dump; the rest are DORMANT (curated hypotheses
# with no qualifying class here after the overrun bug was fixed). Both groups
# stay in the map so the audit can still recognise a name if one reappears, but
# on the current dump only the VERIFIED set should produce callgraph_inferred
# classes — see propose_callee_names.py for the authoritative split.
CURATED = {
    # --- VERIFIED: actively name >=1 class under strict boundary ---
    "Animator": ("AnimatorController", 6),
    "CancellationTokenSource": ("CancellableOperation", 6),
    "Camera": ("CameraController", 6),
    "UniTaskCompletionSource`1": ("AsyncCompletionSource", 5),
    "ApiFile": ("ApiFileHandler", 6), "VRCPlayer": ("PlayerComponent", 6),
    # --- DORMANT: curated but no qualifying class on this dump ---
    "Encoding": ("TextCodec", 8), "RuntimeHelpers": ("StaticDataTable", 8),
    "DateTime": ("TimestampHandler", 6),
    "ColorUtility": ("ColorConverter", 6), "RectTransform": ("LayoutController", 6),
    "CanvasGroup": ("CanvasFader", 5),
    "SynchronizationContext": ("ContextDispatcher", 5),
    "TraceEventCache": ("TraceListenerImpl", 5),
    "PlayerDataTypeUnion": ("PlayerDataAccessor", 6),
    "PlayerPrefs": ("PrefsStore", 6), "ApiContainer": ("ApiModel", 6),
    "VRC_Interactable": ("InteractableHandler", 6),
    "FileSystemInfo": ("FileSystemHandler", 6),
    "GroupsStorage": ("GroupsManager", 6), "Graphics": ("GraphicsRenderer", 6),
    "GetViewDataDictionary": ("EditorViewState", 6),
}
NAME_TO_CALLEE = {n: c for c, (n, _) in CURATED.items()}


def base_name(n):
    return n.rsplit("_", 1)[0]


def main():
    d = json.load(open(DUMP, encoding="utf-8"))
    va2cls, all_vas = build_va2cls(d)
    named = []
    for cl in d["namespaces"].values():
        if not isinstance(cl, list):
            continue
        for c in cl:
            if c.get("semantic_source") == "callgraph_inferred":
                named.append(c)

    dr = DumpReader(str(DMP))
    md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True

    audit = []
    counts = collections.Counter()
    for c in named:
        assigned = base_name(c["name"])
        expect_callee = NAME_TO_CALLEE.get(assigned)
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
            for insn in iter_func(md, dr.mm[fo:fo + HARD_CAP], va, next_va):
                if insn.mnemonic == "call" and insn.operands and insn.operands[0].type == 2:
                    cn = va2cls.get(insn.operands[0].imm)
                    if cn and not GENERIC_CALLEE.match(cn):
                        callee[cn] += 1
        total = sum(callee.values())
        top = callee.most_common(1)
        top_callee, top_n = (top[0] if top else (None, 0))
        conc = (top_n / total) if total else 0.0
        min_req = CURATED.get(expect_callee, (None, 5))[1] if expect_callee else 5
        # verdict
        if expect_callee is None:
            verdict = "unmapped_name"        # name not in curated set (shouldn't happen)
        elif top_callee == expect_callee and top_n >= min_req and conc >= 0.5:
            verdict = "pass"
        elif expect_callee in callee and callee[expect_callee] >= min_req:
            verdict = "pass_nondominant"     # still strong but no longer #1
        elif top_callee == expect_callee:
            verdict = "weak"                 # right callee, below bar now
        else:
            verdict = "drift"                # different dominant callee
        counts[verdict] += 1
        audit.append({
            "class": c["name"], "assigned": assigned,
            "expect_callee": expect_callee, "fresh_top": top_callee,
            "fresh_top_n": top_n, "concentration": round(conc, 3),
            "min_req": min_req, "verdict": verdict,
        })

    json.dump({"counts": dict(counts), "audit": audit},
              open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    print(f"audited {len(named)} callgraph_inferred classes (fresh disasm, strict boundary)")
    for v, n in counts.most_common():
        print(f"  {v:18} {n}")
    drift = [a for a in audit if a["verdict"] in ("drift", "weak")]
    if drift:
        print("\nflagged (drift/weak):")
        for a in drift[:30]:
            print(f"  {a['class'][:30]:30} assigned={a['assigned']:20} "
                  f"expect={a['expect_callee']} fresh_top={a['fresh_top']}({a['fresh_top_n']}) "
                  f"conc={a['concentration']}")
    print(f"\nWrote -> {OUT}")


if __name__ == "__main__":
    main()
