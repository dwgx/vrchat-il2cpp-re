// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.System
// Classes: 1
// Methods: 52

namespace VRC.Core.System
{
    /// <summary>Originally: ÎÍÍÍÏÌÌÎÍÍÏÍÍÎÌÌÎÌÍÎÍÍÏ</summary>
    public class RefreshServicesComponent_9F82 : MonoBehaviour
    {
        public int _destroyCancellationToken; // 0x20
        public string _useGUILayout; // 0x28
        public int f_A81; // 0x30
        public ÎÍÍÍÏÌÌÎÍÍÏÍÍÎÌÌÎÌÍÎÍÍÏ f_EDB;
        public OscCore.OscServer f_E72; // 0x38
        public ÍÎÍÍÍÏÍÎÎÍÍÌÍÍÌÏÏÎÍÎÏÏÍ _debugDisplay; // 0x40
        public bool ÌÍÎÎÌÎÌÌÎÏÍÎÌÏÍÎÍÎÎÌÌÏÎ; // 0x48
        public object ÍÍÍÍÌÍÏÌÍÎÏÎÌÎÏÍÎÎÌÏÍÏÎ; // 0x50
        public System.Action`1<bool> ÍÎÏÏÎÌÍÎÌÍÍÌÍÌÎÏÎÍÌÌÍÌÌ; // 0x8
        public VRC.OSCQuery.OSCQueryService ÎÏÍÌÏÏÍÍÏÍÌÎÎÏÌÍÎÏÌÌÌÌÎ; // 0x58
        public System.Collections.Generic.Dictionary`2<0x664D3750,System.Collections.Generic.Dictionary`2<ÎÏÌÍÎÏÌÍÎÍÎÏÎ.ÌÌÍÏÎÎÌÏÌÎ,OscCore.OscClient>> ÌÏÌÏÍÌÎÌÍÏÌÏÍÍÎÌÎÎÏÌÎÍÌ; // 0x60
        public System.Collections.Generic.Dictionary`2<0x664D3750,bool> ÍÌÏÏÎÎÌÍÏÍÌÌÎÍÎÎÎÍÎÍÎÎÍ; // 0x68
        public System.Collections.Generic.Dictionary`2<ÏÎÌÎÏÏÍÎÌÍÍÍÏÍÏÏÎÍÍÏÌÏÍ,System.Action> ÎÏÎÏÌÍÍÏÎÍÏÎÍÍÍÎÎÏÍÎÌÌÏ; // 0x70
        public string ÍÎÍÏÎÏÌÌÌÎÌÍÌÍÏÏÏÎÏÍÌÏÍ;
        public string ÍÍÍÌÏÏÎÎÌÏÌÍÏÎÎÏÎÏÍÌÏÏÎ; // 0x10
        public float ÎÏÎÎÌÏÎÌÍÍÌÎÎÌÌÎÍÍÎÌÌÌÏ;
        public int ÏÏÏÎÌÏÎÌÍÌÌÏÎÎÎÎÎÌÍÎÍÍÍ; // 0x18
        public int ÌÌÍÍÏÏÏÎÎÌÍÍÏÍÍÎÎÌÏÎÌÏÏ;
        public string ÎÏÌÎÍÌÏÏÍÎÍÎÌÎÏÎÍÎÎÏÌÎÌ;
        public bool ÎÎÎÎÌÌÌÏÎÍÏÌÏÎÌÌÌÍÌÏÎÎÌ; // 0x78
        public System.Collections.Generic.HashSet`1<ÎÏÌÍÎÏÌÍÎÍÎÏÎ.ÌÌÍÏÎÎÌÏÌÎ> ÌÍÍÍÌÌÎÏÏÌÏÏÏÍÏÏÏÎÏÏÍÎÏ; // 0x80
        public System.Collections.Generic.Dictionary`2<string,ÏÍÌÍÍÌÎÏÏÍÏÍÍÎÍÎÎÍÎÏÏÍÎ> ÍÍÏÍÏÎÏÏÍÏÌÍÏÍÎÍÌÏÏÌÍÌÎ; // 0x88

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4F2D2010
        public void Start(){} // RVA: 0x7FFD4F2D25F0
        public void IsInvoking(){} // RVA: 0x7FFD4F2D2730
        public void CancelInvoke(){} // RVA: 0x7FFD4F2D27F0
        public void Invoke(){} // RVA: 0x7FFD4F2D86A0 | overloaded x6
        public void InvokeRepeating(){} // RVA: 0x7FFD4F2D2D00
        public void OnDestroy(){} // RVA: 0x7FFD4F2D2D10
        public void OnApplicationPause(){} // RVA: 0x7FFD4F2D2DE0
        public void StartCoroutine(){} // RVA: 0x7FFD4F2D2F40
        public void .cctor(){} // RVA: 0x7FFD4F2D3450
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4F2D3580
        public void Update(){} // RVA: 0x7FFD4F2D37B0
        public void StopCoroutine(){} // RVA: 0x7FFD4F2D37D0
        public void OnCollisionExit(){} // RVA: 0x7FFD4F2D3B20
        public void StopAllCoroutines(){} // RVA: 0x7FFD4F2D4350
        public void get_useGUILayout(){} // RVA: 0x7FFD4F2D43C0
        public void print(){} // RVA: 0x7FFD4F2D4880
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4F2D4A20
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F2D4BC0
        public void InvokeDelayed_3CA68CC16A1E(){} // RVA: 0x7FFD4E079DE0 | overloaded x2
        public void CancelInvoke_7F2EC1F98190(){} // RVA: 0x7FFD4F2D53F0
        public void OnTriggerEnter(){} // RVA: 0x7FFD4F2D55F0
        public void GetNetworkCallingMetadata(){} // RVA: 0x7FFD4E409500
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4F2D5600
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4F2D5700
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4F2D5B30
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4F2D5E80
        public void OnCancellationTokenCreated(){} // RVA: 0x7FFD4F2D68A0
        public void RefreshServiceComponentParent(){} // RVA: 0x7FFD4F2D6980
        public void RefreshServiceComponentParent_71E8819789E8(){} // RVA: 0x7FFD4F2D6FC0
        public void NextMultipleOf4(){} // RVA: 0x7FFD4F2D7160
        public void SyncShapesNow(){} // RVA: 0x7FFD4F2D74C0
        public void RefreshServices(){} // RVA: 0x7FFD4F2D76B0
        public void SyncShapesNow_17D9C081F781(){} // RVA: 0x7FFD4F2D76D0
        public void .ctor(){} // RVA: 0x7FFD4F2D7E40
        public void Initialize(){} // RVA: 0x7FFD4F2D81E0
        public void StartCoroutine_Auto_936B9944C443(){} // RVA: 0x7FFD4F2D8310
        public void CreatePrimaryRequest(){} // RVA: 0x7FFD4F2D83E0
        public void CopyServiceReferences(){} // RVA: 0x7FFD4F2D85C0
        public void InitializeWithContext(){} // RVA: 0x7FFD4F2D8630
        public void CloneServiceDescriptor(){} // RVA: 0x7FFD4F2D8DC0
        public void Initialize_0E0C6C332983(){} // RVA: 0x7FFD4F2D8E80
        public void GetNetworkCallingMetadata_A81F344D79D8(){} // RVA: 0x7FFD4F2D8EE0
        public void CalculateNextMultiple(){} // RVA: 0x7FFD4F2D91A0
        public void RefreshServices_5E919D5007E2(){} // RVA: 0x7FFD4F2D9370
        public void DispatchRefreshResult(){} // RVA: 0x7FFD4F2D93E0
    }

}