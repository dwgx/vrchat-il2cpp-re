// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.Experimental
// Classes: 11
// Methods: 133

namespace ThirdParty.Unity.UnityEngine.UIElements.Experimental
{
    public class Easing
    {
        // ── Methods ──
        public void Linear(){} // RVA: 0x1020CE0
        public void InSine(){} // RVA: 0x738EED0
        public void OutSine(){} // RVA: 0x738EF00
        public void InOutSine(){} // RVA: 0x738EF10
        public void InQuad(){} // RVA: 0x738EF40
        public void OutQuad(){} // RVA: 0x738EF50
        public void InOutQuad(){} // RVA: 0x738EF70
        public void InCubic(){} // RVA: 0x738EFC0
        public void OutCubic(){} // RVA: 0x738EFD0
        public void InOutCubic(){} // RVA: 0x738F000
        public void InPower(){} // RVA: 0x738F060
        public void OutPower(){} // RVA: 0x738F070
        public void InOutPower(){} // RVA: 0x738F0C0
        public void InBounce(){} // RVA: 0x738F140
        public void OutBounce(){} // RVA: 0x738F210
        public void InOutBounce(){} // RVA: 0x738F2B0
        public void InElastic(){} // RVA: 0x738F3D0
        public void OutElastic(){} // RVA: 0x738F460
        public void InOutElastic(){} // RVA: 0x738F500
        public void InBack(){} // RVA: 0x14F67D0
        public void OutBack(){} // RVA: 0x738F640
        public void InOutBack(){} // RVA: 0x738F680
        public void InCirc(){} // RVA: 0x738F700
        public void OutCirc(){} // RVA: 0x738F760
        public void InOutCirc(){} // RVA: 0x738F790
    }

    public class ITransitionAnimations
    {
        // ── Methods ──
        public void Start(){}
    }

    public class IValueAnimationUpdate
    {
        // ── Methods ──
        public void Tick(){} // RVA: 0x24CC0
    }

    public class Lerp
    {
        // ── Methods ──
        public void Interpolate(){} // RVA: 0x7391800 | overloaded x3
    }

    public class PointerDownLinkTagEvent
    {
        public string <linkID>k__BackingField; // 0x110
        public string <linkText>k__BackingField; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7390300
        public void set_linkID(){} // RVA: 0x509930
        public void set_linkText(){} // RVA: 0x50A8C0
        public void Init(){} // RVA: 0x73903F0
        public void LocalInit(){} // RVA: 0x738F980
        public void GetPooled(){} // RVA: 0x7390440
        public void .ctor(){} // RVA: 0x7390570
    }

    public class PointerMoveLinkTagEvent
    {
        public string <linkID>k__BackingField; // 0x110
        public string <linkText>k__BackingField; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x738FC30
        public void set_linkID(){} // RVA: 0x509930
        public void set_linkText(){} // RVA: 0x50A8C0
        public void Init(){} // RVA: 0x738FD20
        public void LocalInit(){} // RVA: 0x738F980
        public void GetPooled(){} // RVA: 0x738FD70
        public void .ctor(){} // RVA: 0x738FEA0
    }

    public class PointerOutLinkTagEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7390010
        public void Init(){} // RVA: 0x7390100
        public void LocalInit(){} // RVA: 0x738F980
        public void GetPooled(){} // RVA: 0x7390150
        public void .ctor(){} // RVA: 0x7390190
    }

    public class PointerOverLinkTagEvent
    {
        public string <linkID>k__BackingField; // 0x110
        public string <linkText>k__BackingField; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x738F840
        public void set_linkID(){} // RVA: 0x509930
        public void set_linkText(){} // RVA: 0x50A8C0
        public void Init(){} // RVA: 0x738F930
        public void LocalInit(){} // RVA: 0x738F980
        public void GetPooled(){} // RVA: 0x738F990
        public void .ctor(){} // RVA: 0x738FAC0
    }

    public class PointerUpLinkTagEvent
    {
        public string <linkID>k__BackingField; // 0x110
        public string <linkText>k__BackingField; // 0x118

        // ── Methods ──
        public void .cctor(){} // RVA: 0x73906E0
        public void set_linkID(){} // RVA: 0x509930
        public void set_linkText(){} // RVA: 0x50A8C0
        public void Init(){} // RVA: 0x73907D0
        public void LocalInit(){} // RVA: 0x738F980
        public void GetPooled(){} // RVA: 0x7390820
        public void .ctor(){} // RVA: 0x7390950
    }

    public class StyleValues
    {
        public UnityEngine.UIElements.StyleValueCollection m_StyleValues; // 0x10

        // ── Methods ──
        public void set_top(){} // RVA: 0x7390AC0
        public void set_left(){} // RVA: 0x7390B20
        public void set_width(){} // RVA: 0x7390B80
        public void set_height(){} // RVA: 0x7390BE0
        public void set_right(){} // RVA: 0x7390C40
        public void set_bottom(){} // RVA: 0x7390CA0
        public void set_color(){} // RVA: 0x7390D00
        public void set_backgroundColor(){} // RVA: 0x7390D60
        public void set_unityBackgroundImageTintColor(){} // RVA: 0x7390DC0
        public void set_borderColor(){} // RVA: 0x7390E20
        public void set_marginLeft(){} // RVA: 0x7390E80
        public void set_marginTop(){} // RVA: 0x7390EE0
        public void set_marginRight(){} // RVA: 0x7390F40
        public void set_marginBottom(){} // RVA: 0x7390FA0
        public void set_paddingLeft(){} // RVA: 0x7391000
        public void get_paddingTop(){} // RVA: 0x7391060
        public void set_paddingTop(){} // RVA: 0x7391110
        public void set_paddingRight(){} // RVA: 0x7391170
        public void set_paddingBottom(){} // RVA: 0x73911D0
        public void set_borderLeftWidth(){} // RVA: 0x7391230
        public void set_borderRightWidth(){} // RVA: 0x7391290
        public void set_borderTopWidth(){} // RVA: 0x73912F0
        public void set_borderBottomWidth(){} // RVA: 0x7391350
        public void set_borderTopLeftRadius(){} // RVA: 0x73913B0
        public void set_borderTopRightRadius(){} // RVA: 0x7391410
        public void set_borderBottomLeftRadius(){} // RVA: 0x7391470
        public void set_borderBottomRightRadius(){} // RVA: 0x73914D0
        public void set_opacity(){} // RVA: 0x7391530
        public void set_flexGrow(){} // RVA: 0x7391590
        public void set_flexShrink(){} // RVA: 0x7391590
        public void SetValue(){} // RVA: 0x7391650 | overloaded x2
        public void Values(){} // RVA: 0x73916B0
    }

    public class ValueAnimation`1
    {
        public long m_StartTimeMs;
        public int m_DurationMs;
        public System.Func`2<float,float> <easingCurve>k__BackingField;
        public bool <isRunning>k__BackingField;
        public System.Action <onAnimationCompleted>k__BackingField;
        public bool <autoRecycle>k__BackingField;
        public bool <recycled>k__BackingField;
        public UnityEngine.UIElements.ObjectPool`1<UnityEngine.UIElements.Experimental.ValueAnimation`1<T>> sObjectPool;
        public UnityEngine.UIElements.VisualElement <owner>k__BackingField;
        public System.Action`2<UnityEngine.UIElements.VisualElement,T> <valueUpdated>k__BackingField;
        public System.Func`2<UnityEngine.UIElements.VisualElement,T> <initialValue>k__BackingField;
        public System.Func`4<T,T,float,T> <interpolator>k__BackingField;

        // ── Methods ──
        public void get_durationMs(){} // RVA: 0xD840
        public void set_durationMs(){} // RVA: 0x24FA0
        public void get_easingCurve(){} // RVA: 0xCD60
        public void set_easingCurve(){} // RVA: 0x24B10
        public void get_isRunning(){} // RVA: 0xDBE0
        public void set_isRunning(){} // RVA: 0x25130
        public void get_onAnimationCompleted(){} // RVA: 0xCD60
        public void set_onAnimationCompleted(){} // RVA: 0x24B10
        public void get_autoRecycle(){} // RVA: 0xDBE0
        public void set_autoRecycle(){} // RVA: 0x25130
        public void get_recycled(){} // RVA: 0xDBE0
        public void set_recycled(){} // RVA: 0x25130
        public void get_owner(){} // RVA: 0xCD60
        public void set_owner(){} // RVA: 0x24B10
        public void get_valueUpdated(){} // RVA: 0xCD60
        public void set_valueUpdated(){} // RVA: 0x24B10
        public void get_initialValue(){} // RVA: 0xCD60
        public void set_initialValue(){} // RVA: 0x24B10
        public void get_interpolator(){} // RVA: 0xCD60
        public void set_interpolator(){} // RVA: 0x24B10
        public void get_from(){} // RVA: 0x283FA0
        public void set_from(){} // RVA: 0x283FA0
        public void get_to(){} // RVA: 0x283FA0
        public void set_to(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
        public void Start(){} // RVA: 0x24A50
        public void Stop(){} // RVA: 0x24A50
        public void Recycle(){} // RVA: 0x24A50
        public void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(){} // RVA: 0x24CC0
        public void SetDefaultValues(){} // RVA: 0x24A50
        public void Unregister(){} // RVA: 0x24A50
        public void Register(){} // RVA: 0x24A50
        public void SetOwner(){} // RVA: 0x24B10
        public void CheckNotRecycled(){} // RVA: 0x24A50
        public void Create(){} // RVA: 0xCEC0
        public void KeepAlive(){} // RVA: 0xCD60
        public void .cctor(){} // RVA: 0x24A80
    }

}