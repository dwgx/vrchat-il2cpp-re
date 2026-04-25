// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization.Converters
// Classes: 85
// Methods: 436

namespace ThirdParty.DotNet.System.Text.Json.Serialization.Converters
{
    public class ArrayConverter`2 : IEnumerableDefaultConverter`2
    {
        public object CanHaveIdMetadata;

        // ── Methods ──
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFAC2C59D00
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void ConvertCollection(){} // RVA: 0x7FFAC2C79B30
        public void OnWriteResume(){} // RVA: 0x7FFAC2C5D680
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class BooleanConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFBB10
        public void Write(){} // RVA: 0x7FFAC8AFBB20
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFBB50
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFBC80
        public void .ctor(){} // RVA: 0x7FFAC8AFBCB0
    }

    public class ByteArrayConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFBCF0
        public void Write(){} // RVA: 0x7FFAC8AFBD60
        public void .ctor(){} // RVA: 0x7FFAC8AFBEF0
    }

    public class ByteConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFBF30
        public void Read(){} // RVA: 0x7FFAC8AFBF80
        public void Write(){} // RVA: 0x7FFAC8AFBFE0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFC040
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFC050
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFC080
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFC100
    }

    public class CastingConverter`1 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter KeyType;
        public bool ElementType;

        // ── Methods ──
        public void get_KeyType(){} // RVA: 0x7FFAC2C58E90
        public void get_ElementType(){} // RVA: 0x7FFAC2C58E90
        public void get_HandleNull(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_SourceConverterForCastingConverter(){} // RVA: 0x7FFAC2C58E90
        public void Read(){} // RVA: 0x7FFAC2E8DC40
        public void Write(){} // RVA: 0x7FFAC2E8DC40
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFAC2E8DC40
        public void ReadAsPropertyName(){} // RVA: 0x7FFAC2E8DC40
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC2E8DC40
        public void WriteAsPropertyName(){} // RVA: 0x7FFAC2E8DC40
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC2E8DC40
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC2E8DC40
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC2E8DC40
    }

    public class CharConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFC180
        public void Write(){} // RVA: 0x7FFAC8AFC1F0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFC310
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFC330
        public void .ctor(){} // RVA: 0x7FFAC8AFC450
    }

    public class ConcurrentQueueOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ConcurrentStackOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class DateTimeConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFC490
        public void Write(){} // RVA: 0x7FFAC8AFC4A0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFC500
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFC560
        public void .ctor(){} // RVA: 0x7FFAC8AFC590
    }

    public class DateTimeOffsetConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFC5D0
        public void Write(){} // RVA: 0x7FFAC8AFC670
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFC6E0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFC740
        public void .ctor(){} // RVA: 0x7FFAC8AFC770
    }

    public class DecimalConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFC7B0
        public void Read(){} // RVA: 0x7FFAC8AFC800
        public void Write(){} // RVA: 0x7FFAC8AFC860
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFC890
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFC9B0
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFC9E0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFCB60
    }

    public class DefaultObjectConverter : ObjectConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9078880
        public void Read(){} // RVA: 0x7FFAC90788D0
        public void OnTryRead(){} // RVA: 0x7FFAC90789A0
    }

    public class DictionaryDefaultConverter`3 : JsonDictionaryConverter`3
    {
        public object CanHaveMetadata;

        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFAC3006850
        public void OnWriteResume(){} // RVA: 0x7FFAC55820A0
        public void .ctor(){} // RVA: 0x7FFAC5582080
    }

    public class DictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void CreateCollection(){} // RVA: 0x7FFAC2C79B30
        public void OnWriteResume(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class DoubleConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFCBB0
        public void Read(){} // RVA: 0x7FFAC8AFCC00
        public void Write(){} // RVA: 0x7FFAC8AFCC60
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFCC90
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFCCA0
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFCCD0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFCD60
    }

    public class EnumConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CanConvert(){} // RVA: 0x7FFAC58091F0
        public void CreateConverter(){} // RVA: 0x7FFAC8AFCDB0
        public void Create(){} // RVA: 0x7FFAC8AFCDC0
        public void GetEnumConverterType(){} // RVA: 0x7FFAC8AFD090
    }

    public class EnumConverter`1 : JsonConverter`1
    {
        public 0x6B0C1808 s_enumTypeCode;
        public string s_negativeSign;
        public 0x6B2212E0 _converterOptions;
        public System.Text.Json.JsonNamingPolicy _namingPolicy;
        public System.Collections.Concurrent.ConcurrentDictionary`2<ulong,System.Text.Json.JsonEncodedText> _nameCache;
        public System.Collections.Concurrent.ConcurrentDictionary`2<ulong,System.Text.Json.JsonEncodedText> _dictionaryKeyPolicyCache;

        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFAC2C59F60
        public void .ctor(){} // RVA: 0x7FFAC2C73960 | overloaded x2
        public void Read(){} // RVA: 0x7FFAC2E8DC40
        public void Write(){} // RVA: 0x7FFAC2E8DC40
        public void ConvertToUInt64(){} // RVA: 0x7FFAC2C58F80
        public void IsValidIdentifier(){} // RVA: 0x7FFAC2C59DE0
        public void FormatEnumValue(){} // RVA: 0x7FFAC2E8DC40
        public void FormatEnumValueToString(){} // RVA: 0x7FFAC2C6A6F0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC2E8DC40
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class FSharpListConverter`2 : IEnumerableDefaultConverter`2
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<T>,U> _listConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void ConvertCollection(){} // RVA: 0x7FFAC2C79B30
    }

    public class FSharpMapConverter`3 : DictionaryDefaultConverter`3
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<System.Tuple`2<V,T>>,U> CanHaveIdMetadata;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFAC2C59D00
        public void CreateCollection(){} // RVA: 0x7FFAC2C79B30
        public void ConvertCollection(){} // RVA: 0x7FFAC2C79B30
    }

    public class FSharpOptionConverter`2 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<U> ConverterStrategy;
        public System.Func`2<U,U> ElementType;
        public System.Func`2<U,U> HandleNull;
        public 0x6B21DAD8 _converterStrategy;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x7FFAC2C59D00
        public void get_ElementType(){} // RVA: 0x7FFAC2C58E90
        public void get_HandleNull(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFAC2E8DC40
        public void Write(){} // RVA: 0x7FFAC2E8DC40
        public void Read(){} // RVA: 0x7FFAC2E8DC40
    }

    public class FSharpSetConverter`2 : IEnumerableDefaultConverter`2
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<U>,U> _setConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void ConvertCollection(){} // RVA: 0x7FFAC2C79B30
    }

    public class FSharpTypeConverterFactory : JsonConverterFactory
    {
        public System.Text.Json.Serialization.Converters.ObjectConverterFactory _recordConverterFactory; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CanConvert(){} // RVA: 0x7FFAC8AF9480
        public void CreateConverter(){} // RVA: 0x7FFAC8AF95B0
    }

    public class FSharpValueOptionConverter`2 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<T> ConverterStrategy;
        public StructGetter`2<U,T> ElementType;
        public System.Func`2<T,U> HandleNull;
        public 0x6B21DAD8 _converterStrategy;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x7FFAC2C59D00
        public void get_ElementType(){} // RVA: 0x7FFAC2C58E90
        public void get_HandleNull(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFAC2E8DC40
        public void Write(){} // RVA: 0x7FFAC2E8DC40
        public void Read(){} // RVA: 0x7FFAC2E8DC40
    }

    public class GuidConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFD1E0
        public void Write(){} // RVA: 0x7FFAC8AFD280
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFD2F0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFD350
        public void .ctor(){} // RVA: 0x7FFAC8AFD380
    }

    public class IAsyncEnumerableOfTConverter`2 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void OnTryRead(){}
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void OnTryWrite(){} // RVA: 0x7FFAC2E8DC40
        public void OnWriteResume(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ICollectionOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFAC2C59D00
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class IDictionaryConverter`1 : JsonDictionaryConverter`3
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFAC2C59D00
        public void Add(){} // RVA: 0x7FFAC2C7B8C0
        public void CreateCollection(){} // RVA: 0x7FFAC2C79B30
        public void OnWriteResume(){} // RVA: 0x7FFAC2E8DC40
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class IDictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFAC2C59D00
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void CreateCollection(){} // RVA: 0x7FFAC2C79B30
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class IEnumerableConverterFactory : JsonConverterFactory
    {
        public System.Text.Json.Serialization.Converters.IDictionaryConverter`1<System.Collections.IDictionary> s_converterForIDictionary;
        public System.Text.Json.Serialization.Converters.IEnumerableConverter`1<System.Collections.IEnumerable> s_converterForIEnumerable; // 0x8
        public System.Text.Json.Serialization.Converters.IListConverter`1<System.Collections.IList> s_converterForIList; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CanConvert(){} // RVA: 0x7FFAC8AF81C0
        public void CreateConverter(){} // RVA: 0x7FFAC8AF82A0
        public void .cctor(){} // RVA: 0x7FFAC8AF9190
    }

    public class IEnumerableConverter`1 : JsonCollectionConverter`2
    {
        public object RuntimeType;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void OnWriteResume(){} // RVA: 0x7FFAC2E8DC40
        public void get_RuntimeType(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class IEnumerableDefaultConverter`2 : JsonCollectionConverter`2
    {
        public object CanHaveMetadata;

        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFAC3006850
        public void OnWriteResume(){} // RVA: 0x7FFAC5E582C0
        public void .ctor(){} // RVA: 0x7FFAC5E55DF0
    }

    public class IEnumerableOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public object RuntimeType;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void get_RuntimeType(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class IListConverter`1 : JsonCollectionConverter`2
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFAC2C59D00
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void OnWriteResume(){} // RVA: 0x7FFAC2E8DC40
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class IListOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFAC2C59D00
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class IReadOnlyDictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        public object RuntimeType;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void CreateCollection(){} // RVA: 0x7FFAC2C79B30
        public void get_RuntimeType(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ISetOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public object CanPopulate;

        // ── Methods ──
        public void get_CanPopulate(){} // RVA: 0x7FFAC2C59D00
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void ConfigureJsonTypeInfo(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ImmutableDictionaryOfTKeyTValueConverterWithReflection`3 : ImmutableDictionaryOfTKeyTValueConverter`3
    {
        public object RequiresDynamicMemberAccessors;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFAC2C59D00
        public void Initialize(){} // RVA: 0x7FFAC2C79B30
    }

    public class ImmutableDictionaryOfTKeyTValueConverter`3 : DictionaryDefaultConverter`3
    {
        public object CanHaveIdMetadata;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC5E5FC60
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFAC2F21320
        public void CreateCollection(){} // RVA: 0x7FFAC5E8F840
        public void ConvertCollection(){} // RVA: 0x7FFAC5E8F900
        public void .ctor(){} // RVA: 0x7FFAC5E4A7B0
    }

    public class ImmutableEnumerableOfTConverterWithReflection`2 : ImmutableEnumerableOfTConverter`2
    {
        public object RequiresDynamicMemberAccessors;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFAC2C59D00
        public void Initialize(){} // RVA: 0x7FFAC2C79B30
    }

    public class ImmutableEnumerableOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        public object CanHaveIdMetadata;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFAC2C59D00
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void ConvertCollection(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class Int16Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFD3C0
        public void Read(){} // RVA: 0x7FFAC8AFD410
        public void Write(){} // RVA: 0x7FFAC8AFD470
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFD4D0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFD4E0
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFD510
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFD590
    }

    public class Int32Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFD610
        public void Read(){} // RVA: 0x7FFAC8AFD660
        public void Write(){} // RVA: 0x7FFAC8AFD6C0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFD720
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFD730
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFD760
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFD7E0
    }

    public class Int64Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFD860
        public void Read(){} // RVA: 0x7FFAC8AFD8B0
        public void Write(){} // RVA: 0x7FFAC8AFD910
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFD970
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFD980
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFD9B0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFDA30
    }

    public class JsonArrayConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAC8AF9EE0
        public void Read(){} // RVA: 0x7FFAC8AF9F20
        public void ReadList(){} // RVA: 0x7FFAC8AFA020
        public void .ctor(){} // RVA: 0x7FFAC8AFA0B0
    }

    public class JsonDocumentConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFDAB0
        public void Write(){} // RVA: 0x7FFAC8AFDAF0
        public void .ctor(){} // RVA: 0x7FFAC8AFDC10
    }

    public class JsonElementConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFDC50
        public void Write(){} // RVA: 0x7FFAC8AFDC80
        public void .ctor(){} // RVA: 0x7FFAC8AFDD30
    }

    public class JsonMetadataServicesConverter`1 : JsonResumableConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<T>> Converter;
        public 0x6B21DAD8 ConverterStrategy;
        public System.Text.Json.Serialization.JsonConverter`1<T> KeyType;

        // ── Methods ──
        public void get_Converter(){} // RVA: 0x7FFAC2C58E90
        public void get_ConverterStrategy(){} // RVA: 0x7FFAC2C59D00
        public void get_KeyType(){} // RVA: 0x7FFAC2C58E90
        public void get_ElementType(){} // RVA: 0x7FFAC2C58E90
        public void get_ConstructorIsParameterized(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C76500
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFAC2E8DC40
    }

    public class JsonNodeConverter : JsonConverter`1
    {
        public System.Text.Json.Serialization.Converters.JsonNodeConverter Instance;
        public System.Text.Json.Serialization.Converters.JsonArrayConverter ArrayConverter; // 0x8
        public System.Text.Json.Serialization.Converters.JsonObjectConverter ObjectConverter; // 0x10
        public System.Text.Json.Serialization.Converters.JsonValueConverter ValueConverter; // 0x18

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8AFA0F0
        public void get_ArrayConverter(){} // RVA: 0x7FFAC8AFA1E0
        public void get_ObjectConverter(){} // RVA: 0x7FFAC8AFA2F0
        public void get_ValueConverter(){} // RVA: 0x7FFAC8AFA400
        public void Write(){} // RVA: 0x7FFAC8AFA510
        public void Read(){} // RVA: 0x7FFAC8AFA6A0
        public void Create(){} // RVA: 0x7FFAC8AFA7A0
        public void .ctor(){} // RVA: 0x7FFAC8AFA910
    }

    public class JsonNodeConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void CreateConverter(){} // RVA: 0x7FFAC8AFA950
        public void CanConvert(){} // RVA: 0x7FFAC8AFAAF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JsonObjectConverter : JsonConverter`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFAC8AFABF0
        public void ReadElementAndSetProperty(){} // RVA: 0x7FFAC8AFAC70
        public void Write(){} // RVA: 0x7FFAC8AF9EE0
        public void Read(){} // RVA: 0x7FFAC8AFAF60
        public void ReadObject(){} // RVA: 0x7FFAC8AFB060
        public void .ctor(){} // RVA: 0x7FFAC8AFB0F0
    }

    public class JsonPrimitiveConverter`1 : JsonConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x7FFAC5FDC750
        public void ReadAsPropertyName(){} // RVA: 0x7FFAC2E5B230
        public void .ctor(){} // RVA: 0x7FFAC5859110
    }

    public class JsonValueConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAC8AF9EE0
        public void Read(){} // RVA: 0x7FFAC8AFB130
        public void .ctor(){} // RVA: 0x7FFAC8AFB200
    }

    public class KeyValuePairConverter`2 : SmallObjectWithParameterizedConstructorConverter`5
    {
        public string _keyName;
        public string _valueName;
        public System.Reflection.ConstructorInfo s_constructorInfo;

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC2C79B30
        public void TryLookupConstructorParameter(){} // RVA: 0x7FFAC2C5D680
        public void EndRead(){} // RVA: 0x7FFAC2C70A40
        public void FoundKeyProperty(){}
        public void FoundValueProperty(){}
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class LargeJsonObjectExtensionDataSerializationState : Object
    {
        public System.Collections.Generic.Dictionary`2<string,System.Text.Json.Nodes.JsonNode> Destination; // 0x10
        public System.Text.Json.Nodes.JsonObject <Destination>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Destination(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC8AF7D60
        public void AddProperty(){} // RVA: 0x7FFAC8AF7F60
        public void Complete(){} // RVA: 0x7FFAC8AF7FF0
    }

    public class LargeObjectWithParameterizedConstructorConverterWithReflection`1 : LargeObjectWithParameterizedConstructorConverter`1
    {
        public object RequiresDynamicMemberAccessors;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFAC2C59D00
        public void Initialize(){} // RVA: 0x7FFAC2C79B30
    }

    public class LargeObjectWithParameterizedConstructorConverter`1 : ObjectWithParameterizedConstructorConverter`1
    {
        // ── Methods ──
        public void ReadAndCacheConstructorArgument(){} // RVA: 0x7FFAC61028D0
        public void CreateObject(){} // RVA: 0x7FFAC6102AD0
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x7FFAC6102D20
        public void .ctor(){} // RVA: 0x7FFAC6102FB0
    }

    public class ListOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void OnWriteResume(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class MemoryByteConverter : JsonConverter`1
    {
        public object HandleNull;

        // ── Methods ──
        public void get_HandleNull(){} // RVA: 0x7FFAC3006850
        public void Read(){} // RVA: 0x7FFAC90751B0
        public void Write(){} // RVA: 0x7FFAC90752D0
        public void .ctor(){} // RVA: 0x7FFAC90753D0
    }

    public class MemoryConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFAC9074C00
        public void CreateConverter(){} // RVA: 0x7FFAC9074D30
        public void .ctor(){} // RVA: 0x7FFAC5FD87A0
    }

    public class MemoryConverter`1 : JsonCollectionConverter`2
    {
        public object CanHaveMetadata;
        public object HandleNull;

        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFAC2C59D00
        public void get_HandleNull(){} // RVA: 0x7FFAC2C59D00
        public void OnTryRead(){}
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void ConvertCollection(){} // RVA: 0x7FFAC2C79B30
        public void OnWriteResume(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class NullableConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFAC8AFDD70
        public void CreateConverter(){} // RVA: 0x7FFAC8AFDDC0
        public void CreateValueConverter(){} // RVA: 0x7FFAC8AFDEB0
        public void GetNullableConverterType(){} // RVA: 0x7FFAC8AFE110
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NullableConverter`1 : JsonConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<T> _converter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Read(){} // RVA: 0x7FFAC2E8DC40
        public void Write(){} // RVA: 0x7FFAC2E8DC40
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC2E8DC40
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC2E8DC40
    }

    public class ObjectConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFE260
        public void Write(){} // RVA: 0x7FFAC8AFE330
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFE370
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFE3A0
        public void .ctor(){} // RVA: 0x7FFAC8AFE460
    }

    public class ObjectConverterFactory : JsonConverterFactory
    {
        public bool _useDefaultConstructorInUnannotatedStructs; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3C24F40
        public void CanConvert(){} // RVA: 0x7FFAC3006850
        public void CreateConverter(){} // RVA: 0x7FFAC8AFB240
        public void CreateKeyValuePairConverter(){} // RVA: 0x7FFAC8AFB860
    }

    public class ObjectDefaultConverter`1 : JsonObjectConverter`1
    {
        public object CanHaveIdMetadata;

        // ── Methods ──
        public void get_CanHaveIdMetadata(){} // RVA: 0x7FFAC2C59D00
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x7FFAC2E8DC40
        public void ReadPropertyValue(){}
        public void ReadAheadPropertyValue(){} // RVA: 0x7FFAC2C5D5A0
        public void CreateInstanceForReferenceResolver(){} // RVA: 0x7FFAC2C7AF60
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ObjectWithParameterizedConstructorConverter`1 : ObjectDefaultConverter`1
    {
        public object ConstructorIsParameterized;

        // ── Methods ──
        public void get_ConstructorIsParameterized(){} // RVA: 0x7FFAC2C59D00
        public void OnTryRead(){}
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x7FFAC2C79B30
        public void ReadAndCacheConstructorArgument(){}
        public void CreateObject(){} // RVA: 0x7FFAC2C58F40
        public void ReadConstructorArguments(){} // RVA: 0x7FFAC2C7AF60
        public void ReadConstructorArgumentsWithContinuation(){}
        public void HandleConstructorArgumentWithContinuation(){}
        public void HandlePropertyWithContinuation(){}
        public void BeginRead(){} // RVA: 0x7FFAC2C7AF60
        public void EndRead(){} // RVA: 0x7FFAC2C70A40
        public void TryLookupConstructorParameter(){} // RVA: 0x7FFAC2C5D680
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class QueueOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class ReadOnlyMemoryByteConverter : JsonConverter`1
    {
        public object HandleNull;

        // ── Methods ──
        public void get_HandleNull(){} // RVA: 0x7FFAC3006850
        public void Read(){} // RVA: 0x7FFAC9074FB0
        public void Write(){} // RVA: 0x7FFAC90750D0
        public void .ctor(){} // RVA: 0x7FFAC9075170
    }

    public class ReadOnlyMemoryConverter`1 : JsonCollectionConverter`2
    {
        public object CanHaveMetadata;
        public object HandleNull;

        // ── Methods ──
        public void get_CanHaveMetadata(){} // RVA: 0x7FFAC2C59D00
        public void get_HandleNull(){} // RVA: 0x7FFAC2C59D00
        public void OnTryRead(){}
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void ConvertCollection(){} // RVA: 0x7FFAC2C79B30
        public void OnWriteResume(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SByteConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFE4A0
        public void Read(){} // RVA: 0x7FFAC8AFE4F0
        public void Write(){} // RVA: 0x7FFAC8AFE550
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFE5B0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFE5C0
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFE5F0
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFE670
    }

    public class SingleConverter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFE6F0
        public void Read(){} // RVA: 0x7FFAC8AFE740
        public void Write(){} // RVA: 0x7FFAC8AFE7A0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFE7D0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFE7E0
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFE810
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFE8A0
    }

    public class SlimObjectConverter : ObjectConverter
    {
        public System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver _originatingResolver; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC90787C0
        public void Read(){} // RVA: 0x7FFAC9078860
    }

    public class SmallObjectWithParameterizedConstructorConverter`5 : ObjectWithParameterizedConstructorConverter`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFAC2C58F40
        public void ReadAndCacheConstructorArgument(){}
        public void TryRead(){} // RVA: 0x7FFAC2C5D680
        public void InitializeConstructorArgumentCaches(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class StackOfTConverter`2 : IEnumerableDefaultConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C79B30
        public void CreateCollection(){} // RVA: 0x7FFAC2C7AF60
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class StackOrQueueConverterWithReflection`1 : StackOrQueueConverter`1
    {
        public object RequiresDynamicMemberAccessors;

        // ── Methods ──
        public void get_RequiresDynamicMemberAccessors(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Initialize(){} // RVA: 0x7FFAC2C79B30
    }

    public class StackOrQueueConverter`1 : JsonCollectionConverter`2
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC6997E70
        public void CreateCollection(){} // RVA: 0x7FFAC69980B0
        public void OnWriteResume(){} // RVA: 0x7FFAC6998170
        public void .ctor(){} // RVA: 0x7FFAC6998520
    }

    public class StringConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFE8F0
        public void Write(){} // RVA: 0x7FFAC8AFE900
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFE8F0
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFE9B0
        public void .ctor(){} // RVA: 0x7FFAC8AFEB00
    }

    public class TimeSpanConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8AFEB40
        public void Write(){} // RVA: 0x7FFAC8AFF410
        public void .ctor(){} // RVA: 0x7FFAC8AFF6D0
    }

    public class UInt16Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFF710
        public void Read(){} // RVA: 0x7FFAC8AFF760
        public void Write(){} // RVA: 0x7FFAC8AFF7C0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFF820
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFF830
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFF860
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFF8E0
    }

    public class UInt32Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFF960
        public void Read(){} // RVA: 0x7FFAC8AFF9B0
        public void Write(){} // RVA: 0x7FFAC8AFFA10
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFFA40
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFFA50
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFFA80
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFFB00
    }

    public class UInt64Converter : JsonConverter`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AFFB40
        public void Read(){} // RVA: 0x7FFAC8AFFB90
        public void Write(){} // RVA: 0x7FFAC8AFFBF0
        public void ReadAsPropertyNameCore(){} // RVA: 0x7FFAC8AFFC20
        public void WriteAsPropertyNameCore(){} // RVA: 0x7FFAC8AFFC30
        public void ReadNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFFC60
        public void WriteNumberWithCustomHandling(){} // RVA: 0x7FFAC8AFFCE0
    }

    public class UnsupportedTypeConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void CanConvert(){} // RVA: 0x7FFAC8AFFD20
        public void CreateConverter(){} // RVA: 0x7FFAC8AFFF10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnsupportedTypeConverter`1 : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC2E8DC40
        public void Write(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class UriConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8B000F0
        public void Write(){} // RVA: 0x7FFAC8B00170
        public void .ctor(){} // RVA: 0x7FFAC8B00280
    }

    public class VersionConverter : JsonConverter`1
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x7FFAC8B002C0
        public void Write(){} // RVA: 0x7FFAC8B00410
        public void .ctor(){} // RVA: 0x7FFAC8B004E0
    }

}