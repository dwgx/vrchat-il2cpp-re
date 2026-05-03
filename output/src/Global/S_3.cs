// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 397

public class SharedStatic : Object
{
    // ── Methods ──
    public void GetOrCreateSharedStaticInternal(){} // RVA: 0x7FFE87BF9420
}

public class SharedStatic`1 : ValueType
{
    public void* _buffer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void get_Data(){} // RVA: 0x7FFE80E2E2E0
    public void GetOrCreate(){} // RVA: 0x7FFE810A1420
}

public class SharedStatics : Object
{
}

public class SheetHandleKey : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87EC5890
}

public class SheetHandleKeyComparer : Object
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE87EC58D0
    public void GetHashCode(){} // RVA: 0x7FFE84108250
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SigStream : BaseOutputStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE89F83F60
    public void WriteByte(){} // RVA: 0x7FFE89F97820
    public void Write(){} // RVA: 0x7FFE89F97880
}

public class SignalSource : Object
{
    public Cinemachine.CinemachineImpulseDefinition m_Def; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82ABFC20
    public void get_SignalDuration(){} // RVA: 0x7FFE82ABFC90
    public void GetSignal(){} // RVA: 0x7FFE82ABFCB0
}

public class SignedData : Object
{
    public byte version; // 0x10
    public string hashAlgorithm; // 0x18
    public ContentInfo contentInfo; // 0x20
    public Mono.Security.X509.X509CertificateCollection certs; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE866FAE50
    public void get_Certificates(){} // RVA: 0x7FFE81129130
    public void get_ContentInfo(){} // RVA: 0x7FFE811290C0
    public void set_HashName(){} // RVA: 0x7FFE866FB6C0
    public void get_SignerInfo(){} // RVA: 0x7FFE8143BA80
    public void OidToName(){} // RVA: 0x7FFE866FB7A0
}

public class SignerInf : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsSignedGenerator outer; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ISignatureFactory sigCalc; // 0x18
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms.SignerIdentifier signerIdentifier; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A1042F0 | overloaded x2
    public void get_DigestAlgorithmID(){} // RVA: 0x7FFE8A104740
    public void get_SignedAttributes(){} // RVA: 0x7FFE8143BA80
    public void get_UnsignedAttributes(){} // RVA: 0x7FFE81178740
    public void ToSignerInfo(){} // RVA: 0x7FFE8A104820
}

public class SignerInfo : Object
{
    public byte version; // 0x10
    public string hashAlgorithm; // 0x18
    public System.Collections.ArrayList authenticatedAttributes; // 0x20
    public System.Collections.ArrayList unauthenticatedAttributes; // 0x28
    public byte[] signature; // 0x30
    public string issuer; // 0x38
    public byte[] serial; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE866FBB90 | overloaded x2
    public void get_IssuerName(){} // RVA: 0x7FFE8143BA80
    public void get_SerialNumber(){} // RVA: 0x7FFE866FC060
    public void get_AuthenticatedAttributes(){} // RVA: 0x7FFE811290C0
    public void get_HashName(){} // RVA: 0x7FFE810FE7C0
    public void set_HashName(){} // RVA: 0x7FFE81161E80
    public void get_Signature(){} // RVA: 0x7FFE866FC0E0
    public void get_UnauthenticatedAttributes(){} // RVA: 0x7FFE81129130
    public void get_Version(){} // RVA: 0x7FFE811C55E0
}

public class SignerInfoGeneratorImpl : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A10AA20
    public void Generate(){} // RVA: 0x7FFE8A10B0F0
}

public class SigningKey : ValueType
{
    public byte[] _key; // 0x10

    // ── Methods ──
    public void get_Key(){} // RVA: 0x7FFE8284EF60
    public void .ctor(){} // RVA: 0x7FFE8A2AB990
}

public class SimplePropertyDescriptor : PropertyDescriptor
{
    public System.Type componentType; // 0x88
    public System.Type propertyType; // 0x90
    public object field_2;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE877DD5B0 | overloaded x2
    public void get_ComponentType(){} // RVA: 0x7FFE8113A010
    public void get_IsReadOnly(){} // RVA: 0x7FFE877DD6A0
    public void get_PropertyType(){} // RVA: 0x7FFE8154EB60
    public void CanResetValue(){} // RVA: 0x7FFE877DD780
    public void ResetValue(){} // RVA: 0x7FFE877DD940
    public void ShouldSerializeValue(){} // RVA: 0x7FFE810FB320
}

public class SimpleScheduledItem : VisualElementScheduledItem`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87F9CCA0
    public void PerformTimerUpdate(){} // RVA: 0x7FFE87F9CD00
}

public class SingleAnchorDelegatePair : ValueType
{
}

public class SingleByteUnion : ValueType
{
}

public class SingleConsumerUnboundedChannelReader : ChannelReader`1
{
    public System.Action`1<object> CancellationCallbackDelegate;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void get_Completion(){} // RVA: 0x7FFE80E2DCF0
    public void TryRead(){} // RVA: 0x7FFE80E2F3B0
    public void WaitToReadAsync(){}
    public void SingalContinuation(){} // RVA: 0x7FFE80E45FE0
    public void SingalCancellation(){} // RVA: 0x7FFE80E46250
    public void SingalCompleted(){} // RVA: 0x7FFE80E460A0
    public void ReadAllAsync(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource<System.Boolean>.GetResult(){} // RVA: 0x7FFE80E2FFD0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(){}
    public void Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void CancellationCallback(){} // RVA: 0x7FFE80E46070
}

public class SingleConsumerUnboundedChannelWriter : ChannelWriter`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void TryWrite(){} // RVA: 0x7FFE810A1420
    public void TryComplete(){} // RVA: 0x7FFE80E2F3B0
}

public class SingleObjectEnumerator : Object
{
    public object loneValue; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE83C3D9B0
    public void get_Current(){} // RVA: 0x7FFE875A1610
    public void MoveNext(){} // RVA: 0x7FFE875A1670
    public void Reset(){} // RVA: 0x7FFE82A55FE0
}

public class SingleProducerSingleConsumerQueue_DebugView : Object
{
}

public class SingleQueryMatcher : UQueryMatcher
{
    public UnityEngine.UIElements.VisualElement _match; // 0x18

    // ── Methods ──
    public void get_match(){} // RVA: 0x7FFE810FE7C0
    public void set_match(){} // RVA: 0x7FFE81161E80
    public void Run(){} // RVA: 0x7FFE87FCCD50
    public void IsInUse(){} // RVA: 0x7FFE87FCCE90
    public void CreateNew(){} // RVA: 0x7FFE80E2E2E0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SingleRange : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84455D80
}

public class SingleRangeComparer : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Compare(){} // RVA: 0x7FFE87751120
    public void .cctor(){} // RVA: 0x7FFE87751180
}

public class Site : Object
{
    public string _name; // 0x10
    public System.ComponentModel.IComponent _component; // 0x18
    public System.ComponentModel.IContainer _container; // 0x20
    public object field_3; // 0x27D
    public object field_4; // 0x27E

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE877B2CB0
    public void get_Component(){} // RVA: 0x7FFE810FE7C0
    public void get_Container(){} // RVA: 0x7FFE811290C0
    public void GetService(){} // RVA: 0x7FFE877B2DB0
    public void get_DesignMode(){} // RVA: 0x7FFE877B2F00
    public void get_FullName(){} // RVA: 0x7FFE877B2FF0
    public void get_Name(){} // RVA: 0x7FFE81116380
    public void set_Name(){} // RVA: 0x7FFE877B3110
}

public class Size3f : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE86CB15E0
}

public class SizeBySpeedModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x141
    public object field_2; // 0x142
    public object field_3; // 0x143
    public object field_4; // 0x144
    public object field_5; // 0x145
    public object field_6; // 0x146
    public object field_7; // 0x147
    public object field_8; // 0x148
    public object field_9; // 0x149
    public object field_10; // 0x14A

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CFF060
    public void set_enabled(){} // RVA: 0x7FFE87CFF0B0
    public void get_size(){} // RVA: 0x7FFE87CFF110
    public void set_size(){} // RVA: 0x7FFE87CFF180
    public void get_sizeMultiplier(){} // RVA: 0x7FFE87CFF1E0
    public void set_sizeMultiplier(){} // RVA: 0x7FFE87CFF230
    public void get_x(){} // RVA: 0x7FFE87CFF290
    public void set_x(){} // RVA: 0x7FFE87CFF300
    public void get_xMultiplier(){} // RVA: 0x7FFE87CFF360
    public void set_xMultiplier(){} // RVA: 0x7FFE87CFF3B0
    public void get_y(){} // RVA: 0x7FFE87CFF410
    public void set_y(){} // RVA: 0x7FFE87CFF480
    public void get_yMultiplier(){} // RVA: 0x7FFE87CFF4E0
    public void set_yMultiplier(){} // RVA: 0x7FFE87CFF530
    public void get_z(){} // RVA: 0x7FFE87CFF590
    public void set_z(){} // RVA: 0x7FFE87CFF600
    public void get_zMultiplier(){} // RVA: 0x7FFE87CFF660
    public void set_zMultiplier(){} // RVA: 0x7FFE87CFF6B0
    public void get_separateAxes(){} // RVA: 0x7FFE87CFF710
    public void set_separateAxes(){} // RVA: 0x7FFE87CFF760
    public void get_range(){} // RVA: 0x7FFE87CFF7C0
    public void set_range(){} // RVA: 0x7FFE87CFF820
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CFF060
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CFF0B0
    public void get_size_Injected(){} // RVA: 0x7FFE87CFF880
    public void set_size_Injected(){} // RVA: 0x7FFE87CFF8E0
    public void get_sizeMultiplier_Injected(){} // RVA: 0x7FFE87CFF1E0
    public void set_sizeMultiplier_Injected(){} // RVA: 0x7FFE87CFF230
    public void get_x_Injected(){} // RVA: 0x7FFE87CFF940
    public void set_x_Injected(){} // RVA: 0x7FFE87CFF9A0
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFE87CFF360
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFE87CFF3B0
    public void get_y_Injected(){} // RVA: 0x7FFE87CFFA00
    public void set_y_Injected(){} // RVA: 0x7FFE87CFFA60
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFE87CFF4E0
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFE87CFF530
    public void get_z_Injected(){} // RVA: 0x7FFE87CFFAC0
    public void set_z_Injected(){} // RVA: 0x7FFE87CFFB20
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFE87CFF660
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFE87CFF6B0
    public void get_separateAxes_Injected(){} // RVA: 0x7FFE87CFF710
    public void set_separateAxes_Injected(){} // RVA: 0x7FFE87CFF760
    public void get_range_Injected(){} // RVA: 0x7FFE87CFFB80
    public void set_range_Injected(){} // RVA: 0x7FFE87CFFBE0
}

public class SizeGroup : Object
{
    public System.Collections.Generic.Stack`1<T[]> ArrayStack;

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFE80E2EDB0
    public void TryGetArray(){} // RVA: 0x7FFE80E2E2E0
    public void ReturnArray(){} // RVA: 0x7FFE80E460A0
    public void Cleanup(){} // RVA: 0x7FFE80E2EDB0
    public void Contains(){} // RVA: 0x7FFE80E2F3B0
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class SizeOverLifetimeModule : ValueType
{
    public UnityEngine.ParticleSystem m_ParticleSystem; // 0x10
    public object field_1; // 0x137
    public object field_2; // 0x138
    public object field_3; // 0x139
    public object field_4; // 0x13A
    public object field_5; // 0x13B
    public object field_6; // 0x13C
    public object field_7; // 0x13D
    public object field_8; // 0x13E
    public object field_9; // 0x13F

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_enabled(){} // RVA: 0x7FFE87CFE600
    public void set_enabled(){} // RVA: 0x7FFE87CFE650
    public void get_size(){} // RVA: 0x7FFE87CFE6B0
    public void set_size(){} // RVA: 0x7FFE87CFE720
    public void get_sizeMultiplier(){} // RVA: 0x7FFE87CFE780
    public void set_sizeMultiplier(){} // RVA: 0x7FFE87CFE7D0
    public void get_x(){} // RVA: 0x7FFE87CFE830
    public void set_x(){} // RVA: 0x7FFE87CFE8A0
    public void get_xMultiplier(){} // RVA: 0x7FFE87CFE900
    public void set_xMultiplier(){} // RVA: 0x7FFE87CFE950
    public void get_y(){} // RVA: 0x7FFE87CFE9B0
    public void set_y(){} // RVA: 0x7FFE87CFEA20
    public void get_yMultiplier(){} // RVA: 0x7FFE87CFEA80
    public void set_yMultiplier(){} // RVA: 0x7FFE87CFEAD0
    public void get_z(){} // RVA: 0x7FFE87CFEB30
    public void set_z(){} // RVA: 0x7FFE87CFEBA0
    public void get_zMultiplier(){} // RVA: 0x7FFE87CFEC00
    public void set_zMultiplier(){} // RVA: 0x7FFE87CFEC50
    public void get_separateAxes(){} // RVA: 0x7FFE87CFECB0
    public void set_separateAxes(){} // RVA: 0x7FFE87CFED00
    public void get_enabled_Injected(){} // RVA: 0x7FFE87CFE600
    public void set_enabled_Injected(){} // RVA: 0x7FFE87CFE650
    public void get_size_Injected(){} // RVA: 0x7FFE87CFED60
    public void set_size_Injected(){} // RVA: 0x7FFE87CFEDC0
    public void get_sizeMultiplier_Injected(){} // RVA: 0x7FFE87CFE780
    public void set_sizeMultiplier_Injected(){} // RVA: 0x7FFE87CFE7D0
    public void get_x_Injected(){} // RVA: 0x7FFE87CFEE20
    public void set_x_Injected(){} // RVA: 0x7FFE87CFEE80
    public void get_xMultiplier_Injected(){} // RVA: 0x7FFE87CFE900
    public void set_xMultiplier_Injected(){} // RVA: 0x7FFE87CFE950
    public void get_y_Injected(){} // RVA: 0x7FFE87CFEEE0
    public void set_y_Injected(){} // RVA: 0x7FFE87CFEF40
    public void get_yMultiplier_Injected(){} // RVA: 0x7FFE87CFEA80
    public void set_yMultiplier_Injected(){} // RVA: 0x7FFE87CFEAD0
    public void get_z_Injected(){} // RVA: 0x7FFE87CFEFA0
    public void set_z_Injected(){} // RVA: 0x7FFE87CFF000
    public void get_zMultiplier_Injected(){} // RVA: 0x7FFE87CFEC00
    public void set_zMultiplier_Injected(){} // RVA: 0x7FFE87CFEC50
    public void get_separateAxes_Injected(){} // RVA: 0x7FFE87CFECB0
    public void set_separateAxes_Injected(){} // RVA: 0x7FFE87CFED00
}

public class SizeProperty : Property`2
{
    // ── Methods ──
    public void get_Name(){} // RVA: 0x7FFE87D4F800
    public void .ctor(){} // RVA: 0x7FFE87D4F840
}

public class Sizef : ValueType
{
    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFE86CB15A0
}

public class Sizei : ValueType
{
    // ── Methods ──
    public void Equals(){} // RVA: 0x7FFE86CB14A0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE86BC1AE0
    public void .cctor(){} // RVA: 0x7FFE86CB1550
}

public class Skeleton : ValueType
{
}

public class Skeleton2 : ValueType
{
}

public class Skeleton2Internal : ValueType
{
}

public class SkeletonBlendablePose : Object
{
    // ── Methods ──
    public void GetHandSnapshot(){} // RVA: 0x7FFE87036C40
    public void UpdateAdditiveAnimation(){} // RVA: 0x7FFE87036C50
    public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x2
    public void PoseToSnapshots(){} // RVA: 0x7FFE870375E0
}

public class SkeletonPoseData : ValueType
{
    public Posef _rootPose; // 0x10
    public float _rootScale; // 0x2C
    public Quatf[] _boneRotations; // 0x30
    public bool _isDataValid; // 0x38
    public bool _isDataHighConfidence; // 0x39
    public Vector3f[] _boneTranslations; // 0x40
    public int _skeletonChangedCount; // 0x48

    // ── Methods ──
    public void get_RootPose(){} // RVA: 0x7FFE84458FD0
    public void set_RootPose(){} // RVA: 0x7FFE86D04A10
    public void get_RootScale(){} // RVA: 0x7FFE811C8570
    public void set_RootScale(){} // RVA: 0x7FFE811C8580
    public void get_BoneRotations(){} // RVA: 0x7FFE811290C0
    public void set_BoneRotations(){} // RVA: 0x7FFE811290D0
    public void get_IsDataValid(){} // RVA: 0x7FFE815F1380
    public void set_IsDataValid(){} // RVA: 0x7FFE81C15740
    public void get_IsDataHighConfidence(){} // RVA: 0x7FFE819C2EA0
    public void set_IsDataHighConfidence(){} // RVA: 0x7FFE8268C820
    public void get_BoneTranslations(){} // RVA: 0x7FFE8144E200
    public void set_BoneTranslations(){} // RVA: 0x7FFE81129890
    public void get_SkeletonChangedCount(){} // RVA: 0x7FFE81D46090
    public void set_SkeletonChangedCount(){} // RVA: 0x7FFE81D46A00
}

public class SkeletonRendererData : ValueType
{
    public float _rootScale; // 0x10
    public bool _isDataValid; // 0x14
    public bool _isDataHighConfidence; // 0x15
    public bool _shouldUseSystemGestureMaterial; // 0x16

    // ── Methods ──
    public void get_RootScale(){} // RVA: 0x7FFE82AB44F0
    public void set_RootScale(){} // RVA: 0x7FFE82D03BB0
    public void get_IsDataValid(){} // RVA: 0x7FFE82C770F0
    public void set_IsDataValid(){} // RVA: 0x7FFE81E63F40
    public void get_IsDataHighConfidence(){} // RVA: 0x7FFE82C77100
    public void set_IsDataHighConfidence(){} // RVA: 0x7FFE81E63F70
    public void get_ShouldUseSystemGestureMaterial(){} // RVA: 0x7FFE82E019C0
    public void set_ShouldUseSystemGestureMaterial(){} // RVA: 0x7FFE81E63EE0
}

public class SkeletonsUpdatedHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE823781B0
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE8702C170
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class SkinChangedDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159980
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class SlabAllocator : ValueType
{
    public AllocatorHandle m_handle; // 0x10
    public Block Storage; // 0x18

    // ── Methods ──
    public void get_Handle(){} // RVA: 0x7FFE826F4220
    public void get_SlabSizeInBytes(){} // RVA: 0x7FFE878B82A0
    public void Try(){} // RVA: 0x7FFE878B84D0 | overloaded x2
    public void Dispose(){} // RVA: 0x7FFE810FB310
    public void Try$BurstManaged(){} // RVA: 0x7FFE878B8530
}

public class SliderEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE88012BF0
}

public class Slot : ValueType
{
}

public class SlotDefinition : ValueType
{
}

public class SlotUsageEntry : ValueType
{
}

public class SmallXmlNodeList : ValueType
{
    public object field; // 0x10
    public object field_1; // 0x24F

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFE875A0CF0
    public void get_Item(){} // RVA: 0x7FFE875A0D90
    public void Add(){} // RVA: 0x7FFE875A0ED0
    public void RemoveAt(){} // RVA: 0x7FFE875A1140
    public void Insert(){} // RVA: 0x7FFE875A1290
    public void GetEnumerator(){} // RVA: 0x7FFE875A14B0
}

public class Snapshot : ValueType
{
    public string avatarName; // 0x10
    public System.Nullable`1<int> polyCount; // 0x18

    // ── Methods ──
    public void get_downloadSize(){} // RVA: 0x7FFE8A4F4E40
    public void get_uncompressedSize(){} // RVA: 0x7FFE8A4F4EE0
    public void .ctor(){} // RVA: 0x7FFE8A4F4F80
    public void ToString(){} // RVA: 0x7FFE8A4F53F0
}

public class SortedColumnState : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE815AE520
}

public class SortedListDebugView : Object
{
}

public class SortedListEnumerator : Object
{
    public System.Collections.SortedList _sortedList; // 0x10
    public object _key; // 0x18
    public object _value; // 0x20
    public int _index; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86942580
    public void Clone(){} // RVA: 0x7FFE868BC310
    public void get_Key(){} // RVA: 0x7FFE86942610
    public void MoveNext(){} // RVA: 0x7FFE869426E0
    public void get_Entry(){} // RVA: 0x7FFE86942930
    public void get_Current(){} // RVA: 0x7FFE86942A10
    public void get_Value(){} // RVA: 0x7FFE86942AF0
    public void Reset(){} // RVA: 0x7FFE86942BC0
}

public class SortedListKeyEnumerator : Object
{
    public System.Collections.Generic.SortedList`2<U,T> _sortedList;
    public int _index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE80E45FE0
}

public class SortedListValueEnumerator : Object
{
    public System.Collections.Generic.SortedList`2<U,T> _sortedList;
    public int _index;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFE80E45FE0
}

public class SorterGenericArray : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A10DE0
    public void SwapIfGreaterWithItems(){} // RVA: 0x7FFE86A10F60
    public void Swap(){} // RVA: 0x7FFE86A110E0
    public void Sort(){} // RVA: 0x7FFE86A111D0
    public void IntrospectiveSort(){} // RVA: 0x7FFE86A111E0
    public void IntroSort(){} // RVA: 0x7FFE86A112D0
    public void PickPivotAndPartition(){} // RVA: 0x7FFE86A113B0
    public void Heapsort(){} // RVA: 0x7FFE86A11560
    public void DownHeap(){} // RVA: 0x7FFE86A11620
    public void InsertionSort(){} // RVA: 0x7FFE86A11870
}

public class SorterObjectArray : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A0FEE0
    public void SwapIfGreaterWithItems(){} // RVA: 0x7FFE86A10060
    public void Swap(){} // RVA: 0x7FFE86A10270
    public void Sort(){} // RVA: 0x7FFE86A10410
    public void IntrospectiveSort(){} // RVA: 0x7FFE86A10420
    public void IntroSort(){} // RVA: 0x7FFE86A104F0
    public void PickPivotAndPartition(){} // RVA: 0x7FFE86A105D0
    public void Heapsort(){} // RVA: 0x7FFE86A10770
    public void DownHeap(){} // RVA: 0x7FFE86A10830
    public void InsertionSort(){} // RVA: 0x7FFE86A10B50
}

public class SortingData : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE881FF120
}

public class SortingGroupsUpdate : ValueType
{
}

public class Sounds : ValueType
{
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
}

public class SpaceEraseCompleteData : ValueType
{
}

public class SpaceFilterInfoComponents : ValueType
{
}

public class SpaceFilterInfoIds : ValueType
{
}

public class SpaceLocationf : ValueType
{
}

public class SpaceQueryCompleteData : ValueType
{
}

public class SpaceQueryInfo : ValueType
{
}

public class SpaceQueryResult : ValueType
{
}

public class SpaceQueryResultsData : ValueType
{
}

public class SpaceSaveCompleteData : ValueType
{
}

public class SpaceSemanticLabelInternal : ValueType
{
}

public class SpaceSetComponentStatusCompleteData : ValueType
{
}

public class SparseArray`1 : Object
{
    public T[] m_array;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E46530
    public void get_Current(){} // RVA: 0x7FFE80E2E2E0
    public void Add(){} // RVA: 0x7FFE810A1420
    public void Remove(){} // RVA: 0x7FFE810A1420
}

public class SpatialAnchorCreateCompleteData : ValueType
{
}

public class SpatialAnchorCreateInfo : ValueType
{
}

public class SpecialCharacter : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87B48560
}

public class Spectrum : Object
{
    public int selection; // 0x10

    // ── Methods ──
    public void get_Item(){} // RVA: 0x7FFE81E15700
    public void set_Item(){} // RVA: 0x7FFE81E15D40
    public void Equals(){} // RVA: 0x7FFE81E163A0
    public void op_Implicit(){} // RVA: 0x7FFE81E16A00
    public void CompareBaseObjects(){} // RVA: 0x7FFE81E17060
    public void IsNativeObjectAlive(){} // RVA: 0x7FFE81E176C0
    public void .ctor(){} // RVA: 0x7FFE81E17D20
    public void Initialize(){} // RVA: 0x7FFE81E17DE0
}

public class Sphere : ValueType
{
    // ── Methods ──
    public void ClosestPoint(){} // RVA: 0x7FFE881AA140
}

public class Spine : BodyPart
{
    public UnityEngine.Transform headTarget; // 0x48
    public UnityEngine.Transform pelvisTarget; // 0x50
    public float positionWeight; // 0x58
    public float rotationWeight; // 0x5C
    public float pelvisPositionWeight; // 0x60
    public float pelvisRotationWeight; // 0x64
    public UnityEngine.Transform chestGoal; // 0x68
    public float chestGoalWeight; // 0x70

    // ── Methods ──
    public void get_pelvis(){} // RVA: 0x7FFE81230110
    public void get_firstSpineBone(){} // RVA: 0x7FFE81230140
    public void get_chest(){} // RVA: 0x7FFE81230170
    public void get_neck(){} // RVA: 0x7FFE812301E0
    public void get_head(){} // RVA: 0x7FFE81230210
    public void get_anchorRotation(){} // RVA: 0x7FFE81166710
    public void set_anchorRotation(){} // RVA: 0x7FFE81166720
    public void get_anchorRelativeToHead(){} // RVA: 0x7FFE81166730
    public void set_anchorRelativeToHead(){} // RVA: 0x7FFE81166740
    public void get_VrcAdjustedSpineLengthFactor(){} // RVA: 0x7FFE81230240
    public void set_VrcAdjustedSpineLengthFactor(){} // RVA: 0x7FFE81230250
    public void OnRead(){} // RVA: 0x7FFE81230260
    public void PreSolve(){} // RVA: 0x7FFE81231BC0
    public void ApplyOffsets(){} // RVA: 0x7FFE81232360
    public void CalculateChestTargetRotation(){} // RVA: 0x7FFE81233080
    public void Solve(){} // RVA: 0x7FFE81233730
    public void FABRIKPass(){} // RVA: 0x7FFE81234BE0
    public void SolvePelvis(){} // RVA: 0x7FFE81234F90
    public void Write(){} // RVA: 0x7FFE81238030
    public void ResetOffsets(){} // RVA: 0x7FFE812382A0
    public void VrcSolveLockHead(){} // RVA: 0x7FFE81238400
    public void VrcPelvisPitchBack(){} // RVA: 0x7FFE81239C80
    public void VrcRotateSpineToChestGoal(){} // RVA: 0x7FFE8123A300
    public void VrcGetQuaternionAngle(){} // RVA: 0x7FFE8123A9D0
    public void VrcSmoothClampAngle(){} // RVA: 0x7FFE8123AA10
    public void VrcGetReflectedChestGoalPosition(){} // RVA: 0x7FFE8123AAD0
    public void VrcRotateSpineToChestGoalOld(){} // RVA: 0x7FFE8123AF20
    public void VrcApplyTposeRotationsRelativeTo(){} // RVA: 0x7FFE8123B210
    public void VrcApplyDeltaToSpineBones(){} // RVA: 0x7FFE8123B870
    public void VrcBlendQuaternion(){} // RVA: 0x7FFE8123E4E0
    public void VrcRotateTowardsHeadAt(){} // RVA: 0x7FFE8123EB40
    public void VrcAverageNeckRotation(){} // RVA: 0x7FFE8123ECE0
    public void VrcRotateNeckTowardsHeadTarget(){} // RVA: 0x7FFE8123F890
    public void VrcAngleOfRotationAroundAxis(){} // RVA: 0x7FFE81240F70
    public void VrcApplyChestTwist(){} // RVA: 0x7FFE812411B0
    public void VrcApplyChestSwing(){} // RVA: 0x7FFE81242D60
    public void VrcSinEaseIn01(){} // RVA: 0x7FFE81243470
    public void VrcGetTwistOnAxis(){} // RVA: 0x7FFE812434C0
    public void VrcOffsetBoneAndChildBones(){} // RVA: 0x7FFE81243590
    public void AdjustChestByHands(){} // RVA: 0x7FFE81243620
    public void InverseTranslateToHead(){} // RVA: 0x7FFE812441C0
    public void TranslatePelvis(){} // RVA: 0x7FFE81244350
    public void LimitPelvisPosition(){} // RVA: 0x7FFE81244E40
    public void Bend(){} // RVA: 0x7FFE812454E0 | overloaded x2
    public void .ctor(){} // RVA: 0x7FFE812458D0
}

public class SpineEffector : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE811BA800 | overloaded x2
}

public class SpriteAtlasManagerUpdate : ValueType
{
}

public class SpriteDataObject : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class SpriteFrame : ValueType
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFE87B54360
}

public class SpriteSize : ValueType
{
    // ── Methods ──
    public void ToString(){} // RVA: 0x7FFE87B54500
}

public class Sprites : ValueType
{
}

public class Sse : Object
{
    // ── Methods ──
    public void get_IsSseSupported(){} // RVA: 0x7FFE810FB320
    public void SHUFFLE(){} // RVA: 0x7FFE878B5D10
}

public class Sse2 : Object
{
    // ── Methods ──
    public void add_epi64(){} // RVA: 0x7FFE878B5D40
    public void mul_epu32(){} // RVA: 0x7FFE878B5D60
    public void slli_epi64(){} // RVA: 0x7FFE878B5D80
    public void srli_epi64(){} // RVA: 0x7FFE878B5E20
    public void xor_si128(){} // RVA: 0x7FFE878B5EE0
    public void shuffle_epi32(){} // RVA: 0x7FFE878B5F00
}

public class StackAllocator : ValueType
{
    public AllocatorHandle m_handle; // 0x10

    // ── Methods ──
    public void get_Handle(){} // RVA: 0x7FFE826F4220
    public void Try(){} // RVA: 0x7FFE878B7CB0 | overloaded x2
    public void Dispose(){} // RVA: 0x7FFE810FB310
    public void Try$BurstManaged(){} // RVA: 0x7FFE878B7D10
}

public class StackDebugView : Object
{
}

public class StackEnumerator : Object
{
    public System.Collections.Stack _stack; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86944080
    public void Clone(){} // RVA: 0x7FFE868BC310
    public void MoveNext(){} // RVA: 0x7FFE86944160
    public void get_Current(){} // RVA: 0x7FFE869442B0
    public void Reset(){} // RVA: 0x7FFE86944360
}

public class StackRow : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8164E250
}

public class StackRowStack : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86E4B270
    public void Dispose(){} // RVA: 0x7FFE86E4B330
    public void Push(){} // RVA: 0x7FFE86E4B400
    public void Pop(){} // RVA: 0x7FFE86E4B5A0
    public void Enlarge(){} // RVA: 0x7FFE86E4B7D0
}

public class StandardValuesCollection : Object
{
    public System.Collections.ICollection values; // 0x10
    public System.Array valueArray; // 0x18
    public object field_2; // 0x308
    public object field_3; // 0x309
    public object field_4; // 0x30A

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE877DDAD0
    public void get_Count(){} // RVA: 0x7FFE877DDC30
    public void get_Item(){} // RVA: 0x7FFE877DDCA0
    public void CopyTo(){} // RVA: 0x7FFE877DDDF0
    public void GetEnumerator(){} // RVA: 0x7FFE877DDE60
    public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE877DDEB0
    public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
    public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE813240E0
    public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE877DDDF0
    public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE877DDE60
}

public class StartSendingMsg : Object
{
    // ── Methods ──
    public void Process(){} // RVA: 0x7FFE879AA810
}

public class State : ValueType
{
}

public class StateChangeMonitorDelegate : Object
{
    // ── Methods ──
    public void NotifyControlStateChanged(){} // RVA: 0x7FFE87A289F0
    public void NotifyTimerExpired(){} // RVA: 0x7FFE87A28A20
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class StateChangeMonitorListener : ValueType
{
}

public class StateChangeMonitorTimeout : ValueType
{
}

public class StateChangeMonitorsForDevice : ValueType
{
    public BitRegion[] memoryRegions; // 0x10

    // ── Methods ──
    public void get_count(){} // RVA: 0x7FFE81549710
    public void Add(){} // RVA: 0x7FFE879C6320
    public void Remove(){} // RVA: 0x7FFE879C6650
    public void Clear(){} // RVA: 0x7FFE879C6720
    public void CompactArrays(){} // RVA: 0x7FFE879C67C0
    public void RemoveAt(){} // RVA: 0x7FFE879C6820
    public void SortMonitorsByIndex(){} // RVA: 0x7FFE879C69D0
}

public class StateChanged : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE84261260
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class StateDownHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE823D7070
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE86FE8380
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}
