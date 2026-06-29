// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 9
// Methods: 33

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class TryExpression : Expression
    {
        public object _type;
        public object _body;
        public object _handlers;
        public object _finally;
        public object _fault;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7073E50
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_NodeType(){} // RVA: 0x7073D00
        public void get_Body(){} // RVA: 0xB465B0
        public void get_Handlers(){} // RVA: 0xB700F0
        public void get_Finally(){} // RVA: 0xB70160
        public void get_Fault(){} // RVA: 0xD33E60
        public void Accept(){} // RVA: 0x7073D10
        public void Update(){} // RVA: 0x7073D40
    }

    public class TypeBinaryExpression : Expression
    {
        public object _nodeType;
        public object _expression;
        public object _typeOperand;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7074F20
        public void get_Type(){} // RVA: 0x701F5D0
        public void get_NodeType(){} // RVA: 0xB8F8F0
        public void get_Expression(){} // RVA: 0xB465B0
        public void get_TypeOperand(){} // RVA: 0xB700F0
        public void ReduceTypeEqual(){} // RVA: 0x7073FA0
        public void ByValParameterTypeEqual(){} // RVA: 0x7074720
        public void ReduceConstantTypeEqual(){} // RVA: 0x7074C90
        public void Accept(){} // RVA: 0x7074E30
        public void Update(){} // RVA: 0x7074E60
    }

    public class TypedConstantExpression : ConstantExpression
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704E6F0
        public void get_Type(){} // RVA: 0xB465B0
    }

    public class TypedDynamicExpression1 : DynamicExpression1
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70553E0
        public void get_Type(){} // RVA: 0xB70160
    }

    public class TypedDynamicExpression2 : DynamicExpression2
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7055B40
        public void get_Type(){} // RVA: 0xD33E60
    }

    public class TypedDynamicExpression3 : DynamicExpression3
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70560E0
        public void get_Type(){} // RVA: 0xD05CA0
    }

    public class TypedDynamicExpression4 : DynamicExpression4
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7056750
        public void get_Type(){} // RVA: 0xBC1B30
    }

    public class TypedDynamicExpressionN : DynamicExpressionN
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70553E0
        public void get_Type(){} // RVA: 0xB70160
    }

    public class TypedParameterExpression : ParameterExpression
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x706F9F0
        public void get_Type(){} // RVA: 0xB465B0
    }

}