// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization.Converters
// Classes: 12
// Methods: 65

namespace ThirdParty.DotNet.System.Text.Json.Serialization.Converters
{
    public class FSharpListConverter`2 : IEnumerableDefaultConverter`2
    {
        public object _listConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void Add(){} // RVA: 0x8943B0
        public void CreateCollection(){} // RVA: 0x8954D0
        public void ConvertCollection(){} // RVA: 0x8943B0
    }

    public class FSharpListConverter`2 : IEnumerableDefaultConverter`2
    {
        public object _listConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void Add(){} // RVA: 0x8943B0
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x87D280
        public void CreateCollection(){} // RVA: 0x8954D0
        public void ConvertCollection(){} // RVA: 0x8943B0
    }

    public class FSharpMapConverter`3 : DictionaryDefaultConverter`3
    {
        public object _mapConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void Add(){} // RVA: 0xA94080
        public void get_CanHaveIdMetadata(){} // RVA: 0x87D280
        public void CreateCollection(){} // RVA: 0x8943B0
        public void ConvertCollection(){} // RVA: 0x8943B0
    }

    public class FSharpMapConverter`3 : DictionaryDefaultConverter`3
    {
        public object _mapConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void Add(){} // RVA: 0xA94080
        public void get_CanHaveMetadata(){} // RVA: 0x87D280
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x87D280
        public void CreateCollection(){} // RVA: 0x8943B0
        public void ConvertCollection(){} // RVA: 0x8943B0
    }

    public class FSharpOptionConverter`2 : JsonConverter`1
    {
        public object _elementConverter;
        public object _optionValueGetter;
        public object _optionConstructor;
        public object _converterStrategy;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x87D280
        public void get_ElementType(){} // RVA: 0x87C0A0
        public void get_HandleNull(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894320
        public void OnTryRead(){} // RVA: 0x87F2C0
        public void OnTryWrite(){} // RVA: 0xA94080
        public void Write(){} // RVA: 0xA94080
        public void Read(){} // RVA: 0xA94080
    }

    public class FSharpOptionConverter`2 : JsonConverter`1
    {
        public object _elementConverter;
        public object _optionValueGetter;
        public object _optionConstructor;

        // ── Methods ──
        public void get_ElementType(){} // RVA: 0x87C0A0
        public void get_HandleNull(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894320
        public void OnTryRead(){} // RVA: 0x87F2C0
        public void OnTryWrite(){} // RVA: 0xA94080
        public void Write(){} // RVA: 0xA94080
        public void Read(){} // RVA: 0xA94080
    }

    public class FSharpSetConverter`2 : IEnumerableDefaultConverter`2
    {
        public object _setConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void Add(){} // RVA: 0x8943B0
        public void CreateCollection(){} // RVA: 0x8954D0
        public void ConvertCollection(){} // RVA: 0x8943B0
    }

    public class FSharpSetConverter`2 : IEnumerableDefaultConverter`2
    {
        public object _setConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void Add(){} // RVA: 0x8943B0
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0x87D280
        public void CreateCollection(){} // RVA: 0x8954D0
        public void ConvertCollection(){} // RVA: 0x8943B0
    }

    public class FSharpTypeConverterFactory : JsonConverterFactory
    {
        public object _recordConverterFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CanConvert(){} // RVA: 0x6DCF7C0
        public void CreateConverter(){} // RVA: 0x6DCF8F0
    }

    public class FSharpTypeConverterFactory : JsonConverterFactory
    {
        public object _recordConverterFactory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4127AC0
        public void CanConvert(){} // RVA: 0x7344A70
        public void CreateConverter(){} // RVA: 0x7344BA0
    }

    public class FSharpValueOptionConverter`2 : JsonConverter`1
    {
        public object _elementConverter;
        public object _optionValueGetter;
        public object _optionConstructor;
        public object _converterStrategy;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0x87D280
        public void get_ElementType(){} // RVA: 0x87C0A0
        public void get_HandleNull(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894320
        public void OnTryRead(){} // RVA: 0x87F2C0
        public void OnTryWrite(){} // RVA: 0xA94080
        public void Write(){} // RVA: 0xA94080
        public void Read(){} // RVA: 0xA94080
    }

    public class FSharpValueOptionConverter`2 : JsonConverter`1
    {
        public object _elementConverter;
        public object _optionValueGetter;
        public object _optionConstructor;

        // ── Methods ──
        public void get_ElementType(){} // RVA: 0x87C0A0
        public void get_HandleNull(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894320
        public void OnTryRead(){} // RVA: 0x87F2C0
        public void OnTryWrite(){} // RVA: 0xA94080
        public void Write(){} // RVA: 0xA94080
        public void Read(){} // RVA: 0xA94080
    }

}