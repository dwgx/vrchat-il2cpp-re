// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
// Classes: 11
// Methods: 64

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
{
    public class Base64
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void ToBase64String(){} // RVA: 0x7FFAFC193560 | overloaded x2
        public void Encode(){} // RVA: 0x7FFAFC193710 | overloaded x4
        public void Decode(){} // RVA: 0x7FFAFC193990 | overloaded x3
    }

    public class Base64Encoder
    {
        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0x7FFAFC1939F0
        public void .ctor(){} // RVA: 0x7FFAFC193AD0
        public void Encode(){} // RVA: 0x7FFAFC193C00
        public void ignore(){} // RVA: 0x7FFAFC193FC0
        public void Decode(){} // RVA: 0x7FFAFC193FE0
        public void nextI(){} // RVA: 0x7FFAFC194C80 | overloaded x2
        public void DecodeString(){} // RVA: 0x7FFAFC194450
        public void decodeLastBlock(){} // RVA: 0x7FFAFC1948F0
    }

    public class BufferedDecoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC194CF0
        public void ProcessByte(){} // RVA: 0x7FFAFC194E90
        public void ProcessBytes(){} // RVA: 0x7FFAFC194F70
    }

    public class BufferedEncoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC195160
        public void ProcessByte(){} // RVA: 0x7FFAFC195300
        public void ProcessBytes(){} // RVA: 0x7FFAFC1953E0
    }

    public class Hex
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void ToHexString(){} // RVA: 0x7FFAFC195630 | overloaded x2
        public void Encode(){} // RVA: 0x7FFAFC1958E0 | overloaded x4
        public void Decode(){} // RVA: 0x7FFAFC195BA0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAFC195C30
    }

    public class HexEncoder : InitialiseDecodingTable
    {
        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0x7FFAFC195E10
        public void .ctor(){} // RVA: 0x7FFAFC195FB0
        public void Encode(){} // RVA: 0x7FFAFC1960E0
        public void Ignore(){} // RVA: 0x7FFAFC1961E0
        public void Decode(){} // RVA: 0x7FFAFC196200
        public void DecodeString(){} // RVA: 0x7FFAFC1963F0
    }

    public class HexTranslator : GetEncodedBlockSize
    {
        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0x7FFAF2E92CB0
        public void Encode(){} // RVA: 0x7FFAFC196640
        public void GetDecodedBlockSize(){} // RVA: 0x7FFAF2E7FAF0
        public void Decode(){} // RVA: 0x7FFAFC196790
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC196870
    }

    public class IEncoder
    {
        // ── Methods ──
        public void Encode(){}
        public void Decode(){}
        public void DecodeString(){} // RVA: 0x7FFAF2AC7680
    }

    public class ITranslator
    {
        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void Encode(){}
        public void GetDecodedBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void Decode(){}
    }

    public class UrlBase64
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7FFAFC196AE0 | overloaded x2
        public void Decode(){} // RVA: 0x7FFAFC196F50 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC196FE0
    }

    public class UrlBase64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1970A0
    }

}