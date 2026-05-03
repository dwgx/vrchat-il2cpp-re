// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 3
// Methods: 10

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ParameterByRefUpdater : ByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8717FC40
        public void Update(){} // RVA: 0x7FFE8717FCA0
    }

    public class PopInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.PopInstruction Instance;
        public object field_1; // 0x365

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE871937C0
        public void Run(){} // RVA: 0x7FFE87193800
        public void .cctor(){} // RVA: 0x7FFE87193840
    }

    public class PropertyByRefUpdater : ByRefUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87180100
        public void Update(){} // RVA: 0x7FFE87180340
        public void UndefineTemps(){} // RVA: 0x7FFE87180420
    }

}