// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings
// Classes: 8
// Methods: 41

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings
{
    public class IBlockCipherPadding
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void get_PaddingName(){} // RVA: 0x87C0A0
        public void AddPadding(){} // RVA: 0x885970
        public void PadCount(){} // RVA: 0x87D050
    }

    public class ISO10126d2Padding : Object
    {
        public object random;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2399D0
        public void get_PaddingName(){} // RVA: 0xA239A90
        public void AddPadding(){} // RVA: 0xA239AD0
        public void PadCount(){} // RVA: 0xA239B70
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ISO7816d4Padding : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0xB43310
        public void get_PaddingName(){} // RVA: 0xA239C00
        public void AddPadding(){} // RVA: 0xA239C40
        public void PadCount(){} // RVA: 0xA239CA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class PaddedBufferedBlockCipher : BufferedBlockCipher
    {
        public object padding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA239F40
        public void Init(){} // RVA: 0xA239FA0
        public void GetOutputSize(){} // RVA: 0xA23A150
        public void GetUpdateOutputSize(){} // RVA: 0xA23A1A0
        public void ProcessByte(){} // RVA: 0xA23A1E0
        public void ProcessBytes(){} // RVA: 0xA23A2B0
        public void DoFinal(){} // RVA: 0xA23A5C0
    }

    public class Pkcs7Padding : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0xB43310
        public void get_PaddingName(){} // RVA: 0xA23A8E0
        public void AddPadding(){} // RVA: 0xA23A920
        public void PadCount(){} // RVA: 0xA23A960
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TbcPadding : Object
    {
        // ── Methods ──
        public void get_PaddingName(){} // RVA: 0xA23AA80
        public void Init(){} // RVA: 0xB43310
        public void AddPadding(){} // RVA: 0xA23AAC0
        public void PadCount(){} // RVA: 0xA23AB30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class X923Padding : Object
    {
        public object random;

        // ── Methods ──
        public void Init(){} // RVA: 0xB44D60
        public void get_PaddingName(){} // RVA: 0xA23ABA0
        public void AddPadding(){} // RVA: 0xA23ABE0
        public void PadCount(){} // RVA: 0xA23ACA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ZeroBytePadding : Object
    {
        // ── Methods ──
        public void get_PaddingName(){} // RVA: 0xA23AD30
        public void Init(){} // RVA: 0xB43310
        public void AddPadding(){} // RVA: 0xA23AD70
        public void PadCount(){} // RVA: 0xA23ADC0
        public void .ctor(){} // RVA: 0xB43310
    }

}