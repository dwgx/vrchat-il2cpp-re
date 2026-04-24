// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 87
// Methods: 971

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class AimController : MonoBehaviour
    {
        public dius.creaseSpeed pivot; // 0x20
        public float weight; // 0x28
        public object target; // 0x30
        public float targetSwitchSmoothTime; // 0x38
        public float weightSmoothTime; // 0x3C
        public bool smoothTurnTowardsTarget; // 0x40
        public float maxRadiansDelta; // 0x44
        public float maxMagnitudeDelta; // 0x48
        public float slerpSpeed; // 0x4C
        public amut pivotOffsetFromRoot; // 0x50
        public float minDistance; // 0x5C
        public amut offset; // 0x60
        public float maxRootAngle; // 0x6C
        public bool turnToTarget; // 0x70
        public float turnToTargetTime; // 0x74
        public bool useAnimatedAimDirection; // 0x78
        public amut animatedAimDirection; // 0x7C
        public object lastTarget; // 0x88
        public float switchWeight; // 0x90
        public float switchWeightV; // 0x94
        public float weightV; // 0x98
        public amut lastPosition; // 0x9C
        public amut dir; // 0xA8
        public bool lastSmoothTowardsTarget; // 0xB4
        public bool turningToTarget; // 0xB5
        public float turnToTargetMlp; // 0xB8
        public float turnToTargetMlpV; // 0xBC

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
        public dius.broadcaster solver; // 0x40

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
        public float angleBuffer; // 0x20
        public ?[] poses; // 0x28

        // ── Methods ──
        public void GetPose(){} // RVA: 0x7FFD4E4AD3E0
        public void SetPoseActive(){} // RVA: 0x7FFD4E4AD4F0
        public void .ctor(){} // RVA: 0x7FFD4E4AD570
    }

    public class Amplifier : OffsetModifier
    {
        public KeyGenerationParameters[] bodies; // 0x38

        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4AD9B0
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class ArmIK : IK
    {
        public dius.Material solver; // 0x40

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
        public h_Null_ModelNumber_String.pch_Dashboard_EnableDashboard_Bool references; // 0x40
        public dius.ps solvers; // 0x48

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
        public dius.rgetTransforms limbs; // 0x10
        public dius.rgetTransforms ikSolvers; // 0x18
        public dius.rgetTransforms leftHand; // 0x20
        public dius.rgetTransforms rightHand; // 0x28
        public dius.ehaviourTemplate spine; // 0x30
        public dius.rentRotation lookAt; // 0x38
        public dius.broadcaster aim; // 0x40
        public dius.E9B282E317592631CA48B75F46340A11B95A474700E656D4 pelvis; // 0x48
        public dius.rgetTransforms[] _limbs; // 0x50
        public dius.?[] _ikSolvers; // 0x58

        // ── Methods ──
        public void get_limbs(){} // RVA: 0x7FFD4E3F68E0
        public void get_ikSolvers(){} // RVA: 0x7FFD4E3F6AB0
        public void AssignReferences(){} // RVA: 0x7FFD4E3F6D40
        public void .ctor(){} // RVA: 0x7FFD4E3F6FB0
    }

    public class BodyTilt : OffsetModifier
    {
        public float tiltSpeed; // 0x38
        public float tiltSensitivity; // 0x3C
        public dius._BackingField poseLeft; // 0x40
        public dius._BackingField poseRight; // 0x48
        public float tiltAngle; // 0x50
        public amut lastForward; // 0x54

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E4AE220
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4AE330
        public void .ctor(){} // RVA: 0x7FFD4E4AE6E0
    }

    public class CCDIK : IK
    {
        public dius.lier solver; // 0x40

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
        public object isValid; // 0x10
        public float weight; // 0x18

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFD4E3F73B0
        public void UpdateConstraint(){} // RVA: 0x7FFD4E090980
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class ConstraintPosition : Constraint
    {
        public amut position; // 0x20

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFD4E3F7480
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
    }

    public class ConstraintPositionOffset : Constraint
    {
        public amut positionChanged; // 0x20
        public amut defaultLocalPosition; // 0x2C
        public amut lastLocalPosition; // 0x38
        public bool initiated; // 0x44

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFD4E3F75F0
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
        public void get_positionChanged(){} // RVA: 0x7FFD4E3F7A20
    }

    public class ConstraintRotation : Constraint
    {
        public R_12x12 rotation; // 0x20

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFD4E3F7AF0
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
    }

    public class ConstraintRotationOffset : Constraint
    {
        public R_12x12 rotationChanged; // 0x20
        public R_12x12 defaultRotation; // 0x30
        public R_12x12 defaultLocalRotation; // 0x40
        public R_12x12 lastLocalRotation; // 0x50
        public R_12x12 defaultTargetLocalRotation; // 0x60
        public bool initiated; // 0x70

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFD4E3F7C70
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
        public void get_rotationChanged(){} // RVA: 0x7FFD4E3F80B0
    }

    public class Constraints : Object
    {
        public object transform; // 0x10
        public object target; // 0x18
        public amut positionOffset; // 0x20
        public amut position; // 0x2C
        public float positionWeight; // 0x38
        public amut rotationOffset; // 0x3C
        public amut rotation; // 0x48
        public float rotationWeight; // 0x54

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFD4E3F8180
        public void Initiate(){} // RVA: 0x7FFD4E3F8250
        public void Update(){} // RVA: 0x7FFD4E3F83B0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class EditorIK : MonoBehaviour
    {
        public dius.ÌÌÎÍÏÏ ik; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E4AE740
        public void Update(){} // RVA: 0x7FFD4E4AE860
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class FABRIK : IK
    {
        public dius.ehaviourTemplate solver; // 0x40

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
        public dius.der ik; // 0x10
        public float pull; // 0x18
        public float pin; // 0x1C
        public int[] children; // 0x20

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
        public dius.comV solver; // 0x40

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
        public dius.sions ik; // 0x20
        public amut bendDirectionOffsetLeft; // 0x28
        public amut bendDirectionOffsetRight; // 0x34
        public amut characterSpaceBendOffsetLeft; // 0x40
        public amut characterSpaceBendOffsetRight; // 0x4C
        public R_12x12 leftHandTargetRotation; // 0x58
        public R_12x12 rightHandTargetRotation; // 0x68
        public bool initiated; // 0x78
        public object OnPostArmBend; // 0x80

        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFD4E4144B0
        public void OnPostFBBIK(){} // RVA: 0x7FFD4E414FB0
        public void OnDestroy(){} // RVA: 0x7FFD4E415490
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class FBBIKHeadEffector : MonoBehaviour
    {
        public dius.sions ik; // 0x20
        public float positionWeight; // 0x28
        public float bodyWeight; // 0x2C
        public float thighWeight; // 0x30
        public bool handsPullBody; // 0x34
        public float rotationWeight; // 0x38
        public float bodyClampWeight; // 0x3C
        public float headClampWeight; // 0x40
        public float bendWeight; // 0x44
        public veToTarget[] bendBones; // 0x48
        public float CCDWeight; // 0x50
        public float roll; // 0x54
        public float damper; // 0x58
        public ?[] CCDBones; // 0x60
        public float postStretchWeight; // 0x68
        public float maxStretch; // 0x6C
        public float stretchDamper; // 0x70
        public bool fixHead; // 0x74
        public ?[] stretchBones; // 0x78
        public amut chestDirection; // 0x80
        public float chestDirectionWeight; // 0x8C
        public ?[] chestBones; // 0x90
        public object OnPostHeadEffectorFK; // 0x98
        public amut offset; // 0xA0
        public amut headToBody; // 0xAC
        public amut shoulderCenterToHead; // 0xB8
        public amut headToLeftThigh; // 0xC4
        public amut headToRightThigh; // 0xD0
        public amut leftShoulderPos; // 0xDC
        public amut rightShoulderPos; // 0xE8
        public float shoulderDist; // 0xF4
        public float leftShoulderDist; // 0xF8
        public float rightShoulderDist; // 0xFC
        public R_12x12 chestRotation; // 0x100
        public R_12x12 headRotationRelativeToRoot; // 0x110
        public R_12x12[] ccdDefaultLocalRotations; // 0x120
        public amut headLocalPosition; // 0x128
        public R_12x12 headLocalRotation; // 0x134
        public amut[] stretchLocalPositions; // 0x148
        public R_12x12[] stretchLocalRotations; // 0x150
        public amut[] chestLocalPositions; // 0x158
        public R_12x12[] chestLocalRotations; // 0x160
        public int bendBonesCount; // 0x168
        public int ccdBonesCount; // 0x16C
        public int stretchBonesCount; // 0x170
        public int chestBonesCount; // 0x174
        public bool _isVRCAvatarMainIK; // 0x178

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
        public float pin; // 0x10
        public float pull; // 0x14
        public float push; // 0x18
        public float pushParent; // 0x1C
        public float reach; // 0x20
        public ÍÎÍÏÍÍÎÌÍÏÍÍÏÍÎÍÏÎÏÌÎÍ reachSmoothing; // 0x24
        public ÍÎÍÏÍÍÎÌÍÏÍÍÏÍÎÍÏÎÏÌÎÍ pushSmoothing; // 0x28
        public tyles[] nodes; // 0x30
        public int[] children; // 0x38
        public tMuscle[] childConstraints; // 0x40
        public dius.eCollision bendConstraint; // 0x48
        public float rootLength; // 0x50
        public bool initiated; // 0x54
        public float length; // 0x58
        public float distance; // 0x5C
        public object p; // 0x60
        public float reachForce; // 0x68
        public float pullParentSum; // 0x6C
        public float[] crossFades; // 0x70
        public float sqrMag1; // 0x78
        public float sqrMag2; // 0x7C
        public float sqrMagDif; // 0x80
        public float maxLimbLength;

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
        public float initiated; // 0x40
        public dius.ÍÏÏÎÎÍÎÌÎÏÍÎÌÏ[] fingers; // 0x48
        public bool <initiated>k__BackingField; // 0x50

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
        public bool _isVRCAvatarMainIK; // 0x40
        public h_Null_ModelNumber_String.pch_Dashboard_EnableDashboard_Bool references; // 0x48
        public dius.etCentroid solver; // 0x50

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
        public rCert[] maps; // 0x58

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
        public float initiated; // 0x20
        public dius.? solver; // 0x28
        public dex OnPreGrounder; // 0x30
        public dex OnPostGrounder; // 0x38
        public bool <initiated>k__BackingField; // 0x40

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
        public dius.eilingRadius ik; // 0x48
        public float spineBend; // 0x50
        public float spineSpeed; // 0x54
        public ?[] feet; // 0x58
        public R_12x12[] footRotations; // 0x60
        public amut animatedPelvisLocalPosition; // 0x68
        public amut solvedPelvisLocalPosition; // 0x74
        public amut spineOffset; // 0x80
        public float lastWeight; // 0x8C

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
        public dius.sions ik; // 0x48
        public float spineBend; // 0x50
        public float spineSpeed; // 0x54
        public s[] spine; // 0x58
        public ?[] feet; // 0x60
        public amut spineOffset; // 0x68
        public bool firstSolve; // 0x74

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
        public dius.ÌÌÎÍÏÏ[] legs; // 0x48
        public object pelvis; // 0x50
        public object characterRoot; // 0x58
        public float rootRotationWeight; // 0x60
        public float rootRotationSpeed; // 0x64
        public float maxRootRotationAngle; // 0x68
        public ?[] feet; // 0x70
        public R_12x12[] footRotations; // 0x78
        public amut animatedPelvisLocalPosition; // 0x80
        public amut solvedPelvisLocalPosition; // 0x8C
        public int solvedFeet; // 0x98
        public bool solved; // 0x9C
        public float lastWeight; // 0xA0
        public Touched characterRootRigidbody; // 0xA8

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
        public dius.? forelegSolver; // 0x48
        public float rootRotationWeight; // 0x50
        public float minRootRotation; // 0x54
        public float maxRootRotation; // 0x58
        public float rootRotationSpeed; // 0x5C
        public float maxLegOffset; // 0x60
        public float maxForeLegOffset; // 0x64
        public float maintainHeadRotationWeight; // 0x68
        public object characterRoot; // 0x70
        public object pelvis; // 0x78
        public object lastSpineBone; // 0x80
        public object head; // 0x88
        public dius.ÌÌÎÍÏÏ[] legs; // 0x90
        public dius.ÌÌÎÍÏÏ[] forelegs; // 0x98
        public amut gravity; // 0xA0
        public elClip[] feet; // 0xB0
        public amut animatedPelvisLocalPosition; // 0xB8
        public R_12x12 animatedPelvisLocalRotation; // 0xC4
        public R_12x12 animatedHeadLocalRotation; // 0xD4
        public amut solvedPelvisLocalPosition; // 0xE4
        public R_12x12 solvedPelvisLocalRotation; // 0xF0
        public R_12x12 solvedHeadLocalRotation; // 0x100
        public int solvedFeet; // 0x110
        public bool solved; // 0x114
        public float angle; // 0x118
        public object forefeetRoot; // 0x120
        public R_12x12 headRotation; // 0x128
        public float lastWeight; // 0x138
        public Touched characterRootRigidbody; // 0x140

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
        public dius.ht ik; // 0x48
        public ?[] feet; // 0x50

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
        public object legs; // 0x10
        public float pelvis; // 0x14
        public float isGrounded; // 0x18
        public float root; // 0x1C
        public float rootHit; // 0x20
        public float rootGrounded; // 0x24
        public float up; // 0x28
        public float useRootRotation; // 0x2C
        public float footRotationSpeed; // 0x30
        public float maxFootRotationAngle; // 0x34
        public bool rotateSolver; // 0x38
        public float pelvisSpeed; // 0x3C
        public float pelvisDamper; // 0x40
        public float lowerPelvisWeight; // 0x44
        public float liftPelvisWeight; // 0x48
        public float rootSphereCastRadius; // 0x4C
        public bool overstepFallsDown; // 0x50
        public es quality; // 0x54
        public rd_Section[] <legs>k__BackingField; // 0x58
        public ic <pelvis>k__BackingField; // 0x60
        public bool <isGrounded>k__BackingField; // 0x68
        public object <root>k__BackingField; // 0x70
        public ColorScaleAndOffset <rootHit>k__BackingField; // 0x78
        public bool initiated; // 0xA4

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
        public ?[] children; // 0x58
        public object _poseRoot; // 0x60
        public ?[] poseChildren; // 0x68
        public amut[] defaultLocalPositions; // 0x70
        public R_12x12[] defaultLocalRotations; // 0x78

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
        public eightFromGround[] inProgress; // 0x38
        public et[] boneHitPoints; // 0x40

        // ── Methods ──
        public void get_inProgress(){} // RVA: 0x7FFD4E4AE9A0
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4AEA50
        public void Hit(){} // RVA: 0x7FFD4E4AEB30
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class HitReactionVRIK : OffsetModifierVRIK
    {
        public ÍÎÌÍÍÌÌÎÏÏ[] offsetCurves; // 0x38
        public ÎÌ[] positionOffsets; // 0x40
        public tings[] rotationOffsets; // 0x48

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
        public object initiated; // 0x10
        public object bone2; // 0x18
        public object bone3; // 0x20
        public object bendGoal; // 0x28
        public amut direction; // 0x30
        public R_12x12 rotationOffset; // 0x3C
        public float weight; // 0x4C
        public amut defaultLocalDirection; // 0x50
        public amut defaultChildDirection; // 0x5C
        public float clampF; // 0x68
        public int chainIndex1; // 0x6C
        public int nodeIndex1; // 0x70
        public int chainIndex2; // 0x74
        public int nodeIndex2; // 0x78
        public int chainIndex3; // 0x7C
        public int nodeIndex3; // 0x80
        public bool <initiated>k__BackingField; // 0x84
        public bool limbOrientationsSet; // 0x85

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
        public object isEndEffector; // 0x10
        public object target; // 0x18
        public float positionWeight; // 0x20
        public float rotationWeight; // 0x24
        public amut position; // 0x28
        public R_12x12 rotation; // 0x34
        public amut positionOffset; // 0x44
        public bool <isEndEffector>k__BackingField; // 0x50
        public bool effectChildNodes; // 0x51
        public float maintainRelativePositionWeight; // 0x54
        public ?[] childBones; // 0x58
        public object planeBone1; // 0x60
        public object planeBone2; // 0x68
        public object planeBone3; // 0x70
        public R_12x12 planeRotationOffset; // 0x78
        public float posW; // 0x88
        public float rotW; // 0x8C
        public amut[] localPositions; // 0x90
        public bool usePlaneNodes; // 0x98
        public R_12x12 animatedPlaneRotation; // 0x9C
        public amut animatedPosition; // 0xAC
        public bool firstUpdate; // 0xB8
        public int chainIndex; // 0xBC
        public int nodeIndex; // 0xC0
        public int plane1ChainIndex; // 0xC4
        public int plane1NodeIndex; // 0xC8
        public int plane2ChainIndex; // 0xCC
        public int plane2NodeIndex; // 0xD0
        public int plane3ChainIndex; // 0xD4
        public int plane3NodeIndex; // 0xD8
        public int[] childChainIndexes; // 0xE0
        public int[] childNodeIndexes; // 0xE8

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
        public dius.ÌÌÎÍÏÏ[] animatePhysics; // 0x20
        public stfix animator; // 0x28
        public bool fixedFrame; // 0x30

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
        public object bone; // 0x10
        public float maintainRotationWeight; // 0x18
        public hActivate>d__21 boneMap; // 0x20

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
        public object parentBone; // 0x10
        public object bone1; // 0x18
        public object bone2; // 0x20
        public object bone3; // 0x28
        public float maintainRotationWeight; // 0x30
        public float weight; // 0x34
        public bool updatePlaneRotations; // 0x38
        public hActivate>d__21 boneMapParent; // 0x40
        public hActivate>d__21 boneMap1; // 0x48
        public hActivate>d__21 boneMap2; // 0x50
        public hActivate>d__21 boneMap3; // 0x58

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
        public ?[] spineBones; // 0x10
        public object leftUpperArmBone; // 0x18
        public object rightUpperArmBone; // 0x20
        public object leftThighBone; // 0x28
        public object rightThighBone; // 0x30
        public int iterations; // 0x38
        public float twistWeight; // 0x3C
        public int rootNodeIndex; // 0x40
        public hActivate>d__21[] spine; // 0x48
        public hActivate>d__21 leftUpperArm; // 0x50
        public hActivate>d__21 rightUpperArm; // 0x58
        public hActivate>d__21 leftThigh; // 0x60
        public hActivate>d__21 rightThigh; // 0x68
        public bool useFABRIK; // 0x70

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
        public amut initiated; // 0x10
        public float IKPositionWeight; // 0x1C
        public bool <initiated>k__BackingField; // 0x20
        public object OnPreInitiate; // 0x28
        public object OnPostInitiate; // 0x30
        public object OnPreUpdate; // 0x38
        public object OnPostUpdate; // 0x40
        public bool firstInitiation; // 0x48
        public object root; // 0x50

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
        public object transformAxis; // 0x88
        public amut transformPoleAxis; // 0x90
        public amut minBones; // 0x9C
        public amut localDirection; // 0xA8
        public float poleWeight; // 0xB4
        public object poleTarget; // 0xB8
        public float clampWeight; // 0xC0
        public int clampSmoothing; // 0xC4
        public eGetUp OnPreIteration; // 0xC8
        public float step; // 0xD0
        public amut clampedIKPosition; // 0xD4
        public dius.aultLocalRotation transformLimit; // 0xE0
        public object lastTransform; // 0xE8

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
        public float IKRotationWeight; // 0x58
        public R_12x12 IKRotation; // 0x5C
        public object chest; // 0x70
        public object shoulder; // 0x78
        public object upperArm; // 0x80
        public object forearm; // 0x88
        public object hand; // 0x90
        public bool isLeft; // 0x98
        public tionCall arm; // 0xA0
        public amut[] positions; // 0xA8
        public R_12x12[] rotations; // 0xB0

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
        public eGetUp OnPreIteration; // 0x88

        // ── Methods ──
        public void FadeOutBoneWeights(){} // RVA: 0x7FFD4E437690
        public void OnInitiate(){} // RVA: 0x7FFD4E437730
        public void OnUpdate(){} // RVA: 0x7FFD4E437880
        public void Solve(){} // RVA: 0x7FFD4E437D80
        public void .ctor(){} // RVA: 0x7FFD4E438C30
    }

    public class IKSolverFABRIK : IKSolverHeuristic
    {
        public eGetUp boneLengthCanBeZero; // 0x88
        public bool[] limitedBones; // 0x90
        public amut[] solverLocalPositions; // 0x98

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
        public int iterations; // 0x58
        public float rootPin; // 0x5C
        public dius.tchRotation[] chains; // 0x60
        public bool zeroWeightApplied; // 0x68
        public bool[] isRoot; // 0x70
        public amut rootDefaultPosition; // 0x78

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
        public int iterations; // 0x58
        public dius.t[] chain; // 0x60
        public dius.nPostMuscleCollisionExit[] effectors; // 0x68
        public dius.nimationTime spineMapping; // 0x70
        public dius.?[] boneMappings; // 0x78
        public dius.uscleWeightMlp[] limbMappings; // 0x80
        public bool FABRIKPass; // 0x88
        public object OnPreRead; // 0x90
        public object OnPreSolve; // 0x98
        public eGetUp OnPreIteration; // 0xA0
        public eGetUp OnPostIteration; // 0xA8
        public object OnPreBend; // 0xB0
        public object OnPostSolve; // 0xB8
        public object OnStoreDefaultLocalState; // 0xC0
        public object OnFixTransforms; // 0xC8

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
        public object bodyEffector; // 0xD0
        public float leftShoulderEffector; // 0xD8
        public float rightShoulderEffector; // 0xDC
        public float leftThighEffector; // 0xE0
        public amut rightThighEffector; // 0xE4
        public amut leftHandEffector; // 0xF0

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
        public object minBones; // 0x58
        public float boneLengthCanBeZero; // 0x60
        public int allowCommonParent; // 0x64
        public bool localDirection; // 0x68
        public bool positionOffset; // 0x69
        public radius[] bones; // 0x70
        public amut lastLocalDirection; // 0x78
        public float chainLength; // 0x84

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
        public float IKRotationWeight; // 0x58
        public R_12x12 IKRotation; // 0x5C
        public object pelvis; // 0x70
        public object thigh; // 0x78
        public object calf; // 0x80
        public object foot; // 0x88
        public object toe; // 0x90
        public rd_Section leg; // 0x98
        public amut heelOffset; // 0xA0
        public amut[] positions; // 0xB0
        public R_12x12[] rotations; // 0xB8

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
        public ianceMinDistance axisDirections; // 0xA8
        public parentRotation bendModifier; // 0xAC
        public float maintainRotationWeight; // 0xB0
        public float bendModifierWeight; // 0xB4
        public object bendGoal; // 0xB8
        public bool maintainBendFor1Frame; // 0xC0
        public bool maintainRotationFor1Frame; // 0xC1
        public R_12x12 defaultRootRotation; // 0xC4
        public R_12x12 parentDefaultRotation; // 0xD4
        public R_12x12 bone3RotationBeforeSolve; // 0xE4
        public R_12x12 maintainRotation; // 0xF4
        public R_12x12 bone3DefaultRotation; // 0x104
        public amut _bendNormal; // 0x114
        public amut animationNormal; // 0x120
        public n[] axisDirectionsLeft; // 0x130
        public n[] axisDirectionsRight; // 0x138

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
        public object spineIsValid; // 0x58
        public d[] spineIsEmpty; // 0x60
        public d headIsValid; // 0x68
        public d[] headIsEmpty; // 0x70
        public float eyesIsValid; // 0x78
        public float eyesIsEmpty; // 0x7C
        public float eyesWeight; // 0x80
        public float clampWeight; // 0x84
        public float clampWeightHead; // 0x88
        public float clampWeightEyes; // 0x8C
        public int clampSmoothing; // 0x90
        public ÍÎÌÍÍÌÌÎÏÏ spineWeightCurve; // 0x98
        public amut spineTargetOffset; // 0xA0
        public amut[] spineForwards; // 0xB0
        public amut[] headForwards; // 0xB8
        public amut[] eyeForward; // 0xC0

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
        public object target; // 0x58
        public float IKRotationWeight; // 0x60
        public R_12x12 IKRotation; // 0x64
        public amut bendNormal; // 0x74
        public ldTargetParent>k__BackingField bone1; // 0x80
        public ldTargetParent>k__BackingField bone2; // 0x88
        public ldTargetParent>k__BackingField bone3; // 0x90
        public amut weightIKPosition; // 0x98
        public bool directHierarchy; // 0xA4

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
        public ?[] rootBone; // 0x58
        public bool hasChest; // 0x60
        public bool hasNeck; // 0x61
        public bool hasShoulders; // 0x62
        public bool hasToes; // 0x63
        public bool hasLegs; // 0x64
        public bool hasUpperChest; // 0x65
        public amut[] readPositions; // 0x68
        public R_12x12[] readRotations; // 0x70
        public amut[] solvedPositions; // 0x78
        public R_12x12[] solvedRotations; // 0x80
        public R_12x12[] defaultLocalRotations; // 0x88
        public amut[] defaultLocalPositions; // 0x90
        public amut rootV; // 0x98
        public amut rootVelocity; // 0xA4
        public amut bodyOffset; // 0xB0
        public int supportLegIndex; // 0xBC
        public int lastLOD; // 0xC0
        public int LOD; // 0xC4
        public bool plantFeet; // 0xC8
        public ion <rootBone>k__BackingField; // 0xD0
        public ashboard_Section spine; // 0xD8
        public tionCall leftArm; // 0xE0
        public tionCall rightArm; // 0xE8
        public rd_Section leftLeg; // 0xF0
        public rd_Section rightLeg; // 0xF8
        public ÌÍÍÍÍÍÌÎÍÏÏ locomotion; // 0x100
        public rd_Section[] legs; // 0x108
        public tionCall[] arms; // 0x110
        public amut headPosition; // 0x118
        public amut headDeltaPosition; // 0x124
        public amut raycastOriginPelvis; // 0x130
        public amut lastOffset; // 0x13C
        public amut debugPos1; // 0x148
        public amut debugPos2; // 0x154
        public amut debugPos3; // 0x160
        public amut debugPos4; // 0x16C
        public bool vrcLateSolve; // 0x178

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
        public KeyGenerationParameters[] bodies; // 0x38
        public ition>k__BackingField[] limits; // 0x40

        // ── Methods ──
        public void ResetBodies(){} // RVA: 0x7FFD4E4B1D60
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4B1E00
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class InteractionEffector : Object
    {
        public dius.oundedTime effectorType; // 0x10
        public bool isPaused; // 0x14
        public dius.ollisionStayMessages interactionObject; // 0x18
        public dius.KSolvers inInteraction; // 0x20
        public dius.nPostMuscleCollisionExit progress; // 0x28
        public float timer; // 0x30
        public float length; // 0x34
        public float weight; // 0x38
        public float fadeInSpeed; // 0x3C
        public float defaultPositionWeight; // 0x40
        public float defaultRotationWeight; // 0x44
        public float defaultPull; // 0x48
        public float defaultReach; // 0x4C
        public float defaultPush; // 0x50
        public float defaultPushParent; // 0x54
        public float defaultBendGoalWeight; // 0x58
        public float resetTimer; // 0x5C
        public bool positionWeightUsed; // 0x60
        public bool rotationWeightUsed; // 0x61
        public bool pullUsed; // 0x62
        public bool reachUsed; // 0x63
        public bool pushUsed; // 0x64
        public bool pushParentUsed; // 0x65
        public bool bendGoalWeightUsed; // 0x66
        public bool pickedUp; // 0x67
        public bool defaults; // 0x68
        public bool pickUpOnPostFBBIK; // 0x69
        public amut pickUpPosition; // 0x6C
        public amut pausePositionRelative; // 0x78
        public R_12x12 pickUpRotation; // 0x84
        public R_12x12 pauseRotationRelative; // 0x94
        public dius.its interactionTarget; // 0xA8
        public object target; // 0xB0
        public URA.woDigitYearMax<bool> triggered; // 0xB8
        public dius.dBone interactionSystem; // 0xC0
        public bool started; // 0xC8

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
        public dius.ionToLocalSpace ik; // 0x10
        public float lerpSpeed; // 0x18
        public float weightSpeed; // 0x1C
        public bool isPaused; // 0x20
        public object lookAtTarget; // 0x28
        public float stopLookTime; // 0x30
        public float weight; // 0x34
        public bool firstFBBIKSolve; // 0x38

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
        public object length; // 0x20
        public object lastUsedInteractionSystem; // 0x28
        public object lookAtTarget; // 0x30
        public eator[] targetsRoot; // 0x38
        public n[] multipliers; // 0x40
        public ue[] events; // 0x48
        public float <length>k__BackingField; // 0x50
        public dius.dBone <lastUsedInteractionSystem>k__BackingField; // 0x58
        public dius.its[] targets; // 0x60

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
        public string inInteraction; // 0x20
        public float ik; // 0x28
        public float triggersInRange; // 0x2C
        public float resetToDefaultsSpeed; // 0x30
        public riteCharacterUnicode characterCollider; // 0x38
        public object FPSCamera; // 0x40
        public object camRaycastLayers; // 0x48
        public float camRaycastDistance; // 0x4C
        public URA.woDigitYearMax<dius.s> <triggersInRange>k__BackingField; // 0x50
        public URA.woDigitYearMax<dius.s> inContact; // 0x58
        public URA.woDigitYearMax<int> bestRangeIndexes; // 0x60
        public able OnInteractionStart; // 0x68
        public able OnInteractionPause; // 0x70
        public able OnInteractionPickUp; // 0x78
        public able OnInteractionResume; // 0x80
        public able OnInteractionStop; // 0x88
        public ms OnInteractionEvent; // 0x90
        public ColorScaleAndOffset raycastHit; // 0x98
        public dius.sions fullBody; // 0xC8
        public dius.eFree lookAt; // 0xD0
        public dius.75[] interactionEffectors; // 0xD8
        public bool initiated; // 0xE0
        public riteCharacterUnicode lastCollider; // 0xE8
        public riteCharacterUnicode c; // 0xF0

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
        public dius.oundedTime effectorType; // 0x20
        public n[] multipliers; // 0x28
        public float interactionSpeedMlp; // 0x30
        public object pivot; // 0x38
        public amut twistAxis; // 0x40
        public float twistWeight; // 0x4C
        public float swingWeight; // 0x50
        public bool rotateOnce; // 0x54
        public R_12x12 defaultLocalRotation; // 0x58
        public object lastPivot; // 0x68

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
        public HeadAnimatorForExport[] ranges; // 0x20

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
        public dius.? solver; // 0x40

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
        public dius.rgetTransforms solver; // 0x40

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
        public dius.ionToLocalSpace pivot; // 0x20
        public object target; // 0x28
        public float weight; // 0x30
        public amut offset; // 0x34
        public float targetSwitchSmoothTime; // 0x40
        public float weightSmoothTime; // 0x44
        public bool smoothTurnTowardsTarget; // 0x48
        public float maxRadiansDelta; // 0x4C
        public float maxMagnitudeDelta; // 0x50
        public float slerpSpeed; // 0x54
        public amut pivotOffsetFromRoot; // 0x58
        public float minDistance; // 0x64
        public float maxRootAngle; // 0x68
        public object lastTarget; // 0x70
        public float switchWeight; // 0x78
        public float switchWeightV; // 0x7C
        public float weightV; // 0x80
        public amut lastPosition; // 0x84
        public amut dir; // 0x90
        public bool lastSmoothTowardsTarget; // 0x9C

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
        public dius.rentRotation solver; // 0x40

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
        public float deltaTime; // 0x20
        public dius.sions ik; // 0x28
        public float lastTime; // 0x30

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
        public float deltaTime; // 0x20
        public dius.ht ik; // 0x28
        public float lastTime; // 0x30

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
        public xStep[] effectorLinks; // 0x20

        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFD4E4B5A60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E4B5B20
    }

    public class PenetrationAvoidance : OffsetModifier
    {
        public ?[] avoiders; // 0x38

        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFD4E4B6190
        public void .ctor(){} // RVA: 0x7FFD4E349920
    }

    public class Poser : SolverManager
    {
        public object poseRoot; // 0x40
        public float weight; // 0x48
        public float localRotationWeight; // 0x4C
        public float localPositionWeight; // 0x50
        public bool initiated; // 0x54

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
        public dius.ÌÌÎÍÏÏ isRagdoll; // 0x20
        public float ikUsed; // 0x28
        public bool applyIkOnRagdoll; // 0x2C
        public float applyVelocity; // 0x30
        public float applyAngularVelocity; // 0x34
        public stfix animator; // 0x38
        public oreDefaultLocalState[] rigidbones; // 0x40
        public nfo[] children; // 0x48
        public bool enableRagdollFlag; // 0x50
        public ngVisibilityRadius animatorUpdateMode; // 0x54
        public dius.ÌÌÎÍÏÏ[] allIKComponents; // 0x58
        public bool[] fixTransforms; // 0x60
        public float ragdollWeight; // 0x68
        public float ragdollWeightV; // 0x6C
        public bool fixedFrame; // 0x70
        public bool[] disabledIKComponents; // 0x78

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
        public dius.creaseSpeed isFinished; // 0x38
        public bool primaryHandEffector; // 0x40
        public ld secondaryHandEffector; // 0x44
        public bool primaryHand; // 0x48
        public ÍÎÌÍÍÌÌÎÏÏ secondaryHand; // 0x50
        public float magnitudeRandom; // 0x58
        public amut rotationRandom; // 0x5C
        public amut handRotationOffset; // 0x68
        public float blendTime; // 0x74
        public essHandOrientations[] offsets; // 0x78
        public R_12x12 rotationOffset; // 0x80
        public float magnitudeMlp; // 0x90
        public float endTime; // 0x94
        public R_12x12 handRotation; // 0x98
        public R_12x12 secondaryHandRelativeRotation; // 0xA8
        public R_12x12 randomRotation; // 0xB8
        public float length; // 0xC8
        public bool initiated; // 0xCC
        public float blendWeight; // 0xD0
        public float w; // 0xD4
        public R_12x12 primaryHandRotation; // 0xD8
        public bool handRotationsSet; // 0xE8
        public amut aimIKAxis; // 0xEC

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
        public amut secondaryAxis; // 0x20
        public R_12x12 crossAxis; // 0x2C
        public bool defaultLocalRotationOverride; // 0x3C
        public bool initiated; // 0x3D
        public bool applicationQuit; // 0x3E
        public bool defaultLocalRotationSet; // 0x3F

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
        public float limit; // 0x40
        public float twistLimit; // 0x44

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
        public bool useLimits; // 0x40
        public float min; // 0x44
        public float max; // 0x48
        public float zeroAxisDisplayOffset; // 0x4C
        public R_12x12 lastRotation; // 0x50
        public float lastAngle; // 0x60

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
        public float twistLimit; // 0x40
        public int smoothIterations; // 0x44
        public uped[] points; // 0x48
        public amut[] P; // 0x50
        public tationAngle[] reachCones; // 0x58

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
        public float twistLimit; // 0x40
        public ÍÎÌÍÍÌÌÎÏÏ spline; // 0x48

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
        public float weight; // 0x20
        public float offset; // 0x24
        public dius.sions ik; // 0x28
        public bool skip; // 0x30

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
        public dius.ield solver; // 0x40

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
        public dius.ÌÌÎÍÏÏ ik; // 0x20
        public object parent; // 0x28
        public object child; // 0x30
        public float weight; // 0x38
        public float parentChildCrossfade; // 0x3C
        public float twistAngleOffset; // 0x40
        public amut twistAxis; // 0x44
        public amut axis; // 0x50
        public amut axisRelativeToParentDefault; // 0x5C
        public amut axisRelativeToChildDefault; // 0x68
        public bool _inited; // 0x74

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
        public otation references; // 0x40
        public dius._BackingField solver; // 0x48
        public bool _isVRCAvatarMainIK; // 0x50

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
        public rical LODRenderer; // 0x20
        public float LODDistance; // 0x28
        public bool allowCulled; // 0x2C
        public dius.ht ik; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD4E4BFCA0
        public void Update(){} // RVA: 0x7FFD4E4BFD30
        public void GetLODLevel(){} // RVA: 0x7FFD4E4BFD70
        public void .ctor(){} // RVA: 0x7FFD4E4C00B0
    }

    public class VRIKRootController : MonoBehaviour
    {
        public amut pelvisTargetRight; // 0x20
        public object pelvisTarget; // 0x30
        public object leftFootTarget; // 0x38
        public object rightFootTarget; // 0x40
        public dius.ht ik; // 0x48

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