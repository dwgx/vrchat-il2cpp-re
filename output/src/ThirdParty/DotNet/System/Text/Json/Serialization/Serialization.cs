// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization
// Classes: 45
// Methods: 320

namespace ThirdParty.DotNet.System.Text.Json.Serialization
{
    public class ConfigurationList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void OnCollectionModifying(){} // RVA: 0x24A50
        public void ValidateAddedValue(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void Add(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void IndexOf(){} // RVA: 0x283FA0
        public void Insert(){} // RVA: 0x283FA0
        public void Remove(){} // RVA: 0x283FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void System.Collections.Generic.IEnumerable<TItem>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void get_DebuggerDisplay(){} // RVA: 0xCD60
    }

    public class ConverterList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6353DD0 | overloaded x2
        public void get_Item(){} // RVA: 0x6353FA0
        public void set_Item(){} // RVA: 0x6354020
        public void get_Count(){} // RVA: 0x6354120
        public void get_IsReadOnly(){} // RVA: 0x2DD320
        public void Add(){} // RVA: 0x6354170
        public void Clear(){} // RVA: 0x6354240
        public void Contains(){} // RVA: 0x63542D0
        public void CopyTo(){} // RVA: 0x6354330
        public void GetEnumerator(){} // RVA: 0x63543B0
        public void IndexOf(){} // RVA: 0x63544A0
        public void Insert(){} // RVA: 0x6354520
        public void Remove(){} // RVA: 0x6354600
        public void RemoveAt(){} // RVA: 0x6354680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6354700
    }

    public class IAsyncEnumerableConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x63547F0
        public void CreateConverter(){} // RVA: 0x6354810
        public void GetAsyncEnumerableInterface(){} // RVA: 0x6354A60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IEnumerableConverterFactoryHelpers
    {
        // ── Methods ──
        public void GetImmutableEnumerableCreateRangeMethod(){} // RVA: 0x6354B50
        public void GetImmutableDictionaryCreateRangeMethod(){} // RVA: 0x6354E20
        public void GetImmutableEnumerableConstructingType(){} // RVA: 0x6355120
        public void GetImmutableDictionaryConstructingType(){} // RVA: 0x63551D0
        public void IsNonGenericStackOrQueue(){} // RVA: 0x6355280
        public void GetTypeIfExists(){} // RVA: 0x6355330
    }

    public class IJsonOnDeserialized
    {
        // ── Methods ──
        public void OnDeserialized(){} // RVA: 0x24A50
    }

    public class IJsonOnDeserializing
    {
        // ── Methods ──
        public void OnDeserializing(){} // RVA: 0x24A50
    }

    public class IJsonOnSerialized
    {
        // ── Methods ──
        public void OnSerialized(){} // RVA: 0x24A50
    }

    public class IJsonOnSerializing
    {
        // ── Methods ──
        public void OnSerializing(){} // RVA: 0x24A50
    }

    public class IgnoreReferenceHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63553B0
        public void CreateResolver(){} // RVA: 0x6355400
    }

    public class IgnoreReferenceResolver
    {
        // ── Methods ──
        public void PopReferenceForCycleDetection(){} // RVA: 0x6353170
        public void ContainsReferenceForCycleDetection(){} // RVA: 0x6353210
        public void PushReferenceForCycleDetection(){} // RVA: 0x6353380
        public void AddReference(){} // RVA: 0x6353600
        public void GetReference(){} // RVA: 0x6353640
        public void ResolveReference(){} // RVA: 0x6353680
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonCollectionConverter`2
    {
        // ── Methods ──
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x3C2850
        public void GetDefaultConverterStrategy(){} // RVA: 0x361F720
        public void get_ElementType(){} // RVA: 0x3623040
        public void Add(){} // RVA: 0x2DC60
        public void CreateCollection(){} // RVA: 0x3620F30
        public void ConvertCollection(){} // RVA: 0x2DD310
        public void GetElementConverter(){} // RVA: 0x36211C0 | overloaded x2
        public void OnTryRead(){} // RVA: 0x3623220
        public void OnTryWrite(){} // RVA: 0x3623F80
        public void OnWriteResume(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x3624500
    }

    public class JsonConstructorAttribute
    {
    }

    public class JsonConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68C6370
        public void get_Type(){} // RVA: 0xCD60
        public void CanConvert(){} // RVA: 0xDE40
        public void get_ConverterStrategy(){} // RVA: 0x3A75E0
        public void set_ConverterStrategy(){} // RVA: 0x68C6510
        public void GetDefaultConverterStrategy(){} // RVA: 0xDBE0
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x2DD320
        public void get_CanPopulate(){} // RVA: 0x2DD320
        public void get_CanUseDirectReadOrWrite(){} // RVA: 0x543460
        public void set_CanUseDirectReadOrWrite(){} // RVA: 0x543470
        public void get_CanHaveMetadata(){} // RVA: 0x2DD320
        public void get_CanBePolymorphic(){} // RVA: 0x195A940
        public void set_CanBePolymorphic(){} // RVA: 0x195A9A0
        public void get_RequiresReadAhead(){} // RVA: 0x195A9E0
        public void set_RequiresReadAhead(){} // RVA: 0x195A9B0
        public void ReadElementAndSetProperty(){} // RVA: 0x68C6550
        public void CreateJsonTypeInfo(){} // RVA: 0x68C6590
        public void CreateCastingConverter(){} // RVA: 0xCD60
        public void get_UsesDefaultHandleNull(){} // RVA: 0x42CBD0
        public void set_UsesDefaultHandleNull(){} // RVA: 0x42CBE0
        public void get_HandleNullOnRead(){} // RVA: 0x5992B0
        public void set_HandleNullOnRead(){} // RVA: 0x195A9C0
        public void get_HandleNullOnWrite(){} // RVA: 0x195A990
        public void set_HandleNullOnWrite(){} // RVA: 0x195A9D0
        public void get_SourceConverterForCastingConverter(){} // RVA: 0x519240
        public void get_ElementType(){} // RVA: 0xCD60
        public void get_KeyType(){} // RVA: 0xCD60
        public void get_IsValueType(){} // RVA: 0x621FEF0
        public void set_IsValueType(){} // RVA: 0x621FF00
        public void get_IsInternalConverter(){} // RVA: 0x2F84E0
        public void set_IsInternalConverter(){} // RVA: 0x2F84F0
        public void get_IsInternalConverterForNumberType(){} // RVA: 0x6B93D0
        public void set_IsInternalConverterForNumberType(){} // RVA: 0xF43D70
        public void ShouldFlush(){} // RVA: 0x68C65D0
        public void ReadAsObject(){} // RVA: 0x1EE30
        public void OnTryReadAsObject(){}
        public void TryReadAsObject(){}
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x1EE30
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x1EE30
        public void ReadNumberWithCustomHandlingAsObject(){}
        public void WriteAsObject(){} // RVA: 0x2F090
        public void OnTryWriteAsObject(){} // RVA: 0x115A0
        public void TryWriteAsObject(){} // RVA: 0x115A0
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x2F090
        public void WriteAsPropertyNameCoreAsObject(){}
        public void WriteNumberWithCustomHandlingAsObject(){}
        public void get_ConstructorIsParameterized(){} // RVA: 0x1B98340
        public void get_ConstructorInfo(){} // RVA: 0x30B0C0
        public void set_ConstructorInfo(){} // RVA: 0x30B0D0
        public void ConfigureJsonTypeInfo(){} // RVA: 0x2DD310
        public void ConfigureJsonTypeInfoUsingReflection(){} // RVA: 0x2DD310
        public void ResolvePolymorphicConverter(){} // RVA: 0x68C6880 | overloaded x2
        public void TryHandleSerializedObjectReference(){} // RVA: 0x68C6AE0
        public void SingleValueReadWithReadAhead(){} // RVA: 0x68C6C20
        public void DoSingleValueReadWithReadAhead(){} // RVA: 0x68C6C50
    }

    public class JsonConverterAttribute
    {
        // ── Methods ──
        public void get_ConverterType(){} // RVA: 0x2F8380
        public void CreateConverter(){} // RVA: 0x519240
    }

    public class JsonConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x36ABC40
        public void GetDefaultConverterStrategy(){} // RVA: 0x2DD320
        public void CreateConverter(){} // RVA: 0x1E6A0
        public void get_KeyType(){} // RVA: 0x519240
        public void get_ElementType(){} // RVA: 0x519240
        public void GetConverterInternal(){} // RVA: 0x68C6E10
        public void ReadAsObject(){} // RVA: 0x68C6EE0
        public void OnTryReadAsObject(){} // RVA: 0x68C6F20
        public void TryReadAsObject(){} // RVA: 0x68C6F60
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x68C6FA0
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x68C6FE0
        public void ReadNumberWithCustomHandlingAsObject(){} // RVA: 0x68C7020
        public void WriteAsObject(){} // RVA: 0x68C7060
        public void OnTryWriteAsObject(){} // RVA: 0x68C70A0
        public void TryWriteAsObject(){} // RVA: 0x68C70E0
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x68C7120
        public void get_Type(){} // RVA: 0x519240
        public void WriteAsPropertyNameCoreAsObject(){} // RVA: 0x68C7160
        public void WriteNumberWithCustomHandlingAsObject(){} // RVA: 0x68C71A0
    }

    public class JsonConverter`1
    {
        // ── Methods ──
        public void ReadCore(){} // RVA: 0x263BC0
        public void WriteCore(){} // RVA: 0x3698A70
        public void .ctor(){} // RVA: 0x3698D20
        public void CanConvert(){} // RVA: 0x3698FC0
        public void GetDefaultConverterStrategy(){} // RVA: 0x36258F0
        public void CreateJsonTypeInfo(){} // RVA: 0x3699090
        public void get_KeyType(){} // RVA: 0x519240
        public void get_ElementType(){} // RVA: 0x519240
        public void get_HandleNull(){} // RVA: 0x36280F0
        public void WriteAsObject(){} // RVA: 0x3699110
        public void OnTryWriteAsObject(){} // RVA: 0x36992D0
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x36994A0
        public void WriteAsPropertyNameCoreAsObject(){} // RVA: 0x3699660
        public void WriteNumberWithCustomHandlingAsObject(){} // RVA: 0x3699830
        public void TryWriteAsObject(){} // RVA: 0x3699A00
        public void OnTryWrite(){} // RVA: 0x3699B70
        public void OnTryRead(){} // RVA: 0x3699C70
        public void Read(){} // RVA: 0x263BC0
        public void TryRead(){} // RVA: 0x3699D80
        public void OnTryReadAsObject(){} // RVA: 0x369A200
        public void TryReadAsObject(){} // RVA: 0x369A360
        public void ReadAsObject(){} // RVA: 0x369A4E0
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x369A620
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x369A760
        public void ReadNumberWithCustomHandlingAsObject(){} // RVA: 0x369A8A0
        public void IsNull(){} // RVA: 0x3696A00
        public void TryWrite(){} // RVA: 0x369A9F0
        public void TryWriteDataExtensionProperty(){} // RVA: 0x369AF90
        public void get_Type(){} // RVA: 0x30B130
        public void VerifyRead(){} // RVA: 0x36297D0
        public void VerifyWrite(){} // RVA: 0x3629890
        public void Write(){} // RVA: 0x283FA0
        public void ReadAsPropertyName(){} // RVA: 0x263BC0
        public void ReadAsPropertyNameCore(){} // RVA: 0x263BC0
        public void WriteAsPropertyName(){} // RVA: 0x369B590
        public void WriteAsPropertyNameCore(){} // RVA: 0x369B710
        public void GetFallbackConverterForPropertyNameSerialization(){} // RVA: 0x369B970
        public void ReadNumberWithCustomHandling(){} // RVA: 0x263BC0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x36273F0
    }

    public class JsonDerivedTypeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68C4B70 | overloaded x3
        public void get_DerivedType(){} // RVA: 0x2F8380
        public void get_TypeDiscriminator(){} // RVA: 0x2E07C0
    }

    public class JsonDictionaryConverter`1
    {
        // ── Methods ──
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x3C2850
        public void GetDefaultConverterStrategy(){} // RVA: 0x369E100
        public void OnWriteResume(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x2E751C0
    }

    public class JsonDictionaryConverter`3
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x2F9F0
        public void ConvertCollection(){} // RVA: 0x2DD310
        public void CreateCollection(){} // RVA: 0x3620F30
        public void get_ElementType(){} // RVA: 0x36A38F0
        public void get_KeyType(){} // RVA: 0x36A39A0
        public void GetConverter(){} // RVA: 0xCE50
        public void OnTryRead(){} // RVA: 0x36A3A50
        public void OnTryWrite(){} // RVA: 0x36A4F10
        public void .ctor(){} // RVA: 0x36A34A0
        public void <OnTryRead>g__ReadDictionaryKey|10_0(){} // RVA: 0x1F150
    }

    public class JsonExtensionDataAttribute
    {
    }

    public class JsonIgnoreAttribute
    {
        // ── Methods ──
        public void get_Condition(){} // RVA: 0x32A5C0
    }

    public class JsonIncludeAttribute
    {
    }

    public class JsonNumberEnumConverter`1
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0xDE40
        public void CreateConverter(){} // RVA: 0x1E6A0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class JsonNumberHandlingAttribute
    {
        // ── Methods ──
        public void get_Handling(){} // RVA: 0x32A5C0
    }

    public class JsonObjectConverter`1
    {
        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0xDBE0
        public void get_ElementType(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24A50
    }

    public class JsonObjectCreationHandlingAttribute
    {
        // ── Methods ──
        public void get_Handling(){} // RVA: 0x32A5C0
        public void .ctor(){} // RVA: 0x68C4AC0
    }

    public class JsonPolymorphicAttribute
    {
        // ── Methods ──
        public void get_TypeDiscriminatorPropertyName(){} // RVA: 0x2F8380
        public void set_TypeDiscriminatorPropertyName(){} // RVA: 0x2DEE30
        public void get_UnknownDerivedTypeHandling(){} // RVA: 0x5BED50
        public void set_UnknownDerivedTypeHandling(){} // RVA: 0x6374E0
        public void get_IgnoreUnrecognizedTypeDiscriminators(){} // RVA: 0x2F8390
        public void set_IgnoreUnrecognizedTypeDiscriminators(){} // RVA: 0x2F83A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonPropertyNameAttribute
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
    }

    public class JsonPropertyOrderAttribute
    {
        // ── Methods ──
        public void get_Order(){} // RVA: 0x32A5C0
    }

    public class JsonRequiredAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonResumableConverter`1
    {
        // ── Methods ──
        public void get_HandleNull(){} // RVA: 0x2DD320
        public void Read(){} // RVA: 0x263BC0
        public void Write(){} // RVA: 0x372F2A0
        public void .ctor(){} // RVA: 0x2A9AD20
    }

    public class JsonSerializableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonSerializerContext
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x63536C0
        public void get_CanUseSerializationLogic(){} // RVA: 0x63537E0
        public void get_GeneratedSerializerOptions(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x6353B30
        public void GetTypeInfo(){} // RVA: 0xCE10
    }

    public class JsonSourceGenerationOptionsAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68C4A40 | overloaded x2
        public void get_AllowTrailingCommas(){} // RVA: 0x3A75E0
        public void set_AllowTrailingCommas(){} // RVA: 0x3A75F0
        public void get_Converters(){} // RVA: 0x2E07C0
        public void set_Converters(){} // RVA: 0x343E80
        public void get_DefaultBufferSize(){} // RVA: 0x760030
        public void set_DefaultBufferSize(){} // RVA: 0x99E0D0
        public void get_DefaultIgnoreCondition(){} // RVA: 0xCEF5B0
        public void set_DefaultIgnoreCondition(){} // RVA: 0x16E1F00
        public void get_DictionaryKeyPolicy(){} // RVA: 0x791DC0
        public void set_DictionaryKeyPolicy(){} // RVA: 0xA53440
        public void get_IgnoreReadOnlyFields(){} // RVA: 0x3BC230
        public void set_IgnoreReadOnlyFields(){} // RVA: 0x3BC240
        public void get_IgnoreReadOnlyProperties(){} // RVA: 0x4FDE20
        public void set_IgnoreReadOnlyProperties(){} // RVA: 0x4FC950
        public void get_IncludeFields(){} // RVA: 0x4FB980
        public void set_IncludeFields(){} // RVA: 0x4FB0C0
        public void get_MaxDepth(){} // RVA: 0x338CD0
        public void set_MaxDepth(){} // RVA: 0x338CE0
        public void get_NumberHandling(){} // RVA: 0x4C6670
        public void set_NumberHandling(){} // RVA: 0x4C5F20
        public void get_PreferredObjectCreationHandling(){} // RVA: 0xFDC9F0
        public void set_PreferredObjectCreationHandling(){} // RVA: 0xFDD6E0
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x4424E0
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x4424F0
        public void get_PropertyNamingPolicy(){} // RVA: 0x37E080
        public void set_PropertyNamingPolicy(){} // RVA: 0x37E090
        public void get_ReadCommentHandling(){} // RVA: 0x1AF8C70
        public void set_ReadCommentHandling(){} // RVA: 0x1AF8C60
        public void get_UnknownTypeHandling(){} // RVA: 0x37E0C0
        public void set_UnknownTypeHandling(){} // RVA: 0x37E0D0
        public void get_UnmappedMemberHandling(){} // RVA: 0x1479960
        public void set_UnmappedMemberHandling(){} // RVA: 0x1D75D90
        public void get_WriteIndented(){} // RVA: 0x3978E0
        public void set_WriteIndented(){} // RVA: 0x3978F0
        public void get_GenerationMode(){} // RVA: 0xC5BE80
        public void set_GenerationMode(){} // RVA: 0xC5BE70
        public void get_UseStringEnumConverter(){} // RVA: 0x59FF30
        public void set_UseStringEnumConverter(){} // RVA: 0xC5F680
    }

    public class JsonStringEnumConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x372F7C0 | overloaded x2
        public void CanConvert(){} // RVA: 0x2E76B90
        public void CreateConverter(){} // RVA: 0x68C7250
    }

    public class JsonStringEnumConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2A620 | overloaded x2
        public void CanConvert(){} // RVA: 0xDE40
        public void CreateConverter(){} // RVA: 0x1E6A0
    }

    public class JsonUnmappedMemberHandlingAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_UnmappedMemberHandling(){} // RVA: 0x32A5C0
    }

    public class PreserveReferenceHandler
    {
        // ── Methods ──
        public void CreateResolver(){} // RVA: 0x6355B10 | overloaded x2
        public void .ctor(){} // RVA: 0x6355B70
    }

    public class PreserveReferenceResolver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6355BC0
        public void AddReference(){} // RVA: 0x6355DC0
        public void GetReference(){} // RVA: 0x6355ED0
        public void ResolveReference(){} // RVA: 0x6355FB0
    }

    public class ReadBufferState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x68C7780
        public void get_IsFinalBlock(){} // RVA: 0x5992B0
        public void get_Bytes(){} // RVA: 0x68C7900
        public void ReadFromStreamAsync(){} // RVA: 0x68C7A00
        public void ReadFromStream(){} // RVA: 0x68C7CC0
        public void AdvanceBuffer(){} // RVA: 0x68C7D40
        public void ProcessReadBytes(){} // RVA: 0x68C7F90
        public void Dispose(){} // RVA: 0x68C81B0
    }

    public class ReferenceEqualsWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x100A2F0
        public void Equals(){} // RVA: 0x3554450 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6353CA0
    }

    public class ReferenceHandler
    {
        // ── Methods ──
        public void get_Preserve(){} // RVA: 0x68C8790
        public void get_IgnoreCycles(){} // RVA: 0x68C87F0
        public void CreateResolver(){} // RVA: 0x391BC0 | overloaded x2
        public void .ctor(){} // RVA: 0x1AF9470
        public void .cctor(){} // RVA: 0x68C8850
    }

    public class ReferenceHandler`1
    {
        // ── Methods ──
        public void CreateResolver(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24A50
    }

    public class ReferenceResolver
    {
        // ── Methods ──
        public void AddReference(){} // RVA: 0x2DC60
        public void GetReference(){} // RVA: 0x1E6A0
        public void ResolveReference(){} // RVA: 0xCE10
        public void PopReferenceForCycleDetection(){} // RVA: 0x6356270
        public void PushReferenceForCycleDetection(){} // RVA: 0x63562B0
        public void ContainsReferenceForCycleDetection(){} // RVA: 0x63562F0
        public void .ctor(){} // RVA: 0x2DD310
    }

}