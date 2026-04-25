// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 6
// Methods: 38

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class NavigateFocusRing : Object
    {
        public ChangeDirection focusController;
        public ChangeDirection Right; // 0x8
        public ChangeDirection Up; // 0x10
        public ChangeDirection Down; // 0x18
        public UnityEngine.UIElements.FocusChangeDirection Next; // 0x20
        public UnityEngine.UIElements.FocusChangeDirection Previous; // 0x28
        public UnityEngine.UIElements.VisualElement m_Root; // 0x10
        public UnityEngine.UIElements.VisualElementFocusRing m_Ring; // 0x18

        // ── Methods ──
        public void get_focusController(){} // RVA: 0x7FFAC8D71270
        public void .ctor(){} // RVA: 0x7FFAC9B95730
        public void GetFocusChangeDirection(){} // RVA: 0x7FFAC9B95850
        public void GetNextFocusable(){} // RVA: 0x7FFAC9B95E00
        public void GetNextFocusable2D(){} // RVA: 0x7FFAC9B95F70
        public void IsActive(){} // RVA: 0x7FFAC9B966B0
        public void IsNavigable(){} // RVA: 0x7FFAC9B96720
        public void .cctor(){} // RVA: 0x7FFAC9B96770
    }

    public class NavigationCancelEvent : NavigationEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8B920
        public void .ctor(){} // RVA: 0x7FFAC9B8BA10
    }

    public class NavigationEventBase`1 : EventBase`1
    {
        public 0x6B27F588 modifiers;
        public 0x6B11D698 shiftKey;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFAC2C59960
        public void set_modifiers(){} // RVA: 0x7FFAC2C70ED0
        public void get_shiftKey(){} // RVA: 0x7FFAC2C59D00
        public void get_altKey(){} // RVA: 0x7FFAC2C59D00
        public void get_deviceType(){} // RVA: 0x7FFAC2C59960
        public void set_deviceType(){} // RVA: 0x7FFAC2C70ED0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Init(){} // RVA: 0x7FFAC2C70980
        public void LocalInit(){} // RVA: 0x7FFAC2C70980
        public void GetPooled(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class NavigationEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFAC9B8AF30
        public void DispatchEvent(){} // RVA: 0x7FFAC9B8AF80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NavigationMoveEvent : NavigationEventBase`1
    {
        public 0x6B11D748 direction; // 0x90
        public UnityEngine.Vector2 move; // 0x94

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8B030
        public void DetermineMoveDirection(){} // RVA: 0x7FFAC9B8B120
        public void get_direction(){} // RVA: 0x7FFAC3220660
        public void set_direction(){} // RVA: 0x7FFAC34D2750
        public void set_move(){} // RVA: 0x7FFAC6539430
        public void GetPooled(){} // RVA: 0x7FFAC9B8B400 | overloaded x4
        public void Init(){} // RVA: 0x7FFAC9B8B4C0
        public void .ctor(){} // RVA: 0x7FFAC9B8B5E0
        public void LocalInit(){} // RVA: 0x7FFAC9B8B6E0
    }

    public class NavigationSubmitEvent : NavigationEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8BC40
        public void .ctor(){} // RVA: 0x7FFAC9B8BD30
    }

}