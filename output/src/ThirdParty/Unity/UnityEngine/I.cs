// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 18
// Methods: 97

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
        public void LogFormat(){} // RVA: 0x7FFD4E093F00
        public void LogException(){} // RVA: 0x7FFD4E099B30
    }

    public class ILogger
    {
        public object logHandler;
        public object logEnabled;

        // ── Methods ──
        public void get_logHandler(){} // RVA: 0x7FFD4E078E90
        public void set_logHandler(){} // RVA: 0x7FFD4E090A40
        public void get_logEnabled(){} // RVA: 0x7FFD4E079D00
        public void IsLogTypeAllowed(){} // RVA: 0x7FFD4E07A310
        public void Log(){} // RVA: 0x7FFD4E099B30 | overloaded x4
        public void LogWarning(){} // RVA: 0x7FFD4E099B30
        public void LogError(){} // RVA: 0x7FFD4E099B30
        public void LogFormat(){} // RVA: 0x7FFD4E093960
        public void LogException(){} // RVA: 0x7FFD4E090A40
    }

    public class ISerializationCallbackReceiver
    {
        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7FFD4E090980
        public void OnAfterDeserialize(){} // RVA: 0x7FFD4E090980
    }

    public class ISubsystem
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E090980
        public void Stop(){} // RVA: 0x7FFD4E090980
        public void Destroy(){} // RVA: 0x7FFD4E090980
    }

    public class ISubsystemDescriptor
    {
        public object id;

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFD4E078E90
        public void Create(){} // RVA: 0x7FFD4E078E90
    }

    public class ImageConversion : Object
    {
        // ── Methods ──
        public void EncodeToPNG(){} // RVA: 0x7FFD54D25030
        public void EncodeToJPG(){} // RVA: 0x7FFD54D25080
        public void LoadImage(){} // RVA: 0x7FFD54D25150 | overloaded x2
        public void EncodeNativeArrayToPNG(){} // RVA: 0x7FFD4E2ADC40
        public void UnsafeEncodeNativeArrayToPNG(){} // RVA: 0x7FFD54D251C0
    }

    public class ImageEffectAllowedInSceneView : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ImageEffectOpaque : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ImageEffectUsesCommandBuffer : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
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
        public void GetAxis(){} // RVA: 0x7FFD54D5FD50
        public void GetAxisRaw(){} // RVA: 0x7FFD54D5FDA0
        public void GetButton(){} // RVA: 0x7FFD54D5FDF0
        public void GetButtonDown(){} // RVA: 0x7FFD54D5FE40
        public void GetButtonUp(){} // RVA: 0x7FFD54D5FE90
        public void GetKeyInt(){} // RVA: 0x7FFD54D5FEE0
        public void GetKeyUpInt(){} // RVA: 0x7FFD54D5FF30
        public void GetKeyDownInt(){} // RVA: 0x7FFD54D5FF80
        public void GetMouseButton(){} // RVA: 0x7FFD54D5FFD0
        public void GetMouseButtonDown(){} // RVA: 0x7FFD54D60020
        public void GetMouseButtonUp(){} // RVA: 0x7FFD54D60070
        public void GetJoystickNames(){} // RVA: 0x7FFD54D600C0
        public void GetTouch(){} // RVA: 0x7FFD54D60110
        public void GetLastPenContactEvent(){} // RVA: 0x7FFD54D60190
        public void ClearLastPenContactEvent(){} // RVA: 0x7FFD54D60200
        public void GetKey(){} // RVA: 0x7FFD54D60250 | overloaded x2
        public void GetKeyUp(){} // RVA: 0x7FFD54D602A0 | overloaded x2
        public void GetKeyDown(){} // RVA: 0x7FFD54D602F0 | overloaded x2
        public void get_anyKey(){} // RVA: 0x7FFD54D60340
        public void get_anyKeyDown(){} // RVA: 0x7FFD54D60390
        public void get_inputString(){} // RVA: 0x7FFD54D603E0
        public void get_mousePosition(){} // RVA: 0x7FFD54D60430
        public void get_mouseScrollDelta(){} // RVA: 0x7FFD54D60490
        public void get_imeCompositionMode(){} // RVA: 0x7FFD54D604F0
        public void set_imeCompositionMode(){} // RVA: 0x7FFD54D60540
        public void get_compositionString(){} // RVA: 0x7FFD54D60590
        public void get_imeIsSelected(){} // RVA: 0x7FFD54D605E0
        public void get_compositionCursorPos(){} // RVA: 0x7FFD54D60630
        public void set_compositionCursorPos(){} // RVA: 0x7FFD54D60690
        public void get_mousePresent(){} // RVA: 0x7FFD54D606E0
        public void get_touchCount(){} // RVA: 0x7FFD54D60730
        public void get_touchSupported(){} // RVA: 0x7FFD4F3BAEF0
        public void get_deviceOrientation(){} // RVA: 0x7FFD54D60780
        public void get_acceleration(){} // RVA: 0x7FFD54D607D0
        public void get_touches(){} // RVA: 0x7FFD54D60830
        public void CheckDisabled(){} // RVA: 0x7FFD54D609C0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void GetTouch_Injected(){} // RVA: 0x7FFD54D60A10
        public void GetLastPenContactEvent_Injected(){} // RVA: 0x7FFD54D60A70
        public void get_mousePosition_Injected(){} // RVA: 0x7FFD54D60AC0
        public void get_mouseScrollDelta_Injected(){} // RVA: 0x7FFD54D60B10
        public void get_compositionCursorPos_Injected(){} // RVA: 0x7FFD54D60B60
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7FFD54D60BB0
        public void get_acceleration_Injected(){} // RVA: 0x7FFD54D60C00
    }

    public class InspectorNameAttribute : PropertyAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class IntegratedSubsystem : Object
    {
        public object running;
        public object valid;

        // ── Methods ──
        public void SetHandle(){} // RVA: 0x7FFD54E11190
        public void Start(){} // RVA: 0x7FFD54E111F0
        public void Stop(){} // RVA: 0x7FFD54E11240
        public void Destroy(){} // RVA: 0x7FFD54E11290
        public void get_running(){} // RVA: 0x7FFD54E114C0
        public void get_valid(){} // RVA: 0x7FFD54E11530
        public void IsRunning(){} // RVA: 0x7FFD54E11540
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class IntegratedSubsystemDescriptor : Object
    {
        public object id;

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFD54E115E0
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x7FFD4F30A090
        public void CreateImpl(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class IntegratedSubsystemDescriptor`1 : IntegratedSubsystemDescriptor
    {
        // ── Methods ──
        public void CreateImpl(){} // RVA: 0x7FFD4E078E90
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class IntegratedSubsystem`1 : IntegratedSubsystem
    {
        public n<T1717717360,T1717717376> <keySelector>P;
        public URA.hEraNames<T1717717376> <comparer>P;
        public T1717717328 source;
        public _MARGIN..PhysBoneManager.Chainchain)>.Current<T1717717344,T1717717376> second;
        public ics.ManagedTypes.?<T1717717376> set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Internal_SubsystemDescriptors : Object
    {
        // ── Methods ──
        public void Internal_AddDescriptor(){} // RVA: 0x7FFD54E117B0
    }

}