// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 120

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class SHA1 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA78190
        public void Create(){} // RVA: 0x7ADA84730
    }

    public class SHA1CryptoServiceProvider : SHA1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA9C630
        public void Finalize(){} // RVA: 0x7ADA96D20
        public void Dispose(){} // RVA: 0x7ADA62070
        public void HashCore(){} // RVA: 0x7ADA9C850
        public void HashFinal(){} // RVA: 0x7ADA9C9A0
        public void Initialize(){} // RVA: 0x7ADA9CAB0
    }

    public class SHA1Internal : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA9AC90
        public void HashCore(){} // RVA: 0x7ADA9AE10
        public void HashFinal(){} // RVA: 0x7ADA9AF50
        public void Initialize(){} // RVA: 0x7ADA9B050
        public void ProcessBlock(){} // RVA: 0x7ADA9B0E0
        public void InitialiseBuff(){} // RVA: 0x7ADA9B850
        public void FillBuff(){} // RVA: 0x7ADA9BFD0
        public void ProcessFinalBlock(){} // RVA: 0x7ADA9C300
        public void AddLength(){} // RVA: 0x7ADA9C550
    }

    public class SHA1Managed : SHA1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA84810
        public void Initialize(){} // RVA: 0x7ADA849C0
        public void HashCore(){} // RVA: 0x7ADA84A20
        public void HashFinal(){} // RVA: 0x7ADA84A30
        public void InitializeState(){} // RVA: 0x7ADA78500
        public void _HashData(){} // RVA: 0x7ADA84A40
        public void _EndHash(){} // RVA: 0x7ADA84D30
        public void SHATransform(){} // RVA: 0x7ADA85000
        public void SHAExpand(){} // RVA: 0x7ADA855E0
    }

    public class SHA256 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA85740
        public void Create(){} // RVA: 0x7ADA85750
    }

    public class SHA256Managed : SHA256
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA85830
        public void Initialize(){} // RVA: 0x7ADA859E0
        public void HashCore(){} // RVA: 0x7ADA85A40
        public void HashFinal(){} // RVA: 0x7ADA85A50
        public void InitializeState(){} // RVA: 0x7ADA85A60
        public void _HashData(){} // RVA: 0x7ADA85B50
        public void _EndHash(){} // RVA: 0x7ADA85E80
        public void SHATransform(){} // RVA: 0x7ADA86150
        public void RotateRight(){} // RVA: 0x7ADA86DD0
        public void Ch(){} // RVA: 0x7ADA86DF0
        public void Maj(){} // RVA: 0x7ADA86E00
        public void sigma_0(){} // RVA: 0x7ADA86E10
        public void sigma_1(){} // RVA: 0x7ADA86E80
        public void Sigma_0(){} // RVA: 0x7ADA86EF0
        public void Sigma_1(){} // RVA: 0x7ADA86F60
        public void SHA256Expand(){} // RVA: 0x7ADA86FD0
        public void .cctor(){} // RVA: 0x7ADA87120
    }

    public class SHA384 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA87200
        public void Create(){} // RVA: 0x7ADA87210
    }

    public class SHA384Managed : SHA384
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA872F0
        public void Initialize(){} // RVA: 0x7ADA874A0
        public void HashCore(){} // RVA: 0x7ADA87500
        public void HashFinal(){} // RVA: 0x7ADA87510
        public void InitializeState(){} // RVA: 0x7ADA87520
        public void _HashData(){} // RVA: 0x7ADA87650
        public void _EndHash(){} // RVA: 0x7ADA879B0
        public void SHATransform(){} // RVA: 0x7ADA87D00
        public void RotateRight(){} // RVA: 0x7ADA88A90
        public void Ch(){} // RVA: 0x7ADA88AB0
        public void Maj(){} // RVA: 0x7ADA88AC0
        public void Sigma_0(){} // RVA: 0x7ADA88AD0
        public void Sigma_1(){} // RVA: 0x7ADA88B50
        public void sigma_0(){} // RVA: 0x7ADA88BD0
        public void sigma_1(){} // RVA: 0x7ADA88C40
        public void SHA384Expand(){} // RVA: 0x7ADA88CC0
        public void .cctor(){} // RVA: 0x7ADA88E30
    }

    public class SHA512 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA88F10
        public void Create(){} // RVA: 0x7ADA88F20
    }

    public class SHA512Managed : SHA512
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA89000
        public void Initialize(){} // RVA: 0x7ADA891B0
        public void HashCore(){} // RVA: 0x7ADA89210
        public void HashFinal(){} // RVA: 0x7ADA89220
        public void InitializeState(){} // RVA: 0x7ADA89230
        public void _HashData(){} // RVA: 0x7ADA89360
        public void _EndHash(){} // RVA: 0x7ADA896C0
        public void SHATransform(){} // RVA: 0x7ADA89A10
        public void RotateRight(){} // RVA: 0x7ADA88A90
        public void Ch(){} // RVA: 0x7ADA88AB0
        public void Maj(){} // RVA: 0x7ADA88AC0
        public void Sigma_0(){} // RVA: 0x7ADA8A7A0
        public void Sigma_1(){} // RVA: 0x7ADA8A820
        public void sigma_0(){} // RVA: 0x7ADA8A8A0
        public void sigma_1(){} // RVA: 0x7ADA8A910
        public void SHA512Expand(){} // RVA: 0x7ADA8A990
        public void .cctor(){} // RVA: 0x7ADA8AB00
    }

    public class SignatureDescription : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA8ABE0
        public void get_KeyAlgorithm(){} // RVA: 0x7A80F2570
        public void set_KeyAlgorithm(){} // RVA: 0x7A80D8E20
        public void get_DigestAlgorithm(){} // RVA: 0x7A80DA7B0
        public void set_DigestAlgorithm(){} // RVA: 0x7A813E420
        public void get_FormatterAlgorithm(){} // RVA: 0x7A81052C0
        public void set_FormatterAlgorithm(){} // RVA: 0x7A81052D0
        public void get_DeformatterAlgorithm(){} // RVA: 0x7A8105330
        public void set_DeformatterAlgorithm(){} // RVA: 0x7A80D8E80
        public void CreateDeformatter(){} // RVA: 0x7ADA8AE40
        public void CreateFormatter(){} // RVA: 0x7ADA8AF50
        public void CreateDigest(){} // RVA: 0x7ADA8B060
    }

    public class SymmetricAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA8B930
        public void Dispose(){} // RVA: 0x7ADA8B9F0
        public void Clear(){} // RVA: 0x7ADA8B9B0
        public void get_BlockSize(){} // RVA: 0x7A8124910
        public void set_BlockSize(){} // RVA: 0x7ADA8BB00
        public void get_FeedbackSize(){} // RVA: 0x7A8668BC0
        public void set_FeedbackSize(){} // RVA: 0x7ADA8BC50
        public void get_IV(){} // RVA: 0x7ADA8BCE0
        public void set_IV(){} // RVA: 0x7ADA8BD80
        public void get_Key(){} // RVA: 0x7ADA8BF40
        public void set_Key(){} // RVA: 0x7ADA8BFE0
        public void get_LegalBlockSizes(){} // RVA: 0x7ADA8C1B0
        public void get_LegalKeySizes(){} // RVA: 0x7ADA8C230
        public void get_KeySize(){} // RVA: 0x7A8D863F0
        public void set_KeySize(){} // RVA: 0x7ADA8C2B0
        public void get_Mode(){} // RVA: 0x7A864E8D0
        public void set_Mode(){} // RVA: 0x7ADA8C380
        public void get_Padding(){} // RVA: 0x7A8178B30
        public void set_Padding(){} // RVA: 0x7ADA8C400
        public void ValidKeySize(){} // RVA: 0x7ADA8C480
        public void Create(){} // RVA: 0x7ADA8C570
        public void CreateEncryptor(){} // RVA: 0x7A7E00BD0
        public void CreateDecryptor(){} // RVA: 0x7A7E00BD0
        public void GenerateKey(){} // RVA: 0x7A7E18770
        public void GenerateIV(){} // RVA: 0x7A7E18770
    }

}