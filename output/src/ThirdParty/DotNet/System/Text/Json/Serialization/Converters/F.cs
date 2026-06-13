// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization.Converters
// Classes: 12
// Methods: 65

namespace ThirdParty.DotNet.System.Text.Json.Serialization.Converters
{
    public class FSharpListConverter`2
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<T>,U> _listConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x2DC60
        public void CreateCollection(){} // RVA: 0x2F090
        public void ConvertCollection(){} // RVA: 0x2DC60
    }

    public class FSharpListConverter`2
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<T>,U> _listConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x2DC60
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0xDBE0
        public void CreateCollection(){} // RVA: 0x2F090
        public void ConvertCollection(){} // RVA: 0x2DC60
    }

    public class FSharpMapConverter`3
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<System.Tuple`2<...,...>>,U> _mapConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x283FA0
        public void get_CanHaveIdMetadata(){} // RVA: 0xDBE0
        public void CreateCollection(){} // RVA: 0x2DC60
        public void ConvertCollection(){} // RVA: 0x2DC60
    }

    public class FSharpMapConverter`3
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<System.Tuple`2<...,...>>,U> _mapConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x283FA0
        public void get_CanHaveMetadata(){} // RVA: 0xDBE0
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0xDBE0
        public void CreateCollection(){} // RVA: 0x2DC60
        public void ConvertCollection(){} // RVA: 0x2DC60
    }

    public class FSharpOptionConverter`2
    {
        public System.Text.Json.Serialization.JsonConverter`1<U> _elementConverter;
        public System.Func`2<U,U> _optionValueGetter;
        public System.Func`2<U,U> _optionConstructor;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0xDBE0
        public void get_ElementType(){} // RVA: 0xCD60
        public void get_HandleNull(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x24B10
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x283FA0
        public void Write(){} // RVA: 0x283FA0
        public void Read(){} // RVA: 0x283FA0
    }

    public class FSharpOptionConverter`2
    {
        public System.Text.Json.Serialization.JsonConverter`1<U> _elementConverter;
        public System.Func`2<U,U> _optionValueGetter;

        // ── Methods ──
        public void get_ElementType(){} // RVA: 0xCD60
        public void get_HandleNull(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x24B10
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x283FA0
        public void Write(){} // RVA: 0x283FA0
        public void Read(){} // RVA: 0x283FA0
    }

    public class FSharpSetConverter`2
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<U>,U> _setConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x2DC60
        public void CreateCollection(){} // RVA: 0x2F090
        public void ConvertCollection(){} // RVA: 0x2DC60
    }

    public class FSharpSetConverter`2
    {
        public System.Func`2<System.Collections.Generic.IEnumerable`1<U>,U> _setConstructor;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x2DC60
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0xDBE0
        public void CreateCollection(){} // RVA: 0x2F090
        public void ConvertCollection(){} // RVA: 0x2DC60
    }

    public class FSharpTypeConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CanConvert(){} // RVA: 0x63620C0
        public void CreateConverter(){} // RVA: 0x63621F0
    }

    public class FSharpTypeConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x36ABC40
        public void CanConvert(){} // RVA: 0x68DFCD0
        public void CreateConverter(){} // RVA: 0x68DFE00
    }

    public class FSharpValueOptionConverter`2
    {
        public System.Text.Json.Serialization.JsonConverter`1<T> _elementConverter;
        public StructGetter`2<U,T> _optionValueGetter;
        public System.Func`2<T,U> _optionConstructor;

        // ── Methods ──
        public void get_ConverterStrategy(){} // RVA: 0xDBE0
        public void get_ElementType(){} // RVA: 0xCD60
        public void get_HandleNull(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x24B10
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x283FA0
        public void Write(){} // RVA: 0x283FA0
        public void Read(){} // RVA: 0x283FA0
    }

    public class FSharpValueOptionConverter`2
    {
        public System.Text.Json.Serialization.JsonConverter`1<T> _elementConverter;
        public StructGetter`2<U,T> _optionValueGetter;

        // ── Methods ──
        public void get_ElementType(){} // RVA: 0xCD60
        public void get_HandleNull(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x24B10
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x283FA0
        public void Write(){} // RVA: 0x283FA0
        public void Read(){} // RVA: 0x283FA0
    }

}