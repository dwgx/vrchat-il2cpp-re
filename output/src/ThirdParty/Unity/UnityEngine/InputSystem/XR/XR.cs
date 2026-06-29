// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR
// Classes: 13
// Methods: 151

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR
{
    public class Bone : ValueType
    {
        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7A765F070
        public void set_parentBoneIndex(){} // RVA: 0x7A76134D0
        public void get_position(){} // RVA: 0x7A7908AD0
        public void set_position(){} // RVA: 0x7A7EB3C60
        public void get_rotation(){} // RVA: 0x7A76B8870
        public void set_rotation(){} // RVA: 0x7A7EB3C70
    }

    public class BoneControl : InputControl`1
    {
        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7A8142BC0
        public void set_parentBoneIndex(){} // RVA: 0x7A8142BD0
        public void get_position(){} // RVA: 0x7A8142C30
        public void set_position(){} // RVA: 0x7A8142C40
        public void get_rotation(){} // RVA: 0x7A87BB380
        public void set_rotation(){} // RVA: 0x7A8B52120
        public void FinishSetup(){} // RVA: 0x7AEC7E6B0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEC7E8C0
        public void WriteValueIntoState(){} // RVA: 0x7AEC7EA30
        public void .ctor(){} // RVA: 0x7AEC7EAF0
    }

    public class Eyes : ValueType
    {
        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7A79F03E0
        public void set_leftEyePosition(){} // RVA: 0x7A79F03B0
        public void get_leftEyeRotation(){} // RVA: 0x7A7EB3C80
        public void set_leftEyeRotation(){} // RVA: 0x7A7EB3C90
        public void get_rightEyePosition(){} // RVA: 0x7A7EB3CA0
        public void set_rightEyePosition(){} // RVA: 0x7A7EB3CC0
        public void get_rightEyeRotation(){} // RVA: 0x7A7827F80
        public void set_rightEyeRotation(){} // RVA: 0x7A7EB3CD0
        public void get_fixationPoint(){} // RVA: 0x7A7EB3CE0
        public void set_fixationPoint(){} // RVA: 0x7A7EB3D00
        public void get_leftEyeOpenAmount(){} // RVA: 0x7A7EB3D10
        public void set_leftEyeOpenAmount(){} // RVA: 0x7A7EB3D20
        public void get_rightEyeOpenAmount(){} // RVA: 0x7A7EB3D30
        public void set_rightEyeOpenAmount(){} // RVA: 0x7A7EB3D40
    }

    public class EyesControl : InputControl`1
    {
        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7A8855020
        public void set_leftEyePosition(){} // RVA: 0x7A8B60460
        public void get_leftEyeRotation(){} // RVA: 0x7A8B76160
        public void set_leftEyeRotation(){} // RVA: 0x7A8B592F0
        public void get_rightEyePosition(){} // RVA: 0x7A8852B30
        public void set_rightEyePosition(){} // RVA: 0x7A8B66E80
        public void get_rightEyeRotation(){} // RVA: 0x7A8B69B70
        public void set_rightEyeRotation(){} // RVA: 0x7A8B4DC50
        public void get_fixationPoint(){} // RVA: 0x7A8B772D0
        public void set_fixationPoint(){} // RVA: 0x7A8B58850
        public void get_leftEyeOpenAmount(){} // RVA: 0x7A8815B70
        public void set_leftEyeOpenAmount(){} // RVA: 0x7A8B58420
        public void get_rightEyeOpenAmount(){} // RVA: 0x7A8B6AFA0
        public void set_rightEyeOpenAmount(){} // RVA: 0x7A8B58B30
        public void FinishSetup(){} // RVA: 0x7AEC7EB70
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEC7EF80
        public void WriteValueIntoState(){} // RVA: 0x7AEC7F200
        public void .ctor(){} // RVA: 0x7AEC7F3A0
    }

    public class PoseControl : InputControl`1
    {
        // ── Methods ──
        public void get_isTracked(){} // RVA: 0x7A85EBF70
        public void set_isTracked(){} // RVA: 0x7A8B4A0C0
        public void get_trackingState(){} // RVA: 0x7A8B6A790
        public void set_trackingState(){} // RVA: 0x7A8B4AC60
        public void get_position(){} // RVA: 0x7A8B46B20
        public void set_position(){} // RVA: 0x7A8B639C0
        public void get_rotation(){} // RVA: 0x7A884DD70
        public void set_rotation(){} // RVA: 0x7A8B5ADA0
        public void get_velocity(){} // RVA: 0x7A8855020
        public void set_velocity(){} // RVA: 0x7A8B60460
        public void get_angularVelocity(){} // RVA: 0x7A8B76160
        public void set_angularVelocity(){} // RVA: 0x7A8B592F0
        public void .ctor(){} // RVA: 0x7AEC78750
        public void FinishSetup(){} // RVA: 0x7AEC78840
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7AEC78BE0
        public void WriteValueIntoState(){} // RVA: 0x7AEC78E90
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7AEC790C0
        public void <isTracked>k__BackingField(){} // RVA: 0x7B3F4F498
    }

    public class PoseState : ValueType
    {
        // ── Methods ──
        public void get_format(){} // RVA: 0x7A7EB3B90
        public void .ctor(){} // RVA: 0x7A7EB3BF0
        public void .cctor(){} // RVA: 0x7AEC78710
    }

    public class TrackedPoseDriver : MonoBehaviour
    {
        // ── Methods ──
        public void get_trackingType(){} // RVA: 0x7A851DB90
        public void set_trackingType(){} // RVA: 0x7A8738180
        public void get_updateType(){} // RVA: 0x7A8AB15F0
        public void set_updateType(){} // RVA: 0x7A94794D0
        public void get_ignoreTrackingState(){} // RVA: 0x7A84A5BD0
        public void set_ignoreTrackingState(){} // RVA: 0x7A84A5CD0
        public void get_positionInput(){} // RVA: 0x7A9E93B00
        public void set_positionInput(){} // RVA: 0x7AEC79AA0
        public void get_rotationInput(){} // RVA: 0x7AE1A0F00
        public void set_rotationInput(){} // RVA: 0x7AEC79C40
        public void get_trackingStateInput(){} // RVA: 0x7AB492260
        public void set_trackingStateInput(){} // RVA: 0x7AEC79DE0
        public void BindActions(){} // RVA: 0x7AEC79F80
        public void UnbindActions(){} // RVA: 0x7AEC79FB0
        public void BindPosition(){} // RVA: 0x7AEC79FE0
        public void BindRotation(){} // RVA: 0x7AEC7A230
        public void BindTrackingState(){} // RVA: 0x7AEC7A480
        public void RenameAndEnable(){} // RVA: 0x7AEC7A6D0
        public void UnbindPosition(){} // RVA: 0x7AEC7A700
        public void UnbindRotation(){} // RVA: 0x7AEC7A900
        public void UnbindTrackingState(){} // RVA: 0x7AEC7AB00
        public void OnPositionPerformed(){} // RVA: 0x7AEC7AD00
        public void OnPositionCanceled(){} // RVA: 0x7AEC7AD70
        public void OnRotationPerformed(){} // RVA: 0x7AEC7ADC0
        public void OnRotationCanceled(){} // RVA: 0x7AEC7AE20
        public void OnTrackingStatePerformed(){} // RVA: 0x7AEC7AE70
        public void OnTrackingStateCanceled(){} // RVA: 0x7AEC7AED0
        public void Reset(){} // RVA: 0x7AEC7AEE0
        public void Awake(){} // RVA: 0x7AEC7B200
        public void OnEnable(){} // RVA: 0x7AEC7B2F0
        public void OnDisable(){} // RVA: 0x7AEC7B3C0
        public void OnDestroy(){} // RVA: 0x7AEC7B480
        public void UpdateCallback(){} // RVA: 0x7AEC7B570
        public void ReadTrackingState(){} // RVA: 0x7AEC7BA20
        public void OnUpdate(){} // RVA: 0x7AEC7BC10
        public void OnBeforeRender(){} // RVA: 0x7AEC7BC40
        public void PerformUpdate(){} // RVA: 0x7AEC7BC70
        public void SetLocalTransform(){} // RVA: 0x7AEC7BCC0
        public void HasStereoCamera(){} // RVA: 0x7AEC7BF00
        public void HasResolvedControl(){} // RVA: 0x7AEC7BFB0
        public void get_positionAction(){} // RVA: 0x7AEC7C090
        public void set_positionAction(){} // RVA: 0x7AEC7C0A0
        public void get_rotationAction(){} // RVA: 0x7AEC7C270
        public void set_rotationAction(){} // RVA: 0x7AEC7C280
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AEC7C450
        public void .ctor(){} // RVA: 0x7AEC7C510
    }

    public class XRController : TrackedDevice
    {
        // ── Methods ──
        public void get_leftHand(){} // RVA: 0x7AEC796C0
        public void get_rightHand(){} // RVA: 0x7AEC79770
        public void FinishSetup(){} // RVA: 0x7AEC79820
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class XRControllerWithRumble : XRController
    {
        // ── Methods ──
        public void SendImpulse(){} // RVA: 0x7AEC799F0
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class XRDeviceDescriptor : Object
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x7AEC7E600
        public void FromJson(){} // RVA: 0x7AEC7E610
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XRHMD : TrackedDevice
    {
        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7A8B69B70
        public void set_leftEyePosition(){} // RVA: 0x7A8B4DC50
        public void get_leftEyeRotation(){} // RVA: 0x7A8B772D0
        public void set_leftEyeRotation(){} // RVA: 0x7A8B58850
        public void get_rightEyePosition(){} // RVA: 0x7A8815B70
        public void set_rightEyePosition(){} // RVA: 0x7A8B58420
        public void get_rightEyeRotation(){} // RVA: 0x7A8B6AFA0
        public void set_rightEyeRotation(){} // RVA: 0x7A8B58B30
        public void get_centerEyePosition(){} // RVA: 0x7A8B79060
        public void set_centerEyePosition(){} // RVA: 0x7A8B49820
        public void get_centerEyeRotation(){} // RVA: 0x7A8B5ED30
        public void set_centerEyeRotation(){} // RVA: 0x7A8B5E380
        public void FinishSetup(){} // RVA: 0x7AEC79350
        public void .ctor(){} // RVA: 0x7AEB6BB90
        public void <leftEyePosition>k__BackingField(){} // RVA: 0x7B4177678
    }

    public class XRLayoutBuilder : Object
    {
        // ── Methods ──
        public void GetSizeOfFeature(){} // RVA: 0x7AEC7C5F0
        public void SanitizeString(){} // RVA: 0x7AEC7C6B0
        public void OnFindLayoutForDevice(){} // RVA: 0x7AEC7C860
        public void ConvertPotentialAliasToName(){} // RVA: 0x7AEC7CDA0
        public void IsSubControl(){} // RVA: 0x7AEC7D030
        public void GetParentControlName(){} // RVA: 0x7AEC7D070
        public void IsPoseControl(){} // RVA: 0x7AEC7D0B0
        public void Build(){} // RVA: 0x7AEC7D270
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AEC7E370
    }

    public class XRSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AEC7F420
    }

}