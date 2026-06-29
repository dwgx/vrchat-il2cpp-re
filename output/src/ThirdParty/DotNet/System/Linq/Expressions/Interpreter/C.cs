// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 7
// Methods: 32

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class CallInstruction : Instruction
    {
        // ── Methods ──
        public void get_ArgumentCount(){} // RVA: 0x7A7E00710
        public void get_InstructionName(){} // RVA: 0x7AE3FD420
        public void Create(){} // RVA: 0x7AE3FD4C0
        public void GetArrayAccessor(){} // RVA: 0x7AE3FD700
        public void ArrayItemSetter1(){} // RVA: 0x7AE3FDE00
        public void ArrayItemSetter2(){} // RVA: 0x7AE3FDE30
        public void ArrayItemSetter3(){} // RVA: 0x7AE3FDE60
        public void get_ConsumedStack(){} // RVA: 0x7A89B55B0
        public void TryGetLightLambdaTarget(){} // RVA: 0x7AE3FDEA0
        public void InterpretLambdaInvoke(){} // RVA: 0x7AE3FE060
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CastInstruction : Instruction
    {
        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE4469C0
        public void Create(){} // RVA: 0x7AE446A00
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class CastReferenceToEnumInstruction : CastInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Run(){} // RVA: 0x7AE447900
    }

    public class CastToEnumInstruction : CastInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Run(){} // RVA: 0x7AE4477F0
    }

    public class CoalescingBranchInstruction : OffsetInstruction
    {
        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7AE3FF5A0
        public void get_InstructionName(){} // RVA: 0x7AE3FF680
        public void get_ConsumedStack(){} // RVA: 0x7A81CA9D0
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void Run(){} // RVA: 0x7AE3FF6C0
        public void .ctor(){} // RVA: 0x7AE3FF1F0
    }

    public class ConvertHelper : Object
    {
        // ── Methods ──
        public void ToInt32NoNull(){} // RVA: 0x7AE3FCCF0
    }

    public class CreateDelegateInstruction : Instruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_ConsumedStack(){} // RVA: 0x7AE445530
        public void get_ProducedStack(){} // RVA: 0x7A81CA9D0
        public void get_InstructionName(){} // RVA: 0x7AE445590
        public void Run(){} // RVA: 0x7AE4455D0
    }

}