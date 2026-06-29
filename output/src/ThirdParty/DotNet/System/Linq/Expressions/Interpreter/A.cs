// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 41

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class AddInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE3F9160
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE3F91A0
    }

    public class AddOvfInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE3FA120
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE3FA160
    }

    public class AndInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE3FB080
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE3FB0C0
    }

    public class ArrayByRefUpdater : ByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE42F8D0
        public void Update(){} // RVA: 0x7AE42F990
        public void UndefineTemps(){} // RVA: 0x7AE42FAB0
    }

    public class ArrayLengthInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE3FCB50
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Run(){} // RVA: 0x7AE3FCB90
        public void .cctor(){} // RVA: 0x7AE3FCC50
    }

    public class Assert : Object
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0x7A80D7310
    }

    public class AssignLocalBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE4345D0
        public void Run(){} // RVA: 0x7AE434610
    }

    public class AssignLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE434340
        public void Run(){} // RVA: 0x7AE434380
        public void BoxIfIndexMatches(){} // RVA: 0x7AE434410
    }

    public class AssignLocalToClosureInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE434850
        public void Run(){} // RVA: 0x7AE434890
    }

}