// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics.ManagedTypes
// Classes: 7
// Methods: 74

namespace VRC.Dynamics.ManagedTypes
{
    public class VRCAimConstraintBase : VRCWorldUpConstraintBase
    {
        public object PositionMode;
        public object RotationMode;
        public object ScaleMode;
        public object UsesWorldUpTransform;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFD4E919180
        public void get_RotationMode(){} // RVA: 0x7FFD4E446CB0
        public void get_ScaleMode(){} // RVA: 0x7FFD4E919180
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFD55275BC0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFD55275BE0
        public void DetermineUpVector(){} // RVA: 0x7FFD55275D00
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7FFD55276530
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7FFD55276640
        public void ReOrientateForwardLook(){} // RVA: 0x7FFD55276750
        public void FromToRotation(){} // RVA: 0x7FFD55276BF0
        public void AffectsAnyAxis(){} // RVA: 0x7FFD55276F80
        public void .ctor(){} // RVA: 0x7FFD55276FA0
        public void <FromToRotation>g__Approximately|20_0(){} // RVA: 0x7FFD552770A0
    }

    public class VRCLookAtConstraintBase : VRCWorldUpConstraintBase
    {
        public object PositionMode;
        public object RotationMode;
        public object ScaleMode;
        public object UsesWorldUpTransform;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFD4E919180
        public void get_RotationMode(){} // RVA: 0x7FFD4EA8FE20
        public void get_ScaleMode(){} // RVA: 0x7FFD4E919180
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFD552770C0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFD552770D0
        public void DetermineUpVector(){} // RVA: 0x7FFD55277150
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7FFD55277790
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7FFD552777E0
        public void ReOrientateForwardLook(){} // RVA: 0x7FFD552778A0
        public void AffectsAnyAxis(){} // RVA: 0x7FFD4E426850
        public void .ctor(){} // RVA: 0x7FFD55277AA0
    }

    public class VRCParentConstraintBase : VRCConstraintBase
    {
        public object PositionMode;
        public object RotationMode;
        public object ScaleMode;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFD4E446CB0
        public void get_RotationMode(){} // RVA: 0x7FFD4E433AF0
        public void get_ScaleMode(){} // RVA: 0x7FFD4E919180
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFD55277AB0
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x7FFD55277B70
        public void ApplyZeroOffset(){} // RVA: 0x7FFD55277BC0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFD55277D00
        public void AffectsAnyAxis(){} // RVA: 0x7FFD55277D30
        public void .ctor(){} // RVA: 0x7FFD55277D70
    }

    public class VRCPositionConstraintBase : VRCConstraintBase
    {
        public object PositionMode;
        public object RotationMode;
        public object ScaleMode;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFD4E433AF0
        public void get_RotationMode(){} // RVA: 0x7FFD4E919180
        public void get_ScaleMode(){} // RVA: 0x7FFD4E919180
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFD55277E70
        public void ApplyZeroOffset(){} // RVA: 0x7FFD55277F00
        public void AcceptOffsetBaker(){} // RVA: 0x7FFD55277F60
        public void AffectsAnyAxis(){} // RVA: 0x7FFD55278060
        public void .ctor(){} // RVA: 0x7FFD55278080
    }

    public class VRCRotationConstraintBase : VRCConstraintBase
    {
        public object PositionMode;
        public object RotationMode;
        public object ScaleMode;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFD4E919180
        public void get_RotationMode(){} // RVA: 0x7FFD4E433AF0
        public void get_ScaleMode(){} // RVA: 0x7FFD4E919180
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFD55278170
        public void ApplyZeroOffset(){} // RVA: 0x7FFD55277F00
        public void AcceptOffsetBaker(){} // RVA: 0x7FFD55278200
        public void AffectsAnyAxis(){} // RVA: 0x7FFD55278060
        public void .ctor(){} // RVA: 0x7FFD55278320
    }

    public class VRCScaleConstraintBase : VRCConstraintBase
    {
        public object PositionMode;
        public object RotationMode;
        public object ScaleMode;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFD4E919180
        public void get_RotationMode(){} // RVA: 0x7FFD4E919180
        public void get_ScaleMode(){} // RVA: 0x7FFD4E433AF0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFD55278410
        public void ApplyZeroOffset(){} // RVA: 0x7FFD552784B0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFD55278510
        public void AffectsAnyAxis(){} // RVA: 0x7FFD55278060
        public void .ctor(){} // RVA: 0x7FFD55278610
    }

    public class VRCWorldUpConstraintBase : VRCConstraintBase
    {
        public object PositionMode;
        public object ScaleMode;
        public object UsesWorldUpTransform;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFD4E919180
        public void get_ScaleMode(){} // RVA: 0x7FFD4E919180
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFD4E341320
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFD55278700
        public void IsDependentOnTransform(){} // RVA: 0x7FFD552787A0
        public void RecalculateTransformCount(){} // RVA: 0x7FFD552789F0
        public void GetTransforms(){} // RVA: 0x7FFD55278CD0
        public void GetManagedWorldUpTransform(){} // RVA: 0x7FFD55278E90
        public void RequiresReallocation(){} // RVA: 0x7FFD55278ED0
        public void ApplyZeroOffset(){} // RVA: 0x7FFD55277F00
        public void AcceptOffsetBaker(){} // RVA: 0x7FFD55279060
        public void GenerateForwardLook(){} // RVA: 0x7FFD55279090
        public void DetermineUpVector(){}
        public void ForwardLookShouldApplyIdentity(){}
        public void ForwardLookHandleZeroUp(){}
        public void ReOrientateForwardLook(){}
        public void .ctor(){} // RVA: 0x7FFD552793E0
    }

}