// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 15
// Methods: 103

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class MemberAssignment : MemberBinding
    {
        public System.Linq.Expressions.Expression Expression; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D92E40 | overloaded x2
        public void get_Expression(){} // RVA: 0x7FFAC2F4F0C0
        public void Update(){} // RVA: 0x7FFAC8D92DC0
        public void ValidateAsDefinedHere(){} // RVA: 0x7FFAC2F21310
    }

    public class MemberBinding : Object
    {
        public 0x6B1ECEE0 BindingType; // 0x10
        public System.Reflection.MemberInfo Member; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB5F0
        public void get_BindingType(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Member(){} // RVA: 0x7FFAC2F247C0
        public void ToString(){} // RVA: 0x7FFAC8D89690
        public void ValidateAsDefinedHere(){} // RVA: 0x7FFAC8D92E70
    }

    public class MemberExpression : Expression
    {
        public System.Linq.Expressions.Expression Member; // 0x10

        // ── Methods ──
        public void get_Member(){} // RVA: 0x7FFAC3F5BE50
        public void get_Expression(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC8D932A0 | overloaded x2
        public void Make(){} // RVA: 0x7FFAC8D930C0 | overloaded x3
        public void get_NodeType(){} // RVA: 0x7FFAC3641DE0
        public void GetMember(){} // RVA: 0x7FFAC8D931B0
        public void Accept(){} // RVA: 0x7FFAC8D931E0
        public void Update(){} // RVA: 0x7FFAC8D93210
    }

    public class MemberInitExpression : Expression
    {
        public System.Linq.Expressions.NewExpression Type; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.MemberBinding> CanReduce; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D94020 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC87BB0A0
        public void get_CanReduce(){} // RVA: 0x7FFAC3006850
        public void get_NodeType(){} // RVA: 0x7FFAC530B550
        public void get_NewExpression(){} // RVA: 0x7FFAC2F3C380
        public void get_Bindings(){} // RVA: 0x7FFAC2F247C0
        public void Accept(){} // RVA: 0x7FFAC8D934B0
        public void Reduce(){} // RVA: 0x7FFAC8D934E0
        public void ReduceMemberInit(){} // RVA: 0x7FFAC8D93500
        public void ReduceListInit(){} // RVA: 0x7FFAC8D93930
        public void ReduceMemberBinding(){} // RVA: 0x7FFAC8D93D80
        public void Update(){} // RVA: 0x7FFAC8D93F50
    }

    public class MemberListBinding : MemberBinding
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ElementInit> Initializers; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D941C0 | overloaded x2
        public void get_Initializers(){} // RVA: 0x7FFAC2F4F0C0
        public void Update(){} // RVA: 0x7FFAC8D94110
        public void ValidateAsDefinedHere(){} // RVA: 0x7FFAC2F21310
    }

    public class MemberMemberBinding : MemberBinding
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.MemberBinding> Bindings; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D942A0 | overloaded x2
        public void get_Bindings(){} // RVA: 0x7FFAC2F4F0C0
        public void Update(){} // RVA: 0x7FFAC8D941F0
        public void ValidateAsDefinedHere(){} // RVA: 0x7FFAC2F21310
    }

    public class MethodBinaryExpression : SimpleBinaryExpression
    {
        public System.Reflection.MethodInfo _method; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D47B90
        public void GetMethod(){} // RVA: 0x7FFAC31D95E0
    }

    public class MethodCallExpression : Expression
    {
        public System.Reflection.MethodInfo NodeType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D945B0 | overloaded x2
        public void GetInstance(){} // RVA: 0x7FFAC34F9180
        public void get_NodeType(){} // RVA: 0x7FFAC36A9850
        public void get_Type(){} // RVA: 0x7FFAC49AD6D0
        public void get_Method(){} // RVA: 0x7FFAC2F3C380
        public void get_Object(){} // RVA: 0x7FFAC3825740
        public void get_Arguments(){} // RVA: 0x7FFAC8AEC8C0
        public void Update(){} // RVA: 0x7FFAC8D94370
        public void SameArguments(){} // RVA: 0x7FFAC8D94490
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D944C0
        public void Accept(){} // RVA: 0x7FFAC8D944F0
        public void Rewrite(){} // RVA: 0x7FFAC8D94520
        public void GetArgument(){} // RVA: 0x7FFAC8D94550
        public void get_ArgumentCount(){} // RVA: 0x7FFAC8D94580
    }

    public class MethodCallExpression0 : MethodCallExpression
    {
        public object ArgumentCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D94C10
        public void GetArgument(){} // RVA: 0x7FFAC8D94C20
        public void get_ArgumentCount(){} // RVA: 0x7FFAC34F9180
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D94C70
        public void SameArguments(){} // RVA: 0x7FFAC8D94CD0
        public void Rewrite(){} // RVA: 0x7FFAC8D94D30
    }

    public class MethodCallExpression1 : MethodCallExpression
    {
        public object ArgumentCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D945E0
        public void GetArgument(){} // RVA: 0x7FFAC8D94EB0
        public void get_ArgumentCount(){} // RVA: 0x7FFAC3013AF0
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D94F50
        public void SameArguments(){} // RVA: 0x7FFAC8D94F60
        public void Rewrite(){} // RVA: 0x7FFAC8D950E0
    }

    public class MethodCallExpression2 : MethodCallExpression
    {
        public object ArgumentCount; // 0x18
        public System.Linq.Expressions.Expression _arg1; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D948D0
        public void GetArgument(){} // RVA: 0x7FFAC8D951A0
        public void get_ArgumentCount(){} // RVA: 0x7FFAC3026CB0
        public void SameArguments(){} // RVA: 0x7FFAC8D95250
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D94F50
        public void Rewrite(){} // RVA: 0x7FFAC8D954D0
    }

    public class MethodCallExpression3 : MethodCallExpression
    {
        public object ArgumentCount; // 0x18
        public System.Linq.Expressions.Expression _arg1; // 0x20
        public System.Linq.Expressions.Expression _arg2; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D955D0
        public void GetArgument(){} // RVA: 0x7FFAC8D95700
        public void get_ArgumentCount(){} // RVA: 0x7FFAC366FE20
        public void SameArguments(){} // RVA: 0x7FFAC8D957C0
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D94F50
        public void Rewrite(){} // RVA: 0x7FFAC8D95A90
    }

    public class MethodCallExpression4 : MethodCallExpression
    {
        public object ArgumentCount; // 0x18
        public System.Linq.Expressions.Expression _arg1; // 0x20
        public System.Linq.Expressions.Expression _arg2; // 0x28
        public System.Linq.Expressions.Expression _arg3; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D95BC0
        public void GetArgument(){} // RVA: 0x7FFAC8D95D40
        public void get_ArgumentCount(){} // RVA: 0x7FFAC36C3910
        public void SameArguments(){} // RVA: 0x7FFAC8D95E20
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D94F50
        public void Rewrite(){} // RVA: 0x7FFAC8D96130
    }

    public class MethodCallExpression5 : MethodCallExpression
    {
        public object ArgumentCount; // 0x18
        public System.Linq.Expressions.Expression _arg1; // 0x20
        public System.Linq.Expressions.Expression _arg2; // 0x28
        public System.Linq.Expressions.Expression _arg3; // 0x30
        public System.Linq.Expressions.Expression _arg4; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D96290
        public void GetArgument(){} // RVA: 0x7FFAC8D96470
        public void get_ArgumentCount(){} // RVA: 0x7FFAC31E48B0
        public void SameArguments(){} // RVA: 0x7FFAC8D96560
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D94F50
        public void Rewrite(){} // RVA: 0x7FFAC8D968B0
    }

    public class MethodCallExpressionN : MethodCallExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> ArgumentCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D945E0
        public void GetArgument(){} // RVA: 0x7FFAC8D94650
        public void get_ArgumentCount(){} // RVA: 0x7FFAC8D946B0
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D94700
        public void SameArguments(){} // RVA: 0x7FFAC8D94740
        public void Rewrite(){} // RVA: 0x7FFAC8D94820
    }

}