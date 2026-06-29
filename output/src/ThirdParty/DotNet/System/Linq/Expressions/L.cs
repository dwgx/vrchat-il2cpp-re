// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 6
// Methods: 50

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class LabelExpression : Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EA1A0
        public void get_Type(){} // RVA: 0x7A88F4330
        public void get_NodeType(){} // RVA: 0x7A9F26090
        public void get_Target(){} // RVA: 0x7A80F2570
        public void get_DefaultValue(){} // RVA: 0x7A80DA7B0
        public void Accept(){} // RVA: 0x7AE3EA0E0
        public void Update(){} // RVA: 0x7AE3EA110
    }

    public class LabelTarget : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EA220
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_Type(){} // RVA: 0x7A80DA7B0
        public void ToString(){} // RVA: 0x7AE3EA1D0
    }

    public class LambdaExpression : Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EA4A0
        public void get_Type(){} // RVA: 0x7A89B55B0
        public void get_TypeCore(){} // RVA: 0x7A7E00680
        public void get_PublicType(){} // RVA: 0x7A7E00680
        public void get_NodeType(){} // RVA: 0x7A943A740
        public void get_Parameters(){} // RVA: 0x7A9267340
        public void get_Name(){} // RVA: 0x7A95EA850
        public void get_NameCore(){} // RVA: 0x7A82D1450
        public void get_Body(){} // RVA: 0x7A80F2570
        public void get_ReturnType(){} // RVA: 0x7AE3EA2F0
        public void get_TailCall(){} // RVA: 0x7A8881850
        public void get_TailCallCore(){} // RVA: 0x7A80D7320
        public void GetOrMakeParameters(){} // RVA: 0x7AE3EA380
        public void System.Linq.Expressions.IParameterProvider.GetParameter(){} // RVA: 0x7ADE322D0
        public void GetParameter(){} // RVA: 0x7AE3EA3B0
        public void System.Linq.Expressions.IParameterProvider.get_ParameterCount(){} // RVA: 0x7A95E9DD0
        public void get_ParameterCount(){} // RVA: 0x7AE3EA3E0
        public void Compile(){} // RVA: 0x7AE3EA490
        public void CompileToMethod(){} // RVA: 0x7AE3EA500
    }

    public class ListInitExpression : Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EA760
        public void get_NodeType(){} // RVA: 0x7A838E9A0
        public void get_Type(){} // RVA: 0x7A858AB20
        public void get_CanReduce(){} // RVA: 0x7A81BD750
        public void get_NewExpression(){} // RVA: 0x7A80F2570
        public void get_Initializers(){} // RVA: 0x7A80DA7B0
        public void Accept(){} // RVA: 0x7AE3EA640
        public void Reduce(){} // RVA: 0x7AE3EA670
        public void Update(){} // RVA: 0x7AE3EA690
    }

    public class LogicalBinaryExpression : BinaryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE39F340
        public void get_Type(){} // RVA: 0x7AE39F380
        public void get_NodeType(){} // RVA: 0x7A851DB90
    }

    public class LoopExpression : Expression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE3EAA50
        public void get_Type(){} // RVA: 0x7AE3EA8F0
        public void get_NodeType(){} // RVA: 0x7ADC500B0
        public void get_Body(){} // RVA: 0x7A80F2570
        public void get_BreakLabel(){} // RVA: 0x7A80DA7B0
        public void get_ContinueLabel(){} // RVA: 0x7A81052C0
        public void Accept(){} // RVA: 0x7AE3EA980
        public void Update(){} // RVA: 0x7AE3EA9B0
    }

}