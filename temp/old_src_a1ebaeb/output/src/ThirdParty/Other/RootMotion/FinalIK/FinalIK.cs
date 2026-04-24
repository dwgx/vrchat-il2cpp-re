// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 87
// Methods: 971

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class AimController : MonoBehaviour
    {
        public object target; // 0x33AECBF0
        public object smoothTurnTowardsTarget; // 0x33AECBF0
        public object slerpSpeed; // 0x33AECBF0
        public object offset; // 0x33AECBF0
        public object turnToTargetTime; // 0x33AECBF0
        public object lastTarget; // 0x33AECBF0
        public object weightV; // 0x33AECBF0
        public object lastSmoothTowardsTarget; // 0x33AECBF0
        public object turnToTargetMlpV; // 0x33AECBF0
        public object pivot; // 0x17000135

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8a9c580
        public void LateUpdate(){} // RVA: 0x7ffaa8a9c6b0
        public void get_pivot(){} // RVA: 0x7ffaa8a9d480
        public void ApplyMinDistance(){} // RVA: 0x7ffaa8a9d810
        public void RootRotation(){} // RVA: 0x7ffaa8a9d9d0
        public void TurnToTarget(){} // RVA: 0x7ffaa8a9e0d0
        public void .ctor(){} // RVA: 0x7ffaa8a9e170
    }

    public class AimIK : IK
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OpenSetupTutorial(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa89ffe20
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa89af740
    }

    public class AimPoser : MonoBehaviour
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a9e570
        // ── Binary Analysis Named ──
        public void GetPose(){} // RVA: 0x7ffaa8a9e3e0
        public void SetPoseActive(){} // RVA: 0x7ffaa8a9e4f0
    }

    public class Amplifier : OffsetModifier
    {
        // ── Original Methods ──
        public void OnModifyOffset(){} // RVA: 0x7ffaa8a9e9b0
        public void .ctor(){} // RVA: 0x7ffaa893a920
    }

    public class ArmIK : IK
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa89fff00
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa89af740
    }

    public class BipedIK : SolverManager
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void InitiateBipedIK(){} // RVA: 0x7ffaa89e6bc0
        public void UpdateBipedIK(){} // RVA: 0x7ffaa89e6be0
        public void FixTransforms(){} // RVA: 0x7ffaa89e6db0
        public void InitiateSolver(){} // RVA: 0x7ffaa89e6e80
        public void UpdateSolver(){} // RVA: 0x7ffaa89e72a0
        public void LogWarning(){} // RVA: 0x7ffaa89e76f0
        public void .ctor(){} // RVA: 0x7ffaa89e7760
        // ── Binary Analysis Named ──
        public void GetIKPositionWeight(){} // RVA: 0x7ffaa89e6760
        public void GetIKRotationWeight(){} // RVA: 0x7ffaa89e6790
        public void SetIKPositionWeight(){} // RVA: 0x7ffaa89e67c0
        public void SetIKRotationWeight(){} // RVA: 0x7ffaa89e6820
        public void SetIKPosition(){} // RVA: 0x7ffaa89e6880
        public void SetIKRotation(){} // RVA: 0x7ffaa89e68c0
        public void GetIKPosition(){} // RVA: 0x7ffaa89e68f0
        public void GetIKRotation(){} // RVA: 0x7ffaa89e6950
        public void SetLookAtWeight(){} // RVA: 0x7ffaa89e6990
        public void SetLookAtPosition(){} // RVA: 0x7ffaa89e6aa0
        public void SetSpinePosition(){} // RVA: 0x7ffaa89e6ad0
        public void SetSpineWeight(){} // RVA: 0x7ffaa89e6b00
        public void GetGoalIK(){} // RVA: 0x7ffaa89e6b50
        public void SetToDefaults(){} // RVA: 0x7ffaa89e6c00
    }

    public class BipedIKSolvers : Object
    {
        public object leftHand; // 0x3370DDE0
        public object lookAt; // 0x3370DDE0
        public object _limbs; // 0x3370DDE0

        // ── Original Methods ──
        public void get_limbs(){} // RVA: 0x7ffaa89e78e0
        public void get_ikSolvers(){} // RVA: 0x7ffaa89e7ab0
        public void AssignReferences(){} // RVA: 0x7ffaa89e7d40
        public void .ctor(){} // RVA: 0x7ffaa89e7fb0
    }

    public class BodyTilt : OffsetModifier
    {
        public object poseLeft; // 0x33658720
        public object lastForward; // 0x33658720
        public object ; // 0x8443A9B0

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8a9f220
        public void OnModifyOffset(){} // RVA: 0x7ffaa8a9f330
        public void .ctor(){} // RVA: 0x7ffaa8a9f6e0
    }

    public class CCDIK : IK
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa89fffe0
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa89af740
    }

    public class Constraint : Object
    {
        // ── Original Methods ──
        public void get_isValid(){} // RVA: 0x7ffaa89e83b0
        public void UpdateConstraint(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class ConstraintPosition : Constraint
    {
        // ── Original Methods ──
        public void UpdateConstraint(){} // RVA: 0x7ffaa89e8480
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class ConstraintPositionOffset : Constraint
    {
        public object lastLocalPosition; // 0x33C24AF0

        // ── Original Methods ──
        public void UpdateConstraint(){} // RVA: 0x7ffaa89e85f0
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void get_positionChanged(){} // RVA: 0x7ffaa89e8a20
    }

    public class ConstraintRotation : Constraint
    {
        // ── Original Methods ──
        public void UpdateConstraint(){} // RVA: 0x7ffaa89e8af0
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class ConstraintRotationOffset : Constraint
    {
        public object defaultLocalRotation; // 0x336F48C0
        public object initiated; // 0x336F48C0
        public object rotationChanged; // 0x170000AD

        // ── Original Methods ──
        public void UpdateConstraint(){} // RVA: 0x7ffaa89e8c70
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void get_rotationChanged(){} // RVA: 0x7ffaa89e90b0
    }

    public class Constraints : Object
    {
        public object positionOffset; // 0x3341F540
        public object rotationOffset; // 0x3341F540

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa89e9180
        public void Initiate(){} // RVA: 0x7ffaa89e9250
        public void Update(){} // RVA: 0x7ffaa89e93b0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class EditorIK : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8a9f740
        public void Update(){} // RVA: 0x7ffaa8a9f860
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class FABRIK : IK
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8a000c0
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa89af740
    }

    public class FABRIKChain : Object
    {
        public object pin; // 0x33AEC770

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa8a04b50
        public void Initiate(){} // RVA: 0x7ffaa8a04ce0
        public void Stage1(){} // RVA: 0x7ffaa8a04d40
        public void Stage2(){} // RVA: 0x7ffaa8a04f10
        public void .ctor(){} // RVA: 0x7ffaa8a05410
        // ── Binary Analysis Named ──
        public void GetCentroid(){} // RVA: 0x7ffaa8a05150
    }

    public class FABRIKRoot : IK
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8a001a0
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa89af740
    }

    public class FBBIKArmBending : MonoBehaviour
    {
        public object bendDirectionOffsetRight; // 0x33C44500
        public object leftHandTargetRotation; // 0x33C44500
        public object OnPostArmBend; // 0x33C44500
        public object ik; // 0x339DF830

        // ── Original Methods ──
        public void LateUpdate(){} // RVA: 0x7ffaa8a054b0
        public void OnPostFBBIK(){} // RVA: 0x7ffaa8a05fb0
        public void OnDestroy(){} // RVA: 0x7ffaa8a06490
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class FBBIKHeadEffector : MonoBehaviour
    {
        public object bodyWeight; // 0x33C64530
        public object rotationWeight; // 0x33C64530
        public object bendWeight; // 0x33C64530
        public object roll; // 0x33C64530
        public object postStretchWeight; // 0x33C64530
        public object fixHead; // 0x33C64530
        public object chestDirectionWeight; // 0x33C64530
        public object offset; // 0x33C64530
        public object headToLeftThigh; // 0x33C64530
        public object rightShoulderPos; // 0x33C64530
        public object rightShoulderDist; // 0x33C64530
        public object ccdDefaultLocalRotations; // 0x33C64530
        public object stretchLocalPositions; // 0x33C64530
        public object chestLocalRotations; // 0x33C64530
        public object stretchBonesCount; // 0x33C64530

        // ── Original Methods ──
        public void VRCInitialize(){} // RVA: 0x7ffaa8a06690
        public void VRCSetAvatarMainIK(){} // RVA: 0x7ffaa8a066a0
        public void Start(){} // RVA: 0x7ffaa8a066b0
        public void Initialize(){} // RVA: 0x7ffaa8a066d0
        public void OnStoreDefaultLocalState(){} // RVA: 0x7ffaa8a06f70
        public void OnFixTransforms(){} // RVA: 0x7ffaa8a079e0
        public void OnPreRead(){} // RVA: 0x7ffaa8a082d0
        public void SpineBend(){} // RVA: 0x7ffaa8a091c0
        public void CCDPass(){} // RVA: 0x7ffaa8a09ad0
        public void Iterate(){} // RVA: 0x7ffaa8a0a360
        public void OnPostUpdate(){} // RVA: 0x7ffaa8a0b350
        public void ChestDirection(){} // RVA: 0x7ffaa8a0b960
        public void PostStretching(){} // RVA: 0x7ffaa8a0bea0
        public void LerpSolverPosition(){} // RVA: 0x7ffaa8a0c4d0
        public void Solve(){} // RVA: 0x7ffaa8a0c670
        public void OnDestroy(){} // RVA: 0x7ffaa8a0c7b0
        public void .ctor(){} // RVA: 0x7ffaa8a0ce00
    }

    public class FBIKChain : Object
    {
        public object push; // 0x337BE1E0
        public object reachSmoothing; // 0x337BE1E0
        public object children; // 0x337BE1E0
        public object rootLength; // 0x337BE1E0
        public object distance; // 0x337BE1E0
        public object pullParentSum; // 0x337BE1E0
        public object sqrMag2; // 0x337BE1E0
        public object `;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a0d710
        public void .ctor(){} // RVA: 0x7ffaa8a0d710
        public void IsValid(){} // RVA: 0x7ffaa8a0dde0
        public void Initiate(){} // RVA: 0x7ffaa8a0dfa0
        public void ReadPose(){} // RVA: 0x7ffaa8a0e220
        public void CalculateBoneLengths(){} // RVA: 0x7ffaa8a0e8c0
        public void Reach(){} // RVA: 0x7ffaa8a0efb0
        public void Push(){} // RVA: 0x7ffaa8a0f310
        public void SolveTrigonometric(){} // RVA: 0x7ffaa8a0f700
        public void Stage1(){} // RVA: 0x7ffaa8a0fa70
        public void Stage2(){} // RVA: 0x7ffaa8a0ff50
        public void SolveConstraintSystems(){} // RVA: 0x7ffaa8a101c0
        public void SolveFABRIKJoint(){} // RVA: 0x7ffaa8a10310
        public void SolveChildConstraints(){} // RVA: 0x7ffaa8a10840
        public void SolveLinearConstraint(){} // RVA: 0x7ffaa8a10b90
        public void ForwardReach(){} // RVA: 0x7ffaa8a10d20
        public void BackwardReach(){} // RVA: 0x7ffaa8a10f50
        // ── Binary Analysis Named ──
        public void SetNodes(){} // RVA: 0x7ffaa8a0da00
        public void GetNodeIndex(){} // RVA: 0x7ffaa8a0dc50
        public void GetDirToBendPoint(){} // RVA: 0x7ffaa8a10450
    }

    public class FingerRig : SolverManager
    {
        public object _initiated; // 0x33C7DDC0, was: <initiated>k__BackingField
        public object initiated; // 0x170000B1

        // ── Original Methods ──
        public void get_initiated(){} // RVA: 0x7ffaa89ec8e0
        public void set_initiated(){} // RVA: 0x7ffaa89ec8f0
        public void IsValid(){} // RVA: 0x7ffaa89ec900
        public void AutoDetect(){} // RVA: 0x7ffaa89ec980
        public void AddFinger(){} // RVA: 0x7ffaa89ece70
        public void RemoveFinger(){} // RVA: 0x7ffaa89ed1b0
        public void AddChildrenRecursive(){} // RVA: 0x7ffaa89ed3c0
        public void InitiateSolver(){} // RVA: 0x7ffaa89ed520
        public void UpdateFingerSolvers(){} // RVA: 0x7ffaa89ed620
        public void FixFingerTransforms(){} // RVA: 0x7ffaa89ed690
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa89ed8e0
        public void UpdateSolver(){} // RVA: 0x7ffaa89ed620
        public void FixTransforms(){} // RVA: 0x7ffaa89edb10
        public void .ctor(){} // RVA: 0x7ffaa89edb30
    }

    public class FullBodyBipedIK : IK
    {
        public object solver; // 0x339F7C50

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OpenSetupTutorial(){} // RVA: 0x7ffaa8932310
        public void OpenInspectorTutorial(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void ReferencesError(){} // RVA: 0x7ffaa8a00380
        public void ReferencesWarning(){} // RVA: 0x7ffaa8a007d0
        public void Reinitiate(){} // RVA: 0x7ffaa8a00f70
        public void AutoDetectReferences(){} // RVA: 0x7ffaa8a00fa0
        public void VRCSetAvatarMainIK(){} // RVA: 0x7ffaa89edc10
        public void VRCInitiateSolver(){} // RVA: 0x7ffaa8a01150
        public void InitiateSolver(){} // RVA: 0x7ffaa8a01160
        public void .ctor(){} // RVA: 0x7ffaa8a01170
        // ── Binary Analysis Named ──
        public void SetReferences(){} // RVA: 0x7ffaa8a00310
        public void GetIKSolver(){} // RVA: 0x7ffaa89d30e0
    }

    public class GenericPoser : Poser
    {
        // ── Original Methods ──
        public void AutoMapping(){} // RVA: 0x7ffaa8a912b0
        public void InitiatePoser(){} // RVA: 0x7ffaa8a91840
        public void UpdatePoser(){} // RVA: 0x7ffaa8a91850
        public void FixPoserTransforms(){} // RVA: 0x7ffaa8a919c0
        public void StoreDefaultState(){} // RVA: 0x7ffaa8a91b20
        public void .ctor(){} // RVA: 0x7ffaa8a91d50
        // ── Binary Analysis Named ──
        public void GetTargetNamed(){} // RVA: 0x7ffaa8a91c90
    }

    public class Grounder : MonoBehaviour
    {
        public object OnPreGrounder; // 0x334E87F0

        // ── Original Methods ──
        public void ResetPosition(){} // RVA: 0x7ffaa8660cc0
        public void get_initiated(){} // RVA: 0x7ffaa89edc00
        public void set_initiated(){} // RVA: 0x7ffaa89edc10
        public void LogWarning(){} // RVA: 0x7ffaa89e76f0
        public void OpenUserManual(){} // RVA: 0x7ffaa8660cc0
        public void OpenScriptReference(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa89ee260
        // ── Binary Analysis Named ──
        public void GetSpineOffsetTarget(){} // RVA: 0x7ffaa89edc20
        public void GetLegSpineBendVector(){} // RVA: 0x7ffaa89edd60
        public void GetLegSpineTangent(){} // RVA: 0x7ffaa89edfb0
    }

    public class GrounderBipedIK : Grounder
    {
        public object spineSpeed; // 0x33611A50
        public object animatedPelvisLocalPosition; // 0x33611A50
        public object lastWeight; // 0x33611A50
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void ResetPosition(){} // RVA: 0x7ffaa89ee380
        public void IsReadyToInitiate(){} // RVA: 0x7ffaa89ee3f0
        public void Update(){} // RVA: 0x7ffaa89ee510
        public void Initiate(){} // RVA: 0x7ffaa89ee660
        public void OnDisable(){} // RVA: 0x7ffaa89eebf0
        public void OnSolverUpdate(){} // RVA: 0x7ffaa89eec50
        public void OnPostSolverUpdate(){} // RVA: 0x7ffaa89ef890
        public void OnDestroy(){} // RVA: 0x7ffaa89efce0
        public void .ctor(){} // RVA: 0x7ffaa89f0020
        // ── Binary Analysis Named ──
        public void SetLegIK(){} // RVA: 0x7ffaa89ef770
    }

    public class GrounderFBBIK : Grounder
    {
        public object spineSpeed; // 0x335ABBC0
        public object spineOffset; // 0x335ABBC0
        public object ; // 0x84431730
        public object SpineEffector[];

        // ── Original Methods ──
        public void OpenTutorial(){} // RVA: 0x7ffaa8932310
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void ResetPosition(){} // RVA: 0x7ffaa89f0150
        public void IsReadyToInitiate(){} // RVA: 0x7ffaa89f01c0
        public void Update(){} // RVA: 0x7ffaa89f02c0
        public void FixedUpdate(){} // RVA: 0x7ffaa89f0400
        public void LateUpdate(){} // RVA: 0x7ffaa89f0400
        public void Initiate(){} // RVA: 0x7ffaa89f0410
        public void OnSolverUpdate(){} // RVA: 0x7ffaa89f07d0
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaa89f1180
        public void OnDestroy(){} // RVA: 0x7ffaa89f14d0
        public void .ctor(){} // RVA: 0x7ffaa89f16d0
        // ── Binary Analysis Named ──
        public void SetLegIK(){} // RVA: 0x7ffaa89f0d90
    }

    public class GrounderIK : Grounder
    {
        public object characterRoot; // 0x3379ED40
        public object maxRootRotationAngle; // 0x3379ED40
        public object animatedPelvisLocalPosition; // 0x3379ED40
        public object solved; // 0x3379ED40
        public object `;

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void ResetPosition(){} // RVA: 0x7ffaa89f1810
        public void IsReadyToInitiate(){} // RVA: 0x7ffaa89f1830
        public void OnDisable(){} // RVA: 0x7ffaa89f1b10
        public void Update(){} // RVA: 0x7ffaa89f1c80
        public void Initiate(){} // RVA: 0x7ffaa89f26c0
        public void OnSolverUpdate(){} // RVA: 0x7ffaa89f2fd0
        public void OnPostSolverUpdate(){} // RVA: 0x7ffaa89f3ad0
        public void OnDestroy(){} // RVA: 0x7ffaa89f3f30
        public void .ctor(){} // RVA: 0x7ffaa89f4230
        // ── Binary Analysis Named ──
        public void SetLegIK(){} // RVA: 0x7ffaa89f3520
    }

    public class GrounderQuadruped : Grounder
    {
        public object minRootRotation; // 0x3397ED80
        public object maxLegOffset; // 0x3397ED80
        public object characterRoot; // 0x3397ED80
        public object head; // 0x3397ED80
        public object gravity; // 0x3397ED80
        public object animatedPelvisLocalRotation; // 0x3397ED80
        public object solvedPelvisLocalRotation; // 0x3397ED80
        public object solved; // 0x3397ED80
        public object headRotation; // 0x3397ED80

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void ResetPosition(){} // RVA: 0x7ffaa89f4350
        public void IsReadyToInitiate(){} // RVA: 0x7ffaa89f4390
        public void IsReadyToInitiateLegs(){} // RVA: 0x7ffaa89f4610
        public void OnDisable(){} // RVA: 0x7ffaa89f4850
        public void Update(){} // RVA: 0x7ffaa89f48d0
        public void Initiate(){} // RVA: 0x7ffaa89f4940
        public void InitiateFeet(){} // RVA: 0x7ffaa89f50c0
        public void LateUpdate(){} // RVA: 0x7ffaa89f5790
        public void RootRotation(){} // RVA: 0x7ffaa89f58a0
        public void OnSolverUpdate(){} // RVA: 0x7ffaa89f6320
        public void UpdateForefeetRoot(){} // RVA: 0x7ffaa89f7400
        public void OnPostSolverUpdate(){} // RVA: 0x7ffaa89f7b40
        public void OnDestroy(){} // RVA: 0x7ffaa89f82e0
        public void DestroyLegs(){} // RVA: 0x7ffaa89f8320
        public void .ctor(){} // RVA: 0x7ffaa89f8610
        // ── Binary Analysis Named ──
        public void SetFootIK(){} // RVA: 0x7ffaa89f7950
    }

    public class GrounderVRIK : Grounder
    {
        public object solver; // 0x3374DBF0

        // ── Original Methods ──
        public void OpenTutorial(){} // RVA: 0x7ffaa8932310
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void ResetPosition(){} // RVA: 0x7ffaa89f1810
        public void IsReadyToInitiate(){} // RVA: 0x7ffaa89f8c20
        public void Update(){} // RVA: 0x7ffaa89f8d20
        public void Initiate(){} // RVA: 0x7ffaa89f8e50
        public void OnSolverUpdate(){} // RVA: 0x7ffaa89f9230
        public void OnPostSolverUpdate(){} // RVA: 0x7ffaa89f9800
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaa89f9df0
        public void OnDestroy(){} // RVA: 0x7ffaa89fa140
        public void .ctor(){} // RVA: 0x7ffaa89fa470
        // ── Binary Analysis Named ──
        public void SetLegIK(){} // RVA: 0x7ffaa89f96d0
    }

    public class Grounding : Object
    {
        public object heightOffset; // 0x332E2450
        public object footCenterOffset; // 0x332E2450
        public object footRotationSpeed; // 0x332E2450
        public object pelvisSpeed; // 0x332E2450
        public object liftPelvisWeight; // 0x332E2450
        public object quality; // 0x332E2450
        public object _isGrounded; // 0x332E2450, was: <isGrounded>k__BackingField
        public object initiated; // 0x332E2450
        public object legs; // 0x170000B3
        public object pelvis; // 0x170000B4
        public object isGrounded; // 0x170000B5
        public object root; // 0x170000B6
        public object rootHit; // 0x170000B7
        public object rootGrounded; // 0x170000B8
        public object up; // 0x170000B9
        public object useRootRotation; // 0x170000BA

        // ── Original Methods ──
        public void get_legs(){} // RVA: 0x7ffaa89fa500
        public void set_legs(){} // RVA: 0x7ffaa89fa510
        public void get_pelvis(){} // RVA: 0x7ffaa89d0370
        public void set_pelvis(){} // RVA: 0x7ffaa89d0380
        public void get_isGrounded(){} // RVA: 0x7ffaa89fa570
        public void set_isGrounded(){} // RVA: 0x7ffaa89fa580
        public void get_root(){} // RVA: 0x7ffaa89fa590
        public void set_root(){} // RVA: 0x7ffaa89fa5a0
        public void get_rootHit(){} // RVA: 0x7ffaa89fa600
        public void set_rootHit(){} // RVA: 0x7ffaa89fa630
        public void get_rootGrounded(){} // RVA: 0x7ffaa89fa660
        public void IsValid(){} // RVA: 0x7ffaa89fac90
        public void Initiate(){} // RVA: 0x7ffaa89faef0
        public void Update(){} // RVA: 0x7ffaa89fb4a0
        public void Reset(){} // RVA: 0x7ffaa89fbc10
        public void LogWarning(){} // RVA: 0x7ffaa89fbff0
        public void get_up(){} // RVA: 0x7ffaa89fc010
        public void Flatten(){} // RVA: 0x7ffaa89fc290
        public void get_useRootRotation(){} // RVA: 0x7ffaa89fc3d0
        public void .ctor(){} // RVA: 0x7ffaa89fc580
        // ── Binary Analysis Named ──
        public void GetRootHit(){} // RVA: 0x7ffaa89fa680
        public void GetLegsPlaneNormal(){} // RVA: 0x7ffaa89fb730
        public void GetVerticalOffset(){} // RVA: 0x7ffaa89fc0a0
        public void GetFootCenterOffset(){} // RVA: 0x7ffaa89fc4a0
    }

    public class HandPoser : Poser
    {
        public object poseChildren; // 0x33A141B0

        // ── Original Methods ──
        public void AutoMapping(){} // RVA: 0x7ffaa8a92290
        public void InitiatePoser(){} // RVA: 0x7ffaa8a92500
        public void FixPoserTransforms(){} // RVA: 0x7ffaa8a925c0
        public void UpdatePoser(){} // RVA: 0x7ffaa8a92760
        public void StoreDefaultState(){} // RVA: 0x7ffaa8a92f00
        public void .ctor(){} // RVA: 0x7ffaa8a91d50
    }

    public class HitReaction : OffsetModifier
    {
        // ── Original Methods ──
        public void get_inProgress(){} // RVA: 0x7ffaa8a9f9a0
        public void OnModifyOffset(){} // RVA: 0x7ffaa8a9fa50
        public void Hit(){} // RVA: 0x7ffaa8a9fb30
        public void .ctor(){} // RVA: 0x7ffaa893a920
    }

    public class HitReactionVRIK : OffsetModifierVRIK
    {
        public object rotationOffsets; // 0x333232D0

        // ── Original Methods ──
        public void OnModifyOffset(){} // RVA: 0x7ffaa8aa13b0
        public void Hit(){} // RVA: 0x7ffaa8aa1480
        public void .ctor(){} // RVA: 0x7ffaa893a920
    }

    public class IK : SolverManager
    {
        // ── Original Methods ──
        public void UpdateSolver(){} // RVA: 0x7ffaa8a01300
        public void InitiateSolver(){} // RVA: 0x7ffaa8a013a0
        public void FixTransforms(){} // RVA: 0x7ffaa8a01450
        public void OpenUserManual(){} // RVA: 0x7ffaa8660cc0
        public void OpenScriptReference(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa898c060
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa86491d0
    }

    public class IKConstraintBend : Object
    {
        public object bone3; // 0x338F7BA0
        public object rotationOffset; // 0x338F7BA0
        public object defaultChildDirection; // 0x338F7BA0
        public object nodeIndex1; // 0x338F7BA0
        public object chainIndex3; // 0x338F7BA0
        public object limbOrientationsSet; // 0x338F7BA0
        public object initiated; // 0x170000CE
        public object Parent; // 0x81C0C5E0
        public object Bone3; // 0x81C0C5E0

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa8a11920
        public void get_initiated(){} // RVA: 0x7ffaa8a11ce0
        public void set_initiated(){} // RVA: 0x7ffaa8a11cf0
        public void .ctor(){} // RVA: 0x7ffaa8a11d60
        public void .ctor(){} // RVA: 0x7ffaa8a11d60
        public void Initiate(){} // RVA: 0x7ffaa8a11f00
        public void LimitBend(){} // RVA: 0x7ffaa8a12bf0
        public void OrthoToLimb(){} // RVA: 0x7ffaa8a14490
        public void OrthoToBone1(){} // RVA: 0x7ffaa8a14600
        // ── Binary Analysis Named ──
        public void SetBones(){} // RVA: 0x7ffaa8a11e00
        public void SetLimbOrientation(){} // RVA: 0x7ffaa8a12940
        public void GetDir(){} // RVA: 0x7ffaa8a13860
    }

    public class IKEffector : Object
    {
        public object positionWeight; // 0x333904F0
        public object rotation; // 0x333904F0
        public object effectChildNodes; // 0x333904F0
        public object planeBone1; // 0x333904F0
        public object planeRotationOffset; // 0x333904F0
        public object localPositions; // 0x333904F0
        public object animatedPosition; // 0x333904F0
        public object nodeIndex; // 0x333904F0
        public object plane2ChainIndex; // 0x333904F0
        public object plane3NodeIndex; // 0x333904F0
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void get_isEndEffector(){} // RVA: 0x7ffaa89ec8e0
        public void set_isEndEffector(){} // RVA: 0x7ffaa89ec8f0
        public void PinToBone(){} // RVA: 0x7ffaa8a147d0
        public void .ctor(){} // RVA: 0x7ffaa8a14c50
        public void .ctor(){} // RVA: 0x7ffaa8a14c50
        public void IsValid(){} // RVA: 0x7ffaa8a15050
        public void Initiate(){} // RVA: 0x7ffaa8a15660
        public void ResetOffset(){} // RVA: 0x7ffaa8a15c40
        public void OnPreSolve(){} // RVA: 0x7ffaa8a15fc0
        public void OnPostWrite(){} // RVA: 0x7ffaa8a16990
        public void Update(){} // RVA: 0x7ffaa8a16d60
        // ── Binary Analysis Named ──
        public void GetNode(){} // RVA: 0x7ffaa8a14770
        public void SetToTarget(){} // RVA: 0x7ffaa8a15e10
        public void GetPlaneRotation(){} // RVA: 0x7ffaa8a169e0
        public void GetPosition(){} // RVA: 0x7ffaa8a171c0
    }

    public class IKExecutionOrder : MonoBehaviour
    {
        public object fixedFrame; // 0x335E3770
        public object animatePhysics; // 0x170000C9

        // ── Original Methods ──
        public void get_animatePhysics(){} // RVA: 0x7ffaa8a014c0
        public void Start(){} // RVA: 0x7ffaa8a015f0
        public void Update(){} // RVA: 0x7ffaa8a017b0
        public void FixedUpdate(){} // RVA: 0x7ffaa8a017e0
        public void LateUpdate(){} // RVA: 0x7ffaa8a01810
        public void FixTransforms(){} // RVA: 0x7ffaa8a019a0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class IKMapping : Object
    {
        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa8a17850
        public void Initiate(){} // RVA: 0x7ffaa8932310
        public void BoneIsValid(){} // RVA: 0x7ffaa8a17860
        public void SolveFABRIKJoint(){} // RVA: 0x7ffaa8a10310
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class IKMappingBone : IKMapping
    {
        public object boneMap; // 0x33542400

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa8a1b050
        public void .ctor(){} // RVA: 0x7ffaa8a1b250
        public void .ctor(){} // RVA: 0x7ffaa8a1b250
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a1b380
        public void FixTransforms(){} // RVA: 0x7ffaa8a1b3a0
        public void Initiate(){} // RVA: 0x7ffaa8a1b420
        public void ReadPose(){} // RVA: 0x7ffaa8a1b580
        public void WritePose(){} // RVA: 0x7ffaa8a1b5a0
    }

    public class IKMappingLimb : IKMapping
    {
        public object bone2; // 0x33C7EA00
        public object weight; // 0x33C7EA00
        public object boneMap1; // 0x33C7EA00
        public object IsValid; // 0xB41EFD10

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa8a1b5d0
        public void .ctor(){} // RVA: 0x7ffaa8a1c570
        public void .ctor(){} // RVA: 0x7ffaa8a1c570
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a1c950
        public void FixTransforms(){} // RVA: 0x7ffaa8a1ca60
        public void Initiate(){} // RVA: 0x7ffaa8a1cca0
        public void ReadPose(){} // RVA: 0x7ffaa8a1d300
        public void WritePose(){} // RVA: 0x7ffaa8a1d380
        // ── Binary Analysis Named ──
        public void GetBoneMap(){} // RVA: 0x7ffaa8a1b670
        public void SetLimbOrientation(){} // RVA: 0x7ffaa8a1b7b0
        public void SetBones(){} // RVA: 0x7ffaa8a1c800
    }

    public class IKMappingSpine : IKMapping
    {
        public object rightUpperArmBone; // 0x337C4330
        public object iterations; // 0x337C4330
        public object spine; // 0x337C4330
        public object leftThigh; // 0x337C4330

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa8a1d5c0
        public void .ctor(){} // RVA: 0x7ffaa8a1e040
        public void .ctor(){} // RVA: 0x7ffaa8a1e040
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a1e4f0
        public void FixTransforms(){} // RVA: 0x7ffaa8a1e660
        public void Initiate(){} // RVA: 0x7ffaa8a1e6f0
        public void UseFABRIK(){} // RVA: 0x7ffaa8a1f360
        public void ReadPose(){} // RVA: 0x7ffaa8a1f390
        public void WritePose(){} // RVA: 0x7ffaa8a1f7d0
        public void ForwardReach(){} // RVA: 0x7ffaa8a1fcf0
        public void BackwardReach(){} // RVA: 0x7ffaa8a1ff30
        public void MapToSolverPositions(){} // RVA: 0x7ffaa8a20160
        // ── Binary Analysis Named ──
        public void SetBones(){} // RVA: 0x7ffaa8a1e340
    }

    public class IKSolver : Object
    {
        public object _initiated; // 0x3341C730, was: <initiated>k__BackingField
        public object OnPreUpdate; // 0x3341C730
        public object root; // 0x3341C730
        public object initiated; // 0x170000D3

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa864a2a0
        public void IsValid(){} // RVA: 0x7ffaa864a2a0
        public void Initiate(){} // RVA: 0x7ffaa8a20730
        public void Update(){} // RVA: 0x7ffaa8a20920
        public void get_initiated(){} // RVA: 0x7ffaa8a209d0
        public void set_initiated(){} // RVA: 0x7ffaa8a209e0
        public void FixTransforms(){} // RVA: 0x7ffaa8660cc0
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8660cc0
        public void OnInitiate(){} // RVA: 0x7ffaa8660cc0
        public void OnUpdate(){} // RVA: 0x7ffaa8660cc0
        public void LogWarning(){} // RVA: 0x7ffaa8a209f0
        public void ContainsDuplicateBone(){} // RVA: 0x7ffaa8a20aa0
        public void HierarchyIsValid(){} // RVA: 0x7ffaa8a20c70
        public void PreSolveBones(){} // RVA: 0x7ffaa8a20d00
        public void .ctor(){} // RVA: 0x7ffaa8a211a0
        // ── Binary Analysis Named ──
        public void GetIKPosition(){} // RVA: 0x7ffaa894f8d0
        public void SetIKPosition(){} // RVA: 0x7ffaa894f8f0
        public void GetIKPositionWeight(){} // RVA: 0x7ffaa89ff570
        public void SetIKPositionWeight(){} // RVA: 0x7ffaa8a209a0
        public void GetRoot(){} // RVA: 0x7ffaa89d30e0
        public void GetPoints(){} // RVA: 0x7ffaa86491d0
        public void GetPoint(){} // RVA: 0x7ffaa8649280
    }

    public class IKSolverAim : IKSolverHeuristic
    {
        public object poleAxis; // 0x336BCE40
        public object poleTarget; // 0x336BCE40
        public object OnPreIteration; // 0x336BCE40
        public object transformLimit; // 0x336BCE40

        // ── Original Methods ──
        public void get_transformAxis(){} // RVA: 0x7ffaa8a235d0
        public void get_transformPoleAxis(){} // RVA: 0x7ffaa8a23840
        public void OnInitiate(){} // RVA: 0x7ffaa8a23ab0
        public void OnUpdate(){} // RVA: 0x7ffaa8a23f90
        public void get_minBones(){} // RVA: 0x7ffaa8a24af0
        public void Solve(){} // RVA: 0x7ffaa8a24b00
        public void RotateToTarget(){} // RVA: 0x7ffaa8a251d0
        public void get_localDirection(){} // RVA: 0x7ffaa8a26080
        public void .ctor(){} // RVA: 0x7ffaa8a26190
        // ── Binary Analysis Named ──
        public void GetAngle(){} // RVA: 0x7ffaa8a234c0
        public void GetClampedIKPosition(){} // RVA: 0x7ffaa8a24c50
    }

    public class IKSolverArm : IKSolver
    {
        public object chest; // 0x337C5DF0
        public object forearm; // 0x337C5DF0
        public object arm; // 0x337C5DF0
        public object solver; // 0x3397FBA0

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa8a26250
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a27260
        public void FixTransforms(){} // RVA: 0x7ffaa8a272c0
        public void OnInitiate(){} // RVA: 0x7ffaa8a27330
        public void OnUpdate(){} // RVA: 0x7ffaa8a27450
        public void Solve(){} // RVA: 0x7ffaa8a274f0
        public void Read(){} // RVA: 0x7ffaa8a27580
        public void Write(){} // RVA: 0x7ffaa8a27dc0
        public void .ctor(){} // RVA: 0x7ffaa8a28160
        // ── Binary Analysis Named ──
        public void SetChain(){} // RVA: 0x7ffaa8a26940
        public void GetPoints(){} // RVA: 0x7ffaa8a26b60
        public void GetPoint(){} // RVA: 0x7ffaa8a26d10
    }

    public class IKSolverCCD : IKSolverHeuristic
    {
        // ── Original Methods ──
        public void FadeOutBoneWeights(){} // RVA: 0x7ffaa8a28690
        public void OnInitiate(){} // RVA: 0x7ffaa8a28730
        public void OnUpdate(){} // RVA: 0x7ffaa8a28880
        public void Solve(){} // RVA: 0x7ffaa8a28d80
        public void .ctor(){} // RVA: 0x7ffaa8a29c30
    }

    public class IKSolverFABRIK : IKSolverHeuristic
    {
        public object solverLocalPositions; // 0x33C642F0
        public object boneLengthCanBeZero; // 0x170000D9

        // ── Original Methods ──
        public void SolveForward(){} // RVA: 0x7ffaa8a29c40
        public void SolveBackward(){} // RVA: 0x7ffaa8a29cf0
        public void OnInitiate(){} // RVA: 0x7ffaa8a29f20
        public void OnUpdate(){} // RVA: 0x7ffaa8a2a6a0
        public void get_boneLengthCanBeZero(){} // RVA: 0x7ffaa8932320
        public void SolveJoint(){} // RVA: 0x7ffaa8a2ab80
        public void OnPreSolve(){} // RVA: 0x7ffaa8a2acd0
        public void OnPostSolve(){} // RVA: 0x7ffaa8a2b420
        public void Solve(){} // RVA: 0x7ffaa8a2b600
        public void ForwardReach(){} // RVA: 0x7ffaa8a2b700
        public void SolverMove(){} // RVA: 0x7ffaa8a2ba70
        public void SolverRotate(){} // RVA: 0x7ffaa8a2bb00
        public void SolverRotateChildren(){} // RVA: 0x7ffaa8a2bd00
        public void SolverMoveChildrenAroundPoint(){} // RVA: 0x7ffaa8a2bee0
        public void LimitForward(){} // RVA: 0x7ffaa8a2cad0
        public void BackwardReach(){} // RVA: 0x7ffaa8a2d1e0
        public void BackwardReachUnlimited(){} // RVA: 0x7ffaa8a2d220
        public void BackwardReachLimited(){} // RVA: 0x7ffaa8a2d470
        public void MapToSolverPositions(){} // RVA: 0x7ffaa8a2e180
        public void MapToSolverPositionsLimited(){} // RVA: 0x7ffaa8a2e350
        public void .ctor(){} // RVA: 0x7ffaa8a2e4f0
        // ── Binary Analysis Named ──
        public void GetIKPosition(){} // RVA: 0x7ffaa8a29dc0
        public void GetParentSolverRotation(){} // RVA: 0x7ffaa8a2c1b0
        public void GetParentSolverPosition(){} // RVA: 0x7ffaa8a2c450
        public void GetLimitedRotation(){} // RVA: 0x7ffaa8a2c710
    }

    public class IKSolverFABRIKRoot : IKSolver
    {
        public object chains; // 0x337C58C0
        public object rootDefaultPosition; // 0x337C58C0
        public object ßf; // 0x1D0000

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa8a2e610
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a2ef90
        public void FixTransforms(){} // RVA: 0x7ffaa8a2f0a0
        public void OnInitiate(){} // RVA: 0x7ffaa8a2f1a0
        public void IsRoot(){} // RVA: 0x7ffaa8a2f3c0
        public void OnUpdate(){} // RVA: 0x7ffaa8a2f470
        public void AddPointsToArray(){} // RVA: 0x7ffaa8a2f830
        public void .ctor(){} // RVA: 0x7ffaa8a2fdd0
        // ── Binary Analysis Named ──
        public void GetPoints(){} // RVA: 0x7ffaa8a2f6e0
        public void GetPoint(){} // RVA: 0x7ffaa8a2f790
        public void GetCentroid(){} // RVA: 0x7ffaa8a2f9f0
    }

    public class IKSolverFullBody : IKSolver
    {
        public object effectors; // 0x33734F30
        public object limbMappings; // 0x33734F30
        public object OnPreSolve; // 0x33734F30
        public object OnPreBend; // 0x33734F30
        public object OnFixTransforms; // 0x33734F30

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa8a30820
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a30b00
        public void FixTransforms(){} // RVA: 0x7ffaa8a30d80
        public void OnInitiate(){} // RVA: 0x7ffaa8a30fa0
        public void OnUpdate(){} // RVA: 0x7ffaa8a31140
        public void ReadPose(){} // RVA: 0x7ffaa8a31370
        public void Solve(){} // RVA: 0x7ffaa8a31890
        public void ApplyBendConstraints(){} // RVA: 0x7ffaa8a31c00
        public void WritePose(){} // RVA: 0x7ffaa8a31c40
        public void .ctor(){} // RVA: 0x7ffaa8a31d70
        // ── Binary Analysis Named ──
        public void GetEffector(){} // RVA: 0x7ffaa8a2fe70
        public void GetChain(){} // RVA: 0x7ffaa8a30010
        public void GetChainIndex(){} // RVA: 0x7ffaa8a30060
        public void GetNode(){} // RVA: 0x7ffaa8a30240
        public void GetChainAndNodeIndexes(){} // RVA: 0x7ffaa8a30290
        public void GetPoints(){} // RVA: 0x7ffaa8a30470
        public void GetPoint(){} // RVA: 0x7ffaa8a30620
    }

    public class IKSolverFullBodyBiped : IKSolverFullBody
    {
        public object pullBodyVertical; // 0x33A37C10
        public object offset; // 0x33A37C10
        public object bodyEffector; // 0x170000DA
        public object leftShoulderEffector; // 0x170000DB

        // ── Original Methods ──
        public void get_bodyEffector(){} // RVA: 0x7ffaa8a32010
        public void get_leftShoulderEffector(){} // RVA: 0x7ffaa8a32040
        public void get_rightShoulderEffector(){} // RVA: 0x7ffaa8a32070
        public void get_leftThighEffector(){} // RVA: 0x7ffaa8a320a0
        public void get_rightThighEffector(){} // RVA: 0x7ffaa8a320d0
        public void get_leftHandEffector(){} // RVA: 0x7ffaa8a32100
        public void get_rightHandEffector(){} // RVA: 0x7ffaa8a32130
        public void get_leftFootEffector(){} // RVA: 0x7ffaa8a32160
        public void get_rightFootEffector(){} // RVA: 0x7ffaa8a32190
        public void get_leftArmChain(){} // RVA: 0x7ffaa8a321c0
        public void get_rightArmChain(){} // RVA: 0x7ffaa8a321f0
        public void get_leftLegChain(){} // RVA: 0x7ffaa8a32220
        public void get_rightLegChain(){} // RVA: 0x7ffaa8a32250
        public void get_leftArmMapping(){} // RVA: 0x7ffaa8a32280
        public void get_rightArmMapping(){} // RVA: 0x7ffaa8a322b0
        public void get_leftLegMapping(){} // RVA: 0x7ffaa8a322e0
        public void get_rightLegMapping(){} // RVA: 0x7ffaa8a32310
        public void get_headMapping(){} // RVA: 0x7ffaa8a32340
        public void IsValid(){} // RVA: 0x7ffaa8a32a20
        public void DetectRootNodeBone(){} // RVA: 0x7ffaa8a34df0
        public void get_pullBodyOffset(){} // RVA: 0x7ffaa899d260
        public void set_pullBodyOffset(){} // RVA: 0x7ffaa899d280
        public void Contains(){} // RVA: 0x7ffaa8a35b20
        public void ReadPose(){} // RVA: 0x7ffaa8a35c90
        public void PullBody(){} // RVA: 0x7ffaa8a36100
        public void ApplyBendConstraints(){} // RVA: 0x7ffaa8a36800
        public void WritePose(){} // RVA: 0x7ffaa8a36c60
        public void .ctor(){} // RVA: 0x7ffaa8a36eb0
        // ── Binary Analysis Named ──
        public void SetChainWeights(){} // RVA: 0x7ffaa8a32370
        public void SetEffectorWeights(){} // RVA: 0x7ffaa8a323e0
        public void GetChain(){} // RVA: 0x7ffaa8a32530
        public void GetChain(){} // RVA: 0x7ffaa8a32530
        public void GetEffector(){} // RVA: 0x7ffaa8a32620
        public void GetEndEffector(){} // RVA: 0x7ffaa8a32780
        public void GetLimbMapping(){} // RVA: 0x7ffaa8a328b0
        public void GetLimbMapping(){} // RVA: 0x7ffaa8a328b0
        public void GetSpineMapping(){} // RVA: 0x7ffaa89fa590
        public void GetHeadMapping(){} // RVA: 0x7ffaa8a32340
        public void GetBendConstraint(){} // RVA: 0x7ffaa8a32990
        public void SetToReferences(){} // RVA: 0x7ffaa8a32d30
        public void SetLimbOrientations(){} // RVA: 0x7ffaa8a354c0
        public void SetLimbOrientation(){} // RVA: 0x7ffaa8a35530
        public void GetLeftClavicle(){} // RVA: 0x7ffaa8a357c0
        public void GetRightClavicle(){} // RVA: 0x7ffaa8a35970
        public void GetBodyOffset(){} // RVA: 0x7ffaa8a362e0
        public void GetHandBodyPull(){} // RVA: 0x7ffaa8a365c0
    }

    public class IKSolverHeuristic : IKSolver
    {
        public object maxIterations; // 0x3341C4F0
        public object bones; // 0x3341C4F0

        // ── Original Methods ──
        public void AddBone(){} // RVA: 0x7ffaa8a370b0
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a37280
        public void FixTransforms(){} // RVA: 0x7ffaa8a373f0
        public void IsValid(){} // RVA: 0x7ffaa8a37470
        public void get_minBones(){} // RVA: 0x7ffaa8a37cb0
        public void get_boneLengthCanBeZero(){} // RVA: 0x7ffaa8a17850
        public void get_allowCommonParent(){} // RVA: 0x7ffaa8932320
        public void OnInitiate(){} // RVA: 0x7ffaa8932310
        public void OnUpdate(){} // RVA: 0x7ffaa8932310
        public void InitiateBones(){} // RVA: 0x7ffaa8a37cc0
        public void get_localDirection(){} // RVA: 0x7ffaa8a38580
        public void get_positionOffset(){} // RVA: 0x7ffaa8a38790
        public void SingularityDetected(){} // RVA: 0x7ffaa8a38d70
        public void .ctor(){} // RVA: 0x7ffaa8a390e0
        // ── Binary Analysis Named ──
        public void SetChain(){} // RVA: 0x7ffaa8a36ed0
        public void GetPoints(){} // RVA: 0x7ffaa89fa590
        public void GetPoint(){} // RVA: 0x7ffaa8a37b10
        public void GetSingularityOffset(){} // RVA: 0x7ffaa8a38800
    }

    public class IKSolverLeg : IKSolver
    {
        public object pelvis; // 0x338CC760
        public object foot; // 0x338CC760
        public object heelOffset; // 0x338CC760
        public object solver; // 0x336CF7A0
        public object 8؏f; // 0x81C0C2E0

        // ── Original Methods ──
        public void IsValid(){} // RVA: 0x7ffaa8a39190
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a27260
        public void FixTransforms(){} // RVA: 0x7ffaa8a272c0
        public void OnInitiate(){} // RVA: 0x7ffaa8a39f80
        public void OnUpdate(){} // RVA: 0x7ffaa8a3a0a0
        public void Solve(){} // RVA: 0x7ffaa8a3a1a0
        public void Read(){} // RVA: 0x7ffaa8a3a290
        public void Write(){} // RVA: 0x7ffaa8a3aac0
        public void .ctor(){} // RVA: 0x7ffaa8a3ae60
        // ── Binary Analysis Named ──
        public void SetChain(){} // RVA: 0x7ffaa8a26940
        public void GetPoints(){} // RVA: 0x7ffaa8a39880
        public void GetPoint(){} // RVA: 0x7ffaa8a39a30
    }

    public class IKSolverLimb : IKSolverTrigonometric
    {
        public object maintainRotationWeight; // 0x33726A30
        public object maintainBendFor1Frame; // 0x33726A30
        public object parentDefaultRotation; // 0x33726A30
        public object bone3DefaultRotation; // 0x33726A30
        public object axisDirectionsLeft; // 0x33726A30
        public object Animation; // 0x84432520

        // ── Original Methods ──
        public void MaintainRotation(){} // RVA: 0x7ffaa8a3b390
        public void MaintainBend(){} // RVA: 0x7ffaa8a3b430
        public void OnInitiateVirtual(){} // RVA: 0x7ffaa8a3b480
        public void OnUpdateVirtual(){} // RVA: 0x7ffaa8a3bcf0
        public void OnPostSolveVirtual(){} // RVA: 0x7ffaa8a3be50
        public void .ctor(){} // RVA: 0x7ffaa8a3c130
        public void .ctor(){} // RVA: 0x7ffaa8a3c130
        public void get_axisDirections(){} // RVA: 0x7ffaa8a3c260
        public void StoreAxisDirections(){} // RVA: 0x7ffaa8a3c280
        // ── Binary Analysis Named ──
        public void GetModifiedBendNormal(){} // RVA: 0x7ffaa8a3c8d0
    }

    public class IKSolverLookAt : IKSolver
    {
        public object head; // 0x3395FA20
        public object headWeight; // 0x3395FA20
        public object clampWeightHead; // 0x3395FA20
        public object spineWeightCurve; // 0x3395FA20
        public object headForwards; // 0x3395FA20

        // ── Original Methods ──
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a3e480
        public void FixTransforms(){} // RVA: 0x7ffaa8a3e640
        public void IsValid(){} // RVA: 0x7ffaa8a3e810
        public void OnInitiate(){} // RVA: 0x7ffaa8a3f630
        public void OnUpdate(){} // RVA: 0x7ffaa8a3fcc0
        public void get_spineIsValid(){} // RVA: 0x7ffaa8a3fe50
        public void get_spineIsEmpty(){} // RVA: 0x7ffaa8a3ffb0
        public void SolveSpine(){} // RVA: 0x7ffaa8a3ffd0
        public void get_headIsValid(){} // RVA: 0x7ffaa8a402e0
        public void get_headIsEmpty(){} // RVA: 0x7ffaa8a402f0
        public void SolveHead(){} // RVA: 0x7ffaa8a403d0
        public void get_eyesIsValid(){} // RVA: 0x7ffaa8a40870
        public void get_eyesIsEmpty(){} // RVA: 0x7ffaa8a409d0
        public void SolveEyes(){} // RVA: 0x7ffaa8a409f0
        public void .ctor(){} // RVA: 0x7ffaa8a41930
        // ── Binary Analysis Named ──
        public void SetLookAtWeight(){} // RVA: 0x7ffaa8a3e3a0
        public void SetLookAtWeight(){} // RVA: 0x7ffaa8a3e3a0
        public void SetLookAtWeight(){} // RVA: 0x7ffaa8a3e3a0
        public void SetLookAtWeight(){} // RVA: 0x7ffaa8a3e3a0
        public void SetLookAtWeight(){} // RVA: 0x7ffaa8a3e3a0
        public void SetLookAtWeight(){} // RVA: 0x7ffaa8a3e3a0
        public void GetPoints(){} // RVA: 0x7ffaa8a3ed70
        public void GetPoint(){} // RVA: 0x7ffaa8a3f190
        public void SetChain(){} // RVA: 0x7ffaa8a3f530
        public void GetForwards(){} // RVA: 0x7ffaa8a412e0
        public void SetBones(){} // RVA: 0x7ffaa8a416e0
    }

    public class IKSolverTrigonometric : IKSolver
    {
        public object IKRotation; // 0x33500810
        public object bone2; // 0x33500810
        public object directHierarchy; // 0x33500810

        // ── Original Methods ──
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a432a0
        public void FixTransforms(){} // RVA: 0x7ffaa8a432f0
        public void IsValid(){} // RVA: 0x7ffaa8a43350
        public void Solve(){} // RVA: 0x7ffaa8a43c30
        public void OnInitiate(){} // RVA: 0x7ffaa8a44cc0
        public void IsDirectHierarchy(){} // RVA: 0x7ffaa8a45040
        public void InitiateBones(){} // RVA: 0x7ffaa8a45330
        public void OnUpdate(){} // RVA: 0x7ffaa8a454e0
        public void OnInitiateVirtual(){} // RVA: 0x7ffaa8932310
        public void OnUpdateVirtual(){} // RVA: 0x7ffaa8932310
        public void OnPostSolveVirtual(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8a469c0
        // ── Binary Analysis Named ──
        public void SetBendGoalPosition(){} // RVA: 0x7ffaa8a42790
        public void SetBendPlaneToCurrent(){} // RVA: 0x7ffaa8a42aa0
        public void SetIKRotation(){} // RVA: 0x7ffaa8a42dc0
        public void SetIKRotationWeight(){} // RVA: 0x7ffaa8a42dd0
        public void GetIKRotation(){} // RVA: 0x7ffaa8a42e00
        public void GetIKRotationWeight(){} // RVA: 0x7ffaa8a42e10
        public void GetPoints(){} // RVA: 0x7ffaa8a42e20
        public void GetPoint(){} // RVA: 0x7ffaa8a42f50
        public void SetChain(){} // RVA: 0x7ffaa8a43ad0
        public void GetDirectionToBendPoint(){} // RVA: 0x7ffaa8a448e0
        public void GetBendDirection(){} // RVA: 0x7ffaa8a46450
    }

    public class IKSolverVR : IKSolver
    {
        public object hasNeck; // 0x3345E730
        public object hasLegs; // 0x3345E730
        public object readRotations; // 0x3345E730
        public object defaultLocalRotations; // 0x3345E730
        public object rootVelocity; // 0x3345E730
        public object lastLOD; // 0x3345E730
        public object _rootBone; // 0x3345E730, was: <rootBone>k__BackingField
        public object rightArm; // 0x3345E730
        public object locomotion; // 0x3345E730
        public object headPosition; // 0x3345E730
        public object lastOffset; // 0x3345E730
        public object debugPos3; // 0x3345E730
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void GuessHandOrientations(){} // RVA: 0x7ffaa8a47c90
        public void DefaultAnimationCurves(){} // RVA: 0x7ffaa8a480f0
        public void AddPositionOffset(){} // RVA: 0x7ffaa8a484a0
        public void AddRotationOffset(){} // RVA: 0x7ffaa8a487f0
        public void AddRotationOffset(){} // RVA: 0x7ffaa8a487f0
        public void AddPlatformMotion(){} // RVA: 0x7ffaa8a48be0
        public void Reset(){} // RVA: 0x7ffaa8a49020
        public void StoreDefaultLocalState(){} // RVA: 0x7ffaa8a49350
        public void FixTransforms(){} // RVA: 0x7ffaa8a495e0
        public void IsValid(){} // RVA: 0x7ffaa8a499a0
        public void GuessWristToPalmAxis(){} // RVA: 0x7ffaa8a4a210
        public void GuessPalmToThumbAxis(){} // RVA: 0x7ffaa8a4a5e0
        public void UpdateSolverTransforms(){} // RVA: 0x7ffaa8a4afa0
        public void OnInitiate(){} // RVA: 0x7ffaa8a4b220
        public void OnUpdate(){} // RVA: 0x7ffaa8a4b280
        public void WriteTransforms(){} // RVA: 0x7ffaa8a4bd10
        public void Read(){} // RVA: 0x7ffaa8a4c8d0
        public void Solve(){} // RVA: 0x7ffaa8a4d450
        public void get_rootBone(){} // RVA: 0x7ffaa8a4f100
        public void set_rootBone(){} // RVA: 0x7ffaa8a4f110
        public void VrcRead(){} // RVA: 0x7ffaa8a4b220
        public void VrcWrite(){} // RVA: 0x7ffaa8a4f170
        public void VrcWriteTransforms(){} // RVA: 0x7ffaa8a4f180
        public void VrcSyncIk(){} // RVA: 0x7ffaa8a4f190
        public void VrcLateSolve(){} // RVA: 0x7ffaa8a4f1b0
        public void Write(){} // RVA: 0x7ffaa8a4f210
        public void .ctor(){} // RVA: 0x7ffaa8a4fe80
        // ── Binary Analysis Named ──
        public void SetToReferences(){} // RVA: 0x7ffaa8a474f0
        public void GetPoints(){} // RVA: 0x7ffaa8a498e0
        public void GetPoint(){} // RVA: 0x7ffaa8a49940
        public void GetNormal(){} // RVA: 0x7ffaa8a49d50
        public void GetSineKeyframes(){} // RVA: 0x7ffaa8a4af10
        public void GetPosition(){} // RVA: 0x7ffaa8a4f070
        public void GetRotation(){} // RVA: 0x7ffaa8a4f0c0
        public void GetPelvisOffset(){} // RVA: 0x7ffaa8a4f3a0
    }

    public class Inertia : OffsetModifier
    {
        // ── Original Methods ──
        public void ResetBodies(){} // RVA: 0x7ffaa8aa2d60
        public void OnModifyOffset(){} // RVA: 0x7ffaa8aa2e00
        public void .ctor(){} // RVA: 0x7ffaa893a920
    }

    public class InteractionEffector : Object
    {
        public object _interactionObject; // 0x33642BE0, was: <interactionObject>k__BackingF
        public object timer; // 0x33642BE0
        public object fadeInSpeed; // 0x33642BE0
        public object defaultPull; // 0x33642BE0
        public object defaultPushParent; // 0x33642BE0
        public object positionWeightUsed; // 0x33642BE0
        public object reachUsed; // 0x33642BE0
        public object bendGoalWeightUsed; // 0x33642BE0
        public object pickUpOnPostFBBIK; // 0x33642BE0
        public object pickUpRotation; // 0x33642BE0
        public object target; // 0x33642BE0
        public object started; // 0x33642BE0
        public object effectorType; // 0x1700011B
        public object isPaused; // 0x1700011C
        public object interactionObject; // 0x1700011D
        public object inInteraction; // 0x1700011E
        public object progress; // 0x1700011F
        public object 
; // 0x683CF820

        // ── Original Methods ──
        public void get_effectorType(){} // RVA: 0x7ffaa897f5c0
        public void set_effectorType(){} // RVA: 0x7ffaa89350c0
        public void get_isPaused(){} // RVA: 0x7ffaa8a81bd0
        public void set_isPaused(){} // RVA: 0x7ffaa8a81be0
        public void get_interactionObject(){} // RVA: 0x7ffaa89357c0
        public void set_interactionObject(){} // RVA: 0x7ffaa8998e80
        public void get_inInteraction(){} // RVA: 0x7ffaa8a81bf0
        public void .ctor(){} // RVA: 0x7ffaa8a81cc0
        public void Initiate(){} // RVA: 0x7ffaa8a81d90
        public void StoreDefaults(){} // RVA: 0x7ffaa8a81f50
        public void ResetToDefaults(){} // RVA: 0x7ffaa8a82140
        public void Pause(){} // RVA: 0x7ffaa8a82600
        public void Resume(){} // RVA: 0x7ffaa8a82960
        public void Start(){} // RVA: 0x7ffaa8a829c0
        public void Update(){} // RVA: 0x7ffaa8a833f0
        public void get_progress(){} // RVA: 0x7ffaa8a84010
        public void TriggerUntriggeredEvents(){} // RVA: 0x7ffaa8a84050
        public void PickUp(){} // RVA: 0x7ffaa8a84370
        public void Stop(){} // RVA: 0x7ffaa8a84740
        public void OnPostFBBIK(){} // RVA: 0x7ffaa8a84b30
    }

    public class InteractionLookAt : Object
    {
        public object weightSpeed; // 0x335215B0
        public object stopLookTime; // 0x335215B0

        // ── Original Methods ──
        public void Look(){} // RVA: 0x7ffaa8a85120
        public void OnFixTransforms(){} // RVA: 0x7ffaa8a85380
        public void Update(){} // RVA: 0x7ffaa8a85480
        public void SolveSpine(){} // RVA: 0x7ffaa8a85910
        public void SolveHead(){} // RVA: 0x7ffaa8a85aa0
        public void .ctor(){} // RVA: 0x7ffaa8a85be0
    }

    public class InteractionObject : MonoBehaviour
    {
        public object positionOffsetSpace; // 0x33665B60
        public object events; // 0x33665B60
        public object targets; // 0x33665B60
        public object length; // 0x17000120
        public object lastUsedInteractionSystem; // 0x17000121
        public object lookAtTarget; // 0x17000122

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial1(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial2(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial3(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial4(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void get_length(){} // RVA: 0x7ffaa899a460
        public void set_length(){} // RVA: 0x7ffaa899a470
        public void get_lastUsedInteractionSystem(){} // RVA: 0x7ffaa89fa500
        public void set_lastUsedInteractionSystem(){} // RVA: 0x7ffaa89fa510
        public void Initiate(){} // RVA: 0x7ffaa8a85bf0
        public void get_lookAtTarget(){} // RVA: 0x7ffaa8a85eb0
        public void CurveUsed(){} // RVA: 0x7ffaa8a861c0
        public void OnStartInteraction(){} // RVA: 0x7ffaa89fa510
        public void Apply(){} // RVA: 0x7ffaa8a86f70
        public void get_targetsRoot(){} // RVA: 0x7ffaa8a86e40
        public void Start(){} // RVA: 0x7ffaa8a86f60
        public void Apply(){} // RVA: 0x7ffaa8a86f70
        public void .ctor(){} // RVA: 0x7ffaa8a879a0
        // ── Binary Analysis Named ──
        public void GetTarget(){} // RVA: 0x7ffaa8a87830
        public void GetTargets(){} // RVA: 0x7ffaa89d0370
        public void GetTarget(){} // RVA: 0x7ffaa8a87830
        public void GetValue(){} // RVA: 0x7ffaa8a86ac0
        public void GetTarget(){} // RVA: 0x7ffaa8a87830
        public void GetWeightCurveIndex(){} // RVA: 0x7ffaa8a878e0
        public void GetMultiplierIndex(){} // RVA: 0x7ffaa8a87940
    }

    public class InteractionSystem : MonoBehaviour
    {
        public object speed; // 0x336F6780
        public object FPSCamera; // 0x336F6780
        public object _triggersInRange; // 0x336F6780, was: <triggersInRange>k__BackingFie
        public object OnInteractionStart; // 0x336F6780
        public object OnInteractionResume; // 0x336F6780
        public object raycastHit; // 0x336F6780
        public object interactionEffectors; // 0x336F6780
        public object c; // 0x336F6780
        public object inInteraction; // 0x17000124
        public object ik; // 0x17000125
        public object triggersInRange; // 0x17000126

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial1(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial2(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial3(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial4(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void get_inInteraction(){} // RVA: 0x7ffaa8a883c0
        public void IsInInteraction(){} // RVA: 0x7ffaa8a88480
        public void IsPaused(){} // RVA: 0x7ffaa8a88620
        public void IsPaused(){} // RVA: 0x7ffaa8a88620
        public void IsInSync(){} // RVA: 0x7ffaa8a886e0
        public void StartInteraction(){} // RVA: 0x7ffaa8a88810
        public void PauseInteraction(){} // RVA: 0x7ffaa8a88980
        public void ResumeInteraction(){} // RVA: 0x7ffaa8a88a10
        public void StopInteraction(){} // RVA: 0x7ffaa8a88aa0
        public void PauseAll(){} // RVA: 0x7ffaa8a88b30
        public void ResumeAll(){} // RVA: 0x7ffaa8a88bb0
        public void StopAll(){} // RVA: 0x7ffaa8a88c90
        public void TriggerInteraction(){} // RVA: 0x7ffaa8a89400
        public void TriggerInteraction(){} // RVA: 0x7ffaa8a89400
        public void TriggerInteraction(){} // RVA: 0x7ffaa8a89400
        public void TriggerEffectorsReady(){} // RVA: 0x7ffaa8a89c90
        public void get_ik(){} // RVA: 0x7ffaa8a8a460
        public void set_ik(){} // RVA: 0x7ffaa8a8a470
        public void get_triggersInRange(){} // RVA: 0x7ffaa89d30e0
        public void set_triggersInRange(){} // RVA: 0x7ffaa8a8a4d0
        public void Start(){} // RVA: 0x7ffaa8a8a530
        public void InteractionPause(){} // RVA: 0x7ffaa8a8b030
        public void InteractionResume(){} // RVA: 0x7ffaa8a8b050
        public void InteractionStop(){} // RVA: 0x7ffaa8a8b050
        public void LookAtInteraction(){} // RVA: 0x7ffaa8a8b070
        public void OnTriggerEnter(){} // RVA: 0x7ffaa8a8b210
        public void OnTriggerExit(){} // RVA: 0x7ffaa8a8b440
        public void ContactIsInRange(){} // RVA: 0x7ffaa8a8b610
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaa8a8b8a0
        public void Update(){} // RVA: 0x7ffaa8a8bb60
        public void Raycasting(){} // RVA: 0x7ffaa8a8bee0
        public void UpdateTriggerEventBroadcasting(){} // RVA: 0x7ffaa8a8c150
        public void UpdateEffectors(){} // RVA: 0x7ffaa8a8c8d0
        public void OnPreFBBIK(){} // RVA: 0x7ffaa8a8cad0
        public void OnPostFBBIK(){} // RVA: 0x7ffaa8a8cd40
        public void OnFixTransforms(){} // RVA: 0x7ffaa8a8cfb0
        public void OnDestroy(){} // RVA: 0x7ffaa8a8d0c0
        public void IsValid(){} // RVA: 0x7ffaa8a8d8b0
        public void TriggerIndexIsValid(){} // RVA: 0x7ffaa8a8da40
        public void .ctor(){} // RVA: 0x7ffaa8a8dc20
        // ── Binary Analysis Named ──
        public void GetInteractionObject(){} // RVA: 0x7ffaa8a88d10
        public void GetProgress(){} // RVA: 0x7ffaa8a88da0
        public void GetMinActiveProgress(){} // RVA: 0x7ffaa8a88e40
        public void GetClosestInteractionRange(){} // RVA: 0x7ffaa8a897a0
        public void GetClosestInteractionObjectInRange(){} // RVA: 0x7ffaa8a89890
        public void GetClosestInteractionTargetInRange(){} // RVA: 0x7ffaa8a898e0
        public void GetClosestInteractionObjectsInRange(){} // RVA: 0x7ffaa8a89950
        public void GetClosestInteractionTargetsInRange(){} // RVA: 0x7ffaa8a89ae0
        public void GetTriggerRange(){} // RVA: 0x7ffaa8a89fe0
        public void GetClosestTriggerIndex(){} // RVA: 0x7ffaa8a8a160
    }

    public class InteractionTarget : MonoBehaviour
    {
        public object interactionSpeedMlp; // 0x336BDD30
        public object twistWeight; // 0x336BDD30
        public object defaultLocalRotation; // 0x336BDD30

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial1(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial2(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial3(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial4(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void ResetRotation(){} // RVA: 0x7ffaa8a8e600
        public void RotateTo(){} // RVA: 0x7ffaa8a8e730
        public void .ctor(){} // RVA: 0x7ffaa8a8f540
        // ── Binary Analysis Named ──
        public void GetValue(){} // RVA: 0x7ffaa8a8e590
    }

    public class InteractionTrigger : MonoBehaviour
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OpenTutorial4(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void Start(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8a8f900
        // ── Binary Analysis Named ──
        public void GetBestRangeIndex(){} // RVA: 0x7ffaa8a8f5e0
    }

    public class LegIK : IK
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8a01b20
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa89af740
    }

    public class LimbIK : IK
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8a01c00
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa89af740
    }

    public class LookAtController : MonoBehaviour
    {
        public object weight; // 0x338CCC60
        public object weightSmoothTime; // 0x338CCC60
        public object maxMagnitudeDelta; // 0x338CCC60
        public object minDistance; // 0x338CCC60
        public object switchWeight; // 0x338CCC60
        public object lastPosition; // 0x338CCC60

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8aa3790
        public void LateUpdate(){} // RVA: 0x7ffaa8aa3850
        public void get_pivot(){} // RVA: 0x7ffaa8aa4470
        public void ApplyMinDistance(){} // RVA: 0x7ffaa8aa4800
        public void RootRotation(){} // RVA: 0x7ffaa8aa49c0
        public void .ctor(){} // RVA: 0x7ffaa8aa5070
    }

    public class LookAtIK : IK
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8a01ce0
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa89af740
    }

    public class OffsetModifier : MonoBehaviour
    {
        public object lastTime; // 0x332E22A0
        public object deltaTime; // 0x17000143

        // ── Original Methods ──
        public void get_deltaTime(){} // RVA: 0x7ffaa8aa5140
        public void OnModifyOffset(){} // RVA: 0x7ffaa8660cc0
        public void Start(){} // RVA: 0x7ffaa8aa51a0
        public void Initiate(){} // RVA: 0x7ffaa8aa5250
        public void ModifyOffset(){} // RVA: 0x7ffaa8aa52f0
        public void ApplyLimits(){} // RVA: 0x7ffaa8aa54c0
        public void OnDestroy(){} // RVA: 0x7ffaa8aa5630
        public void .ctor(){} // RVA: 0x7ffaa893a920
    }

    public class OffsetModifierVRIK : MonoBehaviour
    {
        public object lastTime; // 0x33323480
        public object deltaTime; // 0x17000146

        // ── Original Methods ──
        public void get_deltaTime(){} // RVA: 0x7ffaa8aa5140
        public void OnModifyOffset(){} // RVA: 0x7ffaa8660cc0
        public void Start(){} // RVA: 0x7ffaa8aa60e0
        public void Initiate(){} // RVA: 0x7ffaa8aa6190
        public void ModifyOffset(){} // RVA: 0x7ffaa8aa6230
        public void OnDestroy(){} // RVA: 0x7ffaa8aa6400
        public void .ctor(){} // RVA: 0x7ffaa893a920
    }

    public class OffsetPose : MonoBehaviour
    {
        // ── Original Methods ──
        public void Apply(){} // RVA: 0x7ffaa8aa6a60
        public void Apply(){} // RVA: 0x7ffaa8aa6a60
        public void .ctor(){} // RVA: 0x7ffaa8aa6b20
    }

    public class PenetrationAvoidance : OffsetModifier
    {
        // ── Original Methods ──
        public void OnModifyOffset(){} // RVA: 0x7ffaa8aa7190
        public void .ctor(){} // RVA: 0x7ffaa893a920
    }

    public class Poser : SolverManager
    {
        public object localRotationWeight; // 0x33737C70
        public object maps; // 0x33BE7C90

        // ── Original Methods ──
        public void AutoMapping(){} // RVA: 0x7ffaa8660cc0
        public void UpdateManual(){} // RVA: 0x7ffaa8a931c0
        public void InitiatePoser(){} // RVA: 0x7ffaa8660cc0
        public void UpdatePoser(){} // RVA: 0x7ffaa8660cc0
        public void FixPoserTransforms(){} // RVA: 0x7ffaa8660cc0
        public void UpdateSolver(){} // RVA: 0x7ffaa8a931e0
        public void InitiateSolver(){} // RVA: 0x7ffaa8a93230
        public void FixTransforms(){} // RVA: 0x7ffaa8a93260
        public void .ctor(){} // RVA: 0x7ffaa8a91d50
    }

    public class RagdollUtility : MonoBehaviour
    {
        public object applyIkOnRagdoll; // 0x33A8CE90
        public object animator; // 0x33A8CE90
        public object enableRagdollFlag; // 0x33A8CE90
        public object fixTransforms; // 0x33A8CE90
        public object fixedFrame; // 0x33A8CE90

        // ── Original Methods ──
        public void EnableRagdoll(){} // RVA: 0x7ffaa8a93280
        public void DisableRagdoll(){} // RVA: 0x7ffaa8a932e0
        public void Start(){} // RVA: 0x7ffaa8a933f0
        public void DisableRagdollSmooth(){} // RVA: 0x7ffaa8a93e90
        public void Update(){} // RVA: 0x7ffaa8a93f30
        public void FixedUpdate(){} // RVA: 0x7ffaa8a94240
        public void LateUpdate(){} // RVA: 0x7ffaa8a94280
        public void AfterLastIK(){} // RVA: 0x7ffaa8a943c0
        public void AfterAnimation(){} // RVA: 0x7ffaa8a94410
        public void OnFinalPose(){} // RVA: 0x7ffaa8a94450
        public void RagdollEnabler(){} // RVA: 0x7ffaa8a94490
        public void get_isRagdoll(){} // RVA: 0x7ffaa8a94800
        public void RecordVelocities(){} // RVA: 0x7ffaa8a948f0
        public void get_ikUsed(){} // RVA: 0x7ffaa8a94bd0
        public void StoreLocalState(){} // RVA: 0x7ffaa8a94e00
        public void FixTransforms(){} // RVA: 0x7ffaa8a94f50
        public void OnDestroy(){} // RVA: 0x7ffaa8a95310
        public void .ctor(){} // RVA: 0x7ffaa8a95520
    }

    public class Recoil : OffsetModifier
    {
        public object handedness; // 0x3354A0F0
        public object magnitudeRandom; // 0x3354A0F0
        public object blendTime; // 0x3354A0F0
        public object magnitudeMlp; // 0x3354A0F0
        public object secondaryHandRelativeRotation; // 0x3354A0F0
        public object initiated; // 0x3354A0F0
        public object primaryHandRotation; // 0x3354A0F0

        // ── Original Methods ──
        public void get_isFinished(){} // RVA: 0x7ffaa8aa7b60
        public void Fire(){} // RVA: 0x7ffaa8aa7bf0
        public void OnModifyOffset(){} // RVA: 0x7ffaa8aa7f50
        public void AfterFBBIK(){} // RVA: 0x7ffaa8aa95d0
        public void AfterAimIK(){} // RVA: 0x7ffaa8aa9930
        public void get_primaryHandEffector(){} // RVA: 0x7ffaa8aa9980
        public void get_secondaryHandEffector(){} // RVA: 0x7ffaa8aa99f0
        public void get_primaryHand(){} // RVA: 0x7ffaa8aa9a60
        public void get_secondaryHand(){} // RVA: 0x7ffaa8aa9a80
        public void OnDestroy(){} // RVA: 0x7ffaa8aa9aa0
        public void .ctor(){} // RVA: 0x7ffaa8aa9e10
        // ── Binary Analysis Named ──
        public void SetHandRotations(){} // RVA: 0x7ffaa8aa7bc0
    }

    public class RotationLimit : MonoBehaviour
    {
        public object _defaultLocalRotationOverride; // 0x3348C670, was: <defaultLocalRotationOverride>
        public object defaultLocalRotationSet; // 0x3348C670
        public object secondaryAxis; // 0x1700012D
        public object crossAxis; // 0x1700012E

        // ── Original Methods ──
        public void Apply(){} // RVA: 0x7ffaa8a971f0
        public void Disable(){} // RVA: 0x7ffaa8a973a0
        public void get_secondaryAxis(){} // RVA: 0x7ffaa8a97440
        public void get_crossAxis(){} // RVA: 0x7ffaa8a97460
        public void get_defaultLocalRotationOverride(){} // RVA: 0x7ffaa8a974e0
        public void set_defaultLocalRotationOverride(){} // RVA: 0x7ffaa8a974f0
        public void LimitRotation(){}
        public void Awake(){} // RVA: 0x7ffaa8a97500
        public void LateUpdate(){} // RVA: 0x7ffaa8a976c0
        public void LogWarning(){} // RVA: 0x7ffaa89e76f0
        public void Limit1DOF(){} // RVA: 0x7ffaa8a976d0
        public void LimitTwist(){} // RVA: 0x7ffaa8a97a20
        public void .ctor(){} // RVA: 0x7ffaa8a98110
        // ── Binary Analysis Named ──
        public void SetDefaultLocalRotation(){} // RVA: 0x7ffaa8a96e10
        public void SetDefaultLocalRotation(){} // RVA: 0x7ffaa8a96e10
        public void GetLimitedLocalRotation(){} // RVA: 0x7ffaa8a96e20
        public void GetOrthogonalAngle(){} // RVA: 0x7ffaa8a98030
    }

    public class RotationLimitAngle : RotationLimit
    {
        public object useLimits; // 0x3368E2C0

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void LimitRotation(){} // RVA: 0x7ffaa8a981a0
        public void LimitSwing(){} // RVA: 0x7ffaa8a98250
        public void .ctor(){} // RVA: 0x7ffaa8a986d0
    }

    public class RotationLimitHinge : RotationLimit
    {
        public object max; // 0x3368E2C0
        public object lastAngle; // 0x3368E2C0
        public object get_o; // 0xB41EA470

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void LimitRotation(){} // RVA: 0x7ffaa8a986f0
        public void LimitHinge(){} // RVA: 0x7ffaa8a98740
        public void .ctor(){} // RVA: 0x7ffaa8a98c20
    }

    public class RotationLimitPolygonal : RotationLimit
    {
        public object points; // 0x33BCD6F0
        public object 8ߟf; // 0x201D0000

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void LimitRotation(){} // RVA: 0x7ffaa8a98d40
        public void Start(){} // RVA: 0x7ffaa8a98e20
        public void ResetToDefault(){} // RVA: 0x7ffaa8a99040
        public void BuildReachCones(){} // RVA: 0x7ffaa8a99e60
        public void SmoothPoints(){} // RVA: 0x7ffaa8a9a620
        public void PointToTangentPlane(){} // RVA: 0x7ffaa8a9ada0
        public void TangentPointToSphere(){} // RVA: 0x7ffaa8a9ae90
        public void LimitSwing(){} // RVA: 0x7ffaa8a9afb0
        public void .ctor(){} // RVA: 0x7ffaa8a9b720
        // ── Binary Analysis Named ──
        public void SetLimitPoints(){} // RVA: 0x7ffaa8a98c80
        public void GetScalar(){} // RVA: 0x7ffaa8a9ad50
        public void GetReachCone(){} // RVA: 0x7ffaa8a9b5c0
    }

    public class RotationLimitSpline : RotationLimit
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void LimitRotation(){} // RVA: 0x7ffaa8a9be90
        public void LimitSwing(){} // RVA: 0x7ffaa8a9bf40
        public void .ctor(){} // RVA: 0x7ffaa8a9c570
        // ── Binary Analysis Named ──
        public void SetSpline(){} // RVA: 0x7ffaa8a9be20
    }

    public class ShoulderRotator : MonoBehaviour
    {
        public object ik; // 0x339DF830

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8aaa490
        public void RotateShoulders(){} // RVA: 0x7ffaa8aaa660
        public void RotateShoulder(){} // RVA: 0x7ffaa8aaa7c0
        public void OnDestroy(){} // RVA: 0x7ffaa8aaafc0
        public void .ctor(){} // RVA: 0x7ffaa8aab1c0
        // ── Binary Analysis Named ──
        public void GetParentBoneMap(){} // RVA: 0x7ffaa8aaae90
    }

    public class TrigonometricIK : IK
    {
        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void SupportGroup(){} // RVA: 0x7ffaa8932310
        public void ASThread(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8a01dc0
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa89af740
    }

    public class TwistRelaxer : MonoBehaviour
    {
        public object child; // 0x33C2EC00
        public object twistAngleOffset; // 0x33C2EC00
        public object axisRelativeToParentDefault; // 0x33C2EC00
        public object ik; // 0x33C64530
        public object thighWeight; // 0x33C64530

        // ── Original Methods ──
        public void Relax(){} // RVA: 0x7ffaa8a7fa40
        public void Init(){} // RVA: 0x7ffaa8a80ba0
        public void Start(){} // RVA: 0x7ffaa8a80bb0
        public void OnPostUpdate(){} // RVA: 0x7ffaa8a81720
        public void LateUpdate(){} // RVA: 0x7ffaa8a81800
        public void OnDestroy(){} // RVA: 0x7ffaa8a818e0
        public void .ctor(){} // RVA: 0x7ffaa8a81af0
    }

    public class VRIK : IK
    {
        public object _isVRCAvatarMainIK; // 0x33AA6C40

        // ── Original Methods ──
        public void OpenUserManual(){} // RVA: 0x7ffaa8932310
        public void OpenScriptReference(){} // RVA: 0x7ffaa8932310
        public void OpenSetupTutorial(){} // RVA: 0x7ffaa8932310
        public void AutoDetectReferences(){} // RVA: 0x7ffaa8a01ea0
        public void GuessHandOrientations(){} // RVA: 0x7ffaa8a01f00
        public void InternalInitiateSolver(){} // RVA: 0x7ffaa8a01f30
        public void InitiateSolver(){} // RVA: 0x7ffaa8a02010
        public void VRCSetAvatarMainIK(){} // RVA: 0x7ffaa89ec8f0
        public void VRCInitiateSolver(){} // RVA: 0x7ffaa8a02020
        public void UpdateSolver(){} // RVA: 0x7ffaa8a02030
        public void .ctor(){} // RVA: 0x7ffaa8a02330
        // ── Binary Analysis Named ──
        public void GetIKSolver(){} // RVA: 0x7ffaa89ad730
    }

    public class VRIKCalibrator : Object
    {
        // ── Original Methods ──
        public void RecalibrateScale(){} // RVA: 0x7ffaa8aab220
        public void Calibrate(){} // RVA: 0x7ffaa8aaf160
        public void CalibrateLeg(){} // RVA: 0x7ffaa8ab0370
        public void Calibrate(){} // RVA: 0x7ffaa8aaf160
        public void CalibrateLeg(){} // RVA: 0x7ffaa8ab0370
    }

    public class VRIKLODController : MonoBehaviour
    {
        public object allowCulled; // 0x3341EB90
        public object pelvisTarget; // 0x334ADE20

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaa8ab0ca0
        public void Update(){} // RVA: 0x7ffaa8ab0d30
        public void .ctor(){} // RVA: 0x7ffaa8ab10b0
        // ── Binary Analysis Named ──
        public void GetLODLevel(){} // RVA: 0x7ffaa8ab0d70
    }

    public class VRIKRootController : MonoBehaviour
    {
        public object leftFootTarget; // 0x334ADE20

        // ── Original Methods ──
        public void get_pelvisTargetRight(){} // RVA: 0x7ffaa8998ee0
        public void set_pelvisTargetRight(){} // RVA: 0x7ffaa8998f00
        public void Awake(){} // RVA: 0x7ffaa8ab1100
        public void Calibrate(){} // RVA: 0x7ffaa8ab17a0
        public void Calibrate(){} // RVA: 0x7ffaa8ab17a0
        public void OnPreUpdate(){} // RVA: 0x7ffaa8ab1b60
        public void OnDestroy(){} // RVA: 0x7ffaa8ab2700
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}