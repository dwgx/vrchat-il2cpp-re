// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVRSimpleJSON
// Classes: 9
// Methods: 159

namespace ThirdParty.Other.OVRSimpleJSON
{
    public class JSON : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7ADFC3FD0
    }

    public class JSONArray : JSONNode
    {
        // ── Methods ──
        public void get_Inline(){} // RVA: 0x7A80F26D0
        public void set_Inline(){} // RVA: 0x7A80F26E0
        public void get_Tag(){} // RVA: 0x7A81CA9D0
        public void get_IsArray(){} // RVA: 0x7A81BD750
        public void GetEnumerator(){} // RVA: 0x7ADFC0040
        public void get_Item(){} // RVA: 0x7ADFC0390
        public void set_Item(){} // RVA: 0x7ADFC03F0
        public void get_Count(){} // RVA: 0x7ADFC0490
        public void Add(){} // RVA: 0x7ADFC04E0
        public void Remove(){} // RVA: 0x7ADFC0650
        public void get_Children(){} // RVA: 0x7ADFC06B0
        public void WriteToStringBuilder(){} // RVA: 0x7ADFC0760
        public void .ctor(){} // RVA: 0x7ADFC0970
    }

    public class JSONBool : JSONNode
    {
        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7A8842E60
        public void get_IsBoolean(){} // RVA: 0x7A81BD750
        public void GetEnumerator(){} // RVA: 0x7AD102F70
        public void get_Value(){} // RVA: 0x7ADFC2F30
        public void set_Value(){} // RVA: 0x7ADFC2FC0
        public void get_AsBool(){} // RVA: 0x7A81A2200
        public void set_AsBool(){} // RVA: 0x7A81A2210
        public void .ctor(){} // RVA: 0x7ADFC29B0
        public void WriteToStringBuilder(){} // RVA: 0x7ADFC30C0
        public void Equals(){} // RVA: 0x7ADFC3140
        public void GetHashCode(){} // RVA: 0x7ADFC31D0
    }

    public class JSONLazyCreator : JSONNode
    {
        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7A88258F0
        public void GetEnumerator(){} // RVA: 0x7AD102F70
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Set(){} // RVA: 0x7A8051B10
        public void get_Item(){} // RVA: 0x7ADFC3590
        public void set_Item(){} // RVA: 0x7ADFC3600
        public void Add(){} // RVA: 0x7ADFC3770
        public void op_Equality(){} // RVA: 0x7ADFC3830
        public void op_Inequality(){} // RVA: 0x7ADFC3840
        public void Equals(){} // RVA: 0x7ADFC3830
        public void GetHashCode(){} // RVA: 0x7A82D1450
        public void get_AsInt(){} // RVA: 0x7ADFC3850
        public void set_AsInt(){} // RVA: 0x7ADFC38C0
        public void get_AsFloat(){} // RVA: 0x7ADFC3940
        public void set_AsFloat(){} // RVA: 0x7ADFC39B0
        public void get_AsDouble(){} // RVA: 0x7ADFC3A30
        public void set_AsDouble(){} // RVA: 0x7ADFC3AA0
        public void get_AsLong(){} // RVA: 0x7ADFC3B10
        public void set_AsLong(){} // RVA: 0x7ADFC3C50
        public void get_AsBool(){} // RVA: 0x7ADFC3DA0
        public void set_AsBool(){} // RVA: 0x7ADFC3E10
        public void get_AsArray(){} // RVA: 0x7ADFC3E80
        public void get_AsObject(){} // RVA: 0x7ADFC3F00
        public void WriteToStringBuilder(){} // RVA: 0x7ADFC3F80
    }

    public class JSONNode : Object
    {
        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7A7E00710
        public void get_Item(){} // RVA: 0x7A82D1450
        public void set_Item(){} // RVA: 0x7A80D7310
        public void get_Value(){} // RVA: 0x7ADFB9CB0
        public void set_Value(){} // RVA: 0x7A80D7310
        public void get_Count(){} // RVA: 0x7A82D1450
        public void get_IsNumber(){} // RVA: 0x7A80D7320
        public void get_IsString(){} // RVA: 0x7A80D7320
        public void get_IsBoolean(){} // RVA: 0x7A80D7320
        public void get_IsNull(){} // RVA: 0x7A80D7320
        public void get_IsArray(){} // RVA: 0x7A80D7320
        public void get_IsObject(){} // RVA: 0x7A80D7320
        public void get_Inline(){} // RVA: 0x7A80D7320
        public void set_Inline(){} // RVA: 0x7A80D7310
        public void Add(){} // RVA: 0x7ADFB9CF0
        public void Remove(){} // RVA: 0x7A9194610
        public void get_Children(){} // RVA: 0x7ADFB9D50
        public void get_DeepChildren(){} // RVA: 0x7ADFB9DA0
        public void ToString(){} // RVA: 0x7ADFB9EF0
        public void WriteToStringBuilder(){} // RVA: 0x7A7E1FD90
        public void GetEnumerator(){} // RVA: 0x7A7E00490
        public void get_Linq(){} // RVA: 0x7ADFB9FA0
        public void get_Keys(){} // RVA: 0x7ADFBA000
        public void get_Values(){} // RVA: 0x7ADFBA000
        public void get_AsDouble(){} // RVA: 0x7ADFBA0A0
        public void set_AsDouble(){} // RVA: 0x7ADFBA200
        public void get_AsInt(){} // RVA: 0x7ADFBA320
        public void set_AsInt(){} // RVA: 0x7ADFBA340
        public void get_AsFloat(){} // RVA: 0x7ADFBA360
        public void set_AsFloat(){} // RVA: 0x7ADFBA380
        public void get_AsBool(){} // RVA: 0x7ADFBA3A0
        public void set_AsBool(){} // RVA: 0x7ADFBA4F0
        public void get_AsLong(){} // RVA: 0x7ADFBA570
        public void set_AsLong(){} // RVA: 0x7ADFBA660
        public void get_AsArray(){} // RVA: 0x7ADFBA6A0
        public void get_AsObject(){} // RVA: 0x7ADFBA720
        public void op_Implicit(){} // RVA: 0x7ADFBC570
        public void op_Equality(){} // RVA: 0x7ADFBAC70
        public void op_Inequality(){} // RVA: 0x7ADFBAE00
        public void Equals(){} // RVA: 0x7AA68A530
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void get_EscapeBuilder(){} // RVA: 0x7ADFBAE20
        public void Escape(){} // RVA: 0x7ADFBAF70
        public void ParseElement(){} // RVA: 0x7ADFBB420
        public void Parse(){} // RVA: 0x7ADFBB730
        public void GetContainer(){} // RVA: 0x7ADFBBE40
        public void ReadVector2(){} // RVA: 0x7ADFBC8A0
        public void WriteVector2(){} // RVA: 0x7ADFBCA50
        public void ReadVector3(){} // RVA: 0x7ADFBCF60
        public void WriteVector3(){} // RVA: 0x7ADFBCFF0
        public void ReadVector4(){} // RVA: 0x7ADFBD4B0
        public void WriteVector4(){} // RVA: 0x7ADFBD530
        public void ReadQuaternion(){} // RVA: 0x7ADFBDAC0
        public void WriteQuaternion(){} // RVA: 0x7ADFBDB40
        public void ReadRect(){} // RVA: 0x7ADFBE0D0
        public void WriteRect(){} // RVA: 0x7ADFBE110
        public void ReadRectOffset(){} // RVA: 0x7ADFBE700
        public void WriteRectOffset(){} // RVA: 0x7ADFBE7A0
        public void ReadMatrix(){} // RVA: 0x7ADFBECA0
        public void WriteMatrix(){} // RVA: 0x7ADFBEDA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class JSONNull : JSONNode
    {
        // ── Methods ──
        public void CreateOrGet(){} // RVA: 0x7ADFC3220
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Tag(){} // RVA: 0x7A8401A30
        public void get_IsNull(){} // RVA: 0x7A81BD750
        public void GetEnumerator(){} // RVA: 0x7AD102F70
        public void get_Value(){} // RVA: 0x7ADFC32A0
        public void set_Value(){} // RVA: 0x7A80D7310
        public void get_AsBool(){} // RVA: 0x7A80D7320
        public void set_AsBool(){} // RVA: 0x7A80D7310
        public void Equals(){} // RVA: 0x7ADFC32E0
        public void GetHashCode(){} // RVA: 0x7A82D1450
        public void WriteToStringBuilder(){} // RVA: 0x7ADFC3380
        public void .cctor(){} // RVA: 0x7ADFC33D0
    }

    public class JSONNumber : JSONNode
    {
        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7A883BE70
        public void get_IsNumber(){} // RVA: 0x7A81BD750
        public void GetEnumerator(){} // RVA: 0x7AD102F70
        public void get_Value(){} // RVA: 0x7ADFC27B0
        public void set_Value(){} // RVA: 0x7ADFC2850
        public void get_AsDouble(){} // RVA: 0x7AACD8650
        public void set_AsDouble(){} // RVA: 0x7ABEA0730
        public void get_AsLong(){} // RVA: 0x7ADFC2990
        public void set_AsLong(){} // RVA: 0x7ADFC29A0
        public void .ctor(){} // RVA: 0x7ADFC29B0
        public void WriteToStringBuilder(){} // RVA: 0x7ADFC29D0
        public void IsNumeric(){} // RVA: 0x7ADFC2A10
        public void Equals(){} // RVA: 0x7ADFC2C00
        public void GetHashCode(){} // RVA: 0x7ADFC2EF0
    }

    public class JSONObject : JSONNode
    {
        // ── Methods ──
        public void get_Inline(){} // RVA: 0x7A80F26D0
        public void set_Inline(){} // RVA: 0x7A80F26E0
        public void get_Tag(){} // RVA: 0x7A81DDCC0
        public void get_IsObject(){} // RVA: 0x7A81BD750
        public void GetEnumerator(){} // RVA: 0x7ADFC0F00
        public void get_Item(){} // RVA: 0x7ADFC1290
        public void set_Item(){} // RVA: 0x7ADFC1340
        public void get_Count(){} // RVA: 0x7ADFC1470
        public void Add(){} // RVA: 0x7ADFC14C0
        public void Remove(){} // RVA: 0x7ADFC18B0
        public void get_Children(){} // RVA: 0x7ADFC1A50
        public void WriteToStringBuilder(){} // RVA: 0x7ADFC1B00
        public void .ctor(){} // RVA: 0x7ADFC1F20
    }

    public class JSONString : JSONNode
    {
        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7A87EE0F0
        public void get_IsString(){} // RVA: 0x7A81BD750
        public void GetEnumerator(){} // RVA: 0x7AD102F70
        public void get_Value(){} // RVA: 0x7A80F2570
        public void set_Value(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void WriteToStringBuilder(){} // RVA: 0x7ADFC2550
        public void Equals(){} // RVA: 0x7ADFC2660
        public void GetHashCode(){} // RVA: 0x7A8738190
    }

}