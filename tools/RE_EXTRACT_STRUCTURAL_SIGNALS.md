# Spec: recovering interfaces + field types from the il2cpp dump

Status: **CORRECTED 2026-06-29.** An earlier draft of this doc (and a memory note)
claimed field types were "unrecoverable / the fourth falsified signal." That was
wrong — it only looked at ONE of two extraction substrates. The metadata
substrate already worked. This doc now reflects the real plan.

## Two independent extraction substrates

| | memory dump (`FieldInfo`) | `global-metadata.dat` |
|---|---|---|
| field type source | `Il2CppType*` pointer in `FieldInfo` | `Il2CppFieldDefinition.typeIndex` (int32) |
| offset stability | **build-specific** (06-05 offsets find 88400 classes; SAME offsets find only 5 on the 06-29 dump) | fixed metadata-version layout |
| type resolution | `FI+0x20` derefs to **executable code** (property getter), not a clean `Il2CppType` → needs more work | clean int32 index |
| status | offsets for 06-29 NOT yet found | **worked 06-13**: produced fieldtype_class_names.json (118) + predictions_v2.json (92) |

Decision (user, 2026-06-29): **do BOTH and cross-validate.** Metadata path is the
cleaner primary; the memory path both serves as the fallback when metadata is
stripped AND cross-checks that the rediscovered struct offsets are correct.

## Blocker resolved (2026-06-29)

`metadata/` dir was deleted, but the source file still exists in the install:
`D:\Steam\steamapps\common\VRChat\VRChat_Data\il2cpp_data\Metadata\global-metadata.dat`
(40 MB, Jun 26, same timestamp as `GameAssembly.dll`). Header magic =
`0xC1C21EF0` → **Beebyte-encrypted** (not the `0xFAB11BAF` plain magic), so it
must go through `decrypt_metadata.py` first (that XOR/keystream algorithm is
already reverse-engineered for this game).

## Build alignment caveat

metadata + GameAssembly.dll are **Jun 26**; the call-graph dump that produced the
11 names is **Jun 29 (build 32984)**. Confirm they are the same il2cpp build (or
accept minor drift) before trusting cross-validation between field-type names and
call-graph names. The deobfuscated_dump.json itself is from the Jun-29 dump
(`source_dump: VRChat_32984_20260629`, offsets CL_FIELDS=0xA8/FI_STRIDE=0x20).

## Plan (ordered)

a. **Decrypt** the Jun-26 `global-metadata.dat` via `decrypt_metadata.py`; verify
   string table + typedef table parse (typedef_index -> name).
b. **Resolve typeIndex -> type name.** Per the old code's own note,
   `Il2CppFieldDefinition.typeIndex` indexes the runtime `Il2CppType[]` built from
   `GameAssembly.dll`'s `CodeRegistration`, NOT a metadata table — so this hop
   needs GameAssembly.dll's type table (or the already-resolved `Il2CppType`s in
   the memory dump). This is the real technical core.
c. **Field-type signature index** over weak classes; measure discriminativeness
   (which type-sets are rare enough to name a class).
d. **Memory path:** extend `reverse_struct_layout.py` to rediscover, on the 06-29
   dump, both the `Il2CppClass` offsets AND the `FieldInfo` type-pointer offset
   (brute-force every FI slot against fields of a-priori-known type, e.g.
   `MonoBehaviour.enabled`->Boolean; require >=3 known fields to agree).
e. **Cross-validate:** the two substrates must agree on the same field's type
   (proves the rediscovered memory offset is right), then measure overlap of
   field-type-named classes with the call-graph names.

## What the 06-13 metadata run already produced (do not redo, reconcile)

- `output/fieldtype_class_names.json` (118), `fieldtype_name_predictions_v2.json`
  (92). Keys are OLD-build obfuscated/descriptive names; **0 match** the current
  06-29 dump keys, so they were never merged. Step (a)-(c) on the current build
  supersedes them; keep the old reasons as hypotheses to confirm.

## Execution log (2026-06-29)

Concrete facts established this session (each verified, not assumed):

1. **Right extractor identified.** The 64773-class `deobfuscated_dump.json` comes
   from `extract_reverse_unity6.py` (NOT `extract_precise_dump.py`, which uses
   stale 06-05 offsets and finds only 5 classes on the 06-29 dump). The Unity-6
   extractor already DEFINES `FI_TYPE = 0x00` in its FieldInfo layout — it knows
   where the type pointer is and simply never reads it. So the memory-path "add a
   field" change is smaller than first thought: offset already located, layout
   already verified (stride 0x20, name@0x08, parent@0x18, **type@0x00**).

2. **Metadata path blocker is partial.** `global-metadata.dat` exists
   (D:\Steam\...\Metadata, 40MB, Jun-26) but the 05-02 `decrypt_metadata.py`
   keystream FAILS on it — header decrypts to magic `0x0E0CD33C` not `0xFAB11BAF`.
   Beebyte changed the header encryption between builds. Recovering the new
   keystream from known plaintext (magic+version) gives `5F 05 73 3B D1 B6 A8 BD`
   for the first 8 bytes — NOT the old arithmetic `(i-0x34)` pattern, NOT linear,
   NOT a short XOR cycle. So the metadata path needs the Jun-26 loader's decrypt
   routine re-RE'd from GameAssembly.dll — real work, not a quick re-run.

3. **KEY INSIGHT that reorders the plan:** the memory dump's metadata is already
   in VRChat's RUNTIME-DECRYPTED state — `deobfuscated_dump.json` has 188384 clean
   field names and **0** still-obfuscated, proving the memory path bypasses the
   on-disk Beebyte encryption entirely. So for THIS goal (field types), the memory
   path is not just a cross-check — it sidesteps the metadata decryption blocker
   that would otherwise gate the cleaner substrate. **Revised priority: lead with
   the memory path (FI_TYPE=0x00 already located), use metadata as the eventual
   cross-check once its Jun-26 keystream is re-RE'd.**

### Immediate next step (concrete, for a fresh fast run)

DONE 2026-06-29. `FieldInfo+0x00` was an UNVERIFIED guess in the code; the real
field-type pointer is at **FI+0x10** (FI+0x00 is offset/token). Verified by byte
inspection of `Color.r`'s FieldInfo and confirmed semantically:
- `resolve_type_name()` reads the Il2CppType **kind byte at +0x0A** and maps
  primitives via `IL2CPP_TYPE_ENUM`. Result on the 06-29 dump:
  `Color` r/g/b/a = Single (✓), `Vector3` x/y/z = Single (✓),
  `Camera` kMinBladeCount = Int32, m_NonSerializedVersion = UInt32 (✓).
- Implemented in `extract_reverse_unity6.py`: `FI_TYPE=0x10`, `IL2CPP_TYPE_ENUM`,
  `resolve_type_name()`, `extract_fields_typed()`. Regression suite still green.

### Remaining work (in priority order)

1. **Class/valuetype name hop (kind 0x11/0x12).** SOLVED 2026-06-29. The
   `Il2CppType.data` for class/valuetype kinds is an `Il2CppMetadataTypeHandle`
   (packed metadata), NOT a runtime klass pointer — chasing it as a klass was a
   dead end (it points to metadata-blob bytes, ties back to the encrypted
   global-metadata path). The robust route: each `Il2CppClass` embeds the SAME
   handle in its inline byval_arg at **klass+0x20** (`CL_BYVAL`). So
   `build_handle_name_map()` scans every known klass's +0x20 -> "Namespace.Name"
   (89209 entries in ~5s), and `resolve_type_name()` turns a field's
   `Il2CppType.data` handle into the type name. Verified:
   `Vector3.zeroVector -> UnityEngine.Vector3`, `Camera.onPreCull ->
   CameraCallback`, `Camera.onPreRender -> CameraCallback`.
2. **Wire `extract_fields_typed` into `main()`.** DONE: `--typed-fields` flag
   (additive — keeps the bare `fields` name list AND adds a `field_types` map),
   `schema_version` bumped to 2 when typed, `FI_TYPE`/`CL_BYVAL` recorded in
   `field_offsets`. Output to `data/precise_dump_unity6_typed.json`.
3. **Field-type signature index** over weak classes + cross-validate with
   call-graph names. DONE 2026-06-29 via `tools/build_field_type_signal.py`
   -> `output/field_type_signal.json`. Joins the typed dump to
   deobfuscated_dump.json by **obfuscated class name** (VAs differ across dump
   sessions — 0 VA overlap — but 8211/8326 obf names join cleanly). Per class:
   keep discriminative field types (drop primitives / `<...>` tags / low-signal
   plumbing like Action/CancellationToken), weight each by global rarity
   (idf = log(N/df), N=19365), score = sum of top-5 type idfs. Results:
   - **588 weak (fallback-named) classes** get a usable naming signal, **1882
     strong-named classes** kept as a cross-validation anchor.
   - The signal is sharply interpretable: `Struct8f_21BD` ->
     LandmarkList/Detection/NormalizedRect (= MediaPipe face landmark struct),
     `Mono30m_A224` -> 3x LineRenderer (= line-renderer component),
     `Mono1m_7442` -> 5x Texture2D (= texture holder),
     `BaseClass290Impl_..8CAB` -> VRCAvatarDescriptor/RuntimeAnimatorController.
   - **Cross-validation finding (important):** only 77/400 strong names
     token-match their field types — but inspection shows this is NOT
     disagreement, it's ORTHOGONALITY. Existing names describe behavior
     (`PointerReleaseBonesComponent`) while field types reveal domain
     (`VRCContactSender`); `ControllerRightBaseImpl` -> OVRHand/OVRSkeleton
     exposes Oculus hand-tracking the generic name missed. Field types are a
     COMPLEMENTARY signal, not a redundant check — several look stronger than
     the established name. Feed them as additional evidence to the namer.
   - **Naming round EXECUTED 2026-06-29.** Fanned the 588 signals to 12 parallel
     sonnet subagents (agents Write to output/ft_results/, report counts only —
     avoids the 32k output cap hit in the prior workflow round). Merged + deduped
     (cross-shard dups, illegal keys, 30 name collisions -> _N suffix) to **304
     unique names (189 high / 115 medium)** in `output/field_type_class_names.json`.
     Registered as source `field_type` (tag `field_type_signature`) in
     `apply_class_names.py` and applied: **297 landed on still-weak classes** (7
     already pipeline-named, not overwritten). Coverage: semantic classes
     4653->5052, source_types_semantic 4226->4523 (+297), semantic_pct
     46.9%->**50.9%**. Regression test_name_quality.py ALL GREEN (recount
     4523/8211). Remaining ~291 weak signals are mostly single generic-type
     fields (low discriminative power) — combine with method-name/callgraph
     evidence for a second pass.

4. **`<class:0x11>` residual — RESOLVED 2026-06-29.** Root cause: the old
   `build_handle_name_map` only scanned the 65156 MethodInfo-derived klasses
   (56835 handles), missing every klass with no enumerated method (interfaces,
   enums, structs, system valuetypes). Fixed by sweeping the FULL heap via the
   self-ref invariant (`klass[+CL_SELFREF]==klass`, numpy fast path + per-qword
   fallback, klass_vas folded in as seed): handle map **56835 -> 89209**, field-
   type resolution **66.2% -> 69.3%** (+5817 fields), and `<class:0x11>` (5823)
   + `<class:0x12>` (168) both dropped to ZERO. Newly resolved kinds include
   enums/interfaces (CollisionDetectionMode, FilterMode, IUdonSignatureVerifier,
   RunningMode, TriggerType). All remaining `<...>` are genuinely unnameable:
   generics (44556), arrays (10038), compiler closures, generic params, and
   `<name>e__FixedBuffer` (which are real C# fixed-buffer field NAMES, not
   resolution failures). A second naming pass on the 206 newly-unlocked weak
   candidates added 139 names (field_type_class_names.json now 443 total);
   coverage semantic_pct 50.9% -> 52.3%, source_types_semantic_pct 55.1% ->
   56.7%. Regression ALL GREEN.

5. **Method return types — NEW signal, landed 2026-06-29.** MethodInfo carries
   `return_type` (Il2CppType*) at **MI_RETTYPE=0x18**, resolvable via the same
   handle->name map as field types. Verified: Transform.get_position->Vector3,
   get_parent->Transform, get_childCount->Int32. The extractor now emits
   `method_return_types` per class (typed path, additive; 35.9% of methods
   resolve a non-void domain type). This is INDEPENDENT of field types — a class
   whose fields are bare GameObject but whose methods return ApiProp/SpawnType/
   PropKind is clearly a prop system class. `build_method_return_signal.py`
   mines it for weak classes the field pass couldn't name (idf-weighted over the
   return-type corpus, excludes field-type-named classes): 313 weak unnamed
   classes got a signal, a naming pass added 79 (50 landed on still-weak
   classes), source_types_semantic_pct 56.7% -> 57.3%. Source `method_return`
   (tag `method_return_type_signature`) in apply_class_names.py. Next untapped:
   method PARAMETER types (same Il2CppType resolution, MethodInfo.parameters).

6. **Method parameter types — NEW signal, landed 2026-06-29.** MethodInfo has
   `parameters` (Il2CppType**) at **MI_PARAMS=0x28** and `parameters_count`
   (uint8) at **MI_PCOUNT=0x4A**. Verified: Transform.SetPositionAndRotation->
   (Vector3,Quaternion), LookAt->(Transform,Vector3), Rotate->(Vector3,Space);
   the count truncates the array so we don't read into the adjacent param pool.
   The extractor emits `method_param_types` per class (typed path, additive).
   Param types expose a class's INPUTS/dependencies, often sharper than returns
   (.ctor / setter / handler args). `build_method_param_signal.py` mines it for
   weak classes named by NEITHER the field nor return pass (disjoint): 501 weak
   unnamed classes got a signal — the strongest yet, since API wrappers take
   typed args (ApiSearchUserResults, APIGroupRoleList, ApiModerationResult+
   ModerationType+APIUser). Filtering to distinct_types>=2 gave 89 candidates;
   naming pass added 56 (48 landed on still-weak classes). source_types_semantic
   _pct 57.3% -> 57.9%, semantic 5239 -> 5287. Source `method_param` (tag
   `method_param_type_signature`). The MethodInfo now yields three orthogonal
   type signals (return @0x18, params @0x28/count@0x4A) on top of field types.

7. **Combined tri-signal + generic-argument mining — landed 2026-06-29.** Two
   compounding advances:
   (a) `build_combined_type_signal.py` UNIONs the field + return + param type
   sets per weak class (disjoint from all three single-signal passes). A class
   unnameable from any one signal is often clearly typed from the union
   (Canvas+RectTransform from params, Transform from returns -> UI layout). First
   pass: 92 candidates, 50 landed; semantic_pct 53.3% -> 53.8%.
   (b) GENERICINST resolution: resolve_type_name now decodes Il2CppType kind 0x15
   via Il2CppGenericClass (data+0x00 = generic typedef Il2CppType*, data+0x08 =
   context -> Il2CppGenericInst with +0x00 argc / +0x08 argv = Il2CppType**),
   rendering Base<Arg,...>. Verified: ApiWorld.localWorlds ->
   Dictionary<String,ApiWorld>, ApiWorld.mWorldInstances ->
   List<ApiWorldInstance>, VRCPlayerApi._isMasterDelegate ->
   Func<VRCPlayerApi,Boolean>. The discriminative type is usually the INNER arg,
   so tools/type_signal_common.py:clean_type_tokens extracts clean domain tokens
   from anywhere in a (possibly generic) type string, dropping container shells
   (List/Dictionary/Func/...), primitives, beebyte names, and leaked placeholder
   tokens (genericinst/genericparam/array). Re-running the combined miner with
   generic mining lifted the pool 92 -> 136 and added 76 more names
   (ChallengeEventDispatcher, MediapipeDetectionResult, TwoFactorAuthApiClient,
   GraphicsSettingsProvider). source_types_semantic_pct 58.5% -> 59.2%, semantic
   5337 -> 5413. Source `combined_type` (tag `combined_type_signature`, 126
   classes). NOTE: blindly template-naming the ~412 single-type-repeat param
   classes (mostly Api*Container generic plumbing with fully-obfuscated methods)
   was rejected as namespace pollution — the union+generic path is the higher-
   quality use of the same data.

8. **Array element types — landed 2026-06-29.** resolve_type_name now decodes
   SZARRAY (kind 0x1D, the common `T[]`: Il2CppType.data IS the element
   Il2CppType*) and multidim ARRAY (kind 0x14: data -> Il2CppArrayType whose
   +0x00 is the element Il2CppType*), rendering `element[]`. NOTE the kinds are
   the reverse of the naive guess: 0x1D = SZARRAY (817 sampled, 98% resolve to a
   named element), 0x14 = multidim. Composes with generics:
   ValueTuple<AudioSource,AudioSourceType>[], Entry<..,Sprite>[]. clean_type_
   tokens already drops the `[]` (word-char regex), so element types flow into
   all miners for free. Global effect on the full typed dump: 9,911 field types
   are now resolved arrays and 45,255 are resolved generics (previously opaque
   <array>/<genericinst>). Re-running the combined miner surfaced 74 still-weak
   candidates; naming added 12 more (NotificationQueryProcessor,
   SkinnedMeshController, ApiContainerFetchTask). semantic_pct 54.5% -> 54.6%,
   source_types_semantic_pct 59.2% -> 59.4%, semantic 5413 -> 5425. The marginal
   naming gain is small (the generic pass already absorbed most weak classes) but
   array resolution is a permanent global improvement to type extraction that
   benefits every future signal pass. resolve_type_name now fully decodes the
   composite Il2CppType graph (primitive / class / valuetype / genericinst /
   szarray / mdarray) up to _depth=3.

9. **Implemented interfaces — landed 2026-06-29.** Il2CppClass+CL_INTERFACES
   (=0xB0) points at an INTERLEAVED array of Il2CppRuntimeInterfaceOffsetPair
   ([interface Il2CppClass*, vtable_slot], stride 16); the interface klass is the
   first qword of each pair. There is NO reliable adjacent count field (the
   obvious uint16 slots are constant across classes), so extract_interfaces reads
   greedily until an entry fails the klass self-reference invariant. Verified:
   Button -> IMoveHandler, IEventSystemHandler, IPointerDownHandler,
   IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler,
   IDeselectHandler. Now stored as the `interfaces` field on every entry (24,988
   classes have >=1). build_interface_signal.py mines weak unnamed classes by
   their CLEAN DOMAIN interfaces, dropping the plumbing the obfuscator attaches to
   every collection / async / iterator (IList`1, ICollection`1, IEnumerator`1,
   IAsyncStateMachine, IStructuralComparable, IEquatable`1, ...), idf-weighted.
   RESULT: only 15 candidates, 3 applied (PointerEventReceiver, CriticalAsync
   Awaiter). The interface signal is HIGHLY CORRELATED with the type signals (a UI
   pointer-handler class already had discriminative field/param types and was
   named by an earlier pass), so its marginal naming yield is low. semantic_pct
   54.6% -> 54.7%. Kept as a permanent dump field for future cross-referencing,
   but not a major coverage lever on its own.

   METADATA PATH: empirically CONFIRMED DEAD as a naming source (2026-06-29). See
   item 5 below — no plaintext global-metadata.dat in memory (0 hits for magic
   0xFAB11BAF either endianness; no System.Object string table), and even if the
   off-disk keystream were re-RE'd the names there are equally beebyte-obfuscated.
   The in-dump structural-signal substrate (6 type sources + interfaces) is now
   essentially exhausted; remaining coverage gains need either method-body
   disassembly (string-literal / api-call mining from the IDA .i64 already on
   disk) or accepting the current ~54.7% semantic / ~59.4% source-type ceiling.

10. **String-literal disassembly — landed 2026-06-29, BIGGEST SINGLE GAIN.**
    Did NOT use the on-disk jun05 .i64/.asm (wrong build vs the jun29 dump; cross-
    build obf-name matching is fragile). Instead disassembled method bodies
    directly out of the jun29 memory dump with capstone (5.0.7, already installed)
    using the method_pointers (VAs) we already extract. LINKAGE (verified): a C#
    string literal load is `lea reg, [rip+disp]` -> a slot whose qword points at an
    Il2CppString object on the heap (object header[+0x00]==System.String klass VA
    0x16D2025FBE0; +0x10 int32 length; +0x14 UTF-16 chars). Both the slot itself
    and *slot can be the string object, so try both. NOTE the lea targets in a
    string-less method are RGCTX/metadata objects (klass ptr in module space) -
    filter by the String-klass header check, not by readability. ~12% of all
    methods carry >=1 resolvable literal. Mined every obfuscated still-unnamed
    class (read up to 16 methods, 1100 bytes each, stop at `ret`), dropped a NOISE
    set of argument-null-check names (index/obj/source/value/...). RESULT: 1,483
    obfuscated classes with >=2 discriminative literals; 10-way subagent fanout
    named 476, 378 matched the dump (keyed on original_name), apply propagated to
    435 instances. The literals are by far the richest signal: avatar download
    error messages, EarmuffMode audio settings, Pages/MM/* menu names, input
    action maps (Run/ActionSelectLeft/...), --command-line-args, notification type
    enums. semantic_pct 54.7% -> 59.1% (+4.4, biggest single-round jump), source_
    types_semantic_pct 59.4% -> 60.4% (+1.0). CAVEAT (honest): the instance-level
    +4.4 is inflated - the 435 instances are only 79 UNIQUE source types (one obf
    original_name = one TypeDefinition); 289 of them are generic instantiations of
    a single TypedObservableData. The HONEST metric is source_types (+1.0 / ~79 new
    distinct classes), per the long-standing generic-dedup rule. Tag string_literal
    _disasm in apply_class_names.py (now 9 sources). This reopens method-body mining
    as a substrate: next could be CALL-TARGET mining (which named API methods a weak
    class calls) or grouping the 289 TypedObservableData by their generic arg.

11. **Call-target disassembly — landed 2026-06-29, the CALL-TARGET follow-up.**
    Sibling to item 10. Where strings capture literal content, call targets capture
    BEHAVIOR: a weak class's methods `call rel32 <VA>`; resolve that VA to the
    NAMED method that owns it and you learn which API the class drives. Built the
    same way (capstone over jun29 method bodies). KEY PITFALL: 15,103 method VAs
    are SHARED across multiple methods (IL2CPP trampolines / shared il2cpp_codegen_
    object_new ctors - one VA labelled PipeStreamImpersonationWorker..ctor is reused
    by 78 methods); mapping a shared VA to one class.method floods every result with
    the same bogus call. FIX: only map UNIQUE VAs (exactly one method per VA) ->
    224,793 of 239,896. Dropped BCL/common-Unity owners, required >=3 distinct
    DOMAIN calls. RESULT: 1,897 obfuscated classes with signal; 12-way subagent
    fanout named 607, 534 matched the dump, apply landed 114 instances = 50 NEW
    distinct source types. Behavior-driven names: AnimatorModerationStateController,
    CameraClipPlaneConfigurator, HumanoidBoneForwardBinder, MicrophoneCapture, etc.
    semantic_pct 59.1% -> 60.2% (+1.1), source_types_semantic_pct 60.4% -> 60.9%
    (+0.5 / ~46 distinct). SMALLER than strings because this is the SECOND pass over
    the same weak-class pool (high overlap - 534 named but only 50 still-unnamed
    distinct types remained). Tool: build_calltarget_signal.py, tag call_target_
    disasm (apply_class_names.py now 10 sources). SUBSTRATE STATUS: method-body
    disassembly now yields strings + call-targets; the cheap wins are taken. Further
    method-body signals (call-ARGUMENT constants, field-access offsets, throw-type
    patterns) would be progressively lower-yield. Honest source-type ceiling is now
    ~60.9%; the big remaining bucket is generic-collection/async plumbing that has
    no domain identity to recover.

12. **Field-composition — landed 2026-06-29, the data-holder signal.** After
    strings + call-targets, surveyed the 3,209 still-weak unique types: 76% have
    NO statically-resolvable direct calls (virtual dispatch `call [reg+off]` can't
    be resolved from a dump), and a looser call-name bar yielded only ~35 mostly-
    logging candidates - confirming method-body CODE mining is exhausted. PIVOT to
    STRUCTURE: a weak class's field NAMES are obfuscated (only 4/7977 clean) but its
    field TYPES often still name clean domain types (Mediapipe.ImageFrame, Transmtn.
    Notifications.Notification, VRC.Core.ApiWorld). Tokenized field types, dropped
    BCL primitives + async/generic plumbing (UniTask/Cysharp.Threading/Func/...),
    required >=2 distinct domain tokens. RESULT: 218 candidates -> 71 after dropping
    plumbing-only -> 4-way fanout named 55 = 55 NEW distinct source types. Names are
    data-holder descriptors: ApiWorldHolder, LocalizableStringDictionary, Economy
    ProductEntry, MediapipeFrameResult. semantic_pct 60.2%->60.7%, source_types
    60.9%->61.6% (+0.7). Notably BETTER per-name than call-target (+0.5 from 114
    instances): these are distinct structs, zero generic-instance inflation. Tool:
    build_fieldcompose_signal.py (pure metadata, NO dump needed - unlike the disasm
    miners). Tag field_composition (apply_class_names.py now 11 sources). DEAD-END
    NOTE for the loop: also checked the "289 TypedObservableData" idea - they share
    ONE original_name (one TypeDef, already deduped to 1) and their generic arg is
    itself obfuscated (field type = List<obf>), so there is nothing to split on.
    Source-type ceiling now ~61.6%; remaining weak types are virtual-dispatch-only
    behavior classes + async/collection plumbing with no recoverable domain identity.

13. **Reverse-reference probe + exhaustive channel survey — 2026-06-29, NEGATIVE
    result (documented so the loop stops re-deriving it).** The stop-hook correctly
    noted "virtual-dispatch-only" wasn't PROVEN unrecoverable, only that a class's
    own outgoing calls are unreadable. So tried the REVERSE: name a weak type by how
    NAMED code uses it (a clean method that returns it / takes it / holds it as a
    field type). Built backref signal: 140 weak types ARE referenced by other named
    classes' descriptive method returns - but filtering to CONCRETE non-generic
    domain referencers collapsed it to 6 (e.g. KeyboardData.get_ActiveRequest, one
    getter each, too thin for a fanout). The 140 are referenced almost entirely via
    GENERIC-collection methods (EqualityComparer`1.CreateComparer, List`1.AsReadOnly,
    HashSet`1, ArrayPool`1) - i.e. the weak type is a generic ARGUMENT to a BCL
    collection, and the referencing method reveals nothing about its domain. Same
    plumbing wall, approached from the other side.
    EXHAUSTIVE CHANNEL SURVEY of the 3,154 remaining weak unique types (the
    definitive map): by parent/interface - 1,759 ordinary classes, 775 structs, 618
    collection/enumerator, 1 delegate, 1 exception, 1 async-state-machine (so the
    earlier "async plumbing" framing was OVERSTATED - most are real classes/structs,
    not machinery). BUT every metadata channel is obfuscated for them: namespace
    100% empty/obfuscated (1,798/1,798 of the non-plumbing subset), field NAMES
    4/7977 clean, field TYPES already mined (item 12), return/param types already
    mined (items 6-8), interfaces already mined (item 9), own strings + own calls
    already mined (items 10-11), and reverse-references are generic-plumbing-only
    (this item). CONCLUSION: ~2,500 of these are genuine domain types that emit NO
    recoverable signal through ANY channel in this dump - they load no literals, use
    virtual dispatch, and are referenced only as generic args. This is the
    information-theoretic floor for static analysis of THIS memory dump. Source-type
    ceiling ~61.6% is real. Breaking it needs a DIFFERENT substrate (the Beebyte
    metadata keystream re-RE, item 5 - still blocked) or DYNAMIC tracing (runtime
    instrumentation to watch what these types actually carry), not another static
    pass. No code written this round; backref_signal_raw.json was a probe, deleted.
5. **Metadata path** as the eventual second substrate: needs the Jun-26 Beebyte
   header keystream re-RE'd from GameAssembly.dll (old 05-02 keystream fails;
   recovered first 8 bytes `5F 05 73 3B D1 B6 A8 BD` are not arithmetic/linear/
   short-cyclic). Lower priority now that the memory path resolves both primitive
   and class/valuetype field types and bypasses on-disk encryption entirely.
   **CONFIRMED BLOCKED + REDUNDANT 2026-06-29:** scanned the full 3.8 GB memory
   dump for the IL2CPP metadata magic 0xFAB11BAF (LE `af1bb1fa` and BE) -> 0 hits;
   the decrypted-header probe `System.Object\0` string table -> absent. The
   runtime never materializes a plaintext global-metadata.dat blob in memory (it
   decrypts string literals on demand, which the memory path already captures).
   So the metadata substrate requires off-disk keystream RE AND would only yield
   the same beebyte-obfuscated names. Dead end for naming; deprioritized
   indefinitely in favor of remaining in-dump structural signals.




14. **Type-derived FIELD names — landed 2026-06-29, a NEW AXIS (not class naming).**
    After item 13 declared the static CLASS-naming floor, pivoted axes: the pipeline
    also scores METHODS (93.5%) and FIELDS (82.7%), and fields were never targeted.
    32,543 fields are f_HEX (Beebyte field names unrecoverable) but a field's TYPE is
    recoverable, and a field name usually mirrors its type (type GameObject ->
    _gameObject, ApiAvatar -> _apiAvatar). ALIGNMENT (verified 204/205): deobf stores
    fields as bare strings in the SAME ORDER as the typed dump's obfuscated-named
    fields, so position-align f_HEX -> typed obf field -> read type; obfuscated type
    names resolve through our class-name map. QUALITY FILTER drops primitives, generic
    params, async/plumbing machinery (_awaiter/_methodBuilder/_action/_func), and
    obfuscation-residue names (Sibling/Impl/BaseClassN/hex-tail). RESULT: 4,392 high-
    quality field names across 1,118 classes. fields 82.7% -> 85.1% (+2.4). Names are
    real: _gameObject, _transform, _button, _color, _sprite, _material, _rectTransform,
    _networkManager, _apiAvatar; and where the field type was a now-named domain class
    the field inherits it (_dropPortalButton, _chatboxOpacity, _portalLockedDisplay).
    Tools: build_fieldname_from_type.py + apply_field_names.py, wired into pipeline as
    stage 2d-field (runs AFTER class names so domain-typed fields resolve). This proves
    the item-13 "floor" was a CLASS-axis floor, not a project floor - the field axis
    had 32k untouched targets. METHODS at 93.5% are the next axis to probe; classes
    remain at the real ~61.6% static ceiling.

15. **Method-axis probe — 2026-06-29, PARTIAL/PRINCIPLED-STOP result.** Followed the
    item-14 axis logic to METHODS: 36,874 m_HEX methods (6.5% of 569,859). Verified
    method ordering aligns deobf<->typed (27/28), and 42,788 obfuscated methods DO
    carry return/param types. Tried the field-axis trick (derive name from type):
    12,464 m_HEX methods are 0-param non-void ("getter-shaped"). BUT this is NOT safe
    the way fields are: a field unambiguously HAS one type, whereas a 0-param method
    merely RETURNS a type - it could be a property getter OR a factory OR a computed
    accessor. The typed dump has NO properties table (keys: name/namespace/parent/
    methods/method_pointers/method_return_types/method_param_types/fields/field_types/
    va), so there is NO way to confirm a given m_HEX is actually a property getter.
    Naming a factory get_Color would be ACTIVELY WRONG - worse than m_HEX. After the
    residue filter only 81 clean-domain candidates remained anyway (get_Localizable
    String, get_DateTime, get_Color, get_Bounds, ...), not worth introducing
    potentially-mislabeled names. PRINCIPLED STOP: discarded the output, correctness
    over coverage. The methods that ARE safely nameable need the item-11 call-target
    technique applied PER-METHOD (name a method by the API it calls - verifiable
    behavior, not a type guess): 28,078 of the m_HEX are in ordinary (non-machinery)
    classes, so a future per-method call-target miner is the right tool, but it's a
    large disasm build, not a cheap metadata pass. AXIS SUMMARY after items 14-15:
    classes ~61.6% (real static ceiling), fields 85.1% (type-derived, item 14 -
    cheap+safe because a field has exactly one type), methods 93.5% (type-derivation
    UNSAFE; remaining 6.5% needs per-method behavioral disasm). The cheap safe axis
    wins are now taken on all three entity axes.

16. **Per-method call-target naming — landed 2026-06-29, the SAFE method axis.** The
    item-15 principled stop noted type-derivation is unsafe for methods but per-method
    call-target naming (item-11 technique applied PER METHOD) is verifiable behavior,
    not a type guess. Built it: disassemble each obfuscated method body, find the
    dominant DISTINCTIVE domain API it calls, name the method Invoke_<Api>. The
    "Invoke_" prefix is deliberate - it states the method DRIVES that API without
    claiming it IS that API. PITFALL FOUND: the typed dump's method_pointers VAs
    resolve against VRChat_6456_20260629, NOT 32984 (the field/class source dump) -
    wrong dump gave 0/20 VA hits, correct dump 20/20. FILTERS: unique-VA map (drop
    shared trampolines), exclude BCL owners + logging/builder noise (VRCLogger/ZLogger/
    AppendLiteral dominated the raw signal) + GENERIC Unity accessors (SetActive/
    get_transform too common to distinguish). Dominant distinctive API must appear
    >=2x, >=5 chars. RESULT: 1,769 candidates, but 1,208 were ALREADY semantically
    named by other signals -> 451 genuinely-new m_HEX methods named across 157 classes.
    methods 93.5% -> 93.6%. Names verified meaningful: Invoke_SetHumanoidBodyPartActive,
    Invoke_ForceRebuildLayoutImmediate, Invoke_RemoveAllListeners. Tools: build_method_
    calltarget_signal.py (manual, needs dump) + apply_method_calltarget_names.py (wired
    as pipeline stage 2d-method, apply-only - same split as the call-target CLASS
    stage). Position-aligns obf method name -> m_HEX (27/28 verified). AXIS STATUS: all
    three entity axes now have their cheap+safe wins AND their one disasm-based deep
    signal taken - classes (call-target item 11), methods (this item), fields (type
    item 14). The 6.4% methods still m_HEX are virtual-dispatch-only or call only
    generic/logging APIs - no distinctive behavior to name them by.

17. **Per-method STRING-literal naming — 2026-06-29, NEGATIVE result (the symmetric
    probe to item 16, with EMPIRICAL disproof).** Item 16 applied call-targets per
    method; the symmetric idea is to apply STRINGS per method (item 10 mined strings
    only per CLASS). Built the per-method version: 6% of m_HEX methods load a "good"
    string, 3,826 after a strict identifier filter (config-key shaped: Button,
    worldName, MainMenuMarketplace, VRC_ACTION_MENU_ONE_HAND_MOVE, PixelLightCount).
    BUT correctness check killed it: a loaded string names DATA the method touches
    (a key/label/UI string it consumes), NOT what the method DOES - unlike a call
    target, which is an action the method PERFORMS. DECISIVE TEST: took 2,001
    ALREADY-NAMED methods (PascalCase real names), disassembled them, and checked
    whether the strings they load correlate with their real name. Only 187/2,001 =
    9% correlate - i.e. naming an unknown method from its loaded string would be
    WRONG ~91% of the time. The 9% that match are profiler-marker strings that echo
    the method name (OnConnectedToMaster, SanityCheck, FindMainCamera) - not
    generalizable. Same lesson as item 15's getter problem: high candidate VOLUME
    (3,826) but unsound INFERENCE. PRINCIPLED STOP, no names applied, raw probe
    deleted. This confirms the item-16 asymmetry is fundamental: for METHODS,
    call-target (what it DOES) is sound, string-literal (what data it NAMES) is not.
    Strings remain sound for CLASSES (item 10) because a class aggregates many
    methods' strings into a domain fingerprint; a single method's single string
    doesn't determine its verb.

18. **Turning item-17's reverse-validation on my OWN item-16 work — 2026-06-29,
    self-audit + honest reclassification.** Item 17 established the methodology: test
    a naming signal by checking correlation against ALREADY-NAMED entities before
    trusting it. Applied it to item 16's own call-target method names (Invoke_<Api>).
    TWO measurements, both true, NOT contradictory:
    (a) NAME-CORRELATION: the dominant-API-derived name matches the method's real
        name only ~1-2% of the time (898 named methods, 11 correlate at min-calls>=2).
        WORSE than the 9% string signal I rejected in item 17.
    (b) ANNOTATION-ACCURACY: after fixing a verification bug (the _N dedup suffix broke
        exact-match; initial reading was a false 50%), the Invoke_<Api> name correctly
        describes an API the method really calls 1719/1724 = 99% of the time.
    RESOLUTION: these are not in tension. Invoke_ was DESIGNED as a behavioral
    annotation ("this method DRIVES api X"), never a claim to recover the original
    name - so (a) is measuring something it never promised. The legitimate issue (a)
    surfaced is CLASSIFICATION: compute_final_stats counted the 451 Invoke_ names as
    plain 'semantic', conflating "behaviorally annotated" with "true name recovered"
    and inflating the methods coverage. FIX: compute_final_stats now tracks
    behavioral_annotations separately and reports BOTH semantic_pct (93.6%, readable)
    AND true_name_pct (93.5%, recovery, behavioral excluded). The 451 names stay (a
    99%-accurate behavioral label IS useful to a reverse engineer), they're just no
    longer double-counted as name recovery. LESSON (extends item 17): the reverse-
    validation methodology must be turned on one's OWN prior signals, not just new
    candidates - and "is this name accurate?" and "does this name recover the
    original?" are DIFFERENT questions that need separate metrics. A behavioral
    annotation is honest only when the coverage number doesn't pretend it's a recovered
    name. No dump changes this round; the change is to HONEST ACCOUNTING.

19. **Reverse-auditing item-14 FIELD type-derivation (extending item 18 to another
    of my own signals) — 2026-06-29, classification UPHELD (opposite verdict to 18).**
    Item 18 established: turn reverse-validation on my OWN prior signals. The natural
    next target is item 14's type-derived field names (_gameObject, _apiAvatar) - like
    Invoke_, they are DERIVED (from the field's type), not recovered Beebyte originals,
    and are counted plain 'semantic'. Same audit, OPPOSITE result. Took 8,000 fields
    with genuine developer names (from non-obfuscated classes) and checked whether the
    type-derivation reproduces them: 38% EXACT (type name == field name) + 19% partial
    = 58% correlation. Excluding plumbing types (Dictionary/List/Task, where Dictionary
    ->dictionary is a trivial match), pure DOMAIN-type fields still correlate 17%.
    Compare: item-16 method call-target names correlate ~1-2% with real names, item-17
    strings 9%. So field type-derivation is a categorically STRONGER recovery signal,
    for a STRUCTURAL reason: C# developers genuinely name fields after their types
    (Transform transform, Color color) far more than they name methods after one API
    they call. DECISIVE distinction: a field of type Color named _color IS a valid,
    correct C# field name a developer would actually write - whereas Invoke_SetActive
    is an annotation prefix no developer writes. The field names are NAMES; the method
    Invoke_ entries are LABELS. VERDICT: item-14's 'semantic' classification STANDS
    (no behavioral_annotations split needed for fields), with the documented nuance
    that the headline correlation (58%) is plumbing-inflated and the domain-type subset
    is a more modest 17%. LESSON (completes the item 17/18 arc): reverse-validation is
    not a guillotine - applied honestly it can ACQUIT a signal as readily as it
    convicts one. The right question is not "is the name derived?" (all our names are)
    but "is the derived name one a developer would actually have written?" - fields YES,
    method-Invoke_ NO-but-useful-as-label, strings NO. No code/dump changes; this is an
    audit that confirms existing accounting is honest.

20. **Reverse-auditing the CLASS signals (items 10-13) under the item 18/19 lens —
    2026-06-29, found + fixed a 5.6-point inflation.** Continuing the self-audit arc
    onto the class axis (the lowest, highest-leverage one). First checked the 12 class
    signal outputs (a1/workflow/calltarget/string/combined/field-type/...): all produce
    developer-STYLE names (VrcStationExitController, LegacyDownloadManager) and 100% of
    them pass is_weak_name - the residue-only placeholders never enter the applied
    signals, they stay as the unsolved remainder. So far clean. BUT a cross-check of
    the 6,029 'strong' class names found 562 (9%) that reduce, after stripping the hex
    residue tail, to exactly "Delegate" (Delegate_72B1, Delegate_DD17, ...). Verified:
    562/564 are genuine MulticastDelegate subclasses. "Delegate" is structurally
    accurate but carries ZERO domain content - it's a LABEL for the class's framework
    role, exactly the item-18 situation (accurate, but not a recovered developer name).
    The criterion accepted them because "Delegate" (>=3 chars, not a synthetic token)
    survives _residual stripping. FIX: added _GENERIC_BCL_ONLY to name_quality.py - a
    name that reduces to a single generic framework word (Delegate/MulticastDelegate/
    Object/Component/ValueType/Enum/Attribute) + hex tail is now weak. DOMAIN-QUALIFIED
    names keep their content and stay real (DelegateRegistry, EventDelegate,
    InputActionDelegate - 6 new golden cases pin this). RESULT: classes 60.7% -> 55.1%
    (-562 names, -5.6 points). This is the class-axis analog of item 18's method
    correction, and BIGGER. The test_name_quality live-recount cross-check caught the
    criterion/stats divergence immediately (5467 != 6029) - the guard worked exactly as
    designed. LESSON: the item-19 acquittal of fields did NOT mean all prior signals are
    clean; each axis needed its own audit, and the class axis had the largest hidden
    inflation of the three. The honest class number is 55.1%. Across the three axes the
    audited-honest figures are now classes 55.1% / methods 93.5% true-name (+0.1
    behavioral) / fields 85.1% (upheld). No new names invented this round; coverage went
    DOWN because the accounting got more honest.

21. **Trying to RECOVER the 562 Delegate_<hex> names item 20 demoted — 2026-06-29,
    confirms the demotion (unrecoverable, not just unlabeled).** After item 20 demoted
    562 MulticastDelegate-subclass placeholders to weak, the constructive question is
    whether they can be genuinely NAMED rather than just marked weak. Delegates have
    two identity sources: (a) their Invoke signature, (b) their use-site. Tested both.
    (a) SIGNATURE: built Func/Action names from Invoke's param+return types. Result:
    only 157/564 have a fully-clean signature (407 carry an obfuscated type in the
    params), and the names produced are GARBAGE - ActionActionAction, bare Action,
    ActionList. Naming a delegate "ActionActionAction" just swaps one generic
    placeholder for another; fails the item-19 test (not a name a developer writes).
    (b) USE-SITE: searched every field whose type is one of these delegates, hoping a
    domain-named field (onPlayerJoined, etc.) would lend its name. Result: of the 562
    obfuscated delegates, exactly ONE is referenced by a non-f_HEX field, and that
    field is itself generic (_current/_items). VERDICT: the 562 are genuinely
    UNRECOVERABLE, not merely unlabeled - confirming item 20's demotion was correct,
    not over-aggressive. A delegate type in this binary carries no domain identity:
    its signature is generic-typed and nothing names it at its use-site. LESSON: a good
    audit demotion should survive an honest attempt to REVERSE it. Item 20 said "these
    aren't names"; item 21 tried to make them names and couldn't - so 55.1% stands as
    the honest class figure, now doubly confirmed. No changes; this is the negative
    result that ratifies the prior round.

22. **PARENT-type as a class-naming signal — 2026-06-29, NEGATIVE (the structural
    opposite of item 19's field-type win).** Item 19 showed field-TYPE recovers field
    names 58% of the time; the symmetric class-axis idea is to name an obfuscated class
    from its base type (parent). Tested on all 10,326 still-obfuscated classes. Only 4%
    (479) have a non-generic domain parent, and 384 of those are parent=Array. Excluding
    Array, the real domain-parent population is ~95 classes, and the parents are mostly
    UI bases (MaskableGraphic, ScrollRect, Button) - naming a subclass <Parent>Subclass
    yields MaskableGraphicSubclass, a weak non-name (fails item 19). STRUCTURAL REASON
    this is the OPPOSITE of fields: a field IS-A its type (Color color is honest), but a
    subclass is a SPECIALIZATION of its parent - its identity is what it ADDS, not the
    base it shares with dozens of siblings. So parent-type cannot name a class the way
    field-type names a field. SECONDARY find: the 384 parent=Array classes are CLR-
    synthesized SZArrayHelper shims (they implement IList`1.Insert/RemoveAt/get_Item for
    T[]), pure runtime machinery with no domain identity. Checked whether they pollute
    the coverage denominator: 0 of them appear in deobfuscated_dump.json - the pipeline
    already excludes runtime-synthesized types from the obfuscated-class population, so
    the 55.1% is clean of this noise. No changes. LESSON: signal symmetry across axes is
    NOT guaranteed - field-type works because of IS-A, parent-type fails because of
    SPECIALIZATION; the same "derive name from related type" idea is sound on one axis
    and empty on another for a principled structural reason.

23. **Domain-INTERFACE as a class-naming signal — 2026-06-29, NEGATIVE via the item-18
    decisive test (role label != recovered name); the 62% correlation was a confound.**
    Following item 22's pointer that class identity comes from what a class ADDS,
    interfaces looked promising: 15% of obfuscated classes implement a domain interface,
    and after stripping framework noise (IReadOnlyList/IAsyncStateMachine/IStructural* -
    collection shims, compiler async, and the Array shims from item 22), the UI pointer-
    handler interfaces (IPointerClickHandler, IDragHandler, ...) remained, with 236
    unnamed candidates. FIRST measurement looked GREEN: 62% of already-NAMED classes
    implementing a UI-pointer interface have an interaction-flavored name (DropdownItem,
    RepeatButton, PanelEventHandler) - comparable to field-type's 58% (item 19). Almost
    shipped it. BUT applied the item-18 DECISIVE test: can the interface ROLE LABEL
    actually RECOVER the name? Took 34 named UI classes and checked if the real name
    contains the interface's role word (Clickable for IPointerClickHandler, Hoverable
    for IPointerEnterHandler, ...). Result: 0/34 = 0%. NO class is named "Clickable" or
    "Hoverable" - they are named DropdownItem, RepeatButton, etc. The interface tells you
    the ROLE, never the NAME. The 62% was a CONFOUND: UI classes independently have
    UI-ish names AND UI interfaces, but the interface cannot PRODUCE the name. The 0%
    test cut through the confound that the 62% correlation hid. VERDICT: REJECTED for
    per-class naming - applying it would inject 236 generic Clickable/Hoverable labels,
    the exact inflation item 20 just removed (a role label is not a recovered name, same
    as Delegate_ and Invoke_). LESSON (sharpens items 18+19): a high correlation with
    named entities is necessary but NOT sufficient - you must also test whether the
    signal can RECOVER the name vs merely co-occur with it. Field-type passes BOTH
    (58% correlate AND 38% exact-recover); interface passes the first (62%) and FAILS
    the second (0%). The exact-recovery test is the one that matters. Also confirmed
    item 22's nesting probe: this dump flattens nested types (0 classes carry a /+ nesting
    marker in the name), so enclosing-type context is unavailable. No changes; another
    principled rejection that keeps 55.1% honest.

24. **The 74 unapplied combined-type candidates + the real class headroom — 2026-06-29,
    quantified the ceiling and rejected auto-naming via gate-2 (9% < 15%).** Resumed
    after /goal mislabeled the perpetual loop "unachievable" (it has no terminal state;
    that is the directive's nature, not an error). Probed remaining class-naming signals
    under the item-23 three-gate test. (1) Own real METHOD names: 12% root-correlate, 4%
    exact - weak; the agent-noun rule (Stretch->Stretcher) recovers a clean 1% but only
    the SUFFIX, never the identity-bearing prefix (KeyValuePair in KeyValuePairComparer).
    Not a primary signal. (2) HEADROOM census of the 10,326 still-obfuscated classes: 74%
    have >=1 clean type signal, 33% have >=2 (combined threshold), but 20% have NO signal
    at all (no clean types, no real method names) - information-theoretically unnameable.
    So a hard ~20% floor is confirmed by direct count. (3) Found a genuine GAP: the
    combined-type signal emitted 74 candidates (high IDF, e.g. VRC_MainSibling_98B4 with
    LoggingMode/MirrorQualitySetting/PerformanceRating) that were NEVER processed by
    synthesize_names.py - it requires >=2 real FIELD NAMES, but these have obfuscated
    field names and signal only in field TYPES. All 74 are disjoint from synth+graded.
    Tried to name them from type tokens. Naive concat fails gate-3 (LoggingModeMirror-
    QualitySetting, BoundsAnimator - not developer names). Narrowed to a strict band
    (single dominant domain type), then ran the gate-2 DECISIVE test on the approach: do
    named classes whose dominant domain field-type is X actually contain X's root in
    their name? Result: 852/8860 = 9%, BELOW the 15% reject bar. A class that HOLDS an
    ApiHypeTrainInfo is named for its FUNCTION (Controller/Tracker), not its contents.
    VERDICT: the 74 are NOT safely auto-nameable; type CONTAINMENT describes what a class
    holds but cannot recover its ROLE-based identity. The 152 already-applied combined
    names worked only because each got human-quality synthesis judgment; auto-applying at
    9% accuracy would be item-20-style inflation. LESSON: the much-cited "74% have a
    signal" headroom is largely UNREACHABLE for auto-naming - containment != identity, so
    realistic auto-coverage sits far below 74%. 55.1% holds; the honest ceiling for
    fully-automatic class naming is bounded not by the 20% no-signal floor but by the far
    larger fraction whose only signal is containment (gate-2 failing). No changes; a
    quantified ceiling is itself a result.

25. **The ~6.4% m_HEX methods: signal census + gate-2 test = the same 9% ceiling as
    classes — 2026-06-29, completes the unified IS-A vs HAS-A law across all 3 axes.**
    The one axis never closed under the three-gate lens. Census of the 36,423 m_HEX
    methods (6% of 569,859 total): in the TYPED dump (the deob dump carries no type maps
    - confirmed 0% there, a red herring) the 109,801 obfuscated methods break down as 9%
    with a clean domain RETURN type, 19% with a clean domain PARAM type, but 72% with NO
    clean type signal at all. And the "signal" ones are dominated by LINQ/ZLinq/collection
    plumbing (ValueEnumerable<AggregateBy2<...>>, IComparer<genericparam>) - framework
    machinery, not domain methods. GATE-2 DECISIVE test on return-type naming: do named
    methods with a domain return type contain that type's root in their name? 4121/41645
    = 9%, BELOW the 15% bar, and the passers are trivial Get<X> accessors (GetSkeletonType
    <-SkeletonType). A method returning List<ApiPlayerModeration> is named for its ACTION
    (Fetch/Refresh/Update), not its return type. VERDICT: return/param types CANNOT
    auto-name methods - same 9% wall as the class lead-type signal (item 24). UNIFIED LAW
    across all three axes: a structural type signal recovers a name ONLY when the entity
    IS-A that type. FIELDS are IS-A their type (Color color) -> field-type passes gate-2
    (38% exact, item 19) -> fields reach 85.1%. CLASSES are HAS-A/role over their types
    (a class HOLDING ApiHypeTrainInfo is a Controller) -> type signal fails gate-2 (9%,
    item 24) -> classes plateau at 55.1%. METHODS are DO-an-action ON/returning types (a
    method returning List<X> Fetches) -> type signal fails gate-2 (9%, this item) ->
    methods' 93.5% comes NOT from types but from the call-target/behavioral signals
    (items 8-9,16,18) that capture ACTION, the right axis for a verb-like entity. This is
    why each axis needed a DIFFERENT primary signal and why their ceilings differ. No
    changes; the m_HEX remainder is confirmed structurally unnameable by type signals,
    and the three-axis audit is now theoretically complete - every axis closed with a
    measured gate-2 number and a structural reason (fields 38% IS-A pass; classes 9%
    HAS-A fail; methods 9% type-fail but action-signal pass).

26. **换武器:Ghidra 反编译语义信号 — 工具链跑通了,但 -noanalysis 伪代码无符号,
    callee 解析率仍撞 14% 墙(2026-06-29)。** 用户要求真去涨覆盖率而非再探测,指向
    D:\Tool\debugger 工作站。该站有 Ghidra 12.1.2 headless + Java 21 + pyghidra 3.1.0
    + GhidraMCP,但无 IDA(放弃旧 .i64 线)。先隔离了 output/gemini_hexrays_pred_*.json
    13 个文件 —— 它们不是数据,是提示词注入文本(伪装 CRITICAL INSTRUCTION 操纵 AI),
    移入 quarantine/。诊断旧管线为何停在 4%:现有 1252 个 IDA 伪代码符号被剥离(裸
    sub_/无字符串,仅 0% 含字符串证据),且 runtime_va 是 ASLR 随机基址不可 rebase。
    搭通 Ghidra:headless .bat 默认无 Jython(PyGhidra not available),改用 pyghidra
    open_program API 定点反编译,28/30 成功 —— 工具链命脉验证通过。但 -noanalysis 出的
    伪代码是 FUN_18059d520/UNK_/裸栈操作,无函数边界无符号,质量比 IDA 还差。用
    build_mass_hexrays_targets 的 runtime_to_ida_ea 公式(IDA_BASE+(rva&~0xFFFFFF))建
    全局 file-ea->方法名表(217220 条),把 Ghidra 的 FUN_<ea> callee 解析回真实符号:
    解析率 12-23%,解析到的名确实干净(PhysBoneGrab::get_Bone, KeyValuePairConverter::
    WriteJson)。但决定性的诚实评估:28 个反编译方法里只有 4 个(14%)调用了"可命名的
    具名方法",且 callee 多是泛型 plumbing(Span.TryCopyTo)。这是 item 17-25 同一堵墙
    在语义层的复现 —— 混淆方法之间互相调用,跨混淆边界的具名锚点稀疏。VERDICT:Ghidra
    语义路工具链可用且正确,但要真正突破需要 -process 全量分析(数小时)+ 从
    metadata_decrypted.dat(40MB 解密 global-metadata)恢复 IL2CPP 符号注入 Ghidra,
    这是一个独立的大工程(IL2CPP 符号重建),非一轮可成。本轮诚实产出:跑通了 Ghidra
    pyghidra 反编译工具链(可复用)、建了全局 ea->符号表、隔离了注入污染、确认了 4% 停滞
    的根因。覆盖率不变(55.1/93.5/85.1,无命名应用 —— 因为没有达到质量门的名)。
    LESSON:换武器(结构->语义)是对的方向,但语义信号的锚点(具名 callee)在重度混淆的
    自有代码里同样稀疏;真突破口是 IL2CPP 符号重建(metadata->Ghidra),应作为独立 P2
    工程立项,而非 loop 内速通。不强行应用低质量名维持了 55.1% 的诚实。

27. **P2 大规模扇出的前置数据校验,挡住了一次"自信地错"的灾难(2026-06-29)。** 用户
    explicit ultracode 授权开几百 agent 跑 P2 反编译命名。我没有直接扇出,先做了数据
    可信度校验 —— 这个决定避免了把几百 agent 喂给中毒数据。流程:建了正确口径目标池
    (coverage_stats 基于 deobfuscated_dump:9928 混淆类中 5467 已命名=55.1%,4855 个
    fallback 类是真目标,40576 方法,用类对象的 va 跨 dump 对齐)。用 pyghidra 反编译首批
    750 方法(104 秒,吞吐 OK),其中只有 91 个是真正需命名的 m_HEX(其余是接口实现已有名)。
    然后校验符号解析 —— 这步炸了:(a) item 26 用的 rebase 公式 IDA_BASE+(rva&~0xFFFFFF)
    有 BUG,~0xFFFFFF 只保留 24 位(16MB),但代码段跨 220MB,9% 的 EA 是碰撞别名 ——
    这就是为什么"9 个不同方法都解析成 StudioMeshSource.EnsureSyncedBuffers";(b) 尝试用
    mass_targets 的 ea<->runtime_va 校准,发现 K=runtime_va-ea 有 8 个值(35%/31%/23%...),
    证明 mass_targets 的 runtime_va 本身就是多次不同 ASLR 进程 dump 拼的;(c) 用 Ghidra
    的 FUN_ 地址(真实磁盘 file VA,ground truth)暴力细扫 2647 步找线性 base,最佳只
    9/80 命中 —— 决定性证明:**IL2CPP method_pointers(runtime 重定位地址)与磁盘 PE
    file VA 之间没有线性映射**,item 26 那些"解析对的符号"(PhysBoneGrab::get_Bone)全是
    碰撞巧合,不可信。(d) Ghidra -noanalysis 自己的符号只有 UNLOCK/CONCAT44/halt_baddata/
    func_0x... —— 零可用语义。VERDICT:反编译语义命名要成立,硬前提是把 IL2CPP 符号正确
    映射进 Ghidra,而这需要解析 PE 的 il2cpp 元数据节(CodeRegistration/MethodInfo →
    真实 method RVA),不能靠 runtime method_pointers rebase。这是 Il2CppDumper/Il2CppInspector
    那一类工具的核心工作。LESSON:在大规模 agent 扇出前校验输入数据可信度,是比扇出本身
    更重要的一步 —— 这次拦下了一次会产出几百个"自信但全错"名字的灾难。真突破口仍是
    IL2CPP 符号重建,但必须走元数据节解析(file RVA),而非 runtime 指针 rebase。覆盖率
    保持 55.1% 诚实未动。

28. **★突破: runtime→file-VA 是单一全局线性映射,item 27 的"无映射"结论被推翻(2026-06-29)。**
    用户开 ultracode workflow,4 个并发 agent 攻 metadata 解密地基。Track D(对冲路)发现并
    经我**独立从头复现**确认:runtime VA → 磁盘 file VA 存在单一全局常量映射
    `file_va = runtime_va - 0x7FFE38B10000`(= GameAssembly.dll 运行时加载基址 0x7FFFB8B10000
    - PE ImageBase 0x180000000)。三重独立验证(我用自己的 PE 解析器从头跑,非信 agent):
    (a) 自解析 jun13 DLL 的 .pdata 异常表得 573318 个真实函数起始,build-matched 的
    precise_dump_jun13.json 的 231634 个方法指针用该 offset **命中 207059 = 89.4%**,相邻
    64KB offset 对照仅 3-4%(信噪比 20x),且单射无碰撞;(b) 抽样映射后的 file 地址读磁盘字节
    **32/40 是干净 x64 函数序言**(4883ec/48895c24/push 等);(c) 解析 minidump
    VRChat_40752 的 ModuleListStream,GameAssembly.dll base **直接报 0x7FFFB8B10000**,
    implied OFF 与拟合值完全一致——映射常量无需拟合,从 dump 模块表直读即可。
    **为什么 item 27 错了:** 那个 "9/80 无映射" 是用被否定的 24-bit-mask 公式产出的污染
    Ghidra GT 去验证的,基线本身就错(GT ea 落在 mid-instruction,仅 3.8% 在 .pdata)。
    用与构建自洽的 .pdata 真函数表做 GT,结论翻转。残差 24575 里 86% 是 x64 leaf 函数(无
    .pdata 记录,正常),实际有效覆盖 ~95%+。**关键纪律: 必须 build-matched** —— jun13 DLL
    只能配 jun13 dump(之前用 jun29 typed dump 配 jun13 GT 是混乱根源)。**影响: metadata
    解密(Track A/B/C)不再是关键路径**,这条路门槛低得多:每个 dump 一个常量(从 minidump
    模块表读)即可把 ~217k runtime 方法符号换算到 file_va,Ghidra 以 ImageBase 加载对应 DLL
    直接重命名 FUN_。下一步: 把 217k 符号换算落地 → 反编译 fallback 类方法 → 注入符号 →
    伪代码已带名 → 这才是 agent 命名的优质输入。覆盖率仍 55.1%(尚未应用)。

29. **地基落地: 176534 个 file-VA→真实名符号表生成并验证,callee 解析从假14%变真18-20%且名字有意义(2026-06-29)。**
    基于 item 28 的映射,写了 tools/map_runtime_to_fileva.py:从 minidump ModuleListStream
    读 GameAssembly base(0x7FFFB8B10000)→ OFF=0x7FFE38B10000 → 把 jun13 dump 的方法指针
    换算 file_va。产出 output/p2_research/jun13_file_va_symbols.json(176534 个非混淆符号,
    89% 落在 .pdata 真函数起始)+ jun13_script.json(Ghidra 注入格式)。中途踩坑: 第一版
    pe_sections 把节头 struct 元组顺序写错(vsz/va/rawsz/rawoff 错位)导致 .pdata 解析全错
    (命中掉到 0%/52个),用我之前验证过的"按节名解析"方式修正后恢复 89%。用正确映射重测
    item 27 那批 batch1 伪代码: 91 个 m_HEX 方法里 18-20% 有域信号 callee,且名字是**真的有
    意义的**(JointConverter::SpringToConfigurable、Animator::GetBoneTransform、
    MeshFilter::set_sharedMesh、VRCLogger::GetLogger)—— 对比 item 27 那些碰撞别名的假名
    (StudioMeshSource.EnsureSyncedBuffers 重复9次)。这证明地基真的修好了。诚实边界: 18-20%
    是 batch1(随机中等类)的数,不是全局上限;真正的 agent 命名输入应该是(a)反编译混淆类
    自己的方法体 +(b)把 176k 符号注入 Ghidra 让伪代码内联显示真名,而非事后解析 callee。
    Track A 确认 Il2CppDumper 对 jun26 加密 metadata 无能为力(解密非必需,已绕开)。Track B/C
    仍在跑解密(现在是锦上添花)。下一步: Ghidra 符号注入 + 批量反编译 fallback 类 → agent 命名。
    覆盖率仍 55.1%(未应用)。

30. **Track C 确认: metadata 名字区是明文,加密是周期256重复XOR;两点经独立复现(2026-06-29)。**
    Track C 密码分析(主控独立验证两个承重声明):(1) global-metadata 约 62% 加密,但**所有
    类型名/方法名/字段名根本没加密**——明文区 ~0x16E3600 起,strings 直接命中 UnityEngine×5165、
    PhysBone×125、MonoBehaviour×11、VRC.Audio.Voice|MicrophoneManager/NoiseGate、DynamicBone|Particle
    等 9976 个 il2cpp `namespace|name` 标识符。这是可直接用的命名词典,零解密。(2) 加密区(开头
    连续 ~23MB,含 header+定义表)是周期=256 的逐位置字节变换(自相关 lag256 尖峰、前后半 key
    100% 一致)——等价一把 256B 重复 XOR key。我独立用熵分块复现: 前 ~23MB H≈8.0(加密),
    名字区 H≈5-6(明文),完全吻合。诚实卡点(Track C 自陈): 那把 256B body key 没能仅靠统计
    恢复(明文是 int32 索引数组,无 ≥256B 定值 crib)。若 Track B 从 jun26 DLL 推出任意 256B
    连续 crib,body key 可一次性全恢复,解开全部 25MB 加密结构表(MethodDefinition 的
    nameIndex/token)。但这只在"想要 jun26 自洽全符号"时才需要——item 28-29 的 Track D 映射
    已用 jun13 解决了 P2 地基,解密非必需。产出: trackC_findings.md/cryptanalysis.py/
    plaintext_names_sample.txt。可立即收割的资产: 9976 明文标识符词典(给命名 agent 当先验)。

31. **build-matched 三元组确定 + fallback 类真实构成诊断(2026-06-29)。** 落地 item 28-29 时
    发现关键: 我最初用 jun13 符号表去配 batch1 targets(jun29 typed dump + 旧公式建的),
    版本错配,batch1 反编译的是错地址的函数 —— item 27 的"假命名"部分源于此。厘清各数据集:
    (a) **deob dump = output/deobfuscated_dump.json**(jun29 unity6-6000.0,source_dump
    VRChat_32984_20260629)是 coverage_stats 的权威来源,含 original_name + is_weak_name 分类;
    (b) 它的 method_pointers 来自 VRChat_32984 进程,GameAssembly base=0x7FFE9E7B0000(从该
    minidump ModuleListStream 读),**OFF=0x7FFD1E7B0000**;(c) 与之 build-matched 的 DLL 是
    **Steam 当前 GameAssembly.dll**(jun26,75% method_pointers 落 .pdata 真起始,jun13 DLL 仅 4%
    —— 证明 deob 配 Steam DLL 而非 jun13)。**铁律再确认: deob dump ↔ Steam jun26 DLL ↔
    VRChat_32984 base**,三者必须同组。
    **fallback 类(4461)真实构成诊断(决定反编译可行性):** 这些类的方法绝大多数是继承的
    boilerplate(GetInstanceID/Equals/GetHashCode/op_Implicit/CompareBaseObjects/
    IsNativeObjectAlive),字段是 hash 名(_3494)。统计: **25%(1143)是纯 boilerplate
    —— 无自有方法,反编译无意义,根本不可命名**;74%(3318)有自有方法但都是混淆 m_HEX。
    所以反编译命名的真实可及目标 ≈ 3318 类,不是 4461。这是对 P2 上限的诚实修正。下一步:
    用 deob dump + Steam DLL + OFF=0x7FFD1E7B0000 给这 3318 类的 m_HEX 方法算正确 file_ea,
    注入 176k 符号后反编译。覆盖率仍 55.1%。

32. **★端到端管线打通: 注入195k符号后反编译,67%混淆方法显示真实具名callee(2026-06-29)。**
    用 build-matched 正确配置(deob dump jun29 + Steam jun26 DLL + OFF=0x7FFD1E7B0000)跑通
    完整管线 tools/decompile_with_symbols.py:(1)pyghidra 打开 Steam DLL,(2)注入 195029 个
    file_ea→真实名符号(createFunction+setName,全部成功),(3)反编译 fallback 类的 m_HEX 方法。
    验证批 10 类 62 方法: **59/62 反编译成功(95%)**,字节确认是真 x64 序言(4889542410 等)。
    关键结果: **40/59(67%)伪代码含有意义的具名 callee**,且名字真实可信:
    MainThreadQueueDrainer::op_Implicit、ZLoggerEntry::Return、IObjectPoolNode::get_NextNode、
    StringFormatterLogState::ToString。对比 item 27 被污染的 14%/碰撞假名,这是质变 —— 证明
    Track D 映射 + 符号注入这条路真的产出优质命名输入。一个方法调用 ZLoggerEntry::Return +
    StringFormatterLogState::ToString 显然是日志相关,agent 可据此命名。**管线各环已验证可用:**
    map_runtime_to_fileva(符号表)→ decompile_with_symbols(注入+反编译)→ 优质伪代码。
    下一步: 对 1265 个有 m_HEX 的 fallback 类(9729 方法)批量反编译,agent 读伪代码命名,
    name_quality 三关+gate2,应用,重算覆盖率。覆盖率仍 55.1%(未应用)。

33. **Track B 部分破解 jun26 解密(名字可解,结构表未解);4-track 收束一致(2026-06-29)。**
    Track B 用 jun26 minidump 作 known-plaintext oracle(dump 里同时有加密文件副本+已解密字符串
    buffer,XOR 直接逆 keystream)破解 jun26:**没换算法,只轮换常量**,与旧 decrypt_metadata.py
    同族(位置相关 XOR ramp)。主控独立验证: 解密后 magic=0xFAB11BAF PASS,version=31,
    identifier 区解出 VRCPlayerApi×213/PhysBone×356/UdonBehaviour×60 等与进程 dump 逐字节一致。
    keystream: header 前缀 ks[0:8]=5f 05 73 3b d3 b6 a8 bd(d3 对应 v31);数据段全局 ramp
    plain[f]=enc[f]^((f+K)&0xFF),K=0xC3(string-literal 区)/0x2D(identifier 区)。
    **诚实限制(我验证发现):** header section 表 dword 仍是垃圾(off=0xB85C5C84 超过 40MB
    文件),因 Track B 只恢复 328B header keystream 的 91B,**结构表(MethodDefinition
    nameIndex/token)未解**,故 Il2CppDumper 仍无法静态解析。补全需逆 MetadataLoader。
    **4-track 收束结论(一致):** (A) 现成 Il2CppDumper 无法处理加密 metadata;(B/C) VRChat
    名字可恢复(明文区+ramp 解密),但结构表未解,不能喂 Il2CppDumper;(D) runtime→file-VA
    映射直接给出 file_va→名,**这是唯一打通到反编译的路,且已端到端验证(item 32)**。解密
    最终非必需,Track D 假设成立。产出: trackB_decrypt.py/findings.md/metadata_decrypted.dat
    (名字区正确,header 表未补全)。

34. **全量反编译完成: 3944/6983 m_HEX 方法成功(56%=on-pdata 边界),1740 有域 callee 信号(2026-06-29)。**
    对 1265 个 fallback 类的 6983 个 m_HEX 方法跑 decompile_with_symbols(Steam DLL+195k 符号注入)。
    结果干净可解释: **成功 3944/6983(56%),恰好=落在 .pdata 的方法**(3920/3944 在 .pdata,
    且 0 个 .pdata 方法失败)。失败的 3039 全部 off-pdata —— 是 x64 leaf 函数,Ghidra 不做全量
    auto-analysis 就不会在那些地址建函数(analyze=False 是为速度,232MB 全量分析要数小时)。
    这是清晰边界不是 bug。可用产出: **3944 反编译方法,1740(44%)有域 callee 信号**
    (StringFormatterLogState/ZLoggerEntry/IObjectPoolNode 类真实名)。耗时仅 72 秒(比预估
    2 小时快得多,注入 90s 摊销后反编译极快)。下一步: 用这 1740 个带信号的方法(分布在多少
    fallback 类待统计)按 build_deep_class_batches 格式打包 → agent 读伪代码命名类 → name_quality
    is_weak_name 门控 → apply_class_names 合并(作为新 name source)→ compute_final_stats。
    剩 3039 leaf 方法需全量 auto-analysis 才能救(后续优化)。覆盖率仍 55.1%。

35. **★关键修正: IL2CPP 共享泛型 thunk 导致 callee 误归因,去碰撞后信号质量剧变(2026-06-29)。**
    slice00 命名 agent 主动 flag: 同一 callee 三元组(IObjectPoolNode::get_NextNode 等)出现在
    大量互不相关的类里、且混着矛盾领域(SteamVR pose + TeleportMarker)—— 疑似误归因。我核实:
    确实如此。**IL2CPP 把共享/去重的泛型方法实例指向同一段 native 代码**,导致一个 file_ea 对应
    多达 8108 个不同逻辑方法名(如 0x180B43320)。我注入符号时每个 ea 只能取一个名,于是所有调用
    该共享 thunk 的类都"看起来"在调 IObjectPoolNode::get_NextNode(出现在 106/442 类!)——纯假
    callee。统计: 195029 符号 ea 里 12248(6%)碰撞,但高频噪声集中在 ~15 个共享 thunk。
    **修正: 只信无碰撞 ea 的符号**(182781 个干净 ea=93%;按 safe 名算 158032 clean / 90554
    collided)。重建 naming_batches_clean.json: **230 类有干净信号,20 强信号(>=5)**,且 callee
    领域高度自洽 —— DOTween::Sequence+CanvasGroup::set_alpha+RectTransform::set_anchoredPosition
    =UI 补间动画类;FavoriteArea::FetchLists+FavoriteAreaListFetcher::GetCachedPtr=收藏夹类。
    对比污染版可猜→现在可定。教训: 注入前必须按 ea 唯一性过滤,共享 thunk 的名零信号。
    正在跑的 12 个 agent 用的是污染 batch,需停掉重派(它们 null 掉噪声类是对的,但应基于干净
    信号重命名)。覆盖率仍 55.1%。

36. **命名 gate 验证通过 + 多 agent 独立印证噪声诊断(2026-06-29)。** 10/12 原始 slice 完成,
    gate_decompile_names.py 跑通: total 405, accepted 37, null 330, **no_clean_signal 拒绝 38**
    (来自污染 batch、无干净 callee 支撑的名,正是 item 35 要拦的)。接受的名质量真实可信:
    CanvasGroupTweenAnimator、ShaderLoader、InventoryItemEquipHandler、MainThreadQueueDispatcher、
    FavoriteAreaListController、ApiFileVersionResolver、VRCLogMessageBuilder —— 像真开发者类名。
    **关键交叉验证: slice07 agent 独立重新发现了 item 35 的共享 thunk 问题** —— 它自己判断
    UnityObjectWrapper_4/IObjectPoolNode::get_NextNode/ThrowHelper 是基础设施转发桩噪声而非领域
    信号,与我的碰撞分析完全一致。多个独立 agent 收敛到同一噪声诊断,强证保守 gate 正确。
    注意: 出现多个 RegexCacheAccessor(不同 orig),待核实是否合法(多个 regex 相关类)或过度命名。
    gate 已加硬约束: 只接受 obf_class 在 naming_batches_clean 有干净信号的名。等 6 个 clean-pass
    agent(75 强信号类)完成后做最终 apply+重算。覆盖率仍 55.1%(未 apply)。

37. **gate 再加固: distinctive-callee 要求,剔除泛型 accessor 噪声(2026-06-29)。** 预览发现 7 个
    RegexCacheAccessor 等过度命名 —— 它们只靠单个高频 callee RegexCache::GetCachedPtr(出现在 24
    个干净类!)+ ThrowHelper 噪声。即便去了地址碰撞,GetCachedPtr/UnityObjectWrapper_4::*/
    ThrowHelper 仍是跨大量无关类的泛型 accessor,零领域信号。gate 加第三关: **必须 >=1 个
    distinctive callee**(非 ThrowHelper/GetCachedPtr/UnityObjectWrapper,且出现在 <8 个类)。
    230 干净类里 80 个有 distinctive 信号。重跑 gate: accepted 38(从含噪的版本收紧),
    no_clean_signal 拒 55,dup 合并 12。结果名质量明显更高: OscMessageSender、
    AvatarPerformanceStatsController、UIPanelTweenAnimator、ShaderLoader、ApiDeleteRequestHandler、
    NetworkSyncableLogger 等,单 callee 的 Regex* 被正确剔除。**遗留: 重名**(3×
    ApiFileVersionResolver 等不同 orig 同名),最终 apply 时需加数字后缀消歧保唯一。等最后 1 个
    clean-pass agent 完成做 apply+重算。覆盖率仍 55.1%。

38. **★最终 apply 完成 + 诚实归因(2026-06-29)。** 全 18 个 naming 结果文件回齐,gate 三关+消歧:
    517 提议 → accepted 42(唯一名,5 个 dup 加后缀消歧),null 395,no_distinctive_signal 拒 61。
    apply_class_names 合并,compute_final_stats 重算。**两个口径必须分清(诚实关键):**
    (a) instance-level headline: semantic 5467→5631(+164),semantic_pct 55.1%→56.7% ——
    **此数被 mojibake-original 碰撞膨胀**: apply 按 original_name 键入,而许多不同混淆类解码出
    相同垃圾 original 串(如 MainThreadQueueDispatcher 的 original 被 56 个类实例共享,实为 6 个
    不同逻辑类 by method_pointers),一个名摊到 106 个类实例。(b) **source_types(按 original_name
    dedup,诚实"distinct 类"口径): 4609→4653 = +44**,56.1%→56.7%。**真实贡献 = +44 个 distinct
    源类型**(与 42 个 gated 名吻合,多 3 因碰撞组里含 >1 真类)。42 个名质量过硬:OscMessageSender、
    AvatarPerformanceStatsController、ShaderLoader、ApiDeleteRequestHandler、UIPanelTweenAnimator、
    NetworkSyncableLogger、FavoriteAreaListManager 等,全部有 distinctive callee 支撑。**P2 诚实结论:
    Track D 反编译命名管线可行且产出真名,但受数据上限约束,净增 +44 distinct 类(+0.6pt 诚实口径)。
    headline 56.7% 含碰撞膨胀,真实 dedup 口径同为 56.7% 但增量仅 +0.6pt。**

39. **★off-.pdata leaf 方法全部救回: CreateFunctionCmd 修复(2026-06-29)。** item 34 的 3039 个
    失败方法(off-.pdata leaf)根因: createFunction(None,ea,...) 在 analyze=False 下无法自动
    算出"包含 entrypoint 的函数体"(报 "Function body must contain the entrypoint";字节其实已
    反汇编为合法指令如 MOV RAX)。修复: 用 **ghidra.app.cmd.function.CreateFunctionCmd(ea)**
    作 fallback —— 它自己反汇编+追踪函数体。实测 10/10→全量 **3039/3039 全部反编译成功**(~45 秒)。
    合并 full+retry = 3457 唯一 EA(方法共享地址,thunk dedup)。重建 v2 干净 batch(同 item35/37
    碰撞+distinctive 过滤): 信号类 230→**332**,distinctive 91 个全是新类(上轮未命名),
    含 DOTween/RectTransform UI 补间、layout、ZLogger 等强信号。已派 agent 命名。
    decompile_with_symbols.py 现对 off-.pdata 方法零失败。

40. **★gate 幂等 bug 修复 + leaf-recovery 轮最终账目(2026-06-29)。** 加 v2 batch 后 gate 回归:
    no_orig 暴增 63、accepted 跌到 17。根因是我自己 gate 的幂等 bug —— cur_to_orig 用 dump 的
    **可变 name 字段**建,而上轮 apply 已把 90 个类改成语义名,agent 引用的老 obf_class 名查不到了。
    修复: 建 **obfclass_to_original.json**(经稳定的 method EA 反查 original_name,548 条,不受
    apply 影响),gate 改用它。重跑: no_orig=0,accepted 53→dedup 46。本轮新名(部分来自救回的
    leaf 方法): ColorTweenUIController、RenderParamsShadowConfigurator、StencilStateConfigurator、
    KeyEventModifierState、ByteBufferReader、TextureLoadRequest、NotificationAccessibilitySettings、
    FriendsManagerInitializer 等。**诚实账目(source_types dedup 口径): 4653→4668 = 本轮 +15
    distinct;两轮累计 4609→4668 = +59 distinct,56.1%→56.9%(+0.8pt)。** 反编译能力: off-.pdata
    3039 方法 0%→100%。P2 收尾。
