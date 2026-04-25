// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 25
// Methods: 206

namespace ThirdParty.DotNet.System
{
    public class MarshalByRefObject : Object
    {
        public object ObjectIdentity; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_ObjectIdentity(){} // RVA: 0x7FFAC869D970
        public void set_ObjectIdentity(){} // RVA: 0x7FFAC869D9B0
        public void CreateObjRef(){} // RVA: 0x7FFAC869D9F0
        public void InitializeLifetimeService(){} // RVA: 0x7FFAC869DA30
    }

    public class Marvin : Object
    {
        public ulong DefaultSeed;

        // ── Methods ──
        public void ComputeHash32(){} // RVA: 0x7FFAC8633130 | overloaded x2
        public void Block(){} // RVA: 0x7FFAC8633620
        public void _rotl(){} // RVA: 0x7FFAC862E4A0
        public void get_DefaultSeed(){} // RVA: 0x7FFAC86336D0
        public void GenerateSeed(){} // RVA: 0x7FFAC8633730
        public void .cctor(){} // RVA: 0x7FFAC8633740
    }

    public class Math : Object
    {
        public double doubleRoundLimit;
        public double[] roundPower10Double; // 0x8

        // ── Methods ──
        public void Abs(){} // RVA: 0x7FFAC8634F10 | overloaded x7
        public void ThrowAbsOverflow(){} // RVA: 0x7FFAC8633950
        public void BigMul(){} // RVA: 0x7FFAC86339A0
        public void DivRem(){} // RVA: 0x7FFAC85A7F10 | overloaded x3
        public void Ceiling(){} // RVA: 0x7FFAC8634F60 | overloaded x2
        public void Clamp(){} // RVA: 0x7FFAC8633C10 | overloaded x3
        public void Floor(){} // RVA: 0x7FFAC8634FA0 | overloaded x2
        public void IEEERemainder(){} // RVA: 0x7FFAC8633D90
        public void Log(){} // RVA: 0x7FFAC8634FB0 | overloaded x2
        public void Max(){} // RVA: 0x7FFAC86341C0 | overloaded x11
        public void Min(){} // RVA: 0x7FFAC8634310 | overloaded x11
        public void Round(){} // RVA: 0x7FFAC8634860 | overloaded x8
        public void Sign(){} // RVA: 0x7FFAC8634CE0 | overloaded x7
        public void Truncate(){} // RVA: 0x7FFAC8634E90 | overloaded x2
        public void ThrowMinMaxException(){} // RVA: 0x7FFAC2E8DC40
        public void Acos(){} // RVA: 0x7FFAC8634F20
        public void Asin(){} // RVA: 0x7FFAC8634F30
        public void Atan(){} // RVA: 0x7FFAC8634F40
        public void Atan2(){} // RVA: 0x7FFAC8634F50
        public void Cos(){} // RVA: 0x7FFAC8634F70
        public void Cosh(){} // RVA: 0x7FFAC8634F80
        public void Exp(){} // RVA: 0x7FFAC8634F90
        public void Log10(){} // RVA: 0x7FFAC8634FC0
        public void Pow(){} // RVA: 0x7FFAC8634FD0
        public void Sin(){} // RVA: 0x7FFAC86351A0
        public void Sinh(){} // RVA: 0x7FFAC86351B0
        public void Sqrt(){} // RVA: 0x7FFAC86351C0
        public void Tan(){} // RVA: 0x7FFAC86351E0
        public void Tanh(){} // RVA: 0x7FFAC86351F0
        public void ModF(){} // RVA: 0x7FFAC8635200
        public void .cctor(){} // RVA: 0x7FFAC8635210
    }

    public class MathF : Object
    {
        public float[] roundPower10Single;
        public float singleRoundLimit; // 0x8

        // ── Methods ──
        public void Acos(){} // RVA: 0x7FFAC8635310
        public void Sin(){} // RVA: 0x7FFAC8635320
        public void .cctor(){} // RVA: 0x7FFAC8635330
    }

    public class MemberAccessException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class MemoryDebugView`1 : Object
    {
    }

    public class MemoryExtensions : Object
    {
        public UIntPtr StringAdjustment;

        // ── Methods ──
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void SequenceEqual(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void IndexOfAny(){} // RVA: 0x7FFAC2E8DC40
        public void StartsWith(){} // RVA: 0x7FFAC8A578D0 | overloaded x3
        public void EndsWith(){} // RVA: 0x7FFAC8A576E0 | overloaded x3
        public void AsSpan(){} // RVA: 0x7FFAC8A57AA0 | overloaded x4
        public void AsMemory(){} // RVA: 0x7FFAC8A57C90 | overloaded x5
        public void CopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void IsTypeComparableAsBytes(){} // RVA: 0x7FFAC2C59DE0
        public void EqualsOrdinalIgnoreCase(){} // RVA: 0x7FFAC8A57320
        public void CompareToOrdinalIgnoreCase(){} // RVA: 0x7FFAC8A573E0
        public void MeasureStringAdjustment(){} // RVA: 0x7FFAC8A57D90
        public void .cctor(){} // RVA: 0x7FFAC8A57DD0
    }

    public class MemoryExtensionsPolyfill : Object
    {
        // ── Methods ──
        public void Sort(){} // RVA: 0x7FFAC2E8DC40 | overloaded x3
    }

    public class Memory`1 : ValueType
    {
        public object Length;
        public int Span;
        public int _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C77970 | overloaded x4
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void Slice(){} // RVA: 0x7FFAC2E8DC40
        public void get_Span(){} // RVA: 0x7FFAC2E8DC40
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void Equals(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void CombineHashCodes(){} // RVA: 0x7FFAC2C5FDC0 | overloaded x2
    }

    public class MethodAccessException : MemberAccessException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class MissingFieldException : MissingMemberException
    {
        public object Message;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8636BC0 | overloaded x4
        public void get_Message(){} // RVA: 0x7FFAC8660340
    }

    public class MissingMemberException : MemberAccessException
    {
        public string Message; // 0x90
        public string MemberName; // 0x98
        public byte[] Signature; // 0xA0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86605F0 | overloaded x4
        public void GetObjectData(){} // RVA: 0x7FFAC8660920
        public void get_Message(){} // RVA: 0x7FFAC8660D70
        public void FormatSignature(){} // RVA: 0x7FFAC8660EB0
    }

    public class MissingMethodException : MissingMemberException
    {
        public object Message;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8636BC0 | overloaded x4
        public void get_Message(){} // RVA: 0x7FFAC8636BE0
    }

    public class ModifierSpec
    {
        // ── Methods ──
        public void Resolve(){} // RVA: 0x7FFAC2C58F40
        public void Append(){} // RVA: 0x7FFAC2C58F40
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
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MonoCustomAttrs : Object
    {
        public System.Reflection.Assembly corlib;
        public System.Collections.Generic.Dictionary`2<System.Type,System.AttributeUsageAttribute> usage_cache; // 0xFFFF
        public System.AttributeUsageAttribute DefaultAttributeUsage; // 0x8

        // ── Methods ──
        public void IsUserCattrProvider(){} // RVA: 0x7FFAC869DA70
        public void GetCustomAttributesInternal(){} // RVA: 0x7FFAC869DD10
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFAC869E090 | overloaded x2
        public void GetCustomAttributesBase(){} // RVA: 0x7FFAC869E210
        public void GetCustomAttributes(){} // RVA: 0x7FFAC869EFF0 | overloaded x2
        public void GetCustomAttributesDataInternal(){} // RVA: 0x7FFAC869F190
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC869F2F0 | overloaded x2
        public void GetCustomAttributesDataBase(){} // RVA: 0x7FFAC869FFC0
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFAC86A0530 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFAC86A07E0
        public void IsDefinedInternal(){} // RVA: 0x7FFAC86A0A60
        public void GetBasePropertyDefinition(){} // RVA: 0x7FFAC86A0AB0
        public void GetBaseEventDefinition(){} // RVA: 0x7FFAC86A0F50
        public void GetBase(){} // RVA: 0x7FFAC86A11A0
        public void RetrieveAttributeUsageNoCache(){} // RVA: 0x7FFAC86A1690
        public void RetrieveAttributeUsage(){} // RVA: 0x7FFAC86A1950
        public void .cctor(){} // RVA: 0x7FFAC86A1BC0
    }

    public class MonoLimitationAttribute : MonoTODOAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class MonoListItem : Object
    {
        public System.MonoListItem next; // 0x10
        public object data; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MonoTODOAttribute : Attribute
    {
        public string comment; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
    }

    public class MonoType : RuntimeType
    {
    }

    public class MonoTypeInfo : Object
    {
        public string full_name; // 0x10
        public System.Reflection.RuntimeConstructorInfo default_ctor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class MonoUtil : Object
    {
        public bool IsUnix;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8D36260
    }

    public class MulticastDelegate : Delegate
    {
        public System.Delegate[] delegates; // 0x78

        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x7FFAC869C000
        public void DynamicInvokeImpl(){} // RVA: 0x7FFAC86A1C80
        public void Equals(){} // RVA: 0x7FFAC86A1D20
        public void GetHashCode(){} // RVA: 0x7FFAC869BE70
        public void GetMethodImpl(){} // RVA: 0x7FFAC86A1EA0
        public void GetInvocationList(){} // RVA: 0x7FFAC86A2010
        public void CombineImpl(){} // RVA: 0x7FFAC86A20F0
        public void LastIndexOf(){} // RVA: 0x7FFAC86A2490
        public void RemoveImpl(){} // RVA: 0x7FFAC86A25D0
    }

    public class MulticastNotSupportedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class MutableDecimal : ValueType
    {
        public uint IsNegative; // 0x10
        public uint Scale; // 0x14
        public uint Low; // 0x18
        public uint Mid; // 0x1C

        // ── Methods ──
        public void get_IsNegative(){} // RVA: 0x7FFAC865D220
        public void set_IsNegative(){} // RVA: 0x7FFAC865D230
        public void get_Scale(){} // RVA: 0x7FFAC495DE20
        public void set_Scale(){} // RVA: 0x7FFAC865D250
    }

}