// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 88
// Methods: 983

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class AimController : MonoBehaviour
    {
        public RootMotion.FinalIK.AimIK ik; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81265580
        public void LateUpdate(){} // RVA: 0x7FFE812656B0
        public void get_pivot(){} // RVA: 0x7FFE81266480
        public void ApplyMinDistance(){} // RVA: 0x7FFE81266810
        public void RootRotation(){} // RVA: 0x7FFE812669D0
        public void TurnToTarget(){} // RVA: 0x7FFE812670D0
        public void .ctor(){} // RVA: 0x7FFE81267170
    }

    public class AimIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OpenSetupTutorial(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetIKSolver(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE811C8E20
    }

    public class AimPoser : MonoBehaviour
    {
        // ── Methods ──
        public void GetPose(){} // RVA: 0x7FFE812673E0
        public void SetPoseActive(){} // RVA: 0x7FFE812674F0
        public void .ctor(){} // RVA: 0x7FFE81267570
    }

    public class Amplifier : OffsetModifier
    {
        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFE812679B0
        public void .ctor(){} // RVA: 0x7FFE81103920
    }

    public class ArmIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetIKSolver(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE811C8F00
    }

    public class BipedIK : SolverManager
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetIKPositionWeight(){} // RVA: 0x7FFE811AF760
        public void GetIKRotationWeight(){} // RVA: 0x7FFE811AF790
        public void SetIKPositionWeight(){} // RVA: 0x7FFE811AF7C0
        public void SetIKRotationWeight(){} // RVA: 0x7FFE811AF820
        public void SetIKPosition(){} // RVA: 0x7FFE811AF880
        public void SetIKRotation(){} // RVA: 0x7FFE811AF8C0
        public void GetIKPosition(){} // RVA: 0x7FFE811AF8F0
        public void GetIKRotation(){} // RVA: 0x7FFE811AF950
        public void SetLookAtWeight(){} // RVA: 0x7FFE811AF990
        public void SetLookAtPosition(){} // RVA: 0x7FFE811AFAA0
        public void SetSpinePosition(){} // RVA: 0x7FFE811AFAD0
        public void SetSpineWeight(){} // RVA: 0x7FFE811AFB00
        public void GetGoalIK(){} // RVA: 0x7FFE811AFB50
        public void InitiateBipedIK(){} // RVA: 0x7FFE811AFBC0
        public void UpdateBipedIK(){} // RVA: 0x7FFE811AFBE0
        public void SetToDefaults(){} // RVA: 0x7FFE811AFC00
        public void FixTransforms(){} // RVA: 0x7FFE811AFDB0
        public void InitiateSolver(){} // RVA: 0x7FFE811AFE80
        public void UpdateSolver(){} // RVA: 0x7FFE811B02A0
        public void LogWarning(){} // RVA: 0x7FFE811B06F0
        public void .ctor(){} // RVA: 0x7FFE811B0760
    }

    public class BipedIKSolvers : Object
    {
        public RootMotion.FinalIK.IKSolverLimb leftFoot; // 0x10
        public RootMotion.FinalIK.IKSolverLimb rightFoot; // 0x18

        // ── Methods ──
        public void get_limbs(){} // RVA: 0x7FFE811B08E0
        public void get_ikSolvers(){} // RVA: 0x7FFE811B0AB0
        public void AssignReferences(){} // RVA: 0x7FFE811B0D40
        public void .ctor(){} // RVA: 0x7FFE811B0FB0
    }

    public class BodyTilt : OffsetModifier
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81268220
        public void OnModifyOffset(){} // RVA: 0x7FFE81268330
        public void .ctor(){} // RVA: 0x7FFE812686E0
    }

    public class CCDIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetIKSolver(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE811C8FE0
    }

    public class Constraint : Object
    {
        public UnityEngine.Transform transform; // 0x10

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFE811B13B0
        public void UpdateConstraint(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ConstraintPosition : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFE811B1480
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
    }

    public class ConstraintPositionOffset : Constraint
    {
        public UnityEngine.Vector3 offset; // 0x20

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFE811B15F0
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_positionChanged(){} // RVA: 0x7FFE811B1A20
    }

    public class ConstraintRotation : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFE811B1AF0
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
    }

    public class ConstraintRotationOffset : Constraint
    {
        public UnityEngine.Quaternion offset; // 0x20

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFE811B1C70
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_rotationChanged(){} // RVA: 0x7FFE811B20B0
    }

    public class Constraints : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811B2180
        public void Initiate(){} // RVA: 0x7FFE811B2250
        public void Update(){} // RVA: 0x7FFE811B23B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EditorIK : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81268740
        public void Update(){} // RVA: 0x7FFE81268860
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class FABRIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetIKSolver(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE811C90C0
    }

    public class FABRIKChain : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811CDB50
        public void Initiate(){} // RVA: 0x7FFE811CDCE0
        public void Stage1(){} // RVA: 0x7FFE811CDD40
        public void Stage2(){} // RVA: 0x7FFE811CDF10
        public void GetCentroid(){} // RVA: 0x7FFE811CE150
        public void .ctor(){} // RVA: 0x7FFE811CE410
    }

    public class FABRIKRoot : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetIKSolver(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE811C91A0
    }

    public class FBBIKArmBending : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFE811CE4B0
        public void OnPostFBBIK(){} // RVA: 0x7FFE811CEFB0
        public void OnDestroy(){} // RVA: 0x7FFE811CF490
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class FBBIKHeadEffector : MonoBehaviour
    {
        // ── Methods ──
        public void VRCInitialize(){} // RVA: 0x7FFE811CF690
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFE811CF6A0
        public void Start(){} // RVA: 0x7FFE811CF6B0
        public void Initialize(){} // RVA: 0x7FFE811CF6D0
        public void OnStoreDefaultLocalState(){} // RVA: 0x7FFE811CFF70
        public void OnFixTransforms(){} // RVA: 0x7FFE811D09E0
        public void OnPreRead(){} // RVA: 0x7FFE811D12D0
        public void SpineBend(){} // RVA: 0x7FFE811D21C0
        public void CCDPass(){} // RVA: 0x7FFE811D2AD0
        public void Iterate(){} // RVA: 0x7FFE811D3360
        public void OnPostUpdate(){} // RVA: 0x7FFE811D4350
        public void ChestDirection(){} // RVA: 0x7FFE811D4960
        public void PostStretching(){} // RVA: 0x7FFE811D4EA0
        public void LerpSolverPosition(){} // RVA: 0x7FFE811D54D0
        public void Solve(){} // RVA: 0x7FFE811D5670
        public void OnDestroy(){} // RVA: 0x7FFE811D57B0
        public void .ctor(){} // RVA: 0x7FFE811D5E00
    }

    public class FBIKChain : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811D6710 | overloaded x2
        public void SetNodes(){} // RVA: 0x7FFE811D6A00
        public void GetNodeIndex(){} // RVA: 0x7FFE811D6C50
        public void IsValid(){} // RVA: 0x7FFE811D6DE0
        public void Initiate(){} // RVA: 0x7FFE811D6FA0
        public void ReadPose(){} // RVA: 0x7FFE811D7220
        public void CalculateBoneLengths(){} // RVA: 0x7FFE811D78C0
        public void Reach(){} // RVA: 0x7FFE811D7FB0
        public void Push(){} // RVA: 0x7FFE811D8310
        public void SolveTrigonometric(){} // RVA: 0x7FFE811D8700
        public void Stage1(){} // RVA: 0x7FFE811D8A70
        public void Stage2(){} // RVA: 0x7FFE811D8F50
        public void SolveConstraintSystems(){} // RVA: 0x7FFE811D91C0
        public void SolveFABRIKJoint(){} // RVA: 0x7FFE811D9310
        public void GetDirToBendPoint(){} // RVA: 0x7FFE811D9450
        public void SolveChildConstraints(){} // RVA: 0x7FFE811D9840
        public void SolveLinearConstraint(){} // RVA: 0x7FFE811D9B90
        public void ForwardReach(){} // RVA: 0x7FFE811D9D20
        public void BackwardReach(){} // RVA: 0x7FFE811D9F50
    }

    public class Finger : Object
    {
        public float weight; // 0x10
        public float rotationWeight; // 0x14
        public 0x665B885C rotationDOF; // 0x18

        // ── Methods ──
        public void get_initiated(){} // RVA: 0x7FFE811B2D30
        public void set_initiated(){} // RVA: 0x7FFE811B2D40
        public void get_IKPosition(){} // RVA: 0x7FFE811B2D50
        public void set_IKPosition(){} // RVA: 0x7FFE811B2D80
        public void get_IKRotation(){} // RVA: 0x7FFE811B2DB0
        public void set_IKRotation(){} // RVA: 0x7FFE811B2DE0
        public void IsValid(){} // RVA: 0x7FFE811B2E00
        public void Initiate(){} // RVA: 0x7FFE811B3080
        public void FixTransforms(){} // RVA: 0x7FFE811B4230
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE811B4410
        public void Update(){} // RVA: 0x7FFE811B45F0
        public void .ctor(){} // RVA: 0x7FFE811B58D0
    }

    public class FingerRig : SolverManager
    {
        public float weight; // 0x40

        // ── Methods ──
        public void get_initiated(){} // RVA: 0x7FFE811B58E0
        public void set_initiated(){} // RVA: 0x7FFE811B58F0
        public void IsValid(){} // RVA: 0x7FFE811B5900
        public void AutoDetect(){} // RVA: 0x7FFE811B5980
        public void AddFinger(){} // RVA: 0x7FFE811B5E70
        public void RemoveFinger(){} // RVA: 0x7FFE811B61B0
        public void AddChildrenRecursive(){} // RVA: 0x7FFE811B63C0
        public void InitiateSolver(){} // RVA: 0x7FFE811B6520
        public void UpdateFingerSolvers(){} // RVA: 0x7FFE811B6620
        public void FixFingerTransforms(){} // RVA: 0x7FFE811B6690
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE811B68E0
        public void UpdateSolver(){} // RVA: 0x7FFE811B6620
        public void FixTransforms(){} // RVA: 0x7FFE811B6B10
        public void .ctor(){} // RVA: 0x7FFE811B6B30
    }

    public class FullBodyBipedIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OpenSetupTutorial(){} // RVA: 0x7FFE810FB310
        public void OpenInspectorTutorial(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void SetReferences(){} // RVA: 0x7FFE811C9310
        public void GetIKSolver(){} // RVA: 0x7FFE8119C0E0
        public void ReferencesError(){} // RVA: 0x7FFE811C9380
        public void ReferencesWarning(){} // RVA: 0x7FFE811C97D0
        public void Reinitiate(){} // RVA: 0x7FFE811C9F70
        public void AutoDetectReferences(){} // RVA: 0x7FFE811C9FA0
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFE811B6C10
        public void VRCInitiateSolver(){} // RVA: 0x7FFE811CA150
        public void InitiateSolver(){} // RVA: 0x7FFE811CA160
        public void .ctor(){} // RVA: 0x7FFE811CA170
    }

    public class GenericPoser : Poser
    {
        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x7FFE8125A2B0
        public void InitiatePoser(){} // RVA: 0x7FFE8125A840
        public void UpdatePoser(){} // RVA: 0x7FFE8125A850
        public void FixPoserTransforms(){} // RVA: 0x7FFE8125A9C0
        public void StoreDefaultState(){} // RVA: 0x7FFE8125AB20
        public void GetTargetNamed(){} // RVA: 0x7FFE8125AC90
        public void .ctor(){} // RVA: 0x7FFE8125AD50
    }

    public class Grounder : MonoBehaviour
    {
        public float weight; // 0x20

        // ── Methods ──
        public void ResetPosition(){} // RVA: 0x7FFE80E45FE0
        public void get_initiated(){} // RVA: 0x7FFE811B6C00
        public void set_initiated(){} // RVA: 0x7FFE811B6C10
        public void GetSpineOffsetTarget(){} // RVA: 0x7FFE811B6C20
        public void LogWarning(){} // RVA: 0x7FFE811B06F0
        public void GetLegSpineBendVector(){} // RVA: 0x7FFE811B6D60
        public void GetLegSpineTangent(){} // RVA: 0x7FFE811B6FB0
        public void OpenUserManual(){} // RVA: 0x7FFE80E45FE0
        public void OpenScriptReference(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE811B7260
    }

    public class GrounderBipedIK : Grounder
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void ResetPosition(){} // RVA: 0x7FFE811B7380
        public void IsReadyToInitiate(){} // RVA: 0x7FFE811B73F0
        public void Update(){} // RVA: 0x7FFE811B7510
        public void Initiate(){} // RVA: 0x7FFE811B7660
        public void OnDisable(){} // RVA: 0x7FFE811B7BF0
        public void OnSolverUpdate(){} // RVA: 0x7FFE811B7C50
        public void SetLegIK(){} // RVA: 0x7FFE811B8770
        public void OnPostSolverUpdate(){} // RVA: 0x7FFE811B8890
        public void OnDestroy(){} // RVA: 0x7FFE811B8CE0
        public void .ctor(){} // RVA: 0x7FFE811B9020
    }

    public class GrounderFBBIK : Grounder
    {
        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0x7FFE810FB310
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void ResetPosition(){} // RVA: 0x7FFE811B9150
        public void IsReadyToInitiate(){} // RVA: 0x7FFE811B91C0
        public void Update(){} // RVA: 0x7FFE811B92C0
        public void FixedUpdate(){} // RVA: 0x7FFE811B9400
        public void LateUpdate(){} // RVA: 0x7FFE811B9400
        public void Initiate(){} // RVA: 0x7FFE811B9410
        public void OnSolverUpdate(){} // RVA: 0x7FFE811B97D0
        public void SetLegIK(){} // RVA: 0x7FFE811B9D90
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE811BA180
        public void OnDestroy(){} // RVA: 0x7FFE811BA4D0
        public void .ctor(){} // RVA: 0x7FFE811BA6D0
    }

    public class GrounderIK : Grounder
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void ResetPosition(){} // RVA: 0x7FFE811BA810
        public void IsReadyToInitiate(){} // RVA: 0x7FFE811BA830
        public void OnDisable(){} // RVA: 0x7FFE811BAB10
        public void Update(){} // RVA: 0x7FFE811BAC80
        public void Initiate(){} // RVA: 0x7FFE811BB6C0
        public void OnSolverUpdate(){} // RVA: 0x7FFE811BBFD0
        public void SetLegIK(){} // RVA: 0x7FFE811BC520
        public void OnPostSolverUpdate(){} // RVA: 0x7FFE811BCAD0
        public void OnDestroy(){} // RVA: 0x7FFE811BCF30
        public void .ctor(){} // RVA: 0x7FFE811BD230
    }

    public class GrounderQuadruped : Grounder
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void ResetPosition(){} // RVA: 0x7FFE811BD350
        public void IsReadyToInitiate(){} // RVA: 0x7FFE811BD390
        public void IsReadyToInitiateLegs(){} // RVA: 0x7FFE811BD610
        public void OnDisable(){} // RVA: 0x7FFE811BD850
        public void Update(){} // RVA: 0x7FFE811BD8D0
        public void Initiate(){} // RVA: 0x7FFE811BD940
        public void InitiateFeet(){} // RVA: 0x7FFE811BE0C0
        public void LateUpdate(){} // RVA: 0x7FFE811BE790
        public void RootRotation(){} // RVA: 0x7FFE811BE8A0
        public void OnSolverUpdate(){} // RVA: 0x7FFE811BF320
        public void UpdateForefeetRoot(){} // RVA: 0x7FFE811C0400
        public void SetFootIK(){} // RVA: 0x7FFE811C0950
        public void OnPostSolverUpdate(){} // RVA: 0x7FFE811C0B40
        public void OnDestroy(){} // RVA: 0x7FFE811C12E0
        public void DestroyLegs(){} // RVA: 0x7FFE811C1320
        public void .ctor(){} // RVA: 0x7FFE811C1610
    }

    public class GrounderVRIK : Grounder
    {
        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0x7FFE810FB310
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void ResetPosition(){} // RVA: 0x7FFE811BA810
        public void IsReadyToInitiate(){} // RVA: 0x7FFE811C1C20
        public void Update(){} // RVA: 0x7FFE811C1D20
        public void Initiate(){} // RVA: 0x7FFE811C1E50
        public void OnSolverUpdate(){} // RVA: 0x7FFE811C2230
        public void SetLegIK(){} // RVA: 0x7FFE811C26D0
        public void OnPostSolverUpdate(){} // RVA: 0x7FFE811C2800
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE811C2DF0
        public void OnDestroy(){} // RVA: 0x7FFE811C3140
        public void .ctor(){} // RVA: 0x7FFE811C3470
    }

    public class Grounding : Object
    {
        public UnityEngine.LayerMask layers; // 0x10
        public float maxStep; // 0x14
        public float heightOffset; // 0x18
        public float footSpeed; // 0x1C
        public float footRadius; // 0x20
        public float footCenterOffset; // 0x24
        public float prediction; // 0x28
        public float footRotationWeight; // 0x2C

        // ── Methods ──
        public void get_legs(){} // RVA: 0x7FFE811C3500
        public void set_legs(){} // RVA: 0x7FFE811C3510
        public void get_pelvis(){} // RVA: 0x7FFE81199370
        public void set_pelvis(){} // RVA: 0x7FFE81199380
        public void get_isGrounded(){} // RVA: 0x7FFE811C3570
        public void set_isGrounded(){} // RVA: 0x7FFE811C3580
        public void get_root(){} // RVA: 0x7FFE811C3590
        public void set_root(){} // RVA: 0x7FFE811C35A0
        public void get_rootHit(){} // RVA: 0x7FFE811C3600
        public void set_rootHit(){} // RVA: 0x7FFE811C3630
        public void get_rootGrounded(){} // RVA: 0x7FFE811C3660
        public void GetRootHit(){} // RVA: 0x7FFE811C3680
        public void IsValid(){} // RVA: 0x7FFE811C3C90
        public void Initiate(){} // RVA: 0x7FFE811C3EF0
        public void Update(){} // RVA: 0x7FFE811C44A0
        public void GetLegsPlaneNormal(){} // RVA: 0x7FFE811C4730
        public void Reset(){} // RVA: 0x7FFE811C4C10
        public void LogWarning(){} // RVA: 0x7FFE811C4FF0
        public void get_up(){} // RVA: 0x7FFE811C5010
        public void GetVerticalOffset(){} // RVA: 0x7FFE811C50A0
        public void Flatten(){} // RVA: 0x7FFE811C5290
        public void get_useRootRotation(){} // RVA: 0x7FFE811C53D0
        public void GetFootCenterOffset(){} // RVA: 0x7FFE811C54A0
        public void .ctor(){} // RVA: 0x7FFE811C5580
    }

    public class HandPoser : Poser
    {
        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x7FFE8125B290
        public void InitiatePoser(){} // RVA: 0x7FFE8125B500
        public void FixPoserTransforms(){} // RVA: 0x7FFE8125B5C0
        public void UpdatePoser(){} // RVA: 0x7FFE8125B760
        public void StoreDefaultState(){} // RVA: 0x7FFE8125BF00
        public void .ctor(){} // RVA: 0x7FFE8125AD50
    }

    public class HitReaction : OffsetModifier
    {
        public HitPointEffector[] effectorHitPoints; // 0x38

        // ── Methods ──
        public void get_inProgress(){} // RVA: 0x7FFE812689A0
        public void OnModifyOffset(){} // RVA: 0x7FFE81268A50
        public void Hit(){} // RVA: 0x7FFE81268B30
        public void .ctor(){} // RVA: 0x7FFE81103920
    }

    public class HitReactionVRIK : OffsetModifierVRIK
    {
        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFE8126A3B0
        public void Hit(){} // RVA: 0x7FFE8126A480
        public void .ctor(){} // RVA: 0x7FFE81103920
    }

    public class IK : SolverManager
    {
        // ── Methods ──
        public void GetIKSolver(){} // RVA: 0x7FFE80E2E2E0
        public void UpdateSolver(){} // RVA: 0x7FFE811CA300
        public void InitiateSolver(){} // RVA: 0x7FFE811CA3A0
        public void FixTransforms(){} // RVA: 0x7FFE811CA450
        public void OpenUserManual(){} // RVA: 0x7FFE80E45FE0
        public void OpenScriptReference(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE81155060
    }

    public class IKConstraintBend : Object
    {
        public UnityEngine.Transform bone1; // 0x10

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811DA920
        public void get_initiated(){} // RVA: 0x7FFE811DACE0
        public void set_initiated(){} // RVA: 0x7FFE811DACF0
        public void .ctor(){} // RVA: 0x7FFE811DAD60 | overloaded x2
        public void SetBones(){} // RVA: 0x7FFE811DAE00
        public void Initiate(){} // RVA: 0x7FFE811DAF00
        public void SetLimbOrientation(){} // RVA: 0x7FFE811DB940
        public void LimitBend(){} // RVA: 0x7FFE811DBBF0
        public void GetDir(){} // RVA: 0x7FFE811DC860
        public void OrthoToLimb(){} // RVA: 0x7FFE811DD490
        public void OrthoToBone1(){} // RVA: 0x7FFE811DD600
    }

    public class IKEffector : Object
    {
        public UnityEngine.Transform bone; // 0x10

        // ── Methods ──
        public void GetNode(){} // RVA: 0x7FFE811DD770
        public void get_isEndEffector(){} // RVA: 0x7FFE811B58E0
        public void set_isEndEffector(){} // RVA: 0x7FFE811B58F0
        public void PinToBone(){} // RVA: 0x7FFE811DD7D0
        public void .ctor(){} // RVA: 0x7FFE811DDC50 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFE811DE050
        public void Initiate(){} // RVA: 0x7FFE811DE660
        public void ResetOffset(){} // RVA: 0x7FFE811DEC40
        public void SetToTarget(){} // RVA: 0x7FFE811DEE10
        public void OnPreSolve(){} // RVA: 0x7FFE811DEFC0
        public void OnPostWrite(){} // RVA: 0x7FFE811DF990
        public void GetPlaneRotation(){} // RVA: 0x7FFE811DF9E0
        public void Update(){} // RVA: 0x7FFE811DFD60
        public void GetPosition(){} // RVA: 0x7FFE811E01C0
    }

    public class IKExecutionOrder : MonoBehaviour
    {
        public RootMotion.FinalIK.IK[] IKComponents; // 0x20

        // ── Methods ──
        public void get_animatePhysics(){} // RVA: 0x7FFE811CA4C0
        public void Start(){} // RVA: 0x7FFE811CA5F0
        public void Update(){} // RVA: 0x7FFE811CA7B0
        public void FixedUpdate(){} // RVA: 0x7FFE811CA7E0
        public void LateUpdate(){} // RVA: 0x7FFE811CA810
        public void FixTransforms(){} // RVA: 0x7FFE811CA9A0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class IKMapping : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811E0850
        public void Initiate(){} // RVA: 0x7FFE810FB310
        public void BoneIsValid(){} // RVA: 0x7FFE811E0860
        public void SolveFABRIKJoint(){} // RVA: 0x7FFE811D9310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IKMappingBone : IKMapping
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811E4050
        public void .ctor(){} // RVA: 0x7FFE811E4250 | overloaded x2
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE811E4380
        public void FixTransforms(){} // RVA: 0x7FFE811E43A0
        public void Initiate(){} // RVA: 0x7FFE811E4420
        public void ReadPose(){} // RVA: 0x7FFE811E4580
        public void WritePose(){} // RVA: 0x7FFE811E45A0
    }

    public class IKMappingLimb : IKMapping
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811E45D0
        public void GetBoneMap(){} // RVA: 0x7FFE811E4670
        public void SetLimbOrientation(){} // RVA: 0x7FFE811E47B0
        public void .ctor(){} // RVA: 0x7FFE811E5570 | overloaded x2
        public void SetBones(){} // RVA: 0x7FFE811E5800
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE811E5950
        public void FixTransforms(){} // RVA: 0x7FFE811E5A60
        public void Initiate(){} // RVA: 0x7FFE811E5CA0
        public void ReadPose(){} // RVA: 0x7FFE811E6300
        public void WritePose(){} // RVA: 0x7FFE811E6380
    }

    public class IKMappingSpine : IKMapping
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811E65C0
        public void .ctor(){} // RVA: 0x7FFE811E7040 | overloaded x2
        public void SetBones(){} // RVA: 0x7FFE811E7340
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE811E74F0
        public void FixTransforms(){} // RVA: 0x7FFE811E7660
        public void Initiate(){} // RVA: 0x7FFE811E76F0
        public void UseFABRIK(){} // RVA: 0x7FFE811E8360
        public void ReadPose(){} // RVA: 0x7FFE811E8390
        public void WritePose(){} // RVA: 0x7FFE811E87D0
        public void ForwardReach(){} // RVA: 0x7FFE811E8CF0
        public void BackwardReach(){} // RVA: 0x7FFE811E8F30
        public void MapToSolverPositions(){} // RVA: 0x7FFE811E9160
    }

    public class IKSolver : Object
    {
        public UnityEngine.Vector3 IKPosition; // 0x10

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void Initiate(){} // RVA: 0x7FFE811E9730
        public void Update(){} // RVA: 0x7FFE811E9920
        public void GetIKPosition(){} // RVA: 0x7FFE811188D0
        public void SetIKPosition(){} // RVA: 0x7FFE811188F0
        public void GetIKPositionWeight(){} // RVA: 0x7FFE811C8570
        public void SetIKPositionWeight(){} // RVA: 0x7FFE811E99A0
        public void GetRoot(){} // RVA: 0x7FFE8119C0E0
        public void get_initiated(){} // RVA: 0x7FFE811E99D0
        public void set_initiated(){} // RVA: 0x7FFE811E99E0
        public void GetPoints(){} // RVA: 0x7FFE80E2E2E0
        public void GetPoint(){} // RVA: 0x7FFE80E2E390
        public void FixTransforms(){} // RVA: 0x7FFE80E45FE0
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE80E45FE0
        public void OnInitiate(){} // RVA: 0x7FFE80E45FE0
        public void OnUpdate(){} // RVA: 0x7FFE80E45FE0
        public void LogWarning(){} // RVA: 0x7FFE811E99F0
        public void ContainsDuplicateBone(){} // RVA: 0x7FFE811E9AA0
        public void HierarchyIsValid(){} // RVA: 0x7FFE811E9C70
        public void PreSolveBones(){} // RVA: 0x7FFE811E9D00
        public void .ctor(){} // RVA: 0x7FFE811EA1A0
    }

    public class IKSolverAim : IKSolverHeuristic
    {
        public UnityEngine.Transform transform; // 0x88
        public UnityEngine.Vector3 axis; // 0x90
        public UnityEngine.Vector3 poleAxis; // 0x9C
        public UnityEngine.Vector3 polePosition; // 0xA8

        // ── Methods ──
        public void GetAngle(){} // RVA: 0x7FFE811EC4C0
        public void get_transformAxis(){} // RVA: 0x7FFE811EC5D0
        public void get_transformPoleAxis(){} // RVA: 0x7FFE811EC840
        public void OnInitiate(){} // RVA: 0x7FFE811ECAB0
        public void OnUpdate(){} // RVA: 0x7FFE811ECF90
        public void get_minBones(){} // RVA: 0x7FFE811EDAF0
        public void Solve(){} // RVA: 0x7FFE811EDB00
        public void GetClampedIKPosition(){} // RVA: 0x7FFE811EDC50
        public void RotateToTarget(){} // RVA: 0x7FFE811EE1D0
        public void get_localDirection(){} // RVA: 0x7FFE811EF080
        public void .ctor(){} // RVA: 0x7FFE811EF190
    }

    public class IKSolverArm : IKSolver
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811EF250
        public void SetChain(){} // RVA: 0x7FFE811EF940
        public void GetPoints(){} // RVA: 0x7FFE811EFB60
        public void GetPoint(){} // RVA: 0x7FFE811EFD10
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE811F0260
        public void FixTransforms(){} // RVA: 0x7FFE811F02C0
        public void OnInitiate(){} // RVA: 0x7FFE811F0330
        public void OnUpdate(){} // RVA: 0x7FFE811F0450
        public void Solve(){} // RVA: 0x7FFE811F04F0
        public void Read(){} // RVA: 0x7FFE811F0580
        public void Write(){} // RVA: 0x7FFE811F0DC0
        public void .ctor(){} // RVA: 0x7FFE811F1160
    }

    public class IKSolverCCD : IKSolverHeuristic
    {
        // ── Methods ──
        public void FadeOutBoneWeights(){} // RVA: 0x7FFE811F1690
        public void OnInitiate(){} // RVA: 0x7FFE811F1730
        public void OnUpdate(){} // RVA: 0x7FFE811F1880
        public void Solve(){} // RVA: 0x7FFE811F1D80
        public void .ctor(){} // RVA: 0x7FFE811F2C30
    }

    public class IKSolverFABRIK : IKSolverHeuristic
    {
        public IterationDelegate OnPreIteration; // 0x88

        // ── Methods ──
        public void SolveForward(){} // RVA: 0x7FFE811F2C40
        public void SolveBackward(){} // RVA: 0x7FFE811F2CF0
        public void GetIKPosition(){} // RVA: 0x7FFE811F2DC0
        public void OnInitiate(){} // RVA: 0x7FFE811F2F20
        public void OnUpdate(){} // RVA: 0x7FFE811F36A0
        public void get_boneLengthCanBeZero(){} // RVA: 0x7FFE810FB320
        public void SolveJoint(){} // RVA: 0x7FFE811F3B80
        public void OnPreSolve(){} // RVA: 0x7FFE811F3CD0
        public void OnPostSolve(){} // RVA: 0x7FFE811F4420
        public void Solve(){} // RVA: 0x7FFE811F4600
        public void ForwardReach(){} // RVA: 0x7FFE811F4700
        public void SolverMove(){} // RVA: 0x7FFE811F4A70
        public void SolverRotate(){} // RVA: 0x7FFE811F4B00
        public void SolverRotateChildren(){} // RVA: 0x7FFE811F4D00
        public void SolverMoveChildrenAroundPoint(){} // RVA: 0x7FFE811F4EE0
        public void GetParentSolverRotation(){} // RVA: 0x7FFE811F51B0
        public void GetParentSolverPosition(){} // RVA: 0x7FFE811F5450
        public void GetLimitedRotation(){} // RVA: 0x7FFE811F5710
        public void LimitForward(){} // RVA: 0x7FFE811F5AD0
        public void BackwardReach(){} // RVA: 0x7FFE811F61E0
        public void BackwardReachUnlimited(){} // RVA: 0x7FFE811F6220
        public void BackwardReachLimited(){} // RVA: 0x7FFE811F6470
        public void MapToSolverPositions(){} // RVA: 0x7FFE811F7180
        public void MapToSolverPositionsLimited(){} // RVA: 0x7FFE811F7350
        public void .ctor(){} // RVA: 0x7FFE811F74F0
    }

    public class IKSolverFABRIKRoot : IKSolver
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE811F7610
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE811F7F90
        public void FixTransforms(){} // RVA: 0x7FFE811F80A0
        public void OnInitiate(){} // RVA: 0x7FFE811F81A0
        public void IsRoot(){} // RVA: 0x7FFE811F83C0
        public void OnUpdate(){} // RVA: 0x7FFE811F8470
        public void GetPoints(){} // RVA: 0x7FFE811F86E0
        public void GetPoint(){} // RVA: 0x7FFE811F8790
        public void AddPointsToArray(){} // RVA: 0x7FFE811F8830
        public void GetCentroid(){} // RVA: 0x7FFE811F89F0
        public void .ctor(){} // RVA: 0x7FFE811F8DD0
    }

    public class IKSolverFullBody : IKSolver
    {
        // ── Methods ──
        public void GetEffector(){} // RVA: 0x7FFE811F8E70
        public void GetChain(){} // RVA: 0x7FFE811F9010
        public void GetChainIndex(){} // RVA: 0x7FFE811F9060
        public void GetNode(){} // RVA: 0x7FFE811F9240
        public void GetChainAndNodeIndexes(){} // RVA: 0x7FFE811F9290
        public void GetPoints(){} // RVA: 0x7FFE811F9470
        public void GetPoint(){} // RVA: 0x7FFE811F9620
        public void IsValid(){} // RVA: 0x7FFE811F9820
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE811F9B00
        public void FixTransforms(){} // RVA: 0x7FFE811F9D80
        public void OnInitiate(){} // RVA: 0x7FFE811F9FA0
        public void OnUpdate(){} // RVA: 0x7FFE811FA140
        public void ReadPose(){} // RVA: 0x7FFE811FA370
        public void Solve(){} // RVA: 0x7FFE811FA890
        public void ApplyBendConstraints(){} // RVA: 0x7FFE811FAC00
        public void WritePose(){} // RVA: 0x7FFE811FAC40
        public void .ctor(){} // RVA: 0x7FFE811FAD70
    }

    public class IKSolverFullBodyBiped : IKSolverFullBody
    {
        public UnityEngine.Transform rootNode; // 0xD0
        public float spineStiffness; // 0xD8
        public float pullBodyVertical; // 0xDC
        public float pullBodyHorizontal; // 0xE0
        public UnityEngine.Vector3 _pullBodyOffset; // 0xE4
        public UnityEngine.Vector3 offset; // 0xF0
        public object field_6; // 0xDA
        public object field_7; // 0xDB
        public object field_8; // 0xDC
        public object field_9; // 0xDD
        public object field_10; // 0xDE
        public object field_11; // 0xDF
        public object field_12; // 0xE0
        public object field_13; // 0xE1
        public object field_14; // 0xE2
        public object field_15; // 0xE3
        public object field_16; // 0xE4
        public object field_17; // 0xE5
        public object field_18; // 0xE6

        // ── Methods ──
        public void get_bodyEffector(){} // RVA: 0x7FFE811FB010
        public void get_leftShoulderEffector(){} // RVA: 0x7FFE811FB040
        public void get_rightShoulderEffector(){} // RVA: 0x7FFE811FB070
        public void get_leftThighEffector(){} // RVA: 0x7FFE811FB0A0
        public void get_rightThighEffector(){} // RVA: 0x7FFE811FB0D0
        public void get_leftHandEffector(){} // RVA: 0x7FFE811FB100
        public void get_rightHandEffector(){} // RVA: 0x7FFE811FB130
        public void get_leftFootEffector(){} // RVA: 0x7FFE811FB160
        public void get_rightFootEffector(){} // RVA: 0x7FFE811FB190
        public void get_leftArmChain(){} // RVA: 0x7FFE811FB1C0
        public void get_rightArmChain(){} // RVA: 0x7FFE811FB1F0
        public void get_leftLegChain(){} // RVA: 0x7FFE811FB220
        public void get_rightLegChain(){} // RVA: 0x7FFE811FB250
        public void get_leftArmMapping(){} // RVA: 0x7FFE811FB280
        public void get_rightArmMapping(){} // RVA: 0x7FFE811FB2B0
        public void get_leftLegMapping(){} // RVA: 0x7FFE811FB2E0
        public void get_rightLegMapping(){} // RVA: 0x7FFE811FB310
        public void get_headMapping(){} // RVA: 0x7FFE811FB340
        public void SetChainWeights(){} // RVA: 0x7FFE811FB370
        public void SetEffectorWeights(){} // RVA: 0x7FFE811FB3E0
        public void GetChain(){} // RVA: 0x7FFE811FB530 | overloaded x2
        public void GetEffector(){} // RVA: 0x7FFE811FB620
        public void GetEndEffector(){} // RVA: 0x7FFE811FB780
        public void GetLimbMapping(){} // RVA: 0x7FFE811FB8B0 | overloaded x2
        public void GetSpineMapping(){} // RVA: 0x7FFE811C3590
        public void GetHeadMapping(){} // RVA: 0x7FFE811FB340
        public void GetBendConstraint(){} // RVA: 0x7FFE811FB990
        public void IsValid(){} // RVA: 0x7FFE811FBA20
        public void SetToReferences(){} // RVA: 0x7FFE811FBD30
        public void DetectRootNodeBone(){} // RVA: 0x7FFE811FDDF0
        public void SetLimbOrientations(){} // RVA: 0x7FFE811FE4C0
        public void get_pullBodyOffset(){} // RVA: 0x7FFE81166260
        public void set_pullBodyOffset(){} // RVA: 0x7FFE81166280
        public void SetLimbOrientation(){} // RVA: 0x7FFE811FE530
        public void GetLeftClavicle(){} // RVA: 0x7FFE811FE7C0
        public void GetRightClavicle(){} // RVA: 0x7FFE811FE970
        public void Contains(){} // RVA: 0x7FFE811FEB20
        public void ReadPose(){} // RVA: 0x7FFE811FEC90
        public void PullBody(){} // RVA: 0x7FFE811FF100
        public void GetBodyOffset(){} // RVA: 0x7FFE811FF2E0
        public void GetHandBodyPull(){} // RVA: 0x7FFE811FF5C0
        public void ApplyBendConstraints(){} // RVA: 0x7FFE811FF800
        public void WritePose(){} // RVA: 0x7FFE811FFC60
        public void .ctor(){} // RVA: 0x7FFE811FFEB0
    }

    public class IKSolverHeuristic : IKSolver
    {
        public UnityEngine.Transform target; // 0x58
        public float tolerance; // 0x60
        public int maxIterations; // 0x64
        public bool useRotationLimits; // 0x68
        public bool XY; // 0x69

        // ── Methods ──
        public void SetChain(){} // RVA: 0x7FFE811FFED0
        public void AddBone(){} // RVA: 0x7FFE812000B0
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE81200280
        public void FixTransforms(){} // RVA: 0x7FFE812003F0
        public void IsValid(){} // RVA: 0x7FFE81200470
        public void GetPoints(){} // RVA: 0x7FFE811C3590
        public void GetPoint(){} // RVA: 0x7FFE81200B10
        public void get_minBones(){} // RVA: 0x7FFE81200CB0
        public void get_boneLengthCanBeZero(){} // RVA: 0x7FFE811E0850
        public void get_allowCommonParent(){} // RVA: 0x7FFE810FB320
        public void OnInitiate(){} // RVA: 0x7FFE810FB310
        public void OnUpdate(){} // RVA: 0x7FFE810FB310
        public void InitiateBones(){} // RVA: 0x7FFE81200CC0
        public void get_localDirection(){} // RVA: 0x7FFE81201580
        public void get_positionOffset(){} // RVA: 0x7FFE81201790
        public void GetSingularityOffset(){} // RVA: 0x7FFE81201800
        public void SingularityDetected(){} // RVA: 0x7FFE81201D70
        public void .ctor(){} // RVA: 0x7FFE812020E0
    }

    public class IKSolverLeg : IKSolver
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE81202190
        public void SetChain(){} // RVA: 0x7FFE811EF940
        public void GetPoints(){} // RVA: 0x7FFE81202880
        public void GetPoint(){} // RVA: 0x7FFE81202A30
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE811F0260
        public void FixTransforms(){} // RVA: 0x7FFE811F02C0
        public void OnInitiate(){} // RVA: 0x7FFE81202F80
        public void OnUpdate(){} // RVA: 0x7FFE812030A0
        public void Solve(){} // RVA: 0x7FFE812031A0
        public void Read(){} // RVA: 0x7FFE81203290
        public void Write(){} // RVA: 0x7FFE81203AC0
        public void .ctor(){} // RVA: 0x7FFE81203E60
    }

    public class IKSolverLimb : IKSolverTrigonometric
    {
        public 0x66696434 goal; // 0xA8

        // ── Methods ──
        public void MaintainRotation(){} // RVA: 0x7FFE81204390
        public void MaintainBend(){} // RVA: 0x7FFE81204430
        public void OnInitiateVirtual(){} // RVA: 0x7FFE81204480
        public void OnUpdateVirtual(){} // RVA: 0x7FFE81204CF0
        public void OnPostSolveVirtual(){} // RVA: 0x7FFE81204E50
        public void .ctor(){} // RVA: 0x7FFE81205130 | overloaded x2
        public void get_axisDirections(){} // RVA: 0x7FFE81205260
        public void StoreAxisDirections(){} // RVA: 0x7FFE81205280
        public void GetModifiedBendNormal(){} // RVA: 0x7FFE812058D0
    }

    public class IKSolverLookAt : IKSolver
    {
        public UnityEngine.Transform target; // 0x58
        public LookAtBone[] spine; // 0x60
        public LookAtBone head; // 0x68
        public LookAtBone[] eyes; // 0x70
        public float bodyWeight; // 0x78
        public float headWeight; // 0x7C

        // ── Methods ──
        public void SetLookAtWeight(){} // RVA: 0x7FFE812073A0 | overloaded x6
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE81207480
        public void FixTransforms(){} // RVA: 0x7FFE81207640
        public void IsValid(){} // RVA: 0x7FFE81207810
        public void GetPoints(){} // RVA: 0x7FFE81207D70
        public void GetPoint(){} // RVA: 0x7FFE81208190
        public void SetChain(){} // RVA: 0x7FFE81208530
        public void OnInitiate(){} // RVA: 0x7FFE81208630
        public void OnUpdate(){} // RVA: 0x7FFE81208CC0
        public void get_spineIsValid(){} // RVA: 0x7FFE81208E50
        public void get_spineIsEmpty(){} // RVA: 0x7FFE81208FB0
        public void SolveSpine(){} // RVA: 0x7FFE81208FD0
        public void get_headIsValid(){} // RVA: 0x7FFE812092E0
        public void get_headIsEmpty(){} // RVA: 0x7FFE812092F0
        public void SolveHead(){} // RVA: 0x7FFE812093D0
        public void get_eyesIsValid(){} // RVA: 0x7FFE81209870
        public void get_eyesIsEmpty(){} // RVA: 0x7FFE812099D0
        public void SolveEyes(){} // RVA: 0x7FFE812099F0
        public void GetForwards(){} // RVA: 0x7FFE8120A2E0
        public void SetBones(){} // RVA: 0x7FFE8120A6E0
        public void .ctor(){} // RVA: 0x7FFE8120A930
    }

    public class IKSolverTrigonometric : IKSolver
    {
        // ── Methods ──
        public void SetBendGoalPosition(){} // RVA: 0x7FFE8120B790
        public void SetBendPlaneToCurrent(){} // RVA: 0x7FFE8120BAA0
        public void SetIKRotation(){} // RVA: 0x7FFE8120BDC0
        public void SetIKRotationWeight(){} // RVA: 0x7FFE8120BDD0
        public void GetIKRotation(){} // RVA: 0x7FFE8120BE00
        public void GetIKRotationWeight(){} // RVA: 0x7FFE8120BE10
        public void GetPoints(){} // RVA: 0x7FFE8120BE20
        public void GetPoint(){} // RVA: 0x7FFE8120BF50
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE8120C2A0
        public void FixTransforms(){} // RVA: 0x7FFE8120C2F0
        public void IsValid(){} // RVA: 0x7FFE8120C350
        public void SetChain(){} // RVA: 0x7FFE8120CAD0
        public void Solve(){} // RVA: 0x7FFE8120CC30
        public void GetDirectionToBendPoint(){} // RVA: 0x7FFE8120D8E0
        public void OnInitiate(){} // RVA: 0x7FFE8120DCC0
        public void IsDirectHierarchy(){} // RVA: 0x7FFE8120E040
        public void InitiateBones(){} // RVA: 0x7FFE8120E330
        public void OnUpdate(){} // RVA: 0x7FFE8120E4E0
        public void OnInitiateVirtual(){} // RVA: 0x7FFE810FB310
        public void OnUpdateVirtual(){} // RVA: 0x7FFE810FB310
        public void OnPostSolveVirtual(){} // RVA: 0x7FFE810FB310
        public void GetBendDirection(){} // RVA: 0x7FFE8120F450
        public void .ctor(){} // RVA: 0x7FFE8120F9C0
    }

    public class IKSolverVR : IKSolver
    {
        public UnityEngine.Transform[] solverTransforms; // 0x58

        // ── Methods ──
        public void SetToReferences(){} // RVA: 0x7FFE812104F0
        public void GuessHandOrientations(){} // RVA: 0x7FFE81210C90
        public void DefaultAnimationCurves(){} // RVA: 0x7FFE812110F0
        public void AddPositionOffset(){} // RVA: 0x7FFE812114A0
        public void AddRotationOffset(){} // RVA: 0x7FFE812117F0 | overloaded x2
        public void AddPlatformMotion(){} // RVA: 0x7FFE81211BE0
        public void Reset(){} // RVA: 0x7FFE81212020
        public void StoreDefaultLocalState(){} // RVA: 0x7FFE81212350
        public void FixTransforms(){} // RVA: 0x7FFE812125E0
        public void GetPoints(){} // RVA: 0x7FFE812128E0
        public void GetPoint(){} // RVA: 0x7FFE81212940
        public void IsValid(){} // RVA: 0x7FFE812129A0
        public void GetNormal(){} // RVA: 0x7FFE81212D50
        public void GuessWristToPalmAxis(){} // RVA: 0x7FFE81213210
        public void GuessPalmToThumbAxis(){} // RVA: 0x7FFE812135E0
        public void GetSineKeyframes(){} // RVA: 0x7FFE81213F10
        public void UpdateSolverTransforms(){} // RVA: 0x7FFE81213FA0
        public void OnInitiate(){} // RVA: 0x7FFE81214220
        public void OnUpdate(){} // RVA: 0x7FFE81214280
        public void WriteTransforms(){} // RVA: 0x7FFE81214D10
        public void Read(){} // RVA: 0x7FFE812158D0
        public void Solve(){} // RVA: 0x7FFE81216450
        public void GetPosition(){} // RVA: 0x7FFE81218070
        public void GetRotation(){} // RVA: 0x7FFE812180C0
        public void get_rootBone(){} // RVA: 0x7FFE81218100
        public void set_rootBone(){} // RVA: 0x7FFE81218110
        public void VrcRead(){} // RVA: 0x7FFE81214220
        public void VrcWrite(){} // RVA: 0x7FFE81218170
        public void VrcWriteTransforms(){} // RVA: 0x7FFE81218180
        public void VrcSyncIk(){} // RVA: 0x7FFE81218190
        public void VrcLateSolve(){} // RVA: 0x7FFE812181B0
        public void Write(){} // RVA: 0x7FFE81218210
        public void GetPelvisOffset(){} // RVA: 0x7FFE812183A0
        public void .ctor(){} // RVA: 0x7FFE81218E80
    }

    public class Inertia : OffsetModifier
    {
        // ── Methods ──
        public void ResetBodies(){} // RVA: 0x7FFE8126BD60
        public void OnModifyOffset(){} // RVA: 0x7FFE8126BE00
        public void .ctor(){} // RVA: 0x7FFE81103920
    }

    public class InteractionEffector : Object
    {
        public 0x665B9BF4 _effectorType; // 0x10
        public bool _isPaused; // 0x14
        public RootMotion.FinalIK.InteractionObject _interactionObject; // 0x18
        public RootMotion.FinalIK.Poser poser; // 0x20
        public RootMotion.FinalIK.IKEffector effector; // 0x28

        // ── Methods ──
        public void get_effectorType(){} // RVA: 0x7FFE811485C0
        public void set_effectorType(){} // RVA: 0x7FFE810FE0C0
        public void get_isPaused(){} // RVA: 0x7FFE8124ABD0
        public void set_isPaused(){} // RVA: 0x7FFE8124ABE0
        public void get_interactionObject(){} // RVA: 0x7FFE810FE7C0
        public void set_interactionObject(){} // RVA: 0x7FFE81161E80
        public void get_inInteraction(){} // RVA: 0x7FFE8124ABF0
        public void .ctor(){} // RVA: 0x7FFE8124ACC0
        public void Initiate(){} // RVA: 0x7FFE8124AD90
        public void StoreDefaults(){} // RVA: 0x7FFE8124AF50
        public void ResetToDefaults(){} // RVA: 0x7FFE8124B140
        public void Pause(){} // RVA: 0x7FFE8124B600
        public void Resume(){} // RVA: 0x7FFE8124B960
        public void Start(){} // RVA: 0x7FFE8124B9C0
        public void Update(){} // RVA: 0x7FFE8124C3F0
        public void get_progress(){} // RVA: 0x7FFE8124D010
        public void TriggerUntriggeredEvents(){} // RVA: 0x7FFE8124D050
        public void PickUp(){} // RVA: 0x7FFE8124D370
        public void Stop(){} // RVA: 0x7FFE8124D740
        public void OnPostFBBIK(){} // RVA: 0x7FFE8124DB30
    }

    public class InteractionLookAt : Object
    {
        // ── Methods ──
        public void Look(){} // RVA: 0x7FFE8124E120
        public void OnFixTransforms(){} // RVA: 0x7FFE8124E380
        public void Update(){} // RVA: 0x7FFE8124E480
        public void SolveSpine(){} // RVA: 0x7FFE8124E910
        public void SolveHead(){} // RVA: 0x7FFE8124EAA0
        public void .ctor(){} // RVA: 0x7FFE8124EBE0
    }

    public class InteractionObject : MonoBehaviour
    {
        public UnityEngine.Transform otherLookAtTarget; // 0x20
        public UnityEngine.Transform otherTargetsRoot; // 0x28
        public UnityEngine.Transform positionOffsetSpace; // 0x30
        public WeightCurve[] weightCurves; // 0x38

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial1(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial2(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial3(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial4(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void get_length(){} // RVA: 0x7FFE81163460
        public void set_length(){} // RVA: 0x7FFE81163470
        public void get_lastUsedInteractionSystem(){} // RVA: 0x7FFE811C3500
        public void set_lastUsedInteractionSystem(){} // RVA: 0x7FFE811C3510
        public void Initiate(){} // RVA: 0x7FFE8124EBF0
        public void get_lookAtTarget(){} // RVA: 0x7FFE8124EEB0
        public void GetTarget(){} // RVA: 0x7FFE81250830 | overloaded x3
        public void CurveUsed(){} // RVA: 0x7FFE8124F1C0
        public void GetTargets(){} // RVA: 0x7FFE81199370
        public void OnStartInteraction(){} // RVA: 0x7FFE811C3510
        public void Apply(){} // RVA: 0x7FFE8124FF70 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFE8124FAC0
        public void get_targetsRoot(){} // RVA: 0x7FFE8124FE40
        public void Start(){} // RVA: 0x7FFE8124FF60
        public void GetWeightCurveIndex(){} // RVA: 0x7FFE812508E0
        public void GetMultiplierIndex(){} // RVA: 0x7FFE81250940
        public void .ctor(){} // RVA: 0x7FFE812509A0
    }

    public class InteractionSystem : MonoBehaviour
    {
        public string targetTag; // 0x20
        public float fadeInTime; // 0x28
        public float speed; // 0x2C

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial1(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial2(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial3(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial4(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void get_inInteraction(){} // RVA: 0x7FFE812513C0
        public void IsInInteraction(){} // RVA: 0x7FFE81251480
        public void IsPaused(){} // RVA: 0x7FFE81251620 | overloaded x2
        public void IsInSync(){} // RVA: 0x7FFE812516E0
        public void StartInteraction(){} // RVA: 0x7FFE81251810
        public void PauseInteraction(){} // RVA: 0x7FFE81251980
        public void ResumeInteraction(){} // RVA: 0x7FFE81251A10
        public void StopInteraction(){} // RVA: 0x7FFE81251AA0
        public void PauseAll(){} // RVA: 0x7FFE81251B30
        public void ResumeAll(){} // RVA: 0x7FFE81251BB0
        public void StopAll(){} // RVA: 0x7FFE81251C90
        public void GetInteractionObject(){} // RVA: 0x7FFE81251D10
        public void GetProgress(){} // RVA: 0x7FFE81251DA0
        public void GetMinActiveProgress(){} // RVA: 0x7FFE81251E40
        public void TriggerInteraction(){} // RVA: 0x7FFE81252400 | overloaded x3
        public void GetClosestInteractionRange(){} // RVA: 0x7FFE812527A0
        public void GetClosestInteractionObjectInRange(){} // RVA: 0x7FFE81252890
        public void GetClosestInteractionTargetInRange(){} // RVA: 0x7FFE812528E0
        public void GetClosestInteractionObjectsInRange(){} // RVA: 0x7FFE81252950
        public void GetClosestInteractionTargetsInRange(){} // RVA: 0x7FFE81252AE0
        public void TriggerEffectorsReady(){} // RVA: 0x7FFE81252C90
        public void GetTriggerRange(){} // RVA: 0x7FFE81252FE0
        public void GetClosestTriggerIndex(){} // RVA: 0x7FFE81253160
        public void get_ik(){} // RVA: 0x7FFE81253460
        public void set_ik(){} // RVA: 0x7FFE81253470
        public void get_triggersInRange(){} // RVA: 0x7FFE8119C0E0
        public void set_triggersInRange(){} // RVA: 0x7FFE812534D0
        public void Start(){} // RVA: 0x7FFE81253530
        public void InteractionPause(){} // RVA: 0x7FFE81254030
        public void InteractionResume(){} // RVA: 0x7FFE81254050
        public void InteractionStop(){} // RVA: 0x7FFE81254050
        public void LookAtInteraction(){} // RVA: 0x7FFE81254070
        public void OnTriggerEnter(){} // RVA: 0x7FFE81254210
        public void OnTriggerExit(){} // RVA: 0x7FFE81254440
        public void ContactIsInRange(){} // RVA: 0x7FFE81254610
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFE812548A0
        public void Update(){} // RVA: 0x7FFE81254B60
        public void Raycasting(){} // RVA: 0x7FFE81254EE0
        public void UpdateTriggerEventBroadcasting(){} // RVA: 0x7FFE81255150
        public void UpdateEffectors(){} // RVA: 0x7FFE812558D0
        public void OnPreFBBIK(){} // RVA: 0x7FFE81255AD0
        public void OnPostFBBIK(){} // RVA: 0x7FFE81255D40
        public void OnFixTransforms(){} // RVA: 0x7FFE81255FB0
        public void OnDestroy(){} // RVA: 0x7FFE812560C0
        public void IsValid(){} // RVA: 0x7FFE812568B0
        public void TriggerIndexIsValid(){} // RVA: 0x7FFE81256A40
        public void .ctor(){} // RVA: 0x7FFE81256C20
    }

    public class InteractionTarget : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial1(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial2(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial3(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial4(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetValue(){} // RVA: 0x7FFE81257590
        public void ResetRotation(){} // RVA: 0x7FFE81257600
        public void RotateTo(){} // RVA: 0x7FFE81257730
        public void .ctor(){} // RVA: 0x7FFE81258540
    }

    public class InteractionTrigger : MonoBehaviour
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OpenTutorial4(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void Start(){} // RVA: 0x7FFE810FB310
        public void GetBestRangeIndex(){} // RVA: 0x7FFE812585E0
        public void .ctor(){} // RVA: 0x7FFE81258900
    }

    public class LegIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetIKSolver(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE811CAB20
    }

    public class LimbIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetIKSolver(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE811CAC00
    }

    public class LookAtController : MonoBehaviour
    {
        public RootMotion.FinalIK.LookAtIK ik; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE8126C790
        public void LateUpdate(){} // RVA: 0x7FFE8126C850
        public void get_pivot(){} // RVA: 0x7FFE8126D470
        public void ApplyMinDistance(){} // RVA: 0x7FFE8126D800
        public void RootRotation(){} // RVA: 0x7FFE8126D9C0
        public void .ctor(){} // RVA: 0x7FFE8126E070
    }

    public class LookAtIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetIKSolver(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE811CACE0
    }

    public class OffsetModifier : MonoBehaviour
    {
        public float weight; // 0x20

        // ── Methods ──
        public void get_deltaTime(){} // RVA: 0x7FFE8126E140
        public void OnModifyOffset(){} // RVA: 0x7FFE80E45FE0
        public void Start(){} // RVA: 0x7FFE8126E1A0
        public void Initiate(){} // RVA: 0x7FFE8126E250
        public void ModifyOffset(){} // RVA: 0x7FFE8126E2F0
        public void ApplyLimits(){} // RVA: 0x7FFE8126E4C0
        public void OnDestroy(){} // RVA: 0x7FFE8126E630
        public void .ctor(){} // RVA: 0x7FFE81103920
    }

    public class OffsetModifierVRIK : MonoBehaviour
    {
        public float weight; // 0x20

        // ── Methods ──
        public void get_deltaTime(){} // RVA: 0x7FFE8126E140
        public void OnModifyOffset(){} // RVA: 0x7FFE80E45FE0
        public void Start(){} // RVA: 0x7FFE8126F0E0
        public void Initiate(){} // RVA: 0x7FFE8126F190
        public void ModifyOffset(){} // RVA: 0x7FFE8126F230
        public void OnDestroy(){} // RVA: 0x7FFE8126F400
        public void .ctor(){} // RVA: 0x7FFE81103920
    }

    public class OffsetPose : MonoBehaviour
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFE8126FA60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8126FB20
    }

    public class PenetrationAvoidance : OffsetModifier
    {
        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFE81270190
        public void .ctor(){} // RVA: 0x7FFE81103920
    }

    public class Poser : SolverManager
    {
        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x7FFE80E45FE0
        public void UpdateManual(){} // RVA: 0x7FFE8125C1C0
        public void InitiatePoser(){} // RVA: 0x7FFE80E45FE0
        public void UpdatePoser(){} // RVA: 0x7FFE80E45FE0
        public void FixPoserTransforms(){} // RVA: 0x7FFE80E45FE0
        public void UpdateSolver(){} // RVA: 0x7FFE8125C1E0
        public void InitiateSolver(){} // RVA: 0x7FFE8125C230
        public void FixTransforms(){} // RVA: 0x7FFE8125C260
        public void .ctor(){} // RVA: 0x7FFE8125AD50
    }

    public class RagdollUtility : MonoBehaviour
    {
        public RootMotion.FinalIK.IK ik; // 0x20
        public float ragdollToAnimationTime; // 0x28

        // ── Methods ──
        public void EnableRagdoll(){} // RVA: 0x7FFE8125C280
        public void DisableRagdoll(){} // RVA: 0x7FFE8125C2E0
        public void Start(){} // RVA: 0x7FFE8125C3F0
        public void DisableRagdollSmooth(){} // RVA: 0x7FFE8125CE90
        public void Update(){} // RVA: 0x7FFE8125CF30
        public void FixedUpdate(){} // RVA: 0x7FFE8125D240
        public void LateUpdate(){} // RVA: 0x7FFE8125D280
        public void AfterLastIK(){} // RVA: 0x7FFE8125D3C0
        public void AfterAnimation(){} // RVA: 0x7FFE8125D410
        public void OnFinalPose(){} // RVA: 0x7FFE8125D450
        public void RagdollEnabler(){} // RVA: 0x7FFE8125D490
        public void get_isRagdoll(){} // RVA: 0x7FFE8125D800
        public void RecordVelocities(){} // RVA: 0x7FFE8125D8F0
        public void get_ikUsed(){} // RVA: 0x7FFE8125DBD0
        public void StoreLocalState(){} // RVA: 0x7FFE8125DE00
        public void FixTransforms(){} // RVA: 0x7FFE8125DF50
        public void OnDestroy(){} // RVA: 0x7FFE8125E310
        public void .ctor(){} // RVA: 0x7FFE8125E520
    }

    public class Recoil : OffsetModifier
    {
        public RootMotion.FinalIK.AimIK aimIK; // 0x38
        public bool aimIKSolvedLast; // 0x40
        public 0x665BBC9C handedness; // 0x44
        public bool twoHanded; // 0x48
        public UnityEngine.AnimationCurve recoilWeight; // 0x50

        // ── Methods ──
        public void get_isFinished(){} // RVA: 0x7FFE81270B60
        public void SetHandRotations(){} // RVA: 0x7FFE81270BC0
        public void Fire(){} // RVA: 0x7FFE81270BF0
        public void OnModifyOffset(){} // RVA: 0x7FFE81270F50
        public void AfterFBBIK(){} // RVA: 0x7FFE812725D0
        public void AfterAimIK(){} // RVA: 0x7FFE81272930
        public void get_primaryHandEffector(){} // RVA: 0x7FFE81272980
        public void get_secondaryHandEffector(){} // RVA: 0x7FFE812729F0
        public void get_primaryHand(){} // RVA: 0x7FFE81272A60
        public void get_secondaryHand(){} // RVA: 0x7FFE81272A80
        public void OnDestroy(){} // RVA: 0x7FFE81272AA0
        public void .ctor(){} // RVA: 0x7FFE81272E10
    }

    public class RotationLimit : MonoBehaviour
    {
        public UnityEngine.Vector3 axis; // 0x20
        public UnityEngine.Quaternion defaultLocalRotation; // 0x2C
        public bool _defaultLocalRotationOverride; // 0x3C

        // ── Methods ──
        public void SetDefaultLocalRotation(){} // RVA: 0x7FFE8125FE10 | overloaded x2
        public void GetLimitedLocalRotation(){} // RVA: 0x7FFE8125FE20
        public void Apply(){} // RVA: 0x7FFE812601F0
        public void Disable(){} // RVA: 0x7FFE812603A0
        public void get_secondaryAxis(){} // RVA: 0x7FFE81260440
        public void get_crossAxis(){} // RVA: 0x7FFE81260460
        public void get_defaultLocalRotationOverride(){} // RVA: 0x7FFE812604E0
        public void set_defaultLocalRotationOverride(){} // RVA: 0x7FFE812604F0
        public void LimitRotation(){}
        public void Awake(){} // RVA: 0x7FFE81260500
        public void LateUpdate(){} // RVA: 0x7FFE812606C0
        public void LogWarning(){} // RVA: 0x7FFE811B06F0
        public void Limit1DOF(){} // RVA: 0x7FFE812606D0
        public void LimitTwist(){} // RVA: 0x7FFE81260A20
        public void GetOrthogonalAngle(){} // RVA: 0x7FFE81261030
        public void .ctor(){} // RVA: 0x7FFE81261110
    }

    public class RotationLimitAngle : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void LimitRotation(){} // RVA: 0x7FFE812611A0
        public void LimitSwing(){} // RVA: 0x7FFE81261250
        public void .ctor(){} // RVA: 0x7FFE812616D0
    }

    public class RotationLimitHinge : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void LimitRotation(){} // RVA: 0x7FFE812616F0
        public void LimitHinge(){} // RVA: 0x7FFE81261740
        public void .ctor(){} // RVA: 0x7FFE81261C20
    }

    public class RotationLimitPolygonal : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void SetLimitPoints(){} // RVA: 0x7FFE81261C80
        public void LimitRotation(){} // RVA: 0x7FFE81261D40
        public void Start(){} // RVA: 0x7FFE81261E20
        public void ResetToDefault(){} // RVA: 0x7FFE81262040
        public void BuildReachCones(){} // RVA: 0x7FFE81262E60
        public void SmoothPoints(){} // RVA: 0x7FFE81263620
        public void GetScalar(){} // RVA: 0x7FFE81263D50
        public void PointToTangentPlane(){} // RVA: 0x7FFE81263DA0
        public void TangentPointToSphere(){} // RVA: 0x7FFE81263E90
        public void LimitSwing(){} // RVA: 0x7FFE81263FB0
        public void GetReachCone(){} // RVA: 0x7FFE812645C0
        public void .ctor(){} // RVA: 0x7FFE81264720
    }

    public class RotationLimitSpline : RotationLimit
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void SetSpline(){} // RVA: 0x7FFE81264E20
        public void LimitRotation(){} // RVA: 0x7FFE81264E90
        public void LimitSwing(){} // RVA: 0x7FFE81264F40
        public void .ctor(){} // RVA: 0x7FFE81265570
    }

    public class ShoulderRotator : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81273490
        public void RotateShoulders(){} // RVA: 0x7FFE81273660
        public void RotateShoulder(){} // RVA: 0x7FFE812737C0
        public void GetParentBoneMap(){} // RVA: 0x7FFE81273E90
        public void OnDestroy(){} // RVA: 0x7FFE81273FC0
        public void .ctor(){} // RVA: 0x7FFE812741C0
    }

    public class TrigonometricIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void SupportGroup(){} // RVA: 0x7FFE810FB310
        public void ASThread(){} // RVA: 0x7FFE810FB310
        public void GetIKSolver(){} // RVA: 0x7FFE81178740
        public void .ctor(){} // RVA: 0x7FFE811CADC0
    }

    public class TwistRelaxer : MonoBehaviour
    {
        // ── Methods ──
        public void Relax(){} // RVA: 0x7FFE81248A40
        public void Init(){} // RVA: 0x7FFE81249BA0
        public void Start(){} // RVA: 0x7FFE81249BB0
        public void OnPostUpdate(){} // RVA: 0x7FFE8124A720
        public void LateUpdate(){} // RVA: 0x7FFE8124A800
        public void OnDestroy(){} // RVA: 0x7FFE8124A8E0
        public void .ctor(){} // RVA: 0x7FFE8124AAF0
    }

    public class VRIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFE810FB310
        public void OpenScriptReference(){} // RVA: 0x7FFE810FB310
        public void OpenSetupTutorial(){} // RVA: 0x7FFE810FB310
        public void AutoDetectReferences(){} // RVA: 0x7FFE811CAEA0
        public void GuessHandOrientations(){} // RVA: 0x7FFE811CAF00
        public void GetIKSolver(){} // RVA: 0x7FFE81176730
        public void InternalInitiateSolver(){} // RVA: 0x7FFE811CAF30
        public void InitiateSolver(){} // RVA: 0x7FFE811CB010
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFE811B58F0
        public void VRCInitiateSolver(){} // RVA: 0x7FFE811CB020
        public void UpdateSolver(){} // RVA: 0x7FFE811CB030
        public void .ctor(){} // RVA: 0x7FFE811CB330
    }

    public class VRIKCalibrator : Object
    {
        // ── Methods ──
        public void RecalibrateScale(){} // RVA: 0x7FFE81274220
        public void Calibrate(){} // RVA: 0x7FFE81278160 | overloaded x2
        public void CalibrateLeg(){} // RVA: 0x7FFE81279370 | overloaded x2
    }

    public class VRIKLODController : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE81279CA0
        public void Update(){} // RVA: 0x7FFE81279D30
        public void GetLODLevel(){} // RVA: 0x7FFE81279D70
        public void .ctor(){} // RVA: 0x7FFE8127A0B0
    }

    public class VRIKRootController : MonoBehaviour
    {
        public UnityEngine.Vector3 _pelvisTargetRight; // 0x20

        // ── Methods ──
        public void get_pelvisTargetRight(){} // RVA: 0x7FFE81161EE0
        public void set_pelvisTargetRight(){} // RVA: 0x7FFE81161F00
        public void Awake(){} // RVA: 0x7FFE8127A100
        public void Calibrate(){} // RVA: 0x7FFE8127A7A0 | overloaded x2
        public void OnPreUpdate(){} // RVA: 0x7FFE8127AB60
        public void OnDestroy(){} // RVA: 0x7FFE8127B700
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

}