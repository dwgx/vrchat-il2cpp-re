// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions
// Classes: 2
// Methods: 20

namespace ThirdParty.DotNet.System.Linq.Expressions
{
    public class UnaryExpression : Expression
    {
        public System.Type _type; // 0x10
        public 0x665E5D54 _nodeType; // 0x18
        public System.Linq.Expressions.Expression _operand; // 0x20
        public System.Reflection.MethodInfo _method; // 0x28
        public object field_4; // 0x268
        public object field_5; // 0x269
        public object field_6; // 0x26A
        public object field_7; // 0x26B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87147CC0 | overloaded x2
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_NodeType(){} // RVA: 0x7FFE813DB630
        public void get_Operand(){} // RVA: 0x7FFE811290C0
        public void get_Method(){} // RVA: 0x7FFE81129130
        public void get_IsLifted(){} // RVA: 0x7FFE87146180
        public void get_IsLiftedToNull(){} // RVA: 0x7FFE871463F0
        public void Accept(){} // RVA: 0x7FFE87146470
        public void get_CanReduce(){} // RVA: 0x7FFE871464A0
        public void Reduce(){} // RVA: 0x7FFE871464D0
        public void get_IsPrefix(){} // RVA: 0x7FFE87146550
        public void FunctionalOp(){} // RVA: 0x7FFE871465A0
        public void ReduceVariable(){} // RVA: 0x7FFE871466A0
        public void ReduceMember(){} // RVA: 0x7FFE87146A60
        public void ReduceIndex(){} // RVA: 0x7FFE87147150
        public void Update(){} // RVA: 0x7FFE87147BF0
    }

    public class Utils : Object
    {
        // ── Methods ──
        public void Constant(){} // RVA: 0x7FFE87147D80 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87147F30
    }

}