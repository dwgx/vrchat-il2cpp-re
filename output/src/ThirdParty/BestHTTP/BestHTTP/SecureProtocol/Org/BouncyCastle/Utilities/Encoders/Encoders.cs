// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
// Classes: 11
// Methods: 47

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Utilities.Encoders
{
    public class Base64 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ToBase64String(){} // RVA: 0xA388360
        public void Encode(){} // RVA: 0xA388510
        public void Decode(){} // RVA: 0xA388790
    }

    public class Base64Encoder : Object
    {
        public object encodingTable;
        public object padding;
        public object decodingTable;

        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0xA3887F0
        public void .ctor(){} // RVA: 0xA3888D0
        public void Encode(){} // RVA: 0xA388A00
        public void ignore(){} // RVA: 0xA388DC0
        public void Decode(){} // RVA: 0xA388DE0
        public void nextI(){} // RVA: 0xA389AE0
        public void DecodeString(){} // RVA: 0xA389260
        public void decodeLastBlock(){} // RVA: 0xA389710
    }

    public class BufferedDecoder : Object
    {
        public object buffer;
        public object bufOff;
        public object translator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA389B50
        public void ProcessByte(){} // RVA: 0xA389CF0
        public void ProcessBytes(){} // RVA: 0xA389DD0
    }

    public class BufferedEncoder : Object
    {
        public object Buffer;
        public object bufOff;
        public object translator;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA389FD0
        public void ProcessByte(){} // RVA: 0xA38A170
        public void ProcessBytes(){} // RVA: 0xA38A250
    }

    public class Hex : Object
    {
        public object encoder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void ToHexString(){} // RVA: 0xA38A4B0
        public void Encode(){} // RVA: 0xA38A760
        public void Decode(){} // RVA: 0xA38AA20
        public void .cctor(){} // RVA: 0xA38AAB0
    }

    public class HexEncoder : Object
    {
        public object encodingTable;
        public object decodingTable;

        // ── Methods ──
        public void InitialiseDecodingTable(){} // RVA: 0xA38AC90
        public void .ctor(){} // RVA: 0xA38AE30
        public void Encode(){} // RVA: 0xA38AF60
        public void Ignore(){} // RVA: 0xA38B060
        public void Decode(){} // RVA: 0xA38B080
        public void DecodeString(){} // RVA: 0xA38B2A0
    }

    public class HexTranslator : Object
    {
        public object hexTable;

        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0xC50A80
        public void Encode(){} // RVA: 0xA38B4F0
        public void GetDecodedBlockSize(){} // RVA: 0xC3CCE0
        public void Decode(){} // RVA: 0xA38B660
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA38B760
    }

    public class IEncoder
    {
        // ── Methods ──
        public void Encode(){} // RVA: 0x885B30
        public void Decode(){} // RVA: 0x885B30
        public void DecodeString(){} // RVA: 0x881CA0
    }

    public class ITranslator
    {
        // ── Methods ──
        public void GetEncodedBlockSize(){} // RVA: 0x87C130
        public void Encode(){} // RVA: 0x885B90
        public void GetDecodedBlockSize(){} // RVA: 0x87C130
        public void Decode(){} // RVA: 0x885B90
    }

    public class UrlBase64 : Object
    {
        public object encoder;

        // ── Methods ──
        public void Encode(){} // RVA: 0xA38B9D0
        public void Decode(){} // RVA: 0xA38BE40
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA38BED0
    }

    public class UrlBase64Encoder : Base64Encoder
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA38C110
    }

}