// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
// Classes: 11
// Methods: 64

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
{
    public class Base64 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ToBase64String(){} // RVA: 0x7FFACBCEC320 | overloaded x2
        public void Encode(){} // RVA: 0x7FFACBCEC4D0 | overloaded x4
        public void Decode(){} // RVA: 0x7FFACBCEC750 | overloaded x3
    }

    public class Base64Encoder : Object
    {
        public byte[] encodingTable; // 0x10
        public byte padding; // 0x18
        public byte[] decodingTable; // 0x20

        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0x7FFACBCEC7B0
        public void .ctor(){} // RVA: 0x7FFACBCEC890
        public void Encode(){} // RVA: 0x7FFACBCEC9C0
        public void ignore(){} // RVA: 0x7FFACBCECD80
        public void Decode(){} // RVA: 0x7FFACBCECDA0
        public void nextI(){} // RVA: 0x7FFACBCEDA40 | overloaded x2
        public void DecodeString(){} // RVA: 0x7FFACBCED210
        public void decodeLastBlock(){} // RVA: 0x7FFACBCED6B0
    }

    public class BufferedDecoder : Object
    {
        public byte[] buffer; // 0x10
        public int bufOff; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders.ITranslator translator; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCEDAB0
        public void ProcessByte(){} // RVA: 0x7FFACBCEDC50
        public void ProcessBytes(){} // RVA: 0x7FFACBCEDD30
    }

    public class BufferedEncoder : Object
    {
        public byte[] Buffer; // 0x10
        public int bufOff; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders.ITranslator translator; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCEDF20
        public void ProcessByte(){} // RVA: 0x7FFACBCEE0C0
        public void ProcessBytes(){} // RVA: 0x7FFACBCEE1A0
    }

    public class Hex : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders.IEncoder encoder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void ToHexString(){} // RVA: 0x7FFACBCEE3F0 | overloaded x2
        public void Encode(){} // RVA: 0x7FFACBCEE6A0 | overloaded x4
        public void Decode(){} // RVA: 0x7FFACBCEE960 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFACBCEE9F0
    }

    public class HexEncoder : Object
    {
        public byte[] encodingTable; // 0x10
        public byte[] decodingTable; // 0x18

        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0x7FFACBCEEBD0
        public void .ctor(){} // RVA: 0x7FFACBCEED70
        public void Encode(){} // RVA: 0x7FFACBCEEEA0
        public void Ignore(){} // RVA: 0x7FFACBCEEFA0
        public void Decode(){} // RVA: 0x7FFACBCEEFC0
        public void DecodeString(){} // RVA: 0x7FFACBCEF1B0
    }

    public class HexTranslator : Object
    {
        public byte[] hexTable;

        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0x7FFAC3026CB0
        public void Encode(){} // RVA: 0x7FFACBCEF400
        public void GetDecodedBlockSize(){} // RVA: 0x7FFAC3013AF0
        public void Decode(){} // RVA: 0x7FFACBCEF550
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBCEF630
    }

    public class IEncoder
    {
        // ── Methods ──
        public void Encode(){}
        public void Decode(){}
        public void DecodeString(){} // RVA: 0x7FFAC2C637A0
    }

    public class ITranslator
    {
        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0x7FFAC2C59960
        public void Encode(){}
        public void GetDecodedBlockSize(){} // RVA: 0x7FFAC2C59960
        public void Decode(){}
    }

    public class UrlBase64 : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders.IEncoder encoder;

        // ── Methods ──
        public void Encode(){} // RVA: 0x7FFACBCEF8A0 | overloaded x2
        public void Decode(){} // RVA: 0x7FFACBCEFD10 | overloaded x4
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBCEFDA0
    }

    public class UrlBase64Encoder : Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBCEFE60
    }

}