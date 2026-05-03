// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 6
// Methods: 25

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class DebugInfo : Object
    {
        // ── Methods ──
        public void GetMatchingDebugInfo(){} // RVA: 0x7FFE8716BCC0
        public void ToString(){} // RVA: 0x7FFE8716BE10
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8716C110
    }

    public class DecrementInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87152610
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87152650
    }

    public class DefaultValueInstruction : Instruction
    {
        public System.Type _type; // 0x10
        public object field_1; // 0x2C9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871533C0
        public void Run(){} // RVA: 0x7FFE87153400
        public void ToString(){} // RVA: 0x7FFE871534A0
    }

    public class DelegateHelpers : Object
    {
        // ── Methods ──
        public void MakeDelegate(){} // RVA: 0x7FFE87199520
    }

    public class DivInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87153510
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87153550
    }

    public class DupInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.DupInstruction Instance;
        public object field_1; // 0x367

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871938E0
        public void Run(){} // RVA: 0x7FFE87193920
        public void .cctor(){} // RVA: 0x7FFE871939C0
    }

}