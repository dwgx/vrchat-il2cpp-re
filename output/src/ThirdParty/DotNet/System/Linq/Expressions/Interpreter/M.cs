// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 4
// Methods: 21

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class MethodInfoCallInstruction : CallInstruction
    {
        public System.Reflection.MethodInfo ArgumentCount; // 0x10
        public int ProducedStack; // 0x18

        // ── Methods ──
        public void get_ArgumentCount(){} // RVA: 0x7FFAC3157800
        public void .ctor(){} // RVA: 0x7FFAC488C310
        public void get_ProducedStack(){} // RVA: 0x7FFAC8DA60C0
        public void Run(){} // RVA: 0x7FFAC8DA61C0
        public void GetArgs(){} // RVA: 0x7FFAC8DA64D0
        public void ToString(){} // RVA: 0x7FFAC8DA6660
    }

    public class ModuloInstruction : Instruction
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
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDE760
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DDE7A0
    }

    public class MulInstruction : Instruction
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
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDF730
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DDF770
    }

    public class MulOvfInstruction : Instruction
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
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE06F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DE0730
    }

}