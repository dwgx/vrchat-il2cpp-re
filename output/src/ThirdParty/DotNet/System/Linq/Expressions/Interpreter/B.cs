// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 7
// Methods: 34

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class BranchFalseInstruction : OffsetInstruction
    {
        public object s_cache;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x707E0D0
        public void get_InstructionName(){} // RVA: 0x707E1B0
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void Run(){} // RVA: 0x707E1F0
        public void .ctor(){} // RVA: 0x707E0C0
    }

    public class BranchInstruction : OffsetInstruction
    {
        public object s_caches;
        public object _hasResult;
        public object _hasValue;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x707E580
        public void .ctor(){} // RVA: 0x707E8F0
        public void get_InstructionName(){} // RVA: 0x707E900
        public void get_ConsumedStack(){} // RVA: 0x707E940
        public void get_ProducedStack(){} // RVA: 0x707E950
        public void Run(){} // RVA: 0xB8F8F0
    }

    public class BranchLabel : Object
    {
        public object UnknownIndex;
        public object UnknownDepth;
        public object _targetIndex;
        public object _stackDepth;
        public object _continuationStackDepth;
        public object _forwardBranchFixups;
        public object _labelIndex;

        // ── Methods ──
        public void get_LabelIndex(){} // RVA: 0x1065D50
        public void set_LabelIndex(){} // RVA: 0x13233D0
        public void get_HasRuntimeLabel(){} // RVA: 0x707C080
        public void get_TargetIndex(){} // RVA: 0xB8F8F0
        public void ToRuntimeLabel(){} // RVA: 0x707C090
        public void Mark(){} // RVA: 0x707C0B0
        public void AddBranch(){} // RVA: 0x707C380
        public void FixupBranch(){} // RVA: 0x707C500
        public void .ctor(){} // RVA: 0x707C530
    }

    public class BranchTrueInstruction : OffsetInstruction
    {
        public object s_cache;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x707E270
        public void get_InstructionName(){} // RVA: 0x707E350
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void Run(){} // RVA: 0x707E390
        public void .ctor(){} // RVA: 0x707E0C0
    }

    public class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
    {
        public object _byrefArgs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69C9EA0
        public void get_ProducedStack(){} // RVA: 0x707D1D0
        public void Run(){} // RVA: 0x707D770
    }

    public class ByRefNewInstruction : NewInstruction
    {
        public object _byrefArgs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x69C9EA0
        public void get_InstructionName(){} // RVA: 0x70B8340
        public void Run(){} // RVA: 0x70B8380
    }

    public class ByRefUpdater : Object
    {
        public object ArgumentIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void Update(){} // RVA: 0x8943B0
        public void UndefineTemps(){} // RVA: 0xB43310
    }

}