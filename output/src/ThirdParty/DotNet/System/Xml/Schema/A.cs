// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Xml.Schema
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System.Xml.Schema
{
    public class ActiveAxis : Object
    {
        public int _currentDepth; // 0x10

        // ── Methods ──
        public void get_CurrentDepth(){} // RVA: 0x7FFE811485C0
        public void Reactivate(){} // RVA: 0x7FFE8760EE80
        public void .ctor(){} // RVA: 0x7FFE8760EE90
        public void MoveToStartElement(){} // RVA: 0x7FFE8760F230
        public void EndElement(){} // RVA: 0x7FFE8760F3C0
        public void MoveToAttribute(){} // RVA: 0x7FFE8760F500
    }

    public class AllElementsContentValidator : ContentValidator
    {
        public System.Collections.Hashtable elements; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE876211C0
        public void AddElement(){} // RVA: 0x7FFE876213B0
        public void get_IsEmptiable(){} // RVA: 0x7FFE87621510
        public void InitValidation(){} // RVA: 0x7FFE87621530
        public void ValidateElement(){} // RVA: 0x7FFE87621610
        public void CompleteValidation(){} // RVA: 0x7FFE876217B0
        public void ExpectedElements(){} // RVA: 0x7FFE87621800
        public void ExpectedParticles(){} // RVA: 0x7FFE87621BC0
    }

    public class Asttree : Object
    {
        public System.Collections.ArrayList _fAxisArray; // 0x10

        // ── Methods ──
        public void get_SubtreeArray(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE8760FC40
        public void IsNameTest(){} // RVA: 0x7FFE8760FD20
        public void IsAttribute(){} // RVA: 0x7FFE8760FD50
        public void IsDescendantOrSelf(){} // RVA: 0x7FFE8760FD80
        public void IsSelf(){} // RVA: 0x7FFE8760FDB0
        public void CompileXPath(){} // RVA: 0x7FFE8760FDE0
        public void SetURN(){} // RVA: 0x7FFE876106D0
    }

    public class AutoValidator : BaseValidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87610840
        public void get_PreserveWhitespace(){} // RVA: 0x7FFE810FB320
        public void Validate(){} // RVA: 0x7FFE87610920
        public void CompleteValidation(){} // RVA: 0x7FFE810FB310
        public void FindId(){} // RVA: 0x7FFE813240E0
        public void DetectValidationType(){} // RVA: 0x7FFE87610AF0
    }

    public class AxisElement : Object
    {
        public System.Xml.Schema.DoubleLinkAxis curNode; // 0x10

        // ── Methods ──
        public void get_CurNode(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE8760DF30
        public void SetDepth(){} // RVA: 0x7FFE8760DF90
        public void MoveToParent(){} // RVA: 0x7FFE8760DFA0
        public void MoveToChild(){} // RVA: 0x7FFE8760E130
    }

    public class AxisStack : Object
    {
        public System.Collections.ArrayList _stack; // 0x10
        public System.Xml.Schema.ForwardAxis _subtree; // 0x18

        // ── Methods ──
        public void get_Subtree(){} // RVA: 0x7FFE810FE7C0
        public void get_Length(){} // RVA: 0x7FFE8154F670
        public void .ctor(){} // RVA: 0x7FFE8760E300
        public void Push(){} // RVA: 0x7FFE8760E490
        public void Pop(){} // RVA: 0x7FFE8760E580
        public void Equal(){} // RVA: 0x7FFE8760E5D0
        public void MoveToParent(){} // RVA: 0x7FFE8760E690
        public void MoveToChild(){} // RVA: 0x7FFE8760EA30
        public void MoveToAttribute(){} // RVA: 0x7FFE8760EC40
    }

}