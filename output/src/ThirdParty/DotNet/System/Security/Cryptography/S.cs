// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 129

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class SHA1 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867CADE0
        public void Create(){} // RVA: 0x7FFE867D7420 | overloaded x2
    }

    public class SHA1CryptoServiceProvider : SHA1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867EF4D0
        public void Finalize(){} // RVA: 0x7FFE867E9780
        public void Dispose(){} // RVA: 0x7FFE867B4F20
        public void HashCore(){} // RVA: 0x7FFE867EF6F0
        public void HashFinal(){} // RVA: 0x7FFE867EF840
        public void Initialize(){} // RVA: 0x7FFE867EF940
    }

    public class SHA1Internal : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867EDB20
        public void HashCore(){} // RVA: 0x7FFE867EDCA0
        public void HashFinal(){} // RVA: 0x7FFE867EDDE0
        public void Initialize(){} // RVA: 0x7FFE867EDED0
        public void ProcessBlock(){} // RVA: 0x7FFE867EDF60
        public void InitialiseBuff(){} // RVA: 0x7FFE867EE650
        public void FillBuff(){} // RVA: 0x7FFE867EEDD0
        public void ProcessFinalBlock(){} // RVA: 0x7FFE867EF1B0
        public void AddLength(){} // RVA: 0x7FFE867EF3F0
    }

    public class SHA1Managed : SHA1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867D7500
        public void Initialize(){} // RVA: 0x7FFE867D76B0
        public void HashCore(){} // RVA: 0x7FFE867D7710
        public void HashFinal(){} // RVA: 0x7FFE867D7720
        public void InitializeState(){} // RVA: 0x7FFE867CB150
        public void _HashData(){} // RVA: 0x7FFE867D7730
        public void _EndHash(){} // RVA: 0x7FFE867D7A20
        public void SHATransform(){} // RVA: 0x7FFE867D7D10
        public void SHAExpand(){} // RVA: 0x7FFE867D8300
    }

    public class SHA256 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867D8460
        public void Create(){} // RVA: 0x7FFE867D8470 | overloaded x2
    }

    public class SHA256Managed : SHA256
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867D8550
        public void Initialize(){} // RVA: 0x7FFE867D8700
        public void HashCore(){} // RVA: 0x7FFE867D8760
        public void HashFinal(){} // RVA: 0x7FFE867D8770
        public void InitializeState(){} // RVA: 0x7FFE867D8780
        public void _HashData(){} // RVA: 0x7FFE867D8870
        public void _EndHash(){} // RVA: 0x7FFE867D8BA0
        public void SHATransform(){} // RVA: 0x7FFE867D8E90
        public void RotateRight(){} // RVA: 0x7FFE867D9B10
        public void Ch(){} // RVA: 0x7FFE867D9B30
        public void Maj(){} // RVA: 0x7FFE867D9B40
        public void sigma_0(){} // RVA: 0x7FFE867D9B50
        public void sigma_1(){} // RVA: 0x7FFE867D9BC0
        public void Sigma_0(){} // RVA: 0x7FFE867D9C30
        public void Sigma_1(){} // RVA: 0x7FFE867D9CA0
        public void SHA256Expand(){} // RVA: 0x7FFE867D9D10
        public void .cctor(){} // RVA: 0x7FFE867D9E60
    }

    public class SHA384 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867D9F40
        public void Create(){} // RVA: 0x7FFE867D9F50 | overloaded x2
    }

    public class SHA384Managed : SHA384
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DA030
        public void Initialize(){} // RVA: 0x7FFE867DA1E0
        public void HashCore(){} // RVA: 0x7FFE867DA240
        public void HashFinal(){} // RVA: 0x7FFE867DA250
        public void InitializeState(){} // RVA: 0x7FFE867DA260
        public void _HashData(){} // RVA: 0x7FFE867DA390
        public void _EndHash(){} // RVA: 0x7FFE867DA6E0
        public void SHATransform(){} // RVA: 0x7FFE867DA910
        public void RotateRight(){} // RVA: 0x7FFE867DB690
        public void Ch(){} // RVA: 0x7FFE867DB6B0
        public void Maj(){} // RVA: 0x7FFE867DB6C0
        public void Sigma_0(){} // RVA: 0x7FFE867DB6D0
        public void Sigma_1(){} // RVA: 0x7FFE867DB750
        public void sigma_0(){} // RVA: 0x7FFE867DB7D0
        public void sigma_1(){} // RVA: 0x7FFE867DB840
        public void SHA384Expand(){} // RVA: 0x7FFE867DB8C0
        public void .cctor(){} // RVA: 0x7FFE867DBA30
    }

    public class SHA512 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DBB10
        public void Create(){} // RVA: 0x7FFE867DBB20 | overloaded x2
    }

    public class SHA512Managed : SHA512
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DBC00
        public void Initialize(){} // RVA: 0x7FFE867DBDB0
        public void HashCore(){} // RVA: 0x7FFE867DBE10
        public void HashFinal(){} // RVA: 0x7FFE867DBE20
        public void InitializeState(){} // RVA: 0x7FFE867DBE30
        public void _HashData(){} // RVA: 0x7FFE867DBF60
        public void _EndHash(){} // RVA: 0x7FFE867DC2B0
        public void SHATransform(){} // RVA: 0x7FFE867DC4E0
        public void RotateRight(){} // RVA: 0x7FFE867DB690
        public void Ch(){} // RVA: 0x7FFE867DB6B0
        public void Maj(){} // RVA: 0x7FFE867DB6C0
        public void Sigma_0(){} // RVA: 0x7FFE867DD260
        public void Sigma_1(){} // RVA: 0x7FFE867DD2E0
        public void sigma_0(){} // RVA: 0x7FFE867DD360
        public void sigma_1(){} // RVA: 0x7FFE867DD3D0
        public void SHA512Expand(){} // RVA: 0x7FFE867DD450
        public void .cctor(){} // RVA: 0x7FFE867DD5C0
    }

    public class SignatureDescription : Object
    {
        public string _strKey; // 0x10
        public string _strDigest; // 0x18
        public string _strFormatter; // 0x20
        public string _strDeformatter; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DD6A0 | overloaded x2
        public void get_KeyAlgorithm(){} // RVA: 0x7FFE81116380
        public void set_KeyAlgorithm(){} // RVA: 0x7FFE810FCE30
        public void get_DigestAlgorithm(){} // RVA: 0x7FFE810FE7C0
        public void set_DigestAlgorithm(){} // RVA: 0x7FFE81161E80
        public void get_FormatterAlgorithm(){} // RVA: 0x7FFE811290C0
        public void set_FormatterAlgorithm(){} // RVA: 0x7FFE811290D0
        public void get_DeformatterAlgorithm(){} // RVA: 0x7FFE81129130
        public void set_DeformatterAlgorithm(){} // RVA: 0x7FFE810FCE90
        public void CreateDeformatter(){} // RVA: 0x7FFE867DD900
        public void CreateFormatter(){} // RVA: 0x7FFE867DDA10
        public void CreateDigest(){} // RVA: 0x7FFE867DDB20
    }

    public class SymmetricAlgorithm : Object
    {
        public int BlockSizeValue; // 0x10
        public int FeedbackSizeValue; // 0x14
        public byte[] IVValue; // 0x18
        public byte[] KeyValue; // 0x20
        public System.Security.Cryptography.KeySizes[] LegalBlockSizesValue; // 0x28
        public System.Security.Cryptography.KeySizes[] LegalKeySizesValue; // 0x30
        public int KeySizeValue; // 0x38
        public 0x664C504C ModeValue; // 0x3C
        public 0x664C50A4 PaddingValue; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867DE3F0
        public void Dispose(){} // RVA: 0x7FFE867DE4B0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE867DE470
        public void get_BlockSize(){} // RVA: 0x7FFE811485C0
        public void set_BlockSize(){} // RVA: 0x7FFE867DE5C0
        public void get_FeedbackSize(){} // RVA: 0x7FFE8164B230
        public void set_FeedbackSize(){} // RVA: 0x7FFE867DE720
        public void get_IV(){} // RVA: 0x7FFE867DE7B0
        public void set_IV(){} // RVA: 0x7FFE867DE850
        public void get_Key(){} // RVA: 0x7FFE867DEA10
        public void set_Key(){} // RVA: 0x7FFE867DEAB0
        public void get_LegalBlockSizes(){} // RVA: 0x7FFE867DEC80
        public void get_LegalKeySizes(){} // RVA: 0x7FFE867DED00
        public void get_KeySize(){} // RVA: 0x7FFE81D46090
        public void set_KeySize(){} // RVA: 0x7FFE867DED80
        public void get_Mode(){} // RVA: 0x7FFE816311C0
        public void set_Mode(){} // RVA: 0x7FFE867DEE50
        public void get_Padding(){} // RVA: 0x7FFE8119C080
        public void set_Padding(){} // RVA: 0x7FFE867DEED0
        public void ValidKeySize(){} // RVA: 0x7FFE867DEF50
        public void Create(){} // RVA: 0x7FFE867DF040 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void CreateDecryptor(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void GenerateKey(){} // RVA: 0x7FFE80E45FE0
        public void GenerateIV(){} // RVA: 0x7FFE80E45FE0
    }

}