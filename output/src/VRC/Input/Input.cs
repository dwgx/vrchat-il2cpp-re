// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Input
// Classes: 17
// Methods: 183

namespace VRC.Input
{
    /// <summary>Originally: ÎÌÏÍÎÏÍÌÏÎÍÎÎÍÌÏÍÍÌÌÏÏÍ</summary>
    public class CursorLockMode : Object
    {
        public ÍÍÏÌÏÍÌÏÍÍÍÎÍÍÍÏÌÍÎÏÍÌÌ _52CC;

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE82D38930
        public void Equals(){} // RVA: 0x7FFE82D38B00
    }

    /// <summary>Originally: ÍÏÏÎÌÎÎÌÍÍÏÌÏÏÎÏÏÎÍÌÏÏÎ</summary>
    public class EGamepadTextInputMode : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    /// <summary>Originally: ÌÌÌÏÌÌÏÏÌÏÏÏÎÏÌÎÍÍÏÌÏÌÏ</summary>
    public class EVRInputError : MonoBehaviour
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    /// <summary>Originally: ÌÍÍÌÏÌÍÏÌÌÏÎÍÌÎÌÍÎÌÌÎÏÎ</summary>
    public class EVRInputFilterCancelType : ValueType
    {
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_19B; // 0x10
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_B2A; // 0x18
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_60D; // 0x20
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_AEE; // 0x28
        public ÏÍÎÏÌÎÍÌÍÏÎÍÌÍÏÍÌÎÎÌÏÎÌ f_A9E; // 0x30

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE810FE7C0
        public void InternalEquals(){} // RVA: 0x7FFE8284EF60
        public void DefaultEquals(){} // RVA: 0x7FFE81161E80
        public void GetHashCode(){} // RVA: 0x7FFE811290C0
        public void InternalGetHashCode(){} // RVA: 0x7FFE81116380
        public void ToString(){} // RVA: 0x7FFE810FCE30
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE811290D0
        // ── Unresolved (hash) ──
        public void m_601(){} // RVA: 0x7FFE810FE7C0
        public void m_81B(){} // RVA: 0x7FFE826F4230
        public void m_048(){} // RVA: 0x7FFE811290D0
        public void m_E46(){} // RVA: 0x7FFE81D7E9E0
        public void m_056(){} // RVA: 0x7FFE826F4210
        public void m_6C1(){} // RVA: 0x7FFE826F4210
        public void m_B0B(){} // RVA: 0x7FFE81116380
        public void m_C44(){} // RVA: 0x7FFE81161E80
        public void m_11E(){} // RVA: 0x7FFE81D7E9E0
        public void m_023(){} // RVA: 0x7FFE810FE7C0
    }

    /// <summary>Originally: ÌÏÎÎÌÎÎÏÏÌÏÌÎÎÎÍÏÌÏÎÍÎÍ</summary>
    public class InputAnalogActionData_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8215AAA0
        public void Equals(){} // RVA: 0x7FFE8215AB70
        public void GetHashCode(){} // RVA: 0x7FFE8215AC40
        public void op_Implicit(){} // RVA: 0x7FFE8215AD10
        public void CompareBaseObjects(){} // RVA: 0x7FFE8215ADE0
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8215AEB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    /// <summary>Originally: ÌÍÍÍÎÎÏÍÏÎÌÌÎÎÌÍÎÍÏÏÏÌÌ</summary>
    public class InputControlBinding : OnScreenControl
    {
        public bool _controlPathInternal; // 0x38
        public float m_MovementRange; // 0x3C
        public string m_ControlPath; // 0x40

        // ── Methods ──
        public void OnDrag(){} // RVA: 0x7FFE81845790
        public void set_controlPath(){} // RVA: 0x7FFE811C3580
        public void get_control(){} // RVA: 0x7FFE8178C5D0
        public void OnPointerDown_D694515A76CE(){} // RVA: 0x7FFE8178C310
        public void set_controlPathInternal(){} // RVA: 0x7FFE81123200
        public void SetupInputControl(){} // RVA: 0x7FFE810FB310
        public void SendValueToControl(){} // RVA: 0x7FFE810FB310
        public void Start(){} // RVA: 0x7FFE81845940
        public void get_HasAnyActive(){} // RVA: 0x7FFE811C3570
        public void .ctor(){} // RVA: 0x7FFE81845B70
        public void Initialize(){} // RVA: 0x7FFE810FB310
        public void OnPointerDown(){} // RVA: 0x7FFE81845BC0
        public void OnPointerUp(){} // RVA: 0x7FFE81845D40
        public void get_magnitude(){} // RVA: 0x7FFE81845DE0
        public void set_controlPathInternal_9C2E5F54EDFD(){} // RVA: 0x7FFE81846010
        public void set_isGrounded(){} // RVA: 0x7FFE818460B0
        public void NeedsSync(){} // RVA: 0x7FFE811C3580
        public void get_controlPathInternal_827B79C9D4C0(){} // RVA: 0x7FFE810FB310
        public void get_controlPathInternal(){} // RVA: 0x7FFE81178740
    }

    /// <summary>Originally: ÌÍÌÏÏÍÌÎÍÏÎÏÎÌÏÏÎÌÏÌÎÎÍ</summary>
    public class InputControlBindingSibling_94CB : InputControlBinding
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81856060
        public void .ctor(){} // RVA: 0x7FFE81845B70
        public void Initialize(){} // RVA: 0x7FFE81856820
        public void OnDestroy(){} // RVA: 0x7FFE81856E00
        // ── 12 unresolved (hash) ──
        public void m_4E4(){} // RVA: 0x7FFE81855E90
        public void m_5D2(){} // RVA: 0x7FFE81856250
        public void m_893(){} // RVA: 0x7FFE818562C0
        public void m_2B9(){} // RVA: 0x7FFE81856500
        public void m_E88(){} // RVA: 0x7FFE818566D0
        // ... 7 more unresolved methods
    }

    /// <summary>Originally: ÌÌÎÏÌÍÏÏÎÌÎÎÌÏÍÎÍÌÏÎÏÌÌ</summary>
    public class InputDigitalActionData_t : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE8215AF80
        public void Equals(){} // RVA: 0x7FFE8215AFD0
        public void op_Implicit(){} // RVA: 0x7FFE8215AFD0
        public void CompareBaseObjects(){} // RVA: 0x7FFE8215AF80
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8215AF80
        public void GetCachedPtr(){} // RVA: 0x7FFE8215AFD0
        public void get_name(){} // RVA: 0x7FFE8215AFD0
    }

    /// <summary>Originally: ÍÍÍÏÏÍÌÌÍÏÏÎÏÍÏÍÍÌÎÌÎÍÎ</summary>
    public class InputOriginInfo_t : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE82DDE040
        public void InternalEquals(){} // RVA: 0x7FFE82DDE0B0
        public void DefaultEquals(){} // RVA: 0x7FFE82DDE1E0
        public void GetHashCode(){} // RVA: 0x7FFE82DDE310
        public void InternalGetHashCode(){} // RVA: 0x7FFE82DDE440
        public void ToString(){} // RVA: 0x7FFE82DDE4B0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82DDE5E0
        public void Dispose(){} // RVA: 0x7FFE82DDE710
    }

    /// <summary>Originally: ÎÌÏÌÏÎÏÌÎÏÌÍÌÏÌÎÍÍÌÍÏÍÎ</summary>
    public class InputPoseActionData_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8215B020
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE8215B1C0
        public void op_Implicit(){} // RVA: 0x7FFE8215B360
        public void CompareBaseObjects(){} // RVA: 0x7FFE8215B500
        public void IsNativeObjectAlive(){} // RVA: 0x7FFE8215B6A0
        public void GetCachedPtr(){} // RVA: 0x7FFE8215B840
    }

    /// <summary>Originally: ÍÌÍÌÌÍÎÏÌÎÍÍÎÍÎÍÎÏÏÌÌÎÍ</summary>
    public class InputSkeletalActionData_t : Object
    {
        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFE8215B9E0
        public void Equals(){} // RVA: 0x7FFE8215B9E0
        public void GetHashCode(){} // RVA: 0x7FFE8215B9E0
        public void op_Implicit(){} // RVA: 0x7FFE8215B9F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE8215B9E0
        public void GetCachedPtr(){} // RVA: 0x7FFE8215C550
        public void get_name(){} // RVA: 0x7FFE8215C560
    }

    /// <summary>Originally: ÌÌÌÏÌÌÎÏÌÎÌÏÎÏÏÌÌÍÌÌÍÎÎ</summary>
    public class UiInputFieldSibling_67F0
    {
        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7FFE80E2E2E0
        public void OnPointerExit(){} // RVA: 0x7FFE80E460A0
        public void OnPointerDown(){} // RVA: 0x7FFE80E45FE0
    }

    /// <summary>Originally: ÌÍÍÍÏÍÌÎÏÎÌÍÎÏÏÌÎÏÍÎÎÏÎ</summary>
    public class VROverlayInputMethod : ValueType
    {
        public System.Nullable`1<ÍÍÌÏÍÏÍÎÌÌÎÍÌÍÏÎÍÎÍÎÏÎÌ> f_D77; // 0x10
        public 0x664F1DB4 f_024; // 0x20

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE8151C410
        public void InternalEquals(){} // RVA: 0x7FFE811485C0
        public void DefaultEquals(){} // RVA: 0x7FFE810FE0C0
        public void GetHashCode(){} // RVA: 0x7FFE82DC95C0
        public void InternalGetHashCode(){} // RVA: 0x7FFE810FE0C0
        public void ToString(){} // RVA: 0x7FFE810FE0C0
        public void GetHashCodeOfPtr(){} // RVA: 0x7FFE82DC95C0
        public void ProcessAsyncOperationData(){} // RVA: 0x7FFE810FE0C0
        public void FindObjectsByType(){} // RVA: 0x7FFE82DC95C0
        public void MoveNext(){} // RVA: 0x7FFE8151C410
        public void ToString_97B77F4DDA91(){} // RVA: 0x7FFE810FE0C0
    }

    /// <summary>Originally: ÎÎÌÍÌÏÏÍÍÍÎÌÌÎÏÏÌÌÌÏÍÎÎ</summary>
    public class clearDisplayplaceholderSiblingSibling_0CFC : MonoBehaviour
    {
        public System.Action _m_CancellationTokenSource; // 0x20
        public System.Action`1<string> f_834; // 0x28

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE82B20A30
        public void RaiseCancellation(){} // RVA: 0x7FFE82B20B20
        public void IsInvoking(){} // RVA: 0x7FFE82B20C10
        public void CancelInvoke(){} // RVA: 0x7FFE82B20D10
        public void Invoke(){} // RVA: 0x7FFE82B20E10
        public void InvokeRepeating(){} // RVA: 0x7FFE82B20F10
        public void ProcessInputAndCallMethod(){} // RVA: 0x7FFE82B21010
        public void StartCoroutine(){} // RVA: 0x7FFE80E45FE0
        public void Construct(){} // RVA: 0x7FFE80E2F150
        public void Initialize(){} // RVA: 0x7FFE80E466C0
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE80E2E2E0
        public void StopCoroutine(){} // RVA: 0x7FFE80E460A0
        public void .ctor_25104E49D39E(){} // RVA: 0x7FFE8148FC70
        public void StopAllCoroutines(){} // RVA: 0x7FFE819208B0
        public void get_useGUILayout(){} // RVA: 0x7FFE82B211F0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        // ── Unresolved (hash) ──
        public void m_D44(){} // RVA: 0x7FFE82B21100
        public void m_8A3(){} // RVA: 0x7FFE81CF80B0
    }

    /// <summary>Originally: ÌÎÏÌÎÌÌÌÎÍÎÎÎÏÍÍÏÍÎÎÎÎÏ</summary>
    public class clearDisplayplaceholderSibling_DDC4
    {
        // ── 11 unresolved (hash) ──
        public void m_467(){} // RVA: 0x7FFE80E460A0
        public void m_BC5(){} // RVA: 0x7FFE80E460A0
        public void m_BEB(){} // RVA: 0x7FFE80E460A0
        public void m_EAA(){} // RVA: 0x7FFE80E460A0
        public void m_F83(){} // RVA: 0x7FFE80E460A0
        // ... 6 more unresolved methods
    }

    /// <summary>Originally: ÎÍÎÌÍÏÏÌÏÏÍÏÎÍÌÎÎÌÌÍÎÏÍ</summary>
    public class clearDisplayplaceholder_53F5 : clearDisplayplaceholderSiblingSibling_0CFC
    {
        public TMPro.TextMeshProUGUI _placeholder; // 0x40
        public TMPro.TextMeshProUGUI _displayText; // 0x48
        public UnityEngine.GameObject _clearDisplay; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89976160
        public void Initialize(){} // RVA: 0x7FFE89976230
        public void OnDestroy(){} // RVA: 0x7FFE89976770
        public void Awake(){} // RVA: 0x7FFE899771F0
        // ── 19 unresolved (hash) ──
        public void m_49D(){} // RVA: 0x7FFE82B211F0
        public void m_4B9(){} // RVA: 0x7FFE811C3500
        public void m_94C(){} // RVA: 0x7FFE82B211F0
        public void m_B66(){} // RVA: 0x7FFE89976260
        public void m_7B1(){} // RVA: 0x7FFE8253AF90
        // ... 14 more unresolved methods
    }

    /// <summary>Originally: ÎÍÌÏÏÌÌÍÌÎÎÏÍÌÏÎÍÍÍÌÏÍÌ</summary>
    public class leftCursorTextComponent_36A7 : MonoBehaviour
    {
        public ÏÏÏÎÏÌÍÏÎÎÍÌÍÌÎÎÏÎÎÌÌÍÌ _m_CancellationTokenSource; // 0x20
        public bool f_C7B; // 0x28
        public bool f_D0E; // 0x29
        public TMPro.TextMeshPro leftCursorText; // 0x30

        // ── Methods ──
        public void get_destroyCancellationToken(){} // RVA: 0x7FFE81199250
        public void RaiseCancellation(){} // RVA: 0x7FFE817D7E20
        public void OnDestroy(){} // RVA: 0x7FFE817D7E90
        public void CancelInvoke(){} // RVA: 0x7FFE817D8140
        public void Invoke(){} // RVA: 0x7FFE817D81A0
        public void OnCollisionEnter(){} // RVA: 0x7FFE817DC1E0 | overloaded x2
        public void Update(){} // RVA: 0x7FFE817DADE0
        public void LateUpdate(){} // RVA: 0x7FFE817DB320
        public void StartCoroutine(){} // RVA: 0x7FFE817DB5F0
        public void Start(){} // RVA: 0x7FFE817DB650
        public void OnTriggerEnter(){} // RVA: 0x7FFE817DBB90
        public void StartCoroutine_Auto(){} // RVA: 0x7FFE817DBBD0
        public void StopCoroutine(){} // RVA: 0x7FFE817DBC30
        public void OnBecameInvisible(){} // RVA: 0x7FFE817DBD50
        public void StopAllCoroutines(){} // RVA: 0x7FFE817DC3F0
        public void .ctor(){} // RVA: 0x7FFE817DC450
        public void Initialize(){} // RVA: 0x7FFE817DC550
        public void print(){} // RVA: 0x7FFE817DC5B0
        public void Internal_CancelInvokeAll(){} // RVA: 0x7FFE81199240
        public void Internal_IsInvokingAll(){} // RVA: 0x7FFE815F1380
        public void InvokeDelayed(){} // RVA: 0x7FFE817DC610
        // ── Unresolved (hash) ──
        public void m_0AD(){} // RVA: 0x7FFE817DC6B0
    }

}