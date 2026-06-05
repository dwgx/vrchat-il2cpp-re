import json
import re
from collections import Counter, defaultdict
from pathlib import Path


ROOT = Path(__file__).resolve().parents[1]
DUMP_PATH = ROOT / "output" / "deobfuscated_dump.json"
MAPPING_PATH = ROOT / "output" / "name_mapping.json"
OUT_PATH = ROOT / "output" / "structural_renames.json"

FALLBACK_RE = re.compile(
    r"^(?:"
    r"EmptyType_[0-9A-F]|"
    r"EmptyStruct_[0-9A-F]|"
    r"AsyncStateMachine_[0-9A-F]|"
    r"Enumerator_[0-9A-F]|"
    r"Delegate_[0-9A-F]|"
    r"LifecycleComponent_[0-9A-F]|"
    r"UpdateComponent_[0-9A-F]|"
    r"ComplexComponent_[0-9A-F]|"
    r"BaseClass\d|"
    r"Unknown\d*m_[0-9A-F]|"
    r"DataOnly(?:_|\d)|"
    r"Static\d+m_[0-9A-F]|"
    r"Record\d*m_[0-9A-F]|"
    r"Type_[0-9A-F]"
    r")"
)

OBF_METHOD_RE = re.compile(r"^m_[0-9A-F]{3}$")
HASH_TAIL_RE = re.compile(r"_[0-9A-F]{12}$")
FALLBACK_WORD_RE = re.compile(
    r"^(?:EmptyType|EmptyStruct|AsyncStateMachine|Enumerator|Delegate|"
    r"LifecycleComponent|UpdateComponent|ComplexComponent|BaseClass\d*|"
    r"Unknown\d*m|DataOnly\d*f?|Static\d*m|Record\d*f?|Type\d*m\d*f?)"
)

STOP_TOKENS = {
    "a",
    "all",
    "alt",
    "and",
    "application",
    "array",
    "async",
    "awake",
    "base",
    "became",
    "bool",
    "boolean",
    "by",
    "callback",
    "callbacks",
    "cancel",
    "cancellation",
    "check",
    "class",
    "clear",
    "code",
    "collision",
    "class",
    "component",
    "components",
    "configure",
    "copy",
    "create",
    "ctor",
    "data",
    "default",
    "destroy",
    "disable",
    "do",
    "enable",
    "enabled",
    "enter",
    "equals",
    "event",
    "exit",
    "field",
    "fixed",
    "from",
    "get",
    "handle",
    "hash",
    "hashcode",
    "impl",
    "in",
    "initialize",
    "instance",
    "internal",
    "invoke",
    "is",
    "late",
    "lifecycle",
    "managed",
    "method",
    "move",
    "next",
    "object",
    "objects",
    "of",
    "on",
    "pause",
    "process",
    "quit",
    "raise",
    "register",
    "related",
    "reset",
    "return",
    "set",
    "sibling",
    "start",
    "state",
    "static",
    "stay",
    "stop",
    "struct",
    "to",
    "trigger",
    "type",
    "unregister",
    "update",
    "value",
    "visible",
    "with",
}

UNITY_LIFECYCLE = {
    "Awake",
    "Start",
    "Update",
    "LateUpdate",
    "FixedUpdate",
    "OnEnable",
    "OnDisable",
    "OnDestroy",
    "OnApplicationPause",
    "OnApplicationQuit",
    "OnApplicationFocus",
    "OnBecameVisible",
    "OnBecameInvisible",
    "OnCollisionEnter",
    "OnCollisionStay",
    "OnCollisionExit",
    "OnTriggerEnter",
    "OnTriggerStay",
    "OnTriggerExit",
    "OnRenderImage",
    "OnPreRender",
    "OnWillRenderObject",
    "OnDrawGizmos",
}

TOKEN_CANON = {
    "ik": "IK",
    "ui": "UI",
    "vr": "VR",
    "vrc": "VRC",
    "id": "Id",
    "ids": "Ids",
    "url": "Url",
    "uri": "Uri",
    "http": "Http",
    "https": "Https",
    "api": "Api",
    "json": "Json",
    "sdk": "Sdk",
    "eac": "Eac",
    "eos": "Eos",
    "ip": "Ip",
    "udp": "Udp",
    "tcp": "Tcp",
}

TOKEN_WEIGHTS = {
    "avatar": 7,
    "photon": 7,
    "network": 6,
    "room": 6,
    "user": 6,
    "player": 6,
    "pointer": 6,
    "hover": 5,
    "drag": 5,
    "ik": 7,
    "foot": 5,
    "effector": 5,
    "transform": 4,
    "rect": 4,
    "camera": 5,
    "audio": 5,
    "video": 5,
    "animator": 5,
    "animation": 5,
    "particle": 5,
    "service": 3,
    "moderation": 6,
    "invite": 5,
    "portal": 5,
    "world": 6,
    "instance": 3,
    "menu": 5,
    "button": 5,
    "toggle": 5,
    "slider": 5,
    "language": 4,
    "platform": 4,
    "material": 5,
    "texture": 5,
    "mesh": 5,
    "constraint": 5,
    "motion": 5,
    "movement": 5,
    "connection": 5,
    "upload": 5,
    "download": 5,
    "auth": 5,
    "cookie": 5,
    "login": 5,
}


def load_classes():
    data = json.loads(DUMP_PATH.read_text(encoding="utf-8"))
    classes = []
    for namespace, entries in data.get("namespaces", {}).items():
        if not isinstance(entries, list):
            continue
        for cls in entries:
            if isinstance(cls, dict):
                cls.setdefault("namespace", namespace)
                classes.append(cls)
    return classes


def load_external_class_map():
    if not MAPPING_PATH.exists():
        return {}
    try:
        data = json.loads(MAPPING_PATH.read_text(encoding="utf-8"))
    except json.JSONDecodeError:
        return {}
    classes = data.get("classes", {})
    return classes if isinstance(classes, dict) else {}


def is_fallback_name(name):
    return bool(name and FALLBACK_RE.match(name))


def is_obfuscated_name(name):
    if not name:
        return False
    if is_fallback_name(name):
        return True
    if re.fullmatch(r"[m_0-9A-F]+", name):
        return True
    letters = sum(1 for ch in name if ch in "лмнопрстуфхцчшщъыьэюяÌÍÎÏ")
    return letters >= max(6, len(name) // 2)


def strip_method_hash(name):
    return HASH_TAIL_RE.sub("", name or "")


def semantic_methods(cls):
    methods = {strip_method_hash(m) for m in cls.get("methods", []) if isinstance(m, str)}
    pointers = cls.get("method_pointers", {})
    if isinstance(pointers, dict):
        methods.update(strip_method_hash(m) for m in pointers if isinstance(m, str))
    return sorted(
        m
        for m in methods
        if m not in {".ctor", ".cctor"} and not OBF_METHOD_RE.fullmatch(m)
    )


def suffix_from_old_name(old_name):
    parts = re.findall(r"[0-9A-F]{4,}|[0-9A-F]{3}[A-Z][A-Za-z]*_[0-9A-F]{4,}", old_name)
    if parts:
        suffix = parts[-1]
    else:
        suffix = f"{abs(hash(old_name)) & 0xFFFF:04X}"
    return suffix[-9:]


def split_tokens(text):
    text = strip_method_hash(text)
    text = FALLBACK_WORD_RE.sub("", text)
    text = re.sub(
        r"(?:ComplexComponent|LifecycleComponent|UpdateComponent|AsyncStateMachine|"
        r"BaseClass|EmptyType|EmptyStruct|Static|Type|DataOnly|Record)\d*[A-Za-z]*",
        " ",
        text,
    )
    text = re.sub(r"([a-z0-9])([A-Z])", r"\1 \2", text)
    text = re.sub(r"([A-Z]+)([A-Z][a-z])", r"\1 \2", text)
    return re.findall(r"[A-Za-z][A-Za-z0-9]*", text)


def format_token(token):
    lower = token.lower()
    if lower in TOKEN_CANON:
        return TOKEN_CANON[lower]
    if token.isupper() and len(token) <= 4:
        return token
    return lower[:1].upper() + lower[1:]


def significant_tokens(methods, namespace="", parent=""):
    scores = Counter()
    first_seen = {}
    source_texts = list(methods)
    if namespace:
        source_texts.extend(namespace.split("."))
    if parent:
        source_texts.append(parent)

    for order, text in enumerate(source_texts):
        for raw in split_tokens(text):
            lower = raw.lower()
            if lower in STOP_TOKENS:
                continue
            if re.fullmatch(r"[0-9A-Fa-f]+", raw) and any(ch.isdigit() for ch in raw):
                continue
            if len(lower) < 3 and lower not in {"ik", "ui", "vr", "id"}:
                continue
            scores[lower] += TOKEN_WEIGHTS.get(lower, 1)
            first_seen.setdefault(lower, order)

    ordered = sorted(scores, key=lambda t: (-scores[t], first_seen[t], t))
    return [format_token(t) for t in ordered]


def normalize_parent(parent, class_map):
    if not parent:
        return ""
    parent = class_map.get(parent, parent)
    parent = parent.split(".")[-1]
    return parent


def semantic_parent(parent):
    if not parent or parent in {"Object", "ValueType", "Enum", "MonoBehaviour"}:
        return ""
    if is_obfuscated_name(parent):
        base = re.sub(r"_[0-9A-F]{4,}.*$", "", parent)
        if base and base != parent and not is_obfuscated_name(base):
            return base
        return ""
    return re.sub(r"_[0-9A-F]{4,}.*$", "", parent)


def role_for_class(old_name, methods, fields, parent):
    method_set = set(methods)
    if old_name.startswith("AsyncStateMachine_") or {"MoveNext", "SetStateMachine"} <= method_set:
        return "AsyncStateMachine"
    if old_name.startswith("Enumerator_") or (
        "MoveNext" in method_set and any("IEnumerator" in f for f in fields)
    ):
        return "Enumerator"
    if old_name.startswith("Delegate_") or "Invoke" in method_set and len(method_set) <= 3:
        return "Delegate"
    if "Equals" in method_set and "GetHashCode" in method_set and len(method_set) <= 4:
        return "EqualityComparer"
    if {"Add", "Clear", "Contains", "CopyTo"} & method_set and len({"Add", "Clear", "Contains", "CopyTo"} & method_set) >= 2:
        return "Collection"
    lifecycle_hits = len(method_set & UNITY_LIFECYCLE)
    if old_name.startswith(("LifecycleComponent_", "UpdateComponent_", "ComplexComponent_")):
        return "Component"
    if lifecycle_hits >= 4:
        return "Behaviour"
    if old_name.startswith("Static"):
        return "StaticMethods"
    if old_name.startswith("EmptyStruct_") or parent == "ValueType":
        return "Struct"
    if old_name.startswith("BaseClass"):
        return "Impl"
    if old_name.startswith("DataOnly"):
        return "Data"
    if old_name.startswith("Record"):
        return "Record"
    return "Type"


def interface_name(methods, fields):
    field_text = " ".join(f for f in fields if isinstance(f, str))
    method_text = " ".join(methods)
    combined = f"{field_text} {method_text}"
    generic_match = re.search(r"IEnumerator<([^>]+)>", combined)
    if generic_match:
        type_name = generic_match.group(1).split(".")[-1]
        if type_name and not is_obfuscated_name(type_name):
            return f"{re.sub(r'[^A-Za-z0-9]', '', type_name)}Enumerator"
    if "IEnumerator" in combined and "MoveNext" in methods:
        return "IEnumeratorImpl"
    if "IEnumerable" in combined and "GetEnumerator" in combined:
        return "IEnumerableImpl"
    if "IAsyncStateMachine" in combined or {"MoveNext", "SetStateMachine"} <= set(methods):
        return "AsyncStateMachine"
    return ""


def compact_name(tokens, role):
    selected = []
    for token in tokens:
        if token in selected:
            continue
        if token.lower() == role.lower():
            continue
        selected.append(token)
        if len(selected) == 3:
            break
    if not selected:
        return ""
    if selected[-1].lower() in {"state", "component", "behaviour", "delegate", "record", "type"}:
        selected = selected[:-1]
    if not selected:
        return ""
    return "".join(selected) + role


def derive_name(cls, class_map):
    old_name = cls.get("name", "")
    parent = normalize_parent(cls.get("parent", ""), class_map)
    parent_base = semantic_parent(parent)
    fields = [f for f in cls.get("fields", []) if isinstance(f, str)]
    methods = semantic_methods(cls)
    role = role_for_class(old_name, methods, fields, parent_base)
    suffix = suffix_from_old_name(old_name)

    method_set = set(methods)
    iface = interface_name(methods, fields)
    if iface and iface != role:
        base = iface
    elif parent_base:
        base = f"{parent_base}{role}"
    else:
        tokens = significant_tokens(methods, cls.get("namespace", ""), parent_base)
        base = compact_name(tokens, role)

    if not base:
        return ""

    # Avoid aliases that are only the previous fallback family with a different suffix.
    if FALLBACK_RE.match(base) or base == old_name:
        return ""

    # Empty shells and pure MoveNext/SetStateMachine entries need a context anchor.
    if not parent_base:
        non_boilerplate = [
            m
            for m in methods
            if m
            not in UNITY_LIFECYCLE
            and m
            not in {
                "MoveNext",
                "SetStateMachine",
                "Equals",
                "GetHashCode",
                "ToString",
                "Dispose",
                "Reset",
                "get_Current",
            }
        ]
        if old_name.startswith(("EmptyType_", "EmptyStruct_")) and not non_boilerplate:
            return ""
        if old_name.startswith("AsyncStateMachine_") and not non_boilerplate:
            return ""
        if old_name.startswith("Static") and not non_boilerplate and role != "EqualityComparer":
            return ""

    return f"{base}_{suffix}"


def choose_best_name(old_name, candidates):
    scored = []
    for new_name, cls in candidates:
        methods = semantic_methods(cls)
        parent = cls.get("parent", "")
        score = 0
        score += min(len([m for m in methods if m not in UNITY_LIFECYCLE]), 12) * 3
        score += min(len(set(methods) & UNITY_LIFECYCLE), 8)
        score += 12 if parent else 0
        score += 5 if not new_name.startswith(("Type", "StaticMethods", "Impl")) else 0
        score += len(new_name)
        scored.append((score, new_name))
    scored.sort(reverse=True)
    return scored[0][1] if scored else ""


def main():
    classes = load_classes()
    class_map = load_external_class_map()

    by_old = defaultdict(list)
    fallback_entries = 0
    for cls in classes:
        old_name = cls.get("name", "")
        if not is_fallback_name(old_name):
            continue
        fallback_entries += 1
        new_name = derive_name(cls, class_map)
        if new_name and new_name != old_name:
            by_old[old_name].append((new_name, cls))

    renames = {}
    used = set()
    for old_name in sorted(by_old):
        new_name = choose_best_name(old_name, by_old[old_name])
        if not new_name:
            continue
        base = new_name
        index = 2
        while new_name in used:
            new_name = f"{base}_{index}"
            index += 1
        used.add(new_name)
        renames[old_name] = new_name

    OUT_PATH.write_text(json.dumps(renames, indent=2, sort_keys=True) + "\n", encoding="utf-8")
    print(f"fallback entries: {fallback_entries}")
    print(f"unique fallback names with candidates: {len(by_old)}")
    print(f"improved renames written: {len(renames)}")
    print(f"output: {OUT_PATH}")


if __name__ == "__main__":
    main()
