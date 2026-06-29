// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.Experimental
// Classes: 15
// Methods: 151

namespace ThirdParty.Unity.UnityEngine.UIElements.Experimental
{
    public class Easing : Object
    {
        // ── Methods ──
        public void Linear(){} // RVA: 0x18F3EB0
        public void InSine(){} // RVA: 0x7FA9050
        public void OutSine(){} // RVA: 0x7FA9080
        public void InOutSine(){} // RVA: 0x7FA9090
        public void InQuad(){} // RVA: 0x7FA90C0
        public void OutQuad(){} // RVA: 0x7FA90D0
        public void InOutQuad(){} // RVA: 0x7FA90F0
        public void InCubic(){} // RVA: 0x7FA9140
        public void OutCubic(){} // RVA: 0x7FA9150
        public void InOutCubic(){} // RVA: 0x7FA9180
        public void InPower(){} // RVA: 0x7FA91E0
        public void OutPower(){} // RVA: 0x7FA91F0
        public void InOutPower(){} // RVA: 0x7FA9240
        public void InBounce(){} // RVA: 0x7FA92C0
        public void OutBounce(){} // RVA: 0x7FA9390
        public void InOutBounce(){} // RVA: 0x7FA9430
        public void InElastic(){} // RVA: 0x7FA9550
        public void OutElastic(){} // RVA: 0x7FA95E0
        public void InOutElastic(){} // RVA: 0x7FA9680
        public void InBack(){} // RVA: 0x7FA97C0
        public void OutBack(){} // RVA: 0x7FA97E0
        public void InOutBack(){} // RVA: 0x7FA9820
        public void InCirc(){} // RVA: 0x7FA98A0
        public void OutCirc(){} // RVA: 0x7FA9900
        public void InOutCirc(){} // RVA: 0x7FA9930
    }

    public class EventDebuggerLogCall : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3FC0
        public void Dispose(){} // RVA: 0x3FC0
    }

    public class EventDebuggerLogExecuteDefaultAction : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3FC0
        public void Dispose(){} // RVA: 0x3FC0
    }

    public class EventDebuggerLogIMGUICall : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3FC0
        public void Dispose(){} // RVA: 0x3FC0
    }

    public class ITransitionAnimations
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x881DE0
    }

    public class IValueAnimationUpdate
    {
        // ── Methods ──
        public void Tick(){} // RVA: 0x8943F0
    }

    public class IValueAnimationUpdate[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Lerp : Object
    {
        // ── Methods ──
        public void Interpolate(){} // RVA: 0x7FAB9A0
    }

    public class PointerDownLinkTagEvent : PointerEventBase`1
    {
        public object _linkID;
        public object _linkText;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FAA4A0
        public void set_linkID(){} // RVA: 0x15B42C0
        public void set_linkText(){} // RVA: 0x15B7570
        public void Init(){} // RVA: 0x7FAA590
        public void LocalInit(){} // RVA: 0x7FA9B20
        public void GetPooled(){} // RVA: 0x7FAA5E0
        public void .ctor(){} // RVA: 0x7FAA710
    }

    public class PointerMoveLinkTagEvent : PointerEventBase`1
    {
        public object _linkID;
        public object _linkText;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FA9DD0
        public void set_linkID(){} // RVA: 0x15B42C0
        public void set_linkText(){} // RVA: 0x15B7570
        public void Init(){} // RVA: 0x7FA9EC0
        public void LocalInit(){} // RVA: 0x7FA9B20
        public void GetPooled(){} // RVA: 0x7FA9F10
        public void .ctor(){} // RVA: 0x7FAA040
    }

    public class PointerOutLinkTagEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FAA1B0
        public void Init(){} // RVA: 0x7FAA2A0
        public void LocalInit(){} // RVA: 0x7FA9B20
        public void GetPooled(){} // RVA: 0x7FAA2F0
        public void .ctor(){} // RVA: 0x7FAA330
    }

    public class PointerOverLinkTagEvent : PointerEventBase`1
    {
        public object _linkID;
        public object _linkText;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FA99E0
        public void set_linkID(){} // RVA: 0x15B42C0
        public void set_linkText(){} // RVA: 0x15B7570
        public void Init(){} // RVA: 0x7FA9AD0
        public void LocalInit(){} // RVA: 0x7FA9B20
        public void GetPooled(){} // RVA: 0x7FA9B30
        public void .ctor(){} // RVA: 0x7FA9C60
    }

    public class PointerUpLinkTagEvent : PointerEventBase`1
    {
        public object _linkID;
        public object _linkText;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FAA880
        public void set_linkID(){} // RVA: 0x15B42C0
        public void set_linkText(){} // RVA: 0x15B7570
        public void Init(){} // RVA: 0x7FAA970
        public void LocalInit(){} // RVA: 0x7FA9B20
        public void GetPooled(){} // RVA: 0x7FAA9C0
        public void .ctor(){} // RVA: 0x7FAAAF0
    }

    public class StyleValues : ValueType
    {
        public object m_StyleValues;

        // ── Methods ──
        public void set_top(){} // RVA: 0x9A1670
        public void set_left(){} // RVA: 0x9A1680
        public void set_width(){} // RVA: 0x9A1690
        public void set_height(){} // RVA: 0x9A16A0
        public void set_right(){} // RVA: 0x9A16B0
        public void set_bottom(){} // RVA: 0x9A16C0
        public void set_color(){} // RVA: 0x9A16D0
        public void set_backgroundColor(){} // RVA: 0x9A1740
        public void set_unityBackgroundImageTintColor(){} // RVA: 0x9A17B0
        public void set_borderColor(){} // RVA: 0x9A1820
        public void set_marginLeft(){} // RVA: 0x9A1890
        public void set_marginTop(){} // RVA: 0x9A18A0
        public void set_marginRight(){} // RVA: 0x9A18B0
        public void set_marginBottom(){} // RVA: 0x9A18C0
        public void set_paddingLeft(){} // RVA: 0x9A18D0
        public void get_paddingTop(){} // RVA: 0x9A18E0
        public void set_paddingTop(){} // RVA: 0x9A18F0
        public void set_paddingRight(){} // RVA: 0x9A1900
        public void set_paddingBottom(){} // RVA: 0x9A1910
        public void set_borderLeftWidth(){} // RVA: 0x9A1920
        public void set_borderRightWidth(){} // RVA: 0x9A1930
        public void set_borderTopWidth(){} // RVA: 0x9A1940
        public void set_borderBottomWidth(){} // RVA: 0x9A1950
        public void set_borderTopLeftRadius(){} // RVA: 0x9A1960
        public void set_borderTopRightRadius(){} // RVA: 0x9A1970
        public void set_borderBottomLeftRadius(){} // RVA: 0x9A1980
        public void set_borderBottomRightRadius(){} // RVA: 0x9A1990
        public void set_opacity(){} // RVA: 0x9A19A0
        public void set_flexGrow(){} // RVA: 0x9A19B0
        public void set_flexShrink(){} // RVA: 0x9A19B0
        public void SetValue(){} // RVA: 0x9A1A20
        public void Values(){} // RVA: 0x9A1A80
    }

    public class ValueAnimation`1 : Object
    {
        public object m_StartTimeMs;
        public object m_DurationMs;
        public object _easingCurve;
        public object _isRunning;
        public object _onAnimationCompleted;
        public object _autoRecycle;
        public object _recycled;
        public object sObjectPool;
        public object _owner;
        public object _valueUpdated;
        public object _initialValue;
        public object _interpolator;
        public object _from;
        public object fromValueSet;
        public object _to;

        // ── Methods ──
        public void get_durationMs(){} // RVA: 0x87C130
        public void set_durationMs(){} // RVA: 0x8944F0
        public void get_easingCurve(){} // RVA: 0x87C0A0
        public void set_easingCurve(){} // RVA: 0x894320
        public void get_isRunning(){} // RVA: 0x87D280
        public void set_isRunning(){} // RVA: 0x894750
        public void get_onAnimationCompleted(){} // RVA: 0x87C0A0
        public void set_onAnimationCompleted(){} // RVA: 0x894320
        public void get_autoRecycle(){} // RVA: 0x87D280
        public void set_autoRecycle(){} // RVA: 0x894750
        public void get_recycled(){} // RVA: 0x87D280
        public void set_recycled(){} // RVA: 0x894750
        public void get_owner(){} // RVA: 0x87C0A0
        public void set_owner(){} // RVA: 0x894320
        public void get_valueUpdated(){} // RVA: 0x87C0A0
        public void set_valueUpdated(){} // RVA: 0x894320
        public void get_initialValue(){} // RVA: 0x87C0A0
        public void set_initialValue(){} // RVA: 0x894320
        public void get_interpolator(){} // RVA: 0x87C0A0
        public void set_interpolator(){} // RVA: 0x894320
        public void get_from(){} // RVA: 0xA94080
        public void set_from(){} // RVA: 0xA94080
        public void get_to(){} // RVA: 0xA94080
        public void set_to(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
        public void Start(){} // RVA: 0x894290
        public void Stop(){} // RVA: 0x894290
        public void Recycle(){} // RVA: 0x894290
        public void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(){} // RVA: 0x8943F0
        public void SetDefaultValues(){} // RVA: 0x894290
        public void Unregister(){} // RVA: 0x894290
        public void Register(){} // RVA: 0x894290
        public void SetOwner(){} // RVA: 0x894320
        public void CheckNotRecycled(){} // RVA: 0x894290
        public void Create(){} // RVA: 0x87C630
        public void KeepAlive(){} // RVA: 0x87C0A0
        public void .cctor(){} // RVA: 0x8942F0
    }

}