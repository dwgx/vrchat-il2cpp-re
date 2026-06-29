// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 5
// Methods: 18

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class RethrowException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE41B750
    }

    public class RightShiftInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE441DD0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE441E10
    }

    public class RuntimeLabel : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E7EF60
        public void ToString(){} // RVA: 0x7A7E7EF70
    }

    public class RuntimeVariables : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void System.Runtime.CompilerServices.IRuntimeVariables.get_Count(){} // RVA: 0x7A8D0A110
        public void System.Runtime.CompilerServices.IRuntimeVariables.get_Item(){} // RVA: 0x7AE442D90
        public void System.Runtime.CompilerServices.IRuntimeVariables.set_Item(){} // RVA: 0x7AE442E00
        public void Create(){} // RVA: 0x7AE442E80
    }

    public class RuntimeVariablesInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_ConsumedStack(){} // RVA: 0x7A8124910
        public void get_InstructionName(){} // RVA: 0x7AE435550
        public void Run(){} // RVA: 0x7AE435590
    }

}