// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 76
// Methods: 429

public class Array3 : ValueType
{
    public float* x; // 0x10
    public float* y; // 0x18
    public float* z; // 0x20
}

public class Array32768`1 : ValueType
{
    public Array4096`1<T> Length;
    public Array4096`1<T> f1;
    public Array4096`1<T> f2;
    public Array4096`1<T> f3;
    public Array4096`1<T> f4;
    public Array4096`1<T> f5;
    public Array4096`1<T> f6;
    public Array4096`1<T> f7;

    // ── Methods ──
    public void get_Length(){} // RVA: 0x7FFAC2C59960
    public void ElementAt(){} // RVA: 0x7FFAC2C67DE0
}

public class Array4 : ValueType
{
    public float* x; // 0x10
    public float* y; // 0x18
    public float* z; // 0x20
    public float* w; // 0x28
}

public class Array4096`1 : ValueType
{
    public Array256`1<T> f0;
    public Array256`1<T> f1;
    public Array256`1<T> f2;
    public Array256`1<T> f3;
    public Array256`1<T> f4;
    public Array256`1<T> f5;
    public Array256`1<T> f6;
    public Array256`1<T> f7;
    public Array256`1<T> f8;
    public Array256`1<T> f9;
    public Array256`1<T> f10;
    public Array256`1<T> f11;
    public Array256`1<T> f12;
    public Array256`1<T> f13;
    public Array256`1<T> f14;
    public Array256`1<T> f15;
}

public class ArrayEnumerator : Object
{
    public System.Array Current; // 0x10
    public int _index; // 0x18
    public int _endIndex; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC86664A0
    public void MoveNext(){} // RVA: 0x7FFAC8666520
    public void Reset(){} // RVA: 0x7FFAC47EDC40
    public void Clone(){} // RVA: 0x7FFAC8512B10
    public void get_Current(){} // RVA: 0x7FFAC8666540
}

public class ArrayListDebugView : Object
{
}

public class ArrayListEnumeratorSimple : Object
{
    public System.Collections.ArrayList Current; // 0x10
    public int _index; // 0x18
    public int _version; // 0x1C
    public object _currentElement; // 0x20
    public bool _isArrayList; // 0x28
    public object s_dummyObject;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC859FB00
    public void Clone(){} // RVA: 0x7FFAC8512B10
    public void MoveNext(){} // RVA: 0x7FFAC859FCF0
    public void get_Current(){} // RVA: 0x7FFAC859FEF0
    public void Reset(){} // RVA: 0x7FFAC859FFF0
    public void .cctor(){} // RVA: 0x7FFAC85A0100
}

public class ArrayPoolImpl`1 : Object
{
    public object ObjectType;
    public System.Collections.Generic.Dictionary`2<int,SizeGroup<T>> CountInactive;
    public ArrayPoolImpl`1<T> Instance;

    // ── Methods ──
    public void get_ObjectType(){} // RVA: 0x7FFAC2C58E90
    public void get_CountInactive(){} // RVA: 0x7FFAC2C59960
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Get(){} // RVA: 0x7FFAC2E8DC40
    public void Contains(){} // RVA: 0x7FFAC2C59F60
    public void Release(){} // RVA: 0x7FFAC2C70A40
    public void Cleanup(){} // RVA: 0x7FFAC2C59960
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class ArrayPropertyDescriptor : SimplePropertyDescriptor
{
    public int _index; // 0x98

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC93E9260
    public void GetValue(){} // RVA: 0x7FFAC93E9320
    public void SetValue(){} // RVA: 0x7FFAC93E93F0
}

public class ArraySubsetEnumerator : Object
{
    public System.Array Current; // 0x10
    public int _total; // 0x18
    public int _current; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC93FCD90
    public void MoveNext(){} // RVA: 0x7FFAC93FCE00
    public void Reset(){} // RVA: 0x7FFAC92CED60
    public void get_Current(){} // RVA: 0x7FFAC93FCE20
}

public class ArraySurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFACC07D000
    public void SetObjectData(){} // RVA: 0x7FFACC07D9D0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class Article : ApiModel
{
    public System.Collections.Generic.List`1<ArticleContent> content; // 0x68
    public System.Collections.Generic.List`1<string> sectionLinks; // 0x70
    public System.Collections.Generic.List`1<VRC.Core.ApiBindingCommandReference> embeddedLinkData; // 0x78
    public System.Collections.Generic.List`1<VRC.Core.ApiBindingCommandReference> moreInfoLinks; // 0x80

    // ── Methods ──
    public void get_content(){} // RVA: 0x7FFAC2F9CD50
    public void set_content(){} // RVA: 0x7FFAC2F9CD60
    public void get_sectionLinks(){} // RVA: 0x7FFAC2FE9590
    public void set_sectionLinks(){} // RVA: 0x7FFAC2FE95A0
    public void get_embeddedLinkData(){} // RVA: 0x7FFAC30E5600
    public void set_embeddedLinkData(){} // RVA: 0x7FFAC30E06F0
    public void get_moreInfoLinks(){} // RVA: 0x7FFAC32EF410
    public void set_moreInfoLinks(){} // RVA: 0x7FFAC34D4AA0
    public void .ctor(){} // RVA: 0x7FFACBE79610
}

public class ArticleContent : ApiModel
{
    public string title; // 0x68
    public string text; // 0x70
    public string imageUrl; // 0x78
    public string videoUrl; // 0x80
    public VRC.Core.ApiBindingCommandReference onPressed; // 0x88

    // ── Methods ──
    public void get_title(){} // RVA: 0x7FFAC2F9CD50
    public void set_title(){} // RVA: 0x7FFAC2F9CD60
    public void get_text(){} // RVA: 0x7FFAC2FE9590
    public void set_text(){} // RVA: 0x7FFAC2FE95A0
    public void get_imageUrl(){} // RVA: 0x7FFAC30E5600
    public void set_imageUrl(){} // RVA: 0x7FFAC30E06F0
    public void get_videoUrl(){} // RVA: 0x7FFAC32EF410
    public void set_videoUrl(){} // RVA: 0x7FFAC34D4AA0
    public void get_onPressed(){} // RVA: 0x7FFAC2F60010
    public void set_onPressed(){} // RVA: 0x7FFAC354E300
    public void .ctor(){} // RVA: 0x7FFACBE79660
}

public class AsciiPreescapedData : ValueType
{
    public <Data>e__FixedBuffer Data; // 0x10

    // ── Methods ──
    public void PopulatePreescapedData(){} // RVA: 0x7FFAC8FCD960
    public void TryGetPreescapedData(){} // RVA: 0x7FFAC8A860A0
}

public class Asn1SequenceParserImpl : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Sequence outer; // 0x10
    public int max; // 0x18
    public int index; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBCD5000
    public void ReadObject(){} // RVA: 0x7FFACBCD5080
    public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
}

public class Asn1SetParserImpl : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Asn1Set outer; // 0x10
    public int max; // 0x18
    public int index; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBCD63F0
    public void ReadObject(){} // RVA: 0x7FFACBCD6470
    public void ToAsn1Object(){} // RVA: 0x7FFAC2F3C380
}

public class AspectStretcher : ValueType
{
    public float Aspect; // 0x10
    public float m_InverseAspect; // 0x14
    public float m_CenterX; // 0x18

    // ── Methods ──
    public void get_Aspect(){} // RVA: 0x7FFAC484C150
    public void .ctor(){} // RVA: 0x7FFAC484C160
    public void Stretch(){} // RVA: 0x7FFAC484C180
    public void Unstretch(){} // RVA: 0x7FFAC484C1B0
}

public class AssetBundleCreateRequestAwaiter : ValueType
{
    public UnityEngine.AssetBundleCreateRequest IsCompleted; // 0x10
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3BB0830
    public void get_IsCompleted(){} // RVA: 0x7FFAC94CED00
    public void GetResult(){} // RVA: 0x7FFAC94D4650
    public void OnCompleted(){} // RVA: 0x7FFAC94D4860
    public void UnsafeOnCompleted(){} // RVA: 0x7FFAC94D4870
}

public class AssetBundleCreateRequestConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AssetBundleCreateRequestConfiguredSource> NextNode;
    public AssetBundleCreateRequestConfiguredSource nextNode; // 0x10
    public UnityEngine.AssetBundleCreateRequest asyncOperation; // 0x18
    public System.IProgress`1<float> progress; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public bool completed; // 0x49
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<UnityEngine.AssetBundle> core; // 0x50
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x78

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC94D49A0
    public void .ctor(){} // RVA: 0x7FFAC94D4B20
    public void Create(){} // RVA: 0x7FFAC94D4BE0
    public void GetResult(){} // RVA: 0x7FFAC94D5150
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC94D53D0
    public void GetStatus(){} // RVA: 0x7FFAC94D53E0
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC94D5430
    public void OnCompleted(){} // RVA: 0x7FFAC94D5470
    public void MoveNext(){} // RVA: 0x7FFAC94D54F0
    public void TryReturn(){} // RVA: 0x7FFAC94D5630
    public void Continuation(){} // RVA: 0x7FFAC94D57A0
}

public class AssetBundleRequestAllAssetsAwaiter : ValueType
{
    public UnityEngine.AssetBundleRequest IsCompleted; // 0x10
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3BB0830
    public void GetAwaiter(){} // RVA: 0x7FFAC32C0590
    public void get_IsCompleted(){} // RVA: 0x7FFAC94CED00
    public void GetResult(){} // RVA: 0x7FFAC94CED60
    public void OnCompleted(){} // RVA: 0x7FFAC94CEF70
    public void UnsafeOnCompleted(){} // RVA: 0x7FFAC94CEF80
}

public class AssetBundleRequestAllAssetsConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AssetBundleRequestAllAssetsConfiguredSource> NextNode;
    public AssetBundleRequestAllAssetsConfiguredSource nextNode; // 0x10
    public UnityEngine.AssetBundleRequest asyncOperation; // 0x18
    public System.IProgress`1<float> progress; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public bool completed; // 0x49
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<UnityEngine.Object[]> core; // 0x50
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x78

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC94CF0B0
    public void .ctor(){} // RVA: 0x7FFAC94CF230
    public void Create(){} // RVA: 0x7FFAC94CF2F0
    public void GetResult(){} // RVA: 0x7FFAC94CF860
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC94CFAC0
    public void GetStatus(){} // RVA: 0x7FFAC94CFAD0
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC94CFB20
    public void OnCompleted(){} // RVA: 0x7FFAC94CFB60
    public void MoveNext(){} // RVA: 0x7FFAC94CFBE0
    public void TryReturn(){} // RVA: 0x7FFAC94CFD20
    public void Continuation(){} // RVA: 0x7FFAC94CFE80
}

public class AssetBundleRequestAwaiter : ValueType
{
    public UnityEngine.AssetBundleRequest IsCompleted; // 0x10
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3BB0830
    public void get_IsCompleted(){} // RVA: 0x7FFAC94CED00
    public void GetResult(){} // RVA: 0x7FFAC94D2140
    public void OnCompleted(){} // RVA: 0x7FFAC94D3490
    public void UnsafeOnCompleted(){} // RVA: 0x7FFAC94D34A0
}

public class AssetBundleRequestConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AssetBundleRequestConfiguredSource> NextNode;
    public AssetBundleRequestConfiguredSource nextNode; // 0x10
    public UnityEngine.AssetBundleRequest asyncOperation; // 0x18
    public System.IProgress`1<float> progress; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public bool completed; // 0x49
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<UnityEngine.Object> core; // 0x50
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x78

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC94D35D0
    public void .ctor(){} // RVA: 0x7FFAC94D3750
    public void Create(){} // RVA: 0x7FFAC94D3810
    public void GetResult(){} // RVA: 0x7FFAC94D3D80
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC94D4000
    public void GetStatus(){} // RVA: 0x7FFAC94D4010
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC94D4060
    public void OnCompleted(){} // RVA: 0x7FFAC94D40A0
    public void MoveNext(){} // RVA: 0x7FFAC94D4120
    public void TryReturn(){} // RVA: 0x7FFAC94D4270
    public void Continuation(){} // RVA: 0x7FFAC94D43E0
}

public class AssetEntry : ValueType
{
    public string type; // 0x10
    public string typeFullName; // 0x18
    public UnityEngine.Object asset; // 0x20
    public System.Type m_CachedType; // 0x28

    // ── Methods ──
    public void get_type(){} // RVA: 0x7FFAC9ABB3A0
    public void .ctor(){} // RVA: 0x7FFAC9ABB480
}

public class AssetPreloader : Object
{
    public ÌÏÍÍÎÍÎÍÌÍÎÌÏÎÌÌÎÎÏÌÎÌÌ _name; // 0x10
    public System.Collections.Generic.List`1<string> _hideFlags; // 0x18
    public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiWorld> f_4F2; // 0x20
    public bool <ÌÍÌÌÌÏÏÍÌÍÎÎÎÌÏÏÏÌÌÍÏÍÎ>k__BackingField; // 0x28
    public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.IList> <ÌÎÌÏÏÍÎÍÎÌÎÏÍÏÏÎÍÎÏÏÌÏÌ>k__BackingField; // 0x30
    public System.Collections.Generic.List`1<VRC.Core.ApiWorld> ÍÍÏÌÍÌÍÎÏÎÏÏÏÌÏÎÏÍÎÏÍÎÎ; // 0x38
    public string ÎÍÏÎÌÏÎÎÌÏÌÎÏÌÌÍÎÏÌÏÌÏÍ;
    public ÏÌÎÌÍÎÌÏÏÎÏÎÍÌÌÍÏÍÍÌÏÏÎ<System.Collections.Generic.IReadOnlyList`1<ÎÏÏÍÍÍÏÎÎÏÎÎÎÎÍÌÎÌÍÍÌÏÏ>> <ÎÌÎÌÎÍÍÍÌÏÌÎÏÌÎÎÍÌÎÎÏÌÎ>k__BackingField; // 0x40
    public System.Collections.Generic.List`1<ÎÏÏÍÍÍÏÎÎÏÎÎÎÎÍÌÎÌÍÍÌÏÏ> ÎÌÌÎÍÎÍÏÌÌÎÎÎÏÍÍÌÏÌÍÎÍÏ; // 0x48
    public System.Collections.Generic.HashSet`1<string> ÍÏÏÍÏÏÏÌÏÍÏÏÌÌÌÌÎÏÎÌÏÎÌ; // 0x50
    public System.Collections.Generic.Dictionary`2<string,System.Threading.CancellationTokenSource> ÍÏÍÌÍÏÌÏÌÌÏÌÎÌÏÏÎÍÌÌÎÎÏ; // 0x58
    public int ÏÎÌÏÌÍÏÏÍÏÎÍÎÎÏÎÌÌÌÏÍÎÏ;

    // ── Methods ──
    public void Finalize(){} // RVA: 0x7FFAC3C23300
    public void Equals(){} // RVA: 0x7FFAC3C23520
    public void GetHashCode(){} // RVA: 0x7FFAC3C236B0
    public void op_Implicit(){} // RVA: 0x7FFAC3C23830
    public void CompareBaseObjects(){} // RVA: 0x7FFAC3C23D80
    public void GetBufferedTimes(){} // RVA: 0x7FFAC2F9E740
    public void GetCachedPtr(){} // RVA: 0x7FFAC3C23E80
    public void get_name(){} // RVA: 0x7FFAC3C23FB0
    public void Initialize(){} // RVA: 0x7FFAC3C24180
    public void Instantiate(){} // RVA: 0x7FFAC3C241F0
    public void ToString(){} // RVA: 0x7FFAC3C246B0
    public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
    public void InitializePreloadData(){} // RVA: 0x7FFAC3C247E0
    public void BuildPreloadManifest(){} // RVA: 0x7FFAC3C24D30
    public void IsSetup(){} // RVA: 0x7FFAC3C24D50
    public void HandlePreloaderDataInitialization(){} // RVA: 0x7FFAC3C24E10
    public void set_Color(){} // RVA: 0x7FFAC3C24F40
    public void GetPreloadedAssetData(){} // RVA: 0x7FFAC34F9180
    public void ConfigureAssetPreloader(){} // RVA: 0x7FFAC3C24F50
    public void Destroy(){} // RVA: 0x7FFAC3C25140
    public void Cleanup(){} // RVA: 0x7FFAC3C25280
    public void DestroyImmediate(){} // RVA: 0x7FFAC3C25380
    public void DestroyImmediate_23F188AB430E(){} // RVA: 0x7FFAC3C25540
    public void FindObjectsOfType(){} // RVA: 0x7FFAC3C256E0
    public void FindObjectsOfType_B0FED4068939(){} // RVA: 0x7FFAC30F6BA0
    public void FindObjectsByType(){} // RVA: 0x7FFAC3C25820
    public void .ctor(){} // RVA: 0x7FFAC3C25A20
    public void DontDestroyOnLoad(){} // RVA: 0x7FFAC3C26300
    public void CompositionMethod(){} // RVA: 0x7FFAC3013AF0
    public void set_hideFlags(){} // RVA: 0x7FFAC3C263C0
    public void Initialize_C7F63F0380B4(){} // RVA: 0x7FFAC3C26910
    public void FindObjectOfType(){} // RVA: 0x7FFAC3C26D80
    public void Dispose(){} // RVA: 0x7FFAC3C26FE0
    public void FindFirstObjectByType(){} // RVA: 0x7FFAC3C270B0
    public void CheckNullArgument(){} // RVA: 0x7FFAC3C27290
}

public class AssociatedDetection : Object
{
    public Google.Protobuf.MessageParser`1<AssociatedDetection> Parser;
    public Google.Protobuf.UnknownFieldSet Descriptor; // 0x10
    public int pb::Google.Protobuf.IMessage.Descriptor; // 0x18
    public int Id;
    public int HasId; // 0x8
    public int Confidence; // 0x1C
    public int HasConfidence;
    public float ConfidenceDefaultValue; // 0xC
    public float confidence_; // 0x20

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFAC82A3EF0
    public void get_Descriptor(){} // RVA: 0x7FFAC82A3F50
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFAC82A3FD0
    public void .ctor(){} // RVA: 0x7FFAC82A4080 | overloaded x2
    public void Clone(){} // RVA: 0x7FFAC82A4170
    public void get_Id(){} // RVA: 0x7FFAC82A4290
    public void set_Id(){} // RVA: 0x7FFAC81F3760
    public void get_HasId(){} // RVA: 0x7FFAC81F3770
    public void ClearId(){} // RVA: 0x7FFAC81F3780
    public void get_Confidence(){} // RVA: 0x7FFAC82A4300
    public void set_Confidence(){} // RVA: 0x7FFAC829E080
    public void get_HasConfidence(){} // RVA: 0x7FFAC81F3810
    public void ClearConfidence(){} // RVA: 0x7FFAC81F3820
    public void Equals(){} // RVA: 0x7FFAC82A44C0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFAC82A45E0
    public void ToString(){} // RVA: 0x7FFAC82A46C0
    public void WriteTo(){} // RVA: 0x7FFAC81D0B60
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFAC82A4710
    public void CalculateSize(){} // RVA: 0x7FFAC82A47A0
    public void MergeFrom(){} // RVA: 0x7FFAC81D0EA0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFAC82A4950
    public void .cctor(){} // RVA: 0x7FFAC82A49F0
}

public class AsyncGPUReadbackRequestAwaiterConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AsyncGPUReadbackRequestAwaiterConfiguredSource> NextNode;
    public AsyncGPUReadbackRequestAwaiterConfiguredSource nextNode; // 0x10
    public UnityEngine.Rendering.AsyncGPUReadbackRequest asyncOperation; // 0x18
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<UnityEngine.Rendering.AsyncGPUReadbackRequest> core; // 0x50

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC94D0130
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Create(){} // RVA: 0x7FFAC94D02B0
    public void GetResult(){} // RVA: 0x7FFAC94D0720
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC94D08F0
    public void GetStatus(){} // RVA: 0x7FFAC94D0910
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC94D0960
    public void OnCompleted(){} // RVA: 0x7FFAC94D09A0
    public void MoveNext(){} // RVA: 0x7FFAC94D0A20
    public void TryReturn(){} // RVA: 0x7FFAC94D0BF0
}

public class AsyncInstantiateOperationConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AsyncInstantiateOperationConfiguredSource> NextNode;
    public AsyncInstantiateOperationConfiguredSource nextNode; // 0x10
    public UnityEngine.AsyncInstantiateOperation asyncOperation; // 0x18
    public System.IProgress`1<float> progress; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public bool completed; // 0x49
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<UnityEngine.Object[]> core; // 0x50
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x78

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC94D7810
    public void .ctor(){} // RVA: 0x7FFAC94D7990
    public void Create(){} // RVA: 0x7FFAC94D7A50
    public void GetResult(){} // RVA: 0x7FFAC94D7FC0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC94D8240
    public void GetStatus(){} // RVA: 0x7FFAC94D8250
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC94D82A0
    public void OnCompleted(){} // RVA: 0x7FFAC94D82E0
    public void MoveNext(){} // RVA: 0x7FFAC94D8360
    public void TryReturn(){} // RVA: 0x7FFAC94D84A0
    public void Continuation(){} // RVA: 0x7FFAC94D8610
}

public class AsyncInstantiateOperationConfiguredSource`1 : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AsyncInstantiateOperationConfiguredSource`1<T>> NextNode;
    public AsyncInstantiateOperationConfiguredSource`1<T> nextNode;
    public UnityEngine.AsyncInstantiateOperation`1<T> asyncOperation;
    public System.IProgress`1<float> progress;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration;
    public bool cancelImmediately;
    public bool completed;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<T[]> core;
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC2C58E90
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
    public void .ctor(){} // RVA: 0x7FFAC2C70980
    public void Create(){} // RVA: 0x7FFAC2E8DC40
    public void GetResult(){} // RVA: 0x7FFAC2C68E00
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
    public void TryReturn(){} // RVA: 0x7FFAC2C59D00
    public void Continuation(){} // RVA: 0x7FFAC2C70A40
}

public class AsyncManualResetEvent : Object
{
    public System.Threading.Tasks.TaskCompletionSource`1<bool> m_tcs; // 0x10

    // ── Methods ──
    public void WaitAsync(){} // RVA: 0x7FFAC930C990
    public void Set(){} // RVA: 0x7FFAC930C9F0
    public void Reset(){} // RVA: 0x7FFAC930CD20
    public void .ctor(){} // RVA: 0x7FFAC930CF50
}

public class AsyncOperationAwaiter : ValueType
{
    public UnityEngine.AsyncOperation IsCompleted; // 0x10
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3BB0830
    public void get_IsCompleted(){} // RVA: 0x7FFAC94CED00
    public void GetResult(){} // RVA: 0x7FFAC94D0E30
    public void OnCompleted(){} // RVA: 0x7FFAC94D0F80
    public void UnsafeOnCompleted(){} // RVA: 0x7FFAC94D0F90
}

public class AsyncOperationConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AsyncOperationConfiguredSource> NextNode;
    public AsyncOperationConfiguredSource nextNode; // 0x10
    public UnityEngine.AsyncOperation asyncOperation; // 0x18
    public System.IProgress`1<float> progress; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public bool completed; // 0x49
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x50
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x78

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC94D10C0
    public void .ctor(){} // RVA: 0x7FFAC94D1240
    public void Create(){} // RVA: 0x7FFAC94D1300
    public void GetResult(){} // RVA: 0x7FFAC94D1860
    public void GetStatus(){} // RVA: 0x7FFAC94D1AD0
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC94D1B20
    public void OnCompleted(){} // RVA: 0x7FFAC94D1B60
    public void MoveNext(){} // RVA: 0x7FFAC94D1BE0
    public void TryReturn(){} // RVA: 0x7FFAC94D1D40
    public void Continuation(){} // RVA: 0x7FFAC94D1EB0
}

public class AsyncTriggerEnumerator : MoveNextSource
{
    public System.Action`1<object> Current;
    public Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase`1<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev;
    public System.Threading.CancellationToken Cysharp.Threading.Tasks.ITriggerHandler<T>.Next;
    public System.Threading.CancellationTokenRegistration registration;
    public bool called;
    public bool isDisposed;
    public T <Current>k__BackingField;
    public Cysharp.Threading.Tasks.ITriggerHandler`1<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField;
    public Cysharp.Threading.Tasks.ITriggerHandler`1<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField;

    // ── Methods ──
    public void .ctor(){}
    public void OnCanceled(){} // RVA: 0x7FFAC2C70BF0
    public void OnNext(){} // RVA: 0x7FFAC2E8DC40
    public void OnCompleted(){} // RVA: 0x7FFAC2C70980
    public void OnError(){} // RVA: 0x7FFAC2C70A40
    public void CancellationCallback(){} // RVA: 0x7FFAC2C70A10
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7FFAC2C58E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7FFAC2C70A40
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7FFAC2C58E90
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7FFAC2C70A40
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class AsyncUnitSource : Object
{
    public Cysharp.Threading.Tasks.IUniTaskSource source; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void GetResult(){} // RVA: 0x7FFAC948B5F0
    public void GetStatus(){} // RVA: 0x7FFAC948B690
    public void OnCompleted(){} // RVA: 0x7FFAC948B6F0
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC948B780
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC948B7D0
}

public class AsyncUploadTimeSlicedUpdate : ValueType
{
}

public class AsyncWriter : Object
{
    public _Create<T> enumerator;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void Dispose(){} // RVA: 0x7FFAC2C70980
    public void GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void OnCompleted(){}
    public void YieldAsync(){} // RVA: 0x7FFAC2E8DC40
    public void SignalWriter(){} // RVA: 0x7FFAC2C70980
}

public class AttachExternalCancellationSource : Object
{
    public System.Action`1<object> cancellationCallbackDelegate;
    public System.Threading.CancellationToken cancellationToken; // 0x10
    public System.Threading.CancellationTokenRegistration tokenRegistration; // 0x18
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<Cysharp.Threading.Tasks.AsyncUnit> core; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC94A1920
    public void RunTask(){} // RVA: 0x7FFAC94A1C00
    public void CancellationCallback(){} // RVA: 0x7FFAC94A1D90
    public void GetResult(){} // RVA: 0x7FFAC94A1E10
    public void GetStatus(){} // RVA: 0x7FFAC94A1E60
    public void OnCompleted(){} // RVA: 0x7FFAC94A1EB0
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC94A1F30
    public void .cctor(){} // RVA: 0x7FFAC94A1F70
}

public class AttachExternalCancellationSource`1 : Object
{
    public System.Action`1<object> cancellationCallbackDelegate;
    public System.Threading.CancellationToken cancellationToken;
    public System.Threading.CancellationTokenRegistration tokenRegistration;
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<T> core;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void RunTask(){} // RVA: 0x7FFAC2E8DC40
    public void CancellationCallback(){} // RVA: 0x7FFAC2C70A10
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC2C70B70
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC2C59960
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class AttachedObject : ValueType
{
    public UnityEngine.GameObject attachedObject; // 0x10
    public Valve.VR.InteractionSystem.Interactable interactable; // 0x18
    public UnityEngine.Rigidbody attachedRigidbody; // 0x20
    public 0x6B2A0270 collisionDetectionMode; // 0x28
    public bool attachedRigidbodyWasKinematic; // 0x2C
    public bool attachedRigidbodyUsedGravity; // 0x2D
    public UnityEngine.GameObject originalParent; // 0x30
    public bool isParentedToHand; // 0x38
    public 0x6B20BBD0 grabbedWithType; // 0x3C
    public 0x6B20BC28 attachmentFlags; // 0x40
    public UnityEngine.Vector3 initialPositionalOffset; // 0x44
    public UnityEngine.Quaternion initialRotationalOffset; // 0x50
    public UnityEngine.Transform attachedOffsetTransform; // 0x60
    public UnityEngine.Transform handAttachmentPointTransform; // 0x68
    public UnityEngine.Vector3 easeSourcePosition; // 0x70
    public UnityEngine.Quaternion easeSourceRotation; // 0x7C
    public float attachTime; // 0x8C
    public Valve.VR.InteractionSystem.AllowTeleportWhileAttachedToHand allowTeleportWhileAttachedToHand; // 0x90

    // ── Methods ──
    public void HasAttachFlag(){} // RVA: 0x7FFAC8CB7650
}

public class AttrInfo : ValueType
{
    public QName name; // 0x10
    public string val; // 0x28
    public int contentPos; // 0x30
    public int hashCode; // 0x34
    public int prevHash; // 0x38

    // ── Methods ──
    public void Set(){} // RVA: 0x7FFAC9093CE0 | overloaded x2
    public void GetLocalnameAndNamespaceUri(){} // RVA: 0x7FFAC9093DB0
    public void GetLocalnameAndNamespaceUriAndHash(){} // RVA: 0x7FFAC9093E60
    public void MatchNS(){} // RVA: 0x7FFAC9093460
    public void MatchHashNS(){} // RVA: 0x7FFAC9093F60
    public void AdjustPosition(){} // RVA: 0x7FFAC9094010
}

public class AttrListImpl : Object
{
    public System.Collections.Generic.List`1<string> Length; // 0x10
    public System.Collections.Generic.List`1<string> Names; // 0x18

    // ── Methods ──
    public void get_Length(){} // RVA: 0x7FFAC8390E20
    public void GetName(){} // RVA: 0x7FFAC8390E70
    public void GetValue(){} // RVA: 0x7FFAC8390F70 | overloaded x2
    public void get_Names(){} // RVA: 0x7FFAC8391090
    public void get_Values(){} // RVA: 0x7FFAC83910E0
    public void Clear(){} // RVA: 0x7FFAC8391130
    public void Add(){} // RVA: 0x7FFAC83911C0
    public void .ctor(){} // RVA: 0x7FFAC83912D0
}

public class AttrName : ValueType
{
    public string prefix; // 0x10
    public string namespaceUri; // 0x18
    public string localName; // 0x20
    public int prev; // 0x28

    // ── Methods ──
    public void Set(){} // RVA: 0x7FFAC91D68D0
    public void IsDuplicate(){} // RVA: 0x7FFAC91D69F0
}

public class AttributeContent : Object
{
    public System.Xml.Schema.SchemaAttDef _AttDef; // 0x10
    public System.Xml.XmlQualifiedName _Name; // 0x18
    public string _Prefix; // 0x20
    public bool _Required; // 0x28
    public uint _MinVal; // 0x2C
    public uint _MaxVal; // 0x30
    public uint _MaxLength; // 0x34
    public uint _MinLength; // 0x38
    public bool _EnumerationRequired; // 0x3C
    public bool _HasDataType; // 0x3D
    public bool _Global; // 0x3E
    public object _Default; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class AttributeEntry : ValueType
{
    public System.Type type; // 0x10
    public int index; // 0x18
}

public class AttributeFilterCacheItem : Object
{
    public System.Attribute[] _filter; // 0x10
    public System.Collections.ICollection FilteredMembers; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
    public void IsValid(){} // RVA: 0x7FFAC94431B0
}

public class AttributeInfo : Object
{
    public System.AttributeUsageAttribute Usage; // 0x10
    public int InheritanceLevel; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC488C310
    public void get_Usage(){} // RVA: 0x7FFAC2F3C380
    public void get_InheritanceLevel(){} // RVA: 0x7FFAC3157800
}

public class AttributeOverride : ValueType
{
    public string m_ElementName; // 0x10
    public string m_AttributeName; // 0x18
    public string m_Value; // 0x20
}

public class AttributeProvider : TypeDescriptionProvider
{
    public System.Attribute[] _attrs; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8BF0300
    public void GetTypeDescriptor(){} // RVA: 0x7FFAC94423F0
}

public class AttributeTypeAndValue : Object
{
    public string Value; // 0x10
    public string attrValue; // 0x18
    public int upperBound; // 0x20
    public byte encoding; // 0x24

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83682B0 | overloaded x2
    public void set_Value(){} // RVA: 0x7FFAC8368320
    public void GetASN1(){} // RVA: 0x7FFAC83687E0 | overloaded x2
    public void SelectBestEncoding(){} // RVA: 0x7FFAC83687F0
}

public class AttributeTypeDescriptor : CustomTypeDescriptor
{
    public System.Attribute[] _attributeArray; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC46FBCC0
    public void GetAttributes(){} // RVA: 0x7FFAC94425D0
}

public class AttributeValueCache : Object
{
    public System.Text.StringBuilder StringValue; // 0x10
    public string singleStringValue; // 0x18
    public Item[] items; // 0x20
    public int firstItem; // 0x28
    public int lastItem; // 0x2C

    // ── Methods ──
    public void get_StringValue(){} // RVA: 0x7FFAC91D6AE0
    public void WriteEntityRef(){} // RVA: 0x7FFAC91D6B20
    public void WriteCharEntity(){} // RVA: 0x7FFAC91D6DA0
    public void WriteSurrogateCharEntity(){} // RVA: 0x7FFAC91D6E30
    public void WriteWhitespace(){} // RVA: 0x7FFAC91D6F00
    public void WriteString(){} // RVA: 0x7FFAC91D6F60
    public void WriteChars(){} // RVA: 0x7FFAC91D7010
    public void WriteRaw(){} // RVA: 0x7FFAC91D7230 | overloaded x2
    public void WriteValue(){} // RVA: 0x7FFAC91D7290
    public void Replay(){} // RVA: 0x7FFAC91D72F0
    public void Trim(){} // RVA: 0x7FFAC91D7740
    public void Clear(){} // RVA: 0x7FFAC91D7D00
    public void StartComplexValue(){} // RVA: 0x7FFAC91D7D80
    public void AddItem(){} // RVA: 0x7FFAC91D7E10
    public void .ctor(){} // RVA: 0x7FFAC91D8210
}

public class AudioConfigurationChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC40BEC20
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
}

public class AudioFixedUpdate : ValueType
{
}

public class AudioTrack : ValueType
{
    public int trackIndex; // 0x10
    public uint channelCount; // 0x14
    public uint sampleRate; // 0x18
    public uint bitsPerSample; // 0x1C
    public uint averageBitRate; // 0x20
}

public class AuthData : ValueType
{
    public string url; // 0x10
    public string token; // 0x18
    public UIntPtr keyBytes; // 0x20
    public int keyBytesLength; // 0x28
}

public class AuthEnvelopedSecureReadable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAuthEnvelopedData Algorithm; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void get_Algorithm(){} // RVA: 0x7FFAC3773190
    public void get_CryptoObject(){} // RVA: 0x7FFAC34F9180
    public void GetReadable(){} // RVA: 0x7FFACBC9B7B0
}

public class AuthorizationArgs : ValueType
{
    public UIntPtr Handle; // 0x10

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFAC49763C0
    public void Drop(){} // RVA: 0x7FFAC4976440
    public void SetClientId(){} // RVA: 0x7FFAC49764C0
    public void SetScopes(){} // RVA: 0x7FFAC4976550
}

public class AuthorizationCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC497DCA0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class AuthorizationState : ValueType
{
    public System.Net.HttpWebRequest IsCompleted; // 0x10
    public bool NtlmAuthState; // 0x18
    public bool IsNtlmAuthenticated; // 0x19
    public 0x6B13D2A8 ntlm_auth_state; // 0x1C

    // ── Methods ──
    public void get_IsCompleted(){} // RVA: 0x7FFAC3AD01E0
    public void get_NtlmAuthState(){} // RVA: 0x7FFAC49C7520
    public void get_IsNtlmAuthenticated(){} // RVA: 0x7FFAC92FAC50
    public void .ctor(){} // RVA: 0x7FFAC92FAC70
    public void CheckAuthorization(){} // RVA: 0x7FFAC92FACE0
    public void Reset(){} // RVA: 0x7FFAC92FB0F0
    public void ToString(){} // RVA: 0x7FFAC92FB1C0
}

public class AutoDetectParams : ValueType
{
    public bool Default; // 0x10
    public bool includeEyes; // 0x11

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F752A0
    public void get_Default(){} // RVA: 0x7FFAC2F752B0
}

public class AutoDolly : ValueType
{
    public bool m_Enabled; // 0x10
    public float m_PositionOffset; // 0x14
    public int m_SearchRadius; // 0x18
    public int m_SearchResolution; // 0x1C

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC4833600
}

public class AutoScope : ValueType
{
    public UIntPtr m_Ptr; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC984F2D0
    public void Dispose(){} // RVA: 0x7FFAC30F0DB0
}

public class AvailableDevice : ValueType
{
    public UnityEngine.InputSystem.Layouts.InputDeviceDescription description; // 0x10
    public int deviceId; // 0x48
    public bool isNative; // 0x4C
    public bool isRemoved; // 0x4D
}

public class AvatarCullingMonitor : Object
{
    public float AvatarScreenSizeAboveTriggerThreshold; // 0x10
    public float AvatarKindValidForExecution; // 0x14
    public 0x6B002030[] AvatarCullableShouldRun; // 0x18
    public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ _owningPlayer; // 0x20
    public bool _hasOwningPlayer; // 0x28
    public bool _isBoundToAvatarKind; // 0x29
    public System.Nullable`1<bool> _hasValidAvatarKind; // 0x2A
    public bool _isBoundToAvatarScreenSize; // 0x2C
    public bool _aboveTriggerThreshold; // 0x2D
    public System.Action _cullingChangedCallback; // 0x30

    // ── Methods ──
    public void get_AvatarCullableShouldRun(){} // RVA: 0x7FFAC3B56C40
    public void set_AvatarCullableShouldRun(){} // RVA: 0x7FFAC3B56CB0
    public void set_AvatarScreenSizeAboveTriggerThreshold(){} // RVA: 0x7FFAC3B56CE0
    public void op_Implicit(){} // RVA: 0x7FFAC3B56DE0
    public void CompareBaseObjects(){} // RVA: 0x7FFAC3B56EE0
    public void .ctor(){} // RVA: 0x7FFAC3B56FE0
    public void get_AvatarScreenSizeAboveTriggerThreshold(){} // RVA: 0x7FFAC3B56FF0
    public void get_AvatarKindValidForExecution(){} // RVA: 0x7FFAC3B57000
    public void set_AvatarKindValidForExecution(){} // RVA: 0x7FFAC3B57070
    public void Instantiate(){} // RVA: 0x7FFAC3B570D0
    public void Equals(){} // RVA: 0x7FFAC3B571D0
    public void Dispose(){} // RVA: 0x7FFAC3B572D0
    public void Cleanup(){} // RVA: 0x7FFAC3B57350
    public void GetHashCode(){} // RVA: 0x7FFAC3B574D0
    public void ToString(){} // RVA: 0x7FFAC3B575B0
    public void SteamVR_Behaviour_Boolean_OnState(){} // RVA: 0x7FFAC3B57610
    public void RefreshAvatarCullingState(){} // RVA: 0x7FFAC3B57710
}

public class AvatarOscConfig : Object
{
    public string id; // 0x10
    public string name; // 0x18
    public int hash; // 0x20
    public System.Collections.Generic.List`1<ParameterConfig> parameters; // 0x28
    public System.Collections.Generic.HashSet`1<0x6B027E38> _supportedTypes; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3BBF1A0 | overloaded x2
    public void GetByName(){} // RVA: 0x7FFAC3BBF080
}

public class Avoider : Object
{
    public UnityEngine.Transform[] raycastFrom; // 0x10
    public UnityEngine.Transform raycastTo; // 0x18
    public float raycastRadius; // 0x20
    public EffectorLink[] effectors; // 0x28
    public float smoothTimeIn; // 0x30
    public float smoothTimeOut; // 0x34
    public UnityEngine.LayerMask layers; // 0x38
    public UnityEngine.Vector3 offset; // 0x3C
    public UnityEngine.Vector3 offsetTarget; // 0x48
    public UnityEngine.Vector3 offsetV; // 0x54

    // ── Methods ──
    public void Solve(){} // RVA: 0x7FFAC3096210
    public void GetOffsetTarget(){} // RVA: 0x7FFAC3096460
    public void Raycast(){} // RVA: 0x7FFAC30966B0
    public void .ctor(){} // RVA: 0x7FFAC3096B50
}

public class Avx : Object
{
    // ── Methods ──
    public void mm256_load_ps(){} // RVA: 0x7FFAC4BBB8D0
    public void mm256_store_ps(){} // RVA: 0x7FFAC950D0C0
    public void mm256_loadu_si256(){} // RVA: 0x7FFAC4BBB8D0
    public void mm256_storeu_si256(){} // RVA: 0x7FFAC950D0C0
    public void mm256_set1_epi32(){} // RVA: 0x7FFAC950D0D0
}

public class Avx2 : Object
{
    public object IsAvx2Supported;

    // ── Methods ──
    public void get_IsAvx2Supported(){} // RVA: 0x7FFAC2F21320
    public void mm256_xor_si256(){} // RVA: 0x7FFAC950D0F0
    public void mm256_add_epi64(){} // RVA: 0x7FFAC950D150
    public void mm256_mul_epu32(){} // RVA: 0x7FFAC950D1C0
    public void mm256_slli_epi64(){} // RVA: 0x7FFAC950D230
    public void mm256_srli_epi64(){} // RVA: 0x7FFAC950D360
    public void mm256_shuffle_epi32(){} // RVA: 0x7FFAC950D4C0
}

public class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs
{
    public AwaitableSocketAsyncEventArgs WrapExceptionsInIOExceptions;
    public System.Action`1<object> s_completedSentinel; // 0x8
    public System.Action`1<object> s_availableSentinel; // 0x10
    public System.Action`1<object> _continuation; // 0xB8
    public System.Threading.ExecutionContext _executionContext; // 0xC0
    public object _scheduler; // 0xC8
    public short _token; // 0xD0
    public bool <WrapExceptionsInIOExceptions>k__BackingField; // 0xD2

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC93413E0
    public void get_WrapExceptionsInIOExceptions(){} // RVA: 0x7FFAC93414A0
    public void set_WrapExceptionsInIOExceptions(){} // RVA: 0x7FFAC93414B0
    public void Reserve(){} // RVA: 0x7FFAC93414C0
    public void Release(){} // RVA: 0x7FFAC9341590
    public void OnCompleted(){} // RVA: 0x7FFAC9341E90 | overloaded x2
    public void ReceiveAsync(){} // RVA: 0x7FFAC9341A10
    public void SendAsyncForNetworkStream(){} // RVA: 0x7FFAC9341C30
    public void GetStatus(){} // RVA: 0x7FFAC9341DF0
    public void InvokeContinuation(){} // RVA: 0x7FFAC93421E0
    public void GetResult(){} // RVA: 0x7FFAC93424F0
    public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7FFAC9342550
    public void ThrowIncorrectTokenException(){} // RVA: 0x7FFAC93425A0
    public void ThrowMultipleContinuationsException(){} // RVA: 0x7FFAC93425F0
    public void ThrowException(){} // RVA: 0x7FFAC9342640
    public void CreateException(){} // RVA: 0x7FFAC9342670
    public void .cctor(){} // RVA: 0x7FFAC9342780
}

public class Awaiter : ValueType
{
    public Cysharp.Threading.Tasks.UniTask`1<T> IsCompleted;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void get_IsCompleted(){} // RVA: 0x7FFAC2C59D00
    public void GetResult(){} // RVA: 0x7FFAC2E8DC40
    public void OnCompleted(){} // RVA: 0x7FFAC2C70A40
    public void UnsafeOnCompleted(){} // RVA: 0x7FFAC2C70A40
    public void SourceOnCompleted(){} // RVA: 0x7FFAC2C79B30
}

public class AwakeDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class AwakeMonitor : Object
{
    public Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase`1<T> trigger;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void MoveNext(){} // RVA: 0x7FFAC2C59D00
}

public class AxisDirection : ValueType
{
    public UnityEngine.Vector3 direction; // 0x10
    public UnityEngine.Vector3 axis; // 0x1C
    public float dot; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC302D170
}

public class AxisHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC6E0A5C0
    public void Invoke(){} // RVA: 0x7FFAC6193050
    public void BeginInvoke(){} // RVA: 0x7FFAC8C47BC0
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class AxisInputDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC48435C0
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC4034000
}

public class AxisMapping : Object
{
    public 0x6B1BB000 type; // 0x10
    public string axisName; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}
