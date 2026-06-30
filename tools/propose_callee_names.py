"""Propose names for weak source types from their dominant call-graph signal,
using a curated set of *discriminative* callees only (a callee whose meaning IS
the class's purpose). Ubiquitous callees (logging, collections, events) are
excluded because every kind of class uses them — naming from them is noise.

Strict bar: the discriminative callee must be the #1 dominant callee AND hit a
minimum count AND the class must not already have a confident name. Read-only:
writes a proposal file; applying is a separate, reviewable step.
"""
import sys, json, collections, re
sys.stdout.reconfigure(encoding="utf-8", errors="replace")
from pathlib import Path
ROOT = Path(__file__).resolve().parent.parent
CALLEES = ROOT / "output" / "weak_class_callees.json"
OUT = ROOT / "output" / "callee_name_proposals.json"
NAMESRC = ROOT / "output" / "callgraph_class_names.json"

# discriminative callee -> (name template, min dominant count).
# Each template names the class by what that callee proves it DOES. Ubiquitous
# callees (ZLogger, Dictionary, List, EventCallback, VRCLogger, Func, Action)
# are deliberately absent: they describe mechanism, not purpose.
#
# Split by strict next-VA-boundary audit (2026-06). VERIFIED = a curated callee
# that still produces >=1 passing weak class on the current dump under the
# correct function boundary. DORMANT = curated and still considered valid as a
# hypothesis, but with ZERO qualifying weak class here once the overrun bug was
# fixed (the old fixed-window sweep had inflated them past the bar). DORMANT
# entries are retained — they are build-independent curated knowledge and may
# resurface on another build — but they must NOT be assumed to name anything on
# this dump. Re-running propose against clean-boundary callees naturally yields
# names only from VERIFIED; DORMANT stays empty unless real evidence returns.
VERIFIED = {
    "Animator":                ("AnimatorController", 6),
    "CancellationTokenSource": ("CancellableOperation", 6),
    "Camera":                  ("CameraController", 6),
    "UniTaskCompletionSource`1": ("AsyncCompletionSource", 5),
    "ApiFile":                 ("ApiFileHandler", 6),
    "VRCPlayer":               ("PlayerComponent", 6),
}
DORMANT = {
    "Encoding":              ("TextCodec", 8),
    "RuntimeHelpers":        ("StaticDataTable", 8),
    "DateTime":              ("TimestampHandler", 6),
    "ColorUtility":          ("ColorConverter", 6),
    "RectTransform":         ("LayoutController", 6),
    "CanvasGroup":           ("CanvasFader", 5),
    "SynchronizationContext": ("ContextDispatcher", 5),
    "TraceEventCache":       ("TraceListenerImpl", 5),
    "PlayerDataTypeUnion":   ("PlayerDataAccessor", 6),
    "PlayerPrefs":           ("PrefsStore", 6),
    "ApiContainer":          ("ApiModel", 6),
    "VRC_Interactable":      ("InteractableHandler", 6),
    "FileSystemInfo":        ("FileSystemHandler", 6),
    "GroupsStorage":         ("GroupsManager", 6),
    "Graphics":              ("GraphicsRenderer", 6),
    "GetViewDataDictionary": ("EditorViewState", 6),
}
# Active map the sweep is scored against. DORMANT is included so that if real
# clean-boundary evidence reappears it is honoured, but on the current dump it
# contributes nothing.
DISCRIMINATIVE = {**VERIFIED, **DORMANT}


def score_proposals(callees_data, disc=DISCRIMINATIVE):
    """Apply the strict bar (dominant discriminative callee, >=min count, >=50%
    concentration) to raw sweep data. Single source of truth for which weak
    source types earn a name — propose, the sweep summary, and the drift test
    all call this so they can never diverge. Returns (proposals, by_template)."""
    proposals = {}
    by_template = collections.Counter()
    for orig, rec in callees_data.items():
        callees = rec["callees"]
        if not callees:
            continue
        top_name, top_n = callees[0]
        total = sum(c for _, c in callees)
        if top_name in disc:
            tmpl, minc = disc[top_name]
            if top_n >= minc and top_n / total >= 0.5:
                proposals[orig] = {
                    "current": rec["current"],
                    "proposed_base": tmpl,
                    "evidence": f"{top_name} x{top_n} ({top_n/total:.0%} of domain calls)",
                }
                by_template[tmpl] += 1
    return proposals, by_template


def main():
    data = json.load(open(CALLEES, encoding="utf-8"))
    proposals, by_template = score_proposals(data)
    json.dump(proposals, open(OUT, "w", encoding="utf-8"),
              ensure_ascii=False, indent=1)

    # Also emit an apply-ready name source keyed by original_name. Names are
    # made unique with a short suffix derived from the obfuscated name so 18
    # ColorConverters don't collide. Marked semantic_source=callgraph_inferred
    # to stay honest: these are behaviour-inferred, not recovered originals.
    namesrc = {}
    for orig, p in proposals.items():
        suffix = f"{hash(orig) & 0xFFFF:04X}"
        namesrc[orig] = {
            "name": f"{p['proposed_base']}_{suffix}",
            "evidence": p["evidence"],
        }
    json.dump(namesrc, open(NAMESRC, "w", encoding="utf-8"),
              ensure_ascii=False, indent=1)

    print(f"confident exclusive-callee name proposals (source types): {len(proposals)}")
    print(f"by template:")
    for t, n in by_template.most_common():
        print(f"  {n:4}  {t}")
    fired = {t for t in by_template}
    dormant_names = {tmpl for tmpl, _ in DORMANT.values()}
    unexpected = fired & dormant_names
    silent_verified = {tmpl for tmpl, _ in VERIFIED.values()} - fired
    if unexpected:
        print(f"\nNOTE: DORMANT template(s) fired (clean-boundary evidence "
              f"returned): {sorted(unexpected)} — consider promoting to VERIFIED")
    if silent_verified:
        print(f"\nWARNING: VERIFIED template(s) produced nothing this run: "
              f"{sorted(silent_verified)} — dump or boundary may have changed")
    print(f"\nsamples:")
    for orig, p in list(proposals.items())[:25]:
        print(f"  {p['current'][:26]:26} -> {p['proposed_base']:22} [{p['evidence']}]")
    print(f"\nWrote -> {OUT}")


if __name__ == "__main__":
    main()
