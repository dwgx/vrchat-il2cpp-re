// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR
// Classes: 16
// Methods: 149

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR
{
    public class Bone
    {
        public object leftEyePosition;
        public object leftEyeRotation;
        public object rightEyePosition;

        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7FFAF44189B0
        public void set_parentBoneIndex(){} // RVA: 0x7FFAF32E3580
        public void get_position(){} // RVA: 0x7FFAF6274F70
        public void set_position(){} // RVA: 0x7FFAF994FE40
        public void get_rotation(){} // RVA: 0x7FFAF441ABE0
        public void set_rotation(){} // RVA: 0x7FFAF441ABF0
    }

    public class BoneControl
    {
        // ── Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7FFAF2DF85F0
        public void set_parentBoneIndex(){} // RVA: 0x7FFAF2DF8600
        public void get_position(){} // RVA: 0x7FFAF2DF8660
        public void set_position(){} // RVA: 0x7FFAF2DF8670
        public void get_rotation(){} // RVA: 0x7FFAF34AE130
        public void set_rotation(){} // RVA: 0x7FFAF383E9B0
        public void FinishSetup(){} // RVA: 0x7FFAF994FEA0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF99500B0
        public void WriteValueIntoState(){} // RVA: 0x7FFAF9950290
        public void .ctor(){} // RVA: 0x7FFAF9950350
    }

    public class Eyes
    {
        public object leftHand;
        public object rightHand;

        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7FFAF4BBE270
        public void set_leftEyePosition(){} // RVA: 0x7FFAF4BBE450
        public void get_leftEyeRotation(){} // RVA: 0x7FFAF994FE50
        public void set_leftEyeRotation(){} // RVA: 0x7FFAF994FE60
        public void get_rightEyePosition(){} // RVA: 0x7FFAF994FE70
        public void set_rightEyePosition(){} // RVA: 0x7FFAF994FE90
        public void get_rightEyeRotation(){} // RVA: 0x7FFAF3BCF520
        public void set_rightEyeRotation(){} // RVA: 0x7FFAF3BCC380
        public void get_fixationPoint(){} // RVA: 0x7FFAF2DF3F40
        public void set_fixationPoint(){} // RVA: 0x7FFAF2DF3F60
        public void get_leftEyeOpenAmount(){} // RVA: 0x7FFAF2D95970
        public void set_leftEyeOpenAmount(){} // RVA: 0x7FFAF2D95980
        public void get_rightEyeOpenAmount(){} // RVA: 0x7FFAF396B900
        public void set_rightEyeOpenAmount(){} // RVA: 0x7FFAF396B7C0
    }

    public class EyesControl
    {
        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7FFAF35474D0
        public void set_leftEyePosition(){} // RVA: 0x7FFAF384C360
        public void get_leftEyeRotation(){} // RVA: 0x7FFAF3861150
        public void set_leftEyeRotation(){} // RVA: 0x7FFAF3845560
        public void get_rightEyePosition(){} // RVA: 0x7FFAF3544F10
        public void set_rightEyePosition(){} // RVA: 0x7FFAF38525E0
        public void get_rightEyeRotation(){} // RVA: 0x7FFAF3855040
        public void set_rightEyeRotation(){} // RVA: 0x7FFAF383AAB0
        public void get_fixationPoint(){} // RVA: 0x7FFAF3862150
        public void set_fixationPoint(){} // RVA: 0x7FFAF3844B20
        public void get_leftEyeOpenAmount(){} // RVA: 0x7FFAF3507F60
        public void set_leftEyeOpenAmount(){} // RVA: 0x7FFAF3844790
        public void get_rightEyeOpenAmount(){} // RVA: 0x7FFAF38562D0
        public void set_rightEyeOpenAmount(){} // RVA: 0x7FFAF3844E00
        public void FinishSetup(){} // RVA: 0x7FFAF99503D0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF99507E0
        public void WriteValueIntoState(){} // RVA: 0x7FFAF9950BD0
        public void .ctor(){} // RVA: 0x7FFAF9950D70
    }

    public class PoseControl
    {
        // ── Methods ──
        public void get_isTracked(){} // RVA: 0x7FFAF32DF060
        public void set_isTracked(){} // RVA: 0x7FFAF38370D0
        public void get_trackingState(){} // RVA: 0x7FFAF3855BB0
        public void set_trackingState(){} // RVA: 0x7FFAF3837C10
        public void get_position(){} // RVA: 0x7FFAF3833B50
        public void set_position(){} // RVA: 0x7FFAF384F550
        public void get_rotation(){} // RVA: 0x7FFAF3540180
        public void set_rotation(){} // RVA: 0x7FFAF3846D90
        public void get_velocity(){} // RVA: 0x7FFAF35474D0
        public void set_velocity(){} // RVA: 0x7FFAF384C360
        public void get_angularVelocity(){} // RVA: 0x7FFAF3861150
        public void set_angularVelocity(){} // RVA: 0x7FFAF3845560
        public void .ctor(){} // RVA: 0x7FFAF9949F00
        public void FinishSetup(){} // RVA: 0x7FFAF9949FF0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7FFAF994A390
        public void WriteValueIntoState(){} // RVA: 0x7FFAF994A640
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7FFAF994A870
    }

    public class PoseState
    {
        // ── Methods ──
        public void get_format(){} // RVA: 0x7FFAF9949E10
        public void .ctor(){} // RVA: 0x7FFAF9949E70
        public void .cctor(){} // RVA: 0x7FFAF9949EC0
    }

    public class TrackedPoseDriver
    {
        // ── Methods ──
        public void get_trackingType(){} // RVA: 0x7FFAF3210030
        public void set_trackingType(){} // RVA: 0x7FFAF344E0D0
        public void get_updateType(){} // RVA: 0x7FFAF379F5B0
        public void set_updateType(){} // RVA: 0x7FFAF4191F00
        public void get_ignoreTrackingState(){} // RVA: 0x7FFAF3198A80
        public void set_ignoreTrackingState(){} // RVA: 0x7FFAF3198B80
        public void get_positionInput(){} // RVA: 0x7FFAF4B2FEE0
        public void set_positionInput(){} // RVA: 0x7FFAF994B250
        public void get_rotationInput(){} // RVA: 0x7FFAF8E64160
        public void set_rotationInput(){} // RVA: 0x7FFAF994B3F0
        public void get_trackingStateInput(){} // RVA: 0x7FFAF615CED0
        public void set_trackingStateInput(){} // RVA: 0x7FFAF994B590
        public void BindActions(){} // RVA: 0x7FFAF994B730
        public void UnbindActions(){} // RVA: 0x7FFAF994B760
        public void BindPosition(){} // RVA: 0x7FFAF994B790
        public void BindRotation(){} // RVA: 0x7FFAF994B9E0
        public void BindTrackingState(){} // RVA: 0x7FFAF994BC30
        public void RenameAndEnable(){} // RVA: 0x7FFAF994BE80
        public void UnbindPosition(){} // RVA: 0x7FFAF994BEB0
        public void UnbindRotation(){} // RVA: 0x7FFAF994C0B0
        public void UnbindTrackingState(){} // RVA: 0x7FFAF994C2B0
        public void OnPositionPerformed(){} // RVA: 0x7FFAF994C4B0
        public void OnPositionCanceled(){} // RVA: 0x7FFAF994C520
        public void OnRotationPerformed(){} // RVA: 0x7FFAF994C570
        public void OnRotationCanceled(){} // RVA: 0x7FFAF994C5D0
        public void OnTrackingStatePerformed(){} // RVA: 0x7FFAF994C620
        public void OnTrackingStateCanceled(){} // RVA: 0x7FFAF994C680
        public void Reset(){} // RVA: 0x7FFAF994C690
        public void Awake(){} // RVA: 0x7FFAF994C9B0
        public void OnEnable(){} // RVA: 0x7FFAF994CAA0
        public void OnDisable(){} // RVA: 0x7FFAF994CB70
        public void OnDestroy(){} // RVA: 0x7FFAF994CC30
        public void UpdateCallback(){} // RVA: 0x7FFAF994CD20
        public void ReadTrackingState(){} // RVA: 0x7FFAF994D1E0
        public void OnUpdate(){} // RVA: 0x7FFAF994D3D0
        public void OnBeforeRender(){} // RVA: 0x7FFAF994D400
        public void PerformUpdate(){} // RVA: 0x7FFAF994D430
        public void SetLocalTransform(){} // RVA: 0x7FFAF994D480
        public void HasStereoCamera(){} // RVA: 0x7FFAF994D6C0
        public void HasResolvedControl(){} // RVA: 0x7FFAF994D770
        public void get_positionAction(){} // RVA: 0x7FFAF994D850
        public void set_positionAction(){} // RVA: 0x7FFAF994D860
        public void get_rotationAction(){} // RVA: 0x7FFAF994DA30
        public void set_rotationAction(){} // RVA: 0x7FFAF994DA40
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAF2D8D310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAF994DC10
        public void .ctor(){} // RVA: 0x7FFAF994DCD0
    }

    public class UsageHint
    {
    }

    public class XRController
    {
        // ── Methods ──
        public void get_leftHand(){} // RVA: 0x7FFAF994AE70
        public void get_rightHand(){} // RVA: 0x7FFAF994AF20
        public void FinishSetup(){} // RVA: 0x7FFAF994AFD0
        public void .ctor(){} // RVA: 0x7FFAF982DCE0
    }

    public class XRControllerWithRumble
    {
        // ── Methods ──
        public void SendImpulse(){} // RVA: 0x7FFAF994B1A0
        public void .ctor(){} // RVA: 0x7FFAF982DCE0
    }

    public class XRDeviceDescriptor
    {
        // ── Methods ──
        public void ToJson(){} // RVA: 0x7FFAF994FDF0
        public void FromJson(){} // RVA: 0x7FFAF994FE00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class XRFeatureDescriptor
    {
    }

    public class XRHMD
    {
        // ── Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7FFAF3855040
        public void set_leftEyePosition(){} // RVA: 0x7FFAF383AAB0
        public void get_leftEyeRotation(){} // RVA: 0x7FFAF3862150
        public void set_leftEyeRotation(){} // RVA: 0x7FFAF3844B20
        public void get_rightEyePosition(){} // RVA: 0x7FFAF3507F60
        public void set_rightEyePosition(){} // RVA: 0x7FFAF3844790
        public void get_rightEyeRotation(){} // RVA: 0x7FFAF38562D0
        public void set_rightEyeRotation(){} // RVA: 0x7FFAF3844E00
        public void get_centerEyePosition(){} // RVA: 0x7FFAF3863D70
        public void set_centerEyePosition(){} // RVA: 0x7FFAF3836540
        public void get_centerEyeRotation(){} // RVA: 0x7FFAF384ABC0
        public void set_centerEyeRotation(){} // RVA: 0x7FFAF384A380
        public void FinishSetup(){} // RVA: 0x7FFAF994AB00
        public void .ctor(){} // RVA: 0x7FFAF982DCE0
    }

    public class XRLayoutBuilder
    {
        // ── Methods ──
        public void GetSizeOfFeature(){} // RVA: 0x7FFAF994DDB0
        public void SanitizeString(){} // RVA: 0x7FFAF994DE70
        public void OnFindLayoutForDevice(){} // RVA: 0x7FFAF994E020
        public void ConvertPotentialAliasToName(){} // RVA: 0x7FFAF994E560
        public void IsSubControl(){} // RVA: 0x7FFAF994E7F0
        public void GetParentControlName(){} // RVA: 0x7FFAF994E830
        public void IsPoseControl(){} // RVA: 0x7FFAF994E870
        public void Build(){} // RVA: 0x7FFAF994EA30
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF994FB60
    }

    public class XRSupport
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF9950DF0
    }

    public class XRUtilities
    {
    }

}