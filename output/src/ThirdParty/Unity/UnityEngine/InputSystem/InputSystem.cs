// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 67
// Methods: 2217

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class Accelerometer : Sensor
    {
        public UnityEngine.InputSystem.Controls.Vector3Control acceleration; // 0x190
        public UnityEngine.InputSystem.Accelerometer current;

        // ── Methods ──
        public void get_acceleration(){} // RVA: 0x7FFAC3540F60
        public void set_acceleration(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC9606220
        public void set_current(){} // RVA: 0x7FFAC9606260
        public void MakeCurrent(){} // RVA: 0x7FFAC9606300
        public void OnRemoved(){} // RVA: 0x7FFAC9606310
        public void FinishSetup(){} // RVA: 0x7FFAC9606360
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class AmbientTemperatureSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl ambientTemperature; // 0x190
        public UnityEngine.InputSystem.AmbientTemperatureSensor current;

        // ── Methods ──
        public void get_ambientTemperature(){} // RVA: 0x7FFAC3540F60
        public void set_ambientTemperature(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC9607580
        public void set_current(){} // RVA: 0x7FFAC96075C0
        public void MakeCurrent(){} // RVA: 0x7FFAC9607660
        public void OnRemoved(){} // RVA: 0x7FFAC9607670
        public void FinishSetup(){} // RVA: 0x7FFAC96076C0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class AttitudeSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.QuaternionControl attitude; // 0x190
        public UnityEngine.InputSystem.AttitudeSensor current;

        // ── Methods ──
        public void get_attitude(){} // RVA: 0x7FFAC3540F60
        public void set_attitude(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC96067F0
        public void set_current(){} // RVA: 0x7FFAC9606830
        public void MakeCurrent(){} // RVA: 0x7FFAC96068D0
        public void OnRemoved(){} // RVA: 0x7FFAC96068E0
        public void FinishSetup(){} // RVA: 0x7FFAC9606930
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class CommonUsages : Object
    {
        public UnityEngine.InputSystem.Utilities.InternedString Primary2DMotion;
        public UnityEngine.InputSystem.Utilities.InternedString Secondary2DMotion; // 0x10
        public UnityEngine.InputSystem.Utilities.InternedString PrimaryAction; // 0x20
        public UnityEngine.InputSystem.Utilities.InternedString SecondaryAction; // 0x30
        public UnityEngine.InputSystem.Utilities.InternedString PrimaryTrigger; // 0x40
        public UnityEngine.InputSystem.Utilities.InternedString SecondaryTrigger; // 0x50
        public UnityEngine.InputSystem.Utilities.InternedString Modifier; // 0x60
        public UnityEngine.InputSystem.Utilities.InternedString Position; // 0x70
        public UnityEngine.InputSystem.Utilities.InternedString Orientation; // 0x80
        public UnityEngine.InputSystem.Utilities.InternedString Hatswitch; // 0x90
        public UnityEngine.InputSystem.Utilities.InternedString Back; // 0xA0
        public UnityEngine.InputSystem.Utilities.InternedString Forward; // 0xB0
        public UnityEngine.InputSystem.Utilities.InternedString Menu; // 0xC0
        public UnityEngine.InputSystem.Utilities.InternedString Submit; // 0xD0
        public UnityEngine.InputSystem.Utilities.InternedString Cancel; // 0xE0
        public UnityEngine.InputSystem.Utilities.InternedString Horizontal; // 0xF0
        public UnityEngine.InputSystem.Utilities.InternedString Vertical; // 0x100
        public UnityEngine.InputSystem.Utilities.InternedString Twist; // 0x110
        public UnityEngine.InputSystem.Utilities.InternedString Pressure; // 0x120
        public UnityEngine.InputSystem.Utilities.InternedString ScrollHorizontal; // 0x130
        public UnityEngine.InputSystem.Utilities.InternedString ScrollVertical; // 0x140
        public UnityEngine.InputSystem.Utilities.InternedString Point; // 0x150
        public UnityEngine.InputSystem.Utilities.InternedString LowFreqMotor; // 0x160
        public UnityEngine.InputSystem.Utilities.InternedString HighFreqMotor; // 0x170
        public UnityEngine.InputSystem.Utilities.InternedString LeftHand; // 0x180
        public UnityEngine.InputSystem.Utilities.InternedString RightHand; // 0x190
        public UnityEngine.InputSystem.Utilities.InternedString BatteryStrength; // 0x1A0

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9582A60
    }

    public class DefaultInputActions : Object
    {
        public UnityEngine.InputSystem.InputActionAsset asset; // 0x10
        public UnityEngine.InputSystem.InputActionMap bindingMask; // 0x18
        public IPlayerActions devices; // 0x20
        public UnityEngine.InputSystem.InputAction controlSchemes; // 0x28
        public UnityEngine.InputSystem.InputAction bindings; // 0x30
        public UnityEngine.InputSystem.InputAction Player; // 0x38
        public UnityEngine.InputSystem.InputActionMap UI; // 0x40
        public IUIActions KeyboardMouseScheme; // 0x48
        public UnityEngine.InputSystem.InputAction GamepadScheme; // 0x50
        public UnityEngine.InputSystem.InputAction TouchScheme; // 0x58
        public UnityEngine.InputSystem.InputAction JoystickScheme; // 0x60
        public UnityEngine.InputSystem.InputAction XRScheme; // 0x68
        public UnityEngine.InputSystem.InputAction m_UI_Click; // 0x70
        public UnityEngine.InputSystem.InputAction m_UI_ScrollWheel; // 0x78
        public UnityEngine.InputSystem.InputAction m_UI_MiddleClick; // 0x80
        public UnityEngine.InputSystem.InputAction m_UI_RightClick; // 0x88
        public UnityEngine.InputSystem.InputAction m_UI_TrackedDevicePosition; // 0x90
        public UnityEngine.InputSystem.InputAction m_UI_TrackedDeviceOrientation; // 0x98
        public int m_KeyboardMouseSchemeIndex; // 0xA0
        public int m_GamepadSchemeIndex; // 0xA4
        public int m_TouchSchemeIndex; // 0xA8
        public int m_JoystickSchemeIndex; // 0xAC
        public int m_XRSchemeIndex; // 0xB0

        // ── Methods ──
        public void get_asset(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC9620BB0
        public void Dispose(){} // RVA: 0x7FFAC9621410
        public void get_bindingMask(){} // RVA: 0x7FFAC38D9600
        public void set_bindingMask(){} // RVA: 0x7FFAC38D9810
        public void get_devices(){} // RVA: 0x7FFAC38D6D20
        public void set_devices(){} // RVA: 0x7FFAC38D6D70
        public void get_controlSchemes(){} // RVA: 0x7FFAC38D6F70
        public void Contains(){} // RVA: 0x7FFAC38D97F0
        public void GetEnumerator(){} // RVA: 0x7FFAC38D9060
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC38D9060
        public void Enable(){} // RVA: 0x7FFAC38D9200
        public void Disable(){} // RVA: 0x7FFAC38D7010
        public void get_bindings(){} // RVA: 0x7FFAC38D95E0
        public void FindAction(){} // RVA: 0x7FFAC38D9650
        public void FindBinding(){} // RVA: 0x7FFAC38D9400
        public void get_Player(){} // RVA: 0x7FFAC38D6FB0
        public void get_UI(){} // RVA: 0x7FFAC38D6FB0
        public void get_KeyboardMouseScheme(){} // RVA: 0x7FFAC9621470
        public void get_GamepadScheme(){} // RVA: 0x7FFAC96215F0
        public void get_TouchScheme(){} // RVA: 0x7FFAC9621770
        public void get_JoystickScheme(){} // RVA: 0x7FFAC96218F0
        public void get_XRScheme(){} // RVA: 0x7FFAC9621A70
    }

    public class DynamicBitfield : ValueType
    {
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<ulong> array; // 0x10
        public int length; // 0x28

        // ── Methods ──
        public void SetLength(){} // RVA: 0x7FFAC96322C0
        public void SetBit(){} // RVA: 0x7FFAC9632320
        public void TestBit(){} // RVA: 0x7FFAC96323C0
        public void ClearBit(){} // RVA: 0x7FFAC9632440
        public void AnyBitIsSet(){} // RVA: 0x7FFAC96324E0
        public void BitCountToULongCount(){} // RVA: 0x7FFAC9632550
    }

    public class FastKeyboard : Keyboard
    {
        public string metadata;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9598D00
        public void Initialize_ctrlKeyboardanyKey(){} // RVA: 0x7FFAC959DA50
        public void Initialize_ctrlKeyboardescape(){} // RVA: 0x7FFAC959DE00
        public void Initialize_ctrlKeyboardspace(){} // RVA: 0x7FFAC959E170
        public void Initialize_ctrlKeyboardenter(){} // RVA: 0x7FFAC959E4D0
        public void Initialize_ctrlKeyboardtab(){} // RVA: 0x7FFAC959E850
        public void Initialize_ctrlKeyboardbackquote(){} // RVA: 0x7FFAC959EBB0
        public void Initialize_ctrlKeyboardquote(){} // RVA: 0x7FFAC959EF10
        public void Initialize_ctrlKeyboardsemicolon(){} // RVA: 0x7FFAC959F270
        public void Initialize_ctrlKeyboardcomma(){} // RVA: 0x7FFAC959F5D0
        public void Initialize_ctrlKeyboardperiod(){} // RVA: 0x7FFAC959F930
        public void Initialize_ctrlKeyboardslash(){} // RVA: 0x7FFAC959FC90
        public void Initialize_ctrlKeyboardbackslash(){} // RVA: 0x7FFAC959FFF0
        public void Initialize_ctrlKeyboardleftBracket(){} // RVA: 0x7FFAC95A0350
        public void Initialize_ctrlKeyboardrightBracket(){} // RVA: 0x7FFAC95A06B0
        public void Initialize_ctrlKeyboardminus(){} // RVA: 0x7FFAC95A0A10
        public void Initialize_ctrlKeyboardequals(){} // RVA: 0x7FFAC95A0D70
        public void Initialize_ctrlKeyboardupArrow(){} // RVA: 0x7FFAC95A10D0
        public void Initialize_ctrlKeyboarddownArrow(){} // RVA: 0x7FFAC95A1430
        public void Initialize_ctrlKeyboardleftArrow(){} // RVA: 0x7FFAC95A1790
        public void Initialize_ctrlKeyboardrightArrow(){} // RVA: 0x7FFAC95A1AF0
        public void Initialize_ctrlKeyboarda(){} // RVA: 0x7FFAC95A1E50
        public void Initialize_ctrlKeyboardb(){} // RVA: 0x7FFAC95A21B0
        public void Initialize_ctrlKeyboardc(){} // RVA: 0x7FFAC95A2510
        public void Initialize_ctrlKeyboardd(){} // RVA: 0x7FFAC95A2870
        public void Initialize_ctrlKeyboarde(){} // RVA: 0x7FFAC95A2BD0
        public void Initialize_ctrlKeyboardf(){} // RVA: 0x7FFAC95A2F30
        public void Initialize_ctrlKeyboardg(){} // RVA: 0x7FFAC95A3290
        public void Initialize_ctrlKeyboardh(){} // RVA: 0x7FFAC95A35F0
        public void Initialize_ctrlKeyboardi(){} // RVA: 0x7FFAC95A3950
        public void Initialize_ctrlKeyboardj(){} // RVA: 0x7FFAC95A3CB0
        public void Initialize_ctrlKeyboardk(){} // RVA: 0x7FFAC95A4010
        public void Initialize_ctrlKeyboardl(){} // RVA: 0x7FFAC95A4370
        public void Initialize_ctrlKeyboardm(){} // RVA: 0x7FFAC95A46D0
        public void Initialize_ctrlKeyboardn(){} // RVA: 0x7FFAC95A4A30
        public void Initialize_ctrlKeyboardo(){} // RVA: 0x7FFAC95A4D90
        public void Initialize_ctrlKeyboardp(){} // RVA: 0x7FFAC95A50F0
        public void Initialize_ctrlKeyboardq(){} // RVA: 0x7FFAC95A5450
        public void Initialize_ctrlKeyboardr(){} // RVA: 0x7FFAC95A57B0
        public void Initialize_ctrlKeyboards(){} // RVA: 0x7FFAC95A5B10
        public void Initialize_ctrlKeyboardt(){} // RVA: 0x7FFAC95A5E70
        public void Initialize_ctrlKeyboardu(){} // RVA: 0x7FFAC95A61D0
        public void Initialize_ctrlKeyboardv(){} // RVA: 0x7FFAC95A6530
        public void Initialize_ctrlKeyboardw(){} // RVA: 0x7FFAC95A6890
        public void Initialize_ctrlKeyboardx(){} // RVA: 0x7FFAC95A6BF0
        public void Initialize_ctrlKeyboardy(){} // RVA: 0x7FFAC95A6F50
        public void Initialize_ctrlKeyboardz(){} // RVA: 0x7FFAC95A72B0
        public void Initialize_ctrlKeyboard1(){} // RVA: 0x7FFAC95A7610
        public void Initialize_ctrlKeyboard2(){} // RVA: 0x7FFAC95A7960
        public void Initialize_ctrlKeyboard3(){} // RVA: 0x7FFAC95A7CB0
        public void Initialize_ctrlKeyboard4(){} // RVA: 0x7FFAC95A8000
        public void Initialize_ctrlKeyboard5(){} // RVA: 0x7FFAC95A8350
        public void Initialize_ctrlKeyboard6(){} // RVA: 0x7FFAC95A86A0
        public void Initialize_ctrlKeyboard7(){} // RVA: 0x7FFAC95A89F0
        public void Initialize_ctrlKeyboard8(){} // RVA: 0x7FFAC95A8D40
        public void Initialize_ctrlKeyboard9(){} // RVA: 0x7FFAC95A9090
        public void Initialize_ctrlKeyboard0(){} // RVA: 0x7FFAC95A93E0
        public void Initialize_ctrlKeyboardleftShift(){} // RVA: 0x7FFAC95A9730
        public void Initialize_ctrlKeyboardrightShift(){} // RVA: 0x7FFAC95A9AB0
        public void Initialize_ctrlKeyboardshift(){} // RVA: 0x7FFAC95A9E30
        public void Initialize_ctrlKeyboardleftAlt(){} // RVA: 0x7FFAC95AA1D0
        public void Initialize_ctrlKeyboardrightAlt(){} // RVA: 0x7FFAC95AA550
        public void Initialize_ctrlKeyboardalt(){} // RVA: 0x7FFAC95AA8D0
        public void Initialize_ctrlKeyboardleftCtrl(){} // RVA: 0x7FFAC95AAC70
        public void Initialize_ctrlKeyboardrightCtrl(){} // RVA: 0x7FFAC95AAFF0
        public void Initialize_ctrlKeyboardctrl(){} // RVA: 0x7FFAC95AB370
        public void Initialize_ctrlKeyboardleftMeta(){} // RVA: 0x7FFAC95AB710
        public void Initialize_ctrlKeyboardrightMeta(){} // RVA: 0x7FFAC95ABAA0
        public void Initialize_ctrlKeyboardcontextMenu(){} // RVA: 0x7FFAC95ABE30
        public void Initialize_ctrlKeyboardbackspace(){} // RVA: 0x7FFAC95AC1B0
        public void Initialize_ctrlKeyboardpageDown(){} // RVA: 0x7FFAC95AC510
        public void Initialize_ctrlKeyboardpageUp(){} // RVA: 0x7FFAC95AC870
        public void Initialize_ctrlKeyboardhome(){} // RVA: 0x7FFAC95ACBD0
        public void Initialize_ctrlKeyboardend(){} // RVA: 0x7FFAC95ACF30
        public void Initialize_ctrlKeyboardinsert(){} // RVA: 0x7FFAC95AD290
        public void Initialize_ctrlKeyboarddelete(){} // RVA: 0x7FFAC95AD5F0
        public void Initialize_ctrlKeyboardcapsLock(){} // RVA: 0x7FFAC95AD950
        public void Initialize_ctrlKeyboardnumLock(){} // RVA: 0x7FFAC95ADCB0
        public void Initialize_ctrlKeyboardprintScreen(){} // RVA: 0x7FFAC95AE010
        public void Initialize_ctrlKeyboardscrollLock(){} // RVA: 0x7FFAC95AE370
        public void Initialize_ctrlKeyboardpause(){} // RVA: 0x7FFAC95AE6D0
        public void Initialize_ctrlKeyboardnumpadEnter(){} // RVA: 0x7FFAC95AEA30
        public void Initialize_ctrlKeyboardnumpadDivide(){} // RVA: 0x7FFAC95AED90
        public void Initialize_ctrlKeyboardnumpadMultiply(){} // RVA: 0x7FFAC95AF0F0
        public void Initialize_ctrlKeyboardnumpadPlus(){} // RVA: 0x7FFAC95AF450
        public void Initialize_ctrlKeyboardnumpadMinus(){} // RVA: 0x7FFAC95AF7B0
        public void Initialize_ctrlKeyboardnumpadPeriod(){} // RVA: 0x7FFAC95AFB10
        public void Initialize_ctrlKeyboardnumpadEquals(){} // RVA: 0x7FFAC95AFE70
        public void Initialize_ctrlKeyboardnumpad1(){} // RVA: 0x7FFAC95B01D0
        public void Initialize_ctrlKeyboardnumpad2(){} // RVA: 0x7FFAC95B0530
        public void Initialize_ctrlKeyboardnumpad3(){} // RVA: 0x7FFAC95B0890
        public void Initialize_ctrlKeyboardnumpad4(){} // RVA: 0x7FFAC95B0BF0
        public void Initialize_ctrlKeyboardnumpad5(){} // RVA: 0x7FFAC95B0F50
        public void Initialize_ctrlKeyboardnumpad6(){} // RVA: 0x7FFAC95B12B0
        public void Initialize_ctrlKeyboardnumpad7(){} // RVA: 0x7FFAC95B1610
        public void Initialize_ctrlKeyboardnumpad8(){} // RVA: 0x7FFAC95B1970
        public void Initialize_ctrlKeyboardnumpad9(){} // RVA: 0x7FFAC95B1CD0
        public void Initialize_ctrlKeyboardnumpad0(){} // RVA: 0x7FFAC95B2030
        public void Initialize_ctrlKeyboardf1(){} // RVA: 0x7FFAC95B2390
        public void Initialize_ctrlKeyboardf2(){} // RVA: 0x7FFAC95B26F0
        public void Initialize_ctrlKeyboardf3(){} // RVA: 0x7FFAC95B2A50
        public void Initialize_ctrlKeyboardf4(){} // RVA: 0x7FFAC95B2DB0
        public void Initialize_ctrlKeyboardf5(){} // RVA: 0x7FFAC95B3110
        public void Initialize_ctrlKeyboardf6(){} // RVA: 0x7FFAC95B3470
        public void Initialize_ctrlKeyboardf7(){} // RVA: 0x7FFAC95B37D0
        public void Initialize_ctrlKeyboardf8(){} // RVA: 0x7FFAC95B3B30
        public void Initialize_ctrlKeyboardf9(){} // RVA: 0x7FFAC95B3E90
        public void Initialize_ctrlKeyboardf10(){} // RVA: 0x7FFAC95B41F0
        public void Initialize_ctrlKeyboardf11(){} // RVA: 0x7FFAC95B4550
        public void Initialize_ctrlKeyboardf12(){} // RVA: 0x7FFAC95B48B0
        public void Initialize_ctrlKeyboardOEM1(){} // RVA: 0x7FFAC95B4C10
        public void Initialize_ctrlKeyboardOEM2(){} // RVA: 0x7FFAC95B4F60
        public void Initialize_ctrlKeyboardOEM3(){} // RVA: 0x7FFAC95B52B0
        public void Initialize_ctrlKeyboardOEM4(){} // RVA: 0x7FFAC95B5600
        public void Initialize_ctrlKeyboardOEM5(){} // RVA: 0x7FFAC95B5950
        public void Initialize_ctrlKeyboardf13(){} // RVA: 0x7FFAC95B5CA0
        public void Initialize_ctrlKeyboardf14(){} // RVA: 0x7FFAC95B6000
        public void Initialize_ctrlKeyboardf15(){} // RVA: 0x7FFAC95B6360
        public void Initialize_ctrlKeyboardf16(){} // RVA: 0x7FFAC95B66C0
        public void Initialize_ctrlKeyboardf17(){} // RVA: 0x7FFAC95B6A20
        public void Initialize_ctrlKeyboardf18(){} // RVA: 0x7FFAC95B6D80
        public void Initialize_ctrlKeyboardf19(){} // RVA: 0x7FFAC95B70E0
        public void Initialize_ctrlKeyboardf20(){} // RVA: 0x7FFAC95B7440
        public void Initialize_ctrlKeyboardf21(){} // RVA: 0x7FFAC95B77A0
        public void Initialize_ctrlKeyboardf22(){} // RVA: 0x7FFAC95B7B00
        public void Initialize_ctrlKeyboardf23(){} // RVA: 0x7FFAC95B7E60
        public void Initialize_ctrlKeyboardf24(){} // RVA: 0x7FFAC95B81C0
        public void Initialize_ctrlKeyboardIMESelected(){} // RVA: 0x7FFAC95B8520
    }

    public class FastMouse : Mouse
    {
        public string metadata;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC95F8A80
        public void Initialize_ctrlMouseposition(){} // RVA: 0x7FFAC95FA4B0
        public void Initialize_ctrlMousedelta(){} // RVA: 0x7FFAC95FA7D0
        public void Initialize_ctrlMousescroll(){} // RVA: 0x7FFAC95FAAE0
        public void Initialize_ctrlMousepress(){} // RVA: 0x7FFAC95FADE0
        public void Initialize_ctrlMouseleftButton(){} // RVA: 0x7FFAC95FB140
        public void Initialize_ctrlMouserightButton(){} // RVA: 0x7FFAC95FB4C0
        public void Initialize_ctrlMousemiddleButton(){} // RVA: 0x7FFAC95FB840
        public void Initialize_ctrlMouseforwardButton(){} // RVA: 0x7FFAC95FBBB0
        public void Initialize_ctrlMousebackButton(){} // RVA: 0x7FFAC95FBF20
        public void Initialize_ctrlMousepressure(){} // RVA: 0x7FFAC95FC290
        public void Initialize_ctrlMouseradius(){} // RVA: 0x7FFAC95FC5C0
        public void Initialize_ctrlMousepointerId(){} // RVA: 0x7FFAC95FC8D0
        public void Initialize_ctrlMousedisplayIndex(){} // RVA: 0x7FFAC95FCBB0
        public void Initialize_ctrlMouseclickCount(){} // RVA: 0x7FFAC95FCEA0
        public void Initialize_ctrlMousepositionx(){} // RVA: 0x7FFAC95FD190
        public void Initialize_ctrlMousepositiony(){} // RVA: 0x7FFAC95FD4B0
        public void Initialize_ctrlMousedeltaup(){} // RVA: 0x7FFAC95FD7D0
        public void Initialize_ctrlMousedeltadown(){} // RVA: 0x7FFAC95FDB00
        public void Initialize_ctrlMousedeltaleft(){} // RVA: 0x7FFAC95FDE30
        public void Initialize_ctrlMousedeltaright(){} // RVA: 0x7FFAC95FE160
        public void Initialize_ctrlMousedeltax(){} // RVA: 0x7FFAC95FE490
        public void Initialize_ctrlMousedeltay(){} // RVA: 0x7FFAC95FE790
        public void Initialize_ctrlMousescrollup(){} // RVA: 0x7FFAC95FEA90
        public void Initialize_ctrlMousescrolldown(){} // RVA: 0x7FFAC95FEDC0
        public void Initialize_ctrlMousescrollleft(){} // RVA: 0x7FFAC95FF0F0
        public void Initialize_ctrlMousescrollright(){} // RVA: 0x7FFAC95FF420
        public void Initialize_ctrlMousescrollx(){} // RVA: 0x7FFAC95FF750
        public void Initialize_ctrlMousescrolly(){} // RVA: 0x7FFAC95FFA70
        public void Initialize_ctrlMouseradiusx(){} // RVA: 0x7FFAC95FFDB0
        public void Initialize_ctrlMouseradiusy(){} // RVA: 0x7FFAC96000B0
        public void OnNextUpdate(){} // RVA: 0x7FFAC96003B0
        public void OnStateEvent(){} // RVA: 0x7FFAC9600510
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFAC96003B0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFAC9600510
        public void MergeForward(){} // RVA: 0x7FFAC96006B0
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7FFAC9600760
    }

    public class FastTouchscreen : Touchscreen
    {
        public string metadata;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC95B8B90
        public void Initialize_ctrlTouchscreenprimaryTouch(){} // RVA: 0x7FFAC95BDFB0
        public void Initialize_ctrlTouchscreenposition(){} // RVA: 0x7FFAC95BE2B0
        public void Initialize_ctrlTouchscreendelta(){} // RVA: 0x7FFAC95BE5E0
        public void Initialize_ctrlTouchscreenpressure(){} // RVA: 0x7FFAC95BE8F0
        public void Initialize_ctrlTouchscreenradius(){} // RVA: 0x7FFAC95BEC20
        public void Initialize_ctrlTouchscreenpress(){} // RVA: 0x7FFAC95BEF30
        public void Initialize_ctrlTouchscreendisplayIndex(){} // RVA: 0x7FFAC95BF290
        public void Initialize_ctrlTouchscreentouch0(){} // RVA: 0x7FFAC95BF580
        public void Initialize_ctrlTouchscreentouch1(){} // RVA: 0x7FFAC95BF880
        public void Initialize_ctrlTouchscreentouch2(){} // RVA: 0x7FFAC95BFB80
        public void Initialize_ctrlTouchscreentouch3(){} // RVA: 0x7FFAC95BFE80
        public void Initialize_ctrlTouchscreentouch4(){} // RVA: 0x7FFAC95C0180
        public void Initialize_ctrlTouchscreentouch5(){} // RVA: 0x7FFAC95C0480
        public void Initialize_ctrlTouchscreentouch6(){} // RVA: 0x7FFAC95C0780
        public void Initialize_ctrlTouchscreentouch7(){} // RVA: 0x7FFAC95C0A80
        public void Initialize_ctrlTouchscreentouch8(){} // RVA: 0x7FFAC95C0D80
        public void Initialize_ctrlTouchscreentouch9(){} // RVA: 0x7FFAC95C1080
        public void Initialize_ctrlTouchscreenprimaryTouchtouchId(){} // RVA: 0x7FFAC95C1380
        public void Initialize_ctrlTouchscreenprimaryTouchposition(){} // RVA: 0x7FFAC95C16A0
        public void Initialize_ctrlTouchscreenprimaryTouchdelta(){} // RVA: 0x7FFAC95C19D0
        public void Initialize_ctrlTouchscreenprimaryTouchpressure(){} // RVA: 0x7FFAC95C1CE0
        public void Initialize_ctrlTouchscreenprimaryTouchradius(){} // RVA: 0x7FFAC95C1FE0
        public void Initialize_ctrlTouchscreenprimaryTouchphase(){} // RVA: 0x7FFAC95C22F0
        public void Initialize_ctrlTouchscreenprimaryTouchpress(){} // RVA: 0x7FFAC95C2600
        public void Initialize_ctrlTouchscreenprimaryTouchtapCount(){} // RVA: 0x7FFAC95C2960
        public void Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(){} // RVA: 0x7FFAC95C2C60
        public void Initialize_ctrlTouchscreenprimaryTouchindirectTouch(){} // RVA: 0x7FFAC95C2F60
        public void Initialize_ctrlTouchscreenprimaryTouchtap(){} // RVA: 0x7FFAC95C32C0
        public void Initialize_ctrlTouchscreenprimaryTouchstartTime(){} // RVA: 0x7FFAC95C3630
        public void Initialize_ctrlTouchscreenprimaryTouchstartPosition(){} // RVA: 0x7FFAC95C3940
        public void Initialize_ctrlTouchscreenprimaryTouchpositionx(){} // RVA: 0x7FFAC95C3C60
        public void Initialize_ctrlTouchscreenprimaryTouchpositiony(){} // RVA: 0x7FFAC95C3F80
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaup(){} // RVA: 0x7FFAC95C42A0
        public void Initialize_ctrlTouchscreenprimaryTouchdeltadown(){} // RVA: 0x7FFAC95C45D0
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaleft(){} // RVA: 0x7FFAC95C4900
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaright(){} // RVA: 0x7FFAC95C4C30
        public void Initialize_ctrlTouchscreenprimaryTouchdeltax(){} // RVA: 0x7FFAC95C4F60
        public void Initialize_ctrlTouchscreenprimaryTouchdeltay(){} // RVA: 0x7FFAC95C5260
        public void Initialize_ctrlTouchscreenprimaryTouchradiusx(){} // RVA: 0x7FFAC95C5560
        public void Initialize_ctrlTouchscreenprimaryTouchradiusy(){} // RVA: 0x7FFAC95C5860
        public void Initialize_ctrlTouchscreenprimaryTouchstartPositionx(){} // RVA: 0x7FFAC95C5B60
        public void Initialize_ctrlTouchscreenprimaryTouchstartPositiony(){} // RVA: 0x7FFAC95C5E60
        public void Initialize_ctrlTouchscreenpositionx(){} // RVA: 0x7FFAC95C6160
        public void Initialize_ctrlTouchscreenpositiony(){} // RVA: 0x7FFAC95C6480
        public void Initialize_ctrlTouchscreendeltaup(){} // RVA: 0x7FFAC95C67A0
        public void Initialize_ctrlTouchscreendeltadown(){} // RVA: 0x7FFAC95C6AD0
        public void Initialize_ctrlTouchscreendeltaleft(){} // RVA: 0x7FFAC95C6E00
        public void Initialize_ctrlTouchscreendeltaright(){} // RVA: 0x7FFAC95C7130
        public void Initialize_ctrlTouchscreendeltax(){} // RVA: 0x7FFAC95C7460
        public void Initialize_ctrlTouchscreendeltay(){} // RVA: 0x7FFAC95C7760
        public void Initialize_ctrlTouchscreenradiusx(){} // RVA: 0x7FFAC95C7A60
        public void Initialize_ctrlTouchscreenradiusy(){} // RVA: 0x7FFAC95C7D60
        public void Initialize_ctrlTouchscreentouch0touchId(){} // RVA: 0x7FFAC95C8060
        public void Initialize_ctrlTouchscreentouch0position(){} // RVA: 0x7FFAC95C8380
        public void Initialize_ctrlTouchscreentouch0delta(){} // RVA: 0x7FFAC95C86B0
        public void Initialize_ctrlTouchscreentouch0pressure(){} // RVA: 0x7FFAC95C89C0
        public void Initialize_ctrlTouchscreentouch0radius(){} // RVA: 0x7FFAC95C8CC0
        public void Initialize_ctrlTouchscreentouch0phase(){} // RVA: 0x7FFAC95C8FD0
        public void Initialize_ctrlTouchscreentouch0press(){} // RVA: 0x7FFAC95C92E0
        public void Initialize_ctrlTouchscreentouch0tapCount(){} // RVA: 0x7FFAC95C9640
        public void Initialize_ctrlTouchscreentouch0displayIndex(){} // RVA: 0x7FFAC95C9940
        public void Initialize_ctrlTouchscreentouch0indirectTouch(){} // RVA: 0x7FFAC95C9C40
        public void Initialize_ctrlTouchscreentouch0tap(){} // RVA: 0x7FFAC95C9FA0
        public void Initialize_ctrlTouchscreentouch0startTime(){} // RVA: 0x7FFAC95CA300
        public void Initialize_ctrlTouchscreentouch0startPosition(){} // RVA: 0x7FFAC95CA610
        public void Initialize_ctrlTouchscreentouch0positionx(){} // RVA: 0x7FFAC95CA930
        public void Initialize_ctrlTouchscreentouch0positiony(){} // RVA: 0x7FFAC95CAC50
        public void Initialize_ctrlTouchscreentouch0deltaup(){} // RVA: 0x7FFAC95CAF70
        public void Initialize_ctrlTouchscreentouch0deltadown(){} // RVA: 0x7FFAC95CB2A0
        public void Initialize_ctrlTouchscreentouch0deltaleft(){} // RVA: 0x7FFAC95CB5D0
        public void Initialize_ctrlTouchscreentouch0deltaright(){} // RVA: 0x7FFAC95CB900
        public void Initialize_ctrlTouchscreentouch0deltax(){} // RVA: 0x7FFAC95CBC30
        public void Initialize_ctrlTouchscreentouch0deltay(){} // RVA: 0x7FFAC95CBF30
        public void Initialize_ctrlTouchscreentouch0radiusx(){} // RVA: 0x7FFAC95CC230
        public void Initialize_ctrlTouchscreentouch0radiusy(){} // RVA: 0x7FFAC95CC530
        public void Initialize_ctrlTouchscreentouch0startPositionx(){} // RVA: 0x7FFAC95CC830
        public void Initialize_ctrlTouchscreentouch0startPositiony(){} // RVA: 0x7FFAC95CCB30
        public void Initialize_ctrlTouchscreentouch1touchId(){} // RVA: 0x7FFAC95CCE30
        public void Initialize_ctrlTouchscreentouch1position(){} // RVA: 0x7FFAC95CD150
        public void Initialize_ctrlTouchscreentouch1delta(){} // RVA: 0x7FFAC95CD480
        public void Initialize_ctrlTouchscreentouch1pressure(){} // RVA: 0x7FFAC95CD790
        public void Initialize_ctrlTouchscreentouch1radius(){} // RVA: 0x7FFAC95CDA90
        public void Initialize_ctrlTouchscreentouch1phase(){} // RVA: 0x7FFAC95CDDA0
        public void Initialize_ctrlTouchscreentouch1press(){} // RVA: 0x7FFAC95CE0B0
        public void Initialize_ctrlTouchscreentouch1tapCount(){} // RVA: 0x7FFAC95CE410
        public void Initialize_ctrlTouchscreentouch1displayIndex(){} // RVA: 0x7FFAC95CE710
        public void Initialize_ctrlTouchscreentouch1indirectTouch(){} // RVA: 0x7FFAC95CEA10
        public void Initialize_ctrlTouchscreentouch1tap(){} // RVA: 0x7FFAC95CED70
        public void Initialize_ctrlTouchscreentouch1startTime(){} // RVA: 0x7FFAC95CF0D0
        public void Initialize_ctrlTouchscreentouch1startPosition(){} // RVA: 0x7FFAC95CF3E0
        public void Initialize_ctrlTouchscreentouch1positionx(){} // RVA: 0x7FFAC95CF700
        public void Initialize_ctrlTouchscreentouch1positiony(){} // RVA: 0x7FFAC95CFA20
        public void Initialize_ctrlTouchscreentouch1deltaup(){} // RVA: 0x7FFAC95CFD40
        public void Initialize_ctrlTouchscreentouch1deltadown(){} // RVA: 0x7FFAC95D0070
        public void Initialize_ctrlTouchscreentouch1deltaleft(){} // RVA: 0x7FFAC95D03A0
        public void Initialize_ctrlTouchscreentouch1deltaright(){} // RVA: 0x7FFAC95D06D0
        public void Initialize_ctrlTouchscreentouch1deltax(){} // RVA: 0x7FFAC95D0A00
        public void Initialize_ctrlTouchscreentouch1deltay(){} // RVA: 0x7FFAC95D0D00
        public void Initialize_ctrlTouchscreentouch1radiusx(){} // RVA: 0x7FFAC95D1000
        public void Initialize_ctrlTouchscreentouch1radiusy(){} // RVA: 0x7FFAC95D1300
        public void Initialize_ctrlTouchscreentouch1startPositionx(){} // RVA: 0x7FFAC95D1600
        public void Initialize_ctrlTouchscreentouch1startPositiony(){} // RVA: 0x7FFAC95D1900
        public void Initialize_ctrlTouchscreentouch2touchId(){} // RVA: 0x7FFAC95D1C00
        public void Initialize_ctrlTouchscreentouch2position(){} // RVA: 0x7FFAC95D1F20
        public void Initialize_ctrlTouchscreentouch2delta(){} // RVA: 0x7FFAC95D2250
        public void Initialize_ctrlTouchscreentouch2pressure(){} // RVA: 0x7FFAC95D2560
        public void Initialize_ctrlTouchscreentouch2radius(){} // RVA: 0x7FFAC95D2860
        public void Initialize_ctrlTouchscreentouch2phase(){} // RVA: 0x7FFAC95D2B70
        public void Initialize_ctrlTouchscreentouch2press(){} // RVA: 0x7FFAC95D2E80
        public void Initialize_ctrlTouchscreentouch2tapCount(){} // RVA: 0x7FFAC95D31E0
        public void Initialize_ctrlTouchscreentouch2displayIndex(){} // RVA: 0x7FFAC95D34E0
        public void Initialize_ctrlTouchscreentouch2indirectTouch(){} // RVA: 0x7FFAC95D37E0
        public void Initialize_ctrlTouchscreentouch2tap(){} // RVA: 0x7FFAC95D3B40
        public void Initialize_ctrlTouchscreentouch2startTime(){} // RVA: 0x7FFAC95D3EA0
        public void Initialize_ctrlTouchscreentouch2startPosition(){} // RVA: 0x7FFAC95D41B0
        public void Initialize_ctrlTouchscreentouch2positionx(){} // RVA: 0x7FFAC95D44D0
        public void Initialize_ctrlTouchscreentouch2positiony(){} // RVA: 0x7FFAC95D47F0
        public void Initialize_ctrlTouchscreentouch2deltaup(){} // RVA: 0x7FFAC95D4B10
        public void Initialize_ctrlTouchscreentouch2deltadown(){} // RVA: 0x7FFAC95D4E40
        public void Initialize_ctrlTouchscreentouch2deltaleft(){} // RVA: 0x7FFAC95D5170
        public void Initialize_ctrlTouchscreentouch2deltaright(){} // RVA: 0x7FFAC95D54A0
        public void Initialize_ctrlTouchscreentouch2deltax(){} // RVA: 0x7FFAC95D57D0
        public void Initialize_ctrlTouchscreentouch2deltay(){} // RVA: 0x7FFAC95D5AD0
        public void Initialize_ctrlTouchscreentouch2radiusx(){} // RVA: 0x7FFAC95D5DD0
        public void Initialize_ctrlTouchscreentouch2radiusy(){} // RVA: 0x7FFAC95D60D0
        public void Initialize_ctrlTouchscreentouch2startPositionx(){} // RVA: 0x7FFAC95D63D0
        public void Initialize_ctrlTouchscreentouch2startPositiony(){} // RVA: 0x7FFAC95D66D0
        public void Initialize_ctrlTouchscreentouch3touchId(){} // RVA: 0x7FFAC95D69D0
        public void Initialize_ctrlTouchscreentouch3position(){} // RVA: 0x7FFAC95D6CF0
        public void Initialize_ctrlTouchscreentouch3delta(){} // RVA: 0x7FFAC95D7020
        public void Initialize_ctrlTouchscreentouch3pressure(){} // RVA: 0x7FFAC95D7330
        public void Initialize_ctrlTouchscreentouch3radius(){} // RVA: 0x7FFAC95D7630
        public void Initialize_ctrlTouchscreentouch3phase(){} // RVA: 0x7FFAC95D7940
        public void Initialize_ctrlTouchscreentouch3press(){} // RVA: 0x7FFAC95D7C50
        public void Initialize_ctrlTouchscreentouch3tapCount(){} // RVA: 0x7FFAC95D7FB0
        public void Initialize_ctrlTouchscreentouch3displayIndex(){} // RVA: 0x7FFAC95D82B0
        public void Initialize_ctrlTouchscreentouch3indirectTouch(){} // RVA: 0x7FFAC95D85B0
        public void Initialize_ctrlTouchscreentouch3tap(){} // RVA: 0x7FFAC95D8910
        public void Initialize_ctrlTouchscreentouch3startTime(){} // RVA: 0x7FFAC95D8C70
        public void Initialize_ctrlTouchscreentouch3startPosition(){} // RVA: 0x7FFAC95D8F80
        public void Initialize_ctrlTouchscreentouch3positionx(){} // RVA: 0x7FFAC95D92A0
        public void Initialize_ctrlTouchscreentouch3positiony(){} // RVA: 0x7FFAC95D95C0
        public void Initialize_ctrlTouchscreentouch3deltaup(){} // RVA: 0x7FFAC95D98E0
        public void Initialize_ctrlTouchscreentouch3deltadown(){} // RVA: 0x7FFAC95D9C10
        public void Initialize_ctrlTouchscreentouch3deltaleft(){} // RVA: 0x7FFAC95D9F40
        public void Initialize_ctrlTouchscreentouch3deltaright(){} // RVA: 0x7FFAC95DA270
        public void Initialize_ctrlTouchscreentouch3deltax(){} // RVA: 0x7FFAC95DA5A0
        public void Initialize_ctrlTouchscreentouch3deltay(){} // RVA: 0x7FFAC95DA8A0
        public void Initialize_ctrlTouchscreentouch3radiusx(){} // RVA: 0x7FFAC95DABA0
        public void Initialize_ctrlTouchscreentouch3radiusy(){} // RVA: 0x7FFAC95DAEA0
        public void Initialize_ctrlTouchscreentouch3startPositionx(){} // RVA: 0x7FFAC95DB1A0
        public void Initialize_ctrlTouchscreentouch3startPositiony(){} // RVA: 0x7FFAC95DB4A0
        public void Initialize_ctrlTouchscreentouch4touchId(){} // RVA: 0x7FFAC95DB7A0
        public void Initialize_ctrlTouchscreentouch4position(){} // RVA: 0x7FFAC95DBAC0
        public void Initialize_ctrlTouchscreentouch4delta(){} // RVA: 0x7FFAC95DBDF0
        public void Initialize_ctrlTouchscreentouch4pressure(){} // RVA: 0x7FFAC95DC100
        public void Initialize_ctrlTouchscreentouch4radius(){} // RVA: 0x7FFAC95DC400
        public void Initialize_ctrlTouchscreentouch4phase(){} // RVA: 0x7FFAC95DC710
        public void Initialize_ctrlTouchscreentouch4press(){} // RVA: 0x7FFAC95DCA20
        public void Initialize_ctrlTouchscreentouch4tapCount(){} // RVA: 0x7FFAC95DCD80
        public void Initialize_ctrlTouchscreentouch4displayIndex(){} // RVA: 0x7FFAC95DD080
        public void Initialize_ctrlTouchscreentouch4indirectTouch(){} // RVA: 0x7FFAC95DD380
        public void Initialize_ctrlTouchscreentouch4tap(){} // RVA: 0x7FFAC95DD6E0
        public void Initialize_ctrlTouchscreentouch4startTime(){} // RVA: 0x7FFAC95DDA40
        public void Initialize_ctrlTouchscreentouch4startPosition(){} // RVA: 0x7FFAC95DDD50
        public void Initialize_ctrlTouchscreentouch4positionx(){} // RVA: 0x7FFAC95DE070
        public void Initialize_ctrlTouchscreentouch4positiony(){} // RVA: 0x7FFAC95DE390
        public void Initialize_ctrlTouchscreentouch4deltaup(){} // RVA: 0x7FFAC95DE6B0
        public void Initialize_ctrlTouchscreentouch4deltadown(){} // RVA: 0x7FFAC95DE9E0
        public void Initialize_ctrlTouchscreentouch4deltaleft(){} // RVA: 0x7FFAC95DED10
        public void Initialize_ctrlTouchscreentouch4deltaright(){} // RVA: 0x7FFAC95DF040
        public void Initialize_ctrlTouchscreentouch4deltax(){} // RVA: 0x7FFAC95DF370
        public void Initialize_ctrlTouchscreentouch4deltay(){} // RVA: 0x7FFAC95DF670
        public void Initialize_ctrlTouchscreentouch4radiusx(){} // RVA: 0x7FFAC95DF970
        public void Initialize_ctrlTouchscreentouch4radiusy(){} // RVA: 0x7FFAC95DFC70
        public void Initialize_ctrlTouchscreentouch4startPositionx(){} // RVA: 0x7FFAC95DFF70
        public void Initialize_ctrlTouchscreentouch4startPositiony(){} // RVA: 0x7FFAC95E0270
        public void Initialize_ctrlTouchscreentouch5touchId(){} // RVA: 0x7FFAC95E0570
        public void Initialize_ctrlTouchscreentouch5position(){} // RVA: 0x7FFAC95E0890
        public void Initialize_ctrlTouchscreentouch5delta(){} // RVA: 0x7FFAC95E0BC0
        public void Initialize_ctrlTouchscreentouch5pressure(){} // RVA: 0x7FFAC95E0ED0
        public void Initialize_ctrlTouchscreentouch5radius(){} // RVA: 0x7FFAC95E11D0
        public void Initialize_ctrlTouchscreentouch5phase(){} // RVA: 0x7FFAC95E14E0
        public void Initialize_ctrlTouchscreentouch5press(){} // RVA: 0x7FFAC95E17F0
        public void Initialize_ctrlTouchscreentouch5tapCount(){} // RVA: 0x7FFAC95E1B50
        public void Initialize_ctrlTouchscreentouch5displayIndex(){} // RVA: 0x7FFAC95E1E50
        public void Initialize_ctrlTouchscreentouch5indirectTouch(){} // RVA: 0x7FFAC95E2150
        public void Initialize_ctrlTouchscreentouch5tap(){} // RVA: 0x7FFAC95E24B0
        public void Initialize_ctrlTouchscreentouch5startTime(){} // RVA: 0x7FFAC95E2810
        public void Initialize_ctrlTouchscreentouch5startPosition(){} // RVA: 0x7FFAC95E2B20
        public void Initialize_ctrlTouchscreentouch5positionx(){} // RVA: 0x7FFAC95E2E40
        public void Initialize_ctrlTouchscreentouch5positiony(){} // RVA: 0x7FFAC95E3160
        public void Initialize_ctrlTouchscreentouch5deltaup(){} // RVA: 0x7FFAC95E3480
        public void Initialize_ctrlTouchscreentouch5deltadown(){} // RVA: 0x7FFAC95E37B0
        public void Initialize_ctrlTouchscreentouch5deltaleft(){} // RVA: 0x7FFAC95E3AE0
        public void Initialize_ctrlTouchscreentouch5deltaright(){} // RVA: 0x7FFAC95E3E10
        public void Initialize_ctrlTouchscreentouch5deltax(){} // RVA: 0x7FFAC95E4140
        public void Initialize_ctrlTouchscreentouch5deltay(){} // RVA: 0x7FFAC95E4440
        public void Initialize_ctrlTouchscreentouch5radiusx(){} // RVA: 0x7FFAC95E4740
        public void Initialize_ctrlTouchscreentouch5radiusy(){} // RVA: 0x7FFAC95E4A40
        public void Initialize_ctrlTouchscreentouch5startPositionx(){} // RVA: 0x7FFAC95E4D40
        public void Initialize_ctrlTouchscreentouch5startPositiony(){} // RVA: 0x7FFAC95E5040
        public void Initialize_ctrlTouchscreentouch6touchId(){} // RVA: 0x7FFAC95E5340
        public void Initialize_ctrlTouchscreentouch6position(){} // RVA: 0x7FFAC95E5660
        public void Initialize_ctrlTouchscreentouch6delta(){} // RVA: 0x7FFAC95E5990
        public void Initialize_ctrlTouchscreentouch6pressure(){} // RVA: 0x7FFAC95E5CA0
        public void Initialize_ctrlTouchscreentouch6radius(){} // RVA: 0x7FFAC95E5FA0
        public void Initialize_ctrlTouchscreentouch6phase(){} // RVA: 0x7FFAC95E62B0
        public void Initialize_ctrlTouchscreentouch6press(){} // RVA: 0x7FFAC95E65C0
        public void Initialize_ctrlTouchscreentouch6tapCount(){} // RVA: 0x7FFAC95E6920
        public void Initialize_ctrlTouchscreentouch6displayIndex(){} // RVA: 0x7FFAC95E6C20
        public void Initialize_ctrlTouchscreentouch6indirectTouch(){} // RVA: 0x7FFAC95E6F20
        public void Initialize_ctrlTouchscreentouch6tap(){} // RVA: 0x7FFAC95E7280
        public void Initialize_ctrlTouchscreentouch6startTime(){} // RVA: 0x7FFAC95E75E0
        public void Initialize_ctrlTouchscreentouch6startPosition(){} // RVA: 0x7FFAC95E78F0
        public void Initialize_ctrlTouchscreentouch6positionx(){} // RVA: 0x7FFAC95E7C10
        public void Initialize_ctrlTouchscreentouch6positiony(){} // RVA: 0x7FFAC95E7F30
        public void Initialize_ctrlTouchscreentouch6deltaup(){} // RVA: 0x7FFAC95E8250
        public void Initialize_ctrlTouchscreentouch6deltadown(){} // RVA: 0x7FFAC95E8580
        public void Initialize_ctrlTouchscreentouch6deltaleft(){} // RVA: 0x7FFAC95E88B0
        public void Initialize_ctrlTouchscreentouch6deltaright(){} // RVA: 0x7FFAC95E8BE0
        public void Initialize_ctrlTouchscreentouch6deltax(){} // RVA: 0x7FFAC95E8F10
        public void Initialize_ctrlTouchscreentouch6deltay(){} // RVA: 0x7FFAC95E9210
        public void Initialize_ctrlTouchscreentouch6radiusx(){} // RVA: 0x7FFAC95E9510
        public void Initialize_ctrlTouchscreentouch6radiusy(){} // RVA: 0x7FFAC95E9810
        public void Initialize_ctrlTouchscreentouch6startPositionx(){} // RVA: 0x7FFAC95E9B10
        public void Initialize_ctrlTouchscreentouch6startPositiony(){} // RVA: 0x7FFAC95E9E10
        public void Initialize_ctrlTouchscreentouch7touchId(){} // RVA: 0x7FFAC95EA110
        public void Initialize_ctrlTouchscreentouch7position(){} // RVA: 0x7FFAC95EA430
        public void Initialize_ctrlTouchscreentouch7delta(){} // RVA: 0x7FFAC95EA760
        public void Initialize_ctrlTouchscreentouch7pressure(){} // RVA: 0x7FFAC95EAA70
        public void Initialize_ctrlTouchscreentouch7radius(){} // RVA: 0x7FFAC95EAD70
        public void Initialize_ctrlTouchscreentouch7phase(){} // RVA: 0x7FFAC95EB080
        public void Initialize_ctrlTouchscreentouch7press(){} // RVA: 0x7FFAC95EB390
        public void Initialize_ctrlTouchscreentouch7tapCount(){} // RVA: 0x7FFAC95EB6F0
        public void Initialize_ctrlTouchscreentouch7displayIndex(){} // RVA: 0x7FFAC95EB9F0
        public void Initialize_ctrlTouchscreentouch7indirectTouch(){} // RVA: 0x7FFAC95EBCF0
        public void Initialize_ctrlTouchscreentouch7tap(){} // RVA: 0x7FFAC95EC050
        public void Initialize_ctrlTouchscreentouch7startTime(){} // RVA: 0x7FFAC95EC3B0
        public void Initialize_ctrlTouchscreentouch7startPosition(){} // RVA: 0x7FFAC95EC6C0
        public void Initialize_ctrlTouchscreentouch7positionx(){} // RVA: 0x7FFAC95EC9E0
        public void Initialize_ctrlTouchscreentouch7positiony(){} // RVA: 0x7FFAC95ECD00
        public void Initialize_ctrlTouchscreentouch7deltaup(){} // RVA: 0x7FFAC95ED020
        public void Initialize_ctrlTouchscreentouch7deltadown(){} // RVA: 0x7FFAC95ED350
        public void Initialize_ctrlTouchscreentouch7deltaleft(){} // RVA: 0x7FFAC95ED680
        public void Initialize_ctrlTouchscreentouch7deltaright(){} // RVA: 0x7FFAC95ED9B0
        public void Initialize_ctrlTouchscreentouch7deltax(){} // RVA: 0x7FFAC95EDCE0
        public void Initialize_ctrlTouchscreentouch7deltay(){} // RVA: 0x7FFAC95EDFE0
        public void Initialize_ctrlTouchscreentouch7radiusx(){} // RVA: 0x7FFAC95EE2E0
        public void Initialize_ctrlTouchscreentouch7radiusy(){} // RVA: 0x7FFAC95EE5E0
        public void Initialize_ctrlTouchscreentouch7startPositionx(){} // RVA: 0x7FFAC95EE8E0
        public void Initialize_ctrlTouchscreentouch7startPositiony(){} // RVA: 0x7FFAC95EEBE0
        public void Initialize_ctrlTouchscreentouch8touchId(){} // RVA: 0x7FFAC95EEEE0
        public void Initialize_ctrlTouchscreentouch8position(){} // RVA: 0x7FFAC95EF200
        public void Initialize_ctrlTouchscreentouch8delta(){} // RVA: 0x7FFAC95EF530
        public void Initialize_ctrlTouchscreentouch8pressure(){} // RVA: 0x7FFAC95EF840
        public void Initialize_ctrlTouchscreentouch8radius(){} // RVA: 0x7FFAC95EFB40
        public void Initialize_ctrlTouchscreentouch8phase(){} // RVA: 0x7FFAC95EFE50
        public void Initialize_ctrlTouchscreentouch8press(){} // RVA: 0x7FFAC95F0160
        public void Initialize_ctrlTouchscreentouch8tapCount(){} // RVA: 0x7FFAC95F04C0
        public void Initialize_ctrlTouchscreentouch8displayIndex(){} // RVA: 0x7FFAC95F07C0
        public void Initialize_ctrlTouchscreentouch8indirectTouch(){} // RVA: 0x7FFAC95F0AC0
        public void Initialize_ctrlTouchscreentouch8tap(){} // RVA: 0x7FFAC95F0E20
        public void Initialize_ctrlTouchscreentouch8startTime(){} // RVA: 0x7FFAC95F1180
        public void Initialize_ctrlTouchscreentouch8startPosition(){} // RVA: 0x7FFAC95F1490
        public void Initialize_ctrlTouchscreentouch8positionx(){} // RVA: 0x7FFAC95F17B0
        public void Initialize_ctrlTouchscreentouch8positiony(){} // RVA: 0x7FFAC95F1AD0
        public void Initialize_ctrlTouchscreentouch8deltaup(){} // RVA: 0x7FFAC95F1DF0
        public void Initialize_ctrlTouchscreentouch8deltadown(){} // RVA: 0x7FFAC95F2120
        public void Initialize_ctrlTouchscreentouch8deltaleft(){} // RVA: 0x7FFAC95F2450
        public void Initialize_ctrlTouchscreentouch8deltaright(){} // RVA: 0x7FFAC95F2780
        public void Initialize_ctrlTouchscreentouch8deltax(){} // RVA: 0x7FFAC95F2AB0
        public void Initialize_ctrlTouchscreentouch8deltay(){} // RVA: 0x7FFAC95F2DB0
        public void Initialize_ctrlTouchscreentouch8radiusx(){} // RVA: 0x7FFAC95F30B0
        public void Initialize_ctrlTouchscreentouch8radiusy(){} // RVA: 0x7FFAC95F33B0
        public void Initialize_ctrlTouchscreentouch8startPositionx(){} // RVA: 0x7FFAC95F36B0
        public void Initialize_ctrlTouchscreentouch8startPositiony(){} // RVA: 0x7FFAC95F39B0
        public void Initialize_ctrlTouchscreentouch9touchId(){} // RVA: 0x7FFAC95F3CB0
        public void Initialize_ctrlTouchscreentouch9position(){} // RVA: 0x7FFAC95F3FD0
        public void Initialize_ctrlTouchscreentouch9delta(){} // RVA: 0x7FFAC95F4300
        public void Initialize_ctrlTouchscreentouch9pressure(){} // RVA: 0x7FFAC95F4610
        public void Initialize_ctrlTouchscreentouch9radius(){} // RVA: 0x7FFAC95F4910
        public void Initialize_ctrlTouchscreentouch9phase(){} // RVA: 0x7FFAC95F4C20
        public void Initialize_ctrlTouchscreentouch9press(){} // RVA: 0x7FFAC95F4F30
        public void Initialize_ctrlTouchscreentouch9tapCount(){} // RVA: 0x7FFAC95F5290
        public void Initialize_ctrlTouchscreentouch9displayIndex(){} // RVA: 0x7FFAC95F5590
        public void Initialize_ctrlTouchscreentouch9indirectTouch(){} // RVA: 0x7FFAC95F5890
        public void Initialize_ctrlTouchscreentouch9tap(){} // RVA: 0x7FFAC95F5BF0
        public void Initialize_ctrlTouchscreentouch9startTime(){} // RVA: 0x7FFAC95F5F50
        public void Initialize_ctrlTouchscreentouch9startPosition(){} // RVA: 0x7FFAC95F6260
        public void Initialize_ctrlTouchscreentouch9positionx(){} // RVA: 0x7FFAC95F6580
        public void Initialize_ctrlTouchscreentouch9positiony(){} // RVA: 0x7FFAC95F68A0
        public void Initialize_ctrlTouchscreentouch9deltaup(){} // RVA: 0x7FFAC95F6BC0
        public void Initialize_ctrlTouchscreentouch9deltadown(){} // RVA: 0x7FFAC95F6EF0
        public void Initialize_ctrlTouchscreentouch9deltaleft(){} // RVA: 0x7FFAC95F7220
        public void Initialize_ctrlTouchscreentouch9deltaright(){} // RVA: 0x7FFAC95F7550
        public void Initialize_ctrlTouchscreentouch9deltax(){} // RVA: 0x7FFAC95F7880
        public void Initialize_ctrlTouchscreentouch9deltay(){} // RVA: 0x7FFAC95F7B80
        public void Initialize_ctrlTouchscreentouch9radiusx(){} // RVA: 0x7FFAC95F7E80
        public void Initialize_ctrlTouchscreentouch9radiusy(){} // RVA: 0x7FFAC95F8180
        public void Initialize_ctrlTouchscreentouch9startPositionx(){} // RVA: 0x7FFAC95F8480
        public void Initialize_ctrlTouchscreentouch9startPositiony(){} // RVA: 0x7FFAC95F8780
    }

    public class Gamepad : InputDevice
    {
        public UnityEngine.InputSystem.Controls.ButtonControl buttonWest; // 0x190
        public UnityEngine.InputSystem.Controls.ButtonControl buttonNorth; // 0x198
        public UnityEngine.InputSystem.Controls.ButtonControl buttonSouth; // 0x1A0
        public UnityEngine.InputSystem.Controls.ButtonControl buttonEast; // 0x1A8
        public UnityEngine.InputSystem.Controls.ButtonControl leftStickButton; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl rightStickButton; // 0x1B8
        public UnityEngine.InputSystem.Controls.ButtonControl startButton; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl selectButton; // 0x1C8
        public UnityEngine.InputSystem.Controls.DpadControl dpad; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl leftShoulder; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl rightShoulder; // 0x1E0
        public UnityEngine.InputSystem.Controls.StickControl leftStick; // 0x1E8
        public UnityEngine.InputSystem.Controls.StickControl rightStick; // 0x1F0
        public UnityEngine.InputSystem.Controls.ButtonControl leftTrigger; // 0x1F8
        public UnityEngine.InputSystem.Controls.ButtonControl rightTrigger; // 0x200
        public UnityEngine.InputSystem.Gamepad aButton;
        public UnityEngine.InputSystem.Haptics.DualMotorRumble bButton; // 0x208
        public int xButton; // 0x8
        public UnityEngine.InputSystem.Gamepad[] yButton; // 0x10

        // ── Methods ──
        public void get_buttonWest(){} // RVA: 0x7FFAC3540F60
        public void set_buttonWest(){} // RVA: 0x7FFAC39AB1D0
        public void get_buttonNorth(){} // RVA: 0x7FFAC3541C80
        public void set_buttonNorth(){} // RVA: 0x7FFAC39C8ED0
        public void get_buttonSouth(){} // RVA: 0x7FFAC354E2E0
        public void set_buttonSouth(){} // RVA: 0x7FFAC39A8AF0
        public void get_buttonEast(){} // RVA: 0x7FFAC3548F80
        public void set_buttonEast(){} // RVA: 0x7FFAC39B4D10
        public void get_leftStickButton(){} // RVA: 0x7FFAC3549F30
        public void set_leftStickButton(){} // RVA: 0x7FFAC39A7790
        public void get_rightStickButton(){} // RVA: 0x7FFAC3544330
        public void set_rightStickButton(){} // RVA: 0x7FFAC39AC050
        public void get_startButton(){} // RVA: 0x7FFAC35422B0
        public void set_startButton(){} // RVA: 0x7FFAC39AD110
        public void get_selectButton(){} // RVA: 0x7FFAC39CCB10
        public void set_selectButton(){} // RVA: 0x7FFAC39CF3F0
        public void get_dpad(){} // RVA: 0x7FFAC39C1920
        public void set_dpad(){} // RVA: 0x7FFAC39A8050
        public void get_leftShoulder(){} // RVA: 0x7FFAC39C0A30
        public void set_leftShoulder(){} // RVA: 0x7FFAC39CF5C0
        public void get_rightShoulder(){} // RVA: 0x7FFAC33F8150
        public void set_rightShoulder(){} // RVA: 0x7FFAC39B1270
        public void get_leftStick(){} // RVA: 0x7FFAC39B1060
        public void set_leftStick(){} // RVA: 0x7FFAC39AC5A0
        public void get_rightStick(){} // RVA: 0x7FFAC3544EF0
        public void set_rightStick(){} // RVA: 0x7FFAC3541400
        public void get_leftTrigger(){} // RVA: 0x7FFAC3541460
        public void set_leftTrigger(){} // RVA: 0x7FFAC3544450
        public void get_rightTrigger(){} // RVA: 0x7FFAC3544790
        public void set_rightTrigger(){} // RVA: 0x7FFAC354D230
        public void get_aButton(){} // RVA: 0x7FFAC354E2E0
        public void get_bButton(){} // RVA: 0x7FFAC3548F80
        public void get_xButton(){} // RVA: 0x7FFAC3540F60
        public void get_yButton(){} // RVA: 0x7FFAC3541C80
        public void get_triangleButton(){} // RVA: 0x7FFAC3541C80
        public void get_squareButton(){} // RVA: 0x7FFAC3540F60
        public void get_circleButton(){} // RVA: 0x7FFAC3548F80
        public void get_crossButton(){} // RVA: 0x7FFAC354E2E0
        public void get_Item(){} // RVA: 0x7FFAC9590210
        public void get_current(){} // RVA: 0x7FFAC9590430
        public void set_current(){} // RVA: 0x7FFAC9590470
        public void get_all(){} // RVA: 0x7FFAC9590510
        public void FinishSetup(){} // RVA: 0x7FFAC95905D0
        public void MakeCurrent(){} // RVA: 0x7FFAC9590DD0
        public void OnAdded(){} // RVA: 0x7FFAC9590DE0
        public void OnRemoved(){} // RVA: 0x7FFAC9590E60
        public void PauseHaptics(){} // RVA: 0x7FFAC9590FF0
        public void ResumeHaptics(){} // RVA: 0x7FFAC9591010
        public void ResetHaptics(){} // RVA: 0x7FFAC95910D0
        public void SetMotorSpeeds(){} // RVA: 0x7FFAC9591180
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class GravitySensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.Vector3Control gravity; // 0x190
        public UnityEngine.InputSystem.GravitySensor current;

        // ── Methods ──
        public void get_gravity(){} // RVA: 0x7FFAC3540F60
        public void set_gravity(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC9606600
        public void set_current(){} // RVA: 0x7FFAC9606640
        public void FinishSetup(){} // RVA: 0x7FFAC96066E0
        public void MakeCurrent(){} // RVA: 0x7FFAC9606790
        public void OnRemoved(){} // RVA: 0x7FFAC96067A0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class Gyroscope : Sensor
    {
        public UnityEngine.InputSystem.Controls.Vector3Control angularVelocity; // 0x190
        public UnityEngine.InputSystem.Gyroscope current;

        // ── Methods ──
        public void get_angularVelocity(){} // RVA: 0x7FFAC3540F60
        public void set_angularVelocity(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC9606410
        public void set_current(){} // RVA: 0x7FFAC9606450
        public void MakeCurrent(){} // RVA: 0x7FFAC96064F0
        public void OnRemoved(){} // RVA: 0x7FFAC9606500
        public void FinishSetup(){} // RVA: 0x7FFAC9606550
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class HingeAngle : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl angle; // 0x190
        public UnityEngine.InputSystem.HingeAngle current;

        // ── Methods ──
        public void get_angle(){} // RVA: 0x7FFAC3540F60
        public void set_angle(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC9607960
        public void set_current(){} // RVA: 0x7FFAC96079A0
        public void MakeCurrent(){} // RVA: 0x7FFAC9607A40
        public void OnRemoved(){} // RVA: 0x7FFAC9607A50
        public void FinishSetup(){} // RVA: 0x7FFAC9607AA0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class HumiditySensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl relativeHumidity; // 0x190
        public UnityEngine.InputSystem.HumiditySensor current;

        // ── Methods ──
        public void get_relativeHumidity(){} // RVA: 0x7FFAC3540F60
        public void set_relativeHumidity(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC9607390
        public void set_current(){} // RVA: 0x7FFAC96073D0
        public void MakeCurrent(){} // RVA: 0x7FFAC9607470
        public void OnRemoved(){} // RVA: 0x7FFAC9607480
        public void FinishSetup(){} // RVA: 0x7FFAC96074D0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class IInputActionCollection
    {
        public object bindingMask;
        public object devices;
        public object controlSchemes;

        // ── Methods ──
        public void get_bindingMask(){} // RVA: 0x7FFAC2E8DC40
        public void set_bindingMask(){}
        public void get_devices(){} // RVA: 0x7FFAC2E8DC40
        public void set_devices(){}
        public void get_controlSchemes(){}
        public void Contains(){} // RVA: 0x7FFAC2C59F60
        public void Enable(){} // RVA: 0x7FFAC2C70980
        public void Disable(){} // RVA: 0x7FFAC2C70980
    }

    public class IInputActionCollection2
    {
        public object bindings;

        // ── Methods ──
        public void get_bindings(){} // RVA: 0x7FFAC2C58E90
        public void FindAction(){} // RVA: 0x7FFAC2C696F0
        public void FindBinding(){}
    }

    public class IInputInteraction
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC2C70A40
        public void Reset(){} // RVA: 0x7FFAC2C70980
    }

    public class IInputInteraction`1
    {
    }

    public class InputAction : Object
    {
        public Unity.Profiling.ProfilerMarker name;
        public Unity.Profiling.ProfilerMarker type; // 0x8
        public string id; // 0x10
        public 0x6B146620 idDontGenerate; // 0x18
        public string expectedControlType; // 0x20
        public string processors; // 0x28
        public string interactions; // 0x30
        public string actionMap; // 0x38
        public UnityEngine.InputSystem.InputBinding[] bindingMask; // 0x40
        public 0x6B145498 bindings; // 0x48
        public System.Nullable`1<UnityEngine.InputSystem.InputBinding> controls; // 0x50
        public int phase; // 0xB0
        public int inProgress; // 0xB4
        public int enabled; // 0xB8
        public int triggered; // 0xBC
        public int activeControl; // 0xC0
        public UnityEngine.InputSystem.InputActionMap activeValueType; // 0xC8
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<CallbackContext>> wantsInitialStateCheck; // 0xD0
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<CallbackContext>> isSingletonAction; // 0x120
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<CallbackContext>> currentState; // 0x170

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F3C380
        public void get_type(){} // RVA: 0x7FFAC3157800
        public void get_id(){} // RVA: 0x7FFAC951AB10
        public void get_idDontGenerate(){} // RVA: 0x7FFAC951AB60
        public void get_expectedControlType(){} // RVA: 0x7FFAC2F4F0C0
        public void set_expectedControlType(){} // RVA: 0x7FFAC2F4F0D0
        public void get_processors(){} // RVA: 0x7FFAC31D95E0
        public void get_interactions(){} // RVA: 0x7FFAC31D0140
        public void get_actionMap(){} // RVA: 0x7FFAC951AC60
        public void get_bindingMask(){} // RVA: 0x7FFAC6B22550
        public void set_bindingMask(){} // RVA: 0x7FFAC951AC80
        public void get_bindings(){} // RVA: 0x7FFAC951AFE0
        public void get_controls(){} // RVA: 0x7FFAC951B0E0
        public void get_phase(){} // RVA: 0x7FFAC951B210
        public void get_inProgress(){} // RVA: 0x7FFAC951B270
        public void get_enabled(){} // RVA: 0x7FFAC951B2D0
        public void add_started(){} // RVA: 0x7FFAC951B330
        public void remove_started(){} // RVA: 0x7FFAC951B390
        public void add_canceled(){} // RVA: 0x7FFAC951B3F0
        public void remove_canceled(){} // RVA: 0x7FFAC951B450
        public void add_performed(){} // RVA: 0x7FFAC951B4B0
        public void remove_performed(){} // RVA: 0x7FFAC951B510
        public void get_triggered(){} // RVA: 0x7FFAC951B570
        public void get_activeControl(){} // RVA: 0x7FFAC951B610
        public void get_activeValueType(){} // RVA: 0x7FFAC951B690
        public void get_wantsInitialStateCheck(){} // RVA: 0x7FFAC951B700
        public void set_wantsInitialStateCheck(){} // RVA: 0x7FFAC951B720
        public void .ctor(){} // RVA: 0x7FFAC951B830 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC951BE00
        public void ToString(){} // RVA: 0x7FFAC951BE20
        public void Enable(){} // RVA: 0x7FFAC951C130
        public void Disable(){} // RVA: 0x7FFAC951C470
        public void Clone(){} // RVA: 0x7FFAC951C770
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC951CA20
        public void ReadValue(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueAsObject(){} // RVA: 0x7FFAC951CA30
        public void GetControlMagnitude(){} // RVA: 0x7FFAC951CAB0
        public void Reset(){} // RVA: 0x7FFAC951CB10
        public void IsPressed(){} // RVA: 0x7FFAC951CBB0
        public void IsInProgress(){} // RVA: 0x7FFAC951CC10
        public void ExpectedFrame(){} // RVA: 0x7FFAC951CC80
        public void WasPressedThisFrame(){} // RVA: 0x7FFAC951CD30
        public void WasPressedThisDynamicUpdate(){} // RVA: 0x7FFAC951CDD0
        public void WasReleasedThisFrame(){} // RVA: 0x7FFAC951CE40
        public void WasReleasedThisDynamicUpdate(){} // RVA: 0x7FFAC951CEE0
        public void WasPerformedThisFrame(){} // RVA: 0x7FFAC951B570
        public void WasPerformedThisDynamicUpdate(){} // RVA: 0x7FFAC951CF50
        public void WasCompletedThisFrame(){} // RVA: 0x7FFAC951CFC0
        public void WasCompletedThisDynamicUpdate(){} // RVA: 0x7FFAC951D060
        public void GetTimeoutCompletionPercentage(){} // RVA: 0x7FFAC951D0D0
        public void get_isSingletonAction(){} // RVA: 0x7FFAC951D210
        public void get_currentState(){} // RVA: 0x7FFAC951D230
        public void MakeSureIdIsInPlace(){} // RVA: 0x7FFAC951D2C0
        public void GenerateId(){} // RVA: 0x7FFAC951D2F0
        public void GetOrCreateActionMap(){} // RVA: 0x7FFAC951D3D0
        public void CreateInternalActionMapForSingletonAction(){} // RVA: 0x7FFAC951D410
        public void RequestInitialStateCheckOnEnabledAction(){} // RVA: 0x7FFAC951D650
        public void ActiveControlIsValid(){} // RVA: 0x7FFAC951D720
        public void FindEffectiveBindingMask(){} // RVA: 0x7FFAC951D820
        public void BindingIndexOnActionToBindingIndexOnMap(){} // RVA: 0x7FFAC951D950
        public void BindingIndexOnMapToBindingIndexOnAction(){} // RVA: 0x7FFAC951DB00
        public void .cctor(){} // RVA: 0x7FFAC951DC90
    }

    public class InputActionAsset : ScriptableObject
    {
        public string enabled;
        public string actionMaps;
        public UnityEngine.InputSystem.InputActionMap[] controlSchemes; // 0x18
        public UnityEngine.InputSystem.InputControlScheme[] bindings; // 0x20
        public bool bindingMask; // 0x28
        public UnityEngine.InputSystem.InputActionState devices; // 0x30
        public System.Nullable`1<UnityEngine.InputSystem.InputBinding> Item; // 0x38
        public int m_ParameterOverridesCount; // 0x98
        public ParameterOverride[] m_ParameterOverrides; // 0xA0
        public DeviceArray m_Devices; // 0xA8

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAC951E9E0
        public void get_actionMaps(){} // RVA: 0x7FFAC951EBB0
        public void get_controlSchemes(){} // RVA: 0x7FFAC951EC70
        public void get_bindings(){} // RVA: 0x7FFAC951ED30
        public void get_bindingMask(){} // RVA: 0x7FFAC951EDE0
        public void set_bindingMask(){} // RVA: 0x7FFAC951EE20
        public void get_devices(){} // RVA: 0x7FFAC951F040
        public void set_devices(){} // RVA: 0x7FFAC951F080
        public void get_Item(){} // RVA: 0x7FFAC951F100
        public void ToJson(){} // RVA: 0x7FFAC951F190
        public void LoadFromJson(){} // RVA: 0x7FFAC951F480
        public void FromJson(){} // RVA: 0x7FFAC951F640
        public void FindAction(){} // RVA: 0x7FFAC9520210 | overloaded x2
        public void FindBinding(){} // RVA: 0x7FFAC951FCA0
        public void FindActionMap(){} // RVA: 0x7FFAC9520100 | overloaded x2
        public void FindControlSchemeIndex(){} // RVA: 0x7FFAC9520390
        public void FindControlScheme(){} // RVA: 0x7FFAC9520530
        public void IsUsableWithDevice(){} // RVA: 0x7FFAC95206B0
        public void Enable(){} // RVA: 0x7FFAC9520810
        public void Disable(){} // RVA: 0x7FFAC9520A20
        public void Contains(){} // RVA: 0x7FFAC9520BF0
        public void GetEnumerator(){} // RVA: 0x7FFAC9520D70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC9520E10
        public void MarkAsDirty(){} // RVA: 0x7FFAC2F21310
        public void IsEmpty(){} // RVA: 0x7FFAC9520E20
        public void OnWantToChangeSetup(){} // RVA: 0x7FFAC9520EB0
        public void OnSetupChanged(){} // RVA: 0x7FFAC9520F20
        public void ReResolveIfNecessary(){} // RVA: 0x7FFAC9520FF0
        public void ResolveBindingsIfNecessary(){} // RVA: 0x7FFAC9521030
        public void OnDestroy(){} // RVA: 0x7FFAC95210D0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class InputActionMap : Object
    {
        public Unity.Profiling.ProfilerMarker name;
        public string asset; // 0x10
        public string id; // 0x18
        public UnityEngine.InputSystem.InputActionAsset idDontGenerate; // 0x20
        public UnityEngine.InputSystem.InputAction[] enabled; // 0x28
        public UnityEngine.InputSystem.InputBinding[] actions; // 0x30
        public UnityEngine.InputSystem.InputBinding[] bindings; // 0x38
        public UnityEngine.InputSystem.InputControl[] UnityEngine.InputSystem.IInputActionCollection2.bindings; // 0x40
        public int controlSchemes; // 0x48
        public UnityEngine.InputSystem.InputAction bindingMask; // 0x50
        public int devices; // 0x58
        public UnityEngine.InputSystem.InputActionState Item; // 0x60
        public System.Nullable`1<UnityEngine.InputSystem.InputBinding> needToResolveBindings; // 0x68
        public 0x6B145808 bindingResolutionNeedsFullReResolve; // 0xC8
        public int controlsForEachActionInitialized; // 0xCC
        public ParameterOverride[] bindingsForEachActionInitialized; // 0xD0
        public DeviceArray m_Devices; // 0xD8
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<CallbackContext>> m_ActionCallbacks; // 0xE8
        public System.Collections.Generic.Dictionary`2<string,int> m_ActionIndexByNameOrId; // 0x138
        public int s_DeferBindingResolution; // 0x8
        public bool s_NeedToResolveBindings; // 0xC

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F3C380
        public void get_asset(){} // RVA: 0x7FFAC2F4F0C0
        public void get_id(){} // RVA: 0x7FFAC9521A40
        public void get_idDontGenerate(){} // RVA: 0x7FFAC9521A90
        public void get_enabled(){} // RVA: 0x7FFAC8E96A00
        public void get_actions(){} // RVA: 0x7FFAC9521B90
        public void get_bindings(){} // RVA: 0x7FFAC9521C50
        public void UnityEngine.InputSystem.IInputActionCollection2.get_bindings(){} // RVA: 0x7FFAC9521D10
        public void get_controlSchemes(){} // RVA: 0x7FFAC9521D70
        public void get_bindingMask(){} // RVA: 0x7FFAC9521E80
        public void set_bindingMask(){} // RVA: 0x7FFAC9521EC0
        public void get_devices(){} // RVA: 0x7FFAC95220D0
        public void set_devices(){} // RVA: 0x7FFAC95221B0
        public void get_Item(){} // RVA: 0x7FFAC9522200
        public void add_actionTriggered(){} // RVA: 0x7FFAC9522310
        public void remove_actionTriggered(){} // RVA: 0x7FFAC9522370
        public void .ctor(){} // RVA: 0x7FFAC9522440 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC9522500
        public void FindActionIndex(){} // RVA: 0x7FFAC9522A60 | overloaded x2
        public void SetUpActionLookupTable(){} // RVA: 0x7FFAC9522810
        public void ClearActionLookupTable(){} // RVA: 0x7FFAC9522A10
        public void FindAction(){} // RVA: 0x7FFAC9522CA0 | overloaded x2
        public void IsUsableWithDevice(){} // RVA: 0x7FFAC9522DD0
        public void Enable(){} // RVA: 0x7FFAC9522ED0
        public void Disable(){} // RVA: 0x7FFAC9522F40
        public void Clone(){} // RVA: 0x7FFAC9522F70
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC9523540
        public void Contains(){} // RVA: 0x7FFAC9523550
        public void ToString(){} // RVA: 0x7FFAC9523580
        public void GetEnumerator(){} // RVA: 0x7FFAC95236E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC95236E0
        public void get_needToResolveBindings(){} // RVA: 0x7FFAC9523810
        public void set_needToResolveBindings(){} // RVA: 0x7FFAC9523820
        public void get_bindingResolutionNeedsFullReResolve(){} // RVA: 0x7FFAC9523840
        public void set_bindingResolutionNeedsFullReResolve(){} // RVA: 0x7FFAC9523850
        public void get_controlsForEachActionInitialized(){} // RVA: 0x7FFAC9523870
        public void set_controlsForEachActionInitialized(){} // RVA: 0x7FFAC9523880
        public void get_bindingsForEachActionInitialized(){} // RVA: 0x7FFAC95238A0
        public void set_bindingsForEachActionInitialized(){} // RVA: 0x7FFAC95238B0
        public void GetBindingsForSingleAction(){} // RVA: 0x7FFAC95238D0
        public void GetControlsForSingleAction(){} // RVA: 0x7FFAC95239B0
        public void SetUpPerActionControlAndBindingArrays(){} // RVA: 0x7FFAC9523A90
        public void OnWantToChangeSetup(){} // RVA: 0x7FFAC9524810
        public void OnSetupChanged(){} // RVA: 0x7FFAC9524B80
        public void OnBindingModified(){} // RVA: 0x7FFAC9524EF0
        public void ClearCachedActionData(){} // RVA: 0x7FFAC9524F20
        public void GenerateId(){} // RVA: 0x7FFAC9525040
        public void LazyResolveBindings(){} // RVA: 0x7FFAC9525120
        public void ResolveBindingsIfNecessary(){} // RVA: 0x7FFAC9525260
        public void ResolveBindings(){} // RVA: 0x7FFAC95252A0
        public void FindBinding(){} // RVA: 0x7FFAC9526470
        public void FindBindingRelativeToMap(){} // RVA: 0x7FFAC95267A0
        public void FromJson(){} // RVA: 0x7FFAC9526850
        public void ToJson(){} // RVA: 0x7FFAC9526AA0 | overloaded x2
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC9526C20
        public void .cctor(){} // RVA: 0x7FFAC9526DE0
    }

    public class InputActionProperty : ValueType
    {
        public bool action; // 0x10
        public UnityEngine.InputSystem.InputAction reference; // 0x18
        public UnityEngine.InputSystem.InputActionReference serializedAction; // 0x20

        // ── Methods ──
        public void get_action(){} // RVA: 0x7FFAC9538510
        public void get_reference(){} // RVA: 0x7FFAC9538610
        public void get_serializedAction(){} // RVA: 0x7FFAC4420220
        public void get_serializedReference(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC95386D0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC9538A40 | overloaded x4
        public void GetHashCode(){} // RVA: 0x7FFAC9538B20
        public void op_Equality(){} // RVA: 0x7FFAC9538C40
        public void op_Inequality(){} // RVA: 0x7FFAC9538C70
    }

    public class InputActionRebindingExtensions : Object
    {
        public DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper;

        // ── Methods ──
        public void GetParameterValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void ApplyParameterOverride(){} // RVA: 0x7FFAC952B9D0 | overloaded x8
        public void ExtractParameterOverride(){} // RVA: 0x7FFAC2E8DC40
        public void GetBindingIndex(){} // RVA: 0x7FFAC952CAE0 | overloaded x3
        public void GetBindingForControl(){} // RVA: 0x7FFAC952CC10
        public void GetBindingIndexForControl(){} // RVA: 0x7FFAC952CEF0
        public void GetBindingDisplayString(){} // RVA: 0x7FFAC952D7F0 | overloaded x4
        public void ApplyBindingOverride(){} // RVA: 0x7FFAC952EA70 | overloaded x6
        public void RemoveBindingOverride(){} // RVA: 0x7FFAC952EEE0 | overloaded x3
        public void RemoveAllBindingOverrides(){} // RVA: 0x7FFAC952F390 | overloaded x2
        public void ApplyBindingOverrides(){} // RVA: 0x7FFAC952F5A0
        public void RemoveBindingOverrides(){} // RVA: 0x7FFAC952F860
        public void ApplyBindingOverridesOnMatchingControls(){} // RVA: 0x7FFAC952FFB0 | overloaded x2
        public void SaveBindingOverridesAsJson(){} // RVA: 0x7FFAC9530500 | overloaded x2
        public void AddBindingOverrideJsonTo(){} // RVA: 0x7FFAC95309B0
        public void LoadBindingOverridesFromJson(){} // RVA: 0x7FFAC9530CE0 | overloaded x2
        public void LoadBindingOverridesFromJsonInternal(){} // RVA: 0x7FFAC9530E20
        public void PerformInteractiveRebinding(){} // RVA: 0x7FFAC9531530
        public void DeferBindingResolution(){} // RVA: 0x7FFAC9531B90
    }

    public class InputActionReference : ScriptableObject
    {
        public UnityEngine.InputSystem.InputActionAsset asset; // 0x18
        public string action; // 0x20
        public UnityEngine.InputSystem.InputAction m_Action; // 0x28

        // ── Methods ──
        public void get_asset(){} // RVA: 0x7FFAC2F247C0
        public void get_action(){} // RVA: 0x7FFAC9538CA0
        public void Set(){} // RVA: 0x7FFAC95391D0 | overloaded x2
        public void SetInternal(){} // RVA: 0x7FFAC9539520
        public void ToString(){} // RVA: 0x7FFAC9539900
        public void GetDisplayName(){} // RVA: 0x7FFAC9539B40
        public void ToDisplayName(){} // RVA: 0x7FFAC9539BC0
        public void op_Implicit(){} // RVA: 0x7FFAC9539C70
        public void Create(){} // RVA: 0x7FFAC9539C80
        public void ResetCachedAction(){} // RVA: 0x7FFAC9539D00
        public void ToInputAction(){} // RVA: 0x7FFAC9539EE0
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class InputActionSetupExtensions : Object
    {
        // ── Methods ──
        public void AddActionMap(){} // RVA: 0x7FFAC953A150 | overloaded x2
        public void RemoveActionMap(){} // RVA: 0x7FFAC953A790 | overloaded x2
        public void AddAction(){} // RVA: 0x7FFAC953A920
        public void RemoveAction(){} // RVA: 0x7FFAC953B570 | overloaded x2
        public void AddBinding(){} // RVA: 0x7FFAC953C470 | overloaded x7
        public void AddCompositeBinding(){} // RVA: 0x7FFAC953C5C0
        public void AddBindingInternal(){} // RVA: 0x7FFAC953C950
        public void ChangeBinding(){} // RVA: 0x7FFAC953D600 | overloaded x4
        public void ChangeBindingWithId(){} // RVA: 0x7FFAC953D190 | overloaded x2
        public void ChangeBindingWithGroup(){} // RVA: 0x7FFAC953D320
        public void ChangeBindingWithPath(){} // RVA: 0x7FFAC953D490
        public void ChangeCompositeBinding(){} // RVA: 0x7FFAC953D960
        public void Rename(){} // RVA: 0x7FFAC953DD50
        public void AddControlScheme(){} // RVA: 0x7FFAC953E4B0 | overloaded x2
        public void RemoveControlScheme(){} // RVA: 0x7FFAC953E7A0
        public void WithBindingGroup(){} // RVA: 0x7FFAC953EA10
        public void WithDevice(){} // RVA: 0x7FFAC953EB90
        public void WithRequiredDevice(){} // RVA: 0x7FFAC953EDB0
        public void WithOptionalDevice(){} // RVA: 0x7FFAC953EF10
        public void OrWithRequiredDevice(){} // RVA: 0x7FFAC953F070
        public void OrWithOptionalDevice(){} // RVA: 0x7FFAC953F1D0
    }

    public class InputActionState : Object
    {
        public int totalCompositeCount;
        public UnityEngine.InputSystem.InputActionMap[] totalMapCount; // 0x10
        public UnityEngine.InputSystem.InputControl[] totalActionCount; // 0x18
        public UnityEngine.InputSystem.IInputInteraction[] totalBindingCount; // 0x20
        public UnityEngine.InputSystem.InputProcessor[] totalInteractionCount; // 0x28
        public UnityEngine.InputSystem.InputBindingComposite[] totalControlCount; // 0x30
        public int mapIndices; // 0x38
        public UnmanagedMemory actionStates; // 0x40
        public bool bindingStates; // 0xC0
        public bool interactionStates; // 0xC1
        public bool controlIndexToBindingIndex; // 0xC2
        public UnityEngine.InputSystem.LowLevel.InputEventPtr controlGroupingAndComplexity; // 0xC8
        public System.Action controlMagnitudes; // 0xD0
        public System.Action enabledControls; // 0xD8
        public Unity.Profiling.ProfilerMarker isProcessingControlStateChange;
        public Unity.Profiling.ProfilerMarker k_InputActionResolveConflictMarker; // 0x8
        public Unity.Profiling.ProfilerMarker k_InputActionCallbackMarker; // 0x10
        public Unity.Profiling.ProfilerMarker k_InputOnActionChangeMarker; // 0x18
        public Unity.Profiling.ProfilerMarker k_InputOnDeviceChangeMarker; // 0x20
        public GlobalState s_GlobalState; // 0x28

        // ── Methods ──
        public void get_totalCompositeCount(){} // RVA: 0x7FFAC313CBA0
        public void get_totalMapCount(){} // RVA: 0x7FFAC2FC20C0
        public void get_totalActionCount(){} // RVA: 0x7FFAC3F2D3C0
        public void get_totalBindingCount(){} // RVA: 0x7FFAC38913D0
        public void get_totalInteractionCount(){} // RVA: 0x7FFAC30F10E0
        public void get_totalControlCount(){} // RVA: 0x7FFAC362EA40
        public void get_mapIndices(){} // RVA: 0x7FFAC2F8C0B0
        public void get_actionStates(){} // RVA: 0x7FFAC2FBF370
        public void get_bindingStates(){} // RVA: 0x7FFAC2F9CD50
        public void get_interactionStates(){} // RVA: 0x7FFAC2FE9590
        public void get_controlIndexToBindingIndex(){} // RVA: 0x7FFAC3543900
        public void get_controlGroupingAndComplexity(){} // RVA: 0x7FFAC354B1A0
        public void get_controlMagnitudes(){} // RVA: 0x7FFAC30E5600
        public void get_enabledControls(){} // RVA: 0x7FFAC2F60010
        public void get_isProcessingControlStateChange(){} // RVA: 0x7FFAC906B7C0
        public void Initialize(){} // RVA: 0x7FFAC9542740
        public void ComputeControlGroupingIfNecessary(){} // RVA: 0x7FFAC9542860
        public void ClaimDataFrom(){} // RVA: 0x7FFAC9542A60
        public void Finalize(){} // RVA: 0x7FFAC9542CB0
        public void Dispose(){} // RVA: 0x7FFAC9542D20
        public void Destroy(){} // RVA: 0x7FFAC9542D30
        public void Clone(){} // RVA: 0x7FFAC95430A0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFAC95433D0
        public void IsUsingDevice(){} // RVA: 0x7FFAC95433E0
        public void CanUseDevice(){} // RVA: 0x7FFAC9543570
        public void HasEnabledActions(){} // RVA: 0x7FFAC9543840
        public void FinishBindingCompositeSetups(){} // RVA: 0x7FFAC95438A0
        public void PrepareForBindingReResolution(){} // RVA: 0x7FFAC95439E0
        public void FinishBindingResolution(){} // RVA: 0x7FFAC9543F10
        public void RestoreActionStatesAfterReResolvingBindings(){} // RVA: 0x7FFAC9544110
        public void IsActiveControl(){} // RVA: 0x7FFAC9544A00
        public void FindControlIndexOnBinding(){} // RVA: 0x7FFAC9544AC0
        public void ResetActionStatesDrivenBy(){} // RVA: 0x7FFAC9544B30
        public void IsActionBoundToControlFromDevice(){} // RVA: 0x7FFAC9544CA0
        public void ResetActionState(){} // RVA: 0x7FFAC9544DB0
        public void FetchActionState(){} // RVA: 0x7FFAC9545000
        public void FetchMapIndices(){} // RVA: 0x7FFAC9545030
        public void EnableAllActions(){} // RVA: 0x7FFAC9545080
        public void EnableControls(){} // RVA: 0x7FFAC9545A00 | overloaded x3
        public void EnableSingleAction(){} // RVA: 0x7FFAC9545250
        public void DisableAllActions(){} // RVA: 0x7FFAC954BC70 | overloaded x2
        public void DisableControls(){} // RVA: 0x7FFAC9545BE0 | overloaded x3
        public void DisableSingleAction(){} // RVA: 0x7FFAC9545760
        public void SetInitialStateCheckPending(){} // RVA: 0x7FFAC9545E70 | overloaded x2
        public void IsControlEnabled(){} // RVA: 0x7FFAC9545EB0
        public void SetControlEnabled(){} // RVA: 0x7FFAC9545EF0
        public void HookOnBeforeUpdate(){} // RVA: 0x7FFAC9545F30
        public void UnhookOnBeforeUpdate(){} // RVA: 0x7FFAC95460B0
        public void OnBeforeInitialUpdate(){} // RVA: 0x7FFAC9546180
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFAC9546540
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFAC9546590
        public void ToCombinedMapAndControlAndBindingIndex(){} // RVA: 0x7FFAC95465E0
        public void SplitUpMapAndControlAndBindingIndex(){} // RVA: 0x7FFAC9546620
        public void GetComplexityFromMonitorIndex(){} // RVA: 0x7FFAC9546650
        public void ProcessControlStateChange(){} // RVA: 0x7FFAC9546660
        public void ProcessButtonState(){} // RVA: 0x7FFAC9546E10
        public void ShouldIgnoreInputOnCompositeBinding(){} // RVA: 0x7FFAC9547060
        public void IsConflictingInput(){} // RVA: 0x7FFAC9547080
        public void GetActionBindingStartIndexAndCount(){} // RVA: 0x7FFAC9547590
        public void ProcessDefaultInteraction(){} // RVA: 0x7FFAC95475C0
        public void ProcessInteractions(){} // RVA: 0x7FFAC9547980
        public void ProcessTimeout(){} // RVA: 0x7FFAC9547C10
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x7FFAC9547FF0
        public void StartTimeout(){} // RVA: 0x7FFAC9548030
        public void StopTimeout(){} // RVA: 0x7FFAC95481E0
        public void ChangePhaseOfInteraction(){} // RVA: 0x7FFAC95482C0
        public void ChangePhaseOfAction(){} // RVA: 0x7FFAC9548870
        public void ChangePhaseOfActionInternal(){} // RVA: 0x7FFAC9548AE0
        public void CallActionListeners(){} // RVA: 0x7FFAC9548E20
        public void GetActionOrNoneString(){} // RVA: 0x7FFAC9549140
        public void GetActionOrNull(){} // RVA: 0x7FFAC9549240 | overloaded x2
        public void GetControl(){} // RVA: 0x7FFAC95492E0
        public void GetInteractionOrNull(){} // RVA: 0x7FFAC9549330
        public void GetBindingIndexInMap(){} // RVA: 0x7FFAC9549370
        public void GetBindingIndexInState(){} // RVA: 0x7FFAC95493C0
        public void GetBindingState(){} // RVA: 0x7FFAC9549400
        public void GetBinding(){} // RVA: 0x7FFAC9549410
        public void GetActionMap(){} // RVA: 0x7FFAC9549490
        public void ResetInteractionStateAndCancelIfNecessary(){} // RVA: 0x7FFAC95494D0
        public void ResetInteractionState(){} // RVA: 0x7FFAC95495B0
        public void GetValueSizeInBytes(){} // RVA: 0x7FFAC9549680
        public void GetValueType(){} // RVA: 0x7FFAC9549740
        public void IsActuated(){} // RVA: 0x7FFAC9549800
        public void ReadValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ApplyProcessors(){} // RVA: 0x7FFAC2E8DC40
        public void EvaluateCompositePartMagnitude(){} // RVA: 0x7FFAC9549B40
        public void GetCompositePartPressTime(){} // RVA: 0x7FFAC9549C30
        public void ReadCompositePartValue(){} // RVA: 0x7FFAC9549CB0 | overloaded x2
        public void ReadCompositePartValueAsObject(){} // RVA: 0x7FFAC9549E00
        public void ReadValueAsObject(){} // RVA: 0x7FFAC9549F30
        public void ReadValueAsButton(){} // RVA: 0x7FFAC954A1B0
        public void SaveAndResetState(){} // RVA: 0x7FFAC954A320
        public void AddToGlobalList(){} // RVA: 0x7FFAC954A900
        public void RemoveMapFromGlobalList(){} // RVA: 0x7FFAC954A990
        public void CompactGlobalList(){} // RVA: 0x7FFAC954AB40
        public void NotifyListenersOfActionChange(){} // RVA: 0x7FFAC954AF60 | overloaded x2
        public void ResetGlobals(){} // RVA: 0x7FFAC954B090
        public void FindAllEnabledActions(){} // RVA: 0x7FFAC954B2C0
        public void OnDeviceChange(){} // RVA: 0x7FFAC954B5A0
        public void DeferredResolutionOfBindings(){} // RVA: 0x7FFAC954B940
        public void DestroyAllActionMapStates(){} // RVA: 0x7FFAC954BE00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC954C050
    }

    public class InputBinding : ValueType
    {
        public char name;
        public string id;
        public string path; // 0x10
        public string overridePath; // 0x18
        public string interactions; // 0x20
        public string overrideInteractions; // 0x28
        public string processors; // 0x30
        public string overrideProcessors; // 0x38
        public string groups; // 0x40
        public 0x6B146728 action; // 0x48
        public string isComposite; // 0x50
        public string isPartOfComposite; // 0x58
        public string hasOverrides; // 0x60

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC3AD9F60
        public void set_name(){} // RVA: 0x7FFAC38DFE40
        public void get_id(){} // RVA: 0x7FFAC954D800
        public void set_id(){} // RVA: 0x7FFAC954D900
        public void get_path(){} // RVA: 0x7FFAC2F3C380
        public void set_path(){} // RVA: 0x7FFAC2F22E30
        public void get_overridePath(){} // RVA: 0x7FFAC2F9E740
        public void set_overridePath(){} // RVA: 0x7FFAC2F49200
        public void get_interactions(){} // RVA: 0x7FFAC2F247C0
        public void set_interactions(){} // RVA: 0x7FFAC2F87E80
        public void get_overrideInteractions(){} // RVA: 0x7FFAC2F9C730
        public void set_overrideInteractions(){} // RVA: 0x7FFAC2F9C740
        public void get_processors(){} // RVA: 0x7FFAC2F4F0C0
        public void set_processors(){} // RVA: 0x7FFAC2F4F0D0
        public void get_overrideProcessors(){} // RVA: 0x7FFAC2FC20E0
        public void set_overrideProcessors(){} // RVA: 0x7FFAC30794D0
        public void get_groups(){} // RVA: 0x7FFAC2F4F130
        public void set_groups(){} // RVA: 0x7FFAC2F22E90
        public void get_action(){} // RVA: 0x7FFAC31D95E0
        public void set_action(){} // RVA: 0x7FFAC2F4F890
        public void get_isComposite(){} // RVA: 0x7FFAC954D9A0
        public void set_isComposite(){} // RVA: 0x7FFAC954D9B0
        public void get_isPartOfComposite(){} // RVA: 0x7FFAC954D9D0
        public void set_isPartOfComposite(){} // RVA: 0x7FFAC954D9E0
        public void get_hasOverrides(){} // RVA: 0x7FFAC954DA00
        public void .ctor(){} // RVA: 0x7FFAC954DA20
        public void GetNameOfComposite(){} // RVA: 0x7FFAC954DD50
        public void GenerateId(){} // RVA: 0x7FFAC954DDF0
        public void RemoveOverrides(){} // RVA: 0x7FFAC954DED0
        public void MaskByGroup(){} // RVA: 0x7FFAC954DFD0
        public void MaskByGroups(){} // RVA: 0x7FFAC954E050
        public void get_effectivePath(){} // RVA: 0x7FFAC954E280
        public void get_effectiveInteractions(){} // RVA: 0x7FFAC954E290
        public void get_effectiveProcessors(){} // RVA: 0x7FFAC954E2A0
        public void get_isEmpty(){} // RVA: 0x7FFAC954E2B0
        public void Equals(){} // RVA: 0x7FFAC954E6A0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC954E770
        public void op_Inequality(){} // RVA: 0x7FFAC954E7C0
        public void GetHashCode(){} // RVA: 0x7FFAC954E850
        public void ToString(){} // RVA: 0x7FFAC954E980
        public void ToDisplayString(){} // RVA: 0x7FFAC954EAE0 | overloaded x2
        public void TriggersAction(){} // RVA: 0x7FFAC954EFE0
        public void Matches(){} // RVA: 0x7FFAC954F120 | overloaded x2
    }

    public class InputBindingComposite : Object
    {
        public UnityEngine.InputSystem.Utilities.TypeTable valueType;

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFAC2C58E90
        public void get_valueSizeInBytes(){} // RVA: 0x7FFAC2C59960
        public void ReadValue(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueAsObject(){} // RVA: 0x7FFAC2C58F40
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC954F350
        public void FinishSetup(){} // RVA: 0x7FFAC2F21310
        public void CallFinishSetup(){} // RVA: 0x7FFAC93914C0
        public void GetValueType(){} // RVA: 0x7FFAC954F360
        public void GetExpectedControlLayoutName(){} // RVA: 0x7FFAC954F4A0
        public void GetPartNames(){} // RVA: 0x7FFAC954F640
        public void GetDisplayFormatString(){} // RVA: 0x7FFAC954F6F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class InputBindingCompositeContext : ValueType
    {
        public UnityEngine.InputSystem.InputActionState controls; // 0x10
        public int m_BindingIndex; // 0x18

        // ── Methods ──
        public void get_controls(){} // RVA: 0x7FFAC95758D0
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC9575980
        public void ReadValue(){} // RVA: 0x7FFAC9575B20 | overloaded x5
        public void ReadValueAsButton(){} // RVA: 0x7FFAC9575A80
        public void ReadValueAsObject(){} // RVA: 0x7FFAC9575C70
        public void GetPressTime(){} // RVA: 0x7FFAC9575DB0
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        public object valueType;
        public object valueSizeInBytes;

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFAC2C58E90
        public void get_valueSizeInBytes(){} // RVA: 0x7FFAC2C59960
        public void ReadValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ReadValueAsObject(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class InputBindingResolver : ValueType
    {
        public int totalMapCount; // 0x10
        public int totalActionCount; // 0x14
        public int totalBindingCount; // 0x18
        public UnityEngine.InputSystem.InputActionMap[] totalControlCount; // 0x20
        public UnityEngine.InputSystem.InputControl[] controls; // 0x28
        public UnmanagedMemory memory; // 0x30
        public UnityEngine.InputSystem.IInputInteraction[] interactions; // 0xB0
        public UnityEngine.InputSystem.InputProcessor[] processors; // 0xB8
        public UnityEngine.InputSystem.InputBindingComposite[] composites; // 0xC0
        public System.Nullable`1<UnityEngine.InputSystem.InputBinding> bindingMask; // 0xC8
        public bool m_IsControlOnlyResolve; // 0x128
        public System.Collections.Generic.List`1<UnityEngine.InputSystem.Utilities.NameAndParameters> m_Parameters; // 0x130

        // ── Methods ──
        public void get_totalMapCount(){} // RVA: 0x7FFAC32EC4C0
        public void get_totalActionCount(){} // RVA: 0x7FFAC3C891D0
        public void get_totalBindingCount(){} // RVA: 0x7FFAC3ADEDC0
        public void get_totalControlCount(){} // RVA: 0x7FFAC358A870
        public void Dispose(){} // RVA: 0x7FFAC9576140
        public void StartWithPreviousResolve(){} // RVA: 0x7FFAC9576150
        public void AddActionMap(){} // RVA: 0x7FFAC9576580
        public void InstantiateWithParameters(){} // RVA: 0x7FFAC2E8DC40
        public void InstantiateBindingComposite(){} // RVA: 0x7FFAC95781F0
        public void ApplyParameters(){} // RVA: 0x7FFAC9578580
        public void AssignCompositePartIndex(){} // RVA: 0x7FFAC9578A90
    }

    public class InputControl : Object
    {
        public UnityEngine.InputSystem.LowLevel.InputStateBlock name; // 0x10
        public UnityEngine.InputSystem.Utilities.InternedString displayName; // 0x20
        public string shortDisplayName; // 0x30
        public string path; // 0x38
        public string layout; // 0x40
        public string variants; // 0x48
        public string device; // 0x50
        public UnityEngine.InputSystem.Utilities.InternedString parent; // 0x58
        public UnityEngine.InputSystem.Utilities.InternedString children; // 0x68
        public UnityEngine.InputSystem.InputDevice usages; // 0x78
        public UnityEngine.InputSystem.InputControl aliases; // 0x80
        public int stateBlock; // 0x88
        public int noisy; // 0x8C
        public int synthetic; // 0x90
        public int Item; // 0x94
        public int valueType; // 0x98
        public int valueSizeInBytes; // 0x9C
        public 0x6B147120 magnitude; // 0xA0
        public bool currentStatePtr; // 0xA4
        public bool previousFrameStatePtr; // 0xA5
        public UnityEngine.InputSystem.Utilities.PrimitiveValue defaultStatePtr; // 0xA8
        public UnityEngine.InputSystem.Utilities.PrimitiveValue noiseMaskPtr; // 0xB8
        public UnityEngine.InputSystem.Utilities.PrimitiveValue stateOffsetRelativeToDeviceRoot; // 0xC8
        public UnityEngine.InputSystem.Utilities.FourCC optimizedControlDataType; // 0xD8

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC9583C00
        public void get_displayName(){} // RVA: 0x7FFAC9583C60
        public void set_displayName(){} // RVA: 0x7FFAC31D0C20
        public void get_shortDisplayName(){} // RVA: 0x7FFAC9583D00
        public void set_shortDisplayName(){} // RVA: 0x7FFAC2F9C740
        public void get_path(){} // RVA: 0x7FFAC9583D60
        public void get_layout(){} // RVA: 0x7FFAC9583EF0
        public void get_variants(){} // RVA: 0x7FFAC9583F50
        public void get_device(){} // RVA: 0x7FFAC30E5600
        public void get_parent(){} // RVA: 0x7FFAC32EF410
        public void get_children(){} // RVA: 0x7FFAC9583FB0
        public void get_usages(){} // RVA: 0x7FFAC9584070
        public void get_aliases(){} // RVA: 0x7FFAC9584130
        public void get_stateBlock(){} // RVA: 0x7FFAC4422E80
        public void get_noisy(){} // RVA: 0x7FFAC95841F0
        public void set_noisy(){} // RVA: 0x7FFAC9584200
        public void get_synthetic(){} // RVA: 0x7FFAC9584300
        public void set_synthetic(){} // RVA: 0x7FFAC9584310
        public void get_Item(){} // RVA: 0x7FFAC9584330
        public void get_valueType(){} // RVA: 0x7FFAC2C58E90
        public void get_valueSizeInBytes(){} // RVA: 0x7FFAC2C59960
        public void get_magnitude(){} // RVA: 0x7FFAC95843F0
        public void ToString(){} // RVA: 0x7FFAC9584470
        public void DebuggerDisplay(){} // RVA: 0x7FFAC9584520
        public void EvaluateMagnitude(){} // RVA: 0x7FFAC954F350 | overloaded x2
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueFromStateAsObject(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7FFAC2E8DC40
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7FFAC95846A0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7FFAC9584710
        public void CompareValue(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetChildControl(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetChildControl(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC5EDCB40
        public void FinishSetup(){} // RVA: 0x7FFAC2F21310
        public void RefreshConfigurationIfNeeded(){} // RVA: 0x7FFAC9584940
        public void RefreshConfiguration(){} // RVA: 0x7FFAC2F21310
        public void get_currentStatePtr(){} // RVA: 0x7FFAC9584980
        public void get_previousFrameStatePtr(){} // RVA: 0x7FFAC95849E0
        public void get_defaultStatePtr(){} // RVA: 0x7FFAC9584A40
        public void get_noiseMaskPtr(){} // RVA: 0x7FFAC9584A80
        public void get_stateOffsetRelativeToDeviceRoot(){} // RVA: 0x7FFAC9584AC0
        public void get_optimizedControlDataType(){} // RVA: 0x7FFAC47BB150
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAC34F9180
        public void ApplyParameterChanges(){} // RVA: 0x7FFAC9584B30
        public void SetOptimizedControlDataType(){} // RVA: 0x7FFAC9584C00
        public void SetOptimizedControlDataTypeRecursively(){} // RVA: 0x7FFAC9584CA0
        public void EnsureOptimizationTypeHasNotChanged(){} // RVA: 0x7FFAC9584E90
        public void get_isSetupFinished(){} // RVA: 0x7FFAC95852C0
        public void set_isSetupFinished(){} // RVA: 0x7FFAC95852D0
        public void get_isButton(){} // RVA: 0x7FFAC95852F0
        public void set_isButton(){} // RVA: 0x7FFAC9585300
        public void get_isConfigUpToDate(){} // RVA: 0x7FFAC9585320
        public void set_isConfigUpToDate(){} // RVA: 0x7FFAC9585330
        public void get_dontReset(){} // RVA: 0x7FFAC9585350
        public void set_dontReset(){} // RVA: 0x7FFAC9585360
        public void get_usesStateFromOtherControl(){} // RVA: 0x7FFAC9585380
        public void set_usesStateFromOtherControl(){} // RVA: 0x7FFAC9585390
        public void get_hasDefaultState(){} // RVA: 0x7FFAC95853B0
        public void CallFinishSetupRecursive(){} // RVA: 0x7FFAC95853C0
        public void MakeChildPath(){} // RVA: 0x7FFAC95854A0
        public void BakeOffsetIntoStateBlockRecursive(){} // RVA: 0x7FFAC9585550
        public void GetDeviceIndex(){} // RVA: 0x7FFAC9585640
        public void IsValueConsideredPressed(){} // RVA: 0x7FFAC95857B0
        public void AddProcessor(){} // RVA: 0x7FFAC2F21310
        public void MarkAsStale(){} // RVA: 0x7FFAC9585860
        public void MarkAsStaleRecursively(){} // RVA: 0x7FFAC9585870
    }

    public class InputControlExtensions : Object
    {
        // ── Methods ──
        public void FindInParentChain(){} // RVA: 0x7FFAC2E8DC40
        public void IsPressed(){} // RVA: 0x7FFAC9585A80
        public void IsActuated(){} // RVA: 0x7FFAC9585BD0
        public void ReadValueAsObject(){} // RVA: 0x7FFAC9585C70
        public void ReadValueIntoBuffer(){} // RVA: 0x7FFAC9585CF0
        public void ReadDefaultValueAsObject(){} // RVA: 0x7FFAC9585DF0
        public void ReadValueFromEvent(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ReadValueFromEventAsObject(){} // RVA: 0x7FFAC9585EA0
        public void ReadUnprocessedValueFromEvent(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void WriteValueFromObjectIntoEvent(){} // RVA: 0x7FFAC9585FD0
        public void WriteValueIntoState(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void WriteValueIntoEvent(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void CopyState(){} // RVA: 0x7FFAC2C70C80 | overloaded x2
        public void CheckStateIsAtDefault(){} // RVA: 0x7FFAC9586590 | overloaded x2
        public void CheckStateIsAtDefaultIgnoringNoise(){} // RVA: 0x7FFAC9586800 | overloaded x2
        public void CompareStateIgnoringNoise(){} // RVA: 0x7FFAC9586950
        public void CompareState(){} // RVA: 0x7FFAC9586C20 | overloaded x2
        public void HasValueChangeInState(){} // RVA: 0x7FFAC9586D10
        public void HasValueChangeInEvent(){} // RVA: 0x7FFAC9586DF0
        public void GetStatePtrFromStateEvent(){} // RVA: 0x7FFAC9586EF0
        public void GetStatePtrFromStateEventUnchecked(){} // RVA: 0x7FFAC9586FB0
        public void ResetToDefaultStateInEvent(){} // RVA: 0x7FFAC95872A0
        public void QueueValueChange(){} // RVA: 0x7FFAC2E8DC40
        public void AccumulateValueInEvent(){} // RVA: 0x7FFAC9587630 | overloaded x2
        public void FindControlsRecursive(){} // RVA: 0x7FFAC2C761F0
        public void BuildPath(){} // RVA: 0x7FFAC9587750
        public void EnumerateControls(){} // RVA: 0x7FFAC9587C70
        public void EnumerateChangedControls(){} // RVA: 0x7FFAC9587EF0
        public void HasButtonPress(){} // RVA: 0x7FFAC9587F40
        public void GetFirstButtonPressOrNull(){} // RVA: 0x7FFAC9587F60
        public void GetAllButtonPresses(){} // RVA: 0x7FFAC95881A0
        public void Setup(){} // RVA: 0x7FFAC9588360 | overloaded x2
    }

    public class InputControlList`1 : ValueType
    {
        public int Count;
        public Unity.Collections.NativeArray`1<ulong> Capacity;
        public 0x6B177E20 IsReadOnly;
        public ulong Item;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_Capacity(){} // RVA: 0x7FFAC2C59960
        public void set_Capacity(){} // RVA: 0x7FFAC2C70ED0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void Resize(){} // RVA: 0x7FFAC2C70ED0
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void AddSlice(){} // RVA: 0x7FFAC2E8DC40
        public void AddRange(){}
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SwapElements(){} // RVA: 0x7FFAC2C72E60
        public void Sort(){} // RVA: 0x7FFAC2E8DC40
        public void ToArray(){}
        public void AppendTo(){} // RVA: 0x7FFAC2C79B30
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void ToIndex(){} // RVA: 0x7FFAC2E8DC40
        public void FromIndex(){} // RVA: 0x7FFAC2E8DC40
    }

    public class InputControlPath : Object
    {
        public string Wildcard;
        public string DoubleWildcard;
        public char Separator;
        public char SeparatorReplacement;

        // ── Methods ──
        public void CleanSlashes(){} // RVA: 0x7FFAC958A8B0
        public void Combine(){} // RVA: 0x7FFAC958A8E0
        public void ToHumanReadableString(){} // RVA: 0x7FFAC958AA20 | overloaded x2
        public void TryGetDeviceUsages(){} // RVA: 0x7FFAC958B0A0
        public void TryGetDeviceLayout(){} // RVA: 0x7FFAC958B2E0
        public void TryGetControlLayout(){} // RVA: 0x7FFAC958B490
        public void FindControlLayoutRecursive(){} // RVA: 0x7FFAC958B980 | overloaded x2
        public void ControlLayoutMatchesPathComponent(){} // RVA: 0x7FFAC958BC30
        public void StringMatches(){} // RVA: 0x7FFAC958BE70
        public void TryFindControl(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void TryFindControls(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void TryFindChild(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Matches(){} // RVA: 0x7FFAC958C660
        public void MatchControlComponent(){} // RVA: 0x7FFAC958C810
        public void MatchesPrefix(){} // RVA: 0x7FFAC958CC50
        public void MatchesRecursive(){} // RVA: 0x7FFAC958CE10
        public void MatchControlsRecursive(){} // RVA: 0x7FFAC2E8DC40
        public void MatchByUsageAtDeviceRootRecursive(){} // RVA: 0x7FFAC2E8DC40
        public void MatchChildrenRecursive(){} // RVA: 0x7FFAC2E8DC40
        public void MatchPathComponent(){} // RVA: 0x7FFAC958CEA0
        public void PathComponentCanYieldMultipleMatches(){} // RVA: 0x7FFAC958D260
        public void Parse(){} // RVA: 0x7FFAC958D320
    }

    public class InputControlScheme : ValueType
    {
        public string name; // 0x10
        public string bindingGroup; // 0x18
        public DeviceRequirement[] deviceRequirements; // 0x20

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC3AD9F60
        public void get_bindingGroup(){} // RVA: 0x7FFAC4420220
        public void set_bindingGroup(){} // RVA: 0x7FFAC4420240
        public void get_deviceRequirements(){} // RVA: 0x7FFAC9578D10
        public void .ctor(){} // RVA: 0x7FFAC9578DD0
        public void SetNameAndBindingGroup(){} // RVA: 0x7FFAC9578FC0
        public void FindControlSchemeForDevices(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void FindControlSchemeForDevice(){} // RVA: 0x7FFAC2E8DC40
        public void SupportsDevice(){} // RVA: 0x7FFAC9579190
        public void PickDevicesFrom(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC95796F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9579790
        public void ToString(){} // RVA: 0x7FFAC9579840
        public void op_Equality(){} // RVA: 0x7FFAC9579A40
        public void op_Inequality(){} // RVA: 0x7FFAC9579A70
    }

    public class InputControl`1 : InputControl
    {
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.InputProcessor`1<T>> valueType;
        public T valueSizeInBytes;
        public T value;
        public bool unprocessedValue;

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFAC2C58E90
        public void get_valueSizeInBytes(){} // RVA: 0x7FFAC2C59960
        public void get_value(){} // RVA: 0x7FFAC2C58E90
        public void get_unprocessedValue(){} // RVA: 0x7FFAC2C58E90
        public void ReadValue(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7FFAC2E8DC40
        public void ReadDefaultValue(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueFromState(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7FFAC2E8DC40
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7FFAC2E8DC40
        public void ReadUnprocessedValue(){} // RVA: 0x7FFAC2E8DC40
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueFromStateAsObject(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7FFAC2E8DC40
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7FFAC2E8DC40
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7FFAC2E8DC40
        public void WriteValueIntoState(){} // RVA: 0x7FFAC2E8DC40
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7FFAC2E8DC40
        public void CompareValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ProcessValue(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void TryGetProcessor(){} // RVA: 0x7FFAC2E8DC40
        public void AddProcessor(){} // RVA: 0x7FFAC2C70A40
        public void FinishSetup(){} // RVA: 0x7FFAC2C70980
        public void get_processors(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class InputDevice : InputControl
    {
        public int description;
        public int enabled;
        public int canRunInBackground;
        public 0x6B1479B8 canDeviceRunInBackground; // 0xE0
        public int added; // 0xE4
        public int remote; // 0xE8
        public int native; // 0xEC
        public uint updateBeforeRender; // 0xF0
        public UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceId; // 0xF8
        public double lastUpdateTime; // 0x130
        public uint wasUpdatedThisFrame; // 0x138
        public UnityEngine.InputSystem.Utilities.InternedString[] allControls; // 0x140
        public UnityEngine.InputSystem.Utilities.InternedString[] valueType; // 0x148
        public UnityEngine.InputSystem.InputControl[] valueSizeInBytes; // 0x150
        public UnityEngine.InputSystem.InputControl[] all; // 0x158
        public System.Collections.Generic.HashSet`1<int> disabledInFrontend; // 0x160
        public System.Collections.Generic.List`1<UnityEngine.InputSystem.Controls.ButtonControl> disabledInRuntime; // 0x168
        public bool disabledWhileInBackground; // 0x170
        public uint[] hasControlsWithDefaultState; // 0x178
        public ControlBitRangeNode[] hasDontResetControls; // 0x180
        public ushort[] hasStateCallbacks; // 0x188
        public int hasEventMerger;
        public int hasEventPreProcessor;
        public int kStateSizeBits;

        // ── Methods ──
        public void get_description(){} // RVA: 0x7FFAC95911B0
        public void get_enabled(){} // RVA: 0x7FFAC95911F0
        public void get_canRunInBackground(){} // RVA: 0x7FFAC9591210
        public void get_canDeviceRunInBackground(){} // RVA: 0x7FFAC9591210
        public void get_added(){} // RVA: 0x7FFAC95912E0
        public void get_remote(){} // RVA: 0x7FFAC95912F0
        public void get_native(){} // RVA: 0x7FFAC9591300
        public void get_updateBeforeRender(){} // RVA: 0x7FFAC9591310
        public void get_deviceId(){} // RVA: 0x7FFAC47D5FD0
        public void get_lastUpdateTime(){} // RVA: 0x7FFAC9591320
        public void get_wasUpdatedThisFrame(){} // RVA: 0x7FFAC9591370
        public void get_allControls(){} // RVA: 0x7FFAC95913C0
        public void get_valueType(){} // RVA: 0x7FFAC9591490
        public void get_valueSizeInBytes(){} // RVA: 0x7FFAC9591540
        public void get_all(){} // RVA: 0x7FFAC95915D0
        public void .ctor(){} // RVA: 0x7FFAC9591680
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7FFAC95916F0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7FFAC9591730
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7FFAC9591880
        public void CompareValue(){} // RVA: 0x7FFAC9591A80
        public void NotifyConfigurationChanged(){} // RVA: 0x7FFAC9591BF0
        public void MakeCurrent(){} // RVA: 0x7FFAC2F21310
        public void OnAdded(){} // RVA: 0x7FFAC2F21310
        public void OnRemoved(){} // RVA: 0x7FFAC2F21310
        public void OnConfigurationChanged(){} // RVA: 0x7FFAC2F21310
        public void ExecuteCommand(){} // RVA: 0x7FFAC9591C80 | overloaded x2
        public void QueryEnabledStateFromRuntime(){} // RVA: 0x7FFAC9591D00
        public void get_disabledInFrontend(){} // RVA: 0x7FFAC9591DC0
        public void set_disabledInFrontend(){} // RVA: 0x7FFAC9591DD0
        public void get_disabledInRuntime(){} // RVA: 0x7FFAC9591DF0
        public void set_disabledInRuntime(){} // RVA: 0x7FFAC9591E00
        public void get_disabledWhileInBackground(){} // RVA: 0x7FFAC9591E30
        public void set_disabledWhileInBackground(){} // RVA: 0x7FFAC9591E40
        public void EncodeStateOffsetToControlMapEntry(){} // RVA: 0x7FFAC9591E70
        public void DecodeStateOffsetToControlMapEntry(){} // RVA: 0x7FFAC9591E80
        public void get_hasControlsWithDefaultState(){} // RVA: 0x7FFAC9591EA0
        public void set_hasControlsWithDefaultState(){} // RVA: 0x7FFAC9591EB0
        public void get_hasDontResetControls(){} // RVA: 0x7FFAC9591ED0
        public void set_hasDontResetControls(){} // RVA: 0x7FFAC9591EE0
        public void get_hasStateCallbacks(){} // RVA: 0x7FFAC9591F10
        public void set_hasStateCallbacks(){} // RVA: 0x7FFAC9591F20
        public void get_hasEventMerger(){} // RVA: 0x7FFAC9591F40
        public void set_hasEventMerger(){} // RVA: 0x7FFAC9591F50
        public void get_hasEventPreProcessor(){} // RVA: 0x7FFAC9591F80
        public void set_hasEventPreProcessor(){} // RVA: 0x7FFAC9591F90
        public void AddDeviceUsage(){} // RVA: 0x7FFAC9591FC0
        public void RemoveDeviceUsage(){} // RVA: 0x7FFAC9592080
        public void ClearDeviceUsages(){} // RVA: 0x7FFAC9592250
        public void RequestSync(){} // RVA: 0x7FFAC95922C0
        public void RequestReset(){} // RVA: 0x7FFAC9592340
        public void ExecuteEnableCommand(){} // RVA: 0x7FFAC95923C0
        public void ExecuteDisableCommand(){} // RVA: 0x7FFAC9592440
        public void NotifyAdded(){} // RVA: 0x7FFAC8D92640
        public void NotifyRemoved(){} // RVA: 0x7FFAC617D250
        public void Build(){} // RVA: 0x7FFAC2E8DC40
        public void WriteChangedControlStates(){} // RVA: 0x7FFAC95924B0
        public void WritePartialChangedControlStatesInternal(){} // RVA: 0x7FFAC9592630
        public void DumpControlBitRangeNode(){} // RVA: 0x7FFAC9592A40
        public void DumpControlTree(){} // RVA: 0x7FFAC95930E0 | overloaded x2
        public void WriteChangedControlStatesInternal(){} // RVA: 0x7FFAC95931C0
        public void HasDataChangedInRange(){} // RVA: 0x7FFAC9593720
    }

    public class InputExtensions : Object
    {
        // ── Methods ──
        public void IsInProgress(){} // RVA: 0x7FFAC86F0D80
        public void IsEndedOrCanceled(){} // RVA: 0x7FFAC960A170
        public void IsActive(){} // RVA: 0x7FFAC960A180
        public void IsModifierKey(){} // RVA: 0x7FFAC960A1A0
        public void IsTextInputKey(){} // RVA: 0x7FFAC960A1B0
    }

    public class InputFeatureNames : Object
    {
        public string kRunPlayerUpdatesInEditMode;
        public string kDisableUnityRemoteSupport;
        public string kUseOptimizedControls;
        public string kUseReadValueCaching;
        public string kParanoidReadValueCachingChecks;
        public string kUseIMGUIEditorForAssets;
    }

    public class InputInteraction : Object
    {
        public UnityEngine.InputSystem.Utilities.TypeTable s_Interactions;

        // ── Methods ──
        public void GetValueType(){} // RVA: 0x7FFAC951A790
        public void GetDisplayName(){} // RVA: 0x7FFAC951A970 | overloaded x2
    }

    public class InputInteractionContext : ValueType
    {
        public UnityEngine.InputSystem.InputActionState action; // 0x10
        public 0x6B146E08 control; // 0x18
        public TriggerState phase; // 0x1C

        // ── Methods ──
        public void get_action(){} // RVA: 0x7FFAC957AED0
        public void get_control(){} // RVA: 0x7FFAC957AF00
        public void get_phase(){} // RVA: 0x7FFAC4AD9B10
        public void get_time(){} // RVA: 0x7FFAC957AF50
        public void get_startTime(){} // RVA: 0x7FFAC957AF60
        public void get_timerHasExpired(){} // RVA: 0x7FFAC957A160
        public void set_timerHasExpired(){} // RVA: 0x7FFAC957A170
        public void get_isWaiting(){} // RVA: 0x7FFAC957AF70
        public void get_isStarted(){} // RVA: 0x7FFAC957AF80
        public void ComputeMagnitude(){} // RVA: 0x7FFAC3000210
        public void ControlIsActuated(){} // RVA: 0x7FFAC957AF90
        public void Started(){} // RVA: 0x7FFAC957B030
        public void Performed(){} // RVA: 0x7FFAC957B080
        public void PerformedAndStayStarted(){} // RVA: 0x7FFAC957B0E0
        public void PerformedAndStayPerformed(){} // RVA: 0x7FFAC957B140
        public void Canceled(){} // RVA: 0x7FFAC957B190
        public void Waiting(){} // RVA: 0x7FFAC957B1E0
        public void SetTimeout(){} // RVA: 0x7FFAC957B230
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x7FFAC957B260
        public void ReadValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_mapIndex(){} // RVA: 0x7FFAC957B330
        public void get_controlIndex(){} // RVA: 0x7FFAC957B340
        public void get_bindingIndex(){} // RVA: 0x7FFAC87AD8B0
        public void get_interactionIndex(){} // RVA: 0x7FFAC957B360
    }

    public class InputManager : Object
    {
        public Unity.Profiling.ProfilerMarker devices;
        public Unity.Profiling.ProfilerMarker processors; // 0x8
        public Unity.Profiling.ProfilerMarker interactions; // 0x10
        public Unity.Profiling.ProfilerMarker composites; // 0x18
        public Unity.Profiling.ProfilerMarker metrics; // 0x20
        public Unity.Profiling.ProfilerMarker settings; // 0x28
        public Unity.Profiling.ProfilerMarker actions; // 0x30
        public Unity.Profiling.ProfilerMarker updateMask; // 0x38
        public Unity.Profiling.ProfilerMarker defaultUpdateType; // 0x40
        public Unity.Profiling.ProfilerMarker scrollDeltaBehavior; // 0x48
        public Unity.Profiling.ProfilerMarker pollingFrequency; // 0x50
        public Unity.Profiling.ProfilerMarker isProcessingEvents; // 0x58
        public Unity.Profiling.ProfilerMarker gameIsPlaying; // 0x60
        public int gameHasFocus; // 0x10
        public float gameShouldGetInputRegardlessOfFocus; // 0x14
        public Collection optimizedControlsFeatureEnabled; // 0x18
        public UnityEngine.InputSystem.Utilities.TypeTable readValueCachingFeatureEnabled; // 0x58
        public UnityEngine.InputSystem.Utilities.TypeTable paranoidReadValueCachingChecksEnabled; // 0x60
        public UnityEngine.InputSystem.Utilities.TypeTable m_Composites; // 0x68
        public int m_DevicesCount; // 0x70
        public UnityEngine.InputSystem.InputDevice[] m_Devices; // 0x78
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.InputSystem.InputDevice> m_DevicesById; // 0x80
        public int m_AvailableDeviceCount; // 0x88
        public AvailableDevice[] m_AvailableDevices; // 0x90
        public int m_DisconnectedDevicesCount; // 0x98
        public UnityEngine.InputSystem.InputDevice[] m_DisconnectedDevices; // 0xA0
        public 0x6B14EA20 m_UpdateMask; // 0xA8
        public 0x6B14EA20 m_CurrentUpdate; // 0xAC
        public UnityEngine.InputSystem.LowLevel.InputStateBuffers m_StateBuffers; // 0xB0
        public 0x6B1490C0 m_ScrollDeltaBehavior; // 0xE8
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`2<UnityEngine.InputSystem.InputDevice,0x6B147AC0>> m_DeviceChangeListeners; // 0xF0
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`2<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr>> m_DeviceStateChangeListeners; // 0x140
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<UnityEngine.InputSystem.Layouts.InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks; // 0x190
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<UnityEngine.InputSystem.LowLevel.InputDeviceCommandDelegate> m_DeviceCommandCallbacks; // 0x1E0
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`2<string,0x6B147490>> m_LayoutChangeListeners; // 0x230
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`2<UnityEngine.InputSystem.LowLevel.InputEventPtr,UnityEngine.InputSystem.InputDevice>> m_EventListeners; // 0x280
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action> m_BeforeUpdateListeners; // 0x2D0
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action> m_AfterUpdateListeners; // 0x320
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action> m_SettingsChangedListeners; // 0x370
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action> m_ActionsChangedListeners; // 0x3C0
        public bool m_NativeBeforeUpdateHooked; // 0x410
        public bool m_HaveDevicesWithStateCallbackReceivers; // 0x411
        public bool m_HasFocus; // 0x412
        public UnityEngine.InputSystem.LowLevel.InputEventStream m_InputEventStream; // 0x418
        public UnityEngine.InputSystem.LowLevel.InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate; // 0x490
        public int m_DeviceFindExecuteCommandDeviceId; // 0x498
        public UnityEngine.InputSystem.LowLevel.IInputRuntime m_Runtime; // 0x4A0
        public UnityEngine.InputSystem.LowLevel.InputMetrics m_Metrics; // 0x4A8
        public UnityEngine.InputSystem.InputSettings m_Settings; // 0x4E0
        public bool m_OptimizedControlsFeatureEnabled; // 0x4E8
        public bool m_ReadValueCachingFeatureEnabled; // 0x4E9
        public bool m_ParanoidReadValueCachingChecksEnabled; // 0x4EA
        public UnityEngine.InputSystem.InputActionAsset m_Actions; // 0x4F0
        public bool m_ShouldMakeCurrentlyUpdatingDeviceCurrent; // 0x4F8
        public StateChangeMonitorsForDevice[] m_StateChangeMonitors; // 0x500
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts; // 0x508

        // ── Methods ──
        public void get_devices(){} // RVA: 0x7FFAC960A1D0
        public void get_processors(){} // RVA: 0x7FFAC2FE9500
        public void get_interactions(){} // RVA: 0x7FFAC2FBF370
        public void get_composites(){} // RVA: 0x7FFAC2F9CD50
        public void get_metrics(){} // RVA: 0x7FFAC960A280
        public void get_settings(){} // RVA: 0x7FFAC39BB630
        public void set_settings(){} // RVA: 0x7FFAC960A4C0
        public void get_actions(){} // RVA: 0x7FFAC39C3D80
        public void set_actions(){} // RVA: 0x7FFAC960A6E0
        public void get_updateMask(){} // RVA: 0x7FFAC39055C0
        public void set_updateMask(){} // RVA: 0x7FFAC960A740
        public void get_defaultUpdateType(){} // RVA: 0x7FFAC960A760
        public void get_scrollDeltaBehavior(){} // RVA: 0x7FFAC47D5FE0
        public void set_scrollDeltaBehavior(){} // RVA: 0x7FFAC960A7A0
        public void get_pollingFrequency(){} // RVA: 0x7FFAC304B340
        public void set_pollingFrequency(){} // RVA: 0x7FFAC960A7B0
        public void add_onDeviceChange(){} // RVA: 0x7FFAC960A890
        public void remove_onDeviceChange(){} // RVA: 0x7FFAC960A8F0
        public void add_onDeviceStateChange(){} // RVA: 0x7FFAC960A950
        public void remove_onDeviceStateChange(){} // RVA: 0x7FFAC960A9B0
        public void add_onDeviceCommand(){} // RVA: 0x7FFAC960AA10
        public void remove_onDeviceCommand(){} // RVA: 0x7FFAC960AA70
        public void add_onFindControlLayoutForDevice(){} // RVA: 0x7FFAC960AAD0
        public void remove_onFindControlLayoutForDevice(){} // RVA: 0x7FFAC960AB30
        public void add_onLayoutChange(){} // RVA: 0x7FFAC960AB90
        public void remove_onLayoutChange(){} // RVA: 0x7FFAC960ABF0
        public void add_onEvent(){} // RVA: 0x7FFAC960AC50
        public void remove_onEvent(){} // RVA: 0x7FFAC960ACB0
        public void add_onBeforeUpdate(){} // RVA: 0x7FFAC960AD10
        public void remove_onBeforeUpdate(){} // RVA: 0x7FFAC960AD70
        public void add_onAfterUpdate(){} // RVA: 0x7FFAC960ADD0
        public void remove_onAfterUpdate(){} // RVA: 0x7FFAC960AE30
        public void add_onSettingsChange(){} // RVA: 0x7FFAC960AE90
        public void remove_onSettingsChange(){} // RVA: 0x7FFAC960AEF0
        public void add_onActionsChange(){} // RVA: 0x7FFAC960AF50
        public void remove_onActionsChange(){} // RVA: 0x7FFAC960AFB0
        public void get_isProcessingEvents(){} // RVA: 0x7FFAC960B010
        public void get_gameIsPlaying(){} // RVA: 0x7FFAC3006850
        public void get_gameHasFocus(){} // RVA: 0x7FFAC960B020
        public void get_gameShouldGetInputRegardlessOfFocus(){} // RVA: 0x7FFAC960B060
        public void RegisterControlLayout(){} // RVA: 0x7FFAC960B8E0 | overloaded x2
        public void RegisterControlLayoutBuilder(){} // RVA: 0x7FFAC960C120
        public void PerformLayoutPostRegistration(){} // RVA: 0x7FFAC960C3D0
        public void RegisterPrecompiledLayout(){} // RVA: 0x7FFAC2C70A40
        public void RecreateDevicesUsingLayout(){} // RVA: 0x7FFAC960CBF0
        public void IsControlOrChildUsingLayoutRecursive(){} // RVA: 0x7FFAC960CE30
        public void IsControlUsingLayout(){} // RVA: 0x7FFAC960CF30
        public void RegisterControlLayoutMatcher(){} // RVA: 0x7FFAC960D280 | overloaded x2
        public void RecreateDevicesUsingLayoutWithInferiorMatch(){} // RVA: 0x7FFAC960D4D0
        public void RecreateDevice(){} // RVA: 0x7FFAC960D810
        public void AddAvailableDevicesMatchingDescription(){} // RVA: 0x7FFAC960DA60
        public void RemoveControlLayout(){} // RVA: 0x7FFAC960DF10
        public void TryLoadControlLayout(){} // RVA: 0x7FFAC960E530 | overloaded x2
        public void TryFindMatchingControlLayout(){} // RVA: 0x7FFAC960E560
        public void FindOrRegisterDeviceLayoutForType(){} // RVA: 0x7FFAC960EB50
        public void IsDeviceLayoutMarkedAsSupportedInSettings(){} // RVA: 0x7FFAC960EC00
        public void ListControlLayouts(){} // RVA: 0x7FFAC960ED40
        public void GetControls(){} // RVA: 0x7FFAC2C637A0
        public void SetDeviceUsage(){} // RVA: 0x7FFAC960EE50
        public void AddDeviceUsage(){} // RVA: 0x7FFAC960F120
        public void RemoveDeviceUsage(){} // RVA: 0x7FFAC960F280
        public void NotifyUsageChanged(){} // RVA: 0x7FFAC960F3E0
        public void AddDevice(){} // RVA: 0x7FFAC9610830 | overloaded x7
        public void RemoveDevice(){} // RVA: 0x7FFAC9610980
        public void FlushDisconnectedDevices(){} // RVA: 0x7FFAC9611250
        public void ResetDevice(){} // RVA: 0x7FFAC96112B0
        public void TryGetDevice(){} // RVA: 0x7FFAC9611C70 | overloaded x2
        public void GetDevice(){} // RVA: 0x7FFAC9611BD0
        public void TryGetDeviceById(){} // RVA: 0x7FFAC9611D00
        public void GetUnsupportedDevices(){} // RVA: 0x7FFAC9611D80
        public void EnableOrDisableDevice(){} // RVA: 0x7FFAC9611F70
        public void QueueEvent(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void Update(){} // RVA: 0x7FFAC9612490 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC96124F0
        public void Destroy(){} // RVA: 0x7FFAC96126A0
        public void InitializeActions(){} // RVA: 0x7FFAC96128E0
        public void InitializeData(){} // RVA: 0x7FFAC96129D0
        public void RegisterCustomTypes(){} // RVA: 0x7FFAC96151D0 | overloaded x2
        public void InstallRuntime(){} // RVA: 0x7FFAC9615490
        public void InstallGlobals(){} // RVA: 0x7FFAC96158C0
        public void UninstallGlobals(){} // RVA: 0x7FFAC9615D70
        public void get_optimizedControlsFeatureEnabled(){} // RVA: 0x7FFAC9616000
        public void set_optimizedControlsFeatureEnabled(){} // RVA: 0x7FFAC9616010
        public void get_readValueCachingFeatureEnabled(){} // RVA: 0x7FFAC9616020
        public void set_readValueCachingFeatureEnabled(){} // RVA: 0x7FFAC9616030
        public void get_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x7FFAC9616040
        public void set_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x7FFAC9616050
        public void MakeDeviceNameUnique(){} // RVA: 0x7FFAC9616060
        public void ResetControlPathsRecursive(){} // RVA: 0x7FFAC9616370
        public void AssignUniqueDeviceId(){} // RVA: 0x7FFAC96164B0
        public void ReallocateStateBuffers(){} // RVA: 0x7FFAC9616620
        public void InitializeDefaultState(){} // RVA: 0x7FFAC9616900
        public void InitializeDeviceState(){} // RVA: 0x7FFAC9616AF0
        public void OnNativeDeviceDiscovered(){} // RVA: 0x7FFAC9616E50
        public void MakeEscapedJsonString(){} // RVA: 0x7FFAC96173B0
        public void TryMatchDisconnectedDevice(){} // RVA: 0x7FFAC9617710
        public void InstallBeforeUpdateHookIfNecessary(){} // RVA: 0x7FFAC9617A50
        public void RestoreDevicesAfterDomainReloadIfNecessary(){} // RVA: 0x7FFAC2F21310
        public void WarnAboutDevicesFailingToRecreateAfterDomainReload(){} // RVA: 0x7FFAC2F21310
        public void OnBeforeUpdate(){} // RVA: 0x7FFAC9617B10
        public void ApplySettings(){} // RVA: 0x7FFAC9617E30
        public void ApplyActions(){} // RVA: 0x7FFAC96187C0
        public void ExecuteGlobalCommand(){} // RVA: 0x7FFAC2C58F40
        public void AddAvailableDevicesThatAreNowRecognized(){} // RVA: 0x7FFAC9618850
        public void ShouldRunDeviceInBackground(){} // RVA: 0x7FFAC9618B60
        public void OnFocusChanged(){} // RVA: 0x7FFAC9618BA0
        public void ShouldRunUpdate(){} // RVA: 0x7FFAC9618DE0
        public void OnUpdate(){} // RVA: 0x7FFAC9618E00
        public void AreMaximumEventBytesPerUpdateExceeded(){} // RVA: 0x7FFAC961A130
        public void MakeStringWithEventsProcessedByDevice(){} // RVA: 0x7FFAC961A2A0
        public void ResetCurrentProcessedEventBytesForDevices(){} // RVA: 0x7FFAC961A480
        public void CheckAllDevicesOptimizedControlsHaveValidState(){} // RVA: 0x7FFAC961A550
        public void InvokeAfterUpdateCallback(){} // RVA: 0x7FFAC961A750
        public void DontMakeCurrentlyUpdatingDeviceCurrent(){} // RVA: 0x7FFAC961A7F0
        public void UpdateState(){} // RVA: 0x7FFAC961A910 | overloaded x2
        public void WriteStateChange(){} // RVA: 0x7FFAC961B080
        public void FlipBuffersForDeviceIfNecessary(){} // RVA: 0x7FFAC961B430
        public void AddStateChangeMonitor(){} // RVA: 0x7FFAC961B4E0
        public void RemoveStateChangeMonitors(){} // RVA: 0x7FFAC961B690
        public void RemoveStateChangeMonitor(){} // RVA: 0x7FFAC961B870
        public void AddStateChangeMonitorTimeout(){} // RVA: 0x7FFAC961BAC0
        public void RemoveStateChangeMonitorTimeout(){} // RVA: 0x7FFAC961BC50
        public void SortStateChangeMonitorsIfNecessary(){} // RVA: 0x7FFAC961BDE0
        public void SignalStateChangeMonitor(){} // RVA: 0x7FFAC961BE30
        public void FireStateChangeNotifications(){} // RVA: 0x7FFAC961C460 | overloaded x2
        public void ProcessStateChangeMonitors(){} // RVA: 0x7FFAC961C040
        public void ProcessStateChangeMonitorTimeouts(){} // RVA: 0x7FFAC961C860
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC961CBA0
        public void <TryFindMatchingControlLayout>b__94_0(){} // RVA: 0x7FFAC961D200
    }

    public class InputProcessor : Object
    {
        public UnityEngine.InputSystem.Utilities.TypeTable cachingPolicy;

        // ── Methods ──
        public void ProcessAsObject(){} // RVA: 0x7FFAC2C6A6F0
        public void Process(){} // RVA: 0x7FFAC2E8DC40
        public void GetValueTypeFromType(){} // RVA: 0x7FFAC9590120
        public void get_cachingPolicy(){} // RVA: 0x7FFAC34F9180
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ProcessAsObject(){} // RVA: 0x7FFAC2C6A6F0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class InputRemoting : Object
    {
        public 0x6B147F90 sending; // 0x10
        public UnityEngine.InputSystem.InputManager manager; // 0x18
        public Subscriber[] m_Subscribers; // 0x20
        public RemoteSender[] m_Senders; // 0x28

        // ── Methods ──
        public void get_sending(){} // RVA: 0x7FFAC9600820
        public void set_sending(){} // RVA: 0x7FFAC9600830
        public void .ctor(){} // RVA: 0x7FFAC9600850
        public void StartSending(){} // RVA: 0x7FFAC9600910
        public void StopSending(){} // RVA: 0x7FFAC9600B10
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x7FFAC9600CF0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0x7FFAC2F21310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0x7FFAC2F21310
        public void Subscribe(){} // RVA: 0x7FFAC9600F80
        public void SendInitialMessages(){} // RVA: 0x7FFAC9601100
        public void SendAllGeneratedLayouts(){} // RVA: 0x7FFAC9601120
        public void SendLayout(){} // RVA: 0x7FFAC96013A0
        public void SendAllDevices(){} // RVA: 0x7FFAC9601440
        public void SendDevice(){} // RVA: 0x7FFAC9601690
        public void SendEvent(){} // RVA: 0x7FFAC9601720
        public void SendDeviceChange(){} // RVA: 0x7FFAC9601780
        public void SendLayoutChange(){} // RVA: 0x7FFAC9601910
        public void Send(){} // RVA: 0x7FFAC9601A70
        public void FindOrCreateSenderRecord(){} // RVA: 0x7FFAC9601BB0
        public void BuildLayoutNamespace(){} // RVA: 0x7FFAC9601C80
        public void FindLocalDeviceId(){} // RVA: 0x7FFAC9601D50
        public void TryGetDeviceByRemoteId(){} // RVA: 0x7FFAC9601DC0
        public void get_manager(){} // RVA: 0x7FFAC2F247C0
        public void RemoveRemoteDevices(){} // RVA: 0x7FFAC9601DF0
        public void SerializeData(){} // RVA: 0x7FFAC2E8DC40
        public void DeserializeData(){} // RVA: 0x7FFAC2E8DC40
    }

    public class InputSettings : ScriptableObject
    {
        public string[] updateMode; // 0x18
        public 0x6B149068 scrollDeltaBehavior; // 0x20
        public 0x6B1490C0 compensateForScreenOrientation; // 0x24
        public int filterNoiseOnCurrent; // 0x28
        public int defaultDeadzoneMin; // 0x2C
        public bool defaultDeadzoneMax; // 0x30
        public 0x6B149118 defaultButtonPressPoint; // 0x34
        public 0x6B149170 buttonReleaseThreshold; // 0x38
        public 0x6B1491C8 defaultTapTime; // 0x3C
        public float defaultSlowTapTime; // 0x40
        public float defaultHoldTime; // 0x44
        public float tapRadius; // 0x48
        public float multiTapDelayTime; // 0x4C
        public float backgroundBehavior; // 0x50
        public float editorInputBehaviorInPlayMode; // 0x54
        public float inputActionPropertyDrawerMode; // 0x58
        public float maxEventBytesPerUpdate; // 0x5C
        public float maxQueuedEventsPerUpdate; // 0x60
        public bool supportedDevices; // 0x64
        public bool disableRedundantEventsMerging; // 0x65
        public System.Collections.Generic.HashSet`1<string> shortcutKeysConsumeInput; // 0x68
        public int s_OldUnsupportedFixedAndDynamicUpdateSetting;

        // ── Methods ──
        public void get_updateMode(){} // RVA: 0x7FFAC30DBBE0
        public void set_updateMode(){} // RVA: 0x7FFAC961FAF0
        public void get_scrollDeltaBehavior(){} // RVA: 0x7FFAC3921980
        public void set_scrollDeltaBehavior(){} // RVA: 0x7FFAC961FB00
        public void get_compensateForScreenOrientation(){} // RVA: 0x7FFAC2F47450
        public void set_compensateForScreenOrientation(){} // RVA: 0x7FFAC961FB10
        public void get_filterNoiseOnCurrent(){} // RVA: 0x7FFAC2F21320
        public void set_filterNoiseOnCurrent(){} // RVA: 0x7FFAC2F21310
        public void get_defaultDeadzoneMin(){} // RVA: 0x7FFAC30E80B0
        public void set_defaultDeadzoneMin(){} // RVA: 0x7FFAC961FB20
        public void get_defaultDeadzoneMax(){} // RVA: 0x7FFAC2F29970
        public void set_defaultDeadzoneMax(){} // RVA: 0x7FFAC961FB40
        public void get_defaultButtonPressPoint(){} // RVA: 0x7FFAC45C0DE0
        public void set_defaultButtonPressPoint(){} // RVA: 0x7FFAC961FB60
        public void get_buttonReleaseThreshold(){} // RVA: 0x7FFAC3735280
        public void set_buttonReleaseThreshold(){} // RVA: 0x7FFAC961FBA0
        public void get_defaultTapTime(){} // RVA: 0x7FFAC2F89460
        public void set_defaultTapTime(){} // RVA: 0x7FFAC961FBC0
        public void get_defaultSlowTapTime(){} // RVA: 0x7FFAC3391600
        public void set_defaultSlowTapTime(){} // RVA: 0x7FFAC961FBE0
        public void get_defaultHoldTime(){} // RVA: 0x7FFAC2F49FE0
        public void set_defaultHoldTime(){} // RVA: 0x7FFAC961FC00
        public void get_tapRadius(){} // RVA: 0x7FFAC2F4A000
        public void set_tapRadius(){} // RVA: 0x7FFAC961FC20
        public void get_multiTapDelayTime(){} // RVA: 0x7FFAC3031E10
        public void set_multiTapDelayTime(){} // RVA: 0x7FFAC961FC40
        public void get_backgroundBehavior(){} // RVA: 0x7FFAC3ADEDC0
        public void set_backgroundBehavior(){} // RVA: 0x7FFAC961FC60
        public void get_editorInputBehaviorInPlayMode(){} // RVA: 0x7FFAC358A870
        public void set_editorInputBehaviorInPlayMode(){} // RVA: 0x7FFAC961FC70
        public void get_inputActionPropertyDrawerMode(){} // RVA: 0x7FFAC33BD4A0
        public void set_inputActionPropertyDrawerMode(){} // RVA: 0x7FFAC961FC80
        public void get_maxEventBytesPerUpdate(){} // RVA: 0x7FFAC32EC4C0
        public void set_maxEventBytesPerUpdate(){} // RVA: 0x7FFAC961FC90
        public void get_maxQueuedEventsPerUpdate(){} // RVA: 0x7FFAC3C891D0
        public void set_maxQueuedEventsPerUpdate(){} // RVA: 0x7FFAC961FCA0
        public void get_supportedDevices(){} // RVA: 0x7FFAC961FCB0
        public void set_supportedDevices(){} // RVA: 0x7FFAC961FD70
        public void get_disableRedundantEventsMerging(){} // RVA: 0x7FFAC3F45FE0
        public void set_disableRedundantEventsMerging(){} // RVA: 0x7FFAC961FF20
        public void get_shortcutKeysConsumeInput(){} // RVA: 0x7FFAC8EA0370
        public void set_shortcutKeysConsumeInput(){} // RVA: 0x7FFAC961FF30
        public void SetInternalFeatureFlag(){} // RVA: 0x7FFAC961FF40
        public void IsFeatureEnabled(){} // RVA: 0x7FFAC9620100
        public void OnChange(){} // RVA: 0x7FFAC9620180
        public void CompareFloats(){} // RVA: 0x7FFAC9620300
        public void CompareSets(){} // RVA: 0x7FFAC2E8DC40
        public void CompareFeatureFlag(){} // RVA: 0x7FFAC9620320
        public void AreEqual(){} // RVA: 0x7FFAC9620410
        public void .ctor(){} // RVA: 0x7FFAC9620B50
    }

    public class InputSystem : Object
    {
        public string devices;
        public string disconnectedDevices;
        public Unity.Profiling.ProfilerMarker pollingFrequency;
        public float isProcessingEvents;
        public UnityEngine.InputSystem.InputManager onEvent; // 0x8
        public UnityEngine.InputSystem.InputRemoting onAnyButtonPress; // 0x10

        // ── Methods ──
        public void add_onLayoutChange(){} // RVA: 0x7FFAC957B380
        public void remove_onLayoutChange(){} // RVA: 0x7FFAC957B570
        public void RegisterLayout(){} // RVA: 0x7FFAC957B900 | overloaded x3
        public void RegisterLayoutOverride(){} // RVA: 0x7FFAC957BA10
        public void RegisterLayoutMatcher(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void RegisterLayoutBuilder(){} // RVA: 0x7FFAC957BB20
        public void RegisterPrecompiledLayout(){} // RVA: 0x7FFAC2C70A10
        public void RemoveLayout(){} // RVA: 0x7FFAC957BCF0
        public void TryFindMatchingLayout(){} // RVA: 0x7FFAC957BD60
        public void ListLayouts(){} // RVA: 0x7FFAC957BE30
        public void ListLayoutsBasedOn(){} // RVA: 0x7FFAC957BEA0
        public void LoadLayout(){} // RVA: 0x7FFAC2C58A90 | overloaded x2
        public void GetNameOfBaseLayout(){} // RVA: 0x7FFAC957C070
        public void IsFirstLayoutBasedOnSecond(){} // RVA: 0x7FFAC957C270
        public void RegisterProcessor(){} // RVA: 0x7FFAC2C70A10 | overloaded x2
        public void TryGetProcessor(){} // RVA: 0x7FFAC957C8C0
        public void ListProcessors(){} // RVA: 0x7FFAC957C9A0
        public void get_devices(){} // RVA: 0x7FFAC957CA20
        public void get_disconnectedDevices(){} // RVA: 0x7FFAC957CAA0
        public void add_onDeviceChange(){} // RVA: 0x7FFAC957CB90
        public void remove_onDeviceChange(){} // RVA: 0x7FFAC957CDE0
        public void add_onDeviceCommand(){} // RVA: 0x7FFAC957D030
        public void remove_onDeviceCommand(){} // RVA: 0x7FFAC957D280
        public void add_onFindLayoutForDevice(){} // RVA: 0x7FFAC957D4D0
        public void remove_onFindLayoutForDevice(){} // RVA: 0x7FFAC957D6D0
        public void get_pollingFrequency(){} // RVA: 0x7FFAC957D8C0
        public void set_pollingFrequency(){} // RVA: 0x7FFAC957D930
        public void AddDevice(){} // RVA: 0x7FFAC957DCC0 | overloaded x4
        public void RemoveDevice(){} // RVA: 0x7FFAC957DD80
        public void FlushDisconnectedDevices(){} // RVA: 0x7FFAC957DE00
        public void GetDevice(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void GetDeviceById(){} // RVA: 0x7FFAC957E1F0
        public void GetUnsupportedDevices(){} // RVA: 0x7FFAC957E2F0 | overloaded x2
        public void EnableDevice(){} // RVA: 0x7FFAC957E530
        public void DisableDevice(){} // RVA: 0x7FFAC957E5B0
        public void TrySyncDevice(){} // RVA: 0x7FFAC957E640
        public void ResetDevice(){} // RVA: 0x7FFAC957E710
        public void TryResetDevice(){} // RVA: 0x7FFAC957E7A0
        public void PauseHaptics(){} // RVA: 0x7FFAC957E810
        public void ResumeHaptics(){} // RVA: 0x7FFAC957E960
        public void ResetHaptics(){} // RVA: 0x7FFAC957EAB0
        public void SetDeviceUsage(){} // RVA: 0x7FFAC957ECF0 | overloaded x2
        public void AddDeviceUsage(){} // RVA: 0x7FFAC957EE40 | overloaded x2
        public void RemoveDeviceUsage(){} // RVA: 0x7FFAC957EF90 | overloaded x2
        public void FindControl(){} // RVA: 0x7FFAC957F020
        public void FindControls(){} // RVA: 0x7FFAC2C5E730 | overloaded x3
        public void get_isProcessingEvents(){} // RVA: 0x7FFAC957F360
        public void get_onEvent(){} // RVA: 0x7FFAC2F21320
        public void set_onEvent(){} // RVA: 0x7FFAC2F21310
        public void get_onAnyButtonPress(){} // RVA: 0x7FFAC957F3D0
        public void QueueEvent(){} // RVA: 0x7FFAC2C70A10 | overloaded x2
        public void QueueStateEvent(){} // RVA: 0x7FFAC2E8DC40
        public void QueueDeltaStateEvent(){} // RVA: 0x7FFAC2E8DC40
        public void QueueConfigChangeEvent(){} // RVA: 0x7FFAC957FAC0
        public void QueueTextEvent(){} // RVA: 0x7FFAC957FD00
        public void Update(){} // RVA: 0x7FFAC9580040 | overloaded x2
        public void add_onBeforeUpdate(){} // RVA: 0x7FFAC95801F0
        public void remove_onBeforeUpdate(){} // RVA: 0x7FFAC95803F0
        public void add_onAfterUpdate(){} // RVA: 0x7FFAC95805E0
        public void remove_onAfterUpdate(){} // RVA: 0x7FFAC95807D0
        public void get_settings(){} // RVA: 0x7FFAC95809C0
        public void set_settings(){} // RVA: 0x7FFAC9580A30
        public void add_onSettingsChange(){} // RVA: 0x7FFAC9580C70
        public void remove_onSettingsChange(){} // RVA: 0x7FFAC9580D20
        public void EnableActions(){} // RVA: 0x7FFAC9580DD0
        public void DisableActions(){} // RVA: 0x7FFAC9580EF0
        public void get_actions(){} // RVA: 0x7FFAC9581000
        public void set_actions(){} // RVA: 0x7FFAC9581070
        public void add_onActionsChange(){} // RVA: 0x7FFAC95812D0
        public void remove_onActionsChange(){} // RVA: 0x7FFAC9581380
        public void add_onActionChange(){} // RVA: 0x7FFAC9581430
        public void remove_onActionChange(){} // RVA: 0x7FFAC9581500
        public void RegisterInteraction(){} // RVA: 0x7FFAC2C70A10 | overloaded x2
        public void TryGetInteraction(){} // RVA: 0x7FFAC9581760
        public void ListInteractions(){} // RVA: 0x7FFAC9581840
        public void RegisterBindingComposite(){} // RVA: 0x7FFAC2C70A10 | overloaded x2
        public void TryGetBindingComposite(){} // RVA: 0x7FFAC9581A50
        public void DisableAllEnabledActions(){} // RVA: 0x7FFAC9581B30
        public void ListEnabledActions(){} // RVA: 0x7FFAC9581E20 | overloaded x2
        public void get_remoting(){} // RVA: 0x7FFAC9581EC0
        public void get_version(){} // RVA: 0x7FFAC9581F20
        public void get_runInBackground(){} // RVA: 0x7FFAC9582050
        public void set_runInBackground(){} // RVA: 0x7FFAC95820E0
        public void get_metrics(){} // RVA: 0x7FFAC9582180
        public void .cctor(){} // RVA: 0x7FFAC9582220
        public void RunInitializeInPlayer(){} // RVA: 0x7FFAC95822D0
        public void EnsureInitialized(){} // RVA: 0x7FFAC2F21310
        public void InitializeInPlayer(){} // RVA: 0x7FFAC9582350
        public void RunInitialUpdate(){} // RVA: 0x7FFAC95826D0
        public void PerformDefaultPluginInitialization(){} // RVA: 0x7FFAC95827B0
    }

    public class InputValue : Object
    {
        public System.Nullable`1<CallbackContext> isPressed; // 0x10

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void get_isPressed(){} // RVA: 0x7FFAC9625E50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Joystick : InputDevice
    {
        public UnityEngine.InputSystem.Controls.ButtonControl trigger; // 0x190
        public UnityEngine.InputSystem.Controls.StickControl stick; // 0x198
        public UnityEngine.InputSystem.Controls.AxisControl twist; // 0x1A0
        public UnityEngine.InputSystem.Controls.Vector2Control hatswitch; // 0x1A8
        public UnityEngine.InputSystem.Joystick current;
        public int all; // 0x8
        public UnityEngine.InputSystem.Joystick[] s_Joysticks; // 0x10

        // ── Methods ──
        public void get_trigger(){} // RVA: 0x7FFAC3540F60
        public void set_trigger(){} // RVA: 0x7FFAC39AB1D0
        public void get_stick(){} // RVA: 0x7FFAC3541C80
        public void set_stick(){} // RVA: 0x7FFAC39C8ED0
        public void get_twist(){} // RVA: 0x7FFAC354E2E0
        public void set_twist(){} // RVA: 0x7FFAC39A8AF0
        public void get_hatswitch(){} // RVA: 0x7FFAC3548F80
        public void set_hatswitch(){} // RVA: 0x7FFAC39B4D10
        public void get_current(){} // RVA: 0x7FFAC95944F0
        public void set_current(){} // RVA: 0x7FFAC9594530
        public void get_all(){} // RVA: 0x7FFAC95945D0
        public void FinishSetup(){} // RVA: 0x7FFAC9594690
        public void MakeCurrent(){} // RVA: 0x7FFAC9594910
        public void OnAdded(){} // RVA: 0x7FFAC9594920
        public void OnRemoved(){} // RVA: 0x7FFAC95949A0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class KeyEx : Object
    {
        public 0x6B147B70 IMESelected;
        public 0x6B147B70 RemappedIMESelected;
    }

    public class Keyboard : InputDevice
    {
        public int keyboardLayout;
        public int anyKey;
        public UnityEngine.InputSystem.Controls.AnyKeyControl spaceKey; // 0x190
        public UnityEngine.InputSystem.Controls.ButtonControl enterKey; // 0x198
        public UnityEngine.InputSystem.Controls.ButtonControl tabKey; // 0x1A0
        public UnityEngine.InputSystem.Controls.ButtonControl backquoteKey; // 0x1A8
        public UnityEngine.InputSystem.Controls.ButtonControl quoteKey; // 0x1B0
        public UnityEngine.InputSystem.Keyboard semicolonKey;
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Action`1<char>> commaKey; // 0x1B8
        public string periodKey; // 0x1D0
        public UnityEngine.InputSystem.Controls.KeyControl[] slashKey; // 0x1D8
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Action`1<UnityEngine.InputSystem.LowLevel.IMECompositionString>> backslashKey; // 0x1E0

        // ── Methods ──
        public void add_onTextInput(){} // RVA: 0x7FFAC9594B30
        public void remove_onTextInput(){} // RVA: 0x7FFAC9594C20
        public void add_onIMECompositionChange(){} // RVA: 0x7FFAC9594C80
        public void remove_onIMECompositionChange(){} // RVA: 0x7FFAC9594D70
        public void SetIMEEnabled(){} // RVA: 0x7FFAC9594DD0
        public void SetIMECursorPosition(){} // RVA: 0x7FFAC9594E50
        public void get_keyboardLayout(){} // RVA: 0x7FFAC9594EE0
        public void set_keyboardLayout(){} // RVA: 0x7FFAC39A8050
        public void get_anyKey(){} // RVA: 0x7FFAC3540F60
        public void set_anyKey(){} // RVA: 0x7FFAC39AB1D0
        public void get_spaceKey(){} // RVA: 0x7FFAC9594F30
        public void get_enterKey(){} // RVA: 0x7FFAC9594F40
        public void get_tabKey(){} // RVA: 0x7FFAC9594F50
        public void get_backquoteKey(){} // RVA: 0x7FFAC9594F60
        public void get_quoteKey(){} // RVA: 0x7FFAC9594F70
        public void get_semicolonKey(){} // RVA: 0x7FFAC9594F80
        public void get_commaKey(){} // RVA: 0x7FFAC9594F90
        public void get_periodKey(){} // RVA: 0x7FFAC9594FA0
        public void get_slashKey(){} // RVA: 0x7FFAC9594FB0
        public void get_backslashKey(){} // RVA: 0x7FFAC9594FC0
        public void get_leftBracketKey(){} // RVA: 0x7FFAC9594FD0
        public void get_rightBracketKey(){} // RVA: 0x7FFAC9594FE0
        public void get_minusKey(){} // RVA: 0x7FFAC9594FF0
        public void get_equalsKey(){} // RVA: 0x7FFAC9595000
        public void get_aKey(){} // RVA: 0x7FFAC9595010
        public void get_bKey(){} // RVA: 0x7FFAC9595020
        public void get_cKey(){} // RVA: 0x7FFAC9595030
        public void get_dKey(){} // RVA: 0x7FFAC9595040
        public void get_eKey(){} // RVA: 0x7FFAC9595050
        public void get_fKey(){} // RVA: 0x7FFAC9595060
        public void get_gKey(){} // RVA: 0x7FFAC9595070
        public void get_hKey(){} // RVA: 0x7FFAC9595080
        public void get_iKey(){} // RVA: 0x7FFAC9595090
        public void get_jKey(){} // RVA: 0x7FFAC95950A0
        public void get_kKey(){} // RVA: 0x7FFAC95950B0
        public void get_lKey(){} // RVA: 0x7FFAC95950C0
        public void get_mKey(){} // RVA: 0x7FFAC95950D0
        public void get_nKey(){} // RVA: 0x7FFAC95950E0
        public void get_oKey(){} // RVA: 0x7FFAC95950F0
        public void get_pKey(){} // RVA: 0x7FFAC9595100
        public void get_qKey(){} // RVA: 0x7FFAC9595110
        public void get_rKey(){} // RVA: 0x7FFAC9595120
        public void get_sKey(){} // RVA: 0x7FFAC9595130
        public void get_tKey(){} // RVA: 0x7FFAC9595140
        public void get_uKey(){} // RVA: 0x7FFAC9595150
        public void get_vKey(){} // RVA: 0x7FFAC9595160
        public void get_wKey(){} // RVA: 0x7FFAC9595170
        public void get_xKey(){} // RVA: 0x7FFAC9595180
        public void get_yKey(){} // RVA: 0x7FFAC9595190
        public void get_zKey(){} // RVA: 0x7FFAC95951A0
        public void get_digit1Key(){} // RVA: 0x7FFAC95951B0
        public void get_digit2Key(){} // RVA: 0x7FFAC95951C0
        public void get_digit3Key(){} // RVA: 0x7FFAC95951D0
        public void get_digit4Key(){} // RVA: 0x7FFAC95951E0
        public void get_digit5Key(){} // RVA: 0x7FFAC95951F0
        public void get_digit6Key(){} // RVA: 0x7FFAC9595200
        public void get_digit7Key(){} // RVA: 0x7FFAC9595210
        public void get_digit8Key(){} // RVA: 0x7FFAC9595220
        public void get_digit9Key(){} // RVA: 0x7FFAC9595230
        public void get_digit0Key(){} // RVA: 0x7FFAC9595240
        public void get_leftShiftKey(){} // RVA: 0x7FFAC9595250
        public void get_rightShiftKey(){} // RVA: 0x7FFAC9595260
        public void get_leftAltKey(){} // RVA: 0x7FFAC9595270
        public void get_rightAltKey(){} // RVA: 0x7FFAC9595280
        public void get_leftCtrlKey(){} // RVA: 0x7FFAC9595290
        public void get_rightCtrlKey(){} // RVA: 0x7FFAC95952A0
        public void get_leftMetaKey(){} // RVA: 0x7FFAC95952B0
        public void get_rightMetaKey(){} // RVA: 0x7FFAC95952C0
        public void get_leftWindowsKey(){} // RVA: 0x7FFAC95952B0
        public void get_rightWindowsKey(){} // RVA: 0x7FFAC95952C0
        public void get_leftAppleKey(){} // RVA: 0x7FFAC95952B0
        public void get_rightAppleKey(){} // RVA: 0x7FFAC95952C0
        public void get_leftCommandKey(){} // RVA: 0x7FFAC95952B0
        public void get_rightCommandKey(){} // RVA: 0x7FFAC95952C0
        public void get_contextMenuKey(){} // RVA: 0x7FFAC95952D0
        public void get_escapeKey(){} // RVA: 0x7FFAC95952E0
        public void get_leftArrowKey(){} // RVA: 0x7FFAC95952F0
        public void get_rightArrowKey(){} // RVA: 0x7FFAC9595300
        public void get_upArrowKey(){} // RVA: 0x7FFAC9595310
        public void get_downArrowKey(){} // RVA: 0x7FFAC9595320
        public void get_backspaceKey(){} // RVA: 0x7FFAC9595330
        public void get_pageDownKey(){} // RVA: 0x7FFAC9595340
        public void get_pageUpKey(){} // RVA: 0x7FFAC9595350
        public void get_homeKey(){} // RVA: 0x7FFAC9595360
        public void get_endKey(){} // RVA: 0x7FFAC9595370
        public void get_insertKey(){} // RVA: 0x7FFAC9595380
        public void get_deleteKey(){} // RVA: 0x7FFAC9595390
        public void get_capsLockKey(){} // RVA: 0x7FFAC95953A0
        public void get_scrollLockKey(){} // RVA: 0x7FFAC95953B0
        public void get_numLockKey(){} // RVA: 0x7FFAC95953C0
        public void get_printScreenKey(){} // RVA: 0x7FFAC95953D0
        public void get_pauseKey(){} // RVA: 0x7FFAC95953E0
        public void get_numpadEnterKey(){} // RVA: 0x7FFAC95953F0
        public void get_numpadDivideKey(){} // RVA: 0x7FFAC9595400
        public void get_numpadMultiplyKey(){} // RVA: 0x7FFAC9595410
        public void get_numpadMinusKey(){} // RVA: 0x7FFAC9595420
        public void get_numpadPlusKey(){} // RVA: 0x7FFAC9595430
        public void get_numpadPeriodKey(){} // RVA: 0x7FFAC9595440
        public void get_numpadEqualsKey(){} // RVA: 0x7FFAC9595450
        public void get_numpad0Key(){} // RVA: 0x7FFAC9595460
        public void get_numpad1Key(){} // RVA: 0x7FFAC9595470
        public void get_numpad2Key(){} // RVA: 0x7FFAC9595480
        public void get_numpad3Key(){} // RVA: 0x7FFAC9595490
        public void get_numpad4Key(){} // RVA: 0x7FFAC95954A0
        public void get_numpad5Key(){} // RVA: 0x7FFAC95954B0
        public void get_numpad6Key(){} // RVA: 0x7FFAC95954C0
        public void get_numpad7Key(){} // RVA: 0x7FFAC95954D0
        public void get_numpad8Key(){} // RVA: 0x7FFAC95954E0
        public void get_numpad9Key(){} // RVA: 0x7FFAC95954F0
        public void get_f1Key(){} // RVA: 0x7FFAC9595500
        public void get_f2Key(){} // RVA: 0x7FFAC9595510
        public void get_f3Key(){} // RVA: 0x7FFAC9595520
        public void get_f4Key(){} // RVA: 0x7FFAC9595530
        public void get_f5Key(){} // RVA: 0x7FFAC9595540
        public void get_f6Key(){} // RVA: 0x7FFAC9595550
        public void get_f7Key(){} // RVA: 0x7FFAC9595560
        public void get_f8Key(){} // RVA: 0x7FFAC9595570
        public void get_f9Key(){} // RVA: 0x7FFAC9595580
        public void get_f10Key(){} // RVA: 0x7FFAC9595590
        public void get_f11Key(){} // RVA: 0x7FFAC95955A0
        public void get_f12Key(){} // RVA: 0x7FFAC95955B0
        public void get_oem1Key(){} // RVA: 0x7FFAC95955C0
        public void get_oem2Key(){} // RVA: 0x7FFAC95955D0
        public void get_oem3Key(){} // RVA: 0x7FFAC95955E0
        public void get_oem4Key(){} // RVA: 0x7FFAC95955F0
        public void get_oem5Key(){} // RVA: 0x7FFAC9595600
        public void get_f13Key(){} // RVA: 0x7FFAC9595610
        public void get_f14Key(){} // RVA: 0x7FFAC9595620
        public void get_f15Key(){} // RVA: 0x7FFAC9595630
        public void get_f16Key(){} // RVA: 0x7FFAC9595640
        public void get_f17Key(){} // RVA: 0x7FFAC9595650
        public void get_f18Key(){} // RVA: 0x7FFAC9595660
        public void get_f19Key(){} // RVA: 0x7FFAC9595670
        public void get_f20Key(){} // RVA: 0x7FFAC9595680
        public void get_f21Key(){} // RVA: 0x7FFAC9595690
        public void get_f22Key(){} // RVA: 0x7FFAC95956A0
        public void get_f23Key(){} // RVA: 0x7FFAC95956B0
        public void get_f24Key(){} // RVA: 0x7FFAC95956C0
        public void get_shiftKey(){} // RVA: 0x7FFAC3541C80
        public void set_shiftKey(){} // RVA: 0x7FFAC39C8ED0
        public void get_ctrlKey(){} // RVA: 0x7FFAC354E2E0
        public void set_ctrlKey(){} // RVA: 0x7FFAC39A8AF0
        public void get_altKey(){} // RVA: 0x7FFAC3548F80
        public void set_altKey(){} // RVA: 0x7FFAC39B4D10
        public void get_imeSelected(){} // RVA: 0x7FFAC3549F30
        public void set_imeSelected(){} // RVA: 0x7FFAC39A7790
        public void get_Item(){} // RVA: 0x7FFAC95956D0
        public void get_allKeys(){} // RVA: 0x7FFAC9595770
        public void get_current(){} // RVA: 0x7FFAC9595840
        public void set_current(){} // RVA: 0x7FFAC9595880
        public void MakeCurrent(){} // RVA: 0x7FFAC9595920
        public void OnRemoved(){} // RVA: 0x7FFAC9595930
        public void FinishSetup(){} // RVA: 0x7FFAC9595980
        public void RefreshConfiguration(){} // RVA: 0x7FFAC9596FB0
        public void OnTextInput(){} // RVA: 0x7FFAC9597180
        public void FindKeyOnCurrentKeyboardLayout(){} // RVA: 0x7FFAC9597210
        public void OnIMECompositionChanged(){} // RVA: 0x7FFAC9597420
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7FFAC9597530
        public void get_keys(){} // RVA: 0x7FFAC39C0A30
        public void set_keys(){} // RVA: 0x7FFAC39CF5C0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class LightSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl lightLevel; // 0x190
        public UnityEngine.InputSystem.LightSensor current;

        // ── Methods ──
        public void get_lightLevel(){} // RVA: 0x7FFAC3540F60
        public void set_lightLevel(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC9606DC0
        public void set_current(){} // RVA: 0x7FFAC9606E00
        public void MakeCurrent(){} // RVA: 0x7FFAC9606EA0
        public void OnRemoved(){} // RVA: 0x7FFAC9606EB0
        public void FinishSetup(){} // RVA: 0x7FFAC9606F00
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class LinearAccelerationSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.Vector3Control acceleration; // 0x190
        public UnityEngine.InputSystem.LinearAccelerationSensor current;

        // ── Methods ──
        public void get_acceleration(){} // RVA: 0x7FFAC3540F60
        public void set_acceleration(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC96069E0
        public void set_current(){} // RVA: 0x7FFAC9606A20
        public void MakeCurrent(){} // RVA: 0x7FFAC9606AC0
        public void OnRemoved(){} // RVA: 0x7FFAC9606AD0
        public void FinishSetup(){} // RVA: 0x7FFAC9606B20
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class MagneticFieldSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.Vector3Control magneticField; // 0x190
        public UnityEngine.InputSystem.MagneticFieldSensor current;

        // ── Methods ──
        public void get_magneticField(){} // RVA: 0x7FFAC3540F60
        public void set_magneticField(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC9606BD0
        public void set_current(){} // RVA: 0x7FFAC9606C10
        public void MakeCurrent(){} // RVA: 0x7FFAC9606CB0
        public void OnRemoved(){} // RVA: 0x7FFAC9606CC0
        public void FinishSetup(){} // RVA: 0x7FFAC9606D10
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class Mouse : Pointer
    {
        public UnityEngine.InputSystem.Controls.DeltaControl scroll; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl leftButton; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl middleButton; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl rightButton; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl backButton; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl forwardButton; // 0x1E8
        public UnityEngine.InputSystem.Controls.IntegerControl clickCount; // 0x1F0
        public UnityEngine.InputSystem.Mouse current;
        public UnityEngine.InputSystem.Mouse s_PlatformMouseDevice; // 0x8

        // ── Methods ──
        public void get_scroll(){} // RVA: 0x7FFAC35422B0
        public void set_scroll(){} // RVA: 0x7FFAC39AD110
        public void get_leftButton(){} // RVA: 0x7FFAC39CCB10
        public void set_leftButton(){} // RVA: 0x7FFAC39CF3F0
        public void get_middleButton(){} // RVA: 0x7FFAC39C1920
        public void set_middleButton(){} // RVA: 0x7FFAC39A8050
        public void get_rightButton(){} // RVA: 0x7FFAC39C0A30
        public void set_rightButton(){} // RVA: 0x7FFAC39CF5C0
        public void get_backButton(){} // RVA: 0x7FFAC33F8150
        public void set_backButton(){} // RVA: 0x7FFAC39B1270
        public void get_forwardButton(){} // RVA: 0x7FFAC39B1060
        public void set_forwardButton(){} // RVA: 0x7FFAC39AC5A0
        public void get_clickCount(){} // RVA: 0x7FFAC3544EF0
        public void set_clickCount(){} // RVA: 0x7FFAC3541400
        public void get_current(){} // RVA: 0x7FFAC9597570
        public void set_current(){} // RVA: 0x7FFAC95975B0
        public void MakeCurrent(){} // RVA: 0x7FFAC9597650
        public void OnAdded(){} // RVA: 0x7FFAC9597670
        public void OnRemoved(){} // RVA: 0x7FFAC9597720
        public void WarpCursorPosition(){} // RVA: 0x7FFAC95977B0
        public void FinishSetup(){} // RVA: 0x7FFAC9597840
        public void OnNextUpdate(){} // RVA: 0x7FFAC9597CB0
        public void OnStateEvent(){} // RVA: 0x7FFAC9597D80
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFAC9597CB0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFAC9597E30
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class Pen : Pointer
    {
        public UnityEngine.InputSystem.Controls.ButtonControl tip; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl eraser; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl firstBarrelButton; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl secondBarrelButton; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl thirdBarrelButton; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl fourthBarrelButton; // 0x1E8
        public UnityEngine.InputSystem.Controls.ButtonControl inRange; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector2Control tilt; // 0x1F8
        public UnityEngine.InputSystem.Controls.AxisControl twist; // 0x200
        public UnityEngine.InputSystem.Pen current;

        // ── Methods ──
        public void get_tip(){} // RVA: 0x7FFAC35422B0
        public void set_tip(){} // RVA: 0x7FFAC39AD110
        public void get_eraser(){} // RVA: 0x7FFAC39CCB10
        public void set_eraser(){} // RVA: 0x7FFAC39CF3F0
        public void get_firstBarrelButton(){} // RVA: 0x7FFAC39C1920
        public void set_firstBarrelButton(){} // RVA: 0x7FFAC39A8050
        public void get_secondBarrelButton(){} // RVA: 0x7FFAC39C0A30
        public void set_secondBarrelButton(){} // RVA: 0x7FFAC39CF5C0
        public void get_thirdBarrelButton(){} // RVA: 0x7FFAC33F8150
        public void set_thirdBarrelButton(){} // RVA: 0x7FFAC39B1270
        public void get_fourthBarrelButton(){} // RVA: 0x7FFAC39B1060
        public void set_fourthBarrelButton(){} // RVA: 0x7FFAC39AC5A0
        public void get_inRange(){} // RVA: 0x7FFAC3544EF0
        public void set_inRange(){} // RVA: 0x7FFAC3541400
        public void get_tilt(){} // RVA: 0x7FFAC3541460
        public void set_tilt(){} // RVA: 0x7FFAC3544450
        public void get_twist(){} // RVA: 0x7FFAC3544790
        public void set_twist(){} // RVA: 0x7FFAC354D230
        public void get_current(){} // RVA: 0x7FFAC9597E40
        public void set_current(){} // RVA: 0x7FFAC9597E80
        public void get_Item(){} // RVA: 0x7FFAC9597F20
        public void MakeCurrent(){} // RVA: 0x7FFAC9598060
        public void OnRemoved(){} // RVA: 0x7FFAC9598080
        public void FinishSetup(){} // RVA: 0x7FFAC9598110
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class PlayerInput : MonoBehaviour
    {
        public string inputIsActive;
        public string active;
        public string playerIndex;
        public int splitScreenIndex; // 0x20
        public UnityEngine.InputSystem.InputActionAsset actions; // 0x28
        public 0x6B1497A0 currentControlScheme; // 0x30
        public UnityEngine.InputSystem.UI.InputSystemUIInputModule defaultControlScheme; // 0x38
        public DeviceLostEvent neverAutoSwitchControlSchemes; // 0x40
        public DeviceRegainedEvent currentActionMap; // 0x48
        public ControlsChangedEvent defaultActionMap; // 0x50
        public ActionEvent[] notificationBehavior; // 0x58
        public bool actionEvents; // 0x60
        public string deviceLostEvent; // 0x68
        public string deviceRegainedEvent; // 0x70
        public int controlsChangedEvent; // 0x78
        public UnityEngine.Camera camera; // 0x80
        public UnityEngine.InputSystem.InputValue uiInputModule; // 0x88
        public UnityEngine.InputSystem.InputActionMap user; // 0x90
        public int devices; // 0x98
        public bool hasMissingRequiredDevices; // 0x9C
        public bool all; // 0x9D
        public bool isSinglePlayer; // 0x9E
        public System.Collections.Generic.Dictionary`2<string,string> m_ActionMessageNames; // 0xA0
        public UnityEngine.InputSystem.Users.InputUser m_InputUser; // 0xA8
        public System.Action`1<CallbackContext> m_ActionTriggeredDelegate; // 0xB0
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<UnityEngine.InputSystem.PlayerInput>> m_DeviceLostCallbacks; // 0xB8
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<UnityEngine.InputSystem.PlayerInput>> m_DeviceRegainedCallbacks; // 0x108
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<UnityEngine.InputSystem.PlayerInput>> m_ControlsChangedCallbacks; // 0x158
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<CallbackContext>> m_ActionTriggeredCallbacks; // 0x1A8
        public System.Action`2<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate; // 0x1F8
        public System.Func`3<UnityEngine.InputSystem.InputDevice,UnityEngine.InputSystem.LowLevel.InputEventPtr,bool> m_PreFilterUnpairedDeviceUsedDelegate; // 0x200
        public bool m_OnUnpairedDeviceUsedHooked; // 0x208
        public System.Action`2<UnityEngine.InputSystem.InputDevice,0x6B147AC0> m_DeviceChangeDelegate; // 0x210
        public bool m_OnDeviceChangeHooked; // 0x218
        public int s_AllActivePlayersCount;
        public UnityEngine.InputSystem.PlayerInput[] s_AllActivePlayers; // 0x8
        public System.Action`3<UnityEngine.InputSystem.Users.InputUser,0x6B14A8D0,UnityEngine.InputSystem.InputDevice> s_UserChangeDelegate; // 0x10
        public int s_InitPairWithDevicesCount; // 0x18
        public UnityEngine.InputSystem.InputDevice[] s_InitPairWithDevices; // 0x20
        public int s_InitPlayerIndex; // 0x28
        public int s_InitSplitScreenIndex; // 0x2C
        public string s_InitControlScheme; // 0x30
        public bool s_DestroyIfDeviceSetupUnsuccessful; // 0x38

        // ── Methods ──
        public void get_inputIsActive(){} // RVA: 0x7FFAC8B10330
        public void get_active(){} // RVA: 0x7FFAC8B10330
        public void get_playerIndex(){} // RVA: 0x7FFAC489E530
        public void get_splitScreenIndex(){} // RVA: 0x7FFAC4596EF0
        public void get_actions(){} // RVA: 0x7FFAC9625F50
        public void set_actions(){} // RVA: 0x7FFAC9626020
        public void get_currentControlScheme(){} // RVA: 0x7FFAC9626370
        public void get_defaultControlScheme(){} // RVA: 0x7FFAC2F9CD50
        public void set_defaultControlScheme(){} // RVA: 0x7FFAC2F9CD60
        public void get_neverAutoSwitchControlSchemes(){} // RVA: 0x7FFAC2F4A020
        public void set_neverAutoSwitchControlSchemes(){} // RVA: 0x7FFAC9626440
        public void get_currentActionMap(){} // RVA: 0x7FFAC32EF640
        public void set_currentActionMap(){} // RVA: 0x7FFAC9626480
        public void get_defaultActionMap(){} // RVA: 0x7FFAC2FE9590
        public void set_defaultActionMap(){} // RVA: 0x7FFAC2FE95A0
        public void get_notificationBehavior(){} // RVA: 0x7FFAC2F7CCD0
        public void set_notificationBehavior(){} // RVA: 0x7FFAC9626720
        public void get_actionEvents(){} // RVA: 0x7FFAC9626770
        public void set_actionEvents(){} // RVA: 0x7FFAC9626840
        public void get_deviceLostEvent(){} // RVA: 0x7FFAC9626900
        public void get_deviceRegainedEvent(){} // RVA: 0x7FFAC96269D0
        public void get_controlsChangedEvent(){} // RVA: 0x7FFAC9626AA0
        public void add_onActionTriggered(){} // RVA: 0x7FFAC9626B70
        public void remove_onActionTriggered(){} // RVA: 0x7FFAC9626C10
        public void add_onDeviceLost(){} // RVA: 0x7FFAC9626CB0
        public void remove_onDeviceLost(){} // RVA: 0x7FFAC9626D50
        public void add_onDeviceRegained(){} // RVA: 0x7FFAC9626DF0
        public void remove_onDeviceRegained(){} // RVA: 0x7FFAC9626E90
        public void add_onControlsChanged(){} // RVA: 0x7FFAC9626F30
        public void remove_onControlsChanged(){} // RVA: 0x7FFAC9626FD0
        public void get_camera(){} // RVA: 0x7FFAC32EF410
        public void set_camera(){} // RVA: 0x7FFAC34D4AA0
        public void get_uiInputModule(){} // RVA: 0x7FFAC31D0140
        public void set_uiInputModule(){} // RVA: 0x7FFAC9627070
        public void get_user(){} // RVA: 0x7FFAC39055C0
        public void get_devices(){} // RVA: 0x7FFAC96274D0
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7FFAC9627580
        public void get_all(){} // RVA: 0x7FFAC9627680
        public void get_isSinglePlayer(){} // RVA: 0x7FFAC9627760
        public void GetDevice(){} // RVA: 0x7FFAC2E8DC40
        public void ActivateInput(){} // RVA: 0x7FFAC96278F0
        public void UpdateDelegates(){} // RVA: 0x7FFAC9627A20
        public void DeactivateInput(){} // RVA: 0x7FFAC9627CF0
        public void PassivateInput(){} // RVA: 0x7FFAC9627CF0
        public void SwitchCurrentControlScheme(){} // RVA: 0x7FFAC9627F80 | overloaded x2
        public void SwitchCurrentActionMap(){} // RVA: 0x7FFAC96280D0
        public void GetPlayerByIndex(){} // RVA: 0x7FFAC96282B0
        public void FindFirstPairedToDevice(){} // RVA: 0x7FFAC96283B0
        public void Instantiate(){} // RVA: 0x7FFAC9628850 | overloaded x2
        public void DoInstantiate(){} // RVA: 0x7FFAC9628AF0
        public void InitializeActions(){} // RVA: 0x7FFAC9629050
        public void CopyActionAssetAndApplyBindingOverrides(){} // RVA: 0x7FFAC9629600
        public void UninitializeActions(){} // RVA: 0x7FFAC9629980
        public void InstallOnActionTriggeredHook(){} // RVA: 0x7FFAC9629C40
        public void UninstallOnActionTriggeredHook(){} // RVA: 0x7FFAC9629F10
        public void OnActionTriggered(){} // RVA: 0x7FFAC962A130
        public void CacheMessageNames(){} // RVA: 0x7FFAC962A430
        public void ClearCaches(){} // RVA: 0x7FFAC962A960
        public void AssignUserAndDevices(){} // RVA: 0x7FFAC962A9C0
        public void HaveBindingForDevice(){} // RVA: 0x7FFAC962B740
        public void UnassignUserAndDevices(){} // RVA: 0x7FFAC962B8D0
        public void TryToActivateControlScheme(){} // RVA: 0x7FFAC962BA70
        public void AssignPlayerIndex(){} // RVA: 0x7FFAC962BEA0
        public void Awake(){} // RVA: 0x7FFAC962C140
        public void OnEnable(){} // RVA: 0x7FFAC962C220
        public void StartListeningForUnpairedDeviceActivity(){} // RVA: 0x7FFAC962C9E0
        public void StopListeningForUnpairedDeviceActivity(){} // RVA: 0x7FFAC962CCC0
        public void StartListeningForDeviceChanges(){} // RVA: 0x7FFAC962CE50
        public void StopListeningForDeviceChanges(){} // RVA: 0x7FFAC962CF70
        public void OnDisable(){} // RVA: 0x7FFAC962CFE0
        public void DebugLogAction(){} // RVA: 0x7FFAC962D530
        public void HandleDeviceLost(){} // RVA: 0x7FFAC962D590
        public void HandleDeviceRegained(){} // RVA: 0x7FFAC962D6B0
        public void HandleControlsChanged(){} // RVA: 0x7FFAC962D7D0
        public void OnUserChange(){} // RVA: 0x7FFAC962D8F0
        public void OnPreFilterUnpairedDeviceUsed(){} // RVA: 0x7FFAC962DAE0
        public void OnUnpairedDeviceUsed(){} // RVA: 0x7FFAC962DE80
        public void OnDeviceChange(){} // RVA: 0x7FFAC962E790
        public void SwitchControlSchemeInternal(){} // RVA: 0x7FFAC962E960
        public void .ctor(){} // RVA: 0x7FFAC962EF00
        public void .cctor(){} // RVA: 0x7FFAC962EF60
    }

    public class PlayerInputManager : MonoBehaviour
    {
        public string splitScreen;
        public string maintainAspectRatioInSplitScreen;
        public UnityEngine.InputSystem.PlayerInputManager fixedNumberOfSplitScreens;
        public 0x6B1497A0 splitScreenArea; // 0x20
        public int playerCount; // 0x24
        public bool maxPlayerCount; // 0x28
        public 0x6B149748 joiningEnabled; // 0x2C
        public PlayerJoinedEvent joinBehavior; // 0x30
        public PlayerLeftEvent joinAction; // 0x38
        public UnityEngine.InputSystem.InputActionProperty notificationBehavior; // 0x40
        public UnityEngine.GameObject playerJoinedEvent; // 0x58
        public bool playerLeftEvent; // 0x60
        public bool playerPrefab; // 0x61
        public int instance; // 0x64
        public UnityEngine.Rect messages; // 0x68
        public bool m_JoinActionDelegateHooked; // 0x78
        public bool m_UnpairedDeviceUsedDelegateHooked; // 0x79
        public System.Action`1<CallbackContext> m_JoinActionDelegate; // 0x80
        public System.Action`2<UnityEngine.InputSystem.InputControl,UnityEngine.InputSystem.LowLevel.InputEventPtr> m_UnpairedDeviceUsedDelegate; // 0x88
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<UnityEngine.InputSystem.PlayerInput>> m_PlayerJoinedCallbacks; // 0x90
        public UnityEngine.InputSystem.Utilities.CallbackArray`1<System.Action`1<UnityEngine.InputSystem.PlayerInput>> m_PlayerLeftCallbacks; // 0xE0

        // ── Methods ──
        public void get_splitScreen(){} // RVA: 0x7FFAC2F4A020
        public void set_splitScreen(){} // RVA: 0x7FFAC962F5E0
        public void get_maintainAspectRatioInSplitScreen(){} // RVA: 0x7FFAC3C11000
        public void get_fixedNumberOfSplitScreens(){} // RVA: 0x7FFAC3138CA0
        public void get_splitScreenArea(){} // RVA: 0x7FFAC5FD87B0
        public void get_playerCount(){} // RVA: 0x7FFAC962F920
        public void get_maxPlayerCount(){} // RVA: 0x7FFAC3921980
        public void get_joiningEnabled(){} // RVA: 0x7FFAC30F6BA0
        public void get_joinBehavior(){} // RVA: 0x7FFAC3C891D0
        public void set_joinBehavior(){} // RVA: 0x7FFAC962F980
        public void get_joinAction(){} // RVA: 0x7FFAC2F2AE10
        public void set_joinAction(){} // RVA: 0x7FFAC962F9D0
        public void get_notificationBehavior(){} // RVA: 0x7FFAC30DBBE0
        public void set_notificationBehavior(){} // RVA: 0x7FFAC35DB7A0
        public void get_playerJoinedEvent(){} // RVA: 0x7FFAC962FAC0
        public void get_playerLeftEvent(){} // RVA: 0x7FFAC962FB90
        public void add_onPlayerJoined(){} // RVA: 0x7FFAC962FC60
        public void remove_onPlayerJoined(){} // RVA: 0x7FFAC962FD00
        public void add_onPlayerLeft(){} // RVA: 0x7FFAC962FDA0
        public void remove_onPlayerLeft(){} // RVA: 0x7FFAC962FE40
        public void get_playerPrefab(){} // RVA: 0x7FFAC2FE9500
        public void set_playerPrefab(){} // RVA: 0x7FFAC2FE9510
        public void get_instance(){} // RVA: 0x7FFAC962FEE0
        public void set_instance(){} // RVA: 0x7FFAC962FF20
        public void EnableJoining(){} // RVA: 0x7FFAC962FFC0
        public void DisableJoining(){} // RVA: 0x7FFAC96301E0
        public void JoinPlayerFromUI(){} // RVA: 0x7FFAC96302E0
        public void JoinPlayerFromAction(){} // RVA: 0x7FFAC9630340
        public void JoinPlayerFromActionIfNotAlreadyJoined(){} // RVA: 0x7FFAC96303B0
        public void JoinPlayer(){} // RVA: 0x7FFAC96305D0 | overloaded x2
        public void get_messages(){} // RVA: 0x7FFAC9630690
        public void CheckIfPlayerCanJoin(){} // RVA: 0x7FFAC9630730
        public void OnUnpairedDeviceUsed(){} // RVA: 0x7FFAC9630AB0
        public void OnEnable(){} // RVA: 0x7FFAC9630B60
        public void OnDisable(){} // RVA: 0x7FFAC9631110
        public void UpdateSplitScreen(){} // RVA: 0x7FFAC9631270
        public void IsDeviceUsableWithPlayerActions(){} // RVA: 0x7FFAC96319B0
        public void ValidateInputActionAsset(){} // RVA: 0x7FFAC2F21310
        public void NotifyPlayerJoined(){} // RVA: 0x7FFAC9631F50
        public void NotifyPlayerLeft(){} // RVA: 0x7FFAC9632090
        public void .ctor(){} // RVA: 0x7FFAC96321D0
    }

    public class Pointer : InputDevice
    {
        public UnityEngine.InputSystem.Controls.Vector2Control position; // 0x190
        public UnityEngine.InputSystem.Controls.DeltaControl delta; // 0x198
        public UnityEngine.InputSystem.Controls.Vector2Control radius; // 0x1A0
        public UnityEngine.InputSystem.Controls.AxisControl pressure; // 0x1A8
        public UnityEngine.InputSystem.Controls.ButtonControl press; // 0x1B0
        public UnityEngine.InputSystem.Controls.IntegerControl displayIndex; // 0x1B8
        public UnityEngine.InputSystem.Pointer current;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAC3540F60
        public void set_position(){} // RVA: 0x7FFAC39AB1D0
        public void get_delta(){} // RVA: 0x7FFAC3541C80
        public void set_delta(){} // RVA: 0x7FFAC39C8ED0
        public void get_radius(){} // RVA: 0x7FFAC354E2E0
        public void set_radius(){} // RVA: 0x7FFAC39A8AF0
        public void get_pressure(){} // RVA: 0x7FFAC3548F80
        public void set_pressure(){} // RVA: 0x7FFAC39B4D10
        public void get_press(){} // RVA: 0x7FFAC3549F30
        public void set_press(){} // RVA: 0x7FFAC39A7790
        public void get_displayIndex(){} // RVA: 0x7FFAC3544330
        public void set_displayIndex(){} // RVA: 0x7FFAC39AC050
        public void get_current(){} // RVA: 0x7FFAC95986A0
        public void set_current(){} // RVA: 0x7FFAC95986E0
        public void MakeCurrent(){} // RVA: 0x7FFAC9598780
        public void OnRemoved(){} // RVA: 0x7FFAC9598790
        public void FinishSetup(){} // RVA: 0x7FFAC95987E0
        public void OnNextUpdate(){} // RVA: 0x7FFAC9598B70
        public void OnStateEvent(){} // RVA: 0x7FFAC9598C30
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFAC9598CE0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFAC9598CF0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class PressureSensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl atmosphericPressure; // 0x190
        public UnityEngine.InputSystem.PressureSensor current;

        // ── Methods ──
        public void get_atmosphericPressure(){} // RVA: 0x7FFAC3540F60
        public void set_atmosphericPressure(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC9606FB0
        public void set_current(){} // RVA: 0x7FFAC9606FF0
        public void MakeCurrent(){} // RVA: 0x7FFAC9607090
        public void OnRemoved(){} // RVA: 0x7FFAC96070A0
        public void FinishSetup(){} // RVA: 0x7FFAC96070F0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class ProximitySensor : Sensor
    {
        public UnityEngine.InputSystem.Controls.AxisControl distance; // 0x190
        public UnityEngine.InputSystem.ProximitySensor current;

        // ── Methods ──
        public void get_distance(){} // RVA: 0x7FFAC3540F60
        public void set_distance(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC96071A0
        public void set_current(){} // RVA: 0x7FFAC96071E0
        public void MakeCurrent(){} // RVA: 0x7FFAC9607280
        public void OnRemoved(){} // RVA: 0x7FFAC9607290
        public void FinishSetup(){} // RVA: 0x7FFAC96072E0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class RemoteInputPlayerConnection : ScriptableObject
    {
        public System.Guid kNewDeviceMsg;
        public System.Guid kNewLayoutMsg; // 0x10
        public System.Guid kNewEventsMsg; // 0x20
        public System.Guid kRemoveDeviceMsg; // 0x30
        public System.Guid kChangeUsagesMsg; // 0x40
        public System.Guid kStartSendingMsg; // 0x50
        public System.Guid kStopSendingMsg; // 0x60
        public UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection m_Connection; // 0x18
        public Subscriber[] m_Subscribers; // 0x20
        public int[] m_ConnectedIds; // 0x28

        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFAC9604A20
        public void Subscribe(){} // RVA: 0x7FFAC9604F40
        public void OnConnected(){} // RVA: 0x7FFAC96051E0
        public void OnDisconnected(){} // RVA: 0x7FFAC9605290
        public void OnNewDevice(){} // RVA: 0x7FFAC9605430
        public void OnNewLayout(){} // RVA: 0x7FFAC9605440
        public void OnNewEvents(){} // RVA: 0x7FFAC9605450
        public void OnRemoveDevice(){} // RVA: 0x7FFAC9605460
        public void OnChangeUsages(){} // RVA: 0x7FFAC9605470
        public void OnStartSending(){} // RVA: 0x7FFAC9605480
        public void OnStopSending(){} // RVA: 0x7FFAC9605490
        public void SendToSubscribers(){} // RVA: 0x7FFAC96054A0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x7FFAC96056A0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0x7FFAC2F21310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
        public void .cctor(){} // RVA: 0x7FFAC9605860
    }

    public class Sensor : InputDevice
    {
        public object samplingFrequency;

        // ── Methods ──
        public void get_samplingFrequency(){} // RVA: 0x7FFAC96060C0
        public void set_samplingFrequency(){} // RVA: 0x7FFAC96061A0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class StepCounter : Sensor
    {
        public UnityEngine.InputSystem.Controls.IntegerControl stepCounter; // 0x190
        public UnityEngine.InputSystem.StepCounter current;

        // ── Methods ──
        public void get_stepCounter(){} // RVA: 0x7FFAC3540F60
        public void set_stepCounter(){} // RVA: 0x7FFAC39AB1D0
        public void get_current(){} // RVA: 0x7FFAC9607770
        public void set_current(){} // RVA: 0x7FFAC96077B0
        public void MakeCurrent(){} // RVA: 0x7FFAC9607850
        public void OnRemoved(){} // RVA: 0x7FFAC9607860
        public void FinishSetup(){} // RVA: 0x7FFAC96078B0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class Touchscreen : Pointer
    {
        public UnityEngine.InputSystem.Controls.TouchControl primaryTouch; // 0x1C0
        public UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.Controls.TouchControl> touches; // 0x1C8
        public Unity.Profiling.ProfilerMarker touchControlArray;
        public Unity.Profiling.ProfilerMarker current; // 0x8
        public UnityEngine.InputSystem.Touchscreen <current>k__BackingField; // 0x10
        public float s_TapTime; // 0x18
        public float s_TapDelayTime; // 0x1C
        public float s_TapRadiusSquared; // 0x20

        // ── Methods ──
        public void get_primaryTouch(){} // RVA: 0x7FFAC35422B0
        public void set_primaryTouch(){} // RVA: 0x7FFAC39AD110
        public void get_touches(){} // RVA: 0x7FFAC9607B50
        public void set_touches(){} // RVA: 0x7FFAC9607B60
        public void get_touchControlArray(){} // RVA: 0x7FFAC39CCB10
        public void set_touchControlArray(){} // RVA: 0x7FFAC9607BC0
        public void get_current(){} // RVA: 0x7FFAC9607CE0
        public void set_current(){} // RVA: 0x7FFAC9607D40
        public void MakeCurrent(){} // RVA: 0x7FFAC9607E00
        public void OnRemoved(){} // RVA: 0x7FFAC9607E60
        public void FinishSetup(){} // RVA: 0x7FFAC9607F50
        public void OnNextUpdate(){} // RVA: 0x7FFAC96085E0
        public void OnStateEvent(){} // RVA: 0x7FFAC9608A90
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFAC96092E0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFAC96092F0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x7FFAC9609300
        public void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset(){} // RVA: 0x7FFAC96096B0
        public void MergeForward(){} // RVA: 0x7FFAC9609BC0
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7FFAC9609C50
        public void TriggerTap(){} // RVA: 0x7FFAC9609D30
        public void .ctor(){} // RVA: 0x7FFAC9516440
        public void .cctor(){} // RVA: 0x7FFAC9609DD0
    }

    public class TrackedDevice : InputDevice
    {
        public UnityEngine.InputSystem.Controls.IntegerControl trackingState; // 0x190
        public UnityEngine.InputSystem.Controls.ButtonControl isTracked; // 0x198
        public UnityEngine.InputSystem.Controls.Vector3Control devicePosition; // 0x1A0
        public UnityEngine.InputSystem.Controls.QuaternionControl deviceRotation; // 0x1A8

        // ── Methods ──
        public void get_trackingState(){} // RVA: 0x7FFAC3540F60
        public void set_trackingState(){} // RVA: 0x7FFAC39AB1D0
        public void get_isTracked(){} // RVA: 0x7FFAC3541C80
        public void set_isTracked(){} // RVA: 0x7FFAC39C8ED0
        public void get_devicePosition(){} // RVA: 0x7FFAC354E2E0
        public void set_devicePosition(){} // RVA: 0x7FFAC39A8AF0
        public void get_deviceRotation(){} // RVA: 0x7FFAC3548F80
        public void set_deviceRotation(){} // RVA: 0x7FFAC39B4D10
        public void FinishSetup(){} // RVA: 0x7FFAC9609EF0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

}