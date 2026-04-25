// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 239

public class UBI : Object
{
    public UbiTweak tweak; // 0x10
    public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests.SkeinEngine engine; // 0x18
    public byte[] currentBlock; // 0x20
    public int currentOffset; // 0x28
    public ulong[] message; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBC7FEC0
    public void Reset(){} // RVA: 0x7FFACBC803C0 | overloaded x2
    public void Update(){} // RVA: 0x7FFACBC80480
    public void ProcessBlock(){} // RVA: 0x7FFACBC805E0
    public void DoFinal(){} // RVA: 0x7FFACBC80760
}

public class UIActions : ValueType
{
    public UnityEngine.InputSystem.DefaultInputActions Navigate; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC38DFE40
    public void get_Navigate(){} // RVA: 0x7FFAC38E2420
    public void get_Submit(){} // RVA: 0x7FFAC38DCA50
    public void get_Cancel(){} // RVA: 0x7FFAC38DFEF0
    public void get_Point(){} // RVA: 0x7FFAC38E24C0
    public void get_Click(){} // RVA: 0x7FFAC38DFE20
    public void get_ScrollWheel(){} // RVA: 0x7FFAC38DFE00
    public void get_MiddleClick(){} // RVA: 0x7FFAC38DCA90
    public void get_RightClick(){} // RVA: 0x7FFAC38DC9D0
    public void get_TrackedDevicePosition(){} // RVA: 0x7FFAC38DFD60
    public void get_TrackedDeviceOrientation(){} // RVA: 0x7FFAC38DC970
    public void Get(){} // RVA: 0x7FFAC38E23E0
    public void Enable(){} // RVA: 0x7FFAC9622D20
    public void Disable(){} // RVA: 0x7FFAC9622DA0
    public void get_enabled(){} // RVA: 0x7FFAC9622DE0
    public void op_Implicit(){} // RVA: 0x7FFAC48AEB50
    public void SetCallbacks(){} // RVA: 0x7FFAC9622E10
}

public class UIElementsUpdatePanels : ValueType
{
}

public class UIInvisibleGraphic : MaskableGraphic
{
    public 0x6B0097D0 interactibility; // 0xE0
    public bool interactableOverride; // 0xE4

    // ── Methods ──
    public void Raycast(){} // RVA: 0x7FFAC42E91C0
    public void Rebuild(){} // RVA: 0x7FFAC2F21310
    public void .ctor(){} // RVA: 0x7FFAC42E9250
    public void OnPopulateMesh(){} // RVA: 0x7FFAC2F21310
}

public class UISearchStateMapping : ValueType
{
    public UnityEngine.GameObject targetGameObject; // 0x10
    public 0x6B0799D8 requiredSearchStatus; // 0x18
    public bool invert; // 0x1C
}

public class UISoundCollection : ScriptableObject
{
    public UnityEngine.AudioClip MoveOver; // 0x18
    public UnityEngine.AudioClip MoveOff; // 0x20
    public UnityEngine.AudioClip Click; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC312F5F0
}

public class UISupport : Object
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFAC9515DF0
}

public class UIToolkitOverrideConfig : ValueType
{
    public UnityEngine.EventSystems.EventSystem activeEventSystem; // 0x10
    public bool sendEvents; // 0x18
    public bool createPanelGameObjectsOnStart; // 0x19
}

public class UNICODE_STRING : ValueType
{
    public ushort Length; // 0x10
    public ushort MaximumLength; // 0x12
    public UIntPtr Buffer; // 0x18
}

public class UQueryMatcher : HierarchyTraversal
{
    public System.Collections.Generic.List`1<UnityEngine.UIElements.RuleMatcher> m_Matchers; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21310
    public void Traverse(){} // RVA: 0x7FFAC9B06540
    public void OnRuleMatchedElement(){} // RVA: 0x7FFAC52088B0
    public void NoProcessResult(){} // RVA: 0x7FFAC2F21310
    public void TraverseRecursive(){} // RVA: 0x7FFAC9C24150
    public void Run(){} // RVA: 0x7FFAC9C243F0
}

public class URPMaterialSwitcher : MonoBehaviour
{
    public bool children; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F21D50
}

public class UTF32Decoder : DecoderNLS
{
    public int HasState; // 0x30
    public int readByteCount; // 0x34

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83E47E0
    public void Reset(){} // RVA: 0x7FFAC83E47F0
    public void get_HasState(){} // RVA: 0x7FFAC39E81F0
}

public class UTF8Decoder : DecoderNLS
{
    public int HasState; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83E47E0
    public void Reset(){} // RVA: 0x7FFAC83EB020
    public void get_HasState(){} // RVA: 0x7FFAC83EB050
}

public class UTF8Encoder : EncoderNLS
{
    public int HasState; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83E6D00
    public void Reset(){} // RVA: 0x7FFAC83EAFE0
    public void get_HasState(){} // RVA: 0x7FFAC83EB010
}

public class UTF8EncodingSealed : UTF8Encoding
{
    public object Preamble;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC83EAE60
    public void get_Preamble(){} // RVA: 0x7FFAC83EAEE0
}

public class UbiTweak : Object
{
    public ulong Type;
    public ulong First;
    public ulong Final;
    public ulong[] tweak; // 0x10
    public bool extendedPosition; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFACBC7F690
    public void Reset(){} // RVA: 0x7FFACBC7F850 | overloaded x2
    public void get_Type(){} // RVA: 0x7FFACBC7F8B0
    public void set_Type(){} // RVA: 0x7FFACBC7F8E0
    public void get_First(){} // RVA: 0x7FFACBC7F930
    public void set_First(){} // RVA: 0x7FFACBC7F970
    public void get_Final(){} // RVA: 0x7FFACBC7F9D0
    public void set_Final(){} // RVA: 0x7FFACBC7FA10
    public void AdvancePosition(){} // RVA: 0x7FFACBC7FA70
    public void GetWords(){} // RVA: 0x7FFAC2F3C380
    public void ToString(){} // RVA: 0x7FFACBC7FC30
}

public class UdonProgramScanner : Object
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFAC3F378D0
    public void Equals(){} // RVA: 0x7FFAC3F37AA0
}

public class UdonTimeSource : Object
{
    public double CurrentTime; // 0x10
    public long CurrentFrame; // 0x18

    // ── Methods ──
    public void get_CurrentTime(){} // RVA: 0x7FFAC5873C20
    public void set_CurrentTime(){} // RVA: 0x7FFAC69C0110
    public void get_CurrentFrame(){} // RVA: 0x7FFAC2F247C0
    public void set_CurrentFrame(){} // RVA: 0x7FFAC38920D0
    public void get_MinimumDelay(){} // RVA: 0x7FFAC9E9F5A0
    public void UpdateTime(){} // RVA: 0x7FFAC9E9F5B0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class UiInputField : MonoBehaviour
{
    public VRC.Localization.LocalizableString _uiInputField; // 0x20
    public UnityEngine.GameObject placeholder; // 0x48
    public VRC.Localization.LocalizableString _placeholderText; // 0x50
    public UnityEngine.GameObject textField; // 0x78
    public 0x6B21A488 inputType; // 0x80
    public bool isDate; // 0x84
    public bool useNumericKeypad; // 0x85
    public UiInputField nextInputField; // 0x88
    public SubmitEvent onEndEdit; // 0x90
    public int ÌÎÍÎÍÎÏÍÎÏÏÎÏÎÌÍÎÌÎÍÏÍÍ; // 0x98
    public bool ÎÍÍÎÎÍÌÏÎÏÏÍÌÌÏÎÎÌÎÎÍÍÎ; // 0x9C
    public bool ÏÎÍÏÏÎÎÏÎÍÍÌÏÍÎÎÎÌÍÍÎÏÏ; // 0x9D
    public bool ÍÍÌÎÍÌÍÎÎÍÌÎÏÎÍÏÌÌÌÏÌÍÌ; // 0x9E
    public UnityEngine.Events.UnityAction`1<string> ÏÍÍÍÏÌÌÏÍÍÎÎÎÍÎÎÍÏÏÏÏÎÏ; // 0xA0
    public UnityEngine.Events.UnityAction ÌÌÌÏÌÌÏÏÍÍÎÎÏÎÏÏÎÍÌÏÍÍÏ; // 0xA8
    public UnityEngine.UI.Button ÏÏÎÍÍÌÎÍÌÏÍÍÍÍÎÌÏÏÍÏÍÏÍ; // 0xB0
    public string ÍÌÏÍÏÏÎÎÌÏÎÍÍÎÍÎÌÏÍÍÎÌÏ; // 0xB8

    // ── Methods ──
    public void get_source(){} // RVA: 0x7FFAC34EA3D0
    public void RaiseCancellation(){} // RVA: 0x7FFAC42E3340
    public void get_PointerPose(){} // RVA: 0x7FFAC2F8C0B0
    public void .ctor(){} // RVA: 0x7FFAC42E3440
    public void Initialize(){} // RVA: 0x7FFAC42E35D0
    public void InvokeRepeating(){} // RVA: 0x7FFAC34EA3D0
    public void CancelInvoke(){} // RVA: 0x7FFAC42E3600
    public void PressEdit(){} // RVA: 0x7FFAC42E3890
    public void StartCoroutine(){} // RVA: 0x7FFAC42E3FE0
    public void OnPointerEnter(){} // RVA: 0x7FFAC42E42A0
    public void OnPointerExit(){} // RVA: 0x7FFAC42E45D0
    public void Awake(){} // RVA: 0x7FFAC42E45E0
    public void OnDestroy(){} // RVA: 0x7FFAC34EA3D0
    public void StopCoroutine(){} // RVA: 0x7FFAC42E4FF0
    public void FixedUpdate(){} // RVA: 0x7FFAC4281240
    public void StopAllCoroutines(){} // RVA: 0x7FFAC42E53B0
    public void get_useGUILayout(){} // RVA: 0x7FFAC42E5600
    public void set_useGUILayout(){} // RVA: 0x7FFAC42E6010
    public void print(){} // RVA: 0x7FFAC42E6770
    public void OnEnable(){} // RVA: 0x7FFAC42E35D0
}

public class Uint16ToBytes : ValueType
{
    public ushort Int; // 0x10
    public byte byte0; // 0x10
    public byte byte1; // 0x11
}

public class Uint32ToBytes : ValueType
{
    public uint Int; // 0x10
    public byte byte0; // 0x10
    public byte byte1; // 0x11
    public byte byte2; // 0x12
    public byte byte3; // 0x13
}

public class Uint64ToBytes : ValueType
{
    public ulong Int; // 0x10
    public byte byte0; // 0x10
    public byte byte1; // 0x11
    public byte byte2; // 0x12
    public byte byte3; // 0x13
    public byte byte4; // 0x14
    public byte byte5; // 0x15
    public byte byte6; // 0x16
    public byte byte7; // 0x17
    public byte byte8; // 0x18
}

public class UnaryExpressionProxy : Object
{
    public System.Linq.Expressions.UnaryExpression CanReduce; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8D727E0
    public void get_CanReduce(){} // RVA: 0x7FFAC880FE40
    public void get_DebugView(){} // RVA: 0x7FFAC8D710B0
    public void get_IsLifted(){} // RVA: 0x7FFAC8D728C0
    public void get_IsLiftedToNull(){} // RVA: 0x7FFAC8D728E0
    public void get_Method(){} // RVA: 0x7FFAC3773190
    public void get_NodeType(){} // RVA: 0x7FFAC84E9CA0
    public void get_Operand(){} // RVA: 0x7FFAC37735E0
    public void get_Type(){} // RVA: 0x7FFAC87BB0A0
}

public class UnboundAnchor : ValueType
{
    public OVRSpace Uuid; // 0x10
    public System.Guid Localized; // 0x18

    // ── Methods ──
    public void get_Uuid(){} // RVA: 0x7FFAC4A927D0
    public void get_Localized(){} // RVA: 0x7FFAC892BC40
    public void get_Localizing(){} // RVA: 0x7FFAC892BCC0
    public void get_Pose(){} // RVA: 0x7FFAC892BD50
    public void Localize(){} // RVA: 0x7FFAC892BE80
    public void BindTo(){} // RVA: 0x7FFAC892C240
    public void .ctor(){} // RVA: 0x7FFAC60F7E80
}

public class UnboundedChannelReader : ChannelReader`1
{
    public System.Threading.Channels.SingleConsumerUnboundedChannel`1<T> _parent;
    public System.Threading.Channels.AsyncOperation`1<T> _readerSingleton;
    public System.Threading.Channels.AsyncOperation`1<bool> _waiterSingleton;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void TryRead(){} // RVA: 0x7FFAC2C59F60
    public void WaitToReadAsync(){}
}

public class UnboundedChannelWriter : ChannelWriter`1
{
    public System.Threading.Channels.SingleConsumerUnboundedChannel`1<T> _parent;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2C70A40
    public void TryComplete(){} // RVA: 0x7FFAC2C59F60
    public void TryWrite(){} // RVA: 0x7FFAC2E8DC40
    public void WaitToWriteAsync(){}
    public void WriteAsync(){} // RVA: 0x7FFAC2E8DC40
}

public class Unchecked : NumericConvertInstruction
{
    public object InstructionName;

    // ── Methods ──
    public void get_InstructionName(){} // RVA: 0x7FFAC8DE6380
    public void .ctor(){} // RVA: 0x7FFAC8DE6030
    public void Convert(){} // RVA: 0x7FFAC8DE63C0
    public void ConvertInt32(){} // RVA: 0x7FFAC8DE67F0
    public void ConvertInt64(){} // RVA: 0x7FFAC8DE6AD0
    public void ConvertUInt64(){} // RVA: 0x7FFAC8DE6D80
    public void ConvertDouble(){} // RVA: 0x7FFAC8DE7050
}

public class UndeclaredNotation : Object
{
    public string name; // 0x10
    public int lineNo; // 0x18
    public int linePos; // 0x1C
    public UndeclaredNotation next; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC9212E30
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
    public int unicode; // 0x10
    public int stringIndex; // 0x14
    public int length; // 0x18
}

public class Uniforms : Object
{
    public UnityEngine.Rendering.PostProcessing.HableCurve curve; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F22E30
    public void get_curve(){} // RVA: 0x7FFAC96DED90
    public void get_toeSegmentA(){} // RVA: 0x7FFAC96DEDD0
    public void get_toeSegmentB(){} // RVA: 0x7FFAC96DEE30
    public void get_midSegmentA(){} // RVA: 0x7FFAC96DEE80
    public void get_midSegmentB(){} // RVA: 0x7FFAC96DEEE0
    public void get_shoSegmentA(){} // RVA: 0x7FFAC96DEF30
    public void get_shoSegmentB(){} // RVA: 0x7FFAC96DEF90
}

public class Union : Object
{
    public Newtonsoft.Json.Utilities.FSharpFunction TagReader; // 0x10
    public System.Collections.Generic.List`1<UnionCase> Cases; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC34EC240
}

public class UnionCase : Object
{
    public int Tag; // 0x10
    public string Name; // 0x18
    public System.Reflection.PropertyInfo[] Fields; // 0x20
    public Newtonsoft.Json.Utilities.FSharpFunction FieldReader; // 0x28
    public Newtonsoft.Json.Utilities.FSharpFunction Constructor; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC87FC980
}

public class UnityEventHand : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8CC1680
}

public class UnityEventHandlerAsyncEnumerator : MoveNextSource
{
    public System.Action`1<object> Current;
    public System.Action`1<object> cancel2;
    public UnityEngine.Events.UnityEvent`1<T> unityEvent;
    public System.Threading.CancellationToken cancellationToken1;
    public System.Threading.CancellationToken cancellationToken2;
    public UnityEngine.Events.UnityAction`1<T> unityAction;
    public System.Threading.CancellationTokenRegistration registration1;
    public System.Threading.CancellationTokenRegistration registration2;
    public bool isDisposed;
    public T <Current>k__BackingField;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    public void get_Current(){} // RVA: 0x7FFAC2E8DC40
    public void set_Current(){} // RVA: 0x7FFAC2E8DC40
    public void MoveNextAsync(){}
    public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    public void OnCanceled1(){} // RVA: 0x7FFAC2C70A10
    public void OnCanceled2(){} // RVA: 0x7FFAC2C70A10
    public void DisposeAsync(){} // RVA: 0x7FFAC2C588A0
    public void .cctor(){} // RVA: 0x7FFAC2C709B0
}

public class UnityEventSingleFloat : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8CC15F0
}

public class UnityLogDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC49781F0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC8875F90
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class UnityObjectKeyComparer`1 : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFAC2E8DC40
    public void .ctor(){} // RVA: 0x7FFAC2C70980
}

public class UnityOpenXR : Object
{
    public bool Enabled;

    // ── Methods ──
    public void SetClientVersion(){} // RVA: 0x7FFAC890CA80
    public void HookGetInstanceProcAddr(){} // RVA: 0x7FFAC890CC70
    public void OnInstanceCreate(){} // RVA: 0x7FFAC890CE10
    public void OnInstanceDestroy(){} // RVA: 0x7FFAC890CFB0
    public void OnSessionCreate(){} // RVA: 0x7FFAC890D140
    public void OnAppSpaceChange(){} // RVA: 0x7FFAC890D2D0
    public void OnSessionStateChange(){} // RVA: 0x7FFAC890D460
    public void OnSessionBegin(){} // RVA: 0x7FFAC890D600
    public void OnSessionEnd(){} // RVA: 0x7FFAC890D790
    public void OnSessionExiting(){} // RVA: 0x7FFAC890D920
    public void OnSessionDestroy(){} // RVA: 0x7FFAC890DAB0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class UnityPackage : ApiModel
{
    public string assetUrl; // 0x68
    public string performanceRating; // 0x70
    public string platform; // 0x78
    public 0x6B0AD960<VRC.Core.ApiAvatar> scanStatus; // 0x80
    public string unityVersion; // 0x88
    public 0x6B0ACE60 variant; // 0x90

    // ── Methods ──
    public void get_assetUrl(){} // RVA: 0x7FFAC2F9CD50
    public void set_assetUrl(){} // RVA: 0x7FFAC2F9CD60
    public void get_performanceRating(){} // RVA: 0x7FFAC2FE9590
    public void set_performanceRating(){} // RVA: 0x7FFAC2FE95A0
    public void get_platform(){} // RVA: 0x7FFAC30E5600
    public void set_platform(){} // RVA: 0x7FFAC30E06F0
    public void get_scanStatus(){} // RVA: 0x7FFAC35729C0
    public void set_scanStatus(){} // RVA: 0x7FFAC3572BF0
    public void get_unityVersion(){} // RVA: 0x7FFAC2F60010
    public void set_unityVersion(){} // RVA: 0x7FFAC354E300
    public void get_variant(){} // RVA: 0x7FFAC3220660
    public void set_variant(){} // RVA: 0x7FFAC34D2750
    public void .ctor(){} // RVA: 0x7FFACBE66B20
}

public class UnitySafeFindHandle : SafeFindHandle
{
    public UIntPtr Handle; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85BB540
    public void get_Handle(){} // RVA: 0x7FFAC2F4F0C0
    public void get_IsInvalid(){} // RVA: 0x7FFAC65A7D10
    public void Dispose(){} // RVA: 0x7FFAC85BB5A0
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x7FFAC47EE2F0
    public void .ctor(){} // RVA: 0x7FFAC2F21310
}

public class UnityWebRequestAsyncOperationAwaiter : ValueType
{
    public UnityEngine.Networking.UnityWebRequestAsyncOperation IsCompleted; // 0x10
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC3BB0830
    public void get_IsCompleted(){} // RVA: 0x7FFAC94CED00
    public void GetResult(){} // RVA: 0x7FFAC94D5A50
    public void OnCompleted(){} // RVA: 0x7FFAC94D5CF0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFAC94D5D00
}

public class UnityWebRequestAsyncOperationConfiguredSource : Object
{
    public Cysharp.Threading.Tasks.TaskPool`1<UnityWebRequestAsyncOperationConfiguredSource> NextNode;
    public UnityWebRequestAsyncOperationConfiguredSource nextNode; // 0x10
    public UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOperation; // 0x18
    public System.IProgress`1<float> progress; // 0x20
    public System.Threading.CancellationToken cancellationToken; // 0x28
    public System.Threading.CancellationTokenRegistration cancellationTokenRegistration; // 0x30
    public bool cancelImmediately; // 0x48
    public bool completed; // 0x49
    public Cysharp.Threading.Tasks.UniTaskCompletionSourceCore`1<UnityEngine.Networking.UnityWebRequest> core; // 0x50
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x78

    // ── Methods ──
    public void get_NextNode(){} // RVA: 0x7FFAC671A9E0
    public void .cctor(){} // RVA: 0x7FFAC94D5E30
    public void .ctor(){} // RVA: 0x7FFAC94D5FB0
    public void Create(){} // RVA: 0x7FFAC94D6070
    public void GetResult(){} // RVA: 0x7FFAC94D65E0
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFAC94D6860
    public void GetStatus(){} // RVA: 0x7FFAC94D6870
    public void UnsafeGetStatus(){} // RVA: 0x7FFAC94D68C0
    public void OnCompleted(){} // RVA: 0x7FFAC94D6900
    public void MoveNext(){} // RVA: 0x7FFAC94D6980
    public void TryReturn(){} // RVA: 0x7FFAC94D6B80
    public void Continuation(){} // RVA: 0x7FFAC94D6CF0
}

public class UnityWebRequestUpdate : ValueType
{
}

public class Unmanaged : ValueType
{
    // ── Methods ──
    public void Allocate(){} // RVA: 0x7FFAC95110D0
    public void Free(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
}

public class UnmanagedMemory : ValueType
{
    public void* isAllocated; // 0x10
    public int sizeInBytes; // 0x18
    public int actionCount; // 0x1C
    public int interactionCount; // 0x20
    public int bindingCount; // 0x24
    public int controlCount; // 0x28
    public int compositeCount; // 0x2C
    public TriggerState* actionStates; // 0x30
    public BindingState* bindingStates; // 0x38
    public InteractionState* interactionStates; // 0x40
    public float* controlMagnitudes; // 0x48
    public float* compositeMagnitudes; // 0x50
    public int* enabledControls; // 0x58
    public ushort* actionBindingIndicesAndCounts; // 0x60
    public ushort* actionBindingIndices; // 0x68
    public int* controlIndexToBindingIndex; // 0x70
    public ushort* controlGroupingAndComplexity; // 0x78
    public bool controlGroupingInitialized; // 0x80
    public ActionMapIndices* mapIndices; // 0x88

    // ── Methods ──
    public void get_isAllocated(){} // RVA: 0x7FFAC5DC6CA0
    public void get_sizeInBytes(){} // RVA: 0x7FFAC954CFD0
    public void Allocate(){} // RVA: 0x7FFAC954D020
    public void Dispose(){} // RVA: 0x7FFAC954D220
    public void CopyDataFrom(){} // RVA: 0x7FFAC954D2D0
    public void Clone(){} // RVA: 0x7FFAC954D410
}

public class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
{
    public System.Reflection.Module module; // 0x68

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC85321F0
    public void Dispose(){} // RVA: 0x7FFAC85322D0
}

public class UnmanagedReadOrWrite : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC8976DD0
    public void Invoke(){} // RVA: 0x7FFAC307D4E0
}

public class UnsignedIntegerInput : TextValueInput
{
    public object parentUnsignedIntegerField;
    public object allowedCharacters;

    // ── Methods ──
    public void get_parentUnsignedIntegerField(){} // RVA: 0x7FFAC9B68670
    public void .ctor(){} // RVA: 0x7FFAC9B686F0
    public void get_allowedCharacters(){} // RVA: 0x7FFAC9B688B0
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9B68910
    public void ValueToString(){} // RVA: 0x7FFAC9B68B30
    public void StringToValue(){} // RVA: 0x7FFAC9B68C20
}

public class UnsignedLongInput : TextValueInput
{
    public object parentUnsignedLongField;
    public object allowedCharacters;

    // ── Methods ──
    public void get_parentUnsignedLongField(){} // RVA: 0x7FFAC9B697F0
    public void .ctor(){} // RVA: 0x7FFAC9B69870
    public void get_allowedCharacters(){} // RVA: 0x7FFAC9B69A30
    public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9B69A90
    public void ClampToMinMaxULongValue(){} // RVA: 0x7FFAC9B69D60
    public void ValueToString(){} // RVA: 0x7FFAC9B69E00
    public void StringToValue(){} // RVA: 0x7FFAC9B69EF0
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
    public void .ctor(){} // RVA: 0x7FFAC2FA1190
    public void Invoke(){} // RVA: 0x7FFAC2F7CC60
    public void BeginInvoke(){} // RVA: 0x7FFAC2F7CC70
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class UpdateFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC2F7F980
    public void Invoke(){} // RVA: 0x7FFAC2F7FA50
}

public class UpdateGridCellsJob : ValueType
{
    public Unity.Collections.NativeList`1<GridCell> gridCells; // 0x10
    public Unity.Collections.NativeArray`1<ShapeData> shapeData; // 0x18
    public ParallelWriter<Pair,bool> collisionPairs; // 0x28

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFAC9DF6D40
    public void UpdateRecords(){} // RVA: 0x7FFAC9DF6F50
    public void InsertionSort(){} // RVA: 0x7FFAC9DF73D0
    public void FindPairs(){} // RVA: 0x7FFAC9DF7520
}

public class UpdateHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC411D4B0
    public void Invoke(){} // RVA: 0x7FFAC307D370
    public void BeginInvoke(){} // RVA: 0x7FFAC8C79320
    public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
}

public class UpdateHeadingDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFAC482EE70
    public void Invoke(){} // RVA: 0x7FFAC482EFF0
    public void BeginInvoke(){} // RVA: 0x7FFAC482F030
    public void EndInvoke(){} // RVA: 0x7FFAC4034000
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
