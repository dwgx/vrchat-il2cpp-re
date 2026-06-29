// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 7
// Methods: 32

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class CallInstruction : Instruction
    {
        // ── Methods ──
        public void get_ArgumentCount(){} // RVA: 0x87C130
        public void get_InstructionName(){} // RVA: 0x707C550
        public void Create(){} // RVA: 0x707C5F0
        public void GetArrayAccessor(){} // RVA: 0x707C820
        public void ArrayItemSetter1(){} // RVA: 0x707CF10
        public void ArrayItemSetter2(){} // RVA: 0x707CF40
        public void ArrayItemSetter3(){} // RVA: 0x707CF70
        public void get_ConsumedStack(){} // RVA: 0x14B3B70
        public void TryGetLightLambdaTarget(){} // RVA: 0x707CFB0
        public void InterpretLambdaInvoke(){} // RVA: 0x707D170
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CastInstruction : Instruction
    {
        public object s_Boolean;
        public object s_Byte;
        public object s_Char;
        public object s_DateTime;
        public object s_Decimal;
        public object s_Double;
        public object s_Int16;
        public object s_Int32;
        public object s_Int64;
        public object s_SByte;
        public object s_Single;
        public object s_String;
        public object s_UInt16;
        public object s_UInt32;
        public object s_UInt64;

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70C3350
        public void Create(){} // RVA: 0x70C3390
        public void .ctor(){} // RVA: 0xB43310
    }

    public class CastReferenceToEnumInstruction : CastInstruction
    {
        public object _t;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Run(){} // RVA: 0x70C42B0
    }

    public class CastToEnumInstruction : CastInstruction
    {
        public object _t;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Run(){} // RVA: 0x70C41C0
    }

    public class CoalescingBranchInstruction : OffsetInstruction
    {
        public object s_cache;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x707E410
        public void get_InstructionName(){} // RVA: 0x707E4F0
        public void get_ConsumedStack(){} // RVA: 0xC3CCE0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void Run(){} // RVA: 0x707E530
        public void .ctor(){} // RVA: 0x707E0C0
    }

    public class ConvertHelper : Object
    {
        // ── Methods ──
        public void ToInt32NoNull(){} // RVA: 0x707BE30
    }

    public class CreateDelegateInstruction : Instruction
    {
        public object _creator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_ConsumedStack(){} // RVA: 0x70C1EC0
        public void get_ProducedStack(){} // RVA: 0xC3CCE0
        public void get_InstructionName(){} // RVA: 0x70C1F20
        public void Run(){} // RVA: 0x70C1F60
    }

}