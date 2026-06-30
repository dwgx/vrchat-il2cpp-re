#!/usr/bin/env python
"""Regression guard for the canonical name-quality criterion.

The "is this a real semantic name?" judgement controls the headline class
coverage number. It silently broke once (structural placeholders counted as
semantic -> 62.8% reported vs ~45% real). This locks the behaviour with golden
cases drawn from the real dump, plus a live consistency check that the criterion
still produces the committed coverage figure.

Run: python tools/test_name_quality.py   (exit 0 = all pinned, non-zero = drift)
No external test framework needed.
"""
import json
import sys
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
sys.path.insert(0, str(Path(__file__).resolve().parent))
from name_quality import is_weak_name, is_structural_placeholder, _residual

BASE = Path(__file__).resolve().parent.parent
STATS = BASE / "output" / "coverage_stats.json"

# (name, expected_is_weak, why) — every case is a real or representative token
# pattern. WEAK=should count as fallback; REAL=should count toward coverage.
GOLDEN = [
    # --- structural placeholders that inflated coverage (must be WEAK) ---
    ("BaseClass290ImplImpl_31B9", True, "pure topology, residual empty"),
    ("BackingFieldBase_16D7", True, "backing-field placeholder"),
    ("k__BackingFieldSibling_3FE6", True, "compiler backing + sibling"),
    ("RequiresStoringk__BackingRelated_C846", True, "stacked synthetic tokens"),
    ("BaseClass7Sibling_4F24", True, "topology sibling"),
    ("UIk__BackingField_28DE", True, "UI lead-noise + backing, no residual"),
    # --- legacy weak prefixes (must be WEAK) ---
    ("Type1234m", True, "legacy type+method weak prefix"),
    ("Struct99f", True, "legacy struct+field weak prefix"),
    ("Class_5", True, "legacy Class_ prefix"),
    ("Unknown5m", True, "counting placeholder Unknown<n>m"),
    ("Mono1m_84FB", True, "counting placeholder Mono<n>"),
    ("Service31m_3451", True, "counting placeholder Service<n>"),
    ("Record106f", True, "counting placeholder Record<n>"),
    ("DataOnly4f", True, "counting placeholder DataOnly<n>"),
    ("EmptyType", True, "bare descriptive placeholder"),
    ("LargeClass99", True, "LargeClass placeholder"),
    ("", True, "empty name"),
    # --- legit names sharing a placeholder prefix (must be REAL — were FALSE
    #     POSITIVES under the old bare-startswith test; mirror of the inflation
    #     bug, this one UNDER-counted coverage and dropped real a1 names) ---
    ("MonoBehaviour", False, "real Unity class, not Mono<digit>"),
    ("ServiceProvider", False, "real DI class, not Service<digit>"),
    ("ServiceCanvasRoot", False, "real a1 name that was being dropped"),
    ("TypeConverterRegistry", False, "real .NET class, not Type<digit>"),
    ("StaticMeshBatcher", False, "real class, not Static<digit>"),
    ("RecordReader", False, "real class, not Record<digit>"),
    ("StructLayoutAttribute", False, "real attribute, not Struct<digit>"),
    ("MajorityVoteResolver", False, "real class, not Major<digit>"),
    # --- real semantic names (must be REAL — never demote these) ---
    ("ShopPrefabProvider", False, "clear domain name"),
    ("GestureLocomotionBase_D955", False, "residual GestureLocomotion survives"),
    ("ContainerPromptBaseImpl_CCAF", False, "residual ContainerPrompt survives"),
    ("SliderInteractText", False, "evidence-synthesized domain name"),
    ("MobileOpacityPulse", False, "evidence-synthesized domain name"),
    ("BlurRenderTexture", False, "evidence-synthesized domain name"),
    ("Pose", False, "short but real, no synthetic tokens"),
    ("Rect", False, "short but real, no synthetic tokens"),
    ("AsyncStateMachine_50D1", False, "residual AsyncStateMachine survives"),
    # --- item 20: generic-BCL-word-only names are weak (label, not domain name) ---
    ("Delegate_72B1", True, "MulticastDelegate subclass, no domain content"),
    ("Delegate", True, "bare generic framework word"),
    ("MulticastDelegate_8342", True, "bare delegate role + hex residue"),
    ("DelegateRegistry", False, "domain qualifier on generic word -> real"),
    ("EventDelegate", False, "domain-qualified delegate -> real"),
    ("InputActionDelegate", False, "domain-qualified -> real"),
]


def run_golden():
    fails = []
    for name, want_weak, why in GOLDEN:
        got = is_weak_name(name)
        if got != want_weak:
            fails.append((name, want_weak, got, why))
    if fails:
        print(f"FAIL: {len(fails)}/{len(GOLDEN)} golden cases drifted:")
        for name, want, got, why in fails:
            verdict = "WEAK" if want else "REAL"
            print(f"  {name!r}: expected {verdict} ({why}), got is_weak={got}")
        return False
    print(f"PASS: all {len(GOLDEN)} golden cases hold")
    return True


def run_residual_spotcheck():
    """The residual extraction is the subtle part — pin a few directly."""
    cases = [
        ("BaseClass290ImplImpl_31B9", ""),            # nothing left -> WEAK
        ("GestureLocomotionBase_D955", "GestureLocomotionBase"),  # bare "Base" kept; >=3 -> REAL
        ("ContainerPromptBaseImpl_CCAF", "ContainerPromptBase"),  # "Impl" stripped, "Base" kept
    ]
    fails = []
    for name, want in cases:
        got = _residual(name)
        if got != want:
            fails.append((name, want, got))
    if fails:
        print(f"FAIL: residual extraction drifted:")
        for name, want, got in fails:
            print(f"  {name!r}: expected residual {want!r}, got {got!r}")
        return False
    print(f"PASS: residual extraction matches on {len(cases)} cases")
    return True


def run_boundary_regression():
    """Pin the next-VA function boundary that fixed the callee-overrun bug.

    The bug: a fixed-size disasm window with no next-method ceiling ran past a
    `ret` that had no trailing int3/nop padding, straight into the adjacent
    function, and miscounted ITS calls as the current class's callees. This
    inflated domain-callee counts for three rounds (TextCodec read Encoding x28
    instead of the true x7) because the discovery sweep and its verifier each
    kept a private copy of the boundary logic and drifted together.

    Synthetic, dump-free: function A = `xor eax,eax; ret` with NO padding, placed
    immediately before function B = `call rel32`. With the next-VA ceiling, A's
    disassembly must stop at B's start and see zero calls; without it, A overruns
    and steals B's call. Also guards that both tools import the one shared
    iter_func rather than redefining it."""
    try:
        from capstone import Cs, CS_ARCH_X86, CS_MODE_64
    except ImportError:
        print("SKIP: capstone not installed, cannot run boundary regression")
        return True
    from callgraph_boundary import iter_func, next_va_for

    md = Cs(CS_ARCH_X86, CS_MODE_64); md.detail = True
    base = 0x1000
    # func A at 0x1000: xor eax,eax (31 C0) ; ret (C3)  -> 3 bytes, no padding
    # func B at 0x1003: call rel32 (E8 00 00 00 00)     -> a call A must NOT see
    code = bytes([0x31, 0xC0, 0xC3, 0xE8, 0x00, 0x00, 0x00, 0x00])
    all_vas = [base, base + 3]  # A and B are both known method starts
    next_va = next_va_for(all_vas, base)
    fails = []
    if next_va != base + 3:
        fails.append(f"next_va_for returned {next_va:#x}, expected {base+3:#x}")

    # With the boundary: A stops at B's start, sees no `call`.
    bounded = [i.mnemonic for i in iter_func(md, code, base, next_va)]
    if "call" in bounded:
        fails.append(f"bounded disasm overran into next function: {bounded}")

    # Without the boundary (next_va=None): A overruns and DOES see the call —
    # this is the bug we are guarding against; asserting it confirms the test
    # actually exercises the overrun path rather than passing vacuously.
    unbounded = [i.mnemonic for i in iter_func(md, code, base, None)]
    if "call" not in unbounded:
        fails.append(f"unbounded disasm unexpectedly did NOT overrun: {unbounded} "
                     f"(test would pass vacuously)")

    # Both call-graph tools must use the shared module, not a private iter_func.
    tools_src = Path(__file__).resolve().parent
    for fn in ("sweep_weak_callees.py", "verify_callgraph_precision.py"):
        src = (tools_src / fn).read_text(encoding="utf-8")
        if "from callgraph_boundary import" not in src:
            fails.append(f"{fn} does not import from callgraph_boundary")
        if "\ndef iter_func(" in src:
            fails.append(f"{fn} still defines its own iter_func (drift risk)")

    if fails:
        print("FAIL: next-VA boundary regression:")
        for f in fails:
            print(f"  {f}")
        return False
    print("PASS: next-VA boundary stops overrun (Encoding x7 not x28) and both "
          "tools share one iter_func")
    return True


def run_sweep_fingerprint():
    """Guard the callgraph sweep's intermediate product against silent drift.

    output/weak_class_callees.json is the slow-to-regenerate result of scanning
    the 700MB dump. A re-run on a changed dump/boundary could quietly produce a
    different set of names while every other test still passes (they read the
    deobfuscated dump, not this intermediate). Pin it: rescore the raw callees
    with the committed VERIFIED/DORMANT map (the same score_proposals the
    pipeline uses) and require the locked distribution — 11 named instances
    across exactly the 6 VERIFIED templates, no DORMANT template firing. Dump-
    free: reads only the committed JSON. Skips cleanly if the file is absent."""
    callees_path = BASE / "output" / "weak_class_callees.json"
    if not callees_path.exists():
        print("SKIP: weak_class_callees.json not present, cannot fingerprint sweep")
        return True
    try:
        from propose_callee_names import score_proposals, VERIFIED, DORMANT
    except ImportError as e:
        print(f"SKIP: cannot import propose_callee_names ({e})")
        return True

    LOCKED = {
        "AnimatorController": 5, "AsyncCompletionSource": 2,
        "CameraController": 1, "CancellableOperation": 1,
        "ApiFileHandler": 1, "PlayerComponent": 1,
    }
    data = json.load(open(callees_path, encoding="utf-8"))
    _, by_template = score_proposals(data)
    got = dict(by_template)
    fails = []
    if got != LOCKED:
        fails.append(f"sweep distribution drifted: got {got}, locked {LOCKED}")
    total = sum(got.values())
    if total != 11:
        fails.append(f"named instance count = {total}, locked 11")
    dormant_names = {tmpl for tmpl, _ in DORMANT.values()}
    fired_dormant = set(got) & dormant_names
    if fired_dormant:
        fails.append(f"DORMANT template(s) fired: {sorted(fired_dormant)} — "
                     f"promote to VERIFIED or investigate boundary regression")
    if fails:
        print("FAIL: sweep fingerprint:")
        for f in fails:
            print(f"  {f}")
        return False
    print(f"PASS: sweep fingerprint = 11 instances across 6 VERIFIED templates "
          f"(no DORMANT fired)")
    return True


def run_live_consistency():
    """Recompute coverage from the dump with this criterion; must match the
    committed coverage_stats.json (catches the criterion silently diverging from
    what produced the published number)."""
    if not STATS.exists():
        print("SKIP: coverage_stats.json not present, cannot cross-check")
        return True
    stats = json.load(open(STATS, encoding="utf-8"))
    dump_path = BASE / "output" / "deobfuscated_dump.json"
    if not dump_path.exists():
        print("SKIP: deobfuscated_dump.json not present, cannot cross-check")
        return True
    dump = json.load(open(dump_path, encoding="utf-8"))
    obf = sem = 0
    src_named = {}  # original_name -> [is_named flags], for generic dedup check
    for cl in dump["namespaces"].values():
        if not isinstance(cl, list):
            continue
        for c in cl:
            if not c.get("original_name"):
                continue
            obf += 1
            named = not is_weak_name(c["name"])
            if named:
                sem += 1
            src_named.setdefault(c["original_name"], []).append(named)
    want_obf = stats["classes"]["obfuscated"]
    want_sem = stats["classes"]["semantic"]
    if (obf, sem) != (want_obf, want_sem):
        print(f"FAIL: live recount ({sem}/{obf}) != committed "
              f"({want_sem}/{want_obf}) — criterion diverged from published stats")
        return False
    print(f"PASS: live recount {sem}/{obf} == committed coverage_stats.json")

    # Source-type-level (generic-dedup) consistency. Only checked if the
    # committed stats carry the dedup fields (added 2026-06).
    cls = stats["classes"]
    if "source_types" in cls:
        src_total = len(src_named)
        src_sem = sum(1 for f in src_named.values() if sum(f) > len(f) / 2)
        if (src_total, src_sem) != (cls["source_types"], cls["source_types_semantic"]):
            print(f"FAIL: dedup recount ({src_sem}/{src_total}) != committed "
                  f"({cls['source_types_semantic']}/{cls['source_types']}) — "
                  f"generic-dedup metric diverged")
            return False
        print(f"PASS: dedup recount {src_sem}/{src_total} source types "
              f"== committed coverage_stats.json")
    return True


def main():
    ok = all([run_golden(), run_residual_spotcheck(),
              run_boundary_regression(), run_sweep_fingerprint(),
              run_live_consistency()])
    print("\n" + ("ALL GREEN — criterion locked" if ok else "DRIFT DETECTED"))
    return 0 if ok else 1


if __name__ == "__main__":
    sys.exit(main())
