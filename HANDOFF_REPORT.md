# VRChat IL2CPP Reverse Engineering Handoff

> ⚠️ **HISTORICAL SNAPSHOT (2026-06-05 audit).** Coverage numbers in this document
> predate the v2.3 quality audit. For current canonical numbers see
> `output/coverage_stats.json`; for the up-to-date workflow and handoff guide see
> `WORKFLOW.md` (especially §6 "接手者：从这里开始"). This file is retained for its
> detailed architectural/tool inventory, which remains accurate.

Generated during repository audit on 2026-06-05 JST.

Scope: current checkout of `D:\Project\vrchat-il2cpp-re`. This report is based on direct review of the core pipeline, deobfuscator, Frida scripts, IDA scripts, LLM naming tools, protocol documents, dashboard, source-tree product, and repository inventories. Some artifacts are stale relative to others: `README.md` and `output/pipeline_coverage_report.md` describe the May 2026 / 86K-class build, while `output/coverage_report.md` and `docs/index.html` describe older April snapshots. Those discrepancies are called out instead of normalized away.

## 1. Core Pipeline

### 1.1 Orchestrator: `tools/run_full_pipeline.py`

`tools/run_full_pipeline.py` is the top-level automation for the current project. Its default run executes stages `0,1,2,3,4`; stage `5` is opt-in because it requires a live offline VRChat process for Frida field extraction.

Documented stages in the script:

| Stage | Name | Main Inputs | Main Outputs | What It Does |
|---:|---|---|---|---|
| 0 | Gather all name sources | `output/master_vocabulary.json`, community maps, SDK extracts, mined names, cross-version maps, `data/apr25_lifted_vocab.json` | `output/unified_vocabulary.json` | Merges all vocabulary and signature/name sources into a single typed vocabulary. |
| 1 | Main deobfuscation | `data/precise_dump.json`, `output/unified_vocabulary.json`, method-name side maps | `output/deobfuscated_dump.json`, `output/deobfuscated_dump.cs`, `output/name_mapping.json`, `output/deobfuscation_report.md` | Instantiates `Deobfuscator`, optionally injects signature mappings, runs all class/method/field rename phases. |
| 2 | Additional cross-references | deobfuscated dump, name mapping, `output/structural_matches.json`, `output/community_name_mapping.json`, `output/additional_names.json`, protocol doc | Updated `output/deobfuscated_dump.json`, `output/name_mapping.json` | Applies high-confidence overrides to weak names from Photon indicators, structural matches, community direct matches, and source-analysis type rules. |
| 3 | Generate outputs | `output/deobfuscated_dump.json` | `output/src/`, `output/pipeline_coverage_report.md`, `.prev_deobf_hash.json` | Regenerates source tree using delta fingerprints and writes a pipeline coverage report. |
| 4 | IDA scripts | `output/deobfuscated_dump.json`, `output/name_mapping.json` | `output/ida_apply_names.py` | Generates IDAPython rename script using method RVA/name data. |
| 5 | Field type extraction | live `VRChat.exe`, Frida script, existing deobf dump | `output/field_types.json`, merged dump/source tree | Runs `extract_field_types_v2.py`, `merge_field_types.py`, then regenerates source tree. |

The README calls this a "5 stage" pipeline, because stage 5 is optional runtime work. The code actually supports six numeric stages, `0` through `5`.

### 1.2 Stage 0: Vocabulary Merge

Stage 0 builds `output/unified_vocabulary.json` with:

- `unified_names`: all readable identifiers collected from every source.
- `signature_to_name`: context/signature mappings, including class names, method keys, field keys, and cross-version `Class::m_HASH` keys.
- `class_names`, `method_names`, `field_names`: heuristic sub-buckets.
- `stats`, `sources_loaded`, and aggregate counts.

Sources loaded if present:

| Source | Expected Format | Role |
|---|---|---|
| `output/master_vocabulary.json` | `names`, `signature_to_name` | Base vocabulary and known signature mappings. |
| `output/all_community_mappings.json` | `merged_obf_to_real`, `readable_real_names`, `all_real_names` | Community map merger output. Not present in current checkout, but supported. |
| `output/il2cpp_sdk_extractions.json` | classes/enums/deob mappings/all names | Names from SDK-style extraction. |
| `output/mod_extracted_names.json` | mod class names and field patterns | Names mined from mod ecosystem. |
| `output/mined_new_names*.json` | `names` or `all_new` | Names mined from external repositories. In checkout, `mined_new_names_v3.json` exists. |
| `output/cross_version_method_names.json` | `Class::m_HASH -> semanticName` | Main cross-version/LLM method-name input. |
| `output/community_name_mapping.json` | direct/community matches | Adds community names and mappings. |
| `output/structural_matches.json` | structural match map | Adds real names from structural matcher. |
| `output/additional_names.json` | type rules and vocab | Adds manual/source-analysis names. |
| `data/apr25_lifted_vocab.json` | class/method/field lift maps | Direct Apr18/Apr25 lifted vocabulary and signature keys. |

Stage 0 filters obvious junk, then classifies probable classes/methods by naming convention. It does not write to `master_vocabulary.json`; it emits a separate merged artifact.

### 1.3 Stage 1: Main Deobfuscation

Stage 1 requires `data/precise_dump.json`. That file is absent in this checkout, so the current repo has products but cannot run a fresh Stage 1 without restoring the precise dump.

Flow:

1. Add `tools/` to `sys.path`.
2. Import `deobfuscate.py`.
3. Create `Deobfuscator(data/precise_dump.json)`.
4. If `unified_vocab` contains `signature_to_name`, call `_inject_signature_mappings`.
5. Run `deobfuscator.run(output/)`.

Important caveat: `_inject_signature_mappings` only counts/prints available signature matches. It does not directly mutate rules or maps in the reviewed code, so most real signature use happens through files read by `deobfuscate.py`, especially `data/apr25_lifted_vocab.json`, `output/cross_version_method_names.json`, and LLM/IDA maps.

### 1.4 Stage 2: Cross-Reference Overrides

Stage 2 reads the deobfuscated dump and existing mapping, builds indices:

- `orig_index`: `original_name -> class dict`
- `name_index`: current `class['name'] -> class dict`

It only overwrites weak/fallback names as defined by `_is_weak_name`, including prefixes such as `Type`, `Struct`, `Mono`, `Service`, `Major`, `Static`, `DataOnly`, `EmptyType`, `EmptyStruct`, `Record`, `Unknown`, `LargeClass`, and `Class_`.

Subpasses:

- Photon xrefs: parses `output/photon_protocol_analysis.md` for Photon class/method names and updates weak classes that implement Photon callbacks such as `OnPhotonSerializeView`, `OnJoinedRoom`, `OnLeftRoom`, `OnPlayerEnteredRoom`, `OnMasterClientSwitched`, and `OnConnectedToMaster`.
- Structural matches: applies `output/structural_matches.json` entries with confidence `>=70`.
- Community mappings: applies `output/community_name_mapping.json` `direct_matches`.
- Additional names: applies `output/additional_names.json` `type_rules` when a weak class method set contains all target methods.

### 1.5 Stage 3: Output Generation and Delta Source Tree

Stage 3 reads `output/deobfuscated_dump.json`, then tries `_delta_source_tree()`:

- Computes per-class fingerprints from class name, parent, method/field counts, first 10 methods, and first 5 fields.
- Loads `output/.prev_deobf_hash.json`.
- If no previous fingerprints or `output/src` missing, runs `tools/generate_source_tree.py` fully.
- Otherwise identifies changed/new/removed classes, classifies affected domains using `generate_source_tree.py`, deletes affected domain `.cs` files, and rewrites only those.
- Saves new fingerprints to `output/.prev_deobf_hash.json`.

It then writes `output/pipeline_coverage_report.md`. The report computes:

- Total classes.
- Renamed classes, semantic classes, fallback classes.
- Total methods and a narrow `m_`/`f_` renamed-method metric.
- Total fields and renamed fields.

### 1.6 Stage 4: IDA Script Generation

Stage 4 checks for `ida/ga_analysis.i64`, checks `tools/ida_extract.py`, then generates `output/ida_apply_names.py` if `output/name_mapping.json` exists.

The generated script:

- Loads method pointers from `output/deobfuscated_dump.json`.
- Builds `RVA -> Class__Method` map.
- Sanitizes names for IDA (`::`, generics, punctuation).
- Uses `idaapi.get_imagebase()` plus RVA to call `idc.set_name`.

### 1.7 Stage 5: Runtime Field Types

Stage 5 is opt-in. It:

1. Runs `tools/extract_field_types_v2.py` against a live offline VRChat process.
2. Runs `tools/merge_field_types.py`.
3. Runs `tools/generate_source_tree.py`.

Its output is intended to improve field type names and typed source products.

### 1.8 Incremental Cache System

`output/.pipeline_cache.json` records one entry per cached stage:

```json
{
  "stage_0": {
    "input_hashes": {"master_vocabulary.json": "..."},
    "output_hash": "...",
    "timestamp": "YYYY-MM-DD HH:MM:SS",
    "completed": true
  }
}
```

Mechanics:

- `file_hash(path)` streams SHA-256 over each input.
- `STAGE_INPUTS` defines files hashed per stage `0-4`.
- `STAGE_OUTPUTS` defines primary output existence checks per stage.
- `check_stage_cache(stage, cache, force=False)` skips if:
  - cache entry exists,
  - entry marked `completed`,
  - primary output exists,
  - current input hashes exactly match cached hashes,
  - `--force` is not set.
- `record_stage_cache` stores current hashes, output hash if file output, timestamp, and completed flag.
- `--check` reports run/skip decisions without executing.
- `--dry-run` prints intended stages and cache status.

Stage 5 is not included in `STAGE_INPUTS`/`STAGE_OUTPUTS` and is not cached.

### 1.9 Core Deobfuscator: `tools/deobfuscate.py`

`deobfuscate.py` contains the main rename engine. The docstring says "7-phase", while the actual `run()` executes direct lifted names plus Phase 1, Phase 6d, Phase 2, Phase 3, Phase 4, Phase 5, Phase 6, Phase 6b, Phase 6c, Phase 7, then method/field renaming. In practice it is an 11-step class-name pipeline plus method/field rename pass.

Obfuscated-name detection is consistent across the codebase:

```python
OBF_RE = re.compile(r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$')
```

Run order:

1. `phase0_lifted_names`
2. `phase1_compiler_artifacts`
3. `phase6d_community_names`
4. `phase2_semantic_methods`
5. `phase3_property_driven`
6. `phase4_unity_components`
7. `phase5_inheritance`
8. `phase6_cross_reference`
9. `phase6b_shared_methods`
10. `phase6c_binary_strings`
11. `phase7_fallback`
12. `rename_methods_and_fields`
13. `apply_and_save`

#### Phase 0: Direct Lifted Names

Loads `data/apr25_lifted_vocab.json` or builds it in memory via `lift_apr18_to_apr25_vocab.build_lifted_vocab()`. Applies `class_name_map` entries from new obfuscated class names to semantic names when the class exists and has not already been named.

#### Phase 1: Compiler Artifacts

Classifies obvious compiler-generated or CLR artifacts:

- Async state machines: methods contain `MoveNext` and `SetStateMachine` -> `AsyncStateMachine_HASH`.
- Enumerators: fields mention `IEnumerator`; element type is extracted when possible -> `<Element>Enumerator_HASH` or `Enumerator_HASH`.
- Delegates: parent is `MulticastDelegate` -> `Delegate_HASH`.
- Display classes: obfuscated names containing closure markers -> `DisplayClass_HASH`.

#### Phase 6d: Community Confirmed Names

Runs early despite being named "6d" because it has high-confidence hand rules. It maps classes by method-set/parent predicates to real VRChat names such as:

- `VRCPlayer`
- `VRC_Main`
- `VRCUiManager`
- `NetworkManager`
- `VRC_Secondary`
- `FlatBufferNetworkSerializer`
- `VRCNetworkBehaviour`
- `VRCNetworkBehaviourBase`
- `PlayerNet`
- `VRCFlowNetworkManager`
- `PlayerModComponentHealth`
- `VRCFlowManager`
- `VRC_MirrorReflection`
- `IKSolverVR` and subtypes
- `ObjectInstantiator`
- `RoomManager`
- `VRCMotionState`
- `VFXBundleInfo`
- `ServerTimeManager`
- `LightManager`
- `AnimatedTexture`
- `InputControlBinding`
- `AsyncResult`
- `VRC_Interactable`

#### Phase 2: Semantic Method Analysis

For still-obfuscated classes with readable methods:

- Uses `METHOD_SEMANTICS` for strong exact patterns, e.g. `PlayEmoteRPC`, `ReloadAvatarNetworkedRPC`, `OnNetworkReady`, `NeedsSync`, `Encode`, `Decode`, Photon callbacks, pointer callbacks.
- Uses `pick_best_label()` to choose whole method/property labels instead of word soup.
- Uses `extract_interesting_words()` and `DOMAIN_CATEGORIES` to prepend VRChat domains: Avatar, Network, UI, Pointer, Player, World, Audio, Video, Camera, Physics, Animation, Security, Social, Udon, Effect, Data, Texture, PhysBone.
- Adds MonoBehaviour suffixes like `Handler` or `Component` based on event/lifecycle method patterns.

#### Phase 3: Property-Driven Naming

Uses readable `get_X`/`set_X` accessors to build names from property words:

- Data-like classes -> `...Data_HASH`.
- MonoBehaviour classes -> `...Component_HASH`.
- Other classes -> `...Info_HASH`.

#### Phase 4: Unity Component Classification

Targets obfuscated classes inheriting from Unity-ish types (`MonoBehaviour`, `UIBehaviour`, `Graphic`, `Selectable`, `NetworkBehaviour`) and containing lifecycle methods. Chooses structural prefixes:

- `MajorSystem`
- `ComplexComponent`
- `PhysicsComponent`
- `UpdateComponent`
- `LateUpdateComponent`
- `FixedUpdateComponent`
- `LifecycleComponent`
- UI/Network variants when parent context indicates it.

#### Phase 5: Inheritance Chain Resolution

Two-step inheritance cascade:

- Names obfuscated base classes with 3+ children by common child words and common readable methods, falling back to `BaseClassN_HASH`.
- Names unnamed children with `<BasePrefix>_<ChildLabel>_HASH` or `<BasePrefix>Impl_HASH`.

#### Phase 6: Cross-Reference From Known Classes

Uses known/obfuscated relationships:

- If a known class inherits from an obfuscated parent, names parent `<KnownClass>Base_HASH`.
- If an obfuscated class inherits from a meaningful known parent, names it `<Parent>Derived_HASH`.

#### Phase 6b: Shared Method Inference

Builds `obf_method_name -> owner classes` index:

- If an unnamed obfuscated class shares 3+ obfuscated methods with a named sibling, names it `<SiblingPrefix>Sibling_HASH`.
- Builds mid-frequency method clusters for obfuscated methods used by 5-100 classes and names classes `<GroupPrefix>Related_HASH`.

#### Phase 6c: Binary String Reference Naming

Loads `output/deep_analysis.json` if present, else `output/method_string_refs.json`. In this checkout `output/deep_analysis.json` is absent, while `data/method_string_refs.json` exists; the deobfuscator only checks `output/` and legacy `tools/il2cpp_full_dump/`, so this pass may skip unless artifacts are copied to the expected location.

When data is present:

- Maps Unity API strings to domains (`Camera`, `Audio`, `Animation`, `Physics`, `UI`, `Particle`, `Navigation`, etc.).
- Names classes by top API domains plus suffix based on parent/method count (`Component`, `Struct`, `System`, `Handler`).
- Uses call-domain data to name callers `<KnownDomain>Caller_HASH`.

#### Phase 7: Fallback Hashing

Names every remaining obfuscated class with a stable structural prefix and hash suffix:

- `EmptyStruct`, `StructNf`, `Enum`
- `EmptyType`, `DataOnlyNf`, `StaticNm`, `MajorNm`, `ServiceNm`, `RecordNf`, `TypeNmNf`
- `MonoNm`
- `<ResolvedParent>Impl`
- `UnknownNm`

This guarantees zero raw Beebyte class names remain, but fallback names are not true semantic identities.

#### Method and Field Renaming

`rename_methods_and_fields()` processes every class, including duplicate class names not represented in `class_index`.

Method inputs:

- Direct lifted methods from `data/apr25_lifted_vocab.json`.
- `output/ida_method_string_names.json`.
- `output/cross_version_method_names.json`.
- `output/va_propagation_names.json`.
- `output/callgraph_method_names.json`.
- `output/string_api_method_names.json`.
- `output/llm_predicted_names.json`.
- Optional deep analysis method names from `deep_analysis.json`.
- Context heuristics M1-M16 from `_infer_method_name()`.

Method heuristic families:

- Class role patterns: Handler, Manager, Controller, Factory, Provider, Validator, Serializer, Listener, Builder, Converter, Resolver, Comparer, Enumerator, Cache, Pool, Observer, Adapter, Disposable.
- Position rules after `.ctor`, `Dispose`, `Awake`, `OnEnable`.
- Interface implementation extraction.
- `get_`/`set_` and `add_`/`remove_` pairing.
- Async state machine `MoveNext`/`SetStateMachine`.
- Parent virtual method propagation.
- Singleton `GetInstance`.
- MonoBehaviour lifecycle ordering.
- ValueType/Enum standard overrides.
- Collection/interface hints.
- String-ref action extraction.
- UI callback patterns.
- Common override maps for `Object`, `IDisposable`, `Exception`, `Stream`, `TextWriter`, etc.

Field inputs and strategies:

- Runtime field types from `output/field_types.json` when available.
- Lifted fields from `data/apr25_lifted_vocab.json`.
- Backing field cleanup: `<Property>k__BackingField` -> `_property`.
- Accessor ordering and unmatched accessor pairing.
- Runtime type inference through exact maps and substring recovery.
- Single-field class context.
- Parent field propagation by field index.
- Delegate/event detection from `add_` methods.
- Fallback `f_HASH`.

Field type maps cover Unity core, UI, math, events/delegates, async, collections, IO/network, System reflection/timing, Photon, and VRChat types. Substring recovery handles truncated/garbled type strings such as `atrix`, `ector`, `ollider`, `igidbody`, `ransform`, `otonView`, and `donBehaviour`.

### 1.10 Output Files From Deobfuscator

`apply_and_save()` emits:

- `output/deobfuscated_dump.json`: JSON dump with renamed classes/methods/fields and `original_name` annotations.
- `output/deobfuscated_dump.cs`: monolithic C# stub.
- `output/name_mapping.json`: `classes`, `methods`, `fields`, `reverse_classes`.
- `output/deobfuscation_report.md`: phase counts and notable renames.

## 2. All Tools

All Python and JavaScript files in `tools/` are listed below. Inputs/outputs are derived from source constants, docstrings, and observed artifact names. Some scripts use hardcoded local paths for historical builds.

### 2.1 Core Pipeline and Output

| File | Purpose | Inputs | Outputs |
|---|---|---|---|
| `run_full_pipeline.py` | Full staged orchestrator with cache, deobfuscation, source generation, IDA script generation, optional field extraction. | `data/precise_dump.json`, `output/*.json`, `data/apr25_lifted_vocab.json` | `output/unified_vocabulary.json`, deobf dump, mapping, reports, source tree, IDA script |
| `deobfuscate.py` | Main Beebyte deobfuscation engine for classes, methods, and fields. | `data/precise_dump.json`, lifted/cross-version/IDA/LLM maps | `output/deobfuscated_dump.json`, `.cs`, `name_mapping.json`, report |
| `quick_update.py` | Fast vocabulary merge and source-tree regeneration without heavy binary analysis. | existing `output/` and `data/` vocab/mapping files | refreshed vocabulary/source/report artifacts |
| `generate_source_tree.py` | Converts deobfuscated dump into organized C# source tree. | `output/deobfuscated_dump.json` | `output/src/**/*.cs`, `output/src/INDEX.md` |
| `add_manual_names.py` | Adds manually extracted VRChat-specific names. | existing dump/mapping/vocabulary | updates name-source JSONs |
| `apply_new_dump_path.py` | Rewrites default dump path in `extract_precise_dump.py`. | CLI path | patched extractor default |

### 2.2 Extraction and Dumping

| File | Purpose | Inputs | Outputs |
|---|---|---|---|
| `take_new_dump.py` | Takes fresh VRChat memory dump. | running `VRChat.exe` | dump file |
| `new_dump_orchestrator.py` | Waits for Steam-launched VRChat, dumps memory, reruns extraction pipeline. | live process | memory dump and extracted artifacts |
| `extract_precise_dump.py` | Extracts IL2CPP classes/methods/fields from minidump using Beebyte runtime struct offsets. | minidump | `data/precise_dump.json` |
| `extract_live_dump.py` | Extracts IL2CPP type data from live VRChat via Frida. | live process | live dump JSON |
| `extract_field_types.py` | Runtime field type extraction through Frida. | live process + `extract_field_types.js` | `output/field_types.json` |
| `extract_field_types.js` | Frida reader for field type information using earlier offsets. | live process | RPC batch results |
| `extract_field_types_v2.py` | Corrected runtime field type extractor. | live process + `extract_field_types_v2.js` | `output/field_types.json` |
| `extract_field_types_v2.js` | Frida type resolver for corrected Beebyte offsets. | live `Il2CppClass` VAs | field names, offsets, resolved types |
| `extract_field_types_from_dump.py` | Offline minidump field type extractor. | `data/precise_dump.json`, minidump | field-type JSON |
| `extract_field_types_metadata.py` | Extracts field types from decrypted IL2CPP metadata. | global metadata | `output/field_types_from_metadata.json` |
| `extract_field_types_metadata.py` | Metadata v29 field type parser. | global metadata | type JSON |
| `wait_and_extract_fields.py` | Waits for VRChat memory threshold, then runs v2 field extraction. | live process | field types |
| `kerneldump_to_minidump.py` | Converts Windows kernel crash dump into process-like minidump using Volatility. | kernel dump | synthetic minidump |
| `decrypt_metadata.py` | Beebyte metadata decryptor for May 2026 metadata encryption. | encrypted metadata | decrypted metadata |
| `find_metadata_decrypt_idalib.py` | Uses IDA idalib to find metadata decrypt function. | IDA DB / GameAssembly | candidate findings |
| `find_nullref_class.py` | Finds EnterWorld NullRef class/method RVAs. | `precise_dump.json` | printed candidates |

### 2.3 Static Binary, Strings, Calls, and Structure

| File | Purpose | Inputs | Outputs |
|---|---|---|---|
| `reverse_struct_layout.py` | Recovers Beebyte-modified `Il2CppClass`, `MethodInfo`, and `FieldInfo` offsets from minidump. | minidump | `data/reverse_struct_report.json` |
| `verify_struct_layout.py` | Verifies/re-recovers struct offsets from minidump. | minidump | verification report |
| `deep_binary_analysis.py` | Deep GameAssembly string/call analysis. | GameAssembly + dump | `output/deep_analysis.json` style data |
| `extract_string_refs.py` | Disassembles method bodies to find string refs. | GameAssembly + method pointers | method string refs |
| `extract_string_refs_may02.py` | May 2 static string ref miner. | May 2 GameAssembly + dump | `data/method_string_refs_may02.json` |
| `extract_string_refs_native.py` | Native string-ref naming for hash methods. | GameAssembly, string refs | method-name JSON |
| `extract_hash_method_context.py` | Extracts native context for hash methods. | GameAssembly + dump | rich hash-method context |
| `build_callgraph_native.py` | Builds caller-propagated method names directly from GameAssembly. | GameAssembly + dump | call graph names |
| `build_callgraph_names.py` | Builds method names from IDA call graph analysis. | `ida_analysis.json` | `output/callgraph_method_names.json` |
| `build_string_api_names.py` | Names methods from Unity API string refs in IDA analysis. | IDA analysis JSON | `output/string_api_method_names.json` |
| `build_va_propagation_v2.py` | Propagates names across methods sharing compiled VA. | deobf/mapping dumps | `output/va_propagation_names.json` |
| `build_va_propagation_v3.py` | Later VA propagation pass. | deobf/mapping dumps | `output/va_propagation_v3_names.json` |
| `structural_matcher.py` | Matches known community names by structural fingerprints. | dump + community vocab | `output/structural_matches.json` |
| `identify_by_fields.py` | Identifies remaining components by field names. | deobf dump/field data | `output/field_based_identifications.json` |
| `categorize_obf_fields.py` | Categorizes obfuscated field patterns. | dump fields | printed/JSON categories |
| `analyze_global_async.py` | Categorizes Global namespace async/compiler-generated types. | deobf dump | `output/global_async_analysis.json`, hooks |
| `deep_name_vrc_main.py` | Deep static naming of `VRC_Main`/related targets. | dumps/binary context | name predictions |

### 2.4 Cross-Version Lifting

| File | Purpose | Inputs | Outputs |
|---|---|---|---|
| `cross_version_class_map.py` | Maps old/new classes by method body hashes and method-name signatures. | old/new dumps + old/new precise dumps | `data/class_map_old_to_new.json` |
| `lift_apr18_to_apr25_vocab.py` | Lifts Apr18 semantic names onto Apr25 identifiers using class map and positional method/field pairing. | Apr18 precise/deobf, Apr25 precise, class map | `data/apr25_lifted_vocab.json`, CSV |
| `lift_cross_version_names.py` | Signature-based old-to-new name lifting. | old/new dumps | cross-version name maps |
| `lift_by_method_body_hash.py` | Lifts names by hashing executable code windows. | old/new GameAssembly and dumps | `output/method_body_hash_lifts.json` |
| `lift_by_method_body_hash_v2.py` | Canonical x64 body hashing with relocation/call displacement normalization. | old/new GameAssembly and dumps | `output/method_body_hash_lifts_v2.json` |
| `lift_by_body_fuzzy.py` | Extended fuzzy body-hash lifting. | old/new binaries/dumps | fuzzy lift JSON |
| `lift_by_field_access.py` | Names strong-class methods from native field-access patterns. | GameAssembly + dump | field-access method names |
| `lift_by_signature_patterns.py` | Predicts hash method names from structural signature patterns. | deobf/precise dump | signature-pattern names |
| `lift_cross_class_siblings.py` | Propagates method names across structurally similar sibling/impl classes. | deobf dump | sibling lift JSON |
| `lift_from_ida_strings.py` | Lifts hash methods from IDA string refs. | IDA string refs | IDA string based names |
| `lift_from_ida_strings_v2.py` | Aggressive IDA string-ref method naming. | IDA analysis/string refs | v2 names |
| `lift_from_metadata_runtime.py` | Links runtime classes to surviving real names in plaintext metadata. | runtime metadata table | `output/metadata_runtime_lifts.json` |
| `lift_from_static_strings.py` | Mines error/log strings for class/method/field names. | static string mining data | `output/static_string_lifts.json` |
| `lift_new_internal_body.py` | Propagates semantic method names across identical new-build method bodies. | new GameAssembly/dump | internal body propagation |
| `lift_old_new_vtable.py` | Propagates names from old semantic vtable slots to new hash methods. | old/new vtables/dumps | vtable lifts |
| `lift_pinvoke_wrappers.py` | Names obvious P/Invoke wrappers from extern strings. | binary string refs | `output/pinvoke_lifts.json` |
| `lift_property_pairs.py` | Finds getter/setter hash pairs by native field offsets. | binary/dump | property pair names |
| `lift_same_name_methods.py` | Lifts methods between same-name old/new classes. | old/new deobf dumps | `output/same_name_method_lifts.json` |
| `lift_typedef_tokens.py` | Real-name lift via decrypted TypeDefinition tokens. | decrypted metadata | `output/typedef_token_lifts.json` |
| `lift_vtable_propagation.py` | Propagates semantic names across inherited vtable slots. | deobf dump/vtables | vtable propagation names |
| `apply_cross_version_field_types.py` | Fills field types via cross-version class mapping. | old/new field type maps | updated field types |

### 2.5 LLM Batching and Naming

| File | Purpose | Inputs | Outputs |
|---|---|---|---|
| `prepare_llm_batches.py` | Prepares rich method-name batches. | dump, strings, context | `output/llm_batches/*` |
| `build_llm_method_batches.py` | Builds fixed LLM method batch layout. | dump/mapping/context | `output/codex_batch_*.json` |
| `build_hexrays_b_batches.py` | Builds max-context Hex-Rays batches. | Hex-Rays export + dump | `output/llm_batches_hexrays_b/batch_*.json` |
| `gemini_batch_worker.py` | Emits Gemini prompt for one batch. | batch JSON | prompt text |
| `gemini_auto_loop.py` | Repeatedly builds batches, runs Gemini, merges predictions, reruns pipeline, commits. | dump/mapping/cross-version names | `output/gemini_auto/*`, updated cross-version names |
| `run_gemini_batches.sh` | Shell runner for Gemini batches. | batch files | prediction files |
| `run_gemini_bulk.sh` | Bulk Gemini shell runner. | batch files | prediction files |
| `run_gemini_predictions.sh` | Gemini predictions runner. | batch files | prediction files |
| `run_llm_bulk.py` | Dispatches focus batches to Gemini CLI with workers. | batch files | result files |
| `collect_gemini_results.py` | Parses Gemini raw outputs. | raw Gemini outputs | prediction JSON |
| `llm_name_batch_api.py` | Calls OpenAI-compatible chat endpoint for hash method names. | `codex_batch_*.json`, API env vars | `output/codex_pred_*.json` |
| `codex_name_batch.py` | Runs one Codex batch using `codex exec`. | `output/codex_batch_*.json` | `output/codex_pred_*.json` |
| `predict_codex_semantic_batches.py` | Predicts semantic batches locally/rule-based. | batches/context | predictions |
| `generate_codex_preds_local.py` | Local fallback for Codex predictions. | `codex_batch_*.json` | `codex_pred_*.json` |
| `llm_name_from_hexrays.py` | Post-IDA LLM naming driver. | IDA analysis + Hex-Rays export | LLM predictions |
| `hexrays_b_prompt.py` | Generates max-context prompt with strict confidence/output contract. | one Hex-Rays batch | prompt text |
| `run_hexrays_b.py` | Iterates Path B batches through Gemini. | Hex-Rays B batches | `pred_*.json` |
| `merge_hexrays_b.py` | Validates Path B predictions and merges into cross-version names. | `output/llm_batches_hexrays_b/pred_*.json` | `output/cross_version_method_names.json` |
| `merge_llm_predictions.py` | Filters and merges LLM predictions into pipeline input. | `output/llm_batches/results/*_results.json` | `output/llm_predicted_names.json` |
| `llm_predict_field_names.py` | Predicts obfuscated field names via chat completions. | field contexts | field predictions |
| `apply_llm_field_predictions.py` | Applies LLM field predictions into deobf dump. | field predictions, dump | updated dump |
| `llm_name_strong_class_hashes.py` | Names hash methods in strong known classes. | dump/binary context | predictions |
| `name_from_pseudocode.py` | Rule-based naming from Hex-Rays pseudocode. | pseudocode export | `output/pseudocode_rule_names.json` |
| `hexrays_cluster_analysis.py` | Clusters Hex-Rays pseudocode by structural features. | Hex-Rays export + deobf dump | `output/cluster_propagated_names.json` |
| `generate_llm_all_chunk_002.py` | Handwritten prediction generator for chunk 002. | local context files | predictions |
| `generate_llm_all_chunk_008.py` | Handwritten prediction generator for chunk 008. | local context files | predictions |
| `generate_llm_all_chunk_010.py` | Handwritten prediction generator for chunk 010. | local context files | predictions |
| `predict_chunk_000_names.py` | Chunk-specific heuristic predictions. | chunk context | predictions |
| `predict_chunk_001_names.py` | Chunk-specific heuristic predictions. | chunk context | predictions |
| `predict_chunk_003_names.py` | Chunk-specific heuristic predictions. | chunk context | predictions |
| `predict_chunk_007_names.py` | Chunk-specific heuristic predictions. | chunk context | predictions |

### 2.6 Frida Runtime, Scene, and Component Identification

| File | Purpose | Inputs | Outputs |
|---|---|---|---|
| `vrc_frida_lib.js` | Reusable Frida IL2CPP runtime library for Beebyte offsets, class/method/field reads, singleton/instance search, hooks. | live VRChat | JS API |
| `vrc_frida_config.json` | Frida runtime config. | consumed by Frida tools | config values |
| `bridge.js` | Installs GameAssembly `.data` trampoline to call IL2CPP exports with GA return address. | live process | RPC bridge |
| `bridge.py` | Python driver for `bridge.js`. | live process | printed/API results |
| `deep_probe.js` | Generic RVA hook framework with RPC install/stats/timeline. | hook config from Python | call counts/timeline |
| `deep_probe.py` | Python driver that selects methods and controls `deep_probe.js`. | deobf dump + live process | `output/deep_probe_*.json` |
| `identify_components.js` | Early runtime component identifier. | live process | component observations |
| `identify_components.py` | Python driver for early ComplexComponent probing. | live process | runtime names |
| `identify_components_v2.js` | Full scene traversal component identifier. | live process | component list |
| `identify_components_v2.py` | Driver for v2 scene traversal. | live process | identifications |
| `identify_components_v3.js` | Session-independent scene traversal using method RVAs, FlowManager hook, singleton roots, class fingerprints. | live process | component tree/klass info |
| `identify_components_v3.py` | Driver/merger for v3 component identification. | live process + dump | `output/runtime_component_names_v3.json` |
| `process_scene_results.py` | Processes scene traversal output. | scene result JSON | identifications |
| `merge_scene_results.py` | Applies scene identifications to dump. | scene results + deobf dump | updated dump |
| `merge_runtime_names.py` | Merges runtime component names into dump/vocabulary. | `runtime_component_names.json` | updated dump/vocab |
| `merge_field_identifications.py` | Merges field-based identifications into dump. | `field_based_identifications.json` | updated dump |
| `load_cached_worlds.py` | Lists cached worlds, loads one via Frida, scans components. | cache + live process | component scan output |
| `frida_session.py` | Session manager that loads reusable Frida lib/config. | live process | Python API |
| `frida_launch_test.py` | Launches VRChat with timing fix. | bypass launcher | process/logs |
| `frida_auto_gohome.py` | Launches VRChat and triggers GoHome after Photon readiness. | bypass launcher + Frida | runtime action/log |
| `frida_find_gohome.js` | Finds GoHome method via vtable/init hooks. | live process | hook logs |
| `frida_retrigger_gohome.js` | Retriggers GoHome in a running error-world session. | live process | runtime action |
| `frida_timing_fix.js` | Delays/patches timing around home-world join in bypass mode. | live process | runtime behavior |
| `probe_wait.py` | Probes early startup waits with Frida. | spawned process | wait/hook logs |
| `probe_t1.py` | Inspects VERSION.dll thread and module list. | live process | printed diagnostics |
| `probe_threads.py` | Inspects process waits/threads. | live process | printed diagnostics |
| `spawn_keepalive.py` | Spawns VRChat via Frida then detaches after keeping process alive. | VRChat executable | live process |
| `bypass_probe.py` | Probes why direct VRChat launch self-kills. | spawn process | hook logs |
| `bypass_spawn_test.py` | Tests create-suspended/resume without Frida injection. | executable | outcome logs |
| `bypass_wait.py` | Signals process event handles to unblock MelonLoader bootstrap deadlock. | live process | unblocked process/log |
| `unblock_ml.py` | Signals all Event handles in a target process. | PID | process handle side effects |
| `wait_ida.py` | Waits for IDA to finish and reports. | IDA process | status |

### 2.7 Auth, EAC, Photon, and Network Runtime Scripts

| File | Purpose | Inputs | Outputs |
|---|---|---|---|
| `trace_auth_flow.js` | Read-only tracer for Steam -> VRChat API -> Photon -> EAC flow. | live process | logs of Steam/EOS/Photon callbacks |
| `analyze_authcookie.js` | AuthCookie and JoinRoom EAC check tracer. | live process | auth response/cookie/op history logs |
| `intercept_photon_auth.js` | Transport/auth interceptor with optional experimental injection mode. | live process | wire/auth state logs |
| `eac_session_analyzer.js` | EOS Anti-Cheat lifecycle and message exchange analyzer. | EAC/bypass sessions | session stats/messages |
| `hook_eos_anticheat.js` | Local EOS anti-cheat fake-return hooks for offline testing mode. | spawned process | modified local EOS return behavior |
| `hook_steam_init.js` | Fakes SteamAPI init in spawn mode. | spawned process | modified Steam init returns |
| `trace_offline_check.js` | Traces offline mode checks and call stacks. | spawned process | hook logs |
| `photon_packet_capture.py` | Captures and analyzes Photon UDP packets without process modification. | network traffic | packet analysis |
| `patch_eossdk.py` | On-disk EOSSDK patch to fake anti-cheat availability. | EOSSDK DLL | patched DLL + backup |
| `patch_ga_binary.py` | On-disk GameAssembly patches for offline testing restrictions. | GameAssembly DLL | patched DLL + backup |
| `patch_offline.py` | Patches offline mode checks. | GameAssembly / VRChat files | patched binary |
| `patch_steam_api.py` | Patches `steam_api64.dll` to fake Steam init. | Steam API DLL | patched DLL + backup |
| `deploy_launch_bypass.py` | Deploys launch bypass executable to Steam VRChat dir. | `launch_bypass.exe` | replaced launcher + backup |
| `deploy_to_steam.py` | One-click binary/launcher/EOS patch deployment. | patch scripts + Steam install | patched Steam VRChat tree |
| `launch_bypass.cs` | C# source for bypass launcher. | compiler | `launch_bypass.exe` |

### 2.8 IDA Integration Tools in `tools/`

| File | Purpose | Inputs | Outputs |
|---|---|---|---|
| `ida_extract.py` | Headless IDA string/xref extraction. | GameAssembly in IDA | IDA analysis JSON |
| `ida_extract_new.py` | New-build headless IDA extraction. | new GameAssembly in IDA | IDA analysis JSON |
| `ida_hexrays_export.py` | Batch Hex-Rays decompilation export. | IDA DB + target list | Hex-Rays JSON |
| `ida_hexrays_resilient.py` | Resilient incremental Hex-Rays export. | target VAs | surgical Hex-Rays JSON |
| `ida_hexrays_surgical.py` | Decompile only specified VAs. | `data/hexrays_target_vas.json` | `output/v_new_ida/hexrays_surgical.json` |
| `ida_apply_then_hexrays.py` | Applies names first, then Hex-Rays on targets. | name mapping + IDA DB | renamed IDB + Hex-Rays export |
| `merge_ida_analysis.py` | Merges IDA static component analysis into dump/vocab. | `output/ida_component_analysis.json` | updated dump/vocab |
| `identify_components_ida.py` | Identifies ComplexComponents from IDA strings/calls/fields. | IDA analysis + dump | component analysis JSON |

### 2.9 Community Mining

| File | Purpose | Inputs | Outputs |
|---|---|---|---|
| `mine_external_community_names.py` | Mines community deob maps for names not in current mapping. | external repos + current mapping | `output/external_mined_names.json` |
| `match_community_maps.py` | Matches community Unhollower-style signatures to precise dump. | community maps + dump | `output/community_name_mapping.json` |
| `merge_community_maps.py` | Merges external community mappings. | `external/deob-maps/*` | `output/all_community_mappings.json` |
| `deep_mine_sources.py` | Deep mines client source repos for class/method/field/enum names. | external repos | mined names |
| `deep_mine_v2.py` | Focused quality-driven source mining. | external repos | mined names |
| `deep_mine_v3.py` | Clean source mining from original sources and fresh mining. | external repos | `output/mined_new_names_v3.json` |
| `merge_new_name_sources.py` | Merges many new name sources into cross-version method map. | optional lift/prediction JSONs | `output/cross_version_method_names.json` |

### 2.10 Miscellaneous and Chunk Tools

| File | Purpose | Inputs | Outputs |
|---|---|---|---|
| `find_metadata_decrypt_idalib.py` | IDA idalib metadata decrypt finder. | IDA DB | candidates |
| `deep_binary_analysis.py` | Binary string/API/call analysis. | GameAssembly/dump | deep analysis JSON |
| `run_weak_body_queue.sh` | Shell runner for weak body naming queue. | weak-body batches | predictions |
| `run_gemini_*` scripts | Shell wrappers around Gemini prediction batches. | batch JSONs | pred JSONs |
| `melon_probe_mod.cs` | MelonLoader probe mod source. | build toolchain | mod DLL |
| `patch_*` scripts | Binary patch helpers. | DLLs/exe | patched binaries/backups |

## 3. Data Flow

### 3.1 End-to-End Flow

```text
Memory dump / live process
  -> tools/reverse_struct_layout.py / verify_struct_layout.py
  -> tools/extract_precise_dump.py
  -> data/precise_dump.json
       |
       +-- Stage 0 vocab merge
       |     master/community/SDK/mod/mined/cross-version/IDA/LLM/runtime sources
       |     -> output/unified_vocabulary.json
       |
       +-- Stage 1 deobfuscate.py
       |     class phases + method/field rename
       |     -> output/deobfuscated_dump.json
       |     -> output/deobfuscated_dump.cs
       |     -> output/name_mapping.json
       |
       +-- Stage 2 cross-reference overrides
       |     Photon + structural + community + additional rules
       |     -> updated deobfuscated_dump/name_mapping
       |
       +-- Stage 3 products
       |     -> output/src/**/*.cs
       |     -> output/pipeline_coverage_report.md
       |
       +-- Stage 4 IDA rename product
             -> output/ida_apply_names.py
```

Side channels:

- Runtime Frida field types: live VRChat -> `output/field_types.json` -> `merge_field_types.py` -> updated dump/source.
- IDA static analysis: IDA extraction/decompilation -> `output/ida_*`, Hex-Rays JSON -> LLM/rule naming -> merge maps -> pipeline.
- Cross-version lifting: old/new dumps and binaries -> class/body/vtable/field/string lifts -> `output/cross_version_method_names.json` and related maps -> pipeline.
- LLM naming: batches -> provider outputs -> filtered/merged `output/llm_predicted_names.json` or `cross_version_method_names.json` -> pipeline.

### 3.2 Key JSON Artifacts in `data/`

| File | Purpose |
|---|---|
| `all_method_strings_may02.json` | Method VA to string references for May 2 build. |
| `api_mapping.json` | API probe mapping and export-to-real map. |
| `api_probe_results.json` | Results of probing obfuscated IL2CPP exports. |
| `apr25_lifted_vocab.json` | Direct old-to-new lifted class/method/field vocabulary; major Stage 0/1 input. |
| `class_map_old_to_new.json` | Old class VA to new class VA mapping. |
| `deep_mapping.json` | Deeper export/API mapping data. |
| `disasm_results.json` | Disassembly mapping/features/assemblies/sample class data. |
| `export_code_raw.json` | Raw export/code/assembly/class extraction data. |
| `export_mapping.json` | Known/analysis/final export mapping. |
| `exports.json` | List of 264 exports. |
| `final_mapping.json` | Final export/function mapping groups. |
| `hash48_target_vas.json` | Small target VA list for hash/body analysis. |
| `il2cpp_export_map.json` | Obfuscated export names to known IL2CPP API names. |
| `log_extracted_names.json` | Names extracted from log tags and type mentions. |
| `metadata_real_names.json` | Real names recovered from metadata. |
| `metadata_unused_real_names.json` | Metadata real names not yet used. |
| `method_string_refs.json` | Class string references from method body scanning. |
| `method_string_refs_may02.json` | May 2 method string refs by class. |
| `real_functions.json` | Export-to-real-function mapping. |
| `reverse_struct_report_may02.json` | Struct layout discovery report for May 2 build. |
| `runtime_typeinfo_table.json` | Runtime TypeInfo table keyed by addresses. |
| `string_heap.json` | Small string heap scan result. |

Missing but expected by pipeline:

- `data/precise_dump.json`: required for Stage 1. The README and products imply it existed during previous runs, but it is not in this checkout.

### 3.3 Key JSON Artifacts in `output/`

Core products and reports:

| File | Purpose |
|---|---|
| `.pipeline_cache.json` | Stage input hashes and completion metadata. |
| `.prev_deobf_hash.json` | Source tree delta fingerprints. |
| `deobfuscated_dump_old_build.json` | Old-build deobfuscated dump snapshot. |
| `name_mapping_old_build.json` | Old-build name mapping. |
| `unified_vocabulary.json` | Current merged vocabulary. |
| `master_vocabulary.json` | Base vocabulary. |
| `coverage_stats.json` | Structured coverage stats used by reports/dashboard. |

Name-source and lift maps:

| File | Purpose |
|---|---|
| `additional_names.json` | Manual/source-analysis class/method/type rules. |
| `archive_recovered_names.json` | Small archive recovered names list. |
| `callgraph_method_names.json` | Method names inferred from call graph. |
| `llm_legacy_hexrays_names.json` | Small LLM Hex-Rays predictions. |
| `llm_legacy_pseudocode_names.json` | Small LLM pseudocode predictions. |
| `llm_legacy_theme_names.json` | Empty theme-name prediction file (legacy). |
| `cluster_propagated_names.json` | Hex-Rays cluster propagation output. |
| `community_name_mapping.json` | Community direct matches/vocabulary. |
| `cross_version_lifted_names.json` | Cross-version class/method lift data. |
| `cross_version_method_names.json` | Primary `Class::m_HASH -> name` method map. |
| `external_mined_names.json` | Names mined from community/external sources. |
| `field_based_identifications.json` | Component identifications by fields. |
| `field_types_from_metadata.json` | Metadata-derived field type info. |
| `ida_class_strings.json` | Class strings from IDA. |
| `ida_component_analysis.json` | IDA component identification analysis. |
| `ida_method_string_names.json` | IDA string-ref method names. |
| `il2cpp_sdk_extractions.json` | SDK-derived classes/enums/mappings/names. |
| `llm_predicted_names.json` | Filtered LLM method predictions; 21,134 entries in current summary. |
| `metadata_runtime_lifts.json` | Runtime metadata name lifts. |
| `method_body_hash_lifts.json` | Small first-generation body hash lifts. |
| `method_body_hash_lifts_v2.json` | Canonical body hash lifts. |
| `mined_new_names_v3.json` | Current mined names from external repos. |
| `mod_extracted_names.json` | Mod-derived names/field patterns. |
| `old_new_index_match_v2.json` | Old/new index matches. |
| `pinvoke_lifts.json` | P/Invoke wrapper method lifts. |
| `pseudocode_rule_names.json` | Rule-based pseudocode names. |
| `runtime_component_names.json` | Runtime component names. |
| `runtime_component_names_v3.json` | v3 runtime scene/component identifications. |
| `same_name_method_lifts.json` | Same-name class method lifts. |
| `scene_traversal_results.json` | Scene traversal identifications. |
| `static_string_lifts.json` | Static string lifts. |
| `structural_matches.json` | Structural matcher output. |
| `typedef_token_lifts.json` | TypeDefinition token lifts. |
| `va_propagation_names.json` | Shared-VA method name propagation. |
| `va_propagation_v3_names.json` | v3 shared-VA propagation. |
| `string_api_method_names.json` | Unity API string method names; empty in current checkout. |

LLM batch/prediction products:

| File/Pattern | Purpose |
|---|---|
| `codex_batch_final.json` | Final Codex batch target list. |
| `final_118_context.json`, `last_118_context.json`, `last_48.txt` | Context snapshots for manual/LLM passes. |
| `gemini_final_pred_000.json` through `gemini_final_pred_017.json` | Raw/fenced Gemini final predictions; several are not strict JSON. |
| `gemini_neighbor_pred_000.json` through `gemini_neighbor_pred_039.json` | Neighbor-context Gemini predictions; several are not strict JSON. |
| `gemini_hexrays_000.json`, `gemini_hexrays_001.json` | Raw Hex-Rays Gemini files. |
| `gemini_hexrays_pred_000.json` through `gemini_hexrays_pred_012.json` | Hex-Rays Gemini predictions; several are not strict JSON. |
| `gemini_final_batches/batch_000.json` through `batch_017.json` | Gemini final batch inputs. |
| `gemini_neighbor_batches/batch_000.json` through `batch_042.json` | Gemini neighbor batch inputs. |
| `hexrays_codex_batches/batch_000.json` through `batch_012.json` | Codex Hex-Rays batch inputs. |
| `llm_batches_hexrays_b/batch_000.json` through `batch_021.json` | Path B prompt batches. |
| `llm_batches_hexrays_b/pred_000.json` through `pred_021.json` | Path B predictions merged by `merge_hexrays_b.py`. |
| `llm_final2_000.json` through `llm_final2_009.json` | Second final LLM predictions. |
| `llm_repass_000.json` through `llm_repass_013.json` | Repass LLM predictions. |
| `llm_weak_body_000.json` through `llm_weak_body_075.json` | Weak-body LLM predictions. |
| `llm_targets_strong.json` | Strong-class LLM target contexts. |

Runtime and analysis products:

| File | Purpose |
|---|---|
| `component_identifications.json` | Component identification list. |
| `deep_probe_all_114702.json` | Deep probe run summary, call counts, timeline sample. |
| `global_async_analysis.json` | Global namespace async analysis. |
| `global_async_hooks.json` | Hook targets for async analysis. |

Notable non-JSON products:

- `output/photon_protocol_analysis.md`, `output/network_layer_analysis.md`, `output/eac_auth_analysis.md`: protocol/auth summaries.
- `output/coverage_report.md`: older April coverage report.
- `output/pipeline_coverage_report.md`: current pipeline-format report.
- `output/dashboard.html` and `docs/index.html`: dashboards, but with stale build metrics in `docs/index.html`.

## 4. Beebyte Obfuscation

### 4.1 Identifier Pattern

Beebyte-obfuscated identifiers are strings consisting only of U+00CC..U+00CF characters:

- `Ì` U+00CC
- `Í` U+00CD
- `Î` U+00CE
- `Ï` U+00CF

Detection regex used by core code:

```python
r'^[\u00CC\u00CD\u00CE\u00CF]{3,}$'
```

The same concept appears in JavaScript helpers (`VRC.isObfuscated`) and IDA scripts. The pipeline turns raw Beebyte method names into stable hash placeholders like `m_ABC` and fields like `f_ABC` when no semantic name is found.

### 4.2 Struct Layout Discovery: `tools/reverse_struct_layout.py`

Purpose: recover Beebyte-shuffled IL2CPP layout from a minidump without trusting standard IL2CPP offsets.

Primary algorithm:

1. Search minidump memory for known class-name strings:
   - `MonoBehaviour`
   - `GameObject`
   - `Transform`
   - `Component`
   - `NetworkManager`
   - `VRCPlayer`
   - `Keyboard`
   - `Canvas`
   - `Il2CppObject`
2. Convert string file offsets to mapped VAs using a minidump `Memory64List` parser.
3. Scan for qword references to those string VAs:
   - First nearby `±0x4000` around strings.
   - Then heap-wide from `0x30000000` to `0x3E000000` if nearby signal is weak.
4. For each pointer reference, try possible `OFF_NAME` values and derive candidate class struct bases.
5. Require at least two self-references inside the first `0xC0` bytes. These become candidate `OFF_ELEM` and `OFF_CAST` offsets.
6. Rank `(OFF_NAME, OFF_ELEM, OFF_CAST)` triples by name diversity, distinct bases, hit count, and offset preference.
7. Scan heap for class candidates using the chosen triple.
8. Probe:
   - `OFF_IMAGE` by looking for image structures with DLL file names.
   - `OFF_PARENT` by checking parent pointers against candidate class bases.
   - `OFF_METHODS`, `OFF_MCNT`, `MI_NAME` by walking method pointer arrays and comparing observed counts to count fields.
   - `OFF_FIELDS`, `OFF_FCNT`, `FI_STRIDE`, `FI_NAME` by walking field arrays and comparing observed field names/counts.
9. Emit `final_offsets`, known-class evidence, and timing stats.

Current `data/reverse_struct_report_may02.json` records final offsets for the May 2 report. README summarizes May 2 layout as:

| Field | May 2 Offset |
|---|---:|
| `OFF_NAME` | `0x50` |
| `OFF_CAST` | `0x80` |
| `OFF_FIELDS` | `0x10` |
| `OFF_METHODS` | `0x90` |
| `MI_NAME` | `0x18` |
| `FI_STRIDE` | `0x28` |
| `FI_NAME` | `0x00` |
| `FIELD_TYPE_OFF` | `0x18` |
| `FIELD_PACKED_OFF` | `0x20` |

Important discrepancy: many runtime Frida scripts still contain older offset comments/uses, such as `Il2CppClass +0x58 name`, `+0x78 methods`, `+0xA0 fields`, `+0x120 method_count`, `+0x124 field_count`. The extractor/runtime scripts must be aligned to the build being analyzed.

## 5. Runtime Analysis

### 5.1 Frida Architecture

The runtime layer is organized around:

- Python drivers that attach/spawn VRChat, load JavaScript, call RPC exports, and save JSON.
- Frida JavaScript libraries/scripts that use:
  - `Process.getModuleByName('GameAssembly.dll')`
  - ASLR-aware `GA.base.add(rva)` addressing
  - IL2CPP struct offset readers
  - `Interceptor.attach` for passive hooks
  - `NativeFunction` only when needed and usually with warnings
  - RPC exports for batch reads, scene scans, hook installation, and summary retrieval.

Key helper library:

- `tools/vrc_frida_lib.js`: central class/method/field readers, vtable walker, singleton/heap instance finders, coroutine helper, hook helper, config loader, RVA helpers, and Beebyte string detector.

### 5.2 Anti-Tamper Trampoline: `bridge.js`

`bridge.js` addresses a return-address validation issue in VRChat/GameAssembly:

- Directly calling IL2CPP exports from Frida gives a return address outside GameAssembly.
- VRChat/Beebyte checks can reject or crash that pattern.
- `bridge.js` finds a writable range inside `GameAssembly.dll`, typically `.data`.
- It writes a 64-byte x64 trampoline at the end of that range and marks it `rwx`.
- Calls go through the trampoline:
  - Frida calls trampoline.
  - Trampoline calls target export.
  - Target sees return address inside GameAssembly.

Trampoline calling convention:

- Windows x64.
- `rcx` = target.
- `rdx`, `r8`, `r9`, stack = arguments.
- Saves/restores stack and returns result.

Known export mappings in bridge:

- `xbdxfIjXGZA` -> `il2cpp_domain_get`
- `HVnVGWHvEoF` -> `il2cpp_thread_attach`
- `il2cpp_free`
- `il2cpp_gchandle_get_target`
- `il2cpp_native_stack_trace`

Safety note: `bridge.js` deliberately avoids blind export probing because unknown IL2CPP exports can crash the process.

### 5.3 Deep Probe

`deep_probe.py` and `deep_probe.js` implement generic method tracing:

- Python selects target methods from deobfuscated dump/RVAs.
- JS installs `Interceptor.attach` hooks on `GA + RVA`.
- Maintains `callCounts`, `eventLog`, throttling, and timeline.
- Specialized argument readers cover room callbacks, Udon events, network encode/decode, and state management.
- RPC:
  - `installHooks(config)`
  - `getStats()`
  - `getTimeline(lastN)`
  - `getTopCallers()`
  - `reset()`

Output example in checkout: `output/deep_probe_all_114702.json`.

### 5.4 Field Type Extraction

`extract_field_types_v2.py` drives `extract_field_types_v2.js`.

JS behavior:

- Receives a batch of class VAs.
- Reads class name/namespace.
- Reads fields pointer and count.
- Reads field name, type address, field offset.
- Resolves `Il2CppType` recursively:
  - primitives by type enum,
  - class/valuetype via metadata type definition strings,
  - arrays,
  - generic instances,
  - pointers/byrefs,
  - generic parameters.

Python behavior:

- Attaches to offline VRChat.
- Batches class VAs.
- Writes field types.

The deobfuscator then uses `output/field_types.json` to turn unknown fields into semantic names such as `_transform`, `_gameObject`, `_animator`, `_photonView`, `_udonBehaviour`, etc.

### 5.5 Component Identification

Evolution:

- `identify_components.py/js`: early runtime component probing with some hardcoded assumptions.
- `identify_components_v2.py/js`: full scene traversal with dynamic Unity method resolution.
- `identify_components_v3.py/js`: session-independent scene traversal.

`identify_components_v3.js` features:

- Avoids hardcoded class VAs.
- Uses stable method RVAs and a single error-state-setter hook (`0x1943BC0`) to find FlowManager.
- Bootstraps `Component.get_transform`, `Component.get_gameObject`, `Object.get_name`, `Transform.GetChild`, `GameObject.GetComponentCount`, `QueryComponentAtIndex` from live class method tables.
- Traverses FlowManager root hierarchy.
- Finds singleton static fields and scans their roots.
- Reads class info: name, namespace, method count, field count, parent, parent chain.
- Exposes method names/signatures for disambiguation.

Outputs merge through `process_scene_results.py`, `merge_scene_results.py`, and `merge_runtime_names.py`.

### 5.6 Auth/EAC/Photon Tracing

Read-only scripts:

- `trace_auth_flow.js`: hooks Steam ticket generation, EOS Anti-Cheat APIs, EOS Auth/Connect APIs, Photon auth callbacks, `GetKeyServerAuthToken`, `OnOperationResponse`.
- `analyze_authcookie.js`: focuses on Photon auth response parameters, AuthCookie dictionary probing, JoinRoom rejection, LoadBalancingClient/AuthValues scanning.
- `eac_session_analyzer.js`: compares EAC-active vs bypass sessions by tracking EOS platform creation, anti-cheat interface, `BeginSession`, message-to-server callbacks, server messages, `PollStatus`, EOS auth/connect tokens, Photon token integration.
- `intercept_photon_auth.js`: adds transport-level `send`/`recv`/`WSASend`/WinHTTP capture for Photon headers; includes optional injection mode, but comments mark it experimental.

Patch/bypass scripts:

- `hook_eos_anticheat.js`: local fake anti-cheat interface/return values. Useful for testing client-side code paths, not sufficient for server validation.
- `hook_steam_init.js`, `patch_steam_api.py`, `patch_eossdk.py`, `patch_ga_binary.py`, `patch_offline.py`: binary/runtime bypass experiments.

Critical finding from docs: local EOS spoofing does not satisfy server-side EAC validation because the server expects continuous opaque EOS messages or valid EAC status in server-side Photon auth state.

## 6. Network / Protocol Summary

### 6.1 Photon Protocol

`output/photon_protocol_analysis.md` documents:

- Photon operation codes:
  - `217 GetRoomList`
  - `219 WebRPC`
  - `220 GetRegions`
  - `221 GetLobbyStats`
  - `222 FindFriends`
  - `225 JoinRandomRoom`
  - `226 JoinRoom`
  - `227 CreateRoom`
  - `229 JoinLobby`
  - `230 Authenticate`
  - `231 AuthenticateOnce`
  - `253 RaiseEvent`
  - `254 Leave`
  - `255 Join`
- VRChat custom event codes:
  - `1 Voice`
  - `2 ExecutiveMessage`
  - `3 PastEvents`
  - `4 SyncEvents`
  - `5 SyncFinished`
  - `6 ProcessEvent`
  - `7 UnreliableSerialization`
  - `8 InterestManagement`
  - `9 ReliableSerialization`
  - `33 ExecutiveAction`
  - `34 RatelimitValueSync`
  - `35 RatelimitUpdate`
  - `40 UserRecordUpdate`
  - `42 UserRecordUpdate2`
  - `60 PhysBonesPermissions`
  - `202 Instantiate`
- Photon internal events:
  - `209 OwnershipRequest`
  - `210 OwnershipTransfer`
  - `211 VacantViewIds`
  - `223 PhotonAuthEvent`

Key protocol findings:

- Voice uses USpeak/Opus framing with packet index/size and Opus payloads.
- `Event 7` carries frequent unreliable interpolatable data: player/camera transforms, muscles, network stats.
- `Event 9` carries reliable serialized state: AV3 parameters, Udon variables, late-join state.
- `Event 34/35` implement rate-limit configuration and current rate-limited actors.
- `Event 40/42` update user records and trigger actor property refresh.
- Instantiate uses Photon keys `245` and `247`, with key `245` containing `{48, "VRCPlayer"}`.

### 6.2 Network Layer

`output/network_layer_analysis.md` maps the stack:

```text
Application:   VRCPlayer / NetworkManager / UdonBehaviour
Serialization: FlatBufferSerializerCodec, FlatBuffers8, FlatBuffers32
Event layer:   VRCPhotonEvent / IFlatBufferNetworkSerializer
Photon:        PhotonPeer, EventData, OperationResponse
Transport:     EnetPeer / TPeer / PhotonClientWebSocket
Encryption:    PhotonEncryptorPlugin native DLL
```

Identified classes:

- `Photon.Client` layer: `PhotonPeer`, `PeerBase`, `EnetPeer`, `TPeer`, `EventData`, `OperationResponse`, `Protocol`, `IPhotonPeerListener`, sockets, command/stat classes.
- `Photon.Realtime`: `AppSettings`, `ConnectionHandler`, matchmaking classes.
- `Photon.Client.Encryption`: `ICryptoProvider`, `IPhotonEncryptor`.
- Main raw event receiver proposed as `VRCNetworkingClient` (`UdonOperationResponseDisconnectMessage_E05D` in older analysis), implementing all `IPhotonPeerListener` methods.
- Photon callback implementors: room, connection, auth, master-client, callback lists/interfaces.
- `NetworkManager` as central coordinator.
- `FlatBufferSerializerCodec` and 8/32-bit FlatBuffer namespaces for reliable/unreliable serialization.
- `IVRC_FlatBufferSerializer` implementors including `PlayerNet`, `FlatBufferNetworkSerializer`, `NetworkSyncable_*`, `PlayerModComponentHealth`, and VRC network behavior bases.

High-priority remaining network work from the doc:

- `NetworkManager` inner method mapping.
- Main event dispatcher switch/case on event codes.
- Room/connection handler obfuscated methods.
- Event 7/9 binary format disassembly.
- Event 8 interest management producer/consumer.

### 6.3 EAC Auth

`output/eac_auth_analysis.md` finds:

- VRChat uses EOS Anti-Cheat in client-server mode.
- EOS messages are opaque, encrypted/signed internally, and exchanged continuously.
- Bypass launch can complete Steam/API/Photon custom auth but fails room joins because EAC session validation is missing.
- Photon custom auth likely stores server-side `AuthCookie`; JoinRoom/CreateRoom is gated by Photon plugin `BeforeJoin` or equivalent server-side checks.
- Client-side AuthCookie mutation is ineffective if server uses its stored AuthCookie.
- Local EAC stubbing/faking can change client behavior but does not produce valid server-side integrity messages.

Four-token chain described:

1. Steam app ticket -> VRChat API.
2. VRChat API token -> Photon custom auth.
3. Photon auth token from `PlatformOptions.GetKeyServerAuthToken`.
4. EAC session/integrity data from EOS callbacks -> Photon server plugin/back-end status.

Practical workflows:

- Offline bypass + Frida for analysis.
- Packet capture for headers/opcodes/timing.
- Static deobfuscation and IDA analysis for online-related code.
- Avoid process modification while EAC is active.

## 7. IDA Integration

### 7.1 `ida/*.py`

| File | Purpose |
|---|---|
| `ida/apply_names.py` | Applies deobfuscated method names to IDA functions by mapping runtime VAs to IDA image-base RVAs; adds comments with original obfuscated names. |
| `ida/apply_strings.py` | Adds function comments from string reference JSON, categorized by purpose. |
| `ida/apply_types.py` | Applies type information in IDA. |
| `ida/dump_decrypt_asm.py` | Dumps assembly around decrypt candidates. |
| `ida/dump_decrypt_candidates.py` | Finds/dumps metadata decrypt function candidates. |
| `ida/extract_decrypt_constants.py` | Extracts constants used by metadata decrypt routine. |
| `ida/find_decrypt_in_idb.py` | Searches IDB for decrypt routine. |
| `ida/find_metadata_decrypt.py` | Metadata decrypt finder script. |

Generated/analysis data in `ida/`:

- `ida/metadata_decrypt_findings.json`
- `ida/metadata_loader_candidates.json`
- `ida/decrypt_pseudocode.json`
- `ida/decrypt_constants.json`
- `ida/decrypt_asm.txt`
- `ida/ida_log.txt`

### 7.2 Metadata Decryption Findings

Reviewed artifacts indicate a Beebyte metadata decrypt function around `sub_180A7E880` in GameAssembly. `tools/decrypt_metadata.py` summarizes the algorithm:

1. Header: first `0x148` bytes encrypted with rolling XOR.
2. Body: remaining bytes encrypted with index-dependent XOR:
   - `key = (i + 0x5A) & 0xFF`
   - `byte ^= key`
3. Applies in-place style decryption.

`ida/metadata_decrypt_findings.json`, `ida/decrypt_constants.json`, `ida/decrypt_asm.txt`, and `ida/decrypt_pseudocode.json` are the IDA-side evidence used to derive that algorithm. The decrypt tooling supports recovering TypeDefinition token/name mappings, which then feed `lift_typedef_tokens.py`.

### 7.3 Name Application

Two paths exist:

- Static repo script `ida/apply_names.py`: uses hardcoded runtime DLL base and mappings to apply names and comments.
- Generated `output/ida_apply_names.py`: produced by Stage 4 with current deobfuscated dump method pointers; simpler RVA-to-name rename list.

Recommended flow:

1. Open analyzed GameAssembly in IDA.
2. Apply names first.
3. Run targeted Hex-Rays export only on unresolved/high-value functions.
4. Feed Hex-Rays output into `build_hexrays_b_batches.py` and LLM/rule naming.

## 8. LLM-Assisted Naming

### 8.1 Strategy

The LLM flow targets hash-fallback methods, not raw Beebyte names. A method key usually looks like:

```text
ClassName::m_ABC
```

Prediction evidence can include:

- Class name and parent.
- Known sibling methods.
- Fields.
- String references.
- Pseudocode from Hex-Rays.
- Call/callee context.
- Cross-version/body/vtable evidence.

Predictions are deliberately filtered before entering pipeline maps.

### 8.2 Main Scripts

- `gemini_auto_loop.py`: scans current `name_mapping.json` and `precise_dump.json` for hash methods in classes with enough named sibling context; writes `output/gemini_auto/batch_*.json`; calls Gemini CLI; merges predictions into `output/cross_version_method_names.json`; reruns pipeline and commits.
- `gemini_batch_worker.py`: prompt-only worker for a focus batch. It stresses pseudocode first, then strings, siblings, class context, and JSON-only output.
- `llm_name_batch_api.py`: OpenAI-compatible endpoint batch runner using `OPENAI_API_KEY`, `API_BASE`, and `LLM_MODEL`; writes `output/codex_pred_*.json`.
- `codex_name_batch.py`: runs `codex exec` on `codex_batch_*.json` files; writes `codex_pred_*.json`.
- `hexrays_b_prompt.py`: high-context prompt generator with Beebyte/IL2CPP noise guidance, confidence threshold, few-shot examples, and strict raw JSON contract.
- `merge_llm_predictions.py`: filters `output/llm_batches/results/*_results.json` into `output/llm_predicted_names.json`.
- `merge_hexrays_b.py`: validates `output/llm_batches_hexrays_b/pred_*.json` and merges valid names into `output/cross_version_method_names.json`.

### 8.3 Quality Filters

Filters reject:

- Bad identifier format.
- Generic names: `Update`, `Process`, `Handle`, `Execute`, `Init`, `Setup`, `Run`, `Method`, etc.
- Existing hash-like names.
- Too-short/too-long names.
- Random/hallucinated fragments and tails.
- Excess duplicate names per class or globally.
- IDA auto names like `sub_`, `loc_`, `unk_`.

Path B prompt explicitly says to omit uncertain keys and target only predictions with at least 70% confidence.

### 8.4 How Predictions Enter Pipeline

Two main routes:

1. `output/llm_predicted_names.json` is loaded by `deobfuscate.py` during method rename.
2. `output/cross_version_method_names.json` is loaded both by Stage 0 and method rename; many LLM/cross-version tools merge here.

This means an LLM prediction can affect both vocabulary stats and actual method renaming.

## 9. Output Products

### 9.1 Source Tree

Current `output/src` summary from checkout:

| Top Directory | C# Files |
|---|---:|
| `Global/` | 68 |
| `VRC/` | 350 |
| `VRCCore/` | 1 |
| `VRCSDK2/` | 2 |
| `ThirdParty/` | 949 |
| Total | 1,370 |

Key files/directories:

- `output/src/INDEX.md`: source-tree index.
- `output/src/VRC/`: VRChat game/system code.
- `output/src/VRCCore/`: VRCCore product.
- `output/src/VRCSDK2/`: SDK2 product.
- `output/src/ThirdParty/`: Unity, Photon, BestHTTP, BouncyCastle, EOS, SteamAudio, Cinemachine, FxResources, etc.
- `output/src/Global/`: global namespace, fallback and compiler-generated classes.

### 9.2 Coverage Reports

`output/pipeline_coverage_report.md` (May 4, current pipeline format):

- Total classes: 86,586.
- Renamed obfuscated classes: 10,858.
- Semantic among renamed: 8,085 (74.5%).
- Fallback among renamed: 2,773.
- Total methods: 517,592.
- Renamed methods: 35,499.
- Total fields: 70,697.
- Renamed fields: 6,752.

This report counts "renamed obfuscated" differently than README's semantic total coverage; it is not a full identifier coverage denominator.

`output/coverage_report.md` (April 8, stale relative to README):

- Total classes: 42,548.
- Fully semantic names: 37,788 (88.8%).
- Pattern-named: 4,760.
- Methods: 253,787 with 96.95% named.
- Fields: 40,930, all named.
- Describes old 20 structural matches and older VRC namespace metrics.

README (May 2 build, stated current project context):

- Classes semantic: 80,621 / 86,586 = 93.1%.
- Methods semantic: 480,821 / 517,592 = 92.9%.
- Fields semantic+typed: 86,113 / 92,885 = 92.7% semantic, 95.6% typed.
- Total identifiers: 647,555 / 697,063 = 92.9%.
- Source files: README says 1,356; current checkout inventory finds 1,370.

`docs/index.html` is a dashboard for an older April build:

- 40,896 classes.
- 296,089 methods.
- 35,925 fields.
- 97.9% semantic.
- Mentions 1,126 source files and 133K+ IDA renames.

Treat `docs/index.html` as stale dashboard content, not current truth for the 86K-class May build.

## 10. Gaps and Opportunities

### 10.1 What Is the Remaining 7%?

Using README's May 2 build metrics:

- Class gap: `86,586 - 80,621 = 5,965` classes not semantically named.
- Method gap: `517,592 - 480,821 = 36,771` methods not semantically named.
- Field semantic gap: `92,885 - 86,113 = 6,772` fields not semantically named.
- Identifier gap: `697,063 - 647,555 = 49,508` identifiers unresolved semantically.

Nature of the gap:

- Fallback structural class names, not raw Beebyte strings.
- Hash fallback methods (`m_XXX`) concentrated in global namespace, generic/template families, network dispatchers, and large components.
- Field gaps where runtime type was unavailable, garbled, or too generic.
- Cross-version class map for Apr -> May is incomplete; README explicitly says May coverage should rise above 99% after a fresh paired old/new class map.

### 10.2 Tools Not in Default Pipeline

The default `run_full_pipeline.py` does not run most discovery/lifting tools. It consumes their outputs if present.

Not default:

- Struct discovery: `reverse_struct_layout.py`, `verify_struct_layout.py`.
- Dump creation/extraction: `take_new_dump.py`, `new_dump_orchestrator.py`, `extract_live_dump.py`.
- Metadata decrypt and token lifts: `decrypt_metadata.py`, `lift_typedef_tokens.py`, IDA decrypt scripts.
- Cross-version class map/body/vtable lifts: all `lift_*` tools except `apr25_lifted_vocab` if already present.
- IDA extraction and Hex-Rays export: `ida_extract*.py`, `ida_hexrays*.py`.
- LLM batch generation/runners/mergers.
- Runtime Frida component scans and field extraction unless Stage 5 is manually selected.
- Photon packet capture and auth tracing.
- Binary patch/deployment tools.

The pipeline is an integration/rebuild pipeline, not a full discovery pipeline.

### 10.3 Dead Ends and Constraints

Observed/documented dead ends:

- Local EAC/EOS faking does not satisfy server-side room join validation.
- Frida with EAC active is blocked/dangerous; offline bypass is the viable analysis mode.
- Client-side AuthCookie editing is likely ineffective because server stores and applies AuthCookie.
- Some Frida scripts hardcode offsets/RVAs from older builds; Beebyte rotates offsets and ASLR changes base every run.
- Blind calls to obfuscated IL2CPP exports can crash VRChat; trampoline helps return-address checks but does not make unknown exports safe.
- `data/precise_dump.json` is absent in this checkout, blocking a fresh Stage 1 run from the repo alone.
- Dashboard/report artifacts are stale/inconsistent across builds.
- Several raw Gemini prediction files are not valid JSON because provider output includes extra text or fences; mergers need extraction/filtering.

### 10.4 Cross-Version Strategies

Existing strategies:

- Class body-hash mapping (`cross_version_class_map.py`): Jaccard over method body hashes with name-signature fallback.
- Direct class/method/field positional lift (`lift_apr18_to_apr25_vocab.py`) after class map.
- Canonical method body hashing (`lift_by_method_body_hash_v2.py`) with relocation/call displacement zeroing.
- Vtable slot propagation (`lift_old_new_vtable.py`, `lift_vtable_propagation.py`).
- Same-name class method lifting (`lift_same_name_methods.py`).
- Property pair lifting by native field offset (`lift_property_pairs.py`).
- Field access pattern naming (`lift_by_field_access.py`).
- P/Invoke wrapper detection (`lift_pinvoke_wrappers.py`).
- TypeDefinition token naming after metadata decrypt (`lift_typedef_tokens.py`).
- Static string and IDA string lifts (`lift_from_static_strings.py`, `lift_from_ida_strings_v2.py`).
- Internal same-build body propagation (`lift_new_internal_body.py`).
- Cross-class sibling/impl propagation (`lift_cross_class_siblings.py`).
- LLM assisted naming with Hex-Rays context.

### 10.5 Highest-Value Next Work

1. Restore or regenerate `data/precise_dump.json` for the current May build, then run `python tools/run_full_pipeline.py --check`.
2. Produce a fresh old/new class map for Apr->May or May->latest using `cross_version_class_map.py`, then rebuild `data/apr25_lifted_vocab.json` equivalent for the actual target version.
3. Align all Frida struct offsets to `data/reverse_struct_report_may02.json` or the newest report before runtime extraction.
4. Run targeted IDA Hex-Rays on high-value network classes:
   - `NetworkManager`
   - main `IPhotonPeerListener` implementation
   - `PhotonRoomHandler_*`
   - `PhotonConnectionHandler_*`
   - `VRCPlayer`
   - `PlayerNet`
5. Merge `llm_batches_hexrays_b` predictions only through filters; avoid raw prediction files directly.
6. Refresh `docs/index.html` and `output/coverage_report.md` to match the 86K-class May build or mark them historical.
7. Move `data/method_string_refs.json` or generate `output/method_string_refs.json`/`output/deep_analysis.json` so `phase6c_binary_strings()` actually consumes string refs.
8. Promote high-confidence runtime component identifications into stable `additional_names.json`/`structural_matches.json` rules.

