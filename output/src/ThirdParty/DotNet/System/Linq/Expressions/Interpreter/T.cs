// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 6
// Methods: 32

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ThrowInstruction : Instruction
    {
        public object Throw;
        public object VoidThrow;
        public object Rethrow;
        public object VoidRethrow;
        public object _hasResult;
        public object _rethrow;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6672F10
        public void get_InstructionName(){} // RVA: 0x7080890
        public void get_ProducedStack(){} // RVA: 0x6F90570
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void Run(){} // RVA: 0x70808D0
        public void WrapThrownObject(){} // RVA: 0x7080AD0
        public void .cctor(){} // RVA: 0x7080C20
    }

    public class TryCatchFinallyHandler : Object
    {
        public object TryStartIndex;
        public object TryEndIndex;
        public object FinallyStartIndex;
        public object FinallyEndIndex;
        public object GotoEndTargetIndex;
        public object _handlers;

        // ── Methods ──
        public void get_IsFinallyBlockExist(){} // RVA: 0x7099150
        public void get_Handlers(){} // RVA: 0xB70160
        public void get_IsCatchBlockExist(){} // RVA: 0x64E22A0
        public void .ctor(){} // RVA: 0x70991E0
        public void HasHandler(){} // RVA: 0x7099260
        public void FilterPasses(){} // RVA: 0x70994C0
    }

    public class TryFaultHandler : Object
    {
        public object TryStartIndex;
        public object TryEndIndex;
        public object FinallyStartIndex;
        public object FinallyEndIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67B7600
    }

    public class TypeAsInstruction : Instruction
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70C2330
        public void Run(){} // RVA: 0x70C2370
        public void ToString(){} // RVA: 0x70C2450
    }

    public class TypeEqualsInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70C24C0
        public void .ctor(){} // RVA: 0xB43310
        public void Run(){} // RVA: 0x70C2500
        public void .cctor(){} // RVA: 0x70C25A0
    }

    public class TypeIsInstruction : Instruction
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70C2200
        public void Run(){} // RVA: 0x70C2240
        public void ToString(){} // RVA: 0x70C22C0
    }

}