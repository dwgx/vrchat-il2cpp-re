// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.XR
// Classes: 18
// Methods: 132

namespace ThirdParty.Unity.UnityEngine.XR
{
    public class Bone : ValueType
    {
        public object deviceId;
        public object featureIndex;

        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFD505F9A30
        public void get_featureIndex(){} // RVA: 0x7FFD5195D9A0
        public void Equals(){} // RVA: 0x7FFD550C0580 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD550C05A0
    }

    public class Eyes : ValueType
    {
        public object deviceId;
        public object featureIndex;

        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFD505F9A30
        public void get_featureIndex(){} // RVA: 0x7FFD5195D9A0
        public void Equals(){} // RVA: 0x7FFD550C0580 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD550C05A0
    }

    public class Hand : ValueType
    {
        public object deviceId;
        public object featureIndex;

        // ── Methods ──
        public void get_deviceId(){} // RVA: 0x7FFD505F9A30
        public void get_featureIndex(){} // RVA: 0x7FFD5195D9A0
        public void Equals(){} // RVA: 0x7FFD550C0580 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD550C05A0
    }

    public class InputDevice : ValueType
    {
        public object deviceId;
        public object isValid;
        public object name;
        public object manufacturer;
        public object serialNumber;
        public object characteristics;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550BFAD0
        public void get_deviceId(){} // RVA: 0x7FFD550BFAE0
        public void get_isValid(){} // RVA: 0x7FFD550BFB00
        public void get_name(){} // RVA: 0x7FFD550BFB70
        public void get_manufacturer(){} // RVA: 0x7FFD550BFBE0
        public void get_serialNumber(){} // RVA: 0x7FFD550BFC50
        public void get_characteristics(){} // RVA: 0x7FFD550BFCC0
        public void IsValidId(){} // RVA: 0x7FFD550BFD30
        public void SendHapticImpulse(){} // RVA: 0x7FFD550BFD50
        public void TryGetHapticCapabilities(){} // RVA: 0x7FFD550BFE80
        public void TryGetFeatureValue(){} // RVA: 0x7FFD550C02F0 | overloaded x6
        public void CheckValidAndSetDefault(){} // RVA: 0x7FFD4E079F60
        public void Equals(){} // RVA: 0x7FFD550C0470 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD550C04A0
    }

    public class InputDevices : Object
    {
        // ── Methods ──
        public void GetDeviceAtXRNode(){} // RVA: 0x7FFD550C0720
        public void GetDevicesAtXRNode(){} // RVA: 0x7FFD550C07A0
        public void GetDevices(){} // RVA: 0x7FFD550C0BE0
        public void GetDevicesWithCharacteristics(){} // RVA: 0x7FFD550C0CB0
        public void add_deviceConnected(){} // RVA: 0x7FFD550C1200
        public void remove_deviceConnected(){} // RVA: 0x7FFD550C1340
        public void add_deviceDisconnected(){} // RVA: 0x7FFD550C1480
        public void remove_deviceDisconnected(){} // RVA: 0x7FFD550C15C0
        public void add_deviceConfigChanged(){} // RVA: 0x7FFD550C1700
        public void remove_deviceConfigChanged(){} // RVA: 0x7FFD550C1840
        public void InvokeConnectionEvent(){} // RVA: 0x7FFD550C1980
        public void GetDevices_Internal(){} // RVA: 0x7FFD550C1A50
        public void SendHapticImpulse(){} // RVA: 0x7FFD550C1AA0
        public void TryGetHapticCapabilities(){} // RVA: 0x7FFD550C1B20
        public void TryGetFeatureValue_bool(){} // RVA: 0x7FFD550C1B80
        public void TryGetFeatureValue_UInt32(){} // RVA: 0x7FFD550C1BF0
        public void TryGetFeatureValue_float(){} // RVA: 0x7FFD550C1C60
        public void TryGetFeatureValue_Vector2f(){} // RVA: 0x7FFD550C1CD0
        public void TryGetFeatureValue_Vector3f(){} // RVA: 0x7FFD550C1D40
        public void TryGetFeatureValue_Quaternionf(){} // RVA: 0x7FFD550C1DB0
        public void IsDeviceValid(){} // RVA: 0x7FFD550C1E20
        public void GetDeviceName(){} // RVA: 0x7FFD550C1E70
        public void GetDeviceManufacturer(){} // RVA: 0x7FFD550C1EC0
        public void GetDeviceSerialNumber(){} // RVA: 0x7FFD550C1F10
        public void GetDeviceCharacteristics(){} // RVA: 0x7FFD550C1F60
    }

    public class InputFeatureUsage : ValueType
    {
        public object name;
        public object internalType;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD505F9A30
        public void get_internalType(){} // RVA: 0x7FFD5195D9A0
        public void Equals(){} // RVA: 0x7FFD550BDB00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD550BDB70
    }

    public class InputFeatureUsage`1 : ValueType
    {
        public object name;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E078E90
        public void set_name(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Equals(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
    }

    public class InputTracking : Object
    {
        // ── Methods ──
        public void InvokeTrackingEvent(){} // RVA: 0x7FFD550BCF50
        public void GetLocalPosition(){} // RVA: 0x7FFD550BD110
        public void GetLocalRotation(){} // RVA: 0x7FFD550BD180
        public void Recenter(){} // RVA: 0x7FFD550BD1F0
        public void GetNodeStates(){} // RVA: 0x7FFD550BD240
        public void GetNodeStates_Internal(){} // RVA: 0x7FFD550BD310
        public void GetDeviceIdAtXRNode(){} // RVA: 0x7FFD550BD360
        public void GetDeviceIdsAtXRNode_Internal(){} // RVA: 0x7FFD550BD3B0
        public void GetLocalPosition_Injected(){} // RVA: 0x7FFD550BD410
        public void GetLocalRotation_Injected(){} // RVA: 0x7FFD550BD470
    }

    public class MeshGenerationResult : ValueType
    {
        public object MeshId;
        public object Mesh;
        public object MeshCollider;
        public object Status;
        public object Attributes;
        public object Position;
        public object Rotation;
        public object Scale;

        // ── Methods ──
        public void get_MeshId(){} // RVA: 0x7FFD4E6E0590
        public void get_Mesh(){} // RVA: 0x7FFD4E35C380
        public void get_MeshCollider(){} // RVA: 0x7FFD4E3447C0
        public void get_Status(){} // RVA: 0x7FFD4E4FBBE0
        public void get_Attributes(){} // RVA: 0x7FFD4ED41980
        public void get_Position(){} // RVA: 0x7FFD536EAB40
        public void get_Rotation(){} // RVA: 0x7FFD53D66F00
        public void get_Scale(){} // RVA: 0x7FFD550C2910
        public void Equals(){} // RVA: 0x7FFD550C2A00 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD550C2BB0
    }

    public class MeshId : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFD550C2610
        public void GetHashCode(){} // RVA: 0x7FFD54CC7070
        public void Equals(){} // RVA: 0x7FFD54CC7170 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD550C2780
    }

    public class XRDevice : Object
    {
        // ── Methods ──
        public void GetNativePtr(){} // RVA: 0x7FFD550BC7C0
        public void DisableAutoXRCameraTracking(){} // RVA: 0x7FFD550BC810
        public void add_deviceLoaded(){} // RVA: 0x7FFD550BC870
        public void remove_deviceLoaded(){} // RVA: 0x7FFD550BC9A0
        public void InvokeDeviceLoaded(){} // RVA: 0x7FFD550BCAD0
    }

    public class XRDisplaySubsystem : IntegratedSubsystem`1
    {
        public object scaleOfAllRenderTargets;

        // ── Methods ──
        public void InvokeDisplayFocusChanged(){} // RVA: 0x7FFD54C65210
        public void get_scaleOfAllRenderTargets(){} // RVA: 0x7FFD550C1FB0
        public void TryGetDisplayRefreshRate(){} // RVA: 0x7FFD550C2000
        public void .ctor(){} // RVA: 0x7FFD550C2060
    }

    public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550C2090
    }

    public class XRInputSubsystem : IntegratedSubsystem`1
    {
        // ── Methods ──
        public void TryRecenter(){} // RVA: 0x7FFD550C20C0
        public void TrySetTrackingOriginMode(){} // RVA: 0x7FFD550C2110
        public void GetTrackingOriginMode(){} // RVA: 0x7FFD550C2170
        public void GetSupportedTrackingOriginModes(){} // RVA: 0x7FFD550C21C0
        public void add_trackingOriginUpdated(){} // RVA: 0x7FFD550C2210
        public void remove_trackingOriginUpdated(){} // RVA: 0x7FFD550C2310
        public void InvokeTrackingOriginUpdatedEvent(){} // RVA: 0x7FFD550C2410
        public void InvokeBoundaryChangedEvent(){} // RVA: 0x7FFD550C24E0
        public void .ctor(){} // RVA: 0x7FFD550C25B0
    }

    public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550C25E0
    }

    public class XRMeshSubsystem : IntegratedSubsystem`1
    {
        // ── Methods ──
        public void InvokeMeshReadyDelegate(){} // RVA: 0x7FFD550C2E30
        public void .ctor(){} // RVA: 0x7FFD550C2EA0
    }

    public class XRMeshSubsystemDescriptor : IntegratedSubsystemDescriptor`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550C2F70
    }

    public class XRNodeState : ValueType
    {
        public object uniqueID;
        public object nodeType;
        public object tracked;

        // ── Methods ──
        public void set_uniqueID(){} // RVA: 0x7FFD4F669140
        public void get_nodeType(){} // RVA: 0x7FFD543B3F90
        public void set_nodeType(){} // RVA: 0x7FFD4E78D8B0
        public void set_tracked(){} // RVA: 0x7FFD550BD4D0
        public void TryGetPosition(){} // RVA: 0x7FFD550BD4E0
        public void TryGetRotation(){} // RVA: 0x7FFD550BD550
        public void TryGetVelocity(){} // RVA: 0x7FFD550BD5B0
        public void TryGetAngularVelocity(){} // RVA: 0x7FFD550BD620
        public void TryGetAcceleration(){} // RVA: 0x7FFD550BD690
        public void TryGetAngularAcceleration(){} // RVA: 0x7FFD550BD700
        public void TryGet(){} // RVA: 0x7FFD550BD7E0 | overloaded x2
    }

}