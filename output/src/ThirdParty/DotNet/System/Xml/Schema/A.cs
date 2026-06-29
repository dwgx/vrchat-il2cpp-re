// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ActiveAxis : Object
    {
        public object _currentDepth;
        public object _isActive;
        public object _axisTree;
        public object _axisStack;

        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0xB8F8F0
        public void Reactivate(){} // RVA: 0x7533FF0
        public void .ctor(){} // RVA: 0x7534000
        public void MoveToStartElement(){} // RVA: 0x75343A0
        public void EndElement(){} // RVA: 0x7534530
        public void MoveToAttribute(){} // RVA: 0x7534670
    }

    public class AllElementsContentValidator : ContentValidator
    {
        public object elements;
        public object particles;
        public object isRequired;
        public object countRequired;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7546370
        public void AddElement(){} // RVA: 0x7546560
        public void get_IsEmptiable(){} // RVA: 0x7546690
        public void InitValidation(){} // RVA: 0x75466B0
        public void ValidateElement(){} // RVA: 0x7546790
        public void CompleteValidation(){} // RVA: 0x7546910
        public void ExpectedElements(){} // RVA: 0x7546960
        public void ExpectedParticles(){} // RVA: 0x7546CF0
    }

    public class Asttree : Object
    {
        public object _fAxisArray;
        public object _xpathexpr;
        public object _isField;
        public object _nsmgr;

        // ── Methods ──
        public void get_SubtreeArray(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x7534DB0
        public void IsNameTest(){} // RVA: 0x7534E90
        public void IsAttribute(){} // RVA: 0x7534EC0
        public void IsDescendantOrSelf(){} // RVA: 0x7534EF0
        public void IsSelf(){} // RVA: 0x7534F20
        public void CompileXPath(){} // RVA: 0x7534F50
        public void SetURN(){} // RVA: 0x7535850
    }

    public class AutoValidator : BaseValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x75359C0
        public void get_PreserveWhitespace(){} // RVA: 0xB43320
        public void Validate(){} // RVA: 0x7535AA0
        public void CompleteValidation(){} // RVA: 0xB43310
        public void FindId(){} // RVA: 0xDAC980
        public void DetectValidationType(){} // RVA: 0x7535C70
    }

    public class AxisElement : Object
    {
        public object curNode;
        public object rootDepth;
        public object curDepth;
        public object isMatch;

        // ── Methods ──
        public void get_CurNode(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x7533090
        public void SetDepth(){} // RVA: 0x75330F0
        public void MoveToParent(){} // RVA: 0x7533100
        public void MoveToChild(){} // RVA: 0x7533290
    }

    public class AxisStack : Object
    {
        public object _stack;
        public object _subtree;
        public object _parent;

        // ── Methods ──
        public void get_Subtree(){} // RVA: 0xB465B0
        public void get_Length(){} // RVA: 0x6875CA0
        public void .ctor(){} // RVA: 0x7533460
        public void Push(){} // RVA: 0x7533600
        public void Pop(){} // RVA: 0x75336F0
        public void Equal(){} // RVA: 0x7533740
        public void MoveToParent(){} // RVA: 0x7533800
        public void MoveToChild(){} // RVA: 0x7533BA0
        public void MoveToAttribute(){} // RVA: 0x7533DB0
    }

}