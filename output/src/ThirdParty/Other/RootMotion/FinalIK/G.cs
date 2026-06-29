// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 8
// Methods: 111

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class GenericPoser : Poser
    {
        // ── Methods ──
        public void AutoMapping(){} // RVA: 0x7A8237440
        public void InitiatePoser(){} // RVA: 0x7A82379D0
        public void UpdatePoser(){} // RVA: 0x7A82379E0
        public void FixPoserTransforms(){} // RVA: 0x7A8237B70
        public void StoreDefaultState(){} // RVA: 0x7A8237CE0
        public void GetTargetNamed(){} // RVA: 0x7A8237E50
        public void .ctor(){} // RVA: 0x7A8237F10
    }

    public class Grounder : MonoBehaviour
    {
        // ── Methods ──
        public void ResetPosition(){} // RVA: 0x7A7E18770
        public void get_initiated(){} // RVA: 0x7A8193790
        public void set_initiated(){} // RVA: 0x7A81937A0
        public void GetSpineOffsetTarget(){} // RVA: 0x7A81937B0
        public void LogWarning(){} // RVA: 0x7A818D240
        public void GetLegSpineBendVector(){} // RVA: 0x7A8193900
        public void GetLegSpineTangent(){} // RVA: 0x7A8193B50
        public void OpenUserManual(){} // RVA: 0x7A7E18770
        public void OpenScriptReference(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A8193E00
    }

    public class GrounderBipedIK : Grounder
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void ResetPosition(){} // RVA: 0x7A8193F20
        public void IsReadyToInitiate(){} // RVA: 0x7A8193F90
        public void Update(){} // RVA: 0x7A81940B0
        public void Initiate(){} // RVA: 0x7A8194200
        public void OnDisable(){} // RVA: 0x7A8194790
        public void OnSolverUpdate(){} // RVA: 0x7A81947F0
        public void SetLegIK(){} // RVA: 0x7A81952D0
        public void OnPostSolverUpdate(){} // RVA: 0x7A81953F0
        public void OnDestroy(){} // RVA: 0x7A8195840
        public void .ctor(){} // RVA: 0x7A8195B80
    }

    public class GrounderFBBIK : Grounder
    {
        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0x7A80D7310
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void ResetPosition(){} // RVA: 0x7A8195CB0
        public void IsReadyToInitiate(){} // RVA: 0x7A8195D20
        public void Update(){} // RVA: 0x7A8195E20
        public void FixedUpdate(){} // RVA: 0x7A8195F60
        public void LateUpdate(){} // RVA: 0x7A8195F60
        public void Initiate(){} // RVA: 0x7A8195F70
        public void OnSolverUpdate(){} // RVA: 0x7A8196320
        public void SetLegIK(){} // RVA: 0x7A81968E0
        public void OnDrawGizmosSelected(){} // RVA: 0x7A8196CB0
        public void OnDestroy(){} // RVA: 0x7A8197000
        public void .ctor(){} // RVA: 0x7A8197200
    }

    public class GrounderIK : Grounder
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void ResetPosition(){} // RVA: 0x7A8197340
        public void IsReadyToInitiate(){} // RVA: 0x7A8197360
        public void OnDisable(){} // RVA: 0x7A8197650
        public void Update(){} // RVA: 0x7A81977E0
        public void Initiate(){} // RVA: 0x7A8198210
        public void OnSolverUpdate(){} // RVA: 0x7A8198B40
        public void SetLegIK(){} // RVA: 0x7A8199090
        public void OnPostSolverUpdate(){} // RVA: 0x7A8199630
        public void OnDestroy(){} // RVA: 0x7A8199A90
        public void .ctor(){} // RVA: 0x7A8199D80
    }

    public class GrounderQuadruped : Grounder
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void ResetPosition(){} // RVA: 0x7A8199EA0
        public void IsReadyToInitiate(){} // RVA: 0x7A8199EE0
        public void IsReadyToInitiateLegs(){} // RVA: 0x7A819A160
        public void OnDisable(){} // RVA: 0x7A819A3B0
        public void Update(){} // RVA: 0x7A819A430
        public void Initiate(){} // RVA: 0x7A819A4A0
        public void InitiateFeet(){} // RVA: 0x7A819AC30
        public void LateUpdate(){} // RVA: 0x7A819B300
        public void RootRotation(){} // RVA: 0x7A819B410
        public void OnSolverUpdate(){} // RVA: 0x7A819BE90
        public void UpdateForefeetRoot(){} // RVA: 0x7A819CF80
        public void SetFootIK(){} // RVA: 0x7A819D4E0
        public void OnPostSolverUpdate(){} // RVA: 0x7A819D6D0
        public void OnDestroy(){} // RVA: 0x7A819DE60
        public void DestroyLegs(){} // RVA: 0x7A819DEA0
        public void .ctor(){} // RVA: 0x7A819E180
    }

    public class GrounderVRIK : Grounder
    {
        // ── Methods ──
        public void OpenTutorial(){} // RVA: 0x7A80D7310
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void ResetPosition(){} // RVA: 0x7A8197340
        public void IsReadyToInitiate(){} // RVA: 0x7A819E780
        public void Update(){} // RVA: 0x7A819E880
        public void Initiate(){} // RVA: 0x7A819E9B0
        public void OnSolverUpdate(){} // RVA: 0x7A819ED90
        public void SetLegIK(){} // RVA: 0x7A819F230
        public void OnPostSolverUpdate(){} // RVA: 0x7A819F360
        public void OnDrawGizmosSelected(){} // RVA: 0x7A819F940
        public void OnDestroy(){} // RVA: 0x7A819FC90
        public void .ctor(){} // RVA: 0x7A819FFC0
    }

    public class Grounding : Object
    {
        // ── Methods ──
        public void get_legs(){} // RVA: 0x7A81A0050
        public void set_legs(){} // RVA: 0x7A81A0060
        public void get_pelvis(){} // RVA: 0x7A8175DF0
        public void set_pelvis(){} // RVA: 0x7A8175E00
        public void get_isGrounded(){} // RVA: 0x7A81A00C0
        public void set_isGrounded(){} // RVA: 0x7A81A00D0
        public void get_root(){} // RVA: 0x7A81A00E0
        public void set_root(){} // RVA: 0x7A81A00F0
        public void get_rootHit(){} // RVA: 0x7A81A0150
        public void set_rootHit(){} // RVA: 0x7A81A0180
        public void get_rootGrounded(){} // RVA: 0x7A81A01B0
        public void GetRootHit(){} // RVA: 0x7A81A01D0
        public void IsValid(){} // RVA: 0x7A81A0800
        public void Initiate(){} // RVA: 0x7A81A0A60
        public void Update(){} // RVA: 0x7A81A1030
        public void GetLegsPlaneNormal(){} // RVA: 0x7A81A12D0
        public void Reset(){} // RVA: 0x7A81A1800
        public void LogWarning(){} // RVA: 0x7A81A1BF0
        public void get_up(){} // RVA: 0x7A81A1C10
        public void GetVerticalOffset(){} // RVA: 0x7A81A1CA0
        public void Flatten(){} // RVA: 0x7A81A1EB0
        public void get_useRootRotation(){} // RVA: 0x7A81A1FF0
        public void GetFootCenterOffset(){} // RVA: 0x7A81A20C0
        public void .ctor(){} // RVA: 0x7A81A21A0
        public void layers(){} // RVA: 0x7B3FA7CD8
    }

}