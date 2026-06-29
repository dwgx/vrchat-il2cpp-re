// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.RootMotion.FinalIK
// Classes: 7
// Methods: 23

namespace ThirdParty.Other.RootMotion.FinalIK
{
    public class CCDIK : IK
    {
        // ── Methods ──
        public void OpenUserManual(){} // RVA: 0x7A80D7310
        public void OpenScriptReference(){} // RVA: 0x7A80D7310
        public void SupportGroup(){} // RVA: 0x7A80D7310
        public void ASThread(){} // RVA: 0x7A80D7310
        public void GetIKSolver(){} // RVA: 0x7A8154D80
        public void .ctor(){} // RVA: 0x7A81A5BF0
    }

    public class Constraint : Object
    {
        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7A818DF00
        public void UpdateConstraint(){} // RVA: 0x7A7E18770
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ConstraintPosition : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7A818DFD0
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class ConstraintPositionOffset : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7A818E140
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_positionChanged(){} // RVA: 0x7A818E560
    }

    public class ConstraintRotation : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7A818E630
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class ConstraintRotationOffset : Constraint
    {
        // ── Methods ──
        public void UpdateConstraint(){} // RVA: 0x7A818E7B0
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_rotationChanged(){} // RVA: 0x7A818EC00
    }

    public class Constraints : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7A818ECD0
        public void Initiate(){} // RVA: 0x7A818EDA0
        public void Update(){} // RVA: 0x7A818EF00
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}