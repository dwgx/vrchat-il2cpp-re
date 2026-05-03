// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst
// Classes: 11
// Methods: 86

namespace ThirdParty.Other.Unity.Burst
{
    public class BurstAuthorizedExternalMethodAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BurstCompileAttribute : Attribute
    {
        public 0x666BDFCC _floatMode; // 0x10
        public 0x666BE024 _floatPrecision; // 0x14
        public System.Nullable`1<bool> _compileSynchronously; // 0x18
        public string[] _options; // 0x20

        // ── Methods ──
        public void set_FloatMode(){} // RVA: 0x7FFE810FE0C0
        public void set_FloatPrecision(){} // RVA: 0x7FFE8164E0F0
        public void set_CompileSynchronously(){} // RVA: 0x7FFE878AD440
        public void set_Options(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE878AD490 | overloaded x2
    }

    public class BurstCompiler : Object
    {
        public bool _IsEnabled;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFE878AD4A0
        public void CompileILPPMethod2(){} // RVA: 0x7FFE878AD540
        public void GetILPPMethodFunctionPointer2(){} // RVA: 0x7FFE878AD710
        public void Compile(){} // RVA: 0x7FFE878ADDA0
        public void DummyMethod(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE878AE5C0
        public void <GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0(){} // RVA: 0x7FFE878AE980
        public void Initialize$BurstCompilerHelper_IsBurstEnabled_00000145$BurstDirectCall(){} // RVA: 0x7FFE878AEB30
    }

    public class BurstCompilerOptions : Object
    {
        public bool ForceDisableBurstCompilation;
        public bool ForceBurstCompilationSynchronously; // 0x1
        public bool IsSecondaryUnityProcess; // 0x2
        public bool _enableBurstCompilation; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE878AF680
        public void get_IsGlobal(){} // RVA: 0x7FFE826E3520
        public void get_EnableBurstCompilation(){} // RVA: 0x7FFE811C55E0
        public void set_EnableBurstCompilation(){} // RVA: 0x7FFE878AF7E0
        public void set_EnableBurstSafetyChecks(){} // RVA: 0x7FFE878AF910
        public void get_OptionsChanged(){} // RVA: 0x7FFE810FE7C0
        public void TryGetAttribute(){} // RVA: 0x7FFE878AF940
        public void GetBurstCompileAttribute(){} // RVA: 0x7FFE878AFA80
        public void HasBurstCompileAttribute(){} // RVA: 0x7FFE878AFD70
        public void OnOptionsChanged(){} // RVA: 0x7FFE8148FF70
        public void MaybeTriggerRecompilation(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE878AFEF0
        public void CheckIsSecondaryUnityProcess(){} // RVA: 0x7FFE810FB320
    }

    public class BurstDiscardAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BurstRuntime : Object
    {
        // ── Methods ──
        public void RuntimeLog(){} // RVA: 0x7FFE878B00D0
        public void PreventRequiredAttributeStrip(){} // RVA: 0x7FFE878B0150
        public void Log(){} // RVA: 0x7FFE878B0330
    }

    public class BurstString : Object
    {
        // ── Methods ──
        public void CopyFixedString(){} // RVA: 0x7FFE878B03B0
        public void Format(){} // RVA: 0x7FFE878B0E20 | overloaded x13
        public void ConvertUnsignedIntegerToString(){} // RVA: 0x7FFE878B0EF0
        public void GetLengthIntegerToString(){} // RVA: 0x7FFE878B10A0
        public void ConvertIntegerToString(){} // RVA: 0x7FFE878B10D0
        public void FormatNumber(){} // RVA: 0x7FFE878B12A0
        public void FormatDecimalOrHexadecimal(){} // RVA: 0x7FFE878B1670
        public void ValueToIntegerChar(){} // RVA: 0x7FFE878B1720
        public void AlignRight(){} // RVA: 0x7FFE878B1750
        public void AlignLeft(){} // RVA: 0x7FFE878B17F0
        public void GetLengthForFormatGeneral(){} // RVA: 0x7FFE878B1830
        public void FormatGeneral(){} // RVA: 0x7FFE878B1970
        public void RoundNumber(){} // RVA: 0x7FFE878B1B10
        public void ShouldRoundUp(){} // RVA: 0x7FFE878B1C30
        public void LogBase2(){} // RVA: 0x7FFE878B1C60
        public void BigInt_Compare(){} // RVA: 0x7FFE878B1DD0
        public void BigInt_Add(){} // RVA: 0x7FFE878B1E30
        public void BigInt_Add_internal(){} // RVA: 0x7FFE878B1EC0
        public void BigInt_Multiply(){} // RVA: 0x7FFE878B2110 | overloaded x2
        public void BigInt_Multiply_internal(){} // RVA: 0x7FFE878B2020
        public void BigInt_Multiply2(){} // RVA: 0x7FFE878B21F0 | overloaded x2
        public void BigInt_Multiply10(){} // RVA: 0x7FFE878B2240
        public void g_PowerOf10_Big(){} // RVA: 0x7FFE878B2280
        public void BigInt_Pow10(){} // RVA: 0x7FFE878B2450
        public void BigInt_MultiplyPow10(){} // RVA: 0x7FFE878B2720
        public void BigInt_Pow2(){} // RVA: 0x7FFE878B2AB0
        public void BigInt_DivideWithRemainder_MaxQuotient9(){} // RVA: 0x7FFE878B2B10
        public void BigInt_ShiftLeft(){} // RVA: 0x7FFE878B2CF0
        public void Dragon4(){} // RVA: 0x7FFE878B2E90
        public void FormatInfinityNaN(){} // RVA: 0x7FFE878B42C0
        public void ConvertFloatToString(){} // RVA: 0x7FFE878B44B0
        public void ConvertDoubleToString(){} // RVA: 0x7FFE878B4750
        public void .cctor(){} // RVA: 0x7FFE878B4A10
    }

    public class FunctionPointer`1 : ValueType
    {
        public UIntPtr _ptr;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46250
        public void get_Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class SharedStatic : Object
    {
        // ── Methods ──
        public void GetOrCreateSharedStaticInternal(){} // RVA: 0x7FFE878B52C0
    }

    public class SharedStatic`1 : ValueType
    {
        public void* _buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_Data(){} // RVA: 0x7FFE80E2E2E0
        public void GetOrCreateUnsafe(){} // RVA: 0x7FFE810A1420
    }

    public class Unsafe : Object
    {
        // ── Methods ──
        public void AsRef(){} // RVA: 0x7FFE810A1420
    }

}