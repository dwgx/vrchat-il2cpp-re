// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR
// Classes: 22
// Methods: 166

namespace ThirdParty.Unity.UnityEngine.XR
{
    public class Bone : ValueType
    {
        public ulong deviceId; // 0x10
        public uint featureIndex; // 0x18

        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFAC51D9A30
        public void get_featureIndex(){} // RVA: 0x7FFAC653D9A0
        public void Equals(){} // RVA: 0x7FFAC9CA0580 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9CA05A0
    }

    public class CommonUsages : Object
    {
        public UnityEngine.XR.InputFeatureUsage`1<bool> isTracked;
        public UnityEngine.XR.InputFeatureUsage`1<bool> primaryButton; // 0x8
        public UnityEngine.XR.InputFeatureUsage`1<bool> primaryTouch; // 0x10
        public UnityEngine.XR.InputFeatureUsage`1<bool> secondaryButton; // 0x18
        public UnityEngine.XR.InputFeatureUsage`1<bool> secondaryTouch; // 0x20
        public UnityEngine.XR.InputFeatureUsage`1<bool> gripButton; // 0x28
        public UnityEngine.XR.InputFeatureUsage`1<bool> triggerButton; // 0x30
        public UnityEngine.XR.InputFeatureUsage`1<bool> menuButton; // 0x38
        public UnityEngine.XR.InputFeatureUsage`1<bool> primary2DAxisClick; // 0x40
        public UnityEngine.XR.InputFeatureUsage`1<bool> primary2DAxisTouch; // 0x48
        public UnityEngine.XR.InputFeatureUsage`1<bool> secondary2DAxisClick; // 0x50
        public UnityEngine.XR.InputFeatureUsage`1<bool> secondary2DAxisTouch; // 0x58
        public UnityEngine.XR.InputFeatureUsage`1<bool> userPresence; // 0x60
        public UnityEngine.XR.InputFeatureUsage`1<0x6B2C9040> trackingState; // 0x68
        public UnityEngine.XR.InputFeatureUsage`1<float> batteryLevel; // 0x70
        public UnityEngine.XR.InputFeatureUsage`1<float> trigger; // 0x78
        public UnityEngine.XR.InputFeatureUsage`1<float> grip; // 0x80
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector2> primary2DAxis; // 0x88
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector2> secondary2DAxis; // 0x90
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> devicePosition; // 0x98
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> leftEyePosition; // 0xA0
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> rightEyePosition; // 0xA8
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> centerEyePosition; // 0xB0
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> colorCameraPosition; // 0xB8
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> deviceVelocity; // 0xC0
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> deviceAngularVelocity; // 0xC8
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> leftEyeVelocity; // 0xD0
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> leftEyeAngularVelocity; // 0xD8
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> rightEyeVelocity; // 0xE0
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> rightEyeAngularVelocity; // 0xE8
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> centerEyeVelocity; // 0xF0
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> centerEyeAngularVelocity; // 0xF8
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> colorCameraVelocity; // 0x100
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> colorCameraAngularVelocity; // 0x108
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> deviceAcceleration; // 0x110
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> deviceAngularAcceleration; // 0x118
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> leftEyeAcceleration; // 0x120
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> leftEyeAngularAcceleration; // 0x128
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> rightEyeAcceleration; // 0x130
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> rightEyeAngularAcceleration; // 0x138
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> centerEyeAcceleration; // 0x140
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> centerEyeAngularAcceleration; // 0x148
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> colorCameraAcceleration; // 0x150
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector3> colorCameraAngularAcceleration; // 0x158
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Quaternion> deviceRotation; // 0x160
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Quaternion> leftEyeRotation; // 0x168
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Quaternion> rightEyeRotation; // 0x170
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Quaternion> centerEyeRotation; // 0x178
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Quaternion> colorCameraRotation; // 0x180
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.XR.Hand> handData; // 0x188
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.XR.Eyes> eyesData; // 0x190
        public UnityEngine.XR.InputFeatureUsage`1<UnityEngine.Vector2> dPad; // 0x198
        public UnityEngine.XR.InputFeatureUsage`1<float> indexFinger; // 0x1A0
        public UnityEngine.XR.InputFeatureUsage`1<float> middleFinger; // 0x1A8
        public UnityEngine.XR.InputFeatureUsage`1<float> ringFinger; // 0x1B0
        public UnityEngine.XR.InputFeatureUsage`1<float> pinkyFinger; // 0x1B8
        public UnityEngine.XR.InputFeatureUsage`1<bool> thumbrest; // 0x1C0
        public UnityEngine.XR.InputFeatureUsage`1<float> indexTouch; // 0x1C8
        public UnityEngine.XR.InputFeatureUsage`1<float> thumbTouch; // 0x1D0

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9C9DBB0
    }

    public class Eyes : ValueType
    {
        public ulong deviceId; // 0x10
        public uint featureIndex; // 0x18

        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFAC51D9A30
        public void get_featureIndex(){} // RVA: 0x7FFAC653D9A0
        public void Equals(){} // RVA: 0x7FFAC9CA0580 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9CA05A0
    }

    public class Hand : ValueType
    {
        public ulong deviceId; // 0x10
        public uint featureIndex; // 0x18

        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFAC51D9A30
        public void get_featureIndex(){} // RVA: 0x7FFAC653D9A0
        public void Equals(){} // RVA: 0x7FFAC9CA0580 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9CA05A0
    }

    public class HapticCapabilities : ValueType
    {
        public uint numChannels; // 0x10
        public bool supportsImpulse; // 0x14
        public bool supportsBuffer; // 0x15
        public uint bufferFrequencyHz; // 0x18
        public uint bufferMaxSize; // 0x1C
        public uint bufferOptimalSize; // 0x20

        // ── Methods ──
        public void get_numChannels(){} // RVA: 0x7FFAC8F93F90
        public void get_supportsImpulse(){} // RVA: 0x7FFAC9C9D840
        public void get_supportsBuffer(){} // RVA: 0x7FFAC9C9D850
        public void get_bufferFrequencyHz(){} // RVA: 0x7FFAC653D9A0
        public void get_bufferMaxSize(){} // RVA: 0x7FFAC659DBB0
        public void get_bufferOptimalSize(){} // RVA: 0x7FFAC9851CE0
        public void Equals(){} // RVA: 0x7FFAC9C9D940 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9C9D980
    }

    public class HashCodeHelper : Object
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0x7FFAC9CA28C0 | overloaded x7
    }

    public class InputDevice : ValueType
    {
        public System.Collections.Generic.List`1<UnityEngine.XR.XRInputSubsystem> deviceId;
        public ulong isValid; // 0x10
        public bool name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C9FAD0
        public void get_deviceId(){} // RVA: 0x7FFAC9C9FAE0
        public void get_isValid(){} // RVA: 0x7FFAC9C9FB00
        public void get_name(){} // RVA: 0x7FFAC9C9FB70
        public void get_manufacturer(){} // RVA: 0x7FFAC9C9FBE0
        public void get_serialNumber(){} // RVA: 0x7FFAC9C9FC50
        public void get_characteristics(){} // RVA: 0x7FFAC9C9FCC0
        public void IsValidId(){} // RVA: 0x7FFAC9C9FD30
        public void SendHapticImpulse(){} // RVA: 0x7FFAC9C9FD50
        public void TryGetHapticCapabilities(){} // RVA: 0x7FFAC9C9FE80
        public void TryGetFeatureValue(){} // RVA: 0x7FFAC9CA02F0 | overloaded x6
        public void CheckValidAndSetDefault(){} // RVA: 0x7FFAC2C59F60
        public void Equals(){} // RVA: 0x7FFAC9CA0470 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9CA04A0
    }

    public class InputDevices : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.XR.InputDevice> s_InputDeviceList;
        public System.Action`1<UnityEngine.XR.InputDevice> deviceConnected; // 0x8
        public System.Action`1<UnityEngine.XR.InputDevice> deviceDisconnected; // 0x10
        public System.Action`1<UnityEngine.XR.InputDevice> deviceConfigChanged; // 0x18

        // ── Methods ──
        public void GetDeviceAtXRNode(){} // RVA: 0x7FFAC9CA0720
        public void GetDevicesAtXRNode(){} // RVA: 0x7FFAC9CA07A0
        public void GetDevices(){} // RVA: 0x7FFAC9CA0BE0
        public void GetDevicesWithCharacteristics(){} // RVA: 0x7FFAC9CA0CB0
        public void add_deviceConnected(){} // RVA: 0x7FFAC9CA1200
        public void remove_deviceConnected(){} // RVA: 0x7FFAC9CA1340
        public void add_deviceDisconnected(){} // RVA: 0x7FFAC9CA1480
        public void remove_deviceDisconnected(){} // RVA: 0x7FFAC9CA15C0
        public void add_deviceConfigChanged(){} // RVA: 0x7FFAC9CA1700
        public void remove_deviceConfigChanged(){} // RVA: 0x7FFAC9CA1840
        public void InvokeConnectionEvent(){} // RVA: 0x7FFAC9CA1980
        public void GetDevices_Internal(){} // RVA: 0x7FFAC9CA1A50
        public void SendHapticImpulse(){} // RVA: 0x7FFAC9CA1AA0
        public void TryGetHapticCapabilities(){} // RVA: 0x7FFAC9CA1B20
        public void TryGetFeatureValue_bool(){} // RVA: 0x7FFAC9CA1B80
        public void TryGetFeatureValue_UInt32(){} // RVA: 0x7FFAC9CA1BF0
        public void TryGetFeatureValue_float(){} // RVA: 0x7FFAC9CA1C60
        public void TryGetFeatureValue_Vector2f(){} // RVA: 0x7FFAC9CA1CD0
        public void TryGetFeatureValue_Vector3f(){} // RVA: 0x7FFAC9CA1D40
        public void TryGetFeatureValue_Quaternionf(){} // RVA: 0x7FFAC9CA1DB0
        public void IsDeviceValid(){} // RVA: 0x7FFAC9CA1E20
        public void GetDeviceName(){} // RVA: 0x7FFAC9CA1E70
        public void GetDeviceManufacturer(){} // RVA: 0x7FFAC9CA1EC0
        public void GetDeviceSerialNumber(){} // RVA: 0x7FFAC9CA1F10
        public void GetDeviceCharacteristics(){} // RVA: 0x7FFAC9CA1F60
    }

    public class InputFeatureUsage : ValueType
    {
        public string name; // 0x10
        public 0x6B2C8F38 internalType; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC51D9A30
        public void get_internalType(){} // RVA: 0x7FFAC653D9A0
        public void Equals(){} // RVA: 0x7FFAC9C9DB00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9C9DB70
    }

    public class InputFeatureUsage`1 : ValueType
    {
        public string name;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2C58E90
        public void set_name(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Equals(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
    }

    public class InputTracking : Object
    {
        public System.Action`1<UnityEngine.XR.XRNodeState> trackingAcquired;
        public System.Action`1<UnityEngine.XR.XRNodeState> trackingLost; // 0x8
        public System.Action`1<UnityEngine.XR.XRNodeState> nodeAdded; // 0x10
        public System.Action`1<UnityEngine.XR.XRNodeState> nodeRemoved; // 0x18

        // ── Methods ──
        public void InvokeTrackingEvent(){} // RVA: 0x7FFAC9C9CF50
        public void GetLocalPosition(){} // RVA: 0x7FFAC9C9D110
        public void GetLocalRotation(){} // RVA: 0x7FFAC9C9D180
        public void Recenter(){} // RVA: 0x7FFAC9C9D1F0
        public void GetNodeStates(){} // RVA: 0x7FFAC9C9D240
        public void GetNodeStates_Internal(){} // RVA: 0x7FFAC9C9D310
        public void GetDeviceIdAtXRNode(){} // RVA: 0x7FFAC9C9D360
        public void GetDeviceIdsAtXRNode_Internal(){} // RVA: 0x7FFAC9C9D3B0
        public void GetLocalPosition_Injected(){} // RVA: 0x7FFAC9C9D410
        public void GetLocalRotation_Injected(){} // RVA: 0x7FFAC9C9D470
    }

    public class MeshGenerationResult : ValueType
    {
        public UnityEngine.XR.MeshId MeshId; // 0x10
        public UnityEngine.Mesh Mesh; // 0x20
        public UnityEngine.MeshCollider MeshCollider; // 0x28
        public 0x6B2C9670 Status; // 0x30
        public 0x6B2C9778 Attributes; // 0x34
        public ulong Position; // 0x38
        public UnityEngine.Vector3 Rotation; // 0x40
        public UnityEngine.Quaternion Scale; // 0x4C
        public UnityEngine.Vector3 <Scale>k__BackingField; // 0x5C

        // ── Methods ──
        public void get_MeshId(){} // RVA: 0x7FFAC32C0590
        public void get_Mesh(){} // RVA: 0x7FFAC2F3C380
        public void get_MeshCollider(){} // RVA: 0x7FFAC2F247C0
        public void get_Status(){} // RVA: 0x7FFAC30DBBE0
        public void get_Attributes(){} // RVA: 0x7FFAC3921980
        public void get_Position(){} // RVA: 0x7FFAC82CAB40
        public void get_Rotation(){} // RVA: 0x7FFAC8946F00
        public void get_Scale(){} // RVA: 0x7FFAC9CA2910
        public void Equals(){} // RVA: 0x7FFAC9CA2A00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9CA2BB0
    }

    public class MeshId : ValueType
    {
        public UnityEngine.XR.MeshId s_InvalidId;
        public ulong m_SubId1; // 0x10
        public ulong m_SubId2; // 0x18

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC9CA2610
        public void GetHashCode(){} // RVA: 0x7FFAC98A7070
        public void Equals(){} // RVA: 0x7FFAC98A7170 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9CA2780
    }

    public class XRDevice : Object
    {
        public System.Action`1<string> deviceLoaded;

        // ── Methods ──
        public void GetNativePtr(){} // RVA: 0x7FFAC9C9C7C0
        public void DisableAutoXRCameraTracking(){} // RVA: 0x7FFAC9C9C810
        public void add_deviceLoaded(){} // RVA: 0x7FFAC9C9C870
        public void remove_deviceLoaded(){} // RVA: 0x7FFAC9C9C9A0
        public void InvokeDeviceLoaded(){} // RVA: 0x7FFAC9C9CAD0
    }

    public class XRDisplaySubsystem : IntegratedSubsystem`1
    {
        public System.Action`1<bool> scaleOfAllRenderTargets; // 0x20
        public UnityEngine.HDROutputSettings m_HDROutputSettings; // 0x28

        // ── Methods ──
        public void InvokeDisplayFocusChanged(){} // RVA: 0x7FFAC9845210
        public void get_scaleOfAllRenderTargets(){} // RVA: 0x7FFAC9CA1FB0
        public void TryGetDisplayRefreshRate(){} // RVA: 0x7FFAC9CA2000
        public void .ctor(){} // RVA: 0x7FFAC9CA2060
    }

    public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CA2090
    }

    public class XRInputSubsystem : IntegratedSubsystem`1
    {
        public System.Action`1<UnityEngine.XR.XRInputSubsystem> trackingOriginUpdated; // 0x20
        public System.Action`1<UnityEngine.XR.XRInputSubsystem> boundaryChanged; // 0x28
        public System.Collections.Generic.List`1<ulong> m_DeviceIdsCache; // 0x30

        // ── Methods ──
        public void TryRecenter(){} // RVA: 0x7FFAC9CA20C0
        public void TrySetTrackingOriginMode(){} // RVA: 0x7FFAC9CA2110
        public void GetTrackingOriginMode(){} // RVA: 0x7FFAC9CA2170
        public void GetSupportedTrackingOriginModes(){} // RVA: 0x7FFAC9CA21C0
        public void add_trackingOriginUpdated(){} // RVA: 0x7FFAC9CA2210
        public void remove_trackingOriginUpdated(){} // RVA: 0x7FFAC9CA2310
        public void InvokeTrackingOriginUpdatedEvent(){} // RVA: 0x7FFAC9CA2410
        public void InvokeBoundaryChangedEvent(){} // RVA: 0x7FFAC9CA24E0
        public void .ctor(){} // RVA: 0x7FFAC9CA25B0
    }

    public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CA25E0
    }

    public class XRMeshSubsystem : IntegratedSubsystem`1
    {
        // ── Methods ──
        public void InvokeMeshReadyDelegate(){} // RVA: 0x7FFAC9CA2E30
        public void .ctor(){} // RVA: 0x7FFAC9CA2EA0
    }

    public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9CA2F70
    }

    public class XRNodeState : ValueType
    {
        public 0x6B2C8DD8 uniqueID; // 0x10
        public 0x6B2C8E30 nodeType; // 0x14
        public UnityEngine.Vector3 tracked; // 0x18
        public UnityEngine.Quaternion m_Rotation; // 0x24
        public UnityEngine.Vector3 m_Velocity; // 0x34
        public UnityEngine.Vector3 m_AngularVelocity; // 0x40
        public UnityEngine.Vector3 m_Acceleration; // 0x4C
        public UnityEngine.Vector3 m_AngularAcceleration; // 0x58
        public int m_Tracked; // 0x64
        public ulong m_UniqueID; // 0x68

        // ── Methods ──
        public void set_uniqueID(){} // RVA: 0x7FFAC4249140
        public void get_nodeType(){} // RVA: 0x7FFAC8F93F90
        public void set_nodeType(){} // RVA: 0x7FFAC336D8B0
        public void set_tracked(){} // RVA: 0x7FFAC9C9D4D0
        public void TryGetPosition(){} // RVA: 0x7FFAC9C9D4E0
        public void TryGetRotation(){} // RVA: 0x7FFAC9C9D550
        public void TryGetVelocity(){} // RVA: 0x7FFAC9C9D5B0
        public void TryGetAngularVelocity(){} // RVA: 0x7FFAC9C9D620
        public void TryGetAcceleration(){} // RVA: 0x7FFAC9C9D690
        public void TryGetAngularAcceleration(){} // RVA: 0x7FFAC9C9D700
        public void TryGet(){} // RVA: 0x7FFAC9C9D7E0 | overloaded x2
    }

    public class XRSettings : Object
    {
        public object enabled;
        public object showDeviceView;
        public object eyeTextureResolutionScale;
        public object eyeTextureWidth;
        public object eyeTextureHeight;
        public object eyeTextureDesc;
        public object renderViewportScale;
        public object renderViewportScaleInternal;
        public object loadedDeviceName;
        public object supportedDevices;
        public object stereoRenderingMode;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAC96E5F80
        public void set_enabled(){} // RVA: 0x7FFAC9C9C330
        public void get_showDeviceView(){} // RVA: 0x7FFAC9C9C380
        public void set_showDeviceView(){} // RVA: 0x7FFAC9C9C3D0
        public void get_eyeTextureResolutionScale(){} // RVA: 0x7FFAC8C96B50
        public void set_eyeTextureResolutionScale(){} // RVA: 0x7FFAC8C96BA0
        public void get_eyeTextureWidth(){} // RVA: 0x7FFAC9C9C420
        public void get_eyeTextureHeight(){} // RVA: 0x7FFAC9C9C470
        public void get_eyeTextureDesc(){} // RVA: 0x7FFAC9C9C4C0
        public void get_renderViewportScale(){} // RVA: 0x7FFAC9C9C530
        public void get_renderViewportScaleInternal(){} // RVA: 0x7FFAC9C9C530
        public void get_loadedDeviceName(){} // RVA: 0x7FFAC9C9C580
        public void LoadDeviceByName(){} // RVA: 0x7FFAC9C9C680 | overloaded x2
        public void get_supportedDevices(){} // RVA: 0x7FFAC9C9C6D0
        public void get_stereoRenderingMode(){} // RVA: 0x7FFAC9C9C720
        public void get_eyeTextureDesc_Injected(){} // RVA: 0x7FFAC9C9C770
    }

}