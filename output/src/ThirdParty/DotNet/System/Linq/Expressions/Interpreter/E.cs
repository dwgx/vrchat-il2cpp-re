// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 11
// Methods: 54

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class EnterExceptionFilterInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.EnterExceptionFilterInstruction Instance;
        public object field_1; // 0x2B5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_InstructionName(){} // RVA: 0x7FFE87151900
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void Run(){} // RVA: 0x7FFE811EDAF0
        public void .cctor(){} // RVA: 0x7FFE87151940
    }

    public class EnterExceptionHandlerInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction Void;
        public System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction NonVoid; // 0x8
        public bool _hasValue; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_InstructionName(){} // RVA: 0x7FFE87151AC0
        public void get_ConsumedStack(){} // RVA: 0x7FFE870619E0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void Run(){} // RVA: 0x7FFE811EDAF0
        public void .cctor(){} // RVA: 0x7FFE87151B00
    }

    public class EnterFaultInstruction : IndexedBranchInstruction
    {
        public System.Linq.Expressions.Interpreter.EnterFaultInstruction[] s_cache;
        public object field_1; // 0x2B0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_InstructionName(){} // RVA: 0x7FFE87151540
        public void get_ProducedStack(){} // RVA: 0x7FFE81200CB0
        public void Create(){} // RVA: 0x7FFE87151580
        public void Run(){} // RVA: 0x7FFE871516B0
        public void .cctor(){} // RVA: 0x7FFE87151730
    }

    public class EnterFinallyInstruction : IndexedBranchInstruction
    {
        public System.Linq.Expressions.Interpreter.EnterFinallyInstruction[] s_cache;
        public object field_1; // 0x2AB
        public object field_2; // 0x2AC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_InstructionName(){} // RVA: 0x7FFE87151170
        public void get_ProducedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ConsumedContinuations(){} // RVA: 0x7FFE811EDAF0
        public void Create(){} // RVA: 0x7FFE871511B0
        public void Run(){} // RVA: 0x7FFE871512E0
        public void .cctor(){} // RVA: 0x7FFE87151360
    }

    public class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
    {
        public bool _hasFinally; // 0x18
        public System.Linq.Expressions.Interpreter.TryCatchFinallyHandler _tryHandler; // 0x20
        public object field_2; // 0x2A5

        // ── Methods ──
        public void SetTryHandler(){} // RVA: 0x7FFE811290D0
        public void get_Handler(){} // RVA: 0x7FFE811290C0
        public void get_ProducedContinuations(){} // RVA: 0x7FFE8714FEF0
        public void .ctor(){} // RVA: 0x7FFE87150510
        public void CreateTryFinally(){} // RVA: 0x7FFE87150520
        public void CreateTryCatch(){} // RVA: 0x7FFE87150570
        public void Run(){} // RVA: 0x7FFE871505C0
        public void get_InstructionName(){} // RVA: 0x7FFE87150C40
        public void ToString(){} // RVA: 0x7FFE87150CA0
    }

    public class EnterTryFaultInstruction : IndexedBranchInstruction
    {
        public System.Linq.Expressions.Interpreter.TryFaultHandler _tryHandler; // 0x18
        public object field_1; // 0x2A8
        public object field_2; // 0x2A9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_InstructionName(){} // RVA: 0x7FFE87150D30
        public void get_ProducedContinuations(){} // RVA: 0x7FFE811EDAF0
        public void get_Handler(){} // RVA: 0x7FFE810FE7C0
        public void SetTryHandler(){} // RVA: 0x7FFE81161E80
        public void Run(){} // RVA: 0x7FFE87150D70
    }

    public class EqualInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_reference;
        public System.Linq.Expressions.Interpreter.Instruction s_Boolean; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_SByte; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871544E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87154520
    }

    public class ExceptionFilter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82B1BB00
    }

    public class ExceptionHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8716B420
        public void Matches(){} // RVA: 0x7FFE8716B4F0
        public void ToString(){} // RVA: 0x7FFE8716B520
    }

    public class ExceptionHelpers : Object
    {
        // ── Methods ──
        public void UnwrapAndRethrow(){} // RVA: 0x7FFE8719A2F0
    }

    public class ExclusiveOrInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87156940
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87156980
    }

}