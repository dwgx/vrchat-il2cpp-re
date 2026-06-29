// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 4
// Methods: 10

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class FieldExpression : MemberExpression
    {
        public object _field;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706A630
        public void GetMember(){} // RVA: 0xB465B0
        public void get_Type(){} // RVA: 0x706A6A0
    }

    public class FullConditionalExpression : ConditionalExpression
    {
        public object _false;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704E480
        public void GetFalse(){} // RVA: 0xB700F0
    }

    public class FullConditionalExpressionWithType : FullConditionalExpression
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704E4F0
        public void get_Type(){} // RVA: 0xB70160
    }

    public class FullExpression`1 : ExpressionN`1
    {
        public object _nameCore;
        public object _tailCallCore;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x89DAB0
        public void get_NameCore(){} // RVA: 0x87C0A0
        public void get_TailCallCore(){} // RVA: 0x87D280
    }

}