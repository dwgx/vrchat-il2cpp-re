// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.InputSystem.Utilities
// Classes: 2
// Methods: 49

namespace ThirdParty.Unity.UnityEngine.InputSystem.Utilities
{
    public class PredictiveParser : ValueType
    {
        public object m_Position;

        // ── Methods ──
        public void ExpectSingleChar(){} // RVA: 0x92F1C0
        public void ExpectInt(){} // RVA: 0x92F1E0
        public void ExpectString(){} // RVA: 0x92F200
        public void AcceptSingleChar(){} // RVA: 0x92F240
        public void AcceptString(){} // RVA: 0x92F280
        public void AcceptInt(){} // RVA: 0x92F2A0
    }

    public class PrimitiveValue : ValueType
    {
        public object m_Type;
        public object m_BoolValue;
        public object m_CharValue;
        public object m_ByteValue;
        public object m_SByteValue;
        public object m_ShortValue;
        public object m_UShortValue;
        public object m_IntValue;
        public object m_UIntValue;
        public object m_LongValue;
        public object m_ULongValue;
        public object m_FloatValue;
        public object m_DoubleValue;

        // ── Methods ──
        public void get_valuePtr(){} // RVA: 0x92F3C0
        public void get_type(){} // RVA: 0x77E60
        public void get_isEmpty(){} // RVA: 0x8E95B0
        public void .ctor(){} // RVA: 0x92F530
        public void ConvertTo(){} // RVA: 0x92F550
        public void Equals(){} // RVA: 0x92F600
        public void op_Equality(){} // RVA: 0x7833680
        public void op_Inequality(){} // RVA: 0x7833700
        public void GetHashCode(){} // RVA: 0x92F610
        public void ToString(){} // RVA: 0x92F7B0
        public void FromString(){} // RVA: 0x7833C20
        public void GetTypeCode(){} // RVA: 0x77E60
        public void ToBoolean(){} // RVA: 0x92F660
        public void ToByte(){} // RVA: 0x92F670
        public void ToChar(){} // RVA: 0x92F680
        public void ToDateTime(){} // RVA: 0x92F6B0
        public void ToDecimal(){} // RVA: 0x92F6C0
        public void ToDouble(){} // RVA: 0x92F770
        public void ToInt16(){} // RVA: 0x92F670
        public void ToInt32(){} // RVA: 0x92F670
        public void ToInt64(){} // RVA: 0x92F780
        public void ToSByte(){} // RVA: 0x92F670
        public void ToSingle(){} // RVA: 0x92F790
        public void ToType(){} // RVA: 0x92F7C0
        public void ToUInt16(){} // RVA: 0x92F7D0
        public void ToUInt32(){} // RVA: 0x92F7D0
        public void ToUInt64(){} // RVA: 0x92F7E0
        public void ToObject(){} // RVA: 0x92F7F0
        public void From(){} // RVA: 0xA94080
        public void FromObject(){} // RVA: 0x7834A10
        public void op_Implicit(){} // RVA: 0x7835320
        public void FromBoolean(){} // RVA: 0x78351C0
        public void FromChar(){} // RVA: 0x78351E0
        public void FromByte(){} // RVA: 0x7835200
        public void FromSByte(){} // RVA: 0x7835220
        public void FromInt16(){} // RVA: 0x7835240
        public void FromUInt16(){} // RVA: 0x7835260
        public void FromInt32(){} // RVA: 0x7835280
        public void FromUInt32(){} // RVA: 0x78352A0
        public void FromInt64(){} // RVA: 0x78352C0
        public void FromUInt64(){} // RVA: 0x78352E0
        public void FromSingle(){} // RVA: 0x7835300
        public void FromDouble(){} // RVA: 0x7835320
    }

}