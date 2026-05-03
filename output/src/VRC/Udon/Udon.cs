// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon
// Classes: 47
// Methods: 1024

namespace VRC.Udon
{
    public class AbstractSerializedUdonProgramAsset : ScriptableObject
    {
        // ── Methods ──
        public void StoreProgram(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void RetrieveProgram(){} // RVA: 0x7FFE80E2E2E0
        public void GetSerializedProgramSize(){} // RVA: 0x7FFE80E2E2E0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void TryGetEntrypointNameFromHash(){}
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFE80E32650
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class AbstractUdonBehaviourEventProxy : MonoBehaviour
    {
        public VRC.Udon.UdonBehaviour _eventReceiver; // 0x20

        // ── Methods ──
        public void get_EventReceiver(){} // RVA: 0x7FFE811290C0
        public void set_EventReceiver(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class AbstractUdonProgramSource : ScriptableObject
    {
        // ── Methods ──
        public void get_SerializedProgramAsset(){} // RVA: 0x7FFE80E2E2E0
        public void RunEditorUpdate(){} // RVA: 0x7FFE80E4F230
        public void RefreshProgram(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class IUdonTriggerEventConsumer
    {
        // ── Methods ──
        public void get_Priority(){} // RVA: 0x7FFE80E2EDB0
        public void TryConsumeOnTriggerEnter(){} // RVA: 0x7FFE80E32650
        public void TryConsumeOnTriggerExit(){} // RVA: 0x7FFE80E32650
        public void TryConsumeOnTriggerStay(){} // RVA: 0x7FFE80E32650
    }

    public class OnAnimatorMoveProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnAnimatorMove(){} // RVA: 0x7FFE8823BE20
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class OnAudioFilterReadProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnAudioFilterRead(){} // RVA: 0x7FFE8823BE80
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class OnCollisionStayProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnCollisionStay(){} // RVA: 0x7FFE8823C060
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class OnRenderObjectProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnRenderObject(){} // RVA: 0x7FFE8823C080
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class OnTriggerStayProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnTriggerStay(){} // RVA: 0x7FFE8823C0E0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class OnWillRenderObjectProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7FFE8823C100
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class UdonBehaviour : AbstractUdonBehaviour
    {
        public VRC.Udon.Common.Interfaces.IUdonVariableTable publicVariables; // 0x40
        public bool SynchronizePosition; // 0x48
        public bool SynchronizeAnimation; // 0x49
        public bool AllowCollisionOwnershipTransfer; // 0x4A
        public bool Reliable; // 0x4B
        public 0x6664882C _syncMethod; // 0x4C
        public VRC.Udon.AbstractSerializedUdonProgramAsset serializedProgramAsset; // 0x50
        public System.Action`2<VRC.Udon.UdonBehaviour,VRC.Udon.Common.Interfaces.IUdonProgram> _onInit;
        public System.Action`1<VRC.Udon.UdonBehaviour> _requestSerializationHook; // 0x8
        public bool _disableInteractive; // 0x58
        public string ReturnVariableName;
        public bool _disableEventProcessing; // 0x59
        public int _componentIndexFixed; // 0x5C
        public VRC.Udon.UdonManager _udonManager; // 0x60
        public VRC.Udon.Common.Interfaces.IUdonProgram _program; // 0x68
        public VRC.Udon.Common.Interfaces.IUdonVM _udonVM; // 0x70
        public bool _isReady; // 0x78

        // ── Methods ──
        public void get_SyncMethod(){} // RVA: 0x7FFE8823C160
        public void set_SyncMethod(){} // RVA: 0x7FFE8823C180
        public void get_HasDoneStart(){} // RVA: 0x7FFE820C3D10
        public void get_HasError(){} // RVA: 0x7FFE820C4230
        public void get_SyncIsContinuous(){} // RVA: 0x7FFE8823C500
        public void get_SyncIsManual(){} // RVA: 0x7FFE8823C530
        public void get_OnInit(){} // RVA: 0x7FFE8823C560
        public void set_OnInit(){} // RVA: 0x7FFE8823C5C0
        public void get_RequestSerializationHook(){} // RVA: 0x7FFE8823C670
        public void set_RequestSerializationHook(){} // RVA: 0x7FFE8823C6D0
        public void get_DisableInteractive(){} // RVA: 0x7FFE813A1140
        public void set_DisableInteractive(){} // RVA: 0x7FFE819E83C0
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFE86E6CC80
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFE8823C790
        public void get_IsInteractive(){} // RVA: 0x7FFE8823C800
        public void get_UpdateOrder(){} // RVA: 0x7FFE8823C840
        public void get_DisableEventProcessing(){} // RVA: 0x7FFE85BA8C00
        public void set_DisableEventProcessing(){} // RVA: 0x7FFE86B5F180
        public void get_ProgramId(){} // RVA: 0x7FFE8823C8A0
        public void get_ProgramSize(){} // RVA: 0x7FFE8823C990
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFE8823CB90 | overloaded x2
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7FFE8823CCA0
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFE8823CE00
        public void get_IsInitialized(){} // RVA: 0x7FFE86E6CC70
        public void GetComponentIndexFixed(){} // RVA: 0x7FFE8823CF20
        public void LoadProgram(){} // RVA: 0x7FFE8823CF80
        public void RegisterEventProxy(){} // RVA: 0x7FFE80E45FE0
        public void ProcessEntryPoints(){} // RVA: 0x7FFE8823D560
        public void DetectExistingProxies(){} // RVA: 0x7FFE8823E170
        public void ResolveUdonHeapReferences(){} // RVA: 0x7FFE8823E460
        public void ResolveUdonHeapReference(){} // RVA: 0x7FFE8823E7B0
        public void ManagedUpdate(){} // RVA: 0x7FFE8823EB80
        public void ManagedLateUpdate(){} // RVA: 0x7FFE8823ED30
        public void ManagedFixedUpdate(){} // RVA: 0x7FFE8823EE50
        public void PostLateUpdate(){} // RVA: 0x7FFE8823EF70
        public void OnAnimatorIK(){} // RVA: 0x7FFE8823F090
        public void ProxyOnAnimatorMove(){} // RVA: 0x7FFE8823F1E0
        public void ProxyOnAudioFilterRead(){} // RVA: 0x7FFE8823F230
        public void OnBecameInvisible(){} // RVA: 0x7FFE8823F400
        public void OnBecameVisible(){} // RVA: 0x7FFE8823F450
        public void OnCollisionEnter(){} // RVA: 0x7FFE8823F4A0
        public void OnCollisionEnter2D(){} // RVA: 0x7FFE8823F710
        public void OnCollisionExit(){} // RVA: 0x7FFE8823F910
        public void OnCollisionExit2D(){} // RVA: 0x7FFE8823FB80
        public void ProxyOnCollisionStay(){} // RVA: 0x7FFE8823FD80
        public void OnCollisionStay2D(){} // RVA: 0x7FFE8823FFF0
        public void OnDestroy(){} // RVA: 0x7FFE882401F0
        public void OnDisable(){} // RVA: 0x7FFE882407F0
        public void OnDrawGizmos(){} // RVA: 0x7FFE88240850
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE882408A0
        public void OnEnable(){} // RVA: 0x7FFE882408F0
        public void OnJointBreak(){} // RVA: 0x7FFE88240950
        public void OnJointBreak2D(){} // RVA: 0x7FFE88240AD0
        public void OnMouseDown(){} // RVA: 0x7FFE88240BF0
        public void OnMouseDrag(){} // RVA: 0x7FFE88240C40
        public void OnMouseEnter(){} // RVA: 0x7FFE88240C90
        public void OnMouseExit(){} // RVA: 0x7FFE88240CE0
        public void OnMouseOver(){} // RVA: 0x7FFE88240D30
        public void OnMouseUp(){} // RVA: 0x7FFE88240D80
        public void OnMouseUpAsButton(){} // RVA: 0x7FFE88240DD0
        public void OnParticleCollision(){} // RVA: 0x7FFE88240E20
        public void OnParticleTrigger(){} // RVA: 0x7FFE88240FF0
        public void OnPostRender(){} // RVA: 0x7FFE88241040
        public void OnPreCull(){} // RVA: 0x7FFE88241090
        public void OnPreRender(){} // RVA: 0x7FFE882410E0
        public void OnRenderImage(){} // RVA: 0x7FFE88241130
        public void ProxyOnRenderObject(){} // RVA: 0x7FFE882413A0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFE882413F0
        public void OnTransformParentChanged(){} // RVA: 0x7FFE88241440
        public void OnTriggerEnter(){} // RVA: 0x7FFE88241490
        public void OnTriggerEnter2D(){} // RVA: 0x7FFE88241880
        public void OnTriggerExit(){} // RVA: 0x7FFE88241A80
        public void OnTriggerExit2D(){} // RVA: 0x7FFE88241E70
        public void ProxyOnTriggerStay(){} // RVA: 0x7FFE88242070
        public void OnTriggerStay2D(){} // RVA: 0x7FFE88242460
        public void OnControllerColliderHit(){} // RVA: 0x7FFE88242660
        public void OnValidate(){} // RVA: 0x7FFE88242AF0
        public void ProxyOnWillRenderObject(){} // RVA: 0x7FFE88242B40
        public void OnNetworkReady(){} // RVA: 0x7FFE88242B90
        public void Interact(){} // RVA: 0x7FFE88242BA0
        public void OnDrop(){} // RVA: 0x7FFE88242BF0
        public void OnPickup(){} // RVA: 0x7FFE88242C40
        public void OnPickupUseDown(){} // RVA: 0x7FFE88242C90
        public void OnPickupUseUp(){} // RVA: 0x7FFE88242CE0
        public void OnPreSerialization(){} // RVA: 0x7FFE88242D30
        public void OnPostSerialization(){} // RVA: 0x7FFE88242EC0
        public void OnDeserialization(){} // RVA: 0x7FFE88243150
        public void RunProgram(){} // RVA: 0x7FFE882434E0 | overloaded x2
        public void GetPrograms(){} // RVA: 0x7FFE88243AD0
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE88243B90
        public void DeserializePublicVariables(){} // RVA: 0x7FFE88243BA0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE88244020
        public void SerializePublicVariables(){} // RVA: 0x7FFE88244020
        public void TryToInterrogateUdon(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void RunEvent(){} // RVA: 0x7FFE81464840 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x7FFE88244470 | overloaded x10
        public void RunInputEvent(){} // RVA: 0x7FFE882447B0
        public void GetEventParameterName(){} // RVA: 0x7FFE88244A50
        public void PreloadUdonProgram(){} // RVA: 0x7FFE88244D40
        public void SearchUdonInterface(){} // RVA: 0x7FFE810A1420
        public void InitializeUdonContent(){} // RVA: 0x7FFE88244FA0
        public void RunOnInit(){} // RVA: 0x7FFE88245830
        public void RegisterUpdate(){} // RVA: 0x7FFE882459E0
        public void UnregisterUpdate(){} // RVA: 0x7FFE88246070
        public void SendCustomEvent(){} // RVA: 0x7FFE88246590
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFE88246A10 | overloaded x9
        public void RequestSerialization(){} // RVA: 0x7FFE88246AA0
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7FFE88246B50
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7FFE88246CD0
        public void get_InteractionText(){} // RVA: 0x7FFE81129130
        public void set_InteractionText(){} // RVA: 0x7FFE810FCE90
        public void get_SyncMetadataTable(){} // RVA: 0x7FFE88246E60
        public void GetProgramVariableType(){} // RVA: 0x7FFE88246EC0
        public void SetProgramVariable(){} // RVA: 0x7FFE88246FD0 | overloaded x2
        public void SetHeapVariable(){} // RVA: 0x7FFE810A1420
        public void GetProgramVariable(){} // RVA: 0x7FFE88247110 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFE88247270 | overloaded x2
        public void SetupLogging(){} // RVA: 0x7FFE882474A0
        public void AssignProgramAndVariables(){} // RVA: 0x7FFE882475E0
        public void .ctor(){} // RVA: 0x7FFE88247690
        public void .cctor(){} // RVA: 0x7FFE88247AA0
    }

    /// <summary>Originally: ÏÎÍÌÏÌÌÌÌÏÏÌÌÌÌÍÎÌÌÎÌÎÎ</summary>
    public class UdonClientImageDownloaderSibling_E51F : Object
    {
        public System.Text.RegularExpressions.Regex _e51F;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82A12610
        public void Equals(){} // RVA: 0x7FFE82A12870
        public void GetHashCode(){} // RVA: 0x7FFE82A128F0
        public void op_Implicit(){} // RVA: 0x7FFE82A12A30
        public void CompareBaseObjects(){} // RVA: 0x7FFE82A12B20
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE82A12D80
        public void .cctor(){} // RVA: 0x7FFE82A12FE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE82A13400
        public void Instantiate(){} // RVA: 0x7FFE82A13480
        public void ToString(){} // RVA: 0x7FFE82A135C0
    }

    /// <summary>Originally: ÎÏÎÍÏÌÍÍÍÌÌÍÍÎÌÌÌÏÍÏÎÌÌ</summary>
    public class UdonDisableEventProcessing_834D : AbstractUdonBehaviour
    {
        public bool f_A3B; // 0x40
        public bool f_D11; // 0x41
        public bool f_E7E; // 0x42
        public string f_5F4; // 0x48
        public 0x6664882C f_596; // 0x50
        public VRC.SDK3.UdonNetworkCalling.NetworkCallingEntrypointMetadata[] f_51A; // 0x58
        public System.Collections.Generic.Dictionary`2<uint,string> _syncMethod; // 0x60
        public System.Collections.Generic.Dictionary`2<string,uint> _isNetworkingSupported; // 0x68

        // ── Methods ──
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFE81463E60 | overloaded x2
        public void RunEventAdvanced(){} // RVA: 0x7FFE810A1420 | overloaded x10
        public void RunEvent(){} // RVA: 0x7FFE81464840 | overloaded x10
        public void SetProgramVariable(){} // RVA: 0x7FFE81463A50 | overloaded x2
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFE81464920 | overloaded x9
        public void SetResources(){} // RVA: 0x7FFE81463AE0
        public void get_SyncMethod(){} // RVA: 0x7FFE8139DAD0
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFE81463AF0
        public void set_SyncMethod(){} // RVA: 0x7FFE81463B00
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFE81463B10
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7FFE81463B80
        public void get_DisableInteractive(){} // RVA: 0x7FFE811B6C00
        public void InitializeUdonContent(){} // RVA: 0x7FFE810FB310
        public void GetComponentIndexFixed(){} // RVA: 0x7FFE81463BC0
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFE81463C10
        public void Interact(){} // RVA: 0x7FFE810FB310
        public void SetDisableInteractive(){} // RVA: 0x7FFE811C3510
        public void .ctor(){} // RVA: 0x7FFE81463C60
        public void get_InteractionText(){} // RVA: 0x7FFE81176730
        public void TryGetProgramVariable(){} // RVA: 0x7FFE814642C0 | overloaded x2
        public void RunEventAdvanced_8D4539BD63EC(){} // RVA: 0x7FFE81463AE0
        public void set_DisableInteractive_A2EA7667E6BE(){} // RVA: 0x7FFE811C3500
        public void RunProgram(){} // RVA: 0x7FFE81463F10
        public void RequestSerialization(){} // RVA: 0x7FFE810FB310
        public void set_DisableInteractive(){} // RVA: 0x7FFE811B6C10
        public void get_SyncMetadataTable(){} // RVA: 0x7FFE81464050
        public void set_InteractionText(){} // RVA: 0x7FFE81176740
        public void RunInputEvent(){} // RVA: 0x7FFE81464120
        public void set_DisableEventProcessing(){} // RVA: 0x7FFE814641E0
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFE814641F0
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7FFE81464420
        public void set_InteractionText_7CF2C7840508(){} // RVA: 0x7FFE811C3510
        public void SendCustomEvent(){} // RVA: 0x7FFE81464460
        public void GetProgramVariableType(){} // RVA: 0x7FFE814644E0
        public void GetProgramVariableType_8F50AFAA0507(){} // RVA: 0x7FFE81464570
        public void get_DisableEventProcessing(){} // RVA: 0x7FFE814645D0
        public void GetProgramVariable(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void DoThrowUInt16OverflowException(){} // RVA: 0x7FFE81464660
        public void GetProgramVariable_EF0B92CDD3F7(){} // RVA: 0x7FFE811C3510
        public void SendCustomEventDelayedFrames_C962E5481C76(){} // RVA: 0x7FFE81464770
        public void SendCustomNetworkEvent_8F75F1092C16(){} // RVA: 0x7FFE81464570
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7FFE814648B0
        // ── Unresolved (hash) ──
        public void m_4B7(){} // RVA: 0x7FFE811C3510
    }

    public class UdonManager : MonoBehaviour
    {
        public System.Action`1<VRC.Udon.Common.Interfaces.IUdonProgram> OnUdonProgramLoaded;
        public System.Action OnUdonReady; // 0x8
        public VRC.Udon.UdonBehaviour currentlyExecuting; // 0x20
        public bool _hasLoaded; // 0x28
        public VRC.Udon.UdonManager _instance; // 0x10
        public UpdateOrderComparer _udonBehaviourUpdateOrderComparer; // 0x18
        public bool _isUdonEnabled; // 0x29
        public bool _isRunningEvent; // 0x2A
        public System.Collections.Generic.Dictionary`2<UnityEngine.SceneManagement.Scene,System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,System.Collections.Generic.HashSet`1<VRC.Udon.UdonBehaviour>>> _sceneUdonBehaviourDirectories; // 0x30

        // ── Methods ──
        public void add_OnUdonProgramLoaded(){} // RVA: 0x7FFE88247D90
        public void remove_OnUdonProgramLoaded(){} // RVA: 0x7FFE88247EF0
        public void add_OnUdonReady(){} // RVA: 0x7FFE88248050
        public void remove_OnUdonReady(){} // RVA: 0x7FFE882481A0
        public void get_HasLoaded(){} // RVA: 0x7FFE815F1380
        public void set_HasLoaded(){} // RVA: 0x7FFE81C15740
        public void get_Instance(){} // RVA: 0x7FFE882482F0
        public void get_SignatureVerificationFailed(){} // RVA: 0x7FFE81790750
        public void get_SignatureVerificationSuccess(){} // RVA: 0x7FFE825F9DC0
        public void get_SignatureVerificationSkipped(){} // RVA: 0x7FFE817E0030
        public void get_WorldSignatureVerificationEnabled(){} // RVA: 0x7FFE82A23490
        public void set_WorldSignatureVerificationEnabled(){} // RVA: 0x7FFE82A234A0
        public void ResetWorldSignatureVerification(){} // RVA: 0x7FFE88248350
        public void EnableWorldSignatureVerification(){} // RVA: 0x7FFE882483C0
        public void RegisterTriggerEventConsumer(){} // RVA: 0x7FFE88248480
        public void UnregisterTriggerEventConsumer(){} // RVA: 0x7FFE882486A0
        public void TryNotifyOnTriggerEnterConsumers(){} // RVA: 0x7FFE88248710
        public void TryNotifyOnTriggerExitConsumers(){} // RVA: 0x7FFE882488B0
        public void TryNotifyOnTriggerStayConsumers(){} // RVA: 0x7FFE88248A50
        public void Awake(){} // RVA: 0x7FFE88248BF0
        public void Update(){} // RVA: 0x7FFE88249500
        public void LateUpdate(){} // RVA: 0x7FFE88249BB0
        public void FixedUpdate(){} // RVA: 0x7FFE8824A1F0
        public void PostLateUpdate(){} // RVA: 0x7FFE8824A830
        public void OnDestroy(){} // RVA: 0x7FFE8824AF30
        public void GetWrapperModule(){} // RVA: 0x7FFE810A1420
        public void RegisterInput(){} // RVA: 0x7FFE8824B0A0
        public void RunInputAction(){} // RVA: 0x7FFE8824B180
        public void UpdateInputQueue(){} // RVA: 0x7FFE8824B4C0
        public void get_IsSceneLoading(){} // RVA: 0x7FFE81F84400
        public void set_IsSceneLoading(){} // RVA: 0x7FFE81F84A40
        public void OnSceneLoaded(){} // RVA: 0x7FFE8824B8A0
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7FFE8824CE00
        public void ProcessUdonProgram(){} // RVA: 0x7FFE8824CF60
        public void OnSceneUnloaded(){} // RVA: 0x7FFE8824CFE0
        public void PurgeSerializationCaches(){} // RVA: 0x7FFE8824D050
        public void GetTotalLoadedProgramSize(){} // RVA: 0x7FFE8824D1C0
        public void GetLoadedBehavioursSyncTypes(){} // RVA: 0x7FFE8824D960
        public void RegisterUdonBehaviourUpdate(){} // RVA: 0x7FFE8824DED0
        public void RegisterUdonBehaviourLateUpdate(){} // RVA: 0x7FFE8824DFB0
        public void RegisterUdonBehaviourFixedUpdate(){} // RVA: 0x7FFE8824E090
        public void RegisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7FFE8824E170
        public void UnregisterUdonBehaviourUpdate(){} // RVA: 0x7FFE8824E2B0
        public void UnregisterUdonBehaviourLateUpdate(){} // RVA: 0x7FFE8824E390
        public void UnregisterUdonBehaviourFixedUpdate(){} // RVA: 0x7FFE8824E470
        public void UnregisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7FFE8824E550
        public void ScheduleDelayedEvent(){} // RVA: 0x7FFE8824E720 | overloaded x2
        public void HandleUdonEventScheduled(){} // RVA: 0x7FFE8824E810
        public void SetUdonEnabled(){} // RVA: 0x7FFE8268C820
        public void IncrementDepthCount(){} // RVA: 0x7FFE8824E890
        public void DecrementDepthCount(){} // RVA: 0x7FFE8824E9A0
        public void get_DebugLogging(){} // RVA: 0x7FFE8824EA60
        public void set_DebugLogging(){} // RVA: 0x7FFE8824EAB0
        public void ConstructUdonVM(){} // RVA: 0x7FFE8824EB20
        public void ApplyFilter(){} // RVA: 0x7FFE8824EC80 | overloaded x2
        public void Blacklist(){} // RVA: 0x7FFE8824EC00 | overloaded x2
        public void CleanBlacklist(){} // RVA: 0x7FFE8824ECE0
        public void IsBlacklisted(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFE8824ED90
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFE8824EDF0
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFE8824EE50
        public void GetWrapper(){} // RVA: 0x7FFE8824EEB0
        public void RegisterUdonBehaviour(){} // RVA: 0x7FFE8824EF00
        public void UnregisterUdonBehaviour(){} // RVA: 0x7FFE8824F220
        public void CheckUdonBehavioursToRegister(){} // RVA: 0x7FFE8824F390
        public void GetUdonBehavioursInScene(){} // RVA: 0x7FFE8824F4C0
        public void RunEvent(){} // RVA: 0x7FFE882508C0 | overloaded x10
        public void .ctor(){} // RVA: 0x7FFE88250B40
        public void .cctor(){} // RVA: 0x7FFE88251A90
        public void <OnSceneLoaded>b__102_0(){} // RVA: 0x7FFE88251B50
    }

    /// <summary>Originally: ÎÎÍÌÌÍÏÍÍÍÏÏÌÎÏÎÏÏÎÍÏÎÍ</summary>
    public class UdonOperationResponseStatusChanged_C627 : Udonk__BackingField_7DFB
    {
        public ÎÎÍÌÌÍÏÍÍÍÏÏÌÎÏÎÏÏÎÍÏÎÍ f_A6F;
        public bool f_49A; // 0x170
        public System.Collections.Generic.Queue`1<Photon.Client.EventData> f_F64; // 0x178

        // ── Methods ──
        public void OnOperationResponse(){} // RVA: 0x7FFE81B41C20
        public void OnEvent(){} // RVA: 0x7FFE81B42540
        public void OnStatusChanged(){} // RVA: 0x7FFE81B433F0
        public void .ctor(){} // RVA: 0x7FFE81B43BA0
        public void Initialize(){} // RVA: 0x7FFE81B43F70
        // ── 11 unresolved (hash) ──
        public void m_D45(){} // RVA: 0x7FFE81B41470
        public void m_FBC(){} // RVA: 0x7FFE81B41D80
        public void m_695(){} // RVA: 0x7FFE81B42530
        public void m_0A4(){} // RVA: 0x7FFE81B43010
        public void m_214(){} // RVA: 0x7FFE81B43090
        // ... 6 more unresolved methods
    }

    /// <summary>Originally: ÎÏÌÎÏÏÌÌÌÏÌÌÍÎÎÍÏÎÏÏÍÌÏ</summary>
    public class UdonUnregisterEventHandlerRegisterEventHandl_C866 : VRC_EventDispatcher
    {
        public ÎÏÌÎÏÏÌÌÌÏÌÌÍÎÎÍÏÎÏÏÍÌÏ f_1F6;

        // ── Methods ──
        public void RegisterEventHandler(){} // RVA: 0x7FFE8211A730
        public void UnregisterEventHandler(){} // RVA: 0x7FFE8211C0C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void Initialize(){} // RVA: 0x7FFE8211CCC0
        public void FindGameObject(){} // RVA: 0x7FFE8211E7B0 | overloaded x2
        public void GetGameObjectPath(){} // RVA: 0x7FFE8211E150
        public void Awake(){} // RVA: 0x7FFE8211E610
        public void TriggerEvent(){} // RVA: 0x7FFE82120300
        public void OnDestroy(){} // RVA: 0x7FFE82121FE0
        public void .cctor(){} // RVA: 0x7FFE821227C0
        // ── 44 unresolved (hash) ──
        public void m_AAA(){} // RVA: 0x7FFE8211A800
        public void m_D70(){} // RVA: 0x7FFE8211AA10
        public void m_EA6(){} // RVA: 0x7FFE8211BE20
        public void m_EC4(){} // RVA: 0x7FFE8211C050
        public void m_0DD(){} // RVA: 0x7FFE8211C220
        // ... 39 more unresolved methods
    }

    /// <summary>Originally: ÎÌÎÎÎÍÍÏÍÎÌÍÎÏÌÎÏÏÏÎÎÎÍ</summary>
    public class Udonk__BackingFieldImpl_6EA7 : Udonk__BackingField_7DFB
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82876470
    }

    /// <summary>Originally: ÍÍÏÏÍÌÎÎÍÏÌÎÌÏÎÍÎÏÏÎÌÍÍ</summary>
    public class Udonk__BackingFieldSiblinRelated_096D : ValueType
    {
        public UIntPtr f_AA0; // 0x10
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_BB6; // 0x18
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_5B8; // 0x20
        public ÌÌÌÌÍÎÏÍÎÌÍÍÎÏÌÏÎÏÌÌÎÌÎ f_273; // 0x28
        public bool f_98A; // 0x38
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_712; // 0x40
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_E41; // 0x48
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_003; // 0x50
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_8AC; // 0x58
        public 0x664F1C54 f_A3F; // 0x60
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_FF1; // 0x68
        public uint f_D51; // 0x70
        public System.Nullable`1<ÌÍÍÍÏÍÌÎÏÎÌÍÎÏÏÌÎÏÍÎÎÏÎ> f_778; // 0x78
        public ÌÍÎÎÌÍÍÍÍÏÏÏÎÏÍÎÍÎÌÌÏÌÎ f_BA5; // 0x98
        public UIntPtr f_FA8; // 0xA0
        public System.Nullable`1<double> f_265; // 0xA8

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82506C00
        public void InternalEquals(){} // RVA: 0x7FFE815F1380
        public void DefaultEquals(){} // RVA: 0x7FFE82889220
        public void GetHashCode(){} // RVA: 0x7FFE81280F90
        public void InternalGetHashCode(){} // RVA: 0x7FFE8154EB60
        public void ToString(){} // RVA: 0x7FFE82D5F200
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE8113A010
        // ── 33 unresolved (hash) ──
        public void m_62B(){} // RVA: 0x7FFE81854020
        public void m_9A8(){} // RVA: 0x7FFE8144E200
        public void m_068(){} // RVA: 0x7FFE81116380
        public void m_3A8(){} // RVA: 0x7FFE82DC8860
        public void m_893(){} // RVA: 0x7FFE8139E520
        // ... 28 more unresolved methods
    }

    /// <summary>Originally: ÌÏÍÎÎÍÌÎÍÏÎÌÍÍÎÍÍÍÎÌÎÎÌ</summary>
    public class Udonk__BackingFieldSiblinRelated_1F3A : ValueType
    {
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x10
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_1E1; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE826F4230
        public void InternalEquals(){} // RVA: 0x7FFE8284EF60
        public void DefaultEquals(){} // RVA: 0x7FFE8284EF60
        public void GetHashCode(){} // RVA: 0x7FFE826F4210
        public void InternalGetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void ToString(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE826F4210
        public void ToString_754D3B567A02(){} // RVA: 0x7FFE826F4230
        // ── Unresolved (hash) ──
        public void m_AC1(){} // RVA: 0x7FFE81D7E9E0
    }

    /// <summary>Originally: ÍÎÌÏÏÏÎÎÎÌÌÎÌÎÏÎÎÍÍÌÎÌÎ</summary>
    public class Udonk__BackingFieldSiblinRelated_38E8 : ValueType
    {
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_5B8; // 0x10
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ[] f_661; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE826F4230
        public void InternalEquals(){} // RVA: 0x7FFE81D7E9E0
        public void MoveNext(){} // RVA: 0x7FFE826F4210
        public void GetHashCode(){} // RVA: 0x7FFE826F4230
        public void InternalGetHashCode(){} // RVA: 0x7FFE826F4230
        public void ToString(){} // RVA: 0x7FFE826F4230
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE826F4210
        public void ProcessAsyncOperationData(){} // RVA: 0x7FFE8284EF60
        public void FindObjectsByType(){} // RVA: 0x7FFE826F4210
        public void MoveNext_FA4EBD3743DA(){} // RVA: 0x7FFE81D7E9E0
        public void ToString_03DD2CE386C6(){} // RVA: 0x7FFE81D7E9E0
        // ── Unresolved (hash) ──
        public void m_068(){} // RVA: 0x7FFE8284EF60
    }

    /// <summary>Originally: ÍÏÌÎÏÌÎÌÌÍÍÎÌÍÎÎÌÌÍÌÎÎÎ</summary>
    public class Udonk__BackingFieldSiblinRelated_48F6 : ValueType
    {
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_9D7; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81D7E9E0
        public void InternalEquals(){} // RVA: 0x7FFE81D7E9E0
        public void DefaultEquals(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCode(){} // RVA: 0x7FFE8284EF60
        public void InternalGetHashCode(){} // RVA: 0x7FFE8284EF60
        public void ToString(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE81D7E9E0
        public void ResetStructFields(){} // RVA: 0x7FFE81D7E9E0
        // ── Unresolved (hash) ──
        public void m_ACE(){} // RVA: 0x7FFE8284EF60
    }

    /// <summary>Originally: ÌÍÍÍÎÏÏÎÏÍÌÌÌÌÍÎÍÌÎÎÏÎÍ</summary>
    public class Udonk__BackingFieldSiblinRelated_4C59 : ValueType
    {
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_9D7; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81D7E9E0
        public void InternalEquals(){} // RVA: 0x7FFE8284EF60
        public void DefaultEquals(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void InternalGetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void ToString(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE81D7E9E0
        public void ResetStructFields(){} // RVA: 0x7FFE8284EF60
        // ── Unresolved (hash) ──
        public void m_40E(){} // RVA: 0x7FFE8284EF60
    }

    /// <summary>Originally: ÍÌÌÏÎÌÏÌÌÎÏÌÏÎÌÏÏÏÌÌÎÍÍ</summary>
    public class Udonk__BackingFieldSiblinRelated_50EB : ValueType
    {
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81D7E9E0
        public void InternalEquals(){} // RVA: 0x7FFE81D7E9E0
        public void DefaultEquals(){} // RVA: 0x7FFE8284EF60
        public void GetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void InternalGetHashCode(){} // RVA: 0x7FFE8284EF60
        public void ToString(){} // RVA: 0x7FFE8284EF60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE8284EF60
    }

    /// <summary>Originally: ÎÍÍÌÌÏÏÌÍÍÍÎÏÎÌÎÍÏÌÏÍÌÍ</summary>
    public class Udonk__BackingFieldSiblinRelated_5409 : ValueType
    {
        public UIntPtr f_AA0; // 0x10
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_BB6; // 0x18
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_5B8; // 0x20
        public ÌÌÌÌÍÎÏÍÎÌÍÍÎÏÌÏÎÏÌÌÎÌÎ f_273; // 0x28
        public bool f_98A; // 0x38
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_712; // 0x40
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_E41; // 0x48
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_003; // 0x50
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_8AC; // 0x58
        public 0x664F1C54 f_A3F; // 0x60
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_FF1; // 0x68
        public uint f_D51; // 0x70
        public System.Nullable`1<ÌÍÏÍÎÍÏÏÌÏÏÌÎÏÎÏÎÏÍÍÌÎÏ> f_778; // 0x78
        public ÌÍÎÎÌÍÍÍÍÏÏÏÎÏÍÎÍÎÌÌÏÌÎ f_BA5; // 0x90
        public UIntPtr f_FA8; // 0x98
        public System.Nullable`1<double> f_265; // 0xA0

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE8139E520
        public void InternalEquals(){} // RVA: 0x7FFE81176740
        public void DefaultEquals(){} // RVA: 0x7FFE82DC3660
        public void GetHashCode(){} // RVA: 0x7FFE82506C00
        public void InternalGetHashCode(){} // RVA: 0x7FFE82C95CA0
        public void ToString(){} // RVA: 0x7FFE81282380
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82DC3680
        // ── 31 unresolved (hash) ──
        public void m_96E(){} // RVA: 0x7FFE82DC3660
        public void m_6CB(){} // RVA: 0x7FFE8119C0E0
        public void m_898(){} // RVA: 0x7FFE82DC3690
        public void m_EFB(){} // RVA: 0x7FFE81437330
        public void m_0AD(){} // RVA: 0x7FFE826F4210
        // ... 26 more unresolved methods
    }

    /// <summary>Originally: ÎÌÍÎÌÏÏÌÍÎÍÏÌÎÍÏÌÎÍÎÎÏÎ</summary>
    public class Udonk__BackingFieldSiblinRelated_5AE1 : ValueType
    {
        public object f_833; // 0x10
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x18
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_0B4; // 0x20
        public System.Nullable`1<System.DateTimeOffset> f_A70; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81116380
        public void InternalEquals(){} // RVA: 0x7FFE81116380
        public void DefaultEquals(){} // RVA: 0x7FFE8284EF60
        public void GetHashCode(){} // RVA: 0x7FFE8284EF60
        public void InternalGetHashCode(){} // RVA: 0x7FFE82D1A030
        public void ToString(){} // RVA: 0x7FFE813240E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82CD7E60
        public void ToString_91FEF90FBA2F(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCode_3CDD05EC234A(){} // RVA: 0x7FFE8284EF60
        // ── Unresolved (hash) ──
        public void m_1AB(){} // RVA: 0x7FFE826F4230
        public void m_40E(){} // RVA: 0x7FFE826F4210
        public void m_F04(){} // RVA: 0x7FFE81116380
        public void m_E11(){} // RVA: 0x7FFE810FCE30
        public void m_787(){} // RVA: 0x7FFE82D1A030
        public void m_EDB(){} // RVA: 0x7FFE826F4230
        public void m_DC4(){} // RVA: 0x7FFE8284EF60
    }

    /// <summary>Originally: ÌÏÍÏÌÍÏÌÏÌÎÏÏÏÏÎÏÎÎÎÎÏÌ</summary>
    public class Udonk__BackingFieldSiblinRelated_5E53 : ValueType
    {
        public object f_833; // 0x10
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x18
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ[] f_4F8; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE810FCE30
        public void InternalEquals(){} // RVA: 0x7FFE8284EF60
        public void DefaultEquals(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCode(){} // RVA: 0x7FFE826F4230
        public void InternalGetHashCode(){} // RVA: 0x7FFE81116380
        public void ToString(){} // RVA: 0x7FFE826F4210
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE8284EF60
        public void GetHashCode_3CDD05EC234A(){} // RVA: 0x7FFE8284EF60
        public void op_Equality(){} // RVA: 0x7FFE8284EF60
        public void Equals_62B39A545625(){} // RVA: 0x7FFE813240E0
        // ── Unresolved (hash) ──
        public void m_056(){} // RVA: 0x7FFE8284EF60
        public void m_40E(){} // RVA: 0x7FFE826F4210
        public void m_B43(){} // RVA: 0x7FFE810FCE30
        public void m_EDB(){} // RVA: 0x7FFE826F4230
        public void m_044(){} // RVA: 0x7FFE826F4230
        public void m_BD6(){} // RVA: 0x7FFE826F4230
    }

    /// <summary>Originally: ÌÏÍÌÏÏÎÍÌÏÏÍÎÍÎÌÍÌÎÏÎÎÌ</summary>
    public class Udonk__BackingFieldSiblinRelated_6767 : Object
    {
        public dFixup.MoveNextCore _6767; // 0x10
        public string _67672; // 0x18
        public object _67673; // 0x20
        public object _67674; // 0x28
        public string _67675; // 0x30

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8144E200
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCode(){} // RVA: 0x7FFE811C55E0
        public void op_Implicit(){} // RVA: 0x7FFE810FCE90
        public void .ctor(){} // RVA: 0x7FFE828370D0 | overloaded x2
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE811290D0 | overloaded x3
        public void GetCachedPtr(){} // RVA: 0x7FFE81161E80
        public void ToString(){} // RVA: 0x7FFE82836D90
        public void set_name(){} // RVA: 0x7FFE81129890
        public void Instantiate(){} // RVA: 0x7FFE82837050
        public void Initialize(){} // RVA: 0x7FFE81129130
        public void .ctor_EDBD1E6B4A22(){} // RVA: 0x7FFE81129890
        public void RemoveSprite(){} // RVA: 0x7FFE82837130
        public void OnSpriteRemoved(){} // RVA: 0x7FFE82837050
        public void GetTypeCode(){} // RVA: 0x7FFE82837260
        public void Destroy(){} // RVA: 0x7FFE811290C0
        public void UpdateController(){} // RVA: 0x7FFE82837370
        public void AddSprite(){} // RVA: 0x7FFE811C55E0
        public void Update(){} // RVA: 0x7FFE811C55E0
        public void DestroyImmediate(){} // RVA: 0x7FFE828375E0
        public void FindObjectsOfType(){} // RVA: 0x7FFE811290D0
        public void ClearSprites(){} // RVA: 0x7FFE8144E200
        public void CompositionMethod(){} // RVA: 0x7FFE810FCE90
        public void FindObjectsByType(){} // RVA: 0x7FFE811C55F0
        public void GetSpriteCount(){} // RVA: 0x7FFE811290D0
    }

    /// <summary>Originally: ÌÏÍÍÏÎÏÍÎÍÌÎÎÌÌÏÍÎÏÍÏÌÎ</summary>
    public class Udonk__BackingFieldSiblinRelated_6D6B : ValueType
    {
        public 0x664DEE84 f_AA2; // 0x10
        public object f_833; // 0x18
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x20
        public uint f_ECF; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE826F4230
        public void InternalEquals(){} // RVA: 0x7FFE815BF990
        public void DefaultEquals(){} // RVA: 0x7FFE81116380
        public void GetHashCode(){} // RVA: 0x7FFE826F4210
        public void InternalGetHashCode(){} // RVA: 0x7FFE810FCE30
        public void ToString(){} // RVA: 0x7FFE815BF990
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE813DB630
        public void GetUdonProgram(){} // RVA: 0x7FFE81116380
        public void Initialize(){} // RVA: 0x7FFE826F4220
        public void Serialize(){} // RVA: 0x7FFE826F4230
        public void ToString_844260588D3B(){} // RVA: 0x7FFE826F4210
        public void Equals_A00ED51F7397(){} // RVA: 0x7FFE826F4210
        public void GetHashCode_9E16F52ACFC7(){} // RVA: 0x7FFE815BF990
        // ── Unresolved (hash) ──
        public void m_62B(){} // RVA: 0x7FFE82D1D0B0
        public void m_EAB(){} // RVA: 0x7FFE81116380
        public void m_FDB(){} // RVA: 0x7FFE82D1D100
        public void m_2B7(){} // RVA: 0x7FFE8144DF00
    }

    /// <summary>Originally: ÏÍÎÍÎÌÏÍÌÎÏÏÏÍÌÍÌÌÎÏÍÎÎ</summary>
    public class Udonk__BackingFieldSiblinRelated_7012 : ValueType
    {
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x10
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ[] f_4F8; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE826F4210
        public void InternalEquals(){} // RVA: 0x7FFE826F4230
        public void DefaultEquals(){} // RVA: 0x7FFE826F4230
        public void GetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void InternalGetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void ToString(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE8284EF60
        public void ToString_B4334B082265(){} // RVA: 0x7FFE826F4230
        // ── Unresolved (hash) ──
        public void m_947(){} // RVA: 0x7FFE8284EF60
        public void m_CB6(){} // RVA: 0x7FFE826F4230
    }

    /// <summary>Originally: ÎÌÌÍÏÏÍÎÏÏÎÎÏÎÍÍÍÌÌÌÍÌÎ</summary>
    public class Udonk__BackingFieldSiblinRelated_75C5 : ValueType
    {
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_1E1; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81D7E9E0
        public void InternalEquals(){} // RVA: 0x7FFE81D7E9E0
        public void DefaultEquals(){} // RVA: 0x7FFE8284EF60
        public void GetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void InternalGetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void ToString(){} // RVA: 0x7FFE8284EF60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE8284EF60
    }

    /// <summary>Originally: ÍÌÏÍÎÌÍÍÍÎÌÎÌÍÎÍÍÏÎÏÏÌÎ</summary>
    public class Udonk__BackingFieldSiblinRelated_87AE : Object
    {
        public string _m_CachedPtr; // 0x10
        public bool _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public string f_0E2; // 0x20
        public object field_3; // 0x884

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8284C530
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE811164F0
        public void op_Implicit(){} // RVA: 0x7FFE811290D0
        public void CompareBaseObjects(){} // RVA: 0x7FFE811290C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE811164F0
        public void GetCachedPtr(){} // RVA: 0x7FFE811164E0
        public void get_name(){} // RVA: 0x7FFE810FCE30
        public void ToString(){} // RVA: 0x7FFE8284C550
        public void Instantiate(){} // RVA: 0x7FFE810FCE30
        public void Equals(){} // RVA: 0x7FFE8284C640
        public void GetHashCode(){} // RVA: 0x7FFE81116380
        public void Start(){} // RVA: 0x7FFE81116380
        public void DoToUpper(){} // RVA: 0x7FFE8284C660
        public void ToString_EDBD1E6B4A22(){} // RVA: 0x7FFE810FCE30
    }

    /// <summary>Originally: ÍÌÏÍÍÌÎÎÎÌÌÎÍÎÌÍÍÍÍÎÏÌÍ</summary>
    public class Udonk__BackingFieldSiblinRelated_8C77 : ValueType
    {
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_1E1; // 0x10
        public 0x664F97BC f_677; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82C33000
        public void InternalEquals(){} // RVA: 0x7FFE8284EF60
        public void DefaultEquals(){} // RVA: 0x7FFE82C33010
        public void GetHashCode(){} // RVA: 0x7FFE82C33010
        public void InternalGetHashCode(){} // RVA: 0x7FFE8284EF60
        public void ToString(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82C33010
        public void ToString_754D3B567A02(){} // RVA: 0x7FFE81D7E9E0
        // ── Unresolved (hash) ──
        public void m_336(){} // RVA: 0x7FFE8284EF60
    }

    /// <summary>Originally: ÍÌÎÎÍÏÎÍÍÍÌÍÏÎÏÍÍÎÍÎÍÍÌ</summary>
    public class Udonk__BackingFieldSiblinRelated_AF09 : ValueType
    {
        public 0x664EFC5C f_05E; // 0x10
        public ÏÏÌÎÌÏÍÍÍÍÍÍÏÍÏÎÍÌÍÍÎÌÍ f_9D7; // 0x18
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_BB6; // 0x20
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_4ED; // 0x28
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_3C2; // 0x30
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_344; // 0x38
        public ÎÎÏÎÍÌÏÏÍÎÏÍÏÌÎÍÎÍÌÍÏÌÌ[] f_325; // 0x40
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_D17; // 0x48
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_4C8; // 0x50

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE8143BA80
        public void InternalEquals(){} // RVA: 0x7FFE8143BA80
        public void DefaultEquals(){} // RVA: 0x7FFE826F4230
        public void GetHashCode(){} // RVA: 0x7FFE811290D0
        public void InternalGetHashCode(){} // RVA: 0x7FFE81123200
        public void ToString(){} // RVA: 0x7FFE810FCE90
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE81129890
        // ── 17 unresolved (hash) ──
        public void m_EDB(){} // RVA: 0x7FFE826F4230
        public void m_2D9(){} // RVA: 0x7FFE826F4220
        public void m_40E(){} // RVA: 0x7FFE826F4210
        public void m_F05(){} // RVA: 0x7FFE81129130
        public void m_046(){} // RVA: 0x7FFE81161E80
        // ... 12 more unresolved methods
    }

    /// <summary>Originally: ÏÌÎÌÍÎÏÎÎÍÌÍÏÎÌÍÎÎÎÌÎÌÍ</summary>
    public class Udonk__BackingFieldSiblinRelated_B4FF : ValueType
    {
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x10
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_0B4; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81D7E9E0
        public void InternalEquals(){} // RVA: 0x7FFE8284EF60
        public void DefaultEquals(){} // RVA: 0x7FFE826F4210
        public void GetHashCode(){} // RVA: 0x7FFE826F4230
        public void InternalGetHashCode(){} // RVA: 0x7FFE8284EF60
        public void ToString(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE81D7E9E0
        public void ProcessAsyncOperationData(){} // RVA: 0x7FFE81D7E9E0
        public void FindObjectsByType(){} // RVA: 0x7FFE826F4210
        public void MoveNext(){} // RVA: 0x7FFE826F4210
        public void ToString_246855182E79(){} // RVA: 0x7FFE8284EF60
    }

    /// <summary>Originally: ÍÎÏÎÍÏÎÏÏÍÎÎÌÍÍÍÍÏÌÍÍÏÎ</summary>
    public class Udonk__BackingFieldSiblinRelated_C579 : ValueType
    {
        public uint f_95C; // 0x10
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_1E1; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE826F4210
        public void InternalEquals(){} // RVA: 0x7FFE826F4210
        public void DefaultEquals(){} // RVA: 0x7FFE826F4230
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void InternalGetHashCode(){} // RVA: 0x7FFE815BF990
        public void ToString(){} // RVA: 0x7FFE815BF990
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE826F4220
        public void ProcessAsyncOperationData(){} // RVA: 0x7FFE826F4230
        public void FindObjectsByType(){} // RVA: 0x7FFE815BF990
        public void MoveNext(){} // RVA: 0x7FFE826F4210
        public void ToString_754D3B567A02(){} // RVA: 0x7FFE826F4230
    }

    /// <summary>Originally: ÎÏÍÏÏÎÏÌÌÎÏÏÍÎÎÏÏÎÏÌÏÏÎ</summary>
    public class Udonk__BackingFieldSiblinRelated_D7D3 : ValueType
    {
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_1E1; // 0x10
        public int f_CF3; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE8284EF60
        public void InternalEquals(){} // RVA: 0x7FFE82C33000
        public void DefaultEquals(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCode(){} // RVA: 0x7FFE82C33000
        public void InternalGetHashCode(){} // RVA: 0x7FFE8284EF60
        public void ToString(){} // RVA: 0x7FFE8284EF60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82C33000
        public void ProcessAsyncOperationData(){} // RVA: 0x7FFE82C33010
        public void FindObjectsByType(){} // RVA: 0x7FFE8284EF60
        public void MoveNext(){} // RVA: 0x7FFE82C33000
        public void ToString_1AB58DB00C61(){} // RVA: 0x7FFE8284EF60
        // ── Unresolved (hash) ──
        public void m_979(){} // RVA: 0x7FFE81D7E9E0
    }

    /// <summary>Originally: ÎÎÍÎÍÏÎÍÍÍÎÍÎÎÎÎÍÎÌÎÌÍÍ</summary>
    public class Udonk__BackingFieldSiblinRelated_DCD6 : ValueType
    {
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81D7E9E0
        public void InternalEquals(){} // RVA: 0x7FFE81D7E9E0
        public void DefaultEquals(){} // RVA: 0x7FFE8284EF60
        public void GetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void InternalGetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void ToString(){} // RVA: 0x7FFE8284EF60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE81D7E9E0
        public void ResetStructFields(){} // RVA: 0x7FFE81D7E9E0
        public void SetupUIManagerModule(){} // RVA: 0x7FFE8284EF60
        // ── Unresolved (hash) ──
        public void m_947(){} // RVA: 0x7FFE8284EF60
    }

    /// <summary>Originally: ÍÌÎÌÏÏÎÏÍÎÎÌÏÏÍÍÍÌÍÌÌÎÌ</summary>
    public class Udonk__BackingFieldSiblinRelated_F088 : ValueType
    {
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x10
        public int f_1FB; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE8284EF60
        public void InternalEquals(){} // RVA: 0x7FFE81D7E9E0
        public void DefaultEquals(){} // RVA: 0x7FFE82C33010
        public void GetHashCode(){} // RVA: 0x7FFE82C33010
        public void InternalGetHashCode(){} // RVA: 0x7FFE82C33000
        public void ToString(){} // RVA: 0x7FFE8284EF60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE81D7E9E0
        public void ProcessAsyncOperationData(){} // RVA: 0x7FFE8284EF60
        public void FindObjectsByType(){} // RVA: 0x7FFE81D7E9E0
        public void MoveNext(){} // RVA: 0x7FFE8284EF60
        public void ToString_5C96AC9B6D10(){} // RVA: 0x7FFE82C33010
        // ── Unresolved (hash) ──
        public void m_044(){} // RVA: 0x7FFE81D7E9E0
    }

    /// <summary>Originally: ÏÏÌÎÌÏÎÎÎÍÌÌÏÌÌÌÌÍÍÎÏÏÌ</summary>
    public class Udonk__BackingFieldSiblingSiblSibling_284C : ValueType
    {
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x10
        public uint f_8E9; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82C33010
        public void InternalEquals(){} // RVA: 0x7FFE82C33010
        public void DefaultEquals(){} // RVA: 0x7FFE8284EF60
        public void GetHashCode(){} // RVA: 0x7FFE82C33000
        public void InternalGetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void ToString(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82C33010
        public void ProcessAsyncOperationData(){} // RVA: 0x7FFE82C33000
        public void FindObjectsByType(){} // RVA: 0x7FFE8284EF60
        public void MoveNext(){} // RVA: 0x7FFE82C33000
        public void ToString_EDBD1E6B4A22(){} // RVA: 0x7FFE81D7E9E0
    }

    /// <summary>Originally: ÏÎÏÎÎÌÍÏÎÍÌÏÌÎÎÍÏÍÌÌÍÏÎ</summary>
    public class Udonk__BackingFieldSiblingSiblSibling_C8E3 : ValueType
    {
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81D7E9E0
        public void InternalEquals(){} // RVA: 0x7FFE81D7E9E0
        public void DefaultEquals(){} // RVA: 0x7FFE8284EF60
        public void GetHashCode(){} // RVA: 0x7FFE8284EF60
        public void InternalGetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void ToString(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE81D7E9E0
        public void ResetStructFields(){} // RVA: 0x7FFE81D7E9E0
        // ── Unresolved (hash) ──
        public void m_EDB(){} // RVA: 0x7FFE81D7E9E0
    }

    /// <summary>Originally: ÏÏÍÍÏÌÌÏÏÍÍÏÏÎÎÏÎÍÌÍÏÏÏ</summary>
    public class Udonk__BackingFieldSiblingSiblSibling_F548 : ValueType
    {
        public ÏÏÌÎÌÏÍÍÍÍÍÍÏÍÏÎÍÌÍÍÎÌÍ f_9D7; // 0x10
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_543; // 0x18
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_DD1; // 0x20
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_101; // 0x28
        public uint f_46F; // 0x30

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81116380
        public void InternalEquals(){} // RVA: 0x7FFE8151D690
        public void DefaultEquals(){} // RVA: 0x7FFE81D7E9E0
        public void GetHashCode(){} // RVA: 0x7FFE826F4230
        public void InternalGetHashCode(){} // RVA: 0x7FFE8284EF60
        public void ToString(){} // RVA: 0x7FFE810FE7C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE81D7E9E0
        // ── Unresolved (hash) ──
        public void m_1AB(){} // RVA: 0x7FFE81D7E9E0
        public void m_790(){} // RVA: 0x7FFE8170B670
        public void m_EBC(){} // RVA: 0x7FFE810FCE30
        public void m_C64(){} // RVA: 0x7FFE81161E80
        public void m_D52(){} // RVA: 0x7FFE8151D690
        public void m_86D(){} // RVA: 0x7FFE8151D690
        public void m_B9E(){} // RVA: 0x7FFE8170B670
        public void m_267(){} // RVA: 0x7FFE826F4210
    }

    /// <summary>Originally: ÎÌÍÏÌÌÌÌÏÍÎÍÎÎÏÏÍÎÌÍÌÍÎ</summary>
    public class Udonk__BackingFieldSiblingSibling_4CB2 : ValueType
    {
        public ÏÏÌÎÌÏÍÍÍÍÍÍÏÍÏÎÍÌÍÍÎÌÍ f_9D7; // 0x10
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_AA5; // 0x18
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_543; // 0x20
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_974; // 0x28
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_101; // 0x30
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_DD1; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE81161E80
        public void InternalEquals(){} // RVA: 0x7FFE81D7E9E0
        public void DefaultEquals(){} // RVA: 0x7FFE81161E80
        public void GetHashCode(){} // RVA: 0x7FFE811290D0
        public void InternalGetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void ToString(){} // RVA: 0x7FFE811290D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE811290C0
        // ── 13 unresolved (hash) ──
        public void m_BBE(){} // RVA: 0x7FFE810FCE30
        public void m_40E(){} // RVA: 0x7FFE8284EF60
        public void m_D84(){} // RVA: 0x7FFE81129130
        public void m_267(){} // RVA: 0x7FFE81116380
        public void m_F31(){} // RVA: 0x7FFE81116380
        // ... 8 more unresolved methods
    }

    /// <summary>Originally: ÏÏÎÎÌÏÍÏÎÍÏÏÎÌÏÎÍÌÎÎÎÏÎ</summary>
    public class Udonk__BackingFieldSiblingSibling_5934 : ValueType
    {
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x10
        public uint f_708; // 0x18
        public int f_1FB; // 0x1C
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_7FE; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82C33010
        public void InternalEquals(){} // RVA: 0x7FFE82C33020
        public void DefaultEquals(){} // RVA: 0x7FFE82C33000
        public void GetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void InternalGetHashCode(){} // RVA: 0x7FFE82C33000
        public void ToString(){} // RVA: 0x7FFE81116380
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE81D7E9E0
        // ── Unresolved (hash) ──
        public void m_EB0(){} // RVA: 0x7FFE82C33020
        public void m_6C4(){} // RVA: 0x7FFE82C33030
        public void m_5CB(){} // RVA: 0x7FFE810FCE30
        public void m_AA4(){} // RVA: 0x7FFE810FCE30
        public void m_40E(){} // RVA: 0x7FFE8284EF60
        public void m_D68(){} // RVA: 0x7FFE81116380
        public void m_E6F(){} // RVA: 0x7FFE8284EF60
        public void m_641(){} // RVA: 0x7FFE82C33030
    }

    /// <summary>Originally: ÍÏÎÌÌÎÏÌÏÌÍÌÌÎÏÌÌÌÌÏÎÌÎ</summary>
    public class Udonk__BackingFieldSiblingSibling_BA98 : ValueType
    {
        public ÌÌÍÎÍÍÏÎÍÏÏÎÌÏÏÏÏÍÌÌÌÏÎ f_9D7; // 0x10
        public uint f_3C2; // 0x18
        public bool f_5AE; // 0x1C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE8284EF60
        public void InternalEquals(){} // RVA: 0x7FFE82D45980
        public void DefaultEquals(){} // RVA: 0x7FFE82C33010
        public void GetHashCode(){} // RVA: 0x7FFE82D45970
        public void InternalGetHashCode(){} // RVA: 0x7FFE81D7E9E0
        public void ToString(){} // RVA: 0x7FFE82C33010
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82C33010
        public void SetStateMachine(){} // RVA: 0x7FFE82D45970
        public void MoveNext(){} // RVA: 0x7FFE82D45970
        public void ToString_590B7B58ABA8(){} // RVA: 0x7FFE82D45970
        public void GetHashCode_2F5E222FE481(){} // RVA: 0x7FFE81D7E9E0
        // ── Unresolved (hash) ──
        public void m_6AB(){} // RVA: 0x7FFE82C33000
    }

    /// <summary>Originally: ÌÏÎÌÎÏÌÌÎÌÌÏÌÏÌÏÍÏÏÏÎÌÌ</summary>
    public class Udonk__BackingFieldSibling_B45F : Object
    {
        public ÏÌÎÌÍÏÍÍÏÍÏÌÌÍÎÍÎÎÏÎÏÌÎ _m_CachedPtr; // 0x10
        public int _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public ÏÏÎÍÍÎÌÏÎÍÍÏÍÏÌÍÏÎÏÏÍÏÏ f_1FA; // 0x20
        public bool f_DB0; // 0x28
        public bool f_E45; // 0x29
        public string f_A1F; // 0x30
        public string f_9D7; // 0x38
        public bool f_F74; // 0x40

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE819C2EA0
        public void op_Implicit(){} // RVA: 0x7FFE8285C460
        public void CompareBaseObjects(){} // RVA: 0x7FFE8143BA80
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8285C520
        public void GetCachedPtr(){} // RVA: 0x7FFE8285C530
        public void get_name(){} // RVA: 0x7FFE8285C560
        public void set_name(){} // RVA: 0x7FFE8285C580
        public void Instantiate(){} // RVA: 0x7FFE8144E200
        public void DestroyImmediate(){} // RVA: 0x7FFE8285CEA0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8285CBD0
        public void ToString(){} // RVA: 0x7FFE8285CD30
        public void GetHashCode(){} // RVA: 0x7FFE813DB630
        public void Destroy(){} // RVA: 0x7FFE81116380
        public void FindObjectsOfType(){} // RVA: 0x7FFE81176740
        public void FindObjectsByType(){} // RVA: 0x7FFE8285D100
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE810FCE30
        public void get_hideFlags(){} // RVA: 0x7FFE8268C820
        public void set_hideFlags(){} // RVA: 0x7FFE8285D2F0
        public void FindObjectOfType(){} // RVA: 0x7FFE8285C560
        public void Equals(){} // RVA: 0x7FFE8285D3C0
        public void FindFirstObjectByType(){} // RVA: 0x7FFE811B6C00
        public void CheckNullArgument(){} // RVA: 0x7FFE81176740
        // ── 13 unresolved (hash) ──
        public void m_0EB(){} // RVA: 0x7FFE811B6C10
        public void m_79D(){} // RVA: 0x7FFE8285C450
        public void m_8C8(){} // RVA: 0x7FFE8285C640
        public void m_CAB(){} // RVA: 0x7FFE8285C730
        public void m_E59(){} // RVA: 0x7FFE81176730
        // ... 8 more unresolved methods
    }

    /// <summary>Originally: ÍÏÍÌÍÌÍÏÏÏÎÎÌÎÎÎÏÎÌÏÌÍÏ</summary>
    public class Udonk__BackingFieldSibling_F02E : Object
    {
        public 0x66564BBC _m_CachedPtr; // 0x10
        public string _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public string f_C35; // 0x20
        public string f_9D7; // 0x28

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE810FCE90
        public void Equals(){} // RVA: 0x7FFE81161E80
        public void GetHashCode(){} // RVA: 0x7FFE810FE7C0
        public void op_Implicit(){} // RVA: 0x7FFE810FE0C0
        public void CompareBaseObjects(){} // RVA: 0x7FFE811485C0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE81129130
        public void GetCachedPtr(){} // RVA: 0x7FFE811290C0
        public void get_name(){} // RVA: 0x7FFE810FCE90
        public void set_name(){} // RVA: 0x7FFE82B02DE0
        public void Instantiate(){} // RVA: 0x7FFE811290C0
        public void ToString(){} // RVA: 0x7FFE81161E80
        public void .cctor(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE81129130
        public void .ctor_B55C0216B9E7(){} // RVA: 0x7FFE810FE0C0
        // ── Unresolved (hash) ──
        public void m_2F5(){} // RVA: 0x7FFE810FCE90
        public void m_546(){} // RVA: 0x7FFE810FCE90
        public void m_A59(){} // RVA: 0x7FFE82B02E90
    }

    /// <summary>Originally: ÏÍÍÏÌÍÎÎÎÏÌÏÌÎÏÏÍÌÌÏÌÍÍ</summary>
    public class Udonk__BackingField_7DFB : Object
    {
        public Photon.Client.PhotonPeer _m_CachedPtr; // 0x10
        public string _offsetOfInstanceIDInCPlusPlusObject; // 0x18
        public 0x666644A4 f_A06; // 0x20
        public int f_55A; // 0x24
        public int f_FD1; // 0x28
        public Photon.Realtime.AppSettings f_2B2; // 0x30
        public dFixup.eAsync>d__99 f_E4E; // 0x38
        public ÌÏÍÌÏÏÎÍÌÏÏÍÎÍÎÌÍÌÎÏÎÎÌ f_E1E; // 0x40
        public dFixup.2 f_740; // 0x48
        public string f_C32; // 0x50
        public ÍÌÎÍÍÏÏÍÍÏÌÎÍÍÍÏÌÎÌÏÎÎÎ f_F17; // 0x58
        public string f_A39; // 0x60
        public string f_F34; // 0x68
        public System.Func`3<string,dFixup.ompleted11Delegate,string> f_E06; // 0x70
        public dFixup.ompleted11Delegate f_C3A; // 0x78
        public dFixup.ate f_CE7; // 0x7C
        public Photon.Realtime.ConnectionHandler f_F56; // 0x80
        public System.Action`2<dFixup.ate,dFixup.ate> f_547; // 0x88
        public System.Action`1<Photon.Client.EventData> f_AE4; // 0x90
        public System.Action`2<bool,object> f_179; // 0x98
        public System.Action`1<Photon.Client.OperationResponse> f_26D; // 0xA0
        public ÌÎÏÌÍÎÌÍÍÌÌÎÍÎÌÍÌÎÍÎÎÎÎ f_9A1; // 0xA8
        public ÍÌÎÎÎÌÎÏÌÏÍÌÎÌÎÍÍÎÌÌÏÏÏ f_75C; // 0xB0
        public ÌÏÏÏÍÍÏÍÎÌÌÌÍÎÏÏÍÏÍÌÍÏÎ f_A16; // 0xB8
        public ÍÌÌÍÌÍÎÌÍÌÏÎÎÎÌÏÎÎÌÏÏÌÍ f_9E0; // 0xC0
        public ÏÍÌÏÌÎÎÎÏÏÏÎÏÏÏÏÏÏÍÌÎÌÏ f_2B8; // 0xC8
        public dFixup.e f_4E2; // 0xD0
        public ÎÌÎÍÍÌÏÌÎÏÏÌÎÏÏÎÎÎÎÍÏÏÍ f_655; // 0xD8
        public ÍÎÍÍÌÏÎÌÍÍÌÎÏÏÎÎÍÏÏÍÍÌÌ f_310; // 0xE0
        public ÍÎÍÍÌÏÎÌÍÍÌÎÏÏÎÎÍÏÏÍÍÌÌ f_7F8; // 0xE8
        public System.Collections.Generic.List`1<ÌÍÌÌÎÍÌÌÏÍÏÎÏÌÌÍÌÏÍÍÌÏÎ> f_349; // 0xF0
        public ÌÏÎÌÎÏÌÌÎÌÌÏÌÏÌÏÍÏÏÏÎÌÌ f_85C; // 0xF8
        public ÏÌÎÌÍÏÍÍÏÍÏÌÌÍÎÍÎÎÏÎÏÌÎ f_022; // 0x100

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8285DDB0
        public void Equals(){} // RVA: 0x7FFE8285DF40
        public void GetHashCode(){} // RVA: 0x7FFE8285DF60
        public void op_Implicit(){} // RVA: 0x7FFE8285E340
        public void CompareBaseObjects(){} // RVA: 0x7FFE81123200
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8285E360
        public void GetCachedPtr(){} // RVA: 0x7FFE8285E560
        public void get_name(){} // RVA: 0x7FFE8285E5B0
        public void set_name(){} // RVA: 0x7FFE8285E6B0
        public void Instantiate(){} // RVA: 0x7FFE8144E200
        public void ToString(){} // RVA: 0x7FFE8285E880
        public void Destroy(){} // RVA: 0x7FFE81823850
        public void DestroyImmediate(){} // RVA: 0x7FFE8285F910
        public void FindObjectsOfType(){} // RVA: 0x7FFE82869AD0 | overloaded x2
        public void OnDisconnectMessage(){} // RVA: 0x7FFE82860350
        public void OnOperationResponse(){} // RVA: 0x7FFE828604A0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFE82861F90
        public void get_hideFlags(){} // RVA: 0x7FFE828622C0
        public void set_hideFlags(){} // RVA: 0x7FFE82862340
        public void FindObjectsByType(){} // RVA: 0x7FFE82862770
        public void FindObjectOfType(){} // RVA: 0x7FFE82862910
        public void FindFirstObjectByType(){} // RVA: 0x7FFE82862A00
        public void CheckNullArgument(){} // RVA: 0x7FFE82862C20
        public void op_Equality(){} // RVA: 0x7FFE81828B50
        public void op_Inequality(){} // RVA: 0x7FFE817E0030
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFE82862E00
        public void Internal_CloneSingle(){} // RVA: 0x7FFE82862E10
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFE82862F10
        public void Internal_InstantiateSingle(){} // RVA: 0x7FFE81116380
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x7FFE82862F20
        public void GetName(){} // RVA: 0x7FFE81129890
        public void SetName(){} // RVA: 0x7FFE82862FC0
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFE82862FD0
        public void ForceLoadFromInstanceID(){} // RVA: 0x7FFE81D46A00
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFE82863380
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFE828635E0
        public void OnMessage(){} // RVA: 0x7FFE82864250
        public void .ctor(){} // RVA: 0x7FFE82865800
        public void Initialize(){} // RVA: 0x7FFE8286AD70 | overloaded x2
        public void OnStatusChanged(){} // RVA: 0x7FFE82869180
        public void OnEvent(){} // RVA: 0x7FFE82869D60
        public void DebugReturn(){} // RVA: 0x7FFE8286BB20
        // ── 95 unresolved (hash) ──
        public void m_F72(){} // RVA: 0x7FFE8285E950
        public void m_A65(){} // RVA: 0x7FFE8285EE30
        public void m_EE6(){} // RVA: 0x7FFE81176D50
        public void m_C43(){} // RVA: 0x7FFE8285EF30
        public void m_838(){} // RVA: 0x7FFE8285EF50
        // ... 90 more unresolved methods
    }

}