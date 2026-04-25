// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 6
// Methods: 25

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class DebugInfo : Object
    {
        public int StartLine; // 0x10
        public int EndLine; // 0x14
        public int Index; // 0x18
        public string FileName; // 0x20
        public bool IsClear; // 0x28
        public DebugInfoComparer s_debugComparer;

        // ── Methods ──
        public void GetMatchingDebugInfo(){} // RVA: 0x7FFAC8DC3890
        public void ToString(){} // RVA: 0x7FFAC8DC39E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8DC3CE0
    }

    public class DecrementInstruction : Instruction
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
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAA1E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DAA220
    }

    public class DefaultValueInstruction : Instruction
    {
        public System.Type ProducedStack; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAAF90
        public void Run(){} // RVA: 0x7FFAC8DAAFD0
        public void ToString(){} // RVA: 0x7FFAC8DAB070
    }

    public class DelegateHelpers : Object
    {
        public int MaximumArity;

        // ── Methods ──
        public void MakeDelegate(){} // RVA: 0x7FFAC8DF10F0
    }

    public class DivInstruction : Instruction
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
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAB0E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DAB120
    }

    public class DupInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.DupInstruction ProducedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DEB4B0
        public void Run(){} // RVA: 0x7FFAC8DEB4F0
        public void .cctor(){} // RVA: 0x7FFAC8DEB590
    }

}