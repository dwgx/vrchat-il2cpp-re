// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 3
// Methods: 14

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class ParameterExpression : Expression
    {
        public string _name; // 0x10
        public object field_1; // 0x1F6
        public object field_2; // 0x1F7
        public object field_3; // 0x1F8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87140B20 | overloaded x2
        public void Make(){} // RVA: 0x7FFE871404D0
        public void get_Type(){} // RVA: 0x7FFE87140A30
        public void get_NodeType(){} // RVA: 0x7FFE87140AE0
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_IsByRef(){} // RVA: 0x7FFE844800F0
        public void GetIsByRef(){} // RVA: 0x7FFE810FB320
        public void Accept(){} // RVA: 0x7FFE87140AF0
    }

    public class PrimitiveParameterExpression`1 : ParameterExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Type(){} // RVA: 0x7FFE80E2E2E0
    }

    public class PropertyExpression : MemberExpression
    {
        public System.Reflection.PropertyInfo _property; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713B700
        public void GetMember(){} // RVA: 0x7FFE810FE7C0
        public void get_Type(){} // RVA: 0x7FFE8713B7A0
    }

}