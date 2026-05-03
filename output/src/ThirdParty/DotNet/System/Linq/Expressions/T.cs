// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 9
// Methods: 35

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class TryExpression : Expression
    {
        public System.Type _type; // 0x10
        public System.Linq.Expressions.Expression _body; // 0x18
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.CatchBlock> _handlers; // 0x20
        public System.Linq.Expressions.Expression _finally; // 0x28
        public System.Linq.Expressions.Expression _fault; // 0x30
        public object field_5; // 0x25E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87144DF0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_NodeType(){} // RVA: 0x7FFE87144CA0
        public void get_Body(){} // RVA: 0x7FFE810FE7C0
        public void get_Handlers(){} // RVA: 0x7FFE811290C0
        public void get_Finally(){} // RVA: 0x7FFE81129130
        public void get_Fault(){} // RVA: 0x7FFE8144E200
        public void Accept(){} // RVA: 0x7FFE87144CB0
        public void Update(){} // RVA: 0x7FFE87144CE0
    }

    public class TypeBinaryExpression : Expression
    {
        public 0x665E5D54 _nodeType; // 0x10
        public System.Linq.Expressions.Expression _expression; // 0x18
        public System.Type _typeOperand; // 0x20
        public object field_3; // 0x264

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87145FF0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE87144F40
        public void get_NodeType(){} // RVA: 0x7FFE811485C0
        public void get_Expression(){} // RVA: 0x7FFE810FE7C0
        public void get_TypeOperand(){} // RVA: 0x7FFE811290C0
        public void ReduceTypeEqual(){} // RVA: 0x7FFE87144FF0
        public void ByValParameterTypeEqual(){} // RVA: 0x7FFE871457C0
        public void ReduceConstantTypeEqual(){} // RVA: 0x7FFE87145D40
        public void Accept(){} // RVA: 0x7FFE87145F00
        public void Update(){} // RVA: 0x7FFE87145F30
    }

    public class TypedConstantExpression : ConstantExpression
    {
        public System.Type _type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711F1F0
        public void get_Type(){} // RVA: 0x7FFE810FE7C0
    }

    public class TypedDynamicExpression1 : DynamicExpression1
    {
        public System.Type _type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87126220
        public void get_Type(){} // RVA: 0x7FFE81129130
    }

    public class TypedDynamicExpression2 : DynamicExpression2
    {
        public System.Type _type; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87126970
        public void get_Type(){} // RVA: 0x7FFE8144E200
    }

    public class TypedDynamicExpression3 : DynamicExpression3
    {
        public System.Type _type; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87126F20
        public void get_Type(){} // RVA: 0x7FFE8143BA80
    }

    public class TypedDynamicExpression4 : DynamicExpression4
    {
        public System.Type _type; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE871275A0
        public void get_Type(){} // RVA: 0x7FFE81178740
    }

    public class TypedDynamicExpressionN : DynamicExpressionN
    {
        public System.Type _type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87126220
        public void get_Type(){} // RVA: 0x7FFE81129130
    }

    public class TypedParameterExpression : ParameterExpression
    {
        public System.Type _type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87140B60
        public void get_Type(){} // RVA: 0x7FFE810FE7C0
    }

}