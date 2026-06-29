// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 4
// Methods: 23

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class GetArrayItemInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x707B8B0
        public void Run(){} // RVA: 0x707B8F0
        public void .cctor(){} // RVA: 0x707BA30
    }

    public class GotoInstruction : IndexedBranchInstruction
    {
        public object Variants;
        public object s_cache;
        public object _hasResult;
        public object _hasValue;
        public object _labelTargetGetsValue;

        // ── Methods ──
        public void get_InstructionName(){} // RVA: 0x707EBA0
        public void get_ConsumedStack(){} // RVA: 0x707E940
        public void get_ProducedStack(){} // RVA: 0x707E950
        public void .ctor(){} // RVA: 0x707EBE0
        public void Create(){} // RVA: 0x707EC00
        public void Run(){} // RVA: 0x707EDA0
        public void .cctor(){} // RVA: 0x707EEB0
    }

    public class GreaterThanInstruction : Instruction
    {
        public object _nullValue;
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
        public object s_liftedToNullSByte;
        public object s_liftedToNullInt16;
        public object s_liftedToNullChar;
        public object s_liftedToNullInt32;
        public object s_liftedToNullInt64;
        public object s_liftedToNullByte;
        public object s_liftedToNullUInt16;
        public object s_liftedToNullUInt32;
        public object s_liftedToNullUInt64;
        public object s_liftedToNullSingle;
        public object s_liftedToNullDouble;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x7086210
        public void .ctor(){} // RVA: 0xB44D60
        public void Create(){} // RVA: 0x7086250
    }

    public class GreaterThanOrEqualInstruction : Instruction
    {
        public object _nullValue;
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
        public object s_liftedToNullSByte;
        public object s_liftedToNullInt16;
        public object s_liftedToNullChar;
        public object s_liftedToNullInt32;
        public object s_liftedToNullInt64;
        public object s_liftedToNullByte;
        public object s_liftedToNullUInt16;
        public object s_liftedToNullUInt32;
        public object s_liftedToNullUInt64;
        public object s_liftedToNullSingle;
        public object s_liftedToNullDouble;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x7087E10
        public void .ctor(){} // RVA: 0xB44D60
        public void Create(){} // RVA: 0x7087E50
    }

}