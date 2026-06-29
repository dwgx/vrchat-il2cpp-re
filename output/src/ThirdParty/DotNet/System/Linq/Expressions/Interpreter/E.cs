// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 11
// Methods: 54

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class EnterExceptionFilterInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_InstructionName(){} // RVA: 0x70802B0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void Run(){} // RVA: 0xC3CCE0
        public void .cctor(){} // RVA: 0x70802F0
    }

    public class EnterExceptionHandlerInstruction : Instruction
    {
        public object Void;
        public object NonVoid;
        public object _hasValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_InstructionName(){} // RVA: 0x7080470
        public void get_ConsumedStack(){} // RVA: 0x6F90570
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void Run(){} // RVA: 0xC3CCE0
        public void .cctor(){} // RVA: 0x70804B0
    }

    public class EnterFaultInstruction : IndexedBranchInstruction
    {
        public object s_cache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_InstructionName(){} // RVA: 0x707FEF0
        public void get_ProducedStack(){} // RVA: 0xC50A80
        public void Create(){} // RVA: 0x707FF30
        public void Run(){} // RVA: 0x7080060
        public void .cctor(){} // RVA: 0x70800E0
    }

    public class EnterFinallyInstruction : IndexedBranchInstruction
    {
        public object s_cache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_InstructionName(){} // RVA: 0x707FB20
        public void get_ProducedStack(){} // RVA: 0xC50A80
        public void get_ConsumedContinuations(){} // RVA: 0xC3CCE0
        public void Create(){} // RVA: 0x707FB60
        public void Run(){} // RVA: 0x707FC90
        public void .cctor(){} // RVA: 0x707FD10
    }

    public class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
    {
        public object _hasFinally;
        public object _tryHandler;

        // ── Methods ──
        public void SetTryHandler(){} // RVA: 0xB70100
        public void get_Handler(){} // RVA: 0xB700F0
        public void get_ProducedContinuations(){} // RVA: 0x707E950
        public void .ctor(){} // RVA: 0x707EF70
        public void CreateTryFinally(){} // RVA: 0x707EF80
        public void CreateTryCatch(){} // RVA: 0x707EFD0
        public void Run(){} // RVA: 0x707F020
        public void get_InstructionName(){} // RVA: 0x707F5F0
        public void ToString(){} // RVA: 0x707F650
    }

    public class EnterTryFaultInstruction : IndexedBranchInstruction
    {
        public object _tryHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_InstructionName(){} // RVA: 0x707F6E0
        public void get_ProducedContinuations(){} // RVA: 0xC3CCE0
        public void get_Handler(){} // RVA: 0xB465B0
        public void SetTryHandler(){} // RVA: 0xBA9BA0
        public void Run(){} // RVA: 0x707F720
    }

    public class EqualInstruction : Instruction
    {
        public object s_reference;
        public object s_Boolean;
        public object s_SByte;
        public object s_Int16;
        public object s_Char;
        public object s_Int32;
        public object s_Int64;
        public object s_Byte;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Single;
        public object s_Double;
        public object s_BooleanLiftedToNull;
        public object s_SByteLiftedToNull;
        public object s_Int16LiftedToNull;
        public object s_CharLiftedToNull;
        public object s_Int32LiftedToNull;
        public object s_Int64LiftedToNull;
        public object s_ByteLiftedToNull;
        public object s_UInt16LiftedToNull;
        public object s_UInt32LiftedToNull;
        public object s_UInt64LiftedToNull;
        public object s_SingleLiftedToNull;
        public object s_DoubleLiftedToNull;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x7082C60
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x7082CA0
    }

    public class ExceptionFilter : Object
    {
        public object LabelIndex;
        public object StartIndex;
        public object EndIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x263F900
    }

    public class ExceptionHandler : Object
    {
        public object _exceptionType;
        public object LabelIndex;
        public object HandlerStartIndex;
        public object HandlerEndIndex;
        public object Filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7098F10
        public void Matches(){} // RVA: 0x7098FE0
        public void ToString(){} // RVA: 0x7099010
    }

    public class ExceptionHelpers : Object
    {
        // ── Methods ──
        public void UnwrapAndRethrow(){} // RVA: 0x70C67E0
    }

    public class ExclusiveOrInstruction : Instruction
    {
        public object s_SByte;
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_Byte;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Boolean;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x7084E40
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x7084E80
    }

}