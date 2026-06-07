// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 11
// Methods: 54

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class EnterExceptionFilterInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_InstructionName(){} // RVA: 0x6612A30
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void Run(){} // RVA: 0x3CFAF0
        public void .cctor(){} // RVA: 0x6612A70
    }

    public class EnterExceptionHandlerInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A75F0
        public void get_InstructionName(){} // RVA: 0x6612BF0
        public void get_ConsumedStack(){} // RVA: 0x6522960
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void Run(){} // RVA: 0x3CFAF0
        public void .cctor(){} // RVA: 0x6612C30
    }

    public class EnterFaultInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_InstructionName(){} // RVA: 0x6612670
        public void get_ProducedStack(){} // RVA: 0x3E2CB0
        public void Create(){} // RVA: 0x66126B0
        public void Run(){} // RVA: 0x66127E0
        public void .cctor(){} // RVA: 0x6612860
    }

    public class EnterFinallyInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_InstructionName(){} // RVA: 0x66122A0
        public void get_ProducedStack(){} // RVA: 0x3E2CB0
        public void get_ConsumedContinuations(){} // RVA: 0x3CFAF0
        public void Create(){} // RVA: 0x66122E0
        public void Run(){} // RVA: 0x6612410
        public void .cctor(){} // RVA: 0x6612490
    }

    public class EnterTryCatchFinallyInstruction
    {
        // ── Methods ──
        public void SetTryHandler(){} // RVA: 0x30B0D0
        public void get_Handler(){} // RVA: 0x30B0C0
        public void get_ProducedContinuations(){} // RVA: 0x6611020
        public void .ctor(){} // RVA: 0x6611640
        public void CreateTryFinally(){} // RVA: 0x6611650
        public void CreateTryCatch(){} // RVA: 0x66116A0
        public void Run(){} // RVA: 0x66116F0
        public void get_InstructionName(){} // RVA: 0x6611D70
        public void ToString(){} // RVA: 0x6611DD0
    }

    public class EnterTryFaultInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_InstructionName(){} // RVA: 0x6611E60
        public void get_ProducedContinuations(){} // RVA: 0x3CFAF0
        public void get_Handler(){} // RVA: 0x2E07C0
        public void SetTryHandler(){} // RVA: 0x343E80
        public void Run(){} // RVA: 0x6611EA0
    }

    public class EqualInstruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6615610
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6615650
    }

    public class ExceptionFilter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D897D0
    }

    public class ExceptionHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x662C530
        public void Matches(){} // RVA: 0x662C600
        public void ToString(){} // RVA: 0x662C630
    }

    public class ExceptionHelpers
    {
        // ── Methods ──
        public void UnwrapAndRethrow(){} // RVA: 0x665B400
    }

    public class ExclusiveOrInstruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6617A70
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6617AB0
    }

}