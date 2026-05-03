// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 25
// Methods: 207

namespace ThirdParty.DotNet.System
{
    public class MarshalByRefObject : Object
    {
        public object _identity; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_ObjectIdentity(){} // RVA: 0x7FFE86A47180
        public void set_ObjectIdentity(){} // RVA: 0x7FFE86A471C0
        public void CreateObjRef(){} // RVA: 0x7FFE86A47200
        public void InitializeLifetimeService(){} // RVA: 0x7FFE86A47240
    }

    public class Marvin : Object
    {
        public ulong _defaultSeed;

        // ── Methods ──
        public void ComputeHash32(){} // RVA: 0x7FFE869DC900 | overloaded x2
        public void Block(){} // RVA: 0x7FFE869DCDF0
        public void _rotl(){} // RVA: 0x7FFE869D7C70
        public void get_DefaultSeed(){} // RVA: 0x7FFE869DCEA0
        public void GenerateSeed(){} // RVA: 0x7FFE869DCF00
        public void .cctor(){} // RVA: 0x7FFE869DCF10
    }

    public class Math : Object
    {
        // ── Methods ──
        public void Abs(){} // RVA: 0x7FFE869DE6E0 | overloaded x7
        public void ThrowAbsOverflow(){} // RVA: 0x7FFE869DD120
        public void BigMul(){} // RVA: 0x7FFE869DD170
        public void DivRem(){} // RVA: 0x7FFE869516E0 | overloaded x3
        public void Ceiling(){} // RVA: 0x7FFE869DE730 | overloaded x2
        public void Clamp(){} // RVA: 0x7FFE869DD3E0 | overloaded x3
        public void Floor(){} // RVA: 0x7FFE869DE770 | overloaded x2
        public void IEEERemainder(){} // RVA: 0x7FFE869DD560
        public void Log(){} // RVA: 0x7FFE869DE780 | overloaded x2
        public void Max(){} // RVA: 0x7FFE869DD990 | overloaded x11
        public void Min(){} // RVA: 0x7FFE869DDAE0 | overloaded x11
        public void Round(){} // RVA: 0x7FFE869DE030 | overloaded x8
        public void Sign(){} // RVA: 0x7FFE869DE4B0 | overloaded x7
        public void Truncate(){} // RVA: 0x7FFE869DE660 | overloaded x2
        public void ThrowMinMaxException(){} // RVA: 0x7FFE810A1420
        public void Acos(){} // RVA: 0x7FFE869DE6F0
        public void Asin(){} // RVA: 0x7FFE869DE700
        public void Atan(){} // RVA: 0x7FFE869DE710
        public void Atan2(){} // RVA: 0x7FFE869DE720
        public void Cos(){} // RVA: 0x7FFE869DE740
        public void Cosh(){} // RVA: 0x7FFE869DE750
        public void Exp(){} // RVA: 0x7FFE869DE760
        public void Log10(){} // RVA: 0x7FFE869DE790
        public void Pow(){} // RVA: 0x7FFE869DE7A0
        public void Sin(){} // RVA: 0x7FFE869DE970
        public void Sinh(){} // RVA: 0x7FFE869DE980
        public void Sqrt(){} // RVA: 0x7FFE869DE990
        public void Tan(){} // RVA: 0x7FFE869DE9B0
        public void Tanh(){} // RVA: 0x7FFE869DE9C0
        public void ModF(){} // RVA: 0x7FFE869DE9D0
        public void .cctor(){} // RVA: 0x7FFE869DE9E0
    }

    public class MathF : Object
    {
        // ── Methods ──
        public void Acos(){} // RVA: 0x7FFE869DEAE0
        public void Sin(){} // RVA: 0x7FFE869DEAF0
        public void Sqrt(){} // RVA: 0x7FFE869DEB00
        public void .cctor(){} // RVA: 0x7FFE869DEB20
    }

    public class MemberAccessException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class MemoryDebugView`1 : Object
    {
    }

    public class MemoryExtensions : Object
    {
        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void SequenceEqual(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void IndexOfAny(){} // RVA: 0x7FFE810A1420
        public void StartsWith(){} // RVA: 0x7FFE86E00F60 | overloaded x3
        public void EndsWith(){} // RVA: 0x7FFE86E00D70 | overloaded x3
        public void AsSpan(){} // RVA: 0x7FFE86E01130 | overloaded x4
        public void AsMemory(){} // RVA: 0x7FFE86E01320 | overloaded x5
        public void CopyTo(){} // RVA: 0x7FFE810A1420
        public void IsTypeComparableAsBytes(){} // RVA: 0x7FFE80E2F230
        public void EqualsOrdinalIgnoreCase(){} // RVA: 0x7FFE86E009B0
        public void CompareToOrdinalIgnoreCase(){} // RVA: 0x7FFE86E00A70
        public void MeasureStringAdjustment(){} // RVA: 0x7FFE86E01420
        public void .cctor(){} // RVA: 0x7FFE86E01460
    }

    public class MemoryExtensionsPolyfill : Object
    {
        // ── Methods ──
        public void Sort(){} // RVA: 0x7FFE810A1420 | overloaded x3
    }

    public class Memory`1 : ValueType
    {
        public object _object;
        public int _index;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4D070 | overloaded x4
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void Slice(){} // RVA: 0x7FFE810A1420
        public void get_Span(){} // RVA: 0x7FFE810A1420
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void Equals(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void CombineHashCodes(){} // RVA: 0x7FFE80E35210 | overloaded x2
    }

    public class MethodAccessException : MemberAccessException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class MissingFieldException : MissingMemberException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869E03B0 | overloaded x4
        public void get_Message(){} // RVA: 0x7FFE86A09B30
    }

    public class MissingMemberException : MemberAccessException
    {
        public string ClassName; // 0x90

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A09DE0 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFE86A0A110
        public void get_Message(){} // RVA: 0x7FFE86A0A560
        public void FormatSignature(){} // RVA: 0x7FFE86A0A6A0
    }

    public class MissingMethodException : MissingMemberException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869E03B0 | overloaded x4
        public void get_Message(){} // RVA: 0x7FFE869E03D0
    }

    public class ModifierSpec
    {
        // ── Methods ──
        public void Resolve(){} // RVA: 0x7FFE80E2E390
        public void Append(){} // RVA: 0x7FFE80E2E390
    }

    public class MonoAsyncCall : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MonoCustomAttrs : Object
    {
        // ── Methods ──
        public void IsUserCattrProvider(){} // RVA: 0x7FFE86A47280
        public void GetCustomAttributesInternal(){} // RVA: 0x7FFE86A47520
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFE86A47890 | overloaded x2
        public void GetCustomAttributesBase(){} // RVA: 0x7FFE86A47A10
        public void GetCustomAttributes(){} // RVA: 0x7FFE86A487E0 | overloaded x2
        public void GetCustomAttributesDataInternal(){} // RVA: 0x7FFE86A48980
        public void GetCustomAttributesData(){} // RVA: 0x7FFE86A48AE0 | overloaded x2
        public void GetCustomAttributesDataBase(){} // RVA: 0x7FFE86A497B0
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFE86A49D20 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFE86A49FD0
        public void IsDefinedInternal(){} // RVA: 0x7FFE86A4A230
        public void GetBasePropertyDefinition(){} // RVA: 0x7FFE86A4A260
        public void GetBaseEventDefinition(){} // RVA: 0x7FFE86A4A700
        public void GetBase(){} // RVA: 0x7FFE86A4A950
        public void RetrieveAttributeUsageNoCache(){} // RVA: 0x7FFE86A4AE40
        public void RetrieveAttributeUsage(){} // RVA: 0x7FFE86A4B100
        public void .cctor(){} // RVA: 0x7FFE86A4B370
    }

    public class MonoLimitationAttribute : MonoTODOAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class MonoListItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MonoTODOAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
    }

    public class MonoType : RuntimeType
    {
    }

    public class MonoTypeInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MonoUtil : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE870DE750
    }

    public class MulticastDelegate : Delegate
    {
        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFE86A457E0
        public void DynamicInvokeImpl(){} // RVA: 0x7FFE86A4B430
        public void Equals(){} // RVA: 0x7FFE86A4B4D0
        public void GetHashCode(){} // RVA: 0x7FFE86A45650
        public void GetMethodImpl(){} // RVA: 0x7FFE86A4B650
        public void GetInvocationList(){} // RVA: 0x7FFE86A4B7C0
        public void CombineImpl(){} // RVA: 0x7FFE86A4B8A0
        public void LastIndexOf(){} // RVA: 0x7FFE86A4BC40
        public void RemoveImpl(){} // RVA: 0x7FFE86A4BD80
    }

    public class MulticastNotSupportedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class MutableDecimal : ValueType
    {
        public uint Flags; // 0x10
        public uint High; // 0x14

        // ── Methods ──
        public void get_IsNegative(){} // RVA: 0x7FFE86A06A10
        public void set_IsNegative(){} // RVA: 0x7FFE86A06A20
        public void get_Scale(){} // RVA: 0x7FFE82BC9950
        public void set_Scale(){} // RVA: 0x7FFE86A06A40
    }

}