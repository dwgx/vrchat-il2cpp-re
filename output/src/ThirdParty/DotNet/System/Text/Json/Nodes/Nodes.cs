// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Nodes
// Classes: 9
// Methods: 215

namespace ThirdParty.DotNet.System.Text.Json.Nodes
{
    public class JsonArray
    {
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

    public class JsonNode
    {
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

    public class JsonNodeOptions
    {
        // ── Methods ──
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x1E40360
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x1E40370
    }

    public class JsonObject
    {
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

    public class JsonValue
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x283FA0 | overloaded x37
        public void .ctor(){} // RVA: 0x4470200
        public void GetPath(){} // RVA: 0x68C1970
        public void TryGetValue(){} // RVA: 0xDE40
        public void VerifyJsonElementIsNotArrayOrObject(){} // RVA: 0x68C19A0
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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void GetValue(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0xDE40
        public void GetValueKindCore(){} // RVA: 0xDBE0
        public void DeepEqualsCore(){} // RVA: 0xDE40
        public void ConvertJsonElement(){} // RVA: 0x283FA0
        public void TryConvertJsonElement(){} // RVA: 0xDE40
    }

}