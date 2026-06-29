// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Plugins.InputForUI
// Classes: 1
// Methods: 33

namespace ThirdParty.Unity.UnityEngine.InputSystem.Plugins.InputForUI
{
    public class InputSystemProvider : Object
    {
        public object m_Cfg;
        public object m_InputEventPartialProvider;
        public object m_InputActionAsset;
        public object m_PointAction;
        public object m_MoveAction;
        public object m_SubmitAction;
        public object m_CancelAction;
        public object m_LeftClickAction;
        public object m_MiddleClickAction;
        public object m_RightClickAction;
        public object m_ScrollWheelAction;
        public object m_NextPreviousAction;
        public object m_Events;
        public object m_MouseState;
        public object m_PenState;
        public object m_SeenPenEvents;
        public object m_TouchState;
        public object m_SeenTouchEvents;
        public object m_RepeatHelper;
        public object m_ResetSeenEventsOnUpdate;
        public object s_OnRegisterActions;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x77F73E0
        public void Bootstrap(){} // RVA: 0xB43310
        public void get_m_EventModifiers(){} // RVA: 0x77F7660
        public void get_m_CurrentTime(){} // RVA: 0x77F7680
        public void Initialize(){} // RVA: 0x77F76F0
        public void Shutdown(){} // RVA: 0x77F7A30
        public void OnActionsChange(){} // RVA: 0x77F7BB0
        public void Update(){} // RVA: 0x77F7C50
        public void ResetSeenEvents(){} // RVA: 0x77F8460
        public void DirectionNavigation(){} // RVA: 0x77F8470
        public void GetActiveDeviceFromDirection(){} // RVA: 0x77F8AF0
        public void ReadCurrentNavigationMoveVector(){} // RVA: 0x77F8C80
        public void ReadNextPreviousDirection(){} // RVA: 0x77F8E20
        public void SortEvents(){} // RVA: 0x77F8FC0
        public void OnFocusChanged(){} // RVA: 0x77F9310
        public void ScreenBottomLeftToPanelPosition(){} // RVA: 0x77F9350
        public void GetEventSource(){} // RVA: 0x77F94E0
        public void GetPointerStateForSource(){} // RVA: 0x77F9670
        public void DispatchFromCallback(){} // RVA: 0x77F96A0
        public void FindTouchFingerIndex(){} // RVA: 0x77F9750
        public void OnPointerPerformed(){} // RVA: 0x77F9A60
        public void OnSubmitPerformed(){} // RVA: 0x77FA5F0
        public void OnCancelPerformed(){} // RVA: 0x77FA770
        public void OnClickPerformed(){} // RVA: 0x77FA8F0
        public void OnLeftClickPerformed(){} // RVA: 0x77FAE30
        public void OnMiddleClickPerformed(){} // RVA: 0x77FAEF0
        public void OnRightClickPerformed(){} // RVA: 0x77FAFB0
        public void OnScrollWheelPerformed(){} // RVA: 0x77FB070
        public void RegisterNextPreviousAction(){} // RVA: 0x77FB590
        public void UnregisterFixedActions(){} // RVA: 0x77FB6D0
        public void RegisterActions(){} // RVA: 0x77FB750
        public void UnregisterActions(){} // RVA: 0x77FC8D0
        public void .ctor(){} // RVA: 0x77FD620
    }

}