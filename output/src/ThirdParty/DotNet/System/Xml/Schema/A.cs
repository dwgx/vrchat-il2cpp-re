// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ActiveAxis : Object
    {
        public int CurrentDepth; // 0x10
        public bool _isActive; // 0x14
        public System.Xml.Schema.Asttree _axisTree; // 0x18
        public System.Collections.ArrayList _axisStack; // 0x20

        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0x7FFAC2F6E5C0
        public void Reactivate(){} // RVA: 0x7FFAC9266710
        public void .ctor(){} // RVA: 0x7FFAC9266720
        public void MoveToStartElement(){} // RVA: 0x7FFAC9266AC0
        public void EndElement(){} // RVA: 0x7FFAC9266C50
        public void MoveToAttribute(){} // RVA: 0x7FFAC9266D90
    }

    public class AllElementsContentValidator : ContentValidator
    {
        public System.Collections.Hashtable IsEmptiable; // 0x18
        public object[] particles; // 0x20
        public System.Xml.Schema.BitSet isRequired; // 0x28
        public int countRequired; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9278A50
        public void AddElement(){} // RVA: 0x7FFAC9278C40
        public void get_IsEmptiable(){} // RVA: 0x7FFAC9278DA0
        public void InitValidation(){} // RVA: 0x7FFAC9278DC0
        public void ValidateElement(){} // RVA: 0x7FFAC9278EA0
        public void CompleteValidation(){} // RVA: 0x7FFAC9279040
        public void ExpectedElements(){} // RVA: 0x7FFAC9279090
        public void ExpectedParticles(){} // RVA: 0x7FFAC9279450
    }

    public class Asttree : Object
    {
        public System.Collections.ArrayList SubtreeArray; // 0x10
        public string _xpathexpr; // 0x18
        public bool _isField; // 0x20
        public System.Xml.XmlNamespaceManager _nsmgr; // 0x28

        // ── Methods ──
        public void get_SubtreeArray(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC92674D0
        public void IsNameTest(){} // RVA: 0x7FFAC92675B0
        public void IsAttribute(){} // RVA: 0x7FFAC92675E0
        public void IsDescendantOrSelf(){} // RVA: 0x7FFAC9267610
        public void IsSelf(){} // RVA: 0x7FFAC9267640
        public void CompileXPath(){} // RVA: 0x7FFAC9267670
        public void SetURN(){} // RVA: 0x7FFAC9267F60
    }

    public class AutoValidator : BaseValidator
    {
        public object PreserveWhitespace;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC92680D0
        public void get_PreserveWhitespace(){} // RVA: 0x7FFAC2F21320
        public void Validate(){} // RVA: 0x7FFAC92681B0
        public void CompleteValidation(){} // RVA: 0x7FFAC2F21310
        public void FindId(){} // RVA: 0x7FFAC34F9180
        public void DetectValidationType(){} // RVA: 0x7FFAC9268380
    }

    public class AxisElement : Object
    {
        public System.Xml.Schema.DoubleLinkAxis CurNode; // 0x10
        public int rootDepth; // 0x18
        public int curDepth; // 0x1C
        public bool isMatch; // 0x20

        // ── Methods ──
        public void get_CurNode(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC92657C0
        public void SetDepth(){} // RVA: 0x7FFAC9265820
        public void MoveToParent(){} // RVA: 0x7FFAC9265830
        public void MoveToChild(){} // RVA: 0x7FFAC92659C0
    }

    public class AxisStack : Object
    {
        public System.Collections.ArrayList Subtree; // 0x10
        public System.Xml.Schema.ForwardAxis Length; // 0x18
        public System.Xml.Schema.ActiveAxis _parent; // 0x20

        // ── Methods ──
        public void get_Subtree(){} // RVA: 0x7FFAC2F247C0
        public void get_Length(){} // RVA: 0x7FFAC8593680
        public void .ctor(){} // RVA: 0x7FFAC9265B90
        public void Push(){} // RVA: 0x7FFAC9265D20
        public void Pop(){} // RVA: 0x7FFAC9265E10
        public void Equal(){} // RVA: 0x7FFAC9265E60
        public void MoveToParent(){} // RVA: 0x7FFAC9265F20
        public void MoveToChild(){} // RVA: 0x7FFAC92662C0
        public void MoveToAttribute(){} // RVA: 0x7FFAC92664D0
    }

}