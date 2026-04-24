// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 11
// Methods: 166

namespace ThirdParty.DotNet.System
{
    public class MarshalByRefObject : Object
    {
        public object ObjectIdentity; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_ObjectIdentity(){} // RVA: 0x7FFD53ABD970
        public void set_ObjectIdentity(){} // RVA: 0x7FFD53ABD9B0
        public void CreateObjRef(){} // RVA: 0x7FFD53ABD9F0
        public void InitializeLifetimeService(){} // RVA: 0x7FFD53ABDA30
    }

    public class Marvin : Object
    {
        public ulong DefaultSeed;

        // ── Methods ──
        public void ComputeHash32(){} // RVA: 0x7FFD53A53130 | overloaded x2
        public void Block(){} // RVA: 0x7FFD53A53620
        public void _rotl(){} // RVA: 0x7FFD53A4E4A0
        public void get_DefaultSeed(){} // RVA: 0x7FFD53A536D0
        public void GenerateSeed(){} // RVA: 0x7FFD53A53730
        public void .cctor(){} // RVA: 0x7FFD53A53740
    }

    public class Math : Object
    {
        public double doubleRoundLimit;
        public double[] roundPower10Double; // 0x8

        // ── Methods ──
        public void Abs(){} // RVA: 0x7FFD53A54F10 | overloaded x7
        public void ThrowAbsOverflow(){} // RVA: 0x7FFD53A53950
        public void BigMul(){} // RVA: 0x7FFD53A539A0
        public void DivRem(){} // RVA: 0x7FFD539C7F10 | overloaded x3
        public void Ceiling(){} // RVA: 0x7FFD53A54F60 | overloaded x2
        public void Clamp(){} // RVA: 0x7FFD53A53C10 | overloaded x3
        public void Floor(){} // RVA: 0x7FFD53A54FA0 | overloaded x2
        public void IEEERemainder(){} // RVA: 0x7FFD53A53D90
        public void Log(){} // RVA: 0x7FFD53A54FB0 | overloaded x2
        public void Max(){} // RVA: 0x7FFD53A541C0 | overloaded x11
        public void Min(){} // RVA: 0x7FFD53A54310 | overloaded x11
        public void Round(){} // RVA: 0x7FFD53A54860 | overloaded x8
        public void Sign(){} // RVA: 0x7FFD53A54CE0 | overloaded x7
        public void Truncate(){} // RVA: 0x7FFD53A54E90 | overloaded x2
        public void ThrowMinMaxException(){} // RVA: 0x7FFD4E2ADC40
        public void Acos(){} // RVA: 0x7FFD53A54F20
        public void Asin(){} // RVA: 0x7FFD53A54F30
        public void Atan(){} // RVA: 0x7FFD53A54F40
        public void Atan2(){} // RVA: 0x7FFD53A54F50
        public void Cos(){} // RVA: 0x7FFD53A54F70
        public void Cosh(){} // RVA: 0x7FFD53A54F80
        public void Exp(){} // RVA: 0x7FFD53A54F90
        public void Log10(){} // RVA: 0x7FFD53A54FC0
        public void Pow(){} // RVA: 0x7FFD53A54FD0
        public void Sin(){} // RVA: 0x7FFD53A551A0
        public void Sinh(){} // RVA: 0x7FFD53A551B0
        public void Sqrt(){} // RVA: 0x7FFD53A551C0
        public void Tan(){} // RVA: 0x7FFD53A551E0
        public void Tanh(){} // RVA: 0x7FFD53A551F0
        public void ModF(){} // RVA: 0x7FFD53A55200
        public void .cctor(){} // RVA: 0x7FFD53A55210
    }

    public class MemoryExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void SequenceEqual(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void IndexOfAny(){} // RVA: 0x7FFD4E2ADC40
        public void StartsWith(){} // RVA: 0x7FFD53E778D0 | overloaded x3
        public void EndsWith(){} // RVA: 0x7FFD53E776E0 | overloaded x3
        public void AsSpan(){} // RVA: 0x7FFD53E77AA0 | overloaded x4
        public void AsMemory(){} // RVA: 0x7FFD53E77C90 | overloaded x5
        public void CopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void IsTypeComparableAsBytes(){} // RVA: 0x7FFD4E079DE0
        public void EqualsOrdinalIgnoreCase(){} // RVA: 0x7FFD53E77320
        public void CompareToOrdinalIgnoreCase(){} // RVA: 0x7FFD53E773E0
        public void MeasureStringAdjustment(){} // RVA: 0x7FFD53E77D90
        public void .cctor(){} // RVA: 0x7FFD53E77DD0
    }

    public class MemoryExtensionsPolyfill : Object
    {
        // ── Methods ──
        public void Sort(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
    }

    public class Memory`1 : ValueType
    {
        public object Length; // 0x10
        public int Span; // 0x18
        public int _length; // 0x1C
        public int RemoveFlagsBitMask;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970 | overloaded x4
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void Slice(){} // RVA: 0x7FFD4E2ADC40
        public void get_Span(){} // RVA: 0x7FFD4E2ADC40
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void Equals(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CombineHashCodes(){} // RVA: 0x7FFD4E07FDC0 | overloaded x2
    }

    public class MonoAsyncCall : Object
    {
        public object msg; // 0x10
        public UIntPtr cb_method; // 0x18
        public object cb_target; // 0x20
        public object state; // 0x28
        public object res; // 0x30
        public object out_args; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MonoCustomAttrs : Object
    {
        public System.Reflection.Assembly corlib;
        public System.Collections.Generic.Dictionary`2<System.Type,System.AttributeUsageAttribute> usage_cache; // 0xFFFF
        public System.AttributeUsageAttribute DefaultAttributeUsage; // 0x8

        // ── Methods ──
        public void IsUserCattrProvider(){} // RVA: 0x7FFD53ABDA70
        public void GetCustomAttributesInternal(){} // RVA: 0x7FFD53ABDD10
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFD53ABE090 | overloaded x2
        public void GetCustomAttributesBase(){} // RVA: 0x7FFD53ABE210
        public void GetCustomAttributes(){} // RVA: 0x7FFD53ABEFF0 | overloaded x2
        public void GetCustomAttributesDataInternal(){} // RVA: 0x7FFD53ABF190
        public void GetCustomAttributesData(){} // RVA: 0x7FFD53ABF2F0 | overloaded x2
        public void GetCustomAttributesDataBase(){} // RVA: 0x7FFD53ABFFC0
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFD53AC0530 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFD53AC07E0
        public void IsDefinedInternal(){} // RVA: 0x7FFD53AC0A60
        public void GetBasePropertyDefinition(){} // RVA: 0x7FFD53AC0AB0
        public void GetBaseEventDefinition(){} // RVA: 0x7FFD53AC0F50
        public void GetBase(){} // RVA: 0x7FFD53AC11A0
        public void RetrieveAttributeUsageNoCache(){} // RVA: 0x7FFD53AC1690
        public void RetrieveAttributeUsage(){} // RVA: 0x7FFD53AC1950
        public void .cctor(){} // RVA: 0x7FFD53AC1BC0
    }

    public class MonoType : RuntimeType
    {
    }

    public class MonoTypeInfo : Object
    {
        public string full_name; // 0x10
        public System.Reflection.RuntimeConstructorInfo default_ctor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class MulticastDelegate : Delegate
    {
        public System.Delegate[] delegates; // 0x78

        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFD53ABC000
        public void DynamicInvokeImpl(){} // RVA: 0x7FFD53AC1C80
        public void Equals(){} // RVA: 0x7FFD53AC1D20
        public void GetHashCode(){} // RVA: 0x7FFD53ABBE70
        public void GetMethodImpl(){} // RVA: 0x7FFD53AC1EA0
        public void GetInvocationList(){} // RVA: 0x7FFD53AC2010
        public void CombineImpl(){} // RVA: 0x7FFD53AC20F0
        public void LastIndexOf(){} // RVA: 0x7FFD53AC2490
        public void RemoveImpl(){} // RVA: 0x7FFD53AC25D0
    }

}