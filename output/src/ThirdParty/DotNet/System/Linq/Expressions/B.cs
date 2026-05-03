// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 10
// Methods: 88

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class BinaryExpression : Expression
    {
        public System.Linq.Expressions.Expression _right; // 0x10
        public System.Linq.Expressions.Expression _left; // 0x18
        public object field_2; // 0x7B
        public object field_3; // 0x7C
        public object field_4; // 0x7D
        public object field_5; // 0x7E
        public object field_6; // 0x7F
        public object field_7; // 0x80
        public object field_8; // 0x81

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870EFC90 | overloaded x2
        public void get_CanReduce(){} // RVA: 0x7FFE870ED600
        public void IsOpAssignment(){} // RVA: 0x7FFE870ED630
        public void get_Right(){} // RVA: 0x7FFE81116380
        public void get_Left(){} // RVA: 0x7FFE810FE7C0
        public void get_Method(){} // RVA: 0x7FFE844800F0
        public void GetMethod(){} // RVA: 0x7FFE813240E0
        public void Update(){} // RVA: 0x7FFE870ED640
        public void Reduce(){} // RVA: 0x7FFE870ED8A0
        public void GetBinaryOpFromAssignmentOp(){} // RVA: 0x7FFE870ED920
        public void ReduceVariable(){} // RVA: 0x7FFE870EDA40
        public void ReduceMember(){} // RVA: 0x7FFE870EDB80
        public void ReduceIndex(){} // RVA: 0x7FFE870EE130
        public void get_Conversion(){} // RVA: 0x7FFE870EE950
        public void GetConversion(){} // RVA: 0x7FFE813240E0
        public void get_IsLifted(){} // RVA: 0x7FFE870EE970
        public void get_IsLiftedToNull(){} // RVA: 0x7FFE870EEB60
        public void Accept(){} // RVA: 0x7FFE870EEBE0
        public void Create(){} // RVA: 0x7FFE870EEC10
        public void get_IsLiftedLogical(){} // RVA: 0x7FFE870EEDD0
        public void get_IsReferenceComparison(){} // RVA: 0x7FFE870EEFA0
        public void ReduceUserdefinedLifted(){} // RVA: 0x7FFE870EF0A0
    }

    public class Block2 : BlockExpression
    {
        public object _arg0; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711B560
        public void GetExpression(){} // RVA: 0x7FFE8711B670
        public void SameExpressions(){} // RVA: 0x7FFE8711B710
        public void get_ExpressionCount(){} // RVA: 0x7FFE81200CB0
        public void GetOrMakeExpressions(){} // RVA: 0x7FFE8711B9A0
        public void Rewrite(){} // RVA: 0x7FFE8711B9B0
    }

    public class Block3 : BlockExpression
    {
        public object _arg0; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711BA40
        public void SameExpressions(){} // RVA: 0x7FFE8711BBA0
        public void GetExpression(){} // RVA: 0x7FFE8711BE70
        public void get_ExpressionCount(){} // RVA: 0x7FFE817BF630
        public void GetOrMakeExpressions(){} // RVA: 0x7FFE8711B9A0
        public void Rewrite(){} // RVA: 0x7FFE8711BF20
    }

    public class Block4 : BlockExpression
    {
        public object _arg0; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711BFD0
        public void SameExpressions(){} // RVA: 0x7FFE8711C180
        public void GetExpression(){} // RVA: 0x7FFE8711C490
        public void get_ExpressionCount(){} // RVA: 0x7FFE8180E590
        public void GetOrMakeExpressions(){} // RVA: 0x7FFE8711B9A0
        public void Rewrite(){} // RVA: 0x7FFE8711C550
    }

    public class Block5 : BlockExpression
    {
        public object _arg0; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711C620
        public void GetExpression(){} // RVA: 0x7FFE8711C820
        public void SameExpressions(){} // RVA: 0x7FFE8711C8F0
        public void get_ExpressionCount(){} // RVA: 0x7FFE81474A10
        public void GetOrMakeExpressions(){} // RVA: 0x7FFE8711B9A0
        public void Rewrite(){} // RVA: 0x7FFE8711CC50
    }

    public class BlockExpression : Expression
    {
        // ── Methods ──
        public void get_Expressions(){} // RVA: 0x7FFE82215450
        public void get_Variables(){} // RVA: 0x7FFE82BC3B70
        public void get_Result(){} // RVA: 0x7FFE8711AE40
        public void .ctor(){} // RVA: 0x7FFE8711AE80
        public void Accept(){} // RVA: 0x7FFE8711AED0
        public void get_NodeType(){} // RVA: 0x7FFE869A2440
        public void get_Type(){} // RVA: 0x7FFE8711AF00
        public void Update(){} // RVA: 0x7FFE8711AF60
        public void SameVariables(){} // RVA: 0x7FFE8711B0E0
        public void SameExpressions(){} // RVA: 0x7FFE8711B140
        public void GetExpression(){} // RVA: 0x7FFE8711B170
        public void get_ExpressionCount(){} // RVA: 0x7FFE8711B1A0
        public void GetOrMakeExpressions(){} // RVA: 0x7FFE8711B1D0
        public void GetOrMakeVariables(){} // RVA: 0x7FFE8711B200
        public void Rewrite(){} // RVA: 0x7FFE8711B260
        public void ReturnReadOnlyExpressions(){} // RVA: 0x7FFE8711B290
    }

    public class BlockExpressionList : Object
    {
        public System.Linq.Expressions.BlockExpression _block; // 0x10
        public System.Linq.Expressions.Expression _arg0; // 0x18
        public object field_2; // 0x14B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void IndexOf(){} // RVA: 0x7FFE8711DC20
        public void Insert(){} // RVA: 0x7FFE8711DCD0
        public void RemoveAt(){} // RVA: 0x7FFE8711DD00
        public void get_Item(){} // RVA: 0x7FFE8711DD30
        public void set_Item(){} // RVA: 0x7FFE8711DD70
        public void Add(){} // RVA: 0x7FFE8711DDA0
        public void Clear(){} // RVA: 0x7FFE8711DDD0
        public void Contains(){} // RVA: 0x7FFE8711DE00
        public void CopyTo(){} // RVA: 0x7FFE8711DEB0
        public void get_Count(){} // RVA: 0x7FFE815889F0
        public void get_IsReadOnly(){} // RVA: 0x7FFE8711E130
        public void Remove(){} // RVA: 0x7FFE8711E160
        public void GetEnumerator(){} // RVA: 0x7FFE8711E190
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8711E190
    }

    public class BlockN : BlockExpression
    {
        public System.Collections.Generic.IReadOnlyList`1<System.Linq.Expressions.Expression> _expressions; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8711CD40
        public void SameExpressions(){} // RVA: 0x7FFE8711CDE0
        public void GetExpression(){} // RVA: 0x7FFE8711CEC0
        public void get_ExpressionCount(){} // RVA: 0x7FFE8711CF20
        public void GetOrMakeExpressions(){} // RVA: 0x7FFE8711CF70
        public void Rewrite(){} // RVA: 0x7FFE8711CFB0
    }

    public class ByRefAssignBinaryExpression : AssignBinaryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870EFDB0
        public void get_IsByRef(){} // RVA: 0x7FFE811E0850
    }

    public class ByRefParameterExpression : TypedParameterExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87140B50
        public void GetIsByRef(){} // RVA: 0x7FFE811E0850
    }

}