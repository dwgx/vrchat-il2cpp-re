// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
// Classes: 4
// Methods: 46

namespace ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
{
    public class OnScreenButton : OnScreenControl
    {
        public string m_ControlPath; // 0x38

        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x7FFE87A01660
        public void OnPointerDown(){} // RVA: 0x7FFE87A016B0
        public void get_controlPathInternal(){} // RVA: 0x7FFE8143BA80
        public void set_controlPathInternal(){} // RVA: 0x7FFE81437330
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class OnScreenControl : MonoBehaviour
    {
        public UnityEngine.InputSystem.InputControl m_Control; // 0x20
        public UnityEngine.InputSystem.OnScreen.OnScreenControl m_NextControlOnDevice; // 0x28
        public UnityEngine.InputSystem.LowLevel.InputEventPtr m_InputEventPtr; // 0x30
        public int s_nbActiveInstances;

        // ── Methods ──
        public void get_controlPath(){} // RVA: 0x7FFE811AFBC0
        public void set_controlPath(){} // RVA: 0x7FFE87A01700
        public void get_control(){} // RVA: 0x7FFE811290C0
        public void get_controlPathInternal(){} // RVA: 0x7FFE80E2E2E0
        public void set_controlPathInternal(){} // RVA: 0x7FFE80E460A0
        public void SetupInputControl(){} // RVA: 0x7FFE87A01780
        public void SendValueToControl(){} // RVA: 0x7FFE810A1420
        public void SentDefaultValueToControl(){} // RVA: 0x7FFE87A021F0
        public void get_HasAnyActive(){} // RVA: 0x7FFE87A022C0
        public void OnEnable(){} // RVA: 0x7FFE87A02300
        public void OnDisable(){} // RVA: 0x7FFE87A026E0
        public void GetWarningMessage(){} // RVA: 0x7FFE87A02A20
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class OnScreenStick : OnScreenControl
    {
        public string kDynamicOriginClickable;
        public float m_MovementRange; // 0x38
        public float m_DynamicOriginRange; // 0x3C
        public string m_ControlPath; // 0x40
        public 0x665445B4 m_Behaviour; // 0x48

        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x7FFE87A046B0 | overloaded x2
        public void OnDrag(){} // RVA: 0x7FFE87A03270
        public void OnPointerUp(){} // RVA: 0x7FFE87A05020 | overloaded x2
        public void Start(){} // RVA: 0x7FFE87A03330
        public void OnDestroy(){} // RVA: 0x7FFE87A03D70
        public void BeginInteraction(){} // RVA: 0x7FFE87A03E40
        public void MoveStick(){} // RVA: 0x7FFE87A04130
        public void EndInteraction(){} // RVA: 0x7FFE87A04520
        public void OnPointerChanged(){} // RVA: 0x7FFE87A04D10
        public void OnPointerMove(){} // RVA: 0x7FFE87A04EE0
        public void GetCameraFromCanvas(){} // RVA: 0x7FFE87A05160
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE87A05350
        public void DrawGizmoCircle(){} // RVA: 0x7FFE87A058D0
        public void UpdateDynamicOriginClickableArea(){} // RVA: 0x7FFE87A05A90
        public void get_movementRange(){} // RVA: 0x7FFE8130ACF0
        public void set_movementRange(){} // RVA: 0x7FFE8130A000
        public void get_dynamicOriginRange(){} // RVA: 0x7FFE8178C5D0
        public void set_dynamicOriginRange(){} // RVA: 0x7FFE87A05D20
        public void get_useIsolatedInputActions(){} // RVA: 0x7FFE82447BA0
        public void set_useIsolatedInputActions(){} // RVA: 0x7FFE824479E0
        public void get_controlPathInternal(){} // RVA: 0x7FFE81178740
        public void set_controlPathInternal(){} // RVA: 0x7FFE81123200
        public void get_behaviour(){} // RVA: 0x7FFE8119C0C0
        public void set_behaviour(){} // RVA: 0x7FFE8119C0D0
        public void .ctor(){} // RVA: 0x7FFE87A05D40
    }

    public class UGUIOnScreenControlUtils : Object
    {
        // ── Methods ──
        public void GetCanvasRectTransform(){} // RVA: 0x7FFE87A03030
    }

}