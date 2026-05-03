// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization
// Classes: 45
// Methods: 320

namespace ThirdParty.DotNet.System.Text.Json.Serialization
{
    public class ConfigurationList`1 : Object
    {
        public System.Collections.Generic.List`1<T> _list;
        public object 0; // 0x1D4
        public object 0; // 0x1D5
        public object 0; // 0x1D6

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void OnCollectionModifying(){} // RVA: 0x7FFE80E45FE0
        public void ValidateAddedValue(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void System.Collections.Generic.IEnumerable<TItem>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_DebuggerDisplay(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ConverterList : Object
    {
        public System.Collections.Generic.List`1<System.Text.Json.Serialization.JsonConverter> _list; // 0x10
        public System.Text.Json.JsonSerializerOptions _options; // 0x18
        public object field_2; // 0x123

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E947F0 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFE86E949C0
        public void set_Item(){} // RVA: 0x7FFE86E94A40
        public void get_Count(){} // RVA: 0x7FFE86E94B40
        public void get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void Add(){} // RVA: 0x7FFE86E94B90
        public void Clear(){} // RVA: 0x7FFE86E94C60
        public void Contains(){} // RVA: 0x7FFE86E94CF0
        public void CopyTo(){} // RVA: 0x7FFE86E94D50
        public void GetEnumerator(){} // RVA: 0x7FFE86E94DD0
        public void IndexOf(){} // RVA: 0x7FFE86E94EC0
        public void Insert(){} // RVA: 0x7FFE86E94F40
        public void Remove(){} // RVA: 0x7FFE86E95020
        public void RemoveAt(){} // RVA: 0x7FFE86E950A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86E95120
    }

    public class IAsyncEnumerableConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFE86E95210
        public void CreateConverter(){} // RVA: 0x7FFE86E95230
        public void GetAsyncEnumerableInterface(){} // RVA: 0x7FFE86E95480
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IEnumerableConverterFactoryHelpers : Object
    {
        // ── Methods ──
        public void GetImmutableEnumerableCreateRangeMethod(){} // RVA: 0x7FFE86E95570
        public void GetImmutableDictionaryCreateRangeMethod(){} // RVA: 0x7FFE86E95840
        public void GetImmutableEnumerableConstructingType(){} // RVA: 0x7FFE86E95B40
        public void GetImmutableDictionaryConstructingType(){} // RVA: 0x7FFE86E95BF0
        public void IsNonGenericStackOrQueue(){} // RVA: 0x7FFE86E95CA0
        public void GetTypeIfExists(){} // RVA: 0x7FFE86E95D50
    }

    public class IJsonOnDeserialized
    {
        // ── Methods ──
        public void OnDeserialized(){} // RVA: 0x7FFE80E45FE0
    }

    public class IJsonOnDeserializing
    {
        // ── Methods ──
        public void OnDeserializing(){} // RVA: 0x7FFE80E45FE0
    }

    public class IJsonOnSerialized
    {
        // ── Methods ──
        public void OnSerialized(){} // RVA: 0x7FFE80E45FE0
    }

    public class IJsonOnSerializing
    {
        // ── Methods ──
        public void OnSerializing(){} // RVA: 0x7FFE80E45FE0
    }

    public class IgnoreReferenceHandler : ReferenceHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E95DD0
        public void CreateResolver(){} // RVA: 0x7FFE86E95E20
    }

    public class IgnoreReferenceResolver : ReferenceResolver
    {
        // ── Methods ──
        public void PopReferenceForCycleDetection(){} // RVA: 0x7FFE86E93B90
        public void ContainsReferenceForCycleDetection(){} // RVA: 0x7FFE86E93C30
        public void PushReferenceForCycleDetection(){} // RVA: 0x7FFE86E93DA0
        public void AddReference(){} // RVA: 0x7FFE86E94020
        public void GetReference(){} // RVA: 0x7FFE86E94060
        public void ResolveReference(){} // RVA: 0x7FFE86E940A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonCollectionConverter`2 : JsonResumableConverter`1
    {
        // ── Methods ──
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFE811E0850
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFE84299240
        public void get_ElementType(){} // RVA: 0x7FFE8429CB50
        public void Add(){} // RVA: 0x7FFE80E4F230
        public void CreateCollection(){} // RVA: 0x7FFE8429AA50
        public void ConvertCollection(){} // RVA: 0x7FFE810FB310
        public void GetElementConverter(){} // RVA: 0x7FFE8429ACE0 | overloaded x2
        public void OnTryRead(){} // RVA: 0x7FFE8429CD30
        public void OnTryWrite(){} // RVA: 0x7FFE8429DA90
        public void OnWriteResume(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE8429E010
    }

    public class JsonConstructorAttribute : JsonAttribute
    {
    }

    public class JsonConverter : Object
    {
        public 0x665CF724 _converterStrategy; // 0x10
        public bool _canUseDirectReadOrWrite; // 0x11
        public bool _canBePolymorphic; // 0x12
        public bool _requiresReadAhead; // 0x13
        public bool _usesDefaultHandleNull; // 0x14
        public bool _handleNullOnRead; // 0x15
        public bool _handleNullOnWrite; // 0x16
        public bool _isValueType; // 0x17
        public bool _isInternalConverter; // 0x18
        public bool _isInternalConverterForNumberType; // 0x19
        public bool _constructorIsParameterized; // 0x1A
        public System.Reflection.ConstructorInfo _constructorInfo; // 0x20
        public object set_Item; // 0x5C80
        public object z0; // 0x88A0
        public object field_14; // 0xB630
        public int field_15; // 0xA2F8
        public object z0; // 0xC1A0
        public object field_17; // 0x9978
        public object field_18; // 0x35A3

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87405640
        public void get_Type(){} // RVA: 0x7FFE80E2E2E0
        public void CanConvert(){} // RVA: 0x7FFE80E2F3B0
        public void get_ConverterStrategy(){} // RVA: 0x7FFE811C55E0
        public void set_ConverterStrategy(){} // RVA: 0x7FFE874057E0
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFE810FB320
        public void get_CanPopulate(){} // RVA: 0x7FFE810FB320
        public void get_CanUseDirectReadOrWrite(){} // RVA: 0x7FFE81346E30
        public void set_CanUseDirectReadOrWrite(){} // RVA: 0x7FFE813471A0
        public void get_CanHaveMetadata(){} // RVA: 0x7FFE810FB320
        public void get_CanBePolymorphic(){} // RVA: 0x7FFE826E3520
        public void set_CanBePolymorphic(){} // RVA: 0x7FFE826E34A0
        public void get_RequiresReadAhead(){} // RVA: 0x7FFE826E3500
        public void set_RequiresReadAhead(){} // RVA: 0x7FFE826E3510
        public void ReadElementAndSetProperty(){} // RVA: 0x7FFE87405820
        public void CreateJsonTypeInfo(){} // RVA: 0x7FFE87405860
        public void CreateCastingConverter(){} // RVA: 0x7FFE80E2E2E0
        public void get_UsesDefaultHandleNull(){} // RVA: 0x7FFE8124ABD0
        public void set_UsesDefaultHandleNull(){} // RVA: 0x7FFE8124ABE0
        public void get_HandleNullOnRead(){} // RVA: 0x7FFE8139AC40
        public void set_HandleNullOnRead(){} // RVA: 0x7FFE826E34C0
        public void get_HandleNullOnWrite(){} // RVA: 0x7FFE826E34B0
        public void set_HandleNullOnWrite(){} // RVA: 0x7FFE826E34D0
        public void get_SourceConverterForCastingConverter(){} // RVA: 0x7FFE813240E0
        public void get_ElementType(){} // RVA: 0x7FFE80E2E2E0
        public void get_KeyType(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsValueType(){} // RVA: 0x7FFE86D60A10
        public void set_IsValueType(){} // RVA: 0x7FFE86D60A20
        public void get_IsInternalConverter(){} // RVA: 0x7FFE811164E0
        public void set_IsInternalConverter(){} // RVA: 0x7FFE811164F0
        public void get_IsInternalConverterForNumberType(){} // RVA: 0x7FFE814B3730
        public void set_IsInternalConverterForNumberType(){} // RVA: 0x7FFE81CD0510
        public void ShouldFlush(){} // RVA: 0x7FFE874058A0
        public void ReadAsObject(){} // RVA: 0x7FFE80E403A0
        public void OnTryReadAsObject(){}
        public void TryReadAsObject(){}
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x7FFE80E403A0
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x7FFE80E403A0
        public void ReadNumberWithCustomHandlingAsObject(){}
        public void WriteAsObject(){} // RVA: 0x7FFE80E50660
        public void OnTryWriteAsObject(){} // RVA: 0x7FFE80E32AD0
        public void TryWriteAsObject(){} // RVA: 0x7FFE80E32AD0
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x7FFE80E50660
        public void WriteAsPropertyNameCoreAsObject(){}
        public void WriteNumberWithCustomHandlingAsObject(){}
        public void get_ConstructorIsParameterized(){} // RVA: 0x7FFE82930110
        public void get_ConstructorInfo(){} // RVA: 0x7FFE811290C0
        public void set_ConstructorInfo(){} // RVA: 0x7FFE811290D0
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFE810FB310
        public void ConfigureJsonTypeInfoUsingReflection(){} // RVA: 0x7FFE810FB310
        public void ResolvePolymorphicConverter(){} // RVA: 0x7FFE87405B50 | overloaded x2
        public void TryHandleSerializedObjectReference(){} // RVA: 0x7FFE87405DB0
        public void SingleValueReadWithReadAhead(){} // RVA: 0x7FFE87405EF0
        public void DoSingleValueReadWithReadAhead(){} // RVA: 0x7FFE87405F20
    }

    public class JsonConverterAttribute : JsonAttribute
    {
        public System.Type _converterType; // 0x10

        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0x7FFE81116380
        public void CreateConverter(){} // RVA: 0x7FFE813240E0
    }

    public class JsonConverterFactory : JsonConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8432FD00
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFE810FB320
        public void CreateConverter(){} // RVA: 0x7FFE80E3FC10
        public void get_KeyType(){} // RVA: 0x7FFE813240E0
        public void get_ElementType(){} // RVA: 0x7FFE813240E0
        public void GetConverterInternal(){} // RVA: 0x7FFE874060E0
        public void ReadAsObject(){} // RVA: 0x7FFE874061B0
        public void OnTryReadAsObject(){} // RVA: 0x7FFE874061F0
        public void TryReadAsObject(){} // RVA: 0x7FFE87406230
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x7FFE87406270
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x7FFE874062B0
        public void ReadNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFE874062F0
        public void WriteAsObject(){} // RVA: 0x7FFE87406330
        public void OnTryWriteAsObject(){} // RVA: 0x7FFE87406370
        public void TryWriteAsObject(){} // RVA: 0x7FFE874063B0
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x7FFE874063F0
        public void get_Type(){} // RVA: 0x7FFE813240E0
        public void WriteAsPropertyNameCoreAsObject(){} // RVA: 0x7FFE87406430
        public void WriteNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFE87406470
    }

    public class JsonConverter`1 : JsonConverter
    {
        public System.Type _type; // 0x28
        public System.Text.Json.Serialization.JsonConverter`1<T> _fallbackConverterForPropertyNameSerialization; // 0x30
        public object KeyType;
        public object KeyType;

        // ── Methods ──
        public void ReadCore(){} // RVA: 0x7FFE81081080
        public void WriteCore(){} // RVA: 0x7FFE8431CB50
        public void .ctor(){} // RVA: 0x7FFE8431CE00
        public void CanConvert(){} // RVA: 0x7FFE8431D0A0
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFE8429F400
        public void CreateJsonTypeInfo(){} // RVA: 0x7FFE8431D170
        public void get_KeyType(){} // RVA: 0x7FFE813240E0
        public void get_ElementType(){} // RVA: 0x7FFE813240E0
        public void get_HandleNull(){} // RVA: 0x7FFE842A1C00
        public void WriteAsObject(){} // RVA: 0x7FFE8431D1F0
        public void OnTryWriteAsObject(){} // RVA: 0x7FFE8431D3B0
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x7FFE8431D580
        public void WriteAsPropertyNameCoreAsObject(){} // RVA: 0x7FFE8431D740
        public void WriteNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFE8431D910
        public void TryWriteAsObject(){} // RVA: 0x7FFE8431DAE0
        public void OnTryWrite(){} // RVA: 0x7FFE8431DC50
        public void OnTryRead(){} // RVA: 0x7FFE8431DD50
        public void Read(){} // RVA: 0x7FFE81081080
        public void TryRead(){} // RVA: 0x7FFE8431DE60
        public void OnTryReadAsObject(){} // RVA: 0x7FFE8431E2E0
        public void TryReadAsObject(){} // RVA: 0x7FFE8431E440
        public void ReadAsObject(){} // RVA: 0x7FFE8431E5C0
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x7FFE8431E700
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x7FFE8431E840
        public void ReadNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFE8431E980
        public void IsNull(){} // RVA: 0x7FFE8431AAE0
        public void TryWrite(){} // RVA: 0x7FFE8431EAD0
        public void TryWriteDataExtensionProperty(){} // RVA: 0x7FFE8431F070
        public void get_Type(){} // RVA: 0x7FFE81129130
        public void VerifyRead(){} // RVA: 0x7FFE842A32E0
        public void VerifyWrite(){} // RVA: 0x7FFE842A33A0
        public void Write(){} // RVA: 0x7FFE810A1420
        public void ReadAsPropertyName(){} // RVA: 0x7FFE81081080
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFE81081080
        public void WriteAsPropertyName(){} // RVA: 0x7FFE8431F670
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFE8431F7F0
        public void GetFallbackConverterForPropertyNameSerialization(){} // RVA: 0x7FFE8431FA50
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFE81081080
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFE842A0F00
    }

    public class JsonDerivedTypeAttribute : JsonAttribute
    {
        public System.Type _derivedType; // 0x10
        public object _typeDiscriminator; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87403E40 | overloaded x3
        public void get_DerivedType(){} // RVA: 0x7FFE81116380
        public void get_TypeDiscriminator(){} // RVA: 0x7FFE810FE7C0
    }

    public class JsonDictionaryConverter`1 : JsonResumableConverter`1
    {
        // ── Methods ──
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFE811E0850
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFE843221E0
        public void OnWriteResume(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE83B23B00
    }

    public class JsonDictionaryConverter`3 : JsonDictionaryConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<string> _keyConverter; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<object> _valueConverter; // 0x40

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E50FC0
        public void ConvertCollection(){} // RVA: 0x7FFE810FB310
        public void CreateCollection(){} // RVA: 0x7FFE8429AA50
        public void get_ElementType(){} // RVA: 0x7FFE843279C0
        public void get_KeyType(){} // RVA: 0x7FFE84327A70
        public void GetConverter(){} // RVA: 0x7FFE80E2E3D0
        public void OnTryRead(){} // RVA: 0x7FFE84327B20
        public void OnTryWrite(){} // RVA: 0x7FFE84328FD0
        public void .ctor(){} // RVA: 0x7FFE84327580
        public void <OnTryRead>g__ReadDictionaryKey|10_0(){} // RVA: 0x7FFE80E406C0
    }

    public class JsonExtensionDataAttribute : JsonAttribute
    {
    }

    public class JsonIgnoreAttribute : JsonAttribute
    {
        public 0x66617E9C _condition; // 0x10

        // ── Methods ──
        public void get_Condition(){} // RVA: 0x7FFE811485C0
    }

    public class JsonIncludeAttribute : JsonAttribute
    {
    }

    public class JsonNumberEnumConverter`1 : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFE80E2F3B0
        public void CreateConverter(){} // RVA: 0x7FFE80E3FC10
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class JsonNumberHandlingAttribute : JsonAttribute
    {
        public 0x66617EF4 _handling; // 0x10

        // ── Methods ──
        public void get_Handling(){} // RVA: 0x7FFE811485C0
    }

    public class JsonObjectConverter`1 : JsonResumableConverter`1
    {
        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x7FFE80E2F150
        public void get_ElementType(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class JsonObjectCreationHandlingAttribute : JsonAttribute
    {
        public 0x665D07FC _handling; // 0x10

        // ── Methods ──
        public void get_Handling(){} // RVA: 0x7FFE811485C0
        public void .ctor(){} // RVA: 0x7FFE87403D90
    }

    public class JsonPolymorphicAttribute : JsonAttribute
    {
        public string _typeDiscriminatorPropertyName; // 0x10
        public 0x665D10EC _unknownDerivedTypeHandling; // 0x18
        public bool _ignoreUnrecognizedTypeDiscriminators; // 0x1C

        // ── Methods ──
        public void get_TypeDiscriminatorPropertyName(){} // RVA: 0x7FFE81116380
        public void set_TypeDiscriminatorPropertyName(){} // RVA: 0x7FFE810FCE30
        public void get_UnknownDerivedTypeHandling(){} // RVA: 0x7FFE813DB630
        public void set_UnknownDerivedTypeHandling(){} // RVA: 0x7FFE8144DF00
        public void get_IgnoreUnrecognizedTypeDiscriminators(){} // RVA: 0x7FFE81116390
        public void set_IgnoreUnrecognizedTypeDiscriminators(){} // RVA: 0x7FFE811163A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonPropertyNameAttribute : JsonAttribute
    {
        public string _name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
    }

    public class JsonPropertyOrderAttribute : JsonAttribute
    {
        public int _order; // 0x10

        // ── Methods ──
        public void get_Order(){} // RVA: 0x7FFE811485C0
    }

    public class JsonRequiredAttribute : JsonAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonResumableConverter`1 : JsonConverter`1
    {
        // ── Methods ──
        public void get_HandleNull(){} // RVA: 0x7FFE810FB320
        public void Read(){} // RVA: 0x7FFE81081080
        public void Write(){} // RVA: 0x7FFE843A8BB0
        public void .ctor(){} // RVA: 0x7FFE8375F130
    }

    public class JsonSerializableAttribute : JsonAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JsonSerializerContext : Object
    {
        public System.Nullable`1<bool> _canUseSerializationLogic; // 0x10
        public System.Text.Json.JsonSerializerOptions _options; // 0x18
        public object field_2; // 0x120

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFE86E940E0
        public void get_CanUseSerializationLogic(){} // RVA: 0x7FFE86E94200
        public void get_GeneratedSerializerOptions(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE86E94550
        public void GetTypeInfo(){} // RVA: 0x7FFE80E2E390
    }

    public class JsonSourceGenerationOptionsAttribute : JsonAttribute
    {
        public bool _allowTrailingCommas; // 0x10
        public System.Type[] _converters; // 0x18
        public int _defaultBufferSize; // 0x20
        public 0x665D06F4 _defaultIgnoreCondition; // 0x24
        public 0x665D074C _dictionaryKeyPolicy; // 0x28
        public bool _ignoreReadOnlyFields; // 0x2C
        public bool _ignoreReadOnlyProperties; // 0x2D
        public bool _includeFields; // 0x2E
        public int _maxDepth; // 0x30
        public 0x665D07A4 _numberHandling; // 0x34
        public 0x665D07FC _preferredObjectCreationHandling; // 0x38
        public bool _propertyNameCaseInsensitive; // 0x3C
        public 0x665D074C _propertyNamingPolicy; // 0x40
        public 0x665CE43C _readCommentHandling; // 0x44
        public 0x665D09B4 _unknownTypeHandling; // 0x48
        public 0x665D0854 _unmappedMemberHandling; // 0x4C
        public bool _writeIndented; // 0x50
        public 0x665D0904 _generationMode; // 0x54
        public bool _useStringEnumConverter; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87403D10 | overloaded x2
        public void get_AllowTrailingCommas(){} // RVA: 0x7FFE811C55E0
        public void set_AllowTrailingCommas(){} // RVA: 0x7FFE811C55F0
        public void get_Converters(){} // RVA: 0x7FFE810FE7C0
        public void set_Converters(){} // RVA: 0x7FFE81161E80
        public void get_DefaultBufferSize(){} // RVA: 0x7FFE8151D690
        public void set_DefaultBufferSize(){} // RVA: 0x7FFE8170B670
        public void get_DefaultIgnoreCondition(){} // RVA: 0x7FFE81A56130
        public void set_DefaultIgnoreCondition(){} // RVA: 0x7FFE82447980
        public void get_DictionaryKeyPolicy(){} // RVA: 0x7FFE81549710
        public void set_DictionaryKeyPolicy(){} // RVA: 0x7FFE817E4800
        public void get_IgnoreReadOnlyFields(){} // RVA: 0x7FFE811DA230
        public void set_IgnoreReadOnlyFields(){} // RVA: 0x7FFE811DA240
        public void get_IgnoreReadOnlyProperties(){} // RVA: 0x7FFE8130C7C0
        public void set_IgnoreReadOnlyProperties(){} // RVA: 0x7FFE8130B300
        public void get_IncludeFields(){} // RVA: 0x7FFE8130ACD0
        public void set_IncludeFields(){} // RVA: 0x7FFE81308970
        public void get_MaxDepth(){} // RVA: 0x7FFE81156CD0
        public void set_MaxDepth(){} // RVA: 0x7FFE81156CE0
        public void get_NumberHandling(){} // RVA: 0x7FFE82447220
        public void set_NumberHandling(){} // RVA: 0x7FFE82443340
        public void get_PreferredObjectCreationHandling(){} // RVA: 0x7FFE81D46090
        public void set_PreferredObjectCreationHandling(){} // RVA: 0x7FFE81D46A00
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x7FFE812604E0
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x7FFE812604F0
        public void get_PropertyNamingPolicy(){} // RVA: 0x7FFE8119C080
        public void set_PropertyNamingPolicy(){} // RVA: 0x7FFE8119C090
        public void get_ReadCommentHandling(){} // RVA: 0x7FFE82876440
        public void set_ReadCommentHandling(){} // RVA: 0x7FFE82876430
        public void get_UnknownTypeHandling(){} // RVA: 0x7FFE8119C0C0
        public void set_UnknownTypeHandling(){} // RVA: 0x7FFE8119C0D0
        public void get_UnmappedMemberHandling(){} // RVA: 0x7FFE821E0A40
        public void set_UnmappedMemberHandling(){} // RVA: 0x7FFE82B06A20
        public void get_WriteIndented(){} // RVA: 0x7FFE811B58E0
        public void set_WriteIndented(){} // RVA: 0x7FFE811B58F0
        public void get_GenerationMode(){} // RVA: 0x7FFE819EA920
        public void set_GenerationMode(){} // RVA: 0x7FFE819EA900
        public void get_UseStringEnumConverter(){} // RVA: 0x7FFE813A1140
        public void set_UseStringEnumConverter(){} // RVA: 0x7FFE819E83C0
    }

    public class JsonStringEnumConverter : JsonConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE843A90D0 | overloaded x2
        public void CanConvert(){} // RVA: 0x7FFE83B45CC0
        public void CreateConverter(){} // RVA: 0x7FFE87406520
    }

    public class JsonStringEnumConverter`1 : JsonConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4BC00 | overloaded x2
        public void CanConvert(){} // RVA: 0x7FFE80E2F3B0
        public void CreateConverter(){} // RVA: 0x7FFE80E3FC10
    }

    public class JsonUnmappedMemberHandlingAttribute : JsonAttribute
    {
        public 0x665D0854 _unmappedMemberHandling; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_UnmappedMemberHandling(){} // RVA: 0x7FFE811485C0
    }

    public class PreserveReferenceHandler : ReferenceHandler
    {
        // ── Methods ──
        public void CreateResolver(){} // RVA: 0x7FFE86E96530 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE86E96590
    }

    public class PreserveReferenceResolver : ReferenceResolver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E965E0
        public void AddReference(){} // RVA: 0x7FFE86E967E0
        public void GetReference(){} // RVA: 0x7FFE86E968F0
        public void ResolveReference(){} // RVA: 0x7FFE86E969D0
    }

    public class ReadBufferState : ValueType
    {
        public byte[] _buffer; // 0x10
        public byte _offset; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87406A50
        public void get_IsFinalBlock(){} // RVA: 0x7FFE8139AC40
        public void get_Bytes(){} // RVA: 0x7FFE87406BD0
        public void ReadFromStreamAsync(){} // RVA: 0x7FFE87406CD0
        public void ReadFromStream(){} // RVA: 0x7FFE87406F90
        public void AdvanceBuffer(){} // RVA: 0x7FFE87407010
        public void ProcessReadBytes(){} // RVA: 0x7FFE87407260
        public void Dispose(){} // RVA: 0x7FFE87407480
    }

    public class ReferenceEqualsWrapper : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void Equals(){} // RVA: 0x7FFE841BEBF0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86E946C0
    }

    public class ReferenceHandler : Object
    {
        public 0x665D18D4 HandlingStrategy; // 0x10
        public System.Text.Json.Serialization.ReferenceHandler _preserve;

        // ── Methods ──
        public void get_Preserve(){} // RVA: 0x7FFE87407A60
        public void get_IgnoreCycles(){} // RVA: 0x7FFE87407AC0
        public void CreateResolver(){} // RVA: 0x7FFE811AFBC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE82880410
        public void .cctor(){} // RVA: 0x7FFE87407B20
    }

    public class ReferenceHandler`1 : ReferenceHandler
    {
        // ── Methods ──
        public void CreateResolver(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ReferenceResolver : Object
    {
        // ── Methods ──
        public void AddReference(){} // RVA: 0x7FFE80E4F230
        public void GetReference(){} // RVA: 0x7FFE80E3FC10
        public void ResolveReference(){} // RVA: 0x7FFE80E2E390
        public void PopReferenceForCycleDetection(){} // RVA: 0x7FFE86E96C90
        public void PushReferenceForCycleDetection(){} // RVA: 0x7FFE86E96CD0
        public void ContainsReferenceForCycleDetection(){} // RVA: 0x7FFE86E96D10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}