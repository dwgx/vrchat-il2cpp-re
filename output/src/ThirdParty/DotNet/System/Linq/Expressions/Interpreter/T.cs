// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 6
// Methods: 33

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ThrowInstruction
    {
        public System.Linq.Expressions.Interpreter.ThrowInstruction Throw;
        public System.Linq.Expressions.Interpreter.ThrowInstruction VoidThrow; // 0x8
        public System.Linq.Expressions.Interpreter.ThrowInstruction Rethrow; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BFA520
        public void get_InstructionName(){} // RVA: 0x6613010
        public void get_ProducedStack(){} // RVA: 0x6522960
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void Run(){} // RVA: 0x6613050
        public void WrapThrownObject(){} // RVA: 0x6613250
        public void .cctor(){} // RVA: 0x66133A0
    }

    public class TryCatchFinallyHandler
    {
        public int TryStartIndex; // 0x10
        public int TryEndIndex; // 0x14
        public int FinallyStartIndex; // 0x18

        // ── Methods ──
        public void get_IsFinallyBlockExist(){} // RVA: 0x662C780
        public void get_Handlers(){} // RVA: 0x30B130
        public void get_IsCatchBlockExist(){} // RVA: 0x5A67FD0
        public void .ctor(){} // RVA: 0x662C810 | overloaded x2
        public void HasHandler(){} // RVA: 0x662C890
        public void FilterPasses(){} // RVA: 0x662CAF0
    }

    public class TryFaultHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D3EB60
    }

    public class TypeAsInstruction
    {
        public System.Type _type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6656F10
        public void Run(){} // RVA: 0x6656F50
        public void ToString(){} // RVA: 0x6657030
    }

    public class TypeEqualsInstruction
    {
        public System.Linq.Expressions.Interpreter.TypeEqualsInstruction Instance;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x3E2CB0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x66570A0
        public void .ctor(){} // RVA: 0x2DD310
        public void Run(){} // RVA: 0x66570E0
        public void .cctor(){} // RVA: 0x6657180
    }

    public class TypeIsInstruction
    {
        public System.Type _type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_ConsumedStack(){} // RVA: 0x3CFAF0
        public void get_ProducedStack(){} // RVA: 0x3CFAF0
        public void get_InstructionName(){} // RVA: 0x6656DE0
        public void Run(){} // RVA: 0x6656E20
        public void ToString(){} // RVA: 0x6656EA0
    }

}