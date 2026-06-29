// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 8
// Methods: 110

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class GenericPoser : Poser
    {
        public object maps;

        // ── Methods ──
        public void AutoMapping(){} // RVA: 0xCABC10
        public void InitiatePoser(){} // RVA: 0xCAC0C0
        public void UpdatePoser(){} // RVA: 0xCAC0D0
        public void FixPoserTransforms(){} // RVA: 0xCAC260
        public void StoreDefaultState(){} // RVA: 0xCAC440
        public void GetTargetNamed(){} // RVA: 0xCAC630
        public void .ctor(){} // RVA: 0xCAC6F0
    }

    public class Grounder : MonoBehaviour
    {
        public object weight;
        public object solver;
        public object OnPreGrounder;
        public object OnPostGrounder;
        public object _initiated;

        // ── Methods ──
        public void ResetPosition(){} // RVA: 0x894290
        public void get_initiated(){} // RVA: 0xC02470
        public void set_initiated(){} // RVA: 0xC02480
        public void GetSpineOffsetTarget(){} // RVA: 0xC02490
        public void LogWarning(){} // RVA: 0xBFAD40
        public void GetLegSpineBendVector(){} // RVA: 0xC025E0
        public void GetLegSpineTangent(){} // RVA: 0xC02870
        public void OpenUserManual(){} // RVA: 0x894290
        public void OpenScriptReference(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0xC02BA0
    }

    public class GrounderBipedIK : Grounder
    {
        public object ik;
        public object spineBend;
        public object spineSpeed;
        public object feet;
        public object footRotations;
        public object animatedPelvisLocalPosition;
        public object solvedPelvisLocalPosition;
        public object spineOffset;
        public object lastWeight;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void ResetPosition(){} // RVA: 0xC02CC0
        public void IsReadyToInitiate(){} // RVA: 0xC02D30
        public void Update(){} // RVA: 0xC02E50
        public void Initiate(){} // RVA: 0xC02FA0
        public void OnDisable(){} // RVA: 0xC03560
        public void OnSolverUpdate(){} // RVA: 0xC035C0
        public void SetLegIK(){} // RVA: 0xC04370
        public void OnPostSolverUpdate(){} // RVA: 0xC044D0
        public void OnDestroy(){} // RVA: 0xC04960
        public void .ctor(){} // RVA: 0xC04CA0
    }

    public class GrounderFBBIK : Grounder
    {
        public object ik;
        public object spineBend;
        public object spineSpeed;
        public object spine;
        public object feet;
        public object spineOffset;
        public object firstSolve;

        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0xB43310
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void ResetPosition(){} // RVA: 0xC04DD0
        public void IsReadyToInitiate(){} // RVA: 0xC04E40
        public void Update(){} // RVA: 0xC04F40
        public void FixedUpdate(){} // RVA: 0xC05080
        public void LateUpdate(){} // RVA: 0xC05080
        public void Initiate(){} // RVA: 0xC05090
        public void OnSolverUpdate(){} // RVA: 0xC05440
        public void SetLegIK(){} // RVA: 0xC05A40
        public void OnDrawGizmosSelected(){} // RVA: 0xC05EC0
        public void OnDestroy(){} // RVA: 0xC06210
        public void .ctor(){} // RVA: 0xC06410
    }

    public class GrounderIK : Grounder
    {
        public object legs;
        public object pelvis;
        public object characterRoot;
        public object rootRotationWeight;
        public object rootRotationSpeed;
        public object maxRootRotationAngle;
        public object feet;
        public object footRotations;
        public object animatedPelvisLocalPosition;
        public object solvedPelvisLocalPosition;
        public object solvedFeet;
        public object solved;
        public object lastWeight;
        public object characterRootRigidbody;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void ResetPosition(){} // RVA: 0xC06550
        public void IsReadyToInitiate(){} // RVA: 0xC06570
        public void OnDisable(){} // RVA: 0xC06870
        public void Update(){} // RVA: 0xC06A00
        public void Initiate(){} // RVA: 0xC073A0
        public void OnSolverUpdate(){} // RVA: 0xC07D50
        public void SetLegIK(){} // RVA: 0xC08400
        public void OnPostSolverUpdate(){} // RVA: 0xC089D0
        public void OnDestroy(){} // RVA: 0xC08E80
        public void .ctor(){} // RVA: 0xC09170
    }

    public class GrounderQuadruped : Grounder
    {
        public object forelegSolver;
        public object rootRotationWeight;
        public object minRootRotation;
        public object maxRootRotation;
        public object rootRotationSpeed;
        public object maxLegOffset;
        public object maxForeLegOffset;
        public object maintainHeadRotationWeight;
        public object characterRoot;
        public object pelvis;
        public object lastSpineBone;
        public object head;
        public object legs;
        public object forelegs;
        public object gravity;
        public object feet;
        public object animatedPelvisLocalPosition;
        public object animatedPelvisLocalRotation;
        public object animatedHeadLocalRotation;
        public object solvedPelvisLocalPosition;
        public object solvedPelvisLocalRotation;
        public object solvedHeadLocalRotation;
        public object solvedFeet;
        public object solved;
        public object angle;
        public object forefeetRoot;
        public object headRotation;
        public object lastWeight;
        public object characterRootRigidbody;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void ResetPosition(){} // RVA: 0xC09290
        public void IsReadyToInitiate(){} // RVA: 0xC092D0
        public void IsReadyToInitiateLegs(){} // RVA: 0xC09550
        public void OnDisable(){} // RVA: 0xC097B0
        public void Update(){} // RVA: 0xC09830
        public void Initiate(){} // RVA: 0xC098A0
        public void InitiateFeet(){} // RVA: 0xC0A080
        public void LateUpdate(){} // RVA: 0xC0A750
        public void RootRotation(){} // RVA: 0xC0A860
        public void OnSolverUpdate(){} // RVA: 0xC0B3D0
        public void UpdateForefeetRoot(){} // RVA: 0xC0C8E0
        public void SetFootIK(){} // RVA: 0xC0D020
        public void OnPostSolverUpdate(){} // RVA: 0xC0D280
        public void OnDestroy(){} // RVA: 0xC0DB40
        public void DestroyLegs(){} // RVA: 0xC0DB80
        public void .ctor(){} // RVA: 0xC0DE60
    }

    public class GrounderVRIK : Grounder
    {
        public object ik;
        public object feet;

        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0xB43310
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void ResetPosition(){} // RVA: 0xC06550
        public void IsReadyToInitiate(){} // RVA: 0xC0E4A0
        public void Update(){} // RVA: 0xC0E5A0
        public void Initiate(){} // RVA: 0xC0E6D0
        public void OnSolverUpdate(){} // RVA: 0xC0EAB0
        public void SetLegIK(){} // RVA: 0xC0F080
        public void OnPostSolverUpdate(){} // RVA: 0xC0F1E0
        public void OnDrawGizmosSelected(){} // RVA: 0xC0F8B0
        public void OnDestroy(){} // RVA: 0xC0FC00
        public void .ctor(){} // RVA: 0xC0FF30
    }

    public class Grounding : Object
    {
        public object layers;
        public object maxStep;
        public object heightOffset;
        public object footSpeed;
        public object footRadius;
        public object footCenterOffset;
        public object prediction;
        public object footRotationWeight;
        public object footRotationSpeed;
        public object maxFootRotationAngle;
        public object rotateSolver;
        public object pelvisSpeed;
        public object pelvisDamper;
        public object lowerPelvisWeight;
        public object liftPelvisWeight;
        public object rootSphereCastRadius;
        public object overstepFallsDown;
        public object quality;
        public object _legs;
        public object _pelvis;
        public object _isGrounded;
        public object _root;
        public object _rootHit;
        public object initiated;

        // ── Methods ──
        public void get_legs(){} // RVA: 0xC0FFC0
        public void set_legs(){} // RVA: 0xC0FFD0
        public void get_pelvis(){} // RVA: 0xBE2C60
        public void set_pelvis(){} // RVA: 0xBE2C70
        public void get_isGrounded(){} // RVA: 0xC10030
        public void set_isGrounded(){} // RVA: 0xC10040
        public void get_root(){} // RVA: 0xC10050
        public void set_root(){} // RVA: 0xC10060
        public void get_rootHit(){} // RVA: 0xC100C0
        public void set_rootHit(){} // RVA: 0xC100F0
        public void get_rootGrounded(){} // RVA: 0xC10120
        public void GetRootHit(){} // RVA: 0xC10140
        public void IsValid(){} // RVA: 0xC107C0
        public void Initiate(){} // RVA: 0xC10A20
        public void Update(){} // RVA: 0xC10FE0
        public void GetLegsPlaneNormal(){} // RVA: 0xC11280
        public void Reset(){} // RVA: 0xC11800
        public void LogWarning(){} // RVA: 0xC11A60
        public void get_up(){} // RVA: 0xC11A80
        public void GetVerticalOffset(){} // RVA: 0xC11B10
        public void Flatten(){} // RVA: 0xC11D50
        public void get_useRootRotation(){} // RVA: 0xC11E90
        public void GetFootCenterOffset(){} // RVA: 0xC11F60
        public void .ctor(){} // RVA: 0xC12040
    }

}