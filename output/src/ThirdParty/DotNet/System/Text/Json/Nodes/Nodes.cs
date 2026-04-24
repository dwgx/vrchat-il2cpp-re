// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Text.Json.Nodes
// Classes: 8
// Methods: 192

namespace ThirdParty.DotNet.System.Text.Json.Nodes
{
    public class JsonArray : JsonNode
    {
        public aphy<inDataView.ase64> List; // 0x20
        public URA.woDigitYearMax<tNegative> Count; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5446E680 | overloaded x4
        public void GetValueKindCore(){} // RVA: 0x7FFD513681B0
        public void DeepCloneCore(){} // RVA: 0x7FFD5446DD30
        public void DeepEqualsCore(){} // RVA: 0x7FFD5446E1A0
        public void GetElementIndex(){} // RVA: 0x7FFD5446E380
        public void GetValues(){} // RVA: 0x7FFD4E078E90
        public void InitializeFromArray(){} // RVA: 0x7FFD5446E410
        public void Create(){} // RVA: 0x7FFD5446E560
        public void Add(){} // RVA: 0x7FFD5446F5E0 | overloaded x2
        public void get_List(){} // RVA: 0x7FFD5446E7A0
        public void GetItem(){} // RVA: 0x7FFD5446E7C0
        public void SetItem(){} // RVA: 0x7FFD5446E840
        public void GetPath(){} // RVA: 0x7FFD5446E9E0
        public void WriteTo(){} // RVA: 0x7FFD5446EBA0
        public void InitializeList(){} // RVA: 0x7FFD5446EF50
        public void GetUnderlyingRepresentation(){} // RVA: 0x7FFD5446F4C0
        public void get_Count(){} // RVA: 0x7FFD5446F580
        public void Clear(){} // RVA: 0x7FFD5446F690
        public void Contains(){} // RVA: 0x7FFD5446F7E0
        public void IndexOf(){} // RVA: 0x7FFD5446F8A0
        public void Insert(){} // RVA: 0x7FFD5446F930
        public void Remove(){} // RVA: 0x7FFD5446F9F0
        public void RemoveAt(){} // RVA: 0x7FFD5446FAD0
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.CopyTo(){} // RVA: 0x7FFD5446FC00
        public void GetEnumerator(){} // RVA: 0x7FFD5446FC90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5446FD90
        public void System.Collections.Generic.ICollection<System.Text.Json.Nodes.JsonNode>.get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void DetachParent(){} // RVA: 0x7FFD5446FDF0
    }

    public class JsonNode : Object
    {
        public tNegative Options; // 0x10
        public aphy<4_0> Parent; // 0x18

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFD544701F0
        public void .ctor(){} // RVA: 0x7FFD52144B10
        public void AsArray(){} // RVA: 0x7FFD54470240
        public void AsObject(){} // RVA: 0x7FFD544702B0
        public void AsValue(){} // RVA: 0x7FFD54470320
        public void get_Parent(){} // RVA: 0x7FFD4E35C380
        public void set_Parent(){} // RVA: 0x7FFD4E342E30
        public void GetPath(){} // RVA: 0x7FFD4E099B30 | overloaded x2
        public void get_Root(){} // RVA: 0x7FFD53BF3860
        public void GetValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD544706E0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFD54470830 | overloaded x2
        public void DeepClone(){} // RVA: 0x7FFD4F37BE50
        public void DeepCloneCore(){} // RVA: 0x7FFD4E078E90
        public void GetValueKind(){} // RVA: 0x7FFD54166490
        public void GetValueKindCore(){} // RVA: 0x7FFD4E079D00
        public void GetPropertyName(){} // RVA: 0x7FFD544708C0
        public void GetElementIndex(){} // RVA: 0x7FFD54470A10
        public void DeepEquals(){} // RVA: 0x7FFD54470B00
        public void DeepEqualsCore(){} // RVA: 0x7FFD4E079F60
        public void ReplaceWith(){} // RVA: 0x7FFD4E2ADC40
        public void AssignParent(){} // RVA: 0x7FFD54470B20
        public void ConvertFromValue(){} // RVA: 0x7FFD4E2ADC40
        public void op_Implicit(){} // RVA: 0x7FFD54472350 | overloaded x33
        public void op_Explicit(){} // RVA: 0x7FFD544733E0 | overloaded x33
        public void Parse(){} // RVA: 0x7FFD54473720 | overloaded x4
        public void ParseAsync(){} // RVA: 0x7FFD54473840
        public void ToJsonString(){} // RVA: 0x7FFD54473A70
        public void ToString(){} // RVA: 0x7FFD54473C50
        public void WriteTo(){} // RVA: 0x7FFD4E099B30
        public void WriteToPooledBuffer(){} // RVA: 0x7FFD54473EF0
    }

    public class JsonNodeOptions : ValueType
    {
        public bool PropertyNameCaseInsensitive; // 0x10

        // ── Methods ──
        public void get_PropertyNameCaseInsensitive(){} // RVA: 0x7FFD4FD7DDF0
        public void set_PropertyNameCaseInsensitive(){} // RVA: 0x7FFD4FD7DE00
    }

    public class JsonValue : JsonNode
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E2ADC40 | overloaded x37
        public void .ctor(){} // RVA: 0x7FFD52144B10
        public void GetPath(){} // RVA: 0x7FFD54478490
        public void TryGetValue(){} // RVA: 0x7FFD4E079F60
        public void VerifyJsonElementIsNotArrayOrObject(){} // RVA: 0x7FFD544784C0
    }

    public class JsonValueCustomized`1 : JsonValue`1
    {
        public ndlingValue.tions.Generic.IAsyncEnumerator<T>.MoveNextAsync<T1717649312> _jsonTypeInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void WriteTo(){} // RVA: 0x7FFD4E099B30
        public void DeepCloneCore(){} // RVA: 0x7FFD4E078E90
    }

    public class JsonValuePrimitive`1 : JsonValue`1
    {
        public inDataView.CannotBeObjectOrArray s_defaultOptions;
        public ngCommas.get_transformPoleAxis<T1717649424> _converter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void WriteTo(){} // RVA: 0x7FFD4E099B30
        public void DeepCloneCore(){} // RVA: 0x7FFD4E078E90
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class JsonValueTrimmable`1 : JsonValue`1
    {
        public ndlingValue.tions.Generic.IAsyncEnumerator<T>.MoveNextAsync<T1717693488> _jsonTypeInfo;
        public ngCommas.get_transformPoleAxis<T1717693488> _converter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void WriteTo(){} // RVA: 0x7FFD4E099B30
    }

    public class JsonValue`1 : JsonValue
    {
        public T1717693472 _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void GetValue(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E079F60
        public void GetValueKindCore(){} // RVA: 0x7FFD4E079D00
        public void DeepEqualsCore(){} // RVA: 0x7FFD4E079F60
        public void ConvertJsonElement(){} // RVA: 0x7FFD4E2ADC40
        public void TryConvertJsonElement(){} // RVA: 0x7FFD4E079F60
    }

}