// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System
// Classes: 8
// Methods: 125

namespace ThirdParty.DotNet.System
{
    public class BRECORD : ValueType
    {
        public UIntPtr pvRecord; // 0x10
        public UIntPtr pRecInfo; // 0x18
    }

    public class BadImageFormatException : SystemException
    {
        public string Message; // 0x90
        public string _fusionLog; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC850B2C0 | overloaded x5
        public void GetObjectData(){} // RVA: 0x7FFAC850B460
        public void get_Message(){} // RVA: 0x7FFAC850B770
        public void SetMessageField(){} // RVA: 0x7FFAC850B890
        public void ToString(){} // RVA: 0x7FFAC850B9B0
    }

    public class BitConverter : Object
    {
        public bool IsLittleEndian;

        // ── Methods ──
        public void GetBytes(){} // RVA: 0x7FFAC850BFA0 | overloaded x10
        public void TryWriteBytes(){} // RVA: 0x7FFAC850BE60
        public void ToChar(){} // RVA: 0x7FFAC44C2C40
        public void ToInt16(){} // RVA: 0x7FFAC44C2C40
        public void ToInt32(){} // RVA: 0x7FFAC850C070 | overloaded x2
        public void ToInt64(){} // RVA: 0x7FFAC850C0D0
        public void ToUInt16(){} // RVA: 0x7FFAC44C2C40
        public void ToUInt32(){} // RVA: 0x7FFAC850C010
        public void ToUInt64(){} // RVA: 0x7FFAC850C0D0
        public void ToSingle(){} // RVA: 0x7FFAC850C130
        public void ToDouble(){} // RVA: 0x7FFAC850C190
        public void ToString(){} // RVA: 0x7FFAC850C7A0 | overloaded x2
        public void ToBoolean(){} // RVA: 0x7FFAC850C7D0
        public void DoubleToInt64Bits(){} // RVA: 0x7FFAC850C830
        public void Int64BitsToDouble(){} // RVA: 0x7FFAC850C840
        public void SingleToInt32Bits(){} // RVA: 0x7FFAC850C850
        public void Int32BitsToSingle(){} // RVA: 0x7FFAC850C860
        public void .cctor(){} // RVA: 0x7FFAC850C870
    }

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
        public void GetHashCode(){} // RVA: 0x7FFAC850CB90
        public void ToString(){} // RVA: 0x7FFAC850CC00 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC850CD20 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC850CE20 | overloaded x2
        public void Parse(){} // RVA: 0x7FFAC850CFC0 | overloaded x2
        public void TryParse(){} // RVA: 0x7FFAC850D140 | overloaded x2
        public void TrimWhiteSpaceAndNull(){} // RVA: 0x7FFAC850D4F0
        public void GetTypeCode(){} // RVA: 0x7FFAC366FE20
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC850D690
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC850D6A0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC850D730
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC850D780
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC850D7D0
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC850D820
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC850D870
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC850D8C0
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC850D910
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC850D960
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC850D9B0
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC850DA10
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC850DA70
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC850DB30
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC850DBC0
        public void .cctor(){} // RVA: 0x7FFAC850DC60
    }

    public class Buffer : Object
    {
        // ── Methods ──
        public void InternalBlockCopy(){} // RVA: 0x7FFAC866D980
        public void IndexOfByte(){} // RVA: 0x7FFAC866DA40
        public void _ByteLength(){} // RVA: 0x7FFAC866DAF0
        public void ZeroMemory(){} // RVA: 0x7FFAC866DB00
        public void Memcpy(){} // RVA: 0x7FFAC866E400 | overloaded x2
        public void InternalMemcpy(){} // RVA: 0x7FFAC866DB70
        public void ByteLength(){} // RVA: 0x7FFAC866DB80
        public void GetByte(){} // RVA: 0x7FFAC866DC30
        public void SetByte(){} // RVA: 0x7FFAC866DD40
        public void BlockCopy(){} // RVA: 0x7FFAC866DE60
        public void MemoryCopy(){} // RVA: 0x7FFAC866E110
        public void memcpy4(){} // RVA: 0x7FFAC866E230
        public void memcpy2(){} // RVA: 0x7FFAC866E2D0
        public void memcpy1(){} // RVA: 0x7FFAC866E350
        public void Memmove(){} // RVA: 0x7FFAC2C72360 | overloaded x2
    }

    public class ByReference`1 : ValueType
    {
        public UIntPtr Value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_Value(){} // RVA: 0x7FFAC2C58E90
    }

    public class Byte : ValueType
    {
        public byte m_value; // 0x10
        public byte MaxValue;
        public byte MinValue;

        // ── Methods ──
        public void CompareTo(){} // RVA: 0x7FFAC850DE60 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC850CD20 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC495DDF0
        public void Parse(){} // RVA: 0x7FFAC850E170 | overloaded x5
        public void TryParse(){} // RVA: 0x7FFAC850E400 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAC850E6D0 | overloaded x4
        public void TryFormat(){} // RVA: 0x7FFAC850E7A0
        public void GetTypeCode(){} // RVA: 0x7FFAC36A9850
        public void System.IConvertible.ToBoolean(){} // RVA: 0x7FFAC850E850
        public void System.IConvertible.ToChar(){} // RVA: 0x7FFAC850E8A0
        public void System.IConvertible.ToSByte(){} // RVA: 0x7FFAC850E8F0
        public void System.IConvertible.ToByte(){} // RVA: 0x7FFAC495DDF0
        public void System.IConvertible.ToInt16(){} // RVA: 0x7FFAC850E980
        public void System.IConvertible.ToUInt16(){} // RVA: 0x7FFAC850E9D0
        public void System.IConvertible.ToInt32(){} // RVA: 0x7FFAC850EA20
        public void System.IConvertible.ToUInt32(){} // RVA: 0x7FFAC850EA70
        public void System.IConvertible.ToInt64(){} // RVA: 0x7FFAC850EAC0
        public void System.IConvertible.ToUInt64(){} // RVA: 0x7FFAC850EB10
        public void System.IConvertible.ToSingle(){} // RVA: 0x7FFAC850EB60
        public void System.IConvertible.ToDouble(){} // RVA: 0x7FFAC850EBB0
        public void System.IConvertible.ToDecimal(){} // RVA: 0x7FFAC850EC00
        public void System.IConvertible.ToDateTime(){} // RVA: 0x7FFAC850ECB0
        public void System.IConvertible.ToType(){} // RVA: 0x7FFAC850ED40
    }

    public class ByteMatcher : Object
    {
        public System.Collections.Hashtable map; // 0x10
        public System.Collections.Hashtable starts; // 0x18

        // ── Methods ──
        public void AddMapping(){} // RVA: 0x7FFAC86AB5C0
        public void Sort(){} // RVA: 0x7FFAC2F21310
        public void StartsWith(){} // RVA: 0x7FFAC86AB700
        public void Match(){} // RVA: 0x7FFAC86AB780
        public void .ctor(){} // RVA: 0x7FFAC86ABA90
    }

}