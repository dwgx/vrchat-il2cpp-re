// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 5
// Methods: 18

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class RethrowException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x662CD80
    }

    public class RightShiftInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6653370
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x66533B0
    }

    public class RuntimeLabel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x660E360
        public void ToString(){} // RVA: 0x660E370
    }

    public class RuntimeVariables
    {
        public System.Runtime.CompilerServices.IStrongBox[] _boxes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void System.Runtime.CompilerServices.IRuntimeVariables.get_Count(){} // RVA: 0xF3F910
        public void System.Runtime.CompilerServices.IRuntimeVariables.get_Item(){} // RVA: 0x6654330
        public void System.Runtime.CompilerServices.IRuntimeVariables.set_Item(){} // RVA: 0x66543A0
        public void Create(){} // RVA: 0x6654420
    }

    public class RuntimeVariablesInstruction
    {
        public int _count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_ConsumedStack(){} // RVA: 0x32A5C0
        public void get_InstructionName(){} // RVA: 0x6646B90
        public void Run(){} // RVA: 0x6646BD0
    }

}