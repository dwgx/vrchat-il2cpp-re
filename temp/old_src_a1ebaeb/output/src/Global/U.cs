// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 192

public class UIElementsUpdatePanels : ValueType
{
}

public class UIInvisibleGraphic : MaskableGraphic
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa9d10800
    public void Raycast(){} // RVA: 0x7ffaa9d10810
    public void Rebuild(){} // RVA: 0x7ffaa8932310
    public void OnPopulateMesh(){} // RVA: 0x7ffaa8932310
}

public class UISearchStateMapping : ValueType
{
    public object invert; // 0x349E31B0
}

public class UISoundCollection : ScriptableObject
{
    public object Click; // 0x33C44380

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8b59ae0
}

public class UISupport : Object
{
    // ── Original Methods ──
    public void Initialize(){} // RVA: 0x7ffaaef37dc0
}

public class UQueryMatcher : HierarchyTraversal
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
    public void Traverse(){} // RVA: 0x7ffaaf5284a0
    public void OnRuleMatchedElement(){} // RVA: 0x7ffaaac0a810
    public void NoProcessResult(){} // RVA: 0x7ffaa8932310
    public void TraverseRecursive(){} // RVA: 0x7ffaaf6460c0
    public void Run(){} // RVA: 0x7ffaaf646360
}

public class URPMaterialSwitcher : MonoBehaviour
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932d50
}

public class UTF8Decoder : DecoderNLS
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaade05990
    public void Reset(){} // RVA: 0x7ffaade0c1d0
    public void get_HasState(){} // RVA: 0x7ffaade0c200
}

public class UTF8Encoder : EncoderNLS
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaade07eb0
    public void Reset(){} // RVA: 0x7ffaade0c190
    public void get_HasState(){} // RVA: 0x7ffaade0c1c0
}

public class UTF8EncodingSealed : UTF8Encoding
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaade0c010
    public void get_Preamble(){} // RVA: 0x7ffaade0c090
}

public class UdonProgramScanner : Object
{
    // ── Original Methods ──
    public void Initialize(){} // RVA: 0x7ffaa9961440
    // ── Binary Analysis Named ──
    public void DoGetRoot(){} // RVA: 0x7ffaa9961610
}

public class UiInputField : MonoBehaviour
{
    public object _placeholderText; // 0x3354B8C0
    public object isDate; // 0x3354B8C0
    public object onEndEdit; // 0x3354B8C0
    public object _flag; // 0x3354B8C0, was: ÏÏÌÍÎÍÍÌÏÌÏÌÎÌÌÎÏÎÏÎÌÌÍ
    public object _rScriptAllObsolete; // 0x3354B8C0, was: ÍÎÍÎÌÍÏÌÍÌÍÎÌÌÌÌÏÌÏÏÏÏÌ

    // ── Original Methods ──
    public void Awake(){} // RVA: 0x7ffaa9d09e00
    public void get_source(){} // RVA: 0x7ffaa8f14960
    public void CancelInvoke(){} // RVA: 0x7ffaa8f14960
    public void .ctor(){} // RVA: 0x7ffaa9d0ab50
    public void OnEnable(){} // RVA: 0x7ffaa9d0c390
    public void StopCoroutine(){} // RVA: 0x7ffaa9d0ca40
    public void UpdateActive(){} // RVA: 0x7ffaa9d0d7a0
    public void PressEdit(){} // RVA: 0x7ffaa9d0db60
    public void set_useGUILayout(){} // RVA: 0x7ffaa9ca2c80
    public void get_PointerPose(){} // RVA: 0x7ffaa899d0b0
    public void Internal_CancelInvokeAll(){} // RVA: 0x7ffaa899d0b0
    // ── Binary Analysis Named ──
    public void SetEnabled_D70(){} // RVA: 0x7ffaa9d0a810
    public void SetEnabled_8E6(){} // RVA: 0x7ffaa9d0a820
    public void GetGameObject_98A(){} // RVA: 0x7ffaa9d0ace0
    public void GetGameObject_F98(){} // RVA: 0x7ffaa9d0b6f0
    public void GetIsPlaying_B21(){} // RVA: 0x7ffaa9d0b980
    public void GetGameObject_895(){} // RVA: 0x7ffaa9d0c3c0
    public void GetActiveInHierarchy_49C(){} // RVA: 0x7ffaa9d0c680
    public void GetGameObject_404(){} // RVA: 0x7ffaa9d0cb40
    public void DoGetPitch_65F(){} // RVA: 0x7ffaa9d0d550
}

public class UnboundAnchor : ValueType
{
    // ── Original Methods ──
    public void get_Uuid(){} // RVA: 0x7ffaaa493970
    public void get_Localized(){} // RVA: 0x7ffaae34ce50
    public void get_Localizing(){} // RVA: 0x7ffaae34ced0
    public void get_Pose(){} // RVA: 0x7ffaae34cf60
    public void Localize(){} // RVA: 0x7ffaae34d090
    public void BindTo(){} // RVA: 0x7ffaae34d450
    public void .ctor(){} // RVA: 0x7ffaabb09430
}

public class UnboundedChannelReader : ChannelReader`1
{
    public object _waiterSingleton; // 0x31468390

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void TryRead(){} // RVA: 0x7ffaa864a2a0
    public void WaitToReadAsync(){}
}

public class UnboundedChannelReader : ChannelReader`1
{
    public object _waiterSingleton; // 0x31468530

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void TryRead(){} // RVA: 0x7ffaa864a2a0
    public void CompleteIfDone(){} // RVA: 0x7ffaa8660d50
    public void WaitToReadAsync(){}
}

public class UnboundedChannelReader : ChannelReader`1
{
    public object _waiterSingleton; // 0x3508C748

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac772860
    public void TryRead(){} // RVA: 0x7ffaac772a50
    public void WaitToReadAsync(){} // RVA: 0x7ffaac772b40
}

public class UnboundedChannelWriter : ChannelWriter`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void TryComplete(){} // RVA: 0x7ffaa864a2a0
    public void TryWrite(){} // RVA: 0x7ffaa887e5c0
    public void WaitToWriteAsync(){}
    public void WriteAsync(){} // RVA: 0x7ffaa887e5c0
}

public class UnboundedChannelWriter : ChannelWriter`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660d80
    public void TryComplete(){} // RVA: 0x7ffaa864a2a0
    public void TryWrite(){} // RVA: 0x7ffaa887e5c0
    public void WaitToWriteAsync(){}
    public void WriteAsync(){} // RVA: 0x7ffaa887e5c0
}

public class UnboundedChannelWriter : ChannelWriter`1
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8933e30
    public void TryComplete(){} // RVA: 0x7ffaac775350
    public void TryWrite(){} // RVA: 0x7ffaac775730
    public void WaitToWriteAsync(){} // RVA: 0x7ffaac775c30
    public void WriteAsync(){} // RVA: 0x7ffaac775f30
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

public class UniTaskLoopRunnerLastYieldEarlyUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastYieldFixedUpdate : ValueType
{
}

public class UniTaskLoopRunnerLastYieldInitialization : ValueType
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

public class UniTaskLoopRunnerYieldPreUpdate : ValueType
{
}

public class UnicodeChar : ValueType
{
    public object length; // 0x341DDF00
}

public class Union : ValueType
{
    // ── Original Methods ──
    public void get_m_current(){} // RVA: 0x7ffaaef34230
    public void set_m_current(){} // RVA: 0x7ffaaef34250
    public void get_m_allocCount(){} // RVA: 0x7ffaaef34270
    public void set_m_allocCount(){} // RVA: 0x7ffaaef34280
}

public class UnityEventHandlerAsyncEnumerator : MoveNextSource
{
    public object unityEvent; // 0x314694A0
    public object unityAction; // 0x314694A0
    public object isDisposed; // 0x314694A0
    public object IUniTaskAsyncEnumerable`1; // 0xB40BBB70

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa887e5c0
    public void get_Current(){} // RVA: 0x7ffaa887e5c0
    public void set_Current(){} // RVA: 0x7ffaa887e5c0
    public void MoveNextAsync(){}
    public void Invoke(){} // RVA: 0x7ffaa887e5c0
    public void OnCanceled1(){} // RVA: 0x7ffaa8660d50
    public void OnCanceled2(){} // RVA: 0x7ffaa8660d50
    public void DisposeAsync(){} // RVA: 0x7ffaa8648be0
    public void .cctor(){} // RVA: 0x7ffaa8660cf0
}

public class UnityObjectKeyComparer`1 : Object
{
    // ── Original Methods ──
    public void Compare(){} // RVA: 0x7ffaa887e5c0
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void Get(){} // RVA: 0x7ffaaa1f61e0
}

public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
    // ── Binary Analysis Named ──
    public void Get(){} // RVA: 0x7ffaaf207f50
}

public class UnityWebRequestAsyncOperationAwaiter : ValueType
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa95e1380
    public void get_IsCompleted(){} // RVA: 0x7ffaaeef0cd0
    public void OnCompleted(){} // RVA: 0x7ffaaeef7cc0
    public void UnsafeOnCompleted(){} // RVA: 0x7ffaaeef7cd0
    // ── Binary Analysis Named ──
    public void GetResult(){} // RVA: 0x7ffaaeef7a20
}

public class UnityWebRequestUpdate : ValueType
{
}

public class Unmanaged : ValueType
{
    // ── Original Methods ──
    public void Allocate(){} // RVA: 0x7ffaaef330a0
    public void Free(){} // RVA: 0x7ffaa887e5c0
    public void Free(){} // RVA: 0x7ffaa887e5c0
}

public class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaadf53440
    public void Dispose(){} // RVA: 0x7ffaadf53520
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

public class UpdateFunction : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8990980
    public void Invoke(){} // RVA: 0x7ffaa8990a50
}

public class UpdateGridCellsJob : ValueType
{
    public object collisionPairs; // 0x3510E520

    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaf819760
    public void UpdateRecords(){} // RVA: 0x7ffaaf819970
    public void InsertionSort(){} // RVA: 0x7ffaaf819df0
    public void FindPairs(){} // RVA: 0x7ffaaf819f40
}

public class UpdateHeadingDelegate : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaa236d80
    public void Invoke(){} // RVA: 0x7ffaaa236f00
    public void EndInvoke(){} // RVA: 0x7ffaa9a347f0
    // ── Binary Analysis Named ──
    public void BeginInvoke(){} // RVA: 0x7ffaaa236f40
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

public class UpdateReceivers : ValueType
{
    public object shapes; // 0x350E5A20

    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaf8481e0
}

public class UpdateReceiversFunctions : Object
{
    // ── Original Methods ──
    public void CalcProximity(){} // RVA: 0x7ffaaf848430
    public void CalcProximity$BurstManaged(){} // RVA: 0x7ffaaf8484a0
}

public class UpdateRectTransform : ValueType
{
}

public class UpdateResolution : ValueType
{
}

public class UpdateRootsJob : ValueType
{
    public object fixedTime; // 0x35134E50

    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaf870d40
    public void CalculateShouldUseFixedTime(){} // RVA: 0x7ffaaf870e90
}

public class UpdateShapePositionsJob : ValueType
{
    public object shapeData; // 0x3510D0E0

    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaf820070
    public void .cctor(){} // RVA: 0x7ffaaf820360
    // ── Binary Analysis Named ──
    public void GetTransform(){} // RVA: 0x7ffaaf820320
}

public class UpdateShapesJob : ValueType
{
    public object shapeMap; // 0x3510D750

    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaf813f50
    public void RemoveShape(){} // RVA: 0x7ffaaf8146f0
    public void RemoveShape(){} // RVA: 0x7ffaaf8146f0
    public void AddShape(){} // RVA: 0x7ffaaf8148f0
    public void AddShape(){} // RVA: 0x7ffaaf8148f0
}

public class UpdateShapesJob : ValueType
{
    public object gridMap; // 0x3510E390

    // ── Original Methods ──
    public void Execute(){} // RVA: 0x7ffaaf8182b0
    public void RemoveShape(){} // RVA: 0x7ffaaf818fb0
    public void RemoveShape(){} // RVA: 0x7ffaaf818fb0
    public void AddShape(){} // RVA: 0x7ffaaf819360
    public void AddShape(){} // RVA: 0x7ffaaf819360
}

public class UpdateStatus : Object
{
    public object lastUpdateMode; // 0x34B46040

    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8932310
}

public class UpdateStatus : Object
{
    public object numWindowLateUpdateMoves; // 0x34B4E2A0
    public object lastFrameUpdated; // 0x34B4E2A0

    // ── Original Methods ──
    public void get_PreferredUpdate(){} // RVA: 0x7ffaa8b64610
    public void set_PreferredUpdate(){} // RVA: 0x7ffaaa0f8ad0
    public void .ctor(){} // RVA: 0x7ffaaa259fc0
    public void OnUpdate(){} // RVA: 0x7ffaaa25a050
}

public class UpdateStepCount : ValueType
{
    // ── Original Methods ──
    public void get_value(){} // RVA: 0x7ffaa9e47530
    public void set_value(){} // RVA: 0x7ffaa9e475c0
    public void OnBeforeUpdate(){} // RVA: 0x7ffaaf09f9f0
    public void OnUpdate(){} // RVA: 0x7ffaaf09fa00
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

public class UpdateVideo : ValueType
{
}

public class UpdateVideoTextures : ValueType
{
}

public class UpdatedEventHandler : MulticastDelegate
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8990980
    public void Invoke(){} // RVA: 0x7ffaa8990a50
}

public class UserController : ScriptableObject
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    public void Initialize(){} // RVA: 0x7ffaa9c90450
    public void BackPressed(){} // RVA: 0x7ffaa93e5b70
    // ── Binary Analysis Named ──
    public void GetTransform_74F(){} // RVA: 0x7ffaa9c904f0
    public void GetGameObject_9FC(){} // RVA: 0x7ffaa9c90580
    public void GetGameObject_4CA(){} // RVA: 0x7ffaa9c90590
    public void GetGameObject_21C(){} // RVA: 0x7ffaa9c90620
    public void GetGameObject_C12(){} // RVA: 0x7ffaa9c906a0
    public void GetGameObject_88E(){} // RVA: 0x7ffaa9c90720
    public void GetGameObject_978(){} // RVA: 0x7ffaa9c907c0
    public void GetGameObject_A97(){} // RVA: 0x7ffaa9c90a10
    public void SetActive_448(){} // RVA: 0x7ffaa9c90ab0
}

public class UserDefinedSettings : ValueType
{
    public object mirrorViewMode; // 0x33D32A40
    public object applicationName; // 0x33D32A40
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class UxmlObjectFactory`1 : UxmlObjectFactory`2
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    public object m_Visible; // 0x30BB9A30
    public object m_MaxWidth; // 0x30BB9A30
    public object m_Optional; // 0x30BB9A30
    public object m_CellTemplateId; // 0x30BB9A30

    // ── Original Methods ──
    public void ParseLength(){} // RVA: 0x7ffaa887e5c0
    public void Init(){}
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    public object m_Reorderable; // 0x314915B0
    public object m_Columns; // 0x314915B0
    public object .;

    // ── Original Methods ──
    public void Init(){}
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    public object m_SortDescription; // 0x31491740

    // ── Original Methods ──
    public void Init(){}
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class UxmlObjectTraits`1 : UxmlObjectTraits`1
{
    // ── Original Methods ──
    public void Init(){}
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class UxmlTraits : UxmlTraits
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac8710c0
    public void Init(){} // RVA: 0x7ffaac871240
    public void ParseChoiceList(){} // RVA: 0x7ffaac8713d0
}

public class UxmlTraits : UxmlTraits
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
    public void Init(){}
    public void ParseChoiceList(){} // RVA: 0x7ffaa86492c0
}

public class UxmlTraits : UxmlTraits
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaaf49fd30
    public void Init(){} // RVA: 0x7ffaaf49fe60
}

public class UxmlTraits : UxmlTraits
{
    public object m_PickingMode; // 0x30D435F0
    public object _focusIndex; // 0x30D435F0, was: <focusIndex>k__BackingField
    public object m_Class; // 0x30D435F0
    public object m_PropertyPath; // 0x30D43460

    // ── Original Methods ──
    public void get_focusIndex(){} // RVA: 0x7ffaa89af740
    public void get_focusable(){} // RVA: 0x7ffaa89d30e0
    public void Init(){} // RVA: 0x7ffaaf613340
    public void .ctor(){} // RVA: 0x7ffaaf613620
}

public class UxmlTraits : UxmlTraits
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac8710c0
    public void Init(){} // RVA: 0x7ffaac871240
    public void ParseChoiceList(){} // RVA: 0x7ffaac8713d0
}

public class UxmlTraits : UxmlTraits
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac8710c0
    public void Init(){} // RVA: 0x7ffaac871240
    public void ParseChoiceList(){} // RVA: 0x7ffaac8713d0
}

public class UxmlTraits : UxmlTraits
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaac86df80
    public void Init(){} // RVA: 0x7ffaac86c6f0
    public void ParseChoiceList(){} // RVA: 0x7ffaac86e100
}

public class UxmlTraits : UxmlTraits
{
    // ── Original Methods ──
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}

public class UxmlTraits : BaseFieldTraits`2
{
    public object m_MaskCharacter; // 0x31491BF0
    public object m_HideMobileInput; // 0x31491BF0
    public object m_MaxLength; // 0x839F3F88
    public object m_IsReadOnly; // 0x839F3F88

    // ── Original Methods ──
    public void Init(){}
    public void .ctor(){} // RVA: 0x7ffaa8660cc0
}
