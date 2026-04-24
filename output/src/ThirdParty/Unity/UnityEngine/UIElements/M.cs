// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 7
// Methods: 89

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Manipulator : Object
    {
        public ÎÏÌÎÎÎÌÌÌ.omLeftRadius target; // 0x10

        // ── Methods ──
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFD4E090980
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFD4E090980
        public void get_target(){} // RVA: 0x7FFD510E4750
        public void set_target(){} // RVA: 0x7FFD54FC56E0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class MouseEventBase`1 : EventBase`1
    {
        public illingServiceDisconnected modifiers;
        public tionX mousePosition;
        public tionX localMousePosition;
        public tionX mouseDelta;
        public int clickCount;
        public int button;
        public int pressedButtons;
        public bool shiftKey;
        public bool ctrlKey;
        public ÎÏÌÎÎÎÌÌÌ.rval commandKey;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFD4E079960
        public void set_modifiers(){} // RVA: 0x7FFD4E090ED0
        public void get_mousePosition(){} // RVA: 0x7FFD4E078E90
        public void set_mousePosition(){} // RVA: 0x7FFD4E09F3E0
        public void get_localMousePosition(){} // RVA: 0x7FFD4E078E90
        public void set_localMousePosition(){} // RVA: 0x7FFD4E09F3E0
        public void get_mouseDelta(){} // RVA: 0x7FFD4E078E90
        public void set_mouseDelta(){} // RVA: 0x7FFD4E09F3E0
        public void get_clickCount(){} // RVA: 0x7FFD4E079960
        public void set_clickCount(){} // RVA: 0x7FFD4E090ED0
        public void get_button(){} // RVA: 0x7FFD4E079960
        public void set_button(){} // RVA: 0x7FFD4E090ED0
        public void get_pressedButtons(){} // RVA: 0x7FFD4E079960
        public void set_pressedButtons(){} // RVA: 0x7FFD4E090ED0
        public void get_shiftKey(){} // RVA: 0x7FFD4E079D00
        public void get_ctrlKey(){} // RVA: 0x7FFD4E079D00
        public void get_commandKey(){} // RVA: 0x7FFD4E079D00
        public void get_altKey(){} // RVA: 0x7FFD4E079D00
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7FFD4E079D00
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7FFD4E091060
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7FFD4E079D00
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7FFD4E091060
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7FFD4E078E90
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7FFD4E090A40
        public void Init(){} // RVA: 0x7FFD4E090980
        public void LocalInit(){} // RVA: 0x7FFD4E090980
        public void get_currentTarget(){} // RVA: 0x7FFD4E078E90
        public void set_currentTarget(){} // RVA: 0x7FFD4E090A40
        public void PreDispatch(){} // RVA: 0x7FFD4E090A40
        public void PostDispatch(){} // RVA: 0x7FFD4E090A40
        public void GetPooled(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class MouseEventsHelper : Object
    {
        // ── Methods ──
        public void SendEnterLeave(){} // RVA: 0x7FFD4E2ADC40
        public void SendMouseOverMouseOut(){} // RVA: 0x7FFD54FAA290
    }

    public class MouseManipulator : Manipulator
    {
        public URA.woDigitYearMax<ÎÏÌÎÎÎÌÌÌ.sertSeparator> activators; // 0x18
        public ÎÏÌÎÎÎÌÌÌ.sertSeparator m_currentActivator; // 0x20

        // ── Methods ──
        public void get_activators(){} // RVA: 0x7FFD4E3447C0
        public void set_activators(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD54FC5B20
        public void CanStartManipulation(){} // RVA: 0x7FFD54FC5BE0
        public void CanStopManipulation(){} // RVA: 0x7FFD54FC5E00
    }

    public class MultiColumnController : Object
    {
        public object header;
        public object bindableElementPropertyName; // 0x4
        public string baseUssClassName; // 0x8
        public string k_HeaderContainerViewDataKey; // 0x10
        public string headerContainerUssClassName; // 0x18
        public string rowContainerUssClassName; // 0x20
        public string cellUssClassName; // 0x28
        public string cellLabelUssClassName; // 0x30
        public string k_HeaderViewDataKey; // 0x38
        public ÎÌÍÏÏÌÍÏ columnSortingChanged; // 0x10
        public rectoryInformation<ÎÏÌÎÎÎÌÌÌ.lerVisibility,ÎÏÌÎÎÎÌÌÌ.?> headerContextMenuPopulateEvent; // 0x18
        public ÎÏÌÎÎÎÌÌÌ.? m_View; // 0x20
        public ÎÏÌÎÎÎÌÌÌ.omLeftRadius m_HeaderContainer; // 0x28
        public CopyBackIndices.xDecl m_MultiColumnHeader; // 0x30

        // ── Methods ──
        public void add_columnSortingChanged(){} // RVA: 0x7FFD54F69E30
        public void remove_columnSortingChanged(){} // RVA: 0x7FFD54F69F20
        public void add_headerContextMenuPopulateEvent(){} // RVA: 0x7FFD54F6A010
        public void remove_headerContextMenuPopulateEvent(){} // RVA: 0x7FFD54F6A110
        public void get_header(){} // RVA: 0x7FFD4E5F95E0
        public void .ctor(){} // RVA: 0x7FFD54F6A210
        public void BindCellItem(){} // RVA: 0x7FFD4E2ADC40
        public void UnbindCellItem(){} // RVA: 0x7FFD54F6AAC0
        public void DefaultMakeCellItem(){} // RVA: 0x7FFD54F6AB00
        public void DefaultBindCellItem(){} // RVA: 0x7FFD4E2ADC40
        public void MakeItem(){} // RVA: 0x7FFD54F6ABD0
        public void BindItem(){} // RVA: 0x7FFD4E2ADC40
        public void UnbindItem(){} // RVA: 0x7FFD54F6AF60
        public void DestroyItem(){} // RVA: 0x7FFD54F6B2F0
        public void PrepareView(){} // RVA: 0x7FFD54F6B6A0
        public void Dispose(){} // RVA: 0x7FFD54F6BAA0
        public void OnHorizontalScrollerValueChanged(){} // RVA: 0x7FFD54F6C650
        public void OnViewportGeometryChanged(){} // RVA: 0x7FFD54F6C790
        public void OnColumnContainerGeometryChanged(){} // RVA: 0x7FFD54F6CA20
        public void UpdateContentContainer(){} // RVA: 0x7FFD54F6CA30
        public void OnColumnSortingChanged(){} // RVA: 0x7FFD4E623950
        public void OnContextMenuPopulateEvent(){} // RVA: 0x7FFD52BB7E30
        public void OnColumnResized(){} // RVA: 0x7FFD54F6CBE0
        public void OnColumnAdded(){} // RVA: 0x7FFD54F6CF80
        public void OnColumnRemoved(){} // RVA: 0x7FFD54F6CF80
        public void OnColumnReordered(){} // RVA: 0x7FFD54F6CFA0
        public void OnColumnsChanged(){} // RVA: 0x7FFD54F6CFE0
        public void OnColumnChanged(){} // RVA: 0x7FFD54F6D020
        public void OnViewDataRestored(){} // RVA: 0x7FFD54F6CF80
        public void .cctor(){} // RVA: 0x7FFD54F6D060
    }

    public class MultiColumnTreeViewController : BaseTreeViewController
    {
        public ÎÏÌÎÎÎÌÌÌ.Width columnController; // 0x58

        // ── Methods ──
        public void get_columnController(){} // RVA: 0x7FFD4E409500
        public void get_header(){} // RVA: 0x7FFD54EAB180
        public void .ctor(){} // RVA: 0x7FFD54EAB190
        public void InvokeMakeItem(){} // RVA: 0x7FFD54EAB290
        public void MakeItem(){} // RVA: 0x7FFD54EAB420
        public void BindItem(){} // RVA: 0x7FFD54EAB440
        public void UnbindItem(){} // RVA: 0x7FFD54EAB4E0
        public void DestroyItem(){} // RVA: 0x7FFD54EAB500
        public void PrepareView(){} // RVA: 0x7FFD54EAB520
        public void Dispose(){} // RVA: 0x7FFD54EAB550
    }

}