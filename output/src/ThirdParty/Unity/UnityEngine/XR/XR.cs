// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR
// Classes: 22
// Methods: 166

namespace ThirdParty.Unity.UnityEngine.XR
{
    public class Bone
    {
        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x2738C50
        public void get_featureIndex(){} // RVA: 0x3C4E030
        public void Equals(){} // RVA: 0x7508C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7508C20
    }

    public class CommonUsages
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7506230
    }

    public class Eyes
    {
        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x2738C50
        public void get_featureIndex(){} // RVA: 0x3C4E030
        public void Equals(){} // RVA: 0x7508C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7508C20
    }

    public class Hand
    {
        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x2738C50
        public void get_featureIndex(){} // RVA: 0x3C4E030
        public void Equals(){} // RVA: 0x7508C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7508C20
    }

    public class HapticCapabilities
    {
        // ── Methods ──
        public void get_numChannels(){} // RVA: 0x67FD0D0
        public void get_supportsImpulse(){} // RVA: 0x7505EC0
        public void get_supportsBuffer(){} // RVA: 0x7505ED0
        public void get_bufferFrequencyHz(){} // RVA: 0x3C4E030
        public void get_bufferMaxSize(){} // RVA: 0x3C78200
        public void get_bufferOptimalSize(){} // RVA: 0x70B92A0
        public void Equals(){} // RVA: 0x7505FC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7506000
    }

    public class HashCodeHelper
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0x750AF40 | overloaded x7
    }

    public class InputDevice
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7508150
        public void get_deviceId(){} // RVA: 0x7508160
        public void get_isValid(){} // RVA: 0x7508180
        public void get_name(){} // RVA: 0x75081F0
        public void get_manufacturer(){} // RVA: 0x7508260
        public void get_serialNumber(){} // RVA: 0x75082D0
        public void get_characteristics(){} // RVA: 0x7508340
        public void IsValidId(){} // RVA: 0x75083B0
        public void SendHapticImpulse(){} // RVA: 0x75083D0
        public void TryGetHapticCapabilities(){} // RVA: 0x7508500
        public void TryGetFeatureValue(){} // RVA: 0x7508970 | overloaded x6
        public void CheckValidAndSetDefault(){} // RVA: 0xDE40
        public void Equals(){} // RVA: 0x7508AF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7508B20
    }

    public class InputDevices
    {
        // ── Methods ──
        public void GetDeviceAtXRNode(){} // RVA: 0x7508DA0
        public void GetDevicesAtXRNode(){} // RVA: 0x7508E20
        public void GetDevices(){} // RVA: 0x7509260
        public void GetDevicesWithCharacteristics(){} // RVA: 0x7509330
        public void add_deviceConnected(){} // RVA: 0x7509880
        public void remove_deviceConnected(){} // RVA: 0x75099C0
        public void add_deviceDisconnected(){} // RVA: 0x7509B00
        public void remove_deviceDisconnected(){} // RVA: 0x7509C40
        public void add_deviceConfigChanged(){} // RVA: 0x7509D80
        public void remove_deviceConfigChanged(){} // RVA: 0x7509EC0
        public void InvokeConnectionEvent(){} // RVA: 0x750A000
        public void GetDevices_Internal(){} // RVA: 0x750A0D0
        public void SendHapticImpulse(){} // RVA: 0x750A120
        public void TryGetHapticCapabilities(){} // RVA: 0x750A1A0
        public void TryGetFeatureValue_bool(){} // RVA: 0x750A200
        public void TryGetFeatureValue_UInt32(){} // RVA: 0x750A270
        public void TryGetFeatureValue_float(){} // RVA: 0x750A2E0
        public void TryGetFeatureValue_Vector2f(){} // RVA: 0x750A350
        public void TryGetFeatureValue_Vector3f(){} // RVA: 0x750A3C0
        public void TryGetFeatureValue_Quaternionf(){} // RVA: 0x750A430
        public void IsDeviceValid(){} // RVA: 0x750A4A0
        public void GetDeviceName(){} // RVA: 0x750A4F0
        public void GetDeviceManufacturer(){} // RVA: 0x750A540
        public void GetDeviceSerialNumber(){} // RVA: 0x750A590
        public void GetDeviceCharacteristics(){} // RVA: 0x750A5E0
    }

    public class InputFeatureUsage
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x2738C50
        public void get_internalType(){} // RVA: 0x3C4E030
        public void Equals(){} // RVA: 0x7506180 | overloaded x2
        public void GetHashCode(){} // RVA: 0x75061F0
    }

    public class InputFeatureUsage`1
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0xCD60
        public void set_name(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24B10
        public void Equals(){} // RVA: 0x283FA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0xD840
    }

    public class InputTracking
    {
        // ── Methods ──
        public void InvokeTrackingEvent(){} // RVA: 0x75055D0
        public void GetLocalPosition(){} // RVA: 0x7505790
        public void GetLocalRotation(){} // RVA: 0x7505800
        public void Recenter(){} // RVA: 0x7505870
        public void GetNodeStates(){} // RVA: 0x75058C0
        public void GetNodeStates_Internal(){} // RVA: 0x7505990
        public void GetDeviceIdAtXRNode(){} // RVA: 0x75059E0
        public void GetDeviceIdsAtXRNode_Internal(){} // RVA: 0x7505A30
        public void GetLocalPosition_Injected(){} // RVA: 0x7505A90
        public void GetLocalRotation_Injected(){} // RVA: 0x7505AF0
    }

    public class MeshGenerationResult
    {
        // ── Methods ──
        public void get_MeshId(){} // RVA: 0x75E7E0
        public void get_Mesh(){} // RVA: 0x2F8380
        public void get_MeshCollider(){} // RVA: 0x2E07C0
        public void get_Status(){} // RVA: 0x760030
        public void get_Attributes(){} // RVA: 0xCEF5B0
        public void get_Position(){} // RVA: 0x1B414E0
        public void get_Rotation(){} // RVA: 0x61AF7C0
        public void get_Scale(){} // RVA: 0x750AF90
        public void Equals(){} // RVA: 0x750B080 | overloaded x2
        public void GetHashCode(){} // RVA: 0x750B230
    }

    public class MeshId
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x750AC90
        public void GetHashCode(){} // RVA: 0x710ECB0
        public void Equals(){} // RVA: 0x710EDB0 | overloaded x2
        public void .cctor(){} // RVA: 0x750AE00
    }

    public class XRDevice
    {
        // ── Methods ──
        public void GetNativePtr(){} // RVA: 0x7504E40
        public void DisableAutoXRCameraTracking(){} // RVA: 0x7504E90
        public void add_deviceLoaded(){} // RVA: 0x7504EF0
        public void remove_deviceLoaded(){} // RVA: 0x7505020
        public void InvokeDeviceLoaded(){} // RVA: 0x7505150
    }

    public class XRDisplaySubsystem
    {
        // ── Methods ──
        public void InvokeDisplayFocusChanged(){} // RVA: 0x70AC7D0
        public void get_scaleOfAllRenderTargets(){} // RVA: 0x750A630
        public void TryGetDisplayRefreshRate(){} // RVA: 0x750A680
        public void .ctor(){} // RVA: 0x750A6E0
    }

    public class XRDisplaySubsystemDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x750A710
    }

    public class XRInputSubsystem
    {
        // ── Methods ──
        public void TryRecenter(){} // RVA: 0x750A740
        public void TrySetTrackingOriginMode(){} // RVA: 0x750A790
        public void GetTrackingOriginMode(){} // RVA: 0x750A7F0
        public void GetSupportedTrackingOriginModes(){} // RVA: 0x750A840
        public void add_trackingOriginUpdated(){} // RVA: 0x750A890
        public void remove_trackingOriginUpdated(){} // RVA: 0x750A990
        public void InvokeTrackingOriginUpdatedEvent(){} // RVA: 0x750AA90
        public void InvokeBoundaryChangedEvent(){} // RVA: 0x750AB60
        public void .ctor(){} // RVA: 0x750AC30
    }

    public class XRInputSubsystemDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x750AC60
    }

    public class XRMeshSubsystem
    {
        // ── Methods ──
        public void InvokeMeshReadyDelegate(){} // RVA: 0x750B4B0
        public void .ctor(){} // RVA: 0x750B520
    }

    public class XRMeshSubsystemDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x750B5F0
    }

    public class XRNodeState
    {
        // ── Methods ──
        public void set_uniqueID(){} // RVA: 0x4C34E0
        public void get_nodeType(){} // RVA: 0x67FD0D0
        public void set_nodeType(){} // RVA: 0x833580
        public void set_tracked(){} // RVA: 0x7505B50
        public void TryGetPosition(){} // RVA: 0x7505B60
        public void TryGetRotation(){} // RVA: 0x7505BD0
        public void TryGetVelocity(){} // RVA: 0x7505C30
        public void TryGetAngularVelocity(){} // RVA: 0x7505CA0
        public void TryGetAcceleration(){} // RVA: 0x7505D10
        public void TryGetAngularAcceleration(){} // RVA: 0x7505D80
        public void TryGet(){} // RVA: 0x7505E60 | overloaded x2
    }

    public class XRSettings
    {
        public object dule;
        public object (;
        public object <Module>;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x6F4D660
        public void set_enabled(){} // RVA: 0x75049B0
        public void get_showDeviceView(){} // RVA: 0x7504A00
        public void set_showDeviceView(){} // RVA: 0x7504A50
        public void get_eyeTextureResolutionScale(){} // RVA: 0x64FFFC0
        public void set_eyeTextureResolutionScale(){} // RVA: 0x6500010
        public void get_eyeTextureWidth(){} // RVA: 0x7504AA0
        public void get_eyeTextureHeight(){} // RVA: 0x7504AF0
        public void get_eyeTextureDesc(){} // RVA: 0x7504B40
        public void get_renderViewportScale(){} // RVA: 0x7504BB0
        public void get_renderViewportScaleInternal(){} // RVA: 0x7504BB0
        public void get_loadedDeviceName(){} // RVA: 0x7504C00
        public void LoadDeviceByName(){} // RVA: 0x7504D00 | overloaded x2
        public void get_supportedDevices(){} // RVA: 0x7504D50
        public void get_stereoRenderingMode(){} // RVA: 0x7504DA0
        public void get_eyeTextureDesc_Injected(){} // RVA: 0x7504DF0
    }

}