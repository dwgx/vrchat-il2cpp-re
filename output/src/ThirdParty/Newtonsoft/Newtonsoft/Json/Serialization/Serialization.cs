// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Newtonsoft.Newtonsoft.Json.Serialization
// Classes: 49
// Methods: 641

namespace ThirdParty.Newtonsoft.Newtonsoft.Json.Serialization
{
    public class CachedAttributeGetter`1 : Object
    {
        // ── Methods ──
        public void GetAttribute(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class CamelCaseNamingStrategy : NamingStrategy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x3
        public void ResolvePropertyName(){} // RVA: 0x7FFE86B21D30
    }

    public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B21D40
        public void ResolveContract(){} // RVA: 0x7FFE86B21E10
        public void GetNameTable(){} // RVA: 0x7FFE86B223D0
        public void .cctor(){} // RVA: 0x7FFE86B22430
    }

    public class DefaultContractResolver : Object
    {
        public Newtonsoft.Json.Serialization.IContractResolver _instance;
        public string[] BlacklistedTypeNames; // 0x8
        public Newtonsoft.Json.JsonConverter[] BuiltInConverters; // 0x10
        public Newtonsoft.Json.DefaultJsonNameTable _nameTable; // 0x10
        public Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,Newtonsoft.Json.Serialization.JsonContract> _contractCache; // 0x18
        public 0x664D16A4 _defaultMembersSearchFlags; // 0x20
        public bool _serializeCompilerGeneratedMembers; // 0x24
        public bool _ignoreSerializableInterface; // 0x25
        public bool _ignoreSerializableAttribute; // 0x26

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE86B22590
        public void get_DynamicCodeGeneration(){} // RVA: 0x7FFE86B225F0
        public void get_DefaultMembersSearchFlags(){} // RVA: 0x7FFE8151D690
        public void set_DefaultMembersSearchFlags(){} // RVA: 0x7FFE8170B670
        public void get_SerializeCompilerGeneratedMembers(){} // RVA: 0x7FFE811167C0
        public void set_SerializeCompilerGeneratedMembers(){} // RVA: 0x7FFE812EB1B0
        public void get_IgnoreSerializableInterface(){} // RVA: 0x7FFE812EAC90
        public void set_IgnoreSerializableInterface(){} // RVA: 0x7FFE812EAC40
        public void get_IgnoreSerializableAttribute(){} // RVA: 0x7FFE812EAC50
        public void set_IgnoreSerializableAttribute(){} // RVA: 0x7FFE812EB000
        public void get_IgnoreIsSpecifiedMembers(){} // RVA: 0x7FFE826F6CC0
        public void set_IgnoreIsSpecifiedMembers(){} // RVA: 0x7FFE86B22720
        public void get_IgnoreShouldSerializeMembers(){} // RVA: 0x7FFE815F1380
        public void set_IgnoreShouldSerializeMembers(){} // RVA: 0x7FFE81C15740
        public void get_NamingStrategy(){} // RVA: 0x7FFE8144E200
        public void set_NamingStrategy(){} // RVA: 0x7FFE81129890
        public void .ctor(){} // RVA: 0x7FFE86B22730
        public void ResolveContract(){} // RVA: 0x7FFE86B228E0
        public void FilterMembers(){} // RVA: 0x7FFE86B229C0
        public void GetSerializableMembers(){} // RVA: 0x7FFE86B22B70
        public void ShouldSerializeEntityMember(){} // RVA: 0x7FFE86B238D0
        public void CreateObjectContract(){} // RVA: 0x7FFE86B23A50
        public void ThrowUnableToSerializeError(){} // RVA: 0x7FFE86B242C0
        public void GetExtensionDataMemberForType(){} // RVA: 0x7FFE86B24360
        public void SetExtensionDataDelegates(){} // RVA: 0x7FFE86B24630
        public void GetAttributeConstructor(){} // RVA: 0x7FFE86B253F0
        public void GetImmutableConstructor(){} // RVA: 0x7FFE86B258A0
        public void GetParameterizedConstructor(){} // RVA: 0x7FFE86B25AF0
        public void CreateConstructorParameters(){} // RVA: 0x7FFE86B25B40
        public void MatchProperty(){} // RVA: 0x7FFE86B25D20
        public void CreatePropertyFromConstructorParameter(){} // RVA: 0x7FFE86B25DE0
        public void ResolveContractConverter(){} // RVA: 0x7FFE86B261A0
        public void GetDefaultCreator(){} // RVA: 0x7FFE86B261F0
        public void InitializeContract(){} // RVA: 0x7FFE86B26270
        public void ResolveCallbackMethods(){} // RVA: 0x7FFE86B26610
        public void GetCallbackMethodsForType(){} // RVA: 0x7FFE86B269B0
        public void IsConcurrentOrObservableCollection(){} // RVA: 0x7FFE86B27530
        public void ShouldSkipDeserialized(){} // RVA: 0x7FFE86B27750
        public void ShouldSkipSerializing(){} // RVA: 0x7FFE86B27890
        public void GetClassHierarchyForType(){} // RVA: 0x7FFE86B279D0
        public void CreateDictionaryContract(){} // RVA: 0x7FFE86B27BB0
        public void CreateArrayContract(){} // RVA: 0x7FFE86B28310
        public void CreatePrimitiveContract(){} // RVA: 0x7FFE86B28720
        public void CreateLinqContract(){} // RVA: 0x7FFE86B287A0
        public void CreateISerializableContract(){} // RVA: 0x7FFE86B28820
        public void CreateDynamicContract(){} // RVA: 0x7FFE86B28B00
        public void CreateStringContract(){} // RVA: 0x7FFE86B28E60
        public void CreateContract(){} // RVA: 0x7FFE86B28F20
        public void IsJsonPrimitiveType(){} // RVA: 0x7FFE86B295D0
        public void IsIConvertible(){} // RVA: 0x7FFE86B29670
        public void CanConvertToString(){} // RVA: 0x7FFE86B29850
        public void IsValidCallback(){} // RVA: 0x7FFE86B29970
        public void GetClrTypeFullName(){} // RVA: 0x7FFE86B2A160
        public void CreateProperties(){} // RVA: 0x7FFE86B2A290
        public void GetNameTable(){} // RVA: 0x7FFE81116380
        public void CreateMemberValueProvider(){} // RVA: 0x7FFE86B2A820
        public void CreateProperty(){} // RVA: 0x7FFE86B2A940
        public void SetPropertySettingsFromAttributes(){} // RVA: 0x7FFE86B2ACC0
        public void CreateShouldSerializeTest(){} // RVA: 0x7FFE86B2B530
        public void SetIsSpecifiedActions(){} // RVA: 0x7FFE86B2B7E0
        public void ResolvePropertyName(){} // RVA: 0x7FFE86B2BC00
        public void ResolveExtensionDataName(){} // RVA: 0x7FFE86B2BC30
        public void ResolveDictionaryKey(){} // RVA: 0x7FFE86B2BC60
        public void GetResolvedPropertyName(){} // RVA: 0x7FFE86B2BCB0
        public void .cctor(){} // RVA: 0x7FFE86B2BCD0
    }

    public class DefaultNamingStrategy : NamingStrategy
    {
        // ── Methods ──
        public void ResolvePropertyName(){} // RVA: 0x7FFE82153650
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DefaultReferenceResolver : Object
    {
        // ── Methods ──
        public void GetMappings(){} // RVA: 0x7FFE86B2D0E0
        public void ResolveReference(){} // RVA: 0x7FFE86B2D360
        public void GetReference(){} // RVA: 0x7FFE86B2D420
        public void AddReference(){} // RVA: 0x7FFE86B2D570
        public void IsReferenced(){} // RVA: 0x7FFE86B2D600
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DefaultSerializationBinder : SerializationBinder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B2D6C0
        public void GetTypeFromTypeNameKey(){} // RVA: 0x7FFE86B2D7D0
        public void GetGenericTypeFromTypeName(){} // RVA: 0x7FFE86B2DC30
        public void GetTypeByName(){} // RVA: 0x7FFE86B2DEC0
        public void BindToType(){} // RVA: 0x7FFE86B2DF40
        public void BindToName(){} // RVA: 0x7FFE86B2E020
        public void .cctor(){} // RVA: 0x7FFE86B2E160
    }

    public class DiagnosticsTraceWriter : Object
    {
        public 0x66529964 _levelFilter; // 0x10

        // ── Methods ──
        public void get_LevelFilter(){} // RVA: 0x7FFE811485C0
        public void set_LevelFilter(){} // RVA: 0x7FFE810FE0C0
        public void GetTraceEventType(){} // RVA: 0x7FFE86B2E310
        public void Trace(){} // RVA: 0x7FFE86B2E3B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ErrorContext : Object
    {
        public bool _traced; // 0x10
        public System.Exception _error; // 0x18
        public object _originalObject; // 0x20
        public object _member; // 0x28
        public string _path; // 0x30
        public bool _handled; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B2E8D0
        public void get_Traced(){} // RVA: 0x7FFE811C55E0
        public void set_Traced(){} // RVA: 0x7FFE811C55F0
        public void get_Error(){} // RVA: 0x7FFE810FE7C0
        public void get_OriginalObject(){} // RVA: 0x7FFE811290C0
        public void get_Member(){} // RVA: 0x7FFE81129130
        public void get_Path(){} // RVA: 0x7FFE8144E200
        public void get_Handled(){} // RVA: 0x7FFE812CF770
        public void set_Handled(){} // RVA: 0x7FFE812D0010
    }

    public class ErrorEventArgs : EventArgs
    {
        public object _currentObject; // 0x10
        public Newtonsoft.Json.Serialization.ErrorContext _errorContext; // 0x18

        // ── Methods ──
        public void get_CurrentObject(){} // RVA: 0x7FFE81116380
        public void get_ErrorContext(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE86B2EA20
    }

    public class ExtensionDataGetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828B3580
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE81156C70
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class ExtensionDataSetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B318A0
        public void Invoke(){} // RVA: 0x7FFE812574E0
        public void BeginInvoke(){} // RVA: 0x7FFE81EE8B90
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class IAttributeProvider
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFE80E3EBB0 | overloaded x2
    }

    public class IContractResolver
    {
        // ── Methods ──
        public void ResolveContract(){} // RVA: 0x7FFE80E2E390
    }

    public class IReferenceResolver
    {
        // ── Methods ──
        public void ResolveReference(){} // RVA: 0x7FFE80E3FC10
        public void GetReference(){} // RVA: 0x7FFE80E3FC10
        public void IsReferenced(){} // RVA: 0x7FFE80E32650
        public void AddReference(){} // RVA: 0x7FFE80E50660
    }

    public class ISerializationBinder
    {
        // ── Methods ──
        public void BindToType(){} // RVA: 0x7FFE80E3FC10
        public void BindToName(){} // RVA: 0x7FFE80E50660
    }

    public class ITraceWriter
    {
        // ── Methods ──
        public void get_LevelFilter(){} // RVA: 0x7FFE80E2EDB0
        public void Trace(){} // RVA: 0x7FFE80E48FD0
    }

    public class IValueProvider
    {
        // ── Methods ──
        public void SetValue(){} // RVA: 0x7FFE80E4F230
        public void GetValue(){} // RVA: 0x7FFE80E2E390
    }

    public class JsonArrayContract : JsonContainerContract
    {
        public System.Type _collectionItemType; // 0xC0
        public bool _isMultidimensionalArray; // 0xC8
        public System.Type _genericCollectionDefinitionType; // 0xD0
        public System.Type _genericWrapperType; // 0xD8
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _genericWrapperCreator; // 0xE0
        public System.Func`1<object> _genericTemporaryCollectionCreator; // 0xE8
        public bool _isArray; // 0xF0
        public bool _shouldCreateWrapper; // 0xF1
        public bool _canDeserialize; // 0xF2

        // ── Methods ──
        public void get_CollectionItemType(){} // RVA: 0x7FFE81166120
        public void get_IsMultidimensionalArray(){} // RVA: 0x7FFE81FF3AD0
        public void get_IsArray(){} // RVA: 0x7FFE8117CAD0
        public void get_ShouldCreateWrapper(){} // RVA: 0x7FFE82145E40
        public void get_CanDeserialize(){} // RVA: 0x7FFE82144680
        public void set_CanDeserialize(){} // RVA: 0x7FFE82146D10
        public void get_ParameterizedCreator(){} // RVA: 0x7FFE86B2EB30
        public void get_OverrideCreator(){} // RVA: 0x7FFE8181E3D0
        public void set_OverrideCreator(){} // RVA: 0x7FFE86B2EC90
        public void get_HasParameterizedCreator(){} // RVA: 0x7FFE81472650
        public void set_HasParameterizedCreator(){} // RVA: 0x7FFE81472660
        public void get_HasParameterizedCreatorInternal(){} // RVA: 0x7FFE86B2ED00
        public void .ctor(){} // RVA: 0x7FFE86B2EDB0
        public void CreateWrapper(){} // RVA: 0x7FFE86B30670
        public void CreateTemporaryCollection(){} // RVA: 0x7FFE86B30BC0
        public void StoreFSharpListCreatorIfNecessary(){} // RVA: 0x7FFE86B30E60
    }

    public class JsonContainerContract : JsonContract
    {
        public Newtonsoft.Json.Serialization.JsonContract _itemContract; // 0x90
        public Newtonsoft.Json.Serialization.JsonContract _finalItemContract; // 0x98
        public Newtonsoft.Json.JsonConverter _itemConverter; // 0xA0
        public System.Nullable`1<bool> _itemIsReference; // 0xA8
        public System.Nullable`1<0x665BF344> _itemReferenceLoopHandling; // 0xAC
        public System.Nullable`1<0x665BF4A4> _itemTypeNameHandling; // 0xB4

        // ── Methods ──
        public void get_ItemContract(){} // RVA: 0x7FFE8154EB60
        public void set_ItemContract(){} // RVA: 0x7FFE86B310E0
        public void get_FinalItemContract(){} // RVA: 0x7FFE817AE360
        public void get_ItemConverter(){} // RVA: 0x7FFE8179C860
        public void set_ItemConverter(){} // RVA: 0x7FFE8171B4D0
        public void get_ItemIsReference(){} // RVA: 0x7FFE86B31260
        public void set_ItemIsReference(){} // RVA: 0x7FFE86B31270
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFE86B31280
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFE86B31290
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFE86B312A0
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFE86B312B0
        public void .ctor(){} // RVA: 0x7FFE86B312C0
    }

    public class JsonContract : Object
    {
        public bool IsNullable; // 0x10
        public bool IsConvertable; // 0x11
        public bool IsEnum; // 0x12
        public System.Type NonNullableUnderlyingType; // 0x18
        public 0x665BE3CC InternalReadType; // 0x20
        public 0x665C230C ContractType; // 0x24
        public bool IsReadOnlyOrFixedSize; // 0x28
        public bool IsSealed; // 0x29
        public bool IsInstantiable; // 0x2A
        public System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializedCallbacks; // 0x30
        public System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializingCallbacks; // 0x38
        public System.Collections.Generic.List`1<Newtonsoft.Json.Serialization.SerializationCallback> _onSerializedCallbacks; // 0x40

        // ── Methods ──
        public void get_UnderlyingType(){} // RVA: 0x7FFE81199370
        public void get_CreatedType(){} // RVA: 0x7FFE811C3500
        public void set_CreatedType(){} // RVA: 0x7FFE86B31A20
        public void get_IsReference(){} // RVA: 0x7FFE843309A0
        public void set_IsReference(){} // RVA: 0x7FFE843309B0
        public void get_Converter(){} // RVA: 0x7FFE811C3590
        public void set_Converter(){} // RVA: 0x7FFE811C35A0
        public void get_InternalConverter(){} // RVA: 0x7FFE81463AE0
        public void set_InternalConverter(){} // RVA: 0x7FFE81464570
        public void get_OnDeserializedCallbacks(){} // RVA: 0x7FFE86B31B90
        public void get_OnDeserializingCallbacks(){} // RVA: 0x7FFE86B31C50
        public void get_OnSerializedCallbacks(){} // RVA: 0x7FFE86B31D10
        public void get_OnSerializingCallbacks(){} // RVA: 0x7FFE86B31DD0
        public void get_OnErrorCallbacks(){} // RVA: 0x7FFE86B31E90
        public void get_DefaultCreator(){} // RVA: 0x7FFE81280C30
        public void set_DefaultCreator(){} // RVA: 0x7FFE81282380
        public void get_DefaultCreatorNonPublic(){} // RVA: 0x7FFE820C4230
        public void set_DefaultCreatorNonPublic(){} // RVA: 0x7FFE820C0790
        public void .ctor(){} // RVA: 0x7FFE86B31F50
        public void InvokeOnSerializing(){} // RVA: 0x7FFE86B322E0
        public void InvokeOnSerialized(){} // RVA: 0x7FFE86B32460
        public void InvokeOnDeserializing(){} // RVA: 0x7FFE86B325E0
        public void InvokeOnDeserialized(){} // RVA: 0x7FFE86B32760
        public void InvokeOnError(){} // RVA: 0x7FFE86B328E0
        public void CreateSerializationCallback(){} // RVA: 0x7FFE86B32A80
        public void CreateSerializationErrorCallback(){} // RVA: 0x7FFE86B32B70
    }

    public class JsonDictionaryContract : JsonContainerContract
    {
        public System.Func`2<string,string> _dictionaryKeyResolver; // 0xC0
        public System.Type _dictionaryKeyType; // 0xC8
        public System.Type _dictionaryValueType; // 0xD0
        public Newtonsoft.Json.Serialization.JsonContract _keyContract; // 0xD8
        public System.Type _genericCollectionDefinitionType; // 0xE0
        public System.Type _genericWrapperType; // 0xE8
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _genericWrapperCreator; // 0xF0
        public System.Func`1<object> _genericTemporaryDictionaryCreator; // 0xF8
        public bool _shouldCreateWrapper; // 0x100

        // ── Methods ──
        public void get_DictionaryKeyResolver(){} // RVA: 0x7FFE81166120
        public void set_DictionaryKeyResolver(){} // RVA: 0x7FFE81166130
        public void get_DictionaryKeyType(){} // RVA: 0x7FFE81253460
        public void get_DictionaryValueType(){} // RVA: 0x7FFE81218100
        public void get_KeyContract(){} // RVA: 0x7FFE8181EA80
        public void set_KeyContract(){} // RVA: 0x7FFE8117C8A0
        public void get_ShouldCreateWrapper(){} // RVA: 0x7FFE81F84400
        public void get_ParameterizedCreator(){} // RVA: 0x7FFE86B32EF0
        public void get_OverrideCreator(){} // RVA: 0x7FFE81317980
        public void set_OverrideCreator(){} // RVA: 0x7FFE813159A0
        public void get_HasParameterizedCreator(){} // RVA: 0x7FFE86B33050
        public void set_HasParameterizedCreator(){} // RVA: 0x7FFE86B33060
        public void get_HasParameterizedCreatorInternal(){} // RVA: 0x7FFE86B33070
        public void .ctor(){} // RVA: 0x7FFE86B33120
        public void CreateWrapper(){} // RVA: 0x7FFE86B34000
        public void CreateTemporaryDictionary(){} // RVA: 0x7FFE86B34400
    }

    public class JsonDynamicContract : JsonContainerContract
    {
        public Newtonsoft.Json.Serialization.JsonPropertyCollection _properties; // 0xC0
        public System.Func`2<string,string> _propertyNameResolver; // 0xC8

        // ── Methods ──
        public void get_Properties(){} // RVA: 0x7FFE81166120
        public void get_PropertyNameResolver(){} // RVA: 0x7FFE81253460
        public void set_PropertyNameResolver(){} // RVA: 0x7FFE81253470
        public void CreateCallSiteGetter(){} // RVA: 0x7FFE86B346F0
        public void CreateCallSiteSetter(){} // RVA: 0x7FFE86B348C0
        public void .ctor(){} // RVA: 0x7FFE86B34B90
        public void TryGetMember(){} // RVA: 0x7FFE86B34E40
        public void TrySetMember(){} // RVA: 0x7FFE86B35040
    }

    public class JsonFormatterConverter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B351C0
        public void GetTokenValue(){} // RVA: 0x7FFE810A1420
        public void Convert(){} // RVA: 0x7FFE86B35530 | overloaded x2
        public void ToBoolean(){} // RVA: 0x7FFE86B356B0
        public void ToByte(){} // RVA: 0x7FFE86B35700
        public void ToChar(){} // RVA: 0x7FFE86B35750
        public void ToDateTime(){} // RVA: 0x7FFE86B357A0
        public void ToDecimal(){} // RVA: 0x7FFE86B357F0
        public void ToDouble(){} // RVA: 0x7FFE86B35860
        public void ToInt16(){} // RVA: 0x7FFE86B358B0
        public void ToInt32(){} // RVA: 0x7FFE86B35900
        public void ToInt64(){} // RVA: 0x7FFE86B35950
        public void ToSByte(){} // RVA: 0x7FFE86B359A0
        public void ToSingle(){} // RVA: 0x7FFE86B359F0
        public void ToString(){} // RVA: 0x7FFE86B35A40
        public void ToUInt16(){} // RVA: 0x7FFE86B35A90
        public void ToUInt32(){} // RVA: 0x7FFE86B35AE0
        public void ToUInt64(){} // RVA: 0x7FFE86B35B30
    }

    public class JsonISerializableContract : JsonContainerContract
    {
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _iSerializableCreator; // 0xC0

        // ── Methods ──
        public void get_ISerializableCreator(){} // RVA: 0x7FFE81166120
        public void set_ISerializableCreator(){} // RVA: 0x7FFE81166130
        public void .ctor(){} // RVA: 0x7FFE86B35B80
    }

    public class JsonLinqContract : JsonContract
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B35BA0
    }

    public class JsonObjectContract : JsonContainerContract
    {
        public \ _memberSerialization; // 0xC0
        public System.Nullable`1<0x665BF1E4> _missingMemberHandling; // 0xC4
        public System.Nullable`1<0x665BF39C> _itemRequired; // 0xCC
        public System.Nullable`1<0x665BF23C> _itemNullValueHandling; // 0xD4
        public Newtonsoft.Json.Serialization.JsonPropertyCollection _properties; // 0xE0
        public Newtonsoft.Json.Serialization.ExtensionDataSetter _extensionDataSetter; // 0xE8
        public Newtonsoft.Json.Serialization.ExtensionDataGetter _extensionDataGetter; // 0xF0
        public System.Func`2<string,string> _extensionDataNameResolver; // 0xF8
        public bool ExtensionDataIsJToken; // 0x100
        public System.Nullable`1<bool> _hasRequiredOrDefaultValueProperties; // 0x101
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _overrideCreator; // 0x108
        public Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _parameterizedCreator; // 0x110
        public Newtonsoft.Json.Serialization.JsonPropertyCollection _creatorParameters; // 0x118

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7FFE813AB640
        public void set_MemberSerialization(){} // RVA: 0x7FFE813A4A00
        public void get_MissingMemberHandling(){} // RVA: 0x7FFE86B35BC0
        public void set_MissingMemberHandling(){} // RVA: 0x7FFE86B35BD0
        public void get_ItemRequired(){} // RVA: 0x7FFE86B35BE0
        public void set_ItemRequired(){} // RVA: 0x7FFE86B35BF0
        public void get_ItemNullValueHandling(){} // RVA: 0x7FFE86B35C00
        public void set_ItemNullValueHandling(){} // RVA: 0x7FFE86B35C10
        public void get_Properties(){} // RVA: 0x7FFE8117C900
        public void get_CreatorParameters(){} // RVA: 0x7FFE86B35C20
        public void get_OverrideCreator(){} // RVA: 0x7FFE8181E3D0
        public void set_OverrideCreator(){} // RVA: 0x7FFE81A60200
        public void get_ParameterizedCreator(){} // RVA: 0x7FFE81317980
        public void set_ParameterizedCreator(){} // RVA: 0x7FFE813159A0
        public void get_ExtensionDataSetter(){} // RVA: 0x7FFE8117C970
        public void set_ExtensionDataSetter(){} // RVA: 0x7FFE8117C980
        public void get_ExtensionDataGetter(){} // RVA: 0x7FFE811662A0
        public void set_ExtensionDataGetter(){} // RVA: 0x7FFE811662B0
        public void get_ExtensionDataValueType(){} // RVA: 0x7FFE813A1DA0
        public void set_ExtensionDataValueType(){} // RVA: 0x7FFE86B35CF0
        public void get_ExtensionDataNameResolver(){} // RVA: 0x7FFE8158D5D0
        public void set_ExtensionDataNameResolver(){} // RVA: 0x7FFE81B0E4B0
        public void get_HasRequiredOrDefaultValueProperties(){} // RVA: 0x7FFE86B35E10
        public void .ctor(){} // RVA: 0x7FFE86B360C0
        public void GetUninitializedObject(){} // RVA: 0x7FFE86B361A0
    }

    public class JsonPrimitiveContract : JsonContract
    {
        public 0x665BFA7C _typeCode; // 0x90

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE814AA220
        public void set_TypeCode(){} // RVA: 0x7FFE81C8DB30
        public void .ctor(){} // RVA: 0x7FFE86B362B0
        public void .cctor(){} // RVA: 0x7FFE86B36410
    }

    public class JsonProperty : Object
    {
        public System.Nullable`1<0x665BF39C> _required; // 0x10
        public bool _hasExplicitDefaultValue; // 0x18
        public object _defaultValue; // 0x20
        public bool _hasGeneratedDefaultValue; // 0x28
        public string _propertyName; // 0x30
        public bool _skipPropertyNameEscape; // 0x38
        public System.Type _propertyType; // 0x40
        public Newtonsoft.Json.Serialization.JsonContract _propertyContract; // 0x48
        public System.Type _declaringType; // 0x50
        public System.Nullable`1<int> _order; // 0x58
        public string _underlyingName; // 0x60
        public Newtonsoft.Json.Serialization.IValueProvider _valueProvider; // 0x68
        public Newtonsoft.Json.Serialization.IAttributeProvider _attributeProvider; // 0x70
        public Newtonsoft.Json.JsonConverter _converter; // 0x78
        public bool _ignored; // 0x80
        public bool _readable; // 0x81
        public bool _writable; // 0x82
        public bool _hasMemberAttribute; // 0x83
        public System.Nullable`1<bool> _isReference; // 0x84
        public System.Nullable`1<0x665BF23C> _nullValueHandling; // 0x88
        public System.Nullable`1<[> _defaultValueHandling; // 0x90
        public System.Nullable`1<0x665BF344> _referenceLoopHandling; // 0x98
        public System.Nullable`1<0x665BF294> _objectCreationHandling; // 0xA0
        public System.Nullable`1<0x665BF4A4> _typeNameHandling; // 0xA8
        public System.Predicate`1<object> _shouldSerialize; // 0xB0
        public System.Predicate`1<object> _shouldDeserialize; // 0xB8
        public System.Predicate`1<object> _getIsSpecified; // 0xC0
        public System.Action`2<object,object> _setIsSpecified; // 0xC8
        public Newtonsoft.Json.JsonConverter _itemConverter; // 0xD0
        public System.Nullable`1<bool> _itemIsReference; // 0xD8
        public System.Nullable`1<0x665BF4A4> _itemTypeNameHandling; // 0xDC

        // ── Methods ──
        public void get_PropertyContract(){} // RVA: 0x7FFE81176730
        public void set_PropertyContract(){} // RVA: 0x7FFE81176740
        public void get_PropertyName(){} // RVA: 0x7FFE8144E200
        public void set_PropertyName(){} // RVA: 0x7FFE86B36C90
        public void get_DeclaringType(){} // RVA: 0x7FFE8119C0E0
        public void set_DeclaringType(){} // RVA: 0x7FFE812534D0
        public void get_Order(){} // RVA: 0x7FFE811C3500
        public void set_Order(){} // RVA: 0x7FFE825093B0
        public void get_UnderlyingName(){} // RVA: 0x7FFE81199370
        public void set_UnderlyingName(){} // RVA: 0x7FFE81199380
        public void get_ValueProvider(){} // RVA: 0x7FFE81176D50
        public void set_ValueProvider(){} // RVA: 0x7FFE81176D60
        public void get_AttributeProvider(){} // RVA: 0x7FFE811C3590
        public void set_AttributeProvider(){} // RVA: 0x7FFE811C35A0
        public void get_PropertyType(){} // RVA: 0x7FFE81178740
        public void set_PropertyType(){} // RVA: 0x7FFE86B36DC0
        public void get_Converter(){} // RVA: 0x7FFE81463AE0
        public void set_Converter(){} // RVA: 0x7FFE81464570
        public void get_MemberConverter(){} // RVA: 0x7FFE81463AE0
        public void set_MemberConverter(){} // RVA: 0x7FFE81464570
        public void get_Ignored(){} // RVA: 0x7FFE813A1130
        public void set_Ignored(){} // RVA: 0x7FFE813A2040
        public void get_Readable(){} // RVA: 0x7FFE813A1BA0
        public void set_Readable(){} // RVA: 0x7FFE8139FDD0
        public void get_Writable(){} // RVA: 0x7FFE81EB0A60
        public void set_Writable(){} // RVA: 0x7FFE86AD9DF0
        public void get_HasMemberAttribute(){} // RVA: 0x7FFE822C14E0
        public void set_HasMemberAttribute(){} // RVA: 0x7FFE86B36E80
        public void get_DefaultValue(){} // RVA: 0x7FFE86B36E90
        public void set_DefaultValue(){} // RVA: 0x7FFE86B36EA0
        public void GetResolvedDefaultValue(){} // RVA: 0x7FFE86B36F00
        public void get_Required(){} // RVA: 0x7FFE86B36FC0
        public void set_Required(){} // RVA: 0x7FFE86B37000
        public void get_IsRequiredSpecified(){} // RVA: 0x7FFE86B37060
        public void get_IsReference(){} // RVA: 0x7FFE86B370A0
        public void set_IsReference(){} // RVA: 0x7FFE86B370B0
        public void get_NullValueHandling(){} // RVA: 0x7FFE8113A010
        public void set_NullValueHandling(){} // RVA: 0x7FFE82C95CA0
        public void get_DefaultValueHandling(){} // RVA: 0x7FFE8154EB60
        public void set_DefaultValueHandling(){} // RVA: 0x7FFE81854020
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFE817AE360
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFE86225270
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFE8179C860
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFE86B370C0
        public void get_TypeNameHandling(){} // RVA: 0x7FFE817AB5E0
        public void set_TypeNameHandling(){} // RVA: 0x7FFE82904630
        public void get_ShouldSerialize(){} // RVA: 0x7FFE81166040
        public void set_ShouldSerialize(){} // RVA: 0x7FFE81166050
        public void get_ShouldDeserialize(){} // RVA: 0x7FFE811660B0
        public void set_ShouldDeserialize(){} // RVA: 0x7FFE811660C0
        public void get_GetIsSpecified(){} // RVA: 0x7FFE81166120
        public void set_GetIsSpecified(){} // RVA: 0x7FFE81166130
        public void get_SetIsSpecified(){} // RVA: 0x7FFE81253460
        public void set_SetIsSpecified(){} // RVA: 0x7FFE81253470
        public void ToString(){} // RVA: 0x7FFE86B370D0
        public void get_ItemConverter(){} // RVA: 0x7FFE81218100
        public void set_ItemConverter(){} // RVA: 0x7FFE81218110
        public void get_ItemIsReference(){} // RVA: 0x7FFE86B37120
        public void set_ItemIsReference(){} // RVA: 0x7FFE86B37130
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFE86B37140
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFE86B37150
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFE86B37160
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFE86B37170
        public void WritePropertyName(){} // RVA: 0x7FFE86B37180
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonPropertyCollection : KeyedCollection`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B371E0
        public void GetKeyForItem(){} // RVA: 0x7FFE866D9B40
        public void AddProperty(){} // RVA: 0x7FFE86B37480
        public void GetClosestMatchProperty(){} // RVA: 0x7FFE86B37780
        public void TryGetProperty(){} // RVA: 0x7FFE86B377D0
        public void GetProperty(){} // RVA: 0x7FFE86B37920
    }

    public class JsonSerializerInternalBase : Object
    {
        public Newtonsoft.Json.Serialization.ErrorContext _currentErrorContext; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B37B60
        public void get_DefaultReferenceMappings(){} // RVA: 0x7FFE86B37CB0
        public void ResolvedNullValueHandling(){} // RVA: 0x7FFE86B37E10
        public void GetErrorContext(){} // RVA: 0x7FFE86B37EC0
        public void ClearErrorContext(){} // RVA: 0x7FFE86B38130
        public void IsErrorHandled(){} // RVA: 0x7FFE86B381E0
    }

    public class JsonSerializerInternalReader : JsonSerializerInternalBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B38640
        public void Populate(){} // RVA: 0x7FFE86B38650
        public void GetContractSafe(){} // RVA: 0x7FFE86B38D10
        public void GetContract(){} // RVA: 0x7FFE86B38DC0
        public void Deserialize(){} // RVA: 0x7FFE86B38E20
        public void GetInternalSerializer(){} // RVA: 0x7FFE86B39170
        public void CreateJToken(){} // RVA: 0x7FFE86B39310
        public void CreateJObject(){} // RVA: 0x7FFE86B39740
        public void CreateValueInternal(){} // RVA: 0x7FFE86B39B20
        public void CoerceEmptyStringToNull(){} // RVA: 0x7FFE86B3A100
        public void GetExpectedDescription(){} // RVA: 0x7FFE86B3A210
        public void GetConverter(){} // RVA: 0x7FFE86B3A320
        public void CreateObject(){} // RVA: 0x7FFE86B3A400
        public void ReadMetadataPropertiesToken(){} // RVA: 0x7FFE86B3B1F0
        public void ReadMetadataProperties(){} // RVA: 0x7FFE86B3BC50
        public void ResolveTypeName(){} // RVA: 0x7FFE86B3C710
        public void EnsureArrayContract(){} // RVA: 0x7FFE86B3CD60
        public void CreateList(){} // RVA: 0x7FFE86B3CF20
        public void HasNoDefinedType(){} // RVA: 0x7FFE86B3D800
        public void EnsureType(){} // RVA: 0x7FFE86B3D8E0
        public void SetPropertyValue(){} // RVA: 0x7FFE86B3DE40
        public void CalculatePropertyDetails(){} // RVA: 0x7FFE86B3E250
        public void AddReference(){} // RVA: 0x7FFE86B3E950
        public void HasFlag(){} // RVA: 0x7FFE86874540
        public void ShouldSetPropertyValue(){} // RVA: 0x7FFE86B3EBE0
        public void CreateNewList(){} // RVA: 0x7FFE86B3ED40
        public void CreateNewDictionary(){} // RVA: 0x7FFE86B3F0C0
        public void OnDeserializing(){} // RVA: 0x7FFE86B3F370
        public void OnDeserialized(){} // RVA: 0x7FFE86B3F540
        public void PopulateDictionary(){} // RVA: 0x7FFE86B3F710
        public void PopulateMultidimensionalArray(){} // RVA: 0x7FFE86B40370
        public void ThrowUnexpectedEndException(){} // RVA: 0x7FFE86B40C80
        public void PopulateList(){} // RVA: 0x7FFE86B40D90
        public void CreateISerializable(){} // RVA: 0x7FFE86B413A0
        public void CreateISerializableItem(){} // RVA: 0x7FFE86B41D10
        public void CreateDynamic(){} // RVA: 0x7FFE86B41F20
        public void CreateObjectUsingCreatorWithParameters(){} // RVA: 0x7FFE86B428E0
        public void DeserializeConvertable(){} // RVA: 0x7FFE86B44200
        public void ResolvePropertyAndCreatorValues(){} // RVA: 0x7FFE86B44660
        public void CreateNewObject(){} // RVA: 0x7FFE86B451E0
        public void PopulateObject(){} // RVA: 0x7FFE86B454B0
        public void ShouldDeserialize(){} // RVA: 0x7FFE86B46280
        public void CheckPropertyName(){} // RVA: 0x7FFE86B46460
        public void SetExtensionData(){} // RVA: 0x7FFE86B46620
        public void ReadExtensionDataValue(){} // RVA: 0x7FFE86B46750
        public void EndProcessProperty(){} // RVA: 0x7FFE86B46850
        public void SetPropertyPresence(){} // RVA: 0x7FFE86B46CF0
        public void HandleError(){} // RVA: 0x7FFE86B46E30
    }

    public class JsonSerializerInternalWriter : JsonSerializerInternalBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B46FD0
        public void Serialize(){} // RVA: 0x7FFE86B470A0
        public void GetInternalSerializer(){} // RVA: 0x7FFE86B474F0
        public void GetContractSafe(){} // RVA: 0x7FFE86B47690
        public void GetContract(){} // RVA: 0x7FFE86B47710
        public void SerializePrimitive(){} // RVA: 0x7FFE86B47780
        public void SerializeValue(){} // RVA: 0x7FFE86B47AA0
        public void ResolveIsReference(){} // RVA: 0x7FFE86B482B0
        public void ShouldWriteReference(){} // RVA: 0x7FFE86B48340
        public void ShouldWriteProperty(){} // RVA: 0x7FFE86B484C0
        public void CheckForCircularReference(){} // RVA: 0x7FFE86B485E0
        public void WriteReference(){} // RVA: 0x7FFE86B48AE0
        public void GetReference(){} // RVA: 0x7FFE86B48CF0
        public void TryConvertToString(){} // RVA: 0x7FFE86B48E40
        public void SerializeString(){} // RVA: 0x7FFE86B49060
        public void OnSerializing(){} // RVA: 0x7FFE86B49110
        public void OnSerialized(){} // RVA: 0x7FFE86B492A0
        public void SerializeObject(){} // RVA: 0x7FFE86B49430
        public void CalculatePropertyValues(){} // RVA: 0x7FFE86B4A030
        public void WriteObjectStart(){} // RVA: 0x7FFE86B4A970
        public void HasCreatorParameter(){} // RVA: 0x7FFE86B4ACF0
        public void WriteReferenceIdProperty(){} // RVA: 0x7FFE86B4ADC0
        public void WriteTypeProperty(){} // RVA: 0x7FFE86B4AF90
        public void HasFlag(){} // RVA: 0x7FFE86874540 | overloaded x3
        public void SerializeConvertable(){} // RVA: 0x7FFE86B4B230
        public void SerializeList(){} // RVA: 0x7FFE86B4B870
        public void SerializeMultidimensionalArray(){} // RVA: 0x7FFE86B4C000 | overloaded x2
        public void WriteStartArray(){} // RVA: 0x7FFE86B4C450
        public void SerializeISerializable(){} // RVA: 0x7FFE86B4C8E0
        public void SerializeDynamic(){} // RVA: 0x7FFE86B4D270
        public void ShouldWriteDynamicProperty(){} // RVA: 0x7FFE86B4DEE0
        public void ShouldWriteType(){} // RVA: 0x7FFE86B4DF90
        public void SerializeDictionary(){} // RVA: 0x7FFE86B4E1B0
        public void GetPropertyName(){} // RVA: 0x7FFE86B4EC10
        public void HandleError(){} // RVA: 0x7FFE86B4F190
        public void ShouldSerialize(){} // RVA: 0x7FFE86B4F2E0
        public void IsSpecified(){} // RVA: 0x7FFE86B4F4B0
    }

    public class JsonSerializerProxy : JsonSerializer
    {
        public Newtonsoft.Json.Serialization.JsonSerializerInternalReader _serializerReader; // 0xE0
        public Newtonsoft.Json.Serialization.JsonSerializerInternalWriter _serializerWriter; // 0xE8
        public Newtonsoft.Json.JsonSerializer _serializer; // 0xF0
        public object Error; // 0x3
        public object ReferenceResolver; // 0xC0C8
        public object TraceWriter; // 0xC178
        public object EqualityComparer; // 0xC228
        public object Converters;
        public object DefaultValueHandling; // 0xC330
        public object ContractResolver; // 0xC3E0
        public object MissingMemberHandling; // 0xC490
        public object NullValueHandling; // 0xC540
        public object ObjectCreationHandling; // 0xC5F0
        public object ReferenceLoopHandling; // 0xC6A0
        public object PreserveReferencesHandling; // 0xC750
        public object TypeNameHandling; // 0xC800
        public object MetadataPropertyHandling; // 0xC8B0
        public object TypeNameAssemblyFormat; // 0xC960
        public object TypeNameAssemblyFormatHandling; // 0xCA10
        public object ConstructorHandling; // 0xCAC0
        public object Binder; // 0xCB70
        public object SerializationBinder; // 0xCC20
        public object Context; // 0xCCD0
        public object Formatting; // 0xCD80
        public object DateFormatHandling; // 0xCE30
        public object DateTimeZoneHandling; // 0xCEE0
        public object DateParseHandling; // 0xCF90
        public object FloatFormatHandling; // 0xD040
        public object FloatParseHandling; // 0xD0F0
        public object FloatParseHandling; // 0xD1A0

        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFE86B4F680
        public void remove_Error(){} // RVA: 0x7FFE86B4F6B0
        public void get_ReferenceResolver(){} // RVA: 0x7FFE86B4F6E0
        public void set_ReferenceResolver(){} // RVA: 0x7FFE86B4F710
        public void get_TraceWriter(){} // RVA: 0x7FFE86B4F740
        public void set_TraceWriter(){} // RVA: 0x7FFE86B4F770
        public void get_EqualityComparer(){} // RVA: 0x7FFE86B4F7A0
        public void set_EqualityComparer(){} // RVA: 0x7FFE86B4F7D0
        public void get_Converters(){} // RVA: 0x7FFE86B4F800
        public void get_DefaultValueHandling(){} // RVA: 0x7FFE86B4F830
        public void set_DefaultValueHandling(){} // RVA: 0x7FFE86B4F860
        public void get_ContractResolver(){} // RVA: 0x7FFE86B4F890
        public void set_ContractResolver(){} // RVA: 0x7FFE86B4F8C0
        public void get_MissingMemberHandling(){} // RVA: 0x7FFE86B4F8F0
        public void set_MissingMemberHandling(){} // RVA: 0x7FFE86B4F920
        public void get_NullValueHandling(){} // RVA: 0x7FFE86B4F950
        public void set_NullValueHandling(){} // RVA: 0x7FFE86B4F980
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFE86B4F9B0
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFE86B4F9E0
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFE86B4FA10
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFE86B4FA40
        public void get_PreserveReferencesHandling(){} // RVA: 0x7FFE86B4FA70
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFE86B4FAA0
        public void get_TypeNameHandling(){} // RVA: 0x7FFE86B4FAD0
        public void set_TypeNameHandling(){} // RVA: 0x7FFE86B4FB00
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFE86B4FB30
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFE86B4FB60
        public void get_TypeNameAssemblyFormat(){} // RVA: 0x7FFE86B4FB90
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFE86B4FBC0
        public void get_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFE86B4FBF0
        public void set_TypeNameAssemblyFormatHandling(){} // RVA: 0x7FFE86B4FC20
        public void get_ConstructorHandling(){} // RVA: 0x7FFE86B4FC50
        public void set_ConstructorHandling(){} // RVA: 0x7FFE86B4FC80
        public void get_Binder(){} // RVA: 0x7FFE86B4FCB0
        public void set_Binder(){} // RVA: 0x7FFE86B4FCE0
        public void get_SerializationBinder(){} // RVA: 0x7FFE86B4FD10
        public void set_SerializationBinder(){} // RVA: 0x7FFE86B4FD40
        public void get_Context(){} // RVA: 0x7FFE86B4FD70
        public void set_Context(){} // RVA: 0x7FFE86B4FDC0
        public void get_Formatting(){} // RVA: 0x7FFE86B4FE00
        public void set_Formatting(){} // RVA: 0x7FFE86B4FE30
        public void get_DateFormatHandling(){} // RVA: 0x7FFE86B4FE60
        public void set_DateFormatHandling(){} // RVA: 0x7FFE86B4FE90
        public void get_DateTimeZoneHandling(){} // RVA: 0x7FFE86B4FEC0
        public void set_DateTimeZoneHandling(){} // RVA: 0x7FFE86B4FEF0
        public void get_DateParseHandling(){} // RVA: 0x7FFE86B4FF20
        public void set_DateParseHandling(){} // RVA: 0x7FFE86B4FF50
        public void get_FloatFormatHandling(){} // RVA: 0x7FFE86B4FF80
        public void set_FloatFormatHandling(){} // RVA: 0x7FFE86B4FFB0
        public void get_FloatParseHandling(){} // RVA: 0x7FFE86B4FFE0
        public void set_FloatParseHandling(){} // RVA: 0x7FFE86B50010
        public void get_StringEscapeHandling(){} // RVA: 0x7FFE86B50040
        public void set_StringEscapeHandling(){} // RVA: 0x7FFE86B50070
        public void get_DateFormatString(){} // RVA: 0x7FFE86B500A0
        public void set_DateFormatString(){} // RVA: 0x7FFE86B500D0
        public void get_Culture(){} // RVA: 0x7FFE86B50100
        public void set_Culture(){} // RVA: 0x7FFE86B50130
        public void get_MaxDepth(){} // RVA: 0x7FFE86B50160
        public void set_MaxDepth(){} // RVA: 0x7FFE86B50190
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFE86B501C0
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFE86B501F0
        public void GetInternalSerializer(){} // RVA: 0x7FFE86B50220
        public void .ctor(){} // RVA: 0x7FFE86B503A0 | overloaded x2
        public void DeserializeInternal(){} // RVA: 0x7FFE86B50500
        public void PopulateInternal(){} // RVA: 0x7FFE86B50560
        public void SerializeInternal(){} // RVA: 0x7FFE86B505B0
    }

    public class JsonStringContract : JsonPrimitiveContract
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B50610
    }

    public class JsonTypeReflector : Object
    {
        public System.Nullable`1<bool> _dynamicCodeGeneration;
        public System.Nullable`1<bool> _fullyTrusted; // 0x2
        public string IdPropertyName;

        // ── Methods ──
        public void GetCachedAttribute(){} // RVA: 0x7FFE810A1420
        public void CanTypeDescriptorConvertString(){} // RVA: 0x7FFE86B50680
        public void GetDataContractAttribute(){} // RVA: 0x7FFE86B509F0
        public void GetDataMemberAttribute(){} // RVA: 0x7FFE86B50AB0
        public void GetObjectMemberSerialization(){} // RVA: 0x7FFE86B50D50
        public void GetJsonConverter(){} // RVA: 0x7FFE86B50E40
        public void CreateJsonConverterInstance(){} // RVA: 0x7FFE86B50FA0
        public void CreateNamingStrategyInstance(){} // RVA: 0x7FFE86B510C0
        public void GetContainerNamingStrategy(){} // RVA: 0x7FFE86B511E0
        public void GetCreator(){} // RVA: 0x7FFE86B512B0
        public void GetAssociatedMetadataType(){} // RVA: 0x7FFE86B514A0
        public void GetAssociateMetadataTypeFromAttribute(){} // RVA: 0x7FFE86B51540
        public void GetAttribute(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void IsNonSerializable(){} // RVA: 0x7FFE86B51840
        public void IsSerializable(){} // RVA: 0x7FFE86B518B0
        public void get_DynamicCodeGeneration(){} // RVA: 0x7FFE86B51920
        public void get_FullyTrusted(){} // RVA: 0x7FFE86B51A10
        public void get_ReflectionDelegateFactory(){} // RVA: 0x7FFE86B51B30
        public void .cctor(){} // RVA: 0x7FFE86B51BD0
    }

    public class KebabCaseNamingStrategy : NamingStrategy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x3
        public void ResolvePropertyName(){} // RVA: 0x7FFE86B52410
    }

    public class MemoryTraceWriter : Object
    {
        public System.Collections.Generic.Queue`1<string> _traceMessages; // 0x10

        // ── Methods ──
        public void get_LevelFilter(){} // RVA: 0x7FFE8151D690
        public void set_LevelFilter(){} // RVA: 0x7FFE8170B670
        public void .ctor(){} // RVA: 0x7FFE86B52420
        public void Trace(){} // RVA: 0x7FFE86B52560
        public void GetTraceMessages(){} // RVA: 0x7FFE81116380
        public void ToString(){} // RVA: 0x7FFE86B52960
    }

    public class NamingStrategy : Object
    {
        public bool _processDictionaryKeys; // 0x10
        public bool _processExtensionDataNames; // 0x11
        public bool _overrideSpecifiedNames; // 0x12

        // ── Methods ──
        public void get_ProcessDictionaryKeys(){} // RVA: 0x7FFE811C55E0
        public void set_ProcessDictionaryKeys(){} // RVA: 0x7FFE811C55F0
        public void get_ProcessExtensionDataNames(){} // RVA: 0x7FFE81346E30
        public void set_ProcessExtensionDataNames(){} // RVA: 0x7FFE813471A0
        public void get_OverrideSpecifiedNames(){} // RVA: 0x7FFE826E3520
        public void set_OverrideSpecifiedNames(){} // RVA: 0x7FFE826E34A0
        public void GetPropertyName(){} // RVA: 0x7FFE86B52D00
        public void GetExtensionDataName(){} // RVA: 0x7FFE86B52D30
        public void GetDictionaryKey(){} // RVA: 0x7FFE86B52D50
        public void ResolvePropertyName(){} // RVA: 0x7FFE80E2E390
        public void GetHashCode(){} // RVA: 0x7FFE86B52D70
        public void Equals(){} // RVA: 0x7FFE86B52F50 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ObjectConstructor`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE80E2E390
        public void BeginInvoke(){} // RVA: 0x7FFE80E403A0
        public void EndInvoke(){} // RVA: 0x7FFE80E2E390
    }

    public class OnErrorAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ReflectionAttributeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B53010
        public void GetAttributes(){} // RVA: 0x7FFE86B53160 | overloaded x2
    }

    public class ReflectionValueProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B531E0
        public void SetValue(){} // RVA: 0x7FFE86B532C0
        public void GetValue(){} // RVA: 0x7FFE86B53420
    }

    public class SerializationBinderAdapter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void BindToType(){} // RVA: 0x7FFE86B53690
        public void BindToName(){} // RVA: 0x7FFE86B536C0
    }

    public class SerializationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B31440
        public void Invoke(){} // RVA: 0x7FFE83F852E0
        public void BeginInvoke(){} // RVA: 0x7FFE86B315C0
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class SerializationErrorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B31650
        public void Invoke(){} // RVA: 0x7FFE86B317D0
        public void BeginInvoke(){} // RVA: 0x7FFE86B31800
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class SnakeCaseNamingStrategy : NamingStrategy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x3
        public void ResolvePropertyName(){} // RVA: 0x7FFE86B536F0
    }

    public class TraceJsonReader : JsonReader
    {
        public Newtonsoft.Json.JsonReader _innerReader; // 0x78
        public Newtonsoft.Json.JsonTextWriter _textWriter; // 0x80
        public System.IO.StringWriter _sw; // 0x88
        public object field_3; // 0x173
        public object field_4; // 0x174
        public object field_5; // 0x175
        public object field_6; // 0x176
        public object field_7; // 0x177

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B53700
        public void GetDeserializedJsonMessage(){} // RVA: 0x7FFE86B539F0
        public void Read(){} // RVA: 0x7FFE86B53A20
        public void ReadAsInt32(){} // RVA: 0x7FFE86B53AA0
        public void ReadAsString(){} // RVA: 0x7FFE86B53B20
        public void ReadAsBytes(){} // RVA: 0x7FFE86B53BA0
        public void ReadAsDecimal(){} // RVA: 0x7FFE86B53C20
        public void ReadAsDouble(){} // RVA: 0x7FFE86B53CB0
        public void ReadAsBoolean(){} // RVA: 0x7FFE86B53D30
        public void ReadAsDateTime(){} // RVA: 0x7FFE86B53DB0
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFE86B53E30
        public void WriteCurrentToken(){} // RVA: 0x7FFE86B53EC0
        public void get_Depth(){} // RVA: 0x7FFE86AE5490
        public void get_Path(){} // RVA: 0x7FFE86AE54C0
        public void get_QuoteChar(){} // RVA: 0x7FFE86AE54F0
        public void set_QuoteChar(){} // RVA: 0x7FFE86B53F10
        public void get_TokenType(){} // RVA: 0x7FFE86AE5520
        public void get_Value(){} // RVA: 0x7FFE86AE5460
        public void get_ValueType(){} // RVA: 0x7FFE86AE5550
        public void Close(){} // RVA: 0x7FFE86B53F40
        public void Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFE86B53F70
        public void Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFE86B53FD0
        public void Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFE86B54030
    }

    public class TraceJsonWriter : JsonWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B54090
        public void GetSerializedJsonMessage(){} // RVA: 0x7FFE86B54570
        public void WriteValue(){} // RVA: 0x7FFE86B560F0 | overloaded x38
        public void WriteUndefined(){} // RVA: 0x7FFE86B55030
        public void WriteNull(){} // RVA: 0x7FFE86B550A0
        public void WriteWhitespace(){} // RVA: 0x7FFE86B561C0
        public void WriteComment(){} // RVA: 0x7FFE86B56230
        public void WriteStartArray(){} // RVA: 0x7FFE86B562A0
        public void WriteEndArray(){} // RVA: 0x7FFE86B56320
        public void WriteStartConstructor(){} // RVA: 0x7FFE86B56380
        public void WriteEndConstructor(){} // RVA: 0x7FFE86B56410
        public void WritePropertyName(){} // RVA: 0x7FFE86B56540 | overloaded x2
        public void WriteStartObject(){} // RVA: 0x7FFE86B56620
        public void WriteEndObject(){} // RVA: 0x7FFE86B566A0
        public void WriteRawValue(){} // RVA: 0x7FFE86B56700
        public void WriteRaw(){} // RVA: 0x7FFE86B56780
        public void Close(){} // RVA: 0x7FFE86B567E0
        public void Flush(){} // RVA: 0x7FFE86B56840
    }

}