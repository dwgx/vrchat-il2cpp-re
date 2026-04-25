// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 18
// Methods: 99

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class IArgumentProvider
    {
        public object ArgumentCount;

        // ── Methods ──
        public void GetArgument(){} // RVA: 0x7FFAC2C67DE0
        public void get_ArgumentCount(){} // RVA: 0x7FFAC2C59960
    }

    public class IDynamicExpression
    {
        public object DelegateType;

        // ── Methods ──
        public void get_DelegateType(){} // RVA: 0x7FFAC2C58E90
        public void Rewrite(){} // RVA: 0x7FFAC2C58F40
        public void CreateCallSite(){} // RVA: 0x7FFAC2C58E90
    }

    public class IParameterProvider
    {
        public object ParameterCount;

        // ── Methods ──
        public void GetParameter(){} // RVA: 0x7FFAC2C67DE0
        public void get_ParameterCount(){} // RVA: 0x7FFAC2C59960
    }

    public class IndexExpression : Expression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> NodeType; // 0x10
        public System.Linq.Expressions.Expression Type; // 0x18
        public System.Reflection.PropertyInfo Object; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D90BE0 | overloaded x2
        public void get_NodeType(){} // RVA: 0x7FFAC8D907D0
        public void get_Type(){} // RVA: 0x7FFAC8D907E0
        public void get_Object(){} // RVA: 0x7FFAC2F247C0
        public void get_Indexer(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Arguments(){} // RVA: 0x7FFAC8D90850
        public void Update(){} // RVA: 0x7FFAC8D90890
        public void GetArgument(){} // RVA: 0x7FFAC8D90A10
        public void get_ArgumentCount(){} // RVA: 0x7FFAC8D90A70
        public void Accept(){} // RVA: 0x7FFAC8D90AC0
        public void Rewrite(){} // RVA: 0x7FFAC8D90AF0
    }

    public class InstanceMethodCallExpression : MethodCallExpression
    {
        public System.Linq.Expressions.Expression _instance; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D945E0
        public void GetInstance(){} // RVA: 0x7FFAC2F247C0
    }

    public class InstanceMethodCallExpression0 : InstanceMethodCallExpression
    {
        public object ArgumentCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D945E0
        public void GetArgument(){} // RVA: 0x7FFAC8D96A30
        public void get_ArgumentCount(){} // RVA: 0x7FFAC34F9180
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D96A80
        public void SameArguments(){} // RVA: 0x7FFAC8D96AE0
        public void Rewrite(){} // RVA: 0x7FFAC8D96B40
    }

    public class InstanceMethodCallExpression1 : InstanceMethodCallExpression
    {
        public object ArgumentCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D948D0
        public void GetArgument(){} // RVA: 0x7FFAC8D96BB0
        public void get_ArgumentCount(){} // RVA: 0x7FFAC3013AF0
        public void SameArguments(){} // RVA: 0x7FFAC8D96C50
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void Rewrite(){} // RVA: 0x7FFAC8D96DD0
    }

    public class InstanceMethodCallExpression2 : InstanceMethodCallExpression
    {
        public object ArgumentCount; // 0x20
        public System.Linq.Expressions.Expression _arg1; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D955D0
        public void GetArgument(){} // RVA: 0x7FFAC8D96EA0
        public void get_ArgumentCount(){} // RVA: 0x7FFAC3026CB0
        public void SameArguments(){} // RVA: 0x7FFAC8D96F50
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void Rewrite(){} // RVA: 0x7FFAC8D971D0
    }

    public class InstanceMethodCallExpression3 : InstanceMethodCallExpression
    {
        public object ArgumentCount; // 0x20
        public System.Linq.Expressions.Expression _arg1; // 0x28
        public System.Linq.Expressions.Expression _arg2; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D95BC0
        public void GetArgument(){} // RVA: 0x7FFAC8D972E0
        public void get_ArgumentCount(){} // RVA: 0x7FFAC366FE20
        public void SameArguments(){} // RVA: 0x7FFAC8D973A0
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void Rewrite(){} // RVA: 0x7FFAC8D97670
    }

    public class InstanceMethodCallExpressionN : InstanceMethodCallExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> ArgumentCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D948D0
        public void GetArgument(){} // RVA: 0x7FFAC8D949B0
        public void get_ArgumentCount(){} // RVA: 0x7FFAC8D94A10
        public void SameArguments(){} // RVA: 0x7FFAC8D94A60
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D94B40
        public void Rewrite(){} // RVA: 0x7FFAC8D94B80
    }

    public class InvocationExpression : Expression
    {
        public System.Type Type; // 0x10
        public System.Linq.Expressions.Expression NodeType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D91050 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_NodeType(){} // RVA: 0x7FFAC8804850
        public void get_Expression(){} // RVA: 0x7FFAC2F247C0
        public void get_Arguments(){} // RVA: 0x7FFAC3825740
        public void Update(){} // RVA: 0x7FFAC8D90D20
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D90E10
        public void GetArgument(){} // RVA: 0x7FFAC8D90E40
        public void get_ArgumentCount(){} // RVA: 0x7FFAC8D90E70
        public void Accept(){} // RVA: 0x7FFAC8D90EA0
        public void Rewrite(){} // RVA: 0x7FFAC8D90ED0
        public void get_LambdaOperand(){} // RVA: 0x7FFAC8D90F00
    }

    public class InvocationExpression0 : InvocationExpression
    {
        public object ArgumentCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D91260
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D91270
        public void GetArgument(){} // RVA: 0x7FFAC8D912D0
        public void get_ArgumentCount(){} // RVA: 0x7FFAC34F9180
        public void Rewrite(){} // RVA: 0x7FFAC8D91320
    }

    public class InvocationExpression1 : InvocationExpression
    {
        public object ArgumentCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D91370
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void GetArgument(){} // RVA: 0x7FFAC8D913E0
        public void get_ArgumentCount(){} // RVA: 0x7FFAC3013AF0
        public void Rewrite(){} // RVA: 0x7FFAC8D91480
    }

    public class InvocationExpression2 : InvocationExpression
    {
        public object ArgumentCount; // 0x20
        public System.Linq.Expressions.Expression _arg1; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D91530
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void GetArgument(){} // RVA: 0x7FFAC8D91610
        public void get_ArgumentCount(){} // RVA: 0x7FFAC3026CB0
        public void Rewrite(){} // RVA: 0x7FFAC8D916C0
    }

    public class InvocationExpression3 : InvocationExpression
    {
        public object ArgumentCount; // 0x20
        public System.Linq.Expressions.Expression _arg1; // 0x28
        public System.Linq.Expressions.Expression _arg2; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D917A0
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void GetArgument(){} // RVA: 0x7FFAC8D918D0
        public void get_ArgumentCount(){} // RVA: 0x7FFAC366FE20
        public void Rewrite(){} // RVA: 0x7FFAC8D91990
    }

    public class InvocationExpression4 : InvocationExpression
    {
        public object ArgumentCount; // 0x20
        public System.Linq.Expressions.Expression _arg1; // 0x28
        public System.Linq.Expressions.Expression _arg2; // 0x30
        public System.Linq.Expressions.Expression _arg3; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D91A90
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void GetArgument(){} // RVA: 0x7FFAC8D91C10
        public void get_ArgumentCount(){} // RVA: 0x7FFAC36C3910
        public void Rewrite(){} // RVA: 0x7FFAC8D91CF0
    }

    public class InvocationExpression5 : InvocationExpression
    {
        public object ArgumentCount; // 0x20
        public System.Linq.Expressions.Expression _arg1; // 0x28
        public System.Linq.Expressions.Expression _arg2; // 0x30
        public System.Linq.Expressions.Expression _arg3; // 0x38
        public System.Linq.Expressions.Expression _arg4; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D91E20
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void GetArgument(){} // RVA: 0x7FFAC8D92000
        public void get_ArgumentCount(){} // RVA: 0x7FFAC31E48B0
        public void Rewrite(){} // RVA: 0x7FFAC8D920F0
    }

    public class InvocationExpressionN : InvocationExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> ArgumentCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D91080
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D910F0
        public void GetArgument(){} // RVA: 0x7FFAC8D91130
        public void get_ArgumentCount(){} // RVA: 0x7FFAC8D91190
        public void Rewrite(){} // RVA: 0x7FFAC8D911E0
    }

}