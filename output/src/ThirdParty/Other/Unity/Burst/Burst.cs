// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst
// Classes: 11
// Methods: 86

namespace ThirdParty.Other.Unity.Burst
{
    public class BurstAuthorizedExternalMethodAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BurstCompileAttribute : Attribute
    {
        public 0x6B2C3478 FloatMode; // 0x10
        public 0x6B2C34D0 FloatPrecision; // 0x14
        public System.Nullable`1<bool> CompileSynchronously; // 0x18
        public string[] Options; // 0x20

        // ── Methods ──
        public void set_FloatMode(){} // RVA: 0x7FFAC2F240C0
        public void set_FloatPrecision(){} // RVA: 0x7FFAC33D4990
        public void set_CompileSynchronously(){} // RVA: 0x7FFAC9504D00
        public void set_Options(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC9504D50 | overloaded x2
    }

    public class BurstCompiler : Object
    {
        public bool IsEnabled;
        public Unity.Burst.BurstCompilerOptions Options; // 0x8
        public System.Action OnCompileILPPMethod2; // 0x10
        public System.Reflection.MethodInfo DummyMethodInfo; // 0x18

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFAC9504D60
        public void CompileILPPMethod2(){} // RVA: 0x7FFAC9504E00
        public void GetILPPMethodFunctionPointer2(){} // RVA: 0x7FFAC9504FD0
        public void Compile(){} // RVA: 0x7FFAC9505660
        public void DummyMethod(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9505E80
        public void <GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0(){} // RVA: 0x7FFAC9506240
        public void Initialize$BurstCompilerHelper_IsBurstEnabled_00000145$BurstDirectCall(){} // RVA: 0x7FFAC95063F0
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
        public void .ctor(){} // RVA: 0x7FFAC9506F40
        public void get_IsGlobal(){} // RVA: 0x7FFAC3AE1A90
        public void get_EnableBurstCompilation(){} // RVA: 0x7FFAC2FEB5E0
        public void set_EnableBurstCompilation(){} // RVA: 0x7FFAC95070A0
        public void set_EnableBurstSafetyChecks(){} // RVA: 0x7FFAC95071D0
        public void get_OptionsChanged(){} // RVA: 0x7FFAC2F247C0
        public void TryGetAttribute(){} // RVA: 0x7FFAC9507200
        public void GetBurstCompileAttribute(){} // RVA: 0x7FFAC9507340
        public void HasBurstCompileAttribute(){} // RVA: 0x7FFAC9507630
        public void OnOptionsChanged(){} // RVA: 0x7FFAC32033B0
        public void MaybeTriggerRecompilation(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC95077B0
        public void CheckIsSecondaryUnityProcess(){} // RVA: 0x7FFAC2F21320
    }

    public class BurstDiscardAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BurstRuntime : Object
    {
        // ── Methods ──
        public void RuntimeLog(){} // RVA: 0x7FFAC9507990
        public void PreventRequiredAttributeStrip(){} // RVA: 0x7FFAC9507A10
        public void Log(){} // RVA: 0x7FFAC9507BF0
    }

    public class BurstString : Object
    {
        public char[] SplitByColon;
        public byte[] logTable; // 0x8
        public uint[] g_PowerOf10_U32; // 0x10
        public byte[] InfinityString; // 0x18
        public byte[] NanString; // 0x20

        // ── Methods ──
        public void CopyFixedString(){} // RVA: 0x7FFAC9507C70
        public void Format(){} // RVA: 0x7FFAC95086E0 | overloaded x13
        public void ConvertUnsignedIntegerToString(){} // RVA: 0x7FFAC95087B0
        public void GetLengthIntegerToString(){} // RVA: 0x7FFAC9508960
        public void ConvertIntegerToString(){} // RVA: 0x7FFAC9508990
        public void FormatNumber(){} // RVA: 0x7FFAC9508B60
        public void FormatDecimalOrHexadecimal(){} // RVA: 0x7FFAC9508F30
        public void ValueToIntegerChar(){} // RVA: 0x7FFAC9508FE0
        public void AlignRight(){} // RVA: 0x7FFAC9509010
        public void AlignLeft(){} // RVA: 0x7FFAC95090B0
        public void GetLengthForFormatGeneral(){} // RVA: 0x7FFAC95090F0
        public void FormatGeneral(){} // RVA: 0x7FFAC9509230
        public void RoundNumber(){} // RVA: 0x7FFAC95093D0
        public void ShouldRoundUp(){} // RVA: 0x7FFAC95094F0
        public void LogBase2(){} // RVA: 0x7FFAC9509520
        public void BigInt_Compare(){} // RVA: 0x7FFAC9509690
        public void BigInt_Add(){} // RVA: 0x7FFAC95096F0
        public void BigInt_Add_internal(){} // RVA: 0x7FFAC9509780
        public void BigInt_Multiply(){} // RVA: 0x7FFAC95099D0 | overloaded x2
        public void BigInt_Multiply_internal(){} // RVA: 0x7FFAC95098E0
        public void BigInt_Multiply2(){} // RVA: 0x7FFAC9509AB0 | overloaded x2
        public void BigInt_Multiply10(){} // RVA: 0x7FFAC9509B00
        public void g_PowerOf10_Big(){} // RVA: 0x7FFAC9509B40
        public void BigInt_Pow10(){} // RVA: 0x7FFAC9509D10
        public void BigInt_MultiplyPow10(){} // RVA: 0x7FFAC9509FE0
        public void BigInt_Pow2(){} // RVA: 0x7FFAC950A370
        public void BigInt_DivideWithRemainder_MaxQuotient9(){} // RVA: 0x7FFAC950A3D0
        public void BigInt_ShiftLeft(){} // RVA: 0x7FFAC950A5B0
        public void Dragon4(){} // RVA: 0x7FFAC950A750
        public void FormatInfinityNaN(){} // RVA: 0x7FFAC950BB80
        public void ConvertFloatToString(){} // RVA: 0x7FFAC950BD70
        public void ConvertDoubleToString(){} // RVA: 0x7FFAC950C010
        public void .cctor(){} // RVA: 0x7FFAC950C2D0
    }

    public class FunctionPointer`1 : ValueType
    {
        public UIntPtr Invoke;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70BF0
        public void get_Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SharedStatic : Object
    {
        // ── Methods ──
        public void GetOrCreateSharedStaticInternal(){} // RVA: 0x7FFAC950CB80
    }

    public class SharedStatic`1 : ValueType
    {
        public void* Data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_Data(){} // RVA: 0x7FFAC2C58E90
        public void GetOrCreateUnsafe(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Unsafe : Object
    {
        // ── Methods ──
        public void AsRef(){} // RVA: 0x7FFAC2E8DC40
    }

}