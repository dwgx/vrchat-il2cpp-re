// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR
// Classes: 13
// Methods: 149

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR
{
    public class Bone : ValueType
    {
        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x77E60
        public void set_parentBoneIndex(){} // RVA: 0x29580
        public void get_position(){} // RVA: 0x35D250
        public void set_position(){} // RVA: 0x935690
        public void get_rotation(){} // RVA: 0xD1A70
        public void set_rotation(){} // RVA: 0x9356A0
    }

    public class BoneControl : InputControl`1
    {
        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0xBAE8F0
        public void set_parentBoneIndex(){} // RVA: 0xBAE900
        public void get_position(){} // RVA: 0xBAE960
        public void set_position(){} // RVA: 0xBAE970
        public void get_rotation(){} // RVA: 0x12CDBF0
        public void set_rotation(){} // RVA: 0x164A230
        public void FinishSetup(){} // RVA: 0x78EC4A0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x78EC6B0
        public void WriteValueIntoState(){} // RVA: 0x78EC820
        public void .ctor(){} // RVA: 0x78EC8E0
    }

    public class Eyes : ValueType
    {
        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x45A5B0
        public void set_leftEyePosition(){} // RVA: 0x45A580
        public void get_leftEyeRotation(){} // RVA: 0x9356B0
        public void set_leftEyeRotation(){} // RVA: 0x9356C0
        public void get_rightEyePosition(){} // RVA: 0x9356D0
        public void set_rightEyePosition(){} // RVA: 0x9356F0
        public void get_rightEyeRotation(){} // RVA: 0x2698F0
        public void set_rightEyeRotation(){} // RVA: 0x935700
        public void get_fixationPoint(){} // RVA: 0x935710
        public void set_fixationPoint(){} // RVA: 0x935730
        public void get_leftEyeOpenAmount(){} // RVA: 0x935740
        public void set_leftEyeOpenAmount(){} // RVA: 0x935750
        public void get_rightEyeOpenAmount(){} // RVA: 0x935760
        public void set_rightEyeOpenAmount(){} // RVA: 0x935770
    }

    public class EyesControl : InputControl`1
    {
        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x135C160
        public void set_leftEyePosition(){} // RVA: 0x16614A0
        public void get_leftEyeRotation(){} // RVA: 0x1664460
        public void set_leftEyeRotation(){} // RVA: 0x16679E0
        public void get_rightEyePosition(){} // RVA: 0x135A180
        public void set_rightEyePosition(){} // RVA: 0x164D690
        public void get_rightEyeRotation(){} // RVA: 0x165E8F0
        public void set_rightEyeRotation(){} // RVA: 0x165C4D0
        public void get_fixationPoint(){} // RVA: 0x1659CB0
        public void set_fixationPoint(){} // RVA: 0x163A980
        public void get_leftEyeOpenAmount(){} // RVA: 0x1344890
        public void set_leftEyeOpenAmount(){} // RVA: 0x1662780
        public void get_rightEyeOpenAmount(){} // RVA: 0x1655DD0
        public void set_rightEyeOpenAmount(){} // RVA: 0x16694D0
        public void FinishSetup(){} // RVA: 0x78EC960
        public void ReadUnprocessedValueFromState(){} // RVA: 0x78ECD70
        public void WriteValueIntoState(){} // RVA: 0x78ECFF0
        public void .ctor(){} // RVA: 0x78ED190
    }

    public class PoseControl : InputControl`1
    {
        // ── Methods ──
        public void get_isTracked(){} // RVA: 0x10F9390
        public void set_isTracked(){} // RVA: 0x165AF80
        public void get_trackingState(){} // RVA: 0x165EBC0
        public void set_trackingState(){} // RVA: 0x1651590
        public void get_position(){} // RVA: 0x1667D40
        public void set_position(){} // RVA: 0x1669D30
        public void get_rotation(){} // RVA: 0x13659D0
        public void set_rotation(){} // RVA: 0x166D270
        public void get_velocity(){} // RVA: 0x135C160
        public void set_velocity(){} // RVA: 0x16614A0
        public void get_angularVelocity(){} // RVA: 0x1664460
        public void set_angularVelocity(){} // RVA: 0x16679E0
        public void .ctor(){} // RVA: 0x78E64A0
        public void FinishSetup(){} // RVA: 0x78E6590
        public void ReadUnprocessedValueFromState(){} // RVA: 0x78E6930
        public void WriteValueIntoState(){} // RVA: 0x78E6BE0
        public void CalculateOptimizedControlDataType(){} // RVA: 0x78E6E10
    }

    public class PoseState : ValueType
    {
        // ── Methods ──
        public void get_format(){} // RVA: 0x935520
        public void .ctor(){} // RVA: 0x935580
        public void .cctor(){} // RVA: 0x78E6460
    }

    public class TrackedPoseDriver : MonoBehaviour
    {
        // ── Methods ──
        public void get_trackingType(){} // RVA: 0xFEAE90
        public void set_trackingType(){} // RVA: 0x1269760
        public void get_updateType(){} // RVA: 0x15AF000
        public void set_updateType(){} // RVA: 0x1FAA840
        public void get_ignoreTrackingState(){} // RVA: 0xF73960
        public void set_ignoreTrackingState(){} // RVA: 0xF73A60
        public void get_positionInput(){} // RVA: 0x290A7C0
        public void set_positionInput(){} // RVA: 0x78E77F0
        public void get_rotationInput(){} // RVA: 0x6E21FD0
        public void set_rotationInput(){} // RVA: 0x78E7960
        public void get_trackingStateInput(){} // RVA: 0x4128C30
        public void set_trackingStateInput(){} // RVA: 0x78E7AD0
        public void BindActions(){} // RVA: 0x78E7C40
        public void UnbindActions(){} // RVA: 0x78E7C70
        public void BindPosition(){} // RVA: 0x78E7CA0
        public void BindRotation(){} // RVA: 0x78E7EF0
        public void BindTrackingState(){} // RVA: 0x78E8140
        public void RenameAndEnable(){} // RVA: 0x78E8390
        public void UnbindPosition(){} // RVA: 0x78E83C0
        public void UnbindRotation(){} // RVA: 0x78E85C0
        public void UnbindTrackingState(){} // RVA: 0x78E87C0
        public void OnPositionPerformed(){} // RVA: 0x78E89C0
        public void OnPositionCanceled(){} // RVA: 0x78E8A30
        public void OnRotationPerformed(){} // RVA: 0x78E8A80
        public void OnRotationCanceled(){} // RVA: 0x78E8AE0
        public void OnTrackingStatePerformed(){} // RVA: 0x78E8B30
        public void OnTrackingStateCanceled(){} // RVA: 0x78E8B90
        public void Reset(){} // RVA: 0x78E8BA0
        public void Awake(){} // RVA: 0x78E8EC0
        public void OnEnable(){} // RVA: 0x78E9070
        public void OnDisable(){} // RVA: 0x78E9140
        public void OnDestroy(){} // RVA: 0x78E9200
        public void UpdateCallback(){} // RVA: 0x78E93B0
        public void ReadTrackingState(){} // RVA: 0x78E9870
        public void OnUpdate(){} // RVA: 0x78E9A60
        public void OnBeforeRender(){} // RVA: 0x78E9A90
        public void PerformUpdate(){} // RVA: 0x78E9AC0
        public void SetLocalTransform(){} // RVA: 0x78E9B10
        public void HasStereoCamera(){} // RVA: 0x78E9DD0
        public void HasResolvedControl(){} // RVA: 0x78E9E50
        public void get_positionAction(){} // RVA: 0x78E9F30
        public void set_positionAction(){} // RVA: 0x78E9F40
        public void get_rotationAction(){} // RVA: 0x78EA0D0
        public void set_rotationAction(){} // RVA: 0x78EA0E0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x78EA270
        public void .ctor(){} // RVA: 0x78EA330
    }

    public class XRController : TrackedDevice
    {
        // ── Methods ──
        public void get_leftHand(){} // RVA: 0x78E7410
        public void get_rightHand(){} // RVA: 0x78E74C0
        public void FinishSetup(){} // RVA: 0x78E7570
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class XRControllerWithRumble : XRController
    {
        // ── Methods ──
        public void SendImpulse(){} // RVA: 0x78E7740
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class XRDeviceDescriptor : Object
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x78EC3F0
        public void FromJson(){} // RVA: 0x78EC400
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XRHMD : TrackedDevice
    {
        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x165E8F0
        public void set_leftEyePosition(){} // RVA: 0x165C4D0
        public void get_leftEyeRotation(){} // RVA: 0x1659CB0
        public void set_leftEyeRotation(){} // RVA: 0x163A980
        public void get_rightEyePosition(){} // RVA: 0x1344890
        public void set_rightEyePosition(){} // RVA: 0x1662780
        public void get_rightEyeRotation(){} // RVA: 0x1655DD0
        public void set_rightEyeRotation(){} // RVA: 0x16694D0
        public void get_centerEyePosition(){} // RVA: 0x1654670
        public void set_centerEyePosition(){} // RVA: 0x16612E0
        public void get_centerEyeRotation(){} // RVA: 0x165AD10
        public void set_centerEyeRotation(){} // RVA: 0x1667130
        public void FinishSetup(){} // RVA: 0x78E70A0
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class XRLayoutBuilder : Object
    {
        // ── Methods ──
        public void GetSizeOfFeature(){} // RVA: 0x78EA410
        public void SanitizeString(){} // RVA: 0x78EA4D0
        public void OnFindLayoutForDevice(){} // RVA: 0x78EA670
        public void ConvertPotentialAliasToName(){} // RVA: 0x78EABB0
        public void IsSubControl(){} // RVA: 0x78EAE20
        public void GetParentControlName(){} // RVA: 0x78EAE60
        public void IsPoseControl(){} // RVA: 0x78EAEA0
        public void Build(){} // RVA: 0x78EB060
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x78EC160
    }

    public class XRSupport : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x78ED210
    }

}