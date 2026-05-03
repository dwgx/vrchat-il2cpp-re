// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 5
// Methods: 18

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class RethrowException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8716BC70
    }

    public class RightShiftInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.Instruction s_SByte;
        public System.Linq.Expressions.Interpreter.Instruction s_Int16; // 0x8
        public System.Linq.Expressions.Interpreter.Instruction s_Int32; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE81200CB0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87192260
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE871922A0
    }

    public class RuntimeLabel : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8714D230
        public void ToString(){} // RVA: 0x7FFE8714D240
    }

    public class RuntimeVariables : Object
    {
        public System.Runtime.CompilerServices.IStrongBox[] _boxes; // 0x10
        public object field_1; // 0x35F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void System.Runtime.CompilerServices.IRuntimeVariables.get_Count(){} // RVA: 0x7FFE81CCB610
        public void System.Runtime.CompilerServices.IRuntimeVariables.get_Item(){} // RVA: 0x7FFE87193220
        public void System.Runtime.CompilerServices.IRuntimeVariables.set_Item(){} // RVA: 0x7FFE87193290
        public void Create(){} // RVA: 0x7FFE87193310
    }

    public class RuntimeVariablesInstruction : Instruction
    {
        public int _count; // 0x10
        public object field_1; // 0x32E
        public object field_2; // 0x32F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ConsumedStack(){} // RVA: 0x7FFE811485C0
        public void get_InstructionName(){} // RVA: 0x7FFE87185A80
        public void Run(){} // RVA: 0x7FFE87185AC0
    }

}