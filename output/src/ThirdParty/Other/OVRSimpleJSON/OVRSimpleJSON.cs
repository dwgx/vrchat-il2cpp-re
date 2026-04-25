// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVRSimpleJSON
// Classes: 9
// Methods: 210

namespace ThirdParty.Other.OVRSimpleJSON
{
    public class JSON : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFAC896EB10
    }

    public class JSONArray : JSONNode
    {
        public System.Collections.Generic.List`1<OVRSimpleJSON.JSONNode> Inline; // 0x10
        public bool Tag; // 0x18

        // ── Methods ──
        public void get_Inline(){} // RVA: 0x7FFAC2F3C4E0
        public void set_Inline(){} // RVA: 0x7FFAC2F3C4F0
        public void get_Tag(){} // RVA: 0x7FFAC3013AF0
        public void get_IsArray(){} // RVA: 0x7FFAC3006850
        public void GetEnumerator(){} // RVA: 0x7FFAC896AD30
        public void get_Item(){} // RVA: 0x7FFAC896B080 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC896B0E0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC896B180
        public void Add(){} // RVA: 0x7FFAC896B1D0
        public void Remove(){} // RVA: 0x7FFAC896B340 | overloaded x2
        public void get_Children(){} // RVA: 0x7FFAC896B3A0
        public void WriteToStringBuilder(){} // RVA: 0x7FFAC896B450
        public void .ctor(){} // RVA: 0x7FFAC896B660
    }

    public class JSONBool : JSONNode
    {
        public bool Tag; // 0x10

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFAC36A9850
        public void get_IsBoolean(){} // RVA: 0x7FFAC3006850
        public void GetEnumerator(){} // RVA: 0x7FFAC7A35970
        public void get_Value(){} // RVA: 0x7FFAC896DA50
        public void set_Value(){} // RVA: 0x7FFAC896DAE0
        public void get_AsBool(){} // RVA: 0x7FFAC2FEB5E0
        public void set_AsBool(){} // RVA: 0x7FFAC2FEB5F0
        public void .ctor(){} // RVA: 0x7FFAC896D690 | overloaded x2
        public void WriteToStringBuilder(){} // RVA: 0x7FFAC896DBE0
        public void Equals(){} // RVA: 0x7FFAC896DC60
        public void GetHashCode(){} // RVA: 0x7FFAC896DCF0
    }

    public class JSONLazyCreator : JSONNode
    {
        public OVRSimpleJSON.JSONNode Tag; // 0x10
        public string Item; // 0x18

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFAC36AE2C0
        public void GetEnumerator(){} // RVA: 0x7FFAC7A35970
        public void .ctor(){} // RVA: 0x7FFAC34EC240 | overloaded x2
        public void Set(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC896E0D0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC896E140 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC896E2B0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC896E370
        public void op_Inequality(){} // RVA: 0x7FFAC896E380
        public void Equals(){} // RVA: 0x7FFAC896E370
        public void GetHashCode(){} // RVA: 0x7FFAC34F9180
        public void get_AsInt(){} // RVA: 0x7FFAC896E390
        public void set_AsInt(){} // RVA: 0x7FFAC896E400
        public void get_AsFloat(){} // RVA: 0x7FFAC896E480
        public void set_AsFloat(){} // RVA: 0x7FFAC896E4F0
        public void get_AsDouble(){} // RVA: 0x7FFAC896E570
        public void set_AsDouble(){} // RVA: 0x7FFAC896E5E0
        public void get_AsLong(){} // RVA: 0x7FFAC896E650
        public void set_AsLong(){} // RVA: 0x7FFAC896E790
        public void get_AsBool(){} // RVA: 0x7FFAC896E8E0
        public void set_AsBool(){} // RVA: 0x7FFAC896E950
        public void get_AsArray(){} // RVA: 0x7FFAC896E9C0
        public void get_AsObject(){} // RVA: 0x7FFAC896EA40
        public void WriteToStringBuilder(){} // RVA: 0x7FFAC896EAC0
    }

    public class JSONNode : Object
    {
        public bool Tag;
        public bool Item; // 0x1
        public System.Text.StringBuilder Item; // 0xFFFF
        public 0x6B1ADDF8 Value; // 0x4
        public 0x6B1ADDF8 Count; // 0x8
        public 0x6B1ADDF8 IsNumber; // 0xC

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFAC2C59960
        public void get_Item(){} // RVA: 0x7FFAC34F9180 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC8964BC0
        public void set_Value(){} // RVA: 0x7FFAC2F21310
        public void get_Count(){} // RVA: 0x7FFAC34F9180
        public void get_IsNumber(){} // RVA: 0x7FFAC2F21320
        public void get_IsString(){} // RVA: 0x7FFAC2F21320
        public void get_IsBoolean(){} // RVA: 0x7FFAC2F21320
        public void get_IsNull(){} // RVA: 0x7FFAC2F21320
        public void get_IsArray(){} // RVA: 0x7FFAC2F21320
        public void get_IsObject(){} // RVA: 0x7FFAC2F21320
        public void get_Inline(){} // RVA: 0x7FFAC2F21320
        public void set_Inline(){} // RVA: 0x7FFAC2F21310
        public void Add(){} // RVA: 0x7FFAC8964C00 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAC3E92FB0 | overloaded x3
        public void get_Children(){} // RVA: 0x7FFAC8964C60
        public void get_DeepChildren(){} // RVA: 0x7FFAC8964CB0
        public void ToString(){} // RVA: 0x7FFAC8964E00 | overloaded x2
        public void WriteToStringBuilder(){}
        public void GetEnumerator(){}
        public void get_Linq(){} // RVA: 0x7FFAC8964EB0
        public void get_Keys(){} // RVA: 0x7FFAC8964F10
        public void get_Values(){} // RVA: 0x7FFAC8964F10
        public void get_AsDouble(){} // RVA: 0x7FFAC8964FB0
        public void set_AsDouble(){} // RVA: 0x7FFAC8965110
        public void get_AsInt(){} // RVA: 0x7FFAC8965230
        public void set_AsInt(){} // RVA: 0x7FFAC8965250
        public void get_AsFloat(){} // RVA: 0x7FFAC8965270
        public void set_AsFloat(){} // RVA: 0x7FFAC8965290
        public void get_AsBool(){} // RVA: 0x7FFAC89652B0
        public void set_AsBool(){} // RVA: 0x7FFAC8965400
        public void get_AsLong(){} // RVA: 0x7FFAC8965480
        public void set_AsLong(){} // RVA: 0x7FFAC8965570
        public void get_AsArray(){} // RVA: 0x7FFAC89655B0
        public void get_AsObject(){} // RVA: 0x7FFAC8965640
        public void op_Implicit(){} // RVA: 0x7FFAC89673C0 | overloaded x25
        public void op_Equality(){} // RVA: 0x7FFAC8965BA0
        public void op_Inequality(){} // RVA: 0x7FFAC8965D30
        public void Equals(){} // RVA: 0x7FFAC530B460
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void get_EscapeBuilder(){} // RVA: 0x7FFAC8965D50
        public void Escape(){} // RVA: 0x7FFAC8965EA0
        public void ParseElement(){} // RVA: 0x7FFAC8966350
        public void Parse(){} // RVA: 0x7FFAC8966660
        public void GetContainer(){} // RVA: 0x7FFAC8966D70
        public void ReadVector2(){} // RVA: 0x7FFAC89676F0 | overloaded x3
        public void WriteVector2(){} // RVA: 0x7FFAC8967750
        public void ReadVector3(){} // RVA: 0x7FFAC8967C60 | overloaded x3
        public void WriteVector3(){} // RVA: 0x7FFAC8967CF0
        public void ReadVector4(){} // RVA: 0x7FFAC89681B0 | overloaded x2
        public void WriteVector4(){} // RVA: 0x7FFAC8968230
        public void ReadQuaternion(){} // RVA: 0x7FFAC89687C0 | overloaded x2
        public void WriteQuaternion(){} // RVA: 0x7FFAC8968840
        public void ReadRect(){} // RVA: 0x7FFAC8968DD0 | overloaded x2
        public void WriteRect(){} // RVA: 0x7FFAC8968E10
        public void ReadRectOffset(){} // RVA: 0x7FFAC8969400 | overloaded x2
        public void WriteRectOffset(){} // RVA: 0x7FFAC89694A0
        public void ReadMatrix(){} // RVA: 0x7FFAC89699A0
        public void WriteMatrix(){} // RVA: 0x7FFAC8969AA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class JSONNull : JSONNode
    {
        public OVRSimpleJSON.JSONNull Tag;
        public bool IsNull; // 0x8

        // ── Methods ──
        public void CreateOrGet(){} // RVA: 0x7FFAC896DD40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Tag(){} // RVA: 0x7FFAC31E48B0
        public void get_IsNull(){} // RVA: 0x7FFAC3006850
        public void GetEnumerator(){} // RVA: 0x7FFAC7A35970
        public void get_Value(){} // RVA: 0x7FFAC896DDC0
        public void set_Value(){} // RVA: 0x7FFAC2F21310
        public void get_AsBool(){} // RVA: 0x7FFAC2F21320
        public void set_AsBool(){} // RVA: 0x7FFAC2F21310
        public void Equals(){} // RVA: 0x7FFAC896DE00
        public void GetHashCode(){} // RVA: 0x7FFAC34F9180
        public void WriteToStringBuilder(){} // RVA: 0x7FFAC896DEC0
        public void .cctor(){} // RVA: 0x7FFAC896DF10
    }

    public class JSONNumber : JSONNode
    {
        public double Tag; // 0x10

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFAC36C3910
        public void get_IsNumber(){} // RVA: 0x7FFAC3006850
        public void GetEnumerator(){} // RVA: 0x7FFAC7A35970
        public void get_Value(){} // RVA: 0x7FFAC896D490
        public void set_Value(){} // RVA: 0x7FFAC896D530
        public void get_AsDouble(){} // RVA: 0x7FFAC5873C20
        public void set_AsDouble(){} // RVA: 0x7FFAC69C0110
        public void get_AsLong(){} // RVA: 0x7FFAC896D670
        public void set_AsLong(){} // RVA: 0x7FFAC896D680
        public void .ctor(){} // RVA: 0x7FFAC896D690 | overloaded x2
        public void WriteToStringBuilder(){} // RVA: 0x7FFAC896D6B0
        public void IsNumeric(){} // RVA: 0x7FFAC896D6F0
        public void Equals(){} // RVA: 0x7FFAC896D8E0
        public void GetHashCode(){} // RVA: 0x7FFAC896DA10
    }

    public class JSONObject : JSONNode
    {
        public System.Collections.Generic.Dictionary`2<string,OVRSimpleJSON.JSONNode> Inline; // 0x10
        public bool Tag; // 0x18

        // ── Methods ──
        public void get_Inline(){} // RVA: 0x7FFAC2F3C4E0
        public void set_Inline(){} // RVA: 0x7FFAC2F3C4F0
        public void get_Tag(){} // RVA: 0x7FFAC3026CB0
        public void get_IsObject(){} // RVA: 0x7FFAC3006850
        public void GetEnumerator(){} // RVA: 0x7FFAC896BBF0
        public void get_Item(){} // RVA: 0x7FFAC896BF90 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFAC896C040 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC896C170
        public void Add(){} // RVA: 0x7FFAC896C1C0
        public void Remove(){} // RVA: 0x7FFAC896C5B0 | overloaded x3
        public void get_Children(){} // RVA: 0x7FFAC896C750
        public void WriteToStringBuilder(){} // RVA: 0x7FFAC896C800
        public void .ctor(){} // RVA: 0x7FFAC896CC00
    }

    public class JSONString : JSONNode
    {
        public string Tag; // 0x10

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFAC366FE20
        public void get_IsString(){} // RVA: 0x7FFAC3006850
        public void GetEnumerator(){} // RVA: 0x7FFAC7A35970
        public void get_Value(){} // RVA: 0x7FFAC2F3C380
        public void set_Value(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void WriteToStringBuilder(){} // RVA: 0x7FFAC896D230
        public void Equals(){} // RVA: 0x7FFAC896D340
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

}