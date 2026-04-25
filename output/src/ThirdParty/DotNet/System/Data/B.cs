// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Data
// Classes: 1
// Methods: 23

namespace ThirdParty.DotNet.System.Data
{
    public class BinaryNode : ExpressionNode
    {
        public int _op; // 0x18
        public System.Data.ExpressionNode _left; // 0x20
        public System.Data.ExpressionNode _right; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8EAB260
        public void Bind(){} // RVA: 0x7FFAC8EAB370
        public void Eval(){} // RVA: 0x7FFAC8EABBD0 | overloaded x4
        public void IsConstant(){} // RVA: 0x7FFAC8EAB4A0
        public void IsTableConstant(){} // RVA: 0x7FFAC8EAB500
        public void HasLocalAggregate(){} // RVA: 0x7FFAC8EAB560
        public void HasRemoteAggregate(){} // RVA: 0x7FFAC8EAB5C0
        public void DependsOn(){} // RVA: 0x7FFAC8EAB620
        public void Optimize(){} // RVA: 0x7FFAC8EAB690
        public void SetTypeMismatchError(){} // RVA: 0x7FFAC8EABB90
        public void BinaryCompare(){} // RVA: 0x7FFAC8EABC50 | overloaded x2
        public void EvalBinaryOp(){} // RVA: 0x7FFAC8EACAC0
        public void GetPrecedence(){} // RVA: 0x7FFAC8EB0F80
        public void GetPrecedenceType(){} // RVA: 0x7FFAC8EB1110
        public void IsMixed(){} // RVA: 0x7FFAC8EB1280
        public void IsMixedSql(){} // RVA: 0x7FFAC8EB12F0
        public void ResultType(){} // RVA: 0x7FFAC8EB1370
        public void ResultSqlType(){} // RVA: 0x7FFAC8EB16D0
        public void SqlResultType(){} // RVA: 0x7FFAC8EB1B80
    }

}