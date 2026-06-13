// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.UI
// Classes: 12
// Methods: 223

namespace ThirdParty.Unity.UnityEngine.InputSystem.UI
{
    public class BaseInputOverride
    {
        public string <compositionString>k__BackingField; // 0x20

        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class ExtendedAxisEventData
    {
        public UnityEngine.InputSystem.InputDevice <device>k__BackingField; // 0x30

        // ── Methods ──
        public void get_device(){} // RVA: 0x6374D0
        public void set_device(){} // RVA: 0x30B890
        public void .ctor(){} // RVA: 0x6EAD420
        public void ToString(){} // RVA: 0x6EAD430
    }

    public class ExtendedPointerEventData
    {
        public UnityEngine.InputSystem.InputControl <control>k__BackingField; // 0x180
        public UnityEngine.InputSystem.InputDevice <device>k__BackingField; // 0x188
        public int <touchId>k__BackingField; // 0x190
        public 0x6586BB50 <pointerType>k__BackingField; // 0x194
        public int <uiToolkitPointerId>k__BackingField; // 0x198
        public UnityEngine.Vector3 <trackedDevicePosition>k__BackingField; // 0x19C
        public UnityEngine.Quaternion <trackedDeviceOrientation>k__BackingField; // 0x1A8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x61F8980
        public void get_control(){} // RVA: 0xDA5BB0
        public void set_control(){} // RVA: 0xD87C10
        public void get_device(){} // RVA: 0xD83B50
        public void set_device(){} // RVA: 0xD9F550
        public void get_touchId(){} // RVA: 0x627D130
        public void set_touchId(){} // RVA: 0x6EAD510
        public void get_pointerType(){} // RVA: 0x6EAD520
        public void set_pointerType(){} // RVA: 0x6EAD530
        public void get_uiToolkitPointerId(){} // RVA: 0x6EAD540
        public void set_uiToolkitPointerId(){} // RVA: 0x6EAD550
        public void get_trackedDevicePosition(){} // RVA: 0x64ADE40
        public void set_trackedDevicePosition(){} // RVA: 0x64ADE60
        public void get_trackedDeviceOrientation(){} // RVA: 0x64ADE80
        public void set_trackedDeviceOrientation(){} // RVA: 0x64ADE90
        public void ToString(){} // RVA: 0x6EAD560
        public void MakePointerIdForTouch(){} // RVA: 0x6EADE80
        public void TouchIdFromPointerId(){} // RVA: 0x196A350
        public void ReadDeviceState(){} // RVA: 0x6EADE90
        public void GetPenPointerId(){} // RVA: 0x6EAE250
        public void GetTouchPointerId(){} // RVA: 0x6EAE550
    }

    public class ExtendedSubmitCancelEventData
    {
        public UnityEngine.InputSystem.InputDevice <device>k__BackingField; // 0x20

        // ── Methods ──
        public void get_device(){} // RVA: 0x30B0C0
        public void set_device(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x343E80
    }

    public class INavigationEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0xCD60
    }

    public class InputSystemUIInputModule
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
        public 0x6586BBA8 m_PointerBehavior; // 0xCC
        public 0x6586BD08 m_CursorLockBehavior; // 0xD0
        public float m_ScrollDeltaPerTick; // 0xD4
        public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.InputAction,InputActionReferenceState> s_InputActionReferenceCounts; // 0x8
        public bool m_ActionsHooked; // 0xD8
        public bool m_NeedToPurgeStalePointers; // 0xD9
        public System.Action`1<CallbackContext> m_OnPointDelegate; // 0xE0
        public System.Action`1<CallbackContext> m_OnMoveDelegate; // 0xE8

        // ── Methods ──
        public void get_deselectOnBackgroundClick(){} // RVA: 0x126AF80
        public void set_deselectOnBackgroundClick(){} // RVA: 0x126BEE0
        public void get_pointerBehavior(){} // RVA: 0x1884A40
        public void set_pointerBehavior(){} // RVA: 0x612FAE0
        public void get_cursorLockBehavior(){} // RVA: 0xA50BB0
        public void set_cursorLockBehavior(){} // RVA: 0x1AE7FE0
        public void get_localMultiPlayerRoot(){} // RVA: 0xD93580
        public void set_localMultiPlayerRoot(){} // RVA: 0xD90A40
        public void get_scrollDeltaPerTick(){} // RVA: 0x612FB10
        public void set_scrollDeltaPerTick(){} // RVA: 0x11CDB70
        public void ActivateModule(){} // RVA: 0x6EAE6B0
        public void IsPointerOverGameObject(){} // RVA: 0x6EAE7E0
        public void GetLastRaycastResult(){} // RVA: 0x6EAEA80
        public void PerformRaycast(){} // RVA: 0x6EAEBD0
        public void ProcessPointer(){} // RVA: 0x6EAEF60
        public void PointerShouldIgnoreTransform(){} // RVA: 0x6EAF5F0
        public void ProcessPointerMovement(){} // RVA: 0x6EAF810 | overloaded x2
        public void ProcessPointerButton(){} // RVA: 0x6EB06C0
        public void ProcessPointerButtonDrag(){} // RVA: 0x6EB1430
        public void ProcessPointerScroll(){} // RVA: 0x6EB1830
        public void ProcessNavigation(){} // RVA: 0x6EB1930
        public void IsMoveAllowed(){} // RVA: 0x6EB2140
        public void get_moveRepeatDelay(){} // RVA: 0x305FE0
        public void set_moveRepeatDelay(){} // RVA: 0x305FF0
        public void get_moveRepeatRate(){} // RVA: 0x306000
        public void set_moveRepeatRate(){} // RVA: 0x306010
        public void get_explictlyIgnoreFocus(){} // RVA: 0x6EB24E0
        public void get_shouldIgnoreFocus(){} // RVA: 0x6EB2540
        public void get_repeatRate(){} // RVA: 0x306000
        public void set_repeatRate(){} // RVA: 0x306010
        public void get_repeatDelay(){} // RVA: 0x305FE0
        public void set_repeatDelay(){} // RVA: 0x305FF0
        public void get_xrTrackingOrigin(){} // RVA: 0x358D50
        public void set_xrTrackingOrigin(){} // RVA: 0x358D60
        public void get_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x3EDE10
        public void set_trackedDeviceDragThresholdMultiplier(){} // RVA: 0xFBC3A0
        public void SwapAction(){} // RVA: 0x6EB2600
        public void get_point(){} // RVA: 0x4C7C50
        public void set_point(){} // RVA: 0x6EB2B30
        public void get_scrollWheel(){} // RVA: 0x348040
        public void set_scrollWheel(){} // RVA: 0x6EB2B70
        public void get_leftClick(){} // RVA: 0xA1C8C0
        public void set_leftClick(){} // RVA: 0x6EB2BB0
        public void get_middleClick(){} // RVA: 0xA085E0
        public void set_middleClick(){} // RVA: 0x6EB2BF0
        public void get_rightClick(){} // RVA: 0xA1C130
        public void set_rightClick(){} // RVA: 0x6EB2C30
        public void get_move(){} // RVA: 0x462D00
        public void set_move(){} // RVA: 0x6EB2C70
        public void get_submit(){} // RVA: 0x31C010
        public void set_submit(){} // RVA: 0x6EB2CB0
        public void get_cancel(){} // RVA: 0x796DE0
        public void set_cancel(){} // RVA: 0x6EB2CF0
        public void get_trackedDeviceOrientation(){} // RVA: 0x348120
        public void set_trackedDeviceOrientation(){} // RVA: 0x6EB2D30
        public void get_trackedDevicePosition(){} // RVA: 0x3480B0
        public void set_trackedDevicePosition(){} // RVA: 0x6EB2D70
        public void AssignDefaultActions(){} // RVA: 0x6EB2DB0
        public void UnassignActions(){} // RVA: 0x6EB38E0
        public void get_trackedDeviceSelect(){} // RVA: 0x6EB3BC0
        public void set_trackedDeviceSelect(){} // RVA: 0x6EB3C00
        public void Awake(){} // RVA: 0x6EB3C40
        public void OnDestroy(){} // RVA: 0x6EB3CA0
        public void OnEnable(){} // RVA: 0x6EB3CC0
        public void OnDisable(){} // RVA: 0x6EB3F80
        public void ResetPointers(){} // RVA: 0x6EB4110
        public void HasNoActions(){} // RVA: 0x6EB4310
        public void EnableAllActions(){} // RVA: 0x6EB44E0
        public void DisableAllActions(){} // RVA: 0x6EB45A0
        public void EnableInputAction(){} // RVA: 0x6EB4680
        public void TryDisableInputAction(){} // RVA: 0x6EB4870
        public void GetPointerStateIndexFor(){} // RVA: 0x6EB4E30 | overloaded x3
        public void GetPointerStateForIndex(){} // RVA: 0x6EB4CB0
        public void GetDisplayIndexFor(){} // RVA: 0x6EB4D00
        public void AllocatePointer(){} // RVA: 0x6EB5990
        public void SendPointerExitEventsAndRemovePointer(){} // RVA: 0x6EB5CB0
        public void RemovePointerAtIndex(){} // RVA: 0x6EB5E70
        public void PurgeStalePointers(){} // RVA: 0x6EB6470
        public void HaveControlForDevice(){} // RVA: 0x6EB65F0
        public void OnPointCallback(){} // RVA: 0x6EB66D0
        public void IgnoreNextClick(){} // RVA: 0x6EB67D0
        public void OnLeftClickCallback(){} // RVA: 0x6EB6900
        public void OnRightClickCallback(){} // RVA: 0x6EB6A30
        public void OnMiddleClickCallback(){} // RVA: 0x6EB6B70
        public void CheckForRemovedDevice(){} // RVA: 0x6EB6CB0
        public void OnScrollCallback(){} // RVA: 0x6EB6D20
        public void OnMoveCallback(){} // RVA: 0x6EB6E60
        public void OnSubmitCancelCallback(){} // RVA: 0x6EB6F80
        public void OnTrackedDeviceOrientationCallback(){} // RVA: 0x6EB7040
        public void OnTrackedDevicePositionCallback(){} // RVA: 0x6EB7190
        public void OnControlsChanged(){} // RVA: 0x6EB72E0
        public void FilterPointerStatesByType(){} // RVA: 0x6EB72F0
        public void Process(){} // RVA: 0x6EB7970
        public void ConvertUIToolkitPointerId(){} // RVA: 0x6EB7D60
        public void HookActions(){} // RVA: 0x6EB7EB0
        public void UnhookActions(){} // RVA: 0x6EB3CA0
        public void SetActionCallbacks(){} // RVA: 0x6EB8440
        public void SetActionCallback(){} // RVA: 0x6EB85C0
        public void UpdateReferenceForNewAsset(){} // RVA: 0x6EB8700
        public void get_actionsAsset(){} // RVA: 0x3A5590
        public void set_actionsAsset(){} // RVA: 0x6EB8870
        public void get_sendPointerHoverToParent(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x6EB8C70
        public void .cctor(){} // RVA: 0x6EB8CB0
    }

    public class MultiplayerEventSystem
    {
        public UnityEngine.GameObject m_PlayerRoot; // 0x60

        // ── Methods ──
        public void get_playerRoot(){} // RVA: 0x37B370
        public void set_playerRoot(){} // RVA: 0x6EB8E10
        public void OnEnable(){} // RVA: 0x6EB8E70
        public void OnDisable(){} // RVA: 0x6EB8FE0
        public void InitializePlayerRoot(){} // RVA: 0x6EB8FF0
        public void Update(){} // RVA: 0x6EB91D0
        public void .ctor(){} // RVA: 0x6EB92B0
    }

    public class NavigationModel
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x6EB93F0
    }

    public class PointerModel
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
        public void get_pointerType(){} // RVA: 0x6EB9440
        public void get_screenPosition(){} // RVA: 0x6EB9470
        public void set_screenPosition(){} // RVA: 0x6EB9490
        public void get_worldPosition(){} // RVA: 0x6EB94E0
        public void set_worldPosition(){} // RVA: 0x6EB9500
        public void get_worldOrientation(){} // RVA: 0x6EB9580
        public void set_worldOrientation(){} // RVA: 0x6EB9590
        public void get_scrollDelta(){} // RVA: 0x6EB9600
        public void set_scrollDelta(){} // RVA: 0x6EB9620
        public void get_pressure(){} // RVA: 0x6EB9670
        public void set_pressure(){} // RVA: 0x6EB9680
        public void get_azimuthAngle(){} // RVA: 0x6EB96A0
        public void set_azimuthAngle(){} // RVA: 0x6EB96B0
        public void get_altitudeAngle(){} // RVA: 0x6EB96D0
        public void set_altitudeAngle(){} // RVA: 0x6EB96E0
        public void get_twist(){} // RVA: 0x6EB9700
        public void set_twist(){} // RVA: 0x6EB9710
        public void get_radius(){} // RVA: 0x6EB9730
        public void set_radius(){} // RVA: 0x6EB9750
        public void .ctor(){} // RVA: 0x6EB97A0
        public void OnFrameFinished(){} // RVA: 0x6EB9930
        public void CopyTouchOrPenStateFrom(){} // RVA: 0x6EB99B0
    }

    public class SubmitCancelModel
    {
    }

    public class TrackedDeviceRaycaster
    {
        public System.Collections.Generic.List`1<RaycastHitData> m_RaycastResultsCache; // 0x28
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster> s_Instances;
        public System.Collections.Generic.List`1<RaycastHitData> s_SortedGraphics; // 0x18
        public bool m_IgnoreReversedGraphics; // 0x30
        public bool m_CheckFor2DOcclusion; // 0x31
        public bool m_CheckFor3DOcclusion; // 0x32
        public float m_MaxDistance; // 0x34

        // ── Methods ──
        public void get_eventCamera(){} // RVA: 0x6EB9F70
        public void get_blockingMask(){} // RVA: 0xFDC9F0
        public void set_blockingMask(){} // RVA: 0xFDD6E0
        public void get_checkFor3DOcclusion(){} // RVA: 0x3BE7520
        public void set_checkFor3DOcclusion(){} // RVA: 0x5AC2490
        public void get_checkFor2DOcclusion(){} // RVA: 0x303470
        public void set_checkFor2DOcclusion(){} // RVA: 0x303480
        public void get_ignoreReversedGraphics(){} // RVA: 0x303450
        public void set_ignoreReversedGraphics(){} // RVA: 0x303460
        public void get_maxDistance(){} // RVA: 0x3A7630
        public void set_maxDistance(){} // RVA: 0x3A7640
        public void OnEnable(){} // RVA: 0x6EBA090
        public void OnDisable(){} // RVA: 0x6EBA240
        public void Raycast(){} // RVA: 0x6EBA460
        public void PerformRaycast(){} // RVA: 0x6EBA510
        public void SortedRaycastGraphics(){} // RVA: 0x6EBAE10
        public void RayIntersectsRectTransform(){} // RVA: 0x6EBB550
        public void get_canvas(){} // RVA: 0x6EBBAD0
        public void .ctor(){} // RVA: 0x6EBBC10
        public void .cctor(){} // RVA: 0x6EBBD00
    }

    public class VirtualMouseInput
    {
        public 0x6586C078 m_CursorMode; // 0x20
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
        public void get_cursorTransform(){} // RVA: 0x6374D0
        public void set_cursorTransform(){} // RVA: 0x30B890
        public void get_cursorSpeed(){} // RVA: 0x4FE250
        public void set_cursorSpeed(){} // RVA: 0x4FB970
        public void get_cursorMode(){} // RVA: 0x760030
        public void set_cursorMode(){} // RVA: 0x6EBC000
        public void get_cursorGraphic(){} // RVA: 0x30B130
        public void set_cursorGraphic(){} // RVA: 0x6EBC180
        public void get_scrollSpeed(){} // RVA: 0x9FC6D0
        public void set_scrollSpeed(){} // RVA: 0x9FC6C0
        public void get_virtualMouse(){} // RVA: 0x3482A0
        public void get_stickAction(){} // RVA: 0x2E6E10
        public void set_stickAction(){} // RVA: 0x6EBC290
        public void get_leftButtonAction(){} // RVA: 0x2E6E50
        public void set_leftButtonAction(){} // RVA: 0x6EBC2C0
        public void get_rightButtonAction(){} // RVA: 0x576C010
        public void set_rightButtonAction(){} // RVA: 0x6EBC470
        public void get_middleButtonAction(){} // RVA: 0x2E6E90
        public void set_middleButtonAction(){} // RVA: 0x6EBC630
        public void get_forwardButtonAction(){} // RVA: 0x576C050
        public void set_forwardButtonAction(){} // RVA: 0x6EBC7E0
        public void get_backButtonAction(){} // RVA: 0x36A9440
        public void set_backButtonAction(){} // RVA: 0x6EBC9A0
        public void get_scrollWheelAction(){} // RVA: 0x6EBCB60
        public void set_scrollWheelAction(){} // RVA: 0x6EBCB80
        public void OnEnable(){} // RVA: 0x6EBCBB0
        public void OnDisable(){} // RVA: 0x6EBD450
        public void TryFindCanvas(){} // RVA: 0x6EBD9A0
        public void TryEnableHardwareCursor(){} // RVA: 0x6EBDA40
        public void UpdateMotion(){} // RVA: 0x6EBDDD0
        public void OnButtonActionTriggered(){} // RVA: 0x6EBE2D0
        public void SetActionCallback(){} // RVA: 0x6EBE530
        public void SetAction(){} // RVA: 0x6EBE660
        public void OnAfterInputUpdate(){} // RVA: 0x6EBE890
        public void .ctor(){} // RVA: 0x6EBE8A0
    }

}