// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.UI
// Classes: 12
// Methods: 237

namespace ThirdParty.Unity.UnityEngine.InputSystem.UI
{
    public class BaseInputOverride : BaseInput
    {
        // ── Methods ──
        public void get_compositionString(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class ExtendedAxisEventData : AxisEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0xD33E60
        public void set_device(){} // RVA: 0xB708C0
        public void .ctor(){} // RVA: 0x78F9A70
        public void ToString(){} // RVA: 0x78F9A80
    }

    public class ExtendedPointerEventData : PointerEventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C67490
        public void get_control(){} // RVA: 0x165EBC0
        public void set_control(){} // RVA: 0x1651590
        public void get_device(){} // RVA: 0x1667D40
        public void set_device(){} // RVA: 0x1669D30
        public void get_touchId(){} // RVA: 0x6CEA800
        public void set_touchId(){} // RVA: 0x78F9B60
        public void get_pointerType(){} // RVA: 0x78F9B70
        public void set_pointerType(){} // RVA: 0x78F9B80
        public void get_uiToolkitPointerId(){} // RVA: 0x78F9B90
        public void set_uiToolkitPointerId(){} // RVA: 0x78F9BA0
        public void get_trackedDevicePosition(){} // RVA: 0x6F1A170
        public void set_trackedDevicePosition(){} // RVA: 0x6F1A190
        public void get_trackedDeviceOrientation(){} // RVA: 0x6F1A1B0
        public void set_trackedDeviceOrientation(){} // RVA: 0x6F1A1C0
        public void ToString(){} // RVA: 0x78F9BB0
        public void MakePointerIdForTouch(){} // RVA: 0x78FA4D0
        public void TouchIdFromPointerId(){} // RVA: 0x22341D0
        public void ReadDeviceState(){} // RVA: 0x78FA4E0
        public void GetPenPointerId(){} // RVA: 0x78FA830
        public void GetTouchPointerId(){} // RVA: 0x78FAB30
    }

    public class ExtendedSubmitCancelEventData : BaseEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0xB700F0
        public void set_device(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0xBA9BA0
    }

    public class INavigationEventData
    {
        // ── Methods ──
        public void get_device(){} // RVA: 0x87C0A0
    }

    public class InputSystemUIInputModule : BaseInputModule
    {
        // ── Methods ──
        public void get_deselectOnBackgroundClick(){} // RVA: 0x1C11610
        public void set_deselectOnBackgroundClick(){} // RVA: 0x1C10980
        public void get_pointerBehavior(){} // RVA: 0x214AA20
        public void set_pointerBehavior(){} // RVA: 0x6BA2C20
        public void get_cursorLockBehavior(){} // RVA: 0x131DCD0
        public void set_cursorLockBehavior(){} // RVA: 0x23B1640
        public void get_localMultiPlayerRoot(){} // RVA: 0x1667260
        public void set_localMultiPlayerRoot(){} // RVA: 0x164C5E0
        public void get_scrollDeltaPerTick(){} // RVA: 0x6BA2C30
        public void set_scrollDeltaPerTick(){} // RVA: 0x1A6F0F0
        public void ActivateModule(){} // RVA: 0x78FAC90
        public void IsPointerOverGameObject(){} // RVA: 0x78FADC0
        public void GetLastRaycastResult(){} // RVA: 0x78FB070
        public void PerformRaycast(){} // RVA: 0x78FB1C0
        public void ProcessPointer(){} // RVA: 0x78FB540
        public void PointerShouldIgnoreTransform(){} // RVA: 0x78FBB90
        public void ProcessPointerMovement(){} // RVA: 0x78FBD60
        public void ProcessPointerButton(){} // RVA: 0x78FCEA0
        public void ProcessPointerButtonDrag(){} // RVA: 0x78FDBD0
        public void ProcessPointerScroll(){} // RVA: 0x78FDFF0
        public void ProcessNavigation(){} // RVA: 0x78FE0F0
        public void IsMoveAllowed(){} // RVA: 0x78FE8C0
        public void get_moveRepeatDelay(){} // RVA: 0xB6B160
        public void set_moveRepeatDelay(){} // RVA: 0xB6B170
        public void get_moveRepeatRate(){} // RVA: 0xB6B180
        public void set_moveRepeatRate(){} // RVA: 0xB6B190
        public void get_explictlyIgnoreFocus(){} // RVA: 0x78FEC60
        public void get_shouldIgnoreFocus(){} // RVA: 0x78FECC0
        public void get_repeatRate(){} // RVA: 0xB6B180
        public void set_repeatRate(){} // RVA: 0xB6B190
        public void get_repeatDelay(){} // RVA: 0xB6B160
        public void set_repeatDelay(){} // RVA: 0xB6B170
        public void get_xrTrackingOrigin(){} // RVA: 0xBBFF90
        public void set_xrTrackingOrigin(){} // RVA: 0xBBFFA0
        public void get_trackedDeviceDragThresholdMultiplier(){} // RVA: 0xC5C4A0
        public void set_trackedDeviceDragThresholdMultiplier(){} // RVA: 0x18AD0F0
        public void SwapAction(){} // RVA: 0x78FED80
        public void get_point(){} // RVA: 0xCD3320
        public void set_point(){} // RVA: 0x78FF270
        public void get_scrollWheel(){} // RVA: 0xBAE340
        public void set_scrollWheel(){} // RVA: 0x78FF2B0
        public void get_leftClick(){} // RVA: 0x106A7D0
        public void set_leftClick(){} // RVA: 0x78FF2F0
        public void get_middleClick(){} // RVA: 0x106A050
        public void set_middleClick(){} // RVA: 0x78FF330
        public void get_rightClick(){} // RVA: 0x12EB090
        public void set_rightClick(){} // RVA: 0x78FF370
        public void get_move(){} // RVA: 0xCD48B0
        public void set_move(){} // RVA: 0x78FF3B0
        public void get_submit(){} // RVA: 0xB813B0
        public void set_submit(){} // RVA: 0x78FF3F0
        public void get_cancel(){} // RVA: 0x1069350
        public void set_cancel(){} // RVA: 0x78FF430
        public void get_trackedDeviceOrientation(){} // RVA: 0xBAE420
        public void set_trackedDeviceOrientation(){} // RVA: 0x78FF470
        public void get_trackedDevicePosition(){} // RVA: 0xBAE3B0
        public void set_trackedDevicePosition(){} // RVA: 0x78FF4B0
        public void AssignDefaultActions(){} // RVA: 0x78FF4F0
        public void UnassignActions(){} // RVA: 0x7900020
        public void get_trackedDeviceSelect(){} // RVA: 0x7900340
        public void set_trackedDeviceSelect(){} // RVA: 0x7900380
        public void Awake(){} // RVA: 0x79003C0
        public void OnDestroy(){} // RVA: 0x7900420
        public void OnEnable(){} // RVA: 0x7900440
        public void OnDisable(){} // RVA: 0x7900700
        public void ResetPointers(){} // RVA: 0x7900890
        public void HasNoActions(){} // RVA: 0x7900A90
        public void EnableAllActions(){} // RVA: 0x7900C60
        public void DisableAllActions(){} // RVA: 0x7900D20
        public void EnableInputAction(){} // RVA: 0x7900E00
        public void TryDisableInputAction(){} // RVA: 0x7900FF0
        public void GetPointerStateIndexFor(){} // RVA: 0x7901570
        public void GetPointerStateForIndex(){} // RVA: 0x7901400
        public void GetDisplayIndexFor(){} // RVA: 0x7901450
        public void AllocatePointer(){} // RVA: 0x7901FF0
        public void SendPointerExitEventsAndRemovePointer(){} // RVA: 0x7902310
        public void RemovePointerAtIndex(){} // RVA: 0x79024D0
        public void PurgeStalePointers(){} // RVA: 0x7902AD0
        public void HaveControlForDevice(){} // RVA: 0x7902C50
        public void OnPointCallback(){} // RVA: 0x7902D30
        public void IgnoreNextClick(){} // RVA: 0x7902E30
        public void OnLeftClickCallback(){} // RVA: 0x7902F60
        public void OnRightClickCallback(){} // RVA: 0x7903090
        public void OnMiddleClickCallback(){} // RVA: 0x79031D0
        public void CheckForRemovedDevice(){} // RVA: 0x7903310
        public void OnScrollCallback(){} // RVA: 0x7903380
        public void OnMoveCallback(){} // RVA: 0x7903500
        public void OnSubmitCancelCallback(){} // RVA: 0x7903620
        public void OnTrackedDeviceOrientationCallback(){} // RVA: 0x79036F0
        public void OnTrackedDevicePositionCallback(){} // RVA: 0x7903880
        public void OnControlsChanged(){} // RVA: 0x79039E0
        public void FilterPointerStatesByType(){} // RVA: 0x79039F0
        public void Process(){} // RVA: 0x7904120
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7904510
        public void ConvertPointerEventScrollDeltaToTicks(){} // RVA: 0x7904650
        public void HookActions(){} // RVA: 0x79046F0
        public void UnhookActions(){} // RVA: 0x7900420
        public void SetActionCallbacks(){} // RVA: 0x7904C80
        public void SetActionCallback(){} // RVA: 0x7904E00
        public void UpdateReferenceForNewAsset(){} // RVA: 0x7904F40
        public void get_actionsAsset(){} // RVA: 0xC10050
        public void set_actionsAsset(){} // RVA: 0x79050B0
        public void get_sendPointerHoverToParent(){} // RVA: 0xF73960
        public void set_sendPointerHoverToParent(){} // RVA: 0xF73A60
        public void .ctor(){} // RVA: 0x79054C0
        public void .cctor(){} // RVA: 0x7905500
    }

    public class MultiplayerEventSystem : EventSystem
    {
        // ── Methods ──
        public void get_playerRoot(){} // RVA: 0xBE2C60
        public void set_playerRoot(){} // RVA: 0x7905660
        public void OnEnable(){} // RVA: 0x79056C0
        public void OnDisable(){} // RVA: 0x7905830
        public void InitializePlayerRoot(){} // RVA: 0x7905840
        public void Update(){} // RVA: 0x7905A20
        public void .ctor(){} // RVA: 0x7905B00
    }

    public class NavigationModel : ValueType
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x937400
    }

    public class PointerModel : ValueType
    {
        // ── Methods ──
        public void get_pointerType(){} // RVA: 0x9375E0
        public void get_screenPosition(){} // RVA: 0x937610
        public void set_screenPosition(){} // RVA: 0x937630
        public void get_worldPosition(){} // RVA: 0x937690
        public void set_worldPosition(){} // RVA: 0x9376B0
        public void get_worldOrientation(){} // RVA: 0x937730
        public void set_worldOrientation(){} // RVA: 0x937740
        public void get_scrollDelta(){} // RVA: 0x9377B0
        public void set_scrollDelta(){} // RVA: 0x9377D0
        public void get_pressure(){} // RVA: 0x937830
        public void set_pressure(){} // RVA: 0x937840
        public void get_azimuthAngle(){} // RVA: 0x937860
        public void set_azimuthAngle(){} // RVA: 0x937870
        public void get_altitudeAngle(){} // RVA: 0x937890
        public void set_altitudeAngle(){} // RVA: 0x9378A0
        public void get_twist(){} // RVA: 0x9378C0
        public void set_twist(){} // RVA: 0x9378D0
        public void get_radius(){} // RVA: 0x9378F0
        public void set_radius(){} // RVA: 0x937910
        public void .ctor(){} // RVA: 0x937970
        public void OnFrameFinished(){} // RVA: 0x937980
        public void CopyTouchOrPenStateFrom(){} // RVA: 0x937990
    }

    public class PointerModel[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB1120
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7BD70
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC6A50
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6C840
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7BD70
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class TrackedDeviceRaycaster : BaseRaycaster
    {
        // ── Methods ──
        public void get_eventCamera(){} // RVA: 0x7906790
        public void get_blockingMask(){} // RVA: 0x18A0130
        public void set_blockingMask(){} // RVA: 0x189D3F0
        public void get_checkFor3DOcclusion(){} // RVA: 0x4674B20
        public void set_checkFor3DOcclusion(){} // RVA: 0x653CDE0
        public void get_checkFor2DOcclusion(){} // RVA: 0xB68E10
        public void set_checkFor2DOcclusion(){} // RVA: 0xB68E20
        public void get_ignoreReversedGraphics(){} // RVA: 0xB68DF0
        public void set_ignoreReversedGraphics(){} // RVA: 0xB68E00
        public void get_maxDistance(){} // RVA: 0xC120F0
        public void set_maxDistance(){} // RVA: 0xC12100
        public void OnEnable(){} // RVA: 0x7906870
        public void OnDisable(){} // RVA: 0x7906A20
        public void Raycast(){} // RVA: 0x7906C40
        public void PerformRaycast(){} // RVA: 0x7906CE0
        public void SortedRaycastGraphics(){} // RVA: 0x7907610
        public void RayIntersectsRectTransform(){} // RVA: 0x7907D50
        public void get_canvas(){} // RVA: 0x79082C0
        public void .ctor(){} // RVA: 0x7908400
        public void .cctor(){} // RVA: 0x79084F0
    }

    public class VirtualMouseInput : MonoBehaviour
    {
        // ── Methods ──
        public void get_cursorTransform(){} // RVA: 0xD33E60
        public void set_cursorTransform(){} // RVA: 0xB708C0
        public void get_cursorSpeed(){} // RVA: 0x11E18C0
        public void set_cursorSpeed(){} // RVA: 0x11E1470
        public void get_cursorMode(){} // RVA: 0xFEAE90
        public void set_cursorMode(){} // RVA: 0x7908750
        public void get_cursorGraphic(){} // RVA: 0xB70160
        public void set_cursorGraphic(){} // RVA: 0x79088D0
        public void get_scrollSpeed(){} // RVA: 0x12CA360
        public void set_scrollSpeed(){} // RVA: 0x12C9F10
        public void get_virtualMouse(){} // RVA: 0xBAE5A0
        public void get_stickAction(){} // RVA: 0xB4CDC0
        public void set_stickAction(){} // RVA: 0x79089E0
        public void get_leftButtonAction(){} // RVA: 0xB4CE00
        public void set_leftButtonAction(){} // RVA: 0x7908A10
        public void get_rightButtonAction(){} // RVA: 0x7908BC0
        public void set_rightButtonAction(){} // RVA: 0x7908BE0
        public void get_middleButtonAction(){} // RVA: 0xB4CE40
        public void set_middleButtonAction(){} // RVA: 0x7908DA0
        public void get_forwardButtonAction(){} // RVA: 0x7908F50
        public void set_forwardButtonAction(){} // RVA: 0x7908F70
        public void get_backButtonAction(){} // RVA: 0x4123D10
        public void set_backButtonAction(){} // RVA: 0x7909130
        public void get_scrollWheelAction(){} // RVA: 0x79092F0
        public void set_scrollWheelAction(){} // RVA: 0x7909310
        public void OnEnable(){} // RVA: 0x7909340
        public void OnDisable(){} // RVA: 0x7909BD0
        public void TryFindCanvas(){} // RVA: 0x790A120
        public void TryEnableHardwareCursor(){} // RVA: 0x790A1C0
        public void UpdateMotion(){} // RVA: 0x790A550
        public void OnButtonActionTriggered(){} // RVA: 0x790AAA0
        public void SetActionCallback(){} // RVA: 0x790ACE0
        public void SetAction(){} // RVA: 0x790AE10
        public void OnAfterInputUpdate(){} // RVA: 0x790B040
        public void .ctor(){} // RVA: 0x790B050
    }

}