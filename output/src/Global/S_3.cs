// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 398

public class SharedStatic : Object
{
    // ── Methods ──
    public void GetOrCreateSharedStaticInternal(){} // RVA: 0x7FFAC9850E80
}

public class SharedStatic`1 : ValueType
{
    public void* Data;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Data(){} // RVA: 0x7FFAC2C58E90
    public void GetOrCreate(){} // RVA: 0x7FFAC2E8DC40
}

public class SharedStatics : Object
{
}

public class SheetHandleKey : ValueType
{
    public int sheetInstanceID; // 0x10
    public int index; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9B1CFF0
}

public class SheetHandleKeyComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC9B1D030
    public void GetHashCode(){} // RVA: 0x7FFAC5DA0260
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SigStream : BaseOutputStream
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner s; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBB2A940
    public void WriteByte(){} // RVA: 0x7FFACBB3E200
    public void Write(){} // RVA: 0x7FFACBB3E260
}

public class SignalSource : Object
{
    public Cinemachine.CinemachineImpulseDefinition SignalDuration; // 0x10
    public UnityEngine.Vector3 m_Velocity; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4857880
    public void get_SignalDuration(){} // RVA: 0x7FFAC48578F0
    public void GetSignal(){} // RVA: 0x7FFAC4857910
}

public class SignedData : Object
{
    public byte Certificates; // 0x10
    public string ContentInfo; // 0x18
    public ContentInfo HashName; // 0x20
    public Mono.Security.X509.X509CertificateCollection SignerInfo; // 0x28
    public System.Collections.ArrayList crls; // 0x30
    public SignerInfo signerInfo; // 0x38
    public bool mda; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8351550
    public void get_Certificates(){} // RVA: 0x7FFAC2F4F130
    public void get_ContentInfo(){} // RVA: 0x7FFAC2F4F0C0
    public void set_HashName(){} // RVA: 0x7FFAC8351DC0
    public void get_SignerInfo(){} // RVA: 0x7FFAC31D0140
    public void OidToName(){} // RVA: 0x7FFAC8351EA0
}

public class SignerInf : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedGenerator DigestAlgorithmID; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISignatureFactory SignedAttributes; // 0x18
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignerIdentifier UnsignedAttributes; // 0x20
    public string digestOID; // 0x28
    public string encOID; // 0x30
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAttributeTableGenerator sAttr; // 0x38
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsAttr; // 0x40
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBCAACD0 | overloaded x2
    public void get_DigestAlgorithmID(){} // RVA: 0x7FFACBCAB120
    public void get_SignedAttributes(){} // RVA: 0x7FFAC31D0140
    public void get_UnsignedAttributes(){} // RVA: 0x7FFAC2F9E740
    public void ToSignerInfo(){} // RVA: 0x7FFACBCAB200
}

public class SignerInfo : Object
{
    public byte IssuerName; // 0x10
    public string SerialNumber; // 0x18
    public System.Collections.ArrayList AuthenticatedAttributes; // 0x20
    public System.Collections.ArrayList HashName; // 0x28
    public byte[] Signature; // 0x30
    public string UnauthenticatedAttributes; // 0x38
    public byte[] Version; // 0x40
    public byte[] ski; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8352290 | overloaded x2
    public void get_IssuerName(){} // RVA: 0x7FFAC31D0140
    public void get_SerialNumber(){} // RVA: 0x7FFAC8352760
    public void get_AuthenticatedAttributes(){} // RVA: 0x7FFAC2F4F0C0
    public void get_HashName(){} // RVA: 0x7FFAC2F247C0
    public void set_HashName(){} // RVA: 0x7FFAC2F87E80
    public void get_Signature(){} // RVA: 0x7FFAC83527E0
    public void get_UnauthenticatedAttributes(){} // RVA: 0x7FFAC2F4F130
    public void get_Version(){} // RVA: 0x7FFAC2FEB5E0
}

public class SignerInfoGeneratorImpl : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator outer; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignerIdentifier _signerIdentifier; // 0x18
    public string _digestOID; // 0x20
    public string _encOID; // 0x28
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAttributeTableGenerator _sAttr; // 0x30
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAttributeTableGenerator _unsAttr; // 0x38
    public string _encName; // 0x40
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISigner _sig; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBCB1400
    public void Generate(){} // RVA: 0x7FFACBCB1AD0
}

public class SigningKey : ValueType
{
    public byte[] Key; // 0x10

    // ── Methods ──
    public void get_Key(){} // RVA: 0x7FFAC3AD9F60
    public void .ctor(){} // RVA: 0x7FFACBE52310
}

public class SimplePropertyDescriptor : PropertyDescriptor
{
    public System.Type ComponentType; // 0x88
    public System.Type IsReadOnly; // 0x90

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9434E60 | overloaded x2
    public void get_ComponentType(){} // RVA: 0x7FFAC2F60010
    public void get_IsReadOnly(){} // RVA: 0x7FFAC9434F50
    public void get_PropertyType(){} // RVA: 0x7FFAC32EF640
    public void CanResetValue(){} // RVA: 0x7FFAC9435030
    public void ResetValue(){} // RVA: 0x7FFAC94351F0
    public void ShouldSerializeValue(){} // RVA: 0x7FFAC2F21320
}

public class SimpleScheduledItem : VisualElementScheduledItem`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9BF4450
    public void PerformTimerUpdate(){} // RVA: 0x7FFAC9BF44B0
}

public class SingleAnchorDelegatePair : ValueType
{
    public OVRSpatialAnchor Anchor; // 0x10
    public System.Action`2<OVRSpatialAnchor,bool> Delegate; // 0x18
}

public class SingleByteUnion : ValueType
{
    public byte Byte0; // 0x10
    public byte Byte1; // 0x11
    public byte Byte2; // 0x12
    public byte Byte3; // 0x13
    public float Value; // 0x10
}

public class SingleConsumerUnboundedChannelReader : ChannelReader`1
{
    public System.Action`1<object> Completion;
    public Cysharp.Threading.Tasks.SingleConsumerUnboundedChannel`1<T> parent;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<bool> core;
    public bool isWaiting;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_Completion(){} // RVA: 0x7FFAC2C588A0
    public void TryRead(){} // RVA: 0x7FFAC2C59F60
    public void WaitToReadAsync(){}
    public void SingalContinuation(){} // RVA: 0x7FFAC2C70980
    public void SingalCancellation(){} // RVA: 0x7FFAC2C70BF0
    public void SingalCompleted(){} // RVA: 0x7FFAC2C70A40
    public void ReadAllAsync(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource<System.Boolean>.GetResult(){} // RVA: 0x7FFAC2C5AB80
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void CancellationCallback(){} // RVA: 0x7FFAC2C70A10
}

public class SingleConsumerUnboundedChannelWriter : ChannelWriter`1
{
    public Cysharp.Threading.Tasks.SingleConsumerUnboundedChannel`1<T> parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void TryWrite(){} // RVA: 0x7FFAC2E8DC40
    public void TryComplete(){} // RVA: 0x7FFAC2C59F60
}

public class SingleObjectEnumerator : Object
{
    public object Current; // 0x10
    public int position; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5923EB0
    public void get_Current(){} // RVA: 0x7FFAC91F8EA0
    public void MoveNext(){} // RVA: 0x7FFAC91F8F00
    public void Reset(){} // RVA: 0x7FFAC47EDC40
}

public class SingleProducerSingleConsumerQueue_DebugView : Object
{
}

public class SingleQueryMatcher : UQueryMatcher
{
    public UnityEngine.UIElements.VisualElement match; // 0x18

    // ── Methods ──
    public void get_match(){} // RVA: 0x7FFAC2F247C0
    public void set_match(){} // RVA: 0x7FFAC2F87E80
    public void Run(){} // RVA: 0x7FFAC9C24500
    public void IsInUse(){} // RVA: 0x7FFAC9C24640
    public void CreateNew(){} // RVA: 0x7FFAC2C58E90
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SingleRange : ValueType
{
    public char First; // 0x10
    public char Last; // 0x12

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC60F0B90
}

public class SingleRangeComparer : Object
{
    public SingleRangeComparer Instance;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Compare(){} // RVA: 0x7FFAC93A89F0
    public void .cctor(){} // RVA: 0x7FFAC93A8A50
}

public class Site : Object
{
    public string Component; // 0x10
    public System.ComponentModel.IComponent Container; // 0x18
    public System.ComponentModel.IContainer DesignMode; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC940A580
    public void get_Component(){} // RVA: 0x7FFAC2F247C0
    public void get_Container(){} // RVA: 0x7FFAC2F4F0C0
    public void GetService(){} // RVA: 0x7FFAC940A680
    public void get_DesignMode(){} // RVA: 0x7FFAC940A7D0
    public void get_FullName(){} // RVA: 0x7FFAC940A8C0
    public void get_Name(){} // RVA: 0x7FFAC2F3C380
    public void set_Name(){} // RVA: 0x7FFAC940A9E0
}

public class Size3f : ValueType
{
    public float w; // 0x10
    public float h; // 0x14
    public float d; // 0x18
    public Size3f zero;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC8907EF0
}

public class SizeBySpeedModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC99567C0
    public void set_enabled(){} // RVA: 0x7FFAC9956810
    public void get_size(){} // RVA: 0x7FFAC9956870
    public void set_size(){} // RVA: 0x7FFAC99568E0
    public void get_sizeMultiplier(){} // RVA: 0x7FFAC9956940
    public void set_sizeMultiplier(){} // RVA: 0x7FFAC9956990
    public void get_x(){} // RVA: 0x7FFAC99569F0
    public void set_x(){} // RVA: 0x7FFAC9956A60
    public void get_xMultiplier(){} // RVA: 0x7FFAC9956AC0
    public void set_xMultiplier(){} // RVA: 0x7FFAC9956B10
    public void get_y(){} // RVA: 0x7FFAC9956B70
    public void set_y(){} // RVA: 0x7FFAC9956BE0
    public void get_yMultiplier(){} // RVA: 0x7FFAC9956C40
    public void set_yMultiplier(){} // RVA: 0x7FFAC9956C90
    public void get_z(){} // RVA: 0x7FFAC9956CF0
    public void set_z(){} // RVA: 0x7FFAC9956D60
    public void get_zMultiplier(){} // RVA: 0x7FFAC9956DC0
    public void set_zMultiplier(){} // RVA: 0x7FFAC9956E10
    public void get_separateAxes(){} // RVA: 0x7FFAC9956E70
    public void set_separateAxes(){} // RVA: 0x7FFAC9956EC0
    public void get_range(){} // RVA: 0x7FFAC9956F20
    public void set_range(){} // RVA: 0x7FFAC9956F80
    public void get_enabled_Injected(){} // RVA: 0x7FFAC99567C0
    public void set_enabled_Injected(){} // RVA: 0x7FFAC9956810
    public void get_size_Injected(){} // RVA: 0x7FFAC9956FE0
    public void set_size_Injected(){} // RVA: 0x7FFAC9957040
    public void get_sizeMultiplier_Injected(){} // RVA: 0x7FFAC9956940
    public void set_sizeMultiplier_Injected(){} // RVA: 0x7FFAC9956990
    public void get_x_Injected(){} // RVA: 0x7FFAC99570A0
    public void set_x_Injected(){} // RVA: 0x7FFAC9957100
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFAC9956AC0
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFAC9956B10
    public void get_y_Injected(){} // RVA: 0x7FFAC9957160
    public void set_y_Injected(){} // RVA: 0x7FFAC99571C0
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFAC9956C40
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFAC9956C90
    public void get_z_Injected(){} // RVA: 0x7FFAC9957220
    public void set_z_Injected(){} // RVA: 0x7FFAC9957280
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFAC9956DC0
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFAC9956E10
    public void get_separateAxes_Injected(){} // RVA: 0x7FFAC9956E70
    public void set_separateAxes_Injected(){} // RVA: 0x7FFAC9956EC0
    public void get_range_Injected(){} // RVA: 0x7FFAC99572E0
    public void set_range_Injected(){} // RVA: 0x7FFAC9957340
}

public class SizeGroup : Object
{
    public System.Collections.Generic.Stack`1<T[]> Count;
    public int LowWaterMark;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFAC2C59960
    public void TryGetArray(){} // RVA: 0x7FFAC2C58E90
    public void ReturnArray(){} // RVA: 0x7FFAC2C70A40
    public void Cleanup(){} // RVA: 0x7FFAC2C59960
    public void Contains(){} // RVA: 0x7FFAC2C59F60
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class SizeOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_enabled(){} // RVA: 0x7FFAC9955D60
    public void set_enabled(){} // RVA: 0x7FFAC9955DB0
    public void get_size(){} // RVA: 0x7FFAC9955E10
    public void set_size(){} // RVA: 0x7FFAC9955E80
    public void get_sizeMultiplier(){} // RVA: 0x7FFAC9955EE0
    public void set_sizeMultiplier(){} // RVA: 0x7FFAC9955F30
    public void get_x(){} // RVA: 0x7FFAC9955F90
    public void set_x(){} // RVA: 0x7FFAC9956000
    public void get_xMultiplier(){} // RVA: 0x7FFAC9956060
    public void set_xMultiplier(){} // RVA: 0x7FFAC99560B0
    public void get_y(){} // RVA: 0x7FFAC9956110
    public void set_y(){} // RVA: 0x7FFAC9956180
    public void get_yMultiplier(){} // RVA: 0x7FFAC99561E0
    public void set_yMultiplier(){} // RVA: 0x7FFAC9956230
    public void get_z(){} // RVA: 0x7FFAC9956290
    public void set_z(){} // RVA: 0x7FFAC9956300
    public void get_zMultiplier(){} // RVA: 0x7FFAC9956360
    public void set_zMultiplier(){} // RVA: 0x7FFAC99563B0
    public void get_separateAxes(){} // RVA: 0x7FFAC9956410
    public void set_separateAxes(){} // RVA: 0x7FFAC9956460
    public void get_enabled_Injected(){} // RVA: 0x7FFAC9955D60
    public void set_enabled_Injected(){} // RVA: 0x7FFAC9955DB0
    public void get_size_Injected(){} // RVA: 0x7FFAC99564C0
    public void set_size_Injected(){} // RVA: 0x7FFAC9956520
    public void get_sizeMultiplier_Injected(){} // RVA: 0x7FFAC9955EE0
    public void set_sizeMultiplier_Injected(){} // RVA: 0x7FFAC9955F30
    public void get_x_Injected(){} // RVA: 0x7FFAC9956580
    public void set_x_Injected(){} // RVA: 0x7FFAC99565E0
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFAC9956060
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFAC99560B0
    public void get_y_Injected(){} // RVA: 0x7FFAC9956640
    public void set_y_Injected(){} // RVA: 0x7FFAC99566A0
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFAC99561E0
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFAC9956230
    public void get_z_Injected(){} // RVA: 0x7FFAC9956700
    public void set_z_Injected(){} // RVA: 0x7FFAC9956760
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFAC9956360
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFAC99563B0
    public void get_separateAxes_Injected(){} // RVA: 0x7FFAC9956410
    public void set_separateAxes_Injected(){} // RVA: 0x7FFAC9956460
}

public class SizeProperty : Property`2
{
    public object Name;

    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFAC99A6F60
    public void .ctor(){} // RVA: 0x7FFAC99A6FA0
}

public class Sizef : ValueType
{
    public float w; // 0x10
    public float h; // 0x14
    public Sizef zero;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFAC8907EB0
}

public class Sizei : ValueType
{
    public int w; // 0x10
    public int h; // 0x14
    public Sizei zero;

    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFAC8907DB0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC88183F0
    public void .cctor(){} // RVA: 0x7FFAC8907E60
}

public class Skeleton : ValueType
{
    public 0x6B1A79F0 Type; // 0x10
    public uint NumBones; // 0x14
    public uint NumBoneCapsules; // 0x18
    public Bone[] Bones; // 0x20
    public BoneCapsule[] BoneCapsules; // 0x28
}

public class Skeleton2 : ValueType
{
    public 0x6B1A79F0 Type; // 0x10
    public uint NumBones; // 0x14
    public uint NumBoneCapsules; // 0x18
    public Bone[] Bones; // 0x20
    public BoneCapsule[] BoneCapsules; // 0x28
}

public class Skeleton2Internal : ValueType
{
    public 0x6B1A79F0 Type; // 0x10
    public uint NumBones; // 0x14
    public uint NumBoneCapsules; // 0x18
    public Bone Bones_0; // 0x1C
    public Bone Bones_1; // 0x40
    public Bone Bones_2; // 0x64
    public Bone Bones_3; // 0x88
    public Bone Bones_4; // 0xAC
    public Bone Bones_5; // 0xD0
    public Bone Bones_6; // 0xF4
    public Bone Bones_7; // 0x118
    public Bone Bones_8; // 0x13C
    public Bone Bones_9; // 0x160
    public Bone Bones_10; // 0x184
    public Bone Bones_11; // 0x1A8
    public Bone Bones_12; // 0x1CC
    public Bone Bones_13; // 0x1F0
    public Bone Bones_14; // 0x214
    public Bone Bones_15; // 0x238
    public Bone Bones_16; // 0x25C
    public Bone Bones_17; // 0x280
    public Bone Bones_18; // 0x2A4
    public Bone Bones_19; // 0x2C8
    public Bone Bones_20; // 0x2EC
    public Bone Bones_21; // 0x310
    public Bone Bones_22; // 0x334
    public Bone Bones_23; // 0x358
    public Bone Bones_24; // 0x37C
    public Bone Bones_25; // 0x3A0
    public Bone Bones_26; // 0x3C4
    public Bone Bones_27; // 0x3E8
    public Bone Bones_28; // 0x40C
    public Bone Bones_29; // 0x430
    public Bone Bones_30; // 0x454
    public Bone Bones_31; // 0x478
    public Bone Bones_32; // 0x49C
    public Bone Bones_33; // 0x4C0
    public Bone Bones_34; // 0x4E4
    public Bone Bones_35; // 0x508
    public Bone Bones_36; // 0x52C
    public Bone Bones_37; // 0x550
    public Bone Bones_38; // 0x574
    public Bone Bones_39; // 0x598
    public Bone Bones_40; // 0x5BC
    public Bone Bones_41; // 0x5E0
    public Bone Bones_42; // 0x604
    public Bone Bones_43; // 0x628
    public Bone Bones_44; // 0x64C
    public Bone Bones_45; // 0x670
    public Bone Bones_46; // 0x694
    public Bone Bones_47; // 0x6B8
    public Bone Bones_48; // 0x6DC
    public Bone Bones_49; // 0x700
    public Bone Bones_50; // 0x724
    public Bone Bones_51; // 0x748
    public Bone Bones_52; // 0x76C
    public Bone Bones_53; // 0x790
    public Bone Bones_54; // 0x7B4
    public Bone Bones_55; // 0x7D8
    public Bone Bones_56; // 0x7FC
    public Bone Bones_57; // 0x820
    public Bone Bones_58; // 0x844
    public Bone Bones_59; // 0x868
    public Bone Bones_60; // 0x88C
    public Bone Bones_61; // 0x8B0
    public Bone Bones_62; // 0x8D4
    public Bone Bones_63; // 0x8F8
    public Bone Bones_64; // 0x91C
    public Bone Bones_65; // 0x940
    public Bone Bones_66; // 0x964
    public Bone Bones_67; // 0x988
    public Bone Bones_68; // 0x9AC
    public Bone Bones_69; // 0x9D0
    public BoneCapsule BoneCapsules_0; // 0x9F4
    public BoneCapsule BoneCapsules_1; // 0xA14
    public BoneCapsule BoneCapsules_2; // 0xA34
    public BoneCapsule BoneCapsules_3; // 0xA54
    public BoneCapsule BoneCapsules_4; // 0xA74
    public BoneCapsule BoneCapsules_5; // 0xA94
    public BoneCapsule BoneCapsules_6; // 0xAB4
    public BoneCapsule BoneCapsules_7; // 0xAD4
    public BoneCapsule BoneCapsules_8; // 0xAF4
    public BoneCapsule BoneCapsules_9; // 0xB14
    public BoneCapsule BoneCapsules_10; // 0xB34
    public BoneCapsule BoneCapsules_11; // 0xB54
    public BoneCapsule BoneCapsules_12; // 0xB74
    public BoneCapsule BoneCapsules_13; // 0xB94
    public BoneCapsule BoneCapsules_14; // 0xBB4
    public BoneCapsule BoneCapsules_15; // 0xBD4
    public BoneCapsule BoneCapsules_16; // 0xBF4
    public BoneCapsule BoneCapsules_17; // 0xC14
    public BoneCapsule BoneCapsules_18; // 0xC34
}

public class SkeletonBlendablePose : Object
{
    public Valve.VR.SteamVR_Skeleton_Pose pose; // 0x10
    public Valve.VR.SteamVR_Skeleton_PoseSnapshot snapshotR; // 0x18
    public Valve.VR.SteamVR_Skeleton_PoseSnapshot snapshotL; // 0x20

    // ── Methods ──
    public void GetHandSnapshot(){} // RVA: 0x7FFAC8C8E750
    public void UpdateAdditiveAnimation(){} // RVA: 0x7FFAC8C8E760
    public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x2
    public void PoseToSnapshots(){} // RVA: 0x7FFAC8C8F0F0
}

public class SkeletonPoseData : ValueType
{
    public Posef RootPose; // 0x10
    public float RootScale; // 0x2C
    public Quatf[] BoneRotations; // 0x30
    public bool IsDataValid; // 0x38
    public bool IsDataHighConfidence; // 0x39
    public Vector3f[] BoneTranslations; // 0x40
    public int SkeletonChangedCount; // 0x48

    // ── Methods ──
    public void get_RootPose(){} // RVA: 0x7FFAC60F3DE0
    public void set_RootPose(){} // RVA: 0x7FFAC895B380
    public void get_RootScale(){} // RVA: 0x7FFAC2FEE570
    public void set_RootScale(){} // RVA: 0x7FFAC2FEE580
    public void get_BoneRotations(){} // RVA: 0x7FFAC2F4F0C0
    public void set_BoneRotations(){} // RVA: 0x7FFAC2F4F0D0
    public void get_IsDataValid(){} // RVA: 0x7FFAC30F6BA0
    public void set_IsDataValid(){} // RVA: 0x7FFAC3C24F40
    public void get_IsDataHighConfidence(){} // RVA: 0x7FFAC386C550
    public void set_IsDataHighConfidence(){} // RVA: 0x7FFAC43B4D70
    public void get_BoneTranslations(){} // RVA: 0x7FFAC31D95E0
    public void set_BoneTranslations(){} // RVA: 0x7FFAC2F4F890
    public void get_SkeletonChangedCount(){} // RVA: 0x7FFAC358A870
    public void set_SkeletonChangedCount(){} // RVA: 0x7FFAC3588350
}

public class SkeletonRendererData : ValueType
{
    public float RootScale; // 0x10
    public bool IsDataValid; // 0x14
    public bool IsDataHighConfidence; // 0x15
    public bool ShouldUseSystemGestureMaterial; // 0x16

    // ── Methods ──
    public void get_RootScale(){} // RVA: 0x7FFAC484C150
    public void set_RootScale(){} // RVA: 0x7FFAC4A9B910
    public void get_IsDataValid(){} // RVA: 0x7FFAC4A0B160
    public void set_IsDataValid(){} // RVA: 0x7FFAC3B9B960
    public void get_IsDataHighConfidence(){} // RVA: 0x7FFAC4A0B150
    public void set_IsDataHighConfidence(){} // RVA: 0x7FFAC3B9B950
    public void get_ShouldUseSystemGestureMaterial(){} // RVA: 0x7FFAC4B96900
    public void set_ShouldUseSystemGestureMaterial(){} // RVA: 0x7FFAC3B9B9C0
}

public class SkeletonsUpdatedHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC40BEC20
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC8C83C80
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class SkinChangedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class SlabAllocator : ValueType
{
    public AllocatorHandle Handle; // 0x10
    public Block SlabSizeInBytes; // 0x18
    public int Log2SlabSizeInBytes; // 0x38
    public Unity.Collections.FixedList4096Bytes`1<int> Occupied; // 0x40
    public long budgetInBytes; // 0x1040
    public long allocatedBytes; // 0x1048

    // ── Methods ──
    public void get_Handle(){} // RVA: 0x7FFAC4420210
    public void get_SlabSizeInBytes(){} // RVA: 0x7FFAC950FB60
    public void Try(){} // RVA: 0x7FFAC950FD90 | overloaded x2
    public void Dispose(){} // RVA: 0x7FFAC2F21310
    public void Try$BurstManaged(){} // RVA: 0x7FFAC950FDF0
}

public class SliderEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9C6A3A0
}

public class Slot : ValueType
{
    public Cysharp.Threading.Tasks.Internal.StateTuple`3<WhenAllPromise`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>,Awaiter<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>,int> Item; // 0x10
    public int SequenceNumber; // 0x18
}

public class SlotDefinition : ValueType
{
    public string name; // 0x10
    public int insertionPointId; // 0x18
}

public class SlotUsageEntry : ValueType
{
    public string slotName; // 0x10
    public int assetId; // 0x18
}

public class SmallXmlNodeList : ValueType
{
    public object Count; // 0x10

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFAC91F8580
    public void get_Item(){} // RVA: 0x7FFAC91F8620
    public void Add(){} // RVA: 0x7FFAC91F8760
    public void RemoveAt(){} // RVA: 0x7FFAC91F89D0
    public void Insert(){} // RVA: 0x7FFAC91F8B20
    public void GetEnumerator(){} // RVA: 0x7FFAC91F8D40
}

public class Snapshot : ValueType
{
    public string downloadSize; // 0x10
    public System.Nullable`1<int> uncompressedSize; // 0x18
    public System.Nullable`1<UnityEngine.Bounds> aabb; // 0x20
    public System.Nullable`1<int> skinnedMeshCount; // 0x3C
    public System.Nullable`1<int> meshCount; // 0x44
    public System.Nullable`1<int> materialCount; // 0x4C
    public System.Nullable`1<int> animatorCount; // 0x54
    public System.Nullable`1<int> boneCount; // 0x5C
    public System.Nullable`1<int> lightCount; // 0x64
    public System.Nullable`1<int> particleSystemCount; // 0x6C
    public System.Nullable`1<int> particleTotalCount; // 0x74
    public System.Nullable`1<int> particleMaxMeshPolyCount; // 0x7C
    public System.Nullable`1<bool> particleTrailsEnabled; // 0x84
    public System.Nullable`1<bool> particleCollisionEnabled; // 0x86
    public System.Nullable`1<int> trailRendererCount; // 0x88
    public System.Nullable`1<int> lineRendererCount; // 0x90
    public System.Nullable`1<PhysBoneStats> physBone; // 0x98
    public System.Nullable`1<int> contactCount; // 0xAC
    public System.Nullable`1<int> contactCompleteCount; // 0xB4
    public System.Nullable`1<int> clothCount; // 0xBC
    public System.Nullable`1<int> clothMaxVertices; // 0xC4
    public System.Nullable`1<int> physicsColliderCount; // 0xCC
    public System.Nullable`1<int> physicsRigidbodyCount; // 0xD4
    public System.Nullable`1<int> audioSourceCount; // 0xDC
    public System.Nullable`1<float> textureMegabytes; // 0xE4
    public System.Nullable`1<int> downloadSizeBytes; // 0xEC
    public System.Nullable`1<int> uncompressedSizeBytes; // 0xF4
    public System.Nullable`1<int> constraintsCount; // 0xFC
    public System.Nullable`1<int> constraintDepth; // 0x104
    public System.Nullable`1<int> raycastCount; // 0x10C
    public 0x6B252B90 overallRating; // 0x114
    public 0x6B252B90 polyCountRating; // 0x118
    public 0x6B252B90 aabbRating; // 0x11C
    public 0x6B252B90 skinnedMeshCountRating; // 0x120
    public 0x6B252B90 meshCountRating; // 0x124
    public 0x6B252B90 materialCountRating; // 0x128
    public 0x6B252B90 animatorCountRating; // 0x12C
    public 0x6B252B90 boneCountRating; // 0x130
    public 0x6B252B90 lightCountRating; // 0x134
    public 0x6B252B90 particleSystemCountRating; // 0x138
    public 0x6B252B90 particleTotalCountRating; // 0x13C
    public 0x6B252B90 particleMaxMeshPolyCountRating; // 0x140
    public 0x6B252B90 particleTrailsEnabledRating; // 0x144
    public 0x6B252B90 particleCollisionEnabledRating; // 0x148
    public 0x6B252B90 trailRendererCountRating; // 0x14C
    public 0x6B252B90 lineRendererCountRating; // 0x150
    public 0x6B252B90 physBoneComponentCountRating; // 0x154
    public 0x6B252B90 physBoneTransformCountRating; // 0x158
    public 0x6B252B90 physBoneColliderCountRating; // 0x15C
    public 0x6B252B90 physBoneCollisionCheckCountRating; // 0x160
    public 0x6B252B90 contactCountRating; // 0x164
    public 0x6B252B90 clothCountRating; // 0x168
    public 0x6B252B90 clothMaxVerticesRating; // 0x16C
    public 0x6B252B90 physicsColliderCountRating; // 0x170
    public 0x6B252B90 physicsRigidbodyCountRating; // 0x174
    public 0x6B252B90 audioSourceCountRating; // 0x178
    public 0x6B252B90 textureMegabytesRating; // 0x17C
    public 0x6B252B90 downloadSizeRating; // 0x180
    public 0x6B252B90 uncompressedSizeRating; // 0x184
    public 0x6B252B90 constraintsCountRating; // 0x188

    // ── Methods ──
    public void get_downloadSize(){} // RVA: 0x7FFACC08EE70
    public void get_uncompressedSize(){} // RVA: 0x7FFACC08EF10
    public void .ctor(){} // RVA: 0x7FFACC08EFB0
    public void ToString(){} // RVA: 0x7FFACC08F420
}

public class SortedColumnState : ValueType
{
    public UnityEngine.UIElements.SortColumnDescription columnDesc; // 0x10
    public 0x6B118890 direction; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC335C3C0
}

public class SortedListDebugView : Object
{
}

public class SortedListEnumerator : Object
{
    public System.Collections.SortedList Key; // 0x10
    public object Entry; // 0x18
    public object Current; // 0x20
    public int Value; // 0x28
    public int _startIndex; // 0x2C
    public int _endIndex; // 0x30
    public int _version; // 0x34
    public bool _current; // 0x38
    public int _getObjectRetType; // 0x3C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8598DA0
    public void Clone(){} // RVA: 0x7FFAC8512B10
    public void get_Key(){} // RVA: 0x7FFAC8598E30
    public void MoveNext(){} // RVA: 0x7FFAC8598F00
    public void get_Entry(){} // RVA: 0x7FFAC8599150
    public void get_Current(){} // RVA: 0x7FFAC8599230
    public void get_Value(){} // RVA: 0x7FFAC8599310
    public void Reset(){} // RVA: 0x7FFAC85993E0
}

public class SortedListKeyEnumerator : Object
{
    public System.Collections.Generic.SortedList`2<U,T> Current;
    public int System.Collections.IEnumerator.Current;
    public int _version;
    public U _currentKey;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
}

public class SortedListValueEnumerator : Object
{
    public System.Collections.Generic.SortedList`2<U,T> Current;
    public int System.Collections.IEnumerator.Current;
    public int _version;
    public T _currentValue;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC2C70980
}

public class SorterGenericArray : ValueType
{
    public System.Array keys; // 0x10
    public System.Array items; // 0x18
    public System.Collections.IComparer comparer; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86675F0
    public void SwapIfGreaterWithItems(){} // RVA: 0x7FFAC8667770
    public void Swap(){} // RVA: 0x7FFAC86678F0
    public void Sort(){} // RVA: 0x7FFAC86679E0
    public void IntrospectiveSort(){} // RVA: 0x7FFAC86679F0
    public void IntroSort(){} // RVA: 0x7FFAC8667AE0
    public void PickPivotAndPartition(){} // RVA: 0x7FFAC8667BC0
    public void Heapsort(){} // RVA: 0x7FFAC8667D70
    public void DownHeap(){} // RVA: 0x7FFAC8667E30
    public void InsertionSort(){} // RVA: 0x7FFAC8668080
}

public class SorterObjectArray : ValueType
{
    public object[] keys; // 0x10
    public object[] items; // 0x18
    public System.Collections.IComparer comparer; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86666F0
    public void SwapIfGreaterWithItems(){} // RVA: 0x7FFAC8666870
    public void Swap(){} // RVA: 0x7FFAC8666A80
    public void Sort(){} // RVA: 0x7FFAC8666C20
    public void IntrospectiveSort(){} // RVA: 0x7FFAC8666C30
    public void IntroSort(){} // RVA: 0x7FFAC8666D00
    public void PickPivotAndPartition(){} // RVA: 0x7FFAC8666DE0
    public void Heapsort(){} // RVA: 0x7FFAC8666F80
    public void DownHeap(){} // RVA: 0x7FFAC8667040
    public void InsertionSort(){} // RVA: 0x7FFAC8667360
}

public class SortingData : Object
{
    public IJobSortable source; // 0x10
    public SortingData parentDependency; // 0x18
    public System.Collections.Generic.List`1<SortingData> dependencies; // 0x20
    public bool visited; // 0x28
    public int executionGroup; // 0x2C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9E4E640
}

public class SortingGroupsUpdate : ValueType
{
}

public class Sounds : ValueType
{
    public UnityEngine.AudioClip hover; // 0x10
    public UnityEngine.AudioClip deny; // 0x18
    public UnityEngine.AudioClip select; // 0x20
    public UnityEngine.AudioClip back; // 0x28
}

public class Source : Object
{
}

public class SourceElement : Object
{
}

public class SourceMap : Object
{
}

public class SpaceContainerInternal : ValueType
{
    public int uuidCapacityInput; // 0x10
    public int uuidCountOutput; // 0x14
    public UIntPtr uuids; // 0x18
}

public class SpaceEraseCompleteData : ValueType
{
    public ulong RequestId; // 0x10
    public int Result; // 0x18
    public System.Guid Uuid; // 0x1C
    public 0x6B1A87B0 Location; // 0x2C
}

public class SpaceFilterInfoComponents : ValueType
{
    public 0x6B1A8758[] Components; // 0x10
    public int NumComponents; // 0x18
}

public class SpaceFilterInfoIds : ValueType
{
    public System.Guid[] Ids; // 0x10
    public int NumIds; // 0x18
}

public class SpaceLocationf : ValueType
{
    public 0x6B1A7C58 locationFlags; // 0x10
    public Posef pose; // 0x18
}

public class SpaceQueryCompleteData : ValueType
{
    public ulong RequestId; // 0x10
    public int Result; // 0x18
}

public class SpaceQueryInfo : ValueType
{
    public 0x6B1A88B8 QueryType; // 0x10
    public int MaxQuerySpaces; // 0x14
    public double Timeout; // 0x18
    public 0x6B1A87B0 Location; // 0x20
    public 0x6B1A8860 ActionType; // 0x24
    public 0x6B1A8910 FilterType; // 0x28
    public SpaceFilterInfoIds IdInfo; // 0x30
    public SpaceFilterInfoComponents ComponentsInfo; // 0x40
}

public class SpaceQueryResult : ValueType
{
    public ulong space; // 0x10
    public System.Guid uuid; // 0x18
}

public class SpaceQueryResultsData : ValueType
{
    public ulong RequestId; // 0x10
}

public class SpaceSaveCompleteData : ValueType
{
    public ulong RequestId; // 0x10
    public ulong Space; // 0x18
    public int Result; // 0x20
    public System.Guid Uuid; // 0x24
}

public class SpaceSemanticLabelInternal : ValueType
{
    public int byteCapacityInput; // 0x10
    public int byteCountOutput; // 0x14
    public UIntPtr labels; // 0x18
}

public class SpaceSetComponentStatusCompleteData : ValueType
{
    public ulong RequestId; // 0x10
    public int Result; // 0x18
    public ulong Space; // 0x20
    public System.Guid Uuid; // 0x28
    public 0x6B1A8758 ComponentType; // 0x38
    public int Enabled; // 0x3C
}

public class SparseArray`1 : Object
{
    public T[] Current;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70ED0
    public void get_Current(){} // RVA: 0x7FFAC2C58E90
    public void Add(){} // RVA: 0x7FFAC2E8DC40
    public void Remove(){} // RVA: 0x7FFAC2E8DC40
}

public class SpatialAnchorCreateCompleteData : ValueType
{
    public ulong RequestId; // 0x10
    public int Result; // 0x18
    public ulong Space; // 0x20
    public System.Guid Uuid; // 0x28
}

public class SpatialAnchorCreateInfo : ValueType
{
    public 0x6B1A6080 BaseTracking; // 0x10
    public Posef PoseInSpace; // 0x14
    public double Time; // 0x30
}

public class SpecialCharacter : ValueType
{
    public TMPro.TMP_Character character; // 0x10
    public TMPro.TMP_FontAsset fontAsset; // 0x18
    public UnityEngine.Material material; // 0x20
    public int materialIndex; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC979FFE0
}

public class Spectrum : Object
{
    public int Item; // 0x10
    public System.Collections.Generic.List`1<Point> points; // 0x18

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFAC3B2F3D0
    public void .ctor(){} // RVA: 0x7FFAC3B2FA30
    public void Initialize(){} // RVA: 0x7FFAC3B2FAF0
    public void set_Item(){} // RVA: 0x7FFAC3B30150
    public void get_Item(){} // RVA: 0x7FFAC3B307B0
    public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3B30DF0
    public void GetCachedPtr(){} // RVA: 0x7FFAC3B31450
    public void get_name(){} // RVA: 0x7FFAC3B31AB0
    public void set_name(){} // RVA: 0x7FFAC3B32110
}

public class Sphere : ValueType
{
    public Unity.Mathematics.float3 position; // 0x10
    public float radius; // 0x1C

    // ── Methods ──
    public void ClosestPoint(){} // RVA: 0x7FFAC9DFE9F0
}

public class Spine : BodyPart
{
    public UnityEngine.Transform pelvis; // 0x48
    public UnityEngine.Transform firstSpineBone; // 0x50
    public float chest; // 0x58
    public float neck; // 0x5C
    public float head; // 0x60
    public float anchorRotation; // 0x64
    public UnityEngine.Transform anchorRelativeToHead; // 0x68
    public float VrcAdjustedSpineLengthFactor; // 0x70
    public float minHeadHeight; // 0x74
    public float bodyPosStiffness; // 0x78
    public float bodyRotStiffness; // 0x7C
    public float neckStiffness; // 0x80
    public float rotateChestByHands; // 0x84
    public float chestClampWeight; // 0x88
    public float headClampWeight; // 0x8C
    public float moveBodyBackWhenCrouching; // 0x90
    public float maintainPelvisPosition; // 0x94
    public float maxRootAngle; // 0x98
    public float rootHeadingOffset; // 0x9C
    public UnityEngine.Vector3 IKPositionHead; // 0xA0
    public UnityEngine.Quaternion IKRotationHead; // 0xAC
    public UnityEngine.Vector3 IKPositionPelvis; // 0xBC
    public UnityEngine.Quaternion IKRotationPelvis; // 0xC8
    public UnityEngine.Vector3 goalPositionChest; // 0xD8
    public UnityEngine.Vector3 pelvisPositionOffset; // 0xE4
    public UnityEngine.Vector3 chestPositionOffset; // 0xF0
    public UnityEngine.Vector3 headPositionOffset; // 0xFC
    public UnityEngine.Quaternion pelvisRotationOffset; // 0x108
    public UnityEngine.Quaternion chestRotationOffset; // 0x118
    public UnityEngine.Quaternion headRotationOffset; // 0x128
    public UnityEngine.Vector3 faceDirection; // 0x138
    public UnityEngine.Vector3 locomotionHeadPositionOffset; // 0x144
    public UnityEngine.Vector3 headPosition; // 0x150
    public UnityEngine.Quaternion <anchorRotation>k__BackingField; // 0x15C
    public UnityEngine.Quaternion <anchorRelativeToHead>k__BackingField; // 0x16C
    public bool vrcFbtSpineMode; // 0x17C
    public bool vrcAllowHipDrift; // 0x17D
    public bool vrcAllowHeadDrift; // 0x17E
    public bool vrcUseNewMode; // 0x17F
    public UnityEngine.Quaternion vrcPreSolveHeadRot; // 0x180
    public UnityEngine.Quaternion vrcPreSolveNeckRot; // 0x190
    public UnityEngine.Quaternion vrcPreSolveChestRot; // 0x1A0
    public UnityEngine.Vector3 vrcMeasuredChestForward; // 0x1B0
    public UnityEngine.Vector3 vrcHipToLegCenter; // 0x1BC
    public UnityEngine.Quaternion vrcTposeHipRot; // 0x1C8
    public UnityEngine.Quaternion vrcTposeSpineRot; // 0x1D8
    public UnityEngine.Quaternion vrcTposeChestRot; // 0x1E8
    public UnityEngine.Quaternion vrcTposeUpperChestRot; // 0x1F8
    public UnityEngine.Quaternion vrcTposeNeckRot; // 0x208
    public UnityEngine.Quaternion vrcTposeHeadRot; // 0x218
    public UnityEngine.Vector3 vrcTposeHipToHead; // 0x228
    public float vrcSpineCrunchFactor; // 0x234
    public float spineLength; // 0x238
    public float normalMaxSpineLengthIncrease;
    public float normalMaxSpineLengthDecrease;
    public float chestTrackingMaxSpineLengthIncrease;
    public float chestTrackingMaxSpineLengthDecrease;
    public float spineCompressionBlendThreshold;
    public float maxChestCrimpAngle;
    public UnityEngine.Vector3 vrcPreShiftHipPos; // 0x23C
    public UnityEngine.Vector3 vrcPreShiftHeadPos; // 0x248
    public float <VrcAdjustedSpineLengthFactor>k__BackingField; // 0x254
    public UnityEngine.Quaternion headRotation; // 0x258
    public UnityEngine.Quaternion pelvisRotation; // 0x268
    public UnityEngine.Quaternion anchorRelativeToPelvis; // 0x278
    public UnityEngine.Quaternion pelvisRelativeRotation; // 0x288
    public UnityEngine.Quaternion chestRelativeRotation; // 0x298
    public UnityEngine.Vector3 headDeltaPosition; // 0x2A8
    public UnityEngine.Quaternion pelvisDeltaRotation; // 0x2B4
    public UnityEngine.Quaternion chestTargetRotation; // 0x2C4
    public int pelvisIndex; // 0x2D4
    public int spineIndex; // 0x2D8
    public int chestIndex; // 0x2DC
    public int neckIndex; // 0x2E0
    public int headIndex; // 0x2E4
    public int upperChestIndex; // 0x2E8
    public float length; // 0x2EC
    public bool hasChest; // 0x2F0
    public bool hasUpperChest; // 0x2F1
    public bool hasNeck; // 0x2F2
    public bool hasLegs; // 0x2F3
    public float headHeight; // 0x2F4
    public float sizeMlp; // 0x2F8
    public UnityEngine.Vector3 chestForward; // 0x2FC

    // ── Methods ──
    public void get_pelvis(){} // RVA: 0x7FFAC3056110
    public void get_firstSpineBone(){} // RVA: 0x7FFAC3056140
    public void get_chest(){} // RVA: 0x7FFAC3056170
    public void get_neck(){} // RVA: 0x7FFAC30561E0
    public void get_head(){} // RVA: 0x7FFAC3056210
    public void get_anchorRotation(){} // RVA: 0x7FFAC2F8C710
    public void set_anchorRotation(){} // RVA: 0x7FFAC2F8C720
    public void get_anchorRelativeToHead(){} // RVA: 0x7FFAC2F8C730
    public void set_anchorRelativeToHead(){} // RVA: 0x7FFAC2F8C740
    public void get_VrcAdjustedSpineLengthFactor(){} // RVA: 0x7FFAC3056240
    public void set_VrcAdjustedSpineLengthFactor(){} // RVA: 0x7FFAC3056250
    public void OnRead(){} // RVA: 0x7FFAC3056260
    public void PreSolve(){} // RVA: 0x7FFAC3057BC0
    public void ApplyOffsets(){} // RVA: 0x7FFAC3058360
    public void CalculateChestTargetRotation(){} // RVA: 0x7FFAC3059080
    public void Solve(){} // RVA: 0x7FFAC3059730
    public void FABRIKPass(){} // RVA: 0x7FFAC305ABE0
    public void SolvePelvis(){} // RVA: 0x7FFAC305AF90
    public void Write(){} // RVA: 0x7FFAC305E030
    public void ResetOffsets(){} // RVA: 0x7FFAC305E2A0
    public void VrcSolveLockHead(){} // RVA: 0x7FFAC305E400
    public void VrcPelvisPitchBack(){} // RVA: 0x7FFAC305FC80
    public void VrcRotateSpineToChestGoal(){} // RVA: 0x7FFAC3060300
    public void VrcGetQuaternionAngle(){} // RVA: 0x7FFAC30609D0
    public void VrcSmoothClampAngle(){} // RVA: 0x7FFAC3060A10
    public void VrcGetReflectedChestGoalPosition(){} // RVA: 0x7FFAC3060AD0
    public void VrcRotateSpineToChestGoalOld(){} // RVA: 0x7FFAC3060F20
    public void VrcApplyTposeRotationsRelativeTo(){} // RVA: 0x7FFAC3061210
    public void VrcApplyDeltaToSpineBones(){} // RVA: 0x7FFAC3061870
    public void VrcBlendQuaternion(){} // RVA: 0x7FFAC30644E0
    public void VrcRotateTowardsHeadAt(){} // RVA: 0x7FFAC3064B40
    public void VrcAverageNeckRotation(){} // RVA: 0x7FFAC3064CE0
    public void VrcRotateNeckTowardsHeadTarget(){} // RVA: 0x7FFAC3065890
    public void VrcAngleOfRotationAroundAxis(){} // RVA: 0x7FFAC3066F70
    public void VrcApplyChestTwist(){} // RVA: 0x7FFAC30671B0
    public void VrcApplyChestSwing(){} // RVA: 0x7FFAC3068D60
    public void VrcSinEaseIn01(){} // RVA: 0x7FFAC3069470
    public void VrcGetTwistOnAxis(){} // RVA: 0x7FFAC30694C0
    public void VrcOffsetBoneAndChildBones(){} // RVA: 0x7FFAC3069590
    public void AdjustChestByHands(){} // RVA: 0x7FFAC3069620
    public void InverseTranslateToHead(){} // RVA: 0x7FFAC306A1C0
    public void TranslatePelvis(){} // RVA: 0x7FFAC306A350
    public void LimitPelvisPosition(){} // RVA: 0x7FFAC306AE40
    public void Bend(){} // RVA: 0x7FFAC306B4E0 | overloaded x2
    public void .ctor(){} // RVA: 0x7FFAC306B8D0
}

public class SpineEffector : Object
{
    public 0x6B1C0330 effectorType; // 0x10
    public float horizontalWeight; // 0x14
    public float verticalWeight; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FE0800 | overloaded x2
}

public class SpriteAtlasManagerUpdate : ValueType
{
}

public class SpriteDataObject : Object
{
    public System.Collections.Generic.List`1<Frame> frames; // 0x10
    public Meta meta; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class SpriteFrame : ValueType
{
    public float x; // 0x10
    public float y; // 0x14
    public float w; // 0x18
    public float h; // 0x1C

    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFAC97ABDE0
}

public class SpriteSize : ValueType
{
    public float w; // 0x10
    public float h; // 0x14

    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFAC97ABF80
}

public class Sprites : ValueType
{
    public UnityEngine.Sprite normal; // 0x10
    public UnityEngine.Sprite hand; // 0x18
    public UnityEngine.Sprite point; // 0x20
}

public class Sse : Object
{
    public object IsSseSupported;

    // ── Methods ──
    public void get_IsSseSupported(){} // RVA: 0x7FFAC2F21320
    public void SHUFFLE(){} // RVA: 0x7FFAC950D5D0
}

public class Sse2 : Object
{
    // ── Methods ──
    public void add_epi64(){} // RVA: 0x7FFAC950D600
    public void mul_epu32(){} // RVA: 0x7FFAC950D620
    public void slli_epi64(){} // RVA: 0x7FFAC950D640
    public void srli_epi64(){} // RVA: 0x7FFAC950D6E0
    public void xor_si128(){} // RVA: 0x7FFAC950D7A0
    public void shuffle_epi32(){} // RVA: 0x7FFAC950D7C0
}

public class StackAllocator : ValueType
{
    public AllocatorHandle Handle; // 0x10
    public Block m_storage; // 0x18
    public long m_top; // 0x38

    // ── Methods ──
    public void get_Handle(){} // RVA: 0x7FFAC4420210
    public void Try(){} // RVA: 0x7FFAC950F570 | overloaded x2
    public void Dispose(){} // RVA: 0x7FFAC2F21310
    public void Try$BurstManaged(){} // RVA: 0x7FFAC950F5D0
}

public class StackDebugView : Object
{
}

public class StackEnumerator : Object
{
    public System.Collections.Stack Current; // 0x10
    public int _index; // 0x18
    public int _version; // 0x1C
    public object _currentElement; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC859A8A0
    public void Clone(){} // RVA: 0x7FFAC8512B10
    public void MoveNext(){} // RVA: 0x7FFAC859A980
    public void get_Current(){} // RVA: 0x7FFAC859AAD0
    public void Reset(){} // RVA: 0x7FFAC859AB80
}

public class StackRow : ValueType
{
    public int SizeOrLength; // 0x10
    public int NumberOfRows; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC33D6D50
}

public class StackRowStack : ValueType
{
    public byte[] _rentedBuffer; // 0x10
    public int _topOfStack; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8AA1BE0
    public void Dispose(){} // RVA: 0x7FFAC8AA1CA0
    public void Push(){} // RVA: 0x7FFAC8AA1D70
    public void Pop(){} // RVA: 0x7FFAC8AA1F10
    public void Enlarge(){} // RVA: 0x7FFAC8AA2140
}

public class StandardValuesCollection : Object
{
    public System.Collections.ICollection Count; // 0x10
    public System.Array Item; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9435380
    public void get_Count(){} // RVA: 0x7FFAC94354E0
    public void get_Item(){} // RVA: 0x7FFAC9435550
    public void CopyTo(){} // RVA: 0x7FFAC94356A0
    public void GetEnumerator(){} // RVA: 0x7FFAC9435710
    public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC9435760
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC34F9180
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC94356A0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9435710
}

public class StartSendingMsg : Object
{
    // ── Methods ──
    public void Process(){} // RVA: 0x7FFAC96020D0
}

public class State : ValueType
{
    public <Accumulators>e__FixedBuffer Accumulators; // 0x10
    public <Secret>e__FixedBuffer Secret; // 0x50
    public <Buffer>e__FixedBuffer Buffer; // 0x110
    public uint BufferedCount; // 0x210
    public ulong StripesProcessedInCurrentBlock; // 0x218
    public ulong TotalLength; // 0x220
    public ulong Seed; // 0x228
}

public class StateChangeMonitorDelegate : Object
{
    public System.Action`4<UnityEngine.InputSystem.InputControl,double,UnityEngine.InputSystem.LowLevel.InputEventPtr,long> valueChangeCallback; // 0x10
    public System.Action`4<UnityEngine.InputSystem.InputControl,double,long,int> timerExpiredCallback; // 0x18

    // ── Methods ──
    public void NotifyControlStateChanged(){} // RVA: 0x7FFAC9680290
    public void NotifyTimerExpired(){} // RVA: 0x7FFAC96802C0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class StateChangeMonitorListener : ValueType
{
    public UnityEngine.InputSystem.InputControl control; // 0x10
    public UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor; // 0x18
    public long monitorIndex; // 0x20
    public uint groupIndex; // 0x28
}

public class StateChangeMonitorTimeout : ValueType
{
    public UnityEngine.InputSystem.InputControl control; // 0x10
    public double time; // 0x18
    public UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor monitor; // 0x20
    public long monitorIndex; // 0x28
    public int timerIndex; // 0x30
}

public class StateChangeMonitorsForDevice : ValueType
{
    public BitRegion[] count; // 0x10
    public StateChangeMonitorListener[] listeners; // 0x18
    public UnityEngine.InputSystem.DynamicBitfield signalled; // 0x20
    public bool needToUpdateOrderingOfMonitors; // 0x40
    public bool needToCompactArrays; // 0x41

    // ── Methods ──
    public void get_count(){} // RVA: 0x7FFAC32EC4C0
    public void Add(){} // RVA: 0x7FFAC961DBE0
    public void Remove(){} // RVA: 0x7FFAC961DF10
    public void Clear(){} // RVA: 0x7FFAC961DFE0
    public void CompactArrays(){} // RVA: 0x7FFAC961E080
    public void RemoveAt(){} // RVA: 0x7FFAC961E0E0
    public void SortMonitorsByIndex(){} // RVA: 0x7FFAC961E290
}

public class StateChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC5F0D920
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class StateDownHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC411D4B0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC8C3FE60
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}
