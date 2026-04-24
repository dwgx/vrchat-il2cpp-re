// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.UI
// Classes: 12
// Methods: 223

namespace ThirdParty.Unity.UnityEngine.InputSystem.UI
{
    public class BaseInputOverride : BaseInput
    {
        // ── Original Methods ──
        public void get_compositionString(){} // RVA: 0x7ffaa89600c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class ExtendedAxisEventData : AxisEventData
    {
        // ── Original Methods ──
        public void get_device(){} // RVA: 0x7ffaa8bfcc80
        public void set_device(){} // RVA: 0x7ffaa8960890
        public void .ctor(){} // RVA: 0x7ffaaf067b50
        public void ToString(){} // RVA: 0x7ffaaf067b60
    }

    public class ExtendedPointerEventData : PointerEventData
    {
        public object _touchId; // 0x33A8DE50, was: <touchId>k__BackingField
        public object _trackedDevicePosition; // 0x33A8DE50, was: <trackedDevicePosition>k__Back

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3b13a0
        public void get_control(){} // RVA: 0x7ffaa8f74160
        public void set_control(){} // RVA: 0x7ffaa8f2e920
        public void get_device(){} // RVA: 0x7ffaa8f6f0b0
        public void set_device(){} // RVA: 0x7ffaa8f2e8c0
        public void get_touchId(){} // RVA: 0x7ffaae435700
        public void set_touchId(){} // RVA: 0x7ffaaf067c40
        public void get_pointerType(){} // RVA: 0x7ffaaf067c50
        public void set_pointerType(){} // RVA: 0x7ffaaf067c60
        public void get_uiToolkitPointerId(){} // RVA: 0x7ffaaf067c70
        public void set_uiToolkitPointerId(){} // RVA: 0x7ffaaf067c80
        public void get_trackedDevicePosition(){} // RVA: 0x7ffaae666930
        public void set_trackedDevicePosition(){} // RVA: 0x7ffaae666950
        public void get_trackedDeviceOrientation(){} // RVA: 0x7ffaae666970
        public void set_trackedDeviceOrientation(){} // RVA: 0x7ffaae666980
        public void ToString(){} // RVA: 0x7ffaaf067c90
        public void MakePointerIdForTouch(){} // RVA: 0x7ffaaf0685b0
        public void TouchIdFromPointerId(){} // RVA: 0x7ffaa9e49950
        public void ReadDeviceState(){} // RVA: 0x7ffaaf0685c0
        // ── Binary Analysis Named ──
        public void GetPenPointerId(){} // RVA: 0x7ffaaf068980
        public void GetTouchPointerId(){} // RVA: 0x7ffaaf068c80
    }

    public class ExtendedSubmitCancelEventData : BaseEventData
    {
        // ── Original Methods ──
        public void get_device(){} // RVA: 0x7ffaa89600c0
        public void set_device(){} // RVA: 0x7ffaa89600d0
        public void .ctor(){} // RVA: 0x7ffaa8998e80
    }

    public class INavigationEventData
    {
        // ── Original Methods ──
        public void get_device(){} // RVA: 0x7ffaa86491d0
    }

    public class InputSystemUIInputModule : BaseInputModule
    {
        public object m_MoveRepeatRate; // 0x33348B70
        public object defaultActions; // 0x33348B70
        public object m_MoveAction; // 0x33348B70
        public object m_LeftClickAction; // 0x33348B70
        public object m_ScrollWheelAction; // 0x33348B70
        public object m_DeselectOnBackgroundClick; // 0x33348B70
        public object m_ScrollDeltaPerTick; // 0x33348B70
        public object m_NeedToPurgeStalePointers; // 0x33348B70
        public object m_OnSubmitCancelDelegate; // 0x33348B70
        public object m_OnMiddleClickDelegate; // 0x33348B70
        public object m_OnTrackedDeviceOrientationDelegate; // 0x33348B70
        public object m_CurrentPointerIndex; // 0x33348B70
        public object m_PointerStates; // 0x33348B70
        public object m_LocalMultiPlayerRoot; // 0x33348B70
        public object `Ǐf; // 0x66E2C491
        public object UnityEngine.InputSystem.Utilities; // 0xB40A7050

        // ── Original Methods ──
        public void get_deselectOnBackgroundClick(){} // RVA: 0x7ffaa9757e70
        public void set_deselectOnBackgroundClick(){} // RVA: 0x7ffaa975cbc0
        public void get_pointerBehavior(){} // RVA: 0x7ffaa9d2b2b0
        public void set_pointerBehavior(){} // RVA: 0x7ffaae2e83d0
        public void get_cursorLockBehavior(){} // RVA: 0x7ffaa90bdfd0
        public void set_cursorLockBehavior(){} // RVA: 0x7ffaa9fb8260
        public void get_localMultiPlayerRoot(){} // RVA: 0x7ffaa93fd0e0
        public void set_localMultiPlayerRoot(){} // RVA: 0x7ffaa93ebd00
        public void get_scrollDeltaPerTick(){} // RVA: 0x7ffaae2e8400
        public void set_scrollDeltaPerTick(){} // RVA: 0x7ffaae2e8410
        public void ActivateModule(){} // RVA: 0x7ffaaf068de0
        public void IsPointerOverGameObject(){} // RVA: 0x7ffaaf068f10
        public void PerformRaycast(){} // RVA: 0x7ffaaf069300
        public void ProcessPointer(){} // RVA: 0x7ffaaf069690
        public void PointerShouldIgnoreTransform(){} // RVA: 0x7ffaaf069d20
        public void ProcessPointerMovement(){} // RVA: 0x7ffaaf069f40
        public void ProcessPointerMovement(){} // RVA: 0x7ffaaf069f40
        public void ProcessPointerButton(){} // RVA: 0x7ffaaf06adf0
        public void ProcessPointerButtonDrag(){} // RVA: 0x7ffaaf06bb60
        public void ProcessPointerScroll(){} // RVA: 0x7ffaaf06bf60
        public void ProcessNavigation(){} // RVA: 0x7ffaaf06c060
        public void IsMoveAllowed(){} // RVA: 0x7ffaaf06c870
        public void get_moveRepeatDelay(){} // RVA: 0x7ffaa895afe0
        public void set_moveRepeatDelay(){} // RVA: 0x7ffaa895aff0
        public void get_moveRepeatRate(){} // RVA: 0x7ffaa895b000
        public void set_moveRepeatRate(){} // RVA: 0x7ffaa895b010
        public void get_explictlyIgnoreFocus(){} // RVA: 0x7ffaaf06cc10
        public void get_shouldIgnoreFocus(){} // RVA: 0x7ffaaf06cc70
        public void get_repeatRate(){} // RVA: 0x7ffaa895b000
        public void set_repeatRate(){} // RVA: 0x7ffaa895b010
        public void get_repeatDelay(){} // RVA: 0x7ffaa895afe0
        public void set_repeatDelay(){} // RVA: 0x7ffaa895aff0
        public void get_xrTrackingOrigin(){} // RVA: 0x7ffaa89add50
        public void set_xrTrackingOrigin(){} // RVA: 0x7ffaa89add60
        public void get_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7ffaa8a42e10
        public void set_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7ffaa9165910
        public void SwapAction(){} // RVA: 0x7ffaaf06cd30
        public void get_point(){} // RVA: 0x7ffaa8af68f0
        public void set_point(){} // RVA: 0x7ffaaf06d260
        public void get_scrollWheel(){} // RVA: 0x7ffaa899d040
        public void set_scrollWheel(){} // RVA: 0x7ffaaf06d2a0
        public void get_leftClick(){} // RVA: 0x7ffaa8f75d20
        public void set_leftClick(){} // RVA: 0x7ffaaf06d2e0
        public void get_middleClick(){} // RVA: 0x7ffaa8f78170
        public void set_middleClick(){} // RVA: 0x7ffaaf06d320
        public void get_rightClick(){} // RVA: 0x7ffaa8f74720
        public void set_rightClick(){} // RVA: 0x7ffaaf06d360
        public void get_move(){} // RVA: 0x7ffaa8d1a3b0
        public void set_move(){} // RVA: 0x7ffaaf06d3a0
        public void get_submit(){} // RVA: 0x7ffaa8971010
        public void set_submit(){} // RVA: 0x7ffaaf06d3e0
        public void get_cancel(){} // RVA: 0x7ffaa8d1b980
        public void set_cancel(){} // RVA: 0x7ffaaf06d420
        public void get_trackedDeviceOrientation(){} // RVA: 0x7ffaa899d120
        public void set_trackedDeviceOrientation(){} // RVA: 0x7ffaaf06d460
        public void get_trackedDevicePosition(){} // RVA: 0x7ffaa899d0b0
        public void set_trackedDevicePosition(){} // RVA: 0x7ffaaf06d4a0
        public void AssignDefaultActions(){} // RVA: 0x7ffaaf06d4e0
        public void UnassignActions(){} // RVA: 0x7ffaaf06e010
        public void get_trackedDeviceSelect(){} // RVA: 0x7ffaaf06e2f0
        public void set_trackedDeviceSelect(){} // RVA: 0x7ffaaf06e330
        public void Awake(){} // RVA: 0x7ffaaf06e370
        public void OnDestroy(){} // RVA: 0x7ffaaf06e3d0
        public void OnEnable(){} // RVA: 0x7ffaaf06e3f0
        public void OnDisable(){} // RVA: 0x7ffaaf06e6b0
        public void ResetPointers(){} // RVA: 0x7ffaaf06e840
        public void HasNoActions(){} // RVA: 0x7ffaaf06ea40
        public void EnableAllActions(){} // RVA: 0x7ffaaf06ec10
        public void DisableAllActions(){} // RVA: 0x7ffaaf06ecd0
        public void EnableInputAction(){} // RVA: 0x7ffaaf06edb0
        public void TryDisableInputAction(){} // RVA: 0x7ffaaf06efa0
        public void AllocatePointer(){} // RVA: 0x7ffaaf0700c0
        public void SendPointerExitEventsAndRemovePointer(){} // RVA: 0x7ffaaf0703e0
        public void RemovePointerAtIndex(){} // RVA: 0x7ffaaf0705a0
        public void PurgeStalePointers(){} // RVA: 0x7ffaaf070ba0
        public void HaveControlForDevice(){} // RVA: 0x7ffaaf070d20
        public void OnPointCallback(){} // RVA: 0x7ffaaf070e00
        public void IgnoreNextClick(){} // RVA: 0x7ffaaf070f00
        public void OnLeftClickCallback(){} // RVA: 0x7ffaaf071030
        public void OnRightClickCallback(){} // RVA: 0x7ffaaf071160
        public void OnMiddleClickCallback(){} // RVA: 0x7ffaaf0712a0
        public void OnScrollCallback(){} // RVA: 0x7ffaaf071450
        public void OnMoveCallback(){} // RVA: 0x7ffaaf071590
        public void OnSubmitCancelCallback(){} // RVA: 0x7ffaaf0716b0
        public void OnTrackedDeviceOrientationCallback(){} // RVA: 0x7ffaaf071770
        public void OnTrackedDevicePositionCallback(){} // RVA: 0x7ffaaf0718c0
        public void OnControlsChanged(){} // RVA: 0x7ffaaf071a10
        public void FilterPointerStatesByType(){} // RVA: 0x7ffaaf071a20
        public void Process(){} // RVA: 0x7ffaaf0720a0
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7ffaaf072490
        public void HookActions(){} // RVA: 0x7ffaaf0725e0
        public void UnhookActions(){} // RVA: 0x7ffaaf06e3d0
        public void UpdateReferenceForNewAsset(){} // RVA: 0x7ffaaf072e30
        public void get_actionsAsset(){} // RVA: 0x7ffaa89fa590
        public void set_actionsAsset(){} // RVA: 0x7ffaaf072fa0
        public void get_sendPointerHoverToParent(){} // RVA: 0x7ffaa8a17850
        public void .ctor(){} // RVA: 0x7ffaaf0733a0
        public void .cctor(){} // RVA: 0x7ffaaf0733e0
        // ── Binary Analysis Named ──
        public void GetLastRaycastResult(){} // RVA: 0x7ffaaf0691b0
        public void GetPointerStateIndexFor(){} // RVA: 0x7ffaaf06f560
        public void GetPointerStateForIndex(){} // RVA: 0x7ffaaf06f3e0
        public void GetDisplayIndexFor(){} // RVA: 0x7ffaaf06f430
        public void GetPointerStateIndexFor(){} // RVA: 0x7ffaaf06f560
        public void GetPointerStateIndexFor(){} // RVA: 0x7ffaaf06f560
        public void CheckForRemovedDevice(){} // RVA: 0x7ffaaf0713e0
        public void SetActionCallbacks(){} // RVA: 0x7ffaaf072b70
        public void SetActionCallback(){} // RVA: 0x7ffaaf072cf0
    }

    public class MultiplayerEventSystem : EventSystem
    {
        // ── Original Methods ──
        public void get_playerRoot(){} // RVA: 0x7ffaa89d0370
        public void set_playerRoot(){} // RVA: 0x7ffaaf073540
        public void OnEnable(){} // RVA: 0x7ffaaf0735a0
        public void OnDisable(){} // RVA: 0x7ffaaf073710
        public void InitializePlayerRoot(){} // RVA: 0x7ffaaf073720
        public void Update(){} // RVA: 0x7ffaaf073900
        public void .ctor(){} // RVA: 0x7ffaaf0739e0
    }

    public class NavigationModel : ValueType
    {
        public object lastMoveDirection; // 0x335E0030
        public object device; // 0x335E0030

        // ── Original Methods ──
        public void Reset(){} // RVA: 0x7ffaaf073b20
    }

    public class PointerModel : ValueType
    {
        public object rightButton; // 0x33C06D90
        public object m_ScreenPosition; // 0x33C06D90
        public object m_WorldOrientation; // 0x33C06D90
        public object m_AltitudeAngle; // 0x33C06D90
        public object m_IsPressed; // 0x34427E40
        public object m_PressRaycast; // 0x34427E40
        public object m_LastPressObject; // 0x34427E40

        // ── Original Methods ──
        public void get_pointerType(){} // RVA: 0x7ffaaf073b70
        public void get_screenPosition(){} // RVA: 0x7ffaaf073ba0
        public void set_screenPosition(){} // RVA: 0x7ffaaf073bc0
        public void get_worldPosition(){} // RVA: 0x7ffaaf073c10
        public void set_worldPosition(){} // RVA: 0x7ffaaf073c30
        public void get_worldOrientation(){} // RVA: 0x7ffaaf073cb0
        public void set_worldOrientation(){} // RVA: 0x7ffaaf073cc0
        public void get_scrollDelta(){} // RVA: 0x7ffaaf073d30
        public void set_scrollDelta(){} // RVA: 0x7ffaaf073d50
        public void get_pressure(){} // RVA: 0x7ffaaf073da0
        public void set_pressure(){} // RVA: 0x7ffaaf073db0
        public void get_azimuthAngle(){} // RVA: 0x7ffaaf073dd0
        public void set_azimuthAngle(){} // RVA: 0x7ffaaf073de0
        public void get_altitudeAngle(){} // RVA: 0x7ffaaf073e00
        public void set_altitudeAngle(){} // RVA: 0x7ffaaf073e10
        public void get_twist(){} // RVA: 0x7ffaaf073e30
        public void set_twist(){} // RVA: 0x7ffaaf073e40
        public void get_radius(){} // RVA: 0x7ffaa9713590
        public void set_radius(){} // RVA: 0x7ffaaf073e60
        public void .ctor(){} // RVA: 0x7ffaaf073eb0
        public void OnFrameFinished(){} // RVA: 0x7ffaaf074040
        public void CopyTouchOrPenStateFrom(){} // RVA: 0x7ffaaf0740c0
    }

    public class SubmitCancelModel : ValueType
    {
    }

    public class TrackedDeviceRaycaster : BaseRaycaster
    {
        public object s_SortedGraphics; // 0x33A36890
        public object m_CheckFor3DOcclusion; // 0x33A36890
        public object m_Canvas; // 0x33A36890

        // ── Original Methods ──
        public void get_eventCamera(){} // RVA: 0x7ffaaf074680
        public void get_blockingMask(){} // RVA: 0x7ffaa8fb82b0
        public void set_blockingMask(){} // RVA: 0x7ffaa8fb82c0
        public void get_checkFor3DOcclusion(){} // RVA: 0x7ffaabef8500
        public void set_checkFor3DOcclusion(){} // RVA: 0x7ffaadc7ab30
        public void get_checkFor2DOcclusion(){} // RVA: 0x7ffaa8958470
        public void set_checkFor2DOcclusion(){} // RVA: 0x7ffaa8958480
        public void get_ignoreReversedGraphics(){} // RVA: 0x7ffaa8958450
        public void set_ignoreReversedGraphics(){} // RVA: 0x7ffaa8958460
        public void get_maxDistance(){} // RVA: 0x7ffaa89fc630
        public void set_maxDistance(){} // RVA: 0x7ffaa89fc640
        public void OnEnable(){} // RVA: 0x7ffaaf0747a0
        public void OnDisable(){} // RVA: 0x7ffaaf074950
        public void Raycast(){} // RVA: 0x7ffaaf074b70
        public void PerformRaycast(){} // RVA: 0x7ffaaf074c20
        public void SortedRaycastGraphics(){} // RVA: 0x7ffaaf075520
        public void RayIntersectsRectTransform(){} // RVA: 0x7ffaaf075c60
        public void get_canvas(){} // RVA: 0x7ffaaf0761e0
        public void .ctor(){} // RVA: 0x7ffaaf076320
        public void .cctor(){} // RVA: 0x7ffaaf076410
    }

    public class VirtualMouseInput : MonoBehaviour
    {
        public object m_CursorTransform; // 0x33666080
        public object m_StickAction; // 0x33666080
        public object m_RightButtonAction; // 0x33666080
        public object m_ScrollWheelAction; // 0x33666080
        public object m_SystemMouse; // 0x33666080
        public object m_LastTime; // 0x33666080

        // ── Original Methods ──
        public void get_cursorTransform(){} // RVA: 0x7ffaa8bfcc80
        public void set_cursorTransform(){} // RVA: 0x7ffaa8960890
        public void get_cursorSpeed(){} // RVA: 0x7ffaa9144a40
        public void set_cursorSpeed(){} // RVA: 0x7ffaa9144ae0
        public void get_cursorMode(){} // RVA: 0x7ffaa8aeced0
        public void set_cursorMode(){} // RVA: 0x7ffaaf076710
        public void get_cursorGraphic(){} // RVA: 0x7ffaa8960130
        public void set_cursorGraphic(){} // RVA: 0x7ffaaf076890
        public void get_scrollSpeed(){} // RVA: 0x7ffaa9068340
        public void set_scrollSpeed(){} // RVA: 0x7ffaa9068080
        public void get_virtualMouse(){} // RVA: 0x7ffaa899d2a0
        public void get_stickAction(){} // RVA: 0x7ffaa893be10
        public void set_stickAction(){} // RVA: 0x7ffaaf0769a0
        public void get_leftButtonAction(){} // RVA: 0x7ffaa893be50
        public void set_leftButtonAction(){} // RVA: 0x7ffaaf0769d0
        public void get_rightButtonAction(){} // RVA: 0x7ffaad82dd70
        public void set_rightButtonAction(){} // RVA: 0x7ffaaf076b80
        public void get_middleButtonAction(){} // RVA: 0x7ffaa893be90
        public void set_middleButtonAction(){} // RVA: 0x7ffaaf076d40
        public void get_forwardButtonAction(){} // RVA: 0x7ffaad82ddb0
        public void set_forwardButtonAction(){} // RVA: 0x7ffaaf076ef0
        public void get_backButtonAction(){} // RVA: 0x7ffaab9e4340
        public void set_backButtonAction(){} // RVA: 0x7ffaaf0770b0
        public void get_scrollWheelAction(){} // RVA: 0x7ffaaf077270
        public void set_scrollWheelAction(){} // RVA: 0x7ffaaf077290
        public void OnEnable(){} // RVA: 0x7ffaaf0772c0
        public void OnDisable(){} // RVA: 0x7ffaaf077b60
        public void TryFindCanvas(){} // RVA: 0x7ffaaf0780b0
        public void TryEnableHardwareCursor(){} // RVA: 0x7ffaaf078150
        public void UpdateMotion(){} // RVA: 0x7ffaaf0784e0
        public void OnButtonActionTriggered(){} // RVA: 0x7ffaaf0789e0
        public void OnAfterInputUpdate(){} // RVA: 0x7ffaaf078fa0
        public void .ctor(){} // RVA: 0x7ffaaf078fb0
        // ── Binary Analysis Named ──
        public void SetActionCallback(){} // RVA: 0x7ffaaf078c40
        public void SetAction(){} // RVA: 0x7ffaaf078d70
    }

}