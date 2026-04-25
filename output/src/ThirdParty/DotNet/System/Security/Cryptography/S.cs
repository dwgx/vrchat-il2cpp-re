// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 129

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class SHA1 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84214D0
        public void Create(){} // RVA: 0x7FFAC842DB10 | overloaded x2
    }

    public class SHA1CryptoServiceProvider : SHA1
    {
        public System.Security.Cryptography.SHA1Internal sha; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8445BC0
        public void Finalize(){} // RVA: 0x7FFAC843FE70
        public void Dispose(){} // RVA: 0x7FFAC840B610
        public void HashCore(){} // RVA: 0x7FFAC8445DE0
        public void HashFinal(){} // RVA: 0x7FFAC8445F30
        public void Initialize(){} // RVA: 0x7FFAC8446030
    }

    public class SHA1Internal : Object
    {
        public int BLOCK_SIZE_BYTES;
        public uint[] _H; // 0x10
        public ulong count; // 0x18
        public byte[] _ProcessingBuffer; // 0x20
        public int _ProcessingBufferCount; // 0x28
        public uint[] buff; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8444210
        public void HashCore(){} // RVA: 0x7FFAC8444390
        public void HashFinal(){} // RVA: 0x7FFAC84444D0
        public void Initialize(){} // RVA: 0x7FFAC84445C0
        public void ProcessBlock(){} // RVA: 0x7FFAC8444650
        public void InitialiseBuff(){} // RVA: 0x7FFAC8444D40
        public void FillBuff(){} // RVA: 0x7FFAC84454C0
        public void ProcessFinalBlock(){} // RVA: 0x7FFAC84458A0
        public void AddLength(){} // RVA: 0x7FFAC8445AE0
    }

    public class SHA1Managed : SHA1
    {
        public byte[] _buffer; // 0x28
        public long _count; // 0x30
        public uint[] _stateSHA1; // 0x38
        public uint[] _expandedBuffer; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC842DBF0
        public void Initialize(){} // RVA: 0x7FFAC842DDA0
        public void HashCore(){} // RVA: 0x7FFAC842DE00
        public void HashFinal(){} // RVA: 0x7FFAC842DE10
        public void InitializeState(){} // RVA: 0x7FFAC8421840
        public void _HashData(){} // RVA: 0x7FFAC842DE20
        public void _EndHash(){} // RVA: 0x7FFAC842E110
        public void SHATransform(){} // RVA: 0x7FFAC842E400
        public void SHAExpand(){} // RVA: 0x7FFAC842E9F0
    }

    public class SHA256 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC842EB50
        public void Create(){} // RVA: 0x7FFAC842EB60 | overloaded x2
    }

    public class SHA256Managed : SHA256
    {
        public byte[] _buffer; // 0x28
        public long _count; // 0x30
        public uint[] _stateSHA256; // 0x38
        public uint[] _W; // 0x40
        public uint[] _K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC842EC40
        public void Initialize(){} // RVA: 0x7FFAC842EDF0
        public void HashCore(){} // RVA: 0x7FFAC842EE50
        public void HashFinal(){} // RVA: 0x7FFAC842EE60
        public void InitializeState(){} // RVA: 0x7FFAC842EE70
        public void _HashData(){} // RVA: 0x7FFAC842EF60
        public void _EndHash(){} // RVA: 0x7FFAC842F290
        public void SHATransform(){} // RVA: 0x7FFAC842F580
        public void RotateRight(){} // RVA: 0x7FFAC8430200
        public void Ch(){} // RVA: 0x7FFAC8430220
        public void Maj(){} // RVA: 0x7FFAC8430230
        public void sigma_0(){} // RVA: 0x7FFAC8430240
        public void sigma_1(){} // RVA: 0x7FFAC84302B0
        public void Sigma_0(){} // RVA: 0x7FFAC8430320
        public void Sigma_1(){} // RVA: 0x7FFAC8430390
        public void SHA256Expand(){} // RVA: 0x7FFAC8430400
        public void .cctor(){} // RVA: 0x7FFAC8430550
    }

    public class SHA384 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8430630
        public void Create(){} // RVA: 0x7FFAC8430640 | overloaded x2
    }

    public class SHA384Managed : SHA384
    {
        public byte[] _buffer; // 0x28
        public ulong _count; // 0x30
        public ulong[] _stateSHA384; // 0x38
        public ulong[] _W; // 0x40
        public ulong[] _K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8430720
        public void Initialize(){} // RVA: 0x7FFAC84308D0
        public void HashCore(){} // RVA: 0x7FFAC8430930
        public void HashFinal(){} // RVA: 0x7FFAC8430940
        public void InitializeState(){} // RVA: 0x7FFAC8430950
        public void _HashData(){} // RVA: 0x7FFAC8430A80
        public void _EndHash(){} // RVA: 0x7FFAC8430DD0
        public void SHATransform(){} // RVA: 0x7FFAC8431000
        public void RotateRight(){} // RVA: 0x7FFAC8431D80
        public void Ch(){} // RVA: 0x7FFAC8431DA0
        public void Maj(){} // RVA: 0x7FFAC8431DB0
        public void Sigma_0(){} // RVA: 0x7FFAC8431DC0
        public void Sigma_1(){} // RVA: 0x7FFAC8431E40
        public void sigma_0(){} // RVA: 0x7FFAC8431EC0
        public void sigma_1(){} // RVA: 0x7FFAC8431F30
        public void SHA384Expand(){} // RVA: 0x7FFAC8431FB0
        public void .cctor(){} // RVA: 0x7FFAC8432120
    }

    public class SHA512 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8432200
        public void Create(){} // RVA: 0x7FFAC8432210 | overloaded x2
    }

    public class SHA512Managed : SHA512
    {
        public byte[] _buffer; // 0x28
        public ulong _count; // 0x30
        public ulong[] _stateSHA512; // 0x38
        public ulong[] _W; // 0x40
        public ulong[] _K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84322F0
        public void Initialize(){} // RVA: 0x7FFAC84324A0
        public void HashCore(){} // RVA: 0x7FFAC8432500
        public void HashFinal(){} // RVA: 0x7FFAC8432510
        public void InitializeState(){} // RVA: 0x7FFAC8432520
        public void _HashData(){} // RVA: 0x7FFAC8432650
        public void _EndHash(){} // RVA: 0x7FFAC84329A0
        public void SHATransform(){} // RVA: 0x7FFAC8432BD0
        public void RotateRight(){} // RVA: 0x7FFAC8431D80
        public void Ch(){} // RVA: 0x7FFAC8431DA0
        public void Maj(){} // RVA: 0x7FFAC8431DB0
        public void Sigma_0(){} // RVA: 0x7FFAC8433950
        public void Sigma_1(){} // RVA: 0x7FFAC84339D0
        public void sigma_0(){} // RVA: 0x7FFAC8433A50
        public void sigma_1(){} // RVA: 0x7FFAC8433AC0
        public void SHA512Expand(){} // RVA: 0x7FFAC8433B40
        public void .cctor(){} // RVA: 0x7FFAC8433CB0
    }

    public class SignatureDescription : Object
    {
        public string KeyAlgorithm; // 0x10
        public string DigestAlgorithm; // 0x18
        public string FormatterAlgorithm; // 0x20
        public string DeformatterAlgorithm; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8433D90 | overloaded x2
        public void get_KeyAlgorithm(){} // RVA: 0x7FFAC2F3C380
        public void set_KeyAlgorithm(){} // RVA: 0x7FFAC2F22E30
        public void get_DigestAlgorithm(){} // RVA: 0x7FFAC2F247C0
        public void set_DigestAlgorithm(){} // RVA: 0x7FFAC2F87E80
        public void get_FormatterAlgorithm(){} // RVA: 0x7FFAC2F4F0C0
        public void set_FormatterAlgorithm(){} // RVA: 0x7FFAC2F4F0D0
        public void get_DeformatterAlgorithm(){} // RVA: 0x7FFAC2F4F130
        public void set_DeformatterAlgorithm(){} // RVA: 0x7FFAC2F22E90
        public void CreateDeformatter(){} // RVA: 0x7FFAC8433FF0
        public void CreateFormatter(){} // RVA: 0x7FFAC8434100
        public void CreateDigest(){} // RVA: 0x7FFAC8434210
    }

    public class SymmetricAlgorithm : Object
    {
        public int BlockSize; // 0x10
        public int FeedbackSize; // 0x14
        public byte[] IV; // 0x18
        public byte[] Key; // 0x20
        public System.Security.Cryptography.KeySizes[] LegalBlockSizes; // 0x28
        public System.Security.Cryptography.KeySizes[] LegalKeySizes; // 0x30
        public int KeySize; // 0x38
        public 0x6B0CC128 Mode; // 0x3C
        public 0x6B0CC180 Padding; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8434AE0
        public void Dispose(){} // RVA: 0x7FFAC8434BA0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC8434B60
        public void get_BlockSize(){} // RVA: 0x7FFAC2F6E5C0
        public void set_BlockSize(){} // RVA: 0x7FFAC8434CB0
        public void get_FeedbackSize(){} // RVA: 0x7FFAC33D5A20
        public void set_FeedbackSize(){} // RVA: 0x7FFAC8434E10
        public void get_IV(){} // RVA: 0x7FFAC8434EA0
        public void set_IV(){} // RVA: 0x7FFAC8434F40
        public void get_Key(){} // RVA: 0x7FFAC8435100
        public void set_Key(){} // RVA: 0x7FFAC84351A0
        public void get_LegalBlockSizes(){} // RVA: 0x7FFAC8435370
        public void get_LegalKeySizes(){} // RVA: 0x7FFAC84353F0
        public void get_KeySize(){} // RVA: 0x7FFAC358A870
        public void set_KeySize(){} // RVA: 0x7FFAC8435470
        public void get_Mode(){} // RVA: 0x7FFAC33BD4A0
        public void set_Mode(){} // RVA: 0x7FFAC8435540
        public void get_Padding(){} // RVA: 0x7FFAC2FC2080
        public void set_Padding(){} // RVA: 0x7FFAC84355C0
        public void ValidKeySize(){} // RVA: 0x7FFAC8435640
        public void Create(){} // RVA: 0x7FFAC8435730 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void CreateDecryptor(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void GenerateKey(){} // RVA: 0x7FFAC2C70980
        public void GenerateIV(){} // RVA: 0x7FFAC2C70980
    }

}