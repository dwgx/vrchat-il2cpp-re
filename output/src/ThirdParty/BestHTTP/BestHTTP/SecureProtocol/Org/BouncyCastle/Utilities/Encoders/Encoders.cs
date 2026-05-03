// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
// Classes: 11
// Methods: 64

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
{
    public class Base64 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ToBase64String(){} // RVA: 0x7FFE8A145940 | overloaded x2
        public void Encode(){} // RVA: 0x7FFE8A145AF0 | overloaded x4
        public void Decode(){} // RVA: 0x7FFE8A145D70 | overloaded x3
    }

    public class Base64Encoder : Object
    {
        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0x7FFE8A145DD0
        public void .ctor(){} // RVA: 0x7FFE8A145EB0
        public void Encode(){} // RVA: 0x7FFE8A145FE0
        public void ignore(){} // RVA: 0x7FFE8A1463A0
        public void Decode(){} // RVA: 0x7FFE8A1463C0
        public void nextI(){} // RVA: 0x7FFE8A147060 | overloaded x2
        public void DecodeString(){} // RVA: 0x7FFE8A146830
        public void decodeLastBlock(){} // RVA: 0x7FFE8A146CD0
    }

    public class BufferedDecoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A1470D0
        public void ProcessByte(){} // RVA: 0x7FFE8A147270
        public void ProcessBytes(){} // RVA: 0x7FFE8A147350
    }

    public class BufferedEncoder : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A147540
        public void ProcessByte(){} // RVA: 0x7FFE8A1476E0
        public void ProcessBytes(){} // RVA: 0x7FFE8A1477C0
    }

    public class Hex : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void ToHexString(){} // RVA: 0x7FFE8A147A10 | overloaded x2
        public void Encode(){} // RVA: 0x7FFE8A147CC0 | overloaded x4
        public void Decode(){} // RVA: 0x7FFE8A147F80 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE8A148010
    }

    public class HexEncoder : Object
    {
        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0x7FFE8A1481F0
        public void .ctor(){} // RVA: 0x7FFE8A148390
        public void Encode(){} // RVA: 0x7FFE8A1484C0
        public void Ignore(){} // RVA: 0x7FFE8A1485C0
        public void Decode(){} // RVA: 0x7FFE8A1485E0
        public void DecodeString(){} // RVA: 0x7FFE8A1487D0
    }

    public class HexTranslator : Object
    {
        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0x7FFE81200CB0
        public void Encode(){} // RVA: 0x7FFE8A148A20
        public void GetDecodedBlockSize(){} // RVA: 0x7FFE811EDAF0
        public void Decode(){} // RVA: 0x7FFE8A148B70
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A148C50
    }

    public class IEncoder
    {
        // ── Methods ──
        public void Encode(){}
        public void Decode(){}
        public void DecodeString(){} // RVA: 0x7FFE80E38BF0
    }

    public class ITranslator
    {
        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void Encode(){}
        public void GetDecodedBlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void Decode(){}
    }

    public class UrlBase64 : Object
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x7FFE8A148EC0 | overloaded x2
        public void Decode(){} // RVA: 0x7FFE8A149330 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A1493C0
    }

    public class UrlBase64Encoder : Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A149480
    }

}