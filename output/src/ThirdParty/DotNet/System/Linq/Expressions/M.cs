// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 15
// Methods: 103

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class MemberAssignment : MemberBinding
    {
        public System.Linq.Expressions.Expression _expression; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713B270 | overloaded x2
        public void get_Expression(){} // RVA: 0x7FFE811290C0
        public void Update(){} // RVA: 0x7FFE8713B1F0
        public void ValidateAsDefinedHere(){} // RVA: 0x7FFE810FB310
    }

    public class MemberBinding : Object
    {
        public 0x665E67A4 _bindingType; // 0x10
        public System.Reflection.MemberInfo _member; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A53990
        public void get_BindingType(){} // RVA: 0x7FFE811485C0
        public void get_Member(){} // RVA: 0x7FFE810FE7C0
        public void ToString(){} // RVA: 0x7FFE87131AC0
        public void ValidateAsDefinedHere(){} // RVA: 0x7FFE8713B2A0
    }

    public class MemberExpression : Expression
    {
        public System.Linq.Expressions.Expression _expression; // 0x10
        public object field_1; // 0x1CD
        public object field_2; // 0x1CE

        // ── Methods ──
        public void get_Member(){} // RVA: 0x7FFE844800F0
        public void get_Expression(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE8713B6D0 | overloaded x2
        public void Make(){} // RVA: 0x7FFE8713B4F0 | overloaded x3
        public void get_NodeType(){} // RVA: 0x7FFE8178CF30
        public void GetMember(){} // RVA: 0x7FFE8713B5E0
        public void Accept(){} // RVA: 0x7FFE8713B610
        public void Update(){} // RVA: 0x7FFE8713B640
    }

    public class MemberInitExpression : Expression
    {
        public System.Linq.Expressions.NewExpression _newExpression; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.MemberBinding> _bindings; // 0x18
        public object field_2; // 0x1D2
        public object field_3; // 0x1D3
        public object field_4; // 0x1D4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713C450 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE815888E0
        public void get_CanReduce(){} // RVA: 0x7FFE811E0850
        public void get_NodeType(){} // RVA: 0x7FFE835C1D90
        public void get_NewExpression(){} // RVA: 0x7FFE81116380
        public void get_Bindings(){} // RVA: 0x7FFE810FE7C0
        public void Accept(){} // RVA: 0x7FFE8713B8E0
        public void Reduce(){} // RVA: 0x7FFE8713B910
        public void ReduceMemberInit(){} // RVA: 0x7FFE8713B930
        public void ReduceListInit(){} // RVA: 0x7FFE8713BD60
        public void ReduceMemberBinding(){} // RVA: 0x7FFE8713C1B0
        public void Update(){} // RVA: 0x7FFE8713C380
    }

    public class MemberListBinding : MemberBinding
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ElementInit> _initializers; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713C5F0 | overloaded x2
        public void get_Initializers(){} // RVA: 0x7FFE811290C0
        public void Update(){} // RVA: 0x7FFE8713C540
        public void ValidateAsDefinedHere(){} // RVA: 0x7FFE810FB310
    }

    public class MemberMemberBinding : MemberBinding
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.MemberBinding> _bindings; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713C6D0 | overloaded x2
        public void get_Bindings(){} // RVA: 0x7FFE811290C0
        public void Update(){} // RVA: 0x7FFE8713C620
        public void ValidateAsDefinedHere(){} // RVA: 0x7FFE810FB310
    }

    public class MethodBinaryExpression : SimpleBinaryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870F0050
        public void GetMethod(){} // RVA: 0x7FFE8144E200
    }

    public class MethodCallExpression : Expression
    {
        public System.Reflection.MethodInfo _method; // 0x10
        public object field_1; // 0x1D9
        public object field_2; // 0x1DA
        public object field_3; // 0x1DB
        public object field_4; // 0x1DC
        public object field_5; // 0x1DD

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713C9E0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFE813240E0
        public void get_NodeType(){} // RVA: 0x7FFE81815210
        public void get_Type(){} // RVA: 0x7FFE82C191D0
        public void get_Method(){} // RVA: 0x7FFE81116380
        public void get_Object(){} // RVA: 0x7FFE81980F70
        public void get_Arguments(){} // RVA: 0x7FFE82215450
        public void Update(){} // RVA: 0x7FFE8713C7A0
        public void SameArguments(){} // RVA: 0x7FFE8713C8C0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE8713C8F0
        public void Accept(){} // RVA: 0x7FFE8713C920
        public void Rewrite(){} // RVA: 0x7FFE8713C950
        public void GetArgument(){} // RVA: 0x7FFE8713C980
        public void get_ArgumentCount(){} // RVA: 0x7FFE8713C9B0
    }

    public class MethodCallExpression0 : MethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713D040
        public void GetArgument(){} // RVA: 0x7FFE8713D050
        public void get_ArgumentCount(){} // RVA: 0x7FFE813240E0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE8713D0A0
        public void SameArguments(){} // RVA: 0x7FFE8713D100
        public void Rewrite(){} // RVA: 0x7FFE8713D160
    }

    public class MethodCallExpression1 : MethodCallExpression
    {
        public object _arg0; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713CA10
        public void GetArgument(){} // RVA: 0x7FFE8713D2E0
        public void get_ArgumentCount(){} // RVA: 0x7FFE811EDAF0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE8713D380
        public void SameArguments(){} // RVA: 0x7FFE8713D390
        public void Rewrite(){} // RVA: 0x7FFE8713D510
    }

    public class MethodCallExpression2 : MethodCallExpression
    {
        public object _arg0; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713CD00
        public void GetArgument(){} // RVA: 0x7FFE8713D5D0
        public void get_ArgumentCount(){} // RVA: 0x7FFE81200CB0
        public void SameArguments(){} // RVA: 0x7FFE8713D680
        public void GetOrMakeArguments(){} // RVA: 0x7FFE8713D380
        public void Rewrite(){} // RVA: 0x7FFE8713D900
    }

    public class MethodCallExpression3 : MethodCallExpression
    {
        public object _arg0; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713DA00
        public void GetArgument(){} // RVA: 0x7FFE8713DB30
        public void get_ArgumentCount(){} // RVA: 0x7FFE817BF630
        public void SameArguments(){} // RVA: 0x7FFE8713DBF0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE8713D380
        public void Rewrite(){} // RVA: 0x7FFE8713DEC0
    }

    public class MethodCallExpression4 : MethodCallExpression
    {
        public object _arg0; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713DFF0
        public void GetArgument(){} // RVA: 0x7FFE8713E170
        public void get_ArgumentCount(){} // RVA: 0x7FFE8180E590
        public void SameArguments(){} // RVA: 0x7FFE8713E250
        public void GetOrMakeArguments(){} // RVA: 0x7FFE8713D380
        public void Rewrite(){} // RVA: 0x7FFE8713E560
    }

    public class MethodCallExpression5 : MethodCallExpression
    {
        public object _arg0; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713E6C0
        public void GetArgument(){} // RVA: 0x7FFE8713E8A0
        public void get_ArgumentCount(){} // RVA: 0x7FFE81474A10
        public void SameArguments(){} // RVA: 0x7FFE8713E990
        public void GetOrMakeArguments(){} // RVA: 0x7FFE8713D380
        public void Rewrite(){} // RVA: 0x7FFE8713ECE0
    }

    public class MethodCallExpressionN : MethodCallExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> _arguments; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713CA10
        public void GetArgument(){} // RVA: 0x7FFE8713CA80
        public void get_ArgumentCount(){} // RVA: 0x7FFE8713CAE0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE8713CB30
        public void SameArguments(){} // RVA: 0x7FFE8713CB70
        public void Rewrite(){} // RVA: 0x7FFE8713CC50
    }

}