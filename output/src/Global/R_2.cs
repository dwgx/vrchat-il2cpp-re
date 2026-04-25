// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 53
// Methods: 282

public class RequestObject : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp.CertificateID certId; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void ToRequest(){} // RVA: 0x7FFACBF82230
}

public class RequiredValue : ApiModel
{
    public string value; // 0x68
    public VRC.Core.ApiLocalizableString error; // 0x70

    // ── Methods ──
    public void get_value(){} // RVA: 0x7FFAC2F9CD50
    public void set_value(){} // RVA: 0x7FFAC2F9CD60
    public void get_error(){} // RVA: 0x7FFAC2FE9590
    public void set_error(){} // RVA: 0x7FFAC2FE95A0
    public void .ctor(){} // RVA: 0x7FFACBE79920
}

public class ReservedName : ApiModel
{
    public string displayName; // 0x68
    public System.DateTime expires; // 0x70

    // ── Methods ──
    public void get_displayName(){} // RVA: 0x7FFAC2F9CD50
    public void set_displayName(){} // RVA: 0x7FFAC2F9CD60
    public void get_expires(){} // RVA: 0x7FFAC2FE9590
    public void set_expires(){} // RVA: 0x7FFAC4A2BA60
    public void .ctor(){} // RVA: 0x7FFACBE64C90
}

public class ReservedRange : Object
{
    public Google.Protobuf.MessageParser`1<ReservedRange> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int Start; // 0x8
    public int HasStart; // 0x1C
    public int End; // 0xC
    public int HasEnd; // 0x20

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC81F43B0
    public void get_Descriptor(){} // RVA: 0x7FFAC81F4410
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC81F4490
    public void .ctor(){} // RVA: 0x7FFAC81F4540 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC81F4630
    public void get_Start(){} // RVA: 0x7FFAC81F4750
    public void set_Start(){} // RVA: 0x7FFAC81F3760
    public void get_HasStart(){} // RVA: 0x7FFAC81F3770
    public void ClearStart(){} // RVA: 0x7FFAC81F3780
    public void get_End(){} // RVA: 0x7FFAC81F47C0
    public void set_End(){} // RVA: 0x7FFAC81F3800
    public void get_HasEnd(){} // RVA: 0x7FFAC81F3810
    public void ClearEnd(){} // RVA: 0x7FFAC81F3820
    public void Equals(){} // RVA: 0x7FFAC81F4920 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC81F49E0
    public void ToString(){} // RVA: 0x7FFAC81F4A50
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC81F4AA0
    public void CalculateSize(){} // RVA: 0x7FFAC81F4B30
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC81F4D10
    public void .cctor(){} // RVA: 0x7FFAC81F4DB0
}

public class ReservedWords : ValueType
{
    public string _word; // 0x10
    public 0x6B1CF8F8 _token; // 0x18
    public int _op; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6510D20
}

public class ResetFrameStatsAfterPresent : ValueType
{
}

public class ResetInputAxis : ValueType
{
}

public class ResolutionStruct : ValueType
{
    public int width; // 0x10
    public int height; // 0x14
    public double frameRate; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC44231A0 | overloaded x2
    public void Initialize(){} // RVA: 0x7FFAC4423170
    public void DefaultEquals(){} // RVA: 0x7FFAC4423170
    public void Equals(){} // RVA: 0x7FFAC4423170
    public void InternalGetHashCode(){} // RVA: 0x7FFAC4423170
    public void GetHashCode(){} // RVA: 0x7FFAC4423170
    public void ToString(){} // RVA: 0x7FFAC44231B0
    public void GetSecondPointerOffsetInt(){} // RVA: 0x7FFAC4423170
    public void GetNetworkValueAtOffset44(){} // RVA: 0x7FFAC4423170
    public void .ctor_2391253A6788(){} // RVA: 0x7FFAC4423170
    public void Equals_3903EA6EFB3E(){} // RVA: 0x7FFAC4423170
}

public class ResolveContext : ValueType
{
    public UnityEngine.UIElements.StyleSheet sheet; // 0x10
    public UnityEngine.UIElements.StyleValueHandle[] handles; // 0x18
}

public class ResolveEventHolder : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Resource : ValueType
{
    public string address; // 0x10
    public UnityEngine.Object obj; // 0x18
}

public class ResourceEnumerator : Object
{
    public System.Resources.ResourceReader Key; // 0x10
    public bool Current; // 0x18
    public int DataPosition; // 0x1C
    public int Entry; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC84EE8C0
    public void MoveNext(){} // RVA: 0x7FFAC84EE930
    public void get_Key(){} // RVA: 0x7FFAC84EE980
    public void get_Current(){} // RVA: 0x7FFAC84EEAE0
    public void get_DataPosition(){} // RVA: 0x7FFAC30DBBE0
    public void get_Entry(){} // RVA: 0x7FFAC84EEB40
    public void get_Value(){} // RVA: 0x7FFAC84EF0C0
    public void Reset(){} // RVA: 0x7FFAC84EF220
}

public class ResourceManagerMediator : Object
{
    public System.Resources.ResourceManager ModuleDir; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC84E9A10
    public void get_ModuleDir(){} // RVA: 0x7FFAC3773190
    public void get_LocationInfo(){} // RVA: 0x7FFAC37735C0
    public void get_UserResourceSet(){} // RVA: 0x7FFAC350FB30
    public void get_BaseNameField(){} // RVA: 0x7FFAC3511350
    public void get_NeutralResourcesCulture(){} // RVA: 0x7FFAC3510F20
    public void GetResourceFileName(){} // RVA: 0x7FFAC84E9AC0
    public void get_LookedForSatelliteContractVersion(){} // RVA: 0x7FFAC353EA20
    public void set_LookedForSatelliteContractVersion(){} // RVA: 0x7FFAC84E9AF0
    public void get_SatelliteContractVersion(){} // RVA: 0x7FFAC84E9B10
    public void set_SatelliteContractVersion(){} // RVA: 0x7FFAC84E9B30
    public void ObtainSatelliteContractVersion(){} // RVA: 0x7FFAC84E9BA0
    public void get_FallbackLoc(){} // RVA: 0x7FFAC84E9BF0
    public void get_CallingAssembly(){} // RVA: 0x7FFAC34AEA50
    public void get_MainAssembly(){} // RVA: 0x7FFAC84E9C10
    public void get_BaseName(){} // RVA: 0x7FFAC84E9CA0
}

public class ResourceProvider : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6EA1B30
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class ResourceRequestAwaiter : ValueType
{
    public UnityEngine.ResourceRequest IsCompleted; // 0x10
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3BB0830
    public void get_IsCompleted(){} // RVA: 0x7FFAC94CED00
    public void GetResult(){} // RVA: 0x7FFAC94D2140
    public void OnCompleted(){} // RVA: 0x7FFAC94D22D0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFAC94D22E0
}

public class ResourceRequestConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<ResourceRequestConfiguredSource> NextNode;
    public ResourceRequestConfiguredSource nextNode; // 0x10
    public UnityEngine.ResourceRequest asyncOperation; // 0x18
    public System.IProgress`1<float> progress; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public bool completed; // 0x49
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<UnityEngine.Object> core; // 0x50
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x78

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC94D2410
    public void .ctor(){} // RVA: 0x7FFAC94D2590
    public void Create(){} // RVA: 0x7FFAC94D2650
    public void GetResult(){} // RVA: 0x7FFAC94D2BC0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC94D2E40
    public void GetStatus(){} // RVA: 0x7FFAC94D2E50
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC94D2EA0
    public void OnCompleted(){} // RVA: 0x7FFAC94D2EE0
    public void MoveNext(){} // RVA: 0x7FFAC94D2F60
    public void TryReturn(){} // RVA: 0x7FFAC94D30B0
    public void Continuation(){} // RVA: 0x7FFAC94D3220
}

public class Resources : ValueType
{
    public UnityEngine.Sprite standard; // 0x10
    public UnityEngine.Sprite background; // 0x18
    public UnityEngine.Sprite inputField; // 0x20
    public UnityEngine.Sprite knob; // 0x28
    public UnityEngine.Sprite checkmark; // 0x30
    public UnityEngine.Sprite dropdown; // 0x38
    public UnityEngine.Sprite mask; // 0x40
}

public class Response : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC307D2A0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFACC0CAF30
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class ResponseObject : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Ocsp.CertificateID certId; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Ocsp.CertStatus certStatus; // 0x18
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime thisUpdate; // 0x20
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.DerGeneralizedTime nextUpdate; // 0x28
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.X509.X509Extensions extensions; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBF7EB70 | overloaded x3
    public void ToResponse(){} // RVA: 0x7FFACBF7F180
}

public class Result : Object
{
    public 0x6B13DCF8<T> Status;
    public System.Runtime.ExceptionServices.ExceptionDispatchInfo Success;
    public T Error;

    // ── Methods ──
    public void get_Status(){} // RVA: 0x7FFAC2E8DC40
    public void get_Success(){} // RVA: 0x7FFAC2C59D00
    public void get_Error(){} // RVA: 0x7FFAC2C58E90
    public void get_Argument(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
}

public class ResultCallback : ValueType
{
    public System.Action continuation; // 0x10
    public bool server; // 0x18
}

public class Retargetable : Object
{
    public UnityEngine.Transform source; // 0x10
    public UnityEngine.Transform destination; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
}

public class Retransmit : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls.DtlsReliableHandshake mOuter; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void ReceivedHandshakeRecord(){} // RVA: 0x7FFACBB33950
}

public class ReturnObservable`1 : Object
{
    public T value;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void Subscribe(){} // RVA: 0x7FFAC2C58F40
}

public class ReverseComparer : ValueType
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC2E8DC40
}

public class RevisionProperty : Property`2
{
    public object Name;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC99A7600
    public void get_Name(){} // RVA: 0x7FFAC99A76B0
}

public class RevokedCertificatesEnumeration : Object
{
    public System.Collections.IEnumerable en; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void GetEnumerator(){} // RVA: 0x7FFACBD453D0
}

public class RevokedCertificatesEnumerator : Object
{
    public System.Collections.IEnumerator Current; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void MoveNext(){} // RVA: 0x7FFACBD45490
    public void Reset(){} // RVA: 0x7FFACBD454E0
    public void get_Current(){} // RVA: 0x7FFACBD45530
}

public class RightShiftByte : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEA850
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RightShiftInt16 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEA470
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RightShiftInt32 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEA5A0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RightShiftInt64 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEA6B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RightShiftSByte : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEA340
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RightShiftUInt16 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEA980
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RightShiftUInt32 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEAAB0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RightShiftUInt64 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFAC8DEAC50
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class RigidTransform : ValueType
{
    public UnityEngine.Vector3 identity; // 0x10
    public UnityEngine.Quaternion rot; // 0x1C

    // ── Methods ──
    public void get_identity(){} // RVA: 0x7FFAC8C377C0
    public void FromLocal(){} // RVA: 0x7FFAC8C37860
    public void .ctor(){} // RVA: 0x7FFAC8C38120 | overloaded x5
    public void ToHmdMatrix44(){} // RVA: 0x7FFAC8C38470
    public void ToHmdMatrix34(){} // RVA: 0x7FFAC8C38640
    public void Equals(){} // RVA: 0x7FFAC8C387E0
    public void GetHashCode(){} // RVA: 0x7FFAC88A10D0
    public void op_Equality(){} // RVA: 0x7FFAC88A11B0
    public void op_Inequality(){} // RVA: 0x7FFAC8C38900
    public void op_Multiply(){} // RVA: 0x7FFAC8C396C0 | overloaded x2
    public void Inverse(){} // RVA: 0x7FFAC8C38CB0
    public void GetInverse(){} // RVA: 0x7FFAC8C38F20
    public void Multiply(){} // RVA: 0x7FFAC8C38F60
    public void InverseTransformPoint(){} // RVA: 0x7FFAC8C39250
    public void TransformPoint(){} // RVA: 0x7FFAC8C394D0
    public void Interpolate(){} // RVA: 0x7FFAC8C39850 | overloaded x2
}

public class Rigidbone : Object
{
    public UnityEngine.Rigidbody r; // 0x10
    public UnityEngine.Transform t; // 0x18
    public UnityEngine.Collider collider; // 0x20
    public UnityEngine.Joint joint; // 0x28
    public UnityEngine.Rigidbody c; // 0x30
    public bool updateAnchor; // 0x38
    public UnityEngine.Vector3 deltaPosition; // 0x3C
    public UnityEngine.Quaternion deltaRotation; // 0x48
    public float deltaTime; // 0x58
    public UnityEngine.Vector3 lastPosition; // 0x5C
    public UnityEngine.Quaternion lastRotation; // 0x68

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC30847C0
    public void RecordVelocity(){} // RVA: 0x7FFAC3084CA0
    public void WakeUp(){} // RVA: 0x7FFAC3084F20
}

public class RoomLayout : ValueType
{
    public System.Guid floorUuid; // 0x10
    public System.Guid ceilingUuid; // 0x20
    public System.Guid[] wallUuids; // 0x30
}

public class RoomLayoutInformation : Object
{
    public OVRScenePlane Floor; // 0x10
    public OVRScenePlane Ceiling; // 0x18
    public System.Collections.Generic.List`1<OVRScenePlane> Walls; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8924000
}

public class RoomLayoutInternal : ValueType
{
    public System.Guid floorUuid; // 0x10
    public System.Guid ceilingUuid; // 0x20
    public int wallUuidCapacityInput; // 0x30
    public int wallUuidCountOutput; // 0x34
    public UIntPtr wallUuids; // 0x38
}

public class RotationBySpeedModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC9957BC0
    public void set_enabled(){} // RVA: 0x7FFAC9957C10
    public void get_x(){} // RVA: 0x7FFAC9957C70
    public void set_x(){} // RVA: 0x7FFAC9957CE0
    public void get_xMultiplier(){} // RVA: 0x7FFAC9957D40
    public void set_xMultiplier(){} // RVA: 0x7FFAC9957D90
    public void get_y(){} // RVA: 0x7FFAC9957DF0
    public void set_y(){} // RVA: 0x7FFAC9957E60
    public void get_yMultiplier(){} // RVA: 0x7FFAC9957EC0
    public void set_yMultiplier(){} // RVA: 0x7FFAC9957F10
    public void get_z(){} // RVA: 0x7FFAC9957F70
    public void set_z(){} // RVA: 0x7FFAC9957FE0
    public void get_zMultiplier(){} // RVA: 0x7FFAC9958040
    public void set_zMultiplier(){} // RVA: 0x7FFAC9958090
    public void get_separateAxes(){} // RVA: 0x7FFAC99580F0
    public void set_separateAxes(){} // RVA: 0x7FFAC9958140
    public void get_range(){} // RVA: 0x7FFAC99581A0
    public void set_range(){} // RVA: 0x7FFAC9958200
    public void get_enabled_Injected(){} // RVA: 0x7FFAC9957BC0
    public void set_enabled_Injected(){} // RVA: 0x7FFAC9957C10
    public void get_x_Injected(){} // RVA: 0x7FFAC9958260
    public void set_x_Injected(){} // RVA: 0x7FFAC99582C0
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFAC9957D40
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFAC9957D90
    public void get_y_Injected(){} // RVA: 0x7FFAC9958320
    public void set_y_Injected(){} // RVA: 0x7FFAC9958380
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFAC9957EC0
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFAC9957F10
    public void get_z_Injected(){} // RVA: 0x7FFAC99583E0
    public void set_z_Injected(){} // RVA: 0x7FFAC9958440
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFAC9958040
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFAC9958090
    public void get_separateAxes_Injected(){} // RVA: 0x7FFAC99580F0
    public void set_separateAxes_Injected(){} // RVA: 0x7FFAC9958140
    public void get_range_Injected(){} // RVA: 0x7FFAC99584A0
    public void set_range_Injected(){} // RVA: 0x7FFAC9958500
}

public class RotationOffset : Offset
{
    public int curveIndex; // 0x50
    public RotationOffsetLink[] offsetLinks; // 0x58
    public UnityEngine.Rigidbody rigidbody; // 0x60

    // ── Methods ──
    public void GetLength(){} // RVA: 0x7FFAC3091320
    public void CrossFadeStart(){} // RVA: 0x7FFAC30914C0
    public void OnApply(){} // RVA: 0x7FFAC3091510
    public void .ctor(){} // RVA: 0x7FFAC308F1F0
}

public class RotationOffsetLink : Object
{
    public 0x6B1C0A10 rotationOffset; // 0x10
    public float weight; // 0x14
    public UnityEngine.Quaternion lastValue; // 0x18
    public UnityEngine.Quaternion current; // 0x28

    // ── Methods ──
    public void Apply(){} // RVA: 0x7FFAC3091B30
    public void CrossFadeStart(){} // RVA: 0x7FFAC3091CD0
    public void .ctor(){} // RVA: 0x7FFAC3091CE0
}

public class RotationOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC99573A0
    public void set_enabled(){} // RVA: 0x7FFAC99573F0
    public void get_x(){} // RVA: 0x7FFAC9957450
    public void set_x(){} // RVA: 0x7FFAC99574C0
    public void get_xMultiplier(){} // RVA: 0x7FFAC9957520
    public void set_xMultiplier(){} // RVA: 0x7FFAC9957570
    public void get_y(){} // RVA: 0x7FFAC99575D0
    public void set_y(){} // RVA: 0x7FFAC9957640
    public void get_yMultiplier(){} // RVA: 0x7FFAC99576A0
    public void set_yMultiplier(){} // RVA: 0x7FFAC99576F0
    public void get_z(){} // RVA: 0x7FFAC9957750
    public void set_z(){} // RVA: 0x7FFAC99577C0
    public void get_zMultiplier(){} // RVA: 0x7FFAC9957820
    public void set_zMultiplier(){} // RVA: 0x7FFAC9957870
    public void get_separateAxes(){} // RVA: 0x7FFAC99578D0
    public void set_separateAxes(){} // RVA: 0x7FFAC9957920
    public void get_enabled_Injected(){} // RVA: 0x7FFAC99573A0
    public void set_enabled_Injected(){} // RVA: 0x7FFAC99573F0
    public void get_x_Injected(){} // RVA: 0x7FFAC9957980
    public void set_x_Injected(){} // RVA: 0x7FFAC99579E0
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFAC9957520
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFAC9957570
    public void get_y_Injected(){} // RVA: 0x7FFAC9957A40
    public void set_y_Injected(){} // RVA: 0x7FFAC9957AA0
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFAC99576A0
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFAC99576F0
    public void get_z_Injected(){} // RVA: 0x7FFAC9957B00
    public void set_z_Injected(){} // RVA: 0x7FFAC9957B60
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFAC9957820
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFAC9957870
    public void get_separateAxes_Injected(){} // RVA: 0x7FFAC99578D0
    public void set_separateAxes_Injected(){} // RVA: 0x7FFAC9957920
}

public class Rotor : ValueType
{
    public UnityEngine.Transform transform; // 0x10
    public float pitchModifier; // 0x18
    public float rollModifier; // 0x1C
    public float maxSpeed; // 0x20
    public UnityEngine.Quaternion startingRotation; // 0x24

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC363AD50
    public void InternalEquals(){} // RVA: 0x7FFAC363B180
    public void DefaultEquals(){} // RVA: 0x7FFAC363B5C0
    public void GetHashCode(){} // RVA: 0x7FFAC363BA00
    public void InternalGetHashCode(){} // RVA: 0x7FFAC363BE40
    public void ToString(){} // RVA: 0x7FFAC363C280
}

public class RoutePoint : ValueType
{
    public UnityEngine.Vector3 position; // 0x10
    public UnityEngine.Vector3 direction; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F2ADF0
}

public class Row : Object
{
    public UnityEngine.UIElements.ObjectPool`1<Row> offsetX;
    public int offsetY; // 0x10
    public int width; // 0x14
    public int height; // 0x18
    public int <height>k__BackingField; // 0x1C
    public int Cursor; // 0x20

    // ── Methods ──
    public void get_offsetX(){} // RVA: 0x7FFAC2F6E5C0
    public void set_offsetX(){} // RVA: 0x7FFAC2F240C0
    public void get_offsetY(){} // RVA: 0x7FFAC33D5A20
    public void set_offsetY(){} // RVA: 0x7FFAC33D4990
    public void get_width(){} // RVA: 0x7FFAC3157800
    public void set_width(){} // RVA: 0x7FFAC392CD10
    public void set_height(){} // RVA: 0x7FFAC44474D0
    public void Acquire(){} // RVA: 0x7FFAC9BC6CC0
    public void Release(){} // RVA: 0x7FFAC9BC6DC0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void .cctor(){} // RVA: 0x7FFAC9BC6E60
}

public class RowDiffIdUsageSection : ValueType
{
    public System.Data.DataTable _targetTable; // 0x10

    // ── Methods ──
    public void Prepare(){} // RVA: 0x7FFAC8E78AE0
}

public class Rune : ValueType
{
    public int value; // 0x10

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC9512CF0
    public void GetHashCode(){} // RVA: 0x7FFAC4420210
}

public class RuntimePanelAccess : Object
{
    public UnityEngine.UIElements.PanelSettings isInitialized; // 0x10
    public UnityEngine.UIElements.BaseRuntimePanel panel; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void get_isInitialized(){} // RVA: 0x7FFAC4860B40
    public void get_panel(){} // RVA: 0x7FFAC9B995C0
    public void DisposePanel(){} // RVA: 0x7FFAC9B99A80
    public void SetTargetTexture(){} // RVA: 0x7FFAC9B99B40
    public void SetSortingPriority(){} // RVA: 0x7FFAC9B99BC0
    public void SetTargetDisplay(){} // RVA: 0x7FFAC9B99C00
    public void CreateRelatedRuntimePanel(){} // RVA: 0x7FFAC9B99C30
    public void DisposeRelatedPanel(){} // RVA: 0x7FFAC9B99D30
    public void MarkPotentiallyEmpty(){} // RVA: 0x7FFAC9B99D90
}

public class RuntimeVariables : Object
{
    public System.Runtime.CompilerServices.IStrongBox[] System.Runtime.CompilerServices.IRuntimeVariables.Count; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void System.Runtime.CompilerServices.IRuntimeVariables.get_Count(){} // RVA: 0x7FFAC3510620
    public void System.Runtime.CompilerServices.IRuntimeVariables.get_Item(){} // RVA: 0x7FFAC8DF5080
    public void System.Runtime.CompilerServices.IRuntimeVariables.set_Item(){} // RVA: 0x7FFAC8DF50F0
}

public class RuntimeVariablesExpressionProxy : Object
{
    public System.Linq.Expressions.RuntimeVariablesExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D72380
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
    public void get_Variables(){} // RVA: 0x7FFAC3511350
}
