// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Dynamics.ManagedTypes
// Classes: 7
// Methods: 74

namespace VRC.Dynamics.ManagedTypes
{
    public class VRCAimConstraintBase : VRCWorldUpConstraintBase
    {
        public bool PositionMode; // 0x3A0
        public bool RotationMode; // 0x3A1
        public bool ScaleMode; // 0x3A2
        public UnityEngine.Vector3 UsesWorldUpTransform; // 0x3A4
        public UnityEngine.Vector3 UpAxis; // 0x3B0
        public 0x6B25E428 WorldUp; // 0x3BC
        public UnityEngine.Vector3 WorldUpVector; // 0x3C0

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAC34F9180
        public void get_RotationMode(){} // RVA: 0x7FFAC3026CB0
        public void get_ScaleMode(){} // RVA: 0x7FFAC34F9180
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFAC9E55BC0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAC9E55BE0
        public void DetermineUpVector(){} // RVA: 0x7FFAC9E55D00
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7FFAC9E56530
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7FFAC9E56640
        public void ReOrientateForwardLook(){} // RVA: 0x7FFAC9E56750
        public void FromToRotation(){} // RVA: 0x7FFAC9E56BF0
        public void AffectsAnyAxis(){} // RVA: 0x7FFAC9E56F80
        public void .ctor(){} // RVA: 0x7FFAC9E56FA0
        public void <FromToRotation>g__Approximately|20_0(){} // RVA: 0x7FFAC9E570A0
    }

    public class VRCLookAtConstraintBase : VRCWorldUpConstraintBase
    {
        public float PositionMode; // 0x3A0
        public bool RotationMode; // 0x3A4

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAC34F9180
        public void get_RotationMode(){} // RVA: 0x7FFAC366FE20
        public void get_ScaleMode(){} // RVA: 0x7FFAC34F9180
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFAC9E570C0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAC9E570D0
        public void DetermineUpVector(){} // RVA: 0x7FFAC9E57150
        public void ForwardLookShouldApplyIdentity(){} // RVA: 0x7FFAC9E57790
        public void ForwardLookHandleZeroUp(){} // RVA: 0x7FFAC9E577E0
        public void ReOrientateForwardLook(){} // RVA: 0x7FFAC9E578A0
        public void AffectsAnyAxis(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC9E57AA0
    }

    public class VRCParentConstraintBase : VRCConstraintBase
    {
        public UnityEngine.Vector3 PositionMode; // 0x380
        public bool RotationMode; // 0x38C
        public bool ScaleMode; // 0x38D
        public bool AffectsPositionZ; // 0x38E
        public UnityEngine.Vector3 RotationAtRest; // 0x390
        public bool AffectsRotationX; // 0x39C
        public bool AffectsRotationY; // 0x39D
        public bool AffectsRotationZ; // 0x39E

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAC3026CB0
        public void get_RotationMode(){} // RVA: 0x7FFAC3013AF0
        public void get_ScaleMode(){} // RVA: 0x7FFAC34F9180
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAC9E57AB0
        public void UpdateTypeSpecificSourceData(){} // RVA: 0x7FFAC9E57B70
        public void ApplyZeroOffset(){} // RVA: 0x7FFAC9E57BC0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAC9E57D00
        public void AffectsAnyAxis(){} // RVA: 0x7FFAC9E57D30
        public void .ctor(){} // RVA: 0x7FFAC9E57D70
    }

    public class VRCPositionConstraintBase : VRCConstraintBase
    {
        public UnityEngine.Vector3 PositionMode; // 0x380
        public UnityEngine.Vector3 RotationMode; // 0x38C
        public bool ScaleMode; // 0x398
        public bool AffectsPositionY; // 0x399
        public bool AffectsPositionZ; // 0x39A

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAC3013AF0
        public void get_RotationMode(){} // RVA: 0x7FFAC34F9180
        public void get_ScaleMode(){} // RVA: 0x7FFAC34F9180
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAC9E57E70
        public void ApplyZeroOffset(){} // RVA: 0x7FFAC9E57F00
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAC9E57F60
        public void AffectsAnyAxis(){} // RVA: 0x7FFAC9E58060
        public void .ctor(){} // RVA: 0x7FFAC9E58080
    }

    public class VRCRotationConstraintBase : VRCConstraintBase
    {
        public UnityEngine.Vector3 PositionMode; // 0x380
        public UnityEngine.Vector3 RotationMode; // 0x38C
        public bool ScaleMode; // 0x398
        public bool AffectsRotationY; // 0x399
        public bool AffectsRotationZ; // 0x39A

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAC34F9180
        public void get_RotationMode(){} // RVA: 0x7FFAC3013AF0
        public void get_ScaleMode(){} // RVA: 0x7FFAC34F9180
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAC9E58170
        public void ApplyZeroOffset(){} // RVA: 0x7FFAC9E57F00
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAC9E58200
        public void AffectsAnyAxis(){} // RVA: 0x7FFAC9E58060
        public void .ctor(){} // RVA: 0x7FFAC9E58320
    }

    public class VRCScaleConstraintBase : VRCConstraintBase
    {
        public UnityEngine.Vector3 PositionMode; // 0x380
        public UnityEngine.Vector3 RotationMode; // 0x38C
        public bool ScaleMode; // 0x398
        public bool AffectsScaleY; // 0x399
        public bool AffectsScaleZ; // 0x39A

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAC34F9180
        public void get_RotationMode(){} // RVA: 0x7FFAC34F9180
        public void get_ScaleMode(){} // RVA: 0x7FFAC3013AF0
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAC9E58410
        public void ApplyZeroOffset(){} // RVA: 0x7FFAC9E584B0
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAC9E58510
        public void AffectsAnyAxis(){} // RVA: 0x7FFAC9E58060
        public void .ctor(){} // RVA: 0x7FFAC9E58610
    }

    public class VRCWorldUpConstraintBase : VRCConstraintBase
    {
        public UnityEngine.Vector3 PositionMode; // 0x380
        public UnityEngine.Vector3 ScaleMode; // 0x38C
        public UnityEngine.Transform UsesWorldUpTransform; // 0x398

        // ── Methods ──
        public void get_PositionMode(){} // RVA: 0x7FFAC34F9180
        public void get_ScaleMode(){} // RVA: 0x7FFAC34F9180
        public void get_UsesWorldUpTransform(){} // RVA: 0x7FFAC2F21320
        public void UpdateTypeSpecificJobData(){} // RVA: 0x7FFAC9E58700
        public void IsDependentOnTransform(){} // RVA: 0x7FFAC9E587A0
        public void RecalculateTransformCount(){} // RVA: 0x7FFAC9E589F0
        public void GetTransforms(){} // RVA: 0x7FFAC9E58CD0
        public void GetManagedWorldUpTransform(){} // RVA: 0x7FFAC9E58E90
        public void RequiresReallocation(){} // RVA: 0x7FFAC9E58ED0
        public void ApplyZeroOffset(){} // RVA: 0x7FFAC9E57F00
        public void AcceptOffsetBaker(){} // RVA: 0x7FFAC9E59060
        public void GenerateForwardLook(){} // RVA: 0x7FFAC9E59090
        public void DetermineUpVector(){}
        public void ForwardLookShouldApplyIdentity(){}
        public void ForwardLookHandleZeroUp(){}
        public void ReOrientateForwardLook(){}
        public void .ctor(){} // RVA: 0x7FFAC9E593E0
    }

}