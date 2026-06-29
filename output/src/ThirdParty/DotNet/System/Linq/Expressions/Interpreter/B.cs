// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 7
// Methods: 34

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class BranchFalseInstruction : OffsetInstruction
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7AE3FF200
        public void get_InstructionName(){} // RVA: 0x7AE3FF2E0
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void Run(){} // RVA: 0x7AE3FF320
        public void .ctor(){} // RVA: 0x7AE3FF1F0
    }

    public class BranchInstruction : OffsetInstruction
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7AE3FF710
        public void .ctor(){} // RVA: 0x7AE3FFA80
        public void get_InstructionName(){} // RVA: 0x7AE3FFA90
        public void get_ConsumedStack(){} // RVA: 0x7AE3FFAD0
        public void get_ProducedStack(){} // RVA: 0x7AE3FFAE0
        public void Run(){} // RVA: 0x7A8124910
    }

    public class BranchLabel : Object
    {
        // ── Methods ──
        public void get_LabelIndex(){} // RVA: 0x7A854FDE0
        public void set_LabelIndex(){} // RVA: 0x7A8810F60
        public void get_HasRuntimeLabel(){} // RVA: 0x7AE3FCF50
        public void get_TargetIndex(){} // RVA: 0x7A8124910
        public void ToRuntimeLabel(){} // RVA: 0x7AE3FCF60
        public void Mark(){} // RVA: 0x7AE3FCF80
        public void AddBranch(){} // RVA: 0x7AE3FD250
        public void FixupBranch(){} // RVA: 0x7AE3FD3D0
        public void .ctor(){} // RVA: 0x7AE3FD400
    }

    public class BranchTrueInstruction : OffsetInstruction
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7AE3FF3D0
        public void get_InstructionName(){} // RVA: 0x7AE3FF4B0
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void Run(){} // RVA: 0x7AE3FF4F0
        public void .ctor(){} // RVA: 0x7AE3FF1F0
    }

    public class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD41100
        public void get_ProducedStack(){} // RVA: 0x7AE3FE700
        public void Run(){} // RVA: 0x7AE3FE800
    }

    public class ByRefNewInstruction : NewInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADD41100
        public void get_InstructionName(){} // RVA: 0x7AE43AA20
        public void Run(){} // RVA: 0x7AE43AA60
    }

    public class ByRefUpdater : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void Update(){} // RVA: 0x7A7E18890
        public void UndefineTemps(){} // RVA: 0x7A80D7310
    }

}