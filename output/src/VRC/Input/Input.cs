// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Input
// Classes: 6
// Methods: 92

namespace VRC.Input
{
    /// <summary>Originally: ÏÍÏÌÌÌÎÏÌÌÌÍÎÌÏÏÏÍÏÌÏÌÍ</summary>
    public class BaseInputOverride_B772 : MonoBehaviour
    {
        public UnityEngine.Object[] compositionString; // 0x20

        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor_98608C65CB2A(){} // RVA: 0x7FFAC2F4F0C0
        public void IsInvoking(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void Initialize(){} // RVA: 0x7FFAC2F4F0C0
        public void InvokeRepeating(){} // RVA: 0x7FFAC2F4F0C0
        public void CancelInvoke(){} // RVA: 0x7FFAC2F4F0C0
        public void ProcessImageInvocation(){} // RVA: 0x7FFAC2F4F0C0
    }

    /// <summary>Originally: ÎÎÎÍÎÏÍÎÍÍÌÍÌÍÏÎÍÍÌÌÎÍÏ</summary>
    public class InputControlBindingSibling_89E1_89E1 : InputControlBinding_C39B
    {
        public UnityEngine.RectTransform ÎÍÌÎÌÎÍÍÎÏÏÎÌÏÏÏÍÍÎÏÏÎÍ; // 0x70
        public UnityEngine.RectTransform ÏÎÍÎÎÍÍÏÍÍÏÎÎÎÎÎÌÍÏÌÍÎÏ; // 0x78
        public UnityEngine.Vector3 ÍÌÎÍÌÌÏÏÏÍÍÎÎÍÎÎÌÎÏÍÌÎÎ; // 0x80
        public bool ÍÏÎÏÌÌÎÏÍÎÎÏÍÏÌÎÍÏÏÏÌÏÎ; // 0x8C
        public UnityEngine.Vector2 stickPosLandscape; // 0x90
        public UnityEngine.Vector2 stickPosPortrait; // 0x98

        // ── Methods ──
        public void GetGameObject_B0F(){} // RVA: 0x7FFAC3707EF0
        public void set_controlPath(){} // RVA: 0x7FFAC3708130
        public void .ctor(){} // RVA: 0x7FFAC36F6E90
        public void OnDestroy(){} // RVA: 0x7FFAC3708210
        public void SendValueToControl(){} // RVA: 0x7FFAC3708310
        public void Initialize(){} // RVA: 0x7FFAC37084E0
        public void SendValueToControl_EEF0D1314C9C(){} // RVA: 0x7FFAC3708550
        public void Start(){} // RVA: 0x7FFAC3708650
        public void set_scrollSpeed(){} // RVA: 0x7FFAC3708840
        public void OnEnable(){} // RVA: 0x7FFAC3708940
        public void OnDisable(){} // RVA: 0x7FFAC3708B80
        public void Computetime(){} // RVA: 0x7FFAC3708B90
        public void SetStartColor(){} // RVA: 0x7FFAC3708C00
        public void get_magnitude(){} // RVA: 0x7FFAC3708DD0
    }

    /// <summary>Originally: ÌÌÏÌÏÌÏÏÎÏÎÌÌÌÍÌÎÍÌÎÍÎÏ</summary>
    public class InputControlBinding_C39B : OnScreenControl
    {
        public bool _controlPathInternal; // 0x38
        public float _control; // 0x3C
        public string _controlPathInternal2; // 0x40
        public UnityEngine.Vector2 ÎÌÏÏÎÌÌÎÌÏÌÍÏÍÌÎÍÏÌÌÎÎÏ; // 0x48
        public UnityEngine.Vector3 ÏÌÎÌÌÏÏÎÏÌÎÏÏÏÎÌÏÍÎÎÎÌÌ; // 0x50
        public UnityEngine.RectTransform ÍÎÍÎÎÎÍÍÏÎÌÍÍÎÍÌÌÍÏÍÍÍÎ; // 0x60
        public bool <ÍÎÎÎÎÏÍÍÏÍÌÏÎÍÏÎÍÌÎÏÏÌÎ>k__BackingField; // 0x68

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC36F6930
        public void set_controlPath(){} // RVA: 0x7FFAC36F6B60
        public void get_control(){} // RVA: 0x7FFAC2F21310
        public void OnPointerDown(){} // RVA: 0x7FFAC36F6D10
        public void .ctor(){} // RVA: 0x7FFAC36F6E90
        public void Initialize(){} // RVA: 0x7FFAC36F6EE0
        public void SendValueToControl(){} // RVA: 0x7FFAC2F21310
        public void OnDrag(){} // RVA: 0x7FFAC36F7060
        public void set_scrollSpeed(){} // RVA: 0x7FFAC363C6C0
        public void OnEnable(){} // RVA: 0x7FFAC36F7210
        public void OnDisable(){} // RVA: 0x7FFAC363C6C0
        public void GetWarningMessage(){} // RVA: 0x7FFAC36F72B0
        public void SetStartColor(){} // RVA: 0x7FFAC36F73B0
        public void get_magnitude(){} // RVA: 0x7FFAC363CE20
        public void set_controlPathInternal(){} // RVA: 0x7FFAC2F49200
        public void set_isGrounded(){} // RVA: 0x7FFAC2FE9580
        public void NeedsSync(){} // RVA: 0x7FFAC2FE9570
        public void get_controlPathInternal(){} // RVA: 0x7FFAC2F9E740
        public void SetEndColor(){} // RVA: 0x7FFAC36F74B0
        public void OnPointerUp(){} // RVA: 0x7FFAC36F76E0
    }

    /// <summary>Originally: ÍÍÎÍÌÏÎÌÏÎÍÌÏÎÎÍÌÏÍÏÏÏÌ</summary>
    public class InputFieldDerived_866B_866B : InputField
    {
        public int _input; // 0x228
        public int _compositionString; // 0x22C
        public int _mesh; // 0x230
        public int _cachedInputTextGenerator; // 0x234
        public float _shouldHideMobileInput; // 0x238
        public float _shouldActivateOnSelect; // 0x23C
        public ÏÌÍÍÏÍÌÏÏÌÍÎÍÎÍÍÍÎÌÌÎÌÏ _plusButton; // 0x240
        public ÏÌÍÍÏÍÌÏÏÌÍÎÍÎÍÍÍÎÌÌÎÌÏ _minusButton; // 0x248
        public UnityEngine.Events.UnityEvent`1<int> ÌÎÎÏÌÎÎÍÏÌÌÌÍÌÍÌÎÌÍÍÍÌÏ; // 0x250
        public UnityEngine.Events.UnityEvent`1<int> ÍÎÏÎÌÍÎÍÏÏÌÌÏÌÍÎÍÍÍÌÎÍÎ; // 0x258
        public UnityEngine.Events.UnityEvent ÏÌÌÍÌÍÎÎÍÏÏÏÍÍÌÎÎÌÍÎÍÍÏ; // 0x260
        public UnityEngine.Events.UnityEvent ÎÎÌÏÎÌÎÌÏÏÌÍÌÍÎÍÎÏÎÌÌÎÏ; // 0x268
        public System.Collections.IEnumerator ÏÎÏÏÌÎÍÏÎÏÎÍÏÍÏÌÍÌÌÏÍÌÏ; // 0x270

        // ── Methods ──
        public void get_input(){} // RVA: 0x7FFAC44F86F0
        public void Start(){} // RVA: 0x7FFAC44F88E0
        public void get_centerEyeAngularAcceleration(){} // RVA: 0x7FFAC39C9150
        public void get_mesh(){} // RVA: 0x7FFAC44F8AE0
        public void get_RefundTokens(){} // RVA: 0x7FFAC44F8B10
        public void set_shouldHideMobileInput(){} // RVA: 0x7FFAC44F8B20
        public void get_shouldHideMobileInput(){} // RVA: 0x7FFAC44F8B30
        public void set_shouldActivateOnSelect(){} // RVA: 0x7FFAC44F9010
        public void get_shouldActivateOnSelect(){} // RVA: 0x7FFAC44F8B20
        public void OnDestroy(){} // RVA: 0x7FFAC44F90B0
        public void set_text(){} // RVA: 0x7FFAC44F9270
        public void SetTextWithoutNotify(){} // RVA: 0x7FFAC44F9380
        public void SetText(){} // RVA: 0x7FFAC44F9400
        public void get_isFocused(){} // RVA: 0x7FFAC44F9460
        public void get_caretBlinkRate(){} // RVA: 0x7FFAC44F94C0
        public void set_caretBlinkRate(){} // RVA: 0x7FFAC44F8B10
        public void get_caretWidth(){} // RVA: 0x7FFAC44F9550
        public void get_StereoRendering(){} // RVA: 0x7FFAC44F95E0
        public void set_CubemapFaceResolution(){} // RVA: 0x7FFAC44F95F0
        public void .ctor(){} // RVA: 0x7FFAC44F9600
        public void Initialize(){} // RVA: 0x7FFAC44F9970
        public void set_placeholder(){} // RVA: 0x7FFAC44F9460
        public void get_CubemapFaceResolution(){} // RVA: 0x7FFAC44F99D0
        public void set_caretColor(){} // RVA: 0x7FFAC44F99E0
        public void get_customCaretColor(){} // RVA: 0x7FFAC44F9A60
        public void get_NetworkStatusListener(){} // RVA: 0x7FFAC39A6830
        public void set_RefundTokens(){} // RVA: 0x7FFAC44F9B00
        public void set_CubemapDepthResolution(){} // RVA: 0x7FFAC44F9B10
        public void get_onEndEdit(){} // RVA: 0x7FFAC44F9B20
        public void set_onEndEdit(){} // RVA: 0x7FFAC44F9380
        public void get_onSubmit(){} // RVA: 0x7FFAC44F9BC0
        public void get_CubemapDepthResolution(){} // RVA: 0x7FFAC44FA0A0
        public void get_onValueChange(){} // RVA: 0x7FFAC44FA0B0
        public void set_onValueChange(){} // RVA: 0x7FFAC44FA130
        public void get_onValueChanged(){} // RVA: 0x7FFAC44FA1C0
    }

    /// <summary>Originally: ÌÎÍÌÏÍÎÌÏÎÎÎÍÎÍÍÏÏÏÏÏÎÎ</summary>
    public class UiInputFieldSibling_8FDB
    {
        public object _8FDB;

        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7FFAC2C58E90
        public void OnPointerExit(){} // RVA: 0x7FFAC2C70A40
        public void OnPointerDown(){} // RVA: 0x7FFAC2C70980
    }

    /// <summary>Originally: ÍÌÍÌÍÏÎÍÎÌÌÎÌÏÎÎÏÍÎÎÍÌÌ</summary>
    public class VRCInputFieldKeyboardOverride_9D49 : MonoBehaviour
    {
        public UnityEngine.Color32 ÌÎÎÍÏÍÎÌÌÎÏÏÎÌÍÍÌÎÏÎÎÎÏ; // 0x20
        public ÌÏÎÌÌÌÎÍÎÎÏÌÏÌÎÌÎÌÍÎÎÌÌ ÎÏÏÍÍÏÎÍÏÎÌÌÍÍÍÎÍÍÏÏÍÌÌ; // 0x28
        public VRC.Localization.LocalizableString ÍÏÌÍÎÎÌÌÎÏÎÌÎÎÍÏÌÌÏÎÎÎÍ; // 0x30

        // ── Methods ──
        public void get_OverrideBehavior(){} // RVA: 0x7FFAC42F6A10
        public void .ctor_9DEE68E37762(){} // RVA: 0x7FFAC30DBBE0
        public void IsInvoking(){} // RVA: 0x7FFAC30DBBE0
        public void CancelInvoke(){} // RVA: 0x7FFAC42F6E10
        public void Invoke(){} // RVA: 0x7FFAC42F7210
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void OnEnable(){} // RVA: 0x7FFAC42F7320
        public void OnDisable(){} // RVA: 0x7FFAC42F7340
        public void StartCoroutine(){} // RVA: 0x7FFAC42F75A0
        public void Update(){} // RVA: 0x7FFAC42F76D0
        public void LateUpdate(){} // RVA: 0x7FFAC42F7800
        public void StartCoroutine_Auto(){} // RVA: 0x7FFAC42F7C00
    }

}