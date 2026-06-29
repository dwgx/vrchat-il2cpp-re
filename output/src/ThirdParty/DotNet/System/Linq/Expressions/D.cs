// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 10
// Methods: 135

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class DebugInfoExpression : Expression
    {
        public object _document;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704E980
        public void get_Type(){} // RVA: 0x704E800
        public void get_NodeType(){} // RVA: 0x2AFBE50
        public void get_StartLine(){} // RVA: 0x704E860
        public void get_StartColumn(){} // RVA: 0x704E890
        public void get_EndLine(){} // RVA: 0x704E8C0
        public void get_EndColumn(){} // RVA: 0x704E8F0
        public void get_Document(){} // RVA: 0xB5DBF0
        public void get_IsClear(){} // RVA: 0x704E920
        public void Accept(){} // RVA: 0x704E950
    }

    public class DebugViewWriter : ExpressionVisitor
    {
        public object Tab;
        public object MaxColumn;
        public object _out;
        public object _column;
        public object _stack;
        public object _delta;
        public object _flow;
        public object _lambdas;
        public object _lambdaIds;
        public object _paramIds;
        public object _labelIds;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704EA20
        public void get_Base(){} // RVA: 0x704EB40
        public void get_Delta(){} // RVA: 0x1065D50
        public void get_Depth(){} // RVA: 0x704EBB0
        public void Indent(){} // RVA: 0x704EC30
        public void Dedent(){} // RVA: 0x704EC40
        public void NewLine(){} // RVA: 0x704EC50
        public void GetId(){} // RVA: 0xA94080
        public void GetLambdaId(){} // RVA: 0x704EC60
        public void GetParamId(){} // RVA: 0x704ECB0
        public void GetLabelTargetId(){} // RVA: 0x704ED00
        public void WriteTo(){} // RVA: 0x704EFD0
        public void Out(){} // RVA: 0x704F170
        public void WriteLine(){} // RVA: 0x704F340
        public void Write(){} // RVA: 0x704F380
        public void GetFlow(){} // RVA: 0x704F3D0
        public void CheckBreak(){} // RVA: 0x704F490
        public void VisitExpressions(){} // RVA: 0xA94080
        public void VisitDeclarations(){} // RVA: 0x704F4D0
        public void VisitBinary(){} // RVA: 0x704F590
        public void VisitParameter(){} // RVA: 0x704FD70
        public void VisitLambda(){} // RVA: 0x87C540
        public void IsSimpleExpression(){} // RVA: 0x704FF00
        public void VisitConditional(){} // RVA: 0x704FFF0
        public void VisitConstant(){} // RVA: 0x7050290
        public void GetConstantValueSuffix(){} // RVA: 0x70506C0
        public void VisitRuntimeVariables(){} // RVA: 0x7050980
        public void OutMember(){} // RVA: 0x7050A50
        public void VisitMember(){} // RVA: 0x7050B80
        public void VisitInvocation(){} // RVA: 0x7050CD0
        public void NeedsParentheses(){} // RVA: 0x7050D80
        public void GetOperatorPrecedence(){} // RVA: 0x7050F50
        public void ParenthesizedVisit(){} // RVA: 0x70510D0
        public void VisitMethodCall(){} // RVA: 0x70511B0
        public void VisitNewArray(){} // RVA: 0x70513D0
        public void VisitNew(){} // RVA: 0x7051530
        public void VisitElementInit(){} // RVA: 0x7051640
        public void VisitListInit(){} // RVA: 0x70517A0
        public void VisitMemberAssignment(){} // RVA: 0x7051890
        public void VisitMemberListBinding(){} // RVA: 0x7051950
        public void VisitMemberMemberBinding(){} // RVA: 0x7051A90
        public void VisitMemberInit(){} // RVA: 0x7051BD0
        public void VisitTypeBinary(){} // RVA: 0x7051CC0
        public void VisitUnary(){} // RVA: 0x7051DB0
        public void VisitBlock(){} // RVA: 0x70522E0
        public void VisitDefault(){} // RVA: 0x70525B0
        public void VisitLabel(){} // RVA: 0x7052670
        public void VisitGoto(){} // RVA: 0x7052720
        public void VisitLoop(){} // RVA: 0x7052880
        public void VisitSwitchCase(){} // RVA: 0x70529D0
        public void VisitSwitch(){} // RVA: 0x7052CB0
        public void VisitCatchBlock(){} // RVA: 0x7052E90
        public void VisitTry(){} // RVA: 0x7053020
        public void VisitIndex(){} // RVA: 0x70531F0
        public void VisitExtension(){} // RVA: 0x70533B0
        public void VisitDebugInfo(){} // RVA: 0x70535C0
        public void DumpLabel(){} // RVA: 0x7053940
        public void GetLabelTargetName(){} // RVA: 0x7053A80
        public void WriteLambda(){} // RVA: 0x7053BC0
        public void GetLambdaName(){} // RVA: 0x7053DF0
        public void ContainsWhiteSpace(){} // RVA: 0x7053F60
        public void QuoteName(){} // RVA: 0x7053FF0
        public void GetDisplayName(){} // RVA: 0x70540F0
        public void <VisitExpressions>b__37_0(){} // RVA: 0xA94080
        public void <VisitDeclarations>b__38_0(){} // RVA: 0x7054270
        public void <VisitListInit>b__58_0(){} // RVA: 0x7054390
        public void <VisitMemberListBinding>b__60_0(){} // RVA: 0x7054390
        public void <VisitMemberMemberBinding>b__61_0(){} // RVA: 0x70543B0
        public void <VisitMemberInit>b__62_0(){} // RVA: 0x70543B0
    }

    public class DefaultExpression : Expression
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70544B0
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_NodeType(){} // RVA: 0x7054470
        public void Accept(){} // RVA: 0x7054480
    }

    public class DynamicExpression : Expression
    {
        public object _binder;
        public object _delegateType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7055150
        public void get_CanReduce(){} // RVA: 0xC2E4C0
        public void Reduce(){} // RVA: 0x70545F0
        public void Make(){} // RVA: 0x7054D20
        public void get_Type(){} // RVA: 0x6AAD9D0
        public void get_NodeType(){} // RVA: 0xE49B50
        public void get_Binder(){} // RVA: 0xB5DBF0
        public void get_DelegateType(){} // RVA: 0xB465B0
        public void get_Arguments(){} // RVA: 0x26BC9C0
        public void GetOrMakeArguments(){} // RVA: 0x7054EE0
        public void Accept(){} // RVA: 0x7054F10
        public void Rewrite(){} // RVA: 0x7054FA0
        public void Update(){} // RVA: 0x7054FD0
        public void SameArguments(){} // RVA: 0x7055090
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x70550C0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x70550F0
        public void Dynamic(){} // RVA: 0x7030430
        public void MakeDynamic(){} // RVA: 0x7030480
        public void System.Linq.Expressions.IDynamicExpression.Rewrite(){} // RVA: 0x7055120
        public void System.Linq.Expressions.IDynamicExpression.CreateCallSite(){} // RVA: 0x7055140
    }

    public class DynamicExpression1 : DynamicExpression
    {
        public object _arg0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7055180
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7055460
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0xC3CCE0
        public void SameArguments(){} // RVA: 0x7055500
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void Rewrite(){} // RVA: 0x70556A0
    }

    public class DynamicExpression2 : DynamicExpression
    {
        public object _arg0;
        public object _arg1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70556E0
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x70557C0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0xC50A80
        public void SameArguments(){} // RVA: 0x7055870
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void Rewrite(){} // RVA: 0x7055AF0
    }

    public class DynamicExpression3 : DynamicExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7055BD0
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7055D00
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x12FC4A0
        public void SameArguments(){} // RVA: 0x7055DC0
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void Rewrite(){} // RVA: 0x7056080
    }

    public class DynamicExpression4 : DynamicExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;
        public object _arg3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7056180
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7056300
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x1347420
        public void SameArguments(){} // RVA: 0x70563E0
        public void GetOrMakeArguments(){} // RVA: 0x7055690
        public void Rewrite(){} // RVA: 0x70566E0
    }

    public class DynamicExpressionN : DynamicExpression
    {
        public object _arguments;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7055180
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x70551F0
        public void SameArguments(){} // RVA: 0x7055250
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7055330
        public void GetOrMakeArguments(){} // RVA: 0x7055380
        public void Rewrite(){} // RVA: 0x70553C0
    }

    public class DynamicExpressionVisitor : ExpressionVisitor
    {
        // ── Methods ──
        public void VisitDynamic(){} // RVA: 0x7059270
        public void .ctor(){} // RVA: 0xB43310
    }

}