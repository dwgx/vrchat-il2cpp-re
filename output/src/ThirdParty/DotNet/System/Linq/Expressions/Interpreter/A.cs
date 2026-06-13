// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 41

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class AddInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x660A730
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x660A770
    }

    public class AddOvfInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x660B6D0
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x660B710
    }

    public class AndInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x660C630
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x660C670
    }

    public class ArrayByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6640F50
        public void Update(){} // RVA: 0x6641010
        public void UndefineTemps(){} // RVA: 0x6641130
    }

    public class ArrayLengthInstruction
    {
        public System.Linq.Expressions.Interpreter.ArrayLengthInstruction Instance;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x660E0C0
        public void .ctor(){} // RVA: 0x2DD310
        public void Run(){} // RVA: 0x660E100
        public void .cctor(){} // RVA: 0x660E1C0
    }

    public class Assert
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0x2DD310
    }

    public class AssignLocalBoxedInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6645C10
        public void Run(){} // RVA: 0x6645C50
    }

    public class AssignLocalInstruction : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6645980
        public void Run(){} // RVA: 0x66459C0
        public void BoxIfIndexMatches(){} // RVA: 0x6645A50
    }

    public class AssignLocalToClosureInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6645E90
        public void Run(){} // RVA: 0x6645ED0
    }

}