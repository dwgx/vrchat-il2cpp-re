// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 7
// Methods: 23

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class CCDIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0xB43310
        public void OpenScriptReference(){} // RVA: 0xB43310
        public void SupportGroup(){} // RVA: 0xB43310
        public void ASThread(){} // RVA: 0xB43310
        public void GetIKSolver(){} // RVA: 0xBC1B30
        public void .ctor(){} // RVA: 0xC15DD0
    }

    public class Constraint : Object
    {
        // ── Methods ──
        public void get_isValid(){} // RVA: 0xBFB9C0
        public void UpdateConstraint(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ConstraintPosition : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0xBFBA90
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class ConstraintPositionOffset : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0xBFBC80
        public void .ctor(){} // RVA: 0xB44D60
        public void get_positionChanged(){} // RVA: 0xBFC280
    }

    public class ConstraintRotation : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0xBFC390
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class ConstraintRotationOffset : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0xBFC590
        public void .ctor(){} // RVA: 0xB44D60
        public void get_rotationChanged(){} // RVA: 0xBFCBB0
    }

    public class Constraints : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0xBFCCC0
        public void Initiate(){} // RVA: 0xBFCD90
        public void Update(){} // RVA: 0xBFCED0
        public void .ctor(){} // RVA: 0xB43310
    }

}