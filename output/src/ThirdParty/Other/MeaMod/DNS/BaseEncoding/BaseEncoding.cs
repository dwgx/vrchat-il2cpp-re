// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.BaseEncoding
// Classes: 6
// Methods: 28

namespace ThirdParty.Other.MeaMod.DNS.BaseEncoding
{
    public class Base16 : Object
    {
        public string lowerAlphabet;
        public string upperAlphabet;

        // ── Methods ──
        public void EncodeUpper(){} // RVA: 0x7FFAC8268450
        public void EncodeLower(){} // RVA: 0x7FFAC82684A0
        public void encode(){} // RVA: 0x7FFAC82684F0
        public void Decode(){} // RVA: 0x7FFAC82686E0
        public void getHexByte(){} // RVA: 0x7FFAC82689B0
    }

    public class Base32 : Object
    {
        public MeaMod.DNS.BaseEncoding.Base32 Crockford;
        public MeaMod.DNS.BaseEncoding.Base32 Rfc4648; // 0x8
        public MeaMod.DNS.BaseEncoding.Base32 ExtendedHex; // 0x10
        public int bitsPerByte;
        public int bitsPerChar;
        public char paddingChar;
        public MeaMod.DNS.BaseEncoding.Base32Alphabet alphabet; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Encode(){} // RVA: 0x7FFAC8268A60
        public void Decode(){} // RVA: 0x7FFAC8268D20
        public void .cctor(){} // RVA: 0x7FFAC8268FB0
    }

    public class Base32Alphabet : EncodingAlphabet
    {
        public System.Lazy`1<MeaMod.DNS.BaseEncoding.CrockfordBase32Alphabet> Crockford;
        public System.Lazy`1<MeaMod.DNS.BaseEncoding.Base32Alphabet> Rfc4648; // 0x8
        public System.Lazy`1<MeaMod.DNS.BaseEncoding.Base32Alphabet> ExtendedHex; // 0x10
        public System.Lazy`1<MeaMod.DNS.BaseEncoding.Base32Alphabet> ZBase32; // 0x18
        public System.Lazy`1<MeaMod.DNS.BaseEncoding.Base32Alphabet> Geohash; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82693D0
        public void get_Crockford(){} // RVA: 0x7FFAC8269540
        public void get_Rfc4648(){} // RVA: 0x7FFAC82695C0
        public void get_ExtendedHex(){} // RVA: 0x7FFAC8269640
        public void get_ZBase32(){} // RVA: 0x7FFAC82696C0
        public void get_Geohash(){} // RVA: 0x7FFAC8269740
        public void mapLowerCaseCounterparts(){} // RVA: 0x7FFAC82697C0
        public void .cctor(){} // RVA: 0x7FFAC82698D0
    }

    public class CrockfordBase32Alphabet : Base32Alphabet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC826A1A0
        public void mapAlternate(){} // RVA: 0x7FFAC826A250
    }

    public class EncodingAlphabet : Object
    {
        public int Length; // 0x10
        public string Value; // 0x18
        public int lookupLength;
        public byte[] ReverseLookupTable; // 0x20

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFAC2F6E5C0
        public void set_Length(){} // RVA: 0x7FFAC2F240C0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void InvalidCharacter(){} // RVA: 0x7FFAC826A300
        public void .ctor(){} // RVA: 0x7FFAC826A3F0
        public void Map(){} // RVA: 0x7FFAC826A6A0
        public void ToString(){} // RVA: 0x7FFAC2F247C0
    }

    public class Require : Object
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0x7FFAC2E8DC40
    }

}