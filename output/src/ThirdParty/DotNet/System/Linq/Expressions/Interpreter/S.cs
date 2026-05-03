// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 38

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ScriptingRuntimeHelpers : Object
    {
        // ── Methods ──
        public void Int32ToObject(){} // RVA: 0x7FFE87199DA0
        public void GetPrimitiveDefaultValue(){} // RVA: 0x7FFE87199F10
    }

    public class SetArrayItemInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.SetArrayItemInstruction Instance;
        public object field_1; // 0x285

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ConsumedStack(){} // RVA: 0x7FFE817BF630
        public void get_InstructionName(){} // RVA: 0x7FFE8714CD90
        public void Run(){} // RVA: 0x7FFE8714CDD0
        public void .cctor(){} // RVA: 0x7FFE8714CEF0
    }

    public class StoreFieldInstruction : FieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_InstructionName(){} // RVA: 0x7FFE87157C90
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void Run(){} // RVA: 0x7FFE87157CD0
    }

    public class StoreLocalBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87184C40
        public void Run(){} // RVA: 0x7FFE87184C80
    }

    public class StoreLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871849B0
        public void Run(){} // RVA: 0x7FFE871849F0
        public void BoxIfIndexMatches(){} // RVA: 0x7FFE87184A90
    }

    public class StoreStaticFieldInstruction : FieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_InstructionName(){} // RVA: 0x7FFE87157D50
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void Run(){} // RVA: 0x7FFE87157D90
    }

    public class StringSwitchInstruction : Instruction
    {
        public System.Collections.Generic.Dictionary`2<string,int> _cases; // 0x10
        public System.Runtime.CompilerServices.StrongBox`1<int> _nullCase; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_InstructionName(){} // RVA: 0x7FFE871524A0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void Run(){} // RVA: 0x7FFE871524E0
    }

    public class SubInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87193A60
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87193AA0
    }

    public class SubOvfInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87194A00
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87194A40
    }

}