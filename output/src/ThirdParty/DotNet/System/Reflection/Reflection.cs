// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection
// Classes: 46
// Methods: 624

namespace ThirdParty.DotNet.System.Reflection
{
    public class Assembly : Object
    {
        public object CodeBase;
        public object EscapedCodeBase;
        public object FullName;
        public object MonoAssembly;
        public object Location;
        public object ReflectionOnly;
        public object IsFullyTrusted;
        public object ManifestModule;
        public object IsDynamic;

        // ── Methods ──
        public void get_CodeBase(){} // RVA: 0x7FFD5394A650
        public void get_EscapedCodeBase(){} // RVA: 0x7FFD5394A690
        public void get_FullName(){} // RVA: 0x7FFD5394A6D0
        public void get_MonoAssembly(){} // RVA: 0x7FFD5394A710
        public void get_Location(){} // RVA: 0x7FFD5394A750
        public void GetObjectData(){} // RVA: 0x7FFD5394A790
        public void IsDefined(){} // RVA: 0x7FFD5394A7D0
        public void GetCustomAttributes(){} // RVA: 0x7FFD5394A850 | overloaded x2
        public void GetManifestResourceStream(){} // RVA: 0x7FFD5394AA90 | overloaded x3
        public void GetSimpleName(){} // RVA: 0x7FFD5394AAC0
        public void GetPublicKey(){} // RVA: 0x7FFD5394AAF0
        public void GetVersion(){} // RVA: 0x7FFD5394AB20
        public void GetFlags(){} // RVA: 0x7FFD5394AB50
        public void GetTypes(){} // RVA: 0x7FFD5394AB90 | overloaded x2
        public void GetType(){} // RVA: 0x7FFD5394BD40 | overloaded x3
        public void InternalGetType(){} // RVA: 0x7FFD5394AC10
        public void GetName(){} // RVA: 0x7FFD5394AC60 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD5394AC80
        public void GetAssembly(){} // RVA: 0x7FFD5394ACC0
        public void GetEntryAssembly(){} // RVA: 0x7FFD4E919180
        public void InternalGetSatelliteAssembly(){} // RVA: 0x7FFD5394AD70
        public void LoadFrom(){} // RVA: 0x7FFD5394B2D0
        public void Load(){} // RVA: 0x7FFD538C1C80
        public void ReflectionOnlyLoad(){} // RVA: 0x7FFD5394B2E0
        public void LoadWithPartialName(){} // RVA: 0x7FFD5394B550 | overloaded x3
        public void load_with_partial_name(){} // RVA: 0x7FFD5394B440
        public void GetModules(){} // RVA: 0x7FFD5394BDD0 | overloaded x2
        public void GetModulesInternal(){} // RVA: 0x7FFD5394B710
        public void GetExecutingAssembly(){} // RVA: 0x7FFD5394B750
        public void GetCallingAssembly(){} // RVA: 0x7FFD5394B790
        public void InternalGetReferencedAssemblies(){} // RVA: 0x7FFD5394B800
        public void GetManifestResourceNames(){} // RVA: 0x7FFD5394B810
        public void GetReferencedAssemblies(){} // RVA: 0x7FFD5394BDA0 | overloaded x2
        public void GetManifestResourceInfo(){} // RVA: 0x7FFD5394BC10
        public void GetManifestModule(){} // RVA: 0x7FFD5394BC50
        public void get_ReflectionOnly(){} // RVA: 0x7FFD5394BC90
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void Equals(){} // RVA: 0x7FFD5072B460
        public void CreateNIE(){} // RVA: 0x7FFD5394BCD0
        public void get_IsFullyTrusted(){} // RVA: 0x7FFD4E426850
        public void GetModule(){} // RVA: 0x7FFD5394BD70
        public void get_ManifestModule(){} // RVA: 0x7FFD5394BE00
        public void get_IsDynamic(){} // RVA: 0x7FFD4E341320
        public void op_Equality(){} // RVA: 0x7FFD5394BE30
        public void op_Inequality(){} // RVA: 0x7FFD5394BE90
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AssemblyCompanyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class AssemblyConfigurationAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class AssemblyCopyrightAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class AssemblyDefaultAliasAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class AssemblyDelaySignAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E40B5F0
    }

    public class AssemblyDescriptionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class AssemblyFileVersionAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53910080
    }

    public class AssemblyInformationalVersionAttribute : Attribute
    {
        public object InformationalVersion;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void get_InformationalVersion(){} // RVA: 0x7FFD4E35C380
    }

    public class AssemblyKeyFileAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class AssemblyMetadataAttribute : Attribute
    {
        public object Key;
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
        public void get_Key(){} // RVA: 0x7FFD4E35C380
        public void get_Value(){} // RVA: 0x7FFD4E3447C0
    }

    public class AssemblyName : Object
    {
        public object Name;
        public object CultureInfo;
        public object Flags;
        public object FullName;
        public object Version;
        public object IsPublicKeyValid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5394C1A0 | overloaded x3
        public void ParseAssemblyName(){} // RVA: 0x7FFD5394BF00
        public void get_Name(){} // RVA: 0x7FFD4E35C380
        public void set_Name(){} // RVA: 0x7FFD4E342E30
        public void get_CultureInfo(){} // RVA: 0x7FFD4E5F95E0
        public void set_CultureInfo(){} // RVA: 0x7FFD4E36F890
        public void get_Flags(){} // RVA: 0x7FFD4E9AA870
        public void set_Flags(){} // RVA: 0x7FFD4E9A8350
        public void get_FullName(){} // RVA: 0x7FFD5394CB70
        public void get_Version(){} // RVA: 0x7FFD4E3DF370
        public void set_Version(){} // RVA: 0x7FFD5394D090
        public void ToString(){} // RVA: 0x7FFD5394D120
        public void GetPublicKey(){} // RVA: 0x7FFD4E3BC730
        public void GetPublicKeyToken(){} // RVA: 0x7FFD5394D170
        public void get_IsPublicKeyValid(){} // RVA: 0x7FFD5394D270
        public void InternalGetPublicKeyToken(){} // RVA: 0x7FFD5394D320
        public void get_public_token(){} // RVA: 0x7FFD5394D410
        public void ComputePublicKeyToken(){} // RVA: 0x7FFD5394D480
        public void SetPublicKey(){} // RVA: 0x7FFD5394D570
        public void GetObjectData(){} // RVA: 0x7FFD5394D5E0
        public void Clone(){} // RVA: 0x7FFD5394D980
        public void OnDeserialization(){} // RVA: 0x7FFD5394DC40
        public void GetNativeName(){} // RVA: 0x7FFD5394DCD0
        public void FillName(){} // RVA: 0x7FFD5394DE10
        public void Create(){} // RVA: 0x7FFD5394E470
    }

    public class AssemblyProductAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class AssemblyTitleAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class AssemblyTrademarkAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class Binder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void BindToField(){} // RVA: 0x7FFD4E089250
        public void BindToMethod(){}
        public void ChangeType(){} // RVA: 0x7FFD4E08AE80
        public void ReorderArgumentArray(){} // RVA: 0x7FFD4E099B30
        public void SelectMethod(){} // RVA: 0x7FFD4E089250
        public void SelectProperty(){}
    }

    public class ConstructorInfo : MethodBase
    {
        public object MemberType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_MemberType(){} // RVA: 0x7FFD4E433AF0
        public void Invoke(){} // RVA: 0x7FFD4E089250 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD5072B460
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void op_Equality(){} // RVA: 0x7FFD53681650
        public void op_Inequality(){} // RVA: 0x7FFD53910170
        public void .cctor(){} // RVA: 0x7FFD53910210
    }

    public class CustomAttributeData : Object
    {
        public object Constructor;
        public object ConstructorArguments;
        public object NamedArguments;
        public object AttributeType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E420E00 | overloaded x4
        public void ResolveArgumentsInternal(){} // RVA: 0x7FFD5394E780
        public void ResolveArguments(){} // RVA: 0x7FFD5394E890
        public void get_Constructor(){} // RVA: 0x7FFD4E35C380
        public void get_ConstructorArguments(){} // RVA: 0x7FFD5394EF50
        public void get_NamedArguments(){} // RVA: 0x7FFD5394EF70
        public void GetCustomAttributes(){} // RVA: 0x7FFD5394F390 | overloaded x4
        public void GetCustomAttributesInternal(){} // RVA: 0x7FFD5394F190
        public void get_AttributeType(){} // RVA: 0x7FFD538CA500
        public void ToString(){} // RVA: 0x7FFD5394F490
        public void UnboxValues(){} // RVA: 0x7FFD4E078F80
        public void Equals(){} // RVA: 0x7FFD5394FB80
        public void GetHashCode(){} // RVA: 0x7FFD53950110
    }

    public class CustomAttributeExtensions : Object
    {
        // ── Methods ──
        public void GetCustomAttribute(){} // RVA: 0x7FFD4E2ADC40 | overloaded x6
        public void GetCustomAttributes(){} // RVA: 0x7FFD4E089730 | overloaded x7
        public void IsDefined(){} // RVA: 0x7FFD53948D40
    }

    public class CustomAttributeNamedArgument : ValueType
    {
        public object TypedValue;
        public object IsField;
        public object MemberName;
        public object MemberInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53947320 | overloaded x3
        public void get_TypedValue(){} // RVA: 0x7FFD4E6E0590
        public void get_IsField(){} // RVA: 0x7FFD4E40B5E0
        public void get_MemberName(){} // RVA: 0x7FFD4E3447C0
        public void get_MemberInfo(){} // RVA: 0x7FFD539474D0
        public void Equals(){} // RVA: 0x7FFD53947620
        public void GetHashCode(){} // RVA: 0x7FFD53947690
        public void op_Equality(){} // RVA: 0x7FFD53947700
        public void op_Inequality(){} // RVA: 0x7FFD53947780
        public void ToString(){} // RVA: 0x7FFD53947800
    }

    public class CustomAttributeTypedArgument : ValueType
    {
        public object ArgumentType;
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53947CA0 | overloaded x2
        public void get_ArgumentType(){} // RVA: 0x7FFD4EEF9F60
        public void get_Value(){} // RVA: 0x7FFD4F840220
        public void Equals(){} // RVA: 0x7FFD53948120
        public void GetHashCode(){} // RVA: 0x7FFD53948180
        public void op_Equality(){} // RVA: 0x7FFD539481E0
        public void op_Inequality(){} // RVA: 0x7FFD53948280
        public void ToString(){} // RVA: 0x7FFD53948330 | overloaded x2
        public void CanonicalizeValue(){} // RVA: 0x7FFD53948AD0
    }

    public class DefaultMemberAttribute : Attribute
    {
        public object MemberName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void get_MemberName(){} // RVA: 0x7FFD4E35C380
    }

    public class EventInfo : MemberInfo
    {
        public object MemberType;
        public object AddMethod;
        public object EventHandlerType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_MemberType(){} // RVA: 0x7FFD4E446CB0
        public void get_AddMethod(){} // RVA: 0x7FFD539103E0
        public void GetAddMethod(){} // RVA: 0x7FFD53868EF0 | overloaded x2
        public void GetRemoveMethod(){} // RVA: 0x7FFD53910400 | overloaded x2
        public void GetRaiseMethod(){}
        public void get_EventHandlerType(){} // RVA: 0x7FFD53910420
        public void RemoveEventHandler(){} // RVA: 0x7FFD539105A0
        public void Equals(){} // RVA: 0x7FFD5072B460
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void op_Equality(){} // RVA: 0x7FFD53681650
        public void op_Inequality(){} // RVA: 0x7FFD539106F0
        public void AddEventHandler(){} // RVA: 0x7FFD53910730
        public void internal_from_handle_type(){} // RVA: 0x7FFD539108F0
        public void GetEventFromHandle(){} // RVA: 0x7FFD53910950
    }

    public class FieldInfo : MemberInfo
    {
        public object MemberType;
        public object Attributes;
        public object FieldType;
        public object IsInitOnly;
        public object IsLiteral;
        public object IsNotSerialized;
        public object IsStatic;
        public object IsAssembly;
        public object IsFamilyAndAssembly;
        public object IsPrivate;
        public object IsPublic;
        public object FieldHandle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_MemberType(){} // RVA: 0x7FFD4EAE3910
        public void get_Attributes(){} // RVA: 0x7FFD4E079960
        public void get_FieldType(){} // RVA: 0x7FFD4E078E90
        public void get_IsInitOnly(){} // RVA: 0x7FFD53910A50
        public void get_IsLiteral(){} // RVA: 0x7FFD53910A80
        public void get_IsNotSerialized(){} // RVA: 0x7FFD53910AB0
        public void get_IsStatic(){} // RVA: 0x7FFD53910AE0
        public void get_IsAssembly(){} // RVA: 0x7FFD53910B10
        public void get_IsFamilyAndAssembly(){} // RVA: 0x7FFD53910B40
        public void get_IsPrivate(){} // RVA: 0x7FFD53910B70
        public void get_IsPublic(){} // RVA: 0x7FFD53910BA0
        public void get_FieldHandle(){}
        public void Equals(){} // RVA: 0x7FFD5072B460
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void op_Equality(){} // RVA: 0x7FFD53681650
        public void op_Inequality(){} // RVA: 0x7FFD539106F0
        public void GetValue(){} // RVA: 0x7FFD4E078F40
        public void SetValue(){} // RVA: 0x7FFD53910BD0 | overloaded x2
        public void SetValueDirect(){} // RVA: 0x7FFD53910C70
        public void GetRawConstantValue(){} // RVA: 0x7FFD53910CC0
        public void internal_from_handle_type(){} // RVA: 0x7FFD53910D10
        public void GetFieldFromHandle(){} // RVA: 0x7FFD53910DF0 | overloaded x2
        public void GetFieldOffset(){} // RVA: 0x7FFD53910EA0
        public void get_marshal_info(){} // RVA: 0x7FFD4E919180
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFD53910EF0
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFD53911100
    }

    public class ICustomAttributeProvider
    {
        // ── Methods ──
        public void GetCustomAttributes(){} // RVA: 0x7FFD4E0896F0 | overloaded x2
        public void IsDefined(){}
    }

    public class IReflectableType
    {
        // ── Methods ──
        public void GetTypeInfo(){} // RVA: 0x7FFD4E078E90
    }

    public class MemberFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD510DD190
        public void Invoke(){} // RVA: 0x7FFD4E49D370
    }

    public class MemberInfo : Object
    {
        public object MemberType;
        public object Name;
        public object DeclaringType;
        public object ReflectedType;
        public object Module;
        public object MetadataToken;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_MemberType(){} // RVA: 0x7FFD4E079960
        public void get_Name(){} // RVA: 0x7FFD4E078E90
        public void get_DeclaringType(){} // RVA: 0x7FFD4E078E90
        public void get_ReflectedType(){} // RVA: 0x7FFD4E078E90
        public void get_Module(){} // RVA: 0x7FFD5393FCC0
        public void IsDefined(){}
        public void GetCustomAttributes(){} // RVA: 0x7FFD4E0896F0 | overloaded x2
        public void GetCustomAttributesData(){} // RVA: 0x7FFD5393FD90
        public void get_MetadataToken(){} // RVA: 0x7FFD5393FDC0
        public void Equals(){} // RVA: 0x7FFD5072B460
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void op_Equality(){} // RVA: 0x7FFD5393FE00
        public void op_Inequality(){} // RVA: 0x7FFD539401B0
    }

    public class MethodBase : MemberInfo
    {
        public object Attributes;
        public object MethodImplementationFlags;
        public object CallingConvention;
        public object IsAbstract;
        public object IsConstructor;
        public object IsSpecialName;
        public object IsStatic;
        public object IsVirtual;
        public object IsAssembly;
        public object IsFamilyAndAssembly;
        public object IsPrivate;
        public object IsPublic;
        public object IsGenericMethod;
        public object IsGenericMethodDefinition;
        public object ContainsGenericParameters;
        public object MethodHandle;
        public object IsSecurityCritical;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void GetParameters(){} // RVA: 0x7FFD4E078E90
        public void get_Attributes(){} // RVA: 0x7FFD4E079960
        public void get_MethodImplementationFlags(){} // RVA: 0x7FFD539401D0
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFD4E079960
        public void GetMethodBody(){} // RVA: 0x7FFD539401F0
        public void get_CallingConvention(){} // RVA: 0x7FFD4E433AF0
        public void get_IsAbstract(){} // RVA: 0x7FFD53940230
        public void get_IsConstructor(){} // RVA: 0x7FFD53940260
        public void get_IsSpecialName(){} // RVA: 0x7FFD53940300
        public void get_IsStatic(){} // RVA: 0x7FFD53940330
        public void get_IsVirtual(){} // RVA: 0x7FFD53940360
        public void get_IsAssembly(){} // RVA: 0x7FFD53940390
        public void get_IsFamilyAndAssembly(){} // RVA: 0x7FFD539403C0
        public void get_IsPrivate(){} // RVA: 0x7FFD539403F0
        public void get_IsPublic(){} // RVA: 0x7FFD53940420
        public void get_IsGenericMethod(){} // RVA: 0x7FFD4E341320
        public void get_IsGenericMethodDefinition(){} // RVA: 0x7FFD4E341320
        public void GetGenericArguments(){} // RVA: 0x7FFD53940450
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFD4E341320
        public void Invoke(){} // RVA: 0x7FFD539404A0 | overloaded x2
        public void get_MethodHandle(){}
        public void get_IsSecurityCritical(){} // RVA: 0x7FFD539404E0
        public void Equals(){} // RVA: 0x7FFD5072B460
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void op_Equality(){} // RVA: 0x7FFD53940510
        public void op_Inequality(){} // RVA: 0x7FFD53940780
        public void GetParametersInternal(){} // RVA: 0x7FFD4EB28F70
        public void GetParametersCount(){} // RVA: 0x7FFD539407A0
        public void FormatNameAndSig(){} // RVA: 0x7FFD539407D0
        public void GetParameterTypes(){} // RVA: 0x7FFD53940930
        public void GetParametersNoCopy(){} // RVA: 0x7FFD4EB28F70
        public void GetMethodFromHandle(){} // RVA: 0x7FFD53940CE0 | overloaded x2
        public void ConstructParameters(){} // RVA: 0x7FFD53940DE0
    }

    public class MethodInfo : MethodBase
    {
        public object MemberType;
        public object ReturnParameter;
        public object ReturnType;
        public object ReturnTypeCustomAttributes;
        public object GenericParameterCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_MemberType(){} // RVA: 0x7FFD4F2F8E80
        public void get_ReturnParameter(){} // RVA: 0x7FFD53941040
        public void get_ReturnType(){} // RVA: 0x7FFD53941070
        public void GetGenericArguments(){} // RVA: 0x7FFD539410A0
        public void GetGenericMethodDefinition(){} // RVA: 0x7FFD539410F0
        public void MakeGenericMethod(){} // RVA: 0x7FFD53941140
        public void GetBaseDefinition(){} // RVA: 0x7FFD4E078E90
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x7FFD4E078E90
        public void CreateDelegate(){} // RVA: 0x7FFD539411E0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD5072B460
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void op_Equality(){} // RVA: 0x7FFD53681650
        public void op_Inequality(){} // RVA: 0x7FFD539106F0
        public void get_GenericParameterCount(){} // RVA: 0x7FFD53941230
    }

    public class Missing : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFD53941260
        public void .cctor(){} // RVA: 0x7FFD539412A0
    }

    public class Module : Object
    {
        public object Assembly;
        public object FullyQualifiedName;
        public object Name;
        public object ModuleVersionId;
        public object ScopeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_Assembly(){} // RVA: 0x7FFD53941340
        public void get_FullyQualifiedName(){} // RVA: 0x7FFD53941370
        public void get_Name(){} // RVA: 0x7FFD539413A0
        public void get_ModuleVersionId(){} // RVA: 0x7FFD539413D0
        public void get_ScopeName(){} // RVA: 0x7FFD53941400
        public void IsResource(){} // RVA: 0x7FFD53941430
        public void IsDefined(){} // RVA: 0x7FFD53941460
        public void GetCustomAttributesData(){} // RVA: 0x7FFD53941490
        public void GetCustomAttributes(){} // RVA: 0x7FFD539414F0 | overloaded x2
        public void ResolveMember(){} // RVA: 0x7FFD53941520
        public void GetObjectData(){} // RVA: 0x7FFD53941550
        public void Equals(){} // RVA: 0x7FFD5072B460
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void op_Equality(){} // RVA: 0x7FFD53681650
        public void ToString(){} // RVA: 0x7FFD4EC45740
        public void FilterTypeNameImpl(){} // RVA: 0x7FFD53941580
        public void FilterTypeNameIgnoreCaseImpl(){} // RVA: 0x7FFD539417F0
        public void GetModuleVersionId(){} // RVA: 0x7FFD53941BB0
        public void .cctor(){} // RVA: 0x7FFD53941BF0
    }

    public class MonoPropertyInfo : ValueType
    {
    }

    public class ObfuscationAttribute : Attribute
    {
        public object Exclude;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53941D80
        public void set_Exclude(){} // RVA: 0x7FFD4EB91D90
    }

    public class ParameterInfo : Object
    {
        public object Attributes;
        public object Member;
        public object Name;
        public object ParameterType;
        public object Position;
        public object IsIn;
        public object IsOptional;
        public object IsOut;
        public object DefaultValue;
        public object HasDefaultValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_Attributes(){} // RVA: 0x7FFD4E38E5C0
        public void get_Member(){} // RVA: 0x7FFD4E36F130
        public void get_Name(){} // RVA: 0x7FFD4E5F95E0
        public void get_ParameterType(){} // RVA: 0x7FFD4E3447C0
        public void get_Position(){} // RVA: 0x7FFD4E9AA870
        public void get_IsIn(){} // RVA: 0x7FFD53941E10
        public void get_IsOptional(){} // RVA: 0x7FFD53941E40
        public void get_IsOut(){} // RVA: 0x7FFD53941E70
        public void get_DefaultValue(){} // RVA: 0x7FFD53941EA0
        public void get_HasDefaultValue(){} // RVA: 0x7FFD53941ED0
        public void IsDefined(){} // RVA: 0x7FFD53941F00
        public void GetCustomAttributesData(){} // RVA: 0x7FFD53941FA0
        public void GetCustomAttributes(){} // RVA: 0x7FFD53942010 | overloaded x2
        public void GetRealObject(){} // RVA: 0x7FFD539420C0
        public void ToString(){} // RVA: 0x7FFD539424A0
    }

    public class PropertyInfo : MemberInfo
    {
        public object MemberType;
        public object PropertyType;
        public object Attributes;
        public object CanRead;
        public object CanWrite;
        public object GetMethod;
        public object SetMethod;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_MemberType(){} // RVA: 0x7FFD5072B540
        public void get_PropertyType(){} // RVA: 0x7FFD4E078E90
        public void GetIndexParameters(){} // RVA: 0x7FFD4E078E90
        public void get_Attributes(){} // RVA: 0x7FFD4E079960
        public void get_CanRead(){} // RVA: 0x7FFD4E079D00
        public void get_CanWrite(){} // RVA: 0x7FFD4E079D00
        public void GetAccessors(){}
        public void get_GetMethod(){} // RVA: 0x7FFD539427F0
        public void GetGetMethod(){} // RVA: 0x7FFD53942810 | overloaded x2
        public void get_SetMethod(){} // RVA: 0x7FFD53942830
        public void GetSetMethod(){} // RVA: 0x7FFD53942850 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFD53942890 | overloaded x3
        public void SetValue(){} // RVA: 0x7FFD53942900 | overloaded x3
        public void Equals(){} // RVA: 0x7FFD5072B460
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void op_Equality(){} // RVA: 0x7FFD53681650
        public void op_Inequality(){} // RVA: 0x7FFD539106F0
    }

    public class RtFieldInfo : FieldInfo
    {
        // ── Methods ──
        public void UnsafeGetValue(){} // RVA: 0x7FFD4E078F40
        public void UnsafeSetValue(){}
        public void CheckConsistency(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class RuntimeAssembly : Assembly
    {
        public object ManifestModule;
        public object ReflectionOnly;
        public object CodeBase;
        public object EscapedCodeBase;
        public object FullName;
        public object MonoAssembly;
        public object Location;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53950B90
        public void GetObjectData(){} // RVA: 0x7FFD53950C20
        public void LoadWithPartialNameInternal(){} // RVA: 0x7FFD53950D50 | overloaded x2
        public void GetName(){} // RVA: 0x7FFD53950DA0
        public void GetType(){} // RVA: 0x7FFD53950E70
        public void GetModule(){} // RVA: 0x7FFD53950F40
        public void GetReferencedAssemblies(){} // RVA: 0x7FFD539510C0
        public void GetModules(){} // RVA: 0x7FFD539510D0
        public void get_ManifestModule(){} // RVA: 0x7FFD53951220
        public void GetAotId(){} // RVA: 0x7FFD53951240
        public void get_code_base(){} // RVA: 0x7FFD53951280
        public void get_location(){} // RVA: 0x7FFD53951380
        public void get_fullname(){} // RVA: 0x7FFD53951410
        public void GetAotIdInternal(){} // RVA: 0x7FFD4E341320
        public void get_ReflectionOnly(){} // RVA: 0x7FFD4E341320
        public void GetCodeBase(){} // RVA: 0x7FFD53951280
        public void get_CodeBase(){} // RVA: 0x7FFD539514A0
        public void get_EscapedCodeBase(){} // RVA: 0x7FFD539514B0
        public void get_FullName(){} // RVA: 0x7FFD53951410
        public void get_MonoAssembly(){} // RVA: 0x7FFD4E35C380
        public void get_Location(){} // RVA: 0x7FFD539514C0
        public void GetManifestResourceInfoInternal(){} // RVA: 0x7FFD53951590
        public void GetManifestResourceInfo(){} // RVA: 0x7FFD539515A0
        public void GetManifestResourceNames(){} // RVA: 0x7FFD53951770
        public void GetManifestResourceInternal(){} // RVA: 0x7FFD539518F0
        public void GetManifestResourceStream(){} // RVA: 0x7FFD53951900
        public void IsDefined(){} // RVA: 0x7FFD53951EA0
        public void GetCustomAttributes(){} // RVA: 0x7FFD53951F70 | overloaded x2
        public void GetManifestModule(){} // RVA: 0x7FFD53951FE0
        public void GetManifestModuleInternal(){} // RVA: 0x7FFD53951FF0
        public void GetModulesInternal(){} // RVA: 0x7FFD53952000
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void Equals(){} // RVA: 0x7FFD539520A0
        public void ToString(){} // RVA: 0x7FFD53952160
    }

    public class RuntimeConstructorInfo : ConstructorInfo
    {
        public object Module;
        public object BindingFlags;
        public object ReflectedTypeInternal;
        public object MethodHandle;
        public object Attributes;
        public object CallingConvention;
        public object ContainsGenericParameters;
        public object ReflectedType;
        public object DeclaringType;
        public object Name;
        public object IsSecurityCritical;
        public object MetadataToken;

        // ── Methods ──
        public void get_Module(){} // RVA: 0x7FFD53956A20
        public void GetRuntimeModule(){} // RVA: 0x7FFD53956A20
        public void get_BindingFlags(){} // RVA: 0x7FFD4E919180
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFD53956AC0
        public void GetObjectData(){} // RVA: 0x7FFD53956B50
        public void SerializationToString(){} // RVA: 0x7FFD53956CD0
        public void SerializationInvoke(){} // RVA: 0x7FFD53956CF0
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFD53954AF0
        public void GetParameters(){} // RVA: 0x7FFD53954BD0
        public void GetParametersInternal(){} // RVA: 0x7FFD53954BD0
        public void GetParametersCount(){} // RVA: 0x7FFD53956E50
        public void InternalInvoke(){} // RVA: 0x7FFD53957280 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFD53957370 | overloaded x2
        public void DoInvoke(){} // RVA: 0x7FFD53956FF0
        public void get_MethodHandle(){} // RVA: 0x7FFD4E35C380
        public void get_Attributes(){} // RVA: 0x7FFD539552D0
        public void get_CallingConvention(){} // RVA: 0x7FFD539552E0
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFD539573A0
        public void get_ReflectedType(){} // RVA: 0x7FFD4E36F0C0
        public void get_DeclaringType(){} // RVA: 0x7FFD53955300
        public void get_Name(){} // RVA: 0x7FFD53955320
        public void IsDefined(){} // RVA: 0x7FFD539573E0
        public void GetCustomAttributes(){} // RVA: 0x7FFD539574B0 | overloaded x2
        public void GetMethodBody(){} // RVA: 0x7FFD53956A10
        public void ToString(){} // RVA: 0x7FFD53957520
        public void GetCustomAttributesData(){} // RVA: 0x7FFD53952D70
        public void get_core_clr_security_level(){} // RVA: 0x7FFD4E433AF0
        public void get_IsSecurityCritical(){} // RVA: 0x7FFD4E426850
        public void get_MetadataToken(){} // RVA: 0x7FFD53952D80
        public void get_metadata_token(){} // RVA: 0x7FFD53952D80
        public void .ctor(){} // RVA: 0x7FFD53957580
    }

    public class RuntimeEventInfo : EventInfo
    {
        public object Module;
        public object BindingFlags;
        public object ReflectedTypeInternal;
        public object DeclaringType;
        public object ReflectedType;
        public object Name;
        public object MetadataToken;

        // ── Methods ──
        public void get_event_info(){} // RVA: 0x7FFD53952350
        public void GetEventInfo(){} // RVA: 0x7FFD53952460
        public void get_Module(){} // RVA: 0x7FFD53952580
        public void get_BindingFlags(){} // RVA: 0x7FFD539525B0
        public void GetDeclaringTypeInternal(){} // RVA: 0x7FFD539525C0
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFD53952650
        public void GetRuntimeModule(){} // RVA: 0x7FFD53952580
        public void GetObjectData(){} // RVA: 0x7FFD539526E0
        public void GetBindingFlags(){} // RVA: 0x7FFD53952820
        public void GetAddMethod(){} // RVA: 0x7FFD539529B0
        public void GetRaiseMethod(){} // RVA: 0x7FFD53952A30
        public void GetRemoveMethod(){} // RVA: 0x7FFD53952AB0
        public void get_DeclaringType(){} // RVA: 0x7FFD53952B30
        public void get_ReflectedType(){} // RVA: 0x7FFD53952B50
        public void get_Name(){} // RVA: 0x7FFD53952B70
        public void ToString(){} // RVA: 0x7FFD53952B90
        public void IsDefined(){} // RVA: 0x7FFD53952C30
        public void GetCustomAttributes(){} // RVA: 0x7FFD53952D00 | overloaded x2
        public void GetCustomAttributesData(){} // RVA: 0x7FFD53952D70
        public void get_MetadataToken(){} // RVA: 0x7FFD53952D80
        public void get_metadata_token(){} // RVA: 0x7FFD53952D80
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class RuntimeFieldInfo : RtFieldInfo
    {
        public object BindingFlags;
        public object Module;
        public object ReflectedTypeInternal;
        public object Attributes;
        public object FieldHandle;
        public object FieldType;
        public object ReflectedType;
        public object DeclaringType;
        public object Name;
        public object MetadataToken;

        // ── Methods ──
        public void get_BindingFlags(){} // RVA: 0x7FFD4E919180
        public void get_Module(){} // RVA: 0x7FFD53952DA0
        public void GetDeclaringTypeInternal(){} // RVA: 0x7FFD53952DD0
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFD53952E60
        public void GetRuntimeModule(){} // RVA: 0x7FFD53952DA0
        public void GetObjectData(){} // RVA: 0x7FFD53952EF0
        public void UnsafeGetValue(){} // RVA: 0x7FFD53953050
        public void CheckConsistency(){} // RVA: 0x7FFD53953060
        public void UnsafeSetValue(){} // RVA: 0x7FFD53953220
        public void SetValueDirect(){} // RVA: 0x7FFD53953270
        public void get_Attributes(){} // RVA: 0x7FFD4E39CCD0
        public void get_FieldHandle(){} // RVA: 0x7FFD4E3447C0
        public void ResolveType(){} // RVA: 0x7FFD53953400
        public void get_FieldType(){} // RVA: 0x7FFD53953410
        public void GetParentType(){} // RVA: 0x7FFD53953480
        public void get_ReflectedType(){} // RVA: 0x7FFD539534B0
        public void get_DeclaringType(){} // RVA: 0x7FFD539534C0
        public void get_Name(){} // RVA: 0x7FFD4E36F0C0
        public void IsDefined(){} // RVA: 0x7FFD539534E0
        public void GetCustomAttributes(){} // RVA: 0x7FFD539535B0 | overloaded x2
        public void GetFieldOffset(){} // RVA: 0x7FFD53953620
        public void GetValueInternal(){} // RVA: 0x7FFD53953050
        public void GetValue(){} // RVA: 0x7FFD53953630
        public void ToString(){} // RVA: 0x7FFD53953800
        public void SetValueInternal(){} // RVA: 0x7FFD539538A0
        public void SetValue(){} // RVA: 0x7FFD539538B0
        public void GetRawConstantValue(){} // RVA: 0x7FFD53953BC0
        public void GetCustomAttributesData(){} // RVA: 0x7FFD53952D70
        public void CheckGeneric(){} // RVA: 0x7FFD53953D30
        public void get_MetadataToken(){} // RVA: 0x7FFD53952D80
        public void get_metadata_token(){} // RVA: 0x7FFD53952D80
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class RuntimeMethodInfo : MethodInfo
    {
        public object BindingFlags;
        public object Module;
        public object ReflectedTypeInternal;
        public object ReturnParameter;
        public object ReturnType;
        public object ReturnTypeCustomAttributes;
        public object MetadataToken;
        public object MethodHandle;
        public object Attributes;
        public object CallingConvention;
        public object ReflectedType;
        public object DeclaringType;
        public object Name;
        public object IsGenericMethodDefinition;
        public object IsGenericMethod;
        public object ContainsGenericParameters;
        public object IsSecurityCritical;

        // ── Methods ──
        public void get_BindingFlags(){} // RVA: 0x7FFD4E919180
        public void get_Module(){} // RVA: 0x7FFD53954230
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFD539542D0
        public void FormatNameAndSig(){} // RVA: 0x7FFD53954360
        public void CreateDelegate(){} // RVA: 0x7FFD53954670 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD539546A0
        public void GetRuntimeModule(){} // RVA: 0x7FFD53954230
        public void GetObjectData(){} // RVA: 0x7FFD53954750
        public void SerializationToString(){} // RVA: 0x7FFD53954920
        public void GetMethodFromHandleNoGenericCheck(){} // RVA: 0x7FFD539549E0 | overloaded x2
        public void GetMethodBodyInternal(){} // RVA: 0x7FFD53954A30
        public void GetMethodBody(){} // RVA: 0x7FFD53956A10 | overloaded x2
        public void GetMethodFromHandleInternalType(){} // RVA: 0x7FFD53954A50
        public void GetMethodFromHandleInternalType_native(){} // RVA: 0x7FFD53954A60
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_name(){} // RVA: 0x7FFD53954A70
        public void get_base_method(){} // RVA: 0x7FFD53954A90
        public void get_metadata_token(){} // RVA: 0x7FFD53952D80
        public void GetBaseDefinition(){} // RVA: 0x7FFD53954AA0
        public void GetBaseMethod(){} // RVA: 0x7FFD53954AB0
        public void get_ReturnParameter(){} // RVA: 0x7FFD539541F0
        public void get_ReturnType(){} // RVA: 0x7FFD53954AC0
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x7FFD539541F0
        public void get_MetadataToken(){} // RVA: 0x7FFD53952D80
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFD53954AF0
        public void GetParameters(){} // RVA: 0x7FFD53954B20
        public void GetParametersInternal(){} // RVA: 0x7FFD53954BD0
        public void GetParametersCount(){} // RVA: 0x7FFD53954C20
        public void InternalInvoke(){} // RVA: 0x7FFD53954C70
        public void Invoke(){} // RVA: 0x7FFD53954C80
        public void ConvertValues(){} // RVA: 0x7FFD53954F70
        public void get_MethodHandle(){} // RVA: 0x7FFD4E35C380
        public void get_Attributes(){} // RVA: 0x7FFD539552D0
        public void get_CallingConvention(){} // RVA: 0x7FFD539552E0
        public void get_ReflectedType(){} // RVA: 0x7FFD4E36F0C0
        public void get_DeclaringType(){} // RVA: 0x7FFD53955300
        public void get_Name(){} // RVA: 0x7FFD53955320
        public void IsDefined(){} // RVA: 0x7FFD53955350
        public void GetCustomAttributes(){} // RVA: 0x7FFD53955420 | overloaded x2
        public void GetPInvoke(){} // RVA: 0x7FFD53955490
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFD53955540
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFD539556F0
        public void GetDllImportAttributeData(){} // RVA: 0x7FFD53955940
        public void MakeGenericMethod(){} // RVA: 0x7FFD539564A0
        public void MakeGenericMethod_impl(){} // RVA: 0x7FFD53956810
        public void GetGenericArguments(){} // RVA: 0x7FFD53956820
        public void GetGenericMethodDefinition_impl(){} // RVA: 0x7FFD53956830
        public void GetGenericMethodDefinition(){} // RVA: 0x7FFD53956860
        public void get_IsGenericMethodDefinition(){} // RVA: 0x7FFD539568E0
        public void get_IsGenericMethod(){} // RVA: 0x7FFD539568F0
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFD53956920
        public void GetCustomAttributesData(){} // RVA: 0x7FFD53952D70
        public void get_core_clr_security_level(){} // RVA: 0x7FFD4E433AF0
        public void get_IsSecurityCritical(){} // RVA: 0x7FFD4E426850
    }

    public class RuntimeModule : Module
    {
        public object Assembly;
        public object Name;
        public object ScopeName;
        public object ModuleVersionId;
        public object FullyQualifiedName;

        // ── Methods ──
        public void get_Assembly(){} // RVA: 0x7FFD4E3447C0
        public void get_Name(){} // RVA: 0x7FFD4E36F130
        public void get_ScopeName(){} // RVA: 0x7FFD4E5F95E0
        public void get_ModuleVersionId(){} // RVA: 0x7FFD539575D0
        public void get_FullyQualifiedName(){} // RVA: 0x7FFD4E36F0C0
        public void IsResource(){} // RVA: 0x7FFD4E5F95D0
        public void GetCustomAttributes(){} // RVA: 0x7FFD53957660 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFD539576D0
        public void ResolveMember(){} // RVA: 0x7FFD53957770 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFD539577D0
        public void GetCustomAttributesData(){} // RVA: 0x7FFD5394F290
        public void GetRuntimeAssembly(){} // RVA: 0x7FFD539578E0
        public void GetModuleVersionId(){} // RVA: 0x7FFD53957960
        public void resolve_token_exception(){} // RVA: 0x7FFD53957A60
        public void ptrs_from_types(){} // RVA: 0x7FFD53957C20
        public void GetGuidInternal(){} // RVA: 0x7FFD4E341310
        public void ResolveMemberToken(){} // RVA: 0x7FFD53957D70
        public void .ctor(){} // RVA: 0x7FFD53957D90
    }

    public class RuntimeParameterInfo : ParameterInfo
    {
        public object DefaultValue;
        public object HasDefaultValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53958530 | overloaded x3
        public void FormatParameters(){} // RVA: 0x7FFD53957FB0
        public void get_DefaultValue(){} // RVA: 0x7FFD539586B0
        public void GetCustomAttributes(){} // RVA: 0x7FFD53958A80 | overloaded x2
        public void GetDefaultValueImpl(){} // RVA: 0x7FFD53958AF0
        public void IsDefined(){} // RVA: 0x7FFD53958C10
        public void GetCustomAttributesData(){} // RVA: 0x7FFD5394F390
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFD53958C80
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFD53958F90
        public void get_HasDefaultValue(){} // RVA: 0x7FFD53959650
        public void New(){} // RVA: 0x7FFD539597E0 | overloaded x2
    }

    public class RuntimePropertyInfo : PropertyInfo
    {
        public object BindingFlags;
        public object Module;
        public object ReflectedTypeInternal;
        public object Attributes;
        public object CanRead;
        public object CanWrite;
        public object PropertyType;
        public object ReflectedType;
        public object DeclaringType;
        public object Name;
        public object MetadataToken;

        // ── Methods ──
        public void get_property_info(){} // RVA: 0x7FFD53959990
        public void get_BindingFlags(){} // RVA: 0x7FFD4E919180
        public void get_Module(){} // RVA: 0x7FFD539599A0
        public void GetDeclaringTypeInternal(){} // RVA: 0x7FFD53959A40
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFD53959AD0
        public void GetRuntimeModule(){} // RVA: 0x7FFD539599A0
        public void ToString(){} // RVA: 0x7FFD53959B60
        public void FormatNameAndSig(){} // RVA: 0x7FFD53959B70
        public void GetObjectData(){} // RVA: 0x7FFD53959D30
        public void SerializationToString(){} // RVA: 0x7FFD53959EB0
        public void CachePropertyInfo(){} // RVA: 0x7FFD53959EC0
        public void get_Attributes(){} // RVA: 0x7FFD53959F00
        public void get_CanRead(){} // RVA: 0x7FFD53959F40
        public void get_CanWrite(){} // RVA: 0x7FFD53959F70
        public void get_PropertyType(){} // RVA: 0x7FFD53959FA0
        public void get_ReflectedType(){} // RVA: 0x7FFD5395A050
        public void get_DeclaringType(){} // RVA: 0x7FFD5395A090
        public void get_Name(){} // RVA: 0x7FFD5395A0D0
        public void GetAccessors(){} // RVA: 0x7FFD5395A110
        public void GetGetMethod(){} // RVA: 0x7FFD5395A2A0
        public void GetIndexParameters(){} // RVA: 0x7FFD5395A310
        public void GetSetMethod(){} // RVA: 0x7FFD5395A580
        public void IsDefined(){} // RVA: 0x7FFD5395A5F0
        public void GetCustomAttributes(){} // RVA: 0x7FFD5395A6C0 | overloaded x2
        public void GetterAdapterFrame(){} // RVA: 0x7FFD4E078FF0
        public void StaticGetterAdapterFrame(){} // RVA: 0x7FFD4E078FF0
        public void GetValue(){} // RVA: 0x7FFD5395A730 | overloaded x2
        public void SetValue(){} // RVA: 0x7FFD5395A8E0
        public void GetCustomAttributesData(){} // RVA: 0x7FFD53952D70
        public void get_MetadataToken(){} // RVA: 0x7FFD53952D80
        public void get_metadata_token(){} // RVA: 0x7FFD53952D80
        public void internal_from_handle_type(){} // RVA: 0x7FFD5395AB00
        public void GetPropertyFromHandle(){} // RVA: 0x7FFD5395AB60
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TypeInfo : Type
    {
        public object DeclaredFields;
        public object ImplementedInterfaces;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53946700
        public void System.Reflection.IReflectableType.GetTypeInfo(){} // RVA: 0x7FFD4F9181E0
        public void GetDeclaredMethods(){} // RVA: 0x7FFD53946750
        public void get_DeclaredFields(){} // RVA: 0x7FFD53946860
        public void get_ImplementedInterfaces(){} // RVA: 0x7FFD53946880
    }

}