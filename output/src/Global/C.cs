// VRChat IL2CPP Deobfuscated Source
// Namespace: Global
// Classes: 100
// Methods: 659

public class COpenVRContext : Object
{
    public merator m_pVRSystem; // 0x10
    public _23 m_pVRChaperone; // 0x18
    public g m_pVRChaperoneSetup; // 0x20
    public UIntPtr m_pVRCompositor; // 0x28
    public UIntPtr m_pVRHeadsetView; // 0x30
    public NBool m_pVROverlay; // 0x38
    public UIntPtr m_pVROverlayView; // 0x40
    public m m_pVRRenderModels; // 0x48
    public __22 m_pVRExtendedDisplay; // 0x50
    public imeSinceLastVsync m_pVRSettings; // 0x58
    public <get_Children>d__23 m_pVRApplications; // 0x60
    public Vsync m_pVRScreenshots; // 0x68
    public ict m_pVRTrackedCamera; // 0x70
    public etOutputDevice m_pVRInput; // 0x78
    public evice m_pVRIOBuffer; // 0x80
    public layOnDesktop m_pVRSpatialAnchors; // 0x88
    public eadTransform m_pVRNotifications; // 0x90
    public ÏÏÎÎÎÍÌÌÎÎÍÏÌ m_pVRDebug; // 0x98

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54C24810
    public void Clear(){} // RVA: 0x7FFD54C24820
    public void CheckClear(){} // RVA: 0x7FFD54C24E00
    public void VRSystem(){} // RVA: 0x7FFD54C24EC0
    public void VRChaperone(){} // RVA: 0x7FFD54C251B0
    public void VRChaperoneSetup(){} // RVA: 0x7FFD54C25430
    public void VRCompositor(){} // RVA: 0x7FFD54C256F0
    public void VRHeadsetView(){} // RVA: 0x7FFD54C259B0
    public void VROverlay(){} // RVA: 0x7FFD54C25C30
    public void VROverlayView(){} // RVA: 0x7FFD54C25EF0
    public void VRRenderModels(){} // RVA: 0x7FFD54C26160
    public void VRExtendedDisplay(){} // RVA: 0x7FFD54C26420
    public void VRSettings(){} // RVA: 0x7FFD54C26690
    public void VRApplications(){} // RVA: 0x7FFD54C26920
    public void VRScreenshots(){} // RVA: 0x7FFD54C26C00
    public void VRTrackedCamera(){} // RVA: 0x7FFD54C26E80
    public void VRInput(){} // RVA: 0x7FFD54C27110
    public void VRIOBuffer(){} // RVA: 0x7FFD54C273D0
    public void VRSpatialAnchors(){} // RVA: 0x7FFD54C27650
    public void VRDebug(){} // RVA: 0x7FFD54C278D0
    public void VRNotifications(){} // RVA: 0x7FFD54C27B50
}

public class Cache : ValueType
{
    public URA.DateTime<2.uestResetCommand,criptorSizeDeviceCommandType.Wrapping> table; // 0x10

    // ── Methods ──
    public void Clear(){} // RVA: 0x7FFD5496FE20
    public void FindOrLoadLayout(){} // RVA: 0x7FFD5496FE80
}

public class CacheCurve : Object
{
    public float Count; // 0x10
    public float StepSize; // 0x14
    public URA.woDigitYearMax<?> m_Cache; // 0x18

    // ── Methods ──
    public void get_Count(){} // RVA: 0x7FFD4FC701E0
    public void .ctor(){} // RVA: 0x7FFD4FC70230
    public void Add(){} // RVA: 0x7FFD4FC70350
    public void AddUntil(){} // RVA: 0x7FFD4FC70430
    public void Evaluate(){} // RVA: 0x7FFD4FC70730
}

public class CacheEntry : Object
{
    public mActivationTime Curve; // 0x10
    public URA.woDigitYearMax<IsBlending> RawItems; // 0x18

    // ── Methods ──
    public void AddRawItem(){} // RVA: 0x7FFD4FC70B40
    public void CreateCurves(){} // RVA: 0x7FFD4FC70F90
    public void .ctor(){} // RVA: 0x7FFD4FC71450
}

public class CacheRefInstance : ValueType
{
    public bool valid; // 0x10

    // ── Methods ──
    public void Dispose(){} // RVA: 0x7FFD54970000
}

public class Cache`1 : Object
{
    public URA.hEraNames<T1717671808> Comparer;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class CachedCodeEntry : Object
{
    public tiate_pending Next; // 0x10
    public tiate_pending Previous; // 0x18
    public _btls_ssl_set_renegotiate_mode Key; // 0x20
    public tor.ck Code; // 0x38
    public mePatterns.MES_SIZE Caps; // 0x40
    public mePatterns.MES_SIZE Capnames; // 0x48
    public string[] Capslist; // 0x50
    public int Capsize; // 0x58
    public tor.re Runnerref; // 0x60
    public numValuesAndNames<tor.btls_x509_lookup_add_dir> ReplRef; // 0x68

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD547BF9F0
}

public class CachedCodeEntryKey : ValueType
{
    public tor.F_SIGNED_CERT_IN_CHAIN _options; // 0x10
    public string _cultureKey; // 0x18
    public string _pattern; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5264FA80
    public void Equals(){} // RVA: 0x7FFD547BF890 | overloaded x2
    public void op_Equality(){} // RVA: 0x7FFD547BF950
    public void GetHashCode(){} // RVA: 0x7FFD547BF980
}

public class CachedData : Object
{
    public ags Local; // 0x10
    public F5C5AE2947D800794ECD5F752EE8381073C2E5D0D095FDA040F541702F3 _localTimeZone; // 0x18
    public URA.DateTime<string,F5C5AE2947D800794ECD5F752EE8381073C2E5D0D095FDA040F541702F3> _systemTimeZones; // 0x20
    public UnicodeCategory.pacingCombiningMark<F5C5AE2947D800794ECD5F752EE8381073C2E5D0D095FDA040F541702F3> _readOnlySystemTimeZones; // 0x28
    public bool _allSystemTimeZonesRead; // 0x30

    // ── Methods ──
    public void GetCurrentOneYearLocal(){} // RVA: 0x7FFD53922AC0
    public void GetOneYearLocalFromUtc(){} // RVA: 0x7FFD53922C30
    public void CreateLocal(){} // RVA: 0x7FFD53922EF0
    public void get_Local(){} // RVA: 0x7FFD53923180
    public void GetCorrespondingKind(){} // RVA: 0x7FFD539231B0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class CalcProximity_000001C3$BurstDirectCall : Object
{
    public UIntPtr Pointer;
    public UIntPtr DeferredCompilation; // 0x8

    // ── Methods ──
    public void GetFunctionPointerDiscard(){} // RVA: 0x7FFD55246400
    public void GetFunctionPointer(){} // RVA: 0x7FFD55246540
    public void Constructor(){} // RVA: 0x7FFD552466B0
    public void Initialize(){} // RVA: 0x7FFD4E341310
    public void .cctor(){} // RVA: 0x7FFD552466B0
    public void Invoke(){} // RVA: 0x7FFD55246770
}

public class CalcProximity_000001C3$PostfixBurstDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD55246260
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD55246340
    public void EndInvoke(){} // RVA: 0x7FFD4F454000
}

public class CallSiteFormatterContext : ValueType
{
    public URA.onsDepth<numeratorObject.NullAttribute> Offset; // 0x10
    public bool Builder; // 0x18
    public int <Offset>k__BackingField; // 0x1C
    public em.MarkAborted.izeDefaultCase <Builder>k__BackingField; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD537459E0
    public void get_Offset(){} // RVA: 0x7FFD4FDE7520
    public void get_Builder(){} // RVA: 0x7FFD4E35C380
    public void ShouldFormat(){} // RVA: 0x7FFD53745AA0
    public void IncrementOffset(){} // RVA: 0x7FFD53745B10
    public void StartObject(){} // RVA: 0x7FFD53745B50
    public void EndObject(){} // RVA: 0x7FFD53745C20
    public void StartProperty(){} // RVA: 0x7FFD53745C90
    public void StartArrayItem(){} // RVA: 0x7FFD53745D80
    public void WriteProperty(){} // RVA: 0x7FFD53745DC0
    public void StartArray(){} // RVA: 0x7FFD53745EC0
    public void EndArray(){} // RVA: 0x7FFD53745F90
}

public class CallSiteValidatorState : ValueType
{
    public numeratorObject.NullAttribute Singleton; // 0x10

    // ── Methods ──
    public void get_Singleton(){} // RVA: 0x7FFD4EEF9F60
    public void set_Singleton(){} // RVA: 0x7FFD4ECFFE40
}

public class Callback : MulticastDelegate
{
    public sageKind.st callback; // 0x10
    public object state; // 0x18

    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E090A40
    public void BeginInvoke(){} // RVA: 0x7FFD4E08AE80
    public void EndInvoke(){} // RVA: 0x7FFD4E090A40
}

public class CallbackContext : ValueType
{
    public object actionIndex; // 0x10
    public line.? bindingIndex; // 0x18
    public line.riCanonical controlIndex; // 0x20
    public tion.Loop interactionIndex; // 0x28
    public bool phase; // 0x2C

    // ── Methods ──
    public void get_actionIndex(){} // RVA: 0x7FFD4FDE7500
    public void get_bindingIndex(){} // RVA: 0x7FFD5493DDB0
    public void get_controlIndex(){} // RVA: 0x7FFD5493DDE0
    public void get_interactionIndex(){} // RVA: 0x7FFD5493DE20
    public void get_phase(){} // RVA: 0x7FFD5493DE60
    public void get_started(){} // RVA: 0x7FFD5493DE80
    public void get_performed(){} // RVA: 0x7FFD5493DEB0
    public void get_canceled(){} // RVA: 0x7FFD5493DEE0
    public void get_action(){} // RVA: 0x7FFD5493DF10
    public void get_control(){} // RVA: 0x7FFD5493DF40
    public void get_interaction(){} // RVA: 0x7FFD5493DFA0
    public void get_time(){} // RVA: 0x7FFD5493E000
    public void get_startTime(){} // RVA: 0x7FFD5493E020
    public void get_duration(){} // RVA: 0x7FFD5493E040
    public void get_valueType(){} // RVA: 0x7FFD5493E080
    public void get_valueSizeInBytes(){} // RVA: 0x7FFD5493E0E0
    public void ReadValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    public void ReadValueAsButton(){} // RVA: 0x7FFD5493E3C0
    public void ReadValueAsObject(){} // RVA: 0x7FFD5493E5A0
    public void ToString(){} // RVA: 0x7FFD5493E630
}

public class CallbackMsg_t : ValueType
{
}

public class CalloutTarget : ValueType
{
    public 16 Target; // 0x10
    public ePathName117.? TargetButton; // 0x18
}

public class CameraCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E39CB80
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class CameraImageCapture : MonoBehaviour
{
    // ── Methods ──
    public void ImageName(){} // RVA: 0x7FFD56E4FA80
    public void TakePicture(){} // RVA: 0x7FFD56E4FD80
    public void .ctor(){} // RVA: 0x7FFD56E504C0
}

public class CanceledResultSource : Object
{
    public sageKind.TICMAP_SIZE cancellationToken; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E342E30
    public void GetResult(){} // RVA: 0x7FFD548B1410
    public void GetStatus(){} // RVA: 0x7FFD4EA8FE20
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4EA8FE20
    public void OnCompleted(){} // RVA: 0x7FFD5107C990
}

public class CanceledResultSource`1 : Object
{
    public sageKind.TICMAP_SIZE cancellationToken;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090BF0
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(){} // RVA: 0x7FFD4E090B70
    public void GetStatus(){}
    public void UnsafeGetStatus(){} // RVA: 0x7FFD4E079960
    public void OnCompleted(){}
}

public class CanceledUniTaskCache`1 : Object
{
    public eObjectDelegate.kingField<T1717659152> Task;

    // ── Methods ──
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class CancellationTokenDisposable : Object
{
    public sageKind._internal Token;

    // ── Methods ──
    public void get_Token(){} // RVA: 0x7FFD4E2ADC40
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class CanvasInfo : Object
{
    public BuffersImpl mCanvas; // 0x10
    public pad mCanvasComponent; // 0x18
    public EXTERNAL_INDEX_REF_SIG.tance mCanvasParent; // 0x20
    public 16 mViewport; // 0x28
    public ePathName117.ÌÎÌÎÏÏÌÎÏÍÍÌÌÌÏÌÍÎÍÎÌÏ mRawImage; // 0x30

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class Capabilities : ValueType
{
    public ilableSlot type; // 0x10
    public alize_ctrlTouchscreentouch9startPositiony subType; // 0x14
    public nState flags; // 0x18
}

public class Capability : ValueType
{
    public string path; // 0x10
    public string value; // 0x18
}

public class CastInstructionT`1 : CastInstruction
{
    // ── Methods ──
    public void Run(){} // RVA: 0x7FFD4E07E6B0
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class CellRecord : ValueType
{
    public ushort shape; // 0x10
    public lutionZ min; // 0x14
    public lutionZ max; // 0x20
    public bool isCollider; // 0x2C
    public bool isReceiver; // 0x2D
    public x shapeData; // 0x30
}

public class Chain : ValueType
{
    public int rootIndex; // 0x10
    public int boneOffset; // 0x14
    public int boneCount; // 0x18
    public int spanCount; // 0x1C
    public bool hasInitialized; // 0x20
    public object version; // 0x24
    public bool isAnimated; // 0x28
    public object integrationType; // 0x2C
    public egister<riteCharacterUnicode> colliders; // 0x30
    public int grabBone; // 0x48
    public es.ap grabGlobalPosition; // 0x4C
    public float grabMovement; // 0x58
    public float paramStretch; // 0x5C
    public float paramSquish; // 0x60
    public bool grabIkSolved; // 0x64
    public _ElementInitializerMethodStatic limitType; // 0x68
    public es.ap staticFreezeAxis; // 0x6C
    public omponent immobileType; // 0x78
    public ushort shapeId; // 0x7C
    public stments renderBounds; // 0x80
    public stments collisionBounds; // 0x98
    public float paramAngle; // 0xB0
    public nityVectorPositive lastRootParentState; // 0xB4
    public nityVectorPositive lastSceneRootState; // 0xD0

    // ── Methods ──
    public void Init(){} // RVA: 0x7FFD55262AD0
    public void Dispose(){} // RVA: 0x7FFD55262B90
}

public class ChainItemInfo : ValueType
{
    public int Order; // 0x10
    public object ImplementationType; // 0x18

    // ── Methods ──
    public void get_Order(){} // RVA: 0x7FFD4F840210
    public void get_ImplementationType(){} // RVA: 0x7FFD4F840220
    public void .ctor(){} // RVA: 0x7FFD515124C0
}

public class ChainRoot : ValueType
{
    public float fixedTime; // 0x10
    public float realTime; // 0x14
    public bool useFixedTime; // 0x18
    public bool autoEvaluateFixedTime; // 0x19
    public int useFixedTimeCounter; // 0x1C
    public float autoFixedTimeElapsed; // 0x20
    public float autoRealTimeElapsed; // 0x24
    public float prevVelReal; // 0x28
    public float prevVelFixed; // 0x2C
    public es.ap lastPos; // 0x30
    public bool isUsed; // 0x3C
    public float executions; // 0x40
}

public class ChangeTokenRegistration`1 : Object
{
    public ormation<lphaPackingShader.oundHorizontalPadding> _changeTokenProducer;
    public ileFullDirectoryInformation<T1717745616> _changeTokenConsumer;
    public T1717745616 _state;
    public Names _disposable;
    public titlesUGUI<T1717745616> _disposedSentinel;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void OnChangeTokenFired(){} // RVA: 0x7FFD4E090980
    public void RegisterChangeTokenCallback(){} // RVA: 0x7FFD4E090A40
    public void SetDisposable(){} // RVA: 0x7FFD4E090A40
    public void Dispose(){} // RVA: 0x7FFD4E090980
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class ChangeTrackerDisposable : Object
{
    public rectoryInformation<ÏÎÏÍÍÌÏÍÌÌÍÍÌÎÎÎÌÎÌÍÎÌÍ.esolutionInternal,string> _listener; // 0x10
    public ce._KernTable<ÏÎÏÍÍÌÏÍÌÌÍÍÌÎÎÎÌÎÌÍÎÌÍ.esolutionInternal> _monitor; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void OnChange(){} // RVA: 0x7FFD4E2ADC40
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class ChannelTransformer`2 : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class CharacterSubstitution : ValueType
{
    public int index; // 0x10
    public uint unicode; // 0x14

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E7F6D50
}

public class CheckTexFieldInput : ValueType
{
}

public class ChildrenSection`1 : Object
{
    public string ValueToAppear; // 0x10
    public bool SettingComponents; // 0x18
    public ÏÌÏÎÎÌÏÍÎÏÎ[] _settingComponents; // 0x20

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD4E078E90
    public void set_ValueToAppear(){} // RVA: 0x7FFD4E078E90
    public void .ctor(){} // RVA: 0x7FFD4E090980
    public void Initialize(){} // RVA: 0x7FFD4E078E90
    public void get_ValueToAppear(){} // RVA: 0x7FFD4E2ADC40
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD4E078E90
    public void GetCachedPtr(){} // RVA: 0x7FFD4E078E90
    public void get_name(){} // RVA: 0x7FFD4E078E90
    public void set_name(){} // RVA: 0x7FFD4E078E90
    public void set_SettingComponents(){} // RVA: 0x7FFD4E078E90
    public void get_SettingComponents(){} // RVA: 0x7FFD4E078E90
}

public class CinemachineCameraOffset : CinemachineExtension
{
    public amut m_Offset; // 0x30
    public NSIGNED_BYTE m_ApplyAfter; // 0x3C
    public bool m_PreserveComposition; // 0x40

    // ── Methods ──
    public void PostPipelineStageCallback(){} // RVA: 0x7FFD4FC0C020
    public void .ctor(){} // RVA: 0x7FFD4FC0C5C0
}

public class CinemachineMixer : PlayableBehaviour
{
    public WriteString_WithEscape GetMasterPlayableDirector;
    public EXTERNAL_INDEX_REF_SIG.FormatterResolve m_BrainOverrideStack; // 0x10
    public int m_BrainOverrideId; // 0x18
    public bool m_PreviewPlay; // 0x1C

    // ── Methods ──
    public void OnPlayableDestroy(){} // RVA: 0x7FFD4FC0D0A0
    public void PrepareFrame(){} // RVA: 0x7FFD4FC0D100
    public void ProcessFrame(){} // RVA: 0x7FFD4FC0D110
    public void GetDeltaTime(){} // RVA: 0x7FFD4FC0DAF0
    public void .ctor(){} // RVA: 0x7FFD4FC0DC40
}

public class CinemachineRecomposer : CinemachineExtension
{
    public NSIGNED_BYTE m_ApplyAfter; // 0x30
    public float m_Tilt; // 0x34
    public float m_Pan; // 0x38
    public float m_Dutch; // 0x3C
    public float m_ZoomScale; // 0x40
    public float m_FollowAttachment; // 0x44
    public float m_LookAtAttachment; // 0x48

    // ── Methods ──
    public void Reset(){} // RVA: 0x7FFD4FC0C650
    public void OnValidate(){} // RVA: 0x7FFD4FC0C680
    public void PrePipelineMutateCameraStateCallback(){} // RVA: 0x7FFD4FC0C6E0
    public void PostPipelineStageCallback(){} // RVA: 0x7FFD4FC0C700
    public void .ctor(){} // RVA: 0x7FFD4E341D50
}

public class CinemachineShot : PlayableAsset
{
    public string DisplayName; // 0x18
    public bType<EXTERNAL_INDEX_REF_SIG.StaticFieldGetter> VirtualCamera; // 0x20

    // ── Methods ──
    public void CreatePlayable(){} // RVA: 0x7FFD4FC0DC50
    public void GatherProperties(){} // RVA: 0x7FFD4FC0DEB0
    public void .ctor(){} // RVA: 0x7FFD4E54F5F0
}

public class CinemachineShotPlayable : PlayableBehaviour
{
    public EXTERNAL_INDEX_REF_SIG.StaticFieldGetter IsValid; // 0x10

    // ── Methods ──
    public void get_IsValid(){} // RVA: 0x7FFD4FC0E090
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class CinemachineTouchInputMapper : MonoBehaviour
{
    public float TouchSensitivityX; // 0x20
    public float TouchSensitivityY; // 0x24
    public string TouchXInputMapTo; // 0x28
    public string TouchYInputMapTo; // 0x30

    // ── Methods ──
    public void Start(){} // RVA: 0x7FFD4FC0CCD0
    public void GetInputAxis(){} // RVA: 0x7FFD4FC0CDD0
    public void .ctor(){} // RVA: 0x7FFD4FC0CF50
}

public class CinemachineTrack : TrackAsset
{
    // ── Methods ──
    public void CreateTrackMixer(){} // RVA: 0x7FFD4FC0E160
    public void .ctor(){} // RVA: 0x7FFD4FC0E2A0
}

public class ClaimNetworkControlDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4F9D91D0
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD4EEF0620
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class ClearImmediateRenderers : ValueType
{
}

public class ClearIntermediateRenderers : ValueType
{
}

public class ClearLines : ValueType
{
}

public class Clipper : ClipperBase
{
    public int ReverseSolution;
    public int StrictlySimple;
    public int ioPreserveCollinear;
    public xWindowSize m_ClipType; // 0x48
    public ngPath m_Maxima; // 0x50
    public m_OriginalPath m_SortedEdges; // 0x58
    public URA.woDigitYearMax<tionTimePerFrameInSeconds> m_IntersectList; // 0x60
    public URA.ndar_data<tionTimePerFrameInSeconds> m_IntersectNodeComparer; // 0x68
    public bool m_ExecuteLocked; // 0x70
    public peCache m_ClipFillType; // 0x74
    public peCache m_SubjFillType; // 0x78
    public URA.woDigitYearMax<434304727B1C71307D99BC27D059966A854CB749> m_Joins; // 0x80
    public URA.woDigitYearMax<434304727B1C71307D99BC27D059966A854CB749> m_GhostJoins; // 0x88
    public bool m_UsingPolyTree; // 0x90
    public bool <ReverseSolution>k__BackingField; // 0x91
    public bool <StrictlySimple>k__BackingField; // 0x92

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC81750
    public void InsertMaxima(){} // RVA: 0x7FFD4FC81D70
    public void get_ReverseSolution(){} // RVA: 0x7FFD4FC82190
    public void set_ReverseSolution(){} // RVA: 0x7FFD4FC821A0
    public void get_StrictlySimple(){} // RVA: 0x7FFD4F35F160
    public void set_StrictlySimple(){} // RVA: 0x7FFD4FC821B0
    public void Execute(){} // RVA: 0x7FFD4FC823B0 | overloaded x4
    public void FixHoleLinkage(){} // RVA: 0x7FFD4FC82490
    public void ExecuteInternal(){} // RVA: 0x7FFD4FC82530
    public void DisposeAllPolyPts(){} // RVA: 0x7FFD4FC82BE0
    public void AddJoin(){} // RVA: 0x7FFD4FC82D90
    public void AddGhostJoin(){} // RVA: 0x7FFD4FC82EE0
    public void InsertLocalMinimaIntoAEL(){} // RVA: 0x7FFD4FC82FD0
    public void InsertEdgeIntoAEL(){} // RVA: 0x7FFD4FC835F0
    public void E2InsertsBeforeE1(){} // RVA: 0x7FFD4FC839B0
    public void IsEvenOddFillType(){} // RVA: 0x7FFD4FC83AC0
    public void IsEvenOddAltFillType(){} // RVA: 0x7FFD4FC83AF0
    public void IsContributing(){} // RVA: 0x7FFD4FC83B20
    public void SetWindingCount(){} // RVA: 0x7FFD4FC83CC0
    public void AddEdgeToSEL(){} // RVA: 0x7FFD4FC83F00
    public void PopEdgeFromSEL(){} // RVA: 0x7FFD4FC841C0
    public void CopyAELToSEL(){} // RVA: 0x7FFD4FC843D0
    public void SwapPositionsInSEL(){} // RVA: 0x7FFD4FC84500
    public void AddLocalMaxPoly(){} // RVA: 0x7FFD4FC84930
    public void AddLocalMinPoly(){} // RVA: 0x7FFD4FC849F0
    public void AddOutPt(){} // RVA: 0x7FFD4FC84C90
    public void GetLastOutPt(){} // RVA: 0x7FFD4FC850B0
    public void SwapPoints(){} // RVA: 0x7FFD4FC85150
    public void HorzSegmentsOverlap(){} // RVA: 0x7FFD4FC85180
    public void SetHoleState(){} // RVA: 0x7FFD4FC851C0
    public void GetDx(){} // RVA: 0x7FFD4FC85390
    public void FirstIsBottomPt(){} // RVA: 0x7FFD4FC853D0
    public void GetBottomPt(){} // RVA: 0x7FFD4FC85810
    public void GetLowermostRec(){} // RVA: 0x7FFD4FC85930
    public void OutRec1RightOfOutRec2(){} // RVA: 0x7FFD4FC85AB0
    public void GetOutRec(){} // RVA: 0x7FFD4FC85AE0
    public void AppendPolygon(){} // RVA: 0x7FFD4FC85B90
    public void ReversePolyPtLinks(){} // RVA: 0x7FFD4FC86BC0
    public void SwapSides(){} // RVA: 0x7FFD4FC86CC0
    public void SwapPolyIndexes(){} // RVA: 0x7FFD4FC86CF0
    public void IntersectEdges(){} // RVA: 0x7FFD4FC86D20
    public void DeleteFromSEL(){} // RVA: 0x7FFD4FC87340
    public void ProcessHorizontals(){} // RVA: 0x7FFD4FC87560
    public void GetHorzDirection(){} // RVA: 0x7FFD4FC877B0
    public void ProcessHorizontal(){} // RVA: 0x7FFD4FC87810
    public void GetNextInAEL(){} // RVA: 0x7FFD4FC881F0
    public void IsMinima(){} // RVA: 0x7FFD4FC88220
    public void IsMaxima(){} // RVA: 0x7FFD4FC88260
    public void IsIntermediate(){} // RVA: 0x7FFD4FC88290
    public void GetMaximaPair(){} // RVA: 0x7FFD4FC882D0
    public void GetMaximaPairEx(){} // RVA: 0x7FFD4FC88350
    public void ProcessIntersections(){} // RVA: 0x7FFD4FC88410
    public void BuildIntersectList(){} // RVA: 0x7FFD4FC88690
    public void EdgesAdjacent(){} // RVA: 0x7FFD4FC88A60
    public void IntersectNodeSort(){} // RVA: 0x7FFD4FC88AA0
    public void FixupIntersectionOrder(){} // RVA: 0x7FFD4FC88AC0
    public void ProcessIntersectList(){} // RVA: 0x7FFD4FC88E70
    public void Round(){} // RVA: 0x7FFD4FC88FC0
    public void TopX(){} // RVA: 0x7FFD4FC88FF0
    public void IntersectPoint(){} // RVA: 0x7FFD4FC89060
    public void ProcessEdgesAtTopOfScanbeam(){} // RVA: 0x7FFD4FC894C0
    public void DoMaxima(){} // RVA: 0x7FFD4FC89A50
    public void ReversePaths(){} // RVA: 0x7FFD4FC89CB0
    public void Orientation(){} // RVA: 0x7FFD4FC89F30
    public void PointCount(){} // RVA: 0x7FFD4FC89F50
    public void BuildResult(){} // RVA: 0x7FFD4FC89F80
    public void BuildResult2(){} // RVA: 0x7FFD4FC8A1D0
    public void FixupOutPolyline(){} // RVA: 0x7FFD4FC8A560
    public void FixupOutPolygon(){} // RVA: 0x7FFD4FC8A670
    public void DupOutPt(){} // RVA: 0x7FFD4FC8AB70
    public void GetOverlap(){} // RVA: 0x7FFD4FC8AEB0
    public void JoinHorz(){} // RVA: 0x7FFD4FC8AFD0
    public void JoinPoints(){} // RVA: 0x7FFD4FC8B5E0
    public void PointInPolygon(){} // RVA: 0x7FFD4FC8CA10 | overloaded x2
    public void Poly2ContainsPoly1(){} // RVA: 0x7FFD4FC8CB60
    public void FixupFirstLefts1(){} // RVA: 0x7FFD4FC8CCF0
    public void FixupFirstLefts2(){} // RVA: 0x7FFD4FC8CEB0
    public void FixupFirstLefts3(){} // RVA: 0x7FFD4FC8D100
    public void ParseFirstLeft(){} // RVA: 0x7FFD4FC8D2A0
    public void JoinCommonEdges(){} // RVA: 0x7FFD4FC8D2C0
    public void UpdateOutPtIdxs(){} // RVA: 0x7FFD4FC8DC90
    public void DoSimplePolygons(){} // RVA: 0x7FFD4FC8DCC0
    public void Area(){} // RVA: 0x7FFD4FC8E1D0 | overloaded x3
    public void SimplifyPolygon(){} // RVA: 0x7FFD4FC8E240
    public void SimplifyPolygons(){} // RVA: 0x7FFD4FC8E340
    public void DistanceSqrd(){} // RVA: 0x7FFD4FC8E440
    public void DistanceFromLineSqrd(){} // RVA: 0x7FFD4FC8E480
    public void SlopesNearCollinear(){} // RVA: 0x7FFD4FC8E500
    public void PointsAreClose(){} // RVA: 0x7FFD4FC8E730
    public void ExcludeOp(){} // RVA: 0x7FFD4FC8E770
    public void CleanPolygon(){} // RVA: 0x7FFD4FC8E860
    public void CleanPolygons(){} // RVA: 0x7FFD4FC8EEA0
    public void Minkowski(){} // RVA: 0x7FFD4FC8F010
    public void MinkowskiSum(){} // RVA: 0x7FFD4FC8FB80 | overloaded x2
    public void TranslatePath(){} // RVA: 0x7FFD4FC8F9A0
    public void MinkowskiDiff(){} // RVA: 0x7FFD4FC8FDB0
    public void PolyTreeToPaths(){} // RVA: 0x7FFD4FC8FE80
    public void AddPolyNodeToPaths(){} // RVA: 0x7FFD4FC8FF40
    public void OpenPathsFromPolyTree(){} // RVA: 0x7FFD4FC90130
    public void ClosedPathsFromPolyTree(){} // RVA: 0x7FFD4FC902D0
}

public class ClipperBase : Object
{
    public double PreserveCollinear;
    public int Skip;
    public int Unassigned;
    public double tolerance;
    public long loRange;
    public long hiRange;
    public ngShape2D m_MinimaList; // 0x10
    public ngShape2D m_CurrentLM; // 0x18
    public URA.woDigitYearMax<URA.woDigitYearMax<m_OriginalPath>> m_edges; // 0x20
    public stanceAlongPath m_Scanbeam; // 0x28
    public URA.woDigitYearMax<SetCartPosition> m_PolyOuts; // 0x30
    public m_OriginalPath m_ActiveEdges; // 0x38
    public bool m_UseFullRange; // 0x40
    public bool m_HasOpenPaths; // 0x41
    public bool <PreserveCollinear>k__BackingField; // 0x42

    // ── Methods ──
    public void near_zero(){} // RVA: 0x7FFD4FC7CBE0
    public void get_PreserveCollinear(){} // RVA: 0x7FFD4E5F90A0
    public void set_PreserveCollinear(){} // RVA: 0x7FFD4E5F9200
    public void Swap(){} // RVA: 0x7FFD4FC7CC00
    public void IsHorizontal(){} // RVA: 0x7FFD4FC7CC10
    public void PointIsVertex(){} // RVA: 0x7FFD4FC7CC30
    public void PointOnLineSegment(){} // RVA: 0x7FFD4FC7CC80
    public void PointOnPolygon(){} // RVA: 0x7FFD4FC7CE40
    public void SlopesEqual(){} // RVA: 0x7FFD4FC7D2F0 | overloaded x3
    public void .ctor(){} // RVA: 0x7FFD4FC7D440
    public void Clear(){} // RVA: 0x7FFD4FC7D5B0
    public void DisposeLocalMinimaList(){} // RVA: 0x7FFD4FC7D8A0
    public void RangeTest(){} // RVA: 0x7FFD4FC7D9E0
    public void InitEdge(){} // RVA: 0x7FFD4FC7DAC0
    public void InitEdge2(){} // RVA: 0x7FFD4FC7DBA0
    public void FindNextLocMin(){} // RVA: 0x7FFD4FC7DC50
    public void ProcessBound(){} // RVA: 0x7FFD4FC7DD60
    public void AddPath(){} // RVA: 0x7FFD4FC7E430
    public void AddPaths(){} // RVA: 0x7FFD4FC7F860
    public void Pt2IsBetweenPt1AndPt3(){} // RVA: 0x7FFD4FC7F950
    public void RemoveEdge(){} // RVA: 0x7FFD4FC7F9D0
    public void SetDx(){} // RVA: 0x7FFD4FC7FB20
    public void InsertLocalMinima(){} // RVA: 0x7FFD4FC7FB80
    public void PopLocalMinima(){} // RVA: 0x7FFD4FC7FDA0
    public void ReverseHorizontal(){} // RVA: 0x7FFD4FC7FE90
    public void Reset(){} // RVA: 0x7FFD4FC7FEC0
    public void GetBounds(){} // RVA: 0x7FFD4FC80330
    public void InsertScanbeam(){} // RVA: 0x7FFD4FC807B0
    public void PopScanbeam(){} // RVA: 0x7FFD4FC80AB0
    public void LocalMinimaPending(){} // RVA: 0x7FFD4FC80B40
    public void CreateOutRec(){} // RVA: 0x7FFD4FC80B50
    public void DisposeOutRec(){} // RVA: 0x7FFD4FC80D80
    public void UpdateEdgeIntoAEL(){} // RVA: 0x7FFD4FC80E90
    public void SwapPositionsInAEL(){} // RVA: 0x7FFD4FC81270
    public void DeleteFromAEL(){} // RVA: 0x7FFD4FC81530
}

public class ClipperException : Exception
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC94CE0
}

public class ClipperOffset : Object
{
    public URA.woDigitYearMax<URA.woDigitYearMax<lfFrustumHeight>> ArcTolerance; // 0x10
    public URA.woDigitYearMax<lfFrustumHeight> MiterLimit; // 0x18
    public URA.woDigitYearMax<lfFrustumHeight> m_destPoly; // 0x20
    public URA.woDigitYearMax<ingShape2DCache> m_normals; // 0x28
    public double m_delta; // 0x30
    public double m_sinA; // 0x38
    public double m_sin; // 0x40
    public double m_cos; // 0x48
    public double m_miterLim; // 0x50
    public double m_StepsPerRad; // 0x58
    public lfFrustumHeight m_lowest; // 0x60
    public hCache m_polyNodes; // 0x70
    public double <ArcTolerance>k__BackingField; // 0x78
    public double <MiterLimit>k__BackingField; // 0x80
    public double two_pi;
    public double def_arc_tolerance;

    // ── Methods ──
    public void get_ArcTolerance(){} // RVA: 0x7FFD4FC90390
    public void set_ArcTolerance(){} // RVA: 0x7FFD4FC903A0
    public void get_MiterLimit(){} // RVA: 0x7FFD4FC903B0
    public void set_MiterLimit(){} // RVA: 0x7FFD4FC903C0
    public void .ctor(){} // RVA: 0x7FFD4FC903D0
    public void Clear(){} // RVA: 0x7FFD4FC90550
    public void Round(){} // RVA: 0x7FFD4FC88FC0
    public void AddPath(){} // RVA: 0x7FFD4FC905D0
    public void AddPaths(){} // RVA: 0x7FFD4FC90C60
    public void FixOrientations(){} // RVA: 0x7FFD4FC90DD0
    public void GetUnitNormal(){} // RVA: 0x7FFD4FC91050
    public void DoOffset(){} // RVA: 0x7FFD4FC91150
    public void Execute(){} // RVA: 0x7FFD4FC92CA0 | overloaded x2
    public void OffsetPoint(){} // RVA: 0x7FFD4FC933E0
    public void DoSquare(){} // RVA: 0x7FFD4FC93E00
    public void DoMiter(){} // RVA: 0x7FFD4FC94440
    public void DoRound(){} // RVA: 0x7FFD4FC94700
}

public class Codec : Object
{
    public gBox.PathNoRoll<T1717702000> KeyCodec;
    public gBox.PathNoRoll<T1717702016> ValueCodec;
    public uint MapTag;

    // ── Methods ──
    public void .ctor(){}
    public void get_KeyCodec(){} // RVA: 0x7FFD4E078E90
    public void get_ValueCodec(){} // RVA: 0x7FFD4E078E90
    public void get_MapTag(){} // RVA: 0x7FFD4E079960
}

public class Collection : ValueType
{
    public float kBaseScoreForNonGeneratedLayouts;
    public URA.DateTime<2.uestResetCommand,?> layoutTypes; // 0x10
    public URA.DateTime<2.uestResetCommand,string> layoutStrings; // 0x18
    public URA.DateTime<2.uestResetCommand,ormation<criptorSizeDeviceCommandType.Wrapping>> layoutBuilders; // 0x20
    public URA.DateTime<2.uestResetCommand,2.uestResetCommand> baseLayoutTable; // 0x28
    public URA.DateTime<2.uestResetCommand,2.uestResetCommand[]> layoutOverrides; // 0x30
    public URA.onsDepth<2.uestResetCommand> layoutOverrideNames; // 0x38
    public URA.DateTime<2.uestResetCommand,FlareRelease> precompiledLayouts; // 0x40
    public URA.woDigitYearMax<ommunications> layoutMatchers; // 0x48

    // ── Methods ──
    public void Allocate(){} // RVA: 0x7FFD54AB4AD0
    public void TryFindLayoutForType(){} // RVA: 0x7FFD54AB5150
    public void TryFindMatchingLayout(){} // RVA: 0x7FFD54AB5350
    public void HasLayout(){} // RVA: 0x7FFD54AB5600
    public void TryLoadLayoutInternal(){} // RVA: 0x7FFD54AB5730
    public void TryLoadLayout(){} // RVA: 0x7FFD54AB5E50
    public void GetBaseLayoutName(){} // RVA: 0x7FFD54AB6520
    public void GetRootLayoutName(){} // RVA: 0x7FFD54AB6640
    public void ComputeDistanceInInheritanceHierarchy(){} // RVA: 0x7FFD54AB6780
    public void FindLayoutThatIntroducesControl(){} // RVA: 0x7FFD54AB6890
    public void GetControlTypeForLayout(){} // RVA: 0x7FFD54AB6B50
    public void ValueTypeIsAssignableFrom(){} // RVA: 0x7FFD54AB6E20
    public void IsGeneratedLayout(){} // RVA: 0x7FFD54AB6F30
    public void GetBaseLayouts(){} // RVA: 0x7FFD54AB6FB0
    public void IsBasedOn(){} // RVA: 0x7FFD54AB7110
    public void AddMatcher(){} // RVA: 0x7FFD54AB7260
}

public class CollectionHeaderTypeInfo`2 : HeaderTypeInfo`2
{
    public int Separator;
    public string separator;
    public CheckingState.?<T1717726160> parser;

    // ── Methods ──
    public void .ctor(){}
    public void get_Separator(){} // RVA: 0x7FFD4E078E90
    public void TryParse(){} // RVA: 0x7FFD4E07D200
}

public class Collider : ValueType
{
    public int shapeId; // 0x10
    public bool hasUpdated; // 0x14
    public es.ap prevPos0; // 0x18
    public es.ap prevPos1; // 0x24
    public es.ap nextPos0; // 0x30
    public es.ap nextPos1; // 0x3C
    public cationCallback shapeType; // 0x48
    public es.ap pos0; // 0x4C
    public es.ap pos1; // 0x58
    public float radius; // 0x64
    public bool insideBounds; // 0x68
    public bool bonesAsSpheres; // 0x69

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5526E710
    public void Lerp(){} // RVA: 0x7FFD5526E840
}

public class ColliderToRemoveData : ValueType
{
    public ÍÏÎÎÌÍÍ.ns comp; // 0x10
    public int executionGroup; // 0x18
    public gSmoothFactor shape; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD55263C20
}

public class CollisionEnterDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5106D540
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD4EEF0620
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class CollisionEvent : ValueType
{
    public bool found; // 0x10
    public int receiver; // 0x14
    public int collider; // 0x18
}

public class CollisionEventsJob : ValueType
{
    public ÍÎÏÎÎ.AssignProgramAndVariables<?> prevCollisionPairs; // 0x10
    public ÍÎÏÎÎ.ateUpdateProfilerMarker<oom> collisionEvents; // 0x18
    public ÍÎÏÎÎ.AssignProgramAndVariables<onfigOptions> gridCells; // 0x20

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFD55217950
}

public class CollisionExitDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD5106D540
    public void Invoke(){} // RVA: 0x7FFD4E49D370
    public void BeginInvoke(){} // RVA: 0x7FFD4EEF0620
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class CollisionModule : ValueType
{
    public InDuration enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D6D1D0
    public void set_enabled(){} // RVA: 0x7FFD54D6D220
    public void get_type(){} // RVA: 0x7FFD54D6D280
    public void set_type(){} // RVA: 0x7FFD54D6D2D0
    public void get_mode(){} // RVA: 0x7FFD54D6D330
    public void set_mode(){} // RVA: 0x7FFD54D6D380
    public void get_dampen(){} // RVA: 0x7FFD54D6D3E0
    public void set_dampen(){} // RVA: 0x7FFD54D6D450
    public void get_dampenMultiplier(){} // RVA: 0x7FFD54D6D4B0
    public void set_dampenMultiplier(){} // RVA: 0x7FFD54D6D500
    public void get_bounce(){} // RVA: 0x7FFD54D6D560
    public void set_bounce(){} // RVA: 0x7FFD54D6D5D0
    public void get_bounceMultiplier(){} // RVA: 0x7FFD54D6D630
    public void set_bounceMultiplier(){} // RVA: 0x7FFD54D6D680
    public void get_lifetimeLoss(){} // RVA: 0x7FFD54D6D6E0
    public void set_lifetimeLoss(){} // RVA: 0x7FFD54D6D750
    public void get_lifetimeLossMultiplier(){} // RVA: 0x7FFD54D6D7B0
    public void set_lifetimeLossMultiplier(){} // RVA: 0x7FFD54D6D800
    public void get_minKillSpeed(){} // RVA: 0x7FFD54D6D860
    public void set_minKillSpeed(){} // RVA: 0x7FFD54D6D8B0
    public void get_maxKillSpeed(){} // RVA: 0x7FFD54D6D910
    public void set_maxKillSpeed(){} // RVA: 0x7FFD54D6D960
    public void get_collidesWith(){} // RVA: 0x7FFD54D6D9C0
    public void set_collidesWith(){} // RVA: 0x7FFD54D6DA20
    public void get_enableDynamicColliders(){} // RVA: 0x7FFD54D6DA80
    public void set_enableDynamicColliders(){} // RVA: 0x7FFD54D6DAD0
    public void get_maxCollisionShapes(){} // RVA: 0x7FFD54D6DB30
    public void set_maxCollisionShapes(){} // RVA: 0x7FFD54D6DB80
    public void get_quality(){} // RVA: 0x7FFD54D6DBE0
    public void set_quality(){} // RVA: 0x7FFD54D6DC30
    public void get_voxelSize(){} // RVA: 0x7FFD54D6DC90
    public void set_voxelSize(){} // RVA: 0x7FFD54D6DCE0
    public void get_radiusScale(){} // RVA: 0x7FFD54D6DD40
    public void set_radiusScale(){} // RVA: 0x7FFD54D6DD90
    public void get_sendCollisionMessages(){} // RVA: 0x7FFD54D6DDF0
    public void set_sendCollisionMessages(){} // RVA: 0x7FFD54D6DE40
    public void get_colliderForce(){} // RVA: 0x7FFD54D6DEA0
    public void set_colliderForce(){} // RVA: 0x7FFD54D6DEF0
    public void get_multiplyColliderForceByCollisionAngle(){} // RVA: 0x7FFD54D6DF50
    public void set_multiplyColliderForceByCollisionAngle(){} // RVA: 0x7FFD54D6DFA0
    public void get_multiplyColliderForceByParticleSpeed(){} // RVA: 0x7FFD54D6E000
    public void set_multiplyColliderForceByParticleSpeed(){} // RVA: 0x7FFD54D6E050
    public void get_multiplyColliderForceByParticleSize(){} // RVA: 0x7FFD54D6E0B0
    public void set_multiplyColliderForceByParticleSize(){} // RVA: 0x7FFD54D6E100
    public void AddPlane(){} // RVA: 0x7FFD54D6E160
    public void RemovePlane(){} // RVA: 0x7FFD54D6E220 | overloaded x2
    public void RemovePlaneObject(){} // RVA: 0x7FFD54D6E220
    public void SetPlane(){} // RVA: 0x7FFD54D6E280
    public void GetPlane(){} // RVA: 0x7FFD54D6E2F0
    public void get_planeCount(){} // RVA: 0x7FFD54D6E350
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D6D1D0
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D6D220
    public void get_type_Injected(){} // RVA: 0x7FFD54D6D280
    public void set_type_Injected(){} // RVA: 0x7FFD54D6D2D0
    public void get_mode_Injected(){} // RVA: 0x7FFD54D6D330
    public void set_mode_Injected(){} // RVA: 0x7FFD54D6D380
    public void get_dampen_Injected(){} // RVA: 0x7FFD54D6E3A0
    public void set_dampen_Injected(){} // RVA: 0x7FFD54D6E400
    public void get_dampenMultiplier_Injected(){} // RVA: 0x7FFD54D6D4B0
    public void set_dampenMultiplier_Injected(){} // RVA: 0x7FFD54D6D500
    public void get_bounce_Injected(){} // RVA: 0x7FFD54D6E460
    public void set_bounce_Injected(){} // RVA: 0x7FFD54D6E4C0
    public void get_bounceMultiplier_Injected(){} // RVA: 0x7FFD54D6D630
    public void set_bounceMultiplier_Injected(){} // RVA: 0x7FFD54D6D680
    public void get_lifetimeLoss_Injected(){} // RVA: 0x7FFD54D6E520
    public void set_lifetimeLoss_Injected(){} // RVA: 0x7FFD54D6E580
    public void get_lifetimeLossMultiplier_Injected(){} // RVA: 0x7FFD54D6D7B0
    public void set_lifetimeLossMultiplier_Injected(){} // RVA: 0x7FFD54D6D800
    public void get_minKillSpeed_Injected(){} // RVA: 0x7FFD54D6D860
    public void set_minKillSpeed_Injected(){} // RVA: 0x7FFD54D6D8B0
    public void get_maxKillSpeed_Injected(){} // RVA: 0x7FFD54D6D910
    public void set_maxKillSpeed_Injected(){} // RVA: 0x7FFD54D6D960
    public void get_collidesWith_Injected(){} // RVA: 0x7FFD54D6E5E0
    public void set_collidesWith_Injected(){} // RVA: 0x7FFD54D6E640
    public void get_enableDynamicColliders_Injected(){} // RVA: 0x7FFD54D6DA80
    public void set_enableDynamicColliders_Injected(){} // RVA: 0x7FFD54D6DAD0
    public void get_maxCollisionShapes_Injected(){} // RVA: 0x7FFD54D6DB30
    public void set_maxCollisionShapes_Injected(){} // RVA: 0x7FFD54D6DB80
    public void get_quality_Injected(){} // RVA: 0x7FFD54D6DBE0
    public void set_quality_Injected(){} // RVA: 0x7FFD54D6DC30
    public void get_voxelSize_Injected(){} // RVA: 0x7FFD54D6DC90
    public void set_voxelSize_Injected(){} // RVA: 0x7FFD54D6DCE0
    public void get_radiusScale_Injected(){} // RVA: 0x7FFD54D6DD40
    public void set_radiusScale_Injected(){} // RVA: 0x7FFD54D6DD90
    public void get_sendCollisionMessages_Injected(){} // RVA: 0x7FFD54D6DDF0
    public void set_sendCollisionMessages_Injected(){} // RVA: 0x7FFD54D6DE40
    public void get_colliderForce_Injected(){} // RVA: 0x7FFD54D6DEA0
    public void set_colliderForce_Injected(){} // RVA: 0x7FFD54D6DEF0
    public void get_multiplyColliderForceByCollisionAngle_Injected(){} // RVA: 0x7FFD54D6DF50
    public void set_multiplyColliderForceByCollisionAngle_Injected(){} // RVA: 0x7FFD54D6DFA0
    public void get_multiplyColliderForceByParticleSpeed_Injected(){} // RVA: 0x7FFD54D6E000
    public void set_multiplyColliderForceByParticleSpeed_Injected(){} // RVA: 0x7FFD54D6E050
    public void get_multiplyColliderForceByParticleSize_Injected(){} // RVA: 0x7FFD54D6E0B0
    public void set_multiplyColliderForceByParticleSize_Injected(){} // RVA: 0x7FFD54D6E100
    public void AddPlane_Injected(){} // RVA: 0x7FFD54D6E160
    public void RemovePlane_Injected(){} // RVA: 0x7FFD54D6E1C0
    public void RemovePlaneObject_Injected(){} // RVA: 0x7FFD54D6E220
    public void SetPlane_Injected(){} // RVA: 0x7FFD54D6E280
    public void GetPlane_Injected(){} // RVA: 0x7FFD54D6E2F0
    public void get_planeCount_Injected(){} // RVA: 0x7FFD54D6E350
}

public class CollisionRecord : ValueType
{
    public gSmoothFactor shape; // 0x10
    public ÍÏÎÎÌÍÍ.leSlant trigger; // 0x18
    public ÍÏÎÎÌÍÍ.9287EE6327F8A74D0617C5 triggerProxy; // 0x20
    public ÍÏÎÎÌÍÍ.5DD51EECC0A8037DAFB1A52F12E04CC696BF57AAC1449C527105 receiverProxy; // 0x28
}

public class CollisionsJob : ValueType
{
    public ÍÎÏÎÎ.ateUpdateEvent<lutionZ,int> shapeMap; // 0x10
    public ÍÎÏÎÎ.AssignProgramAndVariables<ushort> activeShapes; // 0x20
    public ÍÎÏÎÎ.ÌÌ<?> shapeData; // 0x28
    public ÍÎÏÎÎ.ÌÌ<int> collisions; // 0x38
    public kingField<oom> collisionEvents; // 0x48

    // ── Methods ──
    public void Execute(){} // RVA: 0x7FFD55211F50
    public void GetCollision(){} // RVA: 0x7FFD55212D90
    public void SetCollision(){} // RVA: 0x7FFD55212DB0
    public void FindCollision(){} // RVA: 0x7FFD55212DD0
}

public class Color32Surrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFD5749B720
    public void SetObjectData(){} // RVA: 0x7FFD5749B840
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ColorBySpeedModule : ValueType
{
    public InDuration enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D75990
    public void set_enabled(){} // RVA: 0x7FFD54D759E0
    public void get_color(){} // RVA: 0x7FFD54D75A40
    public void set_color(){} // RVA: 0x7FFD54D75AC0
    public void get_range(){} // RVA: 0x7FFD54D75B20
    public void set_range(){} // RVA: 0x7FFD54D75B80
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D75990
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D759E0
    public void get_color_Injected(){} // RVA: 0x7FFD54D75BE0
    public void set_color_Injected(){} // RVA: 0x7FFD54D75C40
    public void get_range_Injected(){} // RVA: 0x7FFD54D75CA0
    public void set_range_Injected(){} // RVA: 0x7FFD54D75D00
}

public class ColorOverLifetimeModule : ValueType
{
    public InDuration enabled; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4ECFFE40
    public void get_enabled(){} // RVA: 0x7FFD54D75740
    public void set_enabled(){} // RVA: 0x7FFD54D75790
    public void get_color(){} // RVA: 0x7FFD54D757F0
    public void set_color(){} // RVA: 0x7FFD54D75870
    public void get_enabled_Injected(){} // RVA: 0x7FFD54D75740
    public void set_enabled_Injected(){} // RVA: 0x7FFD54D75790
    public void get_color_Injected(){} // RVA: 0x7FFD54D758D0
    public void set_color_Injected(){} // RVA: 0x7FFD54D75930
}

public class ColorPaletteData : Object
{
    public string name; // 0x10
    public string id; // 0x18
    public string highlights; // 0x20
    public string icons; // 0x28
    public string buttons; // 0x30
    public string backgrounds; // 0x38
    public string text; // 0x40
    public string subtext; // 0x48

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ColorSurrogate : Object
{
    // ── Methods ──
    public void GetObjectData(){} // RVA: 0x7FFD5749B4A0
    public void SetObjectData(){} // RVA: 0x7FFD5749B5C0
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class Comparers : Object
{
    public ose<T1717730672,T1717730688> KeyComparer;
    public URA.hEraNames<T1717730672> KeyOnlyComparer;
    public URA.hEraNames<T1717730688> ValueComparer;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E099B30
    public void get_KeyComparer(){} // RVA: 0x7FFD4E078E90
    public void get_KeyOnlyComparer(){} // RVA: 0x7FFD4E078E90
    public void get_ValueComparer(){} // RVA: 0x7FFD4E078E90
    public void Equals(){} // RVA: 0x7FFD4E2ADC40
    public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Equals(){} // RVA: 0x7FFD4E2ADC40
    public void System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetHashCode(){} // RVA: 0x7FFD4E2ADC40
    public void Get(){} // RVA: 0x7FFD4E078FF0
    public void .cctor(){} // RVA: 0x7FFD4E0909B0
}

public class CompleteOnInvokePromise : Task`1
{
    public URA.?<utes.Line> InvokeMayRunArbitraryCode; // 0x58

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD537EABF0
    public void Invoke(){} // RVA: 0x7FFD537EAD10
    public void get_InvokeMayRunArbitraryCode(){} // RVA: 0x7FFD4E426850
}

public class ConfigurationListDebugView : Object
{
    public ngCommas.Index<T1717649472> Items;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void get_Items(){} // RVA: 0x7FFD4E078E90
}

public class ConfiguredTaskAwaiter : ValueType
{
    public utes.?<utes.Line> IsCompleted; // 0x10
    public bool m_continueOnCapturedContext; // 0x18

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E096500
    public void get_IsCompleted(){} // RVA: 0x7FFD4E079D00
    public void OnCompleted(){} // RVA: 0x7FFD4E090A40
    public void UnsafeOnCompleted(){} // RVA: 0x7FFD4E090A40
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
}

public class ConfiguredValueTaskAwaiter : ValueType
{
    public utes.xitAttributeMode<bool> IsCompleted; // 0x10

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E2ADC40
    public void get_IsCompleted(){} // RVA: 0x7FFD4E079D00
    public void GetResult(){} // RVA: 0x7FFD4E2ADC40
    public void OnCompleted(){} // RVA: 0x7FFD4E090A40
    public void UnsafeOnCompleted(){} // RVA: 0x7FFD4E090A40
}

public class ConnectDisposable : Object
{
    public sageKind._internal cancellationTokenSource;

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E090A40
    public void Dispose(){} // RVA: 0x7FFD4E090980
}

public class ConstraintManagerUpdate : ValueType
{
}

public class ConstraintSourceData : ValueType
{
    public int SourceIndex; // 0x10
    public bool SourceExists; // 0x14
    public float Weight; // 0x18
    public es.ap ParentPositionOffset; // 0x1C
    public es.ap ParentRotationOffset; // 0x28
}

public class ContactEventDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD51477520
    public void Invoke(){} // RVA: 0x7FFD5106DBE0
}

public class ContainerHeight : Object
{
    public object Height; // 0x10
    public object _containerBottom; // 0x18

    // ── Methods ──
    public void GetInstanceID(){} // RVA: 0x7FFD56A1C000
    public void Equals(){} // RVA: 0x7FFD56A1C000
    public void GetHashCode(){} // RVA: 0x7FFD56A1C000
    public void .ctor(){} // RVA: 0x7FFD4E341310
    public void Initialize(){} // RVA: 0x7FFD56A1C000
    public void IsNativeObjectAlive(){} // RVA: 0x7FFD56A1C000
    public void set_Height(){} // RVA: 0x7FFD56A1C000
    public void get_Height(){} // RVA: 0x7FFD56A1C000
}

public class Content : ValueType
{
    public bool IsAvailable; // 0x10
    public itTypeSize=876 DisplayName; // 0x18
    public bool DisplayPrice; // 0x40
    public itTypeSize=876 Price; // 0x48
    public bool IsFavoritable; // 0x70
    public bool IsFavorited; // 0x71
    public bool IsWearing; // 0x72
    public bool IsLocal; // 0x73
    public bool CanTryOn; // 0x74
    public bool ShowHeight; // 0x75
    public itTypeSize=876 Height; // 0x78
    public bool ShowDisplayName; // 0xA0
    public bool ShowImpostorToggle; // 0xA1
    public bool ShowPrimaryButton; // 0xA2
    public bool ShowFunctionButtons; // 0xA3
    public bool ImpostorSelected; // 0xA4
    public itTypeSize=876 PrimaryButtonText; // 0xA8
    public itTypeSize=876 DetailsButtonTooltip; // 0xD0
    public itTypeSize=876 TryOnButtonTooltip; // 0xF8
    public itTypeSize=876 FavButtonTooltip; // 0x120
}

public class ContentHeightCacheInfo : ValueType
{
    public float sum;
    public int count;

    // ── Methods ──
    public void .ctor(){}
}

public class ContentSectionElementSet : ValueType
{
    public owAlias contentListUiBinding; // 0x10
    public BuffersImpl contentListHeaderContainer; // 0x18
    public ÍÏÎÍÌÍÌÎÌÏÌÍÏÍÌÏÎÎÎÎÏÏ contentListHeaderLabel; // 0x20
    public BuffersImpl trailingSeparator; // 0x28
}

public class Context : ValueType
{
    public 0.gManifestResourceException Option; // 0x10
    public IntPtr NeverMatchFlags; // 0x18
    public IntPtr AlwaysMatchFlags; // 0x20
    public IntPtr Buffer1; // 0x28
    public IntPtr Buffer2; // 0x30
    public int PrevCode; // 0x38
    public IntPtr PrevSortKey; // 0x40

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD537BB2E0
}

public class ContingentProperties : Object
{
    public sageKind.d m_capturedContext; // 0x10
    public sageKind.e m_completionEvent; // 0x18
    public utes.rce m_exceptionsHolder; // 0x20
    public sageKind.TICMAP_SIZE m_cancellationToken; // 0x28
    public object m_cancellationRegistration; // 0x30
    public int m_internalCancellationRequested; // 0x38
    public int m_completionCountdown; // 0x3C
    public URA.jriYear<utes.Line> m_exceptionalChildren; // 0x40

    // ── Methods ──
    public void SetCompleted(){} // RVA: 0x7FFD53B06980
    public void UnregisterCancellationCallback(){} // RVA: 0x7FFD53B069B0
    public void .ctor(){} // RVA: 0x7FFD53B06AA0
}

public class ContinuationWrapper : Object
{
    public ÎÌÍÏÏÌÍÏ m_continuation; // 0x10
    public ÎÌÍÏÏÌÍÏ m_invokeAction; // 0x18
    public utes.Line m_innerTask; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD538FF550
    public void Invoke(){} // RVA: 0x7FFD51ABD470
}

public class Control : Object
{
    public string name; // 0x10
    public ector icon; // 0x18
    public Ì type; // 0x20
    public e parameter; // 0x28
    public float value; // 0x30
    public Property style; // 0x34
    public terfaces.IUdonVariable.Value.VariableType subMenu; // 0x38
    public e[] subParameters; // 0x40
    public ?[] labels; // 0x48

    // ── Methods ──
    public void GetSubParameter(){} // RVA: 0x7FFD57434E30
    public void GetLabel(){} // RVA: 0x7FFD57434E70
    public void .ctor(){} // RVA: 0x7FFD4F2ADE70
}

public class ControlBitRangeNode : ValueType
{
    public ushort endBitOffset; // 0x10
    public short leftChildIndex; // 0x12
    public ushort controlStartIndex; // 0x14
    public byte controlCount; // 0x16

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD549B44E0
}

public class ControlBuilder : ValueType
{
    public ilAddress.ressedThisFrame control; // 0x10

    // ── Methods ──
    public void get_control(){} // RVA: 0x7FFD4EEF9F60
    public void set_control(){} // RVA: 0x7FFD4ECFFE40
    public void At(){} // RVA: 0x7FFD549A9560
    public void WithParent(){} // RVA: 0x7FFD549A9640
    public void WithName(){} // RVA: 0x7FFD549A96B0
    public void WithDisplayName(){} // RVA: 0x7FFD549A9750
    public void WithShortDisplayName(){} // RVA: 0x7FFD549A9830
    public void WithLayout(){} // RVA: 0x7FFD549A9910
    public void WithUsages(){} // RVA: 0x7FFD549A9980
    public void WithAliases(){} // RVA: 0x7FFD549A99B0
    public void WithChildren(){} // RVA: 0x7FFD549A99E0
    public void WithStateBlock(){} // RVA: 0x7FFD549A9A10
    public void WithDefaultState(){} // RVA: 0x7FFD549A9A40
    public void WithMinAndMax(){} // RVA: 0x7FFD549A9A80
    public void WithProcessor(){} // RVA: 0x7FFD4E2ADC40
    public void IsNoisy(){} // RVA: 0x7FFD549A9AC0
    public void IsSynthetic(){} // RVA: 0x7FFD549A9AF0
    public void DontReset(){} // RVA: 0x7FFD549A9B30
    public void IsButton(){} // RVA: 0x7FFD549A9B90
    public void Finish(){} // RVA: 0x7FFD549A9BD0
}

public class ControlDataForExport : Object
{
    public Ì eyeControl; // 0x10
    public object eyelidBoneMode; // 0x14
    public string leftEyePath; // 0x18
    public string rightEyePath; // 0x20
    public float maxEyeUpBoneAngle; // 0x28
    public float maxEyeDownBoneAngle; // 0x2C
    public float maxEyeUpEyeballAngle; // 0x30
    public float maxEyeDownEyeballAngle; // 0x34
    public bool isEyeBallDefaultSet; // 0x38
    public bool isEyeBoneDefaultSet; // 0x39
    public bool isEyeBallLookUpSet; // 0x3A
    public bool isEyeBoneLookUpSet; // 0x3B
    public bool isEyeBallLookDownSet; // 0x3C
    public bool isEyeBoneLookDownSet; // 0x3D
    public object leftBoneEyeRotationLimiter; // 0x40
    public object rightBoneEyeRotationLimiter; // 0x48
    public object leftEyeballEyeRotationLimiter; // 0x50
    public object rightEyeballEyeRotationLimiter; // 0x58
    public ÍÏÏ eyelidControl; // 0x60
    public bool eyelidsFollowEyesVertically; // 0x64
    public string upperEyeLidLeftPath; // 0x68
    public string upperEyeLidRightPath; // 0x70
    public string lowerEyeLidLeftPath; // 0x78
    public string lowerEyeLidRightPath; // 0x80
    public bool isEyelidBonesDefaultSet; // 0x88
    public bool isEyelidBonesClosedSet; // 0x89
    public bool isEyelidBonesLookUpSet; // 0x8A
    public bool isEyelidBonesLookDownSet; // 0x8B
    public ÌÍÎÍÎÍÌÌÍÎÎÌÎÏÏÎÌÌÍÎÏÏ upperLeftLimiter; // 0x90
    public ÌÍÎÍÎÍÌÌÍÎÎÌÎÏÏÎÌÌÍÎÏÏ upperRightLimiter; // 0x98
    public ÌÍÎÍÎÍÌÌÍÎÎÌÎÏÏÎÌÌÍÎÏÏ lowerLeftLimiter; // 0xA0
    public ÌÍÎÍÎÍÌÌÍÎÎÌÎÏÏÎÌÌÍÎÏÏ lowerRightLimiter; // 0xA8
    public float eyeWidenOrSquint; // 0xB0
    public ?[] blendshapesForBlinking; // 0xB8
    public ?[] blendshapesForLookingUp; // 0xC0
    public ?[] blendshapesForLookingDown; // 0xC8
    public ?[] blendshapesConfigs; // 0xD0
    public bool isEyelidBlendshapeDefaultSet; // 0xD8
    public bool isEyelidBlendshapeClosedSet; // 0xD9
    public bool isEyelidBlendshapeLookUpSet; // 0xDA
    public bool isEyelidBlendshapeLookDownSet; // 0xDB

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class ControlItem : ValueType
{
    public 2.uestResetCommand name; // 0x10
    public 2.uestResetCommand layout; // 0x20
    public 2.uestResetCommand variants; // 0x30
    public string useStateFrom; // 0x40
    public string displayName; // 0x48
    public string shortDisplayName; // 0x50
    public 2.ntReadPos<2.uestResetCommand> usages; // 0x58
    public 2.ntReadPos<2.uestResetCommand> aliases; // 0x68
    public 2.ntReadPos<2.sOrphanedPrimaryTouch> parameters; // 0x78
    public 2.ntReadPos<2.se> processors; // 0x88
    public uint offset; // 0x98
    public uint bit; // 0x9C
    public uint sizeInBits; // 0xA0
    public 2.Code format; // 0xA4
    public tf32 flags; // 0xA8
    public int arraySize; // 0xAC
    public 2.me defaultState; // 0xB0
    public 2.me minValue; // 0xC0
    public 2.me maxValue; // 0xD0

    // ── Methods ──
    public void get_name(){} // RVA: 0x7FFD4E6E0590
    public void set_name(){} // RVA: 0x7FFD4FEC1C40
    public void get_layout(){} // RVA: 0x7FFD4F842E80
    public void set_layout(){} // RVA: 0x7FFD4FEBB120
    public void get_variants(){} // RVA: 0x7FFD4FE39630
    public void set_variants(){} // RVA: 0x7FFD4FE39640
    public void get_useStateFrom(){} // RVA: 0x7FFD4E5F95E0
    public void set_useStateFrom(){} // RVA: 0x7FFD4E36F890
    public void get_displayName(){} // RVA: 0x7FFD4E5F0140
    public void set_displayName(){} // RVA: 0x7FFD4E5F0C20
    public void get_shortDisplayName(){} // RVA: 0x7FFD4E3BE740
    public void set_shortDisplayName(){} // RVA: 0x7FFD4E369200
    public void get_usages(){} // RVA: 0x7FFD4FE9F120
    public void set_usages(){} // RVA: 0x7FFD54AAF350
    public void get_aliases(){} // RVA: 0x7FFD4EFEB4D0
    public void set_aliases(){} // RVA: 0x7FFD54AAF3B0
    public void get_parameters(){} // RVA: 0x7FFD513F87B0
    public void set_parameters(){} // RVA: 0x7FFD513F87C0
    public void get_processors(){} // RVA: 0x7FFD53E53E20
    public void set_processors(){} // RVA: 0x7FFD54AAF410
    public void get_offset(){} // RVA: 0x7FFD4EC0E8C0
    public void set_offset(){} // RVA: 0x7FFD4EC19DE0
    public void get_bit(){} // RVA: 0x7FFD51376E80
    public void set_bit(){} // RVA: 0x7FFD519C0990
    public void get_sizeInBits(){} // RVA: 0x7FFD4E640660
    public void set_sizeInBits(){} // RVA: 0x7FFD4E8F2750
    public void get_format(){} // RVA: 0x7FFD4E640670
    public void set_format(){} // RVA: 0x7FFD4E84B670
    public void get_flags(){} // RVA: 0x7FFD4FCBE530
    public void set_flags(){} // RVA: 0x7FFD4FCBE540
    public void get_arraySize(){} // RVA: 0x7FFD4FCBE520
    public void set_arraySize(){} // RVA: 0x7FFD4FCBEAA0
    public void get_defaultState(){} // RVA: 0x7FFD53CE7180
    public void set_defaultState(){} // RVA: 0x7FFD53CE7190
    public void get_minValue(){} // RVA: 0x7FFD4EAB5970
    public void set_minValue(){} // RVA: 0x7FFD4EAB3CA0
    public void get_maxValue(){} // RVA: 0x7FFD53F6E0D0
    public void set_maxValue(){} // RVA: 0x7FFD53F6E0E0
    public void get_isModifyingExistingControl(){} // RVA: 0x7FFD54AAF470
    public void set_isModifyingExistingControl(){} // RVA: 0x7FFD54AAF480
    public void get_isNoisy(){} // RVA: 0x7FFD54AAF4A0
    public void set_isNoisy(){} // RVA: 0x7FFD54AAF4B0
    public void get_isSynthetic(){} // RVA: 0x7FFD54AAF4D0
    public void set_isSynthetic(){} // RVA: 0x7FFD54AAF4E0
    public void get_dontReset(){} // RVA: 0x7FFD54AAF500
    public void set_dontReset(){} // RVA: 0x7FFD54AAF510
    public void get_isFirstDefinedInThisLayout(){} // RVA: 0x7FFD54AAF530
    public void set_isFirstDefinedInThisLayout(){} // RVA: 0x7FFD54AAF540
    public void get_isArray(){} // RVA: 0x7FFD54AAF560
    public void Merge(){} // RVA: 0x7FFD54AAF570
}

public class ControlItemJson : Object
{
    public string name; // 0x10
    public string layout; // 0x18
    public string variants; // 0x20
    public string usage; // 0x28
    public string alias; // 0x30
    public string useStateFrom; // 0x38
    public uint offset; // 0x40
    public uint bit; // 0x44
    public uint sizeInBits; // 0x48
    public string format; // 0x50
    public int arraySize; // 0x58
    public string[] usages; // 0x60
    public string[] aliases; // 0x68
    public string parameters; // 0x70
    public string processors; // 0x78
    public string displayName; // 0x80
    public string shortDisplayName; // 0x88
    public bool noisy; // 0x90
    public bool dontReset; // 0x91
    public bool synthetic; // 0x92
    public string defaultState; // 0x98
    public string minValue; // 0xA0
    public string maxValue; // 0xA8

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54AB3060
    public void ToLayout(){} // RVA: 0x7FFD54AB3070
    public void FromControlItems(){} // RVA: 0x7FFD54AB3E50
}

public class ControlSchemeSyntax : ValueType
{
    public ilAddress.adLength m_Asset; // 0x10
    public int m_ControlSchemeIndex; // 0x18
    public ilAddress.cceleration m_ControlScheme; // 0x20

    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD54961DC0 | overloaded x2
    public void WithBindingGroup(){} // RVA: 0x7FFD54961E90
    public void WithRequiredDevice(){} // RVA: 0x7FFD54962090 | overloaded x2
    public void WithOptionalDevice(){} // RVA: 0x7FFD549620E0 | overloaded x2
    public void OrWithRequiredDevice(){} // RVA: 0x7FFD54962130 | overloaded x2
    public void OrWithOptionalDevice(){} // RVA: 0x7FFD54962180 | overloaded x2
    public void DeviceTypeToControlPath(){} // RVA: 0x7FFD4E078E90
    public void Done(){} // RVA: 0x7FFD549621D0
    public void AddDeviceEntry(){} // RVA: 0x7FFD54962300
}

public class CounterItem : Object
{
    public int Value;

    // ── Methods ──
    public void get_Value(){} // RVA: 0x7FFD4E079960
    public void Add(){} // RVA: 0x7FFD4E090ED0
    public void Increment(){} // RVA: 0x7FFD4E090980
    public void ReadAndReset(){} // RVA: 0x7FFD4E079960
    public void .ctor(){} // RVA: 0x7FFD4E090980
}

public class CreatePipelineDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC2CDD0
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD4F040DC0
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class CreateRigDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4FC2CDD0
    public void Invoke(){} // RVA: 0x7FFD4E49D4E0
    public void BeginInvoke(){} // RVA: 0x7FFD4F040DC0
    public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
}

public class CreateRuntimePanelDelegate : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD510D2620
    public void Invoke(){} // RVA: 0x7FFD4E39CC60
}

public class CreateValueCallback : MulticastDelegate
{
    // ── Methods ──
    public void .ctor(){}
    public void Invoke(){} // RVA: 0x7FFD4E2ADC40
}

public class CredentialsBundle : Object
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD4E341310
}

public class CullStateChangedEvent : UnityEvent`1
{
    // ── Methods ──
    public void .ctor(){} // RVA: 0x7FFD55074E80
}

public class CustomBlend : ValueType
{
    public string m_From; // 0x10
    public string m_To; // 0x18
    public EXTERNAL_INDEX_REF_SIG.racter m_Blend; // 0x20
}
