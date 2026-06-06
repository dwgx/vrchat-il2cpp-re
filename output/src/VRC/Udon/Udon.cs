// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon
// Classes: 34
// Methods: 833

namespace VRC.Udon
{
    public class AbstractSerializedUdonProgramAsset
    {
        // ── Methods ──
        public void StoreProgram(){} // RVA: 0x7FFAF2ADDC60 | overloaded x2
        public void RetrieveProgram(){} // RVA: 0x7FFAF2ABCD60
        public void GetSerializedProgramSize(){} // RVA: 0x7FFAF2ABCD60
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void TryGetEntrypointNameFromHash(){}
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFAF2AC1120
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void get_EventReceiver(){} // RVA: 0x7FFAF2DBB0C0
        public void set_EventReceiver(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class AbstractUdonProgramSource
    {
        // ── Methods ──
        public void get_SerializedProgramAsset(){} // RVA: 0x7FFAF2ABCD60
        public void RunEditorUpdate(){} // RVA: 0x7FFAF2ADDC60
        public void RefreshProgram(){} // RVA: 0x7FFAF2AD4A50
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class IUdonTriggerEventConsumer
    {
        // ── Methods ──
        public void get_Priority(){} // RVA: 0x7FFAF2ABD840
        public void TryConsumeOnTriggerEnter(){} // RVA: 0x7FFAF2AC1120
        public void TryConsumeOnTriggerExit(){} // RVA: 0x7FFAF2AC1120
        public void TryConsumeOnTriggerStay(){} // RVA: 0x7FFAF2AC1120
    }

    public class OnAnimatorMoveProxy
    {
        // ── Methods ──
        public void OnAnimatorMove(){} // RVA: 0x7FFAFA1AF180
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class OnAudioFilterReadProxy
    {
        // ── Methods ──
        public void OnAudioFilterRead(){} // RVA: 0x7FFAFA1AF1E0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class OnCollisionStayProxy
    {
        // ── Methods ──
        public void OnCollisionStay(){} // RVA: 0x7FFAFA1AF3C0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class OnRenderObjectProxy
    {
        // ── Methods ──
        public void OnRenderObject(){} // RVA: 0x7FFAFA1AF3E0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class OnTriggerStayProxy
    {
        // ── Methods ──
        public void OnTriggerStay(){} // RVA: 0x7FFAFA1AF440
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class OnWillRenderObjectProxy
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7FFAFA1AF460
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class UdonAlwaysDenyVerifier : {>
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0x7FFAF2D8D320
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class UdonBehaviour : `
    {
        // ── Methods ──
        public void get_SyncMethod(){} // RVA: 0x7FFAFA1AF4C0
        public void set_SyncMethod(){} // RVA: 0x7FFAFA1AF4E0
        public void get_HasDoneStart(){} // RVA: 0x7FFAF3DFA680
        public void get_HasError(){} // RVA: 0x7FFAF3DF2AB0
        public void get_SyncIsContinuous(){} // RVA: 0x7FFAFA1AF860
        public void get_SyncIsManual(){} // RVA: 0x7FFAFA1AF890
        public void get_OnInit(){} // RVA: 0x7FFAFA1AF8C0
        public void set_OnInit(){} // RVA: 0x7FFAFA1AF920
        public void get_RequestSerializationHook(){} // RVA: 0x7FFAFA1AF9D0
        public void set_RequestSerializationHook(){} // RVA: 0x7FFAFA1AFA30
        public void get_DisableInteractive(){} // RVA: 0x7FFAF304FF30
        public void set_DisableInteractive(){} // RVA: 0x7FFAF370F680
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFAF8DDC260
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFAFA1AFAF0
        public void get_IsInteractive(){} // RVA: 0x7FFAFA1AFB60
        public void get_UpdateOrder(){} // RVA: 0x7FFAFA1AFBA0
        public void get_DisableEventProcessing(){} // RVA: 0x7FFAF7A94B90
        public void set_DisableEventProcessing(){} // RVA: 0x7FFAF8ACE3A0
        public void get_ProgramId(){} // RVA: 0x7FFAFA1AFC00
        public void get_ProgramSize(){} // RVA: 0x7FFAFA1AFCF0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAFA1AFEF0 | overloaded x2
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7FFAFA1B0000
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFAFA1B0160
        public void get_IsInitialized(){} // RVA: 0x7FFAF8DDC250
        public void GetComponentIndexFixed(){} // RVA: 0x7FFAFA1B0280
        public void LoadProgram(){} // RVA: 0x7FFAFA1B02E0
        public void RegisterEventProxy(){} // RVA: 0x7FFAF2AD4A50
        public void ProcessEntryPoints(){} // RVA: 0x7FFAFA1B08C0
        public void DetectExistingProxies(){} // RVA: 0x7FFAFA1B14D0
        public void ResolveUdonHeapReferences(){} // RVA: 0x7FFAFA1B17C0
        public void ResolveUdonHeapReference(){} // RVA: 0x7FFAFA1B1B10
        public void ManagedUpdate(){} // RVA: 0x7FFAFA1B1EE0
        public void ManagedLateUpdate(){} // RVA: 0x7FFAFA1B2090
        public void ManagedFixedUpdate(){} // RVA: 0x7FFAFA1B21B0
        public void PostLateUpdate(){} // RVA: 0x7FFAFA1B22D0
        public void OnAnimatorIK(){} // RVA: 0x7FFAFA1B23F0
        public void ProxyOnAnimatorMove(){} // RVA: 0x7FFAFA1B2540
        public void ProxyOnAudioFilterRead(){} // RVA: 0x7FFAFA1B2590
        public void OnBecameInvisible(){} // RVA: 0x7FFAFA1B2760
        public void OnBecameVisible(){} // RVA: 0x7FFAFA1B27B0
        public void OnCollisionEnter(){} // RVA: 0x7FFAFA1B2800
        public void OnCollisionEnter2D(){} // RVA: 0x7FFAFA1B2A70
        public void OnCollisionExit(){} // RVA: 0x7FFAFA1B2C70
        public void OnCollisionExit2D(){} // RVA: 0x7FFAFA1B2EE0
        public void ProxyOnCollisionStay(){} // RVA: 0x7FFAFA1B30E0
        public void OnCollisionStay2D(){} // RVA: 0x7FFAFA1B3350
        public void OnDestroy(){} // RVA: 0x7FFAFA1B3550
        public void OnDisable(){} // RVA: 0x7FFAFA1B3B50
        public void OnDrawGizmos(){} // RVA: 0x7FFAFA1B3BB0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAFA1B3C00
        public void OnEnable(){} // RVA: 0x7FFAFA1B3C50
        public void OnJointBreak(){} // RVA: 0x7FFAFA1B3CB0
        public void OnJointBreak2D(){} // RVA: 0x7FFAFA1B3E30
        public void OnMouseDown(){} // RVA: 0x7FFAFA1B3F50
        public void OnMouseDrag(){} // RVA: 0x7FFAFA1B3FA0
        public void OnMouseEnter(){} // RVA: 0x7FFAFA1B3FF0
        public void OnMouseExit(){} // RVA: 0x7FFAFA1B4040
        public void OnMouseOver(){} // RVA: 0x7FFAFA1B4090
        public void OnMouseUp(){} // RVA: 0x7FFAFA1B40E0
        public void OnMouseUpAsButton(){} // RVA: 0x7FFAFA1B4130
        public void OnParticleCollision(){} // RVA: 0x7FFAFA1B4180
        public void OnParticleTrigger(){} // RVA: 0x7FFAFA1B4350
        public void OnPostRender(){} // RVA: 0x7FFAFA1B43A0
        public void OnPreCull(){} // RVA: 0x7FFAFA1B43F0
        public void OnPreRender(){} // RVA: 0x7FFAFA1B4440
        public void OnRenderImage(){} // RVA: 0x7FFAFA1B4490
        public void ProxyOnRenderObject(){} // RVA: 0x7FFAFA1B4700
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAFA1B4750
        public void OnTransformParentChanged(){} // RVA: 0x7FFAFA1B47A0
        public void OnTriggerEnter(){} // RVA: 0x7FFAFA1B47F0
        public void OnTriggerEnter2D(){} // RVA: 0x7FFAFA1B4BE0
        public void OnTriggerExit(){} // RVA: 0x7FFAFA1B4DE0
        public void OnTriggerExit2D(){} // RVA: 0x7FFAFA1B51D0
        public void ProxyOnTriggerStay(){} // RVA: 0x7FFAFA1B53D0
        public void OnTriggerStay2D(){} // RVA: 0x7FFAFA1B57C0
        public void OnControllerColliderHit(){} // RVA: 0x7FFAFA1B59C0
        public void OnValidate(){} // RVA: 0x7FFAFA1B5E50
        public void ProxyOnWillRenderObject(){} // RVA: 0x7FFAFA1B5EA0
        public void OnNetworkReady(){} // RVA: 0x7FFAF79D9AB0
        public void Interact(){} // RVA: 0x7FFAFA1B5EF0
        public void OnDrop(){} // RVA: 0x7FFAFA1B5F40
        public void OnPickup(){} // RVA: 0x7FFAFA1B5F90
        public void OnPickupUseDown(){} // RVA: 0x7FFAFA1B5FE0
        public void OnPickupUseUp(){} // RVA: 0x7FFAFA1B6030
        public void OnPreSerialization(){} // RVA: 0x7FFAFA1B6080
        public void OnPostSerialization(){} // RVA: 0x7FFAFA1B6210
        public void OnDeserialization(){} // RVA: 0x7FFAFA1B64A0
        public void RunProgram(){} // RVA: 0x7FFAFA1B6830 | overloaded x2
        public void GetPrograms(){} // RVA: 0x7FFAFA1B6E20
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAFA1B6EE0
        public void DeserializePublicVariables(){} // RVA: 0x7FFAFA1B6EF0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAFA1B7370
        public void SerializePublicVariables(){} // RVA: 0x7FFAFA1B7370
        public void TryToInterrogateUdon(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void RunEvent(){} // RVA: 0x7FFAF310F230 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x7FFAFA1B77C0 | overloaded x10
        public void RunInputEvent(){} // RVA: 0x7FFAFA1B7B00
        public void GetEventParameterName(){} // RVA: 0x7FFAFA1B7DA0
        public void PreloadUdonProgram(){} // RVA: 0x7FFAFA1B8090
        public void SearchUdonInterface(){} // RVA: 0x7FFAF2D33FA0
        public void InitializeUdonContent(){} // RVA: 0x7FFAFA1B82F0
        public void RunOnInit(){} // RVA: 0x7FFAFA1B8B80
        public void RegisterUpdate(){} // RVA: 0x7FFAFA1B8D30
        public void UnregisterUpdate(){} // RVA: 0x7FFAFA1B93C0
        public void SendCustomEvent(){} // RVA: 0x7FFAFA1B98E0
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFAFA1B9D60 | overloaded x9
        public void RequestSerialization(){} // RVA: 0x7FFAFA1B9DF0
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7FFAFA1B9EA0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7FFAFA1BA020
        public void get_InteractionText(){} // RVA: 0x7FFAF2DBB130
        public void set_InteractionText(){} // RVA: 0x7FFAF2D8EE90
        public void get_SyncMetadataTable(){} // RVA: 0x7FFAFA1BA1B0
        public void GetProgramVariableType(){} // RVA: 0x7FFAFA1BA210
        public void SetProgramVariable(){} // RVA: 0x7FFAFA1BA320 | overloaded x2
        public void SetHeapVariable(){} // RVA: 0x7FFAF2D33FA0
        public void GetProgramVariable(){} // RVA: 0x7FFAFA1BA460 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFAFA1BA5C0 | overloaded x2
        public void SetupLogging(){} // RVA: 0x7FFAFA1BA7F0
        public void AssignProgramAndVariables(){} // RVA: 0x7FFAFA1BA930
        public void .ctor(){} // RVA: 0x7FFAFA1BA9E0
        public void .cctor(){} // RVA: 0x7FFAFA1BADF0
    }

    /// <summary>Originally: ÍÍÌÍÍÍÍÌÏÌÏÎÌÌÍÏÌÏÌÏÌÏÌ</summary>
    public class UdonBehaviourResultBytes_CF3F_6FF8
    {
        // ── Methods ──
        public void get_UdonBehaviour(){} // RVA: 0x7FFAF2E0A740
        public void get_Result(){} // RVA: 0x7FFAF31070B0
        public void set_Result(){} // RVA: 0x7FFAF2DBB0D0
        public void set_Error(){} // RVA: 0x7FFAF2F4B830
        public void get_Error(){} // RVA: 0x7FFAF2DBB130
        public void get_ResultBytes(){} // RVA: 0x7FFAF2DBB0C0
        public void set_ResultBytes(){} // RVA: 0x7FFAF2DE8CE0
        public void RefreshUdonBehaviourResultBytes(){} // RVA: 0x7FFAF2DBB130
        public void set_Url(){} // RVA: 0x7FFAF2DE8CD0
        public void set_controlPathInternal(){} // RVA: 0x7FFAF2DB5200
        public void HandleUdonBehaviourResultBytes(){} // RVA: 0x7FFAF2F4B830
        public void .ctor(){} // RVA: 0x7FFAF3107160
        public void get_Url(){} // RVA: 0x7FFAF2F476A0
        public void set_ErrorCode(){} // RVA: 0x7FFAF31072D0
        public void GetUdonBehaviourResultBytes(){} // RVA: 0x7FFAF2DE8CE0
        public void get_ErrorCode(){} // RVA: 0x7FFAF2DE8CD0
        public void CancelDownload(){} // RVA: 0x7FFAF31074F0
        public void set_ErrorCode_AAB5870B7AE6(){} // RVA: 0x7FFAF2D8EE90
        public void set_ErrorCode_EE06E0422BED(){} // RVA: 0x7FFAF2DBB130
        public void set_ErrorCode_985A7F61E844(){} // RVA: 0x7FFAF2DBB130
        public void StartDownload(){} // RVA: 0x7FFAF3107560
        public void SetNetworkIDCollection(){} // RVA: 0x7FFAF2DE8CD0
    }

    /// <summary>Originally: ÏÏÌÌÏÌÎÏÎÎÍÍÎÍÍÌÍÌÌÏÏÎÌ</summary>
    public class UdonClientImageDownloaderSibling_5F31
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF2F7FEB0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Initialize(){} // RVA: 0x7FFAF2F815E0
        // ── Unresolved (hash) ──
        public void m_FFA(){} // RVA: 0x7FFAF2F7F540
        public void m_BFD(){} // RVA: 0x7FFAF2F7F680
        public void m_D99(){} // RVA: 0x7FFAF2F7F700
        public void m_485(){} // RVA: 0x7FFAF2F802D0
        public void m_70B(){} // RVA: 0x7FFAF2F80A80
        public void m_FB0(){} // RVA: 0x7FFAF2F80B00
        public void m_909(){} // RVA: 0x7FFAF2F81290
        public void m_2F5(){} // RVA: 0x7FFAF2F81380
    }

    /// <summary>Originally: ÎÎÏÌÎÍÏÌÍÍÌÍÎÍÏÎÌÎÍÌÎÎÌ</summary>
    public class UdonDisableEventProcessing_A521_6832
    {
        // ── Methods ──
        public void RunEvent(){} // RVA: 0x7FFAF310F230 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x7FFAF2D33FA0 | overloaded x10
        public void RunEventAdvanced_2A16DDE426F5(){} // RVA: 0x7FFAF310EBE0
        public void SetProgramVariable(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void InitializeUdonContent(){} // RVA: 0x7FFAF2D8D310
        public void RequestSerialization(){} // RVA: 0x7FFAF2D8D310
        public void get_DisableEventProcessing_5D87A84FE7D9(){} // RVA: 0x7FFAF2E55500
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7FFAF310ED40
        public void SetProgramVariable_76251B84F0A7(){} // RVA: 0x7FFAF2E55510
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFAF310F820 | overloaded x9
        public void GetComponentIndexFixed(){} // RVA: 0x7FFAF310EE40
        public void GetProgramVariable(){} // RVA: 0x7FFAF310F8E0 | overloaded x2
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAF310F100 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFAF310F610 | overloaded x2
        public void set_DisableEventProcessing(){} // RVA: 0x7FFAF310EEB0
        public void get_DisableEventProcessing(){} // RVA: 0x7FFAF310EEC0
        public void SendCustomEvent(){} // RVA: 0x7FFAF310EED0
        public void get_SyncMethod(){} // RVA: 0x7FFAF304C540
        public void GetIsNetworkingSupported(){} // RVA: 0x7FFAF2F734F0
        public void RunProgram(){} // RVA: 0x7FFAF310EF50
        public void set_DisableEventProcessing_5EA3EFCC727F(){} // RVA: 0x7FFAF2E55510
        public void RunInputEvent(){} // RVA: 0x7FFAF310F010
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFAF310F050
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7FFAF310F0C0
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFAF310F1B0
        public void RunEvent_449EFEA13D0E(){} // RVA: 0x7FFAF2E55510
        public void Interact(){} // RVA: 0x7FFAF2D8D310
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7FFAF310F1C0
        public void RunEvent_586E1D4321A6(){} // RVA: 0x7FFAF2F734F0
        public void get_DisableInteractive(){} // RVA: 0x7FFAF2E48C00
        public void set_InteractionText_F9C1D4480780(){} // RVA: 0x7FFAF2F77C50
        public void .ctor(){} // RVA: 0x7FFAF310F320
        public void get_InteractionText(){} // RVA: 0x7FFAF2E08730
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFAF310F560
        public void set_SyncMethod(){} // RVA: 0x7FFAF310F570
        public void set_InteractionText(){} // RVA: 0x7FFAF2E08740
        public void DoThrowUInt16OverflowException(){} // RVA: 0x7FFAF310F750
        public void set_DisableInteractive(){} // RVA: 0x7FFAF2E48C10
        public void set_SyncMetadataTable(){} // RVA: 0x7FFAF2E55500
        public void get_SyncMetadataTable(){} // RVA: 0x7FFAF310F8A0
        public void GetProgramVariableType(){} // RVA: 0x7FFAF310F960
    }

    public class UdonManager : (00
    {
        // ── Methods ──
        public void add_OnUdonProgramLoaded(){} // RVA: 0x7FFAFA1BB0E0
        public void remove_OnUdonProgramLoaded(){} // RVA: 0x7FFAFA1BB240
        public void add_OnUdonReady(){} // RVA: 0x7FFAFA1BB3A0
        public void remove_OnUdonReady(){} // RVA: 0x7FFAFA1BB4F0
        public void get_HasLoaded(){} // RVA: 0x7FFAF3198A80
        public void set_HasLoaded(){} // RVA: 0x7FFAF3198B80
        public void get_Instance(){} // RVA: 0x7FFAFA1BB640
        public void get_SignatureVerificationFailed(){} // RVA: 0x7FFAF34B02A0
        public void get_SignatureVerificationSuccess(){} // RVA: 0x7FFAF4334A40
        public void get_SignatureVerificationSkipped(){} // RVA: 0x7FFAF3500BB0
        public void get_WorldSignatureVerificationEnabled(){} // RVA: 0x7FFAF47419F0
        public void set_WorldSignatureVerificationEnabled(){} // RVA: 0x7FFAF4741A00
        public void ResetWorldSignatureVerification(){} // RVA: 0x7FFAFA1BB6A0
        public void EnableWorldSignatureVerification(){} // RVA: 0x7FFAFA1BB710
        public void RegisterTriggerEventConsumer(){} // RVA: 0x7FFAFA1BB7D0
        public void UnregisterTriggerEventConsumer(){} // RVA: 0x7FFAFA1BB9F0
        public void TryNotifyOnTriggerEnterConsumers(){} // RVA: 0x7FFAFA1BBA60
        public void TryNotifyOnTriggerExitConsumers(){} // RVA: 0x7FFAFA1BBC00
        public void TryNotifyOnTriggerStayConsumers(){} // RVA: 0x7FFAFA1BBDA0
        public void Awake(){} // RVA: 0x7FFAFA1BBF40
        public void Update(){} // RVA: 0x7FFAFA1BC850
        public void LateUpdate(){} // RVA: 0x7FFAFA1BCF00
        public void FixedUpdate(){} // RVA: 0x7FFAFA1BD540
        public void PostLateUpdate(){} // RVA: 0x7FFAFA1BDB80
        public void OnDestroy(){} // RVA: 0x7FFAFA1BE280
        public void GetWrapperModule(){} // RVA: 0x7FFAF2D33FA0
        public void RegisterInput(){} // RVA: 0x7FFAFA1BE3F0
        public void RunInputAction(){} // RVA: 0x7FFAFA1BE4D0
        public void UpdateInputQueue(){} // RVA: 0x7FFAFA1BE810
        public void get_IsSceneLoading(){} // RVA: 0x7FFAF3CC08C0
        public void set_IsSceneLoading(){} // RVA: 0x7FFAF3CBE9D0
        public void OnSceneLoaded(){} // RVA: 0x7FFAFA1BEBF0
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7FFAFA1C0150
        public void ProcessUdonProgram(){} // RVA: 0x7FFAFA1C0290
        public void OnSceneUnloaded(){} // RVA: 0x7FFAFA1C0310
        public void PurgeSerializationCaches(){} // RVA: 0x7FFAFA1C0380
        public void GetTotalLoadedProgramSize(){} // RVA: 0x7FFAFA1C04F0
        public void GetLoadedBehavioursSyncTypes(){} // RVA: 0x7FFAFA1C0C90
        public void RegisterUdonBehaviourUpdate(){} // RVA: 0x7FFAFA1C1200
        public void RegisterUdonBehaviourLateUpdate(){} // RVA: 0x7FFAFA1C12E0
        public void RegisterUdonBehaviourFixedUpdate(){} // RVA: 0x7FFAFA1C13C0
        public void RegisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7FFAFA1C14A0
        public void UnregisterUdonBehaviourUpdate(){} // RVA: 0x7FFAFA1C15E0
        public void UnregisterUdonBehaviourLateUpdate(){} // RVA: 0x7FFAFA1C16C0
        public void UnregisterUdonBehaviourFixedUpdate(){} // RVA: 0x7FFAFA1C17A0
        public void UnregisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7FFAFA1C1880
        public void ScheduleDelayedEvent(){} // RVA: 0x7FFAFA1C1A50 | overloaded x2
        public void HandleUdonEventScheduled(){} // RVA: 0x7FFAFA1C1B40
        public void SetUdonEnabled(){} // RVA: 0x7FFAF43BAB20
        public void IncrementDepthCount(){} // RVA: 0x7FFAFA1C1BC0
        public void DecrementDepthCount(){} // RVA: 0x7FFAFA1C1CD0
        public void get_DebugLogging(){} // RVA: 0x7FFAFA1C1D90
        public void set_DebugLogging(){} // RVA: 0x7FFAFA1C1DE0
        public void ConstructUdonVM(){} // RVA: 0x7FFAFA1C1E50
        public void ApplyFilter(){} // RVA: 0x7FFAFA1C1FB0 | overloaded x2
        public void Blacklist(){} // RVA: 0x7FFAFA1C1F30 | overloaded x2
        public void CleanBlacklist(){} // RVA: 0x7FFAFA1C2010
        public void IsBlacklisted(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFAFA1C20C0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFAFA1C2120
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFAFA1C2180
        public void GetWrapper(){} // RVA: 0x7FFAFA1C21E0
        public void RegisterUdonBehaviour(){} // RVA: 0x7FFAFA1C2230
        public void UnregisterUdonBehaviour(){} // RVA: 0x7FFAFA1C2550
        public void CheckUdonBehavioursToRegister(){} // RVA: 0x7FFAFA1C26C0
        public void GetUdonBehavioursInScene(){} // RVA: 0x7FFAFA1C27F0
        public void RunEvent(){} // RVA: 0x7FFAFA1C3BF0 | overloaded x10
        public void .ctor(){} // RVA: 0x7FFAFA1C3E70
        public void .cctor(){} // RVA: 0x7FFAFA1C4DC0
        public void <OnSceneLoaded>b__102_0(){} // RVA: 0x7FFAFA1C4E80
    }

    /// <summary>Originally: ÏÎÎÌÎÏÍÏÎÏÎÌÎÎÏÍÍÏÍÏÌÎÎ</summary>
    public class UdonOperationResponseDiscRelated_0902
    {
        // ── Methods ──
        public void set_Low64(){} // RVA: 0x7FFAF45C2320
        public void set_Value(){} // RVA: 0x7FFAF2D8EE30
        public void get_Current(){} // RVA: 0x7FFAF2DA8380
        public void get_Key(){} // RVA: 0x7FFAF4584690
        public void set_Low64_6E3058E781AE(){} // RVA: 0x7FFAF45C2320
        public void set_Count(){} // RVA: 0x7FFAF49598A0
        public void get_Value(){} // RVA: 0x7FFAF4584690
        public void set_Count_CA34BCDBD91E(){} // RVA: 0x7FFAF49598A0
        public void get_Length(){} // RVA: 0x7FFAF4959890
        public void set_Low64_03DADB01CACD(){} // RVA: 0x7FFAF45C2320
        public void set_Low64_BE4985DA9108(){} // RVA: 0x7FFAF45C2320
        public void set_Low64_92919F4FCAE1(){} // RVA: 0x7FFAF45C2320
        public void set_Count_E0C4750C84FB(){} // RVA: 0x7FFAF49598A0
        // ── Unresolved (hash) ──
        public void m_54C(){} // RVA: 0x7FFAF2D8EE30
    }

    /// <summary>Originally: ÍÍÌÍÎÍÍÍÍÍÏÌÌÏÍÌÍÍÏÌÌÌÍ</summary>
    public class UdonOperationResponseDiscRelated_10F5
    {
        // ── Methods ──
        public void set_y(){} // RVA: 0x7FFAF4998D20
        public void get_Current(){} // RVA: 0x7FFAF441ABE0
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void get_Key(){} // RVA: 0x7FFAF4584690
        public void set_layout(){} // RVA: 0x7FFAF4A27B90
        public void MoveNext(){} // RVA: 0x7FFAF3ABA2F0
        public void get_ElementType(){} // RVA: 0x7FFAF2FC9240
        public void get_Value(){} // RVA: 0x7FFAF4584690
        public void set_layout_A3E5F9202457(){} // RVA: 0x7FFAF4A27B90
        public void set_Key(){} // RVA: 0x7FFAF4584690
        public void get_ElementType_425457AF32EC(){} // RVA: 0x7FFAF2FC9240
        public void set_y_E775A440FC3E(){} // RVA: 0x7FFAF4998D20
        // ── Unresolved (hash) ──
        public void m_627(){} // RVA: 0x7FFAF441ABE0
        public void m_417(){} // RVA: 0x7FFAF4584690
    }

    /// <summary>Originally: ÎÏÎÌÎÌÏÏÌÏÍÎÍÏÌÏÌÎÎÌÏÎÍ</summary>
    public class UdonOperationResponseDiscRelated_1356
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF4584690
        public void get_ElementType(){} // RVA: 0x7FFAF2FC9240
        public void get_Key(){} // RVA: 0x7FFAF4584690
        public void get_ElementType_279DE6AF5360(){} // RVA: 0x7FFAF2FC9240
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ReadCapsuleColliderState(){} // RVA: 0x7FFAF2D900C0
        public void get_Current(){} // RVA: 0x7FFAF4584690
        public void set_y(){} // RVA: 0x7FFAF4998D20
        public void get_InstantiationKind(){} // RVA: 0x7FFAF2DDA5C0
        public void MoveNext(){} // RVA: 0x7FFAF3ABA2F0
        public void get_y(){} // RVA: 0x7FFAF4584690
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAF3ABA2F0
        public void set_y_92919F4FCAE1(){} // RVA: 0x7FFAF4998D20
        public void get_ElementType_22AFF8CB038B(){} // RVA: 0x7FFAF2FC9240
    }

    /// <summary>Originally: ÌÏÏÌÎÌÌÏÌÏÍÌÌÎÍÌÍÏÌÎÍÌÏ</summary>
    public class UdonOperationResponseDiscRelated_3389
    {
        // ── Methods ──
        public void ReadCapsuleColliderState(){} // RVA: 0x7FFAF2D900C0
        public void ReadCapsuleColliderState_5824C877CF0B(){} // RVA: 0x7FFAF2D900C0
        public void System.Collections.IEnumerator.MoveNext(){} // RVA: 0x7FFAF3ABA2F0
        public void ReadCapsuleColliderState_49D019FE6D28(){} // RVA: 0x7FFAF2D900C0
        public void get_InstantiationKind(){} // RVA: 0x7FFAF2DDA5C0
        public void MoveNext(){} // RVA: 0x7FFAF3ABA2F0
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ReadCapsuleColliderState_6E01C1E3130A(){} // RVA: 0x7FFAF2D900C0
        public void get_Key(){} // RVA: 0x7FFAF4584690
        public void set_ByteBuffer(){} // RVA: 0x7FFAF4418950
        public void ProcessAsyncGPUReadbackRequest(){} // RVA: 0x7FFAF49B5FF0
        public void System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.InputBinding>.get_Current(){} // RVA: 0x7FFAF49B6070
        public void ProcessAsyncGPUReadbackRequest_EA009C0D650E(){} // RVA: 0x7FFAF49B5FF0
        public void get_InstantiationKind_43F94470EDF3(){} // RVA: 0x7FFAF2DDA5C0
    }

    /// <summary>Originally: ÎÎÏÎÎÌÏÌÎÌÎÍÎÌÏÍÏÎÎÏÎÏÌ</summary>
    public class UdonOperationResponseDiscRelated_61A5
    {
        // ── Methods ──
        public void get_featured(){} // RVA: 0x7FFAF2D33FA0
        public void set_featured(){} // RVA: 0x7FFAF2D33FA0
        public void Awake(){} // RVA: 0x7FFAF2AD4A50
        public void InitializeCollection(){} // RVA: 0x7FFAF2AD4A50
        public void TryCopyTo(){} // RVA: 0x7FFAF2D33FA0
        public void Dispose(){} // RVA: 0x7FFAF2AD5130
        public void TryCopyTo_D2EAFFAB233D(){} // RVA: 0x7FFAF2D33FA0
        public void OnDestroy(){} // RVA: 0x7FFAF2AD4A50
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
        public void Initialize(){} // RVA: 0x7FFAF2ABCD60
    }

    /// <summary>Originally: ÎÎÏÎÎÌÏÌÎÌÎÍÎÌÏÍÏÎÎÏÎÏÌ</summary>
    public class UdonOperationResponseDiscRelated_61A5
    {
        // ── Methods ──
        public void get_featured(){} // RVA: 0x7FFAF41EF990
        public void set_featured(){} // RVA: 0x7FFAF41EEC00
        public void Awake(){} // RVA: 0x7FFAF7B459F0
        public void InitializeCollection(){} // RVA: 0x7FFAF2AD4A50
        public void TryCopyTo(){} // RVA: 0x7FFAF7B45A30
        public void Dispose(){} // RVA: 0x7FFAF7B45B40
        public void TryCopyTo_D2EAFFAB233D(){}
        public void OnDestroy(){} // RVA: 0x7FFAF7B45CC0
        public void Clear(){} // RVA: 0x7FFAF7B45CF0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void Initialize(){} // RVA: 0x7FFAF7B45D70
    }

    /// <summary>Originally: ÎÍÏÌÏÌÏÌÏÎÌÏÌÍÍÌÎÏÎÌÏÍÍ</summary>
    public class UdonOperationResponseDiscRelated_8C4E
    {
        // ── Methods ──
        public void set_Count(){} // RVA: 0x7FFAF49598A0
        public void get_Length(){} // RVA: 0x7FFAF4959890
        public void get_Capacity(){} // RVA: 0x7FFAF49598B0
        public void set_Mid(){} // RVA: 0x7FFAF49598C0
        public void set_Low64(){} // RVA: 0x7FFAF45C2320
        public void get_Length_D0FF8CF5E328(){} // RVA: 0x7FFAF4959890
        public void get_Key(){} // RVA: 0x7FFAF4584690
        public void set_Count_A9B3901CE6E0(){} // RVA: 0x7FFAF49598A0
        public void get_Capacity_65607FDEEEAC(){} // RVA: 0x7FFAF49598B0
        public void set_Mid_DA0582FFF9F2(){} // RVA: 0x7FFAF49598C0
        public void get_Length_6A1A7F3BD571(){} // RVA: 0x7FFAF4959890
    }

    /// <summary>Originally: ÌÍÎÍÌÍÎÎÏÎÎÏÍÏÏÍÌÌÏÎÎÌÏ</summary>
    public class UdonOperationResponseDiscRelated_9AFF
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAF335BED0
        public void get_ElementType(){} // RVA: 0x7FFAF2FC9240
        public void get_InstantiationKind(){} // RVA: 0x7FFAF2DDA5C0
        public void MoveNext(){} // RVA: 0x7FFAF4584690
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF2D907C0
        public void get_Current(){} // RVA: 0x7FFAF3ABA2F0
        public void ReadCapsuleColliderState(){} // RVA: 0x7FFAF2D900C0
        public void ReadCapsuleColliderState_7AB72811C510(){} // RVA: 0x7FFAF2D900C0
        public void Equals(){} // RVA: 0x7FFAF2DF3E80
        public void get_Value(){} // RVA: 0x7FFAF4584690
        public void set_y(){} // RVA: 0x7FFAF4998D20
        public void set_Key(){} // RVA: 0x7FFAF4584690
        public void get_Key(){} // RVA: 0x7FFAF4584690
        public void Equals_B3C949CA3114(){} // RVA: 0x7FFAF2DF3E80
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void set_Count(){} // RVA: 0x7FFAF335C660
        public void set_Count_7247915690F1(){} // RVA: 0x7FFAF335C660
        // ── Unresolved (hash) ──
        public void m_271(){} // RVA: 0x7FFAF4584690
    }

    /// <summary>Originally: ÎÌÍÌÍÍÍÌÎÏÌÌÍÍÏÍÎÏÏÏÏÎÌ</summary>
    public class UdonOperationResponseDiscRelated_A43E
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAF4584690
        public void set_Key(){} // RVA: 0x7FFAF4584690
        public void get_Key(){} // RVA: 0x7FFAF4584690
        public void set_Low64(){} // RVA: 0x7FFAF45C2320
        public void set_Low64_C387F14F6EDF(){} // RVA: 0x7FFAF45C2320
        // ── Unresolved (hash) ──
        public void m_B9D(){} // RVA: 0x7FFAF4584690
        public void m_F38(){} // RVA: 0x7FFAF4584690
        public void m_E5B(){} // RVA: 0x7FFAF4584690
    }

    /// <summary>Originally: ÌÌÍÍÎÎÏÎÎÍÌÎÍÏÏÌÎÌÌÍÏÏÏ</summary>
    public class UdonOperationResponseDiscRelated_C3B2
    {
        // ── Methods ──
        public void set_Count(){} // RVA: 0x7FFAF335C660
        public void get_InstantiationKind(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Count(){} // RVA: 0x7FFAF306ED50
        public void set_Count_7E452DF8F4DC(){} // RVA: 0x7FFAF335C660
        public void set_Priority(){} // RVA: 0x7FFAF30E74E0
        public void ReadCapsuleColliderState(){} // RVA: 0x7FFAF2D900C0
        public void get_Count_AB366DC86CFD(){} // RVA: 0x7FFAF335BED0
        public void get_InstantiationKind_43F94470EDF3(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Count_8358838E01AE(){} // RVA: 0x7FFAF335BED0
        public void get_AllowRenegotiation(){} // RVA: 0x7FFAF2DA8390
        public void get_Count_40B541251DCB(){} // RVA: 0x7FFAF306ED50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Initialize(){} // RVA: 0x7FFAF2D900C0
        public void get_InstantiationKind_44FED05062DC(){} // RVA: 0x7FFAF2DDA5C0
        public void set_matchWithInputManager(){} // RVA: 0x7FFAF2DA83A0
        public void set_Priority_A771305511F3(){} // RVA: 0x7FFAF30E74E0
        public void ReadCapsuleColliderState_5824C877CF0B(){} // RVA: 0x7FFAF2D900C0
    }

    /// <summary>Originally: ÎÎÏÏÏÍÎÏÍÎÌÍÏÌÌÎÎÎÎÌÌÌÎ</summary>
    public class UdonOperationResponseDisconnecSibling_00AD
    {
        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFAF2DBB130
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF2D907C0
        public void MoveNext(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Mid(){} // RVA: 0x7FFAF49598C0
        public void set_Low64(){} // RVA: 0x7FFAF45C2320
        public void ReadCapsuleColliderState(){} // RVA: 0x7FFAF2D900C0
        public void set_Low64_39AD69BC6AAE(){} // RVA: 0x7FFAF45C2320
        public void GetTransformChildCount_609445D97B38(){} // RVA: 0x7FFAF2DBB0D0
        public void set_Mid_312D4564ACFB(){} // RVA: 0x7FFAF49598C0
        public void get_Length(){} // RVA: 0x7FFAF4959890
        public void set_Mid_DFE45C7279F7(){} // RVA: 0x7FFAF49598C0
        public void Equals(){} // RVA: 0x7FFAF2DF3E80
        public void get_Current(){} // RVA: 0x7FFAF4584690
        public void get_Key(){} // RVA: 0x7FFAF4584690
        public void get_Capacity(){} // RVA: 0x7FFAF49598B0
        public void get_Length_7FB69074B92A(){} // RVA: 0x7FFAF4959890
        public void GetTransformChildCount_609445D97B38_433D5416BBB4(){} // RVA: 0x7FFAF2DBB0D0
        public void set_Count(){} // RVA: 0x7FFAF49598A0
        public void CompareTo_DC618AA5A9A7(){} // RVA: 0x7FFAF2D8EE90
        public void get_InstantiationKind(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Data_463A13EDEB35(){} // RVA: 0x7FFAF2DBB130
        public void set_Low64_D30C59E07643(){} // RVA: 0x7FFAF45C2320
    }

    /// <summary>Originally: ÍÎÍÎÏÎÍÎÍÏÌÏÍÍÌÎÍÎÍÌÍÍÍ</summary>
    public class UdonOperationResponseDisconnecSibling_9ACD
    {
        // ── Methods ──
        public void FlagDiscontinuity(){} // RVA: 0x7FFAF2DDA5C0
        public void GetLocalRotation(){} // RVA: 0x7FFAF4823750
        public void GetAngularVelocity(){} // RVA: 0x7FFAF2DBB130
        public void GetLocalPosition(){} // RVA: 0x7FFAF2D8EE90
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Initialize(){} // RVA: 0x7FFAF2D900C0
        public void GetPosition(){} // RVA: 0x7FFAF2D900C0
        public void GetRotation(){} // RVA: 0x7FFAF2DF3E80
        public void GetVelocity(){} // RVA: 0x7FFAF2DBB0D0
        public void Respawn(){} // RVA: 0x7FFAF2D900C0
        public void SetGravity(){} // RVA: 0x7FFAF2DBB0C0
        public void SetKinematic(){} // RVA: 0x7FFAF2DBB0C0
        public void TeleportTo(){} // RVA: 0x7FFAF2D907C0
        public void GetLocalRotation_C089388A5939(){} // RVA: 0x7FFAF4823800
        public void GetTransformChildCount_609445D97B38(){} // RVA: 0x7FFAF2DBB0D0
        public void get_InstantiationKind(){} // RVA: 0x7FFAF2DDA5C0
        public void ReadCapsuleColliderState(){} // RVA: 0x7FFAF2D900C0
    }

    /// <summary>Originally: ÍÎÎÎÌÍÍÏÏÍÌÌÍÌÏÍÌÌÎÎÌÌÍ</summary>
    public class UdonOperationResponseDisconnecSibling_F17D
    {
        // ── Methods ──
        public void MoveNext(){} // RVA: 0x7FFAF2DA8380
        public void GetTransformChildCount_609445D97B38(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Length(){} // RVA: 0x7FFAF4959890
        public void get_Current(){} // RVA: 0x7FFAF4584690
        public void set_Mid(){} // RVA: 0x7FFAF49598C0
        public void set_Mid_FB5A94886DA9(){} // RVA: 0x7FFAF49598C0
        public void get_Length_69FA786618E1(){} // RVA: 0x7FFAF4959890
        public void get_Capacity(){} // RVA: 0x7FFAF49598B0
        public void set_Value(){} // RVA: 0x7FFAF2D8EE30
        public void Cleanup(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Count(){} // RVA: 0x7FFAF3241DC0
        public void CompareTo_DC618AA5A9A7(){} // RVA: 0x7FFAF3503440
        public void get_Length_FA6EE179EA78(){} // RVA: 0x7FFAF4959890
        public void Equals(){} // RVA: 0x7FFAF2DF3E80
        public void set_Count(){} // RVA: 0x7FFAF49598A0
        public void get_Length_E1CA7BDAD95D(){} // RVA: 0x7FFAF4959890
        public void get_Length_8D1950AC0B30(){} // RVA: 0x7FFAF4959890
        public void get_Capacity_471158393742(){} // RVA: 0x7FFAF49598B0
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAF2D907C0
        public void set_Low64(){} // RVA: 0x7FFAF45C2320
        public void set_Mid_7F8C5E9D55BF(){} // RVA: 0x7FFAF49598C0
        public void System.Collections.IEnumerator.get_Current_CE5B5ACC12BF(){} // RVA: 0x7FFAF2D907C0
    }

    /// <summary>Originally: ÎÎÌÏÎÏÏÎÍÎÏÍÎÎÎÍÎÏÏÌÎÎÍ</summary>
    public class UdonOperationResponseDisconnectMessage_331A_E89F
    {
        // ── Methods ──
        public void .ctor_B4166BA2026C(){} // RVA: 0x7FFAF458FB20
        public void Initialize(){} // RVA: 0x7FFAF458FB40
        public void set_AudioCaptureSource_D02B5BF54BB1(){} // RVA: 0x7FFAF4594B60 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAF458FF00
        public void get_domainList(){} // RVA: 0x7FFAF3A8C9F0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAF4590100
        public void set_Flags(){} // RVA: 0x7FFAF4590540
        public void get_name(){} // RVA: 0x7FFAF45906D0
        public void set_name(){} // RVA: 0x7FFAF4590C30
        public void OnOperationResponse(){} // RVA: 0x7FFAF4591110
        public void Equals(){} // RVA: 0x7FFAF4592C00
        public void GetHashCode(){} // RVA: 0x7FFAF4592F40
        public void ToString(){} // RVA: 0x7FFAF4592F90
        public void GetGameObject_A16(){} // RVA: 0x7FFAF4592FB0
        public void DoAngleAxis_Injected_F9A(){} // RVA: 0x7FFAF45935C0
        public void ProcessDisconnectMessage(){} // RVA: 0x7FFAF4593750
        public void SendDisconnectMessage(){} // RVA: 0x7FFAF45937D0
        public void GetCurrentTextCue(){} // RVA: 0x7FFAF45937F0
        public void ReceiveDisconnectMessage(){} // RVA: 0x7FFAF4593800
        public void get_categories(){} // RVA: 0x7FFAF4593810
        public void Destroy(){} // RVA: 0x7FFAF4594040
        public void DestroyImmediate(){} // RVA: 0x7FFAF3A8C9F0
        public void FindObjectsOfType(){} // RVA: 0x7FFAF4594140
        public void GetRotation(){} // RVA: 0x7FFAF4594160
        public void CompareBaseObjects(){} // RVA: 0x7FFAF2E2B370
        public void FindObjectsByType_24D111752E5E(){} // RVA: 0x7FFAF4594A30 | overloaded x2
        public void OnEvent_7795F88D74AA(){} // RVA: 0x7FFAF2DBB890
        public void DontDestroyOnLoad_D56D190B9E49(){} // RVA: 0x7FFAF4599A00 | overloaded x2
        public void get_hideFlags(){} // RVA: 0x7FFAF45944A0
        public void set_hideFlags(){} // RVA: 0x7FFAF45945C0
        public void DropdownValueChanged(){} // RVA: 0x7FFAF45948C0
        public void HandleDisconnectMessage(){} // RVA: 0x7FFAF4594BF0
        public void CheckNullArgument(){} // RVA: 0x7FFAF45952E0
        public void GetProperties(){} // RVA: 0x7FFAF4595880
        public void OnMessage_524DE24DB354(){} // RVA: 0x7FFAF45959F0
        public void GetStatus(){} // RVA: 0x7FFAF4595B20
        public void ParseDisconnectMessage(){} // RVA: 0x7FFAF2E0A740
        public void CheckMessageStatus(){} // RVA: 0x7FFAF4595BF0
        public void op_Equality(){} // RVA: 0x7FFAF3544E10
        public void op_Inequality(){} // RVA: 0x7FFAF45960C0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFAF4596190
        public void Internal_CloneSingle(){} // RVA: 0x7FFAF4596300
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFAF4596340
        public void AddUnitNode(){} // RVA: 0x7FFAF45965A0
        public void get_Uploaded(){} // RVA: 0x7FFAF30E74D0
        public void get_Module(){} // RVA: 0x7FFAF441F280
        public void GetName(){} // RVA: 0x7FFAF45965B0
        public void SetName(){} // RVA: 0x7FFAF4596750
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFAF4596D80
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFAF4596D90
        public void get_atlasHeight(){} // RVA: 0x7FFAF2F14450
        public void SerializeDisconnectMessage(){} // RVA: 0x7FFAF4596E10
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFAF4596E60
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFAF4596E70
        public void set_atlasWidth(){} // RVA: 0x7FFAF4596E90
        public void ReceiveDisconnectMessage_0BDAEE55664C(){} // RVA: 0x7FFAF4596F90
        public void set_EffectiveUnmappedMemberHandling(){} // RVA: 0x7FFAF45971C0
        public void DoAngleAxisInjected(){} // RVA: 0x7FFAF45978B0
        public void SetHasMemberAttribute(){} // RVA: 0x7FFAF4597940
        public void op_Implicit_693997173427(){} // RVA: 0x7FFAF4597A00
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAF4597B00
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFAF4597C00
        public void ReadDisconnectMessage(){} // RVA: 0x7FFAF3A8D6E0
        public void WriteDisconnectMessage(){} // RVA: 0x7FFAF2D8D310
        public void ValidateDisconnectMessage(){} // RVA: 0x7FFAF4597C40
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFAF45937F0
        public void AcceptDisconnectMessage(){} // RVA: 0x7FFAF4597C50
        public void RejectDisconnectMessage(){} // RVA: 0x7FFAF4597DB0
        public void CreateDisconnectMessage(){} // RVA: 0x7FFAF4597FE0
        public void InitializeDisconnectMessage(){} // RVA: 0x7FFAF4597FF0
        public void FindObjectsByType24D111752E5E(){} // RVA: 0x7FFAF4598270
        public void set_payload(){} // RVA: 0x7FFAF4598370
        public void SetOverlay(){} // RVA: 0x7FFAF4598390
        public void AckDisconnectMessage(){} // RVA: 0x7FFAF45983B0
        public void ProcessDisconnectMessage_8D039D091ACB(){} // RVA: 0x7FFAF2F12D00
        public void get_blurSamples(){} // RVA: 0x7FFAF4598400
        public void ProcessDisconnectMessage_55CB91E50937(){} // RVA: 0x7FFAF2DA8380
        public void GetTargets(){} // RVA: 0x7FFAF45985D0
        public void get_EnableServerTracing(){} // RVA: 0x7FFAF4598670
        public void MoveNext(){} // RVA: 0x7FFAF2E08D50
        public void set_trackerAnchor(){} // RVA: 0x7FFAF4598680
        public void NackDisconnectMessage(){} // RVA: 0x7FFAF35433D0
        public void SendDisconnectMessage_0C935A47436A(){} // RVA: 0x7FFAF4598940
        public void OnEvent(){} // RVA: 0x7FFAF45989F0
        public void OnStatusChanged_2BCEC0F71386(){} // RVA: 0x7FFAF4599AE0
        public void set_atlasHeight(){} // RVA: 0x7FFAF4599B60
        public void OnDisconnectMessage(){} // RVA: 0x7FFAF4599C40
        public void set_categories(){} // RVA: 0x7FFAF2ADDC60
        public void OnOperationResponse_59D4F6048AE0(){} // RVA: 0x7FFAF2E0E900
        public void GetAt(){} // RVA: 0x7FFAF4598670
        public void DisconnectMessageTimeout(){} // RVA: 0x7FFAF4599D90
        public void OnStatusChanged(){} // RVA: 0x7FFAF4599DA0
        public void DisconnectMessageError(){} // RVA: 0x7FFAF459A6C0
        public void DisconnectMessageSuccess(){} // RVA: 0x7FFAF459A760
        public void DisconnectMessageFailed(){} // RVA: 0x7FFAF2E2B380
        public void OnMessage(){} // RVA: 0x7FFAF459A7F0
        public void .ctor(){} // RVA: 0x7FFAF459A850
        public void CtorB4166BA2026C(){} // RVA: 0x7FFAF459B950
        public void set_fallbackFontAssetTable(){} // RVA: 0x7FFAF459BD30
        public void InitPayloadEncryption(){} // RVA: 0x7FFAF459BD90
        public void SetDisconnectReason(){} // RVA: 0x7FFAF459BE90
        public void StartPickedUp(){} // RVA: 0x7FFAF459C030
        public void HasDisconnectReason(){} // RVA: 0x7FFAF459C2C0
        public void InitializeDisconnectMessage_23247CF540F5(){} // RVA: 0x7FFAF459C8F0
        public void AcceptDisconnectMessage_53FC416283ED(){} // RVA: 0x7FFAF45937F0
        public void ClearMessage(){} // RVA: 0x7FFAF3546DC0
        public void op_Equality_733FBDB8A934(){} // RVA: 0x7FFAF459CB50
        public void CreateHandle(){} // RVA: 0x7FFAF2DBB890
        public void FindObjectsByType_2152D4103C64(){} // RVA: 0x7FFAF2DB5200
        public void GetFileLineNumber(){} // RVA: 0x7FFAF35433D0
        public void AttachDisconnectMessageBody(){} // RVA: 0x7FFAF2E0E910
        public void OnDisconnectMessage_8D96C35D458B(){} // RVA: 0x7FFAF459CCE0
        public void get_pinkyTip(){} // RVA: 0x7FFAF459CD00
        public void Reset(){} // RVA: 0x7FFAF459CD10
        public void InitializeComponentProperties(){} // RVA: 0x7FFAF459CE30
        public void OnValidate(){} // RVA: 0x7FFAF459CE70
        public void GetBufferedTimes(){} // RVA: 0x7FFAF459CF70
        public void ConfigureAudioSource(){} // RVA: 0x7FFAF459CF90
        public void FollowTarget(){} // RVA: 0x7FFAF3853F70
        public void DebugReturn_A5E001CFC7A9(){} // RVA: 0x7FFAF3500BB0
        public void IndexOf(){} // RVA: 0x7FFAF459D2F0
        public void GetAt_B96AD169676C(){} // RVA: 0x7FFAF44EAF00
        public void GetPlatform(){} // RVA: 0x7FFAF2E08D60
        public void __OnPointerExit__UnityEngineEventSystemsPointerEventData__SystemVoid(){} // RVA: 0x7FFAF459D720
        public void UpdateUdonOperationResponseDisconnect(){} // RVA: 0x7FFAF459D740
        public void GetMaterial(){} // RVA: 0x7FFAF459D810
        public void SetAudioCaptureSourceD02B5BF54BB1(){} // RVA: 0x7FFAF459D820
        public void set_domainList(){} // RVA: 0x7FFAF459DA80
        public void DropdownValueChanged_56CA49515794(){} // RVA: 0x7FFAF459DA90
        public void ComputeNow(){} // RVA: 0x7FFAF459DB90
        public void get_AudioCaptureSource(){} // RVA: 0x7FFAF459DBB0
        public void set_UserId(){} // RVA: 0x7FFAF37A6DE0
        public void get_Plugins(){} // RVA: 0x7FFAF459DC70
        public void DebugReturn(){} // RVA: 0x7FFAF459E2B0
        public void SetGameObjectActive(){} // RVA: 0x7FFAF459E360
        public void GetRotation_6049CA097714(){} // RVA: 0x7FFAF459E370
        public void OnDisable0A17D448B2DB(){} // RVA: 0x7FFAF353E870
        // ── Unresolved (hash) ──
        public void m_C45(){} // RVA: 0x7FFAF4597880
    }

    /// <summary>Originally: ÏÎÏÌÌÏÍÏÏÌÌÍÏÌÌÏÏÌÍÎÌÎÏ</summary>
    public class UdonOperationResponseStatusChanged_6550_B67D
    {
        // ── Methods ──
        public void OnEvent(){} // RVA: 0x7FFAF3867050
        public void Initialize(){} // RVA: 0x7FFAF3867B90
        public void set_AudioCaptureSource(){} // RVA: 0x7FFAF3867BA0
        public void OnBecameInvisible(){} // RVA: 0x7FFAF3868350
        public void OnOperationResponse_91455EE05D0F(){} // RVA: 0x7FFAF3867B90
        public void NewImpulseEvent(){} // RVA: 0x7FFAF3868620
        public void OnStatusChanged_E28C1F6B7FB6(){} // RVA: 0x7FFAF38686B0
        public void get_customCaretColor(){} // RVA: 0x7FFAF3868740
        public void GetInstanceID(){} // RVA: 0x7FFAF3868C60
        public void .ctor(){} // RVA: 0x7FFAF3869410
        public void OnOperationResponse_91455EE05D0F_24B5880240E1(){} // RVA: 0x7FFAF3867B90
        public void .ctor_3DF02C4A926E(){} // RVA: 0x7FFAF38697E0
        public void OnStatusChanged(){} // RVA: 0x7FFAF3869AB0
        public void GetGameObject_A16(){} // RVA: 0x7FFAF3869C60
        public void OnEvent_2BCEC0F71386(){} // RVA: 0x7FFAF3869CB0
        public void OnOperationResponse(){} // RVA: 0x7FFAF3869D30
        public void Start(){} // RVA: 0x7FFAF3869E90
        public void GetCurrentTextCue(){} // RVA: 0x7FFAF3869F20
    }

    /// <summary>Originally: ÎÍÌÌÏÎÌÌÌÎÌÍÌÍÌÎÍÍÎÎÍÏÍ</summary>
    public class UdonUnregisterEventHandlerRegiSibling_220B
    {
        // ── Methods ──
        public void OnDestroy(){} // RVA: 0x7FFAF48C95E0
        public void LateUpdate(){} // RVA: 0x7FFAF48C9630
        public void get_Value(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Data(){} // RVA: 0x7FFAF2DBB0C0
        public void Cleanup(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF48C9AE0
        public void Initialize(){} // RVA: 0x7FFAF48C9D90
        public void LateUpdate_EB5AEEEC5C65(){} // RVA: 0x7FFAF48C9630
        public void GetEnabled(){} // RVA: 0x7FFAF48C9E30
        public void Awake(){} // RVA: 0x7FFAF48C9E90
        public void SetEnabled(){} // RVA: 0x7FFAF2D33FA0
        // ── Unresolved (hash) ──
        public void m_540(){} // RVA: 0x7FFAF48C9640
        public void m_217(){} // RVA: 0x7FFAF48C96C0
        public void m_EE8(){} // RVA: 0x7FFAF48C9700
        public void m_076(){} // RVA: 0x7FFAF48C9A90
        public void m_B05(){} // RVA: 0x7FFAF2DBB0C0
        public void m_A85(){} // RVA: 0x7FFAF48CA140
    }

    /// <summary>Originally: ÍÏÎÍÌÍÍÍÌÍÎÏÏÌÏÎÌÎÌÏÌÏÎ</summary>
    public class UdonUnregisterEventHandlerRegiSibling_581D
    {
        // ── Methods ──
        public void PushRegistration(){} // RVA: 0x7FFAF44792C0
        public void PushRegistration_A85E3366D41B(){} // RVA: 0x7FFAF4479300
        public void PopRegistration(){} // RVA: 0x7FFAF4479340
        public void PopRegistration_ABFF9B3C0B60(){} // RVA: 0x7FFAF4479470
        public void PopRegistration_4B5081F0CA0E(){} // RVA: 0x7FFAF4479490
        public void Update(){} // RVA: 0x7FFAF4479980
        public void GetEnabled(){} // RVA: 0x7FFAF4479AF0
        public void GetEnabled_874AAFB32E69(){} // RVA: 0x7FFAF4479B70
        public void GetEnabled_A660C4F07AE5(){} // RVA: 0x7FFAF4479BE0
        public void PushObject(){} // RVA: 0x7FFAF4479E60
        public void PushObject_B6CA7D3BAB0A(){} // RVA: 0x7FFAF447A120
        public void PopObject(){} // RVA: 0x7FFAF447A220
        public void PopObject_51088B8CD319(){} // RVA: 0x7FFAF447A340
        public void InitializeObjectRingBuffer(){} // RVA: 0x7FFAF447A3C0
        public void InitializeObjectRingBuffer_1559A13BB0C4(){} // RVA: 0x7FFAF447A400
        public void get_MoveNext(){} // RVA: 0x7FFAF2E0A740
        public void InitializeObjectRingBuffer_01868FB1F825(){} // RVA: 0x7FFAF447A520
        public void InitializeObjectRingBuffer_8F5499082328(){} // RVA: 0x7FFAF447A5C0
        public void SetCullingMode(){} // RVA: 0x7FFAF447A5D0
        public void GetEnabled_8C84D06B25F5(){} // RVA: 0x7FFAF4479B70
        public void PushObject_0882992F7E7E(){} // RVA: 0x7FFAF447A890
        public void PushObject_458CD4CD7705(){} // RVA: 0x7FFAF447A8B0
        public void PushObject_C8DB938D9608(){} // RVA: 0x7FFAF447AAD0
        public void PushObject_0882992F7E7E_D4692EACC094(){} // RVA: 0x7FFAF447A890
        public void PeekObject(){} // RVA: 0x7FFAF447ABF0
        public void .ctor(){} // RVA: 0x7FFAF447AD10
        public void Initialize(){} // RVA: 0x7FFAF447AE90
        public void GetEnabled_0B797D902B12(){} // RVA: 0x7FFAF447AF60
        public void SetCullingMode_BC21B0A1CDCA(){} // RVA: 0x7FFAF447AFA0
        public void ResetRegistrationCounters(){} // RVA: 0x7FFAF447B060
        public void OnDestroy(){} // RVA: 0x7FFAF447B1D0
        public void Start(){} // RVA: 0x7FFAF447B3A0
        public void SetCullingMode_96E0F8A62FB4(){} // RVA: 0x7FFAF447BAF0
    }

    /// <summary>Originally: ÏÍÌÏÎÌÏÎÍÌÍÎÍÍÌÍÏÏÍÎÏÏÍ</summary>
    public class UdonUnregisterEventHandlerRegisterEventHandl_2C20_C4A4
    {
        // ── Methods ──
        public void UpdateHandlerState(){} // RVA: 0x7FFAF3E50DD0
        public void DoPlay(){} // RVA: 0x7FFAF3E50FE0
        public void DoResetReplacementSha(){} // RVA: 0x7FFAF3E513F0
        public void .cctor_6E34DE1369F9(){} // RVA: 0x7FFAF3E51560
        public void ClearEventHandler(){} // RVA: 0x7FFAF3E51910
        public void FindGameObject_2808A5BB72DE(){} // RVA: 0x7FFAF3E519A0
        public void TryGetEventHandlerValue(){} // RVA: 0x7FFAF3E51C00
        public void ReadEventHandlerParticleLifetime(){} // RVA: 0x7FFAF3E522F0
        public void OnDestroy(){} // RVA: 0x7FFAF3E526D0
        public void GetUnityEngine(){} // RVA: 0x7FFAF3E52870
        public void UnregisterEventHandler_8748C656D770(){} // RVA: 0x7FFAF3E52C00
        public void UpdateMaterial(){} // RVA: 0x7FFAF3E52DC0
        public void UpdateProgress(){} // RVA: 0x7FFAF3E52E30
        public void UpdateAnimationProgress_E9B0BE4EC3CB(){} // RVA: 0x7FFAF3E5B580 | overloaded x2
        public void ApplyEventHandlerTextureOffset(){} // RVA: 0x7FFAF3E54550
        public void set_useGUILayout(){} // RVA: 0x7FFAF3E54600
        public void TriggerEvent_82644F5984DD(){} // RVA: 0x7FFAF3E55A10
        public void FindGameObject_2AE4CB47EB73(){} // RVA: 0x7FFAF3E55F00
        public void TriggerEvent(){} // RVA: 0x7FFAF3E56130
        public void FindGameObject(){} // RVA: 0x7FFAF3E592D0 | overloaded x2
        public void get_gameObject(){} // RVA: 0x7FFAF3E561F0
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAF3E566B0
        public void RegisterEventHandler_7036646E7670(){} // RVA: 0x7FFAF3E56A40
        public void UnregisterEventHandler(){} // RVA: 0x7FFAF3E56A90
        public void GetDescendants(){} // RVA: 0x7FFAF3E56BF0
        public void Initialize(){} // RVA: 0x7FFAF3E56F70
        public void DoPlay_E620599CA2A1(){} // RVA: 0x7FFAF3E56FD0
        public void MoveNext(){} // RVA: 0x7FFAF3E573B0
        public void RegisterEventHandler(){} // RVA: 0x7FFAF3E57410
        public void InternalGetHashCode(){} // RVA: 0x7FFAF3E574E0
        public void DoRange(){} // RVA: 0x7FFAF3E577D0
        public void FindEventHandlerTransform(){} // RVA: 0x7FFAF3E57EC0
        public void Instantiate(){} // RVA: 0x7FFAF3E580F0
        public void Awake(){} // RVA: 0x7FFAF3E58150
        public void ProcessHandlerTransform(){} // RVA: 0x7FFAF3E582F0
        public void SetEventHandlerValue(){} // RVA: 0x7FFAF3E583F0
        public void Awake_0F2372363034(){} // RVA: 0x7FFAF3E584F0
        public void GetGameObject(){} // RVA: 0x7FFAF3E58890
        public void ValidateEventHandler(){} // RVA: 0x7FFAF3E58D60
        public void RegisterEventHandler_3B3DD05CC0EE(){} // RVA: 0x7FFAF3E58ED0
        public void ParseStandardFormatOrThrow(){} // RVA: 0x7FFAF3E58EF0
        public void .ctor_D00AEE07A215(){} // RVA: 0x7FFAF3E59330
        public void .cctor(){} // RVA: 0x7FFAF3E597F0
        public void UnregisterPlay(){} // RVA: 0x7FFAF3E5A110
        public void UpdatePlay(){} // RVA: 0x7FFAF3E5A2D0
        public void UpdateEyeRotation(){} // RVA: 0x7FFAF3E5A580
        public void set_enabled_0758C5906E4D(){} // RVA: 0x7FFAF3E5C3B0 | overloaded x2
        public void GetGameObjectPath(){} // RVA: 0x7FFAF3E5ABD0
        public void OnDestroy_5BF8EC5D3803(){} // RVA: 0x7FFAF3E5AC20
        public void ProcessPlay(){} // RVA: 0x7FFAF3E5AD00
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void ProcessAsyncOperationData(){} // RVA: 0x7FFAF3E5B090
        public void InvokeEventHandler(){} // RVA: 0x7FFAF3E5BD80
        public void InterlockedUpdateAnotherStateField(){} // RVA: 0x7FFAF3E5C270
    }

}