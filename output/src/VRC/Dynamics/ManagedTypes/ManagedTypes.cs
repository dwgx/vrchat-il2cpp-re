// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics.ManagedTypes
// Classes: 7
// Methods: 74

namespace VRC.Dynamics.ManagedTypes
{
    public class VRCAimConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x519240
        public void get_RotationMode(){} // RVA: 0x3E2CB0
        public void get_ScaleMode(){} // RVA: 0x519240
        public void get_UsesWorldUpTransform(){} // RVA: 0x76C9E80
        public void UpdateTypeSpecificJobData(){} // RVA: 0x76C9EA0
        public void DetermineUpVector(){} // RVA: 0x76C9FC0
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x76CA7F0
        public void ForwardLookHandleZeroUp(){} // RVA: 0x76CA900
        public void ReOrientateForwardLook(){} // RVA: 0x76CAA10
        public void FromToRotation(){} // RVA: 0x76CAEB0
        public void AffectsAnyAxis(){} // RVA: 0x76CB240
        public void .ctor(){} // RVA: 0x76CB260
        public void <FromToRotation>g__Approximately|20_0(){} // RVA: 0x76CB360
    }

    public class VRCLookAtConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x519240
        public void get_RotationMode(){} // RVA: 0xA308B0
        public void get_ScaleMode(){} // RVA: 0x519240
        public void get_UsesWorldUpTransform(){} // RVA: 0x76CB380
        public void UpdateTypeSpecificJobData(){} // RVA: 0x76CB390
        public void DetermineUpVector(){} // RVA: 0x76CB410
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x76CBA50
        public void ForwardLookHandleZeroUp(){} // RVA: 0x76CBAA0
        public void ReOrientateForwardLook(){} // RVA: 0x76CBB60
        public void AffectsAnyAxis(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x76CBD60
    }

    public class VRCParentConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x3E2CB0
        public void get_RotationMode(){} // RVA: 0x3CFAF0
        public void get_ScaleMode(){} // RVA: 0x519240
        public void UpdateTypeSpecificJobData(){} // RVA: 0x76CBD70
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x76CBE30
        public void ApplyZeroOffset(){} // RVA: 0x76CBE80
        public void AcceptOffsetBaker(){} // RVA: 0x76CBFC0
        public void AffectsAnyAxis(){} // RVA: 0x76CBFF0
        public void .ctor(){} // RVA: 0x76CC030
    }

    public class VRCPositionConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x3CFAF0
        public void get_RotationMode(){} // RVA: 0x519240
        public void get_ScaleMode(){} // RVA: 0x519240
        public void UpdateTypeSpecificJobData(){} // RVA: 0x76CC130
        public void ApplyZeroOffset(){} // RVA: 0x76CC1C0
        public void AcceptOffsetBaker(){} // RVA: 0x76CC220
        public void AffectsAnyAxis(){} // RVA: 0x76CC320
        public void .ctor(){} // RVA: 0x76CC340
    }

    public class VRCRotationConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x519240
        public void get_RotationMode(){} // RVA: 0x3CFAF0
        public void get_ScaleMode(){} // RVA: 0x519240
        public void UpdateTypeSpecificJobData(){} // RVA: 0x76CC430
        public void ApplyZeroOffset(){} // RVA: 0x76CC1C0
        public void AcceptOffsetBaker(){} // RVA: 0x76CC4C0
        public void AffectsAnyAxis(){} // RVA: 0x76CC320
        public void .ctor(){} // RVA: 0x76CC5E0
    }

    public class VRCScaleConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x519240
        public void get_RotationMode(){} // RVA: 0x519240
        public void get_ScaleMode(){} // RVA: 0x3CFAF0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x76CC6D0
        public void ApplyZeroOffset(){} // RVA: 0x76CC770
        public void AcceptOffsetBaker(){} // RVA: 0x76CC7D0
        public void AffectsAnyAxis(){} // RVA: 0x76CC320
        public void .ctor(){} // RVA: 0x76CC8D0
    }

    public class VRCWorldUpConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x519240
        public void get_ScaleMode(){} // RVA: 0x519240
        public void get_UsesWorldUpTransform(){} // RVA: 0x2DD320
        public void UpdateTypeSpecificJobData(){} // RVA: 0x76CC9C0
        public void IsDependentOnTransform(){} // RVA: 0x76CCA60
        public void RecalculateTransformCount(){} // RVA: 0x76CCCB0
        public void GetTransforms(){} // RVA: 0x76CCF90
        public void GetManagedWorldUpTransform(){} // RVA: 0x76CD150
        public void RequiresReallocation(){} // RVA: 0x76CD190
        public void ApplyZeroOffset(){} // RVA: 0x76CC1C0
        public void AcceptOffsetBaker(){} // RVA: 0x76CD320
        public void GenerateForwardLook(){} // RVA: 0x76CD350
        public void DetermineUpVector(){}
        public void ForwardLookShouldApplyIdentity(){}
        public void ForwardLookHandleZeroUp(){}
        public void ReOrientateForwardLook(){}
        public void .ctor(){} // RVA: 0x76CD6A0
    }

}