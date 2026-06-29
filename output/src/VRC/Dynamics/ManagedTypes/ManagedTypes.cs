// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics.ManagedTypes
// Classes: 8
// Methods: 89

namespace VRC.Dynamics.ManagedTypes
{
    public class VRCAimConstraintBase : VRCWorldUpConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7A82D1450
        public void get_RotationMode(){} // RVA: 0x7A81DDCC0
        public void get_ScaleMode(){} // RVA: 0x7A82D1450
        public void get_UsesWorldUpTransform(){} // RVA: 0x7AF4A8D40
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7AF4A8D60
        public void DetermineUpVector(){} // RVA: 0x7AF4A8E80
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7AF4A97F0
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7AF4A9900
        public void ReOrientateForwardLook(){} // RVA: 0x7AF4A9A10
        public void FromToRotation(){} // RVA: 0x7AF4A9E80
        public void AffectsAnyAxis(){} // RVA: 0x7AF4AA200
        public void .ctor(){} // RVA: 0x7AF4AA220
        public void <FromToRotation>g__Approximately|20_0(){} // RVA: 0x7AF4AA320
    }

    public class VRCLookAtConstraintBase : VRCWorldUpConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7A82D1450
        public void get_RotationMode(){} // RVA: 0x7A87EE0F0
        public void get_ScaleMode(){} // RVA: 0x7A82D1450
        public void get_UsesWorldUpTransform(){} // RVA: 0x7AF4AA340
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7AF4AA350
        public void DetermineUpVector(){} // RVA: 0x7AF4AA3D0
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7AF4AAA10
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7AF4AAA60
        public void ReOrientateForwardLook(){} // RVA: 0x7AF4AAB20
        public void AffectsAnyAxis(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7AF4AACD0
    }

    public class VRCParentConstraintBase : VRCConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7A81DDCC0
        public void get_RotationMode(){} // RVA: 0x7A81CA9D0
        public void get_ScaleMode(){} // RVA: 0x7A82D1450
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7AF4AACE0
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x7AF4AADA0
        public void ApplyZeroOffset(){} // RVA: 0x7AF4AADF0
        public void AcceptOffsetBaker(){} // RVA: 0x7AF4AAF30
        public void AffectsAnyAxis(){} // RVA: 0x7AF4AAF60
        public void .ctor(){} // RVA: 0x7AF4AAFA0
    }

    public class VRCParentConstraintBase[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class VRCPositionConstraintBase : VRCConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7A81CA9D0
        public void get_RotationMode(){} // RVA: 0x7A82D1450
        public void get_ScaleMode(){} // RVA: 0x7A82D1450
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7AF4AB0A0
        public void ApplyZeroOffset(){} // RVA: 0x7AF4AB130
        public void AcceptOffsetBaker(){} // RVA: 0x7AF4AB190
        public void AffectsAnyAxis(){} // RVA: 0x7AF4AB290
        public void .ctor(){} // RVA: 0x7AF4AB2B0
    }

    public class VRCRotationConstraintBase : VRCConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7A82D1450
        public void get_RotationMode(){} // RVA: 0x7A81CA9D0
        public void get_ScaleMode(){} // RVA: 0x7A82D1450
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7AF4AB3A0
        public void ApplyZeroOffset(){} // RVA: 0x7AF4AB130
        public void AcceptOffsetBaker(){} // RVA: 0x7AF4AB430
        public void AffectsAnyAxis(){} // RVA: 0x7AF4AB290
        public void .ctor(){} // RVA: 0x7AF4AB550
    }

    public class VRCScaleConstraintBase : VRCConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7A82D1450
        public void get_RotationMode(){} // RVA: 0x7A82D1450
        public void get_ScaleMode(){} // RVA: 0x7A81CA9D0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7AF4AB640
        public void ApplyZeroOffset(){} // RVA: 0x7AF4AB6E0
        public void AcceptOffsetBaker(){} // RVA: 0x7AF4AB740
        public void AffectsAnyAxis(){} // RVA: 0x7AF4AB290
        public void .ctor(){} // RVA: 0x7AF4AB840
    }

    public class VRCWorldUpConstraintBase : VRCConstraintBase
    {
        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7A82D1450
        public void get_ScaleMode(){} // RVA: 0x7A82D1450
        public void get_UsesWorldUpTransform(){} // RVA: 0x7A80D7320
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7AF4AB930
        public void IsDependentOnTransform(){} // RVA: 0x7AF4AB9D0
        public void RecalculateTransformCount(){} // RVA: 0x7AF4ABC20
        public void GetTransforms(){} // RVA: 0x7AF4ABD20
        public void GetManagedWorldUpTransform(){} // RVA: 0x7AF4ABEE0
        public void RequiresReallocation(){} // RVA: 0x7AF4ABF20
        public void ApplyZeroOffset(){} // RVA: 0x7AF4AB130
        public void AcceptOffsetBaker(){} // RVA: 0x7AF4AC0A0
        public void GenerateForwardLook(){} // RVA: 0x7AF4AC0D0
        public void DetermineUpVector(){} // RVA: 0x7A7E00560
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7A7E01A40
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7A7E1DDC0
        public void ReOrientateForwardLook(){} // RVA: 0x7A7E00560
        public void .ctor(){} // RVA: 0x7AF4AC440
    }

}