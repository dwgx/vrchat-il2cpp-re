// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR
// Classes: 16
// Methods: 149

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR
{
    public class Bone
    {
        public uint leftEyePosition; // 0x10
        public UnityEngine.Vector3 leftEyeRotation; // 0x14
        public UnityEngine.Quaternion rightEyePosition; // 0x20

        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x19689B0
        public void set_parentBoneIndex(){} // RVA: 0x833580
        public void get_position(){} // RVA: 0x37C4F70
        public void set_position(){} // RVA: 0x6E9FE40
        public void get_rotation(){} // RVA: 0x196ABE0
        public void set_rotation(){} // RVA: 0x196ABF0
    }

    public class BoneControl
    {
        public UnityEngine.InputSystem.Controls.IntegerControl <parentBoneIndex>k__BackingField; // 0x140
        public UnityEngine.InputSystem.Controls.Vector3Control <position>k__BackingField; // 0x148
        public UnityEngine.InputSystem.Controls.QuaternionControl <rotation>k__BackingField; // 0x150

        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x3485F0
        public void set_parentBoneIndex(){} // RVA: 0x348600
        public void get_position(){} // RVA: 0x348660
        public void set_position(){} // RVA: 0x348670
        public void get_rotation(){} // RVA: 0x9FE130
        public void set_rotation(){} // RVA: 0xD8E9B0
        public void FinishSetup(){} // RVA: 0x6E9FEA0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6EA00B0
        public void WriteValueIntoState(){} // RVA: 0x6EA0290
        public void .ctor(){} // RVA: 0x6EA0350
    }

    public class Eyes
    {
        public UnityEngine.Vector3 leftHand; // 0x10
        public UnityEngine.Quaternion rightHand; // 0x1C
        public UnityEngine.Vector3 m_RightEyePosition; // 0x2C
        public UnityEngine.Quaternion m_RightEyeRotation; // 0x38
        public UnityEngine.Vector3 m_FixationPoint; // 0x48
        public float m_LeftEyeOpenAmount; // 0x54
        public float m_RightEyeOpenAmount; // 0x58

        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x210E270
        public void set_leftEyePosition(){} // RVA: 0x210E450
        public void get_leftEyeRotation(){} // RVA: 0x6E9FE50
        public void set_leftEyeRotation(){} // RVA: 0x6E9FE60
        public void get_rightEyePosition(){} // RVA: 0x6E9FE70
        public void set_rightEyePosition(){} // RVA: 0x6E9FE90
        public void get_rightEyeRotation(){} // RVA: 0x111F520
        public void set_rightEyeRotation(){} // RVA: 0x111C380
        public void get_fixationPoint(){} // RVA: 0x343F40
        public void set_fixationPoint(){} // RVA: 0x343F60
        public void get_leftEyeOpenAmount(){} // RVA: 0x2E5970
        public void set_leftEyeOpenAmount(){} // RVA: 0x2E5980
        public void get_rightEyeOpenAmount(){} // RVA: 0xEBB900
        public void set_rightEyeOpenAmount(){} // RVA: 0xEBB7C0
    }

    public class EyesControl
    {
        public UnityEngine.InputSystem.Controls.Vector3Control <leftEyePosition>k__BackingField; // 0x198
        public UnityEngine.InputSystem.Controls.QuaternionControl <leftEyeRotation>k__BackingField; // 0x1A0
        public UnityEngine.InputSystem.Controls.Vector3Control <rightEyePosition>k__BackingField; // 0x1A8
        public UnityEngine.InputSystem.Controls.QuaternionControl <rightEyeRotation>k__BackingField; // 0x1B0
        public UnityEngine.InputSystem.Controls.Vector3Control <fixationPoint>k__BackingField; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl <leftEyeOpenAmount>k__BackingField; // 0x1C0
        public UnityEngine.InputSystem.Controls.AxisControl <rightEyeOpenAmount>k__BackingField; // 0x1C8

        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0xA974D0
        public void set_leftEyePosition(){} // RVA: 0xD9C360
        public void get_leftEyeRotation(){} // RVA: 0xDB1150
        public void set_leftEyeRotation(){} // RVA: 0xD95560
        public void get_rightEyePosition(){} // RVA: 0xA94F10
        public void set_rightEyePosition(){} // RVA: 0xDA25E0
        public void get_rightEyeRotation(){} // RVA: 0xDA5040
        public void set_rightEyeRotation(){} // RVA: 0xD8AAB0
        public void get_fixationPoint(){} // RVA: 0xDB2150
        public void set_fixationPoint(){} // RVA: 0xD94B20
        public void get_leftEyeOpenAmount(){} // RVA: 0xA57F60
        public void set_leftEyeOpenAmount(){} // RVA: 0xD94790
        public void get_rightEyeOpenAmount(){} // RVA: 0xDA62D0
        public void set_rightEyeOpenAmount(){} // RVA: 0xD94E00
        public void FinishSetup(){} // RVA: 0x6EA03D0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6EA07E0
        public void WriteValueIntoState(){} // RVA: 0x6EA0BD0
        public void .ctor(){} // RVA: 0x6EA0D70
    }

    public class PoseControl
    {
        public UnityEngine.InputSystem.Controls.ButtonControl <isTracked>k__BackingField; // 0x178
        public UnityEngine.InputSystem.Controls.IntegerControl <trackingState>k__BackingField; // 0x180
        public UnityEngine.InputSystem.Controls.Vector3Control <position>k__BackingField; // 0x188
        public UnityEngine.InputSystem.Controls.QuaternionControl <rotation>k__BackingField; // 0x190
        public UnityEngine.InputSystem.Controls.Vector3Control <velocity>k__BackingField; // 0x198
        public UnityEngine.InputSystem.Controls.Vector3Control <angularVelocity>k__BackingField; // 0x1A0

        // ── Methods ──
        public void get_isTracked(){} // RVA: 0x82F060
        public void set_isTracked(){} // RVA: 0xD870D0
        public void get_trackingState(){} // RVA: 0xDA5BB0
        public void set_trackingState(){} // RVA: 0xD87C10
        public void get_position(){} // RVA: 0xD83B50
        public void set_position(){} // RVA: 0xD9F550
        public void get_rotation(){} // RVA: 0xA90180
        public void set_rotation(){} // RVA: 0xD96D90
        public void get_velocity(){} // RVA: 0xA974D0
        public void set_velocity(){} // RVA: 0xD9C360
        public void get_angularVelocity(){} // RVA: 0xDB1150
        public void set_angularVelocity(){} // RVA: 0xD95560
        public void .ctor(){} // RVA: 0x6E99F00
        public void FinishSetup(){} // RVA: 0x6E99FF0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x6E9A390
        public void WriteValueIntoState(){} // RVA: 0x6E9A640
        public void CalculateOptimizedControlDataType(){} // RVA: 0x6E9A870
    }

    public class PoseState
    {
        public int kSizeInBytes;

        // ── Methods ──
        public void get_format(){} // RVA: 0x6E99E10
        public void .ctor(){} // RVA: 0x6E99E70
        public void .cctor(){} // RVA: 0x6E99EC0
    }

    public class TrackedPoseDriver
    {
        public 0x6586AA78 m_TrackingType; // 0x20
        public 0x6586AB28 m_UpdateType; // 0x24
        public bool m_IgnoreTrackingState; // 0x28
        public UnityEngine.InputSystem.InputActionProperty m_PositionInput; // 0x30
        public UnityEngine.InputSystem.InputActionProperty m_RotationInput; // 0x48
        public UnityEngine.InputSystem.InputActionProperty m_TrackingStateInput; // 0x60
        public UnityEngine.Vector3 m_CurrentPosition; // 0x78
        public UnityEngine.Quaternion m_CurrentRotation; // 0x84

        // ── Methods ──
        public void get_trackingType(){} // RVA: 0x760030
        public void set_trackingType(){} // RVA: 0x99E0D0
        public void get_updateType(){} // RVA: 0xCEF5B0
        public void set_updateType(){} // RVA: 0x16E1F00
        public void get_ignoreTrackingState(){} // RVA: 0x6E8A80
        public void set_ignoreTrackingState(){} // RVA: 0x6E8B80
        public void get_positionInput(){} // RVA: 0x207FEE0
        public void set_positionInput(){} // RVA: 0x6E9B250
        public void get_rotationInput(){} // RVA: 0x63B4160
        public void set_rotationInput(){} // RVA: 0x6E9B3F0
        public void get_trackingStateInput(){} // RVA: 0x36ACED0
        public void set_trackingStateInput(){} // RVA: 0x6E9B590
        public void BindActions(){} // RVA: 0x6E9B730
        public void UnbindActions(){} // RVA: 0x6E9B760
        public void BindPosition(){} // RVA: 0x6E9B790
        public void BindRotation(){} // RVA: 0x6E9B9E0
        public void BindTrackingState(){} // RVA: 0x6E9BC30
        public void RenameAndEnable(){} // RVA: 0x6E9BE80
        public void UnbindPosition(){} // RVA: 0x6E9BEB0
        public void UnbindRotation(){} // RVA: 0x6E9C0B0
        public void UnbindTrackingState(){} // RVA: 0x6E9C2B0
        public void OnPositionPerformed(){} // RVA: 0x6E9C4B0
        public void OnPositionCanceled(){} // RVA: 0x6E9C520
        public void OnRotationPerformed(){} // RVA: 0x6E9C570
        public void OnRotationCanceled(){} // RVA: 0x6E9C5D0
        public void OnTrackingStatePerformed(){} // RVA: 0x6E9C620
        public void OnTrackingStateCanceled(){} // RVA: 0x6E9C680
        public void Reset(){} // RVA: 0x6E9C690
        public void Awake(){} // RVA: 0x6E9C9B0
        public void OnEnable(){} // RVA: 0x6E9CAA0
        public void OnDisable(){} // RVA: 0x6E9CB70
        public void OnDestroy(){} // RVA: 0x6E9CC30
        public void UpdateCallback(){} // RVA: 0x6E9CD20
        public void ReadTrackingState(){} // RVA: 0x6E9D1E0
        public void OnUpdate(){} // RVA: 0x6E9D3D0
        public void OnBeforeRender(){} // RVA: 0x6E9D400
        public void PerformUpdate(){} // RVA: 0x6E9D430
        public void SetLocalTransform(){} // RVA: 0x6E9D480
        public void HasStereoCamera(){} // RVA: 0x6E9D6C0
        public void HasResolvedControl(){} // RVA: 0x6E9D770
        public void get_positionAction(){} // RVA: 0x6E9D850
        public void set_positionAction(){} // RVA: 0x6E9D860
        public void get_rotationAction(){} // RVA: 0x6E9DA30
        public void set_rotationAction(){} // RVA: 0x6E9DA40
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6E9DC10
        public void .ctor(){} // RVA: 0x6E9DCD0
    }

    public class UsageHint
    {
    }

    public class XRController
    {
        // ── Methods ──
        public void get_leftHand(){} // RVA: 0x6E9AE70
        public void get_rightHand(){} // RVA: 0x6E9AF20
        public void FinishSetup(){} // RVA: 0x6E9AFD0
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class XRControllerWithRumble
    {
        // ── Methods ──
        public void SendImpulse(){} // RVA: 0x6E9B1A0
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class XRDeviceDescriptor
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x6E9FDF0
        public void FromJson(){} // RVA: 0x6E9FE00
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XRFeatureDescriptor
    {
    }

    public class XRHMD
    {
        public UnityEngine.InputSystem.Controls.Vector3Control <leftEyePosition>k__BackingField; // 0x1B0
        public UnityEngine.InputSystem.Controls.QuaternionControl <leftEyeRotation>k__BackingField; // 0x1B8
        public UnityEngine.InputSystem.Controls.Vector3Control <rightEyePosition>k__BackingField; // 0x1C0
        public UnityEngine.InputSystem.Controls.QuaternionControl <rightEyeRotation>k__BackingField; // 0x1C8
        public UnityEngine.InputSystem.Controls.Vector3Control <centerEyePosition>k__BackingField; // 0x1D0
        public UnityEngine.InputSystem.Controls.QuaternionControl <centerEyeRotation>k__BackingField; // 0x1D8

        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0xDA5040
        public void set_leftEyePosition(){} // RVA: 0xD8AAB0
        public void get_leftEyeRotation(){} // RVA: 0xDB2150
        public void set_leftEyeRotation(){} // RVA: 0xD94B20
        public void get_rightEyePosition(){} // RVA: 0xA57F60
        public void set_rightEyePosition(){} // RVA: 0xD94790
        public void get_rightEyeRotation(){} // RVA: 0xDA62D0
        public void set_rightEyeRotation(){} // RVA: 0xD94E00
        public void get_centerEyePosition(){} // RVA: 0xDB3D70
        public void set_centerEyePosition(){} // RVA: 0xD86540
        public void get_centerEyeRotation(){} // RVA: 0xD9ABC0
        public void set_centerEyeRotation(){} // RVA: 0xD9A380
        public void FinishSetup(){} // RVA: 0x6E9AB00
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class XRLayoutBuilder
    {
        // ── Methods ──
        public void GetSizeOfFeature(){} // RVA: 0x6E9DDB0
        public void SanitizeString(){} // RVA: 0x6E9DE70
        public void OnFindLayoutForDevice(){} // RVA: 0x6E9E020
        public void ConvertPotentialAliasToName(){} // RVA: 0x6E9E560
        public void IsSubControl(){} // RVA: 0x6E9E7F0
        public void GetParentControlName(){} // RVA: 0x6E9E830
        public void IsPoseControl(){} // RVA: 0x6E9E870
        public void Build(){} // RVA: 0x6E9EA30
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6E9FB60
    }

    public class XRSupport
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x6EA0DF0
    }

    public class XRUtilities
    {
    }

}