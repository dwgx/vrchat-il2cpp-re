// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon
// Classes: 21
// Methods: 648

namespace VRC.Udon
{
    public class AbstractSerializedUdonProgramAsset : ScriptableObject
    {
        // ── Original Methods ──
        public void StoreProgram(){} // RVA: 0x7ffaa8669e70
        public void StoreProgram(){} // RVA: 0x7ffaa8669e70
        public void RetrieveProgram(){} // RVA: 0x7ffaa86491d0
        public void TryGetEntrypointNameFromHash(){}
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7ffaa864d540
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        // ── Binary Analysis Named ──
        public void GetSerializedProgramSize(){} // RVA: 0x7ffaa86491d0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7ffaa8649280
        public void GetNetworkCallingMetadata(){} // RVA: 0x7ffaa8649280
    }

    public class AbstractUdonBehaviourEventProxy : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_EventReceiver(){} // RVA: 0x7ffaa89600c0
        public void set_EventReceiver(){} // RVA: 0x7ffaa89600d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class AbstractUdonProgramSource : ScriptableObject
    {
        // ── Original Methods ──
        public void get_SerializedProgramAsset(){} // RVA: 0x7ffaa86491d0
        public void RunEditorUpdate(){} // RVA: 0x7ffaa8669e70
        public void RefreshProgram(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class IUdonTriggerEventConsumer
    {
        // ── Original Methods ──
        public void get_Priority(){} // RVA: 0x7ffaa8649ca0
        public void TryConsumeOnTriggerEnter(){} // RVA: 0x7ffaa864d540
        public void TryConsumeOnTriggerExit(){} // RVA: 0x7ffaa864d540
        public void TryConsumeOnTriggerStay(){} // RVA: 0x7ffaa864d540
    }

    public class OnAnimatorMoveProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Original Methods ──
        public void OnAnimatorMove(){} // RVA: 0x7ffaaf8abdb0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class OnAudioFilterReadProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Original Methods ──
        public void OnAudioFilterRead(){} // RVA: 0x7ffaaf8abe10
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class OnCollisionStayProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Original Methods ──
        public void OnCollisionStay(){} // RVA: 0x7ffaaf8abff0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class OnRenderObjectProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Original Methods ──
        public void OnRenderObject(){} // RVA: 0x7ffaaf8ac010
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class OnTriggerStayProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Original Methods ──
        public void OnTriggerStay(){} // RVA: 0x7ffaaf8ac070
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class OnWillRenderObjectProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Original Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7ffaaf8ac090
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class UdonBehaviour : AbstractUdonBehaviour
    {
        public object SynchronizeAnimation; // 0x31912000
        public object _syncMethod; // 0x31912000
        public object _requestSerializationHook; // 0x31912000, was: <RequestSerializationHook>k__B
        public object _disableEventProcessing; // 0x31912000, was: <DisableEventProcessing>k__Bac
        public object _program; // 0x31912000
        public object _categoryName; // 0x31912000
        public object _initialized; // 0x31912000
        public object _hasUpdateEvent; // 0x31912000
        public object _hasPostLateUpdateEvent; // 0x31912000
        public object _managedUpdateProfilerMarker; // 0x31912000
        public object _postLateUpdateProfilerMarker; // 0x31912000
        public object serializedPublicVariablesBytesString; // 0x31912000
        public object _preloadUdonProgramProfilerMarker; // 0x31912000
        public object 1; // 0x600357B

        // ── Original Methods ──
        public void get_SyncMethod(){} // RVA: 0x7ffaaf8ac0f0
        public void set_SyncMethod(){} // RVA: 0x7ffaaf8ac110
        public void get_HasDoneStart(){} // RVA: 0x7ffaa9839a00
        public void get_HasError(){} // RVA: 0x7ffaa98372b0
        public void get_SyncIsContinuous(){} // RVA: 0x7ffaaf8ac490
        public void get_SyncIsManual(){} // RVA: 0x7ffaaf8ac4c0
        public void get_OnInit(){} // RVA: 0x7ffaaf8ac4f0
        public void set_OnInit(){} // RVA: 0x7ffaaf8ac550
        public void get_RequestSerializationHook(){} // RVA: 0x7ffaaf8ac600
        public void set_RequestSerializationHook(){} // RVA: 0x7ffaaf8ac660
        public void get_DisableInteractive(){} // RVA: 0x7ffaa8b6c110
        public void set_DisableInteractive(){} // RVA: 0x7ffaa92bb760
        public void get_IsNetworkingSupported(){} // RVA: 0x7ffaae4e4820
        public void set_IsNetworkingSupported(){} // RVA: 0x7ffaaf8ac720
        public void get_IsInteractive(){} // RVA: 0x7ffaaf8ac790
        public void get_UpdateOrder(){} // RVA: 0x7ffaaf8ac7d0
        public void get_DisableEventProcessing(){} // RVA: 0x7ffaad109aa0
        public void set_DisableEventProcessing(){} // RVA: 0x7ffaae1d6c30
        public void get_ProgramId(){} // RVA: 0x7ffaaf8ac830
        public void get_ProgramSize(){} // RVA: 0x7ffaaf8ac920
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7ffaaf8acc30
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7ffaaf8acd90
        public void get_IsInitialized(){} // RVA: 0x7ffaae4e4810
        public void LoadProgram(){} // RVA: 0x7ffaaf8acf10
        public void RegisterEventProxy(){} // RVA: 0x7ffaa8660cc0
        public void ProcessEntryPoints(){} // RVA: 0x7ffaaf8ad4f0
        public void DetectExistingProxies(){} // RVA: 0x7ffaaf8ae100
        public void ResolveUdonHeapReferences(){} // RVA: 0x7ffaaf8ae3f0
        public void ResolveUdonHeapReference(){} // RVA: 0x7ffaaf8ae740
        public void ManagedUpdate(){} // RVA: 0x7ffaaf8aeb10
        public void ManagedLateUpdate(){} // RVA: 0x7ffaaf8aecc0
        public void ManagedFixedUpdate(){} // RVA: 0x7ffaaf8aede0
        public void PostLateUpdate(){} // RVA: 0x7ffaaf8aef00
        public void OnAnimatorIK(){} // RVA: 0x7ffaaf8af020
        public void ProxyOnAnimatorMove(){} // RVA: 0x7ffaaf8af170
        public void ProxyOnAudioFilterRead(){} // RVA: 0x7ffaaf8af1c0
        public void OnBecameInvisible(){} // RVA: 0x7ffaaf8af390
        public void OnBecameVisible(){} // RVA: 0x7ffaaf8af3e0
        public void OnCollisionEnter(){} // RVA: 0x7ffaaf8af430
        public void OnCollisionEnter2D(){} // RVA: 0x7ffaaf8af6a0
        public void OnCollisionExit(){} // RVA: 0x7ffaaf8af8a0
        public void OnCollisionExit2D(){} // RVA: 0x7ffaaf8afb10
        public void ProxyOnCollisionStay(){} // RVA: 0x7ffaaf8afd10
        public void OnCollisionStay2D(){} // RVA: 0x7ffaaf8aff80
        public void OnDestroy(){} // RVA: 0x7ffaaf8b0180
        public void OnDisable(){} // RVA: 0x7ffaaf8b0780
        public void OnDrawGizmos(){} // RVA: 0x7ffaaf8b07e0
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaaf8b0830
        public void OnEnable(){} // RVA: 0x7ffaaf8b0880
        public void OnJointBreak(){} // RVA: 0x7ffaaf8b08e0
        public void OnJointBreak2D(){} // RVA: 0x7ffaaf8b0a60
        public void OnMouseDown(){} // RVA: 0x7ffaaf8b0b80
        public void OnMouseDrag(){} // RVA: 0x7ffaaf8b0bd0
        public void OnMouseEnter(){} // RVA: 0x7ffaaf8b0c20
        public void OnMouseExit(){} // RVA: 0x7ffaaf8b0c70
        public void OnMouseOver(){} // RVA: 0x7ffaaf8b0cc0
        public void OnMouseUp(){} // RVA: 0x7ffaaf8b0d10
        public void OnMouseUpAsButton(){} // RVA: 0x7ffaaf8b0d60
        public void OnParticleCollision(){} // RVA: 0x7ffaaf8b0db0
        public void OnParticleTrigger(){} // RVA: 0x7ffaaf8b0f80
        public void OnPostRender(){} // RVA: 0x7ffaaf8b0fd0
        public void OnPreCull(){} // RVA: 0x7ffaaf8b1020
        public void OnPreRender(){} // RVA: 0x7ffaaf8b1070
        public void OnRenderImage(){} // RVA: 0x7ffaaf8b10c0
        public void ProxyOnRenderObject(){} // RVA: 0x7ffaaf8b1330
        public void OnTransformChildrenChanged(){} // RVA: 0x7ffaaf8b1380
        public void OnTransformParentChanged(){} // RVA: 0x7ffaaf8b13d0
        public void OnTriggerEnter(){} // RVA: 0x7ffaaf8b1420
        public void OnTriggerEnter2D(){} // RVA: 0x7ffaaf8b1810
        public void OnTriggerExit(){} // RVA: 0x7ffaaf8b1a10
        public void OnTriggerExit2D(){} // RVA: 0x7ffaaf8b1e00
        public void ProxyOnTriggerStay(){} // RVA: 0x7ffaaf8b2000
        public void OnTriggerStay2D(){} // RVA: 0x7ffaaf8b23f0
        public void OnControllerColliderHit(){} // RVA: 0x7ffaaf8b25f0
        public void OnValidate(){} // RVA: 0x7ffaaf8b2a80
        public void ProxyOnWillRenderObject(){} // RVA: 0x7ffaaf8b2ad0
        public void OnNetworkReady(){} // RVA: 0x7ffaaf8b2b20
        public void Interact(){} // RVA: 0x7ffaaf8b2b30
        public void OnDrop(){} // RVA: 0x7ffaaf8b2b80
        public void OnPickup(){} // RVA: 0x7ffaaf8b2bd0
        public void OnPickupUseDown(){} // RVA: 0x7ffaaf8b2c20
        public void OnPickupUseUp(){} // RVA: 0x7ffaaf8b2c70
        public void OnPreSerialization(){} // RVA: 0x7ffaaf8b2cc0
        public void OnPostSerialization(){} // RVA: 0x7ffaaf8b2e50
        public void OnDeserialization(){} // RVA: 0x7ffaaf8b30e0
        public void RunProgram(){} // RVA: 0x7ffaaf8b3470
        public void RunProgram(){} // RVA: 0x7ffaaf8b3470
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaf8b3b20
        public void DeserializePublicVariables(){} // RVA: 0x7ffaaf8b3b30
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaaf8b3fb0
        public void SerializePublicVariables(){} // RVA: 0x7ffaaf8b3fb0
        public void TryToInterrogateUdon(){} // RVA: 0x7ffaa887e5c0
        public void TryToInterrogateUdon(){} // RVA: 0x7ffaa887e5c0
        public void RunEvent(){} // RVA: 0x7ffaa8bfb5f0
        public void RunEventAdvanced(){} // RVA: 0x7ffaaf8b4400
        public void RunEvent(){} // RVA: 0x7ffaa8bfb5f0
        public void RunEventAdvanced(){} // RVA: 0x7ffaaf8b4400
        public void RunEvent(){} // RVA: 0x7ffaa8bfb5f0
        public void RunEventAdvanced(){} // RVA: 0x7ffaaf8b4400
        public void RunEvent(){} // RVA: 0x7ffaa8bfb5f0
        public void RunEventAdvanced(){} // RVA: 0x7ffaaf8b4400
        public void RunEvent(){} // RVA: 0x7ffaa8bfb5f0
        public void RunEventAdvanced(){} // RVA: 0x7ffaaf8b4400
        public void RunEvent(){} // RVA: 0x7ffaa8bfb5f0
        public void RunEventAdvanced(){} // RVA: 0x7ffaaf8b4400
        public void RunEvent(){} // RVA: 0x7ffaa8bfb5f0
        public void RunEventAdvanced(){} // RVA: 0x7ffaaf8b4400
        public void RunEvent(){} // RVA: 0x7ffaa8bfb5f0
        public void RunEventAdvanced(){} // RVA: 0x7ffaaf8b4400
        public void RunEvent(){} // RVA: 0x7ffaa8bfb5f0
        public void RunEventAdvanced(){} // RVA: 0x7ffaaf8b4400
        public void RunEvent(){} // RVA: 0x7ffaa8bfb5f0
        public void RunEventAdvanced(){} // RVA: 0x7ffaaf8b4400
        public void RunInputEvent(){} // RVA: 0x7ffaaf8b4740
        public void PreloadUdonProgram(){} // RVA: 0x7ffaaf8b4cd0
        public void SearchUdonInterface(){} // RVA: 0x7ffaa887e5c0
        public void InitializeUdonContent(){} // RVA: 0x7ffaaf8b4f30
        public void RunOnInit(){} // RVA: 0x7ffaaf8b57a0
        public void RegisterUpdate(){} // RVA: 0x7ffaaf8b5950
        public void UnregisterUpdate(){} // RVA: 0x7ffaaf8b5fe0
        public void SendCustomEvent(){} // RVA: 0x7ffaaf8b6500
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaaf8b6980
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaaf8b6980
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaaf8b6980
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaaf8b6980
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaaf8b6980
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaaf8b6980
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaaf8b6980
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaaf8b6980
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaaf8b6980
        public void RequestSerialization(){} // RVA: 0x7ffaaf8b6a10
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7ffaaf8b6ac0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7ffaaf8b6c40
        public void get_InteractionText(){} // RVA: 0x7ffaa8960130
        public void set_InteractionText(){} // RVA: 0x7ffaa8933e90
        public void get_SyncMetadataTable(){} // RVA: 0x7ffaaf8b6dd0
        public void TryGetProgramVariable(){} // RVA: 0x7ffaaf8b71e0
        public void TryGetProgramVariable(){} // RVA: 0x7ffaaf8b71e0
        public void AssignProgramAndVariables(){} // RVA: 0x7ffaaf8b7550
        public void .ctor(){} // RVA: 0x7ffaaf8b7600
        public void .cctor(){} // RVA: 0x7ffaaf8b7a10
        // ── Binary Analysis Named ──
        public void GetNetworkCallingMetadata(){} // RVA: 0x7ffaaf8acb20
        public void GetNetworkCallingMetadata(){} // RVA: 0x7ffaaf8acb20
        public void GetComponentIndexFixed(){} // RVA: 0x7ffaaf8aceb0
        public void GetPrograms(){} // RVA: 0x7ffaaf8b3a60
        public void GetEventParameterName(){} // RVA: 0x7ffaaf8b49e0
        public void GetProgramVariableType(){} // RVA: 0x7ffaaf8b6e30
        public void SetProgramVariable(){} // RVA: 0x7ffaaf8b6f40
        public void SetProgramVariable(){} // RVA: 0x7ffaaf8b6f40
        public void SetHeapVariable(){} // RVA: 0x7ffaa887e5c0
        public void GetProgramVariable(){} // RVA: 0x7ffaaf8b7080
        public void GetProgramVariable(){} // RVA: 0x7ffaaf8b7080
        public void SetupLogging(){} // RVA: 0x7ffaaf8b7410
    }

    /// <summary>Originally: ÏÎÏÎÎÌÎÍÍÏÍÏÎÌÎÏÏÏÎÎÏÌÌ</summary>
    public class UdonBehaviourResultBytes_5B9F : Object
    {
        public object _resultBytes; // 0x3402E090, was: ÎÎÌÎÎÏÌÎÏÍÌÏÎÍÏÎÏÌÌÎÎÏÎ
        public object _bytes; // 0x3402E090, was: <ÍÍÌÎÏÎÌÍÎÍÎÎÏÏÌÍÌÍÍÏÏÎÏ>k__Ba
        public object _ellSizet; // 0x3402E090, was: <ÌÏÌÎÍÎÌÎÍÌÎÎÎÎÍÍÏÍÌÌÍÎÌ>k__Ba

        // ── Original Methods ──
        public void CancelDownload(){} // RVA: 0x7ffaa8bf43d0
        public void .ctor(){} // RVA: 0x7ffaa8bf4440
        public void get_ResultBytes(){} // RVA: 0x7ffaa89600c0
        public void set_propagation(){} // RVA: 0x7ffaa898dce0
        public void set_UdonBehaviour(){} // RVA: 0x7ffaa89600d0
        public void get_UdonBehaviour(){} // RVA: 0x7ffaa89af740
        public void get_ErrorCode(){} // RVA: 0x7ffaa898dcd0
        public void set_element(){} // RVA: 0x7ffaa8bf45c0
        public void StartDownload(){} // RVA: 0x7ffaa8bf4620
        public void get_Result(){} // RVA: 0x7ffaa8bf4a20
        public void get_Error(){} // RVA: 0x7ffaa8960130
        public void set_Error(){} // RVA: 0x7ffaa8bf43d0
        public void set_Url(){} // RVA: 0x7ffaa895a200
        public void get_Url(){} // RVA: 0x7ffaa8bf45b0
        public void Destroy(){} // RVA: 0x7ffaa8bf4ad0
        public void RegisterOnDisconnected(){} // RVA: 0x7ffaa8933e90
        // ── Binary Analysis Named ──
        public void SetExecutionContextHelper(){} // RVA: 0x7ffaa89600d0
        public void SetOverlay(){} // RVA: 0x7ffaa895a200
        public void GetShapes(){} // RVA: 0x7ffaa8bf45b0
        public void GetMethod(){} // RVA: 0x7ffaa8960130
        public void GetInternalMethodName(){} // RVA: 0x7ffaa89af740
    }

    /// <summary>Originally: ÍÎÏÏÏÌÎÍÍÍÎÏÌÏÎÎÎÌÎÏÏÌÍ</summary>
    public class UdonClientStringDownloaderSibling_E952 : Object
    {
        public object _dlestring; // 0x34004640, was: ÎÍÌÍÏÏÎÌÏÎÏÌÌÎÎÌÏÍÌÏÎÌÍ
        public object _uRAonsDepthstring; // 0x34004640, was: ÏÏÍÌÍÎÌÍÍÎÍÌÎÎÍÍÏÍÎÏÎÏÍ
        public object f_B1B; // 0x17000AB7, was: ÏÌÌÎÎÎÏÌÎÍÎÏÌÏÏÏÌÏÎÏÎÍÏ

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaa128180
        public void IsNativeObjectAlive(){} // RVA: 0x7ffaaa128b50
        public void get_name(){} // RVA: 0x7ffaaa129380
        public void set_name(){} // RVA: 0x7ffaaa129b10
        public void Instantiate(){} // RVA: 0x7ffaaa129b90
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void DoCategoryIsDescribed(){} // RVA: 0x7ffaaa128040
        public void DoGetKernelThreadGroupSizes_473(){} // RVA: 0x7ffaaa1285a0
        public void DoGetKernelThreadGroupSizes_402(){} // RVA: 0x7ffaaa128690
        public void DoFindKernel_C6F(){} // RVA: 0x7ffaaa1288f0
        public void DoIsCreated_9F6(){} // RVA: 0x7ffaaa129300
    }

    /// <summary>Originally: ÍÏÍÌÎÏÍÎÌÍÌÏÌÎÎÌÎÌÏÌÌÏÏ</summary>
    public class UdonDisableEventProcessing_FF1E : AbstractUdonBehaviour
    {
        public object _flag; // 0x31A11BA0, was: <ÍÌÍÎÎÌÎÍÎÍÏÌÍÌÏÍÍÏÎÏÌÎÍ>k__Ba
        public object _burstManagedte; // 0x31A11BA0, was: <ÌÎÌÎÏÏÏÎÏÏÌÌÍÎÏÌÎÍÎÏÏÌÎ>k__Ba
        public object _disableInteractive; // 0x31A11BA0, was: ÍÎÌÌÎÏÏÍÏÏÏÍÌÎÍÌÎÍÍÎÌÌÌ

        // ── Original Methods ──
        public void RunInputEvent(){} // RVA: 0x7ffaa8bfab00
        public void RunEventAdvanced(){} // RVA: 0x7ffaa887e5c0
        public void RunEventAdvanced(){} // RVA: 0x7ffaa887e5c0
        public void RunEvent(){} // RVA: 0x7ffaa887e5c0
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8bfb870
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8bfb870
        public void Interact(){} // RVA: 0x7ffaa8932310
        public void get_DisableInteractive(){} // RVA: 0x7ffaa89edc00
        public void RunEventAdvanced(){} // RVA: 0x7ffaa887e5c0
        public void RunEventAdvanced(){} // RVA: 0x7ffaa887e5c0
        public void RunEvent(){} // RVA: 0x7ffaa887e5c0
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7ffaa8bfadc0
        public void set_InteractionText(){} // RVA: 0x7ffaa89ad740
        public void TryGetProgramVariable(){} // RVA: 0x7ffaa8bfb8b0
        public void set_imageUrl(){} // RVA: 0x7ffaa8af19e0
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8bfb870
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7ffaa8bfaf00
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8bfb870
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8bfb870
        public void get_IsNetworkingSupported(){} // RVA: 0x7ffaa8bfb090
        public void RunEventAdvanced(){} // RVA: 0x7ffaa887e5c0
        public void RequestSerialization(){} // RVA: 0x7ffaa8932310
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8bfb870
        public void set_SyncMetadataTable(){} // RVA: 0x7ffaa8af19e0
        public void get_SyncMetadataTable(){} // RVA: 0x7ffaa8bfb0e0
        public void set_DisableEventProcessing(){} // RVA: 0x7ffaa8bfb120
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7ffaa8bfb130
        public void set_SyncMethod(){} // RVA: 0x7ffaa8bfb270
        public void Submit(){} // RVA: 0x7ffaa89fa510
        public void RunProgram(){} // RVA: 0x7ffaa8bfb310
        public void set_DisableInteractive(){} // RVA: 0x7ffaa89edc10
        public void get_SyncMethod(){} // RVA: 0x7ffaa8b023d0
        public void RunEvent(){} // RVA: 0x7ffaa887e5c0
        public void RunEvent(){} // RVA: 0x7ffaa887e5c0
        public void RunEventAdvanced(){} // RVA: 0x7ffaa887e5c0
        public void RunEventAdvanced(){} // RVA: 0x7ffaa887e5c0
        public void get_InteractionText(){} // RVA: 0x7ffaa89ad730
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8bfb870
        public void RunEventAdvanced(){} // RVA: 0x7ffaa887e5c0
        public void RunEvent(){} // RVA: 0x7ffaa887e5c0
        public void RunEvent(){} // RVA: 0x7ffaa887e5c0
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8bfb870
        public void RunEventAdvanced(){} // RVA: 0x7ffaa887e5c0
        public void RunEvent(){} // RVA: 0x7ffaa887e5c0
        public void SendCustomEvent(){} // RVA: 0x7ffaa8bfb570
        public void RunEvent(){} // RVA: 0x7ffaa887e5c0
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7ffaa8bfb620
        public void set_IsNetworkingSupported(){} // RVA: 0x7ffaa8bfb660
        public void InitializeUdonContent(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8bfb670
        public void SendCustomNetworkEvent(){} // RVA: 0x7ffaa8bfb870
        public void TryGetProgramVariable(){} // RVA: 0x7ffaa8bfb8b0
        public void RunEventAdvanced(){} // RVA: 0x7ffaa887e5c0
        public void get_DisableEventProcessing(){} // RVA: 0x7ffaa8bfb9f0
        public void RunEvent(){} // RVA: 0x7ffaa887e5c0
        public void RunEvent(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetNetworkCallingMetadata(){} // RVA: 0x7ffaa89fa500
        public void GetPlaybackQualityStats(){} // RVA: 0x7ffaa8af68f0
        public void SetProgramVariable(){} // RVA: 0x7ffaa8bfb280
        public void GetNetworkCallingMetadata(){} // RVA: 0x7ffaa89fa500
        public void GetProgramVariable(){} // RVA: 0x7ffaa887e5c0
        public void GetProgramVariableType(){} // RVA: 0x7ffaa8bfae70
        public void SetProgramVariable(){} // RVA: 0x7ffaa8bfb280
        public void GetComponentIndexFixed(){} // RVA: 0x7ffaa8bfb4e0
        public void SetAndRegisterProperty(){} // RVA: 0x7ffaa8af19e0
        public void GetProgramVariable(){} // RVA: 0x7ffaa887e5c0
        // ── Obfuscated Methods ──
        public void m_17B(){} // RVA: 0x7ffaa8bfacd0
        public void m_AFC(){} // RVA: 0x7ffaa8bfaf80
        public void m_B1F(){} // RVA: 0x7ffaa89fa500
        public void m_025(){} // RVA: 0x7ffaa89fa500
        public void m_195(){} // RVA: 0x7ffaa8bfb1a0
        public void m_B8F(){} // RVA: 0x7ffaa89fa500
        public void m_7BF(){} // RVA: 0x7ffaa89fa500
        public void m_FF2(){} // RVA: 0x7ffaa8bfb390
    }

    public class UdonManager : MonoBehaviour
    {
        public object currentlyExecuting; // 0x31912CB0
        public object _udonBehaviourUpdateOrderComparer; // 0x31912CB0
        public object _sceneUdonBehaviourDirectories; // 0x31912CB0
        public object _updateUdonBehaviours; // 0x31912CB0
        public object _postLateUpdateUdonBehaviours; // 0x31912CB0
        public object _fixedUpdateUdonBehavioursRegistrationQueue; // 0x31912CB0
        public object _inputUdonBehaviours; // 0x31912CB0
        public object UDON_EVENT_ONPLAYERDATAUPDATED; // 0x31912CB0
        public object UDON_EVENT_ONDESERIALIZATION; // 0x31912CB0
        public object UDON_EVENT_ONPOSTSERIALIZATION; // 0x31912CB0
        public object UDON_EVENT_ONPLAYERDATASTORAGEEXCEEDED; // 0x31912CB0
        public object UDON_EVENT_ONPLAYEROBJECTSTORAGEWARNING; // 0x31912CB0
        public object _inputActionNames; // 0x31912CB0
        public object UDON_INPUT_GRAB; // 0x31912CB0
        public object UDON_MOVE_HORIZONTAL; // 0x31912CB0
        public object UDON_EVENT_ONINPUTMETHODCHANGED; // 0x31912CB0
        public object _udonTimeSource; // 0x31912CB0
        public object _udonEventScheduler; // 0x31912CB0
        public object _signatureVerificationSkipped; // 0x31912CB0
        public object _verificationCache; // 0x31912CB0
        public object _initializeProfilerMarker; // 0x31912CB0
        public object Compare; // 0xB41F4A50

        // ── Original Methods ──
        public void add_OnUdonProgramLoaded(){} // RVA: 0x7ffaaf8b7d00
        public void remove_OnUdonProgramLoaded(){} // RVA: 0x7ffaaf8b7e60
        public void add_OnUdonReady(){} // RVA: 0x7ffaaf8b7fc0
        public void remove_OnUdonReady(){} // RVA: 0x7ffaaf8b8110
        public void get_HasLoaded(){} // RVA: 0x7ffaa8b0edb0
        public void set_HasLoaded(){} // RVA: 0x7ffaa96574d0
        public void get_Instance(){} // RVA: 0x7ffaaf8b8260
        public void get_SignatureVerificationFailed(){} // RVA: 0x7ffaa906c660
        public void get_SignatureVerificationSuccess(){} // RVA: 0x7ffaa9d2b2b0
        public void get_SignatureVerificationSkipped(){} // RVA: 0x7ffaa90bdfd0
        public void get_WorldSignatureVerificationEnabled(){} // RVA: 0x7ffaaa1c2fe0
        public void set_WorldSignatureVerificationEnabled(){} // RVA: 0x7ffaaa1c2ff0
        public void ResetWorldSignatureVerification(){} // RVA: 0x7ffaaf8b82c0
        public void EnableWorldSignatureVerification(){} // RVA: 0x7ffaaf8b8330
        public void RegisterTriggerEventConsumer(){} // RVA: 0x7ffaaf8b83f0
        public void UnregisterTriggerEventConsumer(){} // RVA: 0x7ffaaf8b8610
        public void TryNotifyOnTriggerEnterConsumers(){} // RVA: 0x7ffaaf8b8680
        public void TryNotifyOnTriggerExitConsumers(){} // RVA: 0x7ffaaf8b8820
        public void TryNotifyOnTriggerStayConsumers(){} // RVA: 0x7ffaaf8b89c0
        public void Awake(){} // RVA: 0x7ffaaf8b8b60
        public void Update(){} // RVA: 0x7ffaaf8b9470
        public void LateUpdate(){} // RVA: 0x7ffaaf8b9b20
        public void FixedUpdate(){} // RVA: 0x7ffaaf8ba160
        public void PostLateUpdate(){} // RVA: 0x7ffaaf8ba7a0
        public void OnDestroy(){} // RVA: 0x7ffaaf8baea0
        public void RegisterInput(){} // RVA: 0x7ffaaf8bb010
        public void RunInputAction(){} // RVA: 0x7ffaaf8bb0f0
        public void UpdateInputQueue(){} // RVA: 0x7ffaaf8bb430
        public void get_IsSceneLoading(){} // RVA: 0x7ffaa96c9090
        public void set_IsSceneLoading(){} // RVA: 0x7ffaa96c8b10
        public void OnSceneLoaded(){} // RVA: 0x7ffaaf8bb810
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7ffaaf8bcd70
        public void ProcessUdonProgram(){} // RVA: 0x7ffaaf8bced0
        public void OnSceneUnloaded(){} // RVA: 0x7ffaaf8bcf50
        public void PurgeSerializationCaches(){} // RVA: 0x7ffaaf8bcfc0
        public void RegisterUdonBehaviourUpdate(){} // RVA: 0x7ffaaf8bde40
        public void RegisterUdonBehaviourLateUpdate(){} // RVA: 0x7ffaaf8bdf20
        public void RegisterUdonBehaviourFixedUpdate(){} // RVA: 0x7ffaaf8be000
        public void RegisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7ffaaf8be0e0
        public void UnregisterUdonBehaviourUpdate(){} // RVA: 0x7ffaaf8be220
        public void UnregisterUdonBehaviourLateUpdate(){} // RVA: 0x7ffaaf8be300
        public void UnregisterUdonBehaviourFixedUpdate(){} // RVA: 0x7ffaaf8be3e0
        public void UnregisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7ffaaf8be4c0
        public void ScheduleDelayedEvent(){} // RVA: 0x7ffaaf8be690
        public void ScheduleDelayedEvent(){} // RVA: 0x7ffaaf8be690
        public void HandleUdonEventScheduled(){} // RVA: 0x7ffaaf8be780
        public void IncrementDepthCount(){} // RVA: 0x7ffaaf8be800
        public void DecrementDepthCount(){} // RVA: 0x7ffaaf8be910
        public void get_DebugLogging(){} // RVA: 0x7ffaaf8be9d0
        public void set_DebugLogging(){} // RVA: 0x7ffaaf8bea20
        public void ConstructUdonVM(){} // RVA: 0x7ffaaf8bea90
        public void ApplyFilter(){} // RVA: 0x7ffaaf8bebe0
        public void Blacklist(){} // RVA: 0x7ffaaf8beb60
        public void Blacklist(){} // RVA: 0x7ffaaf8beb60
        public void ApplyFilter(){} // RVA: 0x7ffaaf8bebe0
        public void CleanBlacklist(){} // RVA: 0x7ffaaf8bec40
        public void IsBlacklisted(){} // RVA: 0x7ffaa887e5c0
        public void IsBlacklisted(){} // RVA: 0x7ffaa887e5c0
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7ffaaf8becf0
        public void get_LightReservedLayerMask(){} // RVA: 0x7ffaaf8bed50
        public void set_LightReservedLayerMask(){} // RVA: 0x7ffaaf8bedb0
        public void RegisterUdonBehaviour(){} // RVA: 0x7ffaaf8bee60
        public void UnregisterUdonBehaviour(){} // RVA: 0x7ffaaf8bf180
        public void RunEvent(){} // RVA: 0x7ffaaf8c0820
        public void RunEvent(){} // RVA: 0x7ffaaf8c0820
        public void RunEvent(){} // RVA: 0x7ffaaf8c0820
        public void RunEvent(){} // RVA: 0x7ffaaf8c0820
        public void RunEvent(){} // RVA: 0x7ffaaf8c0820
        public void RunEvent(){} // RVA: 0x7ffaaf8c0820
        public void RunEvent(){} // RVA: 0x7ffaaf8c0820
        public void RunEvent(){} // RVA: 0x7ffaaf8c0820
        public void RunEvent(){} // RVA: 0x7ffaaf8c0820
        public void RunEvent(){} // RVA: 0x7ffaaf8c0820
        public void .ctor(){} // RVA: 0x7ffaaf8c0aa0
        public void .cctor(){} // RVA: 0x7ffaaf8c19f0
        public void <OnSceneLoaded>b__102_0(){} // RVA: 0x7ffaaf8c1ab0
        // ── Binary Analysis Named ──
        public void GetWrapperModule(){} // RVA: 0x7ffaa887e5c0
        public void GetTotalLoadedProgramSize(){} // RVA: 0x7ffaaf8bd130
        public void GetLoadedBehavioursSyncTypes(){} // RVA: 0x7ffaaf8bd8d0
        public void SetUdonEnabled(){} // RVA: 0x7ffaa9dde1d0
        public void GetWrapper(){} // RVA: 0x7ffaaf8bee10
        public void CheckUdonBehavioursToRegister(){} // RVA: 0x7ffaaf8bf2f0
        public void GetUdonBehavioursInScene(){} // RVA: 0x7ffaaf8bf420
    }

    /// <summary>Originally: ÏÌÏÌÌÎÎÌÍÎÎÏÎÍÏÎÏÎÏÎÍÎÌ</summary>
    public class UdonOperationResponseDiscRelated_E747 : Object
    {
        public object _ref; // 0x33FADA20, was: <ÏÍÎÌÎÎÌÍÎÎÏÏÍÌÎÌÍÎÎÌÌÌÎ>k__Ba

        // ── Original Methods ──
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7ffaa89fc5f0
        public void ToString(){} // RVA: 0x7ffaa9f87af0
        public void RegisterOnDisconnected(){} // RVA: 0x7ffaa8933e90
        public void get_name(){} // RVA: 0x7ffaa89fc5f0
        public void .ctor(){} // RVA: 0x7ffaa9f884c0
        public void Initialize(){} // RVA: 0x7ffaa89600c0
        public void Instantiate(){} // RVA: 0x7ffaa9f880c0
        public void Equals(){} // RVA: 0x7ffaa89fc5e0
        public void Destroy(){} // RVA: 0x7ffaa89600d0
        public void .ctor(){} // RVA: 0x7ffaa9f884c0
        public void DestroyImmediate(){} // RVA: 0x7ffaa89fc5f0
        public void FindObjectsOfType(){} // RVA: 0x7ffaa8960130
        public void CopyResponseFields(){} // RVA: 0x7ffaa9f884d0
        public void FindObjectsByType(){} // RVA: 0x7ffaa89357c0
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa8960890
        public void GetHashCode(){} // RVA: 0x7ffaa89600d0
        public void GetIsPlaying_047(){} // RVA: 0x7ffaa9f87db0
        public void GetCachedPtr(){} // RVA: 0x7ffaa89600c0
        public void GetMethod(){} // RVA: 0x7ffaa8960130
        public void SetMessage(){} // RVA: 0x7ffaa8998e80
        public void GetHashCode(){} // RVA: 0x7ffaa89600d0
        public void GetHashCode(){} // RVA: 0x7ffaa89600d0
        public void CheckUdonOperationConditions(){} // RVA: 0x7ffaa9f883b0
        public void GetFileName(){} // RVA: 0x7ffaa8bfcc80
        public void SetInternalValue(){} // RVA: 0x7ffaa8998e80
        // ── Obfuscated Methods ──
        public void m_B0E(){} // RVA: 0x7ffaa89600c0
    }

    /// <summary>Originally: ÍÌÎÍÏÍÌÌÍÎÏÏÏÌÌÍÍÏÎÏÍÌÍ</summary>
    public class UdonOperationResponseDisconnecSibling_845A : Object
    {
        public object _text; // 0x33FBE170, was: <ÏÍÎÌÎÍÎÎÍÌÍÌÎÌÏÍÌÏÎÌÏÍÎ>k__Ba
        public object _845A; // 0x17000877, was: ÏÌÌÍÌÏÌÎÌÍÌÎÏÍÌÎÍÏÎÏÌÍÌ

        // ── Original Methods ──
        public void get_ValueToAppear(){} // RVA: 0x7ffaa894d4e0
        public void Equals(){} // RVA: 0x7ffaa894d4f0
        public void op_Implicit(){} // RVA: 0x7ffaa89600c0
        public void Initialize(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_name(){} // RVA: 0x7ffaa8933e30
        public void set_name(){} // RVA: 0x7ffaa9f9cf20
        public void Instantiate(){} // RVA: 0x7ffaa894d380
        public void ToString(){} // RVA: 0x7ffaa9f9cf40
        public void IsDisconnected(){} // RVA: 0x7ffaa9f9d030
        // ── Binary Analysis Named ──
        public void SetReadOnlyState(){} // RVA: 0x7ffaa894d4f0
        public void GetCachedPtr(){} // RVA: 0x7ffaa894d4e0
        public void GetHashCode(){} // RVA: 0x7ffaa8933e30
        public void SetExecutionContextHelper(){} // RVA: 0x7ffaa89600d0
        // ── Obfuscated Methods ──
        public void m_2C1(){} // RVA: 0x7ffaa89600c0
        public void m_841(){} // RVA: 0x7ffaa894d380
    }

    /// <summary>Originally: ÍÏÏÌÎÌÏÍÎÍÌÏÎÌÍÎÍÍÍÍÌÏÍ</summary>
    public class UdonOperationResponseDisconnecSibling_BE91 : Object
    {
        public object _objectIsNullMessage; // 0x35D7B940, was: <ÏÍÌÎÎÍÏÍÎÍÎÎÎÍÍÍÌÎÍÏÌÏÍ>k__Ba

        // ── Original Methods ──
        public void RegisterOnDisconnected(){} // RVA: 0x7ffaa8933e90
        public void op_Implicit(){} // RVA: 0x7ffaa8933e90
        public void CompareBaseObjects(){} // RVA: 0x7ffaa89600c0
        public void set_name(){} // RVA: 0x7ffaaa2a4810
        public void Init(){} // RVA: 0x7ffaa89350c0
        public void Instantiate(){} // RVA: 0x7ffaa89350c0
        public void Equals(){} // RVA: 0x7ffaa89600d0
        public void ToString(){} // RVA: 0x7ffaa89357c0
        public void RegisterOnDisconnectedCallback(){} // RVA: 0x7ffaaa2a48c0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetInstanceID(){} // RVA: 0x7ffaa89357c0
        public void GetHashCode(){} // RVA: 0x7ffaa897f5c0
        public void SetMessage(){} // RVA: 0x7ffaa8998e80
        public void GetCachedPtr(){} // RVA: 0x7ffaa89600c0
        public void GetMethod(){} // RVA: 0x7ffaa8960130
        public void SetExecutionContextHelper(){} // RVA: 0x7ffaa89600d0
        public void GetOperationId(){} // RVA: 0x7ffaa897f5c0
        public void SetDisconnectedHandler(){} // RVA: 0x7ffaa8933e90
    }

    /// <summary>Originally: ÏÌÎÌÌÍÌÎÎÏÌÍÍÍÏÌÍÍÍÎÏÏÌ</summary>
    public class UdonOperationResponseDisconnectMessage_E05D : Object
    {
        public object _camera; // 0x31A29020, was: ÍÏÏÏÌÎÍÏÎÌÏÎÎÏÍÎÏÌÎÌÌÏÎ
        public object _name; // 0x31A29020, was: <ÎÎÌÎÌÏÍÍÏÏÏÌÌÏÍÌÌÍÍÍÌÏÏ>k__Ba
        public object f_0A3; // 0x31A29020, was: ÍÌÌÌÏÏÍÏÎÍÍÏÏÎÏÍÏÎÌÎÍÏÍ
        public object _text; // 0x31A29020, was: <ÌÏÎÏÏÏÏÌÍÌÍÌÌÍÏÍÎÌÏÏÎÍÌ>k__Ba
        public object f_7B6; // 0x31A29020, was: <ÍÏÏÌÍÌÎÎÌÏÍÌÏÌÏÎÍÍÎÏÏÍÍ>k__Ba
        public object _vector; // 0x31A29020, was: ÌÍÌÏÍÍÎÍÍÏÎÏÌÌÍÎÍÏÌÍÎÏÍ
        public object _vector2; // 0x31A29020, was: ÌÏÌÌÌÌÌÎÍÏÎÎÏÎÌÎÌÎÍÌÏÏÌ
        public object f_3E8; // 0x31A29020, was: ÍÏÎÍÌÍÍÍÎÏÌÍÏÎÏÍÏÍÎÌÎÌÏ
        public object f_E83; // 0x31A29020, was: <ÍÎÌÌÍÎÎÌÍÎÌÍÌÍÌÎÌÎÎÍÍÎÌ>k__Ba
        public object f_E5C; // 0x31A29020, was: ÌÍÌÏÎÌÌÏÍÍÌÍÎÍÏÎÏÍÍÍÌÍÌ
        public object f_C2E; // 0x31A29020, was: <ÌÌÏÎÌÍÌÏÎÌÎÏÏÏÎÏÌÎÍÎÏÌÍ>k__Ba
        public object _value; // 0x31A29020, was: <ÎÎÌÎÌÍÍÏÏÏÎÌÍÍÎÍÍÌÌÏÏÍÍ>k__Ba
        public object _easeOut; // 0x31A29020, was: ÏÎÎÎÎÎÎÍÏÏÌÏÌÍÏÍÏÍÌÍÎÍÎ
        public object _text2; // 0x31A29020, was: <ÏÎÌÏÍÌÎÎÍÍÏÌÍÏÌÌÎÎÏÏÍÏÎ>k__Ba
        public object _uRAge; // 0x31A29020, was: ÌÏÌÍÍÍÍÎÍÎÌÏÍÍÎÍÏÍÎÍÎÍÏ
        public object f_5B9; // 0x31A29020, was: ÎÌÏÎÌÎÍÎÍÍÎÏÌÍÎÍÍÌÍÌÎÌÌ
        public object f_9EF; // 0xB2EF62C0, was: ÍÍÏÌÏÏÎÌÏÍÍÏÍÏÌÏÏÌÎÍÏÍÏ

        // ── Original Methods ──
        public void ConfigureItem(){} // RVA: 0x7ffaa9fb1720
        public void Equals(){} // RVA: 0x7ffaa9fb1a40
        public void DropdownValueChanged(){} // RVA: 0x7ffaa9fb1a60
        public void CompareBaseObjects(){} // RVA: 0x7ffaa9fb1a80
        public void OnStatusChanged(){} // RVA: 0x7ffaa9fb2160
        public void set_name(){} // RVA: 0x7ffaa9fb2a80
        public void Instantiate(){} // RVA: 0x7ffaa9fb3710
        public void get_EffectiveUnmappedMemberHandling(){} // RVA: 0x7ffaa936f8e0
        public void ToString(){} // RVA: 0x7ffaa9fb3760
        public void ConfigureUploadStream(){} // RVA: 0x7ffaa9fb3780
        public void UpdateUdonOperationStatus(){} // RVA: 0x7ffaa9fb3b30
        public void set_domainList(){} // RVA: 0x7ffaa89b3910
        public void FindObjectsByType(){} // RVA: 0x7ffaa9fb4440
        public void FindObjectsOfType(){} // RVA: 0x7ffaa9fb42b0
        public void IsConnectionActive(){} // RVA: 0x7ffaa9fb4420
        public void FindObjectsByType(){} // RVA: 0x7ffaa9fb4440
        public void ProcessDisconnectMessageFields(){} // RVA: 0x7ffaa9fb4450
        public void set_atlasWidth(){} // RVA: 0x7ffaa9fb4830
        public void DispatchOnJoinedRoom(){} // RVA: 0x7ffaa9fb4840
        public void OnEvent(){} // RVA: 0x7ffaa9fb4e70
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7ffaa9fb71f0
        public void get_LogLevel(){} // RVA: 0x7ffaa9fb62b0
        public void get_hierarchyVersion(){} // RVA: 0x7ffaa90bdfd0
        public void FindObjectOfType(){} // RVA: 0x7ffaa9fb62d0
        public void FindFirstObjectByType(){} // RVA: 0x7ffaa9fb62e0
        public void op_Equality(){} // RVA: 0x7ffaa9fb6890
        public void get_Module(){} // RVA: 0x7ffaa9e4c9c0
        public void get_atlasHeight(){} // RVA: 0x7ffaa9fb71c0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7ffaa9fb71d0
        public void get_categories(){} // RVA: 0x7ffaa8f205f0
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7ffaa9fb71f0
        public void HasAttachedController(){} // RVA: 0x7ffaa9fb72e0
        public void DebugReturn(){} // RVA: 0x7ffaa9fb72f0
        public void set_focusController(){} // RVA: 0x7ffaa93f4640
        public void set_categories(){} // RVA: 0x7ffaa8f20bd0
        public void ProcessUdonMessageAndSetProperty(){} // RVA: 0x7ffaa9fb73a0
        public void ComputePeerState(){} // RVA: 0x7ffaa9fb7480
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7ffaa9fb74e0
        public void ReadDisconnectParameter(){} // RVA: 0x7ffaa9fb7610
        public void ForwardEventToChildHandler(){} // RVA: 0x7ffaa9fb7870
        public void IsStateLoadedWithData(){} // RVA: 0x7ffaa9fb7900
        public void set_fallbackFontAssetTable(){} // RVA: 0x7ffaa9101830
        public void OnStatusChanged_impl(){} // RVA: 0x7ffaa9fb7ab0
        public void InitPayloadEncryption(){} // RVA: 0x7ffaa8efece0
        public void ApplyUdonOperationStatus(){} // RVA: 0x7ffaa9fb7bd0
        public void set_recommendedCapacity(){} // RVA: 0x7ffaa9fb8260
        public void OnOperationResponse_impl(){} // RVA: 0x7ffaa9fb8370
        public void set_atlasHeight(){} // RVA: 0x7ffaa9fb8400
        public void get_fallbackFontAssetTable(){} // RVA: 0x7ffaa8f76810
        public void ConfigureRedirectUri(){} // RVA: 0x7ffaa9fb8600
        public void get_displayDelay(){} // RVA: 0x7ffaa9fb8830
        public void ConfigureEventFromPayload(){} // RVA: 0x7ffaa9fb9000
        public void ProcessAndClearState(){} // RVA: 0x7ffaa9fb9630
        public void get_atlasWidth(){} // RVA: 0x7ffaa9fb9680
        public void ApplyConnectionModeAndInvokeVirtual(){} // RVA: 0x7ffaa9fb9690
        public void OnOperationResponse(){} // RVA: 0x7ffaa9fb9830
        public void IsOperationCodeHandled(){} // RVA: 0x7ffaa9fbb960
        public void HandleDisconnectConfirmation(){} // RVA: 0x7ffaa9fbbac0
        public void set_NumberOfRequiredProperties(){} // RVA: 0x7ffaa8fb82c0
        public void InitializeAndProcessUdonData(){} // RVA: 0x7ffaa9fbbd40
        public void set_trackerAnchor(){} // RVA: 0x7ffaa89d0380
        public void OnEvent_impl(){} // RVA: 0x7ffaa9fbc080
        public void SerializeEventFields(){} // RVA: 0x7ffaa9fbc1e0
        public void HandleDisconnectResponse(){} // RVA: 0x7ffaa9fbc8a0
        public void get_domainList(){} // RVA: 0x7ffaa89b3900
        public void ConfigureAndRegisterPropertyUpdate(){} // RVA: 0x7ffaa9fbcf20
        public void TryDeserializeEventPayload(){} // RVA: 0x7ffaa9fbcff0
        public void ConfigureAndRegisterErrorProperty(){} // RVA: 0x7ffaa9fbd590
        public void OnDisconnectMessage(){} // RVA: 0x7ffaa9fbd660
        public void OnDisconnectStub(){} // RVA: 0x7ffaa8932310
        public void set_EffectiveUnmappedMemberHandling(){} // RVA: 0x7ffaa9fbd7b0
        public void InitializeAndCheckUdonState(){} // RVA: 0x7ffaa9fbd800
        public void TransitionStateByConnectionLevel(){} // RVA: 0x7ffaa9fbde90
        public void get_InnerObjectFlags(){} // RVA: 0x7ffaa9f17340
        public void OnMessage(){} // RVA: 0x7ffaa9fbdf50
        public void HandleUdonOperationCallback(){} // RVA: 0x7ffaa9fbdfb0
        public void set_InnerObjectFlags(){} // RVA: 0x7ffaa9fbe2f0
        public void ComputeElapsedMilliseconds(){} // RVA: 0x7ffaa9fbe410
        public void ProcessUdonMessageData(){} // RVA: 0x7ffaa9fbe4a0
        public void IsStateInteractive(){} // RVA: 0x7ffaa9fbe7a0
        public void get_InnerObject(){} // RVA: 0x7ffaa894d380
        public void ProcessDisconnectMessageDetails(){} // RVA: 0x7ffaa9fbe7f0
        public void InitializeAndFillUdonResponse(){} // RVA: 0x7ffaa9fbe980
        public void Configureright(){} // RVA: 0x7ffaa9fbec20
        public void InvokeDelegateWithArgs(){} // RVA: 0x7ffaa8669e70
        public void get_ExtendedDataReference(){} // RVA: 0x7ffaa8f76810
        public void ProcessDisconnectRequest(){} // RVA: 0x7ffaa9fbef80
        public void HasActiveTimerReference(){} // RVA: 0x7ffaa9fbf0e0
        public void UpdateResponseCounterOffset(){} // RVA: 0x7ffaa9fbf0f0
        public void ProcessDisconnectAcknowledgment(){} // RVA: 0x7ffaa9fbf1c0
        public void ProcessUdonDisconnectData(){} // RVA: 0x7ffaa9fbf350
        public void .ctor(){} // RVA: 0x7ffaa9fbf780
        public void Initialize(){} // RVA: 0x7ffaa9fc0840
        public void set_InnerByteProperty(){} // RVA: 0x7ffaa9fc0910
        // ── Binary Analysis Named ──
        public void GetStatus(){} // RVA: 0x7ffaa9fb1a70
        public void SetMessageCtrl(){} // RVA: 0x7ffaa89add60
        public void GetActiveInHierarchy_790(){} // RVA: 0x7ffaa9fb2090
        public void GetHashCode(){} // RVA: 0x7ffaa8fb82b0
        public void GetTransform_834(){} // RVA: 0x7ffaa9fb3020
        public void GetInternalMethodName(){} // RVA: 0x7ffaa89af740
        public void SetAndComparePropertyConcurrency(){} // RVA: 0x7ffaa9fb3d30
        public void DoAcquire(){} // RVA: 0x7ffaa9fb3e30
        public void GetDeltaTime_1CC(){} // RVA: 0x7ffaa9fb3fd0
        public void GetDeltaTime_D22(){} // RVA: 0x7ffaa9fb4050
        public void SetAndComparePropertyConcurrencyReload(){} // RVA: 0x7ffaa9fb3710
        public void DoAdd(){} // RVA: 0x7ffaa9fb5e80
        public void SetOverlay(){} // RVA: 0x7ffaa895a200
        public void CheckNullArgument(){} // RVA: 0x7ffaa9fb6270
        public void GetTransform_E32(){} // RVA: 0x7ffaa9fb6990
        public void GetFileName(){} // RVA: 0x7ffaa8bfcc80
        public void SetStoreCallback(){} // RVA: 0x7ffaa8960890
        public void CheckAndSendDisconnectMessage(){} // RVA: 0x7ffaa9fb7890
        public void CheckDisconnectMessageValidity(){} // RVA: 0x7ffaa9fb7920
        public void GetSource(){} // RVA: 0x7ffaa8f7aa40
        public void GetMaterial(){} // RVA: 0x7ffaa89add50
        public void GetAttachedComponentValue(){} // RVA: 0x7ffaa9fb7e00
        public void DoCreateThis(){} // RVA: 0x7ffaa9fb7e20
        public void SetAndComparePropertyConcurrencyOptimized(){} // RVA: 0x7ffaa9fb8270
        public void GetTransform_355(){} // RVA: 0x7ffaa9fb8840
        public void GetIsPlaying_549(){} // RVA: 0x7ffaa9fb9730
        public void DoGetTypeFromHandle(){} // RVA: 0x7ffaa9fbb320
        public void GetTargets(){} // RVA: 0x7ffaa89d0370
        public void GetDisconnectReasonCode(){} // RVA: 0x7ffaa9fbca40
        public void SetAndComparePropertyConcurrencyPath(){} // RVA: 0x7ffaa9fbcbb0
        public void DoInternal_FromEulerRad_Injected_58F(){} // RVA: 0x7ffaa9fbccb0
        public void GetCurrentTextCue(){} // RVA: 0x7ffaa8d1a3b0
        public void DoInternal_FromEulerRad_Injected_05D(){} // RVA: 0x7ffaa9fbcdb0
        public void CheckAndProcessDisconnectReason(){} // RVA: 0x7ffaa9fbd4d0
        public void SetStateAndNotifyListener(){} // RVA: 0x7ffaa9fbd7c0
        public void DoInverse_Injected_B5D(){} // RVA: 0x7ffaa9fbdc30
        public void SetAndComparePropertyConcurrencyPathOptimized(){} // RVA: 0x7ffaa9fbe310
        public void SetAndComparePropertyConcurrencyPathReload(){} // RVA: 0x7ffaa9fbea00
        public void DoClosestPoint_Injected_5A1(){} // RVA: 0x7ffaa9fbeb00
        public void GetActiveListenerData(){} // RVA: 0x7ffaa9fbf180
        public void DoClosestPoint_Injected_4A8(){} // RVA: 0x7ffaa9fbf5e0
        public void DoClosestPoint_Injected_101(){} // RVA: 0x7ffaa9fbf700
        public void GetNestedComponentReference(){} // RVA: 0x7ffaa9fc08e0
        // ── Obfuscated Methods ──
        public void m_38B(){} // RVA: 0x7ffaa9fb8410
        public void m_38B(){} // RVA: 0x7ffaa9fb8410
        public void m_FE2(){} // RVA: 0x7ffaa9fb8500
        public void m_BAE(){} // RVA: 0x7ffaa9fb8da0
    }

    /// <summary>Originally: ÏÌÎÎÍÍÌÍÎÎÏÌÏÏÌÌÌÍÎÏÎÌÍ</summary>
    public class UdonOperationResponseStatusChanged_7727 : UdonOperationResponseDisconnectMessage_E05D
    {
        public object _dateTime; // 0x34154030, was: ÌÍÍÌÏÌÍÏÎÍÍÏÎÏÏÌÌÌÍÍÏÎÌ

        // ── Original Methods ──
        public void get_customCaretColor(){} // RVA: 0x7ffaa9410630
        public void .ctor(){} // RVA: 0x7ffaa9410910
        public void ResetOperationResponseState(){} // RVA: 0x7ffaa9411b50
        public void OnStatusChanged(){} // RVA: 0x7ffaa9412350
        public void OnOperationResponse(){} // RVA: 0x7ffaa9412500
        public void OnEvent(){} // RVA: 0x7ffaa9412660
        public void ResetOperationResponseState2(){} // RVA: 0x7ffaa9413650
        public void ResetOperationResponseState3(){} // RVA: 0x7ffaa94136a0
        // ── Binary Analysis Named ──
        public void GetGameObject_F43(){} // RVA: 0x7ffaa94105b0
        public void GetOperationStatusByte(){} // RVA: 0x7ffaa9410630
        public void GetGameObject_252(){} // RVA: 0x7ffaa9410640
        public void GetGameObject_209(){} // RVA: 0x7ffaa9410ce0
        public void GetGameObject_2C3(){} // RVA: 0x7ffaa9410fb0
        public void GetGameObject_9BB(){} // RVA: 0x7ffaa9411040
        public void GetGameObject_93D(){} // RVA: 0x7ffaa9411310
        public void CheckLockState(){} // RVA: 0x7ffaa9413130
        // ── Obfuscated Methods ──
        public void m_7A9(){} // RVA: 0x7ffaa9410630
        public void m_465(){} // RVA: 0x7ffaa94113a0
        public void m_F89(){} // RVA: 0x7ffaa9411ba0
    }

    /// <summary>Originally: ÎÏÍÌÎÌÍÎÎÎÏÏÌÏÏÌÍÏÎÏÍÍÎ</summary>
    public class UdonUnregisterEventHandlerRegisterEventHandl_362C : VRC_EventDispatcher
    {
        public object _texts; // 0x334D1530, was: ÎÎÎÎÍÎÌÏÎÍÌÏÏÏÏÏÍÎÎÏÏÌÎ
        public object _uRAonsDepthUNDLESIZELIMITMOBILE; // 0x334D1530, was: ÌÎÎÎÍÌÌÎÎÏÌÎÎÏÌÍÌÍÎÍÌÎÏ
        public object f_F85; // 0x17000328, was: ÏÌÍÌÍÎÏÎÌÎÌÎÏÎÍÍÎÏÎÎÍÏÍ

        // ── Original Methods ──
        public void Computetransform(){} // RVA: 0x7ffaa98658e0
        public void CompareEventHandlers(){} // RVA: 0x7ffaa9865c90
        public void FindGameObject(){} // RVA: 0x7ffaa986d340
        public void UpdateTriggerString(){} // RVA: 0x7ffaa98663c0
        public void CallEventHandlerFunction(){} // RVA: 0x7ffaa98665d0
        public void Awake(){} // RVA: 0x7ffaa98667b0
        public void Accessvelocity_Injected(){} // RVA: 0x7ffaa9866ac0
        public void RegisterEventWithParameters(){} // RVA: 0x7ffaa9866f80
        public void ProcessUdonEventType(){} // RVA: 0x7ffaa98670f0
        public void UpdateMaterial(){} // RVA: 0x7ffaa98673a0
        public void Updatelayer(){} // RVA: 0x7ffaa9867c50
        public void ComputeRoot(){} // RVA: 0x7ffaa9867cc0
        public void OnDestroy(){} // RVA: 0x7ffaa98697c0
        public void ComputeBoolString(){} // RVA: 0x7ffaa9869960
        public void HandleGameObjectEventRegistration(){} // RVA: 0x7ffaa986acb0
        public void ComputeIntegerString(){} // RVA: 0x7ffaa986a5e0
        public void Accessclip(){} // RVA: 0x7ffaa98665f0
        public void UnregisterUdonEventHandler(){} // RVA: 0x7ffaa986ab30
        public void HandleGameObjectEventRegistration(){} // RVA: 0x7ffaa986acb0
        public void UpdateActive(){} // RVA: 0x7ffaa986c240
        public void Updateenabled(){} // RVA: 0x7ffaa986caa0
        public void ReadTransformProperties(){} // RVA: 0x7ffaa986ce40
        public void FindGameObject(){} // RVA: 0x7ffaa986d340
        public void AccessangularVelocity_Injected(){} // RVA: 0x7ffaa986d450
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void .cctor(){} // RVA: 0x7ffaa986d910
        public void AccessactiveSelf(){} // RVA: 0x7ffaa986e610
        public void RegisterOrUnregisterUdonEventHandler(){} // RVA: 0x7ffaa986e6f0
        public void UnregisterEventHandler(){} // RVA: 0x7ffaa986ea70
        public void RegisterEventWithContext(){} // RVA: 0x7ffaa986ef50
        public void TriggerEvent(){} // RVA: 0x7ffaa986f0c0
        public void RegisterAdvancedEventHandler(){} // RVA: 0x7ffaa986f120
        public void RegisterUdonEventHandler(){} // RVA: 0x7ffaa986f350
        public void RegisterEventHandler(){} // RVA: 0x7ffaa986f520
        // ── Binary Analysis Named ──
        public void DoSetUserMetadata_B4E(){} // RVA: 0x7ffaa986ee00
        public void DoPlay(){} // RVA: 0x7ffaa98651d0
        public void GetEventDispatcher(){} // RVA: 0x7ffaa98656c0
        public void DoStop(){} // RVA: 0x7ffaa9865720
        public void DoTransformVector_(){} // RVA: 0x7ffaa9865f80
        public void DoPlayHelper(){} // RVA: 0x7ffaa98665f0
        public void Gettransform(){} // RVA: 0x7ffaa9867870
        public void DoGetAssemblies(){} // RVA: 0x7ffaa98690d0
        public void DoSetFloatString(){} // RVA: 0x7ffaa986a3f0
        public void DoGetIgnoreLayerCollision_236(){} // RVA: 0x7ffaa986a970
        public void GetGameObjectPath(){} // RVA: 0x7ffaa986ac60
        public void SetEventComponentGameObject(){} // RVA: 0x7ffaa986d200
        public void SetEventDispatcherReference(){} // RVA: 0x7ffaa986d3a0
        public void DoAddForce_Injecte(){} // RVA: 0x7ffaa986e230
        public void GetGameObjectTransformPositionAndRotation(){} // RVA: 0x7ffaa986ebd0
        public void DoSetUserMetadata_B4E(){} // RVA: 0x7ffaa986ee00
        public void DoTransformVector_Injected(){} // RVA: 0x7ffaa986f5f0
        // ── Obfuscated Methods ──
        public void m_C68(){} // RVA: 0x7ffaa98655e0
        public void m_BE0(){} // RVA: 0x7ffaa9865670
        public void m_B54(){} // RVA: 0x7ffaa9866950
    }

}