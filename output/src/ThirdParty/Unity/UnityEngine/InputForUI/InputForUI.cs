// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputForUI
// Classes: 19
// Methods: 192

namespace ThirdParty.Unity.UnityEngine.InputForUI
{
    public class CommandEvent : ValueType
    {
        // ── Methods ──
        public void set_timestamp(){} // RVA: 0x990A0
        public void get_eventSource(){} // RVA: 0x8C7E0
        public void set_eventSource(){} // RVA: 0x8C7F0
        public void set_playerId(){} // RVA: 0xAFF60
        public void get_eventModifiers(){} // RVA: 0x8E1F0
        public void set_eventModifiers(){} // RVA: 0x9E810
        public void ToString(){} // RVA: 0x970640
    }

    public class Event : ValueType
    {
        // ── Methods ──
        public void CompareType(){} // RVA: 0x7C9EC40
        public void get_type(){} // RVA: 0x77E60
        public void get_asObject(){} // RVA: 0x970C30
        public void get_eventSource(){} // RVA: 0x970C40
        public void get_eventModifiers(){} // RVA: 0x970C50
        public void Ensure(){} // RVA: 0x970C60
        public void ToString(){} // RVA: 0x970C70
        public void From(){} // RVA: 0x7C9F780
        public void get_asKeyEvent(){} // RVA: 0x970C80
        public void get_asPointerEvent(){} // RVA: 0x970CD0
        public void get_asTextInputEvent(){} // RVA: 0x970D30
        public void get_asIMECompositionEvent(){} // RVA: 0x970DB0
        public void get_asCommandEvent(){} // RVA: 0x970DE0
        public void get_asNavigationEvent(){} // RVA: 0x970E60
        public void Map(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x7C9F890
    }

    public class EventConsumer : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F2DB30
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class EventModifiers : ValueType
    {
        // ── Methods ──
        public void IsPressed(){} // RVA: 0x970EE0
        public void get_isShiftPressed(){} // RVA: 0x970EF0
        public void get_isCtrlPressed(){} // RVA: 0x970F00
        public void get_isAltPressed(){} // RVA: 0x970F10
        public void get_isMetaPressed(){} // RVA: 0x970F20
        public void get_isCapsLockEnabled(){} // RVA: 0x970F30
        public void get_isFunctionKeyPressed(){} // RVA: 0x970F40
        public void get_isNumericPressed(){} // RVA: 0x970F50
        public void SetPressed(){} // RVA: 0x91F160
        public void Reset(){} // RVA: 0x96220
        public void Append(){} // RVA: 0x7C9F9F0
        public void ToString(){} // RVA: 0x970F60
    }

    public class EventProvider : Object
    {
        // ── Methods ──
        public void Subscribe(){} // RVA: 0x7CA1640
        public void Unsubscribe(){} // RVA: 0x7CA1A80
        public void SetEnabled(){} // RVA: 0x7CA1C70
        public void Dispatch(){} // RVA: 0x7CA1D10
        public void Bootstrap(){} // RVA: 0x7CA1FE0
        public void Initialize(){} // RVA: 0x7CA2050
        public void Shutdown(){} // RVA: 0x7CA2200
        public void OnFocusChanged(){} // RVA: 0x7CA2380
        public void NotifyUpdate(){} // RVA: 0x7CA2410
        public void SetInputSystemProvider(){} // RVA: 0x7CA25C0
        public void .cctor(){} // RVA: 0x7CA26B0
    }

    public class EventProvider[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class EventSanitizer : ValueType
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x971F00
        public void BeforeProviderUpdate(){} // RVA: 0x971F10
        public void AfterProviderUpdate(){} // RVA: 0x971F20
        public void Inspect(){} // RVA: 0x971F30
    }

    public class Event[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E81880
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B8F0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC6110
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E370F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B8F0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IEventProperties
    {
        // ── Methods ──
        public void get_eventSource(){} // RVA: 0x87C130
        public void get_eventModifiers(){} // RVA: 0xA94080
    }

    public class IEventProviderImpl
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x894290
        public void Shutdown(){} // RVA: 0x894290
        public void Update(){} // RVA: 0x894290
        public void OnFocusChanged(){} // RVA: 0x894750
    }

    public class IMECompositionEvent : ValueType
    {
        // ── Methods ──
        public void set_timestamp(){} // RVA: 0x990A0
        public void get_eventSource(){} // RVA: 0x8C7E0
        public void set_eventSource(){} // RVA: 0x8C7F0
        public void set_playerId(){} // RVA: 0xAFF60
        public void get_eventModifiers(){} // RVA: 0x8E1F0
        public void set_eventModifiers(){} // RVA: 0x9E810
        public void ToString(){} // RVA: 0x971080
    }

    public class InputEventPartialProvider : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7CA29D0
        public void Shutdown(){} // RVA: 0xB43310
        public void Update(){} // RVA: 0x7CA2A40
        public void OnFocusChanged(){} // RVA: 0x7CA2ED0
        public void GetTimestamp(){} // RVA: 0x7CA2EF0
        public void UpdateEventModifiers(){} // RVA: 0x7CA2F60
        public void ToKeyEvent(){} // RVA: 0x7CA36D0
        public void ToTextInputEvent(){} // RVA: 0x7CA3900
        public void SendNextOrPreviousNavigationEventOnTabKeyDownEvent(){} // RVA: 0x7CA3A00
        public void ToCommandEvent(){} // RVA: 0x7CA3C40
        public void .ctor(){} // RVA: 0x7CA3EA0
    }

    public class InputManagerProvider : Object
    {
        // ── Methods ──
        public void get__eventModifiers(){} // RVA: 0x7CA46B0
        public void .ctor(){} // RVA: 0x7CA46D0
        public void Initialize(){} // RVA: 0x7CA49E0
        public void Shutdown(){} // RVA: 0xB43310
        public void Update(){} // RVA: 0x7CA4BB0
        public void CheckTouchEvents(){} // RVA: 0x7CA50C0
        public void DetectPen(){} // RVA: 0x7CA57B0
        public void PenStatusToButton(){} // RVA: 0x7CA5870
        public void CheckPenEvent(){} // RVA: 0x7CA5890
        public void CheckMouseEvents(){} // RVA: 0x7CA5D60
        public void CheckMouseScroll(){} // RVA: 0x7CA63E0
        public void NextPreviousNavigation(){} // RVA: 0x7CA6780
        public void SubmitCancelNavigation(){} // RVA: 0x7CA6920
        public void DirectionNavigation(){} // RVA: 0x7CA6B50
        public void CheckIfIMEChanged(){} // RVA: 0x7CA6E40
        public void OnFocusChanged(){} // RVA: 0x7CA7170
        public void GetEventSourceFromPressedKey(){} // RVA: 0x7CA71B0
        public void InputManagerJoystickWasPressed(){} // RVA: 0x7CA72D0
        public void InputManagerKeyboardWasPressed(){} // RVA: 0x7CA7350
        public void InputManagerGetAxisRawOrDefault(){} // RVA: 0x7CA73D0
        public void InputManagerGetButtonDownOrDefault(){} // RVA: 0x7CA7450
        public void ReadCurrentNavigationMoveVector(){} // RVA: 0x7CA74D0
        public void ToIMECompositionEvent(){} // RVA: 0x7CA75F0
        public void TiltToAzimuth(){} // RVA: 0x4860510
        public void AzimuthAndAlitutudeToTilt(){} // RVA: 0x4860620
        public void TiltToAltitude(){} // RVA: 0x48606C0
        public void MultiDisplayBottomLeftToPanelPosition(){} // RVA: 0x7CA76A0
        public void MultiDisplayToLocalScreenPosition(){} // RVA: 0x7CA7980
        public void ScreenBottomLeftToPanelPosition(){} // RVA: 0x7CA7B40
        public void ScreenBottomLeftToPanelDelta(){} // RVA: 0x7CA7C60
    }

    public class KeyEvent : ValueType
    {
        // ── Methods ──
        public void set_timestamp(){} // RVA: 0xCF9D0
        public void get_eventSource(){} // RVA: 0xA3790
        public void set_eventSource(){} // RVA: 0xA37A0
        public void set_playerId(){} // RVA: 0x9710E0
        public void get_eventModifiers(){} // RVA: 0xA6C20
        public void set_eventModifiers(){} // RVA: 0xA6B60
        public void ToString(){} // RVA: 0x9710F0
    }

    public class NavigationEvent : ValueType
    {
        // ── Methods ──
        public void set_timestamp(){} // RVA: 0xE1E10
        public void get_eventSource(){} // RVA: 0x8E1F0
        public void set_eventSource(){} // RVA: 0x9E810
        public void set_playerId(){} // RVA: 0x9F5B0
        public void get_eventModifiers(){} // RVA: 0x93180
        public void set_eventModifiers(){} // RVA: 0x93190
        public void ToString(){} // RVA: 0x9712F0
        public void DetermineMoveDirection(){} // RVA: 0x7CA0490
    }

    public class NavigationEventRepeatHelper : Object
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7CA8470
        public void ShouldSendMoveEvent(){} // RVA: 0x7CA84E0
        public void .ctor(){} // RVA: 0x7CA85B0
    }

    public class PointerEvent : ValueType
    {
        // ── Methods ──
        public void get_isPrimaryPointer(){} // RVA: 0x92EE30
        public void get_azimuth(){} // RVA: 0x971420
        public void get_altitude(){} // RVA: 0x971430
        public void get_timestamp(){} // RVA: 0xC26F0
        public void set_timestamp(){} // RVA: 0x144A80
        public void get_eventSource(){} // RVA: 0x4AA340
        public void set_eventSource(){} // RVA: 0x9588C0
        public void set_playerId(){} // RVA: 0xE31D0
        public void get_eventModifiers(){} // RVA: 0xA6A50
        public void set_eventModifiers(){} // RVA: 0xA6A70
        public void ToString(){} // RVA: 0x971480
        public void ButtonFromButtonIndex(){} // RVA: 0x7CA1480
    }

    public class PointerState : ValueType
    {
        // ── Methods ──
        public void get_LastPressedButton(){} // RVA: 0x77E60
        public void set_LastPressedButton(){} // RVA: 0x29580
        public void get_ButtonsState(){} // RVA: 0x77E50
        public void get_NextPressTime(){} // RVA: 0x77ED0
        public void set_NextPressTime(){} // RVA: 0x990A0
        public void get_ClickCount(){} // RVA: 0x8C7E0
        public void set_ClickCount(){} // RVA: 0x8C7F0
        public void get_LastPosition(){} // RVA: 0x27A900
        public void set_LastPosition(){} // RVA: 0x971DD0
        public void get_LastDisplayIndex(){} // RVA: 0x9F5A0
        public void set_LastDisplayIndex(){} // RVA: 0x9F5B0
        public void get_LastPositionValid(){} // RVA: 0xA62B0
        public void set_LastPositionValid(){} // RVA: 0xA62D0
        public void OnButtonDown(){} // RVA: 0x971DE0
        public void OnButtonUp(){} // RVA: 0x971DF0
        public void OnButtonChange(){} // RVA: 0x971E00
        public void OnMove(){} // RVA: 0x971E20
        public void Reset(){} // RVA: 0x971E30
        public void .cctor(){} // RVA: 0x7CA8A50
    }

    public class TextInputEvent : ValueType
    {
        // ── Methods ──
        public void set_timestamp(){} // RVA: 0x990A0
        public void get_eventSource(){} // RVA: 0x8C7E0
        public void set_eventSource(){} // RVA: 0x8C7F0
        public void set_playerId(){} // RVA: 0xAFF60
        public void get_eventModifiers(){} // RVA: 0x8E1F0
        public void set_eventModifiers(){} // RVA: 0x9E810
        public void ToString(){} // RVA: 0x971590
    }

}