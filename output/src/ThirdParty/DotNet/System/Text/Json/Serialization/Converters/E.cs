// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization.Converters
// Classes: 4
// Methods: 34

namespace ThirdParty.DotNet.System.Text.Json.Serialization.Converters
{
    public class EnumConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CanConvert(){} // RVA: 0x38BA790
        public void CreateConverter(){} // RVA: 0x6DD3090
        public void Create(){} // RVA: 0x6DD30A0
        public void GetEnumConverterType(){} // RVA: 0x6DD3340
    }

    public class EnumConverterFactory : JsonConverterFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4127AC0
        public void CanConvert(){} // RVA: 0x38BA790
        public void CreateConverter(){} // RVA: 0x7348570
        public void Create(){} // RVA: 0x73485A0
        public void GetEnumConverterType(){} // RVA: 0x7348880
    }

    public class EnumConverter`1 : JsonConverter`1
    {
        public object s_enumTypeCode;
        public object s_negativeSign;
        public object _converterOptions;
        public object _namingPolicy;
        public object _nameCache;
        public object _dictionaryKeyPolicyCache;

        // ── Methods ──
        public void CanConvert(){} // RVA: 0x87D350
        public void .ctor(){} // RVA: 0x897330
        public void Read(){} // RVA: 0xA94080
        public void Write(){} // RVA: 0xA94080
        public void ConvertToUInt64(){} // RVA: 0x87C5C0
        public void IsValidIdentifier(){} // RVA: 0x87D390
        public void FormatEnumValue(){} // RVA: 0xA94080
        public void FormatEnumValueToString(){} // RVA: 0x87C5F0
        public void ReadAsPropertyNameCore(){} // RVA: 0xA94080
        public void WriteAsPropertyNameCore(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class EnumConverter`1 : JsonPrimitiveConverter`1
    {
        public object s_enumTypeCode;
        public object s_isSignedEnum;
        public object ValueSeparator;
        public object _converterOptions;
        public object _namingPolicy;
        public object _nameCacheForWriting;
        public object _nameCacheForReading;
        public object NameCacheSizeSoftLimit;

        // ── Methods ──
        public void CanConvert(){} // RVA: 0x87D350
        public void .ctor(){} // RVA: 0x897330
        public void Read(){} // RVA: 0xA94080
        public void Write(){} // RVA: 0xA94080
        public void ReadAsPropertyNameCore(){} // RVA: 0xA94080
        public void WriteAsPropertyNameCore(){} // RVA: 0xA94080
        public void TryParseEnumCore(){} // RVA: 0x880B90
        public void ReadEnumUsingNamingPolicy(){} // RVA: 0xA94080
        public void ConvertToUInt64(){} // RVA: 0x87C5C0
        public void IsValidIdentifier(){} // RVA: 0x87D390
        public void FormatJsonName(){} // RVA: 0x87C630
        public void SplitFlagsEnum(){} // RVA: 0x87C5C0
        public void .cctor(){} // RVA: 0x8942F0
    }

}