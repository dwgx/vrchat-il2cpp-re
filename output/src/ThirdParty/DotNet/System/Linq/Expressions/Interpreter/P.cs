// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 3
// Methods: 10

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ParameterByRefUpdater : ByRefUpdater
    {
        public System.Linq.Expressions.Interpreter.LocalVariable _parameter; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DD7810
        public void Update(){} // RVA: 0x7FFAC8DD7870
    }

    public class PopInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.PopInstruction ConsumedStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DEB390
        public void Run(){} // RVA: 0x7FFAC8DEB3D0
        public void .cctor(){} // RVA: 0x7FFAC8DEB410
    }

    public class PropertyByRefUpdater : ByRefUpdater
    {
        public System.Nullable`1<System.Linq.Expressions.Interpreter.LocalDefinition> _object; // 0x18
        public System.Reflection.PropertyInfo _property; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DD7CD0
        public void Update(){} // RVA: 0x7FFAC8DD7F10
        public void UndefineTemps(){} // RVA: 0x7FFAC8DD7FF0
    }

}