// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics.ManagedTypes
// Classes: 7
// Methods: 74

namespace VRC.Dynamics.ManagedTypes
{
    public class VRCAimConstraintBase : VRCWorldUpConstraintBase
    {
        public bool AffectsRotationX; // 0x3A0
        public bool AffectsRotationY; // 0x3A1
        public bool AffectsRotationZ; // 0x3A2
        public UnityEngine.Vector3 AimAxis; // 0x3A4

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFE813240E0
        public void get_RotationMode(){} // RVA: 0x7FFE81200CB0
        public void get_ScaleMode(){} // RVA: 0x7FFE813240E0
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFE88206FA0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFE88206FC0
        public void DetermineUpVector(){} // RVA: 0x7FFE882070E0
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7FFE88207910
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7FFE88207A20
        public void ReOrientateForwardLook(){} // RVA: 0x7FFE88207B30
        public void FromToRotation(){} // RVA: 0x7FFE88207FD0
        public void AffectsAnyAxis(){} // RVA: 0x7FFE88208360
        public void .ctor(){} // RVA: 0x7FFE88208380
        public void <FromToRotation>g__Approximately|20_0(){} // RVA: 0x7FFE88208480
    }

    public class VRCLookAtConstraintBase : VRCWorldUpConstraintBase
    {
        public float Roll; // 0x3A0
        public bool UseUpTransform; // 0x3A4
        public object field_2; // 0x1BB0
        public object field_3; // 0xB960

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFE813240E0
        public void get_RotationMode(){} // RVA: 0x7FFE817BF630
        public void get_ScaleMode(){} // RVA: 0x7FFE813240E0
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFE882084A0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFE882084B0
        public void DetermineUpVector(){} // RVA: 0x7FFE88208530
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7FFE88208B70
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7FFE88208BC0
        public void ReOrientateForwardLook(){} // RVA: 0x7FFE88208C80
        public void AffectsAnyAxis(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE88208E80
    }

    public class VRCParentConstraintBase : VRCConstraintBase
    {
        public UnityEngine.Vector3 PositionAtRest; // 0x380
        public bool AffectsPositionX; // 0x38C
        public bool AffectsPositionY; // 0x38D

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFE81200CB0
        public void get_RotationMode(){} // RVA: 0x7FFE811EDAF0
        public void get_ScaleMode(){} // RVA: 0x7FFE813240E0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFE88208E90
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x7FFE88208F50
        public void ApplyZeroOffset(){} // RVA: 0x7FFE88208FA0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFE882090E0
        public void AffectsAnyAxis(){} // RVA: 0x7FFE88209110
        public void .ctor(){} // RVA: 0x7FFE88209150
    }

    public class VRCPositionConstraintBase : VRCConstraintBase
    {
        public UnityEngine.Vector3 PositionAtRest; // 0x380
        public UnityEngine.Vector3 PositionOffset; // 0x38C
        public bool AffectsPositionX; // 0x398

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFE811EDAF0
        public void get_RotationMode(){} // RVA: 0x7FFE813240E0
        public void get_ScaleMode(){} // RVA: 0x7FFE813240E0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFE88209250
        public void ApplyZeroOffset(){} // RVA: 0x7FFE882092E0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFE88209340
        public void AffectsAnyAxis(){} // RVA: 0x7FFE88209440
        public void .ctor(){} // RVA: 0x7FFE88209460
    }

    public class VRCRotationConstraintBase : VRCConstraintBase
    {
        public UnityEngine.Vector3 RotationAtRest; // 0x380
        public UnityEngine.Vector3 RotationOffset; // 0x38C
        public bool AffectsRotationX; // 0x398

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFE813240E0
        public void get_RotationMode(){} // RVA: 0x7FFE811EDAF0
        public void get_ScaleMode(){} // RVA: 0x7FFE813240E0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFE88209550
        public void ApplyZeroOffset(){} // RVA: 0x7FFE882092E0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFE882095E0
        public void AffectsAnyAxis(){} // RVA: 0x7FFE88209440
        public void .ctor(){} // RVA: 0x7FFE88209700
    }

    public class VRCScaleConstraintBase : VRCConstraintBase
    {
        public UnityEngine.Vector3 ScaleAtRest; // 0x380
        public UnityEngine.Vector3 ScaleOffset; // 0x38C
        public bool AffectsScaleX; // 0x398

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFE813240E0
        public void get_RotationMode(){} // RVA: 0x7FFE813240E0
        public void get_ScaleMode(){} // RVA: 0x7FFE811EDAF0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFE882097F0
        public void ApplyZeroOffset(){} // RVA: 0x7FFE88209890
        public void AcceptOffsetBaker(){} // RVA: 0x7FFE882098F0
        public void AffectsAnyAxis(){} // RVA: 0x7FFE88209440
        public void .ctor(){} // RVA: 0x7FFE882099F0
    }

    public class VRCWorldUpConstraintBase : VRCConstraintBase
    {
        public UnityEngine.Vector3 RotationAtRest; // 0x380
        public UnityEngine.Vector3 RotationOffset; // 0x38C
        public UnityEngine.Transform WorldUpTransform; // 0x398

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFE813240E0
        public void get_ScaleMode(){} // RVA: 0x7FFE813240E0
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFE810FB320
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFE88209AE0
        public void IsDependentOnTransform(){} // RVA: 0x7FFE88209B80
        public void RecalculateTransformCount(){} // RVA: 0x7FFE88209DD0
        public void GetTransforms(){} // RVA: 0x7FFE8820A0B0
        public void GetManagedWorldUpTransform(){} // RVA: 0x7FFE8820A270
        public void RequiresReallocation(){} // RVA: 0x7FFE8820A2B0
        public void ApplyZeroOffset(){} // RVA: 0x7FFE882092E0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFE8820A440
        public void GenerateForwardLook(){} // RVA: 0x7FFE8820A470
        public void DetermineUpVector(){}
        public void ForwardLookShouldApplyIdentity(){}
        public void ForwardLookHandleZeroUp(){}
        public void ReOrientateForwardLook(){}
        public void .ctor(){} // RVA: 0x7FFE8820A7C0
    }

}