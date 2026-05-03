// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Nodes
// Classes: 9
// Methods: 215

namespace ThirdParty.DotNet.System.Text.Json.Nodes
{
    public class JsonArray : JsonNode
    {
        public System.Nullable`1<System.Text.Json.JsonElement> _jsonElement; // 0x20
        public System.Collections.Generic.List`1<System.Text.Json.Nodes.JsonNode> _list; // 0x38
        public object field_2; // 0x4C50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE873F6E30 | overloaded x4
        public void GetValueKindCore(){} // RVA: 0x7FFE8429F400
        public void DeepCloneCore(){} // RVA: 0x7FFE873F64E0
        public void DeepEqualsCore(){} // RVA: 0x7FFE873F6950
        public void GetElementIndex(){} // RVA: 0x7FFE873F6B30
        public void GetValues(){} // RVA: 0x7FFE80E2E2E0
        public void InitializeFromArray(){} // RVA: 0x7FFE873F6BC0
        public void Create(){} // RVA: 0x7FFE873F6D10
        public void Add(){} // RVA: 0x7FFE873F7D90 | overloaded x2
        public void get_List(){} // RVA: 0x7FFE873F6F50
        public void GetItem(){} // RVA: 0x7FFE873F6F70
        public void SetItem(){} // RVA: 0x7FFE873F6FF0
        public void GetPath(){} // RVA: 0x7FFE873F7190
        public void WriteTo(){} // RVA: 0x7FFE873F7350
        public void InitializeList(){} // RVA: 0x7FFE873F7700
        public void GetUnderlyingRepresentation(){} // RVA: 0x7FFE873F7C70
        public void get_Count(){} // RVA: 0x7FFE873F7D30
        public void Clear(){} // RVA: 0x7FFE873F7E40
        public void Contains(){} // RVA: 0x7FFE873F7F90
        public void IndexOf(){} // RVA: 0x7FFE873F8050
        public void Insert(){} // RVA: 0x7FFE873F80E0
        public void Remove(){} // RVA: 0x7FFE873F81A0
        public void RemoveAt(){} // RVA: 0x7FFE873F8280
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.CopyTo(){} // RVA: 0x7FFE873F83B0
        public void GetEnumerator(){} // RVA: 0x7FFE873F8440
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE873F8540
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void DetachParent(){} // RVA: 0x7FFE873F85A0
    }

    public class JsonNode : Object
    {
        public System.Text.Json.Nodes.JsonNode _parent; // 0x10
        public System.Nullable`1<System.Text.Json.Nodes.JsonNodeOptions> _options; // 0x18
        public bool hasValue; // 0x10
        public System.Text.Json.Nodes.JsonNodeOptions value; // 0x11
        public object field_4; // 0x32A

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFE873F89A0
        public void .ctor(){} // RVA: 0x7FFE850AB060
        public void AsArray(){} // RVA: 0x7FFE873F89F0
        public void AsObject(){} // RVA: 0x7FFE873F8A60
        public void AsValue(){} // RVA: 0x7FFE873F8AD0
        public void get_Parent(){} // RVA: 0x7FFE81116380
        public void set_Parent(){} // RVA: 0x7FFE810FCE30
        public void GetPath(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void get_Root(){} // RVA: 0x7FFE86B7CF90
        public void GetValue(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE873F8E90 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE873F8FE0 | overloaded x2
        public void DeepClone(){} // RVA: 0x7FFE844800F0
        public void DeepCloneCore(){} // RVA: 0x7FFE80E2E2E0
        public void GetValueKind(){} // RVA: 0x7FFE870EE950
        public void GetValueKindCore(){} // RVA: 0x7FFE80E2F150
        public void GetPropertyName(){} // RVA: 0x7FFE873F9070
        public void GetElementIndex(){} // RVA: 0x7FFE873F91C0
        public void DeepEquals(){} // RVA: 0x7FFE873F92B0
        public void DeepEqualsCore(){} // RVA: 0x7FFE80E2F3B0
        public void ReplaceWith(){} // RVA: 0x7FFE810A1420
        public void AssignParent(){} // RVA: 0x7FFE873F92D0
        public void ConvertFromValue(){} // RVA: 0x7FFE810A1420
        public void op_Implicit(){} // RVA: 0x7FFE873FAB00 | overloaded x33
        public void op_Explicit(){} // RVA: 0x7FFE873FBB90 | overloaded x33
        public void Parse(){} // RVA: 0x7FFE873FBED0 | overloaded x4
        public void ParseAsync(){} // RVA: 0x7FFE873FBFF0
        public void ToJsonString(){} // RVA: 0x7FFE873FC220
        public void ToString(){} // RVA: 0x7FFE873FC400
        public void WriteTo(){} // RVA: 0x7FFE80E4F230
        public void WriteToPooledBuffer(){} // RVA: 0x7FFE873FC6A0
    }

    public class JsonNodeOptions : ValueType
    {
        public bool _propertyNameCaseInsensitive; // 0x10

        // ── Methods ──
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x7FFE82BC9920
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x7FFE82BC9930
    }

    public class JsonObject : JsonNode
    {
        public System.Nullable`1<System.Text.Json.JsonElement> _jsonElement; // 0x20
        public System.Text.Json.JsonPropertyDictionary`1<System.Text.Json.Nodes.JsonNode> _dictionary; // 0x38
        public object field_2; // 0x116
        public object field_3; // 0x117

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86E90010 | overloaded x2
        public void TryGetPropertyValue(){} // RVA: 0x7FFE86E90130
        public void WriteTo(){} // RVA: 0x7FFE86E90200
        public void GetItem(){} // RVA: 0x7FFE86E90680
        public void SetItem(){} // RVA: 0x7FFE86E90760
        public void DetachParent(){} // RVA: 0x7FFE86E90980
        public void Add(){} // RVA: 0x7FFE86E90B40 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE86E90CC0
        public void ContainsKey(){} // RVA: 0x7FFE86E90FD0
        public void get_Count(){} // RVA: 0x7FFE86E910A0
        public void Remove(){} // RVA: 0x7FFE86E91100
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Contains(){} // RVA: 0x7FFE86E91240
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.CopyTo(){} // RVA: 0x7FFE86E912B0
        public void GetEnumerator(){} // RVA: 0x7FFE86E91330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Remove(){} // RVA: 0x7FFE86E91390
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Keys(){} // RVA: 0x7FFE86E91500
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Values(){} // RVA: 0x7FFE86E91650
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.TryGetValue(){} // RVA: 0x7FFE86E916C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86E91740
        public void InitializeIfRequired(){} // RVA: 0x7FFE86E917A0
    }

    public class JsonValue : JsonNode
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE810A1420 | overloaded x37
        public void .ctor(){} // RVA: 0x7FFE850AB060
        public void GetPath(){} // RVA: 0x7FFE87400C40
        public void TryGetValue(){} // RVA: 0x7FFE80E2F3B0
        public void VerifyJsonElementIsNotArrayOrObject(){} // RVA: 0x7FFE87400C70
    }

    public class JsonValueCustomized`1 : JsonValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void WriteTo(){} // RVA: 0x7FFE80E4F230
        public void DeepCloneCore(){} // RVA: 0x7FFE80E2E2E0
    }

    public class JsonValuePrimitive`1 : JsonValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void WriteTo(){} // RVA: 0x7FFE80E4F230
        public void DeepCloneCore(){} // RVA: 0x7FFE80E2E2E0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class JsonValueTrimmable`1 : JsonValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void WriteTo(){} // RVA: 0x7FFE80E4F230
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void GetValue(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE80E2F3B0
        public void GetValueKindCore(){} // RVA: 0x7FFE80E2F150
        public void DeepEqualsCore(){} // RVA: 0x7FFE80E2F3B0
        public void ConvertJsonElement(){} // RVA: 0x7FFE810A1420
        public void TryConvertJsonElement(){} // RVA: 0x7FFE80E2F3B0
    }

}