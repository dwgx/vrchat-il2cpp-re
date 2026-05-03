// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 13
// Methods: 271

namespace ThirdParty.DotNet.System
{
    public class Random : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869F0E40 | overloaded x2
        public void Sample(){} // RVA: 0x7FFE869F1070
        public void InternalSample(){} // RVA: 0x7FFE869F1090
        public void GenerateSeed(){} // RVA: 0x7FFE869F1120
        public void GenerateGlobalSeed(){} // RVA: 0x7FFE869D7C40
        public void Next(){} // RVA: 0x7FFE869F15D0 | overloaded x3
        public void GetSampleForLargeRange(){} // RVA: 0x7FFE869F1440
        public void NextDouble(){} // RVA: 0x7FFE811AFBC0
        public void NextBytes(){} // RVA: 0x7FFE869F1690
        public void .cctor(){} // RVA: 0x7FFE869F17B0
    }

    public class Range : ValueType
    {
        public System.Index _start; // 0x10
        public System.Index _end; // 0x14

        // ── Methods ──
        public void get_Start(){} // RVA: 0x7FFE826F4220
        public void get_End(){} // RVA: 0x7FFE826F42A0
        public void Equals(){} // RVA: 0x7FFE869F1910 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE869F1930
        public void ToString(){} // RVA: 0x7FFE869F1B00
    }

    public class RankException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class ReadOnlyMemory`1 : ValueType
    {
        public object _object;
        public int _index;
        public int _length;
        public object _object; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
        public void get_Empty(){} // RVA: 0x7FFE810A1420
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void Slice(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void get_Span(){} // RVA: 0x7FFE810A1420
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void Equals(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void CombineHashCodes(){} // RVA: 0x7FFE80E35210 | overloaded x2
        public void GetObjectStartLength(){} // RVA: 0x7FFE80E3FC10
    }

    public class ReadOnlySpan`1 : ValueType
    {
        public System.ByReference`1<T> _pointer;
        public int _length;
        public System.ByReference`1<int> _pointer; // 0x10
        public int _length; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4D070 | overloaded x4
        public void get_Item(){} // RVA: 0x7FFE80E3D230
        public void GetPinnableReference(){} // RVA: 0x7FFE80E2E2E0
        public void CopyTo(){} // RVA: 0x7FFE810A1420
        public void TryCopyTo(){} // RVA: 0x7FFE810A1420
        public void op_Equality(){} // RVA: 0x7FFE810A1420
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void Slice(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void get_Length(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void Equals(){} // RVA: 0x7FFE80E2F3B0
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void op_Implicit(){} // RVA: 0x7FFE810A1420
        public void get_Empty(){} // RVA: 0x7FFE810A1420
    }

    public class ReflectionOnlyType : RuntimeType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A38950
        public void get_TypeHandle(){} // RVA: 0x7FFE86A38990
    }

    public class ResolveEventArgs : EventArgs
    {
        public string _name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE869F1F10 | overloaded x2
        public void get_Name(){} // RVA: 0x7FFE81116380
    }

    public class ResolveEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8401B110
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class RuntimeArgumentHandle : ValueType
    {
    }

    public class RuntimeFieldHandle : ValueType
    {
        public UIntPtr value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A4C2E0 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE8284EF60
        public void GetObjectData(){} // RVA: 0x7FFE86A4C4A0
        public void Equals(){} // RVA: 0x7FFE86A4C700
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void SetValueInternal(){} // RVA: 0x7FFE868DD0D0
        public void SetValue(){} // RVA: 0x7FFE868DD0D0
        public void SetValueDirect(){} // RVA: 0x7FFE86A4C7F0
    }

    public class RuntimeMethodHandle : ValueType
    {
        public UIntPtr value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A4C800 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE8284EF60
        public void GetObjectData(){} // RVA: 0x7FFE86A4C9C0
        public void Equals(){} // RVA: 0x7FFE86A4CC10
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void ConstructInstantiation(){} // RVA: 0x7FFE86A4CD00
        public void IsNullHandle(){} // RVA: 0x7FFE82AB4690
    }

    public class RuntimeType : TypeInfo
    {
        public System.RuntimeType ValueType;
        public System.RuntimeType EnumType; // 0x8
        public System.RuntimeType ObjectType; // 0x10
        public System.RuntimeType StringType; // 0x18
        public System.RuntimeType DelegateType; // 0x20
        public System.Type[] s_SICtorParamTypes; // 0x28
        public System.Func`3<System.Type,System.Type[],System.Type> MakeTypeBuilderInstantiation; // 0x30
        public 0x664D16A4 MemberBindingMask;
        public 0x664D16A4 InvocationMask;
        public 0x664D16A4 BinderNonCreateInstance;
        public 0x664D16A4 BinderGetSetProperty;
        public 0x664D16A4 BinderSetInvokeProperty;
        public 0x664D16A4 BinderGetSetField;
        public 0x664D16A4 BinderSetInvokeField;
        public 0x664D16A4 BinderNonFieldGetSet;
        public 0x664D16A4 ClassicBindingMask;
        public System.RuntimeType s_typedRef; // 0x38
        public System.MonoTypeInfo type_info; // 0x18
        public object GenericCache; // 0x20
        public System.Reflection.RuntimeConstructorInfo m_serializationCtor; // 0x28
        public int GenericParameterCountAny;
        public object field_21; // 0x15E
        public object field_22; // 0x15F
        public object field_23; // 0x160
        public object field_24; // 0x161

        // ── Methods ──
        public void GetType(){} // RVA: 0x7FFE86A296A0
        public void ThrowIfTypeNeverValidGenericArgument(){} // RVA: 0x7FFE86A29720
        public void SanityCheckGenericArguments(){} // RVA: 0x7FFE86A29890
        public void SplitName(){} // RVA: 0x7FFE86A29AF0
        public void FilterPreCalculate(){} // RVA: 0x7FFE86A29F30
        public void FilterHelper(){} // RVA: 0x7FFE86A2A240 | overloaded x2
        public void FilterApplyPrefixLookup(){} // RVA: 0x7FFE86A2A2E0
        public void FilterApplyBase(){} // RVA: 0x7FFE86A2A510
        public void FilterApplyType(){} // RVA: 0x7FFE86A2A720
        public void FilterApplyMethodInfo(){} // RVA: 0x7FFE86A2A890
        public void FilterApplyConstructorInfo(){} // RVA: 0x7FFE86A2A930
        public void FilterApplyMethodBase(){} // RVA: 0x7FFE86A2A9D0
        public void .ctor(){} // RVA: 0x7FFE86A2AC70
        public void GetMethodCandidates(){} // RVA: 0x7FFE86A37E50 | overloaded x2
        public void GetConstructorCandidates(){} // RVA: 0x7FFE86A2AF40
        public void GetPropertyCandidates(){} // RVA: 0x7FFE86A2B460
        public void GetEventCandidates(){} // RVA: 0x7FFE86A2B670
        public void GetFieldCandidates(){} // RVA: 0x7FFE86A2B870
        public void GetNestedTypeCandidates(){} // RVA: 0x7FFE86A2BA30
        public void GetMethods(){} // RVA: 0x7FFE86A2BFB0
        public void GetConstructors(){} // RVA: 0x7FFE86A2C060
        public void GetProperties(){} // RVA: 0x7FFE86A2C100
        public void GetEvents(){} // RVA: 0x7FFE86A2C1A0
        public void GetFields(){} // RVA: 0x7FFE86A2C230
        public void GetMembers(){} // RVA: 0x7FFE86A2C2C0
        public void GetConstructorImpl(){} // RVA: 0x7FFE86A2C8C0
        public void GetPropertyImpl(){} // RVA: 0x7FFE86A2CBB0
        public void GetEvent(){} // RVA: 0x7FFE86A2CEC0
        public void GetField(){} // RVA: 0x7FFE86A2D0E0
        public void GetInterface(){} // RVA: 0x7FFE86A2D4B0
        public void GetNestedType(){} // RVA: 0x7FFE86A2DD40
        public void GetMember(){} // RVA: 0x7FFE86A2E0E0
        public void get_Module(){} // RVA: 0x7FFE86A2E820
        public void GetRuntimeModule(){} // RVA: 0x7FFE86A2E820
        public void get_Assembly(){} // RVA: 0x7FFE86A2E840
        public void GetRuntimeAssembly(){} // RVA: 0x7FFE86A2E840
        public void get_TypeHandle(){} // RVA: 0x7FFE85B3A480
        public void IsInstanceOfType(){} // RVA: 0x7FFE86A2E860
        public void IsAssignableFrom(){} // RVA: 0x7FFE86A2E890
        public void IsEquivalentTo(){} // RVA: 0x7FFE86A2E9D0
        public void get_BaseType(){} // RVA: 0x7FFE86A2EA90
        public void GetBaseType(){} // RVA: 0x7FFE86A2EAA0
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFE827C4A80
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFE86A2ED90
        public void IsContextfulImpl(){} // RVA: 0x7FFE86A2EDC0
        public void IsByRefImpl(){} // RVA: 0x7FFE86A2EEA0
        public void IsPrimitiveImpl(){} // RVA: 0x7FFE86A2EEC0
        public void IsPointerImpl(){} // RVA: 0x7FFE86A2EEF0
        public void IsCOMObjectImpl(){} // RVA: 0x7FFE834BA0A0
        public void IsValueTypeImpl(){} // RVA: 0x7FFE86A2EF10
        public void get_IsEnum(){} // RVA: 0x7FFE86A2F060
        public void HasElementTypeImpl(){} // RVA: 0x7FFE86A2F0D0
        public void get_GenericParameterAttributes(){} // RVA: 0x7FFE86A2F100
        public void get_IsSzArray(){} // RVA: 0x7FFE86A2F1C0
        public void IsArrayImpl(){} // RVA: 0x7FFE86A2F1E0
        public void GetArrayRank(){} // RVA: 0x7FFE86A2F200
        public void GetElementType(){} // RVA: 0x7FFE86A2F2A0
        public void GetEnumNames(){} // RVA: 0x7FFE86A2F310
        public void GetEnumValues(){} // RVA: 0x7FFE86A2F500
        public void GetEnumUnderlyingType(){} // RVA: 0x7FFE86A2F690
        public void IsEnumDefined(){} // RVA: 0x7FFE86A2F7A0
        public void GetEnumName(){} // RVA: 0x7FFE86A2FE90
        public void GetGenericArgumentsInternal(){} // RVA: 0x7FFE86A366A0 | overloaded x2
        public void GetGenericArguments(){} // RVA: 0x7FFE86A30190
        public void MakeGenericType(){} // RVA: 0x7FFE86A35780 | overloaded x2
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFE86A30730
        public void get_IsGenericParameter(){} // RVA: 0x7FFE86A30770
        public void get_GenericParameterPosition(){} // RVA: 0x7FFE86A30790
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFE86A30840
        public void get_IsGenericType(){} // RVA: 0x7FFE86A30910
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFE86A30950
        public void InvokeMember(){} // RVA: 0x7FFE86A309A0
        public void Equals(){} // RVA: 0x7FFE82E646C0
        public void op_Equality(){} // RVA: 0x7FFE835C1CA0
        public void op_Inequality(){} // RVA: 0x7FFE869FA340
        public void Clone(){} // RVA: 0x7FFE827C4A80
        public void GetObjectData(){} // RVA: 0x7FFE86A32100
        public void GetCustomAttributes(){} // RVA: 0x7FFE86A32220 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFE86A323D0
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868D89C0
        public void FormatTypeName(){} // RVA: 0x7FFE86A32580
        public void get_MemberType(){} // RVA: 0x7FFE86A32770
        public void get_ReflectedType(){} // RVA: 0x7FFE8125C1C0
        public void get_MetadataToken(){} // RVA: 0x7FFE86A327D0
        public void CreateInstanceCheckThis(){} // RVA: 0x7FFE86A32800
        public void CreateInstanceImpl(){} // RVA: 0x7FFE86A32B10
        public void CreateInstanceDefaultCtor(){} // RVA: 0x7FFE86A333B0
        public void GetDefaultConstructor(){} // RVA: 0x7FFE86A33520
        public void GetDefaultMemberName(){} // RVA: 0x7FFE86A33700
        public void GetSerializationCtor(){} // RVA: 0x7FFE86A33860
        public void CreateInstanceSlow(){} // RVA: 0x7FFE86A33AB0
        public void CreateInstanceMono(){} // RVA: 0x7FFE86A33B00
        public void CheckValue(){} // RVA: 0x7FFE86A33EB0
        public void TryConvertToType(){} // RVA: 0x7FFE86A340D0
        public void IsConvertibleToPrimitiveType(){} // RVA: 0x7FFE86A343D0
        public void GetCachedName(){} // RVA: 0x7FFE86A35090
        public void make_array_type(){} // RVA: 0x7FFE86A35100
        public void MakeArrayType(){} // RVA: 0x7FFE86A351B0 | overloaded x2
        public void make_byref_type(){} // RVA: 0x7FFE86A35210
        public void MakeByRefType(){} // RVA: 0x7FFE86A35230
        public void MakePointerType(){} // RVA: 0x7FFE86A352F0 | overloaded x2
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFE86A353F0
        public void GetGenericParameterConstraints(){} // RVA: 0x7FFE86A35530
        public void CreateInstanceForAnotherGenericParameter(){} // RVA: 0x7FFE86A35640
        public void GetMethodsByName_native(){} // RVA: 0x7FFE86A35790
        public void GetMethodsByName(){} // RVA: 0x7FFE86A357A0
        public void GetPropertiesByName_native(){} // RVA: 0x7FFE86A35B30
        public void GetConstructors_native(){} // RVA: 0x7FFE86A35B40
        public void GetConstructors_internal(){} // RVA: 0x7FFE86A35B50
        public void GetPropertiesByName(){} // RVA: 0x7FFE86A35DE0
        public void GetGUID(){} // RVA: 0x7FFE86A36230
        public void get_GUID(){} // RVA: 0x7FFE86A36270
        public void GetTypeCodeImpl(){} // RVA: 0x7FFE86A363D0
        public void GetTypeCodeImplInternal(){} // RVA: 0x7FFE86A36420
        public void ToString(){} // RVA: 0x7FFE86A36430
        public void IsGenericCOMObjectImpl(){} // RVA: 0x7FFE810FB320
        public void CreateInstanceInternal(){} // RVA: 0x7FFE86A36440
        public void get_DeclaringMethod(){} // RVA: 0x7FFE86A36490
        public void getFullName(){} // RVA: 0x7FFE86A36510
        public void GetGenericParameterAttributes(){} // RVA: 0x7FFE86A366B0
        public void GetGenericParameterPosition(){} // RVA: 0x7FFE86A366F0
        public void GetEvents_native(){} // RVA: 0x7FFE86A36720
        public void GetFields_native(){} // RVA: 0x7FFE86A36730
        public void GetFields_internal(){} // RVA: 0x7FFE86A36740
        public void GetEvents_internal(){} // RVA: 0x7FFE86A36B50
        public void GetInterfaces(){} // RVA: 0x7FFE86A36F20
        public void GetNestedTypes_native(){} // RVA: 0x7FFE86A36F30
        public void GetNestedTypes_internal(){} // RVA: 0x7FFE86A36F40
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFE86A37350
        public void get_DeclaringType(){} // RVA: 0x7FFE86A37360
        public void get_Name(){} // RVA: 0x7FFE86A37400
        public void get_Namespace(){} // RVA: 0x7FFE86A374E0
        public void GetHashCode(){} // RVA: 0x7FFE86A37540
        public void get_FullName(){} // RVA: 0x7FFE86A375F0
        public void get_IsSZArray(){} // RVA: 0x7FFE86A377D0
        public void IsSubclassOf(){} // RVA: 0x7FFE86A37840
        public void GetMethodImpl(){} // RVA: 0x7FFE86A37950
        public void GetMethodImplCommon(){} // RVA: 0x7FFE86A379A0
        public void .cctor(){} // RVA: 0x7FFE86A38090
    }

    public class RuntimeTypeHandle : ValueType
    {
        public UIntPtr value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86A4CE90 | overloaded x3
        public void get_Value(){} // RVA: 0x7FFE8284EF60
        public void GetObjectData(){} // RVA: 0x7FFE86A4D050
        public void Equals(){} // RVA: 0x7FFE841BEBF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE826F4220
        public void GetAttributes(){} // RVA: 0x7FFE86A2ED90
        public void GetMetadataToken(){} // RVA: 0x7FFE86A327D0
        public void GetToken(){} // RVA: 0x7FFE86A327D0
        public void GetGenericTypeDefinition_impl(){} // RVA: 0x7FFE86A4D3F0
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFE86A4D3F0
        public void IsPrimitive(){} // RVA: 0x7FFE86A2EEC0
        public void IsByRef(){} // RVA: 0x7FFE86A2EEA0
        public void IsPointer(){} // RVA: 0x7FFE86A2EEF0
        public void IsArray(){} // RVA: 0x7FFE86A2F1E0
        public void IsSzArray(){} // RVA: 0x7FFE86A2F1C0
        public void HasElementType(){} // RVA: 0x7FFE86A2F0D0
        public void GetCorElementType(){} // RVA: 0x7FFE86A4D450
        public void HasInstantiation(){} // RVA: 0x7FFE86A30910
        public void IsComObject(){} // RVA: 0x7FFE810FB320 | overloaded x2
        public void IsInstanceOfType(){} // RVA: 0x7FFE86A2E860
        public void HasReferences(){} // RVA: 0x7FFE86A4D470
        public void IsContextful(){} // RVA: 0x7FFE86A2EDC0
        public void IsEquivalentTo(){} // RVA: 0x7FFE810FB320
        public void IsInterface(){} // RVA: 0x7FFE86A4D490
        public void GetArrayRank(){} // RVA: 0x7FFE86A4D4C0
        public void GetAssembly(){} // RVA: 0x7FFE86A2E840
        public void GetElementType(){} // RVA: 0x7FFE86A2F2A0
        public void GetModule(){} // RVA: 0x7FFE86A2E820
        public void IsGenericVariable(){} // RVA: 0x7FFE86A30770
        public void GetBaseType(){} // RVA: 0x7FFE86A4D4E0
        public void CanCastTo(){} // RVA: 0x7FFE86A4D520
        public void type_is_assignable_from(){} // RVA: 0x7FFE86A4D5A0
        public void IsGenericTypeDefinition(){} // RVA: 0x7FFE86A30730
        public void GetGenericParameterInfo(){} // RVA: 0x7FFE86A4D620
        public void IsSubclassOf(){} // RVA: 0x7FFE86A4D640
        public void is_subclass_of(){} // RVA: 0x7FFE86A4D670
        public void internal_from_name(){} // RVA: 0x7FFE86A4D680
        public void GetTypeByName(){} // RVA: 0x7FFE86A4D6A0
    }

}