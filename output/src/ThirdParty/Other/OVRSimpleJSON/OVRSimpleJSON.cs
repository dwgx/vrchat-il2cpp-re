// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVRSimpleJSON
// Classes: 9
// Methods: 210

namespace ThirdParty.Other.OVRSimpleJSON
{
    public class JSON : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFE86D181A0
    }

    public class JSONArray : JSONNode
    {
        public System.Collections.Generic.List`1<OVRSimpleJSON.JSONNode> m_List; // 0x10
        public bool inline; // 0x18
        public object field_2; // 0x1A5
        public object field_3; // 0x1A6
        public object field_4; // 0x1A7
        public object field_5; // 0x1A8
        public object field_6; // 0x1A9

        // ── Methods ──
        public void get_Inline(){} // RVA: 0x7FFE811164E0
        public void set_Inline(){} // RVA: 0x7FFE811164F0
        public void get_Tag(){} // RVA: 0x7FFE811EDAF0
        public void get_IsArray(){} // RVA: 0x7FFE811E0850
        public void GetEnumerator(){} // RVA: 0x7FFE86D143C0
        public void get_Item(){} // RVA: 0x7FFE86D14710 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE86D14770 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE86D14810
        public void Add(){} // RVA: 0x7FFE86D14860
        public void Remove(){} // RVA: 0x7FFE86D149D0 | overloaded x2
        public void get_Children(){} // RVA: 0x7FFE86D14A30
        public void WriteToStringBuilder(){} // RVA: 0x7FFE86D14AE0
        public void .ctor(){} // RVA: 0x7FFE86D14CF0
    }

    public class JSONBool : JSONNode
    {
        public bool m_Data; // 0x10
        public object field_1; // 0x1BF
        public object field_2; // 0x1C0
        public object field_3; // 0x1C1

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFE81815210
        public void get_IsBoolean(){} // RVA: 0x7FFE811E0850
        public void GetEnumerator(){} // RVA: 0x7FFE85E1B0D0
        public void get_Value(){} // RVA: 0x7FFE86D170E0
        public void set_Value(){} // RVA: 0x7FFE86D17170
        public void get_AsBool(){} // RVA: 0x7FFE811C55E0
        public void set_AsBool(){} // RVA: 0x7FFE811C55F0
        public void .ctor(){} // RVA: 0x7FFE86D16D20 | overloaded x2
        public void WriteToStringBuilder(){} // RVA: 0x7FFE86D17270
        public void Equals(){} // RVA: 0x7FFE86D172F0
        public void GetHashCode(){} // RVA: 0x7FFE86D17380
    }

    public class JSONLazyCreator : JSONNode
    {
        public OVRSimpleJSON.JSONNode m_Node; // 0x10
        public string m_Key; // 0x18
        public object field_2; // 0x1C7
        public object field_3; // 0x1C8
        public object field_4; // 0x1C9
        public object field_5; // 0x1CA
        public object field_6; // 0x1CB
        public object field_7; // 0x1CC
        public object field_8; // 0x1CD
        public object field_9; // 0x1CE

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFE817F39D0
        public void GetEnumerator(){} // RVA: 0x7FFE85E1B0D0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0 | overloaded x2
        public void Set(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE86D17760 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE86D177D0 | overloaded x2
        public void Add(){} // RVA: 0x7FFE86D17940 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE86D17A00
        public void op_Inequality(){} // RVA: 0x7FFE86D17A10
        public void Equals(){} // RVA: 0x7FFE86D17A00
        public void GetHashCode(){} // RVA: 0x7FFE813240E0
        public void get_AsInt(){} // RVA: 0x7FFE86D17A20
        public void set_AsInt(){} // RVA: 0x7FFE86D17A90
        public void get_AsFloat(){} // RVA: 0x7FFE86D17B10
        public void set_AsFloat(){} // RVA: 0x7FFE86D17B80
        public void get_AsDouble(){} // RVA: 0x7FFE86D17C00
        public void set_AsDouble(){} // RVA: 0x7FFE86D17C70
        public void get_AsLong(){} // RVA: 0x7FFE86D17CE0
        public void set_AsLong(){} // RVA: 0x7FFE86D17E20
        public void get_AsBool(){} // RVA: 0x7FFE86D17F70
        public void set_AsBool(){} // RVA: 0x7FFE86D17FE0
        public void get_AsArray(){} // RVA: 0x7FFE86D18050
        public void get_AsObject(){} // RVA: 0x7FFE86D180D0
        public void WriteToStringBuilder(){} // RVA: 0x7FFE86D18150
    }

    public class JSONNode : Object
    {
        public bool forceASCII;
        public bool longAsString; // 0x1
        public System.Text.StringBuilder m_EscapeBuilder; // 0xFFFF
        public 0x665A76BC VectorContainerType; // 0x4
        public 0x665A76BC QuaternionContainerType; // 0x8
        public 0x665A76BC RectContainerType; // 0xC
        public object _buckets; // 0x729C
        public object _entries; // 0xD3D8
        public object _count; // 0xD260
        public object _freeList;
        public int[] _freeCount; // 0x10
        public Entry<string,OVRSimpleJSON.JSONNode>[] _version; // 0x18
        public int _comparer; // 0x20
        public int _keys; // 0x24
        public int _values; // 0x28
        public int _syncRoot; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> VersionName; // 0x30
        public KeyCollection<string,OVRSimpleJSON.JSONNode> HashSizeName; // 0x38
        public ValueCollection<string,OVRSimpleJSON.JSONNode> KeyValuePairsName; // 0x40
        public object ComparerName; // 0x48
        public string VersionName;
        public string HashSizeName;
        public string KeyValuePairsName;
        public string ComparerName;
        public void field_24; // 0x6880

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFE80E2EDB0
        public void get_Item(){} // RVA: 0x7FFE813240E0 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE86D0E250
        public void set_Value(){} // RVA: 0x7FFE810FB310
        public void get_Count(){} // RVA: 0x7FFE813240E0
        public void get_IsNumber(){} // RVA: 0x7FFE810FB320
        public void get_IsString(){} // RVA: 0x7FFE810FB320
        public void get_IsBoolean(){} // RVA: 0x7FFE810FB320
        public void get_IsNull(){} // RVA: 0x7FFE810FB320
        public void get_IsArray(){} // RVA: 0x7FFE810FB320
        public void get_IsObject(){} // RVA: 0x7FFE810FB320
        public void get_Inline(){} // RVA: 0x7FFE810FB320
        public void set_Inline(){} // RVA: 0x7FFE810FB310
        public void Add(){} // RVA: 0x7FFE86D0E290 | overloaded x2
        public void Remove(){} // RVA: 0x7FFE82153650 | overloaded x3
        public void get_Children(){} // RVA: 0x7FFE86D0E2F0
        public void get_DeepChildren(){} // RVA: 0x7FFE86D0E340
        public void ToString(){} // RVA: 0x7FFE86D0E490 | overloaded x2
        public void WriteToStringBuilder(){}
        public void GetEnumerator(){}
        public void get_Linq(){} // RVA: 0x7FFE86D0E540
        public void get_Keys(){} // RVA: 0x7FFE86D0E5A0
        public void get_Values(){} // RVA: 0x7FFE86D0E5A0
        public void get_AsDouble(){} // RVA: 0x7FFE86D0E640
        public void set_AsDouble(){} // RVA: 0x7FFE86D0E7A0
        public void get_AsInt(){} // RVA: 0x7FFE86D0E8C0
        public void set_AsInt(){} // RVA: 0x7FFE86D0E8E0
        public void get_AsFloat(){} // RVA: 0x7FFE86D0E900
        public void set_AsFloat(){} // RVA: 0x7FFE86D0E920
        public void get_AsBool(){} // RVA: 0x7FFE86D0E940
        public void set_AsBool(){} // RVA: 0x7FFE86D0EA90
        public void get_AsLong(){} // RVA: 0x7FFE86D0EB10
        public void set_AsLong(){} // RVA: 0x7FFE86D0EC00
        public void get_AsArray(){} // RVA: 0x7FFE86D0EC40
        public void get_AsObject(){} // RVA: 0x7FFE86D0ECD0
        public void op_Implicit(){} // RVA: 0x7FFE86D10A50 | overloaded x25
        public void op_Equality(){} // RVA: 0x7FFE86D0F230
        public void op_Inequality(){} // RVA: 0x7FFE86D0F3C0
        public void Equals(){} // RVA: 0x7FFE835C1CA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void get_EscapeBuilder(){} // RVA: 0x7FFE86D0F3E0
        public void Escape(){} // RVA: 0x7FFE86D0F530
        public void ParseElement(){} // RVA: 0x7FFE86D0F9E0
        public void Parse(){} // RVA: 0x7FFE86D0FCF0
        public void GetContainer(){} // RVA: 0x7FFE86D10400
        public void ReadVector2(){} // RVA: 0x7FFE86D10D80 | overloaded x3
        public void WriteVector2(){} // RVA: 0x7FFE86D10DE0
        public void ReadVector3(){} // RVA: 0x7FFE86D112F0 | overloaded x3
        public void WriteVector3(){} // RVA: 0x7FFE86D11380
        public void ReadVector4(){} // RVA: 0x7FFE86D11840 | overloaded x2
        public void WriteVector4(){} // RVA: 0x7FFE86D118C0
        public void ReadQuaternion(){} // RVA: 0x7FFE86D11E50 | overloaded x2
        public void WriteQuaternion(){} // RVA: 0x7FFE86D11ED0
        public void ReadRect(){} // RVA: 0x7FFE86D12460 | overloaded x2
        public void WriteRect(){} // RVA: 0x7FFE86D124A0
        public void ReadRectOffset(){} // RVA: 0x7FFE86D12A90 | overloaded x2
        public void WriteRectOffset(){} // RVA: 0x7FFE86D12B30
        public void ReadMatrix(){} // RVA: 0x7FFE86D13030
        public void WriteMatrix(){} // RVA: 0x7FFE86D13130
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class JSONNull : JSONNode
    {
        public OVRSimpleJSON.JSONNull m_StaticInstance;
        public bool reuseSameInstance; // 0x8
        public object field_2; // 0x1C3
        public object field_3; // 0x1C4

        // ── Methods ──
        public void CreateOrGet(){} // RVA: 0x7FFE86D173D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Tag(){} // RVA: 0x7FFE81474A10
        public void get_IsNull(){} // RVA: 0x7FFE811E0850
        public void GetEnumerator(){} // RVA: 0x7FFE85E1B0D0
        public void get_Value(){} // RVA: 0x7FFE86D17450
        public void set_Value(){} // RVA: 0x7FFE810FB310
        public void get_AsBool(){} // RVA: 0x7FFE810FB320
        public void set_AsBool(){} // RVA: 0x7FFE810FB310
        public void Equals(){} // RVA: 0x7FFE86D17490
        public void GetHashCode(){} // RVA: 0x7FFE813240E0
        public void WriteToStringBuilder(){} // RVA: 0x7FFE86D17550
        public void .cctor(){} // RVA: 0x7FFE86D175A0
    }

    public class JSONNumber : JSONNode
    {
        public double m_Data; // 0x10
        public object field_1; // 0x1BA
        public object field_2; // 0x1BB
        public object field_3; // 0x1BC
        public object field_4; // 0x1BD

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFE8180E590
        public void get_IsNumber(){} // RVA: 0x7FFE811E0850
        public void GetEnumerator(){} // RVA: 0x7FFE85E1B0D0
        public void get_Value(){} // RVA: 0x7FFE86D16B20
        public void set_Value(){} // RVA: 0x7FFE86D16BC0
        public void get_AsDouble(){} // RVA: 0x7FFE83BB0D80
        public void set_AsDouble(){} // RVA: 0x7FFE84D215B0
        public void get_AsLong(){} // RVA: 0x7FFE86D16D00
        public void set_AsLong(){} // RVA: 0x7FFE86D16D10
        public void .ctor(){} // RVA: 0x7FFE86D16D20 | overloaded x2
        public void WriteToStringBuilder(){} // RVA: 0x7FFE86D16D40
        public void IsNumeric(){} // RVA: 0x7FFE86D16D80
        public void Equals(){} // RVA: 0x7FFE86D16F70
        public void GetHashCode(){} // RVA: 0x7FFE86D170A0
    }

    public class JSONObject : JSONNode
    {
        public System.Collections.Generic.Dictionary`2<string,OVRSimpleJSON.JSONNode> m_Dict; // 0x10
        public bool inline; // 0x18
        public object field_2; // 0x1AE
        public object field_3; // 0x1AF
        public object field_4; // 0x1B0
        public object field_5; // 0x1B1
        public object field_6; // 0x1B2

        // ── Methods ──
        public void get_Inline(){} // RVA: 0x7FFE811164E0
        public void set_Inline(){} // RVA: 0x7FFE811164F0
        public void get_Tag(){} // RVA: 0x7FFE81200CB0
        public void get_IsObject(){} // RVA: 0x7FFE811E0850
        public void GetEnumerator(){} // RVA: 0x7FFE86D15280
        public void get_Item(){} // RVA: 0x7FFE86D15620 | overloaded x2
        public void set_Item(){} // RVA: 0x7FFE86D156D0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE86D15800
        public void Add(){} // RVA: 0x7FFE86D15850
        public void Remove(){} // RVA: 0x7FFE86D15C40 | overloaded x3
        public void get_Children(){} // RVA: 0x7FFE86D15DE0
        public void WriteToStringBuilder(){} // RVA: 0x7FFE86D15E90
        public void .ctor(){} // RVA: 0x7FFE86D16290
    }

    public class JSONString : JSONNode
    {
        public string m_Data; // 0x10
        public object field_1; // 0x1B7
        public object field_2; // 0x1B8

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFE817BF630
        public void get_IsString(){} // RVA: 0x7FFE811E0850
        public void GetEnumerator(){} // RVA: 0x7FFE85E1B0D0
        public void get_Value(){} // RVA: 0x7FFE81116380
        public void set_Value(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void WriteToStringBuilder(){} // RVA: 0x7FFE86D168C0
        public void Equals(){} // RVA: 0x7FFE86D169D0
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

}