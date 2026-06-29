// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics.ManagedTypes
// Classes: 8
// Methods: 89

namespace VRC.Dynamics.ManagedTypes
{
    public class VRCAimConstraintBase : VRCWorldUpConstraintBase
    {
        public object AffectsRotationX;
        public object AffectsRotationY;
        public object AffectsRotationZ;
        public object AimAxis;
        public object UpAxis;
        public object WorldUp;
        public object WorldUpVector;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0xDAC980
        public void get_RotationMode(){} // RVA: 0xC50A80
        public void get_ScaleMode(){} // RVA: 0xDAC980
        public void get_UsesWorldUpTransform(){} // RVA: 0x8301970
        public void UpdateTypeSpecificJobData(){} // RVA: 0x8301990
        public void DetermineUpVector(){} // RVA: 0x8301AB0
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x83022D0
        public void ForwardLookHandleZeroUp(){} // RVA: 0x83023E0
        public void ReOrientateForwardLook(){} // RVA: 0x83024F0
        public void FromToRotation(){} // RVA: 0x8302960
        public void AffectsAnyAxis(){} // RVA: 0x8302CE0
        public void .ctor(){} // RVA: 0x8302D00
        public void <FromToRotation>g__Approximately|20_0(){} // RVA: 0x8302E00
    }

    public class VRCLookAtConstraintBase : VRCWorldUpConstraintBase
    {
        public object Roll;
        public object UseUpTransform;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0xDAC980
        public void get_RotationMode(){} // RVA: 0x12FC4A0
        public void get_ScaleMode(){} // RVA: 0xDAC980
        public void get_UsesWorldUpTransform(){} // RVA: 0x8302E20
        public void UpdateTypeSpecificJobData(){} // RVA: 0x8302E30
        public void DetermineUpVector(){} // RVA: 0x8302EB0
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x83035E0
        public void ForwardLookHandleZeroUp(){} // RVA: 0x8303630
        public void ReOrientateForwardLook(){} // RVA: 0x83036F0
        public void AffectsAnyAxis(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x83038A0
    }

    public class VRCParentConstraintBase : VRCConstraintBase
    {
        public object PositionAtRest;
        public object AffectsPositionX;
        public object AffectsPositionY;
        public object AffectsPositionZ;
        public object RotationAtRest;
        public object AffectsRotationX;
        public object AffectsRotationY;
        public object AffectsRotationZ;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0xC50A80
        public void get_RotationMode(){} // RVA: 0xC3CCE0
        public void get_ScaleMode(){} // RVA: 0xDAC980
        public void UpdateTypeSpecificJobData(){} // RVA: 0x83038B0
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x8303970
        public void ApplyZeroOffset(){} // RVA: 0x83039C0
        public void AcceptOffsetBaker(){} // RVA: 0x8303B00
        public void AffectsAnyAxis(){} // RVA: 0x8303B30
        public void .ctor(){} // RVA: 0x8303B70
    }

    public class VRCParentConstraintBase[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class VRCPositionConstraintBase : VRCConstraintBase
    {
        public object PositionAtRest;
        public object PositionOffset;
        public object AffectsPositionX;
        public object AffectsPositionY;
        public object AffectsPositionZ;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0xC3CCE0
        public void get_RotationMode(){} // RVA: 0xDAC980
        public void get_ScaleMode(){} // RVA: 0xDAC980
        public void UpdateTypeSpecificJobData(){} // RVA: 0x8303C70
        public void ApplyZeroOffset(){} // RVA: 0x8303D00
        public void AcceptOffsetBaker(){} // RVA: 0x8303D60
        public void AffectsAnyAxis(){} // RVA: 0x8303EB0
        public void .ctor(){} // RVA: 0x8303ED0
    }

    public class VRCRotationConstraintBase : VRCConstraintBase
    {
        public object RotationAtRest;
        public object RotationOffset;
        public object AffectsRotationX;
        public object AffectsRotationY;
        public object AffectsRotationZ;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0xDAC980
        public void get_RotationMode(){} // RVA: 0xC3CCE0
        public void get_ScaleMode(){} // RVA: 0xDAC980
        public void UpdateTypeSpecificJobData(){} // RVA: 0x8303FC0
        public void ApplyZeroOffset(){} // RVA: 0x8303D00
        public void AcceptOffsetBaker(){} // RVA: 0x8304050
        public void AffectsAnyAxis(){} // RVA: 0x8303EB0
        public void .ctor(){} // RVA: 0x83041B0
    }

    public class VRCScaleConstraintBase : VRCConstraintBase
    {
        public object ScaleAtRest;
        public object ScaleOffset;
        public object AffectsScaleX;
        public object AffectsScaleY;
        public object AffectsScaleZ;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0xDAC980
        public void get_RotationMode(){} // RVA: 0xDAC980
        public void get_ScaleMode(){} // RVA: 0xC3CCE0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x83042A0
        public void ApplyZeroOffset(){} // RVA: 0x8304340
        public void AcceptOffsetBaker(){} // RVA: 0x83043A0
        public void AffectsAnyAxis(){} // RVA: 0x8303EB0
        public void .ctor(){} // RVA: 0x83044E0
    }

    public class VRCWorldUpConstraintBase : VRCConstraintBase
    {
        public object RotationAtRest;
        public object RotationOffset;
        public object WorldUpTransform;

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0xDAC980
        public void get_ScaleMode(){} // RVA: 0xDAC980
        public void get_UsesWorldUpTransform(){} // RVA: 0xB43320
        public void UpdateTypeSpecificJobData(){} // RVA: 0x83045D0
        public void IsDependentOnTransform(){} // RVA: 0x8304670
        public void RecalculateTransformCount(){} // RVA: 0x83048C0
        public void GetTransforms(){} // RVA: 0x83049C0
        public void GetManagedWorldUpTransform(){} // RVA: 0x8304B80
        public void RequiresReallocation(){} // RVA: 0x8304BC0
        public void ApplyZeroOffset(){} // RVA: 0x8303D00
        public void AcceptOffsetBaker(){} // RVA: 0x8304D40
        public void GenerateForwardLook(){} // RVA: 0x8304D70
        public void DetermineUpVector(){} // RVA: 0x87BF80
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x87D3C0
        public void ForwardLookHandleZeroUp(){} // RVA: 0x8954D0
        public void ReOrientateForwardLook(){} // RVA: 0x87BF80
        public void .ctor(){} // RVA: 0x8305140
    }

}