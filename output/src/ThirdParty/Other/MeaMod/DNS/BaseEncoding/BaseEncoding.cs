// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.BaseEncoding
// Classes: 6
// Methods: 28

namespace ThirdParty.Other.MeaMod.DNS.BaseEncoding
{
    public class Base16 : Object
    {
        // ── Methods ──
        public void EncodeUpper(){} // RVA: 0x7AD8BE5E0
        public void EncodeLower(){} // RVA: 0x7AD8BE630
        public void encode(){} // RVA: 0x7AD8BE680
        public void Decode(){} // RVA: 0x7AD8BE870
        public void getHexByte(){} // RVA: 0x7AD8BEB40
    }

    public class Base32 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Encode(){} // RVA: 0x7AD8BEC00
        public void Decode(){} // RVA: 0x7AD8BEEB0
        public void .cctor(){} // RVA: 0x7AD8BF140
    }

    public class Base32Alphabet : EncodingAlphabet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8BF560
        public void get_Crockford(){} // RVA: 0x7AD8BF6D0
        public void get_Rfc4648(){} // RVA: 0x7AD8BF750
        public void get_ExtendedHex(){} // RVA: 0x7AD8BF7D0
        public void get_ZBase32(){} // RVA: 0x7AD8BF850
        public void get_Geohash(){} // RVA: 0x7AD8BF8D0
        public void mapLowerCaseCounterparts(){} // RVA: 0x7AD8BF950
        public void .cctor(){} // RVA: 0x7AD8BFA60
    }

    public class CrockfordBase32Alphabet : Base32Alphabet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD8C0330
        public void mapAlternate(){} // RVA: 0x7AD8C03E0
    }

    public class EncodingAlphabet : Object
    {
        // ── Methods ──
        public void get_Length(){} // RVA: 0x7A8124910
        public void set_Length(){} // RVA: 0x7A80DA0C0
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void InvalidCharacter(){} // RVA: 0x7AD8C0490
        public void .ctor(){} // RVA: 0x7AD8C0580
        public void Map(){} // RVA: 0x7AD8C0830
        public void ToString(){} // RVA: 0x7A80DA7B0
    }

    public class Require : Object
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0x7A8051B10
    }

}