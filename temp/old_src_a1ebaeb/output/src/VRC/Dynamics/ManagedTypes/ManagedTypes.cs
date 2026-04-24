// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics.ManagedTypes
// Classes: 7
// Methods: 74

namespace VRC.Dynamics.ManagedTypes
{
    public class VRCAimConstraintBase : VRCWorldUpConstraintBase
    {
        public object AffectsRotationZ; // 0x335A12A0
        public object WorldUp; // 0x335A12A0
        public object `;

        // ── Original Methods ──
        public void get_PositionMode(){} // RVA: 0x7ffaa8f22da0
        public void get_RotationMode(){} // RVA: 0x7ffaa8a37cb0
        public void get_ScaleMode(){} // RVA: 0x7ffaa8f22da0
        public void get_UsesWorldUpTransform(){} // RVA: 0x7ffaaf8785e0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7ffaaf878600
        public void DetermineUpVector(){} // RVA: 0x7ffaaf878720
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7ffaaf878f50
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7ffaaf879060
        public void ReOrientateForwardLook(){} // RVA: 0x7ffaaf879170
        public void FromToRotation(){} // RVA: 0x7ffaaf879610
        public void AffectsAnyAxis(){} // RVA: 0x7ffaaf8799a0
        public void .ctor(){} // RVA: 0x7ffaaf8799c0
        public void <FromToRotation>g__Approximately|20_0(){} // RVA: 0x7ffaaf879ac0
    }

    public class VRCLookAtConstraintBase : VRCWorldUpConstraintBase
    {
        // ── Original Methods ──
        public void get_PositionMode(){} // RVA: 0x7ffaa8f22da0
        public void get_RotationMode(){} // RVA: 0x7ffaa9099760
        public void get_ScaleMode(){} // RVA: 0x7ffaa8f22da0
        public void get_UsesWorldUpTransform(){} // RVA: 0x7ffaaf879ae0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7ffaaf879af0
        public void DetermineUpVector(){} // RVA: 0x7ffaaf879b70
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7ffaaf87a1b0
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7ffaaf87a200
        public void ReOrientateForwardLook(){} // RVA: 0x7ffaaf87a2c0
        public void AffectsAnyAxis(){} // RVA: 0x7ffaa8a17850
        public void .ctor(){} // RVA: 0x7ffaaf87a4c0
    }

    public class VRCParentConstraintBase : VRCConstraintBase
    {
        public object AffectsPositionY; // 0x3343F440
        public object AffectsRotationX; // 0x3343F440

        // ── Original Methods ──
        public void get_PositionMode(){} // RVA: 0x7ffaa8a37cb0
        public void get_RotationMode(){} // RVA: 0x7ffaa8a24af0
        public void get_ScaleMode(){} // RVA: 0x7ffaa8f22da0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7ffaaf87a4d0
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x7ffaaf87a590
        public void ApplyZeroOffset(){} // RVA: 0x7ffaaf87a5e0
        public void AcceptOffsetBaker(){} // RVA: 0x7ffaaf87a720
        public void AffectsAnyAxis(){} // RVA: 0x7ffaaf87a750
        public void .ctor(){} // RVA: 0x7ffaaf87a790
    }

    public class VRCPositionConstraintBase : VRCConstraintBase
    {
        public object AffectsPositionX; // 0x3351A700

        // ── Original Methods ──
        public void get_PositionMode(){} // RVA: 0x7ffaa8a24af0
        public void get_RotationMode(){} // RVA: 0x7ffaa8f22da0
        public void get_ScaleMode(){} // RVA: 0x7ffaa8f22da0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7ffaaf87a890
        public void ApplyZeroOffset(){} // RVA: 0x7ffaaf87a920
        public void AcceptOffsetBaker(){} // RVA: 0x7ffaaf87a980
        public void AffectsAnyAxis(){} // RVA: 0x7ffaaf87aa80
        public void .ctor(){} // RVA: 0x7ffaaf87aaa0
    }

    public class VRCRotationConstraintBase : VRCConstraintBase
    {
        public object AffectsRotationX; // 0x3399EE40

        // ── Original Methods ──
        public void get_PositionMode(){} // RVA: 0x7ffaa8f22da0
        public void get_RotationMode(){} // RVA: 0x7ffaa8a24af0
        public void get_ScaleMode(){} // RVA: 0x7ffaa8f22da0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7ffaaf87ab90
        public void ApplyZeroOffset(){} // RVA: 0x7ffaaf87a920
        public void AcceptOffsetBaker(){} // RVA: 0x7ffaaf87ac20
        public void AffectsAnyAxis(){} // RVA: 0x7ffaaf87aa80
        public void .ctor(){} // RVA: 0x7ffaaf87ad40
    }

    public class VRCScaleConstraintBase : VRCConstraintBase
    {
        public object AffectsScaleX; // 0x33917120

        // ── Original Methods ──
        public void get_PositionMode(){} // RVA: 0x7ffaa8f22da0
        public void get_RotationMode(){} // RVA: 0x7ffaa8f22da0
        public void get_ScaleMode(){} // RVA: 0x7ffaa8a24af0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7ffaaf87ae30
        public void ApplyZeroOffset(){} // RVA: 0x7ffaaf87aed0
        public void AcceptOffsetBaker(){} // RVA: 0x7ffaaf87af30
        public void AffectsAnyAxis(){} // RVA: 0x7ffaaf87aa80
        public void .ctor(){} // RVA: 0x7ffaaf87b030
    }

    public class VRCWorldUpConstraintBase : VRCConstraintBase
    {
        public object WorldUpTransform; // 0x33612740

        // ── Original Methods ──
        public void get_PositionMode(){} // RVA: 0x7ffaa8f22da0
        public void get_ScaleMode(){} // RVA: 0x7ffaa8f22da0
        public void get_UsesWorldUpTransform(){} // RVA: 0x7ffaa8932320
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7ffaaf87b120
        public void IsDependentOnTransform(){} // RVA: 0x7ffaaf87b1c0
        public void RecalculateTransformCount(){} // RVA: 0x7ffaaf87b410
        public void RequiresReallocation(){} // RVA: 0x7ffaaf87b8f0
        public void ApplyZeroOffset(){} // RVA: 0x7ffaaf87a920
        public void AcceptOffsetBaker(){} // RVA: 0x7ffaaf87ba80
        public void GenerateForwardLook(){} // RVA: 0x7ffaaf87bab0
        public void DetermineUpVector(){}
        public void ForwardLookShouldApplyIdentity(){}
        public void ForwardLookHandleZeroUp(){}
        public void ReOrientateForwardLook(){}
        public void .ctor(){} // RVA: 0x7ffaaf87be00
        // ── Binary Analysis Named ──
        public void GetTransforms(){} // RVA: 0x7ffaaf87b6f0
        public void GetManagedWorldUpTransform(){} // RVA: 0x7ffaaf87b8b0
    }

}