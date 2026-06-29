// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Udon
// Classes: 47
// Methods: 792

namespace VRC.Udon
{
    public class UdonAlwaysDenyVerifier : MonoBehaviour
    {
        // ── Methods ──
        public void VerifySignature(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class UdonBehaviour : AbstractUdonBehaviour
    {
        // ── Methods ──
        public void get_SyncMethod(){} // RVA: 0x7AF4DE730
        public void set_SyncMethod(){} // RVA: 0x7AF4DE750
        public void get_HasDoneStart(){} // RVA: 0x7A9101D50
        public void get_HasError(){} // RVA: 0x7A90FA160
        public void get_SyncIsContinuous(){} // RVA: 0x7AF4DEAF0
        public void get_SyncIsManual(){} // RVA: 0x7AF4DEB20
        public void get_OnInit(){} // RVA: 0x7AF4DEB50
        public void set_OnInit(){} // RVA: 0x7AF4DEBB0
        public void get_RequestSerializationHook(){} // RVA: 0x7AF4DEC60
        public void set_RequestSerializationHook(){} // RVA: 0x7AF4DECC0
        public void get_DisableInteractive(){} // RVA: 0x7A8359360
        public void set_DisableInteractive(){} // RVA: 0x7A8A21900
        public void get_IsNetworkingSupported(){} // RVA: 0x7AE117D30
        public void set_IsNetworkingSupported(){} // RVA: 0x7AF4DED80
        public void get_IsInteractive(){} // RVA: 0x7AF4DEDF0
        public void get_UpdateOrder(){} // RVA: 0x7AF4DEE30
        public void get_DisableEventProcessing(){} // RVA: 0x7ACDBE8E0
        public void set_DisableEventProcessing(){} // RVA: 0x7ADE0AE10
        public void get_ProgramId(){} // RVA: 0x7AF4DEE90
        public void get_ProgramSize(){} // RVA: 0x7AF4DEF80
        public void GetNetworkCallingMetadata(){} // RVA: 0x7AF4DF180
        public void TryGetEntrypointNameFromHash(){} // RVA: 0x7AF4DF290
        public void TryGetEntrypointHashFromName(){} // RVA: 0x7AF4DF3F0
        public void get_IsInitialized(){} // RVA: 0x7AE117D20
        public void GetComponentIndexFixed(){} // RVA: 0x7AF4DF510
        public void LoadProgram(){} // RVA: 0x7AF4DF570
        public void RegisterEventProxy(){} // RVA: 0x7AA631DA0
        public void ProcessEntryPoints(){} // RVA: 0x7AF4DFB50
        public void DetectExistingProxies(){} // RVA: 0x7AF4E0760
        public void ResolveUdonHeapReferences(){} // RVA: 0x7AF4E0A70
        public void ResolveUdonHeapReference(){} // RVA: 0x7AF4E0DB0
        public void ManagedUpdate(){} // RVA: 0x7AF4E1180
        public void ManagedLateUpdate(){} // RVA: 0x7AF4E1340
        public void ManagedFixedUpdate(){} // RVA: 0x7AF4E1460
        public void PostLateUpdate(){} // RVA: 0x7AF4E1580
        public void OnAnimatorIK(){} // RVA: 0x7AF4E16A0
        public void ProxyOnAnimatorMove(){} // RVA: 0x7AF4E17F0
        public void ProxyOnAudioFilterRead(){} // RVA: 0x7AF4E1840
        public void OnBecameInvisible(){} // RVA: 0x7AF4E1A10
        public void OnBecameVisible(){} // RVA: 0x7AF4E1A60
        public void OnCollisionEnter(){} // RVA: 0x7AF4E1AB0
        public void OnCollisionEnter2D(){} // RVA: 0x7AF4E1D20
        public void OnCollisionExit(){} // RVA: 0x7AF4E1F20
        public void OnCollisionExit2D(){} // RVA: 0x7AF4E2190
        public void ProxyOnCollisionStay(){} // RVA: 0x7AF4E2390
        public void OnCollisionStay2D(){} // RVA: 0x7AF4E2600
        public void OnDestroy(){} // RVA: 0x7AF4E2800
        public void OnDisable(){} // RVA: 0x7AF4E2E20
        public void OnDrawGizmos(){} // RVA: 0x7AF4E2E80
        public void OnDrawGizmosSelected(){} // RVA: 0x7AF4E2ED0
        public void OnEnable(){} // RVA: 0x7AF4E2F20
        public void OnJointBreak(){} // RVA: 0x7AF4E2F80
        public void OnJointBreak2D(){} // RVA: 0x7AF4E3100
        public void OnMouseDown(){} // RVA: 0x7AF4E3220
        public void OnMouseDrag(){} // RVA: 0x7AF4E3270
        public void OnMouseEnter(){} // RVA: 0x7AF4E32C0
        public void OnMouseExit(){} // RVA: 0x7AF4E3310
        public void OnMouseOver(){} // RVA: 0x7AF4E3360
        public void OnMouseUp(){} // RVA: 0x7AF4E33B0
        public void OnMouseUpAsButton(){} // RVA: 0x7AF4E3400
        public void OnParticleCollision(){} // RVA: 0x7AF4E3450
        public void OnParticleTrigger(){} // RVA: 0x7AF4E3620
        public void OnPostRender(){} // RVA: 0x7AF4E3670
        public void OnPreCull(){} // RVA: 0x7AF4E36C0
        public void OnPreRender(){} // RVA: 0x7AF4E3710
        public void OnRenderImage(){} // RVA: 0x7AF4E3760
        public void ProxyOnRenderObject(){} // RVA: 0x7AF4E39D0
        public void OnTransformChildrenChanged(){} // RVA: 0x7AF4E3A20
        public void OnTransformParentChanged(){} // RVA: 0x7AF4E3A70
        public void OnTriggerEnter(){} // RVA: 0x7AF4E3AC0
        public void OnTriggerEnter2D(){} // RVA: 0x7AF4E3EB0
        public void OnTriggerExit(){} // RVA: 0x7AF4E40B0
        public void OnTriggerExit2D(){} // RVA: 0x7AF4E44A0
        public void ProxyOnTriggerStay(){} // RVA: 0x7AF4E46A0
        public void OnTriggerStay2D(){} // RVA: 0x7AF4E4A90
        public void OnControllerColliderHit(){} // RVA: 0x7AF4E4C90
        public void OnValidate(){} // RVA: 0x7AF4E5130
        public void ProxyOnWillRenderObject(){} // RVA: 0x7AF4E5180
        public void OnNetworkReady(){} // RVA: 0x7ACD0BA60
        public void Interact(){} // RVA: 0x7AF4E51D0
        public void OnDrop(){} // RVA: 0x7AF4E5220
        public void OnPickup(){} // RVA: 0x7AF4E5270
        public void OnPickupUseDown(){} // RVA: 0x7AF4E52C0
        public void OnPickupUseUp(){} // RVA: 0x7AF4E5310
        public void OnPreSerialization(){} // RVA: 0x7AF4E5360
        public void OnPostSerialization(){} // RVA: 0x7AF4E54F0
        public void OnDeserialization(){} // RVA: 0x7AF4E5780
        public void RunProgram(){} // RVA: 0x7AF4E5B10
        public void GetPrograms(){} // RVA: 0x7AF4E6100
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AF4E61C0
        public void DeserializePublicVariables(){} // RVA: 0x7AF4E61D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7AF4E6660
        public void SerializePublicVariables(){} // RVA: 0x7AF4E6660
        public void TryToInterrogateUdon(){} // RVA: 0x7A8051B10
        public void RunEvent(){} // RVA: 0x7AA096C70
        public void RunEventAdvanced(){} // RVA: 0x7AA6321B0
        public void RunInputEvent(){} // RVA: 0x7AF4E6DF0
        public void GetEventParameterName(){} // RVA: 0x7AF4E7090
        public void PreloadUdonProgram(){} // RVA: 0x7AF4E7390
        public void SearchUdonInterface(){} // RVA: 0x7AA6387D0
        public void InitializeUdonContent(){} // RVA: 0x7AF4E7600
        public void RunOnInit(){} // RVA: 0x7AF4E7EB0
        public void RegisterUpdate(){} // RVA: 0x7AF4E8060
        public void UnregisterUpdate(){} // RVA: 0x7AF4E8700
        public void SendCustomEvent(){} // RVA: 0x7AF4E8C30
        public void SendCustomNetworkEvent(){} // RVA: 0x7AF4E90B0
        public void RequestSerialization(){} // RVA: 0x7AF4E9140
        public void SendCustomEventDelayedSeconds(){} // RVA: 0x7AF4E91F0
        public void SendCustomEventDelayedFrames(){} // RVA: 0x7AF4E9370
        public void get_InteractionText(){} // RVA: 0x7A8105330
        public void set_InteractionText(){} // RVA: 0x7A80D8E80
        public void get_SyncMetadataTable(){} // RVA: 0x7AF4E9500
        public void GetProgramVariableType(){} // RVA: 0x7AF4E9560
        public void SetProgramVariable(){} // RVA: 0x7AF4E9670
        public void SetHeapVariable(){} // RVA: 0x7A8051B10
        public void GetProgramVariable(){} // RVA: 0x7AF4E97B0
        public void TryGetProgramVariable(){} // RVA: 0x7AF4E9910
        public void SetupLogging(){} // RVA: 0x7AF4E9B40
        public void AssignProgramAndVariables(){} // RVA: 0x7AF4E9C80
        public void .ctor(){} // RVA: 0x7AF4E9D30
        public void .cctor(){} // RVA: 0x7AF4EA140
    }

    public class UdonBehaviour[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class UdonManager : MonoBehaviour
    {
        // ── Methods ──
        public void add_OnUdonProgramLoaded(){} // RVA: 0x7AF4EA430
        public void remove_OnUdonProgramLoaded(){} // RVA: 0x7AF4EA590
        public void add_OnUdonReady(){} // RVA: 0x7AF4EA6F0
        public void remove_OnUdonReady(){} // RVA: 0x7AF4EA840
        public void get_HasLoaded(){} // RVA: 0x7A84A5BD0
        public void set_HasLoaded(){} // RVA: 0x7A84A5CD0
        public void get_Instance(){} // RVA: 0x7AF4EA990
        public void get_SignatureVerificationFailed(){} // RVA: 0x7A87BD4F0
        public void get_SignatureVerificationSuccess(){} // RVA: 0x7A961A4D0
        public void get_SignatureVerificationSkipped(){} // RVA: 0x7A880E690
        public void get_WorldSignatureVerificationEnabled(){} // RVA: 0x7A9A93FF0
        public void set_WorldSignatureVerificationEnabled(){} // RVA: 0x7A9A94000
        public void ResetWorldSignatureVerification(){} // RVA: 0x7AF4EA9F0
        public void EnableWorldSignatureVerification(){} // RVA: 0x7AF4EAA60
        public void RegisterTriggerEventConsumer(){} // RVA: 0x7AF4EAB20
        public void UnregisterTriggerEventConsumer(){} // RVA: 0x7AF4EAD40
        public void TryNotifyOnTriggerEnterConsumers(){} // RVA: 0x7AF4EADB0
        public void TryNotifyOnTriggerExitConsumers(){} // RVA: 0x7AF4EAF60
        public void TryNotifyOnTriggerStayConsumers(){} // RVA: 0x7AF4EB110
        public void Awake(){} // RVA: 0x7AF4EB2C0
        public void Update(){} // RVA: 0x7AF4EBBD0
        public void LateUpdate(){} // RVA: 0x7AF4EC2A0
        public void FixedUpdate(){} // RVA: 0x7AF4EC8F0
        public void PostLateUpdate(){} // RVA: 0x7AF4ECF40
        public void OnDestroy(){} // RVA: 0x7AF4ED640
        public void GetWrapperModule(){} // RVA: 0x7AA64CB70
        public void RegisterInput(){} // RVA: 0x7AF4ED7B0
        public void RunInputAction(){} // RVA: 0x7AF4ED890
        public void UpdateInputQueue(){} // RVA: 0x7AF4EDBE0
        public void get_IsSceneLoading(){} // RVA: 0x7A8F95140
        public void set_IsSceneLoading(){} // RVA: 0x7A8F94B50
        public void OnSceneLoaded(){} // RVA: 0x7AF4EDFA0
        public void VRC.Udon.Security.IUdonSignatureVerifier.VerifySignature(){} // RVA: 0x7AF4EF540
        public void ProcessUdonProgram(){} // RVA: 0x7AF4EF680
        public void OnSceneUnloaded(){} // RVA: 0x7AF4EF700
        public void PurgeSerializationCaches(){} // RVA: 0x7AF4EF770
        public void GetTotalLoadedProgramSize(){} // RVA: 0x7AF4EF8E0
        public void GetLoadedBehavioursSyncTypes(){} // RVA: 0x7AF4F0090
        public void RegisterUdonBehaviourUpdate(){} // RVA: 0x7AF4F0610
        public void RegisterUdonBehaviourLateUpdate(){} // RVA: 0x7AF4F06F0
        public void RegisterUdonBehaviourFixedUpdate(){} // RVA: 0x7AF4F07D0
        public void RegisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7AF4F08B0
        public void UnregisterUdonBehaviourUpdate(){} // RVA: 0x7AF4F09F0
        public void UnregisterUdonBehaviourLateUpdate(){} // RVA: 0x7AF4F0AD0
        public void UnregisterUdonBehaviourFixedUpdate(){} // RVA: 0x7AF4F0BB0
        public void UnregisterUdonBehaviourPostLateUpdate(){} // RVA: 0x7AF4F0C90
        public void ScheduleDelayedEvent(){} // RVA: 0x7AF4F0E60
        public void HandleUdonEventScheduled(){} // RVA: 0x7AF4F0F50
        public void SetUdonEnabled(){} // RVA: 0x7A96C67C0
        public void IncrementDepthCount(){} // RVA: 0x7AF4F0FD0
        public void DecrementDepthCount(){} // RVA: 0x7AF4F10E0
        public void get_DebugLogging(){} // RVA: 0x7AF4F11A0
        public void set_DebugLogging(){} // RVA: 0x7AF4F11F0
        public void ConstructUdonVM(){} // RVA: 0x7AF4F1260
        public void ApplyFilter(){} // RVA: 0x7AF4F13C0
        public void Blacklist(){} // RVA: 0x7AF4F1340
        public void CleanBlacklist(){} // RVA: 0x7AF4F1420
        public void IsBlacklisted(){} // RVA: 0x7A8051B10
        public void ApplyLightCullingMaskFilter(){} // RVA: 0x7AF4F14D0
        public void get_LightReservedLayerMask(){} // RVA: 0x7AF4F1530
        public void set_LightReservedLayerMask(){} // RVA: 0x7AF4F1590
        public void GetWrapper(){} // RVA: 0x7AF4F15F0
        public void RegisterUdonBehaviour(){} // RVA: 0x7AF4F1640
        public void UnregisterUdonBehaviour(){} // RVA: 0x7AF4F1960
        public void CheckUdonBehavioursToRegister(){} // RVA: 0x7AF4F1AD0
        public void GetUdonBehavioursInScene(){} // RVA: 0x7AF4F1C00
        public void RunEvent(){} // RVA: 0x7AA64F090
        public void .ctor(){} // RVA: 0x7AF4F32E0
        public void .cctor(){} // RVA: 0x7AF4F4230
        public void <OnSceneLoaded>b__102_0(){} // RVA: 0x7AF4F42F0
    }

    /// <summary>Originally: ÎÍÌÏÌÎÌÎÌÎÌÏÏÌÍÌÏÌÌÏÌÏÎ</summary>
    public class UdonOperationResponseDiscRelated_02F9 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F710
        public void InternalEquals(){} // RVA: 0x7A76C4610
        public void DefaultEquals(){} // RVA: 0x7A7637E60
        public void GetHashCode(){} // RVA: 0x7A76C4610
        public void InternalGetHashCode(){} // RVA: 0x7A76C4680
        public void ToString(){} // RVA: 0x7A76C4610
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F710
        // ── Unresolved (hash) ──
        public void m_2A5(){} // RVA: 0x7A7637E60
        public void m_4FF(){} // RVA: 0x7A76C4680
        public void m_D90(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÌÎÎÌÌÍÍÏÎÏÎÍÏÎÎÎÌÌÌÍÌÎÏ</summary>
    public class UdonOperationResponseDiscRelated_0318 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A76134D0
        public void InternalEquals(){} // RVA: 0x7A765F070
        public void DefaultEquals(){} // RVA: 0x7A765F080
        public void GetHashCode(){} // RVA: 0x7A765F070
        public void InternalGetHashCode(){} // RVA: 0x7A765F010
        public void ToString(){} // RVA: 0x7A7664E50
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F080
        // ── Unresolved (hash) ──
        public void m_867(){} // RVA: 0x7A765F070
        public void m_BDA(){} // RVA: 0x7A76A9CA0
        public void m_959(){} // RVA: 0x7A765F080
        public void m_709(){} // RVA: 0x7A765F010
        public void m_114(){} // RVA: 0x7A7664CF0
        public void m_EF8(){} // RVA: 0x7A76A9CF0
        public void m_664(){} // RVA: 0x7A7664E50
        public void m_9C6(){} // RVA: 0x7A7664E50
        public void m_277(){} // RVA: 0x7A765F080
    }

    /// <summary>Originally: ÌÍÏÏÌÏÍÏÎÍÏÏÍÎÎÌÍÍÍÎÏÏÍ</summary>
    public class UdonOperationResponseDiscRelated_05D4 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A76C4610
        public void DefaultEquals(){} // RVA: 0x7A76C4610
        public void GetHashCode(){} // RVA: 0x7A7637E60
        public void InternalGetHashCode(){} // RVA: 0x7A76C4610
        public void ToString(){} // RVA: 0x7A76C4610
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F710
        // ── Unresolved (hash) ──
        public void m_E66(){} // RVA: 0x7A76C4610
        public void m_2A5(){} // RVA: 0x7A7637E60
        public void m_590(){} // RVA: 0x7A76C4680
        public void m_A7E(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÎÎÎÍÌÌÏÌÌÍÏÎÌÍÍÌÍÌÏÍÍÍÍ</summary>
    public class UdonOperationResponseDiscRelated_0CA1 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F070
        public void InternalEquals(){} // RVA: 0x7A76A2FB0
        public void DefaultEquals(){} // RVA: 0x7A765F080
        public void GetHashCode(){} // RVA: 0x7A76134D0
        public void InternalGetHashCode(){} // RVA: 0x7A765F080
        public void ToString(){} // RVA: 0x7A765F070
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76A3000
        // ── Unresolved (hash) ──
        public void m_C94(){} // RVA: 0x7A765F080
        public void m_EF8(){} // RVA: 0x7A76A3050
        public void m_709(){} // RVA: 0x7A765F010
        public void m_277(){} // RVA: 0x7A765F080
        public void m_C9E(){} // RVA: 0x7A76134D0
    }

    /// <summary>Originally: ÍÍÏÎÎÌÎÏÎÏÌÏÌÎÍÏÍÎÎÎÎÌÍ</summary>
    public class UdonOperationResponseDiscRelated_1248 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7690D70
        public void InternalEquals(){} // RVA: 0x7A76ACF20
        public void DefaultEquals(){} // RVA: 0x7A76850B0
        public void GetHashCode(){} // RVA: 0x7A765F080
        public void InternalGetHashCode(){} // RVA: 0x7A7664CF0
        public void ToString(){} // RVA: 0x7A76C7200
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7690D40
        // ── 14 unresolved (hash) ──
        public void m_7E9(){} // RVA: 0x7A7637E60
        public void m_2A5(){} // RVA: 0x7A765F010
        public void m_959(){} // RVA: 0x7A765F710
        public void m_D90(){} // RVA: 0x7A765F080
        public void m_3D1(){} // RVA: 0x7A765F710
        // ... 9 more unresolved methods
    }

    /// <summary>Originally: ÌÏÏÌÍÏÏÎÍÎÎÍÏÍÌÍÍÍÌÌÎÌÎ</summary>
    public class UdonOperationResponseDiscRelated_1DDC : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A768A430
        public void InternalEquals(){} // RVA: 0x7A7664E50
        public void DefaultEquals(){} // RVA: 0x7A7664E50
        public void GetHashCode(){} // RVA: 0x7A765F080
        public void InternalGetHashCode(){} // RVA: 0x7A765F010
        public void ToString(){} // RVA: 0x7A765F070
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F070
        // ── Unresolved (hash) ──
        public void m_354(){} // RVA: 0x7A7664CF0
        public void m_959(){} // RVA: 0x7A765F080
        public void m_45A(){} // RVA: 0x7A768A440
        public void m_1FB(){} // RVA: 0x7A765F080
        public void m_2BD(){} // RVA: 0x7A765F070
        public void m_EF8(){} // RVA: 0x7A76BF6C0
        public void m_783(){} // RVA: 0x7A7664CF0
        public void m_C9E(){} // RVA: 0x7A76134D0
        public void m_132(){} // RVA: 0x7A765F080
        public void m_442(){} // RVA: 0x7A765F010
    }

    /// <summary>Originally: ÎÍÌÏÏÎÍÌÎÏÍÍÏÏÎÎÏÎÌÌÌÏÏ</summary>
    public class UdonOperationResponseDiscRelated_38D0 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A765F010
        public void DefaultEquals(){} // RVA: 0x7A765F710
        public void GetHashCode(){} // RVA: 0x7A76C3EC0
        public void InternalGetHashCode(){} // RVA: 0x7A765F010
        public void ToString(){} // RVA: 0x7A76C3EC0
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76C3EA0
        // ── Unresolved (hash) ──
        public void m_EF1(){} // RVA: 0x7A765F080
        public void m_C50(){} // RVA: 0x7A7637E60
        public void m_105(){} // RVA: 0x7A765F080
        public void m_B86(){} // RVA: 0x7A765F080
    }

    /// <summary>Originally: ÏÎÎÍÌÏÏÌÏÌÎÍÏÎÌÎÍÌÎÍÍÌÏ</summary>
    public class UdonOperationResponseDiscRelated_3F2D : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A765F710
        public void DefaultEquals(){} // RVA: 0x7A76C4680
        public void GetHashCode(){} // RVA: 0x7A76C4680
        public void InternalGetHashCode(){} // RVA: 0x7A765F710
        public void ToString(){} // RVA: 0x7A76C4610
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76C4610
        // ── Unresolved (hash) ──
        public void m_688(){} // RVA: 0x7A76C4680
        public void m_A7E(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÎÍÍÏÌÏÎÌÍÍÏÌÍÎÍÏÎÏÌÏÍÏÌ</summary>
    public class UdonOperationResponseDiscRelated_409E : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F080
        public void InternalEquals(){} // RVA: 0x7A76C3EA0
        public void DefaultEquals(){} // RVA: 0x7A765F010
        public void GetHashCode(){} // RVA: 0x7A7637E60
        public void InternalGetHashCode(){} // RVA: 0x7A76C3EC0
        public void ToString(){} // RVA: 0x7A7637E60
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76C3EA0
        // ── Unresolved (hash) ──
        public void m_342(){} // RVA: 0x7A76C3EA0
        public void m_2A5(){} // RVA: 0x7A7637E60
        public void m_D2F(){} // RVA: 0x7A765F010
        public void m_114(){} // RVA: 0x7A765F710
        public void m_B86(){} // RVA: 0x7A765F080
        public void m_DAF(){} // RVA: 0x7A765F010
    }

    /// <summary>Originally: ÌÌÏÏÍÌÌÏÍÎÏÌÍÍÎÍÎÎÍÌÎÏÎ</summary>
    public class UdonOperationResponseDiscRelated_5174 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A76850C0
        public void InternalEquals(){} // RVA: 0x7A767FF40
        public void DefaultEquals(){} // RVA: 0x7A7637E60
        public void GetHashCode(){} // RVA: 0x7A76779C0
        public void InternalGetHashCode(){} // RVA: 0x7A765F080
        public void ToString(){} // RVA: 0x7A76779C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76850B0
        // ── 14 unresolved (hash) ──
        public void m_3D1(){} // RVA: 0x7A765F710
        public void m_D85(){} // RVA: 0x7A7677A20
        public void m_959(){} // RVA: 0x7A765F710
        public void m_2A5(){} // RVA: 0x7A7664E50
        public void m_A7E(){} // RVA: 0x7A7664CF0
        // ... 9 more unresolved methods
    }

    /// <summary>Originally: ÌÏÏÎÍÍÎÏÌÎÎÍÏÌÎÏÎÌÎÍÍÏÏ</summary>
    public class UdonOperationResponseDiscRelated_53C5 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F010
        public void InternalEquals(){} // RVA: 0x7A765F010
        public void DefaultEquals(){} // RVA: 0x7A76C3EA0
        public void GetHashCode(){} // RVA: 0x7A765F080
        public void InternalGetHashCode(){} // RVA: 0x7A7637E60
        public void ToString(){} // RVA: 0x7A76C3EA0
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F710
        // ── Unresolved (hash) ──
        public void m_D2F(){} // RVA: 0x7A765F010
        public void m_24C(){} // RVA: 0x7A765F010
        public void m_2E4(){} // RVA: 0x7A76C3EC0
        public void m_C4A(){} // RVA: 0x7A76C3EC0
        public void m_6D1(){} // RVA: 0x7A76C3EC0
    }

    /// <summary>Originally: ÎÍÏÏÍÌÎÏÍÏÎÌÎÏÎÍÍÍÍÌÎÎÍ</summary>
    public class UdonOperationResponseDiscRelated_715C : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A76ACF20
        public void InternalEquals(){} // RVA: 0x7A7664CF0
        public void DefaultEquals(){} // RVA: 0x7A765F710
        public void GetHashCode(){} // RVA: 0x7A76850B0
        public void InternalGetHashCode(){} // RVA: 0x7A7664E50
        public void ToString(){} // RVA: 0x7A765F710
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76850B0
        // ── 13 unresolved (hash) ──
        public void m_B80(){} // RVA: 0x7A765F710
        public void m_2A5(){} // RVA: 0x7A765F010
        public void m_709(){} // RVA: 0x7A7637E60
        public void m_E3B(){} // RVA: 0x7A7690D70
        public void m_688(){} // RVA: 0x7A76ACF20
        // ... 8 more unresolved methods
    }

    /// <summary>Originally: ÎÍÌÌÍÍÎÌÍÏÎÎÌÏÏÍÎÏÎÍÎÍÏ</summary>
    public class UdonOperationResponseDiscRelated_974D : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7664E50
        public void InternalEquals(){} // RVA: 0x7A76850B0
        public void DefaultEquals(){} // RVA: 0x7A7664CF0
        public void GetHashCode(){} // RVA: 0x7A765F710
        public void InternalGetHashCode(){} // RVA: 0x7A765F710
        public void ToString(){} // RVA: 0x7A765F710
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76850B0
        // ── Unresolved (hash) ──
        public void m_783(){} // RVA: 0x7A765F080
        public void m_980(){} // RVA: 0x7A7637E60
        public void m_709(){} // RVA: 0x7A7637E60
        public void m_EF8(){} // RVA: 0x7A76850B0
        public void m_C91(){} // RVA: 0x7A76850B0
        public void m_D6C(){} // RVA: 0x7A765F010
    }

    /// <summary>Originally: ÌÌÌÎÏÌÎÌÏÎÎÍÏÌÏÌÌÌÎÎÌÎÌ</summary>
    public class UdonOperationResponseDiscRelated_B87B : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A76C4610
        public void DefaultEquals(){} // RVA: 0x7A76C4610
        public void GetHashCode(){} // RVA: 0x7A76C4610
        public void InternalGetHashCode(){} // RVA: 0x7A76C4680
        public void ToString(){} // RVA: 0x7A765F710
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F710
        // ── Unresolved (hash) ──
        public void m_C4A(){} // RVA: 0x7A76C4610
        public void m_921(){} // RVA: 0x7A76C4610
        public void m_2A5(){} // RVA: 0x7A7637E60
    }

    /// <summary>Originally: ÎÏÏÏÍÎÏÌÏÌÍÎÎÍÏÌÏÍÌÎÏÎÌ</summary>
    public class UdonOperationResponseDiscRelated_D3A5 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F710
        public void InternalEquals(){} // RVA: 0x7A7637E60
        public void DefaultEquals(){} // RVA: 0x7A765F710
        public void GetHashCode(){} // RVA: 0x7A7637E60
        public void InternalGetHashCode(){} // RVA: 0x7A7637E60
        public void ToString(){} // RVA: 0x7A7637E60
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7637E60
        // ── Unresolved (hash) ──
        public void m_63A(){} // RVA: 0x7A7637E60
        public void m_644(){} // RVA: 0x7A7637E60
        public void m_99B(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÍÍÎÌÏÍÌÌÍÍÎÏÌÏÎÎÏÍÎÍÍÎÍ</summary>
    public class UdonOperationResponseDiscRelated_D9D2 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F010
        public void InternalEquals(){} // RVA: 0x7A769BDE0
        public void DefaultEquals(){} // RVA: 0x7A765F070
        public void GetHashCode(){} // RVA: 0x7A765F080
        public void InternalGetHashCode(){} // RVA: 0x7A76134D0
        public void ToString(){} // RVA: 0x7A769BE30
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F080
        // ── Unresolved (hash) ──
        public void m_867(){} // RVA: 0x7A765F070
        public void m_CF1(){} // RVA: 0x7A765F080
        public void m_2A5(){} // RVA: 0x7A7664E50
        public void m_959(){} // RVA: 0x7A765F080
        public void m_114(){} // RVA: 0x7A7664CF0
        public void m_237(){} // RVA: 0x7A7664E50
        public void m_493(){} // RVA: 0x7A7664CF0
        public void m_03D(){} // RVA: 0x7A767FF60
        public void m_A4D(){} // RVA: 0x7A767FF40
        public void m_B92(){} // RVA: 0x7A767FF40
    }

    /// <summary>Originally: ÏÎÍÎÏÏÏÏÍÎÌÏÌÌÎÍÍÎÎÏÎÏÌ</summary>
    public class UdonOperationResponseDiscRelated_DB2A : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7664CF0
        public void InternalEquals(){} // RVA: 0x7A76850B0
        public void DefaultEquals(){} // RVA: 0x7A765F710
        public void GetHashCode(){} // RVA: 0x7A76850B0
        public void InternalGetHashCode(){} // RVA: 0x7A7664E50
        public void ToString(){} // RVA: 0x7A765F710
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F010
        // ── Unresolved (hash) ──
        public void m_114(){} // RVA: 0x7A765F080
        public void m_C4A(){} // RVA: 0x7A76C7200
        public void m_959(){} // RVA: 0x7A765F710
        public void m_331(){} // RVA: 0x7A765F710
        public void m_2A5(){} // RVA: 0x7A765F010
        public void m_709(){} // RVA: 0x7A7637E60
        public void m_B22(){} // RVA: 0x7A7664CF0
        public void m_F7B(){} // RVA: 0x7A76ACF20
        public void m_590(){} // RVA: 0x7A76ACF20
        public void m_174(){} // RVA: 0x7A7664CF0
    }

    /// <summary>Originally: ÌÎÌÌÍÎÎÎÏÍÌÌÎÎÌÌÏÎÍÍÌÏÎ</summary>
    public class UdonOperationResponseDiscRelated_DB86 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7664E50
        public void InternalEquals(){} // RVA: 0x7A766E1F0
        public void DefaultEquals(){} // RVA: 0x7A76ACF20
        public void GetHashCode(){} // RVA: 0x7A7664CF0
        public void InternalGetHashCode(){} // RVA: 0x7A76134D0
        public void ToString(){} // RVA: 0x7A768E520
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76AD770
        // ── 15 unresolved (hash) ──
        public void m_867(){} // RVA: 0x7A765F070
        public void m_9C1(){} // RVA: 0x7A76AD780
        public void m_A35(){} // RVA: 0x7A76AD790
        public void m_8D1(){} // RVA: 0x7A76AD780
        public void m_3D1(){} // RVA: 0x7A765F080
        // ... 10 more unresolved methods
    }

    /// <summary>Originally: ÏÍÎÏÎÌÍÎÍÍÌÎÎÏÌÍÍÍÍÎÎÎÏ</summary>
    public class UdonOperationResponseDiscRelated_E1D4 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F010
        public void InternalEquals(){} // RVA: 0x7A7664CF0
        public void DefaultEquals(){} // RVA: 0x7A7637E60
        public void GetHashCode(){} // RVA: 0x7A765F080
        public void InternalGetHashCode(){} // RVA: 0x7A76C7200
        public void ToString(){} // RVA: 0x7A7664CF0
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76ACF20
        // ── Unresolved (hash) ──
        public void m_3BE(){} // RVA: 0x7A7664CF0
        public void m_114(){} // RVA: 0x7A765F080
        public void m_EF8(){} // RVA: 0x7A76850B0
        public void m_7CD(){} // RVA: 0x7A7664E50
        public void m_959(){} // RVA: 0x7A765F710
        public void m_3D1(){} // RVA: 0x7A765F710
        public void m_364(){} // RVA: 0x7A765F010
        public void m_24C(){} // RVA: 0x7A7664E50
        public void m_709(){} // RVA: 0x7A7637E60
    }

    /// <summary>Originally: ÏÏÏÎÍÎÏÍÌÏÎÍÍÍÏÍÌÍÎÎÌÎÍ</summary>
    public class UdonOperationResponseDiscRelated_E23C : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A76850B0
        public void InternalEquals(){} // RVA: 0x7A7664CF0
        public void DefaultEquals(){} // RVA: 0x7A7664CF0
        public void GetHashCode(){} // RVA: 0x7A7637E60
        public void InternalGetHashCode(){} // RVA: 0x7A765F710
        public void ToString(){} // RVA: 0x7A765F710
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F080
        // ── 11 unresolved (hash) ──
        public void m_D6C(){} // RVA: 0x7A765F010
        public void m_CA4(){} // RVA: 0x7A7664E50
        public void m_D28(){} // RVA: 0x7A76A6CB0
        public void m_A6D(){} // RVA: 0x7A7664CF0
        public void m_648(){} // RVA: 0x7A76A6CB0
        // ... 6 more unresolved methods
    }

    /// <summary>Originally: ÏÎÌÍÏÍÎÍÌÍÏÏÎÏÌÌÌÏÏÍÍÌÏ</summary>
    public class UdonOperationResponseDiscRelated_FA23 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7664CF0
        public void InternalEquals(){} // RVA: 0x7A7664E50
        public void DefaultEquals(){} // RVA: 0x7A769CD60
        public void GetHashCode(){} // RVA: 0x7A76134D0
        public void InternalGetHashCode(){} // RVA: 0x7A7664CF0
        public void ToString(){} // RVA: 0x7A767FF40
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7664E50
        // ── Unresolved (hash) ──
        public void m_C9E(){} // RVA: 0x7A76134D0
        public void m_EF8(){} // RVA: 0x7A769CDB0
        public void m_114(){} // RVA: 0x7A7664CF0
        public void m_243(){} // RVA: 0x7A767FF60
        public void m_867(){} // RVA: 0x7A765F070
        public void m_A7E(){} // RVA: 0x7A7664CF0
        public void m_C4B(){} // RVA: 0x7A7664CF0
        public void m_3D1(){} // RVA: 0x7A765F080
        public void m_709(){} // RVA: 0x7A765F010
        public void m_959(){} // RVA: 0x7A765F080
    }

    /// <summary>Originally: ÏÏÏÎÏÍÌÎÍÌÌÎÎÏÍÍÍÌÌÌÎÌÍ</summary>
    public class UdonOperationResponseDisconnecSibling_069A : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A765F080
        public void DefaultEquals(){} // RVA: 0x7A765F710
        public void GetHashCode(){} // RVA: 0x7A765F710
        public void InternalGetHashCode(){} // RVA: 0x7A765F010
        public void ToString(){} // RVA: 0x7A765F710
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7637E60
        // ── Unresolved (hash) ──
        public void m_D9F(){} // RVA: 0x7A765F010
        public void m_886(){} // RVA: 0x7A7637E60
        public void m_60A(){} // RVA: 0x7A765F080
    }

    /// <summary>Originally: ÏÏÍÏÌÎÌÏÏÍÏÎÎÌÎÏÎÏÎÎÌÏÌ</summary>
    public class UdonOperationResponseDisconnecSibling_20F6 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F080
        public void InternalEquals(){} // RVA: 0x7A765F010
        public void DefaultEquals(){} // RVA: 0x7A7637E60
        public void GetHashCode(){} // RVA: 0x7A7637E60
        public void InternalGetHashCode(){} // RVA: 0x7A7637E60
        public void ToString(){} // RVA: 0x7A7637E60
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F010
        // ── Unresolved (hash) ──
        public void m_4D6(){} // RVA: 0x7A765F710
        public void m_114(){} // RVA: 0x7A765F710
        public void m_6FD(){} // RVA: 0x7A765F010
        public void m_3B6(){} // RVA: 0x7A765F080
        public void m_B29(){} // RVA: 0x7A765F010
    }

    /// <summary>Originally: ÎÍÎÎÏÌÍÌÌÎÎÍÎÏÏÏÏÌÎÍÌÍÏ</summary>
    public class UdonOperationResponseDisconnecSibling_340E : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F710
        public void InternalEquals(){} // RVA: 0x7A765F710
        public void DefaultEquals(){} // RVA: 0x7A765F080
        public void GetHashCode(){} // RVA: 0x7A765F010
        public void InternalGetHashCode(){} // RVA: 0x7A765F710
        public void ToString(){} // RVA: 0x7A7637E60
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7637E60
        // ── Unresolved (hash) ──
        public void m_BAD(){} // RVA: 0x7A765F080
        public void m_664(){} // RVA: 0x7A7637E60
        public void m_A7E(){} // RVA: 0x7A765F710
        public void m_493(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÍÏÏÍÎÏÏÎÌÏÎÎÎÌÌÌÍÌÏÏÌÌÏ</summary>
    public class UdonOperationResponseDisconnecSibling_3CCB : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A76C86C0
        public void DefaultEquals(){} // RVA: 0x7A76C3EA0
        public void GetHashCode(){} // RVA: 0x7A7637E60
        public void InternalGetHashCode(){} // RVA: 0x7A765F010
        public void ToString(){} // RVA: 0x7A76C86D0
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F080
        // ── 15 unresolved (hash) ──
        public void m_DF7(){} // RVA: 0x7A76C86E0
        public void m_BC4(){} // RVA: 0x7A76C86F0
        public void m_C57(){} // RVA: 0x7A76C8700
        public void m_114(){} // RVA: 0x7A765F710
        public void m_B84(){} // RVA: 0x7A76C8710
        // ... 10 more unresolved methods
    }

    /// <summary>Originally: ÍÍÏÏÍÌÏÍÎÍÏÍÍÎÌÌÏÍÏÍÎÎÎ</summary>
    public class UdonOperationResponseDisconnecSibling_3F51 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A765F710
        public void DefaultEquals(){} // RVA: 0x7A765F710
        public void GetHashCode(){} // RVA: 0x7A765F710
        public void InternalGetHashCode(){} // RVA: 0x7A7637E60
        public void ToString(){} // RVA: 0x7A7637E60
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F710
        // ── Unresolved (hash) ──
        public void m_114(){} // RVA: 0x7A765F710
        public void m_886(){} // RVA: 0x7A7637E60
        public void m_493(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÍÍÏÏÏÎÎÌÍÌÍÍÍÌÌÏÎÎÍÏÎÏÌ</summary>
    public class UdonOperationResponseDisconnecSibling_40DA
    {
        // ── Unresolved (hash) ──
        public void m_1E3(){} // RVA: 0x7A7E00740
        public void m_8C0(){} // RVA: 0x7A7E00710
        public void m_79C(){} // RVA: 0x7A7E00710
        public void m_EB7(){} // RVA: 0x7A7E00680
        public void m_E80(){} // RVA: 0x7A7E00680
        public void m_D83(){} // RVA: 0x7A7E00520
        public void m_333(){} // RVA: 0x7A7E00680
    }

    /// <summary>Originally: ÌÎÎÎÎÎÏÍÍÏÎÌÎÏÍÏÌÏÎÌÌÎÍ</summary>
    public class UdonOperationResponseDisconnecSibling_479A : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7677A20
        public void InternalEquals(){} // RVA: 0x7A767FF40
        public void DefaultEquals(){} // RVA: 0x7A7677A70
        public void GetHashCode(){} // RVA: 0x7A767FBE0
        public void InternalGetHashCode(){} // RVA: 0x7A767FEF0
        public void ToString(){} // RVA: 0x7A7677B10
        public void GetHashCodeOfPtr(){} // RVA: 0x7A767FEF0
        // ── 15 unresolved (hash) ──
        public void m_843(){} // RVA: 0x7A7677A80
        public void m_7EA(){} // RVA: 0x7A767FBE0
        public void m_C6F(){} // RVA: 0x7A75FEFA0
        public void m_365(){} // RVA: 0x7A767FBE0
        public void m_D57(){} // RVA: 0x7A767FF60
        // ... 10 more unresolved methods
    }

    /// <summary>Originally: ÎÌÌÏÌÍÎÍÎÏÍÎÍÎÌÏÌÏÎÍÏÍÎ</summary>
    public class UdonOperationResponseDisconnecSibling_4D58 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7664CF0
        public void InternalEquals(){} // RVA: 0x7A7677A80
        public void DefaultEquals(){} // RVA: 0x7A75FEFA0
        public void GetHashCode(){} // RVA: 0x7A765F710
        public void InternalGetHashCode(){} // RVA: 0x7A767FBE0
        public void ToString(){} // RVA: 0x7A767FBE0
        public void GetHashCodeOfPtr(){} // RVA: 0x7A75FEFA0
        // ── 15 unresolved (hash) ──
        public void m_FA6(){} // RVA: 0x7A767FBD0
        public void m_D57(){} // RVA: 0x7A7664E50
        public void m_783(){} // RVA: 0x7A7677A70
        public void m_9F6(){} // RVA: 0x7A765EE70
        public void m_BEC(){} // RVA: 0x7A765EDE0
        // ... 10 more unresolved methods
    }

    /// <summary>Originally: ÏÌÌÌÎÏÎÏÍÍÌÍÌÎÍÌÎÍÍÌÏÏÌ</summary>
    public class UdonOperationResponseDisconnecSibling_56D5 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A765F710
        public void DefaultEquals(){} // RVA: 0x7A7637E60
        public void GetHashCode(){} // RVA: 0x7A765F710
        public void InternalGetHashCode(){} // RVA: 0x7A765F710
        public void ToString(){} // RVA: 0x7A7637E60
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F710
        // ── Unresolved (hash) ──
        public void m_539(){} // RVA: 0x7A765F710
        public void m_354(){} // RVA: 0x7A765F710
        public void m_783(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÎÏÎÌÍÍÏÏÌÏÏÍÏÏÎÍÌÌÌÍÏÌÏ</summary>
    public class UdonOperationResponseDisconnecSibling_637B : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F080
        public void InternalEquals(){} // RVA: 0x7A765F710
        public void DefaultEquals(){} // RVA: 0x7A7637E60
        public void GetHashCode(){} // RVA: 0x7A765F010
        public void InternalGetHashCode(){} // RVA: 0x7A765F080
        public void ToString(){} // RVA: 0x7A765F080
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F710
        // ── Unresolved (hash) ──
        public void m_493(){} // RVA: 0x7A765F710
        public void m_2A5(){} // RVA: 0x7A7637E60
        public void m_C83(){} // RVA: 0x7A765F710
        public void m_111(){} // RVA: 0x7A765F010
    }

    /// <summary>Originally: ÎÍÍÏÏÌÏÏÍÏÏÎÏÎÍÎÏÍÎÏÍÏÎ</summary>
    public class UdonOperationResponseDisconnecSibling_66F8 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A7637E60
        public void DefaultEquals(){} // RVA: 0x7A767FBC0
        public void GetHashCode(){} // RVA: 0x7A767FBC0
        public void InternalGetHashCode(){} // RVA: 0x7A75FEFA0
        public void ToString(){} // RVA: 0x7A7637E60
        public void GetHashCodeOfPtr(){} // RVA: 0x7A75FEFA0
        // ── Unresolved (hash) ──
        public void m_D0D(){} // RVA: 0x7A7637E60
        public void m_F03(){} // RVA: 0x7A75FEFA0
        public void m_783(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÌÎÌÎÏÎÎÏÎÎÏÌÏÌÍÍÌÍÍÏÍÍÍ</summary>
    public class UdonOperationResponseDisconnecSibling_7369 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A76134D0
        public void InternalEquals(){} // RVA: 0x7A765F070
        public void DefaultEquals(){} // RVA: 0x7A765F070
        public void GetHashCode(){} // RVA: 0x7A76134D0
        public void InternalGetHashCode(){} // RVA: 0x7A765F070
        public void ToString(){} // RVA: 0x7A765F070
        public void GetHashCodeOfPtr(){} // RVA: 0x7A765F070
        // ── Unresolved (hash) ──
        public void m_226(){} // RVA: 0x7A76134D0
        public void m_80E(){} // RVA: 0x7A765F070
        public void m_059(){} // RVA: 0x7A765F070
    }

    /// <summary>Originally: ÌÌÏÎÏÍÌÍÍÍÍÎÌÍÎÎÍÍÏÏÏÏÍ</summary>
    public class UdonOperationResponseDisconnecSibling_8565 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A75FEFA0
        public void InternalEquals(){} // RVA: 0x7A7664CF0
        public void DefaultEquals(){} // RVA: 0x7A7637E60
        public void GetHashCode(){} // RVA: 0x7A767FBC0
        public void InternalGetHashCode(){} // RVA: 0x7A767FBC0
        public void ToString(){} // RVA: 0x7A7637E60
        public void GetHashCodeOfPtr(){} // RVA: 0x7A767FBC0
        // ── Unresolved (hash) ──
        public void m_963(){} // RVA: 0x7A75FEFA0
        public void m_2A5(){} // RVA: 0x7A7637E60
        public void m_050(){} // RVA: 0x7A7664CF0
        public void m_114(){} // RVA: 0x7A765F710
        public void m_DA7(){} // RVA: 0x7A7664E50
        public void m_3F9(){} // RVA: 0x7A75FEFA0
    }

    /// <summary>Originally: ÏÍÎÌÏÍÌÌÍÍÏÌÏÎÎÎÍÎÎÎÍÎÌ</summary>
    public class UdonOperationResponseDisconnecSibling_86BD : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A765F010
        public void DefaultEquals(){} // RVA: 0x7A765F080
        public void GetHashCode(){} // RVA: 0x7A7637E60
        public void InternalGetHashCode(){} // RVA: 0x7A765F710
        public void ToString(){} // RVA: 0x7A765F080
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7637E60
        // ── Unresolved (hash) ──
        public void m_328(){} // RVA: 0x7A765F010
        public void m_D6C(){} // RVA: 0x7A7637E60
        public void m_354(){} // RVA: 0x7A765F710
        public void m_783(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÏÎÍÎÍÏÎÌÍÍÏÎÏÏÏÎÌÏÏÏÍÏÏ</summary>
    public class UdonOperationResponseDisconnecSibling_ACA7 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F710
        public void InternalEquals(){} // RVA: 0x7A7637E60
        public void DefaultEquals(){} // RVA: 0x7A765F710
        public void GetHashCode(){} // RVA: 0x7A765F710
        public void InternalGetHashCode(){} // RVA: 0x7A765F710
        public void ToString(){} // RVA: 0x7A765F710
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7637E60
        // ── Unresolved (hash) ──
        public void m_13A(){} // RVA: 0x7A765F710
        public void m_49B(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÍÏÌÍÍÎÌÍÌÏÎÎÌÎÍÌÎÍÌÎÍÏÎ</summary>
    public class UdonOperationResponseDisconnecSibling_AD15 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A765F080
        public void DefaultEquals(){} // RVA: 0x7A7637E60
        public void GetHashCode(){} // RVA: 0x7A765F010
        public void InternalGetHashCode(){} // RVA: 0x7A765F080
        public void ToString(){} // RVA: 0x7A765F010
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7637E60
        // ── Unresolved (hash) ──
        public void m_B4B(){} // RVA: 0x7A765F080
        public void m_114(){} // RVA: 0x7A765F710
        public void m_9C6(){} // RVA: 0x7A7637E60
    }

    /// <summary>Originally: ÍÎÌÌÏÍÌÌÏÍÎÌÎÎÍÎÎÎÎÏÏÍÍ</summary>
    public class UdonOperationResponseDisconnecSibling_AE76 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A765F710
        public void DefaultEquals(){} // RVA: 0x7A76C4680
        public void GetHashCode(){} // RVA: 0x7A76C4610
        public void InternalGetHashCode(){} // RVA: 0x7A765F710
        public void ToString(){} // RVA: 0x7A765F710
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7637E60
        // ── Unresolved (hash) ──
        public void m_C50(){} // RVA: 0x7A7637E60
        public void m_590(){} // RVA: 0x7A76C4680
    }

    /// <summary>Originally: ÏÏÏÍÌÍÌÌÌÏÍÏÍÍÌÏÍÏÏÏÏÏÌ</summary>
    public class UdonOperationResponseDisconnecSibling_BB56 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7690A90
        public void InternalEquals(){} // RVA: 0x7A7690A90
        public void DefaultEquals(){} // RVA: 0x7A76C3620
        public void GetHashCode(){} // RVA: 0x7A76B71E0
        public void InternalGetHashCode(){} // RVA: 0x7A76C3630
        public void ToString(){} // RVA: 0x7A76C36F0
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76C3700
        public void Dispose(){} // RVA: 0x7A76C37A0
        public void Cleanup(){} // RVA: 0x7A76C37B0
        // ── Unresolved (hash) ──
        public void m_02C(){} // RVA: 0x7A76C3790
        public void m_FC3(){} // RVA: 0x7A76C37D0
        public void m_364(){} // RVA: 0x7A76C3890
        public void m_180(){} // RVA: 0x7A76C3990
        public void m_4FC(){} // RVA: 0x7A76C3960
        public void m_D9F(){} // RVA: 0x7A76C3970
        public void m_2A5(){} // RVA: 0x7A76C39A0
        public void m_16E(){} // RVA: 0x7A76C39B0
    }

    /// <summary>Originally: ÏÍÍÏÏÏÍÍÌÌÏÎÎÍÍÌÏÎÍÎÍÏÏ</summary>
    public class UdonOperationResponseDisconnecSibling_BEBB : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A765F080
        public void InternalEquals(){} // RVA: 0x7A765F080
        public void DefaultEquals(){} // RVA: 0x7A7637E60
        public void GetHashCode(){} // RVA: 0x7A7637E60
        public void InternalGetHashCode(){} // RVA: 0x7A765F010
        public void ToString(){} // RVA: 0x7A765F710
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7637E60
        // ── Unresolved (hash) ──
        public void m_237(){} // RVA: 0x7A7637E60
        public void m_886(){} // RVA: 0x7A7637E60
        public void m_2E5(){} // RVA: 0x7A765F010
        public void m_C4B(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÍÍÌÏÌÍÎÍÍÏÍÍÌÍÍÌÎÍÎÌÎÎÌ</summary>
    public class UdonOperationResponseDisconnecSibling_E8EE : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7664E50
        public void InternalEquals(){} // RVA: 0x7A765F710
        public void DefaultEquals(){} // RVA: 0x7A75FEFA0
        public void GetHashCode(){} // RVA: 0x7A7664E50
        public void InternalGetHashCode(){} // RVA: 0x7A7664CF0
        public void ToString(){} // RVA: 0x7A7637E60
        public void GetHashCodeOfPtr(){} // RVA: 0x7A75FEFA0
        // ── Unresolved (hash) ──
        public void m_2A5(){} // RVA: 0x7A7637E60
        public void m_895(){} // RVA: 0x7A767FBC0
        public void m_55E(){} // RVA: 0x7A767FBC0
        public void m_114(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÏÌÎÍÏÍÎÏÌÌÌÍÌÎÏÍÎÌÎÌÎÎÎ</summary>
    public class UdonOperationResponseDisconnecSibling_ED83 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A7637E60
        public void InternalEquals(){} // RVA: 0x7A7637E60
        public void DefaultEquals(){} // RVA: 0x7A7637E60
        public void GetHashCode(){} // RVA: 0x7A765F710
        public void InternalGetHashCode(){} // RVA: 0x7A7637E60
        public void ToString(){} // RVA: 0x7A765F710
        public void GetHashCodeOfPtr(){} // RVA: 0x7A7637E60
        // ── Unresolved (hash) ──
        public void m_4D6(){} // RVA: 0x7A765F710
        public void m_C4B(){} // RVA: 0x7A765F710
        public void m_114(){} // RVA: 0x7A765F710
    }

    /// <summary>Originally: ÌÌÌÏÌÌÌÎÎÎÍÎÏÌÏÎÌÎÍÌÌÎÍ</summary>
    public class UdonOperationResponseDisconnecSibling_F2BA : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7A76134D0
        public void InternalEquals(){} // RVA: 0x7A765F070
        public void DefaultEquals(){} // RVA: 0x7A7664E50
        public void GetHashCode(){} // RVA: 0x7A765F010
        public void InternalGetHashCode(){} // RVA: 0x7A765F080
        public void ToString(){} // RVA: 0x7A765F070
        public void GetHashCodeOfPtr(){} // RVA: 0x7A76134D0
        // ── Unresolved (hash) ──
        public void m_C7E(){} // RVA: 0x7A76134D0
        public void m_114(){} // RVA: 0x7A7664CF0
        public void m_E16(){} // RVA: 0x7A765F010
        public void m_8A0(){} // RVA: 0x7A765F070
        public void m_B91(){} // RVA: 0x7A76134D0
        public void m_EE5(){} // RVA: 0x7A7664E50
    }

}