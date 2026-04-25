// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 10
// Methods: 158

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class DebugInfoExpression : Expression
    {
        public System.Linq.Expressions.SymbolDocumentInfo Type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D770A0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC8D76ED0
        public void get_NodeType(){} // RVA: 0x7FFAC530BFD0
        public void get_StartLine(){} // RVA: 0x7FFAC8D76F80
        public void get_StartColumn(){} // RVA: 0x7FFAC8D76FB0
        public void get_EndLine(){} // RVA: 0x7FFAC8D76FE0
        public void get_EndColumn(){} // RVA: 0x7FFAC8D77010
        public void get_Document(){} // RVA: 0x7FFAC2F3C380
        public void get_IsClear(){} // RVA: 0x7FFAC8D77040
        public void Accept(){} // RVA: 0x7FFAC8D77070
    }

    public class DebugViewWriter : ExpressionVisitor
    {
        public int Base;
        public int Delta;
        public System.IO.TextWriter Depth; // 0x10
        public int _column; // 0x18
        public System.Collections.Generic.Stack`1<int> _stack; // 0x20
        public int _delta; // 0x28
        public 0x6B1EBE08 _flow; // 0x2C
        public System.Collections.Generic.Queue`1<System.Linq.Expressions.LambdaExpression> _lambdas; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Linq.Expressions.LambdaExpression,int> _lambdaIds; // 0x38
        public System.Collections.Generic.Dictionary`2<System.Linq.Expressions.ParameterExpression,int> _paramIds; // 0x40
        public System.Collections.Generic.Dictionary`2<System.Linq.Expressions.LabelTarget,int> _labelIds; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D77140
        public void get_Base(){} // RVA: 0x7FFAC8D77260
        public void get_Delta(){} // RVA: 0x7FFAC32EC4C0
        public void get_Depth(){} // RVA: 0x7FFAC8D772D0
        public void Indent(){} // RVA: 0x7FFAC8D77350
        public void Dedent(){} // RVA: 0x7FFAC8D77360
        public void NewLine(){} // RVA: 0x7FFAC8D77370
        public void GetId(){} // RVA: 0x7FFAC2E8DC40
        public void GetLambdaId(){} // RVA: 0x7FFAC8D77380
        public void GetParamId(){} // RVA: 0x7FFAC8D773D0
        public void GetLabelTargetId(){} // RVA: 0x7FFAC8D77420
        public void WriteTo(){} // RVA: 0x7FFAC8D77700 | overloaded x2
        public void Out(){} // RVA: 0x7FFAC8D778C0 | overloaded x4
        public void WriteLine(){} // RVA: 0x7FFAC8D77A90
        public void Write(){} // RVA: 0x7FFAC8D77AD0
        public void GetFlow(){} // RVA: 0x7FFAC8D77B20
        public void CheckBreak(){} // RVA: 0x7FFAC8D77BE0
        public void VisitExpressions(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
        public void VisitDeclarations(){} // RVA: 0x7FFAC8D77C20
        public void VisitBinary(){} // RVA: 0x7FFAC8D77CE0
        public void VisitParameter(){} // RVA: 0x7FFAC8D784B0
        public void VisitLambda(){} // RVA: 0x7FFAC2C58F40
        public void IsSimpleExpression(){} // RVA: 0x7FFAC8D78640
        public void VisitConditional(){} // RVA: 0x7FFAC8D78750
        public void VisitConstant(){} // RVA: 0x7FFAC8D78A00
        public void GetConstantValueSuffix(){} // RVA: 0x7FFAC8D78E40
        public void VisitRuntimeVariables(){} // RVA: 0x7FFAC8D79130
        public void OutMember(){} // RVA: 0x7FFAC8D79200
        public void VisitMember(){} // RVA: 0x7FFAC8D79330
        public void VisitInvocation(){} // RVA: 0x7FFAC8D79480
        public void NeedsParentheses(){} // RVA: 0x7FFAC8D79530
        public void GetOperatorPrecedence(){} // RVA: 0x7FFAC8D79700
        public void ParenthesizedVisit(){} // RVA: 0x7FFAC8D79880
        public void VisitMethodCall(){} // RVA: 0x7FFAC8D79960
        public void VisitNewArray(){} // RVA: 0x7FFAC8D79B90
        public void VisitNew(){} // RVA: 0x7FFAC8D79CF0
        public void VisitElementInit(){} // RVA: 0x7FFAC8D79E00
        public void VisitListInit(){} // RVA: 0x7FFAC8D79F60
        public void VisitMemberAssignment(){} // RVA: 0x7FFAC8D7A050
        public void VisitMemberListBinding(){} // RVA: 0x7FFAC8D7A110
        public void VisitMemberMemberBinding(){} // RVA: 0x7FFAC8D7A250
        public void VisitMemberInit(){} // RVA: 0x7FFAC8D7A390
        public void VisitTypeBinary(){} // RVA: 0x7FFAC8D7A480
        public void VisitUnary(){} // RVA: 0x7FFAC8D7A570
        public void VisitBlock(){} // RVA: 0x7FFAC8D7AAB0
        public void VisitDefault(){} // RVA: 0x7FFAC8D7AD90
        public void VisitLabel(){} // RVA: 0x7FFAC8D7AE50
        public void VisitGoto(){} // RVA: 0x7FFAC8D7AF00
        public void VisitLoop(){} // RVA: 0x7FFAC8D7B060
        public void VisitSwitchCase(){} // RVA: 0x7FFAC8D7B1B0
        public void VisitSwitch(){} // RVA: 0x7FFAC8D7B470
        public void VisitCatchBlock(){} // RVA: 0x7FFAC8D7B650
        public void VisitTry(){} // RVA: 0x7FFAC8D7B7E0
        public void VisitIndex(){} // RVA: 0x7FFAC8D7B9B0
        public void VisitExtension(){} // RVA: 0x7FFAC8D7BB70
        public void VisitDebugInfo(){} // RVA: 0x7FFAC8D7BD80
        public void DumpLabel(){} // RVA: 0x7FFAC8D7C110
        public void GetLabelTargetName(){} // RVA: 0x7FFAC8D7C250
        public void WriteLambda(){} // RVA: 0x7FFAC8D7C390
        public void GetLambdaName(){} // RVA: 0x7FFAC8D7C5C0
        public void ContainsWhiteSpace(){} // RVA: 0x7FFAC8D7C730
        public void QuoteName(){} // RVA: 0x7FFAC8D7C7E0
        public void GetDisplayName(){} // RVA: 0x7FFAC8D7C8E0
        public void <VisitExpressions>b__37_0(){} // RVA: 0x7FFAC2E8DC40
        public void <VisitDeclarations>b__38_0(){} // RVA: 0x7FFAC8D7CA80
        public void <VisitListInit>b__58_0(){} // RVA: 0x7FFAC8D7CBA0
        public void <VisitMemberListBinding>b__60_0(){} // RVA: 0x7FFAC8D7CBA0
        public void <VisitMemberMemberBinding>b__61_0(){} // RVA: 0x7FFAC8D7CBC0
        public void <VisitMemberInit>b__62_0(){} // RVA: 0x7FFAC8D7CBC0
    }

    public class DefaultExpression : Expression
    {
        public System.Type Type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7CCC0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_NodeType(){} // RVA: 0x7FFAC8D7CC80
        public void Accept(){} // RVA: 0x7FFAC8D7CC90
    }

    public class DynamicExpression : Expression
    {
        public System.Runtime.CompilerServices.CallSiteBinder CanReduce; // 0x10
        public System.Type Type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7DB60 | overloaded x2
        public void get_CanReduce(){} // RVA: 0x7FFAC3006850
        public void Reduce(){} // RVA: 0x7FFAC8D7CE00
        public void Make(){} // RVA: 0x7FFAC8D7D610 | overloaded x5
        public void get_Type(){} // RVA: 0x7FFAC8D7D810
        public void get_NodeType(){} // RVA: 0x7FFAC314F990
        public void get_Binder(){} // RVA: 0x7FFAC2F3C380
        public void get_DelegateType(){} // RVA: 0x7FFAC2F247C0
        public void get_Arguments(){} // RVA: 0x7FFAC3708F90
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7D8C0
        public void Accept(){} // RVA: 0x7FFAC8D7D8F0
        public void Rewrite(){} // RVA: 0x7FFAC8D7D9B0
        public void Update(){} // RVA: 0x7FFAC8D7D9E0
        public void SameArguments(){} // RVA: 0x7FFAC8D7DAA0
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAC8D7DAD0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAC8D7DB00
        public void Dynamic(){} // RVA: 0x7FFAC8D58950 | overloaded x6
        public void MakeDynamic(){} // RVA: 0x7FFAC8D589A0 | overloaded x6
        public void System.Linq.Expressions.IDynamicExpression.Rewrite(){} // RVA: 0x7FFAC8D7DB30
        public void System.Linq.Expressions.IDynamicExpression.CreateCallSite(){} // RVA: 0x7FFAC8D7DB50
    }

    public class DynamicExpression1 : DynamicExpression
    {
        public object System.Linq.Expressions.IArgumentProvider.ArgumentCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7DB90
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAC8D7DE70
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAC3013AF0
        public void SameArguments(){} // RVA: 0x7FFAC8D7DF10
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void Rewrite(){} // RVA: 0x7FFAC8D7E0A0
    }

    public class DynamicExpression2 : DynamicExpression
    {
        public object System.Linq.Expressions.IArgumentProvider.ArgumentCount; // 0x20
        public System.Linq.Expressions.Expression _arg1; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7E0E0
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAC8D7E1C0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAC3026CB0
        public void SameArguments(){} // RVA: 0x7FFAC8D7E270
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void Rewrite(){} // RVA: 0x7FFAC8D7E4F0
    }

    public class DynamicExpression3 : DynamicExpression
    {
        public object System.Linq.Expressions.IArgumentProvider.ArgumentCount; // 0x20
        public System.Linq.Expressions.Expression _arg1; // 0x28
        public System.Linq.Expressions.Expression _arg2; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7E5D0
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAC8D7E700
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAC366FE20
        public void SameArguments(){} // RVA: 0x7FFAC8D7E7C0
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void Rewrite(){} // RVA: 0x7FFAC8D7EA90
    }

    public class DynamicExpression4 : DynamicExpression
    {
        public object System.Linq.Expressions.IArgumentProvider.ArgumentCount; // 0x20
        public System.Linq.Expressions.Expression _arg1; // 0x28
        public System.Linq.Expressions.Expression _arg2; // 0x30
        public System.Linq.Expressions.Expression _arg3; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7EB90
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAC8D7ED10
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAC36C3910
        public void SameArguments(){} // RVA: 0x7FFAC8D7EDF0
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7E090
        public void Rewrite(){} // RVA: 0x7FFAC8D7F100
    }

    public class DynamicExpressionN : DynamicExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> System.Linq.Expressions.IArgumentProvider.ArgumentCount; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7DB90
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAC8D7DC00
        public void SameArguments(){} // RVA: 0x7FFAC8D7DC60
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAC8D7DD40
        public void GetOrMakeArguments(){} // RVA: 0x7FFAC8D7DD90
        public void Rewrite(){} // RVA: 0x7FFAC8D7DDD0
    }

    public class DynamicExpressionVisitor : ExpressionVisitor
    {
        // ── Methods ──
        public void VisitDynamic(){} // RVA: 0x7FFAC8D81E00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}