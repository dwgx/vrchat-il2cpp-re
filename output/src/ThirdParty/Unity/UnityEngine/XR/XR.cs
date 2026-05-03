// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR
// Classes: 22
// Methods: 166

namespace ThirdParty.Unity.UnityEngine.XR
{
    public class Bone : ValueType
    {
        public ulong m_DeviceId; // 0x10
        public uint m_FeatureIndex; // 0x18

        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFE8348B260
        public void get_featureIndex(){} // RVA: 0x7FFE848C3400
        public void Equals(){} // RVA: 0x7FFE88048DD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE88048DF0
    }

    public class CommonUsages : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE88046400
    }

    public class Eyes : ValueType
    {
        public ulong m_DeviceId; // 0x10
        public uint m_FeatureIndex; // 0x18

        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFE8348B260
        public void get_featureIndex(){} // RVA: 0x7FFE848C3400
        public void Equals(){} // RVA: 0x7FFE88048DD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE88048DF0
    }

    public class Hand : ValueType
    {
        public ulong m_DeviceId; // 0x10
        public uint m_FeatureIndex; // 0x18

        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFE8348B260
        public void get_featureIndex(){} // RVA: 0x7FFE848C3400
        public void Equals(){} // RVA: 0x7FFE88048DD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE88048DF0
    }

    public class HapticCapabilities : ValueType
    {
        public uint m_NumChannels; // 0x10
        public bool m_SupportsImpulse; // 0x14
        public bool m_SupportsBuffer; // 0x15
        public uint m_BufferFrequencyHz; // 0x18
        public uint m_BufferMaxSize; // 0x1C
        public uint m_BufferOptimalSize; // 0x20

        // ── Methods ──
        public void get_numChannels(){} // RVA: 0x7FFE8733C3B0
        public void get_supportsImpulse(){} // RVA: 0x7FFE88046090
        public void get_supportsBuffer(){} // RVA: 0x7FFE880460A0
        public void get_bufferFrequencyHz(){} // RVA: 0x7FFE848C3400
        public void get_bufferMaxSize(){} // RVA: 0x7FFE848EDA00
        public void get_bufferOptimalSize(){} // RVA: 0x7FFE87BFA280
        public void Equals(){} // RVA: 0x7FFE88046190 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE880461D0
    }

    public class HashCodeHelper : Object
    {
        // ── Methods ──
        public void Combine(){} // RVA: 0x7FFE8804B110 | overloaded x7
    }

    public class InputDevice : ValueType
    {
        public System.Collections.Generic.List`1<UnityEngine.XR.XRInputSubsystem> s_InputSubsystemCache;
        public ulong m_DeviceId; // 0x10
        public bool m_Initialized; // 0x18
        public object field_3; // 0xBD4D
        public object field_4; // 0xC918
        public object field_5;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88048320
        public void get_deviceId(){} // RVA: 0x7FFE88048330
        public void get_isValid(){} // RVA: 0x7FFE88048350
        public void get_name(){} // RVA: 0x7FFE880483C0
        public void get_manufacturer(){} // RVA: 0x7FFE88048430
        public void get_serialNumber(){} // RVA: 0x7FFE880484A0
        public void get_characteristics(){} // RVA: 0x7FFE88048510
        public void IsValidId(){} // RVA: 0x7FFE88048580
        public void SendHapticImpulse(){} // RVA: 0x7FFE880485A0
        public void TryGetHapticCapabilities(){} // RVA: 0x7FFE880486D0
        public void TryGetFeatureValue(){} // RVA: 0x7FFE88048B40 | overloaded x6
        public void CheckValidAndSetDefault(){} // RVA: 0x7FFE80E2F3B0
        public void Equals(){} // RVA: 0x7FFE88048CC0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE88048CF0
    }

    public class InputDevices : Object
    {
        // ── Methods ──
        public void GetDeviceAtXRNode(){} // RVA: 0x7FFE88048F70
        public void GetDevicesAtXRNode(){} // RVA: 0x7FFE88048FF0
        public void GetDevices(){} // RVA: 0x7FFE88049430
        public void GetDevicesWithCharacteristics(){} // RVA: 0x7FFE88049500
        public void add_deviceConnected(){} // RVA: 0x7FFE88049A50
        public void remove_deviceConnected(){} // RVA: 0x7FFE88049B90
        public void add_deviceDisconnected(){} // RVA: 0x7FFE88049CD0
        public void remove_deviceDisconnected(){} // RVA: 0x7FFE88049E10
        public void add_deviceConfigChanged(){} // RVA: 0x7FFE88049F50
        public void remove_deviceConfigChanged(){} // RVA: 0x7FFE8804A090
        public void InvokeConnectionEvent(){} // RVA: 0x7FFE8804A1D0
        public void GetDevices_Internal(){} // RVA: 0x7FFE8804A2A0
        public void SendHapticImpulse(){} // RVA: 0x7FFE8804A2F0
        public void TryGetHapticCapabilities(){} // RVA: 0x7FFE8804A370
        public void TryGetFeatureValue_bool(){} // RVA: 0x7FFE8804A3D0
        public void TryGetFeatureValue_UInt32(){} // RVA: 0x7FFE8804A440
        public void TryGetFeatureValue_float(){} // RVA: 0x7FFE8804A4B0
        public void TryGetFeatureValue_Vector2f(){} // RVA: 0x7FFE8804A520
        public void TryGetFeatureValue_Vector3f(){} // RVA: 0x7FFE8804A590
        public void TryGetFeatureValue_Quaternionf(){} // RVA: 0x7FFE8804A600
        public void IsDeviceValid(){} // RVA: 0x7FFE8804A670
        public void GetDeviceName(){} // RVA: 0x7FFE8804A6C0
        public void GetDeviceManufacturer(){} // RVA: 0x7FFE8804A710
        public void GetDeviceSerialNumber(){} // RVA: 0x7FFE8804A760
        public void GetDeviceCharacteristics(){} // RVA: 0x7FFE8804A7B0
    }

    public class InputFeatureUsage : ValueType
    {
        public string m_Name; // 0x10
        public 0x666C3FB4 m_InternalType; // 0x18

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE8348B260
        public void get_internalType(){} // RVA: 0x7FFE848C3400
        public void Equals(){} // RVA: 0x7FFE88046350 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE880463C0
    }

    public class InputFeatureUsage`1 : ValueType
    {
        public string _name;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE80E2E2E0
        public void set_name(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Equals(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
    }

    public class InputTracking : Object
    {
        // ── Methods ──
        public void InvokeTrackingEvent(){} // RVA: 0x7FFE880457A0
        public void GetLocalPosition(){} // RVA: 0x7FFE88045960
        public void GetLocalRotation(){} // RVA: 0x7FFE880459D0
        public void Recenter(){} // RVA: 0x7FFE88045A40
        public void GetNodeStates(){} // RVA: 0x7FFE88045A90
        public void GetNodeStates_Internal(){} // RVA: 0x7FFE88045B60
        public void GetDeviceIdAtXRNode(){} // RVA: 0x7FFE88045BB0
        public void GetDeviceIdsAtXRNode_Internal(){} // RVA: 0x7FFE88045C00
        public void GetLocalPosition_Injected(){} // RVA: 0x7FFE88045C60
        public void GetLocalRotation_Injected(){} // RVA: 0x7FFE88045CC0
    }

    public class MeshGenerationResult : ValueType
    {
        public UnityEngine.XR.MeshId _meshId; // 0x10
        public UnityEngine.Mesh _mesh; // 0x20
        public UnityEngine.MeshCollider _meshCollider; // 0x28
        public 0x666C46EC _status; // 0x30
        public 0x666C47F4 _attributes; // 0x34
        public ulong _timestamp; // 0x38
        public UnityEngine.Vector3 _position; // 0x40
        public UnityEngine.Quaternion _rotation; // 0x4C

        // ── Methods ──
        public void get_MeshId(){} // RVA: 0x7FFE8151C410
        public void get_Mesh(){} // RVA: 0x7FFE81116380
        public void get_MeshCollider(){} // RVA: 0x7FFE810FE7C0
        public void get_Status(){} // RVA: 0x7FFE8151D690
        public void get_Attributes(){} // RVA: 0x7FFE81A56130
        public void get_Position(){} // RVA: 0x7FFE828CAED0
        public void get_Rotation(){} // RVA: 0x7FFE86CF05A0
        public void get_Scale(){} // RVA: 0x7FFE8804B160
        public void Equals(){} // RVA: 0x7FFE8804B250 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8804B400
    }

    public class MeshId : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE8804AE60
        public void GetHashCode(){} // RVA: 0x7FFE87C4F970
        public void Equals(){} // RVA: 0x7FFE87C4FA70 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8804AFD0
    }

    public class XRDevice : Object
    {
        // ── Methods ──
        public void GetNativePtr(){} // RVA: 0x7FFE88045010
        public void DisableAutoXRCameraTracking(){} // RVA: 0x7FFE88045060
        public void add_deviceLoaded(){} // RVA: 0x7FFE880450C0
        public void remove_deviceLoaded(){} // RVA: 0x7FFE880451F0
        public void InvokeDeviceLoaded(){} // RVA: 0x7FFE88045320
    }

    public class XRDisplaySubsystem : IntegratedSubsystem`1
    {
        public System.Action`1<bool> displayFocusChanged; // 0x20

        // ── Methods ──
        public void InvokeDisplayFocusChanged(){} // RVA: 0x7FFE87BED7B0
        public void get_scaleOfAllRenderTargets(){} // RVA: 0x7FFE8804A800
        public void TryGetDisplayRefreshRate(){} // RVA: 0x7FFE8804A850
        public void .ctor(){} // RVA: 0x7FFE8804A8B0
    }

    public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8804A8E0
    }

    public class XRInputSubsystem : IntegratedSubsystem`1
    {
        // ── Methods ──
        public void TryRecenter(){} // RVA: 0x7FFE8804A910
        public void TrySetTrackingOriginMode(){} // RVA: 0x7FFE8804A960
        public void GetTrackingOriginMode(){} // RVA: 0x7FFE8804A9C0
        public void GetSupportedTrackingOriginModes(){} // RVA: 0x7FFE8804AA10
        public void add_trackingOriginUpdated(){} // RVA: 0x7FFE8804AA60
        public void remove_trackingOriginUpdated(){} // RVA: 0x7FFE8804AB60
        public void InvokeTrackingOriginUpdatedEvent(){} // RVA: 0x7FFE8804AC60
        public void InvokeBoundaryChangedEvent(){} // RVA: 0x7FFE8804AD30
        public void .ctor(){} // RVA: 0x7FFE8804AE00
    }

    public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8804AE30
    }

    public class XRMeshSubsystem : IntegratedSubsystem`1
    {
        // ── Methods ──
        public void InvokeMeshReadyDelegate(){} // RVA: 0x7FFE8804B680
        public void .ctor(){} // RVA: 0x7FFE8804B6F0
    }

    public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8804B7C0
    }

    public class XRNodeState : ValueType
    {
        public * m_Type; // 0x10
        public 0x666C3EAC m_AvailableFields; // 0x14
        public UnityEngine.Vector3 m_Position; // 0x18

        // ── Methods ──
        public void set_uniqueID(){} // RVA: 0x7FFE825093B0
        public void get_nodeType(){} // RVA: 0x7FFE8733C3B0
        public void set_nodeType(){} // RVA: 0x7FFE815BF990
        public void set_tracked(){} // RVA: 0x7FFE88045D20
        public void TryGetPosition(){} // RVA: 0x7FFE88045D30
        public void TryGetRotation(){} // RVA: 0x7FFE88045DA0
        public void TryGetVelocity(){} // RVA: 0x7FFE88045E00
        public void TryGetAngularVelocity(){} // RVA: 0x7FFE88045E70
        public void TryGetAcceleration(){} // RVA: 0x7FFE88045EE0
        public void TryGetAngularAcceleration(){} // RVA: 0x7FFE88045F50
        public void TryGet(){} // RVA: 0x7FFE88046030 | overloaded x2
    }

    public class XRSettings : Object
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFE87A8E4F0
        public void set_enabled(){} // RVA: 0x7FFE88044B80
        public void get_showDeviceView(){} // RVA: 0x7FFE88044BD0
        public void set_showDeviceView(){} // RVA: 0x7FFE88044C20
        public void get_eyeTextureResolutionScale(){} // RVA: 0x7FFE8703F040
        public void set_eyeTextureResolutionScale(){} // RVA: 0x7FFE8703F090
        public void get_eyeTextureWidth(){} // RVA: 0x7FFE88044C70
        public void get_eyeTextureHeight(){} // RVA: 0x7FFE88044CC0
        public void get_eyeTextureDesc(){} // RVA: 0x7FFE88044D10
        public void get_renderViewportScale(){} // RVA: 0x7FFE88044D80
        public void get_renderViewportScaleInternal(){} // RVA: 0x7FFE88044D80
        public void get_loadedDeviceName(){} // RVA: 0x7FFE88044DD0
        public void LoadDeviceByName(){} // RVA: 0x7FFE88044ED0 | overloaded x2
        public void get_supportedDevices(){} // RVA: 0x7FFE88044F20
        public void get_stereoRenderingMode(){} // RVA: 0x7FFE88044F70
        public void get_eyeTextureDesc_Injected(){} // RVA: 0x7FFE88044FC0
    }

}