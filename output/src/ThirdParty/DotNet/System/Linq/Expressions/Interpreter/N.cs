// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 11
// Methods: 61

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class NegateCheckedInstruction : Instruction
    {
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B77D0
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70B7810
    }

    public class NegateInstruction : Instruction
    {
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_Single;
        public object s_Double;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B6F40
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70B6F80
    }

    public class NewArrayBoundsInstruction : Instruction
    {
        public object _elementType;
        public object _rank;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
        public void get_ConsumedStack(){} // RVA: 0xE62D00
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x707B6C0
        public void Run(){} // RVA: 0x707B700
    }

    public class NewArrayInitInstruction : Instruction
    {
        public object _elementType;
        public object _elementCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
        public void get_ConsumedStack(){} // RVA: 0xE62D00
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x707B430
        public void Run(){} // RVA: 0x707B470
    }

    public class NewArrayInstruction : Instruction
    {
        public object _elementType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x707B570
        public void Run(){} // RVA: 0x707B5B0
    }

    public class NewInstruction : Instruction
    {
        public object _constructor;
        public object _argumentCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2615F10
        public void get_ConsumedStack(){} // RVA: 0xE62D00
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B7EF0
        public void Run(){} // RVA: 0x70B7F30
        public void GetArgs(){} // RVA: 0x70B8030
        public void ToString(){} // RVA: 0x70B81E0
    }

    public class NotEqualInstruction : Instruction
    {
        public object s_reference;
        public object s_Boolean;
        public object s_SByte;
        public object s_Int16;
        public object s_Char;
        public object s_Int32;
        public object s_Int64;
        public object s_Byte;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Single;
        public object s_Double;
        public object s_SByteLiftedToNull;
        public object s_Int16LiftedToNull;
        public object s_CharLiftedToNull;
        public object s_Int32LiftedToNull;
        public object s_Int64LiftedToNull;
        public object s_ByteLiftedToNull;
        public object s_UInt16LiftedToNull;
        public object s_UInt32LiftedToNull;
        public object s_UInt64LiftedToNull;
        public object s_SingleLiftedToNull;
        public object s_DoubleLiftedToNull;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B8660
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70B86A0
    }

    public class NotInstruction : Instruction
    {
        public object s_Boolean;
        public object s_Int64;
        public object s_Int32;
        public object s_Int16;
        public object s_UInt64;
        public object s_UInt32;
        public object s_UInt16;
        public object s_Byte;
        public object s_SByte;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70BA700
        public void Create(){} // RVA: 0x70BA740
    }

    public class NullCheckInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70BB3B0
        public void Run(){} // RVA: 0x70BB3F0
        public void .cctor(){} // RVA: 0x70BB470
    }

    public class NullableMethodCallInstruction : Instruction
    {
        public object s_hasValue;
        public object s_value;
        public object s_equals;
        public object s_getHashCode;
        public object s_getValueOrDefault1;
        public object s_toString;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70C2640
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70C2680
        public void CreateGetValue(){} // RVA: 0x70C2CA0
    }

    public class NumericConvertInstruction : Instruction
    {
        public object _from;
        public object _to;
        public object _isLiftedToNull;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70BB510
        public void Run(){} // RVA: 0x70BB520
        public void Convert(){} // RVA: 0x87C540
        public void get_InstructionName(){} // RVA: 0x70BB6A0
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void ToString(){} // RVA: 0x70BB6E0
    }

}