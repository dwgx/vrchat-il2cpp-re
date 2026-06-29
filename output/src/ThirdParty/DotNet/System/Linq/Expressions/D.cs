// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 10
// Methods: 135

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class DebugInfoExpression : Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3CEE70
        public void get_Type(){} // RVA: 0x7AE3CECA0
        public void get_NodeType(){} // RVA: 0x7A9F22B40
        public void get_StartLine(){} // RVA: 0x7AE3CED50
        public void get_StartColumn(){} // RVA: 0x7AE3CED80
        public void get_EndLine(){} // RVA: 0x7AE3CEDB0
        public void get_EndColumn(){} // RVA: 0x7AE3CEDE0
        public void get_Document(){} // RVA: 0x7A80F2570
        public void get_IsClear(){} // RVA: 0x7AE3CEE10
        public void Accept(){} // RVA: 0x7AE3CEE40
    }

    public class DebugViewWriter : ExpressionVisitor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3CEF10
        public void get_Base(){} // RVA: 0x7AE3CF030
        public void get_Delta(){} // RVA: 0x7A854FDE0
        public void get_Depth(){} // RVA: 0x7AE3CF0A0
        public void Indent(){} // RVA: 0x7AE3CF120
        public void Dedent(){} // RVA: 0x7AE3CF130
        public void NewLine(){} // RVA: 0x7AE3CF140
        public void GetId(){} // RVA: 0x7A8051B10
        public void GetLambdaId(){} // RVA: 0x7AE3CF150
        public void GetParamId(){} // RVA: 0x7AE3CF1A0
        public void GetLabelTargetId(){} // RVA: 0x7AE3CF1F0
        public void WriteTo(){} // RVA: 0x7AE3CF4C0
        public void Out(){} // RVA: 0x7AE3CF660
        public void WriteLine(){} // RVA: 0x7AE3CF830
        public void Write(){} // RVA: 0x7AE3CF870
        public void GetFlow(){} // RVA: 0x7AE3CF8C0
        public void CheckBreak(){} // RVA: 0x7AE3CF980
        public void VisitExpressions(){} // RVA: 0x7A8051B10
        public void VisitDeclarations(){} // RVA: 0x7AE3CF9C0
        public void VisitBinary(){} // RVA: 0x7AE3CFA80
        public void VisitParameter(){} // RVA: 0x7AE3D0260
        public void VisitLambda(){} // RVA: 0x7A7E00B20
        public void IsSimpleExpression(){} // RVA: 0x7AE3D03F0
        public void VisitConditional(){} // RVA: 0x7AE3D04E0
        public void VisitConstant(){} // RVA: 0x7AE3D0780
        public void GetConstantValueSuffix(){} // RVA: 0x7AE3D0BC0
        public void VisitRuntimeVariables(){} // RVA: 0x7AE3D0EB0
        public void OutMember(){} // RVA: 0x7AE3D0F80
        public void VisitMember(){} // RVA: 0x7AE3D10B0
        public void VisitInvocation(){} // RVA: 0x7AE3D1200
        public void NeedsParentheses(){} // RVA: 0x7AE3D12B0
        public void GetOperatorPrecedence(){} // RVA: 0x7AE3D1480
        public void ParenthesizedVisit(){} // RVA: 0x7AE3D1600
        public void VisitMethodCall(){} // RVA: 0x7AE3D16E0
        public void VisitNewArray(){} // RVA: 0x7AE3D1910
        public void VisitNew(){} // RVA: 0x7AE3D1A70
        public void VisitElementInit(){} // RVA: 0x7AE3D1B80
        public void VisitListInit(){} // RVA: 0x7AE3D1CE0
        public void VisitMemberAssignment(){} // RVA: 0x7AE3D1DD0
        public void VisitMemberListBinding(){} // RVA: 0x7AE3D1E90
        public void VisitMemberMemberBinding(){} // RVA: 0x7AE3D1FD0
        public void VisitMemberInit(){} // RVA: 0x7AE3D2110
        public void VisitTypeBinary(){} // RVA: 0x7AE3D2200
        public void VisitUnary(){} // RVA: 0x7AE3D22F0
        public void VisitBlock(){} // RVA: 0x7AE3D2840
        public void VisitDefault(){} // RVA: 0x7AE3D2B20
        public void VisitLabel(){} // RVA: 0x7AE3D2BE0
        public void VisitGoto(){} // RVA: 0x7AE3D2C90
        public void VisitLoop(){} // RVA: 0x7AE3D2DF0
        public void VisitSwitchCase(){} // RVA: 0x7AE3D2F40
        public void VisitSwitch(){} // RVA: 0x7AE3D3220
        public void VisitCatchBlock(){} // RVA: 0x7AE3D3400
        public void VisitTry(){} // RVA: 0x7AE3D3590
        public void VisitIndex(){} // RVA: 0x7AE3D3760
        public void VisitExtension(){} // RVA: 0x7AE3D3920
        public void VisitDebugInfo(){} // RVA: 0x7AE3D3B30
        public void DumpLabel(){} // RVA: 0x7AE3D3EC0
        public void GetLabelTargetName(){} // RVA: 0x7AE3D4000
        public void WriteLambda(){} // RVA: 0x7AE3D4140
        public void GetLambdaName(){} // RVA: 0x7AE3D4370
        public void ContainsWhiteSpace(){} // RVA: 0x7AE3D44E0
        public void QuoteName(){} // RVA: 0x7AE3D4590
        public void GetDisplayName(){} // RVA: 0x7AE3D4690
        public void <VisitExpressions>b__37_0(){} // RVA: 0x7A8051B10
        public void <VisitDeclarations>b__38_0(){} // RVA: 0x7AE3D4830
        public void <VisitListInit>b__58_0(){} // RVA: 0x7AE3D4950
        public void <VisitMemberListBinding>b__60_0(){} // RVA: 0x7AE3D4950
        public void <VisitMemberMemberBinding>b__61_0(){} // RVA: 0x7AE3D4970
        public void <VisitMemberInit>b__62_0(){} // RVA: 0x7AE3D4970
    }

    public class DefaultExpression : Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3D4A70
        public void get_Type(){} // RVA: 0x7A80F2570
        public void get_NodeType(){} // RVA: 0x7AE3D4A30
        public void Accept(){} // RVA: 0x7AE3D4A40
    }

    public class DynamicExpression : Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3D5900
        public void get_CanReduce(){} // RVA: 0x7A81BD750
        public void Reduce(){} // RVA: 0x7AE3D4BB0
        public void Make(){} // RVA: 0x7AE3D53E0
        public void get_Type(){} // RVA: 0x7AE3D55E0
        public void get_NodeType(){} // RVA: 0x7A836B0B0
        public void get_Binder(){} // RVA: 0x7A80F2570
        public void get_DelegateType(){} // RVA: 0x7A80DA7B0
        public void get_Arguments(){} // RVA: 0x7A8881850
        public void GetOrMakeArguments(){} // RVA: 0x7AE3D5690
        public void Accept(){} // RVA: 0x7AE3D56C0
        public void Rewrite(){} // RVA: 0x7AE3D5750
        public void Update(){} // RVA: 0x7AE3D5780
        public void SameArguments(){} // RVA: 0x7AE3D5840
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7AE3D5870
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7AE3D58A0
        public void Dynamic(){} // RVA: 0x7AE3B0590
        public void MakeDynamic(){} // RVA: 0x7AE3B05E0
        public void System.Linq.Expressions.IDynamicExpression.Rewrite(){} // RVA: 0x7AE3D58D0
        public void System.Linq.Expressions.IDynamicExpression.CreateCallSite(){} // RVA: 0x7AE3D58F0
    }

    public class DynamicExpression1 : DynamicExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3D5930
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7AE3D5C10
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7A81CA9D0
        public void SameArguments(){} // RVA: 0x7AE3D5CB0
        public void GetOrMakeArguments(){} // RVA: 0x7AE3D5E40
        public void Rewrite(){} // RVA: 0x7AE3D5E50
    }

    public class DynamicExpression2 : DynamicExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3D5E90
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7AE3D5F70
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7A81DDCC0
        public void SameArguments(){} // RVA: 0x7AE3D6020
        public void GetOrMakeArguments(){} // RVA: 0x7AE3D5E40
        public void Rewrite(){} // RVA: 0x7AE3D62A0
    }

    public class DynamicExpression3 : DynamicExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3D6380
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7AE3D64B0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7A87EE0F0
        public void SameArguments(){} // RVA: 0x7AE3D6570
        public void GetOrMakeArguments(){} // RVA: 0x7AE3D5E40
        public void Rewrite(){} // RVA: 0x7AE3D6830
    }

    public class DynamicExpression4 : DynamicExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3D6930
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7AE3D6AB0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7A883BE70
        public void SameArguments(){} // RVA: 0x7AE3D6B90
        public void GetOrMakeArguments(){} // RVA: 0x7AE3D5E40
        public void Rewrite(){} // RVA: 0x7AE3D6E90
    }

    public class DynamicExpressionN : DynamicExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3D5930
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7AE3D59A0
        public void SameArguments(){} // RVA: 0x7AE3D5A00
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7AE3D5AE0
        public void GetOrMakeArguments(){} // RVA: 0x7AE3D5B30
        public void Rewrite(){} // RVA: 0x7AE3D5B70
    }

    public class DynamicExpressionVisitor : ExpressionVisitor
    {
        // ── Methods ──
        public void VisitDynamic(){} // RVA: 0x7AE3D9BB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}