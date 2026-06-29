// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 3
// Methods: 10

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class ParameterByRefUpdater : ByRefUpdater
    {
        public object _parameter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70AD340
        public void Update(){} // RVA: 0x70AD3A0
    }

    public class PopInstruction : Instruction
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70BFE00
        public void Run(){} // RVA: 0x70BFE40
        public void .cctor(){} // RVA: 0x70BFE80
    }

    public class PropertyByRefUpdater : ByRefUpdater
    {
        public object _object;
        public object _property;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x70AD7A0
        public void Update(){} // RVA: 0x70AD9E0
        public void UndefineTemps(){} // RVA: 0x70ADAC0
    }

}