// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 129

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class SHA1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C89F40
        public void Create(){} // RVA: 0x5C96580 | overloaded x2
    }

    public class SHA1CryptoServiceProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CAE5D0
        public void Finalize(){} // RVA: 0x5CA8880
        public void Dispose(){} // RVA: 0x5C74080
        public void HashCore(){} // RVA: 0x5CAE7F0
        public void HashFinal(){} // RVA: 0x5CAE940
        public void Initialize(){} // RVA: 0x5CAEA40
    }

    public class SHA1Internal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CACC20
        public void HashCore(){} // RVA: 0x5CACDA0
        public void HashFinal(){} // RVA: 0x5CACEE0
        public void Initialize(){} // RVA: 0x5CACFD0
        public void ProcessBlock(){} // RVA: 0x5CAD060
        public void InitialiseBuff(){} // RVA: 0x5CAD750
        public void FillBuff(){} // RVA: 0x5CADED0
        public void ProcessFinalBlock(){} // RVA: 0x5CAE2B0
        public void AddLength(){} // RVA: 0x5CAE4F0
    }

    public class SHA1Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C96660
        public void Initialize(){} // RVA: 0x5C96810
        public void HashCore(){} // RVA: 0x5C96870
        public void HashFinal(){} // RVA: 0x5C96880
        public void InitializeState(){} // RVA: 0x5C8A2B0
        public void _HashData(){} // RVA: 0x5C96890
        public void _EndHash(){} // RVA: 0x5C96B80
        public void SHATransform(){} // RVA: 0x5C96E70
        public void SHAExpand(){} // RVA: 0x5C97460
    }

    public class SHA256
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C975C0
        public void Create(){} // RVA: 0x5C975D0 | overloaded x2
    }

    public class SHA256Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C976B0
        public void Initialize(){} // RVA: 0x5C97860
        public void HashCore(){} // RVA: 0x5C978C0
        public void HashFinal(){} // RVA: 0x5C978D0
        public void InitializeState(){} // RVA: 0x5C978E0
        public void _HashData(){} // RVA: 0x5C979D0
        public void _EndHash(){} // RVA: 0x5C97D00
        public void SHATransform(){} // RVA: 0x5C97FF0
        public void RotateRight(){} // RVA: 0x5C98C70
        public void Ch(){} // RVA: 0x5C98C90
        public void Maj(){} // RVA: 0x5C98CA0
        public void sigma_0(){} // RVA: 0x5C98CB0
        public void sigma_1(){} // RVA: 0x5C98D20
        public void Sigma_0(){} // RVA: 0x5C98D90
        public void Sigma_1(){} // RVA: 0x5C98E00
        public void SHA256Expand(){} // RVA: 0x5C98E70
        public void .cctor(){} // RVA: 0x5C98FC0
    }

    public class SHA384
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C990A0
        public void Create(){} // RVA: 0x5C990B0 | overloaded x2
    }

    public class SHA384Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C99190
        public void Initialize(){} // RVA: 0x5C99340
        public void HashCore(){} // RVA: 0x5C993A0
        public void HashFinal(){} // RVA: 0x5C993B0
        public void InitializeState(){} // RVA: 0x5C993C0
        public void _HashData(){} // RVA: 0x5C994F0
        public void _EndHash(){} // RVA: 0x5C99840
        public void SHATransform(){} // RVA: 0x5C99A70
        public void RotateRight(){} // RVA: 0x5C9A7F0
        public void Ch(){} // RVA: 0x5C9A810
        public void Maj(){} // RVA: 0x5C9A820
        public void Sigma_0(){} // RVA: 0x5C9A830
        public void Sigma_1(){} // RVA: 0x5C9A8B0
        public void sigma_0(){} // RVA: 0x5C9A930
        public void sigma_1(){} // RVA: 0x5C9A9A0
        public void SHA384Expand(){} // RVA: 0x5C9AA20
        public void .cctor(){} // RVA: 0x5C9AB90
    }

    public class SHA512
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9AC70
        public void Create(){} // RVA: 0x5C9AC80 | overloaded x2
    }

    public class SHA512Managed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9AD60
        public void Initialize(){} // RVA: 0x5C9AF10
        public void HashCore(){} // RVA: 0x5C9AF70
        public void HashFinal(){} // RVA: 0x5C9AF80
        public void InitializeState(){} // RVA: 0x5C9AF90
        public void _HashData(){} // RVA: 0x5C9B0C0
        public void _EndHash(){} // RVA: 0x5C9B410
        public void SHATransform(){} // RVA: 0x5C9B640
        public void RotateRight(){} // RVA: 0x5C9A7F0
        public void Ch(){} // RVA: 0x5C9A810
        public void Maj(){} // RVA: 0x5C9A820
        public void Sigma_0(){} // RVA: 0x5C9C3C0
        public void Sigma_1(){} // RVA: 0x5C9C440
        public void sigma_0(){} // RVA: 0x5C9C4C0
        public void sigma_1(){} // RVA: 0x5C9C530
        public void SHA512Expand(){} // RVA: 0x5C9C5B0
        public void .cctor(){} // RVA: 0x5C9C720
    }

    public class SignatureDescription
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9C800 | overloaded x2
        public void get_KeyAlgorithm(){} // RVA: 0x2F8380
        public void set_KeyAlgorithm(){} // RVA: 0x2DEE30
        public void get_DigestAlgorithm(){} // RVA: 0x2E07C0
        public void set_DigestAlgorithm(){} // RVA: 0x343E80
        public void get_FormatterAlgorithm(){} // RVA: 0x30B0C0
        public void set_FormatterAlgorithm(){} // RVA: 0x30B0D0
        public void get_DeformatterAlgorithm(){} // RVA: 0x30B130
        public void set_DeformatterAlgorithm(){} // RVA: 0x2DEE90
        public void CreateDeformatter(){} // RVA: 0x5C9CA60
        public void CreateFormatter(){} // RVA: 0x5C9CB70
        public void CreateDigest(){} // RVA: 0x5C9CC80
    }

    public class SymmetricAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C9D550
        public void Dispose(){} // RVA: 0x5C9D610 | overloaded x2
        public void Clear(){} // RVA: 0x5C9D5D0
        public void get_BlockSize(){} // RVA: 0x32A5C0
        public void set_BlockSize(){} // RVA: 0x5C9D720
        public void get_FeedbackSize(){} // RVA: 0x8ABED0
        public void set_FeedbackSize(){} // RVA: 0x5C9D880
        public void get_IV(){} // RVA: 0x5C9D910
        public void set_IV(){} // RVA: 0x5C9D9B0
        public void get_Key(){} // RVA: 0x5C9DB70
        public void set_Key(){} // RVA: 0x5C9DC10
        public void get_LegalBlockSizes(){} // RVA: 0x5C9DDE0
        public void get_LegalKeySizes(){} // RVA: 0x5C9DE60
        public void get_KeySize(){} // RVA: 0xFDC9F0
        public void set_KeySize(){} // RVA: 0x5C9DEE0
        public void get_Mode(){} // RVA: 0x891AF0
        public void set_Mode(){} // RVA: 0x5C9DFB0
        public void get_Padding(){} // RVA: 0x37E080
        public void set_Padding(){} // RVA: 0x5C9E030
        public void ValidKeySize(){} // RVA: 0x5C9E0B0
        public void Create(){} // RVA: 0x5C9E1A0 | overloaded x2
        public void CreateEncryptor(){} // RVA: 0x1E6A0 | overloaded x2
        public void CreateDecryptor(){} // RVA: 0x1E6A0 | overloaded x2
        public void GenerateKey(){} // RVA: 0x24A50
        public void GenerateIV(){} // RVA: 0x24A50
    }

}