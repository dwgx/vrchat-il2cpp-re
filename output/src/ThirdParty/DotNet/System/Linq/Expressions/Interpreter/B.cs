// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 7
// Methods: 35

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class BranchFalseInstruction
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFAF90C0740
        public void get_InstructionName(){} // RVA: 0x7FFAF90C0820
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void Run(){} // RVA: 0x7FFAF90C0860
        public void .ctor(){} // RVA: 0x7FFAF90C0730
    }

    public class BranchInstruction
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFAF90C0C50
        public void .ctor(){} // RVA: 0x7FFAF90C0FC0 | overloaded x2
        public void get_InstructionName(){} // RVA: 0x7FFAF90C0FD0
        public void get_ConsumedStack(){} // RVA: 0x7FFAF90C1010
        public void get_ProducedStack(){} // RVA: 0x7FFAF90C1020
        public void Run(){} // RVA: 0x7FFAF2DDA5C0
    }

    public class BranchLabel
    {
        public object ArgumentCount;
        public object InstructionName;
        public object ConsumedStack;

        // ── Methods ──
        public void get_LabelIndex(){} // RVA: 0x7FFAF3241DC0
        public void set_LabelIndex(){} // RVA: 0x7FFAF3503440
        public void get_HasRuntimeLabel(){} // RVA: 0x7FFAF90BE4C0
        public void get_TargetIndex(){} // RVA: 0x7FFAF2DDA5C0
        public void ToRuntimeLabel(){} // RVA: 0x7FFAF90BE4D0
        public void Mark(){} // RVA: 0x7FFAF90BE4F0
        public void AddBranch(){} // RVA: 0x7FFAF90BE7B0
        public void FixupBranch(){} // RVA: 0x7FFAF90BE930
        public void .ctor(){} // RVA: 0x7FFAF90BE960
    }

    public class BranchTrueInstruction
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFAF90C0910
        public void get_InstructionName(){} // RVA: 0x7FFAF90C09F0
        public void get_ConsumedStack(){} // RVA: 0x7FFAF2E7FAF0
        public void Run(){} // RVA: 0x7FFAF90C0A30
        public void .ctor(){} // RVA: 0x7FFAF90C0730
    }

    public class ByRefMethodInfoCallInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8A028E0
        public void get_ProducedStack(){} // RVA: 0x7FFAF90BFC40
        public void Run(){} // RVA: 0x7FFAF90BFD40
    }

    public class ByRefNewInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8A028E0
        public void get_InstructionName(){} // RVA: 0x7FFAF90FBFF0
        public void Run(){} // RVA: 0x7FFAF90FC030
    }

    public class ByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void Update(){} // RVA: 0x7FFAF2ADDC60
        public void UndefineTemps(){} // RVA: 0x7FFAF2D8D310
    }

}