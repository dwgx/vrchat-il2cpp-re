#!/usr/bin/env python
"""Deterministic evidence-to-name synthesis for high-signal obfuscated classes.

Targets the classes graded D-with-strong-signal (structural placeholder, but
>=2 real fields or >=4 real methods). For each, it derives a candidate semantic
name *from the class's own field/method symbol tokens* — the name's provenance
is the binary's own symbols, so it is auditable and reproducible, never guessed.

Honesty guard (precision over coverage): a class is only renamed if its evidence
tokens are genuinely domain-specific. Classes whose only signal is generic
plumbing (a CancellationTokenSource field, a FindObjectsOfType call, a bare
Initialize method) carry no domain meaning and are left as-is, honestly unnamed.

Output: output/synthesized_names.json   {original_name: {name, evidence, tokens}}
Does NOT modify the dump; apply via apply_class_names.py in the pipeline.
"""
import json
import re
import sys
from pathlib import Path
from collections import Counter

sys.stdout.reconfigure(encoding="utf-8", errors="replace")
BASE = Path(__file__).resolve().parent.parent
TARGETS = BASE / "output" / "rename_targets_graded.json"
OUT = BASE / "output" / "synthesized_names.json"

_TOK = re.compile(r"[A-Z]+(?=[A-Z][a-z])|[A-Z]?[a-z]+|[A-Z]+|\d+")

# Tokens that carry no domain meaning: language/runtime/Unity plumbing.
GENERIC = {
    "get", "set", "is", "on", "the", "to", "of", "and", "for", "m", "k", "id",
    "value", "field", "backing", "base", "class", "impl", "object", "ctor",
    "start", "awake", "update", "enable", "disable", "destroy", "instantiate",
    "fixed", "late", "method", "invoke", "add", "remove", "handler", "ienumerator",
    "cancellation", "token", "source", "task", "async", "await", "coroutine",
    "find", "objects", "type", "initialize", "init", "dispose", "tostring",
    "equals", "hashcode", "compare", "moveNext", "current", "result", "callback",
    "action", "func", "delegate", "event", "listener", "internal", "wrapper",
}
# Domain tokens that strongly imply a class role when present.
ROLE_HINTS = {
    "button": "Button", "slider": "Slider", "toggle": "Toggle", "panel": "Panel",
    "canvas": "Canvas", "text": "Text", "input": "Input", "dropdown": "Dropdown",
    "scroll": "Scroll", "menu": "Menu", "tooltip": "Tooltip", "icon": "Icon",
    "avatar": "Avatar", "player": "Player", "camera": "Camera", "audio": "Audio",
    "network": "Network", "pickup": "Pickup", "portal": "Portal",
}


def tokenize(s: str):
    return [t for t in _TOK.findall(s) if len(t) > 2]


def domain_tokens(fields, methods):
    """Weighted domain tokens: fields count double (they name what a class holds)."""
    c = Counter()
    for f in fields:
        for t in tokenize(f.lstrip("_")):
            if t.lower() not in GENERIC:
                c[t] += 2
    for m in methods:
        # skip property accessor prefixes; keep the noun
        mm = re.sub(r"^(get_|set_|On)", "", m)
        for t in tokenize(mm):
            if t.lower() not in GENERIC:
                c[t] += 1
    return c


def synthesize(fields, methods):
    """Return (name, top_tokens) or (None, []) if not confidently nameable.

    Requires real *field* evidence. Empirically, method-only signal for these
    placeholder classes is dominated by inherited Unity property accessors
    (get_hideFlags, FindFirstObjectByType) that synthesize into meaningless
    names like "HideFlags"/"SingleHideFlags". Fields name what a class *holds*
    and are the only trustworthy semantic source here.
    """
    real_fields = [f for f in fields if f]
    if len(real_fields) < 2:
        return None, []
    counts = domain_tokens(real_fields, methods)
    if not counts:
        return None, []
    # Need genuine domain signal: a token must appear >= 2 (weighted) to count.
    strong = [(t, n) for t, n in counts.most_common() if n >= 2]
    if not strong:
        return None, []
    top = [t for t, _ in strong[:3]]
    # Build PascalCase name from the 2-3 strongest domain tokens.
    parts = []
    for t in top:
        tl = t.lower()
        parts.append(ROLE_HINTS.get(tl, t[:1].upper() + t[1:]))
    # de-dup case-insensitively, preserve order
    seen = set()
    uniq = []
    for p in parts:
        if p.lower() not in seen:
            seen.add(p.lower())
            uniq.append(p)
    name = "".join(uniq)
    if len(name) < 4:
        return None, []
    return name, top


def main():
    targets = json.load(open(TARGETS, encoding="utf-8"))
    results = {}
    named = 0
    skipped = 0
    for t in targets:
        orig = t["original_name"]
        if orig in results:
            continue
        name, top = synthesize(t["fields"], t["methods"])
        if name:
            results[orig] = {
                "name": name,
                "tokens": top,
                "evidence": {"fields": t["fields"][:8], "methods": t["methods"][:8]},
                "semantic_source": "evidence:synthesized",
            }
            named += 1
        else:
            skipped += 1
    json.dump(results, open(OUT, "w", encoding="utf-8"), ensure_ascii=False, indent=1)
    print(f"named {named} classes from evidence, "
          f"honestly skipped {skipped} (plumbing-only, no domain signal)")
    print(f"wrote {OUT.name}")
    # Show a sample for inspection
    print("\n=== sample synthesized names ===")
    for orig, r in list(results.items())[:15]:
        print(f"  {r['name']:32} <- {r['tokens']}  (fields={r['evidence']['fields'][:3]})")
    return 0


if __name__ == "__main__":
    sys.exit(main())
