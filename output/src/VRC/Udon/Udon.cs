// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon
// Classes: 39
// Methods: 901

namespace VRC.Udon
{
    public class AbstractSerializedUdonProgramAsset : ScriptableObject
    {
        // ── Methods ──
        public void StoreProgram(){} // RVA: 0x8943B0
        public void RetrieveProgram(){} // RVA: 0x87C0A0
        public void GetSerializedProgramSize(){} // RVA: 0x87C0A0
        public void GetNetworkCallingMetadata(){} // RVA: 0x87C540
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x87E350
        public void TryGetEntrypointHashFromName(){} // RVA: 0x87D3C0
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class AbstractUdonBehaviourEventProxy : MonoBehaviour
    {
        public object _eventReceiver;

        // ── Methods ──
        public void get_EventReceiver(){} // RVA: 0xB700F0
        public void set_EventReceiver(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class AbstractUdonBehaviourEventProxy[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AbstractUdonProgramSource : ScriptableObject
    {
        // ── Methods ──
        public void get_SerializedProgramAsset(){} // RVA: 0x87C0A0
        public void RunEditorUpdate(){} // RVA: 0x8943B0
        public void RefreshProgram(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class IUdonTriggerEventConsumer
    {
        // ── Methods ──
        public void get_Priority(){} // RVA: 0x87C130
        public void TryConsumeOnTriggerEnter(){} // RVA: 0x87D3C0
        public void TryConsumeOnTriggerExit(){} // RVA: 0x87D3C0
        public void TryConsumeOnTriggerStay(){} // RVA: 0x87D3C0
    }

    public class IUdonTriggerEventConsumer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class OnAnimatorMoveProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnAnimatorMove(){} // RVA: 0x833DF40
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class OnAudioFilterReadProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnAudioFilterRead(){} // RVA: 0x833DFA0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class OnCollisionStayProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnCollisionStay(){} // RVA: 0x833E180
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class OnRenderObjectProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnRenderObject(){} // RVA: 0x833E1A0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class OnTriggerStayProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnTriggerStay(){} // RVA: 0x833E200
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class OnWillRenderObjectProxy : AbstractUdonBehaviourEventProxy
    {
        // ── Methods ──
        public void OnWillRenderObject(){} // RVA: 0x833E220
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class UdonAlwaysDenyVerifier : MonoBehaviour
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class UdonBehaviour : AbstractUdonBehaviour
    {
        public object publicVariables;
        public object SynchronizePosition;
        public object SynchronizeAnimation;
        public object AllowCollisionOwnershipTransfer;
        public object Reliable;
        public object _syncMethod;
        public object serializedProgramAsset;
        public object _onInit;
        public object _requestSerializationHook;
        public object _disableInteractive;
        public object ReturnVariableName;
        public object _disableEventProcessing;
        public object _componentIndexFixed;
        public object _udonManager;
        public object _program;
        public object _udonVM;
        public object _isReady;
        public object _categoryName;
        public object _hasError;
        public object _hasDoneStart;
        public object _initialized;
        public object _isNetworkingSupported;
        public object _hasInteractiveEvents;
        public object _hasUpdateEvent;
        public object _hasLateUpdateEvent;
        public object _hasFixedUpdateEvent;
        public object _hasPostLateUpdateEvent;
        public object _eventTable;
        public object _symbolNameCache;
        public object _managedUpdateProfilerMarker;
        public object _managedLateUpdateProfilerMarker;
        public object _managedFixedUpdateProfilerMarker;
        public object _postLateUpdateProfilerMarker;
        public object _variableToChangeEvent;
        public object _eventProxies;
        public object serializedPublicVariablesBytesString;
        public object publicVariablesUnityEngineObjects;
        public object publicVariablesSerializationDataFormat;
        public object _preloadUdonProgramProfilerMarker;
        public object _initializeUdonContentProfilerMarker;

        // ── Methods ──
        public void get_SyncMethod(){} // RVA: 0x833E280
        public void set_SyncMethod(){} // RVA: 0x833E2A0
        public void get_HasDoneStart(){} // RVA: 0x1C4D0B0
        public void get_HasError(){} // RVA: 0x1C556E0
        public void get_SyncIsContinuous(){} // RVA: 0x833E610
        public void get_SyncIsManual(){} // RVA: 0x833E640
        public void get_OnInit(){} // RVA: 0x833E670
        public void set_OnInit(){} // RVA: 0x833E6D0
        public void get_RequestSerializationHook(){} // RVA: 0x833E780
        public void set_RequestSerializationHook(){} // RVA: 0x833E7E0
        public void get_DisableInteractive(){} // RVA: 0xE3F480
        public void set_DisableInteractive(){} // RVA: 0x1546550
        public void get_IsNetworkingSupported(){} // RVA: 0x6D98C10
        public void set_IsNetworkingSupported(){} // RVA: 0x833E8A0
        public void get_IsInteractive(){} // RVA: 0x833E910
        public void get_UpdateOrder(){} // RVA: 0x833E950
        public void get_DisableEventProcessing(){} // RVA: 0x5C8BB10
        public void set_DisableEventProcessing(){} // RVA: 0x6A92EB0
        public void get_ProgramId(){} // RVA: 0x833E9B0
        public void get_ProgramSize(){} // RVA: 0x833EAA0
        public void GetNetworkCallingMetadata(){} // RVA: 0x833ECA0
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x833EDB0
        public void TryGetEntrypointHashFromName(){} // RVA: 0x833EF10
        public void get_IsInitialized(){} // RVA: 0x6D98C00
        public void GetComponentIndexFixed(){} // RVA: 0x833F030
        public void LoadProgram(){} // RVA: 0x833F060
        public void RegisterEventProxy(){} // RVA: 0x894290
        public void ProcessEntryPoints(){} // RVA: 0x833F630
        public void DetectExistingProxies(){} // RVA: 0x8340240
        public void ResolveUdonHeapReferences(){} // RVA: 0x8340550
        public void ResolveUdonHeapReference(){} // RVA: 0x8340890
        public void ManagedUpdate(){} // RVA: 0x8340C70
        public void ManagedLateUpdate(){} // RVA: 0x8340E30
        public void ManagedFixedUpdate(){} // RVA: 0x8340F50
        public void PostLateUpdate(){} // RVA: 0x8341070
        public void OnAnimatorIK(){} // RVA: 0x8341190
        public void ProxyOnAnimatorMove(){} // RVA: 0x83412E0
        public void ProxyOnAudioFilterRead(){} // RVA: 0x8341330
        public void OnBecameInvisible(){} // RVA: 0x8341500
        public void OnBecameVisible(){} // RVA: 0x8341550
        public void OnCollisionEnter(){} // RVA: 0x83415A0
        public void OnCollisionEnter2D(){} // RVA: 0x8341810
        public void OnCollisionExit(){} // RVA: 0x8341A10
        public void OnCollisionExit2D(){} // RVA: 0x8341C80
        public void ProxyOnCollisionStay(){} // RVA: 0x8341E80
        public void OnCollisionStay2D(){} // RVA: 0x83420F0
        public void OnDestroy(){} // RVA: 0x83422F0
        public void OnDisable(){} // RVA: 0x8342910
        public void OnDrawGizmos(){} // RVA: 0x8342970
        public void OnDrawGizmosSelected(){} // RVA: 0x83429C0
        public void OnEnable(){} // RVA: 0x8342A10
        public void OnJointBreak(){} // RVA: 0x8342A70
        public void OnJointBreak2D(){} // RVA: 0x8342BF0
        public void OnMouseDown(){} // RVA: 0x8342D10
        public void OnMouseDrag(){} // RVA: 0x8342D60
        public void OnMouseEnter(){} // RVA: 0x8342DB0
        public void OnMouseExit(){} // RVA: 0x8342E00
        public void OnMouseOver(){} // RVA: 0x8342E50
        public void OnMouseUp(){} // RVA: 0x8342EA0
        public void OnMouseUpAsButton(){} // RVA: 0x8342EF0
        public void OnParticleCollision(){} // RVA: 0x8342F40
        public void OnParticleTrigger(){} // RVA: 0x8343110
        public void OnPostRender(){} // RVA: 0x8343160
        public void OnPreCull(){} // RVA: 0x83431B0
        public void OnPreRender(){} // RVA: 0x8343200
        public void OnRenderImage(){} // RVA: 0x8343250
        public void ProxyOnRenderObject(){} // RVA: 0x83434C0
        public void OnTransformChildrenChanged(){} // RVA: 0x8343510
        public void OnTransformParentChanged(){} // RVA: 0x8343560
        public void OnTriggerEnter(){} // RVA: 0x83435B0
        public void OnTriggerEnter2D(){} // RVA: 0x8343930
        public void OnTriggerExit(){} // RVA: 0x8343B30
        public void OnTriggerExit2D(){} // RVA: 0x8343EB0
        public void ProxyOnTriggerStay(){} // RVA: 0x83440B0
        public void OnTriggerStay2D(){} // RVA: 0x8344430
        public void OnControllerColliderHit(){} // RVA: 0x8344630
        public void OnValidate(){} // RVA: 0x8344A70
        public void ProxyOnWillRenderObject(){} // RVA: 0x8344AC0
        public void OnNetworkReady(){} // RVA: 0x5A226F0
        public void Interact(){} // RVA: 0x8344B10
        public void OnDrop(){} // RVA: 0x8344B60
        public void OnPickup(){} // RVA: 0x8344BB0
        public void OnPickupUseDown(){} // RVA: 0x8344C00
        public void OnPickupUseUp(){} // RVA: 0x8344C50
        public void OnPreSerialization(){} // RVA: 0x8344CA0
        public void OnPostSerialization(){} // RVA: 0x8344E30
        public void OnDeserialization(){} // RVA: 0x83450C0
        public void RunProgram(){} // RVA: 0x8345450
        public void GetPrograms(){} // RVA: 0x8345A40
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x8345B00
        public void DeserializePublicVariables(){} // RVA: 0x8345B10
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x8345FA0
        public void SerializePublicVariables(){} // RVA: 0x8345FA0
        public void TryToInterrogateUdon(){} // RVA: 0xA94080
        public void RunEvent(){} // RVA: 0xEEA0B0
        public void RunEventAdvanced(){} // RVA: 0x83463F0
        public void RunInputEvent(){} // RVA: 0x8346730
        public void GetEventParameterName(){} // RVA: 0x83469D0
        public void PreloadUdonProgram(){} // RVA: 0x8346CC0
        public void SearchUdonInterface(){} // RVA: 0xA94080
        public void InitializeUdonContent(){} // RVA: 0x8346F30
        public void RunOnInit(){} // RVA: 0x83477A0
        public void RegisterUpdate(){} // RVA: 0x8347950
        public void UnregisterUpdate(){} // RVA: 0x8347F90
        public void SendCustomEvent(){} // RVA: 0x83484F0
        public void SendCustomNetworkEvent(){} // RVA: 0x8348970
        public void RequestSerialization(){} // RVA: 0x8348A00
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x8348AB0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x8348C30
        public void get_InteractionText(){} // RVA: 0xB70160
        public void set_InteractionText(){} // RVA: 0xB44DC0
        public void get_SyncMetadataTable(){} // RVA: 0x8348DC0
        public void GetProgramVariableType(){} // RVA: 0x8348E20
        public void SetProgramVariable(){} // RVA: 0x8348F30
        public void SetHeapVariable(){} // RVA: 0xA94080
        public void GetProgramVariable(){} // RVA: 0x8349070
        public void TryGetProgramVariable(){} // RVA: 0x83491D0
        public void SetupLogging(){} // RVA: 0x8349400
        public void AssignProgramAndVariables(){} // RVA: 0x8349540
        public void .ctor(){} // RVA: 0x83495F0
        public void .cctor(){} // RVA: 0x8349990
    }

    public class UdonBehaviour[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    /// <summary>Originally: ÏÏÏÌÌÍÍÏÌÎÎÎÎÎÏÎÏÍÎÌÌÎÏ</summary>
    public class UdonClientStringDownloaderSibling_9BAC : Object
    {
        public object _kInstanceID_None;
        public object _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;
        public object _objectIsNullMessage;
        public object _cloneDestroyedMessage;
        public object f_06B;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0xD6C620
        public void Equals(){} // RVA: 0xD6CDB0
        public void GetHashCode(){} // RVA: 0xD6D550
        public void op_Implicit(){} // RVA: 0xD6D690
        public void CompareBaseObjects(){} // RVA: 0xD6D710
        public void .cctor(){} // RVA: 0xD6D850
        public void GetCachedPtr(){} // RVA: 0xD6DC70
        public void .ctor(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0xD6DDB0
        public void Instantiate(){} // RVA: 0xD6E580
        public void Destroy(){} // RVA: 0xD6E7E0
        public void DestroyImmediate(){} // RVA: 0xD6E920
    }

    /// <summary>Originally: ÍÎÌÏÎÎÏÎÍÎÌÍÏÏÍÎÌÏÏÏÎÏÌ</summary>
    public class UdonDisableEventProcessing_6F62 : AbstractUdonBehaviour
    {
        public object f_89F;
        public object f_71F;
        public object f_FBC;
        public object f_489;
        public object f_1C1;
        public object f_913;
        public object _disableEventProcessing;
        public object _syncMethod;
        public object _interactionText;
        public object f_9A5;

        // ── Methods ──
        public void Interact(){} // RVA: 0xB43310
        public void RunEventAdvanced(){} // RVA: 0xEEA6D0
        public void TryGetProgramVariable(){} // RVA: 0xEE9EC0
        public void RequestSerialization(){} // RVA: 0xB43310
        public void RunEvent(){} // RVA: 0xEEA410
        public void RunInputEvent(){} // RVA: 0xEE9940
        public void SendCustomNetworkEvent(){} // RVA: 0xEEA4D0
        public void GetNetworkCallingMetadata(){} // RVA: 0xEEA230
        public void .ctor(){} // RVA: 0xEE9B60
        public void GetComponentIndexFixed(){} // RVA: 0xEE9DA0
        public void GetProgramVariable(){} // RVA: 0xA94080
        public void set_DisableEventProcessing(){} // RVA: 0xEEA000
        public void get_DisableEventProcessing(){} // RVA: 0xEEA010
        public void SendCustomEventDelayedSeconds(){} // RVA: 0xEEA020
        public void set_SyncMethod(){} // RVA: 0xEEA060
        public void SendCustomEventDelayedFrames(){} // RVA: 0xEEA070
        public void SetProgramVariable(){} // RVA: 0xA94080
        public void SendCustomEvent(){} // RVA: 0xEEA1B0
        public void get_InteractionText(){} // RVA: 0xBBF8F0
        public void InitializeUdonContent(){} // RVA: 0xB43310
        public void TryGetEntrypointHashFromName(){} // RVA: 0xEEA2E0
        public void get_DisableInteractive(){} // RVA: 0xC02470
        public void VRC.Udon.Common.Interfaces.IUdonEventReceiver.set_enabled(){} // RVA: 0xC0FFD0
        public void set_IsNetworkingSupported(){} // RVA: 0xEEA470
        public void get_IsNetworkingSupported(){} // RVA: 0xEEA480
        public void set_SyncMetadataTable(){} // RVA: 0xC0FFC0
        public void set_InteractionText(){} // RVA: 0xBBF900
        public void get_SyncMetadataTable(){} // RVA: 0xEEA510
        public void TryGetEntrypointNameFromHash(){} // RVA: 0xEEA550
        public void set_DisableInteractive(){} // RVA: 0xC02480
        public void GetProgramVariableType(){} // RVA: 0xEEA5C0
        public void RunProgram(){} // RVA: 0xEEA650
        public void get_SyncMethod(){} // RVA: 0xE32C80
        // ── 11 unresolved (hash) ──
        public void m_12D(){} // RVA: 0xEE9870
        public void m_A65(){} // RVA: 0xCD4740
        public void m_33E(){} // RVA: 0xEE9980
        public void m_75E(){} // RVA: 0xEE9A90
        public void m_527(){} // RVA: 0xC0FFD0
        // ... 6 more unresolved methods
    }

    public class UdonManager : MonoBehaviour
    {
        public object OnUdonProgramLoaded;
        public object OnUdonReady;
        public object currentlyExecuting;
        public object _hasLoaded;
        public object _instance;
        public object _udonBehaviourUpdateOrderComparer;
        public object _isUdonEnabled;
        public object _isRunningEvent;
        public object _sceneUdonBehaviourDirectories;
        public object _udonBehavioursToRegister;
        public object _udonRunProgramDepth;
        public object _updateUdonBehaviours;
        public object _lateUpdateUdonBehaviours;
        public object _fixedUpdateUdonBehaviours;
        public object _postLateUpdateUdonBehaviours;
        public object _updateUdonBehavioursRegistrationQueue;
        public object _lateUpdateUdonBehavioursRegistrationQueue;
        public object _fixedUpdateUdonBehavioursRegistrationQueue;
        public object _postLateUpdateUdonBehavioursRegistrationQueue;
        public object _postLateUpdater;
        public object _inputUdonBehaviours;
        public object _inputUpdateUdonBehavioursRegistrationQueue;
        public object UDON_EVENT_ONPLAYERRESPAWN;
        public object UDON_EVENT_ONPLAYERDATAUPDATED;
        public object UDON_EVENT_ONPLAYERRESTORED;
        public object UDON_EVENT_ONINSTANCERESTORED;
        public object UDON_EVENT_ONDESERIALIZATION;
        public object UDON_EVENT_ONSCREENUPDATE;
        public object UDON_MAX_RUNPROGRAM_DEPTH;
        public object UDON_EVENT_ONPOSTSERIALIZATION;
        public object UDON_EVENT_ONPRESERIALIZATION;
        public object UDON_EVENT_ONPERSISTENCEUSAGEUPDATED;
        public object UDON_EVENT_ONPLAYERDATASTORAGEEXCEEDED;
        public object UDON_EVENT_ONPLAYERDATASTORAGEWARNING;
        public object UDON_EVENT_ONPLAYEROBJECTSTORAGEEXCEEDED;
        public object UDON_EVENT_ONPLAYEROBJECTSTORAGEWARNING;
        public object UDON_EVENT_ONINSTANCESTORAGEEXCEEDED;
        public object UDON_EVENT_ONINSTANCESTORAGEWARNING;
        public object _inputActionNames;
        public object UDON_INPUT_JUMP;
        public object UDON_INPUT_USE;
        public object UDON_INPUT_GRAB;
        public object UDON_INPUT_DROP;
        public object UDON_MOVE_VERTICAL;
        public object UDON_MOVE_HORIZONTAL;
        public object UDON_LOOK_VERTICAL;
        public object UDON_LOOK_HORIZONTAL;
        public object UDON_EVENT_ONINPUTMETHODCHANGED;
        public object UDON_EVENT_ONLANGUAGECHANGED;
        public object UDON_EVENT_ONVRCPLUSMASSGIFT;
        public object _udonTimeSource;
        public object _blacklist;
        public object _udonClientInterface;
        public object _udonEventScheduler;
        public object _signatureVerificationFailed;
        public object _signatureVerificationSuccess;
        public object _signatureVerificationSkipped;
        public object _worldSignatureVerificationEnabled;
        public object _signatureVerificationKey;
        public object _verificationCache;
        public object _triggerEventConsumers;
        public object _preloadProfilerMarker;
        public object _initializeProfilerMarker;
        public object _isSceneLoading;
        public object UdonBehavioursInScene;

        // ── Methods ──
        public void add_OnUdonProgramLoaded(){} // RVA: 0x8349BA0
        public void remove_OnUdonProgramLoaded(){} // RVA: 0x8349D00
        public void add_OnUdonReady(){} // RVA: 0x8349E60
        public void remove_OnUdonReady(){} // RVA: 0x8349FB0
        public void get_HasLoaded(){} // RVA: 0xF73960
        public void set_HasLoaded(){} // RVA: 0xF73A60
        public void get_Instance(){} // RVA: 0x834A100
        public void get_SignatureVerificationFailed(){} // RVA: 0x12CE7D0
        public void get_SignatureVerificationSuccess(){} // RVA: 0x214AA20
        public void get_SignatureVerificationSkipped(){} // RVA: 0x131DCD0
        public void get_WorldSignatureVerificationEnabled(){} // RVA: 0xD95EC0
        public void set_WorldSignatureVerificationEnabled(){} // RVA: 0x2540E50
        public void ResetWorldSignatureVerification(){} // RVA: 0x834A160
        public void EnableWorldSignatureVerification(){} // RVA: 0x834A1D0
        public void RegisterTriggerEventConsumer(){} // RVA: 0x834A290
        public void UnregisterTriggerEventConsumer(){} // RVA: 0x834A4B0
        public void TryNotifyOnTriggerEnterConsumers(){} // RVA: 0x834A520
        public void TryNotifyOnTriggerExitConsumers(){} // RVA: 0x834A6D0
        public void TryNotifyOnTriggerStayConsumers(){} // RVA: 0x834A880
        public void Awake(){} // RVA: 0x834AA30
        public void Update(){} // RVA: 0x834B390
        public void LateUpdate(){} // RVA: 0x834BA60
        public void FixedUpdate(){} // RVA: 0x834C0B0
        public void PostLateUpdate(){} // RVA: 0x834C700
        public void OnDestroy(){} // RVA: 0x834CE40
        public void GetWrapperModule(){} // RVA: 0x2ABD250
        public void RegisterInput(){} // RVA: 0x834CFB0
        public void RunInputAction(){} // RVA: 0x834D090
        public void UpdateInputQueue(){} // RVA: 0x834D3E0
        public void get_IsSceneLoading(){} // RVA: 0x2443BA0
        public void set_IsSceneLoading(){} // RVA: 0x2443BB0
        public void OnSceneLoaded(){} // RVA: 0x834D7A0
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x834ED30
        public void ProcessUdonProgram(){} // RVA: 0x834EE70
        public void OnSceneUnloaded(){} // RVA: 0x834EEF0
        public void PurgeSerializationCaches(){} // RVA: 0x834EF60
        public void GetTotalLoadedProgramSize(){} // RVA: 0x834F0D0
        public void GetLoadedBehavioursSyncTypes(){} // RVA: 0x834F880
        public void RegisterUdonBehaviourUpdate(){} // RVA: 0x834FE00
        public void RegisterUdonBehaviourLateUpdate(){} // RVA: 0x834FEE0
        public void RegisterUdonBehaviourFixedUpdate(){} // RVA: 0x834FFC0
        public void RegisterUdonBehaviourPostLateUpdate(){} // RVA: 0x83500A0
        public void UnregisterUdonBehaviourUpdate(){} // RVA: 0x83501A0
        public void UnregisterUdonBehaviourLateUpdate(){} // RVA: 0x8350280
        public void UnregisterUdonBehaviourFixedUpdate(){} // RVA: 0x8350360
        public void UnregisterUdonBehaviourPostLateUpdate(){} // RVA: 0x8350440
        public void ScheduleDelayedEvent(){} // RVA: 0x8350610
        public void HandleUdonEventScheduled(){} // RVA: 0x8350700
        public void SetUdonEnabled(){} // RVA: 0x21CBB70
        public void IncrementDepthCount(){} // RVA: 0x8350730
        public void DecrementDepthCount(){} // RVA: 0x8350840
        public void get_DebugLogging(){} // RVA: 0x8350900
        public void set_DebugLogging(){} // RVA: 0x8350950
        public void ConstructUdonVM(){} // RVA: 0x83509C0
        public void ApplyFilter(){} // RVA: 0x8350B20
        public void Blacklist(){} // RVA: 0x8350AA0
        public void CleanBlacklist(){} // RVA: 0x8350B80
        public void IsBlacklisted(){} // RVA: 0xA94080
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x8350C30
        public void get_LightReservedLayerMask(){} // RVA: 0x8350C90
        public void set_LightReservedLayerMask(){} // RVA: 0x8350CF0
        public void GetWrapper(){} // RVA: 0x8350D50
        public void RegisterUdonBehaviour(){} // RVA: 0x8350DA0
        public void UnregisterUdonBehaviour(){} // RVA: 0x8351080
        public void CheckUdonBehavioursToRegister(){} // RVA: 0x8351170
        public void GetUdonBehavioursInScene(){} // RVA: 0x83512A0
        public void RunEvent(){} // RVA: 0x2ABF6F0
        public void .ctor(){} // RVA: 0x8352900
        public void .cctor(){} // RVA: 0x83537E0
        public void <OnSceneLoaded>b__102_0(){} // RVA: 0x83538A0
    }

    /// <summary>Originally: ÍÍÍÎÎÍÏÎÏÌÌÍÏÌÏÌÍÌÍÍÎÏÌ</summary>
    public class UdonOperationResponseStatusChanged_B71F : Udonk__BackingField_1EC0
    {
        public object f_13C;
        public object f_6AA;
        public object f_C7A;
        public object f_A55;
        public object f_4E1;

        // ── Methods ──
        public void OnStatusChanged(){} // RVA: 0x1672950
        public void OnEvent(){} // RVA: 0x16732B0
        public void .ctor(){} // RVA: 0x1673D10
        public void Initialize(){} // RVA: 0x16740B0
        public void OnOperationResponse(){} // RVA: 0x1674BD0
        // ── 11 unresolved (hash) ──
        public void m_626(){} // RVA: 0x16728C0
        public void m_791(){} // RVA: 0x1672940
        public void m_EBD(){} // RVA: 0x1672B00
        public void m_DDF(){} // RVA: 0x1672940
        public void m_DA9(){} // RVA: 0x1672940
        // ... 6 more unresolved methods
    }

    /// <summary>Originally: ÍÎÍÏÍÍÎÌÍÍÌÍÏÏÏÍÌÏÌÎÎÍÍ</summary>
    public class UdonUnregisterEventHandlerRegisterEventHandl_B974 : VRC_EventDispatcher
    {
        public object f_475;
        public object f_065;
        public object f_AC0;
        public object f_337;
        public object f_C99;
        public object f_AC4;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x1C7DB00
        public void FindGameObject(){} // RVA: 0x1C7FB80
        public void OnDestroy(){} // RVA: 0x1C7FBE0
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0x1C81450
        public void GetGameObjectPath(){} // RVA: 0x1C830F0
        public void RegisterEventHandler(){} // RVA: 0x1C83140
        public void UnregisterEventHandler(){} // RVA: 0x1C85980
        public void Awake(){} // RVA: 0x1C86EF0
        public void TriggerEvent(){} // RVA: 0x1C88AB0
        // ── 44 unresolved (hash) ──
        public void m_65C(){} // RVA: 0x1C7D4A0
        public void m_313(){} // RVA: 0x1C7D500
        public void m_BF1(){} // RVA: 0x1C7D520
        public void m_362(){} // RVA: 0x1C7D8D0
        public void m_CD7(){} // RVA: 0x1C7E420
        // ... 39 more unresolved methods
    }

    /// <summary>Originally: ÍÍÌÌÎÍÌÍÎÎÎÎÎÌÏÍÎÏÎÌÍÍÎ</summary>
    public class UdoneventHighlightTransformfollowingCountComponent_A8AD : MonoBehaviour
    {
        public object _m_CancellationTokenSource;
        public object _date;
        public object _followingCount;
        public object _featuredCount;
        public object _groupsCount;
        public object _eventHighlight;
        public object _eventHighlightTransform;
        public object _dateHighlight;
        public object _badge;
        public object _border;
        public object _tooltip;
        public object f_900;
        public object f_BC1;
        public object f_D08;
        public object f_88E;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x9A93870
        public void RaiseCancellation(){} // RVA: 0x9A938E0
        public void IsInvoking(){} // RVA: 0x9A93970
        public void CancelInvoke(){} // RVA: 0x9A93D70
        public void Invoke(){} // RVA: 0x9A93DE0
        public void InvokeRepeating(){} // RVA: 0x9A94100
        public void StartCoroutine(){} // RVA: 0x9A942A0
        public void Start(){} // RVA: 0x9A94D60
        public void StopCoroutine(){} // RVA: 0x9A95010
        public void StopAllCoroutines(){} // RVA: 0x9A950A0
        public void get_useGUILayout(){} // RVA: 0x9A954D0
        public void set_useGUILayout(){} // RVA: 0x9A957F0
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0x9A95860
        public void print(){} // RVA: 0x9A958D0
    }

    /// <summary>Originally: ÎÎÎÌÎÎÏÎÎÏÏÍÏÏÎÎÎÌÎÎÌÍÏ</summary>
    public class UdoneventListBindingeventCellPSibling_D347
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x894320
        // ── Unresolved (hash) ──
        public void m_CF6(){} // RVA: 0x894320
        public void m_99C(){} // RVA: 0x894320
        public void m_DC9(){} // RVA: 0x894320
        public void m_802(){} // RVA: 0x894320
        public void m_92D(){} // RVA: 0x894320
    }

    /// <summary>Originally: ÏÎÏÏÍÍÍÏÍÎÏÍÍÎÏÎÎÌÎÏÍÌÍ</summary>
    public class UdoneventListBindingeventCellPrefabComponent_75B9 : MonoBehaviour
    {
        public object _nameText;
        public object _eventCellPrefab;
        public object _eventListBinding;
        public object f_4AD;
        public object f_E75;
        public object f_BA4;
        public object f_90A;
        public object f_589;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x99CDB60
        public void RaiseCancellation(){} // RVA: 0x99CDE70
        public void IsInvoking(){} // RVA: 0x99CE0F0
        public void CancelInvoke(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0xB43D60
        public void Initialize(){} // RVA: 0x99CE200
        public void StartCoroutine(){} // RVA: 0x99CE310
        public void StartCoroutine_Auto(){} // RVA: 0x99CE590
        public void StopCoroutine(){} // RVA: 0x8004CA0
        public void StopAllCoroutines(){} // RVA: 0x99CE800
        public void get_useGUILayout(){} // RVA: 0x99CEA80
        public void set_useGUILayout(){} // RVA: 0x8004CA0
        public void get_didStart(){} // RVA: 0x99CEB90
        public void get_didAwake(){} // RVA: 0x99CED00
        public void Awake(){} // RVA: 0x99CEE10
        public void OnDestroy(){} // RVA: 0x8004CA0
        public void Internal_IsInvokingAll(){} // RVA: 0x99CF010
        public void InvokeDelayed(){} // RVA: 0x99CF140
        public void IsObjectMonoBehaviour(){} // RVA: 0x99CF250
        public void StartCoroutineManaged(){} // RVA: 0x99CF4E0
        public void StartCoroutineManaged2(){} // RVA: 0x99CF7E0
        public void StopCoroutineManaged(){} // RVA: 0x99CF8F0
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x99CFA00
    }

    /// <summary>Originally: ÍÏÏÏÏÍÍÏÎÍÎÏÌÏÌÌÌÌÏÌÍÌÌ</summary>
    public class UdonfillGraphicminWidthComponent_7ED6 : MonoBehaviour
    {
        public object minWidth;
        public object text;
        public object fill;
        public object fillGraphic;
        public object f_4C7;
        public object f_B5C;
        public object f_4B9;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0xB43310
        public void RaiseCancellation(){} // RVA: 0x11E0310
        public void IsInvoking(){} // RVA: 0x11E0620
        public void CancelInvoke(){} // RVA: 0x11E0710
        public void .cctor(){} // RVA: 0x11E0800
        public void InvokeRepeating(){} // RVA: 0x11E0850
        public void OnDestroy(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x11E08E0
        public void LateUpdate(){} // RVA: 0x11E09E0
        public void StopAllCoroutines(){} // RVA: 0x11E0D00
        public void Start(){} // RVA: 0x11E0D40
        public void set_useGUILayout(){} // RVA: 0x11E0E20
        public void get_didStart(){} // RVA: 0x11E0D00
        public void get_didAwake(){} // RVA: 0xB43310
        public void print(){} // RVA: 0x11E0E70
        public void Internal_CancelInvokeAll(){} // RVA: 0x11E1180
    }

    /// <summary>Originally: ÏÍÌÌÏÍÏÏÌÏÏÍÍÎÍÌÍÏÏÍÌÎÍ</summary>
    public class Udonk__BackingFieldComponent_4F71 : MonoBehaviour
    {
        public object _eventList;
        public object _headerPrefab;
        public object _noEventsPanel;
        public object _noEventsText;
        public object _iconBinding;
        public object _loadingOverlay;
        public object f_5A3;
        public object f_89B;
        public object f_920;
        public object f_D55;
        public object f_B58;
        public object f_5AC;
        public object f_C1B;
        public object f_5A3;
        public object f_AE2;

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x97CB9E0
        public void RaiseCancellation(){} // RVA: 0x97CBAB0
        public void IsInvoking(){} // RVA: 0xCD48B0
        public void Start(){} // RVA: 0x97CBBA0
        public void Invoke(){} // RVA: 0x97CBCA0
        public void InvokeRepeating(){} // RVA: 0xBBFF90
        public void StartCoroutine(){} // RVA: 0x1C556E0
        public void StartCoroutine_Auto(){} // RVA: 0x1165710
        public void StopCoroutine(){} // RVA: 0x97CBCE0
        public void StopAllCoroutines(){} // RVA: 0x97CBDB0
        public void get_useGUILayout(){} // RVA: 0xC10050
        public void set_useGUILayout(){} // RVA: 0x114DE40
        public void get_didStart(){} // RVA: 0x97CBEA0
        public void .ctor(){} // RVA: 0x97CBFA0
        public void Initialize(){} // RVA: 0xB70160
        public void Internal_CancelInvokeAll(){} // RVA: 0xBBFF90
        public void Internal_IsInvokingAll(){} // RVA: 0x97CC0C0
        public void InvokeDelayed(){} // RVA: 0x97CBCA0
        public void IsObjectMonoBehaviour(){} // RVA: 0x97CC1B0
        public void StartCoroutineManaged(){} // RVA: 0x1C4D0B0
        public void StartCoroutineManaged2(){} // RVA: 0x97CC2A0
        public void StopCoroutineManaged(){} // RVA: 0x97CC550
    }

    /// <summary>Originally: ÎÌÎÏÌÏÌÏÌÏÎÍÍÎÏÍÌÎÍÌÌÍÌ</summary>
    public class Udonk__BackingFieldImpl_DA81 : Udonk__BackingField_1EC0
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E22B0
    }

    /// <summary>Originally: ÏÎÌÌÏÏÌÎÌÏÎÏÎÎÏÌÎÏÎÍÏÎÌ</summary>
    public class Udonk__BackingFieldSImpl_3634 : Udonk__BackingFieldSiblingSiblSibling_36BD
    {
        public object f_CF6;
        public object f_23B;
        public object f_473;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17107B0
        public void Initialize(){} // RVA: 0x17107C0
    }

    /// <summary>Originally: ÏÎÎÏÌÌÍÎÎÍÌÍÌÍÏÌÎÎÌÍÌÏÍ</summary>
    public class Udonk__BackingFieldSiblingSiblSibling_36BD : Udonk__BackingFieldSiblingSibling_735C
    {
        public object f_A94;
        public object f_23E;
        public object f_7A2;
        public object f_501;
        public object f_291;
        public object f_2AC;
        public object f_7B2;
        public object f_6D3;
        public object f_6FC;

        // ── Methods ──
        public void ToString(){} // RVA: 0x23E02E0
        public void .ctor(){} // RVA: 0x23E0760
        public void Initialize(){} // RVA: 0x1164780
        // ── 55 unresolved (hash) ──
        public void m_125(){} // RVA: 0x1160510
        public void m_744(){} // RVA: 0x1065D50
        public void m_43F(){} // RVA: 0x23DF270
        public void m_B13(){} // RVA: 0x23DF420
        public void m_D8E(){} // RVA: 0x115DDC0
        // ... 50 more unresolved methods
    }

    /// <summary>Originally: ÏÏÏÎÌÎÌÌÎÏÍÏÎÌÏÎÎÌÍÌÎÍÍ</summary>
    public class Udonk__BackingFieldSiblingSiblSibling_66E0 : Object
    {
        public object _kInstanceID_None;
        public object _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;
        public object _objectIsNullMessage;
        public object _cloneDestroyedMessage;
        public object f_883;
        public object f_53C;
        public object f_DB2;
        public object f_4E3;
        public object f_291;
        public object f_2AC;
        public object f_7B2;
        public object f_6D3;
        public object f_E32;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0xEEA000
        public void Equals(){} // RVA: 0x23E2270
        public void GetHashCode(){} // RVA: 0xC38370
        public void op_Implicit(){} // RVA: 0x23E2280
        public void CompareBaseObjects(){} // RVA: 0xC02480
        public void IsNativeObjectAlive(){} // RVA: 0xC120A0
        public void GetCachedPtr(){} // RVA: 0xEEA010
        public void get_name(){} // RVA: 0x23E2270
        public void set_name(){} // RVA: 0xEEA480
        public void Instantiate(){} // RVA: 0xC120B0
        public void Destroy(){} // RVA: 0xC38360
        public void DestroyImmediate(){} // RVA: 0x1DE3FA0
        public void FindObjectsOfType(){} // RVA: 0xC38360
        public void FindObjectsByType(){} // RVA: 0xEEA000
        public void DontDestroyOnLoad(){} // RVA: 0xDD7A00
        public void get_hideFlags(){} // RVA: 0xEEA470
        public void .ctor(){} // RVA: 0x23E2290
        public void Initialize(){} // RVA: 0xDD5C50
        public void FindFirstObjectByType(){} // RVA: 0xC02470
        public void CheckNullArgument(){} // RVA: 0xEEA010
        public void ToString(){} // RVA: 0x23E22A0
        public void op_Equality(){} // RVA: 0x23E2280
    }

    /// <summary>Originally: ÍÍÏÏÌÍÍÎÍÍÍÏÍÌÎÎÎÎÌÍÎÌÎ</summary>
    public class Udonk__BackingFieldSiblingSiblSibling_8C4D
    {
        // ── Unresolved (hash) ──
        public void m_73D(){} // RVA: 0x87C160
        public void m_3E4(){} // RVA: 0x87C130
        public void m_A6C(){} // RVA: 0x87C130
        public void m_295(){} // RVA: 0x87C0A0
        public void m_620(){} // RVA: 0x87C0A0
        public void m_1FE(){} // RVA: 0x87BF40
        public void m_8EB(){} // RVA: 0x87C0A0
    }

    /// <summary>Originally: ÎÎÏÌÍÌÌÍÏÎÎÎÌÍÎÏÌÍÎÌÎÌÍ</summary>
    public class Udonk__BackingFieldSiblingSiblSibling_9C43 : Object
    {
        public object _kInstanceID_None;
        public object _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;
        public object _objectIsNullMessage;
        public object _cloneDestroyedMessage;
        public object f_03E;
        public object f_09E;
        public object f_257;
        public object f_6E5;
        public object f_812;
        public object f_3C0;
        public object f_6AF;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x24C9820
        public void Equals(){} // RVA: 0x24C01C0
        public void GetHashCode(){} // RVA: 0x24C9C40
        public void op_Implicit(){} // RVA: 0x24C03C0
        public void CompareBaseObjects(){} // RVA: 0x24C0B10
        public void IsNativeObjectAlive(){} // RVA: 0xBC1B30
        public void GetCachedPtr(){} // RVA: 0x24C0BB0
        public void get_name(){} // RVA: 0x24C0D80
        public void set_name(){} // RVA: 0x24C0FE0
        public void Instantiate(){} // RVA: 0x24C1140
        public void Destroy(){} // RVA: 0x24C1E90
        public void DestroyImmediate(){} // RVA: 0x24C2BD0
        public void FindObjectsOfType(){} // RVA: 0x24C2BF0
        public void FindObjectsByType(){} // RVA: 0x24C2C70
        public void DontDestroyOnLoad(){} // RVA: 0x24C2D10
        public void get_hideFlags(){} // RVA: 0x24C0FE0
        public void set_hideFlags(){} // RVA: 0x24C2EC0
        public void FindObjectOfType(){} // RVA: 0xBBF8F0
        public void FindFirstObjectByType(){} // RVA: 0x24C31D0
        public void CheckNullArgument(){} // RVA: 0x24C34A0
        public void ToString(){} // RVA: 0x24C35A0
        public void op_Equality(){} // RVA: 0x24C35F0
        public void op_Inequality(){} // RVA: 0x24C3650
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x24C35F0
        public void Internal_CloneSingle(){} // RVA: 0x24C3D10
        public void Internal_CloneSingleWithParent(){} // RVA: 0x24C3E40
        public void Internal_InstantiateSingle(){} // RVA: 0x24C3E90
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x24C4360
        public void GetName(){} // RVA: 0x24C4440
        public void IsPersistent(){} // RVA: 0x24C50C0
        public void Dispose(){} // RVA: 0x24C5110
        public void Cleanup(){} // RVA: 0x24C56C0
        public void ForceLoadFromInstanceID(){} // RVA: 0x24C56E0
        public void Destroy_Injected(){} // RVA: 0x24C5840
        public void DestroyImmediate_Injected(){} // RVA: 0x24C5C50
        public void DontDestroyOnLoad_Injected(){} // RVA: 0x24C5CD0
        public void .ctor(){} // RVA: 0x24C6060
        public void Initialize(){} // RVA: 0x24C66F0
        public void Internal_CloneSingle_Injected(){} // RVA: 0x24C6BE0
        public void Internal_CloneSingleWithParent_Injected(){} // RVA: 0x24C6C50
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x24C6EB0
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0x24C7450
        public void ToString_Injected(){} // RVA: 0x24C8DB0
        public void GetName_Injected(){} // RVA: 0x24C8EA0
        public void IsPersistent_Injected(){} // RVA: 0x24C9510
        public void SetName_Injected(){} // RVA: 0x24C9640
        public void FindObjectFromInstanceID_Injected(){} // RVA: 0x24C96B0
        public void ForceLoadFromInstanceID_Injected(){} // RVA: 0x204D930
        public void h(){} // RVA: 0x24C9950
        // ── Unresolved (hash) ──
        public void m_549(){} // RVA: 0x24C5700
        public void m_11F(){} // RVA: 0x24C5760
        public void m_AC2(){} // RVA: 0x24C99F0
        public void m_B77(){} // RVA: 0x24C9AD0
        public void m_69B(){} // RVA: 0x24C9BA0
        public void m_03D(){} // RVA: 0x24C35F0
        public void m_85A(){} // RVA: 0x24C9DE0
    }

    /// <summary>Originally: ÏÌÏÍÎÌÌÍÌÌÍÌÎÎÏÌÏÏÎÌÌÎÍ</summary>
    public class Udonk__BackingFieldSiblingSiblSibling_B489 : ValueType
    {
        public object f_983;

        // ── Methods ──
        public void Equals(){} // RVA: 0x29580
        public void InternalEquals(){} // RVA: 0x29580
        public void DefaultEquals(){} // RVA: 0x77E60
        public void GetHashCode(){} // RVA: 0x29580
        public void InternalGetHashCode(){} // RVA: 0x29580
        public void ToString(){} // RVA: 0x77E60
        public void GetHashCodeOfPtr(){} // RVA: 0x77E60
        public void x(){} // RVA: 0x29580
        // ── Unresolved (hash) ──
        public void m_217(){} // RVA: 0x29580
        public void m_8D7(){} // RVA: 0x77E60
    }

    /// <summary>Originally: ÌÎÏÎÍÌÎÍÍÏÎÎÏÌÍÎÏÎÎÌÍÍÌ</summary>
    public class Udonk__BackingFieldSiblingSibling_735C : Object
    {
        public object _kInstanceID_None;
        public object _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;
        public object _objectIsNullMessage;
        public object _cloneDestroyedMessage;
        public object f_26E;
        public object f_21F;
        public object f_E5D;
        public object f_957;
        public object f_150;
        public object f_319;
        public object f_C6D;
        public object f_3DE;

        // ── Methods ──
        public void Equals(){} // RVA: 0x23E0D60
        public void op_Implicit(){} // RVA: 0x12BB640
        public void CompareBaseObjects(){} // RVA: 0xFEAE90
        public void IsNativeObjectAlive(){} // RVA: 0xFEAE90
        public void GetCachedPtr(){} // RVA: 0x12BB630
        public void get_name(){} // RVA: 0x12BB630
        public void set_name(){} // RVA: 0xBC1B30
        public void Instantiate(){} // RVA: 0x23E12F0
        public void Destroy(){} // RVA: 0x23E1610
        public void .ctor(){} // RVA: 0x23E1930
        public void Initialize(){} // RVA: 0xD16660
        public void FindObjectsByType(){} // RVA: 0xFEAE90
        public void DontDestroyOnLoad(){} // RVA: 0xB465B0
        public void get_hideFlags(){} // RVA: 0xD16660
        public void set_hideFlags(){} // RVA: 0x23E1A60
        public void ToString(){} // RVA: 0x23E1F20
        public void FindFirstObjectByType(){} // RVA: 0xFEAE90
        public void GetHashCode(){} // RVA: 0x23E2240
        // ── Unresolved (hash) ──
        public void m_C5A(){} // RVA: 0x23E0E30
        public void m_77F(){} // RVA: 0x12BB640
        public void m_B5E(){} // RVA: 0xD15320
    }

    /// <summary>Originally: ÏÍÍÏÌÏÏÎÌÏÎÎÌÎÏÎÌÍÏÎÎÌÏ</summary>
    public class Udonk__BackingFieldSiblingSibling_D2E8 : ValueType
    {
        public object f_B09;
        public object f_0DB;
        public object f_FBB;
        public object f_198;
        public object f_8D4;
        public object f_9DF;
        public object f_092;

        // ── Methods ──
        public void Equals(){} // RVA: 0x8C7F0
        public void InternalEquals(){} // RVA: 0x8C630
        public void DefaultEquals(){} // RVA: 0x92DD0
        public void GetHashCode(){} // RVA: 0x8C700
        public void InternalGetHashCode(){} // RVA: 0x92DF0
        public void ToString(){} // RVA: 0x8C700
        public void GetHashCodeOfPtr(){} // RVA: 0x93050
        public void x(){} // RVA: 0x92DD0
        // ── 13 unresolved (hash) ──
        public void m_9C1(){} // RVA: 0x93120
        public void m_E90(){} // RVA: 0x8C7E0
        public void m_F55(){} // RVA: 0x77900
        public void m_50E(){} // RVA: 0x8C670
        public void m_935(){} // RVA: 0x93050
        // ... 8 more unresolved methods
    }

    /// <summary>Originally: ÎÍÌÍÌÎÎÏÏÌÌÍÍÌÍÌÎÎÌÍÏÎÎ</summary>
    public class Udonk__BackingFieldSibling_454E : ValueType
    {
        public object f_37A;
        public object f_0DB;
        public object f_FBB;
        public object f_8D4;
        public object f_9DF;
        public object f_5BB;
        public object f_25D;

        // ── Methods ──
        public void Equals(){} // RVA: 0x93050
        public void InternalEquals(){} // RVA: 0x7E450
        public void DefaultEquals(){} // RVA: 0x77D20
        public void GetHashCode(){} // RVA: 0x77CF0
        public void InternalGetHashCode(){} // RVA: 0x93050
        public void ToString(){} // RVA: 0x77900
        public void GetHashCodeOfPtr(){} // RVA: 0x8C630
        public void x(){} // RVA: 0x14790
        // ── 13 unresolved (hash) ──
        public void m_D64(){} // RVA: 0x8C670
        public void m_ECD(){} // RVA: 0x931A0
        public void m_BE8(){} // RVA: 0x7E450
        public void m_0AD(){} // RVA: 0x92DD0
        public void m_A2B(){} // RVA: 0x92DE0
        // ... 8 more unresolved methods
    }

    /// <summary>Originally: ÏÌÏÏÍÍÍÍÍÌÍÍÎÎÍÍÎÏÍÌÏÌÏ</summary>
    public class Udonk__BackingFieldSibling_4E83 : Object
    {
        public object _kInstanceID_None;
        public object _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;
        public object _objectIsNullMessage;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0xB8F8F0
        public void op_Implicit(){} // RVA: 0xBA9BA0
        public void CompareBaseObjects(){} // RVA: 0xB8F8F0
        public void IsNativeObjectAlive(){} // RVA: 0x2624220
        public void GetCachedPtr(){} // RVA: 0xB8F8F0
        public void get_name(){} // RVA: 0xB70160
        public void set_name(){} // RVA: 0xB70100
        public void Instantiate(){} // RVA: 0xB44DC0
        public void Destroy(){} // RVA: 0xB465B0
        public void DestroyImmediate(){} // RVA: 0xBA9BA0
        public void FindObjectsOfType(){} // RVA: 0xB460A0
        public void FindObjectsByType(){} // RVA: 0xB70100
        public void DontDestroyOnLoad(){} // RVA: 0xB700F0
    }

    /// <summary>Originally: ÎÌÌÌÎÎÍÏÎÌÌÍÍÏÍÍÏÏÌÎÏÌÍ</summary>
    public class Udonk__BackingFieldSibling_B262 : Object
    {
        public object _kInstanceID_None;
        public object _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;
        public object _objectIsNullMessage;
        public object _cloneDestroyedMessage;
        public object f_765;
        public object f_5BB;
        public object f_8AB;
        public object f_822;
        public object f_BE8;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0xBBF900
        public void op_Implicit(){} // RVA: 0x21CBB70
        public void CompareBaseObjects(){} // RVA: 0x23A2720
        public void Equals(){} // RVA: 0x23A2960
        public void GetCachedPtr(){} // RVA: 0x14F7430
        public void get_name(){} // RVA: 0x23A2A10
        public void set_name(){} // RVA: 0x23A2A30
        public void Instantiate(){} // RVA: 0x23A2A40
        public void Destroy(){} // RVA: 0xD33E60
        public void DestroyImmediate(){} // RVA: 0x23A2AF0
        public void .ctor(){} // RVA: 0x23A2BB0
        public void Initialize(){} // RVA: 0xD05CA0
        public void DontDestroyOnLoad(){} // RVA: 0x21CBB70
        public void get_hideFlags(){} // RVA: 0x23A2D20
        public void set_hideFlags(){} // RVA: 0xE62D00
        public void FindObjectOfType(){} // RVA: 0x23A3520
        public void FindFirstObjectByType(){} // RVA: 0x23A2E00
        public void CheckNullArgument(){} // RVA: 0xC02470
        public void ToString(){} // RVA: 0x23A2E10
        public void GetHashCode(){} // RVA: 0xE62D00
        public void op_Inequality(){} // RVA: 0xBBF8F0
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x23A2EB0
        public void Internal_CloneSingle(){} // RVA: 0x23A3080
        public void Internal_CloneSingleWithParent(){} // RVA: 0xB5DBF0
        public void Internal_InstantiateSingle(){} // RVA: 0xBBF900
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0xD09D70
        public void GetName(){} // RVA: 0xB44D60
        public void IsPersistent(){} // RVA: 0x23A32D0
        public void SetName(){} // RVA: 0xE62D00
        public void FindObjectFromInstanceID(){} // RVA: 0xB5DBF0
        public void ForceLoadFromInstanceID(){} // RVA: 0xB5DBF0
        // ── Unresolved (hash) ──
        public void m_3C9(){} // RVA: 0x23A26F0
        public void m_D56(){} // RVA: 0xC02480
    }

    /// <summary>Originally: ÍÏÎÍÌÌÌÍÎÏÎÏÍÏÏÏÎÏÍÌÍÎÏ</summary>
    public class Udonk__BackingField_1EC0 : Object
    {
        public object _kInstanceID_None;
        public object _m_CachedPtr;
        public object _offsetOfInstanceIDInCPlusPlusObject;
        public object _objectIsNullMessage;
        public object _cloneDestroyedMessage;
        public object f_D29;
        public object f_0DB;
        public object f_042;
        public object f_44D;
        public object f_C89;
        public object f_DB2;
        public object f_7D2;
        public object f_F9C;
        public object f_368;
        public object f_46B;
        public object f_CC6;
        public object f_967;
        public object f_5F7;
        public object f_821;
        public object f_407;
        public object f_7F7;
        public object f_381;
        public object f_3DE;
        public object f_123;
        public object f_6C0;
        public object f_EBC;
        public object f_E39;
        public object f_14F;
        public object f_219;
        public object f_744;
        public object f_D8C;
        public object f_BA8;
        public object f_F81;
        public object f_A8F;
        public object f_656;
        public object f_233;
        public object f_8E1;
        public object f_AE9;
        public object f_727;
        public object f_5F9;
        public object f_55C;
        public object f_224;
        public object f_89A;
        public object f_D1C;
        public object f_D5F;
        public object f_1A5;
        public object f_2BB;
        public object f_486;
        public object f_734;
        public object f_A89;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x23A40A0
        public void Equals(){} // RVA: 0x23A4120
        public void GetHashCode(){} // RVA: 0x23A4130
        public void op_Implicit(){} // RVA: 0xD33E60
        public void CompareBaseObjects(){} // RVA: 0x2300BB0
        public void IsNativeObjectAlive(){} // RVA: 0xBBFF90
        public void GetCachedPtr(){} // RVA: 0x15B42C0
        public void get_name(){} // RVA: 0x23A4250
        public void set_name(){} // RVA: 0x23A4260
        public void Instantiate(){} // RVA: 0x131DCD0
        public void Destroy(){} // RVA: 0x23A4270
        public void DestroyImmediate(){} // RVA: 0x23A4280
        public void FindObjectsOfType(){} // RVA: 0x23A4340
        public void FindObjectsByType(){} // RVA: 0x23A4510
        public void DontDestroyOnLoad(){} // RVA: 0xB708C0
        public void get_hideFlags(){} // RVA: 0xBC5B30
        public void set_hideFlags(){} // RVA: 0x23A4520
        public void FindObjectOfType(){} // RVA: 0xBC1B30
        public void FindFirstObjectByType(){} // RVA: 0xCD3600
        public void CheckNullArgument(){} // RVA: 0x23A45C0
        public void ToString(){} // RVA: 0x23A46E0
        public void OnOperationResponse(){} // RVA: 0x23A4880
        public void op_Inequality(){} // RVA: 0x23A6360
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x23A6B50
        public void .ctor(){} // RVA: 0x23A6F50
        public void Initialize(){} // RVA: 0x135EDB0
        public void Internal_InstantiateSingle(){} // RVA: 0xB5DBF0
        public void Internal_InstantiateSingleWithParent(){} // RVA: 0x23A8000
        public void OnDisconnectMessage(){} // RVA: 0x23A8020
        public void IsPersistent(){} // RVA: 0x23A8160
        public void SetName(){} // RVA: 0x23A8390
        public void FindObjectFromInstanceID(){} // RVA: 0x23A84B0
        public void ForceLoadFromInstanceID(){} // RVA: 0x23A8650
        public void Destroy_Injected(){} // RVA: 0x23A93C0
        public void DestroyImmediate_Injected(){} // RVA: 0x23A96D0
        public void DontDestroyOnLoad_Injected(){} // RVA: 0x18A0130
        public void get_hideFlags_Injected(){} // RVA: 0x23AC400
        public void set_hideFlags_Injected(){} // RVA: 0x23A9820
        public void Internal_CloneSingle_Injected(){} // RVA: 0x23A9840
        public void Internal_CloneSingleWithParent_Injected(){} // RVA: 0x23A9880
        public void Internal_InstantiateSingle_Injected(){} // RVA: 0x23A9910
        public void Internal_InstantiateSingleWithParent_Injected(){} // RVA: 0xBE2C60
        public void ToString_Injected(){} // RVA: 0x23A99D0
        public void GetName_Injected(){} // RVA: 0x23A9C20
        public void IsPersistent_Injected(){} // RVA: 0x23AA0E0
        public void SetName_Injected(){} // RVA: 0x135A170
        public void FindObjectFromInstanceID_Injected(){} // RVA: 0x23AA200
        public void ForceLoadFromInstanceID_Injected(){} // RVA: 0x23AA460
        public void h(){} // RVA: 0x23AA580
        public void OnEvent(){} // RVA: 0x23AF370
        public void OnStatusChanged(){} // RVA: 0x23B0380
        public void DebugReturn(){} // RVA: 0x23B1F50
        public void OnMessage(){} // RVA: 0x23B3BC0
        // ── 83 unresolved (hash) ──
        public void m_A17(){} // RVA: 0x23AB7A0
        public void m_5D5(){} // RVA: 0x23A9270
        public void m_679(){} // RVA: 0x23B3510
        public void m_A32(){} // RVA: 0x23AA7B0
        public void m_DC1(){} // RVA: 0x23AA980
        // ... 78 more unresolved methods
    }

    /// <summary>Originally: ÎÏÍÌÎÍÎÎÎÎÎÎÏÏÍÏÏÌÏÎÍÍÌ</summary>
    public class Udonk__BackingField_7ED1 : Object
    {
        public object _result;
        public object _udonBehaviour;
        public object _errorCode;
        public object _resultBytes;
        public object _url;
        public object f_A4D;
        public object f_CF0;
        public object f_043;
        public object f_62D;
        public object f_45B;

        // ── Methods ──
        public void set_Result(){} // RVA: 0xB9E090
        public void get_Result(){} // RVA: 0xEE26C0
        public void Equals(){} // RVA: 0xB70100
        public void op_Implicit(){} // RVA: 0xEE2770
        public void CompareBaseObjects(){} // RVA: 0xD09D70
        public void IsNativeObjectAlive(){} // RVA: 0xD09D70
        public void set_UdonBehaviour(){} // RVA: 0xEE27E0
        public void get_UdonBehaviour(){} // RVA: 0xBC1B30
        public void set_name(){} // RVA: 0xB6A8C0
        public void Instantiate(){} // RVA: 0xB44DC0
        public void Destroy(){} // RVA: 0xB44DC0
        public void CancelDownload(){} // RVA: 0xEE2770
        public void StartDownload(){} // RVA: 0xEE2A00
        public void get_ErrorCode(){} // RVA: 0xB9E080
        public void set_ErrorCode(){} // RVA: 0xEE2E00
        public void set_ResultBytes(){} // RVA: 0xEE3020
        public void get_ResultBytes(){} // RVA: 0xB700F0
        public void get_Url(){} // RVA: 0xD05CA0
        public void get_Error(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0xEE34A0
    }

}