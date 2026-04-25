// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 11
// Methods: 54

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class EnterExceptionFilterInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.EnterExceptionFilterInstruction InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA94D0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void Run(){} // RVA: 0x7FFAC3013AF0
        public void .cctor(){} // RVA: 0x7FFAC8DA9510
    }

    public class EnterExceptionHandlerInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction InstructionName;
        public System.Linq.Expressions.Interpreter.EnterExceptionHandlerInstruction ConsumedStack; // 0x8
        public bool ProducedStack; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA9690
        public void get_ConsumedStack(){} // RVA: 0x7FFAC8CB94F0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void Run(){} // RVA: 0x7FFAC3013AF0
        public void .cctor(){} // RVA: 0x7FFAC8DA96D0
    }

    public class EnterFaultInstruction : IndexedBranchInstruction
    {
        public System.Linq.Expressions.Interpreter.EnterFaultInstruction[] InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA9110
        public void get_ProducedStack(){} // RVA: 0x7FFAC3026CB0
        public void Create(){} // RVA: 0x7FFAC8DA9150
        public void Run(){} // RVA: 0x7FFAC8DA9280
        public void .cctor(){} // RVA: 0x7FFAC8DA9300
    }

    public class EnterFinallyInstruction : IndexedBranchInstruction
    {
        public System.Linq.Expressions.Interpreter.EnterFinallyInstruction[] InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA8D40
        public void get_ProducedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ConsumedContinuations(){} // RVA: 0x7FFAC3013AF0
        public void Create(){} // RVA: 0x7FFAC8DA8D80
        public void Run(){} // RVA: 0x7FFAC8DA8EB0
        public void .cctor(){} // RVA: 0x7FFAC8DA8F30
    }

    public class EnterTryCatchFinallyInstruction : IndexedBranchInstruction
    {
        public bool Handler; // 0x18
        public System.Linq.Expressions.Interpreter.TryCatchFinallyHandler ProducedContinuations; // 0x20

        // ── Methods ──
        public void SetTryHandler(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Handler(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ProducedContinuations(){} // RVA: 0x7FFAC8DA7AC0
        public void .ctor(){} // RVA: 0x7FFAC8DA80E0
        public void CreateTryFinally(){} // RVA: 0x7FFAC8DA80F0
        public void CreateTryCatch(){} // RVA: 0x7FFAC8DA8140
        public void Run(){} // RVA: 0x7FFAC8DA8190
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA8810
        public void ToString(){} // RVA: 0x7FFAC8DA8870
    }

    public class EnterTryFaultInstruction : IndexedBranchInstruction
    {
        public System.Linq.Expressions.Interpreter.TryFaultHandler InstructionName; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA8900
        public void get_ProducedContinuations(){} // RVA: 0x7FFAC3013AF0
        public void get_Handler(){} // RVA: 0x7FFAC2F247C0
        public void SetTryHandler(){} // RVA: 0x7FFAC2F87E80
        public void Run(){} // RVA: 0x7FFAC8DA8940
    }

    public class EqualInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Char; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x40
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x48
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x50
        public System.Linq.Expressions.Interpreter.Instruction s_Single; // 0x58
        public System.Linq.Expressions.Interpreter.Instruction s_Double; // 0x60
        public System.Linq.Expressions.Interpreter.Instruction s_BooleanLiftedToNull; // 0x68
        public System.Linq.Expressions.Interpreter.Instruction s_SByteLiftedToNull; // 0x70
        public System.Linq.Expressions.Interpreter.Instruction s_Int16LiftedToNull; // 0x78
        public System.Linq.Expressions.Interpreter.Instruction s_CharLiftedToNull; // 0x80
        public System.Linq.Expressions.Interpreter.Instruction s_Int32LiftedToNull; // 0x88
        public System.Linq.Expressions.Interpreter.Instruction s_Int64LiftedToNull; // 0x90
        public System.Linq.Expressions.Interpreter.Instruction s_ByteLiftedToNull; // 0x98
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16LiftedToNull; // 0xA0
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32LiftedToNull; // 0xA8
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64LiftedToNull; // 0xB0
        public System.Linq.Expressions.Interpreter.Instruction s_SingleLiftedToNull; // 0xB8
        public System.Linq.Expressions.Interpreter.Instruction s_DoubleLiftedToNull; // 0xC0

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAC0B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DAC0F0
    }

    public class ExceptionFilter : Object
    {
        public int LabelIndex; // 0x10
        public int StartIndex; // 0x14
        public int EndIndex; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC48B1250
    }

    public class ExceptionHandler : Object
    {
        public System.Type _exceptionType; // 0x10
        public int LabelIndex; // 0x18
        public int HandlerStartIndex; // 0x1C
        public int HandlerEndIndex; // 0x20
        public System.Linq.Expressions.Interpreter.ExceptionFilter Filter; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DC2FF0
        public void Matches(){} // RVA: 0x7FFAC8DC30C0
        public void ToString(){} // RVA: 0x7FFAC8DC30F0
    }

    public class ExceptionHelpers : Object
    {
        // ── Methods ──
        public void UnwrapAndRethrow(){} // RVA: 0x7FFAC8DF1EC0
    }

    public class ExclusiveOrInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction s_Boolean; // 0x40

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAE510
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DAE550
    }

}