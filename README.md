# VRChat IL2CPP Reverse Engineering

> **2026-06-05 build** — 88,400 classes, 528,135 methods, 2,870 fields
> GameAssembly.dll (210 MB) | IL2CPP v29.1 | Unity 2022.3.x | Beebyte Obfuscation

## Coverage (June 5 build, quality-audited)

| Metric | Count | Coverage |
|--------|------:|----------|
| Classes (semantic) | 7,813 / 11,503 obfuscated | **67.9%** semantic class names |
| Methods (named) | 481,698 / 528,135 | **91.2%** semantic |
| Methods (hash remaining) | 46,437 | 8.8% fallback (m_XXX) |
| Fields | 2,870 total | runtime extraction pending |
| cross_version entries | 42,013 | quality-audited |
| Pipeline runtime | ~22s full run | — |

Naming sources: RVA propagation (15.5K), LLM mega-batches (2.8K), sibling-context inference (13.5K), IDA Hex-Rays pseudocode, metadata strings, cross-version lifts. Quality audit removed ~7K low-confidence predictions.

## Beebyte struct layout (June 5 build)

Beebyte shuffles `Il2CppClass`/`FieldInfo`/`MethodInfo` field positions every release.
The pipeline re-discovers them with `tools/reverse_struct_layout.py`.

| Offset | Apr 18 | May 2 | **Jun 5** |
|--------|-------:|------:|----------:|
| OFF_NAME | 0x10 | 0x50 | **0x50** |
| OFF_ELEM | — | 0x40 | **0x10** |
| OFF_CAST | 0x48 | 0x80 | **0x40** |
| OFF_FIELDS | 0xA8 | 0x10 | **0x1D8** |
| OFF_METHODS | 0x78 | 0x90 | **0x88** |
| OFF_PARENT | — | 0xA0 | **0x80** |
| MI_NAME | 0x28 | 0x18 | **0x18** |
| FI_STRIDE | 0x30 | 0x28 | **0x30** |
| FI_NAME | 0x10 | 0x00 | **0x08** |

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

## Using the Output

### IDA / Ghidra Rename Script

The pipeline generates `output/ida_apply_names.py` with 226K+ function renames.

```python
# In IDA: File -> Script File -> output/ida_apply_names.py
# The script auto-detects IDA's imagebase via idaapi.get_imagebase()
# No manual base address configuration needed
```

For Ghidra or other tools, use `output/name_mapping.json`:
```json
{
  "methods": { "OriginalObfClass::OrigObfMethod": "SemanticName", ... },
  "classes": { "ÌÍÎÏÍÌÎ...": "VRCPlayer", ... }
}
```

### Deobfuscated Dump Format (dump.cs)

`output/deobfuscated_dump.cs` uses **RVA** (Relative Virtual Address) for method offsets, similar to Il2CppDumper output:

```csharp
public class VRCPlayer : VRCPlayerApi
{
    public Transform _avatar; // 0x48
    void Awake(); // RVA: 0x1A2B3C0
    void OnPhotonSerializeView(); // RVA: 0x1A2B520
}
```

To use RVAs in IDA/Ghidra: `imagebase + RVA = actual address`.
IDA's default imagebase for PE files is `0x180000000`. The runtime GA base varies per launch due to ASLR.

For richer output with field types, use the source tree (`output/src/`) which includes resolved types and offsets from `field_types.json` when available.

### Metadata Decryption

VRChat encrypts `global-metadata.dat` with Beebyte's custom XOR scheme. Use `tools/decrypt_metadata.py`:

```bash
python tools/decrypt_metadata.py <path_to_global-metadata.dat> <output_path>
```

Algorithm (reverse-engineered from `sub_180A7E880` in GameAssembly.dll):
1. **Header** (first 0x148 bytes): XOR with `key[i] = (i - 0x34) & 0xFF`
2. **Sections**: 7 sections XOR-decoded with position-dependent keys derived from header size fields

The decrypted metadata enables `tools/lift_typedef_tokens.py` to recover real class/method names from TypeDefinition tokens.

**Note**: The encryption constants may change with new VRChat builds. If decryption produces invalid output, re-analyze the decrypt function in GameAssembly.dll (search for the metadata magic `0xFAB11BAF` handler).

## Documentation

| Document | Description |
|----------|-------------|
| [Workflow Guide](WORKFLOW.md) | Complete pipeline guide for new contributors |
| [Dashboard](docs/index.html) | Interactive visual overview (GitHub Pages) |
| [Coverage Report](output/pipeline_coverage_report.md) | Current pipeline coverage metrics |
| [Network Analysis](output/network_layer_analysis.md) | Photon network layer mapping |
| [Photon Protocol](output/photon_protocol_analysis.md) | Protocol reverse engineering |
| [EAC Auth Analysis](output/eac_auth_analysis.md) | EOS anti-cheat authentication |

## License

Private research project. Not for redistribution.
