// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 38

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ScriptingRuntimeHelpers
    {
        // ── Methods ──
        public void Int32ToObject(){} // RVA: 0x665AEB0
        public void GetPrimitiveDefaultValue(){} // RVA: 0x665B020
    }

    public class SetArrayItemInstruction
    {
        public System.Linq.Expressions.Interpreter.SetArrayItemInstruction Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_ConsumedStack(){} // RVA: 0xA308B0
        public void get_InstructionName(){} // RVA: 0x660DEC0
        public void Run(){} // RVA: 0x660DF00
        public void .cctor(){} // RVA: 0x660E020
    }

    public class StoreFieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_InstructionName(){} // RVA: 0x6618DC0
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void Run(){} // RVA: 0x6618E00
    }

    public class StoreLocalBoxedInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6645D50
        public void Run(){} // RVA: 0x6645D90
    }

    public class StoreLocalInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6645AC0
        public void Run(){} // RVA: 0x6645B00
        public void BoxIfIndexMatches(){} // RVA: 0x6645BA0
    }

    public class StoreStaticFieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_InstructionName(){} // RVA: 0x6618E80
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void Run(){} // RVA: 0x6618EC0
    }

    public class StringSwitchInstruction
    {
        public System.Collections.Generic.Dictionary`2<string,int> _cases; // 0x10
        public System.Runtime.CompilerServices.StrongBox`1<int> _nullCase; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void get_InstructionName(){} // RVA: 0x66135D0
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void Run(){} // RVA: 0x6613610
    }

    public class SubInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6654B70
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6654BB0
    }

    public class SubOvfInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6655B10
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6655B50
    }

}