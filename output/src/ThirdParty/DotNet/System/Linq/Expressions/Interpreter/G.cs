// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 4
// Methods: 23

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class GetArrayItemInstruction
    {
        public System.Linq.Expressions.Interpreter.GetArrayItemInstruction Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x660DC80
        public void Run(){} // RVA: 0x660DCC0
        public void .cctor(){} // RVA: 0x660DE20
    }

    public class GotoInstruction
    {
        public int Variants;
        public System.Linq.Expressions.Interpreter.GotoInstruction[] s_cache;
        public bool _hasResult; // 0x18

        // ── Methods ──
        public void get_InstructionName(){} // RVA: 0x6611270
        public void get_ConsumedStack(){} // RVA: 0x6611010
        public void get_ProducedStack(){} // RVA: 0x6611020
        public void .ctor(){} // RVA: 0x66112B0
        public void Create(){} // RVA: 0x66112D0
        public void Run(){} // RVA: 0x6611470
        public void .cctor(){} // RVA: 0x6611580
    }

    public class GreaterThanInstruction
    {
        public object _nullValue; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6618F20
        public void .ctor(){} // RVA: 0x2DEE30
        public void Create(){} // RVA: 0x6618F60
    }

    public class GreaterThanOrEqualInstruction
    {
        public object _nullValue; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x661AC60
        public void .ctor(){} // RVA: 0x2DEE30
        public void Create(){} // RVA: 0x661ACA0
    }

}