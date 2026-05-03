// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 6
// Methods: 33

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ThrowInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.ThrowInstruction Throw;
        public System.Linq.Expressions.Interpreter.ThrowInstruction VoidThrow; // 0x8
        public System.Linq.Expressions.Interpreter.ThrowInstruction Rethrow; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8673B370
        public void get_InstructionName(){} // RVA: 0x7FFE87151EE0
        public void get_ProducedStack(){} // RVA: 0x7FFE870619E0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void Run(){} // RVA: 0x7FFE87151F20
        public void WrapThrownObject(){} // RVA: 0x7FFE87152120
        public void .cctor(){} // RVA: 0x7FFE87152270
    }

    public class TryCatchFinallyHandler : Object
    {
        public int TryStartIndex; // 0x10
        public int TryEndIndex; // 0x14
        public int FinallyStartIndex; // 0x18

        // ── Methods ──
        public void get_IsFinallyBlockExist(){} // RVA: 0x7FFE8716B670
        public void get_Handlers(){} // RVA: 0x7FFE81129130
        public void get_IsCatchBlockExist(){} // RVA: 0x7FFE865A8CD0
        public void .ctor(){} // RVA: 0x7FFE8716B700 | overloaded x2
        public void HasHandler(){} // RVA: 0x7FFE8716B780
        public void FilterPasses(){} // RVA: 0x7FFE8716B9E0
    }

    public class TryFaultHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8687FA60
    }

    public class TypeAsInstruction : Instruction
    {
        public System.Type _type; // 0x10
        public object field_1; // 0x375
        public object field_2; // 0x376

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87195E00
        public void Run(){} // RVA: 0x7FFE87195E40
        public void ToString(){} // RVA: 0x7FFE87195F20
    }

    public class TypeEqualsInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.TypeEqualsInstruction Instance;
        public object field_1; // 0x378
        public object field_2; // 0x379

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87195F90
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Run(){} // RVA: 0x7FFE87195FD0
        public void .cctor(){} // RVA: 0x7FFE87196070
    }

    public class TypeIsInstruction : Instruction
    {
        public System.Type _type; // 0x10
        public object field_1; // 0x372
        public object field_2; // 0x373

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87195CD0
        public void Run(){} // RVA: 0x7FFE87195D10
        public void ToString(){} // RVA: 0x7FFE87195D90
    }

}