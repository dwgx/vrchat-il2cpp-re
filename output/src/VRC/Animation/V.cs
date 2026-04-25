// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Animation
// Classes: 2
// Methods: 122

namespace VRC.Animation
{
    /// <summary>Originally: ÍÌÌÏÌÌÏÌÌÌÏÌÍÍÌÌÎÎÌÌÍÏÎ</summary>
    public class VRCMotionStateSibling_3B68_3B68 : Object
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
        public 0x6B179370 ÌÎÍÏÏÏÍÎÍÏÏÌÎÎÏÏÍÏÏÎÎÎÎ; // 0x80
        public System.Threading.Thread ÎÌÌÌÍÍÏÌÎÏÏÍÌÏÎÍÌÌÍÎÏÏÍ; // 0x88
        public System.Collections.Concurrent.BlockingCollection`1<System.ValueTuple`2<System.Func`1<object>,System.Threading.Tasks.TaskCompletionSource`1<object>>> ÎÏÏÎÌÏÎÎÌÌÌÏÏÍÏÏÌÏÎÍÎÍÏ; // 0x90
        public int ÌÎÍÏÎÌÏÍÏÍÍÍÌÌÍÎÎÎÍÎÌÎÍ;
        public long ÏÌÏÌÌÌÌÎÎÍÎÍÏÎÍÍÍÏÌÏÎÌÎ; // 0x98
        public VRC.Profiling.ProfilerMarker ÌÎÍÏÌÏÌÌÏÎÌÌÍÍÎÍÌÎÍÍÏÍÎ;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFAC3C74470
        public void Equals(){} // RVA: 0x7FFAC3C74740
        public void GetHashCode(){} // RVA: 0x7FFAC3C74780
        public void op_Implicit(){} // RVA: 0x7FFAC3C749B0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC3C74A90
        public void IsNativeObjectAlive(){} // RVA: 0x7FFAC3C74B20
        public void Dispose(){} // RVA: 0x7FFAC3C74C30
        public void Cleanup(){} // RVA: 0x7FFAC3C74D40
        public void set_name(){} // RVA: 0x7FFAC3C74740
        public void Instantiate(){} // RVA: 0x7FFAC3C74E20
        public void get_ValueToAppear(){} // RVA: 0x7FFAC2F3C4E0
        public void ToString(){} // RVA: 0x7FFAC3C750B0
        public void StopCoroutine(){} // RVA: 0x7FFAC3C753E0
        public void Initialize(){} // RVA: 0x7FFAC3C75480
        public void ComputeCustomData(){} // RVA: 0x7FFAC3C75620
        public void GetTransform_EBA(){} // RVA: 0x7FFAC3C758F0
        public void CopyTo_873D11B3F9C5_873D11B3F9C5(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void set_useGUILayout(){} // RVA: 0x7FFAC3C75B60
        public void print(){} // RVA: 0x7FFAC3C75E20
        public void Destroy(){} // RVA: 0x7FFAC3C760F0
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC3C76130
        public void DestroyImmediate(){} // RVA: 0x7FFAC3C76280
        public void Awake(){} // RVA: 0x7FFAC3C76430
        public void FindObjectsOfType(){} // RVA: 0x7FFAC3C777D0
        public void FindObjectsByType(){} // RVA: 0x7FFAC3C77880
        public void Equals_C5A872A00592(){} // RVA: 0x7FFAC3C77920
        public void DontDestroyOnLoad(){} // RVA: 0x7FFAC3C77A70
        public void get_hideFlags(){} // RVA: 0x7FFAC3C77DB0
        public void set_hideFlags(){} // RVA: 0x7FFAC2F21320
        public void GetGameObject_C8F(){} // RVA: 0x7FFAC3C77FE0
        public void SetReadOnlyState(){} // RVA: 0x7FFAC2F3C4F0
        public void FindFirstObjectByType(){} // RVA: 0x7FFAC3C783C0
        public void OnBecameInvisible(){} // RVA: 0x7FFAC3C78560
        public void CheckNullArgument(){} // RVA: 0x7FFAC3C78A50
        public void .cctor(){} // RVA: 0x7FFAC3C795B0
        public void OnCollisionExit(){} // RVA: 0x7FFAC3C79690
        public void .ctor(){} // RVA: 0x7FFAC3C79A40
        public void OnTriggerStay(){} // RVA: 0x7FFAC3C79BC0
        public void VisitMemberListBinding(){} // RVA: 0x7FFAC3C79C10
        public void op_Equality(){} // RVA: 0x7FFAC3C79FA0
        public void op_Inequality(){} // RVA: 0x7FFAC3C7A020
        public void GetOffsetOfInstanceIDInCPlusPlusObject(){} // RVA: 0x7FFAC3C7A1A0
        public void Internal_CloneSingle(){} // RVA: 0x7FFAC3C7A4D0
    }

    /// <summary>Originally: ÌÌÍÌÌÏÎÎÏÎÌÏÍÏÍÌÌÌÌÏÎÌÍ</summary>
    public class VRCMotionState_8C34 : MonoBehaviour
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
        public 0x6AFF2FE8 ÏÌÎÌÎÍÎÍÎÏÍÌÎÎÍÌÌÎÌÏÌÎÎ; // 0x70
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
        public void get_destroyCancellationToken(){} // RVA: 0x7FFAC3B8D2D0
        public void RaiseCancellation(){} // RVA: 0x7FFAC3B8D460
        public void IsInvoking(){} // RVA: 0x7FFAC3B8D4E0
        public void CancelInvoke(){} // RVA: 0x7FFAC3B8D660
        public void Invoke(){} // RVA: 0x7FFAC3B8DAE0
        public void InvokeRepeating(){} // RVA: 0x7FFAC3B8DB30
        public void CancelInvoke_0DE2DEACF794(){} // RVA: 0x7FFAC3B8DB50
        public void OnEnable(){} // RVA: 0x7FFAC3B8DBF0
        public void StartCoroutine(){} // RVA: 0x7FFAC3B8DD20
        public void SetCullingMode(){} // RVA: 0x7FFAC3B8DEB0
        public void SetUpdateMode(){} // RVA: 0x7FFAC3B8E330
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC3B8E370
        public void StopCoroutine(){} // RVA: 0x7FFAC3B8E640
        public void MakeReadOnly(){} // RVA: 0x7FFAC3B8E650
        public void OnApplicationPause(){} // RVA: 0x7FFAC3B8E660
        public void StopAllCoroutines(){} // RVA: 0x7FFAC3B8E6B0
        public void LateUpdate(){} // RVA: 0x7FFAC3B8E880
        public void set_useGUILayout(){} // RVA: 0x7FFAC3B8FA00
        public void print(){} // RVA: 0x7FFAC3B90F70
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFAC3B91460
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFAC3B91470
        public void InvokeDelayed(){} // RVA: 0x7FFAC3B8E640
        public void Awake(){} // RVA: 0x7FFAC3B914E0
        public void OnTriggerExit(){} // RVA: 0x7FFAC3B91530
        public void IsObjectMonoBehaviour(){} // RVA: 0x7FFAC3B91590
        public void StartCoroutineManaged(){} // RVA: 0x7FFAC3B915A0
        public void StartCoroutineManaged2(){} // RVA: 0x7FFAC3B915B0
        public void StopCoroutineManaged(){} // RVA: 0x7FFAC3B91680
        public void StopCoroutineFromEnumeratorManaged(){} // RVA: 0x7FFAC3B91690
        public void GetScriptClassName(){} // RVA: 0x7FFAC3B916A0
        public void .ctor(){} // RVA: 0x7FFAC3B91B30
        public void Initialize(){} // RVA: 0x7FFAC3B91BB0
        public void OnBecameVisible(){} // RVA: 0x7FFAC3B920A0
        public void OnBecameInvisible(){} // RVA: 0x7FFAC3B92520
        public void OnDestroy(){} // RVA: 0x7FFAC3B92C40
        public void OnCollisionStay(){} // RVA: 0x7FFAC3B92D20
        public void OnCollisionExit(){} // RVA: 0x7FFAC3B93210
        public void Start(){} // RVA: 0x7FFAC3B94290
        public void OnTriggerStay(){} // RVA: 0x7FFAC3B94970
        public void OnCollisionEnter(){} // RVA: 0x7FFAC3B94B20
        public void FixedUpdate(){} // RVA: 0x7FFAC3B95930
        public void GetGameObject_575(){} // RVA: 0x7FFAC3B95950
        public void OnTriggerEnter(){} // RVA: 0x7FFAC3B959A0
        public void OnDisable_04AE7334EA30(){} // RVA: 0x7FFAC3B95A00
        public void OnBecameInvisible_6E9AEE30D9A6(){} // RVA: 0x7FFAC3B95A10
        public void OnApplicationPause_06D62653B906(){} // RVA: 0x7FFAC3B95A20
        public void Reset(){} // RVA: 0x7FFAC3B95AA0
        public void HasKey(){} // RVA: 0x7FFAC3B95D60
        public void Update(){} // RVA: 0x7FFAC3B95E50
        public void op_Implicit(){} // RVA: 0x7FFAC3B965A0
        public void SetMotionStateAndPropagate(){} // RVA: 0x7FFAC3B96780
        public void ComputeMotionVector(){} // RVA: 0x7FFAC3B95A00
        public void StopMotionStateCallbacks(){} // RVA: 0x7FFAC3B96790
        public void OnTriggerStay_11D63005E3E1(){} // RVA: 0x7FFAC3B97AA0
        public void GetTransform_A56(){} // RVA: 0x7FFAC3B97D70
        public void OnDisable(){} // RVA: 0x7FFAC3B97DA0
        public void get_ValidExpressions(){} // RVA: 0x7FFAC300F9D0
        public void OnDrawGizmos(){} // RVA: 0x7FFAC3B97ED0
        public void GetGameObject_8B8(){} // RVA: 0x7FFAC3B983D0
        public void SetActive_5BF(){} // RVA: 0x7FFAC3B988C0
        public void SetActive_5BF_01B377A94A90(){} // RVA: 0x7FFAC3B98920
        public void SetActive_5BF_FDF97024CBB8(){} // RVA: 0x7FFAC3B98980
        public void OnCollisionStay_12005D1E7E7D(){} // RVA: 0x7FFAC3B92D20
        public void StopCoroutine_49ACFF36B700(){} // RVA: 0x7FFAC3B8E640
        public void SetActive_5BF_2351694FB014(){} // RVA: 0x7FFAC3B989B0
        public void Update_3B051D19CE57(){} // RVA: 0x7FFAC3B98E20
        public void Awake_8C42CBD39D8E(){} // RVA: 0x7FFAC3B98E80
        public void InitializeMotionState(){} // RVA: 0x7FFAC3B992F0
        public void CompareBaseObjects(){} // RVA: 0x7FFAC3B99430
        public void ProcessRemoteStringVariables(){} // RVA: 0x7FFAC3B994A0
        public void Awake_D528744CDC34(){} // RVA: 0x7FFAC3B99990
        public void get_ElementCount(){} // RVA: 0x7FFAC3B99E80
        public void get_ElementCount_B3683F4A0F7A(){} // RVA: 0x7FFAC3B99E90
        public void DisposeNetworkObject(){} // RVA: 0x7FFAC3B99F80
        public void CancelPendingMotionInvoke(){} // RVA: 0x7FFAC3B9A7D0
        public void KeyTooManyColumns(){} // RVA: 0x7FFAC3B9A900
        public void CancelMotionStateInvoke(){} // RVA: 0x7FFAC3B9A910
        public void GetParameterizedConstructor(){} // RVA: 0x7FFAC3B9B720
    }

}