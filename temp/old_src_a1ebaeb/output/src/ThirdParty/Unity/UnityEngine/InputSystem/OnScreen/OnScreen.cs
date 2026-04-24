// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
// Classes: 3
// Methods: 45

namespace ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
{
    public class OnScreenButton : OnScreenControl
    {
        // ── Original Methods ──
        public void OnPointerUp(){} // RVA: 0x7ffaaf07aee0
        public void OnPointerDown(){} // RVA: 0x7ffaaf07af30
        public void get_controlPathInternal(){} // RVA: 0x7ffaa8bf45b0
        public void set_controlPathInternal(){} // RVA: 0x7ffaa8bf45c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class OnScreenControl : MonoBehaviour
    {
        public object m_InputEventPtr; // 0x31858890
        public object m_EventPtr; // 0x317BAAC0

        // ── Original Methods ──
        public void get_controlPath(){} // RVA: 0x7ffaa89e6bc0
        public void set_controlPath(){} // RVA: 0x7ffaaf07af80
        public void get_control(){} // RVA: 0x7ffaa89600c0
        public void get_controlPathInternal(){} // RVA: 0x7ffaa86491d0
        public void set_controlPathInternal(){} // RVA: 0x7ffaa8660d80
        public void SendValueToControl(){} // RVA: 0x7ffaa887e5c0
        public void SentDefaultValueToControl(){} // RVA: 0x7ffaaf07ba70
        public void get_HasAnyActive(){} // RVA: 0x7ffaaf07bb40
        public void OnEnable(){} // RVA: 0x7ffaaf07bb80
        public void OnDisable(){} // RVA: 0x7ffaaf07bf60
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void SetupInputControl(){} // RVA: 0x7ffaaf07b000
        public void GetWarningMessage(){} // RVA: 0x7ffaaf07c2a0
    }

    public class OnScreenStick : OnScreenControl
    {
        public object m_DynamicOriginRange; // 0x33C4CFF0
        public object m_UseIsolatedInputActions; // 0x33C4CFF0
        public object m_StartPos; // 0x33C4CFF0
        public object m_PointerEventData; // 0x33C4CFF0

        // ── Original Methods ──
        public void OnPointerDown(){} // RVA: 0x7ffaaf07df30
        public void OnDrag(){} // RVA: 0x7ffaaf07caf0
        public void OnPointerUp(){} // RVA: 0x7ffaaf07e8a0
        public void Start(){} // RVA: 0x7ffaaf07cbb0
        public void OnDestroy(){} // RVA: 0x7ffaaf07d5f0
        public void MoveStick(){} // RVA: 0x7ffaaf07d9b0
        public void EndInteraction(){} // RVA: 0x7ffaaf07dda0
        public void OnPointerDown(){} // RVA: 0x7ffaaf07df30
        public void OnPointerChanged(){} // RVA: 0x7ffaaf07e590
        public void OnPointerMove(){} // RVA: 0x7ffaaf07e760
        public void OnPointerUp(){} // RVA: 0x7ffaaf07e8a0
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaaf07ebd0
        public void DrawGizmoCircle(){} // RVA: 0x7ffaaf07f150
        public void UpdateDynamicOriginClickableArea(){} // RVA: 0x7ffaaf07f310
        public void get_movementRange(){} // RVA: 0x7ffaa9144a40
        public void set_movementRange(){} // RVA: 0x7ffaa9144ae0
        public void get_dynamicOriginRange(){} // RVA: 0x7ffaa9068340
        public void set_dynamicOriginRange(){} // RVA: 0x7ffaaf07f5a0
        public void get_useIsolatedInputActions(){} // RVA: 0x7ffaa9b8bd80
        public void set_useIsolatedInputActions(){} // RVA: 0x7ffaa9b91500
        public void get_controlPathInternal(){} // RVA: 0x7ffaa89af740
        public void set_controlPathInternal(){} // RVA: 0x7ffaa895a200
        public void get_behaviour(){} // RVA: 0x7ffaa89d30c0
        public void set_behaviour(){} // RVA: 0x7ffaa89d30d0
        public void .ctor(){} // RVA: 0x7ffaaf07f5c0
        // ── Binary Analysis Named ──
        public void BeginInteraction(){} // RVA: 0x7ffaaf07d6c0
        public void GetCameraFromCanvas(){} // RVA: 0x7ffaaf07e9e0
    }

}