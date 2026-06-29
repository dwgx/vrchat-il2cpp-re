// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 15
// Methods: 95

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class MemberAssignment : MemberBinding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EABC0
        public void get_Expression(){} // RVA: 0x7A81052C0
        public void Update(){} // RVA: 0x7AE3EAB40
        public void ValidateAsDefinedHere(){} // RVA: 0x7A80D7310
    }

    public class MemberBinding : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AC8120
        public void get_BindingType(){} // RVA: 0x7A8124910
        public void get_Member(){} // RVA: 0x7A80DA7B0
        public void ToString(){} // RVA: 0x7AE3E1440
        public void ValidateAsDefinedHere(){} // RVA: 0x7AE3EABF0
    }

    public class MemberExpression : Expression
    {
        // ── Methods ──
        public void get_Member(){} // RVA: 0x7AB5DC320
        public void get_Expression(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7AE3EB010
        public void Make(){} // RVA: 0x7AE3EAE40
        public void get_NodeType(){} // RVA: 0x7A87BABE0
        public void GetMember(){} // RVA: 0x7AE3EAF20
        public void Accept(){} // RVA: 0x7AE3EAF50
        public void Update(){} // RVA: 0x7AE3EAF80
    }

    public class MemberInitExpression : Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EBDB0
        public void get_Type(){} // RVA: 0x7A858AB20
        public void get_CanReduce(){} // RVA: 0x7A81BD750
        public void get_NodeType(){} // RVA: 0x7A9F22B00
        public void get_NewExpression(){} // RVA: 0x7A80F2570
        public void get_Bindings(){} // RVA: 0x7A80DA7B0
        public void Accept(){} // RVA: 0x7AE3EB220
        public void Reduce(){} // RVA: 0x7AE3EB250
        public void ReduceMemberInit(){} // RVA: 0x7AE3EB270
        public void ReduceListInit(){} // RVA: 0x7AE3EB6A0
        public void ReduceMemberBinding(){} // RVA: 0x7AE3EBB10
        public void Update(){} // RVA: 0x7AE3EBCE0
    }

    public class MemberListBinding : MemberBinding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EBF50
        public void get_Initializers(){} // RVA: 0x7A81052C0
        public void Update(){} // RVA: 0x7AE3EBEA0
        public void ValidateAsDefinedHere(){} // RVA: 0x7A80D7310
    }

    public class MemberMemberBinding : MemberBinding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EC030
        public void get_Bindings(){} // RVA: 0x7A81052C0
        public void Update(){} // RVA: 0x7AE3EBF80
        public void ValidateAsDefinedHere(){} // RVA: 0x7A80D7310
    }

    public class MethodBinaryExpression : SimpleBinaryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE39F6D0
        public void GetMethod(){} // RVA: 0x7A83F69F0
    }

    public class MethodCallExpression : Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EC340
        public void GetInstance(){} // RVA: 0x7A82D1450
        public void get_NodeType(){} // RVA: 0x7A8842E60
        public void get_Type(){} // RVA: 0x7A9C943C0
        public void get_Method(){} // RVA: 0x7A80F2570
        public void get_Object(){} // RVA: 0x7A89B55B0
        public void get_Arguments(){} // RVA: 0x7A95EA850
        public void Update(){} // RVA: 0x7AE3EC100
        public void SameArguments(){} // RVA: 0x7AE3EC220
        public void GetOrMakeArguments(){} // RVA: 0x7AE3EC250
        public void Accept(){} // RVA: 0x7AE3EC280
        public void Rewrite(){} // RVA: 0x7AE3EC2B0
        public void GetArgument(){} // RVA: 0x7AE3EC2E0
        public void get_ArgumentCount(){} // RVA: 0x7AE3EC310
    }

    public class MethodCallExpression0 : MethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EC990
        public void GetArgument(){} // RVA: 0x7AE3EC9A0
        public void get_ArgumentCount(){} // RVA: 0x7A82D1450
        public void GetOrMakeArguments(){} // RVA: 0x7AE3EC9F0
        public void SameArguments(){} // RVA: 0x7AE3ECA50
        public void Rewrite(){} // RVA: 0x7AE3ECAB0
    }

    public class MethodCallExpression1 : MethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EC370
        public void GetArgument(){} // RVA: 0x7AE3ECC30
        public void get_ArgumentCount(){} // RVA: 0x7A81CA9D0
        public void GetOrMakeArguments(){} // RVA: 0x7AE3ECCD0
        public void SameArguments(){} // RVA: 0x7AE3ECCE0
        public void Rewrite(){} // RVA: 0x7AE3ECE70
    }

    public class MethodCallExpression2 : MethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EC660
        public void GetArgument(){} // RVA: 0x7AE3ECF30
        public void get_ArgumentCount(){} // RVA: 0x7A81DDCC0
        public void SameArguments(){} // RVA: 0x7AE3ECFE0
        public void GetOrMakeArguments(){} // RVA: 0x7AE3ECCD0
        public void Rewrite(){} // RVA: 0x7AE3ED260
    }

    public class MethodCallExpression3 : MethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3ED360
        public void GetArgument(){} // RVA: 0x7AE3ED490
        public void get_ArgumentCount(){} // RVA: 0x7A87EE0F0
        public void SameArguments(){} // RVA: 0x7AE3ED550
        public void GetOrMakeArguments(){} // RVA: 0x7AE3ECCD0
        public void Rewrite(){} // RVA: 0x7AE3ED810
    }

    public class MethodCallExpression4 : MethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3ED940
        public void GetArgument(){} // RVA: 0x7AE3EDAC0
        public void get_ArgumentCount(){} // RVA: 0x7A883BE70
        public void SameArguments(){} // RVA: 0x7AE3EDBA0
        public void GetOrMakeArguments(){} // RVA: 0x7AE3ECCD0
        public void Rewrite(){} // RVA: 0x7AE3EDEA0
    }

    public class MethodCallExpression5 : MethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EE000
        public void GetArgument(){} // RVA: 0x7AE3EE1E0
        public void get_ArgumentCount(){} // RVA: 0x7A8401A30
        public void SameArguments(){} // RVA: 0x7AE3EE2D0
        public void GetOrMakeArguments(){} // RVA: 0x7AE3ECCD0
        public void Rewrite(){} // RVA: 0x7AE3EE610
    }

    public class MethodCallExpressionN : MethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EC370
        public void GetArgument(){} // RVA: 0x7AE3EC3E0
        public void get_ArgumentCount(){} // RVA: 0x7AE3EC440
        public void GetOrMakeArguments(){} // RVA: 0x7AE3EC490
        public void SameArguments(){} // RVA: 0x7AE3EC4D0
        public void Rewrite(){} // RVA: 0x7AE3EC5B0
    }

}