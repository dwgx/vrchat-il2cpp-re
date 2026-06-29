// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 6
// Methods: 25

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class DebugInfo : Object
    {
        public object StartLine;
        public object EndLine;
        public object Index;
        public object FileName;
        public object IsClear;
        public object s_debugComparer;

        // ── Methods ──
        public void GetMatchingDebugInfo(){} // RVA: 0x7099780
        public void ToString(){} // RVA: 0x70998D0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x7099BC0
    }

    public class DecrementInstruction : Instruction
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
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x7080FB0
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x7080FF0
    }

    public class DefaultValueInstruction : Instruction
    {
        public object _type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x7081C50
        public void Run(){} // RVA: 0x7081C90
        public void ToString(){} // RVA: 0x7081D30
    }

    public class DelegateHelpers : Object
    {
        public object MaximumArity;

        // ── Methods ──
        public void MakeDelegate(){} // RVA: 0x70C5A00
    }

    public class DivInstruction : Instruction
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
        public void get_InstructionName(){} // RVA: 0x7081DA0
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x7081DE0
    }

    public class DupInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70BFF20
        public void Run(){} // RVA: 0x70BFF60
        public void .cctor(){} // RVA: 0x70C0000
    }

}