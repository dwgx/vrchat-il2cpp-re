// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 41

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class AddInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_Single; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_Double; // 0x38

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA11D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DA1210
    }

    public class AddOvfInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x28

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA2170
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DA21B0
    }

    public class AndInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction s_Boolean; // 0x40

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA30D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DA3110
    }

    public class ArrayByRefUpdater : ByRefUpdater
    {
        public System.Linq.Expressions.Interpreter.LocalDefinition _array; // 0x18
        public System.Linq.Expressions.Interpreter.LocalDefinition _index; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DD7A10
        public void Update(){} // RVA: 0x7FFAC8DD7AD0
        public void UndefineTemps(){} // RVA: 0x7FFAC8DD7BF0
    }

    public class ArrayLengthInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.ArrayLengthInstruction ConsumedStack;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA4B60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Run(){} // RVA: 0x7FFAC8DA4BA0
        public void .cctor(){} // RVA: 0x7FFAC8DA4C60
    }

    public class Assert : Object
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0x7FFAC2F21310
    }

    public class AssignLocalBoxedInstruction : LocalAccessInstruction
    {
        public object ConsumedStack;
        public object ProducedStack;
        public object InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDC6D0
        public void Run(){} // RVA: 0x7FFAC8DDC710
    }

    public class AssignLocalInstruction : LocalAccessInstruction
    {
        public object ConsumedStack;
        public object ProducedStack;
        public object InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDC440
        public void Run(){} // RVA: 0x7FFAC8DDC480
        public void BoxIfIndexMatches(){} // RVA: 0x7FFAC8DDC510
    }

    public class AssignLocalToClosureInstruction : LocalAccessInstruction
    {
        public object ConsumedStack;
        public object ProducedStack;
        public object InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDC950
        public void Run(){} // RVA: 0x7FFAC8DDC990
    }

}