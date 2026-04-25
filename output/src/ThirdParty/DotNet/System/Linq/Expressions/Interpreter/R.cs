// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 5
// Methods: 18

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class RethrowException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DC3840
    }

    public class RightShiftInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x38

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE9E30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DE9E70
    }

    public class RuntimeLabel : ValueType
    {
        public int Index; // 0x10
        public int StackDepth; // 0x14
        public int ContinuationStackDepth; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DA4E00
        public void ToString(){} // RVA: 0x7FFAC8DA4E10
    }

    public class RuntimeVariables : Object
    {
        public System.Runtime.CompilerServices.IStrongBox[] System.Runtime.CompilerServices.IRuntimeVariables.Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void System.Runtime.CompilerServices.IRuntimeVariables.get_Count(){} // RVA: 0x7FFAC3510620
        public void System.Runtime.CompilerServices.IRuntimeVariables.get_Item(){} // RVA: 0x7FFAC8DEADF0
        public void System.Runtime.CompilerServices.IRuntimeVariables.set_Item(){} // RVA: 0x7FFAC8DEAE60
        public void Create(){} // RVA: 0x7FFAC8DEAEE0
    }

    public class RuntimeVariablesInstruction : Instruction
    {
        public int ProducedStack; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ConsumedStack(){} // RVA: 0x7FFAC2F6E5C0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDD650
        public void Run(){} // RVA: 0x7FFAC8DDD690
    }

}