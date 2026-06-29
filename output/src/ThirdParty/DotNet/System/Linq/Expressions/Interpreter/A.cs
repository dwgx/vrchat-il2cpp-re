// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 41

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class AddInstruction : Instruction
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
        public void get_InstructionName(){} // RVA: 0x7078530
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x7078570
    }

    public class AddOvfInstruction : Instruction
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
        public void get_InstructionName(){} // RVA: 0x70793C0
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x7079400
    }

    public class AndInstruction : Instruction
    {
        public object s_SByte;
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_Byte;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Boolean;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x707A300
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x707A340
    }

    public class ArrayByRefUpdater : ByRefUpdater
    {
        public object _array;
        public object _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70AD540
        public void Update(){} // RVA: 0x70AD600
        public void UndefineTemps(){} // RVA: 0x70AD6C0
    }

    public class ArrayLengthInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x707BCB0
        public void .ctor(){} // RVA: 0xB43310
        public void Run(){} // RVA: 0x707BCF0
        public void .cctor(){} // RVA: 0x707BD90
    }

    public class Assert : Object
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0xB43310
    }

    public class AssignLocalBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B2200
        public void Run(){} // RVA: 0x70B2240
    }

    public class AssignLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B1F70
        public void Run(){} // RVA: 0x70B1FB0
        public void BoxIfIndexMatches(){} // RVA: 0x70B2040
    }

    public class AssignLocalToClosureInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B2480
        public void Run(){} // RVA: 0x70B24C0
    }

}