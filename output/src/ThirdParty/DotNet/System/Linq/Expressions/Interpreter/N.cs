// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 11
// Methods: 61

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class NegateCheckedInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x664B4D0
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x664B510
    }

    public class NegateInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Int16;
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x664ABB0
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x664ABF0
    }

    public class NewArrayBoundsInstruction
    {
        public System.Type _elementType; // 0x10
        public int _rank; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50
        public void get_ConsumedStack(){} // RVA: 0x5BED50
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x660DAB0
        public void Run(){} // RVA: 0x660DAF0
    }

    public class NewArrayInitInstruction
    {
        public System.Type _elementType; // 0x10
        public int _elementCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50
        public void get_ConsumedStack(){} // RVA: 0x5BED50
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x660D820
        public void Run(){} // RVA: 0x660D860
    }

    public class NewArrayInstruction
    {
        public System.Type _elementType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x660D960
        public void Run(){} // RVA: 0x660D9A0
    }

    public class NewInstruction
    {
        public System.Reflection.ConstructorInfo _constructor; // 0x10
        public int _argumentCount; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D66A50
        public void get_ConsumedStack(){} // RVA: 0x5BED50
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x664BBC0
        public void Run(){} // RVA: 0x664BC00
        public void GetArgs(){} // RVA: 0x664BD00
        public void ToString(){} // RVA: 0x664BE90
    }

    public class NotEqualInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_reference;
        public System.Linq.Expressions.Interpreter.Instruction s_Boolean; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_SByte; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x664C310
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x664C350
    }

    public class NotInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_Boolean;
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x664E600
        public void Create(){} // RVA: 0x664E640
    }

    public class NullCheckInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x664F410
        public void Run(){} // RVA: 0x664F450
        public void .cctor(){} // RVA: 0x664F4D0
    }

    public class NullableMethodCallInstruction
    {
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_hasValue;
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_value; // 0x8
        public System.Linq.Expressions.Interpreter.NullableMethodCallInstruction s_equals; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6657220
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x6657260
        public void CreateGetValue(){} // RVA: 0x6657880
    }

    public class NumericConvertInstruction
    {
        public 0x657DC788 _from; // 0x10
        public 0x657DC788 _to; // 0x14
        public bool _isLiftedToNull; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x664F570
        public void Run(){} // RVA: 0x664F580
        public void Convert(){} // RVA: 0xCE10
        public void get_InstructionName(){} // RVA: 0x664F700
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void ToString(){} // RVA: 0x664F740
    }

}