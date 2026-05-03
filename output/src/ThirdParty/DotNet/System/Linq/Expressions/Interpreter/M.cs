// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 4
// Methods: 21

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class MethodInfoCallInstruction : CallInstruction
    {
        public System.Reflection.MethodInfo _target; // 0x10
        public int _argumentCount; // 0x18

        // ── Methods ──
        public void get_ArgumentCount(){} // RVA: 0x7FFE813DB630
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
        public void get_ProducedStack(){} // RVA: 0x7FFE8714E4F0
        public void Run(){} // RVA: 0x7FFE8714E5F0
        public void GetArgs(){} // RVA: 0x7FFE8714E900
        public void ToString(){} // RVA: 0x7FFE8714EA90
    }

    public class ModuloInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87186B90
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87186BD0
    }

    public class MulInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87187B60
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87187BA0
    }

    public class MulOvfInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87188B20
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87188B60
    }

}