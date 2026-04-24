// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 145

public class UIElementsUpdatePanels : ValueType
{
}

public class UIInvisibleGraphic : MaskableGraphic
{
    public 0x663697D0 interactibility; // 0xE0
    public bool interactableOverride; // 0xE4

    // ── Methods ──
    public void Raycast(){} // RVA: 0x7FFD4F7091C0
    public void Rebuild(){} // RVA: 0x7FFD4E341310
    public void .ctor(){} // RVA: 0x7FFD4F709250
    public void OnPopulateMesh(){} // RVA: 0x7FFD4E341310
}

public class UISearchStateMapping : ValueType
{
    public UnityEngine.GameObject targetGameObject; // 0x10
    public 0x663D99D8 requiredSearchStatus; // 0x18
    public bool invert; // 0x1C
}

public class UISoundCollection : ScriptableObject
{
    public UnityEngine.AudioClip MoveOver; // 0x18
    public UnityEngine.AudioClip MoveOff; // 0x20
    public UnityEngine.AudioClip Click; // 0x28

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E54F5F0
}

public class UISupport : Object
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFD54935DF0
}

public class UQueryMatcher : HierarchyTraversal
{
    public System.Collections.Generic.List`1<UnityEngine.UIElements.RuleMatcher> m_Matchers; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Traverse(){} // RVA: 0x7FFD54F26540
    public void OnRuleMatchedElement(){} // RVA: 0x7FFD506288B0
    public void NoProcessResult(){} // RVA: 0x7FFD4E341310
    public void TraverseRecursive(){} // RVA: 0x7FFD55044150
    public void Run(){} // RVA: 0x7FFD550443F0
}

public class URPMaterialSwitcher : MonoBehaviour
{
    public bool children; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341D50
}

public class UTF32Decoder : DecoderNLS
{
    public int HasState; // 0x30
    public int readByteCount; // 0x34

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD538047E0
    public void Reset(){} // RVA: 0x7FFD538047F0
    public void get_HasState(){} // RVA: 0x7FFD4EE081F0
}

public class UTF8Decoder : DecoderNLS
{
    public int HasState; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD538047E0
    public void Reset(){} // RVA: 0x7FFD5380B020
    public void get_HasState(){} // RVA: 0x7FFD5380B050
}

public class UTF8Encoder : EncoderNLS
{
    public int HasState; // 0x38

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53806D00
    public void Reset(){} // RVA: 0x7FFD5380AFE0
    public void get_HasState(){} // RVA: 0x7FFD5380B010
}

public class UTF8EncodingSealed : UTF8Encoding
{
    public object Preamble;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5380AE60
    public void get_Preamble(){} // RVA: 0x7FFD5380AEE0
}

public class UdonProgramScanner : Object
{
    // ── Methods ──
    public void Initialize(){} // RVA: 0x7FFD4F3578D0
    public void Equals(){} // RVA: 0x7FFD4F357AA0
}

public class UiInputField : MonoBehaviour
{
    public VRC.Localization.LocalizableString _uiInputField; // 0x20
    public UnityEngine.GameObject placeholder; // 0x48
    public VRC.Localization.LocalizableString _placeholderText; // 0x50
    public UnityEngine.GameObject textField; // 0x78
    public 0x6657A488 inputType; // 0x80
    public bool isDate; // 0x84
    public bool useNumericKeypad; // 0x85
    public UiInputField nextInputField; // 0x88
    public SubmitEvent onEndEdit; // 0x90
    public int ÌÎÍÎÍÎÏÍÎÏÏÎÏÎÌÍÎÌÎÍÏÍÍ; // 0x98
    public bool ÎÍÍÎÎÍÌÏÎÏÏÍÌÌÏÎÎÌÎÎÍÍÎ; // 0x9C
    public bool ÏÎÍÏÏÎÎÏÎÍÍÌÏÍÎÎÎÌÍÍÎÏÏ; // 0x9D
    public bool ÍÍÌÎÍÌÍÎÎÍÌÎÏÎÍÏÌÌÌÏÌÍÌ; // 0x9E
    public UnityEngine.Events.UnityAction`1<string> ÏÍÍÍÏÌÌÏÍÍÎÎÎÍÎÎÍÏÏÏÏÎÏ; // 0xA0
    public 0x664E21C0 ÌÌÌÏÌÌÏÏÍÍÎÎÏÎÏÏÎÍÌÏÍÍÏ; // 0xA8
    public UnityEngine.UI.Button ÏÏÎÍÍÌÎÍÌÏÍÍÍÍÎÌÏÏÍÏÍÏÍ; // 0xB0
    public string ÍÌÏÍÏÏÎÎÌÏÎÍÍÎÍÎÌÏÍÍÎÌÏ; // 0xB8

    // ── Methods ──
    public void get_source(){} // RVA: 0x7FFD4E90A3D0
    public void RaiseCancellation(){} // RVA: 0x7FFD4F703340
    public void get_PointerPose(){} // RVA: 0x7FFD4E3AC0B0
    public void .ctor(){} // RVA: 0x7FFD4F703440
    public void Initialize(){} // RVA: 0x7FFD4F7035D0
    public void InvokeRepeating(){} // RVA: 0x7FFD4E90A3D0
    public void CancelInvoke(){} // RVA: 0x7FFD4F703600
    public void PressEdit(){} // RVA: 0x7FFD4F703890
    public void StartCoroutine(){} // RVA: 0x7FFD4F703FE0
    public void OnPointerEnter(){} // RVA: 0x7FFD4F7042A0
    public void OnPointerExit(){} // RVA: 0x7FFD4F7045D0
    public void Awake(){} // RVA: 0x7FFD4F7045E0
    public void OnDestroy(){} // RVA: 0x7FFD4E90A3D0
    public void StopCoroutine(){} // RVA: 0x7FFD4F704FF0
    public void FixedUpdate(){} // RVA: 0x7FFD4F6A1240
    public void StopAllCoroutines(){} // RVA: 0x7FFD4F7053B0
    public void get_useGUILayout(){} // RVA: 0x7FFD4F705600
    public void set_useGUILayout(){} // RVA: 0x7FFD4F706010
    public void print(){} // RVA: 0x7FFD4F706770
    public void OnEnable(){} // RVA: 0x7FFD4F7035D0
}

public class UnboundAnchor : ValueType
{
    public OVRSpace Uuid; // 0x10
    public System.Guid Localized; // 0x18

    // ── Methods ──
    public void get_Uuid(){} // RVA: 0x7FFD4FEB27D0
    public void get_Localized(){} // RVA: 0x7FFD53D4BC40
    public void get_Localizing(){} // RVA: 0x7FFD53D4BCC0
    public void get_Pose(){} // RVA: 0x7FFD53D4BD50
    public void Localize(){} // RVA: 0x7FFD53D4BE80
    public void BindTo(){} // RVA: 0x7FFD53D4C240
    public void .ctor(){} // RVA: 0x7FFD51517E80
}

public class UnboundedChannelReader : ChannelReader`1
{
    public System.Threading.Channels.SingleConsumerUnboundedChannel`1<ZLogger.IZLoggerEntry> _parent; // 0x10
    public System.Threading.Channels.AsyncOperation`1<ZLogger.IZLoggerEntry> _readerSingleton; // 0x18
    public System.Threading.Channels.AsyncOperation`1<bool> _waiterSingleton; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void TryRead(){} // RVA: 0x7FFD4E079F60
    public void WaitToReadAsync(){}
}

public class UnboundedChannelWriter : ChannelWriter`1
{
    public System.Threading.Channels.SingleConsumerUnboundedChannel`1<ZLogger.IZLoggerEntry> _parent; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void TryComplete(){} // RVA: 0x7FFD4E079F60
    public void TryWrite(){} // RVA: 0x7FFD4E2ADC40
    public void WaitToWriteAsync(){}
    public void WriteAsync(){} // RVA: 0x7FFD4E2ADC40
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

public class Union : ValueType
{
    public 0x66526F20 m_current; // 0x10
    public System.Collections.Generic.List`1<UnionCase> Cases; // 0x18

    // ── Methods ──
    public void get_m_current(){} // RVA: 0x7FFD54932260
    public void set_m_current(){} // RVA: 0x7FFD54932280
    public void get_m_allocCount(){} // RVA: 0x7FFD549322A0
    public void set_m_allocCount(){} // RVA: 0x7FFD549322B0
}

public class UnionCase : Object
{
    public int Tag; // 0x10
    public string Name; // 0x18
    public System.Reflection.PropertyInfo[] Fields; // 0x20
    public 0x66526F20 FieldReader; // 0x28
    public 0x66526F20 Constructor; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD53C1C980
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
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_Current(){} // RVA: 0x7FFD4E2ADC40
    public void set_Current(){} // RVA: 0x7FFD4E2ADC40
    public void MoveNextAsync(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    public void OnCanceled1(){} // RVA: 0x7FFD4E090A10
    public void OnCanceled2(){} // RVA: 0x7FFD4E090A10
    public void DisposeAsync(){} // RVA: 0x7FFD4E0788A0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class UnityObjectKeyComparer`1 : Object
{
    // ── Methods ──
    public void Compare(){} // RVA: 0x7FFD4E2ADC40
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Methods ──
    public void Get(){} // RVA: 0x7FFD4FC0E2F0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class UnityWebRequestAsyncOperationAwaiter : ValueType
{
    public UnityEngine.Networking.UnityWebRequestAsyncOperation IsCompleted; // 0x10
    public System.Action`1<UnityEngine.AsyncOperation> continuationAction; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4EFD0830
    public void get_IsCompleted(){} // RVA: 0x7FFD548EED00
    public void GetResult(){} // RVA: 0x7FFD548F5A50
    public void OnCompleted(){} // RVA: 0x7FFD548F5CF0
    public void UnsafeOnCompleted(){} // RVA: 0x7FFD548F5D00
}

public class UnityWebRequestUpdate : ValueType
{
}

public class Unmanaged : ValueType
{
    // ── Methods ──
    public void Allocate(){} // RVA: 0x7FFD549310D0
    public void Free(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
}

public class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
{
    public System.Reflection.Module module; // 0x68

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD539521F0
    public void Dispose(){} // RVA: 0x7FFD539522D0
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
    public void .ctor(){} // RVA: 0x7FFD4E3C1190
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
    public void BeginInvoke(){} // RVA: 0x7FFD4E39CC70
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class UpdateFunction : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class UpdateGridCellsJob : ValueType
{
    public Unity.Collections.NativeList`1<GridCell> gridCells; // 0x10
    public Unity.Collections.NativeArray`1<ShapeData> shapeData; // 0x18
    public ParallelWriter<Pair,bool> collisionPairs; // 0x28

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFD55216D40
    public void UpdateRecords(){} // RVA: 0x7FFD55216F50
    public void InsertionSort(){} // RVA: 0x7FFD552173D0
    public void FindPairs(){} // RVA: 0x7FFD55217520
}

public class UpdateHeadingDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC4EE70
    public void Invoke(){} // RVA: 0x7FFD4FC4EFF0
    public void BeginInvoke(){} // RVA: 0x7FFD4FC4F030
    public void EndInvoke(){} // RVA: 0x7FFD4F454000
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

public class UpdateMasterServerInterface : ValueType
{
}

public class UpdateNetworkManager : ValueType
{
}

public class UpdatePreloading : ValueType
{
}

public class UpdateRectTransform : ValueType
{
}

public class UpdateResolution : ValueType
{
}

public class UpdateRootsJob : ValueType
{
    public int MAX_EXECUTIONS;
    public float realTime; // 0x10
    public float fixedTime; // 0x14
    public Unity.Collections.NativeArray`1<ChainRoot> roots; // 0x18
    public int FIXED_TIME_COUNTER_MAX;

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFD5526E320
    public void CalculateShouldUseFixedTime(){} // RVA: 0x7FFD5526E470
}

public class UpdateShapePositionsJob : ValueType
{
    public int SHAPE_BATCH_COUNT;
    public Unity.Collections.NativeList`1<ushort> activeShapes; // 0x10
    public Unity.Collections.NativeArray`1<ShapeData> shapeData; // 0x18
    public Unity.Collections.NativeArray`1<0x664E1038> transformData; // 0x28
    public Unity.Collections.NativeArray`1<int> transformLookup; // 0x38

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFD5521D650
    public void GetTransform(){} // RVA: 0x7FFD5521D900
    public void .cctor(){} // RVA: 0x7FFD5521D940
}

public class UpdateShapesJob : ValueType
{
    public Unity.Collections.NativeQueue`1<ushort> shapesToUpdate; // 0x10
    public Unity.Collections.NativeArray`1<ShapeData> shapeData; // 0x18
    public Unity.Collections.NativeHashMap`2<UnityEngine.Vector3Int,int> gridMap; // 0x28
    public Unity.Collections.NativeList`1<GridCell> gridCells; // 0x30
    public Unity.Collections.NativeList`1<int> cellCache; // 0x38

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFD55211530
    public void RemoveShape(){} // RVA: 0x7FFD55211CD0 | overloaded x2
    public void AddShape(){} // RVA: 0x7FFD55211ED0 | overloaded x2
}

public class UpdateStatus : Object
{
    public int kWindowSize;
    public int windowStart; // 0x10
    public int numWindowLateUpdateMoves; // 0x14
    public int numWindowFixedUpdateMoves; // 0x18
    public int numWindows; // 0x1C
    public int lastFrameUpdated; // 0x20
    public UnityEngine.Matrix4x4 lastPos; // 0x24
    public 0x6658B788 <PreferredUpdate>k__BackingField; // 0x64

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class UpdateStepCount : ValueType
{
    public bool value; // 0x10
    public uint <value>k__BackingField; // 0x14

    // ── Methods ──
    public void get_value(){} // RVA: 0x7FFD4F8402A0
    public void set_value(){} // RVA: 0x7FFD4F840230
    public void OnBeforeUpdate(){} // RVA: 0x7FFD54A9DA10
    public void OnUpdate(){} // RVA: 0x7FFD54A9DA20
}

public class UpdateStreamingManager : ValueType
{
}

public class UpdateSubstance : ValueType
{
}

public class UpdateTextureStreamingManager : ValueType
{
}

public class UpdateVideo : ValueType
{
}

public class UpdateVideoTextures : ValueType
{
}

public class UpdatedEventHandler : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39F980
    public void Invoke(){} // RVA: 0x7FFD4E39FA50
}

public class UriInfo : Object
{
    public string Host; // 0x10
    public string ScopeId; // 0x18
    public string String; // 0x20
    public Offset Offset; // 0x28
    public string DnsSafeHost; // 0x38
    public MoreInfo MoreInfo; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class UserController : ScriptableObject
{
    public bool testSteamAccount; // 0x18

    // ── Methods ──
    public void BackPressed(){} // RVA: 0x7FFD4EDD4E30
    public void CreateInstance(){} // RVA: 0x7FFD4F68DD60
    public void Equals(){} // RVA: 0x7FFD4F68DF40
    public void CreateScriptableObject(){} // RVA: 0x7FFD4F68DFE0
    public void CreateScriptableObjectInstanceFromType(){} // RVA: 0x7FFD4F68E080
    public void GetHashCode(){} // RVA: 0x7FFD4F68E120
    public void ToString(){} // RVA: 0x7FFD4F68E1C0
    public void GetGameObject_C12(){} // RVA: 0x7FFD4F68E260
    public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    public void Initialize(){} // RVA: 0x7FFD4F68E300
    public void GetGameObject_A97(){} // RVA: 0x7FFD4F68E390
    public void SetActive_448(){} // RVA: 0x7FFD4F68E430
}

public class UserDefinedSettings : ValueType
{
    public ushort stereoRenderingMode; // 0x10
    public ushort initializationType; // 0x12
    public ushort mirrorViewMode; // 0x14
    public string editorAppKey; // 0x18
    public string actionManifestPath; // 0x20
    public string applicationName; // 0x28
}

public class UserHandle : ValueType
{
    public UIntPtr Handle; // 0x10

    // ── Methods ──
    public void Drop(){} // RVA: 0x7FFD4FD96780
    public void DisplayName(){} // RVA: 0x7FFD4FD96800
    public void Id(){} // RVA: 0x7FFD4FD96890
    public void Status(){} // RVA: 0x7FFD4FD96910
}

public class UxmlFactory : UxmlFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD55011380
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    public UnityEngine.UIElements.UxmlObjectListAttributeDescription`1<UnityEngine.UIElements.SortColumnDescription> m_SortColumnDescriptions;

    // ── Methods ──
    public void ParseLength(){} // RVA: 0x7FFD4E2ADC40
    public void Init(){}
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class UxmlTraits : UxmlTraits
{
    public ÎÏÌÎÎÎÌÌÌ.ntCallbackCategories m_MaxLength;
    public ÎÏÌÎÎÎÌÌÌ.ementPanel m_Password;
    public ÎÏÌÎÎÎÌÌÌ.bledInHierarchy m_MaskCharacter;
    public ÎÏÌÎÎÎÌÌÌ.ementPanel m_IsReadOnly;
    public ÎÏÌÎÎÎÌÌÌ.ementPanel m_IsDelayed;
    public ÎÏÌÎÎÎÌÌÌ.ementPanel m_HideMobileInput;
    public ÎÏÌÎÎÎÌÌÌ.?<Underscore> m_KeyboardType;
    public ÎÏÌÎÎÎÌÌÌ.ementPanel m_AutoCorrection;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5227E2C0
    public void Init(){} // RVA: 0x7FFD5227E440
    public void ParseChoiceList(){} // RVA: 0x7FFD5227E5D0
}
