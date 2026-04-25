// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 2
// Methods: 20

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class UnaryExpression : Expression
    {
        public System.Type Type; // 0x10
        public 0x6B1EC490 NodeType; // 0x18
        public System.Linq.Expressions.Expression Operand; // 0x20
        public System.Reflection.MethodInfo Method; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8D9F890 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_NodeType(){} // RVA: 0x7FFAC3157800
        public void get_Operand(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Method(){} // RVA: 0x7FFAC2F4F130
        public void get_IsLifted(){} // RVA: 0x7FFAC8D9DD50
        public void get_IsLiftedToNull(){} // RVA: 0x7FFAC8D9DFC0
        public void Accept(){} // RVA: 0x7FFAC8D9E040
        public void get_CanReduce(){} // RVA: 0x7FFAC8D9E070
        public void Reduce(){} // RVA: 0x7FFAC8D9E0A0
        public void get_IsPrefix(){} // RVA: 0x7FFAC8D9E120
        public void FunctionalOp(){} // RVA: 0x7FFAC8D9E170
        public void ReduceVariable(){} // RVA: 0x7FFAC8D9E270
        public void ReduceMember(){} // RVA: 0x7FFAC8D9E630
        public void ReduceIndex(){} // RVA: 0x7FFAC8D9ED20
        public void Update(){} // RVA: 0x7FFAC8D9F7C0
    }

    public class Utils : Object
    {
        public object BoxedFalse;
        public object BoxedTrue; // 0x8
        public object BoxedIntM1; // 0x10
        public object BoxedInt0; // 0x18
        public object BoxedInt1; // 0x20
        public object BoxedInt2; // 0x28
        public object BoxedInt3; // 0x30
        public object BoxedDefaultSByte; // 0x38
        public object BoxedDefaultChar; // 0x40
        public object BoxedDefaultInt16; // 0x48
        public object BoxedDefaultInt64; // 0x50
        public object BoxedDefaultByte; // 0x58
        public object BoxedDefaultUInt16; // 0x60
        public object BoxedDefaultUInt32; // 0x68
        public object BoxedDefaultUInt64; // 0x70
        public object BoxedDefaultSingle; // 0x78
        public object BoxedDefaultDouble; // 0x80
        public object BoxedDefaultDecimal; // 0x88
        public object BoxedDefaultDateTime; // 0x90
        public System.Linq.Expressions.ConstantExpression s_true; // 0x98
        public System.Linq.Expressions.ConstantExpression s_false; // 0xA0
        public System.Linq.Expressions.ConstantExpression s_m1; // 0xA8
        public System.Linq.Expressions.ConstantExpression s_0; // 0xB0
        public System.Linq.Expressions.ConstantExpression s_1; // 0xB8
        public System.Linq.Expressions.ConstantExpression s_2; // 0xC0
        public System.Linq.Expressions.ConstantExpression s_3; // 0xC8
        public System.Linq.Expressions.DefaultExpression Empty; // 0xD0
        public System.Linq.Expressions.ConstantExpression Null; // 0xD8

        // ── Methods ──
        public void Constant(){} // RVA: 0x7FFAC8D9F950 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC8D9FB00
    }

}