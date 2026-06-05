// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst
// Classes: 14
// Methods: 86

namespace ThirdParty.Other.Unity.Burst
{
    public class BurstAuthorizedExternalMethodAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BurstCompileAttribute
    {
        // ── Methods ──
        public void set_FloatMode(){} // RVA: 0x7FFAF2D900C0
        public void set_FloatPrecision(){} // RVA: 0x7FFAF335C660
        public void set_CompileSynchronously(){} // RVA: 0x7FFAF981C5A0
        public void set_Options(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF981C5F0 | overloaded x2
    }

    public class BurstCompiler
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFAF981C600
        public void CompileILPPMethod2(){} // RVA: 0x7FFAF981C6A0
        public void GetILPPMethodFunctionPointer2(){} // RVA: 0x7FFAF981C870
        public void Compile(){} // RVA: 0x7FFAF981CF00
        public void DummyMethod(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF981D720
        public void <GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0(){} // RVA: 0x7FFAF981DAE0
        public void Initialize$BurstCompilerHelper_IsBurstEnabled_00000145$BurstDirectCall(){} // RVA: 0x7FFAF981DC90
    }

    public class BurstCompilerOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF981E7E0
        public void get_IsGlobal(){} // RVA: 0x7FFAF440A940
        public void get_EnableBurstCompilation(){} // RVA: 0x7FFAF2E575E0
        public void set_EnableBurstCompilation(){} // RVA: 0x7FFAF981E940
        public void set_EnableBurstSafetyChecks(){} // RVA: 0x7FFAF981EA70
        public void get_OptionsChanged(){} // RVA: 0x7FFAF2D907C0
        public void TryGetAttribute(){} // RVA: 0x7FFAF981EAA0
        public void GetBurstCompileAttribute(){} // RVA: 0x7FFAF981EBE0
        public void HasBurstCompileAttribute(){} // RVA: 0x7FFAF981EED0
        public void OnOptionsChanged(){} // RVA: 0x7FFAF313B350
        public void MaybeTriggerRecompilation(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF981F050
        public void CheckIsSecondaryUnityProcess(){} // RVA: 0x7FFAF2D8D320
    }

    public class BurstDiscardAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BurstRuntime
    {
        // ── Methods ──
        public void RuntimeLog(){} // RVA: 0x7FFAF981F230
        public void PreventRequiredAttributeStrip(){} // RVA: 0x7FFAF981F2B0
        public void Log(){} // RVA: 0x7FFAF981F490
    }

    public class BurstString
    {
        // ── Methods ──
        public void CopyFixedString(){} // RVA: 0x7FFAF981F510
        public void Format(){} // RVA: 0x7FFAF981FF80 | overloaded x13
        public void ConvertUnsignedIntegerToString(){} // RVA: 0x7FFAF9820050
        public void GetLengthIntegerToString(){} // RVA: 0x7FFAF9820200
        public void ConvertIntegerToString(){} // RVA: 0x7FFAF9820230
        public void FormatNumber(){} // RVA: 0x7FFAF9820400
        public void FormatDecimalOrHexadecimal(){} // RVA: 0x7FFAF98207D0
        public void ValueToIntegerChar(){} // RVA: 0x7FFAF9820880
        public void AlignRight(){} // RVA: 0x7FFAF98208B0
        public void AlignLeft(){} // RVA: 0x7FFAF9820950
        public void GetLengthForFormatGeneral(){} // RVA: 0x7FFAF9820990
        public void FormatGeneral(){} // RVA: 0x7FFAF9820AD0
        public void RoundNumber(){} // RVA: 0x7FFAF9820C70
        public void ShouldRoundUp(){} // RVA: 0x7FFAF9820D90
        public void LogBase2(){} // RVA: 0x7FFAF9820DC0
        public void BigInt_Compare(){} // RVA: 0x7FFAF9820F30
        public void BigInt_Add(){} // RVA: 0x7FFAF9820F90
        public void BigInt_Add_internal(){} // RVA: 0x7FFAF9821020
        public void BigInt_Multiply(){} // RVA: 0x7FFAF9821270 | overloaded x2
        public void BigInt_Multiply_internal(){} // RVA: 0x7FFAF9821180
        public void BigInt_Multiply2(){} // RVA: 0x7FFAF9821350 | overloaded x2
        public void BigInt_Multiply10(){} // RVA: 0x7FFAF98213A0
        public void g_PowerOf10_Big(){} // RVA: 0x7FFAF98213E0
        public void BigInt_Pow10(){} // RVA: 0x7FFAF98215B0
        public void BigInt_MultiplyPow10(){} // RVA: 0x7FFAF9821880
        public void BigInt_Pow2(){} // RVA: 0x7FFAF9821C10
        public void BigInt_DivideWithRemainder_MaxQuotient9(){} // RVA: 0x7FFAF9821C70
        public void BigInt_ShiftLeft(){} // RVA: 0x7FFAF9821E50
        public void Dragon4(){} // RVA: 0x7FFAF9821FF0
        public void FormatInfinityNaN(){} // RVA: 0x7FFAF9823420
        public void ConvertFloatToString(){} // RVA: 0x7FFAF9823610
        public void ConvertDoubleToString(){} // RVA: 0x7FFAF98238B0
        public void .cctor(){} // RVA: 0x7FFAF9823B70
    }

    public class FunctionPointer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4CC0
        public void get_Invoke(){} // RVA: 0x7FFAF2D33FA0
    }

    public class FunctionPointer`1
    {
    }

    public class SharedStatic
    {
        // ── Methods ──
        public void GetOrCreateSharedStaticInternal(){} // RVA: 0x7FFAF9824420
    }

    public class SharedStatic`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D33FA0
        public void get_Data(){} // RVA: 0x7FFAF2ABCD60
        public void GetOrCreateUnsafe(){} // RVA: 0x7FFAF2D33FA0
    }

    public class SharedStatic`1
    {
    }

    public class SharedStatic`1
    {
    }

    public class Unsafe
    {
        // ── Methods ──
        public void AsRef(){} // RVA: 0x7FFAF2D33FA0
    }

}