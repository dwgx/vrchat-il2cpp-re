// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR
// Classes: 30
// Methods: 166

namespace ThirdParty.Unity.UnityEngine.XR
{
    public class Bone
    {
        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFAF51E8C50
        public void get_featureIndex(){} // RVA: 0x7FFAF66FE030
        public void Equals(){} // RVA: 0x7FFAF9FB8C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9FB8C20
    }

    public class CommonUsages
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF9FB6230
    }

    public class Eyes
    {
        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFAF51E8C50
        public void get_featureIndex(){} // RVA: 0x7FFAF66FE030
        public void Equals(){} // RVA: 0x7FFAF9FB8C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9FB8C20
    }

    public class Hand
    {
        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFAF51E8C50
        public void get_featureIndex(){} // RVA: 0x7FFAF66FE030
        public void Equals(){} // RVA: 0x7FFAF9FB8C00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9FB8C20
    }

    public class HapticCapabilities
    {
        // ── Methods ──
        public void get_numChannels(){} // RVA: 0x7FFAF92AD0D0
        public void get_supportsImpulse(){} // RVA: 0x7FFAF9FB5EC0
        public void get_supportsBuffer(){} // RVA: 0x7FFAF9FB5ED0
        public void get_bufferFrequencyHz(){} // RVA: 0x7FFAF66FE030
        public void get_bufferMaxSize(){} // RVA: 0x7FFAF6728200
        public void get_bufferOptimalSize(){} // RVA: 0x7FFAF9B692A0
        public void Equals(){} // RVA: 0x7FFAF9FB5FC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9FB6000
    }

    public class HashCodeHelper
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0x7FFAF9FBAF40 | overloaded x7
    }

    public class InputDevice
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9FB8150
        public void get_deviceId(){} // RVA: 0x7FFAF9FB8160
        public void get_isValid(){} // RVA: 0x7FFAF9FB8180
        public void get_name(){} // RVA: 0x7FFAF9FB81F0
        public void get_manufacturer(){} // RVA: 0x7FFAF9FB8260
        public void get_serialNumber(){} // RVA: 0x7FFAF9FB82D0
        public void get_characteristics(){} // RVA: 0x7FFAF9FB8340
        public void IsValidId(){} // RVA: 0x7FFAF9FB83B0
        public void SendHapticImpulse(){} // RVA: 0x7FFAF9FB83D0
        public void TryGetHapticCapabilities(){} // RVA: 0x7FFAF9FB8500
        public void TryGetFeatureValue(){} // RVA: 0x7FFAF9FB8970 | overloaded x6
        public void CheckValidAndSetDefault(){} // RVA: 0x7FFAF2ABDE40
        public void Equals(){} // RVA: 0x7FFAF9FB8AF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9FB8B20
    }

    public class InputDevices
    {
        // ── Methods ──
        public void GetDeviceAtXRNode(){} // RVA: 0x7FFAF9FB8DA0
        public void GetDevicesAtXRNode(){} // RVA: 0x7FFAF9FB8E20
        public void GetDevices(){} // RVA: 0x7FFAF9FB9260
        public void GetDevicesWithCharacteristics(){} // RVA: 0x7FFAF9FB9330
        public void add_deviceConnected(){} // RVA: 0x7FFAF9FB9880
        public void remove_deviceConnected(){} // RVA: 0x7FFAF9FB99C0
        public void add_deviceDisconnected(){} // RVA: 0x7FFAF9FB9B00
        public void remove_deviceDisconnected(){} // RVA: 0x7FFAF9FB9C40
        public void add_deviceConfigChanged(){} // RVA: 0x7FFAF9FB9D80
        public void remove_deviceConfigChanged(){} // RVA: 0x7FFAF9FB9EC0
        public void InvokeConnectionEvent(){} // RVA: 0x7FFAF9FBA000
        public void GetDevices_Internal(){} // RVA: 0x7FFAF9FBA0D0
        public void SendHapticImpulse(){} // RVA: 0x7FFAF9FBA120
        public void TryGetHapticCapabilities(){} // RVA: 0x7FFAF9FBA1A0
        public void TryGetFeatureValue_bool(){} // RVA: 0x7FFAF9FBA200
        public void TryGetFeatureValue_UInt32(){} // RVA: 0x7FFAF9FBA270
        public void TryGetFeatureValue_float(){} // RVA: 0x7FFAF9FBA2E0
        public void TryGetFeatureValue_Vector2f(){} // RVA: 0x7FFAF9FBA350
        public void TryGetFeatureValue_Vector3f(){} // RVA: 0x7FFAF9FBA3C0
        public void TryGetFeatureValue_Quaternionf(){} // RVA: 0x7FFAF9FBA430
        public void IsDeviceValid(){} // RVA: 0x7FFAF9FBA4A0
        public void GetDeviceName(){} // RVA: 0x7FFAF9FBA4F0
        public void GetDeviceManufacturer(){} // RVA: 0x7FFAF9FBA540
        public void GetDeviceSerialNumber(){} // RVA: 0x7FFAF9FBA590
        public void GetDeviceCharacteristics(){} // RVA: 0x7FFAF9FBA5E0
    }

    public class InputFeatureUsage
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF51E8C50
        public void get_internalType(){} // RVA: 0x7FFAF66FE030
        public void Equals(){} // RVA: 0x7FFAF9FB6180 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9FB61F0
    }

    public class InputFeatureUsage`1
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF2ABCD60
        public void set_name(){} // RVA: 0x7FFAF2AD4B10
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void Equals(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
    }

    public class InputFeatureUsage`1
    {
    }

    public class InputFeatureUsage`1
    {
    }

    public class InputFeatureUsage`1
    {
    }

    public class InputFeatureUsage`1
    {
    }

    public class InputFeatureUsage`1
    {
    }

    public class InputFeatureUsage`1
    {
    }

    public class InputFeatureUsage`1
    {
    }

    public class InputFeatureUsage`1
    {
    }

    public class InputTracking
    {
        // ── Methods ──
        public void InvokeTrackingEvent(){} // RVA: 0x7FFAF9FB55D0
        public void GetLocalPosition(){} // RVA: 0x7FFAF9FB5790
        public void GetLocalRotation(){} // RVA: 0x7FFAF9FB5800
        public void Recenter(){} // RVA: 0x7FFAF9FB5870
        public void GetNodeStates(){} // RVA: 0x7FFAF9FB58C0
        public void GetNodeStates_Internal(){} // RVA: 0x7FFAF9FB5990
        public void GetDeviceIdAtXRNode(){} // RVA: 0x7FFAF9FB59E0
        public void GetDeviceIdsAtXRNode_Internal(){} // RVA: 0x7FFAF9FB5A30
        public void GetLocalPosition_Injected(){} // RVA: 0x7FFAF9FB5A90
        public void GetLocalRotation_Injected(){} // RVA: 0x7FFAF9FB5AF0
    }

    public class MeshGenerationResult
    {
        // ── Methods ──
        public void get_MeshId(){} // RVA: 0x7FFAF320E7E0
        public void get_Mesh(){} // RVA: 0x7FFAF2DA8380
        public void get_MeshCollider(){} // RVA: 0x7FFAF2D907C0
        public void get_Status(){} // RVA: 0x7FFAF3210030
        public void get_Attributes(){} // RVA: 0x7FFAF379F5B0
        public void get_Position(){} // RVA: 0x7FFAF45F14E0
        public void get_Rotation(){} // RVA: 0x7FFAF8C5F7C0
        public void get_Scale(){} // RVA: 0x7FFAF9FBAF90
        public void Equals(){} // RVA: 0x7FFAF9FBB080 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9FBB230
    }

    public class MeshId
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAF9FBAC90
        public void GetHashCode(){} // RVA: 0x7FFAF9BBECB0
        public void Equals(){} // RVA: 0x7FFAF9BBEDB0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF9FBAE00
    }

    public class XRDevice
    {
        // ── Methods ──
        public void GetNativePtr(){} // RVA: 0x7FFAF9FB4E40
        public void DisableAutoXRCameraTracking(){} // RVA: 0x7FFAF9FB4E90
        public void add_deviceLoaded(){} // RVA: 0x7FFAF9FB4EF0
        public void remove_deviceLoaded(){} // RVA: 0x7FFAF9FB5020
        public void InvokeDeviceLoaded(){} // RVA: 0x7FFAF9FB5150
    }

    public class XRDisplaySubsystem
    {
        // ── Methods ──
        public void InvokeDisplayFocusChanged(){} // RVA: 0x7FFAF9B5C7D0
        public void get_scaleOfAllRenderTargets(){} // RVA: 0x7FFAF9FBA630
        public void TryGetDisplayRefreshRate(){} // RVA: 0x7FFAF9FBA680
        public void .ctor(){} // RVA: 0x7FFAF9FBA6E0
    }

    public class XRDisplaySubsystemDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9FBA710
    }

    public class XRInputSubsystem
    {
        // ── Methods ──
        public void TryRecenter(){} // RVA: 0x7FFAF9FBA740
        public void TrySetTrackingOriginMode(){} // RVA: 0x7FFAF9FBA790
        public void GetTrackingOriginMode(){} // RVA: 0x7FFAF9FBA7F0
        public void GetSupportedTrackingOriginModes(){} // RVA: 0x7FFAF9FBA840
        public void add_trackingOriginUpdated(){} // RVA: 0x7FFAF9FBA890
        public void remove_trackingOriginUpdated(){} // RVA: 0x7FFAF9FBA990
        public void InvokeTrackingOriginUpdatedEvent(){} // RVA: 0x7FFAF9FBAA90
        public void InvokeBoundaryChangedEvent(){} // RVA: 0x7FFAF9FBAB60
        public void .ctor(){} // RVA: 0x7FFAF9FBAC30
    }

    public class XRInputSubsystemDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9FBAC60
    }

    public class XRMeshSubsystem
    {
        // ── Methods ──
        public void InvokeMeshReadyDelegate(){} // RVA: 0x7FFAF9FBB4B0
        public void .ctor(){} // RVA: 0x7FFAF9FBB520
    }

    public class XRMeshSubsystemDescriptor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9FBB5F0
    }

    public class XRNodeState
    {
        // ── Methods ──
        public void set_uniqueID(){} // RVA: 0x7FFAF2F734E0
        public void get_nodeType(){} // RVA: 0x7FFAF92AD0D0
        public void set_nodeType(){} // RVA: 0x7FFAF32E3580
        public void set_tracked(){} // RVA: 0x7FFAF9FB5B50
        public void TryGetPosition(){} // RVA: 0x7FFAF9FB5B60
        public void TryGetRotation(){} // RVA: 0x7FFAF9FB5BD0
        public void TryGetVelocity(){} // RVA: 0x7FFAF9FB5C30
        public void TryGetAngularVelocity(){} // RVA: 0x7FFAF9FB5CA0
        public void TryGetAcceleration(){} // RVA: 0x7FFAF9FB5D10
        public void TryGetAngularAcceleration(){} // RVA: 0x7FFAF9FB5D80
        public void TryGet(){} // RVA: 0x7FFAF9FB5E60 | overloaded x2
    }

    public class XRSettings
    {
        public object dule;
        public object (;
        public object <Module>;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAF99FD660
        public void set_enabled(){} // RVA: 0x7FFAF9FB49B0
        public void get_showDeviceView(){} // RVA: 0x7FFAF9FB4A00
        public void set_showDeviceView(){} // RVA: 0x7FFAF9FB4A50
        public void get_eyeTextureResolutionScale(){} // RVA: 0x7FFAF8FAFFC0
        public void set_eyeTextureResolutionScale(){} // RVA: 0x7FFAF8FB0010
        public void get_eyeTextureWidth(){} // RVA: 0x7FFAF9FB4AA0
        public void get_eyeTextureHeight(){} // RVA: 0x7FFAF9FB4AF0
        public void get_eyeTextureDesc(){} // RVA: 0x7FFAF9FB4B40
        public void get_renderViewportScale(){} // RVA: 0x7FFAF9FB4BB0
        public void get_renderViewportScaleInternal(){} // RVA: 0x7FFAF9FB4BB0
        public void get_loadedDeviceName(){} // RVA: 0x7FFAF9FB4C00
        public void LoadDeviceByName(){} // RVA: 0x7FFAF9FB4D00 | overloaded x2
        public void get_supportedDevices(){} // RVA: 0x7FFAF9FB4D50
        public void get_stereoRenderingMode(){} // RVA: 0x7FFAF9FB4DA0
        public void get_eyeTextureDesc_Injected(){} // RVA: 0x7FFAF9FB4DF0
    }

}