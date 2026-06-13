// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Utilities
// Classes: 2
// Methods: 73

namespace ThirdParty.Unity.UnityEngine.InputSystem.Utilities
{
    public class PredictiveParser
    {
        // ── Methods ──
        public void ExpectSingleChar(){} // RVA: 0x6DD4430
        public void ExpectInt(){} // RVA: 0x6DD4550
        public void ExpectString(){} // RVA: 0x6DD46B0
        public void AcceptSingleChar(){} // RVA: 0x6DD4940
        public void AcceptString(){} // RVA: 0x6DD4980
        public void AcceptInt(){} // RVA: 0x6DD4AF0
    }

    public class PrimitiveValue
    {
        public 0x657DC788 m_Type; // 0x10
        public bool m_BoolValue; // 0x14
        public char m_CharValue; // 0x14

        // ── Methods ──
        public void get_valuePtr(){} // RVA: 0x6DD4B50
        public void get_type(){} // RVA: 0x19689B0
        public void get_isEmpty(){} // RVA: 0x62E1480
        public void .ctor(){} // RVA: 0x6DD4C90 | overloaded x12
        public void ConvertTo(){} // RVA: 0x6DD4CB0
        public void Equals(){} // RVA: 0x6DD5070 | overloaded x2
        public void op_Equality(){} // RVA: 0x6DD53A0
        public void op_Inequality(){} // RVA: 0x6DD5420
        public void GetHashCode(){} // RVA: 0x6DD54A0
        public void ToString(){} // RVA: 0x6DD6460 | overloaded x2
        public void FromString(){} // RVA: 0x6DD5940
        public void GetTypeCode(){} // RVA: 0x19689B0
        public void ToBoolean(){} // RVA: 0x6DD6130
        public void ToByte(){} // RVA: 0x6DD61F0
        public void ToChar(){} // RVA: 0x6DD6200
        public void ToDateTime(){} // RVA: 0x6DD6220
        public void ToDecimal(){} // RVA: 0x6DD6270
        public void ToDouble(){} // RVA: 0x6DD62B0
        public void ToInt16(){} // RVA: 0x6DD61F0
        public void ToInt32(){} // RVA: 0x6DD61F0
        public void ToInt64(){} // RVA: 0x6DD63B0
        public void ToSByte(){} // RVA: 0x6DD61F0
        public void ToSingle(){} // RVA: 0x6DD6440
        public void ToType(){} // RVA: 0x6DD6470
        public void ToUInt16(){} // RVA: 0x6DD64B0
        public void ToUInt32(){} // RVA: 0x6DD64B0
        public void ToUInt64(){} // RVA: 0x6DD64C0
        public void ToObject(){} // RVA: 0x6DD6560
        public void From(){} // RVA: 0x283FA0
        public void FromObject(){} // RVA: 0x6DD6860
        public void op_Implicit(){} // RVA: 0x6DD72A0 | overloaded x12
        public void FromBoolean(){} // RVA: 0x6DD7140
        public void FromChar(){} // RVA: 0x6DD7160
        public void FromByte(){} // RVA: 0x6DD7180
        public void FromSByte(){} // RVA: 0x6DD71A0
        public void FromInt16(){} // RVA: 0x6DD71C0
        public void FromUInt16(){} // RVA: 0x6DD71E0
        public void FromInt32(){} // RVA: 0x6DD7200
        public void FromUInt32(){} // RVA: 0x6DD7220
        public void FromInt64(){} // RVA: 0x6DD7240
        public void FromUInt64(){} // RVA: 0x6DD7260
        public void FromSingle(){} // RVA: 0x6DD7280
        public void FromDouble(){} // RVA: 0x6DD72A0
    }

}