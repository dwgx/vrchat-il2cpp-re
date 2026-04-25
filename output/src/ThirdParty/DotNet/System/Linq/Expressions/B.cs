// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 10
// Methods: 88

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class BinaryExpression : Expression
    {
        public System.Linq.Expressions.Expression CanReduce; // 0x10
        public System.Linq.Expressions.Expression Right; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D477D0 | overloaded x2
        public void get_CanReduce(){} // RVA: 0x7FFAC8D45140
        public void IsOpAssignment(){} // RVA: 0x7FFAC8D45170
        public void get_Right(){} // RVA: 0x7FFAC2F3C380
        public void get_Left(){} // RVA: 0x7FFAC2F247C0
        public void get_Method(){} // RVA: 0x7FFAC3F5BE50
        public void GetMethod(){} // RVA: 0x7FFAC34F9180
        public void Update(){} // RVA: 0x7FFAC8D45180
        public void Reduce(){} // RVA: 0x7FFAC8D453E0
        public void GetBinaryOpFromAssignmentOp(){} // RVA: 0x7FFAC8D45460
        public void ReduceVariable(){} // RVA: 0x7FFAC8D45580
        public void ReduceMember(){} // RVA: 0x7FFAC8D456C0
        public void ReduceIndex(){} // RVA: 0x7FFAC8D45C70
        public void get_Conversion(){} // RVA: 0x7FFAC8D46490
        public void GetConversion(){} // RVA: 0x7FFAC34F9180
        public void get_IsLifted(){} // RVA: 0x7FFAC8D464B0
        public void get_IsLiftedToNull(){} // RVA: 0x7FFAC8D466A0
        public void Accept(){} // RVA: 0x7FFAC8D46720
        public void Create(){} // RVA: 0x7FFAC8D46750
        public void get_IsLiftedLogical(){} // RVA: 0x7FFAC8D46910
        public void get_IsReferenceComparison(){} // RVA: 0x7FFAC8D46AE0
        public void ReduceUserdefinedLifted(){} // RVA: 0x7FFAC8D46BE0
    }

    public class Block2 : BlockExpression
    {
        public object ExpressionCount; // 0x10
        public System.Linq.Expressions.Expression _arg1; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D73130
        public void GetExpression(){} // RVA: 0x7FFAC8D73240
        public void SameExpressions(){} // RVA: 0x7FFAC8D732E0
        public void get_ExpressionCount(){} // RVA: 0x7FFAC3026CB0
        public void GetOrMakeExpressions(){} // RVA: 0x7FFAC8D73570
        public void Rewrite(){} // RVA: 0x7FFAC8D73580
    }

    public class Block3 : BlockExpression
    {
        public object ExpressionCount; // 0x10
        public System.Linq.Expressions.Expression _arg1; // 0x18
        public System.Linq.Expressions.Expression _arg2; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D73610
        public void SameExpressions(){} // RVA: 0x7FFAC8D73770
        public void GetExpression(){} // RVA: 0x7FFAC8D73A40
        public void get_ExpressionCount(){} // RVA: 0x7FFAC366FE20
        public void GetOrMakeExpressions(){} // RVA: 0x7FFAC8D73570
        public void Rewrite(){} // RVA: 0x7FFAC8D73AF0
    }

    public class Block4 : BlockExpression
    {
        public object ExpressionCount; // 0x10
        public System.Linq.Expressions.Expression _arg1; // 0x18
        public System.Linq.Expressions.Expression _arg2; // 0x20
        public System.Linq.Expressions.Expression _arg3; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D73BA0
        public void SameExpressions(){} // RVA: 0x7FFAC8D73D50
        public void GetExpression(){} // RVA: 0x7FFAC8D74060
        public void get_ExpressionCount(){} // RVA: 0x7FFAC36C3910
        public void GetOrMakeExpressions(){} // RVA: 0x7FFAC8D73570
        public void Rewrite(){} // RVA: 0x7FFAC8D74120
    }

    public class Block5 : BlockExpression
    {
        public object ExpressionCount; // 0x10
        public System.Linq.Expressions.Expression _arg1; // 0x18
        public System.Linq.Expressions.Expression _arg2; // 0x20
        public System.Linq.Expressions.Expression _arg3; // 0x28
        public System.Linq.Expressions.Expression _arg4; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D741F0
        public void GetExpression(){} // RVA: 0x7FFAC8D743F0
        public void SameExpressions(){} // RVA: 0x7FFAC8D744C0
        public void get_ExpressionCount(){} // RVA: 0x7FFAC31E48B0
        public void GetOrMakeExpressions(){} // RVA: 0x7FFAC8D73570
        public void Rewrite(){} // RVA: 0x7FFAC8D74820
    }

    public class BlockExpression : Expression
    {
        public object Expressions;
        public object Variables;
        public object Result;
        public object NodeType;
        public object Type;
        public object ExpressionCount;

        // ── Methods ──
        public void get_Expressions(){} // RVA: 0x7FFAC8AEC8C0
        public void get_Variables(){} // RVA: 0x7FFAC3708F90
        public void get_Result(){} // RVA: 0x7FFAC8D72A10
        public void .ctor(){} // RVA: 0x7FFAC8D72A50
        public void Accept(){} // RVA: 0x7FFAC8D72AA0
        public void get_NodeType(){} // RVA: 0x7FFAC85F8C70
        public void get_Type(){} // RVA: 0x7FFAC8D72AD0
        public void Update(){} // RVA: 0x7FFAC8D72B30
        public void SameVariables(){} // RVA: 0x7FFAC8D72CB0
        public void SameExpressions(){} // RVA: 0x7FFAC8D72D10
        public void GetExpression(){} // RVA: 0x7FFAC8D72D40
        public void get_ExpressionCount(){} // RVA: 0x7FFAC8D72D70
        public void GetOrMakeExpressions(){} // RVA: 0x7FFAC8D72DA0
        public void GetOrMakeVariables(){} // RVA: 0x7FFAC8D72DD0
        public void Rewrite(){} // RVA: 0x7FFAC8D72E30
        public void ReturnReadOnlyExpressions(){} // RVA: 0x7FFAC8D72E60
    }

    public class BlockExpressionList : Object
    {
        public System.Linq.Expressions.BlockExpression Item; // 0x10
        public System.Linq.Expressions.Expression Count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void IndexOf(){} // RVA: 0x7FFAC8D757F0
        public void Insert(){} // RVA: 0x7FFAC8D758A0
        public void RemoveAt(){} // RVA: 0x7FFAC8D758D0
        public void get_Item(){} // RVA: 0x7FFAC8D75900
        public void set_Item(){} // RVA: 0x7FFAC8D75940
        public void Add(){} // RVA: 0x7FFAC8D75970
        public void Clear(){} // RVA: 0x7FFAC8D759A0
        public void Contains(){} // RVA: 0x7FFAC8D759D0
        public void CopyTo(){} // RVA: 0x7FFAC8D75A80
        public void get_Count(){} // RVA: 0x7FFAC8D71620
        public void get_IsReadOnly(){} // RVA: 0x7FFAC8D75D00
        public void Remove(){} // RVA: 0x7FFAC8D75D30
        public void GetEnumerator(){} // RVA: 0x7FFAC8D75D60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8D75D60
    }

    public class BlockN : BlockExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> ExpressionCount; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D74910
        public void SameExpressions(){} // RVA: 0x7FFAC8D749B0
        public void GetExpression(){} // RVA: 0x7FFAC8D74A90
        public void get_ExpressionCount(){} // RVA: 0x7FFAC8D74AF0
        public void GetOrMakeExpressions(){} // RVA: 0x7FFAC8D74B40
        public void Rewrite(){} // RVA: 0x7FFAC8D74B80
    }

    public class ByRefAssignBinaryExpression : AssignBinaryExpression
    {
        public object IsByRef;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D478F0
        public void get_IsByRef(){} // RVA: 0x7FFAC3006850
    }

    public class ByRefParameterExpression : TypedParameterExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D98720
        public void GetIsByRef(){} // RVA: 0x7FFAC3006850
    }

}