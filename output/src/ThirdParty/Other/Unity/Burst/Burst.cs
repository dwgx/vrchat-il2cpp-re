// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst
// Classes: 12
// Methods: 70

namespace ThirdParty.Other.Unity.Burst
{
    public class BurstAuthorizedExternalMethodAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BurstCompileAttribute : Attribute
    {
        // ── Methods ──
        public void set_FloatMode(){} // RVA: 0xB460A0
        public void set_FloatPrecision(){} // RVA: 0x116BB10
        public void set_CompileSynchronously(){} // RVA: 0x77C9F00
        public void set_Options(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x77C9F50
    }

    public class BurstCompiler : Object
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x77C9F60
        public void CompileFunctionPointer(){} // RVA: 0xA94080
        public void Compile(){} // RVA: 0x77CA180
        public void DummyMethod(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x77CAA20
    }

    public class BurstCompilerOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x77CB7E0
        public void get_IsGlobal(){} // RVA: 0x22201E0
        public void get_EnableBurstCompilation(){} // RVA: 0xC120A0
        public void set_EnableBurstCompilation(){} // RVA: 0x77CB940
        public void set_EnableBurstSafetyChecks(){} // RVA: 0x77CBA70
        public void get_OptionsChanged(){} // RVA: 0xB465B0
        public void TryGetAttribute(){} // RVA: 0x77CBAA0
        public void GetBurstCompileAttribute(){} // RVA: 0x77CBBD0
        public void HasBurstCompileAttribute(){} // RVA: 0x77CBEC0
        public void OnOptionsChanged(){} // RVA: 0xF158E0
        public void MaybeTriggerRecompilation(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x77CC040
        public void CheckIsSecondaryUnityProcess(){} // RVA: 0xB43320
    }

    public class BurstDiscardAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BurstRuntime : Object
    {
        // ── Methods ──
        public void RuntimeLog(){} // RVA: 0x77CC220
        public void PreventRequiredAttributeStrip(){} // RVA: 0x77CC2A0
        public void Log(){} // RVA: 0x77CC450
    }

    public class BurstString : Object
    {
        // ── Methods ──
        public void CopyFixedString(){} // RVA: 0x77CC4D0
        public void Format(){} // RVA: 0x77CCF40
        public void ConvertUnsignedIntegerToString(){} // RVA: 0x77CD010
        public void GetLengthIntegerToString(){} // RVA: 0x77CD1D0
        public void ConvertIntegerToString(){} // RVA: 0x77CD200
        public void FormatNumber(){} // RVA: 0x77CD3C0
        public void FormatDecimalOrHexadecimal(){} // RVA: 0x77CD780
        public void ValueToIntegerChar(){} // RVA: 0x77CD830
        public void AlignRight(){} // RVA: 0x77CD860
        public void AlignLeft(){} // RVA: 0x77CD900
        public void GetLengthForFormatGeneral(){} // RVA: 0x77CD940
        public void FormatGeneral(){} // RVA: 0x77CDA80
        public void RoundNumber(){} // RVA: 0x77CDC20
        public void ShouldRoundUp(){} // RVA: 0x77CDD40
        public void LogBase2(){} // RVA: 0x77CDD70
        public void BigInt_Compare(){} // RVA: 0x77CDEE0
        public void BigInt_Add(){} // RVA: 0x77CDF40
        public void BigInt_Add_internal(){} // RVA: 0x77CDFD0
        public void BigInt_Multiply(){} // RVA: 0x77CE230
        public void BigInt_Multiply_internal(){} // RVA: 0x77CE130
        public void BigInt_Multiply2(){} // RVA: 0x77CE320
        public void BigInt_Multiply10(){} // RVA: 0x77CE370
        public void g_PowerOf10_Big(){} // RVA: 0x77CE3B0
        public void BigInt_Pow10(){} // RVA: 0x77CE580
        public void BigInt_MultiplyPow10(){} // RVA: 0x77CE7F0
        public void BigInt_Pow2(){} // RVA: 0x77CEB10
        public void BigInt_DivideWithRemainder_MaxQuotient9(){} // RVA: 0x77CEB70
        public void BigInt_ShiftLeft(){} // RVA: 0x77CED50
        public void Dragon4(){} // RVA: 0x77CEEF0
        public void FormatInfinityNaN(){} // RVA: 0x77D0240
        public void ConvertFloatToString(){} // RVA: 0x77D0430
        public void ConvertDoubleToString(){} // RVA: 0x77D06D0
        public void .cctor(){} // RVA: 0x77D0990
    }

    public class FunctionPointer`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8943F0
        public void get_Value(){} // RVA: 0x87C0A0
        public void get_Invoke(){} // RVA: 0xA94080
    }

    public class FunctionPointer`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x93050
    }

    public class SharedStatic : Object
    {
        // ── Methods ──
        public void GetOrCreateSharedStaticInternal(){} // RVA: 0x77D1200
    }

    public class SharedStatic`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void get_Data(){} // RVA: 0x87C0A0
        public void GetOrCreateUnsafe(){} // RVA: 0xA94080
    }

    public class Unsafe : Object
    {
        // ── Methods ──
        public void AsRef(){} // RVA: 0xA94080
    }

}