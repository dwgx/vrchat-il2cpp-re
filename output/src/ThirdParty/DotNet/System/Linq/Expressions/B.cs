// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 10
// Methods: 87

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class BinaryExpression : Expression
    {
        public object _right;
        public object _left;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x701F560
        public void get_CanReduce(){} // RVA: 0x701CEA0
        public void IsOpAssignment(){} // RVA: 0x701CED0
        public void get_Right(){} // RVA: 0xB5DBF0
        public void get_Left(){} // RVA: 0xB465B0
        public void get_Method(){} // RVA: 0x11F4110
        public void GetMethod(){} // RVA: 0xDAC980
        public void Update(){} // RVA: 0x701CEE0
        public void Reduce(){} // RVA: 0x701D140
        public void GetBinaryOpFromAssignmentOp(){} // RVA: 0x701D1C0
        public void ReduceVariable(){} // RVA: 0x701D2E0
        public void ReduceMember(){} // RVA: 0x701D420
        public void ReduceIndex(){} // RVA: 0x701D9D0
        public void get_Conversion(){} // RVA: 0x1D7BA30
        public void GetConversion(){} // RVA: 0xDAC980
        public void get_IsLifted(){} // RVA: 0x701E1F0
        public void get_IsLiftedToNull(){} // RVA: 0x701E420
        public void Accept(){} // RVA: 0x701E4A0
        public void Create(){} // RVA: 0x701E4D0
        public void get_IsLiftedLogical(){} // RVA: 0x701E6A0
        public void get_IsReferenceComparison(){} // RVA: 0x701E870
        public void ReduceUserdefinedLifted(){} // RVA: 0x701E970
    }

    public class Block2 : BlockExpression
    {
        public object _arg0;
        public object _arg1;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704AA70
        public void GetExpression(){} // RVA: 0x704AB80
        public void SameExpressions(){} // RVA: 0x704AC20
        public void get_ExpressionCount(){} // RVA: 0xC50A80
        public void GetOrMakeExpressions(){} // RVA: 0x704AEA0
        public void Rewrite(){} // RVA: 0x704AEB0
    }

    public class Block3 : BlockExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704AF40
        public void SameExpressions(){} // RVA: 0x704B0A0
        public void GetExpression(){} // RVA: 0x704B360
        public void get_ExpressionCount(){} // RVA: 0x12FC4A0
        public void GetOrMakeExpressions(){} // RVA: 0x704AEA0
        public void Rewrite(){} // RVA: 0x704B410
    }

    public class Block4 : BlockExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;
        public object _arg3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704B4C0
        public void SameExpressions(){} // RVA: 0x704B670
        public void GetExpression(){} // RVA: 0x704B980
        public void get_ExpressionCount(){} // RVA: 0x1347420
        public void GetOrMakeExpressions(){} // RVA: 0x704AEA0
        public void Rewrite(){} // RVA: 0x704BA40
    }

    public class Block5 : BlockExpression
    {
        public object _arg0;
        public object _arg1;
        public object _arg2;
        public object _arg3;
        public object _arg4;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704BB10
        public void GetExpression(){} // RVA: 0x704BD10
        public void SameExpressions(){} // RVA: 0x704BDE0
        public void get_ExpressionCount(){} // RVA: 0xEF4110
        public void GetOrMakeExpressions(){} // RVA: 0x704AEA0
        public void Rewrite(){} // RVA: 0x704C130
    }

    public class BlockExpression : Expression
    {
        // ── Methods ──
        public void get_Expressions(){} // RVA: 0x487D930
        public void get_Variables(){} // RVA: 0x26BC9C0
        public void get_Result(){} // RVA: 0x704A3A0
        public void .ctor(){} // RVA: 0x704A3E0
        public void Accept(){} // RVA: 0x704A430
        public void get_NodeType(){} // RVA: 0x68DAA10
        public void get_Type(){} // RVA: 0x704A460
        public void Update(){} // RVA: 0x704A4C0
        public void SameVariables(){} // RVA: 0x704A640
        public void SameExpressions(){} // RVA: 0x704A6A0
        public void GetExpression(){} // RVA: 0x704A6D0
        public void get_ExpressionCount(){} // RVA: 0x704A700
        public void GetOrMakeExpressions(){} // RVA: 0x704A730
        public void GetOrMakeVariables(){} // RVA: 0x704A760
        public void Rewrite(){} // RVA: 0x704A7C0
        public void ReturnReadOnlyExpressions(){} // RVA: 0x704A7F0
    }

    public class BlockExpressionList : Object
    {
        public object _block;
        public object _arg0;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void IndexOf(){} // RVA: 0x704D0F0
        public void Insert(){} // RVA: 0x704D1A0
        public void RemoveAt(){} // RVA: 0x704D1D0
        public void get_Item(){} // RVA: 0x704D200
        public void set_Item(){} // RVA: 0x704D240
        public void Add(){} // RVA: 0x704D270
        public void Clear(){} // RVA: 0x704D2A0
        public void Contains(){} // RVA: 0x704D2D0
        public void CopyTo(){} // RVA: 0x704D380
        public void get_Count(){} // RVA: 0x10ADE70
        public void get_IsReadOnly(){} // RVA: 0x704D610
        public void Remove(){} // RVA: 0x704D640
        public void GetEnumerator(){} // RVA: 0x704D670
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x704D670
    }

    public class BlockN : BlockExpression
    {
        public object _expressions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x704C220
        public void SameExpressions(){} // RVA: 0x704C2C0
        public void GetExpression(){} // RVA: 0x704C3A0
        public void get_ExpressionCount(){} // RVA: 0x704C400
        public void GetOrMakeExpressions(){} // RVA: 0x704C450
        public void Rewrite(){} // RVA: 0x704C490
    }

    public class ByRefAssignBinaryExpression : AssignBinaryExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x701F630
        public void get_IsByRef(){} // RVA: 0xC2E4C0
    }

    public class ByRefParameterExpression : TypedParameterExpression
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x706F9E0
        public void GetIsByRef(){} // RVA: 0xC2E4C0
    }

}