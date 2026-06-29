// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings
// Classes: 8
// Methods: 41

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings
{
    public class IBlockCipherPadding
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void get_PaddingName(){} // RVA: 0x7A7E00680
        public void AddPadding(){} // RVA: 0x7A7E09FB0
        public void PadCount(){} // RVA: 0x7A7E01630
    }

    public class ISO10126d2Padding : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B13CE3E0
        public void get_PaddingName(){} // RVA: 0x7B13CE4A0
        public void AddPadding(){} // RVA: 0x7B13CE4E0
        public void PadCount(){} // RVA: 0x7B13CE580
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ISO7816d4Padding : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A80D7310
        public void get_PaddingName(){} // RVA: 0x7B13CE610
        public void AddPadding(){} // RVA: 0x7B13CE650
        public void PadCount(){} // RVA: 0x7B13CE6B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class PaddedBufferedBlockCipher : BufferedBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13CE950
        public void Init(){} // RVA: 0x7B13CE9B0
        public void GetOutputSize(){} // RVA: 0x7B13CEB60
        public void GetUpdateOutputSize(){} // RVA: 0x7B13CEBB0
        public void ProcessByte(){} // RVA: 0x7B13CEBF0
        public void ProcessBytes(){} // RVA: 0x7B13CECC0
        public void DoFinal(){} // RVA: 0x7B13CEFD0
    }

    public class Pkcs7Padding : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A80D7310
        public void get_PaddingName(){} // RVA: 0x7B13CF2F0
        public void AddPadding(){} // RVA: 0x7B13CF330
        public void PadCount(){} // RVA: 0x7B13CF370
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TbcPadding : Object
    {
        // ── Methods ──
        public void get_PaddingName(){} // RVA: 0x7B13CF490
        public void Init(){} // RVA: 0x7A80D7310
        public void AddPadding(){} // RVA: 0x7B13CF4D0
        public void PadCount(){} // RVA: 0x7B13CF540
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class X923Padding : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A80D8E20
        public void get_PaddingName(){} // RVA: 0x7B13CF5B0
        public void AddPadding(){} // RVA: 0x7B13CF5F0
        public void PadCount(){} // RVA: 0x7B13CF6B0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ZeroBytePadding : Object
    {
        // ── Methods ──
        public void get_PaddingName(){} // RVA: 0x7B13CF740
        public void Init(){} // RVA: 0x7A80D7310
        public void AddPadding(){} // RVA: 0x7B13CF780
        public void PadCount(){} // RVA: 0x7B13CF7D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}