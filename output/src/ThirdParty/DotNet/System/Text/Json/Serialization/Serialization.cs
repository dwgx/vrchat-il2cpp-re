// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization
// Classes: 13
// Methods: 181

namespace ThirdParty.DotNet.System.Text.Json.Serialization
{
    public class ConfigurationList`1 : Object
    {
        public URA.woDigitYearMax<T1717649488> IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void OnCollectionModifying(){} // RVA: 0x7FFD4E090980
        public void ValidateAddedValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.Generic.IEnumerable<TItem>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void get_DebuggerDisplay(){} // RVA: 0x7FFD4E078E90
    }

    public class JsonCollectionConverter`2 : JsonResumableConverter`1
    {
        public object SupportsCreateObjectDelegate;
        public object ElementType;

        // ── Methods ──
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFD4E426850
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFD51361FE0
        public void get_ElementType(){} // RVA: 0x7FFD51365900
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD513637F0
        public void ConvertCollection(){} // RVA: 0x7FFD4E341310
        public void GetElementConverter(){} // RVA: 0x7FFD51363A80 | overloaded x2
        public void OnTryRead(){} // RVA: 0x7FFD51365AE0
        public void OnTryWrite(){} // RVA: 0x7FFD51366840
        public void OnWriteResume(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD51366DC0
    }

    public class JsonConverter : Object
    {
        public bool Type; // 0x10
        public bool ConverterStrategy; // 0x11
        public bool SupportsCreateObjectDelegate; // 0x12
        public bool CanPopulate; // 0x13
        public bool CanUseDirectReadOrWrite; // 0x14
        public bool CanHaveMetadata; // 0x15
        public m.nformation CanBePolymorphic; // 0x18
        public bool RequiresReadAhead; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5447CE90
        public void get_Type(){} // RVA: 0x7FFD4E078E90
        public void CanConvert(){} // RVA: 0x7FFD4E079F60
        public void get_ConverterStrategy(){} // RVA: 0x7FFD4E40B5E0
        public void set_ConverterStrategy(){} // RVA: 0x7FFD5447D030
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFD4E079D00
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFD4E341320
        public void get_CanPopulate(){} // RVA: 0x7FFD4E341320
        public void get_CanUseDirectReadOrWrite(){} // RVA: 0x7FFD4EB91DA0
        public void set_CanUseDirectReadOrWrite(){} // RVA: 0x7FFD4EB91D90
        public void get_CanHaveMetadata(){} // RVA: 0x7FFD4E341320
        public void get_CanBePolymorphic(){} // RVA: 0x7FFD4EF01A90
        public void set_CanBePolymorphic(){} // RVA: 0x7FFD4F831DE0
        public void get_RequiresReadAhead(){} // RVA: 0x7FFD4F831E00
        public void set_RequiresReadAhead(){} // RVA: 0x7FFD4F831E10
        public void ReadElementAndSetProperty(){} // RVA: 0x7FFD5447D070
        public void CreateJsonTypeInfo(){} // RVA: 0x7FFD5447D0B0
        public void CreateCastingConverter(){} // RVA: 0x7FFD4E078E90
        public void get_UsesDefaultHandleNull(){} // RVA: 0x7FFD4E490BD0
        public void set_UsesDefaultHandleNull(){} // RVA: 0x7FFD4E490BE0
        public void get_HandleNullOnRead(){} // RVA: 0x7FFD4E555090
        public void set_HandleNullOnRead(){} // RVA: 0x7FFD4F831DF0
        public void get_HandleNullOnWrite(){} // RVA: 0x7FFD4F831E30
        public void set_HandleNullOnWrite(){} // RVA: 0x7FFD4F831E20
        public void get_SourceConverterForCastingConverter(){} // RVA: 0x7FFD4E919180
        public void get_ElementType(){} // RVA: 0x7FFD4E078E90
        public void get_KeyType(){} // RVA: 0x7FFD4E078E90
        public void get_IsValueType(){} // RVA: 0x7FFD53DD7390
        public void set_IsValueType(){} // RVA: 0x7FFD53DD73A0
        public void get_IsInternalConverter(){} // RVA: 0x7FFD4E35C4E0
        public void set_IsInternalConverter(){} // RVA: 0x7FFD4E35C4F0
        public void get_IsInternalConverterForNumberType(){} // RVA: 0x7FFD4E648D50
        public void set_IsInternalConverterForNumberType(){} // RVA: 0x7FFD4E935120
        public void ShouldFlush(){} // RVA: 0x7FFD5447D0F0
        public void ReadAsObject(){} // RVA: 0x7FFD4E08AE80
        public void OnTryReadAsObject(){}
        public void TryReadAsObject(){}
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x7FFD4E08AE80
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x7FFD4E08AE80
        public void ReadNumberWithCustomHandlingAsObject(){}
        public void WriteAsObject(){} // RVA: 0x7FFD4E09AF60
        public void OnTryWriteAsObject(){} // RVA: 0x7FFD4E07D680
        public void TryWriteAsObject(){} // RVA: 0x7FFD4E07D680
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x7FFD4E09AF60
        public void WriteAsPropertyNameCoreAsObject(){}
        public void WriteNumberWithCustomHandlingAsObject(){}
        public void get_ConstructorIsParameterized(){} // RVA: 0x7FFD4FA1A190
        public void get_ConstructorInfo(){} // RVA: 0x7FFD4E36F0C0
        public void set_ConstructorInfo(){} // RVA: 0x7FFD4E36F0D0
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFD4E341310
        public void ConfigureJsonTypeInfoUsingReflection(){} // RVA: 0x7FFD4E341310
        public void ResolvePolymorphicConverter(){} // RVA: 0x7FFD5447D3A0 | overloaded x2
        public void TryHandleSerializedObjectReference(){} // RVA: 0x7FFD5447D600
        public void SingleValueReadWithReadAhead(){} // RVA: 0x7FFD5447D740
        public void DoSingleValueReadWithReadAhead(){} // RVA: 0x7FFD5447D770
    }

    public class JsonConverterFactory : JsonConverter
    {
        public object KeyType;
        public object ElementType;
        public object Type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD513F87A0
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFD4E341320
        public void CreateConverter(){} // RVA: 0x7FFD4E08A6F0
        public void get_KeyType(){} // RVA: 0x7FFD4E919180
        public void get_ElementType(){} // RVA: 0x7FFD4E919180
        public void GetConverterInternal(){} // RVA: 0x7FFD5447D930
        public void ReadAsObject(){} // RVA: 0x7FFD5447DA00
        public void OnTryReadAsObject(){} // RVA: 0x7FFD5447DA40
        public void TryReadAsObject(){} // RVA: 0x7FFD5447DA80
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x7FFD5447DAC0
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x7FFD5447DB00
        public void ReadNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFD5447DB40
        public void WriteAsObject(){} // RVA: 0x7FFD5447DB80
        public void OnTryWriteAsObject(){} // RVA: 0x7FFD5447DBC0
        public void TryWriteAsObject(){} // RVA: 0x7FFD5447DC00
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x7FFD5447DC40
        public void get_Type(){} // RVA: 0x7FFD4E919180
        public void WriteAsPropertyNameCoreAsObject(){} // RVA: 0x7FFD5447DC80
        public void WriteNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFD5447DCC0
    }

    public class JsonConverter`1 : JsonConverter
    {
        public object KeyType; // 0x28
        public ngCommas.get_transformPoleAxis<T1717653520> ElementType; // 0x30

        // ── Methods ──
        public void ReadCore(){} // RVA: 0x7FFD4E27B230
        public void WriteCore(){} // RVA: 0x7FFD513E55D0
        public void .ctor(){} // RVA: 0x7FFD513E5880
        public void CanConvert(){} // RVA: 0x7FFD513E5B20
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFD513681B0
        public void CreateJsonTypeInfo(){} // RVA: 0x7FFD513E5BF0
        public void get_KeyType(){} // RVA: 0x7FFD4E919180
        public void get_ElementType(){} // RVA: 0x7FFD4E919180
        public void get_HandleNull(){} // RVA: 0x7FFD5136A9B0
        public void WriteAsObject(){} // RVA: 0x7FFD513E5C70
        public void OnTryWriteAsObject(){} // RVA: 0x7FFD513E5E30
        public void WriteAsPropertyNameAsObject(){} // RVA: 0x7FFD513E6000
        public void WriteAsPropertyNameCoreAsObject(){} // RVA: 0x7FFD513E61C0
        public void WriteNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFD513E6390
        public void TryWriteAsObject(){} // RVA: 0x7FFD513E6560
        public void OnTryWrite(){} // RVA: 0x7FFD513E66D0
        public void OnTryRead(){} // RVA: 0x7FFD513E67D0
        public void Read(){} // RVA: 0x7FFD4E27B230
        public void TryRead(){} // RVA: 0x7FFD513E68E0
        public void OnTryReadAsObject(){} // RVA: 0x7FFD513E6D60
        public void TryReadAsObject(){} // RVA: 0x7FFD513E6EC0
        public void ReadAsObject(){} // RVA: 0x7FFD513E7040
        public void ReadAsPropertyNameAsObject(){} // RVA: 0x7FFD513E7180
        public void ReadAsPropertyNameCoreAsObject(){} // RVA: 0x7FFD513E72C0
        public void ReadNumberWithCustomHandlingAsObject(){} // RVA: 0x7FFD513E7400
        public void IsNull(){} // RVA: 0x7FFD513E3560
        public void TryWrite(){} // RVA: 0x7FFD513E7550
        public void TryWriteDataExtensionProperty(){} // RVA: 0x7FFD513E7AF0
        public void get_Type(){} // RVA: 0x7FFD4E36F130
        public void VerifyRead(){} // RVA: 0x7FFD5136C090
        public void VerifyWrite(){} // RVA: 0x7FFD5136C150
        public void Write(){} // RVA: 0x7FFD4E2ADC40
        public void ReadAsPropertyName(){} // RVA: 0x7FFD4E27B230
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFD4E27B230
        public void WriteAsPropertyName(){} // RVA: 0x7FFD513E80F0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFD513E8270
        public void GetFallbackConverterForPropertyNameSerialization(){} // RVA: 0x7FFD513E84D0
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFD4E27B230
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFD51369CB0
    }

    public class JsonDictionaryConverter`1 : JsonResumableConverter`1
    {
        public object SupportsCreateObjectDelegate;

        // ── Methods ──
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFD4E426850
        public void GetDefaultConverterStrategy(){} // RVA: 0x7FFD513EAC60
        public void OnWriteResume(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD50C27970
    }

    public class JsonDictionaryConverter`3 : JsonDictionaryConverter`1
    {
        public ngCommas.get_transformPoleAxis<T1717652048> ElementType; // 0x38
        public ngCommas.get_transformPoleAxis<T1717652064> KeyType; // 0x40

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E09B8C0
        public void ConvertCollection(){} // RVA: 0x7FFD4E341310
        public void CreateCollection(){} // RVA: 0x7FFD513637F0
        public void get_ElementType(){} // RVA: 0x7FFD513F0450
        public void get_KeyType(){} // RVA: 0x7FFD513F0500
        public void GetConverter(){} // RVA: 0x7FFD4E078F80
        public void OnTryRead(){} // RVA: 0x7FFD513F05B0
        public void OnTryWrite(){} // RVA: 0x7FFD513F1A70
        public void .ctor(){} // RVA: 0x7FFD513F0000
        public void <OnTryRead>g__ReadDictionaryKey|10_0(){} // RVA: 0x7FFD4E08B1A0
    }

    public class JsonNumberEnumConverter`1 : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFD4E079F60
        public void CreateConverter(){} // RVA: 0x7FFD4E08A6F0
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class JsonObjectConverter`1 : JsonResumableConverter`1
    {
        public object ConverterStrategy;
        public object ElementType;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x7FFD4E079D00
        public void get_ElementType(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class JsonResumableConverter`1 : JsonConverter`1
    {
        public object HandleNull;

        // ── Methods ──
        public void get_HandleNull(){} // RVA: 0x7FFD4E341320
        public void Read(){} // RVA: 0x7FFD4E27B230
        public void Write(){} // RVA: 0x7FFD5147C6F0
        public void .ctor(){} // RVA: 0x7FFD5088A1E0
    }

    public class JsonStringEnumConverter`1 : JsonConverterFactory
    {
        public inDataView.gCommaNotAllowedBeforeObjectEnd _namingPolicy;
        public bleInterface.zation _converterOptions;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E096500 | overloaded x2
        public void CanConvert(){} // RVA: 0x7FFD4E079F60
        public void CreateConverter(){} // RVA: 0x7FFD4E08A6F0
    }

    public class ReferenceHandler : Object
    {
        public ngCommas._SerializerOptionsReadOnly Preserve; // 0x10
        public ngCommas.hrowInvalidOperationException_JsonPropertyRequiredAndExtensionData IgnoreCycles;
        public ngCommas.hrowInvalidOperationException_JsonPropertyRequiredAndExtensionData <IgnoreCycles>k__BackingField; // 0x8

        // ── Methods ──
        public void get_Preserve(){} // RVA: 0x7FFD5447F2B0
        public void get_IgnoreCycles(){} // RVA: 0x7FFD5447F310
        public void CreateResolver(){} // RVA: 0x7FFD4E3F5BC0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4F9D41D0
        public void .cctor(){} // RVA: 0x7FFD5447F370
    }

    public class ReferenceHandler`1 : ReferenceHandler
    {
        // ── Methods ──
        public void CreateResolver(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

}