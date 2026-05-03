// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 11
// Methods: 61

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class NegateCheckedInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8718A3C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE8718A400
    }

    public class NegateInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87189AA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87189AE0
    }

    public class NewArrayBoundsInstruction : Instruction
    {
        public System.Type _elementType; // 0x10
        public int _rank; // 0x18
        public object field_2; // 0x27F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
        public void get_ConsumedStack(){} // RVA: 0x7FFE813DB630
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8714C980
        public void Run(){} // RVA: 0x7FFE8714C9C0
    }

    public class NewArrayInitInstruction : Instruction
    {
        public System.Type _elementType; // 0x10
        public int _elementCount; // 0x18
        public object field_2; // 0x279

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
        public void get_ConsumedStack(){} // RVA: 0x7FFE813DB630
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8714C6F0
        public void Run(){} // RVA: 0x7FFE8714C730
    }

    public class NewArrayInstruction : Instruction
    {
        public System.Type _elementType; // 0x10
        public object field_1; // 0x27C
        public object field_2; // 0x27D

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8714C830
        public void Run(){} // RVA: 0x7FFE8714C870
    }

    public class NewInstruction : Instruction
    {
        public System.Reflection.ConstructorInfo _constructor; // 0x10
        public int _argumentCount; // 0x18
        public object field_2; // 0x346

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82AF3A20
        public void get_ConsumedStack(){} // RVA: 0x7FFE813DB630
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8718AAB0
        public void Run(){} // RVA: 0x7FFE8718AAF0
        public void GetArgs(){} // RVA: 0x7FFE8718ABF0
        public void ToString(){} // RVA: 0x7FFE8718AD80
    }

    public class NotEqualInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_reference;
        public System.Linq.Expressions.Interpreter.Instruction s_Boolean; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_SByte; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8718B200
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE8718B240
    }

    public class NotInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Boolean;
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8718D4F0
        public void Create(){} // RVA: 0x7FFE8718D530
    }

    public class NullCheckInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction Instance;
        public object field_1; // 0x350
        public object field_2; // 0x351

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE8718E300
        public void Run(){} // RVA: 0x7FFE8718E340
        public void .cctor(){} // RVA: 0x7FFE8718E3C0
    }

    public class NullableMethodCallInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_hasValue;
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_value; // 0x8
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_equals; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87196110
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE87196150
        public void CreateGetValue(){} // RVA: 0x7FFE87196770
    }

    public class NumericConvertInstruction : Instruction
    {
        public 0x664BA72C _from; // 0x10
        public 0x664BA72C _to; // 0x14
        public bool _isLiftedToNull; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8718E460
        public void Run(){} // RVA: 0x7FFE8718E470
        public void Convert(){} // RVA: 0x7FFE80E2E390
        public void get_InstructionName(){} // RVA: 0x7FFE8718E5F0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void ToString(){} // RVA: 0x7FFE8718E630
    }

}