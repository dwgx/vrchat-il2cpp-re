// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 6
// Methods: 33

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ThrowInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.ThrowInstruction InstructionName;
        public System.Linq.Expressions.Interpreter.ThrowInstruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.ThrowInstruction ConsumedStack; // 0x10
        public System.Linq.Expressions.Interpreter.ThrowInstruction VoidRethrow; // 0x18
        public bool _hasResult; // 0x10
        public bool _rethrow; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8391A70
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA9AB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC8CB94F0
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void Run(){} // RVA: 0x7FFAC8DA9AF0
        public void WrapThrownObject(){} // RVA: 0x7FFAC8DA9CF0
        public void .cctor(){} // RVA: 0x7FFAC8DA9E40
    }

    public class TryCatchFinallyHandler : Object
    {
        public int IsFinallyBlockExist; // 0x10
        public int Handlers; // 0x14
        public int IsCatchBlockExist; // 0x18
        public int FinallyEndIndex; // 0x1C
        public int GotoEndTargetIndex; // 0x20
        public System.Linq.Expressions.Interpreter.ExceptionHandler[] _handlers; // 0x28

        // ── Methods ──
        public void get_IsFinallyBlockExist(){} // RVA: 0x7FFAC8DC3240
        public void get_Handlers(){} // RVA: 0x7FFAC2F4F130
        public void get_IsCatchBlockExist(){} // RVA: 0x7FFAC81FF390
        public void .ctor(){} // RVA: 0x7FFAC8DC32D0 | overloaded x2
        public void HasHandler(){} // RVA: 0x7FFAC8DC3350
        public void FilterPasses(){} // RVA: 0x7FFAC8DC35B0
    }

    public class TryFaultHandler : Object
    {
        public int TryStartIndex; // 0x10
        public int TryEndIndex; // 0x14
        public int FinallyStartIndex; // 0x18
        public int FinallyEndIndex; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84D6230
    }

    public class TypeAsInstruction : Instruction
    {
        public System.Type ConsumedStack; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DED9D0
        public void Run(){} // RVA: 0x7FFAC8DEDA10
        public void ToString(){} // RVA: 0x7FFAC8DEDAF0
    }

    public class TypeEqualsInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.TypeEqualsInstruction ConsumedStack;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3026CB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DEDB60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Run(){} // RVA: 0x7FFAC8DEDBA0
        public void .cctor(){} // RVA: 0x7FFAC8DEDC40
    }

    public class TypeIsInstruction : Instruction
    {
        public System.Type ConsumedStack; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DED8A0
        public void Run(){} // RVA: 0x7FFAC8DED8E0
        public void ToString(){} // RVA: 0x7FFAC8DED960
    }

}