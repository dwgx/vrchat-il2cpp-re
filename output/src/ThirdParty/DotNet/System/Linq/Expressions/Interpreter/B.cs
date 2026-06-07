// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 7
// Methods: 35

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class BranchFalseInstruction
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x6610740
        public void get_InstructionName(){} // RVA: 0x6610820
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void Run(){} // RVA: 0x6610860
        public void .ctor(){} // RVA: 0x6610730
    }

    public class BranchInstruction
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x6610C50
        public void .ctor(){} // RVA: 0x6610FC0 | overloaded x2
        public void get_InstructionName(){} // RVA: 0x6610FD0
        public void get_ConsumedStack(){} // RVA: 0x6611010
        public void get_ProducedStack(){} // RVA: 0x6611020
        public void Run(){} // RVA: 0x32A5C0
    }

    public class BranchLabel
    {
        public object ArgumentCount;
        public object InstructionName;
        public object ConsumedStack;

        // ── Methods ──
        public void get_LabelIndex(){} // RVA: 0x791DC0
        public void set_LabelIndex(){} // RVA: 0xA53440
        public void get_HasRuntimeLabel(){} // RVA: 0x660E4C0
        public void get_TargetIndex(){} // RVA: 0x32A5C0
        public void ToRuntimeLabel(){} // RVA: 0x660E4D0
        public void Mark(){} // RVA: 0x660E4F0
        public void AddBranch(){} // RVA: 0x660E7B0
        public void FixupBranch(){} // RVA: 0x660E930
        public void .ctor(){} // RVA: 0x660E960
    }

    public class BranchTrueInstruction
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x6610910
        public void get_InstructionName(){} // RVA: 0x66109F0
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void Run(){} // RVA: 0x6610A30
        public void .ctor(){} // RVA: 0x6610730
    }

    public class ByRefMethodInfoCallInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F528E0
        public void get_ProducedStack(){} // RVA: 0x660FC40
        public void Run(){} // RVA: 0x660FD40
    }

    public class ByRefNewInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5F528E0
        public void get_InstructionName(){} // RVA: 0x664BFF0
        public void Run(){} // RVA: 0x664C030
    }

    public class ByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void Update(){} // RVA: 0x2DC60
        public void UndefineTemps(){} // RVA: 0x2DD310
    }

}