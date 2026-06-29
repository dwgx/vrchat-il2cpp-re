// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.BaseEncoding
// Classes: 6
// Methods: 28

namespace ThirdParty.Other.MeaMod.DNS.BaseEncoding
{
    public class Base16 : Object
    {
        public object lowerAlphabet;
        public object upperAlphabet;

        // ── Methods ──
        public void EncodeUpper(){} // RVA: 0x654B8D0
        public void EncodeLower(){} // RVA: 0x654B920
        public void encode(){} // RVA: 0x654B970
        public void Decode(){} // RVA: 0x654BAC0
        public void getHexByte(){} // RVA: 0x654BD80
    }

    public class Base32 : Object
    {
        public object Crockford;
        public object Rfc4648;
        public object ExtendedHex;
        public object bitsPerByte;
        public object bitsPerChar;
        public object paddingChar;
        public object alphabet;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Encode(){} // RVA: 0x654BE30
        public void Decode(){} // RVA: 0x654C0E0
        public void .cctor(){} // RVA: 0x654C370
    }

    public class Base32Alphabet : EncodingAlphabet
    {
        public object crockfordAlphabet;
        public object rfc4648Alphabet;
        public object extendedHexAlphabet;
        public object zBase32Alphabet;
        public object geohashAlphabet;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x654C790
        public void get_Crockford(){} // RVA: 0x654C8E0
        public void get_Rfc4648(){} // RVA: 0x654C960
        public void get_ExtendedHex(){} // RVA: 0x654C9E0
        public void get_ZBase32(){} // RVA: 0x654CA60
        public void get_Geohash(){} // RVA: 0x654CAE0
        public void mapLowerCaseCounterparts(){} // RVA: 0x654CB60
        public void .cctor(){} // RVA: 0x654CC50
    }

    public class CrockfordBase32Alphabet : Base32Alphabet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x654D520
        public void mapAlternate(){} // RVA: 0x654D5D0
    }

    public class EncodingAlphabet : Object
    {
        public object _length;
        public object _value;
        public object lookupLength;
        public object ReverseLookupTable;

        // ── Methods ──
        public void get_Length(){} // RVA: 0xB8F8F0
        public void set_Length(){} // RVA: 0xB460A0
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void InvalidCharacter(){} // RVA: 0x654D660
        public void .ctor(){} // RVA: 0x654D740
        public void Map(){} // RVA: 0x654D9E0
        public void ToString(){} // RVA: 0xB465B0
    }

    public class Require : Object
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0xA94080
    }

}