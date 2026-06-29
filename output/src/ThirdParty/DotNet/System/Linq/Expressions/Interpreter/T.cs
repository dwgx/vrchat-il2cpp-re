// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 6
// Methods: 32

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ThrowInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9E8320
        public void get_InstructionName(){} // RVA: 0x7AE401AC0
        public void get_ProducedStack(){} // RVA: 0x7AE310770
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void Run(){} // RVA: 0x7AE401B00
        public void WrapThrownObject(){} // RVA: 0x7AE401D00
        public void .cctor(){} // RVA: 0x7AE401E50
    }

    public class TryCatchFinallyHandler : Object
    {
        // ── Methods ──
        public void get_IsFinallyBlockExist(){} // RVA: 0x7AE41B150
        public void get_Handlers(){} // RVA: 0x7A8105330
        public void get_IsCatchBlockExist(){} // RVA: 0x7AD854AF0
        public void .ctor(){} // RVA: 0x7AE41B1E0
        public void HasHandler(){} // RVA: 0x7AE41B260
        public void FilterPasses(){} // RVA: 0x7AE41B4C0
    }

    public class TryFaultHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADB2CE80
    }

    public class TypeAsInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE4459A0
        public void Run(){} // RVA: 0x7AE4459E0
        public void ToString(){} // RVA: 0x7AE445AC0
    }

    public class TypeEqualsInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE445B30
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Run(){} // RVA: 0x7AE445B70
        public void .cctor(){} // RVA: 0x7AE445C10
    }

    public class TypeIsInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE445870
        public void Run(){} // RVA: 0x7AE4458B0
        public void ToString(){} // RVA: 0x7AE445930
    }

}