// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.Experimental
// Classes: 11
// Methods: 133

namespace ThirdParty.Unity.UnityEngine.UIElements.Experimental
{
    public class Easing : Object
    {
        // ── Methods ──
        public void Linear(){} // RVA: 0x7FFE81D95990
        public void InSine(){} // RVA: 0x7FFE87ECF050
        public void OutSine(){} // RVA: 0x7FFE87ECF080
        public void InOutSine(){} // RVA: 0x7FFE87ECF090
        public void InQuad(){} // RVA: 0x7FFE87ECF0C0
        public void OutQuad(){} // RVA: 0x7FFE87ECF0D0
        public void InOutQuad(){} // RVA: 0x7FFE87ECF0F0
        public void InCubic(){} // RVA: 0x7FFE87ECF140
        public void OutCubic(){} // RVA: 0x7FFE87ECF150
        public void InOutCubic(){} // RVA: 0x7FFE87ECF180
        public void InPower(){} // RVA: 0x7FFE87ECF1E0
        public void OutPower(){} // RVA: 0x7FFE87ECF1F0
        public void InOutPower(){} // RVA: 0x7FFE87ECF240
        public void InBounce(){} // RVA: 0x7FFE87ECF2C0
        public void OutBounce(){} // RVA: 0x7FFE87ECF390
        public void InOutBounce(){} // RVA: 0x7FFE87ECF430
        public void InElastic(){} // RVA: 0x7FFE87ECF550
        public void OutElastic(){} // RVA: 0x7FFE87ECF5E0
        public void InOutElastic(){} // RVA: 0x7FFE87ECF680
        public void InBack(){} // RVA: 0x7FFE82268A80
        public void OutBack(){} // RVA: 0x7FFE87ECF7C0
        public void InOutBack(){} // RVA: 0x7FFE87ECF800
        public void InCirc(){} // RVA: 0x7FFE87ECF880
        public void OutCirc(){} // RVA: 0x7FFE87ECF8E0
        public void InOutCirc(){} // RVA: 0x7FFE87ECF910
    }

    public class ITransitionAnimations
    {
        // ── Methods ──
        public void Start(){}
    }

    public class IValueAnimationUpdate
    {
        // ── Methods ──
        public void Tick(){} // RVA: 0x7FFE80E46250
    }

    public class Lerp : Object
    {
        // ── Methods ──
        public void Interpolate(){} // RVA: 0x7FFE87ED1980 | overloaded x3
    }

    public class PointerDownLinkTagEvent : PointerEventBase`1
    {
        public string _linkID; // 0x110
        public string _linkText; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87ED0480
        public void set_linkID(){} // RVA: 0x7FFE813159A0
        public void set_linkText(){} // RVA: 0x7FFE81317920
        public void Init(){} // RVA: 0x7FFE87ED0570
        public void LocalInit(){} // RVA: 0x7FFE87ECFB00
        public void GetPooled(){} // RVA: 0x7FFE87ED05C0
        public void .ctor(){} // RVA: 0x7FFE87ED06F0
    }

    public class PointerMoveLinkTagEvent : PointerEventBase`1
    {
        public string _linkID; // 0x110
        public string _linkText; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87ECFDB0
        public void set_linkID(){} // RVA: 0x7FFE813159A0
        public void set_linkText(){} // RVA: 0x7FFE81317920
        public void Init(){} // RVA: 0x7FFE87ECFEA0
        public void LocalInit(){} // RVA: 0x7FFE87ECFB00
        public void GetPooled(){} // RVA: 0x7FFE87ECFEF0
        public void .ctor(){} // RVA: 0x7FFE87ED0020
    }

    public class PointerOutLinkTagEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87ED0190
        public void Init(){} // RVA: 0x7FFE87ED0280
        public void LocalInit(){} // RVA: 0x7FFE87ECFB00
        public void GetPooled(){} // RVA: 0x7FFE87ED02D0
        public void .ctor(){} // RVA: 0x7FFE87ED0310
    }

    public class PointerOverLinkTagEvent : PointerEventBase`1
    {
        public string _linkID; // 0x110
        public string _linkText; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87ECF9C0
        public void set_linkID(){} // RVA: 0x7FFE813159A0
        public void set_linkText(){} // RVA: 0x7FFE81317920
        public void Init(){} // RVA: 0x7FFE87ECFAB0
        public void LocalInit(){} // RVA: 0x7FFE87ECFB00
        public void GetPooled(){} // RVA: 0x7FFE87ECFB10
        public void .ctor(){} // RVA: 0x7FFE87ECFC40
    }

    public class PointerUpLinkTagEvent : PointerEventBase`1
    {
        public string _linkID; // 0x110
        public string _linkText; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87ED0860
        public void set_linkID(){} // RVA: 0x7FFE813159A0
        public void set_linkText(){} // RVA: 0x7FFE81317920
        public void Init(){} // RVA: 0x7FFE87ED0950
        public void LocalInit(){} // RVA: 0x7FFE87ECFB00
        public void GetPooled(){} // RVA: 0x7FFE87ED09A0
        public void .ctor(){} // RVA: 0x7FFE87ED0AD0
    }

    public class StyleValues : ValueType
    {
        public UnityEngine.UIElements.StyleValueCollection m_StyleValues; // 0x10
        public object set_right; // 0xDF90
        public object set_borderColor; // 0xE148
        public object field_3; // 0xE300
        public object field_4; // 0xE4B8
        public object field_5; // 0xE670
        public object field_6; // 0xE828
        public 0x33C0570F68EC8348 field_7; // 0xB8F0
        public void field_8; // 0xE988
        public object field_9; // 0xCA0
        public object field_10; // 0xB960
        public object field_11; // 0xFFFF
        public object field_12; // 0x7220
        public object field_13; // 0x1C19
        public object field_14; // 0xC98
        public void field_15;
        public object field_16; // 0x9880
        public object set_right; // 0xAE00
        public 0x33C0570F68EC8348 field_18; // 0xB940
        public void field_19; // 0xE9B0
        public object field_20; // 0xE80
        public object field_21; // 0xB960
        public object field_22; // 0xFFFF
        public object field_23; // 0x7220
        public object field_24; // 0x1C1E
        public object field_25; // 0x5E27
        public void field_26;
        public object field_27; // 0x8220
        public object set_borderColor; // 0xAEA0

        // ── Methods ──
        public void set_top(){} // RVA: 0x7FFE87ED0C40
        public void set_left(){} // RVA: 0x7FFE87ED0CA0
        public void set_width(){} // RVA: 0x7FFE87ED0D00
        public void set_height(){} // RVA: 0x7FFE87ED0D60
        public void set_right(){} // RVA: 0x7FFE87ED0DC0
        public void set_bottom(){} // RVA: 0x7FFE87ED0E20
        public void set_color(){} // RVA: 0x7FFE87ED0E80
        public void set_backgroundColor(){} // RVA: 0x7FFE87ED0EE0
        public void set_unityBackgroundImageTintColor(){} // RVA: 0x7FFE87ED0F40
        public void set_borderColor(){} // RVA: 0x7FFE87ED0FA0
        public void set_marginLeft(){} // RVA: 0x7FFE87ED1000
        public void set_marginTop(){} // RVA: 0x7FFE87ED1060
        public void set_marginRight(){} // RVA: 0x7FFE87ED10C0
        public void set_marginBottom(){} // RVA: 0x7FFE87ED1120
        public void set_paddingLeft(){} // RVA: 0x7FFE87ED1180
        public void get_paddingTop(){} // RVA: 0x7FFE87ED11E0
        public void set_paddingTop(){} // RVA: 0x7FFE87ED1290
        public void set_paddingRight(){} // RVA: 0x7FFE87ED12F0
        public void set_paddingBottom(){} // RVA: 0x7FFE87ED1350
        public void set_borderLeftWidth(){} // RVA: 0x7FFE87ED13B0
        public void set_borderRightWidth(){} // RVA: 0x7FFE87ED1410
        public void set_borderTopWidth(){} // RVA: 0x7FFE87ED1470
        public void set_borderBottomWidth(){} // RVA: 0x7FFE87ED14D0
        public void set_borderTopLeftRadius(){} // RVA: 0x7FFE87ED1530
        public void set_borderTopRightRadius(){} // RVA: 0x7FFE87ED1590
        public void set_borderBottomLeftRadius(){} // RVA: 0x7FFE87ED15F0
        public void set_borderBottomRightRadius(){} // RVA: 0x7FFE87ED1650
        public void set_opacity(){} // RVA: 0x7FFE87ED16B0
        public void set_flexGrow(){} // RVA: 0x7FFE87ED1710
        public void set_flexShrink(){} // RVA: 0x7FFE87ED1710
        public void SetValue(){} // RVA: 0x7FFE87ED17D0 | overloaded x2
        public void Values(){} // RVA: 0x7FFE87ED1830
    }

    public class ValueAnimation`1 : Object
    {
        public long m_StartTimeMs;
        public int m_DurationMs;
        public System.Func`2<float,float> _easingCurve;
        public bool _isRunning;
        public System.Action _onAnimationCompleted;
        public bool _autoRecycle;
        public bool _recycled;
        public UnityEngine.UIElements.ObjectPool`1<UnityEngine.UIElements.Experimental.ValueAnimation`1<T>> sObjectPool;
        public UnityEngine.UIElements.VisualElement _owner;
        public System.Action`2<UnityEngine.UIElements.VisualElement,T> _valueUpdated;
        public System.Func`2<UnityEngine.UIElements.VisualElement,T> _initialValue;
        public System.Func`4<T,T,float,T> _interpolator;

        // ── Methods ──
        public void get_durationMs(){} // RVA: 0x7FFE80E2EDB0
        public void set_durationMs(){} // RVA: 0x7FFE80E46530
        public void get_easingCurve(){} // RVA: 0x7FFE80E2E2E0
        public void set_easingCurve(){} // RVA: 0x7FFE80E460A0
        public void get_isRunning(){} // RVA: 0x7FFE80E2F150
        public void set_isRunning(){} // RVA: 0x7FFE80E466C0
        public void get_onAnimationCompleted(){} // RVA: 0x7FFE80E2E2E0
        public void set_onAnimationCompleted(){} // RVA: 0x7FFE80E460A0
        public void get_autoRecycle(){} // RVA: 0x7FFE80E2F150
        public void set_autoRecycle(){} // RVA: 0x7FFE80E466C0
        public void get_recycled(){} // RVA: 0x7FFE80E2F150
        public void set_recycled(){} // RVA: 0x7FFE80E466C0
        public void get_owner(){} // RVA: 0x7FFE80E2E2E0
        public void set_owner(){} // RVA: 0x7FFE80E460A0
        public void get_valueUpdated(){} // RVA: 0x7FFE80E2E2E0
        public void set_valueUpdated(){} // RVA: 0x7FFE80E460A0
        public void get_initialValue(){} // RVA: 0x7FFE80E2E2E0
        public void set_initialValue(){} // RVA: 0x7FFE80E460A0
        public void get_interpolator(){} // RVA: 0x7FFE80E2E2E0
        public void set_interpolator(){} // RVA: 0x7FFE80E460A0
        public void get_from(){} // RVA: 0x7FFE810A1420
        public void set_from(){} // RVA: 0x7FFE810A1420
        public void get_to(){} // RVA: 0x7FFE810A1420
        public void set_to(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Start(){} // RVA: 0x7FFE80E45FE0
        public void Stop(){} // RVA: 0x7FFE80E45FE0
        public void Recycle(){} // RVA: 0x7FFE80E45FE0
        public void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(){} // RVA: 0x7FFE80E46250
        public void SetDefaultValues(){} // RVA: 0x7FFE80E45FE0
        public void Unregister(){} // RVA: 0x7FFE80E45FE0
        public void Register(){} // RVA: 0x7FFE80E45FE0
        public void SetOwner(){} // RVA: 0x7FFE80E460A0
        public void CheckNotRecycled(){} // RVA: 0x7FFE80E45FE0
        public void Create(){} // RVA: 0x7FFE80E2E440
        public void KeepAlive(){} // RVA: 0x7FFE80E2E2E0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

}