// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
// Classes: 4
// Methods: 44

namespace ThirdParty.Unity.UnityEngine.InputSystem.OnScreen
{
    public class OnScreenButton : OnScreenControl
    {
        public object m_ControlPath;

        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x790CFA0
        public void OnPointerDown(){} // RVA: 0x790CFF0
        public void get_controlPathInternal(){} // RVA: 0xD05CA0
        public void set_controlPathInternal(){} // RVA: 0xD09D70
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class OnScreenControl : MonoBehaviour
    {
        public object m_Control;
        public object m_NextControlOnDevice;
        public object m_InputEventPtr;
        public object s_nbActiveInstances;
        public object s_OnScreenDevices;

        // ── Methods ──
        public void get_controlPath(){} // RVA: 0xBFA210
        public void set_controlPath(){} // RVA: 0x790D040
        public void get_control(){} // RVA: 0xB700F0
        public void get_controlPathInternal(){} // RVA: 0x87C0A0
        public void set_controlPathInternal(){} // RVA: 0x894320
        public void SetupInputControl(){} // RVA: 0x790D0F0
        public void SendValueToControl(){} // RVA: 0xA94080
        public void SentDefaultValueToControl(){} // RVA: 0x790DC40
        public void get_HasAnyActive(){} // RVA: 0x790DD10
        public void OnEnable(){} // RVA: 0x790DD50
        public void OnDisable(){} // RVA: 0x790E140
        public void GetWarningMessage(){} // RVA: 0x790E480
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class OnScreenStick : OnScreenControl
    {
        public object kDynamicOriginClickable;
        public object m_MovementRange;
        public object m_DynamicOriginRange;
        public object m_ControlPath;
        public object m_Behaviour;
        public object m_UseIsolatedInputActions;
        public object m_PointerDownAction;
        public object m_PointerMoveAction;
        public object m_StartPos;
        public object m_PointerDownPos;
        public object m_RaycastResults;
        public object m_PointerEventData;
        public object m_TouchControl;
        public object m_IsIsolationActive;

        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x790FED0
        public void OnDrag(){} // RVA: 0x790EC60
        public void OnPointerUp(){} // RVA: 0x7910820
        public void Start(){} // RVA: 0x790ED20
        public void OnDestroy(){} // RVA: 0x790F690
        public void BeginInteraction(){} // RVA: 0x790F760
        public void MoveStick(){} // RVA: 0x790FA10
        public void EndInteraction(){} // RVA: 0x790FDD0
        public void OnPointerChanged(){} // RVA: 0x7910510
        public void OnPointerMove(){} // RVA: 0x79106E0
        public void GetCameraFromCanvas(){} // RVA: 0x7910960
        public void OnDrawGizmosSelected(){} // RVA: 0x7910B10
        public void DrawGizmoCircle(){} // RVA: 0x7911070
        public void UpdateDynamicOriginClickableArea(){} // RVA: 0x7911230
        public void get_movementRange(){} // RVA: 0x11E18C0
        public void set_movementRange(){} // RVA: 0x11E1470
        public void get_dynamicOriginRange(){} // RVA: 0x12CA360
        public void set_dynamicOriginRange(){} // RVA: 0x7911400
        public void get_useIsolatedInputActions(){} // RVA: 0x1FAA110
        public void set_useIsolatedInputActions(){} // RVA: 0x1FABCC0
        public void get_controlPathInternal(){} // RVA: 0xBC1B30
        public void set_controlPathInternal(){} // RVA: 0xB6A8C0
        public void get_behaviour(){} // RVA: 0xBE5890
        public void set_behaviour(){} // RVA: 0xBE58A0
        public void .ctor(){} // RVA: 0x7911420
    }

    public class UGUIOnScreenControlUtils : Object
    {
        // ── Methods ──
        public void GetCanvasRectTransform(){} // RVA: 0x790EA90
    }

}