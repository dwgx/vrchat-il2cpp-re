// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 31
// Methods: 207

namespace ThirdParty.DotNet.System
{
    public class MarshalByRefObject : Object
    {
        public object _identity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_ObjectIdentity(){} // RVA: 0x697DD10
        public void set_ObjectIdentity(){} // RVA: 0x697DD50
        public void CreateObjRef(){} // RVA: 0x697DD90
        public void InitializeLifetimeService(){} // RVA: 0x697DDD0
    }

    public class Marvin : Object
    {
        public object _defaultSeed;

        // ── Methods ──
        public void ComputeHash32(){} // RVA: 0x6914FF0
        public void Block(){} // RVA: 0x69154E0
        public void _rotl(){} // RVA: 0x69104D0
        public void get_DefaultSeed(){} // RVA: 0x6915590
        public void GenerateSeed(){} // RVA: 0x69155F0
        public void .cctor(){} // RVA: 0x6915600
    }

    public class Math : Object
    {
        public object doubleRoundLimit;
        public object roundPower10Double;

        // ── Methods ──
        public void Abs(){} // RVA: 0x6916DD0
        public void ThrowAbsOverflow(){} // RVA: 0x6915810
        public void BigMul(){} // RVA: 0x6915860
        public void DivRem(){} // RVA: 0x688A160
        public void Ceiling(){} // RVA: 0x6916E20
        public void Clamp(){} // RVA: 0x6915AD0
        public void Floor(){} // RVA: 0x6916E60
        public void IEEERemainder(){} // RVA: 0x6915C50
        public void Log(){} // RVA: 0x6916E70
        public void Max(){} // RVA: 0x6916080
        public void Min(){} // RVA: 0x69161D0
        public void Round(){} // RVA: 0x6916720
        public void Sign(){} // RVA: 0x6916BA0
        public void Truncate(){} // RVA: 0x6916D50
        public void ThrowMinMaxException(){} // RVA: 0x3155280
        public void Acos(){} // RVA: 0x6916DE0
        public void Asin(){} // RVA: 0x6916DF0
        public void Atan(){} // RVA: 0x6916E00
        public void Atan2(){} // RVA: 0x6916E10
        public void Cos(){} // RVA: 0x6916E30
        public void Cosh(){} // RVA: 0x6916E40
        public void Exp(){} // RVA: 0x6916E50
        public void Log10(){} // RVA: 0x6916E80
        public void Pow(){} // RVA: 0x6916E90
        public void Sin(){} // RVA: 0x6917060
        public void Sinh(){} // RVA: 0x6917070
        public void Sqrt(){} // RVA: 0x6917080
        public void Tan(){} // RVA: 0x69170A0
        public void Tanh(){} // RVA: 0x69170B0
        public void ModF(){} // RVA: 0x69170C0
        public void .cctor(){} // RVA: 0x69170D0
    }

    public class MathF : Object
    {
        public object roundPower10Single;
        public object singleRoundLimit;

        // ── Methods ──
        public void Acos(){} // RVA: 0x69171D0
        public void Atan2(){} // RVA: 0x69171E0
        public void Cos(){} // RVA: 0x69171F0
        public void Sin(){} // RVA: 0x6917200
        public void Sqrt(){} // RVA: 0x6917210
        public void .cctor(){} // RVA: 0x6917230
    }

    public class MemberAccessException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class MemoryExtensions : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x6917390
        public void EqualsOrdinal(){} // RVA: 0x6917610
        public void EqualsOrdinalIgnoreCase(){} // RVA: 0x6917730
        public void Contains(){} // RVA: 0x69177E0
        public void ToUpperInvariant(){} // RVA: 0x6917860
        public void EndsWith(){} // RVA: 0x315B760
        public void StartsWith(){} // RVA: 0x31603B0
        public void AsSpan(){} // RVA: 0x315B3B0
        public void AsMemory(){} // RVA: 0x315A350
        public void Trim(){} // RVA: 0x6918490
        public void TrimStart(){} // RVA: 0x6918640
        public void TrimEnd(){} // RVA: 0x6918770
        public void IndexOf(){} // RVA: 0x315D2A0
        public void SequenceEqual(){} // RVA: 0x315FD60
        public void LastIndexOf(){} // RVA: 0xA94080
        public void IndexOfAny(){} // RVA: 0x315E170
        public void SequenceCompareTo(){} // RVA: 0xA94080
        public void Reverse(){} // RVA: 0x315F180
        public void CopyTo(){} // RVA: 0x315B5D0
        public void IsTypeComparableAsBytes(){} // RVA: 0x315CEE0
    }

    public class MemoryExtensions : Object
    {
        public object StringAdjustment;

        // ── Methods ──
        public void IndexOf(){} // RVA: 0xA94080
        public void SequenceEqual(){} // RVA: 0xA94080
        public void IndexOfAny(){} // RVA: 0xA94080
        public void StartsWith(){} // RVA: 0x6D2D5E0
        public void EndsWith(){} // RVA: 0x6D2D3F0
        public void AsSpan(){} // RVA: 0x6D2D7B0
        public void AsMemory(){} // RVA: 0x6D2D9A0
        public void CopyTo(){} // RVA: 0xA94080
        public void IsTypeComparableAsBytes(){} // RVA: 0x87D390
        public void EqualsOrdinalIgnoreCase(){} // RVA: 0x6D2D030
        public void CompareToOrdinalIgnoreCase(){} // RVA: 0x6D2D0F0
        public void MeasureStringAdjustment(){} // RVA: 0x6D2DAA0
        public void .cctor(){} // RVA: 0x6D2DAE0
    }

    public class MemoryExtensionsPolyfill : Object
    {
        // ── Methods ──
        public void Sort(){} // RVA: 0xA94080
    }

    public class Memory`1 : ValueType
    {
        public object _object;
        public object _index;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x89B9B0
        public void op_Implicit(){} // RVA: 0xA94080
        public void get_Empty(){} // RVA: 0xA94080
        public void get_Length(){} // RVA: 0x87C130
        public void ToString(){} // RVA: 0x87C0A0
        public void Slice(){} // RVA: 0xA94080
        public void get_Span(){} // RVA: 0xA94080
        public void Pin(){} // RVA: 0xA94080
        public void ToArray(){} // RVA: 0x87C0A0
        public void Equals(){} // RVA: 0xA94080
        public void GetHashCode(){} // RVA: 0x87C130
        public void CombineHashCodes(){} // RVA: 0x8833F0
    }

    public class Memory`1 : ValueType
    {
        public object _object;
        public object _index;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x469D060
        public void .ctor(){} // RVA: 0x426050
        public void get_Empty(){} // RVA: 0x1DF4930
        public void get_Length(){} // RVA: 0x4260C0
        public void ToString(){} // RVA: 0x42B680
        public void Slice(){} // RVA: 0x4261D0
        public void get_Span(){} // RVA: 0x42B690
        public void Pin(){} // RVA: 0x42B6C0
        public void ToArray(){} // RVA: 0x42B700
        public void Equals(){} // RVA: 0x426360
        public void GetHashCode(){} // RVA: 0x42B710
        public void CombineHashCodes(){} // RVA: 0x469E1E0
    }

    public class Memory`1 : ValueType
    {
        public object _object;
        public object _index;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0x469D060
        public void get_Span(){} // RVA: 0x42B790
        public void .ctor(){} // RVA: 0x426050
        public void get_Empty(){} // RVA: 0x1DF4930
        public void get_Length(){} // RVA: 0x4260C0
        public void ToString(){} // RVA: 0x42B780
        public void Slice(){} // RVA: 0x4261D0
        public void Pin(){} // RVA: 0x42B7C0
        public void ToArray(){} // RVA: 0x42B800
        public void Equals(){} // RVA: 0x426360
        public void GetHashCode(){} // RVA: 0x426390
        public void CombineHashCodes(){} // RVA: 0x469E1E0
    }

    public class Memory`1 : ValueType
    {
        public object _object;
        public object _index;
        public object _length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x89B9B0
        public void op_Implicit(){} // RVA: 0xA94080
        public void get_Length(){} // RVA: 0x87C130
        public void ToString(){} // RVA: 0x87C0A0
        public void Slice(){} // RVA: 0xA94080
        public void get_Span(){} // RVA: 0xA94080
        public void ToArray(){} // RVA: 0x87C0A0
        public void Equals(){} // RVA: 0xA94080
        public void GetHashCode(){} // RVA: 0x87C130
        public void CombineHashCodes(){} // RVA: 0x8833F0
    }

    public class Memory`1 : ValueType
    {
        public object _object;
        public object _index;
        public object _length;

        // ── Methods ──
        public void op_Implicit(){} // RVA: 0xFE9840
        public void Slice(){} // RVA: 0x42B450
        public void .ctor(){} // RVA: 0x426050
        public void get_Length(){} // RVA: 0x4260C0
        public void ToString(){} // RVA: 0x42B440
        public void get_Span(){} // RVA: 0x42B550
        public void ToArray(){} // RVA: 0x42B590
        public void Equals(){} // RVA: 0x426360
        public void GetHashCode(){} // RVA: 0x42B5B0
        public void CombineHashCodes(){} // RVA: 0x469E1E0
    }

    public class MethodAccessException : MemberAccessException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class MissingFieldException : MissingMemberException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6918A80
        public void get_Message(){} // RVA: 0x69414F0
    }

    public class MissingMemberException : MemberAccessException
    {
        public object ClassName;
        public object MemberName;
        public object Signature;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6941780
        public void GetObjectData(){} // RVA: 0x6941A80
        public void get_Message(){} // RVA: 0x6941E50
        public void FormatSignature(){} // RVA: 0x1584680
    }

    public class MissingMethodException : MissingMemberException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6918A80
        public void get_Message(){} // RVA: 0x6918AA0
    }

    public class ModifierSpec
    {
        // ── Methods ──
        public void Resolve(){} // RVA: 0x87C540
        public void Append(){} // RVA: 0x87C540
    }

    public class MonoAsyncCall : Object
    {
        public object msg;
        public object cb_method;
        public object cb_target;
        public object state;
        public object res;
        public object out_args;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MonoCustomAttrs : Object
    {
        public object corlib;
        public object usage_cache;
        public object DefaultAttributeUsage;

        // ── Methods ──
        public void IsUserCattrProvider(){} // RVA: 0x697DE10
        public void GetCustomAttributesInternal(){} // RVA: 0x697E060
        public void GetPseudoCustomAttributes(){} // RVA: 0x697E4D0
        public void GetCustomAttributesBase(){} // RVA: 0x697E650
        public void GetCustomAttributes(){} // RVA: 0x697F440
        public void GetCustomAttributesDataInternal(){} // RVA: 0x697F610
        public void GetCustomAttributesData(){} // RVA: 0x697F780
        public void GetCustomAttributesDataBase(){} // RVA: 0x6980470
        public void GetPseudoCustomAttributesData(){} // RVA: 0x6980980
        public void IsDefined(){} // RVA: 0x6980C70
        public void IsDefinedInternal(){} // RVA: 0x6980ED0
        public void GetBasePropertyDefinition(){} // RVA: 0x6980F00
        public void GetBaseEventDefinition(){} // RVA: 0x6981380
        public void GetBase(){} // RVA: 0x69815D0
        public void RetrieveAttributeUsageNoCache(){} // RVA: 0x6981AA0
        public void RetrieveAttributeUsage(){} // RVA: 0x6981D50
        public void .cctor(){} // RVA: 0x6981FC0
    }

    public class MonoLimitationAttribute : MonoTODOAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class MonoListItem : Object
    {
        public object next;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MonoTODOAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MonoTODOAttribute : Attribute
    {
        public object comment;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class MonoTypeInfo : Object
    {
        public object full_name;
        public object default_ctor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class MonoType[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class MonoUtil : Object
    {
        public object IsUnix;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x700D420
    }

    public class MulticastDelegate : Delegate
    {
        public object delegates;

        // ── Methods ──
        public void GetObjectData(){} // RVA: 0x697C0A0
        public void DynamicInvokeImpl(){} // RVA: 0x6982080
        public void Equals(){} // RVA: 0x6982140
        public void GetHashCode(){} // RVA: 0x697BF10
        public void GetMethodImpl(){} // RVA: 0x69822C0
        public void GetInvocationList(){} // RVA: 0x6982430
        public void CombineImpl(){} // RVA: 0x6982510
        public void LastIndexOf(){} // RVA: 0x69828B0
        public void RemoveImpl(){} // RVA: 0x6982A40
    }

    public class MulticastNotSupportedException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class MutableDecimal : ValueType
    {
        public object Flags;
        public object High;
        public object Low;
        public object Mid;

        // ── Methods ──
        public void get_IsNegative(){} // RVA: 0x8BE0A0
        public void set_IsNegative(){} // RVA: 0x8BE0B0
        public void get_Scale(){} // RVA: 0x90550
        public void set_Scale(){} // RVA: 0x8BE0D0
    }

    public class MutableDecimal : ValueType
    {
        public object Flags;
        public object High;
        public object Low;
        public object Mid;

        // ── Methods ──
        public void get_IsNegative(){} // RVA: 0x8BE0A0
        public void set_IsNegative(){} // RVA: 0x8BE0B0
        public void get_Scale(){} // RVA: 0x90550
        public void set_Scale(){} // RVA: 0x8BE0D0
    }

}