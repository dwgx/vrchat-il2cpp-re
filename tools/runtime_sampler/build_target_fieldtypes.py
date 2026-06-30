#!/usr/bin/env python3
"""Build a per-target field-type map for the runtime instance-value sampler.

The sampler reads each weak class's instance fields. To read a slot correctly it
must know the field's STATIC type (is f_3B6 an Il2CppString? an object pointer to
follow? a raw numeric value?). This tool resolves that type for every one of the
4282 weak targets and assigns each field a SAMPLING CLASS the sampler can act on.

WHERE THE TYPE INFO COMES FROM
------------------------------
Three candidate inputs were inspected:
  * output/field_types_from_metadata.json -- UNUSABLE. jun26 global-metadata is
    encrypted, so this dump is garbage: empty names, wild type indices. Skipped.
  * output/field_type_signal.json -- DERIVED from the typed dump (only the
    discriminative-type subset, keyed by current/obf name). A digest, not the
    source. Not used as the primary join.
  * data/precise_dump_unity6_typed.json -- THE SOURCE. Per class it carries
    `field_types`: { field_obf_name -> resolved type string } produced by the
    Unity 6 reverse extractor (FieldInfo Il2CppType @ FI+0x10, klass byval map
    @ klass+0x20). This is the only input with resolvable per-field static types.

THE JOIN (two hops, because VAs are not stable across dump sessions)
--------------------------------------------------------------------
  target.va  --(precise_dump.json, same dump session as targets)-->  obf class
  obf class name  --(typed dump, obf NAME is the stable cross-session key)-->
      field_types{ field_obf_name -> type }

The target list uses DEOBFUSCATED display names ('Struct2f_B46C', ...) and runtime
VAs from VRChat_32984_20260629_180349_full.dmp; precise_dump.json is the matching
session, so target.va resolves there to the still-obfuscated class. The typed dump
is a different session (different VAs) but field/class obfuscated names are stable,
so we re-key by obf class name to pull resolved field types. Verified: all 4282
target VAs resolve in precise_dump.json; 2703/3543 distinct names carry field_types.

OFFSETS
-------
No available input carries true runtime byte offsets (both source minidumps are
gone, and the typed/precise dumps store fields as ordered name lists with no
offset). The runtime samplers (memscan_sampler.js / hybrid_sampler.js) read the
LIVE FieldInfo offset themselves via VRC.klassGetFields at sample time -- that is
the authoritative offset. We therefore emit a best-effort ESTIMATED offset by
walking field sizes from a fixed object header (0x10), purely as an ordering hint;
each field is flagged offset_estimated=true. The sampler must trust its live
FieldInfo.offset, not this estimate, when both are present.

OUTPUT  (output/p2_research/target_field_types.json, keyed by obf class name)
-----------------------------------------------------------------------------
For every target weak class:
  fields: [ { name, offset (est), offset_estimated, type, sampling_class }, ... ]
where sampling_class is one of:
  STRING -- System.String: read via Il2CppString at the slot.
  OBJECT -- a managed reference (domain class / interface / array / generic
            collection): follow the pointer, read the nested class name.
  VALUE  -- numeric / bool / char / enum / known blittable struct: read raw bytes.
  SKIP   -- generic plumbing (delegates, CancellationToken, Awaiter, Type,
            still-obfuscated unresolvable refs with no naming value): don't sample.
"""

from __future__ import annotations

import argparse
import json
import sys
from collections import Counter
from pathlib import Path

sys.stdout.reconfigure(encoding="utf-8", errors="replace")

BASE_DIR = Path(__file__).resolve().parent.parent.parent
DEFAULT_TARGETS = BASE_DIR / "output" / "p2_research" / "runtime_sample_targets.json"
DEFAULT_PRECISE = BASE_DIR / "data" / "precise_dump.json"
DEFAULT_TYPED = BASE_DIR / "data" / "precise_dump_unity6_typed.json"
DEFAULT_OUT = BASE_DIR / "output" / "p2_research" / "target_field_types.json"

OBJECT_HEADER = 0x10  # Il2CppObject header (klass ptr + monitor) on x64.
PTR_SIZE = 8

# Beebyte obfuscation alphabet -- a type/field name built from these is still
# obfuscated (no recovered identity), so it carries no naming signal.
_BEEBYTE = set("ÌÍÎÏ")

# Managed value-type primitives (read raw bytes at the slot). Size in bytes for
# the offset estimate; reference types occupy one pointer (8) on x64.
PRIMITIVE_SIZES = {
    "Boolean": 1, "SByte": 1, "Byte": 1,
    "Char": 2, "Int16": 2, "UInt16": 2,
    "Int32": 4, "UInt32": 4, "Single": 4,
    "Int64": 8, "UInt64": 8, "Double": 8,
    "IntPtr": 8, "UIntPtr": 8,
}

# Known blittable Unity/system structs read as raw VALUE bytes (not followed).
VALUE_STRUCTS = {
    "UnityEngine.Vector2": 8, "UnityEngine.Vector3": 12, "UnityEngine.Vector4": 16,
    "UnityEngine.Quaternion": 16, "UnityEngine.Color": 16, "UnityEngine.Color32": 4,
    "UnityEngine.Vector2Int": 8, "UnityEngine.Vector3Int": 12,
    "UnityEngine.Rect": 16, "UnityEngine.Bounds": 24, "UnityEngine.Matrix4x4": 64,
    "System.Guid": 16, "System.DateTime": 8, "System.TimeSpan": 8,
    "System.Decimal": 16,
}

# Generic plumbing reference types: real, resolvable, but near-zero identity
# value for a name-recovery sampler -> SKIP rather than spend a pointer follow.
SKIP_TYPE_PREFIXES = (
    "System.Action", "System.Func", "System.Predicate", "System.Comparison",
    "System.EventHandler", "System.Threading.CancellationToken",
    "System.Threading.Tasks.Task", "System.Type", "System.Delegate",
    "System.MulticastDelegate", "System.WeakReference",
    "Cysharp.Threading.Tasks.UniTask",
    "Cysharp.Threading.Tasks.CompilerServices.",
    "Awaiter", "<>c", "<genericparam>", "<genericinst>",
)


def norm_va(v: object) -> int | None:
    if isinstance(v, str):
        try:
            return int(v, 16)
        except ValueError:
            return None
    if isinstance(v, int):
        return v
    return None


def is_obfuscated(name: str) -> bool:
    return bool(name) and any(ch in _BEEBYTE for ch in name)


def base_type(t: str) -> str:
    """Strip generic args and array suffix to the head type token."""
    head = t.split("<", 1)[0]
    head = head.rstrip("[]").rstrip("*")
    return head


def short_name(t: str) -> str:
    return base_type(t).split(".")[-1]


def classify(type_name: str, enum_names: set[str], known_value_types: set[str]):
    """Return (sampling_class, est_size_bytes) for a resolved field type string.

    enum_names / known_value_types are sets of obf-or-real class names known from
    the typed dump's parent chain (Enum -> VALUE, ValueType -> VALUE struct).
    """
    if not type_name:
        return "SKIP", PTR_SIZE

    head = base_type(type_name)
    leaf = head.split(".")[-1]

    # Arrays / generic collections are reference types -> OBJECT (follow pointer).
    is_array = type_name.endswith("[]")

    # System.String -> STRING.
    if type_name == "String" or head == "System.String":
        return "STRING", PTR_SIZE

    # Primitive value types -> VALUE (raw bytes), unless it's an array of them.
    if not is_array and leaf in PRIMITIVE_SIZES:
        return "VALUE", PRIMITIVE_SIZES[leaf]

    # Object base / boxed -> follow as OBJECT (header gives nested class name).
    if type_name in ("Object", "System.Object"):
        return "OBJECT", PTR_SIZE

    # Known blittable structs -> VALUE.
    if not is_array and head in VALUE_STRUCTS:
        return "VALUE", VALUE_STRUCTS[head]

    # Enums resolved via parent chain -> VALUE (backing int at the slot).
    if not is_array and (head in enum_names or leaf in enum_names):
        return "VALUE", 4

    # Generic plumbing -> SKIP.
    for pre in SKIP_TYPE_PREFIXES:
        if head.startswith(pre) or type_name.startswith(pre):
            return "SKIP", PTR_SIZE

    # Still-obfuscated, unresolvable reference with no array/collection wrapper
    # and not a known value type -> SKIP (a pointer we can't name).
    if is_obfuscated(type_name) and not is_array:
        if head in known_value_types or leaf in known_value_types:
            return "VALUE", PTR_SIZE  # obf value-type struct, read raw
        return "SKIP", PTR_SIZE

    # Everything else (domain classes, interfaces, arrays, generic collections,
    # MonoBehaviours, Unity components) -> OBJECT (follow pointer, read class).
    return "OBJECT", PTR_SIZE


def load_precise_by_va(path: Path) -> dict[int, dict]:
    data = json.loads(path.read_text(encoding="utf-8"))
    by_va: dict[int, dict] = {}
    for classes in data["namespaces"].values():
        for c in classes:
            va = norm_va(c.get("va"))
            if va is not None:
                by_va[va] = c
    return by_va


def load_typed(path: Path):
    """Return (field_types_by_obf_name, enum_names, value_type_names)."""
    data = json.loads(path.read_text(encoding="utf-8"))
    field_types: dict[str, dict] = {}
    enum_names: set[str] = set()
    value_type_names: set[str] = set()
    for classes in data["namespaces"].values():
        for c in classes:
            name = c.get("name")
            parent = c.get("parent") or ""
            pleaf = parent.split(".")[-1] if isinstance(parent, str) else ""
            if pleaf == "Enum":
                enum_names.add(name)
            elif pleaf == "ValueType":
                value_type_names.add(name)
            ft = c.get("field_types")
            if ft:
                field_types[name] = ft
    return field_types, enum_names, value_type_names


def build(targets_path, precise_path, typed_path, out_path):
    targets = json.loads(Path(targets_path).read_text(encoding="utf-8"))
    precise_by_va = load_precise_by_va(Path(precise_path))
    typed_ft, enum_names, value_types = load_typed(Path(typed_path))

    result: dict[str, dict] = {}
    seen_names: set[str] = set()

    n_va_hit = 0
    n_with_ft = 0
    n_no_precise = 0
    n_no_typed = 0
    total_fields = 0
    typed_fields = 0
    sc_counter: Counter = Counter()
    string_rank: list[tuple[int, int, str, int]] = []  # (n_str, n_typed, name, nfld)

    for t in targets:
        name = t.get("name")
        if name in seen_names:
            continue  # one record per distinct weak class (VAs are instances)
        seen_names.add(name)

        va = norm_va(t.get("va"))
        pcls = precise_by_va.get(va) if va is not None else None
        if pcls is None:
            n_no_precise += 1
            obf_field_names = []
            obf_class_name = None
        else:
            n_va_hit += 1
            obf_class_name = pcls.get("name")
            obf_field_names = list(pcls.get("fields", []))

        ft_map = typed_ft.get(obf_class_name) if obf_class_name else None
        if obf_class_name and ft_map is None:
            n_no_typed += 1
        if ft_map:
            n_with_ft += 1

        fields = []
        est_off = OBJECT_HEADER
        n_str = 0
        n_typed_here = 0
        # Preserve precise_dump field ORDER (matches declaration order the sampler
        # sees); fall back to typed map's order if precise had no field list.
        ordered = obf_field_names if obf_field_names else (
            list(ft_map.keys()) if ft_map else []
        )
        for fname in ordered:
            type_name = ft_map.get(fname) if ft_map else None
            if type_name:
                n_typed_here += 1
                typed_fields += 1
                sampling_class, size = classify(type_name, enum_names, value_types)
                resolved = type_name
            else:
                sampling_class, size = "SKIP", PTR_SIZE
                resolved = "unknown"
            if sampling_class == "STRING":
                n_str += 1
            sc_counter[sampling_class] += 1
            total_fields += 1
            # align estimate to field size (IL2CPP packs by natural alignment)
            align = min(size, PTR_SIZE) if size else PTR_SIZE
            if align > 1 and est_off % align:
                est_off += align - (est_off % align)
            fields.append({
                "name": fname,
                "offset": est_off,
                "offset_estimated": True,
                "type": resolved,
                "sampling_class": sampling_class,
            })
            est_off += size if size else PTR_SIZE

        result[name] = {
            "obf_class_name": obf_class_name,
            "va": t.get("va"),
            "is_dto": t.get("is_dto", False),
            "nfields": t.get("nfields"),
            "callee_hint": t.get("callee_hint", []),
            "has_resolved_types": bool(ft_map),
            "n_string_fields": n_str,
            "fields": fields,
        }
        if n_str:
            string_rank.append((n_str, n_typed_here, name, len(fields)))

    string_rank.sort(reverse=True)

    summary = {
        "total_targets": len(targets),
        "distinct_target_classes": len(seen_names),
        "targets_va_resolved_in_precise": n_va_hit,
        "classes_without_precise_entry": n_no_precise,
        "classes_with_resolved_field_types": n_with_ft,
        "classes_without_typed_entry": n_no_typed,
        "total_fields": total_fields,
        "fields_with_resolved_type": typed_fields,
        "field_type_coverage_pct": round(100.0 * typed_fields / total_fields, 2) if total_fields else 0.0,
        "class_coverage_pct": round(100.0 * n_with_ft / len(seen_names), 2) if seen_names else 0.0,
        "sampling_class_counts": dict(sc_counter),
        "source_type_data": "data/precise_dump_unity6_typed.json (field_types)",
        "join": "target.va -> precise_dump.json (obf class) -> typed dump field_types by obf name",
        "offset_note": "offsets are size-walk ESTIMATES (offset_estimated=true); "
                       "sampler must use live FieldInfo.offset when available.",
        "top_string_rich_classes": [
            {"name": nm, "n_string_fields": ns, "n_typed_fields": nt, "n_fields": nf}
            for ns, nt, nm, nf in string_rank[:30]
        ],
    }

    out = {"summary": summary, "classes": result}
    Path(out_path).parent.mkdir(parents=True, exist_ok=True)
    Path(out_path).write_text(json.dumps(out, ensure_ascii=False, indent=1),
                              encoding="utf-8")
    return summary


def main() -> int:
    ap = argparse.ArgumentParser(
        description=__doc__, formatter_class=argparse.RawDescriptionHelpFormatter)
    ap.add_argument("--targets", default=str(DEFAULT_TARGETS))
    ap.add_argument("--precise", default=str(DEFAULT_PRECISE))
    ap.add_argument("--typed", default=str(DEFAULT_TYPED))
    ap.add_argument("--out", default=str(DEFAULT_OUT))
    args = ap.parse_args()

    s = build(args.targets, args.precise, args.typed, args.out)

    print("=" * 64)
    print("build_target_fieldtypes -- per-target field-type map")
    print("=" * 64)
    print(f"targets (entries):              {s['total_targets']}")
    print(f"distinct target classes:        {s['distinct_target_classes']}")
    print(f"VA-resolved in precise_dump:    {s['targets_va_resolved_in_precise']}")
    print(f"classes WITH resolved types:    {s['classes_with_resolved_field_types']} "
          f"({s['class_coverage_pct']}%)")
    print(f"total fields:                   {s['total_fields']}")
    print(f"fields with resolved type:      {s['fields_with_resolved_type']} "
          f"({s['field_type_coverage_pct']}%)")
    print(f"sampling-class breakdown:       {s['sampling_class_counts']}")
    print(f"STRING-classified fields:       {s['sampling_class_counts'].get('STRING', 0)}")
    print()
    print("Top 15 string-rich target classes (best initial sampling candidates):")
    for r in s["top_string_rich_classes"][:15]:
        print(f"  {r['n_string_fields']:>2} str / {r['n_fields']:>2} fields  {r['name']}")
    return 0


if __name__ == "__main__":
    sys.exit(main())
