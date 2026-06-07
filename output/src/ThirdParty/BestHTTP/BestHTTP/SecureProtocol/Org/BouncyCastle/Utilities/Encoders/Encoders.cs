// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
// Classes: 11
// Methods: 64

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
{
    public class Base64
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void ToBase64String(){} // RVA: 0x96E3560 | overloaded x2
        public void Encode(){} // RVA: 0x96E3710 | overloaded x4
        public void Decode(){} // RVA: 0x96E3990 | overloaded x3
    }

    public class Base64Encoder
    {
        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0x96E39F0
        public void .ctor(){} // RVA: 0x96E3AD0
        public void Encode(){} // RVA: 0x96E3C00
        public void ignore(){} // RVA: 0x96E3FC0
        public void Decode(){} // RVA: 0x96E3FE0
        public void nextI(){} // RVA: 0x96E4C80 | overloaded x2
        public void DecodeString(){} // RVA: 0x96E4450
        public void decodeLastBlock(){} // RVA: 0x96E48F0
    }

    public class BufferedDecoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E4CF0
        public void ProcessByte(){} // RVA: 0x96E4E90
        public void ProcessBytes(){} // RVA: 0x96E4F70
    }

    public class BufferedEncoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E5160
        public void ProcessByte(){} // RVA: 0x96E5300
        public void ProcessBytes(){} // RVA: 0x96E53E0
    }

    public class Hex
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void ToHexString(){} // RVA: 0x96E5630 | overloaded x2
        public void Encode(){} // RVA: 0x96E58E0 | overloaded x4
        public void Decode(){} // RVA: 0x96E5BA0 | overloaded x3
        public void .cctor(){} // RVA: 0x96E5C30
    }

    public class HexEncoder : InitialiseDecodingTable
    {
        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0x96E5E10
        public void .ctor(){} // RVA: 0x96E5FB0
        public void Encode(){} // RVA: 0x96E60E0
        public void Ignore(){} // RVA: 0x96E61E0
        public void Decode(){} // RVA: 0x96E6200
        public void DecodeString(){} // RVA: 0x96E63F0
    }

    public class HexTranslator : GetEncodedBlockSize
    {
        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0x3E2CB0
        public void Encode(){} // RVA: 0x96E6640
        public void GetDecodedBlockSize(){} // RVA: 0x3CFAF0
        public void Decode(){} // RVA: 0x96E6790
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x96E6870
    }

    public class IEncoder
    {
        // ── Methods ──
        public void Encode(){}
        public void Decode(){}
        public void DecodeString(){} // RVA: 0x17680
    }

    public class ITranslator
    {
        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0xD840
        public void Encode(){}
        public void GetDecodedBlockSize(){} // RVA: 0xD840
        public void Decode(){}
    }

    public class UrlBase64
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x96E6AE0 | overloaded x2
        public void Decode(){} // RVA: 0x96E6F50 | overloaded x4
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x96E6FE0
    }

    public class UrlBase64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96E70A0
    }

}