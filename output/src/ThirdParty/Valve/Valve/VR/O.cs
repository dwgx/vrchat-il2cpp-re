// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 2
// Methods: 46

namespace ThirdParty.Valve.Valve.VR
{
    public class OpenVR : Object
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
        public void InitInternal(){} // RVA: 0x7FFE87BA8040
        public void InitInternal2(){} // RVA: 0x7FFE87BA8080
        public void ShutdownInternal(){} // RVA: 0x7FFE87BA8100
        public void IsHmdPresent(){} // RVA: 0x7FFE87BA8130
        public void IsRuntimeInstalled(){} // RVA: 0x7FFE87BA8160
        public void RuntimePath(){} // RVA: 0x7FFE87BAC540
        public void GetStringForHmdError(){} // RVA: 0x7FFE87BAC680
        public void GetGenericInterface(){} // RVA: 0x7FFE87BA8340
        public void IsInterfaceVersionValid(){} // RVA: 0x7FFE87BA83A0
        public void GetInitToken(){} // RVA: 0x7FFE87BA8400
        public void get_VRToken(){} // RVA: 0x7FFE87BAC710
        public void set_VRToken(){} // RVA: 0x7FFE87BAC750
        public void get_OpenVRInternal_ModuleContext(){} // RVA: 0x7FFE87BAC790
        public void get_System(){} // RVA: 0x7FFE87BAC890
        public void get_Chaperone(){} // RVA: 0x7FFE87BAC8C0
        public void get_ChaperoneSetup(){} // RVA: 0x7FFE87BAC8F0
        public void get_Compositor(){} // RVA: 0x7FFE87BAC920
        public void get_HeadsetView(){} // RVA: 0x7FFE87BAC950
        public void get_Overlay(){} // RVA: 0x7FFE87BAC980
        public void get_OverlayView(){} // RVA: 0x7FFE87BAC9B0
        public void get_RenderModels(){} // RVA: 0x7FFE87BAC9E0
        public void get_ExtendedDisplay(){} // RVA: 0x7FFE87BACA10
        public void get_Settings(){} // RVA: 0x7FFE87BACA40
        public void get_Applications(){} // RVA: 0x7FFE87BACA70
        public void get_Screenshots(){} // RVA: 0x7FFE87BACAA0
        public void get_TrackedCamera(){} // RVA: 0x7FFE87BACAD0
        public void get_Input(){} // RVA: 0x7FFE87BACB00
        public void get_IOBuffer(){} // RVA: 0x7FFE87BACB30
        public void get_SpatialAnchors(){} // RVA: 0x7FFE87BACB60
        public void get_Notifications(){} // RVA: 0x7FFE87BACB90
        public void get_Debug(){} // RVA: 0x7FFE87BACBC0
        public void Init(){} // RVA: 0x7FFE87BACBF0
        public void Shutdown(){} // RVA: 0x7FFE87BA8100
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OpenVRInterop : Object
    {
        // ── Methods ──
        public void InitInternal(){} // RVA: 0x7FFE87BA8040
        public void InitInternal2(){} // RVA: 0x7FFE87BA8080
        public void ShutdownInternal(){} // RVA: 0x7FFE87BA8100
        public void IsHmdPresent(){} // RVA: 0x7FFE87BA8130
        public void IsRuntimeInstalled(){} // RVA: 0x7FFE87BA8160
        public void RuntimePath(){} // RVA: 0x7FFE87BA8190
        public void GetRuntimePath(){} // RVA: 0x7FFE87BA8240
        public void GetStringForHmdError(){} // RVA: 0x7FFE87BA8310
        public void GetGenericInterface(){} // RVA: 0x7FFE87BA8340
        public void IsInterfaceVersionValid(){} // RVA: 0x7FFE87BA83A0
        public void GetInitToken(){} // RVA: 0x7FFE87BA8400
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}