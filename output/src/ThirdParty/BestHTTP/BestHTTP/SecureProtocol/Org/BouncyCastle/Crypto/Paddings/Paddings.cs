// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings
// Classes: 8
// Methods: 42

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings
{
    public class IBlockCipherPadding
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void get_PaddingName(){} // RVA: 0x7FFE80E2E2E0
        public void AddPadding(){}
        public void PadCount(){} // RVA: 0x7FFE80E33B00
    }

    public class ISO10126d2Padding : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE89FF9E10
        public void get_PaddingName(){} // RVA: 0x7FFE89FF9ED0
        public void AddPadding(){} // RVA: 0x7FFE89FF9F10
        public void PadCount(){} // RVA: 0x7FFE89FF9FB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ISO7816d4Padding : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE810FB310
        public void get_PaddingName(){} // RVA: 0x7FFE89FFA040
        public void AddPadding(){} // RVA: 0x7FFE89FFA080
        public void PadCount(){} // RVA: 0x7FFE89FFA0D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class PaddedBufferedBlockCipher : BufferedBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89FFA370 | overloaded x2
        public void Init(){} // RVA: 0x7FFE89FFA3D0
        public void GetOutputSize(){} // RVA: 0x7FFE89FFA580
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE89FFA5D0
        public void ProcessByte(){} // RVA: 0x7FFE89FFA610
        public void ProcessBytes(){} // RVA: 0x7FFE89FFA6E0
        public void DoFinal(){} // RVA: 0x7FFE89FFA9E0
    }

    public class Pkcs7Padding : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE810FB310
        public void get_PaddingName(){} // RVA: 0x7FFE89FFAD00
        public void AddPadding(){} // RVA: 0x7FFE89FFAD40
        public void PadCount(){} // RVA: 0x7FFE89FFAD80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TbcPadding : Object
    {
        // ── Methods ──
        public void get_PaddingName(){} // RVA: 0x7FFE89FFAEA0
        public void Init(){} // RVA: 0x7FFE810FB310
        public void AddPadding(){} // RVA: 0x7FFE89FFAEE0
        public void PadCount(){} // RVA: 0x7FFE89FFAF40
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class X923Padding : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE810FCE30
        public void get_PaddingName(){} // RVA: 0x7FFE89FFAFA0
        public void AddPadding(){} // RVA: 0x7FFE89FFAFE0
        public void PadCount(){} // RVA: 0x7FFE89FFB0A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ZeroBytePadding : Object
    {
        // ── Methods ──
        public void get_PaddingName(){} // RVA: 0x7FFE89FFB130
        public void Init(){} // RVA: 0x7FFE810FB310
        public void AddPadding(){} // RVA: 0x7FFE89FFB170
        public void PadCount(){} // RVA: 0x7FFE89FFB1B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}