// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR
// Classes: 16
// Methods: 149

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR
{
    public class Bone : ValueType
    {
        public uint parentBoneIndex; // 0x10
        public UnityEngine.Vector3 position; // 0x14
        public UnityEngine.Quaternion rotation; // 0x20

        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7FFAC4420210
        public void set_parentBoneIndex(){} // RVA: 0x7FFAC336D8B0
        public void get_position(){} // RVA: 0x7FFAC60F07C0
        public void set_position(){} // RVA: 0x7FFAC9638590
        public void get_rotation(){} // RVA: 0x7FFAC4422E80
        public void set_rotation(){} // RVA: 0x7FFAC4422E90
    }

    public class BoneControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.IntegerControl parentBoneIndex; // 0x140
        public UnityEngine.InputSystem.Controls.Vector3Control position; // 0x148
        public UnityEngine.InputSystem.Controls.QuaternionControl rotation; // 0x150

        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7FFAC2F8C5F0
        public void set_parentBoneIndex(){} // RVA: 0x7FFAC2F8C600
        public void get_position(){} // RVA: 0x7FFAC2F8C660
        public void set_position(){} // RVA: 0x7FFAC2F8C670
        public void get_rotation(){} // RVA: 0x7FFAC354DFA0
        public void set_rotation(){} // RVA: 0x7FFAC39B99C0
        public void FinishSetup(){} // RVA: 0x7FFAC96385F0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC9638800
        public void WriteValueIntoState(){} // RVA: 0x7FFAC96389E0
        public void .ctor(){} // RVA: 0x7FFAC9638AA0
    }

    public class Eyes : ValueType
    {
        public UnityEngine.Vector3 leftEyePosition; // 0x10
        public UnityEngine.Quaternion leftEyeRotation; // 0x1C
        public UnityEngine.Vector3 rightEyePosition; // 0x2C
        public UnityEngine.Quaternion rightEyeRotation; // 0x38
        public UnityEngine.Vector3 fixationPoint; // 0x48
        public float leftEyeOpenAmount; // 0x54
        public float rightEyeOpenAmount; // 0x58

        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7FFAC530B520
        public void set_leftEyePosition(){} // RVA: 0x7FFAC530B6C0
        public void get_leftEyeRotation(){} // RVA: 0x7FFAC96385A0
        public void set_leftEyeRotation(){} // RVA: 0x7FFAC96385B0
        public void get_rightEyePosition(){} // RVA: 0x7FFAC96385C0
        public void set_rightEyePosition(){} // RVA: 0x7FFAC96385E0
        public void get_rightEyeRotation(){} // RVA: 0x7FFAC3BCF020
        public void set_rightEyeRotation(){} // RVA: 0x7FFAC3BCC210
        public void get_fixationPoint(){} // RVA: 0x7FFAC2F87F40
        public void set_fixationPoint(){} // RVA: 0x7FFAC2F87F60
        public void get_leftEyeOpenAmount(){} // RVA: 0x7FFAC2F29970
        public void set_leftEyeOpenAmount(){} // RVA: 0x7FFAC2F29980
        public void get_rightEyeOpenAmount(){} // RVA: 0x7FFAC45C0DE0
        public void set_rightEyeOpenAmount(){} // RVA: 0x7FFAC45C0F70
    }

    public class EyesControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.Vector3Control leftEyePosition; // 0x198
        public UnityEngine.InputSystem.Controls.QuaternionControl leftEyeRotation; // 0x1A0
        public UnityEngine.InputSystem.Controls.Vector3Control rightEyePosition; // 0x1A8
        public UnityEngine.InputSystem.Controls.QuaternionControl rightEyeRotation; // 0x1B0
        public UnityEngine.InputSystem.Controls.Vector3Control fixationPoint; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl leftEyeOpenAmount; // 0x1C0
        public UnityEngine.InputSystem.Controls.AxisControl rightEyeOpenAmount; // 0x1C8

        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7FFAC3541C80
        public void set_leftEyePosition(){} // RVA: 0x7FFAC39C8ED0
        public void get_leftEyeRotation(){} // RVA: 0x7FFAC354E2E0
        public void set_leftEyeRotation(){} // RVA: 0x7FFAC39A8AF0
        public void get_rightEyePosition(){} // RVA: 0x7FFAC3548F80
        public void set_rightEyePosition(){} // RVA: 0x7FFAC39B4D10
        public void get_rightEyeRotation(){} // RVA: 0x7FFAC3549F30
        public void set_rightEyeRotation(){} // RVA: 0x7FFAC39A7790
        public void get_fixationPoint(){} // RVA: 0x7FFAC3544330
        public void set_fixationPoint(){} // RVA: 0x7FFAC39AC050
        public void get_leftEyeOpenAmount(){} // RVA: 0x7FFAC35422B0
        public void set_leftEyeOpenAmount(){} // RVA: 0x7FFAC39AD110
        public void get_rightEyeOpenAmount(){} // RVA: 0x7FFAC39CCB10
        public void set_rightEyeOpenAmount(){} // RVA: 0x7FFAC39CF3F0
        public void FinishSetup(){} // RVA: 0x7FFAC9638B20
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC9638F30
        public void WriteValueIntoState(){} // RVA: 0x7FFAC9639320
        public void .ctor(){} // RVA: 0x7FFAC96394C0
    }

    public class PoseControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.ButtonControl isTracked; // 0x178
        public UnityEngine.InputSystem.Controls.IntegerControl trackingState; // 0x180
        public UnityEngine.InputSystem.Controls.Vector3Control position; // 0x188
        public UnityEngine.InputSystem.Controls.QuaternionControl rotation; // 0x190
        public UnityEngine.InputSystem.Controls.Vector3Control velocity; // 0x198
        public UnityEngine.InputSystem.Controls.Vector3Control angularVelocity; // 0x1A0

        // ── Methods ──
        public void get_isTracked(){} // RVA: 0x7FFAC336D860
        public void set_isTracked(){} // RVA: 0x7FFAC39CA130
        public void get_trackingState(){} // RVA: 0x7FFAC354B1B0
        public void set_trackingState(){} // RVA: 0x7FFAC3503070
        public void get_position(){} // RVA: 0x7FFAC35410C0
        public void set_position(){} // RVA: 0x7FFAC3503010
        public void get_rotation(){} // RVA: 0x7FFAC3540F60
        public void set_rotation(){} // RVA: 0x7FFAC39AB1D0
        public void get_velocity(){} // RVA: 0x7FFAC3541C80
        public void set_velocity(){} // RVA: 0x7FFAC39C8ED0
        public void get_angularVelocity(){} // RVA: 0x7FFAC354E2E0
        public void set_angularVelocity(){} // RVA: 0x7FFAC39A8AF0
        public void .ctor(){} // RVA: 0x7FFAC9632650
        public void FinishSetup(){} // RVA: 0x7FFAC9632740
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAC9632AE0
        public void WriteValueIntoState(){} // RVA: 0x7FFAC9632D90
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAC9632FC0
    }

    public class PoseState : ValueType
    {
        public int format;
        public UnityEngine.InputSystem.Utilities.FourCC s_Format;
        public bool isTracked; // 0x10
        public 0x6B2C9040 trackingState; // 0x14
        public UnityEngine.Vector3 position; // 0x18
        public UnityEngine.Quaternion rotation; // 0x24
        public UnityEngine.Vector3 velocity; // 0x34
        public UnityEngine.Vector3 angularVelocity; // 0x40

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFAC9632560
        public void .ctor(){} // RVA: 0x7FFAC96325C0
        public void .cctor(){} // RVA: 0x7FFAC9632610
    }

    public class TrackedPoseDriver : MonoBehaviour
    {
        public 0x6B149A08 trackingType; // 0x20
        public 0x6B149AB8 updateType; // 0x24
        public bool ignoreTrackingState; // 0x28
        public UnityEngine.InputSystem.InputActionProperty positionInput; // 0x30
        public UnityEngine.InputSystem.InputActionProperty rotationInput; // 0x48
        public UnityEngine.InputSystem.InputActionProperty trackingStateInput; // 0x60
        public UnityEngine.Vector3 positionAction; // 0x78
        public UnityEngine.Quaternion rotationAction; // 0x84
        public 0x6B149A60 m_CurrentTrackingState; // 0x94
        public bool m_RotationBound; // 0x98
        public bool m_PositionBound; // 0x99
        public bool m_TrackingStateBound; // 0x9A
        public bool m_IsFirstUpdate; // 0x9B
        public UnityEngine.InputSystem.InputAction m_PositionAction; // 0xA0
        public UnityEngine.InputSystem.InputAction m_RotationAction; // 0xA8

        // ── Methods ──
        public void get_trackingType(){} // RVA: 0x7FFAC30DBBE0
        public void set_trackingType(){} // RVA: 0x7FFAC35DB7A0
        public void get_updateType(){} // RVA: 0x7FFAC3921980
        public void set_updateType(){} // RVA: 0x7FFAC41674D0
        public void get_ignoreTrackingState(){} // RVA: 0x7FFAC30F6BA0
        public void set_ignoreTrackingState(){} // RVA: 0x7FFAC3C24F40
        public void get_positionInput(){} // RVA: 0x7FFAC4BA6360
        public void set_positionInput(){} // RVA: 0x7FFAC96339A0
        public void get_rotationInput(){} // RVA: 0x7FFAC8B4B520
        public void set_rotationInput(){} // RVA: 0x7FFAC9633B40
        public void get_trackingStateInput(){} // RVA: 0x7FFAC5FD9A30
        public void set_trackingStateInput(){} // RVA: 0x7FFAC9633CE0
        public void BindActions(){} // RVA: 0x7FFAC9633E80
        public void UnbindActions(){} // RVA: 0x7FFAC9633EB0
        public void BindPosition(){} // RVA: 0x7FFAC9633EE0
        public void BindRotation(){} // RVA: 0x7FFAC9634130
        public void BindTrackingState(){} // RVA: 0x7FFAC9634380
        public void RenameAndEnable(){} // RVA: 0x7FFAC96345D0
        public void UnbindPosition(){} // RVA: 0x7FFAC9634600
        public void UnbindRotation(){} // RVA: 0x7FFAC9634800
        public void UnbindTrackingState(){} // RVA: 0x7FFAC9634A00
        public void OnPositionPerformed(){} // RVA: 0x7FFAC9634C00
        public void OnPositionCanceled(){} // RVA: 0x7FFAC9634C70
        public void OnRotationPerformed(){} // RVA: 0x7FFAC9634CC0
        public void OnRotationCanceled(){} // RVA: 0x7FFAC9634D20
        public void OnTrackingStatePerformed(){} // RVA: 0x7FFAC9634D70
        public void OnTrackingStateCanceled(){} // RVA: 0x7FFAC9634DD0
        public void Reset(){} // RVA: 0x7FFAC9634DE0
        public void Awake(){} // RVA: 0x7FFAC9635100
        public void OnEnable(){} // RVA: 0x7FFAC96351F0
        public void OnDisable(){} // RVA: 0x7FFAC96352C0
        public void OnDestroy(){} // RVA: 0x7FFAC9635380
        public void UpdateCallback(){} // RVA: 0x7FFAC9635470
        public void ReadTrackingState(){} // RVA: 0x7FFAC9635930
        public void OnUpdate(){} // RVA: 0x7FFAC9635B20
        public void OnBeforeRender(){} // RVA: 0x7FFAC9635B50
        public void PerformUpdate(){} // RVA: 0x7FFAC9635B80
        public void SetLocalTransform(){} // RVA: 0x7FFAC9635BD0
        public void HasStereoCamera(){} // RVA: 0x7FFAC9635E10
        public void HasResolvedControl(){} // RVA: 0x7FFAC9635EC0
        public void get_positionAction(){} // RVA: 0x7FFAC9635FA0
        public void set_positionAction(){} // RVA: 0x7FFAC9635FB0
        public void get_rotationAction(){} // RVA: 0x7FFAC9636180
        public void set_rotationAction(){} // RVA: 0x7FFAC9636190
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC9636360
        public void .ctor(){} // RVA: 0x7FFAC9636420
    }

    public class UsageHint : ValueType
    {
        public string content; // 0x10
    }

    public class XRController : TrackedDevice
    {
        public object leftHand;
        public object rightHand;

        // ── Methods ──
        public void get_leftHand(){} // RVA: 0x7FFAC96335C0
        public void get_rightHand(){} // RVA: 0x7FFAC9633670
        public void FinishSetup(){} // RVA: 0x7FFAC9633720
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class XRControllerWithRumble : XRController
    {
        // ── Methods ──
        public void SendImpulse(){} // RVA: 0x7FFAC96338F0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class XRDeviceDescriptor : Object
    {
        public string deviceName; // 0x10
        public string manufacturer; // 0x18
        public string serialNumber; // 0x20
        public 0x6B2C8FE8 characteristics; // 0x28
        public int deviceId; // 0x2C
        public System.Collections.Generic.List`1<UnityEngine.InputSystem.XR.XRFeatureDescriptor> inputFeatures; // 0x30

        // ── Methods ──
        public void ToJson(){} // RVA: 0x7FFAC9638540
        public void FromJson(){} // RVA: 0x7FFAC9638550
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XRFeatureDescriptor : ValueType
    {
        public string name; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.InputSystem.XR.UsageHint> usageHints; // 0x18
        public 0x6B149C70 featureType; // 0x20
        public uint customSize; // 0x24
    }

    public class XRHMD : TrackedDevice
    {
        public UnityEngine.InputSystem.Controls.Vector3Control leftEyePosition; // 0x1B0
        public UnityEngine.InputSystem.Controls.QuaternionControl leftEyeRotation; // 0x1B8
        public UnityEngine.InputSystem.Controls.Vector3Control rightEyePosition; // 0x1C0
        public UnityEngine.InputSystem.Controls.QuaternionControl rightEyeRotation; // 0x1C8
        public UnityEngine.InputSystem.Controls.Vector3Control centerEyePosition; // 0x1D0
        public UnityEngine.InputSystem.Controls.QuaternionControl centerEyeRotation; // 0x1D8

        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7FFAC3549F30
        public void set_leftEyePosition(){} // RVA: 0x7FFAC39A7790
        public void get_leftEyeRotation(){} // RVA: 0x7FFAC3544330
        public void set_leftEyeRotation(){} // RVA: 0x7FFAC39AC050
        public void get_rightEyePosition(){} // RVA: 0x7FFAC35422B0
        public void set_rightEyePosition(){} // RVA: 0x7FFAC39AD110
        public void get_rightEyeRotation(){} // RVA: 0x7FFAC39CCB10
        public void set_rightEyeRotation(){} // RVA: 0x7FFAC39CF3F0
        public void get_centerEyePosition(){} // RVA: 0x7FFAC39C1920
        public void set_centerEyePosition(){} // RVA: 0x7FFAC39A8050
        public void get_centerEyeRotation(){} // RVA: 0x7FFAC39C0A30
        public void set_centerEyeRotation(){} // RVA: 0x7FFAC39CF5C0
        public void FinishSetup(){} // RVA: 0x7FFAC9633250
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class XRLayoutBuilder : Object
    {
        public string parentLayout; // 0x10
        public string interfaceName; // 0x18
        public UnityEngine.InputSystem.XR.XRDeviceDescriptor descriptor; // 0x20
        public string[] poseSubControlNames;
        public 0x6B149C70[] poseSubControlTypes; // 0x8

        // ── Methods ──
        public void GetSizeOfFeature(){} // RVA: 0x7FFAC9636500
        public void SanitizeString(){} // RVA: 0x7FFAC96365C0
        public void OnFindLayoutForDevice(){} // RVA: 0x7FFAC9636770
        public void ConvertPotentialAliasToName(){} // RVA: 0x7FFAC9636CB0
        public void IsSubControl(){} // RVA: 0x7FFAC9636F40
        public void GetParentControlName(){} // RVA: 0x7FFAC9636F80
        public void IsPoseControl(){} // RVA: 0x7FFAC9636FC0
        public void Build(){} // RVA: 0x7FFAC9637180
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC96382B0
    }

    public class XRSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC9639540
    }

    public class XRUtilities : Object
    {
        public string InterfaceMatchAnyVersion;
        public string InterfaceV1;
        public string InterfaceCurrent;
    }

}