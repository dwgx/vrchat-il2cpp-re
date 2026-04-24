// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 4
// Methods: 82

namespace ThirdParty.DotNet.System
{
    public class Boolean : ValueType
    {
        public bool m_value; // 0x10
        public int True;
        public int False;
        public string TrueLiteral;
        public string FalseLiteral;
        public string TrueString;
        public string FalseString; // 0x8

        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x7FFD5392CB90
        public void ToString(){} // RVA: 0x7FFD5392CC00 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD5392CD20 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFD5392CE20 | overloaded x2
        public void Parse(){} // RVA: 0x7FFD5392CFC0 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFD5392D140 | overloaded x2
        public void TrimWhiteSpaceAndNull(){} // RVA: 0x7FFD5392D4F0
        public void GetTypeCode(){} // RVA: 0x7FFD4EA8FE20
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD5392D690
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD5392D6A0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD5392D730
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD5392D780
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD5392D7D0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD5392D820
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD5392D870
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD5392D8C0
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD5392D910
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD5392D960
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD5392D9B0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD5392DA10
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD5392DA70
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD5392DB30
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD5392DBC0
        public void .cctor(){} // RVA: 0x7FFD5392DC60
    }

    public class Buffer : Object
    {
        // ── Methods ──
        public void InternalBlockCopy(){} // RVA: 0x7FFD53A8D980
        public void IndexOfByte(){} // RVA: 0x7FFD53A8DA40
        public void _ByteLength(){} // RVA: 0x7FFD53A8DAF0
        public void ZeroMemory(){} // RVA: 0x7FFD53A8DB00
        public void Memcpy(){} // RVA: 0x7FFD53A8E400 | overloaded x2
        public void InternalMemcpy(){} // RVA: 0x7FFD53A8DB70
        public void ByteLength(){} // RVA: 0x7FFD53A8DB80
        public void GetByte(){} // RVA: 0x7FFD53A8DC30
        public void SetByte(){} // RVA: 0x7FFD53A8DD40
        public void BlockCopy(){} // RVA: 0x7FFD53A8DE60
        public void MemoryCopy(){} // RVA: 0x7FFD53A8E110
        public void memcpy4(){} // RVA: 0x7FFD53A8E230
        public void memcpy2(){} // RVA: 0x7FFD53A8E2D0
        public void memcpy1(){} // RVA: 0x7FFD53A8E350
        public void Memmove(){} // RVA: 0x7FFD4E092360 | overloaded x2
    }

    public class ByReference`1 : ValueType
    {
        public object Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void get_Value(){} // RVA: 0x7FFD4E078E90
    }

    public class Byte : ValueType
    {
        public byte m_value; // 0x10
        public byte MaxValue;
        public byte MinValue;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFD5392DE60 | overloaded x2
        public void Equals(){} // RVA: 0x7FFD5392CD20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4FD7DDF0
        public void Parse(){} // RVA: 0x7FFD5392E170 | overloaded x5
        public void TryParse(){} // RVA: 0x7FFD5392E400 | overloaded x3
        public void ToString(){} // RVA: 0x7FFD5392E6D0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFD5392E7A0
        public void GetTypeCode(){} // RVA: 0x7FFD4EAC9850
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFD5392E850
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFD5392E8A0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFD5392E8F0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFD4FD7DDF0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFD5392E980
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFD5392E9D0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFD5392EA20
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFD5392EA70
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFD5392EAC0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFD5392EB10
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFD5392EB60
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFD5392EBB0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFD5392EC00
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFD5392ECB0
        public void System.IConvertible.ToType(){} // RVA: 0x7FFD5392ED40
    }

}