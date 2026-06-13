// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 10
// Methods: 88

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class BinaryExpression
    {
        public System.Linq.Expressions.Expression <Right>k__BackingField; // 0x10
        public System.Linq.Expressions.Expression <Left>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65B0E00 | overloaded x2
        public void get_CanReduce(){} // RVA: 0x65AE770
        public void IsOpAssignment(){} // RVA: 0x65AE7A0
        public void get_Right(){} // RVA: 0x2F8380
        public void get_Left(){} // RVA: 0x2E07C0
        public void get_Method(){} // RVA: 0x37EF790
        public void GetMethod(){} // RVA: 0x519240
        public void Update(){} // RVA: 0x65AE7B0
        public void Reduce(){} // RVA: 0x65AEA10
        public void GetBinaryOpFromAssignmentOp(){} // RVA: 0x65AEA90
        public void ReduceVariable(){} // RVA: 0x65AEBB0
        public void ReduceMember(){} // RVA: 0x65AECF0
        public void ReduceIndex(){} // RVA: 0x65AF2A0
        public void get_Conversion(){} // RVA: 0x65AFAC0
        public void GetConversion(){} // RVA: 0x519240
        public void get_IsLifted(){} // RVA: 0x65AFAE0
        public void get_IsLiftedToNull(){} // RVA: 0x65AFCD0
        public void Accept(){} // RVA: 0x65AFD50
        public void Create(){} // RVA: 0x65AFD80
        public void get_IsLiftedLogical(){} // RVA: 0x65AFF40
        public void get_IsReferenceComparison(){} // RVA: 0x65B0110
        public void ReduceUserdefinedLifted(){} // RVA: 0x65B0210
    }

    public class Block2
    {
        public object _arg0; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DC6D0
        public void GetExpression(){} // RVA: 0x65DC7E0
        public void SameExpressions(){} // RVA: 0x65DC880
        public void get_ExpressionCount(){} // RVA: 0x3E2CB0
        public void GetOrMakeExpressions(){} // RVA: 0x65DCB10
        public void Rewrite(){} // RVA: 0x65DCB20
    }

    public class Block3
    {
        public object _arg0; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DCBB0
        public void SameExpressions(){} // RVA: 0x65DCD10
        public void GetExpression(){} // RVA: 0x65DCFE0
        public void get_ExpressionCount(){} // RVA: 0xA308B0
        public void GetOrMakeExpressions(){} // RVA: 0x65DCB10
        public void Rewrite(){} // RVA: 0x65DD090
    }

    public class Block4
    {
        public object _arg0; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DD140
        public void SameExpressions(){} // RVA: 0x65DD2F0
        public void GetExpression(){} // RVA: 0x65DD600
        public void get_ExpressionCount(){} // RVA: 0xA7E130
        public void GetOrMakeExpressions(){} // RVA: 0x65DCB10
        public void Rewrite(){} // RVA: 0x65DD6C0
    }

    public class Block5
    {
        public object _arg0; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DD790
        public void GetExpression(){} // RVA: 0x65DD990
        public void SameExpressions(){} // RVA: 0x65DDA60
        public void get_ExpressionCount(){} // RVA: 0x66CCC0
        public void GetOrMakeExpressions(){} // RVA: 0x65DCB10
        public void Rewrite(){} // RVA: 0x65DDDC0
    }

    public class BlockExpression
    {
        // ── Methods ──
        public void get_Expressions(){} // RVA: 0x1854D10
        public void get_Variables(){} // RVA: 0xAE50F0
        public void get_Result(){} // RVA: 0x65DBFB0
        public void .ctor(){} // RVA: 0x65DBFF0
        public void Accept(){} // RVA: 0x65DC040
        public void get_NodeType(){} // RVA: 0x5E61600
        public void get_Type(){} // RVA: 0x65DC070
        public void Update(){} // RVA: 0x65DC0D0
        public void SameVariables(){} // RVA: 0x65DC250
        public void SameExpressions(){} // RVA: 0x65DC2B0
        public void GetExpression(){} // RVA: 0x65DC2E0
        public void get_ExpressionCount(){} // RVA: 0x65DC310
        public void GetOrMakeExpressions(){} // RVA: 0x65DC340
        public void GetOrMakeVariables(){} // RVA: 0x65DC370
        public void Rewrite(){} // RVA: 0x65DC3D0
        public void ReturnReadOnlyExpressions(){} // RVA: 0x65DC400
    }

    public class BlockExpressionList
    {
        public System.Linq.Expressions.BlockExpression _block; // 0x10
        public System.Linq.Expressions.Expression _arg0; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void IndexOf(){} // RVA: 0x65DED90
        public void Insert(){} // RVA: 0x65DEE40
        public void RemoveAt(){} // RVA: 0x65DEE70
        public void get_Item(){} // RVA: 0x65DEEA0
        public void set_Item(){} // RVA: 0x65DEEE0
        public void Add(){} // RVA: 0x65DEF10
        public void Clear(){} // RVA: 0x65DEF40
        public void Contains(){} // RVA: 0x65DEF70
        public void CopyTo(){} // RVA: 0x65DF020
        public void get_Count(){} // RVA: 0x7F0310
        public void get_IsReadOnly(){} // RVA: 0x65DF2A0
        public void Remove(){} // RVA: 0x65DF2D0
        public void GetEnumerator(){} // RVA: 0x65DF300
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x65DF300
    }

    public class BlockN
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> _expressions; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65DDEB0
        public void SameExpressions(){} // RVA: 0x65DDF50
        public void GetExpression(){} // RVA: 0x65DE030
        public void get_ExpressionCount(){} // RVA: 0x65DE090
        public void GetOrMakeExpressions(){} // RVA: 0x65DE0E0
        public void Rewrite(){} // RVA: 0x65DE120
    }

    public class ByRefAssignBinaryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65B0F20
        public void get_IsByRef(){} // RVA: 0x3C2850
    }

    public class ByRefParameterExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6601C90
        public void GetIsByRef(){} // RVA: 0x3C2850
    }

}