// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ActiveAxis
    {
        public int _currentDepth; // 0x10

        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0x32A5C0
        public void Reactivate(){} // RVA: 0x6ACFB90
        public void .ctor(){} // RVA: 0x6ACFBA0
        public void MoveToStartElement(){} // RVA: 0x6ACFF40
        public void EndElement(){} // RVA: 0x6AD00D0
        public void MoveToAttribute(){} // RVA: 0x6AD0210
    }

    public class AllElementsContentValidator
    {
        public System.Collections.Hashtable elements; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AE1ED0
        public void AddElement(){} // RVA: 0x6AE20C0
        public void get_IsEmptiable(){} // RVA: 0x6AE2220
        public void InitValidation(){} // RVA: 0x6AE2240
        public void ValidateElement(){} // RVA: 0x6AE2320
        public void CompleteValidation(){} // RVA: 0x6AE24C0
        public void ExpectedElements(){} // RVA: 0x6AE2510
        public void ExpectedParticles(){} // RVA: 0x6AE28D0
    }

    public class Asttree
    {
        public System.Collections.ArrayList PreserveWhitespace; // 0x10

        // ── Methods ──
        public void get_SubtreeArray(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x6AD0950
        public void IsNameTest(){} // RVA: 0x6AD0A30
        public void IsAttribute(){} // RVA: 0x6AD0A60
        public void IsDescendantOrSelf(){} // RVA: 0x6AD0A90
        public void IsSelf(){} // RVA: 0x6AD0AC0
        public void CompileXPath(){} // RVA: 0x6AD0AF0
        public void SetURN(){} // RVA: 0x6AD13E0
    }

    public class AutoValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6AD1550
        public void get_PreserveWhitespace(){} // RVA: 0x2DD320
        public void Validate(){} // RVA: 0x6AD1630
        public void CompleteValidation(){} // RVA: 0x2DD310
        public void FindId(){} // RVA: 0x519240
        public void DetectValidationType(){} // RVA: 0x6AD1800
    }

    public class AxisElement
    {
        public System.Xml.Schema.DoubleLinkAxis Subtree; // 0x10

        // ── Methods ──
        public void get_CurNode(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x6ACEC40
        public void SetDepth(){} // RVA: 0x6ACECA0
        public void MoveToParent(){} // RVA: 0x6ACECB0
        public void MoveToChild(){} // RVA: 0x6ACEE40
    }

    public class AxisStack
    {
        public System.Collections.ArrayList CurrentDepth; // 0x10
        public System.Xml.Schema.ForwardAxis _subtree; // 0x18

        // ── Methods ──
        public void get_Subtree(){} // RVA: 0x2E07C0
        public void get_Length(){} // RVA: 0x5DFC050
        public void .ctor(){} // RVA: 0x6ACF010
        public void Push(){} // RVA: 0x6ACF1A0
        public void Pop(){} // RVA: 0x6ACF290
        public void Equal(){} // RVA: 0x6ACF2E0
        public void MoveToParent(){} // RVA: 0x6ACF3A0
        public void MoveToChild(){} // RVA: 0x6ACF740
        public void MoveToAttribute(){} // RVA: 0x6ACF950
    }

}