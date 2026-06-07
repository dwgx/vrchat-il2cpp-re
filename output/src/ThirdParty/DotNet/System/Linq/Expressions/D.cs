// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 10
// Methods: 158

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class DebugInfoExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E0640 | overloaded x2
        public void get_Type(){} // RVA: 0x65E0470
        public void get_NodeType(){} // RVA: 0x210E2D0
        public void get_StartLine(){} // RVA: 0x65E0520
        public void get_StartColumn(){} // RVA: 0x65E0550
        public void get_EndLine(){} // RVA: 0x65E0580
        public void get_EndColumn(){} // RVA: 0x65E05B0
        public void get_Document(){} // RVA: 0x2F8380
        public void get_IsClear(){} // RVA: 0x65E05E0
        public void Accept(){} // RVA: 0x65E0610
    }

    public class DebugViewWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E06E0
        public void get_Base(){} // RVA: 0x65E0800
        public void get_Delta(){} // RVA: 0x791DC0
        public void get_Depth(){} // RVA: 0x65E0870
        public void Indent(){} // RVA: 0x65E08F0
        public void Dedent(){} // RVA: 0x65E0900
        public void NewLine(){} // RVA: 0x65E0910
        public void GetId(){} // RVA: 0x283FA0
        public void GetLambdaId(){} // RVA: 0x65E0920
        public void GetParamId(){} // RVA: 0x65E0970
        public void GetLabelTargetId(){} // RVA: 0x65E09C0
        public void WriteTo(){} // RVA: 0x65E0CA0 | overloaded x2
        public void Out(){} // RVA: 0x65E0E60 | overloaded x4
        public void WriteLine(){} // RVA: 0x65E1030
        public void Write(){} // RVA: 0x65E1070
        public void GetFlow(){} // RVA: 0x65E10C0
        public void CheckBreak(){} // RVA: 0x65E1180
        public void VisitExpressions(){} // RVA: 0x283FA0 | overloaded x3
        public void VisitDeclarations(){} // RVA: 0x65E11C0
        public void VisitBinary(){} // RVA: 0x65E1280
        public void VisitParameter(){} // RVA: 0x65E1A50
        public void VisitLambda(){} // RVA: 0xCE10
        public void IsSimpleExpression(){} // RVA: 0x65E1BE0
        public void VisitConditional(){} // RVA: 0x65E1CF0
        public void VisitConstant(){} // RVA: 0x65E1FA0
        public void GetConstantValueSuffix(){} // RVA: 0x65E23E0
        public void VisitRuntimeVariables(){} // RVA: 0x65E26D0
        public void OutMember(){} // RVA: 0x65E27A0
        public void VisitMember(){} // RVA: 0x65E28D0
        public void VisitInvocation(){} // RVA: 0x65E2A20
        public void NeedsParentheses(){} // RVA: 0x65E2AD0
        public void GetOperatorPrecedence(){} // RVA: 0x65E2CA0
        public void ParenthesizedVisit(){} // RVA: 0x65E2E20
        public void VisitMethodCall(){} // RVA: 0x65E2F00
        public void VisitNewArray(){} // RVA: 0x65E3130
        public void VisitNew(){} // RVA: 0x65E3290
        public void VisitElementInit(){} // RVA: 0x65E33A0
        public void VisitListInit(){} // RVA: 0x65E3500
        public void VisitMemberAssignment(){} // RVA: 0x65E35F0
        public void VisitMemberListBinding(){} // RVA: 0x65E36B0
        public void VisitMemberMemberBinding(){} // RVA: 0x65E37F0
        public void VisitMemberInit(){} // RVA: 0x65E3930
        public void VisitTypeBinary(){} // RVA: 0x65E3A20
        public void VisitUnary(){} // RVA: 0x65E3B10
        public void VisitBlock(){} // RVA: 0x65E4050
        public void VisitDefault(){} // RVA: 0x65E4330
        public void VisitLabel(){} // RVA: 0x65E43F0
        public void VisitGoto(){} // RVA: 0x65E44A0
        public void VisitLoop(){} // RVA: 0x65E4600
        public void VisitSwitchCase(){} // RVA: 0x65E4750
        public void VisitSwitch(){} // RVA: 0x65E4A10
        public void VisitCatchBlock(){} // RVA: 0x65E4BF0
        public void VisitTry(){} // RVA: 0x65E4D80
        public void VisitIndex(){} // RVA: 0x65E4F50
        public void VisitExtension(){} // RVA: 0x65E5110
        public void VisitDebugInfo(){} // RVA: 0x65E5320
        public void DumpLabel(){} // RVA: 0x65E56B0
        public void GetLabelTargetName(){} // RVA: 0x65E57F0
        public void WriteLambda(){} // RVA: 0x65E5930
        public void GetLambdaName(){} // RVA: 0x65E5B60
        public void ContainsWhiteSpace(){} // RVA: 0x65E5CD0
        public void QuoteName(){} // RVA: 0x65E5D80
        public void GetDisplayName(){} // RVA: 0x65E5E80
        public void <VisitExpressions>b__37_0(){} // RVA: 0x283FA0
        public void <VisitDeclarations>b__38_0(){} // RVA: 0x65E6020
        public void <VisitListInit>b__58_0(){} // RVA: 0x65E6140
        public void <VisitMemberListBinding>b__60_0(){} // RVA: 0x65E6140
        public void <VisitMemberMemberBinding>b__61_0(){} // RVA: 0x65E6160
        public void <VisitMemberInit>b__62_0(){} // RVA: 0x65E6160
    }

    public class DefaultExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E6260 | overloaded x2
        public void get_Type(){} // RVA: 0x2F8380
        public void get_NodeType(){} // RVA: 0x65E6220
        public void Accept(){} // RVA: 0x65E6230
    }

    public class DynamicExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E7100 | overloaded x2
        public void get_CanReduce(){} // RVA: 0x3C2850
        public void Reduce(){} // RVA: 0x65E63A0
        public void Make(){} // RVA: 0x65E6BB0 | overloaded x5
        public void get_Type(){} // RVA: 0x65E6DB0
        public void get_NodeType(){} // RVA: 0x5B1C80
        public void get_Binder(){} // RVA: 0x2F8380
        public void get_DelegateType(){} // RVA: 0x2E07C0
        public void get_Arguments(){} // RVA: 0xAE50F0
        public void GetOrMakeArguments(){} // RVA: 0x65E6E60
        public void Accept(){} // RVA: 0x65E6E90
        public void Rewrite(){} // RVA: 0x65E6F50
        public void Update(){} // RVA: 0x65E6F80
        public void SameArguments(){} // RVA: 0x65E7040
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x65E7070
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x65E70A0
        public void Dynamic(){} // RVA: 0x65C1F80 | overloaded x6
        public void MakeDynamic(){} // RVA: 0x65C1FD0 | overloaded x6
        public void System.Linq.Expressions.IDynamicExpression.Rewrite(){} // RVA: 0x65E70D0
        public void System.Linq.Expressions.IDynamicExpression.CreateCallSite(){} // RVA: 0x65E70F0
    }

    public class DynamicExpression1 : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E7130
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x65E7410
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x3CFAF0
        public void SameArguments(){} // RVA: 0x65E74B0
        public void GetOrMakeArguments(){} // RVA: 0x65E7630
        public void Rewrite(){} // RVA: 0x65E7640
    }

    public class DynamicExpression2 : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E7680
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x65E7760
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x3E2CB0
        public void SameArguments(){} // RVA: 0x65E7810
        public void GetOrMakeArguments(){} // RVA: 0x65E7630
        public void Rewrite(){} // RVA: 0x65E7A90
    }

    public class DynamicExpression3 : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E7B70
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x65E7CA0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0xA308B0
        public void SameArguments(){} // RVA: 0x65E7D60
        public void GetOrMakeArguments(){} // RVA: 0x65E7630
        public void Rewrite(){} // RVA: 0x65E8030
    }

    public class DynamicExpression4 : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E8130
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x65E82B0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0xA7E130
        public void SameArguments(){} // RVA: 0x65E8390
        public void GetOrMakeArguments(){} // RVA: 0x65E7630
        public void Rewrite(){} // RVA: 0x65E86A0
    }

    public class DynamicExpressionN : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65E7130
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x65E71A0
        public void SameArguments(){} // RVA: 0x65E7200
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x65E72E0
        public void GetOrMakeArguments(){} // RVA: 0x65E7330
        public void Rewrite(){} // RVA: 0x65E7370
    }

    public class DynamicExpressionVisitor
    {
        // ── Methods ──
        public void VisitDynamic(){} // RVA: 0x65EB3A0
        public void .ctor(){} // RVA: 0x2DD310
    }

}