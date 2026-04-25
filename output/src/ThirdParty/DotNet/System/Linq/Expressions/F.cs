// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 4
// Methods: 10

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class FieldExpression : MemberExpression
    {
        public System.Reflection.FieldInfo Type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D932D0
        public void GetMember(){} // RVA: 0x7FFAC2F247C0
        public void get_Type(){} // RVA: 0x7FFAC8D93340
    }

    public class FullConditionalExpression : ConditionalExpression
    {
        public System.Linq.Expressions.Expression _false; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D76B50
        public void GetFalse(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class FullConditionalExpressionWithType : FullConditionalExpression
    {
        public System.Type Type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D76BC0
        public void get_Type(){} // RVA: 0x7FFAC2F4F130
    }

    public class FullExpression`1 : ExpressionN`1
    {
        public string NameCore;
        public bool TailCallCore;

        // ── Methods ──
        public void .ctor(){}
        public void get_NameCore(){} // RVA: 0x7FFAC2C58E90
        public void get_TailCallCore(){} // RVA: 0x7FFAC2C59D00
    }

}