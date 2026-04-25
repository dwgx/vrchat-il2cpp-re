// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Animation
// Classes: 2
// Methods: 122

namespace VRC.Animation
{
    /// <summary>Originally: ÌÌÍÌÌÏÎÎÏÎÌÏÍÏÍÌÌÌÌÏÎÌÍ</summary>
    public class VRCMotionState : MonoBehaviour
    {
        public bool _destroyCancellationToken; // 0x20
        public ÏÏÍÎÍÍÎÌÍÍÍÍÎÌÏÎÍÎÎÏÍÍÍ _useGUILayout; // 0x28
        public UnityEngine.Animator f_CC3; // 0x30
        public ÏÏÏÎÍÏÎÏÍÎÎÌÏÍÎÍÍÍÎÍÎÌÎ f_639; // 0x38
        public ÏÍÏÏÌÏÍÎÏÏÍÌÏÍÍÎÎÍÍÌÏÌÎ f_2F3; // 0x40
        public ÏÎÏÏÎÍÌÎÌÏÍÏÏÎÎÏÎÍÎÌÎÎÍ f_FBF; // 0x48
        public ÌÏÌÎÍÏÏÏÍÍÏÌÏÎÌÎÏÌÏÎÌÏÎ f_8D0; // 0x50
        public bool ÌÏÍÍÎÎÍÏÍÎÌÍÍÏÎÌÍÍÎÎÏÍÍ; // 0x58
        public bool ÍÎÌÎÌÍÍÍÌÌÏÏÎÎÎÏÏÎÌÏÏÏÏ; // 0x59
        public ÍÌÌÏÍÎÎÍÍÏÌÎÏÏÎÍÍÏÎÌÌÌÎ ÏÌÍÏÎÍÏÏÌÍÎÏÍÌÎÏÏÌÏÌÏÌÌ; // 0x60
        public ÌÎÍÍÎÌÎÌÌÎÍÎÏÏÍÎÎÌÏÌÎÎÌ ÍÏÌÍÌÏÌÌÏÎÏÎÌÌÌÎÌÏÌÏÎÌÏ; // 0x68
        public 0x66352FE8 ÏÌÎÌÎÍÎÍÎÏÍÌÎÎÍÌÌÎÌÏÌÎÎ; // 0x70
        public UnityEngine.Animator ÌÌÏÎÍÌÎÍÎÍÎÍÏÎÏÎÏÎÍÎÌÍÌ; // 0x78
        public bool ÎÎÎÍÎÎÏÌÎÌÎÍÌÎÍÌÍÌÌÌÎÌÎ; // 0x80
        public bool ÍÌÍÍÎÍÎÌÎÎÏÌÎÍÌÍÎÏÌÌÎÏÌ; // 0x81
        public bool ÎÍÎÌÎÏÎÎÍÍÏÌÍÌÎÎÏÏÎÏÏÌÏ; // 0x82
        public UnityEngine.GameObject ÌÏÌÌÍÌÎÏÍÍÎÍÎÌÎÍÎÏÌÍÎÍÍ; // 0x88
        public UnityEngine.GameObject ÍÌÏÎÍÏÌÎÏÌÎÎÏÎÍÌÌÎÌÏÍÎÍ; // 0x90
        public UnityEngine.GameObject ÍÍÍÍÌÎÎÌÎÎÌÍÌÍÏÍÌÍÎÎÌÎÎ; // 0x98
        public UnityEngine.GameObject ÌÌÎÌÎÍÏÌÍÎÍÍÌÏÍÍÎÎÌÏÍÌÎ; // 0xA0
        public UnityEngine.GameObject ÏÌÍÌÍÏÍÏÍÏÌÍÎÏÎÌÌÏÎÎÏÌÍ; // 0xA8
        public UnityEngine.GameObject ÍÎÏÎÎÎÏÎÏÎÎÎÎÌÍÏÍÌÏÍÎÍÍ; // 0xB0
        public UnityEngine.Vector3 ÎÍÌÌÎÏÌÏÍÍÏÌÏÍÎÍÎÌÍÏÌÎÍ; // 0xB8
        public float ÏÏÏÏÌÌÌÍÍÏÏÍÏÏÎÏÌÍÌÏÌÏÎ; // 0xC4
        public bool ÏÎÌÎÍÍÎÍÏÎÍÌÏÏÎÌÍÎÏÌÌÍÎ; // 0xC8
        public ÌÍÌÏÍÌÏÍÎÌÏÏÎÏÌÎÍÏÌÌÌÌÌ ÎÏÏÏÎÌÏÌÌÍÌÍÍÍÏÏÍÍÍÌÌÌÍ; // 0xD0
        public ÌÍÌÏÍÌÏÍÎÌÏÏÎÏÌÎÍÏÌÌÌÌÌ ÌÏÏÎÏÏÌÍÌÌÏÌÍÏÌÏÎÎÏÏÌÏÌ; // 0xD8
        public ÏÌÎÍÏÎÌÌÎÍÍÎÌÏÌÏÌÎÍÌÎÌÎ ÍÎÏÏÏÍÏÎÎÍÍÍÎÏÏÎÌÎÌÏÏÍÎ; // 0xE0
        public ÏÎÍÏÏÌÏÏÎÎÍÍÍÏÏÌÎÌÍÎÎÍÏ ÌÌÏÌÍÌÏÏÌÍÍÍÎÍÌÏÌÌÏÌÌÍÌ; // 0xE8
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÏÍÍÏÎÌÎÏÌÎÏÎÏÌÌÍÌÌÎÌÏÌÍ; // 0xF0
        public ÌÏÌÍÎÍÏÏÌÎÏÌÌÏÎÎÎÏÍÏÎÎÍ ÌÍÎÍÎÎÎÌÏÍÍÎÌÌÏÌÏÌÌÎÍÍÍ; // 0xF8
        public UnityEngine.Transform ÎÎÌÍÏÎÍÌÎÏÍÏÏÍÎÎÏÏÏÌÍÎÌ; // 0x100
        public UnityEngine.Transform ÌÎÍÍÌÏÎÌÏÍÍÍÌÏÍÍÍÌÍÎÏÎÌ; // 0x108
        public float ÍÏÎÍÍÏÍÏÎÌÌÍÎÌÏÌÏÍÌÌÏÍÎ; // 0x110
        public float ÎÌÍÎÍÏÍÎÏÎÎÏÍÎÍÌÍÎÍÍÏÏÏ; // 0x114
        public float ÎÌÎÍÎÏÌÏÏÌÍÌÍÍÌÌÎÏÌÎÎÎÌ; // 0x118
        public float ÏÌÌÏÍÌÎÍÌÌÏÎÎÎÏÌÏÎÌÍÏÍÌ; // 0x11C
        public float ÎÏÌÌÏÌÎÍÏÌÏÎÌÌÌÏÍÎÏÌÎÎÏ; // 0x120
        public float ÌÎÍÌÎÏÌÎÏÏÌÏÌÏÌÎÍÍÌÌÎÌÌ; // 0x124
        public bool ÍÎÏÎÌÏÏÍÌÏÎÍÌÎÎÎÌÎÌÌÎÏÎ; // 0x128
        public float ÍÏÎÏÌÍÌÍÌÎÌÍÍÍÌÏÎÌÎÎÎÌÍ; // 0x12C
        public UnityEngine.Transform ÎÎÏÍÌÍÍÏÎÌÎÏÍÎÍÍÎÌÎÍÎÎÌ; // 0x130
        public UnityEngine.Transform ÎÏÌÎÏÌÍÏÌÌÍÎÌÌÎÌÏÌÎÎÏÍÏ; // 0x138
        public UnityEngine.Vector3 ÌÍÌÍÏÏÌÏÍÏÏÏÏÌÍÍÏÍÎÎÎÎÏ; // 0x140
        public UnityEngine.Quaternion ÌÏÏÍÎÍÍÌÎÎÏÍÍÎÎÌÏÎÎÏÏÍÎ; // 0x14C
        public UnityEngine.Transform ÎÍÏÍÎÎÍÍÏÌÏÏÍÍÍÎÌÎÌÍÌÎÏ; // 0x160
        public UnityEngine.Vector3 ÌÏÏÌÍÎÍÏÎÌÌÌÌÎÌÎÏÍÎÌÌÍÌ; // 0x168
        public UnityEngine.Quaternion ÎÏÍÌÍÎÍÌÏÌÏÏÌÏÏÌÏÏÍÏÌÍÏ; // 0x174
        public bool ÏÎÍÍÍÏÎÍÏÏÍÎÎÍÍÌÎÎÍÍÎÍÏ; // 0x184
        public bool ÍÎÌÏÌÏÎÏÎÌÎÌÌÎÏÌÎÎÎÎÏÌÍ; // 0x185
        public bool ÏÎÏÏÌÍÍÎÏÎÌÎÎÏÍÎÏÎÌÍÎÌÎ; // 0x186
        public bool ÍÏÎÎÏÍÏÌÍÎÍÏÌÍÍÎÍÌÌÎÌÏÍ; // 0x187
        public float ÍÍÍÌÏÌÎÎÍÎÏÍÏÌÌÏÎÎÌÍÌÎÏ; // 0x188
        public bool ÌÍÍÍÍÎÌÎÏÏÎÏÌÎÏÏÏÏÍÏÎÎÎ; // 0x18C
        public bool ÍÏÎÎÌÍÌÍÏÍÍÌÏÏÎÏÏÎÏÌÎÍÍ; // 0x18D
        public ÏÎÏÍÌÎÏÍÌÏÏÎÌÎÌÏÍÎÌÌÍÎÏ ÎÏÎÎÎÎÎÎÏÌÏÎÎÌÎÎÎÍÌÌÏÌÏ; // 0x18E
        public bool ÎÌÏÍÎÍÏÌÏÌÍÎÎÌÍÍÍÍÍÏÍÍÍ; // 0x195

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFD4EFAD2D0
        public void RaiseCancellation(){} // RVA: 0x7FFD4EFAD460
        public void IsInvoking(){} // RVA: 0x7FFD4EFAD4E0
        public void CancelInvoke(){} // RVA: 0x7FFD4EFAD660
        public void Invoke(){} // RVA: 0x7FFD4EFADAE0
        public void InvokeRepeating(){} // RVA: 0x7FFD4EFADB30
        public void CancelInvoke_0DE2DEACF794(){} // RVA: 0x7FFD4EFADB50
        public void OnEnable(){} // RVA: 0x7FFD4EFADBF0
        public void StartCoroutine(){} // RVA: 0x7FFD4EFADD20
        public void SetCullingMode(){} // RVA: 0x7FFD4EFADEB0
        public void SetUpdateMode(){} // RVA: 0x7FFD4EFAE330
        public void StartCoroutine_Auto(){} // RVA: 0x7FFD4EFAE370
        public void StopCoroutine(){} // RVA: 0x7FFD4EFAE640
        public void MakeReadOnly(){} // RVA: 0x7FFD4EFAE650
        public void OnApplicationPause(){} // RVA: 0x7FFD4EFAE660
        public void StopAllCoroutines(){} // RVA: 0x7FFD4EFAE6B0
        public void LateUpdate(){} // RVA: 0x7FFD4EFAE880
        public void set_useGUILayout(){} // RVA: 0x7FFD4EFAFA00
        public void print(){} // RVA: 0x7FFD4EFB0F70
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFD4EFB1460
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4EFB1470
        public void InvokeDelayed(){} // RVA: 0x7FFD4EFAE640
        public void Awake(){} // RVA: 0x7FFD4EFB14E0
        public void OnTriggerExit(){} // RVA: 0x7FFD4EFB1530
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFD4EFB1590
        public void StartCoroutineManaged(){} // RVA: 0x7FFD4EFB15A0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFD4EFB15B0
        public void StopCoroutineManaged(){} // RVA: 0x7FFD4EFB1680
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFD4EFB1690
        public void GetScriptClassName(){} // RVA: 0x7FFD4EFB16A0
        public void .ctor(){} // RVA: 0x7FFD4EFB1B30
        public void Initialize(){} // RVA: 0x7FFD4EFB1BB0
        public void OnBecameVisible(){} // RVA: 0x7FFD4EFB20A0
        public void OnBecameInvisible(){} // RVA: 0x7FFD4EFB2520
        public void OnDestroy(){} // RVA: 0x7FFD4EFB2C40
        public void OnCollisionStay(){} // RVA: 0x7FFD4EFB2D20
        public void OnCollisionExit(){} // RVA: 0x7FFD4EFB3210
        public void Start(){} // RVA: 0x7FFD4EFB4290
        public void OnTriggerStay(){} // RVA: 0x7FFD4EFB4970
        public void OnCollisionEnter(){} // RVA: 0x7FFD4EFB4B20
        public void FixedUpdate(){} // RVA: 0x7FFD4EFB5930
        public void GetGameObject_575(){} // RVA: 0x7FFD4EFB5950
        public void OnTriggerEnter(){} // RVA: 0x7FFD4EFB59A0
        public void OnDisable_04AE7334EA30(){} // RVA: 0x7FFD4EFB5A00
        public void OnBecameInvisible_6E9AEE30D9A6(){} // RVA: 0x7FFD4EFB5A10
        public void OnApplicationPause_06D62653B906(){} // RVA: 0x7FFD4EFB5A20
        public void Reset(){} // RVA: 0x7FFD4EFB5AA0
        public void HasKey(){} // RVA: 0x7FFD4EFB5D60
        public void Update(){} // RVA: 0x7FFD4EFB5E50
        public void op_Implicit(){} // RVA: 0x7FFD4EFB65A0
        public void SetMotionStateAndPropagate(){} // RVA: 0x7FFD4EFB6780
        public void ComputeMotionVector(){} // RVA: 0x7FFD4EFB5A00
        public void StopMotionStateCallbacks(){} // RVA: 0x7FFD4EFB6790
        public void OnTriggerStay_11D63005E3E1(){} // RVA: 0x7FFD4EFB7AA0
        public void GetTransform_A56(){} // RVA: 0x7FFD4EFB7D70
        public void OnDisable(){} // RVA: 0x7FFD4EFB7DA0
        public void get_ValidExpressions(){} // RVA: 0x7FFD4E42F9D0
        public void OnDrawGizmos(){} // RVA: 0x7FFD4EFB7ED0
        public void GetGameObject_8B8(){} // RVA: 0x7FFD4EFB83D0
        public void SetActive_5BF(){} // RVA: 0x7FFD4EFB88C0
        public void SetActive_5BF_01B377A94A90(){} // RVA: 0x7FFD4EFB8920
        public void SetActive_5BF_FDF97024CBB8(){} // RVA: 0x7FFD4EFB8980
        public void OnCollisionStay_12005D1E7E7D(){} // RVA: 0x7FFD4EFB2D20
        public void StopCoroutine_49ACFF36B700(){} // RVA: 0x7FFD4EFAE640
        public void SetActive_5BF_2351694FB014(){} // RVA: 0x7FFD4EFB89B0
        public void Update_3B051D19CE57(){} // RVA: 0x7FFD4EFB8E20
        public void Awake_8C42CBD39D8E(){} // RVA: 0x7FFD4EFB8E80
        public void InitializeMotionState(){} // RVA: 0x7FFD4EFB92F0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EFB9430
        public void ProcessRemoteStringVariables(){} // RVA: 0x7FFD4EFB94A0
        public void Awake_D528744CDC34(){} // RVA: 0x7FFD4EFB9990
        public void get_ElementCount(){} // RVA: 0x7FFD4EFB9E80
        public void get_ElementCount_B3683F4A0F7A(){} // RVA: 0x7FFD4EFB9E90
        public void DisposeNetworkObject(){} // RVA: 0x7FFD4EFB9F80
        public void CancelPendingMotionInvoke(){} // RVA: 0x7FFD4EFBA7D0
        public void KeyTooManyColumns(){} // RVA: 0x7FFD4EFBA900
        public void CancelMotionStateInvoke(){} // RVA: 0x7FFD4EFBA910
        public void GetParameterizedConstructor(){} // RVA: 0x7FFD4EFBB720
    }

    /// <summary>Originally: ÍÌÌÏÌÌÏÌÌÌÏÌÍÍÌÌÎÎÌÌÍÏÎ</summary>
    public class VRCMotionStateSibling_3B68 : Object
    {
        public ÌÎÎÌÏÍÍÎÎÍÏÌÍÍÌÎÎÎÏÍÌÏÌ _name; // 0x10
        public bool _hideFlags; // 0x18
        public System.Threading.CancellationTokenSource f_8D0; // 0x20
        public ÎÏÍÌÍÌÏÌÍÏÏÎÏÏÌÍÍÎÎÎÍÏÌ ÌÎÍÍÍÍÌÏÎÍÌÎÎÍÏÌÎÍÏÎÌÌÏ; // 0x28
        public ÏÍÏÍÍÌÏÎÏÌÍÌÏÏÍÎÏÌÍÍÎÎÏ ÌÏÎÏÍÎÎÏÎÍÌÏÎÎÌÏÎÍÍÍÎÎÎ; // 0x30
        public ÏÎÏÏÎÎÎÎÌÌÍÍÏÏÍÍÌÍÌÌÌÏÌ ÎÎÎÌÏÍÍÏÍÍÎÏÌÍÎÏÏÌÎÏÎÌÎ; // 0x38
        public System.Nullable`1<ulong> ÏÏÌÏÏÍÎÎÏÎÍÍÎÏÏÌÌÍÏÌÍÌÎ; // 0x40
        public System.Nullable`1<ulong> ÎÎÌÎÎÎÏÏÏÍÏÍÏÏÏÌÍÏÌÏÌÍÎ; // 0x50
        public System.Nullable`1<ulong> ÏÎÏÌÎÍÌÎÏÍÌÌÍÎÍÏÍÍÏÎÍÎÎ; // 0x60
        public System.Nullable`1<ulong> ÍÍÌÎÏÌÌÍÏÍÍÎÎÎÏÏÍÌÏÌÏÍÎ; // 0x70
        public 0x664D9370 ÌÎÍÏÏÏÍÎÍÏÏÌÎÎÏÏÍÏÏÎÎÎÎ; // 0x80
        public System.Threading.Thread ÎÌÌÌÍÍÏÌÎÏÏÍÌÏÎÍÌÌÍÎÏÏÍ; // 0x88
        public System.Collections.Concurrent.BlockingCollection`1<System.ValueTuple`2<System.Func`1<object>,System.Threading.Tasks.TaskCompletionSource`1<object>>> ÎÏÏÎÌÏÎÎÌÌÌÏÏÍÏÏÌÏÎÍÎÍÏ; // 0x90
        public int ÌÎÍÏÎÌÏÍÏÍÍÍÌÌÍÎÎÎÍÎÌÎÍ;
        public long ÏÌÏÌÌÌÌÎÎÍÎÍÏÎÍÍÍÏÌÏÎÌÎ; // 0x98
        public VRC.Profiling.ProfilerMarker ÌÎÍÏÌÏÌÌÏÎÌÌÍÍÎÍÌÎÍÍÏÍÎ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4F094470
        public void Equals(){} // RVA: 0x7FFD4F094740
        public void GetHashCode(){} // RVA: 0x7FFD4F094780
        public void op_Implicit(){} // RVA: 0x7FFD4F0949B0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4F094A90
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4F094B20
        public void Dispose(){} // RVA: 0x7FFD4F094C30
        public void Cleanup(){} // RVA: 0x7FFD4F094D40
        public void set_name(){} // RVA: 0x7FFD4F094740
        public void Instantiate(){} // RVA: 0x7FFD4F094E20
        public void get_ValueToAppear(){} // RVA: 0x7FFD4E35C4E0
        public void ToString(){} // RVA: 0x7FFD4F0950B0
        public void StopCoroutine(){} // RVA: 0x7FFD4F0953E0
        public void Initialize(){} // RVA: 0x7FFD4F095480
        public void ComputeCustomData(){} // RVA: 0x7FFD4F095620
        public void GetTransform_EBA(){} // RVA: 0x7FFD4F0958F0
        public void CopyTo_873D11B3F9C5(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void set_useGUILayout(){} // RVA: 0x7FFD4F095B60
        public void print(){} // RVA: 0x7FFD4F095E20
        public void Destroy(){} // RVA: 0x7FFD4F0960F0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFD4F096130
        public void DestroyImmediate(){} // RVA: 0x7FFD4F096280
        public void Awake(){} // RVA: 0x7FFD4F096430
        public void FindObjectsOfType(){} // RVA: 0x7FFD4F0977D0
        public void FindObjectsByType(){} // RVA: 0x7FFD4F097880
        public void Equals_C5A872A00592(){} // RVA: 0x7FFD4F097920
        public void DontDestroyOnLoad(){} // RVA: 0x7FFD4F097A70
        public void get_hideFlags(){} // RVA: 0x7FFD4F097DB0
        public void set_hideFlags(){} // RVA: 0x7FFD4E341320
        public void GetGameObject_C8F(){} // RVA: 0x7FFD4F097FE0
        public void SetReadOnlyState(){} // RVA: 0x7FFD4E35C4F0
        public void FindFirstObjectByType(){} // RVA: 0x7FFD4F0983C0
        public void OnBecameInvisible(){} // RVA: 0x7FFD4F098560
        public void CheckNullArgument(){} // RVA: 0x7FFD4F098A50
        public void .cctor(){} // RVA: 0x7FFD4F0995B0
        public void OnCollisionExit(){} // RVA: 0x7FFD4F099690
        public void .ctor(){} // RVA: 0x7FFD4F099A40
        public void OnTriggerStay(){} // RVA: 0x7FFD4F099BC0
        public void VisitMemberListBinding(){} // RVA: 0x7FFD4F099C10
        public void op_Equality(){} // RVA: 0x7FFD4F099FA0
        public void op_Inequality(){} // RVA: 0x7FFD4F09A020
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFD4F09A1A0
        public void Internal_CloneSingle(){} // RVA: 0x7FFD4F09A4D0
    }

}