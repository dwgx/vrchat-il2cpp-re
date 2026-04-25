// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Nodes
// Classes: 9
// Methods: 215

namespace ThirdParty.DotNet.System.Text.Json.Nodes
{
    public class JsonArray : JsonNode
    {
        public System.Nullable`1<System.Text.Json.JsonElement> List; // 0x20
        public System.Collections.Generic.List`1<System.Text.Json.Nodes.JsonNode> Count; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC904E680 | overloaded x4
        public void GetValueKindCore(){} // RVA: 0x7FFAC5F481B0
        public void DeepCloneCore(){} // RVA: 0x7FFAC904DD30
        public void DeepEqualsCore(){} // RVA: 0x7FFAC904E1A0
        public void GetElementIndex(){} // RVA: 0x7FFAC904E380
        public void GetValues(){} // RVA: 0x7FFAC2C58E90
        public void InitializeFromArray(){} // RVA: 0x7FFAC904E410
        public void Create(){} // RVA: 0x7FFAC904E560
        public void Add(){} // RVA: 0x7FFAC904F5E0 | overloaded x2
        public void get_List(){} // RVA: 0x7FFAC904E7A0
        public void GetItem(){} // RVA: 0x7FFAC904E7C0
        public void SetItem(){} // RVA: 0x7FFAC904E840
        public void GetPath(){} // RVA: 0x7FFAC904E9E0
        public void WriteTo(){} // RVA: 0x7FFAC904EBA0
        public void InitializeList(){} // RVA: 0x7FFAC904EF50
        public void GetUnderlyingRepresentation(){} // RVA: 0x7FFAC904F4C0
        public void get_Count(){} // RVA: 0x7FFAC904F580
        public void Clear(){} // RVA: 0x7FFAC904F690
        public void Contains(){} // RVA: 0x7FFAC904F7E0
        public void IndexOf(){} // RVA: 0x7FFAC904F8A0
        public void Insert(){} // RVA: 0x7FFAC904F930
        public void Remove(){} // RVA: 0x7FFAC904F9F0
        public void RemoveAt(){} // RVA: 0x7FFAC904FAD0
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.CopyTo(){} // RVA: 0x7FFAC904FC00
        public void GetEnumerator(){} // RVA: 0x7FFAC904FC90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC904FD90
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void DetachParent(){} // RVA: 0x7FFAC904FDF0
    }

    public class JsonNode : Object
    {
        public System.Text.Json.Nodes.JsonNode Options; // 0x10
        public System.Nullable`1<System.Text.Json.Nodes.JsonNodeOptions> Parent; // 0x18

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFAC90501F0
        public void .ctor(){} // RVA: 0x7FFAC6D24B10
        public void AsArray(){} // RVA: 0x7FFAC9050240
        public void AsObject(){} // RVA: 0x7FFAC90502B0
        public void AsValue(){} // RVA: 0x7FFAC9050320
        public void get_Parent(){} // RVA: 0x7FFAC2F3C380
        public void set_Parent(){} // RVA: 0x7FFAC2F22E30
        public void GetPath(){} // RVA: 0x7FFAC2C79B30 | overloaded x2
        public void get_Root(){} // RVA: 0x7FFAC87D3860
        public void GetValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC90506E0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC9050830 | overloaded x2
        public void DeepClone(){} // RVA: 0x7FFAC3F5BE50
        public void DeepCloneCore(){} // RVA: 0x7FFAC2C58E90
        public void GetValueKind(){} // RVA: 0x7FFAC8D46490
        public void GetValueKindCore(){} // RVA: 0x7FFAC2C59D00
        public void GetPropertyName(){} // RVA: 0x7FFAC90508C0
        public void GetElementIndex(){} // RVA: 0x7FFAC9050A10
        public void DeepEquals(){} // RVA: 0x7FFAC9050B00
        public void DeepEqualsCore(){} // RVA: 0x7FFAC2C59F60
        public void ReplaceWith(){} // RVA: 0x7FFAC2E8DC40
        public void AssignParent(){} // RVA: 0x7FFAC9050B20
        public void ConvertFromValue(){} // RVA: 0x7FFAC2E8DC40
        public void op_Implicit(){} // RVA: 0x7FFAC9052350 | overloaded x33
        public void op_Explicit(){} // RVA: 0x7FFAC90533E0 | overloaded x33
        public void Parse(){} // RVA: 0x7FFAC9053720 | overloaded x4
        public void ParseAsync(){} // RVA: 0x7FFAC9053840
        public void ToJsonString(){} // RVA: 0x7FFAC9053A70
        public void ToString(){} // RVA: 0x7FFAC9053C50
        public void WriteTo(){} // RVA: 0x7FFAC2C79B30
        public void WriteToPooledBuffer(){} // RVA: 0x7FFAC9053EF0
    }

    public class JsonNodeOptions : ValueType
    {
        public bool PropertyNameCaseInsensitive; // 0x10

        // ── Methods ──
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x7FFAC495DDF0
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x7FFAC495DE00
    }

    public class JsonObject : JsonNode
    {
        public System.Nullable`1<System.Text.Json.JsonElement> Count; // 0x20
        public System.Text.Json.JsonPropertyDictionary`1<System.Text.Json.Nodes.JsonNode> System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.Keys; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8AE6990 | overloaded x2
        public void TryGetPropertyValue(){} // RVA: 0x7FFAC8AE6AB0
        public void WriteTo(){} // RVA: 0x7FFAC8AE6B80
        public void GetItem(){} // RVA: 0x7FFAC8AE7000
        public void SetItem(){} // RVA: 0x7FFAC8AE70E0
        public void DetachParent(){} // RVA: 0x7FFAC8AE7300
        public void Add(){} // RVA: 0x7FFAC8AE74C0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC8AE7640
        public void ContainsKey(){} // RVA: 0x7FFAC8AE7950
        public void get_Count(){} // RVA: 0x7FFAC8AE7A20
        public void Remove(){} // RVA: 0x7FFAC8AE7A80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Contains(){} // RVA: 0x7FFAC8AE7BC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.CopyTo(){} // RVA: 0x7FFAC8AE7C30
        public void GetEnumerator(){} // RVA: 0x7FFAC8AE7CB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Remove(){} // RVA: 0x7FFAC8AE7D10
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Keys(){} // RVA: 0x7FFAC8AE7E80
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Values(){} // RVA: 0x7FFAC8AE7FD0
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.TryGetValue(){} // RVA: 0x7FFAC8AE8040
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8AE80C0
        public void InitializeIfRequired(){} // RVA: 0x7FFAC8AE8120
    }

    public class JsonValue : JsonNode
    {
        public string CreateUnreferencedCodeMessage;
        public string CreateDynamicCodeMessage;

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2E8DC40 | overloaded x37
        public void .ctor(){} // RVA: 0x7FFAC6D24B10
        public void GetPath(){} // RVA: 0x7FFAC9058490
        public void TryGetValue(){} // RVA: 0x7FFAC2C59F60
        public void VerifyJsonElementIsNotArrayOrObject(){} // RVA: 0x7FFAC90584C0
    }

    public class JsonValueCustomized`1 : JsonValue`1
    {
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<T> _jsonTypeInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void WriteTo(){} // RVA: 0x7FFAC2C79B30
        public void DeepCloneCore(){} // RVA: 0x7FFAC2C58E90
    }

    public class JsonValuePrimitive`1 : JsonValue`1
    {
        public System.Text.Json.JsonSerializerOptions s_defaultOptions;
        public System.Text.Json.Serialization.JsonConverter`1<T> _converter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void WriteTo(){} // RVA: 0x7FFAC2C79B30
        public void DeepCloneCore(){} // RVA: 0x7FFAC2C58E90
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class JsonValueTrimmable`1 : JsonValue`1
    {
        public System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<T> _jsonTypeInfo;
        public System.Text.Json.Serialization.JsonConverter`1<T> _converter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void WriteTo(){} // RVA: 0x7FFAC2C79B30
    }

    public class JsonValue`1 : JsonValue
    {
        public T Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void GetValue(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2C59F60
        public void GetValueKindCore(){} // RVA: 0x7FFAC2C59D00
        public void DeepEqualsCore(){} // RVA: 0x7FFAC2C59F60
        public void ConvertJsonElement(){} // RVA: 0x7FFAC2E8DC40
        public void TryConvertJsonElement(){} // RVA: 0x7FFAC2C59F60
    }

}