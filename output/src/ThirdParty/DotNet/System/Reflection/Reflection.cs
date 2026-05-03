// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection
// Classes: 79
// Methods: 955

namespace ThirdParty.DotNet.System.Reflection
{
    public class AmbiguousMatchException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x3
    }

    public class Assembly : Object
    {
        // ── Methods ──
        public void get_CodeBase(){} // RVA: 0x7FFE868D3E80
        public void get_EscapedCodeBase(){} // RVA: 0x7FFE868D3EC0
        public void get_FullName(){} // RVA: 0x7FFE868D3F00
        public void get_MonoAssembly(){} // RVA: 0x7FFE868D3F40
        public void get_Location(){} // RVA: 0x7FFE868D3F80
        public void GetObjectData(){} // RVA: 0x7FFE868D3FC0
        public void IsDefined(){} // RVA: 0x7FFE868D4000
        public void GetCustomAttributes(){} // RVA: 0x7FFE868D4080 | overloaded x2
        public void GetManifestResourceStream(){} // RVA: 0x7FFE868D42C0 | overloaded x3
        public void GetSimpleName(){} // RVA: 0x7FFE868D42F0
        public void GetPublicKey(){} // RVA: 0x7FFE868D4320
        public void GetVersion(){} // RVA: 0x7FFE868D4350
        public void GetFlags(){} // RVA: 0x7FFE868D4380
        public void GetTypes(){} // RVA: 0x7FFE868D43C0 | overloaded x2
        public void GetType(){} // RVA: 0x7FFE868D5570 | overloaded x3
        public void InternalGetType(){} // RVA: 0x7FFE868D4440
        public void GetName(){} // RVA: 0x7FFE868D4490 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE868D44B0
        public void GetAssembly(){} // RVA: 0x7FFE868D44F0
        public void GetEntryAssembly(){} // RVA: 0x7FFE813240E0
        public void InternalGetSatelliteAssembly(){} // RVA: 0x7FFE868D45A0
        public void LoadFrom(){} // RVA: 0x7FFE868D4B00
        public void Load(){} // RVA: 0x7FFE8684B580
        public void ReflectionOnlyLoad(){} // RVA: 0x7FFE868D4B10
        public void LoadWithPartialName(){} // RVA: 0x7FFE868D4D80 | overloaded x3
        public void load_with_partial_name(){} // RVA: 0x7FFE868D4C70
        public void GetModules(){} // RVA: 0x7FFE868D5600 | overloaded x2
        public void GetModulesInternal(){} // RVA: 0x7FFE868D4F40
        public void GetExecutingAssembly(){} // RVA: 0x7FFE868D4F80
        public void GetCallingAssembly(){} // RVA: 0x7FFE868D4FC0
        public void InternalGetReferencedAssemblies(){} // RVA: 0x7FFE868D5030
        public void GetManifestResourceNames(){} // RVA: 0x7FFE868D5040
        public void GetReferencedAssemblies(){} // RVA: 0x7FFE868D55D0 | overloaded x2
        public void GetManifestResourceInfo(){} // RVA: 0x7FFE868D5440
        public void GetManifestModule(){} // RVA: 0x7FFE868D5480
        public void get_ReflectionOnly(){} // RVA: 0x7FFE868D54C0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void CreateNIE(){} // RVA: 0x7FFE868D5500
        public void get_IsFullyTrusted(){} // RVA: 0x7FFE811E0850
        public void GetModule(){} // RVA: 0x7FFE868D55A0
        public void get_ManifestModule(){} // RVA: 0x7FFE868D5630
        public void get_IsDynamic(){} // RVA: 0x7FFE810FB320
        public void op_Equality(){} // RVA: 0x7FFE868D5660
        public void op_Inequality(){} // RVA: 0x7FFE868D56C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AssemblyCompanyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AssemblyConfigurationAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AssemblyCopyrightAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AssemblyDefaultAliasAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AssemblyDelaySignAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
    }

    public class AssemblyDescriptionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AssemblyFileVersionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86899880
    }

    public class AssemblyInformationalVersionAttribute : Attribute
    {
        public string _informationalVersion; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_InformationalVersion(){} // RVA: 0x7FFE81116380
    }

    public class AssemblyKeyFileAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AssemblyMetadataAttribute : Attribute
    {
        public string _key; // 0x10
        public string _value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void get_Key(){} // RVA: 0x7FFE81116380
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
    }

    public class AssemblyName : Object
    {
        public string name; // 0x10
        public string codebase; // 0x18
        public int major; // 0x20
        public int minor; // 0x24
        public int build; // 0x28
        public int revision; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868D59D0 | overloaded x3
        public void ParseAssemblyName(){} // RVA: 0x7FFE868D5730
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_CultureInfo(){} // RVA: 0x7FFE8144E200
        public void set_CultureInfo(){} // RVA: 0x7FFE81129890
        public void get_Flags(){} // RVA: 0x7FFE81D46090
        public void set_Flags(){} // RVA: 0x7FFE81D46A00
        public void get_FullName(){} // RVA: 0x7FFE868D63A0
        public void get_Version(){} // RVA: 0x7FFE81199370
        public void set_Version(){} // RVA: 0x7FFE868D68C0
        public void ToString(){} // RVA: 0x7FFE868D6950
        public void GetPublicKey(){} // RVA: 0x7FFE81176730
        public void GetPublicKeyToken(){} // RVA: 0x7FFE868D69A0
        public void get_IsPublicKeyValid(){} // RVA: 0x7FFE868D6AA0
        public void InternalGetPublicKeyToken(){} // RVA: 0x7FFE868D6B50
        public void get_public_token(){} // RVA: 0x7FFE868D6C40
        public void ComputePublicKeyToken(){} // RVA: 0x7FFE868D6CB0
        public void SetPublicKey(){} // RVA: 0x7FFE868D6DA0
        public void GetObjectData(){} // RVA: 0x7FFE868D6E10
        public void Clone(){} // RVA: 0x7FFE868D71B0
        public void OnDeserialization(){} // RVA: 0x7FFE868D7470
        public void GetNativeName(){} // RVA: 0x7FFE868D7500
        public void FillName(){} // RVA: 0x7FFE868D7640
        public void Create(){} // RVA: 0x7FFE868D7CA0
    }

    public class AssemblyProductAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AssemblyTitleAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AssemblyTrademarkAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class Binder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void BindToField(){} // RVA: 0x7FFE80E3E710
        public void BindToMethod(){}
        public void ChangeType(){} // RVA: 0x7FFE80E403A0
        public void ReorderArgumentArray(){} // RVA: 0x7FFE80E4F230
        public void SelectMethod(){} // RVA: 0x7FFE80E3E710
        public void SelectProperty(){}
    }

    public class BlobUtilities : Object
    {
        // ── Methods ──
        public void ReadBytes(){} // RVA: 0x7FFE86E15030
    }

    public class ConstructorInfo : MethodBase
    {
        public string ConstructorName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_MemberType(){} // RVA: 0x7FFE811EDAF0
        public void Invoke(){} // RVA: 0x7FFE80E3E710 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void op_Equality(){} // RVA: 0x7FFE8660AF70
        public void op_Inequality(){} // RVA: 0x7FFE86899970
        public void .cctor(){} // RVA: 0x7FFE86899A10
    }

    public class CustomAttributeData : Object
    {
        public System.Reflection.ConstructorInfo ctorInfo; // 0x10
        public System.Collections.Generic.IList`1<System.Reflection.CustomAttributeTypedArgument> ctorArgs; // 0x18
        public System.Collections.Generic.IList`1<System.Reflection.CustomAttributeNamedArgument> namedArgs; // 0x20
        public LazyCAttrData lazyData; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00 | overloaded x4
        public void ResolveArgumentsInternal(){} // RVA: 0x7FFE868D7FB0
        public void ResolveArguments(){} // RVA: 0x7FFE868D80C0
        public void get_Constructor(){} // RVA: 0x7FFE81116380
        public void get_ConstructorArguments(){} // RVA: 0x7FFE868D8780
        public void get_NamedArguments(){} // RVA: 0x7FFE868D87A0
        public void GetCustomAttributes(){} // RVA: 0x7FFE868D8BC0 | overloaded x4
        public void GetCustomAttributesInternal(){} // RVA: 0x7FFE868D89C0
        public void get_AttributeType(){} // RVA: 0x7FFE86853DC0
        public void ToString(){} // RVA: 0x7FFE868D8CC0
        public void UnboxValues(){} // RVA: 0x7FFE80E2E3D0
        public void Equals(){} // RVA: 0x7FFE868D93B0
        public void GetHashCode(){} // RVA: 0x7FFE868D9940
    }

    public class CustomAttributeExtensions : Object
    {
        // ── Methods ──
        public void GetCustomAttribute(){} // RVA: 0x7FFE810A1420 | overloaded x6
        public void GetCustomAttributes(){} // RVA: 0x7FFE80E3EBF0 | overloaded x7
        public void IsDefined(){} // RVA: 0x7FFE868D2570
    }

    public class CustomAttributeFormatException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827C3CE0 | overloaded x4
    }

    public class CustomAttributeNamedArgument : ValueType
    {
        public System.Reflection.CustomAttributeTypedArgument _typedValue; // 0x10
        public bool _isField; // 0x20
        public string _memberName; // 0x28
        public System.Type _attributeType; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868D0B50 | overloaded x3
        public void get_TypedValue(){} // RVA: 0x7FFE8151C410
        public void get_IsField(){} // RVA: 0x7FFE811C55E0
        public void get_MemberName(){} // RVA: 0x7FFE810FE7C0
        public void get_MemberInfo(){} // RVA: 0x7FFE868D0D00
        public void Equals(){} // RVA: 0x7FFE868D0E50
        public void GetHashCode(){} // RVA: 0x7FFE868D0EC0
        public void op_Equality(){} // RVA: 0x7FFE868D0F30
        public void op_Inequality(){} // RVA: 0x7FFE868D0FB0
        public void ToString(){} // RVA: 0x7FFE868D1030
    }

    public class CustomAttributeTypedArgument : ValueType
    {
        public System.Type _argumentType; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868D14D0 | overloaded x2
        public void get_ArgumentType(){} // RVA: 0x7FFE8284EF60
        public void get_Value(){} // RVA: 0x7FFE826F4210
        public void Equals(){} // RVA: 0x7FFE868D1950
        public void GetHashCode(){} // RVA: 0x7FFE868D19B0
        public void op_Equality(){} // RVA: 0x7FFE868D1A10
        public void op_Inequality(){} // RVA: 0x7FFE868D1AB0
        public void ToString(){} // RVA: 0x7FFE868D1B60 | overloaded x2
        public void CanonicalizeValue(){} // RVA: 0x7FFE868D2300
    }

    public class DefaultMemberAttribute : Attribute
    {
        public string _memberName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_MemberName(){} // RVA: 0x7FFE81116380
    }

    public class EventInfo : MemberInfo
    {
        public AddEventAdapter cached_add_event; // 0x10
        public object field_1; // 0x565
        public object field_2; // 0x566

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_MemberType(){} // RVA: 0x7FFE81200CB0
        public void get_AddMethod(){} // RVA: 0x7FFE86899BE0
        public void GetAddMethod(){} // RVA: 0x7FFE867F2800 | overloaded x2
        public void GetRemoveMethod(){} // RVA: 0x7FFE86899C00 | overloaded x2
        public void GetRaiseMethod(){}
        public void get_EventHandlerType(){} // RVA: 0x7FFE86899C20
        public void RemoveEventHandler(){} // RVA: 0x7FFE86899DA0
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void op_Equality(){} // RVA: 0x7FFE8660AF70
        public void op_Inequality(){} // RVA: 0x7FFE86899EF0
        public void AddEventHandler(){} // RVA: 0x7FFE86899F30
        public void internal_from_handle_type(){} // RVA: 0x7FFE8689A0F0
        public void GetEventFromHandle(){} // RVA: 0x7FFE8689A150
    }

    public class ExceptionHandlingClause : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ToString(){} // RVA: 0x7FFE868D9DE0
    }

    public class FieldInfo : MemberInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_MemberType(){} // RVA: 0x7FFE8180E590
        public void get_Attributes(){} // RVA: 0x7FFE80E2EDB0
        public void get_FieldType(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsInitOnly(){} // RVA: 0x7FFE8689A250
        public void get_IsLiteral(){} // RVA: 0x7FFE8689A280
        public void get_IsNotSerialized(){} // RVA: 0x7FFE8689A2B0
        public void get_IsStatic(){} // RVA: 0x7FFE8689A2E0
        public void get_IsAssembly(){} // RVA: 0x7FFE8689A310
        public void get_IsFamilyAndAssembly(){} // RVA: 0x7FFE8689A340
        public void get_IsPrivate(){} // RVA: 0x7FFE8689A370
        public void get_IsPublic(){} // RVA: 0x7FFE8689A3A0
        public void get_FieldHandle(){}
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void op_Equality(){} // RVA: 0x7FFE8660AF70
        public void op_Inequality(){} // RVA: 0x7FFE86899EF0
        public void GetValue(){} // RVA: 0x7FFE80E2E390
        public void SetValue(){} // RVA: 0x7FFE8689A3D0 | overloaded x2
        public void SetValueDirect(){} // RVA: 0x7FFE8689A470
        public void GetRawConstantValue(){} // RVA: 0x7FFE8689A4C0
        public void internal_from_handle_type(){} // RVA: 0x7FFE8689A510
        public void GetFieldFromHandle(){} // RVA: 0x7FFE8689A5F0 | overloaded x2
        public void GetFieldOffset(){} // RVA: 0x7FFE8689A6A0
        public void get_marshal_info(){} // RVA: 0x7FFE813240E0
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFE8689A6F0
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFE8689A900
    }

    public class ICustomAttributeProvider
    {
        // ── Methods ──
        public void GetCustomAttributes(){} // RVA: 0x7FFE80E3EBB0 | overloaded x2
        public void IsDefined(){}
    }

    public class IReflectableType
    {
        // ── Methods ──
        public void GetTypeInfo(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IntrospectionExtensions : Object
    {
        // ── Methods ──
        public void GetTypeInfo(){} // RVA: 0x7FFE868C9200
    }

    public class InvalidFilterCriteriaException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B3BC0 | overloaded x4
    }

    public class LocalVariableInfo : Object
    {
        public System.Type type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_LocalType(){} // RVA: 0x7FFE81116380
        public void ToString(){} // RVA: 0x7FFE868DA180
    }

    public class ManifestResourceInfo : Object
    {
        public System.Reflection.Assembly _referencedAssembly; // 0x10
        public string _fileName; // 0x18
        public 0x664D22AC _resourceLocation; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE862265A0
        public void get_ReferencedAssembly(){} // RVA: 0x7FFE81116380
        public void get_FileName(){} // RVA: 0x7FFE810FE7C0
        public void get_ResourceLocation(){} // RVA: 0x7FFE8151D690
    }

    public class MemberFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8401B5D0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class MemberInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_MemberType(){} // RVA: 0x7FFE80E2EDB0
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_DeclaringType(){} // RVA: 0x7FFE80E2E2E0
        public void get_ReflectedType(){} // RVA: 0x7FFE80E2E2E0
        public void get_Module(){} // RVA: 0x7FFE868C94C0
        public void IsDefined(){}
        public void GetCustomAttributes(){} // RVA: 0x7FFE80E3EBB0 | overloaded x2
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868C9590
        public void get_MetadataToken(){} // RVA: 0x7FFE868C95C0
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void op_Equality(){} // RVA: 0x7FFE868C9600
        public void op_Inequality(){} // RVA: 0x7FFE868C99B0
    }

    public class MemberInfoSerializationHolder : Object
    {
        // ── Methods ──
        public void GetSerializationInfo(){} // RVA: 0x7FFE868D25B0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE868D2CB0
        public void GetObjectData(){} // RVA: 0x7FFE868D3030
        public void GetRealObject(){} // RVA: 0x7FFE868D3090
    }

    public class MethodBase : MemberInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetParameters(){} // RVA: 0x7FFE80E2E2E0
        public void get_Attributes(){} // RVA: 0x7FFE80E2EDB0
        public void get_MethodImplementationFlags(){} // RVA: 0x7FFE868C99D0
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFE80E2EDB0
        public void GetMethodBody(){} // RVA: 0x7FFE868C99F0
        public void get_CallingConvention(){} // RVA: 0x7FFE811EDAF0
        public void get_IsAbstract(){} // RVA: 0x7FFE868C9A30
        public void get_IsConstructor(){} // RVA: 0x7FFE868C9A60
        public void get_IsSpecialName(){} // RVA: 0x7FFE868C9B00
        public void get_IsStatic(){} // RVA: 0x7FFE868C9B30
        public void get_IsVirtual(){} // RVA: 0x7FFE868C9B60
        public void get_IsAssembly(){} // RVA: 0x7FFE868C9B90
        public void get_IsFamilyAndAssembly(){} // RVA: 0x7FFE868C9BC0
        public void get_IsPrivate(){} // RVA: 0x7FFE868C9BF0
        public void get_IsPublic(){} // RVA: 0x7FFE868C9C20
        public void get_IsGenericMethod(){} // RVA: 0x7FFE810FB320
        public void get_IsGenericMethodDefinition(){} // RVA: 0x7FFE810FB320
        public void GetGenericArguments(){} // RVA: 0x7FFE868C9C50
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFE810FB320
        public void Invoke(){} // RVA: 0x7FFE868C9CA0 | overloaded x2
        public void get_MethodHandle(){}
        public void get_IsSecurityCritical(){} // RVA: 0x7FFE868C9CE0
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void op_Equality(){} // RVA: 0x7FFE868C9D10
        public void op_Inequality(){} // RVA: 0x7FFE868C9F80
        public void GetParametersInternal(){} // RVA: 0x7FFE818572C0
        public void GetParametersCount(){} // RVA: 0x7FFE868C9FA0
        public void FormatNameAndSig(){} // RVA: 0x7FFE868C9FD0
        public void GetParameterTypes(){} // RVA: 0x7FFE868CA130
        public void GetParametersNoCopy(){} // RVA: 0x7FFE818572C0
        public void GetMethodFromHandle(){} // RVA: 0x7FFE868CA4E0 | overloaded x2
        public void ConstructParameters(){} // RVA: 0x7FFE868CA5E0
    }

    public class MethodBody : Object
    {
        public System.Reflection.ExceptionHandlingClause[] clauses; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868DA260 | overloaded x2
        public void get_LocalVariables(){} // RVA: 0x7FFE868DA380
        public void GetILAsByteArray(){} // RVA: 0x7FFE811290C0
    }

    public class MethodInfo : MethodBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_MemberType(){} // RVA: 0x7FFE82199910
        public void get_ReturnParameter(){} // RVA: 0x7FFE868CA840
        public void get_ReturnType(){} // RVA: 0x7FFE868CA870
        public void GetGenericArguments(){} // RVA: 0x7FFE868CA8A0
        public void GetGenericMethodDefinition(){} // RVA: 0x7FFE868CA8F0
        public void MakeGenericMethod(){} // RVA: 0x7FFE868CA940
        public void GetBaseDefinition(){} // RVA: 0x7FFE80E2E2E0
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x7FFE80E2E2E0
        public void CreateDelegate(){} // RVA: 0x7FFE868CA9E0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void op_Equality(){} // RVA: 0x7FFE8660AF70
        public void op_Inequality(){} // RVA: 0x7FFE86899EF0
        public void get_GenericParameterCount(){} // RVA: 0x7FFE868CAA30
    }

    public class Missing : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE868CAA60
        public void .cctor(){} // RVA: 0x7FFE868CAAA0
    }

    public class MissingMetadataException : TypeAccessException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868D2410
    }

    public class Module : Object
    {
        public System.Reflection.TypeFilter FilterTypeName;
        public System.Reflection.TypeFilter FilterTypeNameIgnoreCase; // 0x8
        public 0x664D16A4 DefaultLookup;
        public object field_3; // 0x593
        public object field_4; // 0x594

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Assembly(){} // RVA: 0x7FFE868CAB40
        public void get_FullyQualifiedName(){} // RVA: 0x7FFE868CAB70
        public void get_Name(){} // RVA: 0x7FFE868CABA0
        public void get_ModuleVersionId(){} // RVA: 0x7FFE868CABD0
        public void get_ScopeName(){} // RVA: 0x7FFE868CAC00
        public void IsResource(){} // RVA: 0x7FFE868CAC30
        public void IsDefined(){} // RVA: 0x7FFE868CAC60
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868CAC90
        public void GetCustomAttributes(){} // RVA: 0x7FFE868CACF0 | overloaded x2
        public void ResolveMember(){} // RVA: 0x7FFE868CAD20
        public void GetObjectData(){} // RVA: 0x7FFE868CAD50
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void op_Equality(){} // RVA: 0x7FFE8660AF70
        public void ToString(){} // RVA: 0x7FFE81980F70
        public void FilterTypeNameImpl(){} // RVA: 0x7FFE868CAD80
        public void FilterTypeNameIgnoreCaseImpl(){} // RVA: 0x7FFE868CAFF0
        public void GetModuleVersionId(){} // RVA: 0x7FFE868CB3B0
        public void .cctor(){} // RVA: 0x7FFE868CB3F0
    }

    public class MonoEventInfo : ValueType
    {
    }

    public class MonoMethodInfo : ValueType
    {
        // ── Methods ──
        public void get_method_info(){} // RVA: 0x7FFE868DD600
        public void get_method_attributes(){} // RVA: 0x7FFE868DD790
        public void GetMethodInfo(){} // RVA: 0x7FFE868DD7A0
        public void GetDeclaringType(){} // RVA: 0x7FFE868DD940
        public void GetReturnType(){} // RVA: 0x7FFE868DD960
        public void GetAttributes(){} // RVA: 0x7FFE868DD790
        public void GetCallingConvention(){} // RVA: 0x7FFE868DD990
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFE868DD9B0
        public void get_parameter_info(){} // RVA: 0x7FFE868DD9E0
        public void GetParametersInfo(){} // RVA: 0x7FFE868DD9E0
        public void get_retval_marshal(){} // RVA: 0x7FFE813240E0
        public void GetReturnParameterInfo(){} // RVA: 0x7FFE868DDA20
    }

    public class MonoPropertyInfo : ValueType
    {
    }

    public class NullabilityInfo : Object
    {
        public System.Type _type; // 0x10
        public 0x6659BAB4 _readState; // 0x18
        public 0x6659BAB4 _writeState; // 0x1C
        public System.Reflection.NullabilityInfo _elementType; // 0x20
        public System.Reflection.NullabilityInfo[] _genericTypeArguments; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F99C20
        public void get_Type(){} // RVA: 0x7FFE81116380
        public void get_ReadState(){} // RVA: 0x7FFE813DB630
        public void set_ReadState(){} // RVA: 0x7FFE8144DF00
        public void get_WriteState(){} // RVA: 0x7FFE82707EE0
        public void set_WriteState(){} // RVA: 0x7FFE82717690
        public void get_ElementType(){} // RVA: 0x7FFE811290C0
        public void get_GenericTypeArguments(){} // RVA: 0x7FFE81129130
    }

    public class NullabilityInfoContext : Object
    {
        public string CompilerServicesNameSpace;

        // ── Methods ──
        public void get_IsSupported(){} // RVA: 0x7FFE86F99D30
        public void GetNullableContext(){} // RVA: 0x7FFE86F99D90
        public void Create(){} // RVA: 0x7FFE86F9B4F0 | overloaded x4
        public void CheckParameterMetadataType(){} // RVA: 0x7FFE86F9A4A0
        public void GetMethodMetadataDefinition(){} // RVA: 0x7FFE86F9A830
        public void CheckNullabilityAttributes(){} // RVA: 0x7FFE86F9A930
        public void IsPrivateOrInternalMethodAndAnnotationDisabled(){} // RVA: 0x7FFE86F9B2A0
        public void EnsureIsSupported(){} // RVA: 0x7FFE86F9B770
        public void IsPrivateOrInternalFieldAndAnnotationDisabled(){} // RVA: 0x7FFE86F9B850
        public void IsPublicOnly(){} // RVA: 0x7FFE86F9B9A0
        public void PopulateAnnotationInfo(){} // RVA: 0x7FFE86F9BB30
        public void GetNullabilityInfo(){} // RVA: 0x7FFE86F9BF90 | overloaded x2
        public void CreateParser(){} // RVA: 0x7FFE86F9C460
        public void TryLoadGenericMetaTypeNullability(){} // RVA: 0x7FFE86F9C830
        public void GetMemberMetadataDefinition(){} // RVA: 0x7FFE86F9CAA0
        public void GetPropertyMetaType(){} // RVA: 0x7FFE86F9CBB0
        public void CheckGenericParameters(){} // RVA: 0x7FFE86F9CC70
        public void TryUpdateGenericParameterNullability(){} // RVA: 0x7FFE86F9CE50
        public void TryUpdateGenericTypeParameterNullabilityFromReflectedType(){} // RVA: 0x7FFE86F9D090
        public void TryPopulateNullabilityInfo(){} // RVA: 0x7FFE86F9D3F0
        public void TranslateByte(){} // RVA: 0x7FFE86F9D650 | overloaded x2
        public void IsValueTypeOrValueTypeByRef(){} // RVA: 0x7FFE86F9D670
        public void .ctor(){} // RVA: 0x7FFE86F9D720
        public void .cctor(){} // RVA: 0x7FFE86F9D880
        public void <TryUpdateGenericTypeParameterNullabilityFromReflectedType>g__CountNullabilityStates|28_0(){} // RVA: 0x7FFE86F9D920
    }

    public class ObfuscationAttribute : Attribute
    {
        public bool _stripAfterObfuscation; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CB580
        public void set_Exclude(){} // RVA: 0x7FFE813471A0
    }

    public class ParameterInfo : Object
    {
        public 0x664D1FEC AttrsImpl; // 0x10
        public System.Type ClassImpl; // 0x18
        public object DefaultValueImpl; // 0x20
        public System.Reflection.MemberInfo MemberImpl; // 0x28
        public string NameImpl; // 0x30
        public int PositionImpl; // 0x38
        public int MetadataToken_ParamDef;
        public System.Runtime.InteropServices.MarshalAsAttribute marshalAs; // 0x40
        public object field_8; // 0xE40
        public object field_9;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Attributes(){} // RVA: 0x7FFE811485C0
        public void get_Member(){} // RVA: 0x7FFE81129130
        public void get_Name(){} // RVA: 0x7FFE8144E200
        public void get_ParameterType(){} // RVA: 0x7FFE810FE7C0
        public void get_Position(){} // RVA: 0x7FFE81D46090
        public void get_IsIn(){} // RVA: 0x7FFE868CB610
        public void get_IsOptional(){} // RVA: 0x7FFE868CB640
        public void get_IsOut(){} // RVA: 0x7FFE868CB670
        public void get_DefaultValue(){} // RVA: 0x7FFE868CB6A0
        public void get_HasDefaultValue(){} // RVA: 0x7FFE868CB6D0
        public void IsDefined(){} // RVA: 0x7FFE868CB700
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868CB7A0
        public void GetCustomAttributes(){} // RVA: 0x7FFE868CB810 | overloaded x2
        public void GetRealObject(){} // RVA: 0x7FFE868CB8C0
        public void ToString(){} // RVA: 0x7FFE868CBCA0
    }

    public class ParameterModifier : ValueType
    {
    }

    public class Pointer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CBD50
        public void Box(){} // RVA: 0x7FFE868CBDB0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE868CBFB0
    }

    public class PropertyInfo : MemberInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_MemberType(){} // RVA: 0x7FFE835C1D80
        public void get_PropertyType(){} // RVA: 0x7FFE80E2E2E0
        public void GetIndexParameters(){} // RVA: 0x7FFE80E2E2E0
        public void get_Attributes(){} // RVA: 0x7FFE80E2EDB0
        public void get_CanRead(){} // RVA: 0x7FFE80E2F150
        public void get_CanWrite(){} // RVA: 0x7FFE80E2F150
        public void GetAccessors(){}
        public void get_GetMethod(){} // RVA: 0x7FFE868CBFF0
        public void GetGetMethod(){} // RVA: 0x7FFE868CC010 | overloaded x2
        public void get_SetMethod(){} // RVA: 0x7FFE868CC030
        public void GetSetMethod(){} // RVA: 0x7FFE868CC050 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFE868CC090 | overloaded x3
        public void SetValue(){} // RVA: 0x7FFE868CC100 | overloaded x3
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void op_Equality(){} // RVA: 0x7FFE8660AF70
        public void op_Inequality(){} // RVA: 0x7FFE86899EF0
    }

    public class ReflectionTypeLoadException : SystemException
    {
        public System.Type[] _types; // 0x90
        public System.Exception[] _loaderExceptions; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CC270 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE868CC480
        public void get_LoaderExceptions(){} // RVA: 0x7FFE817AE360
        public void get_Message(){} // RVA: 0x7FFE868CC790
        public void ToString(){} // RVA: 0x7FFE868CC7A0
        public void CreateString(){} // RVA: 0x7FFE868CC7B0
    }

    public class RtFieldInfo : FieldInfo
    {
        // ── Methods ──
        public void UnsafeGetValue(){} // RVA: 0x7FFE80E2E390
        public void UnsafeSetValue(){}
        public void CheckConsistency(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RuntimeAssembly : Assembly
    {
        public UIntPtr _mono_assembly; // 0x10
        public object _evidence; // 0x18
        public ResolveEventHolder resolve_event_holder; // 0x20
        public object _minimum; // 0x28
        public object _optional; // 0x30
        public object _refuse; // 0x38
        public object _granted; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868DA3C0
        public void GetObjectData(){} // RVA: 0x7FFE868DA450
        public void LoadWithPartialNameInternal(){} // RVA: 0x7FFE868DA580 | overloaded x2
        public void GetName(){} // RVA: 0x7FFE868DA5D0
        public void GetType(){} // RVA: 0x7FFE868DA6A0
        public void GetModule(){} // RVA: 0x7FFE868DA770
        public void GetReferencedAssemblies(){} // RVA: 0x7FFE868DA8F0
        public void GetModules(){} // RVA: 0x7FFE868DA900
        public void get_ManifestModule(){} // RVA: 0x7FFE868DAA50
        public void GetAotId(){} // RVA: 0x7FFE868DAA70
        public void get_code_base(){} // RVA: 0x7FFE868DAAB0
        public void get_location(){} // RVA: 0x7FFE868DABB0
        public void get_fullname(){} // RVA: 0x7FFE868DAC40
        public void GetAotIdInternal(){} // RVA: 0x7FFE810FB320
        public void get_ReflectionOnly(){} // RVA: 0x7FFE810FB320
        public void GetCodeBase(){} // RVA: 0x7FFE868DAAB0
        public void get_CodeBase(){} // RVA: 0x7FFE868DACD0
        public void get_EscapedCodeBase(){} // RVA: 0x7FFE868DACE0
        public void get_FullName(){} // RVA: 0x7FFE868DAC40
        public void get_MonoAssembly(){} // RVA: 0x7FFE81116380
        public void get_Location(){} // RVA: 0x7FFE868DACF0
        public void GetManifestResourceInfoInternal(){} // RVA: 0x7FFE868DADC0
        public void GetManifestResourceInfo(){} // RVA: 0x7FFE868DADD0
        public void GetManifestResourceNames(){} // RVA: 0x7FFE868DAFA0
        public void GetManifestResourceInternal(){} // RVA: 0x7FFE868DB120
        public void GetManifestResourceStream(){} // RVA: 0x7FFE868DB130
        public void IsDefined(){} // RVA: 0x7FFE868DB6D0
        public void GetCustomAttributes(){} // RVA: 0x7FFE868DB7A0 | overloaded x2
        public void GetManifestModule(){} // RVA: 0x7FFE868DB810
        public void GetManifestModuleInternal(){} // RVA: 0x7FFE868DB820
        public void GetModulesInternal(){} // RVA: 0x7FFE868DB830
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void Equals(){} // RVA: 0x7FFE868DB8D0
        public void ToString(){} // RVA: 0x7FFE868DB990
    }

    public class RuntimeConstructorInfo : ConstructorInfo
    {
        public UIntPtr mhandle; // 0x10
        public string name; // 0x18
        public System.Type reftype; // 0x20
        public object field_3; // 0x646
        public object field_4; // 0x647
        public object field_5; // 0x648
        public object field_6; // 0x649
        public object field_7; // 0x64A
        public object field_8; // 0x64B
        public object field_9; // 0x64C
        public object field_10; // 0x64D
        public object field_11; // 0x64E

        // ── Methods ──
        public void get_Module(){} // RVA: 0x7FFE868E0250
        public void GetRuntimeModule(){} // RVA: 0x7FFE868E0250
        public void get_BindingFlags(){} // RVA: 0x7FFE813240E0
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFE868E02F0
        public void GetObjectData(){} // RVA: 0x7FFE868E0380
        public void SerializationToString(){} // RVA: 0x7FFE868E0500
        public void SerializationInvoke(){} // RVA: 0x7FFE868E0520
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFE868DE320
        public void GetParameters(){} // RVA: 0x7FFE868DE400
        public void GetParametersInternal(){} // RVA: 0x7FFE868DE400
        public void GetParametersCount(){} // RVA: 0x7FFE868E0680
        public void InternalInvoke(){} // RVA: 0x7FFE868E0AB0 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFE868E0BA0 | overloaded x2
        public void DoInvoke(){} // RVA: 0x7FFE868E0820
        public void get_MethodHandle(){} // RVA: 0x7FFE81116380
        public void get_Attributes(){} // RVA: 0x7FFE868DEB00
        public void get_CallingConvention(){} // RVA: 0x7FFE868DEB10
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFE868E0BD0
        public void get_ReflectedType(){} // RVA: 0x7FFE811290C0
        public void get_DeclaringType(){} // RVA: 0x7FFE868DEB30
        public void get_Name(){} // RVA: 0x7FFE868DEB50
        public void IsDefined(){} // RVA: 0x7FFE868E0C10
        public void GetCustomAttributes(){} // RVA: 0x7FFE868E0CE0 | overloaded x2
        public void GetMethodBody(){} // RVA: 0x7FFE868E0240
        public void ToString(){} // RVA: 0x7FFE868E0D50
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868DC5A0
        public void get_core_clr_security_level(){} // RVA: 0x7FFE811EDAF0
        public void get_IsSecurityCritical(){} // RVA: 0x7FFE811E0850
        public void get_MetadataToken(){} // RVA: 0x7FFE868DC5B0
        public void get_metadata_token(){} // RVA: 0x7FFE868DC5B0
        public void .ctor(){} // RVA: 0x7FFE868E0DB0
    }

    public class RuntimeEventInfo : EventInfo
    {
        public UIntPtr klass; // 0x18
        public UIntPtr handle; // 0x20
        public object field_2; // 0x624
        public object field_3; // 0x625
        public object field_4; // 0x626
        public object field_5; // 0x627
        public object field_6; // 0x628

        // ── Methods ──
        public void get_event_info(){} // RVA: 0x7FFE868DBB80
        public void GetEventInfo(){} // RVA: 0x7FFE868DBC90
        public void get_Module(){} // RVA: 0x7FFE868DBDB0
        public void get_BindingFlags(){} // RVA: 0x7FFE868DBDE0
        public void GetDeclaringTypeInternal(){} // RVA: 0x7FFE868DBDF0
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFE868DBE80
        public void GetRuntimeModule(){} // RVA: 0x7FFE868DBDB0
        public void GetObjectData(){} // RVA: 0x7FFE868DBF10
        public void GetBindingFlags(){} // RVA: 0x7FFE868DC050
        public void GetAddMethod(){} // RVA: 0x7FFE868DC1E0
        public void GetRaiseMethod(){} // RVA: 0x7FFE868DC260
        public void GetRemoveMethod(){} // RVA: 0x7FFE868DC2E0
        public void get_DeclaringType(){} // RVA: 0x7FFE868DC360
        public void get_ReflectedType(){} // RVA: 0x7FFE868DC380
        public void get_Name(){} // RVA: 0x7FFE868DC3A0
        public void ToString(){} // RVA: 0x7FFE868DC3C0
        public void IsDefined(){} // RVA: 0x7FFE868DC460
        public void GetCustomAttributes(){} // RVA: 0x7FFE868DC530 | overloaded x2
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868DC5A0
        public void get_MetadataToken(){} // RVA: 0x7FFE868DC5B0
        public void get_metadata_token(){} // RVA: 0x7FFE868DC5B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RuntimeFieldInfo : RtFieldInfo
    {
        public UIntPtr klass; // 0x10
        public System.RuntimeFieldHandle fhandle; // 0x18
        public string name; // 0x20
        public System.Type type; // 0x28
        public 0x664D19BC attrs; // 0x30
        public UIntPtr value; // 0x10
        public object field_6; // 0x62B
        public object field_7; // 0x62C
        public object field_8; // 0x62D
        public object field_9; // 0x62E

        // ── Methods ──
        public void get_BindingFlags(){} // RVA: 0x7FFE813240E0
        public void get_Module(){} // RVA: 0x7FFE868DC5D0
        public void GetDeclaringTypeInternal(){} // RVA: 0x7FFE868DC600
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFE868DC690
        public void GetRuntimeModule(){} // RVA: 0x7FFE868DC5D0
        public void GetObjectData(){} // RVA: 0x7FFE868DC720
        public void UnsafeGetValue(){} // RVA: 0x7FFE868DC880
        public void CheckConsistency(){} // RVA: 0x7FFE868DC890
        public void UnsafeSetValue(){} // RVA: 0x7FFE868DCA50
        public void SetValueDirect(){} // RVA: 0x7FFE868DCAA0
        public void get_Attributes(){} // RVA: 0x7FFE81156CD0
        public void get_FieldHandle(){} // RVA: 0x7FFE810FE7C0
        public void ResolveType(){} // RVA: 0x7FFE868DCC30
        public void get_FieldType(){} // RVA: 0x7FFE868DCC40
        public void GetParentType(){} // RVA: 0x7FFE868DCCB0
        public void get_ReflectedType(){} // RVA: 0x7FFE868DCCE0
        public void get_DeclaringType(){} // RVA: 0x7FFE868DCCF0
        public void get_Name(){} // RVA: 0x7FFE811290C0
        public void IsDefined(){} // RVA: 0x7FFE868DCD10
        public void GetCustomAttributes(){} // RVA: 0x7FFE868DCDE0 | overloaded x2
        public void GetFieldOffset(){} // RVA: 0x7FFE868DCE50
        public void GetValueInternal(){} // RVA: 0x7FFE868DC880
        public void GetValue(){} // RVA: 0x7FFE868DCE60
        public void ToString(){} // RVA: 0x7FFE868DD030
        public void SetValueInternal(){} // RVA: 0x7FFE868DD0D0
        public void SetValue(){} // RVA: 0x7FFE868DD0E0
        public void GetRawConstantValue(){} // RVA: 0x7FFE868DD3F0
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868DC5A0
        public void CheckGeneric(){} // RVA: 0x7FFE868DD560
        public void get_MetadataToken(){} // RVA: 0x7FFE868DC5B0
        public void get_metadata_token(){} // RVA: 0x7FFE868DC5B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RuntimeMethodInfo : MethodInfo
    {
        public UIntPtr mhandle; // 0x10
        public string name; // 0x18
        public System.Type reftype; // 0x20
        public object field_3; // 0x635
        public object field_4; // 0x636
        public object field_5; // 0x637
        public object field_6; // 0x638
        public object field_7; // 0x639
        public object field_8; // 0x63A
        public object field_9; // 0x63B
        public object field_10; // 0x63C
        public object field_11; // 0x63D
        public object field_12; // 0x63E
        public object field_13; // 0x63F
        public object field_14; // 0x640
        public object field_15; // 0x641
        public object field_16; // 0x642

        // ── Methods ──
        public void get_BindingFlags(){} // RVA: 0x7FFE813240E0
        public void get_Module(){} // RVA: 0x7FFE868DDA60
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFE868DDB00
        public void FormatNameAndSig(){} // RVA: 0x7FFE868DDB90
        public void CreateDelegate(){} // RVA: 0x7FFE868DDEA0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE868DDED0
        public void GetRuntimeModule(){} // RVA: 0x7FFE868DDA60
        public void GetObjectData(){} // RVA: 0x7FFE868DDF80
        public void SerializationToString(){} // RVA: 0x7FFE868DE150
        public void GetMethodFromHandleNoGenericCheck(){} // RVA: 0x7FFE868DE210 | overloaded x2
        public void GetMethodBodyInternal(){} // RVA: 0x7FFE868DE260
        public void GetMethodBody(){} // RVA: 0x7FFE868E0240 | overloaded x2
        public void GetMethodFromHandleInternalType(){} // RVA: 0x7FFE868DE280
        public void GetMethodFromHandleInternalType_native(){} // RVA: 0x7FFE868DE290
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_name(){} // RVA: 0x7FFE868DE2A0
        public void get_base_method(){} // RVA: 0x7FFE868DE2C0
        public void get_metadata_token(){} // RVA: 0x7FFE868DC5B0
        public void GetBaseDefinition(){} // RVA: 0x7FFE868DE2D0
        public void GetBaseMethod(){} // RVA: 0x7FFE868DE2E0
        public void get_ReturnParameter(){} // RVA: 0x7FFE868DDA20
        public void get_ReturnType(){} // RVA: 0x7FFE868DE2F0
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x7FFE868DDA20
        public void get_MetadataToken(){} // RVA: 0x7FFE868DC5B0
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFE868DE320
        public void GetParameters(){} // RVA: 0x7FFE868DE350
        public void GetParametersInternal(){} // RVA: 0x7FFE868DE400
        public void GetParametersCount(){} // RVA: 0x7FFE868DE450
        public void InternalInvoke(){} // RVA: 0x7FFE868DE4A0
        public void Invoke(){} // RVA: 0x7FFE868DE4B0
        public void ConvertValues(){} // RVA: 0x7FFE868DE7A0
        public void get_MethodHandle(){} // RVA: 0x7FFE81116380
        public void get_Attributes(){} // RVA: 0x7FFE868DEB00
        public void get_CallingConvention(){} // RVA: 0x7FFE868DEB10
        public void get_ReflectedType(){} // RVA: 0x7FFE811290C0
        public void get_DeclaringType(){} // RVA: 0x7FFE868DEB30
        public void get_Name(){} // RVA: 0x7FFE868DEB50
        public void IsDefined(){} // RVA: 0x7FFE868DEB80
        public void GetCustomAttributes(){} // RVA: 0x7FFE868DEC50 | overloaded x2
        public void GetPInvoke(){} // RVA: 0x7FFE868DECC0
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFE868DED70
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFE868DEF20
        public void GetDllImportAttributeData(){} // RVA: 0x7FFE868DF170
        public void MakeGenericMethod(){} // RVA: 0x7FFE868DFCD0
        public void MakeGenericMethod_impl(){} // RVA: 0x7FFE868E0040
        public void GetGenericArguments(){} // RVA: 0x7FFE868E0050
        public void GetGenericMethodDefinition_impl(){} // RVA: 0x7FFE868E0060
        public void GetGenericMethodDefinition(){} // RVA: 0x7FFE868E0090
        public void get_IsGenericMethodDefinition(){} // RVA: 0x7FFE868E0110
        public void get_IsGenericMethod(){} // RVA: 0x7FFE868E0120
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFE868E0150
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868DC5A0
        public void get_core_clr_security_level(){} // RVA: 0x7FFE811EDAF0
        public void get_IsSecurityCritical(){} // RVA: 0x7FFE811E0850
    }

    public class RuntimeModule : Module
    {
        public UIntPtr _impl; // 0x10
        public System.Reflection.Assembly assembly; // 0x18
        public string fqname; // 0x20
        public string name; // 0x28
        public string scopename; // 0x30

        // ── Methods ──
        public void get_Assembly(){} // RVA: 0x7FFE810FE7C0
        public void get_Name(){} // RVA: 0x7FFE81129130
        public void get_ScopeName(){} // RVA: 0x7FFE8144E200
        public void get_ModuleVersionId(){} // RVA: 0x7FFE868E0E00
        public void get_FullyQualifiedName(){} // RVA: 0x7FFE811290C0
        public void IsResource(){} // RVA: 0x7FFE812CF770
        public void GetCustomAttributes(){} // RVA: 0x7FFE868E0E90 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFE868E0F00
        public void ResolveMember(){} // RVA: 0x7FFE868E0FA0 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFE868E1000
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868D8AC0
        public void GetRuntimeAssembly(){} // RVA: 0x7FFE868E1110
        public void GetModuleVersionId(){} // RVA: 0x7FFE868E1190
        public void resolve_token_exception(){} // RVA: 0x7FFE868E1290
        public void ptrs_from_types(){} // RVA: 0x7FFE868E1450
        public void GetGuidInternal(){} // RVA: 0x7FFE810FB310
        public void ResolveMemberToken(){} // RVA: 0x7FFE868E15A0
        public void .ctor(){} // RVA: 0x7FFE868E15C0
    }

    public class RuntimeParameterInfo : ParameterInfo
    {
        public System.Runtime.InteropServices.MarshalAsAttribute marshalAs; // 0x40
        public object field_1; // 0xE40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868E1D60 | overloaded x3
        public void FormatParameters(){} // RVA: 0x7FFE868E17E0
        public void get_DefaultValue(){} // RVA: 0x7FFE868E1EE0
        public void GetCustomAttributes(){} // RVA: 0x7FFE868E22B0 | overloaded x2
        public void GetDefaultValueImpl(){} // RVA: 0x7FFE868E2320
        public void IsDefined(){} // RVA: 0x7FFE868E2440
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868D8BC0
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFE868E24B0
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFE868E27C0
        public void get_HasDefaultValue(){} // RVA: 0x7FFE868E2E80
        public void New(){} // RVA: 0x7FFE868E3010 | overloaded x2
    }

    public class RuntimePropertyInfo : PropertyInfo
    {
        public UIntPtr klass; // 0x10
        public UIntPtr prop; // 0x18
        public System.Reflection.MonoPropertyInfo info; // 0x20
        public 0x664D3224 cached; // 0x50
        public GetterAdapter cached_getter; // 0x58
        public object field_5;
        public object field_6;
        public object field_7;
        public object field_8;
        public object field_9;
        public object field_10;

        // ── Methods ──
        public void get_property_info(){} // RVA: 0x7FFE868E31C0
        public void get_BindingFlags(){} // RVA: 0x7FFE813240E0
        public void get_Module(){} // RVA: 0x7FFE868E31D0
        public void GetDeclaringTypeInternal(){} // RVA: 0x7FFE868E3270
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFE868E3300
        public void GetRuntimeModule(){} // RVA: 0x7FFE868E31D0
        public void ToString(){} // RVA: 0x7FFE868E3390
        public void FormatNameAndSig(){} // RVA: 0x7FFE868E33A0
        public void GetObjectData(){} // RVA: 0x7FFE868E3560
        public void SerializationToString(){} // RVA: 0x7FFE868E36E0
        public void CachePropertyInfo(){} // RVA: 0x7FFE868E36F0
        public void get_Attributes(){} // RVA: 0x7FFE868E3730
        public void get_CanRead(){} // RVA: 0x7FFE868E3770
        public void get_CanWrite(){} // RVA: 0x7FFE868E37A0
        public void get_PropertyType(){} // RVA: 0x7FFE868E37D0
        public void get_ReflectedType(){} // RVA: 0x7FFE868E3880
        public void get_DeclaringType(){} // RVA: 0x7FFE868E38C0
        public void get_Name(){} // RVA: 0x7FFE868E3900
        public void GetAccessors(){} // RVA: 0x7FFE868E3940
        public void GetGetMethod(){} // RVA: 0x7FFE868E3AD0
        public void GetIndexParameters(){} // RVA: 0x7FFE868E3B40
        public void GetSetMethod(){} // RVA: 0x7FFE868E3DB0
        public void IsDefined(){} // RVA: 0x7FFE868E3E20
        public void GetCustomAttributes(){} // RVA: 0x7FFE868E3EF0 | overloaded x2
        public void GetterAdapterFrame(){} // RVA: 0x7FFE80E2E440
        public void StaticGetterAdapterFrame(){} // RVA: 0x7FFE80E2E440
        public void GetValue(){} // RVA: 0x7FFE868E3F60 | overloaded x2
        public void SetValue(){} // RVA: 0x7FFE868E4110
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868DC5A0
        public void get_MetadataToken(){} // RVA: 0x7FFE868DC5B0
        public void get_metadata_token(){} // RVA: 0x7FFE868DC5B0
        public void internal_from_handle_type(){} // RVA: 0x7FFE868E4330
        public void GetPropertyFromHandle(){} // RVA: 0x7FFE868E4390
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RuntimeReflectionExtensions : Object
    {
        // ── Methods ──
        public void GetRuntimeMethod(){} // RVA: 0x7FFE868D0450
        public void GetRuntimeProperty(){} // RVA: 0x7FFE868D0530
        public void GetMethodInfo(){} // RVA: 0x7FFE868D0660
    }

    public class SignatureArrayType : SignatureHasElementType
    {
        public int _rank; // 0x20
        public bool _isMultiDim; // 0x24
        public object field_2; // 0x5AC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CC940
        public void IsArrayImpl(){} // RVA: 0x7FFE811E0850
        public void IsByRefImpl(){} // RVA: 0x7FFE810FB320
        public void IsPointerImpl(){} // RVA: 0x7FFE810FB320
        public void get_IsSZArray(){} // RVA: 0x7FFE868CC980
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFE811167C0
        public void GetArrayRank(){} // RVA: 0x7FFE8151D690
        public void get_Suffix(){} // RVA: 0x7FFE868CC990
    }

    public class SignatureByRefType : SignatureHasElementType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CCA50
        public void IsArrayImpl(){} // RVA: 0x7FFE810FB320
        public void IsByRefImpl(){} // RVA: 0x7FFE811E0850
        public void IsPointerImpl(){} // RVA: 0x7FFE810FB320
        public void get_IsSZArray(){} // RVA: 0x7FFE810FB320
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFE810FB320
        public void GetArrayRank(){} // RVA: 0x7FFE868CCA60
        public void get_Suffix(){} // RVA: 0x7FFE868CCAB0
    }

    public class SignatureConstructedGenericType : SignatureType
    {
        public System.Type _genericTypeDefinition; // 0x18
        public System.Type[] _genericTypeArguments; // 0x20
        public object field_2; // 0x5B2
        public object field_3; // 0x5B3
        public object field_4; // 0x5B4
        public object field_5; // 0x5B5
        public object field_6; // 0x5B6
        public object field_7; // 0x5B7
        public object field_8; // 0x5B8
        public object field_9; // 0x5B9
        public object field_10; // 0x5BA
        public object field_11; // 0x5BB

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CCAF0
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFE810FB320
        public void HasElementTypeImpl(){} // RVA: 0x7FFE810FB320
        public void IsArrayImpl(){} // RVA: 0x7FFE810FB320
        public void IsByRefImpl(){} // RVA: 0x7FFE810FB320
        public void IsPointerImpl(){} // RVA: 0x7FFE810FB320
        public void get_IsSZArray(){} // RVA: 0x7FFE810FB320
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFE810FB320
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFE811E0850
        public void get_IsGenericParameter(){} // RVA: 0x7FFE810FB320
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFE810FB320
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFE868CCD40
        public void get_ElementType(){} // RVA: 0x7FFE813240E0
        public void GetArrayRank(){} // RVA: 0x7FFE868CCDD0
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFE810FE7C0
        public void GetGenericArguments(){} // RVA: 0x7FFE868CCE20
        public void get_GenericTypeArguments(){} // RVA: 0x7FFE868CCE40
        public void get_GenericParameterPosition(){} // RVA: 0x7FFE868CCEC0
        public void get_Name(){} // RVA: 0x7FFE868CCF10
        public void get_Namespace(){} // RVA: 0x7FFE867A5E30
        public void ToString(){} // RVA: 0x7FFE868CCF40
    }

    public class SignatureHasElementType : SignatureType
    {
        public System.Reflection.SignatureType _elementType; // 0x18
        public object field_1; // 0x5BE
        public object field_2; // 0x5BF
        public object field_3; // 0x5C0
        public object field_4; // 0x5C1
        public object field_5; // 0x5C2
        public object field_6; // 0x5C3
        public object field_7; // 0x5C4
        public object field_8; // 0x5C5
        public object field_9; // 0x5C6
        public object field_10; // 0x5C7
        public object field_11; // 0x5C8
        public object field_12; // 0x5C9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CD120
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFE810FB320
        public void HasElementTypeImpl(){} // RVA: 0x7FFE811E0850
        public void IsArrayImpl(){} // RVA: 0x7FFE80E2F150
        public void IsByRefImpl(){} // RVA: 0x7FFE80E2F150
        public void IsPointerImpl(){} // RVA: 0x7FFE80E2F150
        public void get_IsSZArray(){} // RVA: 0x7FFE80E2F150
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFE80E2F150
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFE810FB320
        public void get_IsGenericParameter(){} // RVA: 0x7FFE810FB320
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFE810FB320
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFE812EAEA0
        public void get_ElementType(){} // RVA: 0x7FFE810FE7C0
        public void GetArrayRank(){} // RVA: 0x7FFE80E2EDB0
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFE868CD1C0
        public void GetGenericArguments(){} // RVA: 0x7FFE868CD210
        public void get_GenericTypeArguments(){} // RVA: 0x7FFE868CD250
        public void get_GenericParameterPosition(){} // RVA: 0x7FFE868CD290
        public void get_Name(){} // RVA: 0x7FFE868CD2E0
        public void get_Namespace(){} // RVA: 0x7FFE867A5E30
        public void ToString(){} // RVA: 0x7FFE868CD350
        public void get_Suffix(){} // RVA: 0x7FFE80E2E2E0
    }

    public class SignaturePointerType : SignatureHasElementType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CCA50
        public void IsArrayImpl(){} // RVA: 0x7FFE810FB320
        public void IsByRefImpl(){} // RVA: 0x7FFE810FB320
        public void IsPointerImpl(){} // RVA: 0x7FFE811E0850
        public void get_IsSZArray(){} // RVA: 0x7FFE810FB320
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFE810FB320
        public void GetArrayRank(){} // RVA: 0x7FFE868CD3C0
        public void get_Suffix(){} // RVA: 0x7FFE868CD410
    }

    public class SignatureType : Type
    {
        // ── Methods ──
        public void get_IsSignatureType(){} // RVA: 0x7FFE811E0850
        public void HasElementTypeImpl(){} // RVA: 0x7FFE80E2F150
        public void IsArrayImpl(){} // RVA: 0x7FFE80E2F150
        public void get_IsSZArray(){} // RVA: 0x7FFE80E2F150
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFE80E2F150
        public void IsByRefImpl(){} // RVA: 0x7FFE80E2F150
        public void IsPointerImpl(){} // RVA: 0x7FFE80E2F150
        public void get_IsGenericType(){} // RVA: 0x7FFE868CD450
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFE80E2F150
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFE80E2F150
        public void get_IsGenericParameter(){} // RVA: 0x7FFE80E2F150
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFE80E2F150
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFE80E2F150
        public void get_MemberType(){} // RVA: 0x7FFE835C28C0
        public void MakeArrayType(){} // RVA: 0x7FFE868CD510 | overloaded x2
        public void MakeByRefType(){} // RVA: 0x7FFE868CD5C0
        public void MakePointerType(){} // RVA: 0x7FFE868CD620
        public void MakeGenericType(){} // RVA: 0x7FFE868CD680
        public void GetElementType(){} // RVA: 0x7FFE868CD6D0
        public void GetArrayRank(){} // RVA: 0x7FFE80E2EDB0
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFE80E2E2E0
        public void get_GenericTypeArguments(){} // RVA: 0x7FFE80E2E2E0
        public void GetGenericArguments(){} // RVA: 0x7FFE80E2E2E0
        public void get_GenericParameterPosition(){} // RVA: 0x7FFE80E2EDB0
        public void get_ElementType(){} // RVA: 0x7FFE80E2E2E0
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFE827C4A80
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_Namespace(){} // RVA: 0x7FFE80E2E2E0
        public void get_FullName(){} // RVA: 0x7FFE813240E0
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFE813240E0
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void get_Assembly(){} // RVA: 0x7FFE868CD6F0
        public void get_Module(){} // RVA: 0x7FFE868CD740
        public void get_ReflectedType(){} // RVA: 0x7FFE868CD790
        public void get_BaseType(){} // RVA: 0x7FFE868CD7E0
        public void GetInterfaces(){} // RVA: 0x7FFE868CD830
        public void IsAssignableFrom(){} // RVA: 0x7FFE868CD880
        public void get_MetadataToken(){} // RVA: 0x7FFE868CD8D0
        public void get_DeclaringType(){} // RVA: 0x7FFE868CD920
        public void get_DeclaringMethod(){} // RVA: 0x7FFE868CD970
        public void GetGenericParameterConstraints(){} // RVA: 0x7FFE868CD9C0
        public void get_GenericParameterAttributes(){} // RVA: 0x7FFE868CDA10
        public void IsEnumDefined(){} // RVA: 0x7FFE868CDA60
        public void GetEnumName(){} // RVA: 0x7FFE868CDAB0
        public void GetEnumNames(){} // RVA: 0x7FFE868CDB00
        public void GetEnumUnderlyingType(){} // RVA: 0x7FFE868CDB50
        public void GetEnumValues(){} // RVA: 0x7FFE868CDBA0
        public void get_GUID(){} // RVA: 0x7FFE868CDBF0
        public void GetTypeCodeImpl(){} // RVA: 0x7FFE868CDC40
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFE868CDC90
        public void GetConstructors(){} // RVA: 0x7FFE868CDCE0
        public void GetEvent(){} // RVA: 0x7FFE868CDD30
        public void GetEvents(){} // RVA: 0x7FFE868CDD80
        public void GetField(){} // RVA: 0x7FFE868CDDD0
        public void GetFields(){} // RVA: 0x7FFE868CDE20
        public void GetMembers(){} // RVA: 0x7FFE868CDE70
        public void GetMethods(){} // RVA: 0x7FFE868CDEC0
        public void GetNestedType(){} // RVA: 0x7FFE868CDF10
        public void GetProperties(){} // RVA: 0x7FFE868CDF60
        public void InvokeMember(){} // RVA: 0x7FFE868CDFB0
        public void GetMethodImpl(){} // RVA: 0x7FFE868CE000
        public void GetPropertyImpl(){} // RVA: 0x7FFE868CE050
        public void GetMember(){} // RVA: 0x7FFE868CE0F0 | overloaded x2
        public void GetCustomAttributes(){} // RVA: 0x7FFE868CE190 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFE868CE1E0
        public void GetCustomAttributesData(){} // RVA: 0x7FFE868CE230
        public void GetInterface(){} // RVA: 0x7FFE868CE280
        public void GetConstructorImpl(){} // RVA: 0x7FFE868CE2D0
        public void IsCOMObjectImpl(){} // RVA: 0x7FFE868CE320
        public void IsPrimitiveImpl(){} // RVA: 0x7FFE868CE370
        public void IsContextfulImpl(){} // RVA: 0x7FFE868CE3C0
        public void get_IsEnum(){} // RVA: 0x7FFE868CE410
        public void IsEquivalentTo(){} // RVA: 0x7FFE868CE460
        public void IsInstanceOfType(){} // RVA: 0x7FFE868CE4B0
        public void IsMarshalByRefImpl(){} // RVA: 0x7FFE868CE500
        public void get_IsSecurityCritical(){} // RVA: 0x7FFE868CE550
        public void get_IsSecuritySafeCritical(){} // RVA: 0x7FFE868CE5A0
        public void get_IsSecurityTransparent(){} // RVA: 0x7FFE868CE5F0
        public void get_IsSerializable(){} // RVA: 0x7FFE868CE640
        public void IsSubclassOf(){} // RVA: 0x7FFE868CE690
        public void IsValueTypeImpl(){} // RVA: 0x7FFE868CE6E0
        public void get_TypeHandle(){} // RVA: 0x7FFE868CE730
        public void .ctor(){} // RVA: 0x7FFE868CE780
    }

    public class SignatureTypeExtensions : Object
    {
        // ── Methods ──
        public void MatchesParameterTypeExactly(){} // RVA: 0x7FFE868CE7D0
        public void MatchesExactly(){} // RVA: 0x7FFE868CE8C0
        public void TryResolveAgainstGenericMethod(){} // RVA: 0x7FFE868CED00
        public void TryResolve(){} // RVA: 0x7FFE868CED40
        public void TryMakeArrayType(){} // RVA: 0x7FFE868CF190 | overloaded x2
        public void TryMakeByRefType(){} // RVA: 0x7FFE868CF1C0
        public void TryMakePointerType(){} // RVA: 0x7FFE868CF1F0
        public void TryMakeGenericType(){} // RVA: 0x7FFE868CF220
    }

    public class StrongNameKeyPair : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868E4490
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFE868E4810
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE810FB310
    }

    public class TargetException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B3BC0 | overloaded x4
    }

    public class TargetInvocationException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B3BC0 | overloaded x3
    }

    public class TargetParameterCountException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868B3BC0 | overloaded x3
    }

    public class Throw : Object
    {
        // ── Methods ──
        public void InvalidCast(){} // RVA: 0x7FFE86E15120
        public void InvalidArgument(){} // RVA: 0x7FFE86E15160
        public void InvalidToken(){} // RVA: 0x7FFE86E151C0
        public void ArgumentNull(){} // RVA: 0x7FFE86E15240
        public void ArgumentOutOfRange(){} // RVA: 0x7FFE86E15290
        public void OutOfBounds(){} // RVA: 0x7FFE86E152E0
        public void InvalidHandle(){} // RVA: 0x7FFE86E15350
        public void InvalidCompressedInteger(){} // RVA: 0x7FFE86E153C0
        public void ImageTooSmall(){} // RVA: 0x7FFE86E15430
        public void ImageTooSmallOrContainsInvalidOffsetOrCount(){} // RVA: 0x7FFE86E154A0
        public void ReferenceOverflow(){} // RVA: 0x7FFE86E15510
        public void TableNotSorted(){} // RVA: 0x7FFE86E15580
        public void InvalidOperation_PEImageNotAvailable(){} // RVA: 0x7FFE86E15620
        public void SequencePointValueOutOfRange(){} // RVA: 0x7FFE86E15690
        public void PEReaderDisposed(){} // RVA: 0x7FFE86E15700
    }

    public class TypeDelegator : TypeInfo
    {
        public System.Type typeImpl; // 0x18
        public object field_1; // 0x5EF
        public object field_2; // 0x5F0
        public object field_3; // 0x5F1
        public object field_4; // 0x5F2
        public object field_5; // 0x5F3
        public object field_6; // 0x5F4
        public object field_7; // 0x5F5
        public object field_8; // 0x5F6
        public object field_9; // 0x5F7
        public object field_10; // 0x5F8
        public object field_11; // 0x5F9
        public object field_12; // 0x5FA
        public object field_13; // 0x5FB
        public object field_14; // 0x5FC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CF3C0
        public void get_GUID(){} // RVA: 0x7FFE868CF4F0
        public void get_MetadataToken(){} // RVA: 0x7FFE868CF530
        public void InvokeMember(){} // RVA: 0x7FFE868CF560
        public void get_Module(){} // RVA: 0x7FFE868CF5E0
        public void get_Assembly(){} // RVA: 0x7FFE868CF610
        public void get_TypeHandle(){} // RVA: 0x7FFE868CF640
        public void get_Name(){} // RVA: 0x7FFE868CCF10
        public void get_FullName(){} // RVA: 0x7FFE868CF670
        public void get_Namespace(){} // RVA: 0x7FFE867A5E30
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFE868CF6A0
        public void get_BaseType(){} // RVA: 0x7FFE868CF6D0
        public void GetConstructorImpl(){} // RVA: 0x7FFE868CF700
        public void GetConstructors(){} // RVA: 0x7FFE868CF730
        public void GetMethodImpl(){} // RVA: 0x7FFE868CF760
        public void GetMethods(){} // RVA: 0x7FFE868CF830
        public void GetField(){} // RVA: 0x7FFE868CF860
        public void GetFields(){} // RVA: 0x7FFE868CF890
        public void GetInterface(){} // RVA: 0x7FFE868CF8C0
        public void GetInterfaces(){} // RVA: 0x7FFE868CF8F0
        public void GetEvent(){} // RVA: 0x7FFE868CF920
        public void GetPropertyImpl(){} // RVA: 0x7FFE868CF950
        public void GetProperties(){} // RVA: 0x7FFE868CFB40
        public void GetEvents(){} // RVA: 0x7FFE868CFB70
        public void GetNestedType(){} // RVA: 0x7FFE868CFBA0
        public void GetMember(){} // RVA: 0x7FFE868CFBD0
        public void GetMembers(){} // RVA: 0x7FFE868CFC00
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFE868CFC30
        public void get_IsSZArray(){} // RVA: 0x7FFE868CFC60
        public void IsArrayImpl(){} // RVA: 0x7FFE868CFC90
        public void IsPrimitiveImpl(){} // RVA: 0x7FFE868CFCC0
        public void IsByRefImpl(){} // RVA: 0x7FFE868CFCF0
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFE868CFD20
        public void IsPointerImpl(){} // RVA: 0x7FFE867A5750
        public void IsValueTypeImpl(){} // RVA: 0x7FFE868CFD50
        public void IsCOMObjectImpl(){} // RVA: 0x7FFE868CFD80
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFE868CFDB0
        public void get_IsCollectible(){} // RVA: 0x7FFE868CFDE0
        public void GetElementType(){} // RVA: 0x7FFE868CFE10
        public void HasElementTypeImpl(){} // RVA: 0x7FFE868CFE40
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFE868CFE70
        public void GetCustomAttributes(){} // RVA: 0x7FFE868CFED0 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFE868CFF00
    }

    public class TypeFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8401B5D0
        public void Invoke(){} // RVA: 0x7FFE81257370
    }

    public class TypeInfo : Type
    {
        public 0x664D16A4 DeclaredOnlyLookup;
        public object field_1; // 0x5FE

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CFF30
        public void System.Reflection.IReflectableType.GetTypeInfo(){} // RVA: 0x7FFE827C4A80
        public void GetDeclaredMethods(){} // RVA: 0x7FFE868CFF80
        public void get_DeclaredFields(){} // RVA: 0x7FFE868D0090
        public void get_ImplementedInterfaces(){} // RVA: 0x7FFE868D00B0
    }

}