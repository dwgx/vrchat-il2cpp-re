// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 239

public class UBI : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A0D94E0
    public void Reset(){} // RVA: 0x7FFE8A0D99E0 | overloaded x2
    public void Update(){} // RVA: 0x7FFE8A0D9AA0
    public void ProcessBlock(){} // RVA: 0x7FFE8A0D9C00
    public void DoFinal(){} // RVA: 0x7FFE8A0D9D80
}

public class UIActions : ValueType
{
    public UnityEngine.InputSystem.DefaultInputActions m_Wrapper; // 0x10
    public object field_1; // 0x2E4
    public object field_2; // 0x2E5
    public object field_3; // 0x2E6
    public object field_4; // 0x2E7
    public object field_5; // 0x2E8
    public object field_6; // 0x2E9
    public object field_7; // 0x2EA
    public object field_8; // 0x2EB
    public object field_9; // 0x2EC
    public object field_10; // 0x2ED

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    public void get_Navigate(){} // RVA: 0x7FFE81D7E820
    public void get_Submit(){} // RVA: 0x7FFE81D7EA80
    public void get_Cancel(){} // RVA: 0x7FFE81D7E940
    public void get_Point(){} // RVA: 0x7FFE81D7E730
    public void get_Click(){} // RVA: 0x7FFE81D7E960
    public void get_ScrollWheel(){} // RVA: 0x7FFE81D7E860
    public void get_MiddleClick(){} // RVA: 0x7FFE81D7E8A0
    public void get_RightClick(){} // RVA: 0x7FFE81D81C20
    public void get_TrackedDevicePosition(){} // RVA: 0x7FFE81D7E500
    public void get_TrackedDeviceOrientation(){} // RVA: 0x7FFE81D7E710
    public void Get(){} // RVA: 0x7FFE81D7E4E0
    public void Enable(){} // RVA: 0x7FFE879CB460
    public void Disable(){} // RVA: 0x7FFE879CB4E0
    public void get_enabled(){} // RVA: 0x7FFE879CB520
    public void op_Implicit(){} // RVA: 0x7FFE82B1A110
    public void SetCallbacks(){} // RVA: 0x7FFE879CB550
}

public class UIElementsUpdatePanels : ValueType
{
}

public class UISearchStateMapping : ValueType
{
}

public class UISoundCollection : ScriptableObject
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81345B60
}

public class UISupport : Object
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFE878BE530
}

public class UIToolkitOverrideConfig : ValueType
{
}

public class UNICODE_STRING : ValueType
{
}

public class UQueryMatcher : HierarchyTraversal
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FB310
    public void Traverse(){} // RVA: 0x7FFE87EAEDE0
    public void OnRuleMatchedElement(){} // RVA: 0x7FFE834BA0A0
    public void NoProcessResult(){} // RVA: 0x7FFE810FB310
    public void TraverseRecursive(){} // RVA: 0x7FFE87FCC9A0
    public void Run(){} // RVA: 0x7FFE87FCCC40
}

public class URPMaterialSwitcher : MonoBehaviour
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FBD50
}

public class UTF32Decoder : DecoderNLS
{
    public int iChar; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8678E0E0
    public void Reset(){} // RVA: 0x7FFE8678E0F0
    public void get_HasState(){} // RVA: 0x7FFE81B44920
}

public class UTF8Decoder : DecoderNLS
{
    public int bits; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8678E0E0
    public void Reset(){} // RVA: 0x7FFE86794920
    public void get_HasState(){} // RVA: 0x7FFE86794950
}

public class UTF8Encoder : EncoderNLS
{
    public int surrogateChar; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86790600
    public void Reset(){} // RVA: 0x7FFE867948E0
    public void get_HasState(){} // RVA: 0x7FFE86794910
}

public class UTF8EncodingSealed : UTF8Encoding
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86794760
    public void get_Preamble(){} // RVA: 0x7FFE867947E0
}

public class UbiTweak : Object
{
    public ulong LOW_RANGE;
    public ulong T1_FINAL;
    public ulong T1_FIRST;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8A0D8CB0
    public void Reset(){} // RVA: 0x7FFE8A0D8E70 | overloaded x2
    public void get_Type(){} // RVA: 0x7FFE8A0D8ED0
    public void set_Type(){} // RVA: 0x7FFE8A0D8F00
    public void get_First(){} // RVA: 0x7FFE8A0D8F50
    public void set_First(){} // RVA: 0x7FFE8A0D8F90
    public void get_Final(){} // RVA: 0x7FFE8A0D8FF0
    public void set_Final(){} // RVA: 0x7FFE8A0D9030
    public void AdvancePosition(){} // RVA: 0x7FFE8A0D9090
    public void GetWords(){} // RVA: 0x7FFE81116380
    public void ToString(){} // RVA: 0x7FFE8A0D9250
}

public class UdonProgramScanner : Object
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFE821F09B0
    public void Equals(){} // RVA: 0x7FFE821F0B80
}

public class UdonTimeSource : Object
{
    public double _currentTime; // 0x10
    public long _currentFrame; // 0x18
    public object field_2; // 0x22

    // ── Methods ──
    public void get_CurrentTime(){} // RVA: 0x7FFE83BB0D80
    public void set_CurrentTime(){} // RVA: 0x7FFE84D215B0
    public void get_CurrentFrame(){} // RVA: 0x7FFE810FE7C0
    public void set_CurrentFrame(){} // RVA: 0x7FFE819EA910
    public void get_MinimumDelay(){} // RVA: 0x7FFE88252060
    public void UpdateTime(){} // RVA: 0x7FFE88252070
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class UiInputField : MonoBehaviour
{
    public VRC.Localization.LocalizableString _titleText; // 0x20

    // ── Methods ──
    public void get_destroyCancellationToken(){} // RVA: 0x7FFE825DAB00
    public void RaiseCancellation(){} // RVA: 0x7FFE819CF830
    public void OnEnable(){} // RVA: 0x7FFE825DAC00
    public void OnDisable(){} // RVA: 0x7FFE825DAC00
    public void Invoke(){} // RVA: 0x7FFE825DAC30
    public void InvokeRepeating(){} // RVA: 0x7FFE811660B0
    public void CancelInvoke(){} // RVA: 0x7FFE825DAE80
    public void IsInvoking(){} // RVA: 0x7FFE825DB5F0
    public void Awake(){} // RVA: 0x7FFE825DB9B0
    public void OnDestroy(){} // RVA: 0x7FFE825DC3C0
    public void PressEdit(){} // RVA: 0x7FFE825DC6F0
    public void StartCoroutine_Auto(){} // RVA: 0x7FFE825DCE40
    public void StopCoroutine(){} // RVA: 0x7FFE825DD0D0
    public void OnCollisionEnter(){} // RVA: 0x7FFE825DD0E0
    public void OnCollisionStay(){} // RVA: 0x7FFE825DD1E0
    public void StopAllCoroutines(){} // RVA: 0x7FFE825DDBF0
    public void .ctor(){} // RVA: 0x7FFE825DDE80
    public void Initialize(){} // RVA: 0x7FFE8253AF90
    public void print(){} // RVA: 0x7FFE825DE010
    public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE819CF830
    public void Internal_IsInvokingAll(){} // RVA: 0x7FFE825DE260
}

public class Uint16ToBytes : ValueType
{
}

public class Uint32ToBytes : ValueType
{
}

public class Uint64ToBytes : ValueType
{
}

public class UnaryExpressionProxy : Object
{
    public System.Linq.Expressions.UnaryExpression _node; // 0x10
    public object field_1; // 0x133
    public object field_2; // 0x134
    public object field_3; // 0x135
    public object field_4; // 0x136
    public object field_5; // 0x137
    public object field_6; // 0x138
    public object field_7; // 0x139

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8711AC10
    public void get_CanReduce(){} // RVA: 0x7FFE81588760
    public void get_DebugView(){} // RVA: 0x7FFE87119570
    public void get_IsLifted(){} // RVA: 0x7FFE8711ACF0
    public void get_IsLiftedToNull(){} // RVA: 0x7FFE8711AD10
    public void get_Method(){} // RVA: 0x7FFE8189B9F0
    public void get_NodeType(){} // RVA: 0x7FFE81588A80
    public void get_Operand(){} // RVA: 0x7FFE8189B810
    public void get_Type(){} // RVA: 0x7FFE815888E0
}

public class UnboundAnchor : ValueType
{
    public OVRSpace _space; // 0x10
    public System.Guid _uuid; // 0x18
    public object field_2; // 0x8CD
    public object field_3; // 0x8CE

    // ── Methods ──
    public void get_Uuid(){} // RVA: 0x7FFE82CF9F60
    public void get_Localized(){} // RVA: 0x7FFE86CD52E0
    public void get_Localizing(){} // RVA: 0x7FFE86CD5360
    public void get_Pose(){} // RVA: 0x7FFE86CD53F0
    public void Localize(){} // RVA: 0x7FFE86CD5520
    public void BindTo(){} // RVA: 0x7FFE86CD58E0
    public void .ctor(){} // RVA: 0x7FFE8445D180
}

public class UnboundedChannelReader : ChannelReader`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void TryRead(){} // RVA: 0x7FFE80E2F3B0
    public void WaitToReadAsync(){}
}

public class UnboundedChannelWriter : ChannelWriter`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE80E460A0
    public void TryComplete(){} // RVA: 0x7FFE80E2F3B0
    public void TryWrite(){} // RVA: 0x7FFE810A1420
    public void WaitToWriteAsync(){}
    public void WriteAsync(){} // RVA: 0x7FFE810A1420
}

public class Unchecked : NumericConvertInstruction
{
    // ── Methods ──
    public void get_InstructionName(){} // RVA: 0x7FFE8718E7B0
    public void .ctor(){} // RVA: 0x7FFE8718E460
    public void Convert(){} // RVA: 0x7FFE8718E7F0
    public void ConvertInt32(){} // RVA: 0x7FFE8718EC20
    public void ConvertInt64(){} // RVA: 0x7FFE8718EF00
    public void ConvertUInt64(){} // RVA: 0x7FFE8718F1B0
    public void ConvertDouble(){} // RVA: 0x7FFE8718F480
}

public class UndeclaredNotation : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE875BB5A0
}

public class UniTaskLoopRunnerEarlyUpdate : ValueType
{
}

public class UniTaskLoopRunnerFixedUpdate : ValueType
{
}

public class UniTaskLoopRunnerInitialization : ValueType
{
}

public class UniTaskLoopRunnerLastEarlyUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastFixedUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastInitialization : ValueType
{
}

public class UniTaskLoopRunnerLastPostLateUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastPreLateUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastPreUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastTimeUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastYieldEarlyUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastYieldFixedUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastYieldInitialization : ValueType
{
}

public class UniTaskLoopRunnerLastYieldPostLateUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastYieldPreLateUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastYieldPreUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastYieldTimeUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastYieldUpdate : ValueType
{
}

public class UniTaskLoopRunnerPostLateUpdate : ValueType
{
}

public class UniTaskLoopRunnerPreLateUpdate : ValueType
{
}

public class UniTaskLoopRunnerPreUpdate : ValueType
{
}

public class UniTaskLoopRunnerTimeUpdate : ValueType
{
}

public class UniTaskLoopRunnerUpdate : ValueType
{
}

public class UniTaskLoopRunnerYieldEarlyUpdate : ValueType
{
}

public class UniTaskLoopRunnerYieldFixedUpdate : ValueType
{
}

public class UniTaskLoopRunnerYieldInitialization : ValueType
{
}

public class UniTaskLoopRunnerYieldPostLateUpdate : ValueType
{
}

public class UniTaskLoopRunnerYieldPreLateUpdate : ValueType
{
}

public class UniTaskLoopRunnerYieldPreUpdate : ValueType
{
}

public class UniTaskLoopRunnerYieldTimeUpdate : ValueType
{
}

public class UniTaskLoopRunnerYieldUpdate : ValueType
{
}

public class UnicodeChar : ValueType
{
}

public class Uniforms : Object
{
    public UnityEngine.Rendering.PostProcessing.HableCurve parent; // 0x10
    public object field_1; // 0x2B
    public object field_2; // 0x2C
    public object field_3; // 0x2D
    public object field_4; // 0x2E
    public object field_5; // 0x2F
    public object field_6; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810FCE30
    public void get_curve(){} // RVA: 0x7FFE87A87300
    public void get_toeSegmentA(){} // RVA: 0x7FFE87A87340
    public void get_toeSegmentB(){} // RVA: 0x7FFE87A873A0
    public void get_midSegmentA(){} // RVA: 0x7FFE87A873F0
    public void get_midSegmentB(){} // RVA: 0x7FFE87A87450
    public void get_shoSegmentA(){} // RVA: 0x7FFE87A874A0
    public void get_shoSegmentB(){} // RVA: 0x7FFE87A87500
}

public class Union : ValueType
{
    public long m_long; // 0x10
    public object field_1; // 0x4E50

    // ── Methods ──
    public void get_m_current(){} // RVA: 0x7FFE878BA9A0
    public void set_m_current(){} // RVA: 0x7FFE878BA9C0
    public void get_m_allocCount(){} // RVA: 0x7FFE878BA9E0
    public void set_m_allocCount(){} // RVA: 0x7FFE878BA9F0
}

public class UnionCase : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86BA60A0
}

public class UnityEventHand : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87069B70
}

public class UnityEventHandlerAsyncEnumerator : MoveNextSource
{
    public System.Action`1<object> cancel1;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE810A1420
    public void get_Current(){} // RVA: 0x7FFE810A1420
    public void set_Current(){} // RVA: 0x7FFE810A1420
    public void MoveNextAsync(){}
    public void Invoke(){} // RVA: 0x7FFE810A1420
    public void OnCanceled1(){} // RVA: 0x7FFE80E46070
    public void OnCanceled2(){} // RVA: 0x7FFE80E46070
    public void DisposeAsync(){} // RVA: 0x7FFE80E2DCF0
    public void .cctor(){} // RVA: 0x7FFE80E46010
}

public class UnityEventSingleFloat : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE87069AE0
}

public class UnityLogDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82BE3CF0
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE86C1F680
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class UnityObjectKeyComparer`1 : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFE810A1420
    public void .ctor(){} // RVA: 0x7FFE80E45FE0
}

public class UnityOpenXR : Object
{
    // ── Methods ──
    public void SetClientVersion(){} // RVA: 0x7FFE86CB6170
    public void HookGetInstanceProcAddr(){} // RVA: 0x7FFE86CB6360
    public void OnInstanceCreate(){} // RVA: 0x7FFE86CB6500
    public void OnInstanceDestroy(){} // RVA: 0x7FFE86CB66A0
    public void OnSessionCreate(){} // RVA: 0x7FFE86CB6830
    public void OnAppSpaceChange(){} // RVA: 0x7FFE86CB69C0
    public void OnSessionStateChange(){} // RVA: 0x7FFE86CB6B50
    public void OnSessionBegin(){} // RVA: 0x7FFE86CB6CF0
    public void OnSessionEnd(){} // RVA: 0x7FFE86CB6E80
    public void OnSessionExiting(){} // RVA: 0x7FFE86CB7010
    public void OnSessionDestroy(){} // RVA: 0x7FFE86CB71A0
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class UnityPackage : ApiModel
{
    public string _assetUrl; // 0x68
    public string _performanceRating; // 0x70
    public string _platform; // 0x78
    public 0x664A677C<VRC.Core.ApiAvatar> _scanStatus; // 0x80
    public string _unityVersion; // 0x88
    public 0x664A564C _variant; // 0x90

    // ── Methods ──
    public void get_assetUrl(){} // RVA: 0x7FFE81176D50
    public void set_assetUrl(){} // RVA: 0x7FFE81176D60
    public void get_performanceRating(){} // RVA: 0x7FFE811C3590
    public void set_performanceRating(){} // RVA: 0x7FFE811C35A0
    public void get_platform(){} // RVA: 0x7FFE81463AE0
    public void set_platform(){} // RVA: 0x7FFE81464570
    public void get_scanStatus(){} // RVA: 0x7FFE81D30560
    public void set_scanStatus(){} // RVA: 0x7FFE81D307B0
    public void get_unityVersion(){} // RVA: 0x7FFE8113A010
    public void set_unityVersion(){} // RVA: 0x7FFE81280F90
    public void get_variant(){} // RVA: 0x7FFE814AA220
    public void set_variant(){} // RVA: 0x7FFE81C8DB30
    public void .ctor(){} // RVA: 0x7FFE8A2C0190
}

public class UnitySafeFindHandle : SafeFindHandle
{
    public UIntPtr m_Handle; // 0x20
    public object field_1; // 0x90A

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86964D10
    public void get_Handle(){} // RVA: 0x7FFE811290C0
    public void get_IsInvalid(){} // RVA: 0x7FFE848F77A0
    public void Dispose(){} // RVA: 0x7FFE86964D70
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x7FFE82A56690
    public void .ctor(){} // RVA: 0x7FFE810FB310
}

public class UnityWebRequestAsyncOperationAwaiter : ValueType
{
    public UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81E76050
    public void get_IsCompleted(){} // RVA: 0x7FFE87877440
    public void GetResult(){} // RVA: 0x7FFE8787E190
    public void OnCompleted(){} // RVA: 0x7FFE8787E430
    public void UnsafeOnCompleted(){} // RVA: 0x7FFE8787E440
}

public class UnityWebRequestAsyncOperationConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<UnityWebRequestAsyncOperationConfiguredSource> pool;

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFE84A67100
    public void .cctor(){} // RVA: 0x7FFE8787E570
    public void .ctor(){} // RVA: 0x7FFE8787E6F0
    public void Create(){} // RVA: 0x7FFE8787E7B0
    public void GetResult(){} // RVA: 0x7FFE8787ED20
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFE8787EFA0
    public void GetStatus(){} // RVA: 0x7FFE8787EFB0
    public void UnsafeGetStatus(){} // RVA: 0x7FFE8787F000
    public void OnCompleted(){} // RVA: 0x7FFE8787F040
    public void MoveNext(){} // RVA: 0x7FFE8787F0C0
    public void TryReturn(){} // RVA: 0x7FFE8787F2C0
    public void Continuation(){} // RVA: 0x7FFE8787F430
}

public class UnityWebRequestUpdate : ValueType
{
}

public class Unmanaged : ValueType
{
    // ── Methods ──
    public void Allocate(){} // RVA: 0x7FFE878B9810
    public void Free(){} // RVA: 0x7FFE810A1420 | overloaded x2
}

public class UnmanagedMemory : ValueType
{
    public void* basePtr; // 0x10
    public int mapCount; // 0x18

    // ── Methods ──
    public void get_isAllocated(){} // RVA: 0x7FFE8412EC80
    public void get_sizeInBytes(){} // RVA: 0x7FFE878F5710
    public void Allocate(){} // RVA: 0x7FFE878F5760
    public void Dispose(){} // RVA: 0x7FFE878F5960
    public void CopyDataFrom(){} // RVA: 0x7FFE878F5A10
    public void Clone(){} // RVA: 0x7FFE878F5B50
}

public class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE868DBA20
    public void Dispose(){} // RVA: 0x7FFE868DBB00
}

public class UnmanagedReadOrWrite : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE86D20460
    public void Invoke(){} // RVA: 0x7FFE812574E0
}

public class UnsignedIntegerInput : TextValueInput
{
    // ── Methods ──
    public void get_parentUnsignedIntegerField(){} // RVA: 0x7FFE87F10F10
    public void .ctor(){} // RVA: 0x7FFE87F10F90
    public void get_allowedCharacters(){} // RVA: 0x7FFE87F11150
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87F111B0
    public void ValueToString(){} // RVA: 0x7FFE87F113D0
    public void StringToValue(){} // RVA: 0x7FFE87F114C0
}

public class UnsignedLongInput : TextValueInput
{
    // ── Methods ──
    public void get_parentUnsignedLongField(){} // RVA: 0x7FFE87F12090
    public void .ctor(){} // RVA: 0x7FFE87F12110
    public void get_allowedCharacters(){} // RVA: 0x7FFE87F122D0
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87F12330
    public void ClampToMinMaxULongValue(){} // RVA: 0x7FFE87F12600
    public void ValueToString(){} // RVA: 0x7FFE87F126A0
    public void StringToValue(){} // RVA: 0x7FFE87F12790
}

public class UpdateAllRenderers : ValueType
{
}

public class UpdateAllSkinnedMeshes : ValueType
{
}

public class UpdateAsyncInstantiate : ValueType
{
}

public class UpdateAsyncReadbackManager : ValueType
{
}

public class UpdateAudio : ValueType
{
}

public class UpdateCameraMotionVectors : ValueType
{
}

public class UpdateCanvasRectTransform : ValueType
{
}

public class UpdateCaptureScreenshot : ValueType
{
}

public class UpdateContentLoading : ValueType
{
}

public class UpdateCustomRenderTextures : ValueType
{
}

public class UpdateDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE8117B190
    public void Invoke(){} // RVA: 0x7FFE81156C60
    public void BeginInvoke(){} // RVA: 0x7FFE81156C70
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class UpdateFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE81159980
    public void Invoke(){} // RVA: 0x7FFE81159A50
}

public class UpdateGridCellsJob : ValueType
{
    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFE8819F7D0
    public void UpdateRecords(){} // RVA: 0x7FFE8819F9E0
    public void InsertionSort(){} // RVA: 0x7FFE8819FE90
    public void FindPairs(){} // RVA: 0x7FFE881A0020
}

public class UpdateHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE823D7070
    public void Invoke(){} // RVA: 0x7FFE81257370
    public void BeginInvoke(){} // RVA: 0x7FFE87021810
    public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
}

public class UpdateHeadingDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFE82A97210
    public void Invoke(){} // RVA: 0x7FFE82A97390
    public void BeginInvoke(){} // RVA: 0x7FFE82A973D0
    public void EndInvoke(){} // RVA: 0x7FFE82268F40
}

public class UpdateInputManager : ValueType
{
}

public class UpdateKinect : ValueType
{
}

public class UpdateLightProbeProxyVolumes : ValueType
{
}

public class UpdateMainGameViewRect : ValueType
{
}
