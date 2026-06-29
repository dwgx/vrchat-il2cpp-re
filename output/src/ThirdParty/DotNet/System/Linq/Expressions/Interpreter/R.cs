// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 5
// Methods: 18

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class RethrowException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7099730
    }

    public class RightShiftInstruction : Instruction
    {
        public object s_SByte;
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_Byte;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70BE9E0
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70BEA20
    }

    public class RuntimeLabel : ValueType
    {
        public object Index;
        public object StackDepth;
        public object ContinuationStackDepth;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8FE270
        public void ToString(){} // RVA: 0x8FE280
    }

    public class RuntimeVariables : Object
    {
        public object _boxes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void System.Runtime.CompilerServices.IRuntimeVariables.get_Count(){} // RVA: 0x17F0080
        public void System.Runtime.CompilerServices.IRuntimeVariables.get_Item(){} // RVA: 0x70BF870
        public void System.Runtime.CompilerServices.IRuntimeVariables.set_Item(){} // RVA: 0x70BF8E0
        public void Create(){} // RVA: 0x70BF960
    }

    public class RuntimeVariablesInstruction : Instruction
    {
        public object _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_ConsumedStack(){} // RVA: 0xB8F8F0
        public void get_InstructionName(){} // RVA: 0x70B3180
        public void Run(){} // RVA: 0x70B31C0
    }

}