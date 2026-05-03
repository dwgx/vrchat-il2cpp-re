// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 67
// Methods: 2217

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class Accelerometer : Sensor
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _acceleration; // 0x190
        public UnityEngine.InputSystem.Accelerometer _current;

        // ── Methods ──
        public void get_acceleration(){} // RVA: 0x7FFE81825EC0
        public void set_acceleration(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AE960
        public void set_current(){} // RVA: 0x7FFE879AE9A0
        public void MakeCurrent(){} // RVA: 0x7FFE879AEA40
        public void OnRemoved(){} // RVA: 0x7FFE879AEA50
        public void FinishSetup(){} // RVA: 0x7FFE879AEAA0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class AmbientTemperatureSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl _ambientTemperature; // 0x190
        public UnityEngine.InputSystem.AmbientTemperatureSensor _current;

        // ── Methods ──
        public void get_ambientTemperature(){} // RVA: 0x7FFE81825EC0
        public void set_ambientTemperature(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AFCC0
        public void set_current(){} // RVA: 0x7FFE879AFD00
        public void MakeCurrent(){} // RVA: 0x7FFE879AFDA0
        public void OnRemoved(){} // RVA: 0x7FFE879AFDB0
        public void FinishSetup(){} // RVA: 0x7FFE879AFE00
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class AttitudeSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.QuaternionControl _attitude; // 0x190
        public UnityEngine.InputSystem.AttitudeSensor _current;

        // ── Methods ──
        public void get_attitude(){} // RVA: 0x7FFE81825EC0
        public void set_attitude(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AEF30
        public void set_current(){} // RVA: 0x7FFE879AEF70
        public void MakeCurrent(){} // RVA: 0x7FFE879AF010
        public void OnRemoved(){} // RVA: 0x7FFE879AF020
        public void FinishSetup(){} // RVA: 0x7FFE879AF070
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class CommonUsages : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8792B1A0
    }

    public class DefaultInputActions : Object
    {
        public UnityEngine.InputSystem.InputActionAsset _asset; // 0x10
        public UnityEngine.InputSystem.InputActionMap m_Player; // 0x18
        public IPlayerActions m_PlayerActionsCallbackInterface; // 0x20
        public UnityEngine.InputSystem.InputAction m_Player_Move; // 0x28
        public UnityEngine.InputSystem.InputAction m_Player_Look; // 0x30
        public UnityEngine.InputSystem.InputAction m_Player_Fire; // 0x38
        public UnityEngine.InputSystem.InputActionMap m_UI; // 0x40
        public IUIActions m_UIActionsCallbackInterface; // 0x48
        public UnityEngine.InputSystem.InputAction m_UI_Navigate; // 0x50
        public UnityEngine.InputSystem.InputAction m_UI_Submit; // 0x58
        public UnityEngine.InputSystem.InputAction m_UI_Cancel; // 0x60
        public UnityEngine.InputSystem.InputAction m_UI_Point; // 0x68

        // ── Methods ──
        public void get_asset(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE879C92F0
        public void Dispose(){} // RVA: 0x7FFE879C9B50
        public void get_bindingMask(){} // RVA: 0x7FFE81D7E060
        public void set_bindingMask(){} // RVA: 0x7FFE81D7BC50
        public void get_devices(){} // RVA: 0x7FFE81D7E0D0
        public void set_devices(){} // RVA: 0x7FFE81D7BB10
        public void get_controlSchemes(){} // RVA: 0x7FFE81D7E120
        public void Contains(){} // RVA: 0x7FFE81D7BBD0
        public void GetEnumerator(){} // RVA: 0x7FFE81D7BB90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE81D7BB90
        public void Enable(){} // RVA: 0x7FFE81D7BA90
        public void Disable(){} // RVA: 0x7FFE81D7E160
        public void get_bindings(){} // RVA: 0x7FFE81D7BBB0
        public void FindAction(){} // RVA: 0x7FFE81D7DEC0
        public void FindBinding(){} // RVA: 0x7FFE81D7E180
        public void get_Player(){} // RVA: 0x7FFE81D7BAB0
        public void get_UI(){} // RVA: 0x7FFE81D7BAB0
        public void get_KeyboardMouseScheme(){} // RVA: 0x7FFE879C9BB0
        public void get_GamepadScheme(){} // RVA: 0x7FFE879C9D30
        public void get_TouchScheme(){} // RVA: 0x7FFE879C9EB0
        public void get_JoystickScheme(){} // RVA: 0x7FFE879CA030
        public void get_XRScheme(){} // RVA: 0x7FFE879CA1B0
    }

    public class DynamicBitfield : ValueType
    {
        // ── Methods ──
        public void SetLength(){} // RVA: 0x7FFE879DAA00
        public void SetBit(){} // RVA: 0x7FFE879DAA60
        public void TestBit(){} // RVA: 0x7FFE879DAB00
        public void ClearBit(){} // RVA: 0x7FFE879DAB80
        public void AnyBitIsSet(){} // RVA: 0x7FFE879DAC20
        public void BitCountToULongCount(){} // RVA: 0x7FFE879DAC90
    }

    public class FastKeyboard : Keyboard
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87941440
        public void Initialize_ctrlKeyboardanyKey(){} // RVA: 0x7FFE87946190
        public void Initialize_ctrlKeyboardescape(){} // RVA: 0x7FFE87946540
        public void Initialize_ctrlKeyboardspace(){} // RVA: 0x7FFE879468B0
        public void Initialize_ctrlKeyboardenter(){} // RVA: 0x7FFE87946C10
        public void Initialize_ctrlKeyboardtab(){} // RVA: 0x7FFE87946F90
        public void Initialize_ctrlKeyboardbackquote(){} // RVA: 0x7FFE879472F0
        public void Initialize_ctrlKeyboardquote(){} // RVA: 0x7FFE87947650
        public void Initialize_ctrlKeyboardsemicolon(){} // RVA: 0x7FFE879479B0
        public void Initialize_ctrlKeyboardcomma(){} // RVA: 0x7FFE87947D10
        public void Initialize_ctrlKeyboardperiod(){} // RVA: 0x7FFE87948070
        public void Initialize_ctrlKeyboardslash(){} // RVA: 0x7FFE879483D0
        public void Initialize_ctrlKeyboardbackslash(){} // RVA: 0x7FFE87948730
        public void Initialize_ctrlKeyboardleftBracket(){} // RVA: 0x7FFE87948A90
        public void Initialize_ctrlKeyboardrightBracket(){} // RVA: 0x7FFE87948DF0
        public void Initialize_ctrlKeyboardminus(){} // RVA: 0x7FFE87949150
        public void Initialize_ctrlKeyboardequals(){} // RVA: 0x7FFE879494B0
        public void Initialize_ctrlKeyboardupArrow(){} // RVA: 0x7FFE87949810
        public void Initialize_ctrlKeyboarddownArrow(){} // RVA: 0x7FFE87949B70
        public void Initialize_ctrlKeyboardleftArrow(){} // RVA: 0x7FFE87949ED0
        public void Initialize_ctrlKeyboardrightArrow(){} // RVA: 0x7FFE8794A230
        public void Initialize_ctrlKeyboarda(){} // RVA: 0x7FFE8794A590
        public void Initialize_ctrlKeyboardb(){} // RVA: 0x7FFE8794A8F0
        public void Initialize_ctrlKeyboardc(){} // RVA: 0x7FFE8794AC50
        public void Initialize_ctrlKeyboardd(){} // RVA: 0x7FFE8794AFB0
        public void Initialize_ctrlKeyboarde(){} // RVA: 0x7FFE8794B310
        public void Initialize_ctrlKeyboardf(){} // RVA: 0x7FFE8794B670
        public void Initialize_ctrlKeyboardg(){} // RVA: 0x7FFE8794B9D0
        public void Initialize_ctrlKeyboardh(){} // RVA: 0x7FFE8794BD30
        public void Initialize_ctrlKeyboardi(){} // RVA: 0x7FFE8794C090
        public void Initialize_ctrlKeyboardj(){} // RVA: 0x7FFE8794C3F0
        public void Initialize_ctrlKeyboardk(){} // RVA: 0x7FFE8794C750
        public void Initialize_ctrlKeyboardl(){} // RVA: 0x7FFE8794CAB0
        public void Initialize_ctrlKeyboardm(){} // RVA: 0x7FFE8794CE10
        public void Initialize_ctrlKeyboardn(){} // RVA: 0x7FFE8794D170
        public void Initialize_ctrlKeyboardo(){} // RVA: 0x7FFE8794D4D0
        public void Initialize_ctrlKeyboardp(){} // RVA: 0x7FFE8794D830
        public void Initialize_ctrlKeyboardq(){} // RVA: 0x7FFE8794DB90
        public void Initialize_ctrlKeyboardr(){} // RVA: 0x7FFE8794DEF0
        public void Initialize_ctrlKeyboards(){} // RVA: 0x7FFE8794E250
        public void Initialize_ctrlKeyboardt(){} // RVA: 0x7FFE8794E5B0
        public void Initialize_ctrlKeyboardu(){} // RVA: 0x7FFE8794E910
        public void Initialize_ctrlKeyboardv(){} // RVA: 0x7FFE8794EC70
        public void Initialize_ctrlKeyboardw(){} // RVA: 0x7FFE8794EFD0
        public void Initialize_ctrlKeyboardx(){} // RVA: 0x7FFE8794F330
        public void Initialize_ctrlKeyboardy(){} // RVA: 0x7FFE8794F690
        public void Initialize_ctrlKeyboardz(){} // RVA: 0x7FFE8794F9F0
        public void Initialize_ctrlKeyboard1(){} // RVA: 0x7FFE8794FD50
        public void Initialize_ctrlKeyboard2(){} // RVA: 0x7FFE879500A0
        public void Initialize_ctrlKeyboard3(){} // RVA: 0x7FFE879503F0
        public void Initialize_ctrlKeyboard4(){} // RVA: 0x7FFE87950740
        public void Initialize_ctrlKeyboard5(){} // RVA: 0x7FFE87950A90
        public void Initialize_ctrlKeyboard6(){} // RVA: 0x7FFE87950DE0
        public void Initialize_ctrlKeyboard7(){} // RVA: 0x7FFE87951130
        public void Initialize_ctrlKeyboard8(){} // RVA: 0x7FFE87951480
        public void Initialize_ctrlKeyboard9(){} // RVA: 0x7FFE879517D0
        public void Initialize_ctrlKeyboard0(){} // RVA: 0x7FFE87951B20
        public void Initialize_ctrlKeyboardleftShift(){} // RVA: 0x7FFE87951E70
        public void Initialize_ctrlKeyboardrightShift(){} // RVA: 0x7FFE879521F0
        public void Initialize_ctrlKeyboardshift(){} // RVA: 0x7FFE87952570
        public void Initialize_ctrlKeyboardleftAlt(){} // RVA: 0x7FFE87952910
        public void Initialize_ctrlKeyboardrightAlt(){} // RVA: 0x7FFE87952C90
        public void Initialize_ctrlKeyboardalt(){} // RVA: 0x7FFE87953010
        public void Initialize_ctrlKeyboardleftCtrl(){} // RVA: 0x7FFE879533B0
        public void Initialize_ctrlKeyboardrightCtrl(){} // RVA: 0x7FFE87953730
        public void Initialize_ctrlKeyboardctrl(){} // RVA: 0x7FFE87953AB0
        public void Initialize_ctrlKeyboardleftMeta(){} // RVA: 0x7FFE87953E50
        public void Initialize_ctrlKeyboardrightMeta(){} // RVA: 0x7FFE879541E0
        public void Initialize_ctrlKeyboardcontextMenu(){} // RVA: 0x7FFE87954570
        public void Initialize_ctrlKeyboardbackspace(){} // RVA: 0x7FFE879548F0
        public void Initialize_ctrlKeyboardpageDown(){} // RVA: 0x7FFE87954C50
        public void Initialize_ctrlKeyboardpageUp(){} // RVA: 0x7FFE87954FB0
        public void Initialize_ctrlKeyboardhome(){} // RVA: 0x7FFE87955310
        public void Initialize_ctrlKeyboardend(){} // RVA: 0x7FFE87955670
        public void Initialize_ctrlKeyboardinsert(){} // RVA: 0x7FFE879559D0
        public void Initialize_ctrlKeyboarddelete(){} // RVA: 0x7FFE87955D30
        public void Initialize_ctrlKeyboardcapsLock(){} // RVA: 0x7FFE87956090
        public void Initialize_ctrlKeyboardnumLock(){} // RVA: 0x7FFE879563F0
        public void Initialize_ctrlKeyboardprintScreen(){} // RVA: 0x7FFE87956750
        public void Initialize_ctrlKeyboardscrollLock(){} // RVA: 0x7FFE87956AB0
        public void Initialize_ctrlKeyboardpause(){} // RVA: 0x7FFE87956E10
        public void Initialize_ctrlKeyboardnumpadEnter(){} // RVA: 0x7FFE87957170
        public void Initialize_ctrlKeyboardnumpadDivide(){} // RVA: 0x7FFE879574D0
        public void Initialize_ctrlKeyboardnumpadMultiply(){} // RVA: 0x7FFE87957830
        public void Initialize_ctrlKeyboardnumpadPlus(){} // RVA: 0x7FFE87957B90
        public void Initialize_ctrlKeyboardnumpadMinus(){} // RVA: 0x7FFE87957EF0
        public void Initialize_ctrlKeyboardnumpadPeriod(){} // RVA: 0x7FFE87958250
        public void Initialize_ctrlKeyboardnumpadEquals(){} // RVA: 0x7FFE879585B0
        public void Initialize_ctrlKeyboardnumpad1(){} // RVA: 0x7FFE87958910
        public void Initialize_ctrlKeyboardnumpad2(){} // RVA: 0x7FFE87958C70
        public void Initialize_ctrlKeyboardnumpad3(){} // RVA: 0x7FFE87958FD0
        public void Initialize_ctrlKeyboardnumpad4(){} // RVA: 0x7FFE87959330
        public void Initialize_ctrlKeyboardnumpad5(){} // RVA: 0x7FFE87959690
        public void Initialize_ctrlKeyboardnumpad6(){} // RVA: 0x7FFE879599F0
        public void Initialize_ctrlKeyboardnumpad7(){} // RVA: 0x7FFE87959D50
        public void Initialize_ctrlKeyboardnumpad8(){} // RVA: 0x7FFE8795A0B0
        public void Initialize_ctrlKeyboardnumpad9(){} // RVA: 0x7FFE8795A410
        public void Initialize_ctrlKeyboardnumpad0(){} // RVA: 0x7FFE8795A770
        public void Initialize_ctrlKeyboardf1(){} // RVA: 0x7FFE8795AAD0
        public void Initialize_ctrlKeyboardf2(){} // RVA: 0x7FFE8795AE30
        public void Initialize_ctrlKeyboardf3(){} // RVA: 0x7FFE8795B190
        public void Initialize_ctrlKeyboardf4(){} // RVA: 0x7FFE8795B4F0
        public void Initialize_ctrlKeyboardf5(){} // RVA: 0x7FFE8795B850
        public void Initialize_ctrlKeyboardf6(){} // RVA: 0x7FFE8795BBB0
        public void Initialize_ctrlKeyboardf7(){} // RVA: 0x7FFE8795BF10
        public void Initialize_ctrlKeyboardf8(){} // RVA: 0x7FFE8795C270
        public void Initialize_ctrlKeyboardf9(){} // RVA: 0x7FFE8795C5D0
        public void Initialize_ctrlKeyboardf10(){} // RVA: 0x7FFE8795C930
        public void Initialize_ctrlKeyboardf11(){} // RVA: 0x7FFE8795CC90
        public void Initialize_ctrlKeyboardf12(){} // RVA: 0x7FFE8795CFF0
        public void Initialize_ctrlKeyboardOEM1(){} // RVA: 0x7FFE8795D350
        public void Initialize_ctrlKeyboardOEM2(){} // RVA: 0x7FFE8795D6A0
        public void Initialize_ctrlKeyboardOEM3(){} // RVA: 0x7FFE8795D9F0
        public void Initialize_ctrlKeyboardOEM4(){} // RVA: 0x7FFE8795DD40
        public void Initialize_ctrlKeyboardOEM5(){} // RVA: 0x7FFE8795E090
        public void Initialize_ctrlKeyboardf13(){} // RVA: 0x7FFE8795E3E0
        public void Initialize_ctrlKeyboardf14(){} // RVA: 0x7FFE8795E740
        public void Initialize_ctrlKeyboardf15(){} // RVA: 0x7FFE8795EAA0
        public void Initialize_ctrlKeyboardf16(){} // RVA: 0x7FFE8795EE00
        public void Initialize_ctrlKeyboardf17(){} // RVA: 0x7FFE8795F160
        public void Initialize_ctrlKeyboardf18(){} // RVA: 0x7FFE8795F4C0
        public void Initialize_ctrlKeyboardf19(){} // RVA: 0x7FFE8795F820
        public void Initialize_ctrlKeyboardf20(){} // RVA: 0x7FFE8795FB80
        public void Initialize_ctrlKeyboardf21(){} // RVA: 0x7FFE8795FEE0
        public void Initialize_ctrlKeyboardf22(){} // RVA: 0x7FFE87960240
        public void Initialize_ctrlKeyboardf23(){} // RVA: 0x7FFE879605A0
        public void Initialize_ctrlKeyboardf24(){} // RVA: 0x7FFE87960900
        public void Initialize_ctrlKeyboardIMESelected(){} // RVA: 0x7FFE87960C60
    }

    public class FastMouse : Mouse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE879A11C0
        public void Initialize_ctrlMouseposition(){} // RVA: 0x7FFE879A2BF0
        public void Initialize_ctrlMousedelta(){} // RVA: 0x7FFE879A2F10
        public void Initialize_ctrlMousescroll(){} // RVA: 0x7FFE879A3220
        public void Initialize_ctrlMousepress(){} // RVA: 0x7FFE879A3520
        public void Initialize_ctrlMouseleftButton(){} // RVA: 0x7FFE879A3880
        public void Initialize_ctrlMouserightButton(){} // RVA: 0x7FFE879A3C00
        public void Initialize_ctrlMousemiddleButton(){} // RVA: 0x7FFE879A3F80
        public void Initialize_ctrlMouseforwardButton(){} // RVA: 0x7FFE879A42F0
        public void Initialize_ctrlMousebackButton(){} // RVA: 0x7FFE879A4660
        public void Initialize_ctrlMousepressure(){} // RVA: 0x7FFE879A49D0
        public void Initialize_ctrlMouseradius(){} // RVA: 0x7FFE879A4D00
        public void Initialize_ctrlMousepointerId(){} // RVA: 0x7FFE879A5010
        public void Initialize_ctrlMousedisplayIndex(){} // RVA: 0x7FFE879A52F0
        public void Initialize_ctrlMouseclickCount(){} // RVA: 0x7FFE879A55E0
        public void Initialize_ctrlMousepositionx(){} // RVA: 0x7FFE879A58D0
        public void Initialize_ctrlMousepositiony(){} // RVA: 0x7FFE879A5BF0
        public void Initialize_ctrlMousedeltaup(){} // RVA: 0x7FFE879A5F10
        public void Initialize_ctrlMousedeltadown(){} // RVA: 0x7FFE879A6240
        public void Initialize_ctrlMousedeltaleft(){} // RVA: 0x7FFE879A6570
        public void Initialize_ctrlMousedeltaright(){} // RVA: 0x7FFE879A68A0
        public void Initialize_ctrlMousedeltax(){} // RVA: 0x7FFE879A6BD0
        public void Initialize_ctrlMousedeltay(){} // RVA: 0x7FFE879A6ED0
        public void Initialize_ctrlMousescrollup(){} // RVA: 0x7FFE879A71D0
        public void Initialize_ctrlMousescrolldown(){} // RVA: 0x7FFE879A7500
        public void Initialize_ctrlMousescrollleft(){} // RVA: 0x7FFE879A7830
        public void Initialize_ctrlMousescrollright(){} // RVA: 0x7FFE879A7B60
        public void Initialize_ctrlMousescrollx(){} // RVA: 0x7FFE879A7E90
        public void Initialize_ctrlMousescrolly(){} // RVA: 0x7FFE879A81B0
        public void Initialize_ctrlMouseradiusx(){} // RVA: 0x7FFE879A84F0
        public void Initialize_ctrlMouseradiusy(){} // RVA: 0x7FFE879A87F0
        public void OnNextUpdate(){} // RVA: 0x7FFE879A8AF0
        public void OnStateEvent(){} // RVA: 0x7FFE879A8C50
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFE879A8AF0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFE879A8C50
        public void MergeForward(){} // RVA: 0x7FFE879A8DF0
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7FFE879A8EA0
    }

    public class FastTouchscreen : Touchscreen
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE879612D0
        public void Initialize_ctrlTouchscreenprimaryTouch(){} // RVA: 0x7FFE879666F0
        public void Initialize_ctrlTouchscreenposition(){} // RVA: 0x7FFE879669F0
        public void Initialize_ctrlTouchscreendelta(){} // RVA: 0x7FFE87966D20
        public void Initialize_ctrlTouchscreenpressure(){} // RVA: 0x7FFE87967030
        public void Initialize_ctrlTouchscreenradius(){} // RVA: 0x7FFE87967360
        public void Initialize_ctrlTouchscreenpress(){} // RVA: 0x7FFE87967670
        public void Initialize_ctrlTouchscreendisplayIndex(){} // RVA: 0x7FFE879679D0
        public void Initialize_ctrlTouchscreentouch0(){} // RVA: 0x7FFE87967CC0
        public void Initialize_ctrlTouchscreentouch1(){} // RVA: 0x7FFE87967FC0
        public void Initialize_ctrlTouchscreentouch2(){} // RVA: 0x7FFE879682C0
        public void Initialize_ctrlTouchscreentouch3(){} // RVA: 0x7FFE879685C0
        public void Initialize_ctrlTouchscreentouch4(){} // RVA: 0x7FFE879688C0
        public void Initialize_ctrlTouchscreentouch5(){} // RVA: 0x7FFE87968BC0
        public void Initialize_ctrlTouchscreentouch6(){} // RVA: 0x7FFE87968EC0
        public void Initialize_ctrlTouchscreentouch7(){} // RVA: 0x7FFE879691C0
        public void Initialize_ctrlTouchscreentouch8(){} // RVA: 0x7FFE879694C0
        public void Initialize_ctrlTouchscreentouch9(){} // RVA: 0x7FFE879697C0
        public void Initialize_ctrlTouchscreenprimaryTouchtouchId(){} // RVA: 0x7FFE87969AC0
        public void Initialize_ctrlTouchscreenprimaryTouchposition(){} // RVA: 0x7FFE87969DE0
        public void Initialize_ctrlTouchscreenprimaryTouchdelta(){} // RVA: 0x7FFE8796A110
        public void Initialize_ctrlTouchscreenprimaryTouchpressure(){} // RVA: 0x7FFE8796A420
        public void Initialize_ctrlTouchscreenprimaryTouchradius(){} // RVA: 0x7FFE8796A720
        public void Initialize_ctrlTouchscreenprimaryTouchphase(){} // RVA: 0x7FFE8796AA30
        public void Initialize_ctrlTouchscreenprimaryTouchpress(){} // RVA: 0x7FFE8796AD40
        public void Initialize_ctrlTouchscreenprimaryTouchtapCount(){} // RVA: 0x7FFE8796B0A0
        public void Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(){} // RVA: 0x7FFE8796B3A0
        public void Initialize_ctrlTouchscreenprimaryTouchindirectTouch(){} // RVA: 0x7FFE8796B6A0
        public void Initialize_ctrlTouchscreenprimaryTouchtap(){} // RVA: 0x7FFE8796BA00
        public void Initialize_ctrlTouchscreenprimaryTouchstartTime(){} // RVA: 0x7FFE8796BD70
        public void Initialize_ctrlTouchscreenprimaryTouchstartPosition(){} // RVA: 0x7FFE8796C080
        public void Initialize_ctrlTouchscreenprimaryTouchpositionx(){} // RVA: 0x7FFE8796C3A0
        public void Initialize_ctrlTouchscreenprimaryTouchpositiony(){} // RVA: 0x7FFE8796C6C0
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaup(){} // RVA: 0x7FFE8796C9E0
        public void Initialize_ctrlTouchscreenprimaryTouchdeltadown(){} // RVA: 0x7FFE8796CD10
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaleft(){} // RVA: 0x7FFE8796D040
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaright(){} // RVA: 0x7FFE8796D370
        public void Initialize_ctrlTouchscreenprimaryTouchdeltax(){} // RVA: 0x7FFE8796D6A0
        public void Initialize_ctrlTouchscreenprimaryTouchdeltay(){} // RVA: 0x7FFE8796D9A0
        public void Initialize_ctrlTouchscreenprimaryTouchradiusx(){} // RVA: 0x7FFE8796DCA0
        public void Initialize_ctrlTouchscreenprimaryTouchradiusy(){} // RVA: 0x7FFE8796DFA0
        public void Initialize_ctrlTouchscreenprimaryTouchstartPositionx(){} // RVA: 0x7FFE8796E2A0
        public void Initialize_ctrlTouchscreenprimaryTouchstartPositiony(){} // RVA: 0x7FFE8796E5A0
        public void Initialize_ctrlTouchscreenpositionx(){} // RVA: 0x7FFE8796E8A0
        public void Initialize_ctrlTouchscreenpositiony(){} // RVA: 0x7FFE8796EBC0
        public void Initialize_ctrlTouchscreendeltaup(){} // RVA: 0x7FFE8796EEE0
        public void Initialize_ctrlTouchscreendeltadown(){} // RVA: 0x7FFE8796F210
        public void Initialize_ctrlTouchscreendeltaleft(){} // RVA: 0x7FFE8796F540
        public void Initialize_ctrlTouchscreendeltaright(){} // RVA: 0x7FFE8796F870
        public void Initialize_ctrlTouchscreendeltax(){} // RVA: 0x7FFE8796FBA0
        public void Initialize_ctrlTouchscreendeltay(){} // RVA: 0x7FFE8796FEA0
        public void Initialize_ctrlTouchscreenradiusx(){} // RVA: 0x7FFE879701A0
        public void Initialize_ctrlTouchscreenradiusy(){} // RVA: 0x7FFE879704A0
        public void Initialize_ctrlTouchscreentouch0touchId(){} // RVA: 0x7FFE879707A0
        public void Initialize_ctrlTouchscreentouch0position(){} // RVA: 0x7FFE87970AC0
        public void Initialize_ctrlTouchscreentouch0delta(){} // RVA: 0x7FFE87970DF0
        public void Initialize_ctrlTouchscreentouch0pressure(){} // RVA: 0x7FFE87971100
        public void Initialize_ctrlTouchscreentouch0radius(){} // RVA: 0x7FFE87971400
        public void Initialize_ctrlTouchscreentouch0phase(){} // RVA: 0x7FFE87971710
        public void Initialize_ctrlTouchscreentouch0press(){} // RVA: 0x7FFE87971A20
        public void Initialize_ctrlTouchscreentouch0tapCount(){} // RVA: 0x7FFE87971D80
        public void Initialize_ctrlTouchscreentouch0displayIndex(){} // RVA: 0x7FFE87972080
        public void Initialize_ctrlTouchscreentouch0indirectTouch(){} // RVA: 0x7FFE87972380
        public void Initialize_ctrlTouchscreentouch0tap(){} // RVA: 0x7FFE879726E0
        public void Initialize_ctrlTouchscreentouch0startTime(){} // RVA: 0x7FFE87972A40
        public void Initialize_ctrlTouchscreentouch0startPosition(){} // RVA: 0x7FFE87972D50
        public void Initialize_ctrlTouchscreentouch0positionx(){} // RVA: 0x7FFE87973070
        public void Initialize_ctrlTouchscreentouch0positiony(){} // RVA: 0x7FFE87973390
        public void Initialize_ctrlTouchscreentouch0deltaup(){} // RVA: 0x7FFE879736B0
        public void Initialize_ctrlTouchscreentouch0deltadown(){} // RVA: 0x7FFE879739E0
        public void Initialize_ctrlTouchscreentouch0deltaleft(){} // RVA: 0x7FFE87973D10
        public void Initialize_ctrlTouchscreentouch0deltaright(){} // RVA: 0x7FFE87974040
        public void Initialize_ctrlTouchscreentouch0deltax(){} // RVA: 0x7FFE87974370
        public void Initialize_ctrlTouchscreentouch0deltay(){} // RVA: 0x7FFE87974670
        public void Initialize_ctrlTouchscreentouch0radiusx(){} // RVA: 0x7FFE87974970
        public void Initialize_ctrlTouchscreentouch0radiusy(){} // RVA: 0x7FFE87974C70
        public void Initialize_ctrlTouchscreentouch0startPositionx(){} // RVA: 0x7FFE87974F70
        public void Initialize_ctrlTouchscreentouch0startPositiony(){} // RVA: 0x7FFE87975270
        public void Initialize_ctrlTouchscreentouch1touchId(){} // RVA: 0x7FFE87975570
        public void Initialize_ctrlTouchscreentouch1position(){} // RVA: 0x7FFE87975890
        public void Initialize_ctrlTouchscreentouch1delta(){} // RVA: 0x7FFE87975BC0
        public void Initialize_ctrlTouchscreentouch1pressure(){} // RVA: 0x7FFE87975ED0
        public void Initialize_ctrlTouchscreentouch1radius(){} // RVA: 0x7FFE879761D0
        public void Initialize_ctrlTouchscreentouch1phase(){} // RVA: 0x7FFE879764E0
        public void Initialize_ctrlTouchscreentouch1press(){} // RVA: 0x7FFE879767F0
        public void Initialize_ctrlTouchscreentouch1tapCount(){} // RVA: 0x7FFE87976B50
        public void Initialize_ctrlTouchscreentouch1displayIndex(){} // RVA: 0x7FFE87976E50
        public void Initialize_ctrlTouchscreentouch1indirectTouch(){} // RVA: 0x7FFE87977150
        public void Initialize_ctrlTouchscreentouch1tap(){} // RVA: 0x7FFE879774B0
        public void Initialize_ctrlTouchscreentouch1startTime(){} // RVA: 0x7FFE87977810
        public void Initialize_ctrlTouchscreentouch1startPosition(){} // RVA: 0x7FFE87977B20
        public void Initialize_ctrlTouchscreentouch1positionx(){} // RVA: 0x7FFE87977E40
        public void Initialize_ctrlTouchscreentouch1positiony(){} // RVA: 0x7FFE87978160
        public void Initialize_ctrlTouchscreentouch1deltaup(){} // RVA: 0x7FFE87978480
        public void Initialize_ctrlTouchscreentouch1deltadown(){} // RVA: 0x7FFE879787B0
        public void Initialize_ctrlTouchscreentouch1deltaleft(){} // RVA: 0x7FFE87978AE0
        public void Initialize_ctrlTouchscreentouch1deltaright(){} // RVA: 0x7FFE87978E10
        public void Initialize_ctrlTouchscreentouch1deltax(){} // RVA: 0x7FFE87979140
        public void Initialize_ctrlTouchscreentouch1deltay(){} // RVA: 0x7FFE87979440
        public void Initialize_ctrlTouchscreentouch1radiusx(){} // RVA: 0x7FFE87979740
        public void Initialize_ctrlTouchscreentouch1radiusy(){} // RVA: 0x7FFE87979A40
        public void Initialize_ctrlTouchscreentouch1startPositionx(){} // RVA: 0x7FFE87979D40
        public void Initialize_ctrlTouchscreentouch1startPositiony(){} // RVA: 0x7FFE8797A040
        public void Initialize_ctrlTouchscreentouch2touchId(){} // RVA: 0x7FFE8797A340
        public void Initialize_ctrlTouchscreentouch2position(){} // RVA: 0x7FFE8797A660
        public void Initialize_ctrlTouchscreentouch2delta(){} // RVA: 0x7FFE8797A990
        public void Initialize_ctrlTouchscreentouch2pressure(){} // RVA: 0x7FFE8797ACA0
        public void Initialize_ctrlTouchscreentouch2radius(){} // RVA: 0x7FFE8797AFA0
        public void Initialize_ctrlTouchscreentouch2phase(){} // RVA: 0x7FFE8797B2B0
        public void Initialize_ctrlTouchscreentouch2press(){} // RVA: 0x7FFE8797B5C0
        public void Initialize_ctrlTouchscreentouch2tapCount(){} // RVA: 0x7FFE8797B920
        public void Initialize_ctrlTouchscreentouch2displayIndex(){} // RVA: 0x7FFE8797BC20
        public void Initialize_ctrlTouchscreentouch2indirectTouch(){} // RVA: 0x7FFE8797BF20
        public void Initialize_ctrlTouchscreentouch2tap(){} // RVA: 0x7FFE8797C280
        public void Initialize_ctrlTouchscreentouch2startTime(){} // RVA: 0x7FFE8797C5E0
        public void Initialize_ctrlTouchscreentouch2startPosition(){} // RVA: 0x7FFE8797C8F0
        public void Initialize_ctrlTouchscreentouch2positionx(){} // RVA: 0x7FFE8797CC10
        public void Initialize_ctrlTouchscreentouch2positiony(){} // RVA: 0x7FFE8797CF30
        public void Initialize_ctrlTouchscreentouch2deltaup(){} // RVA: 0x7FFE8797D250
        public void Initialize_ctrlTouchscreentouch2deltadown(){} // RVA: 0x7FFE8797D580
        public void Initialize_ctrlTouchscreentouch2deltaleft(){} // RVA: 0x7FFE8797D8B0
        public void Initialize_ctrlTouchscreentouch2deltaright(){} // RVA: 0x7FFE8797DBE0
        public void Initialize_ctrlTouchscreentouch2deltax(){} // RVA: 0x7FFE8797DF10
        public void Initialize_ctrlTouchscreentouch2deltay(){} // RVA: 0x7FFE8797E210
        public void Initialize_ctrlTouchscreentouch2radiusx(){} // RVA: 0x7FFE8797E510
        public void Initialize_ctrlTouchscreentouch2radiusy(){} // RVA: 0x7FFE8797E810
        public void Initialize_ctrlTouchscreentouch2startPositionx(){} // RVA: 0x7FFE8797EB10
        public void Initialize_ctrlTouchscreentouch2startPositiony(){} // RVA: 0x7FFE8797EE10
        public void Initialize_ctrlTouchscreentouch3touchId(){} // RVA: 0x7FFE8797F110
        public void Initialize_ctrlTouchscreentouch3position(){} // RVA: 0x7FFE8797F430
        public void Initialize_ctrlTouchscreentouch3delta(){} // RVA: 0x7FFE8797F760
        public void Initialize_ctrlTouchscreentouch3pressure(){} // RVA: 0x7FFE8797FA70
        public void Initialize_ctrlTouchscreentouch3radius(){} // RVA: 0x7FFE8797FD70
        public void Initialize_ctrlTouchscreentouch3phase(){} // RVA: 0x7FFE87980080
        public void Initialize_ctrlTouchscreentouch3press(){} // RVA: 0x7FFE87980390
        public void Initialize_ctrlTouchscreentouch3tapCount(){} // RVA: 0x7FFE879806F0
        public void Initialize_ctrlTouchscreentouch3displayIndex(){} // RVA: 0x7FFE879809F0
        public void Initialize_ctrlTouchscreentouch3indirectTouch(){} // RVA: 0x7FFE87980CF0
        public void Initialize_ctrlTouchscreentouch3tap(){} // RVA: 0x7FFE87981050
        public void Initialize_ctrlTouchscreentouch3startTime(){} // RVA: 0x7FFE879813B0
        public void Initialize_ctrlTouchscreentouch3startPosition(){} // RVA: 0x7FFE879816C0
        public void Initialize_ctrlTouchscreentouch3positionx(){} // RVA: 0x7FFE879819E0
        public void Initialize_ctrlTouchscreentouch3positiony(){} // RVA: 0x7FFE87981D00
        public void Initialize_ctrlTouchscreentouch3deltaup(){} // RVA: 0x7FFE87982020
        public void Initialize_ctrlTouchscreentouch3deltadown(){} // RVA: 0x7FFE87982350
        public void Initialize_ctrlTouchscreentouch3deltaleft(){} // RVA: 0x7FFE87982680
        public void Initialize_ctrlTouchscreentouch3deltaright(){} // RVA: 0x7FFE879829B0
        public void Initialize_ctrlTouchscreentouch3deltax(){} // RVA: 0x7FFE87982CE0
        public void Initialize_ctrlTouchscreentouch3deltay(){} // RVA: 0x7FFE87982FE0
        public void Initialize_ctrlTouchscreentouch3radiusx(){} // RVA: 0x7FFE879832E0
        public void Initialize_ctrlTouchscreentouch3radiusy(){} // RVA: 0x7FFE879835E0
        public void Initialize_ctrlTouchscreentouch3startPositionx(){} // RVA: 0x7FFE879838E0
        public void Initialize_ctrlTouchscreentouch3startPositiony(){} // RVA: 0x7FFE87983BE0
        public void Initialize_ctrlTouchscreentouch4touchId(){} // RVA: 0x7FFE87983EE0
        public void Initialize_ctrlTouchscreentouch4position(){} // RVA: 0x7FFE87984200
        public void Initialize_ctrlTouchscreentouch4delta(){} // RVA: 0x7FFE87984530
        public void Initialize_ctrlTouchscreentouch4pressure(){} // RVA: 0x7FFE87984840
        public void Initialize_ctrlTouchscreentouch4radius(){} // RVA: 0x7FFE87984B40
        public void Initialize_ctrlTouchscreentouch4phase(){} // RVA: 0x7FFE87984E50
        public void Initialize_ctrlTouchscreentouch4press(){} // RVA: 0x7FFE87985160
        public void Initialize_ctrlTouchscreentouch4tapCount(){} // RVA: 0x7FFE879854C0
        public void Initialize_ctrlTouchscreentouch4displayIndex(){} // RVA: 0x7FFE879857C0
        public void Initialize_ctrlTouchscreentouch4indirectTouch(){} // RVA: 0x7FFE87985AC0
        public void Initialize_ctrlTouchscreentouch4tap(){} // RVA: 0x7FFE87985E20
        public void Initialize_ctrlTouchscreentouch4startTime(){} // RVA: 0x7FFE87986180
        public void Initialize_ctrlTouchscreentouch4startPosition(){} // RVA: 0x7FFE87986490
        public void Initialize_ctrlTouchscreentouch4positionx(){} // RVA: 0x7FFE879867B0
        public void Initialize_ctrlTouchscreentouch4positiony(){} // RVA: 0x7FFE87986AD0
        public void Initialize_ctrlTouchscreentouch4deltaup(){} // RVA: 0x7FFE87986DF0
        public void Initialize_ctrlTouchscreentouch4deltadown(){} // RVA: 0x7FFE87987120
        public void Initialize_ctrlTouchscreentouch4deltaleft(){} // RVA: 0x7FFE87987450
        public void Initialize_ctrlTouchscreentouch4deltaright(){} // RVA: 0x7FFE87987780
        public void Initialize_ctrlTouchscreentouch4deltax(){} // RVA: 0x7FFE87987AB0
        public void Initialize_ctrlTouchscreentouch4deltay(){} // RVA: 0x7FFE87987DB0
        public void Initialize_ctrlTouchscreentouch4radiusx(){} // RVA: 0x7FFE879880B0
        public void Initialize_ctrlTouchscreentouch4radiusy(){} // RVA: 0x7FFE879883B0
        public void Initialize_ctrlTouchscreentouch4startPositionx(){} // RVA: 0x7FFE879886B0
        public void Initialize_ctrlTouchscreentouch4startPositiony(){} // RVA: 0x7FFE879889B0
        public void Initialize_ctrlTouchscreentouch5touchId(){} // RVA: 0x7FFE87988CB0
        public void Initialize_ctrlTouchscreentouch5position(){} // RVA: 0x7FFE87988FD0
        public void Initialize_ctrlTouchscreentouch5delta(){} // RVA: 0x7FFE87989300
        public void Initialize_ctrlTouchscreentouch5pressure(){} // RVA: 0x7FFE87989610
        public void Initialize_ctrlTouchscreentouch5radius(){} // RVA: 0x7FFE87989910
        public void Initialize_ctrlTouchscreentouch5phase(){} // RVA: 0x7FFE87989C20
        public void Initialize_ctrlTouchscreentouch5press(){} // RVA: 0x7FFE87989F30
        public void Initialize_ctrlTouchscreentouch5tapCount(){} // RVA: 0x7FFE8798A290
        public void Initialize_ctrlTouchscreentouch5displayIndex(){} // RVA: 0x7FFE8798A590
        public void Initialize_ctrlTouchscreentouch5indirectTouch(){} // RVA: 0x7FFE8798A890
        public void Initialize_ctrlTouchscreentouch5tap(){} // RVA: 0x7FFE8798ABF0
        public void Initialize_ctrlTouchscreentouch5startTime(){} // RVA: 0x7FFE8798AF50
        public void Initialize_ctrlTouchscreentouch5startPosition(){} // RVA: 0x7FFE8798B260
        public void Initialize_ctrlTouchscreentouch5positionx(){} // RVA: 0x7FFE8798B580
        public void Initialize_ctrlTouchscreentouch5positiony(){} // RVA: 0x7FFE8798B8A0
        public void Initialize_ctrlTouchscreentouch5deltaup(){} // RVA: 0x7FFE8798BBC0
        public void Initialize_ctrlTouchscreentouch5deltadown(){} // RVA: 0x7FFE8798BEF0
        public void Initialize_ctrlTouchscreentouch5deltaleft(){} // RVA: 0x7FFE8798C220
        public void Initialize_ctrlTouchscreentouch5deltaright(){} // RVA: 0x7FFE8798C550
        public void Initialize_ctrlTouchscreentouch5deltax(){} // RVA: 0x7FFE8798C880
        public void Initialize_ctrlTouchscreentouch5deltay(){} // RVA: 0x7FFE8798CB80
        public void Initialize_ctrlTouchscreentouch5radiusx(){} // RVA: 0x7FFE8798CE80
        public void Initialize_ctrlTouchscreentouch5radiusy(){} // RVA: 0x7FFE8798D180
        public void Initialize_ctrlTouchscreentouch5startPositionx(){} // RVA: 0x7FFE8798D480
        public void Initialize_ctrlTouchscreentouch5startPositiony(){} // RVA: 0x7FFE8798D780
        public void Initialize_ctrlTouchscreentouch6touchId(){} // RVA: 0x7FFE8798DA80
        public void Initialize_ctrlTouchscreentouch6position(){} // RVA: 0x7FFE8798DDA0
        public void Initialize_ctrlTouchscreentouch6delta(){} // RVA: 0x7FFE8798E0D0
        public void Initialize_ctrlTouchscreentouch6pressure(){} // RVA: 0x7FFE8798E3E0
        public void Initialize_ctrlTouchscreentouch6radius(){} // RVA: 0x7FFE8798E6E0
        public void Initialize_ctrlTouchscreentouch6phase(){} // RVA: 0x7FFE8798E9F0
        public void Initialize_ctrlTouchscreentouch6press(){} // RVA: 0x7FFE8798ED00
        public void Initialize_ctrlTouchscreentouch6tapCount(){} // RVA: 0x7FFE8798F060
        public void Initialize_ctrlTouchscreentouch6displayIndex(){} // RVA: 0x7FFE8798F360
        public void Initialize_ctrlTouchscreentouch6indirectTouch(){} // RVA: 0x7FFE8798F660
        public void Initialize_ctrlTouchscreentouch6tap(){} // RVA: 0x7FFE8798F9C0
        public void Initialize_ctrlTouchscreentouch6startTime(){} // RVA: 0x7FFE8798FD20
        public void Initialize_ctrlTouchscreentouch6startPosition(){} // RVA: 0x7FFE87990030
        public void Initialize_ctrlTouchscreentouch6positionx(){} // RVA: 0x7FFE87990350
        public void Initialize_ctrlTouchscreentouch6positiony(){} // RVA: 0x7FFE87990670
        public void Initialize_ctrlTouchscreentouch6deltaup(){} // RVA: 0x7FFE87990990
        public void Initialize_ctrlTouchscreentouch6deltadown(){} // RVA: 0x7FFE87990CC0
        public void Initialize_ctrlTouchscreentouch6deltaleft(){} // RVA: 0x7FFE87990FF0
        public void Initialize_ctrlTouchscreentouch6deltaright(){} // RVA: 0x7FFE87991320
        public void Initialize_ctrlTouchscreentouch6deltax(){} // RVA: 0x7FFE87991650
        public void Initialize_ctrlTouchscreentouch6deltay(){} // RVA: 0x7FFE87991950
        public void Initialize_ctrlTouchscreentouch6radiusx(){} // RVA: 0x7FFE87991C50
        public void Initialize_ctrlTouchscreentouch6radiusy(){} // RVA: 0x7FFE87991F50
        public void Initialize_ctrlTouchscreentouch6startPositionx(){} // RVA: 0x7FFE87992250
        public void Initialize_ctrlTouchscreentouch6startPositiony(){} // RVA: 0x7FFE87992550
        public void Initialize_ctrlTouchscreentouch7touchId(){} // RVA: 0x7FFE87992850
        public void Initialize_ctrlTouchscreentouch7position(){} // RVA: 0x7FFE87992B70
        public void Initialize_ctrlTouchscreentouch7delta(){} // RVA: 0x7FFE87992EA0
        public void Initialize_ctrlTouchscreentouch7pressure(){} // RVA: 0x7FFE879931B0
        public void Initialize_ctrlTouchscreentouch7radius(){} // RVA: 0x7FFE879934B0
        public void Initialize_ctrlTouchscreentouch7phase(){} // RVA: 0x7FFE879937C0
        public void Initialize_ctrlTouchscreentouch7press(){} // RVA: 0x7FFE87993AD0
        public void Initialize_ctrlTouchscreentouch7tapCount(){} // RVA: 0x7FFE87993E30
        public void Initialize_ctrlTouchscreentouch7displayIndex(){} // RVA: 0x7FFE87994130
        public void Initialize_ctrlTouchscreentouch7indirectTouch(){} // RVA: 0x7FFE87994430
        public void Initialize_ctrlTouchscreentouch7tap(){} // RVA: 0x7FFE87994790
        public void Initialize_ctrlTouchscreentouch7startTime(){} // RVA: 0x7FFE87994AF0
        public void Initialize_ctrlTouchscreentouch7startPosition(){} // RVA: 0x7FFE87994E00
        public void Initialize_ctrlTouchscreentouch7positionx(){} // RVA: 0x7FFE87995120
        public void Initialize_ctrlTouchscreentouch7positiony(){} // RVA: 0x7FFE87995440
        public void Initialize_ctrlTouchscreentouch7deltaup(){} // RVA: 0x7FFE87995760
        public void Initialize_ctrlTouchscreentouch7deltadown(){} // RVA: 0x7FFE87995A90
        public void Initialize_ctrlTouchscreentouch7deltaleft(){} // RVA: 0x7FFE87995DC0
        public void Initialize_ctrlTouchscreentouch7deltaright(){} // RVA: 0x7FFE879960F0
        public void Initialize_ctrlTouchscreentouch7deltax(){} // RVA: 0x7FFE87996420
        public void Initialize_ctrlTouchscreentouch7deltay(){} // RVA: 0x7FFE87996720
        public void Initialize_ctrlTouchscreentouch7radiusx(){} // RVA: 0x7FFE87996A20
        public void Initialize_ctrlTouchscreentouch7radiusy(){} // RVA: 0x7FFE87996D20
        public void Initialize_ctrlTouchscreentouch7startPositionx(){} // RVA: 0x7FFE87997020
        public void Initialize_ctrlTouchscreentouch7startPositiony(){} // RVA: 0x7FFE87997320
        public void Initialize_ctrlTouchscreentouch8touchId(){} // RVA: 0x7FFE87997620
        public void Initialize_ctrlTouchscreentouch8position(){} // RVA: 0x7FFE87997940
        public void Initialize_ctrlTouchscreentouch8delta(){} // RVA: 0x7FFE87997C70
        public void Initialize_ctrlTouchscreentouch8pressure(){} // RVA: 0x7FFE87997F80
        public void Initialize_ctrlTouchscreentouch8radius(){} // RVA: 0x7FFE87998280
        public void Initialize_ctrlTouchscreentouch8phase(){} // RVA: 0x7FFE87998590
        public void Initialize_ctrlTouchscreentouch8press(){} // RVA: 0x7FFE879988A0
        public void Initialize_ctrlTouchscreentouch8tapCount(){} // RVA: 0x7FFE87998C00
        public void Initialize_ctrlTouchscreentouch8displayIndex(){} // RVA: 0x7FFE87998F00
        public void Initialize_ctrlTouchscreentouch8indirectTouch(){} // RVA: 0x7FFE87999200
        public void Initialize_ctrlTouchscreentouch8tap(){} // RVA: 0x7FFE87999560
        public void Initialize_ctrlTouchscreentouch8startTime(){} // RVA: 0x7FFE879998C0
        public void Initialize_ctrlTouchscreentouch8startPosition(){} // RVA: 0x7FFE87999BD0
        public void Initialize_ctrlTouchscreentouch8positionx(){} // RVA: 0x7FFE87999EF0
        public void Initialize_ctrlTouchscreentouch8positiony(){} // RVA: 0x7FFE8799A210
        public void Initialize_ctrlTouchscreentouch8deltaup(){} // RVA: 0x7FFE8799A530
        public void Initialize_ctrlTouchscreentouch8deltadown(){} // RVA: 0x7FFE8799A860
        public void Initialize_ctrlTouchscreentouch8deltaleft(){} // RVA: 0x7FFE8799AB90
        public void Initialize_ctrlTouchscreentouch8deltaright(){} // RVA: 0x7FFE8799AEC0
        public void Initialize_ctrlTouchscreentouch8deltax(){} // RVA: 0x7FFE8799B1F0
        public void Initialize_ctrlTouchscreentouch8deltay(){} // RVA: 0x7FFE8799B4F0
        public void Initialize_ctrlTouchscreentouch8radiusx(){} // RVA: 0x7FFE8799B7F0
        public void Initialize_ctrlTouchscreentouch8radiusy(){} // RVA: 0x7FFE8799BAF0
        public void Initialize_ctrlTouchscreentouch8startPositionx(){} // RVA: 0x7FFE8799BDF0
        public void Initialize_ctrlTouchscreentouch8startPositiony(){} // RVA: 0x7FFE8799C0F0
        public void Initialize_ctrlTouchscreentouch9touchId(){} // RVA: 0x7FFE8799C3F0
        public void Initialize_ctrlTouchscreentouch9position(){} // RVA: 0x7FFE8799C710
        public void Initialize_ctrlTouchscreentouch9delta(){} // RVA: 0x7FFE8799CA40
        public void Initialize_ctrlTouchscreentouch9pressure(){} // RVA: 0x7FFE8799CD50
        public void Initialize_ctrlTouchscreentouch9radius(){} // RVA: 0x7FFE8799D050
        public void Initialize_ctrlTouchscreentouch9phase(){} // RVA: 0x7FFE8799D360
        public void Initialize_ctrlTouchscreentouch9press(){} // RVA: 0x7FFE8799D670
        public void Initialize_ctrlTouchscreentouch9tapCount(){} // RVA: 0x7FFE8799D9D0
        public void Initialize_ctrlTouchscreentouch9displayIndex(){} // RVA: 0x7FFE8799DCD0
        public void Initialize_ctrlTouchscreentouch9indirectTouch(){} // RVA: 0x7FFE8799DFD0
        public void Initialize_ctrlTouchscreentouch9tap(){} // RVA: 0x7FFE8799E330
        public void Initialize_ctrlTouchscreentouch9startTime(){} // RVA: 0x7FFE8799E690
        public void Initialize_ctrlTouchscreentouch9startPosition(){} // RVA: 0x7FFE8799E9A0
        public void Initialize_ctrlTouchscreentouch9positionx(){} // RVA: 0x7FFE8799ECC0
        public void Initialize_ctrlTouchscreentouch9positiony(){} // RVA: 0x7FFE8799EFE0
        public void Initialize_ctrlTouchscreentouch9deltaup(){} // RVA: 0x7FFE8799F300
        public void Initialize_ctrlTouchscreentouch9deltadown(){} // RVA: 0x7FFE8799F630
        public void Initialize_ctrlTouchscreentouch9deltaleft(){} // RVA: 0x7FFE8799F960
        public void Initialize_ctrlTouchscreentouch9deltaright(){} // RVA: 0x7FFE8799FC90
        public void Initialize_ctrlTouchscreentouch9deltax(){} // RVA: 0x7FFE8799FFC0
        public void Initialize_ctrlTouchscreentouch9deltay(){} // RVA: 0x7FFE879A02C0
        public void Initialize_ctrlTouchscreentouch9radiusx(){} // RVA: 0x7FFE879A05C0
        public void Initialize_ctrlTouchscreentouch9radiusy(){} // RVA: 0x7FFE879A08C0
        public void Initialize_ctrlTouchscreentouch9startPositionx(){} // RVA: 0x7FFE879A0BC0
        public void Initialize_ctrlTouchscreentouch9startPositiony(){} // RVA: 0x7FFE879A0EC0
    }

    public class Gamepad : InputDevice
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _buttonWest; // 0x190
        public UnityEngine.InputSystem.Controls.ButtonControl _buttonNorth; // 0x198
        public UnityEngine.InputSystem.Controls.ButtonControl _buttonSouth; // 0x1A0
        public UnityEngine.InputSystem.Controls.ButtonControl _buttonEast; // 0x1A8
        public UnityEngine.InputSystem.Controls.ButtonControl _leftStickButton; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl _rightStickButton; // 0x1B8
        public UnityEngine.InputSystem.Controls.ButtonControl _startButton; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl _selectButton; // 0x1C8
        public UnityEngine.InputSystem.Controls.DpadControl _dpad; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl _leftShoulder; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl _rightShoulder; // 0x1E0
        public UnityEngine.InputSystem.Controls.StickControl _leftStick; // 0x1E8
        public UnityEngine.InputSystem.Controls.StickControl _rightStick; // 0x1F0
        public UnityEngine.InputSystem.Controls.ButtonControl _leftTrigger; // 0x1F8
        public UnityEngine.InputSystem.Controls.ButtonControl _rightTrigger; // 0x200
        public UnityEngine.InputSystem.Gamepad _current;
        public UnityEngine.InputSystem.Haptics.DualMotorRumble m_Rumble; // 0x208
        public int s_GamepadCount; // 0x8
        public UnityEngine.InputSystem.Gamepad[] s_Gamepads; // 0x10
        public float _lowFrequencyMotorSpeed; // 0x10
        public float _highFrequencyMotorSpeed; // 0x14
        public object field_21; // 0x1AA
        public object field_22; // 0x1AB
        public object field_23; // 0x1AC
        public object field_24; // 0x1AD
        public object field_25; // 0x1AE

        // ── Methods ──
        public void get_buttonWest(){} // RVA: 0x7FFE81825EC0
        public void set_buttonWest(){} // RVA: 0x7FFE81B2A360
        public void get_buttonNorth(){} // RVA: 0x7FFE8181EA60
        public void set_buttonNorth(){} // RVA: 0x7FFE81B33630
        public void get_buttonSouth(){} // RVA: 0x7FFE81B32390
        public void set_buttonSouth(){} // RVA: 0x7FFE81B21CA0
        public void get_buttonEast(){} // RVA: 0x7FFE8182AF50
        public void set_buttonEast(){} // RVA: 0x7FFE81B08F90
        public void get_leftStickButton(){} // RVA: 0x7FFE81B23A60
        public void set_leftStickButton(){} // RVA: 0x7FFE81B2ACE0
        public void get_rightStickButton(){} // RVA: 0x7FFE81B164E0
        public void set_rightStickButton(){} // RVA: 0x7FFE81B38D70
        public void get_startButton(){} // RVA: 0x7FFE817EFE00
        public void set_startButton(){} // RVA: 0x7FFE81B0C930
        public void get_selectButton(){} // RVA: 0x7FFE81B16E90
        public void set_selectButton(){} // RVA: 0x7FFE81B290E0
        public void get_dpad(){} // RVA: 0x7FFE81B32320
        public void set_dpad(){} // RVA: 0x7FFE81B31B60
        public void get_leftShoulder(){} // RVA: 0x7FFE81B23D60
        public void set_leftShoulder(){} // RVA: 0x7FFE81B11520
        public void get_rightShoulder(){} // RVA: 0x7FFE816611A0
        public void set_rightShoulder(){} // RVA: 0x7FFE81B31CF0
        public void get_leftStick(){} // RVA: 0x7FFE81B27D50
        public void set_leftStick(){} // RVA: 0x7FFE81B34FD0
        public void get_rightStick(){} // RVA: 0x7FFE81B21230
        public void set_rightStick(){} // RVA: 0x7FFE81B374B0
        public void get_leftTrigger(){} // RVA: 0x7FFE81B20B40
        public void set_leftTrigger(){} // RVA: 0x7FFE81B2E610
        public void get_rightTrigger(){} // RVA: 0x7FFE81B14500
        public void set_rightTrigger(){} // RVA: 0x7FFE81B317A0
        public void get_aButton(){} // RVA: 0x7FFE81B32390
        public void get_bButton(){} // RVA: 0x7FFE8182AF50
        public void get_xButton(){} // RVA: 0x7FFE81825EC0
        public void get_yButton(){} // RVA: 0x7FFE8181EA60
        public void get_triangleButton(){} // RVA: 0x7FFE8181EA60
        public void get_squareButton(){} // RVA: 0x7FFE81825EC0
        public void get_circleButton(){} // RVA: 0x7FFE8182AF50
        public void get_crossButton(){} // RVA: 0x7FFE81B32390
        public void get_Item(){} // RVA: 0x7FFE87938950
        public void get_current(){} // RVA: 0x7FFE87938B70
        public void set_current(){} // RVA: 0x7FFE87938BB0
        public void get_all(){} // RVA: 0x7FFE87938C50
        public void FinishSetup(){} // RVA: 0x7FFE87938D10
        public void MakeCurrent(){} // RVA: 0x7FFE87939510
        public void OnAdded(){} // RVA: 0x7FFE87939520
        public void OnRemoved(){} // RVA: 0x7FFE879395A0
        public void PauseHaptics(){} // RVA: 0x7FFE87939730
        public void ResumeHaptics(){} // RVA: 0x7FFE87939750
        public void ResetHaptics(){} // RVA: 0x7FFE87939810
        public void SetMotorSpeeds(){} // RVA: 0x7FFE879398C0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class GravitySensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _gravity; // 0x190
        public UnityEngine.InputSystem.GravitySensor _current;

        // ── Methods ──
        public void get_gravity(){} // RVA: 0x7FFE81825EC0
        public void set_gravity(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AED40
        public void set_current(){} // RVA: 0x7FFE879AED80
        public void FinishSetup(){} // RVA: 0x7FFE879AEE20
        public void MakeCurrent(){} // RVA: 0x7FFE879AEED0
        public void OnRemoved(){} // RVA: 0x7FFE879AEEE0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class Gyroscope : Sensor
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _angularVelocity; // 0x190
        public UnityEngine.InputSystem.Gyroscope _current;

        // ── Methods ──
        public void get_angularVelocity(){} // RVA: 0x7FFE81825EC0
        public void set_angularVelocity(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AEB50
        public void set_current(){} // RVA: 0x7FFE879AEB90
        public void MakeCurrent(){} // RVA: 0x7FFE879AEC30
        public void OnRemoved(){} // RVA: 0x7FFE879AEC40
        public void FinishSetup(){} // RVA: 0x7FFE879AEC90
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class HingeAngle : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl _angle; // 0x190
        public UnityEngine.InputSystem.HingeAngle _current;

        // ── Methods ──
        public void get_angle(){} // RVA: 0x7FFE81825EC0
        public void set_angle(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879B00A0
        public void set_current(){} // RVA: 0x7FFE879B00E0
        public void MakeCurrent(){} // RVA: 0x7FFE879B0180
        public void OnRemoved(){} // RVA: 0x7FFE879B0190
        public void FinishSetup(){} // RVA: 0x7FFE879B01E0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class HumiditySensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl _relativeHumidity; // 0x190
        public UnityEngine.InputSystem.HumiditySensor _current;

        // ── Methods ──
        public void get_relativeHumidity(){} // RVA: 0x7FFE81825EC0
        public void set_relativeHumidity(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AFAD0
        public void set_current(){} // RVA: 0x7FFE879AFB10
        public void MakeCurrent(){} // RVA: 0x7FFE879AFBB0
        public void OnRemoved(){} // RVA: 0x7FFE879AFBC0
        public void FinishSetup(){} // RVA: 0x7FFE879AFC10
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class IInputActionCollection
    {
        // ── Methods ──
        public void get_bindingMask(){} // RVA: 0x7FFE810A1420
        public void set_bindingMask(){}
        public void get_devices(){} // RVA: 0x7FFE810A1420
        public void set_devices(){}
        public void get_controlSchemes(){}
        public void Contains(){} // RVA: 0x7FFE80E2F3B0
        public void Enable(){} // RVA: 0x7FFE80E45FE0
        public void Disable(){} // RVA: 0x7FFE80E45FE0
    }

    public class IInputActionCollection2
    {
        // ── Methods ──
        public void get_bindings(){} // RVA: 0x7FFE80E2E2E0
        public void FindAction(){} // RVA: 0x7FFE80E3EBB0
        public void FindBinding(){}
    }

    public class IInputInteraction
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE80E460A0
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class IInputInteraction`1
    {
    }

    public class InputAction : Object
    {
        public Unity.Profiling.ProfilerMarker k_InputActionEnableProfilerMarker;
        public Unity.Profiling.ProfilerMarker k_InputActionDisableProfilerMarker; // 0x8
        public string m_Name; // 0x10
        public 0x6653F544 m_Type; // 0x18
        public string m_ExpectedControlType; // 0x20
        public string m_Id; // 0x28
        public string m_Processors; // 0x30
        public string m_Interactions; // 0x38
        public UnityEngine.InputSystem.InputBinding[] m_SingletonActionBindings; // 0x40
        public 0x6653E3BC m_Flags; // 0x48
        public System.Nullable`1<UnityEngine.InputSystem.InputBinding> m_BindingMask; // 0x50
        public int m_BindingsStartIndex; // 0xB0
        public int m_BindingsCount; // 0xB4
        public int m_ControlStartIndex; // 0xB8
        public int m_ControlCount; // 0xBC
        public int m_ActionIndexInState; // 0xC0
        public UnityEngine.InputSystem.InputActionMap m_ActionMap; // 0xC8
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<CallbackContext>> m_OnStarted; // 0xD0
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<CallbackContext>> m_OnCanceled; // 0x120
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<CallbackContext>> m_OnPerformed; // 0x170

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81116380
        public void get_type(){} // RVA: 0x7FFE813DB630
        public void get_id(){} // RVA: 0x7FFE878C3250
        public void get_idDontGenerate(){} // RVA: 0x7FFE878C32A0
        public void get_expectedControlType(){} // RVA: 0x7FFE811290C0
        public void set_expectedControlType(){} // RVA: 0x7FFE811290D0
        public void get_processors(){} // RVA: 0x7FFE8144E200
        public void get_interactions(){} // RVA: 0x7FFE8143BA80
        public void get_actionMap(){} // RVA: 0x7FFE878C33A0
        public void get_bindingMask(){} // RVA: 0x7FFE84E93260
        public void set_bindingMask(){} // RVA: 0x7FFE878C33C0
        public void get_bindings(){} // RVA: 0x7FFE878C3720
        public void get_controls(){} // RVA: 0x7FFE878C3820
        public void get_phase(){} // RVA: 0x7FFE878C3950
        public void get_inProgress(){} // RVA: 0x7FFE878C39B0
        public void get_enabled(){} // RVA: 0x7FFE878C3A10
        public void add_started(){} // RVA: 0x7FFE878C3A70
        public void remove_started(){} // RVA: 0x7FFE878C3AD0
        public void add_canceled(){} // RVA: 0x7FFE878C3B30
        public void remove_canceled(){} // RVA: 0x7FFE878C3B90
        public void add_performed(){} // RVA: 0x7FFE878C3BF0
        public void remove_performed(){} // RVA: 0x7FFE878C3C50
        public void get_triggered(){} // RVA: 0x7FFE878C3CB0
        public void get_activeControl(){} // RVA: 0x7FFE878C3D50
        public void get_activeValueType(){} // RVA: 0x7FFE878C3DD0
        public void get_wantsInitialStateCheck(){} // RVA: 0x7FFE878C3E40
        public void set_wantsInitialStateCheck(){} // RVA: 0x7FFE878C3E60
        public void .ctor(){} // RVA: 0x7FFE878C3F70 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE878C4540
        public void ToString(){} // RVA: 0x7FFE878C4560
        public void Enable(){} // RVA: 0x7FFE878C4870
        public void Disable(){} // RVA: 0x7FFE878C4BB0
        public void Clone(){} // RVA: 0x7FFE878C4EB0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE878C5160
        public void ReadValue(){} // RVA: 0x7FFE810A1420
        public void ReadValueAsObject(){} // RVA: 0x7FFE878C5170
        public void GetControlMagnitude(){} // RVA: 0x7FFE878C51F0
        public void Reset(){} // RVA: 0x7FFE878C5250
        public void IsPressed(){} // RVA: 0x7FFE878C52F0
        public void IsInProgress(){} // RVA: 0x7FFE878C5350
        public void ExpectedFrame(){} // RVA: 0x7FFE878C53C0
        public void WasPressedThisFrame(){} // RVA: 0x7FFE878C5470
        public void WasPressedThisDynamicUpdate(){} // RVA: 0x7FFE878C5510
        public void WasReleasedThisFrame(){} // RVA: 0x7FFE878C5580
        public void WasReleasedThisDynamicUpdate(){} // RVA: 0x7FFE878C5620
        public void WasPerformedThisFrame(){} // RVA: 0x7FFE878C3CB0
        public void WasPerformedThisDynamicUpdate(){} // RVA: 0x7FFE878C5690
        public void WasCompletedThisFrame(){} // RVA: 0x7FFE878C5700
        public void WasCompletedThisDynamicUpdate(){} // RVA: 0x7FFE878C57A0
        public void GetTimeoutCompletionPercentage(){} // RVA: 0x7FFE878C5810
        public void get_isSingletonAction(){} // RVA: 0x7FFE878C5950
        public void get_currentState(){} // RVA: 0x7FFE878C5970
        public void MakeSureIdIsInPlace(){} // RVA: 0x7FFE878C5A00
        public void GenerateId(){} // RVA: 0x7FFE878C5A30
        public void GetOrCreateActionMap(){} // RVA: 0x7FFE878C5B10
        public void CreateInternalActionMapForSingletonAction(){} // RVA: 0x7FFE878C5B50
        public void RequestInitialStateCheckOnEnabledAction(){} // RVA: 0x7FFE878C5D90
        public void ActiveControlIsValid(){} // RVA: 0x7FFE878C5E60
        public void FindEffectiveBindingMask(){} // RVA: 0x7FFE878C5F60
        public void BindingIndexOnActionToBindingIndexOnMap(){} // RVA: 0x7FFE878C6090
        public void BindingIndexOnMapToBindingIndexOnAction(){} // RVA: 0x7FFE878C6240
        public void .cctor(){} // RVA: 0x7FFE878C63D0
    }

    public class InputActionAsset : ScriptableObject
    {
        public string Extension;
        public string kDefaultAssetLayoutJson;
        public UnityEngine.InputSystem.InputActionMap[] m_ActionMaps; // 0x18
        public UnityEngine.InputSystem.InputControlScheme[] m_ControlSchemes; // 0x20
        public bool m_IsProjectWide; // 0x28
        public UnityEngine.InputSystem.InputActionState m_SharedStateForAllMaps; // 0x30
        public System.Nullable`1<UnityEngine.InputSystem.InputBinding> m_BindingMask; // 0x38

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFE878C7120
        public void get_actionMaps(){} // RVA: 0x7FFE878C72F0
        public void get_controlSchemes(){} // RVA: 0x7FFE878C73B0
        public void get_bindings(){} // RVA: 0x7FFE878C7470
        public void get_bindingMask(){} // RVA: 0x7FFE878C7520
        public void set_bindingMask(){} // RVA: 0x7FFE878C7560
        public void get_devices(){} // RVA: 0x7FFE878C7780
        public void set_devices(){} // RVA: 0x7FFE878C77C0
        public void get_Item(){} // RVA: 0x7FFE878C7840
        public void ToJson(){} // RVA: 0x7FFE878C78D0
        public void LoadFromJson(){} // RVA: 0x7FFE878C7BC0
        public void FromJson(){} // RVA: 0x7FFE878C7D80
        public void FindAction(){} // RVA: 0x7FFE878C8950 | overloaded x2
        public void FindBinding(){} // RVA: 0x7FFE878C83E0
        public void FindActionMap(){} // RVA: 0x7FFE878C8840 | overloaded x2
        public void FindControlSchemeIndex(){} // RVA: 0x7FFE878C8AD0
        public void FindControlScheme(){} // RVA: 0x7FFE878C8C70
        public void IsUsableWithDevice(){} // RVA: 0x7FFE878C8DF0
        public void Enable(){} // RVA: 0x7FFE878C8F50
        public void Disable(){} // RVA: 0x7FFE878C9160
        public void Contains(){} // RVA: 0x7FFE878C9330
        public void GetEnumerator(){} // RVA: 0x7FFE878C94B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE878C9550
        public void MarkAsDirty(){} // RVA: 0x7FFE810FB310
        public void IsEmpty(){} // RVA: 0x7FFE878C9560
        public void OnWantToChangeSetup(){} // RVA: 0x7FFE878C95F0
        public void OnSetupChanged(){} // RVA: 0x7FFE878C9660
        public void ReResolveIfNecessary(){} // RVA: 0x7FFE878C9730
        public void ResolveBindingsIfNecessary(){} // RVA: 0x7FFE878C9770
        public void OnDestroy(){} // RVA: 0x7FFE878C9810
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class InputActionMap : Object
    {
        public Unity.Profiling.ProfilerMarker k_ResolveBindingsProfilerMarker;
        public string m_Name; // 0x10
        public string m_Id; // 0x18
        public UnityEngine.InputSystem.InputActionAsset m_Asset; // 0x20
        public UnityEngine.InputSystem.InputAction[] m_Actions; // 0x28
        public UnityEngine.InputSystem.InputBinding[] m_Bindings; // 0x30
        public UnityEngine.InputSystem.InputBinding[] m_BindingsForEachAction; // 0x38
        public UnityEngine.InputSystem.InputControl[] m_ControlsForEachAction; // 0x40
        public int m_EnabledActionsCount; // 0x48
        public UnityEngine.InputSystem.InputAction m_SingletonAction; // 0x50
        public int m_MapIndexInState; // 0x58
        public UnityEngine.InputSystem.InputActionState m_State; // 0x60
        public System.Nullable`1<UnityEngine.InputSystem.InputBinding> m_BindingMask; // 0x68
        public 0x6653E72C m_Flags; // 0xC8
        public int m_ParameterOverridesCount; // 0xCC
        public ParameterOverride[] m_ParameterOverrides; // 0xD0

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81116380
        public void get_asset(){} // RVA: 0x7FFE811290C0
        public void get_id(){} // RVA: 0x7FFE878CA180
        public void get_idDontGenerate(){} // RVA: 0x7FFE878CA1D0
        public void get_enabled(){} // RVA: 0x7FFE8723EE30
        public void get_actions(){} // RVA: 0x7FFE878CA2D0
        public void get_bindings(){} // RVA: 0x7FFE878CA390
        public void UnityEngine.InputSystem.IInputActionCollection2.get_bindings(){} // RVA: 0x7FFE878CA450
        public void get_controlSchemes(){} // RVA: 0x7FFE878CA4B0
        public void get_bindingMask(){} // RVA: 0x7FFE878CA5C0
        public void set_bindingMask(){} // RVA: 0x7FFE878CA600
        public void get_devices(){} // RVA: 0x7FFE878CA810
        public void set_devices(){} // RVA: 0x7FFE878CA8F0
        public void get_Item(){} // RVA: 0x7FFE878CA940
        public void add_actionTriggered(){} // RVA: 0x7FFE878CAA50
        public void remove_actionTriggered(){} // RVA: 0x7FFE878CAAB0
        public void .ctor(){} // RVA: 0x7FFE878CAB80 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE878CAC40
        public void FindActionIndex(){} // RVA: 0x7FFE878CB1A0 | overloaded x2
        public void SetUpActionLookupTable(){} // RVA: 0x7FFE878CAF50
        public void ClearActionLookupTable(){} // RVA: 0x7FFE878CB150
        public void FindAction(){} // RVA: 0x7FFE878CB3E0 | overloaded x2
        public void IsUsableWithDevice(){} // RVA: 0x7FFE878CB510
        public void Enable(){} // RVA: 0x7FFE878CB610
        public void Disable(){} // RVA: 0x7FFE878CB680
        public void Clone(){} // RVA: 0x7FFE878CB6B0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE878CBC80
        public void Contains(){} // RVA: 0x7FFE878CBC90
        public void ToString(){} // RVA: 0x7FFE878CBCC0
        public void GetEnumerator(){} // RVA: 0x7FFE878CBE20
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE878CBE20
        public void get_needToResolveBindings(){} // RVA: 0x7FFE878CBF50
        public void set_needToResolveBindings(){} // RVA: 0x7FFE878CBF60
        public void get_bindingResolutionNeedsFullReResolve(){} // RVA: 0x7FFE878CBF80
        public void set_bindingResolutionNeedsFullReResolve(){} // RVA: 0x7FFE878CBF90
        public void get_controlsForEachActionInitialized(){} // RVA: 0x7FFE878CBFB0
        public void set_controlsForEachActionInitialized(){} // RVA: 0x7FFE878CBFC0
        public void get_bindingsForEachActionInitialized(){} // RVA: 0x7FFE878CBFE0
        public void set_bindingsForEachActionInitialized(){} // RVA: 0x7FFE878CBFF0
        public void GetBindingsForSingleAction(){} // RVA: 0x7FFE878CC010
        public void GetControlsForSingleAction(){} // RVA: 0x7FFE878CC0F0
        public void SetUpPerActionControlAndBindingArrays(){} // RVA: 0x7FFE878CC1D0
        public void OnWantToChangeSetup(){} // RVA: 0x7FFE878CCF50
        public void OnSetupChanged(){} // RVA: 0x7FFE878CD2C0
        public void OnBindingModified(){} // RVA: 0x7FFE878CD630
        public void ClearCachedActionData(){} // RVA: 0x7FFE878CD660
        public void GenerateId(){} // RVA: 0x7FFE878CD780
        public void LazyResolveBindings(){} // RVA: 0x7FFE878CD860
        public void ResolveBindingsIfNecessary(){} // RVA: 0x7FFE878CD9A0
        public void ResolveBindings(){} // RVA: 0x7FFE878CD9E0
        public void FindBinding(){} // RVA: 0x7FFE878CEBB0
        public void FindBindingRelativeToMap(){} // RVA: 0x7FFE878CEEE0
        public void FromJson(){} // RVA: 0x7FFE878CEF90
        public void ToJson(){} // RVA: 0x7FFE878CF1E0 | overloaded x2
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void OnAfterDeserialize(){} // RVA: 0x7FFE878CF360
        public void .cctor(){} // RVA: 0x7FFE878CF520
    }

    public class InputActionProperty : ValueType
    {
        public bool m_UseReference; // 0x10
        public UnityEngine.InputSystem.InputAction m_Action; // 0x18
        public UnityEngine.InputSystem.InputActionReference m_Reference; // 0x20
        public object field_3; // 0xD1

        // ── Methods ──
        public void get_action(){} // RVA: 0x7FFE878E0C50
        public void get_reference(){} // RVA: 0x7FFE878E0D50
        public void get_serializedAction(){} // RVA: 0x7FFE826F4210
        public void get_serializedReference(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE878E0E10 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE878E1180 | overloaded x4
        public void GetHashCode(){} // RVA: 0x7FFE878E1260
        public void op_Equality(){} // RVA: 0x7FFE878E1380
        public void op_Inequality(){} // RVA: 0x7FFE878E13B0
    }

    public class InputActionRebindingExtensions : Object
    {
        // ── Methods ──
        public void GetParameterValue(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void ApplyParameterOverride(){} // RVA: 0x7FFE878D4110 | overloaded x8
        public void ExtractParameterOverride(){} // RVA: 0x7FFE810A1420
        public void GetBindingIndex(){} // RVA: 0x7FFE878D5220 | overloaded x3
        public void GetBindingForControl(){} // RVA: 0x7FFE878D5350
        public void GetBindingIndexForControl(){} // RVA: 0x7FFE878D5630
        public void GetBindingDisplayString(){} // RVA: 0x7FFE878D5F30 | overloaded x4
        public void ApplyBindingOverride(){} // RVA: 0x7FFE878D71B0 | overloaded x6
        public void RemoveBindingOverride(){} // RVA: 0x7FFE878D7620 | overloaded x3
        public void RemoveAllBindingOverrides(){} // RVA: 0x7FFE878D7AD0 | overloaded x2
        public void ApplyBindingOverrides(){} // RVA: 0x7FFE878D7CE0
        public void RemoveBindingOverrides(){} // RVA: 0x7FFE878D7FA0
        public void ApplyBindingOverridesOnMatchingControls(){} // RVA: 0x7FFE878D86F0 | overloaded x2
        public void SaveBindingOverridesAsJson(){} // RVA: 0x7FFE878D8C40 | overloaded x2
        public void AddBindingOverrideJsonTo(){} // RVA: 0x7FFE878D90F0
        public void LoadBindingOverridesFromJson(){} // RVA: 0x7FFE878D9420 | overloaded x2
        public void LoadBindingOverridesFromJsonInternal(){} // RVA: 0x7FFE878D9560
        public void PerformInteractiveRebinding(){} // RVA: 0x7FFE878D9C70
        public void DeferBindingResolution(){} // RVA: 0x7FFE878DA2D0
    }

    public class InputActionReference : ScriptableObject
    {
        public UnityEngine.InputSystem.InputActionAsset m_Asset; // 0x18
        public string m_ActionId; // 0x20

        // ── Methods ──
        public void get_asset(){} // RVA: 0x7FFE810FE7C0
        public void get_action(){} // RVA: 0x7FFE878E13E0
        public void Set(){} // RVA: 0x7FFE878E1910 | overloaded x2
        public void SetInternal(){} // RVA: 0x7FFE878E1C60
        public void ToString(){} // RVA: 0x7FFE878E2040
        public void GetDisplayName(){} // RVA: 0x7FFE878E2280
        public void ToDisplayName(){} // RVA: 0x7FFE878E2300
        public void op_Implicit(){} // RVA: 0x7FFE878E23B0
        public void Create(){} // RVA: 0x7FFE878E23C0
        public void ResetCachedAction(){} // RVA: 0x7FFE878E2440
        public void ToInputAction(){} // RVA: 0x7FFE878E2620
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class InputActionSetupExtensions : Object
    {
        // ── Methods ──
        public void AddActionMap(){} // RVA: 0x7FFE878E2890 | overloaded x2
        public void RemoveActionMap(){} // RVA: 0x7FFE878E2ED0 | overloaded x2
        public void AddAction(){} // RVA: 0x7FFE878E3060
        public void RemoveAction(){} // RVA: 0x7FFE878E3CB0 | overloaded x2
        public void AddBinding(){} // RVA: 0x7FFE878E4BB0 | overloaded x7
        public void AddCompositeBinding(){} // RVA: 0x7FFE878E4D00
        public void AddBindingInternal(){} // RVA: 0x7FFE878E5090
        public void ChangeBinding(){} // RVA: 0x7FFE878E5D40 | overloaded x4
        public void ChangeBindingWithId(){} // RVA: 0x7FFE878E58D0 | overloaded x2
        public void ChangeBindingWithGroup(){} // RVA: 0x7FFE878E5A60
        public void ChangeBindingWithPath(){} // RVA: 0x7FFE878E5BD0
        public void ChangeCompositeBinding(){} // RVA: 0x7FFE878E60A0
        public void Rename(){} // RVA: 0x7FFE878E6490
        public void AddControlScheme(){} // RVA: 0x7FFE878E6BF0 | overloaded x2
        public void RemoveControlScheme(){} // RVA: 0x7FFE878E6EE0
        public void WithBindingGroup(){} // RVA: 0x7FFE878E7150
        public void WithDevice(){} // RVA: 0x7FFE878E72D0
        public void WithRequiredDevice(){} // RVA: 0x7FFE878E74F0
        public void WithOptionalDevice(){} // RVA: 0x7FFE878E7650
        public void OrWithRequiredDevice(){} // RVA: 0x7FFE878E77B0
        public void OrWithOptionalDevice(){} // RVA: 0x7FFE878E7910
    }

    public class InputActionState : Object
    {
        public int kInvalidIndex;
        public UnityEngine.InputSystem.InputActionMap[] maps; // 0x10
        public UnityEngine.InputSystem.InputControl[] controls; // 0x18
        public UnityEngine.InputSystem.IInputInteraction[] interactions; // 0x20
        public UnityEngine.InputSystem.InputProcessor[] processors; // 0x28
        public UnityEngine.InputSystem.InputBindingComposite[] composites; // 0x30
        public int totalProcessorCount; // 0x38
        public UnmanagedMemory memory; // 0x40
        public bool m_OnBeforeUpdateHooked; // 0xC0
        public bool m_OnAfterUpdateHooked; // 0xC1
        public bool m_InProcessControlStateChange; // 0xC2
        public UnityEngine.InputSystem.LowLevel.InputEventPtr m_CurrentlyProcessingThisEvent; // 0xC8
        public System.Action m_OnBeforeUpdateDelegate; // 0xD0
        public System.Action m_OnAfterUpdateDelegate; // 0xD8
        public Unity.Profiling.ProfilerMarker k_InputInitialActionStateCheckMarker;

        // ── Methods ──
        public void get_totalCompositeCount(){} // RVA: 0x7FFE813A7A20
        public void get_totalMapCount(){} // RVA: 0x7FFE8119C0C0
        public void get_totalActionCount(){} // RVA: 0x7FFE821E0A40
        public void get_totalBindingCount(){} // RVA: 0x7FFE819EA920
        public void get_totalInteractionCount(){} // RVA: 0x7FFE8139DAD0
        public void get_totalControlCount(){} // RVA: 0x7FFE8175AC90
        public void get_mapIndices(){} // RVA: 0x7FFE811660B0
        public void get_actionStates(){} // RVA: 0x7FFE81199370
        public void get_bindingStates(){} // RVA: 0x7FFE81176D50
        public void get_interactionStates(){} // RVA: 0x7FFE811C3590
        public void get_controlIndexToBindingIndex(){} // RVA: 0x7FFE8179C860
        public void get_controlGroupingAndComplexity(){} // RVA: 0x7FFE817AB5E0
        public void get_controlMagnitudes(){} // RVA: 0x7FFE81463AE0
        public void get_enabledControls(){} // RVA: 0x7FFE8113A010
        public void get_isProcessingControlStateChange(){} // RVA: 0x7FFE87413F70
        public void Initialize(){} // RVA: 0x7FFE878EAE80
        public void ComputeControlGroupingIfNecessary(){} // RVA: 0x7FFE878EAFA0
        public void ClaimDataFrom(){} // RVA: 0x7FFE878EB1A0
        public void Finalize(){} // RVA: 0x7FFE878EB3F0
        public void Dispose(){} // RVA: 0x7FFE878EB460
        public void Destroy(){} // RVA: 0x7FFE878EB470
        public void Clone(){} // RVA: 0x7FFE878EB7E0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFE878EBB10
        public void IsUsingDevice(){} // RVA: 0x7FFE878EBB20
        public void CanUseDevice(){} // RVA: 0x7FFE878EBCB0
        public void HasEnabledActions(){} // RVA: 0x7FFE878EBF80
        public void FinishBindingCompositeSetups(){} // RVA: 0x7FFE878EBFE0
        public void PrepareForBindingReResolution(){} // RVA: 0x7FFE878EC120
        public void FinishBindingResolution(){} // RVA: 0x7FFE878EC650
        public void RestoreActionStatesAfterReResolvingBindings(){} // RVA: 0x7FFE878EC850
        public void IsActiveControl(){} // RVA: 0x7FFE878ED140
        public void FindControlIndexOnBinding(){} // RVA: 0x7FFE878ED200
        public void ResetActionStatesDrivenBy(){} // RVA: 0x7FFE878ED270
        public void IsActionBoundToControlFromDevice(){} // RVA: 0x7FFE878ED3E0
        public void ResetActionState(){} // RVA: 0x7FFE878ED4F0
        public void FetchActionState(){} // RVA: 0x7FFE878ED740
        public void FetchMapIndices(){} // RVA: 0x7FFE878ED770
        public void EnableAllActions(){} // RVA: 0x7FFE878ED7C0
        public void EnableControls(){} // RVA: 0x7FFE878EE140 | overloaded x3
        public void EnableSingleAction(){} // RVA: 0x7FFE878ED990
        public void DisableAllActions(){} // RVA: 0x7FFE878F43B0 | overloaded x2
        public void DisableControls(){} // RVA: 0x7FFE878EE320 | overloaded x3
        public void DisableSingleAction(){} // RVA: 0x7FFE878EDEA0
        public void SetInitialStateCheckPending(){} // RVA: 0x7FFE878EE5B0 | overloaded x2
        public void IsControlEnabled(){} // RVA: 0x7FFE878EE5F0
        public void SetControlEnabled(){} // RVA: 0x7FFE878EE630
        public void HookOnBeforeUpdate(){} // RVA: 0x7FFE878EE670
        public void UnhookOnBeforeUpdate(){} // RVA: 0x7FFE878EE7F0
        public void OnBeforeInitialUpdate(){} // RVA: 0x7FFE878EE8C0
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFE878EEC80
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFE878EECD0
        public void ToCombinedMapAndControlAndBindingIndex(){} // RVA: 0x7FFE878EED20
        public void SplitUpMapAndControlAndBindingIndex(){} // RVA: 0x7FFE878EED60
        public void GetComplexityFromMonitorIndex(){} // RVA: 0x7FFE878EED90
        public void ProcessControlStateChange(){} // RVA: 0x7FFE878EEDA0
        public void ProcessButtonState(){} // RVA: 0x7FFE878EF550
        public void ShouldIgnoreInputOnCompositeBinding(){} // RVA: 0x7FFE878EF7A0
        public void IsConflictingInput(){} // RVA: 0x7FFE878EF7C0
        public void GetActionBindingStartIndexAndCount(){} // RVA: 0x7FFE878EFCD0
        public void ProcessDefaultInteraction(){} // RVA: 0x7FFE878EFD00
        public void ProcessInteractions(){} // RVA: 0x7FFE878F00C0
        public void ProcessTimeout(){} // RVA: 0x7FFE878F0350
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x7FFE878F0730
        public void StartTimeout(){} // RVA: 0x7FFE878F0770
        public void StopTimeout(){} // RVA: 0x7FFE878F0920
        public void ChangePhaseOfInteraction(){} // RVA: 0x7FFE878F0A00
        public void ChangePhaseOfAction(){} // RVA: 0x7FFE878F0FB0
        public void ChangePhaseOfActionInternal(){} // RVA: 0x7FFE878F1220
        public void CallActionListeners(){} // RVA: 0x7FFE878F1560
        public void GetActionOrNoneString(){} // RVA: 0x7FFE878F1880
        public void GetActionOrNull(){} // RVA: 0x7FFE878F1980 | overloaded x2
        public void GetControl(){} // RVA: 0x7FFE878F1A20
        public void GetInteractionOrNull(){} // RVA: 0x7FFE878F1A70
        public void GetBindingIndexInMap(){} // RVA: 0x7FFE878F1AB0
        public void GetBindingIndexInState(){} // RVA: 0x7FFE878F1B00
        public void GetBindingState(){} // RVA: 0x7FFE878F1B40
        public void GetBinding(){} // RVA: 0x7FFE878F1B50
        public void GetActionMap(){} // RVA: 0x7FFE878F1BD0
        public void ResetInteractionStateAndCancelIfNecessary(){} // RVA: 0x7FFE878F1C10
        public void ResetInteractionState(){} // RVA: 0x7FFE878F1CF0
        public void GetValueSizeInBytes(){} // RVA: 0x7FFE878F1DC0
        public void GetValueType(){} // RVA: 0x7FFE878F1E80
        public void IsActuated(){} // RVA: 0x7FFE878F1F40
        public void ReadValue(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ApplyProcessors(){} // RVA: 0x7FFE810A1420
        public void EvaluateCompositePartMagnitude(){} // RVA: 0x7FFE878F2280
        public void GetCompositePartPressTime(){} // RVA: 0x7FFE878F2370
        public void ReadCompositePartValue(){} // RVA: 0x7FFE878F23F0 | overloaded x2
        public void ReadCompositePartValueAsObject(){} // RVA: 0x7FFE878F2540
        public void ReadValueAsObject(){} // RVA: 0x7FFE878F2670
        public void ReadValueAsButton(){} // RVA: 0x7FFE878F28F0
        public void SaveAndResetState(){} // RVA: 0x7FFE878F2A60
        public void AddToGlobalList(){} // RVA: 0x7FFE878F3040
        public void RemoveMapFromGlobalList(){} // RVA: 0x7FFE878F30D0
        public void CompactGlobalList(){} // RVA: 0x7FFE878F3280
        public void NotifyListenersOfActionChange(){} // RVA: 0x7FFE878F36A0 | overloaded x2
        public void ResetGlobals(){} // RVA: 0x7FFE878F37D0
        public void FindAllEnabledActions(){} // RVA: 0x7FFE878F3A00
        public void OnDeviceChange(){} // RVA: 0x7FFE878F3CE0
        public void DeferredResolutionOfBindings(){} // RVA: 0x7FFE878F4080
        public void DestroyAllActionMapStates(){} // RVA: 0x7FFE878F4540
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE878F4790
    }

    public class InputBinding : ValueType
    {
        public char Separator;
        public string kSeparatorString;
        public string m_Name; // 0x10
        public string m_Id; // 0x18
        public string m_Path; // 0x20
        public string m_Interactions; // 0x28
        public string m_Processors; // 0x30
        public string m_Groups; // 0x38
        public string m_Action; // 0x40
        public 0x6653F64C m_Flags; // 0x48
        public string m_OverridePath; // 0x50
        public string m_OverrideInteractions; // 0x58
        public string m_OverrideProcessors; // 0x60
        public bool m_HaveValue; // 0x10
        public int m_DeviceCount; // 0x14
        public UnityEngine.InputSystem.InputDevice[] m_DeviceArray; // 0x18
        public object field_16; // 0x2DC0

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE8284EF60
        public void set_name(){} // RVA: 0x7FFE81D7E9E0
        public void get_id(){} // RVA: 0x7FFE878F5F40
        public void set_id(){} // RVA: 0x7FFE878F6040
        public void get_path(){} // RVA: 0x7FFE81116380
        public void set_path(){} // RVA: 0x7FFE810FCE30
        public void get_overridePath(){} // RVA: 0x7FFE81178740
        public void set_overridePath(){} // RVA: 0x7FFE81123200
        public void get_interactions(){} // RVA: 0x7FFE810FE7C0
        public void set_interactions(){} // RVA: 0x7FFE81161E80
        public void get_overrideInteractions(){} // RVA: 0x7FFE81176730
        public void set_overrideInteractions(){} // RVA: 0x7FFE81176740
        public void get_processors(){} // RVA: 0x7FFE811290C0
        public void set_processors(){} // RVA: 0x7FFE811290D0
        public void get_overrideProcessors(){} // RVA: 0x7FFE8119C0E0
        public void set_overrideProcessors(){} // RVA: 0x7FFE812534D0
        public void get_groups(){} // RVA: 0x7FFE81129130
        public void set_groups(){} // RVA: 0x7FFE810FCE90
        public void get_action(){} // RVA: 0x7FFE8144E200
        public void set_action(){} // RVA: 0x7FFE81129890
        public void get_isComposite(){} // RVA: 0x7FFE878F60E0
        public void set_isComposite(){} // RVA: 0x7FFE878F60F0
        public void get_isPartOfComposite(){} // RVA: 0x7FFE878F6110
        public void set_isPartOfComposite(){} // RVA: 0x7FFE878F6120
        public void get_hasOverrides(){} // RVA: 0x7FFE878F6140
        public void .ctor(){} // RVA: 0x7FFE878F6160
        public void GetNameOfComposite(){} // RVA: 0x7FFE878F6490
        public void GenerateId(){} // RVA: 0x7FFE878F6530
        public void RemoveOverrides(){} // RVA: 0x7FFE878F6610
        public void MaskByGroup(){} // RVA: 0x7FFE878F6710
        public void MaskByGroups(){} // RVA: 0x7FFE878F6790
        public void get_effectivePath(){} // RVA: 0x7FFE878F69C0
        public void get_effectiveInteractions(){} // RVA: 0x7FFE878F69D0
        public void get_effectiveProcessors(){} // RVA: 0x7FFE878F69E0
        public void get_isEmpty(){} // RVA: 0x7FFE878F69F0
        public void Equals(){} // RVA: 0x7FFE878F6DE0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE878F6EB0
        public void op_Inequality(){} // RVA: 0x7FFE878F6F00
        public void GetHashCode(){} // RVA: 0x7FFE878F6F90
        public void ToString(){} // RVA: 0x7FFE878F70C0
        public void ToDisplayString(){} // RVA: 0x7FFE878F7220 | overloaded x2
        public void TriggersAction(){} // RVA: 0x7FFE878F7720
        public void Matches(){} // RVA: 0x7FFE878F7860 | overloaded x2
    }

    public class InputBindingComposite : Object
    {
        public UnityEngine.InputSystem.Utilities.TypeTable s_Composites;
        public object field_1; // 0x135

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFE80E2E2E0
        public void get_valueSizeInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void ReadValue(){} // RVA: 0x7FFE810A1420
        public void ReadValueAsObject(){} // RVA: 0x7FFE80E2E390
        public void EvaluateMagnitude(){} // RVA: 0x7FFE878F7A90
        public void FinishSetup(){} // RVA: 0x7FFE810FB310
        public void CallFinishSetup(){} // RVA: 0x7FFE87739BF0
        public void GetValueType(){} // RVA: 0x7FFE878F7AA0
        public void GetExpectedControlLayoutName(){} // RVA: 0x7FFE878F7BE0
        public void GetPartNames(){} // RVA: 0x7FFE878F7D80
        public void GetDisplayFormatString(){} // RVA: 0x7FFE878F7E30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class InputBindingCompositeContext : ValueType
    {
        public UnityEngine.InputSystem.InputActionState m_State; // 0x10

        // ── Methods ──
        public void get_controls(){} // RVA: 0x7FFE8791E010
        public void EvaluateMagnitude(){} // RVA: 0x7FFE8791E0C0
        public void ReadValue(){} // RVA: 0x7FFE8791E260 | overloaded x5
        public void ReadValueAsButton(){} // RVA: 0x7FFE8791E1C0
        public void ReadValueAsObject(){} // RVA: 0x7FFE8791E3B0
        public void GetPressTime(){} // RVA: 0x7FFE8791E4F0
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFE80E2E2E0
        public void get_valueSizeInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void ReadValue(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ReadValueAsObject(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class InputBindingResolver : ValueType
    {
        public int totalProcessorCount; // 0x10
        public int totalCompositeCount; // 0x14
        public int totalInteractionCount; // 0x18
        public UnityEngine.InputSystem.InputActionMap[] maps; // 0x20

        // ── Methods ──
        public void get_totalMapCount(){} // RVA: 0x7FFE81549710
        public void get_totalActionCount(){} // RVA: 0x7FFE81F84A50
        public void get_totalBindingCount(){} // RVA: 0x7FFE82447220
        public void get_totalControlCount(){} // RVA: 0x7FFE81D46090
        public void Dispose(){} // RVA: 0x7FFE8791E880
        public void StartWithPreviousResolve(){} // RVA: 0x7FFE8791E890
        public void AddActionMap(){} // RVA: 0x7FFE8791ECC0
        public void InstantiateWithParameters(){} // RVA: 0x7FFE810A1420
        public void InstantiateBindingComposite(){} // RVA: 0x7FFE87920930
        public void ApplyParameters(){} // RVA: 0x7FFE87920CC0
        public void AssignCompositePartIndex(){} // RVA: 0x7FFE879211D0
    }

    public class InputControl : Object
    {
        public UnityEngine.InputSystem.LowLevel.InputStateBlock m_StateBlock; // 0x10
        public UnityEngine.InputSystem.Utilities.InternedString m_Name; // 0x20
        public string m_Path; // 0x30
        public string m_DisplayName; // 0x38
        public string m_DisplayNameFromLayout; // 0x40
        public string m_ShortDisplayName; // 0x48
        public string m_ShortDisplayNameFromLayout; // 0x50
        public UnityEngine.InputSystem.Utilities.InternedString m_Layout; // 0x58
        public UnityEngine.InputSystem.Utilities.InternedString m_Variants; // 0x68
        public UnityEngine.InputSystem.InputDevice m_Device; // 0x78
        public UnityEngine.InputSystem.InputControl m_Parent; // 0x80
        public int m_UsageCount; // 0x88
        public int m_UsageStartIndex; // 0x8C
        public int m_AliasCount; // 0x90
        public int m_AliasStartIndex; // 0x94
        public int m_ChildCount; // 0x98
        public int m_ChildStartIndex; // 0x9C
        public 0x66540044 m_ControlFlags; // 0xA0
        public bool m_CachedValueIsStale; // 0xA4
        public bool m_UnprocessedCachedValueIsStale; // 0xA5
        public UnityEngine.InputSystem.Utilities.PrimitiveValue m_DefaultState; // 0xA8
        public UnityEngine.InputSystem.Utilities.PrimitiveValue m_MinValue; // 0xB8
        public UnityEngine.InputSystem.Utilities.PrimitiveValue m_MaxValue; // 0xC8
        public UnityEngine.InputSystem.Utilities.FourCC m_OptimizedControlDataType; // 0xD8
        public uint InvalidOffset;
        public uint AutomaticOffset;
        public UnityEngine.InputSystem.Utilities.FourCC FormatInvalid;
        public int kFormatInvalid;
        public UnityEngine.InputSystem.Utilities.FourCC FormatBit; // 0x4
        public int kFormatBit;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE8792C340
        public void get_displayName(){} // RVA: 0x7FFE8792C3A0
        public void set_displayName(){} // RVA: 0x7FFE81437330
        public void get_shortDisplayName(){} // RVA: 0x7FFE8792C440
        public void set_shortDisplayName(){} // RVA: 0x7FFE81176740
        public void get_path(){} // RVA: 0x7FFE8792C4A0
        public void get_layout(){} // RVA: 0x7FFE8792C630
        public void get_variants(){} // RVA: 0x7FFE8792C690
        public void get_device(){} // RVA: 0x7FFE81463AE0
        public void get_parent(){} // RVA: 0x7FFE81280C30
        public void get_children(){} // RVA: 0x7FFE8792C6F0
        public void get_usages(){} // RVA: 0x7FFE8792C7B0
        public void get_aliases(){} // RVA: 0x7FFE8792C870
        public void get_stateBlock(){} // RVA: 0x7FFE826F6B90
        public void get_noisy(){} // RVA: 0x7FFE8792C930
        public void set_noisy(){} // RVA: 0x7FFE8792C940
        public void get_synthetic(){} // RVA: 0x7FFE8792CA40
        public void set_synthetic(){} // RVA: 0x7FFE8792CA50
        public void get_Item(){} // RVA: 0x7FFE8792CA70
        public void get_valueType(){} // RVA: 0x7FFE80E2E2E0
        public void get_valueSizeInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void get_magnitude(){} // RVA: 0x7FFE8792CB30
        public void ToString(){} // RVA: 0x7FFE8792CBB0
        public void DebuggerDisplay(){} // RVA: 0x7FFE8792CC60
        public void EvaluateMagnitude(){} // RVA: 0x7FFE878F7A90 | overloaded x2
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7FFE810A1420
        public void ReadValueFromStateAsObject(){} // RVA: 0x7FFE810A1420
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7FFE810A1420
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7FFE8792CDE0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7FFE8792CE50
        public void CompareValue(){} // RVA: 0x7FFE810A1420
        public void TryGetChildControl(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetChildControl(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE84241C00
        public void FinishSetup(){} // RVA: 0x7FFE810FB310
        public void RefreshConfigurationIfNeeded(){} // RVA: 0x7FFE8792D080
        public void RefreshConfiguration(){} // RVA: 0x7FFE810FB310
        public void get_currentStatePtr(){} // RVA: 0x7FFE8792D0C0
        public void get_previousFrameStatePtr(){} // RVA: 0x7FFE8792D120
        public void get_defaultStatePtr(){} // RVA: 0x7FFE8792D180
        public void get_noiseMaskPtr(){} // RVA: 0x7FFE8792D1C0
        public void get_stateOffsetRelativeToDeviceRoot(){} // RVA: 0x7FFE8792D200
        public void get_optimizedControlDataType(){} // RVA: 0x7FFE82A234F0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFE813240E0
        public void ApplyParameterChanges(){} // RVA: 0x7FFE8792D270
        public void SetOptimizedControlDataType(){} // RVA: 0x7FFE8792D340
        public void SetOptimizedControlDataTypeRecursively(){} // RVA: 0x7FFE8792D3E0
        public void EnsureOptimizationTypeHasNotChanged(){} // RVA: 0x7FFE8792D5D0
        public void get_isSetupFinished(){} // RVA: 0x7FFE8792DA00
        public void set_isSetupFinished(){} // RVA: 0x7FFE8792DA10
        public void get_isButton(){} // RVA: 0x7FFE8792DA30
        public void set_isButton(){} // RVA: 0x7FFE8792DA40
        public void get_isConfigUpToDate(){} // RVA: 0x7FFE8792DA60
        public void set_isConfigUpToDate(){} // RVA: 0x7FFE8792DA70
        public void get_dontReset(){} // RVA: 0x7FFE8792DA90
        public void set_dontReset(){} // RVA: 0x7FFE8792DAA0
        public void get_usesStateFromOtherControl(){} // RVA: 0x7FFE8792DAC0
        public void set_usesStateFromOtherControl(){} // RVA: 0x7FFE8792DAD0
        public void get_hasDefaultState(){} // RVA: 0x7FFE8792DAF0
        public void CallFinishSetupRecursive(){} // RVA: 0x7FFE8792DB00
        public void MakeChildPath(){} // RVA: 0x7FFE8792DBE0
        public void BakeOffsetIntoStateBlockRecursive(){} // RVA: 0x7FFE8792DC90
        public void GetDeviceIndex(){} // RVA: 0x7FFE8792DD80
        public void IsValueConsideredPressed(){} // RVA: 0x7FFE8792DEF0
        public void AddProcessor(){} // RVA: 0x7FFE810FB310
        public void MarkAsStale(){} // RVA: 0x7FFE8792DFA0
        public void MarkAsStaleRecursively(){} // RVA: 0x7FFE8792DFB0
    }

    public class InputControlExtensions : Object
    {
        // ── Methods ──
        public void FindInParentChain(){} // RVA: 0x7FFE810A1420
        public void IsPressed(){} // RVA: 0x7FFE8792E1C0
        public void IsActuated(){} // RVA: 0x7FFE8792E310
        public void ReadValueAsObject(){} // RVA: 0x7FFE8792E3B0
        public void ReadValueIntoBuffer(){} // RVA: 0x7FFE8792E430
        public void ReadDefaultValueAsObject(){} // RVA: 0x7FFE8792E530
        public void ReadValueFromEvent(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ReadValueFromEventAsObject(){} // RVA: 0x7FFE8792E5E0
        public void ReadUnprocessedValueFromEvent(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void WriteValueFromObjectIntoEvent(){} // RVA: 0x7FFE8792E710
        public void WriteValueIntoState(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void WriteValueIntoEvent(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void CopyState(){} // RVA: 0x7FFE80E462E0 | overloaded x2
        public void CheckStateIsAtDefault(){} // RVA: 0x7FFE8792ECD0 | overloaded x2
        public void CheckStateIsAtDefaultIgnoringNoise(){} // RVA: 0x7FFE8792EF40 | overloaded x2
        public void CompareStateIgnoringNoise(){} // RVA: 0x7FFE8792F090
        public void CompareState(){} // RVA: 0x7FFE8792F360 | overloaded x2
        public void HasValueChangeInState(){} // RVA: 0x7FFE8792F450
        public void HasValueChangeInEvent(){} // RVA: 0x7FFE8792F530
        public void GetStatePtrFromStateEvent(){} // RVA: 0x7FFE8792F630
        public void GetStatePtrFromStateEventUnchecked(){} // RVA: 0x7FFE8792F6F0
        public void ResetToDefaultStateInEvent(){} // RVA: 0x7FFE8792F9E0
        public void QueueValueChange(){} // RVA: 0x7FFE810A1420
        public void AccumulateValueInEvent(){} // RVA: 0x7FFE8792FD70 | overloaded x2
        public void FindControlsRecursive(){} // RVA: 0x7FFE80E4B8F0
        public void BuildPath(){} // RVA: 0x7FFE8792FE90
        public void EnumerateControls(){} // RVA: 0x7FFE879303B0
        public void EnumerateChangedControls(){} // RVA: 0x7FFE87930630
        public void HasButtonPress(){} // RVA: 0x7FFE87930680
        public void GetFirstButtonPressOrNull(){} // RVA: 0x7FFE879306A0
        public void GetAllButtonPresses(){} // RVA: 0x7FFE879308E0
        public void Setup(){} // RVA: 0x7FFE87930AA0 | overloaded x2
    }

    public class InputControlList`1 : ValueType
    {
        public int m_Count;
        public Unity.Collections.NativeArray`1<ulong> m_Indices;
        public 0x6657168C m_Allocator;
        public ulong kInvalidIndex;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_Capacity(){} // RVA: 0x7FFE80E2EDB0
        public void set_Capacity(){} // RVA: 0x7FFE80E46530
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void Resize(){} // RVA: 0x7FFE80E46530
        public void Add(){} // RVA: 0x7FFE810A1420
        public void AddSlice(){} // RVA: 0x7FFE810A1420
        public void AddRange(){}
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void IndexOf(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SwapElements(){} // RVA: 0x7FFE80E484C0
        public void Sort(){} // RVA: 0x7FFE810A1420
        public void ToArray(){}
        public void AppendTo(){} // RVA: 0x7FFE80E4F230
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void ToIndex(){} // RVA: 0x7FFE810A1420
        public void FromIndex(){} // RVA: 0x7FFE810A1420
    }

    public class InputControlPath : Object
    {
        // ── Methods ──
        public void CleanSlashes(){} // RVA: 0x7FFE87932FF0
        public void Combine(){} // RVA: 0x7FFE87933020
        public void ToHumanReadableString(){} // RVA: 0x7FFE87933160 | overloaded x2
        public void TryGetDeviceUsages(){} // RVA: 0x7FFE879337E0
        public void TryGetDeviceLayout(){} // RVA: 0x7FFE87933A20
        public void TryGetControlLayout(){} // RVA: 0x7FFE87933BD0
        public void FindControlLayoutRecursive(){} // RVA: 0x7FFE879340C0 | overloaded x2
        public void ControlLayoutMatchesPathComponent(){} // RVA: 0x7FFE87934370
        public void StringMatches(){} // RVA: 0x7FFE879345B0
        public void TryFindControl(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void TryFindControls(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void TryFindChild(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Matches(){} // RVA: 0x7FFE87934DA0
        public void MatchControlComponent(){} // RVA: 0x7FFE87934F50
        public void MatchesPrefix(){} // RVA: 0x7FFE87935390
        public void MatchesRecursive(){} // RVA: 0x7FFE87935550
        public void MatchControlsRecursive(){} // RVA: 0x7FFE810A1420
        public void MatchByUsageAtDeviceRootRecursive(){} // RVA: 0x7FFE810A1420
        public void MatchChildrenRecursive(){} // RVA: 0x7FFE810A1420
        public void MatchPathComponent(){} // RVA: 0x7FFE879355E0
        public void PathComponentCanYieldMultipleMatches(){} // RVA: 0x7FFE879359A0
        public void Parse(){} // RVA: 0x7FFE87935A60
    }

    public class InputControlScheme : ValueType
    {
        public string m_Name; // 0x10
        public string m_BindingGroup; // 0x18
        public DeviceRequirement[] m_DeviceRequirements; // 0x20

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE8284EF60
        public void get_bindingGroup(){} // RVA: 0x7FFE826F4210
        public void set_bindingGroup(){} // RVA: 0x7FFE826F4230
        public void get_deviceRequirements(){} // RVA: 0x7FFE87921450
        public void .ctor(){} // RVA: 0x7FFE87921510
        public void SetNameAndBindingGroup(){} // RVA: 0x7FFE87921700
        public void FindControlSchemeForDevices(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void FindControlSchemeForDevice(){} // RVA: 0x7FFE810A1420
        public void SupportsDevice(){} // RVA: 0x7FFE879218D0
        public void PickDevicesFrom(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE87921E30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87921ED0
        public void ToString(){} // RVA: 0x7FFE87921F80
        public void op_Equality(){} // RVA: 0x7FFE87922180
        public void op_Inequality(){} // RVA: 0x7FFE879221B0
    }

    public class InputControl`1 : InputControl
    {
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputProcessor`1<T>> m_ProcessorStack;
        public T m_CachedValue;
        public T m_UnprocessedCachedValue;
        public bool evaluateProcessorsEveryRead;
        public object field_4; // 0x18E

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFE80E2E2E0
        public void get_valueSizeInBytes(){} // RVA: 0x7FFE80E2EDB0
        public void get_value(){} // RVA: 0x7FFE80E2E2E0
        public void get_unprocessedValue(){} // RVA: 0x7FFE80E2E2E0
        public void ReadValue(){} // RVA: 0x7FFE810A1420
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7FFE810A1420
        public void ReadDefaultValue(){} // RVA: 0x7FFE810A1420
        public void ReadValueFromState(){} // RVA: 0x7FFE810A1420
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7FFE810A1420
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7FFE810A1420
        public void ReadUnprocessedValue(){} // RVA: 0x7FFE810A1420
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE810A1420
        public void ReadValueFromStateAsObject(){} // RVA: 0x7FFE810A1420
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7FFE810A1420
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7FFE810A1420
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7FFE810A1420
        public void WriteValueIntoState(){} // RVA: 0x7FFE810A1420
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7FFE810A1420
        public void CompareValue(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ProcessValue(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void TryGetProcessor(){} // RVA: 0x7FFE810A1420
        public void AddProcessor(){} // RVA: 0x7FFE80E460A0
        public void FinishSetup(){} // RVA: 0x7FFE80E45FE0
        public void get_processors(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class InputDevice : InputControl
    {
        public int InvalidDeviceId;
        public int kLocalParticipantId;
        public int kInvalidDeviceIndex;
        public 0x665408DC m_DeviceFlags; // 0xE0
        public int m_DeviceId; // 0xE4
        public int m_ParticipantId; // 0xE8
        public int m_DeviceIndex; // 0xEC
        public uint m_CurrentProcessedEventBytesOnUpdate; // 0xF0
        public UnityEngine.InputSystem.Layouts.InputDeviceDescription m_Description; // 0xF8
        public double m_LastUpdateTimeInternal; // 0x130
        public uint m_CurrentUpdateStepCount; // 0x138
        public UnityEngine.InputSystem.Utilities.InternedString[] m_AliasesForEachControl; // 0x140
        public UnityEngine.InputSystem.Utilities.InternedString[] m_UsagesForEachControl; // 0x148
        public UnityEngine.InputSystem.InputControl[] m_UsageToControl; // 0x150
        public UnityEngine.InputSystem.InputControl[] m_ChildrenForEachControl; // 0x158
        public System.Collections.Generic.HashSet`1<int> m_UpdatedButtons; // 0x160
        public System.Collections.Generic.List`1<UnityEngine.InputSystem.Controls.ButtonControl> m_ButtonControlsCheckingPressState; // 0x168
        public bool m_UseCachePathForButtonPresses; // 0x170
        public uint[] m_StateOffsetToControlMap; // 0x178
        public ControlBitRangeNode[] m_ControlTreeNodes; // 0x180
        public ushort[] m_ControlTreeIndices; // 0x188
        public int kControlIndexBits;
        public int kStateOffsetBits;

        // ── Methods ──
        public void get_description(){} // RVA: 0x7FFE879398F0
        public void get_enabled(){} // RVA: 0x7FFE87939930
        public void get_canRunInBackground(){} // RVA: 0x7FFE87939950
        public void get_canDeviceRunInBackground(){} // RVA: 0x7FFE87939950
        public void get_added(){} // RVA: 0x7FFE87939A20
        public void get_remote(){} // RVA: 0x7FFE87939A30
        public void get_native(){} // RVA: 0x7FFE87939A40
        public void get_updateBeforeRender(){} // RVA: 0x7FFE87939A50
        public void get_deviceId(){} // RVA: 0x7FFE82A3E370
        public void get_lastUpdateTime(){} // RVA: 0x7FFE87939A60
        public void get_wasUpdatedThisFrame(){} // RVA: 0x7FFE87939AB0
        public void get_allControls(){} // RVA: 0x7FFE87939B00
        public void get_valueType(){} // RVA: 0x7FFE87939BD0
        public void get_valueSizeInBytes(){} // RVA: 0x7FFE87939C80
        public void get_all(){} // RVA: 0x7FFE87939D10
        public void .ctor(){} // RVA: 0x7FFE87939DC0
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7FFE87939E30
        public void ReadValueFromStateAsObject(){} // RVA: 0x7FFE87939E70
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7FFE87939FC0
        public void CompareValue(){} // RVA: 0x7FFE8793A1C0
        public void NotifyConfigurationChanged(){} // RVA: 0x7FFE8793A330
        public void MakeCurrent(){} // RVA: 0x7FFE810FB310
        public void OnAdded(){} // RVA: 0x7FFE810FB310
        public void OnRemoved(){} // RVA: 0x7FFE810FB310
        public void OnConfigurationChanged(){} // RVA: 0x7FFE810FB310
        public void ExecuteCommand(){} // RVA: 0x7FFE8793A3C0 | overloaded x2
        public void QueryEnabledStateFromRuntime(){} // RVA: 0x7FFE8793A440
        public void get_disabledInFrontend(){} // RVA: 0x7FFE8793A500
        public void set_disabledInFrontend(){} // RVA: 0x7FFE8793A510
        public void get_disabledInRuntime(){} // RVA: 0x7FFE8793A530
        public void set_disabledInRuntime(){} // RVA: 0x7FFE8793A540
        public void get_disabledWhileInBackground(){} // RVA: 0x7FFE8793A570
        public void set_disabledWhileInBackground(){} // RVA: 0x7FFE8793A580
        public void EncodeStateOffsetToControlMapEntry(){} // RVA: 0x7FFE8793A5B0
        public void DecodeStateOffsetToControlMapEntry(){} // RVA: 0x7FFE8793A5C0
        public void get_hasControlsWithDefaultState(){} // RVA: 0x7FFE8793A5E0
        public void set_hasControlsWithDefaultState(){} // RVA: 0x7FFE8793A5F0
        public void get_hasDontResetControls(){} // RVA: 0x7FFE8793A610
        public void set_hasDontResetControls(){} // RVA: 0x7FFE8793A620
        public void get_hasStateCallbacks(){} // RVA: 0x7FFE8793A650
        public void set_hasStateCallbacks(){} // RVA: 0x7FFE8793A660
        public void get_hasEventMerger(){} // RVA: 0x7FFE8793A680
        public void set_hasEventMerger(){} // RVA: 0x7FFE8793A690
        public void get_hasEventPreProcessor(){} // RVA: 0x7FFE8793A6C0
        public void set_hasEventPreProcessor(){} // RVA: 0x7FFE8793A6D0
        public void AddDeviceUsage(){} // RVA: 0x7FFE8793A700
        public void RemoveDeviceUsage(){} // RVA: 0x7FFE8793A7C0
        public void ClearDeviceUsages(){} // RVA: 0x7FFE8793A990
        public void RequestSync(){} // RVA: 0x7FFE8793AA00
        public void RequestReset(){} // RVA: 0x7FFE8793AA80
        public void ExecuteEnableCommand(){} // RVA: 0x7FFE8793AB00
        public void ExecuteDisableCommand(){} // RVA: 0x7FFE8793AB80
        public void NotifyAdded(){} // RVA: 0x7FFE8713AA70
        public void NotifyRemoved(){} // RVA: 0x7FFE844E23A0
        public void Build(){} // RVA: 0x7FFE810A1420
        public void WriteChangedControlStates(){} // RVA: 0x7FFE8793ABF0
        public void WritePartialChangedControlStatesInternal(){} // RVA: 0x7FFE8793AD70
        public void DumpControlBitRangeNode(){} // RVA: 0x7FFE8793B180
        public void DumpControlTree(){} // RVA: 0x7FFE8793B820 | overloaded x2
        public void WriteChangedControlStatesInternal(){} // RVA: 0x7FFE8793B900
        public void HasDataChangedInRange(){} // RVA: 0x7FFE8793BE60
    }

    public class InputExtensions : Object
    {
        // ── Methods ──
        public void IsInProgress(){} // RVA: 0x7FFE86A9A530
        public void IsEndedOrCanceled(){} // RVA: 0x7FFE879B28B0
        public void IsActive(){} // RVA: 0x7FFE879B28C0
        public void IsModifierKey(){} // RVA: 0x7FFE879B28E0
        public void IsTextInputKey(){} // RVA: 0x7FFE879B28F0
    }

    public class InputFeatureNames : Object
    {
    }

    public class InputInteraction : Object
    {
        // ── Methods ──
        public void GetValueType(){} // RVA: 0x7FFE878C2ED0
        public void GetDisplayName(){} // RVA: 0x7FFE878C30B0 | overloaded x2
    }

    public class InputInteractionContext : ValueType
    {
        public UnityEngine.InputSystem.InputActionState m_State; // 0x10
        public 0x6653FD2C m_Flags; // 0x18
        public TriggerState m_TriggerState; // 0x1C
        public object field_3; // 0x158
        public object field_4; // 0x159
        public object field_5; // 0x15A
        public object field_6; // 0x15B
        public object field_7; // 0x15C
        public object field_8; // 0x15D
        public object field_9; // 0x15E
        public object field_10; // 0x15F
        public object field_11; // 0x160

        // ── Methods ──
        public void get_action(){} // RVA: 0x7FFE87923610
        public void get_control(){} // RVA: 0x7FFE87923640
        public void get_phase(){} // RVA: 0x7FFE82D45970
        public void get_time(){} // RVA: 0x7FFE87923690
        public void get_startTime(){} // RVA: 0x7FFE879236A0
        public void get_timerHasExpired(){} // RVA: 0x7FFE879228A0
        public void set_timerHasExpired(){} // RVA: 0x7FFE879228B0
        public void get_isWaiting(){} // RVA: 0x7FFE879236B0
        public void get_isStarted(){} // RVA: 0x7FFE879236C0
        public void ComputeMagnitude(){} // RVA: 0x7FFE811DA210
        public void ControlIsActuated(){} // RVA: 0x7FFE879236D0
        public void Started(){} // RVA: 0x7FFE87923770
        public void Performed(){} // RVA: 0x7FFE879237C0
        public void PerformedAndStayStarted(){} // RVA: 0x7FFE87923820
        public void PerformedAndStayPerformed(){} // RVA: 0x7FFE87923880
        public void Canceled(){} // RVA: 0x7FFE879238D0
        public void Waiting(){} // RVA: 0x7FFE87923920
        public void SetTimeout(){} // RVA: 0x7FFE87923970
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x7FFE879239A0
        public void ReadValue(){} // RVA: 0x7FFE810A1420
        public void get_mapIndex(){} // RVA: 0x7FFE87923A70
        public void get_controlIndex(){} // RVA: 0x7FFE87923A80
        public void get_bindingIndex(){} // RVA: 0x7FFE86B57020
        public void get_interactionIndex(){} // RVA: 0x7FFE87923AA0
    }

    public class InputManager : Object
    {
        public Unity.Profiling.ProfilerMarker k_InputUpdateProfilerMarker;
        public Unity.Profiling.ProfilerMarker k_InputTryFindMatchingControllerMarker; // 0x8
        public Unity.Profiling.ProfilerMarker k_InputAddDeviceMarker; // 0x10
        public Unity.Profiling.ProfilerMarker k_InputRestoreDevicesAfterReloadMarker; // 0x18
        public Unity.Profiling.ProfilerMarker k_InputRegisterCustomTypesMarker; // 0x20
        public Unity.Profiling.ProfilerMarker k_InputOnBeforeUpdateMarker; // 0x28
        public Unity.Profiling.ProfilerMarker k_InputOnAfterUpdateMarker; // 0x30
        public Unity.Profiling.ProfilerMarker k_InputOnSettingsChangeMarker; // 0x38
        public Unity.Profiling.ProfilerMarker k_InputOnDeviceSettingsChangeMarker; // 0x40
        public Unity.Profiling.ProfilerMarker k_InputOnEventMarker; // 0x48
        public Unity.Profiling.ProfilerMarker k_InputOnLayoutChangeMarker; // 0x50
        public Unity.Profiling.ProfilerMarker k_InputOnDeviceChangeMarker; // 0x58
        public Unity.Profiling.ProfilerMarker k_InputOnActionsChangeMarker; // 0x60
        public int m_LayoutRegistrationVersion; // 0x10
        public float m_PollingFrequency; // 0x14
        public Collection m_Layouts; // 0x18
        public UnityEngine.InputSystem.Utilities.TypeTable m_Processors; // 0x58
        public UnityEngine.InputSystem.Utilities.TypeTable m_Interactions; // 0x60

        // ── Methods ──
        public void get_devices(){} // RVA: 0x7FFE879B2910
        public void get_processors(){} // RVA: 0x7FFE811C3500
        public void get_interactions(){} // RVA: 0x7FFE81199370
        public void get_composites(){} // RVA: 0x7FFE81176D50
        public void get_metrics(){} // RVA: 0x7FFE879B29C0
        public void get_settings(){} // RVA: 0x7FFE81B241A0
        public void set_settings(){} // RVA: 0x7FFE879B2C00
        public void get_actions(){} // RVA: 0x7FFE81B33CF0
        public void set_actions(){} // RVA: 0x7FFE879B2E20
        public void get_updateMask(){} // RVA: 0x7FFE81A338E0
        public void set_updateMask(){} // RVA: 0x7FFE879B2E80
        public void get_defaultUpdateType(){} // RVA: 0x7FFE879B2EA0
        public void get_scrollDeltaBehavior(){} // RVA: 0x7FFE82A3E380
        public void set_scrollDeltaBehavior(){} // RVA: 0x7FFE879B2EE0
        public void get_pollingFrequency(){} // RVA: 0x7FFE81225340
        public void set_pollingFrequency(){} // RVA: 0x7FFE879B2EF0
        public void add_onDeviceChange(){} // RVA: 0x7FFE879B2FD0
        public void remove_onDeviceChange(){} // RVA: 0x7FFE879B3030
        public void add_onDeviceStateChange(){} // RVA: 0x7FFE879B3090
        public void remove_onDeviceStateChange(){} // RVA: 0x7FFE879B30F0
        public void add_onDeviceCommand(){} // RVA: 0x7FFE879B3150
        public void remove_onDeviceCommand(){} // RVA: 0x7FFE879B31B0
        public void add_onFindControlLayoutForDevice(){} // RVA: 0x7FFE879B3210
        public void remove_onFindControlLayoutForDevice(){} // RVA: 0x7FFE879B3270
        public void add_onLayoutChange(){} // RVA: 0x7FFE879B32D0
        public void remove_onLayoutChange(){} // RVA: 0x7FFE879B3330
        public void add_onEvent(){} // RVA: 0x7FFE879B3390
        public void remove_onEvent(){} // RVA: 0x7FFE879B33F0
        public void add_onBeforeUpdate(){} // RVA: 0x7FFE879B3450
        public void remove_onBeforeUpdate(){} // RVA: 0x7FFE879B34B0
        public void add_onAfterUpdate(){} // RVA: 0x7FFE879B3510
        public void remove_onAfterUpdate(){} // RVA: 0x7FFE879B3570
        public void add_onSettingsChange(){} // RVA: 0x7FFE879B35D0
        public void remove_onSettingsChange(){} // RVA: 0x7FFE879B3630
        public void add_onActionsChange(){} // RVA: 0x7FFE879B3690
        public void remove_onActionsChange(){} // RVA: 0x7FFE879B36F0
        public void get_isProcessingEvents(){} // RVA: 0x7FFE879B3750
        public void get_gameIsPlaying(){} // RVA: 0x7FFE811E0850
        public void get_gameHasFocus(){} // RVA: 0x7FFE879B3760
        public void get_gameShouldGetInputRegardlessOfFocus(){} // RVA: 0x7FFE879B37A0
        public void RegisterControlLayout(){} // RVA: 0x7FFE879B4020 | overloaded x2
        public void RegisterControlLayoutBuilder(){} // RVA: 0x7FFE879B4860
        public void PerformLayoutPostRegistration(){} // RVA: 0x7FFE879B4B10
        public void RegisterPrecompiledLayout(){} // RVA: 0x7FFE80E460A0
        public void RecreateDevicesUsingLayout(){} // RVA: 0x7FFE879B5330
        public void IsControlOrChildUsingLayoutRecursive(){} // RVA: 0x7FFE879B5570
        public void IsControlUsingLayout(){} // RVA: 0x7FFE879B5670
        public void RegisterControlLayoutMatcher(){} // RVA: 0x7FFE879B59C0 | overloaded x2
        public void RecreateDevicesUsingLayoutWithInferiorMatch(){} // RVA: 0x7FFE879B5C10
        public void RecreateDevice(){} // RVA: 0x7FFE879B5F50
        public void AddAvailableDevicesMatchingDescription(){} // RVA: 0x7FFE879B61A0
        public void RemoveControlLayout(){} // RVA: 0x7FFE879B6650
        public void TryLoadControlLayout(){} // RVA: 0x7FFE879B6C70 | overloaded x2
        public void TryFindMatchingControlLayout(){} // RVA: 0x7FFE879B6CA0
        public void FindOrRegisterDeviceLayoutForType(){} // RVA: 0x7FFE879B7290
        public void IsDeviceLayoutMarkedAsSupportedInSettings(){} // RVA: 0x7FFE879B7340
        public void ListControlLayouts(){} // RVA: 0x7FFE879B7480
        public void GetControls(){} // RVA: 0x7FFE80E38BF0
        public void SetDeviceUsage(){} // RVA: 0x7FFE879B7590
        public void AddDeviceUsage(){} // RVA: 0x7FFE879B7860
        public void RemoveDeviceUsage(){} // RVA: 0x7FFE879B79C0
        public void NotifyUsageChanged(){} // RVA: 0x7FFE879B7B20
        public void AddDevice(){} // RVA: 0x7FFE879B8F70 | overloaded x7
        public void RemoveDevice(){} // RVA: 0x7FFE879B90C0
        public void FlushDisconnectedDevices(){} // RVA: 0x7FFE879B9990
        public void ResetDevice(){} // RVA: 0x7FFE879B99F0
        public void TryGetDevice(){} // RVA: 0x7FFE879BA3B0 | overloaded x2
        public void GetDevice(){} // RVA: 0x7FFE879BA310
        public void TryGetDeviceById(){} // RVA: 0x7FFE879BA440
        public void GetUnsupportedDevices(){} // RVA: 0x7FFE879BA4C0
        public void EnableOrDisableDevice(){} // RVA: 0x7FFE879BA6B0
        public void QueueEvent(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void Update(){} // RVA: 0x7FFE879BABD0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFE879BAC30
        public void Destroy(){} // RVA: 0x7FFE879BADE0
        public void InitializeActions(){} // RVA: 0x7FFE879BB020
        public void InitializeData(){} // RVA: 0x7FFE879BB110
        public void RegisterCustomTypes(){} // RVA: 0x7FFE879BD910 | overloaded x2
        public void InstallRuntime(){} // RVA: 0x7FFE879BDBD0
        public void InstallGlobals(){} // RVA: 0x7FFE879BE000
        public void UninstallGlobals(){} // RVA: 0x7FFE879BE4B0
        public void get_optimizedControlsFeatureEnabled(){} // RVA: 0x7FFE879BE740
        public void set_optimizedControlsFeatureEnabled(){} // RVA: 0x7FFE879BE750
        public void get_readValueCachingFeatureEnabled(){} // RVA: 0x7FFE879BE760
        public void set_readValueCachingFeatureEnabled(){} // RVA: 0x7FFE879BE770
        public void get_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x7FFE879BE780
        public void set_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x7FFE879BE790
        public void MakeDeviceNameUnique(){} // RVA: 0x7FFE879BE7A0
        public void ResetControlPathsRecursive(){} // RVA: 0x7FFE879BEAB0
        public void AssignUniqueDeviceId(){} // RVA: 0x7FFE879BEBF0
        public void ReallocateStateBuffers(){} // RVA: 0x7FFE879BED60
        public void InitializeDefaultState(){} // RVA: 0x7FFE879BF040
        public void InitializeDeviceState(){} // RVA: 0x7FFE879BF230
        public void OnNativeDeviceDiscovered(){} // RVA: 0x7FFE879BF590
        public void MakeEscapedJsonString(){} // RVA: 0x7FFE879BFAF0
        public void TryMatchDisconnectedDevice(){} // RVA: 0x7FFE879BFE50
        public void InstallBeforeUpdateHookIfNecessary(){} // RVA: 0x7FFE879C0190
        public void RestoreDevicesAfterDomainReloadIfNecessary(){} // RVA: 0x7FFE810FB310
        public void WarnAboutDevicesFailingToRecreateAfterDomainReload(){} // RVA: 0x7FFE810FB310
        public void OnBeforeUpdate(){} // RVA: 0x7FFE879C0250
        public void ApplySettings(){} // RVA: 0x7FFE879C0570
        public void ApplyActions(){} // RVA: 0x7FFE879C0F00
        public void ExecuteGlobalCommand(){} // RVA: 0x7FFE80E2E390
        public void AddAvailableDevicesThatAreNowRecognized(){} // RVA: 0x7FFE879C0F90
        public void ShouldRunDeviceInBackground(){} // RVA: 0x7FFE879C12A0
        public void OnFocusChanged(){} // RVA: 0x7FFE879C12E0
        public void ShouldRunUpdate(){} // RVA: 0x7FFE879C1520
        public void OnUpdate(){} // RVA: 0x7FFE879C1540
        public void AreMaximumEventBytesPerUpdateExceeded(){} // RVA: 0x7FFE879C2870
        public void MakeStringWithEventsProcessedByDevice(){} // RVA: 0x7FFE879C29E0
        public void ResetCurrentProcessedEventBytesForDevices(){} // RVA: 0x7FFE879C2BC0
        public void CheckAllDevicesOptimizedControlsHaveValidState(){} // RVA: 0x7FFE879C2C90
        public void InvokeAfterUpdateCallback(){} // RVA: 0x7FFE879C2E90
        public void DontMakeCurrentlyUpdatingDeviceCurrent(){} // RVA: 0x7FFE879C2F30
        public void UpdateState(){} // RVA: 0x7FFE879C3050 | overloaded x2
        public void WriteStateChange(){} // RVA: 0x7FFE879C37C0
        public void FlipBuffersForDeviceIfNecessary(){} // RVA: 0x7FFE879C3B70
        public void AddStateChangeMonitor(){} // RVA: 0x7FFE879C3C20
        public void RemoveStateChangeMonitors(){} // RVA: 0x7FFE879C3DD0
        public void RemoveStateChangeMonitor(){} // RVA: 0x7FFE879C3FB0
        public void AddStateChangeMonitorTimeout(){} // RVA: 0x7FFE879C4200
        public void RemoveStateChangeMonitorTimeout(){} // RVA: 0x7FFE879C4390
        public void SortStateChangeMonitorsIfNecessary(){} // RVA: 0x7FFE879C4520
        public void SignalStateChangeMonitor(){} // RVA: 0x7FFE879C4570
        public void FireStateChangeNotifications(){} // RVA: 0x7FFE879C4BA0 | overloaded x2
        public void ProcessStateChangeMonitors(){} // RVA: 0x7FFE879C4780
        public void ProcessStateChangeMonitorTimeouts(){} // RVA: 0x7FFE879C4FA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE879C52E0
        public void <TryFindMatchingControlLayout>b__94_0(){} // RVA: 0x7FFE879C5940
    }

    public class InputProcessor : Object
    {
        public UnityEngine.InputSystem.Utilities.TypeTable s_Processors;

        // ── Methods ──
        public void ProcessAsObject(){} // RVA: 0x7FFE80E3FC10
        public void Process(){} // RVA: 0x7FFE810A1420
        public void GetValueTypeFromType(){} // RVA: 0x7FFE87938860
        public void get_cachingPolicy(){} // RVA: 0x7FFE813240E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ProcessAsObject(){} // RVA: 0x7FFE80E3FC10
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class InputRemoting : Object
    {
        public 0x66540EB4 m_Flags; // 0x10
        public UnityEngine.InputSystem.InputManager m_LocalManager; // 0x18

        // ── Methods ──
        public void get_sending(){} // RVA: 0x7FFE879A8F60
        public void set_sending(){} // RVA: 0x7FFE879A8F70
        public void .ctor(){} // RVA: 0x7FFE879A8F90
        public void StartSending(){} // RVA: 0x7FFE879A9050
        public void StopSending(){} // RVA: 0x7FFE879A9250
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x7FFE879A9430
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0x7FFE810FB310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0x7FFE810FB310
        public void Subscribe(){} // RVA: 0x7FFE879A96C0
        public void SendInitialMessages(){} // RVA: 0x7FFE879A9840
        public void SendAllGeneratedLayouts(){} // RVA: 0x7FFE879A9860
        public void SendLayout(){} // RVA: 0x7FFE879A9AE0
        public void SendAllDevices(){} // RVA: 0x7FFE879A9B80
        public void SendDevice(){} // RVA: 0x7FFE879A9DD0
        public void SendEvent(){} // RVA: 0x7FFE879A9E60
        public void SendDeviceChange(){} // RVA: 0x7FFE879A9EC0
        public void SendLayoutChange(){} // RVA: 0x7FFE879AA050
        public void Send(){} // RVA: 0x7FFE879AA1B0
        public void FindOrCreateSenderRecord(){} // RVA: 0x7FFE879AA2F0
        public void BuildLayoutNamespace(){} // RVA: 0x7FFE879AA3C0
        public void FindLocalDeviceId(){} // RVA: 0x7FFE879AA490
        public void TryGetDeviceByRemoteId(){} // RVA: 0x7FFE879AA500
        public void get_manager(){} // RVA: 0x7FFE810FE7C0
        public void RemoveRemoteDevices(){} // RVA: 0x7FFE879AA530
        public void SerializeData(){} // RVA: 0x7FFE810A1420
        public void DeserializeData(){} // RVA: 0x7FFE810A1420
    }

    public class InputSettings : ScriptableObject
    {
        public string[] m_SupportedDevices; // 0x18
        public 0x66541F8C m_UpdateMode; // 0x20
        public 0x66541FE4 m_ScrollDeltaBehavior; // 0x24
        public int m_MaxEventBytesPerUpdate; // 0x28
        public int m_MaxQueuedEventsPerUpdate; // 0x2C
        public bool m_CompensateForScreenOrientation; // 0x30
        public 0x6654203C m_BackgroundBehavior; // 0x34
        public 0x66542094 m_EditorInputBehaviorInPlayMode; // 0x38
        public 0x665420EC m_InputActionPropertyDrawerMode; // 0x3C
        public float m_DefaultDeadzoneMin; // 0x40
        public float m_DefaultDeadzoneMax; // 0x44
        public float m_DefaultButtonPressPoint; // 0x48
        public float m_ButtonReleaseThreshold; // 0x4C
        public float m_DefaultTapTime; // 0x50
        public float m_DefaultSlowTapTime; // 0x54
        public float m_DefaultHoldTime; // 0x58
        public float m_TapRadius; // 0x5C
        public float m_MultiTapDelayTime; // 0x60
        public bool m_DisableRedundantEventsMerging; // 0x64
        public bool m_ShortcutKeysConsumeInputs; // 0x65
        public System.Collections.Generic.HashSet`1<string> m_FeatureFlags; // 0x68

        // ── Methods ──
        public void get_updateMode(){} // RVA: 0x7FFE8151D690
        public void set_updateMode(){} // RVA: 0x7FFE879C8230
        public void get_scrollDeltaBehavior(){} // RVA: 0x7FFE81A56130
        public void set_scrollDeltaBehavior(){} // RVA: 0x7FFE879C8240
        public void get_compensateForScreenOrientation(){} // RVA: 0x7FFE81121450
        public void set_compensateForScreenOrientation(){} // RVA: 0x7FFE879C8250
        public void get_filterNoiseOnCurrent(){} // RVA: 0x7FFE810FB320
        public void set_filterNoiseOnCurrent(){} // RVA: 0x7FFE810FB310
        public void get_defaultDeadzoneMin(){} // RVA: 0x7FFE815E8460
        public void set_defaultDeadzoneMin(){} // RVA: 0x7FFE879C8260
        public void get_defaultDeadzoneMax(){} // RVA: 0x7FFE81103970
        public void set_defaultDeadzoneMax(){} // RVA: 0x7FFE879C8280
        public void get_defaultButtonPressPoint(){} // RVA: 0x7FFE81C1C360
        public void set_defaultButtonPressPoint(){} // RVA: 0x7FFE879C82A0
        public void get_buttonReleaseThreshold(){} // RVA: 0x7FFE81A74BC0
        public void set_buttonReleaseThreshold(){} // RVA: 0x7FFE879C82E0
        public void get_defaultTapTime(){} // RVA: 0x7FFE81163460
        public void set_defaultTapTime(){} // RVA: 0x7FFE879C8300
        public void get_defaultSlowTapTime(){} // RVA: 0x7FFE81604410
        public void set_defaultSlowTapTime(){} // RVA: 0x7FFE879C8320
        public void get_defaultHoldTime(){} // RVA: 0x7FFE81123FE0
        public void set_defaultHoldTime(){} // RVA: 0x7FFE879C8340
        public void get_tapRadius(){} // RVA: 0x7FFE81124000
        public void set_tapRadius(){} // RVA: 0x7FFE879C8360
        public void get_multiTapDelayTime(){} // RVA: 0x7FFE8120BE10
        public void set_multiTapDelayTime(){} // RVA: 0x7FFE879C8380
        public void get_backgroundBehavior(){} // RVA: 0x7FFE82447220
        public void set_backgroundBehavior(){} // RVA: 0x7FFE879C83A0
        public void get_editorInputBehaviorInPlayMode(){} // RVA: 0x7FFE81D46090
        public void set_editorInputBehaviorInPlayMode(){} // RVA: 0x7FFE879C83B0
        public void get_inputActionPropertyDrawerMode(){} // RVA: 0x7FFE816311C0
        public void set_inputActionPropertyDrawerMode(){} // RVA: 0x7FFE879C83C0
        public void get_maxEventBytesPerUpdate(){} // RVA: 0x7FFE81549710
        public void set_maxEventBytesPerUpdate(){} // RVA: 0x7FFE879C83D0
        public void get_maxQueuedEventsPerUpdate(){} // RVA: 0x7FFE81F84A50
        public void set_maxQueuedEventsPerUpdate(){} // RVA: 0x7FFE879C83E0
        public void get_supportedDevices(){} // RVA: 0x7FFE879C83F0
        public void set_supportedDevices(){} // RVA: 0x7FFE879C84B0
        public void get_disableRedundantEventsMerging(){} // RVA: 0x7FFE821FF050
        public void set_disableRedundantEventsMerging(){} // RVA: 0x7FFE879C8660
        public void get_shortcutKeysConsumeInput(){} // RVA: 0x7FFE872487A0
        public void set_shortcutKeysConsumeInput(){} // RVA: 0x7FFE879C8670
        public void SetInternalFeatureFlag(){} // RVA: 0x7FFE879C8680
        public void IsFeatureEnabled(){} // RVA: 0x7FFE879C8840
        public void OnChange(){} // RVA: 0x7FFE879C88C0
        public void CompareFloats(){} // RVA: 0x7FFE879C8A40
        public void CompareSets(){} // RVA: 0x7FFE810A1420
        public void CompareFeatureFlag(){} // RVA: 0x7FFE879C8A60
        public void AreEqual(){} // RVA: 0x7FFE879C8B50
        public void .ctor(){} // RVA: 0x7FFE879C9290
    }

    public class InputSystem : Object
    {
        public string kAssemblyVersion;
        public string kDocUrl;
        public Unity.Profiling.ProfilerMarker k_InputResetMarker;
        public float scrollWheelDeltaPerTick;
        public UnityEngine.InputSystem.InputManager s_Manager; // 0x8
        public UnityEngine.InputSystem.InputRemoting s_Remote; // 0x10
        public object onLayoutChange; // 0x5
        public System.Action`2<UnityEngine.InputSystem.InputDevice,0x665409E4> onLayoutChange; // 0xC650
        public object field_8;
        public object field_9; // 0xEA86
        public object field_10; // 0xE130
        public object field_11; // 0xC830

        // ── Methods ──
        public void add_onLayoutChange(){} // RVA: 0x7FFE87923AC0
        public void remove_onLayoutChange(){} // RVA: 0x7FFE87923CB0
        public void RegisterLayout(){} // RVA: 0x7FFE87924040 | overloaded x3
        public void RegisterLayoutOverride(){} // RVA: 0x7FFE87924150
        public void RegisterLayoutMatcher(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void RegisterLayoutBuilder(){} // RVA: 0x7FFE87924260
        public void RegisterPrecompiledLayout(){} // RVA: 0x7FFE80E46070
        public void RemoveLayout(){} // RVA: 0x7FFE87924430
        public void TryFindMatchingLayout(){} // RVA: 0x7FFE879244A0
        public void ListLayouts(){} // RVA: 0x7FFE87924570
        public void ListLayoutsBasedOn(){} // RVA: 0x7FFE879245E0
        public void LoadLayout(){} // RVA: 0x7FFE80E2DEE0 | overloaded x2
        public void GetNameOfBaseLayout(){} // RVA: 0x7FFE879247B0
        public void IsFirstLayoutBasedOnSecond(){} // RVA: 0x7FFE879249B0
        public void RegisterProcessor(){} // RVA: 0x7FFE80E46070 | overloaded x2
        public void TryGetProcessor(){} // RVA: 0x7FFE87925000
        public void ListProcessors(){} // RVA: 0x7FFE879250E0
        public void get_devices(){} // RVA: 0x7FFE87925160
        public void get_disconnectedDevices(){} // RVA: 0x7FFE879251E0
        public void add_onDeviceChange(){} // RVA: 0x7FFE879252D0
        public void remove_onDeviceChange(){} // RVA: 0x7FFE87925520
        public void add_onDeviceCommand(){} // RVA: 0x7FFE87925770
        public void remove_onDeviceCommand(){} // RVA: 0x7FFE879259C0
        public void add_onFindLayoutForDevice(){} // RVA: 0x7FFE87925C10
        public void remove_onFindLayoutForDevice(){} // RVA: 0x7FFE87925E10
        public void get_pollingFrequency(){} // RVA: 0x7FFE87926000
        public void set_pollingFrequency(){} // RVA: 0x7FFE87926070
        public void AddDevice(){} // RVA: 0x7FFE87926400 | overloaded x4
        public void RemoveDevice(){} // RVA: 0x7FFE879264C0
        public void FlushDisconnectedDevices(){} // RVA: 0x7FFE87926540
        public void GetDevice(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void GetDeviceById(){} // RVA: 0x7FFE87926930
        public void GetUnsupportedDevices(){} // RVA: 0x7FFE87926A30 | overloaded x2
        public void EnableDevice(){} // RVA: 0x7FFE87926C70
        public void DisableDevice(){} // RVA: 0x7FFE87926CF0
        public void TrySyncDevice(){} // RVA: 0x7FFE87926D80
        public void ResetDevice(){} // RVA: 0x7FFE87926E50
        public void TryResetDevice(){} // RVA: 0x7FFE87926EE0
        public void PauseHaptics(){} // RVA: 0x7FFE87926F50
        public void ResumeHaptics(){} // RVA: 0x7FFE879270A0
        public void ResetHaptics(){} // RVA: 0x7FFE879271F0
        public void SetDeviceUsage(){} // RVA: 0x7FFE87927430 | overloaded x2
        public void AddDeviceUsage(){} // RVA: 0x7FFE87927580 | overloaded x2
        public void RemoveDeviceUsage(){} // RVA: 0x7FFE879276D0 | overloaded x2
        public void FindControl(){} // RVA: 0x7FFE87927760
        public void FindControls(){} // RVA: 0x7FFE80E33B80 | overloaded x3
        public void get_isProcessingEvents(){} // RVA: 0x7FFE87927AA0
        public void get_onEvent(){} // RVA: 0x7FFE810FB320
        public void set_onEvent(){} // RVA: 0x7FFE810FB310
        public void get_onAnyButtonPress(){} // RVA: 0x7FFE87927B10
        public void QueueEvent(){} // RVA: 0x7FFE80E46070 | overloaded x2
        public void QueueStateEvent(){} // RVA: 0x7FFE810A1420
        public void QueueDeltaStateEvent(){} // RVA: 0x7FFE810A1420
        public void QueueConfigChangeEvent(){} // RVA: 0x7FFE87928200
        public void QueueTextEvent(){} // RVA: 0x7FFE87928440
        public void Update(){} // RVA: 0x7FFE87928780 | overloaded x2
        public void add_onBeforeUpdate(){} // RVA: 0x7FFE87928930
        public void remove_onBeforeUpdate(){} // RVA: 0x7FFE87928B30
        public void add_onAfterUpdate(){} // RVA: 0x7FFE87928D20
        public void remove_onAfterUpdate(){} // RVA: 0x7FFE87928F10
        public void get_settings(){} // RVA: 0x7FFE87929100
        public void set_settings(){} // RVA: 0x7FFE87929170
        public void add_onSettingsChange(){} // RVA: 0x7FFE879293B0
        public void remove_onSettingsChange(){} // RVA: 0x7FFE87929460
        public void EnableActions(){} // RVA: 0x7FFE87929510
        public void DisableActions(){} // RVA: 0x7FFE87929630
        public void get_actions(){} // RVA: 0x7FFE87929740
        public void set_actions(){} // RVA: 0x7FFE879297B0
        public void add_onActionsChange(){} // RVA: 0x7FFE87929A10
        public void remove_onActionsChange(){} // RVA: 0x7FFE87929AC0
        public void add_onActionChange(){} // RVA: 0x7FFE87929B70
        public void remove_onActionChange(){} // RVA: 0x7FFE87929C40
        public void RegisterInteraction(){} // RVA: 0x7FFE80E46070 | overloaded x2
        public void TryGetInteraction(){} // RVA: 0x7FFE87929EA0
        public void ListInteractions(){} // RVA: 0x7FFE87929F80
        public void RegisterBindingComposite(){} // RVA: 0x7FFE80E46070 | overloaded x2
        public void TryGetBindingComposite(){} // RVA: 0x7FFE8792A190
        public void DisableAllEnabledActions(){} // RVA: 0x7FFE8792A270
        public void ListEnabledActions(){} // RVA: 0x7FFE8792A560 | overloaded x2
        public void get_remoting(){} // RVA: 0x7FFE8792A600
        public void get_version(){} // RVA: 0x7FFE8792A660
        public void get_runInBackground(){} // RVA: 0x7FFE8792A790
        public void set_runInBackground(){} // RVA: 0x7FFE8792A820
        public void get_metrics(){} // RVA: 0x7FFE8792A8C0
        public void .cctor(){} // RVA: 0x7FFE8792A960
        public void RunInitializeInPlayer(){} // RVA: 0x7FFE8792AA10
        public void EnsureInitialized(){} // RVA: 0x7FFE810FB310
        public void InitializeInPlayer(){} // RVA: 0x7FFE8792AA90
        public void RunInitialUpdate(){} // RVA: 0x7FFE8792AE10
        public void PerformDefaultPluginInitialization(){} // RVA: 0x7FFE8792AEF0
    }

    public class InputValue : Object
    {
        public System.Nullable`1<CallbackContext> m_Context; // 0x10

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void get_isPressed(){} // RVA: 0x7FFE879CE590
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Joystick : InputDevice
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _trigger; // 0x190
        public UnityEngine.InputSystem.Controls.StickControl _stick; // 0x198
        public UnityEngine.InputSystem.Controls.AxisControl _twist; // 0x1A0
        public UnityEngine.InputSystem.Controls.Vector2Control _hatswitch; // 0x1A8
        public UnityEngine.InputSystem.Joystick _current;
        public int s_JoystickCount; // 0x8

        // ── Methods ──
        public void get_trigger(){} // RVA: 0x7FFE81825EC0
        public void set_trigger(){} // RVA: 0x7FFE81B2A360
        public void get_stick(){} // RVA: 0x7FFE8181EA60
        public void set_stick(){} // RVA: 0x7FFE81B33630
        public void get_twist(){} // RVA: 0x7FFE81B32390
        public void set_twist(){} // RVA: 0x7FFE81B21CA0
        public void get_hatswitch(){} // RVA: 0x7FFE8182AF50
        public void set_hatswitch(){} // RVA: 0x7FFE81B08F90
        public void get_current(){} // RVA: 0x7FFE8793CC30
        public void set_current(){} // RVA: 0x7FFE8793CC70
        public void get_all(){} // RVA: 0x7FFE8793CD10
        public void FinishSetup(){} // RVA: 0x7FFE8793CDD0
        public void MakeCurrent(){} // RVA: 0x7FFE8793D050
        public void OnAdded(){} // RVA: 0x7FFE8793D060
        public void OnRemoved(){} // RVA: 0x7FFE8793D0E0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class KeyEx : Object
    {
    }

    public class Keyboard : InputDevice
    {
        public int KeyCount;
        public int ExtendedKeyCount;
        public UnityEngine.InputSystem.Controls.AnyKeyControl _anyKey; // 0x190
        public UnityEngine.InputSystem.Controls.ButtonControl _shiftKey; // 0x198
        public UnityEngine.InputSystem.Controls.ButtonControl _ctrlKey; // 0x1A0
        public UnityEngine.InputSystem.Controls.ButtonControl _altKey; // 0x1A8
        public UnityEngine.InputSystem.Controls.ButtonControl _imeSelected; // 0x1B0
        public UnityEngine.InputSystem.Keyboard _current;
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Action`1<char>> m_TextInputListeners; // 0x1B8
        public string m_KeyboardLayoutName; // 0x1D0
        public UnityEngine.InputSystem.Controls.KeyControl[] m_Keys; // 0x1D8
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Action`1<UnityEngine.InputSystem.LowLevel.IMECompositionString>> m_ImeCompositionListeners; // 0x1E0
        public object InlinedArray`1; // 0x7DD0
        public object InlinedArray`1;
        public object onTextInput;
        public object field_15;
        public object field_16; // 0x5F38
        public object field_17;
        public object field_18;
        public object field_19; // 0x21F0
        public object field_20; // 0xA848
        public object field_21; // 0x5C70
        public object field_22; // 0x62B0
        public object field_23; // 0x3788
        public object field_24; // 0x3798
        public System.Action`1<char> field_25; // 0x6
        public object field_26; // 0x7DA0
        public object field_27;
        public object InlinedArray`1;
        public object field_29;
        public object field_30; // 0x85E0
        public object field_31;
        public object field_32;
        public object field_33; // 0x21F0
        public object field_34; // 0xA848
        public object field_35; // 0x5C70
        public object field_36; // 0x62B0
        public object field_37; // 0x39B8
        public object field_38; // 0x39C8
        public System.Action`1<UnityEngine.InputSystem.LowLevel.IMECompositionString> field_39; // 0x6
        public object field_40; // 0xE
        public System.Action`1<UnityEngine.InputSystem.LowLevel.IMECompositionString> onTextInput; // 0xFC90
        public object field_42; // 0x4960
        public object field_43; // 0x4960
        public object field_44; // 0x4960
        public object field_45; // 0x4960
        public object field_46; // 0x4960
        public object field_47; // 0x4960
        public object field_48; // 0x4960
        public object field_49; // 0x4960
        public object field_50; // 0x4960
        public object field_51; // 0x4960
        public object field_52; // 0x4960
        public object field_53; // 0x4960
        public object field_54; // 0x4960
        public object field_55; // 0x4960
        public object field_56; // 0x4960
        public object field_57; // 0x4960
        public object field_58; // 0x4960
        public object field_59; // 0x4960
        public object field_60; // 0x4960
        public object field_61; // 0x4960
        public object field_62; // 0x4960
        public object field_63; // 0x4960
        public object field_64; // 0x4960
        public object field_65; // 0x4960
        public object field_66; // 0x4960
        public object field_67; // 0x4960
        public object field_68; // 0x4960
        public object field_69; // 0x4960
        public object field_70; // 0x4960
        public object field_71; // 0x4960
        public object field_72; // 0x4960
        public object field_73; // 0x4960
        public object field_74; // 0x4960
        public object field_75; // 0x4960
        public object field_76; // 0x4960
        public object field_77; // 0x4960
        public object field_78; // 0x4960
        public object field_79; // 0x4960
        public object field_80; // 0x4960
        public object field_81; // 0x4960
        public object field_82; // 0x4960
        public object field_83; // 0x4960
        public object field_84; // 0x4960
        public object field_85; // 0x4960
        public object field_86; // 0x4960
        public object field_87; // 0x4960
        public object field_88; // 0x4960
        public object field_89; // 0x4960
        public object field_90; // 0x4960
        public object field_91; // 0x4960
        public object field_92; // 0x4960
        public object field_93; // 0x4960
        public object field_94; // 0x4960
        public object field_95; // 0x4960
        public object field_96; // 0x4960
        public object field_97; // 0x4960
        public object field_98; // 0x4960
        public object field_99; // 0x4960
        public object field_100; // 0x4960
        public object field_101; // 0x4960
        public object field_102; // 0x4960
        public object field_103; // 0x4960
        public object field_104; // 0x4960
        public object field_105; // 0x4960
        public object field_106; // 0x4960
        public object field_107; // 0x4960
        public object field_108; // 0x4960
        public object field_109; // 0x4960
        public object field_110; // 0x4960
        public object field_111; // 0x4960
        public object field_112; // 0x4960
        public object field_113; // 0x4960
        public object field_114; // 0x4960
        public object field_115; // 0x4960
        public object field_116; // 0x4960
        public object field_117; // 0x4960
        public object field_118; // 0x4960
        public object field_119; // 0x4960
        public object field_120; // 0x4960
        public object field_121; // 0x4960
        public object field_122; // 0x4960
        public object field_123; // 0x4960
        public object field_124; // 0x4960
        public object field_125; // 0x4960
        public object field_126; // 0x4960
        public object field_127; // 0x4960
        public object field_128; // 0x4960
        public object field_129; // 0x4960
        public object field_130; // 0x4960
        public object field_131; // 0x4960
        public object field_132; // 0x4960
        public object field_133; // 0x4960
        public object field_134; // 0x4960
        public object field_135; // 0x4960
        public object field_136; // 0x4960
        public object field_137; // 0x4960

        // ── Methods ──
        public void add_onTextInput(){} // RVA: 0x7FFE8793D270
        public void remove_onTextInput(){} // RVA: 0x7FFE8793D360
        public void add_onIMECompositionChange(){} // RVA: 0x7FFE8793D3C0
        public void remove_onIMECompositionChange(){} // RVA: 0x7FFE8793D4B0
        public void SetIMEEnabled(){} // RVA: 0x7FFE8793D510
        public void SetIMECursorPosition(){} // RVA: 0x7FFE8793D590
        public void get_keyboardLayout(){} // RVA: 0x7FFE8793D620
        public void set_keyboardLayout(){} // RVA: 0x7FFE81B31B60
        public void get_anyKey(){} // RVA: 0x7FFE81825EC0
        public void set_anyKey(){} // RVA: 0x7FFE81B2A360
        public void get_spaceKey(){} // RVA: 0x7FFE8793D670
        public void get_enterKey(){} // RVA: 0x7FFE8793D680
        public void get_tabKey(){} // RVA: 0x7FFE8793D690
        public void get_backquoteKey(){} // RVA: 0x7FFE8793D6A0
        public void get_quoteKey(){} // RVA: 0x7FFE8793D6B0
        public void get_semicolonKey(){} // RVA: 0x7FFE8793D6C0
        public void get_commaKey(){} // RVA: 0x7FFE8793D6D0
        public void get_periodKey(){} // RVA: 0x7FFE8793D6E0
        public void get_slashKey(){} // RVA: 0x7FFE8793D6F0
        public void get_backslashKey(){} // RVA: 0x7FFE8793D700
        public void get_leftBracketKey(){} // RVA: 0x7FFE8793D710
        public void get_rightBracketKey(){} // RVA: 0x7FFE8793D720
        public void get_minusKey(){} // RVA: 0x7FFE8793D730
        public void get_equalsKey(){} // RVA: 0x7FFE8793D740
        public void get_aKey(){} // RVA: 0x7FFE8793D750
        public void get_bKey(){} // RVA: 0x7FFE8793D760
        public void get_cKey(){} // RVA: 0x7FFE8793D770
        public void get_dKey(){} // RVA: 0x7FFE8793D780
        public void get_eKey(){} // RVA: 0x7FFE8793D790
        public void get_fKey(){} // RVA: 0x7FFE8793D7A0
        public void get_gKey(){} // RVA: 0x7FFE8793D7B0
        public void get_hKey(){} // RVA: 0x7FFE8793D7C0
        public void get_iKey(){} // RVA: 0x7FFE8793D7D0
        public void get_jKey(){} // RVA: 0x7FFE8793D7E0
        public void get_kKey(){} // RVA: 0x7FFE8793D7F0
        public void get_lKey(){} // RVA: 0x7FFE8793D800
        public void get_mKey(){} // RVA: 0x7FFE8793D810
        public void get_nKey(){} // RVA: 0x7FFE8793D820
        public void get_oKey(){} // RVA: 0x7FFE8793D830
        public void get_pKey(){} // RVA: 0x7FFE8793D840
        public void get_qKey(){} // RVA: 0x7FFE8793D850
        public void get_rKey(){} // RVA: 0x7FFE8793D860
        public void get_sKey(){} // RVA: 0x7FFE8793D870
        public void get_tKey(){} // RVA: 0x7FFE8793D880
        public void get_uKey(){} // RVA: 0x7FFE8793D890
        public void get_vKey(){} // RVA: 0x7FFE8793D8A0
        public void get_wKey(){} // RVA: 0x7FFE8793D8B0
        public void get_xKey(){} // RVA: 0x7FFE8793D8C0
        public void get_yKey(){} // RVA: 0x7FFE8793D8D0
        public void get_zKey(){} // RVA: 0x7FFE8793D8E0
        public void get_digit1Key(){} // RVA: 0x7FFE8793D8F0
        public void get_digit2Key(){} // RVA: 0x7FFE8793D900
        public void get_digit3Key(){} // RVA: 0x7FFE8793D910
        public void get_digit4Key(){} // RVA: 0x7FFE8793D920
        public void get_digit5Key(){} // RVA: 0x7FFE8793D930
        public void get_digit6Key(){} // RVA: 0x7FFE8793D940
        public void get_digit7Key(){} // RVA: 0x7FFE8793D950
        public void get_digit8Key(){} // RVA: 0x7FFE8793D960
        public void get_digit9Key(){} // RVA: 0x7FFE8793D970
        public void get_digit0Key(){} // RVA: 0x7FFE8793D980
        public void get_leftShiftKey(){} // RVA: 0x7FFE8793D990
        public void get_rightShiftKey(){} // RVA: 0x7FFE8793D9A0
        public void get_leftAltKey(){} // RVA: 0x7FFE8793D9B0
        public void get_rightAltKey(){} // RVA: 0x7FFE8793D9C0
        public void get_leftCtrlKey(){} // RVA: 0x7FFE8793D9D0
        public void get_rightCtrlKey(){} // RVA: 0x7FFE8793D9E0
        public void get_leftMetaKey(){} // RVA: 0x7FFE8793D9F0
        public void get_rightMetaKey(){} // RVA: 0x7FFE8793DA00
        public void get_leftWindowsKey(){} // RVA: 0x7FFE8793D9F0
        public void get_rightWindowsKey(){} // RVA: 0x7FFE8793DA00
        public void get_leftAppleKey(){} // RVA: 0x7FFE8793D9F0
        public void get_rightAppleKey(){} // RVA: 0x7FFE8793DA00
        public void get_leftCommandKey(){} // RVA: 0x7FFE8793D9F0
        public void get_rightCommandKey(){} // RVA: 0x7FFE8793DA00
        public void get_contextMenuKey(){} // RVA: 0x7FFE8793DA10
        public void get_escapeKey(){} // RVA: 0x7FFE8793DA20
        public void get_leftArrowKey(){} // RVA: 0x7FFE8793DA30
        public void get_rightArrowKey(){} // RVA: 0x7FFE8793DA40
        public void get_upArrowKey(){} // RVA: 0x7FFE8793DA50
        public void get_downArrowKey(){} // RVA: 0x7FFE8793DA60
        public void get_backspaceKey(){} // RVA: 0x7FFE8793DA70
        public void get_pageDownKey(){} // RVA: 0x7FFE8793DA80
        public void get_pageUpKey(){} // RVA: 0x7FFE8793DA90
        public void get_homeKey(){} // RVA: 0x7FFE8793DAA0
        public void get_endKey(){} // RVA: 0x7FFE8793DAB0
        public void get_insertKey(){} // RVA: 0x7FFE8793DAC0
        public void get_deleteKey(){} // RVA: 0x7FFE8793DAD0
        public void get_capsLockKey(){} // RVA: 0x7FFE8793DAE0
        public void get_scrollLockKey(){} // RVA: 0x7FFE8793DAF0
        public void get_numLockKey(){} // RVA: 0x7FFE8793DB00
        public void get_printScreenKey(){} // RVA: 0x7FFE8793DB10
        public void get_pauseKey(){} // RVA: 0x7FFE8793DB20
        public void get_numpadEnterKey(){} // RVA: 0x7FFE8793DB30
        public void get_numpadDivideKey(){} // RVA: 0x7FFE8793DB40
        public void get_numpadMultiplyKey(){} // RVA: 0x7FFE8793DB50
        public void get_numpadMinusKey(){} // RVA: 0x7FFE8793DB60
        public void get_numpadPlusKey(){} // RVA: 0x7FFE8793DB70
        public void get_numpadPeriodKey(){} // RVA: 0x7FFE8793DB80
        public void get_numpadEqualsKey(){} // RVA: 0x7FFE8793DB90
        public void get_numpad0Key(){} // RVA: 0x7FFE8793DBA0
        public void get_numpad1Key(){} // RVA: 0x7FFE8793DBB0
        public void get_numpad2Key(){} // RVA: 0x7FFE8793DBC0
        public void get_numpad3Key(){} // RVA: 0x7FFE8793DBD0
        public void get_numpad4Key(){} // RVA: 0x7FFE8793DBE0
        public void get_numpad5Key(){} // RVA: 0x7FFE8793DBF0
        public void get_numpad6Key(){} // RVA: 0x7FFE8793DC00
        public void get_numpad7Key(){} // RVA: 0x7FFE8793DC10
        public void get_numpad8Key(){} // RVA: 0x7FFE8793DC20
        public void get_numpad9Key(){} // RVA: 0x7FFE8793DC30
        public void get_f1Key(){} // RVA: 0x7FFE8793DC40
        public void get_f2Key(){} // RVA: 0x7FFE8793DC50
        public void get_f3Key(){} // RVA: 0x7FFE8793DC60
        public void get_f4Key(){} // RVA: 0x7FFE8793DC70
        public void get_f5Key(){} // RVA: 0x7FFE8793DC80
        public void get_f6Key(){} // RVA: 0x7FFE8793DC90
        public void get_f7Key(){} // RVA: 0x7FFE8793DCA0
        public void get_f8Key(){} // RVA: 0x7FFE8793DCB0
        public void get_f9Key(){} // RVA: 0x7FFE8793DCC0
        public void get_f10Key(){} // RVA: 0x7FFE8793DCD0
        public void get_f11Key(){} // RVA: 0x7FFE8793DCE0
        public void get_f12Key(){} // RVA: 0x7FFE8793DCF0
        public void get_oem1Key(){} // RVA: 0x7FFE8793DD00
        public void get_oem2Key(){} // RVA: 0x7FFE8793DD10
        public void get_oem3Key(){} // RVA: 0x7FFE8793DD20
        public void get_oem4Key(){} // RVA: 0x7FFE8793DD30
        public void get_oem5Key(){} // RVA: 0x7FFE8793DD40
        public void get_f13Key(){} // RVA: 0x7FFE8793DD50
        public void get_f14Key(){} // RVA: 0x7FFE8793DD60
        public void get_f15Key(){} // RVA: 0x7FFE8793DD70
        public void get_f16Key(){} // RVA: 0x7FFE8793DD80
        public void get_f17Key(){} // RVA: 0x7FFE8793DD90
        public void get_f18Key(){} // RVA: 0x7FFE8793DDA0
        public void get_f19Key(){} // RVA: 0x7FFE8793DDB0
        public void get_f20Key(){} // RVA: 0x7FFE8793DDC0
        public void get_f21Key(){} // RVA: 0x7FFE8793DDD0
        public void get_f22Key(){} // RVA: 0x7FFE8793DDE0
        public void get_f23Key(){} // RVA: 0x7FFE8793DDF0
        public void get_f24Key(){} // RVA: 0x7FFE8793DE00
        public void get_shiftKey(){} // RVA: 0x7FFE8181EA60
        public void set_shiftKey(){} // RVA: 0x7FFE81B33630
        public void get_ctrlKey(){} // RVA: 0x7FFE81B32390
        public void set_ctrlKey(){} // RVA: 0x7FFE81B21CA0
        public void get_altKey(){} // RVA: 0x7FFE8182AF50
        public void set_altKey(){} // RVA: 0x7FFE81B08F90
        public void get_imeSelected(){} // RVA: 0x7FFE81B23A60
        public void set_imeSelected(){} // RVA: 0x7FFE81B2ACE0
        public void get_Item(){} // RVA: 0x7FFE8793DE10
        public void get_allKeys(){} // RVA: 0x7FFE8793DEB0
        public void get_current(){} // RVA: 0x7FFE8793DF80
        public void set_current(){} // RVA: 0x7FFE8793DFC0
        public void MakeCurrent(){} // RVA: 0x7FFE8793E060
        public void OnRemoved(){} // RVA: 0x7FFE8793E070
        public void FinishSetup(){} // RVA: 0x7FFE8793E0C0
        public void RefreshConfiguration(){} // RVA: 0x7FFE8793F6F0
        public void OnTextInput(){} // RVA: 0x7FFE8793F8C0
        public void FindKeyOnCurrentKeyboardLayout(){} // RVA: 0x7FFE8793F950
        public void OnIMECompositionChanged(){} // RVA: 0x7FFE8793FB60
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7FFE8793FC70
        public void get_keys(){} // RVA: 0x7FFE81B23D60
        public void set_keys(){} // RVA: 0x7FFE81B11520
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class LightSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl _lightLevel; // 0x190
        public UnityEngine.InputSystem.LightSensor _current;

        // ── Methods ──
        public void get_lightLevel(){} // RVA: 0x7FFE81825EC0
        public void set_lightLevel(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AF500
        public void set_current(){} // RVA: 0x7FFE879AF540
        public void MakeCurrent(){} // RVA: 0x7FFE879AF5E0
        public void OnRemoved(){} // RVA: 0x7FFE879AF5F0
        public void FinishSetup(){} // RVA: 0x7FFE879AF640
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class LinearAccelerationSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _acceleration; // 0x190
        public UnityEngine.InputSystem.LinearAccelerationSensor _current;

        // ── Methods ──
        public void get_acceleration(){} // RVA: 0x7FFE81825EC0
        public void set_acceleration(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AF120
        public void set_current(){} // RVA: 0x7FFE879AF160
        public void MakeCurrent(){} // RVA: 0x7FFE879AF200
        public void OnRemoved(){} // RVA: 0x7FFE879AF210
        public void FinishSetup(){} // RVA: 0x7FFE879AF260
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class MagneticFieldSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _magneticField; // 0x190
        public UnityEngine.InputSystem.MagneticFieldSensor _current;

        // ── Methods ──
        public void get_magneticField(){} // RVA: 0x7FFE81825EC0
        public void set_magneticField(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AF310
        public void set_current(){} // RVA: 0x7FFE879AF350
        public void MakeCurrent(){} // RVA: 0x7FFE879AF3F0
        public void OnRemoved(){} // RVA: 0x7FFE879AF400
        public void FinishSetup(){} // RVA: 0x7FFE879AF450
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class Mouse : Pointer
    {
        public UnityEngine.InputSystem.Controls.DeltaControl _scroll; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl _leftButton; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl _middleButton; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl _rightButton; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl _backButton; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl _forwardButton; // 0x1E8
        public UnityEngine.InputSystem.Controls.IntegerControl _clickCount; // 0x1F0
        public UnityEngine.InputSystem.Mouse _current;

        // ── Methods ──
        public void get_scroll(){} // RVA: 0x7FFE817EFE00
        public void set_scroll(){} // RVA: 0x7FFE81B0C930
        public void get_leftButton(){} // RVA: 0x7FFE81B16E90
        public void set_leftButton(){} // RVA: 0x7FFE81B290E0
        public void get_middleButton(){} // RVA: 0x7FFE81B32320
        public void set_middleButton(){} // RVA: 0x7FFE81B31B60
        public void get_rightButton(){} // RVA: 0x7FFE81B23D60
        public void set_rightButton(){} // RVA: 0x7FFE81B11520
        public void get_backButton(){} // RVA: 0x7FFE816611A0
        public void set_backButton(){} // RVA: 0x7FFE81B31CF0
        public void get_forwardButton(){} // RVA: 0x7FFE81B27D50
        public void set_forwardButton(){} // RVA: 0x7FFE81B34FD0
        public void get_clickCount(){} // RVA: 0x7FFE81B21230
        public void set_clickCount(){} // RVA: 0x7FFE81B374B0
        public void get_current(){} // RVA: 0x7FFE8793FCB0
        public void set_current(){} // RVA: 0x7FFE8793FCF0
        public void MakeCurrent(){} // RVA: 0x7FFE8793FD90
        public void OnAdded(){} // RVA: 0x7FFE8793FDB0
        public void OnRemoved(){} // RVA: 0x7FFE8793FE60
        public void WarpCursorPosition(){} // RVA: 0x7FFE8793FEF0
        public void FinishSetup(){} // RVA: 0x7FFE8793FF80
        public void OnNextUpdate(){} // RVA: 0x7FFE879403F0
        public void OnStateEvent(){} // RVA: 0x7FFE879404C0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFE879403F0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFE87940570
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class Pen : Pointer
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _tip; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl _eraser; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl _firstBarrelButton; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl _secondBarrelButton; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl _thirdBarrelButton; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl _fourthBarrelButton; // 0x1E8
        public UnityEngine.InputSystem.Controls.ButtonControl _inRange; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector2Control _tilt; // 0x1F8
        public UnityEngine.InputSystem.Controls.AxisControl _twist; // 0x200
        public UnityEngine.InputSystem.Pen _current;
        public object field_10; // 0x273

        // ── Methods ──
        public void get_tip(){} // RVA: 0x7FFE817EFE00
        public void set_tip(){} // RVA: 0x7FFE81B0C930
        public void get_eraser(){} // RVA: 0x7FFE81B16E90
        public void set_eraser(){} // RVA: 0x7FFE81B290E0
        public void get_firstBarrelButton(){} // RVA: 0x7FFE81B32320
        public void set_firstBarrelButton(){} // RVA: 0x7FFE81B31B60
        public void get_secondBarrelButton(){} // RVA: 0x7FFE81B23D60
        public void set_secondBarrelButton(){} // RVA: 0x7FFE81B11520
        public void get_thirdBarrelButton(){} // RVA: 0x7FFE816611A0
        public void set_thirdBarrelButton(){} // RVA: 0x7FFE81B31CF0
        public void get_fourthBarrelButton(){} // RVA: 0x7FFE81B27D50
        public void set_fourthBarrelButton(){} // RVA: 0x7FFE81B34FD0
        public void get_inRange(){} // RVA: 0x7FFE81B21230
        public void set_inRange(){} // RVA: 0x7FFE81B374B0
        public void get_tilt(){} // RVA: 0x7FFE81B20B40
        public void set_tilt(){} // RVA: 0x7FFE81B2E610
        public void get_twist(){} // RVA: 0x7FFE81B14500
        public void set_twist(){} // RVA: 0x7FFE81B317A0
        public void get_current(){} // RVA: 0x7FFE87940580
        public void set_current(){} // RVA: 0x7FFE879405C0
        public void get_Item(){} // RVA: 0x7FFE87940660
        public void MakeCurrent(){} // RVA: 0x7FFE879407A0
        public void OnRemoved(){} // RVA: 0x7FFE879407C0
        public void FinishSetup(){} // RVA: 0x7FFE87940850
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class PlayerInput : MonoBehaviour
    {
        public string DeviceLostMessage;
        public string DeviceRegainedMessage;
        public string ControlsChangedMessage;
        public int m_AllMapsHashCode; // 0x20
        public UnityEngine.InputSystem.InputActionAsset m_Actions; // 0x28
        public 0x665426C4 m_NotificationBehavior; // 0x30
        public UnityEngine.InputSystem.UI.InputSystemUIInputModule m_UIInputModule; // 0x38
        public DeviceLostEvent m_DeviceLostEvent; // 0x40
        public DeviceRegainedEvent m_DeviceRegainedEvent; // 0x48
        public ControlsChangedEvent m_ControlsChangedEvent; // 0x50
        public ActionEvent[] m_ActionEvents; // 0x58
        public bool m_NeverAutoSwitchControlSchemes; // 0x60
        public string m_DefaultControlScheme; // 0x68
        public string m_DefaultActionMap; // 0x70
        public int m_SplitScreenIndex; // 0x78
        public UnityEngine.Camera m_Camera; // 0x80
        public UnityEngine.InputSystem.InputValue m_InputValueObject; // 0x88
        public UnityEngine.InputSystem.InputActionMap m_CurrentActionMap; // 0x90
        public int m_PlayerIndex; // 0x98
        public bool m_InputActive; // 0x9C
        public bool m_Enabled; // 0x9D
        public bool m_ActionsInitialized; // 0x9E

        // ── Methods ──
        public void get_inputIsActive(){} // RVA: 0x7FFE86EB9990
        public void get_active(){} // RVA: 0x7FFE86EB9990
        public void get_playerIndex(){} // RVA: 0x7FFE82B06A40
        public void get_splitScreenIndex(){} // RVA: 0x7FFE8286C0A0
        public void get_actions(){} // RVA: 0x7FFE879CE690
        public void set_actions(){} // RVA: 0x7FFE879CE760
        public void get_currentControlScheme(){} // RVA: 0x7FFE879CEAB0
        public void get_defaultControlScheme(){} // RVA: 0x7FFE81176D50
        public void set_defaultControlScheme(){} // RVA: 0x7FFE81176D60
        public void get_neverAutoSwitchControlSchemes(){} // RVA: 0x7FFE81124020
        public void set_neverAutoSwitchControlSchemes(){} // RVA: 0x7FFE879CEB80
        public void get_currentActionMap(){} // RVA: 0x7FFE8154EB60
        public void set_currentActionMap(){} // RVA: 0x7FFE879CEBC0
        public void get_defaultActionMap(){} // RVA: 0x7FFE811C3590
        public void set_defaultActionMap(){} // RVA: 0x7FFE811C35A0
        public void get_notificationBehavior(){} // RVA: 0x7FFE81156CD0
        public void set_notificationBehavior(){} // RVA: 0x7FFE879CEE60
        public void get_actionEvents(){} // RVA: 0x7FFE879CEEB0
        public void set_actionEvents(){} // RVA: 0x7FFE879CEF80
        public void get_deviceLostEvent(){} // RVA: 0x7FFE879CF040
        public void get_deviceRegainedEvent(){} // RVA: 0x7FFE879CF110
        public void get_controlsChangedEvent(){} // RVA: 0x7FFE879CF1E0
        public void add_onActionTriggered(){} // RVA: 0x7FFE879CF2B0
        public void remove_onActionTriggered(){} // RVA: 0x7FFE879CF350
        public void add_onDeviceLost(){} // RVA: 0x7FFE879CF3F0
        public void remove_onDeviceLost(){} // RVA: 0x7FFE879CF490
        public void add_onDeviceRegained(){} // RVA: 0x7FFE879CF530
        public void remove_onDeviceRegained(){} // RVA: 0x7FFE879CF5D0
        public void add_onControlsChanged(){} // RVA: 0x7FFE879CF670
        public void remove_onControlsChanged(){} // RVA: 0x7FFE879CF710
        public void get_camera(){} // RVA: 0x7FFE81280C30
        public void set_camera(){} // RVA: 0x7FFE81282380
        public void get_uiInputModule(){} // RVA: 0x7FFE8143BA80
        public void set_uiInputModule(){} // RVA: 0x7FFE879CF7B0
        public void get_user(){} // RVA: 0x7FFE81A338E0
        public void get_devices(){} // RVA: 0x7FFE879CFC10
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7FFE879CFCC0
        public void get_all(){} // RVA: 0x7FFE879CFDC0
        public void get_isSinglePlayer(){} // RVA: 0x7FFE879CFEA0
        public void GetDevice(){} // RVA: 0x7FFE810A1420
        public void ActivateInput(){} // RVA: 0x7FFE879D0030
        public void UpdateDelegates(){} // RVA: 0x7FFE879D0160
        public void DeactivateInput(){} // RVA: 0x7FFE879D0430
        public void PassivateInput(){} // RVA: 0x7FFE879D0430
        public void SwitchCurrentControlScheme(){} // RVA: 0x7FFE879D06C0 | overloaded x2
        public void SwitchCurrentActionMap(){} // RVA: 0x7FFE879D0810
        public void GetPlayerByIndex(){} // RVA: 0x7FFE879D09F0
        public void FindFirstPairedToDevice(){} // RVA: 0x7FFE879D0AF0
        public void Instantiate(){} // RVA: 0x7FFE879D0F90 | overloaded x2
        public void DoInstantiate(){} // RVA: 0x7FFE879D1230
        public void InitializeActions(){} // RVA: 0x7FFE879D1790
        public void CopyActionAssetAndApplyBindingOverrides(){} // RVA: 0x7FFE879D1D40
        public void UninitializeActions(){} // RVA: 0x7FFE879D20C0
        public void InstallOnActionTriggeredHook(){} // RVA: 0x7FFE879D2380
        public void UninstallOnActionTriggeredHook(){} // RVA: 0x7FFE879D2650
        public void OnActionTriggered(){} // RVA: 0x7FFE879D2870
        public void CacheMessageNames(){} // RVA: 0x7FFE879D2B70
        public void ClearCaches(){} // RVA: 0x7FFE879D30A0
        public void AssignUserAndDevices(){} // RVA: 0x7FFE879D3100
        public void HaveBindingForDevice(){} // RVA: 0x7FFE879D3E80
        public void UnassignUserAndDevices(){} // RVA: 0x7FFE879D4010
        public void TryToActivateControlScheme(){} // RVA: 0x7FFE879D41B0
        public void AssignPlayerIndex(){} // RVA: 0x7FFE879D45E0
        public void Awake(){} // RVA: 0x7FFE879D4880
        public void OnEnable(){} // RVA: 0x7FFE879D4960
        public void StartListeningForUnpairedDeviceActivity(){} // RVA: 0x7FFE879D5120
        public void StopListeningForUnpairedDeviceActivity(){} // RVA: 0x7FFE879D5400
        public void StartListeningForDeviceChanges(){} // RVA: 0x7FFE879D5590
        public void StopListeningForDeviceChanges(){} // RVA: 0x7FFE879D56B0
        public void OnDisable(){} // RVA: 0x7FFE879D5720
        public void DebugLogAction(){} // RVA: 0x7FFE879D5C70
        public void HandleDeviceLost(){} // RVA: 0x7FFE879D5CD0
        public void HandleDeviceRegained(){} // RVA: 0x7FFE879D5DF0
        public void HandleControlsChanged(){} // RVA: 0x7FFE879D5F10
        public void OnUserChange(){} // RVA: 0x7FFE879D6030
        public void OnPreFilterUnpairedDeviceUsed(){} // RVA: 0x7FFE879D6220
        public void OnUnpairedDeviceUsed(){} // RVA: 0x7FFE879D65C0
        public void OnDeviceChange(){} // RVA: 0x7FFE879D6ED0
        public void SwitchControlSchemeInternal(){} // RVA: 0x7FFE879D70A0
        public void .ctor(){} // RVA: 0x7FFE879D7640
        public void .cctor(){} // RVA: 0x7FFE879D76A0
    }

    public class PlayerInputManager : MonoBehaviour
    {
        public string PlayerJoinedMessage;
        public string PlayerLeftMessage;
        public UnityEngine.InputSystem.PlayerInputManager _instance;
        public 0x665426C4 m_NotificationBehavior; // 0x20
        public int m_MaxPlayerCount; // 0x24
        public bool m_AllowJoining; // 0x28
        public 0x6654266C m_JoinBehavior; // 0x2C
        public PlayerJoinedEvent m_PlayerJoinedEvent; // 0x30
        public PlayerLeftEvent m_PlayerLeftEvent; // 0x38
        public UnityEngine.InputSystem.InputActionProperty m_JoinAction; // 0x40
        public UnityEngine.GameObject m_PlayerPrefab; // 0x58
        public bool m_SplitScreen; // 0x60
        public bool m_MaintainAspectRatioInSplitScreen; // 0x61
        public int m_FixedNumberOfSplitScreens; // 0x64
        public UnityEngine.Rect m_SplitScreenRect; // 0x68

        // ── Methods ──
        public void get_splitScreen(){} // RVA: 0x7FFE81124020
        public void set_splitScreen(){} // RVA: 0x7FFE879D7D20
        public void get_maintainAspectRatioInSplitScreen(){} // RVA: 0x7FFE81EC3970
        public void get_fixedNumberOfSplitScreens(){} // RVA: 0x7FFE8139DA60
        public void get_splitScreenArea(){} // RVA: 0x7FFE8432FD10
        public void get_playerCount(){} // RVA: 0x7FFE879D8060
        public void get_maxPlayerCount(){} // RVA: 0x7FFE81A56130
        public void get_joiningEnabled(){} // RVA: 0x7FFE815F1380
        public void get_joinBehavior(){} // RVA: 0x7FFE81F84A50
        public void set_joinBehavior(){} // RVA: 0x7FFE879D80C0
        public void get_joinAction(){} // RVA: 0x7FFE81104E10
        public void set_joinAction(){} // RVA: 0x7FFE879D8110
        public void get_notificationBehavior(){} // RVA: 0x7FFE8151D690
        public void set_notificationBehavior(){} // RVA: 0x7FFE8170B670
        public void get_playerJoinedEvent(){} // RVA: 0x7FFE879D8200
        public void get_playerLeftEvent(){} // RVA: 0x7FFE879D82D0
        public void add_onPlayerJoined(){} // RVA: 0x7FFE879D83A0
        public void remove_onPlayerJoined(){} // RVA: 0x7FFE879D8440
        public void add_onPlayerLeft(){} // RVA: 0x7FFE879D84E0
        public void remove_onPlayerLeft(){} // RVA: 0x7FFE879D8580
        public void get_playerPrefab(){} // RVA: 0x7FFE811C3500
        public void set_playerPrefab(){} // RVA: 0x7FFE811C3510
        public void get_instance(){} // RVA: 0x7FFE879D8620
        public void set_instance(){} // RVA: 0x7FFE879D8660
        public void EnableJoining(){} // RVA: 0x7FFE879D8700
        public void DisableJoining(){} // RVA: 0x7FFE879D8920
        public void JoinPlayerFromUI(){} // RVA: 0x7FFE879D8A20
        public void JoinPlayerFromAction(){} // RVA: 0x7FFE879D8A80
        public void JoinPlayerFromActionIfNotAlreadyJoined(){} // RVA: 0x7FFE879D8AF0
        public void JoinPlayer(){} // RVA: 0x7FFE879D8D10 | overloaded x2
        public void get_messages(){} // RVA: 0x7FFE879D8DD0
        public void CheckIfPlayerCanJoin(){} // RVA: 0x7FFE879D8E70
        public void OnUnpairedDeviceUsed(){} // RVA: 0x7FFE879D91F0
        public void OnEnable(){} // RVA: 0x7FFE879D92A0
        public void OnDisable(){} // RVA: 0x7FFE879D9850
        public void UpdateSplitScreen(){} // RVA: 0x7FFE879D99B0
        public void IsDeviceUsableWithPlayerActions(){} // RVA: 0x7FFE879DA0F0
        public void ValidateInputActionAsset(){} // RVA: 0x7FFE810FB310
        public void NotifyPlayerJoined(){} // RVA: 0x7FFE879DA690
        public void NotifyPlayerLeft(){} // RVA: 0x7FFE879DA7D0
        public void .ctor(){} // RVA: 0x7FFE879DA910
    }

    public class Pointer : InputDevice
    {
        public UnityEngine.InputSystem.Controls.Vector2Control _position; // 0x190
        public UnityEngine.InputSystem.Controls.DeltaControl _delta; // 0x198
        public UnityEngine.InputSystem.Controls.Vector2Control _radius; // 0x1A0
        public UnityEngine.InputSystem.Controls.AxisControl _pressure; // 0x1A8
        public UnityEngine.InputSystem.Controls.ButtonControl _press; // 0x1B0
        public UnityEngine.InputSystem.Controls.IntegerControl _displayIndex; // 0x1B8
        public UnityEngine.InputSystem.Pointer _current;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFE81825EC0
        public void set_position(){} // RVA: 0x7FFE81B2A360
        public void get_delta(){} // RVA: 0x7FFE8181EA60
        public void set_delta(){} // RVA: 0x7FFE81B33630
        public void get_radius(){} // RVA: 0x7FFE81B32390
        public void set_radius(){} // RVA: 0x7FFE81B21CA0
        public void get_pressure(){} // RVA: 0x7FFE8182AF50
        public void set_pressure(){} // RVA: 0x7FFE81B08F90
        public void get_press(){} // RVA: 0x7FFE81B23A60
        public void set_press(){} // RVA: 0x7FFE81B2ACE0
        public void get_displayIndex(){} // RVA: 0x7FFE81B164E0
        public void set_displayIndex(){} // RVA: 0x7FFE81B38D70
        public void get_current(){} // RVA: 0x7FFE87940DE0
        public void set_current(){} // RVA: 0x7FFE87940E20
        public void MakeCurrent(){} // RVA: 0x7FFE87940EC0
        public void OnRemoved(){} // RVA: 0x7FFE87940ED0
        public void FinishSetup(){} // RVA: 0x7FFE87940F20
        public void OnNextUpdate(){} // RVA: 0x7FFE879412B0
        public void OnStateEvent(){} // RVA: 0x7FFE87941370
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFE87941420
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFE87941430
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class PressureSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl _atmosphericPressure; // 0x190
        public UnityEngine.InputSystem.PressureSensor _current;

        // ── Methods ──
        public void get_atmosphericPressure(){} // RVA: 0x7FFE81825EC0
        public void set_atmosphericPressure(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AF6F0
        public void set_current(){} // RVA: 0x7FFE879AF730
        public void MakeCurrent(){} // RVA: 0x7FFE879AF7D0
        public void OnRemoved(){} // RVA: 0x7FFE879AF7E0
        public void FinishSetup(){} // RVA: 0x7FFE879AF830
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class ProximitySensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl _distance; // 0x190
        public UnityEngine.InputSystem.ProximitySensor _current;

        // ── Methods ──
        public void get_distance(){} // RVA: 0x7FFE81825EC0
        public void set_distance(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AF8E0
        public void set_current(){} // RVA: 0x7FFE879AF920
        public void MakeCurrent(){} // RVA: 0x7FFE879AF9C0
        public void OnRemoved(){} // RVA: 0x7FFE879AF9D0
        public void FinishSetup(){} // RVA: 0x7FFE879AFA20
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class RemoteInputPlayerConnection : ScriptableObject
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFE879AD160
        public void Subscribe(){} // RVA: 0x7FFE879AD680
        public void OnConnected(){} // RVA: 0x7FFE879AD920
        public void OnDisconnected(){} // RVA: 0x7FFE879AD9D0
        public void OnNewDevice(){} // RVA: 0x7FFE879ADB70
        public void OnNewLayout(){} // RVA: 0x7FFE879ADB80
        public void OnNewEvents(){} // RVA: 0x7FFE879ADB90
        public void OnRemoveDevice(){} // RVA: 0x7FFE879ADBA0
        public void OnChangeUsages(){} // RVA: 0x7FFE879ADBB0
        public void OnStartSending(){} // RVA: 0x7FFE879ADBC0
        public void OnStopSending(){} // RVA: 0x7FFE879ADBD0
        public void SendToSubscribers(){} // RVA: 0x7FFE879ADBE0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x7FFE879ADDE0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0x7FFE810FB310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE81345B60
        public void .cctor(){} // RVA: 0x7FFE879ADFA0
    }

    public class Sensor : InputDevice
    {
        // ── Methods ──
        public void get_samplingFrequency(){} // RVA: 0x7FFE879AE800
        public void set_samplingFrequency(){} // RVA: 0x7FFE879AE8E0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class StepCounter : Sensor
    {
        public UnityEngine.InputSystem.Controls.IntegerControl _stepCounter; // 0x190
        public UnityEngine.InputSystem.StepCounter _current;

        // ── Methods ──
        public void get_stepCounter(){} // RVA: 0x7FFE81825EC0
        public void set_stepCounter(){} // RVA: 0x7FFE81B2A360
        public void get_current(){} // RVA: 0x7FFE879AFEB0
        public void set_current(){} // RVA: 0x7FFE879AFEF0
        public void MakeCurrent(){} // RVA: 0x7FFE879AFF90
        public void OnRemoved(){} // RVA: 0x7FFE879AFFA0
        public void FinishSetup(){} // RVA: 0x7FFE879AFFF0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class Touchscreen : Pointer
    {
        public UnityEngine.InputSystem.Controls.TouchControl _primaryTouch; // 0x1C0
        public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Controls.TouchControl> _touches; // 0x1C8
        public Unity.Profiling.ProfilerMarker k_TouchscreenUpdateMarker;
        public Unity.Profiling.ProfilerMarker k_TouchAllocateMarker; // 0x8

        // ── Methods ──
        public void get_primaryTouch(){} // RVA: 0x7FFE817EFE00
        public void set_primaryTouch(){} // RVA: 0x7FFE81B0C930
        public void get_touches(){} // RVA: 0x7FFE879B0290
        public void set_touches(){} // RVA: 0x7FFE879B02A0
        public void get_touchControlArray(){} // RVA: 0x7FFE81B16E90
        public void set_touchControlArray(){} // RVA: 0x7FFE879B0300
        public void get_current(){} // RVA: 0x7FFE879B0420
        public void set_current(){} // RVA: 0x7FFE879B0480
        public void MakeCurrent(){} // RVA: 0x7FFE879B0540
        public void OnRemoved(){} // RVA: 0x7FFE879B05A0
        public void FinishSetup(){} // RVA: 0x7FFE879B0690
        public void OnNextUpdate(){} // RVA: 0x7FFE879B0D20
        public void OnStateEvent(){} // RVA: 0x7FFE879B11D0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFE879B1A20
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFE879B1A30
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x7FFE879B1A40
        public void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset(){} // RVA: 0x7FFE879B1DF0
        public void MergeForward(){} // RVA: 0x7FFE879B2300
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7FFE879B2390
        public void TriggerTap(){} // RVA: 0x7FFE879B2470
        public void .ctor(){} // RVA: 0x7FFE878BEB80
        public void .cctor(){} // RVA: 0x7FFE879B2510
    }

    public class TrackedDevice : InputDevice
    {
        public UnityEngine.InputSystem.Controls.IntegerControl _trackingState; // 0x190
        public UnityEngine.InputSystem.Controls.ButtonControl _isTracked; // 0x198
        public UnityEngine.InputSystem.Controls.Vector3Control _devicePosition; // 0x1A0
        public UnityEngine.InputSystem.Controls.QuaternionControl _deviceRotation; // 0x1A8

        // ── Methods ──
        public void get_trackingState(){} // RVA: 0x7FFE81825EC0
        public void set_trackingState(){} // RVA: 0x7FFE81B2A360
        public void get_isTracked(){} // RVA: 0x7FFE8181EA60
        public void set_isTracked(){} // RVA: 0x7FFE81B33630
        public void get_devicePosition(){} // RVA: 0x7FFE81B32390
        public void set_devicePosition(){} // RVA: 0x7FFE81B21CA0
        public void get_deviceRotation(){} // RVA: 0x7FFE8182AF50
        public void set_deviceRotation(){} // RVA: 0x7FFE81B08F90
        public void FinishSetup(){} // RVA: 0x7FFE879B2630
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

}