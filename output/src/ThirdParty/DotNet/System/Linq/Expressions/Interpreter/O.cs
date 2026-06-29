// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 2
// Methods: 10

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class OffsetInstruction : Instruction
    {
        public object Unknown;
        public object CacheSize;
        public object _offset;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x87C0A0
        public void Fixup(){} // RVA: 0x707DE30
        public void ToDebugString(){} // RVA: 0x707DED0
        public void ToString(){} // RVA: 0x707E000
        public void .ctor(){} // RVA: 0x707E0C0
    }

    public class OrInstruction : Instruction
    {
        public object s_SByte;
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_Byte;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;
        public object s_Boolean;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC50A80
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70BD8B0
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x70BD8F0
    }

}