// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 6
// Methods: 50

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class LabelExpression : Expression
    {
        public object _target;
        public object _defaultValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7069790
        public void get_Type(){} // RVA: 0x13F9400
        public void get_NodeType(){} // RVA: 0x2AFF440
        public void get_Target(){} // RVA: 0xB5DBF0
        public void get_DefaultValue(){} // RVA: 0xB465B0
        public void Accept(){} // RVA: 0x70696D0
        public void Update(){} // RVA: 0x7069700
    }

    public class LabelTarget : Object
    {
        public object _name;
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7069810
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_Type(){} // RVA: 0xB465B0
        public void ToString(){} // RVA: 0x70697C0
    }

    public class LambdaExpression : Expression
    {
        public object _body;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7069A90
        public void get_Type(){} // RVA: 0x14B3B70
        public void get_TypeCore(){} // RVA: 0x87C0A0
        public void get_PublicType(){} // RVA: 0x87C0A0
        public void get_NodeType(){} // RVA: 0x1F7C790
        public void get_Parameters(){} // RVA: 0x13B1020
        public void get_Name(){} // RVA: 0x487D930
        public void get_NameCore(){} // RVA: 0xDAC980
        public void get_Body(){} // RVA: 0xB5DBF0
        public void get_ReturnType(){} // RVA: 0x70698E0
        public void get_TailCall(){} // RVA: 0x26BC9C0
        public void get_TailCallCore(){} // RVA: 0xB43320
        public void GetOrMakeParameters(){} // RVA: 0x7069970
        public void System.Linq.Expressions.IParameterProvider.GetParameter(){} // RVA: 0x6ABA050
        public void GetParameter(){} // RVA: 0x70699A0
        public void System.Linq.Expressions.IParameterProvider.get_ParameterCount(){} // RVA: 0x13C3640
        public void get_ParameterCount(){} // RVA: 0x70699D0
        public void Compile(){} // RVA: 0x7069A80
        public void CompileToMethod(){} // RVA: 0x7069AF0
    }

    public class ListInitExpression : Expression
    {
        public object _newExpression;
        public object _initializers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7069D50
        public void get_NodeType(){} // RVA: 0xE686A0
        public void get_Type(){} // RVA: 0x10ACB60
        public void get_CanReduce(){} // RVA: 0xC2E4C0
        public void get_NewExpression(){} // RVA: 0xB5DBF0
        public void get_Initializers(){} // RVA: 0xB465B0
        public void Accept(){} // RVA: 0x7069C30
        public void Reduce(){} // RVA: 0x7069C60
        public void Update(){} // RVA: 0x7069C80
    }

    public class LogicalBinaryExpression : BinaryExpression
    {
        public object _nodeType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x701F590
        public void get_Type(){} // RVA: 0x701F5D0
        public void get_NodeType(){} // RVA: 0xFEAE90
    }

    public class LoopExpression : Expression
    {
        public object _body;
        public object _breakLabel;
        public object _continueLabel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706A040
        public void get_Type(){} // RVA: 0x7069EE0
        public void get_NodeType(){} // RVA: 0x68DAA00
        public void get_Body(){} // RVA: 0xB5DBF0
        public void get_BreakLabel(){} // RVA: 0xB465B0
        public void get_ContinueLabel(){} // RVA: 0xB700F0
        public void Accept(){} // RVA: 0x7069F70
        public void Update(){} // RVA: 0x7069FA0
    }

}