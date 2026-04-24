#!/usr/bin/env python3
"""
Deep Binary Analysis for VRChat GameAssembly.dll
-------------------------------------------------
Phase 1: Deep string extraction (2048 bytes per function)
Phase 2: Call graph construction (follow CALL/JMP targets)
Phase 3: Name propagation through call graph
Phase 4: Method-level semantic naming
Phase 5: Re-classify previously opaque classes

Output: il2cpp_full_dump/deep_analysis.json
"""

import json, sys, os, re, struct, collections, hashlib, time
import pefile
from capstone import Cs, CS_ARCH_X86, CS_MODE_64, CS_OP_IMM, CS_OP_MEM
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')

BASE_DIR = Path(__file__).parent
GA_PATH = BASE_DIR / '..' / '..' / 'GameAssembly.dll'
DUMP_PATH = BASE_DIR / 'il2cpp_full_dump' / 'precise_dump.json'
OUTPUT_PATH = BASE_DIR / 'il2cpp_full_dump' / 'deep_analysis.json'

DLL_BASE = 0x7FFB4D2AA000
SCAN_BYTES = 2048  # 4x the previous scan
MAX_CALL_DEPTH = 2  # follow calls up to 2 levels deep

OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')


class DeepAnalyzer:
    def __init__(self):
        print('Loading PE...')
        self.pe = pefile.PE(str(GA_PATH), fast_load=True)

        self.sections = []
        for sec in self.pe.sections:
            name = sec.Name.decode().rstrip('\x00')
            self.sections.append({
                'name': name,
                'va': sec.VirtualAddress,
                'vsize': sec.Misc_VirtualSize,
                'raw_offset': sec.PointerToRawData,
                'raw_size': sec.SizeOfRawData,
            })

        rdata = next(s for s in self.sections if s['name'] == '.rdata')
        self.rdata_rva_start = rdata['va']
        self.rdata_rva_end = rdata['va'] + rdata['vsize']

        # Code sections bounds
        text = next(s for s in self.sections if s['name'] == '.text')
        il2cpp = next(s for s in self.sections if s['name'] == 'il2cpp')
        self.code_rva_start = text['va']
        self.code_rva_end = il2cpp['va'] + il2cpp['vsize']

        print(f'Reading GameAssembly.dll...')
        with open(str(GA_PATH), 'rb') as f:
            self.ga_data = f.read()
        print(f'  {len(self.ga_data) / 1024 / 1024:.1f} MB')

        self.cs = Cs(CS_ARCH_X86, CS_MODE_64)
        self.cs.detail = True

        # Load dump
        print('Loading precise_dump.json...')
        with open(str(DUMP_PATH), 'r', encoding='utf-8') as f:
            self.dump = json.load(f)

        # Build RVA → (class_name, method_name) lookup
        self.rva_to_method: dict[int, tuple[str, str]] = {}
        self.class_methods: dict[str, dict[str, int]] = {}  # class -> {method: rva}

        for ns, classes in self.dump['namespaces'].items():
            for cls in classes:
                name = cls['name']
                ptrs = cls.get('method_pointers', {})
                methods_rva = {}
                for m, ptr_str in ptrs.items():
                    try:
                        va = int(ptr_str, 16)
                        if va > 0x100000000:
                            rva = va - DLL_BASE
                            if self.code_rva_start <= rva <= self.code_rva_end:
                                self.rva_to_method[rva] = (name, m)
                                methods_rva[m] = rva
                    except:
                        pass
                if methods_rva:
                    self.class_methods[name] = methods_rva

        print(f'Indexed {len(self.rva_to_method)} method RVAs across {len(self.class_methods)} classes')

        # Results
        self.method_strings: dict[int, list[str]] = {}  # rva -> strings
        self.method_calls: dict[int, list[int]] = {}  # rva -> [called_rvas]
        self.method_api_calls: dict[int, list[str]] = {}  # rva -> [api_signatures]

        # Cache for already-scanned functions
        self._scan_cache: dict[int, tuple[list[str], list[int]]] = {}

    def rva_to_offset(self, rva: int) -> int | None:
        for sec in self.sections:
            if sec['va'] <= rva < sec['va'] + sec['vsize']:
                off = sec['raw_offset'] + (rva - sec['va'])
                if off < len(self.ga_data):
                    return off
        return None

    def read_string_at_offset(self, offset: int, max_len: int = 300) -> str | None:
        if offset < 0 or offset >= len(self.ga_data):
            return None
        end = self.ga_data.find(b'\x00', offset, offset + max_len)
        if end > offset:
            candidate = self.ga_data[offset:end]
            try:
                s = candidate.decode('ascii')
                if len(s) >= 3 and s.isprintable():
                    return s
            except:
                pass
        return None

    def scan_function(self, rva: int, depth: int = 0) -> tuple[list[str], list[int]]:
        """Disassemble function, extract strings and call targets."""
        if rva in self._scan_cache:
            return self._scan_cache[rva]

        offset = self.rva_to_offset(rva)
        if offset is None:
            return [], []

        code = self.ga_data[offset:offset + SCAN_BYTES]
        strings = []
        call_targets = []

        for insn in self.cs.disasm(code, rva, count=300):
            # LEA with RIP-relative → string reference
            if insn.mnemonic == 'lea' and len(insn.operands) == 2:
                op = insn.operands[1]
                if op.type == CS_OP_MEM and op.mem.base == 41:  # RIP
                    target_rva = insn.address + insn.size + op.mem.disp
                    if self.rdata_rva_start <= target_rva < self.rdata_rva_end:
                        t_off = self.rva_to_offset(target_rva)
                        if t_off:
                            s = self.read_string_at_offset(t_off)
                            if s:
                                strings.append(s)

            # CALL with relative offset → direct call target
            elif insn.mnemonic == 'call' and len(insn.operands) == 1:
                op = insn.operands[0]
                if op.type == CS_OP_IMM:
                    target = op.imm
                    # Adjust for capstone's handling of signed immediates
                    if target < 0:
                        target = target & 0xFFFFFFFFFFFFFFFF
                    target_rva_calc = target  # capstone gives absolute address = rva for our case
                    if self.code_rva_start <= target_rva_calc <= self.code_rva_end:
                        call_targets.append(target_rva_calc)
                    elif self.rdata_rva_start <= target_rva_calc < self.rdata_rva_end:
                        # Indirect call via .rdata (import)
                        pass

            # MOV imm → might be VA pointing to .rdata
            elif insn.mnemonic == 'mov' and len(insn.operands) == 2:
                op = insn.operands[1]
                if op.type == CS_OP_IMM:
                    target_rva = op.imm - DLL_BASE
                    if self.rdata_rva_start <= target_rva < self.rdata_rva_end:
                        t_off = self.rva_to_offset(target_rva)
                        if t_off:
                            s = self.read_string_at_offset(t_off)
                            if s:
                                strings.append(s)

            # Stop at RET / INT3
            if insn.mnemonic in ('ret', 'int3') and insn.address > rva + 16:
                break

        # Deduplicate
        strings = list(set(strings))
        call_targets = list(set(call_targets))

        self._scan_cache[rva] = (strings, call_targets)

        # Follow calls (depth-limited)
        if depth < MAX_CALL_DEPTH:
            for target in call_targets[:20]:  # limit to 20 calls per function
                if target not in self._scan_cache:
                    sub_strings, _ = self.scan_function(target, depth + 1)
                    strings.extend(sub_strings)

        return list(set(strings)), call_targets

    def phase1_deep_scan(self):
        """Deep scan ALL method pointers."""
        print(f'\n=== Phase 1: Deep Scan ({len(self.rva_to_method)} methods) ===')
        t0 = time.time()
        scanned = 0
        methods_with_strings = 0

        for rva, (cls_name, method_name) in self.rva_to_method.items():
            strings, calls = self.scan_function(rva, depth=0)
            if strings:
                self.method_strings[rva] = strings
                methods_with_strings += 1
            if calls:
                self.method_calls[rva] = calls
            scanned += 1
            if scanned % 5000 == 0:
                elapsed = time.time() - t0
                rate = scanned / elapsed
                eta = (len(self.rva_to_method) - scanned) / rate
                print(f'  {scanned}/{len(self.rva_to_method)} scanned, '
                      f'{methods_with_strings} with strings, '
                      f'{len(self._scan_cache)} cached, '
                      f'ETA {eta:.0f}s')

        elapsed = time.time() - t0
        print(f'  Done in {elapsed:.1f}s: {methods_with_strings}/{scanned} methods have string refs')

    def phase2_call_graph_naming(self):
        """Use call graph to propagate names: if method A calls known method B, A is related."""
        print(f'\n=== Phase 2: Call Graph Name Propagation ===')

        # For each method, check what known methods it calls
        method_domain: dict[int, list[str]] = {}  # rva -> domain tags

        for rva, calls in self.method_calls.items():
            domains = []
            for target_rva in calls:
                if target_rva in self.rva_to_method:
                    cls_name, method_name = self.rva_to_method[target_rva]
                    if not OBF_RE.match(cls_name):
                        # Calls a known class method!
                        domains.append(cls_name)
                    if not OBF_RE.match(method_name):
                        domains.append(method_name)
            if domains:
                method_domain[rva] = domains

        print(f'  {len(method_domain)} methods call known targets')

        # Aggregate domains per class
        self.class_call_domains: dict[str, list[str]] = {}
        for rva, domains in method_domain.items():
            if rva in self.rva_to_method:
                cls_name = self.rva_to_method[rva][0]
                if OBF_RE.match(cls_name):
                    if cls_name not in self.class_call_domains:
                        self.class_call_domains[cls_name] = []
                    self.class_call_domains[cls_name].extend(domains)

        print(f'  {len(self.class_call_domains)} obfuscated classes call known code')

    def phase3_method_naming(self):
        """Name individual methods based on their string refs and call targets."""
        print(f'\n=== Phase 3: Method-Level Naming ===')

        # Unity API → short semantic name for the METHOD
        API_METHOD_NAMES = {
            'set_enabled': 'SetEnabled',
            'get_enabled': 'GetEnabled',
            'get_transform': 'GetTransform',
            'get_gameObject': 'GetGameObject',
            'get_activeSelf': 'GetActiveSelf',
            'get_activeInHierarchy': 'GetActiveInHierarchy',
            'SetActive': 'SetActive',
            'set_localPosition': 'SetLocalPosition',
            'get_localPosition': 'GetLocalPosition',
            'set_position': 'SetPosition',
            'get_position': 'GetPosition',
            'set_rotation': 'SetRotation',
            'get_rotation': 'GetRotation',
            'set_localScale': 'SetLocalScale',
            'get_lossyScale': 'GetLossyScale',
            'TransformPoint': 'TransformPoint',
            'TransformDirection': 'TransformDirection',
            'InverseTransformPoint': 'InverseTransformPoint',
            'SetParent': 'SetParent',
            'GetParent': 'GetParent',
            'Destroy': 'DoDestroy',
            'Instantiate': 'DoInstantiate',
            'DontDestroyOnLoad': 'MarkDontDestroy',
            'set_volume': 'SetVolume',
            'get_isPlaying': 'GetIsPlaying',
            'Play': 'PlayAudio',
            'Stop': 'StopAudio',
            'Render': 'DoRender',
            'set_type': 'SetLightType',
            'DrawLine': 'DrawGizmoLine',
            'SetTriggerID': 'SetAnimTrigger',
            'SetBool': 'SetAnimBool',
            'SetFloat': 'SetAnimFloat',
            'SetInteger': 'SetAnimInt',
            'get_isDone': 'CheckIsDone',
            'get_value': 'GetRandomValue',
            'BeginSample': 'BeginProfiler',
            'get_realtimeSinceStartup': 'GetRealtime',
            'get_deltaTime': 'GetDeltaTime',
            'get_time': 'GetTime',
        }

        self.method_semantic_names: dict[tuple[str, str], str] = {}  # (class, method) -> name
        named_count = 0

        for rva, (cls_name, method_name) in self.rva_to_method.items():
            if not OBF_RE.match(method_name):
                continue

            strings = self.method_strings.get(rva, [])
            if not strings:
                continue

            # Find the most specific API call
            best_name = None
            best_score = 0

            for s in strings:
                # Parse "UnityEngine.ClassName::MethodName(params)"
                m = re.search(r'::(\w+)\(', s)
                if m:
                    api_method = m.group(1)
                    if api_method in API_METHOD_NAMES:
                        name = API_METHOD_NAMES[api_method]
                        score = len(name)
                        if score > best_score:
                            best_name = name
                            best_score = score
                    elif len(api_method) > 4 and api_method[0].isupper():
                        # Use the API method name directly
                        score = len(api_method)
                        if score > best_score:
                            best_name = f'Do{api_method}'
                            best_score = score

                # Check for error strings (very informative)
                if 'cannot' in s.lower() or 'null' in s.lower() or 'invalid' in s.lower():
                    # Extract key terms from error message
                    error_words = re.findall(r'[A-Z][a-z]+', s)
                    if error_words and len(error_words[0]) > 3:
                        candidate = f'Check{error_words[0]}'
                        if len(candidate) > best_score:
                            best_name = candidate
                            best_score = len(candidate)

            if best_name:
                h = hashlib.sha256(method_name.encode()).hexdigest()[:3].upper()
                self.method_semantic_names[(cls_name, method_name)] = f'{best_name}_{h}'
                named_count += 1

        print(f'  Named {named_count} methods semantically')

    def phase4_aggregate_class_strings(self):
        """Aggregate all string refs per class for improved class naming."""
        print(f'\n=== Phase 4: Aggregate Class String Refs ===')

        self.class_all_strings: dict[str, list[str]] = {}

        for rva, (cls_name, method_name) in self.rva_to_method.items():
            if not OBF_RE.match(cls_name):
                continue
            strings = self.method_strings.get(rva, [])
            if strings:
                if cls_name not in self.class_all_strings:
                    self.class_all_strings[cls_name] = []
                self.class_all_strings[cls_name].extend(strings)

        # Also add call graph domains
        for cls_name, domains in self.class_call_domains.items():
            if cls_name not in self.class_all_strings:
                self.class_all_strings[cls_name] = []
            self.class_all_strings[cls_name].extend(domains)

        # Deduplicate per class
        for cls_name in self.class_all_strings:
            self.class_all_strings[cls_name] = list(set(self.class_all_strings[cls_name]))

        print(f'  {len(self.class_all_strings)} obfuscated classes have binary analysis data')

    def save(self):
        print(f'\n=== Saving Results ===')

        output = {
            'dll_base': f'0x{DLL_BASE:X}',
            'scan_bytes': SCAN_BYTES,
            'max_call_depth': MAX_CALL_DEPTH,
            'total_methods_scanned': len(self.rva_to_method),
            'methods_with_strings': len(self.method_strings),
            'methods_with_calls': len(self.method_calls),
            'classes_with_binary_data': len(self.class_all_strings),
            'method_semantic_names': {
                f'{cls}::{method}': name
                for (cls, method), name in self.method_semantic_names.items()
            },
            'class_string_refs': self.class_all_strings,
            'class_call_domains': {k: list(set(v)) for k, v in self.class_call_domains.items()},
        }

        with open(str(OUTPUT_PATH), 'w', encoding='utf-8') as f:
            json.dump(output, f, indent=2, ensure_ascii=False)

        print(f'  Saved to {OUTPUT_PATH}')
        print(f'  Method semantic names: {len(self.method_semantic_names)}')
        print(f'  Classes with binary data: {len(self.class_all_strings)}')

    def run(self):
        self.phase1_deep_scan()
        self.phase2_call_graph_naming()
        self.phase3_method_naming()
        self.phase4_aggregate_class_strings()
        self.save()


if __name__ == '__main__':
    analyzer = DeepAnalyzer()
    analyzer.run()
