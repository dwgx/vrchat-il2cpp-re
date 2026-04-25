// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security
// Classes: 4
// Methods: 32

namespace ThirdParty.DotNet.Mono.Security
{
    public class ASN1 : Object
    {
        public byte Count; // 0x10
        public byte[] Tag; // 0x18
        public System.Collections.ArrayList Length; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC834E090 | overloaded x3
        public void get_Count(){} // RVA: 0x7FFAC834E260
        public void get_Tag(){} // RVA: 0x7FFAC2FEB5E0
        public void get_Length(){} // RVA: 0x7FFAC834E290
        public void get_Value(){} // RVA: 0x7FFAC834E2B0
        public void set_Value(){} // RVA: 0x7FFAC834E350
        public void CompareArray(){} // RVA: 0x7FFAC834E450
        public void CompareValue(){} // RVA: 0x7FFAC834E4E0
        public void Add(){} // RVA: 0x7FFAC834E570
        public void GetBytes(){} // RVA: 0x7FFAC834E660
        public void Decode(){} // RVA: 0x7FFAC834ED00
        public void DecodeTLV(){} // RVA: 0x7FFAC834F140
        public void get_Item(){} // RVA: 0x7FFAC834F290
        public void Element(){} // RVA: 0x7FFAC834F360
        public void ToString(){} // RVA: 0x7FFAC834F450
    }

    public class ASN1Convert : Object
    {
        // ── Methods ──
        public void FromInt32(){} // RVA: 0x7FFAC834F850
        public void FromOid(){} // RVA: 0x7FFAC834FA60
        public void FromUnsignedBigInteger(){} // RVA: 0x7FFAC834FB40
        public void ToInt32(){} // RVA: 0x7FFAC834FCA0
        public void ToOid(){} // RVA: 0x7FFAC834FDD0
        public void ToDateTime(){} // RVA: 0x7FFAC8350070
    }

    public class BitConverterLE : Object
    {
        // ── Methods ──
        public void GetUIntBytes(){} // RVA: 0x7FFAC83506D0
        public void GetULongBytes(){} // RVA: 0x7FFAC8350760
        public void GetBytes(){} // RVA: 0x7FFAC83508B0 | overloaded x2
        public void UShortFromBytes(){} // RVA: 0x7FFAC8350980
        public void UIntFromBytes(){} // RVA: 0x7FFAC83509C0
        public void ToInt32(){} // RVA: 0x7FFAC8350A30
        public void ToUInt16(){} // RVA: 0x7FFAC8350AA0
        public void ToUInt32(){} // RVA: 0x7FFAC8350A30
    }

    public class PKCS7 : Object
    {
    }

}