// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.World
// Classes: 5
// Methods: 133

namespace VRC.World
{
    /// <summary>Originally: ÍÏÍÏÌÌÎÍÏÌÍÎÎÏÎÍÏÎÎÍÏÎÎ</summary>
    public class ISpawnedPropEnumerator_BA4F : Object
    {
        public int System.Collections.Generic.IEnumerator<VRC.DataModel.ISpawnedProp>.Current; // 0x10
        public ÏÎÌÍÏÎÎÎÍÏÏÌÌÎÌÎÎÌÍÎÍÌÎ System.Collections.IEnumerator.Current; // 0x18
        public int ÌÍÎÎÎÏÍÌÍÌÏÎÌÎÌÍÌÍÍÏÌÌÌ; // 0x20
        public ÌÍÏÏÏÍÌÏÎÎÍÏÍÍÍÌÍÍÍÏÍÎÍ ÌÏÎÏÍÌÌÏÌÏÍÌÍÎÍÎÏÍÏÌÌÍÌ; // 0x28
        public string ÏÏÏÎÍÎÏÏÎÎÌÎÎÍÏÌÌÍÏÍÍÍÏ; // 0x30
        public string ÍÌÍÏÎÌÌÏÎÎÍÎÎÌÏÏÎÌÏÍÏÏÏ; // 0x38
        public System.Collections.Generic.List`1<ÍÌÌÏÎÎÎÎÎÌÍÏÌÍÏÍÏÎÎÌÍÏÌ> ÍÍÎÌÏÌÏÏÌÍÏÌÏÌÍÌÏÏÍÍÏÎÎ; // 0x40
        public int ÎÏÍÎÌÏÌÌÏÌÏÎÎÏÌÍÌÌÏÍÎÍÍ; // 0x48

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC2F247C0
        public void GetEnumerator(){} // RVA: 0x7FFAC2F21310
        public void System.Collections.Generic.IEnumerator<VRC.DataModel.ISpawnedProp>.get_Current(){} // RVA: 0x7FFAC2F247C0
        public void op_Implicit(){} // RVA: 0x7FFAC2F21310
        public void System.IDisposable.Dispose(){} // RVA: 0x7FFAC2F21310
        public void MoveNext(){} // RVA: 0x7FFAC3311100
        public void .ctor(){} // RVA: 0x7FFAC327C740
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2F247C0
        public void System.Collections.Generic.IEnumerable<VRC.DataModel.ISpawnedProp>.GetEnumerator(){} // RVA: 0x7FFAC3311300
        public void Instantiate(){} // RVA: 0x7FFAC2F21310
        public void get_Current(){} // RVA: 0x7FFAC2F247C0
        public void System.Collections.IEnumerator.Reset(){} // RVA: 0x7FFAC3311450
        public void Equals(){} // RVA: 0x7FFAC2F247C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC3311300
    }

    /// <summary>Originally: ÌÏÌÍÍÌÌÎÌÌÍÌÎÏÏÌÌÍÏÌÏÏÌ</summary>
    public class RoomManager_C084 : MonoBehaviour
    {
        public VRCSDK2.VRC_PlayerAudioOverride ÍÌÎÍÎÏÎÍÎÎÎÎÍÎÍÍÎÌÌÌÌÍÍ; // 0x20
        public VRCSDK2.VRC_PlayerAudioOverride ÎÎÌÎÎÏÍÎÏÌÎÍÎÏÍÍÍÍÌÏÌÏÎ;
        public bool ÏÎÍÍÍÏÎÍÏÏÍÎÎÍÍÌÎÎÍÍÎÍÏ; // 0x8
        public System.Collections.Generic.List`1<VRCSDK2.VRC_PlayerAudioOverride> ÌÌÏÏÎÍÏÍÏÏÎÍÌÍÏÍÏÌÏÎÎÌÏ; // 0x10
        public VRCSDK2.VRC_PlayerAudioOverride ÏÌÏÏÍÎÎÎÍÎÏÏÌÍÍÌÏÏÌÌÎÎÎ; // 0x28
        public bool ÌÌÌÍÍÌÍÌÍÌÌÍÏÍÍÌÌÌÎÌÌÎÏ; // 0x30
        public ÍÎÌÎÌÏÏÏÏÌÎÍÎÌÎÏÌÌÏÏÏÏÍ ÎÍÎÎÌÌÎÏÏÏÎÏÎÎÌÍÌÌÏÌÍÍÏ; // 0x38

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC4153840
        public void Start(){} // RVA: 0x7FFAC4153DE0
        public void IsInvoking(){} // RVA: 0x7FFAC41541D0
        public void OnDestroy(){} // RVA: 0x7FFAC41545C0
        public void Invoke(){} // RVA: 0x7FFAC41546D0
        public void InvokeRepeating(){} // RVA: 0x7FFAC4154860
        public void InternalApplyOverrideRPC(){} // RVA: 0x7FFAC4154C60
        public void OnPlayerJoined(){} // RVA: 0x7FFAC4155080
        public void Awake(){} // RVA: 0x7FFAC4155320
        public void StartCoroutine(){} // RVA: 0x7FFAC4155720
        public void OnBecameInvisible(){} // RVA: 0x7FFAC4155CD0
        public void .ctor(){} // RVA: 0x7FFAC4155DE0
        public void Initialize(){} // RVA: 0x7FFAC4155EB0
        public void StopCoroutine(){} // RVA: 0x7FFAC4156020
        public void OnTriggerEnter(){} // RVA: 0x7FFAC41565D0
        public void StopAllCoroutines(){} // RVA: 0x7FFAC41569C0
        public void get_useGUILayout(){} // RVA: 0x7FFAC4156EE0
    }

    /// <summary>Originally: ÎÏÏÎÏÏÎÍÍÎÌÌÏÏÏÌÌÌÌÌÍÏÍ</summary>
    public class WorldProximityExitStation_FE46_FE46 : NetworkReadyHandler_68D0_68D0
    {
        public ÎÏÏÎÏÏÎÍÍÎÌÌÏÏÏÌÌÌÌÌÍÏÍ[] _proximity;
        public System.Collections.Generic.Dictionary`2<uint,ÎÏÏÎÏÏÎÍÍÎÌÌÏÏÏÌÌÌÌÌÍÏÍ> f_EC5; // 0x8
        public VRC.SDKBase.VRCStation f_135; // 0x58
        public VRCSDK2.VRC_Station f_46F; // 0x60
        public VRC.SDK3.Components.VRCStation f_567; // 0x68
        public VRC.Udon.UdonBehaviour f_842; // 0x70
        public VRC.SDKBase.VRC_Interactable f_E7F; // 0x78
        public VRC.SDKBase.VRC_PropController f_BC0; // 0x80
        public CustomTriggerTarget f_53F; // 0x88
        public UnityEngine.Vector3 f_94E; // 0x90
        public UnityEngine.Vector3 f_EAB; // 0x9C
        public UnityEngine.Quaternion ÏÌÏÍÍÏÎÍÎÌÌÍÎÌÍÏÍÌÎÎÌÏÍ; // 0xA8
        public UnityEngine.Quaternion ÌÏÏÌÏÎÎÏÍÌÍÎÎÎÌÏÎÏÍÌÍÎÍ; // 0xB8
        public System.Type ÏÌÎÎÍÍÍÍÎÌÍÏÍÍÍÎÍÌÍÍÍÎÌ; // 0xC8
        public System.Collections.Generic.Dictionary`2<ÌÌÍÎÎÌÌÌÌÍÍÏÌÍÍÎÍÏÌÏÏÌÏ,ÎÌÎÌÏÎÏÍÎÏÌÍÏÏÌÏÌÌÎÎÌÏÍ> ÏÍÎÍÎÍÌÍÏÎÏÌÍÌÏÏÏÍÏÎÎÎÌ; // 0xD0
        public UnityEngine.Vector3 ÌÌÎÍÎÍÍÍÎÏÌÍÌÎÏÎÏÎÏÌÌÍÌ; // 0xD8
        public bool ÏÎÌÌÎÏÌÎÎÌÍÍÍÍÏÍÎÍÎÌÎÍÏ; // 0xE4
        public bool ÏÍÌÎÎÌÌÍÏÎÍÏÍÌÍÎÏÎÏÌÌÍÏ; // 0xE5
        public bool ÍÏÌÌÌÍÌÍÎÏÎÏÌÌÌÌÍÌÎÌÍÏÎ; // 0xE6
        public UnityEngine.Coroutine ÏÎÌÌÏÎÌÎÎÏÌÍÌÌÍÌÎÏÏÍÏÌÏ; // 0xE8
        public UnityEngine.WaitForSeconds ÏÌÍÏÌÌÌÌÎÍÌÏÎÎÏÍÎÌÌÏÎÏÍ; // 0x10
        public System.Nullable`1<int> ÎÍÍÌÌÍÎÍÎÏÌÏÏÎÎÍÏÍÏÌÎÍÍ; // 0xF0
        public System.Action`1<ÎÏÏÎÏÏÎÍÍÎÌÌÏÏÏÌÌÌÌÌÍÏÍ> ÌÎÌÍÏÌÌÏÍÎÎÏÌÏÌÎÎÍÌÍÌÍÍ; // 0xF8
        public System.Nullable`1<uint> <ÏÎÌÌÌÏÏÌÎÍÏÏÌÎÌÎÏÍÎÏÍÍÏ>k__BackingField; // 0x100
        public bool <ÍÌÍÏÎÍÎÍÌÌÌÍÌÍÎÏÌÍÏÏÌÎÏ>k__BackingField; // 0x108
        public UnityEngine.GameObject ÌÌÎÏÎÏÎÎÍÍÌÌÎÏÎÍÎÏÎÎÌÎÎ; // 0x110

        // ── Methods ──
        public void __Clone__SystemObject(){} // RVA: 0x7FFAC41950E0
        public void set_ValidExpressions(){} // RVA: 0x7FFAC4195470
        public void ProcessProximityExit_2FB9A34F349B_2FB9A34F349B(){} // RVA: 0x7FFAC4195690 | overloaded x2
        public void UpdateProximityExit(){} // RVA: 0x7FFAC41958D0
        public void InvokeRepeating(){} // RVA: 0x7FFAC4195980
        public void get_caretColor(){} // RVA: 0x7FFAC41959E0
        public void Awake_352E6214DE07(){} // RVA: 0x7FFAC4195CC0
        public void Start_EEA1039C8659(){} // RVA: 0x7FFAC4195DC0
        public void InvokeRepeating_D3598F593C6D(){} // RVA: 0x7FFAC4195EC0
        public void LateUpdate(){} // RVA: 0x7FFAC4195F10
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC4195F30
        public void OnNetworkReady(){} // RVA: 0x7FFAC4195F50
        public void StopCoroutine(){} // RVA: 0x7FFAC4195F80
        public void OnApplicationQuit(){} // RVA: 0x7FFAC4195FA0
        public void get_categories(){} // RVA: 0x7FFAC34F6C80
        public void set_expiryAfterSeen(){} // RVA: 0x7FFAC4196020
        public void get_AppendFilenameTimestamp(){} // RVA: 0x7FFAC4196030
        public void set_AppendFilenameTimestamp(){} // RVA: 0x7FFAC4196040
        public void Awake(){} // RVA: 0x7FFAC4196050
        public void Start(){} // RVA: 0x7FFAC41965B0
        public void InvokeDelayed(){} // RVA: 0x7FFAC4196650
        public void Update(){} // RVA: 0x7FFAC41966F0
        public void set_hidden(){} // RVA: 0x7FFAC2F21310
        public void UseStation(){} // RVA: 0x7FFAC41974E0
        public void set_AllowAutoRedirect(){} // RVA: 0x7FFAC4197650
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC41977E0
        public void RunUdonEventOnMainThreadAndRemoveFromQueue(){} // RVA: 0x7FFAC41979D0
        public void set_name(){} // RVA: 0x7FFAC4197AD0
        public void ExitStation(){} // RVA: 0x7FFAC4198DA0
        public void set_Proximity(){} // RVA: 0x7FFAC4198E90
        public void VRC.Udon.Common.Interfaces.IUdonComponentGetterModule.GetComponentsInParent__TArray(){} // RVA: 0x7FFAC4199280
        public void InitializeStaticFields(){} // RVA: 0x7FFAC4199EF0
        public void UpdateExitRotation(){} // RVA: 0x7FFAC419A2F0
        public void get_Proximity(){} // RVA: 0x7FFAC419AC50
        public void InitializeProximityExit(){} // RVA: 0x7FFAC419AD50
        public void EnableProximityExit(){} // RVA: 0x7FFAC419B160
        public void DisableProximityExit(){} // RVA: 0x7FFAC419B4C0
        public void AddRange(){} // RVA: 0x7FFAC419B8E0
        public void Awake_16DB48E86C7F(){} // RVA: 0x7FFAC419BC20
        public void GetGoalPosition_Injected(){} // RVA: 0x7FFAC419C300
        public void GetUnityEngine(){} // RVA: 0x7FFAC419C7D0
        public void DestroyProximityExit(){} // RVA: 0x7FFAC419C9E0
        public void ApplyRightLandmarkColor(){} // RVA: 0x7FFAC419CB60
        public void AwakeProximityExit(){} // RVA: 0x7FFAC419D340
        public void OnCollisionStay(){} // RVA: 0x7FFAC419D930
        public void get_gameObject(){} // RVA: 0x7FFAC419DFD0
        public void StartProximityExit(){} // RVA: 0x7FFAC419E290
        public void StopProximityExit(){} // RVA: 0x7FFAC419E460
        public void OnDestroy(){} // RVA: 0x7FFAC419E500
        public void OnEnable(){} // RVA: 0x7FFAC419E700
        public void OnDisable(){} // RVA: 0x7FFAC419E7F0
        public void .ctor(){} // RVA: 0x7FFAC419E9D0
        public void .cctor(){} // RVA: 0x7FFAC419EC30
        public void Update_540CB71AC481(){} // RVA: 0x7FFAC313BE20
        public void ResetProximityExit(){} // RVA: 0x7FFAC419EE40
    }

    /// <summary>Originally: ÍÎÏÍÍÌÎÌÎÎÍÍÏÌÏÎÍÌÍÍÏÌÍ</summary>
    public class WorldSpawnHandler_CA88_CA88 : MonoBehaviour
    {
        public ÍÌÎÏÍÏÍÏÏÌÍÎÍÌÌÍÎÎÌÌÏÌÎ ÍÌÎÎÌÎÍÏÏÏÌÏÌÍÎÏÍÌÍÌÍÌÏ; // 0x20
        public ÎÍÍÎÎÍÌÎÌÍÏÎÎÌÍÎÏÌÌÍÍÏÌ ÌÍÏÌÌÏÏÌÌÎÎÍÌÍÎÏÎÎÏÎÏÍÍ; // 0x28
        public UnityEngine.GameObject ÍÏÌÌÍÏÍÎÏÎÍÌÏÍÍÎÌÌÎÍÎÌÎ; // 0x30
        public UnityEngine.GameObject ÎÍÏÌÎÏÎÎÏÏÎÎÎÏÍÏÍÍÌÎÍÍÏ; // 0x38
        public VRC.UI.Core.Styles.StyleElement ÍÏÎÍÌÍÍÏÏÏÏÏÌÍÍÎÏÍÌÌÏÌÎ; // 0x40
        public ÍÌÌÍÏÍÏÌÏÌÌÌÍÌÎÌÍÏÍÌÍÎÏ ÍÎÎÏÌÍÏÎÏÌÎÏÏÎÎÎÌÍÍÎÌÍÌ; // 0x48

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFACB2C6870
        public void RaiseCancellation(){} // RVA: 0x7FFACB2C68C0
        public void IsInvoking(){} // RVA: 0x7FFACB2C6910
        public void OnSpawn(){} // RVA: 0x7FFACB2C6C60
        public void Invoke(){} // RVA: 0x7FFACB2C6F70
        public void InvokeRepeating(){} // RVA: 0x7FFACB2C7A40
        public void CancelInvoke(){} // RVA: 0x7FFACB2C7D90
        public void IsInvoking_EDC330A24709(){} // RVA: 0x7FFACB2C7DE0
        public void StartCoroutine(){} // RVA: 0x7FFACB2C80F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFACB2C8200
        public void StartCoroutine_Auto(){} // RVA: 0x7FFACB2C8C90
        public void StopCoroutine(){} // RVA: 0x7FFACB2C8FF0
        public void LateUpdate(){} // RVA: 0x7FFACB2C91F0
        public void Awake(){} // RVA: 0x7FFACB2C9300
        public void StopAllCoroutines(){} // RVA: 0x7FFACB2C9410
        public void Start(){} // RVA: 0x7FFACB2C9500
    }

    /// <summary>Originally: ÍÏÏÍÎÍÌÌÎÎÌÍÎÌÍÌÌÌÎÍÍÌÎ</summary>
    public class WorldSpawn_F00B_F00B : LifecycleComponent_5AF1_5AF1
    {
        public ÍÌÌÍÏÍÏÌÏÌÌÌÍÌÎÌÍÏÍÌÍÎÏ _f00B; // 0x68
        public UnityEngine.GameObject spawnedBadge; // 0x70
        public UnityEngine.GameObject ÍÏÌÌÍÏÍÎÏÎÍÌÏÍÍÎÌÌÎÍÎÌÎ; // 0x78
        public UnityEngine.GameObject ÎÍÏÌÎÏÎÎÏÏÎÎÎÏÍÏÍÍÌÎÍÍÏ; // 0x80
        public VRC.UI.Core.Styles.StyleElement ÍÏÎÍÌÍÍÏÏÏÏÏÌÍÍÎÏÍÌÌÏÌÎ; // 0x88
        public ÍÌÌÍÏÍÏÌÏÌÌÌÍÌÎÌÍÏÍÌÍÎÏ ÍÎÎÏÌÍÏÎÏÌÎÏÏÎÎÎÌÍÍÎÌÍÌ; // 0x90
        public System.Collections.Generic.List`1<ÎÍÍÎÎÍÌÎÌÍÏÎÎÌÍÎÏÌÌÍÍÏÌ> ÍÎÎÌÏÌÏÍÌÎÌÌÏÌÏÍÏÏÏÎÍÏÌ; // 0x98

        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFACB95A6C0
        public void OnBecameVisible(){} // RVA: 0x7FFACB95A790
        public void InitializeSpawnPoint(){} // RVA: 0x7FFACB95A7F0
        public void ResolveSpawnPoint(){} // RVA: 0x7FFACB95A970
        public void UpdateSpawnPoint(){} // RVA: 0x7FFACB95AD30
        public void RefreshSpawnPoint(){} // RVA: 0x7FFACB95AE00
        public void Start(){} // RVA: 0x7FFACB95AE10
        public void ApplySpawnPoint(){} // RVA: 0x7FFACB95AEE0
        public void ProcessSpawnPoint(){} // RVA: 0x7FFACB95AF40
        public void ComputeSpawnPoint(){} // RVA: 0x7FFACB95B310
        public void get_name(){} // RVA: 0x7FFACB95B3C0
        public void HandleSpawnPoint(){} // RVA: 0x7FFACB95B590
        public void OnSpawn(){} // RVA: 0x7FFACB95B640
        public void ComputegameObject(){} // RVA: 0x7FFACB95B810
        public void .ctor(){} // RVA: 0x7FFACB95B950
        public void Initialize(){} // RVA: 0x7FFACB95BA60
        public void Computenames(){} // RVA: 0x7FFACB95BA70
        public void TrackSpawnPoint(){} // RVA: 0x7FFACB95EBD0
        public void GetSpawnPoint(){} // RVA: 0x7FFACB95EBE0
        public void SetSpawnPoint(){} // RVA: 0x7FFACB95EBF0
        public void IgnoreLine(){} // RVA: 0x7FFACB95ED10
        public void ClearSpawnPoint(){} // RVA: 0x7FFACB95EDA0
        public void AddForceAtPosition_Injected(){} // RVA: 0x7FFACB95EF70
        public void InitializeSpawnState(){} // RVA: 0x7FFACB95EFD0
        public void get_rect(){} // RVA: 0x7FFACB95F1A0
        public void StopAllCoroutines(){} // RVA: 0x7FFACB95F1B0
        public void ResolveSpawnState(){} // RVA: 0x7FFACB95F5B0
        public void UpdateSpawnState(){} // RVA: 0x7FFACB95F920
        public void RefreshSpawnState(){} // RVA: 0x7FFACB95FBA0
    }

}