// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Input
// Classes: 7
// Methods: 113

namespace VRC.Input
{
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

    /// <summary>Originally: ÌÌÌÏÌÌÎÏÌÎÌÏÎÏÏÌÌÍÌÌÍÎÎ</summary>
    public class UiInputFieldSibling_67F0
    {
        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7FFE80E2E2E0
        public void OnPointerExit(){} // RVA: 0x7FFE80E460A0
        public void OnPointerDown(){} // RVA: 0x7FFE80E45FE0
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