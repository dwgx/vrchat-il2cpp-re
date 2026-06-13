// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
// Classes: 4
// Methods: 46

namespace ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
{
    public class OnScreenButton
    {
        public string m_ControlPath; // 0x38

        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x6EC07D0
        public void OnPointerDown(){} // RVA: 0x6EC0820
        public void get_controlPathInternal(){} // RVA: 0x4976A0
        public void set_controlPathInternal(){} // RVA: 0x49B830
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class OnScreenControl
    {
        public UnityEngine.InputSystem.InputControl m_Control; // 0x20
        public UnityEngine.InputSystem.OnScreen.OnScreenControl m_NextControlOnDevice; // 0x28
        public UnityEngine.InputSystem.LowLevel.InputEventPtr m_InputEventPtr; // 0x30
        public int s_nbActiveInstances;

        // ── Methods ──
        public void get_controlPath(){} // RVA: 0x391BC0
        public void set_controlPath(){} // RVA: 0x6EC0870
        public void get_control(){} // RVA: 0x30B0C0
        public void get_controlPathInternal(){} // RVA: 0xCD60
        public void set_controlPathInternal(){} // RVA: 0x24B10
        public void SetupInputControl(){} // RVA: 0x6EC08F0
        public void SendValueToControl(){} // RVA: 0x283FA0
        public void SentDefaultValueToControl(){} // RVA: 0x6EC1360
        public void get_HasAnyActive(){} // RVA: 0x6EC1430
        public void OnEnable(){} // RVA: 0x6EC1470
        public void OnDisable(){} // RVA: 0x6EC1850
        public void GetWarningMessage(){} // RVA: 0x6EC1B90
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class OnScreenStick
    {
        public string kDynamicOriginClickable;
        public float m_MovementRange; // 0x38
        public float m_DynamicOriginRange; // 0x3C
        public string m_ControlPath; // 0x40
        public 0x6586C700 m_Behaviour; // 0x48

        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x6EC3820 | overloaded x2
        public void OnDrag(){} // RVA: 0x6EC23E0
        public void OnPointerUp(){} // RVA: 0x6EC4190 | overloaded x2
        public void Start(){} // RVA: 0x6EC24A0
        public void OnDestroy(){} // RVA: 0x6EC2EE0
        public void BeginInteraction(){} // RVA: 0x6EC2FB0
        public void MoveStick(){} // RVA: 0x6EC32A0
        public void EndInteraction(){} // RVA: 0x6EC3690
        public void OnPointerChanged(){} // RVA: 0x6EC3E80
        public void OnPointerMove(){} // RVA: 0x6EC4050
        public void GetCameraFromCanvas(){} // RVA: 0x6EC42D0
        public void OnDrawGizmosSelected(){} // RVA: 0x6EC44C0
        public void DrawGizmoCircle(){} // RVA: 0x6EC4A40
        public void UpdateDynamicOriginClickableArea(){} // RVA: 0x6EC4C00
        public void get_movementRange(){} // RVA: 0x4FE250
        public void set_movementRange(){} // RVA: 0x4FB970
        public void get_dynamicOriginRange(){} // RVA: 0x9FC6D0
        public void set_dynamicOriginRange(){} // RVA: 0x6EC4E90
        public void get_useIsolatedInputActions(){} // RVA: 0x16DA880
        public void set_useIsolatedInputActions(){} // RVA: 0x16E0A80
        public void get_controlPathInternal(){} // RVA: 0x35A740
        public void set_controlPathInternal(){} // RVA: 0x305200
        public void get_behaviour(){} // RVA: 0x37E0C0
        public void set_behaviour(){} // RVA: 0x37E0D0
        public void .ctor(){} // RVA: 0x6EC4EB0
    }

    public class UGUIOnScreenControlUtils
    {
        // ── Methods ──
        public void GetCanvasRectTransform(){} // RVA: 0x6EC21A0
    }

}