// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 2
// Methods: 46

namespace ThirdParty.Valve.Valve.VR
{
    public class OpenVR
    {
        public uint k_nDriverNone;
        public uint k_unMaxDriverDebugResponseSize;
        public uint k_unTrackedDeviceIndex_Hmd;
        public uint k_unMaxTrackedDeviceCount;
        public uint k_unTrackedDeviceIndexOther;
        public uint k_unTrackedDeviceIndexInvalid;
        public ulong k_ulInvalidPropertyContainer;
        public uint k_unInvalidPropertyTag;
        public ulong k_ulInvalidDriverHandle;
        public uint k_unFloatPropertyTag;
        public uint k_unInt32PropertyTag;
        public uint k_unUint64PropertyTag;
        public uint k_unBoolPropertyTag;
        public uint k_unStringPropertyTag;
        public uint k_unErrorPropertyTag;
        public uint k_unDoublePropertyTag;
        public uint k_unHmdMatrix34PropertyTag;
        public uint k_unHmdMatrix44PropertyTag;
        public uint k_unHmdVector3PropertyTag;
        public uint k_unHmdVector4PropertyTag;

        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7067170
        public void InitInternal2(){} // RVA: 0x70671B0
        public void ShutdownInternal(){} // RVA: 0x7067230
        public void IsHmdPresent(){} // RVA: 0x7067260
        public void IsRuntimeInstalled(){} // RVA: 0x7067290
        public void RuntimePath(){} // RVA: 0x706B670
        public void GetStringForHmdError(){} // RVA: 0x706B7B0
        public void GetGenericInterface(){} // RVA: 0x7067470
        public void IsInterfaceVersionValid(){} // RVA: 0x70674D0
        public void GetInitToken(){} // RVA: 0x7067530
        public void get_VRToken(){} // RVA: 0x706B840
        public void set_VRToken(){} // RVA: 0x706B880
        public void get_OpenVRInternal_ModuleContext(){} // RVA: 0x706B8C0
        public void get_System(){} // RVA: 0x706B9C0
        public void get_Chaperone(){} // RVA: 0x706B9F0
        public void get_ChaperoneSetup(){} // RVA: 0x706BA20
        public void get_Compositor(){} // RVA: 0x706BA50
        public void get_HeadsetView(){} // RVA: 0x706BA80
        public void get_Overlay(){} // RVA: 0x706BAB0
        public void get_OverlayView(){} // RVA: 0x706BAE0
        public void get_RenderModels(){} // RVA: 0x706BB10
        public void get_ExtendedDisplay(){} // RVA: 0x706BB40
        public void get_Settings(){} // RVA: 0x706BB70
        public void get_Applications(){} // RVA: 0x706BBA0
        public void get_Screenshots(){} // RVA: 0x706BBD0
        public void get_TrackedCamera(){} // RVA: 0x706BC00
        public void get_Input(){} // RVA: 0x706BC30
        public void get_IOBuffer(){} // RVA: 0x706BC60
        public void get_SpatialAnchors(){} // RVA: 0x706BC90
        public void get_Notifications(){} // RVA: 0x706BCC0
        public void get_Debug(){} // RVA: 0x706BCF0
        public void Init(){} // RVA: 0x706BD20
        public void Shutdown(){} // RVA: 0x7067230
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OpenVRInterop
    {
        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7067170
        public void InitInternal2(){} // RVA: 0x70671B0
        public void ShutdownInternal(){} // RVA: 0x7067230
        public void IsHmdPresent(){} // RVA: 0x7067260
        public void IsRuntimeInstalled(){} // RVA: 0x7067290
        public void RuntimePath(){} // RVA: 0x70672C0
        public void GetRuntimePath(){} // RVA: 0x7067370
        public void GetStringForHmdError(){} // RVA: 0x7067440
        public void GetGenericInterface(){} // RVA: 0x7067470
        public void IsInterfaceVersionValid(){} // RVA: 0x70674D0
        public void GetInitToken(){} // RVA: 0x7067530
        public void .ctor(){} // RVA: 0x2DD310
    }

}