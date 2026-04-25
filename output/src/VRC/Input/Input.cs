// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Input
// Classes: 4
// Methods: 72

namespace VRC.Input
{
    /// <summary>Originally: ÌÌÏÌÏÌÏÏÎÏÎÌÌÌÍÌÎÍÌÎÍÎÏ</summary>
    public class InputControlBinding : OnScreenControl
    {
        public bool _controlPathInternal; // 0x38
        public float _control; // 0x3C
        public string _controlPathInternal2; // 0x40
        public UnityEngine.Vector2 ÎÌÏÏÎÌÌÎÌÏÌÍÏÍÌÎÍÏÌÌÎÎÏ; // 0x48
        public UnityEngine.Vector3 ÏÌÎÌÌÏÏÎÏÌÎÏÏÏÎÌÏÍÎÎÎÌÌ; // 0x50
        public UnityEngine.RectTransform ÍÎÍÎÎÎÍÍÏÎÌÍÍÎÍÌÌÍÏÍÍÍÎ; // 0x60
        public bool <ÍÎÎÎÎÏÍÍÏÍÌÏÎÍÏÎÍÌÎÏÏÌÎ>k__BackingField; // 0x68

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4EB16930
        public void set_controlPath(){} // RVA: 0x7FFD4EB16B60
        public void get_control(){} // RVA: 0x7FFD4E341310
        public void OnPointerDown(){} // RVA: 0x7FFD4EB16D10
        public void .ctor(){} // RVA: 0x7FFD4EB16E90
        public void Initialize(){} // RVA: 0x7FFD4EB16EE0
        public void SendValueToControl(){} // RVA: 0x7FFD4E341310
        public void OnDrag(){} // RVA: 0x7FFD4EB17060
        public void set_scrollSpeed(){} // RVA: 0x7FFD4EA5C6C0
        public void OnEnable(){} // RVA: 0x7FFD4EB17210
        public void OnDisable(){} // RVA: 0x7FFD4EA5C6C0
        public void GetWarningMessage(){} // RVA: 0x7FFD4EB172B0
        public void SetStartColor(){} // RVA: 0x7FFD4EB173B0
        public void get_magnitude(){} // RVA: 0x7FFD4EA5CE20
        public void set_controlPathInternal(){} // RVA: 0x7FFD4E369200
        public void set_isGrounded(){} // RVA: 0x7FFD4E409580
        public void NeedsSync(){} // RVA: 0x7FFD4E409570
        public void get_controlPathInternal(){} // RVA: 0x7FFD4E3BE740
        public void SetEndColor(){} // RVA: 0x7FFD4EB174B0
        public void OnPointerUp(){} // RVA: 0x7FFD4EB176E0
    }

    /// <summary>Originally: ÎÎÎÍÎÏÍÎÍÍÌÍÌÍÏÎÍÍÌÌÎÍÏ</summary>
    public class InputControlBindingSibling_89E1 : InputControlBinding
    {
        public UnityEngine.RectTransform ÎÍÌÎÌÎÍÍÎÏÏÎÌÏÏÏÍÍÎÏÏÎÍ; // 0x70
        public UnityEngine.RectTransform ÏÎÍÎÎÍÍÏÍÍÏÎÎÎÎÎÌÍÏÌÍÎÏ; // 0x78
        public UnityEngine.Vector3 ÍÌÎÍÌÌÏÏÏÍÍÎÎÍÎÎÌÎÏÍÌÎÎ; // 0x80
        public bool ÍÏÎÏÌÌÎÏÍÎÎÏÍÏÌÎÍÏÏÏÌÏÎ; // 0x8C
        public UnityEngine.Vector2 stickPosLandscape; // 0x90
        public UnityEngine.Vector2 stickPosPortrait; // 0x98

        // ── Methods ──
        public void GetGameObject_B0F(){} // RVA: 0x7FFD4EB27EF0
        public void set_controlPath(){} // RVA: 0x7FFD4EB28130
        public void .ctor(){} // RVA: 0x7FFD4EB16E90
        public void OnDestroy(){} // RVA: 0x7FFD4EB28210
        public void SendValueToControl(){} // RVA: 0x7FFD4EB28310
        public void Initialize(){} // RVA: 0x7FFD4EB284E0
        public void SendValueToControl_EEF0D1314C9C(){} // RVA: 0x7FFD4EB28550
        public void Start(){} // RVA: 0x7FFD4EB28650
        public void set_scrollSpeed(){} // RVA: 0x7FFD4EB28840
        public void OnEnable(){} // RVA: 0x7FFD4EB28940
        public void OnDisable(){} // RVA: 0x7FFD4EB28B80
        public void Computetime(){} // RVA: 0x7FFD4EB28B90
        public void SetStartColor(){} // RVA: 0x7FFD4EB28C00
        public void get_magnitude(){} // RVA: 0x7FFD4EB28DD0
    }

    /// <summary>Originally: ÍÍÎÍÌÏÎÌÏÎÍÌÏÎÎÍÌÏÍÏÏÏÌ</summary>
    public class InputFieldDerived_866B : InputField
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
        public void get_input(){} // RVA: 0x7FFD4F9186F0
        public void Start(){} // RVA: 0x7FFD4F9188E0
        public void get_centerEyeAngularAcceleration(){} // RVA: 0x7FFD4EDE9150
        public void get_mesh(){} // RVA: 0x7FFD4F918AE0
        public void get_RefundTokens(){} // RVA: 0x7FFD4F918B10
        public void set_shouldHideMobileInput(){} // RVA: 0x7FFD4F918B20
        public void get_shouldHideMobileInput(){} // RVA: 0x7FFD4F918B30
        public void set_shouldActivateOnSelect(){} // RVA: 0x7FFD4F919010
        public void get_shouldActivateOnSelect(){} // RVA: 0x7FFD4F918B20
        public void OnDestroy(){} // RVA: 0x7FFD4F9190B0
        public void set_text(){} // RVA: 0x7FFD4F919270
        public void SetTextWithoutNotify(){} // RVA: 0x7FFD4F919380
        public void SetText(){} // RVA: 0x7FFD4F919400
        public void get_isFocused(){} // RVA: 0x7FFD4F919460
        public void get_caretBlinkRate(){} // RVA: 0x7FFD4F9194C0
        public void set_caretBlinkRate(){} // RVA: 0x7FFD4F918B10
        public void get_caretWidth(){} // RVA: 0x7FFD4F919550
        public void get_StereoRendering(){} // RVA: 0x7FFD4F9195E0
        public void set_CubemapFaceResolution(){} // RVA: 0x7FFD4F9195F0
        public void .ctor(){} // RVA: 0x7FFD4F919600
        public void Initialize(){} // RVA: 0x7FFD4F919970
        public void set_placeholder(){} // RVA: 0x7FFD4F919460
        public void get_CubemapFaceResolution(){} // RVA: 0x7FFD4F9199D0
        public void set_caretColor(){} // RVA: 0x7FFD4F9199E0
        public void get_customCaretColor(){} // RVA: 0x7FFD4F919A60
        public void get_NetworkStatusListener(){} // RVA: 0x7FFD4EDC6830
        public void set_RefundTokens(){} // RVA: 0x7FFD4F919B00
        public void set_CubemapDepthResolution(){} // RVA: 0x7FFD4F919B10
        public void get_onEndEdit(){} // RVA: 0x7FFD4F919B20
        public void set_onEndEdit(){} // RVA: 0x7FFD4F919380
        public void get_onSubmit(){} // RVA: 0x7FFD4F919BC0
        public void get_CubemapDepthResolution(){} // RVA: 0x7FFD4F91A0A0
        public void get_onValueChange(){} // RVA: 0x7FFD4F91A0B0
        public void set_onValueChange(){} // RVA: 0x7FFD4F91A130
        public void get_onValueChanged(){} // RVA: 0x7FFD4F91A1C0
    }

    /// <summary>Originally: ÌÎÍÌÏÍÎÌÏÎÎÎÍÎÍÍÏÏÏÏÏÎÎ</summary>
    public class UiInputFieldSibling_8FDB
    {
        public object _8FDB;

        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7FFD4E078E90
        public void OnPointerExit(){} // RVA: 0x7FFD4E090A40
        public void OnPointerDown(){} // RVA: 0x7FFD4E090980
    }

}