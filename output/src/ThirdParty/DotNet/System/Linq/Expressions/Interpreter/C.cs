// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Linq.Expressions.Interpreter
// Classes: 7
// Methods: 33

namespace ThirdParty.DotNet.System.Linq.Expressions.Interpreter
{
    public class CallInstruction : Instruction
    {
        // ── Methods ──
        public void get_ArgumentCount(){} // RVA: 0x7FFE80E2EDB0
        public void get_InstructionName(){} // RVA: 0x7FFE8714D850
        public void Create(){} // RVA: 0x7FFE8714D8F0 | overloaded x2
        public void GetArrayAccessor(){} // RVA: 0x7FFE8714DB30
        public void ArrayItemSetter1(){} // RVA: 0x7FFE8714E220
        public void ArrayItemSetter2(){} // RVA: 0x7FFE8714E250
        public void ArrayItemSetter3(){} // RVA: 0x7FFE8714E280
        public void get_ConsumedStack(){} // RVA: 0x7FFE81980F70
        public void TryGetLightLambdaTarget(){} // RVA: 0x7FFE8714E2C0
        public void InterpretLambdaInvoke(){} // RVA: 0x7FFE8714E490
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CastInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.CastInstruction s_Boolean;
        public System.Linq.Expressions.Interpreter.CastInstruction s_Byte; // 0x8
        public System.Linq.Expressions.Interpreter.CastInstruction s_Char; // 0x10

        // ── Methods ──
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87196E20
        public void Create(){} // RVA: 0x7FFE87196E60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class CastReferenceToEnumInstruction : CastInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Run(){} // RVA: 0x7FFE87197D60
    }

    public class CastToEnumInstruction : CastInstruction
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Run(){} // RVA: 0x7FFE87197C50
    }

    public class CoalescingBranchInstruction : OffsetInstruction
    {
        public System.Linq.Expressions.Interpreter.Instruction[] s_cache;
        public object field_1; // 0x29A
        public object field_2; // 0x29B
        public object field_3; // 0x29C

        // ── Methods ──
        public void get_Cache(){} // RVA: 0x7FFE8714F9B0
        public void get_InstructionName(){} // RVA: 0x7FFE8714FA90
        public void get_ConsumedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void Run(){} // RVA: 0x7FFE8714FAD0
        public void .ctor(){} // RVA: 0x7FFE8714F600
    }

    public class ConvertHelper : Object
    {
        // ── Methods ──
        public void ToInt32NoNull(){} // RVA: 0x7FFE8714D130
    }

    public class CreateDelegateInstruction : Instruction
    {
        public System.Linq.Expressions.Interpreter.LightDelegateCreator _creator; // 0x10
        public object field_1; // 0x36F
        public object field_2; // 0x370

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_ConsumedStack(){} // RVA: 0x7FFE871959A0
        public void get_ProducedStack(){} // RVA: 0x7FFE811EDAF0
        public void get_InstructionName(){} // RVA: 0x7FFE87195A00
        public void Run(){} // RVA: 0x7FFE87195A40
    }

}