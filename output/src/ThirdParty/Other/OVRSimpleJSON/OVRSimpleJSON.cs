// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVRSimpleJSON
// Classes: 2
// Methods: 127

namespace ThirdParty.Other.OVRSimpleJSON
{
    public class JSONLazyCreator : JSONNode
    {
        public Input.nentTypes Tag; // 0x10
        public string Item; // 0x18

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFD4EACE2C0
        public void GetEnumerator(){} // RVA: 0x7FFD52E55970
        public void .ctor(){} // RVA: 0x7FFD4E90C240 | overloaded x2
        public void Set(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD53D8E0D0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFD53D8E140 | overloaded x2
        public void Add(){} // RVA: 0x7FFD53D8E2B0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFD53D8E370
        public void op_Inequality(){} // RVA: 0x7FFD53D8E380
        public void Equals(){} // RVA: 0x7FFD53D8E370
        public void GetHashCode(){} // RVA: 0x7FFD4E919180
        public void get_AsInt(){} // RVA: 0x7FFD53D8E390
        public void set_AsInt(){} // RVA: 0x7FFD53D8E400
        public void get_AsFloat(){} // RVA: 0x7FFD53D8E480
        public void set_AsFloat(){} // RVA: 0x7FFD53D8E4F0
        public void get_AsDouble(){} // RVA: 0x7FFD53D8E570
        public void set_AsDouble(){} // RVA: 0x7FFD53D8E5E0
        public void get_AsLong(){} // RVA: 0x7FFD53D8E650
        public void set_AsLong(){} // RVA: 0x7FFD53D8E790
        public void get_AsBool(){} // RVA: 0x7FFD53D8E8E0
        public void set_AsBool(){} // RVA: 0x7FFD53D8E950
        public void get_AsArray(){} // RVA: 0x7FFD53D8E9C0
        public void get_AsObject(){} // RVA: 0x7FFD53D8EA40
        public void WriteToStringBuilder(){} // RVA: 0x7FFD53D8EAC0
    }

    public class JSONNode : Object
    {
        public bool Tag;
        public bool Item; // 0x1
        public em.MarkAborted.izeDefaultCase Item; // 0xFFFFFFFF
        public Input.nteractionProfile Value; // 0x4
        public Input.nteractionProfile Count; // 0x8
        public Input.nteractionProfile IsNumber; // 0xC

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFD4E079960
        public void get_Item(){} // RVA: 0x7FFD4E919180 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFD53D84BC0
        public void set_Value(){} // RVA: 0x7FFD4E341310
        public void get_Count(){} // RVA: 0x7FFD4E919180
        public void get_IsNumber(){} // RVA: 0x7FFD4E341320
        public void get_IsString(){} // RVA: 0x7FFD4E341320
        public void get_IsBoolean(){} // RVA: 0x7FFD4E341320
        public void get_IsNull(){} // RVA: 0x7FFD4E341320
        public void get_IsArray(){} // RVA: 0x7FFD4E341320
        public void get_IsObject(){} // RVA: 0x7FFD4E341320
        public void get_Inline(){} // RVA: 0x7FFD4E341320
        public void set_Inline(){} // RVA: 0x7FFD4E341310
        public void Add(){} // RVA: 0x7FFD53D84C00 | overloaded x2
        public void Remove(){} // RVA: 0x7FFD4F2B2FB0 | overloaded x3
        public void get_Children(){} // RVA: 0x7FFD53D84C60
        public void get_DeepChildren(){} // RVA: 0x7FFD53D84CB0
        public void ToString(){} // RVA: 0x7FFD53D84E00 | overloaded x2
        public void WriteToStringBuilder(){}
        public void GetEnumerator(){}
        public void get_Linq(){} // RVA: 0x7FFD53D84EB0
        public void get_Keys(){} // RVA: 0x7FFD53D84F10
        public void get_Values(){} // RVA: 0x7FFD53D84F10
        public void get_AsDouble(){} // RVA: 0x7FFD53D84FB0
        public void set_AsDouble(){} // RVA: 0x7FFD53D85110
        public void get_AsInt(){} // RVA: 0x7FFD53D85230
        public void set_AsInt(){} // RVA: 0x7FFD53D85250
        public void get_AsFloat(){} // RVA: 0x7FFD53D85270
        public void set_AsFloat(){} // RVA: 0x7FFD53D85290
        public void get_AsBool(){} // RVA: 0x7FFD53D852B0
        public void set_AsBool(){} // RVA: 0x7FFD53D85400
        public void get_AsLong(){} // RVA: 0x7FFD53D85480
        public void set_AsLong(){} // RVA: 0x7FFD53D85570
        public void get_AsArray(){} // RVA: 0x7FFD53D855B0
        public void get_AsObject(){} // RVA: 0x7FFD53D85640
        public void op_Implicit(){} // RVA: 0x7FFD53D873C0 | overloaded x25
        public void op_Equality(){} // RVA: 0x7FFD53D85BA0
        public void op_Inequality(){} // RVA: 0x7FFD53D85D30
        public void Equals(){} // RVA: 0x7FFD5072B460
        public void GetHashCode(){} // RVA: 0x7FFD5381AE70
        public void get_EscapeBuilder(){} // RVA: 0x7FFD53D85D50
        public void Escape(){} // RVA: 0x7FFD53D85EA0
        public void ParseElement(){} // RVA: 0x7FFD53D86350
        public void Parse(){} // RVA: 0x7FFD53D86660
        public void GetContainer(){} // RVA: 0x7FFD53D86D70
        public void ReadVector2(){} // RVA: 0x7FFD53D876F0 | overloaded x3
        public void WriteVector2(){} // RVA: 0x7FFD53D87750
        public void ReadVector3(){} // RVA: 0x7FFD53D87C60 | overloaded x3
        public void WriteVector3(){} // RVA: 0x7FFD53D87CF0
        public void ReadVector4(){} // RVA: 0x7FFD53D881B0 | overloaded x2
        public void WriteVector4(){} // RVA: 0x7FFD53D88230
        public void ReadQuaternion(){} // RVA: 0x7FFD53D887C0 | overloaded x2
        public void WriteQuaternion(){} // RVA: 0x7FFD53D88840
        public void ReadRect(){} // RVA: 0x7FFD53D88DD0 | overloaded x2
        public void WriteRect(){} // RVA: 0x7FFD53D88E10
        public void ReadRectOffset(){} // RVA: 0x7FFD53D89400 | overloaded x2
        public void WriteRectOffset(){} // RVA: 0x7FFD53D894A0
        public void ReadMatrix(){} // RVA: 0x7FFD53D899A0
        public void WriteMatrix(){} // RVA: 0x7FFD53D89AA0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}