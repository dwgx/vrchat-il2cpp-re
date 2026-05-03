// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 4
// Methods: 23

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class GetArrayItemInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.GetArrayItemInstruction Instance;
        public object field_1; // 0x282
        public object field_2; // 0x283

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8714CB50
        public void Run(){} // RVA: 0x7FFE8714CB90
        public void .cctor(){} // RVA: 0x7FFE8714CCF0
    }

    public class GotoInstruction : IndexedBranchInstruction
    {
        public int Variants;
        public System.Linq.Expressions.Interpreter.GotoInstruction[] s_cache;
        public bool _hasResult; // 0x18

        // ── Methods ──
        public void get_InstructionName(){} // RVA: 0x7FFE87150140
        public void get_ConsumedStack(){} // RVA: 0x7FFE8714FEE0
        public void get_ProducedStack(){} // RVA: 0x7FFE8714FEF0
        public void .ctor(){} // RVA: 0x7FFE87150180
        public void Create(){} // RVA: 0x7FFE871501A0
        public void Run(){} // RVA: 0x7FFE87150340
        public void .cctor(){} // RVA: 0x7FFE87150450
    }

    public class GreaterThanInstruction : Instruction
    {
        public object _nullValue; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87157DF0
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Create(){} // RVA: 0x7FFE87157E30
    }

    public class GreaterThanOrEqualInstruction : Instruction
    {
        public object _nullValue; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87159B30
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Create(){} // RVA: 0x7FFE87159B70
    }

}