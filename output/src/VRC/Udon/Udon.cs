// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon
// Classes: 68
// Methods: 1364

namespace VRC.Udon
{
    public class AbstractSerializedUdonProgramAsset : ScriptableObject
    {
        // ── Methods ──
        public void StoreProgram(){} // RVA: 0x7FFAC2C79B30 | overloaded x2
        public void RetrieveProgram(){} // RVA: 0x7FFAC2C58E90
        public void GetSerializedProgramSize(){} // RVA: 0x7FFAC2C58E90
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void TryGetEntrypointNameFromHash(){}
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFAC2C5D200
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class AbstractUdonBehaviourEventProxy : MonoBehaviour
    {
        public VRC.Udon.UdonBehaviour EventReceiver; // 0x20

        // ── Methods ──
        public void get_EventReceiver(){} // RVA: 0x7FFAC2F4F0C0
        public void set_EventReceiver(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class AbstractUdonProgramSource : ScriptableObject
    {
        public object SerializedProgramAsset;

        // ── Methods ──
        public void get_SerializedProgramAsset(){} // RVA: 0x7FFAC2C58E90
        public void RunEditorUpdate(){} // RVA: 0x7FFAC2C79B30
        public void RefreshProgram(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class IUdonTriggerEventConsumer
    {
        public object Priority;

        // ── Methods ──
        public void get_Priority(){} // RVA: 0x7FFAC2C59960
        public void TryConsumeOnTriggerEnter(){} // RVA: 0x7FFAC2C5D200
        public void TryConsumeOnTriggerExit(){} // RVA: 0x7FFAC2C5D200
        public void TryConsumeOnTriggerStay(){} // RVA: 0x7FFAC2C5D200
    }

    public class OnAnimatorMoveProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnAnimatorMove(){} // RVA: 0x7FFAC9E89390
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class OnAudioFilterReadProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnAudioFilterRead(){} // RVA: 0x7FFAC9E893F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class OnCollisionStayProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnCollisionStay(){} // RVA: 0x7FFAC9E895D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class OnRenderObjectProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnRenderObject(){} // RVA: 0x7FFAC9E895F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class OnTriggerStayProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnTriggerStay(){} // RVA: 0x7FFAC9E89650
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class OnWillRenderObjectProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7FFAC9E89670
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class UdonBehaviour : AbstractUdonBehaviour
    {
        public VRC.Udon.Common.Interfaces.IUdonVariableTable SyncMethod; // 0x40
        public bool HasDoneStart; // 0x48
        public bool HasError; // 0x49
        public bool SyncIsContinuous; // 0x4A
        public bool SyncIsManual; // 0x4B
        public 0x6B24EE60 OnInit; // 0x4C
        public VRC.Udon.AbstractSerializedUdonProgramAsset RequestSerializationHook; // 0x50
        public System.Action`2<VRC.Udon.UdonBehaviour,VRC.Udon.Common.Interfaces.IUdonProgram> DisableInteractive;
        public System.Action`1<VRC.Udon.UdonBehaviour> IsNetworkingSupported; // 0x8
        public bool IsInteractive; // 0x58
        public string UpdateOrder;
        public bool DisableEventProcessing; // 0x59
        public int ProgramId; // 0x5C
        public VRC.Udon.UdonManager ProgramSize; // 0x60
        public VRC.Udon.Common.Interfaces.IUdonProgram IsInitialized; // 0x68
        public VRC.Udon.Common.Interfaces.IUdonVM InteractionText; // 0x70
        public bool SyncMetadataTable; // 0x78
        public string _categoryName; // 0x80
        public bool _hasError; // 0x88
        public bool _hasDoneStart; // 0x89
        public bool _initialized; // 0x8A
        public bool _isNetworkingSupported; // 0x8B
        public bool _hasInteractiveEvents; // 0x8C
        public bool _hasUpdateEvent; // 0x8D
        public bool _hasLateUpdateEvent; // 0x8E
        public bool _hasFixedUpdateEvent; // 0x8F
        public bool _hasPostLateUpdateEvent; // 0x90
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.List`1<uint>> _eventTable; // 0x98
        public System.Collections.Generic.Dictionary`2<System.ValueTuple`2<string,string>,string> _symbolNameCache; // 0xA0
        public Unity.Profiling.ProfilerMarker _managedUpdateProfilerMarker; // 0x10
        public Unity.Profiling.ProfilerMarker _managedLateUpdateProfilerMarker; // 0x18
        public Unity.Profiling.ProfilerMarker _managedFixedUpdateProfilerMarker; // 0x20
        public Unity.Profiling.ProfilerMarker _postLateUpdateProfilerMarker; // 0x28
        public System.Collections.Generic.SortedDictionary`2<uint,System.ValueTuple`2<uint,uint>> _variableToChangeEvent; // 0xA8
        public System.Collections.Generic.List`1<VRC.Udon.AbstractUdonBehaviourEventProxy> _eventProxies; // 0xB0
        public string serializedPublicVariablesBytesString; // 0xB8
        public System.Collections.Generic.List`1<UnityEngine.Object> publicVariablesUnityEngineObjects; // 0xC0
        public 0x6B223B70 publicVariablesSerializationDataFormat; // 0xC8
        public Unity.Profiling.ProfilerMarker _preloadUdonProgramProfilerMarker; // 0xD0
        public Unity.Profiling.ProfilerMarker _initializeUdonContentProfilerMarker; // 0xD8

        // ── Methods ──
        public void get_SyncMethod(){} // RVA: 0x7FFAC9E896D0
        public void set_SyncMethod(){} // RVA: 0x7FFAC9E896F0
        public void get_HasDoneStart(){} // RVA: 0x7FFAC3E04950
        public void get_HasError(){} // RVA: 0x7FFAC3E003A0
        public void get_SyncIsContinuous(){} // RVA: 0x7FFAC9E89A70
        public void get_SyncIsManual(){} // RVA: 0x7FFAC9E89AA0
        public void get_OnInit(){} // RVA: 0x7FFAC9E89AD0
        public void set_OnInit(){} // RVA: 0x7FFAC9E89B30
        public void get_RequestSerializationHook(){} // RVA: 0x7FFAC9E89BE0
        public void set_RequestSerializationHook(){} // RVA: 0x7FFAC9E89C40
        public void get_DisableInteractive(){} // RVA: 0x7FFAC313F600
        public void set_DisableInteractive(){} // RVA: 0x7FFAC3892770
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFAC8AC3600
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFAC9E89D00
        public void get_IsInteractive(){} // RVA: 0x7FFAC9E89D70
        public void get_UpdateOrder(){} // RVA: 0x7FFAC9E89DB0
        public void get_DisableEventProcessing(){} // RVA: 0x7FFAC778CF40
        public void set_DisableEventProcessing(){} // RVA: 0x7FFAC87B5A20
        public void get_ProgramId(){} // RVA: 0x7FFAC9E89E10
        public void get_ProgramSize(){} // RVA: 0x7FFAC9E89F00
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC9E8A100 | overloaded x2
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7FFAC9E8A210
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFAC9E8A370
        public void get_IsInitialized(){} // RVA: 0x7FFAC8AC35F0
        public void GetComponentIndexFixed(){} // RVA: 0x7FFAC9E8A490
        public void LoadProgram(){} // RVA: 0x7FFAC9E8A4F0
        public void RegisterEventProxy(){} // RVA: 0x7FFAC2C70980
        public void ProcessEntryPoints(){} // RVA: 0x7FFAC9E8AAD0
        public void DetectExistingProxies(){} // RVA: 0x7FFAC9E8B6E0
        public void ResolveUdonHeapReferences(){} // RVA: 0x7FFAC9E8B9D0
        public void ResolveUdonHeapReference(){} // RVA: 0x7FFAC9E8BD20
        public void ManagedUpdate(){} // RVA: 0x7FFAC9E8C0F0
        public void ManagedLateUpdate(){} // RVA: 0x7FFAC9E8C2A0
        public void ManagedFixedUpdate(){} // RVA: 0x7FFAC9E8C3C0
        public void PostLateUpdate(){} // RVA: 0x7FFAC9E8C4E0
        public void OnAnimatorIK(){} // RVA: 0x7FFAC9E8C600
        public void ProxyOnAnimatorMove(){} // RVA: 0x7FFAC9E8C750
        public void ProxyOnAudioFilterRead(){} // RVA: 0x7FFAC9E8C7A0
        public void OnBecameInvisible(){} // RVA: 0x7FFAC9E8C970
        public void OnBecameVisible(){} // RVA: 0x7FFAC9E8C9C0
        public void OnCollisionEnter(){} // RVA: 0x7FFAC9E8CA10
        public void OnCollisionEnter2D(){} // RVA: 0x7FFAC9E8CC80
        public void OnCollisionExit(){} // RVA: 0x7FFAC9E8CE80
        public void OnCollisionExit2D(){} // RVA: 0x7FFAC9E8D0F0
        public void ProxyOnCollisionStay(){} // RVA: 0x7FFAC9E8D2F0
        public void OnCollisionStay2D(){} // RVA: 0x7FFAC9E8D560
        public void OnDestroy(){} // RVA: 0x7FFAC9E8D760
        public void OnDisable(){} // RVA: 0x7FFAC9E8DD60
        public void OnDrawGizmos(){} // RVA: 0x7FFAC9E8DDC0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC9E8DE10
        public void OnEnable(){} // RVA: 0x7FFAC9E8DE60
        public void OnJointBreak(){} // RVA: 0x7FFAC9E8DEC0
        public void OnJointBreak2D(){} // RVA: 0x7FFAC9E8E040
        public void OnMouseDown(){} // RVA: 0x7FFAC9E8E160
        public void OnMouseDrag(){} // RVA: 0x7FFAC9E8E1B0
        public void OnMouseEnter(){} // RVA: 0x7FFAC9E8E200
        public void OnMouseExit(){} // RVA: 0x7FFAC9E8E250
        public void OnMouseOver(){} // RVA: 0x7FFAC9E8E2A0
        public void OnMouseUp(){} // RVA: 0x7FFAC9E8E2F0
        public void OnMouseUpAsButton(){} // RVA: 0x7FFAC9E8E340
        public void OnParticleCollision(){} // RVA: 0x7FFAC9E8E390
        public void OnParticleTrigger(){} // RVA: 0x7FFAC9E8E560
        public void OnPostRender(){} // RVA: 0x7FFAC9E8E5B0
        public void OnPreCull(){} // RVA: 0x7FFAC9E8E600
        public void OnPreRender(){} // RVA: 0x7FFAC9E8E650
        public void OnRenderImage(){} // RVA: 0x7FFAC9E8E6A0
        public void ProxyOnRenderObject(){} // RVA: 0x7FFAC9E8E910
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFAC9E8E960
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC9E8E9B0
        public void OnTriggerEnter(){} // RVA: 0x7FFAC9E8EA00
        public void OnTriggerEnter2D(){} // RVA: 0x7FFAC9E8EDF0
        public void OnTriggerExit(){} // RVA: 0x7FFAC9E8EFF0
        public void OnTriggerExit2D(){} // RVA: 0x7FFAC9E8F3E0
        public void ProxyOnTriggerStay(){} // RVA: 0x7FFAC9E8F5E0
        public void OnTriggerStay2D(){} // RVA: 0x7FFAC9E8F9D0
        public void OnControllerColliderHit(){} // RVA: 0x7FFAC9E8FBD0
        public void OnValidate(){} // RVA: 0x7FFAC9E90060
        public void ProxyOnWillRenderObject(){} // RVA: 0x7FFAC9E900B0
        public void OnNetworkReady(){} // RVA: 0x7FFAC9E90100
        public void Interact(){} // RVA: 0x7FFAC9E90110
        public void OnDrop(){} // RVA: 0x7FFAC9E90160
        public void OnPickup(){} // RVA: 0x7FFAC9E901B0
        public void OnPickupUseDown(){} // RVA: 0x7FFAC9E90200
        public void OnPickupUseUp(){} // RVA: 0x7FFAC9E90250
        public void OnPreSerialization(){} // RVA: 0x7FFAC9E902A0
        public void OnPostSerialization(){} // RVA: 0x7FFAC9E90430
        public void OnDeserialization(){} // RVA: 0x7FFAC9E906C0
        public void RunProgram(){} // RVA: 0x7FFAC9E90A50 | overloaded x2
        public void GetPrograms(){} // RVA: 0x7FFAC9E91040
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC9E91100
        public void DeserializePublicVariables(){} // RVA: 0x7FFAC9E91110
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC9E91590
        public void SerializePublicVariables(){} // RVA: 0x7FFAC9E91590
        public void TryToInterrogateUdon(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void RunEvent(){} // RVA: 0x7FFAC31D9390 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x7FFAC9E919E0 | overloaded x10
        public void RunInputEvent(){} // RVA: 0x7FFAC9E91D20
        public void GetEventParameterName(){} // RVA: 0x7FFAC9E91FC0
        public void PreloadUdonProgram(){} // RVA: 0x7FFAC9E922B0
        public void SearchUdonInterface(){} // RVA: 0x7FFAC2E8DC40
        public void InitializeUdonContent(){} // RVA: 0x7FFAC9E92510
        public void RunOnInit(){} // RVA: 0x7FFAC9E92D80
        public void RegisterUpdate(){} // RVA: 0x7FFAC9E92F30
        public void UnregisterUpdate(){} // RVA: 0x7FFAC9E935C0
        public void SendCustomEvent(){} // RVA: 0x7FFAC9E93AE0
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFAC9E93F60 | overloaded x9
        public void RequestSerialization(){} // RVA: 0x7FFAC9E93FF0
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7FFAC9E940A0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7FFAC9E94220
        public void get_InteractionText(){} // RVA: 0x7FFAC2F4F130
        public void set_InteractionText(){} // RVA: 0x7FFAC2F22E90
        public void get_SyncMetadataTable(){} // RVA: 0x7FFAC9E943B0
        public void GetProgramVariableType(){} // RVA: 0x7FFAC9E94410
        public void SetProgramVariable(){} // RVA: 0x7FFAC9E94520 | overloaded x2
        public void SetHeapVariable(){} // RVA: 0x7FFAC2E8DC40
        public void GetProgramVariable(){} // RVA: 0x7FFAC9E94660 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFAC9E947C0 | overloaded x2
        public void SetupLogging(){} // RVA: 0x7FFAC9E949F0
        public void AssignProgramAndVariables(){} // RVA: 0x7FFAC9E94B30
        public void .ctor(){} // RVA: 0x7FFAC9E94BE0
        public void .cctor(){} // RVA: 0x7FFAC9E94FF0
    }

    /// <summary>Originally: ÎÍÌÎÎÏÌÌÏÌÍÏÎÏÎÌÌÌÍÍÌÏÏ</summary>
    public class UdonBehaviourResultBytes_CF3F_CF3F : Object
    {
        public float _result;
        public int _url;
        public float _errorCode;
        public System.Threading.CancellationTokenSource _error; // 0x10
        public string _udonBehaviour; // 0x18
        public byte[] _resultBytes; // 0x20
        public string <ÌÌÌÏÎÎÍÎÎÎÎÌÍÎÌÌÌÏÌÌÌÌÏ>k__BackingField; // 0x28
        public int <ÏÎÌÏÎÍÍÎÎÎÍÍÍÍÌÌÎÎÎÌÎÎÍ>k__BackingField; // 0x30
        public VRC.SDKBase.VRCUrl <ÍÌÍÏÌÌÎÎÎÌÏÏÍÍÎÍÍÎÌÌÏÌÎ>k__BackingField; // 0x38
        public VRC.Udon.Common.Interfaces.IUdonEventReceiver <ÎÌÍÏÎÍÏÌÌÏÎÌÏÏÌÏÏÏÏÎÍÌÍ>k__BackingField; // 0x40

        // ── Methods ──
        public void GetSessionId(){} // RVA: 0x7FFAC31D0140
        public void .ctor(){} // RVA: 0x7FFAC31D0150
        public void Initialize(){} // RVA: 0x7FFAC31D02C0
        public void get_Result(){} // RVA: 0x7FFAC31D04E0
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void AddSubtraction(){} // RVA: 0x7FFAC2F22E90
        public void get_Url(){} // RVA: 0x7FFAC31D0140
        public void set_ValidatingStreamVersion(){} // RVA: 0x7FFAC2F7CCE0
        public void set_name(){} // RVA: 0x7FFAC2F7CCE0
        public void Instantiate(){} // RVA: 0x7FFAC2F4F130
        public void CancelDownload(){} // RVA: 0x7FFAC31D0590
        public void set_ErrorCode(){} // RVA: 0x7FFAC31D0600
        public void StartDownload(){} // RVA: 0x7FFAC31D0820
        public void set_Error(){} // RVA: 0x7FFAC31D0590
        public void get_ErrorCode(){} // RVA: 0x7FFAC2F7CCD0
        public void SetOverlay(){} // RVA: 0x7FFAC2F49200
        public void get_Error(){} // RVA: 0x7FFAC2F4F130
        public void get_UdonBehaviour(){} // RVA: 0x7FFAC2F9E740
        public void set_element(){} // RVA: 0x7FFAC31D0C20
        public void SetCurrentSocket(){} // RVA: 0x7FFAC2F4F0D0
        public void get_ResultBytes(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ResultBytes(){} // RVA: 0x7FFAC31D0C80
    }

    /// <summary>Originally: ÍÌÎÍÍÎÍÏÌÍÍÎÎÍÎÌÎÏÌÏÎÌÏ</summary>
    public class UdonDisableEventProcessing_A521_A521 : AbstractUdonBehaviour
    {
        public bool _disableInteractive; // 0x40
        public bool _syncMethod; // 0x41
        public bool _disableEventProcessing; // 0x42
        public string _syncMetadataTable; // 0x48
        public 0x6B24EE60 _interactionText; // 0x50
        public VRC.SDK3.UdonNetworkCalling.NetworkCallingEntrypointMetadata[] _isNetworkingSupported; // 0x58
        public System.Collections.Generic.Dictionary`2<uint,string> f_71F; // 0x60
        public System.Collections.Generic.Dictionary`2<string,uint> f_297; // 0x68
        public System.Collections.Generic.Dictionary`2<string,object> ÍÏÎÏÏÏÎÏÍÏÌÏÍÎÍÎÎÏÌÍÏÍÎ; // 0x70
        public ÌÍÎÍÏÌÌÏÎÎÎÌÎÍÍÍÎÎÌÌÏÍÏ <ÌÌÌÍÎÌÍÍÎÌÎÌÎÌÌÍÏÍÌÌÏÎÌ>k__BackingField; // 0x78

        // ── Methods ──
        public void RunEvent(){} // RVA: 0x7FFAC2E8DC40 | overloaded x10
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFAC31D9350 | overloaded x9
        public void RunEventAdvanced(){} // RVA: 0x7FFAC2E8DC40 | overloaded x10
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFAC31D8450
        public void GetProgramVariable(){} // RVA: 0x7FFAC31D9250 | overloaded x2
        public void get_DisableInteractive(){} // RVA: 0x7FFAC2FDCC00
        public void SetResources(){} // RVA: 0x7FFAC2FE9510
        public void Interact(){} // RVA: 0x7FFAC2F21310
        public void SetResources_5DD4CA70B94E(){} // RVA: 0x7FFAC2FE9510
        public void SendCustomNetworkEvent_57FA4903FC5C(){} // RVA: 0x7FFAC31D84C0
        public void SetProgramVariable(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SendCustomNetworkEvent_E8BBCBCF8EFE(){} // RVA: 0x7FFAC31D86A0
        public void GetComponentIndexFixed(){} // RVA: 0x7FFAC31D8770
        public void InitializeUdonContent(){} // RVA: 0x7FFAC2F21310
        public void get_SyncMethod(){} // RVA: 0x7FFAC30F10E0
        public void SetResources_80B0DF0B7577(){} // RVA: 0x7FFAC2FE9510
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7FFAC31D87C0
        public void RunProgram(){} // RVA: 0x7FFAC31D8830
        public void SetResources_E6C8FFA046A7(){} // RVA: 0x7FFAC2FE9510
        public void get_IsNetworkingSupported_7EC8FF59A5F1(){} // RVA: 0x7FFAC31D8940
        public void set_DisableInteractive(){} // RVA: 0x7FFAC2FDCC10
        public void set_DisableEventProcessing(){} // RVA: 0x7FFAC31D8A10
        public void OnSerializing(){} // RVA: 0x7FFAC2FE9500
        public void get_DisableEventProcessing(){} // RVA: 0x7FFAC31D8A60
        public void set_imageUrl(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFAC31D8A70
        public void RunEvent_39E8053A03C2(){} // RVA: 0x7FFAC31D8C70
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFAC2FE9500 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFAC2C5D200 | overloaded x2
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7FFAC31D8F90
        public void get_SyncMetadataTable(){} // RVA: 0x7FFAC31D8FD0
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFAC30E5600
        public void get_InteractionText(){} // RVA: 0x7FFAC2F9C730
        public void set_SyncMethod(){} // RVA: 0x7FFAC31D9010
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFAC31D90A0
        public void set_InteractionText(){} // RVA: 0x7FFAC2F9C740
        public void GetProgramVariableType(){} // RVA: 0x7FFAC31D90B0
        public void SendCustomEvent(){} // RVA: 0x7FFAC31D9140
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFAC31D9200
        public void DoThrowUInt16OverflowException(){} // RVA: 0x7FFAC30E06F0
        public void RunInputEvent(){} // RVA: 0x7FFAC31D92D0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7FFAC31D9310
        public void RequestSerialization(){} // RVA: 0x7FFAC2F21310
        public void GetPlaybackQualityStats_559E674D3E83(){} // RVA: 0x7FFAC30E5600
    }

    public class UdonManager : MonoBehaviour
    {
        public System.Action`1<VRC.Udon.Common.Interfaces.IUdonProgram> HasLoaded;
        public System.Action Instance; // 0x8
        public VRC.Udon.UdonBehaviour SignatureVerificationFailed; // 0x20
        public bool SignatureVerificationSuccess; // 0x28
        public VRC.Udon.UdonManager SignatureVerificationSkipped; // 0x10
        public UpdateOrderComparer WorldSignatureVerificationEnabled; // 0x18
        public bool IsSceneLoading; // 0x29
        public bool DebugLogging; // 0x2A
        public System.Collections.Generic.Dictionary`2<UnityEngine.SceneManagement.Scene,System.Collections.Generic.Dictionary`2<UnityEngine.GameObject,System.Collections.Generic.HashSet`1<VRC.Udon.UdonBehaviour>>> LightReservedLayerMask; // 0x30
        public System.Collections.Generic.HashSet`1<VRC.Udon.UdonBehaviour> _udonBehavioursToRegister; // 0x38
        public System.Threading.ThreadLocal`1<int> _udonRunProgramDepth; // 0x40
        public System.Collections.Generic.SortedSet`1<VRC.Udon.UdonBehaviour> _updateUdonBehaviours; // 0x48
        public System.Collections.Generic.SortedSet`1<VRC.Udon.UdonBehaviour> _lateUpdateUdonBehaviours; // 0x50
        public System.Collections.Generic.SortedSet`1<VRC.Udon.UdonBehaviour> _fixedUpdateUdonBehaviours; // 0x58
        public System.Collections.Generic.SortedSet`1<VRC.Udon.UdonBehaviour> _postLateUpdateUdonBehaviours; // 0x60
        public System.Collections.Generic.Queue`1<System.ValueTuple`2<VRC.Udon.UdonBehaviour,bool>> _updateUdonBehavioursRegistrationQueue; // 0x68
        public System.Collections.Generic.Queue`1<System.ValueTuple`2<VRC.Udon.UdonBehaviour,bool>> _lateUpdateUdonBehavioursRegistrationQueue; // 0x70
        public System.Collections.Generic.Queue`1<System.ValueTuple`2<VRC.Udon.UdonBehaviour,bool>> _fixedUpdateUdonBehavioursRegistrationQueue; // 0x78
        public System.Collections.Generic.Queue`1<System.ValueTuple`2<VRC.Udon.UdonBehaviour,bool>> _postLateUpdateUdonBehavioursRegistrationQueue; // 0x80
        public PostLateUpdater _postLateUpdater; // 0x88
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.HashSet`1<VRC.Udon.UdonBehaviour>> _inputUdonBehaviours; // 0x90
        public System.Collections.Generic.Queue`1<System.ValueTuple`3<VRC.Udon.UdonBehaviour,string,bool>> _inputUpdateUdonBehavioursRegistrationQueue; // 0x98
        public string UDON_EVENT_ONPLAYERRESPAWN;
        public string UDON_EVENT_ONPLAYERDATAUPDATED;
        public string UDON_EVENT_ONPLAYERRESTORED;
        public string UDON_EVENT_ONINSTANCERESTORED;
        public string UDON_EVENT_ONDESERIALIZATION;
        public string UDON_EVENT_ONSCREENUPDATE;
        public int UDON_MAX_RUNPROGRAM_DEPTH;
        public string UDON_EVENT_ONPOSTSERIALIZATION;
        public string UDON_EVENT_ONPRESERIALIZATION;
        public string UDON_EVENT_ONPERSISTENCEUSAGEUPDATED;
        public string UDON_EVENT_ONPLAYERDATASTORAGEEXCEEDED;
        public string UDON_EVENT_ONPLAYERDATASTORAGEWARNING;
        public string UDON_EVENT_ONPLAYEROBJECTSTORAGEEXCEEDED;
        public string UDON_EVENT_ONPLAYEROBJECTSTORAGEWARNING;
        public string UDON_EVENT_ONINSTANCESTORAGEEXCEEDED;
        public string UDON_EVENT_ONINSTANCESTORAGEWARNING;
        public System.Collections.Generic.HashSet`1<string> _inputActionNames; // 0xA0
        public string UDON_INPUT_JUMP;
        public string UDON_INPUT_USE;
        public string UDON_INPUT_GRAB;
        public string UDON_INPUT_DROP;
        public string UDON_MOVE_VERTICAL;
        public string UDON_MOVE_HORIZONTAL;
        public string UDON_LOOK_VERTICAL;
        public string UDON_LOOK_HORIZONTAL;
        public string UDON_EVENT_ONINPUTMETHODCHANGED;
        public string UDON_EVENT_ONLANGUAGECHANGED;
        public string UDON_EVENT_ONVRCPLUSMASSGIFT;
        public UdonTimeSource _udonTimeSource; // 0xA8
        public VRC.Udon.Security.Interfaces.IUdonSecurityBlacklist`1<UnityEngine.Object> _blacklist; // 0xB0
        public VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface _udonClientInterface; // 0xB8
        public VRC.Udon.Common.Interfaces.IUdonEventScheduler _udonEventScheduler; // 0xC0
        public int _signatureVerificationFailed; // 0xC8
        public int _signatureVerificationSuccess; // 0xCC
        public int _signatureVerificationSkipped; // 0xD0
        public bool <WorldSignatureVerificationEnabled>k__BackingField; // 0xD4
        public VerifyKey _signatureVerificationKey; // 0xD8
        public System.Collections.Concurrent.ConcurrentDictionary`2<VRC.Udon.Security.IUdonSignatureHolder,byte> _verificationCache; // 0xE0
        public System.Collections.Generic.List`1<VRC.Udon.IUdonTriggerEventConsumer> _triggerEventConsumers; // 0xE8
        public Unity.Profiling.ProfilerMarker _preloadProfilerMarker; // 0xF0
        public Unity.Profiling.ProfilerMarker _initializeProfilerMarker; // 0xF8
        public bool <IsSceneLoading>k__BackingField; // 0x100
        public System.Collections.Generic.List`1<VRC.Udon.UdonBehaviour> UdonBehavioursInScene; // 0x108

        // ── Methods ──
        public void add_OnUdonProgramLoaded(){} // RVA: 0x7FFAC9E952E0
        public void remove_OnUdonProgramLoaded(){} // RVA: 0x7FFAC9E95440
        public void add_OnUdonReady(){} // RVA: 0x7FFAC9E955A0
        public void remove_OnUdonReady(){} // RVA: 0x7FFAC9E956F0
        public void get_HasLoaded(){} // RVA: 0x7FFAC30F6BA0
        public void set_HasLoaded(){} // RVA: 0x7FFAC3C24F40
        public void get_Instance(){} // RVA: 0x7FFAC9E95840
        public void get_SignatureVerificationFailed(){} // RVA: 0x7FFAC3641480
        public void get_SignatureVerificationSuccess(){} // RVA: 0x7FFAC43065A0
        public void get_SignatureVerificationSkipped(){} // RVA: 0x7FFAC3696B20
        public void get_WorldSignatureVerificationEnabled(){} // RVA: 0x7FFAC47BB0F0
        public void set_WorldSignatureVerificationEnabled(){} // RVA: 0x7FFAC47BB100
        public void ResetWorldSignatureVerification(){} // RVA: 0x7FFAC9E958A0
        public void EnableWorldSignatureVerification(){} // RVA: 0x7FFAC9E95910
        public void RegisterTriggerEventConsumer(){} // RVA: 0x7FFAC9E959D0
        public void UnregisterTriggerEventConsumer(){} // RVA: 0x7FFAC9E95BF0
        public void TryNotifyOnTriggerEnterConsumers(){} // RVA: 0x7FFAC9E95C60
        public void TryNotifyOnTriggerExitConsumers(){} // RVA: 0x7FFAC9E95E00
        public void TryNotifyOnTriggerStayConsumers(){} // RVA: 0x7FFAC9E95FA0
        public void Awake(){} // RVA: 0x7FFAC9E96140
        public void Update(){} // RVA: 0x7FFAC9E96A50
        public void LateUpdate(){} // RVA: 0x7FFAC9E97100
        public void FixedUpdate(){} // RVA: 0x7FFAC9E97740
        public void PostLateUpdate(){} // RVA: 0x7FFAC9E97D80
        public void OnDestroy(){} // RVA: 0x7FFAC9E98480
        public void GetWrapperModule(){} // RVA: 0x7FFAC2E8DC40
        public void RegisterInput(){} // RVA: 0x7FFAC9E985F0
        public void RunInputAction(){} // RVA: 0x7FFAC9E986D0
        public void UpdateInputQueue(){} // RVA: 0x7FFAC9E98A10
        public void get_IsSceneLoading(){} // RVA: 0x7FFAC3C8B9C0
        public void set_IsSceneLoading(){} // RVA: 0x7FFAC3C8DFF0
        public void OnSceneLoaded(){} // RVA: 0x7FFAC9E98DF0
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7FFAC9E9A350
        public void ProcessUdonProgram(){} // RVA: 0x7FFAC9E9A4B0
        public void OnSceneUnloaded(){} // RVA: 0x7FFAC9E9A530
        public void PurgeSerializationCaches(){} // RVA: 0x7FFAC9E9A5A0
        public void GetTotalLoadedProgramSize(){} // RVA: 0x7FFAC9E9A710
        public void GetLoadedBehavioursSyncTypes(){} // RVA: 0x7FFAC9E9AEB0
        public void RegisterUdonBehaviourUpdate(){} // RVA: 0x7FFAC9E9B420
        public void RegisterUdonBehaviourLateUpdate(){} // RVA: 0x7FFAC9E9B500
        public void RegisterUdonBehaviourFixedUpdate(){} // RVA: 0x7FFAC9E9B5E0
        public void RegisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7FFAC9E9B6C0
        public void UnregisterUdonBehaviourUpdate(){} // RVA: 0x7FFAC9E9B800
        public void UnregisterUdonBehaviourLateUpdate(){} // RVA: 0x7FFAC9E9B8E0
        public void UnregisterUdonBehaviourFixedUpdate(){} // RVA: 0x7FFAC9E9B9C0
        public void UnregisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7FFAC9E9BAA0
        public void ScheduleDelayedEvent(){} // RVA: 0x7FFAC9E9BC70 | overloaded x2
        public void HandleUdonEventScheduled(){} // RVA: 0x7FFAC9E9BD60
        public void SetUdonEnabled(){} // RVA: 0x7FFAC43B4D70
        public void IncrementDepthCount(){} // RVA: 0x7FFAC9E9BDE0
        public void DecrementDepthCount(){} // RVA: 0x7FFAC9E9BEF0
        public void get_DebugLogging(){} // RVA: 0x7FFAC9E9BFB0
        public void set_DebugLogging(){} // RVA: 0x7FFAC9E9C000
        public void ConstructUdonVM(){} // RVA: 0x7FFAC9E9C070
        public void ApplyFilter(){} // RVA: 0x7FFAC9E9C1C0 | overloaded x2
        public void Blacklist(){} // RVA: 0x7FFAC9E9C140 | overloaded x2
        public void CleanBlacklist(){} // RVA: 0x7FFAC9E9C220
        public void IsBlacklisted(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFAC9E9C2D0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFAC9E9C330
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFAC9E9C390
        public void GetWrapper(){} // RVA: 0x7FFAC9E9C3F0
        public void RegisterUdonBehaviour(){} // RVA: 0x7FFAC9E9C440
        public void UnregisterUdonBehaviour(){} // RVA: 0x7FFAC9E9C760
        public void CheckUdonBehavioursToRegister(){} // RVA: 0x7FFAC9E9C8D0
        public void GetUdonBehavioursInScene(){} // RVA: 0x7FFAC9E9CA00
        public void RunEvent(){} // RVA: 0x7FFAC9E9DE00 | overloaded x10
        public void .ctor(){} // RVA: 0x7FFAC9E9E080
        public void .cctor(){} // RVA: 0x7FFAC9E9EFD0
        public void <OnSceneLoaded>b__102_0(){} // RVA: 0x7FFAC9E9F090
    }

    /// <summary>Originally: ÎÎÎÏÍÎÌÏÏÍÎÏÍÍÌÏÎÌÏÎÍÌÎ</summary>
    public class UdonOperationResponsImpl_9030_9030 : UdonOperationResponseDisconnectMessage_331A_331A
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45A8360
    }

    /// <summary>Originally: ÍÎÏÏÍÌÏÏÌÍÎÍÎÍÍÎÏÌÏÏÎÌÏ</summary>
    public class UdonOperationResponseDiscRelated_074E : ValueType
    {
        public UIntPtr f_3F2; // 0x10
        public System.ArraySegment`1<byte> f_653; // 0x18
        public uint f_02C; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3157800
        public void InternalEquals(){} // RVA: 0x7FFAC3AD9F60
        public void DefaultEquals(){} // RVA: 0x7FFAC45BB120
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC392CD10
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC45BB120
        // ── Unresolved (hash) ──
        public void m_BAD(){} // RVA: 0x7FFAC4A927E0
        public void m_848(){} // RVA: 0x7FFAC4A927D0
        public void m_440(){} // RVA: 0x7FFAC3157800
        public void m_9A6(){} // RVA: 0x7FFAC3AD9F60
        public void m_CF7(){} // RVA: 0x7FFAC4A927E0
        public void m_E37(){} // RVA: 0x7FFAC4A927E0
    }

    /// <summary>Originally: ÏÍÍÏÍÌÍÌÌÎÏÎÎÏÍÌÌÍÌÎÏÌÏ</summary>
    public class UdonOperationResponseDiscRelated_10CB : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ _10CB; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC38DFE40
        public void InternalEquals(){} // RVA: 0x7FFAC38DFE40
        public void DefaultEquals(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AD9F60
        // ── Unresolved (hash) ──
        public void m_ACD(){} // RVA: 0x7FFAC3AD9F60
        public void m_3F3(){} // RVA: 0x7FFAC38DFE40
    }

    /// <summary>Originally: ÌÌÌÏÌÌÏÌÎÌÌÏÏÌÌÎÎÌÏÍÎÎÌ</summary>
    public class UdonOperationResponseDiscRelated_1332 : ValueType
    {
        public ÎÏÍÌÌÎÎÍÍÍÏÎÌÍÎÌÎÍÍÎÍÌÌ f_A6E; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_C4D; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_A81; // 0x20
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_64B; // 0x28
        public uint f_838; // 0x30

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC30DBBE0
        public void DefaultEquals(){} // RVA: 0x7FFAC2F22E30
        public void GetHashCode(){} // RVA: 0x7FFAC2F247C0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420240
        public void ToString(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4420220
        // ── 11 unresolved (hash) ──
        public void m_ACD(){} // RVA: 0x7FFAC3AD9F60
        public void m_7AE(){} // RVA: 0x7FFAC2F22E30
        public void m_9B4(){} // RVA: 0x7FFAC2F87E80
        public void m_94A(){} // RVA: 0x7FFAC4420220
        public void m_BFB(){} // RVA: 0x7FFAC2F3C380
        // ... 6 more unresolved methods
    }

    /// <summary>Originally: ÍÎÌÏÎÎÍÍÍÌÍÏÏÎÎÍÌÏÌÍÌÌÍ</summary>
    public class UdonOperationResponseDiscRelated_2323 : ValueType
    {
        public object f_34B; // 0x10
        public UIntPtr f_6BE; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4420220
        public void InternalEquals(){} // RVA: 0x7FFAC4420220
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC34F9180
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420220
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC34F9180
        // ── Unresolved (hash) ──
        public void m_A2B(){} // RVA: 0x7FFAC34F9180
        public void m_FB5(){} // RVA: 0x7FFAC4A068C0
        public void m_649(){} // RVA: 0x7FFAC3AD9F60
        public void m_376(){} // RVA: 0x7FFAC34F9180
        public void m_EBC(){} // RVA: 0x7FFAC3AD9F60
        public void m_E5F(){} // RVA: 0x7FFAC3AD9F60
        public void m_EAC(){} // RVA: 0x7FFAC4A068C0
    }

    /// <summary>Originally: ÌÏÍÏÏÏÌÎÌÍÏÎÌÏÌÍÎÏÏÌÍÏÍ</summary>
    public class UdonOperationResponseDiscRelated_2EB5 : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_272; // 0x10
        public 0x6B100898 f_AA8; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC49C7510
        public void InternalEquals(){} // RVA: 0x7FFAC49C7510
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC49C7500
        public void ToString(){} // RVA: 0x7FFAC49C7510
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC49C7510
        // ── Unresolved (hash) ──
        public void m_E9C(){} // RVA: 0x7FFAC49C7500
        public void m_83F(){} // RVA: 0x7FFAC3AD9F60
        public void m_7C5(){} // RVA: 0x7FFAC38DFE40
        public void m_717(){} // RVA: 0x7FFAC49C7500
    }

    /// <summary>Originally: ÌÌÎÎÍÌÎÌÎÏÏÏÌÎÏÎÌÎÎÌÌÌÌ</summary>
    public class UdonOperationResponseDiscRelated_306B : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_838; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_892; // 0x18
        public 0x6B0E5D50 f_A66; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC4420220
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC4420240
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420220
        public void ToString(){} // RVA: 0x7FFAC4420220
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AD9F60
        // ── Unresolved (hash) ──
        public void m_365(){} // RVA: 0x7FFAC4420240
        public void m_B15(){} // RVA: 0x7FFAC4420240
        public void m_EFA(){} // RVA: 0x7FFAC2F6E5C0
        public void m_619(){} // RVA: 0x7FFAC2F6E5C0
        public void m_60C(){} // RVA: 0x7FFAC2F240C0
        public void m_CB4(){} // RVA: 0x7FFAC2F6E5C0
        public void m_6A0(){} // RVA: 0x7FFAC4420220
    }

    /// <summary>Originally: ÎÏÌÎÏÌÌÌÌÌÍÎÌÌÎÍÍÏÍÍÎÎÏ</summary>
    public class UdonOperationResponseDiscRelated_3381 : ValueType
    {
        public 0x6B0E5F60 f_309; // 0x10
        public object f_34B; // 0x18
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_94D; // 0x20

        // ── Methods ──
        public void set_curveMin(){} // RVA: 0x7FFAC4420240
        public void ToHashCode(){} // RVA: 0x7FFAC4420210
        public void Initialize(){} // RVA: 0x7FFAC2F22E30
        public void ToString(){} // RVA: 0x7FFAC4420220
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4A65350
        public void Equals(){} // RVA: 0x7FFAC4420220
        public void set_mode(){} // RVA: 0x7FFAC336D8B0
        public void GetHashCode(){} // RVA: 0x7FFAC2F22E30
        // ── Unresolved (hash) ──
        public void m_E5F(){} // RVA: 0x7FFAC4420220
        public void m_AAF(){} // RVA: 0x7FFAC4420210
        public void m_A2B(){} // RVA: 0x7FFAC4A653A0
        public void m_531(){} // RVA: 0x7FFAC4A653F0
        public void m_EBC(){} // RVA: 0x7FFAC4420220
        public void m_084(){} // RVA: 0x7FFAC2F3C380
        public void m_2DA(){} // RVA: 0x7FFAC4420240
    }

    /// <summary>Originally: ÎÌÍÍÏÏÏÏÏÌÎÌÌÎÍÏÎÎÌÏÍÌÏ</summary>
    public class UdonOperationResponseDiscRelated_3C4C : ValueType
    {
        public UIntPtr f_94A; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_627; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_CEE; // 0x20
        public ÎÏÍÍÌÌÌÎÌÌÍÌÎÎÌÏÌÎÍÌÍÎÎ f_ADE; // 0x28
        public bool f_720; // 0x38
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_7A6; // 0x40
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_B74; // 0x48
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_6CF; // 0x50
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_C67; // 0x58
        public 0x6B0F8D30 f_CCA; // 0x60
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_AA3; // 0x68
        public uint f_7EC; // 0x70
        public System.Nullable`1<ÏÌÌÏÎÏÎÍÎÍÌÌÌÏÏÏÍÍÍÌÌÎÍ> f_149; // 0x78
        public ÎÌÌÍÎÍÎÌÎÍÍÎÍÍÎÎÎÌÍÎÎÌÏ f_723; // 0x98
        public UIntPtr f_4AB; // 0xA0
        public System.Nullable`1<double> f_3B8; // 0xA8

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F49200
        public void InternalEquals(){} // RVA: 0x7FFAC2F60010
        public void DefaultEquals(){} // RVA: 0x7FFAC31D95E0
        public void GetHashCode(){} // RVA: 0x7FFAC4B5E6B0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC354E300
        public void ToString(){} // RVA: 0x7FFAC45BB120
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2FE9500
        // ── 32 unresolved (hash) ──
        public void m_9F1(){} // RVA: 0x7FFAC2F60010
        public void m_FFA(){} // RVA: 0x7FFAC2F4F890
        public void m_8B5(){} // RVA: 0x7FFAC4B5E6C0
        public void m_22C(){} // RVA: 0x7FFAC2F9C740
        public void m_464(){} // RVA: 0x7FFAC32EF640
        // ... 27 more unresolved methods
    }

    /// <summary>Originally: ÎÌÍÏÌÌÏÌÏÏÌÎÎÎÏÍÏÏÌÎÏÎÍ</summary>
    public class UdonOperationResponseDiscRelated_4166 : ValueType
    {
        public object f_34B; // 0x10
        public 0x6B10F410 f_63A; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_1C8; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC49C7500
        public void DefaultEquals(){} // RVA: 0x7FFAC2F22E30
        public void GetHashCode(){} // RVA: 0x7FFAC2F3C380
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F22E30
        // ── Unresolved (hash) ──
        public void m_0B6(){} // RVA: 0x7FFAC38DFE40
        public void m_05A(){} // RVA: 0x7FFAC49C7510
        public void m_A2B(){} // RVA: 0x7FFAC34F9180
        public void m_63E(){} // RVA: 0x7FFAC2F3C380
        public void m_C87(){} // RVA: 0x7FFAC49C7500
        public void m_EBC(){} // RVA: 0x7FFAC3AD9F60
        public void m_CB2(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÏÏÍÏÏÎÏÏÌÏÍÍÌÌÏÏÏÍÏÏÍÍÎ</summary>
    public class UdonOperationResponseDiscRelated_4266 : ValueType
    {
        public object f_34B; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_838; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_892; // 0x20
        public ÎÏÍÌÌÎÎÍÍÍÏÎÌÍÎÌÎÍÍÎÍÌÌ f_F1A; // 0x28
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_066; // 0x30
        public 0x6B0E5D50 f_059; // 0x38
        public 0x6B0E5D50 f_A66; // 0x3C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC34F9180
        public void InternalEquals(){} // RVA: 0x7FFAC38DFE40
        public void DefaultEquals(){} // RVA: 0x7FFAC2F247C0
        public void GetHashCode(){} // RVA: 0x7FFAC2F3C380
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F4F0D0
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC45B6490
        // ── 16 unresolved (hash) ──
        public void m_619(){} // RVA: 0x7FFAC3C891D0
        public void m_6A0(){} // RVA: 0x7FFAC2F3C380
        public void m_3C3(){} // RVA: 0x7FFAC2F4F0D0
        public void m_953(){} // RVA: 0x7FFAC4420240
        public void m_92D(){} // RVA: 0x7FFAC32EC4C0
        // ... 11 more unresolved methods
    }

    /// <summary>Originally: ÍÍÍÎÏÍÎÏÍÏÍÍÍÏÎÌÍÌÎÏÌÎÌ</summary>
    public class UdonOperationResponseDiscRelated_436D : ValueType
    {
        public object f_34B; // 0x10
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_A6E; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ[] f_0B7; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F3C380
        public void InternalEquals(){} // RVA: 0x7FFAC34F9180
        public void DefaultEquals(){} // RVA: 0x7FFAC2F22E30
        public void GetHashCode(){} // RVA: 0x7FFAC4420240
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC4420240
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F3C380
        // ── Unresolved (hash) ──
        public void m_385(){} // RVA: 0x7FFAC38DFE40
        public void m_CB2(){} // RVA: 0x7FFAC3AD9F60
        public void m_649(){} // RVA: 0x7FFAC3AD9F60
        public void m_1C3(){} // RVA: 0x7FFAC3AD9F60
        public void m_497(){} // RVA: 0x7FFAC38DFE40
        public void m_328(){} // RVA: 0x7FFAC2F3C380
        public void m_0C5(){} // RVA: 0x7FFAC3AD9F60
        public void m_76B(){} // RVA: 0x7FFAC2F22E30
        public void m_ACD(){} // RVA: 0x7FFAC4420220
    }

    /// <summary>Originally: ÎÌÍÎÎÌÏÌÌÍÍÌÏÏÎÎÍÌÍÏÎÏÍ</summary>
    public class UdonOperationResponseDiscRelated_4765 : ValueType
    {
        public ÎÏÍÌÌÎÎÍÍÍÏÎÌÍÎÌÎÍÍÎÍÌÌ f_A6E; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_A3A; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_C4D; // 0x20
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_DA8; // 0x28
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_64B; // 0x30
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_A81; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F22E90
        public void InternalEquals(){} // RVA: 0x7FFAC3AD9F60
        public void DefaultEquals(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCode(){} // RVA: 0x7FFAC4420240
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F4F0D0
        public void ToString(){} // RVA: 0x7FFAC2F22E30
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F247C0
        // ── 12 unresolved (hash) ──
        public void m_120(){} // RVA: 0x7FFAC2F4F130
        public void m_C14(){} // RVA: 0x7FFAC2F4F130
        public void m_2A0(){} // RVA: 0x7FFAC4420220
        public void m_ACD(){} // RVA: 0x7FFAC3AD9F60
        public void m_88E(){} // RVA: 0x7FFAC2F4F0C0
        // ... 7 more unresolved methods
    }

    /// <summary>Originally: ÌÍÍÍÎÎÏÏÌÌÌÍÍÎÏÎÏÎÌÏÎÎÏ</summary>
    public class UdonOperationResponseDiscRelated_4898 : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_A6E; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ[] f_0B7; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4420240
        public void InternalEquals(){} // RVA: 0x7FFAC38DFE40
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420220
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4420220
        // ── Unresolved (hash) ──
        public void m_F0E(){} // RVA: 0x7FFAC3AD9F60
        public void m_76B(){} // RVA: 0x7FFAC4420240
        public void m_AFC(){} // RVA: 0x7FFAC3AD9F60
        public void m_666(){} // RVA: 0x7FFAC4420220
        public void m_876(){} // RVA: 0x7FFAC4420220
    }

    /// <summary>Originally: ÌÎÏÌÏÍÌÎÎÌÌÌÌÍÍÌÌÏÍÌÍÍÍ</summary>
    public class UdonOperationResponseDiscRelated_4AD1 : ValueType
    {
        public 0x6B0E5F60 f_309; // 0x10
        public ÎÏÍÌÌÎÎÍÍÍÏÎÌÍÎÌÎÍÍÎÍÌÌ f_94D; // 0x18
        public object f_34B; // 0x20
        public 0x6B0F9518 f_3E4; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F3C380
        public void InternalEquals(){} // RVA: 0x7FFAC336D8B0
        public void DefaultEquals(){} // RVA: 0x7FFAC336D8B0
        public void GetHashCode(){} // RVA: 0x7FFAC4420220
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420210
        public void ToString(){} // RVA: 0x7FFAC2F22E30
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F3C380
        // ── Unresolved (hash) ──
        public void m_1C2(){} // RVA: 0x7FFAC3157800
        public void m_4EA(){} // RVA: 0x7FFAC4420240
        public void m_A2B(){} // RVA: 0x7FFAC4B60B10
        public void m_385(){} // RVA: 0x7FFAC2F22E30
        public void m_F55(){} // RVA: 0x7FFAC4B60B60
        public void m_430(){} // RVA: 0x7FFAC392CD10
        public void m_5D6(){} // RVA: 0x7FFAC2F22E30
        public void m_531(){} // RVA: 0x7FFAC4B60BB0
    }

    /// <summary>Originally: ÍÎÎÌÌÏÌÏÎÏÌÍÌÎÍÏÏÌÏÌÎÌÏ</summary>
    public class UdonOperationResponseDiscRelated_4B7E : ValueType
    {
        public 0x6B0E5F60 f_309; // 0x10
        public object f_34B; // 0x18
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_94D; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4A6AD40
        public void InternalEquals(){} // RVA: 0x7FFAC4420220
        public void DefaultEquals(){} // RVA: 0x7FFAC4420220
        public void GetHashCode(){} // RVA: 0x7FFAC4420220
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420210
        public void ToString(){} // RVA: 0x7FFAC2F3C380
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC336D8B0
        // ── Unresolved (hash) ──
        public void m_981(){} // RVA: 0x7FFAC2F3C380
        public void m_4EA(){} // RVA: 0x7FFAC2F22E30
        public void m_6CE(){} // RVA: 0x7FFAC2F3C380
        public void m_385(){} // RVA: 0x7FFAC4420240
        public void m_A2B(){} // RVA: 0x7FFAC4A6AD90
        public void m_EBC(){} // RVA: 0x7FFAC4420220
        public void m_08C(){} // RVA: 0x7FFAC4420210
        public void m_084(){} // RVA: 0x7FFAC2F3C380
    }

    /// <summary>Originally: ÏÍÏÍÎÌÌÏÍÍÏÎÍÏÏÏÍÎÌÎÏÌÍ</summary>
    public class UdonOperationResponseDiscRelated_5329 : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_A6E; // 0x10
        public int f_839; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC49C7510
        public void InternalEquals(){} // RVA: 0x7FFAC49C7510
        public void DefaultEquals(){} // RVA: 0x7FFAC49C7500
        public void GetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC49C7500
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC49C7500
        // ── Unresolved (hash) ──
        public void m_96D(){} // RVA: 0x7FFAC38DFE40
        public void m_AFC(){} // RVA: 0x7FFAC3AD9F60
        public void m_872(){} // RVA: 0x7FFAC49C7510
        public void m_5C4(){} // RVA: 0x7FFAC49C7510
        public void m_0DF(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÍÍÎÎÍÎÍÎÍÌÏÎÌÌÎÏÌÌÎÌÏÍÍ</summary>
    public class UdonOperationResponseDiscRelated_6059 : ValueType
    {
        public uint f_8D5; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_272; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC336D8B0
        public void InternalEquals(){} // RVA: 0x7FFAC336D8B0
        public void DefaultEquals(){} // RVA: 0x7FFAC4420210
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420210
        public void ToString(){} // RVA: 0x7FFAC4420220
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4420210
        // ── Unresolved (hash) ──
        public void m_56C(){} // RVA: 0x7FFAC4420240
        public void m_F08(){} // RVA: 0x7FFAC336D8B0
        public void m_F8A(){} // RVA: 0x7FFAC4420240
        public void m_F96(){} // RVA: 0x7FFAC4420240
        public void m_31C(){} // RVA: 0x7FFAC4420220
    }

    /// <summary>Originally: ÌÎÎÎÎÎÏÏÍÌÌÍÌÌÌÍÌÎÏÎÌÌÏ</summary>
    public class UdonOperationResponseDiscRelated_64F4 : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_272; // 0x10
        public int f_690; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC49C7500
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC49C7510
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC49C7510
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC49C7510
        // ── Unresolved (hash) ──
        public void m_33F(){} // RVA: 0x7FFAC49C7500
        public void m_31C(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÎÌÌÌÎÍÌÏÎÎÍÏÎÌÌÏÏÏÌÌÏÌÏ</summary>
    public class UdonOperationResponseDiscRelated_6C2B : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_CEE; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ[] f_D75; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC38DFE40
        public void InternalEquals(){} // RVA: 0x7FFAC4420240
        public void DefaultEquals(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420240
        public void ToString(){} // RVA: 0x7FFAC4420220
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC38DFE40
        // ── Unresolved (hash) ──
        public void m_335(){} // RVA: 0x7FFAC4420220
        public void m_11C(){} // RVA: 0x7FFAC4420240
    }

    /// <summary>Originally: ÏÌÌÏÎÏÎÏÌÍÏÏÏÎÎÍÍÌÏÏÏÎÏ</summary>
    public class UdonOperationResponseDiscRelated_6DA9 : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_A6E; // 0x10
        public uint f_04C; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC3AD9F60
        public void DefaultEquals(){} // RVA: 0x7FFAC49C7500
        public void GetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC49C7510
        // ── Unresolved (hash) ──
        public void m_4C1(){} // RVA: 0x7FFAC49C7510
        public void m_682(){} // RVA: 0x7FFAC49C7510
        public void m_19F(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÎÌÍÍÏÌÍÏÌÏÎÏÏÏÌÌÌÌÌÌÍÍÏ</summary>
    public class UdonOperationResponseDiscRelated_7B9B : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_A6E; // 0x10
        public uint f_0D3; // 0x18
        public int f_839; // 0x1C
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_445; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC49C7520
        public void InternalEquals(){} // RVA: 0x7FFAC49C7530
        public void DefaultEquals(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCode(){} // RVA: 0x7FFAC49C7530
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F22E30
        public void ToString(){} // RVA: 0x7FFAC49C7520
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC49C7510
        // ── Unresolved (hash) ──
        public void m_96D(){} // RVA: 0x7FFAC38DFE40
        public void m_CDF(){} // RVA: 0x7FFAC2F22E30
        public void m_878(){} // RVA: 0x7FFAC2F3C380
        public void m_B4C(){} // RVA: 0x7FFAC49C7520
        public void m_9BE(){} // RVA: 0x7FFAC2F3C380
        public void m_377(){} // RVA: 0x7FFAC49C7530
        public void m_E2D(){} // RVA: 0x7FFAC49C7500
        public void m_528(){} // RVA: 0x7FFAC49C7500
        public void m_E33(){} // RVA: 0x7FFAC2F3C380
    }

    /// <summary>Originally: ÌÍÍÎÍÌÏÌÌÌÌÏÍÍÎÌÎÍÌÌÍÍÎ</summary>
    public class UdonOperationResponseDiscRelated_7EBB : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ _7EBB; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC38DFE40
        public void InternalEquals(){} // RVA: 0x7FFAC3AD9F60
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AD9F60
        // ── Unresolved (hash) ──
        public void m_0DF(){} // RVA: 0x7FFAC3AD9F60
        public void m_E89(){} // RVA: 0x7FFAC38DFE40
        public void m_F0E(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÌÌÌÍÎÌÍÍÍÍÎÎÏÏÍÏÎÌÏÌÌÎÍ</summary>
    public class UdonOperationResponseDiscRelated_7ED7 : ValueType
    {
        public object f_34B; // 0x10
        public UIntPtr f_3F2; // 0x18
        public System.ArraySegment`1<byte> f_B82; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC4420220
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC34F9180
        public void InternalGetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4A068C0
        // ── Unresolved (hash) ──
        public void m_E5F(){} // RVA: 0x7FFAC3AD9F60
        public void m_33C(){} // RVA: 0x7FFAC4422E80
        public void m_0C5(){} // RVA: 0x7FFAC3AD9F60
        public void m_CB2(){} // RVA: 0x7FFAC3AD9F60
        public void m_1C3(){} // RVA: 0x7FFAC3AD9F60
        public void m_E58(){} // RVA: 0x7FFAC4A9B120
        public void m_678(){} // RVA: 0x7FFAC4422E80
        public void m_A03(){} // RVA: 0x7FFAC4A068C0
        public void m_A2B(){} // RVA: 0x7FFAC34F9180
    }

    /// <summary>Originally: ÎÌÎÏÏÍÌÌÎÌÎÌÍÏÌÎÍÏÌÏÏÌÍ</summary>
    public class UdonOperationResponseDiscRelated_81D2 : ValueType
    {
        public UIntPtr f_3F2; // 0x10
        public bool f_8CA; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC3AD0200
        public void DefaultEquals(){} // RVA: 0x7FFAC45BB120
        public void GetHashCode(){} // RVA: 0x7FFAC45BB120
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC3AD0200
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC45BB120
        // ── Unresolved (hash) ──
        public void m_035(){} // RVA: 0x7FFAC3AD9F60
        public void m_552(){} // RVA: 0x7FFAC3AD0200
        public void m_538(){} // RVA: 0x7FFAC45BB120
        public void m_20B(){} // RVA: 0x7FFAC3AD0210
    }

    /// <summary>Originally: ÎÌÎÎÎÎÎÍÎÍÍÍÍÎÍÌÍÌÌÏÌÎÏ</summary>
    public class UdonOperationResponseDiscRelated_8C6A : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ _8C6A; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC38DFE40
        public void InternalEquals(){} // RVA: 0x7FFAC38DFE40
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÏÏÎÏÌÎÌÎÌÌÏÎÎÎÏÎÍÎÌÌÏÍÏ</summary>
    public class UdonOperationResponseDiscRelated_8C78 : ValueType
    {
        public UIntPtr f_94A; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_627; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_CEE; // 0x20
        public ÎÏÍÍÌÌÌÎÌÌÍÌÎÎÌÏÌÎÍÌÍÎÎ f_ADE; // 0x28
        public bool f_720; // 0x38
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_7A6; // 0x40
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_B74; // 0x48
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_6CF; // 0x50
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_C67; // 0x58
        public 0x6B0F8D30 f_CCA; // 0x60
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_AA3; // 0x68
        public uint f_7EC; // 0x70
        public System.Nullable`1<ÍÎÎÍÌÏÌÍÏÌÌÌÍÌÌÏÎÍÍÍÍÌÎ> f_149; // 0x78
        public ÎÌÌÍÎÍÎÌÎÍÍÎÍÍÎÎÎÌÍÎÎÌÏ f_723; // 0x90
        public UIntPtr f_4AB; // 0x98
        public System.Nullable`1<double> f_3B8; // 0xA0

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4B596F0
        public void InternalEquals(){} // RVA: 0x7FFAC2F49200
        public void DefaultEquals(){} // RVA: 0x7FFAC3138C20
        public void GetHashCode(){} // RVA: 0x7FFAC2F49200
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420220
        public void ToString(){} // RVA: 0x7FFAC30F6BA0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F3C380
        // ── 33 unresolved (hash) ──
        public void m_D0A(){} // RVA: 0x7FFAC2FE9510
        public void m_5EB(){} // RVA: 0x7FFAC3C24F40
        public void m_C23(){} // RVA: 0x7FFAC4AF4FA0
        public void m_9F1(){} // RVA: 0x7FFAC32EF410
        public void m_FFA(){} // RVA: 0x7FFAC2F4F890
        // ... 28 more unresolved methods
    }

    /// <summary>Originally: ÍÏÎÍÏÍÍÌÌÏÎÎÍÍÌÌÏÌÌÍÏÎÌ</summary>
    public class UdonOperationResponseDiscRelated_9225 : ValueType
    {
        public 0x6B0E5F60 f_309; // 0x10
        public object f_34B; // 0x18
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_94D; // 0x20
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_B8C; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F22E30
        public void InternalEquals(){} // RVA: 0x7FFAC4B56200
        public void DefaultEquals(){} // RVA: 0x7FFAC2F87E80
        public void GetHashCode(){} // RVA: 0x7FFAC4420240
        public void InternalGetHashCode(){} // RVA: 0x7FFAC336D8B0
        public void ToString(){} // RVA: 0x7FFAC2F3C380
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4B56250
        // ── Unresolved (hash) ──
        public void m_E5F(){} // RVA: 0x7FFAC4420220
        public void m_0DB(){} // RVA: 0x7FFAC2F247C0
        public void m_EBC(){} // RVA: 0x7FFAC4420220
        public void m_D48(){} // RVA: 0x7FFAC4420210
        public void m_0B6(){} // RVA: 0x7FFAC4420240
        public void m_0C5(){} // RVA: 0x7FFAC4420220
        public void m_A2B(){} // RVA: 0x7FFAC4B562A0
        public void m_5D6(){} // RVA: 0x7FFAC4420240
        public void m_385(){} // RVA: 0x7FFAC4420240
        public void m_63A(){} // RVA: 0x7FFAC2F247C0
    }

    /// <summary>Originally: ÌÌÎÏÏÎÌÏÌÌÌÌÌÌÍÏÎÍÏÎÍÍÏ</summary>
    public class UdonOperationResponseDiscRelated_9278 : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ _9278; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC38DFE40
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AD9F60
        // ── Unresolved (hash) ──
        public void m_EEB(){} // RVA: 0x7FFAC38DFE40
    }

    /// <summary>Originally: ÎÏÌÎÌÌÌÌÎÎÌÎÏÍÍÌÏÎÌÍÍÏÌ</summary>
    public class UdonOperationResponseDiscRelated_AFD5 : ValueType
    {
        public object f_34B; // 0x10
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_A6E; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_04F; // 0x20
        public System.Nullable`1<System.DateTimeOffset> f_C3C; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4AB09F0
        public void InternalEquals(){} // RVA: 0x7FFAC2F3C380
        public void DefaultEquals(){} // RVA: 0x7FFAC4420220
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420220
        public void ToString(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F22E30
        // ── 11 unresolved (hash) ──
        public void m_EBC(){} // RVA: 0x7FFAC34F9180
        public void m_0DF(){} // RVA: 0x7FFAC4420220
        public void m_96D(){} // RVA: 0x7FFAC4420240
        public void m_523(){} // RVA: 0x7FFAC4A6D150
        public void m_A3D(){} // RVA: 0x7FFAC4A6D150
        // ... 6 more unresolved methods
    }

    /// <summary>Originally: ÌÎÌÍÍÎÍÌÏÏÏÎÍÍÎÌÌÎÌÍÎÍÏ</summary>
    public class UdonOperationResponseDiscRelated_B04A : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_A6E; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_272; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC4420220
        public void DefaultEquals(){} // RVA: 0x7FFAC4420240
        public void GetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420240
        public void ToString(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AD9F60
        // ── Unresolved (hash) ──
        public void m_56C(){} // RVA: 0x7FFAC4420240
        public void m_0DF(){} // RVA: 0x7FFAC3AD9F60
        public void m_D7D(){} // RVA: 0x7FFAC4420220
        public void m_90B(){} // RVA: 0x7FFAC3AD9F60
        public void m_3FB(){} // RVA: 0x7FFAC4420240
    }

    /// <summary>Originally: ÍÌÎÍÌÏÍÍÌÎÏÎÌÎÎÏÌÎÍÍÏÏÏ</summary>
    public class UdonOperationResponseDiscRelated_B240 : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ _b240; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC38DFE40
        public void InternalEquals(){} // RVA: 0x7FFAC3AD9F60
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC38DFE40
        // ── Unresolved (hash) ──
        public void m_F96(){} // RVA: 0x7FFAC38DFE40
    }

    /// <summary>Originally: ÌÍÍÏÎÎÌÍÍÏÏÍÏÌÌÎÌÍÏÏÏÎÍ</summary>
    public class UdonOperationResponseDiscRelated_BBD4 : ValueType
    {
        public object f_34B; // 0x10
        public UIntPtr f_3F2; // 0x18
        public 0x6B10DAF8 f_72A; // 0x20
        public 0x6B10DB50 f_EF3; // 0x24
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_48D; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC4A068C0
        public void DefaultEquals(){} // RVA: 0x7FFAC33D5A20
        public void GetHashCode(){} // RVA: 0x7FFAC2F87E80
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F247C0
        public void ToString(){} // RVA: 0x7FFAC2F6E5C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F247C0
        // ── 13 unresolved (hash) ──
        public void m_A2B(){} // RVA: 0x7FFAC34F9180
        public void m_EBC(){} // RVA: 0x7FFAC3AD9F60
        public void m_DF7(){} // RVA: 0x7FFAC2F240C0
        public void m_540(){} // RVA: 0x7FFAC33D4990
        public void m_385(){} // RVA: 0x7FFAC38DFE40
        // ... 8 more unresolved methods
    }

    /// <summary>Originally: ÍÏÎÌÏÏÎÌÎÍÎÌÏÌÎÏÏÌÏÍÎÎÎ</summary>
    public class UdonOperationResponseDiscRelated_BD5F : ValueType
    {
        public object f_34B; // 0x10
        public UIntPtr f_3F2; // 0x18
        public 0x6B10DBA8 f_6D3; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4A068C0
        public void InternalEquals(){} // RVA: 0x7FFAC34F9180
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F6E5C0
        public void ToString(){} // RVA: 0x7FFAC2F240C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4A068C0
        // ── Unresolved (hash) ──
        public void m_A2B(){} // RVA: 0x7FFAC34F9180
        public void m_8A4(){} // RVA: 0x7FFAC2F240C0
        public void m_9A6(){} // RVA: 0x7FFAC4420220
        public void m_4AA(){} // RVA: 0x7FFAC34F9180
        public void m_F13(){} // RVA: 0x7FFAC2F240C0
        public void m_0C5(){} // RVA: 0x7FFAC3AD9F60
        public void m_D32(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÏÏÌÍÍÌÌÏÏÎÎÎÌÍÍÎÍÏÌÏÌÏÎ</summary>
    public class UdonOperationResponseDiscRelated_C025 : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_A6E; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_04F; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4420240
        public void InternalEquals(){} // RVA: 0x7FFAC3AD9F60
        public void DefaultEquals(){} // RVA: 0x7FFAC4420220
        public void GetHashCode(){} // RVA: 0x7FFAC4420240
        public void InternalGetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4420220
        // ── Unresolved (hash) ──
        public void m_6ED(){} // RVA: 0x7FFAC4420240
        public void m_0DF(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÏÏÌÏÍÌÏÎÌÍÍÌÌÏÎÎÍÌÏÍÍÏÌ</summary>
    public class UdonOperationResponseDiscRelated_C31A : ValueType
    {
        public UIntPtr f_3F2; // 0x10
        public 0x6B10DC00 f_9B8; // 0x18
        public 0x6B10DC58 f_7CB; // 0x1C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC49C7510
        public void InternalEquals(){} // RVA: 0x7FFAC49C7530
        public void DefaultEquals(){} // RVA: 0x7FFAC49C7530
        public void GetHashCode(){} // RVA: 0x7FFAC49C7520
        public void InternalGetHashCode(){} // RVA: 0x7FFAC49C7500
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC49C7500
        // ── Unresolved (hash) ──
        public void m_A03(){} // RVA: 0x7FFAC45BB120
        public void m_D65(){} // RVA: 0x7FFAC49C7520
        public void m_328(){} // RVA: 0x7FFAC49C7500
        public void m_E81(){} // RVA: 0x7FFAC49C7530
        public void m_A12(){} // RVA: 0x7FFAC49C7500
        public void m_20F(){} // RVA: 0x7FFAC49C7500
    }

    /// <summary>Originally: ÎÏÏÌÌÍÎÌÌÏÎÏÎÎÎÌÍÎÍÌÌÍÍ</summary>
    public class UdonOperationResponseDiscRelated_C337 : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_066; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_289; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC4420220
        public void DefaultEquals(){} // RVA: 0x7FFAC4420220
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420240
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC38DFE40
        // ── Unresolved (hash) ──
        public void m_DB3(){} // RVA: 0x7FFAC4420220
        public void m_91A(){} // RVA: 0x7FFAC4420220
        public void m_5C9(){} // RVA: 0x7FFAC4420240
    }

    /// <summary>Originally: ÍÏÏÎÎÌÎÍÎÌÏÍÎÍÏÌÎÎÍÍÍÎÌ</summary>
    public class UdonOperationResponseDiscRelated_CC0A : ValueType
    {
        public UIntPtr f_3F2; // 0x10
        public System.ArraySegment`1<byte> f_653; // 0x18
        public uint f_02C; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC392CD10
        public void InternalEquals(){} // RVA: 0x7FFAC3AD9F60
        public void DefaultEquals(){} // RVA: 0x7FFAC4A927D0
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4A927E0
        public void ToString(){} // RVA: 0x7FFAC45BB120
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC392CD10
        // ── Unresolved (hash) ──
        public void m_F64(){} // RVA: 0x7FFAC3AD9F60
        public void m_644(){} // RVA: 0x7FFAC3AD9F60
        public void m_440(){} // RVA: 0x7FFAC3157800
        public void m_9F5(){} // RVA: 0x7FFAC45BB120
    }

    /// <summary>Originally: ÍÎÏÎÍÍÌÍÏÎÎÏÏÍÎÏÎÍÍÏÌÌÍ</summary>
    public class UdonOperationResponseDiscRelated_D3B1 : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_A6E; // 0x10
        public uint f_865; // 0x18
        public bool f_98F; // 0x1C

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC49C7510
        public void InternalEquals(){} // RVA: 0x7FFAC4AD9B10
        public void DefaultEquals(){} // RVA: 0x7FFAC4AD9B20
        public void GetHashCode(){} // RVA: 0x7FFAC49C7500
        public void InternalGetHashCode(){} // RVA: 0x7FFAC49C7500
        public void ToString(){} // RVA: 0x7FFAC4AD9B20
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4AD9B20
        // ── Unresolved (hash) ──
        public void m_ACD(){} // RVA: 0x7FFAC3AD9F60
        public void m_EEB(){} // RVA: 0x7FFAC38DFE40
        public void m_9F9(){} // RVA: 0x7FFAC49C7500
        public void m_96D(){} // RVA: 0x7FFAC38DFE40
    }

    /// <summary>Originally: ÌÍÍÎÍÎÍÍÎÎÎÏÍÏÏÍÍÍÍÏÏÌÌ</summary>
    public class UdonOperationResponseDiscRelated_DA52 : ValueType
    {
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ _dA52; // 0x10

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC38DFE40
        public void InternalEquals(){} // RVA: 0x7FFAC3AD9F60
        public void DefaultEquals(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC38DFE40
        // ── Unresolved (hash) ──
        public void m_19F(){} // RVA: 0x7FFAC3AD9F60
        public void m_F0E(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÎÍÍÏÏÌÍÏÌÎÍÍÍÎÎÌÌÌÎÏÌÍÎ</summary>
    public class UdonOperationResponseDiscRelated_DDDB : ValueType
    {
        public object f_34B; // 0x10
        public ÎÏÍÌÌÎÎÍÍÍÏÎÌÍÎÌÎÍÍÎÍÌÌ f_94D; // 0x18
        public ÎÏÍÌÌÎÎÍÍÍÏÎÌÍÎÌÎÍÍÎÍÌÌ f_DBE; // 0x20
        public bool f_3EE; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F3C4E0
        public void InternalEquals(){} // RVA: 0x7FFAC34F9180
        public void DefaultEquals(){} // RVA: 0x7FFAC34F9180
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC34F9180
        public void ToString(){} // RVA: 0x7FFAC4420220
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC3AD9F60
        // ── Unresolved (hash) ──
        public void m_4EA(){} // RVA: 0x7FFAC4420240
        public void m_870(){} // RVA: 0x7FFAC2F22E30
        public void m_D32(){} // RVA: 0x7FFAC3AD9F60
        public void m_C74(){} // RVA: 0x7FFAC2F3C4F0
        public void m_3A9(){} // RVA: 0x7FFAC2F3C4F0
        public void m_EBC(){} // RVA: 0x7FFAC3AD9F60
        public void m_385(){} // RVA: 0x7FFAC38DFE40
        public void m_F00(){} // RVA: 0x7FFAC2F3C380
        public void m_F06(){} // RVA: 0x7FFAC3AD9F60
    }

    /// <summary>Originally: ÌÌÏÌÏÏÍÍÍÏÏÏÌÎÏÌÎÌÎÏÌÍÏ</summary>
    public class UdonOperationResponseDiscRelated_E3FD : ValueType
    {
        public 0x6B0F6D38 f_4DD; // 0x10
        public ÎÏÍÌÌÎÎÍÍÍÏÎÌÍÎÌÎÍÍÎÍÌÌ f_A6E; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_627; // 0x20
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_2BE; // 0x28
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_865; // 0x30
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_5CE; // 0x38
        public ÌÎÏÎÏÌÌÍÎÌÌÍÌÍÏÌÏÌÍÌÎÌÌ[] f_24C; // 0x40
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_5E4; // 0x48
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_4FB; // 0x50

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F22E90
        public void InternalEquals(){} // RVA: 0x7FFAC31D0140
        public void DefaultEquals(){} // RVA: 0x7FFAC2F4F0C0
        public void GetHashCode(){} // RVA: 0x7FFAC2F49200
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F4F130
        public void ToString(){} // RVA: 0x7FFAC4420220
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC336D8B0
        // ── 18 unresolved (hash) ──
        public void m_72F(){} // RVA: 0x7FFAC2F3C380
        public void m_BDE(){} // RVA: 0x7FFAC2F4F890
        public void m_8DD(){} // RVA: 0x7FFAC2F87E80
        public void m_6E7(){} // RVA: 0x7FFAC2F4F130
        public void m_890(){} // RVA: 0x7FFAC2F4F0C0
        // ... 13 more unresolved methods
    }

    /// <summary>Originally: ÍÎÌÎÏÌÎÌÎÎÎÏÌÏÍÌÍÏÎÎÎÌÍ</summary>
    public class UdonOperationResponseDiscRelated_E5EC : ValueType
    {
        public object f_34B; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_838; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_892; // 0x20
        public ÎÏÍÌÌÎÎÍÍÍÏÎÌÍÎÌÎÍÍÎÍÌÌ f_F1A; // 0x28
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_066; // 0x30

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC38DFE40
        public void InternalEquals(){} // RVA: 0x7FFAC2F4F0D0
        public void DefaultEquals(){} // RVA: 0x7FFAC2F3C380
        public void GetHashCode(){} // RVA: 0x7FFAC2F22E30
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F3C380
        public void ToString(){} // RVA: 0x7FFAC4420240
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F4F0C0
        // ── 13 unresolved (hash) ──
        public void m_EBC(){} // RVA: 0x7FFAC3AD9F60
        public void m_A2B(){} // RVA: 0x7FFAC34F9180
        public void m_A20(){} // RVA: 0x7FFAC2F247C0
        public void m_385(){} // RVA: 0x7FFAC38DFE40
        public void m_E57(){} // RVA: 0x7FFAC2F247C0
        // ... 8 more unresolved methods
    }

    /// <summary>Originally: ÎÌÌÍÍÎÎÏÍÍÎÎÎÍÏÌÌÎÏÌÎÏÍ</summary>
    public class UdonOperationResponseDiscRelated_F560 : ValueType
    {
        public 0x6B0E5F60 f_309; // 0x10
        public object f_34B; // 0x18
        public ÎÏÍÌÌÎÎÍÍÍÏÎÌÍÎÌÎÍÍÎÍÌÌ f_94D; // 0x20
        public ÏÍÌÌÏÎÍÎÎÏÌÌÏÏÎÌÏÏÍÎÍÎÏ[] f_B1D; // 0x28

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4420220
        public void InternalEquals(){} // RVA: 0x7FFAC4A46840
        public void DefaultEquals(){} // RVA: 0x7FFAC4420240
        public void GetHashCode(){} // RVA: 0x7FFAC4420220
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F22E30
        public void ToString(){} // RVA: 0x7FFAC2F3C380
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC4420210
        // ── Unresolved (hash) ──
        public void m_A2B(){} // RVA: 0x7FFAC4A46890
        public void m_9FD(){} // RVA: 0x7FFAC2F87E80
        public void m_F55(){} // RVA: 0x7FFAC4A468E0
        public void m_EBC(){} // RVA: 0x7FFAC4420220
        public void m_001(){} // RVA: 0x7FFAC2F87E80
        public void m_AC2(){} // RVA: 0x7FFAC2F247C0
        public void m_BB2(){} // RVA: 0x7FFAC336D8B0
        public void m_0B6(){} // RVA: 0x7FFAC4420240
    }

    /// <summary>Originally: ÏÍÎÌÏÌÏÌÌÎÌÎÎÍÌÍÏÌÌÏÎÍÍ</summary>
    public class UdonOperationResponseDiscRelated_F7B2 : ValueType
    {
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_838; // 0x10
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_892; // 0x18
        public 0x6B0E5D50 f_BD8; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4420220
        public void InternalEquals(){} // RVA: 0x7FFAC4420220
        public void DefaultEquals(){} // RVA: 0x7FFAC2F240C0
        public void GetHashCode(){} // RVA: 0x7FFAC38DFE40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F6E5C0
        public void ToString(){} // RVA: 0x7FFAC38DFE40
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F6E5C0
        // ── Unresolved (hash) ──
        public void m_87C(){} // RVA: 0x7FFAC3AD9F60
        public void m_953(){} // RVA: 0x7FFAC38DFE40
        public void m_219(){} // RVA: 0x7FFAC38DFE40
        public void m_365(){} // RVA: 0x7FFAC4420240
        public void m_F11(){} // RVA: 0x7FFAC4420240
        public void m_3D4(){} // RVA: 0x7FFAC2F240C0
        public void m_F33(){} // RVA: 0x7FFAC2F240C0
    }

    /// <summary>Originally: ÍÍÌÏÏÏÌÏÎÍÌÌÎÏÍÎÌÏÍÍÏÌÎ</summary>
    public class UdonOperationResponseDiscRelated_F819 : ValueType
    {
        public 0x6B0E5F60 f_309; // 0x10
        public object f_34B; // 0x18
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_066; // 0x20
        public bool f_6FD; // 0x28
        public 0x6B0E5C48 f_09A; // 0x2C
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_F1A; // 0x30
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_865; // 0x38
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_BED; // 0x40
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_0FB; // 0x48
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_627; // 0x50
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_CEE; // 0x58
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_C67; // 0x60

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC4420210
        public void InternalEquals(){} // RVA: 0x7FFAC2F4F0C0
        public void DefaultEquals(){} // RVA: 0x7FFAC2F3C4F0
        public void GetHashCode(){} // RVA: 0x7FFAC2F22E90
        public void InternalGetHashCode(){} // RVA: 0x7FFAC4420210
        public void ToString(){} // RVA: 0x7FFAC2F22E30
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC44474D0
        // ── 26 unresolved (hash) ──
        public void m_385(){} // RVA: 0x7FFAC4420240
        public void m_74F(){} // RVA: 0x7FFAC2F4F0C0
        public void m_62D(){} // RVA: 0x7FFAC31D0140
        public void m_22C(){} // RVA: 0x7FFAC30794D0
        public void m_08D(){} // RVA: 0x7FFAC2F22E90
        // ... 21 more unresolved methods
    }

    /// <summary>Originally: ÎÌÎÏÏÏÏÎÎÏÎÎÎÎÍÌÎÍÌÎÌÏÎ</summary>
    public class UdonOperationResponseDiscRelated_FBE4 : ValueType
    {
        public 0x6B0E5F60 f_309; // 0x10
        public object f_34B; // 0x18
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_788; // 0x20
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_0FB; // 0x28
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_627; // 0x30
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_CEE; // 0x38
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_C67; // 0x40
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_C4D; // 0x48
        public bool f_6E8; // 0x50
        public 0x6B0E5C48 f_F57; // 0x54
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_B6B; // 0x58
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_F52; // 0x60
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_865; // 0x68

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F9C740
        public void InternalEquals(){} // RVA: 0x7FFAC2F9C740
        public void DefaultEquals(){} // RVA: 0x7FFAC4420210
        public void GetHashCode(){} // RVA: 0x7FFAC2F4F130
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F247C0
        public void ToString(){} // RVA: 0x7FFAC2FDCC10
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC31D95E0
        // ── 27 unresolved (hash) ──
        public void m_1E8(){} // RVA: 0x7FFAC2FDCC00
        public void m_0C5(){} // RVA: 0x7FFAC4420220
        public void m_BB2(){} // RVA: 0x7FFAC336D8B0
        public void m_385(){} // RVA: 0x7FFAC4420240
        public void m_D28(){} // RVA: 0x7FFAC2F4F130
        // ... 22 more unresolved methods
    }

    /// <summary>Originally: ÌÎÍÌÌÎÏÎÎÎÎÎÌÏÎÌÏÏÏÌÎÍÏ</summary>
    public class UdonOperationResponseDisconnecSibling_0FAA : ValueType
    {
        public UIntPtr f_3F2; // 0x10
        public 0x6B10DD08 f_4A9; // 0x18
        public 0x6B10DCB0 f_29D; // 0x1C
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_943; // 0x20
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_03F; // 0x28
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_A6E; // 0x30
        public int f_2E3; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F22E30
        public void InternalEquals(){} // RVA: 0x7FFAC45BB120
        public void DefaultEquals(){} // RVA: 0x7FFAC49C7500
        public void GetHashCode(){} // RVA: 0x7FFAC49C7510
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F247C0
        public void ToString(){} // RVA: 0x7FFAC32EC4C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F247C0
        // ── 15 unresolved (hash) ──
        public void m_E83(){} // RVA: 0x7FFAC369A6E0
        public void m_96F(){} // RVA: 0x7FFAC45BB120
        public void m_840(){} // RVA: 0x7FFAC2F247C0
        public void m_747(){} // RVA: 0x7FFAC2F22E30
        public void m_2C1(){} // RVA: 0x7FFAC2F87E80
        // ... 10 more unresolved methods
    }

    /// <summary>Originally: ÍÌÎÏÍÍÌÍÍÎÌÌÍÏÏÏÏÌÍÍÎÍÏ</summary>
    public class UdonOperationResponseDisconnecSibling_8970 : ValueType
    {
        public UIntPtr f_3F2; // 0x10
        public uint f_66E; // 0x18
        public ÏÎÌÌÍÎÌÎÎÏÍÏÌÌÎÌÍÍÌÎÌÌÍ[] f_602; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC3AD9F60
        public void InternalEquals(){} // RVA: 0x7FFAC2F3C380
        public void DefaultEquals(){} // RVA: 0x7FFAC49C7500
        public void GetHashCode(){} // RVA: 0x7FFAC49C7510
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2F22E30
        public void ToString(){} // RVA: 0x7FFAC49C7500
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC49C7510
        // ── Unresolved (hash) ──
        public void m_A7D(){} // RVA: 0x7FFAC45BB120
        public void m_951(){} // RVA: 0x7FFAC2F22E30
        public void m_29F(){} // RVA: 0x7FFAC2F22E30
        public void m_222(){} // RVA: 0x7FFAC2F3C380
        public void m_CE3(){} // RVA: 0x7FFAC49C7510
        public void m_A03(){} // RVA: 0x7FFAC45BB120
    }

    /// <summary>Originally: ÌÏÏÏÍÏÎÎÍÌÏÏÎÏÎÏÏÍÍÌÍÏÌ</summary>
    public class UdonOperationResponseDisconnecSibling_D528 : ValueType
    {
        public UIntPtr f_058; // 0x10
        public 0x6B10DD08 f_4A9; // 0x18
        public 0x6B10DCB0 f_29D; // 0x1C
        public uint f_84D; // 0x20
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_943; // 0x28
        public ÌÌÏÍÍÍÌÍÎÏÌÌÍÎÎÎÌÌÏÎÍÌÌ f_03F; // 0x30
        public ÏÍÍÎÏÎÌÍÍÍÎÍÏÌÏÍÌÎÎÌÎÍÍ f_830; // 0x38

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2F4F130
        public void InternalEquals(){} // RVA: 0x7FFAC3AD9F60
        public void DefaultEquals(){} // RVA: 0x7FFAC49C7520
        public void GetHashCode(){} // RVA: 0x7FFAC3AD9F60
        public void InternalGetHashCode(){} // RVA: 0x7FFAC49C7530
        public void ToString(){} // RVA: 0x7FFAC2F240C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC2F247C0
        // ── 14 unresolved (hash) ──
        public void m_E91(){} // RVA: 0x7FFAC2F4F0C0
        public void m_01F(){} // RVA: 0x7FFAC2F87E80
        public void m_6BE(){} // RVA: 0x7FFAC2F6E5C0
        public void m_91B(){} // RVA: 0x7FFAC2F22E90
        public void m_46B(){} // RVA: 0x7FFAC49C7500
        // ... 9 more unresolved methods
    }

    /// <summary>Originally: ÏÍÎÏÎÌÍÏÏÎÍÏÎÏÍÌÎÏÌÏÏÍÏ</summary>
    public class UdonOperationResponseDisconnecSibling_E6D0 : Object
    {
        public 0x6B16B4B0 _name; // 0x10
        public string _hideFlags; // 0x18
        public string f_18E; // 0x20
        public string f_A6E; // 0x28

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC2F87E80
        public void Equals(){} // RVA: 0x7FFAC2F240C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Initialize(){} // RVA: 0x7FFAC489B410
        public void CompareBaseObjects(){} // RVA: 0x7FFAC2F4F0D0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC2F4F0C0
        public void GetCachedPtr(){} // RVA: 0x7FFAC2F6E5C0
        public void get_name(){} // RVA: 0x7FFAC2F240C0
        public void set_name(){} // RVA: 0x7FFAC2F4F0D0
        public void Instantiate(){} // RVA: 0x7FFAC2F87E80
        public void GetHashCode(){} // RVA: 0x7FFAC2F4F0C0
        public void ToString(){} // RVA: 0x7FFAC2F4F130
        // ── Unresolved (hash) ──
        public void m_F8F(){} // RVA: 0x7FFAC2F6E5C0
        public void m_010(){} // RVA: 0x7FFAC2F247C0
        public void m_96D(){} // RVA: 0x7FFAC2F22E90
    }

    /// <summary>Originally: ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ</summary>
    public class UdonOperationResponseDisconnectMessage_331A_331A : Object
    {
        public Photon.Client.PhotonPeer _name; // 0x10
        public string _hideFlags; // 0x18
        public 0x6B26A6B8 f_112; // 0x20
        public int f_D26; // 0x24
        public int f_91C; // 0x28
        public Photon.Realtime.AppSettings f_8F2; // 0x30
        public 0x6B017F28 f_4A9; // 0x38
        public ÍÏÍÎÏÍÍÎÏÌÍÎÌÎÏÏÌÌÌÍÎÎÌ f_5FC; // 0x40
        public 0x6B017F80 f_265; // 0x48
        public string f_CAD; // 0x50
        public ÍÎÌÏÌÍÏÍÏÎÌÎÎÌÍÍÌÍÍÏÍÌÏ f_EB2; // 0x58
        public string f_C83; // 0x60
        public string f_764; // 0x68
        public System.Func`3<string,0x6B017ED0,string> f_BB8; // 0x70
        public 0x6B017ED0 f_FD6; // 0x78
        public 0x6B017D70 f_58F; // 0x7C
        public Photon.Realtime.ConnectionHandler f_005; // 0x80
        public System.Action`2<0x6B017D70,0x6B017D70> f_849; // 0x88
        public System.Action`1<Photon.Client.EventData> f_3C3; // 0x90
        public System.Action`2<bool,object> f_730; // 0x98
        public System.Action`1<Photon.Client.OperationResponse> f_76D; // 0xA0
        public ÎÏÌÏÌÍÏÍÎÍÌÌÏÎÍÏÍÌÏÏÎÎÎ f_986; // 0xA8
        public ÍÏÌÎÏÎÏÎÌÌÌÍÎÏÍÍÎÌÎÍÏÍÌ f_A6E; // 0xB0
        public ÌÌÍÍÌÎÏÍÏÍÎÍÏÌÏÎÎÏÌÌÍÌÏ f_754; // 0xB8
        public ÌÎÏÍÎÌÌÍÍÌÍÍÍÎÍÏÍÎÏÏÌÏÌ f_0E1; // 0xC0
        public ÍÌÏÌÌÏÌÌÏÍÍÌÏÏÌÏÍÎÍÎÏÍÏ f_68C; // 0xC8
        public 0x6B017E78 f_360; // 0xD0
        public ÍÍÏÎÎÍÌÏÏÎÍÎÎÎÍÍÏÏÌÍÏÍÏ f_F78; // 0xD8
        public ÎÌÌÍÌÎÍÍÎÏÌÌÍÌÎÎÌÎÌÌÍÎÎ f_F32; // 0xE0
        public ÎÌÌÍÌÎÍÍÎÏÌÌÍÌÎÎÌÎÌÌÍÎÎ f_32A; // 0xE8
        public System.Collections.Generic.List`1<ÎÏÏÍÌÌÍÏÏÎÎÏÏÍÎÎÎÌÍÎÎÎÍ> f_05E; // 0xF0
        public ÏÏÏÍÌÌÍÎÎÍÏÎÍÏÍÎÌÌÌÎÎÌÎ f_0FB; // 0xF8
        public ÎÎÎÏÌÌÍÏÎÍÎÌÎÌÌÏÌÌÍÌÎÏÏ f_A39; // 0x100
        public int <ÏÌÏÏÏÎÌÎÍÎÎÍÌÏÏÍÍÏÎÌÍÎÎ>k__BackingField; // 0x108
        public int <ÎÌÏÌÎÎÎÍÎÍÎÏÎÎÎÎÏÌÏÌÎÏÍ>k__BackingField; // 0x10C
        public int <ÍÏÌÎÍÎÏÏÌÏÍÌÎÌÏÏÍÏÌÌÏÍÍ>k__BackingField; // 0x110
        public 0x6B017E20 ÌÎÎÍÎÎÎÍÏÍÌÎÌÏÌÍÌÎÏÏÎÏÏ; // 0x114
        public ÍÍÎÎÎÏÏÏÎÏÌÍÏÍÍÌÏÌÏÍÏÎÎ ÎÍÌÏÍÏÏÏÍÎÌÌÎÎÌÎÌÎÏÎÎÌÍ; // 0x118
        public Photon.Client.OperationResponse ÏÏÏÍÏÏÏÏÍÎÌÏÏÌÌÌÏÏÏÍÍÎÌ; // 0x120
        public int ÌÍÎÍÎÍÍÎÏÍÍÎÌÏÌÏÍÎÎÍÍÌÏ;
        public string[] ÎÍÏÎÌÎÎÍÍÍÏÎÎÍÏÍÎÎÌÏÎÏÏ; // 0x128
        public string <ÏÍÏÏÏÏÏÌÎÍÏÌÍÍÎÌÎÎÍÏÍÌÌ>k__BackingField; // 0x130
        public string <ÌÍÎÏÏÎÌÏÍÏÌÎÍÏÏÍÌÍÏÎÍÏÍ>k__BackingField; // 0x138
        public ÎÏÏÌÏÌÍÏÍÍÎÍÎÌÍÎÌÏÌÌÍÍÍ ÎÏÎÌÎÏÌÌÍÏÏÌÎÏÌÍÌÎÍÌÍÏÏ; // 0x140
        public System.Collections.Generic.Queue`1<ÎÍÍÎÍÎÏÍÍÏÍÌÌÎÍÍÏÏÌÎÍÎÎ> ÏÏÎÏÏÏÏÌÍÍÏÌÎÌÏÏÎÍÏÏÌÌÌ; // 0x148
        public System.Collections.Generic.HashSet`1<object> ÎÏÍÌÌÍÏÍÎÏÏÍÌÎÌÎÍÎÎÍÎÏÌ; // 0x150
        public 0x6B019268 ÏÍÎÏÍÎÎÏÎÏÏÍÏÏÌÍÎÎÎÍÌÍÏ; // 0x158
        public ÌÍÎÌÍÍÏÏÍÌÍÎÌÍÍÌÍÏÏÏÌÍÍ ÏÌÎÌÍÌÍÌÎÏÏÍÌÏÏÎÏÌÏÏÍÍÌ; // 0x160
        public Photon.Client.Pool`1<Photon.Client.ParameterDictionary> ÌÏÎÌÎÎÍÏÏÌÌÎÍÏÎÍÍÏÎÏÍÎÏ; // 0x168
        public string ÍÏÎÏÏÌÌÌÍÍÏÌÏÌÎÏÏÍÍÍÎÌÍ;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4590AA0
        public void Initialize(){} // RVA: 0x7FFAC4591B60
        public void set_AudioCaptureSource(){} // RVA: 0x7FFAC4591C30
        public void op_Implicit_780B1E5F837B_780B1E5F837B(){} // RVA: 0x7FFAC4598010 | overloaded x2
        public void get_domainList(){} // RVA: 0x7FFAC2FA2900
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC4591D30
        public void set_Flags(){} // RVA: 0x7FFAC3588350
        public void get_name(){} // RVA: 0x7FFAC4591E50
        public void set_name(){} // RVA: 0x7FFAC4591FF0
        public void Instantiate(){} // RVA: 0x7FFAC4592050
        public void Equals(){} // RVA: 0x7FFAC4592150
        public void GetHashCode(){} // RVA: 0x7FFAC4592170
        public void ToString(){} // RVA: 0x7FFAC4592240
        public void GetGameObject_A16(){} // RVA: 0x7FFAC45923D0
        public void DoAngleAxis_Injected_F9A(){} // RVA: 0x7FFAC45929E0
        public void ProcessDisconnectMessage(){} // RVA: 0x7FFAC4592D90
        public void SendDisconnectMessage(){} // RVA: 0x7FFAC45933C0
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC32EF410
        public void ReceiveDisconnectMessage(){} // RVA: 0x7FFAC45935A0
        public void get_categories(){} // RVA: 0x7FFAC34F6C80
        public void Destroy(){} // RVA: 0x7FFAC4593860
        public void DestroyImmediate(){} // RVA: 0x7FFAC4593A30
        public void FindObjectsOfType(){} // RVA: 0x7FFAC4593B30
        public void GetRotation(){} // RVA: 0x7FFAC4593B50
        public void FindObjectsOfType_88D5DE2670F6(){} // RVA: 0x7FFAC4593CC0
        public void FindObjectsByType(){} // RVA: 0x7FFAC45944F0
        public void OnEvent(){} // RVA: 0x7FFAC4594AB0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC4595AC0
        public void get_hideFlags(){} // RVA: 0x7FFAC4595DC0
        public void set_hideFlags(){} // RVA: 0x7FFAC4595F60
        public void DropdownValueChanged(){} // RVA: 0x7FFAC45963A0
        public void FindObjectOfType(){} // RVA: 0x7FFAC45963B0
        public void FindFirstObjectByType(){} // RVA: 0x7FFAC45963D0
        public void HandleDisconnectMessage(){} // RVA: 0x7FFAC4596710
        public void CheckNullArgument(){} // RVA: 0x7FFAC45967D0
        public void GetProperties(){} // RVA: 0x7FFAC3544340
        public void OnMessage(){} // RVA: 0x7FFAC4596E90
        public void GetStatus(){} // RVA: 0x7FFAC4596EF0
        public void ParseDisconnectMessage(){} // RVA: 0x7FFAC4596F00
        public void CheckMessageStatus(){} // RVA: 0x7FFAC4596FA0
        public void op_Equality_16201CE17DFF_16201CE17DFF(){} // RVA: 0x7FFAC459DD20 | overloaded x2
        public void op_Inequality(){} // RVA: 0x7FFAC4597120
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFAC45971B0
        public void Internal_CloneSingle(){} // RVA: 0x7FFAC45975E0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFAC4597660
        public void AddUnitNode(){} // RVA: 0x7FFAC2F4F890
        public void get_Uploaded(){} // RVA: 0x7FFAC35422C0
        public void get_Module(){} // RVA: 0x7FFAC4426B30
        public void GetName(){} // RVA: 0x7FFAC4597680
        public void SetName(){} // RVA: 0x7FFAC4597880
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFAC2F3C380
        public void GetOffsetOfInstanceIDInCPlusPlusObject_8D278CF1455B(){} // RVA: 0x7FFAC45979E0
        public void get_atlasHeight(){} // RVA: 0x7FFAC4597A10
        public void SerializeDisconnectMessage(){} // RVA: 0x7FFAC4597A20
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFAC4597B30
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFAC4597C00
        public void set_atlasWidth(){} // RVA: 0x7FFAC4597C50
        public void set_atlasWidth_ACD780BE1B80(){} // RVA: 0x7FFAC4597C60
        public void set_EffectiveUnmappedMemberHandling(){} // RVA: 0x7FFAC4597C80
        public void set_EffectiveUnmappedMemberHandling_DA1C5A5C674E(){} // RVA: 0x7FFAC4597C90
        public void Initialize_D733C3F21BD1(){} // RVA: 0x7FFAC4597DA0
        public void GetHashCode_D4AA7FF98D2C(){} // RVA: 0x7FFAC4598000
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFAC45980F0
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFAC4598690
        public void ReadDisconnectMessage(){} // RVA: 0x7FFAC45986B0
        public void WriteDisconnectMessage(){} // RVA: 0x7FFAC4598C10
        public void ValidateDisconnectMessage(){} // RVA: 0x7FFAC4598E70
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFAC4598F70
        public void AcceptDisconnectMessage_6903F6DB5527_6903F6DB5527(){} // RVA: 0x7FFAC459DB30 | overloaded x2
        public void RejectDisconnectMessage(){} // RVA: 0x7FFAC4598F90
        public void CreateDisconnectMessage(){} // RVA: 0x7FFAC4599210
        public void InitializeDisconnectMessage(){} // RVA: 0x7FFAC45995F0
        public void Initialize_51F2C62BF0BE(){} // RVA: 0x7FFAC45996F0
        public void set_payload(){} // RVA: 0x7FFAC39A79B0
        public void SetOverlay(){} // RVA: 0x7FFAC2F49200
        public void AckDisconnectMessage(){} // RVA: 0x7FFAC4599710
        public void GetProperties_C93D8383396E(){} // RVA: 0x7FFAC4599830
        public void get_blurSamples(){} // RVA: 0x7FFAC4599E70
        public void Initialize_5BBC8B3CF52D(){} // RVA: 0x7FFAC4599E80
        public void GetTargets(){} // RVA: 0x7FFAC2FBF370
        public void get_EnableServerTracing(){} // RVA: 0x7FFAC4599EA0
        public void MoveNext(){} // RVA: 0x7FFAC4599EE0
        public void set_trackerAnchor(){} // RVA: 0x7FFAC2FBF380
        public void NackDisconnectMessage(){} // RVA: 0x7FFAC459A170
        public void GetHashCode_179F963EFA3A(){} // RVA: 0x7FFAC44F4DD0
        public void WriteValue(){} // RVA: 0x7FFAC2C79B30
        public void Initialize_421CB9911C9A(){} // RVA: 0x7FFAC459A2D0
        public void OnStatusChanged(){} // RVA: 0x7FFAC459A440
        public void set_atlasHeight(){} // RVA: 0x7FFAC459AD60
        public void set_atlasHeight_5F09EE131209(){} // RVA: 0x7FFAC459AD70
        public void set_categories(){} // RVA: 0x7FFAC34F6750
        public void OnOperationResponse(){} // RVA: 0x7FFAC459AD90
        public void GetAt(){} // RVA: 0x7FFAC459C880
        public void DisconnectMessageTimeout(){} // RVA: 0x7FFAC459C980
        public void IsNativeObjectAlive_561D8FF8BECA(){} // RVA: 0x7FFAC459CA00
        public void DisconnectMessageError(){} // RVA: 0x7FFAC459CB90
        public void DisconnectMessageSuccess(){} // RVA: 0x7FFAC459CC70
        public void DisconnectMessageFailed(){} // RVA: 0x7FFAC459CC90
        public void ComputeTask(){} // RVA: 0x7FFAC459CFF0
        public void ComputeTask_0F9ECA62327B(){} // RVA: 0x7FFAC459D080
        public void GetDisconnectReason(){} // RVA: 0x7FFAC459D180
        public void set_fallbackFontAssetTable(){} // RVA: 0x7FFAC36D84B0
        public void InitPayloadEncryption(){} // RVA: 0x7FFAC34D4AA0
        public void SetDisconnectReason(){} // RVA: 0x7FFAC459D1C0
        public void StartPickedUp(){} // RVA: 0x7FFAC2F9CD60
        public void HasDisconnectReason(){} // RVA: 0x7FFAC459D8B0
        public void SetDisconnectMessage(){} // RVA: 0x7FFAC459DAE0
        public void ClearMessage(){} // RVA: 0x7FFAC459DBC0
        public void CreateHandle(){} // RVA: 0x7FFAC459DE10
        public void get_atlasHeight_35E9C719DD94(){} // RVA: 0x7FFAC4597A10
        public void GetFileLineNumber(){} // RVA: 0x7FFAC358A870
        public void AttachDisconnectMessageBody(){} // RVA: 0x7FFAC2F21310
        public void OnDisconnectMessage(){} // RVA: 0x7FFAC459DF40
        public void get_pinkyTip(){} // RVA: 0x7FFAC459E090
        public void Reset(){} // RVA: 0x7FFAC459E440
        public void InitializeComponentProperties(){} // RVA: 0x7FFAC459E920
        public void DropdownValueChanged_9BC1D31A6190(){} // RVA: 0x7FFAC45963A0
        public void GetBufferedTimes(){} // RVA: 0x7FFAC2F9E740
        public void ConfigureAudioSource(){} // RVA: 0x7FFAC459EA20
        public void get_Uploaded_C767B7870CEA(){} // RVA: 0x7FFAC35422C0
        public void DebugReturn(){} // RVA: 0x7FFAC459EEF0
        public void IndexOf(){} // RVA: 0x7FFAC459EFA0
        public void get_counterVelocityMode(){} // RVA: 0x7FFAC39471E0
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void __OnPointerExit__UnityEngineEventSystemsPointerEventData__SystemVoid(){} // RVA: 0x7FFAC459F040
        public void IndexOf_F8C1E5A731FC(){} // RVA: 0x7FFAC459F050
        public void GetMaterial(){} // RVA: 0x7FFAC2F9CD50
        public void IndexOf_0F591CAC6782(){} // RVA: 0x7FFAC459F090
        public void set_domainList(){} // RVA: 0x7FFAC2FA2910
        public void IndexOf_070442A101EC(){} // RVA: 0x7FFAC459F0A0
        public void ComputeNow(){} // RVA: 0x7FFAC459F1A0
        public void get_AudioCaptureSource(){} // RVA: 0x7FFAC3696B20
        public void set_UserId(){} // RVA: 0x7FFAC459F3D0
        public void get_Plugins(){} // RVA: 0x7FFAC459F630
        public void DoAngleAxis_Injected_66F(){} // RVA: 0x7FFAC459F7C0
        public void SetGameObjectActive(){} // RVA: 0x7FFAC459F840
    }

    /// <summary>Originally: ÌÎÌÍÎÏÍÍÍÌÍÏÌÎÌÏÎÌÌÍÍÎÍ</summary>
    public class UdonOperationResponseStatusChanged_6550_6550 : UdonOperationResponseDisconnectMessage_331A_331A
    {
        public ÌÎÌÍÎÏÍÍÍÌÍÏÌÎÌÏÎÌÌÍÍÎÍ f_F85;
        public bool f_324; // 0x170
        public System.Collections.Generic.Queue`1<Photon.Client.EventData> f_973; // 0x178
        public Unity.Profiling.ProfilerMarker ÍÎÏÍÌÍÍÎÍÎÍÌÏÍÍÏÎÎÎÎÍÏÎ; // 0x180
        public System.Collections.Generic.Dictionary`2<int,Unity.Profiling.ProfilerMarker> ÏÌÏÏÍÎÎÏÏÎÍÏÌÏÎÌÍÍÍÍÍÏÎ; // 0x188

        // ── Methods ──
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFAC39E48C0
        public void Initialize(){} // RVA: 0x7FFAC39E4910
        public void set_AudioCaptureSource(){} // RVA: 0x7FFAC39E4960
        public void OnBecameInvisible(){} // RVA: 0x7FFAC39E4C30
        public void OnOperationResponse(){} // RVA: 0x7FFAC39E4F00
        public void NewImpulseEvent(){} // RVA: 0x7FFAC39E5060
        public void OnStatusChanged(){} // RVA: 0x7FFAC39E5810
        public void get_customCaretColor(){} // RVA: 0x7FFAC39E59C0
        public void GetInstanceID(){} // RVA: 0x7FFAC39E59D0
        public void Instantiate(){} // RVA: 0x7FFAC39E5A60
        public void Initialize_1D6556F32805(){} // RVA: 0x7FFAC39E59C0
        public void .ctor(){} // RVA: 0x7FFAC39E6210
        public void Awake(){} // RVA: 0x7FFAC39E59C0
        public void GetGameObject_A16(){} // RVA: 0x7FFAC39E65E0
        public void OnEvent(){} // RVA: 0x7FFAC39E6D90
        public void GetUnityEngine(){} // RVA: 0x7FFAC39E7860
        public void Start(){} // RVA: 0x7FFAC39E78E0
        public void GetCurrentTextCue(){} // RVA: 0x7FFAC39E7E00
    }

    /// <summary>Originally: ÍÏÍÍÌÍÍÍÍÍÌÎÎÏÎÌÎÍÌÍÏÍÏ</summary>
    public class UdonUnregisterEventHandlerRegisterEventHandl_2C20_2C20 : VRC_EventDispatcher
    {
        public ÍÏÍÍÌÍÍÍÍÍÌÎÎÏÎÌÎÍÌÍÏÍÏ _2C20;
        public System.Collections.Generic.HashSet`1<VRC.SDKBase.VRC_EventHandler> ÌÍÌÏÌÏÌÏÍÎÏÍÏÌÎÌÏÏÍÍÎÌÏ; // 0x8
        public string[] ÍÍÏÍÍÎÎÎÎÍÎÌÎÎÎÌÏÍÏÏÍÍÍ; // 0x10
        public System.Collections.Generic.HashSet`1<0x6B2517A0> ÌÌÍÎÌÎÎÎÎÏÍÏÏÍÏÏÍÎÏÎÍÍÌ; // 0x18
        public System.Collections.Generic.HashSet`1<0x6B2517A0> ÎÎÎÎÍÎÎÎÍÎÎÌÌÌÏÏÎÎÎÎÌÍÏ; // 0x20
        public System.Collections.Generic.HashSet`1<0x6B2517A0> ÍÌÏÍÍÍÍÌÌÌÍÍÍÌÍÏÎÌÎÏÎÍÏ; // 0x28

        // ── Methods ──
        public void UpdateHandlerState(){} // RVA: 0x7FFAC3E36AA0
        public void DoPlay(){} // RVA: 0x7FFAC3E36C10
        public void DoResetReplacementSha(){} // RVA: 0x7FFAC3E36E20
        public void .cctor(){} // RVA: 0x7FFAC3E372E0
        public void ClearEventHandler(){} // RVA: 0x7FFAC3E37C00
        public void FindGameObject(){} // RVA: 0x7FFAC3E3A220 | overloaded x2
        public void TryGetEventHandlerValue(){} // RVA: 0x7FFAC3E37F10
        public void ReadEventHandlerParticleLifetime(){} // RVA: 0x7FFAC3E37FC0
        public void ReadEventHandlerParticleLifetime_553AF242105F(){} // RVA: 0x7FFAC3E37FE0
        public void GetUnityEngine(){} // RVA: 0x7FFAC3E38370
        public void UnregisterEventHandler(){} // RVA: 0x7FFAC3E383D0
        public void UpdateMaterial(){} // RVA: 0x7FFAC3E38530
        public void GetUnityEngine_35CD8A9B1022(){} // RVA: 0x7FFAC3E39940
        public void GetUnityEngine_7BBE8629F800(){} // RVA: 0x7FFAC3E39990
        public void ApplyEventHandlerTextureOffset(){} // RVA: 0x7FFAC3E39A00
        public void set_useGUILayout(){} // RVA: 0x7FFAC3E39DE0
        public void TriggerEvent(){} // RVA: 0x7FFAC3E3A1C0
        public void GetUnityEngine_E1D24CBFCB38(){} // RVA: 0x7FFAC3E3A280
        public void GetEventHandler_1C5D2B69DBBF(){} // RVA: 0x7FFAC3E40240 | overloaded x2
        public void get_gameObject(){} // RVA: 0x7FFAC3E3B980
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC3E3BD20
        public void UnregisterEventHandler_19AA642816EA(){} // RVA: 0x7FFAC3E3BE50
        public void Awake_CB0133_CB01332FFE25(){} // RVA: 0x7FFAC3E41160 | overloaded x2
        public void GetDescendants(){} // RVA: 0x7FFAC3E3C220
        public void Initialize(){} // RVA: 0x7FFAC3E3C3E0
        public void UpdateHandlerState_37D7693C836D(){} // RVA: 0x7FFAC3E3C8A0
        public void get_gameObject_68344C56B03D(){} // RVA: 0x7FFAC3E3CB00
        public void Initialize_079D267F3CDC(){} // RVA: 0x7FFAC3E3CBE0
        public void InternalGetHashCode(){} // RVA: 0x7FFAC3E3CD50
        public void get_gameObject_4808918C70EA(){} // RVA: 0x7FFAC3E3CF80
        public void FindEventHandlerTransform(){} // RVA: 0x7FFAC3E3D330
        public void Instantiate(){} // RVA: 0x7FFAC3E3D4F0
        public void FindEventHandlerTransform_8C731D3E634D(){} // RVA: 0x7FFAC3E3D900
        public void ProcessHandlerTransform(){} // RVA: 0x7FFAC3E3DCE0
        public void RegisterEventHandler_699CC97A2C50(){} // RVA: 0x7FFAC3E3E3D0
        public void Awake(){} // RVA: 0x7FFAC3E3E510
        public void get_gameObject_E02F604EB9F3(){} // RVA: 0x7FFAC3E3E6B0
        public void ValidateEventHandler(){} // RVA: 0x7FFAC3E3EB80
        public void RegisterEventHandler(){} // RVA: 0x7FFAC3E3EF60
        public void ParseStandardFormatOrThrow(){} // RVA: 0x7FFAC3E3F030
        public void OnTriggerEnter(){} // RVA: 0x7FFAC3E3F090
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void RegisterPlay(){} // RVA: 0x7FFAC3E3F410
        public void UnregisterPlay(){} // RVA: 0x7FFAC3E3F7F0
        public void UpdatePlay(){} // RVA: 0x7FFAC3E40050
        public void set_enabled(){} // RVA: 0x7FFAC3E40A70
        public void set_enabled_E32CB0377CCF(){} // RVA: 0x7FFAC3E40B00
        public void OnDestroy(){} // RVA: 0x7FFAC3E40CD0
        public void ProcessPlay(){} // RVA: 0x7FFAC3E40E70
        public void GetGameObjectPath(){} // RVA: 0x7FFAC3E415C0
        public void TryGetEventHandlerValue_68FC345B71DC(){} // RVA: 0x7FFAC3E41610
    }

}