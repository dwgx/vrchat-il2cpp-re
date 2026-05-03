// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR
// Classes: 16
// Methods: 149

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR
{
    public class Bone : ValueType
    {
        public uint m_ParentBoneIndex; // 0x10
        public UnityEngine.Vector3 m_Position; // 0x14
        public UnityEngine.Quaternion m_Rotation; // 0x20

        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7FFE826F4220
        public void set_parentBoneIndex(){} // RVA: 0x7FFE815BF990
        public void get_position(){} // RVA: 0x7FFE844559B0
        public void set_position(){} // RVA: 0x7FFE879E0CD0
        public void get_rotation(){} // RVA: 0x7FFE826F6B90
        public void set_rotation(){} // RVA: 0x7FFE826F6BA0
    }

    public class BoneControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.IntegerControl _parentBoneIndex; // 0x140
        public UnityEngine.InputSystem.Controls.Vector3Control _position; // 0x148
        public UnityEngine.InputSystem.Controls.QuaternionControl _rotation; // 0x150

        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7FFE811665F0
        public void set_parentBoneIndex(){} // RVA: 0x7FFE81166600
        public void get_position(){} // RVA: 0x7FFE81166660
        public void set_position(){} // RVA: 0x7FFE81166670
        public void get_rotation(){} // RVA: 0x7FFE81790740
        public void set_rotation(){} // RVA: 0x7FFE81B350B0
        public void FinishSetup(){} // RVA: 0x7FFE879E0D30
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE879E0F40
        public void WriteValueIntoState(){} // RVA: 0x7FFE879E1120
        public void .ctor(){} // RVA: 0x7FFE879E11E0
    }

    public class Eyes : ValueType
    {
        public UnityEngine.Vector3 m_LeftEyePosition; // 0x10
        public UnityEngine.Quaternion m_LeftEyeRotation; // 0x1C
        public UnityEngine.Vector3 m_RightEyePosition; // 0x2C
        public UnityEngine.Quaternion m_RightEyeRotation; // 0x38
        public UnityEngine.Vector3 m_FixationPoint; // 0x48
        public float m_LeftEyeOpenAmount; // 0x54
        public float m_RightEyeOpenAmount; // 0x58

        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7FFE835C1D60
        public void set_leftEyePosition(){} // RVA: 0x7FFE835C1F00
        public void get_leftEyeRotation(){} // RVA: 0x7FFE879E0CE0
        public void set_leftEyeRotation(){} // RVA: 0x7FFE879E0CF0
        public void get_rightEyePosition(){} // RVA: 0x7FFE879E0D00
        public void set_rightEyePosition(){} // RVA: 0x7FFE879E0D20
        public void get_rightEyeRotation(){} // RVA: 0x7FFE81E90600
        public void set_rightEyeRotation(){} // RVA: 0x7FFE81E8E800
        public void get_fixationPoint(){} // RVA: 0x7FFE81161F40
        public void set_fixationPoint(){} // RVA: 0x7FFE81161F60
        public void get_leftEyeOpenAmount(){} // RVA: 0x7FFE81103970
        public void set_leftEyeOpenAmount(){} // RVA: 0x7FFE81103980
        public void get_rightEyeOpenAmount(){} // RVA: 0x7FFE81C1C360
        public void set_rightEyeOpenAmount(){} // RVA: 0x7FFE81C1C2E0
    }

    public class EyesControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _leftEyePosition; // 0x198
        public UnityEngine.InputSystem.Controls.QuaternionControl _leftEyeRotation; // 0x1A0
        public UnityEngine.InputSystem.Controls.Vector3Control _rightEyePosition; // 0x1A8
        public UnityEngine.InputSystem.Controls.QuaternionControl _rightEyeRotation; // 0x1B0
        public UnityEngine.InputSystem.Controls.Vector3Control _fixationPoint; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl _leftEyeOpenAmount; // 0x1C0
        public UnityEngine.InputSystem.Controls.AxisControl _rightEyeOpenAmount; // 0x1C8

        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7FFE8181EA60
        public void set_leftEyePosition(){} // RVA: 0x7FFE81B33630
        public void get_leftEyeRotation(){} // RVA: 0x7FFE81B32390
        public void set_leftEyeRotation(){} // RVA: 0x7FFE81B21CA0
        public void get_rightEyePosition(){} // RVA: 0x7FFE8182AF50
        public void set_rightEyePosition(){} // RVA: 0x7FFE81B08F90
        public void get_rightEyeRotation(){} // RVA: 0x7FFE81B23A60
        public void set_rightEyeRotation(){} // RVA: 0x7FFE81B2ACE0
        public void get_fixationPoint(){} // RVA: 0x7FFE81B164E0
        public void set_fixationPoint(){} // RVA: 0x7FFE81B38D70
        public void get_leftEyeOpenAmount(){} // RVA: 0x7FFE817EFE00
        public void set_leftEyeOpenAmount(){} // RVA: 0x7FFE81B0C930
        public void get_rightEyeOpenAmount(){} // RVA: 0x7FFE81B16E90
        public void set_rightEyeOpenAmount(){} // RVA: 0x7FFE81B290E0
        public void FinishSetup(){} // RVA: 0x7FFE879E1260
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE879E1670
        public void WriteValueIntoState(){} // RVA: 0x7FFE879E1A60
        public void .ctor(){} // RVA: 0x7FFE879E1C00
    }

    public class PoseControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.ButtonControl _isTracked; // 0x178
        public UnityEngine.InputSystem.Controls.IntegerControl _trackingState; // 0x180
        public UnityEngine.InputSystem.Controls.Vector3Control _position; // 0x188
        public UnityEngine.InputSystem.Controls.QuaternionControl _rotation; // 0x190
        public UnityEngine.InputSystem.Controls.Vector3Control _velocity; // 0x198
        public UnityEngine.InputSystem.Controls.Vector3Control _angularVelocity; // 0x1A0

        // ── Methods ──
        public void get_isTracked(){} // RVA: 0x7FFE815BB1F0
        public void set_isTracked(){} // RVA: 0x7FFE81B10700
        public void get_trackingState(){} // RVA: 0x7FFE81B38340
        public void set_trackingState(){} // RVA: 0x7FFE81B31180
        public void get_position(){} // RVA: 0x7FFE81B295E0
        public void set_position(){} // RVA: 0x7FFE81B2E3B0
        public void get_rotation(){} // RVA: 0x7FFE81825EC0
        public void set_rotation(){} // RVA: 0x7FFE81B2A360
        public void get_velocity(){} // RVA: 0x7FFE8181EA60
        public void set_velocity(){} // RVA: 0x7FFE81B33630
        public void get_angularVelocity(){} // RVA: 0x7FFE81B32390
        public void set_angularVelocity(){} // RVA: 0x7FFE81B21CA0
        public void .ctor(){} // RVA: 0x7FFE879DAD90
        public void FinishSetup(){} // RVA: 0x7FFE879DAE80
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFE879DB220
        public void WriteValueIntoState(){} // RVA: 0x7FFE879DB4D0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFE879DB700
    }

    public class PoseState : ValueType
    {
        public int kSizeInBytes;

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFE879DACA0
        public void .ctor(){} // RVA: 0x7FFE879DAD00
        public void .cctor(){} // RVA: 0x7FFE879DAD50
    }

    public class TrackedPoseDriver : MonoBehaviour
    {
        public 0x6654292C m_TrackingType; // 0x20
        public 0x665429DC m_UpdateType; // 0x24
        public bool m_IgnoreTrackingState; // 0x28
        public UnityEngine.InputSystem.InputActionProperty m_PositionInput; // 0x30
        public UnityEngine.InputSystem.InputActionProperty m_RotationInput; // 0x48
        public UnityEngine.InputSystem.InputActionProperty m_TrackingStateInput; // 0x60
        public UnityEngine.Vector3 m_CurrentPosition; // 0x78
        public UnityEngine.Quaternion m_CurrentRotation; // 0x84

        // ── Methods ──
        public void get_trackingType(){} // RVA: 0x7FFE8151D690
        public void set_trackingType(){} // RVA: 0x7FFE8170B670
        public void get_updateType(){} // RVA: 0x7FFE81A56130
        public void set_updateType(){} // RVA: 0x7FFE82447980
        public void get_ignoreTrackingState(){} // RVA: 0x7FFE815F1380
        public void set_ignoreTrackingState(){} // RVA: 0x7FFE81C15740
        public void get_positionInput(){} // RVA: 0x7FFE82E0F4D0
        public void set_positionInput(){} // RVA: 0x7FFE879DC0E0
        public void get_rotationInput(){} // RVA: 0x7FFE86EF4B90
        public void set_rotationInput(){} // RVA: 0x7FFE879DC280
        public void get_trackingStateInput(){} // RVA: 0x7FFE84330F90
        public void set_trackingStateInput(){} // RVA: 0x7FFE879DC420
        public void BindActions(){} // RVA: 0x7FFE879DC5C0
        public void UnbindActions(){} // RVA: 0x7FFE879DC5F0
        public void BindPosition(){} // RVA: 0x7FFE879DC620
        public void BindRotation(){} // RVA: 0x7FFE879DC870
        public void BindTrackingState(){} // RVA: 0x7FFE879DCAC0
        public void RenameAndEnable(){} // RVA: 0x7FFE879DCD10
        public void UnbindPosition(){} // RVA: 0x7FFE879DCD40
        public void UnbindRotation(){} // RVA: 0x7FFE879DCF40
        public void UnbindTrackingState(){} // RVA: 0x7FFE879DD140
        public void OnPositionPerformed(){} // RVA: 0x7FFE879DD340
        public void OnPositionCanceled(){} // RVA: 0x7FFE879DD3B0
        public void OnRotationPerformed(){} // RVA: 0x7FFE879DD400
        public void OnRotationCanceled(){} // RVA: 0x7FFE879DD460
        public void OnTrackingStatePerformed(){} // RVA: 0x7FFE879DD4B0
        public void OnTrackingStateCanceled(){} // RVA: 0x7FFE879DD510
        public void Reset(){} // RVA: 0x7FFE879DD520
        public void Awake(){} // RVA: 0x7FFE879DD840
        public void OnEnable(){} // RVA: 0x7FFE879DD930
        public void OnDisable(){} // RVA: 0x7FFE879DDA00
        public void OnDestroy(){} // RVA: 0x7FFE879DDAC0
        public void UpdateCallback(){} // RVA: 0x7FFE879DDBB0
        public void ReadTrackingState(){} // RVA: 0x7FFE879DE070
        public void OnUpdate(){} // RVA: 0x7FFE879DE260
        public void OnBeforeRender(){} // RVA: 0x7FFE879DE290
        public void PerformUpdate(){} // RVA: 0x7FFE879DE2C0
        public void SetLocalTransform(){} // RVA: 0x7FFE879DE310
        public void HasStereoCamera(){} // RVA: 0x7FFE879DE550
        public void HasResolvedControl(){} // RVA: 0x7FFE879DE600
        public void get_positionAction(){} // RVA: 0x7FFE879DE6E0
        public void set_positionAction(){} // RVA: 0x7FFE879DE6F0
        public void get_rotationAction(){} // RVA: 0x7FFE879DE8C0
        public void set_rotationAction(){} // RVA: 0x7FFE879DE8D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE879DEAA0
        public void .ctor(){} // RVA: 0x7FFE879DEB60
    }

    public class UsageHint : ValueType
    {
    }

    public class XRController : TrackedDevice
    {
        // ── Methods ──
        public void get_leftHand(){} // RVA: 0x7FFE879DBD00
        public void get_rightHand(){} // RVA: 0x7FFE879DBDB0
        public void FinishSetup(){} // RVA: 0x7FFE879DBE60
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class XRControllerWithRumble : XRController
    {
        // ── Methods ──
        public void SendImpulse(){} // RVA: 0x7FFE879DC030
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class XRDeviceDescriptor : Object
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x7FFE879E0C80
        public void FromJson(){} // RVA: 0x7FFE879E0C90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XRFeatureDescriptor : ValueType
    {
    }

    public class XRHMD : TrackedDevice
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _leftEyePosition; // 0x1B0
        public UnityEngine.InputSystem.Controls.QuaternionControl _leftEyeRotation; // 0x1B8
        public UnityEngine.InputSystem.Controls.Vector3Control _rightEyePosition; // 0x1C0
        public UnityEngine.InputSystem.Controls.QuaternionControl _rightEyeRotation; // 0x1C8
        public UnityEngine.InputSystem.Controls.Vector3Control _centerEyePosition; // 0x1D0
        public UnityEngine.InputSystem.Controls.QuaternionControl _centerEyeRotation; // 0x1D8

        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7FFE81B23A60
        public void set_leftEyePosition(){} // RVA: 0x7FFE81B2ACE0
        public void get_leftEyeRotation(){} // RVA: 0x7FFE81B164E0
        public void set_leftEyeRotation(){} // RVA: 0x7FFE81B38D70
        public void get_rightEyePosition(){} // RVA: 0x7FFE817EFE00
        public void set_rightEyePosition(){} // RVA: 0x7FFE81B0C930
        public void get_rightEyeRotation(){} // RVA: 0x7FFE81B16E90
        public void set_rightEyeRotation(){} // RVA: 0x7FFE81B290E0
        public void get_centerEyePosition(){} // RVA: 0x7FFE81B32320
        public void set_centerEyePosition(){} // RVA: 0x7FFE81B31B60
        public void get_centerEyeRotation(){} // RVA: 0x7FFE81B23D60
        public void set_centerEyeRotation(){} // RVA: 0x7FFE81B11520
        public void FinishSetup(){} // RVA: 0x7FFE879DB990
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class XRLayoutBuilder : Object
    {
        // ── Methods ──
        public void GetSizeOfFeature(){} // RVA: 0x7FFE879DEC40
        public void SanitizeString(){} // RVA: 0x7FFE879DED00
        public void OnFindLayoutForDevice(){} // RVA: 0x7FFE879DEEB0
        public void ConvertPotentialAliasToName(){} // RVA: 0x7FFE879DF3F0
        public void IsSubControl(){} // RVA: 0x7FFE879DF680
        public void GetParentControlName(){} // RVA: 0x7FFE879DF6C0
        public void IsPoseControl(){} // RVA: 0x7FFE879DF700
        public void Build(){} // RVA: 0x7FFE879DF8C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE879E09F0
    }

    public class XRSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE879E1C80
    }

    public class XRUtilities : Object
    {
    }

}