// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 92
// Methods: 2580

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class Accelerometer : Sensor
    {
        // ── Original Methods ──
        public void get_acceleration(){} // RVA: 0x7ffaa8f77bc0
        public void set_acceleration(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf028200
        public void set_current(){} // RVA: 0x7ffaaf028240
        public void MakeCurrent(){} // RVA: 0x7ffaaf0282e0
        public void OnRemoved(){} // RVA: 0x7ffaaf0282f0
        public void FinishSetup(){} // RVA: 0x7ffaaf028340
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class AmbientTemperatureSensor : Sensor
    {
        // ── Original Methods ──
        public void get_ambientTemperature(){} // RVA: 0x7ffaa8f77bc0
        public void set_ambientTemperature(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf029560
        public void set_current(){} // RVA: 0x7ffaaf0295a0
        public void MakeCurrent(){} // RVA: 0x7ffaaf029640
        public void OnRemoved(){} // RVA: 0x7ffaaf029650
        public void FinishSetup(){} // RVA: 0x7ffaaf0296a0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class AttitudeSensor : Sensor
    {
        // ── Original Methods ──
        public void get_attitude(){} // RVA: 0x7ffaa8f77bc0
        public void set_attitude(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf0287d0
        public void set_current(){} // RVA: 0x7ffaaf028810
        public void MakeCurrent(){} // RVA: 0x7ffaaf0288b0
        public void OnRemoved(){} // RVA: 0x7ffaaf0288c0
        public void FinishSetup(){} // RVA: 0x7ffaaf028910
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class CommonUsages : Object
    {
        public object PrimaryAction; // 0x337A5FA0
        public object SecondaryTrigger; // 0x337A5FA0
        public object Orientation; // 0x337A5FA0
        public object Forward; // 0x337A5FA0
        public object Cancel; // 0x337A5FA0
        public object Twist; // 0x337A5FA0
        public object ScrollVertical; // 0x337A5FA0
        public object HighFreqMotor; // 0x337A5FA0
        public object BatteryStrength; // 0x337A5FA0
        public object IgnoreControlsInDefaultState; // 0x83E505E0
        public object IncludeNoisyControls; // 0x83E505E0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaefa4a40
    }

    public class DefaultInputActions : Object
    {
        public object m_PlayerActionsCallbackInterface; // 0x33B04EA0
        public object m_Player_Fire; // 0x33B04EA0
        public object m_UI_Navigate; // 0x33B04EA0
        public object m_UI_Point; // 0x33B04EA0
        public object m_UI_MiddleClick; // 0x33B04EA0
        public object m_UI_TrackedDeviceOrientation; // 0x33B04EA0
        public object m_TouchSchemeIndex; // 0x33B04EA0

        // ── Original Methods ──
        public void get_asset(){} // RVA: 0x7ffaa894d380
        public void .ctor(){} // RVA: 0x7ffaaf042b90
        public void Dispose(){} // RVA: 0x7ffaaf0433f0
        public void get_bindingMask(){} // RVA: 0x7ffaa930bfc0
        public void set_bindingMask(){} // RVA: 0x7ffaa930c070
        public void get_devices(){} // RVA: 0x7ffaa930eae0
        public void set_devices(){} // RVA: 0x7ffaa930e8c0
        public void get_controlSchemes(){} // RVA: 0x7ffaa930c010
        public void Contains(){} // RVA: 0x7ffaa930c170
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa930c0d0
        public void Enable(){} // RVA: 0x7ffaa930e6c0
        public void Disable(){} // RVA: 0x7ffaa930e940
        public void get_bindings(){} // RVA: 0x7ffaa930c050
        public void FindAction(){} // RVA: 0x7ffaa930c150
        public void FindBinding(){} // RVA: 0x7ffaa930c490
        public void get_Player(){} // RVA: 0x7ffaa930c0f0
        public void get_UI(){} // RVA: 0x7ffaa930c0f0
        public void get_KeyboardMouseScheme(){} // RVA: 0x7ffaaf043450
        public void get_GamepadScheme(){} // RVA: 0x7ffaaf0435d0
        public void get_TouchScheme(){} // RVA: 0x7ffaaf043750
        public void get_JoystickScheme(){} // RVA: 0x7ffaaf0438d0
        public void get_XRScheme(){} // RVA: 0x7ffaaf043a50
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa930c0d0
    }

    public class DynamicBitfield : ValueType
    {
        // ── Original Methods ──
        public void TestBit(){} // RVA: 0x7ffaaf0543a0
        public void ClearBit(){} // RVA: 0x7ffaaf054420
        public void AnyBitIsSet(){} // RVA: 0x7ffaaf0544c0
        public void BitCountToULongCount(){} // RVA: 0x7ffaaf054530
        // ── Binary Analysis Named ──
        public void SetLength(){} // RVA: 0x7ffaaf0542a0
        public void SetBit(){} // RVA: 0x7ffaaf054300
    }

    public class FastKeyboard : Keyboard
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaefbace0
        public void Initialize_ctrlKeyboardanyKey(){} // RVA: 0x7ffaaefbfa30
        public void Initialize_ctrlKeyboardescape(){} // RVA: 0x7ffaaefbfde0
        public void Initialize_ctrlKeyboardspace(){} // RVA: 0x7ffaaefc0150
        public void Initialize_ctrlKeyboardenter(){} // RVA: 0x7ffaaefc04b0
        public void Initialize_ctrlKeyboardtab(){} // RVA: 0x7ffaaefc0830
        public void Initialize_ctrlKeyboardbackquote(){} // RVA: 0x7ffaaefc0b90
        public void Initialize_ctrlKeyboardquote(){} // RVA: 0x7ffaaefc0ef0
        public void Initialize_ctrlKeyboardsemicolon(){} // RVA: 0x7ffaaefc1250
        public void Initialize_ctrlKeyboardcomma(){} // RVA: 0x7ffaaefc15b0
        public void Initialize_ctrlKeyboardperiod(){} // RVA: 0x7ffaaefc1910
        public void Initialize_ctrlKeyboardslash(){} // RVA: 0x7ffaaefc1c70
        public void Initialize_ctrlKeyboardbackslash(){} // RVA: 0x7ffaaefc1fd0
        public void Initialize_ctrlKeyboardleftBracket(){} // RVA: 0x7ffaaefc2330
        public void Initialize_ctrlKeyboardrightBracket(){} // RVA: 0x7ffaaefc2690
        public void Initialize_ctrlKeyboardminus(){} // RVA: 0x7ffaaefc29f0
        public void Initialize_ctrlKeyboardequals(){} // RVA: 0x7ffaaefc2d50
        public void Initialize_ctrlKeyboardupArrow(){} // RVA: 0x7ffaaefc30b0
        public void Initialize_ctrlKeyboarddownArrow(){} // RVA: 0x7ffaaefc3410
        public void Initialize_ctrlKeyboardleftArrow(){} // RVA: 0x7ffaaefc3770
        public void Initialize_ctrlKeyboardrightArrow(){} // RVA: 0x7ffaaefc3ad0
        public void Initialize_ctrlKeyboarda(){} // RVA: 0x7ffaaefc3e30
        public void Initialize_ctrlKeyboardb(){} // RVA: 0x7ffaaefc4190
        public void Initialize_ctrlKeyboardc(){} // RVA: 0x7ffaaefc44f0
        public void Initialize_ctrlKeyboardd(){} // RVA: 0x7ffaaefc4850
        public void Initialize_ctrlKeyboarde(){} // RVA: 0x7ffaaefc4bb0
        public void Initialize_ctrlKeyboardf(){} // RVA: 0x7ffaaefc4f10
        public void Initialize_ctrlKeyboardg(){} // RVA: 0x7ffaaefc5270
        public void Initialize_ctrlKeyboardh(){} // RVA: 0x7ffaaefc55d0
        public void Initialize_ctrlKeyboardi(){} // RVA: 0x7ffaaefc5930
        public void Initialize_ctrlKeyboardj(){} // RVA: 0x7ffaaefc5c90
        public void Initialize_ctrlKeyboardk(){} // RVA: 0x7ffaaefc5ff0
        public void Initialize_ctrlKeyboardl(){} // RVA: 0x7ffaaefc6350
        public void Initialize_ctrlKeyboardm(){} // RVA: 0x7ffaaefc66b0
        public void Initialize_ctrlKeyboardn(){} // RVA: 0x7ffaaefc6a10
        public void Initialize_ctrlKeyboardo(){} // RVA: 0x7ffaaefc6d70
        public void Initialize_ctrlKeyboardp(){} // RVA: 0x7ffaaefc70d0
        public void Initialize_ctrlKeyboardq(){} // RVA: 0x7ffaaefc7430
        public void Initialize_ctrlKeyboardr(){} // RVA: 0x7ffaaefc7790
        public void Initialize_ctrlKeyboards(){} // RVA: 0x7ffaaefc7af0
        public void Initialize_ctrlKeyboardt(){} // RVA: 0x7ffaaefc7e50
        public void Initialize_ctrlKeyboardu(){} // RVA: 0x7ffaaefc81b0
        public void Initialize_ctrlKeyboardv(){} // RVA: 0x7ffaaefc8510
        public void Initialize_ctrlKeyboardw(){} // RVA: 0x7ffaaefc8870
        public void Initialize_ctrlKeyboardx(){} // RVA: 0x7ffaaefc8bd0
        public void Initialize_ctrlKeyboardy(){} // RVA: 0x7ffaaefc8f30
        public void Initialize_ctrlKeyboardz(){} // RVA: 0x7ffaaefc9290
        public void Initialize_ctrlKeyboard1(){} // RVA: 0x7ffaaefc95f0
        public void Initialize_ctrlKeyboard2(){} // RVA: 0x7ffaaefc9940
        public void Initialize_ctrlKeyboard3(){} // RVA: 0x7ffaaefc9c90
        public void Initialize_ctrlKeyboard4(){} // RVA: 0x7ffaaefc9fe0
        public void Initialize_ctrlKeyboard5(){} // RVA: 0x7ffaaefca330
        public void Initialize_ctrlKeyboard6(){} // RVA: 0x7ffaaefca680
        public void Initialize_ctrlKeyboard7(){} // RVA: 0x7ffaaefca9d0
        public void Initialize_ctrlKeyboard8(){} // RVA: 0x7ffaaefcad20
        public void Initialize_ctrlKeyboard9(){} // RVA: 0x7ffaaefcb070
        public void Initialize_ctrlKeyboard0(){} // RVA: 0x7ffaaefcb3c0
        public void Initialize_ctrlKeyboardleftShift(){} // RVA: 0x7ffaaefcb710
        public void Initialize_ctrlKeyboardrightShift(){} // RVA: 0x7ffaaefcba90
        public void Initialize_ctrlKeyboardshift(){} // RVA: 0x7ffaaefcbe10
        public void Initialize_ctrlKeyboardleftAlt(){} // RVA: 0x7ffaaefcc1b0
        public void Initialize_ctrlKeyboardrightAlt(){} // RVA: 0x7ffaaefcc530
        public void Initialize_ctrlKeyboardalt(){} // RVA: 0x7ffaaefcc8b0
        public void Initialize_ctrlKeyboardleftCtrl(){} // RVA: 0x7ffaaefccc50
        public void Initialize_ctrlKeyboardrightCtrl(){} // RVA: 0x7ffaaefccfd0
        public void Initialize_ctrlKeyboardctrl(){} // RVA: 0x7ffaaefcd350
        public void Initialize_ctrlKeyboardleftMeta(){} // RVA: 0x7ffaaefcd6f0
        public void Initialize_ctrlKeyboardrightMeta(){} // RVA: 0x7ffaaefcda80
        public void Initialize_ctrlKeyboardcontextMenu(){} // RVA: 0x7ffaaefcde10
        public void Initialize_ctrlKeyboardbackspace(){} // RVA: 0x7ffaaefce190
        public void Initialize_ctrlKeyboardpageDown(){} // RVA: 0x7ffaaefce4f0
        public void Initialize_ctrlKeyboardpageUp(){} // RVA: 0x7ffaaefce850
        public void Initialize_ctrlKeyboardhome(){} // RVA: 0x7ffaaefcebb0
        public void Initialize_ctrlKeyboardend(){} // RVA: 0x7ffaaefcef10
        public void Initialize_ctrlKeyboardinsert(){} // RVA: 0x7ffaaefcf270
        public void Initialize_ctrlKeyboarddelete(){} // RVA: 0x7ffaaefcf5d0
        public void Initialize_ctrlKeyboardcapsLock(){} // RVA: 0x7ffaaefcf930
        public void Initialize_ctrlKeyboardnumLock(){} // RVA: 0x7ffaaefcfc90
        public void Initialize_ctrlKeyboardprintScreen(){} // RVA: 0x7ffaaefcfff0
        public void Initialize_ctrlKeyboardscrollLock(){} // RVA: 0x7ffaaefd0350
        public void Initialize_ctrlKeyboardpause(){} // RVA: 0x7ffaaefd06b0
        public void Initialize_ctrlKeyboardnumpadEnter(){} // RVA: 0x7ffaaefd0a10
        public void Initialize_ctrlKeyboardnumpadDivide(){} // RVA: 0x7ffaaefd0d70
        public void Initialize_ctrlKeyboardnumpadMultiply(){} // RVA: 0x7ffaaefd10d0
        public void Initialize_ctrlKeyboardnumpadPlus(){} // RVA: 0x7ffaaefd1430
        public void Initialize_ctrlKeyboardnumpadMinus(){} // RVA: 0x7ffaaefd1790
        public void Initialize_ctrlKeyboardnumpadPeriod(){} // RVA: 0x7ffaaefd1af0
        public void Initialize_ctrlKeyboardnumpadEquals(){} // RVA: 0x7ffaaefd1e50
        public void Initialize_ctrlKeyboardnumpad1(){} // RVA: 0x7ffaaefd21b0
        public void Initialize_ctrlKeyboardnumpad2(){} // RVA: 0x7ffaaefd2510
        public void Initialize_ctrlKeyboardnumpad3(){} // RVA: 0x7ffaaefd2870
        public void Initialize_ctrlKeyboardnumpad4(){} // RVA: 0x7ffaaefd2bd0
        public void Initialize_ctrlKeyboardnumpad5(){} // RVA: 0x7ffaaefd2f30
        public void Initialize_ctrlKeyboardnumpad6(){} // RVA: 0x7ffaaefd3290
        public void Initialize_ctrlKeyboardnumpad7(){} // RVA: 0x7ffaaefd35f0
        public void Initialize_ctrlKeyboardnumpad8(){} // RVA: 0x7ffaaefd3950
        public void Initialize_ctrlKeyboardnumpad9(){} // RVA: 0x7ffaaefd3cb0
        public void Initialize_ctrlKeyboardnumpad0(){} // RVA: 0x7ffaaefd4010
        public void Initialize_ctrlKeyboardf1(){} // RVA: 0x7ffaaefd4370
        public void Initialize_ctrlKeyboardf2(){} // RVA: 0x7ffaaefd46d0
        public void Initialize_ctrlKeyboardf3(){} // RVA: 0x7ffaaefd4a30
        public void Initialize_ctrlKeyboardf4(){} // RVA: 0x7ffaaefd4d90
        public void Initialize_ctrlKeyboardf5(){} // RVA: 0x7ffaaefd50f0
        public void Initialize_ctrlKeyboardf6(){} // RVA: 0x7ffaaefd5450
        public void Initialize_ctrlKeyboardf7(){} // RVA: 0x7ffaaefd57b0
        public void Initialize_ctrlKeyboardf8(){} // RVA: 0x7ffaaefd5b10
        public void Initialize_ctrlKeyboardf9(){} // RVA: 0x7ffaaefd5e70
        public void Initialize_ctrlKeyboardf10(){} // RVA: 0x7ffaaefd61d0
        public void Initialize_ctrlKeyboardf11(){} // RVA: 0x7ffaaefd6530
        public void Initialize_ctrlKeyboardf12(){} // RVA: 0x7ffaaefd6890
        public void Initialize_ctrlKeyboardOEM1(){} // RVA: 0x7ffaaefd6bf0
        public void Initialize_ctrlKeyboardOEM2(){} // RVA: 0x7ffaaefd6f40
        public void Initialize_ctrlKeyboardOEM3(){} // RVA: 0x7ffaaefd7290
        public void Initialize_ctrlKeyboardOEM4(){} // RVA: 0x7ffaaefd75e0
        public void Initialize_ctrlKeyboardOEM5(){} // RVA: 0x7ffaaefd7930
        public void Initialize_ctrlKeyboardf13(){} // RVA: 0x7ffaaefd7c80
        public void Initialize_ctrlKeyboardf14(){} // RVA: 0x7ffaaefd7fe0
        public void Initialize_ctrlKeyboardf15(){} // RVA: 0x7ffaaefd8340
        public void Initialize_ctrlKeyboardf16(){} // RVA: 0x7ffaaefd86a0
        public void Initialize_ctrlKeyboardf17(){} // RVA: 0x7ffaaefd8a00
        public void Initialize_ctrlKeyboardf18(){} // RVA: 0x7ffaaefd8d60
        public void Initialize_ctrlKeyboardf19(){} // RVA: 0x7ffaaefd90c0
        public void Initialize_ctrlKeyboardf20(){} // RVA: 0x7ffaaefd9420
        public void Initialize_ctrlKeyboardf21(){} // RVA: 0x7ffaaefd9780
        public void Initialize_ctrlKeyboardf22(){} // RVA: 0x7ffaaefd9ae0
        public void Initialize_ctrlKeyboardf23(){} // RVA: 0x7ffaaefd9e40
        public void Initialize_ctrlKeyboardf24(){} // RVA: 0x7ffaaefda1a0
        public void Initialize_ctrlKeyboardIMESelected(){} // RVA: 0x7ffaaefda500
    }

    public class FastMouse : Mouse
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf01aa60
        public void Initialize_ctrlMouseposition(){} // RVA: 0x7ffaaf01c490
        public void Initialize_ctrlMousedelta(){} // RVA: 0x7ffaaf01c7b0
        public void Initialize_ctrlMousescroll(){} // RVA: 0x7ffaaf01cac0
        public void Initialize_ctrlMousepress(){} // RVA: 0x7ffaaf01cdc0
        public void Initialize_ctrlMouseleftButton(){} // RVA: 0x7ffaaf01d120
        public void Initialize_ctrlMouserightButton(){} // RVA: 0x7ffaaf01d4a0
        public void Initialize_ctrlMousemiddleButton(){} // RVA: 0x7ffaaf01d820
        public void Initialize_ctrlMouseforwardButton(){} // RVA: 0x7ffaaf01db90
        public void Initialize_ctrlMousebackButton(){} // RVA: 0x7ffaaf01df00
        public void Initialize_ctrlMousepressure(){} // RVA: 0x7ffaaf01e270
        public void Initialize_ctrlMouseradius(){} // RVA: 0x7ffaaf01e5a0
        public void Initialize_ctrlMousepointerId(){} // RVA: 0x7ffaaf01e8b0
        public void Initialize_ctrlMousedisplayIndex(){} // RVA: 0x7ffaaf01eb90
        public void Initialize_ctrlMouseclickCount(){} // RVA: 0x7ffaaf01ee80
        public void Initialize_ctrlMousepositionx(){} // RVA: 0x7ffaaf01f170
        public void Initialize_ctrlMousepositiony(){} // RVA: 0x7ffaaf01f490
        public void Initialize_ctrlMousedeltaup(){} // RVA: 0x7ffaaf01f7b0
        public void Initialize_ctrlMousedeltadown(){} // RVA: 0x7ffaaf01fae0
        public void Initialize_ctrlMousedeltaleft(){} // RVA: 0x7ffaaf01fe10
        public void Initialize_ctrlMousedeltaright(){} // RVA: 0x7ffaaf020140
        public void Initialize_ctrlMousedeltax(){} // RVA: 0x7ffaaf020470
        public void Initialize_ctrlMousedeltay(){} // RVA: 0x7ffaaf020770
        public void Initialize_ctrlMousescrollup(){} // RVA: 0x7ffaaf020a70
        public void Initialize_ctrlMousescrolldown(){} // RVA: 0x7ffaaf020da0
        public void Initialize_ctrlMousescrollleft(){} // RVA: 0x7ffaaf0210d0
        public void Initialize_ctrlMousescrollright(){} // RVA: 0x7ffaaf021400
        public void Initialize_ctrlMousescrollx(){} // RVA: 0x7ffaaf021730
        public void Initialize_ctrlMousescrolly(){} // RVA: 0x7ffaaf021a50
        public void Initialize_ctrlMouseradiusx(){} // RVA: 0x7ffaaf021d90
        public void Initialize_ctrlMouseradiusy(){} // RVA: 0x7ffaaf022090
        public void OnNextUpdate(){} // RVA: 0x7ffaaf022390
        public void OnStateEvent(){} // RVA: 0x7ffaaf0224f0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7ffaaf022390
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7ffaaf0224f0
        public void MergeForward(){} // RVA: 0x7ffaaf022690
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7ffaaf022740
    }

    public class FastTouchscreen : Touchscreen
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaefdab70
        public void Initialize_ctrlTouchscreenprimaryTouch(){} // RVA: 0x7ffaaefdff90
        public void Initialize_ctrlTouchscreenposition(){} // RVA: 0x7ffaaefe0290
        public void Initialize_ctrlTouchscreendelta(){} // RVA: 0x7ffaaefe05c0
        public void Initialize_ctrlTouchscreenpressure(){} // RVA: 0x7ffaaefe08d0
        public void Initialize_ctrlTouchscreenradius(){} // RVA: 0x7ffaaefe0c00
        public void Initialize_ctrlTouchscreenpress(){} // RVA: 0x7ffaaefe0f10
        public void Initialize_ctrlTouchscreendisplayIndex(){} // RVA: 0x7ffaaefe1270
        public void Initialize_ctrlTouchscreentouch0(){} // RVA: 0x7ffaaefe1560
        public void Initialize_ctrlTouchscreentouch1(){} // RVA: 0x7ffaaefe1860
        public void Initialize_ctrlTouchscreentouch2(){} // RVA: 0x7ffaaefe1b60
        public void Initialize_ctrlTouchscreentouch3(){} // RVA: 0x7ffaaefe1e60
        public void Initialize_ctrlTouchscreentouch4(){} // RVA: 0x7ffaaefe2160
        public void Initialize_ctrlTouchscreentouch5(){} // RVA: 0x7ffaaefe2460
        public void Initialize_ctrlTouchscreentouch6(){} // RVA: 0x7ffaaefe2760
        public void Initialize_ctrlTouchscreentouch7(){} // RVA: 0x7ffaaefe2a60
        public void Initialize_ctrlTouchscreentouch8(){} // RVA: 0x7ffaaefe2d60
        public void Initialize_ctrlTouchscreentouch9(){} // RVA: 0x7ffaaefe3060
        public void Initialize_ctrlTouchscreenprimaryTouchtouchId(){} // RVA: 0x7ffaaefe3360
        public void Initialize_ctrlTouchscreenprimaryTouchposition(){} // RVA: 0x7ffaaefe3680
        public void Initialize_ctrlTouchscreenprimaryTouchdelta(){} // RVA: 0x7ffaaefe39b0
        public void Initialize_ctrlTouchscreenprimaryTouchpressure(){} // RVA: 0x7ffaaefe3cc0
        public void Initialize_ctrlTouchscreenprimaryTouchradius(){} // RVA: 0x7ffaaefe3fc0
        public void Initialize_ctrlTouchscreenprimaryTouchphase(){} // RVA: 0x7ffaaefe42d0
        public void Initialize_ctrlTouchscreenprimaryTouchpress(){} // RVA: 0x7ffaaefe45e0
        public void Initialize_ctrlTouchscreenprimaryTouchtapCount(){} // RVA: 0x7ffaaefe4940
        public void Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(){} // RVA: 0x7ffaaefe4c40
        public void Initialize_ctrlTouchscreenprimaryTouchindirectTouch(){} // RVA: 0x7ffaaefe4f40
        public void Initialize_ctrlTouchscreenprimaryTouchtap(){} // RVA: 0x7ffaaefe52a0
        public void Initialize_ctrlTouchscreenprimaryTouchstartTime(){} // RVA: 0x7ffaaefe5610
        public void Initialize_ctrlTouchscreenprimaryTouchstartPosition(){} // RVA: 0x7ffaaefe5920
        public void Initialize_ctrlTouchscreenprimaryTouchpositionx(){} // RVA: 0x7ffaaefe5c40
        public void Initialize_ctrlTouchscreenprimaryTouchpositiony(){} // RVA: 0x7ffaaefe5f60
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaup(){} // RVA: 0x7ffaaefe6280
        public void Initialize_ctrlTouchscreenprimaryTouchdeltadown(){} // RVA: 0x7ffaaefe65b0
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaleft(){} // RVA: 0x7ffaaefe68e0
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaright(){} // RVA: 0x7ffaaefe6c10
        public void Initialize_ctrlTouchscreenprimaryTouchdeltax(){} // RVA: 0x7ffaaefe6f40
        public void Initialize_ctrlTouchscreenprimaryTouchdeltay(){} // RVA: 0x7ffaaefe7240
        public void Initialize_ctrlTouchscreenprimaryTouchradiusx(){} // RVA: 0x7ffaaefe7540
        public void Initialize_ctrlTouchscreenprimaryTouchradiusy(){} // RVA: 0x7ffaaefe7840
        public void Initialize_ctrlTouchscreenprimaryTouchstartPositionx(){} // RVA: 0x7ffaaefe7b40
        public void Initialize_ctrlTouchscreenprimaryTouchstartPositiony(){} // RVA: 0x7ffaaefe7e40
        public void Initialize_ctrlTouchscreenpositionx(){} // RVA: 0x7ffaaefe8140
        public void Initialize_ctrlTouchscreenpositiony(){} // RVA: 0x7ffaaefe8460
        public void Initialize_ctrlTouchscreendeltaup(){} // RVA: 0x7ffaaefe8780
        public void Initialize_ctrlTouchscreendeltadown(){} // RVA: 0x7ffaaefe8ab0
        public void Initialize_ctrlTouchscreendeltaleft(){} // RVA: 0x7ffaaefe8de0
        public void Initialize_ctrlTouchscreendeltaright(){} // RVA: 0x7ffaaefe9110
        public void Initialize_ctrlTouchscreendeltax(){} // RVA: 0x7ffaaefe9440
        public void Initialize_ctrlTouchscreendeltay(){} // RVA: 0x7ffaaefe9740
        public void Initialize_ctrlTouchscreenradiusx(){} // RVA: 0x7ffaaefe9a40
        public void Initialize_ctrlTouchscreenradiusy(){} // RVA: 0x7ffaaefe9d40
        public void Initialize_ctrlTouchscreentouch0touchId(){} // RVA: 0x7ffaaefea040
        public void Initialize_ctrlTouchscreentouch0position(){} // RVA: 0x7ffaaefea360
        public void Initialize_ctrlTouchscreentouch0delta(){} // RVA: 0x7ffaaefea690
        public void Initialize_ctrlTouchscreentouch0pressure(){} // RVA: 0x7ffaaefea9a0
        public void Initialize_ctrlTouchscreentouch0radius(){} // RVA: 0x7ffaaefeaca0
        public void Initialize_ctrlTouchscreentouch0phase(){} // RVA: 0x7ffaaefeafb0
        public void Initialize_ctrlTouchscreentouch0press(){} // RVA: 0x7ffaaefeb2c0
        public void Initialize_ctrlTouchscreentouch0tapCount(){} // RVA: 0x7ffaaefeb620
        public void Initialize_ctrlTouchscreentouch0displayIndex(){} // RVA: 0x7ffaaefeb920
        public void Initialize_ctrlTouchscreentouch0indirectTouch(){} // RVA: 0x7ffaaefebc20
        public void Initialize_ctrlTouchscreentouch0tap(){} // RVA: 0x7ffaaefebf80
        public void Initialize_ctrlTouchscreentouch0startTime(){} // RVA: 0x7ffaaefec2e0
        public void Initialize_ctrlTouchscreentouch0startPosition(){} // RVA: 0x7ffaaefec5f0
        public void Initialize_ctrlTouchscreentouch0positionx(){} // RVA: 0x7ffaaefec910
        public void Initialize_ctrlTouchscreentouch0positiony(){} // RVA: 0x7ffaaefecc30
        public void Initialize_ctrlTouchscreentouch0deltaup(){} // RVA: 0x7ffaaefecf50
        public void Initialize_ctrlTouchscreentouch0deltadown(){} // RVA: 0x7ffaaefed280
        public void Initialize_ctrlTouchscreentouch0deltaleft(){} // RVA: 0x7ffaaefed5b0
        public void Initialize_ctrlTouchscreentouch0deltaright(){} // RVA: 0x7ffaaefed8e0
        public void Initialize_ctrlTouchscreentouch0deltax(){} // RVA: 0x7ffaaefedc10
        public void Initialize_ctrlTouchscreentouch0deltay(){} // RVA: 0x7ffaaefedf10
        public void Initialize_ctrlTouchscreentouch0radiusx(){} // RVA: 0x7ffaaefee210
        public void Initialize_ctrlTouchscreentouch0radiusy(){} // RVA: 0x7ffaaefee510
        public void Initialize_ctrlTouchscreentouch0startPositionx(){} // RVA: 0x7ffaaefee810
        public void Initialize_ctrlTouchscreentouch0startPositiony(){} // RVA: 0x7ffaaefeeb10
        public void Initialize_ctrlTouchscreentouch1touchId(){} // RVA: 0x7ffaaefeee10
        public void Initialize_ctrlTouchscreentouch1position(){} // RVA: 0x7ffaaefef130
        public void Initialize_ctrlTouchscreentouch1delta(){} // RVA: 0x7ffaaefef460
        public void Initialize_ctrlTouchscreentouch1pressure(){} // RVA: 0x7ffaaefef770
        public void Initialize_ctrlTouchscreentouch1radius(){} // RVA: 0x7ffaaefefa70
        public void Initialize_ctrlTouchscreentouch1phase(){} // RVA: 0x7ffaaefefd80
        public void Initialize_ctrlTouchscreentouch1press(){} // RVA: 0x7ffaaeff0090
        public void Initialize_ctrlTouchscreentouch1tapCount(){} // RVA: 0x7ffaaeff03f0
        public void Initialize_ctrlTouchscreentouch1displayIndex(){} // RVA: 0x7ffaaeff06f0
        public void Initialize_ctrlTouchscreentouch1indirectTouch(){} // RVA: 0x7ffaaeff09f0
        public void Initialize_ctrlTouchscreentouch1tap(){} // RVA: 0x7ffaaeff0d50
        public void Initialize_ctrlTouchscreentouch1startTime(){} // RVA: 0x7ffaaeff10b0
        public void Initialize_ctrlTouchscreentouch1startPosition(){} // RVA: 0x7ffaaeff13c0
        public void Initialize_ctrlTouchscreentouch1positionx(){} // RVA: 0x7ffaaeff16e0
        public void Initialize_ctrlTouchscreentouch1positiony(){} // RVA: 0x7ffaaeff1a00
        public void Initialize_ctrlTouchscreentouch1deltaup(){} // RVA: 0x7ffaaeff1d20
        public void Initialize_ctrlTouchscreentouch1deltadown(){} // RVA: 0x7ffaaeff2050
        public void Initialize_ctrlTouchscreentouch1deltaleft(){} // RVA: 0x7ffaaeff2380
        public void Initialize_ctrlTouchscreentouch1deltaright(){} // RVA: 0x7ffaaeff26b0
        public void Initialize_ctrlTouchscreentouch1deltax(){} // RVA: 0x7ffaaeff29e0
        public void Initialize_ctrlTouchscreentouch1deltay(){} // RVA: 0x7ffaaeff2ce0
        public void Initialize_ctrlTouchscreentouch1radiusx(){} // RVA: 0x7ffaaeff2fe0
        public void Initialize_ctrlTouchscreentouch1radiusy(){} // RVA: 0x7ffaaeff32e0
        public void Initialize_ctrlTouchscreentouch1startPositionx(){} // RVA: 0x7ffaaeff35e0
        public void Initialize_ctrlTouchscreentouch1startPositiony(){} // RVA: 0x7ffaaeff38e0
        public void Initialize_ctrlTouchscreentouch2touchId(){} // RVA: 0x7ffaaeff3be0
        public void Initialize_ctrlTouchscreentouch2position(){} // RVA: 0x7ffaaeff3f00
        public void Initialize_ctrlTouchscreentouch2delta(){} // RVA: 0x7ffaaeff4230
        public void Initialize_ctrlTouchscreentouch2pressure(){} // RVA: 0x7ffaaeff4540
        public void Initialize_ctrlTouchscreentouch2radius(){} // RVA: 0x7ffaaeff4840
        public void Initialize_ctrlTouchscreentouch2phase(){} // RVA: 0x7ffaaeff4b50
        public void Initialize_ctrlTouchscreentouch2press(){} // RVA: 0x7ffaaeff4e60
        public void Initialize_ctrlTouchscreentouch2tapCount(){} // RVA: 0x7ffaaeff51c0
        public void Initialize_ctrlTouchscreentouch2displayIndex(){} // RVA: 0x7ffaaeff54c0
        public void Initialize_ctrlTouchscreentouch2indirectTouch(){} // RVA: 0x7ffaaeff57c0
        public void Initialize_ctrlTouchscreentouch2tap(){} // RVA: 0x7ffaaeff5b20
        public void Initialize_ctrlTouchscreentouch2startTime(){} // RVA: 0x7ffaaeff5e80
        public void Initialize_ctrlTouchscreentouch2startPosition(){} // RVA: 0x7ffaaeff6190
        public void Initialize_ctrlTouchscreentouch2positionx(){} // RVA: 0x7ffaaeff64b0
        public void Initialize_ctrlTouchscreentouch2positiony(){} // RVA: 0x7ffaaeff67d0
        public void Initialize_ctrlTouchscreentouch2deltaup(){} // RVA: 0x7ffaaeff6af0
        public void Initialize_ctrlTouchscreentouch2deltadown(){} // RVA: 0x7ffaaeff6e20
        public void Initialize_ctrlTouchscreentouch2deltaleft(){} // RVA: 0x7ffaaeff7150
        public void Initialize_ctrlTouchscreentouch2deltaright(){} // RVA: 0x7ffaaeff7480
        public void Initialize_ctrlTouchscreentouch2deltax(){} // RVA: 0x7ffaaeff77b0
        public void Initialize_ctrlTouchscreentouch2deltay(){} // RVA: 0x7ffaaeff7ab0
        public void Initialize_ctrlTouchscreentouch2radiusx(){} // RVA: 0x7ffaaeff7db0
        public void Initialize_ctrlTouchscreentouch2radiusy(){} // RVA: 0x7ffaaeff80b0
        public void Initialize_ctrlTouchscreentouch2startPositionx(){} // RVA: 0x7ffaaeff83b0
        public void Initialize_ctrlTouchscreentouch2startPositiony(){} // RVA: 0x7ffaaeff86b0
        public void Initialize_ctrlTouchscreentouch3touchId(){} // RVA: 0x7ffaaeff89b0
        public void Initialize_ctrlTouchscreentouch3position(){} // RVA: 0x7ffaaeff8cd0
        public void Initialize_ctrlTouchscreentouch3delta(){} // RVA: 0x7ffaaeff9000
        public void Initialize_ctrlTouchscreentouch3pressure(){} // RVA: 0x7ffaaeff9310
        public void Initialize_ctrlTouchscreentouch3radius(){} // RVA: 0x7ffaaeff9610
        public void Initialize_ctrlTouchscreentouch3phase(){} // RVA: 0x7ffaaeff9920
        public void Initialize_ctrlTouchscreentouch3press(){} // RVA: 0x7ffaaeff9c30
        public void Initialize_ctrlTouchscreentouch3tapCount(){} // RVA: 0x7ffaaeff9f90
        public void Initialize_ctrlTouchscreentouch3displayIndex(){} // RVA: 0x7ffaaeffa290
        public void Initialize_ctrlTouchscreentouch3indirectTouch(){} // RVA: 0x7ffaaeffa590
        public void Initialize_ctrlTouchscreentouch3tap(){} // RVA: 0x7ffaaeffa8f0
        public void Initialize_ctrlTouchscreentouch3startTime(){} // RVA: 0x7ffaaeffac50
        public void Initialize_ctrlTouchscreentouch3startPosition(){} // RVA: 0x7ffaaeffaf60
        public void Initialize_ctrlTouchscreentouch3positionx(){} // RVA: 0x7ffaaeffb280
        public void Initialize_ctrlTouchscreentouch3positiony(){} // RVA: 0x7ffaaeffb5a0
        public void Initialize_ctrlTouchscreentouch3deltaup(){} // RVA: 0x7ffaaeffb8c0
        public void Initialize_ctrlTouchscreentouch3deltadown(){} // RVA: 0x7ffaaeffbbf0
        public void Initialize_ctrlTouchscreentouch3deltaleft(){} // RVA: 0x7ffaaeffbf20
        public void Initialize_ctrlTouchscreentouch3deltaright(){} // RVA: 0x7ffaaeffc250
        public void Initialize_ctrlTouchscreentouch3deltax(){} // RVA: 0x7ffaaeffc580
        public void Initialize_ctrlTouchscreentouch3deltay(){} // RVA: 0x7ffaaeffc880
        public void Initialize_ctrlTouchscreentouch3radiusx(){} // RVA: 0x7ffaaeffcb80
        public void Initialize_ctrlTouchscreentouch3radiusy(){} // RVA: 0x7ffaaeffce80
        public void Initialize_ctrlTouchscreentouch3startPositionx(){} // RVA: 0x7ffaaeffd180
        public void Initialize_ctrlTouchscreentouch3startPositiony(){} // RVA: 0x7ffaaeffd480
        public void Initialize_ctrlTouchscreentouch4touchId(){} // RVA: 0x7ffaaeffd780
        public void Initialize_ctrlTouchscreentouch4position(){} // RVA: 0x7ffaaeffdaa0
        public void Initialize_ctrlTouchscreentouch4delta(){} // RVA: 0x7ffaaeffddd0
        public void Initialize_ctrlTouchscreentouch4pressure(){} // RVA: 0x7ffaaeffe0e0
        public void Initialize_ctrlTouchscreentouch4radius(){} // RVA: 0x7ffaaeffe3e0
        public void Initialize_ctrlTouchscreentouch4phase(){} // RVA: 0x7ffaaeffe6f0
        public void Initialize_ctrlTouchscreentouch4press(){} // RVA: 0x7ffaaeffea00
        public void Initialize_ctrlTouchscreentouch4tapCount(){} // RVA: 0x7ffaaeffed60
        public void Initialize_ctrlTouchscreentouch4displayIndex(){} // RVA: 0x7ffaaefff060
        public void Initialize_ctrlTouchscreentouch4indirectTouch(){} // RVA: 0x7ffaaefff360
        public void Initialize_ctrlTouchscreentouch4tap(){} // RVA: 0x7ffaaefff6c0
        public void Initialize_ctrlTouchscreentouch4startTime(){} // RVA: 0x7ffaaefffa20
        public void Initialize_ctrlTouchscreentouch4startPosition(){} // RVA: 0x7ffaaefffd30
        public void Initialize_ctrlTouchscreentouch4positionx(){} // RVA: 0x7ffaaf000050
        public void Initialize_ctrlTouchscreentouch4positiony(){} // RVA: 0x7ffaaf000370
        public void Initialize_ctrlTouchscreentouch4deltaup(){} // RVA: 0x7ffaaf000690
        public void Initialize_ctrlTouchscreentouch4deltadown(){} // RVA: 0x7ffaaf0009c0
        public void Initialize_ctrlTouchscreentouch4deltaleft(){} // RVA: 0x7ffaaf000cf0
        public void Initialize_ctrlTouchscreentouch4deltaright(){} // RVA: 0x7ffaaf001020
        public void Initialize_ctrlTouchscreentouch4deltax(){} // RVA: 0x7ffaaf001350
        public void Initialize_ctrlTouchscreentouch4deltay(){} // RVA: 0x7ffaaf001650
        public void Initialize_ctrlTouchscreentouch4radiusx(){} // RVA: 0x7ffaaf001950
        public void Initialize_ctrlTouchscreentouch4radiusy(){} // RVA: 0x7ffaaf001c50
        public void Initialize_ctrlTouchscreentouch4startPositionx(){} // RVA: 0x7ffaaf001f50
        public void Initialize_ctrlTouchscreentouch4startPositiony(){} // RVA: 0x7ffaaf002250
        public void Initialize_ctrlTouchscreentouch5touchId(){} // RVA: 0x7ffaaf002550
        public void Initialize_ctrlTouchscreentouch5position(){} // RVA: 0x7ffaaf002870
        public void Initialize_ctrlTouchscreentouch5delta(){} // RVA: 0x7ffaaf002ba0
        public void Initialize_ctrlTouchscreentouch5pressure(){} // RVA: 0x7ffaaf002eb0
        public void Initialize_ctrlTouchscreentouch5radius(){} // RVA: 0x7ffaaf0031b0
        public void Initialize_ctrlTouchscreentouch5phase(){} // RVA: 0x7ffaaf0034c0
        public void Initialize_ctrlTouchscreentouch5press(){} // RVA: 0x7ffaaf0037d0
        public void Initialize_ctrlTouchscreentouch5tapCount(){} // RVA: 0x7ffaaf003b30
        public void Initialize_ctrlTouchscreentouch5displayIndex(){} // RVA: 0x7ffaaf003e30
        public void Initialize_ctrlTouchscreentouch5indirectTouch(){} // RVA: 0x7ffaaf004130
        public void Initialize_ctrlTouchscreentouch5tap(){} // RVA: 0x7ffaaf004490
        public void Initialize_ctrlTouchscreentouch5startTime(){} // RVA: 0x7ffaaf0047f0
        public void Initialize_ctrlTouchscreentouch5startPosition(){} // RVA: 0x7ffaaf004b00
        public void Initialize_ctrlTouchscreentouch5positionx(){} // RVA: 0x7ffaaf004e20
        public void Initialize_ctrlTouchscreentouch5positiony(){} // RVA: 0x7ffaaf005140
        public void Initialize_ctrlTouchscreentouch5deltaup(){} // RVA: 0x7ffaaf005460
        public void Initialize_ctrlTouchscreentouch5deltadown(){} // RVA: 0x7ffaaf005790
        public void Initialize_ctrlTouchscreentouch5deltaleft(){} // RVA: 0x7ffaaf005ac0
        public void Initialize_ctrlTouchscreentouch5deltaright(){} // RVA: 0x7ffaaf005df0
        public void Initialize_ctrlTouchscreentouch5deltax(){} // RVA: 0x7ffaaf006120
        public void Initialize_ctrlTouchscreentouch5deltay(){} // RVA: 0x7ffaaf006420
        public void Initialize_ctrlTouchscreentouch5radiusx(){} // RVA: 0x7ffaaf006720
        public void Initialize_ctrlTouchscreentouch5radiusy(){} // RVA: 0x7ffaaf006a20
        public void Initialize_ctrlTouchscreentouch5startPositionx(){} // RVA: 0x7ffaaf006d20
        public void Initialize_ctrlTouchscreentouch5startPositiony(){} // RVA: 0x7ffaaf007020
        public void Initialize_ctrlTouchscreentouch6touchId(){} // RVA: 0x7ffaaf007320
        public void Initialize_ctrlTouchscreentouch6position(){} // RVA: 0x7ffaaf007640
        public void Initialize_ctrlTouchscreentouch6delta(){} // RVA: 0x7ffaaf007970
        public void Initialize_ctrlTouchscreentouch6pressure(){} // RVA: 0x7ffaaf007c80
        public void Initialize_ctrlTouchscreentouch6radius(){} // RVA: 0x7ffaaf007f80
        public void Initialize_ctrlTouchscreentouch6phase(){} // RVA: 0x7ffaaf008290
        public void Initialize_ctrlTouchscreentouch6press(){} // RVA: 0x7ffaaf0085a0
        public void Initialize_ctrlTouchscreentouch6tapCount(){} // RVA: 0x7ffaaf008900
        public void Initialize_ctrlTouchscreentouch6displayIndex(){} // RVA: 0x7ffaaf008c00
        public void Initialize_ctrlTouchscreentouch6indirectTouch(){} // RVA: 0x7ffaaf008f00
        public void Initialize_ctrlTouchscreentouch6tap(){} // RVA: 0x7ffaaf009260
        public void Initialize_ctrlTouchscreentouch6startTime(){} // RVA: 0x7ffaaf0095c0
        public void Initialize_ctrlTouchscreentouch6startPosition(){} // RVA: 0x7ffaaf0098d0
        public void Initialize_ctrlTouchscreentouch6positionx(){} // RVA: 0x7ffaaf009bf0
        public void Initialize_ctrlTouchscreentouch6positiony(){} // RVA: 0x7ffaaf009f10
        public void Initialize_ctrlTouchscreentouch6deltaup(){} // RVA: 0x7ffaaf00a230
        public void Initialize_ctrlTouchscreentouch6deltadown(){} // RVA: 0x7ffaaf00a560
        public void Initialize_ctrlTouchscreentouch6deltaleft(){} // RVA: 0x7ffaaf00a890
        public void Initialize_ctrlTouchscreentouch6deltaright(){} // RVA: 0x7ffaaf00abc0
        public void Initialize_ctrlTouchscreentouch6deltax(){} // RVA: 0x7ffaaf00aef0
        public void Initialize_ctrlTouchscreentouch6deltay(){} // RVA: 0x7ffaaf00b1f0
        public void Initialize_ctrlTouchscreentouch6radiusx(){} // RVA: 0x7ffaaf00b4f0
        public void Initialize_ctrlTouchscreentouch6radiusy(){} // RVA: 0x7ffaaf00b7f0
        public void Initialize_ctrlTouchscreentouch6startPositionx(){} // RVA: 0x7ffaaf00baf0
        public void Initialize_ctrlTouchscreentouch6startPositiony(){} // RVA: 0x7ffaaf00bdf0
        public void Initialize_ctrlTouchscreentouch7touchId(){} // RVA: 0x7ffaaf00c0f0
        public void Initialize_ctrlTouchscreentouch7position(){} // RVA: 0x7ffaaf00c410
        public void Initialize_ctrlTouchscreentouch7delta(){} // RVA: 0x7ffaaf00c740
        public void Initialize_ctrlTouchscreentouch7pressure(){} // RVA: 0x7ffaaf00ca50
        public void Initialize_ctrlTouchscreentouch7radius(){} // RVA: 0x7ffaaf00cd50
        public void Initialize_ctrlTouchscreentouch7phase(){} // RVA: 0x7ffaaf00d060
        public void Initialize_ctrlTouchscreentouch7press(){} // RVA: 0x7ffaaf00d370
        public void Initialize_ctrlTouchscreentouch7tapCount(){} // RVA: 0x7ffaaf00d6d0
        public void Initialize_ctrlTouchscreentouch7displayIndex(){} // RVA: 0x7ffaaf00d9d0
        public void Initialize_ctrlTouchscreentouch7indirectTouch(){} // RVA: 0x7ffaaf00dcd0
        public void Initialize_ctrlTouchscreentouch7tap(){} // RVA: 0x7ffaaf00e030
        public void Initialize_ctrlTouchscreentouch7startTime(){} // RVA: 0x7ffaaf00e390
        public void Initialize_ctrlTouchscreentouch7startPosition(){} // RVA: 0x7ffaaf00e6a0
        public void Initialize_ctrlTouchscreentouch7positionx(){} // RVA: 0x7ffaaf00e9c0
        public void Initialize_ctrlTouchscreentouch7positiony(){} // RVA: 0x7ffaaf00ece0
        public void Initialize_ctrlTouchscreentouch7deltaup(){} // RVA: 0x7ffaaf00f000
        public void Initialize_ctrlTouchscreentouch7deltadown(){} // RVA: 0x7ffaaf00f330
        public void Initialize_ctrlTouchscreentouch7deltaleft(){} // RVA: 0x7ffaaf00f660
        public void Initialize_ctrlTouchscreentouch7deltaright(){} // RVA: 0x7ffaaf00f990
        public void Initialize_ctrlTouchscreentouch7deltax(){} // RVA: 0x7ffaaf00fcc0
        public void Initialize_ctrlTouchscreentouch7deltay(){} // RVA: 0x7ffaaf00ffc0
        public void Initialize_ctrlTouchscreentouch7radiusx(){} // RVA: 0x7ffaaf0102c0
        public void Initialize_ctrlTouchscreentouch7radiusy(){} // RVA: 0x7ffaaf0105c0
        public void Initialize_ctrlTouchscreentouch7startPositionx(){} // RVA: 0x7ffaaf0108c0
        public void Initialize_ctrlTouchscreentouch7startPositiony(){} // RVA: 0x7ffaaf010bc0
        public void Initialize_ctrlTouchscreentouch8touchId(){} // RVA: 0x7ffaaf010ec0
        public void Initialize_ctrlTouchscreentouch8position(){} // RVA: 0x7ffaaf0111e0
        public void Initialize_ctrlTouchscreentouch8delta(){} // RVA: 0x7ffaaf011510
        public void Initialize_ctrlTouchscreentouch8pressure(){} // RVA: 0x7ffaaf011820
        public void Initialize_ctrlTouchscreentouch8radius(){} // RVA: 0x7ffaaf011b20
        public void Initialize_ctrlTouchscreentouch8phase(){} // RVA: 0x7ffaaf011e30
        public void Initialize_ctrlTouchscreentouch8press(){} // RVA: 0x7ffaaf012140
        public void Initialize_ctrlTouchscreentouch8tapCount(){} // RVA: 0x7ffaaf0124a0
        public void Initialize_ctrlTouchscreentouch8displayIndex(){} // RVA: 0x7ffaaf0127a0
        public void Initialize_ctrlTouchscreentouch8indirectTouch(){} // RVA: 0x7ffaaf012aa0
        public void Initialize_ctrlTouchscreentouch8tap(){} // RVA: 0x7ffaaf012e00
        public void Initialize_ctrlTouchscreentouch8startTime(){} // RVA: 0x7ffaaf013160
        public void Initialize_ctrlTouchscreentouch8startPosition(){} // RVA: 0x7ffaaf013470
        public void Initialize_ctrlTouchscreentouch8positionx(){} // RVA: 0x7ffaaf013790
        public void Initialize_ctrlTouchscreentouch8positiony(){} // RVA: 0x7ffaaf013ab0
        public void Initialize_ctrlTouchscreentouch8deltaup(){} // RVA: 0x7ffaaf013dd0
        public void Initialize_ctrlTouchscreentouch8deltadown(){} // RVA: 0x7ffaaf014100
        public void Initialize_ctrlTouchscreentouch8deltaleft(){} // RVA: 0x7ffaaf014430
        public void Initialize_ctrlTouchscreentouch8deltaright(){} // RVA: 0x7ffaaf014760
        public void Initialize_ctrlTouchscreentouch8deltax(){} // RVA: 0x7ffaaf014a90
        public void Initialize_ctrlTouchscreentouch8deltay(){} // RVA: 0x7ffaaf014d90
        public void Initialize_ctrlTouchscreentouch8radiusx(){} // RVA: 0x7ffaaf015090
        public void Initialize_ctrlTouchscreentouch8radiusy(){} // RVA: 0x7ffaaf015390
        public void Initialize_ctrlTouchscreentouch8startPositionx(){} // RVA: 0x7ffaaf015690
        public void Initialize_ctrlTouchscreentouch8startPositiony(){} // RVA: 0x7ffaaf015990
        public void Initialize_ctrlTouchscreentouch9touchId(){} // RVA: 0x7ffaaf015c90
        public void Initialize_ctrlTouchscreentouch9position(){} // RVA: 0x7ffaaf015fb0
        public void Initialize_ctrlTouchscreentouch9delta(){} // RVA: 0x7ffaaf0162e0
        public void Initialize_ctrlTouchscreentouch9pressure(){} // RVA: 0x7ffaaf0165f0
        public void Initialize_ctrlTouchscreentouch9radius(){} // RVA: 0x7ffaaf0168f0
        public void Initialize_ctrlTouchscreentouch9phase(){} // RVA: 0x7ffaaf016c00
        public void Initialize_ctrlTouchscreentouch9press(){} // RVA: 0x7ffaaf016f10
        public void Initialize_ctrlTouchscreentouch9tapCount(){} // RVA: 0x7ffaaf017270
        public void Initialize_ctrlTouchscreentouch9displayIndex(){} // RVA: 0x7ffaaf017570
        public void Initialize_ctrlTouchscreentouch9indirectTouch(){} // RVA: 0x7ffaaf017870
        public void Initialize_ctrlTouchscreentouch9tap(){} // RVA: 0x7ffaaf017bd0
        public void Initialize_ctrlTouchscreentouch9startTime(){} // RVA: 0x7ffaaf017f30
        public void Initialize_ctrlTouchscreentouch9startPosition(){} // RVA: 0x7ffaaf018240
        public void Initialize_ctrlTouchscreentouch9positionx(){} // RVA: 0x7ffaaf018560
        public void Initialize_ctrlTouchscreentouch9positiony(){} // RVA: 0x7ffaaf018880
        public void Initialize_ctrlTouchscreentouch9deltaup(){} // RVA: 0x7ffaaf018ba0
        public void Initialize_ctrlTouchscreentouch9deltadown(){} // RVA: 0x7ffaaf018ed0
        public void Initialize_ctrlTouchscreentouch9deltaleft(){} // RVA: 0x7ffaaf019200
        public void Initialize_ctrlTouchscreentouch9deltaright(){} // RVA: 0x7ffaaf019530
        public void Initialize_ctrlTouchscreentouch9deltax(){} // RVA: 0x7ffaaf019860
        public void Initialize_ctrlTouchscreentouch9deltay(){} // RVA: 0x7ffaaf019b60
        public void Initialize_ctrlTouchscreentouch9radiusx(){} // RVA: 0x7ffaaf019e60
        public void Initialize_ctrlTouchscreentouch9radiusy(){} // RVA: 0x7ffaaf01a160
        public void Initialize_ctrlTouchscreentouch9startPositionx(){} // RVA: 0x7ffaaf01a460
        public void Initialize_ctrlTouchscreentouch9startPositiony(){} // RVA: 0x7ffaaf01a760
    }

    public class Gamepad : InputDevice
    {
        public object _buttonSouth; // 0x333DF8B0, was: <buttonSouth>k__BackingField
        public object _rightStickButton; // 0x333DF8B0, was: <rightStickButton>k__BackingFi
        public object _dpad; // 0x333DF8B0, was: <dpad>k__BackingField
        public object _leftStick; // 0x333DF8B0, was: <leftStick>k__BackingField
        public object _rightTrigger; // 0x333DF8B0, was: <rightTrigger>k__BackingField
        public object s_GamepadCount; // 0x333DF8B0
        public object _highFrequencyMotorSpeed; // 0x33C2D0C0, was: <highFrequencyMotorSpeed>k__Ba
        public object buttonWest; // 0x170001AA
        public object buttonNorth; // 0x170001AB
        public object buttonSouth; // 0x170001AC
        public object buttonEast; // 0x170001AD
        public object leftStickButton; // 0x170001AE

        // ── Original Methods ──
        public void get_buttonWest(){} // RVA: 0x7ffaa8f77bc0
        public void set_buttonWest(){} // RVA: 0x7ffaa93f5420
        public void get_buttonNorth(){} // RVA: 0x7ffaa8f75d50
        public void set_buttonNorth(){} // RVA: 0x7ffaa94036f0
        public void get_buttonSouth(){} // RVA: 0x7ffaa8f74750
        public void set_buttonSouth(){} // RVA: 0x7ffaa93e77a0
        public void get_buttonEast(){} // RVA: 0x7ffaa8f6f0e0
        public void set_buttonEast(){} // RVA: 0x7ffaa93ff2c0
        public void get_leftStickButton(){} // RVA: 0x7ffaa8f6f0f0
        public void set_leftStickButton(){} // RVA: 0x7ffaa93d9af0
        public void get_rightStickButton(){} // RVA: 0x7ffaa8f78130
        public void set_rightStickButton(){} // RVA: 0x7ffaa93e4fb0
        public void get_startButton(){} // RVA: 0x7ffaa8f73670
        public void set_startButton(){} // RVA: 0x7ffaa93e9360
        public void get_selectButton(){} // RVA: 0x7ffaa93d5320
        public void set_selectButton(){} // RVA: 0x7ffaa93e3d80
        public void get_dpad(){} // RVA: 0x7ffaa93d4100
        public void set_dpad(){} // RVA: 0x7ffaa93e7fd0
        public void get_leftShoulder(){} // RVA: 0x7ffaa93e8b10
        public void set_leftShoulder(){} // RVA: 0x7ffaa9400010
        public void get_rightShoulder(){} // RVA: 0x7ffaa8e19790
        public void set_rightShoulder(){} // RVA: 0x7ffaa93fdbe0
        public void get_leftStick(){} // RVA: 0x7ffaa93d15b0
        public void set_leftStick(){} // RVA: 0x7ffaa93d3cc0
        public void get_rightStick(){} // RVA: 0x7ffaa8f6fa20
        public void set_rightStick(){} // RVA: 0x7ffaa8f774b0
        public void get_leftTrigger(){} // RVA: 0x7ffaa8f74aa0
        public void set_leftTrigger(){} // RVA: 0x7ffaa8f744d0
        public void get_rightTrigger(){} // RVA: 0x7ffaa8f7aa00
        public void set_rightTrigger(){} // RVA: 0x7ffaa8f77dc0
        public void get_aButton(){} // RVA: 0x7ffaa8f74750
        public void get_bButton(){} // RVA: 0x7ffaa8f6f0e0
        public void get_xButton(){} // RVA: 0x7ffaa8f77bc0
        public void get_yButton(){} // RVA: 0x7ffaa8f75d50
        public void get_triangleButton(){} // RVA: 0x7ffaa8f75d50
        public void get_squareButton(){} // RVA: 0x7ffaa8f77bc0
        public void get_circleButton(){} // RVA: 0x7ffaa8f6f0e0
        public void get_crossButton(){} // RVA: 0x7ffaa8f74750
        public void get_Item(){} // RVA: 0x7ffaaefb21f0
        public void get_current(){} // RVA: 0x7ffaaefb2410
        public void set_current(){} // RVA: 0x7ffaaefb2450
        public void get_all(){} // RVA: 0x7ffaaefb24f0
        public void FinishSetup(){} // RVA: 0x7ffaaefb25b0
        public void MakeCurrent(){} // RVA: 0x7ffaaefb2db0
        public void OnAdded(){} // RVA: 0x7ffaaefb2dc0
        public void OnRemoved(){} // RVA: 0x7ffaaefb2e40
        public void PauseHaptics(){} // RVA: 0x7ffaaefb2fd0
        public void ResumeHaptics(){} // RVA: 0x7ffaaefb2ff0
        public void ResetHaptics(){} // RVA: 0x7ffaaefb30b0
        public void .ctor(){} // RVA: 0x7ffaaef38410
        // ── Binary Analysis Named ──
        public void SetMotorSpeeds(){} // RVA: 0x7ffaaefb3160
    }

    public class GravitySensor : Sensor
    {
        // ── Original Methods ──
        public void get_gravity(){} // RVA: 0x7ffaa8f77bc0
        public void set_gravity(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf0285e0
        public void set_current(){} // RVA: 0x7ffaaf028620
        public void FinishSetup(){} // RVA: 0x7ffaaf0286c0
        public void MakeCurrent(){} // RVA: 0x7ffaaf028770
        public void OnRemoved(){} // RVA: 0x7ffaaf028780
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class Gyroscope : Sensor
    {
        // ── Original Methods ──
        public void get_angularVelocity(){} // RVA: 0x7ffaa8f77bc0
        public void set_angularVelocity(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf0283f0
        public void set_current(){} // RVA: 0x7ffaaf028430
        public void MakeCurrent(){} // RVA: 0x7ffaaf0284d0
        public void OnRemoved(){} // RVA: 0x7ffaaf0284e0
        public void FinishSetup(){} // RVA: 0x7ffaaf028530
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class HumiditySensor : Sensor
    {
        // ── Original Methods ──
        public void get_relativeHumidity(){} // RVA: 0x7ffaa8f77bc0
        public void set_relativeHumidity(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf029370
        public void set_current(){} // RVA: 0x7ffaaf0293b0
        public void MakeCurrent(){} // RVA: 0x7ffaaf029450
        public void OnRemoved(){} // RVA: 0x7ffaaf029460
        public void FinishSetup(){} // RVA: 0x7ffaaf0294b0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class IInputActionCollection
    {
        // ── Original Methods ──
        public void get_bindingMask(){} // RVA: 0x7ffaa887e5c0
        public void set_bindingMask(){}
        public void get_devices(){} // RVA: 0x7ffaa887e5c0
        public void set_devices(){}
        public void get_controlSchemes(){}
        public void Contains(){} // RVA: 0x7ffaa864a2a0
        public void Enable(){} // RVA: 0x7ffaa8660cc0
        public void Disable(){} // RVA: 0x7ffaa8660cc0
    }

    public class IInputActionCollection2
    {
        // ── Original Methods ──
        public void get_bindings(){} // RVA: 0x7ffaa86491d0
        public void FindAction(){} // RVA: 0x7ffaa8659a30
        public void FindBinding(){}
    }

    public class IInputInteraction
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaa8660d80
        public void Reset(){} // RVA: 0x7ffaa8660cc0
    }

    public class IInputInteraction`1
    {
    }

    public class IInputInteraction`1
    {
    }

    public class InputAction : Object
    {
        public object m_Name; // 0x317B9A20
        public object m_Id; // 0x317B9A20
        public object m_SingletonActionBindings; // 0x317B9A20
        public object m_BindingsStartIndex; // 0x317B9A20
        public object m_ControlCount; // 0x317B9A20
        public object m_OnStarted; // 0x317B9A20

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa894d380
        public void get_type(){} // RVA: 0x7ffaa8b945a0
        public void get_id(){} // RVA: 0x7ffaaef3cae0
        public void get_idDontGenerate(){} // RVA: 0x7ffaaef3cb30
        public void get_expectedControlType(){} // RVA: 0x7ffaa89600c0
        public void set_expectedControlType(){} // RVA: 0x7ffaa89600d0
        public void get_processors(){} // RVA: 0x7ffaa8bfcc80
        public void get_interactions(){} // RVA: 0x7ffaa8bf45b0
        public void get_actionMap(){} // RVA: 0x7ffaaef3cc30
        public void get_bindingMask(){} // RVA: 0x7ffaac52dfa0
        public void set_bindingMask(){} // RVA: 0x7ffaaef3cc50
        public void get_bindings(){} // RVA: 0x7ffaaef3cfb0
        public void get_controls(){} // RVA: 0x7ffaaef3d0b0
        public void get_phase(){} // RVA: 0x7ffaaef3d1e0
        public void get_inProgress(){} // RVA: 0x7ffaaef3d240
        public void get_enabled(){} // RVA: 0x7ffaaef3d2a0
        public void add_started(){} // RVA: 0x7ffaaef3d300
        public void remove_started(){} // RVA: 0x7ffaaef3d360
        public void add_canceled(){} // RVA: 0x7ffaaef3d3c0
        public void remove_canceled(){} // RVA: 0x7ffaaef3d420
        public void add_performed(){} // RVA: 0x7ffaaef3d480
        public void remove_performed(){} // RVA: 0x7ffaaef3d4e0
        public void get_triggered(){} // RVA: 0x7ffaaef3d540
        public void get_activeControl(){} // RVA: 0x7ffaaef3d5e0
        public void get_activeValueType(){} // RVA: 0x7ffaaef3d660
        public void get_wantsInitialStateCheck(){} // RVA: 0x7ffaaef3d6d0
        public void set_wantsInitialStateCheck(){} // RVA: 0x7ffaaef3d6f0
        public void .ctor(){} // RVA: 0x7ffaaef3d800
        public void .ctor(){} // RVA: 0x7ffaaef3d800
        public void Dispose(){} // RVA: 0x7ffaaef3ddd0
        public void ToString(){} // RVA: 0x7ffaaef3ddf0
        public void Enable(){} // RVA: 0x7ffaaef3e100
        public void Disable(){} // RVA: 0x7ffaaef3e440
        public void Clone(){} // RVA: 0x7ffaaef3e740
        public void System.ICloneable.Clone(){} // RVA: 0x7ffaaef3e9f0
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueAsObject(){} // RVA: 0x7ffaaef3ea00
        public void Reset(){} // RVA: 0x7ffaaef3eae0
        public void IsPressed(){} // RVA: 0x7ffaaef3eb80
        public void IsInProgress(){} // RVA: 0x7ffaaef3ebe0
        public void ExpectedFrame(){} // RVA: 0x7ffaaef3ec50
        public void WasPressedThisFrame(){} // RVA: 0x7ffaaef3ed00
        public void WasPressedThisDynamicUpdate(){} // RVA: 0x7ffaaef3eda0
        public void WasReleasedThisFrame(){} // RVA: 0x7ffaaef3ee10
        public void WasReleasedThisDynamicUpdate(){} // RVA: 0x7ffaaef3eeb0
        public void WasPerformedThisFrame(){} // RVA: 0x7ffaaef3d540
        public void WasPerformedThisDynamicUpdate(){} // RVA: 0x7ffaaef3ef20
        public void WasCompletedThisFrame(){} // RVA: 0x7ffaaef3ef90
        public void WasCompletedThisDynamicUpdate(){} // RVA: 0x7ffaaef3f030
        public void get_isSingletonAction(){} // RVA: 0x7ffaaef3f1e0
        public void get_currentState(){} // RVA: 0x7ffaaef3f200
        public void MakeSureIdIsInPlace(){} // RVA: 0x7ffaaef3f290
        public void GenerateId(){} // RVA: 0x7ffaaef3f2c0
        public void CreateInternalActionMapForSingletonAction(){} // RVA: 0x7ffaaef3f3e0
        public void RequestInitialStateCheckOnEnabledAction(){} // RVA: 0x7ffaaef3f620
        public void ActiveControlIsValid(){} // RVA: 0x7ffaaef3f6f0
        public void FindEffectiveBindingMask(){} // RVA: 0x7ffaaef3f7f0
        public void BindingIndexOnActionToBindingIndexOnMap(){} // RVA: 0x7ffaaef3f920
        public void BindingIndexOnMapToBindingIndexOnAction(){} // RVA: 0x7ffaaef3fad0
        public void .cctor(){} // RVA: 0x7ffaaef3fc60
        // ── Binary Analysis Named ──
        public void GetControlMagnitude(){} // RVA: 0x7ffaaef3ea80
        public void GetTimeoutCompletionPercentage(){} // RVA: 0x7ffaaef3f0a0
        public void GetOrCreateActionMap(){} // RVA: 0x7ffaaef3f3a0
    }

    public class InputActionAsset : ScriptableObject
    {
        public object m_ActionMaps; // 0x33613970
        public object m_SharedStateForAllMaps; // 0x33613970
        public object m_ParameterOverrides; // 0x33613970

        // ── Original Methods ──
        public void get_enabled(){} // RVA: 0x7ffaaef409b0
        public void get_actionMaps(){} // RVA: 0x7ffaaef40b80
        public void get_controlSchemes(){} // RVA: 0x7ffaaef40c40
        public void get_bindings(){} // RVA: 0x7ffaaef40d00
        public void get_bindingMask(){} // RVA: 0x7ffaaef40db0
        public void set_bindingMask(){} // RVA: 0x7ffaaef40df0
        public void get_devices(){} // RVA: 0x7ffaaef41010
        public void set_devices(){} // RVA: 0x7ffaaef41050
        public void get_Item(){} // RVA: 0x7ffaaef410d0
        public void ToJson(){} // RVA: 0x7ffaaef41160
        public void LoadFromJson(){} // RVA: 0x7ffaaef41450
        public void FromJson(){} // RVA: 0x7ffaaef41610
        public void FindAction(){} // RVA: 0x7ffaaef421e0
        public void FindBinding(){} // RVA: 0x7ffaaef41c70
        public void FindActionMap(){} // RVA: 0x7ffaaef420d0
        public void FindActionMap(){} // RVA: 0x7ffaaef420d0
        public void FindAction(){} // RVA: 0x7ffaaef421e0
        public void FindControlSchemeIndex(){} // RVA: 0x7ffaaef42360
        public void FindControlScheme(){} // RVA: 0x7ffaaef42500
        public void IsUsableWithDevice(){} // RVA: 0x7ffaaef42680
        public void Enable(){} // RVA: 0x7ffaaef427e0
        public void Disable(){} // RVA: 0x7ffaaef429f0
        public void Contains(){} // RVA: 0x7ffaaef42bc0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaef42de0
        public void MarkAsDirty(){} // RVA: 0x7ffaa8932310
        public void IsEmpty(){} // RVA: 0x7ffaaef42df0
        public void OnWantToChangeSetup(){} // RVA: 0x7ffaaef42e80
        public void OnSetupChanged(){} // RVA: 0x7ffaaef42ef0
        public void ReResolveIfNecessary(){} // RVA: 0x7ffaaef42fc0
        public void ResolveBindingsIfNecessary(){} // RVA: 0x7ffaaef43000
        public void OnDestroy(){} // RVA: 0x7ffaaef430a0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaaef42d40
    }

    public class InputActionMap : Object
    {
        public object m_Id; // 0x338ECE00
        public object m_Bindings; // 0x338ECE00
        public object m_EnabledActionsCount; // 0x338ECE00
        public object m_State; // 0x338ECE00
        public object m_ParameterOverridesCount; // 0x338ECE00
        public object m_ActionCallbacks; // 0x338ECE00
        public object s_NeedToResolveBindings; // 0x338ECE00

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa894d380
        public void get_asset(){} // RVA: 0x7ffaa89600c0
        public void get_id(){} // RVA: 0x7ffaaef43a10
        public void get_idDontGenerate(){} // RVA: 0x7ffaaef43a60
        public void get_enabled(){} // RVA: 0x7ffaae8b8980
        public void get_actions(){} // RVA: 0x7ffaaef43b60
        public void get_bindings(){} // RVA: 0x7ffaaef43c20
        public void UnityEngine.InputSystem.IInputActionCollection2.get_bindings(){} // RVA: 0x7ffaaef43ce0
        public void get_controlSchemes(){} // RVA: 0x7ffaaef43d40
        public void get_bindingMask(){} // RVA: 0x7ffaaef43e50
        public void set_bindingMask(){} // RVA: 0x7ffaaef43e90
        public void get_devices(){} // RVA: 0x7ffaaef440a0
        public void set_devices(){} // RVA: 0x7ffaaef44180
        public void get_Item(){} // RVA: 0x7ffaaef441d0
        public void add_actionTriggered(){} // RVA: 0x7ffaaef442e0
        public void remove_actionTriggered(){} // RVA: 0x7ffaaef44340
        public void .ctor(){} // RVA: 0x7ffaaef44410
        public void .ctor(){} // RVA: 0x7ffaaef44410
        public void Dispose(){} // RVA: 0x7ffaaef444d0
        public void FindActionIndex(){} // RVA: 0x7ffaaef44a30
        public void ClearActionLookupTable(){} // RVA: 0x7ffaaef449e0
        public void FindActionIndex(){} // RVA: 0x7ffaaef44a30
        public void FindAction(){} // RVA: 0x7ffaaef44c70
        public void FindAction(){} // RVA: 0x7ffaaef44c70
        public void IsUsableWithDevice(){} // RVA: 0x7ffaaef44da0
        public void Enable(){} // RVA: 0x7ffaaef44ea0
        public void Disable(){} // RVA: 0x7ffaaef44f10
        public void Clone(){} // RVA: 0x7ffaaef44f40
        public void System.ICloneable.Clone(){} // RVA: 0x7ffaaef45510
        public void Contains(){} // RVA: 0x7ffaaef45520
        public void ToString(){} // RVA: 0x7ffaaef45550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaaef456b0
        public void get_needToResolveBindings(){} // RVA: 0x7ffaaef457e0
        public void set_needToResolveBindings(){} // RVA: 0x7ffaaef457f0
        public void get_bindingResolutionNeedsFullReResolve(){} // RVA: 0x7ffaaef45810
        public void set_bindingResolutionNeedsFullReResolve(){} // RVA: 0x7ffaaef45820
        public void get_controlsForEachActionInitialized(){} // RVA: 0x7ffaaef45840
        public void set_controlsForEachActionInitialized(){} // RVA: 0x7ffaaef45850
        public void get_bindingsForEachActionInitialized(){} // RVA: 0x7ffaaef45870
        public void set_bindingsForEachActionInitialized(){} // RVA: 0x7ffaaef45880
        public void OnWantToChangeSetup(){} // RVA: 0x7ffaaef467e0
        public void OnSetupChanged(){} // RVA: 0x7ffaaef46b50
        public void OnBindingModified(){} // RVA: 0x7ffaaef46ec0
        public void ClearCachedActionData(){} // RVA: 0x7ffaaef46ef0
        public void GenerateId(){} // RVA: 0x7ffaaef47010
        public void LazyResolveBindings(){} // RVA: 0x7ffaaef470f0
        public void ResolveBindingsIfNecessary(){} // RVA: 0x7ffaaef47230
        public void ResolveBindings(){} // RVA: 0x7ffaaef47270
        public void FindBinding(){} // RVA: 0x7ffaaef48440
        public void FindBindingRelativeToMap(){} // RVA: 0x7ffaaef48770
        public void FromJson(){} // RVA: 0x7ffaaef48820
        public void ToJson(){} // RVA: 0x7ffaaef48a70
        public void ToJson(){} // RVA: 0x7ffaaef48a70
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void OnAfterDeserialize(){} // RVA: 0x7ffaaef48bf0
        public void .cctor(){} // RVA: 0x7ffaaef48db0
        // ── Binary Analysis Named ──
        public void SetUpActionLookupTable(){} // RVA: 0x7ffaaef447e0
        public void GetEnumerator(){} // RVA: 0x7ffaaef456b0
        public void GetBindingsForSingleAction(){} // RVA: 0x7ffaaef458a0
        public void GetControlsForSingleAction(){} // RVA: 0x7ffaaef45980
        public void SetUpPerActionControlAndBindingArrays(){} // RVA: 0x7ffaaef45a60
    }

    public class InputActionProperty : ValueType
    {
        public object m_Reference; // 0x333FD3B0
        public object action; // 0x170000D1

        // ── Original Methods ──
        public void get_action(){} // RVA: 0x7ffaaef5a4e0
        public void get_reference(){} // RVA: 0x7ffaaef5a5e0
        public void get_serializedAction(){} // RVA: 0x7ffaa9e47540
        public void get_serializedReference(){} // RVA: 0x7ffaa894d380
        public void .ctor(){} // RVA: 0x7ffaaef5a6a0
        public void .ctor(){} // RVA: 0x7ffaaef5a6a0
        public void Equals(){} // RVA: 0x7ffaaef5aa10
        public void Equals(){} // RVA: 0x7ffaaef5aa10
        public void Equals(){} // RVA: 0x7ffaaef5aa10
        public void Equals(){} // RVA: 0x7ffaaef5aa10
        public void op_Equality(){} // RVA: 0x7ffaaef5ac10
        public void op_Inequality(){} // RVA: 0x7ffaaef5ac40
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaef5aaf0
    }

    public class InputActionRebindingExtensions : Object
    {
        // ── Original Methods ──
        public void ApplyParameterOverride(){} // RVA: 0x7ffaaef4d9a0
        public void ApplyParameterOverride(){} // RVA: 0x7ffaaef4d9a0
        public void ApplyParameterOverride(){} // RVA: 0x7ffaaef4d9a0
        public void ExtractParameterOverride(){} // RVA: 0x7ffaa887e5c0
        public void ApplyParameterOverride(){} // RVA: 0x7ffaaef4d9a0
        public void ApplyParameterOverride(){} // RVA: 0x7ffaaef4d9a0
        public void ApplyParameterOverride(){} // RVA: 0x7ffaaef4d9a0
        public void ApplyParameterOverride(){} // RVA: 0x7ffaaef4d9a0
        public void ApplyParameterOverride(){} // RVA: 0x7ffaaef4d9a0
        public void ApplyBindingOverride(){} // RVA: 0x7ffaaef50a40
        public void ApplyBindingOverride(){} // RVA: 0x7ffaaef50a40
        public void ApplyBindingOverride(){} // RVA: 0x7ffaaef50a40
        public void ApplyBindingOverride(){} // RVA: 0x7ffaaef50a40
        public void ApplyBindingOverride(){} // RVA: 0x7ffaaef50a40
        public void ApplyBindingOverride(){} // RVA: 0x7ffaaef50a40
        public void RemoveBindingOverride(){} // RVA: 0x7ffaaef50eb0
        public void RemoveBindingOverride(){} // RVA: 0x7ffaaef50eb0
        public void RemoveBindingOverride(){} // RVA: 0x7ffaaef50eb0
        public void RemoveAllBindingOverrides(){} // RVA: 0x7ffaaef51360
        public void RemoveAllBindingOverrides(){} // RVA: 0x7ffaaef51360
        public void ApplyBindingOverrides(){} // RVA: 0x7ffaaef51570
        public void RemoveBindingOverrides(){} // RVA: 0x7ffaaef51830
        public void ApplyBindingOverridesOnMatchingControls(){} // RVA: 0x7ffaaef51f80
        public void ApplyBindingOverridesOnMatchingControls(){} // RVA: 0x7ffaaef51f80
        public void SaveBindingOverridesAsJson(){} // RVA: 0x7ffaaef524d0
        public void SaveBindingOverridesAsJson(){} // RVA: 0x7ffaaef524d0
        public void AddBindingOverrideJsonTo(){} // RVA: 0x7ffaaef52980
        public void LoadBindingOverridesFromJson(){} // RVA: 0x7ffaaef52cb0
        public void LoadBindingOverridesFromJson(){} // RVA: 0x7ffaaef52cb0
        public void LoadBindingOverridesFromJsonInternal(){} // RVA: 0x7ffaaef52df0
        public void PerformInteractiveRebinding(){} // RVA: 0x7ffaaef53500
        public void DeferBindingResolution(){} // RVA: 0x7ffaaef53b60
        // ── Binary Analysis Named ──
        public void GetParameterValue(){} // RVA: 0x7ffaa887e5c0
        public void GetParameterValue(){} // RVA: 0x7ffaa887e5c0
        public void GetParameterValue(){} // RVA: 0x7ffaa887e5c0
        public void GetParameterValue(){} // RVA: 0x7ffaa887e5c0
        public void GetBindingIndex(){} // RVA: 0x7ffaaef4eab0
        public void GetBindingIndex(){} // RVA: 0x7ffaaef4eab0
        public void GetBindingIndex(){} // RVA: 0x7ffaaef4eab0
        public void GetBindingForControl(){} // RVA: 0x7ffaaef4ebe0
        public void GetBindingIndexForControl(){} // RVA: 0x7ffaaef4eec0
        public void GetBindingDisplayString(){} // RVA: 0x7ffaaef4f7c0
        public void GetBindingDisplayString(){} // RVA: 0x7ffaaef4f7c0
        public void GetBindingDisplayString(){} // RVA: 0x7ffaaef4f7c0
        public void GetBindingDisplayString(){} // RVA: 0x7ffaaef4f7c0
    }

    public class InputActionReference : ScriptableObject
    {
        public object m_Action; // 0x33CEE250
        public object asset; // 0x170000D5

        // ── Original Methods ──
        public void get_asset(){} // RVA: 0x7ffaa89357c0
        public void get_action(){} // RVA: 0x7ffaaef5ac70
        public void ToString(){} // RVA: 0x7ffaaef5b8d0
        public void ToDisplayName(){} // RVA: 0x7ffaaef5bb90
        public void op_Implicit(){} // RVA: 0x7ffaaef5bc40
        public void Create(){} // RVA: 0x7ffaaef5bc50
        public void ResetCachedAction(){} // RVA: 0x7ffaaef5bcd0
        public void ToInputAction(){} // RVA: 0x7ffaaef5beb0
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        // ── Binary Analysis Named ──
        public void Set(){} // RVA: 0x7ffaaef5b1a0
        public void Set(){} // RVA: 0x7ffaaef5b1a0
        public void SetInternal(){} // RVA: 0x7ffaaef5b4f0
        public void GetDisplayName(){} // RVA: 0x7ffaaef5bb10
    }

    public class InputActionSetupExtensions : Object
    {
        // ── Original Methods ──
        public void AddActionMap(){} // RVA: 0x7ffaaef5c120
        public void AddActionMap(){} // RVA: 0x7ffaaef5c120
        public void RemoveActionMap(){} // RVA: 0x7ffaaef5c760
        public void RemoveActionMap(){} // RVA: 0x7ffaaef5c760
        public void AddAction(){} // RVA: 0x7ffaaef5c8f0
        public void RemoveAction(){} // RVA: 0x7ffaaef5d540
        public void RemoveAction(){} // RVA: 0x7ffaaef5d540
        public void AddBinding(){} // RVA: 0x7ffaaef5e440
        public void AddBinding(){} // RVA: 0x7ffaaef5e440
        public void AddBinding(){} // RVA: 0x7ffaaef5e440
        public void AddBinding(){} // RVA: 0x7ffaaef5e440
        public void AddBinding(){} // RVA: 0x7ffaaef5e440
        public void AddBinding(){} // RVA: 0x7ffaaef5e440
        public void AddBinding(){} // RVA: 0x7ffaaef5e440
        public void AddCompositeBinding(){} // RVA: 0x7ffaaef5e590
        public void AddBindingInternal(){} // RVA: 0x7ffaaef5e920
        public void ChangeBinding(){} // RVA: 0x7ffaaef5f5d0
        public void ChangeBinding(){} // RVA: 0x7ffaaef5f5d0
        public void ChangeBinding(){} // RVA: 0x7ffaaef5f5d0
        public void ChangeBindingWithId(){} // RVA: 0x7ffaaef5f160
        public void ChangeBindingWithId(){} // RVA: 0x7ffaaef5f160
        public void ChangeBindingWithGroup(){} // RVA: 0x7ffaaef5f2f0
        public void ChangeBindingWithPath(){} // RVA: 0x7ffaaef5f460
        public void ChangeBinding(){} // RVA: 0x7ffaaef5f5d0
        public void ChangeCompositeBinding(){} // RVA: 0x7ffaaef5f930
        public void Rename(){} // RVA: 0x7ffaaef5fd20
        public void AddControlScheme(){} // RVA: 0x7ffaaef60480
        public void AddControlScheme(){} // RVA: 0x7ffaaef60480
        public void RemoveControlScheme(){} // RVA: 0x7ffaaef60770
        public void WithBindingGroup(){} // RVA: 0x7ffaaef609e0
        public void WithDevice(){} // RVA: 0x7ffaaef60b60
        public void WithRequiredDevice(){} // RVA: 0x7ffaaef60d80
        public void WithOptionalDevice(){} // RVA: 0x7ffaaef60ee0
        public void OrWithRequiredDevice(){} // RVA: 0x7ffaaef61040
        public void OrWithOptionalDevice(){} // RVA: 0x7ffaaef611a0
    }

    public class InputActionState : Object
    {
        public object controls; // 0x317BA2F0
        public object composites; // 0x317BA2F0
        public object m_OnBeforeUpdateHooked; // 0x317BA2F0
        public object m_CurrentlyProcessingThisEvent; // 0x317BA2F0
        public object k_InputInitialActionStateCheckMarker; // 0x317BA2F0
        public object k_InputOnActionChangeMarker; // 0x317BA2F0
        public object basePtr; // 0x8191A6F0
        public object interactionCount; // 0x8191A6F0
        public object compositeCount; // 0x8191A6F0
        public object interactionStates; // 0x8191A6F0

        // ── Original Methods ──
        public void get_totalCompositeCount(){} // RVA: 0x7ffaa8b6e710
        public void get_totalMapCount(){} // RVA: 0x7ffaa89d30c0
        public void get_totalActionCount(){} // RVA: 0x7ffaa99531a0
        public void get_totalBindingCount(){} // RVA: 0x7ffaa92bf840
        public void get_totalInteractionCount(){} // RVA: 0x7ffaa8b023d0
        public void get_totalControlCount(){} // RVA: 0x7ffaa905bf10
        public void get_mapIndices(){} // RVA: 0x7ffaa899d0b0
        public void get_actionStates(){} // RVA: 0x7ffaa89d0370
        public void get_bindingStates(){} // RVA: 0x7ffaa89add50
        public void get_interactionStates(){} // RVA: 0x7ffaa89fa590
        public void get_controlIndexToBindingIndex(){} // RVA: 0x7ffaa8f78170
        public void get_controlGroupingAndComplexity(){} // RVA: 0x7ffaa8f74720
        public void get_controlMagnitudes(){} // RVA: 0x7ffaa8af68f0
        public void get_enabledControls(){} // RVA: 0x7ffaa8971010
        public void get_isProcessingControlStateChange(){} // RVA: 0x7ffaaea8d790
        public void Initialize(){} // RVA: 0x7ffaaef64710
        public void ComputeControlGroupingIfNecessary(){} // RVA: 0x7ffaaef64830
        public void ClaimDataFrom(){} // RVA: 0x7ffaaef64a30
        public void Finalize(){} // RVA: 0x7ffaaef64c80
        public void Dispose(){} // RVA: 0x7ffaaef64cf0
        public void Destroy(){} // RVA: 0x7ffaaef64d00
        public void Clone(){} // RVA: 0x7ffaaef65070
        public void System.ICloneable.Clone(){} // RVA: 0x7ffaaef653a0
        public void IsUsingDevice(){} // RVA: 0x7ffaaef653b0
        public void CanUseDevice(){} // RVA: 0x7ffaaef65540
        public void HasEnabledActions(){} // RVA: 0x7ffaaef65810
        public void FinishBindingCompositeSetups(){} // RVA: 0x7ffaaef65870
        public void PrepareForBindingReResolution(){} // RVA: 0x7ffaaef659b0
        public void FinishBindingResolution(){} // RVA: 0x7ffaaef65ee0
        public void RestoreActionStatesAfterReResolvingBindings(){} // RVA: 0x7ffaaef660e0
        public void IsActiveControl(){} // RVA: 0x7ffaaef669d0
        public void FindControlIndexOnBinding(){} // RVA: 0x7ffaaef66a90
        public void ResetActionStatesDrivenBy(){} // RVA: 0x7ffaaef66b00
        public void IsActionBoundToControlFromDevice(){} // RVA: 0x7ffaaef66c70
        public void ResetActionState(){} // RVA: 0x7ffaaef66d80
        public void FetchActionState(){} // RVA: 0x7ffaaef66fd0
        public void FetchMapIndices(){} // RVA: 0x7ffaaef67000
        public void EnableAllActions(){} // RVA: 0x7ffaaef67050
        public void EnableControls(){} // RVA: 0x7ffaaef679d0
        public void EnableSingleAction(){} // RVA: 0x7ffaaef67220
        public void EnableControls(){} // RVA: 0x7ffaaef679d0
        public void DisableAllActions(){} // RVA: 0x7ffaaef6dc40
        public void DisableControls(){} // RVA: 0x7ffaaef67bb0
        public void DisableSingleAction(){} // RVA: 0x7ffaaef67730
        public void DisableControls(){} // RVA: 0x7ffaaef67bb0
        public void EnableControls(){} // RVA: 0x7ffaaef679d0
        public void DisableControls(){} // RVA: 0x7ffaaef67bb0
        public void IsControlEnabled(){} // RVA: 0x7ffaaef67e80
        public void HookOnBeforeUpdate(){} // RVA: 0x7ffaaef67f00
        public void UnhookOnBeforeUpdate(){} // RVA: 0x7ffaaef68080
        public void OnBeforeInitialUpdate(){} // RVA: 0x7ffaaef68150
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7ffaaef68510
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7ffaaef68560
        public void ToCombinedMapAndControlAndBindingIndex(){} // RVA: 0x7ffaaef685b0
        public void SplitUpMapAndControlAndBindingIndex(){} // RVA: 0x7ffaaef685f0
        public void ProcessControlStateChange(){} // RVA: 0x7ffaaef68630
        public void ProcessButtonState(){} // RVA: 0x7ffaaef68de0
        public void ShouldIgnoreInputOnCompositeBinding(){} // RVA: 0x7ffaaef69030
        public void IsConflictingInput(){} // RVA: 0x7ffaaef69050
        public void ProcessDefaultInteraction(){} // RVA: 0x7ffaaef69590
        public void ProcessInteractions(){} // RVA: 0x7ffaaef69950
        public void ProcessTimeout(){} // RVA: 0x7ffaaef69be0
        public void StartTimeout(){} // RVA: 0x7ffaaef6a000
        public void StopTimeout(){} // RVA: 0x7ffaaef6a1b0
        public void ChangePhaseOfInteraction(){} // RVA: 0x7ffaaef6a290
        public void ChangePhaseOfAction(){} // RVA: 0x7ffaaef6a840
        public void ChangePhaseOfActionInternal(){} // RVA: 0x7ffaaef6aab0
        public void CallActionListeners(){} // RVA: 0x7ffaaef6adf0
        public void ResetInteractionStateAndCancelIfNecessary(){} // RVA: 0x7ffaaef6b4a0
        public void ResetInteractionState(){} // RVA: 0x7ffaaef6b580
        public void IsActuated(){} // RVA: 0x7ffaaef6b7d0
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void ApplyProcessors(){} // RVA: 0x7ffaa887e5c0
        public void EvaluateCompositePartMagnitude(){} // RVA: 0x7ffaaef6bb10
        public void ReadCompositePartValue(){} // RVA: 0x7ffaaef6bc80
        public void ReadCompositePartValue(){} // RVA: 0x7ffaaef6bc80
        public void ReadCompositePartValueAsObject(){} // RVA: 0x7ffaaef6bdd0
        public void ReadValueAsObject(){} // RVA: 0x7ffaaef6bf00
        public void ReadValueAsButton(){} // RVA: 0x7ffaaef6c180
        public void SaveAndResetState(){} // RVA: 0x7ffaaef6c2f0
        public void AddToGlobalList(){} // RVA: 0x7ffaaef6c8d0
        public void RemoveMapFromGlobalList(){} // RVA: 0x7ffaaef6c960
        public void CompactGlobalList(){} // RVA: 0x7ffaaef6cb10
        public void NotifyListenersOfActionChange(){} // RVA: 0x7ffaaef6cf30
        public void NotifyListenersOfActionChange(){} // RVA: 0x7ffaaef6cf30
        public void ResetGlobals(){} // RVA: 0x7ffaaef6d060
        public void FindAllEnabledActions(){} // RVA: 0x7ffaaef6d290
        public void OnDeviceChange(){} // RVA: 0x7ffaaef6d570
        public void DeferredResolutionOfBindings(){} // RVA: 0x7ffaaef6d910
        public void DisableAllActions(){} // RVA: 0x7ffaaef6dc40
        public void DestroyAllActionMapStates(){} // RVA: 0x7ffaaef6ddd0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaef6e020
        // ── Binary Analysis Named ──
        public void SetInitialStateCheckPending(){} // RVA: 0x7ffaaef67e40
        public void SetInitialStateCheckPending(){} // RVA: 0x7ffaaef67e40
        public void SetControlEnabled(){} // RVA: 0x7ffaaef67ec0
        public void GetComplexityFromMonitorIndex(){} // RVA: 0x7ffaaef68620
        public void GetActionBindingStartIndexAndCount(){} // RVA: 0x7ffaaef69560
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x7ffaaef69fc0
        public void GetActionOrNoneString(){} // RVA: 0x7ffaaef6b110
        public void GetActionOrNull(){} // RVA: 0x7ffaaef6b210
        public void GetActionOrNull(){} // RVA: 0x7ffaaef6b210
        public void GetControl(){} // RVA: 0x7ffaaef6b2b0
        public void GetInteractionOrNull(){} // RVA: 0x7ffaaef6b300
        public void GetBindingIndexInMap(){} // RVA: 0x7ffaaef6b340
        public void GetBindingIndexInState(){} // RVA: 0x7ffaaef6b390
        public void GetBindingState(){} // RVA: 0x7ffaaef6b3d0
        public void GetBinding(){} // RVA: 0x7ffaaef6b3e0
        public void GetActionMap(){} // RVA: 0x7ffaaef6b460
        public void GetValueSizeInBytes(){} // RVA: 0x7ffaaef6b650
        public void GetValueType(){} // RVA: 0x7ffaaef6b710
        public void GetCompositePartPressTime(){} // RVA: 0x7ffaaef6bc00
    }

    public class InputBinding : ValueType
    {
        public object m_Name; // 0x317B9D40
        public object m_Interactions; // 0x317B9D40
        public object m_Action; // 0x317B9D40
        public object m_OverrideInteractions; // 0x317B9D40
        public object m_DeviceCount; // 0x33B3ED30
        public object enabled; // 0x170000A7

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa950bda0
        public void set_name(){} // RVA: 0x7ffaa930eca0
        public void get_id(){} // RVA: 0x7ffaaef6f7d0
        public void set_id(){} // RVA: 0x7ffaaef6f8d0
        public void get_path(){} // RVA: 0x7ffaa894d380
        public void set_path(){} // RVA: 0x7ffaa8933e30
        public void get_overridePath(){} // RVA: 0x7ffaa89af740
        public void set_overridePath(){} // RVA: 0x7ffaa895a200
        public void get_interactions(){} // RVA: 0x7ffaa89357c0
        public void set_interactions(){} // RVA: 0x7ffaa8998e80
        public void get_overrideInteractions(){} // RVA: 0x7ffaa89ad730
        public void set_overrideInteractions(){} // RVA: 0x7ffaa89ad740
        public void get_processors(){} // RVA: 0x7ffaa89600c0
        public void set_processors(){} // RVA: 0x7ffaa89600d0
        public void get_overrideProcessors(){} // RVA: 0x7ffaa89d30e0
        public void set_overrideProcessors(){} // RVA: 0x7ffaa8a8a4d0
        public void get_groups(){} // RVA: 0x7ffaa8960130
        public void set_groups(){} // RVA: 0x7ffaa8933e90
        public void get_action(){} // RVA: 0x7ffaa8bfcc80
        public void set_action(){} // RVA: 0x7ffaa8960890
        public void get_isComposite(){} // RVA: 0x7ffaaef6f970
        public void set_isComposite(){} // RVA: 0x7ffaaef6f980
        public void get_isPartOfComposite(){} // RVA: 0x7ffaaef6f9a0
        public void set_isPartOfComposite(){} // RVA: 0x7ffaaef6f9b0
        public void get_hasOverrides(){} // RVA: 0x7ffaaef6f9d0
        public void .ctor(){} // RVA: 0x7ffaaef6f9f0
        public void GenerateId(){} // RVA: 0x7ffaaef6fdc0
        public void RemoveOverrides(){} // RVA: 0x7ffaaef6fea0
        public void MaskByGroup(){} // RVA: 0x7ffaaef6ffa0
        public void MaskByGroups(){} // RVA: 0x7ffaaef70020
        public void get_effectivePath(){} // RVA: 0x7ffaaef70250
        public void get_effectiveInteractions(){} // RVA: 0x7ffaaef70260
        public void get_effectiveProcessors(){} // RVA: 0x7ffaaef70270
        public void get_isEmpty(){} // RVA: 0x7ffaaef70280
        public void Equals(){} // RVA: 0x7ffaaef70670
        public void Equals(){} // RVA: 0x7ffaaef70670
        public void op_Equality(){} // RVA: 0x7ffaaef70740
        public void op_Inequality(){} // RVA: 0x7ffaaef70790
        public void ToString(){} // RVA: 0x7ffaaef70950
        public void ToDisplayString(){} // RVA: 0x7ffaaef70ab0
        public void ToDisplayString(){} // RVA: 0x7ffaaef70ab0
        public void TriggersAction(){} // RVA: 0x7ffaaef70fb0
        public void Matches(){} // RVA: 0x7ffaaef710f0
        public void Matches(){} // RVA: 0x7ffaaef710f0
        // ── Binary Analysis Named ──
        public void GetNameOfComposite(){} // RVA: 0x7ffaaef6fd20
        public void GetHashCode(){} // RVA: 0x7ffaaef70820
    }

    public class InputBindingComposite : Object
    {
        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaa86491d0
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa8649ca0
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueAsObject(){} // RVA: 0x7ffaa8649280
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef71320
        public void FinishSetup(){} // RVA: 0x7ffaa8932310
        public void CallFinishSetup(){} // RVA: 0x7ffaaedb3490
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetValueType(){} // RVA: 0x7ffaaef71330
        public void GetExpectedControlLayoutName(){} // RVA: 0x7ffaaef71470
        public void GetPartNames(){} // RVA: 0x7ffaaef71610
        public void GetDisplayFormatString(){} // RVA: 0x7ffaaef716c0
    }

    public class InputBindingCompositeContext : ValueType
    {
        public object m_ControlCount; // 0x8191AB80

        // ── Original Methods ──
        public void get_controls(){} // RVA: 0x7ffaaef978b0
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef97960
        public void ReadValue(){} // RVA: 0x7ffaaef97b00
        public void ReadValue(){} // RVA: 0x7ffaaef97b00
        public void ReadValue(){} // RVA: 0x7ffaaef97b00
        public void ReadValue(){} // RVA: 0x7ffaaef97b00
        public void ReadValueAsButton(){} // RVA: 0x7ffaaef97a60
        public void ReadValue(){} // RVA: 0x7ffaaef97b00
        public void ReadValueAsObject(){} // RVA: 0x7ffaaef97c50
        // ── Binary Analysis Named ──
        public void GetPressTime(){} // RVA: 0x7ffaaef97d90
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaa86491d0
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa8649ca0
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueAsObject(){} // RVA: 0x7ffaa8649280
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8dbcc0
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa90e5cf0
        public void ReadValue(){} // RVA: 0x7ffaab8dbd70
        public void ReadValue(){} // RVA: 0x7ffaab8dbd70
        public void ReadValueAsObject(){} // RVA: 0x7ffaab8dbec0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8dbf30
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa92584b0
        public void ReadValue(){} // RVA: 0x7ffaab8dbfe0
        public void ReadValue(){} // RVA: 0x7ffaab8dbfe0
        public void ReadValueAsObject(){} // RVA: 0x7ffaab8dc130
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8dc1a0
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaaad0d500
        public void ReadValue(){} // RVA: 0x7ffaab8dc250
        public void ReadValue(){} // RVA: 0x7ffaab8dc250
        public void ReadValueAsObject(){} // RVA: 0x7ffaab8dc3c0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputBindingResolver : ValueType
    {
        public object totalInteractionCount; // 0x317BA630
        public object memory; // 0x317BA630
        public object composites; // 0x317BA630
        public object m_Parameters; // 0x317BA630
        public object totalMapCount; // 0x17000140
        public object totalActionCount; // 0x17000141
        public object totalBindingCount; // 0x17000142
        public object totalControlCount; // 0x17000143

        // ── Original Methods ──
        public void get_totalMapCount(){} // RVA: 0x7ffaa8d14570
        public void get_totalActionCount(){} // RVA: 0x7ffaa96cc980
        public void get_totalBindingCount(){} // RVA: 0x7ffaa950c6d0
        public void get_totalControlCount(){} // RVA: 0x7ffaa8fb82b0
        public void Dispose(){} // RVA: 0x7ffaaef98120
        public void StartWithPreviousResolve(){} // RVA: 0x7ffaaef98130
        public void AddActionMap(){} // RVA: 0x7ffaaef98560
        public void InstantiateWithParameters(){} // RVA: 0x7ffaa887e5c0
        public void InstantiateBindingComposite(){} // RVA: 0x7ffaaef9a1d0
        public void ApplyParameters(){} // RVA: 0x7ffaaef9a560
        public void AssignCompositePartIndex(){} // RVA: 0x7ffaaef9aa70
    }

    public class InputControl : Object
    {
        public object m_Path; // 0x3106F5A0
        public object m_ShortDisplayName; // 0x3106F5A0
        public object m_Variants; // 0x3106F5A0
        public object m_UsageCount; // 0x3106F5A0
        public object m_AliasStartIndex; // 0x3106F5A0
        public object m_ControlFlags; // 0x3106F5A0
        public object m_DefaultState; // 0x3106F5A0
        public object m_OptimizedControlDataType; // 0x3106F5A0
        public object FormatInvalid; // 0x33C7ED20
        public object kFormatBit; // 0x33C7ED20
        public object FormatInt; // 0x33C7ED20
        public object kFormatUInt; // 0x33C7ED20

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaaefa5be0
        public void get_displayName(){} // RVA: 0x7ffaaefa5c40
        public void set_displayName(){} // RVA: 0x7ffaa8bf45c0
        public void get_shortDisplayName(){} // RVA: 0x7ffaaefa5ce0
        public void set_shortDisplayName(){} // RVA: 0x7ffaa89ad740
        public void get_path(){} // RVA: 0x7ffaaefa5d40
        public void get_layout(){} // RVA: 0x7ffaaefa5ed0
        public void get_variants(){} // RVA: 0x7ffaaefa5f30
        public void get_device(){} // RVA: 0x7ffaa8af68f0
        public void get_parent(){} // RVA: 0x7ffaa8d1a3b0
        public void get_children(){} // RVA: 0x7ffaaefa5f90
        public void get_usages(){} // RVA: 0x7ffaaefa6050
        public void get_aliases(){} // RVA: 0x7ffaaefa6110
        public void get_stateBlock(){} // RVA: 0x7ffaa9e49b20
        public void get_noisy(){} // RVA: 0x7ffaaefa61d0
        public void set_noisy(){} // RVA: 0x7ffaaefa61e0
        public void get_synthetic(){} // RVA: 0x7ffaaefa62e0
        public void set_synthetic(){} // RVA: 0x7ffaaefa62f0
        public void get_Item(){} // RVA: 0x7ffaaefa6310
        public void get_valueType(){} // RVA: 0x7ffaa86491d0
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa8649ca0
        public void get_magnitude(){} // RVA: 0x7ffaaefa63d0
        public void ToString(){} // RVA: 0x7ffaaefa6450
        public void DebuggerDisplay(){} // RVA: 0x7ffaaefa6500
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef71320
        public void EvaluateMagnitude(){} // RVA: 0x7ffaaef71320
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaaefa6680
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaaefa66f0
        public void CompareValue(){} // RVA: 0x7ffaa887e5c0
        public void TryGetChildControl(){} // RVA: 0x7ffaa887e5c0
        public void TryGetChildControl(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
        public void FinishSetup(){} // RVA: 0x7ffaa8932310
        public void RefreshConfigurationIfNeeded(){} // RVA: 0x7ffaaefa6920
        public void RefreshConfiguration(){} // RVA: 0x7ffaa8932310
        public void get_currentStatePtr(){} // RVA: 0x7ffaaefa6960
        public void get_previousFrameStatePtr(){} // RVA: 0x7ffaaefa69c0
        public void get_defaultStatePtr(){} // RVA: 0x7ffaaefa6a20
        public void get_noiseMaskPtr(){} // RVA: 0x7ffaaefa6a60
        public void get_stateOffsetRelativeToDeviceRoot(){} // RVA: 0x7ffaaefa6aa0
        public void get_optimizedControlDataType(){} // RVA: 0x7ffaaa1c3040
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7ffaa8f22da0
        public void ApplyParameterChanges(){} // RVA: 0x7ffaaefa6b10
        public void EnsureOptimizationTypeHasNotChanged(){} // RVA: 0x7ffaaefa6e70
        public void get_isSetupFinished(){} // RVA: 0x7ffaaefa72a0
        public void set_isSetupFinished(){} // RVA: 0x7ffaaefa72b0
        public void get_isButton(){} // RVA: 0x7ffaaefa72d0
        public void set_isButton(){} // RVA: 0x7ffaaefa72e0
        public void get_isConfigUpToDate(){} // RVA: 0x7ffaaefa7300
        public void set_isConfigUpToDate(){} // RVA: 0x7ffaaefa7310
        public void get_dontReset(){} // RVA: 0x7ffaaefa7330
        public void set_dontReset(){} // RVA: 0x7ffaaefa7340
        public void get_usesStateFromOtherControl(){} // RVA: 0x7ffaaefa7360
        public void set_usesStateFromOtherControl(){} // RVA: 0x7ffaaefa7370
        public void get_hasDefaultState(){} // RVA: 0x7ffaaefa7390
        public void CallFinishSetupRecursive(){} // RVA: 0x7ffaaefa73a0
        public void MakeChildPath(){} // RVA: 0x7ffaaefa7480
        public void BakeOffsetIntoStateBlockRecursive(){} // RVA: 0x7ffaaefa7530
        public void IsValueConsideredPressed(){} // RVA: 0x7ffaaefa7790
        public void AddProcessor(){} // RVA: 0x7ffaa8932310
        public void MarkAsStale(){} // RVA: 0x7ffaaefa7840
        public void MarkAsStaleRecursively(){} // RVA: 0x7ffaaefa7850
        // ── Binary Analysis Named ──
        public void GetChildControl(){} // RVA: 0x7ffaa887e5c0
        public void GetChildControl(){} // RVA: 0x7ffaa887e5c0
        public void SetOptimizedControlDataType(){} // RVA: 0x7ffaaefa6be0
        public void SetOptimizedControlDataTypeRecursively(){} // RVA: 0x7ffaaefa6c80
        public void GetDeviceIndex(){} // RVA: 0x7ffaaefa7620
    }

    public class InputControlExtensions : Object
    {
        // ── Original Methods ──
        public void FindInParentChain(){} // RVA: 0x7ffaa887e5c0
        public void IsPressed(){} // RVA: 0x7ffaaefa7a60
        public void IsActuated(){} // RVA: 0x7ffaaefa7bb0
        public void ReadValueAsObject(){} // RVA: 0x7ffaaefa7c50
        public void ReadValueIntoBuffer(){} // RVA: 0x7ffaaefa7cd0
        public void ReadDefaultValueAsObject(){} // RVA: 0x7ffaaefa7dd0
        public void ReadValueFromEvent(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueFromEvent(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueFromEventAsObject(){} // RVA: 0x7ffaaefa7e80
        public void ReadUnprocessedValueFromEvent(){} // RVA: 0x7ffaa887e5c0
        public void ReadUnprocessedValueFromEvent(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueFromObjectIntoEvent(){} // RVA: 0x7ffaaefa7fb0
        public void WriteValueIntoState(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueIntoState(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueIntoState(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueIntoState(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueIntoState(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueIntoEvent(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueIntoEvent(){} // RVA: 0x7ffaa887e5c0
        public void CopyState(){} // RVA: 0x7ffaa8660fc0
        public void CopyState(){} // RVA: 0x7ffaa8660fc0
        public void CompareStateIgnoringNoise(){} // RVA: 0x7ffaaefa8930
        public void CompareState(){} // RVA: 0x7ffaaefa8c00
        public void CompareState(){} // RVA: 0x7ffaaefa8c00
        public void HasValueChangeInState(){} // RVA: 0x7ffaaefa8cf0
        public void HasValueChangeInEvent(){} // RVA: 0x7ffaaefa8dd0
        public void ResetToDefaultStateInEvent(){} // RVA: 0x7ffaaefa9280
        public void QueueValueChange(){} // RVA: 0x7ffaa887e5c0
        public void AccumulateValueInEvent(){} // RVA: 0x7ffaaefa9610
        public void AccumulateValueInEvent(){} // RVA: 0x7ffaaefa9610
        public void FindControlsRecursive(){} // RVA: 0x7ffaa8666530
        public void BuildPath(){} // RVA: 0x7ffaaefa9730
        public void EnumerateControls(){} // RVA: 0x7ffaaefa9c50
        public void EnumerateChangedControls(){} // RVA: 0x7ffaaefa9ed0
        public void HasButtonPress(){} // RVA: 0x7ffaaefa9f20
        // ── Binary Analysis Named ──
        public void CheckStateIsAtDefault(){} // RVA: 0x7ffaaefa8570
        public void CheckStateIsAtDefault(){} // RVA: 0x7ffaaefa8570
        public void CheckStateIsAtDefaultIgnoringNoise(){} // RVA: 0x7ffaaefa87e0
        public void CheckStateIsAtDefaultIgnoringNoise(){} // RVA: 0x7ffaaefa87e0
        public void GetStatePtrFromStateEvent(){} // RVA: 0x7ffaaefa8ed0
        public void GetStatePtrFromStateEventUnchecked(){} // RVA: 0x7ffaaefa8f90
        public void GetFirstButtonPressOrNull(){} // RVA: 0x7ffaaefa9f40
        public void GetAllButtonPresses(){} // RVA: 0x7ffaaefaa180
        public void Setup(){} // RVA: 0x7ffaaefaa340
        public void Setup(){} // RVA: 0x7ffaaefaa340
    }

    public class InputControlList`1 : ValueType
    {
        public object m_Allocator; // 0x30F3D6D0
        public object m_Indices; // 0x360EC930

        // ── Original Methods ──
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_Capacity(){} // RVA: 0x7ffaa8649ca0
        public void set_Capacity(){} // RVA: 0x7ffaa8661210
        public void get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Resize(){} // RVA: 0x7ffaa8661210
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void AddSlice(){} // RVA: 0x7ffaa887e5c0
        public void AddRange(){}
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void RemoveAt(){} // RVA: 0x7ffaa8661210
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void IndexOf(){} // RVA: 0x7ffaa887e5c0
        public void IndexOf(){} // RVA: 0x7ffaa887e5c0
        public void Insert(){} // RVA: 0x7ffaa887e5c0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Contains(){} // RVA: 0x7ffaa887e5c0
        public void Contains(){} // RVA: 0x7ffaa887e5c0
        public void SwapElements(){} // RVA: 0x7ffaa86631a0
        public void Sort(){} // RVA: 0x7ffaa887e5c0
        public void ToArray(){}
        public void AppendTo(){} // RVA: 0x7ffaa8669e70
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void ToString(){} // RVA: 0x7ffaa86491d0
        public void ToIndex(){} // RVA: 0x7ffaa887e5c0
        public void FromIndex(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa86491d0
    }

    public class InputControlList`1 : ValueType
    {
    }

    public class InputControlList`1 : ValueType
    {
        public object m_Allocator; // 0x360EC930

        // ── Original Methods ──
        public void get_Count(){} // RVA: 0x7ffaa9e47550
        public void get_Capacity(){} // RVA: 0x7ffaab8dc900
        public void set_Capacity(){} // RVA: 0x7ffaab8dc950
        public void get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void get_Item(){} // RVA: 0x7ffaab8dcb20
        public void set_Item(){} // RVA: 0x7ffaab8dcc20
        public void .ctor(){} // RVA: 0x7ffaab8dd010
        public void .ctor(){} // RVA: 0x7ffaab8dd010
        public void .ctor(){} // RVA: 0x7ffaab8dd010
        public void Resize(){} // RVA: 0x7ffaab8dd130
        public void Add(){} // RVA: 0x7ffaab8dd2b0
        public void AddSlice(){} // RVA: 0x7ffaa887e5c0
        public void AddRange(){} // RVA: 0x7ffaab8dd380
        public void Remove(){} // RVA: 0x7ffaab8dd750
        public void RemoveAt(){} // RVA: 0x7ffaab8dd810
        public void CopyTo(){} // RVA: 0x7ffaab8dd970
        public void IndexOf(){} // RVA: 0x7ffaab8dda10
        public void IndexOf(){} // RVA: 0x7ffaab8dda10
        public void Insert(){} // RVA: 0x7ffaab8dd970
        public void Clear(){} // RVA: 0x7ffaaa4039b0
        public void Contains(){} // RVA: 0x7ffaab8ddc00
        public void Contains(){} // RVA: 0x7ffaab8ddc00
        public void SwapElements(){} // RVA: 0x7ffaab8ddc80
        public void Sort(){} // RVA: 0x7ffaa887e5c0
        public void ToArray(){} // RVA: 0x7ffaab8ddd80
        public void AppendTo(){} // RVA: 0x7ffaab8ddf30
        public void Dispose(){} // RVA: 0x7ffaab8ddff0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaab8de110
        public void ToString(){} // RVA: 0x7ffaab8de150
        public void ToIndex(){} // RVA: 0x7ffaab8de310
        public void FromIndex(){} // RVA: 0x7ffaab8de3f0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaab8de050
    }

    public class InputControlPath : Object
    {
        public object Separator; // 0x317BAC50

        // ── Original Methods ──
        public void CleanSlashes(){} // RVA: 0x7ffaaefac890
        public void Combine(){} // RVA: 0x7ffaaefac8c0
        public void ToHumanReadableString(){} // RVA: 0x7ffaaefaca00
        public void ToHumanReadableString(){} // RVA: 0x7ffaaefaca00
        public void TryGetDeviceUsages(){} // RVA: 0x7ffaaefad080
        public void TryGetDeviceLayout(){} // RVA: 0x7ffaaefad2c0
        public void TryGetControlLayout(){} // RVA: 0x7ffaaefad470
        public void FindControlLayoutRecursive(){} // RVA: 0x7ffaaefad960
        public void FindControlLayoutRecursive(){} // RVA: 0x7ffaaefad960
        public void ControlLayoutMatchesPathComponent(){} // RVA: 0x7ffaaefadc10
        public void StringMatches(){} // RVA: 0x7ffaaefade50
        public void TryFindControl(){} // RVA: 0x7ffaa887e5c0
        public void TryFindControls(){} // RVA: 0x7ffaa887e5c0
        public void TryFindControls(){} // RVA: 0x7ffaa887e5c0
        public void TryFindControl(){} // RVA: 0x7ffaa887e5c0
        public void TryFindControls(){} // RVA: 0x7ffaa887e5c0
        public void TryFindChild(){} // RVA: 0x7ffaa887e5c0
        public void TryFindChild(){} // RVA: 0x7ffaa887e5c0
        public void Matches(){} // RVA: 0x7ffaaefae640
        public void MatchControlComponent(){} // RVA: 0x7ffaaefae7f0
        public void MatchesPrefix(){} // RVA: 0x7ffaaefaec30
        public void MatchesRecursive(){} // RVA: 0x7ffaaefaedf0
        public void MatchControlsRecursive(){} // RVA: 0x7ffaa887e5c0
        public void MatchByUsageAtDeviceRootRecursive(){} // RVA: 0x7ffaa887e5c0
        public void MatchChildrenRecursive(){} // RVA: 0x7ffaa887e5c0
        public void MatchPathComponent(){} // RVA: 0x7ffaaefaee80
        public void PathComponentCanYieldMultipleMatches(){} // RVA: 0x7ffaaefaf240
        public void Parse(){} // RVA: 0x7ffaaefaf300
    }

    public class InputControlScheme : ValueType
    {
        public object m_DeviceRequirements; // 0x317BADD0

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa950bda0
        public void get_bindingGroup(){} // RVA: 0x7ffaa9e47540
        public void set_bindingGroup(){} // RVA: 0x7ffaa9e47560
        public void get_deviceRequirements(){} // RVA: 0x7ffaaef9acf0
        public void .ctor(){} // RVA: 0x7ffaaef9adb0
        public void FindControlSchemeForDevices(){} // RVA: 0x7ffaa887e5c0
        public void FindControlSchemeForDevices(){} // RVA: 0x7ffaa887e5c0
        public void FindControlSchemeForDevice(){} // RVA: 0x7ffaa887e5c0
        public void SupportsDevice(){} // RVA: 0x7ffaaef9b170
        public void PickDevicesFrom(){} // RVA: 0x7ffaa887e5c0
        public void Equals(){} // RVA: 0x7ffaaef9b6d0
        public void Equals(){} // RVA: 0x7ffaaef9b6d0
        public void ToString(){} // RVA: 0x7ffaaef9b820
        public void op_Equality(){} // RVA: 0x7ffaaef9ba20
        public void op_Inequality(){} // RVA: 0x7ffaaef9ba50
        // ── Binary Analysis Named ──
        public void SetNameAndBindingGroup(){} // RVA: 0x7ffaaef9afa0
        public void GetHashCode(){} // RVA: 0x7ffaaef9b770
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x3106F330

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaa86491d0
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa8649ca0
        public void get_value(){} // RVA: 0x7ffaa86491d0
        public void get_unprocessedValue(){} // RVA: 0x7ffaa86491d0
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaa887e5c0
        public void ReadDefaultValue(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueFromState(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaa887e5c0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaa887e5c0
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaa887e5c0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaa887e5c0
        public void WriteValueIntoState(){} // RVA: 0x7ffaa887e5c0
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaa887e5c0
        public void CompareValue(){} // RVA: 0x7ffaa887e5c0
        public void CompareValue(){} // RVA: 0x7ffaa887e5c0
        public void ProcessValue(){} // RVA: 0x7ffaa8660d80
        public void ProcessValue(){} // RVA: 0x7ffaa8660d80
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaa8660d80
        public void FinishSetup(){} // RVA: 0x7ffaa8660cc0
        public void get_processors(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x333BACD0

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8ec430
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa92584b0
        public void get_value(){} // RVA: 0x7ffaab8ec4e0
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8ec5c0
        public void ReadValue(){} // RVA: 0x7ffaab8ec700
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8ec720
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8ec830
        public void ReadValueFromState(){} // RVA: 0x7ffaab8ec910
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8ec9a0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8ecae0
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8ecbb0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8ecbd0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8ecc90
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8ece30
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8ecfc0
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8ed1c0
        public void CompareValue(){} // RVA: 0x7ffaab8ed380
        public void CompareValue(){} // RVA: 0x7ffaab8ed380
        public void ProcessValue(){} // RVA: 0x7ffaab8ed530
        public void ProcessValue(){} // RVA: 0x7ffaab8ed530
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8ed610
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x33493E18

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8e8e90
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa90e5cf0
        public void get_value(){} // RVA: 0x7ffaab8e8f40
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8e9000
        public void ReadValue(){} // RVA: 0x7ffaab8e9120
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8e9140
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8e9250
        public void ReadValueFromState(){} // RVA: 0x7ffaab8e9330
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8e93c0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8e94f0
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8e95b0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8e95d0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8e96a0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8e9840
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8e99e0
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8e9bd0
        public void CompareValue(){} // RVA: 0x7ffaab8e9d90
        public void CompareValue(){} // RVA: 0x7ffaab8e9d90
        public void ProcessValue(){} // RVA: 0x7ffaab8e9f30
        public void ProcessValue(){} // RVA: 0x7ffaab8e9f30
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8ea010
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x33569270

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8e5680
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa90e5cf0
        public void get_value(){} // RVA: 0x7ffaab8e5730
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8e57f0
        public void ReadValue(){} // RVA: 0x7ffaab8e5910
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8e4500
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8e4610
        public void ReadValueFromState(){} // RVA: 0x7ffaab8e46f0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8e5930
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8e5a60
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8e5b20
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8e4970
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8e4a30
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8e4bd0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8e5b30
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8e4f50
        public void CompareValue(){} // RVA: 0x7ffaab8e5220
        public void CompareValue(){} // RVA: 0x7ffaab8e5220
        public void ProcessValue(){} // RVA: 0x7ffaab8e53b0
        public void ProcessValue(){} // RVA: 0x7ffaab8e53b0
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8e5d20
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x335B9930

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8e5f20
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaaad11490
        public void get_value(){} // RVA: 0x7ffaab8e5fd0
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8e60f0
        public void ReadValue(){} // RVA: 0x7ffaab8e6250
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8e6290
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8e6420
        public void ReadValueFromState(){} // RVA: 0x7ffaab8e6570
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8e6670
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8e6830
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8e6920
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8e6960
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8e6a90
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8e6cc0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8e6ed0
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8e70f0
        public void CompareValue(){} // RVA: 0x7ffaab8e7360
        public void CompareValue(){} // RVA: 0x7ffaab8e7360
        public void ProcessValue(){} // RVA: 0x7ffaab8e7600
        public void ProcessValue(){} // RVA: 0x7ffaab8e7600
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8e77b0
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x33626910

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8e79b0
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaaad0d4a0
        public void get_value(){} // RVA: 0x7ffaab8e7a60
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8e7b20
        public void ReadValue(){} // RVA: 0x7ffaab8e7c40
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8e7c60
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8e7d90
        public void ReadValueFromState(){} // RVA: 0x7ffaab8e7e90
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8e7f40
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8e8090
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8e8160
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8e8180
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8e8250
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8e8400
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8e85a0
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8e87a0
        public void CompareValue(){} // RVA: 0x7ffaab8e89b0
        public void CompareValue(){} // RVA: 0x7ffaab8e89b0
        public void ProcessValue(){} // RVA: 0x7ffaab8e8b90
        public void ProcessValue(){} // RVA: 0x7ffaab8e8b90
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8e8c90
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x3380E780

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8e4260
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa90e5cf0
        public void get_value(){} // RVA: 0x7ffaab8e4310
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8e43d0
        public void ReadValue(){} // RVA: 0x7ffaab8e44f0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8e4500
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8e4610
        public void ReadValueFromState(){} // RVA: 0x7ffaab8e46f0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8e4780
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8e48a0
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8e4960
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8e4970
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8e4a30
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8e4bd0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8e4d60
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8e4f50
        public void CompareValue(){} // RVA: 0x7ffaab8e5220
        public void CompareValue(){} // RVA: 0x7ffaab8e5220
        public void ProcessValue(){} // RVA: 0x7ffaab8e53b0
        public void ProcessValue(){} // RVA: 0x7ffaab8e53b0
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8e5480
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x33825978

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8e1330
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaa92584b0
        public void get_value(){} // RVA: 0x7ffaab8e13e0
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8e14a0
        public void ReadValue(){} // RVA: 0x7ffaab8e15c0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8e15e0
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8e16f0
        public void ReadValueFromState(){} // RVA: 0x7ffaab8e17d0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8e1860
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8e1990
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8e1a50
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8e1a70
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8e1b40
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8e1ce0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8e1e80
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8e2070
        public void CompareValue(){} // RVA: 0x7ffaab8e2280
        public void CompareValue(){} // RVA: 0x7ffaab8e2280
        public void ProcessValue(){} // RVA: 0x7ffaab8e2420
        public void ProcessValue(){} // RVA: 0x7ffaab8e2420
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8e2500
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x33869480

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8ea210
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaaad11360
        public void get_value(){} // RVA: 0x7ffaab8ea2c0
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8ea3c0
        public void ReadValue(){} // RVA: 0x7ffaab8ea510
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8ea550
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8ea6d0
        public void ReadValueFromState(){} // RVA: 0x7ffaab8ea810
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8ea900
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8eaab0
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8eaba0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8eabe0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8ead00
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8eaf20
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8eb120
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8eb340
        public void CompareValue(){} // RVA: 0x7ffaab8eb5a0
        public void CompareValue(){} // RVA: 0x7ffaab8eb5a0
        public void ProcessValue(){} // RVA: 0x7ffaab8eb810
        public void ProcessValue(){} // RVA: 0x7ffaab8eb810
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8eb9b0
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x339486E0

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8ed810
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaaad0d500
        public void get_value(){} // RVA: 0x7ffaab8ed8c0
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8ed990
        public void ReadValue(){} // RVA: 0x7ffaab8edac0
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8edaf0
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8edc40
        public void ReadValueFromState(){} // RVA: 0x7ffaab8edd50
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8ede10
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8edf70
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8ee050
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8ee080
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8ee160
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8ee330
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8ee4e0
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8ee6f0
        public void CompareValue(){} // RVA: 0x7ffaab8ee910
        public void CompareValue(){} // RVA: 0x7ffaab8ee910
        public void ProcessValue(){} // RVA: 0x7ffaab8eeb10
        public void ProcessValue(){} // RVA: 0x7ffaab8eeb10
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8eec30
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x34C99DC0

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8de550
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaaad0df50
        public void get_value(){} // RVA: 0x7ffaab8de600
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8de6d0
        public void ReadValue(){} // RVA: 0x7ffaab8de800
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8de830
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8de980
        public void ReadValueFromState(){} // RVA: 0x7ffaab8dea90
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8deb50
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8decb0
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8ded90
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8dedc0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8deea0
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8df080
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8df240
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8df4c0
        public void CompareValue(){} // RVA: 0x7ffaab8df6f0
        public void CompareValue(){} // RVA: 0x7ffaab8df6f0
        public void ProcessValue(){} // RVA: 0x7ffaab8df900
        public void ProcessValue(){} // RVA: 0x7ffaab8df900
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8dfc50
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputControl`1 : InputControl
    {
        public object m_UnprocessedCachedValue; // 0x34CAAD70

        // ── Original Methods ──
        public void get_valueType(){} // RVA: 0x7ffaab8e2700
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaaad11440
        public void get_value(){} // RVA: 0x7ffaab8e27b0
        public void get_unprocessedValue(){} // RVA: 0x7ffaab8e28e0
        public void ReadValue(){} // RVA: 0x7ffaab8e2a50
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7ffaab8e2aa0
        public void ReadDefaultValue(){} // RVA: 0x7ffaab8e2c40
        public void ReadValueFromState(){} // RVA: 0x7ffaab8e2da0
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7ffaab8e2eb0
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7ffaab8e3090
        public void ReadUnprocessedValue(){} // RVA: 0x7ffaab8e3190
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaa884bb60
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaab8e31e0
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaab8e3330
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7ffaab8e3550
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7ffaab8e3740
        public void WriteValueIntoState(){} // RVA: 0x7ffaab8df450
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaab8e3970
        public void CompareValue(){} // RVA: 0x7ffaab8e3bd0
        public void CompareValue(){} // RVA: 0x7ffaab8e3bd0
        public void ProcessValue(){} // RVA: 0x7ffaab8e3e90
        public void ProcessValue(){} // RVA: 0x7ffaab8e3e90
        public void TryGetProcessor(){} // RVA: 0x7ffaa887e5c0
        public void AddProcessor(){} // RVA: 0x7ffaab8dfa40
        public void FinishSetup(){} // RVA: 0x7ffaab8e4060
        public void get_processors(){} // RVA: 0x7ffaab8dfe50
        public void .ctor(){} // RVA: 0x7ffaab8dfe70
    }

    public class InputDevice : InputControl
    {
        public object kInvalidDeviceIndex; // 0x317BB110
        public object m_ParticipantId; // 0x317BB110
        public object m_Description; // 0x317BB110
        public object m_AliasesForEachControl; // 0x317BB110
        public object m_ChildrenForEachControl; // 0x317BB110
        public object m_UseCachePathForButtonPresses; // 0x317BB110
        public object m_ControlTreeIndices; // 0x317BB110
        public object kStateSizeBits; // 0x317BB110
        public object m_Manufacturer; // 0x317BB3B0
        public object m_Version; // 0x317BB3B0

        // ── Original Methods ──
        public void get_description(){} // RVA: 0x7ffaaefb3190
        public void get_enabled(){} // RVA: 0x7ffaaefb31d0
        public void get_canRunInBackground(){} // RVA: 0x7ffaaefb31f0
        public void get_canDeviceRunInBackground(){} // RVA: 0x7ffaaefb31f0
        public void get_added(){} // RVA: 0x7ffaaefb32c0
        public void get_remote(){} // RVA: 0x7ffaaefb32d0
        public void get_native(){} // RVA: 0x7ffaaefb32e0
        public void get_updateBeforeRender(){} // RVA: 0x7ffaaefb32f0
        public void get_deviceId(){} // RVA: 0x7ffaaa1ddec0
        public void get_lastUpdateTime(){} // RVA: 0x7ffaaefb3300
        public void get_wasUpdatedThisFrame(){} // RVA: 0x7ffaaefb3350
        public void get_allControls(){} // RVA: 0x7ffaaefb33a0
        public void get_valueType(){} // RVA: 0x7ffaaefb3470
        public void get_valueSizeInBytes(){} // RVA: 0x7ffaaefb3520
        public void get_all(){} // RVA: 0x7ffaaefb35b0
        public void .ctor(){} // RVA: 0x7ffaaefb3660
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7ffaaefb36d0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7ffaaefb3710
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7ffaaefb3860
        public void CompareValue(){} // RVA: 0x7ffaaefb3a60
        public void NotifyConfigurationChanged(){} // RVA: 0x7ffaaefb3bd0
        public void MakeCurrent(){} // RVA: 0x7ffaa8932310
        public void OnAdded(){} // RVA: 0x7ffaa8932310
        public void OnRemoved(){} // RVA: 0x7ffaa8932310
        public void OnConfigurationChanged(){} // RVA: 0x7ffaa8932310
        public void ExecuteCommand(){} // RVA: 0x7ffaaefb3c60
        public void ExecuteCommand(){} // RVA: 0x7ffaaefb3c60
        public void QueryEnabledStateFromRuntime(){} // RVA: 0x7ffaaefb3ce0
        public void get_disabledInFrontend(){} // RVA: 0x7ffaaefb3da0
        public void set_disabledInFrontend(){} // RVA: 0x7ffaaefb3db0
        public void get_disabledInRuntime(){} // RVA: 0x7ffaaefb3dd0
        public void set_disabledInRuntime(){} // RVA: 0x7ffaaefb3de0
        public void get_disabledWhileInBackground(){} // RVA: 0x7ffaaefb3e10
        public void set_disabledWhileInBackground(){} // RVA: 0x7ffaaefb3e20
        public void EncodeStateOffsetToControlMapEntry(){} // RVA: 0x7ffaaefb3e50
        public void DecodeStateOffsetToControlMapEntry(){} // RVA: 0x7ffaaefb3e60
        public void get_hasControlsWithDefaultState(){} // RVA: 0x7ffaaefb3e80
        public void set_hasControlsWithDefaultState(){} // RVA: 0x7ffaaefb3e90
        public void get_hasDontResetControls(){} // RVA: 0x7ffaaefb3eb0
        public void set_hasDontResetControls(){} // RVA: 0x7ffaaefb3ec0
        public void get_hasStateCallbacks(){} // RVA: 0x7ffaaefb3ef0
        public void set_hasStateCallbacks(){} // RVA: 0x7ffaaefb3f00
        public void get_hasEventMerger(){} // RVA: 0x7ffaaefb3f20
        public void set_hasEventMerger(){} // RVA: 0x7ffaaefb3f30
        public void get_hasEventPreProcessor(){} // RVA: 0x7ffaaefb3f60
        public void set_hasEventPreProcessor(){} // RVA: 0x7ffaaefb3f70
        public void AddDeviceUsage(){} // RVA: 0x7ffaaefb3fa0
        public void RemoveDeviceUsage(){} // RVA: 0x7ffaaefb4060
        public void ClearDeviceUsages(){} // RVA: 0x7ffaaefb4230
        public void RequestSync(){} // RVA: 0x7ffaaefb42a0
        public void RequestReset(){} // RVA: 0x7ffaaefb4320
        public void ExecuteEnableCommand(){} // RVA: 0x7ffaaefb43a0
        public void ExecuteDisableCommand(){} // RVA: 0x7ffaaefb4420
        public void NotifyAdded(){} // RVA: 0x7ffaae7b45c0
        public void NotifyRemoved(){} // RVA: 0x7ffaa9144930
        public void Build(){} // RVA: 0x7ffaa887e5c0
        public void WriteChangedControlStates(){} // RVA: 0x7ffaaefb4490
        public void WritePartialChangedControlStatesInternal(){} // RVA: 0x7ffaaefb4610
        public void DumpControlBitRangeNode(){} // RVA: 0x7ffaaefb4a20
        public void DumpControlTree(){} // RVA: 0x7ffaaefb50c0
        public void DumpControlTree(){} // RVA: 0x7ffaaefb50c0
        public void WriteChangedControlStatesInternal(){} // RVA: 0x7ffaaefb51a0
        public void HasDataChangedInRange(){} // RVA: 0x7ffaaefb5700
    }

    public class InputExtensions : Object
    {
        // ── Original Methods ──
        public void IsInProgress(){} // RVA: 0x7ffaae111f90
        public void IsEndedOrCanceled(){} // RVA: 0x7ffaaf02c150
        public void IsActive(){} // RVA: 0x7ffaaf02c160
        public void IsModifierKey(){} // RVA: 0x7ffaaf02c180
        public void IsTextInputKey(){} // RVA: 0x7ffaaf02c190
    }

    public class InputFeatureNames : Object
    {
        public object kUseOptimizedControls; // 0x338EE4A0
        public object kUseIMGUIEditorForAssets; // 0x338EE4A0
    }

    public class InputInteraction : Object
    {
        // ── Binary Analysis Named ──
        public void GetValueType(){} // RVA: 0x7ffaaef3c760
        public void GetDisplayName(){} // RVA: 0x7ffaaef3c940
        public void GetDisplayName(){} // RVA: 0x7ffaaef3c940
    }

    public class InputInteractionContext : ValueType
    {
        public object m_TriggerState; // 0x317BB860
        public object action; // 0x17000158

        // ── Original Methods ──
        public void get_action(){} // RVA: 0x7ffaaef9ceb0
        public void get_control(){} // RVA: 0x7ffaaef9cee0
        public void get_phase(){} // RVA: 0x7ffaaa4dc400
        public void get_time(){} // RVA: 0x7ffaaef9cf30
        public void get_startTime(){} // RVA: 0x7ffaaef9cf40
        public void get_timerHasExpired(){} // RVA: 0x7ffaaef9c140
        public void set_timerHasExpired(){} // RVA: 0x7ffaaef9c150
        public void get_isWaiting(){} // RVA: 0x7ffaaef9cf50
        public void get_isStarted(){} // RVA: 0x7ffaaef9cf60
        public void ComputeMagnitude(){} // RVA: 0x7ffaa8a11210
        public void ControlIsActuated(){} // RVA: 0x7ffaaef9cf70
        public void Started(){} // RVA: 0x7ffaaef9d010
        public void Performed(){} // RVA: 0x7ffaaef9d060
        public void PerformedAndStayStarted(){} // RVA: 0x7ffaaef9d0c0
        public void PerformedAndStayPerformed(){} // RVA: 0x7ffaaef9d120
        public void Canceled(){} // RVA: 0x7ffaaef9d170
        public void Waiting(){} // RVA: 0x7ffaaef9d1c0
        public void ReadValue(){} // RVA: 0x7ffaa887e5c0
        public void get_mapIndex(){} // RVA: 0x7ffaaef9d310
        public void get_controlIndex(){} // RVA: 0x7ffaaef9d320
        public void get_bindingIndex(){} // RVA: 0x7ffaae1ceac0
        public void get_interactionIndex(){} // RVA: 0x7ffaaef9d340
        // ── Binary Analysis Named ──
        public void SetTimeout(){} // RVA: 0x7ffaaef9d210
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x7ffaaef9d240
    }

    public class InputManager : Object
    {
        public object k_InputAddDeviceMarker; // 0x30BB0A50
        public object k_InputOnBeforeUpdateMarker; // 0x30BB0A50
        public object k_InputOnDeviceSettingsChangeMarker; // 0x30BB0A50
        public object k_InputOnDeviceChangeMarker; // 0x30BB0A50
        public object m_PollingFrequency; // 0x30BB0A50
        public object m_Interactions; // 0x30BB0A50
        public object m_Devices; // 0x30BB0A50
        public object m_AvailableDevices; // 0x30BB0A50
        public object m_UpdateMask; // 0x30BB0A50
        public object m_ScrollDeltaBehavior; // 0x30BB0A50
        public object m_DeviceFindLayoutCallbacks; // 0x30BB0A50
        public object m_EventListeners; // 0x30BB0A50
        public object m_SettingsChangedListeners; // 0x30BB0A50
        public object m_HaveDevicesWithStateCallbackReceivers; // 0x30BB0A50
        public object m_DeviceFindExecuteCommandDelegate; // 0x30BB0A50
        public object m_Metrics; // 0x30BB0A50
        public object m_ReadValueCachingFeatureEnabled; // 0x30BB0A50
        public object m_ShouldMakeCurrentlyUpdatingDeviceCurrent; // 0x30BB0A50
        public object kBaseScoreForNonGeneratedLayouts; // 0x33B3C850
        public object layoutBuilders; // 0x33B3C850
        public object layoutOverrideNames; // 0x33B3C850
        public object table; // 0x317BA7C0
        public object defaultStateBuffer; // 0x3379FB50
        public object m_AllBuffers; // 0x3379FB50
        public object s_NoiseMaskBuffer; // 0x3379FB50
        public object deviceToBufferMapping; // 0x33B3C9D0

        // ── Original Methods ──
        public void get_devices(){} // RVA: 0x7ffaaf02c1b0
        public void get_processors(){} // RVA: 0x7ffaa89fa500
        public void get_interactions(){} // RVA: 0x7ffaa89d0370
        public void get_composites(){} // RVA: 0x7ffaa89add50
        public void get_metrics(){} // RVA: 0x7ffaaf02c260
        public void get_settings(){} // RVA: 0x7ffaa93ed2c0
        public void set_settings(){} // RVA: 0x7ffaaf02c4a0
        public void get_actions(){} // RVA: 0x7ffaa93eaa30
        public void set_actions(){} // RVA: 0x7ffaaf02c6c0
        public void get_updateMask(){} // RVA: 0x7ffaa9325970
        public void set_updateMask(){} // RVA: 0x7ffaaf02c720
        public void get_defaultUpdateType(){} // RVA: 0x7ffaaf02c740
        public void get_scrollDeltaBehavior(){} // RVA: 0x7ffaaa1dded0
        public void set_scrollDeltaBehavior(){} // RVA: 0x7ffaaf02c780
        public void get_pollingFrequency(){} // RVA: 0x7ffaa8a5c340
        public void set_pollingFrequency(){} // RVA: 0x7ffaaf02c790
        public void add_onDeviceChange(){} // RVA: 0x7ffaaf02c870
        public void remove_onDeviceChange(){} // RVA: 0x7ffaaf02c8d0
        public void add_onDeviceStateChange(){} // RVA: 0x7ffaaf02c930
        public void remove_onDeviceStateChange(){} // RVA: 0x7ffaaf02c990
        public void add_onDeviceCommand(){} // RVA: 0x7ffaaf02c9f0
        public void remove_onDeviceCommand(){} // RVA: 0x7ffaaf02ca50
        public void add_onFindControlLayoutForDevice(){} // RVA: 0x7ffaaf02cab0
        public void remove_onFindControlLayoutForDevice(){} // RVA: 0x7ffaaf02cb10
        public void add_onLayoutChange(){} // RVA: 0x7ffaaf02cb70
        public void remove_onLayoutChange(){} // RVA: 0x7ffaaf02cbd0
        public void add_onEvent(){} // RVA: 0x7ffaaf02cc30
        public void remove_onEvent(){} // RVA: 0x7ffaaf02cc90
        public void add_onBeforeUpdate(){} // RVA: 0x7ffaaf02ccf0
        public void remove_onBeforeUpdate(){} // RVA: 0x7ffaaf02cd50
        public void add_onAfterUpdate(){} // RVA: 0x7ffaaf02cdb0
        public void remove_onAfterUpdate(){} // RVA: 0x7ffaaf02ce10
        public void add_onSettingsChange(){} // RVA: 0x7ffaaf02ce70
        public void remove_onSettingsChange(){} // RVA: 0x7ffaaf02ced0
        public void add_onActionsChange(){} // RVA: 0x7ffaaf02cf30
        public void remove_onActionsChange(){} // RVA: 0x7ffaaf02cf90
        public void get_isProcessingEvents(){} // RVA: 0x7ffaaf02cff0
        public void get_gameIsPlaying(){} // RVA: 0x7ffaa8a17850
        public void get_gameHasFocus(){} // RVA: 0x7ffaaf02d000
        public void get_gameShouldGetInputRegardlessOfFocus(){} // RVA: 0x7ffaaf02d040
        public void RegisterControlLayout(){} // RVA: 0x7ffaaf02d8c0
        public void RegisterControlLayout(){} // RVA: 0x7ffaaf02d8c0
        public void RegisterControlLayoutBuilder(){} // RVA: 0x7ffaaf02e100
        public void PerformLayoutPostRegistration(){} // RVA: 0x7ffaaf02e3b0
        public void RegisterPrecompiledLayout(){} // RVA: 0x7ffaa8660d80
        public void RecreateDevicesUsingLayout(){} // RVA: 0x7ffaaf02ebd0
        public void IsControlOrChildUsingLayoutRecursive(){} // RVA: 0x7ffaaf02ee10
        public void IsControlUsingLayout(){} // RVA: 0x7ffaaf02ef10
        public void RegisterControlLayoutMatcher(){} // RVA: 0x7ffaaf02f260
        public void RegisterControlLayoutMatcher(){} // RVA: 0x7ffaaf02f260
        public void RecreateDevicesUsingLayoutWithInferiorMatch(){} // RVA: 0x7ffaaf02f4b0
        public void RecreateDevice(){} // RVA: 0x7ffaaf02f7f0
        public void AddAvailableDevicesMatchingDescription(){} // RVA: 0x7ffaaf02fa40
        public void RemoveControlLayout(){} // RVA: 0x7ffaaf02fef0
        public void TryLoadControlLayout(){} // RVA: 0x7ffaaf030510
        public void TryLoadControlLayout(){} // RVA: 0x7ffaaf030510
        public void TryFindMatchingControlLayout(){} // RVA: 0x7ffaaf030540
        public void FindOrRegisterDeviceLayoutForType(){} // RVA: 0x7ffaaf030b30
        public void IsDeviceLayoutMarkedAsSupportedInSettings(){} // RVA: 0x7ffaaf030be0
        public void ListControlLayouts(){} // RVA: 0x7ffaaf030d20
        public void AddDeviceUsage(){} // RVA: 0x7ffaaf031100
        public void RemoveDeviceUsage(){} // RVA: 0x7ffaaf031260
        public void NotifyUsageChanged(){} // RVA: 0x7ffaaf0313c0
        public void AddDevice(){} // RVA: 0x7ffaaf032810
        public void AddDevice(){} // RVA: 0x7ffaaf032810
        public void AddDevice(){} // RVA: 0x7ffaaf032810
        public void AddDevice(){} // RVA: 0x7ffaaf032810
        public void AddDevice(){} // RVA: 0x7ffaaf032810
        public void AddDevice(){} // RVA: 0x7ffaaf032810
        public void AddDevice(){} // RVA: 0x7ffaaf032810
        public void RemoveDevice(){} // RVA: 0x7ffaaf032960
        public void FlushDisconnectedDevices(){} // RVA: 0x7ffaaf033230
        public void ResetDevice(){} // RVA: 0x7ffaaf033290
        public void TryGetDevice(){} // RVA: 0x7ffaaf033c50
        public void TryGetDevice(){} // RVA: 0x7ffaaf033c50
        public void TryGetDeviceById(){} // RVA: 0x7ffaaf033ce0
        public void EnableOrDisableDevice(){} // RVA: 0x7ffaaf033f50
        public void QueueEvent(){} // RVA: 0x7ffaa8660d80
        public void QueueEvent(){} // RVA: 0x7ffaa8660d80
        public void QueueEvent(){} // RVA: 0x7ffaa8660d80
        public void Update(){} // RVA: 0x7ffaaf034470
        public void Update(){} // RVA: 0x7ffaaf034470
        public void Initialize(){} // RVA: 0x7ffaaf0344d0
        public void Destroy(){} // RVA: 0x7ffaaf034680
        public void InitializeActions(){} // RVA: 0x7ffaaf0348c0
        public void InitializeData(){} // RVA: 0x7ffaaf0349b0
        public void RegisterCustomTypes(){} // RVA: 0x7ffaaf0371b0
        public void RegisterCustomTypes(){} // RVA: 0x7ffaaf0371b0
        public void InstallRuntime(){} // RVA: 0x7ffaaf037470
        public void InstallGlobals(){} // RVA: 0x7ffaaf0378a0
        public void UninstallGlobals(){} // RVA: 0x7ffaaf037d50
        public void get_optimizedControlsFeatureEnabled(){} // RVA: 0x7ffaaf037fe0
        public void set_optimizedControlsFeatureEnabled(){} // RVA: 0x7ffaaf037ff0
        public void get_readValueCachingFeatureEnabled(){} // RVA: 0x7ffaaf038000
        public void set_readValueCachingFeatureEnabled(){} // RVA: 0x7ffaaf038010
        public void get_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x7ffaaf038020
        public void set_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x7ffaaf038030
        public void MakeDeviceNameUnique(){} // RVA: 0x7ffaaf038040
        public void ResetControlPathsRecursive(){} // RVA: 0x7ffaaf038350
        public void AssignUniqueDeviceId(){} // RVA: 0x7ffaaf038490
        public void ReallocateStateBuffers(){} // RVA: 0x7ffaaf038600
        public void InitializeDefaultState(){} // RVA: 0x7ffaaf0388e0
        public void InitializeDeviceState(){} // RVA: 0x7ffaaf038ad0
        public void OnNativeDeviceDiscovered(){} // RVA: 0x7ffaaf038e30
        public void MakeEscapedJsonString(){} // RVA: 0x7ffaaf039390
        public void TryMatchDisconnectedDevice(){} // RVA: 0x7ffaaf0396f0
        public void InstallBeforeUpdateHookIfNecessary(){} // RVA: 0x7ffaaf039a30
        public void RestoreDevicesAfterDomainReloadIfNecessary(){} // RVA: 0x7ffaa8932310
        public void WarnAboutDevicesFailingToRecreateAfterDomainReload(){} // RVA: 0x7ffaa8932310
        public void OnBeforeUpdate(){} // RVA: 0x7ffaaf039af0
        public void ApplySettings(){} // RVA: 0x7ffaaf039e10
        public void ApplyActions(){} // RVA: 0x7ffaaf03a7a0
        public void ExecuteGlobalCommand(){} // RVA: 0x7ffaa8649280
        public void AddAvailableDevicesThatAreNowRecognized(){} // RVA: 0x7ffaaf03a830
        public void ShouldRunDeviceInBackground(){} // RVA: 0x7ffaaf03ab40
        public void OnFocusChanged(){} // RVA: 0x7ffaaf03ab80
        public void ShouldRunUpdate(){} // RVA: 0x7ffaaf03adc0
        public void OnUpdate(){} // RVA: 0x7ffaaf03ade0
        public void AreMaximumEventBytesPerUpdateExceeded(){} // RVA: 0x7ffaaf03c110
        public void MakeStringWithEventsProcessedByDevice(){} // RVA: 0x7ffaaf03c280
        public void ResetCurrentProcessedEventBytesForDevices(){} // RVA: 0x7ffaaf03c460
        public void InvokeAfterUpdateCallback(){} // RVA: 0x7ffaaf03c730
        public void UpdateState(){} // RVA: 0x7ffaaf03c8f0
        public void UpdateState(){} // RVA: 0x7ffaaf03c8f0
        public void WriteStateChange(){} // RVA: 0x7ffaaf03d060
        public void FlipBuffersForDeviceIfNecessary(){} // RVA: 0x7ffaaf03d410
        public void AddStateChangeMonitor(){} // RVA: 0x7ffaaf03d4c0
        public void RemoveStateChangeMonitors(){} // RVA: 0x7ffaaf03d670
        public void RemoveStateChangeMonitor(){} // RVA: 0x7ffaaf03d850
        public void AddStateChangeMonitorTimeout(){} // RVA: 0x7ffaaf03daa0
        public void RemoveStateChangeMonitorTimeout(){} // RVA: 0x7ffaaf03dc30
        public void SortStateChangeMonitorsIfNecessary(){} // RVA: 0x7ffaaf03ddc0
        public void SignalStateChangeMonitor(){} // RVA: 0x7ffaaf03de10
        public void FireStateChangeNotifications(){} // RVA: 0x7ffaaf03e440
        public void ProcessStateChangeMonitors(){} // RVA: 0x7ffaaf03e020
        public void FireStateChangeNotifications(){} // RVA: 0x7ffaaf03e440
        public void ProcessStateChangeMonitorTimeouts(){} // RVA: 0x7ffaaf03e840
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf03eb80
        public void <TryFindMatchingControlLayout>b__94_0(){} // RVA: 0x7ffaaf03f1e0
        // ── Binary Analysis Named ──
        public void GetControls(){} // RVA: 0x7ffaa8653ae0
        public void SetDeviceUsage(){} // RVA: 0x7ffaaf030e30
        public void GetDevice(){} // RVA: 0x7ffaaf033bb0
        public void GetUnsupportedDevices(){} // RVA: 0x7ffaaf033d60
        public void CheckAllDevicesOptimizedControlsHaveValidState(){} // RVA: 0x7ffaaf03c530
        public void DontMakeCurrentlyUpdatingDeviceCurrent(){} // RVA: 0x7ffaaf03c7d0
    }

    public class InputProcessor : Object
    {
        // ── Original Methods ──
        public void ProcessAsObject(){} // RVA: 0x7ffaa865aa30
        public void Process(){} // RVA: 0x7ffaa887e5c0
        public void get_cachingPolicy(){} // RVA: 0x7ffaa8f22da0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetValueTypeFromType(){} // RVA: 0x7ffaaefb2100
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaa887e5c0
        public void ProcessAsObject(){} // RVA: 0x7ffaa865aa30
        public void Process(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaab8f3110
        public void ProcessAsObject(){} // RVA: 0x7ffaab8f2f00
        public void Process(){} // RVA: 0x7ffaab8f3110
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaab8f3cb0
        public void ProcessAsObject(){} // RVA: 0x7ffaab8f3a70
        public void Process(){} // RVA: 0x7ffaab8f3cb0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaab8f38f0
        public void ProcessAsObject(){} // RVA: 0x7ffaab8f36d0
        public void Process(){} // RVA: 0x7ffaab8f38f0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaab8f2d50
        public void ProcessAsObject(){} // RVA: 0x7ffaab8f2b30
        public void Process(){} // RVA: 0x7ffaab8f2d50
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaab8f2550
        public void ProcessAsObject(){} // RVA: 0x7ffaab8f2340
        public void Process(){} // RVA: 0x7ffaab8f2550
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaab8f1d20
        public void ProcessAsObject(){} // RVA: 0x7ffaab8f1b10
        public void Process(){} // RVA: 0x7ffaab8f1d20
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaab8f34f0
        public void ProcessAsObject(){} // RVA: 0x7ffaab8f3290
        public void Process(){} // RVA: 0x7ffaab8f34f0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Original Methods ──
        public void Process(){} // RVA: 0x7ffaab8f2550
        public void ProcessAsObject(){} // RVA: 0x7ffaab8f2340
        public void Process(){} // RVA: 0x7ffaab8f2550
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class InputProcessor`1 : InputProcessor
    {
    }

    public class InputProcessor`1 : InputProcessor
    {
    }

    public class InputProcessor`1 : InputProcessor
    {
    }

    public class InputRemoting : Object
    {
        public object m_Subscribers; // 0x317BB9E0

        // ── Original Methods ──
        public void get_sending(){} // RVA: 0x7ffaaf022800
        public void set_sending(){} // RVA: 0x7ffaaf022810
        public void .ctor(){} // RVA: 0x7ffaaf022830
        public void StartSending(){} // RVA: 0x7ffaaf0228f0
        public void StopSending(){} // RVA: 0x7ffaaf022af0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x7ffaaf022cd0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0x7ffaa8932310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0x7ffaa8932310
        public void Subscribe(){} // RVA: 0x7ffaaf022f60
        public void SendInitialMessages(){} // RVA: 0x7ffaaf0230e0
        public void SendAllGeneratedLayouts(){} // RVA: 0x7ffaaf023100
        public void SendLayout(){} // RVA: 0x7ffaaf023380
        public void SendAllDevices(){} // RVA: 0x7ffaaf023420
        public void SendDevice(){} // RVA: 0x7ffaaf023670
        public void SendEvent(){} // RVA: 0x7ffaaf023700
        public void SendDeviceChange(){} // RVA: 0x7ffaaf023760
        public void SendLayoutChange(){} // RVA: 0x7ffaaf0238f0
        public void Send(){} // RVA: 0x7ffaaf023a50
        public void FindOrCreateSenderRecord(){} // RVA: 0x7ffaaf023b90
        public void BuildLayoutNamespace(){} // RVA: 0x7ffaaf023c60
        public void FindLocalDeviceId(){} // RVA: 0x7ffaaf023d30
        public void TryGetDeviceByRemoteId(){} // RVA: 0x7ffaaf023da0
        public void get_manager(){} // RVA: 0x7ffaa89357c0
        public void RemoveRemoteDevices(){} // RVA: 0x7ffaaf023dd0
        public void SerializeData(){} // RVA: 0x7ffaa887e5c0
        public void DeserializeData(){} // RVA: 0x7ffaa887e5c0
    }

    public class InputSettings : ScriptableObject
    {
        public object m_ScrollDeltaBehavior; // 0x317BBD20
        public object m_CompensateForScreenOrientation; // 0x317BBD20
        public object m_InputActionPropertyDrawerMode; // 0x317BBD20
        public object m_DefaultButtonPressPoint; // 0x317BBD20
        public object m_DefaultSlowTapTime; // 0x317BBD20
        public object m_MultiTapDelayTime; // 0x317BBD20
        public object m_FeatureFlags; // 0x317BBD20

        // ── Original Methods ──
        public void get_updateMode(){} // RVA: 0x7ffaa8aeced0
        public void set_updateMode(){} // RVA: 0x7ffaaf041ad0
        public void get_scrollDeltaBehavior(){} // RVA: 0x7ffaa9349010
        public void set_scrollDeltaBehavior(){} // RVA: 0x7ffaaf041ae0
        public void get_compensateForScreenOrientation(){} // RVA: 0x7ffaa8958450
        public void set_compensateForScreenOrientation(){} // RVA: 0x7ffaaf041af0
        public void get_filterNoiseOnCurrent(){} // RVA: 0x7ffaa8932320
        public void set_filterNoiseOnCurrent(){} // RVA: 0x7ffaa8932310
        public void get_defaultDeadzoneMin(){} // RVA: 0x7ffaa8af93a0
        public void set_defaultDeadzoneMin(){} // RVA: 0x7ffaaf041b00
        public void get_defaultDeadzoneMax(){} // RVA: 0x7ffaa893a970
        public void set_defaultDeadzoneMax(){} // RVA: 0x7ffaaf041b20
        public void get_defaultButtonPressPoint(){} // RVA: 0x7ffaa9fe53d0
        public void set_defaultButtonPressPoint(){} // RVA: 0x7ffaaf041b40
        public void get_buttonReleaseThreshold(){} // RVA: 0x7ffaa9168110
        public void set_buttonReleaseThreshold(){} // RVA: 0x7ffaaf041b80
        public void get_defaultTapTime(){} // RVA: 0x7ffaa899a460
        public void set_defaultTapTime(){} // RVA: 0x7ffaaf041ba0
        public void get_defaultSlowTapTime(){} // RVA: 0x7ffaa8dbada0
        public void set_defaultSlowTapTime(){} // RVA: 0x7ffaaf041bc0
        public void get_defaultHoldTime(){} // RVA: 0x7ffaa895afe0
        public void set_defaultHoldTime(){} // RVA: 0x7ffaaf041be0
        public void get_tapRadius(){} // RVA: 0x7ffaa895b000
        public void set_tapRadius(){} // RVA: 0x7ffaaf041c00
        public void get_multiTapDelayTime(){} // RVA: 0x7ffaa8a42e10
        public void set_multiTapDelayTime(){} // RVA: 0x7ffaaf041c20
        public void get_backgroundBehavior(){} // RVA: 0x7ffaa950c6d0
        public void set_backgroundBehavior(){} // RVA: 0x7ffaaf041c40
        public void get_editorInputBehaviorInPlayMode(){} // RVA: 0x7ffaa8fb82b0
        public void set_editorInputBehaviorInPlayMode(){} // RVA: 0x7ffaaf041c50
        public void get_inputActionPropertyDrawerMode(){} // RVA: 0x7ffaa8de7460
        public void set_inputActionPropertyDrawerMode(){} // RVA: 0x7ffaaf041c60
        public void get_maxEventBytesPerUpdate(){} // RVA: 0x7ffaa8d14570
        public void set_maxEventBytesPerUpdate(){} // RVA: 0x7ffaaf041c70
        public void get_maxQueuedEventsPerUpdate(){} // RVA: 0x7ffaa96cc980
        public void set_maxQueuedEventsPerUpdate(){} // RVA: 0x7ffaaf041c80
        public void get_supportedDevices(){} // RVA: 0x7ffaaf041c90
        public void set_supportedDevices(){} // RVA: 0x7ffaaf041d50
        public void get_disableRedundantEventsMerging(){} // RVA: 0x7ffaa9970570
        public void set_disableRedundantEventsMerging(){} // RVA: 0x7ffaaf041f00
        public void get_shortcutKeysConsumeInput(){} // RVA: 0x7ffaae8c22f0
        public void set_shortcutKeysConsumeInput(){} // RVA: 0x7ffaaf041f10
        public void IsFeatureEnabled(){} // RVA: 0x7ffaaf0420e0
        public void OnChange(){} // RVA: 0x7ffaaf042160
        public void CompareFloats(){} // RVA: 0x7ffaaf0422e0
        public void CompareSets(){} // RVA: 0x7ffaa887e5c0
        public void CompareFeatureFlag(){} // RVA: 0x7ffaaf042300
        public void AreEqual(){} // RVA: 0x7ffaaf0423f0
        public void .ctor(){} // RVA: 0x7ffaaf042b30
        // ── Binary Analysis Named ──
        public void SetInternalFeatureFlag(){} // RVA: 0x7ffaaf041f20
    }

    public class InputSystem : Object
    {
        public object k_InputResetMarker; // 0x317E0460
        public object s_Remote; // 0x317E0460

        // ── Original Methods ──
        public void add_onLayoutChange(){} // RVA: 0x7ffaaef9d360
        public void remove_onLayoutChange(){} // RVA: 0x7ffaaef9d550
        public void RegisterLayout(){} // RVA: 0x7ffaaef9d8e0
        public void RegisterLayout(){} // RVA: 0x7ffaaef9d8e0
        public void RegisterLayout(){} // RVA: 0x7ffaaef9d8e0
        public void RegisterLayoutOverride(){} // RVA: 0x7ffaaef9d9f0
        public void RegisterLayoutMatcher(){} // RVA: 0x7ffaa887e5c0
        public void RegisterLayoutMatcher(){} // RVA: 0x7ffaa887e5c0
        public void RegisterLayoutBuilder(){} // RVA: 0x7ffaaef9db00
        public void RegisterPrecompiledLayout(){} // RVA: 0x7ffaa8660d50
        public void RemoveLayout(){} // RVA: 0x7ffaaef9dcd0
        public void TryFindMatchingLayout(){} // RVA: 0x7ffaaef9dd40
        public void ListLayouts(){} // RVA: 0x7ffaaef9de10
        public void ListLayoutsBasedOn(){} // RVA: 0x7ffaaef9de80
        public void LoadLayout(){} // RVA: 0x7ffaa8648dd0
        public void LoadLayout(){} // RVA: 0x7ffaa8648dd0
        public void IsFirstLayoutBasedOnSecond(){} // RVA: 0x7ffaaef9e250
        public void RegisterProcessor(){} // RVA: 0x7ffaa8660d50
        public void RegisterProcessor(){} // RVA: 0x7ffaa8660d50
        public void TryGetProcessor(){} // RVA: 0x7ffaaef9e8a0
        public void ListProcessors(){} // RVA: 0x7ffaaef9e980
        public void get_devices(){} // RVA: 0x7ffaaef9ea00
        public void get_disconnectedDevices(){} // RVA: 0x7ffaaef9ea80
        public void add_onDeviceChange(){} // RVA: 0x7ffaaef9eb70
        public void remove_onDeviceChange(){} // RVA: 0x7ffaaef9edc0
        public void add_onDeviceCommand(){} // RVA: 0x7ffaaef9f010
        public void remove_onDeviceCommand(){} // RVA: 0x7ffaaef9f260
        public void add_onFindLayoutForDevice(){} // RVA: 0x7ffaaef9f4b0
        public void remove_onFindLayoutForDevice(){} // RVA: 0x7ffaaef9f6b0
        public void get_pollingFrequency(){} // RVA: 0x7ffaaef9f8a0
        public void set_pollingFrequency(){} // RVA: 0x7ffaaef9f910
        public void AddDevice(){} // RVA: 0x7ffaaef9fca0
        public void AddDevice(){} // RVA: 0x7ffaaef9fca0
        public void AddDevice(){} // RVA: 0x7ffaaef9fca0
        public void AddDevice(){} // RVA: 0x7ffaaef9fca0
        public void RemoveDevice(){} // RVA: 0x7ffaaef9fd60
        public void FlushDisconnectedDevices(){} // RVA: 0x7ffaaef9fde0
        public void EnableDevice(){} // RVA: 0x7ffaaefa0510
        public void DisableDevice(){} // RVA: 0x7ffaaefa0590
        public void TrySyncDevice(){} // RVA: 0x7ffaaefa0620
        public void ResetDevice(){} // RVA: 0x7ffaaefa06f0
        public void TryResetDevice(){} // RVA: 0x7ffaaefa0780
        public void PauseHaptics(){} // RVA: 0x7ffaaefa07f0
        public void ResumeHaptics(){} // RVA: 0x7ffaaefa0940
        public void ResetHaptics(){} // RVA: 0x7ffaaefa0a90
        public void AddDeviceUsage(){} // RVA: 0x7ffaaefa0e20
        public void AddDeviceUsage(){} // RVA: 0x7ffaaefa0e20
        public void RemoveDeviceUsage(){} // RVA: 0x7ffaaefa0f70
        public void RemoveDeviceUsage(){} // RVA: 0x7ffaaefa0f70
        public void FindControl(){} // RVA: 0x7ffaaefa1000
        public void FindControls(){} // RVA: 0x7ffaa864ea70
        public void FindControls(){} // RVA: 0x7ffaa864ea70
        public void FindControls(){} // RVA: 0x7ffaa864ea70
        public void get_isProcessingEvents(){} // RVA: 0x7ffaaefa1340
        public void get_onEvent(){} // RVA: 0x7ffaa8932320
        public void set_onEvent(){} // RVA: 0x7ffaa8932310
        public void get_onAnyButtonPress(){} // RVA: 0x7ffaaefa13b0
        public void QueueEvent(){} // RVA: 0x7ffaa8660d50
        public void QueueEvent(){} // RVA: 0x7ffaa8660d50
        public void QueueStateEvent(){} // RVA: 0x7ffaa887e5c0
        public void QueueDeltaStateEvent(){} // RVA: 0x7ffaa887e5c0
        public void QueueConfigChangeEvent(){} // RVA: 0x7ffaaefa1aa0
        public void QueueTextEvent(){} // RVA: 0x7ffaaefa1ce0
        public void Update(){} // RVA: 0x7ffaaefa2020
        public void Update(){} // RVA: 0x7ffaaefa2020
        public void add_onBeforeUpdate(){} // RVA: 0x7ffaaefa21d0
        public void remove_onBeforeUpdate(){} // RVA: 0x7ffaaefa23d0
        public void add_onAfterUpdate(){} // RVA: 0x7ffaaefa25c0
        public void remove_onAfterUpdate(){} // RVA: 0x7ffaaefa27b0
        public void get_settings(){} // RVA: 0x7ffaaefa29a0
        public void set_settings(){} // RVA: 0x7ffaaefa2a10
        public void add_onSettingsChange(){} // RVA: 0x7ffaaefa2c50
        public void remove_onSettingsChange(){} // RVA: 0x7ffaaefa2d00
        public void EnableActions(){} // RVA: 0x7ffaaefa2db0
        public void DisableActions(){} // RVA: 0x7ffaaefa2ed0
        public void get_actions(){} // RVA: 0x7ffaaefa2fe0
        public void set_actions(){} // RVA: 0x7ffaaefa3050
        public void add_onActionsChange(){} // RVA: 0x7ffaaefa32b0
        public void remove_onActionsChange(){} // RVA: 0x7ffaaefa3360
        public void add_onActionChange(){} // RVA: 0x7ffaaefa3410
        public void remove_onActionChange(){} // RVA: 0x7ffaaefa34e0
        public void RegisterInteraction(){} // RVA: 0x7ffaa8660d50
        public void RegisterInteraction(){} // RVA: 0x7ffaa8660d50
        public void TryGetInteraction(){} // RVA: 0x7ffaaefa3740
        public void ListInteractions(){} // RVA: 0x7ffaaefa3820
        public void RegisterBindingComposite(){} // RVA: 0x7ffaa8660d50
        public void RegisterBindingComposite(){} // RVA: 0x7ffaa8660d50
        public void TryGetBindingComposite(){} // RVA: 0x7ffaaefa3a30
        public void DisableAllEnabledActions(){} // RVA: 0x7ffaaefa3b10
        public void ListEnabledActions(){} // RVA: 0x7ffaaefa3e00
        public void ListEnabledActions(){} // RVA: 0x7ffaaefa3e00
        public void get_remoting(){} // RVA: 0x7ffaaefa3ea0
        public void get_version(){} // RVA: 0x7ffaaefa3f00
        public void get_runInBackground(){} // RVA: 0x7ffaaefa4030
        public void set_runInBackground(){} // RVA: 0x7ffaaefa40c0
        public void get_metrics(){} // RVA: 0x7ffaaefa4160
        public void .cctor(){} // RVA: 0x7ffaaefa4200
        public void RunInitializeInPlayer(){} // RVA: 0x7ffaaefa42b0
        public void EnsureInitialized(){} // RVA: 0x7ffaa8932310
        public void InitializeInPlayer(){} // RVA: 0x7ffaaefa4330
        public void RunInitialUpdate(){} // RVA: 0x7ffaaefa46b0
        public void PerformDefaultPluginInitialization(){} // RVA: 0x7ffaaefa4790
        // ── Binary Analysis Named ──
        public void GetNameOfBaseLayout(){} // RVA: 0x7ffaaef9e050
        public void GetDevice(){} // RVA: 0x7ffaa887e5c0
        public void GetDevice(){} // RVA: 0x7ffaa887e5c0
        public void GetDevice(){} // RVA: 0x7ffaa887e5c0
        public void GetDevice(){} // RVA: 0x7ffaa887e5c0
        public void GetDevice(){} // RVA: 0x7ffaa887e5c0
        public void GetDeviceById(){} // RVA: 0x7ffaaefa01d0
        public void GetUnsupportedDevices(){} // RVA: 0x7ffaaefa02d0
        public void GetUnsupportedDevices(){} // RVA: 0x7ffaaefa02d0
        public void SetDeviceUsage(){} // RVA: 0x7ffaaefa0cd0
        public void SetDeviceUsage(){} // RVA: 0x7ffaaefa0cd0
    }

    public class InputValue : Object
    {
        // ── Original Methods ──
        public void get_isPressed(){} // RVA: 0x7ffaaf047e30
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffaa887e5c0
        public void Get(){} // RVA: 0x7ffaa887e5c0
    }

    public class Joystick : InputDevice
    {
        public object _twist; // 0x33C0D1F0, was: <twist>k__BackingField
        public object s_JoystickCount; // 0x33C0D1F0

        // ── Original Methods ──
        public void get_trigger(){} // RVA: 0x7ffaa8f77bc0
        public void set_trigger(){} // RVA: 0x7ffaa93f5420
        public void get_stick(){} // RVA: 0x7ffaa8f75d50
        public void set_stick(){} // RVA: 0x7ffaa94036f0
        public void get_twist(){} // RVA: 0x7ffaa8f74750
        public void set_twist(){} // RVA: 0x7ffaa93e77a0
        public void get_hatswitch(){} // RVA: 0x7ffaa8f6f0e0
        public void set_hatswitch(){} // RVA: 0x7ffaa93ff2c0
        public void get_current(){} // RVA: 0x7ffaaefb64d0
        public void set_current(){} // RVA: 0x7ffaaefb6510
        public void get_all(){} // RVA: 0x7ffaaefb65b0
        public void FinishSetup(){} // RVA: 0x7ffaaefb6670
        public void MakeCurrent(){} // RVA: 0x7ffaaefb68f0
        public void OnAdded(){} // RVA: 0x7ffaaefb6900
        public void OnRemoved(){} // RVA: 0x7ffaaefb6980
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class Keyboard : InputDevice
    {
        public object _anyKey; // 0x33664480, was: <anyKey>k__BackingField
        public object _altKey; // 0x33664480, was: <altKey>k__BackingField
        public object m_TextInputListeners; // 0x33664480
        public object m_ImeCompositionListeners; // 0x33664480

        // ── Original Methods ──
        public void add_onTextInput(){} // RVA: 0x7ffaaefb6b10
        public void remove_onTextInput(){} // RVA: 0x7ffaaefb6c00
        public void add_onIMECompositionChange(){} // RVA: 0x7ffaaefb6c60
        public void remove_onIMECompositionChange(){} // RVA: 0x7ffaaefb6d50
        public void get_keyboardLayout(){} // RVA: 0x7ffaaefb6ec0
        public void set_keyboardLayout(){} // RVA: 0x7ffaa93e7fd0
        public void get_anyKey(){} // RVA: 0x7ffaa8f77bc0
        public void set_anyKey(){} // RVA: 0x7ffaa93f5420
        public void get_spaceKey(){} // RVA: 0x7ffaaefb6f10
        public void get_enterKey(){} // RVA: 0x7ffaaefb6f20
        public void get_tabKey(){} // RVA: 0x7ffaaefb6f30
        public void get_backquoteKey(){} // RVA: 0x7ffaaefb6f40
        public void get_quoteKey(){} // RVA: 0x7ffaaefb6f50
        public void get_semicolonKey(){} // RVA: 0x7ffaaefb6f60
        public void get_commaKey(){} // RVA: 0x7ffaaefb6f70
        public void get_periodKey(){} // RVA: 0x7ffaaefb6f80
        public void get_slashKey(){} // RVA: 0x7ffaaefb6f90
        public void get_backslashKey(){} // RVA: 0x7ffaaefb6fa0
        public void get_leftBracketKey(){} // RVA: 0x7ffaaefb6fb0
        public void get_rightBracketKey(){} // RVA: 0x7ffaaefb6fc0
        public void get_minusKey(){} // RVA: 0x7ffaaefb6fd0
        public void get_equalsKey(){} // RVA: 0x7ffaaefb6fe0
        public void get_aKey(){} // RVA: 0x7ffaaefb6ff0
        public void get_bKey(){} // RVA: 0x7ffaaefb7000
        public void get_cKey(){} // RVA: 0x7ffaaefb7010
        public void get_dKey(){} // RVA: 0x7ffaaefb7020
        public void get_eKey(){} // RVA: 0x7ffaaefb7030
        public void get_fKey(){} // RVA: 0x7ffaaefb7040
        public void get_gKey(){} // RVA: 0x7ffaaefb7050
        public void get_hKey(){} // RVA: 0x7ffaaefb7060
        public void get_iKey(){} // RVA: 0x7ffaaefb7070
        public void get_jKey(){} // RVA: 0x7ffaaefb7080
        public void get_kKey(){} // RVA: 0x7ffaaefb7090
        public void get_lKey(){} // RVA: 0x7ffaaefb70a0
        public void get_mKey(){} // RVA: 0x7ffaaefb70b0
        public void get_nKey(){} // RVA: 0x7ffaaefb70c0
        public void get_oKey(){} // RVA: 0x7ffaaefb70d0
        public void get_pKey(){} // RVA: 0x7ffaaefb70e0
        public void get_qKey(){} // RVA: 0x7ffaaefb70f0
        public void get_rKey(){} // RVA: 0x7ffaaefb7100
        public void get_sKey(){} // RVA: 0x7ffaaefb7110
        public void get_tKey(){} // RVA: 0x7ffaaefb7120
        public void get_uKey(){} // RVA: 0x7ffaaefb7130
        public void get_vKey(){} // RVA: 0x7ffaaefb7140
        public void get_wKey(){} // RVA: 0x7ffaaefb7150
        public void get_xKey(){} // RVA: 0x7ffaaefb7160
        public void get_yKey(){} // RVA: 0x7ffaaefb7170
        public void get_zKey(){} // RVA: 0x7ffaaefb7180
        public void get_digit1Key(){} // RVA: 0x7ffaaefb7190
        public void get_digit2Key(){} // RVA: 0x7ffaaefb71a0
        public void get_digit3Key(){} // RVA: 0x7ffaaefb71b0
        public void get_digit4Key(){} // RVA: 0x7ffaaefb71c0
        public void get_digit5Key(){} // RVA: 0x7ffaaefb71d0
        public void get_digit6Key(){} // RVA: 0x7ffaaefb71e0
        public void get_digit7Key(){} // RVA: 0x7ffaaefb71f0
        public void get_digit8Key(){} // RVA: 0x7ffaaefb7200
        public void get_digit9Key(){} // RVA: 0x7ffaaefb7210
        public void get_digit0Key(){} // RVA: 0x7ffaaefb7220
        public void get_leftShiftKey(){} // RVA: 0x7ffaaefb7230
        public void get_rightShiftKey(){} // RVA: 0x7ffaaefb7240
        public void get_leftAltKey(){} // RVA: 0x7ffaaefb7250
        public void get_rightAltKey(){} // RVA: 0x7ffaaefb7260
        public void get_leftCtrlKey(){} // RVA: 0x7ffaaefb7270
        public void get_rightCtrlKey(){} // RVA: 0x7ffaaefb7280
        public void get_leftMetaKey(){} // RVA: 0x7ffaaefb7290
        public void get_rightMetaKey(){} // RVA: 0x7ffaaefb72a0
        public void get_leftWindowsKey(){} // RVA: 0x7ffaaefb7290
        public void get_rightWindowsKey(){} // RVA: 0x7ffaaefb72a0
        public void get_leftAppleKey(){} // RVA: 0x7ffaaefb7290
        public void get_rightAppleKey(){} // RVA: 0x7ffaaefb72a0
        public void get_leftCommandKey(){} // RVA: 0x7ffaaefb7290
        public void get_rightCommandKey(){} // RVA: 0x7ffaaefb72a0
        public void get_contextMenuKey(){} // RVA: 0x7ffaaefb72b0
        public void get_escapeKey(){} // RVA: 0x7ffaaefb72c0
        public void get_leftArrowKey(){} // RVA: 0x7ffaaefb72d0
        public void get_rightArrowKey(){} // RVA: 0x7ffaaefb72e0
        public void get_upArrowKey(){} // RVA: 0x7ffaaefb72f0
        public void get_downArrowKey(){} // RVA: 0x7ffaaefb7300
        public void get_backspaceKey(){} // RVA: 0x7ffaaefb7310
        public void get_pageDownKey(){} // RVA: 0x7ffaaefb7320
        public void get_pageUpKey(){} // RVA: 0x7ffaaefb7330
        public void get_homeKey(){} // RVA: 0x7ffaaefb7340
        public void get_endKey(){} // RVA: 0x7ffaaefb7350
        public void get_insertKey(){} // RVA: 0x7ffaaefb7360
        public void get_deleteKey(){} // RVA: 0x7ffaaefb7370
        public void get_capsLockKey(){} // RVA: 0x7ffaaefb7380
        public void get_scrollLockKey(){} // RVA: 0x7ffaaefb7390
        public void get_numLockKey(){} // RVA: 0x7ffaaefb73a0
        public void get_printScreenKey(){} // RVA: 0x7ffaaefb73b0
        public void get_pauseKey(){} // RVA: 0x7ffaaefb73c0
        public void get_numpadEnterKey(){} // RVA: 0x7ffaaefb73d0
        public void get_numpadDivideKey(){} // RVA: 0x7ffaaefb73e0
        public void get_numpadMultiplyKey(){} // RVA: 0x7ffaaefb73f0
        public void get_numpadMinusKey(){} // RVA: 0x7ffaaefb7400
        public void get_numpadPlusKey(){} // RVA: 0x7ffaaefb7410
        public void get_numpadPeriodKey(){} // RVA: 0x7ffaaefb7420
        public void get_numpadEqualsKey(){} // RVA: 0x7ffaaefb7430
        public void get_numpad0Key(){} // RVA: 0x7ffaaefb7440
        public void get_numpad1Key(){} // RVA: 0x7ffaaefb7450
        public void get_numpad2Key(){} // RVA: 0x7ffaaefb7460
        public void get_numpad3Key(){} // RVA: 0x7ffaaefb7470
        public void get_numpad4Key(){} // RVA: 0x7ffaaefb7480
        public void get_numpad5Key(){} // RVA: 0x7ffaaefb7490
        public void get_numpad6Key(){} // RVA: 0x7ffaaefb74a0
        public void get_numpad7Key(){} // RVA: 0x7ffaaefb74b0
        public void get_numpad8Key(){} // RVA: 0x7ffaaefb74c0
        public void get_numpad9Key(){} // RVA: 0x7ffaaefb74d0
        public void get_f1Key(){} // RVA: 0x7ffaaefb74e0
        public void get_f2Key(){} // RVA: 0x7ffaaefb74f0
        public void get_f3Key(){} // RVA: 0x7ffaaefb7500
        public void get_f4Key(){} // RVA: 0x7ffaaefb7510
        public void get_f5Key(){} // RVA: 0x7ffaaefb7520
        public void get_f6Key(){} // RVA: 0x7ffaaefb7530
        public void get_f7Key(){} // RVA: 0x7ffaaefb7540
        public void get_f8Key(){} // RVA: 0x7ffaaefb7550
        public void get_f9Key(){} // RVA: 0x7ffaaefb7560
        public void get_f10Key(){} // RVA: 0x7ffaaefb7570
        public void get_f11Key(){} // RVA: 0x7ffaaefb7580
        public void get_f12Key(){} // RVA: 0x7ffaaefb7590
        public void get_oem1Key(){} // RVA: 0x7ffaaefb75a0
        public void get_oem2Key(){} // RVA: 0x7ffaaefb75b0
        public void get_oem3Key(){} // RVA: 0x7ffaaefb75c0
        public void get_oem4Key(){} // RVA: 0x7ffaaefb75d0
        public void get_oem5Key(){} // RVA: 0x7ffaaefb75e0
        public void get_f13Key(){} // RVA: 0x7ffaaefb75f0
        public void get_f14Key(){} // RVA: 0x7ffaaefb7600
        public void get_f15Key(){} // RVA: 0x7ffaaefb7610
        public void get_f16Key(){} // RVA: 0x7ffaaefb7620
        public void get_f17Key(){} // RVA: 0x7ffaaefb7630
        public void get_f18Key(){} // RVA: 0x7ffaaefb7640
        public void get_f19Key(){} // RVA: 0x7ffaaefb7650
        public void get_f20Key(){} // RVA: 0x7ffaaefb7660
        public void get_f21Key(){} // RVA: 0x7ffaaefb7670
        public void get_f22Key(){} // RVA: 0x7ffaaefb7680
        public void get_f23Key(){} // RVA: 0x7ffaaefb7690
        public void get_f24Key(){} // RVA: 0x7ffaaefb76a0
        public void get_shiftKey(){} // RVA: 0x7ffaa8f75d50
        public void set_shiftKey(){} // RVA: 0x7ffaa94036f0
        public void get_ctrlKey(){} // RVA: 0x7ffaa8f74750
        public void set_ctrlKey(){} // RVA: 0x7ffaa93e77a0
        public void get_altKey(){} // RVA: 0x7ffaa8f6f0e0
        public void set_altKey(){} // RVA: 0x7ffaa93ff2c0
        public void get_imeSelected(){} // RVA: 0x7ffaa8f6f0f0
        public void set_imeSelected(){} // RVA: 0x7ffaa93d9af0
        public void get_Item(){} // RVA: 0x7ffaaefb76b0
        public void get_allKeys(){} // RVA: 0x7ffaaefb7750
        public void get_current(){} // RVA: 0x7ffaaefb7820
        public void set_current(){} // RVA: 0x7ffaaefb7860
        public void MakeCurrent(){} // RVA: 0x7ffaaefb7900
        public void OnRemoved(){} // RVA: 0x7ffaaefb7910
        public void FinishSetup(){} // RVA: 0x7ffaaefb7960
        public void RefreshConfiguration(){} // RVA: 0x7ffaaefb8f90
        public void OnTextInput(){} // RVA: 0x7ffaaefb9160
        public void FindKeyOnCurrentKeyboardLayout(){} // RVA: 0x7ffaaefb91f0
        public void OnIMECompositionChanged(){} // RVA: 0x7ffaaefb9400
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7ffaaefb9510
        public void get_keys(){} // RVA: 0x7ffaa93e8b10
        public void set_keys(){} // RVA: 0x7ffaa9400010
        public void .ctor(){} // RVA: 0x7ffaaef38410
        // ── Binary Analysis Named ──
        public void SetIMEEnabled(){} // RVA: 0x7ffaaefb6db0
        public void SetIMECursorPosition(){} // RVA: 0x7ffaaefb6e30
    }

    public class LightSensor : Sensor
    {
        // ── Original Methods ──
        public void get_lightLevel(){} // RVA: 0x7ffaa8f77bc0
        public void set_lightLevel(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf028da0
        public void set_current(){} // RVA: 0x7ffaaf028de0
        public void MakeCurrent(){} // RVA: 0x7ffaaf028e80
        public void OnRemoved(){} // RVA: 0x7ffaaf028e90
        public void FinishSetup(){} // RVA: 0x7ffaaf028ee0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class LinearAccelerationSensor : Sensor
    {
        // ── Original Methods ──
        public void get_acceleration(){} // RVA: 0x7ffaa8f77bc0
        public void set_acceleration(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf0289c0
        public void set_current(){} // RVA: 0x7ffaaf028a00
        public void MakeCurrent(){} // RVA: 0x7ffaaf028aa0
        public void OnRemoved(){} // RVA: 0x7ffaaf028ab0
        public void FinishSetup(){} // RVA: 0x7ffaaf028b00
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class MagneticFieldSensor : Sensor
    {
        // ── Original Methods ──
        public void get_magneticField(){} // RVA: 0x7ffaa8f77bc0
        public void set_magneticField(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf028bb0
        public void set_current(){} // RVA: 0x7ffaaf028bf0
        public void MakeCurrent(){} // RVA: 0x7ffaaf028c90
        public void OnRemoved(){} // RVA: 0x7ffaaf028ca0
        public void FinishSetup(){} // RVA: 0x7ffaaf028cf0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class Mouse : Pointer
    {
        public object _middleButton; // 0x335A2E40, was: <middleButton>k__BackingField
        public object _forwardButton; // 0x335A2E40, was: <forwardButton>k__BackingField
        public object s_PlatformMouseDevice; // 0x335A2E40
        public object scroll; // 0x1700026B
        public object leftButton; // 0x1700026C
        public object middleButton; // 0x1700026D

        // ── Original Methods ──
        public void get_scroll(){} // RVA: 0x7ffaa8f73670
        public void set_scroll(){} // RVA: 0x7ffaa93e9360
        public void get_leftButton(){} // RVA: 0x7ffaa93d5320
        public void set_leftButton(){} // RVA: 0x7ffaa93e3d80
        public void get_middleButton(){} // RVA: 0x7ffaa93d4100
        public void set_middleButton(){} // RVA: 0x7ffaa93e7fd0
        public void get_rightButton(){} // RVA: 0x7ffaa93e8b10
        public void set_rightButton(){} // RVA: 0x7ffaa9400010
        public void get_backButton(){} // RVA: 0x7ffaa8e19790
        public void set_backButton(){} // RVA: 0x7ffaa93fdbe0
        public void get_forwardButton(){} // RVA: 0x7ffaa93d15b0
        public void set_forwardButton(){} // RVA: 0x7ffaa93d3cc0
        public void get_clickCount(){} // RVA: 0x7ffaa8f6fa20
        public void set_clickCount(){} // RVA: 0x7ffaa8f774b0
        public void get_current(){} // RVA: 0x7ffaaefb9550
        public void set_current(){} // RVA: 0x7ffaaefb9590
        public void MakeCurrent(){} // RVA: 0x7ffaaefb9630
        public void OnAdded(){} // RVA: 0x7ffaaefb9650
        public void OnRemoved(){} // RVA: 0x7ffaaefb9700
        public void WarpCursorPosition(){} // RVA: 0x7ffaaefb9790
        public void FinishSetup(){} // RVA: 0x7ffaaefb9820
        public void OnNextUpdate(){} // RVA: 0x7ffaaefb9c90
        public void OnStateEvent(){} // RVA: 0x7ffaaefb9d60
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7ffaaefb9c90
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7ffaaefb9e10
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class Pen : Pointer
    {
        public object _firstBarrelButton; // 0x336D4B90, was: <firstBarrelButton>k__BackingF
        public object _fourthBarrelButton; // 0x336D4B90, was: <fourthBarrelButton>k__Backing
        public object _twist; // 0x336D4B90, was: <twist>k__BackingField
        public object ; // 0x33E01E10

        // ── Original Methods ──
        public void get_tip(){} // RVA: 0x7ffaa8f73670
        public void set_tip(){} // RVA: 0x7ffaa93e9360
        public void get_eraser(){} // RVA: 0x7ffaa93d5320
        public void set_eraser(){} // RVA: 0x7ffaa93e3d80
        public void get_firstBarrelButton(){} // RVA: 0x7ffaa93d4100
        public void set_firstBarrelButton(){} // RVA: 0x7ffaa93e7fd0
        public void get_secondBarrelButton(){} // RVA: 0x7ffaa93e8b10
        public void set_secondBarrelButton(){} // RVA: 0x7ffaa9400010
        public void get_thirdBarrelButton(){} // RVA: 0x7ffaa8e19790
        public void set_thirdBarrelButton(){} // RVA: 0x7ffaa93fdbe0
        public void get_fourthBarrelButton(){} // RVA: 0x7ffaa93d15b0
        public void set_fourthBarrelButton(){} // RVA: 0x7ffaa93d3cc0
        public void get_inRange(){} // RVA: 0x7ffaa8f6fa20
        public void set_inRange(){} // RVA: 0x7ffaa8f774b0
        public void get_tilt(){} // RVA: 0x7ffaa8f74aa0
        public void set_tilt(){} // RVA: 0x7ffaa8f744d0
        public void get_twist(){} // RVA: 0x7ffaa8f7aa00
        public void set_twist(){} // RVA: 0x7ffaa8f77dc0
        public void get_current(){} // RVA: 0x7ffaaefb9e20
        public void set_current(){} // RVA: 0x7ffaaefb9e60
        public void get_Item(){} // RVA: 0x7ffaaefb9f00
        public void MakeCurrent(){} // RVA: 0x7ffaaefba040
        public void OnRemoved(){} // RVA: 0x7ffaaefba060
        public void FinishSetup(){} // RVA: 0x7ffaaefba0f0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class PlayerInput : MonoBehaviour
    {
        public object ControlsChangedMessage; // 0x3185B1A0
        public object m_NotificationBehavior; // 0x3185B1A0
        public object m_DeviceRegainedEvent; // 0x3185B1A0
        public object m_NeverAutoSwitchControlSchemes; // 0x3185B1A0
        public object m_SplitScreenIndex; // 0x3185B1A0
        public object m_CurrentActionMap; // 0x3185B1A0
        public object m_Enabled; // 0x3185B1A0
        public object m_InputUser; // 0x3185B1A0
        public object m_DeviceRegainedCallbacks; // 0x3185B1A0
        public object m_UnpairedDeviceUsedDelegate; // 0x3185B1A0
        public object m_DeviceChangeDelegate; // 0x3185B1A0
        public object s_AllActivePlayers; // 0x3185B1A0
        public object s_InitPairWithDevices; // 0x3185B1A0
        public object s_InitControlScheme; // 0x3185B1A0
        public object k_InputUserOnChangeMarker; // 0x33C07210
        public object s_GlobalState; // 0x33C07210
        public object allUserCount; // 0x83E601B0
        public object allUsers; // 0x83E601B0
        public object allLostDevices; // 0x83E601B0
        public object onUnpairedDeviceUsed; // 0x83E601B0
        public object onDeviceChangeDelegate; // 0x83E601B0

        // ── Original Methods ──
        public void get_inputIsActive(){} // RVA: 0x7ffaae531530
        public void get_active(){} // RVA: 0x7ffaae531530
        public void get_playerIndex(){} // RVA: 0x7ffaaa2a8330
        public void get_splitScreenIndex(){} // RVA: 0x7ffaa9fb1a70
        public void get_actions(){} // RVA: 0x7ffaaf047f30
        public void set_actions(){} // RVA: 0x7ffaaf048000
        public void get_currentControlScheme(){} // RVA: 0x7ffaaf048350
        public void get_defaultControlScheme(){} // RVA: 0x7ffaa89add50
        public void set_defaultControlScheme(){} // RVA: 0x7ffaa89add60
        public void get_neverAutoSwitchControlSchemes(){} // RVA: 0x7ffaa895b020
        public void set_neverAutoSwitchControlSchemes(){} // RVA: 0x7ffaaf048420
        public void get_currentActionMap(){} // RVA: 0x7ffaa8d1b980
        public void set_currentActionMap(){} // RVA: 0x7ffaaf048460
        public void get_defaultActionMap(){} // RVA: 0x7ffaa89fa590
        public void set_defaultActionMap(){} // RVA: 0x7ffaa89fa5a0
        public void get_notificationBehavior(){} // RVA: 0x7ffaa898dcd0
        public void set_notificationBehavior(){} // RVA: 0x7ffaaf048700
        public void get_actionEvents(){} // RVA: 0x7ffaaf048750
        public void set_actionEvents(){} // RVA: 0x7ffaaf048820
        public void get_deviceLostEvent(){} // RVA: 0x7ffaaf0488e0
        public void get_deviceRegainedEvent(){} // RVA: 0x7ffaaf0489b0
        public void get_controlsChangedEvent(){} // RVA: 0x7ffaaf048a80
        public void add_onActionTriggered(){} // RVA: 0x7ffaaf048b50
        public void remove_onActionTriggered(){} // RVA: 0x7ffaaf048bf0
        public void add_onDeviceLost(){} // RVA: 0x7ffaaf048c90
        public void remove_onDeviceLost(){} // RVA: 0x7ffaaf048d30
        public void add_onDeviceRegained(){} // RVA: 0x7ffaaf048dd0
        public void remove_onDeviceRegained(){} // RVA: 0x7ffaaf048e70
        public void add_onControlsChanged(){} // RVA: 0x7ffaaf048f10
        public void remove_onControlsChanged(){} // RVA: 0x7ffaaf048fb0
        public void get_camera(){} // RVA: 0x7ffaa8d1a3b0
        public void set_camera(){} // RVA: 0x7ffaa8efece0
        public void get_uiInputModule(){} // RVA: 0x7ffaa8bf45b0
        public void set_uiInputModule(){} // RVA: 0x7ffaaf049050
        public void get_user(){} // RVA: 0x7ffaa9325970
        public void get_devices(){} // RVA: 0x7ffaaf0494b0
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7ffaaf049560
        public void get_all(){} // RVA: 0x7ffaaf049660
        public void get_isSinglePlayer(){} // RVA: 0x7ffaaf049740
        public void ActivateInput(){} // RVA: 0x7ffaaf0498d0
        public void UpdateDelegates(){} // RVA: 0x7ffaaf049a00
        public void DeactivateInput(){} // RVA: 0x7ffaaf049cd0
        public void PassivateInput(){} // RVA: 0x7ffaaf049cd0
        public void SwitchCurrentControlScheme(){} // RVA: 0x7ffaaf049f60
        public void SwitchCurrentControlScheme(){} // RVA: 0x7ffaaf049f60
        public void SwitchCurrentActionMap(){} // RVA: 0x7ffaaf04a0b0
        public void FindFirstPairedToDevice(){} // RVA: 0x7ffaaf04a390
        public void Instantiate(){} // RVA: 0x7ffaaf04a830
        public void Instantiate(){} // RVA: 0x7ffaaf04a830
        public void InitializeActions(){} // RVA: 0x7ffaaf04b030
        public void CopyActionAssetAndApplyBindingOverrides(){} // RVA: 0x7ffaaf04b5e0
        public void UninitializeActions(){} // RVA: 0x7ffaaf04b960
        public void InstallOnActionTriggeredHook(){} // RVA: 0x7ffaaf04bc20
        public void UninstallOnActionTriggeredHook(){} // RVA: 0x7ffaaf04bef0
        public void OnActionTriggered(){} // RVA: 0x7ffaaf04c110
        public void CacheMessageNames(){} // RVA: 0x7ffaaf04c410
        public void ClearCaches(){} // RVA: 0x7ffaaf04c940
        public void AssignUserAndDevices(){} // RVA: 0x7ffaaf04c9a0
        public void HaveBindingForDevice(){} // RVA: 0x7ffaaf04d720
        public void UnassignUserAndDevices(){} // RVA: 0x7ffaaf04d8b0
        public void TryToActivateControlScheme(){} // RVA: 0x7ffaaf04da50
        public void AssignPlayerIndex(){} // RVA: 0x7ffaaf04de80
        public void Awake(){} // RVA: 0x7ffaaf04e120
        public void OnEnable(){} // RVA: 0x7ffaaf04e200
        public void StartListeningForUnpairedDeviceActivity(){} // RVA: 0x7ffaaf04e9c0
        public void StopListeningForUnpairedDeviceActivity(){} // RVA: 0x7ffaaf04eca0
        public void StartListeningForDeviceChanges(){} // RVA: 0x7ffaaf04ee30
        public void StopListeningForDeviceChanges(){} // RVA: 0x7ffaaf04ef50
        public void OnDisable(){} // RVA: 0x7ffaaf04efc0
        public void DebugLogAction(){} // RVA: 0x7ffaaf04f510
        public void HandleDeviceLost(){} // RVA: 0x7ffaaf04f570
        public void HandleDeviceRegained(){} // RVA: 0x7ffaaf04f690
        public void HandleControlsChanged(){} // RVA: 0x7ffaaf04f7b0
        public void OnUserChange(){} // RVA: 0x7ffaaf04f8d0
        public void OnPreFilterUnpairedDeviceUsed(){} // RVA: 0x7ffaaf04fac0
        public void OnUnpairedDeviceUsed(){} // RVA: 0x7ffaaf04fe60
        public void OnDeviceChange(){} // RVA: 0x7ffaaf050770
        public void SwitchControlSchemeInternal(){} // RVA: 0x7ffaaf050940
        public void .ctor(){} // RVA: 0x7ffaaf050ee0
        public void .cctor(){} // RVA: 0x7ffaaf050f40
        // ── Binary Analysis Named ──
        public void GetDevice(){} // RVA: 0x7ffaa887e5c0
        public void GetPlayerByIndex(){} // RVA: 0x7ffaaf04a290
        public void DoInstantiate(){} // RVA: 0x7ffaaf04aad0
    }

    public class PlayerInputManager : MonoBehaviour
    {
        public object _instance; // 0x3376DB30, was: <instance>k__BackingField
        public object m_AllowJoining; // 0x3376DB30
        public object m_PlayerLeftEvent; // 0x3376DB30
        public object m_SplitScreen; // 0x3376DB30
        public object m_SplitScreenRect; // 0x3376DB30
        public object m_JoinActionDelegate; // 0x3376DB30
        public object m_PlayerLeftCallbacks; // 0x3376DB30

        // ── Original Methods ──
        public void get_splitScreen(){} // RVA: 0x7ffaa895b020
        public void set_splitScreen(){} // RVA: 0x7ffaaf0515c0
        public void get_maintainAspectRatioInSplitScreen(){} // RVA: 0x7ffaa96315d0
        public void get_fixedNumberOfSplitScreens(){} // RVA: 0x7ffaa8b64610
        public void get_splitScreenArea(){} // RVA: 0x7ffaab9e9f20
        public void get_playerCount(){} // RVA: 0x7ffaaf051900
        public void get_maxPlayerCount(){} // RVA: 0x7ffaa9349010
        public void get_joiningEnabled(){} // RVA: 0x7ffaa8b0edb0
        public void get_joinBehavior(){} // RVA: 0x7ffaa96cc980
        public void set_joinBehavior(){} // RVA: 0x7ffaaf051960
        public void get_joinAction(){} // RVA: 0x7ffaa893be10
        public void set_joinAction(){} // RVA: 0x7ffaaf0519b0
        public void get_notificationBehavior(){} // RVA: 0x7ffaa8aeced0
        public void set_notificationBehavior(){} // RVA: 0x7ffaa900aa90
        public void get_playerJoinedEvent(){} // RVA: 0x7ffaaf051aa0
        public void get_playerLeftEvent(){} // RVA: 0x7ffaaf051b70
        public void add_onPlayerJoined(){} // RVA: 0x7ffaaf051c40
        public void remove_onPlayerJoined(){} // RVA: 0x7ffaaf051ce0
        public void add_onPlayerLeft(){} // RVA: 0x7ffaaf051d80
        public void remove_onPlayerLeft(){} // RVA: 0x7ffaaf051e20
        public void get_playerPrefab(){} // RVA: 0x7ffaa89fa500
        public void set_playerPrefab(){} // RVA: 0x7ffaa89fa510
        public void get_instance(){} // RVA: 0x7ffaaf051ec0
        public void set_instance(){} // RVA: 0x7ffaaf051f00
        public void EnableJoining(){} // RVA: 0x7ffaaf051fa0
        public void DisableJoining(){} // RVA: 0x7ffaaf0521c0
        public void JoinPlayerFromUI(){} // RVA: 0x7ffaaf0522c0
        public void JoinPlayerFromAction(){} // RVA: 0x7ffaaf052320
        public void JoinPlayerFromActionIfNotAlreadyJoined(){} // RVA: 0x7ffaaf052390
        public void JoinPlayer(){} // RVA: 0x7ffaaf0525b0
        public void JoinPlayer(){} // RVA: 0x7ffaaf0525b0
        public void get_messages(){} // RVA: 0x7ffaaf052670
        public void OnUnpairedDeviceUsed(){} // RVA: 0x7ffaaf052a90
        public void OnEnable(){} // RVA: 0x7ffaaf052b40
        public void OnDisable(){} // RVA: 0x7ffaaf0530f0
        public void UpdateSplitScreen(){} // RVA: 0x7ffaaf053250
        public void IsDeviceUsableWithPlayerActions(){} // RVA: 0x7ffaaf053990
        public void ValidateInputActionAsset(){} // RVA: 0x7ffaa8932310
        public void NotifyPlayerJoined(){} // RVA: 0x7ffaaf053f30
        public void NotifyPlayerLeft(){} // RVA: 0x7ffaaf054070
        public void .ctor(){} // RVA: 0x7ffaaf0541b0
        // ── Binary Analysis Named ──
        public void CheckIfPlayerCanJoin(){} // RVA: 0x7ffaaf052710
    }

    public class Pointer : InputDevice
    {
        public object _radius; // 0x334657A0, was: <radius>k__BackingField
        public object _displayIndex; // 0x334657A0, was: <displayIndex>k__BackingField

        // ── Original Methods ──
        public void get_position(){} // RVA: 0x7ffaa8f77bc0
        public void set_position(){} // RVA: 0x7ffaa93f5420
        public void get_delta(){} // RVA: 0x7ffaa8f75d50
        public void set_delta(){} // RVA: 0x7ffaa94036f0
        public void get_radius(){} // RVA: 0x7ffaa8f74750
        public void set_radius(){} // RVA: 0x7ffaa93e77a0
        public void get_pressure(){} // RVA: 0x7ffaa8f6f0e0
        public void set_pressure(){} // RVA: 0x7ffaa93ff2c0
        public void get_press(){} // RVA: 0x7ffaa8f6f0f0
        public void set_press(){} // RVA: 0x7ffaa93d9af0
        public void get_displayIndex(){} // RVA: 0x7ffaa8f78130
        public void set_displayIndex(){} // RVA: 0x7ffaa93e4fb0
        public void get_current(){} // RVA: 0x7ffaaefba680
        public void set_current(){} // RVA: 0x7ffaaefba6c0
        public void MakeCurrent(){} // RVA: 0x7ffaaefba760
        public void OnRemoved(){} // RVA: 0x7ffaaefba770
        public void FinishSetup(){} // RVA: 0x7ffaaefba7c0
        public void OnNextUpdate(){} // RVA: 0x7ffaaefbab50
        public void OnStateEvent(){} // RVA: 0x7ffaaefbac10
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7ffaaefbacc0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7ffaaefbacd0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x7ffaa8932320
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class PressureSensor : Sensor
    {
        // ── Original Methods ──
        public void get_atmosphericPressure(){} // RVA: 0x7ffaa8f77bc0
        public void set_atmosphericPressure(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf028f90
        public void set_current(){} // RVA: 0x7ffaaf028fd0
        public void MakeCurrent(){} // RVA: 0x7ffaaf029070
        public void OnRemoved(){} // RVA: 0x7ffaaf029080
        public void FinishSetup(){} // RVA: 0x7ffaaf0290d0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class RemoteInputPlayerConnection : ScriptableObject
    {
        public object kNewEventsMsg; // 0x334566F0
        public object kStartSendingMsg; // 0x334566F0
        public object m_Subscribers; // 0x334566F0
        public object get_distance; // 0xB4160560

        // ── Original Methods ──
        public void Bind(){} // RVA: 0x7ffaaf026a00
        public void Subscribe(){} // RVA: 0x7ffaaf026f20
        public void OnConnected(){} // RVA: 0x7ffaaf0271c0
        public void OnDisconnected(){} // RVA: 0x7ffaaf027270
        public void OnNewDevice(){} // RVA: 0x7ffaaf027410
        public void OnNewLayout(){} // RVA: 0x7ffaaf027420
        public void OnNewEvents(){} // RVA: 0x7ffaaf027430
        public void OnRemoveDevice(){} // RVA: 0x7ffaaf027440
        public void OnChangeUsages(){} // RVA: 0x7ffaaf027450
        public void OnStartSending(){} // RVA: 0x7ffaaf027460
        public void OnStopSending(){} // RVA: 0x7ffaaf027470
        public void SendToSubscribers(){} // RVA: 0x7ffaaf027480
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x7ffaaf027680
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0x7ffaa8932310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        public void .cctor(){} // RVA: 0x7ffaaf027840
    }

    public class Sensor : InputDevice
    {
        // ── Original Methods ──
        public void get_samplingFrequency(){} // RVA: 0x7ffaaf0280a0
        public void set_samplingFrequency(){} // RVA: 0x7ffaaf028180
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class StepCounter : Sensor
    {
        // ── Original Methods ──
        public void get_stepCounter(){} // RVA: 0x7ffaa8f77bc0
        public void set_stepCounter(){} // RVA: 0x7ffaa93f5420
        public void get_current(){} // RVA: 0x7ffaaf029750
        public void set_current(){} // RVA: 0x7ffaaf029790
        public void MakeCurrent(){} // RVA: 0x7ffaaf029830
        public void OnRemoved(){} // RVA: 0x7ffaaf029840
        public void FinishSetup(){} // RVA: 0x7ffaaf029890
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class Touchscreen : Pointer
    {
        public object k_TouchscreenUpdateMarker; // 0x334654B0
        public object s_TapTime; // 0x334654B0

        // ── Original Methods ──
        public void get_primaryTouch(){} // RVA: 0x7ffaa8f73670
        public void set_primaryTouch(){} // RVA: 0x7ffaa93e9360
        public void get_touches(){} // RVA: 0x7ffaaf029b30
        public void set_touches(){} // RVA: 0x7ffaaf029b40
        public void get_touchControlArray(){} // RVA: 0x7ffaa93d5320
        public void set_touchControlArray(){} // RVA: 0x7ffaaf029ba0
        public void get_current(){} // RVA: 0x7ffaaf029cc0
        public void set_current(){} // RVA: 0x7ffaaf029d20
        public void MakeCurrent(){} // RVA: 0x7ffaaf029de0
        public void OnRemoved(){} // RVA: 0x7ffaaf029e40
        public void FinishSetup(){} // RVA: 0x7ffaaf029f30
        public void OnNextUpdate(){} // RVA: 0x7ffaaf02a5c0
        public void OnStateEvent(){} // RVA: 0x7ffaaf02aa70
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7ffaaf02b2c0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7ffaaf02b2d0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x7ffaaf02b2e0
        public void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset(){} // RVA: 0x7ffaaf02b690
        public void MergeForward(){} // RVA: 0x7ffaaf02bba0
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7ffaaf02bc30
        public void TriggerTap(){} // RVA: 0x7ffaaf02bd10
        public void .ctor(){} // RVA: 0x7ffaaef38410
        public void .cctor(){} // RVA: 0x7ffaaf02bdb0
    }

    public class TrackedDevice : InputDevice
    {
        public object _devicePosition; // 0x33455590, was: <devicePosition>k__BackingFiel

        // ── Original Methods ──
        public void get_trackingState(){} // RVA: 0x7ffaa8f77bc0
        public void set_trackingState(){} // RVA: 0x7ffaa93f5420
        public void get_isTracked(){} // RVA: 0x7ffaa8f75d50
        public void set_isTracked(){} // RVA: 0x7ffaa94036f0
        public void get_devicePosition(){} // RVA: 0x7ffaa8f74750
        public void set_devicePosition(){} // RVA: 0x7ffaa93e77a0
        public void get_deviceRotation(){} // RVA: 0x7ffaa8f6f0e0
        public void set_deviceRotation(){} // RVA: 0x7ffaa93ff2c0
        public void FinishSetup(){} // RVA: 0x7ffaaf02bed0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

}