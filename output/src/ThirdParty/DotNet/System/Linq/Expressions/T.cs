// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 9
// Methods: 35

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class TryExpression : Expression
    {
        public System.Type Type; // 0x10
        public System.Linq.Expressions.Expression NodeType; // 0x18
        public System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.CatchBlock> Body; // 0x20
        public System.Linq.Expressions.Expression Handlers; // 0x28
        public System.Linq.Expressions.Expression Finally; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D9C9C0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_NodeType(){} // RVA: 0x7FFAC8D9C870
        public void get_Body(){} // RVA: 0x7FFAC2F247C0
        public void get_Handlers(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Finally(){} // RVA: 0x7FFAC2F4F130
        public void get_Fault(){} // RVA: 0x7FFAC31D95E0
        public void Accept(){} // RVA: 0x7FFAC8D9C880
        public void Update(){} // RVA: 0x7FFAC8D9C8B0
    }

    public class TypeBinaryExpression : Expression
    {
        public 0x6B1EC490 Type; // 0x10
        public System.Linq.Expressions.Expression NodeType; // 0x18
        public System.Type Expression; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D9DBC0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC8D9CB10
        public void get_NodeType(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Expression(){} // RVA: 0x7FFAC2F247C0
        public void get_TypeOperand(){} // RVA: 0x7FFAC2F4F0C0
        public void ReduceTypeEqual(){} // RVA: 0x7FFAC8D9CBC0
        public void ByValParameterTypeEqual(){} // RVA: 0x7FFAC8D9D390
        public void ReduceConstantTypeEqual(){} // RVA: 0x7FFAC8D9D910
        public void Accept(){} // RVA: 0x7FFAC8D9DAD0
        public void Update(){} // RVA: 0x7FFAC8D9DB00
    }

    public class TypedConstantExpression : ConstantExpression
    {
        public System.Type Type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D76DC0
        public void get_Type(){} // RVA: 0x7FFAC2F247C0
    }

    public class TypedDynamicExpression1 : DynamicExpression1
    {
        public System.Type Type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7DDF0
        public void get_Type(){} // RVA: 0x7FFAC2F4F130
    }

    public class TypedDynamicExpression2 : DynamicExpression2
    {
        public System.Type Type; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7E540
        public void get_Type(){} // RVA: 0x7FFAC31D95E0
    }

    public class TypedDynamicExpression3 : DynamicExpression3
    {
        public System.Type Type; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7EAF0
        public void get_Type(){} // RVA: 0x7FFAC31D0140
    }

    public class TypedDynamicExpression4 : DynamicExpression4
    {
        public System.Type Type; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7F170
        public void get_Type(){} // RVA: 0x7FFAC2F9E740
    }

    public class TypedDynamicExpressionN : DynamicExpressionN
    {
        public System.Type Type; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D7DDF0
        public void get_Type(){} // RVA: 0x7FFAC2F4F130
    }

    public class TypedParameterExpression : ParameterExpression
    {
        public System.Type Type; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D98730
        public void get_Type(){} // RVA: 0x7FFAC2F247C0
    }

}