// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 7
// Methods: 33

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class CallInstruction : Instruction
    {
        public object ArgumentCount;
        public object InstructionName;
        public object ConsumedStack;

        // ── Methods ──
        public void get_ArgumentCount(){} // RVA: 0x7FFAC2C59960
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA5420
        public void Create(){} // RVA: 0x7FFAC8DA54C0 | overloaded x2
        public void GetArrayAccessor(){} // RVA: 0x7FFAC8DA5700
        public void ArrayItemSetter1(){} // RVA: 0x7FFAC8DA5DF0
        public void ArrayItemSetter2(){} // RVA: 0x7FFAC8DA5E20
        public void ArrayItemSetter3(){} // RVA: 0x7FFAC8DA5E50
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3825740
        public void TryGetLightLambdaTarget(){} // RVA: 0x7FFAC8DA5E90
        public void InterpretLambdaInvoke(){} // RVA: 0x7FFAC8DA6060
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CastInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.CastInstruction ConsumedStack;
        public System.Linq.Expressions.Interpreter.CastInstruction ProducedStack; // 0x8
        public System.Linq.Expressions.Interpreter.CastInstruction InstructionName; // 0x10
        public System.Linq.Expressions.Interpreter.CastInstruction s_DateTime; // 0x18
        public System.Linq.Expressions.Interpreter.CastInstruction s_Decimal; // 0x20
        public System.Linq.Expressions.Interpreter.CastInstruction s_Double; // 0x28
        public System.Linq.Expressions.Interpreter.CastInstruction s_Int16; // 0x30
        public System.Linq.Expressions.Interpreter.CastInstruction s_Int32; // 0x38
        public System.Linq.Expressions.Interpreter.CastInstruction s_Int64; // 0x40
        public System.Linq.Expressions.Interpreter.CastInstruction s_SByte; // 0x48
        public System.Linq.Expressions.Interpreter.CastInstruction s_Single; // 0x50
        public System.Linq.Expressions.Interpreter.CastInstruction s_String; // 0x58
        public System.Linq.Expressions.Interpreter.CastInstruction s_UInt16; // 0x60
        public System.Linq.Expressions.Interpreter.CastInstruction s_UInt32; // 0x68
        public System.Linq.Expressions.Interpreter.CastInstruction s_UInt64; // 0x70

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DEE9F0
        public void Create(){} // RVA: 0x7FFAC8DEEA30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class CastReferenceToEnumInstruction : CastInstruction
    {
        public System.Type _t; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Run(){} // RVA: 0x7FFAC8DEF930
    }

    public class CastToEnumInstruction : CastInstruction
    {
        public System.Type _t; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Run(){} // RVA: 0x7FFAC8DEF820
    }

    public class CoalescingBranchInstruction : OffsetInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction[] Cache;

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFAC8DA7580
        public void get_InstructionName(){} // RVA: 0x7FFAC8DA7660
        public void get_ConsumedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void Run(){} // RVA: 0x7FFAC8DA76A0
        public void .ctor(){} // RVA: 0x7FFAC8DA71D0
    }

    public class ConvertHelper : Object
    {
        // ── Methods ──
        public void ToInt32NoNull(){} // RVA: 0x7FFAC8DA4D00
    }

    public class CreateDelegateInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.LightDelegateCreator ConsumedStack; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_ConsumedStack(){} // RVA: 0x7FFAC8DED570
        public void get_ProducedStack(){} // RVA: 0x7FFAC3013AF0
        public void get_InstructionName(){} // RVA: 0x7FFAC8DED5D0
        public void Run(){} // RVA: 0x7FFAC8DED610
    }

}