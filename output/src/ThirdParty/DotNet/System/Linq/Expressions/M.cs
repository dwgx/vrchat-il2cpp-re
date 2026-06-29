// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 15
// Methods: 95

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class MemberAssignment : MemberBinding
    {
        public object _expression;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706A1B0
        public void get_Expression(){} // RVA: 0xB700F0
        public void Update(){} // RVA: 0x706A130
        public void ValidateAsDefinedHere(){} // RVA: 0xB43310
    }

    public class MemberBinding : Object
    {
        public object _bindingType;
        public object _member;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2574280
        public void get_BindingType(){} // RVA: 0xB8F8F0
        public void get_Member(){} // RVA: 0xB465B0
        public void ToString(){} // RVA: 0x7060AE0
        public void ValidateAsDefinedHere(){} // RVA: 0x706A1E0
    }

    public class MemberExpression : Expression
    {
        public object _expression;

        // ── Methods ──
        public void get_Member(){} // RVA: 0x11F4110
        public void get_Expression(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x706A600
        public void Make(){} // RVA: 0x706A430
        public void get_NodeType(){} // RVA: 0x10AC210
        public void GetMember(){} // RVA: 0x706A510
        public void Accept(){} // RVA: 0x706A540
        public void Update(){} // RVA: 0x706A570
    }

    public class MemberInitExpression : Expression
    {
        public object _newExpression;
        public object _bindings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706B3A0
        public void get_Type(){} // RVA: 0x10ACB60
        public void get_CanReduce(){} // RVA: 0xC2E4C0
        public void get_NodeType(){} // RVA: 0x2AFB690
        public void get_NewExpression(){} // RVA: 0xB5DBF0
        public void get_Bindings(){} // RVA: 0xB465B0
        public void Accept(){} // RVA: 0x706A810
        public void Reduce(){} // RVA: 0x706A840
        public void ReduceMemberInit(){} // RVA: 0x706A860
        public void ReduceListInit(){} // RVA: 0x706AC90
        public void ReduceMemberBinding(){} // RVA: 0x706B100
        public void Update(){} // RVA: 0x706B2D0
    }

    public class MemberListBinding : MemberBinding
    {
        public object _initializers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706B540
        public void get_Initializers(){} // RVA: 0xB700F0
        public void Update(){} // RVA: 0x706B490
        public void ValidateAsDefinedHere(){} // RVA: 0xB43310
    }

    public class MemberMemberBinding : MemberBinding
    {
        public object _bindings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706B620
        public void get_Bindings(){} // RVA: 0xB700F0
        public void Update(){} // RVA: 0x706B570
        public void ValidateAsDefinedHere(){} // RVA: 0xB43310
    }

    public class MethodBinaryExpression : SimpleBinaryExpression
    {
        public object _method;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x701F8D0
        public void GetMethod(){} // RVA: 0xD33E60
    }

    public class MethodCallExpression : Expression
    {
        public object _method;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706B930
        public void GetInstance(){} // RVA: 0xDAC980
        public void get_NodeType(){} // RVA: 0x13510C0
        public void get_Type(){} // RVA: 0x2710FE0
        public void get_Method(){} // RVA: 0xB5DBF0
        public void get_Object(){} // RVA: 0x14B3B70
        public void get_Arguments(){} // RVA: 0x487D930
        public void Update(){} // RVA: 0x706B6F0
        public void SameArguments(){} // RVA: 0x706B810
        public void GetOrMakeArguments(){} // RVA: 0x706B840
        public void Accept(){} // RVA: 0x706B870
        public void Rewrite(){} // RVA: 0x706B8A0
        public void GetArgument(){} // RVA: 0x706B8D0
        public void get_ArgumentCount(){} // RVA: 0x706B900
    }

    public class MethodCallExpression0 : MethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x706BF80
        public void GetArgument(){} // RVA: 0x706BF90
        public void get_ArgumentCount(){} // RVA: 0xDAC980
        public void GetOrMakeArguments(){} // RVA: 0x706BFE0
        public void SameArguments(){} // RVA: 0x706C040
        public void Rewrite(){} // RVA: 0x706C0A0
    }

    public class MethodCallExpression1 : MethodCallExpression
    {
        public object _arg0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706B960
        public void GetArgument(){} // RVA: 0x706C220
        public void get_ArgumentCount(){} // RVA: 0xC3CCE0
        public void GetOrMakeArguments(){} // RVA: 0x706C2C0
        public void SameArguments(){} // RVA: 0x706C2D0
        public void Rewrite(){} // RVA: 0x706C460
    }

    public class MethodCallExpression2 : MethodCallExpression
    {
        public object _arg0;
        public object _arg1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706BC50
        public void GetArgument(){} // RVA: 0x706C520
        public void get_ArgumentCount(){} // RVA: 0xC50A80
        public void SameArguments(){} // RVA: 0x706C5D0
        public void GetOrMakeArguments(){} // RVA: 0x706C2C0
        public void Rewrite(){} // RVA: 0x706C850
    }

    public class MethodCallExpression3 : MethodCallExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706C950
        public void GetArgument(){} // RVA: 0x706CA80
        public void get_ArgumentCount(){} // RVA: 0x12FC4A0
        public void SameArguments(){} // RVA: 0x706CB40
        public void GetOrMakeArguments(){} // RVA: 0x706C2C0
        public void Rewrite(){} // RVA: 0x706CE00
    }

    public class MethodCallExpression4 : MethodCallExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;
        public object _arg3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706CF30
        public void GetArgument(){} // RVA: 0x706D0B0
        public void get_ArgumentCount(){} // RVA: 0x1347420
        public void SameArguments(){} // RVA: 0x706D190
        public void GetOrMakeArguments(){} // RVA: 0x706C2C0
        public void Rewrite(){} // RVA: 0x706D490
    }

    public class MethodCallExpression5 : MethodCallExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;
        public object _arg3;
        public object _arg4;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706D5F0
        public void GetArgument(){} // RVA: 0x706D7D0
        public void get_ArgumentCount(){} // RVA: 0xEF4110
        public void SameArguments(){} // RVA: 0x706D8C0
        public void GetOrMakeArguments(){} // RVA: 0x706C2C0
        public void Rewrite(){} // RVA: 0x706DC00
    }

    public class MethodCallExpressionN : MethodCallExpression
    {
        public object _arguments;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706B960
        public void GetArgument(){} // RVA: 0x706B9D0
        public void get_ArgumentCount(){} // RVA: 0x706BA30
        public void GetOrMakeArguments(){} // RVA: 0x706BA80
        public void SameArguments(){} // RVA: 0x706BAC0
        public void Rewrite(){} // RVA: 0x706BBA0
    }

}