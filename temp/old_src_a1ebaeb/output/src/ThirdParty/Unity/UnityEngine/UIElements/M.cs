// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 7
// Methods: 89

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Manipulator : Object
    {
        // ── Original Methods ──
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7ffaa8660cc0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7ffaa8660cc0
        public void get_target(){} // RVA: 0x7ffaab6f26c0
        public void set_target(){} // RVA: 0x7ffaaf5c7650
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class MouseCaptureEventBase`1 : PointerCaptureEventBase`1
    {
        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class MouseEventBase`1 : EventBase`1
    {
        public object _localMousePosition; // 0x3122B030, was: <localMousePosition>k__Backing
        public object _button; // 0x3122B030, was: <button>k__BackingField
        public object _recomputeTopElementUnderMouse; // 0x3122B030, was: <UnityEngine.UIElements.IMouse

        // ── Original Methods ──
        public void get_modifiers(){} // RVA: 0x7ffaa8649ca0
        public void set_modifiers(){} // RVA: 0x7ffaa8661210
        public void get_mousePosition(){} // RVA: 0x7ffaa86491d0
        public void set_mousePosition(){} // RVA: 0x7ffaa866f720
        public void get_localMousePosition(){} // RVA: 0x7ffaa86491d0
        public void set_localMousePosition(){} // RVA: 0x7ffaa866f720
        public void get_mouseDelta(){} // RVA: 0x7ffaa86491d0
        public void set_mouseDelta(){} // RVA: 0x7ffaa866f720
        public void get_clickCount(){} // RVA: 0x7ffaa8649ca0
        public void set_clickCount(){} // RVA: 0x7ffaa8661210
        public void get_button(){} // RVA: 0x7ffaa8649ca0
        public void set_button(){} // RVA: 0x7ffaa8661210
        public void get_pressedButtons(){} // RVA: 0x7ffaa8649ca0
        public void set_pressedButtons(){} // RVA: 0x7ffaa8661210
        public void get_shiftKey(){} // RVA: 0x7ffaa864a040
        public void get_ctrlKey(){} // RVA: 0x7ffaa864a040
        public void get_commandKey(){} // RVA: 0x7ffaa864a040
        public void get_altKey(){} // RVA: 0x7ffaa864a040
        public void UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS(){} // RVA: 0x7ffaa864a040
        public void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(){} // RVA: 0x7ffaa86613a0
        public void UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse(){} // RVA: 0x7ffaa864a040
        public void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(){} // RVA: 0x7ffaa86613a0
        public void UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent(){} // RVA: 0x7ffaa86491d0
        public void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(){} // RVA: 0x7ffaa8660d80
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void LocalInit(){} // RVA: 0x7ffaa8660cc0
        public void get_currentTarget(){} // RVA: 0x7ffaa86491d0
        public void set_currentTarget(){} // RVA: 0x7ffaa8660d80
        public void PreDispatch(){} // RVA: 0x7ffaa8660d80
        public void PostDispatch(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
    }

    public class MouseEventsHelper : Object
    {
        // ── Original Methods ──
        public void SendEnterLeave(){} // RVA: 0x7ffaa887e5c0
        public void SendMouseOverMouseOut(){} // RVA: 0x7ffaaf5ac200
    }

    public class MouseManipulator : Manipulator
    {
        public object _button; // 0x83A893B0, was: <button>k__BackingField

        // ── Original Methods ──
        public void get_activators(){} // RVA: 0x7ffaa89357c0
        public void set_activators(){} // RVA: 0x7ffaa8998e80
        public void .ctor(){} // RVA: 0x7ffaaf5c7a90
        public void CanStartManipulation(){} // RVA: 0x7ffaaf5c7b50
        public void CanStopManipulation(){} // RVA: 0x7ffaaf5c7d70
    }

    public class MultiColumnController : Object
    {
        public object baseUssClassName; // 0x31832140
        public object rowContainerUssClassName; // 0x31832140
        public object k_HeaderViewDataKey; // 0x31832140
        public object m_View; // 0x31832140

        // ── Original Methods ──
        public void add_columnSortingChanged(){} // RVA: 0x7ffaaf56bd90
        public void remove_columnSortingChanged(){} // RVA: 0x7ffaaf56be80
        public void add_headerContextMenuPopulateEvent(){} // RVA: 0x7ffaaf56bf70
        public void remove_headerContextMenuPopulateEvent(){} // RVA: 0x7ffaaf56c070
        public void get_header(){} // RVA: 0x7ffaa8bfcc80
        public void .ctor(){} // RVA: 0x7ffaaf56c170
        public void BindCellItem(){} // RVA: 0x7ffaa887e5c0
        public void UnbindCellItem(){} // RVA: 0x7ffaaf56ca20
        public void DefaultMakeCellItem(){} // RVA: 0x7ffaaf56ca60
        public void DefaultBindCellItem(){} // RVA: 0x7ffaa887e5c0
        public void MakeItem(){} // RVA: 0x7ffaaf56cb30
        public void BindItem(){} // RVA: 0x7ffaa887e5c0
        public void UnbindItem(){} // RVA: 0x7ffaaf56cec0
        public void DestroyItem(){} // RVA: 0x7ffaaf56d250
        public void PrepareView(){} // RVA: 0x7ffaaf56d600
        public void Dispose(){} // RVA: 0x7ffaaf56da00
        public void OnHorizontalScrollerValueChanged(){} // RVA: 0x7ffaaf56e5b0
        public void OnViewportGeometryChanged(){} // RVA: 0x7ffaaf56e6f0
        public void OnColumnContainerGeometryChanged(){} // RVA: 0x7ffaaf56e980
        public void UpdateContentContainer(){} // RVA: 0x7ffaaf56e990
        public void OnColumnSortingChanged(){} // RVA: 0x7ffaa8c272e0
        public void OnContextMenuPopulateEvent(){} // RVA: 0x7ffaad0af8e0
        public void OnColumnResized(){} // RVA: 0x7ffaaf56eb40
        public void OnColumnAdded(){} // RVA: 0x7ffaaf56eee0
        public void OnColumnRemoved(){} // RVA: 0x7ffaaf56eee0
        public void OnColumnReordered(){} // RVA: 0x7ffaaf56ef00
        public void OnColumnsChanged(){} // RVA: 0x7ffaaf56ef40
        public void OnColumnChanged(){} // RVA: 0x7ffaaf56ef80
        public void OnViewDataRestored(){} // RVA: 0x7ffaaf56eee0
        public void .cctor(){} // RVA: 0x7ffaaf56efc0
    }

    public class MultiColumnTreeViewController : BaseTreeViewController
    {
        // ── Original Methods ──
        public void get_columnController(){} // RVA: 0x7ffaa89fa500
        public void get_header(){} // RVA: 0x7ffaaf4ad0e0
        public void .ctor(){} // RVA: 0x7ffaaf4ad0f0
        public void InvokeMakeItem(){} // RVA: 0x7ffaaf4ad1f0
        public void MakeItem(){} // RVA: 0x7ffaaf4ad380
        public void BindItem(){} // RVA: 0x7ffaaf4ad3a0
        public void UnbindItem(){} // RVA: 0x7ffaaf4ad440
        public void DestroyItem(){} // RVA: 0x7ffaaf4ad460
        public void PrepareView(){} // RVA: 0x7ffaaf4ad480
        public void Dispose(){} // RVA: 0x7ffaaf4ad4b0
    }

}