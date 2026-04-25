// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR
// Classes: 12
// Methods: 146

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR
{
    public class Bone : ValueType
    {
        public uint parentBoneIndex; // 0x10
        public UnityEngine.Vector3 position; // 0x14
        public UnityEngine.Quaternion rotation; // 0x20

        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7FFD4F840210
        public void set_parentBoneIndex(){} // RVA: 0x7FFD4E78D8B0
        public void get_position(){} // RVA: 0x7FFD515107C0
        public void set_position(){} // RVA: 0x7FFD54A58590
        public void get_rotation(){} // RVA: 0x7FFD4F842E80
        public void set_rotation(){} // RVA: 0x7FFD4F842E90
    }

    public class BoneControl : InputControl`1
    {
        public UnityEngine.InputSystem.Controls.IntegerControl parentBoneIndex; // 0x140
        public UnityEngine.InputSystem.Controls.Vector3Control position; // 0x148
        public UnityEngine.InputSystem.Controls.QuaternionControl rotation; // 0x150

        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7FFD4E3AC5F0
        public void set_parentBoneIndex(){} // RVA: 0x7FFD4E3AC600
        public void get_position(){} // RVA: 0x7FFD4E3AC660
        public void set_position(){} // RVA: 0x7FFD4E3AC670
        public void get_rotation(){} // RVA: 0x7FFD4E96DFA0
        public void set_rotation(){} // RVA: 0x7FFD4EDD99C0
        public void FinishSetup(){} // RVA: 0x7FFD54A585F0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD54A58800
        public void WriteValueIntoState(){} // RVA: 0x7FFD54A589E0
        public void .ctor(){} // RVA: 0x7FFD54A58AA0
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
        public void get_leftEyePosition(){} // RVA: 0x7FFD5072B520
        public void set_leftEyePosition(){} // RVA: 0x7FFD5072B6C0
        public void get_leftEyeRotation(){} // RVA: 0x7FFD54A585A0
        public void set_leftEyeRotation(){} // RVA: 0x7FFD54A585B0
        public void get_rightEyePosition(){} // RVA: 0x7FFD54A585C0
        public void set_rightEyePosition(){} // RVA: 0x7FFD54A585E0
        public void get_rightEyeRotation(){} // RVA: 0x7FFD4EFEF020
        public void set_rightEyeRotation(){} // RVA: 0x7FFD4EFEC210
        public void get_fixationPoint(){} // RVA: 0x7FFD4E3A7F40
        public void set_fixationPoint(){} // RVA: 0x7FFD4E3A7F60
        public void get_leftEyeOpenAmount(){} // RVA: 0x7FFD4E349970
        public void set_leftEyeOpenAmount(){} // RVA: 0x7FFD4E349980
        public void get_rightEyeOpenAmount(){} // RVA: 0x7FFD4F9E0DE0
        public void set_rightEyeOpenAmount(){} // RVA: 0x7FFD4F9E0F70
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
        public void get_leftEyePosition(){} // RVA: 0x7FFD4E961C80
        public void set_leftEyePosition(){} // RVA: 0x7FFD4EDE8ED0
        public void get_leftEyeRotation(){} // RVA: 0x7FFD4E96E2E0
        public void set_leftEyeRotation(){} // RVA: 0x7FFD4EDC8AF0
        public void get_rightEyePosition(){} // RVA: 0x7FFD4E968F80
        public void set_rightEyePosition(){} // RVA: 0x7FFD4EDD4D10
        public void get_rightEyeRotation(){} // RVA: 0x7FFD4E969F30
        public void set_rightEyeRotation(){} // RVA: 0x7FFD4EDC7790
        public void get_fixationPoint(){} // RVA: 0x7FFD4E964330
        public void set_fixationPoint(){} // RVA: 0x7FFD4EDCC050
        public void get_leftEyeOpenAmount(){} // RVA: 0x7FFD4E9622B0
        public void set_leftEyeOpenAmount(){} // RVA: 0x7FFD4EDCD110
        public void get_rightEyeOpenAmount(){} // RVA: 0x7FFD4EDECB10
        public void set_rightEyeOpenAmount(){} // RVA: 0x7FFD4EDEF3F0
        public void FinishSetup(){} // RVA: 0x7FFD54A58B20
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD54A58F30
        public void WriteValueIntoState(){} // RVA: 0x7FFD54A59320
        public void .ctor(){} // RVA: 0x7FFD54A594C0
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
        public void get_isTracked(){} // RVA: 0x7FFD4E78D860
        public void set_isTracked(){} // RVA: 0x7FFD4EDEA130
        public void get_trackingState(){} // RVA: 0x7FFD4E96B1B0
        public void set_trackingState(){} // RVA: 0x7FFD4E923070
        public void get_position(){} // RVA: 0x7FFD4E9610C0
        public void set_position(){} // RVA: 0x7FFD4E923010
        public void get_rotation(){} // RVA: 0x7FFD4E960F60
        public void set_rotation(){} // RVA: 0x7FFD4EDCB1D0
        public void get_velocity(){} // RVA: 0x7FFD4E961C80
        public void set_velocity(){} // RVA: 0x7FFD4EDE8ED0
        public void get_angularVelocity(){} // RVA: 0x7FFD4E96E2E0
        public void set_angularVelocity(){} // RVA: 0x7FFD4EDC8AF0
        public void .ctor(){} // RVA: 0x7FFD54A52650
        public void FinishSetup(){} // RVA: 0x7FFD54A52740
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFD54A52AE0
        public void WriteValueIntoState(){} // RVA: 0x7FFD54A52D90
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFD54A52FC0
    }

    public class PoseState : ValueType
    {
        public int format;
        public UnityEngine.InputSystem.Utilities.FourCC s_Format;
        public bool isTracked; // 0x10
        public ÏÎÏÎÏÍÎÌÍÍÍÏÍÎÍÍÎÎÎÌ.ÌÏÌÎÌÎÎÌÎÎÌÌÎÎÍÌÌÏÌÍÏÍ trackingState; // 0x14
        public UnityEngine.Vector3 position; // 0x18
        public UnityEngine.Quaternion rotation; // 0x24
        public UnityEngine.Vector3 velocity; // 0x34
        public UnityEngine.Vector3 angularVelocity; // 0x40

        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFD54A52560
        public void .ctor(){} // RVA: 0x7FFD54A525C0
        public void .cctor(){} // RVA: 0x7FFD54A52610
    }

    public class TrackedPoseDriver : MonoBehaviour
    {
        public 0x664A9A08 trackingType; // 0x20
        public 0x664A9AB8 updateType; // 0x24
        public bool ignoreTrackingState; // 0x28
        public UnityEngine.InputSystem.InputActionProperty positionInput; // 0x30
        public UnityEngine.InputSystem.InputActionProperty rotationInput; // 0x48
        public UnityEngine.InputSystem.InputActionProperty trackingStateInput; // 0x60
        public UnityEngine.Vector3 positionAction; // 0x78
        public UnityEngine.Quaternion rotationAction; // 0x84
        public 0x664A9A60 m_CurrentTrackingState; // 0x94
        public bool m_RotationBound; // 0x98
        public bool m_PositionBound; // 0x99
        public bool m_TrackingStateBound; // 0x9A
        public bool m_IsFirstUpdate; // 0x9B
        public UnityEngine.InputSystem.InputAction m_PositionAction; // 0xA0
        public UnityEngine.InputSystem.InputAction m_RotationAction; // 0xA8

        // ── Methods ──
        public void get_trackingType(){} // RVA: 0x7FFD4E4FBBE0
        public void set_trackingType(){} // RVA: 0x7FFD4E9FB7A0
        public void get_updateType(){} // RVA: 0x7FFD4ED41980
        public void set_updateType(){} // RVA: 0x7FFD4F5874D0
        public void get_ignoreTrackingState(){} // RVA: 0x7FFD4E516BA0
        public void set_ignoreTrackingState(){} // RVA: 0x7FFD4F044F40
        public void get_positionInput(){} // RVA: 0x7FFD4FFC6360
        public void set_positionInput(){} // RVA: 0x7FFD54A539A0
        public void get_rotationInput(){} // RVA: 0x7FFD53F6B520
        public void set_rotationInput(){} // RVA: 0x7FFD54A53B40
        public void get_trackingStateInput(){} // RVA: 0x7FFD513F9A30
        public void set_trackingStateInput(){} // RVA: 0x7FFD54A53CE0
        public void BindActions(){} // RVA: 0x7FFD54A53E80
        public void UnbindActions(){} // RVA: 0x7FFD54A53EB0
        public void BindPosition(){} // RVA: 0x7FFD54A53EE0
        public void BindRotation(){} // RVA: 0x7FFD54A54130
        public void BindTrackingState(){} // RVA: 0x7FFD54A54380
        public void RenameAndEnable(){} // RVA: 0x7FFD54A545D0
        public void UnbindPosition(){} // RVA: 0x7FFD54A54600
        public void UnbindRotation(){} // RVA: 0x7FFD54A54800
        public void UnbindTrackingState(){} // RVA: 0x7FFD54A54A00
        public void OnPositionPerformed(){} // RVA: 0x7FFD54A54C00
        public void OnPositionCanceled(){} // RVA: 0x7FFD54A54C70
        public void OnRotationPerformed(){} // RVA: 0x7FFD54A54CC0
        public void OnRotationCanceled(){} // RVA: 0x7FFD54A54D20
        public void OnTrackingStatePerformed(){} // RVA: 0x7FFD54A54D70
        public void OnTrackingStateCanceled(){} // RVA: 0x7FFD54A54DD0
        public void Reset(){} // RVA: 0x7FFD54A54DE0
        public void Awake(){} // RVA: 0x7FFD54A55100
        public void OnEnable(){} // RVA: 0x7FFD54A551F0
        public void OnDisable(){} // RVA: 0x7FFD54A552C0
        public void OnDestroy(){} // RVA: 0x7FFD54A55380
        public void UpdateCallback(){} // RVA: 0x7FFD54A55470
        public void ReadTrackingState(){} // RVA: 0x7FFD54A55930
        public void OnUpdate(){} // RVA: 0x7FFD54A55B20
        public void OnBeforeRender(){} // RVA: 0x7FFD54A55B50
        public void PerformUpdate(){} // RVA: 0x7FFD54A55B80
        public void SetLocalTransform(){} // RVA: 0x7FFD54A55BD0
        public void HasStereoCamera(){} // RVA: 0x7FFD54A55E10
        public void HasResolvedControl(){} // RVA: 0x7FFD54A55EC0
        public void get_positionAction(){} // RVA: 0x7FFD54A55FA0
        public void set_positionAction(){} // RVA: 0x7FFD54A55FB0
        public void get_rotationAction(){} // RVA: 0x7FFD54A56180
        public void set_rotationAction(){} // RVA: 0x7FFD54A56190
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54A56360
        public void .ctor(){} // RVA: 0x7FFD54A56420
    }

    public class XRController : TrackedDevice
    {
        public object leftHand;
        public object rightHand;

        // ── Methods ──
        public void get_leftHand(){} // RVA: 0x7FFD54A535C0
        public void get_rightHand(){} // RVA: 0x7FFD54A53670
        public void FinishSetup(){} // RVA: 0x7FFD54A53720
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class XRControllerWithRumble : XRController
    {
        // ── Methods ──
        public void SendImpulse(){} // RVA: 0x7FFD54A538F0
        public void .ctor(){} // RVA: 0x7FFD54936440
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
        public void get_leftEyePosition(){} // RVA: 0x7FFD4E969F30
        public void set_leftEyePosition(){} // RVA: 0x7FFD4EDC7790
        public void get_leftEyeRotation(){} // RVA: 0x7FFD4E964330
        public void set_leftEyeRotation(){} // RVA: 0x7FFD4EDCC050
        public void get_rightEyePosition(){} // RVA: 0x7FFD4E9622B0
        public void set_rightEyePosition(){} // RVA: 0x7FFD4EDCD110
        public void get_rightEyeRotation(){} // RVA: 0x7FFD4EDECB10
        public void set_rightEyeRotation(){} // RVA: 0x7FFD4EDEF3F0
        public void get_centerEyePosition(){} // RVA: 0x7FFD4EDE1920
        public void set_centerEyePosition(){} // RVA: 0x7FFD4EDC8050
        public void get_centerEyeRotation(){} // RVA: 0x7FFD4EDE0A30
        public void set_centerEyeRotation(){} // RVA: 0x7FFD4EDEF5C0
        public void FinishSetup(){} // RVA: 0x7FFD54A53250
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class XRLayoutBuilder : Object
    {
        public string parentLayout; // 0x10
        public string interfaceName; // 0x18
        public 0x664A9D78 descriptor; // 0x20
        public string[] poseSubControlNames;
        public 0x664A9C70[] poseSubControlTypes; // 0x8

        // ── Methods ──
        public void GetSizeOfFeature(){} // RVA: 0x7FFD54A56500
        public void SanitizeString(){} // RVA: 0x7FFD54A565C0
        public void OnFindLayoutForDevice(){} // RVA: 0x7FFD54A56770
        public void ConvertPotentialAliasToName(){} // RVA: 0x7FFD54A56CB0
        public void IsSubControl(){} // RVA: 0x7FFD54A56F40
        public void GetParentControlName(){} // RVA: 0x7FFD54A56F80
        public void IsPoseControl(){} // RVA: 0x7FFD54A56FC0
        public void Build(){} // RVA: 0x7FFD54A57180
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54A582B0
    }

    public class XRSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD54A59540
    }

}