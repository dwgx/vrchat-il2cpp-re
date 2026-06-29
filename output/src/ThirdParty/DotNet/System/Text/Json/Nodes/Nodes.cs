// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Nodes
// Classes: 18
// Methods: 183

namespace ThirdParty.DotNet.System.Text.Json.Nodes
{
    public class JsonArray : JsonNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6A65E0
        public void GetValueKindCore(){} // RVA: 0x7AB40BF50
        public void DeepCloneCore(){} // RVA: 0x7AE6A5CA0
        public void DeepEqualsCore(){} // RVA: 0x7AE6A6100
        public void GetElementIndex(){} // RVA: 0x7AE6A62E0
        public void GetValues(){} // RVA: 0x7A7E00680
        public void InitializeFromArray(){} // RVA: 0x7AE6A6370
        public void Create(){} // RVA: 0x7AE6A64C0
        public void Add(){} // RVA: 0x7AE6A7570
        public void get_List(){} // RVA: 0x7AE6A6700
        public void GetItem(){} // RVA: 0x7AE6A6720
        public void SetItem(){} // RVA: 0x7AE6A67A0
        public void GetPath(){} // RVA: 0x7AE6A6940
        public void WriteTo(){} // RVA: 0x7AE6A6B00
        public void InitializeList(){} // RVA: 0x7AE6A6EC0
        public void GetUnderlyingRepresentation(){} // RVA: 0x7AE6A7450
        public void get_Count(){} // RVA: 0x7AE6A7510
        public void Clear(){} // RVA: 0x7AE6A7620
        public void Contains(){} // RVA: 0x7AE6A7760
        public void IndexOf(){} // RVA: 0x7AE6A7820
        public void Insert(){} // RVA: 0x7AE6A78B0
        public void Remove(){} // RVA: 0x7AE6A7970
        public void RemoveAt(){} // RVA: 0x7AE6A7A50
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.CopyTo(){} // RVA: 0x7AE6A7B80
        public void GetEnumerator(){} // RVA: 0x7AE6A7C10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE6A7D10
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void DetachParent(){} // RVA: 0x7AE6A7D70
    }

    public class JsonArray : JsonNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE139EE0
        public void get_List(){} // RVA: 0x7AE13A000
        public void GetItem(){} // RVA: 0x7AE13A020
        public void SetItem(){} // RVA: 0x7AE13A0A0
        public void WriteTo(){} // RVA: 0x7AE13A220
        public void CreateNodes(){} // RVA: 0x7AE13A4D0
        public void get_Count(){} // RVA: 0x7AE13A8C0
        public void Add(){} // RVA: 0x7AE13A910
        public void Clear(){} // RVA: 0x7AE13A9B0
        public void Contains(){} // RVA: 0x7AE13AB50
        public void IndexOf(){} // RVA: 0x7AE13AC10
        public void Insert(){} // RVA: 0x7AE13ACA0
        public void Remove(){} // RVA: 0x7AE13AD60
        public void RemoveAt(){} // RVA: 0x7AE13AE30
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.CopyTo(){} // RVA: 0x7AE13AF50
        public void GetEnumerator(){} // RVA: 0x7AE13AFE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE13B0E0
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void DetachParent(){} // RVA: 0x7AE13B140
    }

    public class JsonNode : Object
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x7AE6A8180
        public void .ctor(){} // RVA: 0x7AC25E3B0
        public void AsArray(){} // RVA: 0x7AE6A81D0
        public void AsObject(){} // RVA: 0x7AE6A8240
        public void AsValue(){} // RVA: 0x7AE6A82B0
        public void get_Parent(){} // RVA: 0x7A80F2570
        public void set_Parent(){} // RVA: 0x7A80D8E20
        public void GetPath(){} // RVA: 0x7A7E18890
        public void get_Root(){} // RVA: 0x7ADE289E0
        public void GetValue(){} // RVA: 0x7A8051B10
        public void get_Item(){} // RVA: 0x7AE6A8690
        public void set_Item(){} // RVA: 0x7AE6A87E0
        public void DeepClone(){} // RVA: 0x7AB5DC320
        public void DeepCloneCore(){} // RVA: 0x7A7E00680
        public void GetValueKind(){} // RVA: 0x7AE39DFD0
        public void GetValueKindCore(){} // RVA: 0x7A7E01900
        public void GetPropertyName(){} // RVA: 0x7AE6A8870
        public void GetElementIndex(){} // RVA: 0x7AE6A89C0
        public void DeepEquals(){} // RVA: 0x7AE6A8AB0
        public void DeepEqualsCore(){} // RVA: 0x7A7E019D0
        public void ReplaceWith(){} // RVA: 0x7A8051B10
        public void AssignParent(){} // RVA: 0x7AE6A8AD0
        public void ConvertFromValue(){} // RVA: 0x7A8051B10
        public void op_Implicit(){} // RVA: 0x7AE6AA300
        public void op_Explicit(){} // RVA: 0x7AE6AB390
        public void Parse(){} // RVA: 0x7AE6AB6D0
        public void ParseAsync(){} // RVA: 0x7AE6AB7F0
        public void ToJsonString(){} // RVA: 0x7AE6ABA10
        public void ToString(){} // RVA: 0x7AE6ABC00
        public void WriteTo(){} // RVA: 0x7A7E18890
        public void WriteToPooledBuffer(){} // RVA: 0x7AE6ABEC0
    }

    public class JsonNode : Object
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x7AE13B1A0
        public void .ctor(){} // RVA: 0x7AC25E3B0
        public void AsArray(){} // RVA: 0x7AE13B1F0
        public void AsObject(){} // RVA: 0x7AE13B2C0
        public void get_Parent(){} // RVA: 0x7A80F2570
        public void set_Parent(){} // RVA: 0x7A80D8E20
        public void get_Item(){} // RVA: 0x7AE13B460
        public void set_Item(){} // RVA: 0x7AE13B550
        public void AssignParent(){} // RVA: 0x7AE13B590
        public void ToString(){} // RVA: 0x7AE13B5E0
        public void WriteTo(){} // RVA: 0x7A7E18890
    }

    public class JsonNodeOptions : ValueType
    {
        // ── Methods ──
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x7A767CAD0
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x7A767CAE0
    }

    public class JsonNodeOptions : ValueType
    {
        // ── Methods ──
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x7A767CAD0
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x7A767CAE0
    }

    public class JsonObject : JsonNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE13BBF0
        public void TryGetPropertyValue(){} // RVA: 0x7AE13BD10
        public void WriteTo(){} // RVA: 0x7AE13BDE0
        public void GetItem(){} // RVA: 0x7AE13C290
        public void SetItem(){} // RVA: 0x7AE13C370
        public void DetachParent(){} // RVA: 0x7AE13C590
        public void Add(){} // RVA: 0x7AE13C750
        public void Clear(){} // RVA: 0x7AE13C8D0
        public void ContainsKey(){} // RVA: 0x7AE13CBE0
        public void get_Count(){} // RVA: 0x7AE13CCB0
        public void Remove(){} // RVA: 0x7AE13CD10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Contains(){} // RVA: 0x7AE13CE50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.CopyTo(){} // RVA: 0x7AE13CEC0
        public void GetEnumerator(){} // RVA: 0x7AE13CF40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Remove(){} // RVA: 0x7AE13CFA0
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Keys(){} // RVA: 0x7AE13D110
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Values(){} // RVA: 0x7AE13D260
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.TryGetValue(){} // RVA: 0x7AE13D2D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE13D350
        public void InitializeIfRequired(){} // RVA: 0x7AE13D3B0
    }

    public class JsonObject : JsonNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE6AC7E0
        public void Create(){} // RVA: 0x7AE6AC6C0
        public void get_Dictionary(){} // RVA: 0x7AE6AC900
        public void DeepCloneCore(){} // RVA: 0x7AE6AC920
        public void GetPropertyName(){} // RVA: 0x7AE6ACF70
        public void TryGetPropertyValue(){} // RVA: 0x7AE6AD050
        public void WriteTo(){} // RVA: 0x7AE6AD120
        public void GetValueKindCore(){} // RVA: 0x7A81BD750
        public void DeepEqualsCore(){} // RVA: 0x7AE6AD4C0
        public void GetItem(){} // RVA: 0x7AE6AD7D0
        public void GetPath(){} // RVA: 0x7AE6AD8B0
        public void SetItem(){} // RVA: 0x7AE6ADAB0
        public void DetachParent(){} // RVA: 0x7AE13B140
        public void Add(){} // RVA: 0x7AE6ADCB0
        public void Clear(){} // RVA: 0x7AE6ADD10
        public void ContainsKey(){} // RVA: 0x7AE6ADFD0
        public void get_Count(){} // RVA: 0x7AE6AE090
        public void Remove(){} // RVA: 0x7AE6AE0F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Contains(){} // RVA: 0x7AE6AE210
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.CopyTo(){} // RVA: 0x7AE6AE290
        public void GetEnumerator(){} // RVA: 0x7AE6AE310
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.Remove(){} // RVA: 0x7AE6AE3B0
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Keys(){} // RVA: 0x7AE6AE4F0
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.get_Values(){} // RVA: 0x7AE6AE650
        public void System.Collections.Generic.IDictionary<System.String,System.Text.Json.Nodes.JsonNode>.TryGetValue(){} // RVA: 0x7AE6AE6C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Text.Json.Nodes.JsonNode>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE6AE740
        public void InitializeDictionary(){} // RVA: 0x7AE6AE7E0
        public void GetUnderlyingRepresentation(){} // RVA: 0x7AE6A7450
    }

    public class JsonValue : JsonNode
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7AC25E3B0
        public void GetPath(){} // RVA: 0x7AE6B04A0
        public void TryGetValue(){} // RVA: 0x7A7E019D0
        public void VerifyJsonElementIsNotArrayOrObject(){} // RVA: 0x7AE6B04D0
    }

    public class JsonValue : JsonNode
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC25E3B0
    }

    public class JsonValueCustomized`1 : JsonValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void WriteTo(){} // RVA: 0x7A7E18890
        public void DeepCloneCore(){} // RVA: 0x7A7E00680
    }

    public class JsonValuePrimitive`1 : JsonValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void WriteTo(){} // RVA: 0x7A7E18890
        public void DeepCloneCore(){} // RVA: 0x7A7E00680
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class JsonValueTrimmable`1 : JsonValue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void WriteTo(){} // RVA: 0x7A7E18890
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void GetValue(){} // RVA: 0x7A8051B10
        public void TryGetValue(){} // RVA: 0x7A7E019D0
        public void GetValueKindCore(){} // RVA: 0x7A7E01900
        public void DeepEqualsCore(){} // RVA: 0x7A7E019D0
        public void ConvertJsonElement(){} // RVA: 0x7A8051B10
        public void TryConvertJsonElement(){} // RVA: 0x7A7E019D0
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8051B10
        public void get_Value(){} // RVA: 0x7A8051B10
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80804D0
        public void get_Value(){} // RVA: 0x7A80804D0
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80804D0
        public void GetValue(){} // RVA: 0x7A8051B10
        public void TryGetValue(){} // RVA: 0x7A7E019D0
        public void GetValueKindCore(){} // RVA: 0x7AB57FA00
        public void DeepEqualsCore(){} // RVA: 0x7AB57FD70
        public void ConvertJsonElement(){} // RVA: 0x7A8051B10
        public void TryConvertJsonElement(){} // RVA: 0x7A7E019D0
    }

    public class JsonValue`1 : JsonValue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80804D0
        public void GetValue(){} // RVA: 0x7A8051B10
        public void TryGetValue(){} // RVA: 0x7A7E019D0
        public void GetValueKindCore(){} // RVA: 0x7AB57FA00
        public void DeepEqualsCore(){} // RVA: 0x7AB57FD70
        public void ConvertJsonElement(){} // RVA: 0x7A8051B10
        public void TryConvertJsonElement(){} // RVA: 0x7A7E019D0
    }

}