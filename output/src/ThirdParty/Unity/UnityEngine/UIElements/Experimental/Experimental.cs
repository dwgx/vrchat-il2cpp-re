// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.Experimental
// Classes: 11
// Methods: 133

namespace ThirdParty.Unity.UnityEngine.UIElements.Experimental
{
    public class Easing : Object
    {
        // ── Methods ──
        public void Linear(){} // RVA: 0x7FFAC35D2DD0
        public void InSine(){} // RVA: 0x7FFAC9B267B0
        public void OutSine(){} // RVA: 0x7FFAC9B267E0
        public void InOutSine(){} // RVA: 0x7FFAC9B267F0
        public void InQuad(){} // RVA: 0x7FFAC9B26820
        public void OutQuad(){} // RVA: 0x7FFAC9B26830
        public void InOutQuad(){} // RVA: 0x7FFAC9B26850
        public void InCubic(){} // RVA: 0x7FFAC9B268A0
        public void OutCubic(){} // RVA: 0x7FFAC9B268B0
        public void InOutCubic(){} // RVA: 0x7FFAC9B268E0
        public void InPower(){} // RVA: 0x7FFAC9B26940
        public void OutPower(){} // RVA: 0x7FFAC9B26950
        public void InOutPower(){} // RVA: 0x7FFAC9B269A0
        public void InBounce(){} // RVA: 0x7FFAC9B26A20
        public void OutBounce(){} // RVA: 0x7FFAC9B26AF0
        public void InOutBounce(){} // RVA: 0x7FFAC9B26B90
        public void InElastic(){} // RVA: 0x7FFAC9B26CB0
        public void OutElastic(){} // RVA: 0x7FFAC9B26D40
        public void InOutElastic(){} // RVA: 0x7FFAC9B26DE0
        public void InBack(){} // RVA: 0x7FFAC4033B40
        public void OutBack(){} // RVA: 0x7FFAC9B26F20
        public void InOutBack(){} // RVA: 0x7FFAC9B26F60
        public void InCirc(){} // RVA: 0x7FFAC9B26FE0
        public void OutCirc(){} // RVA: 0x7FFAC9B27040
        public void InOutCirc(){} // RVA: 0x7FFAC9B27070
    }

    public class ITransitionAnimations
    {
        // ── Methods ──
        public void Start(){}
    }

    public class IValueAnimationUpdate
    {
        // ── Methods ──
        public void Tick(){} // RVA: 0x7FFAC2C70BF0
    }

    public class Lerp : Object
    {
        // ── Methods ──
        public void Interpolate(){} // RVA: 0x7FFAC9B290E0 | overloaded x3
    }

    public class PointerDownLinkTagEvent : PointerEventBase`1
    {
        public string linkID; // 0x110
        public string linkText; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B27BE0
        public void set_linkID(){} // RVA: 0x7FFAC39B3E10
        public void set_linkText(){} // RVA: 0x7FFAC33B8580
        public void Init(){} // RVA: 0x7FFAC9B27CD0
        public void LocalInit(){} // RVA: 0x7FFAC9B27260
        public void GetPooled(){} // RVA: 0x7FFAC9B27D20
        public void .ctor(){} // RVA: 0x7FFAC9B27E50
    }

    public class PointerMoveLinkTagEvent : PointerEventBase`1
    {
        public string linkID; // 0x110
        public string linkText; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B27510
        public void set_linkID(){} // RVA: 0x7FFAC39B3E10
        public void set_linkText(){} // RVA: 0x7FFAC33B8580
        public void Init(){} // RVA: 0x7FFAC9B27600
        public void LocalInit(){} // RVA: 0x7FFAC9B27260
        public void GetPooled(){} // RVA: 0x7FFAC9B27650
        public void .ctor(){} // RVA: 0x7FFAC9B27780
    }

    public class PointerOutLinkTagEvent : PointerEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B278F0
        public void Init(){} // RVA: 0x7FFAC9B279E0
        public void LocalInit(){} // RVA: 0x7FFAC9B27260
        public void GetPooled(){} // RVA: 0x7FFAC9B27A30
        public void .ctor(){} // RVA: 0x7FFAC9B27A70
    }

    public class PointerOverLinkTagEvent : PointerEventBase`1
    {
        public string linkID; // 0x110
        public string linkText; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B27120
        public void set_linkID(){} // RVA: 0x7FFAC39B3E10
        public void set_linkText(){} // RVA: 0x7FFAC33B8580
        public void Init(){} // RVA: 0x7FFAC9B27210
        public void LocalInit(){} // RVA: 0x7FFAC9B27260
        public void GetPooled(){} // RVA: 0x7FFAC9B27270
        public void .ctor(){} // RVA: 0x7FFAC9B273A0
    }

    public class PointerUpLinkTagEvent : PointerEventBase`1
    {
        public string linkID; // 0x110
        public string linkText; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B27FC0
        public void set_linkID(){} // RVA: 0x7FFAC39B3E10
        public void set_linkText(){} // RVA: 0x7FFAC33B8580
        public void Init(){} // RVA: 0x7FFAC9B280B0
        public void LocalInit(){} // RVA: 0x7FFAC9B27260
        public void GetPooled(){} // RVA: 0x7FFAC9B28100
        public void .ctor(){} // RVA: 0x7FFAC9B28230
    }

    public class StyleValues : ValueType
    {
        public UnityEngine.UIElements.StyleValueCollection top; // 0x10

        // ── Methods ──
        public void set_top(){} // RVA: 0x7FFAC9B283A0
        public void set_left(){} // RVA: 0x7FFAC9B28400
        public void set_width(){} // RVA: 0x7FFAC9B28460
        public void set_height(){} // RVA: 0x7FFAC9B284C0
        public void set_right(){} // RVA: 0x7FFAC9B28520
        public void set_bottom(){} // RVA: 0x7FFAC9B28580
        public void set_color(){} // RVA: 0x7FFAC9B285E0
        public void set_backgroundColor(){} // RVA: 0x7FFAC9B28640
        public void set_unityBackgroundImageTintColor(){} // RVA: 0x7FFAC9B286A0
        public void set_borderColor(){} // RVA: 0x7FFAC9B28700
        public void set_marginLeft(){} // RVA: 0x7FFAC9B28760
        public void set_marginTop(){} // RVA: 0x7FFAC9B287C0
        public void set_marginRight(){} // RVA: 0x7FFAC9B28820
        public void set_marginBottom(){} // RVA: 0x7FFAC9B28880
        public void set_paddingLeft(){} // RVA: 0x7FFAC9B288E0
        public void get_paddingTop(){} // RVA: 0x7FFAC9B28940
        public void set_paddingTop(){} // RVA: 0x7FFAC9B289F0
        public void set_paddingRight(){} // RVA: 0x7FFAC9B28A50
        public void set_paddingBottom(){} // RVA: 0x7FFAC9B28AB0
        public void set_borderLeftWidth(){} // RVA: 0x7FFAC9B28B10
        public void set_borderRightWidth(){} // RVA: 0x7FFAC9B28B70
        public void set_borderTopWidth(){} // RVA: 0x7FFAC9B28BD0
        public void set_borderBottomWidth(){} // RVA: 0x7FFAC9B28C30
        public void set_borderTopLeftRadius(){} // RVA: 0x7FFAC9B28C90
        public void set_borderTopRightRadius(){} // RVA: 0x7FFAC9B28CF0
        public void set_borderBottomLeftRadius(){} // RVA: 0x7FFAC9B28D50
        public void set_borderBottomRightRadius(){} // RVA: 0x7FFAC9B28DB0
        public void set_opacity(){} // RVA: 0x7FFAC9B28E10
        public void set_flexGrow(){} // RVA: 0x7FFAC9B28E70
        public void set_flexShrink(){} // RVA: 0x7FFAC9B28E70
        public void SetValue(){} // RVA: 0x7FFAC9B28F30 | overloaded x2
        public void Values(){} // RVA: 0x7FFAC9B28F90
    }

    public class ValueAnimation`1 : Object
    {
        public long durationMs;
        public int easingCurve;
        public System.Func`2<float,float> isRunning;
        public bool onAnimationCompleted;
        public System.Action autoRecycle;
        public bool recycled;
        public bool owner;
        public UnityEngine.UIElements.ObjectPool`1<UnityEngine.UIElements.Experimental.ValueAnimation`1<T>> valueUpdated;
        public UnityEngine.UIElements.VisualElement initialValue;
        public System.Action`2<UnityEngine.UIElements.VisualElement,T> interpolator;
        public System.Func`2<UnityEngine.UIElements.VisualElement,T> from;
        public System.Func`4<T,T,float,T> to;
        public T _from;
        public bool fromValueSet;
        public T <to>k__BackingField;

        // ── Methods ──
        public void get_durationMs(){} // RVA: 0x7FFAC2C59960
        public void set_durationMs(){} // RVA: 0x7FFAC2C70ED0
        public void get_easingCurve(){} // RVA: 0x7FFAC2C58E90
        public void set_easingCurve(){} // RVA: 0x7FFAC2C70A40
        public void get_isRunning(){} // RVA: 0x7FFAC2C59D00
        public void set_isRunning(){} // RVA: 0x7FFAC2C71060
        public void get_onAnimationCompleted(){} // RVA: 0x7FFAC2C58E90
        public void set_onAnimationCompleted(){} // RVA: 0x7FFAC2C70A40
        public void get_autoRecycle(){} // RVA: 0x7FFAC2C59D00
        public void set_autoRecycle(){} // RVA: 0x7FFAC2C71060
        public void get_recycled(){} // RVA: 0x7FFAC2C59D00
        public void set_recycled(){} // RVA: 0x7FFAC2C71060
        public void get_owner(){} // RVA: 0x7FFAC2C58E90
        public void set_owner(){} // RVA: 0x7FFAC2C70A40
        public void get_valueUpdated(){} // RVA: 0x7FFAC2C58E90
        public void set_valueUpdated(){} // RVA: 0x7FFAC2C70A40
        public void get_initialValue(){} // RVA: 0x7FFAC2C58E90
        public void set_initialValue(){} // RVA: 0x7FFAC2C70A40
        public void get_interpolator(){} // RVA: 0x7FFAC2C58E90
        public void set_interpolator(){} // RVA: 0x7FFAC2C70A40
        public void get_from(){} // RVA: 0x7FFAC2E8DC40
        public void set_from(){} // RVA: 0x7FFAC2E8DC40
        public void get_to(){} // RVA: 0x7FFAC2E8DC40
        public void set_to(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Start(){} // RVA: 0x7FFAC2C70980
        public void Stop(){} // RVA: 0x7FFAC2C70980
        public void Recycle(){} // RVA: 0x7FFAC2C70980
        public void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(){} // RVA: 0x7FFAC2C70BF0
        public void SetDefaultValues(){} // RVA: 0x7FFAC2C70980
        public void Unregister(){} // RVA: 0x7FFAC2C70980
        public void Register(){} // RVA: 0x7FFAC2C70980
        public void SetOwner(){} // RVA: 0x7FFAC2C70A40
        public void CheckNotRecycled(){} // RVA: 0x7FFAC2C70980
        public void Create(){} // RVA: 0x7FFAC2C58FF0
        public void KeepAlive(){} // RVA: 0x7FFAC2C58E90
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

}