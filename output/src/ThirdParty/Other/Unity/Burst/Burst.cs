// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Burst
// Classes: 13
// Methods: 89

namespace ThirdParty.Other.Unity.Burst
{
    public class BurstAuthorizedExternalMethodAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BurstCompileAttribute : Attribute
    {
        // ── Methods ──
        public void set_FloatMode(){} // RVA: 0x7A80DA0C0
        public void set_FloatPrecision(){} // RVA: 0x7A8669360
        public void set_CompileSynchronously(){} // RVA: 0x7AEB5A4E0
        public void set_Options(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AEB5A530
        public void <FloatMode>k__BackingField(){} // RVA: 0x7B3F5C4D8
    }

    public class BurstCompileAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BurstCompiler : Object
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7AEB5A540
        public void CompileILPPMethod2(){} // RVA: 0x7AEB5A5E0
        public void GetILPPMethodFunctionPointer2(){} // RVA: 0x7AEB5A7B0
        public void Compile(){} // RVA: 0x7AEB5AE50
        public void DummyMethod(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AEB5B680
        public void <GetILPPMethodFunctionPointer2>g__GetManagedFallbackDelegate|17_0(){} // RVA: 0x7AEB5BA40
        public void Initialize$BurstCompilerHelper_IsBurstEnabled_00000145$BurstDirectCall(){} // RVA: 0x7AEB5BBF0
    }

    public class BurstCompilerOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEB5C750
        public void get_IsGlobal(){} // RVA: 0x7A9716B70
        public void get_EnableBurstCompilation(){} // RVA: 0x7A81A2200
        public void set_EnableBurstCompilation(){} // RVA: 0x7AEB5C8B0
        public void set_EnableBurstSafetyChecks(){} // RVA: 0x7AEB5C9E0
        public void get_OptionsChanged(){} // RVA: 0x7A80DA7B0
        public void TryGetAttribute(){} // RVA: 0x7AEB5CA10
        public void GetBurstCompileAttribute(){} // RVA: 0x7AEB5CB50
        public void HasBurstCompileAttribute(){} // RVA: 0x7AEB5CE40
        public void OnOptionsChanged(){} // RVA: 0x7A8447B80
        public void MaybeTriggerRecompilation(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AEB5CFD0
        public void CheckIsSecondaryUnityProcess(){} // RVA: 0x7A80D7320
        public void ForceDisableBurstCompilation(){} // RVA: 0x7B41AC978
    }

    public class BurstDiscardAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BurstRuntime : Object
    {
        // ── Methods ──
        public void RuntimeLog(){} // RVA: 0x7AEB5D1B0
        public void PreventRequiredAttributeStrip(){} // RVA: 0x7AEB5D230
        public void Log(){} // RVA: 0x7AEB5D410
    }

    public class BurstString : Object
    {
        // ── Methods ──
        public void CopyFixedString(){} // RVA: 0x7AEB5D490
        public void Format(){} // RVA: 0x7AEB5DF00
        public void ConvertUnsignedIntegerToString(){} // RVA: 0x7AEB5DFD0
        public void GetLengthIntegerToString(){} // RVA: 0x7AEB5E190
        public void ConvertIntegerToString(){} // RVA: 0x7AEB5E1C0
        public void FormatNumber(){} // RVA: 0x7AEB5E380
        public void FormatDecimalOrHexadecimal(){} // RVA: 0x7AEB5E740
        public void ValueToIntegerChar(){} // RVA: 0x7AEB5E7F0
        public void AlignRight(){} // RVA: 0x7AEB5E820
        public void AlignLeft(){} // RVA: 0x7AEB5E8C0
        public void GetLengthForFormatGeneral(){} // RVA: 0x7AEB5E900
        public void FormatGeneral(){} // RVA: 0x7AEB5EA40
        public void RoundNumber(){} // RVA: 0x7AEB5EBE0
        public void ShouldRoundUp(){} // RVA: 0x7AEB5ED00
        public void LogBase2(){} // RVA: 0x7AEB5ED30
        public void BigInt_Compare(){} // RVA: 0x7AEB5EEA0
        public void BigInt_Add(){} // RVA: 0x7AEB5EF00
        public void BigInt_Add_internal(){} // RVA: 0x7AEB5EF90
        public void BigInt_Multiply(){} // RVA: 0x7AEB5F1F0
        public void BigInt_Multiply_internal(){} // RVA: 0x7AEB5F0F0
        public void BigInt_Multiply2(){} // RVA: 0x7AEB5F2E0
        public void BigInt_Multiply10(){} // RVA: 0x7AEB5F330
        public void g_PowerOf10_Big(){} // RVA: 0x7AEB5F370
        public void BigInt_Pow10(){} // RVA: 0x7AEB5F540
        public void BigInt_MultiplyPow10(){} // RVA: 0x7AEB5F7B0
        public void BigInt_Pow2(){} // RVA: 0x7AEB5FAD0
        public void BigInt_DivideWithRemainder_MaxQuotient9(){} // RVA: 0x7AEB5FB30
        public void BigInt_ShiftLeft(){} // RVA: 0x7AEB5FD10
        public void Dragon4(){} // RVA: 0x7AEB5FEB0
        public void FormatInfinityNaN(){} // RVA: 0x7AEB61200
        public void ConvertFloatToString(){} // RVA: 0x7AEB613F0
        public void ConvertDoubleToString(){} // RVA: 0x7AEB61690
        public void .cctor(){} // RVA: 0x7AEB61950
    }

    public class FunctionPointer`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E188D0
        public void get_Invoke(){} // RVA: 0x7A8051B10
    }

    public class FunctionPointer`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A767FEF0
    }

    public class SharedStatic : Object
    {
        // ── Methods ──
        public void GetOrCreateSharedStaticInternal(){} // RVA: 0x7AEB62200
    }

    public class SharedStatic`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void get_Data(){} // RVA: 0x7A7E00680
        public void GetOrCreateUnsafe(){} // RVA: 0x7A8051B10
    }

    public class Unsafe : Object
    {
        // ── Methods ──
        public void AsRef(){} // RVA: 0x7A8051B10
    }

}