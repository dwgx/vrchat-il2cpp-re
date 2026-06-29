// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 11
// Methods: 54

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class EnterExceptionFilterInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_InstructionName(){} // RVA: 0x7AE4014E0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void Run(){} // RVA: 0x7A81CA9D0
        public void .cctor(){} // RVA: 0x7AE401520
    }

    public class EnterExceptionHandlerInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81A2210
        public void get_InstructionName(){} // RVA: 0x7AE4016A0
        public void get_ConsumedStack(){} // RVA: 0x7AE310770
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void Run(){} // RVA: 0x7A81CA9D0
        public void .cctor(){} // RVA: 0x7AE4016E0
    }

    public class EnterFaultInstruction : IndexedBranchInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_InstructionName(){} // RVA: 0x7AE401120
        public void get_ProducedStack(){} // RVA: 0x7A81DDCC0
        public void Create(){} // RVA: 0x7AE401160
        public void Run(){} // RVA: 0x7AE401290
        public void .cctor(){} // RVA: 0x7AE401310
    }

    public class EnterFinallyInstruction : IndexedBranchInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_InstructionName(){} // RVA: 0x7AE400D50
        public void get_ProducedStack(){} // RVA: 0x7A81DDCC0
        public void get_ConsumedContinuations(){} // RVA: 0x7A81CA9D0
        public void Create(){} // RVA: 0x7AE400D90
        public void Run(){} // RVA: 0x7AE400EC0
        public void .cctor(){} // RVA: 0x7AE400F40
    }

    public class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
    {
        // ── Methods ──
        public void SetTryHandler(){} // RVA: 0x7A81052D0
        public void get_Handler(){} // RVA: 0x7A81052C0
        public void get_ProducedContinuations(){} // RVA: 0x7AE3FFAE0
        public void .ctor(){} // RVA: 0x7AE400100
        public void CreateTryFinally(){} // RVA: 0x7AE400110
        public void CreateTryCatch(){} // RVA: 0x7AE400160
        public void Run(){} // RVA: 0x7AE4001B0
        public void get_InstructionName(){} // RVA: 0x7AE400820
        public void ToString(){} // RVA: 0x7AE400880
    }

    public class EnterTryFaultInstruction : IndexedBranchInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_InstructionName(){} // RVA: 0x7AE400910
        public void get_ProducedContinuations(){} // RVA: 0x7A81CA9D0
        public void get_Handler(){} // RVA: 0x7A80DA7B0
        public void SetTryHandler(){} // RVA: 0x7A813E420
        public void Run(){} // RVA: 0x7AE400950
    }

    public class EqualInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE4040F0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE404130
    }

    public class ExceptionFilter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B8CFF0
    }

    public class ExceptionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE41AF00
        public void Matches(){} // RVA: 0x7AE41AFD0
        public void ToString(){} // RVA: 0x7AE41B000
    }

    public class ExceptionHelpers : Object
    {
        // ── Methods ──
        public void UnwrapAndRethrow(){} // RVA: 0x7AE449EC0
    }

    public class ExclusiveOrInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81DDCC0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE406580
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7AE4065C0
    }

}