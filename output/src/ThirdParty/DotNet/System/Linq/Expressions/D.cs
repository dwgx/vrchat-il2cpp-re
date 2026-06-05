// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 10
// Methods: 158

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class DebugInfoExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9090640 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAF9090470
        public void get_NodeType(){} // RVA: 0x7FFAF4BBE2D0
        public void get_StartLine(){} // RVA: 0x7FFAF9090520
        public void get_StartColumn(){} // RVA: 0x7FFAF9090550
        public void get_EndLine(){} // RVA: 0x7FFAF9090580
        public void get_EndColumn(){} // RVA: 0x7FFAF90905B0
        public void get_Document(){} // RVA: 0x7FFAF2DA8380
        public void get_IsClear(){} // RVA: 0x7FFAF90905E0
        public void Accept(){} // RVA: 0x7FFAF9090610
    }

    public class DebugViewWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF90906E0
        public void get_Base(){} // RVA: 0x7FFAF9090800
        public void get_Delta(){} // RVA: 0x7FFAF3241DC0
        public void get_Depth(){} // RVA: 0x7FFAF9090870
        public void Indent(){} // RVA: 0x7FFAF90908F0
        public void Dedent(){} // RVA: 0x7FFAF9090900
        public void NewLine(){} // RVA: 0x7FFAF9090910
        public void GetId(){} // RVA: 0x7FFAF2D33FA0
        public void GetLambdaId(){} // RVA: 0x7FFAF9090920
        public void GetParamId(){} // RVA: 0x7FFAF9090970
        public void GetLabelTargetId(){} // RVA: 0x7FFAF90909C0
        public void WriteTo(){} // RVA: 0x7FFAF9090CA0 | overloaded x2
        public void Out(){} // RVA: 0x7FFAF9090E60 | overloaded x4
        public void WriteLine(){} // RVA: 0x7FFAF9091030
        public void Write(){} // RVA: 0x7FFAF9091070
        public void GetFlow(){} // RVA: 0x7FFAF90910C0
        public void CheckBreak(){} // RVA: 0x7FFAF9091180
        public void VisitExpressions(){} // RVA: 0x7FFAF2D33FA0 | overloaded x3
        public void VisitDeclarations(){} // RVA: 0x7FFAF90911C0
        public void VisitBinary(){} // RVA: 0x7FFAF9091280
        public void VisitParameter(){} // RVA: 0x7FFAF9091A50
        public void VisitLambda(){} // RVA: 0x7FFAF2ABCE10
        public void IsSimpleExpression(){} // RVA: 0x7FFAF9091BE0
        public void VisitConditional(){} // RVA: 0x7FFAF9091CF0
        public void VisitConstant(){} // RVA: 0x7FFAF9091FA0
        public void GetConstantValueSuffix(){} // RVA: 0x7FFAF90923E0
        public void VisitRuntimeVariables(){} // RVA: 0x7FFAF90926D0
        public void OutMember(){} // RVA: 0x7FFAF90927A0
        public void VisitMember(){} // RVA: 0x7FFAF90928D0
        public void VisitInvocation(){} // RVA: 0x7FFAF9092A20
        public void NeedsParentheses(){} // RVA: 0x7FFAF9092AD0
        public void GetOperatorPrecedence(){} // RVA: 0x7FFAF9092CA0
        public void ParenthesizedVisit(){} // RVA: 0x7FFAF9092E20
        public void VisitMethodCall(){} // RVA: 0x7FFAF9092F00
        public void VisitNewArray(){} // RVA: 0x7FFAF9093130
        public void VisitNew(){} // RVA: 0x7FFAF9093290
        public void VisitElementInit(){} // RVA: 0x7FFAF90933A0
        public void VisitListInit(){} // RVA: 0x7FFAF9093500
        public void VisitMemberAssignment(){} // RVA: 0x7FFAF90935F0
        public void VisitMemberListBinding(){} // RVA: 0x7FFAF90936B0
        public void VisitMemberMemberBinding(){} // RVA: 0x7FFAF90937F0
        public void VisitMemberInit(){} // RVA: 0x7FFAF9093930
        public void VisitTypeBinary(){} // RVA: 0x7FFAF9093A20
        public void VisitUnary(){} // RVA: 0x7FFAF9093B10
        public void VisitBlock(){} // RVA: 0x7FFAF9094050
        public void VisitDefault(){} // RVA: 0x7FFAF9094330
        public void VisitLabel(){} // RVA: 0x7FFAF90943F0
        public void VisitGoto(){} // RVA: 0x7FFAF90944A0
        public void VisitLoop(){} // RVA: 0x7FFAF9094600
        public void VisitSwitchCase(){} // RVA: 0x7FFAF9094750
        public void VisitSwitch(){} // RVA: 0x7FFAF9094A10
        public void VisitCatchBlock(){} // RVA: 0x7FFAF9094BF0
        public void VisitTry(){} // RVA: 0x7FFAF9094D80
        public void VisitIndex(){} // RVA: 0x7FFAF9094F50
        public void VisitExtension(){} // RVA: 0x7FFAF9095110
        public void VisitDebugInfo(){} // RVA: 0x7FFAF9095320
        public void DumpLabel(){} // RVA: 0x7FFAF90956B0
        public void GetLabelTargetName(){} // RVA: 0x7FFAF90957F0
        public void WriteLambda(){} // RVA: 0x7FFAF9095930
        public void GetLambdaName(){} // RVA: 0x7FFAF9095B60
        public void ContainsWhiteSpace(){} // RVA: 0x7FFAF9095CD0
        public void QuoteName(){} // RVA: 0x7FFAF9095D80
        public void GetDisplayName(){} // RVA: 0x7FFAF9095E80
        public void <VisitExpressions>b__37_0(){} // RVA: 0x7FFAF2D33FA0
        public void <VisitDeclarations>b__38_0(){} // RVA: 0x7FFAF9096020
        public void <VisitListInit>b__58_0(){} // RVA: 0x7FFAF9096140
        public void <VisitMemberListBinding>b__60_0(){} // RVA: 0x7FFAF9096140
        public void <VisitMemberMemberBinding>b__61_0(){} // RVA: 0x7FFAF9096160
        public void <VisitMemberInit>b__62_0(){} // RVA: 0x7FFAF9096160
    }

    public class DefaultExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9096260 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAF2DA8380
        public void get_NodeType(){} // RVA: 0x7FFAF9096220
        public void Accept(){} // RVA: 0x7FFAF9096230
    }

    public class DynamicExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9097100 | overloaded x2
        public void get_CanReduce(){} // RVA: 0x7FFAF2E72850
        public void Reduce(){} // RVA: 0x7FFAF90963A0
        public void Make(){} // RVA: 0x7FFAF9096BB0 | overloaded x5
        public void get_Type(){} // RVA: 0x7FFAF9096DB0
        public void get_NodeType(){} // RVA: 0x7FFAF3061C80
        public void get_Binder(){} // RVA: 0x7FFAF2DA8380
        public void get_DelegateType(){} // RVA: 0x7FFAF2D907C0
        public void get_Arguments(){} // RVA: 0x7FFAF35950F0
        public void GetOrMakeArguments(){} // RVA: 0x7FFAF9096E60
        public void Accept(){} // RVA: 0x7FFAF9096E90
        public void Rewrite(){} // RVA: 0x7FFAF9096F50
        public void Update(){} // RVA: 0x7FFAF9096F80
        public void SameArguments(){} // RVA: 0x7FFAF9097040
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAF9097070
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAF90970A0
        public void Dynamic(){} // RVA: 0x7FFAF9071F80 | overloaded x6
        public void MakeDynamic(){} // RVA: 0x7FFAF9071FD0 | overloaded x6
        public void System.Linq.Expressions.IDynamicExpression.Rewrite(){} // RVA: 0x7FFAF90970D0
        public void System.Linq.Expressions.IDynamicExpression.CreateCallSite(){} // RVA: 0x7FFAF90970F0
    }

    public class DynamicExpression1 : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9097130
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAF9097410
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAF2E7FAF0
        public void SameArguments(){} // RVA: 0x7FFAF90974B0
        public void GetOrMakeArguments(){} // RVA: 0x7FFAF9097630
        public void Rewrite(){} // RVA: 0x7FFAF9097640
    }

    public class DynamicExpression2 : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9097680
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAF9097760
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAF2E92CB0
        public void SameArguments(){} // RVA: 0x7FFAF9097810
        public void GetOrMakeArguments(){} // RVA: 0x7FFAF9097630
        public void Rewrite(){} // RVA: 0x7FFAF9097A90
    }

    public class DynamicExpression3 : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9097B70
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAF9097CA0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAF34E08B0
        public void SameArguments(){} // RVA: 0x7FFAF9097D60
        public void GetOrMakeArguments(){} // RVA: 0x7FFAF9097630
        public void Rewrite(){} // RVA: 0x7FFAF9098030
    }

    public class DynamicExpression4 : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9098130
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAF90982B0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAF352E130
        public void SameArguments(){} // RVA: 0x7FFAF9098390
        public void GetOrMakeArguments(){} // RVA: 0x7FFAF9097630
        public void Rewrite(){} // RVA: 0x7FFAF90986A0
    }

    public class DynamicExpressionN : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9097130
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFAF90971A0
        public void SameArguments(){} // RVA: 0x7FFAF9097200
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFAF90972E0
        public void GetOrMakeArguments(){} // RVA: 0x7FFAF9097330
        public void Rewrite(){} // RVA: 0x7FFAF9097370
    }

    public class DynamicExpressionVisitor
    {
        // ── Methods ──
        public void VisitDynamic(){} // RVA: 0x7FFAF909B3A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}