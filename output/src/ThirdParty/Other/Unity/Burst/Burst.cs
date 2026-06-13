// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst
// Classes: 14
// Methods: 86

namespace ThirdParty.Other.Unity.Burst
{
    public class BurstAuthorizedExternalMethodAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BurstCompileAttribute
    {
        public 0x659E6A60 <FloatMode>k__BackingField; // 0x10
        public 0x659E6AB8 <FloatPrecision>k__BackingField; // 0x14
        public System.Nullable`1<bool> _compileSynchronously; // 0x18
        public string[] <Options>k__BackingField; // 0x20

        // ── Methods ──
        public void set_FloatMode(){} // RVA: 0x2E00C0
        public void set_FloatPrecision(){} // RVA: 0x8AC660
        public void set_CompileSynchronously(){} // RVA: 0x6D6C5A0
        public void set_Options(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x6D6C5F0 | overloaded x2
    }

    public class BurstCompiler
    {
        public bool _IsEnabled;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x6D6C600
        public void CompileILPPMethod2(){} // RVA: 0x6D6C6A0
        public void GetILPPMethodFunctionPointer2(){} // RVA: 0x6D6C870
        public void Compile(){} // RVA: 0x6D6CF00
        public void DummyMethod(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6D6D720
        public void <GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0(){} // RVA: 0x6D6DAE0
        public void Initialize$BurstCompilerHelper_IsBurstEnabled_00000145$BurstDirectCall(){} // RVA: 0x6D6DC90
    }

    public class BurstCompilerOptions
    {
        public bool ForceDisableBurstCompilation;
        public bool ForceBurstCompilationSynchronously; // 0x1
        public bool IsSecondaryUnityProcess; // 0x2
        public bool _enableBurstCompilation; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D6E7E0
        public void get_IsGlobal(){} // RVA: 0x195A940
        public void get_EnableBurstCompilation(){} // RVA: 0x3A75E0
        public void set_EnableBurstCompilation(){} // RVA: 0x6D6E940
        public void set_EnableBurstSafetyChecks(){} // RVA: 0x6D6EA70
        public void get_OptionsChanged(){} // RVA: 0x2E07C0
        public void TryGetAttribute(){} // RVA: 0x6D6EAA0
        public void GetBurstCompileAttribute(){} // RVA: 0x6D6EBE0
        public void HasBurstCompileAttribute(){} // RVA: 0x6D6EED0
        public void OnOptionsChanged(){} // RVA: 0x68B350
        public void MaybeTriggerRecompilation(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6D6F050
        public void CheckIsSecondaryUnityProcess(){} // RVA: 0x2DD320
    }

    public class BurstDiscardAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BurstRuntime
    {
        // ── Methods ──
        public void RuntimeLog(){} // RVA: 0x6D6F230
        public void PreventRequiredAttributeStrip(){} // RVA: 0x6D6F2B0
        public void Log(){} // RVA: 0x6D6F490
    }

    public class BurstString
    {
        // ── Methods ──
        public void CopyFixedString(){} // RVA: 0x6D6F510
        public void Format(){} // RVA: 0x6D6FF80 | overloaded x13
        public void ConvertUnsignedIntegerToString(){} // RVA: 0x6D70050
        public void GetLengthIntegerToString(){} // RVA: 0x6D70200
        public void ConvertIntegerToString(){} // RVA: 0x6D70230
        public void FormatNumber(){} // RVA: 0x6D70400
        public void FormatDecimalOrHexadecimal(){} // RVA: 0x6D707D0
        public void ValueToIntegerChar(){} // RVA: 0x6D70880
        public void AlignRight(){} // RVA: 0x6D708B0
        public void AlignLeft(){} // RVA: 0x6D70950
        public void GetLengthForFormatGeneral(){} // RVA: 0x6D70990
        public void FormatGeneral(){} // RVA: 0x6D70AD0
        public void RoundNumber(){} // RVA: 0x6D70C70
        public void ShouldRoundUp(){} // RVA: 0x6D70D90
        public void LogBase2(){} // RVA: 0x6D70DC0
        public void BigInt_Compare(){} // RVA: 0x6D70F30
        public void BigInt_Add(){} // RVA: 0x6D70F90
        public void BigInt_Add_internal(){} // RVA: 0x6D71020
        public void BigInt_Multiply(){} // RVA: 0x6D71270 | overloaded x2
        public void BigInt_Multiply_internal(){} // RVA: 0x6D71180
        public void BigInt_Multiply2(){} // RVA: 0x6D71350 | overloaded x2
        public void BigInt_Multiply10(){} // RVA: 0x6D713A0
        public void g_PowerOf10_Big(){} // RVA: 0x6D713E0
        public void BigInt_Pow10(){} // RVA: 0x6D715B0
        public void BigInt_MultiplyPow10(){} // RVA: 0x6D71880
        public void BigInt_Pow2(){} // RVA: 0x6D71C10
        public void BigInt_DivideWithRemainder_MaxQuotient9(){} // RVA: 0x6D71C70
        public void BigInt_ShiftLeft(){} // RVA: 0x6D71E50
        public void Dragon4(){} // RVA: 0x6D71FF0
        public void FormatInfinityNaN(){} // RVA: 0x6D73420
        public void ConvertFloatToString(){} // RVA: 0x6D73610
        public void ConvertDoubleToString(){} // RVA: 0x6D738B0
        public void .cctor(){} // RVA: 0x6D73B70
    }

    public class FunctionPointer`1
    {
        public UIntPtr _ptr;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24CC0
        public void get_Invoke(){} // RVA: 0x283FA0
    }

    public class FunctionPointer`1
    {
        public UIntPtr _ptr;
    }

    public class SharedStatic
    {
        // ── Methods ──
        public void GetOrCreateSharedStaticInternal(){} // RVA: 0x6D74420
    }

    public class SharedStatic`1
    {
        public void* _buffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_Data(){} // RVA: 0xCD60
        public void GetOrCreateUnsafe(){} // RVA: 0x283FA0
    }

    public class SharedStatic`1
    {
        public void* _buffer; // 0x10
    }

    public class SharedStatic`1
    {
        public void* _buffer; // 0x10
    }

    public class Unsafe
    {
        // ── Methods ──
        public void AsRef(){} // RVA: 0x283FA0
    }

}