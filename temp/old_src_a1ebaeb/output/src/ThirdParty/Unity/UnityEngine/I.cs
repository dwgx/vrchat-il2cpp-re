// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 24
// Methods: 109

namespace ThirdParty.Unity.UnityEngine
{
    public class ICanvasRaycastFilter
    {
        // ── Original Methods ──
        public void IsRaycastLocationValid(){}
    }

    public class IExposedPropertyTable
    {
        // ── Binary Analysis Named ──
        public void GetReferenceValue(){}
    }

    public class ILogHandler
    {
        // ── Original Methods ──
        public void LogFormat(){} // RVA: 0x7ffaa8664240
        public void LogException(){} // RVA: 0x7ffaa8669e70
    }

    public class ILogger
    {
        // ── Original Methods ──
        public void get_logHandler(){} // RVA: 0x7ffaa86491d0
        public void set_logHandler(){} // RVA: 0x7ffaa8660d80
        public void get_logEnabled(){} // RVA: 0x7ffaa864a040
        public void IsLogTypeAllowed(){} // RVA: 0x7ffaa864a650
        public void Log(){} // RVA: 0x7ffaa8669e70
        public void Log(){} // RVA: 0x7ffaa8669e70
        public void Log(){} // RVA: 0x7ffaa8669e70
        public void Log(){} // RVA: 0x7ffaa8669e70
        public void LogWarning(){} // RVA: 0x7ffaa8669e70
        public void LogError(){} // RVA: 0x7ffaa8669e70
        public void LogFormat(){} // RVA: 0x7ffaa8663ca0
        public void LogException(){} // RVA: 0x7ffaa8660d80
    }

    public class ISerializationCallbackReceiver
    {
        // ── Original Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7ffaa8660cc0
        public void OnAfterDeserialize(){} // RVA: 0x7ffaa8660cc0
    }

    public class ISubsystem
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8660cc0
        public void Stop(){} // RVA: 0x7ffaa8660cc0
        public void Destroy(){} // RVA: 0x7ffaa8660cc0
    }

    public class ISubsystemDescriptor
    {
        // ── Original Methods ──
        public void get_id(){} // RVA: 0x7ffaa86491d0
        public void Create(){} // RVA: 0x7ffaa86491d0
    }

    public class ImageConversion : Object
    {
        // ── Original Methods ──
        public void EncodeToPNG(){} // RVA: 0x7ffaaf326f90
        public void EncodeToJPG(){} // RVA: 0x7ffaaf326fe0
        public void LoadImage(){} // RVA: 0x7ffaaf3270b0
        public void LoadImage(){} // RVA: 0x7ffaaf3270b0
        public void EncodeNativeArrayToPNG(){} // RVA: 0x7ffaa887e5c0
        public void UnsafeEncodeNativeArrayToPNG(){} // RVA: 0x7ffaaf327120
    }

    public class ImageEffectAllowedInSceneView : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ImageEffectOpaque : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ImageEffectUsesCommandBuffer : Attribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Input : Object
    {
        // ── Original Methods ──
        public void ClearLastPenContactEvent(){} // RVA: 0x7ffaaf362160
        public void get_anyKey(){} // RVA: 0x7ffaaf3622a0
        public void get_anyKeyDown(){} // RVA: 0x7ffaaf3622f0
        public void get_inputString(){} // RVA: 0x7ffaaf362340
        public void get_mousePosition(){} // RVA: 0x7ffaaf362390
        public void get_mouseScrollDelta(){} // RVA: 0x7ffaaf3623f0
        public void get_imeCompositionMode(){} // RVA: 0x7ffaaf362450
        public void set_imeCompositionMode(){} // RVA: 0x7ffaaf3624a0
        public void get_compositionString(){} // RVA: 0x7ffaaf3624f0
        public void get_imeIsSelected(){} // RVA: 0x7ffaaf362540
        public void get_compositionCursorPos(){} // RVA: 0x7ffaaf362590
        public void set_compositionCursorPos(){} // RVA: 0x7ffaaf3625f0
        public void get_mousePresent(){} // RVA: 0x7ffaaf362640
        public void get_touchCount(){} // RVA: 0x7ffaaf362690
        public void get_touchSupported(){} // RVA: 0x7ffaa99c5840
        public void get_deviceOrientation(){} // RVA: 0x7ffaaf3626e0
        public void get_acceleration(){} // RVA: 0x7ffaaf362730
        public void get_touches(){} // RVA: 0x7ffaaf362790
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_mousePosition_Injected(){} // RVA: 0x7ffaaf362a20
        public void get_mouseScrollDelta_Injected(){} // RVA: 0x7ffaaf362a70
        public void get_compositionCursorPos_Injected(){} // RVA: 0x7ffaaf362ac0
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7ffaaf362b10
        public void get_acceleration_Injected(){} // RVA: 0x7ffaaf362b60
        // ── Binary Analysis Named ──
        public void GetAxis(){} // RVA: 0x7ffaaf361cb0
        public void GetAxisRaw(){} // RVA: 0x7ffaaf361d00
        public void GetButton(){} // RVA: 0x7ffaaf361d50
        public void GetButtonDown(){} // RVA: 0x7ffaaf361da0
        public void GetButtonUp(){} // RVA: 0x7ffaaf361df0
        public void GetKeyInt(){} // RVA: 0x7ffaaf361e40
        public void GetKeyUpInt(){} // RVA: 0x7ffaaf361e90
        public void GetKeyDownInt(){} // RVA: 0x7ffaaf361ee0
        public void GetMouseButton(){} // RVA: 0x7ffaaf361f30
        public void GetMouseButtonDown(){} // RVA: 0x7ffaaf361f80
        public void GetMouseButtonUp(){} // RVA: 0x7ffaaf361fd0
        public void GetJoystickNames(){} // RVA: 0x7ffaaf362020
        public void GetTouch(){} // RVA: 0x7ffaaf362070
        public void GetLastPenContactEvent(){} // RVA: 0x7ffaaf3620f0
        public void GetKey(){} // RVA: 0x7ffaaf3621b0
        public void GetKey(){} // RVA: 0x7ffaaf3621b0
        public void GetKeyUp(){} // RVA: 0x7ffaaf362200
        public void GetKeyUp(){} // RVA: 0x7ffaaf362200
        public void GetKeyDown(){} // RVA: 0x7ffaaf362250
        public void GetKeyDown(){} // RVA: 0x7ffaaf362250
        public void CheckDisabled(){} // RVA: 0x7ffaaf362920
        public void GetTouch_Injected(){} // RVA: 0x7ffaaf362970
        public void GetLastPenContactEvent_Injected(){} // RVA: 0x7ffaaf3629d0
    }

    public class InspectorNameAttribute : PropertyAttribute
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class IntegratedSubsystem : Object
    {
        public object displayFocusChanged; // 0x32D518E0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaaf413150
        public void Stop(){} // RVA: 0x7ffaaf4131a0
        public void Destroy(){} // RVA: 0x7ffaaf4131f0
        public void get_running(){} // RVA: 0x7ffaaf413420
        public void get_valid(){} // RVA: 0x7ffaaf413490
        public void IsRunning(){} // RVA: 0x7ffaaf4134a0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetHandle(){} // RVA: 0x7ffaaf4130f0
    }

    public class IntegratedSubsystemDescriptor : Object
    {
        // ── Original Methods ──
        public void get_id(){} // RVA: 0x7ffaaf413540
        public void UnityEngine.ISubsystemDescriptor.Create(){} // RVA: 0x7ffaae8d4a00
        public void CreateImpl(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class IntegratedSubsystemDescriptor`1 : IntegratedSubsystemDescriptor
    {
        // ── Original Methods ──
        public void CreateImpl(){} // RVA: 0x7ffaa86491d0
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class IntegratedSubsystemDescriptor`1 : IntegratedSubsystemDescriptor
    {
        // ── Original Methods ──
        public void CreateImpl(){} // RVA: 0x7ffaab8f63b0
        public void Create(){} // RVA: 0x7ffaab8f6510
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class IntegratedSubsystemDescriptor`1 : IntegratedSubsystemDescriptor
    {
        // ── Original Methods ──
        public void CreateImpl(){} // RVA: 0x7ffaab8f63b0
        public void Create(){} // RVA: 0x7ffaab8f6510
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class IntegratedSubsystemDescriptor`1 : IntegratedSubsystemDescriptor
    {
        // ── Original Methods ──
        public void CreateImpl(){} // RVA: 0x7ffaab8f63b0
        public void Create(){} // RVA: 0x7ffaab8f6510
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class IntegratedSubsystem`1 : IntegratedSubsystem
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class IntegratedSubsystem`1 : IntegratedSubsystem
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class IntegratedSubsystem`1 : IntegratedSubsystem
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class IntegratedSubsystem`1 : IntegratedSubsystem
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class Internal_SubsystemDescriptors : Object
    {
        // ── Original Methods ──
        public void Internal_AddDescriptor(){} // RVA: 0x7ffaaf413710
    }

}