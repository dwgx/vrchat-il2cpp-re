// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Nodes
// Classes: 18
// Methods: 183

namespace ThirdParty.DotNet.System.Text.Json.Nodes
{
    public class JsonArray : JsonNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DBACA0
        public void get_List(){} // RVA: 0x6DBADC0
        public void GetItem(){} // RVA: 0x6DBADE0
        public void SetItem(){} // RVA: 0x6DBAE60
        public void WriteTo(){} // RVA: 0x6DBAFE0
        public void CreateNodes(){} // RVA: 0x6DBB290
        public void get_Count(){} // RVA: 0x6DBB680
        public void Add(){} // RVA: 0x6DBB6D0
        public void Clear(){} // RVA: 0x6DBB770
        public void Contains(){} // RVA: 0x6DBB910
        public void IndexOf(){} // RVA: 0x6DBB9D0
        public void Insert(){} // RVA: 0x6DBBA60
        public void Remove(){} // RVA: 0x6DBBB20
        public void RemoveAt(){} // RVA: 0x6DBBBF0
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.CopyTo(){} // RVA: 0x6DBBD10
        public void GetEnumerator(){} // RVA: 0x6DBBDA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6DBBEA0
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.get_IsReadOnly(){} // RVA: 0xB43320
        public void DetachParent(){} // RVA: 0x6DBBF00
    }

    public class JsonArray : JsonNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x731CCF0
        public void GetValueKindCore(){} // RVA: 0x40A00B0
        public void DeepCloneCore(){} // RVA: 0x731C3B0
        public void DeepEqualsCore(){} // RVA: 0x731C810
        public void GetElementIndex(){} // RVA: 0x731C9F0
        public void GetValues(){} // RVA: 0x87C0A0
        public void InitializeFromArray(){} // RVA: 0x731CA80
        public void Create(){} // RVA: 0x731CBD0
        public void Add(){} // RVA: 0x731DC70
        public void get_List(){} // RVA: 0x731CE10
        public void GetItem(){} // RVA: 0x731CE30
        public void SetItem(){} // RVA: 0x731CEB0
        public void GetPath(){} // RVA: 0x731D050
        public void WriteTo(){} // RVA: 0x731D200
        public void InitializeList(){} // RVA: 0x731D5C0
        public void GetUnderlyingRepresentation(){} // RVA: 0x731DB50
        public void get_Count(){} // RVA: 0x731DC10
        public void Clear(){} // RVA: 0x731DD20
        public void Contains(){} // RVA: 0x731DE60
        public void IndexOf(){} // RVA: 0x731DF20
        public void Insert(){} // RVA: 0x731DFB0
        public void Remove(){} // RVA: 0x731E070
        public void RemoveAt(){} // RVA: 0x731E150
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.CopyTo(){} // RVA: 0x731E280
        public void GetEnumerator(){} // RVA: 0x731E310
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x731E410
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.get_IsReadOnly(){} // RVA: 0xB43320
        public void DetachParent(){} // RVA: 0x731E470
    }

    public class JsonNode : Object
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x6DBBF60
        public void .ctor(){} // RVA: 0x4FB44B0
        public void AsArray(){} // RVA: 0x6DBBFB0
        public void AsObject(){} // RVA: 0x6DBC080
        public void get_Parent(){} // RVA: 0xB5DBF0
        public void set_Parent(){} // RVA: 0xB44D60
        public void get_Item(){} // RVA: 0x6DBC220
        public void set_Item(){} // RVA: 0x6DBC310
        public void AssignParent(){} // RVA: 0x6DBC350
        public void ToString(){} // RVA: 0x6DBC3A0
        public void WriteTo(){} // RVA: 0x8943B0
    }

    public class JsonNode : Object
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x731E870
        public void .ctor(){} // RVA: 0x4FB44B0
        public void AsArray(){} // RVA: 0x731E8C0
        public void AsObject(){} // RVA: 0x731E930
        public void AsValue(){} // RVA: 0x731E9A0
        public void get_Parent(){} // RVA: 0xB5DBF0
        public void set_Parent(){} // RVA: 0xB44D60
        public void GetPath(){} // RVA: 0x8943B0
        public void get_Root(){} // RVA: 0x6AB0800
        public void GetValue(){} // RVA: 0xA94080
        public void get_Item(){} // RVA: 0x731ED80
        public void set_Item(){} // RVA: 0x731EED0
        public void DeepClone(){} // RVA: 0x11F4110
        public void DeepCloneCore(){} // RVA: 0x87C0A0
        public void GetValueKind(){} // RVA: 0x1D7BA30
        public void GetValueKindCore(){} // RVA: 0x87D280
        public void GetPropertyName(){} // RVA: 0x731EF60
        public void GetElementIndex(){} // RVA: 0x731F0A0
        public void DeepEquals(){} // RVA: 0x731F190
        public void DeepEqualsCore(){} // RVA: 0x87D350
        public void ReplaceWith(){} // RVA: 0xA94080
        public void AssignParent(){} // RVA: 0x731F1B0
        public void ConvertFromValue(){} // RVA: 0xA94080
        public void op_Implicit(){} // RVA: 0x73209E0
        public void op_Explicit(){} // RVA: 0x7321A40
        public void Parse(){} // RVA: 0x7321D80
        public void ParseAsync(){} // RVA: 0x7321EA0
        public void ToJsonString(){} // RVA: 0x73220C0
        public void ToString(){} // RVA: 0x73222B0
        public void WriteTo(){} // RVA: 0x8943B0
        public void WriteToPooledBuffer(){} // RVA: 0x7322570
    }

    public class JsonNodeOptions : ValueType
    {
        // ── Methods ──
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x90520
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x90530
    }

    public class JsonNodeOptions : ValueType
    {
        // ── Methods ──
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x90520
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x90530
    }

    public class JsonObject : JsonNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DBC9B0
        public void TryGetPropertyValue(){} // RVA: 0x6DBCAD0
        public void WriteTo(){} // RVA: 0x6DBCBA0
        public void GetItem(){} // RVA: 0x6DBD050
        public void SetItem(){} // RVA: 0x6DBD130
        public void DetachParent(){} // RVA: 0x6DBD350
        public void Add(){} // RVA: 0x6DBD510
        public void Clear(){} // RVA: 0x6DBD690
        public void ContainsKey(){} // RVA: 0x6DBD9A0
        public void get_Count(){} // RVA: 0x6DBDA70
        public void Remove(){} // RVA: 0x6DBDAD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Contains(){} // RVA: 0x6DBDC10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.CopyTo(){} // RVA: 0x6DBDC80
        public void GetEnumerator(){} // RVA: 0x6DBDD00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Remove(){} // RVA: 0x6DBDD60
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Keys(){} // RVA: 0x6DBDED0
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Values(){} // RVA: 0x6DBE020
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.TryGetValue(){} // RVA: 0x6DBE090
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6DBE110
        public void InitializeIfRequired(){} // RVA: 0x6DBE170
    }

    public class JsonObject : JsonNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7322E90
        public void Create(){} // RVA: 0x7322D70
        public void get_Dictionary(){} // RVA: 0x7322FB0
        public void DeepCloneCore(){} // RVA: 0x7322FD0
        public void GetPropertyName(){} // RVA: 0x7323620
        public void TryGetPropertyValue(){} // RVA: 0x73236F0
        public void WriteTo(){} // RVA: 0x73237C0
        public void GetValueKindCore(){} // RVA: 0xC2E4C0
        public void DeepEqualsCore(){} // RVA: 0x7323B60
        public void GetItem(){} // RVA: 0x7323E70
        public void GetPath(){} // RVA: 0x7323F50
        public void SetItem(){} // RVA: 0x7324150
        public void DetachParent(){} // RVA: 0x6DBBF00
        public void Add(){} // RVA: 0x7324350
        public void Clear(){} // RVA: 0x73243B0
        public void ContainsKey(){} // RVA: 0x7324670
        public void get_Count(){} // RVA: 0x7324730
        public void Remove(){} // RVA: 0x7324790
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Contains(){} // RVA: 0x73248B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.CopyTo(){} // RVA: 0x7324930
        public void GetEnumerator(){} // RVA: 0x73249B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Remove(){} // RVA: 0x7324A50
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Keys(){} // RVA: 0x7324B90
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Values(){} // RVA: 0x7324CF0
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.TryGetValue(){} // RVA: 0x7324D60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7324DE0
        public void InitializeDictionary(){} // RVA: 0x7324E80
        public void GetUnderlyingRepresentation(){} // RVA: 0x731DB50
    }

    public class JsonValue : JsonNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4FB44B0
    }

    public class JsonValue : JsonNode
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x4FB44B0
        public void GetPath(){} // RVA: 0x7326B30
        public void TryGetValue(){} // RVA: 0x87D350
        public void VerifyJsonElementIsNotArrayOrObject(){} // RVA: 0x7326B60
    }

    public class JsonValueCustomized`1 : JsonValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void WriteTo(){} // RVA: 0x8943B0
        public void DeepCloneCore(){} // RVA: 0x87C0A0
    }

    public class JsonValuePrimitive`1 : JsonValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void WriteTo(){} // RVA: 0x8943B0
        public void DeepCloneCore(){} // RVA: 0x87C0A0
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class JsonValueTrimmable`1 : JsonValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void WriteTo(){} // RVA: 0x8943B0
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void get_Value(){} // RVA: 0xA94080
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x41FE570
        public void get_Value(){} // RVA: 0xAD0950
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void GetValue(){} // RVA: 0xA94080
        public void TryGetValue(){} // RVA: 0x87D350
        public void GetValueKindCore(){} // RVA: 0x87D280
        public void DeepEqualsCore(){} // RVA: 0x87D350
        public void ConvertJsonElement(){} // RVA: 0xA94080
        public void TryConvertJsonElement(){} // RVA: 0x87D350
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x41FE6F0
        public void GetValue(){} // RVA: 0xA94080
        public void TryGetValue(){} // RVA: 0x87D350
        public void GetValueKindCore(){} // RVA: 0x41FE870
        public void DeepEqualsCore(){} // RVA: 0x41FEBE0
        public void ConvertJsonElement(){} // RVA: 0xA94080
        public void TryConvertJsonElement(){} // RVA: 0x87D350
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x41FE6F0
        public void GetValue(){} // RVA: 0xA94080
        public void TryGetValue(){} // RVA: 0x87D350
        public void GetValueKindCore(){} // RVA: 0x41FE870
        public void DeepEqualsCore(){} // RVA: 0x41FEBE0
        public void ConvertJsonElement(){} // RVA: 0xA94080
        public void TryConvertJsonElement(){} // RVA: 0x87D350
    }

}