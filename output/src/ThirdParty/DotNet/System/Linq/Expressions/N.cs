// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 5
// Methods: 24

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class NewArrayBoundsExpression : NewArrayExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713FFB0
        public void get_NodeType(){} // RVA: 0x7FFE8713FFC0
    }

    public class NewArrayExpression : Expression
    {
        public System.Type _type; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.Expression> _expressions; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713FF80 | overloaded x2
        public void Make(){} // RVA: 0x7FFE8713FD00
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_Expressions(){} // RVA: 0x7FFE810FE7C0
        public void Accept(){} // RVA: 0x7FFE8713FD90
        public void Update(){} // RVA: 0x7FFE8713FDC0
    }

    public class NewArrayInitExpression : NewArrayExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713FFB0
        public void get_NodeType(){} // RVA: 0x7FFE835C28C0
    }

    public class NewExpression : Expression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> _arguments; // 0x10
        public System.Reflection.ConstructorInfo _constructor; // 0x18
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Reflection.MemberInfo> _members; // 0x20
        public object field_3; // 0x1EF
        public object field_4; // 0x1F0
        public object field_5; // 0x1F1

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87140380 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE86738540
        public void get_NodeType(){} // RVA: 0x7FFE87140130
        public void get_Constructor(){} // RVA: 0x7FFE810FE7C0
        public void get_Arguments(){} // RVA: 0x7FFE87140140
        public void GetArgument(){} // RVA: 0x7FFE87140180
        public void get_ArgumentCount(){} // RVA: 0x7FFE871401E0
        public void get_Members(){} // RVA: 0x7FFE811290C0
        public void Accept(){} // RVA: 0x7FFE87140230
        public void Update(){} // RVA: 0x7FFE87140260
    }

    public class NewValueTypeExpression : NewExpression
    {
        public System.Type _type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871403B0
        public void get_Type(){} // RVA: 0x7FFE81129130
    }

}