#!/usr/bin/env python3
"""Native string-ref naming for hash methods in GameAssembly.dll."""
from __future__ import annotations
import argparse, json, re, struct, sys
from bisect import bisect_right
from collections import Counter
from pathlib import Path
import pefile
from capstone import CS_ARCH_X86, CS_MODE_64, Cs
from capstone.x86 import X86_GRP_JUMP, X86_INS_CALL, X86_INS_JMP, X86_OP_IMM, X86_OP_MEM, X86_REG_RIP
sys.stdout.reconfigure(encoding="utf-8"); sys.stderr.reconfigure(encoding="utf-8")
HASH_RE = re.compile(r"^m_[0-9A-Fa-f]+$"); EVENT_RE = re.compile(r"\bOn([A-Z][A-Za-z0-9]+)\b")
API_RE = re.compile(r"^([A-Za-z0-9_.+/]+)::([A-Za-z0-9_]+)\("); SPLIT_RE = re.compile(r"[\\/._:\-\s]+")
STOP = {
    "a","an","and","are","as","at","be","bool","by","for","from","has","if","in","into","is","it","must","new","not","null","of","on","or",
    "the","this","to","true","false","empty","value","values","type","types","with","without","when","while","cannot","could","failed","failure",
    "unable","error","errors","warning","debug","log","info","string","unityengine","system","il2cppsystem","injected",
}
GENERIC = {"Initialize","Update","Validate","Process","Handle","Trigger","GetValue","SetValue"}
VERBS = [(re.compile(p, re.I), v) for p, v in [
    (r"\b(initializ(?:e|ing|ed))\s+(.+)", "Initialize"), (r"\b(start(?:ing|ed)?)\s+(.+)", "Start"),
    (r"\b(stop(?:ping|ped)?)\s+(.+)", "Stop"), (r"\b(load(?:ing|ed)?)\s+(.+)", "Load"),
    (r"\b(save(?:ing|d)?)\s+(.+)", "Save"), (r"\b(validat(?:e|ing|ed))\s+(.+)", "Validate"),
    (r"\b(connect(?:ing|ed)?)\s+(.+)", "Connect"), (r"\b(disconnect(?:ing|ed)?)\s+(.+)", "Disconnect"),
    (r"\b(join(?:ing|ed)?)\s+(.+)", "Join"), (r"\b(leave|left|leaving)\s+(.+)", "Leave"),
    (r"\b(update(?:ing|d)?)\s+(.+)", "Update"), (r"\b(refresh(?:ing|ed)?)\s+(.+)", "Refresh"),
    (r"\b(create|creating|created)\s+(.+)", "Create"), (r"\b(destroy|destroying|destroyed)\s+(.+)", "Destroy"),
]]
def parse_args():
    base = Path(__file__).resolve().parent.parent
    p = argparse.ArgumentParser(description=__doc__)
    p.add_argument("--dll", default="D:/Steam/steamapps/common/VRChat/GameAssembly.dll")
    p.add_argument("--precise", default=str(base / "data" / "precise_dump.json"))
    p.add_argument("--deobf", default=str(base / "output" / "deobfuscated_dump.json"))
    p.add_argument("--output", default=str(base / "output" / "ida_method_string_names_native.json"))
    p.add_argument("--scan-bytes", type=int, default=2048); p.add_argument("--max-insns", type=int, default=300)
    p.add_argument("--max-follow-bytes", type=int, default=1024); p.add_argument("--max-follow-targets", type=int, default=4)
    return p.parse_args()
def load_json(path):
    with Path(path).open("r", encoding="utf-8") as f: return json.load(f)
def flat_classes(dump):
    return [(ns, cls) for ns, classes in dump.get("namespaces", {}).items() for cls in classes]
def pair_classes(raw, deobf):
    raw_items, deobf_items = flat_classes(raw), flat_classes(deobf)
    if len(raw_items) != len(deobf_items): raise ValueError(f"class count mismatch: {len(raw_items)} != {len(deobf_items)}")
    for idx, ((rns, rcls), (dns, dcls)) in enumerate(zip(raw_items, deobf_items)):
        if rns != dns: raise ValueError(f"namespace mismatch at class {idx}: {rns!r} != {dns!r}")
        rm, dm = rcls.get("methods") or [], dcls.get("methods") or []
        if len(rm) != len(dm): raise ValueError(f"method count mismatch at class {idx}: {len(rm)} != {len(dm)}")
        yield rcls, dcls
def parse_va(value):
    if not value: return None
    try: va = int(str(value), 16)
    except ValueError: return None
    return va or None
class PEImage:
    def __init__(self, path):
        self.path = Path(path); self.data = self.path.read_bytes(); self.pe = pefile.PE(str(self.path), fast_load=True)
        self.pref_base = self.pe.OPTIONAL_HEADER.ImageBase; self.runtime_base = 0; self.sections = []; self.exec_secs = []; self.ro_secs = []
        for sec in self.pe.sections:
            name = sec.Name.decode("ascii", errors="ignore").rstrip("\0"); mapped = min(sec.SizeOfRawData, max(0, len(self.data) - sec.PointerToRawData))
            if mapped <= 0: continue
            info = {"name": name, "start": sec.VirtualAddress, "end": sec.VirtualAddress + mapped, "raw": sec.PointerToRawData, "mapped": mapped, "chars": sec.Characteristics}
            self.sections.append(info)
            if sec.Characteristics & 0x20000000: self.exec_secs.append(info)
            if sec.Characteristics & 0x40000000 and not sec.Characteristics & 0x80000000 and not sec.Characteristics & 0x20000000: self.ro_secs.append(info)
        if not self.exec_secs: raise ValueError("no executable sections found")
    def infer_runtime_base(self, dump):
        vas = []
        for _, cls in flat_classes(dump):
            for value in (cls.get("method_pointers") or {}).values():
                va = parse_va(value)
                if va: vas.append(va)
        if not vas: self.runtime_base = self.pref_base; return self.runtime_base
        lo = ((max(vas) - max(s["end"] for s in self.exec_secs)) // 0x10000) * 0x10000
        hi = ((min(vas) - min(s["start"] for s in self.exec_secs)) // 0x10000) * 0x10000
        best_base, best_hits = self.pref_base, -1
        for base in range(lo, hi + 1, 0x10000):
            hits = 0
            for va in vas:
                rva = va - base
                if any(s["start"] <= rva < s["end"] for s in self.exec_secs): hits += 1
            if hits > best_hits: best_base, best_hits = base, hits
        self.runtime_base = best_base; return best_base
    def section_for_va(self, va):
        rva = va - self.runtime_base
        for sec in self.sections:
            if sec["start"] <= rva < sec["end"]: return sec
        return None
    def is_exec(self, va):
        return self.section_for_va(va) in self.exec_secs
    def is_ro(self, va):
        return self.section_for_va(va) in self.ro_secs
    def read_va(self, va, size):
        sec = self.section_for_va(va)
        if not sec: return b""
        rva = va - self.runtime_base; off = sec["raw"] + (rva - sec["start"]); end = min(len(self.data), sec["raw"] + sec["mapped"], off + size)
        return self.data[off:end] if end > off else b""
    def read_qword(self, va):
        data = self.read_va(va, 8)
        return struct.unpack("<Q", data)[0] if len(data) == 8 else None
def printable_text(s, min_len=4):
    return len(s) >= min_len and any(c.isalpha() for c in s) and all(c.isprintable() or c in "\r\n\t" for c in s)
def scan_strings(pe):
    exact, spans, counts = {}, [], Counter()
    for sec in pe.ro_secs:
        data = pe.data[sec["raw"] : sec["raw"] + sec["mapped"]]; base_va = pe.runtime_base + sec["start"]; i = 0
        while i < len(data):
            end = data.find(b"\0", i)
            if end > i:
                raw = data[i:end]
                if len(raw) >= 4:
                    try: text = raw.decode("utf-8")
                    except UnicodeDecodeError: text = None
                    if text and printable_text(text):
                        va = base_va + i; exact.setdefault(va, text); spans.append((va, va + len(raw) + 1, text)); counts["utf8"] += 1; i = end + 1; continue
            if i + 8 <= len(data) and data[i + 1] == 0:
                j, chars = i, []
                while j + 1 < len(data):
                    code = data[j] | (data[j + 1] << 8)
                    if code == 0: break
                    ch = chr(code)
                    if code < 32 or (ch not in "\r\n\t" and not ch.isprintable()): chars = []; break
                    chars.append(ch); j += 2
                if len(chars) >= 4 and j + 1 < len(data) and data[j] == 0 and data[j + 1] == 0:
                    text = "".join(chars)
                    if printable_text(text):
                        va = base_va + i; exact.setdefault(va, text); spans.append((va, va + ((len(chars) + 1) * 2), text)); counts["utf16"] += 1; i = j + 2; continue
            if i + 24 <= len(data):
                length = struct.unpack_from("<I", data, i + 16)[0]; end = i + 20 + (length * 2)
                if 4 <= length <= 200 and end + 1 < len(data) and data[end : end + 2] == b"\0\0":
                    try: text = data[i + 20 : end].decode("utf-16-le")
                    except UnicodeDecodeError: text = None
                    if text and printable_text(text):
                        obj_va = base_va + i; exact.setdefault(obj_va, text); exact.setdefault(obj_va + 20, text)
                        spans.append((obj_va, obj_va + 22 + (length * 2), text)); counts["il2cpp_utf16"] += 1
            i += 1
    spans.sort(key=lambda x: x[0]); return exact, spans, [x[0] for x in spans], counts
def resolve_string(va, exact, spans, starts):
    if va in exact: return exact[va]
    idx = bisect_right(starts, va) - 1
    if idx >= 0:
        start, end, text = spans[idx]
        if start <= va < end and va - start <= 20: return text
    return None
def build_cs():
    cs = Cs(CS_ARCH_X86, CS_MODE_64); cs.detail = True; return cs
def is_branch(insn):
    return insn.id in (X86_INS_CALL, X86_INS_JMP) or insn.group(X86_GRP_JUMP)
def extract_refs(pe, cs, va, exact, spans, starts, scan_bytes, follow_bytes, max_insns, max_follow, depth=0, seen=None):
    seen = seen or set()
    if va in seen or not pe.is_exec(va): return set(), 0
    seen.add(va); code = pe.read_va(va, scan_bytes)
    if not code: return set(), 0
    refs, follow, used = set(), [], 0
    for idx, insn in enumerate(cs.disasm(code, va)):
        used += insn.size; ops = getattr(insn, "operands", [])
        if insn.mnemonic in {"lea", "mov"} and len(ops) >= 2:
            src, target = ops[1], None
            if src.type == X86_OP_MEM and src.mem.base == X86_REG_RIP:
                target = insn.address + insn.size + src.mem.disp; text = resolve_string(target, exact, spans, starts)
                if text: refs.add(text)
                elif insn.mnemonic == "mov":
                    ptr = pe.read_qword(target)
                    if ptr:
                        text = resolve_string(ptr, exact, spans, starts)
                        if text: refs.add(text)
            elif src.type == X86_OP_IMM:
                target = src.imm
                if pe.is_ro(target):
                    text = resolve_string(target, exact, spans, starts)
                    if text: refs.add(text)
            if depth == 0 and len(refs) < 3 and len(follow) < max_follow and target and is_branch(insn) and pe.is_exec(target): follow.append(target)
        elif depth == 0 and len(follow) < max_follow and is_branch(insn):
            if ops and ops[0].type == X86_OP_IMM and pe.is_exec(ops[0].imm): follow.append(ops[0].imm)
        if idx + 1 >= max_insns or insn.mnemonic in {"ret", "retf", "int3", "ud2"}: break
    if depth == 0 and len(refs) < 3:
        for target in follow[:max_follow]:
            more, _ = extract_refs(pe, cs, target, exact, spans, starts, min(scan_bytes // 2, follow_bytes), follow_bytes, min(max_insns // 2, 300), 0, 1, seen)
            refs.update(more)
            if len(refs) >= 3: break
    return refs, used
def split_words(text):
    return re.findall(r"[A-Z]+(?=[A-Z][a-z]|\d|$)|[A-Z]?[a-z]+|\d+", text)
def pascal(parts):
    out = []
    for part in parts: out.extend(w.capitalize() for w in split_words(part) if w and w.lower() not in STOP)
    return "".join(out)
def clean_tokens(text):
    out = []
    for part in SPLIT_RE.split(text):
        part = part.strip(" {}[]()\"'`<>!?,;")
        if part and part.lower() not in STOP and not (part.isupper() and len(part) <= 2): out.append(part)
    return out
def common_prefix(values):
    words = [split_words(v) for v in values if v]
    if not words: return ""
    prefix = []
    for group in zip(*words):
        if len(set(group)) != 1: break
        prefix.append(group[0])
    return "".join(prefix)
def derive_api_name(strings):
    actions, types, props, calls = Counter(), Counter(), Counter(), Counter()
    for text in strings:
        m = API_RE.match(text)
        if not m: continue
        raw_type, raw_method = m.groups(); toks = [t for t in re.split(r"[./+]", raw_type) if t and t.lower() not in STOP]
        if not toks: continue
        type_name = pascal(toks[-2:] if len(toks) >= 2 else toks[-1:]); method = raw_method.replace("_Injected", ""); types[type_name] += 1
        if method.startswith("get_"): actions["get"] += 1; props[method[4:]] += 1
        elif method.startswith("set_"): actions["set"] += 1; props[method[4:]] += 1
        elif method.startswith(("Is", "Has")): actions["check"] += 1; calls[method] += 1
        else: actions["call"] += 1; calls[method] += 1
    if not types: return None
    domain = types.most_common(1)[0][0]
    if actions["set"] >= max(actions["get"], actions["call"], actions["check"]) and props:
        prefix = common_prefix([pascal([p]) for p, _ in props.most_common(3)])
        return f"Configure{domain}{prefix}" if prefix else f"Configure{domain}"
    if actions["get"] >= max(actions["set"], actions["call"], actions["check"]) and props:
        prefix = common_prefix([pascal([p]) for p, _ in props.most_common(3)])
        return f"Get{domain}{prefix}" if prefix else f"Read{domain}State"
    if actions["check"] and calls:
        name = pascal([calls.most_common(1)[0][0]])
        return name if name.startswith(("Is", "Has")) else f"Check{domain}"
    if calls:
        name = pascal([calls.most_common(1)[0][0]])
        if name.startswith(("Get", "Find", "Load", "Save", "Create", "Destroy", "Update", "Apply", "Set")): return name if domain in name else f"{name}{domain}"
        return f"Process{domain}"
    return None
def derive_name(strings):
    name = derive_api_name(strings)
    if name: return name
    for text in strings:
        m = EVENT_RE.search(text)
        if m: return f"Trigger{pascal([m.group(1)])}"
    for text in strings:
        low = text.lower()
        if "/" in text or "\\" in text:
            toks = clean_tokens(text)
            if len(toks) >= 2:
                core = pascal(toks[-2:] + toks[:1])
                if core: return f"Load{core}"
        if "{0}" in text or "%s" in low or " must " in low or "invalid" in low:
            ids = [t for t in clean_tokens(text) if re.fullmatch(r"[A-Za-z][A-Za-z0-9_]{2,}", t)]
            if ids: return f"Validate{pascal(ids[:2])}"
    for text in strings:
        compact = " ".join(text.split())
        for pat, verb in VERBS:
            m = pat.search(compact)
            if m:
                noun = pascal(clean_tokens(m.group(2))[:3])
                if noun: return f"{verb}{noun}"
    ident, toks = Counter(), Counter()
    for text in strings:
        s = text.strip()
        if re.fullmatch(r"[A-Za-z][A-Za-z0-9_]{2,}", s) and s.lower() not in STOP: ident[s] += 1
        for tok in clean_tokens(s):
            if re.fullmatch(r"[A-Za-z][A-Za-z0-9_]{2,}", tok): toks[tok] += 1
    if ident: return pascal([ident.most_common(1)[0][0]]) or None
    if len(toks) >= 2: return f"Handle{pascal([t for t, _ in toks.most_common(3)])}"
    if toks: return f"Get{pascal([toks.most_common(1)[0][0]])}"
    return None
def method_va(raw_cls, deobf_cls, idx):
    raw_name = (raw_cls.get("methods") or [])[idx]; deobf_name = (deobf_cls.get("methods") or [])[idx]
    for mapping, name in ((deobf_cls.get("method_pointers") or {}, deobf_name), (raw_cls.get("method_pointers") or {}, raw_name), (deobf_cls.get("method_pointers") or {}, raw_name), (raw_cls.get("method_pointers") or {}, deobf_name)):
        va = parse_va(mapping.get(name))
        if va: return va
    return None
def main():
    args = parse_args(); precise, deobf = load_json(args.precise), load_json(args.deobf); pe = PEImage(args.dll); runtime_base = pe.infer_runtime_base(precise)
    print("Loading dumps..."); print("Loading PE..."); print(f"  Runtime image base: 0x{runtime_base:X}")
    print(f"  Read-only sections: {', '.join(sec['name'] for sec in pe.ro_secs)}"); print("Building string table...")
    exact, spans, starts, counts = scan_strings(pe); print(f"  String entries: {len(exact):,} ({dict(counts)})"); cs = build_cs()
    total_hash = scanned = short = with_signal = collisions = 0; names, samples = {}, {}
    for raw_cls, deobf_cls in pair_classes(precise, deobf):
        methods, class_name, refs_by_method = deobf_cls.get("methods") or [], deobf_cls["name"], {}
        for idx, method_name in enumerate(methods):
            if not HASH_RE.fullmatch(str(method_name)): continue
            total_hash += 1; va = method_va(raw_cls, deobf_cls, idx)
            if not va: continue
            refs, used = extract_refs(pe, cs, va, exact, spans, starts, args.scan_bytes, args.max_follow_bytes, args.max_insns, args.max_follow_targets)
            if used < 20: short += 1; continue
            scanned += 1; refs_by_method[method_name] = {"va": va, "strings": sorted(refs)}
        shared = Counter()
        for info in refs_by_method.values(): shared.update(set(info["strings"]))
        for method_name, info in refs_by_method.items():
            strings = [s for s in info["strings"] if shared[s] == 1]
            if len(strings) < 3: strings = [s for s in info["strings"] if shared[s] <= 2]
            if len(strings) < 3: continue
            with_signal += 1; name = derive_name(strings)
            if not name or len(name) < 4 or len(name) > 60 or name in GENERIC: continue
            key = f"{class_name}::{method_name}"
            if key in names and names[key] != name: collisions += 1; continue
            names[key] = name; samples.setdefault(key, {"name": name, "strings": strings[:5], "count": len(strings), "va": f"0x{info['va']:X}"})
    generic = {n for n, c in Counter(names.values()).items() if c > 64}
    if generic:
        names = {k: v for k, v in names.items() if v not in generic}; samples = {k: v for k, v in samples.items() if v["name"] not in generic}
    out = Path(args.output); out.parent.mkdir(parents=True, exist_ok=True)
    out.write_text(json.dumps(dict(sorted(names.items())), indent=2, ensure_ascii=False), encoding="utf-8")
    ordered = sorted(({"key": k, **v} for k, v in samples.items()), key=lambda x: (-x["count"], x["key"]))[:20]
    print("\nReport"); print(f"  Hash-named methods: {total_hash:,}"); print(f"  Scanned methods: {scanned:,}"); print(f"  Short methods skipped: {short:,}")
    print(f"  Methods with >=3 unique string refs: {with_signal:,}"); print(f"  Names derived: {len(names):,}")
    print(f"  Coverage improvement estimate: {len(names):,}/{total_hash:,} = {len(names) / max(total_hash, 1):.1%}")
    if collisions: print(f"  Key collisions skipped: {collisions:,}")
    print("\nTop 20 samples:")
    for row in ordered: print(f"  {row['key']} -> {row['name']} | {row['strings']}")
    print(f"\nWrote {out}"); return 0
if __name__ == "__main__":
    raise SystemExit(main())
