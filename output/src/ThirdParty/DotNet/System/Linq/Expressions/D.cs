// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 10
// Methods: 158

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class DebugInfoExpression : Expression
    {
        public System.Linq.Expressions.SymbolDocumentInfo _document; // 0x10
        public object field_1; // 0x15E
        public object field_2; // 0x15F
        public object field_3; // 0x160
        public object field_4; // 0x161
        public object field_5; // 0x162
        public object field_6; // 0x163
        public object field_7; // 0x164

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711F4D0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE8711F300
        public void get_NodeType(){} // RVA: 0x7FFE835C28A0
        public void get_StartLine(){} // RVA: 0x7FFE8711F3B0
        public void get_StartColumn(){} // RVA: 0x7FFE8711F3E0
        public void get_EndLine(){} // RVA: 0x7FFE8711F410
        public void get_EndColumn(){} // RVA: 0x7FFE8711F440
        public void get_Document(){} // RVA: 0x7FFE81116380
        public void get_IsClear(){} // RVA: 0x7FFE8711F470
        public void Accept(){} // RVA: 0x7FFE8711F4A0
    }

    public class DebugViewWriter : ExpressionVisitor
    {
        public int Tab;
        public int MaxColumn;
        public System.IO.TextWriter _out; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711F570
        public void get_Base(){} // RVA: 0x7FFE8711F690
        public void get_Delta(){} // RVA: 0x7FFE81549710
        public void get_Depth(){} // RVA: 0x7FFE8711F700
        public void Indent(){} // RVA: 0x7FFE8711F780
        public void Dedent(){} // RVA: 0x7FFE8711F790
        public void NewLine(){} // RVA: 0x7FFE8711F7A0
        public void GetId(){} // RVA: 0x7FFE810A1420
        public void GetLambdaId(){} // RVA: 0x7FFE8711F7B0
        public void GetParamId(){} // RVA: 0x7FFE8711F800
        public void GetLabelTargetId(){} // RVA: 0x7FFE8711F850
        public void WriteTo(){} // RVA: 0x7FFE8711FB30 | overloaded x2
        public void Out(){} // RVA: 0x7FFE8711FCF0 | overloaded x4
        public void WriteLine(){} // RVA: 0x7FFE8711FEC0
        public void Write(){} // RVA: 0x7FFE8711FF00
        public void GetFlow(){} // RVA: 0x7FFE8711FF50
        public void CheckBreak(){} // RVA: 0x7FFE87120010
        public void VisitExpressions(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void VisitDeclarations(){} // RVA: 0x7FFE87120050
        public void VisitBinary(){} // RVA: 0x7FFE87120110
        public void VisitParameter(){} // RVA: 0x7FFE871208E0
        public void VisitLambda(){} // RVA: 0x7FFE80E2E390
        public void IsSimpleExpression(){} // RVA: 0x7FFE87120A70
        public void VisitConditional(){} // RVA: 0x7FFE87120B80
        public void VisitConstant(){} // RVA: 0x7FFE87120E30
        public void GetConstantValueSuffix(){} // RVA: 0x7FFE87121270
        public void VisitRuntimeVariables(){} // RVA: 0x7FFE87121560
        public void OutMember(){} // RVA: 0x7FFE87121630
        public void VisitMember(){} // RVA: 0x7FFE87121760
        public void VisitInvocation(){} // RVA: 0x7FFE871218B0
        public void NeedsParentheses(){} // RVA: 0x7FFE87121960
        public void GetOperatorPrecedence(){} // RVA: 0x7FFE87121B30
        public void ParenthesizedVisit(){} // RVA: 0x7FFE87121CB0
        public void VisitMethodCall(){} // RVA: 0x7FFE87121D90
        public void VisitNewArray(){} // RVA: 0x7FFE87121FC0
        public void VisitNew(){} // RVA: 0x7FFE87122120
        public void VisitElementInit(){} // RVA: 0x7FFE87122230
        public void VisitListInit(){} // RVA: 0x7FFE87122390
        public void VisitMemberAssignment(){} // RVA: 0x7FFE87122480
        public void VisitMemberListBinding(){} // RVA: 0x7FFE87122540
        public void VisitMemberMemberBinding(){} // RVA: 0x7FFE87122680
        public void VisitMemberInit(){} // RVA: 0x7FFE871227C0
        public void VisitTypeBinary(){} // RVA: 0x7FFE871228B0
        public void VisitUnary(){} // RVA: 0x7FFE871229A0
        public void VisitBlock(){} // RVA: 0x7FFE87122EE0
        public void VisitDefault(){} // RVA: 0x7FFE871231C0
        public void VisitLabel(){} // RVA: 0x7FFE87123280
        public void VisitGoto(){} // RVA: 0x7FFE87123330
        public void VisitLoop(){} // RVA: 0x7FFE87123490
        public void VisitSwitchCase(){} // RVA: 0x7FFE871235E0
        public void VisitSwitch(){} // RVA: 0x7FFE871238A0
        public void VisitCatchBlock(){} // RVA: 0x7FFE87123A80
        public void VisitTry(){} // RVA: 0x7FFE87123C10
        public void VisitIndex(){} // RVA: 0x7FFE87123DE0
        public void VisitExtension(){} // RVA: 0x7FFE87123FA0
        public void VisitDebugInfo(){} // RVA: 0x7FFE871241B0
        public void DumpLabel(){} // RVA: 0x7FFE87124540
        public void GetLabelTargetName(){} // RVA: 0x7FFE87124680
        public void WriteLambda(){} // RVA: 0x7FFE871247C0
        public void GetLambdaName(){} // RVA: 0x7FFE871249F0
        public void ContainsWhiteSpace(){} // RVA: 0x7FFE87124B60
        public void QuoteName(){} // RVA: 0x7FFE87124C10
        public void GetDisplayName(){} // RVA: 0x7FFE87124D10
        public void <VisitExpressions>b__37_0(){} // RVA: 0x7FFE810A1420
        public void <VisitDeclarations>b__38_0(){} // RVA: 0x7FFE87124EB0
        public void <VisitListInit>b__58_0(){} // RVA: 0x7FFE87124FD0
        public void <VisitMemberListBinding>b__60_0(){} // RVA: 0x7FFE87124FD0
        public void <VisitMemberMemberBinding>b__61_0(){} // RVA: 0x7FFE87124FF0
        public void <VisitMemberInit>b__62_0(){} // RVA: 0x7FFE87124FF0
    }

    public class DefaultExpression : Expression
    {
        public System.Type _type; // 0x10
        public object field_1; // 0x173

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871250F0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_NodeType(){} // RVA: 0x7FFE871250B0
        public void Accept(){} // RVA: 0x7FFE871250C0
    }

    public class DynamicExpression : Expression
    {
        public System.Runtime.CompilerServices.CallSiteBinder _binder; // 0x10
        public System.Type _delegateType; // 0x18
        public object field_2; // 0x175
        public object field_3; // 0x176
        public object field_4; // 0x177
        public object field_5; // 0x178
        public object field_6; // 0x179

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87125F90 | overloaded x2
        public void get_CanReduce(){} // RVA: 0x7FFE811E0850
        public void Reduce(){} // RVA: 0x7FFE87125230
        public void Make(){} // RVA: 0x7FFE87125A40 | overloaded x5
        public void get_Type(){} // RVA: 0x7FFE87125C40
        public void get_NodeType(){} // RVA: 0x7FFE813B49E0
        public void get_Binder(){} // RVA: 0x7FFE81116380
        public void get_DelegateType(){} // RVA: 0x7FFE810FE7C0
        public void get_Arguments(){} // RVA: 0x7FFE82BC3B70
        public void GetOrMakeArguments(){} // RVA: 0x7FFE87125CF0
        public void Accept(){} // RVA: 0x7FFE87125D20
        public void Rewrite(){} // RVA: 0x7FFE87125DE0
        public void Update(){} // RVA: 0x7FFE87125E10
        public void SameArguments(){} // RVA: 0x7FFE87125ED0
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFE87125F00
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFE87125F30
        public void Dynamic(){} // RVA: 0x7FFE87100E10 | overloaded x6
        public void MakeDynamic(){} // RVA: 0x7FFE87100E60 | overloaded x6
        public void System.Linq.Expressions.IDynamicExpression.Rewrite(){} // RVA: 0x7FFE87125F60
        public void System.Linq.Expressions.IDynamicExpression.CreateCallSite(){} // RVA: 0x7FFE87125F80
    }

    public class DynamicExpression1 : DynamicExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87125FC0
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFE871262A0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFE811EDAF0
        public void SameArguments(){} // RVA: 0x7FFE87126340
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void Rewrite(){} // RVA: 0x7FFE871264D0
    }

    public class DynamicExpression2 : DynamicExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87126510
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFE871265F0
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFE81200CB0
        public void SameArguments(){} // RVA: 0x7FFE871266A0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void Rewrite(){} // RVA: 0x7FFE87126920
    }

    public class DynamicExpression3 : DynamicExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87126A00
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFE87126B30
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFE817BF630
        public void SameArguments(){} // RVA: 0x7FFE87126BF0
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void Rewrite(){} // RVA: 0x7FFE87126EC0
    }

    public class DynamicExpression4 : DynamicExpression
    {
        public object _arg0; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87126FC0
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFE87127140
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFE8180E590
        public void SameArguments(){} // RVA: 0x7FFE87127220
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871264C0
        public void Rewrite(){} // RVA: 0x7FFE87127530
    }

    public class DynamicExpressionN : DynamicExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> _arguments; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87125FC0
        public void System.Linq.Expressions.IArgumentProvider.GetArgument(){} // RVA: 0x7FFE87126030
        public void SameArguments(){} // RVA: 0x7FFE87126090
        public void System.Linq.Expressions.IArgumentProvider.get_ArgumentCount(){} // RVA: 0x7FFE87126170
        public void GetOrMakeArguments(){} // RVA: 0x7FFE871261C0
        public void Rewrite(){} // RVA: 0x7FFE87126200
    }

    public class DynamicExpressionVisitor : ExpressionVisitor
    {
        // ── Methods ──
        public void VisitDynamic(){} // RVA: 0x7FFE8712A230
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}