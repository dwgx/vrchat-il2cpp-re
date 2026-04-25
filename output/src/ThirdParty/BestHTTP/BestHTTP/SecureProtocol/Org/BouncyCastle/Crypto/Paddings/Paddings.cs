// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings
// Classes: 8
// Methods: 42

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings
{
    public class IBlockCipherPadding
    {
        public object PaddingName;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void get_PaddingName(){} // RVA: 0x7FFAC2C58E90
        public void AddPadding(){}
        public void PadCount(){} // RVA: 0x7FFAC2C5E6B0
    }

    public class ISO10126d2Padding : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom PaddingName; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBA07F0
        public void get_PaddingName(){} // RVA: 0x7FFACBBA08B0
        public void AddPadding(){} // RVA: 0x7FFACBBA08F0
        public void PadCount(){} // RVA: 0x7FFACBBA0990
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ISO7816d4Padding : Object
    {
        public object PaddingName;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2F21310
        public void get_PaddingName(){} // RVA: 0x7FFACBBA0A20
        public void AddPadding(){} // RVA: 0x7FFACBBA0A60
        public void PadCount(){} // RVA: 0x7FFACBBA0AB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class PaddedBufferedBlockCipher : BufferedBlockCipher
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA0D50 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBBA0DB0
        public void GetOutputSize(){} // RVA: 0x7FFACBBA0F60
        public void GetUpdateOutputSize(){} // RVA: 0x7FFACBBA0FB0
        public void ProcessByte(){} // RVA: 0x7FFACBBA0FF0
        public void ProcessBytes(){} // RVA: 0x7FFACBBA10C0
        public void DoFinal(){} // RVA: 0x7FFACBBA13C0
    }

    public class Pkcs7Padding : Object
    {
        public object PaddingName;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2F21310
        public void get_PaddingName(){} // RVA: 0x7FFACBBA16E0
        public void AddPadding(){} // RVA: 0x7FFACBBA1720
        public void PadCount(){} // RVA: 0x7FFACBBA1760
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TbcPadding : Object
    {
        public object PaddingName;

        // ── Methods ──
        public void get_PaddingName(){} // RVA: 0x7FFACBBA1880
        public void Init(){} // RVA: 0x7FFAC2F21310
        public void AddPadding(){} // RVA: 0x7FFACBBA18C0
        public void PadCount(){} // RVA: 0x7FFACBBA1920
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class X923Padding : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom PaddingName; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2F22E30
        public void get_PaddingName(){} // RVA: 0x7FFACBBA1980
        public void AddPadding(){} // RVA: 0x7FFACBBA19C0
        public void PadCount(){} // RVA: 0x7FFACBBA1A80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ZeroBytePadding : Object
    {
        public object PaddingName;

        // ── Methods ──
        public void get_PaddingName(){} // RVA: 0x7FFACBBA1B10
        public void Init(){} // RVA: 0x7FFAC2F21310
        public void AddPadding(){} // RVA: 0x7FFACBBA1B50
        public void PadCount(){} // RVA: 0x7FFACBBA1B90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}