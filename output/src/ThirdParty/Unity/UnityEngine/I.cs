// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 21
// Methods: 107

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
        public void LogFormat(){} // RVA: 0x7FFE80E49570
        public void LogException(){} // RVA: 0x7FFE80E4F230
    }

    public class ILogger
    {
        // ── Methods ──
        public void get_logHandler(){} // RVA: 0x7FFE80E2E2E0
        public void set_logHandler(){} // RVA: 0x7FFE80E460A0
        public void get_logEnabled(){} // RVA: 0x7FFE80E2F150
        public void IsLogTypeAllowed(){} // RVA: 0x7FFE80E2F760
        public void Log(){} // RVA: 0x7FFE80E4F230 | overloaded x4
        public void LogWarning(){} // RVA: 0x7FFE80E4F230
        public void LogError(){} // RVA: 0x7FFE80E4F230
        public void LogFormat(){} // RVA: 0x7FFE80E48FD0
        public void LogException(){} // RVA: 0x7FFE80E460A0
    }

    public class IPlayerEditorConnectionNative
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE80E45FE0
        public void DisconnectAll(){} // RVA: 0x7FFE80E45FE0
        public void SendMessage(){}
        public void TrySendMessage(){}
        public void Poll(){} // RVA: 0x7FFE80E45FE0
        public void RegisterInternal(){} // RVA: 0x7FFE80E460A0
        public void UnregisterInternal(){} // RVA: 0x7FFE80E460A0
        public void IsConnected(){} // RVA: 0x7FFE80E2F150
    }

    public class ISerializationCallbackReceiver
    {
        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7FFE80E45FE0
        public void OnAfterDeserialize(){} // RVA: 0x7FFE80E45FE0
    }

    public class ISubsystem
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE80E45FE0
        public void Stop(){} // RVA: 0x7FFE80E45FE0
        public void Destroy(){} // RVA: 0x7FFE80E45FE0
    }

    public class ISubsystemDescriptor
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE80E2E2E0
        public void Create(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ImageConversion : Object
    {
        // ── Methods ──
        public void EncodeToPNG(){} // RVA: 0x7FFE87CAD8D0
        public void EncodeToJPG(){} // RVA: 0x7FFE87CAD920
        public void LoadImage(){} // RVA: 0x7FFE87CAD9F0 | overloaded x2
        public void EncodeNativeArrayToPNG(){} // RVA: 0x7FFE810A1420
        public void UnsafeEncodeNativeArrayToPNG(){} // RVA: 0x7FFE87CADA60
    }

    public class ImageEffectAllowedInSceneView : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ImageEffectOpaque : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ImageEffectUsesCommandBuffer : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Input : Object
    {
        // ── Methods ──
        public void GetAxis(){} // RVA: 0x7FFE87CE85F0
        public void GetAxisRaw(){} // RVA: 0x7FFE87CE8640
        public void GetButton(){} // RVA: 0x7FFE87CE8690
        public void GetButtonDown(){} // RVA: 0x7FFE87CE86E0
        public void GetButtonUp(){} // RVA: 0x7FFE87CE8730
        public void GetKeyInt(){} // RVA: 0x7FFE87CE8780
        public void GetKeyUpInt(){} // RVA: 0x7FFE87CE87D0
        public void GetKeyDownInt(){} // RVA: 0x7FFE87CE8820
        public void GetMouseButton(){} // RVA: 0x7FFE87CE8870
        public void GetMouseButtonDown(){} // RVA: 0x7FFE87CE88C0
        public void GetMouseButtonUp(){} // RVA: 0x7FFE87CE8910
        public void GetJoystickNames(){} // RVA: 0x7FFE87CE8960
        public void GetTouch(){} // RVA: 0x7FFE87CE89B0
        public void GetLastPenContactEvent(){} // RVA: 0x7FFE87CE8A30
        public void ClearLastPenContactEvent(){} // RVA: 0x7FFE87CE8AA0
        public void GetKey(){} // RVA: 0x7FFE87CE8AF0 | overloaded x2
        public void GetKeyUp(){} // RVA: 0x7FFE87CE8B40 | overloaded x2
        public void GetKeyDown(){} // RVA: 0x7FFE87CE8B90 | overloaded x2
        public void get_anyKey(){} // RVA: 0x7FFE87CE8BE0
        public void get_anyKeyDown(){} // RVA: 0x7FFE87CE8C30
        public void get_inputString(){} // RVA: 0x7FFE87CE8C80
        public void get_mousePosition(){} // RVA: 0x7FFE87CE8CD0
        public void get_mouseScrollDelta(){} // RVA: 0x7FFE87CE8D30
        public void get_imeCompositionMode(){} // RVA: 0x7FFE87CE8D90
        public void set_imeCompositionMode(){} // RVA: 0x7FFE87CE8DE0
        public void get_compositionString(){} // RVA: 0x7FFE87CE8E30
        public void get_imeIsSelected(){} // RVA: 0x7FFE87CE8E80
        public void get_compositionCursorPos(){} // RVA: 0x7FFE87CE8ED0
        public void set_compositionCursorPos(){} // RVA: 0x7FFE87CE8F30
        public void get_mousePresent(){} // RVA: 0x7FFE87CE8F80
        public void get_touchCount(){} // RVA: 0x7FFE87CE8FD0
        public void get_touchSupported(){} // RVA: 0x7FFE822B5720
        public void get_deviceOrientation(){} // RVA: 0x7FFE87CE9020
        public void get_acceleration(){} // RVA: 0x7FFE87CE9070
        public void get_touches(){} // RVA: 0x7FFE87CE90D0
        public void CheckDisabled(){} // RVA: 0x7FFE87CE9260
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetTouch_Injected(){} // RVA: 0x7FFE87CE92B0
        public void GetLastPenContactEvent_Injected(){} // RVA: 0x7FFE87CE9310
        public void get_mousePosition_Injected(){} // RVA: 0x7FFE87CE9360
        public void get_mouseScrollDelta_Injected(){} // RVA: 0x7FFE87CE93B0
        public void get_compositionCursorPos_Injected(){} // RVA: 0x7FFE87CE9400
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7FFE87CE9450
        public void get_acceleration_Injected(){} // RVA: 0x7FFE87CE94A0
    }

    public class InspectorNameAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class InspectorOrderAttribute : PropertyAttribute
    {
        public 0x665788AC _m_inspectorSort; // 0x10
        public 0x66578904 _m_sortDirection; // 0x14

        // ── Methods ──
        public void get_m_inspectorSort(){} // RVA: 0x7FFE811485C0
        public void get_m_sortDirection(){} // RVA: 0x7FFE8164B230
    }

    public class IntegratedSubsystem : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public UnityEngine.ISubsystemDescriptor m_SubsystemDescriptor; // 0x18

        // ── Methods ──
        public void SetHandle(){} // RVA: 0x7FFE87D99A30
        public void Start(){} // RVA: 0x7FFE87D99A90
        public void Stop(){} // RVA: 0x7FFE87D99AE0
        public void Destroy(){} // RVA: 0x7FFE87D99B30
        public void get_running(){} // RVA: 0x7FFE87D99D60
        public void get_valid(){} // RVA: 0x7FFE87D99DD0
        public void IsRunning(){} // RVA: 0x7FFE87D99DE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IntegratedSubsystemDescriptor : Object
    {
        public UIntPtr m_Ptr; // 0x10

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE87D99E80
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x7FFE8725AEB0
        public void CreateImpl(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IntegratedSubsystemDescriptor`1 : IntegratedSubsystemDescriptor
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0x7FFE80E2E2E0
        public void Create(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class IntegratedSubsystem`1 : IntegratedSubsystem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class Internal_DrawTextureArguments : ValueType
    {
    }

    public class Internal_SubsystemDescriptors : Object
    {
        // ── Methods ──
        public void Internal_AddDescriptor(){} // RVA: 0x7FFE87D9A050
    }

}