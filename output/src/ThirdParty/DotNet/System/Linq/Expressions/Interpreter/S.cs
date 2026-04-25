// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 38

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ScriptingRuntimeHelpers : Object
    {
        // ── Methods ──
        public void Int32ToObject(){} // RVA: 0x7FFAC8DF1970
        public void GetPrimitiveDefaultValue(){} // RVA: 0x7FFAC8DF1AE0
    }

    public class SetArrayItemInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.SetArrayItemInstruction ConsumedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ConsumedStack(){} // RVA: 0x7FFAC366FE20
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA4960
        public void Run(){} // RVA: 0x7FFAC8DA49A0
        public void .cctor(){} // RVA: 0x7FFAC8DA4AC0
    }

    public class StoreFieldInstruction : FieldInstruction
    {
        public object InstructionName;
        public object ConsumedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAF860
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void Run(){} // RVA: 0x7FFAC8DAF8A0
    }

    public class StoreLocalBoxedInstruction : LocalAccessInstruction
    {
        public object ConsumedStack;
        public object InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDC810
        public void Run(){} // RVA: 0x7FFAC8DDC850
    }

    public class StoreLocalInstruction : LocalAccessInstruction
    {
        public object ConsumedStack;
        public object InstructionName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DDC580
        public void Run(){} // RVA: 0x7FFAC8DDC5C0
        public void BoxIfIndexMatches(){} // RVA: 0x7FFAC8DDC660
    }

    public class StoreStaticFieldInstruction : FieldInstruction
    {
        public object InstructionName;
        public object ConsumedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAF920
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void Run(){} // RVA: 0x7FFAC8DAF960
    }

    public class StringSwitchInstruction : Instruction
    {
        public System.Collections.Generic.Dictionary`2<string,int> InstructionName; // 0x10
        public System.Runtime.CompilerServices.StrongBox`1<int> ConsumedStack; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_InstructionName(){} // RVA: 0x7FFAC8DAA070
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void Run(){} // RVA: 0x7FFAC8DAA0B0
    }

    public class SubInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_Single; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_Double; // 0x38

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DEB630
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DEB670
    }

    public class SubOvfInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x28

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DEC5D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DEC610
    }

}