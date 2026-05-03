// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 80
// Methods: 448

public class Array : ValueType
{
    // ── Methods ──
    public void IsCustom(){} // RVA: 0x7FFE878B7500
    public void CustomResize(){} // RVA: 0x7FFE878B9880
    public void Resize(){} // RVA: 0x7FFE810A1420 | overloaded x2
}

public class Array16`1 : ValueType
{
}

public class Array256`1 : ValueType
{
}

public class Array3 : ValueType
{
}

public class Array32768`1 : ValueType
{
    public Array4096`1<T> f0;

    // ── Methods ──
    public void get_Length(){} // RVA: 0x7FFE80E2EDB0
    public void ElementAt(){} // RVA: 0x7FFE80E3D230
}

public class Array4 : ValueType
{
}

public class Array4096`1 : ValueType
{
}

public class ArrayEnumerator : Object
{
    public System.Array _array; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86A0FC90
    public void MoveNext(){} // RVA: 0x7FFE86A0FD10
    public void Reset(){} // RVA: 0x7FFE82A55FE0
    public void Clone(){} // RVA: 0x7FFE868BC310
    public void get_Current(){} // RVA: 0x7FFE86A0FD30
}

public class ArrayListDebugView : Object
{
}

public class ArrayListEnumeratorSimple : Object
{
    public System.Collections.ArrayList _list; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE869492E0
    public void Clone(){} // RVA: 0x7FFE868BC310
    public void MoveNext(){} // RVA: 0x7FFE869494D0
    public void get_Current(){} // RVA: 0x7FFE869496D0
    public void Reset(){} // RVA: 0x7FFE869497D0
    public void .cctor(){} // RVA: 0x7FFE869498E0
}

public class ArrayPoolImpl`1 : Object
{
    public object syncLock;
    public System.Collections.Generic.Dictionary`2<int,SizeGroup<T>> Pool;

    // ── Methods ──
    public void get_ObjectType(){} // RVA: 0x7FFE80E2E2E0
    public void get_CountInactive(){} // RVA: 0x7FFE80E2EDB0
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Get(){} // RVA: 0x7FFE810A1420
    public void Contains(){} // RVA: 0x7FFE80E2F3B0
    public void Release(){} // RVA: 0x7FFE80E460A0
    public void Cleanup(){} // RVA: 0x7FFE80E2EDB0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class ArrayPropertyDescriptor : SimplePropertyDescriptor
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87791990
    public void GetValue(){} // RVA: 0x7FFE87791A50
    public void SetValue(){} // RVA: 0x7FFE87791B20
}

public class ArraySubsetEnumerator : Object
{
    public System.Array _array; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE877A54C0
    public void MoveNext(){} // RVA: 0x7FFE877A5530
    public void Reset(){} // RVA: 0x7FFE87677490
    public void get_Current(){} // RVA: 0x7FFE877A5550
}

public class ArraySurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFE8A4E2FD0
    public void SetObjectData(){} // RVA: 0x7FFE8A4E39A0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class Article : ApiModel
{
    public System.Collections.Generic.List`1<ArticleContent> _content; // 0x68
    public System.Collections.Generic.List`1<string> _sectionLinks; // 0x70
    public System.Collections.Generic.List`1<VRC.Core.ApiBindingCommandReference> _embeddedLinkData; // 0x78
    public System.Collections.Generic.List`1<VRC.Core.ApiBindingCommandReference> _moreInfoLinks; // 0x80

    // ── Methods ──
    public void get_content(){} // RVA: 0x7FFE81176D50
    public void set_content(){} // RVA: 0x7FFE81176D60
    public void get_sectionLinks(){} // RVA: 0x7FFE811C3590
    public void set_sectionLinks(){} // RVA: 0x7FFE811C35A0
    public void get_embeddedLinkData(){} // RVA: 0x7FFE81463AE0
    public void set_embeddedLinkData(){} // RVA: 0x7FFE81464570
    public void get_moreInfoLinks(){} // RVA: 0x7FFE81280C30
    public void set_moreInfoLinks(){} // RVA: 0x7FFE81282380
    public void .ctor(){} // RVA: 0x7FFE8A2D8460
}

public class ArticleContent : ApiModel
{
    public string _title; // 0x68
    public string _text; // 0x70
    public string _imageUrl; // 0x78
    public string _videoUrl; // 0x80
    public VRC.Core.ApiBindingCommandReference _onPressed; // 0x88

    // ── Methods ──
    public void get_title(){} // RVA: 0x7FFE81176D50
    public void set_title(){} // RVA: 0x7FFE81176D60
    public void get_text(){} // RVA: 0x7FFE811C3590
    public void set_text(){} // RVA: 0x7FFE811C35A0
    public void get_imageUrl(){} // RVA: 0x7FFE81463AE0
    public void set_imageUrl(){} // RVA: 0x7FFE81464570
    public void get_videoUrl(){} // RVA: 0x7FFE81280C30
    public void set_videoUrl(){} // RVA: 0x7FFE81282380
    public void get_onPressed(){} // RVA: 0x7FFE8113A010
    public void set_onPressed(){} // RVA: 0x7FFE81280F90
    public void .ctor(){} // RVA: 0x7FFE8A2D84B0
}

public class AsciiPreescapedData : ValueType
{
    // ── Methods ──
    public void PopulatePreescapedData(){} // RVA: 0x7FFE87376120
    public void TryGetPreescapedData(){} // RVA: 0x7FFE86E2F730
}

public class Asn1SequenceParserImpl : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A12E620
    public void ReadObject(){} // RVA: 0x7FFE8A12E6A0
    public void ToAsn1Object(){} // RVA: 0x7FFE81116380
}

public class Asn1SetParserImpl : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A12FA10
    public void ReadObject(){} // RVA: 0x7FFE8A12FA90
    public void ToAsn1Object(){} // RVA: 0x7FFE81116380
}

public class AspectStretcher : ValueType
{
    public float _aspect; // 0x10

    // ── Methods ──
    public void get_Aspect(){} // RVA: 0x7FFE82AB44F0
    public void .ctor(){} // RVA: 0x7FFE82AB4500
    public void Stretch(){} // RVA: 0x7FFE82AB4520
    public void Unstretch(){} // RVA: 0x7FFE82AB4550
}

public class AssetBundleCreateRequestAwaiter : ValueType
{
    public UnityEngine.AssetBundleCreateRequest asyncOperation; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81E76050
    public void get_IsCompleted(){} // RVA: 0x7FFE87877440
    public void GetResult(){} // RVA: 0x7FFE8787CD90
    public void OnCompleted(){} // RVA: 0x7FFE8787CFA0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFE8787CFB0
}

public class AssetBundleCreateRequestConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AssetBundleCreateRequestConfiguredSource> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE8787D0E0
    public void .ctor(){} // RVA: 0x7FFE8787D260
    public void Create(){} // RVA: 0x7FFE8787D320
    public void GetResult(){} // RVA: 0x7FFE8787D890
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE8787DB10
    public void GetStatus(){} // RVA: 0x7FFE8787DB20
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8787DB70
    public void OnCompleted(){} // RVA: 0x7FFE8787DBB0
    public void MoveNext(){} // RVA: 0x7FFE8787DC30
    public void TryReturn(){} // RVA: 0x7FFE8787DD70
    public void Continuation(){} // RVA: 0x7FFE8787DEE0
}

public class AssetBundleRequestAllAssetsAwaiter : ValueType
{
    public UnityEngine.AssetBundleRequest asyncOperation; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81E76050
    public void GetAwaiter(){} // RVA: 0x7FFE8151C410
    public void get_IsCompleted(){} // RVA: 0x7FFE87877440
    public void GetResult(){} // RVA: 0x7FFE878774A0
    public void OnCompleted(){} // RVA: 0x7FFE878776B0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFE878776C0
}

public class AssetBundleRequestAllAssetsConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AssetBundleRequestAllAssetsConfiguredSource> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE878777F0
    public void .ctor(){} // RVA: 0x7FFE87877970
    public void Create(){} // RVA: 0x7FFE87877A30
    public void GetResult(){} // RVA: 0x7FFE87877FA0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE87878200
    public void GetStatus(){} // RVA: 0x7FFE87878210
    public void UnsafeGetStatus(){} // RVA: 0x7FFE87878260
    public void OnCompleted(){} // RVA: 0x7FFE878782A0
    public void MoveNext(){} // RVA: 0x7FFE87878320
    public void TryReturn(){} // RVA: 0x7FFE87878460
    public void Continuation(){} // RVA: 0x7FFE878785C0
}

public class AssetBundleRequestAwaiter : ValueType
{
    public UnityEngine.AssetBundleRequest asyncOperation; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81E76050
    public void get_IsCompleted(){} // RVA: 0x7FFE87877440
    public void GetResult(){} // RVA: 0x7FFE8787A880
    public void OnCompleted(){} // RVA: 0x7FFE8787BBD0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFE8787BBE0
}

public class AssetBundleRequestConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AssetBundleRequestConfiguredSource> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE8787BD10
    public void .ctor(){} // RVA: 0x7FFE8787BE90
    public void Create(){} // RVA: 0x7FFE8787BF50
    public void GetResult(){} // RVA: 0x7FFE8787C4C0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE8787C740
    public void GetStatus(){} // RVA: 0x7FFE8787C750
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8787C7A0
    public void OnCompleted(){} // RVA: 0x7FFE8787C7E0
    public void MoveNext(){} // RVA: 0x7FFE8787C860
    public void TryReturn(){} // RVA: 0x7FFE8787C9B0
    public void Continuation(){} // RVA: 0x7FFE8787CB20
}

public class AssetEntry : ValueType
{
    public string path; // 0x10

    // ── Methods ──
    public void get_type(){} // RVA: 0x7FFE87E63C40
    public void .ctor(){} // RVA: 0x7FFE87E63D20
}

public class AssetPreloader : Object
{
    public ÍÎÍÎÌÍÌÏÌÎÎÍÏÌÍÍÎÏÏÎÏÌÍ _m_CachedPtr; // 0x10
    public System.Collections.Generic.List`1<string> _offsetOfInstanceIDInCPlusPlusObject; // 0x18
    public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiWorld> f_F72; // 0x20

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFE81EEADE0
    public void Equals(){} // RVA: 0x7FFE81EEAF20
    public void GetHashCode(){} // RVA: 0x7FFE81EEB050
    public void op_Implicit(){} // RVA: 0x7FFE81EEB5A0
    public void CompareBaseObjects(){} // RVA: 0x7FFE81178740
    public void IsNativeObjectAlive(){} // RVA: 0x7FFE81EEB6A0
    public void GetCachedPtr(){} // RVA: 0x7FFE81EEB6C0
    public void get_name(){} // RVA: 0x7FFE81EEB8B0
    public void set_name(){} // RVA: 0x7FFE81EEB970
    public void Instantiate(){} // RVA: 0x7FFE81EEBB50
    public void ToString(){} // RVA: 0x7FFE81EEBCF0
    public void InitializePreloadData(){} // RVA: 0x7FFE815F1380
    public void BuildPreloadManifest(){} // RVA: 0x7FFE811EDAF0
    public void IsSetup(){} // RVA: 0x7FFE81EEBF20
    public void HandlePreloaderDataInitialization(){} // RVA: 0x7FFE81EEC0F0
    public void .ctor(){} // RVA: 0x7FFE81EEC5B0
    public void GetPreloadedAssetData(){} // RVA: 0x7FFE81EECE90
    public void ConfigureAssetPreloader(){} // RVA: 0x7FFE81EECF90
    public void Initialize(){} // RVA: 0x7FFE81EED0C0
    public void Destroy(){} // RVA: 0x7FFE81EED130
    public void DestroyImmediate(){} // RVA: 0x7FFE8144E200
    public void FindObjectsOfType(){} // RVA: 0x7FFE81C15740
    public void Finalize(){} // RVA: 0x7FFE81EED4F0
    public void FindObjectsByType(){} // RVA: 0x7FFE81EED710
    public void .ctor_8D46CF0021A5(){} // RVA: 0x7FFE81EED970
    public void DontDestroyOnLoad(){} // RVA: 0x7FFE81EEDAA0
    public void get_hideFlags(){} // RVA: 0x7FFE81EEDC30
    public void set_hideFlags(){} // RVA: 0x7FFE81EEDE30
    public void Dispose(){} // RVA: 0x7FFE81EEE2F0
    public void Cleanup(){} // RVA: 0x7FFE81EEE3C0
    public void FindFirstObjectByType(){} // RVA: 0x7FFE81EEE830
    // ── Unresolved (hash) ──
    public void m_7FD(){} // RVA: 0x7FFE81EEBE20
    public void m_2E2(){} // RVA: 0x7FFE81EED2F0
}

public class AssociatedDetection : Object
{
    public Google.Protobuf.MessageParser`1<AssociatedDetection> _parser;
    public Google.Protobuf.UnknownFieldSet _unknownFields; // 0x10
    public int _hasBits0; // 0x18
    public int IdFieldNumber;
    public int IdDefaultValue; // 0x8
    public int id_; // 0x1C
    public int ConfidenceFieldNumber;

    // ── Methods ──
    public void get_Parser(){} // RVA: 0x7FFE8664D810
    public void get_Descriptor(){} // RVA: 0x7FFE8664D870
    public void pb::Google.Protobuf.IMessage.get_Descriptor(){} // RVA: 0x7FFE8664D8F0
    public void .ctor(){} // RVA: 0x7FFE8664D9A0 | overloaded x2
    public void Clone(){} // RVA: 0x7FFE8664DA90
    public void get_Id(){} // RVA: 0x7FFE8664DBB0
    public void set_Id(){} // RVA: 0x7FFE8659D0A0
    public void get_HasId(){} // RVA: 0x7FFE8659D0B0
    public void ClearId(){} // RVA: 0x7FFE8659D0C0
    public void get_Confidence(){} // RVA: 0x7FFE8664DC20
    public void set_Confidence(){} // RVA: 0x7FFE866479A0
    public void get_HasConfidence(){} // RVA: 0x7FFE8659D150
    public void ClearConfidence(){} // RVA: 0x7FFE8659D160
    public void Equals(){} // RVA: 0x7FFE8664DDE0 | overloaded x2
    public void GetHashCode(){} // RVA: 0x7FFE8664DF00
    public void ToString(){} // RVA: 0x7FFE8664DFE0
    public void WriteTo(){} // RVA: 0x7FFE8657A4A0
    public void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(){} // RVA: 0x7FFE8664E030
    public void CalculateSize(){} // RVA: 0x7FFE8664E0C0
    public void MergeFrom(){} // RVA: 0x7FFE8657A7E0 | overloaded x2
    public void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(){} // RVA: 0x7FFE8664E270
    public void .cctor(){} // RVA: 0x7FFE8664E310
}

public class AsyncGPUReadbackRequestAwaiterConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AsyncGPUReadbackRequestAwaiterConfiguredSource> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE87878870
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Create(){} // RVA: 0x7FFE878789F0
    public void GetResult(){} // RVA: 0x7FFE87878E60
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE87879030
    public void GetStatus(){} // RVA: 0x7FFE87879050
    public void UnsafeGetStatus(){} // RVA: 0x7FFE878790A0
    public void OnCompleted(){} // RVA: 0x7FFE878790E0
    public void MoveNext(){} // RVA: 0x7FFE87879160
    public void TryReturn(){} // RVA: 0x7FFE87879330
}

public class AsyncInstantiateOperationConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AsyncInstantiateOperationConfiguredSource> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE8787FF50
    public void .ctor(){} // RVA: 0x7FFE878800D0
    public void Create(){} // RVA: 0x7FFE87880190
    public void GetResult(){} // RVA: 0x7FFE87880700
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE87880980
    public void GetStatus(){} // RVA: 0x7FFE87880990
    public void UnsafeGetStatus(){} // RVA: 0x7FFE878809E0
    public void OnCompleted(){} // RVA: 0x7FFE87880A20
    public void MoveNext(){} // RVA: 0x7FFE87880AA0
    public void TryReturn(){} // RVA: 0x7FFE87880BE0
    public void Continuation(){} // RVA: 0x7FFE87880D50
}

public class AsyncInstantiateOperationConfiguredSource`1 : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AsyncInstantiateOperationConfiguredSource`1<T>> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE80E2E2E0
    public void .cctor(){} // RVA: 0x7FFE80E46010
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
    public void Create(){} // RVA: 0x7FFE810A1420
    public void GetResult(){} // RVA: 0x7FFE80E3E250
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
    public void TryReturn(){} // RVA: 0x7FFE80E2F150
    public void Continuation(){} // RVA: 0x7FFE80E460A0
}

public class AsyncManualResetEvent : Object
{
    // ── Methods ──
    public void WaitAsync(){} // RVA: 0x7FFE876B50C0
    public void Set(){} // RVA: 0x7FFE876B5120
    public void Reset(){} // RVA: 0x7FFE876B5450
    public void .ctor(){} // RVA: 0x7FFE876B5680
}

public class AsyncOperationAwaiter : ValueType
{
    public UnityEngine.AsyncOperation asyncOperation; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81E76050
    public void get_IsCompleted(){} // RVA: 0x7FFE87877440
    public void GetResult(){} // RVA: 0x7FFE87879570
    public void OnCompleted(){} // RVA: 0x7FFE878796C0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFE878796D0
}

public class AsyncOperationConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<AsyncOperationConfiguredSource> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE87879800
    public void .ctor(){} // RVA: 0x7FFE87879980
    public void Create(){} // RVA: 0x7FFE87879A40
    public void GetResult(){} // RVA: 0x7FFE87879FA0
    public void GetStatus(){} // RVA: 0x7FFE8787A210
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8787A260
    public void OnCompleted(){} // RVA: 0x7FFE8787A2A0
    public void MoveNext(){} // RVA: 0x7FFE8787A320
    public void TryReturn(){} // RVA: 0x7FFE8787A480
    public void Continuation(){} // RVA: 0x7FFE8787A5F0
}

public class AsyncTriggerEnumerator : MoveNextSource
{
    public System.Action`1<object> cancellationCallback;
    public Cysharp.Threading.Tasks.Triggers.AsyncTriggerBase`1<T> parent;
    public System.Threading.CancellationToken cancellationToken;

    // ── Methods ──
    public void .ctor(){}
    public void OnCanceled(){} // RVA: 0x7FFE80E46250
    public void OnNext(){} // RVA: 0x7FFE810A1420
    public void OnCompleted(){} // RVA: 0x7FFE80E45FE0
    public void OnError(){} // RVA: 0x7FFE80E460A0
    public void CancellationCallback(){} // RVA: 0x7FFE80E46070
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void set_Current(){} // RVA: 0x7FFE810A1420
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev(){} // RVA: 0x7FFE80E2E2E0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(){} // RVA: 0x7FFE80E460A0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next(){} // RVA: 0x7FFE80E2E2E0
    public void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(){} // RVA: 0x7FFE80E460A0
    public void MoveNextAsync(){}
    public void DisposeAsync(){} // RVA: 0x7FFE80E2DCF0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class AsyncUnitSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void GetResult(){} // RVA: 0x7FFE87833D30
    public void GetStatus(){} // RVA: 0x7FFE87833DD0
    public void OnCompleted(){} // RVA: 0x7FFE87833E30
    public void UnsafeGetStatus(){} // RVA: 0x7FFE87833EC0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE87833F10
}

public class AsyncUploadTimeSlicedUpdate : ValueType
{
}

public class AsyncWriter : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void Dispose(){} // RVA: 0x7FFE80E45FE0
    public void GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void OnCompleted(){}
    public void YieldAsync(){} // RVA: 0x7FFE810A1420
    public void SignalWriter(){} // RVA: 0x7FFE80E45FE0
}

public class AttachExternalCancellationSource : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8784A060
    public void RunTask(){} // RVA: 0x7FFE8784A340
    public void CancellationCallback(){} // RVA: 0x7FFE8784A4D0
    public void GetResult(){} // RVA: 0x7FFE8784A550
    public void GetStatus(){} // RVA: 0x7FFE8784A5A0
    public void OnCompleted(){} // RVA: 0x7FFE8784A5F0
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8784A670
    public void .cctor(){} // RVA: 0x7FFE8784A6B0
}

public class AttachExternalCancellationSource`1 : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void RunTask(){} // RVA: 0x7FFE810A1420
    public void CancellationCallback(){} // RVA: 0x7FFE80E46070
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE80E461D0
    public void GetResult(){} // RVA: 0x7FFE810A1420
    public void GetStatus(){}
    public void OnCompleted(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFE80E2EDB0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class AttachedObject : ValueType
{
    // ── Methods ──
    public void HasAttachFlag(){} // RVA: 0x7FFE8705FB40
}

public class Attachment : ApiModel
{
    public string _partId; // 0x68
    public bool _isEnabled; // 0x70
    public string _path; // 0x78
    public System.Collections.Generic.List`1<float> _position; // 0x80
    public System.Collections.Generic.List`1<float> _rotation; // 0x88
    public System.Collections.Generic.List`1<float> _scale; // 0x90
    public System.Collections.Generic.List`1<Variable> _variables; // 0x98

    // ── Methods ──
    public void get_partId(){} // RVA: 0x7FFE81176D50
    public void set_partId(){} // RVA: 0x7FFE81176D60
    public void get_isEnabled(){} // RVA: 0x7FFE81177320
    public void set_isEnabled(){} // RVA: 0x7FFE81177330
    public void get_path(){} // RVA: 0x7FFE81463AE0
    public void set_path(){} // RVA: 0x7FFE81464570
    public void get_position(){} // RVA: 0x7FFE81280C30
    public void set_position(){} // RVA: 0x7FFE81282380
    public void get_rotation(){} // RVA: 0x7FFE8113A010
    public void set_rotation(){} // RVA: 0x7FFE81280F90
    public void get_scale(){} // RVA: 0x7FFE8154EB60
    public void set_scale(){} // RVA: 0x7FFE818CE320
    public void get_variables(){} // RVA: 0x7FFE817AE360
    public void set_variables(){} // RVA: 0x7FFE8171B470
    public void .ctor(){} // RVA: 0x7FFE8A2C0F30
}

public class AttrInfo : ValueType
{
    // ── Methods ──
    public void Set(){} // RVA: 0x7FFE8743C490 | overloaded x2
    public void GetLocalnameAndNamespaceUri(){} // RVA: 0x7FFE8743C560
    public void GetLocalnameAndNamespaceUriAndHash(){} // RVA: 0x7FFE8743C610
    public void MatchNS(){} // RVA: 0x7FFE8743BC10
    public void MatchHashNS(){} // RVA: 0x7FFE8743C710
    public void AdjustPosition(){} // RVA: 0x7FFE8743C7C0
}

public class AttrListImpl : Object
{
    public System.Collections.Generic.List`1<string> attrNames; // 0x10
    public System.Collections.Generic.List`1<string> attrValues; // 0x18
    public object field_2; // 0x13

    // ── Methods ──
    public void get_Length(){} // RVA: 0x7FFE8673A720
    public void GetName(){} // RVA: 0x7FFE8673A770
    public void GetValue(){} // RVA: 0x7FFE8673A870 | overloaded x2
    public void get_Names(){} // RVA: 0x7FFE8673A990
    public void get_Values(){} // RVA: 0x7FFE8673A9E0
    public void Clear(){} // RVA: 0x7FFE8673AA30
    public void Add(){} // RVA: 0x7FFE8673AAC0
    public void .ctor(){} // RVA: 0x7FFE8673ABD0
}

public class AttrName : ValueType
{
    // ── Methods ──
    public void Set(){} // RVA: 0x7FFE8757F040
    public void IsDuplicate(){} // RVA: 0x7FFE8757F160
}

public class AttributeContent : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class AttributeEntry : ValueType
{
}

public class AttributeFilterCacheItem : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81CA56D0
    public void IsValid(){} // RVA: 0x7FFE877EB900
}

public class AttributeInfo : Object
{
    public System.AttributeUsageAttribute _usage; // 0x10
    public int _inheritanceLevel; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AF3A20
    public void get_Usage(){} // RVA: 0x7FFE81116380
    public void get_InheritanceLevel(){} // RVA: 0x7FFE813DB630
}

public class AttributeOverride : ValueType
{
}

public class AttributeProvider : TypeDescriptionProvider
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86F99960
    public void GetTypeDescriptor(){} // RVA: 0x7FFE877EAB40
}

public class AttributeTypeAndValue : Object
{
    public string oid; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86711BB0 | overloaded x2
    public void set_Value(){} // RVA: 0x7FFE86711C20
    public void GetASN1(){} // RVA: 0x7FFE867120E0 | overloaded x2
    public void SelectBestEncoding(){} // RVA: 0x7FFE867120F0
}

public class AttributeTypeDescriptor : CustomTypeDescriptor
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82A057B0
    public void GetAttributes(){} // RVA: 0x7FFE877EAD20
}

public class AttributeValueCache : Object
{
    public System.Text.StringBuilder stringValue; // 0x10

    // ── Methods ──
    public void get_StringValue(){} // RVA: 0x7FFE8757F250
    public void WriteEntityRef(){} // RVA: 0x7FFE8757F290
    public void WriteCharEntity(){} // RVA: 0x7FFE8757F510
    public void WriteSurrogateCharEntity(){} // RVA: 0x7FFE8757F5A0
    public void WriteWhitespace(){} // RVA: 0x7FFE8757F670
    public void WriteString(){} // RVA: 0x7FFE8757F6D0
    public void WriteChars(){} // RVA: 0x7FFE8757F780
    public void WriteRaw(){} // RVA: 0x7FFE8757F9A0 | overloaded x2
    public void WriteValue(){} // RVA: 0x7FFE8757FA00
    public void Replay(){} // RVA: 0x7FFE8757FA60
    public void Trim(){} // RVA: 0x7FFE8757FEB0
    public void Clear(){} // RVA: 0x7FFE87580470
    public void StartComplexValue(){} // RVA: 0x7FFE875804F0
    public void AddItem(){} // RVA: 0x7FFE87580580
    public void .ctor(){} // RVA: 0x7FFE87580980
}

public class AudioConfigurationChangeHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE823781B0
    public void Invoke(){} // RVA: 0x7FFE81156C60
}

public class AudioFixedUpdate : ValueType
{
}

public class AudioTrack : ValueType
{
}

public class AuthData : ValueType
{
}

public class AuthEnvelopedSecureReadable : Object
{
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Cms.CmsAuthEnvelopedData parent; // 0x10
    public object field_1; // 0x624

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void get_Algorithm(){} // RVA: 0x7FFE8189B9F0
    public void get_CryptoObject(){} // RVA: 0x7FFE813240E0
    public void GetReadable(){} // RVA: 0x7FFE8A0F4DD0
}

public class AuthorizationArgs : ValueType
{
    // ── Methods ──
    public void Init(){} // RVA: 0x7FFE82BE1EC0
    public void Drop(){} // RVA: 0x7FFE82BE1F40
    public void SetClientId(){} // RVA: 0x7FFE82BE1FC0
    public void SetScopes(){} // RVA: 0x7FFE82BE2050
}

public class AuthorizationCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BE97A0
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class AuthorizationState : ValueType
{
    public System.Net.HttpWebRequest request; // 0x10
    public bool isProxy; // 0x18
    public bool isCompleted; // 0x19

    // ── Methods ──
    public void get_IsCompleted(){} // RVA: 0x7FFE828B3170
    public void get_NtlmAuthState(){} // RVA: 0x7FFE82C33020
    public void get_IsNtlmAuthenticated(){} // RVA: 0x7FFE876A3380
    public void .ctor(){} // RVA: 0x7FFE876A33A0
    public void CheckAuthorization(){} // RVA: 0x7FFE876A3410
    public void Reset(){} // RVA: 0x7FFE876A3820
    public void ToString(){} // RVA: 0x7FFE876A38F0
}

public class AutoDetectParams : ValueType
{
    public bool legsParentInSpine; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8114F2A0
    public void get_Default(){} // RVA: 0x7FFE8114F2B0
}

public class AutoDolly : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82A9B9A0
}

public class AutoScope : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87BF7870
    public void Dispose(){} // RVA: 0x7FFE812C4BA0
}

public class AvailableDevice : ValueType
{
}

public class AvatarCullingMonitor : Object
{
    public float _avatarScreenSizeThresholdLower; // 0x10
    public float _avatarScreenSizeThresholdUpper; // 0x14
    public dFixup.Relative[] _validAvatarKinds; // 0x18

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFE81E40C60
    public void set_AvatarScreenSizeAboveTriggerThreshold(){} // RVA: 0x7FFE81E40D60
    public void Equals(){} // RVA: 0x7FFE81E40E40
    public void op_Implicit(){} // RVA: 0x7FFE81E40F40
    public void get_AvatarScreenSizeAboveTriggerThreshold(){} // RVA: 0x7FFE81E41060
    public void .ctor(){} // RVA: 0x7FFE81E41070
    public void Initialize(){} // RVA: 0x7FFE81E41080
    public void get_AvatarKindValidForExecution(){} // RVA: 0x7FFE81E410B0
    public void set_AvatarKindValidForExecution(){} // RVA: 0x7FFE81E41080
    public void get_AvatarCullableShouldRun(){} // RVA: 0x7FFE81E41120
    public void set_AvatarCullableShouldRun(){} // RVA: 0x7FFE81E41190
    public void Dispose(){} // RVA: 0x7FFE81E41420
    public void Cleanup(){} // RVA: 0x7FFE81E414A0
    public void Instantiate(){} // RVA: 0x7FFE81E41620
    public void GetHashCode(){} // RVA: 0x7FFE81E417A0
    public void ToString(){} // RVA: 0x7FFE81E418A0
    public void set_AvatarCullingDistance(){} // RVA: 0x7FFE81E41A80
    public void UpdateCullingState(){} // RVA: 0x7FFE81E41B80
    public void EvaluateAvatarVisibility(){} // RVA: 0x7FFE81E41C90
}

public class AvatarOscConfig : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81E843B0 | overloaded x2
    public void GetByName(){} // RVA: 0x7FFE81E84290
}

public class Avoider : Object
{
    // ── Methods ──
    public void Solve(){} // RVA: 0x7FFE81270210
    public void GetOffsetTarget(){} // RVA: 0x7FFE81270460
    public void Raycast(){} // RVA: 0x7FFE812706B0
    public void .ctor(){} // RVA: 0x7FFE81270B50
}

public class Avx : Object
{
    // ── Methods ──
    public void mm256_load_ps(){} // RVA: 0x7FFE82E25FF0
    public void mm256_store_ps(){} // RVA: 0x7FFE878B5800
    public void mm256_loadu_si256(){} // RVA: 0x7FFE82E25FF0
    public void mm256_storeu_si256(){} // RVA: 0x7FFE878B5800
    public void mm256_set1_epi32(){} // RVA: 0x7FFE878B5810
}

public class Avx2 : Object
{
    // ── Methods ──
    public void get_IsAvx2Supported(){} // RVA: 0x7FFE810FB320
    public void mm256_xor_si256(){} // RVA: 0x7FFE878B5830
    public void mm256_add_epi64(){} // RVA: 0x7FFE878B5890
    public void mm256_mul_epu32(){} // RVA: 0x7FFE878B5900
    public void mm256_slli_epi64(){} // RVA: 0x7FFE878B5970
    public void mm256_srli_epi64(){} // RVA: 0x7FFE878B5AA0
    public void mm256_shuffle_epi32(){} // RVA: 0x7FFE878B5C00
}

public class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs
{
    public AwaitableSocketAsyncEventArgs Reserved;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE876E9B10
    public void get_WrapExceptionsInIOExceptions(){} // RVA: 0x7FFE876E9BD0
    public void set_WrapExceptionsInIOExceptions(){} // RVA: 0x7FFE876E9BE0
    public void Reserve(){} // RVA: 0x7FFE876E9BF0
    public void Release(){} // RVA: 0x7FFE876E9CC0
    public void OnCompleted(){} // RVA: 0x7FFE876EA5C0 | overloaded x2
    public void ReceiveAsync(){} // RVA: 0x7FFE876EA140
    public void SendAsyncForNetworkStream(){} // RVA: 0x7FFE876EA360
    public void GetStatus(){} // RVA: 0x7FFE876EA520
    public void InvokeContinuation(){} // RVA: 0x7FFE876EA910
    public void GetResult(){} // RVA: 0x7FFE876EAC20
    public void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(){} // RVA: 0x7FFE876EAC80
    public void ThrowIncorrectTokenException(){} // RVA: 0x7FFE876EACD0
    public void ThrowMultipleContinuationsException(){} // RVA: 0x7FFE876EAD20
    public void ThrowException(){} // RVA: 0x7FFE876EAD70
    public void CreateException(){} // RVA: 0x7FFE876EADA0
    public void .cctor(){} // RVA: 0x7FFE876EAEB0
}

public class Awaiter : ValueType
{
    public Cysharp.Threading.Tasks.UniTask`1<UnityEngine.AudioClip> task; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86027470
    public void get_IsCompleted(){} // RVA: 0x7FFE860605D0
    public void GetResult(){} // RVA: 0x7FFE81327810
    public void OnCompleted(){} // RVA: 0x7FFE86060610
    public void UnsafeOnCompleted(){} // RVA: 0x7FFE86060710
    public void SourceOnCompleted(){} // RVA: 0x7FFE86027710
}

public class AwakeDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class AwakeMonitor : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void MoveNext(){} // RVA: 0x7FFE80E2F150
}

public class AxisDirection : ValueType
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81207170
}

public class AxisHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE85196800
    public void Invoke(){} // RVA: 0x7FFE84424470
    public void BeginInvoke(){} // RVA: 0x7FFE86FF00E0
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class AxisInputDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82AAB960
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE82268F40
}

public class AxisMapping : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
}
