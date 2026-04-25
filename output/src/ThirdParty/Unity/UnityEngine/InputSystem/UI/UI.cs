// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.UI
// Classes: 12
// Methods: 223

namespace ThirdParty.Unity.UnityEngine.InputSystem.UI
{
    public class BaseInputOverride : BaseInput
    {
        public string compositionString; // 0x20

        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class ExtendedAxisEventData : AxisEventData
    {
        public UnityEngine.InputSystem.InputDevice device; // 0x30

        // ── Methods ──
        public void get_device(){} // RVA: 0x7FFAC31D95E0
        public void set_device(){} // RVA: 0x7FFAC2F4F890
        public void .ctor(){} // RVA: 0x7FFAC9645B70
        public void ToString(){} // RVA: 0x7FFAC9645B80
    }

    public class ExtendedPointerEventData : PointerEventData
    {
        public UnityEngine.InputSystem.InputControl control; // 0x180
        public UnityEngine.InputSystem.InputDevice device; // 0x188
        public int touchId; // 0x190
        public 0x6B14AAE0 pointerType; // 0x194
        public int uiToolkitPointerId; // 0x198
        public UnityEngine.Vector3 trackedDevicePosition; // 0x19C
        public UnityEngine.Quaternion trackedDeviceOrientation; // 0x1A8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8990190
        public void get_control(){} // RVA: 0x7FFAC354B1B0
        public void set_control(){} // RVA: 0x7FFAC3503070
        public void get_device(){} // RVA: 0x7FFAC35410C0
        public void set_device(){} // RVA: 0x7FFAC3503010
        public void get_touchId(){} // RVA: 0x7FFAC8A144E0
        public void set_touchId(){} // RVA: 0x7FFAC9645C60
        public void get_pointerType(){} // RVA: 0x7FFAC9645C70
        public void set_pointerType(){} // RVA: 0x7FFAC9645C80
        public void get_uiToolkitPointerId(){} // RVA: 0x7FFAC9645C90
        public void set_uiToolkitPointerId(){} // RVA: 0x7FFAC9645CA0
        public void get_trackedDevicePosition(){} // RVA: 0x7FFAC8C449D0
        public void set_trackedDevicePosition(){} // RVA: 0x7FFAC8C449F0
        public void get_trackedDeviceOrientation(){} // RVA: 0x7FFAC8C44A10
        public void set_trackedDeviceOrientation(){} // RVA: 0x7FFAC8C44A20
        public void ToString(){} // RVA: 0x7FFAC9645CB0
        public void MakePointerIdForTouch(){} // RVA: 0x7FFAC96465D0
        public void TouchIdFromPointerId(){} // RVA: 0x7FFAC4422930
        public void ReadDeviceState(){} // RVA: 0x7FFAC96465E0
        public void GetPenPointerId(){} // RVA: 0x7FFAC96469A0
        public void GetTouchPointerId(){} // RVA: 0x7FFAC9646CA0
    }

    public class ExtendedSubmitCancelEventData : BaseEventData
    {
        public UnityEngine.InputSystem.InputDevice device; // 0x20

        // ── Methods ──
        public void get_device(){} // RVA: 0x7FFAC2F4F0C0
        public void set_device(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
    }

    public class INavigationEventData
    {
        public object device;

        // ── Methods ──
        public void get_device(){} // RVA: 0x7FFAC2C58E90
    }

    public class InputSystemUIInputModule : BaseInputModule
    {
        public float deselectOnBackgroundClick;
        public float pointerBehavior; // 0x58
        public float cursorLockBehavior; // 0x5C
        public float localMultiPlayerRoot; // 0x60
        public UnityEngine.Transform scrollDeltaPerTick; // 0x68
        public UnityEngine.InputSystem.DefaultInputActions moveRepeatDelay;
        public UnityEngine.InputSystem.InputActionAsset moveRepeatRate; // 0x70
        public UnityEngine.InputSystem.InputActionReference explictlyIgnoreFocus; // 0x78
        public UnityEngine.InputSystem.InputActionReference shouldIgnoreFocus; // 0x80
        public UnityEngine.InputSystem.InputActionReference repeatRate; // 0x88
        public UnityEngine.InputSystem.InputActionReference repeatDelay; // 0x90
        public UnityEngine.InputSystem.InputActionReference xrTrackingOrigin; // 0x98
        public UnityEngine.InputSystem.InputActionReference trackedDeviceDragThresholdMultiplier; // 0xA0
        public UnityEngine.InputSystem.InputActionReference point; // 0xA8
        public UnityEngine.InputSystem.InputActionReference scrollWheel; // 0xB0
        public UnityEngine.InputSystem.InputActionReference leftClick; // 0xB8
        public UnityEngine.InputSystem.InputActionReference middleClick; // 0xC0
        public bool rightClick; // 0xC8
        public 0x6B14AB38 move; // 0xCC
        public 0x6B14AC98 submit; // 0xD0
        public float cancel; // 0xD4
        public System.Collections.Generic.Dictionary`2<UnityEngine.InputSystem.InputAction,InputActionReferenceState> trackedDeviceOrientation; // 0x8
        public bool trackedDevicePosition; // 0xD8
        public bool trackedDeviceSelect; // 0xD9
        public System.Action`1<CallbackContext> actionsAsset; // 0xE0
        public System.Action`1<CallbackContext> sendPointerHoverToParent; // 0xE8
        public System.Action`1<CallbackContext> m_OnSubmitCancelDelegate; // 0xF0
        public System.Action`1<CallbackContext> m_OnLeftClickDelegate; // 0xF8
        public System.Action`1<CallbackContext> m_OnRightClickDelegate; // 0x100
        public System.Action`1<CallbackContext> m_OnMiddleClickDelegate; // 0x108
        public System.Action`1<CallbackContext> m_OnScrollWheelDelegate; // 0x110
        public System.Action`1<CallbackContext> m_OnTrackedDevicePositionDelegate; // 0x118
        public System.Action`1<CallbackContext> m_OnTrackedDeviceOrientationDelegate; // 0x120
        public System.Action`1<object> m_OnControlsChangedDelegate; // 0x128
        public int m_CurrentPointerId; // 0x130
        public int m_CurrentPointerIndex; // 0x134
        public 0x6B14AAE0 m_CurrentPointerType; // 0x138
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<int> m_PointerIds; // 0x140
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.PointerModel> m_PointerStates; // 0x150
        public UnityEngine.InputSystem.UI.NavigationModel m_NavigationState; // 0x380
        public UnityEngine.InputSystem.UI.SubmitCancelModel m_SubmitCancelState; // 0x3A8
        public UnityEngine.GameObject m_LocalMultiPlayerRoot; // 0x3B8

        // ── Methods ──
        public void get_deselectOnBackgroundClick(){} // RVA: 0x7FFAC3D2B010
        public void set_deselectOnBackgroundClick(){} // RVA: 0x7FFAC3D23EE0
        public void get_pointerBehavior(){} // RVA: 0x7FFAC43065A0
        public void set_pointerBehavior(){} // RVA: 0x7FFAC88C71C0
        public void get_cursorLockBehavior(){} // RVA: 0x7FFAC3696B20
        public void set_cursorLockBehavior(){} // RVA: 0x7FFAC4591C30
        public void get_localMultiPlayerRoot(){} // RVA: 0x7FFAC39ACDA0
        public void set_localMultiPlayerRoot(){} // RVA: 0x7FFAC39B7300
        public void get_scrollDeltaPerTick(){} // RVA: 0x7FFAC88C71F0
        public void set_scrollDeltaPerTick(){} // RVA: 0x7FFAC88C7200
        public void ActivateModule(){} // RVA: 0x7FFAC9646E00
        public void IsPointerOverGameObject(){} // RVA: 0x7FFAC9646F30
        public void GetLastRaycastResult(){} // RVA: 0x7FFAC96471D0
        public void PerformRaycast(){} // RVA: 0x7FFAC9647320
        public void ProcessPointer(){} // RVA: 0x7FFAC96476B0
        public void PointerShouldIgnoreTransform(){} // RVA: 0x7FFAC9647D40
        public void ProcessPointerMovement(){} // RVA: 0x7FFAC9647F60 | overloaded x2
        public void ProcessPointerButton(){} // RVA: 0x7FFAC9648E10
        public void ProcessPointerButtonDrag(){} // RVA: 0x7FFAC9649B80
        public void ProcessPointerScroll(){} // RVA: 0x7FFAC9649F80
        public void ProcessNavigation(){} // RVA: 0x7FFAC964A080
        public void IsMoveAllowed(){} // RVA: 0x7FFAC964A890
        public void get_moveRepeatDelay(){} // RVA: 0x7FFAC2F49FE0
        public void set_moveRepeatDelay(){} // RVA: 0x7FFAC2F49FF0
        public void get_moveRepeatRate(){} // RVA: 0x7FFAC2F4A000
        public void set_moveRepeatRate(){} // RVA: 0x7FFAC2F4A010
        public void get_explictlyIgnoreFocus(){} // RVA: 0x7FFAC964AC30
        public void get_shouldIgnoreFocus(){} // RVA: 0x7FFAC964AC90
        public void get_repeatRate(){} // RVA: 0x7FFAC2F4A000
        public void set_repeatRate(){} // RVA: 0x7FFAC2F4A010
        public void get_repeatDelay(){} // RVA: 0x7FFAC2F49FE0
        public void set_repeatDelay(){} // RVA: 0x7FFAC2F49FF0
        public void get_xrTrackingOrigin(){} // RVA: 0x7FFAC2F9CD50
        public void set_xrTrackingOrigin(){} // RVA: 0x7FFAC2F9CD60
        public void get_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7FFAC3031E10
        public void set_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7FFAC3735550
        public void SwapAction(){} // RVA: 0x7FFAC964AD50
        public void get_point(){} // RVA: 0x7FFAC30E5600
        public void set_point(){} // RVA: 0x7FFAC964B280
        public void get_scrollWheel(){} // RVA: 0x7FFAC2F8C040
        public void set_scrollWheel(){} // RVA: 0x7FFAC964B2C0
        public void get_leftClick(){} // RVA: 0x7FFAC354DFB0
        public void set_leftClick(){} // RVA: 0x7FFAC964B300
        public void get_middleClick(){} // RVA: 0x7FFAC3543900
        public void set_middleClick(){} // RVA: 0x7FFAC964B340
        public void get_rightClick(){} // RVA: 0x7FFAC354B1A0
        public void set_rightClick(){} // RVA: 0x7FFAC964B380
        public void get_move(){} // RVA: 0x7FFAC32EF410
        public void set_move(){} // RVA: 0x7FFAC964B3C0
        public void get_submit(){} // RVA: 0x7FFAC2F60010
        public void set_submit(){} // RVA: 0x7FFAC964B400
        public void get_cancel(){} // RVA: 0x7FFAC32EF640
        public void set_cancel(){} // RVA: 0x7FFAC964B440
        public void get_trackedDeviceOrientation(){} // RVA: 0x7FFAC2F8C120
        public void set_trackedDeviceOrientation(){} // RVA: 0x7FFAC964B480
        public void get_trackedDevicePosition(){} // RVA: 0x7FFAC2F8C0B0
        public void set_trackedDevicePosition(){} // RVA: 0x7FFAC964B4C0
        public void AssignDefaultActions(){} // RVA: 0x7FFAC964B500
        public void UnassignActions(){} // RVA: 0x7FFAC964C030
        public void get_trackedDeviceSelect(){} // RVA: 0x7FFAC964C310
        public void set_trackedDeviceSelect(){} // RVA: 0x7FFAC964C350
        public void Awake(){} // RVA: 0x7FFAC964C390
        public void OnDestroy(){} // RVA: 0x7FFAC964C3F0
        public void OnEnable(){} // RVA: 0x7FFAC964C410
        public void OnDisable(){} // RVA: 0x7FFAC964C6D0
        public void ResetPointers(){} // RVA: 0x7FFAC964C860
        public void HasNoActions(){} // RVA: 0x7FFAC964CA60
        public void EnableAllActions(){} // RVA: 0x7FFAC964CC30
        public void DisableAllActions(){} // RVA: 0x7FFAC964CCF0
        public void EnableInputAction(){} // RVA: 0x7FFAC964CDD0
        public void TryDisableInputAction(){} // RVA: 0x7FFAC964CFC0
        public void GetPointerStateIndexFor(){} // RVA: 0x7FFAC964D580 | overloaded x3
        public void GetPointerStateForIndex(){} // RVA: 0x7FFAC964D400
        public void GetDisplayIndexFor(){} // RVA: 0x7FFAC964D450
        public void AllocatePointer(){} // RVA: 0x7FFAC964E0E0
        public void SendPointerExitEventsAndRemovePointer(){} // RVA: 0x7FFAC964E400
        public void RemovePointerAtIndex(){} // RVA: 0x7FFAC964E5C0
        public void PurgeStalePointers(){} // RVA: 0x7FFAC964EBC0
        public void HaveControlForDevice(){} // RVA: 0x7FFAC964ED40
        public void OnPointCallback(){} // RVA: 0x7FFAC964EE20
        public void IgnoreNextClick(){} // RVA: 0x7FFAC964EF20
        public void OnLeftClickCallback(){} // RVA: 0x7FFAC964F050
        public void OnRightClickCallback(){} // RVA: 0x7FFAC964F180
        public void OnMiddleClickCallback(){} // RVA: 0x7FFAC964F2C0
        public void CheckForRemovedDevice(){} // RVA: 0x7FFAC964F400
        public void OnScrollCallback(){} // RVA: 0x7FFAC964F470
        public void OnMoveCallback(){} // RVA: 0x7FFAC964F5B0
        public void OnSubmitCancelCallback(){} // RVA: 0x7FFAC964F6D0
        public void OnTrackedDeviceOrientationCallback(){} // RVA: 0x7FFAC964F790
        public void OnTrackedDevicePositionCallback(){} // RVA: 0x7FFAC964F8E0
        public void OnControlsChanged(){} // RVA: 0x7FFAC964FA30
        public void FilterPointerStatesByType(){} // RVA: 0x7FFAC964FA40
        public void Process(){} // RVA: 0x7FFAC96500C0
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7FFAC96504B0
        public void HookActions(){} // RVA: 0x7FFAC9650600
        public void UnhookActions(){} // RVA: 0x7FFAC964C3F0
        public void SetActionCallbacks(){} // RVA: 0x7FFAC9650B90
        public void SetActionCallback(){} // RVA: 0x7FFAC9650D10
        public void UpdateReferenceForNewAsset(){} // RVA: 0x7FFAC9650E50
        public void get_actionsAsset(){} // RVA: 0x7FFAC2FE9590
        public void set_actionsAsset(){} // RVA: 0x7FFAC9650FC0
        public void get_sendPointerHoverToParent(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC96513C0
        public void .cctor(){} // RVA: 0x7FFAC9651400
    }

    public class MultiplayerEventSystem : EventSystem
    {
        public UnityEngine.GameObject playerRoot; // 0x60

        // ── Methods ──
        public void get_playerRoot(){} // RVA: 0x7FFAC2FBF370
        public void set_playerRoot(){} // RVA: 0x7FFAC9651560
        public void OnEnable(){} // RVA: 0x7FFAC96515C0
        public void OnDisable(){} // RVA: 0x7FFAC9651730
        public void InitializePlayerRoot(){} // RVA: 0x7FFAC9651740
        public void Update(){} // RVA: 0x7FFAC9651920
        public void .ctor(){} // RVA: 0x7FFAC9651A00
    }

    public class NavigationModel : ValueType
    {
        public UnityEngine.Vector2 move; // 0x10
        public int consecutiveMoveCount; // 0x18
        public 0x6B24CCB0 lastMoveDirection; // 0x1C
        public float lastMoveTime; // 0x20
        public UnityEngine.EventSystems.AxisEventData eventData; // 0x28
        public UnityEngine.InputSystem.InputDevice device; // 0x30

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC9651B40
    }

    public class PointerModel : ValueType
    {
        public bool pointerType; // 0x10
        public ButtonState screenPosition; // 0x18
        public ButtonState worldPosition; // 0xB0
        public ButtonState worldOrientation; // 0x148
        public UnityEngine.InputSystem.UI.ExtendedPointerEventData scrollDelta; // 0x1E0
        public UnityEngine.Vector2 pressure; // 0x1E8
        public UnityEngine.Vector2 azimuthAngle; // 0x1F0
        public UnityEngine.Vector3 altitudeAngle; // 0x1F8
        public UnityEngine.Quaternion twist; // 0x204
        public float radius; // 0x214
        public float m_AzimuthAngle; // 0x218
        public float m_AltitudeAngle; // 0x21C
        public float m_Twist; // 0x220
        public UnityEngine.Vector2 m_Radius; // 0x224

        // ── Methods ──
        public void get_pointerType(){} // RVA: 0x7FFAC9651B90
        public void get_screenPosition(){} // RVA: 0x7FFAC9651BC0
        public void set_screenPosition(){} // RVA: 0x7FFAC9651BE0
        public void get_worldPosition(){} // RVA: 0x7FFAC9651C30
        public void set_worldPosition(){} // RVA: 0x7FFAC9651C50
        public void get_worldOrientation(){} // RVA: 0x7FFAC9651CD0
        public void set_worldOrientation(){} // RVA: 0x7FFAC9651CE0
        public void get_scrollDelta(){} // RVA: 0x7FFAC9651D50
        public void set_scrollDelta(){} // RVA: 0x7FFAC9651D70
        public void get_pressure(){} // RVA: 0x7FFAC9651DC0
        public void set_pressure(){} // RVA: 0x7FFAC9651DD0
        public void get_azimuthAngle(){} // RVA: 0x7FFAC9651DF0
        public void set_azimuthAngle(){} // RVA: 0x7FFAC9651E00
        public void get_altitudeAngle(){} // RVA: 0x7FFAC9651E20
        public void set_altitudeAngle(){} // RVA: 0x7FFAC9651E30
        public void get_twist(){} // RVA: 0x7FFAC9651E50
        public void set_twist(){} // RVA: 0x7FFAC9651E60
        public void get_radius(){} // RVA: 0x7FFAC3CF4C00
        public void set_radius(){} // RVA: 0x7FFAC9651E80
        public void .ctor(){} // RVA: 0x7FFAC9651ED0
        public void OnFrameFinished(){} // RVA: 0x7FFAC9652060
        public void CopyTouchOrPenStateFrom(){} // RVA: 0x7FFAC96520E0
    }

    public class SubmitCancelModel : ValueType
    {
        public UnityEngine.EventSystems.BaseEventData eventData; // 0x10
        public UnityEngine.InputSystem.InputDevice device; // 0x18
    }

    public class TrackedDeviceRaycaster : BaseRaycaster
    {
        public System.Collections.Generic.List`1<RaycastHitData> eventCamera; // 0x28
        public UnityEngine.InputSystem.Utilities.InlinedArray`1<UnityEngine.InputSystem.UI.TrackedDeviceRaycaster> blockingMask;
        public System.Collections.Generic.List`1<RaycastHitData> checkFor3DOcclusion; // 0x18
        public bool checkFor2DOcclusion; // 0x30
        public bool ignoreReversedGraphics; // 0x31
        public bool maxDistance; // 0x32
        public float canvas; // 0x34
        public UnityEngine.LayerMask m_BlockingMask; // 0x38
        public UnityEngine.Canvas m_Canvas; // 0x40

        // ── Methods ──
        public void get_eventCamera(){} // RVA: 0x7FFAC96526A0
        public void get_blockingMask(){} // RVA: 0x7FFAC358A870
        public void set_blockingMask(){} // RVA: 0x7FFAC3588350
        public void get_checkFor3DOcclusion(){} // RVA: 0x7FFAC64EB050
        public void set_checkFor3DOcclusion(){} // RVA: 0x7FFAC8259980
        public void get_checkFor2DOcclusion(){} // RVA: 0x7FFAC2F47470
        public void set_checkFor2DOcclusion(){} // RVA: 0x7FFAC2F47480
        public void get_ignoreReversedGraphics(){} // RVA: 0x7FFAC2F47450
        public void set_ignoreReversedGraphics(){} // RVA: 0x7FFAC2F47460
        public void get_maxDistance(){} // RVA: 0x7FFAC2FEB630
        public void set_maxDistance(){} // RVA: 0x7FFAC2FEB640
        public void OnEnable(){} // RVA: 0x7FFAC96527C0
        public void OnDisable(){} // RVA: 0x7FFAC9652970
        public void Raycast(){} // RVA: 0x7FFAC9652B90
        public void PerformRaycast(){} // RVA: 0x7FFAC9652C40
        public void SortedRaycastGraphics(){} // RVA: 0x7FFAC9653540
        public void RayIntersectsRectTransform(){} // RVA: 0x7FFAC9653C80
        public void get_canvas(){} // RVA: 0x7FFAC9654200
        public void .ctor(){} // RVA: 0x7FFAC9654340
        public void .cctor(){} // RVA: 0x7FFAC9654430
    }

    public class VirtualMouseInput : MonoBehaviour
    {
        public 0x6B14B008 cursorTransform; // 0x20
        public UnityEngine.UI.Graphic cursorSpeed; // 0x28
        public UnityEngine.RectTransform cursorMode; // 0x30
        public float cursorGraphic; // 0x38
        public float scrollSpeed; // 0x3C
        public UnityEngine.InputSystem.InputActionProperty virtualMouse; // 0x40
        public UnityEngine.InputSystem.InputActionProperty stickAction; // 0x58
        public UnityEngine.InputSystem.InputActionProperty leftButtonAction; // 0x70
        public UnityEngine.InputSystem.InputActionProperty rightButtonAction; // 0x88
        public UnityEngine.InputSystem.InputActionProperty middleButtonAction; // 0xA0
        public UnityEngine.InputSystem.InputActionProperty forwardButtonAction; // 0xB8
        public UnityEngine.InputSystem.InputActionProperty backButtonAction; // 0xD0
        public UnityEngine.Canvas scrollWheelAction; // 0xE8
        public UnityEngine.InputSystem.Mouse m_VirtualMouse; // 0xF0
        public UnityEngine.InputSystem.Mouse m_SystemMouse; // 0xF8
        public System.Action m_AfterInputUpdateDelegate; // 0x100
        public System.Action`1<CallbackContext> m_ButtonActionTriggeredDelegate; // 0x108
        public double m_LastTime; // 0x110
        public UnityEngine.Vector2 m_LastStickValue; // 0x118

        // ── Methods ──
        public void get_cursorTransform(){} // RVA: 0x7FFAC31D95E0
        public void set_cursorTransform(){} // RVA: 0x7FFAC2F4F890
        public void get_cursorSpeed(){} // RVA: 0x7FFAC3716E90
        public void set_cursorSpeed(){} // RVA: 0x7FFAC3717190
        public void get_cursorMode(){} // RVA: 0x7FFAC30DBBE0
        public void set_cursorMode(){} // RVA: 0x7FFAC9654730
        public void get_cursorGraphic(){} // RVA: 0x7FFAC2F4F130
        public void set_cursorGraphic(){} // RVA: 0x7FFAC96548B0
        public void get_scrollSpeed(){} // RVA: 0x7FFAC363CE20
        public void set_scrollSpeed(){} // RVA: 0x7FFAC363C6C0
        public void get_virtualMouse(){} // RVA: 0x7FFAC2F8C2A0
        public void get_stickAction(){} // RVA: 0x7FFAC2F2AE10
        public void set_stickAction(){} // RVA: 0x7FFAC96549C0
        public void get_leftButtonAction(){} // RVA: 0x7FFAC2F2AE50
        public void set_leftButtonAction(){} // RVA: 0x7FFAC96549F0
        public void get_rightButtonAction(){} // RVA: 0x7FFAC7DF9410
        public void set_rightButtonAction(){} // RVA: 0x7FFAC9654BA0
        public void get_middleButtonAction(){} // RVA: 0x7FFAC2F2AE90
        public void set_middleButtonAction(){} // RVA: 0x7FFAC9654D60
        public void get_forwardButtonAction(){} // RVA: 0x7FFAC7DF9450
        public void set_forwardButtonAction(){} // RVA: 0x7FFAC9654F10
        public void get_backButtonAction(){} // RVA: 0x7FFAC5FD37F0
        public void set_backButtonAction(){} // RVA: 0x7FFAC96550D0
        public void get_scrollWheelAction(){} // RVA: 0x7FFAC9655290
        public void set_scrollWheelAction(){} // RVA: 0x7FFAC96552B0
        public void OnEnable(){} // RVA: 0x7FFAC96552E0
        public void OnDisable(){} // RVA: 0x7FFAC9655B80
        public void TryFindCanvas(){} // RVA: 0x7FFAC96560D0
        public void TryEnableHardwareCursor(){} // RVA: 0x7FFAC9656170
        public void UpdateMotion(){} // RVA: 0x7FFAC9656500
        public void OnButtonActionTriggered(){} // RVA: 0x7FFAC9656A00
        public void SetActionCallback(){} // RVA: 0x7FFAC9656C60
        public void SetAction(){} // RVA: 0x7FFAC9656D90
        public void OnAfterInputUpdate(){} // RVA: 0x7FFAC9656FC0
        public void .ctor(){} // RVA: 0x7FFAC9656FD0
    }

}