// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security
// Classes: 5
// Methods: 44

namespace ThirdParty.DotNet.Mono.Security
{
    public class ASN1 : Object
    {
        public object m_nTag;
        public object m_aValue;
        public object elist;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x662F600
        public void get_Count(){} // RVA: 0x662F7C0
        public void get_Tag(){} // RVA: 0xC120A0
        public void get_Length(){} // RVA: 0x662F7F0
        public void get_Value(){} // RVA: 0x662F810
        public void set_Value(){} // RVA: 0x662F8B0
        public void CompareArray(){} // RVA: 0x662F9B0
        public void CompareValue(){} // RVA: 0x662FA40
        public void Add(){} // RVA: 0x662FAC0
        public void GetBytes(){} // RVA: 0x662FBB0
        public void Decode(){} // RVA: 0x6630240
        public void DecodeTLV(){} // RVA: 0x6630680
        public void get_Item(){} // RVA: 0x66307D0
        public void Element(){} // RVA: 0x66308A0
        public void ToString(){} // RVA: 0x6630990
    }

    public class ASN1 : Object
    {
        public object m_nTag;
        public object m_aValue;
        public object elist;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x667DB80
        public void get_Count(){} // RVA: 0x662F7C0
        public void get_Value(){} // RVA: 0x667DD40
        public void Add(){} // RVA: 0x667DDE0
        public void GetBytes(){} // RVA: 0x667DED0
        public void Decode(){} // RVA: 0x667E560
        public void DecodeTLV(){} // RVA: 0x667E9A0
        public void ToString(){} // RVA: 0x667EAF0
    }

    public class ASN1Convert : Object
    {
        // ── Methods ──
        public void FromInt32(){} // RVA: 0x6630D90
        public void FromOid(){} // RVA: 0x6630FB0
        public void FromUnsignedBigInteger(){} // RVA: 0x6631090
        public void ToInt32(){} // RVA: 0x66311F0
        public void ToOid(){} // RVA: 0x6631330
        public void ToDateTime(){} // RVA: 0x66315B0
    }

    public class BitConverterLE : Object
    {
        // ── Methods ──
        public void GetUIntBytes(){} // RVA: 0x6631C00
        public void GetULongBytes(){} // RVA: 0x6631C90
        public void GetBytes(){} // RVA: 0x6631DE0
        public void UShortFromBytes(){} // RVA: 0x6631EB0
        public void UIntFromBytes(){} // RVA: 0x6631EF0
        public void ToInt32(){} // RVA: 0x6631F60
        public void ToUInt16(){} // RVA: 0x6631FD0
        public void ToUInt32(){} // RVA: 0x6631F60
    }

    public class BitConverterLE : Object
    {
        // ── Methods ──
        public void GetUIntBytes(){} // RVA: 0x667EEF0
        public void GetULongBytes(){} // RVA: 0x667EF80
        public void GetBytes(){} // RVA: 0x667F160
        public void UIntFromBytes(){} // RVA: 0x6631EF0
        public void ULongFromBytes(){} // RVA: 0x667F230
        public void ToSingle(){} // RVA: 0x667F280
        public void ToDouble(){} // RVA: 0x667F300
    }

}