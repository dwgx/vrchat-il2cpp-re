// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 10
// Methods: 263

namespace ThirdParty.DotNet.System
{
    public class Random : Object
    {
        public int MBIG;
        public int MSEED;
        public int MZ;
        public int _inext; // 0x10
        public int _inextp; // 0x14
        public int[] _seedArray; // 0x18
        public System.Random t_threadRandom; // 0xFFFF
        public System.Random s_globalRandom;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53A67650 | overloaded x2
        public void Sample(){} // RVA: 0x7FFD53A67880
        public void InternalSample(){} // RVA: 0x7FFD53A678A0
        public void GenerateSeed(){} // RVA: 0x7FFD53A67930
        public void GenerateGlobalSeed(){} // RVA: 0x7FFD53A4E470
        public void Next(){} // RVA: 0x7FFD53A67DE0 | overloaded x3
        public void GetSampleForLargeRange(){} // RVA: 0x7FFD53A67C50
        public void NextDouble(){} // RVA: 0x7FFD4E3F5BC0
        public void NextBytes(){} // RVA: 0x7FFD53A67EA0
        public void .cctor(){} // RVA: 0x7FFD53A67FC0
    }

    public class Range : ValueType
    {
        public System.Index Start; // 0x10
        public System.Index End; // 0x14

        // ── Methods ──
        public void get_Start(){} // RVA: 0x7FFD4F840210
        public void get_End(){} // RVA: 0x7FFD4F8402A0
        public void Equals(){} // RVA: 0x7FFD53A68120 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD53A68140
        public void ToString(){} // RVA: 0x7FFD53A68310
    }

    public class ReadOnlyMemory`1 : ValueType
    {
        public object Empty; // 0x10
        public int Length; // 0x18
        public int IsEmpty; // 0x1C
        public int Span;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void get_Empty(){} // RVA: 0x7FFD4E2ADC40
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void Slice(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void get_Span(){} // RVA: 0x7FFD4E2ADC40
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void Equals(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void CombineHashCodes(){} // RVA: 0x7FFD4E07FDC0 | overloaded x2
        public void GetObjectStartLength(){} // RVA: 0x7FFD4E08A6F0
    }

    public class ReadOnlySpan`1 : ValueType
    {
        public System.ByReference`1<System.Collections.Generic.KeyValuePair`2<string,int>> Item; // 0x10
        public int Length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E097970 | overloaded x4
        public void get_Item(){} // RVA: 0x7FFD4E087DE0
        public void GetPinnableReference(){} // RVA: 0x7FFD4E078E90
        public void CopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void TryCopyTo(){} // RVA: 0x7FFD4E2ADC40
        public void op_Equality(){} // RVA: 0x7FFD4E2ADC40
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void Slice(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void get_Length(){} // RVA: 0x7FFD4E079960
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void Equals(){} // RVA: 0x7FFD4E079F60
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void op_Implicit(){} // RVA: 0x7FFD4E2ADC40
        public void get_Empty(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ReflectionOnlyType : RuntimeType
    {
        public object TypeHandle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AAF170
        public void get_TypeHandle(){} // RVA: 0x7FFD53AAF1B0
    }

    public class RuntimeArgumentHandle : ValueType
    {
        public UIntPtr args; // 0x10
    }

    public class RuntimeFieldHandle : ValueType
    {
        public UIntPtr Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AC2B30 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFD4EEF9F60
        public void GetObjectData(){} // RVA: 0x7FFD53AC2CF0
        public void Equals(){} // RVA: 0x7FFD53AC2F50
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void SetValueInternal(){} // RVA: 0x7FFD539538A0
        public void SetValue(){} // RVA: 0x7FFD539538A0
        public void SetValueDirect(){} // RVA: 0x7FFD53AC3040
    }

    public class RuntimeMethodHandle : ValueType
    {
        public UIntPtr Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AC3050 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFD4EEF9F60
        public void GetObjectData(){} // RVA: 0x7FFD53AC3210
        public void Equals(){} // RVA: 0x7FFD53AC3460
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void ConstructInstantiation(){} // RVA: 0x7FFD53AC3550
        public void IsNullHandle(){} // RVA: 0x7FFD4FC6C2F0
    }

    public class RuntimeType : TypeInfo
    {
        public System.RuntimeType Module;
        public System.RuntimeType Assembly; // 0x8
        public System.RuntimeType TypeHandle; // 0x10
        public System.RuntimeType BaseType; // 0x18
        public System.RuntimeType UnderlyingSystemType; // 0x20
        public System.Type[] IsEnum; // 0x28
        public System.Func`3<System.Type,System.Type[],System.Type> GenericParameterAttributes; // 0x30
        public 0x66438780 IsSzArray;
        public 0x66438780 IsGenericTypeDefinition;
        public 0x66438780 IsGenericParameter;
        public 0x66438780 GenericParameterPosition;
        public 0x66438780 IsGenericType;
        public 0x66438780 IsConstructedGenericType;
        public 0x66438780 MemberType;
        public 0x66438780 ReflectedType;
        public 0x66438780 MetadataToken;
        public System.RuntimeType ContainsGenericParameters; // 0x38
        public System.MonoTypeInfo GUID; // 0x18
        public object DeclaringMethod; // 0x20
        public System.Reflection.RuntimeConstructorInfo AssemblyQualifiedName; // 0x28
        public int DeclaringType;

        // ── Methods ──
        public void GetType(){} // RVA: 0x7FFD53A9FEB0
        public void ThrowIfTypeNeverValidGenericArgument(){} // RVA: 0x7FFD53A9FF30
        public void SanityCheckGenericArguments(){} // RVA: 0x7FFD53AA00A0
        public void SplitName(){} // RVA: 0x7FFD53AA0300
        public void FilterPreCalculate(){} // RVA: 0x7FFD53AA0740
        public void FilterHelper(){} // RVA: 0x7FFD53AA0A50 | overloaded x2
        public void FilterApplyPrefixLookup(){} // RVA: 0x7FFD53AA0AF0
        public void FilterApplyBase(){} // RVA: 0x7FFD53AA0D20
        public void FilterApplyType(){} // RVA: 0x7FFD53AA0F30
        public void FilterApplyMethodInfo(){} // RVA: 0x7FFD53AA10A0
        public void FilterApplyConstructorInfo(){} // RVA: 0x7FFD53AA1140
        public void FilterApplyMethodBase(){} // RVA: 0x7FFD53AA11E0
        public void .ctor(){} // RVA: 0x7FFD53AA1480
        public void GetMethodCandidates(){} // RVA: 0x7FFD53AAE670 | overloaded x2
        public void GetConstructorCandidates(){} // RVA: 0x7FFD53AA1750
        public void GetPropertyCandidates(){} // RVA: 0x7FFD53AA1C70
        public void GetEventCandidates(){} // RVA: 0x7FFD53AA1E80
        public void GetFieldCandidates(){} // RVA: 0x7FFD53AA2080
        public void GetNestedTypeCandidates(){} // RVA: 0x7FFD53AA2240
        public void GetMethods(){} // RVA: 0x7FFD53AA27C0
        public void GetConstructors(){} // RVA: 0x7FFD53AA2870
        public void GetProperties(){} // RVA: 0x7FFD53AA2910
        public void GetEvents(){} // RVA: 0x7FFD53AA29B0
        public void GetFields(){} // RVA: 0x7FFD53AA2A40
        public void GetMembers(){} // RVA: 0x7FFD53AA2AD0
        public void GetConstructorImpl(){} // RVA: 0x7FFD53AA30D0
        public void GetPropertyImpl(){} // RVA: 0x7FFD53AA33C0
        public void GetEvent(){} // RVA: 0x7FFD53AA36D0
        public void GetField(){} // RVA: 0x7FFD53AA38F0
        public void GetInterface(){} // RVA: 0x7FFD53AA3CC0
        public void GetNestedType(){} // RVA: 0x7FFD53AA4550
        public void GetMember(){} // RVA: 0x7FFD53AA48F0
        public void get_Module(){} // RVA: 0x7FFD53AA5030
        public void GetRuntimeModule(){} // RVA: 0x7FFD53AA5030
        public void get_Assembly(){} // RVA: 0x7FFD53AA5050
        public void GetRuntimeAssembly(){} // RVA: 0x7FFD53AA5050
        public void get_TypeHandle(){} // RVA: 0x7FFD52BE53A0
        public void IsInstanceOfType(){} // RVA: 0x7FFD53AA5070
        public void IsAssignableFrom(){} // RVA: 0x7FFD53AA50A0
        public void IsEquivalentTo(){} // RVA: 0x7FFD53AA51E0
        public void get_BaseType(){} // RVA: 0x7FFD53AA52A0
        public void GetBaseType(){} // RVA: 0x7FFD53AA52B0
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFD4F9181E0
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFD53AA55A0
        public void IsContextfulImpl(){} // RVA: 0x7FFD53AA55D0
        public void IsByRefImpl(){} // RVA: 0x7FFD53AA56B0
        public void IsPrimitiveImpl(){} // RVA: 0x7FFD53AA56D0
        public void IsPointerImpl(){} // RVA: 0x7FFD53AA5700
        public void IsCOMObjectImpl(){} // RVA: 0x7FFD506288B0
        public void IsValueTypeImpl(){} // RVA: 0x7FFD53AA5720
        public void get_IsEnum(){} // RVA: 0x7FFD53AA5870
        public void HasElementTypeImpl(){} // RVA: 0x7FFD53AA58E0
        public void get_GenericParameterAttributes(){} // RVA: 0x7FFD53AA5910
        public void get_IsSzArray(){} // RVA: 0x7FFD53AA59D0
        public void IsArrayImpl(){} // RVA: 0x7FFD53AA59F0
        public void GetArrayRank(){} // RVA: 0x7FFD53AA5A10
        public void GetElementType(){} // RVA: 0x7FFD53AA5AB0
        public void GetEnumNames(){} // RVA: 0x7FFD53AA5B20
        public void GetEnumValues(){} // RVA: 0x7FFD53AA5D10
        public void GetEnumUnderlyingType(){} // RVA: 0x7FFD53AA5EA0
        public void IsEnumDefined(){} // RVA: 0x7FFD53AA5FB0
        public void GetEnumName(){} // RVA: 0x7FFD53AA66A0
        public void GetGenericArgumentsInternal(){} // RVA: 0x7FFD53AACEB0 | overloaded x2
        public void GetGenericArguments(){} // RVA: 0x7FFD53AA69A0
        public void MakeGenericType(){} // RVA: 0x7FFD53AABF90 | overloaded x2
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFD53AA6F40
        public void get_IsGenericParameter(){} // RVA: 0x7FFD53AA6F80
        public void get_GenericParameterPosition(){} // RVA: 0x7FFD53AA6FA0
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFD53AA7050
        public void get_IsGenericType(){} // RVA: 0x7FFD53AA7120
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFD53AA7160
        public void InvokeMember(){} // RVA: 0x7FFD53AA71B0
        public void Equals(){} // RVA: 0x7FFD50017CC0
        public void op_Equality(){} // RVA: 0x7FFD5072B460
        public void op_Inequality(){} // RVA: 0x7FFD53A70B50
        public void Clone(){} // RVA: 0x7FFD4F9181E0
        public void GetObjectData(){} // RVA: 0x7FFD53AA8910
        public void GetCustomAttributes(){} // RVA: 0x7FFD53AA8A30 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFD53AA8BE0
        public void GetCustomAttributesData(){} // RVA: 0x7FFD5394F190
        public void FormatTypeName(){} // RVA: 0x7FFD53AA8D90
        public void get_MemberType(){} // RVA: 0x7FFD53AA8F80
        public void get_ReflectedType(){} // RVA: 0x7FFD4E4A21C0
        public void get_MetadataToken(){} // RVA: 0x7FFD53AA8FE0
        public void CreateInstanceCheckThis(){} // RVA: 0x7FFD53AA9010
        public void CreateInstanceImpl(){} // RVA: 0x7FFD53AA9320
        public void CreateInstanceDefaultCtor(){} // RVA: 0x7FFD53AA9BC0
        public void GetDefaultConstructor(){} // RVA: 0x7FFD53AA9D30
        public void GetDefaultMemberName(){} // RVA: 0x7FFD53AA9F10
        public void GetSerializationCtor(){} // RVA: 0x7FFD53AAA070
        public void CreateInstanceSlow(){} // RVA: 0x7FFD53AAA2C0
        public void CreateInstanceMono(){} // RVA: 0x7FFD53AAA310
        public void CheckValue(){} // RVA: 0x7FFD53AAA6C0
        public void TryConvertToType(){} // RVA: 0x7FFD53AAA8E0
        public void IsConvertibleToPrimitiveType(){} // RVA: 0x7FFD53AAABE0
        public void GetCachedName(){} // RVA: 0x7FFD53AAB8A0
        public void make_array_type(){} // RVA: 0x7FFD53AAB910
        public void MakeArrayType(){} // RVA: 0x7FFD53AAB9C0 | overloaded x2
        public void make_byref_type(){} // RVA: 0x7FFD53AABA20
        public void MakeByRefType(){} // RVA: 0x7FFD53AABA40
        public void MakePointerType(){} // RVA: 0x7FFD53AABB00 | overloaded x2
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFD53AABC00
        public void GetGenericParameterConstraints(){} // RVA: 0x7FFD53AABD40
        public void CreateInstanceForAnotherGenericParameter(){} // RVA: 0x7FFD53AABE50
        public void GetMethodsByName_native(){} // RVA: 0x7FFD53AABFA0
        public void GetMethodsByName(){} // RVA: 0x7FFD53AABFB0
        public void GetPropertiesByName_native(){} // RVA: 0x7FFD53AAC340
        public void GetConstructors_native(){} // RVA: 0x7FFD53AAC350
        public void GetConstructors_internal(){} // RVA: 0x7FFD53AAC360
        public void GetPropertiesByName(){} // RVA: 0x7FFD53AAC5F0
        public void GetGUID(){} // RVA: 0x7FFD53AACA40
        public void get_GUID(){} // RVA: 0x7FFD53AACA80
        public void GetTypeCodeImpl(){} // RVA: 0x7FFD53AACBE0
        public void GetTypeCodeImplInternal(){} // RVA: 0x7FFD53AACC30
        public void ToString(){} // RVA: 0x7FFD53AACC40
        public void IsGenericCOMObjectImpl(){} // RVA: 0x7FFD4E341320
        public void CreateInstanceInternal(){} // RVA: 0x7FFD53AACC50
        public void get_DeclaringMethod(){} // RVA: 0x7FFD53AACCA0
        public void getFullName(){} // RVA: 0x7FFD53AACD20
        public void GetGenericParameterAttributes(){} // RVA: 0x7FFD53AACEC0
        public void GetGenericParameterPosition(){} // RVA: 0x7FFD53AACF00
        public void GetEvents_native(){} // RVA: 0x7FFD53AACF30
        public void GetFields_native(){} // RVA: 0x7FFD53AACF40
        public void GetFields_internal(){} // RVA: 0x7FFD53AACF50
        public void GetEvents_internal(){} // RVA: 0x7FFD53AAD360
        public void GetInterfaces(){} // RVA: 0x7FFD53AAD730
        public void GetNestedTypes_native(){} // RVA: 0x7FFD53AAD740
        public void GetNestedTypes_internal(){} // RVA: 0x7FFD53AAD750
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFD53AADB60
        public void get_DeclaringType(){} // RVA: 0x7FFD53AADB70
        public void get_Name(){} // RVA: 0x7FFD53AADC10
        public void get_Namespace(){} // RVA: 0x7FFD53AADCF0
        public void GetHashCode(){} // RVA: 0x7FFD53AADD60
        public void get_FullName(){} // RVA: 0x7FFD53AADE10
        public void get_IsSZArray(){} // RVA: 0x7FFD53AADFF0
        public void IsSubclassOf(){} // RVA: 0x7FFD53AAE060
        public void GetMethodImpl(){} // RVA: 0x7FFD53AAE170
        public void GetMethodImplCommon(){} // RVA: 0x7FFD53AAE1C0
        public void .cctor(){} // RVA: 0x7FFD53AAE8B0
    }

    public class RuntimeTypeHandle : ValueType
    {
        public UIntPtr Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53AC36E0 | overloaded x3
        public void get_Value(){} // RVA: 0x7FFD4EEF9F60
        public void GetObjectData(){} // RVA: 0x7FFD53AC38A0
        public void Equals(){} // RVA: 0x7FFD512A61F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4F840210
        public void GetAttributes(){} // RVA: 0x7FFD53AA55A0
        public void GetMetadataToken(){} // RVA: 0x7FFD53AA8FE0
        public void GetToken(){} // RVA: 0x7FFD53AA8FE0
        public void GetGenericTypeDefinition_impl(){} // RVA: 0x7FFD53AC3C40
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFD53AC3C40
        public void IsPrimitive(){} // RVA: 0x7FFD53AA56D0
        public void IsByRef(){} // RVA: 0x7FFD53AA56B0
        public void IsPointer(){} // RVA: 0x7FFD53AA5700
        public void IsArray(){} // RVA: 0x7FFD53AA59F0
        public void IsSzArray(){} // RVA: 0x7FFD53AA59D0
        public void HasElementType(){} // RVA: 0x7FFD53AA58E0
        public void GetCorElementType(){} // RVA: 0x7FFD53AC3CA0
        public void HasInstantiation(){} // RVA: 0x7FFD53AA7120
        public void IsComObject(){} // RVA: 0x7FFD4E341320 | overloaded x2
        public void IsInstanceOfType(){} // RVA: 0x7FFD53AA5070
        public void HasReferences(){} // RVA: 0x7FFD53AC3CC0
        public void IsContextful(){} // RVA: 0x7FFD53AA55D0
        public void IsEquivalentTo(){} // RVA: 0x7FFD4E341320
        public void IsInterface(){} // RVA: 0x7FFD53AC3CE0
        public void GetArrayRank(){} // RVA: 0x7FFD53AC3D10
        public void GetAssembly(){} // RVA: 0x7FFD53AA5050
        public void GetElementType(){} // RVA: 0x7FFD53AA5AB0
        public void GetModule(){} // RVA: 0x7FFD53AA5030
        public void IsGenericVariable(){} // RVA: 0x7FFD53AA6F80
        public void GetBaseType(){} // RVA: 0x7FFD53AC3D30
        public void CanCastTo(){} // RVA: 0x7FFD53AC3D70
        public void type_is_assignable_from(){} // RVA: 0x7FFD53AC3DF0
        public void IsGenericTypeDefinition(){} // RVA: 0x7FFD53AA6F40
        public void GetGenericParameterInfo(){} // RVA: 0x7FFD53AC3E70
        public void IsSubclassOf(){} // RVA: 0x7FFD53AC3E90
        public void is_subclass_of(){} // RVA: 0x7FFD53AC3EC0
        public void internal_from_name(){} // RVA: 0x7FFD53AC3ED0
        public void GetTypeByName(){} // RVA: 0x7FFD53AC3EF0
    }

}