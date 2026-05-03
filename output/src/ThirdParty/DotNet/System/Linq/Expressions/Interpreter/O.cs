// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 2
// Methods: 10

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class OffsetInstruction : Instruction
    {
        public int Unknown;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFE80E2E2E0
        public void Fixup(){} // RVA: 0x7FFE8714F370
        public void ToDebugString(){} // RVA: 0x7FFE8714F410
        public void ToString(){} // RVA: 0x7FFE8714F540
        public void .ctor(){} // RVA: 0x7FFE8714F600
    }

    public class OrInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87191060
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE871910A0
    }

}