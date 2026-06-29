// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Reflection
// Classes: 95
// Methods: 1141

namespace ThirdParty.DotNet.System.Reflection
{
    public class AmbiguousMatchException : SystemException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class Assembly : Object
    {
        // ── Methods ──
        public void get_CodeBase(){} // RVA: 0x680B180
        public void get_EscapedCodeBase(){} // RVA: 0x680B1C0
        public void get_FullName(){} // RVA: 0x680B200
        public void get_MonoAssembly(){} // RVA: 0x680B240
        public void get_Location(){} // RVA: 0x680B280
        public void GetObjectData(){} // RVA: 0x680B2C0
        public void IsDefined(){} // RVA: 0x680B300
        public void GetCustomAttributes(){} // RVA: 0x680B380
        public void GetManifestResourceStream(){} // RVA: 0x680B5A0
        public void GetSimpleName(){} // RVA: 0x680B6B0
        public void GetPublicKey(){} // RVA: 0x680B6E0
        public void GetVersion(){} // RVA: 0x680B710
        public void GetFlags(){} // RVA: 0x680B740
        public void GetTypes(){} // RVA: 0x680B780
        public void GetType(){} // RVA: 0x680C940
        public void InternalGetType(){} // RVA: 0x680B800
        public void GetName(){} // RVA: 0x680B850
        public void ToString(){} // RVA: 0x680B870
        public void GetAssembly(){} // RVA: 0x680B8B0
        public void GetEntryAssembly(){} // RVA: 0xDAC980
        public void InternalGetSatelliteAssembly(){} // RVA: 0x680B940
        public void LoadFrom(){} // RVA: 0x680BE90
        public void Load(){} // RVA: 0x67838E0
        public void ReflectionOnlyLoad(){} // RVA: 0x680BEA0
        public void LoadWithPartialName(){} // RVA: 0x680C140
        public void load_with_partial_name(){} // RVA: 0x680C000
        public void GetModules(){} // RVA: 0x680C9D0
        public void GetModulesInternal(){} // RVA: 0x680C320
        public void GetExecutingAssembly(){} // RVA: 0x680C360
        public void GetCallingAssembly(){} // RVA: 0x680C3A0
        public void InternalGetReferencedAssemblies(){} // RVA: 0x680C410
        public void GetManifestResourceNames(){} // RVA: 0x680C420
        public void GetReferencedAssemblies(){} // RVA: 0x680C9A0
        public void GetManifestResourceInfo(){} // RVA: 0x680C810
        public void GetManifestModule(){} // RVA: 0x680C850
        public void get_ReflectionOnly(){} // RVA: 0x680C890
        public void GetHashCode(){} // RVA: 0x66DC010
        public void Equals(){} // RVA: 0x2AFB5A0
        public void CreateNIE(){} // RVA: 0x680C8D0
        public void get_IsFullyTrusted(){} // RVA: 0xC2E4C0
        public void GetModule(){} // RVA: 0x680C970
        public void get_ManifestModule(){} // RVA: 0x680CA00
        public void get_IsDynamic(){} // RVA: 0xB43320
        public void op_Equality(){} // RVA: 0x680CA30
        public void op_Inequality(){} // RVA: 0x680CA90
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AssemblyCompanyAttribute : Attribute
    {
        public object _company;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class AssemblyConfigurationAttribute : Attribute
    {
        public object _configuration;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class AssemblyCopyrightAttribute : Attribute
    {
        public object _copyright;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class AssemblyDefaultAliasAttribute : Attribute
    {
        public object _defaultAlias;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class AssemblyDelaySignAttribute : Attribute
    {
        public object _delaySign;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
    }

    public class AssemblyDescriptionAttribute : Attribute
    {
        public object _description;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class AssemblyFileVersionAttribute : Attribute
    {
        public object _version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67D0AE0
    }

    public class AssemblyInformationalVersionAttribute : Attribute
    {
        public object _informationalVersion;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_InformationalVersion(){} // RVA: 0xB5DBF0
    }

    public class AssemblyKeyFileAttribute : Attribute
    {
        public object _keyFile;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class AssemblyMetadataAttribute : Attribute
    {
        public object _key;
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void get_Key(){} // RVA: 0xB5DBF0
        public void get_Value(){} // RVA: 0xB465B0
    }

    public class AssemblyName : Object
    {
        public object name;
        public object codebase;
        public object major;
        public object minor;
        public object build;
        public object revision;
        public object cultureinfo;
        public object flags;
        public object hashalg;
        public object keypair;
        public object publicKey;
        public object keyToken;
        public object versioncompat;
        public object version;
        public object processor_architecture;
        public object contentType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x680CDB0
        public void ParseAssemblyName(){} // RVA: 0x680CB00
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_CultureInfo(){} // RVA: 0xD33E60
        public void set_CultureInfo(){} // RVA: 0xB708C0
        public void get_Flags(){} // RVA: 0x18A0130
        public void set_Flags(){} // RVA: 0x189D3F0
        public void get_FullName(){} // RVA: 0x680D690
        public void get_Version(){} // RVA: 0xBE2C60
        public void set_Version(){} // RVA: 0x680DBA0
        public void ToString(){} // RVA: 0x680DC30
        public void GetPublicKey(){} // RVA: 0xBBF8F0
        public void GetPublicKeyToken(){} // RVA: 0x680DC80
        public void get_IsPublicKeyValid(){} // RVA: 0x680DD80
        public void InternalGetPublicKeyToken(){} // RVA: 0x680DE40
        public void get_public_token(){} // RVA: 0x680DF30
        public void ComputePublicKeyToken(){} // RVA: 0x680DFA0
        public void SetPublicKey(){} // RVA: 0x680E090
        public void GetObjectData(){} // RVA: 0x680E100
        public void Clone(){} // RVA: 0x680F600
        public void OnDeserialization(){} // RVA: 0x680F8C0
        public void GetNativeName(){} // RVA: 0x680F950
        public void FillName(){} // RVA: 0x680FA60
        public void Create(){} // RVA: 0x68100A0
    }

    public class AssemblyName[] : Array
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

    public class AssemblyProductAttribute : Attribute
    {
        public object _product;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class AssemblyTitleAttribute : Attribute
    {
        public object _title;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class AssemblyTrademarkAttribute : Attribute
    {
        public object _trademark;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class Binder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void BindToField(){} // RVA: 0x88C8B0
        public void BindToMethod(){} // RVA: 0x88CA30
        public void ChangeType(){} // RVA: 0x882090
        public void ReorderArgumentArray(){} // RVA: 0x8943B0
        public void SelectMethod(){} // RVA: 0x88C8B0
        public void SelectProperty(){} // RVA: 0x88C9C0
    }

    public class BlobUtilities : Object
    {
        // ── Methods ──
        public void ReadBytes(){} // RVA: 0x6D412A0
    }

    public class ConstructorInfo : MethodBase
    {
        public object ConstructorName;
        public object TypeConstructorName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_MemberType(){} // RVA: 0xC3CCE0
        public void Invoke(){} // RVA: 0x88C8B0
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void op_Equality(){} // RVA: 0x6544B10
        public void op_Inequality(){} // RVA: 0x67D0BD0
        public void .cctor(){} // RVA: 0x67D0C70
    }

    public class ConstructorInfo[] : Array
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

    public class CustomAttributeData : Object
    {
        public object ctorInfo;
        public object ctorArgs;
        public object namedArgs;
        public object lazyData;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void ResolveArgumentsInternal(){} // RVA: 0x6810490
        public void ResolveArguments(){} // RVA: 0x68105A0
        public void get_Constructor(){} // RVA: 0xB5DBF0
        public void get_ConstructorArguments(){} // RVA: 0x6810CB0
        public void get_NamedArguments(){} // RVA: 0x6810CD0
        public void GetCustomAttributes(){} // RVA: 0x68110B0
        public void GetCustomAttributesInternal(){} // RVA: 0x6810ED0
        public void get_AttributeType(){} // RVA: 0x678C220
        public void ToString(){} // RVA: 0x68111A0
        public void UnboxValues(){} // RVA: 0x303B140
        public void Equals(){} // RVA: 0x6811890
        public void GetHashCode(){} // RVA: 0x6811E20
    }

    public class CustomAttributeData[] : Array
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

    public class CustomAttributeExtensions : Object
    {
        // ── Methods ──
        public void GetCustomAttribute(){} // RVA: 0x303B6D0
        public void GetCustomAttributes(){} // RVA: 0x303B9B0
        public void IsDefined(){} // RVA: 0x6809790
    }

    public class CustomAttributeFormatException : FormatException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23022F0
    }

    public class CustomAttributeNamedArgument : ValueType
    {
        public object _typedValue;
        public object _isField;
        public object _memberName;
        public object _attributeType;
        public object _lazyMemberInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8B21E0
        public void get_TypedValue(){} // RVA: 0x7BF80
        public void get_IsField(){} // RVA: 0xB1800
        public void get_MemberName(){} // RVA: 0x931A0
        public void get_MemberInfo(){} // RVA: 0x8B2380
        public void Equals(){} // RVA: 0x8B2530
        public void GetHashCode(){} // RVA: 0x8B2540
        public void op_Equality(){} // RVA: 0x68082A0
        public void op_Inequality(){} // RVA: 0x6808320
        public void ToString(){} // RVA: 0x8B2550
    }

    public class CustomAttributeNamedArgument[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAD9E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AF90
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4D90
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E58710
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AF90
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class CustomAttributeTypedArgument : ValueType
    {
        public object _argumentType;
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8B2750
        public void get_ArgumentType(){} // RVA: 0x77900
        public void get_Value(){} // RVA: 0x77ED0
        public void Equals(){} // RVA: 0x8B2760
        public void GetHashCode(){} // RVA: 0x8B27C0
        public void op_Equality(){} // RVA: 0x6808CB0
        public void op_Inequality(){} // RVA: 0x6808D50
        public void ToString(){} // RVA: 0x8B2830
        public void CanonicalizeValue(){} // RVA: 0x6809540
    }

    public class CustomAttributeTypedArgument[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EADBF0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC3B70
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E58860
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A5B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class DefaultMemberAttribute : Attribute
    {
        public object _memberName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_MemberName(){} // RVA: 0xB5DBF0
    }

    public class EventInfo : MemberInfo
    {
        public object cached_add_event;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_MemberType(){} // RVA: 0xC50A80
        public void get_AddMethod(){} // RVA: 0x67D0E40
        public void GetAddMethod(){} // RVA: 0x881D20
        public void GetRemoveMethod(){} // RVA: 0x881D20
        public void GetRaiseMethod(){} // RVA: 0x881D20
        public void get_EventHandlerType(){} // RVA: 0x67D0E80
        public void RemoveEventHandler(){} // RVA: 0x67D0FE0
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void op_Equality(){} // RVA: 0x6544B10
        public void op_Inequality(){} // RVA: 0x67D1130
        public void AddEventHandler(){} // RVA: 0x67D1170
        public void internal_from_handle_type(){} // RVA: 0x67D1330
        public void GetEventFromHandle(){} // RVA: 0x67D1390
    }

    public class EventInfo[] : Array
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

    public class ExceptionHandlingClause : Object
    {
        public object catch_type;
        public object filter_offset;
        public object flags;
        public object try_offset;
        public object try_length;
        public object handler_offset;
        public object handler_length;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ToString(){} // RVA: 0x68122C0
    }

    public class FieldInfo : MemberInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_MemberType(){} // RVA: 0x1347420
        public void get_Attributes(){} // RVA: 0x87C130
        public void get_FieldType(){} // RVA: 0x87C0A0
        public void get_IsInitOnly(){} // RVA: 0x67D1490
        public void get_IsLiteral(){} // RVA: 0x67D14C0
        public void get_IsNotSerialized(){} // RVA: 0x67D14F0
        public void get_IsStatic(){} // RVA: 0x67D1520
        public void get_IsAssembly(){} // RVA: 0x67D1550
        public void get_IsFamilyAndAssembly(){} // RVA: 0x67D1580
        public void get_IsPrivate(){} // RVA: 0x67D15B0
        public void get_IsPublic(){} // RVA: 0x67D15E0
        public void get_FieldHandle(){} // RVA: 0x87C0A0
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void op_Equality(){} // RVA: 0x6544B10
        public void op_Inequality(){} // RVA: 0x67D1130
        public void GetValue(){} // RVA: 0x87C540
        public void SetValue(){} // RVA: 0x89E390
        public void SetValueDirect(){} // RVA: 0x67D1690
        public void GetRawConstantValue(){} // RVA: 0x67D16E0
        public void internal_from_handle_type(){} // RVA: 0x67D1730
        public void GetFieldFromHandle(){} // RVA: 0x67D1810
        public void GetFieldOffset(){} // RVA: 0x67D18C0
        public void get_marshal_info(){} // RVA: 0xDAC980
        public void GetPseudoCustomAttributes(){} // RVA: 0x67D1910
        public void GetPseudoCustomAttributesData(){} // RVA: 0x67D1B20
    }

    public class FieldInfo[] : Array
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

    public class ICustomAttributeProvider
    {
        // ── Methods ──
        public void GetCustomAttributes(){} // RVA: 0x87D1A0
        public void IsDefined(){} // RVA: 0x87F360
    }

    public class IReflectableType
    {
        // ── Methods ──
        public void GetTypeInfo(){} // RVA: 0x87C0A0
    }

    public class IntrospectionExtensions : Object
    {
        // ── Methods ──
        public void GetTypeInfo(){} // RVA: 0x6800890
    }

    public class InvalidFilterCriteriaException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67EC2E0
    }

    public class LocalVariableInfo : Object
    {
        public object type;
        public object is_pinned;
        public object position;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_LocalType(){} // RVA: 0xB5DBF0
        public void ToString(){} // RVA: 0x6812640
    }

    public class ManifestResourceInfo : Object
    {
        public object _referencedAssembly;
        public object _fileName;
        public object _resourceLocation;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x31D5D40
        public void get_ReferencedAssembly(){} // RVA: 0xB5DBF0
        public void get_FileName(){} // RVA: 0xB465B0
        public void get_ResourceLocation(){} // RVA: 0xFEAE90
    }

    public class MemberFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3A9D0
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class MemberInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_MemberType(){} // RVA: 0x87C130
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_DeclaringType(){} // RVA: 0x87C0A0
        public void get_ReflectedType(){} // RVA: 0x87C0A0
        public void get_Module(){} // RVA: 0x6800B00
        public void IsDefined(){} // RVA: 0x87F360
        public void GetCustomAttributes(){} // RVA: 0x87D1A0
        public void GetCustomAttributesData(){} // RVA: 0x6800BA0
        public void get_MetadataToken(){} // RVA: 0x6800BD0
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void op_Equality(){} // RVA: 0x6800C10
        public void op_Inequality(){} // RVA: 0x6800FA0
    }

    public class MemberInfoSerializationHolder : Object
    {
        public object m_memberName;
        public object m_reflectedType;
        public object m_signature;
        public object m_signature2;
        public object m_memberType;
        public object m_info;

        // ── Methods ──
        public void GetSerializationInfo(){} // RVA: 0x68097D0
        public void .ctor(){} // RVA: 0x6809FE0
        public void GetObjectData(){} // RVA: 0x680A330
        public void GetRealObject(){} // RVA: 0x680A390
    }

    public class MemberInfo[] : Array
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

    public class MethodBase : MemberInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void GetParameters(){} // RVA: 0x87C0A0
        public void get_Attributes(){} // RVA: 0x87C130
        public void get_MethodImplementationFlags(){} // RVA: 0x6800FC0
        public void GetMethodImplementationFlags(){} // RVA: 0x87C130
        public void GetMethodBody(){} // RVA: 0x6800FE0
        public void get_CallingConvention(){} // RVA: 0xC3CCE0
        public void get_IsAbstract(){} // RVA: 0x6801020
        public void get_IsConstructor(){} // RVA: 0x6801050
        public void get_IsSpecialName(){} // RVA: 0x68010F0
        public void get_IsStatic(){} // RVA: 0x6801120
        public void get_IsVirtual(){} // RVA: 0x6801150
        public void get_IsAssembly(){} // RVA: 0x6801180
        public void get_IsFamilyAndAssembly(){} // RVA: 0x68011B0
        public void get_IsPrivate(){} // RVA: 0x68011E0
        public void get_IsPublic(){} // RVA: 0x6801210
        public void get_IsGenericMethod(){} // RVA: 0xB43320
        public void get_IsGenericMethodDefinition(){} // RVA: 0xB43320
        public void GetGenericArguments(){} // RVA: 0x6801240
        public void get_ContainsGenericParameters(){} // RVA: 0xB43320
        public void Invoke(){} // RVA: 0x88DC00
        public void get_MethodHandle(){} // RVA: 0x87C0A0
        public void get_IsSecurityCritical(){} // RVA: 0x68012D0
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void op_Equality(){} // RVA: 0x6801300
        public void op_Inequality(){} // RVA: 0x6801580
        public void GetParametersInternal(){} // RVA: 0x2597FF0
        public void GetParametersCount(){} // RVA: 0x68015A0
        public void FormatNameAndSig(){} // RVA: 0x68015D0
        public void GetParameterTypes(){} // RVA: 0x6801740
        public void GetParametersNoCopy(){} // RVA: 0x2597FF0
        public void GetMethodFromHandle(){} // RVA: 0x6801B00
        public void ConstructParameters(){} // RVA: 0x6801C00
    }

    public class MethodBase[] : Array
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

    public class MethodBody : Object
    {
        public object clauses;
        public object locals;
        public object il;
        public object init_locals;
        public object sig_token;
        public object max_stack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6812710
        public void get_LocalVariables(){} // RVA: 0x6812830
        public void GetILAsByteArray(){} // RVA: 0xB700F0
    }

    public class MethodInfo : MethodBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_MemberType(){} // RVA: 0x17FCE50
        public void get_ReturnParameter(){} // RVA: 0x6801E60
        public void get_ReturnType(){} // RVA: 0x6801E90
        public void GetGenericArguments(){} // RVA: 0x6801EC0
        public void GetGenericMethodDefinition(){} // RVA: 0x6801F10
        public void MakeGenericMethod(){} // RVA: 0x6801F60
        public void GetBaseDefinition(){} // RVA: 0x87C0A0
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x87C0A0
        public void CreateDelegate(){} // RVA: 0x6802000
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void op_Equality(){} // RVA: 0x6544B10
        public void op_Inequality(){} // RVA: 0x67D1130
        public void get_GenericParameterCount(){} // RVA: 0x6802050
    }

    public class MethodInfo[] : Array
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

    public class Missing : Object
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6802080
        public void .cctor(){} // RVA: 0x68020C0
    }

    public class MissingMetadataException : TypeAccessException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6809630
    }

    public class Module : Object
    {
        public object FilterTypeName;
        public object FilterTypeNameIgnoreCase;
        public object DefaultLookup;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Assembly(){} // RVA: 0x6802160
        public void get_FullyQualifiedName(){} // RVA: 0x6802190
        public void get_Name(){} // RVA: 0x68021C0
        public void get_ModuleVersionId(){} // RVA: 0x68021F0
        public void get_ScopeName(){} // RVA: 0x6802220
        public void IsResource(){} // RVA: 0x6802250
        public void IsDefined(){} // RVA: 0x6802280
        public void GetCustomAttributesData(){} // RVA: 0x68022B0
        public void GetCustomAttributes(){} // RVA: 0x6802310
        public void ResolveMember(){} // RVA: 0x6802340
        public void GetObjectData(){} // RVA: 0x6802370
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void op_Equality(){} // RVA: 0x6544B10
        public void ToString(){} // RVA: 0x14B3B70
        public void FilterTypeNameImpl(){} // RVA: 0x68023A0
        public void FilterTypeNameIgnoreCaseImpl(){} // RVA: 0x68025F0
        public void GetModuleVersionId(){} // RVA: 0x6802980
        public void .cctor(){} // RVA: 0x68029C0
    }

    public class MonoMethodInfo : ValueType
    {
        public object parent;
        public object ret;
        public object attrs;
        public object iattrs;
        public object callconv;

        // ── Methods ──
        public void get_method_info(){} // RVA: 0x6815870
        public void get_method_attributes(){} // RVA: 0x6815A00
        public void GetMethodInfo(){} // RVA: 0x6815A10
        public void GetDeclaringType(){} // RVA: 0x6815BB0
        public void GetReturnType(){} // RVA: 0x6815BD0
        public void GetAttributes(){} // RVA: 0x6815A00
        public void GetCallingConvention(){} // RVA: 0x6815C00
        public void GetMethodImplementationFlags(){} // RVA: 0x6815C20
        public void get_parameter_info(){} // RVA: 0x6815C50
        public void GetParametersInfo(){} // RVA: 0x6815C50
        public void get_retval_marshal(){} // RVA: 0xDAC980
        public void GetReturnParameterInfo(){} // RVA: 0x6815C90
    }

    public class NullabilityInfo : Object
    {
        public object _type;
        public object _readState;
        public object _writeState;
        public object _elementType;
        public object _genericTypeArguments;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EC9A10
        public void get_Type(){} // RVA: 0xB5DBF0
        public void get_ReadState(){} // RVA: 0xE62D00
        public void set_ReadState(){} // RVA: 0x1033F40
        public void get_WriteState(){} // RVA: 0x2244FB0
        public void set_WriteState(){} // RVA: 0x22735B0
        public void get_ElementType(){} // RVA: 0xB700F0
        public void get_GenericTypeArguments(){} // RVA: 0xB70160
    }

    public class NullabilityInfoContext : Object
    {
        public object CompilerServicesNameSpace;
        public object _publicOnlyModules;
        public object _context;
        public object _isSupported;

        // ── Methods ──
        public void get_IsSupported(){} // RVA: 0x6EC9B20
        public void GetNullableContext(){} // RVA: 0x6EC9B80
        public void Create(){} // RVA: 0x6ECB2D0
        public void CheckParameterMetadataType(){} // RVA: 0x6ECA270
        public void GetMethodMetadataDefinition(){} // RVA: 0x6ECA600
        public void CheckNullabilityAttributes(){} // RVA: 0x6ECA700
        public void IsPrivateOrInternalMethodAndAnnotationDisabled(){} // RVA: 0x6ECB080
        public void EnsureIsSupported(){} // RVA: 0x6ECB550
        public void IsPrivateOrInternalFieldAndAnnotationDisabled(){} // RVA: 0x6ECB630
        public void IsPublicOnly(){} // RVA: 0x6ECB780
        public void PopulateAnnotationInfo(){} // RVA: 0x6ECB910
        public void GetNullabilityInfo(){} // RVA: 0x6ECBD60
        public void CreateParser(){} // RVA: 0x6ECC270
        public void TryLoadGenericMetaTypeNullability(){} // RVA: 0x6ECC660
        public void GetMemberMetadataDefinition(){} // RVA: 0x6ECC8A0
        public void GetPropertyMetaType(){} // RVA: 0x6ECC9A0
        public void CheckGenericParameters(){} // RVA: 0x6ECCA60
        public void TryUpdateGenericParameterNullability(){} // RVA: 0x6ECCC40
        public void TryUpdateGenericTypeParameterNullabilityFromReflectedType(){} // RVA: 0x6ECCE80
        public void TryPopulateNullabilityInfo(){} // RVA: 0x6ECD1F0
        public void TranslateByte(){} // RVA: 0x6ECD450
        public void IsValueTypeOrValueTypeByRef(){} // RVA: 0x6ECD470
        public void .ctor(){} // RVA: 0x6ECD520
        public void .cctor(){} // RVA: 0x6ECD680
        public void <TryUpdateGenericTypeParameterNullabilityFromReflectedType>g__CountNullabilityStates|28_0(){} // RVA: 0x6ECD720
    }

    public class ObfuscationAttribute : Attribute
    {
        public object _stripAfterObfuscation;
        public object _exclude;
        public object _applyToMembers;
        public object _feature;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6802B50
        public void set_Exclude(){} // RVA: 0xDD7A00
    }

    public class ParameterInfo : Object
    {
        public object AttrsImpl;
        public object ClassImpl;
        public object DefaultValueImpl;
        public object MemberImpl;
        public object NameImpl;
        public object PositionImpl;
        public object MetadataToken_ParamDef;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Attributes(){} // RVA: 0xB8F8F0
        public void get_Member(){} // RVA: 0xB70160
        public void get_Name(){} // RVA: 0xD33E60
        public void get_ParameterType(){} // RVA: 0xB465B0
        public void get_Position(){} // RVA: 0x18A0130
        public void get_IsIn(){} // RVA: 0x6802BE0
        public void get_IsOptional(){} // RVA: 0x6802C00
        public void get_IsOut(){} // RVA: 0x6802C30
        public void get_DefaultValue(){} // RVA: 0x6802C60
        public void get_HasDefaultValue(){} // RVA: 0x6802C90
        public void IsDefined(){} // RVA: 0x6802CC0
        public void GetCustomAttributesData(){} // RVA: 0x6802D40
        public void GetCustomAttributes(){} // RVA: 0x6802DB0
        public void GetRealObject(){} // RVA: 0x6802E50
        public void ToString(){} // RVA: 0x6803220
    }

    public class ParameterInfo[] : Array
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

    public class Pointer : Object
    {
        public object _ptr;
        public object _ptrType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68032D0
        public void Box(){} // RVA: 0x6803330
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x6803520
    }

    public class PropertyInfo : MemberInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_MemberType(){} // RVA: 0x2AFB680
        public void get_PropertyType(){} // RVA: 0x87C0A0
        public void GetIndexParameters(){} // RVA: 0x87C0A0
        public void get_Attributes(){} // RVA: 0x87C130
        public void get_CanRead(){} // RVA: 0x87D280
        public void get_CanWrite(){} // RVA: 0x87D280
        public void GetAccessors(){} // RVA: 0x881D20
        public void get_GetMethod(){} // RVA: 0x6803560
        public void GetGetMethod(){} // RVA: 0x881D20
        public void get_SetMethod(){} // RVA: 0x68035A0
        public void GetSetMethod(){} // RVA: 0x881D20
        public void GetValue(){} // RVA: 0x88DC00
        public void SetValue(){} // RVA: 0x89E3F0
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void op_Equality(){} // RVA: 0x6544B10
        public void op_Inequality(){} // RVA: 0x67D1130
    }

    public class PropertyInfo[] : Array
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

    public class ReflectionTypeLoadException : SystemException
    {
        public object _types;
        public object _loaderExceptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68037E0
        public void GetObjectData(){} // RVA: 0x68039C0
        public void get_LoaderExceptions(){} // RVA: 0x106A7D0
        public void get_Message(){} // RVA: 0x6803C70
        public void ToString(){} // RVA: 0x6803C80
        public void CreateString(){} // RVA: 0x6803C90
    }

    public class RtFieldInfo : FieldInfo
    {
        // ── Methods ──
        public void UnsafeGetValue(){} // RVA: 0x87C540
        public void UnsafeSetValue(){} // RVA: 0x89E390
        public void CheckConsistency(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RuntimeAssembly : Assembly
    {
        public object _mono_assembly;
        public object _evidence;
        public object resolve_event_holder;
        public object _minimum;
        public object _optional;
        public object _refuse;
        public object _granted;
        public object _denied;
        public object fromByteArray;
        public object assemblyName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6812870
        public void GetObjectData(){} // RVA: 0x6812900
        public void LoadWithPartialNameInternal(){} // RVA: 0x6812A30
        public void GetName(){} // RVA: 0x6812A80
        public void GetType(){} // RVA: 0x6812A90
        public void GetModule(){} // RVA: 0x6812B60
        public void GetReferencedAssemblies(){} // RVA: 0x6812CF0
        public void GetModules(){} // RVA: 0x6812D00
        public void get_ManifestModule(){} // RVA: 0x6812E50
        public void GetAotId(){} // RVA: 0x6812E70
        public void get_code_base(){} // RVA: 0x6812EB0
        public void get_location(){} // RVA: 0x6812FD0
        public void get_fullname(){} // RVA: 0x6813070
        public void GetAotIdInternal(){} // RVA: 0xB43320
        public void get_ReflectionOnly(){} // RVA: 0xB43320
        public void GetCodeBase(){} // RVA: 0x6812EB0
        public void get_CodeBase(){} // RVA: 0x6813110
        public void get_EscapedCodeBase(){} // RVA: 0x6813120
        public void get_FullName(){} // RVA: 0x6813070
        public void get_MonoAssembly(){} // RVA: 0xB5DBF0
        public void get_Location(){} // RVA: 0x6813130
        public void GetManifestResourceInfoInternal(){} // RVA: 0x68131F0
        public void GetManifestResourceInfo(){} // RVA: 0x6813200
        public void GetManifestResourceNames(){} // RVA: 0x68133D0
        public void GetManifestResourceInternal(){} // RVA: 0x68133E0
        public void GetManifestResourceStream(){} // RVA: 0x68133F0
        public void IsDefined(){} // RVA: 0x6813990
        public void GetCustomAttributes(){} // RVA: 0x6813A60
        public void GetManifestModule(){} // RVA: 0x6813AD0
        public void GetManifestModuleInternal(){} // RVA: 0x6813AE0
        public void GetModulesInternal(){} // RVA: 0x6813AF0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void Equals(){} // RVA: 0x6813B90
        public void ToString(){} // RVA: 0x6813C50
    }

    public class RuntimeAssembly[] : Array
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

    public class RuntimeConstructorInfo : ConstructorInfo
    {
        public object mhandle;
        public object name;
        public object reftype;

        // ── Methods ──
        public void get_Module(){} // RVA: 0x68186F0
        public void GetRuntimeModule(){} // RVA: 0x68186F0
        public void get_BindingFlags(){} // RVA: 0xDAC980
        public void get_ReflectedTypeInternal(){} // RVA: 0x6818790
        public void GetObjectData(){} // RVA: 0x6818820
        public void SerializationToString(){} // RVA: 0x68189A0
        public void SerializationInvoke(){} // RVA: 0x68189C0
        public void GetMethodImplementationFlags(){} // RVA: 0x6816750
        public void GetParameters(){} // RVA: 0x6816830
        public void GetParametersInternal(){} // RVA: 0x6816830
        public void GetParametersCount(){} // RVA: 0x6818B20
        public void InternalInvoke(){} // RVA: 0x6818F30
        public void Invoke(){} // RVA: 0x6819020
        public void DoInvoke(){} // RVA: 0x6818CC0
        public void get_MethodHandle(){} // RVA: 0xB5DBF0
        public void get_Attributes(){} // RVA: 0x6816F20
        public void get_CallingConvention(){} // RVA: 0x6816F30
        public void get_ContainsGenericParameters(){} // RVA: 0x6819050
        public void get_ReflectedType(){} // RVA: 0xB700F0
        public void get_DeclaringType(){} // RVA: 0x6816F50
        public void get_Name(){} // RVA: 0x6816F70
        public void IsDefined(){} // RVA: 0x6819090
        public void GetCustomAttributes(){} // RVA: 0x6819160
        public void GetMethodBody(){} // RVA: 0x68186E0
        public void ToString(){} // RVA: 0x68191D0
        public void GetCustomAttributesData(){} // RVA: 0x6814840
        public void get_core_clr_security_level(){} // RVA: 0xC3CCE0
        public void get_IsSecurityCritical(){} // RVA: 0xC2E4C0
        public void get_MetadataToken(){} // RVA: 0x6814850
        public void get_metadata_token(){} // RVA: 0x6814850
        public void .ctor(){} // RVA: 0x6819230
    }

    public class RuntimeConstructorInfo[] : Array
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

    public class RuntimeEventInfo : EventInfo
    {
        public object klass;
        public object handle;

        // ── Methods ──
        public void get_event_info(){} // RVA: 0x6813E40
        public void GetEventInfo(){} // RVA: 0x6813F50
        public void get_Module(){} // RVA: 0x6814070
        public void get_BindingFlags(){} // RVA: 0x68140A0
        public void GetDeclaringTypeInternal(){} // RVA: 0x68140B0
        public void get_ReflectedTypeInternal(){} // RVA: 0x6814140
        public void GetRuntimeModule(){} // RVA: 0x6814070
        public void GetObjectData(){} // RVA: 0x68141D0
        public void GetBindingFlags(){} // RVA: 0x6814310
        public void GetAddMethod(){} // RVA: 0x6814480
        public void GetRaiseMethod(){} // RVA: 0x6814500
        public void GetRemoveMethod(){} // RVA: 0x6814580
        public void get_DeclaringType(){} // RVA: 0x6814600
        public void get_ReflectedType(){} // RVA: 0x6814620
        public void get_Name(){} // RVA: 0x6814640
        public void ToString(){} // RVA: 0x6814660
        public void IsDefined(){} // RVA: 0x6814700
        public void GetCustomAttributes(){} // RVA: 0x68147D0
        public void GetCustomAttributesData(){} // RVA: 0x6814840
        public void get_MetadataToken(){} // RVA: 0x6814850
        public void get_metadata_token(){} // RVA: 0x6814850
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RuntimeEventInfo[] : Array
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

    public class RuntimeFieldInfo : RtFieldInfo
    {
        public object klass;
        public object fhandle;
        public object name;
        public object type;
        public object attrs;

        // ── Methods ──
        public void get_BindingFlags(){} // RVA: 0xDAC980
        public void get_Module(){} // RVA: 0x6814870
        public void GetDeclaringTypeInternal(){} // RVA: 0x68148A0
        public void get_ReflectedTypeInternal(){} // RVA: 0x6814930
        public void GetRuntimeModule(){} // RVA: 0x6814870
        public void GetObjectData(){} // RVA: 0x68149C0
        public void UnsafeGetValue(){} // RVA: 0x6814B20
        public void CheckConsistency(){} // RVA: 0x6814B30
        public void UnsafeSetValue(){} // RVA: 0x6814CF0
        public void SetValueDirect(){} // RVA: 0x6814D40
        public void get_Attributes(){} // RVA: 0xB9E080
        public void get_FieldHandle(){} // RVA: 0xB465B0
        public void ResolveType(){} // RVA: 0x6814ED0
        public void get_FieldType(){} // RVA: 0x6814EE0
        public void GetParentType(){} // RVA: 0x6814F30
        public void get_ReflectedType(){} // RVA: 0x6814F60
        public void get_DeclaringType(){} // RVA: 0x6814F70
        public void get_Name(){} // RVA: 0xB700F0
        public void IsDefined(){} // RVA: 0x6814F90
        public void GetCustomAttributes(){} // RVA: 0x6815060
        public void GetFieldOffset(){} // RVA: 0x68150D0
        public void GetValueInternal(){} // RVA: 0x6814B20
        public void GetValue(){} // RVA: 0x68150E0
        public void ToString(){} // RVA: 0x68152B0
        public void SetValueInternal(){} // RVA: 0x6815350
        public void SetValue(){} // RVA: 0x6815360
        public void GetRawConstantValue(){} // RVA: 0x6815660
        public void GetCustomAttributesData(){} // RVA: 0x6814840
        public void CheckGeneric(){} // RVA: 0x68157D0
        public void get_MetadataToken(){} // RVA: 0x6814850
        public void get_metadata_token(){} // RVA: 0x6814850
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RuntimeFieldInfo[] : Array
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

    public class RuntimeMethodInfo : MethodInfo
    {
        public object mhandle;
        public object name;
        public object reftype;

        // ── Methods ──
        public void get_BindingFlags(){} // RVA: 0xDAC980
        public void get_Module(){} // RVA: 0x6815E70
        public void get_ReflectedTypeInternal(){} // RVA: 0x6815F10
        public void FormatNameAndSig(){} // RVA: 0x6815FA0
        public void CreateDelegate(){} // RVA: 0x68162C0
        public void ToString(){} // RVA: 0x68162F0
        public void GetRuntimeModule(){} // RVA: 0x6815E70
        public void GetObjectData(){} // RVA: 0x68163A0
        public void SerializationToString(){} // RVA: 0x6816570
        public void GetMethodFromHandleNoGenericCheck(){} // RVA: 0x6816630
        public void GetMethodBodyInternal(){} // RVA: 0x6816680
        public void GetMethodBody(){} // RVA: 0x68186E0
        public void GetMethodFromHandleInternalType(){} // RVA: 0x68166A0
        public void GetMethodFromHandleInternalType_native(){} // RVA: 0x68166B0
        public void .ctor(){} // RVA: 0xB43310
        public void get_name(){} // RVA: 0x68166C0
        public void get_base_method(){} // RVA: 0x68166E0
        public void get_metadata_token(){} // RVA: 0x6814850
        public void GetBaseDefinition(){} // RVA: 0x68166F0
        public void GetBaseMethod(){} // RVA: 0x6816700
        public void get_ReturnParameter(){} // RVA: 0x6816710
        public void get_ReturnType(){} // RVA: 0x6816720
        public void get_ReturnTypeCustomAttributes(){} // RVA: 0x6816710
        public void get_MetadataToken(){} // RVA: 0x6814850
        public void GetMethodImplementationFlags(){} // RVA: 0x6816750
        public void GetParameters(){} // RVA: 0x6816780
        public void GetParametersInternal(){} // RVA: 0x6816830
        public void GetParametersCount(){} // RVA: 0x6816880
        public void InternalInvoke(){} // RVA: 0x68168D0
        public void Invoke(){} // RVA: 0x68168E0
        public void ConvertValues(){} // RVA: 0x6816BB0
        public void get_MethodHandle(){} // RVA: 0xB5DBF0
        public void get_Attributes(){} // RVA: 0x6816F20
        public void get_CallingConvention(){} // RVA: 0x6816F30
        public void get_ReflectedType(){} // RVA: 0xB700F0
        public void get_DeclaringType(){} // RVA: 0x6816F50
        public void get_Name(){} // RVA: 0x6816F70
        public void IsDefined(){} // RVA: 0x6816FA0
        public void GetCustomAttributes(){} // RVA: 0x6817070
        public void GetPInvoke(){} // RVA: 0x68170E0
        public void GetPseudoCustomAttributes(){} // RVA: 0x6817190
        public void GetPseudoCustomAttributesData(){} // RVA: 0x6817340
        public void GetDllImportAttributeData(){} // RVA: 0x68175A0
        public void MakeGenericMethod(){} // RVA: 0x6818180
        public void MakeGenericMethod_impl(){} // RVA: 0x68184E0
        public void GetGenericArguments(){} // RVA: 0x68184F0
        public void GetGenericMethodDefinition_impl(){} // RVA: 0x6818500
        public void GetGenericMethodDefinition(){} // RVA: 0x6818530
        public void get_IsGenericMethodDefinition(){} // RVA: 0x68185B0
        public void get_IsGenericMethod(){} // RVA: 0x68185C0
        public void get_ContainsGenericParameters(){} // RVA: 0x68185F0
        public void GetCustomAttributesData(){} // RVA: 0x6814840
        public void get_core_clr_security_level(){} // RVA: 0xC3CCE0
        public void get_IsSecurityCritical(){} // RVA: 0xC2E4C0
    }

    public class RuntimeMethodInfo[] : Array
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

    public class RuntimeModule : Module
    {
        public object _impl;
        public object assembly;
        public object fqname;
        public object name;
        public object scopename;
        public object is_resource;
        public object token;

        // ── Methods ──
        public void get_Assembly(){} // RVA: 0xB465B0
        public void get_Name(){} // RVA: 0xB70160
        public void get_ScopeName(){} // RVA: 0xD33E60
        public void get_ModuleVersionId(){} // RVA: 0x6819280
        public void get_FullyQualifiedName(){} // RVA: 0xB700F0
        public void IsResource(){} // RVA: 0xD16660
        public void GetCustomAttributes(){} // RVA: 0x6819310
        public void IsDefined(){} // RVA: 0x6819380
        public void ResolveMember(){} // RVA: 0x6819420
        public void GetObjectData(){} // RVA: 0x6819480
        public void GetCustomAttributesData(){} // RVA: 0x6810FC0
        public void GetRuntimeAssembly(){} // RVA: 0x6819590
        public void GetModuleVersionId(){} // RVA: 0x6819610
        public void resolve_token_exception(){} // RVA: 0x6819710
        public void ptrs_from_types(){} // RVA: 0x68198C0
        public void GetGuidInternal(){} // RVA: 0xB43310
        public void ResolveMemberToken(){} // RVA: 0x6819A10
        public void .ctor(){} // RVA: 0x6819A30
    }

    public class RuntimeParameterInfo : ParameterInfo
    {
        public object marshalAs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x681A190
        public void FormatParameters(){} // RVA: 0x6819C50
        public void get_DefaultValue(){} // RVA: 0x681A310
        public void GetCustomAttributes(){} // RVA: 0x681A730
        public void GetDefaultValueImpl(){} // RVA: 0x681A7A0
        public void IsDefined(){} // RVA: 0x681A880
        public void GetCustomAttributesData(){} // RVA: 0x68110B0
        public void GetPseudoCustomAttributes(){} // RVA: 0x681A8F0
        public void GetPseudoCustomAttributesData(){} // RVA: 0x681AC00
        public void get_HasDefaultValue(){} // RVA: 0x681B3B0
        public void New(){} // RVA: 0x681B590
    }

    public class RuntimeParameterInfo[] : Array
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

    public class RuntimePropertyInfo : PropertyInfo
    {
        public object klass;
        public object prop;
        public object info;
        public object cached;
        public object cached_getter;

        // ── Methods ──
        public void get_property_info(){} // RVA: 0x681B740
        public void get_BindingFlags(){} // RVA: 0xDAC980
        public void get_Module(){} // RVA: 0x681B750
        public void GetDeclaringTypeInternal(){} // RVA: 0x681B7F0
        public void get_ReflectedTypeInternal(){} // RVA: 0x681B880
        public void GetRuntimeModule(){} // RVA: 0x681B750
        public void ToString(){} // RVA: 0x681B910
        public void FormatNameAndSig(){} // RVA: 0x681B920
        public void GetObjectData(){} // RVA: 0x681BAE0
        public void SerializationToString(){} // RVA: 0x681BC60
        public void CachePropertyInfo(){} // RVA: 0x681BC70
        public void get_Attributes(){} // RVA: 0x681BCB0
        public void get_CanRead(){} // RVA: 0x681BCF0
        public void get_CanWrite(){} // RVA: 0x681BD20
        public void get_PropertyType(){} // RVA: 0x681BD50
        public void get_ReflectedType(){} // RVA: 0x681BE00
        public void get_DeclaringType(){} // RVA: 0x681BE40
        public void get_Name(){} // RVA: 0x681BE80
        public void GetAccessors(){} // RVA: 0x681BEC0
        public void GetGetMethod(){} // RVA: 0x681C050
        public void GetIndexParameters(){} // RVA: 0x681C0C0
        public void GetSetMethod(){} // RVA: 0x681C350
        public void IsDefined(){} // RVA: 0x681C3C0
        public void GetCustomAttributes(){} // RVA: 0x681C490
        public void GetterAdapterFrame(){} // RVA: 0x87C630
        public void StaticGetterAdapterFrame(){} // RVA: 0x87C630
        public void GetValue(){} // RVA: 0x681C500
        public void SetValue(){} // RVA: 0x681C6B0
        public void GetCustomAttributesData(){} // RVA: 0x6814840
        public void get_MetadataToken(){} // RVA: 0x6814850
        public void get_metadata_token(){} // RVA: 0x6814850
        public void internal_from_handle_type(){} // RVA: 0x681C8D0
        public void GetPropertyFromHandle(){} // RVA: 0x681C930
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RuntimePropertyInfo[] : Array
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

    public class RuntimeReflectionExtensions : Object
    {
        // ── Methods ──
        public void GetRuntimeMethod(){} // RVA: 0x6807830
        public void GetRuntimeProperty(){} // RVA: 0x68078F0
        public void GetMethodInfo(){} // RVA: 0x6807A00
    }

    public class SignatureArrayType : SignatureHasElementType
    {
        public object _rank;
        public object _isMultiDim;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6803E20
        public void IsArrayImpl(){} // RVA: 0xC2E4C0
        public void IsByRefImpl(){} // RVA: 0xB43320
        public void IsPointerImpl(){} // RVA: 0xB43320
        public void get_IsSZArray(){} // RVA: 0x6803E60
        public void get_IsVariableBoundArray(){} // RVA: 0xB5E030
        public void GetArrayRank(){} // RVA: 0xFEAE90
        public void get_Suffix(){} // RVA: 0x6803E70
    }

    public class SignatureByRefType : SignatureHasElementType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6803F30
        public void IsArrayImpl(){} // RVA: 0xB43320
        public void IsByRefImpl(){} // RVA: 0xC2E4C0
        public void IsPointerImpl(){} // RVA: 0xB43320
        public void get_IsSZArray(){} // RVA: 0xB43320
        public void get_IsVariableBoundArray(){} // RVA: 0xB43320
        public void GetArrayRank(){} // RVA: 0x6803F40
        public void get_Suffix(){} // RVA: 0x6803F90
    }

    public class SignatureConstructedGenericType : SignatureType
    {
        public object _genericTypeDefinition;
        public object _genericTypeArguments;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6803FD0
        public void get_IsGenericTypeDefinition(){} // RVA: 0xB43320
        public void HasElementTypeImpl(){} // RVA: 0xB43320
        public void IsArrayImpl(){} // RVA: 0xB43320
        public void IsByRefImpl(){} // RVA: 0xB43320
        public void IsPointerImpl(){} // RVA: 0xB43320
        public void get_IsSZArray(){} // RVA: 0xB43320
        public void get_IsVariableBoundArray(){} // RVA: 0xB43320
        public void get_IsConstructedGenericType(){} // RVA: 0xC2E4C0
        public void get_IsGenericParameter(){} // RVA: 0xB43320
        public void get_IsGenericMethodParameter(){} // RVA: 0xB43320
        public void get_ContainsGenericParameters(){} // RVA: 0x68041F0
        public void get_ElementType(){} // RVA: 0xDAC980
        public void GetArrayRank(){} // RVA: 0x6804290
        public void GetGenericTypeDefinition(){} // RVA: 0xB465B0
        public void GetGenericArguments(){} // RVA: 0x68042E0
        public void get_GenericTypeArguments(){} // RVA: 0x6804300
        public void get_GenericParameterPosition(){} // RVA: 0x6804380
        public void get_Name(){} // RVA: 0x68043D0
        public void get_Namespace(){} // RVA: 0x5C6C5A0
        public void ToString(){} // RVA: 0x6804400
    }

    public class SignatureHasElementType : SignatureType
    {
        public object _elementType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68045F0
        public void get_IsGenericTypeDefinition(){} // RVA: 0xB43320
        public void HasElementTypeImpl(){} // RVA: 0xC2E4C0
        public void IsArrayImpl(){} // RVA: 0x87D280
        public void IsByRefImpl(){} // RVA: 0x87D280
        public void IsPointerImpl(){} // RVA: 0x87D280
        public void get_IsSZArray(){} // RVA: 0x87D280
        public void get_IsVariableBoundArray(){} // RVA: 0x87D280
        public void get_IsConstructedGenericType(){} // RVA: 0xB43320
        public void get_IsGenericParameter(){} // RVA: 0xB43320
        public void get_IsGenericMethodParameter(){} // RVA: 0xB43320
        public void get_ContainsGenericParameters(){} // RVA: 0x6804670
        public void get_ElementType(){} // RVA: 0xB465B0
        public void GetArrayRank(){} // RVA: 0x87C130
        public void GetGenericTypeDefinition(){} // RVA: 0x68046A0
        public void GetGenericArguments(){} // RVA: 0x68046F0
        public void get_GenericTypeArguments(){} // RVA: 0x6804730
        public void get_GenericParameterPosition(){} // RVA: 0x6804770
        public void get_Name(){} // RVA: 0x68047C0
        public void get_Namespace(){} // RVA: 0x5C6C5A0
        public void ToString(){} // RVA: 0x6804830
        public void get_Suffix(){} // RVA: 0x87C0A0
    }

    public class SignaturePointerType : SignatureHasElementType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6803F30
        public void IsArrayImpl(){} // RVA: 0xB43320
        public void IsByRefImpl(){} // RVA: 0xB43320
        public void IsPointerImpl(){} // RVA: 0xC2E4C0
        public void get_IsSZArray(){} // RVA: 0xB43320
        public void get_IsVariableBoundArray(){} // RVA: 0xB43320
        public void GetArrayRank(){} // RVA: 0x68048A0
        public void get_Suffix(){} // RVA: 0x68048F0
    }

    public class SignatureType : Type
    {
        // ── Methods ──
        public void get_IsSignatureType(){} // RVA: 0xC2E4C0
        public void HasElementTypeImpl(){} // RVA: 0x87D280
        public void IsArrayImpl(){} // RVA: 0x87D280
        public void get_IsSZArray(){} // RVA: 0x87D280
        public void get_IsVariableBoundArray(){} // RVA: 0x87D280
        public void IsByRefImpl(){} // RVA: 0x87D280
        public void IsPointerImpl(){} // RVA: 0x87D280
        public void get_IsGenericType(){} // RVA: 0x6804930
        public void get_IsGenericTypeDefinition(){} // RVA: 0x87D280
        public void get_IsConstructedGenericType(){} // RVA: 0x87D280
        public void get_IsGenericParameter(){} // RVA: 0x87D280
        public void get_IsGenericMethodParameter(){} // RVA: 0x87D280
        public void get_ContainsGenericParameters(){} // RVA: 0x87D280
        public void get_MemberType(){} // RVA: 0x2AFBE90
        public void MakeArrayType(){} // RVA: 0x68049F0
        public void MakeByRefType(){} // RVA: 0x6804AA0
        public void MakePointerType(){} // RVA: 0x6804B00
        public void MakeGenericType(){} // RVA: 0x6804B60
        public void GetElementType(){} // RVA: 0x6804BB0
        public void GetArrayRank(){} // RVA: 0x87C130
        public void GetGenericTypeDefinition(){} // RVA: 0x87C0A0
        public void get_GenericTypeArguments(){} // RVA: 0x87C0A0
        public void GetGenericArguments(){} // RVA: 0x87C0A0
        public void get_GenericParameterPosition(){} // RVA: 0x87C130
        public void get_ElementType(){} // RVA: 0x87C0A0
        public void get_UnderlyingSystemType(){} // RVA: 0x2303260
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_Namespace(){} // RVA: 0x87C0A0
        public void get_FullName(){} // RVA: 0xDAC980
        public void get_AssemblyQualifiedName(){} // RVA: 0xDAC980
        public void ToString(){} // RVA: 0x87C0A0
        public void get_Assembly(){} // RVA: 0x6804BD0
        public void get_Module(){} // RVA: 0x6804C20
        public void get_ReflectedType(){} // RVA: 0x6804C70
        public void get_BaseType(){} // RVA: 0x6804CC0
        public void GetInterfaces(){} // RVA: 0x6804D10
        public void IsAssignableFrom(){} // RVA: 0x6804D60
        public void get_MetadataToken(){} // RVA: 0x6804DB0
        public void get_DeclaringType(){} // RVA: 0x6804E00
        public void get_DeclaringMethod(){} // RVA: 0x6804E50
        public void GetGenericParameterConstraints(){} // RVA: 0x6804EA0
        public void get_GenericParameterAttributes(){} // RVA: 0x6804EF0
        public void IsEnumDefined(){} // RVA: 0x6804F40
        public void GetEnumName(){} // RVA: 0x6804F90
        public void GetEnumNames(){} // RVA: 0x6804FE0
        public void GetEnumUnderlyingType(){} // RVA: 0x6805030
        public void GetEnumValues(){} // RVA: 0x6805080
        public void get_GUID(){} // RVA: 0x68050D0
        public void GetTypeCodeImpl(){} // RVA: 0x6805120
        public void GetAttributeFlagsImpl(){} // RVA: 0x6805170
        public void GetConstructors(){} // RVA: 0x68051C0
        public void GetEvent(){} // RVA: 0x6805210
        public void GetEvents(){} // RVA: 0x6805260
        public void GetField(){} // RVA: 0x68052B0
        public void GetFields(){} // RVA: 0x6805300
        public void GetMembers(){} // RVA: 0x6805350
        public void GetMethods(){} // RVA: 0x68053A0
        public void GetNestedType(){} // RVA: 0x68053F0
        public void GetProperties(){} // RVA: 0x6805440
        public void InvokeMember(){} // RVA: 0x6805490
        public void GetMethodImpl(){} // RVA: 0x68054E0
        public void GetPropertyImpl(){} // RVA: 0x6805530
        public void GetMember(){} // RVA: 0x68055D0
        public void GetCustomAttributes(){} // RVA: 0x6805670
        public void IsDefined(){} // RVA: 0x68056C0
        public void GetCustomAttributesData(){} // RVA: 0x6805710
        public void GetInterface(){} // RVA: 0x6805760
        public void GetConstructorImpl(){} // RVA: 0x68057B0
        public void IsCOMObjectImpl(){} // RVA: 0x6805800
        public void IsPrimitiveImpl(){} // RVA: 0x6805850
        public void IsContextfulImpl(){} // RVA: 0x68058A0
        public void get_IsEnum(){} // RVA: 0x68058F0
        public void IsEquivalentTo(){} // RVA: 0x6805940
        public void IsInstanceOfType(){} // RVA: 0x6805990
        public void IsMarshalByRefImpl(){} // RVA: 0x68059E0
        public void get_IsSecurityCritical(){} // RVA: 0x6805A30
        public void get_IsSecuritySafeCritical(){} // RVA: 0x6805A80
        public void get_IsSecurityTransparent(){} // RVA: 0x6805AD0
        public void get_IsSerializable(){} // RVA: 0x6805B20
        public void IsSubclassOf(){} // RVA: 0x6805B70
        public void IsValueTypeImpl(){} // RVA: 0x6805BC0
        public void get_TypeHandle(){} // RVA: 0x6805C10
        public void .ctor(){} // RVA: 0x6805C60
    }

    public class SignatureTypeExtensions : Object
    {
        // ── Methods ──
        public void MatchesParameterTypeExactly(){} // RVA: 0x6805C80
        public void MatchesExactly(){} // RVA: 0x6805D50
        public void TryResolveAgainstGenericMethod(){} // RVA: 0x6806190
        public void TryResolve(){} // RVA: 0x68061D0
        public void TryMakeArrayType(){} // RVA: 0x6806620
        public void TryMakeByRefType(){} // RVA: 0x6806650
        public void TryMakePointerType(){} // RVA: 0x6806680
        public void TryMakeGenericType(){} // RVA: 0x68066B0
    }

    public class StrongNameKeyPair : Object
    {
        public object _publicKey;
        public object _keyPairContainer;
        public object _keyPairExported;
        public object _keyPairArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x681CA30
        public void System.Runtime.Serialization.ISerializable.GetObjectData(){} // RVA: 0x681CD70
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0xB43310
    }

    public class TargetException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67EC2E0
    }

    public class TargetInvocationException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67EC2E0
    }

    public class TargetParameterCountException : ApplicationException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67EC2E0
    }

    public class Throw : Object
    {
        // ── Methods ──
        public void InvalidCast(){} // RVA: 0x6D41390
        public void InvalidArgument(){} // RVA: 0x6D413D0
        public void InvalidToken(){} // RVA: 0x6D41430
        public void ArgumentNull(){} // RVA: 0x6D414B0
        public void ArgumentOutOfRange(){} // RVA: 0x6D41500
        public void OutOfBounds(){} // RVA: 0x6D41550
        public void InvalidHandle(){} // RVA: 0x6D415C0
        public void InvalidCompressedInteger(){} // RVA: 0x6D41630
        public void ImageTooSmall(){} // RVA: 0x6D416A0
        public void ImageTooSmallOrContainsInvalidOffsetOrCount(){} // RVA: 0x6D41710
        public void ReferenceOverflow(){} // RVA: 0x6D41780
        public void TableNotSorted(){} // RVA: 0x6D417F0
        public void InvalidOperation_PEImageNotAvailable(){} // RVA: 0x6D41890
        public void SequencePointValueOutOfRange(){} // RVA: 0x6D41900
        public void PEReaderDisposed(){} // RVA: 0x6D41970
    }

    public class TypeDelegator : TypeInfo
    {
        public object typeImpl;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6806850
        public void get_GUID(){} // RVA: 0x6806940
        public void get_MetadataToken(){} // RVA: 0x6806980
        public void InvokeMember(){} // RVA: 0x68069B0
        public void get_Module(){} // RVA: 0x6806A30
        public void get_Assembly(){} // RVA: 0x6806A60
        public void get_TypeHandle(){} // RVA: 0x6806A90
        public void get_Name(){} // RVA: 0x68043D0
        public void get_FullName(){} // RVA: 0x6806AC0
        public void get_Namespace(){} // RVA: 0x5C6C5A0
        public void get_AssemblyQualifiedName(){} // RVA: 0x6806AF0
        public void get_BaseType(){} // RVA: 0x6806B20
        public void GetConstructorImpl(){} // RVA: 0x6806B50
        public void GetConstructors(){} // RVA: 0x6806B80
        public void GetMethodImpl(){} // RVA: 0x6806BB0
        public void GetMethods(){} // RVA: 0x6806C80
        public void GetField(){} // RVA: 0x6806CB0
        public void GetFields(){} // RVA: 0x6806CE0
        public void GetInterface(){} // RVA: 0x6806D10
        public void GetInterfaces(){} // RVA: 0x6806D40
        public void GetEvent(){} // RVA: 0x6806D70
        public void GetPropertyImpl(){} // RVA: 0x6806DA0
        public void GetProperties(){} // RVA: 0x6806F70
        public void GetEvents(){} // RVA: 0x6806FA0
        public void GetNestedType(){} // RVA: 0x6806FD0
        public void GetMember(){} // RVA: 0x6807000
        public void GetMembers(){} // RVA: 0x6807030
        public void GetAttributeFlagsImpl(){} // RVA: 0x6807060
        public void get_IsSZArray(){} // RVA: 0x6807090
        public void IsArrayImpl(){} // RVA: 0x68070C0
        public void IsPrimitiveImpl(){} // RVA: 0x68070F0
        public void IsByRefImpl(){} // RVA: 0x6807120
        public void get_IsGenericMethodParameter(){} // RVA: 0x6807150
        public void IsPointerImpl(){} // RVA: 0x66DCF30
        public void IsValueTypeImpl(){} // RVA: 0x6807180
        public void IsCOMObjectImpl(){} // RVA: 0x68071B0
        public void get_IsConstructedGenericType(){} // RVA: 0x68071E0
        public void get_IsCollectible(){} // RVA: 0x6807210
        public void GetElementType(){} // RVA: 0x6807240
        public void HasElementTypeImpl(){} // RVA: 0x6807270
        public void get_UnderlyingSystemType(){} // RVA: 0x68072A0
        public void GetCustomAttributes(){} // RVA: 0x6807300
        public void IsDefined(){} // RVA: 0x6807330
    }

    public class TypeFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E3A9D0
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class TypeInfo : Type
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6805C60
        public void System.Reflection.IReflectableType.GetTypeInfo(){} // RVA: 0x2303260
        public void GetDeclaredMethods(){} // RVA: 0x6807360
        public void get_DeclaredFields(){} // RVA: 0x6807470
        public void get_ImplementedInterfaces(){} // RVA: 0x6807490
    }

}