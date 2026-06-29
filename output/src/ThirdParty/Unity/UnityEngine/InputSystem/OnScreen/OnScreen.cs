// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
// Classes: 4
// Methods: 44

namespace ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
{
    public class OnScreenButton : OnScreenControl
    {
        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x7AEC9EDB0
        public void OnPointerDown(){} // RVA: 0x7AEC9EE00
        public void get_controlPathInternal(){} // RVA: 0x7A8292C30
        public void set_controlPathInternal(){} // RVA: 0x7A8296DE0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class OnScreenControl : MonoBehaviour
    {
        // ── Methods ──
        public void get_controlPath(){} // RVA: 0x7A818C700
        public void set_controlPath(){} // RVA: 0x7AEC9EE50
        public void get_control(){} // RVA: 0x7A81052C0
        public void get_controlPathInternal(){} // RVA: 0x7A7E00680
        public void set_controlPathInternal(){} // RVA: 0x7A7E18800
        public void SetupInputControl(){} // RVA: 0x7AEC9EED0
        public void SendValueToControl(){} // RVA: 0x7A8051B10
        public void SentDefaultValueToControl(){} // RVA: 0x7AEC9FA20
        public void get_HasAnyActive(){} // RVA: 0x7AEC9FAF0
        public void OnEnable(){} // RVA: 0x7AEC9FB30
        public void OnDisable(){} // RVA: 0x7AEC9FF20
        public void GetWarningMessage(){} // RVA: 0x7AECA0260
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class OnScreenStick : OnScreenControl
    {
        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x7AECA1EF0
        public void OnDrag(){} // RVA: 0x7AECA0AB0
        public void OnPointerUp(){} // RVA: 0x7AECA2870
        public void Start(){} // RVA: 0x7AECA0B70
        public void OnDestroy(){} // RVA: 0x7AECA15B0
        public void BeginInteraction(){} // RVA: 0x7AECA1680
        public void MoveStick(){} // RVA: 0x7AECA1970
        public void EndInteraction(){} // RVA: 0x7AECA1D60
        public void OnPointerChanged(){} // RVA: 0x7AECA2560
        public void OnPointerMove(){} // RVA: 0x7AECA2730
        public void GetCameraFromCanvas(){} // RVA: 0x7AECA29B0
        public void OnDrawGizmosSelected(){} // RVA: 0x7AECA2BA0
        public void DrawGizmoCircle(){} // RVA: 0x7AECA3130
        public void UpdateDynamicOriginClickableArea(){} // RVA: 0x7AECA32F0
        public void get_movementRange(){} // RVA: 0x7A8891F60
        public void set_movementRange(){} // RVA: 0x7A8891A80
        public void get_dynamicOriginRange(){} // RVA: 0x7A87B9920
        public void set_dynamicOriginRange(){} // RVA: 0x7AECA3580
        public void get_useIsolatedInputActions(){} // RVA: 0x7A9471CE0
        public void set_useIsolatedInputActions(){} // RVA: 0x7A9478060
        public void get_controlPathInternal(){} // RVA: 0x7A8154D80
        public void set_controlPathInternal(){} // RVA: 0x7A80FF440
        public void get_behaviour(){} // RVA: 0x7A8178B70
        public void set_behaviour(){} // RVA: 0x7A8178B80
        public void .ctor(){} // RVA: 0x7AECA35A0
    }

    public class UGUIOnScreenControlUtils : Object
    {
        // ── Methods ──
        public void GetCanvasRectTransform(){} // RVA: 0x7AECA0870
    }

}