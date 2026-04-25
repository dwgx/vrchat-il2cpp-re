# VRChat IL2CPP Reverse Engineering

> **99.78% of identifiers resolved** — 43,158 classes, 305,681 methods, 41,286 fields  
> GameAssembly.dll (206 MB) | IL2CPP v29.1 | Unity 2022.3.x | Beebyte Obfuscation

## Coverage

| Metric | Count | Coverage |
|--------|------:|----------|
| Classes | 43,158 / 43,158 | **100%** (0 obfuscated) |
| Methods (semantic) | 304,997 / 305,681 | **99.78%** |
| Fields | 41,286 / 41,286 | **100%** (0 obfuscated) |
| Unique source files | 753 | — |
| Unique classes in tree | 14,658 | — |
| Vocabulary | 7,813 unified + 2,137 external = 9,950 names | — |
| Cross-version lifted | 65,849 method names from prior build | — |
| LLM predictions | 21,134 (codex/gemini/gpt-5.5) | — |
| Pipeline runtime | 9.3 seconds full run | — |

## Quick Start

```bash
# Full deobfuscation pipeline (5 stages)
python tools/run_full_pipeline.py

# Skip heavy binary analysis
python tools/run_full_pipeline.py --skip-binary

# Quick vocabulary merge + source tree rebuild
python tools/quick_update.py

# Runtime field extraction (requires VRChat offline)
start "" "VRChat.exe" --no-vr
python tools/extract_field_types_v2.py
```

## Pipeline Architecture

```
precise_dump.json (IL2CPP struct extraction from memory dump)
    │
    ▼
run_full_pipeline.py (orchestrator)
    ├── Stage 0: Merge all name sources → unified_vocabulary.json (7,918 names)
    │     Sources: 3 community deob maps + mod mining + SDK + IDA xrefs + manual
    │
    ├── Stage 1: deobfuscate.py (8-phase rename engine)
    │     vocabulary → string refs → binary analysis → structural → mods → fallback
    │     Result: 73,510 identifiers renamed
    │
    ├── Stage 2: Cross-reference (Photon, SDK, structural matches)
    │     20 high-confidence confirmed matches
    │
    ├── Stage 3: Generate outputs
    │     deobfuscated_dump.json/cs, name_mapping.json, src/ tree (1,137 files)
    │
    └── Stage 4: Generate IDA scripts (133K renames)
```

## Directory Structure

```
├── tools/              52 scripts (39 Python + 13 JavaScript)
│   ├── Core Pipeline       run_full_pipeline.py, deobfuscate.py, quick_update.py
│   ├── Extraction          extract_precise_dump.py, deep_binary_analysis.py
│   ├── Community           match_community_maps.py, deep_mine_v3.py
│   ├── Runtime/Frida       bridge.py/js, vrc_frida_lib.js, frida_auto_gohome.py
│   ├── Auth/Tracing        trace_auth_flow.js, hook_eos_anticheat.js
│   └── Patching            patch_ga_binary.py, deploy_to_steam.py
│
├── output/             Final products
│   ├── src/                1,137 deobfuscated C# source files
│   │   ├── VRC/                VRChat game code (291 files)
│   │   ├── ThirdParty/         Libraries: Photon, BestHTTP, etc (754 files)
│   │   └── Global/             Global namespace (93 files)
│   ├── *.json              Mappings, vocabulary, analysis results
│   └── *.md                Coverage report, protocol analysis, EAC analysis
│
├── data/               Intermediate analysis data
├── ida/                IDA Pro database + scripts (excluded from git)
├── docs/               GitHub Pages dashboard
├── dumps/              Memory dumps (excluded from git, 7.4GB)
├── external/           36+ cloned repos (excluded from git, 4.9GB)
├── metadata/           Patched global-metadata.dat (excluded from git)
└── archive/            80 historical scripts from 5 dev phases (excluded)
```

## Obfuscation: Beebyte

Beebyte Obfuscator renames identifiers to `ÌÍÎÏ` strings (U+00CC-00CF) and **modifies IL2CPP struct layout**:

| Field | Beebyte Offset | Standard Offset |
|-------|---------------|-----------------|
| FieldInfo | +0xA0 | +0x88 |
| field_count | +0x124 | +0x122 |
| MethodInfo code ptr | +0x00 & +0x08 (dup) | +0x00 |
| IL2CPP exports | 264 total, only 3 unobfuscated | — |

## Network Layer

VRChat uses Photon Realtime with FlatBuffer serialization:

```
Application     VRCPlayer / NetworkManager / UdonBehaviour
Serialization   FlatBufferSerializerCodec (8-bit + 32-bit)
Event Layer     VRCPhotonEvent / IFlatBufferNetworkSerializer
Photon          PhotonPeer → EnetPeer (UDP) / TPeer (TCP) / WebSocket
Encryption      PhotonEncryptorPlugin (native DLL)
```

Key findings:
- **15 custom event types** documented (Voice, Serialization, Moderation, etc.)
- **4-token auth chain**: Steam → VRChat API → Photon → EAC
- **Server-side EAC validation** gates room joins via AuthCookie in Photon plugin
- **FlatBuffers** used for both 8-bit (frequent) and 32-bit (full precision) serialization

## EAC Analysis

EAC (EOS Anti-Cheat) runs in Client-Server mode with continuous opaque message exchange:

- **Bypass mode**: EAC not initialized → no integrity messages → server rejects room joins
- **Normal mode**: EAC kernel driver blocks Frida/injection
- **Recommended**: Hybrid workflow — offline+Frida for analysis, MelonLoader+EAC for online

See [EAC Auth Analysis](output/eac_auth_analysis.md) and [Photon Protocol Analysis](output/photon_protocol_analysis.md) for details.

## Key Constraints

- **EAC blocks online analysis** — always use offline VRChat (`VRChat.exe --no-vr`)
- **ASLR** — GameAssembly base changes every launch, hardcoded addresses need updating
- **Never blindly call unknown IL2CPP exports** — crashes Frida/VRChat
- **Bridge trampoline** (bridge.js) writes shellcode in GA .data section for anti-tamper
- **All Python scripts** use `sys.stdout.reconfigure(encoding='utf-8')` for Windows CJK

## Documentation

| Document | Description |
|----------|-------------|
| [Dashboard](docs/index.html) | Interactive visual overview (GitHub Pages) |
| [Coverage Report](output/coverage_report.md) | Deobfuscation coverage metrics |
| [Network Analysis](output/network_layer_analysis.md) | Photon network layer mapping |
| [Photon Protocol](output/photon_protocol_analysis.md) | Protocol reverse engineering |
| [EAC Auth Analysis](output/eac_auth_analysis.md) | EOS anti-cheat authentication |

## License

Private research project. Not for redistribution.
