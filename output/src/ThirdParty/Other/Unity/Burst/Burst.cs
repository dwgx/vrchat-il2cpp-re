// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst
// Classes: 9
// Methods: 84

namespace ThirdParty.Other.Unity.Burst
{
    public class BurstCompileAttribute : Attribute
    {
        public ÌÎÎÍÌÍÍÍ FloatMode; // 0x10
        public 0x666234D0 FloatPrecision; // 0x14
        public System.Nullable`1<bool> CompileSynchronously; // 0x18
        public string[] Options; // 0x20

        // ── Methods ──
        public void set_FloatMode(){} // RVA: 0x7FFD4E3440C0
        public void set_FloatPrecision(){} // RVA: 0x7FFD4E7F4990
        public void set_CompileSynchronously(){} // RVA: 0x7FFD54924D00
        public void set_Options(){} // RVA: 0x7FFD4E36F0D0
        public void .ctor(){} // RVA: 0x7FFD54924D50 | overloaded x2
    }

    public class BurstCompiler : Object
    {
        public bool IsEnabled;
        public Unity.Burst.BurstCompilerOptions Options; // 0x8
        public System.Action OnCompileILPPMethod2; // 0x10
        public System.Reflection.MethodInfo DummyMethodInfo; // 0x18

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFD54924D60
        public void CompileILPPMethod2(){} // RVA: 0x7FFD54924E00
        public void GetILPPMethodFunctionPointer2(){} // RVA: 0x7FFD54924FD0
        public void Compile(){} // RVA: 0x7FFD54925660
        public void DummyMethod(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD54925E80
        public void <GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0(){} // RVA: 0x7FFD54926240
        public void Initialize$BurstCompilerHelper_IsBurstEnabled_00000145$BurstDirectCall(){} // RVA: 0x7FFD549263F0
    }

    public class BurstCompilerOptions : Object
    {
        public bool IsGlobal;
        public bool EnableBurstCompilation; // 0x1
        public bool EnableBurstSafetyChecks; // 0x2
        public bool OptionsChanged; // 0x10
        public bool _enableBurstSafetyChecks; // 0x11
        public bool <IsGlobal>k__BackingField; // 0x12
        public System.Action <OptionsChanged>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54926F40
        public void get_IsGlobal(){} // RVA: 0x7FFD4EF01A90
        public void get_EnableBurstCompilation(){} // RVA: 0x7FFD4E40B5E0
        public void set_EnableBurstCompilation(){} // RVA: 0x7FFD549270A0
        public void set_EnableBurstSafetyChecks(){} // RVA: 0x7FFD549271D0
        public void get_OptionsChanged(){} // RVA: 0x7FFD4E3447C0
        public void TryGetAttribute(){} // RVA: 0x7FFD54927200
        public void GetBurstCompileAttribute(){} // RVA: 0x7FFD54927340
        public void HasBurstCompileAttribute(){} // RVA: 0x7FFD54927630
        public void OnOptionsChanged(){} // RVA: 0x7FFD4E6233B0
        public void MaybeTriggerRecompilation(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD549277B0
        public void CheckIsSecondaryUnityProcess(){} // RVA: 0x7FFD4E341320
    }

    public class BurstRuntime : Object
    {
        // ── Methods ──
        public void RuntimeLog(){} // RVA: 0x7FFD54927990
        public void PreventRequiredAttributeStrip(){} // RVA: 0x7FFD54927A10
        public void Log(){} // RVA: 0x7FFD54927BF0
    }

    public class BurstString : Object
    {
        public char[] SplitByColon;
        public byte[] logTable; // 0x8
        public uint[] g_PowerOf10_U32; // 0x10
        public byte[] InfinityString; // 0x18
        public byte[] NanString; // 0x20

        // ── Methods ──
        public void CopyFixedString(){} // RVA: 0x7FFD54927C70
        public void Format(){} // RVA: 0x7FFD549286E0 | overloaded x13
        public void ConvertUnsignedIntegerToString(){} // RVA: 0x7FFD549287B0
        public void GetLengthIntegerToString(){} // RVA: 0x7FFD54928960
        public void ConvertIntegerToString(){} // RVA: 0x7FFD54928990
        public void FormatNumber(){} // RVA: 0x7FFD54928B60
        public void FormatDecimalOrHexadecimal(){} // RVA: 0x7FFD54928F30
        public void ValueToIntegerChar(){} // RVA: 0x7FFD54928FE0
        public void AlignRight(){} // RVA: 0x7FFD54929010
        public void AlignLeft(){} // RVA: 0x7FFD549290B0
        public void GetLengthForFormatGeneral(){} // RVA: 0x7FFD549290F0
        public void FormatGeneral(){} // RVA: 0x7FFD54929230
        public void RoundNumber(){} // RVA: 0x7FFD549293D0
        public void ShouldRoundUp(){} // RVA: 0x7FFD549294F0
        public void LogBase2(){} // RVA: 0x7FFD54929520
        public void BigInt_Compare(){} // RVA: 0x7FFD54929690
        public void BigInt_Add(){} // RVA: 0x7FFD549296F0
        public void BigInt_Add_internal(){} // RVA: 0x7FFD54929780
        public void BigInt_Multiply(){} // RVA: 0x7FFD549299D0 | overloaded x2
        public void BigInt_Multiply_internal(){} // RVA: 0x7FFD549298E0
        public void BigInt_Multiply2(){} // RVA: 0x7FFD54929AB0 | overloaded x2
        public void BigInt_Multiply10(){} // RVA: 0x7FFD54929B00
        public void g_PowerOf10_Big(){} // RVA: 0x7FFD54929B40
        public void BigInt_Pow10(){} // RVA: 0x7FFD54929D10
        public void BigInt_MultiplyPow10(){} // RVA: 0x7FFD54929FE0
        public void BigInt_Pow2(){} // RVA: 0x7FFD5492A370
        public void BigInt_DivideWithRemainder_MaxQuotient9(){} // RVA: 0x7FFD5492A3D0
        public void BigInt_ShiftLeft(){} // RVA: 0x7FFD5492A5B0
        public void Dragon4(){} // RVA: 0x7FFD5492A750
        public void FormatInfinityNaN(){} // RVA: 0x7FFD5492BB80
        public void ConvertFloatToString(){} // RVA: 0x7FFD5492BD70
        public void ConvertDoubleToString(){} // RVA: 0x7FFD5492C010
        public void .cctor(){} // RVA: 0x7FFD5492C2D0
    }

    public class FunctionPointer`1 : ValueType
    {
        public UIntPtr Invoke;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090BF0
        public void get_Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SharedStatic : Object
    {
        // ── Methods ──
        public void GetOrCreateSharedStaticInternal(){} // RVA: 0x7FFD5492CB80
    }

    public class SharedStatic`1 : ValueType
    {
        public void* Data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_Data(){} // RVA: 0x7FFD4E078E90
        public void GetOrCreateUnsafe(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Unsafe : Object
    {
        // ── Methods ──
        public void AsRef(){} // RVA: 0x7FFD4E2ADC40
    }

}