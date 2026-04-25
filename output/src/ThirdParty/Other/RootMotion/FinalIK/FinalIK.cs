// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 87
// Methods: 971

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class AimController : MonoBehaviour
    {
        public object pivot;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E4AB580
        public void LateUpdate(){} // RVA: 0x7FFD4E4AB6B0
        public void get_pivot(){} // RVA: 0x7FFD4E4AC480
        public void ApplyMinDistance(){} // RVA: 0x7FFD4E4AC810
        public void RootRotation(){} // RVA: 0x7FFD4E4AC9D0
        public void TurnToTarget(){} // RVA: 0x7FFD4E4AD0D0
        public void .ctor(){} // RVA: 0x7FFD4E4AD170
    }

    public class AimIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OpenSetupTutorial(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BE740
        public void .ctor(){} // RVA: 0x7FFD4E40EE20
    }

    public class AimPoser : MonoBehaviour
    {
        // ── Methods ──
        public void GetPose(){} // RVA: 0x7FFD4E4AD3E0
        public void SetPoseActive(){} // RVA: 0x7FFD4E4AD4F0
        public void .ctor(){} // RVA: 0x7FFD4E4AD570
    }

    public class Amplifier : OffsetModifier
    {
        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4AD9B0
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class ArmIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BE740
        public void .ctor(){} // RVA: 0x7FFD4E40EF00
    }

    public class BipedIK : SolverManager
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetIKPositionWeight(){} // RVA: 0x7FFD4E3F5760
        public void GetIKRotationWeight(){} // RVA: 0x7FFD4E3F5790
        public void SetIKPositionWeight(){} // RVA: 0x7FFD4E3F57C0
        public void SetIKRotationWeight(){} // RVA: 0x7FFD4E3F5820
        public void SetIKPosition(){} // RVA: 0x7FFD4E3F5880
        public void SetIKRotation(){} // RVA: 0x7FFD4E3F58C0
        public void GetIKPosition(){} // RVA: 0x7FFD4E3F58F0
        public void GetIKRotation(){} // RVA: 0x7FFD4E3F5950
        public void SetLookAtWeight(){} // RVA: 0x7FFD4E3F5990
        public void SetLookAtPosition(){} // RVA: 0x7FFD4E3F5AA0
        public void SetSpinePosition(){} // RVA: 0x7FFD4E3F5AD0
        public void SetSpineWeight(){} // RVA: 0x7FFD4E3F5B00
        public void GetGoalIK(){} // RVA: 0x7FFD4E3F5B50
        public void InitiateBipedIK(){} // RVA: 0x7FFD4E3F5BC0
        public void UpdateBipedIK(){} // RVA: 0x7FFD4E3F5BE0
        public void SetToDefaults(){} // RVA: 0x7FFD4E3F5C00
        public void FixTransforms(){} // RVA: 0x7FFD4E3F5DB0
        public void InitiateSolver(){} // RVA: 0x7FFD4E3F5E80
        public void UpdateSolver(){} // RVA: 0x7FFD4E3F62A0
        public void LogWarning(){} // RVA: 0x7FFD4E3F66F0
        public void .ctor(){} // RVA: 0x7FFD4E3F6760
    }

    public class BipedIKSolvers : Object
    {
        public object limbs;
        public object ikSolvers;

        // ── Methods ──
        public void get_limbs(){} // RVA: 0x7FFD4E3F68E0
        public void get_ikSolvers(){} // RVA: 0x7FFD4E3F6AB0
        public void AssignReferences(){} // RVA: 0x7FFD4E3F6D40
        public void .ctor(){} // RVA: 0x7FFD4E3F6FB0
    }

    public class BodyTilt : OffsetModifier
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E4AE220
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4AE330
        public void .ctor(){} // RVA: 0x7FFD4E4AE6E0
    }

    public class CCDIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BE740
        public void .ctor(){} // RVA: 0x7FFD4E40EFE0
    }

    public class Constraint : Object
    {
        public object isValid;

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFD4E3F73B0
        public void UpdateConstraint(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ConstraintPosition : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFD4E3F7480
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
    }

    public class ConstraintPositionOffset : Constraint
    {
        public object positionChanged;

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFD4E3F75F0
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
        public void get_positionChanged(){} // RVA: 0x7FFD4E3F7A20
    }

    public class ConstraintRotation : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFD4E3F7AF0
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
    }

    public class ConstraintRotationOffset : Constraint
    {
        public object rotationChanged;

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFD4E3F7C70
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
        public void get_rotationChanged(){} // RVA: 0x7FFD4E3F80B0
    }

    public class Constraints : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E3F8180
        public void Initiate(){} // RVA: 0x7FFD4E3F8250
        public void Update(){} // RVA: 0x7FFD4E3F83B0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class EditorIK : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E4AE740
        public void Update(){} // RVA: 0x7FFD4E4AE860
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class FABRIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BE740
        public void .ctor(){} // RVA: 0x7FFD4E40F0C0
    }

    public class FABRIKChain : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E413B50
        public void Initiate(){} // RVA: 0x7FFD4E413CE0
        public void Stage1(){} // RVA: 0x7FFD4E413D40
        public void Stage2(){} // RVA: 0x7FFD4E413F10
        public void GetCentroid(){} // RVA: 0x7FFD4E414150
        public void .ctor(){} // RVA: 0x7FFD4E414410
    }

    public class FABRIKRoot : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BE740
        public void .ctor(){} // RVA: 0x7FFD4E40F1A0
    }

    public class FBBIKArmBending : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFD4E4144B0
        public void OnPostFBBIK(){} // RVA: 0x7FFD4E414FB0
        public void OnDestroy(){} // RVA: 0x7FFD4E415490
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class FBBIKHeadEffector : MonoBehaviour
    {
        // ── Methods ──
        public void VRCInitialize(){} // RVA: 0x7FFD4E415690
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFD4E4156A0
        public void Start(){} // RVA: 0x7FFD4E4156B0
        public void Initialize(){} // RVA: 0x7FFD4E4156D0
        public void OnStoreDefaultLocalState(){} // RVA: 0x7FFD4E415F70
        public void OnFixTransforms(){} // RVA: 0x7FFD4E4169E0
        public void OnPreRead(){} // RVA: 0x7FFD4E4172D0
        public void SpineBend(){} // RVA: 0x7FFD4E4181C0
        public void CCDPass(){} // RVA: 0x7FFD4E418AD0
        public void Iterate(){} // RVA: 0x7FFD4E419360
        public void OnPostUpdate(){} // RVA: 0x7FFD4E41A350
        public void ChestDirection(){} // RVA: 0x7FFD4E41A960
        public void PostStretching(){} // RVA: 0x7FFD4E41AEA0
        public void LerpSolverPosition(){} // RVA: 0x7FFD4E41B4D0
        public void Solve(){} // RVA: 0x7FFD4E41B670
        public void OnDestroy(){} // RVA: 0x7FFD4E41B7B0
        public void .ctor(){} // RVA: 0x7FFD4E41BE00
    }

    public class FBIKChain : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E41C710 | overloaded x2
        public void SetNodes(){} // RVA: 0x7FFD4E41CA00
        public void GetNodeIndex(){} // RVA: 0x7FFD4E41CC50
        public void IsValid(){} // RVA: 0x7FFD4E41CDE0
        public void Initiate(){} // RVA: 0x7FFD4E41CFA0
        public void ReadPose(){} // RVA: 0x7FFD4E41D220
        public void CalculateBoneLengths(){} // RVA: 0x7FFD4E41D8C0
        public void Reach(){} // RVA: 0x7FFD4E41DFB0
        public void Push(){} // RVA: 0x7FFD4E41E310
        public void SolveTrigonometric(){} // RVA: 0x7FFD4E41E700
        public void Stage1(){} // RVA: 0x7FFD4E41EA70
        public void Stage2(){} // RVA: 0x7FFD4E41EF50
        public void SolveConstraintSystems(){} // RVA: 0x7FFD4E41F1C0
        public void SolveFABRIKJoint(){} // RVA: 0x7FFD4E41F310
        public void GetDirToBendPoint(){} // RVA: 0x7FFD4E41F450
        public void SolveChildConstraints(){} // RVA: 0x7FFD4E41F840
        public void SolveLinearConstraint(){} // RVA: 0x7FFD4E41FB90
        public void ForwardReach(){} // RVA: 0x7FFD4E41FD20
        public void BackwardReach(){} // RVA: 0x7FFD4E41FF50
    }

    public class FingerRig : SolverManager
    {
        public object initiated;

        // ── Methods ──
        public void get_initiated(){} // RVA: 0x7FFD4E3FB8E0
        public void set_initiated(){} // RVA: 0x7FFD4E3FB8F0
        public void IsValid(){} // RVA: 0x7FFD4E3FB900
        public void AutoDetect(){} // RVA: 0x7FFD4E3FB980
        public void AddFinger(){} // RVA: 0x7FFD4E3FBE70
        public void RemoveFinger(){} // RVA: 0x7FFD4E3FC1B0
        public void AddChildrenRecursive(){} // RVA: 0x7FFD4E3FC3C0
        public void InitiateSolver(){} // RVA: 0x7FFD4E3FC520
        public void UpdateFingerSolvers(){} // RVA: 0x7FFD4E3FC620
        public void FixFingerTransforms(){} // RVA: 0x7FFD4E3FC690
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E3FC8E0
        public void UpdateSolver(){} // RVA: 0x7FFD4E3FC620
        public void FixTransforms(){} // RVA: 0x7FFD4E3FCB10
        public void .ctor(){} // RVA: 0x7FFD4E3FCB30
    }

    public class FullBodyBipedIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OpenSetupTutorial(){} // RVA: 0x7FFD4E341310
        public void OpenInspectorTutorial(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void SetReferences(){} // RVA: 0x7FFD4E40F310
        public void GetIKSolver(){} // RVA: 0x7FFD4E3E20E0
        public void ReferencesError(){} // RVA: 0x7FFD4E40F380
        public void ReferencesWarning(){} // RVA: 0x7FFD4E40F7D0
        public void Reinitiate(){} // RVA: 0x7FFD4E40FF70
        public void AutoDetectReferences(){} // RVA: 0x7FFD4E40FFA0
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFD4E3FCC10
        public void VRCInitiateSolver(){} // RVA: 0x7FFD4E410150
        public void InitiateSolver(){} // RVA: 0x7FFD4E410160
        public void .ctor(){} // RVA: 0x7FFD4E410170
    }

    public class GenericPoser : Poser
    {
        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x7FFD4E4A02B0
        public void InitiatePoser(){} // RVA: 0x7FFD4E4A0840
        public void UpdatePoser(){} // RVA: 0x7FFD4E4A0850
        public void FixPoserTransforms(){} // RVA: 0x7FFD4E4A09C0
        public void StoreDefaultState(){} // RVA: 0x7FFD4E4A0B20
        public void GetTargetNamed(){} // RVA: 0x7FFD4E4A0C90
        public void .ctor(){} // RVA: 0x7FFD4E4A0D50
    }

    public class Grounder : MonoBehaviour
    {
        public object initiated;

        // ── Methods ──
        public void ResetPosition(){} // RVA: 0x7FFD4E090980
        public void get_initiated(){} // RVA: 0x7FFD4E3FCC00
        public void set_initiated(){} // RVA: 0x7FFD4E3FCC10
        public void GetSpineOffsetTarget(){} // RVA: 0x7FFD4E3FCC20
        public void LogWarning(){} // RVA: 0x7FFD4E3F66F0
        public void GetLegSpineBendVector(){} // RVA: 0x7FFD4E3FCD60
        public void GetLegSpineTangent(){} // RVA: 0x7FFD4E3FCFB0
        public void OpenUserManual(){} // RVA: 0x7FFD4E090980
        public void OpenScriptReference(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E3FD260
    }

    public class GrounderBipedIK : Grounder
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void ResetPosition(){} // RVA: 0x7FFD4E3FD380
        public void IsReadyToInitiate(){} // RVA: 0x7FFD4E3FD3F0
        public void Update(){} // RVA: 0x7FFD4E3FD510
        public void Initiate(){} // RVA: 0x7FFD4E3FD660
        public void OnDisable(){} // RVA: 0x7FFD4E3FDBF0
        public void OnSolverUpdate(){} // RVA: 0x7FFD4E3FDC50
        public void SetLegIK(){} // RVA: 0x7FFD4E3FE770
        public void OnPostSolverUpdate(){} // RVA: 0x7FFD4E3FE890
        public void OnDestroy(){} // RVA: 0x7FFD4E3FECE0
        public void .ctor(){} // RVA: 0x7FFD4E3FF020
    }

    public class GrounderFBBIK : Grounder
    {
        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0x7FFD4E341310
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void ResetPosition(){} // RVA: 0x7FFD4E3FF150
        public void IsReadyToInitiate(){} // RVA: 0x7FFD4E3FF1C0
        public void Update(){} // RVA: 0x7FFD4E3FF2C0
        public void FixedUpdate(){} // RVA: 0x7FFD4E3FF400
        public void LateUpdate(){} // RVA: 0x7FFD4E3FF400
        public void Initiate(){} // RVA: 0x7FFD4E3FF410
        public void OnSolverUpdate(){} // RVA: 0x7FFD4E3FF7D0
        public void SetLegIK(){} // RVA: 0x7FFD4E3FFD90
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD4E400180
        public void OnDestroy(){} // RVA: 0x7FFD4E4004D0
        public void .ctor(){} // RVA: 0x7FFD4E4006D0
    }

    public class GrounderIK : Grounder
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void ResetPosition(){} // RVA: 0x7FFD4E400810
        public void IsReadyToInitiate(){} // RVA: 0x7FFD4E400830
        public void OnDisable(){} // RVA: 0x7FFD4E400B10
        public void Update(){} // RVA: 0x7FFD4E400C80
        public void Initiate(){} // RVA: 0x7FFD4E4016C0
        public void OnSolverUpdate(){} // RVA: 0x7FFD4E401FD0
        public void SetLegIK(){} // RVA: 0x7FFD4E402520
        public void OnPostSolverUpdate(){} // RVA: 0x7FFD4E402AD0
        public void OnDestroy(){} // RVA: 0x7FFD4E402F30
        public void .ctor(){} // RVA: 0x7FFD4E403230
    }

    public class GrounderQuadruped : Grounder
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void ResetPosition(){} // RVA: 0x7FFD4E403350
        public void IsReadyToInitiate(){} // RVA: 0x7FFD4E403390
        public void IsReadyToInitiateLegs(){} // RVA: 0x7FFD4E403610
        public void OnDisable(){} // RVA: 0x7FFD4E403850
        public void Update(){} // RVA: 0x7FFD4E4038D0
        public void Initiate(){} // RVA: 0x7FFD4E403940
        public void InitiateFeet(){} // RVA: 0x7FFD4E4040C0
        public void LateUpdate(){} // RVA: 0x7FFD4E404790
        public void RootRotation(){} // RVA: 0x7FFD4E4048A0
        public void OnSolverUpdate(){} // RVA: 0x7FFD4E405320
        public void UpdateForefeetRoot(){} // RVA: 0x7FFD4E406400
        public void SetFootIK(){} // RVA: 0x7FFD4E406950
        public void OnPostSolverUpdate(){} // RVA: 0x7FFD4E406B40
        public void OnDestroy(){} // RVA: 0x7FFD4E4072E0
        public void DestroyLegs(){} // RVA: 0x7FFD4E407320
        public void .ctor(){} // RVA: 0x7FFD4E407610
    }

    public class GrounderVRIK : Grounder
    {
        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0x7FFD4E341310
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void ResetPosition(){} // RVA: 0x7FFD4E400810
        public void IsReadyToInitiate(){} // RVA: 0x7FFD4E407C20
        public void Update(){} // RVA: 0x7FFD4E407D20
        public void Initiate(){} // RVA: 0x7FFD4E407E50
        public void OnSolverUpdate(){} // RVA: 0x7FFD4E408230
        public void SetLegIK(){} // RVA: 0x7FFD4E4086D0
        public void OnPostSolverUpdate(){} // RVA: 0x7FFD4E408800
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD4E408DF0
        public void OnDestroy(){} // RVA: 0x7FFD4E409140
        public void .ctor(){} // RVA: 0x7FFD4E409470
    }

    public class Grounding : Object
    {
        public object legs;
        public object pelvis;
        public object isGrounded;
        public object root;
        public object rootHit;
        public object rootGrounded;
        public object up;
        public object useRootRotation;

        // ── Methods ──
        public void get_legs(){} // RVA: 0x7FFD4E409500
        public void set_legs(){} // RVA: 0x7FFD4E409510
        public void get_pelvis(){} // RVA: 0x7FFD4E3DF370
        public void set_pelvis(){} // RVA: 0x7FFD4E3DF380
        public void get_isGrounded(){} // RVA: 0x7FFD4E409570
        public void set_isGrounded(){} // RVA: 0x7FFD4E409580
        public void get_root(){} // RVA: 0x7FFD4E409590
        public void set_root(){} // RVA: 0x7FFD4E4095A0
        public void get_rootHit(){} // RVA: 0x7FFD4E409600
        public void set_rootHit(){} // RVA: 0x7FFD4E409630
        public void get_rootGrounded(){} // RVA: 0x7FFD4E409660
        public void GetRootHit(){} // RVA: 0x7FFD4E409680
        public void IsValid(){} // RVA: 0x7FFD4E409C90
        public void Initiate(){} // RVA: 0x7FFD4E409EF0
        public void Update(){} // RVA: 0x7FFD4E40A4A0
        public void GetLegsPlaneNormal(){} // RVA: 0x7FFD4E40A730
        public void Reset(){} // RVA: 0x7FFD4E40AC10
        public void LogWarning(){} // RVA: 0x7FFD4E40AFF0
        public void get_up(){} // RVA: 0x7FFD4E40B010
        public void GetVerticalOffset(){} // RVA: 0x7FFD4E40B0A0
        public void Flatten(){} // RVA: 0x7FFD4E40B290
        public void get_useRootRotation(){} // RVA: 0x7FFD4E40B3D0
        public void GetFootCenterOffset(){} // RVA: 0x7FFD4E40B4A0
        public void .ctor(){} // RVA: 0x7FFD4E40B580
    }

    public class HandPoser : Poser
    {
        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x7FFD4E4A1290
        public void InitiatePoser(){} // RVA: 0x7FFD4E4A1500
        public void FixPoserTransforms(){} // RVA: 0x7FFD4E4A15C0
        public void UpdatePoser(){} // RVA: 0x7FFD4E4A1760
        public void StoreDefaultState(){} // RVA: 0x7FFD4E4A1F00
        public void .ctor(){} // RVA: 0x7FFD4E4A0D50
    }

    public class HitReaction : OffsetModifier
    {
        public object inProgress;

        // ── Methods ──
        public void get_inProgress(){} // RVA: 0x7FFD4E4AE9A0
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4AEA50
        public void Hit(){} // RVA: 0x7FFD4E4AEB30
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class HitReactionVRIK : OffsetModifierVRIK
    {
        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4B03B0
        public void Hit(){} // RVA: 0x7FFD4E4B0480
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class IK : SolverManager
    {
        // ── Methods ──
        public void GetIKSolver(){} // RVA: 0x7FFD4E078E90
        public void UpdateSolver(){} // RVA: 0x7FFD4E410300
        public void InitiateSolver(){} // RVA: 0x7FFD4E4103A0
        public void FixTransforms(){} // RVA: 0x7FFD4E410450
        public void OpenUserManual(){} // RVA: 0x7FFD4E090980
        public void OpenScriptReference(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E39B060
    }

    public class IKConstraintBend : Object
    {
        public object initiated;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E420920
        public void get_initiated(){} // RVA: 0x7FFD4E420CE0
        public void set_initiated(){} // RVA: 0x7FFD4E420CF0
        public void .ctor(){} // RVA: 0x7FFD4E420D60 | overloaded x2
        public void SetBones(){} // RVA: 0x7FFD4E420E00
        public void Initiate(){} // RVA: 0x7FFD4E420F00
        public void SetLimbOrientation(){} // RVA: 0x7FFD4E421940
        public void LimitBend(){} // RVA: 0x7FFD4E421BF0
        public void GetDir(){} // RVA: 0x7FFD4E422860
        public void OrthoToLimb(){} // RVA: 0x7FFD4E423490
        public void OrthoToBone1(){} // RVA: 0x7FFD4E423600
    }

    public class IKEffector : Object
    {
        public object isEndEffector;

        // ── Methods ──
        public void GetNode(){} // RVA: 0x7FFD4E423770
        public void get_isEndEffector(){} // RVA: 0x7FFD4E3FB8E0
        public void set_isEndEffector(){} // RVA: 0x7FFD4E3FB8F0
        public void PinToBone(){} // RVA: 0x7FFD4E4237D0
        public void .ctor(){} // RVA: 0x7FFD4E423C50 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFD4E424050
        public void Initiate(){} // RVA: 0x7FFD4E424660
        public void ResetOffset(){} // RVA: 0x7FFD4E424C40
        public void SetToTarget(){} // RVA: 0x7FFD4E424E10
        public void OnPreSolve(){} // RVA: 0x7FFD4E424FC0
        public void OnPostWrite(){} // RVA: 0x7FFD4E425990
        public void GetPlaneRotation(){} // RVA: 0x7FFD4E4259E0
        public void Update(){} // RVA: 0x7FFD4E425D60
        public void GetPosition(){} // RVA: 0x7FFD4E4261C0
    }

    public class IKExecutionOrder : MonoBehaviour
    {
        public object animatePhysics;

        // ── Methods ──
        public void get_animatePhysics(){} // RVA: 0x7FFD4E4104C0
        public void Start(){} // RVA: 0x7FFD4E4105F0
        public void Update(){} // RVA: 0x7FFD4E4107B0
        public void FixedUpdate(){} // RVA: 0x7FFD4E4107E0
        public void LateUpdate(){} // RVA: 0x7FFD4E410810
        public void FixTransforms(){} // RVA: 0x7FFD4E4109A0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class IKMapping : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E426850
        public void Initiate(){} // RVA: 0x7FFD4E341310
        public void BoneIsValid(){} // RVA: 0x7FFD4E426860
        public void SolveFABRIKJoint(){} // RVA: 0x7FFD4E41F310
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class IKMappingBone : IKMapping
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E42A050
        public void .ctor(){} // RVA: 0x7FFD4E42A250 | overloaded x2
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E42A380
        public void FixTransforms(){} // RVA: 0x7FFD4E42A3A0
        public void Initiate(){} // RVA: 0x7FFD4E42A420
        public void ReadPose(){} // RVA: 0x7FFD4E42A580
        public void WritePose(){} // RVA: 0x7FFD4E42A5A0
    }

    public class IKMappingLimb : IKMapping
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E42A5D0
        public void GetBoneMap(){} // RVA: 0x7FFD4E42A670
        public void SetLimbOrientation(){} // RVA: 0x7FFD4E42A7B0
        public void .ctor(){} // RVA: 0x7FFD4E42B570 | overloaded x2
        public void SetBones(){} // RVA: 0x7FFD4E42B800
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E42B950
        public void FixTransforms(){} // RVA: 0x7FFD4E42BA60
        public void Initiate(){} // RVA: 0x7FFD4E42BCA0
        public void ReadPose(){} // RVA: 0x7FFD4E42C300
        public void WritePose(){} // RVA: 0x7FFD4E42C380
    }

    public class IKMappingSpine : IKMapping
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E42C5C0
        public void .ctor(){} // RVA: 0x7FFD4E42D040 | overloaded x2
        public void SetBones(){} // RVA: 0x7FFD4E42D340
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E42D4F0
        public void FixTransforms(){} // RVA: 0x7FFD4E42D660
        public void Initiate(){} // RVA: 0x7FFD4E42D6F0
        public void UseFABRIK(){} // RVA: 0x7FFD4E42E360
        public void ReadPose(){} // RVA: 0x7FFD4E42E390
        public void WritePose(){} // RVA: 0x7FFD4E42E7D0
        public void ForwardReach(){} // RVA: 0x7FFD4E42ECF0
        public void BackwardReach(){} // RVA: 0x7FFD4E42EF30
        public void MapToSolverPositions(){} // RVA: 0x7FFD4E42F160
    }

    public class IKSolver : Object
    {
        public object initiated;

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void Initiate(){} // RVA: 0x7FFD4E42F730
        public void Update(){} // RVA: 0x7FFD4E42F920
        public void GetIKPosition(){} // RVA: 0x7FFD4E35E8D0
        public void SetIKPosition(){} // RVA: 0x7FFD4E35E8F0
        public void GetIKPositionWeight(){} // RVA: 0x7FFD4E40E570
        public void SetIKPositionWeight(){} // RVA: 0x7FFD4E42F9A0
        public void GetRoot(){} // RVA: 0x7FFD4E3E20E0
        public void get_initiated(){} // RVA: 0x7FFD4E42F9D0
        public void set_initiated(){} // RVA: 0x7FFD4E42F9E0
        public void GetPoints(){} // RVA: 0x7FFD4E078E90
        public void GetPoint(){} // RVA: 0x7FFD4E078F40
        public void FixTransforms(){} // RVA: 0x7FFD4E090980
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E090980
        public void OnInitiate(){} // RVA: 0x7FFD4E090980
        public void OnUpdate(){} // RVA: 0x7FFD4E090980
        public void LogWarning(){} // RVA: 0x7FFD4E42F9F0
        public void ContainsDuplicateBone(){} // RVA: 0x7FFD4E42FAA0
        public void HierarchyIsValid(){} // RVA: 0x7FFD4E42FC70
        public void PreSolveBones(){} // RVA: 0x7FFD4E42FD00
        public void .ctor(){} // RVA: 0x7FFD4E4301A0
    }

    public class IKSolverAim : IKSolverHeuristic
    {
        public object transformAxis;
        public object transformPoleAxis;
        public object minBones;
        public object localDirection;

        // ── Methods ──
        public void GetAngle(){} // RVA: 0x7FFD4E4324C0
        public void get_transformAxis(){} // RVA: 0x7FFD4E4325D0
        public void get_transformPoleAxis(){} // RVA: 0x7FFD4E432840
        public void OnInitiate(){} // RVA: 0x7FFD4E432AB0
        public void OnUpdate(){} // RVA: 0x7FFD4E432F90
        public void get_minBones(){} // RVA: 0x7FFD4E433AF0
        public void Solve(){} // RVA: 0x7FFD4E433B00
        public void GetClampedIKPosition(){} // RVA: 0x7FFD4E433C50
        public void RotateToTarget(){} // RVA: 0x7FFD4E4341D0
        public void get_localDirection(){} // RVA: 0x7FFD4E435080
        public void .ctor(){} // RVA: 0x7FFD4E435190
    }

    public class IKSolverArm : IKSolver
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E435250
        public void SetChain(){} // RVA: 0x7FFD4E435940
        public void GetPoints(){} // RVA: 0x7FFD4E435B60
        public void GetPoint(){} // RVA: 0x7FFD4E435D10
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E436260
        public void FixTransforms(){} // RVA: 0x7FFD4E4362C0
        public void OnInitiate(){} // RVA: 0x7FFD4E436330
        public void OnUpdate(){} // RVA: 0x7FFD4E436450
        public void Solve(){} // RVA: 0x7FFD4E4364F0
        public void Read(){} // RVA: 0x7FFD4E436580
        public void Write(){} // RVA: 0x7FFD4E436DC0
        public void .ctor(){} // RVA: 0x7FFD4E437160
    }

    public class IKSolverCCD : IKSolverHeuristic
    {
        // ── Methods ──
        public void FadeOutBoneWeights(){} // RVA: 0x7FFD4E437690
        public void OnInitiate(){} // RVA: 0x7FFD4E437730
        public void OnUpdate(){} // RVA: 0x7FFD4E437880
        public void Solve(){} // RVA: 0x7FFD4E437D80
        public void .ctor(){} // RVA: 0x7FFD4E438C30
    }

    public class IKSolverFABRIK : IKSolverHeuristic
    {
        public object boneLengthCanBeZero;

        // ── Methods ──
        public void SolveForward(){} // RVA: 0x7FFD4E438C40
        public void SolveBackward(){} // RVA: 0x7FFD4E438CF0
        public void GetIKPosition(){} // RVA: 0x7FFD4E438DC0
        public void OnInitiate(){} // RVA: 0x7FFD4E438F20
        public void OnUpdate(){} // RVA: 0x7FFD4E4396A0
        public void get_boneLengthCanBeZero(){} // RVA: 0x7FFD4E341320
        public void SolveJoint(){} // RVA: 0x7FFD4E439B80
        public void OnPreSolve(){} // RVA: 0x7FFD4E439CD0
        public void OnPostSolve(){} // RVA: 0x7FFD4E43A420
        public void Solve(){} // RVA: 0x7FFD4E43A600
        public void ForwardReach(){} // RVA: 0x7FFD4E43A700
        public void SolverMove(){} // RVA: 0x7FFD4E43AA70
        public void SolverRotate(){} // RVA: 0x7FFD4E43AB00
        public void SolverRotateChildren(){} // RVA: 0x7FFD4E43AD00
        public void SolverMoveChildrenAroundPoint(){} // RVA: 0x7FFD4E43AEE0
        public void GetParentSolverRotation(){} // RVA: 0x7FFD4E43B1B0
        public void GetParentSolverPosition(){} // RVA: 0x7FFD4E43B450
        public void GetLimitedRotation(){} // RVA: 0x7FFD4E43B710
        public void LimitForward(){} // RVA: 0x7FFD4E43BAD0
        public void BackwardReach(){} // RVA: 0x7FFD4E43C1E0
        public void BackwardReachUnlimited(){} // RVA: 0x7FFD4E43C220
        public void BackwardReachLimited(){} // RVA: 0x7FFD4E43C470
        public void MapToSolverPositions(){} // RVA: 0x7FFD4E43D180
        public void MapToSolverPositionsLimited(){} // RVA: 0x7FFD4E43D350
        public void .ctor(){} // RVA: 0x7FFD4E43D4F0
    }

    public class IKSolverFABRIKRoot : IKSolver
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E43D610
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E43DF90
        public void FixTransforms(){} // RVA: 0x7FFD4E43E0A0
        public void OnInitiate(){} // RVA: 0x7FFD4E43E1A0
        public void IsRoot(){} // RVA: 0x7FFD4E43E3C0
        public void OnUpdate(){} // RVA: 0x7FFD4E43E470
        public void GetPoints(){} // RVA: 0x7FFD4E43E6E0
        public void GetPoint(){} // RVA: 0x7FFD4E43E790
        public void AddPointsToArray(){} // RVA: 0x7FFD4E43E830
        public void GetCentroid(){} // RVA: 0x7FFD4E43E9F0
        public void .ctor(){} // RVA: 0x7FFD4E43EDD0
    }

    public class IKSolverFullBody : IKSolver
    {
        // ── Methods ──
        public void GetEffector(){} // RVA: 0x7FFD4E43EE70
        public void GetChain(){} // RVA: 0x7FFD4E43F010
        public void GetChainIndex(){} // RVA: 0x7FFD4E43F060
        public void GetNode(){} // RVA: 0x7FFD4E43F240
        public void GetChainAndNodeIndexes(){} // RVA: 0x7FFD4E43F290
        public void GetPoints(){} // RVA: 0x7FFD4E43F470
        public void GetPoint(){} // RVA: 0x7FFD4E43F620
        public void IsValid(){} // RVA: 0x7FFD4E43F820
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E43FB00
        public void FixTransforms(){} // RVA: 0x7FFD4E43FD80
        public void OnInitiate(){} // RVA: 0x7FFD4E43FFA0
        public void OnUpdate(){} // RVA: 0x7FFD4E440140
        public void ReadPose(){} // RVA: 0x7FFD4E440370
        public void Solve(){} // RVA: 0x7FFD4E440890
        public void ApplyBendConstraints(){} // RVA: 0x7FFD4E440C00
        public void WritePose(){} // RVA: 0x7FFD4E440C40
        public void .ctor(){} // RVA: 0x7FFD4E440D70
    }

    public class IKSolverFullBodyBiped : IKSolverFullBody
    {
        public object bodyEffector;
        public object leftShoulderEffector;
        public object rightShoulderEffector;
        public object leftThighEffector;
        public object rightThighEffector;
        public object leftHandEffector;
        public object rightHandEffector;
        public object leftFootEffector;
        public object rightFootEffector;
        public object leftArmChain;
        public object rightArmChain;
        public object leftLegChain;
        public object rightLegChain;
        public object leftArmMapping;
        public object rightArmMapping;
        public object leftLegMapping;
        public object rightLegMapping;
        public object headMapping;
        public object pullBodyOffset;

        // ── Methods ──
        public void get_bodyEffector(){} // RVA: 0x7FFD4E441010
        public void get_leftShoulderEffector(){} // RVA: 0x7FFD4E441040
        public void get_rightShoulderEffector(){} // RVA: 0x7FFD4E441070
        public void get_leftThighEffector(){} // RVA: 0x7FFD4E4410A0
        public void get_rightThighEffector(){} // RVA: 0x7FFD4E4410D0
        public void get_leftHandEffector(){} // RVA: 0x7FFD4E441100
        public void get_rightHandEffector(){} // RVA: 0x7FFD4E441130
        public void get_leftFootEffector(){} // RVA: 0x7FFD4E441160
        public void get_rightFootEffector(){} // RVA: 0x7FFD4E441190
        public void get_leftArmChain(){} // RVA: 0x7FFD4E4411C0
        public void get_rightArmChain(){} // RVA: 0x7FFD4E4411F0
        public void get_leftLegChain(){} // RVA: 0x7FFD4E441220
        public void get_rightLegChain(){} // RVA: 0x7FFD4E441250
        public void get_leftArmMapping(){} // RVA: 0x7FFD4E441280
        public void get_rightArmMapping(){} // RVA: 0x7FFD4E4412B0
        public void get_leftLegMapping(){} // RVA: 0x7FFD4E4412E0
        public void get_rightLegMapping(){} // RVA: 0x7FFD4E441310
        public void get_headMapping(){} // RVA: 0x7FFD4E441340
        public void SetChainWeights(){} // RVA: 0x7FFD4E441370
        public void SetEffectorWeights(){} // RVA: 0x7FFD4E4413E0
        public void GetChain(){} // RVA: 0x7FFD4E441530 | overloaded x2
        public void GetEffector(){} // RVA: 0x7FFD4E441620
        public void GetEndEffector(){} // RVA: 0x7FFD4E441780
        public void GetLimbMapping(){} // RVA: 0x7FFD4E4418B0 | overloaded x2
        public void GetSpineMapping(){} // RVA: 0x7FFD4E409590
        public void GetHeadMapping(){} // RVA: 0x7FFD4E441340
        public void GetBendConstraint(){} // RVA: 0x7FFD4E441990
        public void IsValid(){} // RVA: 0x7FFD4E441A20
        public void SetToReferences(){} // RVA: 0x7FFD4E441D30
        public void DetectRootNodeBone(){} // RVA: 0x7FFD4E443DF0
        public void SetLimbOrientations(){} // RVA: 0x7FFD4E4444C0
        public void get_pullBodyOffset(){} // RVA: 0x7FFD4E3AC260
        public void set_pullBodyOffset(){} // RVA: 0x7FFD4E3AC280
        public void SetLimbOrientation(){} // RVA: 0x7FFD4E444530
        public void GetLeftClavicle(){} // RVA: 0x7FFD4E4447C0
        public void GetRightClavicle(){} // RVA: 0x7FFD4E444970
        public void Contains(){} // RVA: 0x7FFD4E444B20
        public void ReadPose(){} // RVA: 0x7FFD4E444C90
        public void PullBody(){} // RVA: 0x7FFD4E445100
        public void GetBodyOffset(){} // RVA: 0x7FFD4E4452E0
        public void GetHandBodyPull(){} // RVA: 0x7FFD4E4455C0
        public void ApplyBendConstraints(){} // RVA: 0x7FFD4E445800
        public void WritePose(){} // RVA: 0x7FFD4E445C60
        public void .ctor(){} // RVA: 0x7FFD4E445EB0
    }

    public class IKSolverHeuristic : IKSolver
    {
        public object minBones;
        public object boneLengthCanBeZero;
        public object allowCommonParent;
        public object localDirection;
        public object positionOffset;

        // ── Methods ──
        public void SetChain(){} // RVA: 0x7FFD4E445ED0
        public void AddBone(){} // RVA: 0x7FFD4E4460B0
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E446280
        public void FixTransforms(){} // RVA: 0x7FFD4E4463F0
        public void IsValid(){} // RVA: 0x7FFD4E446470
        public void GetPoints(){} // RVA: 0x7FFD4E409590
        public void GetPoint(){} // RVA: 0x7FFD4E446B10
        public void get_minBones(){} // RVA: 0x7FFD4E446CB0
        public void get_boneLengthCanBeZero(){} // RVA: 0x7FFD4E426850
        public void get_allowCommonParent(){} // RVA: 0x7FFD4E341320
        public void OnInitiate(){} // RVA: 0x7FFD4E341310
        public void OnUpdate(){} // RVA: 0x7FFD4E341310
        public void InitiateBones(){} // RVA: 0x7FFD4E446CC0
        public void get_localDirection(){} // RVA: 0x7FFD4E447580
        public void get_positionOffset(){} // RVA: 0x7FFD4E447790
        public void GetSingularityOffset(){} // RVA: 0x7FFD4E447800
        public void SingularityDetected(){} // RVA: 0x7FFD4E447D70
        public void .ctor(){} // RVA: 0x7FFD4E4480E0
    }

    public class IKSolverLeg : IKSolver
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E448190
        public void SetChain(){} // RVA: 0x7FFD4E435940
        public void GetPoints(){} // RVA: 0x7FFD4E448880
        public void GetPoint(){} // RVA: 0x7FFD4E448A30
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E436260
        public void FixTransforms(){} // RVA: 0x7FFD4E4362C0
        public void OnInitiate(){} // RVA: 0x7FFD4E448F80
        public void OnUpdate(){} // RVA: 0x7FFD4E4490A0
        public void Solve(){} // RVA: 0x7FFD4E4491A0
        public void Read(){} // RVA: 0x7FFD4E449290
        public void Write(){} // RVA: 0x7FFD4E449AC0
        public void .ctor(){} // RVA: 0x7FFD4E449E60
    }

    public class IKSolverLimb : IKSolverTrigonometric
    {
        public object axisDirections;

        // ── Methods ──
        public void MaintainRotation(){} // RVA: 0x7FFD4E44A390
        public void MaintainBend(){} // RVA: 0x7FFD4E44A430
        public void OnInitiateVirtual(){} // RVA: 0x7FFD4E44A480
        public void OnUpdateVirtual(){} // RVA: 0x7FFD4E44ACF0
        public void OnPostSolveVirtual(){} // RVA: 0x7FFD4E44AE50
        public void .ctor(){} // RVA: 0x7FFD4E44B130 | overloaded x2
        public void get_axisDirections(){} // RVA: 0x7FFD4E44B260
        public void StoreAxisDirections(){} // RVA: 0x7FFD4E44B280
        public void GetModifiedBendNormal(){} // RVA: 0x7FFD4E44B8D0
    }

    public class IKSolverLookAt : IKSolver
    {
        public object spineIsValid;
        public object spineIsEmpty;
        public object headIsValid;
        public object headIsEmpty;
        public object eyesIsValid;
        public object eyesIsEmpty;

        // ── Methods ──
        public void SetLookAtWeight(){} // RVA: 0x7FFD4E44D3A0 | overloaded x6
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E44D480
        public void FixTransforms(){} // RVA: 0x7FFD4E44D640
        public void IsValid(){} // RVA: 0x7FFD4E44D810
        public void GetPoints(){} // RVA: 0x7FFD4E44DD70
        public void GetPoint(){} // RVA: 0x7FFD4E44E190
        public void SetChain(){} // RVA: 0x7FFD4E44E530
        public void OnInitiate(){} // RVA: 0x7FFD4E44E630
        public void OnUpdate(){} // RVA: 0x7FFD4E44ECC0
        public void get_spineIsValid(){} // RVA: 0x7FFD4E44EE50
        public void get_spineIsEmpty(){} // RVA: 0x7FFD4E44EFB0
        public void SolveSpine(){} // RVA: 0x7FFD4E44EFD0
        public void get_headIsValid(){} // RVA: 0x7FFD4E44F2E0
        public void get_headIsEmpty(){} // RVA: 0x7FFD4E44F2F0
        public void SolveHead(){} // RVA: 0x7FFD4E44F3D0
        public void get_eyesIsValid(){} // RVA: 0x7FFD4E44F870
        public void get_eyesIsEmpty(){} // RVA: 0x7FFD4E44F9D0
        public void SolveEyes(){} // RVA: 0x7FFD4E44F9F0
        public void GetForwards(){} // RVA: 0x7FFD4E4502E0
        public void SetBones(){} // RVA: 0x7FFD4E4506E0
        public void .ctor(){} // RVA: 0x7FFD4E450930
    }

    public class IKSolverTrigonometric : IKSolver
    {
        // ── Methods ──
        public void SetBendGoalPosition(){} // RVA: 0x7FFD4E451790
        public void SetBendPlaneToCurrent(){} // RVA: 0x7FFD4E451AA0
        public void SetIKRotation(){} // RVA: 0x7FFD4E451DC0
        public void SetIKRotationWeight(){} // RVA: 0x7FFD4E451DD0
        public void GetIKRotation(){} // RVA: 0x7FFD4E451E00
        public void GetIKRotationWeight(){} // RVA: 0x7FFD4E451E10
        public void GetPoints(){} // RVA: 0x7FFD4E451E20
        public void GetPoint(){} // RVA: 0x7FFD4E451F50
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E4522A0
        public void FixTransforms(){} // RVA: 0x7FFD4E4522F0
        public void IsValid(){} // RVA: 0x7FFD4E452350
        public void SetChain(){} // RVA: 0x7FFD4E452AD0
        public void Solve(){} // RVA: 0x7FFD4E452C30
        public void GetDirectionToBendPoint(){} // RVA: 0x7FFD4E4538E0
        public void OnInitiate(){} // RVA: 0x7FFD4E453CC0
        public void IsDirectHierarchy(){} // RVA: 0x7FFD4E454040
        public void InitiateBones(){} // RVA: 0x7FFD4E454330
        public void OnUpdate(){} // RVA: 0x7FFD4E4544E0
        public void OnInitiateVirtual(){} // RVA: 0x7FFD4E341310
        public void OnUpdateVirtual(){} // RVA: 0x7FFD4E341310
        public void OnPostSolveVirtual(){} // RVA: 0x7FFD4E341310
        public void GetBendDirection(){} // RVA: 0x7FFD4E455450
        public void .ctor(){} // RVA: 0x7FFD4E4559C0
    }

    public class IKSolverVR : IKSolver
    {
        public object rootBone;

        // ── Methods ──
        public void SetToReferences(){} // RVA: 0x7FFD4E4564F0
        public void GuessHandOrientations(){} // RVA: 0x7FFD4E456C90
        public void DefaultAnimationCurves(){} // RVA: 0x7FFD4E4570F0
        public void AddPositionOffset(){} // RVA: 0x7FFD4E4574A0
        public void AddRotationOffset(){} // RVA: 0x7FFD4E4577F0 | overloaded x2
        public void AddPlatformMotion(){} // RVA: 0x7FFD4E457BE0
        public void Reset(){} // RVA: 0x7FFD4E458020
        public void StoreDefaultLocalState(){} // RVA: 0x7FFD4E458350
        public void FixTransforms(){} // RVA: 0x7FFD4E4585E0
        public void GetPoints(){} // RVA: 0x7FFD4E4588E0
        public void GetPoint(){} // RVA: 0x7FFD4E458940
        public void IsValid(){} // RVA: 0x7FFD4E4589A0
        public void GetNormal(){} // RVA: 0x7FFD4E458D50
        public void GuessWristToPalmAxis(){} // RVA: 0x7FFD4E459210
        public void GuessPalmToThumbAxis(){} // RVA: 0x7FFD4E4595E0
        public void GetSineKeyframes(){} // RVA: 0x7FFD4E459F10
        public void UpdateSolverTransforms(){} // RVA: 0x7FFD4E459FA0
        public void OnInitiate(){} // RVA: 0x7FFD4E45A220
        public void OnUpdate(){} // RVA: 0x7FFD4E45A280
        public void WriteTransforms(){} // RVA: 0x7FFD4E45AD10
        public void Read(){} // RVA: 0x7FFD4E45B8D0
        public void Solve(){} // RVA: 0x7FFD4E45C450
        public void GetPosition(){} // RVA: 0x7FFD4E45E070
        public void GetRotation(){} // RVA: 0x7FFD4E45E0C0
        public void get_rootBone(){} // RVA: 0x7FFD4E45E100
        public void set_rootBone(){} // RVA: 0x7FFD4E45E110
        public void VrcRead(){} // RVA: 0x7FFD4E45A220
        public void VrcWrite(){} // RVA: 0x7FFD4E45E170
        public void VrcWriteTransforms(){} // RVA: 0x7FFD4E45E180
        public void VrcSyncIk(){} // RVA: 0x7FFD4E45E190
        public void VrcLateSolve(){} // RVA: 0x7FFD4E45E1B0
        public void Write(){} // RVA: 0x7FFD4E45E210
        public void GetPelvisOffset(){} // RVA: 0x7FFD4E45E3A0
        public void .ctor(){} // RVA: 0x7FFD4E45EE80
    }

    public class Inertia : OffsetModifier
    {
        // ── Methods ──
        public void ResetBodies(){} // RVA: 0x7FFD4E4B1D60
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4B1E00
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class InteractionEffector : Object
    {
        public object effectorType;
        public object isPaused;
        public object interactionObject;
        public object inInteraction;
        public object progress;

        // ── Methods ──
        public void get_effectorType(){} // RVA: 0x7FFD4E38E5C0
        public void set_effectorType(){} // RVA: 0x7FFD4E3440C0
        public void get_isPaused(){} // RVA: 0x7FFD4E490BD0
        public void set_isPaused(){} // RVA: 0x7FFD4E490BE0
        public void get_interactionObject(){} // RVA: 0x7FFD4E3447C0
        public void set_interactionObject(){} // RVA: 0x7FFD4E3A7E80
        public void get_inInteraction(){} // RVA: 0x7FFD4E490BF0
        public void .ctor(){} // RVA: 0x7FFD4E490CC0
        public void Initiate(){} // RVA: 0x7FFD4E490D90
        public void StoreDefaults(){} // RVA: 0x7FFD4E490F50
        public void ResetToDefaults(){} // RVA: 0x7FFD4E491140
        public void Pause(){} // RVA: 0x7FFD4E491600
        public void Resume(){} // RVA: 0x7FFD4E491960
        public void Start(){} // RVA: 0x7FFD4E4919C0
        public void Update(){} // RVA: 0x7FFD4E4923F0
        public void get_progress(){} // RVA: 0x7FFD4E493010
        public void TriggerUntriggeredEvents(){} // RVA: 0x7FFD4E493050
        public void PickUp(){} // RVA: 0x7FFD4E493370
        public void Stop(){} // RVA: 0x7FFD4E493740
        public void OnPostFBBIK(){} // RVA: 0x7FFD4E493B30
    }

    public class InteractionLookAt : Object
    {
        // ── Methods ──
        public void Look(){} // RVA: 0x7FFD4E494120
        public void OnFixTransforms(){} // RVA: 0x7FFD4E494380
        public void Update(){} // RVA: 0x7FFD4E494480
        public void SolveSpine(){} // RVA: 0x7FFD4E494910
        public void SolveHead(){} // RVA: 0x7FFD4E494AA0
        public void .ctor(){} // RVA: 0x7FFD4E494BE0
    }

    public class InteractionObject : MonoBehaviour
    {
        public object length;
        public object lastUsedInteractionSystem;
        public object lookAtTarget;
        public object targetsRoot;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial1(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial2(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial3(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial4(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void get_length(){} // RVA: 0x7FFD4E3A9460
        public void set_length(){} // RVA: 0x7FFD4E3A9470
        public void get_lastUsedInteractionSystem(){} // RVA: 0x7FFD4E409500
        public void set_lastUsedInteractionSystem(){} // RVA: 0x7FFD4E409510
        public void Initiate(){} // RVA: 0x7FFD4E494BF0
        public void get_lookAtTarget(){} // RVA: 0x7FFD4E494EB0
        public void GetTarget(){} // RVA: 0x7FFD4E496830 | overloaded x3
        public void CurveUsed(){} // RVA: 0x7FFD4E4951C0
        public void GetTargets(){} // RVA: 0x7FFD4E3DF370
        public void OnStartInteraction(){} // RVA: 0x7FFD4E409510
        public void Apply(){} // RVA: 0x7FFD4E495F70 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFD4E495AC0
        public void get_targetsRoot(){} // RVA: 0x7FFD4E495E40
        public void Start(){} // RVA: 0x7FFD4E495F60
        public void GetWeightCurveIndex(){} // RVA: 0x7FFD4E4968E0
        public void GetMultiplierIndex(){} // RVA: 0x7FFD4E496940
        public void .ctor(){} // RVA: 0x7FFD4E4969A0
    }

    public class InteractionSystem : MonoBehaviour
    {
        public object inInteraction;
        public object ik;
        public object triggersInRange;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial1(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial2(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial3(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial4(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void get_inInteraction(){} // RVA: 0x7FFD4E4973C0
        public void IsInInteraction(){} // RVA: 0x7FFD4E497480
        public void IsPaused(){} // RVA: 0x7FFD4E497620 | overloaded x2
        public void IsInSync(){} // RVA: 0x7FFD4E4976E0
        public void StartInteraction(){} // RVA: 0x7FFD4E497810
        public void PauseInteraction(){} // RVA: 0x7FFD4E497980
        public void ResumeInteraction(){} // RVA: 0x7FFD4E497A10
        public void StopInteraction(){} // RVA: 0x7FFD4E497AA0
        public void PauseAll(){} // RVA: 0x7FFD4E497B30
        public void ResumeAll(){} // RVA: 0x7FFD4E497BB0
        public void StopAll(){} // RVA: 0x7FFD4E497C90
        public void GetInteractionObject(){} // RVA: 0x7FFD4E497D10
        public void GetProgress(){} // RVA: 0x7FFD4E497DA0
        public void GetMinActiveProgress(){} // RVA: 0x7FFD4E497E40
        public void TriggerInteraction(){} // RVA: 0x7FFD4E498400 | overloaded x3
        public void GetClosestInteractionRange(){} // RVA: 0x7FFD4E4987A0
        public void GetClosestInteractionObjectInRange(){} // RVA: 0x7FFD4E498890
        public void GetClosestInteractionTargetInRange(){} // RVA: 0x7FFD4E4988E0
        public void GetClosestInteractionObjectsInRange(){} // RVA: 0x7FFD4E498950
        public void GetClosestInteractionTargetsInRange(){} // RVA: 0x7FFD4E498AE0
        public void TriggerEffectorsReady(){} // RVA: 0x7FFD4E498C90
        public void GetTriggerRange(){} // RVA: 0x7FFD4E498FE0
        public void GetClosestTriggerIndex(){} // RVA: 0x7FFD4E499160
        public void get_ik(){} // RVA: 0x7FFD4E499460
        public void set_ik(){} // RVA: 0x7FFD4E499470
        public void get_triggersInRange(){} // RVA: 0x7FFD4E3E20E0
        public void set_triggersInRange(){} // RVA: 0x7FFD4E4994D0
        public void Start(){} // RVA: 0x7FFD4E499530
        public void InteractionPause(){} // RVA: 0x7FFD4E49A030
        public void InteractionResume(){} // RVA: 0x7FFD4E49A050
        public void InteractionStop(){} // RVA: 0x7FFD4E49A050
        public void LookAtInteraction(){} // RVA: 0x7FFD4E49A070
        public void OnTriggerEnter(){} // RVA: 0x7FFD4E49A210
        public void OnTriggerExit(){} // RVA: 0x7FFD4E49A440
        public void ContactIsInRange(){} // RVA: 0x7FFD4E49A610
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD4E49A8A0
        public void Update(){} // RVA: 0x7FFD4E49AB60
        public void Raycasting(){} // RVA: 0x7FFD4E49AEE0
        public void UpdateTriggerEventBroadcasting(){} // RVA: 0x7FFD4E49B150
        public void UpdateEffectors(){} // RVA: 0x7FFD4E49B8D0
        public void OnPreFBBIK(){} // RVA: 0x7FFD4E49BAD0
        public void OnPostFBBIK(){} // RVA: 0x7FFD4E49BD40
        public void OnFixTransforms(){} // RVA: 0x7FFD4E49BFB0
        public void OnDestroy(){} // RVA: 0x7FFD4E49C0C0
        public void IsValid(){} // RVA: 0x7FFD4E49C8B0
        public void TriggerIndexIsValid(){} // RVA: 0x7FFD4E49CA40
        public void .ctor(){} // RVA: 0x7FFD4E49CC20
    }

    public class InteractionTarget : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial1(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial2(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial3(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial4(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetValue(){} // RVA: 0x7FFD4E49D590
        public void ResetRotation(){} // RVA: 0x7FFD4E49D600
        public void RotateTo(){} // RVA: 0x7FFD4E49D730
        public void .ctor(){} // RVA: 0x7FFD4E49E540
    }

    public class InteractionTrigger : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OpenTutorial4(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void Start(){} // RVA: 0x7FFD4E341310
        public void GetBestRangeIndex(){} // RVA: 0x7FFD4E49E5E0
        public void .ctor(){} // RVA: 0x7FFD4E49E900
    }

    public class LegIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BE740
        public void .ctor(){} // RVA: 0x7FFD4E410B20
    }

    public class LimbIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BE740
        public void .ctor(){} // RVA: 0x7FFD4E410C00
    }

    public class LookAtController : MonoBehaviour
    {
        public object pivot;

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E4B2790
        public void LateUpdate(){} // RVA: 0x7FFD4E4B2850
        public void get_pivot(){} // RVA: 0x7FFD4E4B3470
        public void ApplyMinDistance(){} // RVA: 0x7FFD4E4B3800
        public void RootRotation(){} // RVA: 0x7FFD4E4B39C0
        public void .ctor(){} // RVA: 0x7FFD4E4B4070
    }

    public class LookAtIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BE740
        public void .ctor(){} // RVA: 0x7FFD4E410CE0
    }

    public class OffsetModifier : MonoBehaviour
    {
        public object deltaTime;

        // ── Methods ──
        public void get_deltaTime(){} // RVA: 0x7FFD4E4B4140
        public void OnModifyOffset(){} // RVA: 0x7FFD4E090980
        public void Start(){} // RVA: 0x7FFD4E4B41A0
        public void Initiate(){} // RVA: 0x7FFD4E4B4250
        public void ModifyOffset(){} // RVA: 0x7FFD4E4B42F0
        public void ApplyLimits(){} // RVA: 0x7FFD4E4B44C0
        public void OnDestroy(){} // RVA: 0x7FFD4E4B4630
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class OffsetModifierVRIK : MonoBehaviour
    {
        public object deltaTime;

        // ── Methods ──
        public void get_deltaTime(){} // RVA: 0x7FFD4E4B4140
        public void OnModifyOffset(){} // RVA: 0x7FFD4E090980
        public void Start(){} // RVA: 0x7FFD4E4B50E0
        public void Initiate(){} // RVA: 0x7FFD4E4B5190
        public void ModifyOffset(){} // RVA: 0x7FFD4E4B5230
        public void OnDestroy(){} // RVA: 0x7FFD4E4B5400
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class OffsetPose : MonoBehaviour
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFD4E4B5A60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E4B5B20
    }

    public class PenetrationAvoidance : OffsetModifier
    {
        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4B6190
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class Poser : SolverManager
    {
        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x7FFD4E090980
        public void UpdateManual(){} // RVA: 0x7FFD4E4A21C0
        public void InitiatePoser(){} // RVA: 0x7FFD4E090980
        public void UpdatePoser(){} // RVA: 0x7FFD4E090980
        public void FixPoserTransforms(){} // RVA: 0x7FFD4E090980
        public void UpdateSolver(){} // RVA: 0x7FFD4E4A21E0
        public void InitiateSolver(){} // RVA: 0x7FFD4E4A2230
        public void FixTransforms(){} // RVA: 0x7FFD4E4A2260
        public void .ctor(){} // RVA: 0x7FFD4E4A0D50
    }

    public class RagdollUtility : MonoBehaviour
    {
        public object isRagdoll;
        public object ikUsed;

        // ── Methods ──
        public void EnableRagdoll(){} // RVA: 0x7FFD4E4A2280
        public void DisableRagdoll(){} // RVA: 0x7FFD4E4A22E0
        public void Start(){} // RVA: 0x7FFD4E4A23F0
        public void DisableRagdollSmooth(){} // RVA: 0x7FFD4E4A2E90
        public void Update(){} // RVA: 0x7FFD4E4A2F30
        public void FixedUpdate(){} // RVA: 0x7FFD4E4A3240
        public void LateUpdate(){} // RVA: 0x7FFD4E4A3280
        public void AfterLastIK(){} // RVA: 0x7FFD4E4A33C0
        public void AfterAnimation(){} // RVA: 0x7FFD4E4A3410
        public void OnFinalPose(){} // RVA: 0x7FFD4E4A3450
        public void RagdollEnabler(){} // RVA: 0x7FFD4E4A3490
        public void get_isRagdoll(){} // RVA: 0x7FFD4E4A3800
        public void RecordVelocities(){} // RVA: 0x7FFD4E4A38F0
        public void get_ikUsed(){} // RVA: 0x7FFD4E4A3BD0
        public void StoreLocalState(){} // RVA: 0x7FFD4E4A3E00
        public void FixTransforms(){} // RVA: 0x7FFD4E4A3F50
        public void OnDestroy(){} // RVA: 0x7FFD4E4A4310
        public void .ctor(){} // RVA: 0x7FFD4E4A4520
    }

    public class Recoil : OffsetModifier
    {
        public object isFinished;
        public object primaryHandEffector;
        public object secondaryHandEffector;
        public object primaryHand;
        public object secondaryHand;

        // ── Methods ──
        public void get_isFinished(){} // RVA: 0x7FFD4E4B6B60
        public void SetHandRotations(){} // RVA: 0x7FFD4E4B6BC0
        public void Fire(){} // RVA: 0x7FFD4E4B6BF0
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4B6F50
        public void AfterFBBIK(){} // RVA: 0x7FFD4E4B85D0
        public void AfterAimIK(){} // RVA: 0x7FFD4E4B8930
        public void get_primaryHandEffector(){} // RVA: 0x7FFD4E4B8980
        public void get_secondaryHandEffector(){} // RVA: 0x7FFD4E4B89F0
        public void get_primaryHand(){} // RVA: 0x7FFD4E4B8A60
        public void get_secondaryHand(){} // RVA: 0x7FFD4E4B8A80
        public void OnDestroy(){} // RVA: 0x7FFD4E4B8AA0
        public void .ctor(){} // RVA: 0x7FFD4E4B8E10
    }

    public class RotationLimit : MonoBehaviour
    {
        public object secondaryAxis;
        public object crossAxis;
        public object defaultLocalRotationOverride;

        // ── Methods ──
        public void SetDefaultLocalRotation(){} // RVA: 0x7FFD4E4A5E10 | overloaded x2
        public void GetLimitedLocalRotation(){} // RVA: 0x7FFD4E4A5E20
        public void Apply(){} // RVA: 0x7FFD4E4A61F0
        public void Disable(){} // RVA: 0x7FFD4E4A63A0
        public void get_secondaryAxis(){} // RVA: 0x7FFD4E4A6440
        public void get_crossAxis(){} // RVA: 0x7FFD4E4A6460
        public void get_defaultLocalRotationOverride(){} // RVA: 0x7FFD4E4A64E0
        public void set_defaultLocalRotationOverride(){} // RVA: 0x7FFD4E4A64F0
        public void LimitRotation(){}
        public void Awake(){} // RVA: 0x7FFD4E4A6500
        public void LateUpdate(){} // RVA: 0x7FFD4E4A66C0
        public void LogWarning(){} // RVA: 0x7FFD4E3F66F0
        public void Limit1DOF(){} // RVA: 0x7FFD4E4A66D0
        public void LimitTwist(){} // RVA: 0x7FFD4E4A6A20
        public void GetOrthogonalAngle(){} // RVA: 0x7FFD4E4A7030
        public void .ctor(){} // RVA: 0x7FFD4E4A7110
    }

    public class RotationLimitAngle : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void LimitRotation(){} // RVA: 0x7FFD4E4A71A0
        public void LimitSwing(){} // RVA: 0x7FFD4E4A7250
        public void .ctor(){} // RVA: 0x7FFD4E4A76D0
    }

    public class RotationLimitHinge : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void LimitRotation(){} // RVA: 0x7FFD4E4A76F0
        public void LimitHinge(){} // RVA: 0x7FFD4E4A7740
        public void .ctor(){} // RVA: 0x7FFD4E4A7C20
    }

    public class RotationLimitPolygonal : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void SetLimitPoints(){} // RVA: 0x7FFD4E4A7C80
        public void LimitRotation(){} // RVA: 0x7FFD4E4A7D40
        public void Start(){} // RVA: 0x7FFD4E4A7E20
        public void ResetToDefault(){} // RVA: 0x7FFD4E4A8040
        public void BuildReachCones(){} // RVA: 0x7FFD4E4A8E60
        public void SmoothPoints(){} // RVA: 0x7FFD4E4A9620
        public void GetScalar(){} // RVA: 0x7FFD4E4A9D50
        public void PointToTangentPlane(){} // RVA: 0x7FFD4E4A9DA0
        public void TangentPointToSphere(){} // RVA: 0x7FFD4E4A9E90
        public void LimitSwing(){} // RVA: 0x7FFD4E4A9FB0
        public void GetReachCone(){} // RVA: 0x7FFD4E4AA5C0
        public void .ctor(){} // RVA: 0x7FFD4E4AA720
    }

    public class RotationLimitSpline : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void SetSpline(){} // RVA: 0x7FFD4E4AAE20
        public void LimitRotation(){} // RVA: 0x7FFD4E4AAE90
        public void LimitSwing(){} // RVA: 0x7FFD4E4AAF40
        public void .ctor(){} // RVA: 0x7FFD4E4AB570
    }

    public class ShoulderRotator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E4B9490
        public void RotateShoulders(){} // RVA: 0x7FFD4E4B9660
        public void RotateShoulder(){} // RVA: 0x7FFD4E4B97C0
        public void GetParentBoneMap(){} // RVA: 0x7FFD4E4B9E90
        public void OnDestroy(){} // RVA: 0x7FFD4E4B9FC0
        public void .ctor(){} // RVA: 0x7FFD4E4BA1C0
    }

    public class TrigonometricIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void SupportGroup(){} // RVA: 0x7FFD4E341310
        public void ASThread(){} // RVA: 0x7FFD4E341310
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BE740
        public void .ctor(){} // RVA: 0x7FFD4E410DC0
    }

    public class TwistRelaxer : MonoBehaviour
    {
        // ── Methods ──
        public void Relax(){} // RVA: 0x7FFD4E48EA40
        public void Init(){} // RVA: 0x7FFD4E48FBA0
        public void Start(){} // RVA: 0x7FFD4E48FBB0
        public void OnPostUpdate(){} // RVA: 0x7FFD4E490720
        public void LateUpdate(){} // RVA: 0x7FFD4E490800
        public void OnDestroy(){} // RVA: 0x7FFD4E4908E0
        public void .ctor(){} // RVA: 0x7FFD4E490AF0
    }

    public class VRIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFD4E341310
        public void OpenScriptReference(){} // RVA: 0x7FFD4E341310
        public void OpenSetupTutorial(){} // RVA: 0x7FFD4E341310
        public void AutoDetectReferences(){} // RVA: 0x7FFD4E410EA0
        public void GuessHandOrientations(){} // RVA: 0x7FFD4E410F00
        public void GetIKSolver(){} // RVA: 0x7FFD4E3BC730
        public void InternalInitiateSolver(){} // RVA: 0x7FFD4E410F30
        public void InitiateSolver(){} // RVA: 0x7FFD4E411010
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFD4E3FB8F0
        public void VRCInitiateSolver(){} // RVA: 0x7FFD4E411020
        public void UpdateSolver(){} // RVA: 0x7FFD4E411030
        public void .ctor(){} // RVA: 0x7FFD4E411330
    }

    public class VRIKCalibrator : Object
    {
        // ── Methods ──
        public void RecalibrateScale(){} // RVA: 0x7FFD4E4BA220
        public void Calibrate(){} // RVA: 0x7FFD4E4BE160 | overloaded x2
        public void CalibrateLeg(){} // RVA: 0x7FFD4E4BF370 | overloaded x2
    }

    public class VRIKLODController : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E4BFCA0
        public void Update(){} // RVA: 0x7FFD4E4BFD30
        public void GetLODLevel(){} // RVA: 0x7FFD4E4BFD70
        public void .ctor(){} // RVA: 0x7FFD4E4C00B0
    }

    public class VRIKRootController : MonoBehaviour
    {
        public object pelvisTargetRight;

        // ── Methods ──
        public void get_pelvisTargetRight(){} // RVA: 0x7FFD4E3A7EE0
        public void set_pelvisTargetRight(){} // RVA: 0x7FFD4E3A7F00
        public void Awake(){} // RVA: 0x7FFD4E4C0100
        public void Calibrate(){} // RVA: 0x7FFD4E4C07A0 | overloaded x2
        public void OnPreUpdate(){} // RVA: 0x7FFD4E4C0B60
        public void OnDestroy(){} // RVA: 0x7FFD4E4C1700
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}