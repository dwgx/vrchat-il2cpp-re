// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Serialization
// Classes: 41
// Methods: 485

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Serialization
{
    public class CachedAttributeGetter`1 : Object
    {
        // ── Methods ──
        public void GetAttribute(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class DefaultContractResolver : Object
    {
        public Valve.Newtonsoft.Json.Serialization.IContractResolver _instance;
        public Valve.Newtonsoft.Json.JsonConverter[] BuiltInConverters; // 0x8
        public object TypeContractCacheLock; // 0x10
        public Valve.Newtonsoft.Json.Serialization.DefaultContractResolverState _sharedState; // 0x18
        public Valve.Newtonsoft.Json.Serialization.DefaultContractResolverState _instanceState; // 0x10
        public bool _sharedCache; // 0x18

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE88081920
        public void get_DefaultMembersSearchFlags(){} // RVA: 0x7FFE82707EE0
        public void set_DefaultMembersSearchFlags(){} // RVA: 0x7FFE82717690
        public void get_SerializeCompilerGeneratedMembers(){} // RVA: 0x7FFE811E99D0
        public void get_IgnoreSerializableInterface(){} // RVA: 0x7FFE814B5BF0
        public void get_IgnoreSerializableAttribute(){} // RVA: 0x7FFE8292F1A0
        public void set_IgnoreSerializableAttribute(){} // RVA: 0x7FFE822131E0
        public void get_NamingStrategy(){} // RVA: 0x7FFE81129130
        public void .ctor(){} // RVA: 0x7FFE88081A30 | overloaded x2
        public void GetState(){} // RVA: 0x7FFE88081AF0
        public void ResolveContract(){} // RVA: 0x7FFE88081B60
        public void GetSerializableMembers(){} // RVA: 0x7FFE88081FF0
        public void ShouldSerializeEntityMember(){} // RVA: 0x7FFE88082A60
        public void CreateObjectContract(){} // RVA: 0x7FFE88082BE0
        public void GetExtensionDataMemberForType(){} // RVA: 0x7FFE88083250
        public void SetExtensionDataDelegates(){} // RVA: 0x7FFE88083520
        public void GetAttributeConstructor(){} // RVA: 0x7FFE880841C0
        public void GetParameterizedConstructor(){} // RVA: 0x7FFE880846B0
        public void CreateConstructorParameters(){} // RVA: 0x7FFE880847F0
        public void CreatePropertyFromConstructorParameter(){} // RVA: 0x7FFE880849D0
        public void ResolveContractConverter(){} // RVA: 0x7FFE88084E50
        public void GetDefaultCreator(){} // RVA: 0x7FFE88084EA0
        public void InitializeContract(){} // RVA: 0x7FFE88084F20
        public void ResolveCallbackMethods(){} // RVA: 0x7FFE880852A0
        public void GetCallbackMethodsForType(){} // RVA: 0x7FFE88085640
        public void ShouldSkipDeserialized(){} // RVA: 0x7FFE810FB320
        public void ShouldSkipSerializing(){} // RVA: 0x7FFE810FB320
        public void GetClassHierarchyForType(){} // RVA: 0x7FFE88085F50
        public void CreateDictionaryContract(){} // RVA: 0x7FFE88086120
        public void CreateArrayContract(){} // RVA: 0x7FFE880867E0
        public void CreatePrimitiveContract(){} // RVA: 0x7FFE88086B80
        public void CreateLinqContract(){} // RVA: 0x7FFE88086C00
        public void CreateISerializableContract(){} // RVA: 0x7FFE88086C80
        public void CreateStringContract(){} // RVA: 0x7FFE88086F90
        public void CreateContract(){} // RVA: 0x7FFE88087050
        public void IsJsonPrimitiveType(){} // RVA: 0x7FFE88087580
        public void IsIConvertible(){} // RVA: 0x7FFE88087620
        public void CanConvertToString(){} // RVA: 0x7FFE88087800
        public void IsValidCallback(){} // RVA: 0x7FFE88087A90
        public void GetClrTypeFullName(){} // RVA: 0x7FFE88088260
        public void CreateProperties(){} // RVA: 0x7FFE88088470
        public void CreateMemberValueProvider(){} // RVA: 0x7FFE880889D0
        public void CreateProperty(){} // RVA: 0x7FFE88088AF0
        public void SetPropertySettingsFromAttributes(){} // RVA: 0x7FFE88088EB0
        public void CreateShouldSerializeTest(){} // RVA: 0x7FFE88089680
        public void SetIsSpecifiedActions(){} // RVA: 0x7FFE88089930
        public void ResolvePropertyName(){} // RVA: 0x7FFE88089DB0
        public void ResolveDictionaryKey(){} // RVA: 0x7FFE88089DE0
        public void GetResolvedPropertyName(){} // RVA: 0x7FFE88089E30
        public void .cctor(){} // RVA: 0x7FFE88089E50
    }

    public class DefaultContractResolverState : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880817F0
    }

    public class DefaultReferenceResolver : Object
    {
        // ── Methods ──
        public void GetMappings(){} // RVA: 0x7FFE8808AFE0
        public void ResolveReference(){} // RVA: 0x7FFE8808B2B0
        public void GetReference(){} // RVA: 0x7FFE8808B370
        public void AddReference(){} // RVA: 0x7FFE8808B4B0
        public void IsReferenced(){} // RVA: 0x7FFE8808B540
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DefaultSerializationBinder : SerializationBinder
    {
        // ── Methods ──
        public void GetTypeFromTypeNameKey(){} // RVA: 0x7FFE8808B600
        public void BindToType(){} // RVA: 0x7FFE8808B8D0
        public void .ctor(){} // RVA: 0x7FFE8808BB10
        public void .cctor(){} // RVA: 0x7FFE8808BCF0
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
        public void set_Error(){} // RVA: 0x7FFE81161E80
        public void set_OriginalObject(){} // RVA: 0x7FFE811290D0
        public void set_Member(){} // RVA: 0x7FFE810FCE90
        public void set_Path(){} // RVA: 0x7FFE81129890
        public void get_Handled(){} // RVA: 0x7FFE812CF770
    }

    public class ErrorEventArgs : EventArgs
    {
        public object _currentObject; // 0x10
        public Valve.Newtonsoft.Json.Serialization.ErrorContext _errorContext; // 0x18

        // ── Methods ──
        public void set_CurrentObject(){} // RVA: 0x7FFE810FCE30
        public void set_ErrorContext(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8808BF60
    }

    public class ExtensionDataGetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828B3580
        public void Invoke(){} // RVA: 0x7FFE81156C60
    }

    public class ExtensionDataSetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B318A0
        public void Invoke(){} // RVA: 0x7FFE812574E0
    }

    public class IAttributeProvider
    {
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
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _genericWrapperCreator; // 0xE0
        public System.Func`1<object> _genericTemporaryCollectionCreator; // 0xE8
        public bool _isArray; // 0xF0
        public bool _shouldCreateWrapper; // 0xF1
        public bool _canDeserialize; // 0xF2

        // ── Methods ──
        public void get_CollectionItemType(){} // RVA: 0x7FFE81166120
        public void set_CollectionItemType(){} // RVA: 0x7FFE81166130
        public void get_IsMultidimensionalArray(){} // RVA: 0x7FFE81FF3AD0
        public void set_IsMultidimensionalArray(){} // RVA: 0x7FFE81FE9F60
        public void get_IsArray(){} // RVA: 0x7FFE8117CAD0
        public void set_IsArray(){} // RVA: 0x7FFE8117CAE0
        public void get_ShouldCreateWrapper(){} // RVA: 0x7FFE82145E40
        public void set_ShouldCreateWrapper(){} // RVA: 0x7FFE82145F60
        public void get_CanDeserialize(){} // RVA: 0x7FFE82144680
        public void set_CanDeserialize(){} // RVA: 0x7FFE82146D10
        public void get_ParameterizedCreator(){} // RVA: 0x7FFE8808C070
        public void get_OverrideCreator(){} // RVA: 0x7FFE8181E3D0
        public void set_OverrideCreator(){} // RVA: 0x7FFE86B2EC90
        public void get_HasParameterizedCreator(){} // RVA: 0x7FFE81472650
        public void set_HasParameterizedCreator(){} // RVA: 0x7FFE81472660
        public void get_HasParameterizedCreatorInternal(){} // RVA: 0x7FFE8808C160
        public void .ctor(){} // RVA: 0x7FFE8808C190
        public void CreateWrapper(){} // RVA: 0x7FFE8808CD20
        public void CreateTemporaryCollection(){} // RVA: 0x7FFE8808D270
    }

    public class JsonContainerContract : JsonContract
    {
        public Valve.Newtonsoft.Json.Serialization.JsonContract _itemContract; // 0x90
        public Valve.Newtonsoft.Json.Serialization.JsonContract _finalItemContract; // 0x98
        public Valve.Newtonsoft.Json.JsonConverter _itemConverter; // 0xA0
        public System.Nullable`1<bool> _itemIsReference; // 0xA8
        public System.Nullable`1<0x6663ED7C> _itemReferenceLoopHandling; // 0xAC
        public System.Nullable`1<0x6663EE84> _itemTypeNameHandling; // 0xB4

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
        public void .ctor(){} // RVA: 0x7FFE8808D500
    }

    public class JsonContract : Object
    {
        public bool IsNullable; // 0x10
        public bool IsConvertable; // 0x11
        public bool IsEnum; // 0x12
        public System.Type NonNullableUnderlyingType; // 0x18
        public 0x6663E904 InternalReadType; // 0x20
        public 0x66640A5C ContractType; // 0x24
        public bool IsReadOnlyOrFixedSize; // 0x28
        public bool IsSealed; // 0x29
        public bool IsInstantiable; // 0x2A
        public System.Collections.Generic.List`1<Valve.Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializedCallbacks; // 0x30
        public System.Collections.Generic.IList`1<Valve.Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializingCallbacks; // 0x38
        public System.Collections.Generic.IList`1<Valve.Newtonsoft.Json.Serialization.SerializationCallback> _onSerializedCallbacks; // 0x40

        // ── Methods ──
        public void get_UnderlyingType(){} // RVA: 0x7FFE81199370
        public void set_UnderlyingType(){} // RVA: 0x7FFE81199380
        public void get_CreatedType(){} // RVA: 0x7FFE811C3500
        public void set_CreatedType(){} // RVA: 0x7FFE8808D650
        public void get_IsReference(){} // RVA: 0x7FFE843309A0
        public void set_IsReference(){} // RVA: 0x7FFE843309B0
        public void get_Converter(){} // RVA: 0x7FFE811C3590
        public void set_Converter(){} // RVA: 0x7FFE811C35A0
        public void get_InternalConverter(){} // RVA: 0x7FFE81463AE0
        public void set_InternalConverter(){} // RVA: 0x7FFE81464570
        public void get_OnDeserializedCallbacks(){} // RVA: 0x7FFE8808D720
        public void get_OnDeserializingCallbacks(){} // RVA: 0x7FFE8808D7E0
        public void get_OnSerializedCallbacks(){} // RVA: 0x7FFE8808D8A0
        public void get_OnSerializingCallbacks(){} // RVA: 0x7FFE8808D960
        public void get_OnErrorCallbacks(){} // RVA: 0x7FFE8808DA20
        public void get_DefaultCreator(){} // RVA: 0x7FFE81280C30
        public void set_DefaultCreator(){} // RVA: 0x7FFE81282380
        public void get_DefaultCreatorNonPublic(){} // RVA: 0x7FFE820C4230
        public void set_DefaultCreatorNonPublic(){} // RVA: 0x7FFE820C0790
        public void .ctor(){} // RVA: 0x7FFE8808DAE0
        public void InvokeOnSerializing(){} // RVA: 0x7FFE8808DD60
        public void InvokeOnSerialized(){} // RVA: 0x7FFE8808DF60
        public void InvokeOnDeserializing(){} // RVA: 0x7FFE8808E160
        public void InvokeOnDeserialized(){} // RVA: 0x7FFE8808E360
        public void InvokeOnError(){} // RVA: 0x7FFE8808E4E0
        public void CreateSerializationCallback(){} // RVA: 0x7FFE8808E6F0
        public void CreateSerializationErrorCallback(){} // RVA: 0x7FFE8808E7E0
    }

    public class JsonDictionaryContract : JsonContainerContract
    {
        public System.Func`2<string,string> _dictionaryKeyResolver; // 0xC0
        public System.Type _dictionaryKeyType; // 0xC8
        public System.Type _dictionaryValueType; // 0xD0
        public Valve.Newtonsoft.Json.Serialization.JsonContract _keyContract; // 0xD8
        public System.Type _genericCollectionDefinitionType; // 0xE0
        public System.Type _genericWrapperType; // 0xE8
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _genericWrapperCreator; // 0xF0
        public System.Func`1<object> _genericTemporaryDictionaryCreator; // 0xF8
        public bool _shouldCreateWrapper; // 0x100

        // ── Methods ──
        public void get_DictionaryKeyResolver(){} // RVA: 0x7FFE81166120
        public void set_DictionaryKeyResolver(){} // RVA: 0x7FFE81166130
        public void get_DictionaryKeyType(){} // RVA: 0x7FFE81253460
        public void set_DictionaryKeyType(){} // RVA: 0x7FFE81253470
        public void get_DictionaryValueType(){} // RVA: 0x7FFE81218100
        public void set_DictionaryValueType(){} // RVA: 0x7FFE81218110
        public void get_KeyContract(){} // RVA: 0x7FFE8181EA80
        public void set_KeyContract(){} // RVA: 0x7FFE8117C8A0
        public void get_ShouldCreateWrapper(){} // RVA: 0x7FFE81F84400
        public void set_ShouldCreateWrapper(){} // RVA: 0x7FFE81F84A40
        public void get_ParameterizedCreator(){} // RVA: 0x7FFE8808EB60
        public void get_OverrideCreator(){} // RVA: 0x7FFE81317980
        public void set_OverrideCreator(){} // RVA: 0x7FFE813159A0
        public void get_HasParameterizedCreator(){} // RVA: 0x7FFE86B33050
        public void set_HasParameterizedCreator(){} // RVA: 0x7FFE86B33060
        public void get_HasParameterizedCreatorInternal(){} // RVA: 0x7FFE8808EC50
        public void .ctor(){} // RVA: 0x7FFE8808EC80
        public void CreateWrapper(){} // RVA: 0x7FFE8808F4F0
        public void CreateTemporaryDictionary(){} // RVA: 0x7FFE8808F8F0
    }

    public class JsonFormatterConverter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8808FBE0
        public void GetTokenValue(){} // RVA: 0x7FFE810A1420
        public void Convert(){} // RVA: 0x7FFE8808FDE0
        public void ToBoolean(){} // RVA: 0x7FFE8808FF50
        public void ToByte(){} // RVA: 0x7FFE8808FFA0
        public void ToInt16(){} // RVA: 0x7FFE8808FFF0
        public void ToInt32(){} // RVA: 0x7FFE88090040
        public void ToInt64(){} // RVA: 0x7FFE88090090
        public void ToSingle(){} // RVA: 0x7FFE880900E0
        public void ToString(){} // RVA: 0x7FFE88090130
        public void ToUInt32(){} // RVA: 0x7FFE88090180
    }

    public class JsonISerializableContract : JsonContainerContract
    {
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _iSerializableCreator; // 0xC0

        // ── Methods ──
        public void get_ISerializableCreator(){} // RVA: 0x7FFE81166120
        public void set_ISerializableCreator(){} // RVA: 0x7FFE81166130
        public void .ctor(){} // RVA: 0x7FFE880901D0
    }

    public class JsonLinqContract : JsonContract
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880901F0
    }

    public class JsonObjectContract : JsonContainerContract
    {
        public \ _memberSerialization; // 0xC0
        public System.Nullable`1<0x6663EDD4> _itemRequired; // 0xC4
        public Valve.Newtonsoft.Json.Serialization.JsonPropertyCollection _properties; // 0xD0
        public Valve.Newtonsoft.Json.Serialization.ExtensionDataSetter _extensionDataSetter; // 0xD8
        public Valve.Newtonsoft.Json.Serialization.ExtensionDataGetter _extensionDataGetter; // 0xE0
        public bool ExtensionDataIsJToken; // 0xE8
        public System.Nullable`1<bool> _hasRequiredOrDefaultValueProperties; // 0xE9
        public System.Reflection.ConstructorInfo _parametrizedConstructor; // 0xF0
        public System.Reflection.ConstructorInfo _overrideConstructor; // 0xF8
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _overrideCreator; // 0x100
        public Valve.Newtonsoft.Json.Serialization.ObjectConstructor`1<object> _parameterizedCreator; // 0x108
        public Valve.Newtonsoft.Json.Serialization.JsonPropertyCollection _creatorParameters; // 0x110

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0x7FFE813AB640
        public void set_MemberSerialization(){} // RVA: 0x7FFE813A4A00
        public void get_ItemRequired(){} // RVA: 0x7FFE86B35BC0
        public void set_ItemRequired(){} // RVA: 0x7FFE86B35BD0
        public void get_Properties(){} // RVA: 0x7FFE81218100
        public void set_Properties(){} // RVA: 0x7FFE81218110
        public void get_CreatorParameters(){} // RVA: 0x7FFE88090210
        public void set_OverrideConstructor(){} // RVA: 0x7FFE880902E0
        public void set_ParametrizedConstructor(){} // RVA: 0x7FFE88090430
        public void get_OverrideCreator(){} // RVA: 0x7FFE81828B50
        public void get_ParameterizedCreator(){} // RVA: 0x7FFE8181E3D0
        public void get_ExtensionDataSetter(){} // RVA: 0x7FFE8181EA80
        public void set_ExtensionDataSetter(){} // RVA: 0x7FFE8117C8A0
        public void get_ExtensionDataGetter(){} // RVA: 0x7FFE8117C900
        public void set_ExtensionDataGetter(){} // RVA: 0x7FFE8117C910
        public void set_ExtensionDataValueType(){} // RVA: 0x7FFE88090580
        public void get_HasRequiredOrDefaultValueProperties(){} // RVA: 0x7FFE88090690
        public void .ctor(){} // RVA: 0x7FFE88090960
        public void GetUninitializedObject(){} // RVA: 0x7FFE88090A40
    }

    public class JsonPrimitiveContract : JsonContract
    {
        public 0x6663F0EC _typeCode; // 0x90

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0x7FFE814AA220
        public void set_TypeCode(){} // RVA: 0x7FFE81C8DB30
        public void .ctor(){} // RVA: 0x7FFE88090B50
        public void .cctor(){} // RVA: 0x7FFE88090CB0
    }

    public class JsonProperty : Object
    {
        public System.Nullable`1<0x6663EDD4> _required; // 0x10
        public bool _hasExplicitDefaultValue; // 0x18
        public object _defaultValue; // 0x20
        public bool _hasGeneratedDefaultValue; // 0x28
        public string _propertyName; // 0x30
        public bool _skipPropertyNameEscape; // 0x38
        public System.Type _propertyType; // 0x40
        public Valve.Newtonsoft.Json.Serialization.JsonContract _propertyContract; // 0x48
        public System.Type _declaringType; // 0x50
        public System.Nullable`1<int> _order; // 0x58
        public string _underlyingName; // 0x60
        public Valve.Newtonsoft.Json.Serialization.IValueProvider _valueProvider; // 0x68
        public Valve.Newtonsoft.Json.Serialization.IAttributeProvider _attributeProvider; // 0x70
        public Valve.Newtonsoft.Json.JsonConverter _converter; // 0x78
        public Valve.Newtonsoft.Json.JsonConverter _memberConverter; // 0x80
        public bool _ignored; // 0x88
        public bool _readable; // 0x89
        public bool _writable; // 0x8A
        public bool _hasMemberAttribute; // 0x8B
        public System.Nullable`1<bool> _isReference; // 0x8C
        public System.Nullable`1<0x6663EC74> _nullValueHandling; // 0x90
        public System.Nullable`1<[> _defaultValueHandling; // 0x98
        public System.Nullable`1<0x6663ED7C> _referenceLoopHandling; // 0xA0
        public System.Nullable`1<0x6663ECCC> _objectCreationHandling; // 0xA8
        public System.Nullable`1<0x6663EE84> _typeNameHandling; // 0xB0
        public System.Predicate`1<object> _shouldSerialize; // 0xB8
        public System.Predicate`1<object> _shouldDeserialize; // 0xC0
        public System.Predicate`1<object> _getIsSpecified; // 0xC8
        public System.Action`2<object,object> _setIsSpecified; // 0xD0
        public Valve.Newtonsoft.Json.JsonConverter _itemConverter; // 0xD8

        // ── Methods ──
        public void get_PropertyContract(){} // RVA: 0x7FFE81176730
        public void set_PropertyContract(){} // RVA: 0x7FFE81176740
        public void get_PropertyName(){} // RVA: 0x7FFE8144E200
        public void set_PropertyName(){} // RVA: 0x7FFE88091490
        public void get_DeclaringType(){} // RVA: 0x7FFE8119C0E0
        public void set_DeclaringType(){} // RVA: 0x7FFE812534D0
        public void get_Order(){} // RVA: 0x7FFE811C3500
        public void set_Order(){} // RVA: 0x7FFE825093B0
        public void get_UnderlyingName(){} // RVA: 0x7FFE81199370
        public void set_UnderlyingName(){} // RVA: 0x7FFE81199380
        public void get_ValueProvider(){} // RVA: 0x7FFE81176D50
        public void set_ValueProvider(){} // RVA: 0x7FFE81176D60
        public void set_AttributeProvider(){} // RVA: 0x7FFE811C35A0
        public void get_PropertyType(){} // RVA: 0x7FFE81178740
        public void set_PropertyType(){} // RVA: 0x7FFE880915C0
        public void get_Converter(){} // RVA: 0x7FFE81463AE0
        public void set_Converter(){} // RVA: 0x7FFE81464570
        public void get_MemberConverter(){} // RVA: 0x7FFE81280C30
        public void set_MemberConverter(){} // RVA: 0x7FFE81282380
        public void get_Ignored(){} // RVA: 0x7FFE820C4230
        public void set_Ignored(){} // RVA: 0x7FFE820C0790
        public void get_Readable(){} // RVA: 0x7FFE820C3D10
        public void set_Readable(){} // RVA: 0x7FFE820BE3A0
        public void get_Writable(){} // RVA: 0x7FFE86E6CC70
        public void set_Writable(){} // RVA: 0x7FFE87A310F0
        public void get_HasMemberAttribute(){} // RVA: 0x7FFE86E6CC80
        public void set_HasMemberAttribute(){} // RVA: 0x7FFE820BFD10
        public void get_DefaultValue(){} // RVA: 0x7FFE86B36E90
        public void set_DefaultValue(){} // RVA: 0x7FFE86B36EA0
        public void GetResolvedDefaultValue(){} // RVA: 0x7FFE88091620
        public void get_Required(){} // RVA: 0x7FFE880916B0
        public void get_IsReference(){} // RVA: 0x7FFE8445E430
        public void set_IsReference(){} // RVA: 0x7FFE8445E440
        public void get_NullValueHandling(){} // RVA: 0x7FFE8154EB60
        public void set_NullValueHandling(){} // RVA: 0x7FFE81854020
        public void get_DefaultValueHandling(){} // RVA: 0x7FFE817AE360
        public void set_DefaultValueHandling(){} // RVA: 0x7FFE86225270
        public void get_ReferenceLoopHandling(){} // RVA: 0x7FFE8179C860
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFE86B370C0
        public void get_ObjectCreationHandling(){} // RVA: 0x7FFE817AB5E0
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFE82904630
        public void get_TypeNameHandling(){} // RVA: 0x7FFE81166040
        public void set_TypeNameHandling(){} // RVA: 0x7FFE82904640
        public void get_ShouldSerialize(){} // RVA: 0x7FFE811660B0
        public void set_ShouldSerialize(){} // RVA: 0x7FFE811660C0
        public void get_ShouldDeserialize(){} // RVA: 0x7FFE81166120
        public void get_GetIsSpecified(){} // RVA: 0x7FFE81253460
        public void set_GetIsSpecified(){} // RVA: 0x7FFE81253470
        public void get_SetIsSpecified(){} // RVA: 0x7FFE81218100
        public void set_SetIsSpecified(){} // RVA: 0x7FFE81218110
        public void ToString(){} // RVA: 0x7FFE8144E200
        public void get_ItemConverter(){} // RVA: 0x7FFE8181EA80
        public void set_ItemConverter(){} // RVA: 0x7FFE8117C8A0
        public void get_ItemIsReference(){} // RVA: 0x7FFE86D59AE0
        public void set_ItemIsReference(){} // RVA: 0x7FFE86D59AF0
        public void get_ItemTypeNameHandling(){} // RVA: 0x7FFE86B37160
        public void set_ItemTypeNameHandling(){} // RVA: 0x7FFE86B37170
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x7FFE88091710
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x7FFE88091720
        public void WritePropertyName(){} // RVA: 0x7FFE88091730
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonPropertyCollection : KeyedCollection`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88091790
        public void GetKeyForItem(){} // RVA: 0x7FFE866D9B40
        public void AddProperty(){} // RVA: 0x7FFE88091A30
        public void GetClosestMatchProperty(){} // RVA: 0x7FFE88091CB0
        public void TryGetValue(){} // RVA: 0x7FFE88091D00
        public void GetProperty(){} // RVA: 0x7FFE88091E50
    }

    public class JsonSerializerInternalBase : Object
    {
        public Valve.Newtonsoft.Json.Serialization.ErrorContext _currentErrorContext; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88092090
        public void get_DefaultReferenceMappings(){} // RVA: 0x7FFE880921E0
        public void GetErrorContext(){} // RVA: 0x7FFE88092340
        public void ClearErrorContext(){} // RVA: 0x7FFE880925B0
        public void IsErrorHandled(){} // RVA: 0x7FFE88092660
    }

    public class JsonSerializerInternalReader : JsonSerializerInternalBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88092A90
        public void GetContractSafe(){} // RVA: 0x7FFE88092AA0
        public void Deserialize(){} // RVA: 0x7FFE88092B10
        public void GetInternalSerializer(){} // RVA: 0x7FFE88093040
        public void CreateJToken(){} // RVA: 0x7FFE880931E0
        public void CreateJObject(){} // RVA: 0x7FFE880934F0
        public void CreateValueInternal(){} // RVA: 0x7FFE880938D0
        public void CoerceEmptyStringToNull(){} // RVA: 0x7FFE88093EB0
        public void GetExpectedDescription(){} // RVA: 0x7FFE88093FA0
        public void GetConverter(){} // RVA: 0x7FFE880940B0
        public void CreateObject(){} // RVA: 0x7FFE88094190
        public void ReadMetadataPropertiesToken(){} // RVA: 0x7FFE88094EE0
        public void ReadMetadataProperties(){} // RVA: 0x7FFE88095A40
        public void ResolveTypeName(){} // RVA: 0x7FFE88096540
        public void EnsureArrayContract(){} // RVA: 0x7FFE88096AB0
        public void CreateList(){} // RVA: 0x7FFE88096C70
        public void HasNoDefinedType(){} // RVA: 0x7FFE88097560
        public void EnsureType(){} // RVA: 0x7FFE88097600
        public void SetPropertyValue(){} // RVA: 0x7FFE88097950
        public void CalculatePropertyDetails(){} // RVA: 0x7FFE88097D40
        public void AddReference(){} // RVA: 0x7FFE88098270
        public void HasFlag(){} // RVA: 0x7FFE86874540
        public void ShouldSetPropertyValue(){} // RVA: 0x7FFE88098500
        public void CreateNewList(){} // RVA: 0x7FFE88098610
        public void CreateNewDictionary(){} // RVA: 0x7FFE88098980
        public void OnDeserializing(){} // RVA: 0x7FFE88098C40
        public void OnDeserialized(){} // RVA: 0x7FFE88098E10
        public void PopulateDictionary(){} // RVA: 0x7FFE88098FE0
        public void PopulateMultidimensionalArray(){} // RVA: 0x7FFE88099DB0
        public void ThrowUnexpectedEndException(){} // RVA: 0x7FFE8809A8C0
        public void PopulateList(){} // RVA: 0x7FFE8809A9D0
        public void CreateISerializable(){} // RVA: 0x7FFE8809B210
        public void CreateISerializableItem(){} // RVA: 0x7FFE8809BAE0
        public void CreateObjectUsingCreatorWithParameters(){} // RVA: 0x7FFE8809BD20
        public void DeserializeConvertable(){} // RVA: 0x7FFE8809D650
        public void ResolvePropertyAndCreatorValues(){} // RVA: 0x7FFE8809DAB0
        public void ReadForType(){} // RVA: 0x7FFE8809E730
        public void CreateNewObject(){} // RVA: 0x7FFE8809E940
        public void PopulateObject(){} // RVA: 0x7FFE8809EC20
        public void ShouldDeserialize(){} // RVA: 0x7FFE8809FBC0
        public void CheckPropertyName(){} // RVA: 0x7FFE8809FDA0
        public void SetExtensionData(){} // RVA: 0x7FFE8809FF60
        public void ReadExtensionDataValue(){} // RVA: 0x7FFE880A0090
        public void EndProcessProperty(){} // RVA: 0x7FFE880A0190
        public void SetPropertyPresence(){} // RVA: 0x7FFE880A0630
        public void HandleError(){} // RVA: 0x7FFE880A0770
    }

    public class JsonSerializerInternalWriter : JsonSerializerInternalBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880A08A0
        public void Serialize(){} // RVA: 0x7FFE880A0970
        public void GetInternalSerializer(){} // RVA: 0x7FFE880A0D50
        public void GetContractSafe(){} // RVA: 0x7FFE880A0EF0
        public void SerializePrimitive(){} // RVA: 0x7FFE880A0F70
        public void SerializeValue(){} // RVA: 0x7FFE880A1210
        public void ResolveIsReference(){} // RVA: 0x7FFE880A19A0
        public void ShouldWriteReference(){} // RVA: 0x7FFE880A1A30
        public void ShouldWriteProperty(){} // RVA: 0x7FFE880A1BB0
        public void CheckForCircularReference(){} // RVA: 0x7FFE880A1C90
        public void WriteReference(){} // RVA: 0x7FFE880A2190
        public void GetReference(){} // RVA: 0x7FFE880A23A0
        public void TryConvertToString(){} // RVA: 0x7FFE880A24F0
        public void SerializeString(){} // RVA: 0x7FFE880A27C0
        public void OnSerializing(){} // RVA: 0x7FFE880A2870
        public void OnSerialized(){} // RVA: 0x7FFE880A2A00
        public void SerializeObject(){} // RVA: 0x7FFE880A2B90
        public void CalculatePropertyValues(){} // RVA: 0x7FFE880A3780
        public void WriteObjectStart(){} // RVA: 0x7FFE880A4040
        public void WriteReferenceIdProperty(){} // RVA: 0x7FFE880A4330
        public void WriteTypeProperty(){} // RVA: 0x7FFE880A4500
        public void HasFlag(){} // RVA: 0x7FFE86874540 | overloaded x3
        public void SerializeConvertable(){} // RVA: 0x7FFE880A4700
        public void SerializeList(){} // RVA: 0x7FFE880A4D40
        public void SerializeMultidimensionalArray(){} // RVA: 0x7FFE880A54D0 | overloaded x2
        public void WriteStartArray(){} // RVA: 0x7FFE880A5920
        public void SerializeISerializable(){} // RVA: 0x7FFE880A5D50
        public void ShouldWriteType(){} // RVA: 0x7FFE880A6630
        public void SerializeDictionary(){} // RVA: 0x7FFE880A67C0
        public void GetPropertyName(){} // RVA: 0x7FFE880A7170
        public void HandleError(){} // RVA: 0x7FFE880A7550
        public void ShouldSerialize(){} // RVA: 0x7FFE880A76A0
        public void IsSpecified(){} // RVA: 0x7FFE880A7870
    }

    public class JsonSerializerProxy : JsonSerializer
    {
        public Valve.Newtonsoft.Json.Serialization.JsonSerializerInternalReader _serializerReader; // 0xE0
        public Valve.Newtonsoft.Json.Serialization.JsonSerializerInternalWriter _serializerWriter; // 0xE8
        public Valve.Newtonsoft.Json.JsonSerializer _serializer; // 0xF0
        public object Error; // 0x2
        public object ReferenceResolver; // 0x41D8
        public object TraceWriter; // 0x4288
        public object EqualityComparer; // 0x42E0
        public object Converters;
        public object DefaultValueHandling; // 0x4390
        public long ContractResolver; // 0x4440
        public object MissingMemberHandling; // 0x4498
        public object NullValueHandling; // 0x44F0
        public object ObjectCreationHandling; // 0x4548
        public object ReferenceLoopHandling; // 0x45A0
        public object PreserveReferencesHandling; // 0x45F8
        public object TypeNameHandling; // 0x4650
        public object MetadataPropertyHandling; // 0x4700
        public object TypeNameAssemblyFormat; // 0x4758
        public object TypeNameAssemblyFormat; // 0x47B0

        // ── Methods ──
        public void add_Error(){} // RVA: 0x7FFE86B4F680
        public void remove_Error(){} // RVA: 0x7FFE86B4F6B0
        public void set_ReferenceResolver(){} // RVA: 0x7FFE880A7A40
        public void get_TraceWriter(){} // RVA: 0x7FFE86B4FCB0
        public void set_TraceWriter(){} // RVA: 0x7FFE86B4FCE0
        public void set_EqualityComparer(){} // RVA: 0x7FFE880A7A70
        public void get_Converters(){} // RVA: 0x7FFE86B4FA70
        public void set_DefaultValueHandling(){} // RVA: 0x7FFE86B4FB00
        public void get_ContractResolver(){} // RVA: 0x7FFE880A7AA0
        public void set_ContractResolver(){} // RVA: 0x7FFE880A7AD0
        public void set_MissingMemberHandling(){} // RVA: 0x7FFE86B4F7D0
        public void set_NullValueHandling(){} // RVA: 0x7FFE880A7B00
        public void set_ObjectCreationHandling(){} // RVA: 0x7FFE880A7B30
        public void set_ReferenceLoopHandling(){} // RVA: 0x7FFE880A7B60
        public void set_PreserveReferencesHandling(){} // RVA: 0x7FFE86B4F770
        public void set_TypeNameHandling(){} // RVA: 0x7FFE86B4FD40
        public void get_MetadataPropertyHandling(){} // RVA: 0x7FFE86B4FBF0
        public void set_MetadataPropertyHandling(){} // RVA: 0x7FFE86B4FC20
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x7FFE880A7B90
        public void set_ConstructorHandling(){} // RVA: 0x7FFE86B4FBC0
        public void set_Binder(){} // RVA: 0x7FFE86B4F710
        public void get_Context(){} // RVA: 0x7FFE880A7BC0
        public void set_Context(){} // RVA: 0x7FFE880A7C10
        public void get_Formatting(){} // RVA: 0x7FFE880A7C50
        public void set_Formatting(){} // RVA: 0x7FFE880A7C80
        public void get_CheckAdditionalContent(){} // RVA: 0x7FFE880A7CB0
        public void set_CheckAdditionalContent(){} // RVA: 0x7FFE880A7CE0
        public void GetInternalSerializer(){} // RVA: 0x7FFE86B50220
        public void .ctor(){} // RVA: 0x7FFE880A7E70 | overloaded x2
        public void DeserializeInternal(){} // RVA: 0x7FFE880A7FD0
        public void SerializeInternal(){} // RVA: 0x7FFE880A8030
    }

    public class JsonStringContract : JsonPrimitiveContract
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880A8090
    }

    public class JsonTypeReflector : Object
    {
        public System.Nullable`1<bool> _fullyTrusted;
        public Valve.Newtonsoft.Json.Utilities.ThreadSafeStore`2<System.Type,System.Func`2<object[],object>> CreatorCache; // 0x8

        // ── Methods ──
        public void GetCachedAttribute(){} // RVA: 0x7FFE810A1420
        public void GetDataContractAttribute(){} // RVA: 0x7FFE880A8100
        public void GetDataMemberAttribute(){} // RVA: 0x7FFE880A81A0
        public void GetObjectMemberSerialization(){} // RVA: 0x7FFE880A8410
        public void GetJsonConverter(){} // RVA: 0x7FFE880A8520
        public void CreateJsonConverterInstance(){} // RVA: 0x7FFE880A8650
        public void CreateNamingStrategyInstance(){} // RVA: 0x7FFE880A8750
        public void GetContainerNamingStrategy(){} // RVA: 0x7FFE880A8850
        public void GetCreator(){} // RVA: 0x7FFE880A8940
        public void GetTypeConverter(){} // RVA: 0x7FFE880A8B30
        public void GetAssociatedMetadataType(){} // RVA: 0x7FFE880A8B80
        public void GetAssociateMetadataTypeFromAttribute(){} // RVA: 0x7FFE880A8C10
        public void GetAttribute(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void get_FullyTrusted(){} // RVA: 0x7FFE880A8F10
        public void get_ReflectionDelegateFactory(){} // RVA: 0x7FFE880A90A0
        public void .cctor(){} // RVA: 0x7FFE880A9140
    }

    public class NamingStrategy : Object
    {
        public bool _processDictionaryKeys; // 0x10
        public bool _overrideSpecifiedNames; // 0x11

        // ── Methods ──
        public void get_ProcessDictionaryKeys(){} // RVA: 0x7FFE811C55E0
        public void get_OverrideSpecifiedNames(){} // RVA: 0x7FFE81346E30
        public void GetPropertyName(){} // RVA: 0x7FFE880A98B0
        public void GetDictionaryKey(){} // RVA: 0x7FFE880A98E0
        public void ResolvePropertyName(){} // RVA: 0x7FFE80E2E390
    }

    public class ObjectConstructor`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE80E2E390
    }

    public class OnErrorAttribute : Attribute
    {
    }

    public class ReflectionAttributeProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880A9900
    }

    public class ReflectionValueProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880A99E0
        public void SetValue(){} // RVA: 0x7FFE880A9AC0
        public void GetValue(){} // RVA: 0x7FFE880A9C20
    }

    public class ResolverContractKey : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void GetHashCode(){} // RVA: 0x7FFE8743BEA0
        public void Equals(){} // RVA: 0x7FFE82AC4DD0 | overloaded x2
    }

    public class SerializationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B31440
        public void Invoke(){} // RVA: 0x7FFE83F852E0
    }

    public class SerializationErrorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86B31650
        public void Invoke(){} // RVA: 0x7FFE86B317D0
    }

    public class TraceJsonReader : JsonReader
    {
        public Valve.Newtonsoft.Json.JsonReader _innerReader; // 0x78
        public Valve.Newtonsoft.Json.JsonTextWriter _textWriter; // 0x80
        public System.IO.StringWriter _sw; // 0x88
        public object field_3; // 0xFF
        public object field_4; // 0x100
        public object field_5; // 0x101
        public object field_6; // 0x102

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880A9D70
        public void GetDeserializedJsonMessage(){} // RVA: 0x7FFE86B539F0
        public void Read(){} // RVA: 0x7FFE880AA030
        public void ReadAsInt32(){} // RVA: 0x7FFE880AA0B0
        public void ReadAsString(){} // RVA: 0x7FFE880AA130
        public void ReadAsBytes(){} // RVA: 0x7FFE880AA1B0
        public void ReadAsDecimal(){} // RVA: 0x7FFE880AA230
        public void ReadAsDouble(){} // RVA: 0x7FFE880AA2C0
        public void ReadAsBoolean(){} // RVA: 0x7FFE880AA340
        public void ReadAsDateTime(){} // RVA: 0x7FFE880AA3C0
        public void ReadAsDateTimeOffset(){} // RVA: 0x7FFE880AA440
        public void get_Depth(){} // RVA: 0x7FFE880AA4D0
        public void get_Path(){} // RVA: 0x7FFE880AA500
        public void get_TokenType(){} // RVA: 0x7FFE880AA530
        public void get_Value(){} // RVA: 0x7FFE880AA560
        public void get_ValueType(){} // RVA: 0x7FFE880AA590
        public void Close(){} // RVA: 0x7FFE86AE54C0
        public void Valve.Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x7FFE880AA5C0
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x7FFE880AA620
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x7FFE880AA680
    }

    public class TraceJsonWriter : JsonWriter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880AA6E0
        public void GetSerializedJsonMessage(){} // RVA: 0x7FFE86B54570
        public void WriteValue(){} // RVA: 0x7FFE880AB7B0 | overloaded x21
        public void WriteUndefined(){} // RVA: 0x7FFE880AB0E0
        public void WriteNull(){} // RVA: 0x7FFE880AB150
        public void WriteComment(){} // RVA: 0x7FFE880AB830
        public void WriteStartArray(){} // RVA: 0x7FFE880AB8A0
        public void WriteEndArray(){} // RVA: 0x7FFE880AB900
        public void WriteStartConstructor(){} // RVA: 0x7FFE880AB960
        public void WriteEndConstructor(){} // RVA: 0x7FFE880AB9D0
        public void WritePropertyName(){} // RVA: 0x7FFE880ABB00 | overloaded x2
        public void WriteStartObject(){} // RVA: 0x7FFE880ABBE0
        public void WriteEndObject(){} // RVA: 0x7FFE880ABC40
        public void WriteRawValue(){} // RVA: 0x7FFE880ABCA0
        public void WriteRaw(){} // RVA: 0x7FFE880ABD20
        public void Close(){} // RVA: 0x7FFE880ABD80
    }

}