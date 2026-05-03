// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security
// Classes: 4
// Methods: 32

namespace ThirdParty.DotNet.Mono.Security
{
    public class ASN1 : Object
    {
        public byte m_nTag; // 0x10
        public byte[] m_aValue; // 0x18
        public System.Collections.ArrayList elist; // 0x20
        public object field_3; // 0x1
        public object field_4; // 0x2

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866F7990 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFE866F7B60
        public void get_Tag(){} // RVA: 0x7FFE811C55E0
        public void get_Length(){} // RVA: 0x7FFE866F7B90
        public void get_Value(){} // RVA: 0x7FFE866F7BB0
        public void set_Value(){} // RVA: 0x7FFE866F7C50
        public void CompareArray(){} // RVA: 0x7FFE866F7D50
        public void CompareValue(){} // RVA: 0x7FFE866F7DE0
        public void Add(){} // RVA: 0x7FFE866F7E70
        public void GetBytes(){} // RVA: 0x7FFE866F7F60
        public void Decode(){} // RVA: 0x7FFE866F8600
        public void DecodeTLV(){} // RVA: 0x7FFE866F8A40
        public void get_Item(){} // RVA: 0x7FFE866F8B90
        public void Element(){} // RVA: 0x7FFE866F8C60
        public void ToString(){} // RVA: 0x7FFE866F8D50
    }

    public class ASN1Convert : Object
    {
        // ── Methods ──
        public void FromInt32(){} // RVA: 0x7FFE866F9150
        public void FromOid(){} // RVA: 0x7FFE866F9360
        public void FromUnsignedBigInteger(){} // RVA: 0x7FFE866F9440
        public void ToInt32(){} // RVA: 0x7FFE866F95A0
        public void ToOid(){} // RVA: 0x7FFE866F96D0
        public void ToDateTime(){} // RVA: 0x7FFE866F9970
    }

    public class BitConverterLE : Object
    {
        // ── Methods ──
        public void GetUIntBytes(){} // RVA: 0x7FFE866F9FD0
        public void GetULongBytes(){} // RVA: 0x7FFE866FA060
        public void GetBytes(){} // RVA: 0x7FFE866FA1B0 | overloaded x2
        public void UShortFromBytes(){} // RVA: 0x7FFE866FA280
        public void UIntFromBytes(){} // RVA: 0x7FFE866FA2C0
        public void ToInt32(){} // RVA: 0x7FFE866FA330
        public void ToUInt16(){} // RVA: 0x7FFE866FA3A0
        public void ToUInt32(){} // RVA: 0x7FFE866FA330
    }

    public class PKCS7 : Object
    {
    }

}