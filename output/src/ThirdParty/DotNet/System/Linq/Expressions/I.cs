// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 18
// Methods: 97

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class IArgumentProvider
    {
        // ── Methods ──
        public void GetArgument(){} // RVA: 0x87C160
        public void get_ArgumentCount(){} // RVA: 0x87C130
    }

    public class IDynamicExpression
    {
        // ── Methods ──
        public void get_DelegateType(){} // RVA: 0x87C0A0
        public void Rewrite(){} // RVA: 0x87C540
        public void CreateCallSite(){} // RVA: 0x87C0A0
    }

    public class IParameterProvider
    {
        // ── Methods ──
        public void GetParameter(){} // RVA: 0x87C160
        public void get_ParameterCount(){} // RVA: 0x87C130
    }

    public class IndexExpression : Expression
    {
        public object _arguments;
        public object _object;
        public object _indexer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7067F80
        public void get_NodeType(){} // RVA: 0x7067B70
        public void get_Type(){} // RVA: 0x7067B80
        public void get_Object(){} // RVA: 0xB465B0
        public void get_Indexer(){} // RVA: 0xB700F0
        public void get_Arguments(){} // RVA: 0x7067BF0
        public void Update(){} // RVA: 0x7067C30
        public void GetArgument(){} // RVA: 0x7067DB0
        public void get_ArgumentCount(){} // RVA: 0x7067E10
        public void Accept(){} // RVA: 0x7067E60
        public void Rewrite(){} // RVA: 0x7067E90
    }

    public class InstanceMethodCallExpression : MethodCallExpression
    {
        public object _instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706B960
        public void GetInstance(){} // RVA: 0xB465B0
    }

    public class InstanceMethodCallExpression0 : InstanceMethodCallExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x706B960
        public void GetArgument(){} // RVA: 0x706DD80
        public void get_ArgumentCount(){} // RVA: 0xDAC980
        public void GetOrMakeArguments(){} // RVA: 0x706DDD0
        public void SameArguments(){} // RVA: 0x706DE30
        public void Rewrite(){} // RVA: 0x706DE90
    }

    public class InstanceMethodCallExpression1 : InstanceMethodCallExpression
    {
        public object _arg0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706BC50
        public void GetArgument(){} // RVA: 0x706DF00
        public void get_ArgumentCount(){} // RVA: 0xC3CCE0
        public void SameArguments(){} // RVA: 0x706DFA0
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void Rewrite(){} // RVA: 0x706E130
    }

    public class InstanceMethodCallExpression2 : InstanceMethodCallExpression
    {
        public object _arg0;
        public object _arg1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706C950
        public void GetArgument(){} // RVA: 0x706E200
        public void get_ArgumentCount(){} // RVA: 0xC50A80
        public void SameArguments(){} // RVA: 0x706E2B0
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void Rewrite(){} // RVA: 0x706E530
    }

    public class InstanceMethodCallExpression3 : InstanceMethodCallExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706CF30
        public void GetArgument(){} // RVA: 0x706E640
        public void get_ArgumentCount(){} // RVA: 0x12FC4A0
        public void SameArguments(){} // RVA: 0x706E700
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void Rewrite(){} // RVA: 0x706E9C0
    }

    public class InstanceMethodCallExpressionN : InstanceMethodCallExpression
    {
        public object _arguments;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706BC50
        public void GetArgument(){} // RVA: 0x706BD30
        public void get_ArgumentCount(){} // RVA: 0x706BD90
        public void SameArguments(){} // RVA: 0x706BDE0
        public void GetOrMakeArguments(){} // RVA: 0x706BEC0
        public void Rewrite(){} // RVA: 0x706BF00
    }

    public class InvocationExpression : Expression
    {
        public object _type;
        public object _expression;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70683E0
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_NodeType(){} // RVA: 0x6AE0A80
        public void get_Expression(){} // RVA: 0xB465B0
        public void get_Arguments(){} // RVA: 0x14B3B70
        public void Update(){} // RVA: 0x70680C0
        public void GetOrMakeArguments(){} // RVA: 0x70681B0
        public void GetArgument(){} // RVA: 0x70681E0
        public void get_ArgumentCount(){} // RVA: 0x7068210
        public void Accept(){} // RVA: 0x7068240
        public void Rewrite(){} // RVA: 0x7068270
        public void get_LambdaOperand(){} // RVA: 0x70682A0
    }

    public class InvocationExpression0 : InvocationExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70685F0
        public void GetOrMakeArguments(){} // RVA: 0x7068600
        public void GetArgument(){} // RVA: 0x7068660
        public void get_ArgumentCount(){} // RVA: 0xDAC980
        public void Rewrite(){} // RVA: 0x70686B0
    }

    public class InvocationExpression1 : InvocationExpression
    {
        public object _arg0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7068700
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void GetArgument(){} // RVA: 0x7068770
        public void get_ArgumentCount(){} // RVA: 0xC3CCE0
        public void Rewrite(){} // RVA: 0x7068810
    }

    public class InvocationExpression2 : InvocationExpression
    {
        public object _arg0;
        public object _arg1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70688C0
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void GetArgument(){} // RVA: 0x70689A0
        public void get_ArgumentCount(){} // RVA: 0xC50A80
        public void Rewrite(){} // RVA: 0x7068A50
    }

    public class InvocationExpression3 : InvocationExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7068B30
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void GetArgument(){} // RVA: 0x7068C60
        public void get_ArgumentCount(){} // RVA: 0x12FC4A0
        public void Rewrite(){} // RVA: 0x7068D20
    }

    public class InvocationExpression4 : InvocationExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;
        public object _arg3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7068E20
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void GetArgument(){} // RVA: 0x7068FA0
        public void get_ArgumentCount(){} // RVA: 0x1347420
        public void Rewrite(){} // RVA: 0x7069080
    }

    public class InvocationExpression5 : InvocationExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;
        public object _arg3;
        public object _arg4;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70691B0
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void GetArgument(){} // RVA: 0x7069390
        public void get_ArgumentCount(){} // RVA: 0xEF4110
        public void Rewrite(){} // RVA: 0x7069480
    }

    public class InvocationExpressionN : InvocationExpression
    {
        public object _arguments;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7068410
        public void GetOrMakeArguments(){} // RVA: 0x7068480
        public void GetArgument(){} // RVA: 0x70684C0
        public void get_ArgumentCount(){} // RVA: 0x7068520
        public void Rewrite(){} // RVA: 0x7068570
    }

}