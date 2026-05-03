// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 41

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class AddInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87149600
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87149640
    }

    public class AddOvfInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8714A5A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE8714A5E0
    }

    public class AndInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8714B500
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE8714B540
    }

    public class ArrayByRefUpdater : ByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8717FE40
        public void Update(){} // RVA: 0x7FFE8717FF00
        public void UndefineTemps(){} // RVA: 0x7FFE87180020
    }

    public class ArrayLengthInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.ArrayLengthInstruction Instance;
        public object field_1; // 0x287
        public object field_2; // 0x288

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8714CF90
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Run(){} // RVA: 0x7FFE8714CFD0
        public void .cctor(){} // RVA: 0x7FFE8714D090
    }

    public class Assert : Object
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0x7FFE810FB310
    }

    public class AssignLocalBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87184B00
        public void Run(){} // RVA: 0x7FFE87184B40
    }

    public class AssignLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87184870
        public void Run(){} // RVA: 0x7FFE871848B0
        public void BoxIfIndexMatches(){} // RVA: 0x7FFE87184940
    }

    public class AssignLocalToClosureInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87184D80
        public void Run(){} // RVA: 0x7FFE87184DC0
    }

}