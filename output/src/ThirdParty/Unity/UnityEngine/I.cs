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
        public void LogFormat(){} // RVA: 0x7FFAF2AD7F90
        public void LogException(){} // RVA: 0x7FFAF2ADDC60
    }

    public class ILogger
    {
        // ── Methods ──
        public void get_logHandler(){} // RVA: 0x7FFAF2ABCD60
        public void set_logHandler(){} // RVA: 0x7FFAF2AD4B10
        public void get_logEnabled(){} // RVA: 0x7FFAF2ABDBE0
        public void IsLogTypeAllowed(){} // RVA: 0x7FFAF2ABE1F0
        public void Log(){} // RVA: 0x7FFAF2ADDC60 | overloaded x4
        public void LogWarning(){} // RVA: 0x7FFAF2ADDC60
        public void LogError(){} // RVA: 0x7FFAF2ADDC60
        public void LogFormat(){} // RVA: 0x7FFAF2AD79F0
        public void LogException(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IPlayerEditorConnectionNative
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF2AD4A50
        public void DisconnectAll(){} // RVA: 0x7FFAF2AD4A50
        public void SendMessage(){}
        public void TrySendMessage(){}
        public void Poll(){} // RVA: 0x7FFAF2AD4A50
        public void RegisterInternal(){} // RVA: 0x7FFAF2AD4B10
        public void UnregisterInternal(){} // RVA: 0x7FFAF2AD4B10
        public void IsConnected(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class ISerializationCallbackReceiver
    {
        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7FFAF2AD4A50
        public void OnAfterDeserialize(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ISubsystem
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF2AD4A50
        public void Stop(){} // RVA: 0x7FFAF2AD4A50
        public void Destroy(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ISubsystemDescriptor
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAF2ABCD60
        public void Create(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ImageConversion
    {
        // ── Methods ──
        public void EncodeToPNG(){} // RVA: 0x7FFAF9C1D730
        public void EncodeToJPG(){} // RVA: 0x7FFAF9C1D780
        public void LoadImage(){} // RVA: 0x7FFAF9C1D850 | overloaded x2
        public void EncodeNativeArrayToPNG(){} // RVA: 0x7FFAF2D33FA0
        public void UnsafeEncodeNativeArrayToPNG(){} // RVA: 0x7FFAF9C1D8C0
    }

    public class ImageEffectAllowedInSceneView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ImageEffectOpaque
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ImageEffectUsesCommandBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Input
    {
        // ── Methods ──
        public void GetAxis(){} // RVA: 0x7FFAF9C58450
        public void GetAxisRaw(){} // RVA: 0x7FFAF9C584A0
        public void GetButton(){} // RVA: 0x7FFAF9C584F0
        public void GetButtonDown(){} // RVA: 0x7FFAF9C58540
        public void GetButtonUp(){} // RVA: 0x7FFAF9C58590
        public void GetKeyInt(){} // RVA: 0x7FFAF9C585E0
        public void GetKeyUpInt(){} // RVA: 0x7FFAF9C58630
        public void GetKeyDownInt(){} // RVA: 0x7FFAF9C58680
        public void GetMouseButton(){} // RVA: 0x7FFAF9C586D0
        public void GetMouseButtonDown(){} // RVA: 0x7FFAF9C58720
        public void GetMouseButtonUp(){} // RVA: 0x7FFAF9C58770
        public void GetJoystickNames(){} // RVA: 0x7FFAF9C587C0
        public void GetTouch(){} // RVA: 0x7FFAF9C58810
        public void GetLastPenContactEvent(){} // RVA: 0x7FFAF9C58890
        public void ClearLastPenContactEvent(){} // RVA: 0x7FFAF9C58900
        public void GetKey(){} // RVA: 0x7FFAF9C58950 | overloaded x2
        public void GetKeyUp(){} // RVA: 0x7FFAF9C589A0 | overloaded x2
        public void GetKeyDown(){} // RVA: 0x7FFAF9C589F0 | overloaded x2
        public void get_anyKey(){} // RVA: 0x7FFAF9C58A40
        public void get_anyKeyDown(){} // RVA: 0x7FFAF9C58A90
        public void get_inputString(){} // RVA: 0x7FFAF9C58AE0
        public void get_mousePosition(){} // RVA: 0x7FFAF9C58B30
        public void get_mouseScrollDelta(){} // RVA: 0x7FFAF9C58B90
        public void get_imeCompositionMode(){} // RVA: 0x7FFAF9C58BF0
        public void set_imeCompositionMode(){} // RVA: 0x7FFAF9C58C40
        public void get_compositionString(){} // RVA: 0x7FFAF9C58C90
        public void get_imeIsSelected(){} // RVA: 0x7FFAF9C58CE0
        public void get_compositionCursorPos(){} // RVA: 0x7FFAF9C58D30
        public void set_compositionCursorPos(){} // RVA: 0x7FFAF9C58D90
        public void get_mousePresent(){} // RVA: 0x7FFAF9C58DE0
        public void get_touchCount(){} // RVA: 0x7FFAF9C58E30
        public void get_touchSupported(){} // RVA: 0x7FFAF3FC0190
        public void get_deviceOrientation(){} // RVA: 0x7FFAF9C58E80
        public void get_acceleration(){} // RVA: 0x7FFAF9C58ED0
        public void get_touches(){} // RVA: 0x7FFAF9C58F30
        public void CheckDisabled(){} // RVA: 0x7FFAF9C590C0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void GetTouch_Injected(){} // RVA: 0x7FFAF9C59110
        public void GetLastPenContactEvent_Injected(){} // RVA: 0x7FFAF9C59170
        public void get_mousePosition_Injected(){} // RVA: 0x7FFAF9C591C0
        public void get_mouseScrollDelta_Injected(){} // RVA: 0x7FFAF9C59210
        public void get_compositionCursorPos_Injected(){} // RVA: 0x7FFAF9C59260
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7FFAF9C592B0
        public void get_acceleration_Injected(){} // RVA: 0x7FFAF9C59300
    }

    public class InspectorNameAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
    }

    public class InspectorOrderAttribute
    {
        // ── Methods ──
        public void get_m_inspectorSort(){} // RVA: 0x7FFAF2DDA5C0
        public void get_m_sortDirection(){} // RVA: 0x7FFAF335BED0
    }

    public class IntegratedSubsystem
    {
        // ── Methods ──
        public void SetHandle(){} // RVA: 0x7FFAF9D09890
        public void Start(){} // RVA: 0x7FFAF9D098F0
        public void Stop(){} // RVA: 0x7FFAF9D09940
        public void Destroy(){} // RVA: 0x7FFAF9D09990
        public void get_running(){} // RVA: 0x7FFAF9D09BC0
        public void get_valid(){} // RVA: 0x7FFAF9D09C30
        public void IsRunning(){} // RVA: 0x7FFAF9D09C40
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IntegratedSubsystemDescriptor
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAF9D09CE0
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x7FFAF91CBFB0
        public void CreateImpl(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0x7FFAF2ABCD60
        public void Create(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0x7FFAF60712E0
        public void Create(){} // RVA: 0x7FFAF6071440
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0x7FFAF60712E0
        public void Create(){} // RVA: 0x7FFAF6071440
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0x7FFAF60712E0
        public void Create(){} // RVA: 0x7FFAF6071440
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IntegratedSubsystem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IntegratedSubsystem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IntegratedSubsystem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IntegratedSubsystem`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Internal_DrawTextureArguments
    {
    }

    public class Internal_SubsystemDescriptors
    {
        // ── Methods ──
        public void Internal_AddDescriptor(){} // RVA: 0x7FFAF9D09EB0
    }

}