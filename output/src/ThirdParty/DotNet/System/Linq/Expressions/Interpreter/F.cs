// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 2
// Methods: 5

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class FieldByRefUpdater : ByRefUpdater
    {
        public System.Nullable`1<System.Linq.Expressions.Interpreter.LocalDefinition> _object; // 0x18
        public System.Reflection.FieldInfo _field; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8DD7CD0
        public void Update(){} // RVA: 0x7FFAC8DD7D90
        public void UndefineTemps(){} // RVA: 0x7FFAC8DD7E40
    }

    public class FieldInstruction : Instruction
    {
        public System.Reflection.FieldInfo _field; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ToString(){} // RVA: 0x7FFAC8DAF5A0
    }

}