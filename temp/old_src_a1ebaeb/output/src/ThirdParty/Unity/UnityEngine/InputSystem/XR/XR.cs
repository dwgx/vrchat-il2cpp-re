// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.XR
// Classes: 12
// Methods: 146

namespace ThirdParty.Unity.UnityEngine.InputSystem.XR
{
    public class Bone : ValueType
    {
        public object m_Rotation; // 0x34CA4030
        public object valueType; // 0x1700018E

        // ── Original Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7ffaa9e47550
        public void set_parentBoneIndex(){} // RVA: 0x7ffaa8d92880
        public void get_position(){} // RVA: 0x7ffaabb01d70
        public void set_position(){} // RVA: 0x7ffaaf05a570
        public void get_rotation(){} // RVA: 0x7ffaa9e49b20
        public void set_rotation(){} // RVA: 0x7ffaa9e49b30
    }

    public class BoneControl : InputControl`1
    {
        public object _rotation; // 0x34C9FCB0, was: <rotation>k__BackingField
        public object parentBoneIndex; // 0x17000338

        // ── Original Methods ──
        public void get_parentBoneIndex(){} // RVA: 0x7ffaa899d5f0
        public void set_parentBoneIndex(){} // RVA: 0x7ffaa899d600
        public void get_position(){} // RVA: 0x7ffaa899d660
        public void set_position(){} // RVA: 0x7ffaa899d670
        public void get_rotation(){} // RVA: 0x7ffaa8f6e840
        public void set_rotation(){} // RVA: 0x7ffaa93ec470
        public void FinishSetup(){} // RVA: 0x7ffaaf05a5d0
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaf05a7e0
        public void WriteValueIntoState(){} // RVA: 0x7ffaaf05a9c0
        public void .ctor(){} // RVA: 0x7ffaaf05aa80
    }

    public class Eyes : ValueType
    {
        public object m_RightEyePosition; // 0x34CA4420
        public object m_LeftEyeOpenAmount; // 0x34CA4420

        // ── Original Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7ffaaad0d480
        public void set_leftEyePosition(){} // RVA: 0x7ffaaad0d620
        public void get_leftEyeRotation(){} // RVA: 0x7ffaaf05a580
        public void set_leftEyeRotation(){} // RVA: 0x7ffaaf05a590
        public void get_rightEyePosition(){} // RVA: 0x7ffaaf05a5a0
        public void set_rightEyePosition(){} // RVA: 0x7ffaaf05a5c0
        public void get_rightEyeRotation(){} // RVA: 0x7ffaa95ffd80
        public void set_rightEyeRotation(){} // RVA: 0x7ffaa95fffc0
        public void get_fixationPoint(){} // RVA: 0x7ffaa8998f40
        public void set_fixationPoint(){} // RVA: 0x7ffaa8998f60
        public void get_leftEyeOpenAmount(){} // RVA: 0x7ffaa893a970
        public void set_leftEyeOpenAmount(){} // RVA: 0x7ffaa893a980
        public void get_rightEyeOpenAmount(){} // RVA: 0x7ffaa9fe53d0
        public void set_rightEyeOpenAmount(){} // RVA: 0x7ffaa9fe6140
    }

    public class EyesControl : InputControl`1
    {
        public object _rightEyePosition; // 0x34CA41B0, was: <rightEyePosition>k__BackingFi
        public object _leftEyeOpenAmount; // 0x34CA41B0, was: <leftEyeOpenAmount>k__BackingF

        // ── Original Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7ffaa8f75d50
        public void set_leftEyePosition(){} // RVA: 0x7ffaa94036f0
        public void get_leftEyeRotation(){} // RVA: 0x7ffaa8f74750
        public void set_leftEyeRotation(){} // RVA: 0x7ffaa93e77a0
        public void get_rightEyePosition(){} // RVA: 0x7ffaa8f6f0e0
        public void set_rightEyePosition(){} // RVA: 0x7ffaa93ff2c0
        public void get_rightEyeRotation(){} // RVA: 0x7ffaa8f6f0f0
        public void set_rightEyeRotation(){} // RVA: 0x7ffaa93d9af0
        public void get_fixationPoint(){} // RVA: 0x7ffaa8f78130
        public void set_fixationPoint(){} // RVA: 0x7ffaa93e4fb0
        public void get_leftEyeOpenAmount(){} // RVA: 0x7ffaa8f73670
        public void set_leftEyeOpenAmount(){} // RVA: 0x7ffaa93e9360
        public void get_rightEyeOpenAmount(){} // RVA: 0x7ffaa93d5320
        public void set_rightEyeOpenAmount(){} // RVA: 0x7ffaa93e3d80
        public void FinishSetup(){} // RVA: 0x7ffaaf05ab00
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaf05af10
        public void WriteValueIntoState(){} // RVA: 0x7ffaaf05b300
        public void .ctor(){} // RVA: 0x7ffaaf05b4a0
    }

    public class PoseControl : InputControl`1
    {
        public object _position; // 0x334665F0, was: <position>k__BackingField
        public object _angularVelocity; // 0x334665F0, was: <angularVelocity>k__BackingFie
        public object isTracked; // 0x17000318
        public object trackingState; // 0x17000319

        // ── Original Methods ──
        public void get_isTracked(){} // RVA: 0x7ffaa8d92160
        public void set_isTracked(){} // RVA: 0x7ffaa93d3040
        public void get_trackingState(){} // RVA: 0x7ffaa8f74160
        public void set_trackingState(){} // RVA: 0x7ffaa8f2e920
        public void get_position(){} // RVA: 0x7ffaa8f6f0b0
        public void set_position(){} // RVA: 0x7ffaa8f2e8c0
        public void get_rotation(){} // RVA: 0x7ffaa8f77bc0
        public void set_rotation(){} // RVA: 0x7ffaa93f5420
        public void get_velocity(){} // RVA: 0x7ffaa8f75d50
        public void set_velocity(){} // RVA: 0x7ffaa94036f0
        public void get_angularVelocity(){} // RVA: 0x7ffaa8f74750
        public void set_angularVelocity(){} // RVA: 0x7ffaa93e77a0
        public void .ctor(){} // RVA: 0x7ffaaf054630
        public void FinishSetup(){} // RVA: 0x7ffaaf054720
        public void ReadUnprocessedValueFromState(){} // RVA: 0x7ffaaf054ac0
        public void WriteValueIntoState(){} // RVA: 0x7ffaaf054d70
        public void CalculateOptimizedControlDataType(){} // RVA: 0x7ffaaf054fa0
    }

    public class PoseState : ValueType
    {
        public object isTracked; // 0x34C9F870
        public object rotation; // 0x34C9F870

        // ── Original Methods ──
        public void get_format(){} // RVA: 0x7ffaaf054540
        public void .ctor(){} // RVA: 0x7ffaaf0545a0
        public void .cctor(){} // RVA: 0x7ffaaf0545f0
    }

    public class TrackedPoseDriver : MonoBehaviour
    {
        public object m_IgnoreTrackingState; // 0x33AB4D10
        public object m_TrackingStateInput; // 0x33AB4D10
        public object m_CurrentTrackingState; // 0x33AB4D10
        public object m_TrackingStateBound; // 0x33AB4D10
        public object m_RotationAction; // 0x33AB4D10
        public object trackingType; // 0x17000326
        public object updateType; // 0x17000327
        public object ignoreTrackingState; // 0x17000328
        public object positionInput; // 0x17000329
        public object rotationInput; // 0x1700032A

        // ── Original Methods ──
        public void get_trackingType(){} // RVA: 0x7ffaa8aeced0
        public void set_trackingType(){} // RVA: 0x7ffaa900aa90
        public void get_updateType(){} // RVA: 0x7ffaa9349010
        public void set_updateType(){} // RVA: 0x7ffaa9b8c1b0
        public void get_ignoreTrackingState(){} // RVA: 0x7ffaa8b0edb0
        public void set_ignoreTrackingState(){} // RVA: 0x7ffaa96574d0
        public void get_positionInput(){} // RVA: 0x7ffaaa5a37b0
        public void set_positionInput(){} // RVA: 0x7ffaaf055980
        public void get_rotationInput(){} // RVA: 0x7ffaae56c720
        public void set_rotationInput(){} // RVA: 0x7ffaaf055b20
        public void get_trackingStateInput(){} // RVA: 0x7ffaab9eb1a0
        public void set_trackingStateInput(){} // RVA: 0x7ffaaf055cc0
        public void BindActions(){} // RVA: 0x7ffaaf055e60
        public void UnbindActions(){} // RVA: 0x7ffaaf055e90
        public void BindPosition(){} // RVA: 0x7ffaaf055ec0
        public void BindRotation(){} // RVA: 0x7ffaaf056110
        public void BindTrackingState(){} // RVA: 0x7ffaaf056360
        public void RenameAndEnable(){} // RVA: 0x7ffaaf0565b0
        public void UnbindPosition(){} // RVA: 0x7ffaaf0565e0
        public void UnbindRotation(){} // RVA: 0x7ffaaf0567e0
        public void UnbindTrackingState(){} // RVA: 0x7ffaaf0569e0
        public void OnPositionPerformed(){} // RVA: 0x7ffaaf056be0
        public void OnPositionCanceled(){} // RVA: 0x7ffaaf056c50
        public void OnRotationPerformed(){} // RVA: 0x7ffaaf056ca0
        public void OnRotationCanceled(){} // RVA: 0x7ffaaf056d00
        public void OnTrackingStatePerformed(){} // RVA: 0x7ffaaf056d50
        public void OnTrackingStateCanceled(){} // RVA: 0x7ffaaf056db0
        public void Reset(){} // RVA: 0x7ffaaf056dc0
        public void Awake(){} // RVA: 0x7ffaaf0570e0
        public void OnEnable(){} // RVA: 0x7ffaaf0571d0
        public void OnDisable(){} // RVA: 0x7ffaaf0572a0
        public void OnDestroy(){} // RVA: 0x7ffaaf057360
        public void UpdateCallback(){} // RVA: 0x7ffaaf057450
        public void ReadTrackingState(){} // RVA: 0x7ffaaf057910
        public void OnUpdate(){} // RVA: 0x7ffaaf057b00
        public void OnBeforeRender(){} // RVA: 0x7ffaaf057b30
        public void PerformUpdate(){} // RVA: 0x7ffaaf057b60
        public void HasStereoCamera(){} // RVA: 0x7ffaaf057df0
        public void HasResolvedControl(){} // RVA: 0x7ffaaf057ea0
        public void get_positionAction(){} // RVA: 0x7ffaaf057f80
        public void set_positionAction(){} // RVA: 0x7ffaaf057f90
        public void get_rotationAction(){} // RVA: 0x7ffaaf058160
        public void set_rotationAction(){} // RVA: 0x7ffaaf058170
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaaf058340
        public void .ctor(){} // RVA: 0x7ffaaf058400
        // ── Binary Analysis Named ──
        public void SetLocalTransform(){} // RVA: 0x7ffaaf057bb0
    }

    public class XRController : TrackedDevice
    {
        // ── Original Methods ──
        public void get_leftHand(){} // RVA: 0x7ffaaf0555a0
        public void get_rightHand(){} // RVA: 0x7ffaaf055650
        public void FinishSetup(){} // RVA: 0x7ffaaf055700
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class XRControllerWithRumble : XRController
    {
        // ── Original Methods ──
        public void SendImpulse(){} // RVA: 0x7ffaaf0558d0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class XRHMD : TrackedDevice
    {
        public object _rightEyePosition; // 0x334552F0, was: <rightEyePosition>k__BackingFi
        public object _centerEyeRotation; // 0x334552F0, was: <centerEyeRotation>k__BackingF
        public object leftEyePosition; // 0x1700031E
        public object leftEyeRotation; // 0x1700031F

        // ── Original Methods ──
        public void get_leftEyePosition(){} // RVA: 0x7ffaa8f6f0f0
        public void set_leftEyePosition(){} // RVA: 0x7ffaa93d9af0
        public void get_leftEyeRotation(){} // RVA: 0x7ffaa8f78130
        public void set_leftEyeRotation(){} // RVA: 0x7ffaa93e4fb0
        public void get_rightEyePosition(){} // RVA: 0x7ffaa8f73670
        public void set_rightEyePosition(){} // RVA: 0x7ffaa93e9360
        public void get_rightEyeRotation(){} // RVA: 0x7ffaa93d5320
        public void set_rightEyeRotation(){} // RVA: 0x7ffaa93e3d80
        public void get_centerEyePosition(){} // RVA: 0x7ffaa93d4100
        public void set_centerEyePosition(){} // RVA: 0x7ffaa93e7fd0
        public void get_centerEyeRotation(){} // RVA: 0x7ffaa93e8b10
        public void set_centerEyeRotation(){} // RVA: 0x7ffaa9400010
        public void FinishSetup(){} // RVA: 0x7ffaaf055230
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class XRLayoutBuilder : Object
    {
        public object descriptor; // 0x33C856C0

        // ── Original Methods ──
        public void SanitizeString(){} // RVA: 0x7ffaaf0585a0
        public void OnFindLayoutForDevice(){} // RVA: 0x7ffaaf058750
        public void ConvertPotentialAliasToName(){} // RVA: 0x7ffaaf058c90
        public void IsSubControl(){} // RVA: 0x7ffaaf058f20
        public void IsPoseControl(){} // RVA: 0x7ffaaf058fa0
        public void Build(){} // RVA: 0x7ffaaf059160
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaf05a290
        // ── Binary Analysis Named ──
        public void GetSizeOfFeature(){} // RVA: 0x7ffaaf0584e0
        public void GetParentControlName(){} // RVA: 0x7ffaaf058f60
    }

    public class XRSupport : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaaf05b520
    }

}