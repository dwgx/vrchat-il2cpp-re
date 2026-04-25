// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection
// Classes: 79
// Methods: 955

namespace ThirdParty.DotNet.System.Reflection
{
    public class AmbiguousMatchException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x3
    }

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
        public void get_CodeBase(){} // RVA: 0x7FFAC852A650
        public void get_EscapedCodeBase(){} // RVA: 0x7FFAC852A690
        public void get_FullName(){} // RVA: 0x7FFAC852A6D0
        public void get_MonoAssembly(){} // RVA: 0x7FFAC852A710
        public void get_Location(){} // RVA: 0x7FFAC852A750
        public void GetObjectData(){} // RVA: 0x7FFAC852A790
        public void IsDefined(){} // RVA: 0x7FFAC852A7D0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC852A850 | overloaded x2
        public void GetManifestResourceStream(){} // RVA: 0x7FFAC852AA90 | overloaded x3
        public void GetSimpleName(){} // RVA: 0x7FFAC852AAC0
        public void GetPublicKey(){} // RVA: 0x7FFAC852AAF0
        public void GetVersion(){} // RVA: 0x7FFAC852AB20
        public void GetFlags(){} // RVA: 0x7FFAC852AB50
        public void GetTypes(){} // RVA: 0x7FFAC852AB90 | overloaded x2
        public void GetType(){} // RVA: 0x7FFAC852BD40 | overloaded x3
        public void InternalGetType(){} // RVA: 0x7FFAC852AC10
        public void GetName(){} // RVA: 0x7FFAC852AC60 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC852AC80
        public void GetAssembly(){} // RVA: 0x7FFAC852ACC0
        public void GetEntryAssembly(){} // RVA: 0x7FFAC34F9180
        public void InternalGetSatelliteAssembly(){} // RVA: 0x7FFAC852AD70
        public void LoadFrom(){} // RVA: 0x7FFAC852B2D0
        public void Load(){} // RVA: 0x7FFAC84A1C80
        public void ReflectionOnlyLoad(){} // RVA: 0x7FFAC852B2E0
        public void LoadWithPartialName(){} // RVA: 0x7FFAC852B550 | overloaded x3
        public void load_with_partial_name(){} // RVA: 0x7FFAC852B440
        public void GetModules(){} // RVA: 0x7FFAC852BDD0 | overloaded x2
        public void GetModulesInternal(){} // RVA: 0x7FFAC852B710
        public void GetExecutingAssembly(){} // RVA: 0x7FFAC852B750
        public void GetCallingAssembly(){} // RVA: 0x7FFAC852B790
        public void InternalGetReferencedAssemblies(){} // RVA: 0x7FFAC852B800
        public void GetManifestResourceNames(){} // RVA: 0x7FFAC852B810
        public void GetReferencedAssemblies(){} // RVA: 0x7FFAC852BDA0 | overloaded x2
        public void GetManifestResourceInfo(){} // RVA: 0x7FFAC852BC10
        public void GetManifestModule(){} // RVA: 0x7FFAC852BC50
        public void get_ReflectionOnly(){} // RVA: 0x7FFAC852BC90
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void CreateNIE(){} // RVA: 0x7FFAC852BCD0
        public void get_IsFullyTrusted(){} // RVA: 0x7FFAC3006850
        public void GetModule(){} // RVA: 0x7FFAC852BD70
        public void get_ManifestModule(){} // RVA: 0x7FFAC852BE00
        public void get_IsDynamic(){} // RVA: 0x7FFAC2F21320
        public void op_Equality(){} // RVA: 0x7FFAC852BE30
        public void op_Inequality(){} // RVA: 0x7FFAC852BE90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AssemblyCompanyAttribute : Attribute
    {
        public string <Company>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AssemblyConfigurationAttribute : Attribute
    {
        public string <Configuration>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AssemblyCopyrightAttribute : Attribute
    {
        public string <Copyright>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AssemblyDefaultAliasAttribute : Attribute
    {
        public string <DefaultAlias>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AssemblyDelaySignAttribute : Attribute
    {
        public bool <DelaySign>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
    }

    public class AssemblyDescriptionAttribute : Attribute
    {
        public string <Description>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AssemblyFileVersionAttribute : Attribute
    {
        public string <Version>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84F0080
    }

    public class AssemblyInformationalVersionAttribute : Attribute
    {
        public string InformationalVersion; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_InformationalVersion(){} // RVA: 0x7FFAC2F3C380
    }

    public class AssemblyKeyFileAttribute : Attribute
    {
        public string <KeyFile>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AssemblyMetadataAttribute : Attribute
    {
        public string Key; // 0x10
        public string Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void get_Key(){} // RVA: 0x7FFAC2F3C380
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
    }

    public class AssemblyName : Object
    {
        public string Name; // 0x10
        public string CultureInfo; // 0x18
        public int Flags; // 0x20
        public int FullName; // 0x24
        public int Version; // 0x28
        public int IsPublicKeyValid; // 0x2C
        public System.Globalization.CultureInfo cultureinfo; // 0x30
        public 0x6B0D85C8 flags; // 0x38
        public 0x6B0DD378 hashalg; // 0x3C
        public System.Reflection.StrongNameKeyPair keypair; // 0x40
        public byte[] publicKey; // 0x48
        public byte[] keyToken; // 0x50
        public 0x6B0DD3D0 versioncompat; // 0x58
        public System.Version version; // 0x60
        public 0x6B0D9228 processor_architecture; // 0x68
        public 0x6B0D82B0 contentType; // 0x6C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC852C1A0 | overloaded x3
        public void ParseAssemblyName(){} // RVA: 0x7FFAC852BF00
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_CultureInfo(){} // RVA: 0x7FFAC31D95E0
        public void set_CultureInfo(){} // RVA: 0x7FFAC2F4F890
        public void get_Flags(){} // RVA: 0x7FFAC358A870
        public void set_Flags(){} // RVA: 0x7FFAC3588350
        public void get_FullName(){} // RVA: 0x7FFAC852CB70
        public void get_Version(){} // RVA: 0x7FFAC2FBF370
        public void set_Version(){} // RVA: 0x7FFAC852D090
        public void ToString(){} // RVA: 0x7FFAC852D120
        public void GetPublicKey(){} // RVA: 0x7FFAC2F9C730
        public void GetPublicKeyToken(){} // RVA: 0x7FFAC852D170
        public void get_IsPublicKeyValid(){} // RVA: 0x7FFAC852D270
        public void InternalGetPublicKeyToken(){} // RVA: 0x7FFAC852D320
        public void get_public_token(){} // RVA: 0x7FFAC852D410
        public void ComputePublicKeyToken(){} // RVA: 0x7FFAC852D480
        public void SetPublicKey(){} // RVA: 0x7FFAC852D570
        public void GetObjectData(){} // RVA: 0x7FFAC852D5E0
        public void Clone(){} // RVA: 0x7FFAC852D980
        public void OnDeserialization(){} // RVA: 0x7FFAC852DC40
        public void GetNativeName(){} // RVA: 0x7FFAC852DCD0
        public void FillName(){} // RVA: 0x7FFAC852DE10
        public void Create(){} // RVA: 0x7FFAC852E470
    }

    public class AssemblyProductAttribute : Attribute
    {
        public string <Product>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AssemblyTitleAttribute : Attribute
    {
        public string <Title>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AssemblyTrademarkAttribute : Attribute
    {
        public string <Trademark>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class Binder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void BindToField(){} // RVA: 0x7FFAC2C69250
        public void BindToMethod(){}
        public void ChangeType(){} // RVA: 0x7FFAC2C6AE80
        public void ReorderArgumentArray(){} // RVA: 0x7FFAC2C79B30
        public void SelectMethod(){} // RVA: 0x7FFAC2C69250
        public void SelectProperty(){}
    }

    public class BlobUtilities : Object
    {
        // ── Methods ──
        public void ReadBytes(){} // RVA: 0x7FFAC8A6B9A0
    }

    public class ConstructorInfo : MethodBase
    {
        public string MemberType;
        public string TypeConstructorName; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_MemberType(){} // RVA: 0x7FFAC3013AF0
        public void Invoke(){} // RVA: 0x7FFAC2C69250 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void op_Equality(){} // RVA: 0x7FFAC8261650
        public void op_Inequality(){} // RVA: 0x7FFAC84F0170
        public void .cctor(){} // RVA: 0x7FFAC84F0210
    }

    public class CustomAttributeData : Object
    {
        public System.Reflection.ConstructorInfo Constructor; // 0x10
        public System.Collections.Generic.IList`1<System.Reflection.CustomAttributeTypedArgument> ConstructorArguments; // 0x18
        public System.Collections.Generic.IList`1<System.Reflection.CustomAttributeNamedArgument> NamedArguments; // 0x20
        public LazyCAttrData AttributeType; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00 | overloaded x4
        public void ResolveArgumentsInternal(){} // RVA: 0x7FFAC852E780
        public void ResolveArguments(){} // RVA: 0x7FFAC852E890
        public void get_Constructor(){} // RVA: 0x7FFAC2F3C380
        public void get_ConstructorArguments(){} // RVA: 0x7FFAC852EF50
        public void get_NamedArguments(){} // RVA: 0x7FFAC852EF70
        public void GetCustomAttributes(){} // RVA: 0x7FFAC852F390 | overloaded x4
        public void GetCustomAttributesInternal(){} // RVA: 0x7FFAC852F190
        public void get_AttributeType(){} // RVA: 0x7FFAC84AA500
        public void ToString(){} // RVA: 0x7FFAC852F490
        public void UnboxValues(){} // RVA: 0x7FFAC2C58F80
        public void Equals(){} // RVA: 0x7FFAC852FB80
        public void GetHashCode(){} // RVA: 0x7FFAC8530110
    }

    public class CustomAttributeExtensions : Object
    {
        // ── Methods ──
        public void GetCustomAttribute(){} // RVA: 0x7FFAC2E8DC40 | overloaded x6
        public void GetCustomAttributes(){} // RVA: 0x7FFAC2C69730 | overloaded x7
        public void IsDefined(){} // RVA: 0x7FFAC8528D40
    }

    public class CustomAttributeFormatException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC44F7540 | overloaded x4
    }

    public class CustomAttributeNamedArgument : ValueType
    {
        public System.Reflection.CustomAttributeTypedArgument TypedValue; // 0x10
        public bool IsField; // 0x20
        public string MemberName; // 0x28
        public System.Type MemberInfo; // 0x30
        public System.Reflection.MemberInfo _lazyMemberInfo; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8527320 | overloaded x3
        public void get_TypedValue(){} // RVA: 0x7FFAC32C0590
        public void get_IsField(){} // RVA: 0x7FFAC2FEB5E0
        public void get_MemberName(){} // RVA: 0x7FFAC2F247C0
        public void get_MemberInfo(){} // RVA: 0x7FFAC85274D0
        public void Equals(){} // RVA: 0x7FFAC8527620
        public void GetHashCode(){} // RVA: 0x7FFAC8527690
        public void op_Equality(){} // RVA: 0x7FFAC8527700
        public void op_Inequality(){} // RVA: 0x7FFAC8527780
        public void ToString(){} // RVA: 0x7FFAC8527800
    }

    public class CustomAttributeTypedArgument : ValueType
    {
        public System.Type ArgumentType; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8527CA0 | overloaded x2
        public void get_ArgumentType(){} // RVA: 0x7FFAC3AD9F60
        public void get_Value(){} // RVA: 0x7FFAC4420220
        public void Equals(){} // RVA: 0x7FFAC8528120
        public void GetHashCode(){} // RVA: 0x7FFAC8528180
        public void op_Equality(){} // RVA: 0x7FFAC85281E0
        public void op_Inequality(){} // RVA: 0x7FFAC8528280
        public void ToString(){} // RVA: 0x7FFAC8528330 | overloaded x2
        public void CanonicalizeValue(){} // RVA: 0x7FFAC8528AD0
    }

    public class DefaultMemberAttribute : Attribute
    {
        public string MemberName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_MemberName(){} // RVA: 0x7FFAC2F3C380
    }

    public class EventInfo : MemberInfo
    {
        public AddEventAdapter MemberType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_MemberType(){} // RVA: 0x7FFAC3026CB0
        public void get_AddMethod(){} // RVA: 0x7FFAC84F03E0
        public void GetAddMethod(){} // RVA: 0x7FFAC8448EF0 | overloaded x2
        public void GetRemoveMethod(){} // RVA: 0x7FFAC84F0400 | overloaded x2
        public void GetRaiseMethod(){}
        public void get_EventHandlerType(){} // RVA: 0x7FFAC84F0420
        public void RemoveEventHandler(){} // RVA: 0x7FFAC84F05A0
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void op_Equality(){} // RVA: 0x7FFAC8261650
        public void op_Inequality(){} // RVA: 0x7FFAC84F06F0
        public void AddEventHandler(){} // RVA: 0x7FFAC84F0730
        public void internal_from_handle_type(){} // RVA: 0x7FFAC84F08F0
        public void GetEventFromHandle(){} // RVA: 0x7FFAC84F0950
    }

    public class ExceptionHandlingClause : Object
    {
        public System.Type catch_type; // 0x10
        public int filter_offset; // 0x18
        public 0x6B0D8A40 flags; // 0x1C
        public int try_offset; // 0x20
        public int try_length; // 0x24
        public int handler_offset; // 0x28
        public int handler_length; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ToString(){} // RVA: 0x7FFAC85305B0
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
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_MemberType(){} // RVA: 0x7FFAC36C3910
        public void get_Attributes(){} // RVA: 0x7FFAC2C59960
        public void get_FieldType(){} // RVA: 0x7FFAC2C58E90
        public void get_IsInitOnly(){} // RVA: 0x7FFAC84F0A50
        public void get_IsLiteral(){} // RVA: 0x7FFAC84F0A80
        public void get_IsNotSerialized(){} // RVA: 0x7FFAC84F0AB0
        public void get_IsStatic(){} // RVA: 0x7FFAC84F0AE0
        public void get_IsAssembly(){} // RVA: 0x7FFAC84F0B10
        public void get_IsFamilyAndAssembly(){} // RVA: 0x7FFAC84F0B40
        public void get_IsPrivate(){} // RVA: 0x7FFAC84F0B70
        public void get_IsPublic(){} // RVA: 0x7FFAC84F0BA0
        public void get_FieldHandle(){}
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void op_Equality(){} // RVA: 0x7FFAC8261650
        public void op_Inequality(){} // RVA: 0x7FFAC84F06F0
        public void GetValue(){} // RVA: 0x7FFAC2C58F40
        public void SetValue(){} // RVA: 0x7FFAC84F0BD0 | overloaded x2
        public void SetValueDirect(){} // RVA: 0x7FFAC84F0C70
        public void GetRawConstantValue(){} // RVA: 0x7FFAC84F0CC0
        public void internal_from_handle_type(){} // RVA: 0x7FFAC84F0D10
        public void GetFieldFromHandle(){} // RVA: 0x7FFAC84F0DF0 | overloaded x2
        public void GetFieldOffset(){} // RVA: 0x7FFAC84F0EA0
        public void get_marshal_info(){} // RVA: 0x7FFAC34F9180
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFAC84F0EF0
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFAC84F1100
    }

    public class ICustomAttributeProvider
    {
        // ── Methods ──
        public void GetCustomAttributes(){} // RVA: 0x7FFAC2C696F0 | overloaded x2
        public void IsDefined(){}
    }

    public class IReflectableType
    {
        // ── Methods ──
        public void GetTypeInfo(){} // RVA: 0x7FFAC2C58E90
    }

    public class IntrospectionExtensions : Object
    {
        // ── Methods ──
        public void GetTypeInfo(){} // RVA: 0x7FFAC851FA00
    }

    public class InvalidFilterCriteriaException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850A3C0 | overloaded x4
    }

    public class LocalVariableInfo : Object
    {
        public System.Type LocalType; // 0x10
        public bool is_pinned; // 0x18
        public ushort position; // 0x1A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_LocalType(){} // RVA: 0x7FFAC2F3C380
        public void ToString(){} // RVA: 0x7FFAC8530950
    }

    public class ManifestResourceInfo : Object
    {
        public System.Reflection.Assembly ReferencedAssembly; // 0x10
        public string FileName; // 0x18
        public 0x6B0D9388 ResourceLocation; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC7E02DD0
        public void get_ReferencedAssembly(){} // RVA: 0x7FFAC2F3C380
        public void get_FileName(){} // RVA: 0x7FFAC2F247C0
        public void get_ResourceLocation(){} // RVA: 0x7FFAC30DBBE0
    }

    public class MemberFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5CBD190
        public void Invoke(){} // RVA: 0x7FFAC307D370
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
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_MemberType(){} // RVA: 0x7FFAC2C59960
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_DeclaringType(){} // RVA: 0x7FFAC2C58E90
        public void get_ReflectedType(){} // RVA: 0x7FFAC2C58E90
        public void get_Module(){} // RVA: 0x7FFAC851FCC0
        public void IsDefined(){}
        public void GetCustomAttributes(){} // RVA: 0x7FFAC2C696F0 | overloaded x2
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC851FD90
        public void get_MetadataToken(){} // RVA: 0x7FFAC851FDC0
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void op_Equality(){} // RVA: 0x7FFAC851FE00
        public void op_Inequality(){} // RVA: 0x7FFAC85201B0
    }

    public class MemberInfoSerializationHolder : Object
    {
        public string m_memberName; // 0x10
        public System.RuntimeType m_reflectedType; // 0x18
        public string m_signature; // 0x20
        public string m_signature2; // 0x28
        public 0x6B0D8E08 m_memberType; // 0x30
        public System.Runtime.Serialization.SerializationInfo m_info; // 0x38

        // ── Methods ──
        public void GetSerializationInfo(){} // RVA: 0x7FFAC8528D80 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC8529480
        public void GetObjectData(){} // RVA: 0x7FFAC8529800
        public void GetRealObject(){} // RVA: 0x7FFAC8529860
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
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetParameters(){} // RVA: 0x7FFAC2C58E90
        public void get_Attributes(){} // RVA: 0x7FFAC2C59960
        public void get_MethodImplementationFlags(){} // RVA: 0x7FFAC85201D0
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFAC2C59960
        public void GetMethodBody(){} // RVA: 0x7FFAC85201F0
        public void get_CallingConvention(){} // RVA: 0x7FFAC3013AF0
        public void get_IsAbstract(){} // RVA: 0x7FFAC8520230
        public void get_IsConstructor(){} // RVA: 0x7FFAC8520260
        public void get_IsSpecialName(){} // RVA: 0x7FFAC8520300
        public void get_IsStatic(){} // RVA: 0x7FFAC8520330
        public void get_IsVirtual(){} // RVA: 0x7FFAC8520360
        public void get_IsAssembly(){} // RVA: 0x7FFAC8520390
        public void get_IsFamilyAndAssembly(){} // RVA: 0x7FFAC85203C0
        public void get_IsPrivate(){} // RVA: 0x7FFAC85203F0
        public void get_IsPublic(){} // RVA: 0x7FFAC8520420
        public void get_IsGenericMethod(){} // RVA: 0x7FFAC2F21320
        public void get_IsGenericMethodDefinition(){} // RVA: 0x7FFAC2F21320
        public void GetGenericArguments(){} // RVA: 0x7FFAC8520450
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFAC2F21320
        public void Invoke(){} // RVA: 0x7FFAC85204A0 | overloaded x2
        public void get_MethodHandle(){}
        public void get_IsSecurityCritical(){} // RVA: 0x7FFAC85204E0
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void op_Equality(){} // RVA: 0x7FFAC8520510
        public void op_Inequality(){} // RVA: 0x7FFAC8520780
        public void GetParametersInternal(){} // RVA: 0x7FFAC3708F70
        public void GetParametersCount(){} // RVA: 0x7FFAC85207A0
        public void FormatNameAndSig(){} // RVA: 0x7FFAC85207D0
        public void GetParameterTypes(){} // RVA: 0x7FFAC8520930
        public void GetParametersNoCopy(){} // RVA: 0x7FFAC3708F70
        public void GetMethodFromHandle(){} // RVA: 0x7FFAC8520CE0 | overloaded x2
        public void ConstructParameters(){} // RVA: 0x7FFAC8520DE0
    }

    public class MethodBody : Object
    {
        public System.Reflection.ExceptionHandlingClause[] LocalVariables; // 0x10
        public System.Reflection.LocalVariableInfo[] locals; // 0x18
        public byte[] il; // 0x20
        public bool init_locals; // 0x28
        public int sig_token; // 0x2C
        public int max_stack; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8530A30 | overloaded x2
        public void get_LocalVariables(){} // RVA: 0x7FFAC8530B50
        public void GetILAsByteArray(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class MethodInfo : MethodBase
    {
        public object MemberType;
        public object ReturnParameter;
        public object ReturnType;
        public object ReturnTypeCustomAttributes;
        public object GenericParameterCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_MemberType(){} // RVA: 0x7FFAC3ED8E80
        public void get_ReturnParameter(){} // RVA: 0x7FFAC8521040
        public void get_ReturnType(){} // RVA: 0x7FFAC8521070
        public void GetGenericArguments(){} // RVA: 0x7FFAC85210A0
        public void GetGenericMethodDefinition(){} // RVA: 0x7FFAC85210F0
        public void MakeGenericMethod(){} // RVA: 0x7FFAC8521140
        public void GetBaseDefinition(){} // RVA: 0x7FFAC2C58E90
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x7FFAC2C58E90
        public void CreateDelegate(){} // RVA: 0x7FFAC85211E0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void op_Equality(){} // RVA: 0x7FFAC8261650
        public void op_Inequality(){} // RVA: 0x7FFAC84F06F0
        public void get_GenericParameterCount(){} // RVA: 0x7FFAC8521230
    }

    public class Missing : Object
    {
        public System.Reflection.Missing Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC8521260
        public void .cctor(){} // RVA: 0x7FFAC85212A0
    }

    public class MissingMetadataException : TypeAccessException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8528BE0
    }

    public class Module : Object
    {
        public System.Reflection.TypeFilter Assembly;
        public System.Reflection.TypeFilter FullyQualifiedName; // 0x8
        public 0x6B0D8780 Name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Assembly(){} // RVA: 0x7FFAC8521340
        public void get_FullyQualifiedName(){} // RVA: 0x7FFAC8521370
        public void get_Name(){} // RVA: 0x7FFAC85213A0
        public void get_ModuleVersionId(){} // RVA: 0x7FFAC85213D0
        public void get_ScopeName(){} // RVA: 0x7FFAC8521400
        public void IsResource(){} // RVA: 0x7FFAC8521430
        public void IsDefined(){} // RVA: 0x7FFAC8521460
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC8521490
        public void GetCustomAttributes(){} // RVA: 0x7FFAC85214F0 | overloaded x2
        public void ResolveMember(){} // RVA: 0x7FFAC8521520
        public void GetObjectData(){} // RVA: 0x7FFAC8521550
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void op_Equality(){} // RVA: 0x7FFAC8261650
        public void ToString(){} // RVA: 0x7FFAC3825740
        public void FilterTypeNameImpl(){} // RVA: 0x7FFAC8521580
        public void FilterTypeNameIgnoreCaseImpl(){} // RVA: 0x7FFAC85217F0
        public void GetModuleVersionId(){} // RVA: 0x7FFAC8521BB0
        public void .cctor(){} // RVA: 0x7FFAC8521BF0
    }

    public class MonoEventInfo : ValueType
    {
        public System.Type declaring_type; // 0x10
        public System.Type reflected_type; // 0x18
        public string name; // 0x20
        public System.Reflection.MethodInfo add_method; // 0x28
        public System.Reflection.MethodInfo remove_method; // 0x30
        public System.Reflection.MethodInfo raise_method; // 0x38
        public 0x6B0D8938 attrs; // 0x40
        public System.Reflection.MethodInfo[] other_methods; // 0x48
    }

    public class MonoMethodInfo : ValueType
    {
        public System.Type parent; // 0x10
        public System.Type ret; // 0x18
        public 0x6B0D8E60 attrs; // 0x20
        public 0x6B0D8F10 iattrs; // 0x24
        public 0x6B0D87D8 callconv; // 0x28

        // ── Methods ──
        public void get_method_info(){} // RVA: 0x7FFAC8533DD0
        public void get_method_attributes(){} // RVA: 0x7FFAC8533F60
        public void GetMethodInfo(){} // RVA: 0x7FFAC8533F70
        public void GetDeclaringType(){} // RVA: 0x7FFAC8534110
        public void GetReturnType(){} // RVA: 0x7FFAC8534130
        public void GetAttributes(){} // RVA: 0x7FFAC8533F60
        public void GetCallingConvention(){} // RVA: 0x7FFAC8534160
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFAC8534180
        public void get_parameter_info(){} // RVA: 0x7FFAC85341B0
        public void GetParametersInfo(){} // RVA: 0x7FFAC85341B0
        public void get_retval_marshal(){} // RVA: 0x7FFAC34F9180
        public void GetReturnParameterInfo(){} // RVA: 0x7FFAC85341F0
    }

    public class MonoPropertyInfo : ValueType
    {
        public System.Type parent; // 0x10
        public System.Type declaring_type; // 0x18
        public string name; // 0x20
        public System.Reflection.MethodInfo get_method; // 0x28
        public System.Reflection.MethodInfo set_method; // 0x30
        public 0x6B0D9280 attrs; // 0x38
    }

    public class NullabilityInfo : Object
    {
        public System.Type Type; // 0x10
        public 0x6B1A21F0 ReadState; // 0x18
        public 0x6B1A21F0 WriteState; // 0x1C
        public System.Reflection.NullabilityInfo ElementType; // 0x20
        public System.Reflection.NullabilityInfo[] GenericTypeArguments; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BF05C0
        public void get_Type(){} // RVA: 0x7FFAC2F3C380
        public void get_ReadState(){} // RVA: 0x7FFAC3157800
        public void set_ReadState(){} // RVA: 0x7FFAC392CD10
        public void get_WriteState(){} // RVA: 0x7FFAC44357F0
        public void set_WriteState(){} // RVA: 0x7FFAC44474D0
        public void get_ElementType(){} // RVA: 0x7FFAC2F4F0C0
        public void get_GenericTypeArguments(){} // RVA: 0x7FFAC2F4F130
    }

    public class NullabilityInfoContext : Object
    {
        public string IsSupported;
        public System.Collections.Generic.Dictionary`2<System.Reflection.Module,0x6B1A2248> _publicOnlyModules; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Reflection.MemberInfo,0x6B1A21F0> _context; // 0x18
        public bool <IsSupported>k__BackingField;

        // ── Methods ──
        public void get_IsSupported(){} // RVA: 0x7FFAC8BF06D0
        public void GetNullableContext(){} // RVA: 0x7FFAC8BF0730
        public void Create(){} // RVA: 0x7FFAC8BF1E90 | overloaded x4
        public void CheckParameterMetadataType(){} // RVA: 0x7FFAC8BF0E40
        public void GetMethodMetadataDefinition(){} // RVA: 0x7FFAC8BF11D0
        public void CheckNullabilityAttributes(){} // RVA: 0x7FFAC8BF12D0
        public void IsPrivateOrInternalMethodAndAnnotationDisabled(){} // RVA: 0x7FFAC8BF1C40
        public void EnsureIsSupported(){} // RVA: 0x7FFAC8BF2110
        public void IsPrivateOrInternalFieldAndAnnotationDisabled(){} // RVA: 0x7FFAC8BF21F0
        public void IsPublicOnly(){} // RVA: 0x7FFAC8BF2340
        public void PopulateAnnotationInfo(){} // RVA: 0x7FFAC8BF24D0
        public void GetNullabilityInfo(){} // RVA: 0x7FFAC8BF2930 | overloaded x2
        public void CreateParser(){} // RVA: 0x7FFAC8BF2E00
        public void TryLoadGenericMetaTypeNullability(){} // RVA: 0x7FFAC8BF31D0
        public void GetMemberMetadataDefinition(){} // RVA: 0x7FFAC8BF3440
        public void GetPropertyMetaType(){} // RVA: 0x7FFAC8BF3550
        public void CheckGenericParameters(){} // RVA: 0x7FFAC8BF3610
        public void TryUpdateGenericParameterNullability(){} // RVA: 0x7FFAC8BF37F0
        public void TryUpdateGenericTypeParameterNullabilityFromReflectedType(){} // RVA: 0x7FFAC8BF3A30
        public void TryPopulateNullabilityInfo(){} // RVA: 0x7FFAC8BF3D90
        public void TranslateByte(){} // RVA: 0x7FFAC8BF3FF0 | overloaded x2
        public void IsValueTypeOrValueTypeByRef(){} // RVA: 0x7FFAC8BF4010
        public void .ctor(){} // RVA: 0x7FFAC8BF40C0
        public void .cctor(){} // RVA: 0x7FFAC8BF4220
        public void <TryUpdateGenericTypeParameterNullabilityFromReflectedType>g__CountNullabilityStates|28_0(){} // RVA: 0x7FFAC8BF42C0
    }

    public class ObfuscationAttribute : Attribute
    {
        public bool Exclude; // 0x10
        public bool <Exclude>k__BackingField; // 0x11
        public bool <ApplyToMembers>k__BackingField; // 0x12
        public string <Feature>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8521D80
        public void set_Exclude(){} // RVA: 0x7FFAC3771D90
    }

    public class ParameterInfo : Object
    {
        public 0x6B0D90C8 Attributes; // 0x10
        public System.Type Member; // 0x18
        public object Name; // 0x20
        public System.Reflection.MemberInfo ParameterType; // 0x28
        public string Position; // 0x30
        public int IsIn; // 0x38
        public int IsOptional;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Attributes(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Member(){} // RVA: 0x7FFAC2F4F130
        public void get_Name(){} // RVA: 0x7FFAC31D95E0
        public void get_ParameterType(){} // RVA: 0x7FFAC2F247C0
        public void get_Position(){} // RVA: 0x7FFAC358A870
        public void get_IsIn(){} // RVA: 0x7FFAC8521E10
        public void get_IsOptional(){} // RVA: 0x7FFAC8521E40
        public void get_IsOut(){} // RVA: 0x7FFAC8521E70
        public void get_DefaultValue(){} // RVA: 0x7FFAC8521EA0
        public void get_HasDefaultValue(){} // RVA: 0x7FFAC8521ED0
        public void IsDefined(){} // RVA: 0x7FFAC8521F00
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC8521FA0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC8522010 | overloaded x2
        public void GetRealObject(){} // RVA: 0x7FFAC85220C0
        public void ToString(){} // RVA: 0x7FFAC85224A0
    }

    public class ParameterModifier : ValueType
    {
        public bool[] _byRef; // 0x10
    }

    public class Pointer : Object
    {
        public void* _ptr; // 0x10
        public System.Type _ptrType; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8522550
        public void Box(){} // RVA: 0x7FFAC85225B0
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC85227B0
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
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_MemberType(){} // RVA: 0x7FFAC530B540
        public void get_PropertyType(){} // RVA: 0x7FFAC2C58E90
        public void GetIndexParameters(){} // RVA: 0x7FFAC2C58E90
        public void get_Attributes(){} // RVA: 0x7FFAC2C59960
        public void get_CanRead(){} // RVA: 0x7FFAC2C59D00
        public void get_CanWrite(){} // RVA: 0x7FFAC2C59D00
        public void GetAccessors(){}
        public void get_GetMethod(){} // RVA: 0x7FFAC85227F0
        public void GetGetMethod(){} // RVA: 0x7FFAC8522810 | overloaded x2
        public void get_SetMethod(){} // RVA: 0x7FFAC8522830
        public void GetSetMethod(){} // RVA: 0x7FFAC8522850 | overloaded x2
        public void GetValue(){} // RVA: 0x7FFAC8522890 | overloaded x3
        public void SetValue(){} // RVA: 0x7FFAC8522900 | overloaded x3
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void op_Equality(){} // RVA: 0x7FFAC8261650
        public void op_Inequality(){} // RVA: 0x7FFAC84F06F0
    }

    public class ReflectionTypeLoadException : SystemException
    {
        public System.Type[] LoaderExceptions; // 0x90
        public System.Exception[] Message; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8522A70 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAC8522C80
        public void get_LoaderExceptions(){} // RVA: 0x7FFAC354DFB0
        public void get_Message(){} // RVA: 0x7FFAC8522F90
        public void ToString(){} // RVA: 0x7FFAC8522FA0
        public void CreateString(){} // RVA: 0x7FFAC8522FB0
    }

    public class RtFieldInfo : FieldInfo
    {
        // ── Methods ──
        public void UnsafeGetValue(){} // RVA: 0x7FFAC2C58F40
        public void UnsafeSetValue(){}
        public void CheckConsistency(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RuntimeAssembly : Assembly
    {
        public UIntPtr ManifestModule; // 0x10
        public object ReflectionOnly; // 0x18
        public ResolveEventHolder CodeBase; // 0x20
        public object EscapedCodeBase; // 0x28
        public object FullName; // 0x30
        public object MonoAssembly; // 0x38
        public object Location; // 0x40
        public object _denied; // 0x48
        public bool fromByteArray; // 0x50
        public string assemblyName; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8530B90
        public void GetObjectData(){} // RVA: 0x7FFAC8530C20
        public void LoadWithPartialNameInternal(){} // RVA: 0x7FFAC8530D50 | overloaded x2
        public void GetName(){} // RVA: 0x7FFAC8530DA0
        public void GetType(){} // RVA: 0x7FFAC8530E70
        public void GetModule(){} // RVA: 0x7FFAC8530F40
        public void GetReferencedAssemblies(){} // RVA: 0x7FFAC85310C0
        public void GetModules(){} // RVA: 0x7FFAC85310D0
        public void get_ManifestModule(){} // RVA: 0x7FFAC8531220
        public void GetAotId(){} // RVA: 0x7FFAC8531240
        public void get_code_base(){} // RVA: 0x7FFAC8531280
        public void get_location(){} // RVA: 0x7FFAC8531380
        public void get_fullname(){} // RVA: 0x7FFAC8531410
        public void GetAotIdInternal(){} // RVA: 0x7FFAC2F21320
        public void get_ReflectionOnly(){} // RVA: 0x7FFAC2F21320
        public void GetCodeBase(){} // RVA: 0x7FFAC8531280
        public void get_CodeBase(){} // RVA: 0x7FFAC85314A0
        public void get_EscapedCodeBase(){} // RVA: 0x7FFAC85314B0
        public void get_FullName(){} // RVA: 0x7FFAC8531410
        public void get_MonoAssembly(){} // RVA: 0x7FFAC2F3C380
        public void get_Location(){} // RVA: 0x7FFAC85314C0
        public void GetManifestResourceInfoInternal(){} // RVA: 0x7FFAC8531590
        public void GetManifestResourceInfo(){} // RVA: 0x7FFAC85315A0
        public void GetManifestResourceNames(){} // RVA: 0x7FFAC8531770
        public void GetManifestResourceInternal(){} // RVA: 0x7FFAC85318F0
        public void GetManifestResourceStream(){} // RVA: 0x7FFAC8531900
        public void IsDefined(){} // RVA: 0x7FFAC8531EA0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC8531F70 | overloaded x2
        public void GetManifestModule(){} // RVA: 0x7FFAC8531FE0
        public void GetManifestModuleInternal(){} // RVA: 0x7FFAC8531FF0
        public void GetModulesInternal(){} // RVA: 0x7FFAC8532000
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void Equals(){} // RVA: 0x7FFAC85320A0
        public void ToString(){} // RVA: 0x7FFAC8532160
    }

    public class RuntimeConstructorInfo : ConstructorInfo
    {
        public UIntPtr Module; // 0x10
        public string BindingFlags; // 0x18
        public System.Type ReflectedTypeInternal; // 0x20

        // ── Methods ──
        public void get_Module(){} // RVA: 0x7FFAC8536A20
        public void GetRuntimeModule(){} // RVA: 0x7FFAC8536A20
        public void get_BindingFlags(){} // RVA: 0x7FFAC34F9180
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFAC8536AC0
        public void GetObjectData(){} // RVA: 0x7FFAC8536B50
        public void SerializationToString(){} // RVA: 0x7FFAC8536CD0
        public void SerializationInvoke(){} // RVA: 0x7FFAC8536CF0
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFAC8534AF0
        public void GetParameters(){} // RVA: 0x7FFAC8534BD0
        public void GetParametersInternal(){} // RVA: 0x7FFAC8534BD0
        public void GetParametersCount(){} // RVA: 0x7FFAC8536E50
        public void InternalInvoke(){} // RVA: 0x7FFAC8537280 | overloaded x2
        public void Invoke(){} // RVA: 0x7FFAC8537370 | overloaded x2
        public void DoInvoke(){} // RVA: 0x7FFAC8536FF0
        public void get_MethodHandle(){} // RVA: 0x7FFAC2F3C380
        public void get_Attributes(){} // RVA: 0x7FFAC85352D0
        public void get_CallingConvention(){} // RVA: 0x7FFAC85352E0
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFAC85373A0
        public void get_ReflectedType(){} // RVA: 0x7FFAC2F4F0C0
        public void get_DeclaringType(){} // RVA: 0x7FFAC8535300
        public void get_Name(){} // RVA: 0x7FFAC8535320
        public void IsDefined(){} // RVA: 0x7FFAC85373E0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC85374B0 | overloaded x2
        public void GetMethodBody(){} // RVA: 0x7FFAC8536A10
        public void ToString(){} // RVA: 0x7FFAC8537520
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC8532D70
        public void get_core_clr_security_level(){} // RVA: 0x7FFAC3013AF0
        public void get_IsSecurityCritical(){} // RVA: 0x7FFAC3006850
        public void get_MetadataToken(){} // RVA: 0x7FFAC8532D80
        public void get_metadata_token(){} // RVA: 0x7FFAC8532D80
        public void .ctor(){} // RVA: 0x7FFAC8537580
    }

    public class RuntimeEventInfo : EventInfo
    {
        public UIntPtr Module; // 0x18
        public UIntPtr BindingFlags; // 0x20

        // ── Methods ──
        public void get_event_info(){} // RVA: 0x7FFAC8532350
        public void GetEventInfo(){} // RVA: 0x7FFAC8532460
        public void get_Module(){} // RVA: 0x7FFAC8532580
        public void get_BindingFlags(){} // RVA: 0x7FFAC85325B0
        public void GetDeclaringTypeInternal(){} // RVA: 0x7FFAC85325C0
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFAC8532650
        public void GetRuntimeModule(){} // RVA: 0x7FFAC8532580
        public void GetObjectData(){} // RVA: 0x7FFAC85326E0
        public void GetBindingFlags(){} // RVA: 0x7FFAC8532820
        public void GetAddMethod(){} // RVA: 0x7FFAC85329B0
        public void GetRaiseMethod(){} // RVA: 0x7FFAC8532A30
        public void GetRemoveMethod(){} // RVA: 0x7FFAC8532AB0
        public void get_DeclaringType(){} // RVA: 0x7FFAC8532B30
        public void get_ReflectedType(){} // RVA: 0x7FFAC8532B50
        public void get_Name(){} // RVA: 0x7FFAC8532B70
        public void ToString(){} // RVA: 0x7FFAC8532B90
        public void IsDefined(){} // RVA: 0x7FFAC8532C30
        public void GetCustomAttributes(){} // RVA: 0x7FFAC8532D00 | overloaded x2
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC8532D70
        public void get_MetadataToken(){} // RVA: 0x7FFAC8532D80
        public void get_metadata_token(){} // RVA: 0x7FFAC8532D80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RuntimeFieldInfo : RtFieldInfo
    {
        public UIntPtr BindingFlags; // 0x10
        public System.RuntimeFieldHandle Module; // 0x18
        public string ReflectedTypeInternal; // 0x20
        public System.Type Attributes; // 0x28
        public 0x6B0D8A98 FieldHandle; // 0x30

        // ── Methods ──
        public void get_BindingFlags(){} // RVA: 0x7FFAC34F9180
        public void get_Module(){} // RVA: 0x7FFAC8532DA0
        public void GetDeclaringTypeInternal(){} // RVA: 0x7FFAC8532DD0
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFAC8532E60
        public void GetRuntimeModule(){} // RVA: 0x7FFAC8532DA0
        public void GetObjectData(){} // RVA: 0x7FFAC8532EF0
        public void UnsafeGetValue(){} // RVA: 0x7FFAC8533050
        public void CheckConsistency(){} // RVA: 0x7FFAC8533060
        public void UnsafeSetValue(){} // RVA: 0x7FFAC8533220
        public void SetValueDirect(){} // RVA: 0x7FFAC8533270
        public void get_Attributes(){} // RVA: 0x7FFAC2F7CCD0
        public void get_FieldHandle(){} // RVA: 0x7FFAC2F247C0
        public void ResolveType(){} // RVA: 0x7FFAC8533400
        public void get_FieldType(){} // RVA: 0x7FFAC8533410
        public void GetParentType(){} // RVA: 0x7FFAC8533480
        public void get_ReflectedType(){} // RVA: 0x7FFAC85334B0
        public void get_DeclaringType(){} // RVA: 0x7FFAC85334C0
        public void get_Name(){} // RVA: 0x7FFAC2F4F0C0
        public void IsDefined(){} // RVA: 0x7FFAC85334E0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC85335B0 | overloaded x2
        public void GetFieldOffset(){} // RVA: 0x7FFAC8533620
        public void GetValueInternal(){} // RVA: 0x7FFAC8533050
        public void GetValue(){} // RVA: 0x7FFAC8533630
        public void ToString(){} // RVA: 0x7FFAC8533800
        public void SetValueInternal(){} // RVA: 0x7FFAC85338A0
        public void SetValue(){} // RVA: 0x7FFAC85338B0
        public void GetRawConstantValue(){} // RVA: 0x7FFAC8533BC0
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC8532D70
        public void CheckGeneric(){} // RVA: 0x7FFAC8533D30
        public void get_MetadataToken(){} // RVA: 0x7FFAC8532D80
        public void get_metadata_token(){} // RVA: 0x7FFAC8532D80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RuntimeMethodInfo : MethodInfo
    {
        public UIntPtr BindingFlags; // 0x10
        public string Module; // 0x18
        public System.Type ReflectedTypeInternal; // 0x20

        // ── Methods ──
        public void get_BindingFlags(){} // RVA: 0x7FFAC34F9180
        public void get_Module(){} // RVA: 0x7FFAC8534230
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFAC85342D0
        public void FormatNameAndSig(){} // RVA: 0x7FFAC8534360
        public void CreateDelegate(){} // RVA: 0x7FFAC8534670 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC85346A0
        public void GetRuntimeModule(){} // RVA: 0x7FFAC8534230
        public void GetObjectData(){} // RVA: 0x7FFAC8534750
        public void SerializationToString(){} // RVA: 0x7FFAC8534920
        public void GetMethodFromHandleNoGenericCheck(){} // RVA: 0x7FFAC85349E0 | overloaded x2
        public void GetMethodBodyInternal(){} // RVA: 0x7FFAC8534A30
        public void GetMethodBody(){} // RVA: 0x7FFAC8536A10 | overloaded x2
        public void GetMethodFromHandleInternalType(){} // RVA: 0x7FFAC8534A50
        public void GetMethodFromHandleInternalType_native(){} // RVA: 0x7FFAC8534A60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_name(){} // RVA: 0x7FFAC8534A70
        public void get_base_method(){} // RVA: 0x7FFAC8534A90
        public void get_metadata_token(){} // RVA: 0x7FFAC8532D80
        public void GetBaseDefinition(){} // RVA: 0x7FFAC8534AA0
        public void GetBaseMethod(){} // RVA: 0x7FFAC8534AB0
        public void get_ReturnParameter(){} // RVA: 0x7FFAC85341F0
        public void get_ReturnType(){} // RVA: 0x7FFAC8534AC0
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x7FFAC85341F0
        public void get_MetadataToken(){} // RVA: 0x7FFAC8532D80
        public void GetMethodImplementationFlags(){} // RVA: 0x7FFAC8534AF0
        public void GetParameters(){} // RVA: 0x7FFAC8534B20
        public void GetParametersInternal(){} // RVA: 0x7FFAC8534BD0
        public void GetParametersCount(){} // RVA: 0x7FFAC8534C20
        public void InternalInvoke(){} // RVA: 0x7FFAC8534C70
        public void Invoke(){} // RVA: 0x7FFAC8534C80
        public void ConvertValues(){} // RVA: 0x7FFAC8534F70
        public void get_MethodHandle(){} // RVA: 0x7FFAC2F3C380
        public void get_Attributes(){} // RVA: 0x7FFAC85352D0
        public void get_CallingConvention(){} // RVA: 0x7FFAC85352E0
        public void get_ReflectedType(){} // RVA: 0x7FFAC2F4F0C0
        public void get_DeclaringType(){} // RVA: 0x7FFAC8535300
        public void get_Name(){} // RVA: 0x7FFAC8535320
        public void IsDefined(){} // RVA: 0x7FFAC8535350
        public void GetCustomAttributes(){} // RVA: 0x7FFAC8535420 | overloaded x2
        public void GetPInvoke(){} // RVA: 0x7FFAC8535490
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFAC8535540
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFAC85356F0
        public void GetDllImportAttributeData(){} // RVA: 0x7FFAC8535940
        public void MakeGenericMethod(){} // RVA: 0x7FFAC85364A0
        public void MakeGenericMethod_impl(){} // RVA: 0x7FFAC8536810
        public void GetGenericArguments(){} // RVA: 0x7FFAC8536820
        public void GetGenericMethodDefinition_impl(){} // RVA: 0x7FFAC8536830
        public void GetGenericMethodDefinition(){} // RVA: 0x7FFAC8536860
        public void get_IsGenericMethodDefinition(){} // RVA: 0x7FFAC85368E0
        public void get_IsGenericMethod(){} // RVA: 0x7FFAC85368F0
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFAC8536920
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC8532D70
        public void get_core_clr_security_level(){} // RVA: 0x7FFAC3013AF0
        public void get_IsSecurityCritical(){} // RVA: 0x7FFAC3006850
    }

    public class RuntimeModule : Module
    {
        public UIntPtr Assembly; // 0x10
        public System.Reflection.Assembly Name; // 0x18
        public string ScopeName; // 0x20
        public string ModuleVersionId; // 0x28
        public string FullyQualifiedName; // 0x30
        public bool is_resource; // 0x38
        public int token; // 0x3C

        // ── Methods ──
        public void get_Assembly(){} // RVA: 0x7FFAC2F247C0
        public void get_Name(){} // RVA: 0x7FFAC2F4F130
        public void get_ScopeName(){} // RVA: 0x7FFAC31D95E0
        public void get_ModuleVersionId(){} // RVA: 0x7FFAC85375D0
        public void get_FullyQualifiedName(){} // RVA: 0x7FFAC2F4F0C0
        public void IsResource(){} // RVA: 0x7FFAC31D95D0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC8537660 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFAC85376D0
        public void ResolveMember(){} // RVA: 0x7FFAC8537770 | overloaded x2
        public void GetObjectData(){} // RVA: 0x7FFAC85377D0
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC852F290
        public void GetRuntimeAssembly(){} // RVA: 0x7FFAC85378E0
        public void GetModuleVersionId(){} // RVA: 0x7FFAC8537960
        public void resolve_token_exception(){} // RVA: 0x7FFAC8537A60
        public void ptrs_from_types(){} // RVA: 0x7FFAC8537C20
        public void GetGuidInternal(){} // RVA: 0x7FFAC2F21310
        public void ResolveMemberToken(){} // RVA: 0x7FFAC8537D70
        public void .ctor(){} // RVA: 0x7FFAC8537D90
    }

    public class RuntimeParameterInfo : ParameterInfo
    {
        public System.Runtime.InteropServices.MarshalAsAttribute DefaultValue; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8538530 | overloaded x3
        public void FormatParameters(){} // RVA: 0x7FFAC8537FB0
        public void get_DefaultValue(){} // RVA: 0x7FFAC85386B0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC8538A80 | overloaded x2
        public void GetDefaultValueImpl(){} // RVA: 0x7FFAC8538AF0
        public void IsDefined(){} // RVA: 0x7FFAC8538C10
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC852F390
        public void GetPseudoCustomAttributes(){} // RVA: 0x7FFAC8538C80
        public void GetPseudoCustomAttributesData(){} // RVA: 0x7FFAC8538F90
        public void get_HasDefaultValue(){} // RVA: 0x7FFAC8539650
        public void New(){} // RVA: 0x7FFAC85397E0 | overloaded x2
    }

    public class RuntimePropertyInfo : PropertyInfo
    {
        public UIntPtr BindingFlags; // 0x10
        public UIntPtr Module; // 0x18
        public System.Reflection.MonoPropertyInfo ReflectedTypeInternal; // 0x20
        public 0x6B0DA300 Attributes; // 0x50
        public GetterAdapter CanRead; // 0x58

        // ── Methods ──
        public void get_property_info(){} // RVA: 0x7FFAC8539990
        public void get_BindingFlags(){} // RVA: 0x7FFAC34F9180
        public void get_Module(){} // RVA: 0x7FFAC85399A0
        public void GetDeclaringTypeInternal(){} // RVA: 0x7FFAC8539A40
        public void get_ReflectedTypeInternal(){} // RVA: 0x7FFAC8539AD0
        public void GetRuntimeModule(){} // RVA: 0x7FFAC85399A0
        public void ToString(){} // RVA: 0x7FFAC8539B60
        public void FormatNameAndSig(){} // RVA: 0x7FFAC8539B70
        public void GetObjectData(){} // RVA: 0x7FFAC8539D30
        public void SerializationToString(){} // RVA: 0x7FFAC8539EB0
        public void CachePropertyInfo(){} // RVA: 0x7FFAC8539EC0
        public void get_Attributes(){} // RVA: 0x7FFAC8539F00
        public void get_CanRead(){} // RVA: 0x7FFAC8539F40
        public void get_CanWrite(){} // RVA: 0x7FFAC8539F70
        public void get_PropertyType(){} // RVA: 0x7FFAC8539FA0
        public void get_ReflectedType(){} // RVA: 0x7FFAC853A050
        public void get_DeclaringType(){} // RVA: 0x7FFAC853A090
        public void get_Name(){} // RVA: 0x7FFAC853A0D0
        public void GetAccessors(){} // RVA: 0x7FFAC853A110
        public void GetGetMethod(){} // RVA: 0x7FFAC853A2A0
        public void GetIndexParameters(){} // RVA: 0x7FFAC853A310
        public void GetSetMethod(){} // RVA: 0x7FFAC853A580
        public void IsDefined(){} // RVA: 0x7FFAC853A5F0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC853A6C0 | overloaded x2
        public void GetterAdapterFrame(){} // RVA: 0x7FFAC2C58FF0
        public void StaticGetterAdapterFrame(){} // RVA: 0x7FFAC2C58FF0
        public void GetValue(){} // RVA: 0x7FFAC853A730 | overloaded x2
        public void SetValue(){} // RVA: 0x7FFAC853A8E0
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC8532D70
        public void get_MetadataToken(){} // RVA: 0x7FFAC8532D80
        public void get_metadata_token(){} // RVA: 0x7FFAC8532D80
        public void internal_from_handle_type(){} // RVA: 0x7FFAC853AB00
        public void GetPropertyFromHandle(){} // RVA: 0x7FFAC853AB60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RuntimeReflectionExtensions : Object
    {
        // ── Methods ──
        public void GetRuntimeMethod(){} // RVA: 0x7FFAC8526C20
        public void GetRuntimeProperty(){} // RVA: 0x7FFAC8526D00
        public void GetMethodInfo(){} // RVA: 0x7FFAC8526E30
    }

    public class SignatureArrayType : SignatureHasElementType
    {
        public int IsSZArray; // 0x20
        public bool IsVariableBoundArray; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8523140
        public void IsArrayImpl(){} // RVA: 0x7FFAC3006850
        public void IsByRefImpl(){} // RVA: 0x7FFAC2F21320
        public void IsPointerImpl(){} // RVA: 0x7FFAC2F21320
        public void get_IsSZArray(){} // RVA: 0x7FFAC8523180
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFAC2F3C7C0
        public void GetArrayRank(){} // RVA: 0x7FFAC30DBBE0
        public void get_Suffix(){} // RVA: 0x7FFAC8523190
    }

    public class SignatureByRefType : SignatureHasElementType
    {
        public object IsSZArray;
        public object IsVariableBoundArray;
        public object Suffix;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8523250
        public void IsArrayImpl(){} // RVA: 0x7FFAC2F21320
        public void IsByRefImpl(){} // RVA: 0x7FFAC3006850
        public void IsPointerImpl(){} // RVA: 0x7FFAC2F21320
        public void get_IsSZArray(){} // RVA: 0x7FFAC2F21320
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFAC2F21320
        public void GetArrayRank(){} // RVA: 0x7FFAC8523260
        public void get_Suffix(){} // RVA: 0x7FFAC85232B0
    }

    public class SignatureConstructedGenericType : SignatureType
    {
        public System.Type IsGenericTypeDefinition; // 0x18
        public System.Type[] IsSZArray; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85232F0
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFAC2F21320
        public void HasElementTypeImpl(){} // RVA: 0x7FFAC2F21320
        public void IsArrayImpl(){} // RVA: 0x7FFAC2F21320
        public void IsByRefImpl(){} // RVA: 0x7FFAC2F21320
        public void IsPointerImpl(){} // RVA: 0x7FFAC2F21320
        public void get_IsSZArray(){} // RVA: 0x7FFAC2F21320
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFAC2F21320
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFAC3006850
        public void get_IsGenericParameter(){} // RVA: 0x7FFAC2F21320
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFAC2F21320
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFAC8523540
        public void get_ElementType(){} // RVA: 0x7FFAC34F9180
        public void GetArrayRank(){} // RVA: 0x7FFAC85235D0
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFAC2F247C0
        public void GetGenericArguments(){} // RVA: 0x7FFAC8523620
        public void get_GenericTypeArguments(){} // RVA: 0x7FFAC8523640
        public void get_GenericParameterPosition(){} // RVA: 0x7FFAC85236C0
        public void get_Name(){} // RVA: 0x7FFAC8523710
        public void get_Namespace(){} // RVA: 0x7FFAC83FC520
        public void ToString(){} // RVA: 0x7FFAC8523740
    }

    public class SignatureHasElementType : SignatureType
    {
        public System.Reflection.SignatureType IsGenericTypeDefinition; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8523920
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFAC2F21320
        public void HasElementTypeImpl(){} // RVA: 0x7FFAC3006850
        public void IsArrayImpl(){} // RVA: 0x7FFAC2C59D00
        public void IsByRefImpl(){} // RVA: 0x7FFAC2C59D00
        public void IsPointerImpl(){} // RVA: 0x7FFAC2C59D00
        public void get_IsSZArray(){} // RVA: 0x7FFAC2C59D00
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFAC2C59D00
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFAC2F21320
        public void get_IsGenericParameter(){} // RVA: 0x7FFAC2F21320
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFAC2F21320
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFAC470C5F0
        public void get_ElementType(){} // RVA: 0x7FFAC2F247C0
        public void GetArrayRank(){} // RVA: 0x7FFAC2C59960
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFAC85239C0
        public void GetGenericArguments(){} // RVA: 0x7FFAC8523A10
        public void get_GenericTypeArguments(){} // RVA: 0x7FFAC8523A50
        public void get_GenericParameterPosition(){} // RVA: 0x7FFAC8523A90
        public void get_Name(){} // RVA: 0x7FFAC8523AE0
        public void get_Namespace(){} // RVA: 0x7FFAC83FC520
        public void ToString(){} // RVA: 0x7FFAC8523B50
        public void get_Suffix(){} // RVA: 0x7FFAC2C58E90
    }

    public class SignaturePointerType : SignatureHasElementType
    {
        public object IsSZArray;
        public object IsVariableBoundArray;
        public object Suffix;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8523250
        public void IsArrayImpl(){} // RVA: 0x7FFAC2F21320
        public void IsByRefImpl(){} // RVA: 0x7FFAC2F21320
        public void IsPointerImpl(){} // RVA: 0x7FFAC3006850
        public void get_IsSZArray(){} // RVA: 0x7FFAC2F21320
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFAC2F21320
        public void GetArrayRank(){} // RVA: 0x7FFAC8523BC0
        public void get_Suffix(){} // RVA: 0x7FFAC8523C10
    }

    public class SignatureType : Type
    {
        public object IsSignatureType;
        public object IsSZArray;
        public object IsVariableBoundArray;
        public object IsGenericType;
        public object IsGenericTypeDefinition;
        public object IsConstructedGenericType;
        public object IsGenericParameter;
        public object IsGenericMethodParameter;
        public object ContainsGenericParameters;
        public object MemberType;
        public object GenericTypeArguments;
        public object GenericParameterPosition;
        public object ElementType;
        public object UnderlyingSystemType;
        public object Name;
        public object Namespace;
        public object FullName;
        public object AssemblyQualifiedName;
        public object Assembly;
        public object Module;
        public object ReflectedType;
        public object BaseType;
        public object MetadataToken;
        public object DeclaringType;
        public object DeclaringMethod;
        public object GenericParameterAttributes;
        public object GUID;
        public object IsEnum;
        public object IsSecurityCritical;
        public object IsSecuritySafeCritical;
        public object IsSecurityTransparent;
        public object IsSerializable;
        public object TypeHandle;

        // ── Methods ──
        public void get_IsSignatureType(){} // RVA: 0x7FFAC3006850
        public void HasElementTypeImpl(){} // RVA: 0x7FFAC2C59D00
        public void IsArrayImpl(){} // RVA: 0x7FFAC2C59D00
        public void get_IsSZArray(){} // RVA: 0x7FFAC2C59D00
        public void get_IsVariableBoundArray(){} // RVA: 0x7FFAC2C59D00
        public void IsByRefImpl(){} // RVA: 0x7FFAC2C59D00
        public void IsPointerImpl(){} // RVA: 0x7FFAC2C59D00
        public void get_IsGenericType(){} // RVA: 0x7FFAC8523C50
        public void get_IsGenericTypeDefinition(){} // RVA: 0x7FFAC2C59D00
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFAC2C59D00
        public void get_IsGenericParameter(){} // RVA: 0x7FFAC2C59D00
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFAC2C59D00
        public void get_ContainsGenericParameters(){} // RVA: 0x7FFAC2C59D00
        public void get_MemberType(){} // RVA: 0x7FFAC530BFF0
        public void MakeArrayType(){} // RVA: 0x7FFAC8523D10 | overloaded x2
        public void MakeByRefType(){} // RVA: 0x7FFAC8523DC0
        public void MakePointerType(){} // RVA: 0x7FFAC8523E20
        public void MakeGenericType(){} // RVA: 0x7FFAC8523E80
        public void GetElementType(){} // RVA: 0x7FFAC8523ED0
        public void GetArrayRank(){} // RVA: 0x7FFAC2C59960
        public void GetGenericTypeDefinition(){} // RVA: 0x7FFAC2C58E90
        public void get_GenericTypeArguments(){} // RVA: 0x7FFAC2C58E90
        public void GetGenericArguments(){} // RVA: 0x7FFAC2C58E90
        public void get_GenericParameterPosition(){} // RVA: 0x7FFAC2C59960
        public void get_ElementType(){} // RVA: 0x7FFAC2C58E90
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFAC44F81E0
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_Namespace(){} // RVA: 0x7FFAC2C58E90
        public void get_FullName(){} // RVA: 0x7FFAC34F9180
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFAC34F9180
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void get_Assembly(){} // RVA: 0x7FFAC8523EF0
        public void get_Module(){} // RVA: 0x7FFAC8523F40
        public void get_ReflectedType(){} // RVA: 0x7FFAC8523F90
        public void get_BaseType(){} // RVA: 0x7FFAC8523FE0
        public void GetInterfaces(){} // RVA: 0x7FFAC8524030
        public void IsAssignableFrom(){} // RVA: 0x7FFAC8524080
        public void get_MetadataToken(){} // RVA: 0x7FFAC85240D0
        public void get_DeclaringType(){} // RVA: 0x7FFAC8524120
        public void get_DeclaringMethod(){} // RVA: 0x7FFAC8524170
        public void GetGenericParameterConstraints(){} // RVA: 0x7FFAC85241C0
        public void get_GenericParameterAttributes(){} // RVA: 0x7FFAC8524210
        public void IsEnumDefined(){} // RVA: 0x7FFAC8524260
        public void GetEnumName(){} // RVA: 0x7FFAC85242B0
        public void GetEnumNames(){} // RVA: 0x7FFAC8524300
        public void GetEnumUnderlyingType(){} // RVA: 0x7FFAC8524350
        public void GetEnumValues(){} // RVA: 0x7FFAC85243A0
        public void get_GUID(){} // RVA: 0x7FFAC85243F0
        public void GetTypeCodeImpl(){} // RVA: 0x7FFAC8524440
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFAC8524490
        public void GetConstructors(){} // RVA: 0x7FFAC85244E0
        public void GetEvent(){} // RVA: 0x7FFAC8524530
        public void GetEvents(){} // RVA: 0x7FFAC8524580
        public void GetField(){} // RVA: 0x7FFAC85245D0
        public void GetFields(){} // RVA: 0x7FFAC8524620
        public void GetMembers(){} // RVA: 0x7FFAC8524670
        public void GetMethods(){} // RVA: 0x7FFAC85246C0
        public void GetNestedType(){} // RVA: 0x7FFAC8524710
        public void GetProperties(){} // RVA: 0x7FFAC8524760
        public void InvokeMember(){} // RVA: 0x7FFAC85247B0
        public void GetMethodImpl(){} // RVA: 0x7FFAC8524800
        public void GetPropertyImpl(){} // RVA: 0x7FFAC8524850
        public void GetMember(){} // RVA: 0x7FFAC85248F0 | overloaded x2
        public void GetCustomAttributes(){} // RVA: 0x7FFAC8524990 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFAC85249E0
        public void GetCustomAttributesData(){} // RVA: 0x7FFAC8524A30
        public void GetInterface(){} // RVA: 0x7FFAC8524A80
        public void GetConstructorImpl(){} // RVA: 0x7FFAC8524AD0
        public void IsCOMObjectImpl(){} // RVA: 0x7FFAC8524B20
        public void IsPrimitiveImpl(){} // RVA: 0x7FFAC8524B70
        public void IsContextfulImpl(){} // RVA: 0x7FFAC8524BC0
        public void get_IsEnum(){} // RVA: 0x7FFAC8524C10
        public void IsEquivalentTo(){} // RVA: 0x7FFAC8524C60
        public void IsInstanceOfType(){} // RVA: 0x7FFAC8524CB0
        public void IsMarshalByRefImpl(){} // RVA: 0x7FFAC8524D00
        public void get_IsSecurityCritical(){} // RVA: 0x7FFAC8524D50
        public void get_IsSecuritySafeCritical(){} // RVA: 0x7FFAC8524DA0
        public void get_IsSecurityTransparent(){} // RVA: 0x7FFAC8524DF0
        public void get_IsSerializable(){} // RVA: 0x7FFAC8524E40
        public void IsSubclassOf(){} // RVA: 0x7FFAC8524E90
        public void IsValueTypeImpl(){} // RVA: 0x7FFAC8524EE0
        public void get_TypeHandle(){} // RVA: 0x7FFAC8524F30
        public void .ctor(){} // RVA: 0x7FFAC8524F80
    }

    public class SignatureTypeExtensions : Object
    {
        // ── Methods ──
        public void MatchesParameterTypeExactly(){} // RVA: 0x7FFAC8524FD0
        public void MatchesExactly(){} // RVA: 0x7FFAC85250C0
        public void TryResolveAgainstGenericMethod(){} // RVA: 0x7FFAC8525500
        public void TryResolve(){} // RVA: 0x7FFAC8525540
        public void TryMakeArrayType(){} // RVA: 0x7FFAC8525990 | overloaded x2
        public void TryMakeByRefType(){} // RVA: 0x7FFAC85259C0
        public void TryMakePointerType(){} // RVA: 0x7FFAC85259F0
        public void TryMakeGenericType(){} // RVA: 0x7FFAC8525A20
    }

    public class StrongNameKeyPair : Object
    {
        public byte[] _publicKey; // 0x10
        public string _keyPairContainer; // 0x18
        public bool _keyPairExported; // 0x20
        public byte[] _keyPairArray; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC853AC60
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x7FFAC853AFE0
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC2F21310
    }

    public class TargetException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850A3C0 | overloaded x4
    }

    public class TargetInvocationException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850A3C0 | overloaded x3
    }

    public class TargetParameterCountException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850A3C0 | overloaded x3
    }

    public class Throw : Object
    {
        // ── Methods ──
        public void InvalidCast(){} // RVA: 0x7FFAC8A6BA90
        public void InvalidArgument(){} // RVA: 0x7FFAC8A6BAD0
        public void InvalidToken(){} // RVA: 0x7FFAC8A6BB30
        public void ArgumentNull(){} // RVA: 0x7FFAC8A6BBB0
        public void ArgumentOutOfRange(){} // RVA: 0x7FFAC8A6BC00
        public void OutOfBounds(){} // RVA: 0x7FFAC8A6BC50
        public void InvalidHandle(){} // RVA: 0x7FFAC8A6BCC0
        public void InvalidCompressedInteger(){} // RVA: 0x7FFAC8A6BD30
        public void ImageTooSmall(){} // RVA: 0x7FFAC8A6BDA0
        public void ImageTooSmallOrContainsInvalidOffsetOrCount(){} // RVA: 0x7FFAC8A6BE10
        public void ReferenceOverflow(){} // RVA: 0x7FFAC8A6BE80
        public void TableNotSorted(){} // RVA: 0x7FFAC8A6BEF0
        public void InvalidOperation_PEImageNotAvailable(){} // RVA: 0x7FFAC8A6BF90
        public void SequencePointValueOutOfRange(){} // RVA: 0x7FFAC8A6C000
        public void PEReaderDisposed(){} // RVA: 0x7FFAC8A6C070
    }

    public class TypeDelegator : TypeInfo
    {
        public System.Type GUID; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8525BC0
        public void get_GUID(){} // RVA: 0x7FFAC8525CF0
        public void get_MetadataToken(){} // RVA: 0x7FFAC8525D30
        public void InvokeMember(){} // RVA: 0x7FFAC8525D60
        public void get_Module(){} // RVA: 0x7FFAC8525DE0
        public void get_Assembly(){} // RVA: 0x7FFAC8525E10
        public void get_TypeHandle(){} // RVA: 0x7FFAC8525E40
        public void get_Name(){} // RVA: 0x7FFAC8523710
        public void get_FullName(){} // RVA: 0x7FFAC8525E70
        public void get_Namespace(){} // RVA: 0x7FFAC83FC520
        public void get_AssemblyQualifiedName(){} // RVA: 0x7FFAC8525EA0
        public void get_BaseType(){} // RVA: 0x7FFAC8525ED0
        public void GetConstructorImpl(){} // RVA: 0x7FFAC8525F00
        public void GetConstructors(){} // RVA: 0x7FFAC8525F30
        public void GetMethodImpl(){} // RVA: 0x7FFAC8525F60
        public void GetMethods(){} // RVA: 0x7FFAC8526030
        public void GetField(){} // RVA: 0x7FFAC8526060
        public void GetFields(){} // RVA: 0x7FFAC8526090
        public void GetInterface(){} // RVA: 0x7FFAC85260C0
        public void GetInterfaces(){} // RVA: 0x7FFAC85260F0
        public void GetEvent(){} // RVA: 0x7FFAC8526120
        public void GetPropertyImpl(){} // RVA: 0x7FFAC8526150
        public void GetProperties(){} // RVA: 0x7FFAC8526340
        public void GetEvents(){} // RVA: 0x7FFAC8526370
        public void GetNestedType(){} // RVA: 0x7FFAC85263A0
        public void GetMember(){} // RVA: 0x7FFAC85263D0
        public void GetMembers(){} // RVA: 0x7FFAC8526400
        public void GetAttributeFlagsImpl(){} // RVA: 0x7FFAC8526430
        public void get_IsSZArray(){} // RVA: 0x7FFAC8526460
        public void IsArrayImpl(){} // RVA: 0x7FFAC8526490
        public void IsPrimitiveImpl(){} // RVA: 0x7FFAC85264C0
        public void IsByRefImpl(){} // RVA: 0x7FFAC85264F0
        public void get_IsGenericMethodParameter(){} // RVA: 0x7FFAC8526520
        public void IsPointerImpl(){} // RVA: 0x7FFAC83FBE10
        public void IsValueTypeImpl(){} // RVA: 0x7FFAC8526550
        public void IsCOMObjectImpl(){} // RVA: 0x7FFAC8526580
        public void get_IsConstructedGenericType(){} // RVA: 0x7FFAC85265B0
        public void get_IsCollectible(){} // RVA: 0x7FFAC85265E0
        public void GetElementType(){} // RVA: 0x7FFAC8526610
        public void HasElementTypeImpl(){} // RVA: 0x7FFAC8526640
        public void get_UnderlyingSystemType(){} // RVA: 0x7FFAC7785DE0
        public void GetCustomAttributes(){} // RVA: 0x7FFAC85266A0 | overloaded x2
        public void IsDefined(){} // RVA: 0x7FFAC85266D0
    }

    public class TypeFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5CBD190
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class TypeInfo : Type
    {
        public 0x6B0D8780 DeclaredFields;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8526700
        public void System.Reflection.IReflectableType.GetTypeInfo(){} // RVA: 0x7FFAC44F81E0
        public void GetDeclaredMethods(){} // RVA: 0x7FFAC8526750
        public void get_DeclaredFields(){} // RVA: 0x7FFAC8526860
        public void get_ImplementedInterfaces(){} // RVA: 0x7FFAC8526880
    }

}