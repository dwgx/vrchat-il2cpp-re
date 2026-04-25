// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 64
// Methods: 405

public class Token : ValueType
{
    public object Type;
    public object IsNull; // 0x8
    public System.Collections.ICollection Boolean; // 0x10
    public System.ReadOnlyMemory`1<char> Number; // 0x10
    public string String; // 0x10
    public double StringInstance; // 0x18
    public bool Array; // 0x18
    public 0x6B0A9970 Object; // 0x20
    public 0x6B0A99C8 Value; // 0x21

    // ── Methods ──
    public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
    public void get_IsNull(){} // RVA: 0x7FFAC37C9990
    public void get_Boolean(){} // RVA: 0x7FFACBE13250
    public void get_Number(){} // RVA: 0x7FFACBE13320
    public void get_String(){} // RVA: 0x7FFACBE133F0
    public void get_StringInstance(){} // RVA: 0x7FFACBE13580
    public void get_Array(){} // RVA: 0x7FFACBE13680
    public void get_Object(){} // RVA: 0x7FFACBE13790
    public void get_Value(){} // RVA: 0x7FFACBE138A0
    public void .ctor(){} // RVA: 0x7FFACBE13C90 | overloaded x6
    public void op_Implicit(){} // RVA: 0x7FFACBE13F80 | overloaded x6
    public void op_Explicit(){} // RVA: 0x7FFACBE14200 | overloaded x6
    public void TryGetBool(){} // RVA: 0x7FFACBE14250
    public void TryGetNumber(){} // RVA: 0x7FFACBE142D0
    public void TryGetArray(){} // RVA: 0x7FFACBE14380
    public void TryGetObject(){} // RVA: 0x7FFACBE143E0
    public void TryGetString(){} // RVA: 0x7FFACBE14440
    public void TryGetStringInstance(){} // RVA: 0x7FFACBE14550
    public void TryFromObject(){} // RVA: 0x7FFAC2C5A350
    public void FromObject(){} // RVA: 0x7FFAC2C58980
    public void ToString(){} // RVA: 0x7FFACBE145B0
    public void GetHashCode(){} // RVA: 0x7FFACBE14760
    public void ToLegacyObject(){} // RVA: 0x7FFACBE14940
    public void GetInnerType(){} // RVA: 0x7FFACBE14B80
    public void CompareTo(){} // RVA: 0x7FFACBE14D50
    public void Equals(){} // RVA: 0x7FFACBE153A0 | overloaded x2
    public void op_Equality(){} // RVA: 0x7FFACBE15470
    public void op_Inequality(){} // RVA: 0x7FFACBE15500
    public void .cctor(){} // RVA: 0x7FFACBE15570
}

public class TokenHashValue : Object
{
    public string tokenString; // 0x10
    public 0x6B0BF550 tokenType; // 0x18
    public int tokenValue; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7DCAE30
}

public class TokenInfo : Info
{
    public int tokens; // 0x80
    public int amount; // 0x84
    public string imageUrl; // 0x88

    // ── Methods ──
    public void get_tokens(){} // RVA: 0x7FFAC35729C0
    public void set_tokens(){} // RVA: 0x7FFAC3572BF0
    public void get_amount(){} // RVA: 0x7FFAC46D5110
    public void set_amount(){} // RVA: 0x7FFAC46D5150
    public void get_imageUrl(){} // RVA: 0x7FFAC2F60010
    public void set_imageUrl(){} // RVA: 0x7FFAC354E300
    public void .ctor(){} // RVA: 0x7FFACBEF1220
}

public class TopLevelAssemblyTypeResolver : Object
{
    public System.Reflection.Assembly m_topLevelAssembly; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void ResolveType(){} // RVA: 0x7FFAC84C68C0
}

public class TouchScreenKeyboardEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97870D0
}

public class TrackAssetUpgrade : Object
{
}

public class TrackCacheManager : ValueType
{
    public System.Collections.Generic.HashSet`1<UnityEngine.Timeline.AnimationTrack> trackCache; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC97DC610
    public void Dispose(){} // RVA: 0x7FFAC97DC670
    public void GetTrackAssetsFromRuntimeElements(){} // RVA: 0x7FFAC97DC700
}

public class TrackProgress : Object
{
    public MidiTrack track; // 0x10
    public System.Collections.Generic.List`1<MidiBlock> activeBlocks; // 0x18
    public int currentBlockIndex; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBFFB960
}

public class TrackedCachingContexts : Object
{
    public int MaxTrackedContexts;
    public System.WeakReference`1<CachingContext>[] s_trackedContexts;
    public EqualityComparer s_optionsComparer; // 0x8

    // ── Methods ──
    public void GetOrCreate(){} // RVA: 0x7FFAC9044980
    public void TryGetContext(){} // RVA: 0x7FFAC9044D70
    public void .cctor(){} // RVA: 0x7FFAC9044F60
}

public class TrackedOptionsInstances : Object
{
    public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Text.Json.JsonSerializerOptions,object> All;

    // ── Methods ──
    public void get_All(){} // RVA: 0x7FFAC8AC3FD0
    public void .cctor(){} // RVA: 0x7FFAC8AC4030
}

public class TrackedPose : ValueType
{
    public UnityEngine.Vector3 Position; // 0x10
    public UnityEngine.Quaternion Rotation; // 0x1C
}

public class TrackingChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6058FB0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC8C793B0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class TrackingData : ValueType
{
    public UnityEngine.Vector3 position; // 0x10
    public UnityEngine.Quaternion rotation; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7206E60
}

public class TrackingReferenceObject : Object
{
    public 0x6B23FF78 trackedDeviceClass; // 0x10
    public UnityEngine.GameObject gameObject; // 0x18
    public Valve.VR.SteamVR_RenderModel renderModel; // 0x20
    public Valve.VR.SteamVR_TrackedObject trackedObject; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Trail : ValueType
{
    public float m_Timer; // 0x10
}

public class TrailModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC995B690
    public void set_enabled(){} // RVA: 0x7FFAC995B6E0
    public void get_mode(){} // RVA: 0x7FFAC995B740
    public void set_mode(){} // RVA: 0x7FFAC995B790
    public void get_ratio(){} // RVA: 0x7FFAC995B7F0
    public void set_ratio(){} // RVA: 0x7FFAC995B840
    public void get_lifetime(){} // RVA: 0x7FFAC995B8A0
    public void set_lifetime(){} // RVA: 0x7FFAC995B910
    public void get_lifetimeMultiplier(){} // RVA: 0x7FFAC995B970
    public void set_lifetimeMultiplier(){} // RVA: 0x7FFAC995B9C0
    public void get_minVertexDistance(){} // RVA: 0x7FFAC995BA20
    public void set_minVertexDistance(){} // RVA: 0x7FFAC995BA70
    public void get_textureMode(){} // RVA: 0x7FFAC995BAD0
    public void set_textureMode(){} // RVA: 0x7FFAC995BB20
    public void get_textureScale(){} // RVA: 0x7FFAC995BB80
    public void set_textureScale(){} // RVA: 0x7FFAC995BBE0
    public void get_worldSpace(){} // RVA: 0x7FFAC995BC40
    public void set_worldSpace(){} // RVA: 0x7FFAC995BC90
    public void get_dieWithParticles(){} // RVA: 0x7FFAC995BCF0
    public void set_dieWithParticles(){} // RVA: 0x7FFAC995BD40
    public void get_sizeAffectsWidth(){} // RVA: 0x7FFAC995BDA0
    public void set_sizeAffectsWidth(){} // RVA: 0x7FFAC995BDF0
    public void get_sizeAffectsLifetime(){} // RVA: 0x7FFAC995BE50
    public void set_sizeAffectsLifetime(){} // RVA: 0x7FFAC995BEA0
    public void get_inheritParticleColor(){} // RVA: 0x7FFAC995BF00
    public void set_inheritParticleColor(){} // RVA: 0x7FFAC995BF50
    public void get_colorOverLifetime(){} // RVA: 0x7FFAC995BFB0
    public void set_colorOverLifetime(){} // RVA: 0x7FFAC995C030
    public void get_widthOverTrail(){} // RVA: 0x7FFAC995C090
    public void set_widthOverTrail(){} // RVA: 0x7FFAC995C100
    public void get_widthOverTrailMultiplier(){} // RVA: 0x7FFAC995C160
    public void set_widthOverTrailMultiplier(){} // RVA: 0x7FFAC995C1B0
    public void get_colorOverTrail(){} // RVA: 0x7FFAC995C210
    public void set_colorOverTrail(){} // RVA: 0x7FFAC995C290
    public void get_generateLightingData(){} // RVA: 0x7FFAC995C2F0
    public void set_generateLightingData(){} // RVA: 0x7FFAC995C340
    public void get_ribbonCount(){} // RVA: 0x7FFAC995C3A0
    public void set_ribbonCount(){} // RVA: 0x7FFAC995C3F0
    public void get_shadowBias(){} // RVA: 0x7FFAC995C450
    public void set_shadowBias(){} // RVA: 0x7FFAC995C4A0
    public void get_splitSubEmitterRibbons(){} // RVA: 0x7FFAC995C500
    public void set_splitSubEmitterRibbons(){} // RVA: 0x7FFAC995C550
    public void get_attachRibbonsToTransform(){} // RVA: 0x7FFAC995C5B0
    public void set_attachRibbonsToTransform(){} // RVA: 0x7FFAC995C600
    public void get_enabled_Injected(){} // RVA: 0x7FFAC995B690
    public void set_enabled_Injected(){} // RVA: 0x7FFAC995B6E0
    public void get_mode_Injected(){} // RVA: 0x7FFAC995B740
    public void set_mode_Injected(){} // RVA: 0x7FFAC995B790
    public void get_ratio_Injected(){} // RVA: 0x7FFAC995B7F0
    public void set_ratio_Injected(){} // RVA: 0x7FFAC995B840
    public void get_lifetime_Injected(){} // RVA: 0x7FFAC995C660
    public void set_lifetime_Injected(){} // RVA: 0x7FFAC995C6C0
    public void get_lifetimeMultiplier_Injected(){} // RVA: 0x7FFAC995B970
    public void set_lifetimeMultiplier_Injected(){} // RVA: 0x7FFAC995B9C0
    public void get_minVertexDistance_Injected(){} // RVA: 0x7FFAC995BA20
    public void set_minVertexDistance_Injected(){} // RVA: 0x7FFAC995BA70
    public void get_textureMode_Injected(){} // RVA: 0x7FFAC995BAD0
    public void set_textureMode_Injected(){} // RVA: 0x7FFAC995BB20
    public void get_textureScale_Injected(){} // RVA: 0x7FFAC995C720
    public void set_textureScale_Injected(){} // RVA: 0x7FFAC995C780
    public void get_worldSpace_Injected(){} // RVA: 0x7FFAC995BC40
    public void set_worldSpace_Injected(){} // RVA: 0x7FFAC995BC90
    public void get_dieWithParticles_Injected(){} // RVA: 0x7FFAC995BCF0
    public void set_dieWithParticles_Injected(){} // RVA: 0x7FFAC995BD40
    public void get_sizeAffectsWidth_Injected(){} // RVA: 0x7FFAC995BDA0
    public void set_sizeAffectsWidth_Injected(){} // RVA: 0x7FFAC995BDF0
    public void get_sizeAffectsLifetime_Injected(){} // RVA: 0x7FFAC995BE50
    public void set_sizeAffectsLifetime_Injected(){} // RVA: 0x7FFAC995BEA0
    public void get_inheritParticleColor_Injected(){} // RVA: 0x7FFAC995BF00
    public void set_inheritParticleColor_Injected(){} // RVA: 0x7FFAC995BF50
    public void get_colorOverLifetime_Injected(){} // RVA: 0x7FFAC995C7E0
    public void set_colorOverLifetime_Injected(){} // RVA: 0x7FFAC995C840
    public void get_widthOverTrail_Injected(){} // RVA: 0x7FFAC995C8A0
    public void set_widthOverTrail_Injected(){} // RVA: 0x7FFAC995C900
    public void get_widthOverTrailMultiplier_Injected(){} // RVA: 0x7FFAC995C160
    public void set_widthOverTrailMultiplier_Injected(){} // RVA: 0x7FFAC995C1B0
    public void get_colorOverTrail_Injected(){} // RVA: 0x7FFAC995C960
    public void set_colorOverTrail_Injected(){} // RVA: 0x7FFAC995C9C0
    public void get_generateLightingData_Injected(){} // RVA: 0x7FFAC995C2F0
    public void set_generateLightingData_Injected(){} // RVA: 0x7FFAC995C340
    public void get_ribbonCount_Injected(){} // RVA: 0x7FFAC995C3A0
    public void set_ribbonCount_Injected(){} // RVA: 0x7FFAC995C3F0
    public void get_shadowBias_Injected(){} // RVA: 0x7FFAC995C450
    public void set_shadowBias_Injected(){} // RVA: 0x7FFAC995C4A0
    public void get_splitSubEmitterRibbons_Injected(){} // RVA: 0x7FFAC995C500
    public void set_splitSubEmitterRibbons_Injected(){} // RVA: 0x7FFAC995C550
    public void get_attachRibbonsToTransform_Injected(){} // RVA: 0x7FFAC995C5B0
    public void set_attachRibbonsToTransform_Injected(){} // RVA: 0x7FFAC995C600
}

public class Trails : ValueType
{
    public System.Collections.Generic.List`1<UnityEngine.Vector4> positions; // 0x10
    public System.Collections.Generic.List`1<int> frontPositions; // 0x18
    public System.Collections.Generic.List`1<int> backPositions; // 0x20
    public System.Collections.Generic.List`1<int> positionCounts; // 0x28
    public System.Collections.Generic.List`1<float> textureOffsets; // 0x30
    public int maxTrailCount; // 0x38
    public int maxPositionsPerTrailCount; // 0x3C

    // ── Methods ──
    public void Allocate(){} // RVA: 0x7FFAC9951E70
}

public class TransformData : ValueType
{
    public Unity.Mathematics.float3 lossyScale;
    public Unity.Mathematics.float4x4 localToWorld; // 0x10
    public Unity.Mathematics.float3 position; // 0x50
    public Unity.Mathematics.quaternion rotation; // 0x5C
    public Unity.Mathematics.float3 localPosition; // 0x6C
    public Unity.Mathematics.quaternion localRotation; // 0x78
    public Unity.Mathematics.float3 localScale; // 0x88
    public Unity.Mathematics.float3 prevLocalPosition; // 0x94
    public Unity.Mathematics.quaternion prevLocalRotation; // 0xA0

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E42E00
    public void UpdateFromUnityTransform(){} // RVA: 0x7FFAC9E432C0
    public void UpdateGlobalTransform(){} // RVA: 0x7FFAC9E43820
    public void UpdateUnityTransform(){} // RVA: 0x7FFAC9E43970
    public void get_lossyScale(){} // RVA: 0x7FFAC9E43A30
    public void .cctor(){} // RVA: 0x7FFAC9E43AF0
}

public class TransformJobData : ValueType
{
    public UIntPtr TransformAccessArray;
    public int IsReadOnly;
}

public class TransformNoiseParams : ValueType
{
    public NoiseParams X; // 0x10
    public NoiseParams Y; // 0x1C
    public NoiseParams Z; // 0x28

    // ── Methods ──
    public void GetValueAt(){} // RVA: 0x7FFAC484D530
}

public class TransformParallelForLoopStruct`1 : ValueType
{
    public SharedStatic`1<UIntPtr> jobReflectionData;

    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFAC2C709B0
    public void Execute(){} // RVA: 0x7FFAC2C79720
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class TransformState : ValueType
{
    public TransformState identity;
    public Unity.Mathematics.float3 position; // 0x10
    public Unity.Mathematics.quaternion rotation; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7206E60
    public void ToMatrix(){} // RVA: 0x7FFAC9E42BD0
    public void Lerp(){} // RVA: 0x7FFAC9E42C60
    public void .cctor(){} // RVA: 0x7FFAC9E42D40
}

public class TransformSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFACC07B060
    public void SetObjectData(){} // RVA: 0x7FFACC07B2D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class TransformToUnitySpaceJob : ValueType
{
    public Unity.Collections.NativeArray`1<UnityEngine.Vector3> Vertices; // 0x10
    public Unity.Collections.NativeArray`1<UnityEngine.Vector3> Normals; // 0x20
    public Unity.Collections.NativeArray`1<UnityEngine.Vector2> UV; // 0x30
    public Unity.Collections.NativeArray`1<UnityEngine.BoneWeight> BoneWeights; // 0x40
    public Unity.Collections.NativeArray`1<Vector3f> MeshVerticesPosition; // 0x50
    public Unity.Collections.NativeArray`1<Vector3f> MeshNormals; // 0x60
    public Unity.Collections.NativeArray`1<Vector2f> MeshUV; // 0x70
    public Unity.Collections.NativeArray`1<Vector4f> MeshBoneWeights; // 0x80
    public Unity.Collections.NativeArray`1<Vector4s> MeshBoneIndices; // 0x90

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC8945020
}

public class TransformTrianglesJob : ValueType
{
    public Unity.Collections.NativeArray`1<uint> Triangles; // 0x10
    public Unity.Collections.NativeArray`1<short> MeshIndices; // 0x20
    public int NumIndices; // 0x30

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC8945150
}

public class TransientBuildData : ValueType
{
    public System.Collections.Generic.List`1<UnityEngine.Timeline.TrackAsset> trackList; // 0x10
    public System.Collections.Generic.List`1<UnityEngine.Timeline.TimelineClip> clipList; // 0x18
    public System.Collections.Generic.List`1<UnityEngine.Timeline.IMarker> markerList; // 0x20

    // ── Methods ──
    public void Create(){} // RVA: 0x7FFAC97C5D10
    public void Clear(){} // RVA: 0x7FFAC97C6060
}

public class TransitionEventsFrameState : Object
{
    public UnityEngine.Pool.ObjectPool`1<System.Collections.Generic.Queue`1<UnityEngine.UIElements.EventBase>> k_EventQueuePool;
    public System.Collections.Generic.Dictionary`2<ElementPropertyPair,0x6B122D38> elementPropertyStateDelta;
    public System.Collections.Generic.Dictionary`2<ElementPropertyPair,System.Collections.Generic.Queue`1<UnityEngine.UIElements.EventBase>> elementPropertyQueuedEvents;
    public UnityEngine.UIElements.IPanel panel;
    public int m_ChangesCount;

    // ── Methods ──
    public void GetPooledQueue(){} // RVA: 0x7FFAC2C58A90
    public void RegisterChange(){} // RVA: 0x7FFAC2C70980
    public void UnregisterChange(){} // RVA: 0x7FFAC2C70980
    public void StateChanged(){} // RVA: 0x7FFAC2C59D00
    public void Clear(){} // RVA: 0x7FFAC2C70980
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class TransitionParams : ValueType
{
    public 0x6B22AE40 m_BlendHint; // 0x10
    public bool m_InheritPosition; // 0x14
    public VcamActivatedEvent m_OnCameraLive; // 0x18
}

public class TransitionTime : ValueType
{
    public System.DateTime TimeOfDay; // 0x10
    public byte Month; // 0x18
    public byte Week; // 0x19
    public byte Day; // 0x1A
    public 0x6B0BEB00 DayOfWeek; // 0x1C
    public bool IsFixedDateRule; // 0x20

    // ── Methods ──
    public void get_TimeOfDay(){} // RVA: 0x7FFAC3AD9F60
    public void get_Month(){} // RVA: 0x7FFAC3AD0210
    public void get_Week(){} // RVA: 0x7FFAC3AD01E0
    public void get_Day(){} // RVA: 0x7FFAC8507500
    public void get_DayOfWeek(){} // RVA: 0x7FFAC49C7520
    public void get_IsFixedDateRule(){} // RVA: 0x7FFAC2FEB5E0
    public void Equals(){} // RVA: 0x7FFAC85075E0 | overloaded x2
    public void op_Inequality(){} // RVA: 0x7FFAC85075B0
    public void GetHashCode(){} // RVA: 0x7FFAC85076E0
    public void .ctor(){} // RVA: 0x7FFAC8507EC0 | overloaded x2
    public void CreateFixedDateRule(){} // RVA: 0x7FFAC8507780
    public void CreateFloatingDateRule(){} // RVA: 0x7FFAC8507800
    public void ValidateTransitionTime(){} // RVA: 0x7FFAC8507890
    public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC8507C80
    public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC8507D20
}

public class TreePage : Object
{
    public Node<T>[] InUseCount;
    public int[] PageId;
    public int _inUseCount;
    public int _pageId;
    public int _nextFreeSlotLine;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void AllocSlot(){} // RVA: 0x7FFAC2C5E6B0
    public void get_InUseCount(){} // RVA: 0x7FFAC2C59960
    public void set_InUseCount(){} // RVA: 0x7FFAC2C70ED0
    public void get_PageId(){} // RVA: 0x7FFAC2C59960
    public void set_PageId(){} // RVA: 0x7FFAC2C70ED0
}

public class TriangleDataShaderIds : Object
{
    public int _TriangleBuffer;
    public int _TrianglesDispatchIndirectArgs; // 0x4
    public int _TrianglesCount; // 0x8
    public int _TrianglesDrawIndirectArgs; // 0xC

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC4957690
}

public class TriggerEndOfFrameCallbacks : ValueType
{
}

public class TriggerEvent : UnityEvent
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4854470
}

public class TriggerModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC994E6A0
    public void set_enabled(){} // RVA: 0x7FFAC994E6F0
    public void get_inside(){} // RVA: 0x7FFAC994E750
    public void set_inside(){} // RVA: 0x7FFAC994E7A0
    public void get_outside(){} // RVA: 0x7FFAC994E800
    public void set_outside(){} // RVA: 0x7FFAC994E850
    public void get_enter(){} // RVA: 0x7FFAC994E8B0
    public void set_enter(){} // RVA: 0x7FFAC994E900
    public void get_exit(){} // RVA: 0x7FFAC994E960
    public void set_exit(){} // RVA: 0x7FFAC994E9B0
    public void get_colliderQueryMode(){} // RVA: 0x7FFAC994EA10
    public void set_colliderQueryMode(){} // RVA: 0x7FFAC994EA60
    public void get_radiusScale(){} // RVA: 0x7FFAC994EAC0
    public void set_radiusScale(){} // RVA: 0x7FFAC994EB10
    public void AddCollider(){} // RVA: 0x7FFAC994EB70
    public void RemoveCollider(){} // RVA: 0x7FFAC994EC30 | overloaded x2
    public void RemoveColliderObject(){} // RVA: 0x7FFAC994EC30
    public void SetCollider(){} // RVA: 0x7FFAC994EC90
    public void GetCollider(){} // RVA: 0x7FFAC994ED00
    public void get_colliderCount(){} // RVA: 0x7FFAC994ED60
    public void get_enabled_Injected(){} // RVA: 0x7FFAC994E6A0
    public void set_enabled_Injected(){} // RVA: 0x7FFAC994E6F0
    public void get_inside_Injected(){} // RVA: 0x7FFAC994E750
    public void set_inside_Injected(){} // RVA: 0x7FFAC994E7A0
    public void get_outside_Injected(){} // RVA: 0x7FFAC994E800
    public void set_outside_Injected(){} // RVA: 0x7FFAC994E850
    public void get_enter_Injected(){} // RVA: 0x7FFAC994E8B0
    public void set_enter_Injected(){} // RVA: 0x7FFAC994E900
    public void get_exit_Injected(){} // RVA: 0x7FFAC994E960
    public void set_exit_Injected(){} // RVA: 0x7FFAC994E9B0
    public void get_colliderQueryMode_Injected(){} // RVA: 0x7FFAC994EA10
    public void set_colliderQueryMode_Injected(){} // RVA: 0x7FFAC994EA60
    public void get_radiusScale_Injected(){} // RVA: 0x7FFAC994EAC0
    public void set_radiusScale_Injected(){} // RVA: 0x7FFAC994EB10
    public void AddCollider_Injected(){} // RVA: 0x7FFAC994EB70
    public void RemoveCollider_Injected(){} // RVA: 0x7FFAC994EBD0
    public void RemoveColliderObject_Injected(){} // RVA: 0x7FFAC994EC30
    public void SetCollider_Injected(){} // RVA: 0x7FFAC994EC90
    public void GetCollider_Injected(){} // RVA: 0x7FFAC994ED00
    public void get_colliderCount_Injected(){} // RVA: 0x7FFAC994ED60
}

public class TriggerState : ValueType
{
    public int phase;
    public int isDisabled;
    public int isWaiting;
    public byte isStarted; // 0x10
    public byte isPerformed; // 0x11
    public byte isCanceled; // 0x12
    public ushort time; // 0x14
    public double startTime; // 0x18
    public double magnitude; // 0x20
    public ushort haveMagnitude; // 0x28
    public ushort mapIndex; // 0x2A
    public float controlIndex; // 0x2C
    public uint bindingIndex; // 0x30
    public uint interactionIndex; // 0x34
    public uint lastPerformedInUpdate; // 0x38
    public uint lastCompletedInUpdate; // 0x3C
    public uint lastCanceledInUpdate; // 0x40
    public int pressedInUpdate; // 0x44
    public int releasedInUpdate; // 0x48
    public int isPassThrough; // 0x4C
    public int isButton; // 0x50

    // ── Methods ──
    public void get_phase(){} // RVA: 0x7FFAC495DDF0
    public void set_phase(){} // RVA: 0x7FFAC495DE00
    public void get_isDisabled(){} // RVA: 0x7FFAC5F4D7E0
    public void get_isWaiting(){} // RVA: 0x7FFAC8F0CA70
    public void get_isStarted(){} // RVA: 0x7FFAC8F0CA60
    public void get_isPerformed(){} // RVA: 0x7FFAC954CBF0
    public void get_isCanceled(){} // RVA: 0x7FFAC954CC00
    public void get_time(){} // RVA: 0x7FFAC47D1AE0
    public void set_time(){} // RVA: 0x7FFAC4AB3ED0
    public void get_startTime(){} // RVA: 0x7FFAC5873C20
    public void set_startTime(){} // RVA: 0x7FFAC69C0110
    public void get_magnitude(){} // RVA: 0x7FFAC2FEE570
    public void set_magnitude(){} // RVA: 0x7FFAC954CC10
    public void get_haveMagnitude(){} // RVA: 0x7FFAC954CC20
    public void get_mapIndex(){} // RVA: 0x7FFAC495DE20
    public void set_mapIndex(){} // RVA: 0x7FFAC954CC30
    public void get_controlIndex(){} // RVA: 0x7FFAC954CCA0
    public void set_controlIndex(){} // RVA: 0x7FFAC954CCC0
    public void get_bindingIndex(){} // RVA: 0x7FFAC5F39D20
    public void set_bindingIndex(){} // RVA: 0x7FFAC954CD40
    public void get_interactionIndex(){} // RVA: 0x7FFAC954CDB0
    public void set_interactionIndex(){} // RVA: 0x7FFAC954CDD0
    public void get_lastPerformedInUpdate(){} // RVA: 0x7FFAC30DBBE0
    public void set_lastPerformedInUpdate(){} // RVA: 0x7FFAC35DB7A0
    public void get_lastCompletedInUpdate(){} // RVA: 0x7FFAC2F7CCD0
    public void set_lastCompletedInUpdate(){} // RVA: 0x7FFAC2F7CCE0
    public void get_lastCanceledInUpdate(){} // RVA: 0x7FFAC3921980
    public void set_lastCanceledInUpdate(){} // RVA: 0x7FFAC41674D0
    public void get_pressedInUpdate(){} // RVA: 0x7FFAC32EC4C0
    public void set_pressedInUpdate(){} // RVA: 0x7FFAC369A6E0
    public void get_releasedInUpdate(){} // RVA: 0x7FFAC3C891D0
    public void set_releasedInUpdate(){} // RVA: 0x7FFAC45B6490
    public void get_isPassThrough(){} // RVA: 0x7FFAC954CE50
    public void set_isPassThrough(){} // RVA: 0x7FFAC954CE60
    public void get_isButton(){} // RVA: 0x7FFAC954CE90
    public void set_isButton(){} // RVA: 0x7FFAC954CEA0
    public void get_isPressed(){} // RVA: 0x7FFAC954CED0
    public void set_isPressed(){} // RVA: 0x7FFAC954CEE0
    public void get_mayNeedConflictResolution(){} // RVA: 0x7FFAC954CF10
    public void set_mayNeedConflictResolution(){} // RVA: 0x7FFAC954CF20
    public void get_hasMultipleConcurrentActuations(){} // RVA: 0x7FFAC954CF50
    public void set_hasMultipleConcurrentActuations(){} // RVA: 0x7FFAC954CF60
    public void get_inProcessing(){} // RVA: 0x7FFAC954CF90
    public void set_inProcessing(){} // RVA: 0x7FFAC954CFA0
    public void get_flags(){} // RVA: 0x7FFAC495DE10
    public void set_flags(){} // RVA: 0x7FFAC3B9B9B0
}

public class TrigonometricBone : Bone
{
    public UnityEngine.Quaternion targetToLocalSpace; // 0x80
    public UnityEngine.Vector3 defaultLocalBendNormal; // 0x90

    // ── Methods ──
    public void Initiate(){} // RVA: 0x7FFAC3035BF0
    public void GetRotation(){} // RVA: 0x7FFAC3036060
    public void GetBendNormalFromCurrentRotation(){} // RVA: 0x7FFAC3036280
    public void .ctor(){} // RVA: 0x7FFAC3030DA0
}

public class TryCode : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class TryExpressionProxy : Object
{
    public System.Linq.Expressions.TryExpression Body; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D72620
    public void get_Body(){} // RVA: 0x7FFAC356B610
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Fault(){} // RVA: 0x7FFAC3510100
    public void get_Finally(){} // RVA: 0x7FFAC3773190
    public void get_Handlers(){} // RVA: 0x7FFAC37735E0
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class TryFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class Try_000000AB$BurstDirectCall : Object
{
    public UIntPtr Pointer;
    public UIntPtr DeferredCompilation; // 0x8

    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC950F5E0
    public void GetFunctionPointer(){} // RVA: 0x7FFAC950F720
    public void Constructor(){} // RVA: 0x7FFAC950F890
    public void Initialize(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC950F890
    public void Invoke(){} // RVA: 0x7FFAC950F950
}

public class Try_000000AB$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class Try_000000B9$BurstDirectCall : Object
{
    public UIntPtr Pointer;
    public UIntPtr DeferredCompilation; // 0x8

    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7FFAC950FE00
    public void GetFunctionPointer(){} // RVA: 0x7FFAC950FF40
    public void Constructor(){} // RVA: 0x7FFAC95100B0
    public void Initialize(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC95100B0
    public void Invoke(){} // RVA: 0x7FFAC9510170
}

public class Try_000000B9$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC7F5FAB0
    public void Invoke(){} // RVA: 0x7FFAC307D370
}

public class TypeBinaryExpressionProxy : Object
{
    public System.Linq.Expressions.TypeBinaryExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D72700
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Expression(){} // RVA: 0x7FFAC356B610
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
    public void get_TypeOperand(){} // RVA: 0x7FFAC37735E0
}

public class TypeCollections : Object
{
    public 0x6B250880[] KeyTypes;
    public 0x6B250880[] TimerTypes; // 0x8
    public 0x6B250880[] InteractiveTypes; // 0x10
    public 0x6B250880[] ColliderTypes; // 0x18
    public 0x6B250880[] TriggerTypes; // 0x20
    public 0x6B250880[] PickupTypes; // 0x28
    public 0x6B250880[] DataStorageTypes; // 0x30

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFACC06B280
}

public class TypeConstructorVisitor : Object
{
    public ITypeConstructor TypeConstructor; // 0x10

    // ── Methods ──
    public void Visit(){} // RVA: 0x7FFAC2C70980
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class TypeConstructor`1 : Object
{
    public System.Func`1<T> Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated;
    public System.Func`1<T> m_ImplicitConstructor;
    public Unity.Properties.IConstructor`1<T> m_OverrideConstructor;

    // ── Methods ──
    public void Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated(){} // RVA: 0x7FFAC2C59D00
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void SetImplicitConstructor(){} // RVA: 0x7FFAC2C70980
    public void CreateValueTypeInstance(){} // RVA: 0x7FFAC2E8DC40
    public void CreateScriptableObjectInstance(){} // RVA: 0x7FFAC2E8DC40
    public void CreateClassInstance(){} // RVA: 0x7FFAC2E8DC40
    public void SetExplicitConstructor(){} // RVA: 0x7FFAC2C70A40
    public void Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate(){} // RVA: 0x7FFAC2E8DC40
    public void Unity.Properties.TypeUtility.ITypeConstructor.Instantiate(){} // RVA: 0x7FFAC2C58E90
}

public class TypeConvertKey : ValueType
{
    public System.Type InitialType; // 0x10
    public System.Type TargetType; // 0x18

    // ── Methods ──
    public void get_InitialType(){} // RVA: 0x7FFAC3AD9F60
    public void get_TargetType(){} // RVA: 0x7FFAC4420220
    public void .ctor(){} // RVA: 0x7FFAC41AE4B0
    public void GetHashCode(){} // RVA: 0x7FFAC90936F0
    public void Equals(){} // RVA: 0x7FFAC485CA30 | overloaded x2
}

public class TypeData : Object
{
    public System.Type type; // 0x10
    public string fullTypeName; // 0x18
    public string typeName; // 0x20
    public string typeNamespace; // 0x28

    // ── Methods ──
    public void get_type(){} // RVA: 0x7FFAC2F3C380
    public void .ctor(){} // RVA: 0x7FFAC9BF5280
    public void get_fullTypeName(){} // RVA: 0x7FFAC9BF5440
    public void get_typeName(){} // RVA: 0x7FFAC9BF54E0
    public void get_typeNamespace(){} // RVA: 0x7FFAC9BF55F0
}

public class TypeDescriptionNode : TypeDescriptionProvider
{
    public TypeDescriptionNode Next; // 0x20
    public System.ComponentModel.TypeDescriptionProvider Provider; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E90
    public void CreateInstance(){} // RVA: 0x7FFAC9443A40
    public void GetCache(){} // RVA: 0x7FFAC9443C00
    public void GetExtendedTypeDescriptor(){} // RVA: 0x7FFAC9443C90
    public void GetExtenderProviders(){} // RVA: 0x7FFAC9443D60
    public void GetFullComponentName(){} // RVA: 0x7FFAC9443DF0
    public void GetReflectionType(){} // RVA: 0x7FFAC9443E80
    public void GetRuntimeType(){} // RVA: 0x7FFAC9443F60
    public void GetTypeDescriptor(){} // RVA: 0x7FFAC9444030
    public void IsSupportedType(){} // RVA: 0x7FFAC94441B0
}

public class TypeDescriptorComObject : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class TypeDescriptorInterface : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class TypeHandler : ValueType
{
    public _Size Size; // 0x10
    public _Put32Bit Put32; // 0x18
    public _Put8Bit Put8; // 0x20
    public _Get32Bit Get32; // 0x28
    public _Get8Bit Get8; // 0x30
}

public class TypeInfo : Object
{
    public System.Collections.Hashtable Attributes; // 0x10
    public System.Collections.Hashtable Elements; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class TypeNAssembly : Object
{
    public System.Type type; // 0x10
    public string assemblyName; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class TypeNameKey : ValueType
{
    public string AssemblyName; // 0x10
    public string TypeName; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC41AE4B0
    public void GetHashCode(){} // RVA: 0x7FFAC9CE3590
    public void Equals(){} // RVA: 0x7FFAC9CE36A0 | overloaded x2
}

public class TypeRestriction : BindingRestrictions
{
    public System.Linq.Expressions.Expression _expression; // 0x10
    public System.Type _type; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8DF71A0
    public void Equals(){} // RVA: 0x7FFAC8DF72B0
    public void GetHashCode(){} // RVA: 0x7FFAC8DF73B0
    public void GetExpression(){} // RVA: 0x7FFAC8DF7410
}

public class TypeSchema : Object
{
    public System.Type Type; // 0x10
    public Newtonsoft.Json.Schema.JsonSchema Schema; // 0x18

    // ── Methods ──
    public void get_Type(){} // RVA: 0x7FFAC2F3C380
    public void get_Schema(){} // RVA: 0x7FFAC2F247C0
    public void .ctor(){} // RVA: 0x7FFAC87B57F0
}

public class TypedRestore : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFAC2C70A40
    public void BeginInvoke(){} // RVA: 0x7FFAC2C6AE80
    public void EndInvoke(){} // RVA: 0x7FFAC2C79B30
}

public class TypedStore`1 : ValueType
{
    public Unity.Properties.IPropertyBag`1<T> PropertyBag;
}

public class Types : Object
{
}

public class tBigInt : ValueType
{
    public int m_length; // 0x10
    public <m_blocks>e__FixedBuffer m_blocks; // 0x14

    // ── Methods ──
    public void GetLength(){} // RVA: 0x7FFAC4420210
    public void GetBlock(){} // RVA: 0x7FFAC950CAB0
    public void IsZero(){} // RVA: 0x7FFAC8A78820
    public void SetU64(){} // RVA: 0x7FFAC950CAC0
    public void SetU32(){} // RVA: 0x7FFAC950CAF0
}

public class tFloatUnion32 : ValueType
{
    public float m_floatingPoint; // 0x10
    public uint m_integer; // 0x10

    // ── Methods ──
    public void IsNegative(){} // RVA: 0x7FFAC865D220
    public void GetExponent(){} // RVA: 0x7FFAC950CB10
    public void GetMantissa(){} // RVA: 0x7FFAC950CB20
}

public class tFloatUnion64 : ValueType
{
    public double m_floatingPoint; // 0x10
    public ulong m_integer; // 0x10

    // ── Methods ──
    public void IsNegative(){} // RVA: 0x7FFAC950CB30
    public void GetExponent(){} // RVA: 0x7FFAC950CB50
    public void GetMantissa(){} // RVA: 0x7FFAC950CB60
}
