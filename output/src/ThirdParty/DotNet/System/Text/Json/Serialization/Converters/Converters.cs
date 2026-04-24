// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization.Converters
// Classes: 44
// Methods: 238

namespace ThirdParty.DotNet.System.Text.Json.Serialization.Converters
{
    public class ArrayConverter`2 : IEnumerableDefaultConverter`2
    {
        public object CanHaveIdMetadata;

        // ── Methods ──
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void ConvertCollection(){} // RVA: 0x7FFD4E099B30
        public void OnWriteResume(){} // RVA: 0x7FFD4E07D680
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class CastingConverter`1 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter KeyType;
        public bool ElementType;

        // ── Methods ──
        public void get_KeyType(){} // RVA: 0x7FFD4E078E90
        public void get_ElementType(){} // RVA: 0x7FFD4E078E90
        public void get_HandleNull(){} // RVA: 0x7FFD4E079D00
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_SourceConverterForCastingConverter(){} // RVA: 0x7FFD4E078E90
        public void Read(){} // RVA: 0x7FFD4E2ADC40
        public void Write(){} // RVA: 0x7FFD4E2ADC40
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFD4E2ADC40
        public void ReadAsPropertyName(){} // RVA: 0x7FFD4E2ADC40
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFD4E2ADC40
        public void WriteAsPropertyName(){} // RVA: 0x7FFD4E2ADC40
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFD4E2ADC40
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFD4E2ADC40
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ConcurrentQueueOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ConcurrentStackOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class DictionaryDefaultConverter`3 : JsonDictionaryConverter`3
    {
        public object CanHaveMetadata;

        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFD4E426850
        public void OnWriteResume(){} // RVA: 0x7FFD509A20A0
        public void .ctor(){} // RVA: 0x7FFD509A2080
    }

    public class DictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void CreateCollection(){} // RVA: 0x7FFD4E099B30
        public void OnWriteResume(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class EnumConverter`1 : JsonConverter`1
    {
        public 0x66421808 s_enumTypeCode;
        public bool s_isSignedEnum;
        public string ValueSeparator;
        public 0x6653AF28 _converterOptions;
        public 0x66534B20 _namingPolicy;
        public System.Collections.Concurrent.ConcurrentDictionary`2<ulong,System.Text.Json.JsonEncodedText> _nameCacheForWriting;
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,T> _nameCacheForReading;
        public int NameCacheSizeSoftLimit;

        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFD4E079F60
        public void .ctor(){} // RVA: 0x7FFD4E093960 | overloaded x2
        public void Read(){} // RVA: 0x7FFD4E2ADC40
        public void Write(){} // RVA: 0x7FFD4E2ADC40
        public void ConvertToUInt64(){} // RVA: 0x7FFD4E078F80
        public void IsValidIdentifier(){} // RVA: 0x7FFD4E079DE0
        public void FormatEnumValue(){} // RVA: 0x7FFD4E2ADC40
        public void FormatEnumValueToString(){} // RVA: 0x7FFD4E08A6F0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFD4E2ADC40
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class FSharpListConverter`2 : IEnumerableDefaultConverter`2
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<T>,U> _listConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void ConvertCollection(){} // RVA: 0x7FFD4E099B30
    }

    public class FSharpMapConverter`3 : DictionaryDefaultConverter`3
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<System.Tuple`2<V,T>>,U> CanHaveIdMetadata;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFD4E079D00
        public void CreateCollection(){} // RVA: 0x7FFD4E099B30
        public void ConvertCollection(){} // RVA: 0x7FFD4E099B30
    }

    public class FSharpOptionConverter`2 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<U> ConverterStrategy;
        public System.Func`2<U,U> ElementType;
        public System.Func`2<U,U> HandleNull;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x7FFD4E079D00
        public void get_ElementType(){} // RVA: 0x7FFD4E078E90
        public void get_HandleNull(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFD4E2ADC40
        public void Write(){} // RVA: 0x7FFD4E2ADC40
        public void Read(){} // RVA: 0x7FFD4E2ADC40
    }

    public class FSharpSetConverter`2 : IEnumerableDefaultConverter`2
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<U>,U> _setConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void ConvertCollection(){} // RVA: 0x7FFD4E099B30
    }

    public class FSharpValueOptionConverter`2 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<T> ConverterStrategy;
        public StructGetter`2<U,T> ElementType;
        public System.Func`2<T,U> HandleNull;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x7FFD4E079D00
        public void get_ElementType(){} // RVA: 0x7FFD4E078E90
        public void get_HandleNull(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFD4E2ADC40
        public void Write(){} // RVA: 0x7FFD4E2ADC40
        public void Read(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IAsyncEnumerableOfTConverter`2 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void OnTryRead(){}
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void OnTryWrite(){} // RVA: 0x7FFD4E2ADC40
        public void OnWriteResume(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ICollectionOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class IDictionaryConverter`1 : JsonDictionaryConverter`3
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E09B8C0
        public void CreateCollection(){} // RVA: 0x7FFD4E099B30
        public void OnWriteResume(){} // RVA: 0x7FFD4E2ADC40
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class IDictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void CreateCollection(){} // RVA: 0x7FFD4E099B30
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class IEnumerableConverter`1 : JsonCollectionConverter`2
    {
        public bool RuntimeType;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void OnWriteResume(){} // RVA: 0x7FFD4E2ADC40
        public void get_RuntimeType(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class IEnumerableDefaultConverter`2 : JsonCollectionConverter`2
    {
        public object CanHaveMetadata;

        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFD4E426850
        public void OnWriteResume(){} // RVA: 0x7FFD512782C0
        public void .ctor(){} // RVA: 0x7FFD51275DF0
    }

    public class IEnumerableOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public bool RuntimeType;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void get_RuntimeType(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class IListConverter`1 : JsonCollectionConverter`2
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void OnWriteResume(){} // RVA: 0x7FFD4E2ADC40
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class IListOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class IReadOnlyDictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        public bool RuntimeType;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void CreateCollection(){} // RVA: 0x7FFD4E099B30
        public void get_RuntimeType(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ISetOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFD4E079D00
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ImmutableDictionaryOfTKeyTValueConverterWithReflection`3 : ImmutableDictionaryOfTKeyTValueConverter`3
    {
        public object RequiresDynamicMemberAccessors;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFD4E079D00
        public void Initialize(){} // RVA: 0x7FFD4E099B30
    }

    public class ImmutableDictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        public object CanHaveIdMetadata;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD5127FC60
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFD4E341320
        public void CreateCollection(){} // RVA: 0x7FFD512AF840
        public void ConvertCollection(){} // RVA: 0x7FFD512AF900
        public void .ctor(){} // RVA: 0x7FFD5126A7B0
    }

    public class ImmutableEnumerableOfTConverterWithReflection`2 : ImmutableEnumerableOfTConverter`2
    {
        public object RequiresDynamicMemberAccessors;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFD4E079D00
        public void Initialize(){} // RVA: 0x7FFD4E099B30
    }

    public class ImmutableEnumerableOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public object CanHaveIdMetadata;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFD4E079D00
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void ConvertCollection(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class JsonMetadataServicesConverter`1 : JsonResumableConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<T> Converter;
        public bool ConverterStrategy;

        // ── Methods ──
        public void get_Converter(){} // RVA: 0x7FFD4E078E90
        public void get_ConverterStrategy(){} // RVA: 0x7FFD4E079D00
        public void get_KeyType(){} // RVA: 0x7FFD4E078E90
        public void get_ElementType(){} // RVA: 0x7FFD4E078E90
        public void get_ConstructorIsParameterized(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E096500
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFD4E2ADC40
    }

    public class JsonPrimitiveConverter`1 : JsonConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x7FFD513FC750
        public void ReadAsPropertyName(){} // RVA: 0x7FFD4E27B230
        public void .ctor(){} // RVA: 0x7FFD50C79110
    }

    public class KeyValuePairConverter`2 : SmallObjectWithParameterizedConstructorConverter`5
    {
        public string _keyName;
        public string _valueName;
        public System.Reflection.ConstructorInfo s_constructorInfo;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4E099B30
        public void TryLookupConstructorParameter(){} // RVA: 0x7FFD4E07D680
        public void EndRead(){} // RVA: 0x7FFD4E090A40
        public void FoundKeyProperty(){}
        public void FoundValueProperty(){}
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class LargeObjectWithParameterizedConstructorConverterWithReflection`1 : LargeObjectWithParameterizedConstructorConverter`1
    {
        public object RequiresDynamicMemberAccessors;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFD4E079D00
        public void Initialize(){} // RVA: 0x7FFD4E099B30
    }

    public class LargeObjectWithParameterizedConstructorConverter`1 : ObjectWithParameterizedConstructorConverter`1
    {
        // ── Methods ──
        public void ReadAndCacheConstructorArgument(){} // RVA: 0x7FFD515228D0
        public void CreateObject(){} // RVA: 0x7FFD51522AD0
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x7FFD51522D20
        public void .ctor(){} // RVA: 0x7FFD51522FB0
    }

    public class ListOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void OnWriteResume(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class MemoryConverter`1 : JsonCollectionConverter`2
    {
        public object CanHaveMetadata;
        public object HandleNull;

        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFD4E079D00
        public void get_HandleNull(){} // RVA: 0x7FFD4E079D00
        public void OnTryRead(){}
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void ConvertCollection(){} // RVA: 0x7FFD4E099B30
        public void OnWriteResume(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class NullableConverter`1 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<T> _elementConverter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Read(){} // RVA: 0x7FFD4E2ADC40
        public void Write(){} // RVA: 0x7FFD4E2ADC40
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFD4E2ADC40
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ObjectDefaultConverter`1 : JsonObjectConverter`1
    {
        public object CanHaveIdMetadata;

        // ── Methods ──
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFD4E079D00
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFD4E2ADC40
        public void ReadPropertyValue(){}
        public void ReadAheadPropertyValue(){} // RVA: 0x7FFD4E07D5A0
        public void CreateInstanceForReferenceResolver(){} // RVA: 0x7FFD4E09AF60
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ObjectWithParameterizedConstructorConverter`1 : ObjectDefaultConverter`1
    {
        public object ConstructorIsParameterized;

        // ── Methods ──
        public void get_ConstructorIsParameterized(){} // RVA: 0x7FFD4E079D00
        public void OnTryRead(){}
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x7FFD4E099B30
        public void ReadAndCacheConstructorArgument(){}
        public void CreateObject(){} // RVA: 0x7FFD4E078F40
        public void ReadConstructorArguments(){} // RVA: 0x7FFD4E09AF60
        public void ReadConstructorArgumentsWithContinuation(){}
        public void HandleConstructorArgumentWithContinuation(){}
        public void HandlePropertyWithContinuation(){}
        public void BeginRead(){} // RVA: 0x7FFD4E09AF60
        public void EndRead(){} // RVA: 0x7FFD4E090A40
        public void TryLookupConstructorParameter(){} // RVA: 0x7FFD4E07D680
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class QueueOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class ReadOnlyMemoryConverter`1 : JsonCollectionConverter`2
    {
        public object CanHaveMetadata;
        public object HandleNull;

        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFD4E079D00
        public void get_HandleNull(){} // RVA: 0x7FFD4E079D00
        public void OnTryRead(){}
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void ConvertCollection(){} // RVA: 0x7FFD4E099B30
        public void OnWriteResume(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class SmallObjectWithParameterizedConstructorConverter`5 : ObjectWithParameterizedConstructorConverter`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFD4E078F40
        public void ReadAndCacheConstructorArgument(){}
        public void TryRead(){} // RVA: 0x7FFD4E07D680
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class StackOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E099B30
        public void CreateCollection(){} // RVA: 0x7FFD4E09AF60
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class StackOrQueueConverterWithReflection`1 : StackOrQueueConverter`1
    {
        public object RequiresDynamicMemberAccessors;

        // ── Methods ──
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Initialize(){} // RVA: 0x7FFD4E099B30
    }

    public class StackOrQueueConverter`1 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD51DB7E70
        public void CreateCollection(){} // RVA: 0x7FFD51DB80B0
        public void OnWriteResume(){} // RVA: 0x7FFD51DB8170
        public void .ctor(){} // RVA: 0x7FFD51DB8520
    }

    public class UnsupportedTypeConverter`1 : JsonConverter`1
    {
        public string _errorMessage;

        // ── Methods ──
        public void Read(){} // RVA: 0x7FFD4E2ADC40
        public void Write(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

}