// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVRSimpleJSON
// Classes: 9
// Methods: 210

namespace ThirdParty.Other.OVRSimpleJSON
{
    public class JSON
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x61D73D0
    }

    public class JSONArray
    {
        public System.Collections.Generic.List`1<OVRSimpleJSON.JSONNode> m_List; // 0x10
        public bool inline; // 0x18

        // ── Methods ──
        public void get_Inline(){} // RVA: 0x2F84E0
        public void set_Inline(){} // RVA: 0x2F84F0
        public void get_Tag(){} // RVA: 0x3CFAF0
        public void get_IsArray(){} // RVA: 0x3C2850
        public void GetEnumerator(){} // RVA: 0x61D35F0
        public void get_Item(){} // RVA: 0x61D3940 | overloaded x2
        public void set_Item(){} // RVA: 0x61D39A0 | overloaded x2
        public void get_Count(){} // RVA: 0x61D3A40
        public void Add(){} // RVA: 0x61D3A90
        public void Remove(){} // RVA: 0x61D3C00 | overloaded x2
        public void get_Children(){} // RVA: 0x61D3C60
        public void WriteToStringBuilder(){} // RVA: 0x61D3D10
        public void .ctor(){} // RVA: 0x61D3F20
    }

    public class JSONBool
    {
        public bool m_Data; // 0x10

        // ── Methods ──
        public void get_Tag(){} // RVA: 0xA850E0
        public void get_IsBoolean(){} // RVA: 0x3C2850
        public void GetEnumerator(){} // RVA: 0x534B5F0
        public void get_Value(){} // RVA: 0x61D6310
        public void set_Value(){} // RVA: 0x61D63A0
        public void get_AsBool(){} // RVA: 0x3A75E0
        public void set_AsBool(){} // RVA: 0x3A75F0
        public void .ctor(){} // RVA: 0x61D5F50 | overloaded x2
        public void WriteToStringBuilder(){} // RVA: 0x61D64A0
        public void Equals(){} // RVA: 0x61D6520
        public void GetHashCode(){} // RVA: 0x61D65B0
    }

    public class JSONLazyCreator
    {
        public OVRSimpleJSON.JSONNode m_Node; // 0x10
        public string m_Key; // 0x18

        // ── Methods ──
        public void get_Tag(){} // RVA: 0xA67BB0
        public void GetEnumerator(){} // RVA: 0x534B5F0
        public void .ctor(){} // RVA: 0xF19AE0 | overloaded x2
        public void Set(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x61D6990 | overloaded x2
        public void set_Item(){} // RVA: 0x61D6A00 | overloaded x2
        public void Add(){} // RVA: 0x61D6B70 | overloaded x2
        public void op_Equality(){} // RVA: 0x61D6C30
        public void op_Inequality(){} // RVA: 0x61D6C40
        public void Equals(){} // RVA: 0x61D6C30
        public void GetHashCode(){} // RVA: 0x519240
        public void get_AsInt(){} // RVA: 0x61D6C50
        public void set_AsInt(){} // RVA: 0x61D6CC0
        public void get_AsFloat(){} // RVA: 0x61D6D40
        public void set_AsFloat(){} // RVA: 0x61D6DB0
        public void get_AsDouble(){} // RVA: 0x61D6E30
        public void set_AsDouble(){} // RVA: 0x61D6EA0
        public void get_AsLong(){} // RVA: 0x61D6F10
        public void set_AsLong(){} // RVA: 0x61D7050
        public void get_AsBool(){} // RVA: 0x61D71A0
        public void set_AsBool(){} // RVA: 0x61D7210
        public void get_AsArray(){} // RVA: 0x61D7280
        public void get_AsObject(){} // RVA: 0x61D7300
        public void WriteToStringBuilder(){} // RVA: 0x61D7380
    }

    public class JSONNode
    {
        public bool forceASCII;
        public bool longAsString; // 0x1
        public System.Text.StringBuilder m_EscapeBuilder; // 0xFFFFFFFF
        public 0x658C9FB0 VectorContainerType; // 0x4
        public 0x658C9FB0 QuaternionContainerType; // 0x8
        public 0x658C9FB0 RectContainerType; // 0xC

        // ── Methods ──
        public void get_Tag(){} // RVA: 0xD840
        public void get_Item(){} // RVA: 0x519240 | overloaded x2
        public void set_Item(){} // RVA: 0x2DD310 | overloaded x2
        public void get_Value(){} // RVA: 0x61CD480
        public void set_Value(){} // RVA: 0x2DD310
        public void get_Count(){} // RVA: 0x519240
        public void get_IsNumber(){} // RVA: 0x2DD320
        public void get_IsString(){} // RVA: 0x2DD320
        public void get_IsBoolean(){} // RVA: 0x2DD320
        public void get_IsNull(){} // RVA: 0x2DD320
        public void get_IsArray(){} // RVA: 0x2DD320
        public void get_IsObject(){} // RVA: 0x2DD320
        public void get_Inline(){} // RVA: 0x2DD320
        public void set_Inline(){} // RVA: 0x2DD310
        public void Add(){} // RVA: 0x61CD4C0 | overloaded x2
        public void Remove(){} // RVA: 0x13DCE00 | overloaded x3
        public void get_Children(){} // RVA: 0x61CD520
        public void get_DeepChildren(){} // RVA: 0x61CD570
        public void ToString(){} // RVA: 0x61CD6C0 | overloaded x2
        public void WriteToStringBuilder(){}
        public void GetEnumerator(){}
        public void get_Linq(){} // RVA: 0x61CD770
        public void get_Keys(){} // RVA: 0x61CD7D0
        public void get_Values(){} // RVA: 0x61CD7D0
        public void get_AsDouble(){} // RVA: 0x61CD870
        public void set_AsDouble(){} // RVA: 0x61CD9D0
        public void get_AsInt(){} // RVA: 0x61CDAF0
        public void set_AsInt(){} // RVA: 0x61CDB10
        public void get_AsFloat(){} // RVA: 0x61CDB30
        public void set_AsFloat(){} // RVA: 0x61CDB50
        public void get_AsBool(){} // RVA: 0x61CDB70
        public void set_AsBool(){} // RVA: 0x61CDCC0
        public void get_AsLong(){} // RVA: 0x61CDD40
        public void set_AsLong(){} // RVA: 0x61CDE30
        public void get_AsArray(){} // RVA: 0x61CDE70
        public void get_AsObject(){} // RVA: 0x61CDF00
        public void op_Implicit(){} // RVA: 0x61CFC80 | overloaded x25
        public void op_Equality(){} // RVA: 0x61CE460
        public void op_Inequality(){} // RVA: 0x61CE5F0
        public void Equals(){} // RVA: 0x2878D00
        public void GetHashCode(){} // RVA: 0x5C63910
        public void get_EscapeBuilder(){} // RVA: 0x61CE610
        public void Escape(){} // RVA: 0x61CE760
        public void ParseElement(){} // RVA: 0x61CEC10
        public void Parse(){} // RVA: 0x61CEF20
        public void GetContainer(){} // RVA: 0x61CF630
        public void ReadVector2(){} // RVA: 0x61CFFB0 | overloaded x3
        public void WriteVector2(){} // RVA: 0x61D0010
        public void ReadVector3(){} // RVA: 0x61D0520 | overloaded x3
        public void WriteVector3(){} // RVA: 0x61D05B0
        public void ReadVector4(){} // RVA: 0x61D0A70 | overloaded x2
        public void WriteVector4(){} // RVA: 0x61D0AF0
        public void ReadQuaternion(){} // RVA: 0x61D1080 | overloaded x2
        public void WriteQuaternion(){} // RVA: 0x61D1100
        public void ReadRect(){} // RVA: 0x61D1690 | overloaded x2
        public void WriteRect(){} // RVA: 0x61D16D0
        public void ReadRectOffset(){} // RVA: 0x61D1CC0 | overloaded x2
        public void WriteRectOffset(){} // RVA: 0x61D1D60
        public void ReadMatrix(){} // RVA: 0x61D2260
        public void WriteMatrix(){} // RVA: 0x61D2360
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class JSONNull
    {
        public OVRSimpleJSON.JSONNull m_StaticInstance;
        public bool reuseSameInstance; // 0x8

        // ── Methods ──
        public void CreateOrGet(){} // RVA: 0x61D6600
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Tag(){} // RVA: 0x66CCC0
        public void get_IsNull(){} // RVA: 0x3C2850
        public void GetEnumerator(){} // RVA: 0x534B5F0
        public void get_Value(){} // RVA: 0x61D6680
        public void set_Value(){} // RVA: 0x2DD310
        public void get_AsBool(){} // RVA: 0x2DD320
        public void set_AsBool(){} // RVA: 0x2DD310
        public void Equals(){} // RVA: 0x61D66C0
        public void GetHashCode(){} // RVA: 0x519240
        public void WriteToStringBuilder(){} // RVA: 0x61D6780
        public void .cctor(){} // RVA: 0x61D67D0
    }

    public class JSONNumber
    {
        public double m_Data; // 0x10

        // ── Methods ──
        public void get_Tag(){} // RVA: 0xA7E130
        public void get_IsNumber(){} // RVA: 0x3C2850
        public void GetEnumerator(){} // RVA: 0x534B5F0
        public void get_Value(){} // RVA: 0x61D5D50
        public void set_Value(){} // RVA: 0x61D5DF0
        public void get_AsDouble(){} // RVA: 0x2EE1B30
        public void set_AsDouble(){} // RVA: 0x40AB380
        public void get_AsLong(){} // RVA: 0x61D5F30
        public void set_AsLong(){} // RVA: 0x61D5F40
        public void .ctor(){} // RVA: 0x61D5F50 | overloaded x2
        public void WriteToStringBuilder(){} // RVA: 0x61D5F70
        public void IsNumeric(){} // RVA: 0x61D5FB0
        public void Equals(){} // RVA: 0x61D61A0
        public void GetHashCode(){} // RVA: 0x61D62D0
    }

    public class JSONObject
    {
        public System.Collections.Generic.Dictionary`2<string,OVRSimpleJSON.JSONNode> m_Dict; // 0x10
        public bool inline; // 0x18

        // ── Methods ──
        public void get_Inline(){} // RVA: 0x2F84E0
        public void set_Inline(){} // RVA: 0x2F84F0
        public void get_Tag(){} // RVA: 0x3E2CB0
        public void get_IsObject(){} // RVA: 0x3C2850
        public void GetEnumerator(){} // RVA: 0x61D44B0
        public void get_Item(){} // RVA: 0x61D4850 | overloaded x2
        public void set_Item(){} // RVA: 0x61D4900 | overloaded x2
        public void get_Count(){} // RVA: 0x61D4A30
        public void Add(){} // RVA: 0x61D4A80
        public void Remove(){} // RVA: 0x61D4E70 | overloaded x3
        public void get_Children(){} // RVA: 0x61D5010
        public void WriteToStringBuilder(){} // RVA: 0x61D50C0
        public void .ctor(){} // RVA: 0x61D54C0
    }

    public class JSONString
    {
        public string m_Data; // 0x10

        // ── Methods ──
        public void get_Tag(){} // RVA: 0xA308B0
        public void get_IsString(){} // RVA: 0x3C2850
        public void GetEnumerator(){} // RVA: 0x534B5F0
        public void get_Value(){} // RVA: 0x2F8380
        public void set_Value(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x2DEE30
        public void WriteToStringBuilder(){} // RVA: 0x61D5AF0
        public void Equals(){} // RVA: 0x61D5C00
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

}