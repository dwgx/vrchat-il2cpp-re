// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.UI
// Classes: 12
// Methods: 223

namespace ThirdParty.Unity.UnityEngine.InputSystem.UI
{
    public class BaseInputOverride
    {
        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class ExtendedAxisEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0x7FFAF30E74D0
        public void set_device(){} // RVA: 0x7FFAF2DBB890
        public void .ctor(){} // RVA: 0x7FFAF995D420
        public void ToString(){} // RVA: 0x7FFAF995D430
    }

    public class ExtendedPointerEventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CA8980
        public void get_control(){} // RVA: 0x7FFAF3855BB0
        public void set_control(){} // RVA: 0x7FFAF3837C10
        public void get_device(){} // RVA: 0x7FFAF3833B50
        public void set_device(){} // RVA: 0x7FFAF384F550
        public void get_touchId(){} // RVA: 0x7FFAF8D2D130
        public void set_touchId(){} // RVA: 0x7FFAF995D510
        public void get_pointerType(){} // RVA: 0x7FFAF995D520
        public void set_pointerType(){} // RVA: 0x7FFAF995D530
        public void get_uiToolkitPointerId(){} // RVA: 0x7FFAF995D540
        public void set_uiToolkitPointerId(){} // RVA: 0x7FFAF995D550
        public void get_trackedDevicePosition(){} // RVA: 0x7FFAF8F5DE40
        public void set_trackedDevicePosition(){} // RVA: 0x7FFAF8F5DE60
        public void get_trackedDeviceOrientation(){} // RVA: 0x7FFAF8F5DE80
        public void set_trackedDeviceOrientation(){} // RVA: 0x7FFAF8F5DE90
        public void ToString(){} // RVA: 0x7FFAF995D560
        public void MakePointerIdForTouch(){} // RVA: 0x7FFAF995DE80
        public void TouchIdFromPointerId(){} // RVA: 0x7FFAF441A350
        public void ReadDeviceState(){} // RVA: 0x7FFAF995DE90
        public void GetPenPointerId(){} // RVA: 0x7FFAF995E250
        public void GetTouchPointerId(){} // RVA: 0x7FFAF995E550
    }

    public class ExtendedSubmitCancelEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0x7FFAF2DBB0C0
        public void set_device(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80
    }

    public class INavigationEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0x7FFAF2ABCD60
    }

    public class InputSystemUIInputModule
    {
        // ── Methods ──
        public void get_deselectOnBackgroundClick(){} // RVA: 0x7FFAF3D1AF80
        public void set_deselectOnBackgroundClick(){} // RVA: 0x7FFAF3D1BEE0
        public void get_pointerBehavior(){} // RVA: 0x7FFAF4334A40
        public void set_pointerBehavior(){} // RVA: 0x7FFAF8BDFAE0
        public void get_cursorLockBehavior(){} // RVA: 0x7FFAF3500BB0
        public void set_cursorLockBehavior(){} // RVA: 0x7FFAF4597FE0
        public void get_localMultiPlayerRoot(){} // RVA: 0x7FFAF3843580
        public void set_localMultiPlayerRoot(){} // RVA: 0x7FFAF3840A40
        public void get_scrollDeltaPerTick(){} // RVA: 0x7FFAF8BDFB10
        public void set_scrollDeltaPerTick(){} // RVA: 0x7FFAF3C7DB70
        public void ActivateModule(){} // RVA: 0x7FFAF995E6B0
        public void IsPointerOverGameObject(){} // RVA: 0x7FFAF995E7E0
        public void GetLastRaycastResult(){} // RVA: 0x7FFAF995EA80
        public void PerformRaycast(){} // RVA: 0x7FFAF995EBD0
        public void ProcessPointer(){} // RVA: 0x7FFAF995EF60
        public void PointerShouldIgnoreTransform(){} // RVA: 0x7FFAF995F5F0
        public void ProcessPointerMovement(){} // RVA: 0x7FFAF995F810 | overloaded x2
        public void ProcessPointerButton(){} // RVA: 0x7FFAF99606C0
        public void ProcessPointerButtonDrag(){} // RVA: 0x7FFAF9961430
        public void ProcessPointerScroll(){} // RVA: 0x7FFAF9961830
        public void ProcessNavigation(){} // RVA: 0x7FFAF9961930
        public void IsMoveAllowed(){} // RVA: 0x7FFAF9962140
        public void get_moveRepeatDelay(){} // RVA: 0x7FFAF2DB5FE0
        public void set_moveRepeatDelay(){} // RVA: 0x7FFAF2DB5FF0
        public void get_moveRepeatRate(){} // RVA: 0x7FFAF2DB6000
        public void set_moveRepeatRate(){} // RVA: 0x7FFAF2DB6010
        public void get_explictlyIgnoreFocus(){} // RVA: 0x7FFAF99624E0
        public void get_shouldIgnoreFocus(){} // RVA: 0x7FFAF9962540
        public void get_repeatRate(){} // RVA: 0x7FFAF2DB6000
        public void set_repeatRate(){} // RVA: 0x7FFAF2DB6010
        public void get_repeatDelay(){} // RVA: 0x7FFAF2DB5FE0
        public void set_repeatDelay(){} // RVA: 0x7FFAF2DB5FF0
        public void get_xrTrackingOrigin(){} // RVA: 0x7FFAF2E08D50
        public void set_xrTrackingOrigin(){} // RVA: 0x7FFAF2E08D60
        public void get_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7FFAF2E9DE10
        public void set_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7FFAF3A6C3A0
        public void SwapAction(){} // RVA: 0x7FFAF9962600
        public void get_point(){} // RVA: 0x7FFAF2F77C50
        public void set_point(){} // RVA: 0x7FFAF9962B30
        public void get_scrollWheel(){} // RVA: 0x7FFAF2DF8040
        public void set_scrollWheel(){} // RVA: 0x7FFAF9962B70
        public void get_leftClick(){} // RVA: 0x7FFAF34CC8C0
        public void set_leftClick(){} // RVA: 0x7FFAF9962BB0
        public void get_middleClick(){} // RVA: 0x7FFAF34B85E0
        public void set_middleClick(){} // RVA: 0x7FFAF9962BF0
        public void get_rightClick(){} // RVA: 0x7FFAF34CC130
        public void set_rightClick(){} // RVA: 0x7FFAF9962C30
        public void get_move(){} // RVA: 0x7FFAF2F12D00
        public void set_move(){} // RVA: 0x7FFAF9962C70
        public void get_submit(){} // RVA: 0x7FFAF2DCC010
        public void set_submit(){} // RVA: 0x7FFAF9962CB0
        public void get_cancel(){} // RVA: 0x7FFAF3246DE0
        public void set_cancel(){} // RVA: 0x7FFAF9962CF0
        public void get_trackedDeviceOrientation(){} // RVA: 0x7FFAF2DF8120
        public void set_trackedDeviceOrientation(){} // RVA: 0x7FFAF9962D30
        public void get_trackedDevicePosition(){} // RVA: 0x7FFAF2DF80B0
        public void set_trackedDevicePosition(){} // RVA: 0x7FFAF9962D70
        public void AssignDefaultActions(){} // RVA: 0x7FFAF9962DB0
        public void UnassignActions(){} // RVA: 0x7FFAF99638E0
        public void get_trackedDeviceSelect(){} // RVA: 0x7FFAF9963BC0
        public void set_trackedDeviceSelect(){} // RVA: 0x7FFAF9963C00
        public void Awake(){} // RVA: 0x7FFAF9963C40
        public void OnDestroy(){} // RVA: 0x7FFAF9963CA0
        public void OnEnable(){} // RVA: 0x7FFAF9963CC0
        public void OnDisable(){} // RVA: 0x7FFAF9963F80
        public void ResetPointers(){} // RVA: 0x7FFAF9964110
        public void HasNoActions(){} // RVA: 0x7FFAF9964310
        public void EnableAllActions(){} // RVA: 0x7FFAF99644E0
        public void DisableAllActions(){} // RVA: 0x7FFAF99645A0
        public void EnableInputAction(){} // RVA: 0x7FFAF9964680
        public void TryDisableInputAction(){} // RVA: 0x7FFAF9964870
        public void GetPointerStateIndexFor(){} // RVA: 0x7FFAF9964E30 | overloaded x3
        public void GetPointerStateForIndex(){} // RVA: 0x7FFAF9964CB0
        public void GetDisplayIndexFor(){} // RVA: 0x7FFAF9964D00
        public void AllocatePointer(){} // RVA: 0x7FFAF9965990
        public void SendPointerExitEventsAndRemovePointer(){} // RVA: 0x7FFAF9965CB0
        public void RemovePointerAtIndex(){} // RVA: 0x7FFAF9965E70
        public void PurgeStalePointers(){} // RVA: 0x7FFAF9966470
        public void HaveControlForDevice(){} // RVA: 0x7FFAF99665F0
        public void OnPointCallback(){} // RVA: 0x7FFAF99666D0
        public void IgnoreNextClick(){} // RVA: 0x7FFAF99667D0
        public void OnLeftClickCallback(){} // RVA: 0x7FFAF9966900
        public void OnRightClickCallback(){} // RVA: 0x7FFAF9966A30
        public void OnMiddleClickCallback(){} // RVA: 0x7FFAF9966B70
        public void CheckForRemovedDevice(){} // RVA: 0x7FFAF9966CB0
        public void OnScrollCallback(){} // RVA: 0x7FFAF9966D20
        public void OnMoveCallback(){} // RVA: 0x7FFAF9966E60
        public void OnSubmitCancelCallback(){} // RVA: 0x7FFAF9966F80
        public void OnTrackedDeviceOrientationCallback(){} // RVA: 0x7FFAF9967040
        public void OnTrackedDevicePositionCallback(){} // RVA: 0x7FFAF9967190
        public void OnControlsChanged(){} // RVA: 0x7FFAF99672E0
        public void FilterPointerStatesByType(){} // RVA: 0x7FFAF99672F0
        public void Process(){} // RVA: 0x7FFAF9967970
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7FFAF9967D60
        public void HookActions(){} // RVA: 0x7FFAF9967EB0
        public void UnhookActions(){} // RVA: 0x7FFAF9963CA0
        public void SetActionCallbacks(){} // RVA: 0x7FFAF9968440
        public void SetActionCallback(){} // RVA: 0x7FFAF99685C0
        public void UpdateReferenceForNewAsset(){} // RVA: 0x7FFAF9968700
        public void get_actionsAsset(){} // RVA: 0x7FFAF2E55590
        public void set_actionsAsset(){} // RVA: 0x7FFAF9968870
        public void get_sendPointerHoverToParent(){} // RVA: 0x7FFAF2E72850
        public void .ctor(){} // RVA: 0x7FFAF9968C70
        public void .cctor(){} // RVA: 0x7FFAF9968CB0
    }

    public class MultiplayerEventSystem
    {
        // ── Methods ──
        public void get_playerRoot(){} // RVA: 0x7FFAF2E2B370
        public void set_playerRoot(){} // RVA: 0x7FFAF9968E10
        public void OnEnable(){} // RVA: 0x7FFAF9968E70
        public void OnDisable(){} // RVA: 0x7FFAF9968FE0
        public void InitializePlayerRoot(){} // RVA: 0x7FFAF9968FF0
        public void Update(){} // RVA: 0x7FFAF99691D0
        public void .ctor(){} // RVA: 0x7FFAF99692B0
    }

    public class NavigationModel
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF99693F0
    }

    public class PointerModel
    {
        // ── Methods ──
        public void get_pointerType(){} // RVA: 0x7FFAF9969440
        public void get_screenPosition(){} // RVA: 0x7FFAF9969470
        public void set_screenPosition(){} // RVA: 0x7FFAF9969490
        public void get_worldPosition(){} // RVA: 0x7FFAF99694E0
        public void set_worldPosition(){} // RVA: 0x7FFAF9969500
        public void get_worldOrientation(){} // RVA: 0x7FFAF9969580
        public void set_worldOrientation(){} // RVA: 0x7FFAF9969590
        public void get_scrollDelta(){} // RVA: 0x7FFAF9969600
        public void set_scrollDelta(){} // RVA: 0x7FFAF9969620
        public void get_pressure(){} // RVA: 0x7FFAF9969670
        public void set_pressure(){} // RVA: 0x7FFAF9969680
        public void get_azimuthAngle(){} // RVA: 0x7FFAF99696A0
        public void set_azimuthAngle(){} // RVA: 0x7FFAF99696B0
        public void get_altitudeAngle(){} // RVA: 0x7FFAF99696D0
        public void set_altitudeAngle(){} // RVA: 0x7FFAF99696E0
        public void get_twist(){} // RVA: 0x7FFAF9969700
        public void set_twist(){} // RVA: 0x7FFAF9969710
        public void get_radius(){} // RVA: 0x7FFAF9969730
        public void set_radius(){} // RVA: 0x7FFAF9969750
        public void .ctor(){} // RVA: 0x7FFAF99697A0
        public void OnFrameFinished(){} // RVA: 0x7FFAF9969930
        public void CopyTouchOrPenStateFrom(){} // RVA: 0x7FFAF99699B0
    }

    public class SubmitCancelModel
    {
    }

    public class TrackedDeviceRaycaster
    {
        // ── Methods ──
        public void get_eventCamera(){} // RVA: 0x7FFAF9969F70
        public void get_blockingMask(){} // RVA: 0x7FFAF3A8C9F0
        public void set_blockingMask(){} // RVA: 0x7FFAF3A8D6E0
        public void get_checkFor3DOcclusion(){} // RVA: 0x7FFAF6697520
        public void set_checkFor3DOcclusion(){} // RVA: 0x7FFAF8572490
        public void get_checkFor2DOcclusion(){} // RVA: 0x7FFAF2DB3470
        public void set_checkFor2DOcclusion(){} // RVA: 0x7FFAF2DB3480
        public void get_ignoreReversedGraphics(){} // RVA: 0x7FFAF2DB3450
        public void set_ignoreReversedGraphics(){} // RVA: 0x7FFAF2DB3460
        public void get_maxDistance(){} // RVA: 0x7FFAF2E57630
        public void set_maxDistance(){} // RVA: 0x7FFAF2E57640
        public void OnEnable(){} // RVA: 0x7FFAF996A090
        public void OnDisable(){} // RVA: 0x7FFAF996A240
        public void Raycast(){} // RVA: 0x7FFAF996A460
        public void PerformRaycast(){} // RVA: 0x7FFAF996A510
        public void SortedRaycastGraphics(){} // RVA: 0x7FFAF996AE10
        public void RayIntersectsRectTransform(){} // RVA: 0x7FFAF996B550
        public void get_canvas(){} // RVA: 0x7FFAF996BAD0
        public void .ctor(){} // RVA: 0x7FFAF996BC10
        public void .cctor(){} // RVA: 0x7FFAF996BD00
    }

    public class VirtualMouseInput
    {
        // ── Methods ──
        public void get_cursorTransform(){} // RVA: 0x7FFAF30E74D0
        public void set_cursorTransform(){} // RVA: 0x7FFAF2DBB890
        public void get_cursorSpeed(){} // RVA: 0x7FFAF2FAE250
        public void set_cursorSpeed(){} // RVA: 0x7FFAF2FAB970
        public void get_cursorMode(){} // RVA: 0x7FFAF3210030
        public void set_cursorMode(){} // RVA: 0x7FFAF996C000
        public void get_cursorGraphic(){} // RVA: 0x7FFAF2DBB130
        public void set_cursorGraphic(){} // RVA: 0x7FFAF996C180
        public void get_scrollSpeed(){} // RVA: 0x7FFAF34AC6D0
        public void set_scrollSpeed(){} // RVA: 0x7FFAF34AC6C0
        public void get_virtualMouse(){} // RVA: 0x7FFAF2DF82A0
        public void get_stickAction(){} // RVA: 0x7FFAF2D96E10
        public void set_stickAction(){} // RVA: 0x7FFAF996C290
        public void get_leftButtonAction(){} // RVA: 0x7FFAF2D96E50
        public void set_leftButtonAction(){} // RVA: 0x7FFAF996C2C0
        public void get_rightButtonAction(){} // RVA: 0x7FFAF821C010
        public void set_rightButtonAction(){} // RVA: 0x7FFAF996C470
        public void get_middleButtonAction(){} // RVA: 0x7FFAF2D96E90
        public void set_middleButtonAction(){} // RVA: 0x7FFAF996C630
        public void get_forwardButtonAction(){} // RVA: 0x7FFAF821C050
        public void set_forwardButtonAction(){} // RVA: 0x7FFAF996C7E0
        public void get_backButtonAction(){} // RVA: 0x7FFAF6159440
        public void set_backButtonAction(){} // RVA: 0x7FFAF996C9A0
        public void get_scrollWheelAction(){} // RVA: 0x7FFAF996CB60
        public void set_scrollWheelAction(){} // RVA: 0x7FFAF996CB80
        public void OnEnable(){} // RVA: 0x7FFAF996CBB0
        public void OnDisable(){} // RVA: 0x7FFAF996D450
        public void TryFindCanvas(){} // RVA: 0x7FFAF996D9A0
        public void TryEnableHardwareCursor(){} // RVA: 0x7FFAF996DA40
        public void UpdateMotion(){} // RVA: 0x7FFAF996DDD0
        public void OnButtonActionTriggered(){} // RVA: 0x7FFAF996E2D0
        public void SetActionCallback(){} // RVA: 0x7FFAF996E530
        public void SetAction(){} // RVA: 0x7FFAF996E660
        public void OnAfterInputUpdate(){} // RVA: 0x7FFAF996E890
        public void .ctor(){} // RVA: 0x7FFAF996E8A0
    }

}