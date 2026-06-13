// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Serialization.Converters
// Classes: 100
// Methods: 146

namespace ThirdParty.DotNet.System.Text.Json.Serialization.Converters
{
    public class JsonArrayConverter
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x6362B20
        public void Read(){} // RVA: 0x6362B60
        public void ReadList(){} // RVA: 0x6362C60
        public void .ctor(){} // RVA: 0x6362CF0
    }

    public class JsonArrayConverter
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x68E0770
        public void Read(){} // RVA: 0x68E07C0
        public void ReadList(){} // RVA: 0x68E08E0
        public void .ctor(){} // RVA: 0x68E0970
    }

    public class JsonDocumentConverter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x63666F0
        public void Write(){} // RVA: 0x6366730
        public void .ctor(){} // RVA: 0x6366850
    }

    public class JsonDocumentConverter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x68E4730
        public void Write(){} // RVA: 0x68E4770
        public void .ctor(){} // RVA: 0x68E48D0
    }

    public class JsonElementConverter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x6366890
        public void Write(){} // RVA: 0x63668C0
        public void .ctor(){} // RVA: 0x6366970
    }

    public class JsonElementConverter
    {
        // ── Methods ──
        public void Read(){} // RVA: 0x68E4910
        public void Write(){} // RVA: 0x68E4940
        public void .ctor(){} // RVA: 0x68E49E0
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<T>> _converterCreator;
        public 0x65939C90 _converterStrategy;
        public System.Text.Json.Serialization.JsonConverter`1<T> _converter;

        // ── Methods ──
        public void get_Converter(){} // RVA: 0xCD60
        public void get_ConverterStrategy(){} // RVA: 0xDBE0
        public void get_KeyType(){} // RVA: 0xCD60
        public void get_ElementType(){} // RVA: 0xCD60
        public void get_ConstructorIsParameterized(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x2A620
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x283FA0
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<T> <Converter>k__BackingField;
        public bool <HandleNull>k__BackingField;

        // ── Methods ──
        public void get_Converter(){} // RVA: 0xCD60
        public void get_KeyType(){} // RVA: 0xCD60
        public void get_ElementType(){} // RVA: 0xCD60
        public void get_HandleNull(){} // RVA: 0xDBE0
        public void get_ConstructorIsParameterized(){} // RVA: 0xDBE0
        public void get_SupportsCreateObjectDelegate(){} // RVA: 0xDBE0
        public void get_CanHaveMetadata(){} // RVA: 0xDBE0
        public void get_CanPopulate(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x24B10
        public void OnTryRead(){}
        public void OnTryWrite(){} // RVA: 0x283FA0
        public void ConfigureJsonTypeInfo(){} // RVA: 0x2DC60
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.DateTime> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.DateTimeOffset> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Decimal> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<double> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Guid> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<UIntPtr>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<UIntPtr> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Nullable`1<UIntPtr>>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Nullable`1<UIntPtr>> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<object>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<object> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<type_0x19>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<type_0x19> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Nullable`1<type_0x19>>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Nullable`1<type_0x19>> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonArray>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonArray> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonNode>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonNode> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonObject>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonObject> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonValue>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonValue> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<bool>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<bool> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<byte[]>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<byte[]> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<byte>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<byte> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<char>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<char> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.DateTime>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.DateTime> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.DateTimeOffset>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.DateTimeOffset> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Decimal>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Decimal> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<double>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<double> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Guid>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Guid> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<short>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<short> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<int>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<int> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<long>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<long> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.JsonDocument>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.JsonDocument> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.JsonElement>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.JsonElement> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<sbyte>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<sbyte> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<float>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<float> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<string>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<string> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.TimeSpan>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.TimeSpan> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<ushort>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<ushort> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<uint>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<uint> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<ulong>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<ulong> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Uri>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Uri> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Func`1<System.Text.Json.Serialization.JsonConverter`1<System.Version>> _converterCreator; // 0x30
        public 0x65939C90 _converterStrategy; // 0x38
        public System.Text.Json.Serialization.JsonConverter`1<System.Version> _converter; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.ReadOnlyMemory`1<byte>> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Memory`1<byte>> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonArray> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonNode> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonObject> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.Nodes.JsonValue> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<object> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<bool> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<byte[]> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<byte> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<char> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<short> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<int> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<long> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.JsonDocument> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Text.Json.JsonElement> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<sbyte> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<float> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<string> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.TimeSpan> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<ushort> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<uint> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<ulong> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Uri> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonMetadataServicesConverter`1
    {
        public System.Text.Json.Serialization.JsonConverter`1<System.Version> <Converter>k__BackingField; // 0x38
        public bool <HandleNull>k__BackingField; // 0x40
    }

    public class JsonNodeConverter
    {
        public System.Text.Json.Serialization.Converters.JsonNodeConverter s_nodeConverter;
        public System.Text.Json.Serialization.Converters.JsonArrayConverter s_arrayConverter; // 0x8
        public System.Text.Json.Serialization.Converters.JsonObjectConverter s_objectConverter; // 0x10
        public System.Text.Json.Serialization.Converters.JsonValueConverter s_valueConverter; // 0x18

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6362D30
        public void get_ArrayConverter(){} // RVA: 0x6362E20
        public void get_ObjectConverter(){} // RVA: 0x6362F30
        public void get_ValueConverter(){} // RVA: 0x6363040
        public void Write(){} // RVA: 0x6363150
        public void Read(){} // RVA: 0x63632E0
        public void Create(){} // RVA: 0x63633E0
        public void .ctor(){} // RVA: 0x6363550
    }

    public class JsonNodeConverter
    {
        public System.Text.Json.Serialization.Converters.JsonNodeConverter s_nodeConverter;
        public System.Text.Json.Serialization.Converters.JsonArrayConverter s_arrayConverter; // 0x8
        public System.Text.Json.Serialization.Converters.JsonObjectConverter s_objectConverter; // 0x10
        public System.Text.Json.Serialization.Converters.JsonValueConverter s_valueConverter; // 0x18

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x68E09B0
        public void get_ArrayConverter(){} // RVA: 0x68E0AA0
        public void get_ObjectConverter(){} // RVA: 0x68E0BB0
        public void get_ValueConverter(){} // RVA: 0x68E0CC0
        public void Write(){} // RVA: 0x68E0770
        public void Read(){} // RVA: 0x68E0DD0
        public void Create(){} // RVA: 0x68E0EE0
        public void .ctor(){} // RVA: 0x68E1050
    }

    public class JsonNodeConverterFactory
    {
        // ── Methods ──
        public void CreateConverter(){} // RVA: 0x6363590
        public void CanConvert(){} // RVA: 0x6363730
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JsonNodeConverterFactory
    {
        // ── Methods ──
        public void CreateConverter(){} // RVA: 0x68E1090
        public void CanConvert(){} // RVA: 0x68E1230
        public void .ctor(){} // RVA: 0x36ABC40
    }

    public class JsonObjectConverter
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x6363830
        public void ReadElementAndSetProperty(){} // RVA: 0x63638B0
        public void Write(){} // RVA: 0x6362B20
        public void Read(){} // RVA: 0x6363BA0
        public void ReadObject(){} // RVA: 0x6363CA0
        public void .ctor(){} // RVA: 0x6363D30
    }

    public class JsonObjectConverter
    {
        // ── Methods ──
        public void ConfigureJsonTypeInfo(){} // RVA: 0x68E1310
        public void ReadElementAndSetProperty(){} // RVA: 0x68E1490
        public void Write(){} // RVA: 0x68E0770
        public void Read(){} // RVA: 0x68E1690
        public void ReadObject(){} // RVA: 0x68E17B0
        public void .ctor(){} // RVA: 0x68E1840
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AFB40
        public void ReadAsPropertyName(){} // RVA: 0x263BC0
        public void .ctor(){} // RVA: 0x2EC6B90
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x283FA0
        public void ReadAsPropertyName(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AF770
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AF790
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AF7B0
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AF7D0
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF7F0
        public void ReadAsPropertyName(){} // RVA: 0x36AF830
        public void .ctor(){} // RVA: 0x36AF8A0
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF7F0
        public void ReadAsPropertyName(){} // RVA: 0x36AF830
        public void .ctor(){} // RVA: 0x36AF8C0
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF8E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AF920
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF7F0
        public void ReadAsPropertyName(){} // RVA: 0x36AF830
        public void .ctor(){} // RVA: 0x36AF940
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AF960
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AF980
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AF9A0
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AFA80
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF8E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AFAA0
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF9C0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AFA60
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AFAC0
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AFAE0
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AFB00
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF6E0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AFB20
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF9C0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AFA60
    }

    public class JsonPrimitiveConverter`1
    {
        // ── Methods ──
        public void WriteAsPropertyName(){} // RVA: 0x36AF9C0
        public void ReadAsPropertyName(){} // RVA: 0x36AF720
        public void .ctor(){} // RVA: 0x36AFA60
    }

    public class JsonValueConverter
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x6362B20
        public void Read(){} // RVA: 0x6363D70
        public void .ctor(){} // RVA: 0x6363E40
    }

    public class JsonValueConverter
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x68E0770
        public void Read(){} // RVA: 0x68E1900
        public void .ctor(){} // RVA: 0x68E1A00
    }

}