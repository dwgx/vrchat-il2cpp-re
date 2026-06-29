// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Accessibility
// Classes: 19
// Methods: 204

namespace ThirdParty.Unity.UnityEngine.Accessibility
{
    public class AccessibilityAction : Object
    {
        // ── Methods ──
        public void Dispose(){} // RVA: 0x7AD65D0
        public void Internal_Destroy(){} // RVA: 0x7AD6640
        public void get_activated(){} // RVA: 0xB465B0
        public void Internal_InvokeActivated(){} // RVA: 0x7AD6690
    }

    public class AccessibilityAction[] : Array
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

    public class AccessibilityHierarchy : Object
    {
        // ── Methods ──
        public void TryGetNode(){} // RVA: 0x7AD9A80
        public void FreeNative(){} // RVA: 0x7AD9B60
        public void TryGetNodeAt(){} // RVA: 0x7AD9CC0
        public void <TryGetNodeAt>g__FindNodeContainingPoint|27_0(){} // RVA: 0x7AD9D30
    }

    public class AccessibilityHierarchyService : Object
    {
        // ── Methods ──
        public void get_hierarchy(){} // RVA: 0xB5DBF0
        public void Start(){} // RVA: 0xB43310
        public void Stop(){} // RVA: 0x7ADB1D0
        public void RemoveActiveHierarchy(){} // RVA: 0x7ADB1F0
        public void TryGetNode(){} // RVA: 0x7ADB390
        public void GetRootNodes(){} // RVA: 0x7ADB410
        public void TryGetNodeAt(){} // RVA: 0x7ADB430
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AccessibilityManager : Object
    {
        // ── Methods ──
        public void add_screenReaderStatusChanged(){} // RVA: 0x7AD66D0
        public void remove_screenReaderStatusChanged(){} // RVA: 0x7AD6840
        public void add_nodeFocusChanged(){} // RVA: 0x7AD69B0
        public void remove_nodeFocusChanged(){} // RVA: 0x7AD6B20
        public void IsScreenReaderEnabled(){} // RVA: 0x7AD6C90
        public void SendAccessibilityNotification(){} // RVA: 0x7AD6CE0
        public void Internal_Initialize(){} // RVA: 0x7AD6D30
        public void Internal_Update(){} // RVA: 0x7AD6D80
        public void Internal_GetRootNodeIds(){} // RVA: 0x7AD7480
        public void Internal_GetNode(){} // RVA: 0x7AD7750
        public void Internal_GetNodeIdAt(){} // RVA: 0x7AD7870
        public void Internal_OnAccessibilityNotificationReceived(){} // RVA: 0x7AD79F0
        public void QueueNotification(){} // RVA: 0x7AD7AC0
        public void GetExclusiveLock(){} // RVA: 0x7AD7CC0
        public void Lock(){} // RVA: 0x7AD7D80
        public void Unlock(){} // RVA: 0x7AD7DD0
        public void .cctor(){} // RVA: 0x7AD7E20
    }

    public class AccessibilityManager[] : Array
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

    public class AccessibilityNode : Object
    {
        // ── Methods ──
        public void FreeNative(){} // RVA: 0x7AD9F10
        public void get_id(){} // RVA: 0xB8F8F0
        public void get_label(){} // RVA: 0xBBF8F0
        public void get_value(){} // RVA: 0xBE58B0
        public void get_hint(){} // RVA: 0xC0FFC0
        public void get_isActive(){} // RVA: 0xB6B1A0
        public void get_role(){} // RVA: 0x7ADA460
        public void get_allowsDirectInteraction(){} // RVA: 0x1D450E0
        public void get_state(){} // RVA: 0x7ADA470
        public void get_parent(){} // RVA: 0xBBFF90
        public void get_childList(){} // RVA: 0xC10050
        public void get_frame(){} // RVA: 0x7ADA480
        public void SetFrame(){} // RVA: 0x7ADA5F0
        public void get_frameGetter(){} // RVA: 0xB465B0
        public void CalculateFrame(){} // RVA: 0x7ADA6C0
        public void get_language(){} // RVA: 0xF3A950
        public void GetNodeData(){} // RVA: 0x7ADA7B0
        public void ChildrenChanged(){} // RVA: 0x7ADAB10
        public void ActionsChanged(){} // RVA: 0x7ADAD50
        public void IsInActiveHierarchy(){} // RVA: 0x7ADAF30
        public void NotifyFocusChanged(){} // RVA: 0x7ADAFA0
        public void InvokeFocusChanged(){} // RVA: 0x7ADB110
        public void InvokeSelected(){} // RVA: 0x7ADB130
        public void InvokeIncremented(){} // RVA: 0x7ADB170
        public void InvokeDecremented(){} // RVA: 0x593C430
        public void Dismissed(){} // RVA: 0x7ADB190
    }

    public class AccessibilityNodeData : ValueType
    {
        // ── Methods ──
        public void set_id(){} // RVA: 0x29580
        public void set_isActive(){} // RVA: 0x54160
        public void set_label(){} // RVA: 0x77E70
        public void set_value(){} // RVA: 0x7E3E0
        public void set_hint(){} // RVA: 0x93120
        public void set_role(){} // RVA: 0x957EF0
        public void set_allowsDirectInteraction(){} // RVA: 0x957F00
        public void set_state(){} // RVA: 0x957F10
        public void set_frame(){} // RVA: 0x935700
        public void set_parentId(){} // RVA: 0xA37A0
        public void set_childIds(){} // RVA: 0x63E40
        public void set_language(){} // RVA: 0x4AA3F0
        public void set_implementsSelected(){} // RVA: 0xE3280
        public void set_implementsDismissed(){} // RVA: 0x957F20
    }

    public class AccessibilityNodeData[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AccessibilityNodeManager : Object
    {
        // ── Methods ──
        public void DestroyNativeNode(){} // RVA: 0x7AD83B0
        public void SetFrame(){} // RVA: 0x7AD8410
        public void SetChildren(){} // RVA: 0x7AD8470
        public void SetActions(){} // RVA: 0x7AD8550
        public void Internal_InvokeFocusChanged(){} // RVA: 0x7AD85B0
        public void Internal_InvokeSelected(){} // RVA: 0x7AD8830
        public void Internal_InvokeIncremented(){} // RVA: 0x7AD8950
        public void Internal_InvokeDecremented(){} // RVA: 0x7AD8A60
        public void Internal_InvokeDismissed(){} // RVA: 0x7AD8B70
        public void SetFrame_Injected(){} // RVA: 0x7AD8C90
        public void SetChildren_Injected(){} // RVA: 0x7AD8CF0
    }

    public class AccessibilityNodeManager[] : Array
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

    public class AccessibilityNotificationContext : ValueType
    {
        // ── Methods ──
        public void get_notification(){} // RVA: 0x77E60
        public void set_notification(){} // RVA: 0x29580
        public void get_isScreenReaderEnabled(){} // RVA: 0x9B0B0
        public void get_announcement(){} // RVA: 0x77ED0
        public void get_wasAnnouncementSuccessful(){} // RVA: 0xB1800
        public void get_currentNodeId(){} // RVA: 0xAFF50
        public void get_nextNodeId(){} // RVA: 0x8E1F0
        public void set_nextNodeId(){} // RVA: 0x9E810
    }

    public class AccessibilityNotificationContext[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0xAD0950
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AccessibilitySettings : Object
    {
        // ── Methods ──
        public void Internal_OnFontScaleChanged(){} // RVA: 0x7AD8D50
        public void Internal_OnBoldTextStatusChanged(){} // RVA: 0x7AD8E10
        public void Internal_OnClosedCaptioningStatusChanged(){} // RVA: 0x7AD8EC0
        public void InvokeFontScaleChanged(){} // RVA: 0x7AD8F70
        public void InvokeBoldTextStatusChanged(){} // RVA: 0x7AD8FD0
        public void InvokeClosedCaptionStatusChanged(){} // RVA: 0x7AD9030
    }

    public class AccessibilitySettings[] : Array
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

    public class AssistiveSupport : Object
    {
        // ── Methods ──
        public void get_isScreenReaderEnabled(){} // RVA: 0x7AD9090
        public void set_isScreenReaderEnabled(){} // RVA: 0x7AD90F0
        public void get_notificationDispatcher(){} // RVA: 0x7AD9150
        public void Initialize(){} // RVA: 0x7AD91B0
        public void GetService(){} // RVA: 0xA94080
        public void ScreenReaderStatusChanged(){} // RVA: 0x7AD9690
        public void NodeFocusChanged(){} // RVA: 0x7AD9780
        public void get_activeHierarchy(){} // RVA: 0x7AD9800
        public void .cctor(){} // RVA: 0x7AD9870
    }

    public class IAccessibilityNotificationDispatcher
    {
        // ── Methods ──
        public void SendScreenChanged(){} // RVA: 0x894320
    }

    public class IService
    {
        // ── Methods ──
        public void Stop(){} // RVA: 0x894290
    }

    public class ServiceManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADB540
        public void GetService(){} // RVA: 0x29B4580
        public void StopService(){} // RVA: 0x29B4AA0
        public void UpdateServices(){} // RVA: 0x7ADB6F0
        public void ScreenReaderStatusChanged(){} // RVA: 0x7ADB960
    }

}