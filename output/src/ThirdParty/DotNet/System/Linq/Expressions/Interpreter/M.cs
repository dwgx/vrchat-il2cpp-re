// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 4
// Methods: 21

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class MethodInfoCallInstruction : CallInstruction
    {
        public object _target;
        public object _argumentCount;

        // ── Methods ──
        public void get_ArgumentCount(){} // RVA: 0xE62D00
        public void .ctor(){} // RVA: 0x2615F10
        public void get_ProducedStack(){} // RVA: 0x707D1D0
        public void Run(){} // RVA: 0x707D280
        public void GetArgs(){} // RVA: 0x707D540
        public void ToString(){} // RVA: 0x707D6F0
    }

    public class ModuloInstruction : Instruction
    {
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Single;
        public object s_Double;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B4280
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70B42C0
    }

    public class MulInstruction : Instruction
    {
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Single;
        public object s_Double;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B5140
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70B5180
    }

    public class MulOvfInstruction : Instruction
    {
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B5FD0
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70B6010
    }

}