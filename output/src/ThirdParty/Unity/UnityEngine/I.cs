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
        public void LogFormat(){} // RVA: 0x7FFAC2C73F00
        public void LogException(){} // RVA: 0x7FFAC2C79B30
    }

    public class ILogger
    {
        public object logHandler;
        public object logEnabled;

        // ── Methods ──
        public void get_logHandler(){} // RVA: 0x7FFAC2C58E90
        public void set_logHandler(){} // RVA: 0x7FFAC2C70A40
        public void get_logEnabled(){} // RVA: 0x7FFAC2C59D00
        public void IsLogTypeAllowed(){} // RVA: 0x7FFAC2C5A310
        public void Log(){} // RVA: 0x7FFAC2C79B30 | overloaded x4
        public void LogWarning(){} // RVA: 0x7FFAC2C79B30
        public void LogError(){} // RVA: 0x7FFAC2C79B30
        public void LogFormat(){} // RVA: 0x7FFAC2C73960
        public void LogException(){} // RVA: 0x7FFAC2C70A40
    }

    public class IPlayerEditorConnectionNative
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC2C70980
        public void DisconnectAll(){} // RVA: 0x7FFAC2C70980
        public void SendMessage(){}
        public void TrySendMessage(){}
        public void Poll(){} // RVA: 0x7FFAC2C70980
        public void RegisterInternal(){} // RVA: 0x7FFAC2C70A40
        public void UnregisterInternal(){} // RVA: 0x7FFAC2C70A40
        public void IsConnected(){} // RVA: 0x7FFAC2C59D00
    }

    public class ISerializationCallbackReceiver
    {
        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC2C70980
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC2C70980
    }

    public class ISubsystem
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC2C70980
        public void Stop(){} // RVA: 0x7FFAC2C70980
        public void Destroy(){} // RVA: 0x7FFAC2C70980
    }

    public class ISubsystemDescriptor
    {
        public object id;

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAC2C58E90
        public void Create(){} // RVA: 0x7FFAC2C58E90
    }

    public class ImageConversion : Object
    {
        // ── Methods ──
        public void EncodeToPNG(){} // RVA: 0x7FFAC9905030
        public void EncodeToJPG(){} // RVA: 0x7FFAC9905080
        public void LoadImage(){} // RVA: 0x7FFAC9905150 | overloaded x2
        public void EncodeNativeArrayToPNG(){} // RVA: 0x7FFAC2E8DC40
        public void UnsafeEncodeNativeArrayToPNG(){} // RVA: 0x7FFAC99051C0
    }

    public class ImageEffectAllowedInSceneView : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ImageEffectOpaque : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ImageEffectUsesCommandBuffer : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Input : Object
    {
        public object anyKey;
        public object anyKeyDown;
        public object inputString;
        public object mousePosition;
        public object mouseScrollDelta;
        public object imeCompositionMode;
        public object compositionString;
        public object imeIsSelected;
        public object compositionCursorPos;
        public object mousePresent;
        public object touchCount;
        public object touchSupported;
        public object deviceOrientation;
        public object acceleration;
        public object touches;

        // ── Methods ──
        public void GetAxis(){} // RVA: 0x7FFAC993FD50
        public void GetAxisRaw(){} // RVA: 0x7FFAC993FDA0
        public void GetButton(){} // RVA: 0x7FFAC993FDF0
        public void GetButtonDown(){} // RVA: 0x7FFAC993FE40
        public void GetButtonUp(){} // RVA: 0x7FFAC993FE90
        public void GetKeyInt(){} // RVA: 0x7FFAC993FEE0
        public void GetKeyUpInt(){} // RVA: 0x7FFAC993FF30
        public void GetKeyDownInt(){} // RVA: 0x7FFAC993FF80
        public void GetMouseButton(){} // RVA: 0x7FFAC993FFD0
        public void GetMouseButtonDown(){} // RVA: 0x7FFAC9940020
        public void GetMouseButtonUp(){} // RVA: 0x7FFAC9940070
        public void GetJoystickNames(){} // RVA: 0x7FFAC99400C0
        public void GetTouch(){} // RVA: 0x7FFAC9940110
        public void GetLastPenContactEvent(){} // RVA: 0x7FFAC9940190
        public void ClearLastPenContactEvent(){} // RVA: 0x7FFAC9940200
        public void GetKey(){} // RVA: 0x7FFAC9940250 | overloaded x2
        public void GetKeyUp(){} // RVA: 0x7FFAC99402A0 | overloaded x2
        public void GetKeyDown(){} // RVA: 0x7FFAC99402F0 | overloaded x2
        public void get_anyKey(){} // RVA: 0x7FFAC9940340
        public void get_anyKeyDown(){} // RVA: 0x7FFAC9940390
        public void get_inputString(){} // RVA: 0x7FFAC99403E0
        public void get_mousePosition(){} // RVA: 0x7FFAC9940430
        public void get_mouseScrollDelta(){} // RVA: 0x7FFAC9940490
        public void get_imeCompositionMode(){} // RVA: 0x7FFAC99404F0
        public void set_imeCompositionMode(){} // RVA: 0x7FFAC9940540
        public void get_compositionString(){} // RVA: 0x7FFAC9940590
        public void get_imeIsSelected(){} // RVA: 0x7FFAC99405E0
        public void get_compositionCursorPos(){} // RVA: 0x7FFAC9940630
        public void set_compositionCursorPos(){} // RVA: 0x7FFAC9940690
        public void get_mousePresent(){} // RVA: 0x7FFAC99406E0
        public void get_touchCount(){} // RVA: 0x7FFAC9940730
        public void get_touchSupported(){} // RVA: 0x7FFAC3F9AEF0
        public void get_deviceOrientation(){} // RVA: 0x7FFAC9940780
        public void get_acceleration(){} // RVA: 0x7FFAC99407D0
        public void get_touches(){} // RVA: 0x7FFAC9940830
        public void CheckDisabled(){} // RVA: 0x7FFAC99409C0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetTouch_Injected(){} // RVA: 0x7FFAC9940A10
        public void GetLastPenContactEvent_Injected(){} // RVA: 0x7FFAC9940A70
        public void get_mousePosition_Injected(){} // RVA: 0x7FFAC9940AC0
        public void get_mouseScrollDelta_Injected(){} // RVA: 0x7FFAC9940B10
        public void get_compositionCursorPos_Injected(){} // RVA: 0x7FFAC9940B60
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7FFAC9940BB0
        public void get_acceleration_Injected(){} // RVA: 0x7FFAC9940C00
    }

    public class InspectorNameAttribute : PropertyAttribute
    {
        public string displayName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class InspectorOrderAttribute : PropertyAttribute
    {
        public 0x6B17F040 m_inspectorSort; // 0x10
        public 0x6B17F098 m_sortDirection; // 0x14

        // ── Methods ──
        public void get_m_inspectorSort(){} // RVA: 0x7FFAC2F6E5C0
        public void get_m_sortDirection(){} // RVA: 0x7FFAC33D5A20
    }

    public class IntegratedSubsystem : Object
    {
        public UIntPtr running; // 0x10
        public UnityEngine.ISubsystemDescriptor valid; // 0x18

        // ── Methods ──
        public void SetHandle(){} // RVA: 0x7FFAC99F1190
        public void Start(){} // RVA: 0x7FFAC99F11F0
        public void Stop(){} // RVA: 0x7FFAC99F1240
        public void Destroy(){} // RVA: 0x7FFAC99F1290
        public void get_running(){} // RVA: 0x7FFAC99F14C0
        public void get_valid(){} // RVA: 0x7FFAC99F1530
        public void IsRunning(){} // RVA: 0x7FFAC99F1540
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IntegratedSubsystemDescriptor : Object
    {
        public UIntPtr id; // 0x10

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAC99F15E0
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x7FFAC3EEA090
        public void CreateImpl(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IntegratedSubsystemDescriptor`1 : IntegratedSubsystemDescriptor
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0x7FFAC2C58E90
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class IntegratedSubsystem`1 : IntegratedSubsystem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class Internal_DrawTextureArguments : ValueType
    {
        public UnityEngine.Rect screenRect; // 0x10
        public UnityEngine.Rect sourceRect; // 0x20
        public int leftBorder; // 0x30
        public int rightBorder; // 0x34
        public int topBorder; // 0x38
        public int bottomBorder; // 0x3C
        public UnityEngine.Color leftBorderColor; // 0x40
        public UnityEngine.Color rightBorderColor; // 0x50
        public UnityEngine.Color topBorderColor; // 0x60
        public UnityEngine.Color bottomBorderColor; // 0x70
        public UnityEngine.Color color; // 0x80
        public UnityEngine.Vector4 borderWidths; // 0x90
        public UnityEngine.Vector4 cornerRadiuses; // 0xA0
        public bool smoothCorners; // 0xB0
        public int pass; // 0xB4
        public UnityEngine.Texture texture; // 0xB8
        public UnityEngine.Material mat; // 0xC0
    }

    public class Internal_SubsystemDescriptors : Object
    {
        // ── Methods ──
        public void Internal_AddDescriptor(){} // RVA: 0x7FFAC99F17B0
    }

}