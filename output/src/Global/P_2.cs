// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 64
// Methods: 276

public class PointerLocation : ValueType
{
    public UnityEngine.Vector2 Position; // 0x10
    public UnityEngine.UIElements.IPanel Panel; // 0x18
    public 0x6B11DBC0 Flags; // 0x20

    // ── Methods ──
    public void get_Position(){} // RVA: 0x7FFAC3AD9F60
    public void set_Position(){} // RVA: 0x7FFAC45BB120
    public void get_Panel(){} // RVA: 0x7FFAC4420220
    public void set_Panel(){} // RVA: 0x7FFAC4420240
    public void get_Flags(){} // RVA: 0x7FFAC2F6E5C0
    public void set_Flags(){} // RVA: 0x7FFAC2F240C0
    public void SetLocation(){} // RVA: 0x7FFAC9B8D380
}

public class PolarCoord : ValueType
{
    public float azimuth; // 0x10
    public float elevation; // 0x14

    // ── Methods ──
    public void FromCart(){} // RVA: 0x7FFAC8A11240
}

public class PollHtcsPlayerConnection : ValueType
{
}

public class PollNextEventUnion : ValueType
{
    public _PollNextEvent pPollNextEvent; // 0x10
    public _PollNextEventPacked pPollNextEventPacked; // 0x10
}

public class PollNextOverlayEventUnion : ValueType
{
    public _PollNextOverlayEvent pPollNextOverlayEvent; // 0x10
    public _PollNextOverlayEventPacked pPollNextOverlayEventPacked; // 0x10
}

public class PollPlayerConnection : ValueType
{
}

public class PolyNode : Object
{
    public PolyNode ChildCount; // 0x10
    public System.Collections.Generic.List`1<IntPoint> Contour; // 0x18
    public int Childs; // 0x20
    public 0x6B22C548 Parent; // 0x24
    public 0x6B22C5A0 IsHole; // 0x28
    public System.Collections.Generic.List`1<PolyNode> IsOpen; // 0x30
    public bool <IsOpen>k__BackingField; // 0x38

    // ── Methods ──
    public void IsHoleNode(){} // RVA: 0x7FFAC485C110
    public void get_ChildCount(){} // RVA: 0x7FFAC485C130
    public void get_Contour(){} // RVA: 0x7FFAC2F247C0
    public void AddChild(){} // RVA: 0x7FFAC485C180
    public void GetNext(){} // RVA: 0x7FFAC485C250
    public void GetNextSiblingUp(){} // RVA: 0x7FFAC485C2F0
    public void get_Childs(){} // RVA: 0x7FFAC31D95E0
    public void get_Parent(){} // RVA: 0x7FFAC2F3C380
    public void get_IsHole(){} // RVA: 0x7FFAC485C110
    public void get_IsOpen(){} // RVA: 0x7FFAC31D95D0
    public void set_IsOpen(){} // RVA: 0x7FFAC31D95C0
    public void .ctor(){} // RVA: 0x7FFAC485C3B0
}

public class PolyTree : PolyNode
{
    public System.Collections.Generic.List`1<PolyNode> Total; // 0x40

    // ── Methods ──
    public void Clear(){} // RVA: 0x7FFAC485BDD0
    public void GetFirst(){} // RVA: 0x7FFAC485BF00
    public void get_Total(){} // RVA: 0x7FFAC485BF90
    public void .ctor(){} // RVA: 0x7FFAC485C040
}

public class PolyfillExtensions : Object
{
    public System.Collections.Concurrent.ConcurrentDictionary`2<System.Reflection.ParameterInfo,System.Reflection.NullabilityInfo> parameterCache;
    public System.Collections.Concurrent.ConcurrentDictionary`2<System.Reflection.PropertyInfo,System.Reflection.NullabilityInfo> propertyCache; // 0x8
    public System.Collections.Concurrent.ConcurrentDictionary`2<System.Reflection.EventInfo,System.Reflection.NullabilityInfo> eventCache; // 0x10
    public System.Collections.Concurrent.ConcurrentDictionary`2<System.Reflection.FieldInfo,System.Reflection.NullabilityInfo> fieldCache; // 0x18
    public long TicksPerMicrosecond;

    // ── Methods ──
    public void GetNullabilityInfo(){} // RVA: 0x7FFAC8A288F0 | overloaded x5
    public void GetNullability(){} // RVA: 0x7FFAC8A28AA0 | overloaded x5
    public void IsNullable(){} // RVA: 0x7FFAC8A28E10 | overloaded x6
    public void GetReadOrWriteState(){} // RVA: 0x7FFAC8A28BE0
    public void GetKnownState(){} // RVA: 0x7FFAC8A28C10
    public void CancelAsync(){} // RVA: 0x7FFAC8A28E80
    public void GetStreamAsync(){} // RVA: 0x7FFAC8A291C0 | overloaded x2
    public void GetByteArrayAsync(){} // RVA: 0x7FFAC8A294B0 | overloaded x2
    public void GetStringAsync(){} // RVA: 0x7FFAC8A297A0 | overloaded x2
    public void ReadAsStreamAsync(){} // RVA: 0x7FFAC8A29840
    public void ReadAsByteArrayAsync(){} // RVA: 0x7FFAC8A29910
    public void ReadAsStringAsync(){} // RVA: 0x7FFAC8A29B60
    public void MaxBy(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    public void MinBy(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    public void SkipLast(){} // RVA: 0x7FFAC2C68090
    public void GetValueOrDefault(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    public void Deconstruct(){} // RVA: 0x7FFAC2E8DC40
    public void Contains(){} // RVA: 0x7FFAC8A2BAB0 | overloaded x4
    public void SequenceEqual(){} // RVA: 0x7FFAC8A29CE0 | overloaded x2
    public void StartsWith(){} // RVA: 0x7FFAC8A2B7F0 | overloaded x3
    public void EndsWith(){} // RVA: 0x7FFAC8A2B830 | overloaded x3
    public void Nanoseconds(){} // RVA: 0x7FFAC8A2A440
    public void Nanosecond(){} // RVA: 0x7FFAC8A2A540 | overloaded x2
    public void Microseconds(){} // RVA: 0x7FFAC8A2A5D0
    public void Microsecond(){} // RVA: 0x7FFAC8A2A6D0 | overloaded x2
    public void AddMicroseconds(){} // RVA: 0x7FFAC8A2A810 | overloaded x2
    public void TicksComponent(){} // RVA: 0x7FFAC8A2ACC0 | overloaded x3
    public void ReadAsync(){} // RVA: 0x7FFAC8A2C200 | overloaded x2
    public void WriteAsync(){} // RVA: 0x7FFAC8A2C5F0 | overloaded x2
    public void CopyToAsync(){} // RVA: 0x7FFAC8A2B330
    public void CopyTo(){} // RVA: 0x7FFAC8A2BAE0 | overloaded x2
    public void TryCopyTo(){} // RVA: 0x7FFAC8A2B450
    public void GetHashCode(){} // RVA: 0x7FFAC8A2B500
    public void FromComparison(){} // RVA: 0x7FFAC8A2B680
    public void Split(){} // RVA: 0x7FFAC8A2B990 | overloaded x2
    public void Append(){} // RVA: 0x7FFAC8A2BBB0
    public void Equals(){} // RVA: 0x7FFAC8A2BC50
    public void WaitAsync(){} // RVA: 0x7FFAC2E8DC40 | overloaded x6
    public void ReadToEndAsync(){} // RVA: 0x7FFAC8A2C510
    public void WriteLineAsync(){} // RVA: 0x7FFAC8A2C8E0
    public void Write(){} // RVA: 0x7FFAC8A2CBD0
    public void WriteLine(){} // RVA: 0x7FFAC8A2CE00
    public void TryFormat(){} // RVA: 0x7FFAC8A2E190 | overloaded x14
    public void CopyToSpan(){} // RVA: 0x7FFAC8A2E320
    public void HasSameMetadataDefinitionAs(){} // RVA: 0x7FFAC8A2E450
    public void IsGenericMethodParameter(){} // RVA: 0x7FFAC8A2E520
    public void GetMemberWithSameMetadataDefinitionAs(){} // RVA: 0x7FFAC8A2E5B0
    public void ReadAsStream(){} // RVA: 0x7FFAC8A2E7B0
    public void WriteRawValue(){} // RVA: 0x7FFAC8A2E960
    public void .cctor(){} // RVA: 0x7FFAC8A2EC30
}

public class PolygonSolution : ValueType
{
    public System.Collections.Generic.List`1<System.Collections.Generic.List`1<IntPoint>> IsNull; // 0x10
    public float frustumHeight; // 0x18

    // ── Methods ──
    public void StateChanged(){} // RVA: 0x7FFAC484C1E0
    public void get_IsNull(){} // RVA: 0x7FFAC484C2F0
}

public class PolygonalBoundary2DInternal : ValueType
{
    public int vertexCapacityInput; // 0x10
    public int vertexCountOutput; // 0x14
    public UIntPtr vertices; // 0x18
}

public class PopupButtonData : ApiModel
{
    public VRC.Core.ApiLocalizableString text; // 0x68
    public System.Collections.Generic.Dictionary`2<string,string> capture; // 0x70
    public System.Collections.Generic.List`1<RequiredValue> requiredCaptures; // 0x78
    public bool completePromotionOnPress; // 0x80
    public string analyticsEventTag; // 0x88
    public VRC.Core.ApiBindingCommandReference onPressed; // 0x90

    // ── Methods ──
    public void get_text(){} // RVA: 0x7FFAC2F9CD50
    public void set_text(){} // RVA: 0x7FFAC2F9CD60
    public void get_capture(){} // RVA: 0x7FFAC2FE9590
    public void set_capture(){} // RVA: 0x7FFAC2FE95A0
    public void get_requiredCaptures(){} // RVA: 0x7FFAC30E5600
    public void set_requiredCaptures(){} // RVA: 0x7FFAC30E06F0
    public void get_completePromotionOnPress(){} // RVA: 0x7FFAC313E620
    public void set_completePromotionOnPress(){} // RVA: 0x7FFAC313D3B0
    public void get_analyticsEventTag(){} // RVA: 0x7FFAC2F60010
    public void set_analyticsEventTag(){} // RVA: 0x7FFAC354E300
    public void get_onPressed(){} // RVA: 0x7FFAC32EF640
    public void set_onPressed(){} // RVA: 0x7FFAC354E360
    public void .ctor(){} // RVA: 0x7FFACBE798D0
}

public class PopupTextElement : TextElement
{
    // ── Methods ──
    public void DoMeasure(){}
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class PortalSkinMap : MonoBehaviour
{
    public UnityEngine.Animator Animator; // 0x20
    public UnityEngine.MeshRenderer ThumbnailRenderer; // 0x28
    public float DespawnDuration; // 0x30
    public UnityEngine.Transform PortalUIOverridePosition; // 0x38
    public UnityEngine.Transform PortalPlatformBadgesOverridePosition; // 0x40
    public UnityEngine.Transform PortalLabsBadgeOverridePosition; // 0x48
    public float PreviewScale; // 0x50
    public UnityEngine.Vector3 PreviewOffset; // 0x54

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E5DC40
}

public class Pose : Object
{
    public VRC.Dynamics.ChainId chainId; // 0x10
    public bool prevIsAnimated; // 0x20
    public System.Collections.Generic.List`1<PoseData> prevData; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E4E9E0
}

public class PoseBlendingBehaviour : Object
{
    public string name; // 0x10
    public bool enabled; // 0x18
    public float influence; // 0x1C
    public int pose; // 0x20
    public float value; // 0x24
    public Valve.VR.SteamVR_Action_Single action_single; // 0x28
    public Valve.VR.SteamVR_Action_Boolean action_bool; // 0x30
    public float smoothingSpeed; // 0x38
    public 0x6B209EF0 type; // 0x3C
    public bool useMask; // 0x40
    public Valve.VR.SteamVR_Skeleton_HandMask mask; // 0x48
    public bool previewEnabled; // 0x50

    // ── Methods ──
    public void Update(){} // RVA: 0x7FFAC8C8F2C0
    public void ApplyBlending(){} // RVA: 0x7FFAC8C8F420
    public void .ctor(){} // RVA: 0x7FFAC8C8F8A0
}

public class PoseData : ValueType
{
    public Unity.Mathematics.float3 localPoseBoneVector; // 0x10
    public Unity.Mathematics.quaternion localPoseRotation; // 0x1C
}

public class PoseStatef : ValueType
{
    public Posef Pose; // 0x10
    public Vector3f Velocity; // 0x2C
    public Vector3f Acceleration; // 0x38
    public Vector3f AngularVelocity; // 0x44
    public Vector3f AngularAcceleration; // 0x50
    public double Time; // 0x60
    public PoseStatef identity;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC8907AE0
}

public class Posef : ValueType
{
    public Quatf Orientation; // 0x10
    public Vector3f Position; // 0x20
    public Posef identity;

    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFAC8907570
    public void .cctor(){} // RVA: 0x7FFAC89076E0
}

public class PosesUpdatedHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC40BEC20
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC8C83C00
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class PositionOffset : Offset
{
    public int forceDirCurveIndex; // 0x50
    public int upDirCurveIndex; // 0x54
    public PositionOffsetLink[] offsetLinks; // 0x58

    // ── Methods ──
    public void GetLength(){} // RVA: 0x7FFAC3090B50
    public void CrossFadeStart(){} // RVA: 0x7FFAC3090E60
    public void OnApply(){} // RVA: 0x7FFAC3090EC0
    public void .ctor(){} // RVA: 0x7FFAC3091230
}

public class PositionOffsetLink : Object
{
    public 0x6B1C09B8 positionOffset; // 0x10
    public float weight; // 0x14
    public UnityEngine.Vector3 lastValue; // 0x18
    public UnityEngine.Vector3 current; // 0x24

    // ── Methods ──
    public void Apply(){} // RVA: 0x7FFAC3091240
    public void CrossFadeStart(){} // RVA: 0x7FFAC308FA00
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class PositionProperty : Property`2
{
    public object Name;

    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFAC99A6EF0
    public void .ctor(){} // RVA: 0x7FFAC99A6F30
}

public class PostLateUpdater : MonoBehaviour
{
    public VRC.Udon.UdonManager udonManager; // 0x20

    // ── Methods ──
    public void LateUpdate(){} // RVA: 0x7FFAC9E87A40
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
}

public class PowerOvfl : ValueType
{
    public uint Hi; // 0x10
    public ulong MidLo; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86B9480
}

public class PrecisionBudget : Object
{
    public float Disabled;
    public float Safe;
    public float Strict;
}

public class PrecompiledLayout : ValueType
{
    public System.Func`1<UnityEngine.InputSystem.InputDevice> factoryMethod; // 0x10
    public string metadata; // 0x18
}

public class PrecomputeCallback : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint m_p; // 0x10
    public int m_minWidth; // 0x18
    public bool m_includeNegated; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8675550
    public void Precompute(){} // RVA: 0x7FFACBA7F7C0
    public void CheckExisting(){} // RVA: 0x7FFACBA80330
    public void CheckTable(){} // RVA: 0x7FFACBA80460
}

public class PrecomputeWithPointMapCallback : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPoint m_point; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.ECPointMap m_pointMap; // 0x18
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo m_fromWNaf; // 0x20
    public bool m_includeNegated; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBA80470
    public void Precompute(){} // RVA: 0x7FFACBA80580
    public void CheckExisting(){} // RVA: 0x7FFACBA80AD0
    public void CheckTable(){} // RVA: 0x7FFACBA80460
}

public class PresentAfterDraw : ValueType
{
}

public class PresentBeforeUpdate : ValueType
{
}

public class PreserveAttribute : Attribute
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class PresetSaveData : Object
{
    public int SelectedPreset; // 0x10
    public System.Collections.Generic.Dictionary`2<int,ÍÎÍÌÎÌÍÍÎÍÏÏÎÏÏÎÎÎÌÌÌÍÏ> Presets; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class PreviousInfo : ValueType
{
    public int Code; // 0x10
    public byte* SortKey; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC839B310
}

public class Prime192v1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD1E850
    public void .cctor(){} // RVA: 0x7FFACBD1EAD0
}

public class Prime192v2Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD1EB70
    public void .cctor(){} // RVA: 0x7FFACBD1EDF0
}

public class Prime192v3Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD1EE90
    public void .cctor(){} // RVA: 0x7FFACBD1F110
}

public class Prime239v1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD1F1B0
    public void .cctor(){} // RVA: 0x7FFACBD1F430
}

public class Prime239v2Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD1F4D0
    public void .cctor(){} // RVA: 0x7FFACBD1F750
}

public class Prime239v3Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD1F7F0
    public void .cctor(){} // RVA: 0x7FFACBD1FA70
}

public class Prime256v1Holder : X9ECParametersHolder
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X9.X9ECParametersHolder Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void CreateParameters(){} // RVA: 0x7FFACBD1FB10
    public void .cctor(){} // RVA: 0x7FFACBD1FD90
}

public class PrintErrorsCallbackFunc : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8977AB0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class PrintFile : ApiModel
{
    public string fileId; // 0x68
    public string image; // 0x70

    // ── Methods ──
    public void get_fileId(){} // RVA: 0x7FFAC2F9CD50
    public void set_fileId(){} // RVA: 0x7FFAC2F9CD60
    public void get_image(){} // RVA: 0x7FFAC2FE9590
    public void set_image(){} // RVA: 0x7FFAC2FE95A0
    public void .ctor(){} // RVA: 0x7FFACBEC1AF0
}

public class PrivateKeyInfo : Object
{
    public int Algorithm; // 0x10
    public string PrivateKey; // 0x18
    public byte[] _key; // 0x20
    public System.Collections.ArrayList _list; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8377780 | overloaded x2
    public void get_Algorithm(){} // RVA: 0x7FFAC2F247C0
    public void set_Algorithm(){} // RVA: 0x7FFAC2F87E80
    public void get_PrivateKey(){} // RVA: 0x7FFAC83777B0
    public void set_PrivateKey(){} // RVA: 0x7FFAC8377830
    public void Decode(){} // RVA: 0x7FFAC8377970
    public void GetBytes(){} // RVA: 0x7FFAC8377CA0
    public void RemoveLeadingZero(){} // RVA: 0x7FFAC8378330
    public void Normalize(){} // RVA: 0x7FFAC83783E0
    public void DecodeRSA(){} // RVA: 0x7FFAC83784A0
    public void Encode(){} // RVA: 0x7FFAC83790D0 | overloaded x3
    public void DecodeDSA(){} // RVA: 0x7FFAC8378EB0
}

public class ProbabilisticMap : ValueType
{
}

public class ProcInfo : ValueType
{
    public UIntPtr process_handle; // 0x10
    public int pid; // 0x18
    public string[] envVariables; // 0x20
    public string UserName; // 0x28
    public string Domain; // 0x30
    public UIntPtr Password; // 0x38
    public bool LoadUserProfile; // 0x40
}

public class ProcessExtractedFrame : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7CB80
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ProcessMessageRes : ValueType
{
    public byte[] arrResponse; // 0x10
    public System.Runtime.Remoting.Messaging.CADMethodReturnMessage cadMrm; // 0x18
}

public class ProcessMouseInWindow : ValueType
{
}

public class ProcessRemoteInput : ValueType
{
}

public class ProcessWebSendMessages : ValueType
{
}

public class ProfilerEndFrame : ValueType
{
}

public class ProfilerStartFrame : ValueType
{
}

public class ProfilerSynchronizeStats : ValueType
{
}

public class Promotion : ApiModel
{
    public string type; // 0x68
    public string imageUrl; // 0x70
    public int position; // 0x78
    public int displayDelay; // 0x7C
    public int impressions; // 0x80
    public int hoursBetweenImpressions; // 0x84
    public string fallback; // 0x88
    public int fallbackPosition; // 0x90
    public string popupId; // 0x98
    public VRC.Core.ApiBindingCommandReference onPressed; // 0xA0
    public VRC.Core.ApiBindingCommandReference popupCommand; // 0xA8
    public System.Collections.Generic.List`1<ApiPopupBuilderRecipe> recipes; // 0xB0
    public ApiPromotionNotification notification; // 0xB8

    // ── Methods ──
    public void get_type(){} // RVA: 0x7FFAC2F9CD50
    public void set_type(){} // RVA: 0x7FFAC2F9CD60
    public void get_imageUrl(){} // RVA: 0x7FFAC2FE9590
    public void set_imageUrl(){} // RVA: 0x7FFAC2FE95A0
    public void get_position(){} // RVA: 0x7FFAC4596EF0
    public void set_position(){} // RVA: 0x7FFAC45963A0
    public void get_displayDelay(){} // RVA: 0x7FFAC4598F70
    public void set_displayDelay(){} // RVA: 0x7FFAC89E0310
    public void get_impressions(){} // RVA: 0x7FFAC35729C0
    public void set_impressions(){} // RVA: 0x7FFAC3572BF0
    public void get_hoursBetweenImpressions(){} // RVA: 0x7FFAC46D5110
    public void set_hoursBetweenImpressions(){} // RVA: 0x7FFAC46D5150
    public void get_fallback(){} // RVA: 0x7FFAC2F60010
    public void set_fallback(){} // RVA: 0x7FFAC354E300
    public void get_fallbackPosition(){} // RVA: 0x7FFAC3220660
    public void set_fallbackPosition(){} // RVA: 0x7FFAC34D2750
    public void get_popupId(){} // RVA: 0x7FFAC354DFB0
    public void set_popupId(){} // RVA: 0x7FFAC354E3C0
    public void get_onPressed(){} // RVA: 0x7FFAC3543900
    public void set_onPressed(){} // RVA: 0x7FFAC354E420
    public void get_popupCommand(){} // RVA: 0x7FFAC354B1A0
    public void set_popupCommand(){} // RVA: 0x7FFAC334B370
    public void get_recipes(){} // RVA: 0x7FFAC2F8C040
    public void set_recipes(){} // RVA: 0x7FFAC2F8C050
    public void get_notification(){} // RVA: 0x7FFAC2F8C0B0
    public void set_notification(){} // RVA: 0x7FFAC2F8C0C0
    public void .ctor(){} // RVA: 0x7FFACBE79710
}

public class PropBuilderSessionData : Object
{
    public string PropName; // 0x10
    public string PropID; // 0x18
    public string PropDesc; // 0x20
    public string PropTags; // 0x28
    public string PropThumbPath; // 0x30
    public string PropReleaseStatus; // 0x38
    public 0x6B0AC048 PropSpawnType; // 0x40
    public 0x6B0AC0A0 PropWorldPlacementMask; // 0x44
    public bool PropScaleWithAvatar; // 0x48
    public string PropAbilities; // 0x50

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class PropDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class PropertyDescriptorEnumerator : Object
{
    public System.ComponentModel.PropertyDescriptorCollection Current; // 0x10
    public int Entry; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5923EB0
    public void get_Current(){} // RVA: 0x7FFAC940FFD0
    public void get_Entry(){} // RVA: 0x7FFAC9410130
    public void get_Key(){} // RVA: 0x7FFAC94101B0
    public void get_Value(){} // RVA: 0x7FFAC94101B0
    public void MoveNext(){} // RVA: 0x7FFAC9410200
    public void Reset(){} // RVA: 0x7FFAC47EDC40
}

public class PropertyHierarchyResolutionState : ValueType
{
    public System.Collections.Generic.Dictionary`2<string,System.ValueTuple`2<System.Text.Json.Serialization.Metadata.JsonPropertyInfo,int>> AddedProperties; // 0x10
    public System.Collections.Generic.Dictionary`2<string,System.Text.Json.Serialization.Metadata.JsonPropertyInfo> IgnoredProperties; // 0x18
    public bool IsPropertyOrderSpecified; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9071D50
}

public class Props : Object
{
    public 0x6B1BDBA8 group; // 0x10
    public float mappingWeight; // 0x14
    public float pinWeight; // 0x18
    public float muscleWeight; // 0x1C
    public float muscleDamper; // 0x20
    public bool mapPosition; // 0x24
    public InternalCollisionIgnoreSettings internalCollisionIgnores; // 0x28
    public UnityEngine.Transform[] animatedTargetChildren; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F97990 | overloaded x2
    public void Clamp(){} // RVA: 0x7FFAC2F97B30
}

public class ProviderRegistration : ValueType
{
    public Microsoft.Extensions.Logging.ILoggerProvider Provider; // 0x10
    public bool ShouldDispose; // 0x18
}

public class PseudoStateData : ValueType
{
    public 0x6B126648 state; // 0x10
    public bool negate; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC336D8C0
}

public class PuppetEvent : ValueType
{
    public string switchBehaviour; // 0x10
    public AnimatorEvent[] animations; // 0x18
    public UnityEngine.Events.UnityEvent unityEvent; // 0x20
    public string empty;

    // ── Methods ──
    public void get_switchBehaviour(){} // RVA: 0x7FFAC2F7FDB0
    public void Trigger(){} // RVA: 0x7FFAC2F7FEA0
}

public class PuppetUpdateLimit : Object
{
    public int puppetsPerFrame; // 0x10
    public int index; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FC27D0
    public void Step(){} // RVA: 0x7FFAC2FC27E0
    public void Update(){} // RVA: 0x7FFAC2FC2800
}
