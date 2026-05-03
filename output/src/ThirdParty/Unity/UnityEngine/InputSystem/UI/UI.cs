// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.UI
// Classes: 12
// Methods: 223

namespace ThirdParty.Unity.UnityEngine.InputSystem.UI
{
    public class BaseInputOverride : BaseInput
    {
        public string _compositionString; // 0x20

        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class ExtendedAxisEventData : AxisEventData
    {
        public UnityEngine.InputSystem.InputDevice _device; // 0x30

        // ── Methods ──
        public void get_device(){} // RVA: 0x7FFE8144E200
        public void set_device(){} // RVA: 0x7FFE81129890
        public void .ctor(){} // RVA: 0x7FFE879EE2B0
        public void ToString(){} // RVA: 0x7FFE879EE2C0
    }

    public class ExtendedPointerEventData : PointerEventData
    {
        public UnityEngine.InputSystem.InputControl _control; // 0x180
        public UnityEngine.InputSystem.InputDevice _device; // 0x188
        public int _touchId; // 0x190
        public 0x66543A04 _pointerType; // 0x194
        public int _uiToolkitPointerId; // 0x198
        public UnityEngine.Vector3 _trackedDevicePosition; // 0x19C
        public UnityEngine.Quaternion _trackedDeviceOrientation; // 0x1A8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D39820
        public void get_control(){} // RVA: 0x7FFE81B38340
        public void set_control(){} // RVA: 0x7FFE81B31180
        public void get_device(){} // RVA: 0x7FFE81B295E0
        public void set_device(){} // RVA: 0x7FFE81B2E3B0
        public void get_touchId(){} // RVA: 0x7FFE86DBDB60
        public void set_touchId(){} // RVA: 0x7FFE879EE3A0
        public void get_pointerType(){} // RVA: 0x7FFE879EE3B0
        public void set_pointerType(){} // RVA: 0x7FFE879EE3C0
        public void get_uiToolkitPointerId(){} // RVA: 0x7FFE879EE3D0
        public void set_uiToolkitPointerId(){} // RVA: 0x7FFE879EE3E0
        public void get_trackedDevicePosition(){} // RVA: 0x7FFE86FECEF0
        public void set_trackedDevicePosition(){} // RVA: 0x7FFE86FECF10
        public void get_trackedDeviceOrientation(){} // RVA: 0x7FFE86FECF30
        public void set_trackedDeviceOrientation(){} // RVA: 0x7FFE86FECF40
        public void ToString(){} // RVA: 0x7FFE879EE3F0
        public void MakePointerIdForTouch(){} // RVA: 0x7FFE879EED10
        public void TouchIdFromPointerId(){} // RVA: 0x7FFE826F6440
        public void ReadDeviceState(){} // RVA: 0x7FFE879EED20
        public void GetPenPointerId(){} // RVA: 0x7FFE879EF0E0
        public void GetTouchPointerId(){} // RVA: 0x7FFE879EF3E0
    }

    public class ExtendedSubmitCancelEventData : BaseEventData
    {
        public UnityEngine.InputSystem.InputDevice _device; // 0x20

        // ── Methods ──
        public void get_device(){} // RVA: 0x7FFE811290C0
        public void set_device(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE81161E80
    }

    public class INavigationEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0x7FFE80E2E2E0
    }

    public class InputSystemUIInputModule : BaseInputModule
    {
        public float kClickSpeed;
        public float m_MoveRepeatDelay; // 0x58
        public float m_MoveRepeatRate; // 0x5C
        public float m_TrackedDeviceDragThresholdMultiplier; // 0x60
        public UnityEngine.Transform m_XRTrackingOrigin; // 0x68
        public UnityEngine.InputSystem.DefaultInputActions defaultActions;
        public UnityEngine.InputSystem.InputActionAsset m_ActionsAsset; // 0x70
        public UnityEngine.InputSystem.InputActionReference m_PointAction; // 0x78
        public UnityEngine.InputSystem.InputActionReference m_MoveAction; // 0x80
        public UnityEngine.InputSystem.InputActionReference m_SubmitAction; // 0x88
        public UnityEngine.InputSystem.InputActionReference m_CancelAction; // 0x90
        public UnityEngine.InputSystem.InputActionReference m_LeftClickAction; // 0x98
        public UnityEngine.InputSystem.InputActionReference m_MiddleClickAction; // 0xA0
        public UnityEngine.InputSystem.InputActionReference m_RightClickAction; // 0xA8
        public UnityEngine.InputSystem.InputActionReference m_ScrollWheelAction; // 0xB0
        public UnityEngine.InputSystem.InputActionReference m_TrackedDevicePositionAction; // 0xB8
        public UnityEngine.InputSystem.InputActionReference m_TrackedDeviceOrientationAction; // 0xC0
        public bool m_DeselectOnBackgroundClick; // 0xC8
        public 0x66543A5C m_PointerBehavior; // 0xCC
        public 0x66543BBC m_CursorLockBehavior; // 0xD0
        public float m_ScrollDeltaPerTick; // 0xD4
        public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.InputAction,InputActionReferenceState> s_InputActionReferenceCounts; // 0x8
        public bool m_ActionsHooked; // 0xD8
        public bool m_NeedToPurgeStalePointers; // 0xD9
        public System.Action`1<CallbackContext> m_OnPointDelegate; // 0xE0
        public System.Action`1<CallbackContext> m_OnMoveDelegate; // 0xE8

        // ── Methods ──
        public void get_deselectOnBackgroundClick(){} // RVA: 0x7FFE81FF3AD0
        public void set_deselectOnBackgroundClick(){} // RVA: 0x7FFE81FE9F60
        public void get_pointerBehavior(){} // RVA: 0x7FFE825F9DC0
        public void set_pointerBehavior(){} // RVA: 0x7FFE86C708B0
        public void get_cursorLockBehavior(){} // RVA: 0x7FFE817E0030
        public void set_cursorLockBehavior(){} // RVA: 0x7FFE82862FC0
        public void get_localMultiPlayerRoot(){} // RVA: 0x7FFE81B267B0
        public void set_localMultiPlayerRoot(){} // RVA: 0x7FFE81B2BD10
        public void get_scrollDeltaPerTick(){} // RVA: 0x7FFE86C708E0
        public void set_scrollDeltaPerTick(){} // RVA: 0x7FFE86C708F0
        public void ActivateModule(){} // RVA: 0x7FFE879EF540
        public void IsPointerOverGameObject(){} // RVA: 0x7FFE879EF670
        public void GetLastRaycastResult(){} // RVA: 0x7FFE879EF910
        public void PerformRaycast(){} // RVA: 0x7FFE879EFA60
        public void ProcessPointer(){} // RVA: 0x7FFE879EFDF0
        public void PointerShouldIgnoreTransform(){} // RVA: 0x7FFE879F0480
        public void ProcessPointerMovement(){} // RVA: 0x7FFE879F06A0 | overloaded x2
        public void ProcessPointerButton(){} // RVA: 0x7FFE879F1550
        public void ProcessPointerButtonDrag(){} // RVA: 0x7FFE879F22C0
        public void ProcessPointerScroll(){} // RVA: 0x7FFE879F26C0
        public void ProcessNavigation(){} // RVA: 0x7FFE879F27C0
        public void IsMoveAllowed(){} // RVA: 0x7FFE879F2FD0
        public void get_moveRepeatDelay(){} // RVA: 0x7FFE81123FE0
        public void set_moveRepeatDelay(){} // RVA: 0x7FFE81123FF0
        public void get_moveRepeatRate(){} // RVA: 0x7FFE81124000
        public void set_moveRepeatRate(){} // RVA: 0x7FFE81124010
        public void get_explictlyIgnoreFocus(){} // RVA: 0x7FFE879F3370
        public void get_shouldIgnoreFocus(){} // RVA: 0x7FFE879F33D0
        public void get_repeatRate(){} // RVA: 0x7FFE81124000
        public void set_repeatRate(){} // RVA: 0x7FFE81124010
        public void get_repeatDelay(){} // RVA: 0x7FFE81123FE0
        public void set_repeatDelay(){} // RVA: 0x7FFE81123FF0
        public void get_xrTrackingOrigin(){} // RVA: 0x7FFE81176D50
        public void set_xrTrackingOrigin(){} // RVA: 0x7FFE81176D60
        public void get_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7FFE8120BE10
        public void set_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7FFE81D5D9B0
        public void SwapAction(){} // RVA: 0x7FFE879F3490
        public void get_point(){} // RVA: 0x7FFE81463AE0
        public void set_point(){} // RVA: 0x7FFE879F39C0
        public void get_scrollWheel(){} // RVA: 0x7FFE81166040
        public void set_scrollWheel(){} // RVA: 0x7FFE879F3A00
        public void get_leftClick(){} // RVA: 0x7FFE817AE360
        public void set_leftClick(){} // RVA: 0x7FFE879F3A40
        public void get_middleClick(){} // RVA: 0x7FFE8179C860
        public void set_middleClick(){} // RVA: 0x7FFE879F3A80
        public void get_rightClick(){} // RVA: 0x7FFE817AB5E0
        public void set_rightClick(){} // RVA: 0x7FFE879F3AC0
        public void get_move(){} // RVA: 0x7FFE81280C30
        public void set_move(){} // RVA: 0x7FFE879F3B00
        public void get_submit(){} // RVA: 0x7FFE8113A010
        public void set_submit(){} // RVA: 0x7FFE879F3B40
        public void get_cancel(){} // RVA: 0x7FFE8154EB60
        public void set_cancel(){} // RVA: 0x7FFE879F3B80
        public void get_trackedDeviceOrientation(){} // RVA: 0x7FFE81166120
        public void set_trackedDeviceOrientation(){} // RVA: 0x7FFE879F3BC0
        public void get_trackedDevicePosition(){} // RVA: 0x7FFE811660B0
        public void set_trackedDevicePosition(){} // RVA: 0x7FFE879F3C00
        public void AssignDefaultActions(){} // RVA: 0x7FFE879F3C40
        public void UnassignActions(){} // RVA: 0x7FFE879F4770
        public void get_trackedDeviceSelect(){} // RVA: 0x7FFE879F4A50
        public void set_trackedDeviceSelect(){} // RVA: 0x7FFE879F4A90
        public void Awake(){} // RVA: 0x7FFE879F4AD0
        public void OnDestroy(){} // RVA: 0x7FFE879F4B30
        public void OnEnable(){} // RVA: 0x7FFE879F4B50
        public void OnDisable(){} // RVA: 0x7FFE879F4E10
        public void ResetPointers(){} // RVA: 0x7FFE879F4FA0
        public void HasNoActions(){} // RVA: 0x7FFE879F51A0
        public void EnableAllActions(){} // RVA: 0x7FFE879F5370
        public void DisableAllActions(){} // RVA: 0x7FFE879F5430
        public void EnableInputAction(){} // RVA: 0x7FFE879F5510
        public void TryDisableInputAction(){} // RVA: 0x7FFE879F5700
        public void GetPointerStateIndexFor(){} // RVA: 0x7FFE879F5CC0 | overloaded x3
        public void GetPointerStateForIndex(){} // RVA: 0x7FFE879F5B40
        public void GetDisplayIndexFor(){} // RVA: 0x7FFE879F5B90
        public void AllocatePointer(){} // RVA: 0x7FFE879F6820
        public void SendPointerExitEventsAndRemovePointer(){} // RVA: 0x7FFE879F6B40
        public void RemovePointerAtIndex(){} // RVA: 0x7FFE879F6D00
        public void PurgeStalePointers(){} // RVA: 0x7FFE879F7300
        public void HaveControlForDevice(){} // RVA: 0x7FFE879F7480
        public void OnPointCallback(){} // RVA: 0x7FFE879F7560
        public void IgnoreNextClick(){} // RVA: 0x7FFE879F7660
        public void OnLeftClickCallback(){} // RVA: 0x7FFE879F7790
        public void OnRightClickCallback(){} // RVA: 0x7FFE879F78C0
        public void OnMiddleClickCallback(){} // RVA: 0x7FFE879F7A00
        public void CheckForRemovedDevice(){} // RVA: 0x7FFE879F7B40
        public void OnScrollCallback(){} // RVA: 0x7FFE879F7BB0
        public void OnMoveCallback(){} // RVA: 0x7FFE879F7CF0
        public void OnSubmitCancelCallback(){} // RVA: 0x7FFE879F7E10
        public void OnTrackedDeviceOrientationCallback(){} // RVA: 0x7FFE879F7ED0
        public void OnTrackedDevicePositionCallback(){} // RVA: 0x7FFE879F8020
        public void OnControlsChanged(){} // RVA: 0x7FFE879F8170
        public void FilterPointerStatesByType(){} // RVA: 0x7FFE879F8180
        public void Process(){} // RVA: 0x7FFE879F8800
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7FFE879F8BF0
        public void HookActions(){} // RVA: 0x7FFE879F8D40
        public void UnhookActions(){} // RVA: 0x7FFE879F4B30
        public void SetActionCallbacks(){} // RVA: 0x7FFE879F92D0
        public void SetActionCallback(){} // RVA: 0x7FFE879F9450
        public void UpdateReferenceForNewAsset(){} // RVA: 0x7FFE879F9590
        public void get_actionsAsset(){} // RVA: 0x7FFE811C3590
        public void set_actionsAsset(){} // RVA: 0x7FFE879F9700
        public void get_sendPointerHoverToParent(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE879F9B00
        public void .cctor(){} // RVA: 0x7FFE879F9B40
    }

    public class MultiplayerEventSystem : EventSystem
    {
        public UnityEngine.GameObject m_PlayerRoot; // 0x60

        // ── Methods ──
        public void get_playerRoot(){} // RVA: 0x7FFE81199370
        public void set_playerRoot(){} // RVA: 0x7FFE879F9CA0
        public void OnEnable(){} // RVA: 0x7FFE879F9D00
        public void OnDisable(){} // RVA: 0x7FFE879F9E70
        public void InitializePlayerRoot(){} // RVA: 0x7FFE879F9E80
        public void Update(){} // RVA: 0x7FFE879FA060
        public void .ctor(){} // RVA: 0x7FFE879FA140
    }

    public class NavigationModel : ValueType
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE879FA280
    }

    public class PointerModel : ValueType
    {
        public bool changedThisFrame; // 0x10
        public ButtonState leftButton; // 0x18
        public ButtonState rightButton; // 0xB0
        public ButtonState middleButton; // 0x148
        public UnityEngine.InputSystem.UI.ExtendedPointerEventData eventData; // 0x1E0
        public UnityEngine.Vector2 m_ScreenPosition; // 0x1E8
        public UnityEngine.Vector2 m_ScrollDelta; // 0x1F0
        public UnityEngine.Vector3 m_WorldPosition; // 0x1F8
        public UnityEngine.Quaternion m_WorldOrientation; // 0x204
        public float m_Pressure; // 0x214

        // ── Methods ──
        public void get_pointerType(){} // RVA: 0x7FFE879FA2D0
        public void get_screenPosition(){} // RVA: 0x7FFE879FA300
        public void set_screenPosition(){} // RVA: 0x7FFE879FA320
        public void get_worldPosition(){} // RVA: 0x7FFE879FA370
        public void set_worldPosition(){} // RVA: 0x7FFE879FA390
        public void get_worldOrientation(){} // RVA: 0x7FFE879FA410
        public void set_worldOrientation(){} // RVA: 0x7FFE879FA420
        public void get_scrollDelta(){} // RVA: 0x7FFE879FA490
        public void set_scrollDelta(){} // RVA: 0x7FFE879FA4B0
        public void get_pressure(){} // RVA: 0x7FFE879FA500
        public void set_pressure(){} // RVA: 0x7FFE879FA510
        public void get_azimuthAngle(){} // RVA: 0x7FFE879FA530
        public void set_azimuthAngle(){} // RVA: 0x7FFE879FA540
        public void get_altitudeAngle(){} // RVA: 0x7FFE879FA560
        public void set_altitudeAngle(){} // RVA: 0x7FFE879FA570
        public void get_twist(){} // RVA: 0x7FFE879FA590
        public void set_twist(){} // RVA: 0x7FFE879FA5A0
        public void get_radius(){} // RVA: 0x7FFE879FA5C0
        public void set_radius(){} // RVA: 0x7FFE879FA5E0
        public void .ctor(){} // RVA: 0x7FFE879FA630
        public void OnFrameFinished(){} // RVA: 0x7FFE879FA7C0
        public void CopyTouchOrPenStateFrom(){} // RVA: 0x7FFE879FA840
    }

    public class SubmitCancelModel : ValueType
    {
    }

    public class TrackedDeviceRaycaster : BaseRaycaster
    {
        public System.Collections.Generic.List`1<RaycastHitData> m_RaycastResultsCache; // 0x28
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster> s_Instances;
        public System.Collections.Generic.List`1<RaycastHitData> s_SortedGraphics; // 0x18
        public bool m_IgnoreReversedGraphics; // 0x30
        public bool m_CheckFor2DOcclusion; // 0x31
        public bool m_CheckFor3DOcclusion; // 0x32
        public float m_MaxDistance; // 0x34

        // ── Methods ──
        public void get_eventCamera(){} // RVA: 0x7FFE879FAE00
        public void get_blockingMask(){} // RVA: 0x7FFE81D46090
        public void set_blockingMask(){} // RVA: 0x7FFE81D46A00
        public void get_checkFor3DOcclusion(){} // RVA: 0x7FFE848700A0
        public void set_checkFor3DOcclusion(){} // RVA: 0x7FFE866032C0
        public void get_checkFor2DOcclusion(){} // RVA: 0x7FFE81121470
        public void set_checkFor2DOcclusion(){} // RVA: 0x7FFE81121480
        public void get_ignoreReversedGraphics(){} // RVA: 0x7FFE81121450
        public void set_ignoreReversedGraphics(){} // RVA: 0x7FFE81121460
        public void get_maxDistance(){} // RVA: 0x7FFE811C5630
        public void set_maxDistance(){} // RVA: 0x7FFE811C5640
        public void OnEnable(){} // RVA: 0x7FFE879FAF20
        public void OnDisable(){} // RVA: 0x7FFE879FB0D0
        public void Raycast(){} // RVA: 0x7FFE879FB2F0
        public void PerformRaycast(){} // RVA: 0x7FFE879FB3A0
        public void SortedRaycastGraphics(){} // RVA: 0x7FFE879FBCA0
        public void RayIntersectsRectTransform(){} // RVA: 0x7FFE879FC3E0
        public void get_canvas(){} // RVA: 0x7FFE879FC960
        public void .ctor(){} // RVA: 0x7FFE879FCAA0
        public void .cctor(){} // RVA: 0x7FFE879FCB90
    }

    public class VirtualMouseInput : MonoBehaviour
    {
        public 0x66543F2C m_CursorMode; // 0x20
        public UnityEngine.UI.Graphic m_CursorGraphic; // 0x28
        public UnityEngine.RectTransform m_CursorTransform; // 0x30
        public float m_CursorSpeed; // 0x38
        public float m_ScrollSpeed; // 0x3C
        public UnityEngine.InputSystem.InputActionProperty m_StickAction; // 0x40
        public UnityEngine.InputSystem.InputActionProperty m_LeftButtonAction; // 0x58
        public UnityEngine.InputSystem.InputActionProperty m_MiddleButtonAction; // 0x70
        public UnityEngine.InputSystem.InputActionProperty m_RightButtonAction; // 0x88
        public UnityEngine.InputSystem.InputActionProperty m_ForwardButtonAction; // 0xA0
        public UnityEngine.InputSystem.InputActionProperty m_BackButtonAction; // 0xB8
        public UnityEngine.InputSystem.InputActionProperty m_ScrollWheelAction; // 0xD0
        public UnityEngine.Canvas m_Canvas; // 0xE8

        // ── Methods ──
        public void get_cursorTransform(){} // RVA: 0x7FFE8144E200
        public void set_cursorTransform(){} // RVA: 0x7FFE81129890
        public void get_cursorSpeed(){} // RVA: 0x7FFE8130ACF0
        public void set_cursorSpeed(){} // RVA: 0x7FFE8130A000
        public void get_cursorMode(){} // RVA: 0x7FFE8151D690
        public void set_cursorMode(){} // RVA: 0x7FFE879FCE90
        public void get_cursorGraphic(){} // RVA: 0x7FFE81129130
        public void set_cursorGraphic(){} // RVA: 0x7FFE879FD010
        public void get_scrollSpeed(){} // RVA: 0x7FFE8178C5D0
        public void set_scrollSpeed(){} // RVA: 0x7FFE8178C310
        public void get_virtualMouse(){} // RVA: 0x7FFE811662A0
        public void get_stickAction(){} // RVA: 0x7FFE81104E10
        public void set_stickAction(){} // RVA: 0x7FFE879FD120
        public void get_leftButtonAction(){} // RVA: 0x7FFE81104E50
        public void set_leftButtonAction(){} // RVA: 0x7FFE879FD150
        public void get_rightButtonAction(){} // RVA: 0x7FFE8621C7D0
        public void set_rightButtonAction(){} // RVA: 0x7FFE879FD300
        public void get_middleButtonAction(){} // RVA: 0x7FFE81104E90
        public void set_middleButtonAction(){} // RVA: 0x7FFE879FD4C0
        public void get_forwardButtonAction(){} // RVA: 0x7FFE8621C810
        public void set_forwardButtonAction(){} // RVA: 0x7FFE879FD670
        public void get_backButtonAction(){} // RVA: 0x7FFE8432DE70
        public void set_backButtonAction(){} // RVA: 0x7FFE879FD830
        public void get_scrollWheelAction(){} // RVA: 0x7FFE879FD9F0
        public void set_scrollWheelAction(){} // RVA: 0x7FFE879FDA10
        public void OnEnable(){} // RVA: 0x7FFE879FDA40
        public void OnDisable(){} // RVA: 0x7FFE879FE2E0
        public void TryFindCanvas(){} // RVA: 0x7FFE879FE830
        public void TryEnableHardwareCursor(){} // RVA: 0x7FFE879FE8D0
        public void UpdateMotion(){} // RVA: 0x7FFE879FEC60
        public void OnButtonActionTriggered(){} // RVA: 0x7FFE879FF160
        public void SetActionCallback(){} // RVA: 0x7FFE879FF3C0
        public void SetAction(){} // RVA: 0x7FFE879FF4F0
        public void OnAfterInputUpdate(){} // RVA: 0x7FFE879FF720
        public void .ctor(){} // RVA: 0x7FFE879FF730
    }

}