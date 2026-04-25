#!/usr/bin/env python3
"""
identify_components_ida.py - Identify ~75 unidentified ComplexComponent classes
using IDA binary analysis data (string refs, call graphs, field types, structural fingerprinting).

Method pointers from the runtime dump don't exactly match IDA function start addresses
(IL2CPP trampolines, ASLR alignment differences). We use binary search to find the
containing IDA function for each method pointer.

Usage: python tools/identify_components_ida.py
"""

import json
import sys
import re
import bisect
import time
from pathlib import Path
from collections import Counter, defaultdict
from datetime import datetime

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).resolve().parent.parent
GA_BASE = 0x7FFB4DCC0000
IDA_BASE = 0x180000000

# Maximum distance (bytes) between a method pointer and an IDA function start
# to consider them the same function. IL2CPP methods typically start within
# a few hundred bytes of the IDA-recognized function entry.
MAX_FUNC_DISTANCE = 0x200

# ── Category keyword mappings ──────────────────────────────────────────────
CATEGORY_KEYWORDS = {
    "avatar": [
        "avatar", "ik", "bone", "skeleton", "humanoid", "muscle", "finger",
        "hand", "head", "pose", "armature", "blendshape", "morph", "outfit",
        "calibrat", "tracking", "vrik", "fullbody", "fbt", "eyebone",
        "wearable", "pedestal", "AvatarParameter", "playable",
    ],
    "network": [
        "photon", "network", "rpc", "sync", "serialize", "deserializ",
        "packet", "bandwidth", "latency", "reliable", "unreliable",
        "masterclient", "room", "lobby", "matchmak", "region",
        "PhotonView", "PhotonNetwork", "peer", "opcode", "eventcode",
        "buffered", "instantiat", "ownership",
    ],
    "ui": [
        "button", "menu", "canvas", "panel", "scroll", "text", "label",
        "toggle", "slider", "dropdown", "tooltip", "modal", "popup",
        "notification", "hud", "quickmenu", "wingmenu", "actionmenu",
        "uimanager", "inputfield", "layout", "grid", "list", "tab",
        "page", "screen", "widget", "badge", "icon", "image",
    ],
    "audio": [
        "audio", "sound", "voice", "speak", "microphone", "uspeak",
        "volume", "mute", "gain", "spatializer", "listener", "mixer",
        "clip", "frequency", "sample", "bitrate", "opus", "codec",
    ],
    "social": [
        "player", "user", "friend", "trust", "rank", "status", "block",
        "mute", "invite", "group", "instance", "portal", "moderat",
        "report", "favorite", "VRCPlayer", "APIUser", "social",
        "nameplate", "tag", "bio", "profile",
    ],
    "world": [
        "world", "scene", "spawn", "trigger", "udon", "sdk", "loader",
        "teleport", "respawn", "mirror", "pickup", "station", "chair",
        "video", "portal", "descriptor", "VRC_", "environment",
    ],
    "animation": [
        "anim", "playable", "layer", "state", "transition", "parameter",
        "blend", "motion", "clip", "controller", "mecanim", "gesture",
        "emote", "expression", "viseme", "lipsync",
    ],
    "physics": [
        "physics", "collider", "rigidbod", "joint", "raycast", "contact",
        "trigger", "dynbone", "dynamic", "cloth", "spring", "phys",
        "gravity", "velocity", "force",
    ],
    "system": [
        "manager", "singleton", "service", "controller", "handler",
        "registry", "config", "setting", "cache", "pool", "factory",
        "bootstrap", "init", "startup", "lifecycle", "dispose",
        "analytics", "log", "debug", "error", "exception", "telemetry",
    ],
    "api": [
        "api", "http", "request", "response", "endpoint", "token",
        "auth", "session", "cookie", "oauth", "pipeline", "fetch",
        "download", "upload", "rest", "json",
    ],
    "safety": [
        "safety", "eac", "anticheat", "integrity", "protect", "guard",
        "shield", "trust", "verify", "signature", "hash", "encrypt",
    ],
}

# Flatten for quick lookup
ALL_KEYWORDS = {}
for cat, kws in CATEGORY_KEYWORDS.items():
    for kw in kws:
        ALL_KEYWORDS[kw.lower()] = cat


def load_json(path, label):
    """Load JSON with progress."""
    print(f"  Loading {label}...", end=" ", flush=True)
    t0 = time.time()
    with open(path, "r", encoding="utf-8") as f:
        data = json.load(f)
    dt = time.time() - t0
    print(f"done ({dt:.1f}s)")
    return data


def runtime_va_to_ida(va_str):
    """Convert runtime VA hex string to IDA absolute address (int)."""
    va = int(va_str, 16)
    rva = va - GA_BASE
    return IDA_BASE + rva


def runtime_va_to_rva_hex(va_str):
    """Convert runtime VA hex string to RVA hex (for ida_string_refs keys)."""
    va = int(va_str, 16)
    rva = va - GA_BASE
    return hex(rva)


class IDAFunctionLookup:
    """
    Binary-search based lookup for IDA functions.
    Method pointers from the dump don't exactly match IDA function starts,
    so we find the containing function (nearest start addr <= target).
    """

    def __init__(self, ida_functions_dict):
        # Build sorted arrays for binary search
        self._keys_hex = []  # hex string keys matching ida_functions_dict
        self._keys_int = []  # integer addresses for binary search
        self._func_data = ida_functions_dict

        items = [(int(k, 16), k) for k in ida_functions_dict.keys()]
        items.sort(key=lambda x: x[0])
        self._keys_int = [x[0] for x in items]
        self._keys_hex = [x[1] for x in items]

    def find_containing_function(self, ida_addr_int):
        """Find the IDA function that contains the given address.
        Returns (func_hex_key, func_data) or (None, None)."""
        idx = bisect.bisect_right(self._keys_int, ida_addr_int) - 1
        if idx < 0:
            return None, None
        func_addr = self._keys_int[idx]
        distance = ida_addr_int - func_addr
        if 0 <= distance <= MAX_FUNC_DISTANCE:
            key = self._keys_hex[idx]
            return key, self._func_data[key]
        return None, None

    def find_nearest(self, ida_addr_int):
        """Find the nearest IDA function (by start address) to the given address.
        Returns (func_hex_key, distance, func_data) or (None, None, None)."""
        idx = bisect.bisect_left(self._keys_int, ida_addr_int)
        best_dist = float("inf")
        best_idx = -1
        for i in [idx - 1, idx]:
            if 0 <= i < len(self._keys_int):
                d = abs(self._keys_int[i] - ida_addr_int)
                if d < best_dist:
                    best_dist = d
                    best_idx = i
        if best_idx >= 0:
            key = self._keys_hex[best_idx]
            return key, best_dist, self._func_data[key]
        return None, None, None


def classify_strings(strings):
    """Classify a list of strings into categories and extract meaningful ones."""
    categories = Counter()
    meaningful = []
    for s in strings:
        s_stripped = s.strip()
        if len(s_stripped) < 3 or len(s_stripped) > 200:
            continue
        if re.match(r'^[\s\x00-\x1f]+$', s_stripped):
            continue
        if re.match(r'^[0-9a-fA-F]+$', s_stripped) and len(s_stripped) < 8:
            continue
        if s_stripped in ('H', ' ', '\t', '\n', 'null', 'true', 'false'):
            continue

        s_lower = s_stripped.lower()
        matched = False
        for kw, cat in ALL_KEYWORDS.items():
            if kw in s_lower:
                categories[cat] += 1
                matched = True
                break
        if matched or len(s_stripped) > 4:
            meaningful.append(s_stripped)
    return categories, meaningful


def suggest_name_from_strings(meaningful_strings, categories):
    """Try to derive a suggested name from string evidence."""
    name_patterns = []
    for s in meaningful_strings:
        # "get_XXX" / "set_XXX" patterns
        m = re.match(r'(?:get|set)_(\w+)', s)
        if m:
            name_patterns.append(m.group(1))
        # "Failed to XXX" / "Cannot XXX" patterns
        m = re.match(r'(?:Failed to|Cannot|Unable to|Error in)\s+(\w+)', s)
        if m:
            name_patterns.append(m.group(1))
        # CamelCase names that look like class/type names
        if re.match(r'^[A-Z][a-zA-Z0-9]{4,30}$', s):
            name_patterns.append(s)

    if name_patterns:
        c = Counter(name_patterns)
        return c.most_common(1)[0][0]
    return None


def build_method_pointer_index(dump, ida_lookup):
    """Build reverse index: IDA function hex key -> list of (class_name, method_name, namespace).
    Uses binary search to match dump VAs to IDA function starts."""
    idx = defaultdict(list)
    matched = 0
    total = 0
    for ns_name, class_list in dump["namespaces"].items():
        for cls in class_list:
            cname = cls["name"]
            for mname, va_str in cls.get("method_pointers", {}).items():
                total += 1
                try:
                    ida_addr = runtime_va_to_ida(va_str)
                    if not (IDA_BASE <= ida_addr <= IDA_BASE + 0xA000000):
                        continue
                    func_key, func_data = ida_lookup.find_containing_function(ida_addr)
                    if func_key:
                        idx[func_key].append((ns_name, cname, mname))
                        matched += 1
                except (ValueError, OverflowError):
                    pass
    print(f"  Matched {matched}/{total} method pointers to IDA functions")
    return idx


def main():
    print("=" * 70)
    print("  ComplexComponent Identification via IDA Binary Analysis")
    print("=" * 70)
    print()

    # ── Load data ──────────────────────────────────────────────────────────
    print("[1/7] Loading data sources...")

    dump = load_json(BASE_DIR / "output" / "deobfuscated_dump.json", "deobfuscated_dump.json (30MB)")

    # Collect all ComplexComponent classes
    cc_classes = []
    all_classes_by_name = {}
    for ns_name, class_list in dump["namespaces"].items():
        for cls in class_list:
            cname = cls["name"]
            all_classes_by_name[cname] = cls
            if "ComplexComponent" in cname:
                cls["_namespace"] = ns_name
                cc_classes.append(cls)
    print(f"  Found {len(cc_classes)} ComplexComponent classes")

    name_mapping = load_json(BASE_DIR / "output" / "name_mapping.json", "name_mapping.json")
    reverse_classes = name_mapping.get("reverse_classes", {})

    # ida_string_refs (smaller, load first)
    ida_string_refs = load_json(BASE_DIR / "output" / "ida_string_refs.json", "ida_string_refs.json (6MB)")
    string_ref_funcs = ida_string_refs.get("function_strings", {})

    # ida_analysis (83MB - large)
    ida_analysis = load_json(BASE_DIR / "data" / "ida_analysis.json", "ida_analysis.json (83MB)")
    ida_functions = ida_analysis.get("functions", {})
    ida_func_names = ida_analysis.get("function_names", {})

    # field_types
    field_types = load_json(BASE_DIR / "output" / "field_types.json", "field_types.json (10MB)")
    ft_classes = field_types.get("classes", {})

    # runtime component names (already identified)
    try:
        runtime_ids = load_json(BASE_DIR / "output" / "runtime_component_names.json", "runtime_component_names.json")
        already_identified = {
            ident["deobf_name"]: ident["suggested_name"]
            for ident in runtime_ids.get("identifications", [])
        }
    except FileNotFoundError:
        already_identified = {}
    print(f"  Already identified from runtime: {len(already_identified)}")

    # ── Build IDA function lookup ──────────────────────────────────────────
    print()
    print("[2/7] Building IDA function lookup index (binary search)...")
    t0 = time.time()
    ida_lookup = IDAFunctionLookup(ida_functions)
    print(f"  Indexed {len(ida_functions)} IDA functions ({time.time()-t0:.1f}s)")

    # ── Build method pointer reverse index ─────────────────────────────────
    print()
    print("[3/7] Building method pointer -> IDA function index...")
    t0 = time.time()
    method_ptr_index = build_method_pointer_index(dump, ida_lookup)
    print(f"  Index has {len(method_ptr_index)} unique IDA functions ({time.time()-t0:.1f}s)")

    # Build obfuscated name -> deobf name map for field_types lookup
    obf_to_deobf = {}
    for deobf, obf in reverse_classes.items():
        obf_to_deobf[obf] = deobf

    # Also build IDA string_refs lookup with RVA -> IDA addr mapping
    # ida_string_refs keys are RVA hex strings like "0x2ed0"
    # Convert to IDA addresses for unified lookup
    string_ref_by_ida = {}
    for rva_hex, strs in string_ref_funcs.items():
        try:
            rva = int(rva_hex, 16)
            ida_addr = IDA_BASE + rva
            string_ref_by_ida[ida_addr] = strs
        except ValueError:
            pass

    # ── Analyze each CC ───────────────────────────────────────────────────
    print()
    print("[4/7] Analyzing ComplexComponent classes...")
    print()

    results = []
    total_str_hits = 0
    total_call_hits = 0

    for i, cls in enumerate(cc_classes):
        cc_name = cls["name"]
        method_ptrs = cls.get("method_pointers", {})

        evidence = []
        all_strings = []
        all_calls_known = []
        all_field_hints = []
        cat_scores = Counter()

        # ── A. String Reference Analysis ──────────────────────────────
        for mname, va_str in method_ptrs.items():
            try:
                ida_addr = runtime_va_to_ida(va_str)
                if not (IDA_BASE <= ida_addr <= IDA_BASE + 0xA000000):
                    continue

                # Find containing function in ida_analysis
                func_key, func_data = ida_lookup.find_containing_function(ida_addr)
                if func_data:
                    strs = func_data.get("strings", [])
                    strs = [s for s in strs if s not in ("H", " ", "\t") and len(s) > 2]
                    if strs:
                        all_strings.extend(strs)

                # Also check ida_string_refs using nearest-match
                # ida_string_refs keys are RVAs, find the one containing our address
                rva = ida_addr - IDA_BASE
                # Try exact RVA first
                rva_hex = hex(rva)
                sr_strs = string_ref_funcs.get(rva_hex, [])
                if sr_strs:
                    all_strings.extend(sr_strs)
                else:
                    # Try nearby RVAs (the function start might differ)
                    if func_key:
                        func_rva = int(func_key, 16) - IDA_BASE
                        sr_strs = string_ref_funcs.get(hex(func_rva), [])
                        if sr_strs:
                            all_strings.extend(sr_strs)

            except (ValueError, OverflowError):
                pass

        # Deduplicate strings
        all_strings = list(dict.fromkeys(all_strings))

        if all_strings:
            total_str_hits += 1
            cats, meaningful = classify_strings(all_strings)
            cat_scores += cats
            if meaningful:
                evidence.append(f"string_refs ({len(meaningful)}): {', '.join(meaningful[:10])}")

        # ── B. Call Graph Analysis ────────────────────────────────────
        for mname, va_str in method_ptrs.items():
            try:
                ida_addr = runtime_va_to_ida(va_str)
                if not (IDA_BASE <= ida_addr <= IDA_BASE + 0xA000000):
                    continue

                func_key, func_data = ida_lookup.find_containing_function(ida_addr)
                if func_data and "calls" in func_data:
                    for call_target_hex in func_data["calls"]:
                        # Look up call target in our method pointer index
                        targets = method_ptr_index.get(call_target_hex, [])
                        if not targets:
                            # Try finding the containing function for the call target
                            try:
                                call_addr = int(call_target_hex, 16)
                                ct_key, _ = ida_lookup.find_containing_function(call_addr)
                                if ct_key:
                                    targets = method_ptr_index.get(ct_key, [])
                            except ValueError:
                                pass

                        for tns, tcls, tmeth in targets:
                            if tcls == cc_name:
                                continue
                            if re.match(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$', tcls):
                                continue
                            call_desc = f"{tcls}::{tmeth}"
                            all_calls_known.append(call_desc)
                            target_lower = tcls.lower()
                            for kw, cat in ALL_KEYWORDS.items():
                                if kw in target_lower:
                                    cat_scores[cat] += 2
                                    break
            except (ValueError, OverflowError):
                pass

        all_calls_known = list(dict.fromkeys(all_calls_known))
        if all_calls_known:
            total_call_hits += 1
            evidence.append(f"calls ({len(all_calls_known)}): {', '.join(all_calls_known[:10])}")

        # ── C. Field Type Analysis ────────────────────────────────────
        # Look up by obfuscated name in field_types
        obf_name = reverse_classes.get(cc_name, "")
        ft_entry = ft_classes.get(obf_name)
        if ft_entry:
            for field in ft_entry.get("fields", []):
                ftype = field.get("type", "") if isinstance(field, dict) else str(field)
                if ftype and not re.match(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$', ftype):
                    all_field_hints.append(ftype)
                    ftype_lower = ftype.lower()
                    for kw, cat in ALL_KEYWORDS.items():
                        if kw in ftype_lower:
                            cat_scores[cat] += 1
                            break

        # Also check dump fields
        for field in cls.get("fields", []):
            if isinstance(field, dict):
                ftype = field.get("type", "")
            elif isinstance(field, str):
                ftype = field
            else:
                continue
            if ftype and not re.match(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$', ftype):
                all_field_hints.append(ftype)
                ftype_lower = ftype.lower()
                for kw, cat in ALL_KEYWORDS.items():
                    if kw in ftype_lower:
                        cat_scores[cat] += 1
                        break

        all_field_hints = list(dict.fromkeys(all_field_hints))
        if all_field_hints:
            evidence.append(f"field_types: {', '.join(all_field_hints[:10])}")

        # ── D. Structural Fingerprinting ──────────────────────────────
        parent = cls.get("parent", "")
        method_count = len(cls.get("methods", []))
        field_count = len(cls.get("fields", []))
        methods = cls.get("methods", [])

        struct_hints = []
        if parent and parent != "Object":
            struct_hints.append(f"parent={parent}")
            parent_lower = parent.lower()
            for kw, cat in ALL_KEYWORDS.items():
                if kw in parent_lower:
                    cat_scores[cat] += 1
                    break

        # Check for known Unity lifecycle methods
        unity_methods = {"Awake", "Start", "Update", "LateUpdate", "FixedUpdate",
                         "OnEnable", "OnDisable", "OnDestroy", "OnGUI",
                         "OnTriggerEnter", "OnTriggerExit", "OnCollisionEnter"}
        found_unity = [m for m in methods if m in unity_methods]
        if found_unity:
            struct_hints.append(f"unity_lifecycle: {', '.join(found_unity)}")

        # Check for serialization methods
        serial_methods = {"Serialize", "Deserialize", "OnSerialize", "OnDeserialize",
                          "OnPhotonSerializeView"}
        found_serial = [m for m in methods if m in serial_methods]
        if found_serial:
            struct_hints.append(f"serialization: {', '.join(found_serial)}")
            cat_scores["network"] += 2

        # Event handler / callback patterns
        if any("OnEvent" in m for m in methods):
            struct_hints.append("event_handler")
        if any("Callback" in m for m in methods if not m.startswith("m_")):
            struct_hints.append("callbacks")

        struct_hints.append(f"methods={method_count}, fields={field_count}")
        evidence.append(f"structure: {'; '.join(struct_hints)}")

        # ── E. Cross-Reference with Runtime IDs ───────────────────────
        if cc_name in already_identified:
            evidence.insert(0, f"runtime_identified: {already_identified[cc_name]}")
            rt_name = already_identified[cc_name].lower()
            for kw, cat in ALL_KEYWORDS.items():
                if kw in rt_name:
                    cat_scores[cat] += 5
                    break

        # ── F. IDA Function Name Analysis ─────────────────────────────
        # Check if any method has a named function in IDA
        for mname, va_str in method_ptrs.items():
            try:
                ida_addr = runtime_va_to_ida(va_str)
                ida_hex = hex(ida_addr)
                # Check function_names
                fname = ida_func_names.get(ida_hex, "")
                if fname and not fname.startswith("sub_") and not fname.startswith("unknown_"):
                    evidence.append(f"ida_name: {mname} = {fname}")
                    # Extract meaningful parts
                    for kw, cat in ALL_KEYWORDS.items():
                        if kw in fname.lower():
                            cat_scores[cat] += 3
                            break
            except (ValueError, OverflowError):
                pass

        # ── Determine category and confidence ─────────────────────────
        if cat_scores:
            top_cat = cat_scores.most_common(1)[0][0]
            top_score = cat_scores.most_common(1)[0][1]
        else:
            top_cat = "unknown"
            top_score = 0

        # Determine confidence
        evidence_types = sum([
            1 if all_strings else 0,
            1 if all_calls_known else 0,
            1 if all_field_hints else 0,
            1 if cc_name in already_identified else 0,
        ])
        total_score = sum(cat_scores.values())

        if cc_name in already_identified:
            confidence = "high"
        elif total_score >= 8 and evidence_types >= 2:
            confidence = "high"
        elif total_score >= 3 or evidence_types >= 2:
            confidence = "medium"
        elif total_score >= 1:
            confidence = "low"
        else:
            confidence = "none"

        # ── Suggest name ──────────────────────────────────────────────
        # Generic/noise names to skip when suggesting
        GENERIC_PREFIXES = (
            "Static", "AsyncStateMachine", "BaseClass", "ComplexComponent",
            "LifecycleComponent", "UpdateComponent", "Impl", "<>c",
            "LightLambda", "ImmutableHashSet",
        )
        GENERIC_NAMES = {
            "Object", "String", "Boolean", "Single", "Double", "Int32",
            "DateTime", "BuffersImpl", "DependencyInjector", "MonoBehaviour",
            "ValueType", "Enum", "Array", "Delegate", "Attribute",
            "URA", "ePathName117", "ileFullDirectoryInformation",
            "esampleMode", "Varint32SlowPath", "owAlias", "hpClassPrefix",
        }

        def is_meaningful_class_name(name):
            """Check if a class name is meaningful (not a generic deobf pattern)."""
            if not name:
                return False
            for prefix in GENERIC_PREFIXES:
                if name.startswith(prefix):
                    return False
            if name in GENERIC_NAMES:
                return False
            # Skip names that are just hex suffixes or obfuscated
            if re.match(r'^[a-z_]+$', name):
                return False
            if re.match(r'^[\u00CC\u00CD\u00CE\u00CF]', name):
                return False
            return True

        suggested = None
        if cc_name in already_identified:
            suggested = already_identified[cc_name]
        else:
            # 1. Try string-based name suggestion
            if all_strings:
                _, meaningful = classify_strings(all_strings)
                # Look for Unity API patterns that reveal purpose
                unity_api_hints = []
                for s in all_strings:
                    # "UnityEngine.XXX::method" -> extract XXX
                    m = re.match(r'UnityEngine\.(\w+)(?:::|/)', s)
                    if m:
                        comp = m.group(1)
                        if comp not in ("Object", "Component", "MonoBehaviour",
                                        "Debug", "Application"):
                            unity_api_hints.append(comp)
                    # "VRC.XXX" or "VRChat.XXX" patterns
                    m = re.match(r'VRC(?:hat)?\.(\w+)', s)
                    if m:
                        unity_api_hints.append(m.group(1))

                if unity_api_hints:
                    c = Counter(unity_api_hints)
                    top_api = c.most_common(1)[0][0]
                    count = c.most_common(1)[0][1]
                    if count >= 2:
                        suggested = f"{top_api}Handler"
                    else:
                        suggested = f"{top_api}Related"

                if not suggested:
                    suggested = suggest_name_from_strings(meaningful, cat_scores)

            # 2. Try call-based suggestion (skip generic deobf names)
            if not suggested and all_calls_known:
                called_classes = [c.split("::")[0] for c in all_calls_known]
                meaningful_calls = [c for c in called_classes if is_meaningful_class_name(c)]
                if meaningful_calls:
                    cc_counter = Counter(meaningful_calls)
                    top_called = cc_counter.most_common(1)[0][0]
                    suggested = f"{top_called}Related"

            # 3. Try field-type suggestion (skip noise types)
            if not suggested and all_field_hints:
                for fh in all_field_hints:
                    clean = re.sub(r'[<>\[\]?,.]', ' ', fh).strip().split()
                    for part in clean:
                        if (re.match(r'^[A-Z][a-zA-Z]{4,}$', part)
                                and part not in GENERIC_NAMES
                                and is_meaningful_class_name(part)):
                            suggested = f"{part}Handler"
                            break
                    if suggested:
                        break

            # 4. Fallback: use category + structural hints
            if not suggested and top_cat != "unknown":
                # Add parent hint if meaningful
                if parent and is_meaningful_class_name(parent):
                    suggested = f"{top_cat.capitalize()}_{parent}Child"
                else:
                    suggested = f"{top_cat.capitalize()}Component"

        result = {
            "name": cc_name,
            "suggested_name": suggested,
            "confidence": confidence,
            "evidence": evidence,
            "category": top_cat,
            "string_refs": all_strings[:30],
            "calls_known": all_calls_known[:20],
            "field_types": all_field_hints[:20],
            "parent": parent,
            "method_count": method_count,
            "field_count": field_count,
            "category_scores": dict(cat_scores.most_common()),
        }
        results.append(result)

        if (i + 1) % 10 == 0 or i == len(cc_classes) - 1:
            print(f"  Analyzed {i+1}/{len(cc_classes)} classes "
                  f"(str_hits={total_str_hits}, call_hits={total_call_hits})", flush=True)

    # ── Sort by confidence ────────────────────────────────────────────────
    conf_order = {"high": 0, "medium": 1, "low": 2, "none": 3}
    results.sort(key=lambda r: (conf_order.get(r["confidence"], 9), r["name"]))

    # ── Stats ─────────────────────────────────────────────────────────────
    print()
    print("[5/7] Computing statistics...")

    conf_counts = Counter(r["confidence"] for r in results)
    cat_counts = Counter(r["category"] for r in results)
    identified = [r for r in results if r["confidence"] != "none"]
    unidentified = [r["name"] for r in results if r["confidence"] == "none"]

    stats = {
        "total_cc": len(cc_classes),
        "identified": len(identified),
        "unidentified": len(unidentified),
        "by_confidence": dict(conf_counts),
        "by_category": dict(cat_counts.most_common()),
        "already_runtime_identified": len(already_identified),
        "with_string_refs": sum(1 for r in results if r["string_refs"]),
        "with_call_targets": sum(1 for r in results if r["calls_known"]),
        "with_field_hints": sum(1 for r in results if r["field_types"]),
    }

    # ── Save output ───────────────────────────────────────────────────────
    print()
    print("[6/7] Saving results...")

    output = {
        "generated_by": "identify_components_ida.py",
        "timestamp": datetime.now().strftime("%Y-%m-%d %H:%M:%S"),
        "ga_base": hex(GA_BASE),
        "ida_base": hex(IDA_BASE),
        "stats": stats,
        "identifications": [r for r in results if r["confidence"] != "none"],
        "unidentified": unidentified,
    }

    out_path = BASE_DIR / "output" / "ida_component_analysis.json"
    with open(out_path, "w", encoding="utf-8") as f:
        json.dump(output, f, indent=2, ensure_ascii=False)
    print(f"  Saved to {out_path}")

    # ── Print summary table ───────────────────────────────────────────────
    print()
    print("[7/7] Summary")
    print("=" * 110)
    print(f"  {'CC Name':<45} {'Suggested':<28} {'Conf':<6} {'Cat':<12} {'Str':>4} {'Call':>4} {'Fld':>4}")
    print("-" * 110)

    for r in results:
        sug = (r["suggested_name"] or "-")[:27]
        n_str = len(r["string_refs"])
        n_call = len(r["calls_known"])
        n_fld = len(r["field_types"])
        conf_marker = {
            "high": "[H]", "medium": "[M]", "low": "[L]", "none": "[ ]"
        }.get(r["confidence"], "[ ]")

        print(f"  {r['name']:<45} {sug:<28} {conf_marker:<6} {r['category']:<12} {n_str:>4} {n_call:>4} {n_fld:>4}")

    print("-" * 110)
    print()
    print("Statistics:")
    print(f"  Total ComplexComponents:    {stats['total_cc']}")
    print(f"  Identified (any confidence):{stats['identified']}")
    print(f"  Unidentified:               {stats['unidentified']}")
    print(f"  By confidence: high={conf_counts.get('high',0)}, "
          f"medium={conf_counts.get('medium',0)}, "
          f"low={conf_counts.get('low',0)}, "
          f"none={conf_counts.get('none',0)}")
    print(f"  By category: {', '.join(f'{k}={v}' for k,v in cat_counts.most_common())}")
    print(f"  With string refs:  {stats['with_string_refs']}")
    print(f"  With call targets: {stats['with_call_targets']}")
    print(f"  With field hints:  {stats['with_field_hints']}")
    print()

    # ── Show top findings ─────────────────────────────────────────────────
    high_conf = [r for r in results if r["confidence"] == "high"]
    if high_conf:
        print("High-Confidence Identifications:")
        print("-" * 70)
        for r in high_conf:
            print(f"  {r['name']} -> {r['suggested_name']}")
            for ev in r["evidence"][:3]:
                print(f"    {ev[:100]}")
            print()

    med_conf = [r for r in results if r["confidence"] == "medium"]
    if med_conf:
        print("Medium-Confidence Identifications:")
        print("-" * 70)
        for r in med_conf:
            print(f"  {r['name']} -> {r['suggested_name'] or '?'} [{r['category']}]")
            for ev in r["evidence"][:2]:
                print(f"    {ev[:100]}")
            print()

    print(f"Results saved to: {out_path}")


if __name__ == "__main__":
    main()
