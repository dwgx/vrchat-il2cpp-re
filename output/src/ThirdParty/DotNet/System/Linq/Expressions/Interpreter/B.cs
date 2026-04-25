// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 7
// Methods: 35

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class BranchFalseInstruction : OffsetInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction[] Cache;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFAC8DA71E0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA72C0
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void Run(){} // RVA: 0x7FFAC8DA7300
        public void .ctor(){} // RVA: 0x7FFAC8DA71D0
    }

    public class BranchInstruction : OffsetInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction[][][] Cache;
        public bool InstructionName; // 0x18
        public bool ConsumedStack; // 0x19

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFAC8DA76F0
        public void .ctor(){} // RVA: 0x7FFAC8DA7A60 | overloaded x2
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA7A70
        public void get_ConsumedStack(){} // RVA: 0x7FFAC8DA7AB0
        public void get_ProducedStack(){} // RVA: 0x7FFAC8DA7AC0
        public void Run(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class BranchLabel : Object
    {
        public int LabelIndex;
        public int HasRuntimeLabel;
        public int TargetIndex; // 0x10
        public int _stackDepth; // 0x14
        public int _continuationStackDepth; // 0x18
        public System.Collections.Generic.List`1<int> _forwardBranchFixups; // 0x20
        public int <LabelIndex>k__BackingField; // 0x28

        // ── Methods ──
        public void get_LabelIndex(){} // RVA: 0x7FFAC32EC4C0
        public void set_LabelIndex(){} // RVA: 0x7FFAC369A6E0
        public void get_HasRuntimeLabel(){} // RVA: 0x7FFAC8DA4F60
        public void get_TargetIndex(){} // RVA: 0x7FFAC2F6E5C0
        public void ToRuntimeLabel(){} // RVA: 0x7FFAC8DA4F70
        public void Mark(){} // RVA: 0x7FFAC8DA4F90
        public void AddBranch(){} // RVA: 0x7FFAC8DA5250
        public void FixupBranch(){} // RVA: 0x7FFAC8DA53D0
        public void .ctor(){} // RVA: 0x7FFAC8DA5400
    }

    public class BranchTrueInstruction : OffsetInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction[] Cache;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFAC8DA73B0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA7490
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void Run(){} // RVA: 0x7FFAC8DA74D0
        public void .ctor(){} // RVA: 0x7FFAC8DA71D0
    }

    public class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction
    {
        public System.Linq.Expressions.Interpreter.ByRefUpdater[] ProducedStack; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86E9F50
        public void get_ProducedStack(){} // RVA: 0x7FFAC8DA66E0
        public void Run(){} // RVA: 0x7FFAC8DA67E0
    }

    public class ByRefNewInstruction : NewInstruction
    {
        public System.Linq.Expressions.Interpreter.ByRefUpdater[] InstructionName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86E9F50
        public void get_InstructionName(){} // RVA: 0x7FFAC8DE2AB0
        public void Run(){} // RVA: 0x7FFAC8DE2AF0
    }

    public class ByRefUpdater : Object
    {
        public int ArgumentIndex; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void Update(){} // RVA: 0x7FFAC2C79B30
        public void UndefineTemps(){} // RVA: 0x7FFAC2F21310
    }

}