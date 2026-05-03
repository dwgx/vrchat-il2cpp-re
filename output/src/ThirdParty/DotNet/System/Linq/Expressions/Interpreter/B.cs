// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 7
// Methods: 35

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class BranchFalseInstruction : OffsetInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction[] s_cache;
        public object field_1; // 0x294
        public object field_2; // 0x295

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFE8714F610
        public void get_InstructionName(){} // RVA: 0x7FFE8714F6F0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void Run(){} // RVA: 0x7FFE8714F730
        public void .ctor(){} // RVA: 0x7FFE8714F600
    }

    public class BranchInstruction : OffsetInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction[][][] s_caches;
        public bool _hasResult; // 0x18
        public bool _hasValue; // 0x19
        public object field_3; // 0x29E

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFE8714FB20
        public void .ctor(){} // RVA: 0x7FFE8714FE90 | overloaded x2
        public void get_InstructionName(){} // RVA: 0x7FFE8714FEA0
        public void get_ConsumedStack(){} // RVA: 0x7FFE8714FEE0
        public void get_ProducedStack(){} // RVA: 0x7FFE8714FEF0
        public void Run(){} // RVA: 0x7FFE811485C0
    }

    public class BranchLabel : Object
    {
        public int UnknownIndex;
        public int UnknownDepth;
        public int _targetIndex; // 0x10

        // ── Methods ──
        public void get_LabelIndex(){} // RVA: 0x7FFE81549710
        public void set_LabelIndex(){} // RVA: 0x7FFE817E4800
        public void get_HasRuntimeLabel(){} // RVA: 0x7FFE8714D390
        public void get_TargetIndex(){} // RVA: 0x7FFE811485C0
        public void ToRuntimeLabel(){} // RVA: 0x7FFE8714D3A0
        public void Mark(){} // RVA: 0x7FFE8714D3C0
        public void AddBranch(){} // RVA: 0x7FFE8714D680
        public void FixupBranch(){} // RVA: 0x7FFE8714D800
        public void .ctor(){} // RVA: 0x7FFE8714D830
    }

    public class BranchTrueInstruction : OffsetInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction[] s_cache;
        public object field_1; // 0x297
        public object field_2; // 0x298

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFE8714F7E0
        public void get_InstructionName(){} // RVA: 0x7FFE8714F8C0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void Run(){} // RVA: 0x7FFE8714F900
        public void .ctor(){} // RVA: 0x7FFE8714F600
    }

    public class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
    {
        public System.Linq.Expressions.Interpreter.ByRefUpdater[] _byrefArgs; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A93700
        public void get_ProducedStack(){} // RVA: 0x7FFE8714EB10
        public void Run(){} // RVA: 0x7FFE8714EC10
    }

    public class ByRefNewInstruction : NewInstruction
    {
        public System.Linq.Expressions.Interpreter.ByRefUpdater[] _byrefArgs; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A93700
        public void get_InstructionName(){} // RVA: 0x7FFE8718AEE0
        public void Run(){} // RVA: 0x7FFE8718AF20
    }

    public class ByRefUpdater : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void Update(){} // RVA: 0x7FFE80E4F230
        public void UndefineTemps(){} // RVA: 0x7FFE810FB310
    }

}