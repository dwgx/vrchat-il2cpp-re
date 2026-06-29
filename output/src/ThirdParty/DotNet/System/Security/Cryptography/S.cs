// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 12
// Methods: 120

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class SHA1 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67027C0
        public void Create(){} // RVA: 0x670EE10
    }

    public class SHA1CryptoServiceProvider : SHA1
    {
        public object sha;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6726F50
        public void Finalize(){} // RVA: 0x6721500
        public void Dispose(){} // RVA: 0x66EC680
        public void HashCore(){} // RVA: 0x6727170
        public void HashFinal(){} // RVA: 0x67272C0
        public void Initialize(){} // RVA: 0x67273D0
    }

    public class SHA1Internal : Object
    {
        public object BLOCK_SIZE_BYTES;
        public object _H;
        public object count;
        public object _ProcessingBuffer;
        public object _ProcessingBufferCount;
        public object buff;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67255B0
        public void HashCore(){} // RVA: 0x6725730
        public void HashFinal(){} // RVA: 0x6725870
        public void Initialize(){} // RVA: 0x6725970
        public void ProcessBlock(){} // RVA: 0x6725A00
        public void InitialiseBuff(){} // RVA: 0x6726170
        public void FillBuff(){} // RVA: 0x67268F0
        public void ProcessFinalBlock(){} // RVA: 0x6726C20
        public void AddLength(){} // RVA: 0x6726E70
    }

    public class SHA1Managed : SHA1
    {
        public object _buffer;
        public object _count;
        public object _stateSHA1;
        public object _expandedBuffer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x670EEF0
        public void Initialize(){} // RVA: 0x670F0A0
        public void HashCore(){} // RVA: 0x670F100
        public void HashFinal(){} // RVA: 0x670F110
        public void InitializeState(){} // RVA: 0x6702B30
        public void _HashData(){} // RVA: 0x670F120
        public void _EndHash(){} // RVA: 0x670F410
        public void SHATransform(){} // RVA: 0x670F6E0
        public void SHAExpand(){} // RVA: 0x670FCC0
    }

    public class SHA256 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x670FE20
        public void Create(){} // RVA: 0x670FE30
    }

    public class SHA256Managed : SHA256
    {
        public object _buffer;
        public object _count;
        public object _stateSHA256;
        public object _W;
        public object _K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x670FF10
        public void Initialize(){} // RVA: 0x67100C0
        public void HashCore(){} // RVA: 0x6710120
        public void HashFinal(){} // RVA: 0x6710130
        public void InitializeState(){} // RVA: 0x6710140
        public void _HashData(){} // RVA: 0x6710230
        public void _EndHash(){} // RVA: 0x6710560
        public void SHATransform(){} // RVA: 0x6710830
        public void RotateRight(){} // RVA: 0x67114B0
        public void Ch(){} // RVA: 0x67114D0
        public void Maj(){} // RVA: 0x67114E0
        public void sigma_0(){} // RVA: 0x67114F0
        public void sigma_1(){} // RVA: 0x6711560
        public void Sigma_0(){} // RVA: 0x67115D0
        public void Sigma_1(){} // RVA: 0x6711640
        public void SHA256Expand(){} // RVA: 0x67116B0
        public void .cctor(){} // RVA: 0x6711800
    }

    public class SHA384 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67118E0
        public void Create(){} // RVA: 0x67118F0
    }

    public class SHA384Managed : SHA384
    {
        public object _buffer;
        public object _count;
        public object _stateSHA384;
        public object _W;
        public object _K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67119D0
        public void Initialize(){} // RVA: 0x6711B80
        public void HashCore(){} // RVA: 0x6711BE0
        public void HashFinal(){} // RVA: 0x6711BF0
        public void InitializeState(){} // RVA: 0x6711C00
        public void _HashData(){} // RVA: 0x6711D30
        public void _EndHash(){} // RVA: 0x6712090
        public void SHATransform(){} // RVA: 0x67123E0
        public void RotateRight(){} // RVA: 0x6713170
        public void Ch(){} // RVA: 0x6713190
        public void Maj(){} // RVA: 0x67131A0
        public void Sigma_0(){} // RVA: 0x67131B0
        public void Sigma_1(){} // RVA: 0x6713230
        public void sigma_0(){} // RVA: 0x67132B0
        public void sigma_1(){} // RVA: 0x6713320
        public void SHA384Expand(){} // RVA: 0x67133A0
        public void .cctor(){} // RVA: 0x6713510
    }

    public class SHA512 : HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67135F0
        public void Create(){} // RVA: 0x6713600
    }

    public class SHA512Managed : SHA512
    {
        public object _buffer;
        public object _count;
        public object _stateSHA512;
        public object _W;
        public object _K;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67136E0
        public void Initialize(){} // RVA: 0x6713890
        public void HashCore(){} // RVA: 0x67138F0
        public void HashFinal(){} // RVA: 0x6713900
        public void InitializeState(){} // RVA: 0x6713910
        public void _HashData(){} // RVA: 0x6713A40
        public void _EndHash(){} // RVA: 0x6713DA0
        public void SHATransform(){} // RVA: 0x67140F0
        public void RotateRight(){} // RVA: 0x6713170
        public void Ch(){} // RVA: 0x6713190
        public void Maj(){} // RVA: 0x67131A0
        public void Sigma_0(){} // RVA: 0x6714E80
        public void Sigma_1(){} // RVA: 0x6714F00
        public void sigma_0(){} // RVA: 0x6714F80
        public void sigma_1(){} // RVA: 0x6714FF0
        public void SHA512Expand(){} // RVA: 0x6715070
        public void .cctor(){} // RVA: 0x67151E0
    }

    public class SignatureDescription : Object
    {
        public object _strKey;
        public object _strDigest;
        public object _strFormatter;
        public object _strDeformatter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67152C0
        public void get_KeyAlgorithm(){} // RVA: 0xB5DBF0
        public void set_KeyAlgorithm(){} // RVA: 0xB44D60
        public void get_DigestAlgorithm(){} // RVA: 0xB465B0
        public void set_DigestAlgorithm(){} // RVA: 0xBA9BA0
        public void get_FormatterAlgorithm(){} // RVA: 0xB700F0
        public void set_FormatterAlgorithm(){} // RVA: 0xB70100
        public void get_DeformatterAlgorithm(){} // RVA: 0xB70160
        public void set_DeformatterAlgorithm(){} // RVA: 0xB44DC0
        public void CreateDeformatter(){} // RVA: 0x6715520
        public void CreateFormatter(){} // RVA: 0x6715630
        public void CreateDigest(){} // RVA: 0x6715740
    }

    public class SymmetricAlgorithm : Object
    {
        public object BlockSizeValue;
        public object FeedbackSizeValue;
        public object IVValue;
        public object KeyValue;
        public object LegalBlockSizesValue;
        public object LegalKeySizesValue;
        public object KeySizeValue;
        public object ModeValue;
        public object PaddingValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6716010
        public void Dispose(){} // RVA: 0x67160D0
        public void Clear(){} // RVA: 0x6716090
        public void get_BlockSize(){} // RVA: 0xB8F8F0
        public void set_BlockSize(){} // RVA: 0x67161E0
        public void get_FeedbackSize(){} // RVA: 0x116A650
        public void set_FeedbackSize(){} // RVA: 0x6716330
        public void get_IV(){} // RVA: 0x67163C0
        public void set_IV(){} // RVA: 0x6716460
        public void get_Key(){} // RVA: 0x6716620
        public void set_Key(){} // RVA: 0x67166C0
        public void get_LegalBlockSizes(){} // RVA: 0x6716890
        public void get_LegalKeySizes(){} // RVA: 0x6716910
        public void get_KeySize(){} // RVA: 0x18A0130
        public void set_KeySize(){} // RVA: 0x6716990
        public void get_Mode(){} // RVA: 0x114DAD0
        public void set_Mode(){} // RVA: 0x6716A60
        public void get_Padding(){} // RVA: 0xBE5850
        public void set_Padding(){} // RVA: 0x6716AE0
        public void ValidKeySize(){} // RVA: 0x6716B60
        public void Create(){} // RVA: 0x6716C50
        public void CreateEncryptor(){} // RVA: 0x87C5F0
        public void CreateDecryptor(){} // RVA: 0x87C5F0
        public void GenerateKey(){} // RVA: 0x894290
        public void GenerateIV(){} // RVA: 0x894290
    }

}