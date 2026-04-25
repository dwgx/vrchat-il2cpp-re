// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 3
// Methods: 14

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class ParameterExpression : Expression
    {
        public string Type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D986F0 | overloaded x2
        public void Make(){} // RVA: 0x7FFAC8D980A0
        public void get_Type(){} // RVA: 0x7FFAC8D98600
        public void get_NodeType(){} // RVA: 0x7FFAC8D986B0
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_IsByRef(){} // RVA: 0x7FFAC3F5BE50
        public void GetIsByRef(){} // RVA: 0x7FFAC2F21320
        public void Accept(){} // RVA: 0x7FFAC8D986C0
    }

    public class PrimitiveParameterExpression`1 : ParameterExpression
    {
        public object Type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_Type(){} // RVA: 0x7FFAC2C58E90
    }

    public class PropertyExpression : MemberExpression
    {
        public System.Reflection.PropertyInfo Type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D932D0
        public void GetMember(){} // RVA: 0x7FFAC2F247C0
        public void get_Type(){} // RVA: 0x7FFAC8D93370
    }

}