// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
// Classes: 14
// Methods: 195

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
    public class CbcBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13D4560
        public void GetUnderlyingCipher(){} // RVA: 0x7A83F69F0
        public void Init(){} // RVA: 0x7B13D4750
        public void get_AlgorithmName(){} // RVA: 0x7B13D49B0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7B13D4A20
        public void ProcessBlock(){} // RVA: 0x7B13D4A70
        public void Reset(){} // RVA: 0x7B13D4C10
        public void EncryptBlock(){} // RVA: 0x7B13D4CB0
        public void DecryptBlock(){} // RVA: 0x7B13D4E20
    }

    public class CcmBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13D5060
        public void GetUnderlyingCipher(){} // RVA: 0x7A80F2570
        public void Init(){} // RVA: 0x7B13D53A0
        public void get_AlgorithmName(){} // RVA: 0x7B13D57E0
        public void GetBlockSize(){} // RVA: 0x7B13D5850
        public void ProcessAadByte(){} // RVA: 0x7B13D58A0
        public void ProcessAadBytes(){} // RVA: 0x7AEABBDC0
        public void ProcessByte(){} // RVA: 0x7B13D58D0
        public void ProcessBytes(){} // RVA: 0x7B13D5900
        public void DoFinal(){} // RVA: 0x7B13D59F0
        public void Reset(){} // RVA: 0x7B13D5AC0
        public void GetMac(){} // RVA: 0x7B13D5B50
        public void GetUpdateOutputSize(){} // RVA: 0x7A82D1450
        public void GetOutputSize(){} // RVA: 0x7B13D5BC0
        public void ProcessPacket(){} // RVA: 0x7B13D5D40
        public void CalculateMac(){} // RVA: 0x7B13D66C0
        public void GetAssociatedTextLength(){} // RVA: 0x7B13D6BF0
        public void HasAssociatedText(){} // RVA: 0x7B13D6C40
        public void .cctor(){} // RVA: 0x7B13D6CA0
    }

    public class CfbBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13D6CE0
        public void GetUnderlyingCipher(){} // RVA: 0x7A83F69F0
        public void Init(){} // RVA: 0x7B13D6F40
        public void get_AlgorithmName(){} // RVA: 0x7B13D7100
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A81BD750
        public void GetBlockSize(){} // RVA: 0x7A8F9ACE0
        public void ProcessBlock(){} // RVA: 0x7B13D7210
        public void EncryptBlock(){} // RVA: 0x7B13D7240
        public void DecryptBlock(){} // RVA: 0x7B13D7480
        public void Reset(){} // RVA: 0x7B13D76B0
    }

    public class CtsBlockCipher : BufferedBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13D7730
        public void GetUpdateOutputSize(){} // RVA: 0x7B13CEBB0
        public void GetOutputSize(){} // RVA: 0x7B1340830
        public void ProcessByte(){} // RVA: 0x7B13D7970
        public void ProcessBytes(){} // RVA: 0x7B13D7A70
        public void DoFinal(){} // RVA: 0x7B13D7DD0
    }

    public class EaxBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13D8310
        public void get_AlgorithmName(){} // RVA: 0x7B13D8660
        public void GetUnderlyingCipher(){} // RVA: 0x7A80F2570
        public void GetBlockSize(){} // RVA: 0x7A858AB50
        public void Init(){} // RVA: 0x7B13D86F0
        public void InitCipher(){} // RVA: 0x7B13D8BC0
        public void CalculateMac(){} // RVA: 0x7B13D8C90
        public void Reset(){} // RVA: 0x7B13D8DB0
        public void ProcessAadByte(){} // RVA: 0x7B13D8F20
        public void ProcessAadBytes(){} // RVA: 0x7B13D8FD0
        public void ProcessByte(){} // RVA: 0x7B13D90A0
        public void ProcessBytes(){} // RVA: 0x7B13D9100
        public void DoFinal(){} // RVA: 0x7B13D91C0
        public void GetMac(){} // RVA: 0x7B13D95B0
        public void GetUpdateOutputSize(){} // RVA: 0x7B13D9620
        public void GetOutputSize(){} // RVA: 0x7B13D9650
        public void Process(){} // RVA: 0x7B13D9680
        public void VerifyMac(){} // RVA: 0x7B13D98A0
    }

    public class GOfbBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13DCDA0
        public void GetUnderlyingCipher(){} // RVA: 0x7A83F69F0
        public void Init(){} // RVA: 0x7B13DD030
        public void get_AlgorithmName(){} // RVA: 0x7B13DD260
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A81BD750
        public void GetBlockSize(){} // RVA: 0x7A854FDE0
        public void ProcessBlock(){} // RVA: 0x7B13DD2D0
        public void Reset(){} // RVA: 0x7B13DD6A0
        public void bytesToint(){} // RVA: 0x7B13DD720
        public void intTobytes(){} // RVA: 0x7B13DD790
    }

    public class GcmBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13D9940
        public void get_AlgorithmName(){} // RVA: 0x7B13D9C30
        public void GetUnderlyingCipher(){} // RVA: 0x7A80DA7B0
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void Init(){} // RVA: 0x7B13D9CA0
        public void GetMac(){} // RVA: 0x7B13DA820
        public void GetOutputSize(){} // RVA: 0x7B13DA900
        public void GetUpdateOutputSize(){} // RVA: 0x7B13DA930
        public void ProcessAadByte(){} // RVA: 0x7B13DA960
        public void ProcessAadBytes(){} // RVA: 0x7B13DA9F0
        public void InitCipher(){} // RVA: 0x7B13DAAE0
        public void ProcessByte(){} // RVA: 0x7B13DAC60
        public void ProcessBytes(){} // RVA: 0x7B13DAD40
        public void DoFinal(){} // RVA: 0x7B13DB020
        public void Reset(){} // RVA: 0x7B13DBAD0
        public void ProcessBlock(){} // RVA: 0x7B13DBEF0
        public void ProcessPartial(){} // RVA: 0x7B13DC360
        public void gHASH(){} // RVA: 0x7B13DC680
        public void gHASHBlock(){} // RVA: 0x7B13DC940
        public void gHASHPartial(){} // RVA: 0x7B13DCA90
        public void GetNextCtrBlock(){} // RVA: 0x7B13DCB80
        public void CheckStatus(){} // RVA: 0x7B13DCCF0
    }

    public class IAeadBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void GetUnderlyingCipher(){} // RVA: 0x7A7E00680
        public void Init(){} // RVA: 0x7A7E19310
        public void GetBlockSize(){} // RVA: 0x7A7E00710
        public void ProcessAadByte(){} // RVA: 0x7A7E18C30
        public void ProcessAadBytes(){} // RVA: 0x7A7E1E220
        public void ProcessByte(){} // RVA: 0x7A7E07990
        public void ProcessBytes(){} // RVA: 0x7A7E0A1D0
        public void DoFinal(){} // RVA: 0x7A7E09FB0
        public void GetMac(){} // RVA: 0x7A7E00680
        public void GetUpdateOutputSize(){} // RVA: 0x7A7E062A0
        public void GetOutputSize(){} // RVA: 0x7A7E062A0
        public void Reset(){} // RVA: 0x7A7E18770
    }

    public class KCcmBlockCipher : Object
    {
        // ── Methods ──
        public void setNb(){} // RVA: 0x7B13DD800
        public void .ctor(){} // RVA: 0x7B13DD880
        public void Init(){} // RVA: 0x7B13DDE50
        public void get_AlgorithmName(){} // RVA: 0x7B13DE3A0
        public void GetBlockSize(){} // RVA: 0x7B13DE410
        public void GetUnderlyingCipher(){} // RVA: 0x7A80F2570
        public void ProcessAadByte(){} // RVA: 0x7B13DE460
        public void ProcessAadBytes(){} // RVA: 0x7B13DE490
        public void ProcessAAD(){} // RVA: 0x7B13DE4C0
        public void ProcessByte(){} // RVA: 0x7B13DEBA0
        public void ProcessBytes(){} // RVA: 0x7B13DEBD0
        public void ProcessPacket(){} // RVA: 0x7B13DECC0
        public void ProcessBlock(){} // RVA: 0x7B13DF8A0
        public void CalculateMac(){} // RVA: 0x7B13DFB40
        public void DoFinal(){} // RVA: 0x7B13DFCB0
        public void GetMac(){} // RVA: 0x7B13DFD70
        public void GetUpdateOutputSize(){} // RVA: 0x7AB93BE00
        public void GetOutputSize(){} // RVA: 0x7B1340830
        public void Reset(){} // RVA: 0x7B13DFE20
        public void intToBytes(){} // RVA: 0x7B13DD790
        public void getFlag(){} // RVA: 0x7B13DFFD0
        public void .cctor(){} // RVA: 0x7B13E02D0
    }

    public class KCtrBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13E0350
        public void GetUnderlyingCipher(){} // RVA: 0x7A8292C30
        public void Init(){} // RVA: 0x7B13E0580
        public void get_AlgorithmName(){} // RVA: 0x7B13E07B0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A81BD750
        public void GetBlockSize(){} // RVA: 0x7B13E0820
        public void ReturnByte(){} // RVA: 0x7B13E0870
        public void ProcessBytes(){} // RVA: 0x7B13E0880
        public void CalculateByte(){} // RVA: 0x7B13E0A00
        public void ProcessBlock(){} // RVA: 0x7B13E0B40
        public void Reset(){} // RVA: 0x7B13E0E70
        public void incrementCounterAt(){} // RVA: 0x7B13E0F00
        public void checkCounter(){} // RVA: 0x7A80D7310
    }

    public class OcbBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13E0F60
        public void GetUnderlyingCipher(){} // RVA: 0x7A80DA7B0
        public void get_AlgorithmName(){} // RVA: 0x7B13E13A0
        public void Init(){} // RVA: 0x7B13E1410
        public void ProcessNonce(){} // RVA: 0x7B13E1DE0
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void GetMac(){} // RVA: 0x7B13E20A0
        public void GetOutputSize(){} // RVA: 0x7B13E2180
        public void GetUpdateOutputSize(){} // RVA: 0x7B13E21B0
        public void ProcessAadByte(){} // RVA: 0x7B13E21E0
        public void ProcessAadBytes(){} // RVA: 0x7B13E2240
        public void ProcessByte(){} // RVA: 0x7B13E2300
        public void ProcessBytes(){} // RVA: 0x7B13E2380
        public void DoFinal(){} // RVA: 0x7B13E2480
        public void Reset(){} // RVA: 0x7B13E3460
        public void Clear(){} // RVA: 0x7B13E2C60
        public void GetLSub(){} // RVA: 0x7B13E2C80
        public void ProcessHashBlock(){} // RVA: 0x7B13E3090
        public void ProcessMainBlock(){} // RVA: 0x7B13E3100
        public void UpdateHASH(){} // RVA: 0x7B13E3630
        public void OCB_double(){} // RVA: 0x7B13E37C0
        public void OCB_extend(){} // RVA: 0x7B13E3880
        public void OCB_ntz(){} // RVA: 0x7B13E38E0
        public void ShiftLeft(){} // RVA: 0x7B13E3910
        public void Xor(){} // RVA: 0x7B13E3980
    }

    public class OfbBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13E39E0
        public void GetUnderlyingCipher(){} // RVA: 0x7A83F69F0
        public void Init(){} // RVA: 0x7B13E3C40
        public void get_AlgorithmName(){} // RVA: 0x7B13E3E60
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A81BD750
        public void GetBlockSize(){} // RVA: 0x7A854FDE0
        public void ProcessBlock(){} // RVA: 0x7B13E3F70
        public void Reset(){} // RVA: 0x7B13E41A0
    }

    public class OpenPgpCfbBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13E4220
        public void GetUnderlyingCipher(){} // RVA: 0x7A8105330
        public void get_AlgorithmName(){} // RVA: 0x7B13E4410
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A81BD750
        public void GetBlockSize(){} // RVA: 0x7B13E4480
        public void ProcessBlock(){} // RVA: 0x7B13E44D0
        public void Reset(){} // RVA: 0x7B13E4500
        public void Init(){} // RVA: 0x7B13E4580
        public void EncryptByte(){} // RVA: 0x7B13E47A0
        public void EncryptBlock(){} // RVA: 0x7B13E47D0
        public void DecryptBlock(){} // RVA: 0x7B13E4D60
    }

    public class SicBlockCipher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B13E5310
        public void GetUnderlyingCipher(){} // RVA: 0x7A80F2570
        public void Init(){} // RVA: 0x7B13E5500
        public void get_AlgorithmName(){} // RVA: 0x7B13E58A0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A81BD750
        public void GetBlockSize(){} // RVA: 0x7B13E5910
        public void ProcessBlock(){} // RVA: 0x7B13E5960
        public void Reset(){} // RVA: 0x7B13E5AE0
    }

}