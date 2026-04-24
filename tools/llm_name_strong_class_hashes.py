#!/usr/bin/env python3
from __future__ import annotations
import argparse, json, re, struct, sys
from bisect import bisect_right
from collections import Counter, defaultdict
from pathlib import Path
import pefile
from capstone import CS_ARCH_X86, CS_MODE_64, Cs
from capstone.x86 import X86_GRP_JUMP, X86_INS_CALL, X86_INS_JMP, X86_OP_IMM, X86_OP_MEM, X86_REG_RIP

sys.stdout.reconfigure(encoding="utf-8")
sys.stderr.reconfigure(encoding="utf-8")

ROOT = Path(__file__).resolve().parent.parent
WEAK_RE = re.compile(
    r"^(BaseClass|Type|Static|Major|Service|Struct|Mono|DataOnly|Unknown|Record|NestedType|"
    r"EmptyType|EmptyStruct|AsyncStateMachine|Enumerator|Delegate|LifecycleComponent|"
    r"UpdateComponent|ComplexComponent|AnimatedTextureBase|NetworkItem|NetworkSyncable|"
    r"VRCUiManagerSibling|VRC_Main|VRC_Secondary|VRCUi|MajorSystem|TransformGame|UIRect|"
    r"GameObjectHandler|PointerEnter|VRCInit|InitializeVRSDK)\w*_[0-9A-F]+$",
    re.I,
)
HEX_SUFFIX_RE = re.compile(r"_[0-9A-F]{4}$", re.I)
HASH_RE = re.compile(r"^m_[0-9A-F]+$", re.I)
HEX_TAIL_RE = re.compile(r"_[0-9A-F]{3,4}$", re.I)
VALID_NAME_RE = re.compile(r"^[A-Za-z][A-Za-z0-9_]{2,39}$")
API_RE = re.compile(r"([A-Za-z0-9_.+/]+)::([A-Za-z0-9_]+)\(")
STOP = set("a an and are as at be bool by do for from get has if in into is it new not null of on or out set the this to true false type types unityengine system vrc vrchat il2cppsystem value values internal managed could would should cannot failed failure error errors exception nullreferenceexception missingmethodexception locale lcid ex".split())
GENERIC = {"HandleEvent", "ProcessData", "UpdateState", "InitializeState", "GetValue", "SetValue", "CheckState", "RunAction", "ExecuteAction", "HandleMessage", "ProcessMessage"}
NOUN_HINTS = {k: v for k, v in [("avatar", "Avatar"), ("auth", "Auth"), ("audio", "Audio"), ("camera", "Camera"), ("cookie", "Cookie"), ("emoji", "Emoji"), ("eye", "Eye"), ("file", "File"), ("friend", "Friend"), ("group", "Group"), ("head", "Head"), ("http", "Http"), ("instance", "Instance"), ("json", "Json"), ("menu", "Menu"), ("message", "Message"), ("moderation", "Moderation"), ("network", "Network"), ("osc", "Osc"), ("overlay", "Overlay"), ("packet", "Packet"), ("permission", "Permission"), ("photon", "Photon"), ("photo", "Photo"), ("player", "Player"), ("pose", "Pose"), ("prefab", "Prefab"), ("profile", "Profile"), ("room", "Room"), ("screen", "Screen"), ("sdk", "Sdk"), ("setting", "Settings"), ("shader", "Shader"), ("state", "State"), ("text", "Text"), ("token", "Token"), ("transform", "Transform"), ("ui", "Ui"), ("url", "Url"), ("user", "User"), ("video", "Video"), ("voice", "Voice"), ("world", "World")]}
VERB_HINTS = [re.compile(r"\bfailed to (load|save|create|join|connect|parse|serialize|deserialize)\b", re.I), re.compile(r"\b(load|save|create|destroy|refresh|reset|apply|update|initialize|validate|sync|serialize|deserialize)\b", re.I), re.compile(r"\b(connect|disconnect|join|leave|open|close|send|receive|decode|encode)\b", re.I)]
FALLBACK_DLLS = [Path("D:/Steam/steamapps/common/VRChat/GameAssembly.dll"), ROOT.parent / "GameAssembly.dll"]
EMPTY_CTX = {"disasm_first_128": [], "referenced_strings": [], "called_named_methods": [], "field_offsets": [], "shape": "unknown"}


def parse_args() -> argparse.Namespace:
    p = argparse.ArgumentParser(description="Collect strong-class hash method contexts and predict names locally.")
    p.add_argument("--precise", default=str(ROOT / "data" / "precise_dump.json"))
    p.add_argument("--deobf", default=str(ROOT / "output" / "deobfuscated_dump.json"))
    p.add_argument("--targets", default=str(ROOT / "output" / "llm_targets_strong.json"))
    p.add_argument("--output", default=str(ROOT / "output" / "llm_strong_class_names.json"))
    p.add_argument("--dll", default="")
    p.add_argument("--scan-bytes", type=int, default=512)
    p.add_argument("--max-insns", type=int, default=120)
    p.add_argument("--max-follow-targets", type=int, default=2)
    p.add_argument("--include-compiler-generated", action="store_true")
    return p.parse_args()


def load_json(path: str | Path) -> dict:
    with Path(path).open("r", encoding="utf-8") as f: return json.load(f)


def flat_classes(dump: dict):
    for ns, classes in dump.get("namespaces", {}).items():
        for cls in classes:
            yield ns, cls


def pair_classes(raw: dict, deobf: dict):
    raw_items = list(flat_classes(raw))
    deobf_items = list(flat_classes(deobf))
    if len(raw_items) != len(deobf_items): raise ValueError(f"class count mismatch: {len(raw_items)} != {len(deobf_items)}")
    for idx, ((rns, rcls), (dns, dcls)) in enumerate(zip(raw_items, deobf_items)):
        if rns != dns: raise ValueError(f"namespace mismatch at class {idx}: {rns!r} != {dns!r}")
        if len(rcls.get("methods") or []) != len(dcls.get("methods") or []):
            raise ValueError(f"method count mismatch at class {idx}: {rcls.get('name')} / {dcls.get('name')}")
        yield dns, rcls, dcls


def parse_va(value) -> int | None:
    try: return int(str(value), 16) if value else None
    except ValueError: return None


def find_dll_path(cli_value: str) -> Path:
    if cli_value:
        p = Path(cli_value)
        if p.exists(): return p
        raise FileNotFoundError(f"GameAssembly.dll not found: {p}")
    for candidate in FALLBACK_DLLS:
        if candidate.exists(): return candidate
    raise FileNotFoundError("Could not find GameAssembly.dll; pass --dll explicitly.")


def is_compiler_generated(name: str) -> bool:
    return "<" in name or ">" in name or name.startswith("$") or name.startswith("__StaticArrayInitTypeSize")


def is_strong_class(name: str, exclude_compiler_generated: bool = True) -> bool:
    return bool(name) and not WEAK_RE.fullmatch(name) and not HEX_SUFFIX_RE.search(name) and not (exclude_compiler_generated and is_compiler_generated(name))


def split_words(text: str) -> list[str]:
    return re.findall(r"[A-Z]+(?=[A-Z][a-z]|\d|$)|[A-Z]?[a-z]+|\d+", text)


def pascal_symbol(text: str) -> str:
    return "".join(word[0].upper() + word[1:] for word in split_words(text) if word)


def pascal_from_tokens(tokens: list[str]) -> str:
    out: list[str] = []
    for token in tokens:
        for word in split_words(token):
            low = word.lower()
            if not word or low in STOP:
                continue
            if word.isupper() and len(word) <= 3:
                out.append(word.title())
            else:
                out.append(word[0].upper() + word[1:])
    return "".join(out)


def normalize_name(name: str) -> str | None:
    name = HEX_TAIL_RE.sub("", name.strip().replace("::", "_"))
    name = re.sub(r"(Impl|Injected)$", "", name)
    name = re.sub(r"[^A-Za-z0-9_]+", " ", name)
    if "_" in name and not name.startswith(("Get_", "Set_", "get_", "set_")): name = pascal_from_tokens(name.split("_"))
    elif " " in name: name = pascal_from_tokens(name.split())
    elif name and name[0].islower(): name = name[0].upper() + name[1:]
    return None if not VALID_NAME_RE.fullmatch(name) or name in GENERIC else name


class PEImage:
    def __init__(self, path: Path):
        self.path = path
        self.data = path.read_bytes()
        self.pe = pefile.PE(str(path), fast_load=True)
        self.pref_base = self.pe.OPTIONAL_HEADER.ImageBase
        self.runtime_base = 0
        self.sections = []
        self.exec_sections = []
        self.ro_sections = []
        for sec in self.pe.sections:
            mapped = min(sec.SizeOfRawData, max(0, len(self.data) - sec.PointerToRawData))
            if mapped <= 0:
                continue
            info = {
                "name": sec.Name.decode("ascii", errors="ignore").rstrip("\0"),
                "start": sec.VirtualAddress,
                "end": sec.VirtualAddress + mapped,
                "raw": sec.PointerToRawData,
                "mapped": mapped,
            }
            self.sections.append(info)
            if sec.Characteristics & 0x20000000: self.exec_sections.append(info)
            if sec.Characteristics & 0x40000000 and not sec.Characteristics & 0x80000000 and not sec.Characteristics & 0x20000000:
                self.ro_sections.append(info)

    def infer_runtime_base(self, dump: dict) -> int:
        vas = [parse_va(v) for _, cls in flat_classes(dump) for v in (cls.get("method_pointers") or {}).values()]
        vas = [va for va in vas if va]
        if not vas: self.runtime_base = self.pref_base; return self.runtime_base
        lo = ((max(vas) - max(s["end"] for s in self.exec_sections)) // 0x10000) * 0x10000
        hi = ((min(vas) - min(s["start"] for s in self.exec_sections)) // 0x10000) * 0x10000
        best_base, best_hits = self.pref_base, -1
        for base in range(lo, hi + 1, 0x10000):
            hits = sum(1 for va in vas if any(sec["start"] <= va - base < sec["end"] for sec in self.exec_sections))
            if hits > best_hits: best_base, best_hits = base, hits
        self.runtime_base = best_base; return best_base

    def section_for_va(self, va: int):
        rva = va - self.runtime_base
        for sec in self.sections:
            if sec["start"] <= rva < sec["end"]: return sec
        return None

    def is_exec(self, va: int) -> bool: return self.section_for_va(va) in self.exec_sections
    def is_ro(self, va: int) -> bool: return self.section_for_va(va) in self.ro_sections

    def read_va(self, va: int, size: int) -> bytes:
        sec = self.section_for_va(va)
        if not sec: return b""
        rva = va - self.runtime_base
        offset = sec["raw"] + (rva - sec["start"])
        end = min(len(self.data), sec["raw"] + sec["mapped"], offset + size)
        return self.data[offset:end] if end > offset else b""

    def read_qword(self, va: int) -> int | None:
        data = self.read_va(va, 8)
        return struct.unpack("<Q", data)[0] if len(data) == 8 else None


def printable_text(s: str) -> bool: return len(s) >= 4 and any(c.isalpha() for c in s) and all(c.isprintable() or c in "\r\n\t" for c in s)


def scan_strings(pe: PEImage):
    exact: dict[int, str] = {}
    spans = []
    for sec in pe.ro_sections:
        data = pe.data[sec["raw"] : sec["raw"] + sec["mapped"]]
        base_va = pe.runtime_base + sec["start"]
        i = 0
        while i < len(data):
            end = data.find(b"\0", i)
            if end > i:
                raw = data[i:end]
                if len(raw) >= 4:
                    try:
                        text = raw.decode("utf-8")
                    except UnicodeDecodeError:
                        text = None
                    if text and printable_text(text):
                        va = base_va + i; exact.setdefault(va, text); spans.append((va, va + len(raw) + 1, text)); i = end + 1; continue
            i += 1
    spans.sort(key=lambda x: x[0])
    return exact, spans, [x[0] for x in spans]


def resolve_string(va: int, exact: dict[int, str], spans: list[tuple[int, int, str]], starts: list[int]) -> str | None:
    if va in exact: return exact[va]
    idx = bisect_right(starts, va) - 1
    if idx >= 0:
        start, end, text = spans[idx]
        if start <= va < end and va - start <= 24: return text
    return None


class MethodAnalyzer:
    def __init__(self, pe: PEImage, exact, spans, starts, va_to_named_key: dict[int, str], scan_bytes: int, max_insns: int, max_follow_targets: int):
        self.pe = pe
        self.exact = exact
        self.spans = spans
        self.starts = starts
        self.va_to_named_key = va_to_named_key
        self.scan_bytes = scan_bytes
        self.max_insns = max_insns
        self.max_follow_targets = max_follow_targets
        self.cs = Cs(CS_ARCH_X86, CS_MODE_64)
        self.cs.detail = True
        self.cache: dict[int, dict] = {}

    def analyze(self, va: int | None, active: set[int] | None = None) -> dict:
        if not va: return EMPTY_CTX
        if va in self.cache: return self.cache[va]
        active = active or set()
        if va in active: return EMPTY_CTX
        active.add(va)
        code = self.pe.read_va(va, self.scan_bytes)
        if not code or not self.pe.is_exec(va):
            self.cache[va] = EMPTY_CTX
            active.discard(va)
            return EMPTY_CTX
        strings: set[str] = set()
        calls: list[str] = []
        field_offsets: list[int] = []
        preview: list[str] = []
        meaningful = []
        follow: list[int] = []
        for idx, insn in enumerate(self.cs.disasm(code, va, count=self.max_insns)):
            if insn.address < va + 128:
                preview.append(f"0x{insn.address:X}: {insn.mnemonic} {insn.op_str}".rstrip())
            meaningful.append(insn)
            ops = getattr(insn, "operands", [])
            for op in ops:
                if op.type == X86_OP_MEM and op.mem.base and op.mem.disp and abs(op.mem.disp) < 0x2000:
                    field_offsets.append(op.mem.disp)
            if insn.mnemonic in {"lea", "mov"} and len(ops) >= 2:
                src = ops[1]
                if src.type == X86_OP_MEM and src.mem.base == X86_REG_RIP:
                    target = insn.address + insn.size + src.mem.disp
                    text = resolve_string(target, self.exact, self.spans, self.starts)
                    if text: strings.add(text)
                    elif insn.mnemonic == "mov":
                        ptr = self.pe.read_qword(target)
                        if ptr:
                            text = resolve_string(ptr, self.exact, self.spans, self.starts)
                            if text: strings.add(text)
                elif src.type == X86_OP_IMM and self.pe.is_ro(src.imm):
                    text = resolve_string(src.imm, self.exact, self.spans, self.starts)
                    if text: strings.add(text)
            if insn.id in (X86_INS_CALL, X86_INS_JMP) and ops and ops[0].type == X86_OP_IMM:
                target = ops[0].imm
                if target in self.va_to_named_key and self.va_to_named_key[target] not in calls: calls.append(self.va_to_named_key[target])
                if insn.id == X86_INS_CALL and self.pe.is_exec(target) and len(follow) < self.max_follow_targets: follow.append(target)
            if (idx >= 5 and insn.mnemonic in {"ret", "retf", "int3", "ud2"}) or (insn.group(X86_GRP_JUMP) and idx > 30): break
        if len(strings) < 3:
            for target in follow:
                sub = self.analyze(target, active)
                strings.update(sub["referenced_strings"][:2])
                for key in sub["called_named_methods"]:
                    if key not in calls: calls.append(key)
                if len(strings) >= 3: break
        result = {"disasm_first_128": preview, "referenced_strings": sorted(strings)[:12], "called_named_methods": calls[:12], "field_offsets": sorted(set(field_offsets))[:8], "shape": detect_shape(meaningful)}
        self.cache[va] = result
        active.discard(va)
        return result


def detect_shape(insns) -> str:
    text = " | ".join(f"{i.mnemonic} {i.op_str}".strip() for i in insns[:8])
    if re.search(r"\bmov [er]ax, (?:dword ptr |qword ptr |byte ptr )?\[rcx \+ ", text) and "ret" in text: return "getter"
    if re.search(r"\bmov (?:dword ptr |qword ptr |byte ptr )?\[rcx \+ .+], [er]dx\b", text) and "ret" in text: return "setter"
    if re.search(r"\b(?:cmp|test) (?:byte ptr |dword ptr |qword ptr )?\[rcx \+ ", text) and re.search(r"\bset[a-z]{1,2}\b", text): return "predicate"
    if "call " in text and "ret" in text and all(i.mnemonic not in {"jmp", "je", "jne", "jg", "jl"} for i in insns[:6]): return "wrapper"
    return "method"


def clean_method_stem(name: str) -> tuple[str | None, str | None]:
    base = HEX_TAIL_RE.sub("", name)
    if HASH_RE.fullmatch(base): return None, None
    for prefix, verb in (("get_", "Get"), ("set_", "Set"), ("add_", "Add"), ("remove_", "Remove")):
        if base.startswith(prefix): return verb, pascal_symbol(base[len(prefix) :])
    for verb in ("Get", "Set", "Is", "Has", "Update", "Initialize", "Reset", "Refresh", "Sync", "Apply", "Build", "Create", "Destroy", "Load", "Save", "Process", "Handle", "Validate", "Check"):
        if base.startswith(verb) and len(base) > len(verb): return verb, base[len(verb) :]
    return None, None


def getter_name(prop: str) -> str:
    stem = pascal_symbol(prop)
    return stem if stem.startswith(("Is", "Has", "Can", "Should")) else f"Get{stem}"


def is_bad_prediction(name: str) -> bool:
    parts = set(split_words(name))
    if parts & {"Exception", "Locale", "Lcid", "Missing", "NullReference", "IndexOutOfRange"}: return True
    return name.startswith("LoadGetLocale") or name.startswith("LoadLocal")


def build_accessor_map(class_methods: list[dict], analyzer: MethodAnalyzer) -> dict[int, tuple[str, str]]:
    matches: dict[int, list[tuple[str, str]]] = defaultdict(list)
    for entry in class_methods:
        verb, stem = clean_method_stem(entry["current_name"])
        if not verb or not stem or not entry["_va"]: continue
        ctx = analyzer.analyze(entry["_va"])
        if ctx["shape"] not in {"getter", "setter", "predicate"} or len(ctx["field_offsets"]) != 1: continue
        matches[ctx["field_offsets"][0]].append((verb, stem))
    resolved = {}
    for offset, pairs in matches.items():
        counts = Counter(pairs)
        (verb, stem), freq = counts.most_common(1)[0]
        if freq >= 1 and len(counts) == 1: resolved[offset] = (verb, stem)
    return resolved


def neighboring_methods(methods: list[str], index: int) -> list[str]:
    return [methods[i] for i in range(max(0, index - 3), min(len(methods), index + 4)) if i != index]


def method_va(raw_cls: dict, deobf_cls: dict, idx: int) -> int | None:
    raw_name = (raw_cls.get("methods") or [])[idx]
    deobf_name = (deobf_cls.get("methods") or [])[idx]
    for mapping, key in (
        (deobf_cls.get("method_pointers") or {}, deobf_name),
        (raw_cls.get("method_pointers") or {}, raw_name),
        (deobf_cls.get("method_pointers") or {}, raw_name),
        (raw_cls.get("method_pointers") or {}, deobf_name),
    ):
        va = parse_va(mapping.get(key))
        if va:
            return va
    return None


def extract_nouns(texts: list[str]) -> Counter:
    nouns: Counter = Counter()
    for text in texts:
        for token in re.findall(r"[A-Za-z][A-Za-z0-9_]{2,}", text):
            low = token.lower()
            if low in STOP: continue
            if low in NOUN_HINTS: nouns[NOUN_HINTS[low]] += 3
            elif token[0].isupper(): nouns[pascal_symbol(token)] += 1
    return nouns


def derive_from_api(strings: list[str], class_name: str) -> tuple[str | None, float, str]:
    actions = Counter()
    props = Counter()
    domains = Counter()
    for text in strings:
        m = API_RE.search(text)
        if not m: continue
        raw_type, raw_method = m.groups()
        type_name = pascal_symbol(raw_type.split(".")[-1])
        method = raw_method.replace("_Injected", "")
        if type_name: domains[type_name] += 1
        if method.startswith("get_"):
            actions["get"] += 1; props[method[4:]] += 2
        elif method.startswith("set_"):
            actions["set"] += 1; props[method[4:]] += 2
        else:
            actions[method] += 1
    if not actions: return None, 0.0, ""
    domain = domains.most_common(1)[0][0] if domains else pascal_from_tokens([class_name])
    action, count = actions.most_common(1)[0]
    if action == "get" and props: return normalize_name(getter_name(props.most_common(1)[0][0])), 0.88, "api_get"
    if action == "set" and props: return normalize_name(f"Set{pascal_symbol(props.most_common(1)[0][0])}"), 0.88, "api_set"
    if action and action[0].isupper():
        base = normalize_name(f"{action}{domain}" if action in {"Load", "Save", "Create", "Destroy", "Update", "Apply"} else action)
        return base, 0.82 if count >= 2 else 0.76, "api_call"
    return None, 0.0, ""


def derive_from_strings(strings: list[str], class_name: str) -> tuple[str | None, float, str]:
    joined = " | ".join(strings)
    verb = None
    for pattern in VERB_HINTS:
        m = pattern.search(joined)
        if m: verb = m.group(1).title(); break
    nouns = extract_nouns(strings)
    if not nouns: return None, 0.0, ""
    noun = nouns.most_common(1)[0][0]
    if noun in {"System", "Type", "Locale", "Info", "Ex"}: return None, 0.0, ""
    if not verb:
        if any("invalid" in s.lower() or "must" in s.lower() for s in strings): verb = "Validate"
        elif any("error" in s.lower() or "failed" in s.lower() for s in strings): verb = "Handle"
        elif any("http" in s.lower() or "url" in s.lower() for s in strings): verb = "Open"
        else: return None, 0.0, ""
    name = normalize_name(f"{verb}{noun}")
    return name, 0.74, "strings"


def derive_from_calls(called: list[str], class_name: str) -> tuple[str | None, float, str]:
    if not called: return None, 0.0, ""
    verbs = Counter()
    nouns = Counter()
    for key in called:
        method = key.split("::", 1)[1]
        verb, stem = clean_method_stem(method)
        if verb: verbs[verb] += 1
        if stem:
            for word in split_words(stem):
                if word.lower() not in STOP: nouns[word] += 1
    if not nouns: return None, 0.0, ""
    noun = pascal_from_tokens([nouns.most_common(1)[0][0]])
    if verbs:
        verb = verbs.most_common(1)[0][0]
        return normalize_name(f"{verb}{noun}"), 0.70 if verbs[verb] >= 2 else 0.64, "calls"
    class_word = pascal_from_tokens(split_words(class_name)[-2:])
    return normalize_name(f"Handle{class_word}{noun}"), 0.60, "calls_fallback"


def derive_from_accessor(target: dict, accessor_map: dict[int, tuple[str, str]]) -> tuple[str | None, float, str]:
    if target["shape"] not in {"getter", "setter", "predicate"} or len(target["field_offsets"]) != 1: return None, 0.0, ""
    match = accessor_map.get(target["field_offsets"][0])
    if not match: return None, 0.0, ""
    _, stem = match
    verb = {"getter": "Get", "setter": "Set", "predicate": "Is"}[target["shape"]]
    return normalize_name(f"{verb}{stem}"), 0.95, "accessor_match"


def predict_name(target: dict, accessor_map: dict[int, tuple[str, str]]) -> tuple[str | None, float, str]:
    candidates = [derive_from_accessor(target, accessor_map), derive_from_api(target["referenced_strings"], target["class_name"]), derive_from_strings(target["referenced_strings"], target["class_name"]), derive_from_calls(target["called_named_methods"], target["class_name"])]
    best = max(candidates, key=lambda item: item[1])
    return best if best[0] and best[1] >= 0.68 else (None, 0.0, "")


def main() -> int:
    args = parse_args()
    precise = load_json(args.precise)
    deobf = load_json(args.deobf)
    dll_path = find_dll_path(args.dll)
    pe = PEImage(dll_path)
    runtime_base = pe.infer_runtime_base(precise)
    exact, spans, starts = scan_strings(pe)

    named_va_map: dict[int, str] = {}
    all_class_methods: dict[str, list[dict]] = defaultdict(list)
    strong_class_names: set[str] = set()
    for ns, raw_cls, deobf_cls in pair_classes(precise, deobf):
        class_name = deobf_cls["name"]
        methods = [str(m) for m in (deobf_cls.get("methods") or [])]
        for idx, current_name in enumerate(methods):
            va = method_va(raw_cls, deobf_cls, idx)
            entry = {"class_name": class_name, "namespace": ns, "parent_class": deobf_cls.get("parent", ""), "current_name": current_name, "method_index_in_class": idx, "method_va": f"0x{va:X}" if va else None, "_va": va}
            all_class_methods[class_name].append(entry)
            if va and not HASH_RE.fullmatch(current_name): named_va_map[va] = f"{class_name}::{current_name}"
        if is_strong_class(class_name, not args.include_compiler_generated): strong_class_names.add(class_name)

    analyzer = MethodAnalyzer(pe, exact, spans, starts, named_va_map, args.scan_bytes, args.max_insns, args.max_follow_targets)

    targets = []
    for class_name in sorted(strong_class_names):
        methods = all_class_methods[class_name]
        method_names = [m["current_name"] for m in methods]
        for entry in methods:
            if not HASH_RE.fullmatch(entry["current_name"]): continue
            ctx = analyzer.analyze(entry["_va"])
            targets.append({"class_name": class_name, "parent_class": entry["parent_class"], "namespace": entry["namespace"], "method_hash_name": entry["current_name"], "method_va": entry["method_va"], "method_index_in_class": entry["method_index_in_class"], "neighboring_methods": neighboring_methods(method_names, entry["method_index_in_class"]), "disasm_first_128": ctx["disasm_first_128"], "referenced_strings": ctx["referenced_strings"], "called_named_methods": ctx["called_named_methods"], "field_offsets": ctx["field_offsets"], "shape": ctx["shape"]})

    targets.sort(key=lambda t: (t["class_name"], t["method_index_in_class"]))
    Path(args.targets).write_text(json.dumps(targets, ensure_ascii=False, indent=2), encoding="utf-8")

    predictions: dict[str, str] = {}
    prediction_meta = []
    by_class = defaultdict(list)
    for target in targets: by_class[target["class_name"]].append(target)

    for class_name, class_targets in by_class.items():
        accessor_map = build_accessor_map(all_class_methods[class_name], analyzer)
        class_used = Counter()
        for target in class_targets:
            predicted, score, reason = predict_name(target, accessor_map)
            if not predicted or is_bad_prediction(predicted) or (class_used[predicted] >= 2 and score < 0.9): continue
            key = f"{class_name}::{target['method_hash_name']}"
            predictions[key] = predicted; class_used[predicted] += 1
            prediction_meta.append({"key": key, "predicted_name": predicted, "score": round(score, 3), "reason": reason})

    Path(args.output).write_text(json.dumps(dict(sorted(predictions.items())), ensure_ascii=False, indent=2), encoding="utf-8")

    prediction_meta.sort(key=lambda row: (-row["score"], row["key"]))
    samples = prediction_meta[:20]
    skipped = len(targets) - len(predictions)
    print("Report")
    print(f"  GameAssembly.dll: {dll_path}")
    print(f"  Runtime image base: 0x{runtime_base:X}")
    print(f"  Strong-class targets collected: {len(targets):,}")
    print(f"  Predictions made: {len(predictions):,}")
    print(f"  Skipped (low-confidence or duplicate): {skipped:,}")
    print("  Top 20 samples:")
    for row in samples: print(f"    {row['key']} -> {row['predicted_name']} [{row['score']:.2f} via {row['reason']}]")
    print(f"Wrote {args.targets}")
    print(f"Wrote {args.output}")
    return 0


if __name__ == "__main__":
    raise SystemExit(main())
