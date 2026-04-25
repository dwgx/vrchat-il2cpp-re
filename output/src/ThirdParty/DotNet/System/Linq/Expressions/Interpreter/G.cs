// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 4
// Methods: 23

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class GetArrayItemInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.GetArrayItemInstruction ConsumedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA4720
        public void Run(){} // RVA: 0x7FFAC8DA4760
        public void .cctor(){} // RVA: 0x7FFAC8DA48C0
    }

    public class GotoInstruction : IndexedBranchInstruction
    {
        public int InstructionName;
        public System.Linq.Expressions.Interpreter.GotoInstruction[] ConsumedStack;
        public bool ProducedStack; // 0x18
        public bool _hasValue; // 0x19
        public bool _labelTargetGetsValue; // 0x1A

        // ── Methods ──
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA7D10
        public void get_ConsumedStack(){} // RVA: 0x7FFAC8DA7AB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC8DA7AC0
        public void .ctor(){} // RVA: 0x7FFAC8DA7D50
        public void Create(){} // RVA: 0x7FFAC8DA7D70
        public void Run(){} // RVA: 0x7FFAC8DA7F10
        public void .cctor(){} // RVA: 0x7FFAC8DA8020
    }

    public class GreaterThanInstruction : Instruction
    {
        public object ConsumedStack; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack;
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Char; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x40
        public System.Linq.Expressions.Interpreter.Instruction s_Single; // 0x48
        public System.Linq.Expressions.Interpreter.Instruction s_Double; // 0x50
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSByte; // 0x58
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt16; // 0x60
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullChar; // 0x68
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt32; // 0x70
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt64; // 0x78
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullByte; // 0x80
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt16; // 0x88
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt32; // 0x90
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt64; // 0x98
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSingle; // 0xA0
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullDouble; // 0xA8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAF9C0
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Create(){} // RVA: 0x7FFAC8DAFA00
    }

    public class GreaterThanOrEqualInstruction : Instruction
    {
        public object ConsumedStack; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack;
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Char; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x40
        public System.Linq.Expressions.Interpreter.Instruction s_Single; // 0x48
        public System.Linq.Expressions.Interpreter.Instruction s_Double; // 0x50
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSByte; // 0x58
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt16; // 0x60
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullChar; // 0x68
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt32; // 0x70
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullInt64; // 0x78
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullByte; // 0x80
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt16; // 0x88
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt32; // 0x90
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullUInt64; // 0x98
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullSingle; // 0xA0
        public System.Linq.Expressions.Interpreter.Instruction s_liftedToNullDouble; // 0xA8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DB1700
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Create(){} // RVA: 0x7FFAC8DB1740
    }

}