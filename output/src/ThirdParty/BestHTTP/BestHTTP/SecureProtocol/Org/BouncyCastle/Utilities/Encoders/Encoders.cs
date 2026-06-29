// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
// Classes: 11
// Methods: 47

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
{
    public class Base64 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void ToBase64String(){} // RVA: 0x7B151CFF0
        public void Encode(){} // RVA: 0x7B151D1A0
        public void Decode(){} // RVA: 0x7B151D420
    }

    public class Base64Encoder : Object
    {
        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0x7B151D480
        public void .ctor(){} // RVA: 0x7B151D560
        public void Encode(){} // RVA: 0x7B151D690
        public void ignore(){} // RVA: 0x7B151DA50
        public void Decode(){} // RVA: 0x7B151DA70
        public void nextI(){} // RVA: 0x7B151E770
        public void DecodeString(){} // RVA: 0x7B151DEF0
        public void decodeLastBlock(){} // RVA: 0x7B151E3A0
    }

    public class BufferedDecoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151E7E0
        public void ProcessByte(){} // RVA: 0x7B151E980
        public void ProcessBytes(){} // RVA: 0x7B151EA60
    }

    public class BufferedEncoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B151EC60
        public void ProcessByte(){} // RVA: 0x7B151EE00
        public void ProcessBytes(){} // RVA: 0x7B151EEE0
    }

    public class Hex : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void ToHexString(){} // RVA: 0x7B151F140
        public void Encode(){} // RVA: 0x7B151F3F0
        public void Decode(){} // RVA: 0x7B151F6B0
        public void .cctor(){} // RVA: 0x7B151F740
    }

    public class HexEncoder : Object
    {
        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0x7B151F920
        public void .ctor(){} // RVA: 0x7B151FAC0
        public void Encode(){} // RVA: 0x7B151FBF0
        public void Ignore(){} // RVA: 0x7B151FCF0
        public void Decode(){} // RVA: 0x7B151FD10
        public void DecodeString(){} // RVA: 0x7B151FF30
    }

    public class HexTranslator : Object
    {
        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0x7A81DDCC0
        public void Encode(){} // RVA: 0x7B1520180
        public void GetDecodedBlockSize(){} // RVA: 0x7A81CA9D0
        public void Decode(){} // RVA: 0x7B15202F0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B15203F0
    }

    public class IEncoder
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7A7E0A170
        public void Decode(){} // RVA: 0x7A7E0A170
        public void DecodeString(){} // RVA: 0x7A7E06320
    }

    public class ITranslator
    {
        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0x7A7E00710
        public void Encode(){} // RVA: 0x7A7E0A1D0
        public void GetDecodedBlockSize(){} // RVA: 0x7A7E00710
        public void Decode(){} // RVA: 0x7A7E0A1D0
    }

    public class UrlBase64 : Object
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7B1520660
        public void Decode(){} // RVA: 0x7B1520AD0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1520B60
    }

    public class UrlBase64Encoder : Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1520DA0
    }

}