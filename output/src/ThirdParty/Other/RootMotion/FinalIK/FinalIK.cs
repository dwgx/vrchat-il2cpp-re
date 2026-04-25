// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 88
// Methods: 983

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class AimController : MonoBehaviour
    {
        public RootMotion.FinalIK.AimIK pivot; // 0x20
        public float weight; // 0x28
        public UnityEngine.Transform target; // 0x30
        public float targetSwitchSmoothTime; // 0x38
        public float weightSmoothTime; // 0x3C
        public bool smoothTurnTowardsTarget; // 0x40
        public float maxRadiansDelta; // 0x44
        public float maxMagnitudeDelta; // 0x48
        public float slerpSpeed; // 0x4C
        public UnityEngine.Vector3 pivotOffsetFromRoot; // 0x50
        public float minDistance; // 0x5C
        public UnityEngine.Vector3 offset; // 0x60
        public float maxRootAngle; // 0x6C
        public bool turnToTarget; // 0x70
        public float turnToTargetTime; // 0x74
        public bool useAnimatedAimDirection; // 0x78
        public UnityEngine.Vector3 animatedAimDirection; // 0x7C
        public UnityEngine.Transform lastTarget; // 0x88
        public float switchWeight; // 0x90
        public float switchWeightV; // 0x94
        public float weightV; // 0x98
        public UnityEngine.Vector3 lastPosition; // 0x9C
        public UnityEngine.Vector3 dir; // 0xA8
        public bool lastSmoothTowardsTarget; // 0xB4
        public bool turningToTarget; // 0xB5
        public float turnToTargetMlp; // 0xB8
        public float turnToTargetMlpV; // 0xBC

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC308B580
        public void LateUpdate(){} // RVA: 0x7FFAC308B6B0
        public void get_pivot(){} // RVA: 0x7FFAC308C480
        public void ApplyMinDistance(){} // RVA: 0x7FFAC308C810
        public void RootRotation(){} // RVA: 0x7FFAC308C9D0
        public void TurnToTarget(){} // RVA: 0x7FFAC308D0D0
        public void .ctor(){} // RVA: 0x7FFAC308D170
    }

    public class AimIK : IK
    {
        public RootMotion.FinalIK.IKSolverAim solver; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OpenSetupTutorial(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC2FEEE20
    }

    public class AimPoser : MonoBehaviour
    {
        public float angleBuffer; // 0x20
        public Pose[] poses; // 0x28

        // ── Methods ──
        public void GetPose(){} // RVA: 0x7FFAC308D3E0
        public void SetPoseActive(){} // RVA: 0x7FFAC308D4F0
        public void .ctor(){} // RVA: 0x7FFAC308D570
    }

    public class Amplifier : OffsetModifier
    {
        public Body[] bodies; // 0x38

        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFAC308D9B0
        public void .ctor(){} // RVA: 0x7FFAC2F29920
    }

    public class ArmIK : IK
    {
        public RootMotion.FinalIK.IKSolverArm solver; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC2FEEF00
    }

    public class BipedIK : SolverManager
    {
        public RootMotion.BipedReferences references; // 0x40
        public RootMotion.FinalIK.BipedIKSolvers solvers; // 0x48

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetIKPositionWeight(){} // RVA: 0x7FFAC2FD5760
        public void GetIKRotationWeight(){} // RVA: 0x7FFAC2FD5790
        public void SetIKPositionWeight(){} // RVA: 0x7FFAC2FD57C0
        public void SetIKRotationWeight(){} // RVA: 0x7FFAC2FD5820
        public void SetIKPosition(){} // RVA: 0x7FFAC2FD5880
        public void SetIKRotation(){} // RVA: 0x7FFAC2FD58C0
        public void GetIKPosition(){} // RVA: 0x7FFAC2FD58F0
        public void GetIKRotation(){} // RVA: 0x7FFAC2FD5950
        public void SetLookAtWeight(){} // RVA: 0x7FFAC2FD5990
        public void SetLookAtPosition(){} // RVA: 0x7FFAC2FD5AA0
        public void SetSpinePosition(){} // RVA: 0x7FFAC2FD5AD0
        public void SetSpineWeight(){} // RVA: 0x7FFAC2FD5B00
        public void GetGoalIK(){} // RVA: 0x7FFAC2FD5B50
        public void InitiateBipedIK(){} // RVA: 0x7FFAC2FD5BC0
        public void UpdateBipedIK(){} // RVA: 0x7FFAC2FD5BE0
        public void SetToDefaults(){} // RVA: 0x7FFAC2FD5C00
        public void FixTransforms(){} // RVA: 0x7FFAC2FD5DB0
        public void InitiateSolver(){} // RVA: 0x7FFAC2FD5E80
        public void UpdateSolver(){} // RVA: 0x7FFAC2FD62A0
        public void LogWarning(){} // RVA: 0x7FFAC2FD66F0
        public void .ctor(){} // RVA: 0x7FFAC2FD6760
    }

    public class BipedIKSolvers : Object
    {
        public RootMotion.FinalIK.IKSolverLimb limbs; // 0x10
        public RootMotion.FinalIK.IKSolverLimb ikSolvers; // 0x18
        public RootMotion.FinalIK.IKSolverLimb leftHand; // 0x20
        public RootMotion.FinalIK.IKSolverLimb rightHand; // 0x28
        public RootMotion.FinalIK.IKSolverFABRIK spine; // 0x30
        public RootMotion.FinalIK.IKSolverLookAt lookAt; // 0x38
        public RootMotion.FinalIK.IKSolverAim aim; // 0x40
        public RootMotion.FinalIK.Constraints pelvis; // 0x48
        public RootMotion.FinalIK.IKSolverLimb[] _limbs; // 0x50
        public RootMotion.FinalIK.IKSolver[] _ikSolvers; // 0x58

        // ── Methods ──
        public void get_limbs(){} // RVA: 0x7FFAC2FD68E0
        public void get_ikSolvers(){} // RVA: 0x7FFAC2FD6AB0
        public void AssignReferences(){} // RVA: 0x7FFAC2FD6D40
        public void .ctor(){} // RVA: 0x7FFAC2FD6FB0
    }

    public class BodyTilt : OffsetModifier
    {
        public float tiltSpeed; // 0x38
        public float tiltSensitivity; // 0x3C
        public RootMotion.FinalIK.OffsetPose poseLeft; // 0x40
        public RootMotion.FinalIK.OffsetPose poseRight; // 0x48
        public float tiltAngle; // 0x50
        public UnityEngine.Vector3 lastForward; // 0x54

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC308E220
        public void OnModifyOffset(){} // RVA: 0x7FFAC308E330
        public void .ctor(){} // RVA: 0x7FFAC308E6E0
    }

    public class CCDIK : IK
    {
        public RootMotion.FinalIK.IKSolverCCD solver; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC2FEEFE0
    }

    public class Constraint : Object
    {
        public UnityEngine.Transform isValid; // 0x10
        public float weight; // 0x18

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFAC2FD73B0
        public void UpdateConstraint(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ConstraintPosition : Constraint
    {
        public UnityEngine.Vector3 position; // 0x20

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFAC2FD7480
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
    }

    public class ConstraintPositionOffset : Constraint
    {
        public UnityEngine.Vector3 positionChanged; // 0x20
        public UnityEngine.Vector3 defaultLocalPosition; // 0x2C
        public UnityEngine.Vector3 lastLocalPosition; // 0x38
        public bool initiated; // 0x44

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFAC2FD75F0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_positionChanged(){} // RVA: 0x7FFAC2FD7A20
    }

    public class ConstraintRotation : Constraint
    {
        public UnityEngine.Quaternion rotation; // 0x20

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFAC2FD7AF0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
    }

    public class ConstraintRotationOffset : Constraint
    {
        public UnityEngine.Quaternion rotationChanged; // 0x20
        public UnityEngine.Quaternion defaultRotation; // 0x30
        public UnityEngine.Quaternion defaultLocalRotation; // 0x40
        public UnityEngine.Quaternion lastLocalRotation; // 0x50
        public UnityEngine.Quaternion defaultTargetLocalRotation; // 0x60
        public bool initiated; // 0x70

        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7FFAC2FD7C70
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_rotationChanged(){} // RVA: 0x7FFAC2FD80B0
    }

    public class Constraints : Object
    {
        public UnityEngine.Transform transform; // 0x10
        public UnityEngine.Transform target; // 0x18
        public UnityEngine.Vector3 positionOffset; // 0x20
        public UnityEngine.Vector3 position; // 0x2C
        public float positionWeight; // 0x38
        public UnityEngine.Vector3 rotationOffset; // 0x3C
        public UnityEngine.Vector3 rotation; // 0x48
        public float rotationWeight; // 0x54

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC2FD8180
        public void Initiate(){} // RVA: 0x7FFAC2FD8250
        public void Update(){} // RVA: 0x7FFAC2FD83B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EditorIK : MonoBehaviour
    {
        public RootMotion.FinalIK.IK ik; // 0x20

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC308E740
        public void Update(){} // RVA: 0x7FFAC308E860
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class FABRIK : IK
    {
        public RootMotion.FinalIK.IKSolverFABRIK solver; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC2FEF0C0
    }

    public class FABRIKChain : Object
    {
        public RootMotion.FinalIK.FABRIK ik; // 0x10
        public float pull; // 0x18
        public float pin; // 0x1C
        public int[] children; // 0x20

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC2FF3B50
        public void Initiate(){} // RVA: 0x7FFAC2FF3CE0
        public void Stage1(){} // RVA: 0x7FFAC2FF3D40
        public void Stage2(){} // RVA: 0x7FFAC2FF3F10
        public void GetCentroid(){} // RVA: 0x7FFAC2FF4150
        public void .ctor(){} // RVA: 0x7FFAC2FF4410
    }

    public class FABRIKRoot : IK
    {
        public RootMotion.FinalIK.IKSolverFABRIKRoot solver; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC2FEF1A0
    }

    public class FBBIKArmBending : MonoBehaviour
    {
        public RootMotion.FinalIK.FullBodyBipedIK ik; // 0x20
        public UnityEngine.Vector3 bendDirectionOffsetLeft; // 0x28
        public UnityEngine.Vector3 bendDirectionOffsetRight; // 0x34
        public UnityEngine.Vector3 characterSpaceBendOffsetLeft; // 0x40
        public UnityEngine.Vector3 characterSpaceBendOffsetRight; // 0x4C
        public UnityEngine.Quaternion leftHandTargetRotation; // 0x58
        public UnityEngine.Quaternion rightHandTargetRotation; // 0x68
        public bool initiated; // 0x78
        public UpdateDelegate OnPostArmBend; // 0x80

        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFAC2FF44B0
        public void OnPostFBBIK(){} // RVA: 0x7FFAC2FF4FB0
        public void OnDestroy(){} // RVA: 0x7FFAC2FF5490
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class FBBIKHeadEffector : MonoBehaviour
    {
        public RootMotion.FinalIK.FullBodyBipedIK ik; // 0x20
        public float positionWeight; // 0x28
        public float bodyWeight; // 0x2C
        public float thighWeight; // 0x30
        public bool handsPullBody; // 0x34
        public float rotationWeight; // 0x38
        public float bodyClampWeight; // 0x3C
        public float headClampWeight; // 0x40
        public float bendWeight; // 0x44
        public BendBone[] bendBones; // 0x48
        public float CCDWeight; // 0x50
        public float roll; // 0x54
        public float damper; // 0x58
        public UnityEngine.Transform[] CCDBones; // 0x60
        public float postStretchWeight; // 0x68
        public float maxStretch; // 0x6C
        public float stretchDamper; // 0x70
        public bool fixHead; // 0x74
        public UnityEngine.Transform[] stretchBones; // 0x78
        public UnityEngine.Vector3 chestDirection; // 0x80
        public float chestDirectionWeight; // 0x8C
        public UnityEngine.Transform[] chestBones; // 0x90
        public UpdateDelegate OnPostHeadEffectorFK; // 0x98
        public UnityEngine.Vector3 offset; // 0xA0
        public UnityEngine.Vector3 headToBody; // 0xAC
        public UnityEngine.Vector3 shoulderCenterToHead; // 0xB8
        public UnityEngine.Vector3 headToLeftThigh; // 0xC4
        public UnityEngine.Vector3 headToRightThigh; // 0xD0
        public UnityEngine.Vector3 leftShoulderPos; // 0xDC
        public UnityEngine.Vector3 rightShoulderPos; // 0xE8
        public float shoulderDist; // 0xF4
        public float leftShoulderDist; // 0xF8
        public float rightShoulderDist; // 0xFC
        public UnityEngine.Quaternion chestRotation; // 0x100
        public UnityEngine.Quaternion headRotationRelativeToRoot; // 0x110
        public UnityEngine.Quaternion[] ccdDefaultLocalRotations; // 0x120
        public UnityEngine.Vector3 headLocalPosition; // 0x128
        public UnityEngine.Quaternion headLocalRotation; // 0x134
        public UnityEngine.Vector3[] stretchLocalPositions; // 0x148
        public UnityEngine.Quaternion[] stretchLocalRotations; // 0x150
        public UnityEngine.Vector3[] chestLocalPositions; // 0x158
        public UnityEngine.Quaternion[] chestLocalRotations; // 0x160
        public int bendBonesCount; // 0x168
        public int ccdBonesCount; // 0x16C
        public int stretchBonesCount; // 0x170
        public int chestBonesCount; // 0x174
        public bool _isVRCAvatarMainIK; // 0x178

        // ── Methods ──
        public void VRCInitialize(){} // RVA: 0x7FFAC2FF5690
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFAC2FF56A0
        public void Start(){} // RVA: 0x7FFAC2FF56B0
        public void Initialize(){} // RVA: 0x7FFAC2FF56D0
        public void OnStoreDefaultLocalState(){} // RVA: 0x7FFAC2FF5F70
        public void OnFixTransforms(){} // RVA: 0x7FFAC2FF69E0
        public void OnPreRead(){} // RVA: 0x7FFAC2FF72D0
        public void SpineBend(){} // RVA: 0x7FFAC2FF81C0
        public void CCDPass(){} // RVA: 0x7FFAC2FF8AD0
        public void Iterate(){} // RVA: 0x7FFAC2FF9360
        public void OnPostUpdate(){} // RVA: 0x7FFAC2FFA350
        public void ChestDirection(){} // RVA: 0x7FFAC2FFA960
        public void PostStretching(){} // RVA: 0x7FFAC2FFAEA0
        public void LerpSolverPosition(){} // RVA: 0x7FFAC2FFB4D0
        public void Solve(){} // RVA: 0x7FFAC2FFB670
        public void OnDestroy(){} // RVA: 0x7FFAC2FFB7B0
        public void .ctor(){} // RVA: 0x7FFAC2FFBE00
    }

    public class FBIKChain : Object
    {
        public float pin; // 0x10
        public float pull; // 0x14
        public float push; // 0x18
        public float pushParent; // 0x1C
        public float reach; // 0x20
        public 0x6B1BFBA0 reachSmoothing; // 0x24
        public 0x6B1BFBA0 pushSmoothing; // 0x28
        public Node[] nodes; // 0x30
        public int[] children; // 0x38
        public ChildConstraint[] childConstraints; // 0x40
        public RootMotion.FinalIK.IKConstraintBend bendConstraint; // 0x48
        public float rootLength; // 0x50
        public bool initiated; // 0x54
        public float length; // 0x58
        public float distance; // 0x5C
        public Point p; // 0x60
        public float reachForce; // 0x68
        public float pullParentSum; // 0x6C
        public float[] crossFades; // 0x70
        public float sqrMag1; // 0x78
        public float sqrMag2; // 0x7C
        public float sqrMagDif; // 0x80
        public float maxLimbLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FFC710 | overloaded x2
        public void SetNodes(){} // RVA: 0x7FFAC2FFCA00
        public void GetNodeIndex(){} // RVA: 0x7FFAC2FFCC50
        public void IsValid(){} // RVA: 0x7FFAC2FFCDE0
        public void Initiate(){} // RVA: 0x7FFAC2FFCFA0
        public void ReadPose(){} // RVA: 0x7FFAC2FFD220
        public void CalculateBoneLengths(){} // RVA: 0x7FFAC2FFD8C0
        public void Reach(){} // RVA: 0x7FFAC2FFDFB0
        public void Push(){} // RVA: 0x7FFAC2FFE310
        public void SolveTrigonometric(){} // RVA: 0x7FFAC2FFE700
        public void Stage1(){} // RVA: 0x7FFAC2FFEA70
        public void Stage2(){} // RVA: 0x7FFAC2FFEF50
        public void SolveConstraintSystems(){} // RVA: 0x7FFAC2FFF1C0
        public void SolveFABRIKJoint(){} // RVA: 0x7FFAC2FFF310
        public void GetDirToBendPoint(){} // RVA: 0x7FFAC2FFF450
        public void SolveChildConstraints(){} // RVA: 0x7FFAC2FFF840
        public void SolveLinearConstraint(){} // RVA: 0x7FFAC2FFFB90
        public void ForwardReach(){} // RVA: 0x7FFAC2FFFD20
        public void BackwardReach(){} // RVA: 0x7FFAC2FFFF50
    }

    public class Finger : Object
    {
        public float initiated; // 0x10
        public float IKPosition; // 0x14
        public 0x6B1BEF98 IKRotation; // 0x18
        public bool fixBone1Twist; // 0x1C
        public UnityEngine.Transform bone1; // 0x20
        public UnityEngine.Transform bone2; // 0x28
        public UnityEngine.Transform bone3; // 0x30
        public UnityEngine.Transform tip; // 0x38
        public UnityEngine.Transform target; // 0x40
        public bool <initiated>k__BackingField; // 0x48
        public RootMotion.FinalIK.IKSolverLimb solver; // 0x50
        public UnityEngine.Quaternion bone3RelativeToTarget; // 0x58
        public UnityEngine.Vector3 bone3DefaultLocalPosition; // 0x68
        public UnityEngine.Quaternion bone3DefaultLocalRotation; // 0x74
        public UnityEngine.Vector3 bone1Axis; // 0x84
        public UnityEngine.Vector3 tipAxis; // 0x90
        public UnityEngine.Vector3 bone1TwistAxis; // 0x9C

        // ── Methods ──
        public void get_initiated(){} // RVA: 0x7FFAC2FD8D30
        public void set_initiated(){} // RVA: 0x7FFAC2FD8D40
        public void get_IKPosition(){} // RVA: 0x7FFAC2FD8D50
        public void set_IKPosition(){} // RVA: 0x7FFAC2FD8D80
        public void get_IKRotation(){} // RVA: 0x7FFAC2FD8DB0
        public void set_IKRotation(){} // RVA: 0x7FFAC2FD8DE0
        public void IsValid(){} // RVA: 0x7FFAC2FD8E00
        public void Initiate(){} // RVA: 0x7FFAC2FD9080
        public void FixTransforms(){} // RVA: 0x7FFAC2FDA230
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC2FDA410
        public void Update(){} // RVA: 0x7FFAC2FDA5F0
        public void .ctor(){} // RVA: 0x7FFAC2FDB8D0
    }

    public class FingerRig : SolverManager
    {
        public float initiated; // 0x40
        public RootMotion.FinalIK.Finger[] fingers; // 0x48
        public bool <initiated>k__BackingField; // 0x50

        // ── Methods ──
        public void get_initiated(){} // RVA: 0x7FFAC2FDB8E0
        public void set_initiated(){} // RVA: 0x7FFAC2FDB8F0
        public void IsValid(){} // RVA: 0x7FFAC2FDB900
        public void AutoDetect(){} // RVA: 0x7FFAC2FDB980
        public void AddFinger(){} // RVA: 0x7FFAC2FDBE70
        public void RemoveFinger(){} // RVA: 0x7FFAC2FDC1B0
        public void AddChildrenRecursive(){} // RVA: 0x7FFAC2FDC3C0
        public void InitiateSolver(){} // RVA: 0x7FFAC2FDC520
        public void UpdateFingerSolvers(){} // RVA: 0x7FFAC2FDC620
        public void FixFingerTransforms(){} // RVA: 0x7FFAC2FDC690
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC2FDC8E0
        public void UpdateSolver(){} // RVA: 0x7FFAC2FDC620
        public void FixTransforms(){} // RVA: 0x7FFAC2FDCB10
        public void .ctor(){} // RVA: 0x7FFAC2FDCB30
    }

    public class FullBodyBipedIK : IK
    {
        public bool _isVRCAvatarMainIK; // 0x40
        public RootMotion.BipedReferences references; // 0x48
        public RootMotion.FinalIK.IKSolverFullBodyBiped solver; // 0x50

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OpenSetupTutorial(){} // RVA: 0x7FFAC2F21310
        public void OpenInspectorTutorial(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void SetReferences(){} // RVA: 0x7FFAC2FEF310
        public void GetIKSolver(){} // RVA: 0x7FFAC2FC20E0
        public void ReferencesError(){} // RVA: 0x7FFAC2FEF380
        public void ReferencesWarning(){} // RVA: 0x7FFAC2FEF7D0
        public void Reinitiate(){} // RVA: 0x7FFAC2FEFF70
        public void AutoDetectReferences(){} // RVA: 0x7FFAC2FEFFA0
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFAC2FDCC10
        public void VRCInitiateSolver(){} // RVA: 0x7FFAC2FF0150
        public void InitiateSolver(){} // RVA: 0x7FFAC2FF0160
        public void .ctor(){} // RVA: 0x7FFAC2FF0170
    }

    public class GenericPoser : Poser
    {
        public Map[] maps; // 0x58

        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x7FFAC30802B0
        public void InitiatePoser(){} // RVA: 0x7FFAC3080840
        public void UpdatePoser(){} // RVA: 0x7FFAC3080850
        public void FixPoserTransforms(){} // RVA: 0x7FFAC30809C0
        public void StoreDefaultState(){} // RVA: 0x7FFAC3080B20
        public void GetTargetNamed(){} // RVA: 0x7FFAC3080C90
        public void .ctor(){} // RVA: 0x7FFAC3080D50
    }

    public class Grounder : MonoBehaviour
    {
        public float initiated; // 0x20
        public RootMotion.FinalIK.Grounding solver; // 0x28
        public GrounderDelegate OnPreGrounder; // 0x30
        public GrounderDelegate OnPostGrounder; // 0x38
        public bool <initiated>k__BackingField; // 0x40

        // ── Methods ──
        public void ResetPosition(){} // RVA: 0x7FFAC2C70980
        public void get_initiated(){} // RVA: 0x7FFAC2FDCC00
        public void set_initiated(){} // RVA: 0x7FFAC2FDCC10
        public void GetSpineOffsetTarget(){} // RVA: 0x7FFAC2FDCC20
        public void LogWarning(){} // RVA: 0x7FFAC2FD66F0
        public void GetLegSpineBendVector(){} // RVA: 0x7FFAC2FDCD60
        public void GetLegSpineTangent(){} // RVA: 0x7FFAC2FDCFB0
        public void OpenUserManual(){} // RVA: 0x7FFAC2C70980
        public void OpenScriptReference(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2FDD260
    }

    public class GrounderBipedIK : Grounder
    {
        public RootMotion.FinalIK.BipedIK ik; // 0x48
        public float spineBend; // 0x50
        public float spineSpeed; // 0x54
        public UnityEngine.Transform[] feet; // 0x58
        public UnityEngine.Quaternion[] footRotations; // 0x60
        public UnityEngine.Vector3 animatedPelvisLocalPosition; // 0x68
        public UnityEngine.Vector3 solvedPelvisLocalPosition; // 0x74
        public UnityEngine.Vector3 spineOffset; // 0x80
        public float lastWeight; // 0x8C

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void ResetPosition(){} // RVA: 0x7FFAC2FDD380
        public void IsReadyToInitiate(){} // RVA: 0x7FFAC2FDD3F0
        public void Update(){} // RVA: 0x7FFAC2FDD510
        public void Initiate(){} // RVA: 0x7FFAC2FDD660
        public void OnDisable(){} // RVA: 0x7FFAC2FDDBF0
        public void OnSolverUpdate(){} // RVA: 0x7FFAC2FDDC50
        public void SetLegIK(){} // RVA: 0x7FFAC2FDE770
        public void OnPostSolverUpdate(){} // RVA: 0x7FFAC2FDE890
        public void OnDestroy(){} // RVA: 0x7FFAC2FDECE0
        public void .ctor(){} // RVA: 0x7FFAC2FDF020
    }

    public class GrounderFBBIK : Grounder
    {
        public RootMotion.FinalIK.FullBodyBipedIK ik; // 0x48
        public float spineBend; // 0x50
        public float spineSpeed; // 0x54
        public SpineEffector[] spine; // 0x58
        public UnityEngine.Transform[] feet; // 0x60
        public UnityEngine.Vector3 spineOffset; // 0x68
        public bool firstSolve; // 0x74

        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0x7FFAC2F21310
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void ResetPosition(){} // RVA: 0x7FFAC2FDF150
        public void IsReadyToInitiate(){} // RVA: 0x7FFAC2FDF1C0
        public void Update(){} // RVA: 0x7FFAC2FDF2C0
        public void FixedUpdate(){} // RVA: 0x7FFAC2FDF400
        public void LateUpdate(){} // RVA: 0x7FFAC2FDF400
        public void Initiate(){} // RVA: 0x7FFAC2FDF410
        public void OnSolverUpdate(){} // RVA: 0x7FFAC2FDF7D0
        public void SetLegIK(){} // RVA: 0x7FFAC2FDFD90
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC2FE0180
        public void OnDestroy(){} // RVA: 0x7FFAC2FE04D0
        public void .ctor(){} // RVA: 0x7FFAC2FE06D0
    }

    public class GrounderIK : Grounder
    {
        public RootMotion.FinalIK.IK[] legs; // 0x48
        public UnityEngine.Transform pelvis; // 0x50
        public UnityEngine.Transform characterRoot; // 0x58
        public float rootRotationWeight; // 0x60
        public float rootRotationSpeed; // 0x64
        public float maxRootRotationAngle; // 0x68
        public UnityEngine.Transform[] feet; // 0x70
        public UnityEngine.Quaternion[] footRotations; // 0x78
        public UnityEngine.Vector3 animatedPelvisLocalPosition; // 0x80
        public UnityEngine.Vector3 solvedPelvisLocalPosition; // 0x8C
        public int solvedFeet; // 0x98
        public bool solved; // 0x9C
        public float lastWeight; // 0xA0
        public UnityEngine.Rigidbody characterRootRigidbody; // 0xA8

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void ResetPosition(){} // RVA: 0x7FFAC2FE0810
        public void IsReadyToInitiate(){} // RVA: 0x7FFAC2FE0830
        public void OnDisable(){} // RVA: 0x7FFAC2FE0B10
        public void Update(){} // RVA: 0x7FFAC2FE0C80
        public void Initiate(){} // RVA: 0x7FFAC2FE16C0
        public void OnSolverUpdate(){} // RVA: 0x7FFAC2FE1FD0
        public void SetLegIK(){} // RVA: 0x7FFAC2FE2520
        public void OnPostSolverUpdate(){} // RVA: 0x7FFAC2FE2AD0
        public void OnDestroy(){} // RVA: 0x7FFAC2FE2F30
        public void .ctor(){} // RVA: 0x7FFAC2FE3230
    }

    public class GrounderQuadruped : Grounder
    {
        public RootMotion.FinalIK.Grounding forelegSolver; // 0x48
        public float rootRotationWeight; // 0x50
        public float minRootRotation; // 0x54
        public float maxRootRotation; // 0x58
        public float rootRotationSpeed; // 0x5C
        public float maxLegOffset; // 0x60
        public float maxForeLegOffset; // 0x64
        public float maintainHeadRotationWeight; // 0x68
        public UnityEngine.Transform characterRoot; // 0x70
        public UnityEngine.Transform pelvis; // 0x78
        public UnityEngine.Transform lastSpineBone; // 0x80
        public UnityEngine.Transform head; // 0x88
        public RootMotion.FinalIK.IK[] legs; // 0x90
        public RootMotion.FinalIK.IK[] forelegs; // 0x98
        public UnityEngine.Vector3 gravity; // 0xA0
        public Foot[] feet; // 0xB0
        public UnityEngine.Vector3 animatedPelvisLocalPosition; // 0xB8
        public UnityEngine.Quaternion animatedPelvisLocalRotation; // 0xC4
        public UnityEngine.Quaternion animatedHeadLocalRotation; // 0xD4
        public UnityEngine.Vector3 solvedPelvisLocalPosition; // 0xE4
        public UnityEngine.Quaternion solvedPelvisLocalRotation; // 0xF0
        public UnityEngine.Quaternion solvedHeadLocalRotation; // 0x100
        public int solvedFeet; // 0x110
        public bool solved; // 0x114
        public float angle; // 0x118
        public UnityEngine.Transform forefeetRoot; // 0x120
        public UnityEngine.Quaternion headRotation; // 0x128
        public float lastWeight; // 0x138
        public UnityEngine.Rigidbody characterRootRigidbody; // 0x140

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void ResetPosition(){} // RVA: 0x7FFAC2FE3350
        public void IsReadyToInitiate(){} // RVA: 0x7FFAC2FE3390
        public void IsReadyToInitiateLegs(){} // RVA: 0x7FFAC2FE3610
        public void OnDisable(){} // RVA: 0x7FFAC2FE3850
        public void Update(){} // RVA: 0x7FFAC2FE38D0
        public void Initiate(){} // RVA: 0x7FFAC2FE3940
        public void InitiateFeet(){} // RVA: 0x7FFAC2FE40C0
        public void LateUpdate(){} // RVA: 0x7FFAC2FE4790
        public void RootRotation(){} // RVA: 0x7FFAC2FE48A0
        public void OnSolverUpdate(){} // RVA: 0x7FFAC2FE5320
        public void UpdateForefeetRoot(){} // RVA: 0x7FFAC2FE6400
        public void SetFootIK(){} // RVA: 0x7FFAC2FE6950
        public void OnPostSolverUpdate(){} // RVA: 0x7FFAC2FE6B40
        public void OnDestroy(){} // RVA: 0x7FFAC2FE72E0
        public void DestroyLegs(){} // RVA: 0x7FFAC2FE7320
        public void .ctor(){} // RVA: 0x7FFAC2FE7610
    }

    public class GrounderVRIK : Grounder
    {
        public RootMotion.FinalIK.VRIK ik; // 0x48
        public UnityEngine.Transform[] feet; // 0x50

        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0x7FFAC2F21310
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void ResetPosition(){} // RVA: 0x7FFAC2FE0810
        public void IsReadyToInitiate(){} // RVA: 0x7FFAC2FE7C20
        public void Update(){} // RVA: 0x7FFAC2FE7D20
        public void Initiate(){} // RVA: 0x7FFAC2FE7E50
        public void OnSolverUpdate(){} // RVA: 0x7FFAC2FE8230
        public void SetLegIK(){} // RVA: 0x7FFAC2FE86D0
        public void OnPostSolverUpdate(){} // RVA: 0x7FFAC2FE8800
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC2FE8DF0
        public void OnDestroy(){} // RVA: 0x7FFAC2FE9140
        public void .ctor(){} // RVA: 0x7FFAC2FE9470
    }

    public class Grounding : Object
    {
        public UnityEngine.LayerMask legs; // 0x10
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
        public 0x6B1BF3B8 quality; // 0x54
        public Leg[] <legs>k__BackingField; // 0x58
        public Pelvis <pelvis>k__BackingField; // 0x60
        public bool <isGrounded>k__BackingField; // 0x68
        public UnityEngine.Transform <root>k__BackingField; // 0x70
        public UnityEngine.RaycastHit <rootHit>k__BackingField; // 0x78
        public bool initiated; // 0xA4

        // ── Methods ──
        public void get_legs(){} // RVA: 0x7FFAC2FE9500
        public void set_legs(){} // RVA: 0x7FFAC2FE9510
        public void get_pelvis(){} // RVA: 0x7FFAC2FBF370
        public void set_pelvis(){} // RVA: 0x7FFAC2FBF380
        public void get_isGrounded(){} // RVA: 0x7FFAC2FE9570
        public void set_isGrounded(){} // RVA: 0x7FFAC2FE9580
        public void get_root(){} // RVA: 0x7FFAC2FE9590
        public void set_root(){} // RVA: 0x7FFAC2FE95A0
        public void get_rootHit(){} // RVA: 0x7FFAC2FE9600
        public void set_rootHit(){} // RVA: 0x7FFAC2FE9630
        public void get_rootGrounded(){} // RVA: 0x7FFAC2FE9660
        public void GetRootHit(){} // RVA: 0x7FFAC2FE9680
        public void IsValid(){} // RVA: 0x7FFAC2FE9C90
        public void Initiate(){} // RVA: 0x7FFAC2FE9EF0
        public void Update(){} // RVA: 0x7FFAC2FEA4A0
        public void GetLegsPlaneNormal(){} // RVA: 0x7FFAC2FEA730
        public void Reset(){} // RVA: 0x7FFAC2FEAC10
        public void LogWarning(){} // RVA: 0x7FFAC2FEAFF0
        public void get_up(){} // RVA: 0x7FFAC2FEB010
        public void GetVerticalOffset(){} // RVA: 0x7FFAC2FEB0A0
        public void Flatten(){} // RVA: 0x7FFAC2FEB290
        public void get_useRootRotation(){} // RVA: 0x7FFAC2FEB3D0
        public void GetFootCenterOffset(){} // RVA: 0x7FFAC2FEB4A0
        public void .ctor(){} // RVA: 0x7FFAC2FEB580
    }

    public class HandPoser : Poser
    {
        public UnityEngine.Transform[] children; // 0x58
        public UnityEngine.Transform _poseRoot; // 0x60
        public UnityEngine.Transform[] poseChildren; // 0x68
        public UnityEngine.Vector3[] defaultLocalPositions; // 0x70
        public UnityEngine.Quaternion[] defaultLocalRotations; // 0x78

        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x7FFAC3081290
        public void InitiatePoser(){} // RVA: 0x7FFAC3081500
        public void FixPoserTransforms(){} // RVA: 0x7FFAC30815C0
        public void UpdatePoser(){} // RVA: 0x7FFAC3081760
        public void StoreDefaultState(){} // RVA: 0x7FFAC3081F00
        public void .ctor(){} // RVA: 0x7FFAC3080D50
    }

    public class HitReaction : OffsetModifier
    {
        public HitPointEffector[] inProgress; // 0x38
        public HitPointBone[] boneHitPoints; // 0x40

        // ── Methods ──
        public void get_inProgress(){} // RVA: 0x7FFAC308E9A0
        public void OnModifyOffset(){} // RVA: 0x7FFAC308EA50
        public void Hit(){} // RVA: 0x7FFAC308EB30
        public void .ctor(){} // RVA: 0x7FFAC2F29920
    }

    public class HitReactionVRIK : OffsetModifierVRIK
    {
        public UnityEngine.AnimationCurve[] offsetCurves; // 0x38
        public PositionOffset[] positionOffsets; // 0x40
        public RotationOffset[] rotationOffsets; // 0x48

        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFAC30903B0
        public void Hit(){} // RVA: 0x7FFAC3090480
        public void .ctor(){} // RVA: 0x7FFAC2F29920
    }

    public class IK : SolverManager
    {
        // ── Methods ──
        public void GetIKSolver(){} // RVA: 0x7FFAC2C58E90
        public void UpdateSolver(){} // RVA: 0x7FFAC2FF0300
        public void InitiateSolver(){} // RVA: 0x7FFAC2FF03A0
        public void FixTransforms(){} // RVA: 0x7FFAC2FF0450
        public void OpenUserManual(){} // RVA: 0x7FFAC2C70980
        public void OpenScriptReference(){} // RVA: 0x7FFAC2C70980
        public void .ctor(){} // RVA: 0x7FFAC2F7B060
    }

    public class IKConstraintBend : Object
    {
        public UnityEngine.Transform initiated; // 0x10
        public UnityEngine.Transform bone2; // 0x18
        public UnityEngine.Transform bone3; // 0x20
        public UnityEngine.Transform bendGoal; // 0x28
        public UnityEngine.Vector3 direction; // 0x30
        public UnityEngine.Quaternion rotationOffset; // 0x3C
        public float weight; // 0x4C
        public UnityEngine.Vector3 defaultLocalDirection; // 0x50
        public UnityEngine.Vector3 defaultChildDirection; // 0x5C
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
        public void IsValid(){} // RVA: 0x7FFAC3000920
        public void get_initiated(){} // RVA: 0x7FFAC3000CE0
        public void set_initiated(){} // RVA: 0x7FFAC3000CF0
        public void .ctor(){} // RVA: 0x7FFAC3000D60 | overloaded x2
        public void SetBones(){} // RVA: 0x7FFAC3000E00
        public void Initiate(){} // RVA: 0x7FFAC3000F00
        public void SetLimbOrientation(){} // RVA: 0x7FFAC3001940
        public void LimitBend(){} // RVA: 0x7FFAC3001BF0
        public void GetDir(){} // RVA: 0x7FFAC3002860
        public void OrthoToLimb(){} // RVA: 0x7FFAC3003490
        public void OrthoToBone1(){} // RVA: 0x7FFAC3003600
    }

    public class IKEffector : Object
    {
        public UnityEngine.Transform isEndEffector; // 0x10
        public UnityEngine.Transform target; // 0x18
        public float positionWeight; // 0x20
        public float rotationWeight; // 0x24
        public UnityEngine.Vector3 position; // 0x28
        public UnityEngine.Quaternion rotation; // 0x34
        public UnityEngine.Vector3 positionOffset; // 0x44
        public bool <isEndEffector>k__BackingField; // 0x50
        public bool effectChildNodes; // 0x51
        public float maintainRelativePositionWeight; // 0x54
        public UnityEngine.Transform[] childBones; // 0x58
        public UnityEngine.Transform planeBone1; // 0x60
        public UnityEngine.Transform planeBone2; // 0x68
        public UnityEngine.Transform planeBone3; // 0x70
        public UnityEngine.Quaternion planeRotationOffset; // 0x78
        public float posW; // 0x88
        public float rotW; // 0x8C
        public UnityEngine.Vector3[] localPositions; // 0x90
        public bool usePlaneNodes; // 0x98
        public UnityEngine.Quaternion animatedPlaneRotation; // 0x9C
        public UnityEngine.Vector3 animatedPosition; // 0xAC
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
        public void GetNode(){} // RVA: 0x7FFAC3003770
        public void get_isEndEffector(){} // RVA: 0x7FFAC2FDB8E0
        public void set_isEndEffector(){} // RVA: 0x7FFAC2FDB8F0
        public void PinToBone(){} // RVA: 0x7FFAC30037D0
        public void .ctor(){} // RVA: 0x7FFAC3003C50 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFAC3004050
        public void Initiate(){} // RVA: 0x7FFAC3004660
        public void ResetOffset(){} // RVA: 0x7FFAC3004C40
        public void SetToTarget(){} // RVA: 0x7FFAC3004E10
        public void OnPreSolve(){} // RVA: 0x7FFAC3004FC0
        public void OnPostWrite(){} // RVA: 0x7FFAC3005990
        public void GetPlaneRotation(){} // RVA: 0x7FFAC30059E0
        public void Update(){} // RVA: 0x7FFAC3005D60
        public void GetPosition(){} // RVA: 0x7FFAC30061C0
    }

    public class IKExecutionOrder : MonoBehaviour
    {
        public RootMotion.FinalIK.IK[] animatePhysics; // 0x20
        public UnityEngine.Animator animator; // 0x28
        public bool fixedFrame; // 0x30

        // ── Methods ──
        public void get_animatePhysics(){} // RVA: 0x7FFAC2FF04C0
        public void Start(){} // RVA: 0x7FFAC2FF05F0
        public void Update(){} // RVA: 0x7FFAC2FF07B0
        public void FixedUpdate(){} // RVA: 0x7FFAC2FF07E0
        public void LateUpdate(){} // RVA: 0x7FFAC2FF0810
        public void FixTransforms(){} // RVA: 0x7FFAC2FF09A0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class IKMapping : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC3006850
        public void Initiate(){} // RVA: 0x7FFAC2F21310
        public void BoneIsValid(){} // RVA: 0x7FFAC3006860
        public void SolveFABRIKJoint(){} // RVA: 0x7FFAC2FFF310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IKMappingBone : IKMapping
    {
        public UnityEngine.Transform bone; // 0x10
        public float maintainRotationWeight; // 0x18
        public BoneMap boneMap; // 0x20

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC300A050
        public void .ctor(){} // RVA: 0x7FFAC300A250 | overloaded x2
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC300A380
        public void FixTransforms(){} // RVA: 0x7FFAC300A3A0
        public void Initiate(){} // RVA: 0x7FFAC300A420
        public void ReadPose(){} // RVA: 0x7FFAC300A580
        public void WritePose(){} // RVA: 0x7FFAC300A5A0
    }

    public class IKMappingLimb : IKMapping
    {
        public UnityEngine.Transform parentBone; // 0x10
        public UnityEngine.Transform bone1; // 0x18
        public UnityEngine.Transform bone2; // 0x20
        public UnityEngine.Transform bone3; // 0x28
        public float maintainRotationWeight; // 0x30
        public float weight; // 0x34
        public bool updatePlaneRotations; // 0x38
        public BoneMap boneMapParent; // 0x40
        public BoneMap boneMap1; // 0x48
        public BoneMap boneMap2; // 0x50
        public BoneMap boneMap3; // 0x58

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC300A5D0
        public void GetBoneMap(){} // RVA: 0x7FFAC300A670
        public void SetLimbOrientation(){} // RVA: 0x7FFAC300A7B0
        public void .ctor(){} // RVA: 0x7FFAC300B570 | overloaded x2
        public void SetBones(){} // RVA: 0x7FFAC300B800
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC300B950
        public void FixTransforms(){} // RVA: 0x7FFAC300BA60
        public void Initiate(){} // RVA: 0x7FFAC300BCA0
        public void ReadPose(){} // RVA: 0x7FFAC300C300
        public void WritePose(){} // RVA: 0x7FFAC300C380
    }

    public class IKMappingSpine : IKMapping
    {
        public UnityEngine.Transform[] spineBones; // 0x10
        public UnityEngine.Transform leftUpperArmBone; // 0x18
        public UnityEngine.Transform rightUpperArmBone; // 0x20
        public UnityEngine.Transform leftThighBone; // 0x28
        public UnityEngine.Transform rightThighBone; // 0x30
        public int iterations; // 0x38
        public float twistWeight; // 0x3C
        public int rootNodeIndex; // 0x40
        public BoneMap[] spine; // 0x48
        public BoneMap leftUpperArm; // 0x50
        public BoneMap rightUpperArm; // 0x58
        public BoneMap leftThigh; // 0x60
        public BoneMap rightThigh; // 0x68
        public bool useFABRIK; // 0x70

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC300C5C0
        public void .ctor(){} // RVA: 0x7FFAC300D040 | overloaded x2
        public void SetBones(){} // RVA: 0x7FFAC300D340
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC300D4F0
        public void FixTransforms(){} // RVA: 0x7FFAC300D660
        public void Initiate(){} // RVA: 0x7FFAC300D6F0
        public void UseFABRIK(){} // RVA: 0x7FFAC300E360
        public void ReadPose(){} // RVA: 0x7FFAC300E390
        public void WritePose(){} // RVA: 0x7FFAC300E7D0
        public void ForwardReach(){} // RVA: 0x7FFAC300ECF0
        public void BackwardReach(){} // RVA: 0x7FFAC300EF30
        public void MapToSolverPositions(){} // RVA: 0x7FFAC300F160
    }

    public class IKSolver : Object
    {
        public UnityEngine.Vector3 initiated; // 0x10
        public float IKPositionWeight; // 0x1C
        public bool <initiated>k__BackingField; // 0x20
        public UpdateDelegate OnPreInitiate; // 0x28
        public UpdateDelegate OnPostInitiate; // 0x30
        public UpdateDelegate OnPreUpdate; // 0x38
        public UpdateDelegate OnPostUpdate; // 0x40
        public bool firstInitiation; // 0x48
        public UnityEngine.Transform root; // 0x50

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void Initiate(){} // RVA: 0x7FFAC300F730
        public void Update(){} // RVA: 0x7FFAC300F920
        public void GetIKPosition(){} // RVA: 0x7FFAC2F3E8D0
        public void SetIKPosition(){} // RVA: 0x7FFAC2F3E8F0
        public void GetIKPositionWeight(){} // RVA: 0x7FFAC2FEE570
        public void SetIKPositionWeight(){} // RVA: 0x7FFAC300F9A0
        public void GetRoot(){} // RVA: 0x7FFAC2FC20E0
        public void get_initiated(){} // RVA: 0x7FFAC300F9D0
        public void set_initiated(){} // RVA: 0x7FFAC300F9E0
        public void GetPoints(){} // RVA: 0x7FFAC2C58E90
        public void GetPoint(){} // RVA: 0x7FFAC2C58F40
        public void FixTransforms(){} // RVA: 0x7FFAC2C70980
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC2C70980
        public void OnInitiate(){} // RVA: 0x7FFAC2C70980
        public void OnUpdate(){} // RVA: 0x7FFAC2C70980
        public void LogWarning(){} // RVA: 0x7FFAC300F9F0
        public void ContainsDuplicateBone(){} // RVA: 0x7FFAC300FAA0
        public void HierarchyIsValid(){} // RVA: 0x7FFAC300FC70
        public void PreSolveBones(){} // RVA: 0x7FFAC300FD00
        public void .ctor(){} // RVA: 0x7FFAC30101A0
    }

    public class IKSolverAim : IKSolverHeuristic
    {
        public UnityEngine.Transform transformAxis; // 0x88
        public UnityEngine.Vector3 transformPoleAxis; // 0x90
        public UnityEngine.Vector3 minBones; // 0x9C
        public UnityEngine.Vector3 localDirection; // 0xA8
        public float poleWeight; // 0xB4
        public UnityEngine.Transform poleTarget; // 0xB8
        public float clampWeight; // 0xC0
        public int clampSmoothing; // 0xC4
        public IterationDelegate OnPreIteration; // 0xC8
        public float step; // 0xD0
        public UnityEngine.Vector3 clampedIKPosition; // 0xD4
        public RootMotion.FinalIK.RotationLimit transformLimit; // 0xE0
        public UnityEngine.Transform lastTransform; // 0xE8

        // ── Methods ──
        public void GetAngle(){} // RVA: 0x7FFAC30124C0
        public void get_transformAxis(){} // RVA: 0x7FFAC30125D0
        public void get_transformPoleAxis(){} // RVA: 0x7FFAC3012840
        public void OnInitiate(){} // RVA: 0x7FFAC3012AB0
        public void OnUpdate(){} // RVA: 0x7FFAC3012F90
        public void get_minBones(){} // RVA: 0x7FFAC3013AF0
        public void Solve(){} // RVA: 0x7FFAC3013B00
        public void GetClampedIKPosition(){} // RVA: 0x7FFAC3013C50
        public void RotateToTarget(){} // RVA: 0x7FFAC30141D0
        public void get_localDirection(){} // RVA: 0x7FFAC3015080
        public void .ctor(){} // RVA: 0x7FFAC3015190
    }

    public class IKSolverArm : IKSolver
    {
        public float IKRotationWeight; // 0x58
        public UnityEngine.Quaternion IKRotation; // 0x5C
        public Point chest; // 0x70
        public Point shoulder; // 0x78
        public Point upperArm; // 0x80
        public Point forearm; // 0x88
        public Point hand; // 0x90
        public bool isLeft; // 0x98
        public Arm arm; // 0xA0
        public UnityEngine.Vector3[] positions; // 0xA8
        public UnityEngine.Quaternion[] rotations; // 0xB0

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC3015250
        public void SetChain(){} // RVA: 0x7FFAC3015940
        public void GetPoints(){} // RVA: 0x7FFAC3015B60
        public void GetPoint(){} // RVA: 0x7FFAC3015D10
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC3016260
        public void FixTransforms(){} // RVA: 0x7FFAC30162C0
        public void OnInitiate(){} // RVA: 0x7FFAC3016330
        public void OnUpdate(){} // RVA: 0x7FFAC3016450
        public void Solve(){} // RVA: 0x7FFAC30164F0
        public void Read(){} // RVA: 0x7FFAC3016580
        public void Write(){} // RVA: 0x7FFAC3016DC0
        public void .ctor(){} // RVA: 0x7FFAC3017160
    }

    public class IKSolverCCD : IKSolverHeuristic
    {
        public IterationDelegate OnPreIteration; // 0x88

        // ── Methods ──
        public void FadeOutBoneWeights(){} // RVA: 0x7FFAC3017690
        public void OnInitiate(){} // RVA: 0x7FFAC3017730
        public void OnUpdate(){} // RVA: 0x7FFAC3017880
        public void Solve(){} // RVA: 0x7FFAC3017D80
        public void .ctor(){} // RVA: 0x7FFAC3018C30
    }

    public class IKSolverFABRIK : IKSolverHeuristic
    {
        public IterationDelegate boneLengthCanBeZero; // 0x88
        public bool[] limitedBones; // 0x90
        public UnityEngine.Vector3[] solverLocalPositions; // 0x98

        // ── Methods ──
        public void SolveForward(){} // RVA: 0x7FFAC3018C40
        public void SolveBackward(){} // RVA: 0x7FFAC3018CF0
        public void GetIKPosition(){} // RVA: 0x7FFAC3018DC0
        public void OnInitiate(){} // RVA: 0x7FFAC3018F20
        public void OnUpdate(){} // RVA: 0x7FFAC30196A0
        public void get_boneLengthCanBeZero(){} // RVA: 0x7FFAC2F21320
        public void SolveJoint(){} // RVA: 0x7FFAC3019B80
        public void OnPreSolve(){} // RVA: 0x7FFAC3019CD0
        public void OnPostSolve(){} // RVA: 0x7FFAC301A420
        public void Solve(){} // RVA: 0x7FFAC301A600
        public void ForwardReach(){} // RVA: 0x7FFAC301A700
        public void SolverMove(){} // RVA: 0x7FFAC301AA70
        public void SolverRotate(){} // RVA: 0x7FFAC301AB00
        public void SolverRotateChildren(){} // RVA: 0x7FFAC301AD00
        public void SolverMoveChildrenAroundPoint(){} // RVA: 0x7FFAC301AEE0
        public void GetParentSolverRotation(){} // RVA: 0x7FFAC301B1B0
        public void GetParentSolverPosition(){} // RVA: 0x7FFAC301B450
        public void GetLimitedRotation(){} // RVA: 0x7FFAC301B710
        public void LimitForward(){} // RVA: 0x7FFAC301BAD0
        public void BackwardReach(){} // RVA: 0x7FFAC301C1E0
        public void BackwardReachUnlimited(){} // RVA: 0x7FFAC301C220
        public void BackwardReachLimited(){} // RVA: 0x7FFAC301C470
        public void MapToSolverPositions(){} // RVA: 0x7FFAC301D180
        public void MapToSolverPositionsLimited(){} // RVA: 0x7FFAC301D350
        public void .ctor(){} // RVA: 0x7FFAC301D4F0
    }

    public class IKSolverFABRIKRoot : IKSolver
    {
        public int iterations; // 0x58
        public float rootPin; // 0x5C
        public RootMotion.FinalIK.FABRIKChain[] chains; // 0x60
        public bool zeroWeightApplied; // 0x68
        public bool[] isRoot; // 0x70
        public UnityEngine.Vector3 rootDefaultPosition; // 0x78

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC301D610
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC301DF90
        public void FixTransforms(){} // RVA: 0x7FFAC301E0A0
        public void OnInitiate(){} // RVA: 0x7FFAC301E1A0
        public void IsRoot(){} // RVA: 0x7FFAC301E3C0
        public void OnUpdate(){} // RVA: 0x7FFAC301E470
        public void GetPoints(){} // RVA: 0x7FFAC301E6E0
        public void GetPoint(){} // RVA: 0x7FFAC301E790
        public void AddPointsToArray(){} // RVA: 0x7FFAC301E830
        public void GetCentroid(){} // RVA: 0x7FFAC301E9F0
        public void .ctor(){} // RVA: 0x7FFAC301EDD0
    }

    public class IKSolverFullBody : IKSolver
    {
        public int iterations; // 0x58
        public RootMotion.FinalIK.FBIKChain[] chain; // 0x60
        public RootMotion.FinalIK.IKEffector[] effectors; // 0x68
        public RootMotion.FinalIK.IKMappingSpine spineMapping; // 0x70
        public RootMotion.FinalIK.IKMappingBone[] boneMappings; // 0x78
        public RootMotion.FinalIK.IKMappingLimb[] limbMappings; // 0x80
        public bool FABRIKPass; // 0x88
        public UpdateDelegate OnPreRead; // 0x90
        public UpdateDelegate OnPreSolve; // 0x98
        public IterationDelegate OnPreIteration; // 0xA0
        public IterationDelegate OnPostIteration; // 0xA8
        public UpdateDelegate OnPreBend; // 0xB0
        public UpdateDelegate OnPostSolve; // 0xB8
        public UpdateDelegate OnStoreDefaultLocalState; // 0xC0
        public UpdateDelegate OnFixTransforms; // 0xC8

        // ── Methods ──
        public void GetEffector(){} // RVA: 0x7FFAC301EE70
        public void GetChain(){} // RVA: 0x7FFAC301F010
        public void GetChainIndex(){} // RVA: 0x7FFAC301F060
        public void GetNode(){} // RVA: 0x7FFAC301F240
        public void GetChainAndNodeIndexes(){} // RVA: 0x7FFAC301F290
        public void GetPoints(){} // RVA: 0x7FFAC301F470
        public void GetPoint(){} // RVA: 0x7FFAC301F620
        public void IsValid(){} // RVA: 0x7FFAC301F820
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC301FB00
        public void FixTransforms(){} // RVA: 0x7FFAC301FD80
        public void OnInitiate(){} // RVA: 0x7FFAC301FFA0
        public void OnUpdate(){} // RVA: 0x7FFAC3020140
        public void ReadPose(){} // RVA: 0x7FFAC3020370
        public void Solve(){} // RVA: 0x7FFAC3020890
        public void ApplyBendConstraints(){} // RVA: 0x7FFAC3020C00
        public void WritePose(){} // RVA: 0x7FFAC3020C40
        public void .ctor(){} // RVA: 0x7FFAC3020D70
    }

    public class IKSolverFullBodyBiped : IKSolverFullBody
    {
        public UnityEngine.Transform bodyEffector; // 0xD0
        public float leftShoulderEffector; // 0xD8
        public float rightShoulderEffector; // 0xDC
        public float leftThighEffector; // 0xE0
        public UnityEngine.Vector3 rightThighEffector; // 0xE4
        public UnityEngine.Vector3 leftHandEffector; // 0xF0

        // ── Methods ──
        public void get_bodyEffector(){} // RVA: 0x7FFAC3021010
        public void get_leftShoulderEffector(){} // RVA: 0x7FFAC3021040
        public void get_rightShoulderEffector(){} // RVA: 0x7FFAC3021070
        public void get_leftThighEffector(){} // RVA: 0x7FFAC30210A0
        public void get_rightThighEffector(){} // RVA: 0x7FFAC30210D0
        public void get_leftHandEffector(){} // RVA: 0x7FFAC3021100
        public void get_rightHandEffector(){} // RVA: 0x7FFAC3021130
        public void get_leftFootEffector(){} // RVA: 0x7FFAC3021160
        public void get_rightFootEffector(){} // RVA: 0x7FFAC3021190
        public void get_leftArmChain(){} // RVA: 0x7FFAC30211C0
        public void get_rightArmChain(){} // RVA: 0x7FFAC30211F0
        public void get_leftLegChain(){} // RVA: 0x7FFAC3021220
        public void get_rightLegChain(){} // RVA: 0x7FFAC3021250
        public void get_leftArmMapping(){} // RVA: 0x7FFAC3021280
        public void get_rightArmMapping(){} // RVA: 0x7FFAC30212B0
        public void get_leftLegMapping(){} // RVA: 0x7FFAC30212E0
        public void get_rightLegMapping(){} // RVA: 0x7FFAC3021310
        public void get_headMapping(){} // RVA: 0x7FFAC3021340
        public void SetChainWeights(){} // RVA: 0x7FFAC3021370
        public void SetEffectorWeights(){} // RVA: 0x7FFAC30213E0
        public void GetChain(){} // RVA: 0x7FFAC3021530 | overloaded x2
        public void GetEffector(){} // RVA: 0x7FFAC3021620
        public void GetEndEffector(){} // RVA: 0x7FFAC3021780
        public void GetLimbMapping(){} // RVA: 0x7FFAC30218B0 | overloaded x2
        public void GetSpineMapping(){} // RVA: 0x7FFAC2FE9590
        public void GetHeadMapping(){} // RVA: 0x7FFAC3021340
        public void GetBendConstraint(){} // RVA: 0x7FFAC3021990
        public void IsValid(){} // RVA: 0x7FFAC3021A20
        public void SetToReferences(){} // RVA: 0x7FFAC3021D30
        public void DetectRootNodeBone(){} // RVA: 0x7FFAC3023DF0
        public void SetLimbOrientations(){} // RVA: 0x7FFAC30244C0
        public void get_pullBodyOffset(){} // RVA: 0x7FFAC2F8C260
        public void set_pullBodyOffset(){} // RVA: 0x7FFAC2F8C280
        public void SetLimbOrientation(){} // RVA: 0x7FFAC3024530
        public void GetLeftClavicle(){} // RVA: 0x7FFAC30247C0
        public void GetRightClavicle(){} // RVA: 0x7FFAC3024970
        public void Contains(){} // RVA: 0x7FFAC3024B20
        public void ReadPose(){} // RVA: 0x7FFAC3024C90
        public void PullBody(){} // RVA: 0x7FFAC3025100
        public void GetBodyOffset(){} // RVA: 0x7FFAC30252E0
        public void GetHandBodyPull(){} // RVA: 0x7FFAC30255C0
        public void ApplyBendConstraints(){} // RVA: 0x7FFAC3025800
        public void WritePose(){} // RVA: 0x7FFAC3025C60
        public void .ctor(){} // RVA: 0x7FFAC3025EB0
    }

    public class IKSolverHeuristic : IKSolver
    {
        public UnityEngine.Transform minBones; // 0x58
        public float boneLengthCanBeZero; // 0x60
        public int allowCommonParent; // 0x64
        public bool localDirection; // 0x68
        public bool positionOffset; // 0x69
        public Bone[] bones; // 0x70
        public UnityEngine.Vector3 lastLocalDirection; // 0x78
        public float chainLength; // 0x84

        // ── Methods ──
        public void SetChain(){} // RVA: 0x7FFAC3025ED0
        public void AddBone(){} // RVA: 0x7FFAC30260B0
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC3026280
        public void FixTransforms(){} // RVA: 0x7FFAC30263F0
        public void IsValid(){} // RVA: 0x7FFAC3026470
        public void GetPoints(){} // RVA: 0x7FFAC2FE9590
        public void GetPoint(){} // RVA: 0x7FFAC3026B10
        public void get_minBones(){} // RVA: 0x7FFAC3026CB0
        public void get_boneLengthCanBeZero(){} // RVA: 0x7FFAC3006850
        public void get_allowCommonParent(){} // RVA: 0x7FFAC2F21320
        public void OnInitiate(){} // RVA: 0x7FFAC2F21310
        public void OnUpdate(){} // RVA: 0x7FFAC2F21310
        public void InitiateBones(){} // RVA: 0x7FFAC3026CC0
        public void get_localDirection(){} // RVA: 0x7FFAC3027580
        public void get_positionOffset(){} // RVA: 0x7FFAC3027790
        public void GetSingularityOffset(){} // RVA: 0x7FFAC3027800
        public void SingularityDetected(){} // RVA: 0x7FFAC3027D70
        public void .ctor(){} // RVA: 0x7FFAC30280E0
    }

    public class IKSolverLeg : IKSolver
    {
        public float IKRotationWeight; // 0x58
        public UnityEngine.Quaternion IKRotation; // 0x5C
        public Point pelvis; // 0x70
        public Point thigh; // 0x78
        public Point calf; // 0x80
        public Point foot; // 0x88
        public Point toe; // 0x90
        public Leg leg; // 0x98
        public UnityEngine.Vector3 heelOffset; // 0xA0
        public UnityEngine.Vector3[] positions; // 0xB0
        public UnityEngine.Quaternion[] rotations; // 0xB8

        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFAC3028190
        public void SetChain(){} // RVA: 0x7FFAC3015940
        public void GetPoints(){} // RVA: 0x7FFAC3028880
        public void GetPoint(){} // RVA: 0x7FFAC3028A30
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC3016260
        public void FixTransforms(){} // RVA: 0x7FFAC30162C0
        public void OnInitiate(){} // RVA: 0x7FFAC3028F80
        public void OnUpdate(){} // RVA: 0x7FFAC30290A0
        public void Solve(){} // RVA: 0x7FFAC30291A0
        public void Read(){} // RVA: 0x7FFAC3029290
        public void Write(){} // RVA: 0x7FFAC3029AC0
        public void .ctor(){} // RVA: 0x7FFAC3029E60
    }

    public class IKSolverLimb : IKSolverTrigonometric
    {
        public 0x6B29C648 axisDirections; // 0xA8
        public 0x6B1C04E8 bendModifier; // 0xAC
        public float maintainRotationWeight; // 0xB0
        public float bendModifierWeight; // 0xB4
        public UnityEngine.Transform bendGoal; // 0xB8
        public bool maintainBendFor1Frame; // 0xC0
        public bool maintainRotationFor1Frame; // 0xC1
        public UnityEngine.Quaternion defaultRootRotation; // 0xC4
        public UnityEngine.Quaternion parentDefaultRotation; // 0xD4
        public UnityEngine.Quaternion bone3RotationBeforeSolve; // 0xE4
        public UnityEngine.Quaternion maintainRotation; // 0xF4
        public UnityEngine.Quaternion bone3DefaultRotation; // 0x104
        public UnityEngine.Vector3 _bendNormal; // 0x114
        public UnityEngine.Vector3 animationNormal; // 0x120
        public AxisDirection[] axisDirectionsLeft; // 0x130
        public AxisDirection[] axisDirectionsRight; // 0x138

        // ── Methods ──
        public void MaintainRotation(){} // RVA: 0x7FFAC302A390
        public void MaintainBend(){} // RVA: 0x7FFAC302A430
        public void OnInitiateVirtual(){} // RVA: 0x7FFAC302A480
        public void OnUpdateVirtual(){} // RVA: 0x7FFAC302ACF0
        public void OnPostSolveVirtual(){} // RVA: 0x7FFAC302AE50
        public void .ctor(){} // RVA: 0x7FFAC302B130 | overloaded x2
        public void get_axisDirections(){} // RVA: 0x7FFAC302B260
        public void StoreAxisDirections(){} // RVA: 0x7FFAC302B280
        public void GetModifiedBendNormal(){} // RVA: 0x7FFAC302B8D0
    }

    public class IKSolverLookAt : IKSolver
    {
        public UnityEngine.Transform spineIsValid; // 0x58
        public LookAtBone[] spineIsEmpty; // 0x60
        public LookAtBone headIsValid; // 0x68
        public LookAtBone[] headIsEmpty; // 0x70
        public float eyesIsValid; // 0x78
        public float eyesIsEmpty; // 0x7C
        public float eyesWeight; // 0x80
        public float clampWeight; // 0x84
        public float clampWeightHead; // 0x88
        public float clampWeightEyes; // 0x8C
        public int clampSmoothing; // 0x90
        public UnityEngine.AnimationCurve spineWeightCurve; // 0x98
        public UnityEngine.Vector3 spineTargetOffset; // 0xA0
        public UnityEngine.Vector3[] spineForwards; // 0xB0
        public UnityEngine.Vector3[] headForwards; // 0xB8
        public UnityEngine.Vector3[] eyeForward; // 0xC0

        // ── Methods ──
        public void SetLookAtWeight(){} // RVA: 0x7FFAC302D3A0 | overloaded x6
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC302D480
        public void FixTransforms(){} // RVA: 0x7FFAC302D640
        public void IsValid(){} // RVA: 0x7FFAC302D810
        public void GetPoints(){} // RVA: 0x7FFAC302DD70
        public void GetPoint(){} // RVA: 0x7FFAC302E190
        public void SetChain(){} // RVA: 0x7FFAC302E530
        public void OnInitiate(){} // RVA: 0x7FFAC302E630
        public void OnUpdate(){} // RVA: 0x7FFAC302ECC0
        public void get_spineIsValid(){} // RVA: 0x7FFAC302EE50
        public void get_spineIsEmpty(){} // RVA: 0x7FFAC302EFB0
        public void SolveSpine(){} // RVA: 0x7FFAC302EFD0
        public void get_headIsValid(){} // RVA: 0x7FFAC302F2E0
        public void get_headIsEmpty(){} // RVA: 0x7FFAC302F2F0
        public void SolveHead(){} // RVA: 0x7FFAC302F3D0
        public void get_eyesIsValid(){} // RVA: 0x7FFAC302F870
        public void get_eyesIsEmpty(){} // RVA: 0x7FFAC302F9D0
        public void SolveEyes(){} // RVA: 0x7FFAC302F9F0
        public void GetForwards(){} // RVA: 0x7FFAC30302E0
        public void SetBones(){} // RVA: 0x7FFAC30306E0
        public void .ctor(){} // RVA: 0x7FFAC3030930
    }

    public class IKSolverTrigonometric : IKSolver
    {
        public UnityEngine.Transform target; // 0x58
        public float IKRotationWeight; // 0x60
        public UnityEngine.Quaternion IKRotation; // 0x64
        public UnityEngine.Vector3 bendNormal; // 0x74
        public TrigonometricBone bone1; // 0x80
        public TrigonometricBone bone2; // 0x88
        public TrigonometricBone bone3; // 0x90
        public UnityEngine.Vector3 weightIKPosition; // 0x98
        public bool directHierarchy; // 0xA4

        // ── Methods ──
        public void SetBendGoalPosition(){} // RVA: 0x7FFAC3031790
        public void SetBendPlaneToCurrent(){} // RVA: 0x7FFAC3031AA0
        public void SetIKRotation(){} // RVA: 0x7FFAC3031DC0
        public void SetIKRotationWeight(){} // RVA: 0x7FFAC3031DD0
        public void GetIKRotation(){} // RVA: 0x7FFAC3031E00
        public void GetIKRotationWeight(){} // RVA: 0x7FFAC3031E10
        public void GetPoints(){} // RVA: 0x7FFAC3031E20
        public void GetPoint(){} // RVA: 0x7FFAC3031F50
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC30322A0
        public void FixTransforms(){} // RVA: 0x7FFAC30322F0
        public void IsValid(){} // RVA: 0x7FFAC3032350
        public void SetChain(){} // RVA: 0x7FFAC3032AD0
        public void Solve(){} // RVA: 0x7FFAC3032C30
        public void GetDirectionToBendPoint(){} // RVA: 0x7FFAC30338E0
        public void OnInitiate(){} // RVA: 0x7FFAC3033CC0
        public void IsDirectHierarchy(){} // RVA: 0x7FFAC3034040
        public void InitiateBones(){} // RVA: 0x7FFAC3034330
        public void OnUpdate(){} // RVA: 0x7FFAC30344E0
        public void OnInitiateVirtual(){} // RVA: 0x7FFAC2F21310
        public void OnUpdateVirtual(){} // RVA: 0x7FFAC2F21310
        public void OnPostSolveVirtual(){} // RVA: 0x7FFAC2F21310
        public void GetBendDirection(){} // RVA: 0x7FFAC3035450
        public void .ctor(){} // RVA: 0x7FFAC30359C0
    }

    public class IKSolverVR : IKSolver
    {
        public UnityEngine.Transform[] rootBone; // 0x58
        public bool hasChest; // 0x60
        public bool hasNeck; // 0x61
        public bool hasShoulders; // 0x62
        public bool hasToes; // 0x63
        public bool hasLegs; // 0x64
        public bool hasUpperChest; // 0x65
        public UnityEngine.Vector3[] readPositions; // 0x68
        public UnityEngine.Quaternion[] readRotations; // 0x70
        public UnityEngine.Vector3[] solvedPositions; // 0x78
        public UnityEngine.Quaternion[] solvedRotations; // 0x80
        public UnityEngine.Quaternion[] defaultLocalRotations; // 0x88
        public UnityEngine.Vector3[] defaultLocalPositions; // 0x90
        public UnityEngine.Vector3 rootV; // 0x98
        public UnityEngine.Vector3 rootVelocity; // 0xA4
        public UnityEngine.Vector3 bodyOffset; // 0xB0
        public int supportLegIndex; // 0xBC
        public int lastLOD; // 0xC0
        public int LOD; // 0xC4
        public bool plantFeet; // 0xC8
        public VirtualBone <rootBone>k__BackingField; // 0xD0
        public Spine spine; // 0xD8
        public Arm leftArm; // 0xE0
        public Arm rightArm; // 0xE8
        public Leg leftLeg; // 0xF0
        public Leg rightLeg; // 0xF8
        public Locomotion locomotion; // 0x100
        public Leg[] legs; // 0x108
        public Arm[] arms; // 0x110
        public UnityEngine.Vector3 headPosition; // 0x118
        public UnityEngine.Vector3 headDeltaPosition; // 0x124
        public UnityEngine.Vector3 raycastOriginPelvis; // 0x130
        public UnityEngine.Vector3 lastOffset; // 0x13C
        public UnityEngine.Vector3 debugPos1; // 0x148
        public UnityEngine.Vector3 debugPos2; // 0x154
        public UnityEngine.Vector3 debugPos3; // 0x160
        public UnityEngine.Vector3 debugPos4; // 0x16C
        public bool vrcLateSolve; // 0x178

        // ── Methods ──
        public void SetToReferences(){} // RVA: 0x7FFAC30364F0
        public void GuessHandOrientations(){} // RVA: 0x7FFAC3036C90
        public void DefaultAnimationCurves(){} // RVA: 0x7FFAC30370F0
        public void AddPositionOffset(){} // RVA: 0x7FFAC30374A0
        public void AddRotationOffset(){} // RVA: 0x7FFAC30377F0 | overloaded x2
        public void AddPlatformMotion(){} // RVA: 0x7FFAC3037BE0
        public void Reset(){} // RVA: 0x7FFAC3038020
        public void StoreDefaultLocalState(){} // RVA: 0x7FFAC3038350
        public void FixTransforms(){} // RVA: 0x7FFAC30385E0
        public void GetPoints(){} // RVA: 0x7FFAC30388E0
        public void GetPoint(){} // RVA: 0x7FFAC3038940
        public void IsValid(){} // RVA: 0x7FFAC30389A0
        public void GetNormal(){} // RVA: 0x7FFAC3038D50
        public void GuessWristToPalmAxis(){} // RVA: 0x7FFAC3039210
        public void GuessPalmToThumbAxis(){} // RVA: 0x7FFAC30395E0
        public void GetSineKeyframes(){} // RVA: 0x7FFAC3039F10
        public void UpdateSolverTransforms(){} // RVA: 0x7FFAC3039FA0
        public void OnInitiate(){} // RVA: 0x7FFAC303A220
        public void OnUpdate(){} // RVA: 0x7FFAC303A280
        public void WriteTransforms(){} // RVA: 0x7FFAC303AD10
        public void Read(){} // RVA: 0x7FFAC303B8D0
        public void Solve(){} // RVA: 0x7FFAC303C450
        public void GetPosition(){} // RVA: 0x7FFAC303E070
        public void GetRotation(){} // RVA: 0x7FFAC303E0C0
        public void get_rootBone(){} // RVA: 0x7FFAC303E100
        public void set_rootBone(){} // RVA: 0x7FFAC303E110
        public void VrcRead(){} // RVA: 0x7FFAC303A220
        public void VrcWrite(){} // RVA: 0x7FFAC303E170
        public void VrcWriteTransforms(){} // RVA: 0x7FFAC303E180
        public void VrcSyncIk(){} // RVA: 0x7FFAC303E190
        public void VrcLateSolve(){} // RVA: 0x7FFAC303E1B0
        public void Write(){} // RVA: 0x7FFAC303E210
        public void GetPelvisOffset(){} // RVA: 0x7FFAC303E3A0
        public void .ctor(){} // RVA: 0x7FFAC303EE80
    }

    public class Inertia : OffsetModifier
    {
        public Body[] bodies; // 0x38
        public OffsetLimits[] limits; // 0x40

        // ── Methods ──
        public void ResetBodies(){} // RVA: 0x7FFAC3091D60
        public void OnModifyOffset(){} // RVA: 0x7FFAC3091E00
        public void .ctor(){} // RVA: 0x7FFAC2F29920
    }

    public class InteractionEffector : Object
    {
        public 0x6B1C0330 effectorType; // 0x10
        public bool isPaused; // 0x14
        public RootMotion.FinalIK.InteractionObject interactionObject; // 0x18
        public RootMotion.FinalIK.Poser inInteraction; // 0x20
        public RootMotion.FinalIK.IKEffector progress; // 0x28
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
        public UnityEngine.Vector3 pickUpPosition; // 0x6C
        public UnityEngine.Vector3 pausePositionRelative; // 0x78
        public UnityEngine.Quaternion pickUpRotation; // 0x84
        public UnityEngine.Quaternion pauseRotationRelative; // 0x94
        public RootMotion.FinalIK.InteractionTarget interactionTarget; // 0xA8
        public UnityEngine.Transform target; // 0xB0
        public System.Collections.Generic.List`1<bool> triggered; // 0xB8
        public RootMotion.FinalIK.InteractionSystem interactionSystem; // 0xC0
        public bool started; // 0xC8

        // ── Methods ──
        public void get_effectorType(){} // RVA: 0x7FFAC2F6E5C0
        public void set_effectorType(){} // RVA: 0x7FFAC2F240C0
        public void get_isPaused(){} // RVA: 0x7FFAC3070BD0
        public void set_isPaused(){} // RVA: 0x7FFAC3070BE0
        public void get_interactionObject(){} // RVA: 0x7FFAC2F247C0
        public void set_interactionObject(){} // RVA: 0x7FFAC2F87E80
        public void get_inInteraction(){} // RVA: 0x7FFAC3070BF0
        public void .ctor(){} // RVA: 0x7FFAC3070CC0
        public void Initiate(){} // RVA: 0x7FFAC3070D90
        public void StoreDefaults(){} // RVA: 0x7FFAC3070F50
        public void ResetToDefaults(){} // RVA: 0x7FFAC3071140
        public void Pause(){} // RVA: 0x7FFAC3071600
        public void Resume(){} // RVA: 0x7FFAC3071960
        public void Start(){} // RVA: 0x7FFAC30719C0
        public void Update(){} // RVA: 0x7FFAC30723F0
        public void get_progress(){} // RVA: 0x7FFAC3073010
        public void TriggerUntriggeredEvents(){} // RVA: 0x7FFAC3073050
        public void PickUp(){} // RVA: 0x7FFAC3073370
        public void Stop(){} // RVA: 0x7FFAC3073740
        public void OnPostFBBIK(){} // RVA: 0x7FFAC3073B30
    }

    public class InteractionLookAt : Object
    {
        public RootMotion.FinalIK.LookAtIK ik; // 0x10
        public float lerpSpeed; // 0x18
        public float weightSpeed; // 0x1C
        public bool isPaused; // 0x20
        public UnityEngine.Transform lookAtTarget; // 0x28
        public float stopLookTime; // 0x30
        public float weight; // 0x34
        public bool firstFBBIKSolve; // 0x38

        // ── Methods ──
        public void Look(){} // RVA: 0x7FFAC3074120
        public void OnFixTransforms(){} // RVA: 0x7FFAC3074380
        public void Update(){} // RVA: 0x7FFAC3074480
        public void SolveSpine(){} // RVA: 0x7FFAC3074910
        public void SolveHead(){} // RVA: 0x7FFAC3074AA0
        public void .ctor(){} // RVA: 0x7FFAC3074BE0
    }

    public class InteractionObject : MonoBehaviour
    {
        public UnityEngine.Transform length; // 0x20
        public UnityEngine.Transform lastUsedInteractionSystem; // 0x28
        public UnityEngine.Transform lookAtTarget; // 0x30
        public WeightCurve[] targetsRoot; // 0x38
        public Multiplier[] multipliers; // 0x40
        public InteractionEvent[] events; // 0x48
        public float <length>k__BackingField; // 0x50
        public RootMotion.FinalIK.InteractionSystem <lastUsedInteractionSystem>k__BackingField; // 0x58
        public RootMotion.FinalIK.InteractionTarget[] targets; // 0x60

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial1(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial2(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial3(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial4(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void get_length(){} // RVA: 0x7FFAC2F89460
        public void set_length(){} // RVA: 0x7FFAC2F89470
        public void get_lastUsedInteractionSystem(){} // RVA: 0x7FFAC2FE9500
        public void set_lastUsedInteractionSystem(){} // RVA: 0x7FFAC2FE9510
        public void Initiate(){} // RVA: 0x7FFAC3074BF0
        public void get_lookAtTarget(){} // RVA: 0x7FFAC3074EB0
        public void GetTarget(){} // RVA: 0x7FFAC3076830 | overloaded x3
        public void CurveUsed(){} // RVA: 0x7FFAC30751C0
        public void GetTargets(){} // RVA: 0x7FFAC2FBF370
        public void OnStartInteraction(){} // RVA: 0x7FFAC2FE9510
        public void Apply(){} // RVA: 0x7FFAC3075F70 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFAC3075AC0
        public void get_targetsRoot(){} // RVA: 0x7FFAC3075E40
        public void Start(){} // RVA: 0x7FFAC3075F60
        public void GetWeightCurveIndex(){} // RVA: 0x7FFAC30768E0
        public void GetMultiplierIndex(){} // RVA: 0x7FFAC3076940
        public void .ctor(){} // RVA: 0x7FFAC30769A0
    }

    public class InteractionSystem : MonoBehaviour
    {
        public string inInteraction; // 0x20
        public float ik; // 0x28
        public float triggersInRange; // 0x2C
        public float resetToDefaultsSpeed; // 0x30
        public UnityEngine.Collider characterCollider; // 0x38
        public UnityEngine.Transform FPSCamera; // 0x40
        public UnityEngine.LayerMask camRaycastLayers; // 0x48
        public float camRaycastDistance; // 0x4C
        public System.Collections.Generic.List`1<RootMotion.FinalIK.InteractionTrigger> <triggersInRange>k__BackingField; // 0x50
        public System.Collections.Generic.List`1<RootMotion.FinalIK.InteractionTrigger> inContact; // 0x58
        public System.Collections.Generic.List`1<int> bestRangeIndexes; // 0x60
        public InteractionDelegate OnInteractionStart; // 0x68
        public InteractionDelegate OnInteractionPause; // 0x70
        public InteractionDelegate OnInteractionPickUp; // 0x78
        public InteractionDelegate OnInteractionResume; // 0x80
        public InteractionDelegate OnInteractionStop; // 0x88
        public InteractionEventDelegate OnInteractionEvent; // 0x90
        public UnityEngine.RaycastHit raycastHit; // 0x98
        public RootMotion.FinalIK.FullBodyBipedIK fullBody; // 0xC8
        public RootMotion.FinalIK.InteractionLookAt lookAt; // 0xD0
        public RootMotion.FinalIK.InteractionEffector[] interactionEffectors; // 0xD8
        public bool initiated; // 0xE0
        public UnityEngine.Collider lastCollider; // 0xE8
        public UnityEngine.Collider c; // 0xF0

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial1(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial2(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial3(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial4(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void get_inInteraction(){} // RVA: 0x7FFAC30773C0
        public void IsInInteraction(){} // RVA: 0x7FFAC3077480
        public void IsPaused(){} // RVA: 0x7FFAC3077620 | overloaded x2
        public void IsInSync(){} // RVA: 0x7FFAC30776E0
        public void StartInteraction(){} // RVA: 0x7FFAC3077810
        public void PauseInteraction(){} // RVA: 0x7FFAC3077980
        public void ResumeInteraction(){} // RVA: 0x7FFAC3077A10
        public void StopInteraction(){} // RVA: 0x7FFAC3077AA0
        public void PauseAll(){} // RVA: 0x7FFAC3077B30
        public void ResumeAll(){} // RVA: 0x7FFAC3077BB0
        public void StopAll(){} // RVA: 0x7FFAC3077C90
        public void GetInteractionObject(){} // RVA: 0x7FFAC3077D10
        public void GetProgress(){} // RVA: 0x7FFAC3077DA0
        public void GetMinActiveProgress(){} // RVA: 0x7FFAC3077E40
        public void TriggerInteraction(){} // RVA: 0x7FFAC3078400 | overloaded x3
        public void GetClosestInteractionRange(){} // RVA: 0x7FFAC30787A0
        public void GetClosestInteractionObjectInRange(){} // RVA: 0x7FFAC3078890
        public void GetClosestInteractionTargetInRange(){} // RVA: 0x7FFAC30788E0
        public void GetClosestInteractionObjectsInRange(){} // RVA: 0x7FFAC3078950
        public void GetClosestInteractionTargetsInRange(){} // RVA: 0x7FFAC3078AE0
        public void TriggerEffectorsReady(){} // RVA: 0x7FFAC3078C90
        public void GetTriggerRange(){} // RVA: 0x7FFAC3078FE0
        public void GetClosestTriggerIndex(){} // RVA: 0x7FFAC3079160
        public void get_ik(){} // RVA: 0x7FFAC3079460
        public void set_ik(){} // RVA: 0x7FFAC3079470
        public void get_triggersInRange(){} // RVA: 0x7FFAC2FC20E0
        public void set_triggersInRange(){} // RVA: 0x7FFAC30794D0
        public void Start(){} // RVA: 0x7FFAC3079530
        public void InteractionPause(){} // RVA: 0x7FFAC307A030
        public void InteractionResume(){} // RVA: 0x7FFAC307A050
        public void InteractionStop(){} // RVA: 0x7FFAC307A050
        public void LookAtInteraction(){} // RVA: 0x7FFAC307A070
        public void OnTriggerEnter(){} // RVA: 0x7FFAC307A210
        public void OnTriggerExit(){} // RVA: 0x7FFAC307A440
        public void ContactIsInRange(){} // RVA: 0x7FFAC307A610
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAC307A8A0
        public void Update(){} // RVA: 0x7FFAC307AB60
        public void Raycasting(){} // RVA: 0x7FFAC307AEE0
        public void UpdateTriggerEventBroadcasting(){} // RVA: 0x7FFAC307B150
        public void UpdateEffectors(){} // RVA: 0x7FFAC307B8D0
        public void OnPreFBBIK(){} // RVA: 0x7FFAC307BAD0
        public void OnPostFBBIK(){} // RVA: 0x7FFAC307BD40
        public void OnFixTransforms(){} // RVA: 0x7FFAC307BFB0
        public void OnDestroy(){} // RVA: 0x7FFAC307C0C0
        public void IsValid(){} // RVA: 0x7FFAC307C8B0
        public void TriggerIndexIsValid(){} // RVA: 0x7FFAC307CA40
        public void .ctor(){} // RVA: 0x7FFAC307CC20
    }

    public class InteractionTarget : MonoBehaviour
    {
        public 0x6B1C0330 effectorType; // 0x20
        public Multiplier[] multipliers; // 0x28
        public float interactionSpeedMlp; // 0x30
        public UnityEngine.Transform pivot; // 0x38
        public UnityEngine.Vector3 twistAxis; // 0x40
        public float twistWeight; // 0x4C
        public float swingWeight; // 0x50
        public bool rotateOnce; // 0x54
        public UnityEngine.Quaternion defaultLocalRotation; // 0x58
        public UnityEngine.Transform lastPivot; // 0x68

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial1(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial2(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial3(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial4(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetValue(){} // RVA: 0x7FFAC307D590
        public void ResetRotation(){} // RVA: 0x7FFAC307D600
        public void RotateTo(){} // RVA: 0x7FFAC307D730
        public void .ctor(){} // RVA: 0x7FFAC307E540
    }

    public class InteractionTrigger : MonoBehaviour
    {
        public Range[] ranges; // 0x20

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OpenTutorial4(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void Start(){} // RVA: 0x7FFAC2F21310
        public void GetBestRangeIndex(){} // RVA: 0x7FFAC307E5E0
        public void .ctor(){} // RVA: 0x7FFAC307E900
    }

    public class LegIK : IK
    {
        public RootMotion.FinalIK.IKSolverLeg solver; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC2FF0B20
    }

    public class LimbIK : IK
    {
        public RootMotion.FinalIK.IKSolverLimb solver; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC2FF0C00
    }

    public class LookAtController : MonoBehaviour
    {
        public RootMotion.FinalIK.LookAtIK pivot; // 0x20
        public UnityEngine.Transform target; // 0x28
        public float weight; // 0x30
        public UnityEngine.Vector3 offset; // 0x34
        public float targetSwitchSmoothTime; // 0x40
        public float weightSmoothTime; // 0x44
        public bool smoothTurnTowardsTarget; // 0x48
        public float maxRadiansDelta; // 0x4C
        public float maxMagnitudeDelta; // 0x50
        public float slerpSpeed; // 0x54
        public UnityEngine.Vector3 pivotOffsetFromRoot; // 0x58
        public float minDistance; // 0x64
        public float maxRootAngle; // 0x68
        public UnityEngine.Transform lastTarget; // 0x70
        public float switchWeight; // 0x78
        public float switchWeightV; // 0x7C
        public float weightV; // 0x80
        public UnityEngine.Vector3 lastPosition; // 0x84
        public UnityEngine.Vector3 dir; // 0x90
        public bool lastSmoothTowardsTarget; // 0x9C

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC3092790
        public void LateUpdate(){} // RVA: 0x7FFAC3092850
        public void get_pivot(){} // RVA: 0x7FFAC3093470
        public void ApplyMinDistance(){} // RVA: 0x7FFAC3093800
        public void RootRotation(){} // RVA: 0x7FFAC30939C0
        public void .ctor(){} // RVA: 0x7FFAC3094070
    }

    public class LookAtIK : IK
    {
        public RootMotion.FinalIK.IKSolverLookAt solver; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC2FF0CE0
    }

    public class OffsetModifier : MonoBehaviour
    {
        public float deltaTime; // 0x20
        public RootMotion.FinalIK.FullBodyBipedIK ik; // 0x28
        public float lastTime; // 0x30

        // ── Methods ──
        public void get_deltaTime(){} // RVA: 0x7FFAC3094140
        public void OnModifyOffset(){} // RVA: 0x7FFAC2C70980
        public void Start(){} // RVA: 0x7FFAC30941A0
        public void Initiate(){} // RVA: 0x7FFAC3094250
        public void ModifyOffset(){} // RVA: 0x7FFAC30942F0
        public void ApplyLimits(){} // RVA: 0x7FFAC30944C0
        public void OnDestroy(){} // RVA: 0x7FFAC3094630
        public void .ctor(){} // RVA: 0x7FFAC2F29920
    }

    public class OffsetModifierVRIK : MonoBehaviour
    {
        public float deltaTime; // 0x20
        public RootMotion.FinalIK.VRIK ik; // 0x28
        public float lastTime; // 0x30

        // ── Methods ──
        public void get_deltaTime(){} // RVA: 0x7FFAC3094140
        public void OnModifyOffset(){} // RVA: 0x7FFAC2C70980
        public void Start(){} // RVA: 0x7FFAC30950E0
        public void Initiate(){} // RVA: 0x7FFAC3095190
        public void ModifyOffset(){} // RVA: 0x7FFAC3095230
        public void OnDestroy(){} // RVA: 0x7FFAC3095400
        public void .ctor(){} // RVA: 0x7FFAC2F29920
    }

    public class OffsetPose : MonoBehaviour
    {
        public EffectorLink[] effectorLinks; // 0x20

        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFAC3095A60 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC3095B20
    }

    public class PenetrationAvoidance : OffsetModifier
    {
        public Avoider[] avoiders; // 0x38

        // ── Methods ──
        public void OnModifyOffset(){} // RVA: 0x7FFAC3096190
        public void .ctor(){} // RVA: 0x7FFAC2F29920
    }

    public class Poser : SolverManager
    {
        public UnityEngine.Transform poseRoot; // 0x40
        public float weight; // 0x48
        public float localRotationWeight; // 0x4C
        public float localPositionWeight; // 0x50
        public bool initiated; // 0x54

        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x7FFAC2C70980
        public void UpdateManual(){} // RVA: 0x7FFAC30821C0
        public void InitiatePoser(){} // RVA: 0x7FFAC2C70980
        public void UpdatePoser(){} // RVA: 0x7FFAC2C70980
        public void FixPoserTransforms(){} // RVA: 0x7FFAC2C70980
        public void UpdateSolver(){} // RVA: 0x7FFAC30821E0
        public void InitiateSolver(){} // RVA: 0x7FFAC3082230
        public void FixTransforms(){} // RVA: 0x7FFAC3082260
        public void .ctor(){} // RVA: 0x7FFAC3080D50
    }

    public class RagdollUtility : MonoBehaviour
    {
        public RootMotion.FinalIK.IK isRagdoll; // 0x20
        public float ikUsed; // 0x28
        public bool applyIkOnRagdoll; // 0x2C
        public float applyVelocity; // 0x30
        public float applyAngularVelocity; // 0x34
        public UnityEngine.Animator animator; // 0x38
        public Rigidbone[] rigidbones; // 0x40
        public Child[] children; // 0x48
        public bool enableRagdollFlag; // 0x50
        public 0x6B29C8B0 animatorUpdateMode; // 0x54
        public RootMotion.FinalIK.IK[] allIKComponents; // 0x58
        public bool[] fixTransforms; // 0x60
        public float ragdollWeight; // 0x68
        public float ragdollWeightV; // 0x6C
        public bool fixedFrame; // 0x70
        public bool[] disabledIKComponents; // 0x78

        // ── Methods ──
        public void EnableRagdoll(){} // RVA: 0x7FFAC3082280
        public void DisableRagdoll(){} // RVA: 0x7FFAC30822E0
        public void Start(){} // RVA: 0x7FFAC30823F0
        public void DisableRagdollSmooth(){} // RVA: 0x7FFAC3082E90
        public void Update(){} // RVA: 0x7FFAC3082F30
        public void FixedUpdate(){} // RVA: 0x7FFAC3083240
        public void LateUpdate(){} // RVA: 0x7FFAC3083280
        public void AfterLastIK(){} // RVA: 0x7FFAC30833C0
        public void AfterAnimation(){} // RVA: 0x7FFAC3083410
        public void OnFinalPose(){} // RVA: 0x7FFAC3083450
        public void RagdollEnabler(){} // RVA: 0x7FFAC3083490
        public void get_isRagdoll(){} // RVA: 0x7FFAC3083800
        public void RecordVelocities(){} // RVA: 0x7FFAC30838F0
        public void get_ikUsed(){} // RVA: 0x7FFAC3083BD0
        public void StoreLocalState(){} // RVA: 0x7FFAC3083E00
        public void FixTransforms(){} // RVA: 0x7FFAC3083F50
        public void OnDestroy(){} // RVA: 0x7FFAC3084310
        public void .ctor(){} // RVA: 0x7FFAC3084520
    }

    public class Recoil : OffsetModifier
    {
        public RootMotion.FinalIK.AimIK isFinished; // 0x38
        public bool primaryHandEffector; // 0x40
        public 0x6B1C23D8 secondaryHandEffector; // 0x44
        public bool primaryHand; // 0x48
        public UnityEngine.AnimationCurve secondaryHand; // 0x50
        public float magnitudeRandom; // 0x58
        public UnityEngine.Vector3 rotationRandom; // 0x5C
        public UnityEngine.Vector3 handRotationOffset; // 0x68
        public float blendTime; // 0x74
        public RecoilOffset[] offsets; // 0x78
        public UnityEngine.Quaternion rotationOffset; // 0x80
        public float magnitudeMlp; // 0x90
        public float endTime; // 0x94
        public UnityEngine.Quaternion handRotation; // 0x98
        public UnityEngine.Quaternion secondaryHandRelativeRotation; // 0xA8
        public UnityEngine.Quaternion randomRotation; // 0xB8
        public float length; // 0xC8
        public bool initiated; // 0xCC
        public float blendWeight; // 0xD0
        public float w; // 0xD4
        public UnityEngine.Quaternion primaryHandRotation; // 0xD8
        public bool handRotationsSet; // 0xE8
        public UnityEngine.Vector3 aimIKAxis; // 0xEC

        // ── Methods ──
        public void get_isFinished(){} // RVA: 0x7FFAC3096B60
        public void SetHandRotations(){} // RVA: 0x7FFAC3096BC0
        public void Fire(){} // RVA: 0x7FFAC3096BF0
        public void OnModifyOffset(){} // RVA: 0x7FFAC3096F50
        public void AfterFBBIK(){} // RVA: 0x7FFAC30985D0
        public void AfterAimIK(){} // RVA: 0x7FFAC3098930
        public void get_primaryHandEffector(){} // RVA: 0x7FFAC3098980
        public void get_secondaryHandEffector(){} // RVA: 0x7FFAC30989F0
        public void get_primaryHand(){} // RVA: 0x7FFAC3098A60
        public void get_secondaryHand(){} // RVA: 0x7FFAC3098A80
        public void OnDestroy(){} // RVA: 0x7FFAC3098AA0
        public void .ctor(){} // RVA: 0x7FFAC3098E10
    }

    public class RotationLimit : MonoBehaviour
    {
        public UnityEngine.Vector3 secondaryAxis; // 0x20
        public UnityEngine.Quaternion crossAxis; // 0x2C
        public bool defaultLocalRotationOverride; // 0x3C
        public bool initiated; // 0x3D
        public bool applicationQuit; // 0x3E
        public bool defaultLocalRotationSet; // 0x3F

        // ── Methods ──
        public void SetDefaultLocalRotation(){} // RVA: 0x7FFAC3085E10 | overloaded x2
        public void GetLimitedLocalRotation(){} // RVA: 0x7FFAC3085E20
        public void Apply(){} // RVA: 0x7FFAC30861F0
        public void Disable(){} // RVA: 0x7FFAC30863A0
        public void get_secondaryAxis(){} // RVA: 0x7FFAC3086440
        public void get_crossAxis(){} // RVA: 0x7FFAC3086460
        public void get_defaultLocalRotationOverride(){} // RVA: 0x7FFAC30864E0
        public void set_defaultLocalRotationOverride(){} // RVA: 0x7FFAC30864F0
        public void LimitRotation(){}
        public void Awake(){} // RVA: 0x7FFAC3086500
        public void LateUpdate(){} // RVA: 0x7FFAC30866C0
        public void LogWarning(){} // RVA: 0x7FFAC2FD66F0
        public void Limit1DOF(){} // RVA: 0x7FFAC30866D0
        public void LimitTwist(){} // RVA: 0x7FFAC3086A20
        public void GetOrthogonalAngle(){} // RVA: 0x7FFAC3087030
        public void .ctor(){} // RVA: 0x7FFAC3087110
    }

    public class RotationLimitAngle : RotationLimit
    {
        public float limit; // 0x40
        public float twistLimit; // 0x44

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void LimitRotation(){} // RVA: 0x7FFAC30871A0
        public void LimitSwing(){} // RVA: 0x7FFAC3087250
        public void .ctor(){} // RVA: 0x7FFAC30876D0
    }

    public class RotationLimitHinge : RotationLimit
    {
        public bool useLimits; // 0x40
        public float min; // 0x44
        public float max; // 0x48
        public float zeroAxisDisplayOffset; // 0x4C
        public UnityEngine.Quaternion lastRotation; // 0x50
        public float lastAngle; // 0x60

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void LimitRotation(){} // RVA: 0x7FFAC30876F0
        public void LimitHinge(){} // RVA: 0x7FFAC3087740
        public void .ctor(){} // RVA: 0x7FFAC3087C20
    }

    public class RotationLimitPolygonal : RotationLimit
    {
        public float twistLimit; // 0x40
        public int smoothIterations; // 0x44
        public LimitPoint[] points; // 0x48
        public UnityEngine.Vector3[] P; // 0x50
        public ReachCone[] reachCones; // 0x58

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void SetLimitPoints(){} // RVA: 0x7FFAC3087C80
        public void LimitRotation(){} // RVA: 0x7FFAC3087D40
        public void Start(){} // RVA: 0x7FFAC3087E20
        public void ResetToDefault(){} // RVA: 0x7FFAC3088040
        public void BuildReachCones(){} // RVA: 0x7FFAC3088E60
        public void SmoothPoints(){} // RVA: 0x7FFAC3089620
        public void GetScalar(){} // RVA: 0x7FFAC3089D50
        public void PointToTangentPlane(){} // RVA: 0x7FFAC3089DA0
        public void TangentPointToSphere(){} // RVA: 0x7FFAC3089E90
        public void LimitSwing(){} // RVA: 0x7FFAC3089FB0
        public void GetReachCone(){} // RVA: 0x7FFAC308A5C0
        public void .ctor(){} // RVA: 0x7FFAC308A720
    }

    public class RotationLimitSpline : RotationLimit
    {
        public float twistLimit; // 0x40
        public UnityEngine.AnimationCurve spline; // 0x48

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void SetSpline(){} // RVA: 0x7FFAC308AE20
        public void LimitRotation(){} // RVA: 0x7FFAC308AE90
        public void LimitSwing(){} // RVA: 0x7FFAC308AF40
        public void .ctor(){} // RVA: 0x7FFAC308B570
    }

    public class ShoulderRotator : MonoBehaviour
    {
        public float weight; // 0x20
        public float offset; // 0x24
        public RootMotion.FinalIK.FullBodyBipedIK ik; // 0x28
        public bool skip; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC3099490
        public void RotateShoulders(){} // RVA: 0x7FFAC3099660
        public void RotateShoulder(){} // RVA: 0x7FFAC30997C0
        public void GetParentBoneMap(){} // RVA: 0x7FFAC3099E90
        public void OnDestroy(){} // RVA: 0x7FFAC3099FC0
        public void .ctor(){} // RVA: 0x7FFAC309A1C0
    }

    public class TrigonometricIK : IK
    {
        public RootMotion.FinalIK.IKSolverTrigonometric solver; // 0x40

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void SupportGroup(){} // RVA: 0x7FFAC2F21310
        public void ASThread(){} // RVA: 0x7FFAC2F21310
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9E740
        public void .ctor(){} // RVA: 0x7FFAC2FF0DC0
    }

    public class TwistRelaxer : MonoBehaviour
    {
        public RootMotion.FinalIK.IK ik; // 0x20
        public UnityEngine.Transform parent; // 0x28
        public UnityEngine.Transform child; // 0x30
        public float weight; // 0x38
        public float parentChildCrossfade; // 0x3C
        public float twistAngleOffset; // 0x40
        public UnityEngine.Vector3 twistAxis; // 0x44
        public UnityEngine.Vector3 axis; // 0x50
        public UnityEngine.Vector3 axisRelativeToParentDefault; // 0x5C
        public UnityEngine.Vector3 axisRelativeToChildDefault; // 0x68
        public bool _inited; // 0x74

        // ── Methods ──
        public void Relax(){} // RVA: 0x7FFAC306EA40
        public void Init(){} // RVA: 0x7FFAC306FBA0
        public void Start(){} // RVA: 0x7FFAC306FBB0
        public void OnPostUpdate(){} // RVA: 0x7FFAC3070720
        public void LateUpdate(){} // RVA: 0x7FFAC3070800
        public void OnDestroy(){} // RVA: 0x7FFAC30708E0
        public void .ctor(){} // RVA: 0x7FFAC3070AF0
    }

    public class VRIK : IK
    {
        public References references; // 0x40
        public RootMotion.FinalIK.IKSolverVR solver; // 0x48
        public bool _isVRCAvatarMainIK; // 0x50

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7FFAC2F21310
        public void OpenScriptReference(){} // RVA: 0x7FFAC2F21310
        public void OpenSetupTutorial(){} // RVA: 0x7FFAC2F21310
        public void AutoDetectReferences(){} // RVA: 0x7FFAC2FF0EA0
        public void GuessHandOrientations(){} // RVA: 0x7FFAC2FF0F00
        public void GetIKSolver(){} // RVA: 0x7FFAC2F9C730
        public void InternalInitiateSolver(){} // RVA: 0x7FFAC2FF0F30
        public void InitiateSolver(){} // RVA: 0x7FFAC2FF1010
        public void VRCSetAvatarMainIK(){} // RVA: 0x7FFAC2FDB8F0
        public void VRCInitiateSolver(){} // RVA: 0x7FFAC2FF1020
        public void UpdateSolver(){} // RVA: 0x7FFAC2FF1030
        public void .ctor(){} // RVA: 0x7FFAC2FF1330
    }

    public class VRIKCalibrator : Object
    {
        // ── Methods ──
        public void RecalibrateScale(){} // RVA: 0x7FFAC309A220
        public void Calibrate(){} // RVA: 0x7FFAC309E160 | overloaded x2
        public void CalibrateLeg(){} // RVA: 0x7FFAC309F370 | overloaded x2
    }

    public class VRIKLODController : MonoBehaviour
    {
        public UnityEngine.Renderer LODRenderer; // 0x20
        public float LODDistance; // 0x28
        public bool allowCulled; // 0x2C
        public RootMotion.FinalIK.VRIK ik; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC309FCA0
        public void Update(){} // RVA: 0x7FFAC309FD30
        public void GetLODLevel(){} // RVA: 0x7FFAC309FD70
        public void .ctor(){} // RVA: 0x7FFAC30A00B0
    }

    public class VRIKRootController : MonoBehaviour
    {
        public UnityEngine.Vector3 pelvisTargetRight; // 0x20
        public UnityEngine.Transform pelvisTarget; // 0x30
        public UnityEngine.Transform leftFootTarget; // 0x38
        public UnityEngine.Transform rightFootTarget; // 0x40
        public RootMotion.FinalIK.VRIK ik; // 0x48

        // ── Methods ──
        public void get_pelvisTargetRight(){} // RVA: 0x7FFAC2F87EE0
        public void set_pelvisTargetRight(){} // RVA: 0x7FFAC2F87F00
        public void Awake(){} // RVA: 0x7FFAC30A0100
        public void Calibrate(){} // RVA: 0x7FFAC30A07A0 | overloaded x2
        public void OnPreUpdate(){} // RVA: 0x7FFAC30A0B60
        public void OnDestroy(){} // RVA: 0x7FFAC30A1700
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}