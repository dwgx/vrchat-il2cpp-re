// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon
// Classes: 18
// Methods: 576

namespace VRC.Udon
{
    public class AbstractSerializedUdonProgramAsset : ScriptableObject
    {
        // ── Methods ──
        public void StoreProgram(){} // RVA: 0x7FFD4E099B30 | overloaded x2
        public void RetrieveProgram(){} // RVA: 0x7FFD4E078E90
        public void GetSerializedProgramSize(){} // RVA: 0x7FFD4E078E90
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void TryGetEntrypointNameFromHash(){}
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFD4E07D200
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class AbstractUdonBehaviourEventProxy : MonoBehaviour
    {
        public VRC.Udon.UdonBehaviour EventReceiver; // 0x20

        // ── Methods ──
        public void get_EventReceiver(){} // RVA: 0x7FFD4E36F0C0
        public void set_EventReceiver(){} // RVA: 0x7FFD4E36F0D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class AbstractUdonProgramSource : ScriptableObject
    {
        public object SerializedProgramAsset;

        // ── Methods ──
        public void get_SerializedProgramAsset(){} // RVA: 0x7FFD4E078E90
        public void RunEditorUpdate(){} // RVA: 0x7FFD4E099B30
        public void RefreshProgram(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class IUdonTriggerEventConsumer
    {
        public object Priority;

        // ── Methods ──
        public void get_Priority(){} // RVA: 0x7FFD4E079960
        public void TryConsumeOnTriggerEnter(){} // RVA: 0x7FFD4E07D200
        public void TryConsumeOnTriggerExit(){} // RVA: 0x7FFD4E07D200
        public void TryConsumeOnTriggerStay(){} // RVA: 0x7FFD4E07D200
    }

    public class OnAnimatorMoveProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnAnimatorMove(){} // RVA: 0x7FFD552A9390
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class OnAudioFilterReadProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnAudioFilterRead(){} // RVA: 0x7FFD552A93F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class OnCollisionStayProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnCollisionStay(){} // RVA: 0x7FFD552A95D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class OnRenderObjectProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnRenderObject(){} // RVA: 0x7FFD552A95F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class OnTriggerStayProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnTriggerStay(){} // RVA: 0x7FFD552A9650
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class OnWillRenderObjectProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x7FFD552A9670
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class UdonBehaviour : AbstractUdonBehaviour
    {
        public VRC.Udon.Common.Interfaces.IUdonVariableTable SyncMethod; // 0x40
        public bool HasDoneStart; // 0x48
        public bool HasError; // 0x49
        public bool SyncIsContinuous; // 0x4A
        public bool SyncIsManual; // 0x4B
        public 0x665AEE60 OnInit; // 0x4C
        public VRC.Udon.AbstractSerializedUdonProgramAsset RequestSerializationHook; // 0x50
        public System.Action`2<VRC.Udon.UdonBehaviour,0x6662FCE0> DisableInteractive;
        public System.Action`1<VRC.Udon.UdonBehaviour> IsNetworkingSupported; // 0x8
        public bool IsInteractive; // 0x58
        public string UpdateOrder;
        public bool DisableEventProcessing; // 0x59
        public int ProgramId; // 0x5C
        public VRC.Udon.UdonManager ProgramSize; // 0x60
        public 0x6662FCE0 IsInitialized; // 0x68
        public ÎÏÍÏÏÎÌÌ.Î InteractionText; // 0x70
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
        public 0x66583B70 publicVariablesSerializationDataFormat; // 0xC8
        public Unity.Profiling.ProfilerMarker _preloadUdonProgramProfilerMarker; // 0xD0
        public Unity.Profiling.ProfilerMarker _initializeUdonContentProfilerMarker; // 0xD8

        // ── Methods ──
        public void get_SyncMethod(){} // RVA: 0x7FFD552A96D0
        public void set_SyncMethod(){} // RVA: 0x7FFD552A96F0
        public void get_HasDoneStart(){} // RVA: 0x7FFD4F224950
        public void get_HasError(){} // RVA: 0x7FFD4F2203A0
        public void get_SyncIsContinuous(){} // RVA: 0x7FFD552A9A70
        public void get_SyncIsManual(){} // RVA: 0x7FFD552A9AA0
        public void get_OnInit(){} // RVA: 0x7FFD552A9AD0
        public void set_OnInit(){} // RVA: 0x7FFD552A9B30
        public void get_RequestSerializationHook(){} // RVA: 0x7FFD552A9BE0
        public void set_RequestSerializationHook(){} // RVA: 0x7FFD552A9C40
        public void get_DisableInteractive(){} // RVA: 0x7FFD4E55F600
        public void set_DisableInteractive(){} // RVA: 0x7FFD4ECB2770
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFD53EE3600
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFD552A9D00
        public void get_IsInteractive(){} // RVA: 0x7FFD552A9D70
        public void get_UpdateOrder(){} // RVA: 0x7FFD552A9DB0
        public void get_DisableEventProcessing(){} // RVA: 0x7FFD52BACF40
        public void set_DisableEventProcessing(){} // RVA: 0x7FFD53BD5A20
        public void get_ProgramId(){} // RVA: 0x7FFD552A9E10
        public void get_ProgramSize(){} // RVA: 0x7FFD552A9F00
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD552AA100 | overloaded x2
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7FFD552AA210
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFD552AA370
        public void get_IsInitialized(){} // RVA: 0x7FFD53EE35F0
        public void GetComponentIndexFixed(){} // RVA: 0x7FFD552AA490
        public void LoadProgram(){} // RVA: 0x7FFD552AA4F0
        public void RegisterEventProxy(){} // RVA: 0x7FFD4E090980
        public void ProcessEntryPoints(){} // RVA: 0x7FFD552AAAD0
        public void DetectExistingProxies(){} // RVA: 0x7FFD552AB6E0
        public void ResolveUdonHeapReferences(){} // RVA: 0x7FFD552AB9D0
        public void ResolveUdonHeapReference(){} // RVA: 0x7FFD552ABD20
        public void ManagedUpdate(){} // RVA: 0x7FFD552AC0F0
        public void ManagedLateUpdate(){} // RVA: 0x7FFD552AC2A0
        public void ManagedFixedUpdate(){} // RVA: 0x7FFD552AC3C0
        public void PostLateUpdate(){} // RVA: 0x7FFD552AC4E0
        public void OnAnimatorIK(){} // RVA: 0x7FFD552AC600
        public void ProxyOnAnimatorMove(){} // RVA: 0x7FFD552AC750
        public void ProxyOnAudioFilterRead(){} // RVA: 0x7FFD552AC7A0
        public void OnBecameInvisible(){} // RVA: 0x7FFD552AC970
        public void OnBecameVisible(){} // RVA: 0x7FFD552AC9C0
        public void OnCollisionEnter(){} // RVA: 0x7FFD552ACA10
        public void OnCollisionEnter2D(){} // RVA: 0x7FFD552ACC80
        public void OnCollisionExit(){} // RVA: 0x7FFD552ACE80
        public void OnCollisionExit2D(){} // RVA: 0x7FFD552AD0F0
        public void ProxyOnCollisionStay(){} // RVA: 0x7FFD552AD2F0
        public void OnCollisionStay2D(){} // RVA: 0x7FFD552AD560
        public void OnDestroy(){} // RVA: 0x7FFD552AD760
        public void OnDisable(){} // RVA: 0x7FFD552ADD60
        public void OnDrawGizmos(){} // RVA: 0x7FFD552ADDC0
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD552ADE10
        public void OnEnable(){} // RVA: 0x7FFD552ADE60
        public void OnJointBreak(){} // RVA: 0x7FFD552ADEC0
        public void OnJointBreak2D(){} // RVA: 0x7FFD552AE040
        public void OnMouseDown(){} // RVA: 0x7FFD552AE160
        public void OnMouseDrag(){} // RVA: 0x7FFD552AE1B0
        public void OnMouseEnter(){} // RVA: 0x7FFD552AE200
        public void OnMouseExit(){} // RVA: 0x7FFD552AE250
        public void OnMouseOver(){} // RVA: 0x7FFD552AE2A0
        public void OnMouseUp(){} // RVA: 0x7FFD552AE2F0
        public void OnMouseUpAsButton(){} // RVA: 0x7FFD552AE340
        public void OnParticleCollision(){} // RVA: 0x7FFD552AE390
        public void OnParticleTrigger(){} // RVA: 0x7FFD552AE560
        public void OnPostRender(){} // RVA: 0x7FFD552AE5B0
        public void OnPreCull(){} // RVA: 0x7FFD552AE600
        public void OnPreRender(){} // RVA: 0x7FFD552AE650
        public void OnRenderImage(){} // RVA: 0x7FFD552AE6A0
        public void ProxyOnRenderObject(){} // RVA: 0x7FFD552AE910
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFD552AE960
        public void OnTransformParentChanged(){} // RVA: 0x7FFD552AE9B0
        public void OnTriggerEnter(){} // RVA: 0x7FFD552AEA00
        public void OnTriggerEnter2D(){} // RVA: 0x7FFD552AEDF0
        public void OnTriggerExit(){} // RVA: 0x7FFD552AEFF0
        public void OnTriggerExit2D(){} // RVA: 0x7FFD552AF3E0
        public void ProxyOnTriggerStay(){} // RVA: 0x7FFD552AF5E0
        public void OnTriggerStay2D(){} // RVA: 0x7FFD552AF9D0
        public void OnControllerColliderHit(){} // RVA: 0x7FFD552AFBD0
        public void OnValidate(){} // RVA: 0x7FFD552B0060
        public void ProxyOnWillRenderObject(){} // RVA: 0x7FFD552B00B0
        public void OnNetworkReady(){} // RVA: 0x7FFD552B0100
        public void Interact(){} // RVA: 0x7FFD552B0110
        public void OnDrop(){} // RVA: 0x7FFD552B0160
        public void OnPickup(){} // RVA: 0x7FFD552B01B0
        public void OnPickupUseDown(){} // RVA: 0x7FFD552B0200
        public void OnPickupUseUp(){} // RVA: 0x7FFD552B0250
        public void OnPreSerialization(){} // RVA: 0x7FFD552B02A0
        public void OnPostSerialization(){} // RVA: 0x7FFD552B0430
        public void OnDeserialization(){} // RVA: 0x7FFD552B06C0
        public void RunProgram(){} // RVA: 0x7FFD552B0A50 | overloaded x2
        public void GetPrograms(){} // RVA: 0x7FFD552B1040
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD552B1100
        public void DeserializePublicVariables(){} // RVA: 0x7FFD552B1110
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD552B1590
        public void SerializePublicVariables(){} // RVA: 0x7FFD552B1590
        public void TryToInterrogateUdon(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void RunEvent(){} // RVA: 0x7FFD4E5F9390 | overloaded x10
        public void RunEventAdvanced(){} // RVA: 0x7FFD552B19E0 | overloaded x10
        public void RunInputEvent(){} // RVA: 0x7FFD552B1D20
        public void GetEventParameterName(){} // RVA: 0x7FFD552B1FC0
        public void PreloadUdonProgram(){} // RVA: 0x7FFD552B22B0
        public void SearchUdonInterface(){} // RVA: 0x7FFD4E2ADC40
        public void InitializeUdonContent(){} // RVA: 0x7FFD552B2510
        public void RunOnInit(){} // RVA: 0x7FFD552B2D80
        public void RegisterUpdate(){} // RVA: 0x7FFD552B2F30
        public void UnregisterUpdate(){} // RVA: 0x7FFD552B35C0
        public void SendCustomEvent(){} // RVA: 0x7FFD552B3AE0
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFD552B3F60 | overloaded x9
        public void RequestSerialization(){} // RVA: 0x7FFD552B3FF0
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7FFD552B40A0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7FFD552B4220
        public void get_InteractionText(){} // RVA: 0x7FFD4E36F130
        public void set_InteractionText(){} // RVA: 0x7FFD4E342E90
        public void get_SyncMetadataTable(){} // RVA: 0x7FFD552B43B0
        public void GetProgramVariableType(){} // RVA: 0x7FFD552B4410
        public void SetProgramVariable(){} // RVA: 0x7FFD552B4520 | overloaded x2
        public void SetHeapVariable(){} // RVA: 0x7FFD4E2ADC40
        public void GetProgramVariable(){} // RVA: 0x7FFD552B4660 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFD552B47C0 | overloaded x2
        public void SetupLogging(){} // RVA: 0x7FFD552B49F0
        public void AssignProgramAndVariables(){} // RVA: 0x7FFD552B4B30
        public void .ctor(){} // RVA: 0x7FFD552B4BE0
        public void .cctor(){} // RVA: 0x7FFD552B4FF0
    }

    /// <summary>Originally: ÎÍÌÎÎÏÌÌÏÌÍÏÎÏÎÌÌÌÍÍÌÏÏ</summary>
    public class UdonBehaviourResultBytes_CF3F : Object
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
        public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
        public void .ctor(){} // RVA: 0x7FFD4E5F0150
        public void Initialize(){} // RVA: 0x7FFD4E5F02C0
        public void get_Result(){} // RVA: 0x7FFD4E5F04E0
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void AddSubtraction(){} // RVA: 0x7FFD4E342E90
        public void get_Url(){} // RVA: 0x7FFD4E5F0140
        public void set_ValidatingStreamVersion(){} // RVA: 0x7FFD4E39CCE0
        public void set_name(){} // RVA: 0x7FFD4E39CCE0
        public void Instantiate(){} // RVA: 0x7FFD4E36F130
        public void CancelDownload(){} // RVA: 0x7FFD4E5F0590
        public void set_ErrorCode(){} // RVA: 0x7FFD4E5F0600
        public void StartDownload(){} // RVA: 0x7FFD4E5F0820
        public void set_Error(){} // RVA: 0x7FFD4E5F0590
        public void get_ErrorCode(){} // RVA: 0x7FFD4E39CCD0
        public void SetOverlay(){} // RVA: 0x7FFD4E369200
        public void get_Error(){} // RVA: 0x7FFD4E36F130
        public void get_UdonBehaviour(){} // RVA: 0x7FFD4E3BE740
        public void set_element(){} // RVA: 0x7FFD4E5F0C20
        public void SetCurrentSocket(){} // RVA: 0x7FFD4E36F0D0
        public void get_ResultBytes(){} // RVA: 0x7FFD4E36F0C0
        public void set_ResultBytes(){} // RVA: 0x7FFD4E5F0C80
    }

    /// <summary>Originally: ÍÌÎÍÍÎÍÏÌÍÍÎÎÍÎÌÎÏÌÏÎÌÏ</summary>
    public class UdonDisableEventProcessing_A521 : AbstractUdonBehaviour
    {
        public bool _disableInteractive; // 0x40
        public bool _syncMethod; // 0x41
        public bool _disableEventProcessing; // 0x42
        public string _syncMetadataTable; // 0x48
        public 0x665AEE60 _interactionText; // 0x50
        public 0x665C1448[] _isNetworkingSupported; // 0x58
        public System.Collections.Generic.Dictionary`2<uint,string> f_71F; // 0x60
        public System.Collections.Generic.Dictionary`2<string,uint> f_297; // 0x68
        public System.Collections.Generic.Dictionary`2<string,object> ÍÏÎÏÏÏÎÏÍÏÌÏÍÎÍÎÎÏÌÍÏÍÎ; // 0x70
        public ÌÍÎÍÏÌÌÏÎÎÎÌÎÍÍÍÎÎÌÌÏÍÏ <ÌÌÌÍÎÌÍÍÎÌÎÌÎÌÌÍÏÍÌÌÏÎÌ>k__BackingField; // 0x78

        // ── Methods ──
        public void RunEvent(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
        public void SendCustomNetworkEvent(){} // RVA: 0x7FFD4E5F9350 | overloaded x9
        public void RunEventAdvanced(){} // RVA: 0x7FFD4E2ADC40 | overloaded x10
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7FFD4E5F8450
        public void GetProgramVariable(){} // RVA: 0x7FFD4E5F9250 | overloaded x2
        public void get_DisableInteractive(){} // RVA: 0x7FFD4E3FCC00
        public void SetResources(){} // RVA: 0x7FFD4E409510
        public void Interact(){} // RVA: 0x7FFD4E341310
        public void SetResources_5DD4CA70B94E(){} // RVA: 0x7FFD4E409510
        public void SendCustomNetworkEvent_57FA4903FC5C(){} // RVA: 0x7FFD4E5F84C0
        public void SetProgramVariable(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SendCustomNetworkEvent_E8BBCBCF8EFE(){} // RVA: 0x7FFD4E5F86A0
        public void GetComponentIndexFixed(){} // RVA: 0x7FFD4E5F8770
        public void InitializeUdonContent(){} // RVA: 0x7FFD4E341310
        public void get_SyncMethod(){} // RVA: 0x7FFD4E5110E0
        public void SetResources_80B0DF0B7577(){} // RVA: 0x7FFD4E409510
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7FFD4E5F87C0
        public void RunProgram(){} // RVA: 0x7FFD4E5F8830
        public void SetResources_E6C8FFA046A7(){} // RVA: 0x7FFD4E409510
        public void get_IsNetworkingSupported_7EC8FF59A5F1(){} // RVA: 0x7FFD4E5F8940
        public void set_DisableInteractive(){} // RVA: 0x7FFD4E3FCC10
        public void set_DisableEventProcessing(){} // RVA: 0x7FFD4E5F8A10
        public void OnSerializing(){} // RVA: 0x7FFD4E409500
        public void get_DisableEventProcessing(){} // RVA: 0x7FFD4E5F8A60
        public void set_imageUrl(){} // RVA: 0x7FFD4E5006F0
        public void .ctor(){} // RVA: 0x7FFD4E5F8A70
        public void RunEvent_39E8053A03C2(){} // RVA: 0x7FFD4E5F8C70
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500 | overloaded x2
        public void TryGetProgramVariable(){} // RVA: 0x7FFD4E07D200 | overloaded x2
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7FFD4E5F8F90
        public void get_SyncMetadataTable(){} // RVA: 0x7FFD4E5F8FD0
        public void GetPlaybackQualityStats(){} // RVA: 0x7FFD4E505600
        public void get_InteractionText(){} // RVA: 0x7FFD4E3BC730
        public void set_SyncMethod(){} // RVA: 0x7FFD4E5F9010
        public void get_IsNetworkingSupported(){} // RVA: 0x7FFD4E5F90A0
        public void set_InteractionText(){} // RVA: 0x7FFD4E3BC740
        public void GetProgramVariableType(){} // RVA: 0x7FFD4E5F90B0
        public void SendCustomEvent(){} // RVA: 0x7FFD4E5F9140
        public void set_IsNetworkingSupported(){} // RVA: 0x7FFD4E5F9200
        public void DoThrowUInt16OverflowException(){} // RVA: 0x7FFD4E5006F0
        public void RunInputEvent(){} // RVA: 0x7FFD4E5F92D0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7FFD4E5F9310
        public void RequestSerialization(){} // RVA: 0x7FFD4E341310
        public void GetPlaybackQualityStats_559E674D3E83(){} // RVA: 0x7FFD4E505600
    }

    public class UdonManager : MonoBehaviour
    {
        public System.Action`1<0x6662FCE0> HasLoaded;
        public System.Action Instance; // 0x8
        public VRC.Udon.UdonBehaviour SignatureVerificationFailed; // 0x20
        public bool SignatureVerificationSuccess; // 0x28
        public VRC.Udon.UdonManager SignatureVerificationSkipped; // 0x10
        public 0x66604A48 WorldSignatureVerificationEnabled; // 0x18
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
        public ÍÎÌÎÌÎÍÍÎÌÌÏÍÎÎÎÌÎ _udonTimeSource; // 0xA8
        public VRC.Udon.Security.Interfaces.IUdonSecurityBlacklist`1<UnityEngine.Object> _blacklist; // 0xB0
        public VRC.Udon.ClientBindings.Interfaces.IUdonClientInterface _udonClientInterface; // 0xB8
        public ÎÏÍÏÏÎÌÌ.ÌÍÎÍÌÎÌÎÌÍÏÏÍÎÏ _udonEventScheduler; // 0xC0
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
        public void add_OnUdonProgramLoaded(){} // RVA: 0x7FFD552B52E0
        public void remove_OnUdonProgramLoaded(){} // RVA: 0x7FFD552B5440
        public void add_OnUdonReady(){} // RVA: 0x7FFD552B55A0
        public void remove_OnUdonReady(){} // RVA: 0x7FFD552B56F0
        public void get_HasLoaded(){} // RVA: 0x7FFD4E516BA0
        public void set_HasLoaded(){} // RVA: 0x7FFD4F044F40
        public void get_Instance(){} // RVA: 0x7FFD552B5840
        public void get_SignatureVerificationFailed(){} // RVA: 0x7FFD4EA61480
        public void get_SignatureVerificationSuccess(){} // RVA: 0x7FFD4F7265A0
        public void get_SignatureVerificationSkipped(){} // RVA: 0x7FFD4EAB6B20
        public void get_WorldSignatureVerificationEnabled(){} // RVA: 0x7FFD4FBDB0F0
        public void set_WorldSignatureVerificationEnabled(){} // RVA: 0x7FFD4FBDB100
        public void ResetWorldSignatureVerification(){} // RVA: 0x7FFD552B58A0
        public void EnableWorldSignatureVerification(){} // RVA: 0x7FFD552B5910
        public void RegisterTriggerEventConsumer(){} // RVA: 0x7FFD552B59D0
        public void UnregisterTriggerEventConsumer(){} // RVA: 0x7FFD552B5BF0
        public void TryNotifyOnTriggerEnterConsumers(){} // RVA: 0x7FFD552B5C60
        public void TryNotifyOnTriggerExitConsumers(){} // RVA: 0x7FFD552B5E00
        public void TryNotifyOnTriggerStayConsumers(){} // RVA: 0x7FFD552B5FA0
        public void Awake(){} // RVA: 0x7FFD552B6140
        public void Update(){} // RVA: 0x7FFD552B6A50
        public void LateUpdate(){} // RVA: 0x7FFD552B7100
        public void FixedUpdate(){} // RVA: 0x7FFD552B7740
        public void PostLateUpdate(){} // RVA: 0x7FFD552B7D80
        public void OnDestroy(){} // RVA: 0x7FFD552B8480
        public void GetWrapperModule(){} // RVA: 0x7FFD4E2ADC40
        public void RegisterInput(){} // RVA: 0x7FFD552B85F0
        public void RunInputAction(){} // RVA: 0x7FFD552B86D0
        public void UpdateInputQueue(){} // RVA: 0x7FFD552B8A10
        public void get_IsSceneLoading(){} // RVA: 0x7FFD4F0AB9C0
        public void set_IsSceneLoading(){} // RVA: 0x7FFD4F0ADFF0
        public void OnSceneLoaded(){} // RVA: 0x7FFD552B8DF0
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7FFD552BA350
        public void ProcessUdonProgram(){} // RVA: 0x7FFD552BA4B0
        public void OnSceneUnloaded(){} // RVA: 0x7FFD552BA530
        public void PurgeSerializationCaches(){} // RVA: 0x7FFD552BA5A0
        public void GetTotalLoadedProgramSize(){} // RVA: 0x7FFD552BA710
        public void GetLoadedBehavioursSyncTypes(){} // RVA: 0x7FFD552BAEB0
        public void RegisterUdonBehaviourUpdate(){} // RVA: 0x7FFD552BB420
        public void RegisterUdonBehaviourLateUpdate(){} // RVA: 0x7FFD552BB500
        public void RegisterUdonBehaviourFixedUpdate(){} // RVA: 0x7FFD552BB5E0
        public void RegisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7FFD552BB6C0
        public void UnregisterUdonBehaviourUpdate(){} // RVA: 0x7FFD552BB800
        public void UnregisterUdonBehaviourLateUpdate(){} // RVA: 0x7FFD552BB8E0
        public void UnregisterUdonBehaviourFixedUpdate(){} // RVA: 0x7FFD552BB9C0
        public void UnregisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7FFD552BBAA0
        public void ScheduleDelayedEvent(){} // RVA: 0x7FFD552BBC70 | overloaded x2
        public void HandleUdonEventScheduled(){} // RVA: 0x7FFD552BBD60
        public void SetUdonEnabled(){} // RVA: 0x7FFD4F7D4D70
        public void IncrementDepthCount(){} // RVA: 0x7FFD552BBDE0
        public void DecrementDepthCount(){} // RVA: 0x7FFD552BBEF0
        public void get_DebugLogging(){} // RVA: 0x7FFD552BBFB0
        public void set_DebugLogging(){} // RVA: 0x7FFD552BC000
        public void ConstructUdonVM(){} // RVA: 0x7FFD552BC070
        public void ApplyFilter(){} // RVA: 0x7FFD552BC1C0 | overloaded x2
        public void Blacklist(){} // RVA: 0x7FFD552BC140 | overloaded x2
        public void CleanBlacklist(){} // RVA: 0x7FFD552BC220
        public void IsBlacklisted(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7FFD552BC2D0
        public void get_LightReservedLayerMask(){} // RVA: 0x7FFD552BC330
        public void set_LightReservedLayerMask(){} // RVA: 0x7FFD552BC390
        public void GetWrapper(){} // RVA: 0x7FFD552BC3F0
        public void RegisterUdonBehaviour(){} // RVA: 0x7FFD552BC440
        public void UnregisterUdonBehaviour(){} // RVA: 0x7FFD552BC760
        public void CheckUdonBehavioursToRegister(){} // RVA: 0x7FFD552BC8D0
        public void GetUdonBehavioursInScene(){} // RVA: 0x7FFD552BCA00
        public void RunEvent(){} // RVA: 0x7FFD552BDE00 | overloaded x10
        public void .ctor(){} // RVA: 0x7FFD552BE080
        public void .cctor(){} // RVA: 0x7FFD552BEFD0
        public void <OnSceneLoaded>b__102_0(){} // RVA: 0x7FFD552BF090
    }

    /// <summary>Originally: ÎÎÎÏÍÎÌÏÏÍÎÏÍÍÌÏÎÌÏÎÍÌÎ</summary>
    public class UdonOperationResponsImpl_9030 : UdonOperationResponseDisconnectMessage_331A
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F9C8360
    }

    /// <summary>Originally: ÏÌÌÎÍÏÏÍÎÍÌÌÏÏÏÏÎÎÌÏÌÎÌ</summary>
    public class UdonOperationResponseDisconnectMessage_331A : Object
    {
        public Photon.Client.PhotonPeer _name; // 0x10
        public string _hideFlags; // 0x18
        public 0x665CA6B8 f_112; // 0x20
        public int f_D26; // 0x24
        public int f_91C; // 0x28
        public Photon.Realtime.AppSettings f_8F2; // 0x30
        public 0x66377F28 f_4A9; // 0x38
        public ÍÏÍÎÏÍÍÎÏÌÍÎÌÎÏÏÌÌÌÍÎÎÌ f_5FC; // 0x40
        public 0x66377F80 f_265; // 0x48
        public string f_CAD; // 0x50
        public ÍÎÌÏÌÍÏÍÏÎÌÎÎÌÍÍÌÍÍÏÍÌÏ f_EB2; // 0x58
        public string f_C83; // 0x60
        public string f_764; // 0x68
        public System.Func`3<string,0x66377ED0,string> f_BB8; // 0x70
        public 0x66377ED0 f_FD6; // 0x78
        public 0x66377D70 f_58F; // 0x7C
        public Photon.Realtime.ConnectionHandler f_005; // 0x80
        public System.Action`2<0x66377D70,0x66377D70> f_849; // 0x88
        public System.Action`1<Photon.Client.EventData> f_3C3; // 0x90
        public System.Action`2<bool,object> f_730; // 0x98
        public System.Action`1<Photon.Client.OperationResponse> f_76D; // 0xA0
        public ÎÏÌÏÌÍÏÍÎÍÌÌÏÎÍÏÍÌÏÏÎÎÎ f_986; // 0xA8
        public ÍÏÌÎÏÎÏÎÌÌÌÍÎÏÍÍÎÌÎÍÏÍÌ f_A6E; // 0xB0
        public ÌÌÍÍÌÎÏÍÏÍÎÍÏÌÏÎÎÏÌÌÍÌÏ f_754; // 0xB8
        public ÌÎÏÍÎÌÌÍÍÌÍÍÍÎÍÏÍÎÏÏÌÏÌ f_0E1; // 0xC0
        public ÍÌÏÌÌÏÌÌÏÍÍÌÏÏÌÏÍÎÍÎÏÍÏ f_68C; // 0xC8
        public 0x66377E78 f_360; // 0xD0
        public ÍÍÏÎÎÍÌÏÏÎÍÎÎÎÍÍÏÏÌÍÏÍÏ f_F78; // 0xD8
        public ÎÌÌÍÌÎÍÍÎÏÌÌÍÌÎÎÌÎÌÌÍÎÎ f_F32; // 0xE0
        public ÎÌÌÍÌÎÍÍÎÏÌÌÍÌÎÎÌÎÌÌÍÎÎ f_32A; // 0xE8
        public System.Collections.Generic.List`1<ÎÏÏÍÌÌÍÏÏÎÎÏÏÍÎÎÎÌÍÎÎÎÍ> f_05E; // 0xF0
        public ÏÏÏÍÌÌÍÎÎÍÏÎÍÏÍÎÌÌÌÎÎÌÎ f_0FB; // 0xF8
        public ÎÎÎÏÌÌÍÏÎÍÎÌÎÌÌÏÌÌÍÌÎÏÏ f_A39; // 0x100
        public int <ÏÌÏÏÏÎÌÎÍÎÎÍÌÏÏÍÍÏÎÌÍÎÎ>k__BackingField; // 0x108
        public int <ÎÌÏÌÎÎÎÍÎÍÎÏÎÎÎÎÏÌÏÌÎÏÍ>k__BackingField; // 0x10C
        public int <ÍÏÌÎÍÎÏÏÌÏÍÌÎÌÏÏÍÏÌÌÏÍÍ>k__BackingField; // 0x110
        public 0x66377E20 ÌÎÎÍÎÎÎÍÏÍÌÎÌÏÌÍÌÎÏÏÎÏÏ; // 0x114
        public ÍÍÎÎÎÏÏÏÎÏÌÍÏÍÍÌÏÌÏÍÏÎÎ ÎÍÌÏÍÏÏÏÍÎÌÌÎÎÌÎÌÎÏÎÎÌÍ; // 0x118
        public Photon.Client.OperationResponse ÏÏÏÍÏÏÏÏÍÎÌÏÏÌÌÌÏÏÏÍÍÎÌ; // 0x120
        public int ÌÍÎÍÎÍÍÎÏÍÍÎÌÏÌÏÍÎÎÍÍÌÏ;
        public string[] ÎÍÏÎÌÎÎÍÍÍÏÎÎÍÏÍÎÎÌÏÎÏÏ; // 0x128
        public string <ÏÍÏÏÏÏÏÌÎÍÏÌÍÍÎÌÎÎÍÏÍÌÌ>k__BackingField; // 0x130
        public string <ÌÍÎÏÏÎÌÏÍÏÌÎÍÏÏÍÌÍÏÎÍÏÍ>k__BackingField; // 0x138
        public ÎÏÏÌÏÌÍÏÍÍÎÍÎÌÍÎÌÏÌÌÍÍÍ ÎÏÎÌÎÏÌÌÍÏÏÌÎÏÌÍÌÎÍÌÍÏÏ; // 0x140
        public System.Collections.Generic.Queue`1<ÎÍÍÎÍÎÏÍÍÏÍÌÌÎÍÍÏÏÌÎÍÎÎ> ÏÏÎÏÏÏÏÌÍÍÏÌÎÌÏÏÎÍÏÏÌÌÌ; // 0x148
        public System.Collections.Generic.HashSet`1<object> ÎÏÍÌÌÍÏÍÎÏÏÍÌÎÌÎÍÎÎÍÎÏÌ; // 0x150
        public 0x66379268 ÏÍÎÏÍÎÎÏÎÏÏÍÏÏÌÍÎÎÎÍÌÍÏ; // 0x158
        public ÌÍÎÌÍÍÏÏÍÌÍÎÌÍÍÌÍÏÏÏÌÍÍ ÏÌÎÌÍÌÍÌÎÏÏÍÌÏÏÎÏÌÏÏÍÍÌ; // 0x160
        public Photon.Client.Pool`1<Photon.Client.ParameterDictionary> ÌÏÎÌÎÎÍÏÏÌÌÎÍÏÎÍÍÏÎÏÍÎÏ; // 0x168
        public string ÍÏÎÏÏÌÌÌÍÍÏÌÏÌÎÏÏÍÍÍÎÌÍ;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F9B0AA0
        public void Initialize(){} // RVA: 0x7FFD4F9B1B60
        public void set_AudioCaptureSource(){} // RVA: 0x7FFD4F9B1C30
        public void op_Implicit_780B1E5F837B(){} // RVA: 0x7FFD4F9B8010 | overloaded x2
        public void get_domainList(){} // RVA: 0x7FFD4E3C2900
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F9B1D30
        public void set_Flags(){} // RVA: 0x7FFD4E9A8350
        public void get_name(){} // RVA: 0x7FFD4F9B1E50
        public void set_name(){} // RVA: 0x7FFD4F9B1FF0
        public void Instantiate(){} // RVA: 0x7FFD4F9B2050
        public void Equals(){} // RVA: 0x7FFD4F9B2150
        public void GetHashCode(){} // RVA: 0x7FFD4F9B2170
        public void ToString(){} // RVA: 0x7FFD4F9B2240
        public void GetGameObject_A16(){} // RVA: 0x7FFD4F9B23D0
        public void DoAngleAxis_Injected_F9A(){} // RVA: 0x7FFD4F9B29E0
        public void ProcessDisconnectMessage(){} // RVA: 0x7FFD4F9B2D90
        public void SendDisconnectMessage(){} // RVA: 0x7FFD4F9B33C0
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4E70F410
        public void ReceiveDisconnectMessage(){} // RVA: 0x7FFD4F9B35A0
        public void get_categories(){} // RVA: 0x7FFD4E916C80
        public void Destroy(){} // RVA: 0x7FFD4F9B3860
        public void DestroyImmediate(){} // RVA: 0x7FFD4F9B3A30
        public void FindObjectsOfType(){} // RVA: 0x7FFD4F9B3B30
        public void GetRotation(){} // RVA: 0x7FFD4F9B3B50
        public void FindObjectsOfType_88D5DE2670F6(){} // RVA: 0x7FFD4F9B3CC0
        public void FindObjectsByType(){} // RVA: 0x7FFD4F9B44F0
        public void OnEvent(){} // RVA: 0x7FFD4F9B4AB0
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4F9B5AC0
        public void get_hideFlags(){} // RVA: 0x7FFD4F9B5DC0
        public void set_hideFlags(){} // RVA: 0x7FFD4F9B5F60
        public void DropdownValueChanged(){} // RVA: 0x7FFD4F9B63A0
        public void FindObjectOfType(){} // RVA: 0x7FFD4F9B63B0
        public void FindFirstObjectByType(){} // RVA: 0x7FFD4F9B63D0
        public void HandleDisconnectMessage(){} // RVA: 0x7FFD4F9B6710
        public void CheckNullArgument(){} // RVA: 0x7FFD4F9B67D0
        public void GetProperties(){} // RVA: 0x7FFD4E964340
        public void OnMessage(){} // RVA: 0x7FFD4F9B6E90
        public void GetStatus(){} // RVA: 0x7FFD4F9B6EF0
        public void ParseDisconnectMessage(){} // RVA: 0x7FFD4F9B6F00
        public void CheckMessageStatus(){} // RVA: 0x7FFD4F9B6FA0
        public void op_Equality_16201CE17DFF(){} // RVA: 0x7FFD4F9BDD20 | overloaded x2
        public void op_Inequality(){} // RVA: 0x7FFD4F9B7120
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFD4F9B71B0
        public void Internal_CloneSingle(){} // RVA: 0x7FFD4F9B75E0
        public void Internal_CloneSingleWithParent(){} // RVA: 0x7FFD4F9B7660
        public void AddUnitNode(){} // RVA: 0x7FFD4E36F890
        public void get_Uploaded(){} // RVA: 0x7FFD4E9622C0
        public void get_Module(){} // RVA: 0x7FFD4F846B30
        public void GetName(){} // RVA: 0x7FFD4F9B7680
        public void SetName(){} // RVA: 0x7FFD4F9B7880
        public void FindObjectFromInstanceID(){} // RVA: 0x7FFD4E35C380
        public void GetOffsetOfInstanceIDInCPlusPlusObject_8D278CF1455B(){} // RVA: 0x7FFD4F9B79E0
        public void get_atlasHeight(){} // RVA: 0x7FFD4F9B7A10
        public void SerializeDisconnectMessage(){} // RVA: 0x7FFD4F9B7A20
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x7FFD4F9B7B30
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x7FFD4F9B7C00
        public void set_atlasWidth(){} // RVA: 0x7FFD4F9B7C50
        public void set_atlasWidth_ACD780BE1B80(){} // RVA: 0x7FFD4F9B7C60
        public void set_EffectiveUnmappedMemberHandling(){} // RVA: 0x7FFD4F9B7C80
        public void set_EffectiveUnmappedMemberHandling_DA1C5A5C674E(){} // RVA: 0x7FFD4F9B7C90
        public void Initialize_D733C3F21BD1(){} // RVA: 0x7FFD4F9B7DA0
        public void GetHashCode_D4AA7FF98D2C(){} // RVA: 0x7FFD4F9B8000
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFD4F9B80F0
        public void DeserializeDisconnectMessage(){} // RVA: 0x7FFD4F9B8690
        public void ReadDisconnectMessage(){} // RVA: 0x7FFD4F9B86B0
        public void WriteDisconnectMessage(){} // RVA: 0x7FFD4F9B8C10
        public void ValidateDisconnectMessage(){} // RVA: 0x7FFD4F9B8E70
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFD4F9B8F70
        public void AcceptDisconnectMessage_6903F6DB5527(){} // RVA: 0x7FFD4F9BDB30 | overloaded x2
        public void RejectDisconnectMessage(){} // RVA: 0x7FFD4F9B8F90
        public void CreateDisconnectMessage(){} // RVA: 0x7FFD4F9B9210
        public void InitializeDisconnectMessage(){} // RVA: 0x7FFD4F9B95F0
        public void Initialize_51F2C62BF0BE(){} // RVA: 0x7FFD4F9B96F0
        public void set_payload(){} // RVA: 0x7FFD4EDC79B0
        public void SetOverlay(){} // RVA: 0x7FFD4E369200
        public void AckDisconnectMessage(){} // RVA: 0x7FFD4F9B9710
        public void GetProperties_C93D8383396E(){} // RVA: 0x7FFD4F9B9830
        public void get_blurSamples(){} // RVA: 0x7FFD4F9B9E70
        public void Initialize_5BBC8B3CF52D(){} // RVA: 0x7FFD4F9B9E80
        public void GetTargets(){} // RVA: 0x7FFD4E3DF370
        public void get_EnableServerTracing(){} // RVA: 0x7FFD4F9B9EA0
        public void MoveNext(){} // RVA: 0x7FFD4F9B9EE0
        public void set_trackerAnchor(){} // RVA: 0x7FFD4E3DF380
        public void NackDisconnectMessage(){} // RVA: 0x7FFD4F9BA170
        public void GetHashCode_179F963EFA3A(){} // RVA: 0x7FFD4F914DD0
        public void WriteValue(){} // RVA: 0x7FFD4E099B30
        public void Initialize_421CB9911C9A(){} // RVA: 0x7FFD4F9BA2D0
        public void OnStatusChanged(){} // RVA: 0x7FFD4F9BA440
        public void set_atlasHeight(){} // RVA: 0x7FFD4F9BAD60
        public void set_atlasHeight_5F09EE131209(){} // RVA: 0x7FFD4F9BAD70
        public void set_categories(){} // RVA: 0x7FFD4E916750
        public void OnOperationResponse(){} // RVA: 0x7FFD4F9BAD90
        public void GetAt(){} // RVA: 0x7FFD4F9BC880
        public void DisconnectMessageTimeout(){} // RVA: 0x7FFD4F9BC980
        public void IsNativeObjectAlive_561D8FF8BECA(){} // RVA: 0x7FFD4F9BCA00
        public void DisconnectMessageError(){} // RVA: 0x7FFD4F9BCB90
        public void DisconnectMessageSuccess(){} // RVA: 0x7FFD4F9BCC70
        public void DisconnectMessageFailed(){} // RVA: 0x7FFD4F9BCC90
        public void ComputeTask(){} // RVA: 0x7FFD4F9BCFF0
        public void ComputeTask_0F9ECA62327B(){} // RVA: 0x7FFD4F9BD080
        public void GetDisconnectReason(){} // RVA: 0x7FFD4F9BD180
        public void set_fallbackFontAssetTable(){} // RVA: 0x7FFD4EAF84B0
        public void InitPayloadEncryption(){} // RVA: 0x7FFD4E8F4AA0
        public void SetDisconnectReason(){} // RVA: 0x7FFD4F9BD1C0
        public void StartPickedUp(){} // RVA: 0x7FFD4E3BCD60
        public void HasDisconnectReason(){} // RVA: 0x7FFD4F9BD8B0
        public void SetDisconnectMessage(){} // RVA: 0x7FFD4F9BDAE0
        public void ClearMessage(){} // RVA: 0x7FFD4F9BDBC0
        public void CreateHandle(){} // RVA: 0x7FFD4F9BDE10
        public void get_atlasHeight_35E9C719DD94(){} // RVA: 0x7FFD4F9B7A10
        public void GetFileLineNumber(){} // RVA: 0x7FFD4E9AA870
        public void AttachDisconnectMessageBody(){} // RVA: 0x7FFD4E341310
        public void OnDisconnectMessage(){} // RVA: 0x7FFD4F9BDF40
        public void get_pinkyTip(){} // RVA: 0x7FFD4F9BE090
        public void Reset(){} // RVA: 0x7FFD4F9BE440
        public void InitializeComponentProperties(){} // RVA: 0x7FFD4F9BE920
        public void DropdownValueChanged_9BC1D31A6190(){} // RVA: 0x7FFD4F9B63A0
        public void GetBufferedTimes(){} // RVA: 0x7FFD4E3BE740
        public void ConfigureAudioSource(){} // RVA: 0x7FFD4F9BEA20
        public void get_Uploaded_C767B7870CEA(){} // RVA: 0x7FFD4E9622C0
        public void DebugReturn(){} // RVA: 0x7FFD4F9BEEF0
        public void IndexOf(){} // RVA: 0x7FFD4F9BEFA0
        public void get_counterVelocityMode(){} // RVA: 0x7FFD4ED671E0
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void __OnPointerExit__UnityEngineEventSystemsPointerEventData__SystemVoid(){} // RVA: 0x7FFD4F9BF040
        public void IndexOf_F8C1E5A731FC(){} // RVA: 0x7FFD4F9BF050
        public void GetMaterial(){} // RVA: 0x7FFD4E3BCD50
        public void IndexOf_0F591CAC6782(){} // RVA: 0x7FFD4F9BF090
        public void set_domainList(){} // RVA: 0x7FFD4E3C2910
        public void IndexOf_070442A101EC(){} // RVA: 0x7FFD4F9BF0A0
        public void ComputeNow(){} // RVA: 0x7FFD4F9BF1A0
        public void get_AudioCaptureSource(){} // RVA: 0x7FFD4EAB6B20
        public void set_UserId(){} // RVA: 0x7FFD4F9BF3D0
        public void get_Plugins(){} // RVA: 0x7FFD4F9BF630
        public void DoAngleAxis_Injected_66F(){} // RVA: 0x7FFD4F9BF7C0
        public void SetGameObjectActive(){} // RVA: 0x7FFD4F9BF840
    }

    /// <summary>Originally: ÌÎÌÍÎÏÍÍÍÌÍÏÌÎÌÏÎÌÌÍÍÎÍ</summary>
    public class UdonOperationResponseStatusChanged_6550 : UdonOperationResponseDisconnectMessage_331A
    {
        public ÌÎÌÍÎÏÍÍÍÌÍÏÌÎÌÏÎÌÌÍÍÎÍ f_F85;
        public bool f_324; // 0x170
        public System.Collections.Generic.Queue`1<Photon.Client.EventData> f_973; // 0x178
        public Unity.Profiling.ProfilerMarker ÍÎÏÍÌÍÍÎÍÎÍÌÏÍÍÏÎÎÎÎÍÏÎ; // 0x180
        public System.Collections.Generic.Dictionary`2<int,Unity.Profiling.ProfilerMarker> ÏÌÏÏÍÎÎÏÏÎÍÏÌÏÎÌÍÍÍÍÍÏÎ; // 0x188

        // ── Methods ──
        public void set_IsSimulationEnabled(){} // RVA: 0x7FFD4EE048C0
        public void Initialize(){} // RVA: 0x7FFD4EE04910
        public void set_AudioCaptureSource(){} // RVA: 0x7FFD4EE04960
        public void OnBecameInvisible(){} // RVA: 0x7FFD4EE04C30
        public void OnOperationResponse(){} // RVA: 0x7FFD4EE04F00
        public void NewImpulseEvent(){} // RVA: 0x7FFD4EE05060
        public void OnStatusChanged(){} // RVA: 0x7FFD4EE05810
        public void get_customCaretColor(){} // RVA: 0x7FFD4EE059C0
        public void GetInstanceID(){} // RVA: 0x7FFD4EE059D0
        public void Instantiate(){} // RVA: 0x7FFD4EE05A60
        public void Initialize_1D6556F32805(){} // RVA: 0x7FFD4EE059C0
        public void .ctor(){} // RVA: 0x7FFD4EE06210
        public void Awake(){} // RVA: 0x7FFD4EE059C0
        public void GetGameObject_A16(){} // RVA: 0x7FFD4EE065E0
        public void OnEvent(){} // RVA: 0x7FFD4EE06D90
        public void GetUnityEngine(){} // RVA: 0x7FFD4EE07860
        public void Start(){} // RVA: 0x7FFD4EE078E0
        public void GetCurrentTextCue(){} // RVA: 0x7FFD4EE07E00
    }

    /// <summary>Originally: ÍÏÍÍÌÍÍÍÍÍÌÎÎÏÎÌÎÍÌÍÏÍÏ</summary>
    public class UdonUnregisterEventHandlerRegisterEventHandl_2C20 : VRC_EventDispatcher
    {
        public ÍÏÍÍÌÍÍÍÍÍÌÎÎÏÎÌÎÍÌÍÏÍÏ _2C20;
        public System.Collections.Generic.HashSet`1<VRC.SDKBase.VRC_EventHandler> ÌÍÌÏÌÏÌÏÍÎÏÍÏÌÎÌÏÏÍÍÎÌÏ; // 0x8
        public string[] ÍÍÏÍÍÎÎÎÎÍÎÌÎÎÎÌÏÍÏÏÍÍÍ; // 0x10
        public System.Collections.Generic.HashSet`1<0x665B17A0> ÌÌÍÎÌÎÎÎÎÏÍÏÏÍÏÏÍÎÏÎÍÍÌ; // 0x18
        public System.Collections.Generic.HashSet`1<0x665B17A0> ÎÎÎÎÍÎÎÎÍÎÎÌÌÌÏÏÎÎÎÎÌÍÏ; // 0x20
        public System.Collections.Generic.HashSet`1<0x665B17A0> ÍÌÏÍÍÍÍÌÌÌÍÍÍÌÍÏÎÌÎÏÎÍÏ; // 0x28

        // ── Methods ──
        public void UpdateHandlerState(){} // RVA: 0x7FFD4F256AA0
        public void DoPlay(){} // RVA: 0x7FFD4F256C10
        public void DoResetReplacementSha(){} // RVA: 0x7FFD4F256E20
        public void .cctor(){} // RVA: 0x7FFD4F2572E0
        public void ClearEventHandler(){} // RVA: 0x7FFD4F257C00
        public void FindGameObject(){} // RVA: 0x7FFD4F25A220 | overloaded x2
        public void TryGetEventHandlerValue(){} // RVA: 0x7FFD4F257F10
        public void ReadEventHandlerParticleLifetime(){} // RVA: 0x7FFD4F257FC0
        public void ReadEventHandlerParticleLifetime_553AF242105F(){} // RVA: 0x7FFD4F257FE0
        public void GetUnityEngine(){} // RVA: 0x7FFD4F258370
        public void UnregisterEventHandler(){} // RVA: 0x7FFD4F2583D0
        public void UpdateMaterial(){} // RVA: 0x7FFD4F258530
        public void GetUnityEngine_35CD8A9B1022(){} // RVA: 0x7FFD4F259940
        public void GetUnityEngine_7BBE8629F800(){} // RVA: 0x7FFD4F259990
        public void ApplyEventHandlerTextureOffset(){} // RVA: 0x7FFD4F259A00
        public void set_useGUILayout(){} // RVA: 0x7FFD4F259DE0
        public void TriggerEvent(){} // RVA: 0x7FFD4F25A1C0
        public void GetUnityEngine_E1D24CBFCB38(){} // RVA: 0x7FFD4F25A280
        public void GetEventHandler(){} // RVA: 0x7FFD4F260240 | overloaded x2
        public void get_gameObject(){} // RVA: 0x7FFD4F25B980
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4F25BD20
        public void UnregisterEventHandler_19AA642816EA(){} // RVA: 0x7FFD4F25BE50
        public void Awake_CB0133(){} // RVA: 0x7FFD4F261160 | overloaded x2
        public void GetDescendants(){} // RVA: 0x7FFD4F25C220
        public void Initialize(){} // RVA: 0x7FFD4F25C3E0
        public void UpdateHandlerState_37D7693C836D(){} // RVA: 0x7FFD4F25C8A0
        public void get_gameObject_68344C56B03D(){} // RVA: 0x7FFD4F25CB00
        public void Initialize_079D267F3CDC(){} // RVA: 0x7FFD4F25CBE0
        public void InternalGetHashCode(){} // RVA: 0x7FFD4F25CD50
        public void get_gameObject_4808918C70EA(){} // RVA: 0x7FFD4F25CF80
        public void FindEventHandlerTransform(){} // RVA: 0x7FFD4F25D330
        public void Instantiate(){} // RVA: 0x7FFD4F25D4F0
        public void FindEventHandlerTransform_8C731D3E634D(){} // RVA: 0x7FFD4F25D900
        public void ProcessHandlerTransform(){} // RVA: 0x7FFD4F25DCE0
        public void RegisterEventHandler_699CC97A2C50(){} // RVA: 0x7FFD4F25E3D0
        public void Awake(){} // RVA: 0x7FFD4F25E510
        public void get_gameObject_E02F604EB9F3(){} // RVA: 0x7FFD4F25E6B0
        public void ValidateEventHandler(){} // RVA: 0x7FFD4F25EB80
        public void RegisterEventHandler(){} // RVA: 0x7FFD4F25EF60
        public void ParseStandardFormatOrThrow(){} // RVA: 0x7FFD4F25F030
        public void OnTriggerEnter(){} // RVA: 0x7FFD4F25F090
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void RegisterPlay(){} // RVA: 0x7FFD4F25F410
        public void UnregisterPlay(){} // RVA: 0x7FFD4F25F7F0
        public void UpdatePlay(){} // RVA: 0x7FFD4F260050
        public void set_enabled(){} // RVA: 0x7FFD4F260A70
        public void set_enabled_E32CB0377CCF(){} // RVA: 0x7FFD4F260B00
        public void OnDestroy(){} // RVA: 0x7FFD4F260CD0
        public void ProcessPlay(){} // RVA: 0x7FFD4F260E70
        public void GetGameObjectPath(){} // RVA: 0x7FFD4F2615C0
        public void TryGetEventHandlerValue_68FC345B71DC(){} // RVA: 0x7FFD4F261610
    }

}