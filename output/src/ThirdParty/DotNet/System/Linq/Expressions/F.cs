// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 4
// Methods: 10

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class FieldExpression : MemberExpression
    {
        public System.Reflection.FieldInfo _field; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713B700
        public void GetMember(){} // RVA: 0x7FFE810FE7C0
        public void get_Type(){} // RVA: 0x7FFE8713B770
    }

    public class FullConditionalExpression : ConditionalExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711EF80
        public void GetFalse(){} // RVA: 0x7FFE811290C0
    }

    public class FullConditionalExpressionWithType : FullConditionalExpression
    {
        public System.Type _type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711EFF0
        public void get_Type(){} // RVA: 0x7FFE81129130
    }

    public class FullExpression`1 : ExpressionN`1
    {
        public string _nameCore;
        public bool _tailCallCore;

        // ── Methods ──
        public void .ctor(){}
        public void get_NameCore(){} // RVA: 0x7FFE80E2E2E0
        public void get_TailCallCore(){} // RVA: 0x7FFE80E2F150
    }

}