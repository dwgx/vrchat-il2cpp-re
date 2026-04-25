// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 2
// Methods: 10

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class OffsetInstruction : Instruction
    {
        public int Cache;
        public int CacheSize;
        public int _offset; // 0x10

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFAC2C58E90
        public void Fixup(){} // RVA: 0x7FFAC8DA6F40
        public void ToDebugString(){} // RVA: 0x7FFAC8DA6FE0
        public void ToString(){} // RVA: 0x7FFAC8DA7110
        public void .ctor(){} // RVA: 0x7FFAC8DA71D0
    }

    public class OrInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.Instruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.Instruction s_Int64; // 0x18
        public System.Linq.Expressions.Interpreter.Instruction s_Byte; // 0x20
        public System.Linq.Expressions.Interpreter.Instruction s_UInt16; // 0x28
        public System.Linq.Expressions.Interpreter.Instruction s_UInt32; // 0x30
        public System.Linq.Expressions.Interpreter.Instruction s_UInt64; // 0x38
        public System.Linq.Expressions.Interpreter.Instruction s_Boolean; // 0x40

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE8C30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC8DE8C70
    }

}