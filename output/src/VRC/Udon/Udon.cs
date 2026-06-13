// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon
// Classes: 34
// Methods: 833

namespace VRC.Udon
{
    public class AbstractSerializedUdonProgramAsset
    {
        // ── Methods ──
        public void StoreProgram(){} // RVA: 0x2DC60 | overloaded x2
        public void RetrieveProgram(){} // RVA: 0xCD60
        public void GetSerializedProgramSize(){} // RVA: 0xCD60
        public void GetNetworkCallingMetadata(){} // RVA: 0xCE10 | overloaded x2
        public void TryGetEntrypointNameFromHash(){}
        public void TryGetEntrypointHashFromName(){} // RVA: 0x11120
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class AbstractUdonBehaviourEventProxy
    {
        public VRC.Udon.UdonBehaviour <EventReceiver>k__BackingField; // 0x20

        // ── Methods ──
        public void get_EventReceiver(){} // RVA: 0x30B0C0
        public void set_EventReceiver(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class AbstractUdonProgramSource
    {
        // ── Methods ──
        public void get_SerializedProgramAsset(){} // RVA: 0xCD60
        public void RunEditorUpdate(){} // RVA: 0x2DC60
        public void RefreshProgram(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class IUdonTriggerEventConsumer
    {
        // ── Methods ──
        public void get_Priority(){} // RVA: 0xD840
        public void TryConsumeOnTriggerEnter(){} // RVA: 0x11120
        public void TryConsumeOnTriggerExit(){} // RVA: 0x11120
        public void TryConsumeOnTriggerStay(){} // RVA: 0x11120
    }

    public class OnAnimatorMoveProxy
    {
        // ── Methods ──
        public void OnAnimatorMove(){} // RVA: 0x76FF180
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class OnAudioFilterReadProxy
    {
        // ── Methods ──
        public void OnAudioFilterRead(){} // RVA: 0x76FF1E0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class OnCollisionStayProxy
    {
        // ── Methods ──
        public void OnCollisionStay(){} // RVA: 0x76FF3C0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class OnRenderObjectProxy
    {
        // ── Methods ──
        public void OnRenderObject(){} // RVA: 0x76FF3E0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class OnTriggerStayProxy
    {
        // ── Methods ──
        public void OnTriggerStay(){} // RVA: 0x76FF440
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class OnWillRenderObjectProxy
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x76FF460
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class UdonAlwaysDenyVerifier : {>
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class UdonBehaviour : `
    {
        public VRC.Udon.Common.Interfaces.IUdonVariableTable publicVariables; // 0x40
        public bool SynchronizePosition; // 0x48
        public bool SynchronizeAnimation; // 0x49
        public bool AllowCollisionOwnershipTransfer; // 0x4A
        public bool Reliable; // 0x4B
        public 0x6596EF00 _syncMethod; // 0x4C
        public VRC.Udon.AbstractSerializedUdonProgramAsset serializedProgramAsset; // 0x50
        public System.Action`2<VRC.Udon.UdonBehaviour,VRC.Udon.Common.Interfaces.IUdonProgram> <OnInit>k__BackingField;
        public System.Action`1<VRC.Udon.UdonBehaviour> <RequestSerializationHook>k__BackingField; // 0x8
        public bool <DisableInteractive>k__BackingField; // 0x58
        public string ReturnVariableName;
        public bool <DisableEventProcessing>k__BackingField; // 0x59
        public int _componentIndexFixed; // 0x5C
        public VRC.Udon.UdonManager _udonManager; // 0x60
        public VRC.Udon.Common.Interfaces.IUdonProgram _program; // 0x68
        public VRC.Udon.Common.Interfaces.IUdonVM _udonVM; // 0x70
        public bool _isReady; // 0x78

        // ── Methods ──
        public void get_SyncMethod(){} // RVA: 0x76FF4C0
        public void set_SyncMethod(){} // RVA: 0x76FF4E0
        public void get_HasDoneStart(){} // RVA: 0x134A680
        public void get_HasError(){} // RVA: 0x1342AB0
        public void get_SyncIsContinuous(){} // RVA: 0x76FF860
        public void get_SyncIsManual(){} // RVA: 0x76FF890
        public void get_OnInit(){} // RVA: 0x76FF8C0
        public void set_OnInit(){} // RVA: 0x76FF920
        public void get_RequestSerializationHook(){} // RVA: 0x76FF9D0
        public void set_RequestSerializationHook(){} // RVA: 0x76FFA30
        public void get_DisableInteractive(){} // RVA: 0x59FF30
        public void set_DisableInteractive(){} // RVA: 0xC5F680
        public void get_IsNetworkingSupported(){} // RVA: 0x632C260
        public void set_IsNetworkingSupported(){} // RVA: 0x76FFAF0
        public void get_IsInteractive(){} // RVA: 0x76FFB60
        public void get_UpdateOrder(){} // RVA: 0x76FFBA0
        public void get_DisableEventProcessing(){} // RVA: 0x4FE4B90
        public void set_DisableEventProcessing(){} // RVA: 0x601E3A0
        public void get_ProgramId(){} // RVA: 0x76FFC00
        public void get_ProgramSize(){} // RVA: 0x76FFCF0
        public void GetNetworkCallingMetadata(){} // RVA: 0x76FFEF0 | overloaded x2
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7700000
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7700160
        public void get_IsInitialized(){} // RVA: 0x632C250
        public void GetComponentIndexFixed(){} // RVA: 0x7700280
        public void LoadProgram(){} // RVA: 0x77002E0
        public void RegisterEventProxy(){} // RVA: 0x24A50
        public void ProcessEntryPoints(){} // RVA: 0x77008C0
        public void DetectExistingProxies(){} // RVA: 0x77014D0
        public void ResolveUdonHeapReferences(){} // RVA: 0x77017C0
        public void ResolveUdonHeapReference(){} // RVA: 0x7701B10
        public void ManagedUpdate(){} // RVA: 0x7701EE0
        public void ManagedLateUpdate(){} // RVA: 0x7702090
        public void ManagedFixedUpdate(){} // RVA: 0x77021B0
        public void PostLateUpdate(){} // RVA: 0x77022D0
        public void OnAnimatorIK(){} // RVA: 0x77023F0
        public void ProxyOnAnimatorMove(){} // RVA: 0x7702540
        public void ProxyOnAudioFilterRead(){} // RVA: 0x7702590
        public void OnBecameInvisible(){} // RVA: 0x7702760
        public void OnBecameVisible(){} // RVA: 0x77027B0
        public void OnCollisionEnter(){} // RVA: 0x7702800
        public void OnCollisionEnter2D(){} // RVA: 0x7702A70
        public void OnCollisionExit(){} // RVA: 0x7702C70
        public void OnCollisionExit2D(){} // RVA: 0x7702EE0
        public void ProxyOnCollisionStay(){} // RVA: 0x77030E0
        public void OnCollisionStay2D(){} // RVA: 0x7703350
        public void OnDestroy(){} // RVA: 0x7703550
        public void OnDisable(){} // RVA: 0x7703B50
        public void OnDrawGizmos(){} // RVA: 0x7703BB0
        public void OnDrawGizmosSelected(){} // RVA: 0x7703C00
        public void OnEnable(){} // RVA: 0x7703C50
        public void OnJointBreak(){} // RVA: 0x7703CB0
        public void OnJointBreak2D(){} // RVA: 0x7703E30
        public void OnMouseDown(){} // RVA: 0x7703F50
        public void OnMouseDrag(){} // RVA: 0x7703FA0
        public void OnMouseEnter(){} // RVA: 0x7703FF0
        public void OnMouseExit(){} // RVA: 0x7704040
        public void OnMouseOver(){} // RVA: 0x7704090
        public void OnMouseUp(){} // RVA: 0x77040E0
        public void OnMouseUpAsButton(){} // RVA: 0x7704130
        public void OnParticleCollision(){} // RVA: 0x7704180
        public void OnParticleTrigger(){} // RVA: 0x7704350
        public void OnPostRender(){} // RVA: 0x77043A0
        public void OnPreCull(){} // RVA: 0x77043F0
        public void OnPreRender(){} // RVA: 0x7704440
        public void OnRenderImage(){} // RVA: 0x7704490
        public void ProxyOnRenderObject(){} // RVA: 0x7704700
        public void OnTransformChildrenChanged(){} // RVA: 0x7704750
        public void OnTransformParentChanged(){} // RVA: 0x77047A0
        public void OnTriggerEnter(){} // RVA: 0x77047F0
        public void OnTriggerEnter2D(){} // RVA: 0x7704BE0
        public void OnTriggerExit(){} // RVA: 0x7704DE0
        public void OnTriggerExit2D(){} // RVA: 0x77051D0
        public void ProxyOnTriggerStay(){} // RVA: 0x77053D0
        public void OnTriggerStay2D(){} // RVA: 0x77057C0
        public void OnControllerColliderHit(){} // RVA: 0x77059C0
        public void OnValidate(){} // RVA: 0x7705E50
        public void ProxyOnWillRenderObject(){} // RVA: 0x7705EA0
        public void OnNetworkReady(){} // RVA: 0x4F29AB0
        public void Interact(){} // RVA: 0x7705EF0
        public void OnDrop(){} // RVA: 0x7705F40
        public void OnPickup(){} // RVA: 0x7705F90
        public void OnPickupUseDown(){} // RVA: 0x7705FE0
        public void OnPickupUseUp(){} // RVA: 0x7706030
        public void OnPreSerialization(){} // RVA: 0x7706080
        public void OnPostSerialization(){} // RVA: 0x7706210
        public void OnDeserialization(){} // RVA: 0x77064A0
        public void RunProgram(){} // RVA: 0x7706830 | overloaded x2
        public void GetPrograms(){} // RVA: 0x7706E20
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7706EE0
        public void DeserializePublicVariables(){} // RVA: 0x7706EF0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7707370
        public void SerializePublicVariables(){} // RVA: 0x7707370
        public void TryToInterrogateUdon(){} // RVA: 0x283FA0 | overloaded x2
        public void RunEvent(){} // RVA: 0x65F230 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x77077C0 | overloaded x10
        public void RunInputEvent(){} // RVA: 0x7707B00
        public void GetEventParameterName(){} // RVA: 0x7707DA0
        public void PreloadUdonProgram(){} // RVA: 0x7708090
        public void SearchUdonInterface(){} // RVA: 0x283FA0
        public void InitializeUdonContent(){} // RVA: 0x77082F0
        public void RunOnInit(){} // RVA: 0x7708B80
        public void RegisterUpdate(){} // RVA: 0x7708D30
        public void UnregisterUpdate(){} // RVA: 0x77093C0
        public void SendCustomEvent(){} // RVA: 0x77098E0
        public void SendCustomNetworkEvent(){} // RVA: 0x7709D60 | overloaded x9
        public void RequestSerialization(){} // RVA: 0x7709DF0
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7709EA0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x770A020
        public void get_InteractionText(){} // RVA: 0x30B130
        public void set_InteractionText(){} // RVA: 0x2DEE90
        public void get_SyncMetadataTable(){} // RVA: 0x770A1B0
        public void GetProgramVariableType(){} // RVA: 0x770A210
        public void SetProgramVariable(){} // RVA: 0x770A320 | overloaded x2
        public void SetHeapVariable(){} // RVA: 0x283FA0
        public void GetProgramVariable(){} // RVA: 0x770A460 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x770A5C0 | overloaded x2
        public void SetupLogging(){} // RVA: 0x770A7F0
        public void AssignProgramAndVariables(){} // RVA: 0x770A930
        public void .ctor(){} // RVA: 0x770A9E0
        public void .cctor(){} // RVA: 0x770ADF0
    }

    /// <summary>Originally: ÍÍÌÍÍÍÍÌÏÌÏÎÌÌÍÏÌÏÌÏÌÏÌ</summary>
    public class UdonBehaviourResultBytes_CF3F_6FF8
    {
        public float ÏÎÍÌÏÎÎÏÍÌÍÌÌÍÎÎÍÏÏÏÏÏÎ;
        public int ÎÎÎÏÌÎÍÎÎÏÏÎÏÎÌÎÏÎÍÏÎÌÎ;
        public float ÍÌÏÏÌÌÍÏÌÌÍÌÍÏÏÌÌÌÌÏÏÍÎ;
        public System.Threading.CancellationTokenSource ÍÏÌÎÌÎÏÍÌÎÌÍÌÏÍÏÎÌÏÌÍÎÎ; // 0x10
        public string ÌÌÏÌÍÎÎÏÌÎÏÏÌÎÌÏÌÍÍÏÍÎÏ; // 0x18
        public byte[] <ÌÌÍÎÏÎÌÌÏÎÌÌÎÏÏÏÎÏÏÌÏÌÍ>k__BackingField; // 0x20

        // ── Methods ──
        public void get_UdonBehaviour(){} // RVA: 0x35A740
        public void get_Result(){} // RVA: 0x6570B0
        public void set_Result(){} // RVA: 0x30B0D0
        public void set_Error(){} // RVA: 0x49B830
        public void get_Error(){} // RVA: 0x30B130
        public void get_ResultBytes(){} // RVA: 0x30B0C0
        public void set_ResultBytes(){} // RVA: 0x338CE0
        public void RefreshUdonBehaviourResultBytes(){} // RVA: 0x30B130
        public void set_Url(){} // RVA: 0x338CD0
        public void set_controlPathInternal(){} // RVA: 0x305200
        public void HandleUdonBehaviourResultBytes(){} // RVA: 0x49B830
        public void .ctor(){} // RVA: 0x657160
        public void get_Url(){} // RVA: 0x4976A0
        public void set_ErrorCode(){} // RVA: 0x6572D0
        public void GetUdonBehaviourResultBytes(){} // RVA: 0x338CE0
        public void get_ErrorCode(){} // RVA: 0x338CD0
        public void CancelDownload(){} // RVA: 0x6574F0
        public void set_ErrorCode_AAB5870B7AE6(){} // RVA: 0x2DEE90
        public void set_ErrorCode_EE06E0422BED(){} // RVA: 0x30B130
        public void set_ErrorCode_985A7F61E844(){} // RVA: 0x30B130
        public void StartDownload(){} // RVA: 0x657560
        public void SetNetworkIDCollection(){} // RVA: 0x338CD0
    }

    /// <summary>Originally: ÏÏÌÌÏÌÎÏÎÎÍÍÎÍÍÌÍÌÌÏÏÎÌ</summary>
    public class UdonClientImageDownloaderSibling_5F31
    {
        public System.Text.RegularExpressions.Regex ÍÏÏÏÌÏÏÍÏÎÍÎÍÍÍÎÏÏÍÍÎÏÍ;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x4CFEB0
        public void .ctor(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x4D15E0
        // ── Unresolved (hash) ──
        public void m_FFA(){} // RVA: 0x4CF540
        public void m_BFD(){} // RVA: 0x4CF680
        public void m_D99(){} // RVA: 0x4CF700
        public void m_485(){} // RVA: 0x4D02D0
        public void m_70B(){} // RVA: 0x4D0A80
        public void m_FB0(){} // RVA: 0x4D0B00
        public void m_909(){} // RVA: 0x4D1290
        public void m_2F5(){} // RVA: 0x4D1380
    }

    /// <summary>Originally: ÎÎÏÌÎÍÏÌÍÍÌÍÎÍÏÎÌÎÍÌÎÎÌ</summary>
    public class UdonDisableEventProcessing_A521_6832
    {
        public bool <ÍÍÍÎÏÎÏÎÏÌÎÌÏÍÌÎÎÎÍÎÏÎÎ>k__BackingField; // 0x40
        public bool <ÌÏÍÏÎÎÏÌÏÍÎÎÏÎÎÎÏÍÍÏÎÏÌ>k__BackingField; // 0x41
        public bool <ÌÍÏÎÍÏÎÌÍÏÎÏÎÌÌÎÍÏÌÏÏÎÎ>k__BackingField; // 0x42
        public string <ÌÎÌÏÍÌÍÌÍÍÏÏÎÏÎÌÎÌÌÍÏÏÏ>k__BackingField; // 0x48
        public 0x6596EF00 <ÏÌÏÍÍÎÏÌÍÍÌÌÏÎÎÏÍÌÌÏÍÏÎ>k__BackingField; // 0x50
        public VRC.SDK3.UdonNetworkCalling.NetworkCallingEntrypointMetadata[] <ÍÍÏÍÎÍÎÍÏÍÌÏÌÍÍÌÏÌÌÌÏÎÍ>k__BackingField; // 0x58
        public System.Collections.Generic.Dictionary`2<uint,string> ÏÏÎÌÎÍÌÏÎÍÏÍÎÏÍÏÎÍÏÍÎÏÍ; // 0x60
        public System.Collections.Generic.Dictionary`2<string,uint> ÏÎÍÍÎÍÌÍÍÏÍÏÍÍÎÎÏÍÎÎÏÏÌ; // 0x68

        // ── Methods ──
        public void RunEvent(){} // RVA: 0x65F230 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x283FA0 | overloaded x10
        public void RunEventAdvanced_2A16DDE426F5(){} // RVA: 0x65EBE0
        public void SetProgramVariable(){} // RVA: 0x283FA0 | overloaded x2
        public void InitializeUdonContent(){} // RVA: 0x2DD310
        public void RequestSerialization(){} // RVA: 0x2DD310
        public void get_DisableEventProcessing_5D87A84FE7D9(){} // RVA: 0x3A5500
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x65ED40
        public void SetProgramVariable_76251B84F0A7(){} // RVA: 0x3A5510
        public void SendCustomNetworkEvent(){} // RVA: 0x65F820 | overloaded x9
        public void GetComponentIndexFixed(){} // RVA: 0x65EE40
        public void GetProgramVariable(){} // RVA: 0x65F8E0 | overloaded x2
        public void GetNetworkCallingMetadata(){} // RVA: 0x65F100 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x65F610 | overloaded x2
        public void set_DisableEventProcessing(){} // RVA: 0x65EEB0
        public void get_DisableEventProcessing(){} // RVA: 0x65EEC0
        public void SendCustomEvent(){} // RVA: 0x65EED0
        public void get_SyncMethod(){} // RVA: 0x59C540
        public void GetIsNetworkingSupported(){} // RVA: 0x4C34F0
        public void RunProgram(){} // RVA: 0x65EF50
        public void set_DisableEventProcessing_5EA3EFCC727F(){} // RVA: 0x3A5510
        public void RunInputEvent(){} // RVA: 0x65F010
        public void TryGetEntrypointHashFromName(){} // RVA: 0x65F050
        public void SendCustomEventDelayedFrames(){} // RVA: 0x65F0C0
        public void set_IsNetworkingSupported(){} // RVA: 0x65F1B0
        public void RunEvent_449EFEA13D0E(){} // RVA: 0x3A5510
        public void Interact(){} // RVA: 0x2DD310
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x65F1C0
        public void RunEvent_586E1D4321A6(){} // RVA: 0x4C34F0
        public void get_DisableInteractive(){} // RVA: 0x398C00
        public void set_InteractionText_F9C1D4480780(){} // RVA: 0x4C7C50
        public void .ctor(){} // RVA: 0x65F320
        public void get_InteractionText(){} // RVA: 0x358730
        public void get_IsNetworkingSupported(){} // RVA: 0x65F560
        public void set_SyncMethod(){} // RVA: 0x65F570
        public void set_InteractionText(){} // RVA: 0x358740
        public void DoThrowUInt16OverflowException(){} // RVA: 0x65F750
        public void set_DisableInteractive(){} // RVA: 0x398C10
        public void set_SyncMetadataTable(){} // RVA: 0x3A5500
        public void get_SyncMetadataTable(){} // RVA: 0x65F8A0
        public void GetProgramVariableType(){} // RVA: 0x65F960
    }

    public class UdonManager : (00
    {
        public System.Action`1<VRC.Udon.Common.Interfaces.IUdonProgram> OnUdonProgramLoaded;
        public System.Action OnUdonReady; // 0x8
        public VRC.Udon.UdonBehaviour currentlyExecuting; // 0x20
        public bool <HasLoaded>k__BackingField; // 0x28
        public VRC.Udon.UdonManager _instance; // 0x10
        public UpdateOrderComparer _udonBehaviourUpdateOrderComparer; // 0x18
        public bool _isUdonEnabled; // 0x29
        public bool _isRunningEvent; // 0x2A
        public System.Collections.Generic.Dictionary`2<UnityEngine.SceneManagement.Scene,System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,System.Collections.Generic.HashSet`1<...>>> _sceneUdonBehaviourDirectories; // 0x30

        // ── Methods ──
        public void add_OnUdonProgramLoaded(){} // RVA: 0x770B0E0
        public void remove_OnUdonProgramLoaded(){} // RVA: 0x770B240
        public void add_OnUdonReady(){} // RVA: 0x770B3A0
        public void remove_OnUdonReady(){} // RVA: 0x770B4F0
        public void get_HasLoaded(){} // RVA: 0x6E8A80
        public void set_HasLoaded(){} // RVA: 0x6E8B80
        public void get_Instance(){} // RVA: 0x770B640
        public void get_SignatureVerificationFailed(){} // RVA: 0xA002A0
        public void get_SignatureVerificationSuccess(){} // RVA: 0x1884A40
        public void get_SignatureVerificationSkipped(){} // RVA: 0xA50BB0
        public void get_WorldSignatureVerificationEnabled(){} // RVA: 0x1C919F0
        public void set_WorldSignatureVerificationEnabled(){} // RVA: 0x1C91A00
        public void ResetWorldSignatureVerification(){} // RVA: 0x770B6A0
        public void EnableWorldSignatureVerification(){} // RVA: 0x770B710
        public void RegisterTriggerEventConsumer(){} // RVA: 0x770B7D0
        public void UnregisterTriggerEventConsumer(){} // RVA: 0x770B9F0
        public void TryNotifyOnTriggerEnterConsumers(){} // RVA: 0x770BA60
        public void TryNotifyOnTriggerExitConsumers(){} // RVA: 0x770BC00
        public void TryNotifyOnTriggerStayConsumers(){} // RVA: 0x770BDA0
        public void Awake(){} // RVA: 0x770BF40
        public void Update(){} // RVA: 0x770C850
        public void LateUpdate(){} // RVA: 0x770CF00
        public void FixedUpdate(){} // RVA: 0x770D540
        public void PostLateUpdate(){} // RVA: 0x770DB80
        public void OnDestroy(){} // RVA: 0x770E280
        public void GetWrapperModule(){} // RVA: 0x283FA0
        public void RegisterInput(){} // RVA: 0x770E3F0
        public void RunInputAction(){} // RVA: 0x770E4D0
        public void UpdateInputQueue(){} // RVA: 0x770E810
        public void get_IsSceneLoading(){} // RVA: 0x12108C0
        public void set_IsSceneLoading(){} // RVA: 0x120E9D0
        public void OnSceneLoaded(){} // RVA: 0x770EBF0
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7710150
        public void ProcessUdonProgram(){} // RVA: 0x7710290
        public void OnSceneUnloaded(){} // RVA: 0x7710310
        public void PurgeSerializationCaches(){} // RVA: 0x7710380
        public void GetTotalLoadedProgramSize(){} // RVA: 0x77104F0
        public void GetLoadedBehavioursSyncTypes(){} // RVA: 0x7710C90
        public void RegisterUdonBehaviourUpdate(){} // RVA: 0x7711200
        public void RegisterUdonBehaviourLateUpdate(){} // RVA: 0x77112E0
        public void RegisterUdonBehaviourFixedUpdate(){} // RVA: 0x77113C0
        public void RegisterUdonBehaviourPostLateUpdate(){} // RVA: 0x77114A0
        public void UnregisterUdonBehaviourUpdate(){} // RVA: 0x77115E0
        public void UnregisterUdonBehaviourLateUpdate(){} // RVA: 0x77116C0
        public void UnregisterUdonBehaviourFixedUpdate(){} // RVA: 0x77117A0
        public void UnregisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7711880
        public void ScheduleDelayedEvent(){} // RVA: 0x7711A50 | overloaded x2
        public void HandleUdonEventScheduled(){} // RVA: 0x7711B40
        public void SetUdonEnabled(){} // RVA: 0x190AB20
        public void IncrementDepthCount(){} // RVA: 0x7711BC0
        public void DecrementDepthCount(){} // RVA: 0x7711CD0
        public void get_DebugLogging(){} // RVA: 0x7711D90
        public void set_DebugLogging(){} // RVA: 0x7711DE0
        public void ConstructUdonVM(){} // RVA: 0x7711E50
        public void ApplyFilter(){} // RVA: 0x7711FB0 | overloaded x2
        public void Blacklist(){} // RVA: 0x7711F30 | overloaded x2
        public void CleanBlacklist(){} // RVA: 0x7712010
        public void IsBlacklisted(){} // RVA: 0x283FA0 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x77120C0
        public void get_LightReservedLayerMask(){} // RVA: 0x7712120
        public void set_LightReservedLayerMask(){} // RVA: 0x7712180
        public void GetWrapper(){} // RVA: 0x77121E0
        public void RegisterUdonBehaviour(){} // RVA: 0x7712230
        public void UnregisterUdonBehaviour(){} // RVA: 0x7712550
        public void CheckUdonBehavioursToRegister(){} // RVA: 0x77126C0
        public void GetUdonBehavioursInScene(){} // RVA: 0x77127F0
        public void RunEvent(){} // RVA: 0x7713BF0 | overloaded x10
        public void .ctor(){} // RVA: 0x7713E70
        public void .cctor(){} // RVA: 0x7714DC0
        public void <OnSceneLoaded>b__102_0(){} // RVA: 0x7714E80
    }

    /// <summary>Originally: ÏÎÎÌÎÏÍÏÎÏÎÌÎÎÏÍÍÏÍÏÌÎÎ</summary>
    public class UdonOperationResponseDiscRelated_0902
    {
        public UIntPtr <ÍÍÌÌÌÍÏÎÌÎÍÌÏÌÏÎÍÌÏÎÏÍÎ>k__BackingField; // 0x10
        public uint <ÍÍÏÌÍÏÍÍÏÌÍÌÌÍÌÏÎÎÏÍÎÏÌ>k__BackingField; // 0x18
        public ÌÍÍÌÌÎÌÍÍÍÎÎÌÌÏÎÍÌÏÌÎÍÍ[] <ÍÏÌÍÏÏÌÎÌÎÍÎÌÏÌÌÎÍÏÌÎÎÍ>k__BackingField; // 0x20

        // ── Methods ──
        public void set_Low64(){} // RVA: 0x1B12320
        public void set_Value(){} // RVA: 0x2DEE30
        public void get_Current(){} // RVA: 0x2F8380
        public void get_Key(){} // RVA: 0x1AD4690
        public void set_Low64_6E3058E781AE(){} // RVA: 0x1B12320
        public void set_Count(){} // RVA: 0x1EA98A0
        public void set_Count_CA34BCDBD91E(){} // RVA: 0x1EA98A0
        public void get_Length(){} // RVA: 0x1EA9890
        public void set_Low64_03DADB01CACD(){} // RVA: 0x1B12320
        public void set_Low64_BE4985DA9108(){} // RVA: 0x1B12320
        public void set_Low64_92919F4FCAE1(){} // RVA: 0x1B12320
        public void set_Count_E0C4750C84FB(){} // RVA: 0x1EA98A0
        // ── Unresolved (hash) ──
        public void m_54C(){} // RVA: 0x2DEE30
        public void m_EED(){} // RVA: 0x1AD4690
    }

    /// <summary>Originally: ÍÍÌÍÎÍÍÍÍÍÏÌÌÏÍÌÍÍÏÌÌÌÍ</summary>
    public class UdonOperationResponseDiscRelated_10F5
    {
        public object <ÍÌÌÌÏÌÍÏÌÌÌÌÍÎÎÎÎÎÌÏÏÍÏ>k__BackingField; // 0x10
        public UIntPtr <ÍÍÌÌÌÍÏÎÌÎÍÌÏÌÏÎÍÌÏÎÏÍÎ>k__BackingField; // 0x18
        public System.ArraySegment`1<byte> <ÍÏÌÎÌÍÏÎÌÌÍÏÌÍÎÎÌÎÏÌÏÏÎ>k__BackingField; // 0x20

        // ── Methods ──
        public void set_y(){} // RVA: 0x1EE8D20
        public void get_Current(){} // RVA: 0x196ABE0
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void get_Key(){} // RVA: 0x1AD4690
        public void set_layout(){} // RVA: 0x1F77B90
        public void MoveNext(){} // RVA: 0x100A2F0
        public void get_ElementType(){} // RVA: 0x519240
        public void set_layout_A3E5F9202457(){} // RVA: 0x1F77B90
        public void get_ElementType_425457AF32EC(){} // RVA: 0x519240
        public void set_y_E775A440FC3E(){} // RVA: 0x1EE8D20
        // ── Unresolved (hash) ──
        public void m_627(){} // RVA: 0x196ABE0
        public void m_271(){} // RVA: 0x1AD4690
        public void m_B90(){} // RVA: 0x1AD4690
        public void m_417(){} // RVA: 0x1AD4690
    }

    /// <summary>Originally: ÎÏÎÌÎÌÏÏÌÏÍÎÍÏÌÏÌÎÎÌÏÎÍ</summary>
    public class UdonOperationResponseDiscRelated_1356
    {
        public object <ÍÌÌÌÏÌÍÏÌÌÌÌÍÎÎÎÎÎÌÏÏÍÏ>k__BackingField; // 0x10
        public UIntPtr <ÍÍÌÌÌÍÏÎÌÎÍÌÏÌÏÎÍÌÏÎÏÍÎ>k__BackingField; // 0x18
        public 0x65828B28 <ÎÎÏÌÎÍÏÎÎÎÏÌÌÌÎÍÌÌÌÌÍÍÎ>k__BackingField; // 0x20

        // ── Methods ──
        public void get_Value(){} // RVA: 0x1AD4690
        public void get_ElementType(){} // RVA: 0x519240
        public void get_Key(){} // RVA: 0x1AD4690
        public void get_ElementType_279DE6AF5360(){} // RVA: 0x519240
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ReadCapsuleColliderState(){} // RVA: 0x2E00C0
        public void get_Current(){} // RVA: 0x1AD4690
        public void set_y(){} // RVA: 0x1EE8D20
        public void get_InstantiationKind(){} // RVA: 0x32A5C0
        public void MoveNext(){} // RVA: 0x100A2F0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x100A2F0
        public void set_y_92919F4FCAE1(){} // RVA: 0x1EE8D20
        public void get_ElementType_22AFF8CB038B(){} // RVA: 0x519240
        // ── Unresolved (hash) ──
        public void m_B01(){} // RVA: 0x1AD4690
    }

    /// <summary>Originally: ÌÏÏÌÎÌÌÏÌÏÍÌÌÎÍÌÍÏÌÎÍÌÏ</summary>
    public class UdonOperationResponseDiscRelated_3389
    {
        public ÎÌÏÏÌÏÎÎÍÏÍÎÏÍÍÏÍÌÌÍÌÍÌ <ÎÏÎÎÏÏÎÌÍÎÎÏÏÌÍÌÏÍÍÎÎÍÏ>k__BackingField; // 0x10
        public ÎÏÏÌÌÏÎÎÎÌÏÏÎÍÎÌÌÌÌÍÏÎÌ <ÌÎÍÎÌÏÍÎÏÍÌÍÏÍÏÏÏÏÍÎÌÌÏ>k__BackingField; // 0x18
        public 0x65806E18 <ÏÎÌÌÎÏÎÎÏÌÏÎÍÍÌÎÎÍÍÌÍÏÏ>k__BackingField; // 0x20
        public System.Nullable`1<ÎÏÍÍÌÎÌÏÏÏÌÏÍÎÏÌÏÌÎÌÏÍÏ> <ÌÎÍÌÏÌÍÌÌÏÏÌÎÍÏÎÎÌÏÎÎÏÏ>k__BackingField; // 0x28

        // ── Methods ──
        public void ReadCapsuleColliderState(){} // RVA: 0x2E00C0
        public void ReadCapsuleColliderState_5824C877CF0B(){} // RVA: 0x2E00C0
        public void ReadCapsuleColliderState_49D019FE6D28(){} // RVA: 0x2E00C0
        public void get_InstantiationKind(){} // RVA: 0x32A5C0
        public void MoveNext(){} // RVA: 0x100A2F0
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ReadCapsuleColliderState_6E01C1E3130A(){} // RVA: 0x2E00C0
        public void get_Key(){} // RVA: 0x1AD4690
        public void set_ByteBuffer(){} // RVA: 0x1968950
        public void ProcessAsyncGPUReadbackRequest(){} // RVA: 0x1F05FF0
        public void System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current(){} // RVA: 0x1F06070
        public void ProcessAsyncGPUReadbackRequest_EA009C0D650E(){} // RVA: 0x1F05FF0
        public void get_InstantiationKind_43F94470EDF3(){} // RVA: 0x32A5C0
        // ── Unresolved (hash) ──
        public void m_54A(){} // RVA: 0x100A2F0
    }

    /// <summary>Originally: ÎÎÏÎÎÌÏÌÎÌÎÍÎÌÏÍÏÎÎÏÎÏÌ</summary>
    public class UdonOperationResponseDiscRelated_61A5
    {
        public T <ÏÎÌÌÎÏÎÎÏÌÏÎÍÍÌÎÎÍÍÌÍÏÏ>k__BackingField;

        // ── Methods ──
        public void Awake(){} // RVA: 0x24A50
        public void OnDestroy(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x24A50
        public void Initialize(){} // RVA: 0xCD60
        // ── Unresolved (hash) ──
        public void m_43F(){} // RVA: 0x283FA0
        public void m_582(){} // RVA: 0x283FA0
        public void m_BFE(){} // RVA: 0x24A50
        public void m_3D3(){} // RVA: 0x283FA0
        public void m_2AB(){} // RVA: 0x25130
        public void m_D2E(){} // RVA: 0x283FA0
        public void m_25A(){} // RVA: 0x24A50
    }

    /// <summary>Originally: ÎÎÏÎÎÌÏÌÎÌÎÍÎÌÏÍÏÎÎÏÎÏÌ</summary>
    public class UdonOperationResponseDiscRelated_61A5
    {
        public bool <ÏÎÌÌÎÏÎÎÏÌÏÎÍÍÌÎÎÍÍÌÍÏÏ>k__BackingField; // 0xB8

        // ── Methods ──
        public void Awake(){} // RVA: 0x50959F0
        public void OnDestroy(){} // RVA: 0x5095CC0
        public void .ctor(){} // RVA: 0x2DDD50
        public void Initialize(){} // RVA: 0x5095D70
        // ── Unresolved (hash) ──
        public void m_43F(){} // RVA: 0x173F990
        public void m_582(){} // RVA: 0x173EC00
        public void m_BFE(){} // RVA: 0x24A50
        public void m_3D3(){} // RVA: 0x5095A30
        public void m_2AB(){} // RVA: 0x5095B40
        public void m_D2E(){}
        public void m_25A(){} // RVA: 0x5095CF0
    }

    /// <summary>Originally: ÎÍÏÌÏÌÏÌÏÎÌÏÌÍÍÌÎÏÎÌÏÍÍ</summary>
    public class UdonOperationResponseDiscRelated_8C4E
    {
        public UIntPtr <ÍÍÌÌÌÍÏÎÌÎÍÌÏÌÏÎÍÌÏÎÏÍÎ>k__BackingField; // 0x10
        public 0x65828B80 <ÍÌÏÎÌÌÎÎÌÏÎÏÏÎÏÏÍÍÏÍÎÎÍ>k__BackingField; // 0x18
        public 0x65828BD8 <ÏÌÏÎÎÍÏÍÏÏÏÍÍÏÌÎÍÎÎÎÌÎÎ>k__BackingField; // 0x1C

        // ── Methods ──
        public void set_Count(){} // RVA: 0x1EA98A0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_Capacity(){} // RVA: 0x1EA98B0
        public void set_Mid(){} // RVA: 0x1EA98C0
        public void set_Low64(){} // RVA: 0x1B12320
        public void get_Length_D0FF8CF5E328(){} // RVA: 0x1EA9890
        public void get_Key(){} // RVA: 0x1AD4690
        public void set_Count_A9B3901CE6E0(){} // RVA: 0x1EA98A0
        public void get_Capacity_65607FDEEEAC(){} // RVA: 0x1EA98B0
        public void set_Mid_DA0582FFF9F2(){} // RVA: 0x1EA98C0
        public void get_Length_6A1A7F3BD571(){} // RVA: 0x1EA9890
    }

    /// <summary>Originally: ÌÍÎÍÌÍÎÎÏÎÎÏÍÏÏÍÌÌÏÎÎÌÏ</summary>
    public class UdonOperationResponseDiscRelated_9AFF
    {
        public object <ÍÌÌÌÏÌÍÏÌÌÌÌÍÎÎÎÎÎÌÏÏÍÏ>k__BackingField; // 0x10
        public UIntPtr <ÍÍÌÌÌÍÏÎÌÎÍÌÏÌÏÎÍÌÏÎÏÍÎ>k__BackingField; // 0x18
        public 0x65828A78 <ÍÏÎÌÌÏÎÏÌÌÎÎÌÏÍÏÍÏÎÎÏÎÏ>k__BackingField; // 0x20
        public 0x65828AD0 <ÎÎÏÌÏÏÌÌÌÌÎÌÏÌÌÍÌÍÎÌÏÏÎ>k__BackingField; // 0x24
        public ÎÌÏÏÌÏÎÎÍÏÍÎÏÍÍÏÍÌÌÍÌÍÌ <ÏÌÎÌÎÍÍÏÎÌÌÌÌÎÌÌÍÍÏÎÌÍÌ>k__BackingField; // 0x28

        // ── Methods ──
        public void get_Count(){} // RVA: 0x8ABED0
        public void get_ElementType(){} // RVA: 0x519240
        public void get_InstantiationKind(){} // RVA: 0x32A5C0
        public void MoveNext(){} // RVA: 0x1AD4690
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x2E07C0
        public void get_Current(){} // RVA: 0x100A2F0
        public void ReadCapsuleColliderState(){} // RVA: 0x2E00C0
        public void ReadCapsuleColliderState_7AB72811C510(){} // RVA: 0x2E00C0
        public void Equals(){} // RVA: 0x343E80
        public void get_Value(){} // RVA: 0x1AD4690
        public void set_y(){} // RVA: 0x1EE8D20
        public void set_Key(){} // RVA: 0x1AD4690
        public void get_Key(){} // RVA: 0x1AD4690
        public void Equals_B3C949CA3114(){} // RVA: 0x343E80
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void set_Count(){} // RVA: 0x8AC660
        public void set_Count_7247915690F1(){} // RVA: 0x8AC660
        // ── Unresolved (hash) ──
        public void m_271(){} // RVA: 0x1AD4690
    }

    /// <summary>Originally: ÎÌÍÌÍÍÍÌÎÏÌÌÍÍÏÍÎÏÏÏÏÎÌ</summary>
    public class UdonOperationResponseDiscRelated_A43E
    {
        public UIntPtr <ÍÍÌÌÌÍÏÎÌÎÍÌÏÌÏÎÍÌÏÎÏÍÎ>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Key(){} // RVA: 0x1AD4690
        public void set_Low64(){} // RVA: 0x1B12320
        public void set_Low64_C387F14F6EDF(){} // RVA: 0x1B12320
        // ── Unresolved (hash) ──
        public void m_EED(){} // RVA: 0x1AD4690
        public void m_87C(){} // RVA: 0x1AD4690
        public void m_B9D(){} // RVA: 0x1AD4690
        public void m_F38(){} // RVA: 0x1AD4690
        public void m_E5B(){} // RVA: 0x1AD4690
    }

    /// <summary>Originally: ÌÌÍÍÎÎÏÎÎÍÌÎÍÏÏÌÎÌÌÍÏÏÏ</summary>
    public class UdonOperationResponseDiscRelated_C3B2
    {
        public 0x656FBC98 ÏÌÌÌÌÌÌÎÌÏÌÏÌÍÎÍÏÌÏÌÍÌÏ; // 0x10
        public int ÌÍÍÌÎÍÍÍÌÍÎÍÏÏÏÏÍÎÌÏÏÏÌ; // 0x14
        public int ÌÌÎÍÏÌÍÎÎÌÎÏÏÎÏÏÍÏÍÌÎÌÎ; // 0x18
        public byte ÍÎÏÎÌÎÍÍÎÏÎÌÏÏÍÎÌÌÍÎÏÏÎ; // 0x1C

        // ── Methods ──
        public void set_Count(){} // RVA: 0x8AC660
        public void get_InstantiationKind(){} // RVA: 0x32A5C0
        public void get_Count(){} // RVA: 0x5BED50
        public void set_Count_7E452DF8F4DC(){} // RVA: 0x8AC660
        public void set_Priority(){} // RVA: 0x6374E0
        public void ReadCapsuleColliderState(){} // RVA: 0x2E00C0
        public void get_Count_AB366DC86CFD(){} // RVA: 0x8ABED0
        public void get_InstantiationKind_43F94470EDF3(){} // RVA: 0x32A5C0
        public void get_Count_8358838E01AE(){} // RVA: 0x8ABED0
        public void get_AllowRenegotiation(){} // RVA: 0x2F8390
        public void get_Count_40B541251DCB(){} // RVA: 0x5BED50
        public void .ctor(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x2E00C0
        public void get_InstantiationKind_44FED05062DC(){} // RVA: 0x32A5C0
        public void set_matchWithInputManager(){} // RVA: 0x2F83A0
        public void set_Priority_A771305511F3(){} // RVA: 0x6374E0
        public void ReadCapsuleColliderState_5824C877CF0B(){} // RVA: 0x2E00C0
    }

    /// <summary>Originally: ÎÎÏÏÏÍÎÏÍÎÌÍÏÌÌÎÎÎÎÌÌÌÎ</summary>
    public class UdonOperationResponseDisconnecSibling_00AD
    {
        public UIntPtr <ÎÌÏÌÍÏÍÍÎÌÍÏÏÍÍÌÍÎÎÏÌÎÍ>k__BackingField; // 0x10
        public 0x65828C88 <ÎÎÏÏÏÏÏÌÏÏÎÏÍÍÏÎÌÌÌÏÎÏÍ>k__BackingField; // 0x18
        public 0x65828C30 <ÎÍÎÏÍÍÎÏÎÌÎÍÎÏÍÌÌÌÍÌÎÌÌ>k__BackingField; // 0x1C
        public uint <ÌÎÌÏÌÏÌÍÎÍÏÎÎÍÏÍÌÍÍÍÎÌÎ>k__BackingField; // 0x20
        public ÎÌÏÏÌÏÎÎÍÏÍÎÏÍÍÏÍÌÌÍÌÍÌ <ÍÎÏÌÍÎÎÎÌÌÍÏÍÍÌÎÌÌÍÎÏÍÌ>k__BackingField; // 0x28
        public ÎÌÏÏÌÏÎÎÍÏÍÎÏÍÍÏÍÌÌÍÌÍÌ <ÍÎÎÎÍÏÌÏÎÍÌÍÌÌÌÎÎÍÍÎÌÌÍ>k__BackingField; // 0x30
        public ÎÏÏÌÌÏÎÎÎÌÏÏÎÍÎÌÌÌÌÍÏÎÌ <ÏÍÍÍÌÌÌÍÏÏÌÍÌÎÎÍÍÌÏÌÌÎÎ>k__BackingField; // 0x38

        // ── Methods ──
        public void get_Data(){} // RVA: 0x30B130
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x2E07C0
        public void MoveNext(){} // RVA: 0x30B0C0
        public void set_Mid(){} // RVA: 0x1EA98C0
        public void set_Low64(){} // RVA: 0x1B12320
        public void ReadCapsuleColliderState(){} // RVA: 0x2E00C0
        public void set_Low64_39AD69BC6AAE(){} // RVA: 0x1B12320
        public void GetTransformChildCount_609445D97B38(){} // RVA: 0x30B0D0
        public void set_Mid_312D4564ACFB(){} // RVA: 0x1EA98C0
        public void get_Length(){} // RVA: 0x1EA9890
        public void set_Mid_DFE45C7279F7(){} // RVA: 0x1EA98C0
        public void Equals(){} // RVA: 0x343E80
        public void get_Current(){} // RVA: 0x1AD4690
        public void get_Key(){} // RVA: 0x1AD4690
        public void get_Capacity(){} // RVA: 0x1EA98B0
        public void get_Length_7FB69074B92A(){} // RVA: 0x1EA9890
        public void GetTransformChildCount_609445D97B38_433D5416BBB4(){} // RVA: 0x30B0D0
        public void set_Count(){} // RVA: 0x1EA98A0
        public void CompareTo_DC618AA5A9A7(){} // RVA: 0x2DEE90
        public void get_InstantiationKind(){} // RVA: 0x32A5C0
        public void get_Data_463A13EDEB35(){} // RVA: 0x30B130
        public void set_Low64_D30C59E07643(){} // RVA: 0x1B12320
    }

    /// <summary>Originally: ÍÎÍÎÏÎÍÎÍÏÌÏÍÍÌÎÍÎÍÌÍÍÍ</summary>
    public class UdonOperationResponseDisconnecSibling_9ACD
    {
        public 0x65886F30 <ÏÎÌÌÎÏÎÎÏÌÏÎÍÍÌÎÎÍÍÌÍÏÏ>k__BackingField; // 0x10
        public string <ÍÍÎÎÍÌÎÏÍÎÍÍÌÎÌÍÍÏÎÎÍÌÏ>k__BackingField; // 0x18
        public string <ÍÌÎÍÎÌÎÍÏÏÌÍÎÌÍÏÏÌÎÌÎÏÌ>k__BackingField; // 0x20
        public string <ÎÌÏÏÎÏÍÌÎÍÍÍÏÌÏÏÎÏÍÏÍÍÍ>k__BackingField; // 0x28

        // ── Methods ──
        public void GetLocalRotation(){} // RVA: 0x1D73750
        public void .ctor(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x2E00C0
        public void GetLocalRotation_C089388A5939(){} // RVA: 0x1D73800
        public void GetTransformChildCount_609445D97B38(){} // RVA: 0x30B0D0
        public void get_InstantiationKind(){} // RVA: 0x32A5C0
        public void ReadCapsuleColliderState(){} // RVA: 0x2E00C0
        // ── Unresolved (hash) ──
        public void m_20D(){} // RVA: 0x32A5C0
        public void m_8D9(){} // RVA: 0x30B130
        public void m_D4B(){} // RVA: 0x2DEE90
        public void m_582(){} // RVA: 0x2E00C0
        public void m_609(){} // RVA: 0x343E80
        public void m_7EC(){} // RVA: 0x30B0D0
        public void m_6E0(){} // RVA: 0x2E00C0
        public void m_567(){} // RVA: 0x30B0C0
        public void m_329(){} // RVA: 0x30B0C0
        public void m_537(){} // RVA: 0x2E07C0
    }

    /// <summary>Originally: ÍÎÎÎÌÍÍÏÏÍÌÌÍÌÏÍÌÌÎÎÌÌÍ</summary>
    public class UdonOperationResponseDisconnecSibling_F17D
    {
        public UIntPtr <ÍÍÌÌÌÍÏÎÌÎÍÌÏÌÏÎÍÌÏÎÏÍÎ>k__BackingField; // 0x10
        public 0x65828C88 <ÎÎÏÏÏÏÏÌÏÏÎÏÍÍÏÎÌÌÌÏÎÏÍ>k__BackingField; // 0x18
        public 0x65828C30 <ÎÍÎÏÍÍÎÏÎÌÎÍÎÏÍÌÌÌÍÌÎÌÌ>k__BackingField; // 0x1C
        public ÎÌÏÏÌÏÎÎÍÏÍÎÏÍÍÏÍÌÌÍÌÍÌ <ÍÎÏÌÍÎÎÎÌÌÍÏÍÍÌÎÌÌÍÎÏÍÌ>k__BackingField; // 0x20
        public ÎÌÏÏÌÏÎÎÍÏÍÎÏÍÍÏÍÌÌÍÌÍÌ <ÍÎÎÎÍÏÌÏÎÍÌÍÌÌÌÎÎÍÍÎÌÌÍ>k__BackingField; // 0x28
        public ÎÏÏÌÌÏÎÎÎÌÏÏÎÍÎÌÌÌÌÍÏÎÌ <ÎÌÏÏÎÏÍÌÎÍÍÍÏÌÏÏÎÏÍÏÍÍÍ>k__BackingField; // 0x30
        public int <ÏÌÌÏÏÍÎÍÎÏÌÌÌÏÎÎÌÍÏÎÏÌÎ>k__BackingField; // 0x38

        // ── Methods ──
        public void MoveNext(){} // RVA: 0x2F8380
        public void GetTransformChildCount_609445D97B38(){} // RVA: 0x30B0D0
        public void get_Length(){} // RVA: 0x1EA9890
        public void get_Current(){} // RVA: 0x1AD4690
        public void set_Mid(){} // RVA: 0x1EA98C0
        public void set_Mid_FB5A94886DA9(){} // RVA: 0x1EA98C0
        public void get_Length_69FA786618E1(){} // RVA: 0x1EA9890
        public void get_Capacity(){} // RVA: 0x1EA98B0
        public void set_Value(){} // RVA: 0x2DEE30
        public void Cleanup(){} // RVA: 0x30B0C0
        public void get_Count(){} // RVA: 0x791DC0
        public void CompareTo_DC618AA5A9A7(){} // RVA: 0xA53440
        public void get_Length_FA6EE179EA78(){} // RVA: 0x1EA9890
        public void Equals(){} // RVA: 0x343E80
        public void set_Count(){} // RVA: 0x1EA98A0
        public void get_Length_E1CA7BDAD95D(){} // RVA: 0x1EA9890
        public void get_Length_8D1950AC0B30(){} // RVA: 0x1EA9890
        public void get_Capacity_471158393742(){} // RVA: 0x1EA98B0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x2E07C0
        public void set_Low64(){} // RVA: 0x1B12320
        public void set_Mid_7F8C5E9D55BF(){} // RVA: 0x1EA98C0
        public void System.Collections.IEnumerator.get_Current_CE5B5ACC12BF(){} // RVA: 0x2E07C0
    }

    /// <summary>Originally: ÎÎÌÏÎÏÏÎÍÎÏÍÎÎÎÍÎÏÏÌÎÎÍ</summary>
    public class UdonOperationResponseDisconnectMessage_331A_E89F
    {
        public Photon.Client.PhotonPeer ÎÏÎÎÏÏÍÎÏÎÎÌÌÍÌÌÌÏÏÍÏÌÎ; // 0x10
        public string ÎÎÍÍÏÏÎÏÌÍÎÎÏÌÎÌÏÎÍÌÏÏÍ; // 0x18
        public 0x6598D8D8 ÌÍÎÎÎÌÏÏÏÍÏÏÎÍÍÍÌÍÎÍÎÏÍ; // 0x20
        public int ÎÍÍÎÏÍÎÍÎÏÎÌÏÏÍÌÍÎÌÍÍÍÎ; // 0x24
        public int ÏÎÌÏÏÍÏÌÍÎÌÏÌÎÌÏÏÎÍÍÏÏÏ; // 0x28
        public Photon.Realtime.AppSettings <ÍÍÏÌÏÍÎÍÎÍÍÏÍÌÎÏÍÎÏÎÌÏÎ>k__BackingField; // 0x30
        public 0x6572C628 <ÎÎÏÏÏÏÏÌÏÏÎÏÍÍÏÎÌÌÌÏÎÏÍ>k__BackingField; // 0x38
        public ÏÎÎÎÍÎÎÌÏÎÎÌÎÍÌÎÍÍÏÍÌÍÌ <ÍÍÌÌÏÌÍÍÍÎÌÍÏÍÍÍÍÍÎÎÎÍÍ>k__BackingField; // 0x40
        public 0x6572C680 ÌÎÎÌÏÌÌÌÌÎÌÎÏÌÏÏÌÍÍÏÏÎÎ; // 0x48
        public string ÏÍÎÍÍÌÌÎÎÌÌÌÏÌÌÏÏÏÌÌÏÍÌ; // 0x50
        public ÎÍÏÍÏÍÍÏÏÎÏÎÌÍÏÍÏÎÍÎÏÍÎ ÌÎÏÌÏÏÏÏÍÌÎÌÍÌÏÌÍÍÍÎÌÎÎ; // 0x58
        public string <ÏÎÏÏÏÌÏÏÌÎÏÌÎÍÏÌÎÎÌÌÍÏÏ>k__BackingField; // 0x60
        public string <ÍÍÏÎÌÎÎÌÎÌÎÍÎÎÍÌÌÌÌÍÏÎÌ>k__BackingField; // 0x68
        public System.Func`3<string,0x6572C5D0,string> ÏÎÏÍÏÏÌÎÌÏÎÏÎÌÍÍÏÌÍÌÏÌÍ; // 0x70
        public 0x6572C5D0 <ÌÌÎÎÍÎÌÎÏÎÏÎÌÏÎÎÎÏÌÎÍÏÎ>k__BackingField; // 0x78
        public 0x6572C470 ÏÌÌÌÌÌÌÎÌÏÌÏÌÍÎÍÏÌÏÌÍÌÏ; // 0x7C
        public Photon.Realtime.ConnectionHandler <ÏÎÏÏÌÏÎÌÏÏÏÌÌÍÌÏÌÌÌÍÎÍÏ>k__BackingField; // 0x80
        public System.Action`2<0x6572C470,0x6572C470> ÌÍÌÌÏÏÎÎÏÍÏÌÏÌÏÍÎÍÍÎÎÏÏ; // 0x88
        public System.Action`1<Photon.Client.EventData> ÎÎÏÏÏÏÍÏÏÌÎÍÌÎÍÎÏÎÏÎÌÏÍ; // 0x90
        public System.Action`2<bool,object> ÍÏÎÍÌÍÌÍÎÏÍÎÎÌÌÎÎÍÏÌÎÌÎ; // 0x98
        public System.Action`1<Photon.Client.OperationResponse> ÎÌÏÎÍÍÎÍÌÏÏÏÏÎÍÎÏÍÍÌÏÍÎ; // 0xA0
        public ÏÍÌÌÍÌÏÏÍÏÍÏÎÎÏÍÍÎÍÍÎÏÍ ÍÏÎÌÎÏÎÎÍÍÎÍÍÎÏÌÌÎÍÎÌÌÎ; // 0xA8
        public ÏÌÌÏÍÎÏÍÌÌÏÍÏÎÌÎÌÎÍÍÏÏÌ ÌÍÏÌÎÏÎÍÍÍÌÎÎÎÌÌÎÎÌÍÎÎÍ; // 0xB0
        public ÍÏÌÏÍÍÌÏÍÍÎÌÎÎÏÏÏÌÍÏÏÍÏ ÌÎÎÌÏÍÎÍÌÏÎÏÏÌÎÎÎÎÏÌÌÎÏ; // 0xB8
        public ÎÍÌÍÌÏÏÏÎÏÏÏÎÍÎÎÏÍÏÌÍÎÏ ÍÌÎÎÍÍÍÌÌÏÎÎÍÌÎÏÏÎÍÌÏÏÌ; // 0xC0
        public ÏÎÍÍÎÌÏÌÏÌÎÎÎÌÏÍÏÌÏÌÍÏÎ ÌÍÍÌÎÌÍÏÎÍÎÌÎÍÍÌÍÍÌÏÏÏÌ; // 0xC8
        public 0x6572C578 <ÌÍÌÏÎÍÏÏÌÍÍÎÍÌÍÎÌÌÌÏÎÌÍ>k__BackingField; // 0xD0
        public ÌÌÍÍÎÍÏÍÍÎÏÍÏÎÎÍÏÏÏÌÌÌÍ ÍÍÎÌÎÍÌÎÎÌÏÍÏÎÎÍÍÌÎÍÏÌÍ; // 0xD8
        public ÌÌÎÍÍÏÎÍÍÍÎÎÌÌÍÍÍÏÏÍÎÍÎ <ÍÍÎÌÌÌÍÍÍÍÍÌÏÏÍÎÍÎÍÎÌÌÍ>k__BackingField; // 0xE0
        public ÌÌÎÍÍÏÎÍÍÍÎÎÌÌÍÍÍÏÏÍÎÍÎ ÌÏÌÌÏÎÌÍÎÌÎÎÍÌÍÌÏÏÏÏÍÌÎ; // 0xE8
        public System.Collections.Generic.List`1<ÌÏÎÌÍÏÍÎÌÌÎÎÍÌÎÎÌÍÎÎÎÎÏ> ÍÎÏÌÍÍÎÎÌÍÍÌÏÌÍÎÍÌÍÍÌÎÎ; // 0xF0
        public ÏÍÎÎÏÎÌÍÍÌÍÎÏÎÎÌÌÏÏÏÍÌÍ ÏÌÏÌÍÍÍÌÌÌÌÎÏÎÏÍÍÍÌÌÌÎÌ; // 0xF8
        public ÌÌÍÍÍÏÎÍÎÎÌÎÎÌÌÎÍÏÏÌÌÍÏ <ÌÎÎÍÎÌÌÎÍÎÌÏÌÌÌÍÌÏÌÌÏÍÏ>k__BackingField; // 0x100

        // ── Methods ──
        public void .ctor_B4166BA2026C(){} // RVA: 0x1ADFB20
        public void Initialize(){} // RVA: 0x1ADFB40
        public void set_AudioCaptureSource_D02B5BF54BB1(){} // RVA: 0x1AE4B60 | overloaded x2
        public void op_Implicit(){} // RVA: 0x1ADFF00
        public void get_domainList(){} // RVA: 0xFDC9F0
        public void IsNativeObjectAlive(){} // RVA: 0x1AE0100
        public void set_Flags(){} // RVA: 0x1AE0540
        public void get_name(){} // RVA: 0x1AE06D0
        public void set_name(){} // RVA: 0x1AE0C30
        public void OnOperationResponse(){} // RVA: 0x1AE1110
        public void Equals(){} // RVA: 0x1AE2C00
        public void GetHashCode(){} // RVA: 0x1AE2F40
        public void ToString(){} // RVA: 0x1AE2F90
        public void GetGameObject_A16(){} // RVA: 0x1AE2FB0
        public void DoAngleAxis_Injected_F9A(){} // RVA: 0x1AE35C0
        public void ProcessDisconnectMessage(){} // RVA: 0x1AE3750
        public void SendDisconnectMessage(){} // RVA: 0x1AE37D0
        public void GetCurrentTextCue(){} // RVA: 0x1AE37F0
        public void ReceiveDisconnectMessage(){} // RVA: 0x1AE3800
        public void get_categories(){} // RVA: 0x1AE3810
        public void Destroy(){} // RVA: 0x1AE4040
        public void DestroyImmediate(){} // RVA: 0xFDC9F0
        public void FindObjectsOfType(){} // RVA: 0x1AE4140
        public void GetRotation(){} // RVA: 0x1AE4160
        public void CompareBaseObjects(){} // RVA: 0x37B370
        public void FindObjectsByType_24D111752E5E(){} // RVA: 0x1AE4A30 | overloaded x2
        public void OnEvent_7795F88D74AA(){} // RVA: 0x30B890
        public void DontDestroyOnLoad_D56D190B9E49(){} // RVA: 0x1AE9A00 | overloaded x2
        public void get_hideFlags(){} // RVA: 0x1AE44A0
        public void set_hideFlags(){} // RVA: 0x1AE45C0
        public void DropdownValueChanged(){} // RVA: 0x1AE48C0
        public void HandleDisconnectMessage(){} // RVA: 0x1AE4BF0
        public void CheckNullArgument(){} // RVA: 0x1AE52E0
        public void GetProperties(){} // RVA: 0x1AE5880
        public void OnMessage_524DE24DB354(){} // RVA: 0x1AE59F0
        public void GetStatus(){} // RVA: 0x1AE5B20
        public void ParseDisconnectMessage(){} // RVA: 0x35A740
        public void CheckMessageStatus(){} // RVA: 0x1AE5BF0
        public void op_Equality(){} // RVA: 0xA94E10
        public void op_Inequality(){} // RVA: 0x1AE60C0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x1AE6190
        public void Internal_CloneSingle(){} // RVA: 0x1AE6300
        public void Internal_CloneSingleWithParent(){} // RVA: 0x1AE6340
        public void AddUnitNode(){} // RVA: 0x1AE65A0
        public void get_Uploaded(){} // RVA: 0x6374D0
        public void get_Module(){} // RVA: 0x196F280
        public void GetName(){} // RVA: 0x1AE65B0
        public void SetName(){} // RVA: 0x1AE6750
        public void FindObjectFromInstanceID(){} // RVA: 0x1AE6D80
        public void ForceLoadFromInstanceID(){} // RVA: 0x1AE6D90
        public void get_atlasHeight(){} // RVA: 0x464450
        public void SerializeDisconnectMessage(){} // RVA: 0x1AE6E10
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x1AE6E60
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x1AE6E70
        public void set_atlasWidth(){} // RVA: 0x1AE6E90
        public void ReceiveDisconnectMessage_0BDAEE55664C(){} // RVA: 0x1AE6F90
        public void set_EffectiveUnmappedMemberHandling(){} // RVA: 0x1AE71C0
        public void DoAngleAxisInjected(){} // RVA: 0x1AE78B0
        public void SetHasMemberAttribute(){} // RVA: 0x1AE7940
        public void op_Implicit_693997173427(){} // RVA: 0x1AE7A00
        public void GetHashCodeOfPtr(){} // RVA: 0x1AE7B00
        public void DeserializeDisconnectMessage(){} // RVA: 0x1AE7C00
        public void ReadDisconnectMessage(){} // RVA: 0xFDD6E0
        public void WriteDisconnectMessage(){} // RVA: 0x2DD310
        public void ValidateDisconnectMessage(){} // RVA: 0x1AE7C40
        public void get_MaxBreadcrumbs(){} // RVA: 0x1AE37F0
        public void AcceptDisconnectMessage(){} // RVA: 0x1AE7C50
        public void RejectDisconnectMessage(){} // RVA: 0x1AE7DB0
        public void CreateDisconnectMessage(){} // RVA: 0x1AE7FE0
        public void InitializeDisconnectMessage(){} // RVA: 0x1AE7FF0
        public void FindObjectsByType24D111752E5E(){} // RVA: 0x1AE8270
        public void set_payload(){} // RVA: 0x1AE8370
        public void SetOverlay(){} // RVA: 0x1AE8390
        public void AckDisconnectMessage(){} // RVA: 0x1AE83B0
        public void ProcessDisconnectMessage_8D039D091ACB(){} // RVA: 0x462D00
        public void get_blurSamples(){} // RVA: 0x1AE8400
        public void ProcessDisconnectMessage_55CB91E50937(){} // RVA: 0x2F8380
        public void GetTargets(){} // RVA: 0x1AE85D0
        public void get_EnableServerTracing(){} // RVA: 0x1AE8670
        public void MoveNext(){} // RVA: 0x358D50
        public void set_trackerAnchor(){} // RVA: 0x1AE8680
        public void NackDisconnectMessage(){} // RVA: 0xA933D0
        public void SendDisconnectMessage_0C935A47436A(){} // RVA: 0x1AE8940
        public void OnEvent(){} // RVA: 0x1AE89F0
        public void OnStatusChanged_2BCEC0F71386(){} // RVA: 0x1AE9AE0
        public void set_atlasHeight(){} // RVA: 0x1AE9B60
        public void OnDisconnectMessage(){} // RVA: 0x1AE9C40
        public void set_categories(){} // RVA: 0x2DC60
        public void OnOperationResponse_59D4F6048AE0(){} // RVA: 0x35E900
        public void GetAt(){} // RVA: 0x1AE8670
        public void DisconnectMessageTimeout(){} // RVA: 0x1AE9D90
        public void OnStatusChanged(){} // RVA: 0x1AE9DA0
        public void DisconnectMessageError(){} // RVA: 0x1AEA6C0
        public void DisconnectMessageSuccess(){} // RVA: 0x1AEA760
        public void DisconnectMessageFailed(){} // RVA: 0x37B380
        public void OnMessage(){} // RVA: 0x1AEA7F0
        public void .ctor(){} // RVA: 0x1AEA850
        public void CtorB4166BA2026C(){} // RVA: 0x1AEB950
        public void set_fallbackFontAssetTable(){} // RVA: 0x1AEBD30
        public void InitPayloadEncryption(){} // RVA: 0x1AEBD90
        public void SetDisconnectReason(){} // RVA: 0x1AEBE90
        public void StartPickedUp(){} // RVA: 0x1AEC030
        public void HasDisconnectReason(){} // RVA: 0x1AEC2C0
        public void InitializeDisconnectMessage_23247CF540F5(){} // RVA: 0x1AEC8F0
        public void AcceptDisconnectMessage_53FC416283ED(){} // RVA: 0x1AE37F0
        public void ClearMessage(){} // RVA: 0xA96DC0
        public void op_Equality_733FBDB8A934(){} // RVA: 0x1AECB50
        public void CreateHandle(){} // RVA: 0x30B890
        public void FindObjectsByType_2152D4103C64(){} // RVA: 0x305200
        public void GetFileLineNumber(){} // RVA: 0xA933D0
        public void AttachDisconnectMessageBody(){} // RVA: 0x35E910
        public void OnDisconnectMessage_8D96C35D458B(){} // RVA: 0x1AECCE0
        public void get_pinkyTip(){} // RVA: 0x1AECD00
        public void Reset(){} // RVA: 0x1AECD10
        public void InitializeComponentProperties(){} // RVA: 0x1AECE30
        public void OnValidate(){} // RVA: 0x1AECE70
        public void GetBufferedTimes(){} // RVA: 0x1AECF70
        public void ConfigureAudioSource(){} // RVA: 0x1AECF90
        public void FollowTarget(){} // RVA: 0xDA3F70
        public void DebugReturn_A5E001CFC7A9(){} // RVA: 0xA50BB0
        public void IndexOf(){} // RVA: 0x1AED2F0
        public void GetAt_B96AD169676C(){} // RVA: 0x1A3AF00
        public void GetPlatform(){} // RVA: 0x358D60
        public void __OnPointerExit__UnityEngineEventSystemsPointerEventData__SystemVoid(){} // RVA: 0x1AED720
        public void UpdateUdonOperationResponseDisconnect(){} // RVA: 0x1AED740
        public void GetMaterial(){} // RVA: 0x1AED810
        public void SetAudioCaptureSourceD02B5BF54BB1(){} // RVA: 0x1AED820
        public void set_domainList(){} // RVA: 0x1AEDA80
        public void DropdownValueChanged_56CA49515794(){} // RVA: 0x1AEDA90
        public void ComputeNow(){} // RVA: 0x1AEDB90
        public void get_AudioCaptureSource(){} // RVA: 0x1AEDBB0
        public void set_UserId(){} // RVA: 0xCF6DE0
        public void get_Plugins(){} // RVA: 0x1AEDC70
        public void DebugReturn(){} // RVA: 0x1AEE2B0
        public void SetGameObjectActive(){} // RVA: 0x1AEE360
        public void GetRotation_6049CA097714(){} // RVA: 0x1AEE370
        public void OnDisable0A17D448B2DB(){} // RVA: 0xA8E870
        // ── Unresolved (hash) ──
        public void m_C45(){} // RVA: 0x1AE7880
    }

    /// <summary>Originally: ÏÎÏÌÌÏÍÏÏÌÌÍÏÌÌÏÏÌÍÎÌÎÏ</summary>
    public class UdonOperationResponseStatusChanged_6550_B67D
    {
        public ÏÎÏÌÌÏÍÏÏÌÌÍÏÌÌÏÏÌÍÎÌÎÏ ÍÏÍÏÎÌÍÎÏÏÏÌÏÌÏÌÌÌÌÌÍÏÌ;
        public bool ÏÎÏÍÍÎÎÏÏÎÏÌÌÏÍÌÏÍÎÎÌÏÍ; // 0x170
        public System.Collections.Generic.Queue`1<Photon.Client.EventData> ÍÎÏÌÏÍÍÍÌÍÎÍÍÍÎÌÍÏÏÍÌÍÍ; // 0x178

        // ── Methods ──
        public void OnEvent(){} // RVA: 0xDB7050
        public void Initialize(){} // RVA: 0xDB7B90
        public void set_AudioCaptureSource(){} // RVA: 0xDB7BA0
        public void OnBecameInvisible(){} // RVA: 0xDB8350
        public void OnOperationResponse_91455EE05D0F(){} // RVA: 0xDB7B90
        public void NewImpulseEvent(){} // RVA: 0xDB8620
        public void OnStatusChanged_E28C1F6B7FB6(){} // RVA: 0xDB86B0
        public void get_customCaretColor(){} // RVA: 0xDB8740
        public void GetInstanceID(){} // RVA: 0xDB8C60
        public void .ctor(){} // RVA: 0xDB9410
        public void OnOperationResponse_91455EE05D0F_24B5880240E1(){} // RVA: 0xDB7B90
        public void .ctor_3DF02C4A926E(){} // RVA: 0xDB97E0
        public void OnStatusChanged(){} // RVA: 0xDB9AB0
        public void GetGameObject_A16(){} // RVA: 0xDB9C60
        public void OnEvent_2BCEC0F71386(){} // RVA: 0xDB9CB0
        public void OnOperationResponse(){} // RVA: 0xDB9D30
        public void Start(){} // RVA: 0xDB9E90
        public void GetCurrentTextCue(){} // RVA: 0xDB9F20
    }

    /// <summary>Originally: ÎÍÌÌÏÎÌÌÌÎÌÍÌÍÌÎÍÍÎÎÍÏÍ</summary>
    public class UdonUnregisterEventHandlerRegiSibling_220B
    {
        public ÎÍÌÌÏÎÌÌÌÎÌÍÌÍÌÎÍÍÎÎÍÏÍ <ÎÌÌÍÍÌÌÎÌÏÏÏÍÍÏÌÎÍÌÎÍÏÍ>k__BackingField;
        public ÏÏÏÎÏÏÎÌÏÎÏÍÌÍÎÍÏÎÍÎÏÎÌ <ÏÍÏÏÏÎÎÍÎÏÍÏÏÍÏÍÌÍÌÌÎÍÍ>k__BackingField; // 0x20

        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x1E195E0
        public void LateUpdate(){} // RVA: 0x1E19630
        public void Cleanup(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x1E19AE0
        public void Initialize(){} // RVA: 0x1E19D90
        public void LateUpdate_EB5AEEEC5C65(){} // RVA: 0x1E19630
        public void GetEnabled(){} // RVA: 0x1E19E30
        public void Awake(){} // RVA: 0x1E19E90
        public void TryCopyTo(){} // RVA: 0x283FA0
        // ── Unresolved (hash) ──
        public void m_540(){} // RVA: 0x1E19640
        public void m_217(){} // RVA: 0x1E196C0
        public void m_C8E(){} // RVA: 0x30B0C0
        public void m_EE8(){} // RVA: 0x1E19700
        public void m_E45(){} // RVA: 0x30B0C0
        public void m_076(){} // RVA: 0x1E19A90
        public void m_B05(){} // RVA: 0x30B0C0
        public void m_A85(){} // RVA: 0x1E1A140
    }

    /// <summary>Originally: ÍÏÎÍÌÍÍÍÌÍÎÏÏÌÏÎÌÎÌÏÌÏÎ</summary>
    public class UdonUnregisterEventHandlerRegiSibling_581D
    {
        public string ÏÌÍÌÎÌÏÏÍÏÌÍÌÎÏÎÍÎÎÏÍÎÏ; // 0x20
        public string ÏÎÏÏÍÌÏÌÌÌÎÌÍÌÎÍÏÌÏÌÏÌÌ; // 0x28
        public int ÌÎÎÏÌÏÌÏÍÍÎÏÏÌÌÎÎÌÎÏÌÍÎ;
        public float ÌÏÏÎÌÍÎÏÏÏÏÏÏÏÌÎÍÏÎÎÏÌÌ;

        // ── Methods ──
        public void PushRegistration(){} // RVA: 0x19C9300
        public void PopRegistration(){} // RVA: 0x19C9340
        public void Update(){} // RVA: 0x19C9980
        public void GetEnabled(){} // RVA: 0x19C9AF0
        public void GetEnabled_874AAFB32E69(){} // RVA: 0x19C9B70
        public void GetEnabled_A660C4F07AE5(){} // RVA: 0x19C9BE0
        public void PushObject(){} // RVA: 0x19CA120
        public void PopObject(){} // RVA: 0x19CA220
        public void get_MoveNext(){} // RVA: 0x35A740
        public void InitializeObjectRingBuffer(){} // RVA: 0x19CA520
        public void InitializeObjectRingBuffer_8F5499082328(){} // RVA: 0x19CA5C0
        public void GetEnabled_8C84D06B25F5(){} // RVA: 0x19C9B70
        public void PushObject_0882992F7E7E(){} // RVA: 0x19CA890
        public void PushObject_458CD4CD7705(){} // RVA: 0x19CA8B0
        public void PushObject_C8DB938D9608(){} // RVA: 0x19CAAD0
        public void PushObject_0882992F7E7E_D4692EACC094(){} // RVA: 0x19CA890
        public void .ctor(){} // RVA: 0x19CAD10
        public void Initialize(){} // RVA: 0x19CAE90
        public void SetCullingMode(){} // RVA: 0x19CAFA0
        public void ResetRegistrationCounters(){} // RVA: 0x19CB060
        public void OnDestroy(){} // RVA: 0x19CB1D0
        public void Start(){} // RVA: 0x19CB3A0
        public void SetCullingMode_96E0F8A62FB4(){} // RVA: 0x19CBAF0
        // ── Unresolved (hash) ──
        public void m_848(){} // RVA: 0x19C92C0
        public void m_ABF(){} // RVA: 0x19C9470
        public void m_4B5(){} // RVA: 0x19C9490
        public void m_8AF(){} // RVA: 0x19C9E60
        public void m_510(){} // RVA: 0x19CA340
        public void m_217(){} // RVA: 0x19CA3C0
        public void m_155(){} // RVA: 0x19CA400
        public void m_768(){} // RVA: 0x19CA5D0
        public void m_C1C(){} // RVA: 0x19CABF0
        public void m_0B7(){} // RVA: 0x19CAF60
    }

    /// <summary>Originally: ÏÍÌÏÎÌÏÎÍÌÍÎÍÍÌÍÏÏÍÎÏÏÍ</summary>
    public class UdonUnregisterEventHandlerRegisterEventHandl_2C20_C4A4
    {
        public ÏÍÌÏÎÌÏÎÍÌÍÎÍÍÌÍÏÏÍÎÏÏÍ <ÎÌÌÍÍÌÌÎÌÏÏÏÍÍÏÌÎÍÌÎÍÏÍ>k__BackingField;

        // ── Methods ──
        public void UpdateHandlerState(){} // RVA: 0x13A0DD0
        public void DoPlay(){} // RVA: 0x13A0FE0
        public void DoResetReplacementSha(){} // RVA: 0x13A13F0
        public void .cctor_6E34DE1369F9(){} // RVA: 0x13A1560
        public void ClearEventHandler(){} // RVA: 0x13A1910
        public void FindGameObject_2808A5BB72DE(){} // RVA: 0x13A19A0
        public void TryGetEventHandlerValue(){} // RVA: 0x13A1C00
        public void ReadEventHandlerParticleLifetime(){} // RVA: 0x13A22F0
        public void OnDestroy(){} // RVA: 0x13A26D0
        public void GetUnityEngine(){} // RVA: 0x13A2870
        public void UnregisterEventHandler_8748C656D770(){} // RVA: 0x13A2C00
        public void UpdateMaterial(){} // RVA: 0x13A2DC0
        public void UpdateProgress(){} // RVA: 0x13A2E30
        public void UpdateAnimationProgress_E9B0BE4EC3CB(){} // RVA: 0x13AB580 | overloaded x2
        public void ApplyEventHandlerTextureOffset(){} // RVA: 0x13A4550
        public void set_useGUILayout(){} // RVA: 0x13A4600
        public void TriggerEvent_82644F5984DD(){} // RVA: 0x13A5A10
        public void FindGameObject_2AE4CB47EB73(){} // RVA: 0x13A5F00
        public void TriggerEvent(){} // RVA: 0x13A6130
        public void FindGameObject(){} // RVA: 0x13A92D0 | overloaded x2
        public void get_gameObject(){} // RVA: 0x13A61F0
        public void IsObjectMonoBehaviour(){} // RVA: 0x13A66B0
        public void RegisterEventHandler_7036646E7670(){} // RVA: 0x13A6A40
        public void UnregisterEventHandler(){} // RVA: 0x13A6A90
        public void GetDescendants(){} // RVA: 0x13A6BF0
        public void Initialize(){} // RVA: 0x13A6F70
        public void DoPlay_E620599CA2A1(){} // RVA: 0x13A6FD0
        public void MoveNext(){} // RVA: 0x13A73B0
        public void RegisterEventHandler(){} // RVA: 0x13A7410
        public void InternalGetHashCode(){} // RVA: 0x13A74E0
        public void DoRange(){} // RVA: 0x13A77D0
        public void FindEventHandlerTransform(){} // RVA: 0x13A7EC0
        public void Instantiate(){} // RVA: 0x13A80F0
        public void Awake(){} // RVA: 0x13A8150
        public void ProcessHandlerTransform(){} // RVA: 0x13A82F0
        public void SetEventHandlerValue(){} // RVA: 0x13A83F0
        public void Awake_0F2372363034(){} // RVA: 0x13A84F0
        public void GetGameObject(){} // RVA: 0x13A8890
        public void ValidateEventHandler(){} // RVA: 0x13A8D60
        public void RegisterEventHandler_3B3DD05CC0EE(){} // RVA: 0x13A8ED0
        public void ParseStandardFormatOrThrow(){} // RVA: 0x13A8EF0
        public void .ctor_D00AEE07A215(){} // RVA: 0x13A9330
        public void .cctor(){} // RVA: 0x13A97F0
        public void UnregisterPlay(){} // RVA: 0x13AA110
        public void UpdatePlay(){} // RVA: 0x13AA2D0
        public void UpdateEyeRotation(){} // RVA: 0x13AA580
        public void set_enabled_0758C5906E4D(){} // RVA: 0x13AC3B0 | overloaded x2
        public void GetGameObjectPath(){} // RVA: 0x13AABD0
        public void OnDestroy_5BF8EC5D3803(){} // RVA: 0x13AAC20
        public void ProcessPlay(){} // RVA: 0x13AAD00
        public void .ctor(){} // RVA: 0x2DDD50
        public void ProcessAsyncOperationData(){} // RVA: 0x13AB090
        public void InvokeEventHandler(){} // RVA: 0x13ABD80
        public void InterlockedUpdateAnotherStateField(){} // RVA: 0x13AC270
    }

}