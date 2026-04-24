// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem
// Classes: 64
// Methods: 2201

namespace ThirdParty.Unity.UnityEngine.InputSystem
{
    public class Accelerometer : Sensor
    {
        public object acceleration;
        public object current;

        // ── Methods ──
        public void get_acceleration(){} // RVA: 0x7FFD4E960F60
        public void set_acceleration(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A26220
        public void set_current(){} // RVA: 0x7FFD54A26260
        public void MakeCurrent(){} // RVA: 0x7FFD54A26300
        public void OnRemoved(){} // RVA: 0x7FFD54A26310
        public void FinishSetup(){} // RVA: 0x7FFD54A26360
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class AmbientTemperatureSensor : Sensor
    {
        public object ambientTemperature;
        public object current;

        // ── Methods ──
        public void get_ambientTemperature(){} // RVA: 0x7FFD4E960F60
        public void set_ambientTemperature(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A27580
        public void set_current(){} // RVA: 0x7FFD54A275C0
        public void MakeCurrent(){} // RVA: 0x7FFD54A27660
        public void OnRemoved(){} // RVA: 0x7FFD54A27670
        public void FinishSetup(){} // RVA: 0x7FFD54A276C0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class AttitudeSensor : Sensor
    {
        public object attitude;
        public object current;

        // ── Methods ──
        public void get_attitude(){} // RVA: 0x7FFD4E960F60
        public void set_attitude(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A267F0
        public void set_current(){} // RVA: 0x7FFD54A26830
        public void MakeCurrent(){} // RVA: 0x7FFD54A268D0
        public void OnRemoved(){} // RVA: 0x7FFD54A268E0
        public void FinishSetup(){} // RVA: 0x7FFD54A26930
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class CommonUsages : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD549A2A60
    }

    public class DefaultInputActions : Object
    {
        public object asset;
        public object bindingMask;
        public object devices;
        public object controlSchemes;
        public object bindings;
        public object Player;
        public object UI;
        public object KeyboardMouseScheme;
        public object GamepadScheme;
        public object TouchScheme;
        public object JoystickScheme;
        public object XRScheme;

        // ── Methods ──
        public void get_asset(){} // RVA: 0x7FFD4E35C380
        public void .ctor(){} // RVA: 0x7FFD54A40BB0
        public void Dispose(){} // RVA: 0x7FFD54A41410
        public void get_bindingMask(){} // RVA: 0x7FFD4ECF9600
        public void set_bindingMask(){} // RVA: 0x7FFD4ECF9810
        public void get_devices(){} // RVA: 0x7FFD4ECF6D20
        public void set_devices(){} // RVA: 0x7FFD4ECF6D70
        public void get_controlSchemes(){} // RVA: 0x7FFD4ECF6F70
        public void Contains(){} // RVA: 0x7FFD4ECF97F0
        public void GetEnumerator(){} // RVA: 0x7FFD4ECF9060
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4ECF9060
        public void Enable(){} // RVA: 0x7FFD4ECF9200
        public void Disable(){} // RVA: 0x7FFD4ECF7010
        public void get_bindings(){} // RVA: 0x7FFD4ECF95E0
        public void FindAction(){} // RVA: 0x7FFD4ECF9650
        public void FindBinding(){} // RVA: 0x7FFD4ECF9400
        public void get_Player(){} // RVA: 0x7FFD4ECF6FB0
        public void get_UI(){} // RVA: 0x7FFD4ECF6FB0
        public void get_KeyboardMouseScheme(){} // RVA: 0x7FFD54A41470
        public void get_GamepadScheme(){} // RVA: 0x7FFD54A415F0
        public void get_TouchScheme(){} // RVA: 0x7FFD54A41770
        public void get_JoystickScheme(){} // RVA: 0x7FFD54A418F0
        public void get_XRScheme(){} // RVA: 0x7FFD54A41A70
    }

    public class DynamicBitfield : ValueType
    {
        // ── Methods ──
        public void SetLength(){} // RVA: 0x7FFD54A522C0
        public void SetBit(){} // RVA: 0x7FFD54A52320
        public void TestBit(){} // RVA: 0x7FFD54A523C0
        public void ClearBit(){} // RVA: 0x7FFD54A52440
        public void AnyBitIsSet(){} // RVA: 0x7FFD54A524E0
        public void BitCountToULongCount(){} // RVA: 0x7FFD54A52550
    }

    public class FastKeyboard : Keyboard
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD549B8D00
        public void Initialize_ctrlKeyboardanyKey(){} // RVA: 0x7FFD549BDA50
        public void Initialize_ctrlKeyboardescape(){} // RVA: 0x7FFD549BDE00
        public void Initialize_ctrlKeyboardspace(){} // RVA: 0x7FFD549BE170
        public void Initialize_ctrlKeyboardenter(){} // RVA: 0x7FFD549BE4D0
        public void Initialize_ctrlKeyboardtab(){} // RVA: 0x7FFD549BE850
        public void Initialize_ctrlKeyboardbackquote(){} // RVA: 0x7FFD549BEBB0
        public void Initialize_ctrlKeyboardquote(){} // RVA: 0x7FFD549BEF10
        public void Initialize_ctrlKeyboardsemicolon(){} // RVA: 0x7FFD549BF270
        public void Initialize_ctrlKeyboardcomma(){} // RVA: 0x7FFD549BF5D0
        public void Initialize_ctrlKeyboardperiod(){} // RVA: 0x7FFD549BF930
        public void Initialize_ctrlKeyboardslash(){} // RVA: 0x7FFD549BFC90
        public void Initialize_ctrlKeyboardbackslash(){} // RVA: 0x7FFD549BFFF0
        public void Initialize_ctrlKeyboardleftBracket(){} // RVA: 0x7FFD549C0350
        public void Initialize_ctrlKeyboardrightBracket(){} // RVA: 0x7FFD549C06B0
        public void Initialize_ctrlKeyboardminus(){} // RVA: 0x7FFD549C0A10
        public void Initialize_ctrlKeyboardequals(){} // RVA: 0x7FFD549C0D70
        public void Initialize_ctrlKeyboardupArrow(){} // RVA: 0x7FFD549C10D0
        public void Initialize_ctrlKeyboarddownArrow(){} // RVA: 0x7FFD549C1430
        public void Initialize_ctrlKeyboardleftArrow(){} // RVA: 0x7FFD549C1790
        public void Initialize_ctrlKeyboardrightArrow(){} // RVA: 0x7FFD549C1AF0
        public void Initialize_ctrlKeyboarda(){} // RVA: 0x7FFD549C1E50
        public void Initialize_ctrlKeyboardb(){} // RVA: 0x7FFD549C21B0
        public void Initialize_ctrlKeyboardc(){} // RVA: 0x7FFD549C2510
        public void Initialize_ctrlKeyboardd(){} // RVA: 0x7FFD549C2870
        public void Initialize_ctrlKeyboarde(){} // RVA: 0x7FFD549C2BD0
        public void Initialize_ctrlKeyboardf(){} // RVA: 0x7FFD549C2F30
        public void Initialize_ctrlKeyboardg(){} // RVA: 0x7FFD549C3290
        public void Initialize_ctrlKeyboardh(){} // RVA: 0x7FFD549C35F0
        public void Initialize_ctrlKeyboardi(){} // RVA: 0x7FFD549C3950
        public void Initialize_ctrlKeyboardj(){} // RVA: 0x7FFD549C3CB0
        public void Initialize_ctrlKeyboardk(){} // RVA: 0x7FFD549C4010
        public void Initialize_ctrlKeyboardl(){} // RVA: 0x7FFD549C4370
        public void Initialize_ctrlKeyboardm(){} // RVA: 0x7FFD549C46D0
        public void Initialize_ctrlKeyboardn(){} // RVA: 0x7FFD549C4A30
        public void Initialize_ctrlKeyboardo(){} // RVA: 0x7FFD549C4D90
        public void Initialize_ctrlKeyboardp(){} // RVA: 0x7FFD549C50F0
        public void Initialize_ctrlKeyboardq(){} // RVA: 0x7FFD549C5450
        public void Initialize_ctrlKeyboardr(){} // RVA: 0x7FFD549C57B0
        public void Initialize_ctrlKeyboards(){} // RVA: 0x7FFD549C5B10
        public void Initialize_ctrlKeyboardt(){} // RVA: 0x7FFD549C5E70
        public void Initialize_ctrlKeyboardu(){} // RVA: 0x7FFD549C61D0
        public void Initialize_ctrlKeyboardv(){} // RVA: 0x7FFD549C6530
        public void Initialize_ctrlKeyboardw(){} // RVA: 0x7FFD549C6890
        public void Initialize_ctrlKeyboardx(){} // RVA: 0x7FFD549C6BF0
        public void Initialize_ctrlKeyboardy(){} // RVA: 0x7FFD549C6F50
        public void Initialize_ctrlKeyboardz(){} // RVA: 0x7FFD549C72B0
        public void Initialize_ctrlKeyboard1(){} // RVA: 0x7FFD549C7610
        public void Initialize_ctrlKeyboard2(){} // RVA: 0x7FFD549C7960
        public void Initialize_ctrlKeyboard3(){} // RVA: 0x7FFD549C7CB0
        public void Initialize_ctrlKeyboard4(){} // RVA: 0x7FFD549C8000
        public void Initialize_ctrlKeyboard5(){} // RVA: 0x7FFD549C8350
        public void Initialize_ctrlKeyboard6(){} // RVA: 0x7FFD549C86A0
        public void Initialize_ctrlKeyboard7(){} // RVA: 0x7FFD549C89F0
        public void Initialize_ctrlKeyboard8(){} // RVA: 0x7FFD549C8D40
        public void Initialize_ctrlKeyboard9(){} // RVA: 0x7FFD549C9090
        public void Initialize_ctrlKeyboard0(){} // RVA: 0x7FFD549C93E0
        public void Initialize_ctrlKeyboardleftShift(){} // RVA: 0x7FFD549C9730
        public void Initialize_ctrlKeyboardrightShift(){} // RVA: 0x7FFD549C9AB0
        public void Initialize_ctrlKeyboardshift(){} // RVA: 0x7FFD549C9E30
        public void Initialize_ctrlKeyboardleftAlt(){} // RVA: 0x7FFD549CA1D0
        public void Initialize_ctrlKeyboardrightAlt(){} // RVA: 0x7FFD549CA550
        public void Initialize_ctrlKeyboardalt(){} // RVA: 0x7FFD549CA8D0
        public void Initialize_ctrlKeyboardleftCtrl(){} // RVA: 0x7FFD549CAC70
        public void Initialize_ctrlKeyboardrightCtrl(){} // RVA: 0x7FFD549CAFF0
        public void Initialize_ctrlKeyboardctrl(){} // RVA: 0x7FFD549CB370
        public void Initialize_ctrlKeyboardleftMeta(){} // RVA: 0x7FFD549CB710
        public void Initialize_ctrlKeyboardrightMeta(){} // RVA: 0x7FFD549CBAA0
        public void Initialize_ctrlKeyboardcontextMenu(){} // RVA: 0x7FFD549CBE30
        public void Initialize_ctrlKeyboardbackspace(){} // RVA: 0x7FFD549CC1B0
        public void Initialize_ctrlKeyboardpageDown(){} // RVA: 0x7FFD549CC510
        public void Initialize_ctrlKeyboardpageUp(){} // RVA: 0x7FFD549CC870
        public void Initialize_ctrlKeyboardhome(){} // RVA: 0x7FFD549CCBD0
        public void Initialize_ctrlKeyboardend(){} // RVA: 0x7FFD549CCF30
        public void Initialize_ctrlKeyboardinsert(){} // RVA: 0x7FFD549CD290
        public void Initialize_ctrlKeyboarddelete(){} // RVA: 0x7FFD549CD5F0
        public void Initialize_ctrlKeyboardcapsLock(){} // RVA: 0x7FFD549CD950
        public void Initialize_ctrlKeyboardnumLock(){} // RVA: 0x7FFD549CDCB0
        public void Initialize_ctrlKeyboardprintScreen(){} // RVA: 0x7FFD549CE010
        public void Initialize_ctrlKeyboardscrollLock(){} // RVA: 0x7FFD549CE370
        public void Initialize_ctrlKeyboardpause(){} // RVA: 0x7FFD549CE6D0
        public void Initialize_ctrlKeyboardnumpadEnter(){} // RVA: 0x7FFD549CEA30
        public void Initialize_ctrlKeyboardnumpadDivide(){} // RVA: 0x7FFD549CED90
        public void Initialize_ctrlKeyboardnumpadMultiply(){} // RVA: 0x7FFD549CF0F0
        public void Initialize_ctrlKeyboardnumpadPlus(){} // RVA: 0x7FFD549CF450
        public void Initialize_ctrlKeyboardnumpadMinus(){} // RVA: 0x7FFD549CF7B0
        public void Initialize_ctrlKeyboardnumpadPeriod(){} // RVA: 0x7FFD549CFB10
        public void Initialize_ctrlKeyboardnumpadEquals(){} // RVA: 0x7FFD549CFE70
        public void Initialize_ctrlKeyboardnumpad1(){} // RVA: 0x7FFD549D01D0
        public void Initialize_ctrlKeyboardnumpad2(){} // RVA: 0x7FFD549D0530
        public void Initialize_ctrlKeyboardnumpad3(){} // RVA: 0x7FFD549D0890
        public void Initialize_ctrlKeyboardnumpad4(){} // RVA: 0x7FFD549D0BF0
        public void Initialize_ctrlKeyboardnumpad5(){} // RVA: 0x7FFD549D0F50
        public void Initialize_ctrlKeyboardnumpad6(){} // RVA: 0x7FFD549D12B0
        public void Initialize_ctrlKeyboardnumpad7(){} // RVA: 0x7FFD549D1610
        public void Initialize_ctrlKeyboardnumpad8(){} // RVA: 0x7FFD549D1970
        public void Initialize_ctrlKeyboardnumpad9(){} // RVA: 0x7FFD549D1CD0
        public void Initialize_ctrlKeyboardnumpad0(){} // RVA: 0x7FFD549D2030
        public void Initialize_ctrlKeyboardf1(){} // RVA: 0x7FFD549D2390
        public void Initialize_ctrlKeyboardf2(){} // RVA: 0x7FFD549D26F0
        public void Initialize_ctrlKeyboardf3(){} // RVA: 0x7FFD549D2A50
        public void Initialize_ctrlKeyboardf4(){} // RVA: 0x7FFD549D2DB0
        public void Initialize_ctrlKeyboardf5(){} // RVA: 0x7FFD549D3110
        public void Initialize_ctrlKeyboardf6(){} // RVA: 0x7FFD549D3470
        public void Initialize_ctrlKeyboardf7(){} // RVA: 0x7FFD549D37D0
        public void Initialize_ctrlKeyboardf8(){} // RVA: 0x7FFD549D3B30
        public void Initialize_ctrlKeyboardf9(){} // RVA: 0x7FFD549D3E90
        public void Initialize_ctrlKeyboardf10(){} // RVA: 0x7FFD549D41F0
        public void Initialize_ctrlKeyboardf11(){} // RVA: 0x7FFD549D4550
        public void Initialize_ctrlKeyboardf12(){} // RVA: 0x7FFD549D48B0
        public void Initialize_ctrlKeyboardOEM1(){} // RVA: 0x7FFD549D4C10
        public void Initialize_ctrlKeyboardOEM2(){} // RVA: 0x7FFD549D4F60
        public void Initialize_ctrlKeyboardOEM3(){} // RVA: 0x7FFD549D52B0
        public void Initialize_ctrlKeyboardOEM4(){} // RVA: 0x7FFD549D5600
        public void Initialize_ctrlKeyboardOEM5(){} // RVA: 0x7FFD549D5950
        public void Initialize_ctrlKeyboardf13(){} // RVA: 0x7FFD549D5CA0
        public void Initialize_ctrlKeyboardf14(){} // RVA: 0x7FFD549D6000
        public void Initialize_ctrlKeyboardf15(){} // RVA: 0x7FFD549D6360
        public void Initialize_ctrlKeyboardf16(){} // RVA: 0x7FFD549D66C0
        public void Initialize_ctrlKeyboardf17(){} // RVA: 0x7FFD549D6A20
        public void Initialize_ctrlKeyboardf18(){} // RVA: 0x7FFD549D6D80
        public void Initialize_ctrlKeyboardf19(){} // RVA: 0x7FFD549D70E0
        public void Initialize_ctrlKeyboardf20(){} // RVA: 0x7FFD549D7440
        public void Initialize_ctrlKeyboardf21(){} // RVA: 0x7FFD549D77A0
        public void Initialize_ctrlKeyboardf22(){} // RVA: 0x7FFD549D7B00
        public void Initialize_ctrlKeyboardf23(){} // RVA: 0x7FFD549D7E60
        public void Initialize_ctrlKeyboardf24(){} // RVA: 0x7FFD549D81C0
        public void Initialize_ctrlKeyboardIMESelected(){} // RVA: 0x7FFD549D8520
    }

    public class FastMouse : Mouse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54A18A80
        public void Initialize_ctrlMouseposition(){} // RVA: 0x7FFD54A1A4B0
        public void Initialize_ctrlMousedelta(){} // RVA: 0x7FFD54A1A7D0
        public void Initialize_ctrlMousescroll(){} // RVA: 0x7FFD54A1AAE0
        public void Initialize_ctrlMousepress(){} // RVA: 0x7FFD54A1ADE0
        public void Initialize_ctrlMouseleftButton(){} // RVA: 0x7FFD54A1B140
        public void Initialize_ctrlMouserightButton(){} // RVA: 0x7FFD54A1B4C0
        public void Initialize_ctrlMousemiddleButton(){} // RVA: 0x7FFD54A1B840
        public void Initialize_ctrlMouseforwardButton(){} // RVA: 0x7FFD54A1BBB0
        public void Initialize_ctrlMousebackButton(){} // RVA: 0x7FFD54A1BF20
        public void Initialize_ctrlMousepressure(){} // RVA: 0x7FFD54A1C290
        public void Initialize_ctrlMouseradius(){} // RVA: 0x7FFD54A1C5C0
        public void Initialize_ctrlMousepointerId(){} // RVA: 0x7FFD54A1C8D0
        public void Initialize_ctrlMousedisplayIndex(){} // RVA: 0x7FFD54A1CBB0
        public void Initialize_ctrlMouseclickCount(){} // RVA: 0x7FFD54A1CEA0
        public void Initialize_ctrlMousepositionx(){} // RVA: 0x7FFD54A1D190
        public void Initialize_ctrlMousepositiony(){} // RVA: 0x7FFD54A1D4B0
        public void Initialize_ctrlMousedeltaup(){} // RVA: 0x7FFD54A1D7D0
        public void Initialize_ctrlMousedeltadown(){} // RVA: 0x7FFD54A1DB00
        public void Initialize_ctrlMousedeltaleft(){} // RVA: 0x7FFD54A1DE30
        public void Initialize_ctrlMousedeltaright(){} // RVA: 0x7FFD54A1E160
        public void Initialize_ctrlMousedeltax(){} // RVA: 0x7FFD54A1E490
        public void Initialize_ctrlMousedeltay(){} // RVA: 0x7FFD54A1E790
        public void Initialize_ctrlMousescrollup(){} // RVA: 0x7FFD54A1EA90
        public void Initialize_ctrlMousescrolldown(){} // RVA: 0x7FFD54A1EDC0
        public void Initialize_ctrlMousescrollleft(){} // RVA: 0x7FFD54A1F0F0
        public void Initialize_ctrlMousescrollright(){} // RVA: 0x7FFD54A1F420
        public void Initialize_ctrlMousescrollx(){} // RVA: 0x7FFD54A1F750
        public void Initialize_ctrlMousescrolly(){} // RVA: 0x7FFD54A1FA70
        public void Initialize_ctrlMouseradiusx(){} // RVA: 0x7FFD54A1FDB0
        public void Initialize_ctrlMouseradiusy(){} // RVA: 0x7FFD54A200B0
        public void OnNextUpdate(){} // RVA: 0x7FFD54A203B0
        public void OnStateEvent(){} // RVA: 0x7FFD54A20510
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFD54A203B0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFD54A20510
        public void MergeForward(){} // RVA: 0x7FFD54A206B0
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7FFD54A20760
    }

    public class FastTouchscreen : Touchscreen
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD549D8B90
        public void Initialize_ctrlTouchscreenprimaryTouch(){} // RVA: 0x7FFD549DDFB0
        public void Initialize_ctrlTouchscreenposition(){} // RVA: 0x7FFD549DE2B0
        public void Initialize_ctrlTouchscreendelta(){} // RVA: 0x7FFD549DE5E0
        public void Initialize_ctrlTouchscreenpressure(){} // RVA: 0x7FFD549DE8F0
        public void Initialize_ctrlTouchscreenradius(){} // RVA: 0x7FFD549DEC20
        public void Initialize_ctrlTouchscreenpress(){} // RVA: 0x7FFD549DEF30
        public void Initialize_ctrlTouchscreendisplayIndex(){} // RVA: 0x7FFD549DF290
        public void Initialize_ctrlTouchscreentouch0(){} // RVA: 0x7FFD549DF580
        public void Initialize_ctrlTouchscreentouch1(){} // RVA: 0x7FFD549DF880
        public void Initialize_ctrlTouchscreentouch2(){} // RVA: 0x7FFD549DFB80
        public void Initialize_ctrlTouchscreentouch3(){} // RVA: 0x7FFD549DFE80
        public void Initialize_ctrlTouchscreentouch4(){} // RVA: 0x7FFD549E0180
        public void Initialize_ctrlTouchscreentouch5(){} // RVA: 0x7FFD549E0480
        public void Initialize_ctrlTouchscreentouch6(){} // RVA: 0x7FFD549E0780
        public void Initialize_ctrlTouchscreentouch7(){} // RVA: 0x7FFD549E0A80
        public void Initialize_ctrlTouchscreentouch8(){} // RVA: 0x7FFD549E0D80
        public void Initialize_ctrlTouchscreentouch9(){} // RVA: 0x7FFD549E1080
        public void Initialize_ctrlTouchscreenprimaryTouchtouchId(){} // RVA: 0x7FFD549E1380
        public void Initialize_ctrlTouchscreenprimaryTouchposition(){} // RVA: 0x7FFD549E16A0
        public void Initialize_ctrlTouchscreenprimaryTouchdelta(){} // RVA: 0x7FFD549E19D0
        public void Initialize_ctrlTouchscreenprimaryTouchpressure(){} // RVA: 0x7FFD549E1CE0
        public void Initialize_ctrlTouchscreenprimaryTouchradius(){} // RVA: 0x7FFD549E1FE0
        public void Initialize_ctrlTouchscreenprimaryTouchphase(){} // RVA: 0x7FFD549E22F0
        public void Initialize_ctrlTouchscreenprimaryTouchpress(){} // RVA: 0x7FFD549E2600
        public void Initialize_ctrlTouchscreenprimaryTouchtapCount(){} // RVA: 0x7FFD549E2960
        public void Initialize_ctrlTouchscreenprimaryTouchdisplayIndex(){} // RVA: 0x7FFD549E2C60
        public void Initialize_ctrlTouchscreenprimaryTouchindirectTouch(){} // RVA: 0x7FFD549E2F60
        public void Initialize_ctrlTouchscreenprimaryTouchtap(){} // RVA: 0x7FFD549E32C0
        public void Initialize_ctrlTouchscreenprimaryTouchstartTime(){} // RVA: 0x7FFD549E3630
        public void Initialize_ctrlTouchscreenprimaryTouchstartPosition(){} // RVA: 0x7FFD549E3940
        public void Initialize_ctrlTouchscreenprimaryTouchpositionx(){} // RVA: 0x7FFD549E3C60
        public void Initialize_ctrlTouchscreenprimaryTouchpositiony(){} // RVA: 0x7FFD549E3F80
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaup(){} // RVA: 0x7FFD549E42A0
        public void Initialize_ctrlTouchscreenprimaryTouchdeltadown(){} // RVA: 0x7FFD549E45D0
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaleft(){} // RVA: 0x7FFD549E4900
        public void Initialize_ctrlTouchscreenprimaryTouchdeltaright(){} // RVA: 0x7FFD549E4C30
        public void Initialize_ctrlTouchscreenprimaryTouchdeltax(){} // RVA: 0x7FFD549E4F60
        public void Initialize_ctrlTouchscreenprimaryTouchdeltay(){} // RVA: 0x7FFD549E5260
        public void Initialize_ctrlTouchscreenprimaryTouchradiusx(){} // RVA: 0x7FFD549E5560
        public void Initialize_ctrlTouchscreenprimaryTouchradiusy(){} // RVA: 0x7FFD549E5860
        public void Initialize_ctrlTouchscreenprimaryTouchstartPositionx(){} // RVA: 0x7FFD549E5B60
        public void Initialize_ctrlTouchscreenprimaryTouchstartPositiony(){} // RVA: 0x7FFD549E5E60
        public void Initialize_ctrlTouchscreenpositionx(){} // RVA: 0x7FFD549E6160
        public void Initialize_ctrlTouchscreenpositiony(){} // RVA: 0x7FFD549E6480
        public void Initialize_ctrlTouchscreendeltaup(){} // RVA: 0x7FFD549E67A0
        public void Initialize_ctrlTouchscreendeltadown(){} // RVA: 0x7FFD549E6AD0
        public void Initialize_ctrlTouchscreendeltaleft(){} // RVA: 0x7FFD549E6E00
        public void Initialize_ctrlTouchscreendeltaright(){} // RVA: 0x7FFD549E7130
        public void Initialize_ctrlTouchscreendeltax(){} // RVA: 0x7FFD549E7460
        public void Initialize_ctrlTouchscreendeltay(){} // RVA: 0x7FFD549E7760
        public void Initialize_ctrlTouchscreenradiusx(){} // RVA: 0x7FFD549E7A60
        public void Initialize_ctrlTouchscreenradiusy(){} // RVA: 0x7FFD549E7D60
        public void Initialize_ctrlTouchscreentouch0touchId(){} // RVA: 0x7FFD549E8060
        public void Initialize_ctrlTouchscreentouch0position(){} // RVA: 0x7FFD549E8380
        public void Initialize_ctrlTouchscreentouch0delta(){} // RVA: 0x7FFD549E86B0
        public void Initialize_ctrlTouchscreentouch0pressure(){} // RVA: 0x7FFD549E89C0
        public void Initialize_ctrlTouchscreentouch0radius(){} // RVA: 0x7FFD549E8CC0
        public void Initialize_ctrlTouchscreentouch0phase(){} // RVA: 0x7FFD549E8FD0
        public void Initialize_ctrlTouchscreentouch0press(){} // RVA: 0x7FFD549E92E0
        public void Initialize_ctrlTouchscreentouch0tapCount(){} // RVA: 0x7FFD549E9640
        public void Initialize_ctrlTouchscreentouch0displayIndex(){} // RVA: 0x7FFD549E9940
        public void Initialize_ctrlTouchscreentouch0indirectTouch(){} // RVA: 0x7FFD549E9C40
        public void Initialize_ctrlTouchscreentouch0tap(){} // RVA: 0x7FFD549E9FA0
        public void Initialize_ctrlTouchscreentouch0startTime(){} // RVA: 0x7FFD549EA300
        public void Initialize_ctrlTouchscreentouch0startPosition(){} // RVA: 0x7FFD549EA610
        public void Initialize_ctrlTouchscreentouch0positionx(){} // RVA: 0x7FFD549EA930
        public void Initialize_ctrlTouchscreentouch0positiony(){} // RVA: 0x7FFD549EAC50
        public void Initialize_ctrlTouchscreentouch0deltaup(){} // RVA: 0x7FFD549EAF70
        public void Initialize_ctrlTouchscreentouch0deltadown(){} // RVA: 0x7FFD549EB2A0
        public void Initialize_ctrlTouchscreentouch0deltaleft(){} // RVA: 0x7FFD549EB5D0
        public void Initialize_ctrlTouchscreentouch0deltaright(){} // RVA: 0x7FFD549EB900
        public void Initialize_ctrlTouchscreentouch0deltax(){} // RVA: 0x7FFD549EBC30
        public void Initialize_ctrlTouchscreentouch0deltay(){} // RVA: 0x7FFD549EBF30
        public void Initialize_ctrlTouchscreentouch0radiusx(){} // RVA: 0x7FFD549EC230
        public void Initialize_ctrlTouchscreentouch0radiusy(){} // RVA: 0x7FFD549EC530
        public void Initialize_ctrlTouchscreentouch0startPositionx(){} // RVA: 0x7FFD549EC830
        public void Initialize_ctrlTouchscreentouch0startPositiony(){} // RVA: 0x7FFD549ECB30
        public void Initialize_ctrlTouchscreentouch1touchId(){} // RVA: 0x7FFD549ECE30
        public void Initialize_ctrlTouchscreentouch1position(){} // RVA: 0x7FFD549ED150
        public void Initialize_ctrlTouchscreentouch1delta(){} // RVA: 0x7FFD549ED480
        public void Initialize_ctrlTouchscreentouch1pressure(){} // RVA: 0x7FFD549ED790
        public void Initialize_ctrlTouchscreentouch1radius(){} // RVA: 0x7FFD549EDA90
        public void Initialize_ctrlTouchscreentouch1phase(){} // RVA: 0x7FFD549EDDA0
        public void Initialize_ctrlTouchscreentouch1press(){} // RVA: 0x7FFD549EE0B0
        public void Initialize_ctrlTouchscreentouch1tapCount(){} // RVA: 0x7FFD549EE410
        public void Initialize_ctrlTouchscreentouch1displayIndex(){} // RVA: 0x7FFD549EE710
        public void Initialize_ctrlTouchscreentouch1indirectTouch(){} // RVA: 0x7FFD549EEA10
        public void Initialize_ctrlTouchscreentouch1tap(){} // RVA: 0x7FFD549EED70
        public void Initialize_ctrlTouchscreentouch1startTime(){} // RVA: 0x7FFD549EF0D0
        public void Initialize_ctrlTouchscreentouch1startPosition(){} // RVA: 0x7FFD549EF3E0
        public void Initialize_ctrlTouchscreentouch1positionx(){} // RVA: 0x7FFD549EF700
        public void Initialize_ctrlTouchscreentouch1positiony(){} // RVA: 0x7FFD549EFA20
        public void Initialize_ctrlTouchscreentouch1deltaup(){} // RVA: 0x7FFD549EFD40
        public void Initialize_ctrlTouchscreentouch1deltadown(){} // RVA: 0x7FFD549F0070
        public void Initialize_ctrlTouchscreentouch1deltaleft(){} // RVA: 0x7FFD549F03A0
        public void Initialize_ctrlTouchscreentouch1deltaright(){} // RVA: 0x7FFD549F06D0
        public void Initialize_ctrlTouchscreentouch1deltax(){} // RVA: 0x7FFD549F0A00
        public void Initialize_ctrlTouchscreentouch1deltay(){} // RVA: 0x7FFD549F0D00
        public void Initialize_ctrlTouchscreentouch1radiusx(){} // RVA: 0x7FFD549F1000
        public void Initialize_ctrlTouchscreentouch1radiusy(){} // RVA: 0x7FFD549F1300
        public void Initialize_ctrlTouchscreentouch1startPositionx(){} // RVA: 0x7FFD549F1600
        public void Initialize_ctrlTouchscreentouch1startPositiony(){} // RVA: 0x7FFD549F1900
        public void Initialize_ctrlTouchscreentouch2touchId(){} // RVA: 0x7FFD549F1C00
        public void Initialize_ctrlTouchscreentouch2position(){} // RVA: 0x7FFD549F1F20
        public void Initialize_ctrlTouchscreentouch2delta(){} // RVA: 0x7FFD549F2250
        public void Initialize_ctrlTouchscreentouch2pressure(){} // RVA: 0x7FFD549F2560
        public void Initialize_ctrlTouchscreentouch2radius(){} // RVA: 0x7FFD549F2860
        public void Initialize_ctrlTouchscreentouch2phase(){} // RVA: 0x7FFD549F2B70
        public void Initialize_ctrlTouchscreentouch2press(){} // RVA: 0x7FFD549F2E80
        public void Initialize_ctrlTouchscreentouch2tapCount(){} // RVA: 0x7FFD549F31E0
        public void Initialize_ctrlTouchscreentouch2displayIndex(){} // RVA: 0x7FFD549F34E0
        public void Initialize_ctrlTouchscreentouch2indirectTouch(){} // RVA: 0x7FFD549F37E0
        public void Initialize_ctrlTouchscreentouch2tap(){} // RVA: 0x7FFD549F3B40
        public void Initialize_ctrlTouchscreentouch2startTime(){} // RVA: 0x7FFD549F3EA0
        public void Initialize_ctrlTouchscreentouch2startPosition(){} // RVA: 0x7FFD549F41B0
        public void Initialize_ctrlTouchscreentouch2positionx(){} // RVA: 0x7FFD549F44D0
        public void Initialize_ctrlTouchscreentouch2positiony(){} // RVA: 0x7FFD549F47F0
        public void Initialize_ctrlTouchscreentouch2deltaup(){} // RVA: 0x7FFD549F4B10
        public void Initialize_ctrlTouchscreentouch2deltadown(){} // RVA: 0x7FFD549F4E40
        public void Initialize_ctrlTouchscreentouch2deltaleft(){} // RVA: 0x7FFD549F5170
        public void Initialize_ctrlTouchscreentouch2deltaright(){} // RVA: 0x7FFD549F54A0
        public void Initialize_ctrlTouchscreentouch2deltax(){} // RVA: 0x7FFD549F57D0
        public void Initialize_ctrlTouchscreentouch2deltay(){} // RVA: 0x7FFD549F5AD0
        public void Initialize_ctrlTouchscreentouch2radiusx(){} // RVA: 0x7FFD549F5DD0
        public void Initialize_ctrlTouchscreentouch2radiusy(){} // RVA: 0x7FFD549F60D0
        public void Initialize_ctrlTouchscreentouch2startPositionx(){} // RVA: 0x7FFD549F63D0
        public void Initialize_ctrlTouchscreentouch2startPositiony(){} // RVA: 0x7FFD549F66D0
        public void Initialize_ctrlTouchscreentouch3touchId(){} // RVA: 0x7FFD549F69D0
        public void Initialize_ctrlTouchscreentouch3position(){} // RVA: 0x7FFD549F6CF0
        public void Initialize_ctrlTouchscreentouch3delta(){} // RVA: 0x7FFD549F7020
        public void Initialize_ctrlTouchscreentouch3pressure(){} // RVA: 0x7FFD549F7330
        public void Initialize_ctrlTouchscreentouch3radius(){} // RVA: 0x7FFD549F7630
        public void Initialize_ctrlTouchscreentouch3phase(){} // RVA: 0x7FFD549F7940
        public void Initialize_ctrlTouchscreentouch3press(){} // RVA: 0x7FFD549F7C50
        public void Initialize_ctrlTouchscreentouch3tapCount(){} // RVA: 0x7FFD549F7FB0
        public void Initialize_ctrlTouchscreentouch3displayIndex(){} // RVA: 0x7FFD549F82B0
        public void Initialize_ctrlTouchscreentouch3indirectTouch(){} // RVA: 0x7FFD549F85B0
        public void Initialize_ctrlTouchscreentouch3tap(){} // RVA: 0x7FFD549F8910
        public void Initialize_ctrlTouchscreentouch3startTime(){} // RVA: 0x7FFD549F8C70
        public void Initialize_ctrlTouchscreentouch3startPosition(){} // RVA: 0x7FFD549F8F80
        public void Initialize_ctrlTouchscreentouch3positionx(){} // RVA: 0x7FFD549F92A0
        public void Initialize_ctrlTouchscreentouch3positiony(){} // RVA: 0x7FFD549F95C0
        public void Initialize_ctrlTouchscreentouch3deltaup(){} // RVA: 0x7FFD549F98E0
        public void Initialize_ctrlTouchscreentouch3deltadown(){} // RVA: 0x7FFD549F9C10
        public void Initialize_ctrlTouchscreentouch3deltaleft(){} // RVA: 0x7FFD549F9F40
        public void Initialize_ctrlTouchscreentouch3deltaright(){} // RVA: 0x7FFD549FA270
        public void Initialize_ctrlTouchscreentouch3deltax(){} // RVA: 0x7FFD549FA5A0
        public void Initialize_ctrlTouchscreentouch3deltay(){} // RVA: 0x7FFD549FA8A0
        public void Initialize_ctrlTouchscreentouch3radiusx(){} // RVA: 0x7FFD549FABA0
        public void Initialize_ctrlTouchscreentouch3radiusy(){} // RVA: 0x7FFD549FAEA0
        public void Initialize_ctrlTouchscreentouch3startPositionx(){} // RVA: 0x7FFD549FB1A0
        public void Initialize_ctrlTouchscreentouch3startPositiony(){} // RVA: 0x7FFD549FB4A0
        public void Initialize_ctrlTouchscreentouch4touchId(){} // RVA: 0x7FFD549FB7A0
        public void Initialize_ctrlTouchscreentouch4position(){} // RVA: 0x7FFD549FBAC0
        public void Initialize_ctrlTouchscreentouch4delta(){} // RVA: 0x7FFD549FBDF0
        public void Initialize_ctrlTouchscreentouch4pressure(){} // RVA: 0x7FFD549FC100
        public void Initialize_ctrlTouchscreentouch4radius(){} // RVA: 0x7FFD549FC400
        public void Initialize_ctrlTouchscreentouch4phase(){} // RVA: 0x7FFD549FC710
        public void Initialize_ctrlTouchscreentouch4press(){} // RVA: 0x7FFD549FCA20
        public void Initialize_ctrlTouchscreentouch4tapCount(){} // RVA: 0x7FFD549FCD80
        public void Initialize_ctrlTouchscreentouch4displayIndex(){} // RVA: 0x7FFD549FD080
        public void Initialize_ctrlTouchscreentouch4indirectTouch(){} // RVA: 0x7FFD549FD380
        public void Initialize_ctrlTouchscreentouch4tap(){} // RVA: 0x7FFD549FD6E0
        public void Initialize_ctrlTouchscreentouch4startTime(){} // RVA: 0x7FFD549FDA40
        public void Initialize_ctrlTouchscreentouch4startPosition(){} // RVA: 0x7FFD549FDD50
        public void Initialize_ctrlTouchscreentouch4positionx(){} // RVA: 0x7FFD549FE070
        public void Initialize_ctrlTouchscreentouch4positiony(){} // RVA: 0x7FFD549FE390
        public void Initialize_ctrlTouchscreentouch4deltaup(){} // RVA: 0x7FFD549FE6B0
        public void Initialize_ctrlTouchscreentouch4deltadown(){} // RVA: 0x7FFD549FE9E0
        public void Initialize_ctrlTouchscreentouch4deltaleft(){} // RVA: 0x7FFD549FED10
        public void Initialize_ctrlTouchscreentouch4deltaright(){} // RVA: 0x7FFD549FF040
        public void Initialize_ctrlTouchscreentouch4deltax(){} // RVA: 0x7FFD549FF370
        public void Initialize_ctrlTouchscreentouch4deltay(){} // RVA: 0x7FFD549FF670
        public void Initialize_ctrlTouchscreentouch4radiusx(){} // RVA: 0x7FFD549FF970
        public void Initialize_ctrlTouchscreentouch4radiusy(){} // RVA: 0x7FFD549FFC70
        public void Initialize_ctrlTouchscreentouch4startPositionx(){} // RVA: 0x7FFD549FFF70
        public void Initialize_ctrlTouchscreentouch4startPositiony(){} // RVA: 0x7FFD54A00270
        public void Initialize_ctrlTouchscreentouch5touchId(){} // RVA: 0x7FFD54A00570
        public void Initialize_ctrlTouchscreentouch5position(){} // RVA: 0x7FFD54A00890
        public void Initialize_ctrlTouchscreentouch5delta(){} // RVA: 0x7FFD54A00BC0
        public void Initialize_ctrlTouchscreentouch5pressure(){} // RVA: 0x7FFD54A00ED0
        public void Initialize_ctrlTouchscreentouch5radius(){} // RVA: 0x7FFD54A011D0
        public void Initialize_ctrlTouchscreentouch5phase(){} // RVA: 0x7FFD54A014E0
        public void Initialize_ctrlTouchscreentouch5press(){} // RVA: 0x7FFD54A017F0
        public void Initialize_ctrlTouchscreentouch5tapCount(){} // RVA: 0x7FFD54A01B50
        public void Initialize_ctrlTouchscreentouch5displayIndex(){} // RVA: 0x7FFD54A01E50
        public void Initialize_ctrlTouchscreentouch5indirectTouch(){} // RVA: 0x7FFD54A02150
        public void Initialize_ctrlTouchscreentouch5tap(){} // RVA: 0x7FFD54A024B0
        public void Initialize_ctrlTouchscreentouch5startTime(){} // RVA: 0x7FFD54A02810
        public void Initialize_ctrlTouchscreentouch5startPosition(){} // RVA: 0x7FFD54A02B20
        public void Initialize_ctrlTouchscreentouch5positionx(){} // RVA: 0x7FFD54A02E40
        public void Initialize_ctrlTouchscreentouch5positiony(){} // RVA: 0x7FFD54A03160
        public void Initialize_ctrlTouchscreentouch5deltaup(){} // RVA: 0x7FFD54A03480
        public void Initialize_ctrlTouchscreentouch5deltadown(){} // RVA: 0x7FFD54A037B0
        public void Initialize_ctrlTouchscreentouch5deltaleft(){} // RVA: 0x7FFD54A03AE0
        public void Initialize_ctrlTouchscreentouch5deltaright(){} // RVA: 0x7FFD54A03E10
        public void Initialize_ctrlTouchscreentouch5deltax(){} // RVA: 0x7FFD54A04140
        public void Initialize_ctrlTouchscreentouch5deltay(){} // RVA: 0x7FFD54A04440
        public void Initialize_ctrlTouchscreentouch5radiusx(){} // RVA: 0x7FFD54A04740
        public void Initialize_ctrlTouchscreentouch5radiusy(){} // RVA: 0x7FFD54A04A40
        public void Initialize_ctrlTouchscreentouch5startPositionx(){} // RVA: 0x7FFD54A04D40
        public void Initialize_ctrlTouchscreentouch5startPositiony(){} // RVA: 0x7FFD54A05040
        public void Initialize_ctrlTouchscreentouch6touchId(){} // RVA: 0x7FFD54A05340
        public void Initialize_ctrlTouchscreentouch6position(){} // RVA: 0x7FFD54A05660
        public void Initialize_ctrlTouchscreentouch6delta(){} // RVA: 0x7FFD54A05990
        public void Initialize_ctrlTouchscreentouch6pressure(){} // RVA: 0x7FFD54A05CA0
        public void Initialize_ctrlTouchscreentouch6radius(){} // RVA: 0x7FFD54A05FA0
        public void Initialize_ctrlTouchscreentouch6phase(){} // RVA: 0x7FFD54A062B0
        public void Initialize_ctrlTouchscreentouch6press(){} // RVA: 0x7FFD54A065C0
        public void Initialize_ctrlTouchscreentouch6tapCount(){} // RVA: 0x7FFD54A06920
        public void Initialize_ctrlTouchscreentouch6displayIndex(){} // RVA: 0x7FFD54A06C20
        public void Initialize_ctrlTouchscreentouch6indirectTouch(){} // RVA: 0x7FFD54A06F20
        public void Initialize_ctrlTouchscreentouch6tap(){} // RVA: 0x7FFD54A07280
        public void Initialize_ctrlTouchscreentouch6startTime(){} // RVA: 0x7FFD54A075E0
        public void Initialize_ctrlTouchscreentouch6startPosition(){} // RVA: 0x7FFD54A078F0
        public void Initialize_ctrlTouchscreentouch6positionx(){} // RVA: 0x7FFD54A07C10
        public void Initialize_ctrlTouchscreentouch6positiony(){} // RVA: 0x7FFD54A07F30
        public void Initialize_ctrlTouchscreentouch6deltaup(){} // RVA: 0x7FFD54A08250
        public void Initialize_ctrlTouchscreentouch6deltadown(){} // RVA: 0x7FFD54A08580
        public void Initialize_ctrlTouchscreentouch6deltaleft(){} // RVA: 0x7FFD54A088B0
        public void Initialize_ctrlTouchscreentouch6deltaright(){} // RVA: 0x7FFD54A08BE0
        public void Initialize_ctrlTouchscreentouch6deltax(){} // RVA: 0x7FFD54A08F10
        public void Initialize_ctrlTouchscreentouch6deltay(){} // RVA: 0x7FFD54A09210
        public void Initialize_ctrlTouchscreentouch6radiusx(){} // RVA: 0x7FFD54A09510
        public void Initialize_ctrlTouchscreentouch6radiusy(){} // RVA: 0x7FFD54A09810
        public void Initialize_ctrlTouchscreentouch6startPositionx(){} // RVA: 0x7FFD54A09B10
        public void Initialize_ctrlTouchscreentouch6startPositiony(){} // RVA: 0x7FFD54A09E10
        public void Initialize_ctrlTouchscreentouch7touchId(){} // RVA: 0x7FFD54A0A110
        public void Initialize_ctrlTouchscreentouch7position(){} // RVA: 0x7FFD54A0A430
        public void Initialize_ctrlTouchscreentouch7delta(){} // RVA: 0x7FFD54A0A760
        public void Initialize_ctrlTouchscreentouch7pressure(){} // RVA: 0x7FFD54A0AA70
        public void Initialize_ctrlTouchscreentouch7radius(){} // RVA: 0x7FFD54A0AD70
        public void Initialize_ctrlTouchscreentouch7phase(){} // RVA: 0x7FFD54A0B080
        public void Initialize_ctrlTouchscreentouch7press(){} // RVA: 0x7FFD54A0B390
        public void Initialize_ctrlTouchscreentouch7tapCount(){} // RVA: 0x7FFD54A0B6F0
        public void Initialize_ctrlTouchscreentouch7displayIndex(){} // RVA: 0x7FFD54A0B9F0
        public void Initialize_ctrlTouchscreentouch7indirectTouch(){} // RVA: 0x7FFD54A0BCF0
        public void Initialize_ctrlTouchscreentouch7tap(){} // RVA: 0x7FFD54A0C050
        public void Initialize_ctrlTouchscreentouch7startTime(){} // RVA: 0x7FFD54A0C3B0
        public void Initialize_ctrlTouchscreentouch7startPosition(){} // RVA: 0x7FFD54A0C6C0
        public void Initialize_ctrlTouchscreentouch7positionx(){} // RVA: 0x7FFD54A0C9E0
        public void Initialize_ctrlTouchscreentouch7positiony(){} // RVA: 0x7FFD54A0CD00
        public void Initialize_ctrlTouchscreentouch7deltaup(){} // RVA: 0x7FFD54A0D020
        public void Initialize_ctrlTouchscreentouch7deltadown(){} // RVA: 0x7FFD54A0D350
        public void Initialize_ctrlTouchscreentouch7deltaleft(){} // RVA: 0x7FFD54A0D680
        public void Initialize_ctrlTouchscreentouch7deltaright(){} // RVA: 0x7FFD54A0D9B0
        public void Initialize_ctrlTouchscreentouch7deltax(){} // RVA: 0x7FFD54A0DCE0
        public void Initialize_ctrlTouchscreentouch7deltay(){} // RVA: 0x7FFD54A0DFE0
        public void Initialize_ctrlTouchscreentouch7radiusx(){} // RVA: 0x7FFD54A0E2E0
        public void Initialize_ctrlTouchscreentouch7radiusy(){} // RVA: 0x7FFD54A0E5E0
        public void Initialize_ctrlTouchscreentouch7startPositionx(){} // RVA: 0x7FFD54A0E8E0
        public void Initialize_ctrlTouchscreentouch7startPositiony(){} // RVA: 0x7FFD54A0EBE0
        public void Initialize_ctrlTouchscreentouch8touchId(){} // RVA: 0x7FFD54A0EEE0
        public void Initialize_ctrlTouchscreentouch8position(){} // RVA: 0x7FFD54A0F200
        public void Initialize_ctrlTouchscreentouch8delta(){} // RVA: 0x7FFD54A0F530
        public void Initialize_ctrlTouchscreentouch8pressure(){} // RVA: 0x7FFD54A0F840
        public void Initialize_ctrlTouchscreentouch8radius(){} // RVA: 0x7FFD54A0FB40
        public void Initialize_ctrlTouchscreentouch8phase(){} // RVA: 0x7FFD54A0FE50
        public void Initialize_ctrlTouchscreentouch8press(){} // RVA: 0x7FFD54A10160
        public void Initialize_ctrlTouchscreentouch8tapCount(){} // RVA: 0x7FFD54A104C0
        public void Initialize_ctrlTouchscreentouch8displayIndex(){} // RVA: 0x7FFD54A107C0
        public void Initialize_ctrlTouchscreentouch8indirectTouch(){} // RVA: 0x7FFD54A10AC0
        public void Initialize_ctrlTouchscreentouch8tap(){} // RVA: 0x7FFD54A10E20
        public void Initialize_ctrlTouchscreentouch8startTime(){} // RVA: 0x7FFD54A11180
        public void Initialize_ctrlTouchscreentouch8startPosition(){} // RVA: 0x7FFD54A11490
        public void Initialize_ctrlTouchscreentouch8positionx(){} // RVA: 0x7FFD54A117B0
        public void Initialize_ctrlTouchscreentouch8positiony(){} // RVA: 0x7FFD54A11AD0
        public void Initialize_ctrlTouchscreentouch8deltaup(){} // RVA: 0x7FFD54A11DF0
        public void Initialize_ctrlTouchscreentouch8deltadown(){} // RVA: 0x7FFD54A12120
        public void Initialize_ctrlTouchscreentouch8deltaleft(){} // RVA: 0x7FFD54A12450
        public void Initialize_ctrlTouchscreentouch8deltaright(){} // RVA: 0x7FFD54A12780
        public void Initialize_ctrlTouchscreentouch8deltax(){} // RVA: 0x7FFD54A12AB0
        public void Initialize_ctrlTouchscreentouch8deltay(){} // RVA: 0x7FFD54A12DB0
        public void Initialize_ctrlTouchscreentouch8radiusx(){} // RVA: 0x7FFD54A130B0
        public void Initialize_ctrlTouchscreentouch8radiusy(){} // RVA: 0x7FFD54A133B0
        public void Initialize_ctrlTouchscreentouch8startPositionx(){} // RVA: 0x7FFD54A136B0
        public void Initialize_ctrlTouchscreentouch8startPositiony(){} // RVA: 0x7FFD54A139B0
        public void Initialize_ctrlTouchscreentouch9touchId(){} // RVA: 0x7FFD54A13CB0
        public void Initialize_ctrlTouchscreentouch9position(){} // RVA: 0x7FFD54A13FD0
        public void Initialize_ctrlTouchscreentouch9delta(){} // RVA: 0x7FFD54A14300
        public void Initialize_ctrlTouchscreentouch9pressure(){} // RVA: 0x7FFD54A14610
        public void Initialize_ctrlTouchscreentouch9radius(){} // RVA: 0x7FFD54A14910
        public void Initialize_ctrlTouchscreentouch9phase(){} // RVA: 0x7FFD54A14C20
        public void Initialize_ctrlTouchscreentouch9press(){} // RVA: 0x7FFD54A14F30
        public void Initialize_ctrlTouchscreentouch9tapCount(){} // RVA: 0x7FFD54A15290
        public void Initialize_ctrlTouchscreentouch9displayIndex(){} // RVA: 0x7FFD54A15590
        public void Initialize_ctrlTouchscreentouch9indirectTouch(){} // RVA: 0x7FFD54A15890
        public void Initialize_ctrlTouchscreentouch9tap(){} // RVA: 0x7FFD54A15BF0
        public void Initialize_ctrlTouchscreentouch9startTime(){} // RVA: 0x7FFD54A15F50
        public void Initialize_ctrlTouchscreentouch9startPosition(){} // RVA: 0x7FFD54A16260
        public void Initialize_ctrlTouchscreentouch9positionx(){} // RVA: 0x7FFD54A16580
        public void Initialize_ctrlTouchscreentouch9positiony(){} // RVA: 0x7FFD54A168A0
        public void Initialize_ctrlTouchscreentouch9deltaup(){} // RVA: 0x7FFD54A16BC0
        public void Initialize_ctrlTouchscreentouch9deltadown(){} // RVA: 0x7FFD54A16EF0
        public void Initialize_ctrlTouchscreentouch9deltaleft(){} // RVA: 0x7FFD54A17220
        public void Initialize_ctrlTouchscreentouch9deltaright(){} // RVA: 0x7FFD54A17550
        public void Initialize_ctrlTouchscreentouch9deltax(){} // RVA: 0x7FFD54A17880
        public void Initialize_ctrlTouchscreentouch9deltay(){} // RVA: 0x7FFD54A17B80
        public void Initialize_ctrlTouchscreentouch9radiusx(){} // RVA: 0x7FFD54A17E80
        public void Initialize_ctrlTouchscreentouch9radiusy(){} // RVA: 0x7FFD54A18180
        public void Initialize_ctrlTouchscreentouch9startPositionx(){} // RVA: 0x7FFD54A18480
        public void Initialize_ctrlTouchscreentouch9startPositiony(){} // RVA: 0x7FFD54A18780
    }

    public class Gamepad : InputDevice
    {
        public object buttonWest;
        public object buttonNorth;
        public object buttonSouth;
        public object buttonEast;
        public object leftStickButton;
        public object rightStickButton;
        public object startButton;
        public object selectButton;
        public object dpad;
        public object leftShoulder;
        public object rightShoulder;
        public object leftStick;
        public object rightStick;
        public object leftTrigger;
        public object rightTrigger;
        public object aButton;
        public object bButton;
        public object xButton;
        public object yButton;
        public object triangleButton;
        public object squareButton;
        public object circleButton;
        public object crossButton;
        public object Item;
        public object current;
        public object all;

        // ── Methods ──
        public void get_buttonWest(){} // RVA: 0x7FFD4E960F60
        public void set_buttonWest(){} // RVA: 0x7FFD4EDCB1D0
        public void get_buttonNorth(){} // RVA: 0x7FFD4E961C80
        public void set_buttonNorth(){} // RVA: 0x7FFD4EDE8ED0
        public void get_buttonSouth(){} // RVA: 0x7FFD4E96E2E0
        public void set_buttonSouth(){} // RVA: 0x7FFD4EDC8AF0
        public void get_buttonEast(){} // RVA: 0x7FFD4E968F80
        public void set_buttonEast(){} // RVA: 0x7FFD4EDD4D10
        public void get_leftStickButton(){} // RVA: 0x7FFD4E969F30
        public void set_leftStickButton(){} // RVA: 0x7FFD4EDC7790
        public void get_rightStickButton(){} // RVA: 0x7FFD4E964330
        public void set_rightStickButton(){} // RVA: 0x7FFD4EDCC050
        public void get_startButton(){} // RVA: 0x7FFD4E9622B0
        public void set_startButton(){} // RVA: 0x7FFD4EDCD110
        public void get_selectButton(){} // RVA: 0x7FFD4EDECB10
        public void set_selectButton(){} // RVA: 0x7FFD4EDEF3F0
        public void get_dpad(){} // RVA: 0x7FFD4EDE1920
        public void set_dpad(){} // RVA: 0x7FFD4EDC8050
        public void get_leftShoulder(){} // RVA: 0x7FFD4EDE0A30
        public void set_leftShoulder(){} // RVA: 0x7FFD4EDEF5C0
        public void get_rightShoulder(){} // RVA: 0x7FFD4E818150
        public void set_rightShoulder(){} // RVA: 0x7FFD4EDD1270
        public void get_leftStick(){} // RVA: 0x7FFD4EDD1060
        public void set_leftStick(){} // RVA: 0x7FFD4EDCC5A0
        public void get_rightStick(){} // RVA: 0x7FFD4E964EF0
        public void set_rightStick(){} // RVA: 0x7FFD4E961400
        public void get_leftTrigger(){} // RVA: 0x7FFD4E961460
        public void set_leftTrigger(){} // RVA: 0x7FFD4E964450
        public void get_rightTrigger(){} // RVA: 0x7FFD4E964790
        public void set_rightTrigger(){} // RVA: 0x7FFD4E96D230
        public void get_aButton(){} // RVA: 0x7FFD4E96E2E0
        public void get_bButton(){} // RVA: 0x7FFD4E968F80
        public void get_xButton(){} // RVA: 0x7FFD4E960F60
        public void get_yButton(){} // RVA: 0x7FFD4E961C80
        public void get_triangleButton(){} // RVA: 0x7FFD4E961C80
        public void get_squareButton(){} // RVA: 0x7FFD4E960F60
        public void get_circleButton(){} // RVA: 0x7FFD4E968F80
        public void get_crossButton(){} // RVA: 0x7FFD4E96E2E0
        public void get_Item(){} // RVA: 0x7FFD549B0210
        public void get_current(){} // RVA: 0x7FFD549B0430
        public void set_current(){} // RVA: 0x7FFD549B0470
        public void get_all(){} // RVA: 0x7FFD549B0510
        public void FinishSetup(){} // RVA: 0x7FFD549B05D0
        public void MakeCurrent(){} // RVA: 0x7FFD549B0DD0
        public void OnAdded(){} // RVA: 0x7FFD549B0DE0
        public void OnRemoved(){} // RVA: 0x7FFD549B0E60
        public void PauseHaptics(){} // RVA: 0x7FFD549B0FF0
        public void ResumeHaptics(){} // RVA: 0x7FFD549B1010
        public void ResetHaptics(){} // RVA: 0x7FFD549B10D0
        public void SetMotorSpeeds(){} // RVA: 0x7FFD549B1180
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class GravitySensor : Sensor
    {
        public object gravity;
        public object current;

        // ── Methods ──
        public void get_gravity(){} // RVA: 0x7FFD4E960F60
        public void set_gravity(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A26600
        public void set_current(){} // RVA: 0x7FFD54A26640
        public void FinishSetup(){} // RVA: 0x7FFD54A266E0
        public void MakeCurrent(){} // RVA: 0x7FFD54A26790
        public void OnRemoved(){} // RVA: 0x7FFD54A267A0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class Gyroscope : Sensor
    {
        public object angularVelocity;
        public object current;

        // ── Methods ──
        public void get_angularVelocity(){} // RVA: 0x7FFD4E960F60
        public void set_angularVelocity(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A26410
        public void set_current(){} // RVA: 0x7FFD54A26450
        public void MakeCurrent(){} // RVA: 0x7FFD54A264F0
        public void OnRemoved(){} // RVA: 0x7FFD54A26500
        public void FinishSetup(){} // RVA: 0x7FFD54A26550
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class HumiditySensor : Sensor
    {
        public object relativeHumidity;
        public object current;

        // ── Methods ──
        public void get_relativeHumidity(){} // RVA: 0x7FFD4E960F60
        public void set_relativeHumidity(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A27390
        public void set_current(){} // RVA: 0x7FFD54A273D0
        public void MakeCurrent(){} // RVA: 0x7FFD54A27470
        public void OnRemoved(){} // RVA: 0x7FFD54A27480
        public void FinishSetup(){} // RVA: 0x7FFD54A274D0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class IInputActionCollection
    {
        public object bindingMask;
        public object devices;
        public object controlSchemes;

        // ── Methods ──
        public void get_bindingMask(){} // RVA: 0x7FFD4E2ADC40
        public void set_bindingMask(){}
        public void get_devices(){} // RVA: 0x7FFD4E2ADC40
        public void set_devices(){}
        public void get_controlSchemes(){}
        public void Contains(){} // RVA: 0x7FFD4E079F60
        public void Enable(){} // RVA: 0x7FFD4E090980
        public void Disable(){} // RVA: 0x7FFD4E090980
    }

    public class IInputActionCollection2
    {
        public object bindings;

        // ── Methods ──
        public void get_bindings(){} // RVA: 0x7FFD4E078E90
        public void FindAction(){} // RVA: 0x7FFD4E0896F0
        public void FindBinding(){}
    }

    public class IInputInteraction
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD4E090A40
        public void Reset(){} // RVA: 0x7FFD4E090980
    }

    public class IInputInteraction`1
    {
    }

    public class InputAction : Object
    {
        public object name;
        public object type;
        public object id;
        public object idDontGenerate;
        public object expectedControlType;
        public object processors;
        public object interactions;
        public object actionMap;
        public object bindingMask;
        public object bindings;
        public object controls;
        public object phase;
        public object inProgress;
        public object enabled;
        public object triggered;
        public object activeControl;
        public object activeValueType;
        public object wantsInitialStateCheck;
        public object isSingletonAction;
        public object currentState;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E35C380
        public void get_type(){} // RVA: 0x7FFD4E577800
        public void get_id(){} // RVA: 0x7FFD5493AB10
        public void get_idDontGenerate(){} // RVA: 0x7FFD5493AB60
        public void get_expectedControlType(){} // RVA: 0x7FFD4E36F0C0
        public void set_expectedControlType(){} // RVA: 0x7FFD4E36F0D0
        public void get_processors(){} // RVA: 0x7FFD4E5F95E0
        public void get_interactions(){} // RVA: 0x7FFD4E5F0140
        public void get_actionMap(){} // RVA: 0x7FFD5493AC60
        public void get_bindingMask(){} // RVA: 0x7FFD51F42550
        public void set_bindingMask(){} // RVA: 0x7FFD5493AC80
        public void get_bindings(){} // RVA: 0x7FFD5493AFE0
        public void get_controls(){} // RVA: 0x7FFD5493B0E0
        public void get_phase(){} // RVA: 0x7FFD5493B210
        public void get_inProgress(){} // RVA: 0x7FFD5493B270
        public void get_enabled(){} // RVA: 0x7FFD5493B2D0
        public void add_started(){} // RVA: 0x7FFD5493B330
        public void remove_started(){} // RVA: 0x7FFD5493B390
        public void add_canceled(){} // RVA: 0x7FFD5493B3F0
        public void remove_canceled(){} // RVA: 0x7FFD5493B450
        public void add_performed(){} // RVA: 0x7FFD5493B4B0
        public void remove_performed(){} // RVA: 0x7FFD5493B510
        public void get_triggered(){} // RVA: 0x7FFD5493B570
        public void get_activeControl(){} // RVA: 0x7FFD5493B610
        public void get_activeValueType(){} // RVA: 0x7FFD5493B690
        public void get_wantsInitialStateCheck(){} // RVA: 0x7FFD5493B700
        public void set_wantsInitialStateCheck(){} // RVA: 0x7FFD5493B720
        public void .ctor(){} // RVA: 0x7FFD5493B830 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFD5493BE00
        public void ToString(){} // RVA: 0x7FFD5493BE20
        public void Enable(){} // RVA: 0x7FFD5493C130
        public void Disable(){} // RVA: 0x7FFD5493C470
        public void Clone(){} // RVA: 0x7FFD5493C770
        public void System.ICloneable.Clone(){} // RVA: 0x7FFD5493CA20
        public void ReadValue(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueAsObject(){} // RVA: 0x7FFD5493CA30
        public void GetControlMagnitude(){} // RVA: 0x7FFD5493CAB0
        public void Reset(){} // RVA: 0x7FFD5493CB10
        public void IsPressed(){} // RVA: 0x7FFD5493CBB0
        public void IsInProgress(){} // RVA: 0x7FFD5493CC10
        public void ExpectedFrame(){} // RVA: 0x7FFD5493CC80
        public void WasPressedThisFrame(){} // RVA: 0x7FFD5493CD30
        public void WasPressedThisDynamicUpdate(){} // RVA: 0x7FFD5493CDD0
        public void WasReleasedThisFrame(){} // RVA: 0x7FFD5493CE40
        public void WasReleasedThisDynamicUpdate(){} // RVA: 0x7FFD5493CEE0
        public void WasPerformedThisFrame(){} // RVA: 0x7FFD5493B570
        public void WasPerformedThisDynamicUpdate(){} // RVA: 0x7FFD5493CF50
        public void WasCompletedThisFrame(){} // RVA: 0x7FFD5493CFC0
        public void WasCompletedThisDynamicUpdate(){} // RVA: 0x7FFD5493D060
        public void GetTimeoutCompletionPercentage(){} // RVA: 0x7FFD5493D0D0
        public void get_isSingletonAction(){} // RVA: 0x7FFD5493D210
        public void get_currentState(){} // RVA: 0x7FFD5493D230
        public void MakeSureIdIsInPlace(){} // RVA: 0x7FFD5493D2C0
        public void GenerateId(){} // RVA: 0x7FFD5493D2F0
        public void GetOrCreateActionMap(){} // RVA: 0x7FFD5493D3D0
        public void CreateInternalActionMapForSingletonAction(){} // RVA: 0x7FFD5493D410
        public void RequestInitialStateCheckOnEnabledAction(){} // RVA: 0x7FFD5493D650
        public void ActiveControlIsValid(){} // RVA: 0x7FFD5493D720
        public void FindEffectiveBindingMask(){} // RVA: 0x7FFD5493D820
        public void BindingIndexOnActionToBindingIndexOnMap(){} // RVA: 0x7FFD5493D950
        public void BindingIndexOnMapToBindingIndexOnAction(){} // RVA: 0x7FFD5493DB00
        public void .cctor(){} // RVA: 0x7FFD5493DC90
    }

    public class InputActionAsset : ScriptableObject
    {
        public object enabled;
        public object actionMaps;
        public object controlSchemes;
        public object bindings;
        public object bindingMask;
        public object devices;
        public object Item;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFD5493E9E0
        public void get_actionMaps(){} // RVA: 0x7FFD5493EBB0
        public void get_controlSchemes(){} // RVA: 0x7FFD5493EC70
        public void get_bindings(){} // RVA: 0x7FFD5493ED30
        public void get_bindingMask(){} // RVA: 0x7FFD5493EDE0
        public void set_bindingMask(){} // RVA: 0x7FFD5493EE20
        public void get_devices(){} // RVA: 0x7FFD5493F040
        public void set_devices(){} // RVA: 0x7FFD5493F080
        public void get_Item(){} // RVA: 0x7FFD5493F100
        public void ToJson(){} // RVA: 0x7FFD5493F190
        public void LoadFromJson(){} // RVA: 0x7FFD5493F480
        public void FromJson(){} // RVA: 0x7FFD5493F640
        public void FindAction(){} // RVA: 0x7FFD54940210 | overloaded x2
        public void FindBinding(){} // RVA: 0x7FFD5493FCA0
        public void FindActionMap(){} // RVA: 0x7FFD54940100 | overloaded x2
        public void FindControlSchemeIndex(){} // RVA: 0x7FFD54940390
        public void FindControlScheme(){} // RVA: 0x7FFD54940530
        public void IsUsableWithDevice(){} // RVA: 0x7FFD549406B0
        public void Enable(){} // RVA: 0x7FFD54940810
        public void Disable(){} // RVA: 0x7FFD54940A20
        public void Contains(){} // RVA: 0x7FFD54940BF0
        public void GetEnumerator(){} // RVA: 0x7FFD54940D70
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD54940E10
        public void MarkAsDirty(){} // RVA: 0x7FFD4E341310
        public void IsEmpty(){} // RVA: 0x7FFD54940E20
        public void OnWantToChangeSetup(){} // RVA: 0x7FFD54940EB0
        public void OnSetupChanged(){} // RVA: 0x7FFD54940F20
        public void ReResolveIfNecessary(){} // RVA: 0x7FFD54940FF0
        public void ResolveBindingsIfNecessary(){} // RVA: 0x7FFD54941030
        public void OnDestroy(){} // RVA: 0x7FFD549410D0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class InputActionMap : Object
    {
        public object name;
        public object asset;
        public object id;
        public object idDontGenerate;
        public object enabled;
        public object actions;
        public object bindings;
        public object UnityEngine.InputSystem.IInputActionCollection2.bindings;
        public object controlSchemes;
        public object bindingMask;
        public object devices;
        public object Item;
        public object needToResolveBindings;
        public object bindingResolutionNeedsFullReResolve;
        public object controlsForEachActionInitialized;
        public object bindingsForEachActionInitialized;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E35C380
        public void get_asset(){} // RVA: 0x7FFD4E36F0C0
        public void get_id(){} // RVA: 0x7FFD54941A40
        public void get_idDontGenerate(){} // RVA: 0x7FFD54941A90
        public void get_enabled(){} // RVA: 0x7FFD542B6A00
        public void get_actions(){} // RVA: 0x7FFD54941B90
        public void get_bindings(){} // RVA: 0x7FFD54941C50
        public void UnityEngine.InputSystem.IInputActionCollection2.get_bindings(){} // RVA: 0x7FFD54941D10
        public void get_controlSchemes(){} // RVA: 0x7FFD54941D70
        public void get_bindingMask(){} // RVA: 0x7FFD54941E80
        public void set_bindingMask(){} // RVA: 0x7FFD54941EC0
        public void get_devices(){} // RVA: 0x7FFD549420D0
        public void set_devices(){} // RVA: 0x7FFD549421B0
        public void get_Item(){} // RVA: 0x7FFD54942200
        public void add_actionTriggered(){} // RVA: 0x7FFD54942310
        public void remove_actionTriggered(){} // RVA: 0x7FFD54942370
        public void .ctor(){} // RVA: 0x7FFD54942440 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFD54942500
        public void FindActionIndex(){} // RVA: 0x7FFD54942A60 | overloaded x2
        public void SetUpActionLookupTable(){} // RVA: 0x7FFD54942810
        public void ClearActionLookupTable(){} // RVA: 0x7FFD54942A10
        public void FindAction(){} // RVA: 0x7FFD54942CA0 | overloaded x2
        public void IsUsableWithDevice(){} // RVA: 0x7FFD54942DD0
        public void Enable(){} // RVA: 0x7FFD54942ED0
        public void Disable(){} // RVA: 0x7FFD54942F40
        public void Clone(){} // RVA: 0x7FFD54942F70
        public void System.ICloneable.Clone(){} // RVA: 0x7FFD54943540
        public void Contains(){} // RVA: 0x7FFD54943550
        public void ToString(){} // RVA: 0x7FFD54943580
        public void GetEnumerator(){} // RVA: 0x7FFD549436E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD549436E0
        public void get_needToResolveBindings(){} // RVA: 0x7FFD54943810
        public void set_needToResolveBindings(){} // RVA: 0x7FFD54943820
        public void get_bindingResolutionNeedsFullReResolve(){} // RVA: 0x7FFD54943840
        public void set_bindingResolutionNeedsFullReResolve(){} // RVA: 0x7FFD54943850
        public void get_controlsForEachActionInitialized(){} // RVA: 0x7FFD54943870
        public void set_controlsForEachActionInitialized(){} // RVA: 0x7FFD54943880
        public void get_bindingsForEachActionInitialized(){} // RVA: 0x7FFD549438A0
        public void set_bindingsForEachActionInitialized(){} // RVA: 0x7FFD549438B0
        public void GetBindingsForSingleAction(){} // RVA: 0x7FFD549438D0
        public void GetControlsForSingleAction(){} // RVA: 0x7FFD549439B0
        public void SetUpPerActionControlAndBindingArrays(){} // RVA: 0x7FFD54943A90
        public void OnWantToChangeSetup(){} // RVA: 0x7FFD54944810
        public void OnSetupChanged(){} // RVA: 0x7FFD54944B80
        public void OnBindingModified(){} // RVA: 0x7FFD54944EF0
        public void ClearCachedActionData(){} // RVA: 0x7FFD54944F20
        public void GenerateId(){} // RVA: 0x7FFD54945040
        public void LazyResolveBindings(){} // RVA: 0x7FFD54945120
        public void ResolveBindingsIfNecessary(){} // RVA: 0x7FFD54945260
        public void ResolveBindings(){} // RVA: 0x7FFD549452A0
        public void FindBinding(){} // RVA: 0x7FFD54946470
        public void FindBindingRelativeToMap(){} // RVA: 0x7FFD549467A0
        public void FromJson(){} // RVA: 0x7FFD54946850
        public void ToJson(){} // RVA: 0x7FFD54946AA0 | overloaded x2
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void OnAfterDeserialize(){} // RVA: 0x7FFD54946C20
        public void .cctor(){} // RVA: 0x7FFD54946DE0
    }

    public class InputActionProperty : ValueType
    {
        public object action;
        public object reference;
        public object serializedAction;
        public object serializedReference;

        // ── Methods ──
        public void get_action(){} // RVA: 0x7FFD54958510
        public void get_reference(){} // RVA: 0x7FFD54958610
        public void get_serializedAction(){} // RVA: 0x7FFD4F840220
        public void get_serializedReference(){} // RVA: 0x7FFD4E35C380
        public void .ctor(){} // RVA: 0x7FFD549586D0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD54958A40 | overloaded x4
        public void GetHashCode(){} // RVA: 0x7FFD54958B20
        public void op_Equality(){} // RVA: 0x7FFD54958C40
        public void op_Inequality(){} // RVA: 0x7FFD54958C70
    }

    public class InputActionRebindingExtensions : Object
    {
        // ── Methods ──
        public void GetParameterValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void ApplyParameterOverride(){} // RVA: 0x7FFD5494B9D0 | overloaded x8
        public void ExtractParameterOverride(){} // RVA: 0x7FFD4E2ADC40
        public void GetBindingIndex(){} // RVA: 0x7FFD5494CAE0 | overloaded x3
        public void GetBindingForControl(){} // RVA: 0x7FFD5494CC10
        public void GetBindingIndexForControl(){} // RVA: 0x7FFD5494CEF0
        public void GetBindingDisplayString(){} // RVA: 0x7FFD5494D7F0 | overloaded x4
        public void ApplyBindingOverride(){} // RVA: 0x7FFD5494EA70 | overloaded x6
        public void RemoveBindingOverride(){} // RVA: 0x7FFD5494EEE0 | overloaded x3
        public void RemoveAllBindingOverrides(){} // RVA: 0x7FFD5494F390 | overloaded x2
        public void ApplyBindingOverrides(){} // RVA: 0x7FFD5494F5A0
        public void RemoveBindingOverrides(){} // RVA: 0x7FFD5494F860
        public void ApplyBindingOverridesOnMatchingControls(){} // RVA: 0x7FFD5494FFB0 | overloaded x2
        public void SaveBindingOverridesAsJson(){} // RVA: 0x7FFD54950500 | overloaded x2
        public void AddBindingOverrideJsonTo(){} // RVA: 0x7FFD549509B0
        public void LoadBindingOverridesFromJson(){} // RVA: 0x7FFD54950CE0 | overloaded x2
        public void LoadBindingOverridesFromJsonInternal(){} // RVA: 0x7FFD54950E20
        public void PerformInteractiveRebinding(){} // RVA: 0x7FFD54951530
        public void DeferBindingResolution(){} // RVA: 0x7FFD54951B90
    }

    public class InputActionReference : ScriptableObject
    {
        public object asset;
        public object action;

        // ── Methods ──
        public void get_asset(){} // RVA: 0x7FFD4E3447C0
        public void get_action(){} // RVA: 0x7FFD54958CA0
        public void Set(){} // RVA: 0x7FFD549591D0 | overloaded x2
        public void SetInternal(){} // RVA: 0x7FFD54959520
        public void ToString(){} // RVA: 0x7FFD54959900
        public void GetDisplayName(){} // RVA: 0x7FFD54959B40
        public void ToDisplayName(){} // RVA: 0x7FFD54959BC0
        public void op_Implicit(){} // RVA: 0x7FFD54959C70
        public void Create(){} // RVA: 0x7FFD54959C80
        public void ResetCachedAction(){} // RVA: 0x7FFD54959D00
        public void ToInputAction(){} // RVA: 0x7FFD54959EE0
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class InputActionSetupExtensions : Object
    {
        // ── Methods ──
        public void AddActionMap(){} // RVA: 0x7FFD5495A150 | overloaded x2
        public void RemoveActionMap(){} // RVA: 0x7FFD5495A790 | overloaded x2
        public void AddAction(){} // RVA: 0x7FFD5495A920
        public void RemoveAction(){} // RVA: 0x7FFD5495B570 | overloaded x2
        public void AddBinding(){} // RVA: 0x7FFD5495C470 | overloaded x7
        public void AddCompositeBinding(){} // RVA: 0x7FFD5495C5C0
        public void AddBindingInternal(){} // RVA: 0x7FFD5495C950
        public void ChangeBinding(){} // RVA: 0x7FFD5495D600 | overloaded x4
        public void ChangeBindingWithId(){} // RVA: 0x7FFD5495D190 | overloaded x2
        public void ChangeBindingWithGroup(){} // RVA: 0x7FFD5495D320
        public void ChangeBindingWithPath(){} // RVA: 0x7FFD5495D490
        public void ChangeCompositeBinding(){} // RVA: 0x7FFD5495D960
        public void Rename(){} // RVA: 0x7FFD5495DD50
        public void AddControlScheme(){} // RVA: 0x7FFD5495E4B0 | overloaded x2
        public void RemoveControlScheme(){} // RVA: 0x7FFD5495E7A0
        public void WithBindingGroup(){} // RVA: 0x7FFD5495EA10
        public void WithDevice(){} // RVA: 0x7FFD5495EB90
        public void WithRequiredDevice(){} // RVA: 0x7FFD5495EDB0
        public void WithOptionalDevice(){} // RVA: 0x7FFD5495EF10
        public void OrWithRequiredDevice(){} // RVA: 0x7FFD5495F070
        public void OrWithOptionalDevice(){} // RVA: 0x7FFD5495F1D0
    }

    public class InputActionState : Object
    {
        public object totalCompositeCount;
        public object totalMapCount;
        public object totalActionCount;
        public object totalBindingCount;
        public object totalInteractionCount;
        public object totalControlCount;
        public object mapIndices;
        public object actionStates;
        public object bindingStates;
        public object interactionStates;
        public object controlIndexToBindingIndex;
        public object controlGroupingAndComplexity;
        public object controlMagnitudes;
        public object enabledControls;
        public object isProcessingControlStateChange;

        // ── Methods ──
        public void get_totalCompositeCount(){} // RVA: 0x7FFD4E55CBA0
        public void get_totalMapCount(){} // RVA: 0x7FFD4E3E20C0
        public void get_totalActionCount(){} // RVA: 0x7FFD4F34D3C0
        public void get_totalBindingCount(){} // RVA: 0x7FFD4ECB13D0
        public void get_totalInteractionCount(){} // RVA: 0x7FFD4E5110E0
        public void get_totalControlCount(){} // RVA: 0x7FFD4EA4EA40
        public void get_mapIndices(){} // RVA: 0x7FFD4E3AC0B0
        public void get_actionStates(){} // RVA: 0x7FFD4E3DF370
        public void get_bindingStates(){} // RVA: 0x7FFD4E3BCD50
        public void get_interactionStates(){} // RVA: 0x7FFD4E409590
        public void get_controlIndexToBindingIndex(){} // RVA: 0x7FFD4E963900
        public void get_controlGroupingAndComplexity(){} // RVA: 0x7FFD4E96B1A0
        public void get_controlMagnitudes(){} // RVA: 0x7FFD4E505600
        public void get_enabledControls(){} // RVA: 0x7FFD4E380010
        public void get_isProcessingControlStateChange(){} // RVA: 0x7FFD5448B7C0
        public void Initialize(){} // RVA: 0x7FFD54962740
        public void ComputeControlGroupingIfNecessary(){} // RVA: 0x7FFD54962860
        public void ClaimDataFrom(){} // RVA: 0x7FFD54962A60
        public void Finalize(){} // RVA: 0x7FFD54962CB0
        public void Dispose(){} // RVA: 0x7FFD54962D20
        public void Destroy(){} // RVA: 0x7FFD54962D30
        public void Clone(){} // RVA: 0x7FFD549630A0
        public void System.ICloneable.Clone(){} // RVA: 0x7FFD549633D0
        public void IsUsingDevice(){} // RVA: 0x7FFD549633E0
        public void CanUseDevice(){} // RVA: 0x7FFD54963570
        public void HasEnabledActions(){} // RVA: 0x7FFD54963840
        public void FinishBindingCompositeSetups(){} // RVA: 0x7FFD549638A0
        public void PrepareForBindingReResolution(){} // RVA: 0x7FFD549639E0
        public void FinishBindingResolution(){} // RVA: 0x7FFD54963F10
        public void RestoreActionStatesAfterReResolvingBindings(){} // RVA: 0x7FFD54964110
        public void IsActiveControl(){} // RVA: 0x7FFD54964A00
        public void FindControlIndexOnBinding(){} // RVA: 0x7FFD54964AC0
        public void ResetActionStatesDrivenBy(){} // RVA: 0x7FFD54964B30
        public void IsActionBoundToControlFromDevice(){} // RVA: 0x7FFD54964CA0
        public void ResetActionState(){} // RVA: 0x7FFD54964DB0
        public void FetchActionState(){} // RVA: 0x7FFD54965000
        public void FetchMapIndices(){} // RVA: 0x7FFD54965030
        public void EnableAllActions(){} // RVA: 0x7FFD54965080
        public void EnableControls(){} // RVA: 0x7FFD54965A00 | overloaded x3
        public void EnableSingleAction(){} // RVA: 0x7FFD54965250
        public void DisableAllActions(){} // RVA: 0x7FFD5496BC70 | overloaded x2
        public void DisableControls(){} // RVA: 0x7FFD54965BE0 | overloaded x3
        public void DisableSingleAction(){} // RVA: 0x7FFD54965760
        public void SetInitialStateCheckPending(){} // RVA: 0x7FFD54965E70 | overloaded x2
        public void IsControlEnabled(){} // RVA: 0x7FFD54965EB0
        public void SetControlEnabled(){} // RVA: 0x7FFD54965EF0
        public void HookOnBeforeUpdate(){} // RVA: 0x7FFD54965F30
        public void UnhookOnBeforeUpdate(){} // RVA: 0x7FFD549660B0
        public void OnBeforeInitialUpdate(){} // RVA: 0x7FFD54966180
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(){} // RVA: 0x7FFD54966540
        public void UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(){} // RVA: 0x7FFD54966590
        public void ToCombinedMapAndControlAndBindingIndex(){} // RVA: 0x7FFD549665E0
        public void SplitUpMapAndControlAndBindingIndex(){} // RVA: 0x7FFD54966620
        public void GetComplexityFromMonitorIndex(){} // RVA: 0x7FFD54966650
        public void ProcessControlStateChange(){} // RVA: 0x7FFD54966660
        public void ProcessButtonState(){} // RVA: 0x7FFD54966E10
        public void ShouldIgnoreInputOnCompositeBinding(){} // RVA: 0x7FFD54967060
        public void IsConflictingInput(){} // RVA: 0x7FFD54967080
        public void GetActionBindingStartIndexAndCount(){} // RVA: 0x7FFD54967590
        public void ProcessDefaultInteraction(){} // RVA: 0x7FFD549675C0
        public void ProcessInteractions(){} // RVA: 0x7FFD54967980
        public void ProcessTimeout(){} // RVA: 0x7FFD54967C10
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x7FFD54967FF0
        public void StartTimeout(){} // RVA: 0x7FFD54968030
        public void StopTimeout(){} // RVA: 0x7FFD549681E0
        public void ChangePhaseOfInteraction(){} // RVA: 0x7FFD549682C0
        public void ChangePhaseOfAction(){} // RVA: 0x7FFD54968870
        public void ChangePhaseOfActionInternal(){} // RVA: 0x7FFD54968AE0
        public void CallActionListeners(){} // RVA: 0x7FFD54968E20
        public void GetActionOrNoneString(){} // RVA: 0x7FFD54969140
        public void GetActionOrNull(){} // RVA: 0x7FFD54969240 | overloaded x2
        public void GetControl(){} // RVA: 0x7FFD549692E0
        public void GetInteractionOrNull(){} // RVA: 0x7FFD54969330
        public void GetBindingIndexInMap(){} // RVA: 0x7FFD54969370
        public void GetBindingIndexInState(){} // RVA: 0x7FFD549693C0
        public void GetBindingState(){} // RVA: 0x7FFD54969400
        public void GetBinding(){} // RVA: 0x7FFD54969410
        public void GetActionMap(){} // RVA: 0x7FFD54969490
        public void ResetInteractionStateAndCancelIfNecessary(){} // RVA: 0x7FFD549694D0
        public void ResetInteractionState(){} // RVA: 0x7FFD549695B0
        public void GetValueSizeInBytes(){} // RVA: 0x7FFD54969680
        public void GetValueType(){} // RVA: 0x7FFD54969740
        public void IsActuated(){} // RVA: 0x7FFD54969800
        public void ReadValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ApplyProcessors(){} // RVA: 0x7FFD4E2ADC40
        public void EvaluateCompositePartMagnitude(){} // RVA: 0x7FFD54969B40
        public void GetCompositePartPressTime(){} // RVA: 0x7FFD54969C30
        public void ReadCompositePartValue(){} // RVA: 0x7FFD54969CB0 | overloaded x2
        public void ReadCompositePartValueAsObject(){} // RVA: 0x7FFD54969E00
        public void ReadValueAsObject(){} // RVA: 0x7FFD54969F30
        public void ReadValueAsButton(){} // RVA: 0x7FFD5496A1B0
        public void SaveAndResetState(){} // RVA: 0x7FFD5496A320
        public void AddToGlobalList(){} // RVA: 0x7FFD5496A900
        public void RemoveMapFromGlobalList(){} // RVA: 0x7FFD5496A990
        public void CompactGlobalList(){} // RVA: 0x7FFD5496AB40
        public void NotifyListenersOfActionChange(){} // RVA: 0x7FFD5496AF60 | overloaded x2
        public void ResetGlobals(){} // RVA: 0x7FFD5496B090
        public void FindAllEnabledActions(){} // RVA: 0x7FFD5496B2C0
        public void OnDeviceChange(){} // RVA: 0x7FFD5496B5A0
        public void DeferredResolutionOfBindings(){} // RVA: 0x7FFD5496B940
        public void DestroyAllActionMapStates(){} // RVA: 0x7FFD5496BE00
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD5496C050
    }

    public class InputBinding : ValueType
    {
        public object name;
        public object id;
        public object path;
        public object overridePath;
        public object interactions;
        public object overrideInteractions;
        public object processors;
        public object overrideProcessors;
        public object groups;
        public object action;
        public object isComposite;
        public object isPartOfComposite;
        public object hasOverrides;
        public object effectivePath;
        public object effectiveInteractions;
        public object effectiveProcessors;
        public object isEmpty;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4EEF9F60
        public void set_name(){} // RVA: 0x7FFD4ECFFE40
        public void get_id(){} // RVA: 0x7FFD5496D800
        public void set_id(){} // RVA: 0x7FFD5496D900
        public void get_path(){} // RVA: 0x7FFD4E35C380
        public void set_path(){} // RVA: 0x7FFD4E342E30
        public void get_overridePath(){} // RVA: 0x7FFD4E3BE740
        public void set_overridePath(){} // RVA: 0x7FFD4E369200
        public void get_interactions(){} // RVA: 0x7FFD4E3447C0
        public void set_interactions(){} // RVA: 0x7FFD4E3A7E80
        public void get_overrideInteractions(){} // RVA: 0x7FFD4E3BC730
        public void set_overrideInteractions(){} // RVA: 0x7FFD4E3BC740
        public void get_processors(){} // RVA: 0x7FFD4E36F0C0
        public void set_processors(){} // RVA: 0x7FFD4E36F0D0
        public void get_overrideProcessors(){} // RVA: 0x7FFD4E3E20E0
        public void set_overrideProcessors(){} // RVA: 0x7FFD4E4994D0
        public void get_groups(){} // RVA: 0x7FFD4E36F130
        public void set_groups(){} // RVA: 0x7FFD4E342E90
        public void get_action(){} // RVA: 0x7FFD4E5F95E0
        public void set_action(){} // RVA: 0x7FFD4E36F890
        public void get_isComposite(){} // RVA: 0x7FFD5496D9A0
        public void set_isComposite(){} // RVA: 0x7FFD5496D9B0
        public void get_isPartOfComposite(){} // RVA: 0x7FFD5496D9D0
        public void set_isPartOfComposite(){} // RVA: 0x7FFD5496D9E0
        public void get_hasOverrides(){} // RVA: 0x7FFD5496DA00
        public void .ctor(){} // RVA: 0x7FFD5496DA20
        public void GetNameOfComposite(){} // RVA: 0x7FFD5496DD50
        public void GenerateId(){} // RVA: 0x7FFD5496DDF0
        public void RemoveOverrides(){} // RVA: 0x7FFD5496DED0
        public void MaskByGroup(){} // RVA: 0x7FFD5496DFD0
        public void MaskByGroups(){} // RVA: 0x7FFD5496E050
        public void get_effectivePath(){} // RVA: 0x7FFD5496E280
        public void get_effectiveInteractions(){} // RVA: 0x7FFD5496E290
        public void get_effectiveProcessors(){} // RVA: 0x7FFD5496E2A0
        public void get_isEmpty(){} // RVA: 0x7FFD5496E2B0
        public void Equals(){} // RVA: 0x7FFD5496E6A0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD5496E770
        public void op_Inequality(){} // RVA: 0x7FFD5496E7C0
        public void GetHashCode(){} // RVA: 0x7FFD5496E850
        public void ToString(){} // RVA: 0x7FFD5496E980
        public void ToDisplayString(){} // RVA: 0x7FFD5496EAE0 | overloaded x2
        public void TriggersAction(){} // RVA: 0x7FFD5496EFE0
        public void Matches(){} // RVA: 0x7FFD5496F120 | overloaded x2
    }

    public class InputBindingComposite : Object
    {
        public object valueType;
        public object valueSizeInBytes;

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFD4E078E90
        public void get_valueSizeInBytes(){} // RVA: 0x7FFD4E079960
        public void ReadValue(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueAsObject(){} // RVA: 0x7FFD4E078F40
        public void EvaluateMagnitude(){} // RVA: 0x7FFD5496F350
        public void FinishSetup(){} // RVA: 0x7FFD4E341310
        public void CallFinishSetup(){} // RVA: 0x7FFD547B14C0
        public void GetValueType(){} // RVA: 0x7FFD5496F360
        public void GetExpectedControlLayoutName(){} // RVA: 0x7FFD5496F4A0
        public void GetPartNames(){} // RVA: 0x7FFD5496F640
        public void GetDisplayFormatString(){} // RVA: 0x7FFD5496F6F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class InputBindingCompositeContext : ValueType
    {
        public object controls;

        // ── Methods ──
        public void get_controls(){} // RVA: 0x7FFD549958D0
        public void EvaluateMagnitude(){} // RVA: 0x7FFD54995980
        public void ReadValue(){} // RVA: 0x7FFD54995B20 | overloaded x5
        public void ReadValueAsButton(){} // RVA: 0x7FFD54995A80
        public void ReadValueAsObject(){} // RVA: 0x7FFD54995C70
        public void GetPressTime(){} // RVA: 0x7FFD54995DB0
    }

    public class InputBindingComposite`1 : InputBindingComposite
    {
        public object valueType;
        public object valueSizeInBytes;

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFD4E078E90
        public void get_valueSizeInBytes(){} // RVA: 0x7FFD4E079960
        public void ReadValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ReadValueAsObject(){} // RVA: 0x7FFD4E078F40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class InputBindingResolver : ValueType
    {
        public object totalMapCount;
        public object totalActionCount;
        public object totalBindingCount;
        public object totalControlCount;

        // ── Methods ──
        public void get_totalMapCount(){} // RVA: 0x7FFD4E70C4C0
        public void get_totalActionCount(){} // RVA: 0x7FFD4F0A91D0
        public void get_totalBindingCount(){} // RVA: 0x7FFD4EEFEDC0
        public void get_totalControlCount(){} // RVA: 0x7FFD4E9AA870
        public void Dispose(){} // RVA: 0x7FFD54996140
        public void StartWithPreviousResolve(){} // RVA: 0x7FFD54996150
        public void AddActionMap(){} // RVA: 0x7FFD54996580
        public void InstantiateWithParameters(){} // RVA: 0x7FFD4E2ADC40
        public void InstantiateBindingComposite(){} // RVA: 0x7FFD549981F0
        public void ApplyParameters(){} // RVA: 0x7FFD54998580
        public void AssignCompositePartIndex(){} // RVA: 0x7FFD54998A90
    }

    public class InputControl : Object
    {
        public object name;
        public object displayName;
        public object shortDisplayName;
        public object path;
        public object layout;
        public object variants;
        public object device;
        public object parent;
        public object children;
        public object usages;
        public object aliases;
        public object stateBlock;
        public object noisy;
        public object synthetic;
        public object Item;
        public object valueType;
        public object valueSizeInBytes;
        public object magnitude;
        public object currentStatePtr;
        public object previousFrameStatePtr;
        public object defaultStatePtr;
        public object noiseMaskPtr;
        public object stateOffsetRelativeToDeviceRoot;
        public object optimizedControlDataType;
        public object isSetupFinished;
        public object isButton;
        public object isConfigUpToDate;
        public object dontReset;
        public object usesStateFromOtherControl;
        public object hasDefaultState;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD549A3C00
        public void get_displayName(){} // RVA: 0x7FFD549A3C60
        public void set_displayName(){} // RVA: 0x7FFD4E5F0C20
        public void get_shortDisplayName(){} // RVA: 0x7FFD549A3D00
        public void set_shortDisplayName(){} // RVA: 0x7FFD4E3BC740
        public void get_path(){} // RVA: 0x7FFD549A3D60
        public void get_layout(){} // RVA: 0x7FFD549A3EF0
        public void get_variants(){} // RVA: 0x7FFD549A3F50
        public void get_device(){} // RVA: 0x7FFD4E505600
        public void get_parent(){} // RVA: 0x7FFD4E70F410
        public void get_children(){} // RVA: 0x7FFD549A3FB0
        public void get_usages(){} // RVA: 0x7FFD549A4070
        public void get_aliases(){} // RVA: 0x7FFD549A4130
        public void get_stateBlock(){} // RVA: 0x7FFD4F842E80
        public void get_noisy(){} // RVA: 0x7FFD549A41F0
        public void set_noisy(){} // RVA: 0x7FFD549A4200
        public void get_synthetic(){} // RVA: 0x7FFD549A4300
        public void set_synthetic(){} // RVA: 0x7FFD549A4310
        public void get_Item(){} // RVA: 0x7FFD549A4330
        public void get_valueType(){} // RVA: 0x7FFD4E078E90
        public void get_valueSizeInBytes(){} // RVA: 0x7FFD4E079960
        public void get_magnitude(){} // RVA: 0x7FFD549A43F0
        public void ToString(){} // RVA: 0x7FFD549A4470
        public void DebuggerDisplay(){} // RVA: 0x7FFD549A4520
        public void EvaluateMagnitude(){} // RVA: 0x7FFD5496F350 | overloaded x2
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueFromStateAsObject(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7FFD4E2ADC40
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7FFD549A46A0
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7FFD549A4710
        public void CompareValue(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetChildControl(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetChildControl(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD512FCB40
        public void FinishSetup(){} // RVA: 0x7FFD4E341310
        public void RefreshConfigurationIfNeeded(){} // RVA: 0x7FFD549A4940
        public void RefreshConfiguration(){} // RVA: 0x7FFD4E341310
        public void get_currentStatePtr(){} // RVA: 0x7FFD549A4980
        public void get_previousFrameStatePtr(){} // RVA: 0x7FFD549A49E0
        public void get_defaultStatePtr(){} // RVA: 0x7FFD549A4A40
        public void get_noiseMaskPtr(){} // RVA: 0x7FFD549A4A80
        public void get_stateOffsetRelativeToDeviceRoot(){} // RVA: 0x7FFD549A4AC0
        public void get_optimizedControlDataType(){} // RVA: 0x7FFD4FBDB150
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFD4E919180
        public void ApplyParameterChanges(){} // RVA: 0x7FFD549A4B30
        public void SetOptimizedControlDataType(){} // RVA: 0x7FFD549A4C00
        public void SetOptimizedControlDataTypeRecursively(){} // RVA: 0x7FFD549A4CA0
        public void EnsureOptimizationTypeHasNotChanged(){} // RVA: 0x7FFD549A4E90
        public void get_isSetupFinished(){} // RVA: 0x7FFD549A52C0
        public void set_isSetupFinished(){} // RVA: 0x7FFD549A52D0
        public void get_isButton(){} // RVA: 0x7FFD549A52F0
        public void set_isButton(){} // RVA: 0x7FFD549A5300
        public void get_isConfigUpToDate(){} // RVA: 0x7FFD549A5320
        public void set_isConfigUpToDate(){} // RVA: 0x7FFD549A5330
        public void get_dontReset(){} // RVA: 0x7FFD549A5350
        public void set_dontReset(){} // RVA: 0x7FFD549A5360
        public void get_usesStateFromOtherControl(){} // RVA: 0x7FFD549A5380
        public void set_usesStateFromOtherControl(){} // RVA: 0x7FFD549A5390
        public void get_hasDefaultState(){} // RVA: 0x7FFD549A53B0
        public void CallFinishSetupRecursive(){} // RVA: 0x7FFD549A53C0
        public void MakeChildPath(){} // RVA: 0x7FFD549A54A0
        public void BakeOffsetIntoStateBlockRecursive(){} // RVA: 0x7FFD549A5550
        public void GetDeviceIndex(){} // RVA: 0x7FFD549A5640
        public void IsValueConsideredPressed(){} // RVA: 0x7FFD549A57B0
        public void AddProcessor(){} // RVA: 0x7FFD4E341310
        public void MarkAsStale(){} // RVA: 0x7FFD549A5860
        public void MarkAsStaleRecursively(){} // RVA: 0x7FFD549A5870
    }

    public class InputControlExtensions : Object
    {
        // ── Methods ──
        public void FindInParentChain(){} // RVA: 0x7FFD4E2ADC40
        public void IsPressed(){} // RVA: 0x7FFD549A5A80
        public void IsActuated(){} // RVA: 0x7FFD549A5BD0
        public void ReadValueAsObject(){} // RVA: 0x7FFD549A5C70
        public void ReadValueIntoBuffer(){} // RVA: 0x7FFD549A5CF0
        public void ReadDefaultValueAsObject(){} // RVA: 0x7FFD549A5DF0
        public void ReadValueFromEvent(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ReadValueFromEventAsObject(){} // RVA: 0x7FFD549A5EA0
        public void ReadUnprocessedValueFromEvent(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void WriteValueFromObjectIntoEvent(){} // RVA: 0x7FFD549A5FD0
        public void WriteValueIntoState(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void WriteValueIntoEvent(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void CopyState(){} // RVA: 0x7FFD4E090C80 | overloaded x2
        public void CheckStateIsAtDefault(){} // RVA: 0x7FFD549A6590 | overloaded x2
        public void CheckStateIsAtDefaultIgnoringNoise(){} // RVA: 0x7FFD549A6800 | overloaded x2
        public void CompareStateIgnoringNoise(){} // RVA: 0x7FFD549A6950
        public void CompareState(){} // RVA: 0x7FFD549A6C20 | overloaded x2
        public void HasValueChangeInState(){} // RVA: 0x7FFD549A6D10
        public void HasValueChangeInEvent(){} // RVA: 0x7FFD549A6DF0
        public void GetStatePtrFromStateEvent(){} // RVA: 0x7FFD549A6EF0
        public void GetStatePtrFromStateEventUnchecked(){} // RVA: 0x7FFD549A6FB0
        public void ResetToDefaultStateInEvent(){} // RVA: 0x7FFD549A72A0
        public void QueueValueChange(){} // RVA: 0x7FFD4E2ADC40
        public void AccumulateValueInEvent(){} // RVA: 0x7FFD549A7630 | overloaded x2
        public void FindControlsRecursive(){} // RVA: 0x7FFD4E0961F0
        public void BuildPath(){} // RVA: 0x7FFD549A7750
        public void EnumerateControls(){} // RVA: 0x7FFD549A7C70
        public void EnumerateChangedControls(){} // RVA: 0x7FFD549A7EF0
        public void HasButtonPress(){} // RVA: 0x7FFD549A7F40
        public void GetFirstButtonPressOrNull(){} // RVA: 0x7FFD549A7F60
        public void GetAllButtonPresses(){} // RVA: 0x7FFD549A81A0
        public void Setup(){} // RVA: 0x7FFD549A8360 | overloaded x2
    }

    public class InputControlList`1 : ValueType
    {
        public object Count;
        public object Capacity;
        public object IsReadOnly;
        public object Item;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_Capacity(){} // RVA: 0x7FFD4E079960
        public void set_Capacity(){} // RVA: 0x7FFD4E090ED0
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void Resize(){} // RVA: 0x7FFD4E090ED0
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void AddSlice(){} // RVA: 0x7FFD4E2ADC40
        public void AddRange(){}
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SwapElements(){} // RVA: 0x7FFD4E092E60
        public void Sort(){} // RVA: 0x7FFD4E2ADC40
        public void ToArray(){}
        public void AppendTo(){} // RVA: 0x7FFD4E099B30
        public void Dispose(){} // RVA: 0x7FFD4E090980
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void ToIndex(){} // RVA: 0x7FFD4E2ADC40
        public void FromIndex(){} // RVA: 0x7FFD4E2ADC40
    }

    public class InputControlPath : Object
    {
        // ── Methods ──
        public void CleanSlashes(){} // RVA: 0x7FFD549AA8B0
        public void Combine(){} // RVA: 0x7FFD549AA8E0
        public void ToHumanReadableString(){} // RVA: 0x7FFD549AAA20 | overloaded x2
        public void TryGetDeviceUsages(){} // RVA: 0x7FFD549AB0A0
        public void TryGetDeviceLayout(){} // RVA: 0x7FFD549AB2E0
        public void TryGetControlLayout(){} // RVA: 0x7FFD549AB490
        public void FindControlLayoutRecursive(){} // RVA: 0x7FFD549AB980 | overloaded x2
        public void ControlLayoutMatchesPathComponent(){} // RVA: 0x7FFD549ABC30
        public void StringMatches(){} // RVA: 0x7FFD549ABE70
        public void TryFindControl(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void TryFindControls(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void TryFindChild(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Matches(){} // RVA: 0x7FFD549AC660
        public void MatchControlComponent(){} // RVA: 0x7FFD549AC810
        public void MatchesPrefix(){} // RVA: 0x7FFD549ACC50
        public void MatchesRecursive(){} // RVA: 0x7FFD549ACE10
        public void MatchControlsRecursive(){} // RVA: 0x7FFD4E2ADC40
        public void MatchByUsageAtDeviceRootRecursive(){} // RVA: 0x7FFD4E2ADC40
        public void MatchChildrenRecursive(){} // RVA: 0x7FFD4E2ADC40
        public void MatchPathComponent(){} // RVA: 0x7FFD549ACEA0
        public void PathComponentCanYieldMultipleMatches(){} // RVA: 0x7FFD549AD260
        public void Parse(){} // RVA: 0x7FFD549AD320
    }

    public class InputControlScheme : ValueType
    {
        public object name;
        public object bindingGroup;
        public object deviceRequirements;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4EEF9F60
        public void get_bindingGroup(){} // RVA: 0x7FFD4F840220
        public void set_bindingGroup(){} // RVA: 0x7FFD4F840240
        public void get_deviceRequirements(){} // RVA: 0x7FFD54998D10
        public void .ctor(){} // RVA: 0x7FFD54998DD0
        public void SetNameAndBindingGroup(){} // RVA: 0x7FFD54998FC0
        public void FindControlSchemeForDevices(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void FindControlSchemeForDevice(){} // RVA: 0x7FFD4E2ADC40
        public void SupportsDevice(){} // RVA: 0x7FFD54999190
        public void PickDevicesFrom(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD549996F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54999790
        public void ToString(){} // RVA: 0x7FFD54999840
        public void op_Equality(){} // RVA: 0x7FFD54999A40
        public void op_Inequality(){} // RVA: 0x7FFD54999A70
    }

    public class InputControl`1 : InputControl
    {
        public object valueType;
        public object valueSizeInBytes;
        public object value;
        public object unprocessedValue;
        public object processors;

        // ── Methods ──
        public void get_valueType(){} // RVA: 0x7FFD4E078E90
        public void get_valueSizeInBytes(){} // RVA: 0x7FFD4E079960
        public void get_value(){} // RVA: 0x7FFD4E078E90
        public void get_unprocessedValue(){} // RVA: 0x7FFD4E078E90
        public void ReadValue(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueFromPreviousFrame(){} // RVA: 0x7FFD4E2ADC40
        public void ReadDefaultValue(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueFromState(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueFromStateWithCaching(){} // RVA: 0x7FFD4E2ADC40
        public void ReadUnprocessedValueFromStateWithCaching(){} // RVA: 0x7FFD4E2ADC40
        public void ReadUnprocessedValue(){} // RVA: 0x7FFD4E2ADC40
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueFromStateAsObject(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7FFD4E2ADC40
        public void WriteValueFromBufferIntoState(){} // RVA: 0x7FFD4E2ADC40
        public void WriteValueFromObjectIntoState(){} // RVA: 0x7FFD4E2ADC40
        public void WriteValueIntoState(){} // RVA: 0x7FFD4E2ADC40
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7FFD4E2ADC40
        public void CompareValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ProcessValue(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void TryGetProcessor(){} // RVA: 0x7FFD4E2ADC40
        public void AddProcessor(){} // RVA: 0x7FFD4E090A40
        public void FinishSetup(){} // RVA: 0x7FFD4E090980
        public void get_processors(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class InputDevice : InputControl
    {
        public object description;
        public object enabled;
        public object canRunInBackground;
        public object canDeviceRunInBackground;
        public object added;
        public object remote;
        public object native;
        public object updateBeforeRender;
        public object deviceId;
        public object lastUpdateTime;
        public object wasUpdatedThisFrame;
        public object allControls;
        public object valueType;
        public object valueSizeInBytes;
        public object all;
        public object disabledInFrontend;
        public object disabledInRuntime;
        public object disabledWhileInBackground;
        public object hasControlsWithDefaultState;
        public object hasDontResetControls;
        public object hasStateCallbacks;
        public object hasEventMerger;
        public object hasEventPreProcessor;

        // ── Methods ──
        public void get_description(){} // RVA: 0x7FFD549B11B0
        public void get_enabled(){} // RVA: 0x7FFD549B11F0
        public void get_canRunInBackground(){} // RVA: 0x7FFD549B1210
        public void get_canDeviceRunInBackground(){} // RVA: 0x7FFD549B1210
        public void get_added(){} // RVA: 0x7FFD549B12E0
        public void get_remote(){} // RVA: 0x7FFD549B12F0
        public void get_native(){} // RVA: 0x7FFD549B1300
        public void get_updateBeforeRender(){} // RVA: 0x7FFD549B1310
        public void get_deviceId(){} // RVA: 0x7FFD4FBF5FD0
        public void get_lastUpdateTime(){} // RVA: 0x7FFD549B1320
        public void get_wasUpdatedThisFrame(){} // RVA: 0x7FFD549B1370
        public void get_allControls(){} // RVA: 0x7FFD549B13C0
        public void get_valueType(){} // RVA: 0x7FFD549B1490
        public void get_valueSizeInBytes(){} // RVA: 0x7FFD549B1540
        public void get_all(){} // RVA: 0x7FFD549B15D0
        public void .ctor(){} // RVA: 0x7FFD549B1680
        public void ReadValueFromBufferAsObject(){} // RVA: 0x7FFD549B16F0
        public void ReadValueFromStateAsObject(){} // RVA: 0x7FFD549B1730
        public void ReadValueFromStateIntoBuffer(){} // RVA: 0x7FFD549B1880
        public void CompareValue(){} // RVA: 0x7FFD549B1A80
        public void NotifyConfigurationChanged(){} // RVA: 0x7FFD549B1BF0
        public void MakeCurrent(){} // RVA: 0x7FFD4E341310
        public void OnAdded(){} // RVA: 0x7FFD4E341310
        public void OnRemoved(){} // RVA: 0x7FFD4E341310
        public void OnConfigurationChanged(){} // RVA: 0x7FFD4E341310
        public void ExecuteCommand(){} // RVA: 0x7FFD549B1C80 | overloaded x2
        public void QueryEnabledStateFromRuntime(){} // RVA: 0x7FFD549B1D00
        public void get_disabledInFrontend(){} // RVA: 0x7FFD549B1DC0
        public void set_disabledInFrontend(){} // RVA: 0x7FFD549B1DD0
        public void get_disabledInRuntime(){} // RVA: 0x7FFD549B1DF0
        public void set_disabledInRuntime(){} // RVA: 0x7FFD549B1E00
        public void get_disabledWhileInBackground(){} // RVA: 0x7FFD549B1E30
        public void set_disabledWhileInBackground(){} // RVA: 0x7FFD549B1E40
        public void EncodeStateOffsetToControlMapEntry(){} // RVA: 0x7FFD549B1E70
        public void DecodeStateOffsetToControlMapEntry(){} // RVA: 0x7FFD549B1E80
        public void get_hasControlsWithDefaultState(){} // RVA: 0x7FFD549B1EA0
        public void set_hasControlsWithDefaultState(){} // RVA: 0x7FFD549B1EB0
        public void get_hasDontResetControls(){} // RVA: 0x7FFD549B1ED0
        public void set_hasDontResetControls(){} // RVA: 0x7FFD549B1EE0
        public void get_hasStateCallbacks(){} // RVA: 0x7FFD549B1F10
        public void set_hasStateCallbacks(){} // RVA: 0x7FFD549B1F20
        public void get_hasEventMerger(){} // RVA: 0x7FFD549B1F40
        public void set_hasEventMerger(){} // RVA: 0x7FFD549B1F50
        public void get_hasEventPreProcessor(){} // RVA: 0x7FFD549B1F80
        public void set_hasEventPreProcessor(){} // RVA: 0x7FFD549B1F90
        public void AddDeviceUsage(){} // RVA: 0x7FFD549B1FC0
        public void RemoveDeviceUsage(){} // RVA: 0x7FFD549B2080
        public void ClearDeviceUsages(){} // RVA: 0x7FFD549B2250
        public void RequestSync(){} // RVA: 0x7FFD549B22C0
        public void RequestReset(){} // RVA: 0x7FFD549B2340
        public void ExecuteEnableCommand(){} // RVA: 0x7FFD549B23C0
        public void ExecuteDisableCommand(){} // RVA: 0x7FFD549B2440
        public void NotifyAdded(){} // RVA: 0x7FFD541B2640
        public void NotifyRemoved(){} // RVA: 0x7FFD5159D250
        public void Build(){} // RVA: 0x7FFD4E2ADC40
        public void WriteChangedControlStates(){} // RVA: 0x7FFD549B24B0
        public void WritePartialChangedControlStatesInternal(){} // RVA: 0x7FFD549B2630
        public void DumpControlBitRangeNode(){} // RVA: 0x7FFD549B2A40
        public void DumpControlTree(){} // RVA: 0x7FFD549B30E0 | overloaded x2
        public void WriteChangedControlStatesInternal(){} // RVA: 0x7FFD549B31C0
        public void HasDataChangedInRange(){} // RVA: 0x7FFD549B3720
    }

    public class InputExtensions : Object
    {
        // ── Methods ──
        public void IsInProgress(){} // RVA: 0x7FFD53B10D80
        public void IsEndedOrCanceled(){} // RVA: 0x7FFD54A2A170
        public void IsActive(){} // RVA: 0x7FFD54A2A180
        public void IsModifierKey(){} // RVA: 0x7FFD54A2A1A0
        public void IsTextInputKey(){} // RVA: 0x7FFD54A2A1B0
    }

    public class InputFeatureNames : Object
    {
    }

    public class InputInteraction : Object
    {
        // ── Methods ──
        public void GetValueType(){} // RVA: 0x7FFD5493A790
        public void GetDisplayName(){} // RVA: 0x7FFD5493A970 | overloaded x2
    }

    public class InputInteractionContext : ValueType
    {
        public object action;
        public object control;
        public object phase;
        public object time;
        public object startTime;
        public object timerHasExpired;
        public object isWaiting;
        public object isStarted;
        public object mapIndex;
        public object controlIndex;
        public object bindingIndex;
        public object interactionIndex;

        // ── Methods ──
        public void get_action(){} // RVA: 0x7FFD5499AED0
        public void get_control(){} // RVA: 0x7FFD5499AF00
        public void get_phase(){} // RVA: 0x7FFD4FEF9B10
        public void get_time(){} // RVA: 0x7FFD5499AF50
        public void get_startTime(){} // RVA: 0x7FFD5499AF60
        public void get_timerHasExpired(){} // RVA: 0x7FFD5499A160
        public void set_timerHasExpired(){} // RVA: 0x7FFD5499A170
        public void get_isWaiting(){} // RVA: 0x7FFD5499AF70
        public void get_isStarted(){} // RVA: 0x7FFD5499AF80
        public void ComputeMagnitude(){} // RVA: 0x7FFD4E420210
        public void ControlIsActuated(){} // RVA: 0x7FFD5499AF90
        public void Started(){} // RVA: 0x7FFD5499B030
        public void Performed(){} // RVA: 0x7FFD5499B080
        public void PerformedAndStayStarted(){} // RVA: 0x7FFD5499B0E0
        public void PerformedAndStayPerformed(){} // RVA: 0x7FFD5499B140
        public void Canceled(){} // RVA: 0x7FFD5499B190
        public void Waiting(){} // RVA: 0x7FFD5499B1E0
        public void SetTimeout(){} // RVA: 0x7FFD5499B230
        public void SetTotalTimeoutCompletionTime(){} // RVA: 0x7FFD5499B260
        public void ReadValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_mapIndex(){} // RVA: 0x7FFD5499B330
        public void get_controlIndex(){} // RVA: 0x7FFD5499B340
        public void get_bindingIndex(){} // RVA: 0x7FFD53BCD8B0
        public void get_interactionIndex(){} // RVA: 0x7FFD5499B360
    }

    public class InputManager : Object
    {
        public object devices;
        public object processors;
        public object interactions;
        public object composites;
        public object metrics;
        public object settings;
        public object actions;
        public object updateMask;
        public object defaultUpdateType;
        public object scrollDeltaBehavior;
        public object pollingFrequency;
        public object isProcessingEvents;
        public object gameIsPlaying;
        public object gameHasFocus;
        public object gameShouldGetInputRegardlessOfFocus;
        public object optimizedControlsFeatureEnabled;
        public object readValueCachingFeatureEnabled;
        public object paranoidReadValueCachingChecksEnabled;

        // ── Methods ──
        public void get_devices(){} // RVA: 0x7FFD54A2A1D0
        public void get_processors(){} // RVA: 0x7FFD4E409500
        public void get_interactions(){} // RVA: 0x7FFD4E3DF370
        public void get_composites(){} // RVA: 0x7FFD4E3BCD50
        public void get_metrics(){} // RVA: 0x7FFD54A2A280
        public void get_settings(){} // RVA: 0x7FFD4EDDB630
        public void set_settings(){} // RVA: 0x7FFD54A2A4C0
        public void get_actions(){} // RVA: 0x7FFD4EDE3D80
        public void set_actions(){} // RVA: 0x7FFD54A2A6E0
        public void get_updateMask(){} // RVA: 0x7FFD4ED255C0
        public void set_updateMask(){} // RVA: 0x7FFD54A2A740
        public void get_defaultUpdateType(){} // RVA: 0x7FFD54A2A760
        public void get_scrollDeltaBehavior(){} // RVA: 0x7FFD4FBF5FE0
        public void set_scrollDeltaBehavior(){} // RVA: 0x7FFD54A2A7A0
        public void get_pollingFrequency(){} // RVA: 0x7FFD4E46B340
        public void set_pollingFrequency(){} // RVA: 0x7FFD54A2A7B0
        public void add_onDeviceChange(){} // RVA: 0x7FFD54A2A890
        public void remove_onDeviceChange(){} // RVA: 0x7FFD54A2A8F0
        public void add_onDeviceStateChange(){} // RVA: 0x7FFD54A2A950
        public void remove_onDeviceStateChange(){} // RVA: 0x7FFD54A2A9B0
        public void add_onDeviceCommand(){} // RVA: 0x7FFD54A2AA10
        public void remove_onDeviceCommand(){} // RVA: 0x7FFD54A2AA70
        public void add_onFindControlLayoutForDevice(){} // RVA: 0x7FFD54A2AAD0
        public void remove_onFindControlLayoutForDevice(){} // RVA: 0x7FFD54A2AB30
        public void add_onLayoutChange(){} // RVA: 0x7FFD54A2AB90
        public void remove_onLayoutChange(){} // RVA: 0x7FFD54A2ABF0
        public void add_onEvent(){} // RVA: 0x7FFD54A2AC50
        public void remove_onEvent(){} // RVA: 0x7FFD54A2ACB0
        public void add_onBeforeUpdate(){} // RVA: 0x7FFD54A2AD10
        public void remove_onBeforeUpdate(){} // RVA: 0x7FFD54A2AD70
        public void add_onAfterUpdate(){} // RVA: 0x7FFD54A2ADD0
        public void remove_onAfterUpdate(){} // RVA: 0x7FFD54A2AE30
        public void add_onSettingsChange(){} // RVA: 0x7FFD54A2AE90
        public void remove_onSettingsChange(){} // RVA: 0x7FFD54A2AEF0
        public void add_onActionsChange(){} // RVA: 0x7FFD54A2AF50
        public void remove_onActionsChange(){} // RVA: 0x7FFD54A2AFB0
        public void get_isProcessingEvents(){} // RVA: 0x7FFD54A2B010
        public void get_gameIsPlaying(){} // RVA: 0x7FFD4E426850
        public void get_gameHasFocus(){} // RVA: 0x7FFD54A2B020
        public void get_gameShouldGetInputRegardlessOfFocus(){} // RVA: 0x7FFD54A2B060
        public void RegisterControlLayout(){} // RVA: 0x7FFD54A2B8E0 | overloaded x2
        public void RegisterControlLayoutBuilder(){} // RVA: 0x7FFD54A2C120
        public void PerformLayoutPostRegistration(){} // RVA: 0x7FFD54A2C3D0
        public void RegisterPrecompiledLayout(){} // RVA: 0x7FFD4E090A40
        public void RecreateDevicesUsingLayout(){} // RVA: 0x7FFD54A2CBF0
        public void IsControlOrChildUsingLayoutRecursive(){} // RVA: 0x7FFD54A2CE30
        public void IsControlUsingLayout(){} // RVA: 0x7FFD54A2CF30
        public void RegisterControlLayoutMatcher(){} // RVA: 0x7FFD54A2D280 | overloaded x2
        public void RecreateDevicesUsingLayoutWithInferiorMatch(){} // RVA: 0x7FFD54A2D4D0
        public void RecreateDevice(){} // RVA: 0x7FFD54A2D810
        public void AddAvailableDevicesMatchingDescription(){} // RVA: 0x7FFD54A2DA60
        public void RemoveControlLayout(){} // RVA: 0x7FFD54A2DF10
        public void TryLoadControlLayout(){} // RVA: 0x7FFD54A2E530 | overloaded x2
        public void TryFindMatchingControlLayout(){} // RVA: 0x7FFD54A2E560
        public void FindOrRegisterDeviceLayoutForType(){} // RVA: 0x7FFD54A2EB50
        public void IsDeviceLayoutMarkedAsSupportedInSettings(){} // RVA: 0x7FFD54A2EC00
        public void ListControlLayouts(){} // RVA: 0x7FFD54A2ED40
        public void GetControls(){} // RVA: 0x7FFD4E0837A0
        public void SetDeviceUsage(){} // RVA: 0x7FFD54A2EE50
        public void AddDeviceUsage(){} // RVA: 0x7FFD54A2F120
        public void RemoveDeviceUsage(){} // RVA: 0x7FFD54A2F280
        public void NotifyUsageChanged(){} // RVA: 0x7FFD54A2F3E0
        public void AddDevice(){} // RVA: 0x7FFD54A30830 | overloaded x7
        public void RemoveDevice(){} // RVA: 0x7FFD54A30980
        public void FlushDisconnectedDevices(){} // RVA: 0x7FFD54A31250
        public void ResetDevice(){} // RVA: 0x7FFD54A312B0
        public void TryGetDevice(){} // RVA: 0x7FFD54A31C70 | overloaded x2
        public void GetDevice(){} // RVA: 0x7FFD54A31BD0
        public void TryGetDeviceById(){} // RVA: 0x7FFD54A31D00
        public void GetUnsupportedDevices(){} // RVA: 0x7FFD54A31D80
        public void EnableOrDisableDevice(){} // RVA: 0x7FFD54A31F70
        public void QueueEvent(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void Update(){} // RVA: 0x7FFD54A32490 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFD54A324F0
        public void Destroy(){} // RVA: 0x7FFD54A326A0
        public void InitializeActions(){} // RVA: 0x7FFD54A328E0
        public void InitializeData(){} // RVA: 0x7FFD54A329D0
        public void RegisterCustomTypes(){} // RVA: 0x7FFD54A351D0 | overloaded x2
        public void InstallRuntime(){} // RVA: 0x7FFD54A35490
        public void InstallGlobals(){} // RVA: 0x7FFD54A358C0
        public void UninstallGlobals(){} // RVA: 0x7FFD54A35D70
        public void get_optimizedControlsFeatureEnabled(){} // RVA: 0x7FFD54A36000
        public void set_optimizedControlsFeatureEnabled(){} // RVA: 0x7FFD54A36010
        public void get_readValueCachingFeatureEnabled(){} // RVA: 0x7FFD54A36020
        public void set_readValueCachingFeatureEnabled(){} // RVA: 0x7FFD54A36030
        public void get_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x7FFD54A36040
        public void set_paranoidReadValueCachingChecksEnabled(){} // RVA: 0x7FFD54A36050
        public void MakeDeviceNameUnique(){} // RVA: 0x7FFD54A36060
        public void ResetControlPathsRecursive(){} // RVA: 0x7FFD54A36370
        public void AssignUniqueDeviceId(){} // RVA: 0x7FFD54A364B0
        public void ReallocateStateBuffers(){} // RVA: 0x7FFD54A36620
        public void InitializeDefaultState(){} // RVA: 0x7FFD54A36900
        public void InitializeDeviceState(){} // RVA: 0x7FFD54A36AF0
        public void OnNativeDeviceDiscovered(){} // RVA: 0x7FFD54A36E50
        public void MakeEscapedJsonString(){} // RVA: 0x7FFD54A373B0
        public void TryMatchDisconnectedDevice(){} // RVA: 0x7FFD54A37710
        public void InstallBeforeUpdateHookIfNecessary(){} // RVA: 0x7FFD54A37A50
        public void RestoreDevicesAfterDomainReloadIfNecessary(){} // RVA: 0x7FFD4E341310
        public void WarnAboutDevicesFailingToRecreateAfterDomainReload(){} // RVA: 0x7FFD4E341310
        public void OnBeforeUpdate(){} // RVA: 0x7FFD54A37B10
        public void ApplySettings(){} // RVA: 0x7FFD54A37E30
        public void ApplyActions(){} // RVA: 0x7FFD54A387C0
        public void ExecuteGlobalCommand(){} // RVA: 0x7FFD4E078F40
        public void AddAvailableDevicesThatAreNowRecognized(){} // RVA: 0x7FFD54A38850
        public void ShouldRunDeviceInBackground(){} // RVA: 0x7FFD54A38B60
        public void OnFocusChanged(){} // RVA: 0x7FFD54A38BA0
        public void ShouldRunUpdate(){} // RVA: 0x7FFD54A38DE0
        public void OnUpdate(){} // RVA: 0x7FFD54A38E00
        public void AreMaximumEventBytesPerUpdateExceeded(){} // RVA: 0x7FFD54A3A130
        public void MakeStringWithEventsProcessedByDevice(){} // RVA: 0x7FFD54A3A2A0
        public void ResetCurrentProcessedEventBytesForDevices(){} // RVA: 0x7FFD54A3A480
        public void CheckAllDevicesOptimizedControlsHaveValidState(){} // RVA: 0x7FFD54A3A550
        public void InvokeAfterUpdateCallback(){} // RVA: 0x7FFD54A3A750
        public void DontMakeCurrentlyUpdatingDeviceCurrent(){} // RVA: 0x7FFD54A3A7F0
        public void UpdateState(){} // RVA: 0x7FFD54A3A910 | overloaded x2
        public void WriteStateChange(){} // RVA: 0x7FFD54A3B080
        public void FlipBuffersForDeviceIfNecessary(){} // RVA: 0x7FFD54A3B430
        public void AddStateChangeMonitor(){} // RVA: 0x7FFD54A3B4E0
        public void RemoveStateChangeMonitors(){} // RVA: 0x7FFD54A3B690
        public void RemoveStateChangeMonitor(){} // RVA: 0x7FFD54A3B870
        public void AddStateChangeMonitorTimeout(){} // RVA: 0x7FFD54A3BAC0
        public void RemoveStateChangeMonitorTimeout(){} // RVA: 0x7FFD54A3BC50
        public void SortStateChangeMonitorsIfNecessary(){} // RVA: 0x7FFD54A3BDE0
        public void SignalStateChangeMonitor(){} // RVA: 0x7FFD54A3BE30
        public void FireStateChangeNotifications(){} // RVA: 0x7FFD54A3C460 | overloaded x2
        public void ProcessStateChangeMonitors(){} // RVA: 0x7FFD54A3C040
        public void ProcessStateChangeMonitorTimeouts(){} // RVA: 0x7FFD54A3C860
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54A3CBA0
        public void <TryFindMatchingControlLayout>b__94_0(){} // RVA: 0x7FFD54A3D200
    }

    public class InputProcessor : Object
    {
        public object cachingPolicy;

        // ── Methods ──
        public void ProcessAsObject(){} // RVA: 0x7FFD4E08A6F0
        public void Process(){} // RVA: 0x7FFD4E2ADC40
        public void GetValueTypeFromType(){} // RVA: 0x7FFD549B0120
        public void get_cachingPolicy(){} // RVA: 0x7FFD4E919180
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class InputProcessor`1 : InputProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ProcessAsObject(){} // RVA: 0x7FFD4E08A6F0
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class InputRemoting : Object
    {
        public object sending;
        public object manager;

        // ── Methods ──
        public void get_sending(){} // RVA: 0x7FFD54A20820
        public void set_sending(){} // RVA: 0x7FFD54A20830
        public void .ctor(){} // RVA: 0x7FFD54A20850
        public void StartSending(){} // RVA: 0x7FFD54A20910
        public void StopSending(){} // RVA: 0x7FFD54A20B10
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x7FFD54A20CF0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0x7FFD4E341310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0x7FFD4E341310
        public void Subscribe(){} // RVA: 0x7FFD54A20F80
        public void SendInitialMessages(){} // RVA: 0x7FFD54A21100
        public void SendAllGeneratedLayouts(){} // RVA: 0x7FFD54A21120
        public void SendLayout(){} // RVA: 0x7FFD54A213A0
        public void SendAllDevices(){} // RVA: 0x7FFD54A21440
        public void SendDevice(){} // RVA: 0x7FFD54A21690
        public void SendEvent(){} // RVA: 0x7FFD54A21720
        public void SendDeviceChange(){} // RVA: 0x7FFD54A21780
        public void SendLayoutChange(){} // RVA: 0x7FFD54A21910
        public void Send(){} // RVA: 0x7FFD54A21A70
        public void FindOrCreateSenderRecord(){} // RVA: 0x7FFD54A21BB0
        public void BuildLayoutNamespace(){} // RVA: 0x7FFD54A21C80
        public void FindLocalDeviceId(){} // RVA: 0x7FFD54A21D50
        public void TryGetDeviceByRemoteId(){} // RVA: 0x7FFD54A21DC0
        public void get_manager(){} // RVA: 0x7FFD4E3447C0
        public void RemoveRemoteDevices(){} // RVA: 0x7FFD54A21DF0
        public void SerializeData(){} // RVA: 0x7FFD4E2ADC40
        public void DeserializeData(){} // RVA: 0x7FFD4E2ADC40
    }

    public class InputSettings : ScriptableObject
    {
        public object updateMode;
        public object scrollDeltaBehavior;
        public object compensateForScreenOrientation;
        public object filterNoiseOnCurrent;
        public object defaultDeadzoneMin;
        public object defaultDeadzoneMax;
        public object defaultButtonPressPoint;
        public object buttonReleaseThreshold;
        public object defaultTapTime;
        public object defaultSlowTapTime;
        public object defaultHoldTime;
        public object tapRadius;
        public object multiTapDelayTime;
        public object backgroundBehavior;
        public object editorInputBehaviorInPlayMode;
        public object inputActionPropertyDrawerMode;
        public object maxEventBytesPerUpdate;
        public object maxQueuedEventsPerUpdate;
        public object supportedDevices;
        public object disableRedundantEventsMerging;
        public object shortcutKeysConsumeInput;

        // ── Methods ──
        public void get_updateMode(){} // RVA: 0x7FFD4E4FBBE0
        public void set_updateMode(){} // RVA: 0x7FFD54A3FAF0
        public void get_scrollDeltaBehavior(){} // RVA: 0x7FFD4ED41980
        public void set_scrollDeltaBehavior(){} // RVA: 0x7FFD54A3FB00
        public void get_compensateForScreenOrientation(){} // RVA: 0x7FFD4E367450
        public void set_compensateForScreenOrientation(){} // RVA: 0x7FFD54A3FB10
        public void get_filterNoiseOnCurrent(){} // RVA: 0x7FFD4E341320
        public void set_filterNoiseOnCurrent(){} // RVA: 0x7FFD4E341310
        public void get_defaultDeadzoneMin(){} // RVA: 0x7FFD4E5080B0
        public void set_defaultDeadzoneMin(){} // RVA: 0x7FFD54A3FB20
        public void get_defaultDeadzoneMax(){} // RVA: 0x7FFD4E349970
        public void set_defaultDeadzoneMax(){} // RVA: 0x7FFD54A3FB40
        public void get_defaultButtonPressPoint(){} // RVA: 0x7FFD4F9E0DE0
        public void set_defaultButtonPressPoint(){} // RVA: 0x7FFD54A3FB60
        public void get_buttonReleaseThreshold(){} // RVA: 0x7FFD4EB55280
        public void set_buttonReleaseThreshold(){} // RVA: 0x7FFD54A3FBA0
        public void get_defaultTapTime(){} // RVA: 0x7FFD4E3A9460
        public void set_defaultTapTime(){} // RVA: 0x7FFD54A3FBC0
        public void get_defaultSlowTapTime(){} // RVA: 0x7FFD4E7B1600
        public void set_defaultSlowTapTime(){} // RVA: 0x7FFD54A3FBE0
        public void get_defaultHoldTime(){} // RVA: 0x7FFD4E369FE0
        public void set_defaultHoldTime(){} // RVA: 0x7FFD54A3FC00
        public void get_tapRadius(){} // RVA: 0x7FFD4E36A000
        public void set_tapRadius(){} // RVA: 0x7FFD54A3FC20
        public void get_multiTapDelayTime(){} // RVA: 0x7FFD4E451E10
        public void set_multiTapDelayTime(){} // RVA: 0x7FFD54A3FC40
        public void get_backgroundBehavior(){} // RVA: 0x7FFD4EEFEDC0
        public void set_backgroundBehavior(){} // RVA: 0x7FFD54A3FC60
        public void get_editorInputBehaviorInPlayMode(){} // RVA: 0x7FFD4E9AA870
        public void set_editorInputBehaviorInPlayMode(){} // RVA: 0x7FFD54A3FC70
        public void get_inputActionPropertyDrawerMode(){} // RVA: 0x7FFD4E7DD4A0
        public void set_inputActionPropertyDrawerMode(){} // RVA: 0x7FFD54A3FC80
        public void get_maxEventBytesPerUpdate(){} // RVA: 0x7FFD4E70C4C0
        public void set_maxEventBytesPerUpdate(){} // RVA: 0x7FFD54A3FC90
        public void get_maxQueuedEventsPerUpdate(){} // RVA: 0x7FFD4F0A91D0
        public void set_maxQueuedEventsPerUpdate(){} // RVA: 0x7FFD54A3FCA0
        public void get_supportedDevices(){} // RVA: 0x7FFD54A3FCB0
        public void set_supportedDevices(){} // RVA: 0x7FFD54A3FD70
        public void get_disableRedundantEventsMerging(){} // RVA: 0x7FFD4F365FE0
        public void set_disableRedundantEventsMerging(){} // RVA: 0x7FFD54A3FF20
        public void get_shortcutKeysConsumeInput(){} // RVA: 0x7FFD542C0370
        public void set_shortcutKeysConsumeInput(){} // RVA: 0x7FFD54A3FF30
        public void SetInternalFeatureFlag(){} // RVA: 0x7FFD54A3FF40
        public void IsFeatureEnabled(){} // RVA: 0x7FFD54A40100
        public void OnChange(){} // RVA: 0x7FFD54A40180
        public void CompareFloats(){} // RVA: 0x7FFD54A40300
        public void CompareSets(){} // RVA: 0x7FFD4E2ADC40
        public void CompareFeatureFlag(){} // RVA: 0x7FFD54A40320
        public void AreEqual(){} // RVA: 0x7FFD54A40410
        public void .ctor(){} // RVA: 0x7FFD54A40B50
    }

    public class InputSystem : Object
    {
        public object devices;
        public object disconnectedDevices;
        public object pollingFrequency;
        public object isProcessingEvents;
        public object onEvent;
        public object onAnyButtonPress;
        public object settings;
        public object actions;
        public object remoting;
        public object version;
        public object runInBackground;
        public object metrics;

        // ── Methods ──
        public void add_onLayoutChange(){} // RVA: 0x7FFD5499B380
        public void remove_onLayoutChange(){} // RVA: 0x7FFD5499B570
        public void RegisterLayout(){} // RVA: 0x7FFD5499B900 | overloaded x3
        public void RegisterLayoutOverride(){} // RVA: 0x7FFD5499BA10
        public void RegisterLayoutMatcher(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void RegisterLayoutBuilder(){} // RVA: 0x7FFD5499BB20
        public void RegisterPrecompiledLayout(){} // RVA: 0x7FFD4E090A10
        public void RemoveLayout(){} // RVA: 0x7FFD5499BCF0
        public void TryFindMatchingLayout(){} // RVA: 0x7FFD5499BD60
        public void ListLayouts(){} // RVA: 0x7FFD5499BE30
        public void ListLayoutsBasedOn(){} // RVA: 0x7FFD5499BEA0
        public void LoadLayout(){} // RVA: 0x7FFD4E078A90 | overloaded x2
        public void GetNameOfBaseLayout(){} // RVA: 0x7FFD5499C070
        public void IsFirstLayoutBasedOnSecond(){} // RVA: 0x7FFD5499C270
        public void RegisterProcessor(){} // RVA: 0x7FFD4E090A10 | overloaded x2
        public void TryGetProcessor(){} // RVA: 0x7FFD5499C8C0
        public void ListProcessors(){} // RVA: 0x7FFD5499C9A0
        public void get_devices(){} // RVA: 0x7FFD5499CA20
        public void get_disconnectedDevices(){} // RVA: 0x7FFD5499CAA0
        public void add_onDeviceChange(){} // RVA: 0x7FFD5499CB90
        public void remove_onDeviceChange(){} // RVA: 0x7FFD5499CDE0
        public void add_onDeviceCommand(){} // RVA: 0x7FFD5499D030
        public void remove_onDeviceCommand(){} // RVA: 0x7FFD5499D280
        public void add_onFindLayoutForDevice(){} // RVA: 0x7FFD5499D4D0
        public void remove_onFindLayoutForDevice(){} // RVA: 0x7FFD5499D6D0
        public void get_pollingFrequency(){} // RVA: 0x7FFD5499D8C0
        public void set_pollingFrequency(){} // RVA: 0x7FFD5499D930
        public void AddDevice(){} // RVA: 0x7FFD5499DCC0 | overloaded x4
        public void RemoveDevice(){} // RVA: 0x7FFD5499DD80
        public void FlushDisconnectedDevices(){} // RVA: 0x7FFD5499DE00
        public void GetDevice(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void GetDeviceById(){} // RVA: 0x7FFD5499E1F0
        public void GetUnsupportedDevices(){} // RVA: 0x7FFD5499E2F0 | overloaded x2
        public void EnableDevice(){} // RVA: 0x7FFD5499E530
        public void DisableDevice(){} // RVA: 0x7FFD5499E5B0
        public void TrySyncDevice(){} // RVA: 0x7FFD5499E640
        public void ResetDevice(){} // RVA: 0x7FFD5499E710
        public void TryResetDevice(){} // RVA: 0x7FFD5499E7A0
        public void PauseHaptics(){} // RVA: 0x7FFD5499E810
        public void ResumeHaptics(){} // RVA: 0x7FFD5499E960
        public void ResetHaptics(){} // RVA: 0x7FFD5499EAB0
        public void SetDeviceUsage(){} // RVA: 0x7FFD5499ECF0 | overloaded x2
        public void AddDeviceUsage(){} // RVA: 0x7FFD5499EE40 | overloaded x2
        public void RemoveDeviceUsage(){} // RVA: 0x7FFD5499EF90 | overloaded x2
        public void FindControl(){} // RVA: 0x7FFD5499F020
        public void FindControls(){} // RVA: 0x7FFD4E07E730 | overloaded x3
        public void get_isProcessingEvents(){} // RVA: 0x7FFD5499F360
        public void get_onEvent(){} // RVA: 0x7FFD4E341320
        public void set_onEvent(){} // RVA: 0x7FFD4E341310
        public void get_onAnyButtonPress(){} // RVA: 0x7FFD5499F3D0
        public void QueueEvent(){} // RVA: 0x7FFD4E090A10 | overloaded x2
        public void QueueStateEvent(){} // RVA: 0x7FFD4E2ADC40
        public void QueueDeltaStateEvent(){} // RVA: 0x7FFD4E2ADC40
        public void QueueConfigChangeEvent(){} // RVA: 0x7FFD5499FAC0
        public void QueueTextEvent(){} // RVA: 0x7FFD5499FD00
        public void Update(){} // RVA: 0x7FFD549A0040 | overloaded x2
        public void add_onBeforeUpdate(){} // RVA: 0x7FFD549A01F0
        public void remove_onBeforeUpdate(){} // RVA: 0x7FFD549A03F0
        public void add_onAfterUpdate(){} // RVA: 0x7FFD549A05E0
        public void remove_onAfterUpdate(){} // RVA: 0x7FFD549A07D0
        public void get_settings(){} // RVA: 0x7FFD549A09C0
        public void set_settings(){} // RVA: 0x7FFD549A0A30
        public void add_onSettingsChange(){} // RVA: 0x7FFD549A0C70
        public void remove_onSettingsChange(){} // RVA: 0x7FFD549A0D20
        public void EnableActions(){} // RVA: 0x7FFD549A0DD0
        public void DisableActions(){} // RVA: 0x7FFD549A0EF0
        public void get_actions(){} // RVA: 0x7FFD549A1000
        public void set_actions(){} // RVA: 0x7FFD549A1070
        public void add_onActionsChange(){} // RVA: 0x7FFD549A12D0
        public void remove_onActionsChange(){} // RVA: 0x7FFD549A1380
        public void add_onActionChange(){} // RVA: 0x7FFD549A1430
        public void remove_onActionChange(){} // RVA: 0x7FFD549A1500
        public void RegisterInteraction(){} // RVA: 0x7FFD4E090A10 | overloaded x2
        public void TryGetInteraction(){} // RVA: 0x7FFD549A1760
        public void ListInteractions(){} // RVA: 0x7FFD549A1840
        public void RegisterBindingComposite(){} // RVA: 0x7FFD4E090A10 | overloaded x2
        public void TryGetBindingComposite(){} // RVA: 0x7FFD549A1A50
        public void DisableAllEnabledActions(){} // RVA: 0x7FFD549A1B30
        public void ListEnabledActions(){} // RVA: 0x7FFD549A1E20 | overloaded x2
        public void get_remoting(){} // RVA: 0x7FFD549A1EC0
        public void get_version(){} // RVA: 0x7FFD549A1F20
        public void get_runInBackground(){} // RVA: 0x7FFD549A2050
        public void set_runInBackground(){} // RVA: 0x7FFD549A20E0
        public void get_metrics(){} // RVA: 0x7FFD549A2180
        public void .cctor(){} // RVA: 0x7FFD549A2220
        public void RunInitializeInPlayer(){} // RVA: 0x7FFD549A22D0
        public void EnsureInitialized(){} // RVA: 0x7FFD4E341310
        public void InitializeInPlayer(){} // RVA: 0x7FFD549A2350
        public void RunInitialUpdate(){} // RVA: 0x7FFD549A26D0
        public void PerformDefaultPluginInitialization(){} // RVA: 0x7FFD549A27B0
    }

    public class InputValue : Object
    {
        public object isPressed;

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void get_isPressed(){} // RVA: 0x7FFD54A45E50
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class Joystick : InputDevice
    {
        public object trigger;
        public object stick;
        public object twist;
        public object hatswitch;
        public object current;
        public object all;

        // ── Methods ──
        public void get_trigger(){} // RVA: 0x7FFD4E960F60
        public void set_trigger(){} // RVA: 0x7FFD4EDCB1D0
        public void get_stick(){} // RVA: 0x7FFD4E961C80
        public void set_stick(){} // RVA: 0x7FFD4EDE8ED0
        public void get_twist(){} // RVA: 0x7FFD4E96E2E0
        public void set_twist(){} // RVA: 0x7FFD4EDC8AF0
        public void get_hatswitch(){} // RVA: 0x7FFD4E968F80
        public void set_hatswitch(){} // RVA: 0x7FFD4EDD4D10
        public void get_current(){} // RVA: 0x7FFD549B44F0
        public void set_current(){} // RVA: 0x7FFD549B4530
        public void get_all(){} // RVA: 0x7FFD549B45D0
        public void FinishSetup(){} // RVA: 0x7FFD549B4690
        public void MakeCurrent(){} // RVA: 0x7FFD549B4910
        public void OnAdded(){} // RVA: 0x7FFD549B4920
        public void OnRemoved(){} // RVA: 0x7FFD549B49A0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class Keyboard : InputDevice
    {
        public object keyboardLayout;
        public object anyKey;
        public object spaceKey;
        public object enterKey;
        public object tabKey;
        public object backquoteKey;
        public object quoteKey;
        public object semicolonKey;
        public object commaKey;
        public object periodKey;
        public object slashKey;
        public object backslashKey;
        public object leftBracketKey;
        public object rightBracketKey;
        public object minusKey;
        public object equalsKey;
        public object aKey;
        public object bKey;
        public object cKey;
        public object dKey;
        public object eKey;
        public object fKey;
        public object gKey;
        public object hKey;
        public object iKey;
        public object jKey;
        public object kKey;
        public object lKey;
        public object mKey;
        public object nKey;
        public object oKey;
        public object pKey;
        public object qKey;
        public object rKey;
        public object sKey;
        public object tKey;
        public object uKey;
        public object vKey;
        public object wKey;
        public object xKey;
        public object yKey;
        public object zKey;
        public object digit1Key;
        public object digit2Key;
        public object digit3Key;
        public object digit4Key;
        public object digit5Key;
        public object digit6Key;
        public object digit7Key;
        public object digit8Key;
        public object digit9Key;
        public object digit0Key;
        public object leftShiftKey;
        public object rightShiftKey;
        public object leftAltKey;
        public object rightAltKey;
        public object leftCtrlKey;
        public object rightCtrlKey;
        public object leftMetaKey;
        public object rightMetaKey;
        public object leftWindowsKey;
        public object rightWindowsKey;
        public object leftAppleKey;
        public object rightAppleKey;
        public object leftCommandKey;
        public object rightCommandKey;
        public object contextMenuKey;
        public object escapeKey;
        public object leftArrowKey;
        public object rightArrowKey;
        public object upArrowKey;
        public object downArrowKey;
        public object backspaceKey;
        public object pageDownKey;
        public object pageUpKey;
        public object homeKey;
        public object endKey;
        public object insertKey;
        public object deleteKey;
        public object capsLockKey;
        public object scrollLockKey;
        public object numLockKey;
        public object printScreenKey;
        public object pauseKey;
        public object numpadEnterKey;
        public object numpadDivideKey;
        public object numpadMultiplyKey;
        public object numpadMinusKey;
        public object numpadPlusKey;
        public object numpadPeriodKey;
        public object numpadEqualsKey;
        public object numpad0Key;
        public object numpad1Key;
        public object numpad2Key;
        public object numpad3Key;
        public object numpad4Key;
        public object numpad5Key;
        public object numpad6Key;
        public object numpad7Key;
        public object numpad8Key;
        public object numpad9Key;
        public object f1Key;
        public object f2Key;
        public object f3Key;
        public object f4Key;
        public object f5Key;
        public object f6Key;
        public object f7Key;
        public object f8Key;
        public object f9Key;
        public object f10Key;
        public object f11Key;
        public object f12Key;
        public object oem1Key;
        public object oem2Key;
        public object oem3Key;
        public object oem4Key;
        public object oem5Key;
        public object f13Key;
        public object f14Key;
        public object f15Key;
        public object f16Key;
        public object f17Key;
        public object f18Key;
        public object f19Key;
        public object f20Key;
        public object f21Key;
        public object f22Key;
        public object f23Key;
        public object f24Key;
        public object shiftKey;
        public object ctrlKey;
        public object altKey;
        public object imeSelected;
        public object Item;
        public object allKeys;
        public object current;
        public object keys;

        // ── Methods ──
        public void add_onTextInput(){} // RVA: 0x7FFD549B4B30
        public void remove_onTextInput(){} // RVA: 0x7FFD549B4C20
        public void add_onIMECompositionChange(){} // RVA: 0x7FFD549B4C80
        public void remove_onIMECompositionChange(){} // RVA: 0x7FFD549B4D70
        public void SetIMEEnabled(){} // RVA: 0x7FFD549B4DD0
        public void SetIMECursorPosition(){} // RVA: 0x7FFD549B4E50
        public void get_keyboardLayout(){} // RVA: 0x7FFD549B4EE0
        public void set_keyboardLayout(){} // RVA: 0x7FFD4EDC8050
        public void get_anyKey(){} // RVA: 0x7FFD4E960F60
        public void set_anyKey(){} // RVA: 0x7FFD4EDCB1D0
        public void get_spaceKey(){} // RVA: 0x7FFD549B4F30
        public void get_enterKey(){} // RVA: 0x7FFD549B4F40
        public void get_tabKey(){} // RVA: 0x7FFD549B4F50
        public void get_backquoteKey(){} // RVA: 0x7FFD549B4F60
        public void get_quoteKey(){} // RVA: 0x7FFD549B4F70
        public void get_semicolonKey(){} // RVA: 0x7FFD549B4F80
        public void get_commaKey(){} // RVA: 0x7FFD549B4F90
        public void get_periodKey(){} // RVA: 0x7FFD549B4FA0
        public void get_slashKey(){} // RVA: 0x7FFD549B4FB0
        public void get_backslashKey(){} // RVA: 0x7FFD549B4FC0
        public void get_leftBracketKey(){} // RVA: 0x7FFD549B4FD0
        public void get_rightBracketKey(){} // RVA: 0x7FFD549B4FE0
        public void get_minusKey(){} // RVA: 0x7FFD549B4FF0
        public void get_equalsKey(){} // RVA: 0x7FFD549B5000
        public void get_aKey(){} // RVA: 0x7FFD549B5010
        public void get_bKey(){} // RVA: 0x7FFD549B5020
        public void get_cKey(){} // RVA: 0x7FFD549B5030
        public void get_dKey(){} // RVA: 0x7FFD549B5040
        public void get_eKey(){} // RVA: 0x7FFD549B5050
        public void get_fKey(){} // RVA: 0x7FFD549B5060
        public void get_gKey(){} // RVA: 0x7FFD549B5070
        public void get_hKey(){} // RVA: 0x7FFD549B5080
        public void get_iKey(){} // RVA: 0x7FFD549B5090
        public void get_jKey(){} // RVA: 0x7FFD549B50A0
        public void get_kKey(){} // RVA: 0x7FFD549B50B0
        public void get_lKey(){} // RVA: 0x7FFD549B50C0
        public void get_mKey(){} // RVA: 0x7FFD549B50D0
        public void get_nKey(){} // RVA: 0x7FFD549B50E0
        public void get_oKey(){} // RVA: 0x7FFD549B50F0
        public void get_pKey(){} // RVA: 0x7FFD549B5100
        public void get_qKey(){} // RVA: 0x7FFD549B5110
        public void get_rKey(){} // RVA: 0x7FFD549B5120
        public void get_sKey(){} // RVA: 0x7FFD549B5130
        public void get_tKey(){} // RVA: 0x7FFD549B5140
        public void get_uKey(){} // RVA: 0x7FFD549B5150
        public void get_vKey(){} // RVA: 0x7FFD549B5160
        public void get_wKey(){} // RVA: 0x7FFD549B5170
        public void get_xKey(){} // RVA: 0x7FFD549B5180
        public void get_yKey(){} // RVA: 0x7FFD549B5190
        public void get_zKey(){} // RVA: 0x7FFD549B51A0
        public void get_digit1Key(){} // RVA: 0x7FFD549B51B0
        public void get_digit2Key(){} // RVA: 0x7FFD549B51C0
        public void get_digit3Key(){} // RVA: 0x7FFD549B51D0
        public void get_digit4Key(){} // RVA: 0x7FFD549B51E0
        public void get_digit5Key(){} // RVA: 0x7FFD549B51F0
        public void get_digit6Key(){} // RVA: 0x7FFD549B5200
        public void get_digit7Key(){} // RVA: 0x7FFD549B5210
        public void get_digit8Key(){} // RVA: 0x7FFD549B5220
        public void get_digit9Key(){} // RVA: 0x7FFD549B5230
        public void get_digit0Key(){} // RVA: 0x7FFD549B5240
        public void get_leftShiftKey(){} // RVA: 0x7FFD549B5250
        public void get_rightShiftKey(){} // RVA: 0x7FFD549B5260
        public void get_leftAltKey(){} // RVA: 0x7FFD549B5270
        public void get_rightAltKey(){} // RVA: 0x7FFD549B5280
        public void get_leftCtrlKey(){} // RVA: 0x7FFD549B5290
        public void get_rightCtrlKey(){} // RVA: 0x7FFD549B52A0
        public void get_leftMetaKey(){} // RVA: 0x7FFD549B52B0
        public void get_rightMetaKey(){} // RVA: 0x7FFD549B52C0
        public void get_leftWindowsKey(){} // RVA: 0x7FFD549B52B0
        public void get_rightWindowsKey(){} // RVA: 0x7FFD549B52C0
        public void get_leftAppleKey(){} // RVA: 0x7FFD549B52B0
        public void get_rightAppleKey(){} // RVA: 0x7FFD549B52C0
        public void get_leftCommandKey(){} // RVA: 0x7FFD549B52B0
        public void get_rightCommandKey(){} // RVA: 0x7FFD549B52C0
        public void get_contextMenuKey(){} // RVA: 0x7FFD549B52D0
        public void get_escapeKey(){} // RVA: 0x7FFD549B52E0
        public void get_leftArrowKey(){} // RVA: 0x7FFD549B52F0
        public void get_rightArrowKey(){} // RVA: 0x7FFD549B5300
        public void get_upArrowKey(){} // RVA: 0x7FFD549B5310
        public void get_downArrowKey(){} // RVA: 0x7FFD549B5320
        public void get_backspaceKey(){} // RVA: 0x7FFD549B5330
        public void get_pageDownKey(){} // RVA: 0x7FFD549B5340
        public void get_pageUpKey(){} // RVA: 0x7FFD549B5350
        public void get_homeKey(){} // RVA: 0x7FFD549B5360
        public void get_endKey(){} // RVA: 0x7FFD549B5370
        public void get_insertKey(){} // RVA: 0x7FFD549B5380
        public void get_deleteKey(){} // RVA: 0x7FFD549B5390
        public void get_capsLockKey(){} // RVA: 0x7FFD549B53A0
        public void get_scrollLockKey(){} // RVA: 0x7FFD549B53B0
        public void get_numLockKey(){} // RVA: 0x7FFD549B53C0
        public void get_printScreenKey(){} // RVA: 0x7FFD549B53D0
        public void get_pauseKey(){} // RVA: 0x7FFD549B53E0
        public void get_numpadEnterKey(){} // RVA: 0x7FFD549B53F0
        public void get_numpadDivideKey(){} // RVA: 0x7FFD549B5400
        public void get_numpadMultiplyKey(){} // RVA: 0x7FFD549B5410
        public void get_numpadMinusKey(){} // RVA: 0x7FFD549B5420
        public void get_numpadPlusKey(){} // RVA: 0x7FFD549B5430
        public void get_numpadPeriodKey(){} // RVA: 0x7FFD549B5440
        public void get_numpadEqualsKey(){} // RVA: 0x7FFD549B5450
        public void get_numpad0Key(){} // RVA: 0x7FFD549B5460
        public void get_numpad1Key(){} // RVA: 0x7FFD549B5470
        public void get_numpad2Key(){} // RVA: 0x7FFD549B5480
        public void get_numpad3Key(){} // RVA: 0x7FFD549B5490
        public void get_numpad4Key(){} // RVA: 0x7FFD549B54A0
        public void get_numpad5Key(){} // RVA: 0x7FFD549B54B0
        public void get_numpad6Key(){} // RVA: 0x7FFD549B54C0
        public void get_numpad7Key(){} // RVA: 0x7FFD549B54D0
        public void get_numpad8Key(){} // RVA: 0x7FFD549B54E0
        public void get_numpad9Key(){} // RVA: 0x7FFD549B54F0
        public void get_f1Key(){} // RVA: 0x7FFD549B5500
        public void get_f2Key(){} // RVA: 0x7FFD549B5510
        public void get_f3Key(){} // RVA: 0x7FFD549B5520
        public void get_f4Key(){} // RVA: 0x7FFD549B5530
        public void get_f5Key(){} // RVA: 0x7FFD549B5540
        public void get_f6Key(){} // RVA: 0x7FFD549B5550
        public void get_f7Key(){} // RVA: 0x7FFD549B5560
        public void get_f8Key(){} // RVA: 0x7FFD549B5570
        public void get_f9Key(){} // RVA: 0x7FFD549B5580
        public void get_f10Key(){} // RVA: 0x7FFD549B5590
        public void get_f11Key(){} // RVA: 0x7FFD549B55A0
        public void get_f12Key(){} // RVA: 0x7FFD549B55B0
        public void get_oem1Key(){} // RVA: 0x7FFD549B55C0
        public void get_oem2Key(){} // RVA: 0x7FFD549B55D0
        public void get_oem3Key(){} // RVA: 0x7FFD549B55E0
        public void get_oem4Key(){} // RVA: 0x7FFD549B55F0
        public void get_oem5Key(){} // RVA: 0x7FFD549B5600
        public void get_f13Key(){} // RVA: 0x7FFD549B5610
        public void get_f14Key(){} // RVA: 0x7FFD549B5620
        public void get_f15Key(){} // RVA: 0x7FFD549B5630
        public void get_f16Key(){} // RVA: 0x7FFD549B5640
        public void get_f17Key(){} // RVA: 0x7FFD549B5650
        public void get_f18Key(){} // RVA: 0x7FFD549B5660
        public void get_f19Key(){} // RVA: 0x7FFD549B5670
        public void get_f20Key(){} // RVA: 0x7FFD549B5680
        public void get_f21Key(){} // RVA: 0x7FFD549B5690
        public void get_f22Key(){} // RVA: 0x7FFD549B56A0
        public void get_f23Key(){} // RVA: 0x7FFD549B56B0
        public void get_f24Key(){} // RVA: 0x7FFD549B56C0
        public void get_shiftKey(){} // RVA: 0x7FFD4E961C80
        public void set_shiftKey(){} // RVA: 0x7FFD4EDE8ED0
        public void get_ctrlKey(){} // RVA: 0x7FFD4E96E2E0
        public void set_ctrlKey(){} // RVA: 0x7FFD4EDC8AF0
        public void get_altKey(){} // RVA: 0x7FFD4E968F80
        public void set_altKey(){} // RVA: 0x7FFD4EDD4D10
        public void get_imeSelected(){} // RVA: 0x7FFD4E969F30
        public void set_imeSelected(){} // RVA: 0x7FFD4EDC7790
        public void get_Item(){} // RVA: 0x7FFD549B56D0
        public void get_allKeys(){} // RVA: 0x7FFD549B5770
        public void get_current(){} // RVA: 0x7FFD549B5840
        public void set_current(){} // RVA: 0x7FFD549B5880
        public void MakeCurrent(){} // RVA: 0x7FFD549B5920
        public void OnRemoved(){} // RVA: 0x7FFD549B5930
        public void FinishSetup(){} // RVA: 0x7FFD549B5980
        public void RefreshConfiguration(){} // RVA: 0x7FFD549B6FB0
        public void OnTextInput(){} // RVA: 0x7FFD549B7180
        public void FindKeyOnCurrentKeyboardLayout(){} // RVA: 0x7FFD549B7210
        public void OnIMECompositionChanged(){} // RVA: 0x7FFD549B7420
        public void UnityEngine.InputSystem.LowLevel.IEventPreProcessor.PreProcessEvent(){} // RVA: 0x7FFD549B7530
        public void get_keys(){} // RVA: 0x7FFD4EDE0A30
        public void set_keys(){} // RVA: 0x7FFD4EDEF5C0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class LightSensor : Sensor
    {
        public object lightLevel;
        public object current;

        // ── Methods ──
        public void get_lightLevel(){} // RVA: 0x7FFD4E960F60
        public void set_lightLevel(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A26DC0
        public void set_current(){} // RVA: 0x7FFD54A26E00
        public void MakeCurrent(){} // RVA: 0x7FFD54A26EA0
        public void OnRemoved(){} // RVA: 0x7FFD54A26EB0
        public void FinishSetup(){} // RVA: 0x7FFD54A26F00
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class LinearAccelerationSensor : Sensor
    {
        public object acceleration;
        public object current;

        // ── Methods ──
        public void get_acceleration(){} // RVA: 0x7FFD4E960F60
        public void set_acceleration(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A269E0
        public void set_current(){} // RVA: 0x7FFD54A26A20
        public void MakeCurrent(){} // RVA: 0x7FFD54A26AC0
        public void OnRemoved(){} // RVA: 0x7FFD54A26AD0
        public void FinishSetup(){} // RVA: 0x7FFD54A26B20
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class MagneticFieldSensor : Sensor
    {
        public object magneticField;
        public object current;

        // ── Methods ──
        public void get_magneticField(){} // RVA: 0x7FFD4E960F60
        public void set_magneticField(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A26BD0
        public void set_current(){} // RVA: 0x7FFD54A26C10
        public void MakeCurrent(){} // RVA: 0x7FFD54A26CB0
        public void OnRemoved(){} // RVA: 0x7FFD54A26CC0
        public void FinishSetup(){} // RVA: 0x7FFD54A26D10
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class Mouse : Pointer
    {
        public object scroll;
        public object leftButton;
        public object middleButton;
        public object rightButton;
        public object backButton;
        public object forwardButton;
        public object clickCount;
        public object current;

        // ── Methods ──
        public void get_scroll(){} // RVA: 0x7FFD4E9622B0
        public void set_scroll(){} // RVA: 0x7FFD4EDCD110
        public void get_leftButton(){} // RVA: 0x7FFD4EDECB10
        public void set_leftButton(){} // RVA: 0x7FFD4EDEF3F0
        public void get_middleButton(){} // RVA: 0x7FFD4EDE1920
        public void set_middleButton(){} // RVA: 0x7FFD4EDC8050
        public void get_rightButton(){} // RVA: 0x7FFD4EDE0A30
        public void set_rightButton(){} // RVA: 0x7FFD4EDEF5C0
        public void get_backButton(){} // RVA: 0x7FFD4E818150
        public void set_backButton(){} // RVA: 0x7FFD4EDD1270
        public void get_forwardButton(){} // RVA: 0x7FFD4EDD1060
        public void set_forwardButton(){} // RVA: 0x7FFD4EDCC5A0
        public void get_clickCount(){} // RVA: 0x7FFD4E964EF0
        public void set_clickCount(){} // RVA: 0x7FFD4E961400
        public void get_current(){} // RVA: 0x7FFD549B7570
        public void set_current(){} // RVA: 0x7FFD549B75B0
        public void MakeCurrent(){} // RVA: 0x7FFD549B7650
        public void OnAdded(){} // RVA: 0x7FFD549B7670
        public void OnRemoved(){} // RVA: 0x7FFD549B7720
        public void WarpCursorPosition(){} // RVA: 0x7FFD549B77B0
        public void FinishSetup(){} // RVA: 0x7FFD549B7840
        public void OnNextUpdate(){} // RVA: 0x7FFD549B7CB0
        public void OnStateEvent(){} // RVA: 0x7FFD549B7D80
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFD549B7CB0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFD549B7E30
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class Pen : Pointer
    {
        public object tip;
        public object eraser;
        public object firstBarrelButton;
        public object secondBarrelButton;
        public object thirdBarrelButton;
        public object fourthBarrelButton;
        public object inRange;
        public object tilt;
        public object twist;
        public object current;
        public object Item;

        // ── Methods ──
        public void get_tip(){} // RVA: 0x7FFD4E9622B0
        public void set_tip(){} // RVA: 0x7FFD4EDCD110
        public void get_eraser(){} // RVA: 0x7FFD4EDECB10
        public void set_eraser(){} // RVA: 0x7FFD4EDEF3F0
        public void get_firstBarrelButton(){} // RVA: 0x7FFD4EDE1920
        public void set_firstBarrelButton(){} // RVA: 0x7FFD4EDC8050
        public void get_secondBarrelButton(){} // RVA: 0x7FFD4EDE0A30
        public void set_secondBarrelButton(){} // RVA: 0x7FFD4EDEF5C0
        public void get_thirdBarrelButton(){} // RVA: 0x7FFD4E818150
        public void set_thirdBarrelButton(){} // RVA: 0x7FFD4EDD1270
        public void get_fourthBarrelButton(){} // RVA: 0x7FFD4EDD1060
        public void set_fourthBarrelButton(){} // RVA: 0x7FFD4EDCC5A0
        public void get_inRange(){} // RVA: 0x7FFD4E964EF0
        public void set_inRange(){} // RVA: 0x7FFD4E961400
        public void get_tilt(){} // RVA: 0x7FFD4E961460
        public void set_tilt(){} // RVA: 0x7FFD4E964450
        public void get_twist(){} // RVA: 0x7FFD4E964790
        public void set_twist(){} // RVA: 0x7FFD4E96D230
        public void get_current(){} // RVA: 0x7FFD549B7E40
        public void set_current(){} // RVA: 0x7FFD549B7E80
        public void get_Item(){} // RVA: 0x7FFD549B7F20
        public void MakeCurrent(){} // RVA: 0x7FFD549B8060
        public void OnRemoved(){} // RVA: 0x7FFD549B8080
        public void FinishSetup(){} // RVA: 0x7FFD549B8110
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class PlayerInput : MonoBehaviour
    {
        public object inputIsActive;
        public object active;
        public object playerIndex;
        public object splitScreenIndex;
        public object actions;
        public object currentControlScheme;
        public object defaultControlScheme;
        public object neverAutoSwitchControlSchemes;
        public object currentActionMap;
        public object defaultActionMap;
        public object notificationBehavior;
        public object actionEvents;
        public object deviceLostEvent;
        public object deviceRegainedEvent;
        public object controlsChangedEvent;
        public object camera;
        public object uiInputModule;
        public object user;
        public object devices;
        public object hasMissingRequiredDevices;
        public object all;
        public object isSinglePlayer;

        // ── Methods ──
        public void get_inputIsActive(){} // RVA: 0x7FFD53F30330
        public void get_active(){} // RVA: 0x7FFD53F30330
        public void get_playerIndex(){} // RVA: 0x7FFD4FCBE530
        public void get_splitScreenIndex(){} // RVA: 0x7FFD4F9B6EF0
        public void get_actions(){} // RVA: 0x7FFD54A45F50
        public void set_actions(){} // RVA: 0x7FFD54A46020
        public void get_currentControlScheme(){} // RVA: 0x7FFD54A46370
        public void get_defaultControlScheme(){} // RVA: 0x7FFD4E3BCD50
        public void set_defaultControlScheme(){} // RVA: 0x7FFD4E3BCD60
        public void get_neverAutoSwitchControlSchemes(){} // RVA: 0x7FFD4E36A020
        public void set_neverAutoSwitchControlSchemes(){} // RVA: 0x7FFD54A46440
        public void get_currentActionMap(){} // RVA: 0x7FFD4E70F640
        public void set_currentActionMap(){} // RVA: 0x7FFD54A46480
        public void get_defaultActionMap(){} // RVA: 0x7FFD4E409590
        public void set_defaultActionMap(){} // RVA: 0x7FFD4E4095A0
        public void get_notificationBehavior(){} // RVA: 0x7FFD4E39CCD0
        public void set_notificationBehavior(){} // RVA: 0x7FFD54A46720
        public void get_actionEvents(){} // RVA: 0x7FFD54A46770
        public void set_actionEvents(){} // RVA: 0x7FFD54A46840
        public void get_deviceLostEvent(){} // RVA: 0x7FFD54A46900
        public void get_deviceRegainedEvent(){} // RVA: 0x7FFD54A469D0
        public void get_controlsChangedEvent(){} // RVA: 0x7FFD54A46AA0
        public void add_onActionTriggered(){} // RVA: 0x7FFD54A46B70
        public void remove_onActionTriggered(){} // RVA: 0x7FFD54A46C10
        public void add_onDeviceLost(){} // RVA: 0x7FFD54A46CB0
        public void remove_onDeviceLost(){} // RVA: 0x7FFD54A46D50
        public void add_onDeviceRegained(){} // RVA: 0x7FFD54A46DF0
        public void remove_onDeviceRegained(){} // RVA: 0x7FFD54A46E90
        public void add_onControlsChanged(){} // RVA: 0x7FFD54A46F30
        public void remove_onControlsChanged(){} // RVA: 0x7FFD54A46FD0
        public void get_camera(){} // RVA: 0x7FFD4E70F410
        public void set_camera(){} // RVA: 0x7FFD4E8F4AA0
        public void get_uiInputModule(){} // RVA: 0x7FFD4E5F0140
        public void set_uiInputModule(){} // RVA: 0x7FFD54A47070
        public void get_user(){} // RVA: 0x7FFD4ED255C0
        public void get_devices(){} // RVA: 0x7FFD54A474D0
        public void get_hasMissingRequiredDevices(){} // RVA: 0x7FFD54A47580
        public void get_all(){} // RVA: 0x7FFD54A47680
        public void get_isSinglePlayer(){} // RVA: 0x7FFD54A47760
        public void GetDevice(){} // RVA: 0x7FFD4E2ADC40
        public void ActivateInput(){} // RVA: 0x7FFD54A478F0
        public void UpdateDelegates(){} // RVA: 0x7FFD54A47A20
        public void DeactivateInput(){} // RVA: 0x7FFD54A47CF0
        public void PassivateInput(){} // RVA: 0x7FFD54A47CF0
        public void SwitchCurrentControlScheme(){} // RVA: 0x7FFD54A47F80 | overloaded x2
        public void SwitchCurrentActionMap(){} // RVA: 0x7FFD54A480D0
        public void GetPlayerByIndex(){} // RVA: 0x7FFD54A482B0
        public void FindFirstPairedToDevice(){} // RVA: 0x7FFD54A483B0
        public void Instantiate(){} // RVA: 0x7FFD54A48850 | overloaded x2
        public void DoInstantiate(){} // RVA: 0x7FFD54A48AF0
        public void InitializeActions(){} // RVA: 0x7FFD54A49050
        public void CopyActionAssetAndApplyBindingOverrides(){} // RVA: 0x7FFD54A49600
        public void UninitializeActions(){} // RVA: 0x7FFD54A49980
        public void InstallOnActionTriggeredHook(){} // RVA: 0x7FFD54A49C40
        public void UninstallOnActionTriggeredHook(){} // RVA: 0x7FFD54A49F10
        public void OnActionTriggered(){} // RVA: 0x7FFD54A4A130
        public void CacheMessageNames(){} // RVA: 0x7FFD54A4A430
        public void ClearCaches(){} // RVA: 0x7FFD54A4A960
        public void AssignUserAndDevices(){} // RVA: 0x7FFD54A4A9C0
        public void HaveBindingForDevice(){} // RVA: 0x7FFD54A4B740
        public void UnassignUserAndDevices(){} // RVA: 0x7FFD54A4B8D0
        public void TryToActivateControlScheme(){} // RVA: 0x7FFD54A4BA70
        public void AssignPlayerIndex(){} // RVA: 0x7FFD54A4BEA0
        public void Awake(){} // RVA: 0x7FFD54A4C140
        public void OnEnable(){} // RVA: 0x7FFD54A4C220
        public void StartListeningForUnpairedDeviceActivity(){} // RVA: 0x7FFD54A4C9E0
        public void StopListeningForUnpairedDeviceActivity(){} // RVA: 0x7FFD54A4CCC0
        public void StartListeningForDeviceChanges(){} // RVA: 0x7FFD54A4CE50
        public void StopListeningForDeviceChanges(){} // RVA: 0x7FFD54A4CF70
        public void OnDisable(){} // RVA: 0x7FFD54A4CFE0
        public void DebugLogAction(){} // RVA: 0x7FFD54A4D530
        public void HandleDeviceLost(){} // RVA: 0x7FFD54A4D590
        public void HandleDeviceRegained(){} // RVA: 0x7FFD54A4D6B0
        public void HandleControlsChanged(){} // RVA: 0x7FFD54A4D7D0
        public void OnUserChange(){} // RVA: 0x7FFD54A4D8F0
        public void OnPreFilterUnpairedDeviceUsed(){} // RVA: 0x7FFD54A4DAE0
        public void OnUnpairedDeviceUsed(){} // RVA: 0x7FFD54A4DE80
        public void OnDeviceChange(){} // RVA: 0x7FFD54A4E790
        public void SwitchControlSchemeInternal(){} // RVA: 0x7FFD54A4E960
        public void .ctor(){} // RVA: 0x7FFD54A4EF00
        public void .cctor(){} // RVA: 0x7FFD54A4EF60
    }

    public class PlayerInputManager : MonoBehaviour
    {
        public object splitScreen;
        public object maintainAspectRatioInSplitScreen;
        public object fixedNumberOfSplitScreens;
        public object splitScreenArea;
        public object playerCount;
        public object maxPlayerCount;
        public object joiningEnabled;
        public object joinBehavior;
        public object joinAction;
        public object notificationBehavior;
        public object playerJoinedEvent;
        public object playerLeftEvent;
        public object playerPrefab;
        public object instance;
        public object messages;

        // ── Methods ──
        public void get_splitScreen(){} // RVA: 0x7FFD4E36A020
        public void set_splitScreen(){} // RVA: 0x7FFD54A4F5E0
        public void get_maintainAspectRatioInSplitScreen(){} // RVA: 0x7FFD4F031000
        public void get_fixedNumberOfSplitScreens(){} // RVA: 0x7FFD4E558CA0
        public void get_splitScreenArea(){} // RVA: 0x7FFD513F87B0
        public void get_playerCount(){} // RVA: 0x7FFD54A4F920
        public void get_maxPlayerCount(){} // RVA: 0x7FFD4ED41980
        public void get_joiningEnabled(){} // RVA: 0x7FFD4E516BA0
        public void get_joinBehavior(){} // RVA: 0x7FFD4F0A91D0
        public void set_joinBehavior(){} // RVA: 0x7FFD54A4F980
        public void get_joinAction(){} // RVA: 0x7FFD4E34AE10
        public void set_joinAction(){} // RVA: 0x7FFD54A4F9D0
        public void get_notificationBehavior(){} // RVA: 0x7FFD4E4FBBE0
        public void set_notificationBehavior(){} // RVA: 0x7FFD4E9FB7A0
        public void get_playerJoinedEvent(){} // RVA: 0x7FFD54A4FAC0
        public void get_playerLeftEvent(){} // RVA: 0x7FFD54A4FB90
        public void add_onPlayerJoined(){} // RVA: 0x7FFD54A4FC60
        public void remove_onPlayerJoined(){} // RVA: 0x7FFD54A4FD00
        public void add_onPlayerLeft(){} // RVA: 0x7FFD54A4FDA0
        public void remove_onPlayerLeft(){} // RVA: 0x7FFD54A4FE40
        public void get_playerPrefab(){} // RVA: 0x7FFD4E409500
        public void set_playerPrefab(){} // RVA: 0x7FFD4E409510
        public void get_instance(){} // RVA: 0x7FFD54A4FEE0
        public void set_instance(){} // RVA: 0x7FFD54A4FF20
        public void EnableJoining(){} // RVA: 0x7FFD54A4FFC0
        public void DisableJoining(){} // RVA: 0x7FFD54A501E0
        public void JoinPlayerFromUI(){} // RVA: 0x7FFD54A502E0
        public void JoinPlayerFromAction(){} // RVA: 0x7FFD54A50340
        public void JoinPlayerFromActionIfNotAlreadyJoined(){} // RVA: 0x7FFD54A503B0
        public void JoinPlayer(){} // RVA: 0x7FFD54A505D0 | overloaded x2
        public void get_messages(){} // RVA: 0x7FFD54A50690
        public void CheckIfPlayerCanJoin(){} // RVA: 0x7FFD54A50730
        public void OnUnpairedDeviceUsed(){} // RVA: 0x7FFD54A50AB0
        public void OnEnable(){} // RVA: 0x7FFD54A50B60
        public void OnDisable(){} // RVA: 0x7FFD54A51110
        public void UpdateSplitScreen(){} // RVA: 0x7FFD54A51270
        public void IsDeviceUsableWithPlayerActions(){} // RVA: 0x7FFD54A519B0
        public void ValidateInputActionAsset(){} // RVA: 0x7FFD4E341310
        public void NotifyPlayerJoined(){} // RVA: 0x7FFD54A51F50
        public void NotifyPlayerLeft(){} // RVA: 0x7FFD54A52090
        public void .ctor(){} // RVA: 0x7FFD54A521D0
    }

    public class Pointer : InputDevice
    {
        public object position;
        public object delta;
        public object radius;
        public object pressure;
        public object press;
        public object displayIndex;
        public object current;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFD4E960F60
        public void set_position(){} // RVA: 0x7FFD4EDCB1D0
        public void get_delta(){} // RVA: 0x7FFD4E961C80
        public void set_delta(){} // RVA: 0x7FFD4EDE8ED0
        public void get_radius(){} // RVA: 0x7FFD4E96E2E0
        public void set_radius(){} // RVA: 0x7FFD4EDC8AF0
        public void get_pressure(){} // RVA: 0x7FFD4E968F80
        public void set_pressure(){} // RVA: 0x7FFD4EDD4D10
        public void get_press(){} // RVA: 0x7FFD4E969F30
        public void set_press(){} // RVA: 0x7FFD4EDC7790
        public void get_displayIndex(){} // RVA: 0x7FFD4E964330
        public void set_displayIndex(){} // RVA: 0x7FFD4EDCC050
        public void get_current(){} // RVA: 0x7FFD549B86A0
        public void set_current(){} // RVA: 0x7FFD549B86E0
        public void MakeCurrent(){} // RVA: 0x7FFD549B8780
        public void OnRemoved(){} // RVA: 0x7FFD549B8790
        public void FinishSetup(){} // RVA: 0x7FFD549B87E0
        public void OnNextUpdate(){} // RVA: 0x7FFD549B8B70
        public void OnStateEvent(){} // RVA: 0x7FFD549B8C30
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFD549B8CE0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFD549B8CF0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x7FFD4E341320
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class PressureSensor : Sensor
    {
        public object atmosphericPressure;
        public object current;

        // ── Methods ──
        public void get_atmosphericPressure(){} // RVA: 0x7FFD4E960F60
        public void set_atmosphericPressure(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A26FB0
        public void set_current(){} // RVA: 0x7FFD54A26FF0
        public void MakeCurrent(){} // RVA: 0x7FFD54A27090
        public void OnRemoved(){} // RVA: 0x7FFD54A270A0
        public void FinishSetup(){} // RVA: 0x7FFD54A270F0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class RemoteInputPlayerConnection : ScriptableObject
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFD54A24A20
        public void Subscribe(){} // RVA: 0x7FFD54A24F40
        public void OnConnected(){} // RVA: 0x7FFD54A251E0
        public void OnDisconnected(){} // RVA: 0x7FFD54A25290
        public void OnNewDevice(){} // RVA: 0x7FFD54A25430
        public void OnNewLayout(){} // RVA: 0x7FFD54A25440
        public void OnNewEvents(){} // RVA: 0x7FFD54A25450
        public void OnRemoveDevice(){} // RVA: 0x7FFD54A25460
        public void OnChangeUsages(){} // RVA: 0x7FFD54A25470
        public void OnStartSending(){} // RVA: 0x7FFD54A25480
        public void OnStopSending(){} // RVA: 0x7FFD54A25490
        public void SendToSubscribers(){} // RVA: 0x7FFD54A254A0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnNext(){} // RVA: 0x7FFD54A256A0
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnError(){} // RVA: 0x7FFD4E341310
        public void System.IObserver<UnityEngine.InputSystem.InputRemoting.Message>.OnCompleted(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
        public void .cctor(){} // RVA: 0x7FFD54A25860
    }

    public class Sensor : InputDevice
    {
        public object samplingFrequency;

        // ── Methods ──
        public void get_samplingFrequency(){} // RVA: 0x7FFD54A260C0
        public void set_samplingFrequency(){} // RVA: 0x7FFD54A261A0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class StepCounter : Sensor
    {
        public object stepCounter;
        public object current;

        // ── Methods ──
        public void get_stepCounter(){} // RVA: 0x7FFD4E960F60
        public void set_stepCounter(){} // RVA: 0x7FFD4EDCB1D0
        public void get_current(){} // RVA: 0x7FFD54A27770
        public void set_current(){} // RVA: 0x7FFD54A277B0
        public void MakeCurrent(){} // RVA: 0x7FFD54A27850
        public void OnRemoved(){} // RVA: 0x7FFD54A27860
        public void FinishSetup(){} // RVA: 0x7FFD54A278B0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class Touchscreen : Pointer
    {
        public object primaryTouch;
        public object touches;
        public object touchControlArray;
        public object current;

        // ── Methods ──
        public void get_primaryTouch(){} // RVA: 0x7FFD4E9622B0
        public void set_primaryTouch(){} // RVA: 0x7FFD4EDCD110
        public void get_touches(){} // RVA: 0x7FFD54A27B50
        public void set_touches(){} // RVA: 0x7FFD54A27B60
        public void get_touchControlArray(){} // RVA: 0x7FFD4EDECB10
        public void set_touchControlArray(){} // RVA: 0x7FFD54A27BC0
        public void get_current(){} // RVA: 0x7FFD54A27CE0
        public void set_current(){} // RVA: 0x7FFD54A27D40
        public void MakeCurrent(){} // RVA: 0x7FFD54A27E00
        public void OnRemoved(){} // RVA: 0x7FFD54A27E60
        public void FinishSetup(){} // RVA: 0x7FFD54A27F50
        public void OnNextUpdate(){} // RVA: 0x7FFD54A285E0
        public void OnStateEvent(){} // RVA: 0x7FFD54A28A90
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate(){} // RVA: 0x7FFD54A292E0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(){} // RVA: 0x7FFD54A292F0
        public void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(){} // RVA: 0x7FFD54A29300
        public void UnityEngine.InputSystem.LowLevel.ICustomDeviceReset.Reset(){} // RVA: 0x7FFD54A296B0
        public void MergeForward(){} // RVA: 0x7FFD54A29BC0
        public void UnityEngine.InputSystem.LowLevel.IEventMerger.MergeForward(){} // RVA: 0x7FFD54A29C50
        public void TriggerTap(){} // RVA: 0x7FFD54A29D30
        public void .ctor(){} // RVA: 0x7FFD54936440
        public void .cctor(){} // RVA: 0x7FFD54A29DD0
    }

    public class TrackedDevice : InputDevice
    {
        public object trackingState;
        public object isTracked;
        public object devicePosition;
        public object deviceRotation;

        // ── Methods ──
        public void get_trackingState(){} // RVA: 0x7FFD4E960F60
        public void set_trackingState(){} // RVA: 0x7FFD4EDCB1D0
        public void get_isTracked(){} // RVA: 0x7FFD4E961C80
        public void set_isTracked(){} // RVA: 0x7FFD4EDE8ED0
        public void get_devicePosition(){} // RVA: 0x7FFD4E96E2E0
        public void set_devicePosition(){} // RVA: 0x7FFD4EDC8AF0
        public void get_deviceRotation(){} // RVA: 0x7FFD4E968F80
        public void set_deviceRotation(){} // RVA: 0x7FFD4EDD4D10
        public void FinishSetup(){} // RVA: 0x7FFD54A29EF0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

}