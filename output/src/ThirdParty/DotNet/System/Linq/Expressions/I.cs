// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 18
// Methods: 99

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class IArgumentProvider
    {
        // ── Methods ──
        public void GetArgument(){} // RVA: 0x7FFE80E3D230
        public void get_ArgumentCount(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IDynamicExpression
    {
        // ── Methods ──
        public void get_DelegateType(){} // RVA: 0x7FFE80E2E2E0
        public void Rewrite(){} // RVA: 0x7FFE80E2E390
        public void CreateCallSite(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IParameterProvider
    {
        // ── Methods ──
        public void GetParameter(){} // RVA: 0x7FFE80E3D230
        public void get_ParameterCount(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IndexExpression : Expression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> _arguments; // 0x10
        public System.Linq.Expressions.Expression _object; // 0x18
        public System.Reflection.PropertyInfo _indexer; // 0x20
        public object field_3; // 0x191
        public object field_4; // 0x192
        public object field_5; // 0x193

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87139010 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFE87138C00
        public void get_Type(){} // RVA: 0x7FFE87138C10
        public void get_Object(){} // RVA: 0x7FFE810FE7C0
        public void get_Indexer(){} // RVA: 0x7FFE811290C0
        public void get_Arguments(){} // RVA: 0x7FFE87138C80
        public void Update(){} // RVA: 0x7FFE87138CC0
        public void GetArgument(){} // RVA: 0x7FFE87138E40
        public void get_ArgumentCount(){} // RVA: 0x7FFE87138EA0
        public void Accept(){} // RVA: 0x7FFE87138EF0
        public void Rewrite(){} // RVA: 0x7FFE87138F20
    }

    public class InstanceMethodCallExpression : MethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713CA10
        public void GetInstance(){} // RVA: 0x7FFE810FE7C0
    }

    public class InstanceMethodCallExpression0 : InstanceMethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713CA10
        public void GetArgument(){} // RVA: 0x7FFE8713EE60
        public void get_ArgumentCount(){} // RVA: 0x7FFE813240E0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE8713EEB0
        public void SameArguments(){} // RVA: 0x7FFE8713EF10
        public void Rewrite(){} // RVA: 0x7FFE8713EF70
    }

    public class InstanceMethodCallExpression1 : InstanceMethodCallExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713CD00
        public void GetArgument(){} // RVA: 0x7FFE8713EFE0
        public void get_ArgumentCount(){} // RVA: 0x7FFE811EDAF0
        public void SameArguments(){} // RVA: 0x7FFE8713F080
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void Rewrite(){} // RVA: 0x7FFE8713F200
    }

    public class InstanceMethodCallExpression2 : InstanceMethodCallExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713DA00
        public void GetArgument(){} // RVA: 0x7FFE8713F2D0
        public void get_ArgumentCount(){} // RVA: 0x7FFE81200CB0
        public void SameArguments(){} // RVA: 0x7FFE8713F380
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void Rewrite(){} // RVA: 0x7FFE8713F600
    }

    public class InstanceMethodCallExpression3 : InstanceMethodCallExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713DFF0
        public void GetArgument(){} // RVA: 0x7FFE8713F710
        public void get_ArgumentCount(){} // RVA: 0x7FFE817BF630
        public void SameArguments(){} // RVA: 0x7FFE8713F7D0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void Rewrite(){} // RVA: 0x7FFE8713FAA0
    }

    public class InstanceMethodCallExpressionN : InstanceMethodCallExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> _arguments; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713CD00
        public void GetArgument(){} // RVA: 0x7FFE8713CDE0
        public void get_ArgumentCount(){} // RVA: 0x7FFE8713CE40
        public void SameArguments(){} // RVA: 0x7FFE8713CE90
        public void GetOrMakeArguments(){} // RVA: 0x7FFE8713CF70
        public void Rewrite(){} // RVA: 0x7FFE8713CFB0
    }

    public class InvocationExpression : Expression
    {
        public System.Type _type; // 0x10
        public System.Linq.Expressions.Expression _expression; // 0x18
        public object field_2; // 0x197
        public object field_3; // 0x198
        public object field_4; // 0x199
        public object field_5; // 0x19A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87139480 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_NodeType(){} // RVA: 0x7FFE86BADF70
        public void get_Expression(){} // RVA: 0x7FFE810FE7C0
        public void get_Arguments(){} // RVA: 0x7FFE81980F70
        public void Update(){} // RVA: 0x7FFE87139150
        public void GetOrMakeArguments(){} // RVA: 0x7FFE87139240
        public void GetArgument(){} // RVA: 0x7FFE87139270
        public void get_ArgumentCount(){} // RVA: 0x7FFE871392A0
        public void Accept(){} // RVA: 0x7FFE871392D0
        public void Rewrite(){} // RVA: 0x7FFE87139300
        public void get_LambdaOperand(){} // RVA: 0x7FFE87139330
    }

    public class InvocationExpression0 : InvocationExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87139690
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871396A0
        public void GetArgument(){} // RVA: 0x7FFE87139700
        public void get_ArgumentCount(){} // RVA: 0x7FFE813240E0
        public void Rewrite(){} // RVA: 0x7FFE87139750
    }

    public class InvocationExpression1 : InvocationExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871397A0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void GetArgument(){} // RVA: 0x7FFE87139810
        public void get_ArgumentCount(){} // RVA: 0x7FFE811EDAF0
        public void Rewrite(){} // RVA: 0x7FFE871398B0
    }

    public class InvocationExpression2 : InvocationExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87139960
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void GetArgument(){} // RVA: 0x7FFE87139A40
        public void get_ArgumentCount(){} // RVA: 0x7FFE81200CB0
        public void Rewrite(){} // RVA: 0x7FFE87139AF0
    }

    public class InvocationExpression3 : InvocationExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87139BD0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void GetArgument(){} // RVA: 0x7FFE87139D00
        public void get_ArgumentCount(){} // RVA: 0x7FFE817BF630
        public void Rewrite(){} // RVA: 0x7FFE87139DC0
    }

    public class InvocationExpression4 : InvocationExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87139EC0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void GetArgument(){} // RVA: 0x7FFE8713A040
        public void get_ArgumentCount(){} // RVA: 0x7FFE8180E590
        public void Rewrite(){} // RVA: 0x7FFE8713A120
    }

    public class InvocationExpression5 : InvocationExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8713A250
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void GetArgument(){} // RVA: 0x7FFE8713A430
        public void get_ArgumentCount(){} // RVA: 0x7FFE81474A10
        public void Rewrite(){} // RVA: 0x7FFE8713A520
    }

    public class InvocationExpressionN : InvocationExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> _arguments; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871394B0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE87139520
        public void GetArgument(){} // RVA: 0x7FFE87139560
        public void get_ArgumentCount(){} // RVA: 0x7FFE871395C0
        public void Rewrite(){} // RVA: 0x7FFE87139610
    }

}