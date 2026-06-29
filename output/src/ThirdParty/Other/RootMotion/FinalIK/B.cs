// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 3
// Methods: 32

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class BipedIK : SolverManager
    {
        public object references;
        public object solvers;

        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void GetIKPositionWeight(){} // RVA: 0xBF9DB0
        public void GetIKRotationWeight(){} // RVA: 0xBF9DE0
        public void SetIKPositionWeight(){} // RVA: 0xBF9E10
        public void SetIKRotationWeight(){} // RVA: 0xBF9E70
        public void SetIKPosition(){} // RVA: 0xBF9ED0
        public void SetIKRotation(){} // RVA: 0xBF9F10
        public void GetIKPosition(){} // RVA: 0xBF9F40
        public void GetIKRotation(){} // RVA: 0xBF9FA0
        public void SetLookAtWeight(){} // RVA: 0xBF9FE0
        public void SetLookAtPosition(){} // RVA: 0xBFA0F0
        public void SetSpinePosition(){} // RVA: 0xBFA120
        public void SetSpineWeight(){} // RVA: 0xBFA150
        public void GetGoalIK(){} // RVA: 0xBFA1A0
        public void InitiateBipedIK(){} // RVA: 0xBFA210
        public void UpdateBipedIK(){} // RVA: 0xBFA230
        public void SetToDefaults(){} // RVA: 0xBFA250
        public void FixTransforms(){} // RVA: 0xBFA400
        public void InitiateSolver(){} // RVA: 0xBFA4E0
        public void UpdateSolver(){} // RVA: 0xBFA8B0
        public void LogWarning(){} // RVA: 0xBFAD40
        public void .ctor(){} // RVA: 0xBFAD70
    }

    public class BipedIKSolvers : Object
    {
        public object leftFoot;
        public object rightFoot;
        public object leftHand;
        public object rightHand;
        public object spine;
        public object lookAt;
        public object aim;
        public object pelvis;
        public object _limbs;
        public object _ikSolvers;

        // ── Methods ──
        public void get_limbs(){} // RVA: 0xBFAEF0
        public void get_ikSolvers(){} // RVA: 0xBFB0C0
        public void AssignReferences(){} // RVA: 0xBFB350
        public void .ctor(){} // RVA: 0xBFB5C0
    }

    public class BodyTilt : OffsetModifier
    {
        public object tiltSpeed;
        public object tiltSensitivity;
        public object poseLeft;
        public object poseRight;
        public object tiltAngle;
        public object lastForward;

        // ── Methods ──
        public void Start(){} // RVA: 0xCBA110
        public void OnModifyOffset(){} // RVA: 0xCBA1F0
        public void .ctor(){} // RVA: 0xCBA520
    }

}