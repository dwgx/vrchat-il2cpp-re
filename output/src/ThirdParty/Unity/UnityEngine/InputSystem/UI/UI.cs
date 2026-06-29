// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.UI
// Classes: 12
// Methods: 236

namespace ThirdParty.Unity.UnityEngine.InputSystem.UI
{
    public class BaseInputOverride : BaseInput
    {
        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class ExtendedAxisEventData : AxisEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0x7A83F69F0
        public void set_device(){} // RVA: 0x7A8105A90
        public void .ctor(){} // RVA: 0x7AEC8BA80
        public void ToString(){} // RVA: 0x7AEC8BA90
    }

    public class ExtendedPointerEventData : PointerEventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE5820
        public void get_control(){} // RVA: 0x7A8B6A790
        public void set_control(){} // RVA: 0x7A8B4AC60
        public void get_device(){} // RVA: 0x7A8B46B20
        public void set_device(){} // RVA: 0x7A8B639C0
        public void get_touchId(){} // RVA: 0x7AE068FD0
        public void set_touchId(){} // RVA: 0x7AEC8BB70
        public void get_pointerType(){} // RVA: 0x7AEC8BB80
        public void set_pointerType(){} // RVA: 0x7AEC8BB90
        public void get_uiToolkitPointerId(){} // RVA: 0x7AEC8BBA0
        public void set_uiToolkitPointerId(){} // RVA: 0x7AEC8BBB0
        public void get_trackedDevicePosition(){} // RVA: 0x7AE29B180
        public void set_trackedDevicePosition(){} // RVA: 0x7AE29B1A0
        public void get_trackedDeviceOrientation(){} // RVA: 0x7AE29B1C0
        public void set_trackedDeviceOrientation(){} // RVA: 0x7AE29B1D0
        public void ToString(){} // RVA: 0x7AEC8BBC0
        public void MakePointerIdForTouch(){} // RVA: 0x7AEC8C4E0
        public void TouchIdFromPointerId(){} // RVA: 0x7A9726F60
        public void ReadDeviceState(){} // RVA: 0x7AEC8C4F0
        public void GetPenPointerId(){} // RVA: 0x7AEC8C840
        public void GetTouchPointerId(){} // RVA: 0x7AEC8CB40
        public void <control>k__BackingField(){} // RVA: 0x7B3F33818
    }

    public class ExtendedSubmitCancelEventData : BaseEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0x7A81052C0
        public void set_device(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7A813E420
    }

    public class INavigationEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0x7A7E00680
    }

    public class InputSystemUIInputModule : BaseInputModule
    {
        // ── Methods ──
        public void get_deselectOnBackgroundClick(){} // RVA: 0x7A9021760
        public void set_deselectOnBackgroundClick(){} // RVA: 0x7A90226D0
        public void get_pointerBehavior(){} // RVA: 0x7A961A4D0
        public void set_pointerBehavior(){} // RVA: 0x7ADF1BDC0
        public void get_cursorLockBehavior(){} // RVA: 0x7A880E690
        public void set_cursorLockBehavior(){} // RVA: 0x7A98A1E20
        public void get_localMultiPlayerRoot(){} // RVA: 0x7A8B57090
        public void set_localMultiPlayerRoot(){} // RVA: 0x7A8B542D0
        public void get_scrollDeltaPerTick(){} // RVA: 0x7ADF1BDF0
        public void set_scrollDeltaPerTick(){} // RVA: 0x7A8FB8260
        public void ActivateModule(){} // RVA: 0x7AEC8CCA0
        public void IsPointerOverGameObject(){} // RVA: 0x7AEC8CDD0
        public void GetLastRaycastResult(){} // RVA: 0x7AEC8D080
        public void PerformRaycast(){} // RVA: 0x7AEC8D1D0
        public void ProcessPointer(){} // RVA: 0x7AEC8D550
        public void PointerShouldIgnoreTransform(){} // RVA: 0x7AEC8DBE0
        public void ProcessPointerMovement(){} // RVA: 0x7AEC8DDF0
        public void ProcessPointerButton(){} // RVA: 0x7AEC8ECB0
        public void ProcessPointerButtonDrag(){} // RVA: 0x7AEC8FA20
        public void ProcessPointerScroll(){} // RVA: 0x7AEC8FE40
        public void ProcessNavigation(){} // RVA: 0x7AEC8FF40
        public void IsMoveAllowed(){} // RVA: 0x7AEC90710
        public void get_moveRepeatDelay(){} // RVA: 0x7A8100220
        public void set_moveRepeatDelay(){} // RVA: 0x7A8100230
        public void get_moveRepeatRate(){} // RVA: 0x7A8100240
        public void set_moveRepeatRate(){} // RVA: 0x7A8100250
        public void get_explictlyIgnoreFocus(){} // RVA: 0x7AEC90AB0
        public void get_shouldIgnoreFocus(){} // RVA: 0x7AEC90B10
        public void get_repeatRate(){} // RVA: 0x7A8100240
        public void set_repeatRate(){} // RVA: 0x7A8100250
        public void get_repeatDelay(){} // RVA: 0x7A8100220
        public void set_repeatDelay(){} // RVA: 0x7A8100230
        public void get_xrTrackingOrigin(){} // RVA: 0x7A8153390
        public void set_xrTrackingOrigin(){} // RVA: 0x7A81533A0
        public void get_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7A81E8E60
        public void set_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x7A8D9F8A0
        public void SwapAction(){} // RVA: 0x7AEC90BD0
        public void get_point(){} // RVA: 0x7A82C2060
        public void set_point(){} // RVA: 0x7AEC91100
        public void get_scrollWheel(){} // RVA: 0x7A8142610
        public void set_scrollWheel(){} // RVA: 0x7AEC91140
        public void get_leftClick(){} // RVA: 0x7A87D9C10
        public void set_leftClick(){} // RVA: 0x7AEC91180
        public void get_middleClick(){} // RVA: 0x7A87C5850
        public void set_middleClick(){} // RVA: 0x7AEC911C0
        public void get_rightClick(){} // RVA: 0x7A87D9480
        public void set_rightClick(){} // RVA: 0x7AEC91200
        public void get_move(){} // RVA: 0x7A825E100
        public void set_move(){} // RVA: 0x7AEC91240
        public void get_submit(){} // RVA: 0x7A81163D0
        public void set_submit(){} // RVA: 0x7AEC91280
        public void get_cancel(){} // RVA: 0x7A8555100
        public void set_cancel(){} // RVA: 0x7AEC912C0
        public void get_trackedDeviceOrientation(){} // RVA: 0x7A81426F0
        public void set_trackedDeviceOrientation(){} // RVA: 0x7AEC91300
        public void get_trackedDevicePosition(){} // RVA: 0x7A8142680
        public void set_trackedDevicePosition(){} // RVA: 0x7AEC91340
        public void AssignDefaultActions(){} // RVA: 0x7AEC91380
        public void UnassignActions(){} // RVA: 0x7AEC91EB0
        public void get_trackedDeviceSelect(){} // RVA: 0x7AEC92190
        public void set_trackedDeviceSelect(){} // RVA: 0x7AEC921D0
        public void Awake(){} // RVA: 0x7AEC92210
        public void OnDestroy(){} // RVA: 0x7AEC92270
        public void OnEnable(){} // RVA: 0x7AEC92290
        public void OnDisable(){} // RVA: 0x7AEC92550
        public void ResetPointers(){} // RVA: 0x7AEC926E0
        public void HasNoActions(){} // RVA: 0x7AEC928E0
        public void EnableAllActions(){} // RVA: 0x7AEC92AB0
        public void DisableAllActions(){} // RVA: 0x7AEC92B70
        public void EnableInputAction(){} // RVA: 0x7AEC92C50
        public void TryDisableInputAction(){} // RVA: 0x7AEC92E40
        public void GetPointerStateIndexFor(){} // RVA: 0x7AEC933F0
        public void GetPointerStateForIndex(){} // RVA: 0x7AEC93280
        public void GetDisplayIndexFor(){} // RVA: 0x7AEC932D0
        public void AllocatePointer(){} // RVA: 0x7AEC93E70
        public void SendPointerExitEventsAndRemovePointer(){} // RVA: 0x7AEC94190
        public void RemovePointerAtIndex(){} // RVA: 0x7AEC94350
        public void PurgeStalePointers(){} // RVA: 0x7AEC94950
        public void HaveControlForDevice(){} // RVA: 0x7AEC94AD0
        public void OnPointCallback(){} // RVA: 0x7AEC94BB0
        public void IgnoreNextClick(){} // RVA: 0x7AEC94CB0
        public void OnLeftClickCallback(){} // RVA: 0x7AEC94DE0
        public void OnRightClickCallback(){} // RVA: 0x7AEC94F10
        public void OnMiddleClickCallback(){} // RVA: 0x7AEC95050
        public void CheckForRemovedDevice(){} // RVA: 0x7AEC95190
        public void OnScrollCallback(){} // RVA: 0x7AEC95200
        public void OnMoveCallback(){} // RVA: 0x7AEC95350
        public void OnSubmitCancelCallback(){} // RVA: 0x7AEC95470
        public void OnTrackedDeviceOrientationCallback(){} // RVA: 0x7AEC95540
        public void OnTrackedDevicePositionCallback(){} // RVA: 0x7AEC956D0
        public void OnControlsChanged(){} // RVA: 0x7AEC95830
        public void FilterPointerStatesByType(){} // RVA: 0x7AEC95840
        public void Process(){} // RVA: 0x7AEC95F70
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7AEC96360
        public void HookActions(){} // RVA: 0x7AEC964A0
        public void UnhookActions(){} // RVA: 0x7AEC92270
        public void SetActionCallbacks(){} // RVA: 0x7AEC96A30
        public void SetActionCallback(){} // RVA: 0x7AEC96BB0
        public void UpdateReferenceForNewAsset(){} // RVA: 0x7AEC96CF0
        public void get_actionsAsset(){} // RVA: 0x7A81A00E0
        public void set_actionsAsset(){} // RVA: 0x7AEC96E60
        public void get_sendPointerHoverToParent(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7AEC97270
        public void .cctor(){} // RVA: 0x7AEC972B0
    }

    public class MultiplayerEventSystem : EventSystem
    {
        // ── Methods ──
        public void get_playerRoot(){} // RVA: 0x7A8175DF0
        public void set_playerRoot(){} // RVA: 0x7AEC97410
        public void OnEnable(){} // RVA: 0x7AEC97470
        public void OnDisable(){} // RVA: 0x7AEC975E0
        public void InitializePlayerRoot(){} // RVA: 0x7AEC975F0
        public void Update(){} // RVA: 0x7AEC977D0
        public void .ctor(){} // RVA: 0x7AEC978B0
    }

    public class NavigationModel : ValueType
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7A7EB56E0
    }

    public class PointerModel : ValueType
    {
        // ── Methods ──
        public void get_pointerType(){} // RVA: 0x7A7EB5780
        public void get_screenPosition(){} // RVA: 0x7A7EB57B0
        public void set_screenPosition(){} // RVA: 0x7A7EB57D0
        public void get_worldPosition(){} // RVA: 0x7A7EB5830
        public void set_worldPosition(){} // RVA: 0x7A7EB5850
        public void get_worldOrientation(){} // RVA: 0x7A7EB58D0
        public void set_worldOrientation(){} // RVA: 0x7A7EB58E0
        public void get_scrollDelta(){} // RVA: 0x7A7EB5950
        public void set_scrollDelta(){} // RVA: 0x7A7EB5970
        public void get_pressure(){} // RVA: 0x7A7EB59D0
        public void set_pressure(){} // RVA: 0x7A7EB59E0
        public void get_azimuthAngle(){} // RVA: 0x7A7EB5A00
        public void set_azimuthAngle(){} // RVA: 0x7A7EB5A10
        public void get_altitudeAngle(){} // RVA: 0x7A7EB5A30
        public void set_altitudeAngle(){} // RVA: 0x7A7EB5A40
        public void get_twist(){} // RVA: 0x7A7EB5A60
        public void set_twist(){} // RVA: 0x7A7EB5A70
        public void get_radius(){} // RVA: 0x7A7EB5A90
        public void set_radius(){} // RVA: 0x7A7EB5AB0
        public void .ctor(){} // RVA: 0x7A7EB5B10
        public void OnFrameFinished(){} // RVA: 0x7A7EB5B20
        public void CopyTouchOrPenStateFrom(){} // RVA: 0x7A7EB5B30
    }

    public class PointerModel[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D2C10
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29F310
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E52E0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA280EA0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29F310
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class TrackedDeviceRaycaster : BaseRaycaster
    {
        // ── Methods ──
        public void get_eventCamera(){} // RVA: 0x7AEC98560
        public void get_blockingMask(){} // RVA: 0x7A8D863F0
        public void set_blockingMask(){} // RVA: 0x7A8D870E0
        public void get_checkFor3DOcclusion(){} // RVA: 0x7AB9DF6A0
        public void set_checkFor3DOcclusion(){} // RVA: 0x7AD8AFA40
        public void get_checkFor2DOcclusion(){} // RVA: 0x7A80FD6B0
        public void set_checkFor2DOcclusion(){} // RVA: 0x7A80FD6C0
        public void get_ignoreReversedGraphics(){} // RVA: 0x7A80FD690
        public void set_ignoreReversedGraphics(){} // RVA: 0x7A80FD6A0
        public void get_maxDistance(){} // RVA: 0x7A81A2250
        public void set_maxDistance(){} // RVA: 0x7A81A2260
        public void OnEnable(){} // RVA: 0x7AEC98680
        public void OnDisable(){} // RVA: 0x7AEC98830
        public void Raycast(){} // RVA: 0x7AEC98A50
        public void PerformRaycast(){} // RVA: 0x7AEC98AF0
        public void SortedRaycastGraphics(){} // RVA: 0x7AEC99400
        public void RayIntersectsRectTransform(){} // RVA: 0x7AEC99B40
        public void get_canvas(){} // RVA: 0x7AEC9A0B0
        public void .ctor(){} // RVA: 0x7AEC9A1F0
        public void .cctor(){} // RVA: 0x7AEC9A2E0
    }

    public class VirtualMouseInput : MonoBehaviour
    {
        // ── Methods ──
        public void get_cursorTransform(){} // RVA: 0x7A83F69F0
        public void set_cursorTransform(){} // RVA: 0x7A8105A90
        public void get_cursorSpeed(){} // RVA: 0x7A8891F60
        public void set_cursorSpeed(){} // RVA: 0x7A8891A80
        public void get_cursorMode(){} // RVA: 0x7A851DB90
        public void set_cursorMode(){} // RVA: 0x7AEC9A5F0
        public void get_cursorGraphic(){} // RVA: 0x7A8105330
        public void set_cursorGraphic(){} // RVA: 0x7AEC9A770
        public void get_scrollSpeed(){} // RVA: 0x7A87B9920
        public void set_scrollSpeed(){} // RVA: 0x7A87B9910
        public void get_virtualMouse(){} // RVA: 0x7A8142870
        public void get_stickAction(){} // RVA: 0x7A80E0E30
        public void set_stickAction(){} // RVA: 0x7AEC9A880
        public void get_leftButtonAction(){} // RVA: 0x7A80E0E70
        public void set_leftButtonAction(){} // RVA: 0x7AEC9A8B0
        public void get_rightButtonAction(){} // RVA: 0x7AD53B020
        public void set_rightButtonAction(){} // RVA: 0x7AEC9AA60
        public void get_middleButtonAction(){} // RVA: 0x7A80E0EB0
        public void set_middleButtonAction(){} // RVA: 0x7AEC9AC20
        public void get_forwardButtonAction(){} // RVA: 0x7AD53B060
        public void set_forwardButtonAction(){} // RVA: 0x7AEC9ADD0
        public void get_backButtonAction(){} // RVA: 0x7AB48FA00
        public void set_backButtonAction(){} // RVA: 0x7AEC9AF90
        public void get_scrollWheelAction(){} // RVA: 0x7AEC9B150
        public void set_scrollWheelAction(){} // RVA: 0x7AEC9B170
        public void OnEnable(){} // RVA: 0x7AEC9B1A0
        public void OnDisable(){} // RVA: 0x7AEC9BA30
        public void TryFindCanvas(){} // RVA: 0x7AEC9BF80
        public void TryEnableHardwareCursor(){} // RVA: 0x7AEC9C020
        public void UpdateMotion(){} // RVA: 0x7AEC9C3B0
        public void OnButtonActionTriggered(){} // RVA: 0x7AEC9C8B0
        public void SetActionCallback(){} // RVA: 0x7AEC9CAF0
        public void SetAction(){} // RVA: 0x7AEC9CC20
        public void OnAfterInputUpdate(){} // RVA: 0x7AEC9CE50
        public void .ctor(){} // RVA: 0x7AEC9CE60
    }

}