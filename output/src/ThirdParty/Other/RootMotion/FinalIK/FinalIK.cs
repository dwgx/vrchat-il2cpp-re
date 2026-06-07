// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 88
// Methods: 983

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class AimController
    {
        public object instance;

        // ── Methods ──
        public void Start(){} // RVA: 0x447580
        public void LateUpdate(){} // RVA: 0x4476B0
        public void get_pivot(){} // RVA: 0x448480
        public void ApplyMinDistance(){} // RVA: 0x448810
        public void RootRotation(){} // RVA: 0x4489D0
        public void TurnToTarget(){} // RVA: 0x4490D0
        public void .ctor(){} // RVA: 0x449170
    }

    public class AimIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void OpenSetupTutorial(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetIKSolver(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x3AAE20
    }

    public class AimPoser
    {
        // ── Methods ──
        public void GetPose(){} // RVA: 0x4493E0
        public void SetPoseActive(){} // RVA: 0x4494F0
        public void .ctor(){} // RVA: 0x449570
    }

    public class Amplifier
    {
        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x4499B0
        public void .ctor(){} // RVA: 0x2E5920
    }

    public class ArmIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetIKSolver(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x3AAF00
    }

    public class BipedIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetIKPositionWeight(){} // RVA: 0x391760
        public void GetIKRotationWeight(){} // RVA: 0x391790
        public void SetIKPositionWeight(){} // RVA: 0x3917C0
        public void SetIKRotationWeight(){} // RVA: 0x391820
        public void SetIKPosition(){} // RVA: 0x391880
        public void SetIKRotation(){} // RVA: 0x3918C0
        public void GetIKPosition(){} // RVA: 0x3918F0
        public void GetIKRotation(){} // RVA: 0x391950
        public void SetLookAtWeight(){} // RVA: 0x391990
        public void SetLookAtPosition(){} // RVA: 0x391AA0
        public void SetSpinePosition(){} // RVA: 0x391AD0
        public void SetSpineWeight(){} // RVA: 0x391B00
        public void GetGoalIK(){} // RVA: 0x391B50
        public void InitiateBipedIK(){} // RVA: 0x391BC0
        public void UpdateBipedIK(){} // RVA: 0x391BE0
        public void SetToDefaults(){} // RVA: 0x391C00
        public void FixTransforms(){} // RVA: 0x391DB0
        public void InitiateSolver(){} // RVA: 0x391E80
        public void UpdateSolver(){} // RVA: 0x3922A0
        public void LogWarning(){} // RVA: 0x3926F0
        public void .ctor(){} // RVA: 0x392760
    }

    public class BipedIKSolvers
    {
        // ── Methods ──
        public void get_limbs(){} // RVA: 0x3928E0
        public void get_ikSolvers(){} // RVA: 0x392AB0
        public void AssignReferences(){} // RVA: 0x392D40
        public void .ctor(){} // RVA: 0x392FB0
    }

    public class BodyTilt
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x44A220
        public void OnModifyOffset(){} // RVA: 0x44A330
        public void .ctor(){} // RVA: 0x44A6E0
    }

    public class CCDIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetIKSolver(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x3AAFE0
    }

    public class Constraint
    {
        // ── Methods ──
        public void get_isValid(){} // RVA: 0x3933B0
        public void UpdateConstraint(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ConstraintPosition
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x393480
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
    }

    public class ConstraintPositionOffset
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x3935F0
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_positionChanged(){} // RVA: 0x393A20
    }

    public class ConstraintRotation
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x393AF0
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
    }

    public class ConstraintRotationOffset
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x393C70
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_rotationChanged(){} // RVA: 0x3940B0
    }

    public class Constraints
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x394180
        public void Initiate(){} // RVA: 0x394250
        public void Update(){} // RVA: 0x3943B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EditorIK
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x44A740
        public void Update(){} // RVA: 0x44A860
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class FABRIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetIKSolver(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x3AB0C0
    }

    public class FABRIKChain
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x3AFB50
        public void Initiate(){} // RVA: 0x3AFCE0
        public void Stage1(){} // RVA: 0x3AFD40
        public void Stage2(){} // RVA: 0x3AFF10
        public void GetCentroid(){} // RVA: 0x3B0150
        public void .ctor(){} // RVA: 0x3B0410
    }

    public class FABRIKRoot
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetIKSolver(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x3AB1A0
    }

    public class FBBIKArmBending
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x3B04B0
        public void OnPostFBBIK(){} // RVA: 0x3B0FB0
        public void OnDestroy(){} // RVA: 0x3B1490
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class FBBIKHeadEffector
    {
        // ── Methods ──
        public void VRCInitialize(){} // RVA: 0x3B1690
        public void VRCSetAvatarMainIK(){} // RVA: 0x3B16A0
        public void Start(){} // RVA: 0x3B16B0
        public void Initialize(){} // RVA: 0x3B16D0
        public void OnStoreDefaultLocalState(){} // RVA: 0x3B1F70
        public void OnFixTransforms(){} // RVA: 0x3B29E0
        public void OnPreRead(){} // RVA: 0x3B32D0
        public void SpineBend(){} // RVA: 0x3B41C0
        public void CCDPass(){} // RVA: 0x3B4AD0
        public void Iterate(){} // RVA: 0x3B5360
        public void OnPostUpdate(){} // RVA: 0x3B6350
        public void ChestDirection(){} // RVA: 0x3B6960
        public void PostStretching(){} // RVA: 0x3B6EA0
        public void LerpSolverPosition(){} // RVA: 0x3B74D0
        public void Solve(){} // RVA: 0x3B7670
        public void OnDestroy(){} // RVA: 0x3B77B0
        public void .ctor(){} // RVA: 0x3B7E00
    }

    public class FBIKChain
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3B8710 | overloaded x2
        public void SetNodes(){} // RVA: 0x3B8A00
        public void GetNodeIndex(){} // RVA: 0x3B8C50
        public void IsValid(){} // RVA: 0x3B8DE0
        public void Initiate(){} // RVA: 0x3B8FA0
        public void ReadPose(){} // RVA: 0x3B9220
        public void CalculateBoneLengths(){} // RVA: 0x3B98C0
        public void Reach(){} // RVA: 0x3B9FB0
        public void Push(){} // RVA: 0x3BA310
        public void SolveTrigonometric(){} // RVA: 0x3BA700
        public void Stage1(){} // RVA: 0x3BAA70
        public void Stage2(){} // RVA: 0x3BAF50
        public void SolveConstraintSystems(){} // RVA: 0x3BB1C0
        public void SolveFABRIKJoint(){} // RVA: 0x3BB310
        public void GetDirToBendPoint(){} // RVA: 0x3BB450
        public void SolveChildConstraints(){} // RVA: 0x3BB840
        public void SolveLinearConstraint(){} // RVA: 0x3BBB90
        public void ForwardReach(){} // RVA: 0x3BBD20
        public void BackwardReach(){} // RVA: 0x3BBF50
    }

    public class Finger
    {
        // ── Methods ──
        public void get_initiated(){} // RVA: 0x394D30
        public void set_initiated(){} // RVA: 0x394D40
        public void get_IKPosition(){} // RVA: 0x394D50
        public void set_IKPosition(){} // RVA: 0x394D80
        public void get_IKRotation(){} // RVA: 0x394DB0
        public void set_IKRotation(){} // RVA: 0x394DE0
        public void IsValid(){} // RVA: 0x394E00
        public void Initiate(){} // RVA: 0x395080
        public void FixTransforms(){} // RVA: 0x396230
        public void StoreDefaultLocalState(){} // RVA: 0x396410
        public void Update(){} // RVA: 0x3965F0
        public void .ctor(){} // RVA: 0x3978D0
    }

    public class FingerRig
    {
        // ── Methods ──
        public void get_initiated(){} // RVA: 0x3978E0
        public void set_initiated(){} // RVA: 0x3978F0
        public void IsValid(){} // RVA: 0x397900
        public void AutoDetect(){} // RVA: 0x397980
        public void AddFinger(){} // RVA: 0x397E70
        public void RemoveFinger(){} // RVA: 0x3981B0
        public void AddChildrenRecursive(){} // RVA: 0x3983C0
        public void InitiateSolver(){} // RVA: 0x398520
        public void UpdateFingerSolvers(){} // RVA: 0x398620
        public void FixFingerTransforms(){} // RVA: 0x398690
        public void StoreDefaultLocalState(){} // RVA: 0x3988E0
        public void UpdateSolver(){} // RVA: 0x398620
        public void FixTransforms(){} // RVA: 0x398B10
        public void .ctor(){} // RVA: 0x398B30
    }

    public class FullBodyBipedIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void OpenSetupTutorial(){} // RVA: 0x2DD310
        public void OpenInspectorTutorial(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void SetReferences(){} // RVA: 0x3AB310
        public void GetIKSolver(){} // RVA: 0x37E0E0
        public void ReferencesError(){} // RVA: 0x3AB380
        public void ReferencesWarning(){} // RVA: 0x3AB7D0
        public void Reinitiate(){} // RVA: 0x3ABF70
        public void AutoDetectReferences(){} // RVA: 0x3ABFA0
        public void VRCSetAvatarMainIK(){} // RVA: 0x398C10
        public void VRCInitiateSolver(){} // RVA: 0x3AC150
        public void InitiateSolver(){} // RVA: 0x3AC160
        public void .ctor(){} // RVA: 0x3AC170
    }

    public class GenericPoser
    {
        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x43C2B0
        public void InitiatePoser(){} // RVA: 0x43C840
        public void UpdatePoser(){} // RVA: 0x43C850
        public void FixPoserTransforms(){} // RVA: 0x43C9C0
        public void StoreDefaultState(){} // RVA: 0x43CB20
        public void GetTargetNamed(){} // RVA: 0x43CC90
        public void .ctor(){} // RVA: 0x43CD50
    }

    public class Grounder
    {
        // ── Methods ──
        public void ResetPosition(){} // RVA: 0x24A50
        public void get_initiated(){} // RVA: 0x398C00
        public void set_initiated(){} // RVA: 0x398C10
        public void GetSpineOffsetTarget(){} // RVA: 0x398C20
        public void LogWarning(){} // RVA: 0x3926F0
        public void GetLegSpineBendVector(){} // RVA: 0x398D60
        public void GetLegSpineTangent(){} // RVA: 0x398FB0
        public void OpenUserManual(){} // RVA: 0x24A50
        public void OpenScriptReference(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x399260
    }

    public class GrounderBipedIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void ResetPosition(){} // RVA: 0x399380
        public void IsReadyToInitiate(){} // RVA: 0x3993F0
        public void Update(){} // RVA: 0x399510
        public void Initiate(){} // RVA: 0x399660
        public void OnDisable(){} // RVA: 0x399BF0
        public void OnSolverUpdate(){} // RVA: 0x399C50
        public void SetLegIK(){} // RVA: 0x39A770
        public void OnPostSolverUpdate(){} // RVA: 0x39A890
        public void OnDestroy(){} // RVA: 0x39ACE0
        public void .ctor(){} // RVA: 0x39B020
    }

    public class GrounderFBBIK
    {
        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0x2DD310
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void ResetPosition(){} // RVA: 0x39B150
        public void IsReadyToInitiate(){} // RVA: 0x39B1C0
        public void Update(){} // RVA: 0x39B2C0
        public void FixedUpdate(){} // RVA: 0x39B400
        public void LateUpdate(){} // RVA: 0x39B400
        public void Initiate(){} // RVA: 0x39B410
        public void OnSolverUpdate(){} // RVA: 0x39B7D0
        public void SetLegIK(){} // RVA: 0x39BD90
        public void OnDrawGizmosSelected(){} // RVA: 0x39C180
        public void OnDestroy(){} // RVA: 0x39C4D0
        public void .ctor(){} // RVA: 0x39C6D0
    }

    public class GrounderIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void ResetPosition(){} // RVA: 0x39C810
        public void IsReadyToInitiate(){} // RVA: 0x39C830
        public void OnDisable(){} // RVA: 0x39CB10
        public void Update(){} // RVA: 0x39CC80
        public void Initiate(){} // RVA: 0x39D6C0
        public void OnSolverUpdate(){} // RVA: 0x39DFD0
        public void SetLegIK(){} // RVA: 0x39E520
        public void OnPostSolverUpdate(){} // RVA: 0x39EAD0
        public void OnDestroy(){} // RVA: 0x39EF30
        public void .ctor(){} // RVA: 0x39F230
    }

    public class GrounderQuadruped
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void ResetPosition(){} // RVA: 0x39F350
        public void IsReadyToInitiate(){} // RVA: 0x39F390
        public void IsReadyToInitiateLegs(){} // RVA: 0x39F610
        public void OnDisable(){} // RVA: 0x39F850
        public void Update(){} // RVA: 0x39F8D0
        public void Initiate(){} // RVA: 0x39F940
        public void InitiateFeet(){} // RVA: 0x3A00C0
        public void LateUpdate(){} // RVA: 0x3A0790
        public void RootRotation(){} // RVA: 0x3A08A0
        public void OnSolverUpdate(){} // RVA: 0x3A1320
        public void UpdateForefeetRoot(){} // RVA: 0x3A2400
        public void SetFootIK(){} // RVA: 0x3A2950
        public void OnPostSolverUpdate(){} // RVA: 0x3A2B40
        public void OnDestroy(){} // RVA: 0x3A32E0
        public void DestroyLegs(){} // RVA: 0x3A3320
        public void .ctor(){} // RVA: 0x3A3610
    }

    public class GrounderVRIK
    {
        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0x2DD310
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void ResetPosition(){} // RVA: 0x39C810
        public void IsReadyToInitiate(){} // RVA: 0x3A3C20
        public void Update(){} // RVA: 0x3A3D20
        public void Initiate(){} // RVA: 0x3A3E50
        public void OnSolverUpdate(){} // RVA: 0x3A4230
        public void SetLegIK(){} // RVA: 0x3A46D0
        public void OnPostSolverUpdate(){} // RVA: 0x3A4800
        public void OnDrawGizmosSelected(){} // RVA: 0x3A4DF0
        public void OnDestroy(){} // RVA: 0x3A5140
        public void .ctor(){} // RVA: 0x3A5470
    }

    public class Grounding
    {
        // ── Methods ──
        public void get_legs(){} // RVA: 0x3A5500
        public void set_legs(){} // RVA: 0x3A5510
        public void get_pelvis(){} // RVA: 0x37B370
        public void set_pelvis(){} // RVA: 0x37B380
        public void get_isGrounded(){} // RVA: 0x3A5570
        public void set_isGrounded(){} // RVA: 0x3A5580
        public void get_root(){} // RVA: 0x3A5590
        public void set_root(){} // RVA: 0x3A55A0
        public void get_rootHit(){} // RVA: 0x3A5600
        public void set_rootHit(){} // RVA: 0x3A5630
        public void get_rootGrounded(){} // RVA: 0x3A5660
        public void GetRootHit(){} // RVA: 0x3A5680
        public void IsValid(){} // RVA: 0x3A5C90
        public void Initiate(){} // RVA: 0x3A5EF0
        public void Update(){} // RVA: 0x3A64A0
        public void GetLegsPlaneNormal(){} // RVA: 0x3A6730
        public void Reset(){} // RVA: 0x3A6C10
        public void LogWarning(){} // RVA: 0x3A6FF0
        public void get_up(){} // RVA: 0x3A7010
        public void GetVerticalOffset(){} // RVA: 0x3A70A0
        public void Flatten(){} // RVA: 0x3A7290
        public void get_useRootRotation(){} // RVA: 0x3A73D0
        public void GetFootCenterOffset(){} // RVA: 0x3A74A0
        public void .ctor(){} // RVA: 0x3A7580
    }

    public class HandPoser
    {
        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x43D290
        public void InitiatePoser(){} // RVA: 0x43D500
        public void FixPoserTransforms(){} // RVA: 0x43D5C0
        public void UpdatePoser(){} // RVA: 0x43D760
        public void StoreDefaultState(){} // RVA: 0x43DF00
        public void .ctor(){} // RVA: 0x43CD50
    }

    public class HitReaction
    {
        // ── Methods ──
        public void get_inProgress(){} // RVA: 0x44A9A0
        public void OnModifyOffset(){} // RVA: 0x44AA50
        public void Hit(){} // RVA: 0x44AB30
        public void .ctor(){} // RVA: 0x2E5920
    }

    public class HitReactionVRIK
    {
        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x44C3B0
        public void Hit(){} // RVA: 0x44C480
        public void .ctor(){} // RVA: 0x2E5920
    }

    public class IK
    {
        // ── Methods ──
        public void GetIKSolver(){} // RVA: 0xCD60
        public void UpdateSolver(){} // RVA: 0x3AC300
        public void InitiateSolver(){} // RVA: 0x3AC3A0
        public void FixTransforms(){} // RVA: 0x3AC450
        public void OpenUserManual(){} // RVA: 0x24A50
        public void OpenScriptReference(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x337060
    }

    public class IKConstraintBend
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x3BC920
        public void get_initiated(){} // RVA: 0x3BCCE0
        public void set_initiated(){} // RVA: 0x3BCCF0
        public void .ctor(){} // RVA: 0x3BCD60 | overloaded x2
        public void SetBones(){} // RVA: 0x3BCE00
        public void Initiate(){} // RVA: 0x3BCF00
        public void SetLimbOrientation(){} // RVA: 0x3BD940
        public void LimitBend(){} // RVA: 0x3BDBF0
        public void GetDir(){} // RVA: 0x3BE860
        public void OrthoToLimb(){} // RVA: 0x3BF490
        public void OrthoToBone1(){} // RVA: 0x3BF600
    }

    public class IKEffector
    {
        public object BuilderType;

        // ── Methods ──
        public void GetNode(){} // RVA: 0x3BF770
        public void get_isEndEffector(){} // RVA: 0x3978E0
        public void set_isEndEffector(){} // RVA: 0x3978F0
        public void PinToBone(){} // RVA: 0x3BF7D0
        public void .ctor(){} // RVA: 0x3BFC50 | overloaded x2
        public void IsValid(){} // RVA: 0x3C0050
        public void Initiate(){} // RVA: 0x3C0660
        public void ResetOffset(){} // RVA: 0x3C0C40
        public void SetToTarget(){} // RVA: 0x3C0E10
        public void OnPreSolve(){} // RVA: 0x3C0FC0
        public void OnPostWrite(){} // RVA: 0x3C1990
        public void GetPlaneRotation(){} // RVA: 0x3C19E0
        public void Update(){} // RVA: 0x3C1D60
        public void GetPosition(){} // RVA: 0x3C21C0
    }

    public class IKExecutionOrder
    {
        // ── Methods ──
        public void get_animatePhysics(){} // RVA: 0x3AC4C0
        public void Start(){} // RVA: 0x3AC5F0
        public void Update(){} // RVA: 0x3AC7B0
        public void FixedUpdate(){} // RVA: 0x3AC7E0
        public void LateUpdate(){} // RVA: 0x3AC810
        public void FixTransforms(){} // RVA: 0x3AC9A0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class IKMapping
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x3C2850
        public void Initiate(){} // RVA: 0x2DD310
        public void BoneIsValid(){} // RVA: 0x3C2860
        public void SolveFABRIKJoint(){} // RVA: 0x3BB310
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IKMappingBone
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x3C6050
        public void .ctor(){} // RVA: 0x3C6250 | overloaded x2
        public void StoreDefaultLocalState(){} // RVA: 0x3C6380
        public void FixTransforms(){} // RVA: 0x3C63A0
        public void Initiate(){} // RVA: 0x3C6420
        public void ReadPose(){} // RVA: 0x3C6580
        public void WritePose(){} // RVA: 0x3C65A0
    }

    public class IKMappingLimb
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x3C65D0
        public void GetBoneMap(){} // RVA: 0x3C6670
        public void SetLimbOrientation(){} // RVA: 0x3C67B0
        public void .ctor(){} // RVA: 0x3C7570 | overloaded x2
        public void SetBones(){} // RVA: 0x3C7800
        public void StoreDefaultLocalState(){} // RVA: 0x3C7950
        public void FixTransforms(){} // RVA: 0x3C7A60
        public void Initiate(){} // RVA: 0x3C7CA0
        public void ReadPose(){} // RVA: 0x3C8300
        public void WritePose(){} // RVA: 0x3C8380
    }

    public class IKMappingSpine
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x3C85C0
        public void .ctor(){} // RVA: 0x3C9040 | overloaded x2
        public void SetBones(){} // RVA: 0x3C9340
        public void StoreDefaultLocalState(){} // RVA: 0x3C94F0
        public void FixTransforms(){} // RVA: 0x3C9660
        public void Initiate(){} // RVA: 0x3C96F0
        public void UseFABRIK(){} // RVA: 0x3CA360
        public void ReadPose(){} // RVA: 0x3CA390
        public void WritePose(){} // RVA: 0x3CA7D0
        public void ForwardReach(){} // RVA: 0x3CACF0
        public void BackwardReach(){} // RVA: 0x3CAF30
        public void MapToSolverPositions(){} // RVA: 0x3CB160
    }

    public class IKSolver
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0xDE40 | overloaded x2
        public void Initiate(){} // RVA: 0x3CB730
        public void Update(){} // RVA: 0x3CB920
        public void GetIKPosition(){} // RVA: 0x2FA8D0
        public void SetIKPosition(){} // RVA: 0x2FA8F0
        public void GetIKPositionWeight(){} // RVA: 0x3AA570
        public void SetIKPositionWeight(){} // RVA: 0x3CB9A0
        public void GetRoot(){} // RVA: 0x37E0E0
        public void get_initiated(){} // RVA: 0x3CB9D0
        public void set_initiated(){} // RVA: 0x3CB9E0
        public void GetPoints(){} // RVA: 0xCD60
        public void GetPoint(){} // RVA: 0xCE10
        public void FixTransforms(){} // RVA: 0x24A50
        public void StoreDefaultLocalState(){} // RVA: 0x24A50
        public void OnInitiate(){} // RVA: 0x24A50
        public void OnUpdate(){} // RVA: 0x24A50
        public void LogWarning(){} // RVA: 0x3CB9F0
        public void ContainsDuplicateBone(){} // RVA: 0x3CBAA0
        public void HierarchyIsValid(){} // RVA: 0x3CBC70
        public void PreSolveBones(){} // RVA: 0x3CBD00
        public void .ctor(){} // RVA: 0x3CC1A0
    }

    public class IKSolverAim
    {
        // ── Methods ──
        public void GetAngle(){} // RVA: 0x3CE4C0
        public void get_transformAxis(){} // RVA: 0x3CE5D0
        public void get_transformPoleAxis(){} // RVA: 0x3CE840
        public void OnInitiate(){} // RVA: 0x3CEAB0
        public void OnUpdate(){} // RVA: 0x3CEF90
        public void get_minBones(){} // RVA: 0x3CFAF0
        public void Solve(){} // RVA: 0x3CFB00
        public void GetClampedIKPosition(){} // RVA: 0x3CFC50
        public void RotateToTarget(){} // RVA: 0x3D01D0
        public void get_localDirection(){} // RVA: 0x3D1080
        public void .ctor(){} // RVA: 0x3D1190
    }

    public class IKSolverArm
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x3D1250
        public void SetChain(){} // RVA: 0x3D1940
        public void GetPoints(){} // RVA: 0x3D1B60
        public void GetPoint(){} // RVA: 0x3D1D10
        public void StoreDefaultLocalState(){} // RVA: 0x3D2260
        public void FixTransforms(){} // RVA: 0x3D22C0
        public void OnInitiate(){} // RVA: 0x3D2330
        public void OnUpdate(){} // RVA: 0x3D2450
        public void Solve(){} // RVA: 0x3D24F0
        public void Read(){} // RVA: 0x3D2580
        public void Write(){} // RVA: 0x3D2DC0
        public void .ctor(){} // RVA: 0x3D3160
    }

    public class IKSolverCCD
    {
        // ── Methods ──
        public void FadeOutBoneWeights(){} // RVA: 0x3D3690
        public void OnInitiate(){} // RVA: 0x3D3730
        public void OnUpdate(){} // RVA: 0x3D3880
        public void Solve(){} // RVA: 0x3D3D80
        public void .ctor(){} // RVA: 0x3D4C30
    }

    public class IKSolverFABRIK
    {
        // ── Methods ──
        public void SolveForward(){} // RVA: 0x3D4C40
        public void SolveBackward(){} // RVA: 0x3D4CF0
        public void GetIKPosition(){} // RVA: 0x3D4DC0
        public void OnInitiate(){} // RVA: 0x3D4F20
        public void OnUpdate(){} // RVA: 0x3D56A0
        public void get_boneLengthCanBeZero(){} // RVA: 0x2DD320
        public void SolveJoint(){} // RVA: 0x3D5B80
        public void OnPreSolve(){} // RVA: 0x3D5CD0
        public void OnPostSolve(){} // RVA: 0x3D6420
        public void Solve(){} // RVA: 0x3D6600
        public void ForwardReach(){} // RVA: 0x3D6700
        public void SolverMove(){} // RVA: 0x3D6A70
        public void SolverRotate(){} // RVA: 0x3D6B00
        public void SolverRotateChildren(){} // RVA: 0x3D6D00
        public void SolverMoveChildrenAroundPoint(){} // RVA: 0x3D6EE0
        public void GetParentSolverRotation(){} // RVA: 0x3D71B0
        public void GetParentSolverPosition(){} // RVA: 0x3D7450
        public void GetLimitedRotation(){} // RVA: 0x3D7710
        public void LimitForward(){} // RVA: 0x3D7AD0
        public void BackwardReach(){} // RVA: 0x3D81E0
        public void BackwardReachUnlimited(){} // RVA: 0x3D8220
        public void BackwardReachLimited(){} // RVA: 0x3D8470
        public void MapToSolverPositions(){} // RVA: 0x3D9180
        public void MapToSolverPositionsLimited(){} // RVA: 0x3D9350
        public void .ctor(){} // RVA: 0x3D94F0
    }

    public class IKSolverFABRIKRoot
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x3D9610
        public void StoreDefaultLocalState(){} // RVA: 0x3D9F90
        public void FixTransforms(){} // RVA: 0x3DA0A0
        public void OnInitiate(){} // RVA: 0x3DA1A0
        public void IsRoot(){} // RVA: 0x3DA3C0
        public void OnUpdate(){} // RVA: 0x3DA470
        public void GetPoints(){} // RVA: 0x3DA6E0
        public void GetPoint(){} // RVA: 0x3DA790
        public void AddPointsToArray(){} // RVA: 0x3DA830
        public void GetCentroid(){} // RVA: 0x3DA9F0
        public void .ctor(){} // RVA: 0x3DADD0
    }

    public class IKSolverFullBody
    {
        // ── Methods ──
        public void GetEffector(){} // RVA: 0x3DAE70
        public void GetChain(){} // RVA: 0x3DB010
        public void GetChainIndex(){} // RVA: 0x3DB060
        public void GetNode(){} // RVA: 0x3DB240
        public void GetChainAndNodeIndexes(){} // RVA: 0x3DB290
        public void GetPoints(){} // RVA: 0x3DB470
        public void GetPoint(){} // RVA: 0x3DB620
        public void IsValid(){} // RVA: 0x3DB820
        public void StoreDefaultLocalState(){} // RVA: 0x3DBB00
        public void FixTransforms(){} // RVA: 0x3DBD80
        public void OnInitiate(){} // RVA: 0x3DBFA0
        public void OnUpdate(){} // RVA: 0x3DC140
        public void ReadPose(){} // RVA: 0x3DC370
        public void Solve(){} // RVA: 0x3DC890
        public void ApplyBendConstraints(){} // RVA: 0x3DCC00
        public void WritePose(){} // RVA: 0x3DCC40
        public void .ctor(){} // RVA: 0x3DCD70
    }

    public class IKSolverFullBodyBiped
    {
        // ── Methods ──
        public void get_bodyEffector(){} // RVA: 0x3DD010
        public void get_leftShoulderEffector(){} // RVA: 0x3DD040
        public void get_rightShoulderEffector(){} // RVA: 0x3DD070
        public void get_leftThighEffector(){} // RVA: 0x3DD0A0
        public void get_rightThighEffector(){} // RVA: 0x3DD0D0
        public void get_leftHandEffector(){} // RVA: 0x3DD100
        public void get_rightHandEffector(){} // RVA: 0x3DD130
        public void get_leftFootEffector(){} // RVA: 0x3DD160
        public void get_rightFootEffector(){} // RVA: 0x3DD190
        public void get_leftArmChain(){} // RVA: 0x3DD1C0
        public void get_rightArmChain(){} // RVA: 0x3DD1F0
        public void get_leftLegChain(){} // RVA: 0x3DD220
        public void get_rightLegChain(){} // RVA: 0x3DD250
        public void get_leftArmMapping(){} // RVA: 0x3DD280
        public void get_rightArmMapping(){} // RVA: 0x3DD2B0
        public void get_leftLegMapping(){} // RVA: 0x3DD2E0
        public void get_rightLegMapping(){} // RVA: 0x3DD310
        public void get_headMapping(){} // RVA: 0x3DD340
        public void SetChainWeights(){} // RVA: 0x3DD370
        public void SetEffectorWeights(){} // RVA: 0x3DD3E0
        public void GetChain(){} // RVA: 0x3DD530 | overloaded x2
        public void GetEffector(){} // RVA: 0x3DD620
        public void GetEndEffector(){} // RVA: 0x3DD780
        public void GetLimbMapping(){} // RVA: 0x3DD8B0 | overloaded x2
        public void GetSpineMapping(){} // RVA: 0x3A5590
        public void GetHeadMapping(){} // RVA: 0x3DD340
        public void GetBendConstraint(){} // RVA: 0x3DD990
        public void IsValid(){} // RVA: 0x3DDA20
        public void SetToReferences(){} // RVA: 0x3DDD30
        public void DetectRootNodeBone(){} // RVA: 0x3DFDF0
        public void SetLimbOrientations(){} // RVA: 0x3E04C0
        public void get_pullBodyOffset(){} // RVA: 0x348260
        public void set_pullBodyOffset(){} // RVA: 0x348280
        public void SetLimbOrientation(){} // RVA: 0x3E0530
        public void GetLeftClavicle(){} // RVA: 0x3E07C0
        public void GetRightClavicle(){} // RVA: 0x3E0970
        public void Contains(){} // RVA: 0x3E0B20
        public void ReadPose(){} // RVA: 0x3E0C90
        public void PullBody(){} // RVA: 0x3E1100
        public void GetBodyOffset(){} // RVA: 0x3E12E0
        public void GetHandBodyPull(){} // RVA: 0x3E15C0
        public void ApplyBendConstraints(){} // RVA: 0x3E1800
        public void WritePose(){} // RVA: 0x3E1C60
        public void .ctor(){} // RVA: 0x3E1EB0
    }

    public class IKSolverHeuristic
    {
        // ── Methods ──
        public void SetChain(){} // RVA: 0x3E1ED0
        public void AddBone(){} // RVA: 0x3E20B0
        public void StoreDefaultLocalState(){} // RVA: 0x3E2280
        public void FixTransforms(){} // RVA: 0x3E23F0
        public void IsValid(){} // RVA: 0x3E2470
        public void GetPoints(){} // RVA: 0x3A5590
        public void GetPoint(){} // RVA: 0x3E2B10
        public void get_minBones(){} // RVA: 0x3E2CB0
        public void get_boneLengthCanBeZero(){} // RVA: 0x3C2850
        public void get_allowCommonParent(){} // RVA: 0x2DD320
        public void OnInitiate(){} // RVA: 0x2DD310
        public void OnUpdate(){} // RVA: 0x2DD310
        public void InitiateBones(){} // RVA: 0x3E2CC0
        public void get_localDirection(){} // RVA: 0x3E3580
        public void get_positionOffset(){} // RVA: 0x3E3790
        public void GetSingularityOffset(){} // RVA: 0x3E3800
        public void SingularityDetected(){} // RVA: 0x3E3D70
        public void .ctor(){} // RVA: 0x3E40E0
    }

    public class IKSolverLeg
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x3E4190
        public void SetChain(){} // RVA: 0x3D1940
        public void GetPoints(){} // RVA: 0x3E4880
        public void GetPoint(){} // RVA: 0x3E4A30
        public void StoreDefaultLocalState(){} // RVA: 0x3D2260
        public void FixTransforms(){} // RVA: 0x3D22C0
        public void OnInitiate(){} // RVA: 0x3E4F80
        public void OnUpdate(){} // RVA: 0x3E50A0
        public void Solve(){} // RVA: 0x3E51A0
        public void Read(){} // RVA: 0x3E5290
        public void Write(){} // RVA: 0x3E5AC0
        public void .ctor(){} // RVA: 0x3E5E60
    }

    public class IKSolverLimb
    {
        // ── Methods ──
        public void MaintainRotation(){} // RVA: 0x3E6390
        public void MaintainBend(){} // RVA: 0x3E6430
        public void OnInitiateVirtual(){} // RVA: 0x3E6480
        public void OnUpdateVirtual(){} // RVA: 0x3E6CF0
        public void OnPostSolveVirtual(){} // RVA: 0x3E6E50
        public void .ctor(){} // RVA: 0x3E7130 | overloaded x2
        public void get_axisDirections(){} // RVA: 0x3E7260
        public void StoreAxisDirections(){} // RVA: 0x3E7280
        public void GetModifiedBendNormal(){} // RVA: 0x3E78D0
    }

    public class IKSolverLookAt
    {
        // ── Methods ──
        public void SetLookAtWeight(){} // RVA: 0x3E93A0 | overloaded x6
        public void StoreDefaultLocalState(){} // RVA: 0x3E9480
        public void FixTransforms(){} // RVA: 0x3E9640
        public void IsValid(){} // RVA: 0x3E9810
        public void GetPoints(){} // RVA: 0x3E9D70
        public void GetPoint(){} // RVA: 0x3EA190
        public void SetChain(){} // RVA: 0x3EA530
        public void OnInitiate(){} // RVA: 0x3EA630
        public void OnUpdate(){} // RVA: 0x3EACC0
        public void get_spineIsValid(){} // RVA: 0x3EAE50
        public void get_spineIsEmpty(){} // RVA: 0x3EAFB0
        public void SolveSpine(){} // RVA: 0x3EAFD0
        public void get_headIsValid(){} // RVA: 0x3EB2E0
        public void get_headIsEmpty(){} // RVA: 0x3EB2F0
        public void SolveHead(){} // RVA: 0x3EB3D0
        public void get_eyesIsValid(){} // RVA: 0x3EB870
        public void get_eyesIsEmpty(){} // RVA: 0x3EB9D0
        public void SolveEyes(){} // RVA: 0x3EB9F0
        public void GetForwards(){} // RVA: 0x3EC2E0
        public void SetBones(){} // RVA: 0x3EC6E0
        public void .ctor(){} // RVA: 0x3EC930
    }

    public class IKSolverTrigonometric
    {
        // ── Methods ──
        public void SetBendGoalPosition(){} // RVA: 0x3ED790
        public void SetBendPlaneToCurrent(){} // RVA: 0x3EDAA0
        public void SetIKRotation(){} // RVA: 0x3EDDC0
        public void SetIKRotationWeight(){} // RVA: 0x3EDDD0
        public void GetIKRotation(){} // RVA: 0x3EDE00
        public void GetIKRotationWeight(){} // RVA: 0x3EDE10
        public void GetPoints(){} // RVA: 0x3EDE20
        public void GetPoint(){} // RVA: 0x3EDF50
        public void StoreDefaultLocalState(){} // RVA: 0x3EE2A0
        public void FixTransforms(){} // RVA: 0x3EE2F0
        public void IsValid(){} // RVA: 0x3EE350
        public void SetChain(){} // RVA: 0x3EEAD0
        public void Solve(){} // RVA: 0x3EEC30
        public void GetDirectionToBendPoint(){} // RVA: 0x3EF8E0
        public void OnInitiate(){} // RVA: 0x3EFCC0
        public void IsDirectHierarchy(){} // RVA: 0x3F0040
        public void InitiateBones(){} // RVA: 0x3F0330
        public void OnUpdate(){} // RVA: 0x3F04E0
        public void OnInitiateVirtual(){} // RVA: 0x2DD310
        public void OnUpdateVirtual(){} // RVA: 0x2DD310
        public void OnPostSolveVirtual(){} // RVA: 0x2DD310
        public void GetBendDirection(){} // RVA: 0x3F1450
        public void .ctor(){} // RVA: 0x3F19C0
    }

    public class IKSolverVR
    {
        // ── Methods ──
        public void SetToReferences(){} // RVA: 0x3F24F0
        public void GuessHandOrientations(){} // RVA: 0x3F2C90
        public void DefaultAnimationCurves(){} // RVA: 0x3F30F0
        public void AddPositionOffset(){} // RVA: 0x3F34A0
        public void AddRotationOffset(){} // RVA: 0x3F37F0 | overloaded x2
        public void AddPlatformMotion(){} // RVA: 0x3F3BE0
        public void Reset(){} // RVA: 0x3F4020
        public void StoreDefaultLocalState(){} // RVA: 0x3F4350
        public void FixTransforms(){} // RVA: 0x3F45E0
        public void GetPoints(){} // RVA: 0x3F48E0
        public void GetPoint(){} // RVA: 0x3F4940
        public void IsValid(){} // RVA: 0x3F49A0
        public void GetNormal(){} // RVA: 0x3F4D50
        public void GuessWristToPalmAxis(){} // RVA: 0x3F5210
        public void GuessPalmToThumbAxis(){} // RVA: 0x3F55E0
        public void GetSineKeyframes(){} // RVA: 0x3F5F10
        public void UpdateSolverTransforms(){} // RVA: 0x3F5FA0
        public void OnInitiate(){} // RVA: 0x3F6220
        public void OnUpdate(){} // RVA: 0x3F6280
        public void WriteTransforms(){} // RVA: 0x3F6D10
        public void Read(){} // RVA: 0x3F78D0
        public void Solve(){} // RVA: 0x3F8450
        public void GetPosition(){} // RVA: 0x3FA070
        public void GetRotation(){} // RVA: 0x3FA0C0
        public void get_rootBone(){} // RVA: 0x3FA100
        public void set_rootBone(){} // RVA: 0x3FA110
        public void VrcRead(){} // RVA: 0x3F6220
        public void VrcWrite(){} // RVA: 0x3FA170
        public void VrcWriteTransforms(){} // RVA: 0x3FA180
        public void VrcSyncIk(){} // RVA: 0x3FA190
        public void VrcLateSolve(){} // RVA: 0x3FA1B0
        public void Write(){} // RVA: 0x3FA210
        public void GetPelvisOffset(){} // RVA: 0x3FA3A0
        public void .ctor(){} // RVA: 0x3FAE80
    }

    public class Inertia
    {
        // ── Methods ──
        public void ResetBodies(){} // RVA: 0x44DD60
        public void OnModifyOffset(){} // RVA: 0x44DE00
        public void .ctor(){} // RVA: 0x2E5920
    }

    public class InteractionEffector
    {
        public object device;

        // ── Methods ──
        public void get_effectorType(){} // RVA: 0x32A5C0
        public void set_effectorType(){} // RVA: 0x2E00C0
        public void get_isPaused(){} // RVA: 0x42CBD0
        public void set_isPaused(){} // RVA: 0x42CBE0
        public void get_interactionObject(){} // RVA: 0x2E07C0
        public void set_interactionObject(){} // RVA: 0x343E80
        public void get_inInteraction(){} // RVA: 0x42CBF0
        public void .ctor(){} // RVA: 0x42CCC0
        public void Initiate(){} // RVA: 0x42CD90
        public void StoreDefaults(){} // RVA: 0x42CF50
        public void ResetToDefaults(){} // RVA: 0x42D140
        public void Pause(){} // RVA: 0x42D600
        public void Resume(){} // RVA: 0x42D960
        public void Start(){} // RVA: 0x42D9C0
        public void Update(){} // RVA: 0x42E3F0
        public void get_progress(){} // RVA: 0x42F010
        public void TriggerUntriggeredEvents(){} // RVA: 0x42F050
        public void PickUp(){} // RVA: 0x42F370
        public void Stop(){} // RVA: 0x42F740
        public void OnPostFBBIK(){} // RVA: 0x42FB30
    }

    public class InteractionLookAt
    {
        // ── Methods ──
        public void Look(){} // RVA: 0x430120
        public void OnFixTransforms(){} // RVA: 0x430380
        public void Update(){} // RVA: 0x430480
        public void SolveSpine(){} // RVA: 0x430910
        public void SolveHead(){} // RVA: 0x430AA0
        public void .ctor(){} // RVA: 0x430BE0
    }

    public class InteractionObject
    {
        public object Name;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void OpenTutorial1(){} // RVA: 0x2DD310
        public void OpenTutorial2(){} // RVA: 0x2DD310
        public void OpenTutorial3(){} // RVA: 0x2DD310
        public void OpenTutorial4(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void get_length(){} // RVA: 0x345460
        public void set_length(){} // RVA: 0x345470
        public void get_lastUsedInteractionSystem(){} // RVA: 0x3A5500
        public void set_lastUsedInteractionSystem(){} // RVA: 0x3A5510
        public void Initiate(){} // RVA: 0x430BF0
        public void get_lookAtTarget(){} // RVA: 0x430EB0
        public void GetTarget(){} // RVA: 0x432830 | overloaded x3
        public void CurveUsed(){} // RVA: 0x4311C0
        public void GetTargets(){} // RVA: 0x37B370
        public void OnStartInteraction(){} // RVA: 0x3A5510
        public void Apply(){} // RVA: 0x431F70 | overloaded x2
        public void GetValue(){} // RVA: 0x431AC0
        public void get_targetsRoot(){} // RVA: 0x431E40
        public void Start(){} // RVA: 0x431F60
        public void GetWeightCurveIndex(){} // RVA: 0x4328E0
        public void GetMultiplierIndex(){} // RVA: 0x432940
        public void .ctor(){} // RVA: 0x4329A0
    }

    public class InteractionSystem
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void OpenTutorial1(){} // RVA: 0x2DD310
        public void OpenTutorial2(){} // RVA: 0x2DD310
        public void OpenTutorial3(){} // RVA: 0x2DD310
        public void OpenTutorial4(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void get_inInteraction(){} // RVA: 0x4333C0
        public void IsInInteraction(){} // RVA: 0x433480
        public void IsPaused(){} // RVA: 0x433620 | overloaded x2
        public void IsInSync(){} // RVA: 0x4336E0
        public void StartInteraction(){} // RVA: 0x433810
        public void PauseInteraction(){} // RVA: 0x433980
        public void ResumeInteraction(){} // RVA: 0x433A10
        public void StopInteraction(){} // RVA: 0x433AA0
        public void PauseAll(){} // RVA: 0x433B30
        public void ResumeAll(){} // RVA: 0x433BB0
        public void StopAll(){} // RVA: 0x433C90
        public void GetInteractionObject(){} // RVA: 0x433D10
        public void GetProgress(){} // RVA: 0x433DA0
        public void GetMinActiveProgress(){} // RVA: 0x433E40
        public void TriggerInteraction(){} // RVA: 0x434400 | overloaded x3
        public void GetClosestInteractionRange(){} // RVA: 0x4347A0
        public void GetClosestInteractionObjectInRange(){} // RVA: 0x434890
        public void GetClosestInteractionTargetInRange(){} // RVA: 0x4348E0
        public void GetClosestInteractionObjectsInRange(){} // RVA: 0x434950
        public void GetClosestInteractionTargetsInRange(){} // RVA: 0x434AE0
        public void TriggerEffectorsReady(){} // RVA: 0x434C90
        public void GetTriggerRange(){} // RVA: 0x434FE0
        public void GetClosestTriggerIndex(){} // RVA: 0x435160
        public void get_ik(){} // RVA: 0x435460
        public void set_ik(){} // RVA: 0x435470
        public void get_triggersInRange(){} // RVA: 0x37E0E0
        public void set_triggersInRange(){} // RVA: 0x4354D0
        public void Start(){} // RVA: 0x435530
        public void InteractionPause(){} // RVA: 0x436030
        public void InteractionResume(){} // RVA: 0x436050
        public void InteractionStop(){} // RVA: 0x436050
        public void LookAtInteraction(){} // RVA: 0x436070
        public void OnTriggerEnter(){} // RVA: 0x436210
        public void OnTriggerExit(){} // RVA: 0x436440
        public void ContactIsInRange(){} // RVA: 0x436610
        public void OnDrawGizmosSelected(){} // RVA: 0x4368A0
        public void Update(){} // RVA: 0x436B60
        public void Raycasting(){} // RVA: 0x436EE0
        public void UpdateTriggerEventBroadcasting(){} // RVA: 0x437150
        public void UpdateEffectors(){} // RVA: 0x4378D0
        public void OnPreFBBIK(){} // RVA: 0x437AD0
        public void OnPostFBBIK(){} // RVA: 0x437D40
        public void OnFixTransforms(){} // RVA: 0x437FB0
        public void OnDestroy(){} // RVA: 0x4380C0
        public void IsValid(){} // RVA: 0x4388B0
        public void TriggerIndexIsValid(){} // RVA: 0x438A40
        public void .ctor(){} // RVA: 0x438C20
    }

    public class InteractionTarget
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void OpenTutorial1(){} // RVA: 0x2DD310
        public void OpenTutorial2(){} // RVA: 0x2DD310
        public void OpenTutorial3(){} // RVA: 0x2DD310
        public void OpenTutorial4(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetValue(){} // RVA: 0x439590
        public void ResetRotation(){} // RVA: 0x439600
        public void RotateTo(){} // RVA: 0x439730
        public void .ctor(){} // RVA: 0x43A540
    }

    public class InteractionTrigger
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void OpenTutorial4(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void Start(){} // RVA: 0x2DD310
        public void GetBestRangeIndex(){} // RVA: 0x43A5E0
        public void .ctor(){} // RVA: 0x43A900
    }

    public class LegIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetIKSolver(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x3ACB20
    }

    public class LimbIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetIKSolver(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x3ACC00
    }

    public class LookAtController
    {
        public object Descriptor;

        // ── Methods ──
        public void Start(){} // RVA: 0x44E790
        public void LateUpdate(){} // RVA: 0x44E850
        public void get_pivot(){} // RVA: 0x44F470
        public void ApplyMinDistance(){} // RVA: 0x44F800
        public void RootRotation(){} // RVA: 0x44F9C0
        public void .ctor(){} // RVA: 0x450070
    }

    public class LookAtIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetIKSolver(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x3ACCE0
    }

    public class OffsetModifier
    {
        // ── Methods ──
        public void get_deltaTime(){} // RVA: 0x450140
        public void OnModifyOffset(){} // RVA: 0x24A50
        public void Start(){} // RVA: 0x4501A0
        public void Initiate(){} // RVA: 0x450250
        public void ModifyOffset(){} // RVA: 0x4502F0
        public void ApplyLimits(){} // RVA: 0x4504C0
        public void OnDestroy(){} // RVA: 0x450630
        public void .ctor(){} // RVA: 0x2E5920
    }

    public class OffsetModifierVRIK
    {
        // ── Methods ──
        public void get_deltaTime(){} // RVA: 0x450140
        public void OnModifyOffset(){} // RVA: 0x24A50
        public void Start(){} // RVA: 0x4510E0
        public void Initiate(){} // RVA: 0x451190
        public void ModifyOffset(){} // RVA: 0x451230
        public void OnDestroy(){} // RVA: 0x451400
        public void .ctor(){} // RVA: 0x2E5920
    }

    public class OffsetPose
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x451A60 | overloaded x2
        public void .ctor(){} // RVA: 0x451B20
    }

    public class PenetrationAvoidance
    {
        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x452190
        public void .ctor(){} // RVA: 0x2E5920
    }

    public class Poser
    {
        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x24A50
        public void UpdateManual(){} // RVA: 0x43E1C0
        public void InitiatePoser(){} // RVA: 0x24A50
        public void UpdatePoser(){} // RVA: 0x24A50
        public void FixPoserTransforms(){} // RVA: 0x24A50
        public void UpdateSolver(){} // RVA: 0x43E1E0
        public void InitiateSolver(){} // RVA: 0x43E230
        public void FixTransforms(){} // RVA: 0x43E260
        public void .ctor(){} // RVA: 0x43CD50
    }

    public class RagdollUtility
    {
        // ── Methods ──
        public void EnableRagdoll(){} // RVA: 0x43E280
        public void DisableRagdoll(){} // RVA: 0x43E2E0
        public void Start(){} // RVA: 0x43E3F0
        public void DisableRagdollSmooth(){} // RVA: 0x43EE90
        public void Update(){} // RVA: 0x43EF30
        public void FixedUpdate(){} // RVA: 0x43F240
        public void LateUpdate(){} // RVA: 0x43F280
        public void AfterLastIK(){} // RVA: 0x43F3C0
        public void AfterAnimation(){} // RVA: 0x43F410
        public void OnFinalPose(){} // RVA: 0x43F450
        public void RagdollEnabler(){} // RVA: 0x43F490
        public void get_isRagdoll(){} // RVA: 0x43F800
        public void RecordVelocities(){} // RVA: 0x43F8F0
        public void get_ikUsed(){} // RVA: 0x43FBD0
        public void StoreLocalState(){} // RVA: 0x43FE00
        public void FixTransforms(){} // RVA: 0x43FF50
        public void OnDestroy(){} // RVA: 0x440310
        public void .ctor(){} // RVA: 0x440520
    }

    public class Recoil
    {
        // ── Methods ──
        public void get_isFinished(){} // RVA: 0x452B60
        public void SetHandRotations(){} // RVA: 0x452BC0
        public void Fire(){} // RVA: 0x452BF0
        public void OnModifyOffset(){} // RVA: 0x452F50
        public void AfterFBBIK(){} // RVA: 0x4545D0
        public void AfterAimIK(){} // RVA: 0x454930
        public void get_primaryHandEffector(){} // RVA: 0x454980
        public void get_secondaryHandEffector(){} // RVA: 0x4549F0
        public void get_primaryHand(){} // RVA: 0x454A60
        public void get_secondaryHand(){} // RVA: 0x454A80
        public void OnDestroy(){} // RVA: 0x454AA0
        public void .ctor(){} // RVA: 0x454E10
    }

    public class RotationLimit
    {
        // ── Methods ──
        public void SetDefaultLocalRotation(){} // RVA: 0x441E10 | overloaded x2
        public void GetLimitedLocalRotation(){} // RVA: 0x441E20
        public void Apply(){} // RVA: 0x4421F0
        public void Disable(){} // RVA: 0x4423A0
        public void get_secondaryAxis(){} // RVA: 0x442440
        public void get_crossAxis(){} // RVA: 0x442460
        public void get_defaultLocalRotationOverride(){} // RVA: 0x4424E0
        public void set_defaultLocalRotationOverride(){} // RVA: 0x4424F0
        public void LimitRotation(){}
        public void Awake(){} // RVA: 0x442500
        public void LateUpdate(){} // RVA: 0x4426C0
        public void LogWarning(){} // RVA: 0x3926F0
        public void Limit1DOF(){} // RVA: 0x4426D0
        public void LimitTwist(){} // RVA: 0x442A20
        public void GetOrthogonalAngle(){} // RVA: 0x443030
        public void .ctor(){} // RVA: 0x443110
    }

    public class RotationLimitAngle
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void LimitRotation(){} // RVA: 0x4431A0
        public void LimitSwing(){} // RVA: 0x443250
        public void .ctor(){} // RVA: 0x4436D0
    }

    public class RotationLimitHinge
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void LimitRotation(){} // RVA: 0x4436F0
        public void LimitHinge(){} // RVA: 0x443740
        public void .ctor(){} // RVA: 0x443C20
    }

    public class RotationLimitPolygonal
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void SetLimitPoints(){} // RVA: 0x443C80
        public void LimitRotation(){} // RVA: 0x443D40
        public void Start(){} // RVA: 0x443E20
        public void ResetToDefault(){} // RVA: 0x444040
        public void BuildReachCones(){} // RVA: 0x444E60
        public void SmoothPoints(){} // RVA: 0x445620
        public void GetScalar(){} // RVA: 0x445D50
        public void PointToTangentPlane(){} // RVA: 0x445DA0
        public void TangentPointToSphere(){} // RVA: 0x445E90
        public void LimitSwing(){} // RVA: 0x445FB0
        public void GetReachCone(){} // RVA: 0x4465C0
        public void .ctor(){} // RVA: 0x446720
    }

    public class RotationLimitSpline
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void SetSpline(){} // RVA: 0x446E20
        public void LimitRotation(){} // RVA: 0x446E90
        public void LimitSwing(){} // RVA: 0x446F40
        public void .ctor(){} // RVA: 0x447570
    }

    public class ShoulderRotator
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x455490
        public void RotateShoulders(){} // RVA: 0x455660
        public void RotateShoulder(){} // RVA: 0x4557C0
        public void GetParentBoneMap(){} // RVA: 0x455E90
        public void OnDestroy(){} // RVA: 0x455FC0
        public void .ctor(){} // RVA: 0x4561C0
    }

    public class TrigonometricIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void SupportGroup(){} // RVA: 0x2DD310
        public void ASThread(){} // RVA: 0x2DD310
        public void GetIKSolver(){} // RVA: 0x35A740
        public void .ctor(){} // RVA: 0x3ACDC0
    }

    public class TwistRelaxer
    {
        // ── Methods ──
        public void Relax(){} // RVA: 0x42AA40
        public void Init(){} // RVA: 0x42BBA0
        public void Start(){} // RVA: 0x42BBB0
        public void OnPostUpdate(){} // RVA: 0x42C720
        public void LateUpdate(){} // RVA: 0x42C800
        public void OnDestroy(){} // RVA: 0x42C8E0
        public void .ctor(){} // RVA: 0x42CAF0
    }

    public class VRIK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x2DD310
        public void OpenScriptReference(){} // RVA: 0x2DD310
        public void OpenSetupTutorial(){} // RVA: 0x2DD310
        public void AutoDetectReferences(){} // RVA: 0x3ACEA0
        public void GuessHandOrientations(){} // RVA: 0x3ACF00
        public void GetIKSolver(){} // RVA: 0x358730
        public void InternalInitiateSolver(){} // RVA: 0x3ACF30
        public void InitiateSolver(){} // RVA: 0x3AD010
        public void VRCSetAvatarMainIK(){} // RVA: 0x3978F0
        public void VRCInitiateSolver(){} // RVA: 0x3AD020
        public void UpdateSolver(){} // RVA: 0x3AD030
        public void .ctor(){} // RVA: 0x3AD330
    }

    public class VRIKCalibrator
    {
        // ── Methods ──
        public void RecalibrateScale(){} // RVA: 0x456220
        public void Calibrate(){} // RVA: 0x45A160 | overloaded x2
        public void CalibrateLeg(){} // RVA: 0x45B370 | overloaded x2
    }

    public class VRIKLODController
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x45BCA0
        public void Update(){} // RVA: 0x45BD30
        public void GetLODLevel(){} // RVA: 0x45BD70
        public void .ctor(){} // RVA: 0x45C0B0
    }

    public class VRIKRootController
    {
        // ── Methods ──
        public void get_pelvisTargetRight(){} // RVA: 0x343EE0
        public void set_pelvisTargetRight(){} // RVA: 0x343F00
        public void Awake(){} // RVA: 0x45C100
        public void Calibrate(){} // RVA: 0x45C7A0 | overloaded x2
        public void OnPreUpdate(){} // RVA: 0x45CB60
        public void OnDestroy(){} // RVA: 0x45D700
        public void .ctor(){} // RVA: 0x2DDD50
    }

}