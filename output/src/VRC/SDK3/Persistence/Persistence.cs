// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.SDK3.Persistence
// Classes: 1
// Methods: 62

namespace VRC.SDK3.Persistence
{
    public class PlayerData : Object
    {
        public System.Func`2<VRC.SDKBase.VRCPlayerApi,System.Collections.Generic.IEnumerable`1<string>> _getKeys;
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,bool> _hasKey; // 0x8
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,System.Type> _getType; // 0x10
        public System.Action`2<string,bool> _setBool; // 0x18
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,bool> _getBool; // 0x20
        public System.Action`2<string,sbyte> _setSByte; // 0x28
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,sbyte> _getSByte; // 0x30
        public System.Action`2<string,byte> _setByte; // 0x38
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,byte> _getByte; // 0x40
        public System.Action`2<string,byte[]> _setBytes; // 0x48
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,byte[]> _getBytes; // 0x50
        public System.Action`2<string,string> _setString; // 0x58
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,string> _getString; // 0x60
        public System.Action`2<string,short> _setShort; // 0x68
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,short> _getShort; // 0x70
        public System.Action`2<string,ushort> _setUShort; // 0x78
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,ushort> _getUShort; // 0x80
        public System.Action`2<string,int> _setInt; // 0x88
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,int> _getInt; // 0x90
        public System.Action`2<string,uint> _setUInt; // 0x98
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,uint> _getUInt; // 0xA0
        public System.Action`2<string,long> _setLong; // 0xA8
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,long> _getLong; // 0xB0
        public System.Action`2<string,ulong> _setULong; // 0xB8
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,ulong> _getULong; // 0xC0
        public System.Action`2<string,float> _setFloat; // 0xC8
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,float> _getFloat; // 0xD0
        public System.Action`2<string,double> _setDouble; // 0xD8
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,double> _getDouble; // 0xE0
        public System.Action`2<string,UnityEngine.Vector2> _setVector2; // 0xE8
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,UnityEngine.Vector2> _getVector2; // 0xF0
        public System.Action`2<string,UnityEngine.Vector3> _setVector3; // 0xF8
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,UnityEngine.Vector3> _getVector3; // 0x100
        public System.Action`2<string,UnityEngine.Vector4> _setVector4; // 0x108
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,UnityEngine.Vector4> _getVector4; // 0x110
        public System.Action`2<string,UnityEngine.Quaternion> _setQuaternion; // 0x118
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,UnityEngine.Quaternion> _getQuaternion; // 0x120
        public System.Action`2<string,UnityEngine.Color> _setColor; // 0x128
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,UnityEngine.Color> _getColor; // 0x130
        public System.Action`2<string,UnityEngine.Color32> _setColor32; // 0x138
        public System.Func`3<VRC.SDKBase.VRCPlayerApi,string,UnityEngine.Color32> _getColor32; // 0x140

        // ── Methods ──
        public void HasKey(){} // RVA: 0x7FFACC00FE30
        public void GetType(){} // RVA: 0x7FFACC00FEB0
        public void TryGetType(){} // RVA: 0x7FFACC00FF30
        public void IsType(){} // RVA: 0x7FFACC00FFF0
        public void SetString(){} // RVA: 0x7FFACC010070
        public void GetString(){} // RVA: 0x7FFACC0100E0
        public void TryGetString(){} // RVA: 0x7FFACC010160
        public void SetBool(){} // RVA: 0x7FFACC010300
        public void GetBool(){} // RVA: 0x7FFACC010370
        public void TryGetBool(){} // RVA: 0x7FFACC0103F0
        public void SetSByte(){} // RVA: 0x7FFACC010500
        public void GetSByte(){} // RVA: 0x7FFACC010570
        public void TryGetSByte(){} // RVA: 0x7FFACC0105F0
        public void SetByte(){} // RVA: 0x7FFACC010700
        public void GetByte(){} // RVA: 0x7FFACC010770
        public void TryGetByte(){} // RVA: 0x7FFACC0107F0
        public void SetBytes(){} // RVA: 0x7FFACC010900
        public void GetBytes(){} // RVA: 0x7FFACC010970
        public void TryGetBytes(){} // RVA: 0x7FFACC0109F0
        public void SetShort(){} // RVA: 0x7FFACC010B90
        public void GetShort(){} // RVA: 0x7FFACC010C00
        public void TryGetShort(){} // RVA: 0x7FFACC010C80
        public void SetUShort(){} // RVA: 0x7FFACC010D90
        public void GetUShort(){} // RVA: 0x7FFACC010E00
        public void TryGetUShort(){} // RVA: 0x7FFACC010E80
        public void SetInt(){} // RVA: 0x7FFACC010F90
        public void GetInt(){} // RVA: 0x7FFACC011000
        public void TryGetInt(){} // RVA: 0x7FFACC011080
        public void SetUInt(){} // RVA: 0x7FFACC011190
        public void GetUInt(){} // RVA: 0x7FFACC011200
        public void TryGetUInt(){} // RVA: 0x7FFACC011280
        public void SetLong(){} // RVA: 0x7FFACC011390
        public void GetLong(){} // RVA: 0x7FFACC011400
        public void TryGetLong(){} // RVA: 0x7FFACC011480
        public void SetULong(){} // RVA: 0x7FFACC0115A0
        public void GetULong(){} // RVA: 0x7FFACC011610
        public void TryGetULong(){} // RVA: 0x7FFACC011690
        public void SetFloat(){} // RVA: 0x7FFACC0117B0
        public void GetFloat(){} // RVA: 0x7FFACC011820
        public void SetDouble(){} // RVA: 0x7FFACC0118A0
        public void GetDouble(){} // RVA: 0x7FFACC011910
        public void TryGetDouble(){} // RVA: 0x7FFACC011990
        public void TryGetFloat(){} // RVA: 0x7FFACC011AB0
        public void SetQuaternion(){} // RVA: 0x7FFACC011BD0
        public void GetQuaternion(){} // RVA: 0x7FFACC011C50
        public void TryGetQuaternion(){} // RVA: 0x7FFACC011CE0
        public void SetVector4(){} // RVA: 0x7FFACC011E50
        public void GetVector4(){} // RVA: 0x7FFACC011ED0
        public void TryGetVector4(){} // RVA: 0x7FFACC011F60
        public void SetVector3(){} // RVA: 0x7FFACC0120D0
        public void GetVector3(){} // RVA: 0x7FFACC012150
        public void TryGetVector3(){} // RVA: 0x7FFACC012200
        public void SetVector2(){} // RVA: 0x7FFACC012380
        public void GetVector2(){} // RVA: 0x7FFACC0123F0
        public void TryGetVector2(){} // RVA: 0x7FFACC012470
        public void SetColor(){} // RVA: 0x7FFACC012580
        public void GetColor(){} // RVA: 0x7FFACC012600
        public void TryGetColor(){} // RVA: 0x7FFACC012690
        public void SetColor32(){} // RVA: 0x7FFACC012800
        public void GetColor32(){} // RVA: 0x7FFACC012870
        public void TryGetColor32(){} // RVA: 0x7FFACC0128F0
        public void GetKeys(){} // RVA: 0x7FFACC012A00
    }

}