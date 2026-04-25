// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 428

public class Label : ValueType
{
    public string name; // 0x10
    public UnityEngine.Texture2D icon; // 0x18
}

public class LabelExpressionProxy : Object
{
    public System.Linq.Expressions.LabelExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71A50
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_DefaultValue(){} // RVA: 0x7FFAC356B610
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Target(){} // RVA: 0x7FFAC3511350
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class LambdaExpressionProxy : Object
{
    public System.Linq.Expressions.LambdaExpression Body; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71B30
    public void get_Body(){} // RVA: 0x7FFAC3511350
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Name(){} // RVA: 0x7FFAC8D711F0
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Parameters(){} // RVA: 0x7FFAC84AA3A0
    public void get_ReturnType(){} // RVA: 0x7FFAC8D71C10
    public void get_TailCall(){} // RVA: 0x7FFAC8D71270
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class LambdaSignature`1 : Object
{
    public LambdaSignature`1<T> Instance;
    public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression> Parameters;
    public System.Linq.Expressions.LabelTarget ReturnLabel;

    // ── Methods ──
    public void get_Instance(){} // RVA: 0x7FFAC2C58A90
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class LastActiveSpanTracker : Object
{
    public object TrackedSpans; // 0x10
    public System.Lazy`1<System.Collections.Generic.Stack`1<Sentry.ISpan>> _trackedSpans; // 0x18

    // ── Methods ──
    public void get_TrackedSpans(){} // RVA: 0x7FFAC8B627C0
    public void Push(){} // RVA: 0x7FFAC8B62810
    public void PeekActive(){} // RVA: 0x7FFAC8B629D0
    public void Clear(){} // RVA: 0x7FFAC8B62CA0
    public void .ctor(){} // RVA: 0x7FFAC8B62E60
}

public class LatencyData : ValueType
{
    public float render; // 0x10
    public float timeWarp; // 0x14
    public float postPresent; // 0x18
    public float renderError; // 0x1C
    public float timeWarpError; // 0x20
}

public class LaterInitParam : Object
{
    public bool useAsync; // 0x10
    public System.IO.Stream inputStream; // 0x18
    public byte[] inputBytes; // 0x20
    public int inputByteCount; // 0x28
    public System.Uri inputbaseUri; // 0x30
    public string inputUriStr; // 0x38
    public System.Xml.XmlResolver inputUriResolver; // 0x40
    public System.Xml.XmlParserContext inputContext; // 0x48
    public System.IO.TextReader inputTextReader; // 0x50
    public 0x6B15A8E8 initType; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC91BE410
}

public class Layer : Object
{
    public float Weight; // 0x10
    public int Hash; // 0x14
    public float NormalizedTime; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class LayerDesc : ValueType
{
    public 0x6B1A62E8 Shape; // 0x10
    public 0x6B1A7418 Layout; // 0x14
    public Sizei TextureSize; // 0x18
    public int MipLevels; // 0x20
    public int SampleCount; // 0x24
    public 0x6B1A6188 Format; // 0x28
    public int LayerFlags; // 0x2C
    public Fovf[] Fov; // 0x30
    public Rectf[] VisibleRect; // 0x38
    public Sizei MaxViewportSize; // 0x40
    public 0x6B1A6188 DepthFormat; // 0x48
    public 0x6B1A6188 MotionVectorFormat; // 0x4C
    public 0x6B1A6188 MotionVectorDepthFormat; // 0x50
    public Sizei MotionVectorTextureSize; // 0x54

    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFAC8908200
}

public class LayerDescInternal : ValueType
{
    public 0x6B1A62E8 Shape; // 0x10
    public 0x6B1A7418 Layout; // 0x14
    public Sizei TextureSize; // 0x18
    public int MipLevels; // 0x20
    public int SampleCount; // 0x24
    public 0x6B1A6188 Format; // 0x28
    public int LayerFlags; // 0x2C
    public Fovf Fov0; // 0x30
    public Fovf Fov1; // 0x40
    public Rectf VisibleRect0; // 0x50
    public Rectf VisibleRect1; // 0x60
    public Sizei MaxViewportSize; // 0x70
    public 0x6B1A6188 DepthFormat; // 0x78
    public 0x6B1A6188 MotionVectorFormat; // 0x7C
    public 0x6B1A6188 MotionVectorDepthFormat; // 0x80
    public Sizei MotionVectorTextureSize; // 0x84

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8908470
    public void ToLayerDesc(){} // RVA: 0x7FFAC8908530
}

public class LayerSubmit : ValueType
{
    public int LayerId; // 0x10
    public int TextureStage; // 0x14
    public Recti[] ViewportRect; // 0x18
    public Posef Pose; // 0x20
    public int LayerSubmitFlags; // 0x3C
}

public class LayerTexture : ValueType
{
    public UnityEngine.Texture appTexture; // 0x10
    public UIntPtr appTexturePtr; // 0x18
    public UnityEngine.Texture[] swapChain; // 0x20
    public UIntPtr[] swapChainPtr; // 0x28
}

public class LayoutCache : Object
{
    public int id; // 0x10
    public UnityEngine.GUILayoutGroup topLevel; // 0x18
    public UnityEngineInternal.GenericStack layoutGroups; // 0x20
    public UnityEngine.GUILayoutGroup windows; // 0x28

    // ── Methods ──
    public void set_id(){} // RVA: 0x7FFAC2F240C0
    public void .ctor(){} // RVA: 0x7FFAC991ECA0
    public void ResetCursor(){} // RVA: 0x7FFAC991EE90
}

public class LayoutJson : ValueType
{
    public string name; // 0x10
    public string extend; // 0x18
    public string[] extendMultiple; // 0x20
    public string format; // 0x28
    public string beforeRender; // 0x30
    public string runInBackground; // 0x38
    public string[] commonUsages; // 0x40
    public string displayName; // 0x48
    public string description; // 0x50
    public string type; // 0x58
    public string variant; // 0x60
    public bool isGenericTypeOfDevice; // 0x68
    public bool hideInUI; // 0x69
    public ControlItemJson[] controls; // 0x70

    // ── Methods ──
    public void ToLayout(){} // RVA: 0x7FFAC96919A0
    public void FromLayout(){} // RVA: 0x7FFAC9692670
}

public class LayoutJsonNameAndDescriptorOnly : ValueType
{
    public string name; // 0x10
    public string extend; // 0x18
    public string[] extendMultiple; // 0x20
    public MatcherJson device; // 0x28
}

public class LayoutMatcher : ValueType
{
    public UnityEngine.InputSystem.Utilities.InternedString layoutName; // 0x10
    public UnityEngine.InputSystem.Layouts.InputDeviceMatcher deviceMatcher; // 0x20
}

public class LayoutNotFoundException : Exception
{
    public string layout; // 0x90

    // ── Methods ──
    public void get_layout(){} // RVA: 0x7FFAC32EF640
    public void .ctor(){} // RVA: 0x7FFAC954FDA0 | overloaded x5
}

public class LayoutedWindow : Object
{
    public WindowFunction m_Func; // 0x10
    public UnityEngine.Rect m_ScreenRect; // 0x18
    public UnityEngine.GUILayoutOption[] m_Options; // 0x28
    public UnityEngine.GUIStyle m_Style; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC991AAF0
    public void DoWindow(){} // RVA: 0x7FFAC991AC00
}

public class LazyCAttrData : Object
{
    public System.Reflection.Assembly assembly; // 0x10
    public UIntPtr data; // 0x18
    public uint data_length; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class LeftShiftByte : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DBEFD0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class LeftShiftInt16 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DBEBF0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class LeftShiftInt32 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DBED20
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class LeftShiftInt64 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DBEE30
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class LeftShiftSByte : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DBEAC0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class LeftShiftUInt16 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DBF100
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class LeftShiftUInt32 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DBF230
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class LeftShiftUInt64 : LeftShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DBF3D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Leg : BodyPart
{
    public UnityEngine.Transform position; // 0x48
    public UnityEngine.Transform rotation; // 0x50
    public float hasToes; // 0x58
    public float thigh; // 0x5C
    public float calf; // 0x60
    public float foot; // 0x64
    public float toes; // 0x68
    public float lastBone; // 0x6C
    public UnityEngine.AnimationCurve thighRelativeToPelvis; // 0x70
    public UnityEngine.Vector3 IKPosition; // 0x78
    public UnityEngine.Quaternion IKRotation; // 0x84
    public UnityEngine.Vector3 footPositionOffset; // 0x94
    public UnityEngine.Vector3 heelPositionOffset; // 0xA0
    public UnityEngine.Quaternion footRotationOffset; // 0xAC
    public float currentMag; // 0xBC
    public bool useAnimatedBendNormal; // 0xC0
    public UnityEngine.Vector3 <position>k__BackingField; // 0xC4
    public UnityEngine.Quaternion <rotation>k__BackingField; // 0xD0
    public bool <hasToes>k__BackingField; // 0xE0
    public bool VrcAllowToes; // 0xE1
    public UnityEngine.Vector3 <thighRelativeToPelvis>k__BackingField; // 0xE4
    public bool vrcUseKneeTarget; // 0xF0
    public bool vrcUseForcedBendNormal; // 0xF1
    public UnityEngine.Vector3 vrcForcedBendNormal; // 0xF4
    public UnityEngine.Vector3 footPosition; // 0x100
    public UnityEngine.Quaternion footRotation; // 0x10C
    public UnityEngine.Vector3 bendNormal; // 0x11C
    public UnityEngine.Quaternion calfRelToThigh; // 0x128
    public UnityEngine.Quaternion thighRelToFoot; // 0x138
    public UnityEngine.Vector3 bendNormalRelToPelvis; // 0x148
    public UnityEngine.Vector3 bendNormalRelToTarget; // 0x154
    public UnityEngine.Vector3 vrcBendNormalRelToFoot; // 0x160
    public UnityEngine.Quaternion vrcLegTwistFromBendDir; // 0x16C

    // ── Methods ──
    public void get_position(){} // RVA: 0x7FFAC304CF20
    public void set_position(){} // RVA: 0x7FFAC304CF40
    public void get_rotation(){} // RVA: 0x7FFAC304CF60
    public void set_rotation(){} // RVA: 0x7FFAC304CF70
    public void get_hasToes(){} // RVA: 0x7FFAC304CF80
    public void set_hasToes(){} // RVA: 0x7FFAC304CF90
    public void get_thigh(){} // RVA: 0x7FFAC303F5F0
    public void get_calf(){} // RVA: 0x7FFAC304CFA0
    public void get_foot(){} // RVA: 0x7FFAC304CFD0
    public void get_toes(){} // RVA: 0x7FFAC304D000
    public void get_lastBone(){} // RVA: 0x7FFAC304D030
    public void get_thighRelativeToPelvis(){} // RVA: 0x7FFAC2F8C260
    public void set_thighRelativeToPelvis(){} // RVA: 0x7FFAC2F8C280
    public void OnRead(){} // RVA: 0x7FFAC304D070
    public void PreSolve(){} // RVA: 0x7FFAC304DE10
    public void ApplyOffsets(){} // RVA: 0x7FFAC304EBD0
    public void ApplyPositionOffset(){} // RVA: 0x7FFAC304FA40
    public void ApplyRotationOffset(){} // RVA: 0x7FFAC304FAF0
    public void Solve(){} // RVA: 0x7FFAC3050180
    public void VrcFindKneeTargetBend(){} // RVA: 0x7FFAC3050470
    public void FixTwistRotations(){} // RVA: 0x7FFAC30506E0
    public void Stretching(){} // RVA: 0x7FFAC3051210
    public void Write(){} // RVA: 0x7FFAC3051880
    public void ResetOffsets(){} // RVA: 0x7FFAC3051B40
    public void .ctor(){} // RVA: 0x7FFAC3051C20
}

public class LegacyAnimationUpdate : ValueType
{
}

public class LegacyFixedAnimationUpdate : ValueType
{
}

public class LegacySignalSource : Object
{
    public Cinemachine.CinemachineImpulseDefinition SignalDuration; // 0x10
    public UnityEngine.Vector3 m_Velocity; // 0x18
    public float m_StartTimeOffset; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4857B20
    public void get_SignalDuration(){} // RVA: 0x7FFAC4857BE0
    public void GetSignal(){} // RVA: 0x7FFAC4857C20
}

public class LessThanByte : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC0A70
}

public class LessThanChar : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC0650
}

public class LessThanDouble : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC1150
}

public class LessThanInt16 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC04F0
}

public class LessThanInt32 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC07B0
}

public class LessThanInt64 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC0910
}

public class LessThanOrEqualByte : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC27B0
}

public class LessThanOrEqualChar : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC2390
}

public class LessThanOrEqualDouble : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC2E90
}

public class LessThanOrEqualInt16 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC2230
}

public class LessThanOrEqualInt32 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC24F0
}

public class LessThanOrEqualInt64 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC2650
}

public class LessThanOrEqualSByte : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC20D0
}

public class LessThanOrEqualSingle : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC2D30
}

public class LessThanOrEqualUInt16 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC2910
}

public class LessThanOrEqualUInt32 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC2A70
}

public class LessThanOrEqualUInt64 : LessThanOrEqualInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC2BD0
}

public class LessThanSByte : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC0390
}

public class LessThanSingle : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC0FF0
}

public class LessThanUInt16 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC0BD0
}

public class LessThanUInt32 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC0D30
}

public class LessThanUInt64 : LessThanInstruction
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void Run(){} // RVA: 0x7FFAC8DC0E90
}

public class Level : ValueType
{
    public int down; // 0x10
    public int up; // 0x14
}

public class LicFileLicense : License
{
    public System.ComponentModel.LicFileLicenseProvider LicenseKey; // 0x10
    public string <LicenseKey>k__BackingField; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void get_LicenseKey(){} // RVA: 0x7FFAC2F247C0
    public void Dispose(){} // RVA: 0x7FFAC93FF5E0
}

public class LifetimeByEmitterSpeedModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
}

public class Lights : ValueType
{
    public Seed m_Random; // 0x10
    public float m_ParticleEmissionCounter; // 0x20
}

public class LightsModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC995AC90
    public void set_enabled(){} // RVA: 0x7FFAC995ACE0
    public void get_ratio(){} // RVA: 0x7FFAC995AD40
    public void set_ratio(){} // RVA: 0x7FFAC995AD90
    public void get_useRandomDistribution(){} // RVA: 0x7FFAC995ADF0
    public void set_useRandomDistribution(){} // RVA: 0x7FFAC995AE40
    public void get_light(){} // RVA: 0x7FFAC995AEA0
    public void set_light(){} // RVA: 0x7FFAC995AEF0
    public void get_useParticleColor(){} // RVA: 0x7FFAC995AF50
    public void set_useParticleColor(){} // RVA: 0x7FFAC995AFA0
    public void get_sizeAffectsRange(){} // RVA: 0x7FFAC995B000
    public void set_sizeAffectsRange(){} // RVA: 0x7FFAC995B050
    public void get_alphaAffectsIntensity(){} // RVA: 0x7FFAC995B0B0
    public void set_alphaAffectsIntensity(){} // RVA: 0x7FFAC995B100
    public void get_range(){} // RVA: 0x7FFAC995B160
    public void set_range(){} // RVA: 0x7FFAC995B1D0
    public void get_rangeMultiplier(){} // RVA: 0x7FFAC995B230
    public void set_rangeMultiplier(){} // RVA: 0x7FFAC995B280
    public void get_intensity(){} // RVA: 0x7FFAC995B2E0
    public void set_intensity(){} // RVA: 0x7FFAC995B350
    public void get_intensityMultiplier(){} // RVA: 0x7FFAC995B3B0
    public void set_intensityMultiplier(){} // RVA: 0x7FFAC995B400
    public void get_maxLights(){} // RVA: 0x7FFAC995B460
    public void set_maxLights(){} // RVA: 0x7FFAC995B4B0
    public void get_enabled_Injected(){} // RVA: 0x7FFAC995AC90
    public void set_enabled_Injected(){} // RVA: 0x7FFAC995ACE0
    public void get_ratio_Injected(){} // RVA: 0x7FFAC995AD40
    public void set_ratio_Injected(){} // RVA: 0x7FFAC995AD90
    public void get_useRandomDistribution_Injected(){} // RVA: 0x7FFAC995ADF0
    public void set_useRandomDistribution_Injected(){} // RVA: 0x7FFAC995AE40
    public void get_light_Injected(){} // RVA: 0x7FFAC995AEA0
    public void set_light_Injected(){} // RVA: 0x7FFAC995AEF0
    public void get_useParticleColor_Injected(){} // RVA: 0x7FFAC995AF50
    public void set_useParticleColor_Injected(){} // RVA: 0x7FFAC995AFA0
    public void get_sizeAffectsRange_Injected(){} // RVA: 0x7FFAC995B000
    public void set_sizeAffectsRange_Injected(){} // RVA: 0x7FFAC995B050
    public void get_alphaAffectsIntensity_Injected(){} // RVA: 0x7FFAC995B0B0
    public void set_alphaAffectsIntensity_Injected(){} // RVA: 0x7FFAC995B100
    public void get_range_Injected(){} // RVA: 0x7FFAC995B510
    public void set_range_Injected(){} // RVA: 0x7FFAC995B570
    public void get_rangeMultiplier_Injected(){} // RVA: 0x7FFAC995B230
    public void set_rangeMultiplier_Injected(){} // RVA: 0x7FFAC995B280
    public void get_intensity_Injected(){} // RVA: 0x7FFAC995B5D0
    public void set_intensity_Injected(){} // RVA: 0x7FFAC995B630
    public void get_intensityMultiplier_Injected(){} // RVA: 0x7FFAC995B3B0
    public void set_intensityMultiplier_Injected(){} // RVA: 0x7FFAC995B400
    public void get_maxLights_Injected(){} // RVA: 0x7FFAC995B460
    public void set_maxLights_Injected(){} // RVA: 0x7FFAC995B4B0
}

public class LimbOrientation : Object
{
    public UnityEngine.Vector3 upperBoneForwardAxis; // 0x10
    public UnityEngine.Vector3 lowerBoneForwardAxis; // 0x1C
    public UnityEngine.Vector3 lastBoneLeftAxis; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F6A480
}

public class LimitPoint : Object
{
    public UnityEngine.Vector3 point; // 0x10
    public float tangentWeight; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC308ADC0
}

public class LimitVelocityOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC9953B70
    public void set_enabled(){} // RVA: 0x7FFAC9953BC0
    public void get_limitX(){} // RVA: 0x7FFAC9953C20
    public void set_limitX(){} // RVA: 0x7FFAC9953C90
    public void get_limitXMultiplier(){} // RVA: 0x7FFAC9953CF0
    public void set_limitXMultiplier(){} // RVA: 0x7FFAC9953D40
    public void get_limitY(){} // RVA: 0x7FFAC9953DA0
    public void set_limitY(){} // RVA: 0x7FFAC9953E10
    public void get_limitYMultiplier(){} // RVA: 0x7FFAC9953E70
    public void set_limitYMultiplier(){} // RVA: 0x7FFAC9953EC0
    public void get_limitZ(){} // RVA: 0x7FFAC9953F20
    public void set_limitZ(){} // RVA: 0x7FFAC9953F90
    public void get_limitZMultiplier(){} // RVA: 0x7FFAC9953FF0
    public void set_limitZMultiplier(){} // RVA: 0x7FFAC9954040
    public void get_limit(){} // RVA: 0x7FFAC99540A0
    public void set_limit(){} // RVA: 0x7FFAC9954110
    public void get_limitMultiplier(){} // RVA: 0x7FFAC9954170
    public void set_limitMultiplier(){} // RVA: 0x7FFAC99541C0
    public void get_dampen(){} // RVA: 0x7FFAC9954220
    public void set_dampen(){} // RVA: 0x7FFAC9954270
    public void get_separateAxes(){} // RVA: 0x7FFAC99542D0
    public void set_separateAxes(){} // RVA: 0x7FFAC9954320
    public void get_space(){} // RVA: 0x7FFAC9954380
    public void set_space(){} // RVA: 0x7FFAC99543D0
    public void get_drag(){} // RVA: 0x7FFAC9954430
    public void set_drag(){} // RVA: 0x7FFAC99544A0
    public void get_dragMultiplier(){} // RVA: 0x7FFAC9954500
    public void set_dragMultiplier(){} // RVA: 0x7FFAC9954550
    public void get_multiplyDragByParticleSize(){} // RVA: 0x7FFAC99545B0
    public void set_multiplyDragByParticleSize(){} // RVA: 0x7FFAC9954600
    public void get_multiplyDragByParticleVelocity(){} // RVA: 0x7FFAC9954660
    public void set_multiplyDragByParticleVelocity(){} // RVA: 0x7FFAC99546B0
    public void get_enabled_Injected(){} // RVA: 0x7FFAC9953B70
    public void set_enabled_Injected(){} // RVA: 0x7FFAC9953BC0
    public void get_limitX_Injected(){} // RVA: 0x7FFAC9954710
    public void set_limitX_Injected(){} // RVA: 0x7FFAC9954770
    public void get_limitXMultiplier_Injected(){} // RVA: 0x7FFAC9953CF0
    public void set_limitXMultiplier_Injected(){} // RVA: 0x7FFAC9953D40
    public void get_limitY_Injected(){} // RVA: 0x7FFAC99547D0
    public void set_limitY_Injected(){} // RVA: 0x7FFAC9954830
    public void get_limitYMultiplier_Injected(){} // RVA: 0x7FFAC9953E70
    public void set_limitYMultiplier_Injected(){} // RVA: 0x7FFAC9953EC0
    public void get_limitZ_Injected(){} // RVA: 0x7FFAC9954890
    public void set_limitZ_Injected(){} // RVA: 0x7FFAC99548F0
    public void get_limitZMultiplier_Injected(){} // RVA: 0x7FFAC9953FF0
    public void set_limitZMultiplier_Injected(){} // RVA: 0x7FFAC9954040
    public void get_limit_Injected(){} // RVA: 0x7FFAC9954950
    public void set_limit_Injected(){} // RVA: 0x7FFAC99549B0
    public void get_limitMultiplier_Injected(){} // RVA: 0x7FFAC9954170
    public void set_limitMultiplier_Injected(){} // RVA: 0x7FFAC99541C0
    public void get_dampen_Injected(){} // RVA: 0x7FFAC9954220
    public void set_dampen_Injected(){} // RVA: 0x7FFAC9954270
    public void get_separateAxes_Injected(){} // RVA: 0x7FFAC99542D0
    public void set_separateAxes_Injected(){} // RVA: 0x7FFAC9954320
    public void get_space_Injected(){} // RVA: 0x7FFAC9954380
    public void set_space_Injected(){} // RVA: 0x7FFAC99543D0
    public void get_drag_Injected(){} // RVA: 0x7FFAC9954A10
    public void set_drag_Injected(){} // RVA: 0x7FFAC9954A70
    public void get_dragMultiplier_Injected(){} // RVA: 0x7FFAC9954500
    public void set_dragMultiplier_Injected(){} // RVA: 0x7FFAC9954550
    public void get_multiplyDragByParticleSize_Injected(){} // RVA: 0x7FFAC99545B0
    public void set_multiplyDragByParticleSize_Injected(){} // RVA: 0x7FFAC9954600
    public void get_multiplyDragByParticleVelocity_Injected(){} // RVA: 0x7FFAC9954660
    public void set_multiplyDragByParticleVelocity_Injected(){} // RVA: 0x7FFAC99546B0
}

public class Limits : ValueType
{
    public float minSwing; // 0x10
    public float maxSwing; // 0x14
    public float swing2; // 0x18
    public float twist; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F45570
}

public class LineBreakingTable : Object
{
    public System.Collections.Generic.Dictionary`2<int,char> leadingCharacters; // 0x10
    public System.Collections.Generic.Dictionary`2<int,char> followingCharacters; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class LineInfoAnnotation : Object
{
    public int LineNumber; // 0x10
    public int LinePosition; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6CEC5A0
}

public class LineSegment : ValueType
{
    public UnityEngine.Vector3 Point1; // 0x10
    public UnityEngine.Vector3 Point2; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F2ADF0
}

public class LinkImage : Object
{
    public string url; // 0x10
    public UnityEngine.Texture texture; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Linked1CancellationTokenSource : CancellationTokenSource
{
    public System.Threading.CancellationTokenRegistration _reg1; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86BEE00
    public void Dispose(){} // RVA: 0x7FFAC86BEF80
}

public class Linked2CancellationTokenSource : CancellationTokenSource
{
    public System.Threading.CancellationTokenRegistration _reg1; // 0x40
    public System.Threading.CancellationTokenRegistration _reg2; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86BEFC0
    public void Dispose(){} // RVA: 0x7FFAC86BF230
}

public class LinkedNCancellationTokenSource : CancellationTokenSource
{
    public System.Action`1<object> s_linkedTokenCancelDelegate;
    public System.Threading.CancellationTokenRegistration[] _linkingRegistrations; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86BF280
    public void Dispose(){} // RVA: 0x7FFAC86BF4B0
    public void .cctor(){} // RVA: 0x7FFAC86BF540
}

public class LinkedSlot : Object
{
    public LinkedSlot<T> Next;
    public LinkedSlot<T> Previous;
    public LinkedSlotVolatile<T>[] SlotArray;
    public T Value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
}

public class LinkedSlotVolatile : ValueType
{
    public LinkedSlot<T> Value;
}

public class LinqEnumerator : Object
{
    public OVRSimpleJSON.JSONNode Current; // 0x10
    public Enumerator System.Collections.IEnumerator.Current; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC896A0B0
    public void get_Current(){} // RVA: 0x7FFAC896A1E0
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC896A210
    public void MoveNext(){} // RVA: 0x7FFAC896A270
    public void Dispose(){} // RVA: 0x7FFAC896A280
    public void GetEnumerator(){} // RVA: 0x7FFAC896A2F0
    public void Reset(){} // RVA: 0x7FFAC896A350
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC896A410
}

public class ListBuffer16 : MemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBB22A20
    public void EncodeTo(){} // RVA: 0x7FFACBB22AB0
}

public class ListBuilder`1 : ValueType
{
    public T[] Item;
    public T Count;
    public int _count;
    public int _capacity;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void get_Item(){} // RVA: 0x7FFAC2E8DC40
    public void ToArray(){} // RVA: 0x7FFAC2C58E90
    public void CopyTo(){} // RVA: 0x7FFAC2C77970
    public void get_Count(){} // RVA: 0x7FFAC2C59960
    public void Add(){} // RVA: 0x7FFAC2E8DC40
}

public class ListDummy`1 : Object
{
    public string[] Items; // 0x10
}

public class ListElementProperty : Property`2
{
    public int Index;

    // ── Methods ──
    public void get_Index(){} // RVA: 0x7FFAC2C59960
    public void get_Name(){} // RVA: 0x7FFAC2C58E90
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class ListEntry : Object
{
    public ListEntry _next; // 0x10
    public object _key; // 0x18
    public System.Delegate _handler; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC93E77C0
}

public class ListInitExpressionProxy : Object
{
    public System.Linq.Expressions.ListInitExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D71C30
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_Initializers(){} // RVA: 0x7FFAC356B610
    public void get_NewExpression(){} // RVA: 0x7FFAC3511350
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class ListIterator`1 : ValueType
{
    public bool Current;
    public System.Collections.Generic.List`1<T> list;
    public Enumerator<T> enumerator;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void Dispose(){} // RVA: 0x7FFAC2C70980
}

public class ListOfTWrapper`1 : Object
{
    public System.Collections.Generic.IList`1<T> Count;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_Count(){} // RVA: 0x7FFAC2C59960
    public void get_Item(){} // RVA: 0x7FFAC2E8DC40
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class ListPlayersDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3AD07E0
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7FA60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ListPoolImpl`1 : Object
{
    public VRC.Core.Pool.ObjectPool`1<System.Collections.Generic.List`1<T>> Pool;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class ListQueryMatcher`1 : UQueryMatcher
{
    public System.Collections.Generic.List`1<T> matches;

    // ── Methods ──
    public void get_matches(){} // RVA: 0x7FFAC2C58E90
    public void set_matches(){} // RVA: 0x7FFAC2C70A40
    public void OnRuleMatchedElement(){}
    public void Reset(){} // RVA: 0x7FFAC2C70980
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class ListWrapper`1 : ValueType
{
    public System.Collections.Generic.IReadOnlyList`1<T> Count;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFAC2C59960
    public void get_Item(){}
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
}

public class LiteralList : ValueType
{
    public System.Collections.Generic.List`1<string> literals; // 0x10
    public System.IO.Hashing.XxHash3 xxhash; // 0xFFFF

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void GetHashCode(){} // RVA: 0x7FFACC0ECCD0
    public void Equals(){} // RVA: 0x7FFACC0ED110
}

public class LoadOptions : ValueType
{
    public 0x6B1AB148 StorageLocation; // 0x10
    public int MaxAnchorCount; // 0x14
    public double Timeout; // 0x18
    public System.Collections.Generic.IReadOnlyList`1<System.Guid> Uuids; // 0x20

    // ── Methods ──
    public void get_StorageLocation(){} // RVA: 0x7FFAC4420210
    public void set_StorageLocation(){} // RVA: 0x7FFAC336D8B0
    public void get_MaxAnchorCount(){} // RVA: 0x7FFAC44202A0
    public void set_MaxAnchorCount(){} // RVA: 0x7FFAC4420230
    public void get_Timeout(){} // RVA: 0x7FFAC47D1AE0
    public void set_Timeout(){} // RVA: 0x7FFAC4AB3ED0
    public void get_Uuids(){} // RVA: 0x7FFAC2F3C380
    public void set_Uuids(){} // RVA: 0x7FFAC2F22E30
    public void ToQueryOptions(){} // RVA: 0x7FFAC892BBA0
}

public class LoadingInfoData : ScriptableObject
{
    public string _textureName; // 0x18
    public float weight; // 0x20
    public bool isAnnouncement; // 0x24
    public System.Collections.Generic.List`1<string> paragraphs; // 0x28
    public UnityEngine.Texture _loadedTexture; // 0x30

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC4284850
    public void CreateInstance(){} // RVA: 0x7FFAC42849F0
    public void GetHashCode(){} // RVA: 0x7FFAC4284C40
    public void CreateScriptableObject(){} // RVA: 0x7FFAC4284DE0
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFAC4284F80
    public void ToString(){} // RVA: 0x7FFAC4285120
    public void DoSlerp_Injected_4C0(){} // RVA: 0x7FFAC4285370
    public void .ctor(){} // RVA: 0x7FFAC312F5F0
    public void Initialize(){} // RVA: 0x7FFAC42855C0
}

public class LoadingInfoSet : ScriptableObject
{
    public System.Collections.Generic.List`1<LoadingInfoData> loadingInfos; // 0x18
    public LoadingInfoData announcementLoadingInfo; // 0x20
    public LoadingInfoData twoFactorAuthenticationLoadingInfo; // 0x28
    public LoadingInfoData communityLabsLoadingInfo; // 0x30
    public System.Collections.Generic.List`1<int> loadingInfoCyclesBeforeRepeat; // 0x38
    public int cyclesBeforeRepeat;
    public bool displayCommunityLabsInfo; // 0x40
    public System.Collections.Generic.List`1<UnityEngine.UI.Text> texts; // 0x48
    public System.Collections.Generic.List`1<string> announcementsSeen;
    public LoadingInfoData _currentLoadingInfoData; // 0x50

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC4286D40
    public void CreateInstance(){} // RVA: 0x7FFAC42875B0
    public void Awake(){} // RVA: 0x7FFAC4287840
    public void OnDestroy(){} // RVA: 0x7FFAC42879D0
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFAC4287A00
    public void GetHashCode(){} // RVA: 0x7FFAC4287B70
    public void ToString(){} // RVA: 0x7FFAC4287FF0
    public void ComputeMaterial(){} // RVA: 0x7FFAC42886A0
    public void .ctor(){} // RVA: 0x7FFAC312F5F0
    public void Initialize(){} // RVA: 0x7FFAC42888E0
    public void OnDisable_impl(){} // RVA: 0x7FFAC4288B60
    public void ProcessLoadingInformation(){} // RVA: 0x7FFAC4288BE0
    public void InitializeLoadingContext(){} // RVA: 0x7FFAC4288FF0
    public void CreateLoadingContext(){} // RVA: 0x7FFAC4289860
    public void ConfiguremainTexture(){} // RVA: 0x7FFAC42899D0
    public void Initialize_482C69232443(){} // RVA: 0x7FFAC4289C10
    public void Initialize_532BBB6E7A4E(){} // RVA: 0x7FFAC4289DA0
    public void GetOrProcessLoadingInfo(){} // RVA: 0x7FFAC4289FA0
    public void VRCSetAvatarMainIK(){} // RVA: 0x7FFAC2FDCC10
}

public class LocalMinima : Object
{
    public long Y; // 0x10
    public TEdge LeftBound; // 0x18
    public TEdge RightBound; // 0x20
    public LocalMinima Next; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Locale : Object
{
    // ── Methods ──
    public void GetText(){} // RVA: 0x7FFAC834DF70 | overloaded x2
}

public class LocalityName : AttributeTypeAndValue
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83689A0
}

public class Location : Object
{
    public Google.Protobuf.MessageParser`1<Location> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public Google.Protobuf.FieldCodec`1<int> pb::Google.Protobuf.IMessage.Descriptor; // 0x8
    public Google.Protobuf.Collections.RepeatedField`1<int> Path; // 0x18
    public Google.Protobuf.FieldCodec`1<int> Span; // 0x10
    public Google.Protobuf.Collections.RepeatedField`1<int> LeadingComments; // 0x20
    public string HasLeadingComments; // 0x18
    public string TrailingComments; // 0x28
    public string HasTrailingComments; // 0x20
    public string LeadingDetachedComments; // 0x30
    public Google.Protobuf.FieldCodec`1<string> _repeated_leadingDetachedComments_codec; // 0x28
    public Google.Protobuf.Collections.RepeatedField`1<string> leadingDetachedComments_; // 0x38

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC8210C30
    public void get_Descriptor(){} // RVA: 0x7FFAC8210C90
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC8210D10
    public void .ctor(){} // RVA: 0x7FFAC8210F90 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC82112E0
    public void get_Path(){} // RVA: 0x7FFAC2F247C0
    public void get_Span(){} // RVA: 0x7FFAC2F4F0C0
    public void get_LeadingComments(){} // RVA: 0x7FFAC8211340
    public void set_LeadingComments(){} // RVA: 0x7FFAC82113B0
    public void get_HasLeadingComments(){} // RVA: 0x7FFAC81FF390
    public void ClearLeadingComments(){} // RVA: 0x7FFAC53F2F70
    public void get_TrailingComments(){} // RVA: 0x7FFAC82114B0
    public void set_TrailingComments(){} // RVA: 0x7FFAC8211520
    public void get_HasTrailingComments(){} // RVA: 0x7FFAC781E0A0
    public void ClearTrailingComments(){} // RVA: 0x7FFAC81FF510
    public void get_LeadingDetachedComments(){} // RVA: 0x7FFAC31D0140
    public void Equals(){} // RVA: 0x7FFAC8211680 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC8211860
    public void ToString(){} // RVA: 0x7FFAC8211980
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82119D0
    public void CalculateSize(){} // RVA: 0x7FFAC8211B60
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC8211F00
    public void .cctor(){} // RVA: 0x7FFAC8212140
}

public class LockedScope : Object
{
    public System.IDisposable _scope; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8A40B90
    public void Dispose(){} // RVA: 0x7FFAC8A40DB0
}

public class LockedStack : Object
{
    public T[][] _arrays;
    public int _count;
    public uint _firstStackItemMS;

    // ── Methods ──
    public void TryPush(){} // RVA: 0x7FFAC2C59F60
    public void TryPop(){} // RVA: 0x7FFAC2C58E90
    public void Trim(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class Locomotion : Object
{
    public float centerOfMass; // 0x10
    public float leftFootstepPosition; // 0x14
    public float rightFootstepPosition; // 0x18
    public float leftFootstepRotation; // 0x1C
    public float rightFootstepRotation; // 0x20
    public float maxVelocity; // 0x24
    public float velocityFactor; // 0x28
    public float maxLegStretch; // 0x2C
    public float rootSpeed; // 0x30
    public float stepSpeed; // 0x34
    public UnityEngine.AnimationCurve stepHeight; // 0x38
    public UnityEngine.AnimationCurve heelHeight; // 0x40
    public float relaxLegTwistMinAngle; // 0x48
    public float relaxLegTwistSpeed; // 0x4C
    public 0x6B1BCE98 stepInterpolation; // 0x50
    public UnityEngine.Vector3 offset; // 0x54
    public bool blockingEnabled; // 0x60
    public UnityEngine.LayerMask blockingLayers; // 0x64
    public float raycastRadius; // 0x68
    public float raycastHeight; // 0x6C
    public UnityEngine.Events.UnityEvent onLeftFootstep; // 0x70
    public UnityEngine.Events.UnityEvent onRightFootstep; // 0x78
    public UnityEngine.Vector3 <centerOfMass>k__BackingField; // 0x80
    public Footstep[] footsteps; // 0x90
    public UnityEngine.Vector3 lastComPosition; // 0x98
    public UnityEngine.Vector3 comVelocity; // 0xA4
    public int leftFootIndex; // 0xB0
    public int rightFootIndex; // 0xB4

    // ── Methods ──
    public void get_centerOfMass(){} // RVA: 0x7FFAC3051E70
    public void set_centerOfMass(){} // RVA: 0x7FFAC3051E90
    public void Initiate(){} // RVA: 0x7FFAC3051EB0
    public void Reset(){} // RVA: 0x7FFAC30522E0
    public void VrcSetLeftFoot(){} // RVA: 0x7FFAC30526F0
    public void VrcSetRightFoot(){} // RVA: 0x7FFAC3052770
    public void AddDeltaRotation(){} // RVA: 0x7FFAC30527F0
    public void AddDeltaPosition(){} // RVA: 0x7FFAC30532E0
    public void Solve(){} // RVA: 0x7FFAC3053430
    public void get_leftFootstepPosition(){} // RVA: 0x7FFAC30556F0
    public void get_rightFootstepPosition(){} // RVA: 0x7FFAC3055740
    public void get_leftFootstepRotation(){} // RVA: 0x7FFAC3055790
    public void get_rightFootstepRotation(){} // RVA: 0x7FFAC30557D0
    public void StepBlocked(){} // RVA: 0x7FFAC3055810
    public void CanStep(){} // RVA: 0x7FFAC3055A90
    public void GetLineSphereCollision(){} // RVA: 0x7FFAC3055B00
    public void .ctor(){} // RVA: 0x7FFAC3055E60
}

public class LogCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9855000
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class LogCallback2DelegateType : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC89068C0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
    public void BeginInvoke(){} // RVA: 0x7FFAC8906990
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class LogDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class LogEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACC0772D0
    public void Invoke(){} // RVA: 0x7FFAC5C60E20
    public void BeginInvoke(){} // RVA: 0x7FFACC077450
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class LogForwarder : ValueType
{
    // ── Methods ──
    public void Log(){} // RVA: 0x7FFAC89240C0
    public void LogWarning(){} // RVA: 0x7FFAC8924170
    public void LogError(){} // RVA: 0x7FFAC8924220
}
