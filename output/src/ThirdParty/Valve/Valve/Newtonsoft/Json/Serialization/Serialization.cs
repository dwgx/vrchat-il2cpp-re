// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.Newtonsoft.Json.Serialization
// Classes: 39
// Methods: 456

namespace ThirdParty.Valve.Valve.Newtonsoft.Json.Serialization
{
    public class CachedAttributeGetter`1 : Object
    {
        public object TypeAttributeCache;

        // ── Methods ──
        public void GetAttribute(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class DefaultContractResolver : Object
    {
        public object _instance;
        public object BuiltInConverters;
        public object TypeContractCacheLock;
        public object _sharedState;
        public object _instanceState;
        public object _sharedCache;
        public object _defaultMembersSearchFlags;
        public object _serializeCompilerGeneratedMembers;
        public object _ignoreSerializableInterface;
        public object _ignoreSerializableAttribute;
        public object _namingStrategy;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x8178FD0
        public void get_DefaultMembersSearchFlags(){} // RVA: 0x2244FB0
        public void set_DefaultMembersSearchFlags(){} // RVA: 0x22735B0
        public void get_SerializeCompilerGeneratedMembers(){} // RVA: 0xC38360
        public void get_IgnoreSerializableInterface(){} // RVA: 0xF45EE0
        public void get_IgnoreSerializableAttribute(){} // RVA: 0x246F130
        public void set_IgnoreSerializableAttribute(){} // RVA: 0x1AD8C10
        public void get_NamingStrategy(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0x81790E0
        public void GetState(){} // RVA: 0x81791A0
        public void ResolveContract(){} // RVA: 0x8179210
        public void GetSerializableMembers(){} // RVA: 0x81796D0
        public void ShouldSerializeEntityMember(){} // RVA: 0x817A120
        public void CreateObjectContract(){} // RVA: 0x817A280
        public void GetExtensionDataMemberForType(){} // RVA: 0x817A8F0
        public void SetExtensionDataDelegates(){} // RVA: 0x817ABC0
        public void GetAttributeConstructor(){} // RVA: 0x817B920
        public void GetParameterizedConstructor(){} // RVA: 0x817BE30
        public void CreateConstructorParameters(){} // RVA: 0x817BF70
        public void CreatePropertyFromConstructorParameter(){} // RVA: 0x817C160
        public void ResolveContractConverter(){} // RVA: 0x817C650
        public void GetDefaultCreator(){} // RVA: 0x817C6A0
        public void InitializeContract(){} // RVA: 0x817C720
        public void ResolveCallbackMethods(){} // RVA: 0x817CAA0
        public void GetCallbackMethodsForType(){} // RVA: 0x817CE30
        public void ShouldSkipDeserialized(){} // RVA: 0xB43320
        public void ShouldSkipSerializing(){} // RVA: 0xB43320
        public void GetClassHierarchyForType(){} // RVA: 0x817D7D0
        public void CreateDictionaryContract(){} // RVA: 0x817D960
        public void CreateArrayContract(){} // RVA: 0x817E040
        public void CreatePrimitiveContract(){} // RVA: 0x817E410
        public void CreateLinqContract(){} // RVA: 0x817E490
        public void CreateISerializableContract(){} // RVA: 0x817E510
        public void CreateStringContract(){} // RVA: 0x817E7D0
        public void CreateContract(){} // RVA: 0x817E890
        public void IsJsonPrimitiveType(){} // RVA: 0x817EDB0
        public void IsIConvertible(){} // RVA: 0x817EE50
        public void CanConvertToString(){} // RVA: 0x817F060
        public void IsValidCallback(){} // RVA: 0x817F2C0
        public void GetClrTypeFullName(){} // RVA: 0x817FA60
        public void CreateProperties(){} // RVA: 0x817FC70
        public void CreateMemberValueProvider(){} // RVA: 0x81801E0
        public void CreateProperty(){} // RVA: 0x8180300
        public void SetPropertySettingsFromAttributes(){} // RVA: 0x8180720
        public void CreateShouldSerializeTest(){} // RVA: 0x8180F30
        public void SetIsSpecifiedActions(){} // RVA: 0x81811E0
        public void ResolvePropertyName(){} // RVA: 0x8181680
        public void ResolveDictionaryKey(){} // RVA: 0x81816B0
        public void GetResolvedPropertyName(){} // RVA: 0x8181700
        public void .cctor(){} // RVA: 0x8181720
    }

    public class DefaultContractResolverState : Object
    {
        public object ContractCache;
        public object NameTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8178EA0
    }

    public class DefaultReferenceResolver : Object
    {
        public object _referenceCount;

        // ── Methods ──
        public void GetMappings(){} // RVA: 0x8182800
        public void ResolveReference(){} // RVA: 0x8182AD0
        public void GetReference(){} // RVA: 0x8182B90
        public void AddReference(){} // RVA: 0x8182CD0
        public void IsReferenced(){} // RVA: 0x8182D60
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DefaultSerializationBinder : SerializationBinder
    {
        public object Instance;
        public object _typeCache;

        // ── Methods ──
        public void GetTypeFromTypeNameKey(){} // RVA: 0x8182E20
        public void BindToType(){} // RVA: 0x81830E0
        public void .ctor(){} // RVA: 0x8183330
        public void .cctor(){} // RVA: 0x8183510
    }

    public class ErrorContext : Object
    {
        public object _traced;
        public object _error;
        public object _originalObject;
        public object _member;
        public object _path;
        public object _handled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A61F70
        public void get_Traced(){} // RVA: 0xC120A0
        public void set_Traced(){} // RVA: 0xC120B0
        public void get_Error(){} // RVA: 0xB465B0
        public void set_Error(){} // RVA: 0xBA9BA0
        public void set_OriginalObject(){} // RVA: 0xB70100
        public void set_Member(){} // RVA: 0xB44DC0
        public void set_Path(){} // RVA: 0xB708C0
        public void get_Handled(){} // RVA: 0xD16660
    }

    public class ErrorEventArgs : EventArgs
    {
        public object _currentObject;
        public object _errorContext;

        // ── Methods ──
        public void set_CurrentObject(){} // RVA: 0xB44D60
        public void set_ErrorContext(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8183950
    }

    public class ExtensionDataGetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23F1A30
        public void Invoke(){} // RVA: 0xB9E010
    }

    public class ExtensionDataSetter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A65000
        public void Invoke(){} // RVA: 0xCA8D60
    }

    public class IContractResolver
    {
        // ── Methods ──
        public void ResolveContract(){} // RVA: 0x87C540
    }

    public class IReferenceResolver
    {
        // ── Methods ──
        public void ResolveReference(){} // RVA: 0x87C5F0
        public void GetReference(){} // RVA: 0x87C5F0
        public void IsReferenced(){} // RVA: 0x87D3C0
        public void AddReference(){} // RVA: 0x8954D0
    }

    public class ITraceWriter
    {
        // ── Methods ──
        public void get_LevelFilter(){} // RVA: 0x87C130
        public void Trace(){} // RVA: 0x897330
    }

    public class IValueProvider
    {
        // ── Methods ──
        public void SetValue(){} // RVA: 0x8943B0
        public void GetValue(){} // RVA: 0x87C540
    }

    public class JsonArrayContract : JsonContainerContract
    {
        public object _collectionItemType;
        public object _isMultidimensionalArray;
        public object _genericCollectionDefinitionType;
        public object _genericWrapperType;
        public object _genericWrapperCreator;
        public object _genericTemporaryCollectionCreator;
        public object _isArray;
        public object _shouldCreateWrapper;
        public object _canDeserialize;
        public object _parameterizedConstructor;
        public object _parameterizedCreator;
        public object _overrideCreator;
        public object _hasParameterizedCreator;

        // ── Methods ──
        public void get_CollectionItemType(){} // RVA: 0xBAE420
        public void set_CollectionItemType(){} // RVA: 0xBAE430
        public void get_IsMultidimensionalArray(){} // RVA: 0x1C11610
        public void set_IsMultidimensionalArray(){} // RVA: 0x1C10980
        public void get_IsArray(){} // RVA: 0xBC5D20
        public void set_IsArray(){} // RVA: 0xBC5D30
        public void get_ShouldCreateWrapper(){} // RVA: 0x21656F0
        public void set_ShouldCreateWrapper(){} // RVA: 0x216AB00
        public void get_CanDeserialize(){} // RVA: 0x6A621D0
        public void set_CanDeserialize(){} // RVA: 0x6A621E0
        public void get_ParameterizedCreator(){} // RVA: 0x8183A60
        public void get_OverrideCreator(){} // RVA: 0x10B9D50
        public void set_OverrideCreator(){} // RVA: 0x6A62350
        public void get_HasParameterizedCreator(){} // RVA: 0x1184420
        public void set_HasParameterizedCreator(){} // RVA: 0x1EBEA50
        public void get_HasParameterizedCreatorInternal(){} // RVA: 0x8183B50
        public void .ctor(){} // RVA: 0x8183B80
        public void CreateWrapper(){} // RVA: 0x8184840
        public void CreateTemporaryCollection(){} // RVA: 0x8184E20
    }

    public class JsonContainerContract : JsonContract
    {
        public object _itemContract;
        public object _finalItemContract;
        public object _itemConverter;
        public object _itemIsReference;
        public object _itemReferenceLoopHandling;
        public object _itemTypeNameHandling;

        // ── Methods ──
        public void get_ItemContract(){} // RVA: 0x1069350
        public void set_ItemContract(){} // RVA: 0x6A64870
        public void get_FinalItemContract(){} // RVA: 0x106A7D0
        public void get_ItemConverter(){} // RVA: 0x106A050
        public void set_ItemConverter(){} // RVA: 0xD5CCD0
        public void get_ItemIsReference(){} // RVA: 0x6A649F0
        public void set_ItemIsReference(){} // RVA: 0x6A64A00
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x6A64A10
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x6A64A20
        public void get_ItemTypeNameHandling(){} // RVA: 0x6A64A30
        public void set_ItemTypeNameHandling(){} // RVA: 0x6A64A40
        public void .ctor(){} // RVA: 0x81850E0
    }

    public class JsonContract : Object
    {
        public object IsNullable;
        public object IsConvertable;
        public object IsEnum;
        public object NonNullableUnderlyingType;
        public object InternalReadType;
        public object ContractType;
        public object IsReadOnlyOrFixedSize;
        public object IsSealed;
        public object IsInstantiable;
        public object _onDeserializedCallbacks;
        public object _onDeserializingCallbacks;
        public object _onSerializedCallbacks;
        public object _onSerializingCallbacks;
        public object _onErrorCallbacks;
        public object _createdType;
        public object _underlyingType;
        public object _isReference;
        public object _converter;
        public object _internalConverter;
        public object _defaultCreator;
        public object _defaultCreatorNonPublic;

        // ── Methods ──
        public void get_UnderlyingType(){} // RVA: 0xBE2C60
        public void set_UnderlyingType(){} // RVA: 0xBE2C70
        public void get_CreatedType(){} // RVA: 0xC0FFC0
        public void set_CreatedType(){} // RVA: 0x8185230
        public void get_IsReference(){} // RVA: 0x4128620
        public void set_IsReference(){} // RVA: 0x4128630
        public void get_Converter(){} // RVA: 0xC10050
        public void set_Converter(){} // RVA: 0xC10060
        public void get_InternalConverter(){} // RVA: 0xCD3320
        public void set_InternalConverter(){} // RVA: 0xCD4740
        public void get_OnDeserializedCallbacks(){} // RVA: 0x8185300
        public void get_OnDeserializingCallbacks(){} // RVA: 0x81853C0
        public void get_OnSerializedCallbacks(){} // RVA: 0x8185480
        public void get_OnSerializingCallbacks(){} // RVA: 0x8185540
        public void get_OnErrorCallbacks(){} // RVA: 0x8185600
        public void get_DefaultCreator(){} // RVA: 0xCD48B0
        public void set_DefaultCreator(){} // RVA: 0xCD3600
        public void get_DefaultCreatorNonPublic(){} // RVA: 0x1C556E0
        public void set_DefaultCreatorNonPublic(){} // RVA: 0x19CAF90
        public void .ctor(){} // RVA: 0x81856C0
        public void InvokeOnSerializing(){} // RVA: 0x8185940
        public void InvokeOnSerialized(){} // RVA: 0x8185B40
        public void InvokeOnDeserializing(){} // RVA: 0x8185D40
        public void InvokeOnDeserialized(){} // RVA: 0x8185F40
        public void InvokeOnError(){} // RVA: 0x81860D0
        public void CreateSerializationCallback(){} // RVA: 0x81862F0
        public void CreateSerializationErrorCallback(){} // RVA: 0x81863E0
    }

    public class JsonDictionaryContract : JsonContainerContract
    {
        public object _dictionaryKeyResolver;
        public object _dictionaryKeyType;
        public object _dictionaryValueType;
        public object _keyContract;
        public object _genericCollectionDefinitionType;
        public object _genericWrapperType;
        public object _genericWrapperCreator;
        public object _genericTemporaryDictionaryCreator;
        public object _shouldCreateWrapper;
        public object _parameterizedConstructor;
        public object _overrideCreator;
        public object _parameterizedCreator;
        public object _hasParameterizedCreator;

        // ── Methods ──
        public void get_DictionaryKeyResolver(){} // RVA: 0xBAE420
        public void set_DictionaryKeyResolver(){} // RVA: 0xBAE430
        public void get_DictionaryKeyType(){} // RVA: 0xCA4D80
        public void set_DictionaryKeyType(){} // RVA: 0xCA4D90
        public void get_DictionaryValueType(){} // RVA: 0xC68EB0
        public void set_DictionaryValueType(){} // RVA: 0xC68EC0
        public void get_KeyContract(){} // RVA: 0x135D730
        public void set_KeyContract(){} // RVA: 0xBC5AD0
        public void get_ShouldCreateWrapper(){} // RVA: 0x2443BA0
        public void set_ShouldCreateWrapper(){} // RVA: 0x2443BB0
        public void get_ParameterizedCreator(){} // RVA: 0x8186760
        public void get_OverrideCreator(){} // RVA: 0xD9E3D0
        public void set_OverrideCreator(){} // RVA: 0xD9D290
        public void get_HasParameterizedCreator(){} // RVA: 0x6A667F0
        public void set_HasParameterizedCreator(){} // RVA: 0x6A66800
        public void get_HasParameterizedCreatorInternal(){} // RVA: 0x8186850
        public void .ctor(){} // RVA: 0x8186880
        public void CreateWrapper(){} // RVA: 0x81871B0
        public void CreateTemporaryDictionary(){} // RVA: 0x81875C0
    }

    public class JsonFormatterConverter : Object
    {
        public object _reader;
        public object _contract;
        public object _member;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8187910
        public void GetTokenValue(){} // RVA: 0xA94080
        public void Convert(){} // RVA: 0x8187B10
        public void ToBoolean(){} // RVA: 0x8187C80
        public void ToByte(){} // RVA: 0x8187CD0
        public void ToInt16(){} // RVA: 0x8187D20
        public void ToInt32(){} // RVA: 0x8187D70
        public void ToInt64(){} // RVA: 0x8187DC0
        public void ToSingle(){} // RVA: 0x8187E10
        public void ToString(){} // RVA: 0x8187E60
        public void ToUInt32(){} // RVA: 0x8187EB0
    }

    public class JsonISerializableContract : JsonContainerContract
    {
        public object _iSerializableCreator;

        // ── Methods ──
        public void get_ISerializableCreator(){} // RVA: 0xBAE420
        public void set_ISerializableCreator(){} // RVA: 0xBAE430
        public void .ctor(){} // RVA: 0x8187F00
    }

    public class JsonLinqContract : JsonContract
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8187F20
    }

    public class JsonObjectContract : JsonContainerContract
    {
        public object _memberSerialization;
        public object _itemRequired;
        public object _properties;
        public object _extensionDataSetter;
        public object _extensionDataGetter;
        public object ExtensionDataIsJToken;
        public object _hasRequiredOrDefaultValueProperties;
        public object _parametrizedConstructor;
        public object _overrideConstructor;
        public object _overrideCreator;
        public object _parameterizedCreator;
        public object _creatorParameters;
        public object _extensionDataValueType;

        // ── Methods ──
        public void get_MemberSerialization(){} // RVA: 0xE35F30
        public void set_MemberSerialization(){} // RVA: 0xE3CFA0
        public void get_ItemRequired(){} // RVA: 0x6A69530
        public void set_ItemRequired(){} // RVA: 0x6A69540
        public void get_Properties(){} // RVA: 0xC68EB0
        public void set_Properties(){} // RVA: 0xC68EC0
        public void get_CreatorParameters(){} // RVA: 0x8187F40
        public void set_OverrideConstructor(){} // RVA: 0x8188010
        public void set_ParametrizedConstructor(){} // RVA: 0x8188160
        public void get_OverrideCreator(){} // RVA: 0x10B4170
        public void get_ParameterizedCreator(){} // RVA: 0x10B9D50
        public void get_ExtensionDataSetter(){} // RVA: 0x135D730
        public void set_ExtensionDataSetter(){} // RVA: 0xBC5AD0
        public void get_ExtensionDataGetter(){} // RVA: 0xBC5B30
        public void set_ExtensionDataGetter(){} // RVA: 0xBC5B40
        public void set_ExtensionDataValueType(){} // RVA: 0x81882B0
        public void get_HasRequiredOrDefaultValueProperties(){} // RVA: 0x81883D0
        public void .ctor(){} // RVA: 0x81886A0
        public void GetUninitializedObject(){} // RVA: 0x8188780
    }

    public class JsonPrimitiveContract : JsonContract
    {
        public object _typeCode;
        public object ReadTypeMap;

        // ── Methods ──
        public void get_TypeCode(){} // RVA: 0xF3A950
        public void set_TypeCode(){} // RVA: 0x17AFA20
        public void .ctor(){} // RVA: 0x8188890
        public void .cctor(){} // RVA: 0x81889F0
    }

    public class JsonProperty : Object
    {
        public object _required;
        public object _hasExplicitDefaultValue;
        public object _defaultValue;
        public object _hasGeneratedDefaultValue;
        public object _propertyName;
        public object _skipPropertyNameEscape;
        public object _propertyType;
        public object _propertyContract;
        public object _declaringType;
        public object _order;
        public object _underlyingName;
        public object _valueProvider;
        public object _attributeProvider;
        public object _converter;
        public object _memberConverter;
        public object _ignored;
        public object _readable;
        public object _writable;
        public object _hasMemberAttribute;
        public object _isReference;
        public object _nullValueHandling;
        public object _defaultValueHandling;
        public object _referenceLoopHandling;
        public object _objectCreationHandling;
        public object _typeNameHandling;
        public object _shouldSerialize;
        public object _shouldDeserialize;
        public object _getIsSpecified;
        public object _setIsSpecified;
        public object _itemConverter;
        public object _itemIsReference;
        public object _itemTypeNameHandling;
        public object _itemReferenceLoopHandling;

        // ── Methods ──
        public void get_PropertyContract(){} // RVA: 0xBBF8F0
        public void set_PropertyContract(){} // RVA: 0xBBF900
        public void get_PropertyName(){} // RVA: 0xD33E60
        public void set_PropertyName(){} // RVA: 0x8188FF0
        public void get_DeclaringType(){} // RVA: 0xBE58B0
        public void set_DeclaringType(){} // RVA: 0xCA4DF0
        public void get_Order(){} // RVA: 0xC0FFC0
        public void set_Order(){} // RVA: 0xEA1CE0
        public void get_UnderlyingName(){} // RVA: 0xBE2C60
        public void set_UnderlyingName(){} // RVA: 0xBE2C70
        public void get_ValueProvider(){} // RVA: 0xBBFF90
        public void set_ValueProvider(){} // RVA: 0xBBFFA0
        public void set_AttributeProvider(){} // RVA: 0xC10060
        public void get_PropertyType(){} // RVA: 0xBC1B30
        public void set_PropertyType(){} // RVA: 0x8189120
        public void get_Converter(){} // RVA: 0xCD3320
        public void set_Converter(){} // RVA: 0xCD4740
        public void get_MemberConverter(){} // RVA: 0xCD48B0
        public void set_MemberConverter(){} // RVA: 0xCD3600
        public void get_Ignored(){} // RVA: 0x1C556E0
        public void set_Ignored(){} // RVA: 0x19CAF90
        public void get_Readable(){} // RVA: 0x1C4D0B0
        public void set_Readable(){} // RVA: 0x1C4F800
        public void get_Writable(){} // RVA: 0x6D98C00
        public void set_Writable(){} // RVA: 0x8189180
        public void get_HasMemberAttribute(){} // RVA: 0x6D98C10
        public void set_HasMemberAttribute(){} // RVA: 0x1C53B60
        public void get_DefaultValue(){} // RVA: 0x6A6A5E0
        public void set_DefaultValue(){} // RVA: 0x6A6A5F0
        public void GetResolvedDefaultValue(){} // RVA: 0x8189190
        public void get_Required(){} // RVA: 0x8189220
        public void get_IsReference(){} // RVA: 0x8189280
        public void set_IsReference(){} // RVA: 0x8189290
        public void get_NullValueHandling(){} // RVA: 0x1069350
        public void set_NullValueHandling(){} // RVA: 0x25687F0
        public void get_DefaultValueHandling(){} // RVA: 0x106A7D0
        public void set_DefaultValueHandling(){} // RVA: 0x6A6A800
        public void get_ReferenceLoopHandling(){} // RVA: 0x106A050
        public void set_ReferenceLoopHandling(){} // RVA: 0x6A6A810
        public void get_ObjectCreationHandling(){} // RVA: 0x12EB090
        public void set_ObjectCreationHandling(){} // RVA: 0x24440F0
        public void get_TypeNameHandling(){} // RVA: 0xBAE340
        public void set_TypeNameHandling(){} // RVA: 0x2443FC0
        public void get_ShouldSerialize(){} // RVA: 0xBAE3B0
        public void set_ShouldSerialize(){} // RVA: 0xBAE3C0
        public void get_ShouldDeserialize(){} // RVA: 0xBAE420
        public void get_GetIsSpecified(){} // RVA: 0xCA4D80
        public void set_GetIsSpecified(){} // RVA: 0xCA4D90
        public void get_SetIsSpecified(){} // RVA: 0xC68EB0
        public void set_SetIsSpecified(){} // RVA: 0xC68EC0
        public void ToString(){} // RVA: 0xD33E60
        public void get_ItemConverter(){} // RVA: 0x135D730
        public void set_ItemConverter(){} // RVA: 0xBC5AD0
        public void get_ItemIsReference(){} // RVA: 0x6C86EE0
        public void set_ItemIsReference(){} // RVA: 0x6C86EF0
        public void get_ItemTypeNameHandling(){} // RVA: 0x6A6A880
        public void set_ItemTypeNameHandling(){} // RVA: 0x6A6A890
        public void get_ItemReferenceLoopHandling(){} // RVA: 0x81892A0
        public void set_ItemReferenceLoopHandling(){} // RVA: 0x81892B0
        public void WritePropertyName(){} // RVA: 0x81892C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JsonPropertyCollection : KeyedCollection`2
    {
        public object _type;
        public object _list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8189320
        public void GetKeyForItem(){} // RVA: 0x13874F0
        public void AddProperty(){} // RVA: 0x81895B0
        public void GetClosestMatchProperty(){} // RVA: 0x8189830
        public void TryGetValue(){} // RVA: 0x8189880
        public void GetProperty(){} // RVA: 0x81899C0
    }

    public class JsonSerializerInternalBase : Object
    {
        public object _currentErrorContext;
        public object _mappings;
        public object Serializer;
        public object TraceWriter;
        public object InternalSerializer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8189C00
        public void get_DefaultReferenceMappings(){} // RVA: 0x8189D50
        public void GetErrorContext(){} // RVA: 0x8189EB0
        public void ClearErrorContext(){} // RVA: 0x818A130
        public void IsErrorHandled(){} // RVA: 0x818A1E0
    }

    public class JsonSerializerInternalReader : JsonSerializerInternalBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x818A6A0
        public void GetContractSafe(){} // RVA: 0x818A6B0
        public void Deserialize(){} // RVA: 0x818A720
        public void GetInternalSerializer(){} // RVA: 0x818AC50
        public void CreateJToken(){} // RVA: 0x818ADF0
        public void CreateJObject(){} // RVA: 0x818B120
        public void CreateValueInternal(){} // RVA: 0x818B500
        public void CoerceEmptyStringToNull(){} // RVA: 0x818BAC0
        public void GetExpectedDescription(){} // RVA: 0x818BBA0
        public void GetConverter(){} // RVA: 0x818BCB0
        public void CreateObject(){} // RVA: 0x818BD90
        public void ReadMetadataPropertiesToken(){} // RVA: 0x818CB60
        public void ReadMetadataProperties(){} // RVA: 0x818D6B0
        public void ResolveTypeName(){} // RVA: 0x818E1B0
        public void EnsureArrayContract(){} // RVA: 0x818E720
        public void CreateList(){} // RVA: 0x818E8E0
        public void HasNoDefinedType(){} // RVA: 0x818F1C0
        public void EnsureType(){} // RVA: 0x818F260
        public void SetPropertyValue(){} // RVA: 0x818F6D0
        public void CalculatePropertyDetails(){} // RVA: 0x818FAB0
        public void AddReference(){} // RVA: 0x818FFE0
        public void HasFlag(){} // RVA: 0x67AC200
        public void ShouldSetPropertyValue(){} // RVA: 0x8190270
        public void CreateNewList(){} // RVA: 0x8190380
        public void CreateNewDictionary(){} // RVA: 0x81906F0
        public void OnDeserializing(){} // RVA: 0x81909B0
        public void OnDeserialized(){} // RVA: 0x8190B80
        public void PopulateDictionary(){} // RVA: 0x8190D50
        public void PopulateMultidimensionalArray(){} // RVA: 0x8191B60
        public void ThrowUnexpectedEndException(){} // RVA: 0x8192610
        public void PopulateList(){} // RVA: 0x8192720
        public void CreateISerializable(){} // RVA: 0x8192F80
        public void CreateISerializableItem(){} // RVA: 0x8193850
        public void CreateObjectUsingCreatorWithParameters(){} // RVA: 0x8193A90
        public void DeserializeConvertable(){} // RVA: 0x8195360
        public void ResolvePropertyAndCreatorValues(){} // RVA: 0x81957C0
        public void ReadForType(){} // RVA: 0x8196440
        public void CreateNewObject(){} // RVA: 0x8196650
        public void PopulateObject(){} // RVA: 0x8196940
        public void ShouldDeserialize(){} // RVA: 0x8197AC0
        public void CheckPropertyName(){} // RVA: 0x8197C90
        public void SetExtensionData(){} // RVA: 0x8197E50
        public void ReadExtensionDataValue(){} // RVA: 0x8197F80
        public void EndProcessProperty(){} // RVA: 0x8198080
        public void SetPropertyPresence(){} // RVA: 0x8198520
        public void HandleError(){} // RVA: 0x81986F0
    }

    public class JsonSerializerInternalWriter : JsonSerializerInternalBase
    {
        public object _rootType;
        public object _rootLevel;
        public object _serializeStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8198820
        public void Serialize(){} // RVA: 0x81988F0
        public void GetInternalSerializer(){} // RVA: 0x8198CE0
        public void GetContractSafe(){} // RVA: 0x8198E80
        public void SerializePrimitive(){} // RVA: 0x8198F00
        public void SerializeValue(){} // RVA: 0x81991A0
        public void ResolveIsReference(){} // RVA: 0x8199920
        public void ShouldWriteReference(){} // RVA: 0x81999B0
        public void ShouldWriteProperty(){} // RVA: 0x8199B30
        public void CheckForCircularReference(){} // RVA: 0x8199C10
        public void WriteReference(){} // RVA: 0x819A140
        public void GetReference(){} // RVA: 0x819A350
        public void TryConvertToString(){} // RVA: 0x819A4A0
        public void SerializeString(){} // RVA: 0x819A770
        public void OnSerializing(){} // RVA: 0x819A820
        public void OnSerialized(){} // RVA: 0x819A9B0
        public void SerializeObject(){} // RVA: 0x819AB40
        public void CalculatePropertyValues(){} // RVA: 0x819B720
        public void WriteObjectStart(){} // RVA: 0x819BFD0
        public void WriteReferenceIdProperty(){} // RVA: 0x819C2B0
        public void WriteTypeProperty(){} // RVA: 0x819C480
        public void HasFlag(){} // RVA: 0x67AC200
        public void SerializeConvertable(){} // RVA: 0x819C680
        public void SerializeList(){} // RVA: 0x819CCC0
        public void SerializeMultidimensionalArray(){} // RVA: 0x819D450
        public void WriteStartArray(){} // RVA: 0x819D8D0
        public void SerializeISerializable(){} // RVA: 0x819DD00
        public void ShouldWriteType(){} // RVA: 0x819E5E0
        public void SerializeDictionary(){} // RVA: 0x819E770
        public void GetPropertyName(){} // RVA: 0x819F150
        public void HandleError(){} // RVA: 0x819F530
        public void ShouldSerialize(){} // RVA: 0x819F680
        public void IsSpecified(){} // RVA: 0x819F840
    }

    public class JsonSerializerProxy : JsonSerializer
    {
        public object _serializerReader;
        public object _serializerWriter;
        public object _serializer;

        // ── Methods ──
        public void add_Error(){} // RVA: 0x6A83480
        public void remove_Error(){} // RVA: 0x6A834B0
        public void set_ReferenceResolver(){} // RVA: 0x819FA00
        public void get_TraceWriter(){} // RVA: 0x6A83AB0
        public void set_TraceWriter(){} // RVA: 0x6A83AE0
        public void set_EqualityComparer(){} // RVA: 0x819FA30
        public void get_Converters(){} // RVA: 0x6A83870
        public void set_DefaultValueHandling(){} // RVA: 0x6A83900
        public void get_ContractResolver(){} // RVA: 0x819FA60
        public void set_ContractResolver(){} // RVA: 0x819FA90
        public void set_MissingMemberHandling(){} // RVA: 0x6A835D0
        public void set_NullValueHandling(){} // RVA: 0x819FAC0
        public void set_ObjectCreationHandling(){} // RVA: 0x819FAF0
        public void set_ReferenceLoopHandling(){} // RVA: 0x819FB20
        public void set_PreserveReferencesHandling(){} // RVA: 0x6A83570
        public void set_TypeNameHandling(){} // RVA: 0x6A83B40
        public void get_MetadataPropertyHandling(){} // RVA: 0x6A839F0
        public void set_MetadataPropertyHandling(){} // RVA: 0x6A83A20
        public void set_TypeNameAssemblyFormat(){} // RVA: 0x819FB50
        public void set_ConstructorHandling(){} // RVA: 0x6A839C0
        public void set_Binder(){} // RVA: 0x6A83510
        public void get_Context(){} // RVA: 0x819FB80
        public void set_Context(){} // RVA: 0x819FBD0
        public void get_Formatting(){} // RVA: 0x819FC10
        public void set_Formatting(){} // RVA: 0x819FC40
        public void get_CheckAdditionalContent(){} // RVA: 0x819FC70
        public void set_CheckAdditionalContent(){} // RVA: 0x819FCA0
        public void GetInternalSerializer(){} // RVA: 0x6A84020
        public void .ctor(){} // RVA: 0x819FE30
        public void DeserializeInternal(){} // RVA: 0x819FF90
        public void SerializeInternal(){} // RVA: 0x819FFF0
    }

    public class JsonStringContract : JsonPrimitiveContract
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x81A0050
    }

    public class JsonTypeReflector : Object
    {
        public object _fullyTrusted;
        public object CreatorCache;
        public object AssociatedMetadataTypesCache;
        public object _metadataTypeAttributeReflectionObject;

        // ── Methods ──
        public void GetCachedAttribute(){} // RVA: 0xA94080
        public void GetDataContractAttribute(){} // RVA: 0x81A00C0
        public void GetDataMemberAttribute(){} // RVA: 0x81A0160
        public void GetObjectMemberSerialization(){} // RVA: 0x81A03D0
        public void GetJsonConverter(){} // RVA: 0x81A04E0
        public void CreateJsonConverterInstance(){} // RVA: 0x81A0610
        public void CreateNamingStrategyInstance(){} // RVA: 0x81A0710
        public void GetContainerNamingStrategy(){} // RVA: 0x81A0810
        public void GetCreator(){} // RVA: 0x81A0900
        public void GetTypeConverter(){} // RVA: 0x81A0AF0
        public void GetAssociatedMetadataType(){} // RVA: 0x81A0B40
        public void GetAssociateMetadataTypeFromAttribute(){} // RVA: 0x81A0BD0
        public void GetAttribute(){} // RVA: 0xA94080
        public void get_FullyTrusted(){} // RVA: 0x81A0ED0
        public void get_ReflectionDelegateFactory(){} // RVA: 0x81A1060
        public void .cctor(){} // RVA: 0x81A1100
    }

    public class NamingStrategy : Object
    {
        public object _processDictionaryKeys;
        public object _overrideSpecifiedNames;

        // ── Methods ──
        public void get_ProcessDictionaryKeys(){} // RVA: 0xC120A0
        public void get_OverrideSpecifiedNames(){} // RVA: 0xDD5C50
        public void GetPropertyName(){} // RVA: 0x81A1870
        public void GetDictionaryKey(){} // RVA: 0x81A18A0
        public void ResolvePropertyName(){} // RVA: 0x87C540
    }

    public class ObjectConstructor`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0x87C540
    }

    public class ReflectionAttributeProvider : Object
    {
        public object _attributeProvider;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81A18C0
    }

    public class ReflectionValueProvider : Object
    {
        public object _memberInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81A19A0
        public void SetValue(){} // RVA: 0x81A1A80
        public void GetValue(){} // RVA: 0x81A1BE0
    }

    public class ResolverContractKey : ValueType
    {
        public object _resolverType;
        public object _contractType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void GetHashCode(){} // RVA: 0x913170
        public void Equals(){} // RVA: 0x3108B0
    }

    public class SerializationCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A64BC0
        public void Invoke(){} // RVA: 0x3DB9B10
    }

    public class SerializationErrorCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6A64DC0
        public void Invoke(){} // RVA: 0x6A64F30
    }

    public class TraceJsonReader : JsonReader
    {
        public object _innerReader;
        public object _textWriter;
        public object _sw;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81A1D30
        public void GetDeserializedJsonMessage(){} // RVA: 0x6A876D0
        public void Read(){} // RVA: 0x81A1FF0
        public void ReadAsInt32(){} // RVA: 0x81A2070
        public void ReadAsString(){} // RVA: 0x81A20F0
        public void ReadAsBytes(){} // RVA: 0x81A2170
        public void ReadAsDecimal(){} // RVA: 0x81A21F0
        public void ReadAsDouble(){} // RVA: 0x81A2280
        public void ReadAsBoolean(){} // RVA: 0x81A2300
        public void ReadAsDateTime(){} // RVA: 0x81A2380
        public void ReadAsDateTimeOffset(){} // RVA: 0x81A2400
        public void get_Depth(){} // RVA: 0x81A2490
        public void get_Path(){} // RVA: 0x81A24C0
        public void get_TokenType(){} // RVA: 0x81A24F0
        public void get_Value(){} // RVA: 0x81A2520
        public void get_ValueType(){} // RVA: 0x81A2550
        public void Close(){} // RVA: 0x6A19200
        public void Valve.Newtonsoft.Json.IJsonLineInfo.HasLineInfo(){} // RVA: 0x81A2580
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LineNumber(){} // RVA: 0x81A25E0
        public void Valve.Newtonsoft.Json.IJsonLineInfo.get_LinePosition(){} // RVA: 0x81A2640
    }

    public class TraceJsonWriter : JsonWriter
    {
        public object _innerWriter;
        public object _textWriter;
        public object _sw;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x81A26A0
        public void GetSerializedJsonMessage(){} // RVA: 0x6A88270
        public void WriteValue(){} // RVA: 0x81A3790
        public void WriteUndefined(){} // RVA: 0x81A30C0
        public void WriteNull(){} // RVA: 0x81A3130
        public void WriteComment(){} // RVA: 0x81A3810
        public void WriteStartArray(){} // RVA: 0x81A3880
        public void WriteEndArray(){} // RVA: 0x81A38E0
        public void WriteStartConstructor(){} // RVA: 0x81A3940
        public void WriteEndConstructor(){} // RVA: 0x81A39B0
        public void WritePropertyName(){} // RVA: 0x81A3AE0
        public void WriteStartObject(){} // RVA: 0x81A3BC0
        public void WriteEndObject(){} // RVA: 0x81A3C20
        public void WriteRawValue(){} // RVA: 0x81A3C80
        public void WriteRaw(){} // RVA: 0x81A3D00
        public void Close(){} // RVA: 0x81A3D60
    }

}