// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 11
// Methods: 61

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class NegateCheckedInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE1F90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DE1FD0
    }

    public class NegateInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Single; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Double; // 0x20

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE1670
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DE16B0
    }

    public class NewArrayBoundsInstruction : Instruction
    {
        public System.Type ConsumedStack; // 0x10
        public int ProducedStack; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3157800
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA4550
        public void Run(){} // RVA: 0x7FFAC8DA4590
    }

    public class NewArrayInitInstruction : Instruction
    {
        public System.Type ConsumedStack; // 0x10
        public int ProducedStack; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3157800
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA42C0
        public void Run(){} // RVA: 0x7FFAC8DA4300
    }

    public class NewArrayInstruction : Instruction
    {
        public System.Type ConsumedStack; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA4400
        public void Run(){} // RVA: 0x7FFAC8DA4440
    }

    public class NewInstruction : Instruction
    {
        public System.Reflection.ConstructorInfo ConsumedStack; // 0x10
        public int ProducedStack; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC488C310
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3157800
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE2680
        public void Run(){} // RVA: 0x7FFAC8DE26C0
        public void GetArgs(){} // RVA: 0x7FFAC8DE27C0
        public void ToString(){} // RVA: 0x7FFAC8DE2950
    }

    public class NotEqualInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Char; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x40
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x48
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x50
        public System.Linq.Expressions.Interpreter.Instruction s_Single; // 0x58
        public System.Linq.Expressions.Interpreter.Instruction s_Double; // 0x60
        public System.Linq.Expressions.Interpreter.Instruction s_SByteLiftedToNull; // 0x68
        public System.Linq.Expressions.Interpreter.Instruction s_Int16LiftedToNull; // 0x70
        public System.Linq.Expressions.Interpreter.Instruction s_CharLiftedToNull; // 0x78
        public System.Linq.Expressions.Interpreter.Instruction s_Int32LiftedToNull; // 0x80
        public System.Linq.Expressions.Interpreter.Instruction s_Int64LiftedToNull; // 0x88
        public System.Linq.Expressions.Interpreter.Instruction s_ByteLiftedToNull; // 0x90
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16LiftedToNull; // 0x98
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32LiftedToNull; // 0xA0
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64LiftedToNull; // 0xA8
        public System.Linq.Expressions.Interpreter.Instruction s_SingleLiftedToNull; // 0xB0
        public System.Linq.Expressions.Interpreter.Instruction s_DoubleLiftedToNull; // 0xB8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE2DD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DE2E10
    }

    public class NotInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction s_SByte; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE50C0
        public void Create(){} // RVA: 0x7FFAC8DE5100
    }

    public class NullCheckInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE5ED0
        public void Run(){} // RVA: 0x7FFAC8DE5F10
        public void .cctor(){} // RVA: 0x7FFAC8DE5F90
    }

    public class NullableMethodCallInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_getHashCode; // 0x18
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_getValueOrDefault1; // 0x20
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_toString; // 0x28

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DEDCE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DEDD20
        public void CreateGetValue(){} // RVA: 0x7FFAC8DEE340
    }

    public class NumericConvertInstruction : Instruction
    {
        public 0x6B0C1808 InstructionName; // 0x10
        public 0x6B0C1808 ConsumedStack; // 0x14
        public bool ProducedStack; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DE6030
        public void Run(){} // RVA: 0x7FFAC8DE6040
        public void Convert(){} // RVA: 0x7FFAC2C58F40
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE61C0
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void ToString(){} // RVA: 0x7FFAC8DE6200
    }

}