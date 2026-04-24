// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst
// Classes: 10
// Methods: 84

namespace ThirdParty.Other.Unity.Burst
{
    public class BurstCompileAttribute : Attribute
    {
        public object _compileSynchronously; // 0x33AAC4D0

        // ── Original Methods ──
        public void set_FloatMode(){} // RVA: 0x7ffaa89350c0
        public void set_FloatPrecision(){} // RVA: 0x7ffaa8e03640
        public void set_CompileSynchronously(){} // RVA: 0x7ffaaef26cd0
        public void set_Options(){} // RVA: 0x7ffaa89600d0
        public void .ctor(){} // RVA: 0x7ffaaef26d20
        public void .ctor(){} // RVA: 0x7ffaaef26d20
    }

    public class BurstCompiler : Object
    {
        public object OnCompileILPPMethod2; // 0x334C7570

        // ── Original Methods ──
        public void get_IsEnabled(){} // RVA: 0x7ffaaef26d30
        public void CompileILPPMethod2(){} // RVA: 0x7ffaaef26dd0
        public void Compile(){} // RVA: 0x7ffaaef27630
        public void DummyMethod(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaef27e50
        public void <GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0(){} // RVA: 0x7ffaaef28210
        public void Initialize$BurstCompilerHelper_IsBurstEnabled_00000145$BurstDirectCall(){} // RVA: 0x7ffaaef283c0
        // ── Binary Analysis Named ──
        public void GetILPPMethodFunctionPointer2(){} // RVA: 0x7ffaaef26fa0
    }

    public class BurstCompilerOptions : Object
    {
        public object IsSecondaryUnityProcess; // 0x33C64E30
        public object _isGlobal; // 0x33C64E30, was: <IsGlobal>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaef28f10
        public void get_IsGlobal(){} // RVA: 0x7ffaa950f430
        public void get_EnableBurstCompilation(){} // RVA: 0x7ffaa89fc5e0
        public void set_EnableBurstCompilation(){} // RVA: 0x7ffaaef29070
        public void set_EnableBurstSafetyChecks(){} // RVA: 0x7ffaaef291a0
        public void get_OptionsChanged(){} // RVA: 0x7ffaa89357c0
        public void TryGetAttribute(){} // RVA: 0x7ffaaef291d0
        public void HasBurstCompileAttribute(){} // RVA: 0x7ffaaef29600
        public void OnOptionsChanged(){} // RVA: 0x7ffaa8b02670
        public void MaybeTriggerRecompilation(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaaef29780
        // ── Binary Analysis Named ──
        public void GetBurstCompileAttribute(){} // RVA: 0x7ffaaef29310
        public void CheckIsSecondaryUnityProcess(){} // RVA: 0x7ffaa8932320
    }

    public class BurstRuntime : Object
    {
        // ── Original Methods ──
        public void RuntimeLog(){} // RVA: 0x7ffaaef29960
        public void PreventRequiredAttributeStrip(){} // RVA: 0x7ffaaef299e0
        public void Log(){} // RVA: 0x7ffaaef29bc0
    }

    public class BurstString : Object
    {
        public object g_PowerOf10_U32; // 0x33685400

        // ── Original Methods ──
        public void CopyFixedString(){} // RVA: 0x7ffaaef29c40
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void Format(){} // RVA: 0x7ffaaef2a6b0
        public void ConvertUnsignedIntegerToString(){} // RVA: 0x7ffaaef2a780
        public void ConvertIntegerToString(){} // RVA: 0x7ffaaef2a960
        public void FormatNumber(){} // RVA: 0x7ffaaef2ab30
        public void FormatDecimalOrHexadecimal(){} // RVA: 0x7ffaaef2af00
        public void ValueToIntegerChar(){} // RVA: 0x7ffaaef2afb0
        public void AlignRight(){} // RVA: 0x7ffaaef2afe0
        public void AlignLeft(){} // RVA: 0x7ffaaef2b080
        public void FormatGeneral(){} // RVA: 0x7ffaaef2b200
        public void RoundNumber(){} // RVA: 0x7ffaaef2b3a0
        public void ShouldRoundUp(){} // RVA: 0x7ffaaef2b4c0
        public void LogBase2(){} // RVA: 0x7ffaaef2b4f0
        public void BigInt_Compare(){} // RVA: 0x7ffaaef2b660
        public void BigInt_Add(){} // RVA: 0x7ffaaef2b6c0
        public void BigInt_Add_internal(){} // RVA: 0x7ffaaef2b750
        public void BigInt_Multiply(){} // RVA: 0x7ffaaef2b9a0
        public void BigInt_Multiply_internal(){} // RVA: 0x7ffaaef2b8b0
        public void BigInt_Multiply(){} // RVA: 0x7ffaaef2b9a0
        public void BigInt_Multiply2(){} // RVA: 0x7ffaaef2ba80
        public void BigInt_Multiply2(){} // RVA: 0x7ffaaef2ba80
        public void BigInt_Multiply10(){} // RVA: 0x7ffaaef2bad0
        public void g_PowerOf10_Big(){} // RVA: 0x7ffaaef2bb10
        public void BigInt_Pow10(){} // RVA: 0x7ffaaef2bce0
        public void BigInt_MultiplyPow10(){} // RVA: 0x7ffaaef2bfb0
        public void BigInt_Pow2(){} // RVA: 0x7ffaaef2c340
        public void BigInt_DivideWithRemainder_MaxQuotient9(){} // RVA: 0x7ffaaef2c3a0
        public void BigInt_ShiftLeft(){} // RVA: 0x7ffaaef2c580
        public void Dragon4(){} // RVA: 0x7ffaaef2c720
        public void FormatInfinityNaN(){} // RVA: 0x7ffaaef2db50
        public void ConvertFloatToString(){} // RVA: 0x7ffaaef2dd40
        public void ConvertDoubleToString(){} // RVA: 0x7ffaaef2dfe0
        public void .cctor(){} // RVA: 0x7ffaaef2e2a0
        // ── Binary Analysis Named ──
        public void GetLengthIntegerToString(){} // RVA: 0x7ffaaef2a930
        public void GetLengthForFormatGeneral(){} // RVA: 0x7ffaaef2b0c0
    }

    public class FunctionPointer`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660f30
        public void get_Invoke(){} // RVA: 0x7ffaa887e5c0
    }

    public class FunctionPointer`1 : ValueType
    {
    }

    public class SharedStatic : Object
    {
        // ── Binary Analysis Named ──
        public void GetOrCreateSharedStaticInternal(){} // RVA: 0x7ffaaef2eb50
    }

    public class SharedStatic`1 : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void get_Data(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void GetOrCreateUnsafe(){} // RVA: 0x7ffaa887e5c0
    }

    public class Unsafe : Object
    {
        // ── Original Methods ──
        public void AsRef(){} // RVA: 0x7ffaa887e5c0
    }

}