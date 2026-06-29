// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 9
// Methods: 38

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ScriptingRuntimeHelpers : Object
    {
        // ── Methods ──
        public void Int32ToObject(){} // RVA: 0x70C6280
        public void GetPrimitiveDefaultValue(){} // RVA: 0x70C63E0
    }

    public class SetArrayItemInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ConsumedStack(){} // RVA: 0x12FC4A0
        public void get_InstructionName(){} // RVA: 0x707BAD0
        public void Run(){} // RVA: 0x707BB10
        public void .cctor(){} // RVA: 0x707BC10
    }

    public class StoreFieldInstruction : FieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_InstructionName(){} // RVA: 0x70860B0
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void Run(){} // RVA: 0x70860F0
    }

    public class StoreLocalBoxedInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B2340
        public void Run(){} // RVA: 0x70B2380
    }

    public class StoreLocalInstruction : LocalAccessInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70B20B0
        public void Run(){} // RVA: 0x70B20F0
        public void BoxIfIndexMatches(){} // RVA: 0x70B2190
    }

    public class StoreStaticFieldInstruction : FieldInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_InstructionName(){} // RVA: 0x7086170
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void Run(){} // RVA: 0x70861B0
    }

    public class StringSwitchInstruction : Instruction
    {
        public object _cases;
        public object _nullCase;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_InstructionName(){} // RVA: 0x7080E50
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void Run(){} // RVA: 0x7080E90
    }

    public class SubInstruction : Instruction
    {
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Single;
        public object s_Double;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70C00A0
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70C00E0
    }

    public class SubOvfInstruction : Instruction
    {
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70C0F30
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70C0F70
    }

}