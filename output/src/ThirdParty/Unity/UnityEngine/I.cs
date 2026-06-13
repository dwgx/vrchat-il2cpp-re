// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 27
// Methods: 119

namespace ThirdParty.Unity.UnityEngine
{
    public class ICanvasRaycastFilter
    {
        // ── Methods ──
        public void IsRaycastLocationValid(){}
    }

    public class IExposedPropertyTable
    {
        // ── Methods ──
        public void GetReferenceValue(){}
    }

    public class ILogHandler
    {
        // ── Methods ──
        public void LogFormat(){} // RVA: 0x27F90
        public void LogException(){} // RVA: 0x2DC60
    }

    public class ILogger
    {
        // ── Methods ──
        public void get_logHandler(){} // RVA: 0xCD60
        public void set_logHandler(){} // RVA: 0x24B10
        public void get_logEnabled(){} // RVA: 0xDBE0
        public void IsLogTypeAllowed(){} // RVA: 0xE1F0
        public void Log(){} // RVA: 0x2DC60 | overloaded x4
        public void LogWarning(){} // RVA: 0x2DC60
        public void LogError(){} // RVA: 0x2DC60
        public void LogFormat(){} // RVA: 0x279F0
        public void LogException(){} // RVA: 0x24B10
    }

    public class IPlayerEditorConnectionNative
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x24A50
        public void DisconnectAll(){} // RVA: 0x24A50
        public void SendMessage(){}
        public void TrySendMessage(){}
        public void Poll(){} // RVA: 0x24A50
        public void RegisterInternal(){} // RVA: 0x24B10
        public void UnregisterInternal(){} // RVA: 0x24B10
        public void IsConnected(){} // RVA: 0xDBE0
    }

    public class ISerializationCallbackReceiver
    {
        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x24A50
        public void OnAfterDeserialize(){} // RVA: 0x24A50
    }

    public class ISubsystem
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x24A50
        public void Stop(){} // RVA: 0x24A50
        public void Destroy(){} // RVA: 0x24A50
    }

    public class ISubsystemDescriptor
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0xCD60
        public void Create(){} // RVA: 0xCD60
    }

    public class ImageConversion
    {
        // ── Methods ──
        public void EncodeToPNG(){} // RVA: 0x716D730
        public void EncodeToJPG(){} // RVA: 0x716D780
        public void LoadImage(){} // RVA: 0x716D850 | overloaded x2
        public void EncodeNativeArrayToPNG(){} // RVA: 0x283FA0
        public void UnsafeEncodeNativeArrayToPNG(){} // RVA: 0x716D8C0
    }

    public class ImageEffectAllowedInSceneView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ImageEffectOpaque
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ImageEffectUsesCommandBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Input
    {
        // ── Methods ──
        public void GetAxis(){} // RVA: 0x71A8450
        public void GetAxisRaw(){} // RVA: 0x71A84A0
        public void GetButton(){} // RVA: 0x71A84F0
        public void GetButtonDown(){} // RVA: 0x71A8540
        public void GetButtonUp(){} // RVA: 0x71A8590
        public void GetKeyInt(){} // RVA: 0x71A85E0
        public void GetKeyUpInt(){} // RVA: 0x71A8630
        public void GetKeyDownInt(){} // RVA: 0x71A8680
        public void GetMouseButton(){} // RVA: 0x71A86D0
        public void GetMouseButtonDown(){} // RVA: 0x71A8720
        public void GetMouseButtonUp(){} // RVA: 0x71A8770
        public void GetJoystickNames(){} // RVA: 0x71A87C0
        public void GetTouch(){} // RVA: 0x71A8810
        public void GetLastPenContactEvent(){} // RVA: 0x71A8890
        public void ClearLastPenContactEvent(){} // RVA: 0x71A8900
        public void GetKey(){} // RVA: 0x71A8950 | overloaded x2
        public void GetKeyUp(){} // RVA: 0x71A89A0 | overloaded x2
        public void GetKeyDown(){} // RVA: 0x71A89F0 | overloaded x2
        public void get_anyKey(){} // RVA: 0x71A8A40
        public void get_anyKeyDown(){} // RVA: 0x71A8A90
        public void get_inputString(){} // RVA: 0x71A8AE0
        public void get_mousePosition(){} // RVA: 0x71A8B30
        public void get_mouseScrollDelta(){} // RVA: 0x71A8B90
        public void get_imeCompositionMode(){} // RVA: 0x71A8BF0
        public void set_imeCompositionMode(){} // RVA: 0x71A8C40
        public void get_compositionString(){} // RVA: 0x71A8C90
        public void get_imeIsSelected(){} // RVA: 0x71A8CE0
        public void get_compositionCursorPos(){} // RVA: 0x71A8D30
        public void set_compositionCursorPos(){} // RVA: 0x71A8D90
        public void get_mousePresent(){} // RVA: 0x71A8DE0
        public void get_touchCount(){} // RVA: 0x71A8E30
        public void get_touchSupported(){} // RVA: 0x1510190
        public void get_deviceOrientation(){} // RVA: 0x71A8E80
        public void get_acceleration(){} // RVA: 0x71A8ED0
        public void get_touches(){} // RVA: 0x71A8F30
        public void CheckDisabled(){} // RVA: 0x71A90C0
        public void .ctor(){} // RVA: 0x2DD310
        public void GetTouch_Injected(){} // RVA: 0x71A9110
        public void GetLastPenContactEvent_Injected(){} // RVA: 0x71A9170
        public void get_mousePosition_Injected(){} // RVA: 0x71A91C0
        public void get_mouseScrollDelta_Injected(){} // RVA: 0x71A9210
        public void get_compositionCursorPos_Injected(){} // RVA: 0x71A9260
        public void set_compositionCursorPos_Injected(){} // RVA: 0x71A92B0
        public void get_acceleration_Injected(){} // RVA: 0x71A9300
    }

    public class InspectorNameAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class InspectorOrderAttribute
    {
        public 0x6589B040 <m_inspectorSort>k__BackingField; // 0x10
        public 0x6589B098 <m_sortDirection>k__BackingField; // 0x14

        // ── Methods ──
        public void get_m_inspectorSort(){} // RVA: 0x32A5C0
        public void get_m_sortDirection(){} // RVA: 0x8ABED0
    }

    public class IntegratedSubsystem
    {
        public UIntPtr m_Ptr; // 0x10
        public UnityEngine.ISubsystemDescriptor m_SubsystemDescriptor; // 0x18

        // ── Methods ──
        public void SetHandle(){} // RVA: 0x7259890
        public void Start(){} // RVA: 0x72598F0
        public void Stop(){} // RVA: 0x7259940
        public void Destroy(){} // RVA: 0x7259990
        public void get_running(){} // RVA: 0x7259BC0
        public void get_valid(){} // RVA: 0x7259C30
        public void IsRunning(){} // RVA: 0x7259C40
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IntegratedSubsystemDescriptor
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void get_id(){} // RVA: 0x7259CE0
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x671BFB0
        public void CreateImpl(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0xCD60
        public void Create(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0x35C12E0
        public void Create(){} // RVA: 0x35C1440
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0x35C12E0
        public void Create(){} // RVA: 0x35C1440
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0x35C12E0
        public void Create(){} // RVA: 0x35C1440
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IntegratedSubsystem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
    }

    public class IntegratedSubsystem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IntegratedSubsystem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IntegratedSubsystem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Internal_DrawTextureArguments
    {
    }

    public class Internal_SubsystemDescriptors
    {
        // ── Methods ──
        public void Internal_AddDescriptor(){} // RVA: 0x7259EB0
    }

}