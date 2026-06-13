// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Nodes
// Classes: 18
// Methods: 300

namespace ThirdParty.DotNet.System.Text.Json.Nodes
{
    public class JsonArray
    {
        public System.Nullable`1<System.Text.Json.JsonElement> _jsonElement; // 0x20
        public System.Collections.Generic.List`1<System.Text.Json.Nodes.JsonNode> _list; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68B7B60 | overloaded x4
        public void GetValueKindCore(){} // RVA: 0x36258F0
        public void DeepCloneCore(){} // RVA: 0x68B7210
        public void DeepEqualsCore(){} // RVA: 0x68B7680
        public void GetElementIndex(){} // RVA: 0x68B7860
        public void GetValues(){} // RVA: 0xCD60
        public void InitializeFromArray(){} // RVA: 0x68B78F0
        public void Create(){} // RVA: 0x68B7A40
        public void Add(){} // RVA: 0x68B8AC0 | overloaded x2
        public void get_List(){} // RVA: 0x68B7C80
        public void GetItem(){} // RVA: 0x68B7CA0
        public void SetItem(){} // RVA: 0x68B7D20
        public void GetPath(){} // RVA: 0x68B7EC0
        public void WriteTo(){} // RVA: 0x68B8080
        public void InitializeList(){} // RVA: 0x68B8430
        public void GetUnderlyingRepresentation(){} // RVA: 0x68B89A0
        public void get_Count(){} // RVA: 0x68B8A60
        public void Clear(){} // RVA: 0x68B8B70
        public void Contains(){} // RVA: 0x68B8CC0
        public void IndexOf(){} // RVA: 0x68B8D80
        public void Insert(){} // RVA: 0x68B8E10
        public void Remove(){} // RVA: 0x68B8ED0
        public void RemoveAt(){} // RVA: 0x68B8FB0
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.CopyTo(){} // RVA: 0x68B90E0
        public void GetEnumerator(){} // RVA: 0x68B9170
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x68B9270
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void DetachParent(){} // RVA: 0x68B92D0
    }

    public class JsonArray
    {
        public System.Nullable`1<System.Text.Json.JsonElement> _jsonElement; // 0x20
        public System.Collections.Generic.List`1<System.Text.Json.Nodes.JsonNode> _list; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x634D950
        public void get_List(){} // RVA: 0x634DA70
        public void GetItem(){} // RVA: 0x634DA90
        public void SetItem(){} // RVA: 0x634DB10
        public void WriteTo(){} // RVA: 0x634DC90
        public void CreateNodes(){} // RVA: 0x634DEF0
        public void get_Count(){} // RVA: 0x634E2E0
        public void Add(){} // RVA: 0x634E330
        public void Clear(){} // RVA: 0x634E3D0
        public void Contains(){} // RVA: 0x634E550
        public void IndexOf(){} // RVA: 0x634E610
        public void Insert(){} // RVA: 0x634E6A0
        public void Remove(){} // RVA: 0x634E760
        public void RemoveAt(){} // RVA: 0x634E830
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.CopyTo(){} // RVA: 0x634E950
        public void GetEnumerator(){} // RVA: 0x634E9E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x634EAE0
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void DetachParent(){} // RVA: 0x634EB40
    }

    public class JsonNode
    {
        public System.Text.Json.Nodes.JsonNode _parent; // 0x10
        public System.Nullable`1<System.Text.Json.Nodes.JsonNodeOptions> _options; // 0x18

        // ── Methods ──
        public void get_Options(){} // RVA: 0x68B96D0
        public void .ctor(){} // RVA: 0x4470200
        public void AsArray(){} // RVA: 0x68B9720
        public void AsObject(){} // RVA: 0x68B9790
        public void AsValue(){} // RVA: 0x68B9800
        public void get_Parent(){} // RVA: 0x2F8380
        public void set_Parent(){} // RVA: 0x2DEE30
        public void GetPath(){} // RVA: 0x2DC60 | overloaded x2
        public void get_Root(){} // RVA: 0x603C1B0
        public void GetValue(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x68B9BC0 | overloaded x2
        public void set_Item(){} // RVA: 0x68B9D10 | overloaded x2
        public void DeepClone(){} // RVA: 0x37EF790
        public void DeepCloneCore(){} // RVA: 0xCD60
        public void GetValueKind(){} // RVA: 0x65AFAC0
        public void GetValueKindCore(){} // RVA: 0xDBE0
        public void GetPropertyName(){} // RVA: 0x68B9DA0
        public void GetElementIndex(){} // RVA: 0x68B9EF0
        public void DeepEquals(){} // RVA: 0x68B9FE0
        public void DeepEqualsCore(){} // RVA: 0xDE40
        public void ReplaceWith(){} // RVA: 0x283FA0
        public void AssignParent(){} // RVA: 0x68BA000
        public void ConvertFromValue(){} // RVA: 0x283FA0
        public void op_Implicit(){} // RVA: 0x68BB830 | overloaded x33
        public void op_Explicit(){} // RVA: 0x68BC8C0 | overloaded x33
        public void Parse(){} // RVA: 0x68BCC00 | overloaded x4
        public void ParseAsync(){} // RVA: 0x68BCD20
        public void ToJsonString(){} // RVA: 0x68BCF50
        public void ToString(){} // RVA: 0x68BD130
        public void WriteTo(){} // RVA: 0x2DC60
        public void WriteToPooledBuffer(){} // RVA: 0x68BD3D0
    }

    public class JsonNode
    {
        public System.Text.Json.Nodes.JsonNode _parent; // 0x10
        public System.Nullable`1<System.Text.Json.Nodes.JsonNodeOptions> _options; // 0x18

        // ── Methods ──
        public void get_Options(){} // RVA: 0x634EBA0
        public void .ctor(){} // RVA: 0x4470200
        public void AsArray(){} // RVA: 0x634EBF0
        public void AsObject(){} // RVA: 0x634ECC0
        public void get_Parent(){} // RVA: 0x2F8380
        public void set_Parent(){} // RVA: 0x2DEE30
        public void get_Item(){} // RVA: 0x634EE60 | overloaded x2
        public void set_Item(){} // RVA: 0x634EF50 | overloaded x2
        public void AssignParent(){} // RVA: 0x634EF90
        public void ToString(){} // RVA: 0x634EFE0
        public void WriteTo(){} // RVA: 0x2DC60
    }

    public class JsonNodeOptions
    {
        public bool <PropertyNameCaseInsensitive>k__BackingField; // 0x10

        // ── Methods ──
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x1E40360
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x1E40370
    }

    public class JsonNodeOptions
    {
        public bool <PropertyNameCaseInsensitive>k__BackingField; // 0x10

        // ── Methods ──
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x1E40360
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x1E40370
    }

    public class JsonObject
    {
        public System.Nullable`1<System.Text.Json.JsonElement> _jsonElement; // 0x20
        public System.Text.Json.JsonPropertyDictionary`1<System.Text.Json.Nodes.JsonNode> _dictionary; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x634F5F0 | overloaded x2
        public void TryGetPropertyValue(){} // RVA: 0x634F710
        public void WriteTo(){} // RVA: 0x634F7E0
        public void GetItem(){} // RVA: 0x634FC60
        public void SetItem(){} // RVA: 0x634FD40
        public void DetachParent(){} // RVA: 0x634FF60
        public void Add(){} // RVA: 0x6350120 | overloaded x2
        public void Clear(){} // RVA: 0x63502A0
        public void ContainsKey(){} // RVA: 0x63505B0
        public void get_Count(){} // RVA: 0x6350680
        public void Remove(){} // RVA: 0x63506E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Contains(){} // RVA: 0x6350820
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.CopyTo(){} // RVA: 0x6350890
        public void GetEnumerator(){} // RVA: 0x6350910
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Remove(){} // RVA: 0x6350970
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Keys(){} // RVA: 0x6350AE0
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Values(){} // RVA: 0x6350C30
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.TryGetValue(){} // RVA: 0x6350CA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6350D20
        public void InitializeIfRequired(){} // RVA: 0x6350D80
    }

    public class JsonObject
    {
        public System.Nullable`1<System.Text.Json.JsonElement> _jsonElement; // 0x20
        public System.Text.Json.JsonPropertyDictionary`1<System.Text.Json.Nodes.JsonNode> _dictionary; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68BDCE0 | overloaded x3
        public void Create(){} // RVA: 0x68BDBC0
        public void get_Dictionary(){} // RVA: 0x68BDE00
        public void DeepCloneCore(){} // RVA: 0x68BDE20
        public void GetPropertyName(){} // RVA: 0x68BE450
        public void TryGetPropertyValue(){} // RVA: 0x68BE530
        public void WriteTo(){} // RVA: 0x68BE600
        public void GetValueKindCore(){} // RVA: 0x3C2850
        public void DeepEqualsCore(){} // RVA: 0x68BE9B0
        public void GetItem(){} // RVA: 0x68BECB0
        public void GetPath(){} // RVA: 0x68BED90
        public void SetItem(){} // RVA: 0x68BEF90
        public void DetachParent(){} // RVA: 0x634EB40
        public void Add(){} // RVA: 0x68BF190 | overloaded x2
        public void Clear(){} // RVA: 0x68BF1F0
        public void ContainsKey(){} // RVA: 0x68BF4C0
        public void get_Count(){} // RVA: 0x68BF580
        public void Remove(){} // RVA: 0x68BF5E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Contains(){} // RVA: 0x68BF700
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.CopyTo(){} // RVA: 0x68BF780
        public void GetEnumerator(){} // RVA: 0x68BF800
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Remove(){} // RVA: 0x68BF8A0
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Keys(){} // RVA: 0x68BF9E0
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Values(){} // RVA: 0x68BFB40
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.TryGetValue(){} // RVA: 0x68BFBB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x68BFC30
        public void InitializeDictionary(){} // RVA: 0x68BFCD0
        public void GetUnderlyingRepresentation(){} // RVA: 0x68B89A0
    }

    public class JsonValue
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x283FA0 | overloaded x37
        public void .ctor(){} // RVA: 0x4470200
        public void GetPath(){} // RVA: 0x68C1970
        public void TryGetValue(){} // RVA: 0xDE40
        public void VerifyJsonElementIsNotArrayOrObject(){} // RVA: 0x68C19A0
    }

    public class JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4470200
    }

    public class JsonValueCustomized`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void WriteTo(){} // RVA: 0x2DC60
        public void DeepCloneCore(){} // RVA: 0xCD60
    }

    public class JsonValuePrimitive`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void WriteTo(){} // RVA: 0x2DC60
        public void DeepCloneCore(){} // RVA: 0xCD60
        public void .cctor(){} // RVA: 0x24A80
    }

    public class JsonValueTrimmable`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void WriteTo(){} // RVA: 0x2DC60
    }

    public class JsonValue`1
    {
        public T _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void GetValue(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0xDE40
        public void GetValueKindCore(){} // RVA: 0xDBE0
        public void DeepEqualsCore(){} // RVA: 0xDE40
        public void ConvertJsonElement(){} // RVA: 0x283FA0
        public void TryConvertJsonElement(){} // RVA: 0xDE40
    }

    public class JsonValue`1
    {
        public T _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x263BC0
        public void GetValue(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0xDE40
        public void GetValueKindCore(){} // RVA: 0x3793900
        public void DeepEqualsCore(){} // RVA: 0x3793C70
        public void ConvertJsonElement(){} // RVA: 0x283FA0
        public void TryConvertJsonElement(){} // RVA: 0xDE40
    }

    public class JsonValue`1
    {
        public T _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x263BC0
        public void GetValue(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0xDE40
        public void GetValueKindCore(){} // RVA: 0x3793900
        public void DeepEqualsCore(){} // RVA: 0x3793C70
        public void ConvertJsonElement(){} // RVA: 0x283FA0
        public void TryConvertJsonElement(){} // RVA: 0xDE40
    }

    public class JsonValue`1
    {
        public T _value; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x263BC0
        public void get_Value(){} // RVA: 0x263BC0
    }

    public class JsonValue`1
    {
        public T _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_Value(){} // RVA: 0x283FA0
    }

}