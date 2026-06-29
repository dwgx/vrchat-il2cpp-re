// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 3
// Methods: 13

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class ParameterExpression : Expression
    {
        public object _name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706F9B0
        public void Make(){} // RVA: 0x706F3F0
        public void get_Type(){} // RVA: 0x6AAD9D0
        public void get_NodeType(){} // RVA: 0x706F970
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_IsByRef(){} // RVA: 0x11F4110
        public void GetIsByRef(){} // RVA: 0xB43320
        public void Accept(){} // RVA: 0x706F980
    }

    public class PrimitiveParameterExpression`1 : ParameterExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void get_Type(){} // RVA: 0x87C0A0
    }

    public class PropertyExpression : MemberExpression
    {
        public object _property;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706A630
        public void GetMember(){} // RVA: 0xB465B0
        public void get_Type(){} // RVA: 0x706A6D0
    }

}