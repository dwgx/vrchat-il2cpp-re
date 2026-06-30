#!/usr/bin/env python
"""Locate the Newtonsoft.Json deserialization hook points by STATIC analysis.

The strongest class-name leak VRChat leaves at runtime is a JSON key: when a DTO
is deserialised, the property names that flow into it (avatarId, performance-
Rating, ...) ARE its real field names. To capture key->class pairs we hook the
Newtonsoft deserialisation path and read (property_name, target_object_class) at
the moment a value is written into an object.

This module finds the concrete methods/addresses worth hooking. It does NOT run
anything against the game; it is pure static triage over three inputs:

  - merged_pseudocode.json   3457 decompiled VRChat methods {class,method,ea,...}
  - steam_symbols.json       195029 runtime symbols  ea -> "Class::Method"
  - runtime_sample_targets.json  4282 target classes, 65 flagged is_dto=true

It emits output/p2_research/json_hook_points.json with two sections:
  1. newtonsoft_core_hooks  the central library methods that, hooked once, see
     every (JsonProperty, target object) pair the deserialiser touches. These
     are LIBRARY methods (Newtonsoft.Json) -- present in the symbol table but
     NOT in VRChat's own pseudocode, so they are sourced from steam_symbols.
  2. per_target_dto         for each is_dto weak class, the subset of its own
     pseudocode methods that look like a JSON (de)serialisation hook -- custom
     JsonConverter.ReadJson, a property setter, a [JsonProperty] accessor.

Why hook the library core instead of every DTO: Newtonsoft funnels ALL object
deserialisation through JsonSerializerInternalReader. SetPropertyValue is called
once per JSON property with (reader, JsonProperty, target) in hand -- one hook
covers all 65 DTOs and every class not yet flagged. The per-target list is the
fallback for classes that supply a custom converter, where the library core
never sees the individual keys.

See JSON_HOOK_DESIGN.md for the internal-flow rationale and the runtime read
strategy at each hook.
"""
import argparse
import json
import re
import sys
from collections import defaultdict
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE = Path(__file__).resolve().parent.parent.parent
P2 = BASE / "output" / "p2_research"
DEFAULT_PC = P2 / "merged_pseudocode.json"
DEFAULT_SYM = P2 / "steam_symbols.json"
DEFAULT_TGT = P2 / "runtime_sample_targets.json"
DEFAULT_OUT = P2 / "json_hook_points.json"

# Newtonsoft library methods to surface as core hooks, each paired with WHY it
# is worth hooking and WHAT a runtime hook can read there. Order = usefulness.
# Matched against the symbol table by exact "Class::Method" string; the binary
# ships two copies of the Newtonsoft assembly (0x186.. and 0x188.. ranges) so a
# name resolves to >=1 ea -- we keep every ea and tag the address range.
CORE_HOOK_SPECS = [
    ("JsonSerializerInternalReader::SetPropertyValue",
     "PRIME HOOK. Called once per JSON property. Args carry the JsonProperty "
     "(-> get_UnderlyingName = the real field name) and the target object being "
     "filled (-> its il2cpp class). One hook = (key, target_class) for every DTO."),
    ("JsonSerializerInternalReader::PopulateObject",
     "Per-object property loop. Holds the target object + its JsonObjectContract "
     "for the whole deserialise of one object; hook to bracket a class's key set."),
    ("JsonSerializerInternalReader::SetPropertyPresence",
     "Records which property was just seen on the target; corroborates the key "
     "stream feeding one object even when SetPropertyValue is short-circuited."),
    ("JsonSerializerInternalReader::CalculatePropertyDetails",
     "Resolves the JsonProperty for the current reader token; reading its "
     "JsonProperty arg gives the key name before the value is materialised."),
    ("JsonSerializerInternalReader::CreateNewObject",
     "Instantiates the target before population. Hook to capture the contract's "
     "CreatedType (the obf class) and tag the object identity for later keys."),
    ("JsonSerializerInternalReader::CreateObject",
     "Outer object-creation dispatch (metadata/$type, converter, plain object); "
     "sees the JsonObjectContract -> CreatedType for the class about to be filled."),
    ("JsonSerializerInternalReader::CreateObjectUsingCreatorWithParameters",
     "Immutable-DTO path: values are passed to a parameterized constructor, so "
     "SetPropertyValue never fires. Hook here for ctor-arg DTOs (record types)."),
    ("JsonSerializerInternalReader::ResolvePropertyAndCreatorValues",
     "Collects (property, value) pairs for the constructor path above; carries "
     "the key names for ctor-populated DTOs that SetPropertyValue would miss."),
    ("JsonSerializerInternalReader::Deserialize",
     "Top of the internal reader. Sees the requested root type; brackets a whole "
     "deserialise call so captured keys can be attributed to one root object."),
    ("JsonConvert::DeserializeObject",
     "Public entry VRChat calls. Coarse, but its Type arg names the requested "
     "root class -- a sanity anchor for the key stream that follows."),
    ("JsonSerializer::Deserialize",
     "Serializer-level entry between JsonConvert and the internal reader; useful "
     "if a call site uses a preconfigured JsonSerializer instead of JsonConvert."),
]

# Accessor symbols a runtime hook READS to turn a raw arg into a name/class.
# These are the helpers the design doc points the hook implementation at.
SUPPORT_SYMS = [
    ("JsonProperty::get_UnderlyingName",
     "JsonProperty arg -> the real (pre-rename) field name = the JSON key."),
    ("JsonProperty::set_PropertyName",
     "Alt key source; the serialised key as it appears on the wire."),
    ("JsonContract::set_CreatedType",
     "Contract -> the il2cpp Type being built = the obf class identity."),
    ("JsonReader::get_ValueType",
     "Reader -> CLR type of the current value, to record value alongside key."),
]

# Signals that a VRChat-owned method participates in JSON (de)serialisation.
# Checked against BOTH the resolved real symbol and the decompiled body.
SETTER_RE = re.compile(r"::set_[A-Za-z0-9_]+$")
GETTER_RE = re.compile(r"::get_[A-Za-z0-9_]+$")
# Body tokens (decompiler leaves Newtonsoft type names in signatures / xrefs).
BODY_JSON_RE = re.compile(
    r"(ReadJson|WriteJson|Json(Reader|Writer|Property|Converter|Contract|"
    r"Serializer)|Deserialize|UnderlyingName|get_CurrentState)", re.I)


def load(path):
    with open(path, "r", encoding="utf-8", errors="replace") as f:
        return json.load(f)


def addr_range(ea):
    """Tag which shipped Newtonsoft copy an address lives in."""
    e = ea.lower()
    if e.startswith("0x186"):
        return "asm_copy_A(0x186)"
    if e.startswith("0x188"):
        return "asm_copy_B(0x188)"
    return "other"


def first_signature(body):
    """The decompiler's name hint: first declaration line of the pseudocode."""
    lines = [l.strip() for l in (body or "").splitlines() if l.strip()]
    # body opens with the return type then the (often Newtonsoft-named) function.
    for l in lines[:4]:
        if l in ("{", "}") or l.startswith(("undefined", "//")):
            continue
        if "(" in l or "__" in l:
            return l[:140]
    return lines[1][:140] if len(lines) > 1 else (lines[0][:140] if lines else "")


def build_core_hooks(symbols):
    """Resolve each curated Newtonsoft method name to its address(es)."""
    by_name = defaultdict(list)
    for ea, name in symbols.items():
        by_name[name].append(ea)

    hooks = []
    for sym, why in CORE_HOOK_SPECS:
        eas = sorted(by_name.get(sym, []))
        if not eas:
            continue
        for ea in eas:
            hooks.append({
                "ea": ea,
                "symbol": sym,
                "range": addr_range(ea),
                "why": why,
            })

    support = []
    for sym, why in SUPPORT_SYMS:
        for ea in sorted(by_name.get(sym, [])):
            support.append({
                "ea": ea, "symbol": sym, "range": addr_range(ea), "why": why,
            })
    return hooks, support


def score_dto_method(real_sym, sig, body):
    """Rank one DTO-owned method as a JSON (de)serialisation hook candidate.

    Returns (score, reasons[]). Higher score = stronger deserialisation signal.
    """
    score = 0.0
    reasons = []
    name = real_sym or ""

    if re.search(r"ReadJson|FromJson|Deserialize", name, re.I) or \
       re.search(r"ReadJson|FromJson|Deserialize", sig, re.I):
        score += 4.0
        reasons.append("name=ReadJson/Deserialize: custom JSON read entry "
                       "(reads each key itself; library core never sees them)")
    if "JsonConverter" in name or "JsonConverter" in sig:
        score += 3.0
        reasons.append("declares JsonConverter: a custom converter for this DTO")
    if SETTER_RE.search(name):
        score += 2.0
        reasons.append("property setter: receives one deserialised field value")
    if re.search(r"UnderlyingName|JsonProperty|JsonContract", name, re.I):
        score += 1.5
        reasons.append("JsonProperty/JsonContract member: carries the wire key")
    if GETTER_RE.search(name) and "Json" in name:
        score += 0.5
        reasons.append("Json* getter: metadata accessor, weak signal")
    if BODY_JSON_RE.search(body or ""):
        score += 1.0
        reasons.append("body references Newtonsoft Json* / UnderlyingName")
    return score, reasons


def build_per_target(targets, pseudocode, symbols):
    symL = {k.lower(): v for k, v in symbols.items()}
    # group pseudocode by owning class
    by_class = defaultdict(list)
    for m in pseudocode:
        by_class[m["class"]].append(m)

    # de-dup the is_dto targets (input repeats each class once per live va)
    dto_seen = {}
    for t in targets:
        if t.get("is_dto"):
            dto_seen.setdefault(t["name"], t)

    out = []
    for name, t in sorted(dto_seen.items()):
        methods = by_class.get(name, [])
        cands = []
        for m in methods:
            ea = m["ea"]
            body = m.get("pseudocode") or ""
            real = symL.get(ea.lower())
            sig = first_signature(body)
            score, reasons = score_dto_method(real, sig, body)
            if score <= 0:
                continue
            cands.append({
                "ea": ea,
                "real_symbol": real or "(unresolved)",
                "score": round(score, 2),
                "why": "; ".join(reasons),
            })
        cands.sort(key=lambda c: c["score"], reverse=True)
        out.append({
            "obf_class": name,
            "callee_hint": t.get("callee_hint", []),
            "n_methods_seen": len(methods),
            "candidate_methods": cands,
        })
    return out


def main():
    ap = argparse.ArgumentParser(description=__doc__,
                                 formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("--pseudocode", type=Path, default=DEFAULT_PC)
    ap.add_argument("--symbols", type=Path, default=DEFAULT_SYM)
    ap.add_argument("--targets", type=Path, default=DEFAULT_TGT)
    ap.add_argument("--out", type=Path, default=DEFAULT_OUT)
    args = ap.parse_args()

    pseudocode = load(args.pseudocode)
    symbols = load(args.symbols)
    targets = load(args.targets)

    core, support = build_core_hooks(symbols)
    per_target = build_per_target(targets, pseudocode, symbols)

    result = {
        "_about": ("Static-analysis hook map for capturing JSON key->class "
                   "leaks via Newtonsoft.Json deserialisation. See "
                   "JSON_HOOK_DESIGN.md."),
        "newtonsoft_core_hooks": core,
        "support_accessors": support,
        "per_target_dto": per_target,
    }
    with open(args.out, "w", encoding="utf-8") as f:
        json.dump(result, f, indent=2, ensure_ascii=False)

    # ---- report ----
    n_core_names = len({h["symbol"] for h in core})
    dtos_with_cands = sum(1 for d in per_target if d["candidate_methods"])
    print(f"wrote {args.out}")
    print(f"core hooks: {len(core)} addresses across {n_core_names} method names "
          f"(2 shipped Newtonsoft copies per name)")
    print(f"support accessors: {len(support)} addresses")
    print(f"per-target DTOs: {len(per_target)} unique is_dto classes, "
          f"{dtos_with_cands} got >=1 candidate method")
    print()
    print("PRIME core hooks:")
    seen = set()
    for h in core:
        if h["symbol"] in seen:
            continue
        seen.add(h["symbol"])
        eas = [c["ea"] for c in core if c["symbol"] == h["symbol"]]
        print(f"  {h['symbol']:<60} {eas}")
    print()
    print("Per-target candidates:")
    for d in per_target:
        top = d["candidate_methods"][:1]
        tag = (f"{top[0]['real_symbol']} @ {top[0]['ea']} (score {top[0]['score']})"
               if top else "(none)")
        print(f"  {d['obf_class']:<40} {len(d['candidate_methods'])} cand  best={tag}")


if __name__ == "__main__":
    main()
