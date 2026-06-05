// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics.ManagedTypes
// Classes: 7
// Methods: 74

namespace VRC.Dynamics.ManagedTypes
{
    public class VRCAimConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAF2FC9240
        public void get_RotationMode(){} // RVA: 0x7FFAF2E92CB0
        public void get_ScaleMode(){} // RVA: 0x7FFAF2FC9240
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFAFA179E80
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAFA179EA0
        public void DetermineUpVector(){} // RVA: 0x7FFAFA179FC0
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7FFAFA17A7F0
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7FFAFA17A900
        public void ReOrientateForwardLook(){} // RVA: 0x7FFAFA17AA10
        public void FromToRotation(){} // RVA: 0x7FFAFA17AEB0
        public void AffectsAnyAxis(){} // RVA: 0x7FFAFA17B240
        public void .ctor(){} // RVA: 0x7FFAFA17B260
        public void <FromToRotation>g__Approximately|20_0(){} // RVA: 0x7FFAFA17B360
    }

    public class VRCLookAtConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAF2FC9240
        public void get_RotationMode(){} // RVA: 0x7FFAF34E08B0
        public void get_ScaleMode(){} // RVA: 0x7FFAF2FC9240
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFAFA17B380
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAFA17B390
        public void DetermineUpVector(){} // RVA: 0x7FFAFA17B410
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7FFAFA17BA50
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7FFAFA17BAA0
        public void ReOrientateForwardLook(){} // RVA: 0x7FFAFA17BB60
        public void AffectsAnyAxis(){} // RVA: 0x7FFAF2E72850
        public void .ctor(){} // RVA: 0x7FFAFA17BD60
    }

    public class VRCParentConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAF2E92CB0
        public void get_RotationMode(){} // RVA: 0x7FFAF2E7FAF0
        public void get_ScaleMode(){} // RVA: 0x7FFAF2FC9240
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAFA17BD70
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x7FFAFA17BE30
        public void ApplyZeroOffset(){} // RVA: 0x7FFAFA17BE80
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAFA17BFC0
        public void AffectsAnyAxis(){} // RVA: 0x7FFAFA17BFF0
        public void .ctor(){} // RVA: 0x7FFAFA17C030
    }

    public class VRCPositionConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAF2E7FAF0
        public void get_RotationMode(){} // RVA: 0x7FFAF2FC9240
        public void get_ScaleMode(){} // RVA: 0x7FFAF2FC9240
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAFA17C130
        public void ApplyZeroOffset(){} // RVA: 0x7FFAFA17C1C0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAFA17C220
        public void AffectsAnyAxis(){} // RVA: 0x7FFAFA17C320
        public void .ctor(){} // RVA: 0x7FFAFA17C340
    }

    public class VRCRotationConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAF2FC9240
        public void get_RotationMode(){} // RVA: 0x7FFAF2E7FAF0
        public void get_ScaleMode(){} // RVA: 0x7FFAF2FC9240
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAFA17C430
        public void ApplyZeroOffset(){} // RVA: 0x7FFAFA17C1C0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAFA17C4C0
        public void AffectsAnyAxis(){} // RVA: 0x7FFAFA17C320
        public void .ctor(){} // RVA: 0x7FFAFA17C5E0
    }

    public class VRCScaleConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAF2FC9240
        public void get_RotationMode(){} // RVA: 0x7FFAF2FC9240
        public void get_ScaleMode(){} // RVA: 0x7FFAF2E7FAF0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAFA17C6D0
        public void ApplyZeroOffset(){} // RVA: 0x7FFAFA17C770
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAFA17C7D0
        public void AffectsAnyAxis(){} // RVA: 0x7FFAFA17C320
        public void .ctor(){} // RVA: 0x7FFAFA17C8D0
    }

    public class VRCWorldUpConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAF2FC9240
        public void get_ScaleMode(){} // RVA: 0x7FFAF2FC9240
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFAF2D8D320
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAFA17C9C0
        public void IsDependentOnTransform(){} // RVA: 0x7FFAFA17CA60
        public void RecalculateTransformCount(){} // RVA: 0x7FFAFA17CCB0
        public void GetTransforms(){} // RVA: 0x7FFAFA17CF90
        public void GetManagedWorldUpTransform(){} // RVA: 0x7FFAFA17D150
        public void RequiresReallocation(){} // RVA: 0x7FFAFA17D190
        public void ApplyZeroOffset(){} // RVA: 0x7FFAFA17C1C0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAFA17D320
        public void GenerateForwardLook(){} // RVA: 0x7FFAFA17D350
        public void DetermineUpVector(){}
        public void ForwardLookShouldApplyIdentity(){}
        public void ForwardLookHandleZeroUp(){}
        public void ReOrientateForwardLook(){}
        public void .ctor(){} // RVA: 0x7FFAFA17D6A0
    }

}