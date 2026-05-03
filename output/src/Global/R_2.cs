// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 54
// Methods: 284

public class RequestLightsDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84C73440
    public void Invoke(){} // RVA: 0x7FFE83F852E0
}

public class RequestObject : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void ToRequest(){} // RVA: 0x7FFE8A3E2DA0
}

public class RequiredValue : ApiModel
{
    public string _value; // 0x68
    public VRC.Core.ApiLocalizableString _error; // 0x70

    // ── Methods ──
    public void get_value(){} // RVA: 0x7FFE81176D50
    public void set_value(){} // RVA: 0x7FFE81176D60
    public void get_error(){} // RVA: 0x7FFE811C3590
    public void set_error(){} // RVA: 0x7FFE811C35A0
    public void .ctor(){} // RVA: 0x7FFE8A2D8770
}

public class ReservedName : ApiModel
{
    public string _displayName; // 0x68
    public System.DateTime _expires; // 0x70

    // ── Methods ──
    public void get_displayName(){} // RVA: 0x7FFE81176D50
    public void set_displayName(){} // RVA: 0x7FFE81176D60
    public void get_expires(){} // RVA: 0x7FFE811C3590
    public void set_expires(){} // RVA: 0x7FFE82C95C70
    public void .ctor(){} // RVA: 0x7FFE8A2BE310
}

public class ReservedRange : Object
{
    public Google.Protobuf.MessageParser`1<ReservedRange> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public int StartDefaultValue; // 0x8
    public int start_; // 0x1C
    public int EndDefaultValue; // 0xC
    public int end_; // 0x20

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE8659DCF0
    public void get_Descriptor(){} // RVA: 0x7FFE8659DD50
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8659DDD0
    public void .ctor(){} // RVA: 0x7FFE8659DE80 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE8659DF70
    public void get_Start(){} // RVA: 0x7FFE8659E090
    public void set_Start(){} // RVA: 0x7FFE8659D0A0
    public void get_HasStart(){} // RVA: 0x7FFE8659D0B0
    public void ClearStart(){} // RVA: 0x7FFE8659D0C0
    public void get_End(){} // RVA: 0x7FFE8659E100
    public void set_End(){} // RVA: 0x7FFE8659D140
    public void get_HasEnd(){} // RVA: 0x7FFE8659D150
    public void ClearEnd(){} // RVA: 0x7FFE8659D160
    public void Equals(){} // RVA: 0x7FFE8659E260 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE8659E320
    public void ToString(){} // RVA: 0x7FFE8659E390
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8659E3E0
    public void CalculateSize(){} // RVA: 0x7FFE8659E470
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8659E650
    public void .cctor(){} // RVA: 0x7FFE8659E6F0
}

public class ReservedWords : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84896780
}

public class ResetFrameStatsAfterPresent : ValueType
{
}

public class ResetInputAxis : ValueType
{
}

public class ResolutionStruct : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE826F6E30
    public void InternalEquals(){} // RVA: 0x7FFE826F6E30
    public void DefaultEquals(){} // RVA: 0x7FFE826F6E30
    public void GetHashCode(){} // RVA: 0x7FFE826F6E30
    public void .ctor(){} // RVA: 0x7FFE826F6EA0 | overloaded x2
    public void ToString(){} // RVA: 0x7FFE826F6EB0
    public void ToString_CEB5E2A0FADE(){} // RVA: 0x7FFE826F6E30
    // ── Unresolved (hash) ──
    public void m_78A(){} // RVA: 0x7FFE826F6E30
}

public class ResolveContext : ValueType
{
}

public class ResolveEventHolder : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Resource : ValueType
{
}

public class ResourceEnumerator : Object
{
    public System.Resources.ResourceReader _reader; // 0x10
    public bool _currentIsValid; // 0x18
    public int _currentName; // 0x1C
    public int _dataPosition; // 0x20
    public object field_4; // 0x55B

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE868980C0
    public void MoveNext(){} // RVA: 0x7FFE86898130
    public void get_Key(){} // RVA: 0x7FFE86898180
    public void get_Current(){} // RVA: 0x7FFE868982E0
    public void get_DataPosition(){} // RVA: 0x7FFE8151D690
    public void get_Entry(){} // RVA: 0x7FFE86898340
    public void get_Value(){} // RVA: 0x7FFE868988C0
    public void Reset(){} // RVA: 0x7FFE86898A20
}

public class ResourceManagerMediator : Object
{
    public System.Resources.ResourceManager _rm; // 0x10
    public object field_1; // 0x54E
    public object field_2; // 0x54F
    public object field_3; // 0x550
    public object field_4; // 0x551
    public object field_5; // 0x552
    public object field_6; // 0x553
    public object field_7; // 0x554
    public object field_8; // 0x555
    public object field_9; // 0x556
    public object field_10; // 0x557

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86893240
    public void get_ModuleDir(){} // RVA: 0x7FFE8189B9F0
    public void get_LocationInfo(){} // RVA: 0x7FFE8189C060
    public void get_UserResourceSet(){} // RVA: 0x7FFE8189B8F0
    public void get_BaseNameField(){} // RVA: 0x7FFE8189BB90
    public void get_NeutralResourcesCulture(){} // RVA: 0x7FFE81CCBEC0
    public void GetResourceFileName(){} // RVA: 0x7FFE868932F0
    public void get_LookedForSatelliteContractVersion(){} // RVA: 0x7FFE81CFD820
    public void set_LookedForSatelliteContractVersion(){} // RVA: 0x7FFE86893320
    public void get_SatelliteContractVersion(){} // RVA: 0x7FFE86893340
    public void set_SatelliteContractVersion(){} // RVA: 0x7FFE86893360
    public void ObtainSatelliteContractVersion(){} // RVA: 0x7FFE868933D0
    public void get_FallbackLoc(){} // RVA: 0x7FFE86893420
    public void get_CallingAssembly(){} // RVA: 0x7FFE8170F950
    public void get_MainAssembly(){} // RVA: 0x7FFE86893440
    public void get_BaseName(){} // RVA: 0x7FFE81588A80
}

public class ResourceProvider : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8526B7D0
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class ResourceRequestAwaiter : ValueType
{
    public UnityEngine.ResourceRequest asyncOperation; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81E76050
    public void get_IsCompleted(){} // RVA: 0x7FFE87877440
    public void GetResult(){} // RVA: 0x7FFE8787A880
    public void OnCompleted(){} // RVA: 0x7FFE8787AA10
    public void UnsafeOnCompleted(){} // RVA: 0x7FFE8787AA20
}

public class ResourceRequestConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<ResourceRequestConfiguredSource> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE8787AB50
    public void .ctor(){} // RVA: 0x7FFE8787ACD0
    public void Create(){} // RVA: 0x7FFE8787AD90
    public void GetResult(){} // RVA: 0x7FFE8787B300
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE8787B580
    public void GetStatus(){} // RVA: 0x7FFE8787B590
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8787B5E0
    public void OnCompleted(){} // RVA: 0x7FFE8787B620
    public void MoveNext(){} // RVA: 0x7FFE8787B6A0
    public void TryReturn(){} // RVA: 0x7FFE8787B7F0
    public void Continuation(){} // RVA: 0x7FFE8787B960
}

public class Resources : ValueType
{
}

public class Response : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE812572A0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE8A530F00
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class ResponseObject : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A3DF6E0 | overloaded x3
    public void ToResponse(){} // RVA: 0x7FFE8A3DFCF0
}

public class Result : Object
{
    public 0x66536C1C<T> _status;
    public System.Runtime.ExceptionServices.ExceptionDispatchInfo _error;
    public T _argument;
    public object field_3; // 0x557

    // ── Methods ──
    public void get_Status(){} // RVA: 0x7FFE810A1420
    public void get_Success(){} // RVA: 0x7FFE80E2F150
    public void get_Error(){} // RVA: 0x7FFE80E2E2E0
    public void get_Argument(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x2
}

public class ResultCallback : ValueType
{
}

public class Retargetable : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
}

public class Retransmit : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void ReceivedHandshakeRecord(){} // RVA: 0x7FFE89F8CF70
}

public class ReturnObservable`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void Subscribe(){} // RVA: 0x7FFE80E2E390
}

public class ReverseComparer : ValueType
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFE810A1420
}

public class RevisionProperty : Property`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87D4FEA0
    public void get_Name(){} // RVA: 0x7FFE87D4FF50
}

public class RevokedCertificatesEnumeration : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void GetEnumerator(){} // RVA: 0x7FFE8A19E9F0
}

public class RevokedCertificatesEnumerator : Object
{
    public System.Collections.IEnumerator e; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void MoveNext(){} // RVA: 0x7FFE8A19EAB0
    public void Reset(){} // RVA: 0x7FFE8A19EB00
    public void get_Current(){} // RVA: 0x7FFE8A19EB50
}

public class RightShiftByte : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87192C80
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RightShiftInt16 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871928A0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RightShiftInt32 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE871929D0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RightShiftInt64 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87192AE0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RightShiftSByte : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87192770
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RightShiftUInt16 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87192DB0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RightShiftUInt32 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87192EE0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RightShiftUInt64 : RightShiftInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFE87193080
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class RigidTransform : ValueType
{
    public UnityEngine.Vector3 pos; // 0x10

    // ── Methods ──
    public void get_identity(){} // RVA: 0x7FFE86FDFCE0
    public void FromLocal(){} // RVA: 0x7FFE86FDFD80
    public void .ctor(){} // RVA: 0x7FFE86FE0640 | overloaded x5
    public void ToHmdMatrix44(){} // RVA: 0x7FFE86FE0990
    public void ToHmdMatrix34(){} // RVA: 0x7FFE86FE0B60
    public void Equals(){} // RVA: 0x7FFE86FE0D00
    public void GetHashCode(){} // RVA: 0x7FFE86C4A7C0
    public void op_Equality(){} // RVA: 0x7FFE86C4A8A0
    public void op_Inequality(){} // RVA: 0x7FFE86FE0E20
    public void op_Multiply(){} // RVA: 0x7FFE86FE1BE0 | overloaded x2
    public void Inverse(){} // RVA: 0x7FFE86FE11D0
    public void GetInverse(){} // RVA: 0x7FFE86FE1440
    public void Multiply(){} // RVA: 0x7FFE86FE1480
    public void InverseTransformPoint(){} // RVA: 0x7FFE86FE1770
    public void TransformPoint(){} // RVA: 0x7FFE86FE19F0
    public void Interpolate(){} // RVA: 0x7FFE86FE1D70 | overloaded x2
}

public class Rigidbone : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8125E7C0
    public void RecordVelocity(){} // RVA: 0x7FFE8125ECA0
    public void WakeUp(){} // RVA: 0x7FFE8125EF20
}

public class RoomLayout : ValueType
{
}

public class RoomLayoutInformation : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86CCD6A0
}

public class RoomLayoutInternal : ValueType
{
}

public class RotationBySpeedModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x154
    public object field_2; // 0x155
    public object field_3; // 0x156
    public object field_4; // 0x157
    public object field_5; // 0x158
    public object field_6; // 0x159
    public object field_7; // 0x15A
    public object field_8; // 0x15B

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87D00460
    public void set_enabled(){} // RVA: 0x7FFE87D004B0
    public void get_x(){} // RVA: 0x7FFE87D00510
    public void set_x(){} // RVA: 0x7FFE87D00580
    public void get_xMultiplier(){} // RVA: 0x7FFE87D005E0
    public void set_xMultiplier(){} // RVA: 0x7FFE87D00630
    public void get_y(){} // RVA: 0x7FFE87D00690
    public void set_y(){} // RVA: 0x7FFE87D00700
    public void get_yMultiplier(){} // RVA: 0x7FFE87D00760
    public void set_yMultiplier(){} // RVA: 0x7FFE87D007B0
    public void get_z(){} // RVA: 0x7FFE87D00810
    public void set_z(){} // RVA: 0x7FFE87D00880
    public void get_zMultiplier(){} // RVA: 0x7FFE87D008E0
    public void set_zMultiplier(){} // RVA: 0x7FFE87D00930
    public void get_separateAxes(){} // RVA: 0x7FFE87D00990
    public void set_separateAxes(){} // RVA: 0x7FFE87D009E0
    public void get_range(){} // RVA: 0x7FFE87D00A40
    public void set_range(){} // RVA: 0x7FFE87D00AA0
    public void get_enabled_Injected(){} // RVA: 0x7FFE87D00460
    public void set_enabled_Injected(){} // RVA: 0x7FFE87D004B0
    public void get_x_Injected(){} // RVA: 0x7FFE87D00B00
    public void set_x_Injected(){} // RVA: 0x7FFE87D00B60
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFE87D005E0
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFE87D00630
    public void get_y_Injected(){} // RVA: 0x7FFE87D00BC0
    public void set_y_Injected(){} // RVA: 0x7FFE87D00C20
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFE87D00760
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFE87D007B0
    public void get_z_Injected(){} // RVA: 0x7FFE87D00C80
    public void set_z_Injected(){} // RVA: 0x7FFE87D00CE0
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFE87D008E0
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFE87D00930
    public void get_separateAxes_Injected(){} // RVA: 0x7FFE87D00990
    public void set_separateAxes_Injected(){} // RVA: 0x7FFE87D009E0
    public void get_range_Injected(){} // RVA: 0x7FFE87D00D40
    public void set_range_Injected(){} // RVA: 0x7FFE87D00DA0
}

public class RotationOffset : Offset
{
    // ── Methods ──
    public void GetLength(){} // RVA: 0x7FFE8126B320
    public void CrossFadeStart(){} // RVA: 0x7FFE8126B4C0
    public void OnApply(){} // RVA: 0x7FFE8126B510
    public void .ctor(){} // RVA: 0x7FFE812691F0
}

public class RotationOffsetLink : Object
{
    // ── Methods ──
    public void Apply(){} // RVA: 0x7FFE8126BB30
    public void CrossFadeStart(){} // RVA: 0x7FFE8126BCD0
    public void .ctor(){} // RVA: 0x7FFE8126BCE0
}

public class RotationOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x14C
    public object field_2; // 0x14D
    public object field_3; // 0x14E
    public object field_4; // 0x14F
    public object field_5; // 0x150
    public object field_6; // 0x151
    public object field_7; // 0x152

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CFFC40
    public void set_enabled(){} // RVA: 0x7FFE87CFFC90
    public void get_x(){} // RVA: 0x7FFE87CFFCF0
    public void set_x(){} // RVA: 0x7FFE87CFFD60
    public void get_xMultiplier(){} // RVA: 0x7FFE87CFFDC0
    public void set_xMultiplier(){} // RVA: 0x7FFE87CFFE10
    public void get_y(){} // RVA: 0x7FFE87CFFE70
    public void set_y(){} // RVA: 0x7FFE87CFFEE0
    public void get_yMultiplier(){} // RVA: 0x7FFE87CFFF40
    public void set_yMultiplier(){} // RVA: 0x7FFE87CFFF90
    public void get_z(){} // RVA: 0x7FFE87CFFFF0
    public void set_z(){} // RVA: 0x7FFE87D00060
    public void get_zMultiplier(){} // RVA: 0x7FFE87D000C0
    public void set_zMultiplier(){} // RVA: 0x7FFE87D00110
    public void get_separateAxes(){} // RVA: 0x7FFE87D00170
    public void set_separateAxes(){} // RVA: 0x7FFE87D001C0
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CFFC40
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CFFC90
    public void get_x_Injected(){} // RVA: 0x7FFE87D00220
    public void set_x_Injected(){} // RVA: 0x7FFE87D00280
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFE87CFFDC0
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFE87CFFE10
    public void get_y_Injected(){} // RVA: 0x7FFE87D002E0
    public void set_y_Injected(){} // RVA: 0x7FFE87D00340
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFE87CFFF40
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFE87CFFF90
    public void get_z_Injected(){} // RVA: 0x7FFE87D003A0
    public void set_z_Injected(){} // RVA: 0x7FFE87D00400
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFE87D000C0
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFE87D00110
    public void get_separateAxes_Injected(){} // RVA: 0x7FFE87D00170
    public void set_separateAxes_Injected(){} // RVA: 0x7FFE87D001C0
}

public class Rotor : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE81789BC0
    public void InternalEquals(){} // RVA: 0x7FFE8178A000
    public void DefaultEquals(){} // RVA: 0x7FFE8178A440
    public void GetHashCode(){} // RVA: 0x7FFE8178A880
    public void InternalGetHashCode(){} // RVA: 0x7FFE8178ACB0
    public void ToString(){} // RVA: 0x7FFE8178B0F0
    public void GetHashCodeOfPtr(){} // RVA: 0x7FFE8178B530
    public void ValidateStructPointers(){} // RVA: 0x7FFE8178BDB0
    // ── Unresolved (hash) ──
    public void m_0DF(){} // RVA: 0x7FFE8178B970
}

public class RoutePoint : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81104DF0
}

public class Row : Object
{
    public UnityEngine.UIElements.ObjectPool`1<Row> s_Pool;
    public int _offsetX; // 0x10
    public int _offsetY; // 0x14
    public int _width; // 0x18

    // ── Methods ──
    public void get_offsetX(){} // RVA: 0x7FFE811485C0
    public void set_offsetX(){} // RVA: 0x7FFE810FE0C0
    public void get_offsetY(){} // RVA: 0x7FFE8164B230
    public void set_offsetY(){} // RVA: 0x7FFE8164E0F0
    public void get_width(){} // RVA: 0x7FFE813DB630
    public void set_width(){} // RVA: 0x7FFE8144DF00
    public void set_height(){} // RVA: 0x7FFE82717690
    public void Acquire(){} // RVA: 0x7FFE87F6F570
    public void Release(){} // RVA: 0x7FFE87F6F670
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void .cctor(){} // RVA: 0x7FFE87F6F710
}

public class RowDiffIdUsageSection : ValueType
{
    // ── Methods ──
    public void Prepare(){} // RVA: 0x7FFE87220F10
}

public class Rune : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE878BB430
    public void GetHashCode(){} // RVA: 0x7FFE826F4220
}

public class RuntimePanelAccess : Object
{
    public UnityEngine.UIElements.PanelSettings m_Settings; // 0x10
    public UnityEngine.UIElements.BaseRuntimePanel m_RuntimePanel; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void get_isInitialized(){} // RVA: 0x7FFE82AC8EE0
    public void get_panel(){} // RVA: 0x7FFE87F41E70
    public void DisposePanel(){} // RVA: 0x7FFE87F42330
    public void SetTargetTexture(){} // RVA: 0x7FFE87F423F0
    public void SetSortingPriority(){} // RVA: 0x7FFE87F42470
    public void SetTargetDisplay(){} // RVA: 0x7FFE87F424B0
    public void CreateRelatedRuntimePanel(){} // RVA: 0x7FFE87F424E0
    public void DisposeRelatedPanel(){} // RVA: 0x7FFE87F425E0
    public void MarkPotentiallyEmpty(){} // RVA: 0x7FFE87F42640
}

public class RuntimeVariables : Object
{
    public System.Runtime.CompilerServices.IStrongBox[] _boxes; // 0x10
    public object field_1; // 0x38B

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void System.Runtime.CompilerServices.IRuntimeVariables.get_Count(){} // RVA: 0x7FFE81CCB610
    public void System.Runtime.CompilerServices.IRuntimeVariables.get_Item(){} // RVA: 0x7FFE8719D4B0
    public void System.Runtime.CompilerServices.IRuntimeVariables.set_Item(){} // RVA: 0x7FFE8719D520
}

public class RuntimeVariablesExpressionProxy : Object
{
    public System.Linq.Expressions.RuntimeVariablesExpression _node; // 0x10
    public object field_1; // 0x116
    public object field_2; // 0x117
    public object field_3; // 0x118
    public object field_4; // 0x119

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8711A7B0
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Type(){} // RVA: 0x7FFE815888E0
    public void get_Variables(){} // RVA: 0x7FFE8189BB90
}
