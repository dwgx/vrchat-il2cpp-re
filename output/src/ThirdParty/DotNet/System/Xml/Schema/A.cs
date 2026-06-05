// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ActiveAxis
    {
        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0x7FFAF2DDA5C0
        public void Reactivate(){} // RVA: 0x7FFAF957FB90
        public void .ctor(){} // RVA: 0x7FFAF957FBA0
        public void MoveToStartElement(){} // RVA: 0x7FFAF957FF40
        public void EndElement(){} // RVA: 0x7FFAF95800D0
        public void MoveToAttribute(){} // RVA: 0x7FFAF9580210
    }

    public class AllElementsContentValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9591ED0
        public void AddElement(){} // RVA: 0x7FFAF95920C0
        public void get_IsEmptiable(){} // RVA: 0x7FFAF9592220
        public void InitValidation(){} // RVA: 0x7FFAF9592240
        public void ValidateElement(){} // RVA: 0x7FFAF9592320
        public void CompleteValidation(){} // RVA: 0x7FFAF95924C0
        public void ExpectedElements(){} // RVA: 0x7FFAF9592510
        public void ExpectedParticles(){} // RVA: 0x7FFAF95928D0
    }

    public class Asttree
    {
        public object PreserveWhitespace;

        // ── Methods ──
        public void get_SubtreeArray(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF9580950
        public void IsNameTest(){} // RVA: 0x7FFAF9580A30
        public void IsAttribute(){} // RVA: 0x7FFAF9580A60
        public void IsDescendantOrSelf(){} // RVA: 0x7FFAF9580A90
        public void IsSelf(){} // RVA: 0x7FFAF9580AC0
        public void CompileXPath(){} // RVA: 0x7FFAF9580AF0
        public void SetURN(){} // RVA: 0x7FFAF95813E0
    }

    public class AutoValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9581550
        public void get_PreserveWhitespace(){} // RVA: 0x7FFAF2D8D320
        public void Validate(){} // RVA: 0x7FFAF9581630
        public void CompleteValidation(){} // RVA: 0x7FFAF2D8D310
        public void FindId(){} // RVA: 0x7FFAF2FC9240
        public void DetectValidationType(){} // RVA: 0x7FFAF9581800
    }

    public class AxisElement
    {
        public object Subtree;

        // ── Methods ──
        public void get_CurNode(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF957EC40
        public void SetDepth(){} // RVA: 0x7FFAF957ECA0
        public void MoveToParent(){} // RVA: 0x7FFAF957ECB0
        public void MoveToChild(){} // RVA: 0x7FFAF957EE40
    }

    public class AxisStack
    {
        public object CurrentDepth;

        // ── Methods ──
        public void get_Subtree(){} // RVA: 0x7FFAF2D907C0
        public void get_Length(){} // RVA: 0x7FFAF88AC050
        public void .ctor(){} // RVA: 0x7FFAF957F010
        public void Push(){} // RVA: 0x7FFAF957F1A0
        public void Pop(){} // RVA: 0x7FFAF957F290
        public void Equal(){} // RVA: 0x7FFAF957F2E0
        public void MoveToParent(){} // RVA: 0x7FFAF957F3A0
        public void MoveToChild(){} // RVA: 0x7FFAF957F740
        public void MoveToAttribute(){} // RVA: 0x7FFAF957F950
    }

}