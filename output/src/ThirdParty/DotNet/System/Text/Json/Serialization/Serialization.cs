// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization
// Classes: 45
// Methods: 320

namespace ThirdParty.DotNet.System.Text.Json.Serialization
{
    public class ConfigurationList`1 : Object
    {
        public System.Collections.Generic.List`1<T> IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void OnCollectionModifying(){} // RVA: 0x7FFAC2C70980
        public void ValidateAddedValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void System.Collections.Generic.IEnumerable<TItem>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void get_DebuggerDisplay(){} // RVA: 0x7FFAC2C58E90
    }

    public class ConverterList : Object
    {
        public System.Collections.Generic.List`1<System.Text.Json.Serialization.JsonConverter> Item; // 0x10
        public System.Text.Json.JsonSerializerOptions Count; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AEB170 | overloaded x2
        public void get_Item(){} // RVA: 0x7FFAC8AEB340
        public void set_Item(){} // RVA: 0x7FFAC8AEB3C0
        public void get_Count(){} // RVA: 0x7FFAC8AEB4C0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void Add(){} // RVA: 0x7FFAC8AEB510
        public void Clear(){} // RVA: 0x7FFAC8AEB5E0
        public void Contains(){} // RVA: 0x7FFAC8AEB670
        public void CopyTo(){} // RVA: 0x7FFAC8AEB6D0
        public void GetEnumerator(){} // RVA: 0x7FFAC8AEB750
        public void IndexOf(){} // RVA: 0x7FFAC8AEB840
        public void Insert(){} // RVA: 0x7FFAC8AEB8C0
        public void Remove(){} // RVA: 0x7FFAC8AEB9A0
        public void RemoveAt(){} // RVA: 0x7FFAC8AEBA20
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8AEBAA0
    }

    public class IAsyncEnumerableConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFAC8AEBB90
        public void CreateConverter(){} // RVA: 0x7FFAC8AEBBB0
        public void GetAsyncEnumerableInterface(){} // RVA: 0x7FFAC8AEBE00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IEnumerableConverterFactoryHelpers : Object
    {
        // ── Methods ──
        public void GetImmutableEnumerableCreateRangeMethod(){} // RVA: 0x7FFAC8AEBEF0
        public void GetImmutableDictionaryCreateRangeMethod(){} // RVA: 0x7FFAC8AEC1C0
        public void GetImmutableEnumerableConstructingType(){} // RVA: 0x7FFAC8AEC4C0
        public void GetImmutableDictionaryConstructingType(){} // RVA: 0x7FFAC8AEC570
        public void IsNonGenericStackOrQueue(){} // RVA: 0x7FFAC8AEC620
        public void GetTypeIfExists(){} // RVA: 0x7FFAC8AEC6D0
    }

    public class IJsonOnDeserialized
    {
        // ── Methods ──
        public void OnDeserialized(){} // RVA: 0x7FFAC2C70980
    }

    public class IJsonOnDeserializing
    {
        // ── Methods ──
        public void OnDeserializing(){} // RVA: 0x7FFAC2C70980
    }

    public class IJsonOnSerialized
    {
        // ── Methods ──
        public void OnSerialized(){} // RVA: 0x7FFAC2C70980
    }

    public class IJsonOnSerializing
    {
        // ── Methods ──
        public void OnSerializing(){} // RVA: 0x7FFAC2C70980
    }

    public class IgnoreReferenceHandler : ReferenceHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AEC750
        public void CreateResolver(){} // RVA: 0x7FFAC8AEC7A0
    }

    public class IgnoreReferenceResolver : ReferenceResolver
    {
        public System.Collections.Generic.Stack`1<System.Text.Json.Serialization.ReferenceEqualsWrapper> _stackForCycleDetection; // 0x10

        // ── Methods ──
        public void PopReferenceForCycleDetection(){} // RVA: 0x7FFAC8AEA510
        public void ContainsReferenceForCycleDetection(){} // RVA: 0x7FFAC8AEA5B0
        public void PushReferenceForCycleDetection(){} // RVA: 0x7FFAC8AEA720
        public void AddReference(){} // RVA: 0x7FFAC8AEA9A0
        public void GetReference(){} // RVA: 0x7FFAC8AEA9E0
        public void ResolveReference(){} // RVA: 0x7FFAC8AEAA20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonCollectionConverter`2 : JsonResumableConverter`1
    {
        public object SupportsCreateObjectDelegate;
        public object ElementType;

        // ── Methods ──
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFAC3006850
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFAC5F41FE0
        public void get_ElementType(){} // RVA: 0x7FFAC5F45900
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC5F437F0
        public void ConvertCollection(){} // RVA: 0x7FFAC2F21310
        public void GetElementConverter(){} // RVA: 0x7FFAC5F43A80 | overloaded x2
        public void OnTryRead(){} // RVA: 0x7FFAC5F45AE0
        public void OnTryWrite(){} // RVA: 0x7FFAC5F46840
        public void OnWriteResume(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC5F46DC0
    }

    public class JsonConstructorAttribute : JsonAttribute
    {
    }

    public class JsonConverter : Object
    {
        public 0x6B1D5E60 Type; // 0x10
        public bool ConverterStrategy; // 0x11
        public bool SupportsCreateObjectDelegate; // 0x12
        public bool CanPopulate; // 0x13
        public bool CanUseDirectReadOrWrite; // 0x14
        public bool CanHaveMetadata; // 0x15
        public bool CanBePolymorphic; // 0x16
        public bool RequiresReadAhead; // 0x17
        public bool UsesDefaultHandleNull; // 0x18
        public bool HandleNullOnRead; // 0x19
        public bool HandleNullOnWrite; // 0x1A
        public System.Reflection.ConstructorInfo SourceConverterForCastingConverter; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC905CE90
        public void get_Type(){} // RVA: 0x7FFAC2C58E90
        public void CanConvert(){} // RVA: 0x7FFAC2C59F60
        public void get_ConverterStrategy(){} // RVA: 0x7FFAC2FEB5E0
        public void set_ConverterStrategy(){} // RVA: 0x7FFAC905D030
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFAC2F21320
        public void get_CanPopulate(){} // RVA: 0x7FFAC2F21320
        public void get_CanUseDirectReadOrWrite(){} // RVA: 0x7FFAC3771DA0
        public void set_CanUseDirectReadOrWrite(){} // RVA: 0x7FFAC3771D90
        public void get_CanHaveMetadata(){} // RVA: 0x7FFAC2F21320
        public void get_CanBePolymorphic(){} // RVA: 0x7FFAC3AE1A90
        public void set_CanBePolymorphic(){} // RVA: 0x7FFAC4411DE0
        public void get_RequiresReadAhead(){} // RVA: 0x7FFAC4411E00
        public void set_RequiresReadAhead(){} // RVA: 0x7FFAC4411E10
        public void ReadElementAndSetProperty(){} // RVA: 0x7FFAC905D070
        public void CreateJsonTypeInfo(){} // RVA: 0x7FFAC905D0B0
        public void CreateCastingConverter(){} // RVA: 0x7FFAC2C58E90
        public void get_UsesDefaultHandleNull(){} // RVA: 0x7FFAC3070BD0
        public void set_UsesDefaultHandleNull(){} // RVA: 0x7FFAC3070BE0
        public void get_HandleNullOnRead(){} // RVA: 0x7FFAC3135090
        public void set_HandleNullOnRead(){} // RVA: 0x7FFAC4411DF0
        public void get_HandleNullOnWrite(){} // RVA: 0x7FFAC4411E30
        public void set_HandleNullOnWrite(){} // RVA: 0x7FFAC4411E20
        public void get_SourceConverterForCastingConverter(){} // RVA: 0x7FFAC34F9180
        public void get_ElementType(){} // RVA: 0x7FFAC2C58E90
        public void get_KeyType(){} // RVA: 0x7FFAC2C58E90
        public void get_IsValueType(){} // RVA: 0x7FFAC89B7390
        public void set_IsValueType(){} // RVA: 0x7FFAC89B73A0
        public void get_IsInternalConverter(){} // RVA: 0x7FFAC2F3C4E0
        public void set_IsInternalConverter(){} // RVA: 0x7FFAC2F3C4F0
        public void get_IsInternalConverterForNumberType(){} // RVA: 0x7FFAC3228D50
        public void set_IsInternalConverterForNumberType(){} // RVA: 0x7FFAC3515120
        public void ShouldFlush(){} // RVA: 0x7FFAC905D0F0
        public void ReadAsObject(){} // RVA: 0x7FFAC2C6AE80
        public void OnTryReadAsObject(){}
        public void TryReadAsObject(){}
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x7FFAC2C6AE80
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x7FFAC2C6AE80
        public void ReadNumberWithCustomHandlingAsObject(){}
        public void WriteAsObject(){} // RVA: 0x7FFAC2C7AF60
        public void OnTryWriteAsObject(){} // RVA: 0x7FFAC2C5D680
        public void TryWriteAsObject(){} // RVA: 0x7FFAC2C5D680
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x7FFAC2C7AF60
        public void WriteAsPropertyNameCoreAsObject(){}
        public void WriteNumberWithCustomHandlingAsObject(){}
        public void get_ConstructorIsParameterized(){} // RVA: 0x7FFAC45FA190
        public void get_ConstructorInfo(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ConstructorInfo(){} // RVA: 0x7FFAC2F4F0D0
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFAC2F21310
        public void ConfigureJsonTypeInfoUsingReflection(){} // RVA: 0x7FFAC2F21310
        public void ResolvePolymorphicConverter(){} // RVA: 0x7FFAC905D3A0 | overloaded x2
        public void TryHandleSerializedObjectReference(){} // RVA: 0x7FFAC905D600
        public void SingleValueReadWithReadAhead(){} // RVA: 0x7FFAC905D740
        public void DoSingleValueReadWithReadAhead(){} // RVA: 0x7FFAC905D770
    }

    public class JsonConverterAttribute : JsonAttribute
    {
        public System.Type ConverterType; // 0x10

        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0x7FFAC2F3C380
        public void CreateConverter(){} // RVA: 0x7FFAC34F9180
    }

    public class JsonConverterFactory : JsonConverter
    {
        public object KeyType;
        public object ElementType;
        public object Type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5FD87A0
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFAC2F21320
        public void CreateConverter(){} // RVA: 0x7FFAC2C6A6F0
        public void get_KeyType(){} // RVA: 0x7FFAC34F9180
        public void get_ElementType(){} // RVA: 0x7FFAC34F9180
        public void GetConverterInternal(){} // RVA: 0x7FFAC905D930
        public void ReadAsObject(){} // RVA: 0x7FFAC905DA00
        public void OnTryReadAsObject(){} // RVA: 0x7FFAC905DA40
        public void TryReadAsObject(){} // RVA: 0x7FFAC905DA80
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x7FFAC905DAC0
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x7FFAC905DB00
        public void ReadNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFAC905DB40
        public void WriteAsObject(){} // RVA: 0x7FFAC905DB80
        public void OnTryWriteAsObject(){} // RVA: 0x7FFAC905DBC0
        public void TryWriteAsObject(){} // RVA: 0x7FFAC905DC00
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x7FFAC905DC40
        public void get_Type(){} // RVA: 0x7FFAC34F9180
        public void WriteAsPropertyNameCoreAsObject(){} // RVA: 0x7FFAC905DC80
        public void WriteNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFAC905DCC0
    }

    public class JsonConverter`1 : JsonConverter
    {
        public System.Type KeyType; // 0x28
        public System.Text.Json.Serialization.JsonConverter`1<T> ElementType; // 0x30

        // ── Methods ──
        public void ReadCore(){} // RVA: 0x7FFAC2E5B230
        public void WriteCore(){} // RVA: 0x7FFAC5FC55D0
        public void .ctor(){} // RVA: 0x7FFAC5FC5880
        public void CanConvert(){} // RVA: 0x7FFAC5FC5B20
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFAC5F481B0
        public void CreateJsonTypeInfo(){} // RVA: 0x7FFAC5FC5BF0
        public void get_KeyType(){} // RVA: 0x7FFAC34F9180
        public void get_ElementType(){} // RVA: 0x7FFAC34F9180
        public void get_HandleNull(){} // RVA: 0x7FFAC5F4A9B0
        public void WriteAsObject(){} // RVA: 0x7FFAC5FC5C70
        public void OnTryWriteAsObject(){} // RVA: 0x7FFAC5FC5E30
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x7FFAC5FC6000
        public void WriteAsPropertyNameCoreAsObject(){} // RVA: 0x7FFAC5FC61C0
        public void WriteNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFAC5FC6390
        public void TryWriteAsObject(){} // RVA: 0x7FFAC5FC6560
        public void OnTryWrite(){} // RVA: 0x7FFAC5FC66D0
        public void OnTryRead(){} // RVA: 0x7FFAC5FC67D0
        public void Read(){} // RVA: 0x7FFAC2E5B230
        public void TryRead(){} // RVA: 0x7FFAC5FC68E0
        public void OnTryReadAsObject(){} // RVA: 0x7FFAC5FC6D60
        public void TryReadAsObject(){} // RVA: 0x7FFAC5FC6EC0
        public void ReadAsObject(){} // RVA: 0x7FFAC5FC7040
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x7FFAC5FC7180
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x7FFAC5FC72C0
        public void ReadNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFAC5FC7400
        public void IsNull(){} // RVA: 0x7FFAC5FC3560
        public void TryWrite(){} // RVA: 0x7FFAC5FC7550
        public void TryWriteDataExtensionProperty(){} // RVA: 0x7FFAC5FC7AF0
        public void get_Type(){} // RVA: 0x7FFAC2F4F130
        public void VerifyRead(){} // RVA: 0x7FFAC5F4C090
        public void VerifyWrite(){} // RVA: 0x7FFAC5F4C150
        public void Write(){} // RVA: 0x7FFAC2E8DC40
        public void ReadAsPropertyName(){} // RVA: 0x7FFAC2E5B230
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC2E5B230
        public void WriteAsPropertyName(){} // RVA: 0x7FFAC5FC80F0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC5FC8270
        public void GetFallbackConverterForPropertyNameSerialization(){} // RVA: 0x7FFAC5FC84D0
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC2E5B230
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC5F49CB0
    }

    public class JsonDerivedTypeAttribute : JsonAttribute
    {
        public System.Type DerivedType; // 0x10
        public object TypeDiscriminator; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC905B690 | overloaded x3
        public void get_DerivedType(){} // RVA: 0x7FFAC2F3C380
        public void get_TypeDiscriminator(){} // RVA: 0x7FFAC2F247C0
    }

    public class JsonDictionaryConverter`1 : JsonResumableConverter`1
    {
        public object SupportsCreateObjectDelegate;

        // ── Methods ──
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFAC3006850
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFAC5FCAC60
        public void OnWriteResume(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC5807970
    }

    public class JsonDictionaryConverter`3 : JsonDictionaryConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<string> ElementType; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<object> KeyType; // 0x40

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C7B8C0
        public void ConvertCollection(){} // RVA: 0x7FFAC2F21310
        public void CreateCollection(){} // RVA: 0x7FFAC5F437F0
        public void get_ElementType(){} // RVA: 0x7FFAC5FD0450
        public void get_KeyType(){} // RVA: 0x7FFAC5FD0500
        public void GetConverter(){} // RVA: 0x7FFAC2C58F80
        public void OnTryRead(){} // RVA: 0x7FFAC5FD05B0
        public void OnTryWrite(){} // RVA: 0x7FFAC5FD1A70
        public void .ctor(){} // RVA: 0x7FFAC5FD0000
        public void <OnTryRead>g__ReadDictionaryKey|10_0(){} // RVA: 0x7FFAC2C6B1A0
    }

    public class JsonExtensionDataAttribute : JsonAttribute
    {
    }

    public class JsonIgnoreAttribute : JsonAttribute
    {
        public 0x6B21E5D8 Condition; // 0x10

        // ── Methods ──
        public void get_Condition(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class JsonIncludeAttribute : JsonAttribute
    {
    }

    public class JsonNumberEnumConverter`1 : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFAC2C59F60
        public void CreateConverter(){} // RVA: 0x7FFAC2C6A6F0
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class JsonNumberHandlingAttribute : JsonAttribute
    {
        public 0x6B21E630 Handling; // 0x10

        // ── Methods ──
        public void get_Handling(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class JsonObjectConverter`1 : JsonResumableConverter`1
    {
        public object ConverterStrategy;
        public object ElementType;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x7FFAC2C59D00
        public void get_ElementType(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class JsonObjectCreationHandlingAttribute : JsonAttribute
    {
        public 0x6B1D6F38 Handling; // 0x10

        // ── Methods ──
        public void get_Handling(){} // RVA: 0x7FFAC2F6E5C0
        public void .ctor(){} // RVA: 0x7FFAC905B5E0
    }

    public class JsonPolymorphicAttribute : JsonAttribute
    {
        public string TypeDiscriminatorPropertyName; // 0x10
        public 0x6B1D7828 UnknownDerivedTypeHandling; // 0x18
        public bool IgnoreUnrecognizedTypeDiscriminators; // 0x1C

        // ── Methods ──
        public void get_TypeDiscriminatorPropertyName(){} // RVA: 0x7FFAC2F3C380
        public void set_TypeDiscriminatorPropertyName(){} // RVA: 0x7FFAC2F22E30
        public void get_UnknownDerivedTypeHandling(){} // RVA: 0x7FFAC3157800
        public void set_UnknownDerivedTypeHandling(){} // RVA: 0x7FFAC392CD10
        public void get_IgnoreUnrecognizedTypeDiscriminators(){} // RVA: 0x7FFAC2F3C390
        public void set_IgnoreUnrecognizedTypeDiscriminators(){} // RVA: 0x7FFAC2F3C3A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonPropertyNameAttribute : JsonAttribute
    {
        public string Name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
    }

    public class JsonPropertyOrderAttribute : JsonAttribute
    {
        public int Order; // 0x10

        // ── Methods ──
        public void get_Order(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class JsonRequiredAttribute : JsonAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonResumableConverter`1 : JsonConverter`1
    {
        public object HandleNull;

        // ── Methods ──
        public void get_HandleNull(){} // RVA: 0x7FFAC2F21320
        public void Read(){} // RVA: 0x7FFAC2E5B230
        public void Write(){} // RVA: 0x7FFAC605C6F0
        public void .ctor(){} // RVA: 0x7FFAC546A1E0
    }

    public class JsonSerializableAttribute : JsonAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonSerializerContext : Object
    {
        public System.Nullable`1<bool> Options; // 0x10
        public System.Text.Json.JsonSerializerOptions CanUseSerializationLogic; // 0x18

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFAC8AEAA60
        public void get_CanUseSerializationLogic(){} // RVA: 0x7FFAC8AEAB80
        public void get_GeneratedSerializerOptions(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC8AEAED0
        public void GetTypeInfo(){} // RVA: 0x7FFAC2C58F40
    }

    public class JsonSourceGenerationOptionsAttribute : JsonAttribute
    {
        public bool AllowTrailingCommas; // 0x10
        public System.Type[] Converters; // 0x18
        public int DefaultBufferSize; // 0x20
        public 0x6B1D6E30 DefaultIgnoreCondition; // 0x24
        public 0x6B1D6E88 DictionaryKeyPolicy; // 0x28
        public bool IgnoreReadOnlyFields; // 0x2C
        public bool IgnoreReadOnlyProperties; // 0x2D
        public bool IncludeFields; // 0x2E
        public int MaxDepth; // 0x30
        public 0x6B1D6EE0 NumberHandling; // 0x34
        public 0x6B1D6F38 PreferredObjectCreationHandling; // 0x38
        public bool PropertyNameCaseInsensitive; // 0x3C
        public 0x6B1D6E88 PropertyNamingPolicy; // 0x40
        public 0x6B1D4B78 ReadCommentHandling; // 0x44
        public 0x6B1D70F0 UnknownTypeHandling; // 0x48
        public 0x6B1D6F90 UnmappedMemberHandling; // 0x4C
        public bool WriteIndented; // 0x50
        public 0x6B1D7040 GenerationMode; // 0x54
        public bool UseStringEnumConverter; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC905B560 | overloaded x2
        public void get_AllowTrailingCommas(){} // RVA: 0x7FFAC2FEB5E0
        public void set_AllowTrailingCommas(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Converters(){} // RVA: 0x7FFAC2F247C0
        public void set_Converters(){} // RVA: 0x7FFAC2F87E80
        public void get_DefaultBufferSize(){} // RVA: 0x7FFAC30DBBE0
        public void set_DefaultBufferSize(){} // RVA: 0x7FFAC35DB7A0
        public void get_DefaultIgnoreCondition(){} // RVA: 0x7FFAC3921980
        public void set_DefaultIgnoreCondition(){} // RVA: 0x7FFAC41674D0
        public void get_DictionaryKeyPolicy(){} // RVA: 0x7FFAC32EC4C0
        public void set_DictionaryKeyPolicy(){} // RVA: 0x7FFAC369A6E0
        public void get_IgnoreReadOnlyFields(){} // RVA: 0x7FFAC3000230
        public void set_IgnoreReadOnlyFields(){} // RVA: 0x7FFAC3000240
        public void get_IgnoreReadOnlyProperties(){} // RVA: 0x7FFAC392CE00
        public void set_IgnoreReadOnlyProperties(){} // RVA: 0x7FFAC473AAD0
        public void get_IncludeFields(){} // RVA: 0x7FFAC473C630
        public void set_IncludeFields(){} // RVA: 0x7FFAC473BA00
        public void get_MaxDepth(){} // RVA: 0x7FFAC2F7CCD0
        public void set_MaxDepth(){} // RVA: 0x7FFAC2F7CCE0
        public void get_NumberHandling(){} // RVA: 0x7FFAC3ADEDC0
        public void set_NumberHandling(){} // RVA: 0x7FFAC416A6E0
        public void get_PreferredObjectCreationHandling(){} // RVA: 0x7FFAC358A870
        public void set_PreferredObjectCreationHandling(){} // RVA: 0x7FFAC3588350
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x7FFAC30864E0
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x7FFAC30864F0
        public void get_PropertyNamingPolicy(){} // RVA: 0x7FFAC2FC2080
        public void set_PropertyNamingPolicy(){} // RVA: 0x7FFAC2FC2090
        public void get_ReadCommentHandling(){} // RVA: 0x7FFAC45A8350
        public void set_ReadCommentHandling(){} // RVA: 0x7FFAC45A8340
        public void get_UnknownTypeHandling(){} // RVA: 0x7FFAC2FC20C0
        public void set_UnknownTypeHandling(){} // RVA: 0x7FFAC2FC20D0
        public void get_UnmappedMemberHandling(){} // RVA: 0x7FFAC3F2D3C0
        public void set_UnmappedMemberHandling(){} // RVA: 0x7FFAC489E500
        public void get_WriteIndented(){} // RVA: 0x7FFAC2FDB8E0
        public void set_WriteIndented(){} // RVA: 0x7FFAC2FDB8F0
        public void get_GenerationMode(){} // RVA: 0x7FFAC38913D0
        public void set_GenerationMode(){} // RVA: 0x7FFAC3890750
        public void get_UseStringEnumConverter(){} // RVA: 0x7FFAC313F600
        public void set_UseStringEnumConverter(){} // RVA: 0x7FFAC3892770
    }

    public class JsonStringEnumConverter : JsonConverterFactory
    {
        public System.Text.Json.JsonNamingPolicy _namingPolicy; // 0x28
        public 0x6B1DAF28 _converterOptions; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC605CC10 | overloaded x2
        public void CanConvert(){} // RVA: 0x7FFAC58091F0
        public void CreateConverter(){} // RVA: 0x7FFAC905DD70
    }

    public class JsonStringEnumConverter`1 : JsonConverterFactory
    {
        public System.Text.Json.JsonNamingPolicy _namingPolicy;
        public 0x6B1DAF28 _converterOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C76500 | overloaded x2
        public void CanConvert(){} // RVA: 0x7FFAC2C59F60
        public void CreateConverter(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class JsonUnmappedMemberHandlingAttribute : JsonAttribute
    {
        public 0x6B1D6F90 UnmappedMemberHandling; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_UnmappedMemberHandling(){} // RVA: 0x7FFAC2F6E5C0
    }

    public class PreserveReferenceHandler : ReferenceHandler
    {
        // ── Methods ──
        public void CreateResolver(){} // RVA: 0x7FFAC8AECED0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC8AECF30
    }

    public class PreserveReferenceResolver : ReferenceResolver
    {
        public uint _referenceCount; // 0x10
        public System.Collections.Generic.Dictionary`2<string,object> _referenceIdToObjectMap; // 0x18
        public System.Collections.Generic.Dictionary`2<object,string> _objectToReferenceIdMap; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AECF80
        public void AddReference(){} // RVA: 0x7FFAC8AED180
        public void GetReference(){} // RVA: 0x7FFAC8AED290
        public void ResolveReference(){} // RVA: 0x7FFAC8AED370
    }

    public class ReadBufferState : ValueType
    {
        public byte[] IsFinalBlock; // 0x10
        public byte Bytes; // 0x18
        public int _count; // 0x1C
        public int _maxCount; // 0x20
        public bool _isFirstBlock; // 0x24
        public bool _isFinalBlock; // 0x25

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC905E2A0
        public void get_IsFinalBlock(){} // RVA: 0x7FFAC3135090
        public void get_Bytes(){} // RVA: 0x7FFAC905E420
        public void ReadFromStreamAsync(){} // RVA: 0x7FFAC905E520
        public void ReadFromStream(){} // RVA: 0x7FFAC905E7E0
        public void AdvanceBuffer(){} // RVA: 0x7FFAC905E860
        public void ProcessReadBytes(){} // RVA: 0x7FFAC905EAB0
        public void Dispose(){} // RVA: 0x7FFAC905ECD0
    }

    public class ReferenceEqualsWrapper : ValueType
    {
        public object _object; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void Equals(){} // RVA: 0x7FFAC5E861F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8AEB040
    }

    public class ReferenceHandler : Object
    {
        public 0x6B1D8010 Preserve; // 0x10
        public System.Text.Json.Serialization.ReferenceHandler IgnoreCycles;
        public System.Text.Json.Serialization.ReferenceHandler <IgnoreCycles>k__BackingField; // 0x8

        // ── Methods ──
        public void get_Preserve(){} // RVA: 0x7FFAC905F2B0
        public void get_IgnoreCycles(){} // RVA: 0x7FFAC905F310
        public void CreateResolver(){} // RVA: 0x7FFAC2FD5BC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC45B41D0
        public void .cctor(){} // RVA: 0x7FFAC905F370
    }

    public class ReferenceHandler`1 : ReferenceHandler
    {
        // ── Methods ──
        public void CreateResolver(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ReferenceResolver : Object
    {
        // ── Methods ──
        public void AddReference(){} // RVA: 0x7FFAC2C79B30
        public void GetReference(){} // RVA: 0x7FFAC2C6A6F0
        public void ResolveReference(){} // RVA: 0x7FFAC2C58F40
        public void PopReferenceForCycleDetection(){} // RVA: 0x7FFAC8AED630
        public void PushReferenceForCycleDetection(){} // RVA: 0x7FFAC8AED670
        public void ContainsReferenceForCycleDetection(){} // RVA: 0x7FFAC8AED6B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}