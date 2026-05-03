// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.MeaMod.DNS.BaseEncoding
// Classes: 6
// Methods: 28

namespace ThirdParty.Other.MeaMod.DNS.BaseEncoding
{
    public class Base16 : Object
    {
        // ── Methods ──
        public void EncodeUpper(){} // RVA: 0x7FFE86611D70
        public void EncodeLower(){} // RVA: 0x7FFE86611DC0
        public void encode(){} // RVA: 0x7FFE86611E10
        public void Decode(){} // RVA: 0x7FFE86612000
        public void getHexByte(){} // RVA: 0x7FFE866122D0
    }

    public class Base32 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Encode(){} // RVA: 0x7FFE86612380
        public void Decode(){} // RVA: 0x7FFE86612640
        public void .cctor(){} // RVA: 0x7FFE866128D0
    }

    public class Base32Alphabet : EncodingAlphabet
    {
        public System.Lazy`1<MeaMod.DNS.BaseEncoding.CrockfordBase32Alphabet> crockfordAlphabet;
        public System.Lazy`1<MeaMod.DNS.BaseEncoding.Base32Alphabet> rfc4648Alphabet; // 0x8
        public System.Lazy`1<MeaMod.DNS.BaseEncoding.Base32Alphabet> extendedHexAlphabet; // 0x10
        public System.Lazy`1<MeaMod.DNS.BaseEncoding.Base32Alphabet> zBase32Alphabet; // 0x18
        public System.Lazy`1<MeaMod.DNS.BaseEncoding.Base32Alphabet> geohashAlphabet; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86612CF0
        public void get_Crockford(){} // RVA: 0x7FFE86612E60
        public void get_Rfc4648(){} // RVA: 0x7FFE86612EE0
        public void get_ExtendedHex(){} // RVA: 0x7FFE86612F60
        public void get_ZBase32(){} // RVA: 0x7FFE86612FE0
        public void get_Geohash(){} // RVA: 0x7FFE86613060
        public void mapLowerCaseCounterparts(){} // RVA: 0x7FFE866130E0
        public void .cctor(){} // RVA: 0x7FFE866131F0
    }

    public class CrockfordBase32Alphabet : Base32Alphabet
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86613AC0
        public void mapAlternate(){} // RVA: 0x7FFE86613B70
    }

    public class EncodingAlphabet : Object
    {
        public int _length; // 0x10
        public string _value; // 0x18

        // ── Methods ──
        public void get_Length(){} // RVA: 0x7FFE811485C0
        public void set_Length(){} // RVA: 0x7FFE810FE0C0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void InvalidCharacter(){} // RVA: 0x7FFE86613C20
        public void .ctor(){} // RVA: 0x7FFE86613D10
        public void Map(){} // RVA: 0x7FFE86613FC0
        public void ToString(){} // RVA: 0x7FFE810FE7C0
    }

    public class Require : Object
    {
        // ── Methods ──
        public void NotNull(){} // RVA: 0x7FFE810A1420
    }

}