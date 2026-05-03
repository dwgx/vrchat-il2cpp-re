// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 6
// Methods: 38

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class NavigateFocusRing : Object
    {
        public ChangeDirection Left;

        // ── Methods ──
        public void get_focusController(){} // RVA: 0x7FFE815888B0
        public void .ctor(){} // RVA: 0x7FFE87F3DFE0
        public void GetFocusChangeDirection(){} // RVA: 0x7FFE87F3E100
        public void GetNextFocusable(){} // RVA: 0x7FFE87F3E6B0
        public void GetNextFocusable2D(){} // RVA: 0x7FFE87F3E820
        public void IsActive(){} // RVA: 0x7FFE87F3EF60
        public void IsNavigable(){} // RVA: 0x7FFE87F3EFD0
        public void .cctor(){} // RVA: 0x7FFE87F3F020
    }

    public class NavigationCancelEvent : NavigationEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F341D0
        public void .ctor(){} // RVA: 0x7FFE87F342C0
    }

    public class NavigationEventBase`1 : EventBase`1
    {
        public 0x66679374 _modifiers;
        public 0x665165BC _deviceType;
        public object field_2; // 0x23E
        public object field_3; // 0x23F

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFE80E2EDB0
        public void set_modifiers(){} // RVA: 0x7FFE80E46530
        public void get_shiftKey(){} // RVA: 0x7FFE80E2F150
        public void get_altKey(){} // RVA: 0x7FFE80E2F150
        public void get_deviceType(){} // RVA: 0x7FFE80E2EDB0
        public void set_deviceType(){} // RVA: 0x7FFE80E46530
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Init(){} // RVA: 0x7FFE80E45FE0
        public void LocalInit(){} // RVA: 0x7FFE80E45FE0
        public void GetPooled(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class NavigationEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFE87F337E0
        public void DispatchEvent(){} // RVA: 0x7FFE87F33830
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NavigationMoveEvent : NavigationEventBase`1
    {
        public 0x6651666C _direction; // 0x90
        public UnityEngine.Vector2 _move; // 0x94

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F338E0
        public void DetermineMoveDirection(){} // RVA: 0x7FFE87F339D0
        public void get_direction(){} // RVA: 0x7FFE814AA220
        public void set_direction(){} // RVA: 0x7FFE81C8DB30
        public void set_move(){} // RVA: 0x7FFE848BEE90
        public void GetPooled(){} // RVA: 0x7FFE87F33CB0 | overloaded x4
        public void Init(){} // RVA: 0x7FFE87F33D70
        public void .ctor(){} // RVA: 0x7FFE87F33E90
        public void LocalInit(){} // RVA: 0x7FFE87F33F90
    }

    public class NavigationSubmitEvent : NavigationEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F344F0
        public void .ctor(){} // RVA: 0x7FFE87F345E0
    }

}