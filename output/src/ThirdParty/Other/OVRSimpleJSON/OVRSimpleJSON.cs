// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVRSimpleJSON
// Classes: 9
// Methods: 159

namespace ThirdParty.Other.OVRSimpleJSON
{
    public class JSON : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x6C4A070
    }

    public class JSONArray : JSONNode
    {
        public object m_List;
        public object inline;

        // ── Methods ──
        public void get_Inline(){} // RVA: 0xB5DD50
        public void set_Inline(){} // RVA: 0xB5DD60
        public void get_Tag(){} // RVA: 0xC3CCE0
        public void get_IsArray(){} // RVA: 0xC2E4C0
        public void GetEnumerator(){} // RVA: 0x6C462F0
        public void get_Item(){} // RVA: 0x6C46640
        public void set_Item(){} // RVA: 0x6C466A0
        public void get_Count(){} // RVA: 0x6C46740
        public void Add(){} // RVA: 0x6C46790
        public void Remove(){} // RVA: 0x6C46900
        public void get_Children(){} // RVA: 0x6C46960
        public void WriteToStringBuilder(){} // RVA: 0x6C46A10
        public void .ctor(){} // RVA: 0x6C46C20
    }

    public class JSONBool : JSONNode
    {
        public object m_Data;

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x13510C0
        public void get_IsBoolean(){} // RVA: 0xC2E4C0
        public void GetEnumerator(){} // RVA: 0x5E5CFD0
        public void get_Value(){} // RVA: 0x6C49080
        public void set_Value(){} // RVA: 0x6C490F0
        public void get_AsBool(){} // RVA: 0xC120A0
        public void set_AsBool(){} // RVA: 0xC120B0
        public void .ctor(){} // RVA: 0x6C48C50
        public void WriteToStringBuilder(){} // RVA: 0x6C491B0
        public void Equals(){} // RVA: 0x6C49230
        public void GetHashCode(){} // RVA: 0x6C49290
    }

    public class JSONLazyCreator : JSONNode
    {
        public object m_Node;
        public object m_Key;

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x132D270
        public void GetEnumerator(){} // RVA: 0x5E5CFD0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Set(){} // RVA: 0xA94080
        public void get_Item(){} // RVA: 0x6C49630
        public void set_Item(){} // RVA: 0x6C496A0
        public void Add(){} // RVA: 0x6C49810
        public void op_Equality(){} // RVA: 0x6C498D0
        public void op_Inequality(){} // RVA: 0x6C498E0
        public void Equals(){} // RVA: 0x6C498D0
        public void GetHashCode(){} // RVA: 0xDAC980
        public void get_AsInt(){} // RVA: 0x6C498F0
        public void set_AsInt(){} // RVA: 0x6C49960
        public void get_AsFloat(){} // RVA: 0x6C499E0
        public void set_AsFloat(){} // RVA: 0x6C49A50
        public void get_AsDouble(){} // RVA: 0x6C49AD0
        public void set_AsDouble(){} // RVA: 0x6C49B40
        public void get_AsLong(){} // RVA: 0x6C49BB0
        public void set_AsLong(){} // RVA: 0x6C49CF0
        public void get_AsBool(){} // RVA: 0x6C49E40
        public void set_AsBool(){} // RVA: 0x6C49EB0
        public void get_AsArray(){} // RVA: 0x6C49F20
        public void get_AsObject(){} // RVA: 0x6C49FA0
        public void WriteToStringBuilder(){} // RVA: 0x6C4A020
    }

    public class JSONNode : Object
    {
        public object forceASCII;
        public object longAsString;
        public object m_EscapeBuilder;
        public object VectorContainerType;
        public object QuaternionContainerType;
        public object RectContainerType;

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x87C130
        public void get_Item(){} // RVA: 0xDAC980
        public void set_Item(){} // RVA: 0xB43310
        public void get_Value(){} // RVA: 0x6C3FF50
        public void set_Value(){} // RVA: 0xB43310
        public void get_Count(){} // RVA: 0xDAC980
        public void get_IsNumber(){} // RVA: 0xB43320
        public void get_IsString(){} // RVA: 0xB43320
        public void get_IsBoolean(){} // RVA: 0xB43320
        public void get_IsNull(){} // RVA: 0xB43320
        public void get_IsArray(){} // RVA: 0xB43320
        public void get_IsObject(){} // RVA: 0xB43320
        public void get_Inline(){} // RVA: 0xB43320
        public void set_Inline(){} // RVA: 0xB43310
        public void Add(){} // RVA: 0x6C3FF90
        public void Remove(){} // RVA: 0x1CB3B00
        public void get_Children(){} // RVA: 0x6C3FFF0
        public void get_DeepChildren(){} // RVA: 0x6C40040
        public void ToString(){} // RVA: 0x6C40190
        public void WriteToStringBuilder(){} // RVA: 0x89BA50
        public void GetEnumerator(){} // RVA: 0x87BEB0
        public void get_Linq(){} // RVA: 0x6C40240
        public void get_Keys(){} // RVA: 0x6C402A0
        public void get_Values(){} // RVA: 0x6C402A0
        public void get_AsDouble(){} // RVA: 0x6C40340
        public void set_AsDouble(){} // RVA: 0x6C404A0
        public void get_AsInt(){} // RVA: 0x6C405C0
        public void set_AsInt(){} // RVA: 0x6C405E0
        public void get_AsFloat(){} // RVA: 0x6C40600
        public void set_AsFloat(){} // RVA: 0x6C40620
        public void get_AsBool(){} // RVA: 0x6C40640
        public void set_AsBool(){} // RVA: 0x6C40740
        public void get_AsLong(){} // RVA: 0x6C407C0
        public void set_AsLong(){} // RVA: 0x6C408B0
        public void get_AsArray(){} // RVA: 0x6C408F0
        public void get_AsObject(){} // RVA: 0x6C40970
        public void op_Implicit(){} // RVA: 0x6C427C0
        public void op_Equality(){} // RVA: 0x6C40EC0
        public void op_Inequality(){} // RVA: 0x6C41050
        public void Equals(){} // RVA: 0x2AFB5A0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void get_EscapeBuilder(){} // RVA: 0x6C41070
        public void Escape(){} // RVA: 0x6C411C0
        public void ParseElement(){} // RVA: 0x6C41670
        public void Parse(){} // RVA: 0x6C41980
        public void GetContainer(){} // RVA: 0x6C42090
        public void ReadVector2(){} // RVA: 0x6C42AF0
        public void WriteVector2(){} // RVA: 0x6C42CA0
        public void ReadVector3(){} // RVA: 0x6C431B0
        public void WriteVector3(){} // RVA: 0x6C43240
        public void ReadVector4(){} // RVA: 0x6C43700
        public void WriteVector4(){} // RVA: 0x6C43780
        public void ReadQuaternion(){} // RVA: 0x6C43D10
        public void WriteQuaternion(){} // RVA: 0x6C43D90
        public void ReadRect(){} // RVA: 0x6C44320
        public void WriteRect(){} // RVA: 0x6C44360
        public void ReadRectOffset(){} // RVA: 0x6C44950
        public void WriteRectOffset(){} // RVA: 0x6C449F0
        public void ReadMatrix(){} // RVA: 0x6C44F70
        public void WriteMatrix(){} // RVA: 0x6C45070
        public void .ctor(){} // RVA: 0xB43310
    }

    public class JSONNull : JSONNode
    {
        public object m_StaticInstance;
        public object reuseSameInstance;

        // ── Methods ──
        public void CreateOrGet(){} // RVA: 0x6C492C0
        public void .ctor(){} // RVA: 0xB43310
        public void get_Tag(){} // RVA: 0xEF4110
        public void get_IsNull(){} // RVA: 0xC2E4C0
        public void GetEnumerator(){} // RVA: 0x5E5CFD0
        public void get_Value(){} // RVA: 0x6C49340
        public void set_Value(){} // RVA: 0xB43310
        public void get_AsBool(){} // RVA: 0xB43320
        public void set_AsBool(){} // RVA: 0xB43310
        public void Equals(){} // RVA: 0x6C49380
        public void GetHashCode(){} // RVA: 0xDAC980
        public void WriteToStringBuilder(){} // RVA: 0x6C49420
        public void .cctor(){} // RVA: 0x6C49470
    }

    public class JSONNumber : JSONNode
    {
        public object m_Data;

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x1347420
        public void get_IsNumber(){} // RVA: 0xC2E4C0
        public void GetEnumerator(){} // RVA: 0x5E5CFD0
        public void get_Value(){} // RVA: 0x6C48A50
        public void set_Value(){} // RVA: 0x6C48AF0
        public void get_AsDouble(){} // RVA: 0x2566C50
        public void set_AsDouble(){} // RVA: 0x4B6F180
        public void get_AsLong(){} // RVA: 0x6C48C30
        public void set_AsLong(){} // RVA: 0x6C48C40
        public void .ctor(){} // RVA: 0x6C48C50
        public void WriteToStringBuilder(){} // RVA: 0x6C48C70
        public void IsNumeric(){} // RVA: 0x6C48CB0
        public void Equals(){} // RVA: 0x6C48DF0
        public void GetHashCode(){} // RVA: 0x6C49040
    }

    public class JSONObject : JSONNode
    {
        public object m_Dict;
        public object inline;

        // ── Methods ──
        public void get_Inline(){} // RVA: 0xB5DD50
        public void set_Inline(){} // RVA: 0xB5DD60
        public void get_Tag(){} // RVA: 0xC50A80
        public void get_IsObject(){} // RVA: 0xC2E4C0
        public void GetEnumerator(){} // RVA: 0x6C471B0
        public void get_Item(){} // RVA: 0x6C47540
        public void set_Item(){} // RVA: 0x6C475F0
        public void get_Count(){} // RVA: 0x6C47720
        public void Add(){} // RVA: 0x6C47770
        public void Remove(){} // RVA: 0x6C47B60
        public void get_Children(){} // RVA: 0x6C47D00
        public void WriteToStringBuilder(){} // RVA: 0x6C47DB0
        public void .ctor(){} // RVA: 0x6C481D0
    }

    public class JSONString : JSONNode
    {
        public object m_Data;

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x12FC4A0
        public void get_IsString(){} // RVA: 0xC2E4C0
        public void GetEnumerator(){} // RVA: 0x5E5CFD0
        public void get_Value(){} // RVA: 0xB5DBF0
        public void set_Value(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0xB44D60
        public void WriteToStringBuilder(){} // RVA: 0x6C48800
        public void Equals(){} // RVA: 0x6C48910
        public void GetHashCode(){} // RVA: 0x1269730
    }

}