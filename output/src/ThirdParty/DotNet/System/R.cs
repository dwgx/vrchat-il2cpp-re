// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 13
// Methods: 271

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
        public void .ctor(){} // RVA: 0x7FFAC8647650 | overloaded x2
        public void Sample(){} // RVA: 0x7FFAC8647880
        public void InternalSample(){} // RVA: 0x7FFAC86478A0
        public void GenerateSeed(){} // RVA: 0x7FFAC8647930
        public void GenerateGlobalSeed(){} // RVA: 0x7FFAC862E470
        public void Next(){} // RVA: 0x7FFAC8647DE0 | overloaded x3
        public void GetSampleForLargeRange(){} // RVA: 0x7FFAC8647C50
        public void NextDouble(){} // RVA: 0x7FFAC2FD5BC0
        public void NextBytes(){} // RVA: 0x7FFAC8647EA0
        public void .cctor(){} // RVA: 0x7FFAC8647FC0
    }

    public class Range : ValueType
    {
        public System.Index Start; // 0x10
        public System.Index End; // 0x14

        // ── Methods ──
        public void get_Start(){} // RVA: 0x7FFAC4420210
        public void get_End(){} // RVA: 0x7FFAC44202A0
        public void Equals(){} // RVA: 0x7FFAC8648120 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8648140
        public void ToString(){} // RVA: 0x7FFAC8648310
    }

    public class RankException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

    public class ReadOnlyMemory`1 : ValueType
    {
        public object Empty;
        public int Length;
        public int IsEmpty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
        public void get_Empty(){} // RVA: 0x7FFAC2E8DC40
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void Slice(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void get_Span(){} // RVA: 0x7FFAC2E8DC40
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void Equals(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void CombineHashCodes(){} // RVA: 0x7FFAC2C5FDC0 | overloaded x2
        public void GetObjectStartLength(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class ReadOnlySpan`1 : ValueType
    {
        public System.ByReference`1<T> Item;
        public int Length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C77970 | overloaded x4
        public void get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void GetPinnableReference(){} // RVA: 0x7FFAC2C58E90
        public void CopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void TryCopyTo(){} // RVA: 0x7FFAC2E8DC40
        public void op_Equality(){} // RVA: 0x7FFAC2E8DC40
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void Slice(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void get_Length(){} // RVA: 0x7FFAC2C59960
        public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void Equals(){} // RVA: 0x7FFAC2C59F60
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void op_Implicit(){} // RVA: 0x7FFAC2E8DC40
        public void get_Empty(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ReflectionOnlyType : RuntimeType
    {
        public object TypeHandle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC868F170
        public void get_TypeHandle(){} // RVA: 0x7FFAC868F1B0
    }

    public class ResolveEventArgs : EventArgs
    {
        public string Name; // 0x10
        public System.Reflection.Assembly <RequestingAssembly>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8648720 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
    }

    public class ResolveEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5CBCCD0
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class RuntimeArgumentHandle : ValueType
    {
        public UIntPtr args; // 0x10
    }

    public class RuntimeFieldHandle : ValueType
    {
        public UIntPtr Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86A2B30 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC3AD9F60
        public void GetObjectData(){} // RVA: 0x7FFAC86A2CF0
        public void Equals(){} // RVA: 0x7FFAC86A2F50
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void SetValueInternal(){} // RVA: 0x7FFAC85338A0
        public void SetValue(){} // RVA: 0x7FFAC85338A0
        public void SetValueDirect(){} // RVA: 0x7FFAC86A3040
    }

    public class RuntimeMethodHandle : ValueType
    {
        public UIntPtr Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86A3050 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC3AD9F60
        public void GetObjectData(){} // RVA: 0x7FFAC86A3210
        public void Equals(){} // RVA: 0x7FFAC86A3460
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void ConstructInstantiation(){} // RVA: 0x7FFAC86A3550
        public void IsNullHandle(){} // RVA: 0x7FFAC484C2F0
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
        public 0x6B0D8780 IsSzArray;
        public 0x6B0D8780 IsGenericTypeDefinition;
        public 0x6B0D8780 IsGenericParameter;
        public 0x6B0D8780 GenericParameterPosition;
        public 0x6B0D8780 IsGenericType;
        public 0x6B0D8780 IsConstructedGenericType;
        public 0x6B0D8780 MemberType;
        public 0x6B0D8780 ReflectedType;
        public 0x6B0D8780 MetadataToken;
        public System.RuntimeType ContainsGenericParameters; // 0x38
        public System.MonoTypeInfo GUID; // 0x18
        public object DeclaringMethod; // 0x20
        public System.Reflection.RuntimeConstructorInfo AssemblyQualifiedName; // 0x28
        public int DeclaringType;

        // ── Methods ──
        public void GetType(){} // RVA: 0x7FFAC867FEB0
        public void ThrowIfTypeNeverValidGenericArgument(){} // RVA: 0x7FFAC867FF30
        public void SanityCheckGenericArguments(){} // RVA: 0x7FFAC86800A0
        public void SplitName(){} // RVA: 0x7FFAC8680300
        public void FilterPreCalculate(){} // RVA: 0x7FFAC8680740
        public void FilterHelper(){} // RVA: 0x7FFAC8680A50 | overloaded x2
        public void FilterApplyPrefixLookup(){} // RVA: 0x7FFAC8680AF0
        public void FilterApplyBase(){} // RVA: 0x7FFAC8680D20
        public void FilterApplyType(){} // RVA: 0x7FFAC8680F30
        public void FilterApplyMethodInfo(){} // RVA: 0x7FFAC86810A0
        public void FilterApplyConstructorInfo(){} // RVA: 0x7FFAC8681140
        public void FilterApplyMethodBase(){} // RVA: 0x7FFAC86811E0
        public void .ctor(){} // RVA: 0x7FFAC8681480
        public void GetMethodCandidates(){} // RVA: 0x7FFAC868E670 | overloaded x2
        public void GetConstructorCandidates(){} // RVA: 0x7FFAC8681750
        public void GetPropertyCandidates(){} // RVA: 0x7FFAC8681C70
        public void GetEventCandidates(){} // RVA: 0x7FFAC8681E80
        public void GetFieldCandidates(){} // RVA: 0x7FFAC8682080
        public void GetNestedTypeCandidates(){} // RVA: 0x7FFAC8682240
        public void GetMethods(){} // RVA: 0x7FFAC86827C0
        public void GetConstructors(){} // RVA: 0x7FFAC8682870
        public void GetProperties(){} // RVA: 0x7FFAC8682910
        public void GetEvents(){} // RVA: 0x7FFAC86829B0
        public void GetFields(){} // RVA: 0x7FFAC8682A40
        public void GetMembers(){} // RVA: 0x7FFAC8682AD0
        public void GetConstructorImpl(){} // RVA: 0x7FFAC86830D0
        public void GetPropertyImpl(){} // RVA: 0x7FFAC86833C0
        public void GetEvent(){} // RVA: 0x7FFAC86836D0
        public void GetField(){} // RVA: 0x7FFAC86838F0
        public void GetInterface(){} // RVA: 0x7FFAC8683CC0
        public void GetNestedType(){} // RVA: 0x7FFAC8684550
        public void GetMember(){} // RVA: 0x7FFAC86848F0
        public void get_Module(){} // RVA: 0x7FFAC8685030
        public void GetRuntimeModule(){} // RVA: 0x7FFAC8685030
        public void get_Assembly(){} // RVA: 0x7FFAC8685050
        public void GetRuntimeAssembly(){} // RVA: 0x7FFAC8685050
        public void get_TypeHandle(){} // RVA: 0x7FFAC77C53A0
        public void IsInstanceOfType(){} // RVA: 0x7FFAC8685070
        public void IsAssignableFrom(){} // RVA: 0x7FFAC86850A0
        public void IsEquivalentTo(){} // RVA: 0x7FFAC86851E0
        public void get_BaseType(){} // RVA: 0x7FFAC86852A0
        public void GetBaseType(){} // RVA: 0x7FFAC86852B0
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFAC44F81E0
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFAC86855A0
        public void IsContextfulImpl(){} // RVA: 0x7FFAC86855D0
        public void IsByRefImpl(){} // RVA: 0x7FFAC86856B0
        public void IsPrimitiveImpl(){} // RVA: 0x7FFAC86856D0
        public void IsPointerImpl(){} // RVA: 0x7FFAC8685700
        public void IsCOMObjectImpl(){} // RVA: 0x7FFAC52088B0
        public void IsValueTypeImpl(){} // RVA: 0x7FFAC8685720
        public void get_IsEnum(){} // RVA: 0x7FFAC8685870
        public void HasElementTypeImpl(){} // RVA: 0x7FFAC86858E0
        public void get_GenericParameterAttributes(){} // RVA: 0x7FFAC8685910
        public void get_IsSzArray(){} // RVA: 0x7FFAC86859D0
        public void IsArrayImpl(){} // RVA: 0x7FFAC86859F0
        public void GetArrayRank(){} // RVA: 0x7FFAC8685A10
        public void GetElementType(){} // RVA: 0x7FFAC8685AB0
        public void GetEnumNames(){} // RVA: 0x7FFAC8685B20
        public void GetEnumValues(){} // RVA: 0x7FFAC8685D10
        public void GetEnumUnderlyingType(){} // RVA: 0x7FFAC8685EA0
        public void IsEnumDefined(){} // RVA: 0x7FFAC8685FB0
        public void GetEnumName(){} // RVA: 0x7FFAC86866A0
        public void GetGenericArgumentsInternal(){} // RVA: 0x7FFAC868CEB0 | overloaded x2
        public void GetGenericArguments(){} // RVA: 0x7FFAC86869A0
        public void MakeGenericType(){} // RVA: 0x7FFAC868BF90 | overloaded x2
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFAC8686F40
        public void get_IsGenericParameter(){} // RVA: 0x7FFAC8686F80
        public void get_GenericParameterPosition(){} // RVA: 0x7FFAC8686FA0
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFAC8687050
        public void get_IsGenericType(){} // RVA: 0x7FFAC8687120
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFAC8687160
        public void InvokeMember(){} // RVA: 0x7FFAC86871B0
        public void Equals(){} // RVA: 0x7FFAC4BF7CC0
        public void op_Equality(){} // RVA: 0x7FFAC530B460
        public void op_Inequality(){} // RVA: 0x7FFAC8650B50
        public void Clone(){} // RVA: 0x7FFAC44F81E0
        public void GetObjectData(){} // RVA: 0x7FFAC8688910
        public void GetCustomAttributes(){} // RVA: 0x7FFAC8688A30 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFAC8688BE0
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC852F190
        public void FormatTypeName(){} // RVA: 0x7FFAC8688D90
        public void get_MemberType(){} // RVA: 0x7FFAC8688F80
        public void get_ReflectedType(){} // RVA: 0x7FFAC30821C0
        public void get_MetadataToken(){} // RVA: 0x7FFAC8688FE0
        public void CreateInstanceCheckThis(){} // RVA: 0x7FFAC8689010
        public void CreateInstanceImpl(){} // RVA: 0x7FFAC8689320
        public void CreateInstanceDefaultCtor(){} // RVA: 0x7FFAC8689BC0
        public void GetDefaultConstructor(){} // RVA: 0x7FFAC8689D30
        public void GetDefaultMemberName(){} // RVA: 0x7FFAC8689F10
        public void GetSerializationCtor(){} // RVA: 0x7FFAC868A070
        public void CreateInstanceSlow(){} // RVA: 0x7FFAC868A2C0
        public void CreateInstanceMono(){} // RVA: 0x7FFAC868A310
        public void CheckValue(){} // RVA: 0x7FFAC868A6C0
        public void TryConvertToType(){} // RVA: 0x7FFAC868A8E0
        public void IsConvertibleToPrimitiveType(){} // RVA: 0x7FFAC868ABE0
        public void GetCachedName(){} // RVA: 0x7FFAC868B8A0
        public void make_array_type(){} // RVA: 0x7FFAC868B910
        public void MakeArrayType(){} // RVA: 0x7FFAC868B9C0 | overloaded x2
        public void make_byref_type(){} // RVA: 0x7FFAC868BA20
        public void MakeByRefType(){} // RVA: 0x7FFAC868BA40
        public void MakePointerType(){} // RVA: 0x7FFAC868BB00 | overloaded x2
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFAC868BC00
        public void GetGenericParameterConstraints(){} // RVA: 0x7FFAC868BD40
        public void CreateInstanceForAnotherGenericParameter(){} // RVA: 0x7FFAC868BE50
        public void GetMethodsByName_native(){} // RVA: 0x7FFAC868BFA0
        public void GetMethodsByName(){} // RVA: 0x7FFAC868BFB0
        public void GetPropertiesByName_native(){} // RVA: 0x7FFAC868C340
        public void GetConstructors_native(){} // RVA: 0x7FFAC868C350
        public void GetConstructors_internal(){} // RVA: 0x7FFAC868C360
        public void GetPropertiesByName(){} // RVA: 0x7FFAC868C5F0
        public void GetGUID(){} // RVA: 0x7FFAC868CA40
        public void get_GUID(){} // RVA: 0x7FFAC868CA80
        public void GetTypeCodeImpl(){} // RVA: 0x7FFAC868CBE0
        public void GetTypeCodeImplInternal(){} // RVA: 0x7FFAC868CC30
        public void ToString(){} // RVA: 0x7FFAC868CC40
        public void IsGenericCOMObjectImpl(){} // RVA: 0x7FFAC2F21320
        public void CreateInstanceInternal(){} // RVA: 0x7FFAC868CC50
        public void get_DeclaringMethod(){} // RVA: 0x7FFAC868CCA0
        public void getFullName(){} // RVA: 0x7FFAC868CD20
        public void GetGenericParameterAttributes(){} // RVA: 0x7FFAC868CEC0
        public void GetGenericParameterPosition(){} // RVA: 0x7FFAC868CF00
        public void GetEvents_native(){} // RVA: 0x7FFAC868CF30
        public void GetFields_native(){} // RVA: 0x7FFAC868CF40
        public void GetFields_internal(){} // RVA: 0x7FFAC868CF50
        public void GetEvents_internal(){} // RVA: 0x7FFAC868D360
        public void GetInterfaces(){} // RVA: 0x7FFAC868D730
        public void GetNestedTypes_native(){} // RVA: 0x7FFAC868D740
        public void GetNestedTypes_internal(){} // RVA: 0x7FFAC868D750
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFAC868DB60
        public void get_DeclaringType(){} // RVA: 0x7FFAC868DB70
        public void get_Name(){} // RVA: 0x7FFAC868DC10
        public void get_Namespace(){} // RVA: 0x7FFAC868DCF0
        public void GetHashCode(){} // RVA: 0x7FFAC868DD60
        public void get_FullName(){} // RVA: 0x7FFAC868DE10
        public void get_IsSZArray(){} // RVA: 0x7FFAC868DFF0
        public void IsSubclassOf(){} // RVA: 0x7FFAC868E060
        public void GetMethodImpl(){} // RVA: 0x7FFAC868E170
        public void GetMethodImplCommon(){} // RVA: 0x7FFAC868E1C0
        public void .cctor(){} // RVA: 0x7FFAC868E8B0
    }

    public class RuntimeTypeHandle : ValueType
    {
        public UIntPtr Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC86A36E0 | overloaded x3
        public void get_Value(){} // RVA: 0x7FFAC3AD9F60
        public void GetObjectData(){} // RVA: 0x7FFAC86A38A0
        public void Equals(){} // RVA: 0x7FFAC5E861F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC4420210
        public void GetAttributes(){} // RVA: 0x7FFAC86855A0
        public void GetMetadataToken(){} // RVA: 0x7FFAC8688FE0
        public void GetToken(){} // RVA: 0x7FFAC8688FE0
        public void GetGenericTypeDefinition_impl(){} // RVA: 0x7FFAC86A3C40
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFAC86A3C40
        public void IsPrimitive(){} // RVA: 0x7FFAC86856D0
        public void IsByRef(){} // RVA: 0x7FFAC86856B0
        public void IsPointer(){} // RVA: 0x7FFAC8685700
        public void IsArray(){} // RVA: 0x7FFAC86859F0
        public void IsSzArray(){} // RVA: 0x7FFAC86859D0
        public void HasElementType(){} // RVA: 0x7FFAC86858E0
        public void GetCorElementType(){} // RVA: 0x7FFAC86A3CA0
        public void HasInstantiation(){} // RVA: 0x7FFAC8687120
        public void IsComObject(){} // RVA: 0x7FFAC2F21320 | overloaded x2
        public void IsInstanceOfType(){} // RVA: 0x7FFAC8685070
        public void HasReferences(){} // RVA: 0x7FFAC86A3CC0
        public void IsContextful(){} // RVA: 0x7FFAC86855D0
        public void IsEquivalentTo(){} // RVA: 0x7FFAC2F21320
        public void IsInterface(){} // RVA: 0x7FFAC86A3CE0
        public void GetArrayRank(){} // RVA: 0x7FFAC86A3D10
        public void GetAssembly(){} // RVA: 0x7FFAC8685050
        public void GetElementType(){} // RVA: 0x7FFAC8685AB0
        public void GetModule(){} // RVA: 0x7FFAC8685030
        public void IsGenericVariable(){} // RVA: 0x7FFAC8686F80
        public void GetBaseType(){} // RVA: 0x7FFAC86A3D30
        public void CanCastTo(){} // RVA: 0x7FFAC86A3D70
        public void type_is_assignable_from(){} // RVA: 0x7FFAC86A3DF0
        public void IsGenericTypeDefinition(){} // RVA: 0x7FFAC8686F40
        public void GetGenericParameterInfo(){} // RVA: 0x7FFAC86A3E70
        public void IsSubclassOf(){} // RVA: 0x7FFAC86A3E90
        public void is_subclass_of(){} // RVA: 0x7FFAC86A3EC0
        public void internal_from_name(){} // RVA: 0x7FFAC86A3ED0
        public void GetTypeByName(){} // RVA: 0x7FFAC86A3EF0
    }

}