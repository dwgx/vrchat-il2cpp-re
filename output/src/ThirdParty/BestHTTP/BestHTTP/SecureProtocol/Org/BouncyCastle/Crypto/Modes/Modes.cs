// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
// Classes: 14
// Methods: 202

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
    public class CbcBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x959DC60
        public void GetUnderlyingCipher(){} // RVA: 0x6374D0
        public void Init(){} // RVA: 0x959DE50
        public void get_AlgorithmName(){} // RVA: 0x959E0B0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x959E120
        public void ProcessBlock(){} // RVA: 0x959E170
        public void Reset(){} // RVA: 0x959E310
        public void EncryptBlock(){} // RVA: 0x959E3B0
        public void DecryptBlock(){} // RVA: 0x959E520
    }

    public class CcmBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x959E740
        public void GetUnderlyingCipher(){} // RVA: 0x2F8380
        public void Init(){} // RVA: 0x959EA80
        public void get_AlgorithmName(){} // RVA: 0x959EEB0
        public void GetBlockSize(){} // RVA: 0x959EF20
        public void ProcessAadByte(){} // RVA: 0x959EF70
        public void ProcessAadBytes(){} // RVA: 0x6CCCC50
        public void ProcessByte(){} // RVA: 0x959EFA0
        public void ProcessBytes(){} // RVA: 0x959EFD0
        public void DoFinal(){} // RVA: 0x959F0C0
        public void Reset(){} // RVA: 0x959F190
        public void GetMac(){} // RVA: 0x959F220
        public void GetUpdateOutputSize(){} // RVA: 0x519240
        public void GetOutputSize(){} // RVA: 0x959F290
        public void ProcessPacket(){} // RVA: 0x959F410 | overloaded x2
        public void CalculateMac(){} // RVA: 0x959FD80
        public void GetAssociatedTextLength(){} // RVA: 0x95A02B0
        public void HasAssociatedText(){} // RVA: 0x95A0300
        public void .cctor(){} // RVA: 0x95A0360
    }

    public class CfbBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95A03A0
        public void GetUnderlyingCipher(){} // RVA: 0x6374D0
        public void Init(){} // RVA: 0x95A0600
        public void get_AlgorithmName(){} // RVA: 0x95A07C0
        public void get_IsPartialBlockOkay(){} // RVA: 0x3C2850
        public void GetBlockSize(){} // RVA: 0x1209F00
        public void ProcessBlock(){} // RVA: 0x95A08D0
        public void EncryptBlock(){} // RVA: 0x95A0900
        public void DecryptBlock(){} // RVA: 0x95A0B30
        public void Reset(){} // RVA: 0x95A0D50
    }

    public class CtsBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95A0DD0
        public void GetUpdateOutputSize(){} // RVA: 0x9598200
        public void GetOutputSize(){} // RVA: 0x950A7F0
        public void ProcessByte(){} // RVA: 0x95A1010
        public void ProcessBytes(){} // RVA: 0x95A1110
        public void DoFinal(){} // RVA: 0x95A1440
    }

    public class EaxBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95A1930
        public void get_AlgorithmName(){} // RVA: 0x95A1C80
        public void GetUnderlyingCipher(){} // RVA: 0x2F8380
        public void GetBlockSize(){} // RVA: 0x7F0280
        public void Init(){} // RVA: 0x95A1D10
        public void InitCipher(){} // RVA: 0x95A21E0
        public void CalculateMac(){} // RVA: 0x95A22B0
        public void Reset(){} // RVA: 0x95A23E0 | overloaded x2
        public void ProcessAadByte(){} // RVA: 0x95A2550
        public void ProcessAadBytes(){} // RVA: 0x95A2600
        public void ProcessByte(){} // RVA: 0x95A26D0
        public void ProcessBytes(){} // RVA: 0x95A2730
        public void DoFinal(){} // RVA: 0x95A27E0
        public void GetMac(){} // RVA: 0x95A2BE0
        public void GetUpdateOutputSize(){} // RVA: 0x95A2C50
        public void GetOutputSize(){} // RVA: 0x95A2C80
        public void Process(){} // RVA: 0x95A2CB0
        public void VerifyMac(){} // RVA: 0x95A2ED0
    }

    public class GOfbBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95A63B0
        public void GetUnderlyingCipher(){} // RVA: 0x6374D0
        public void Init(){} // RVA: 0x95A6640
        public void get_AlgorithmName(){} // RVA: 0x95A6870
        public void get_IsPartialBlockOkay(){} // RVA: 0x3C2850
        public void GetBlockSize(){} // RVA: 0x791DC0
        public void ProcessBlock(){} // RVA: 0x95A68E0
        public void Reset(){} // RVA: 0x95A6C80
        public void bytesToint(){} // RVA: 0x95A6D00
        public void intTobytes(){} // RVA: 0x95A6D70
    }

    public class GcmBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95A2F60 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x95A3250
        public void GetUnderlyingCipher(){} // RVA: 0x2E07C0
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void Init(){} // RVA: 0x95A32C0
        public void GetMac(){} // RVA: 0x95A3E20
        public void GetOutputSize(){} // RVA: 0x95A3F00
        public void GetUpdateOutputSize(){} // RVA: 0x95A3F30
        public void ProcessAadByte(){} // RVA: 0x95A3F60
        public void ProcessAadBytes(){} // RVA: 0x95A3FF0
        public void InitCipher(){} // RVA: 0x95A40D0
        public void ProcessByte(){} // RVA: 0x95A4260
        public void ProcessBytes(){} // RVA: 0x95A4340
        public void DoFinal(){} // RVA: 0x95A4610
        public void Reset(){} // RVA: 0x95A50B0 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x95A54D0
        public void ProcessPartial(){} // RVA: 0x95A5960
        public void gHASH(){} // RVA: 0x95A5C60
        public void gHASHBlock(){} // RVA: 0x95A5F10 | overloaded x2
        public void gHASHPartial(){} // RVA: 0x95A6070
        public void GetNextCtrBlock(){} // RVA: 0x95A6160
        public void CheckStatus(){} // RVA: 0x95A6300
    }

    public class IAeadBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void GetUnderlyingCipher(){} // RVA: 0xCD60
        public void Init(){} // RVA: 0x25600
        public void GetBlockSize(){} // RVA: 0xD840
        public void ProcessAadByte(){} // RVA: 0x25130
        public void ProcessAadBytes(){}
        public void ProcessByte(){}
        public void ProcessBytes(){}
        public void DoFinal(){}
        public void GetMac(){} // RVA: 0xCD60
        public void GetUpdateOutputSize(){} // RVA: 0x13FB0
        public void GetOutputSize(){} // RVA: 0x13FB0
        public void Reset(){} // RVA: 0x24A50
    }

    public class KCcmBlockCipher
    {
        // ── Methods ──
        public void setNb(){} // RVA: 0x95A6DE0
        public void .ctor(){} // RVA: 0x95A6E60 | overloaded x2
        public void Init(){} // RVA: 0x95A7410
        public void get_AlgorithmName(){} // RVA: 0x95A7950
        public void GetBlockSize(){} // RVA: 0x95A79C0
        public void GetUnderlyingCipher(){} // RVA: 0x2F8380
        public void ProcessAadByte(){} // RVA: 0x95A7A10
        public void ProcessAadBytes(){} // RVA: 0x95A7A40
        public void ProcessAAD(){} // RVA: 0x95A7A70
        public void ProcessByte(){} // RVA: 0x95A8140
        public void ProcessBytes(){} // RVA: 0x95A8170
        public void ProcessPacket(){} // RVA: 0x95A8260
        public void ProcessBlock(){} // RVA: 0x95A8F20
        public void CalculateMac(){} // RVA: 0x95A91A0
        public void DoFinal(){} // RVA: 0x95A92F0
        public void GetMac(){} // RVA: 0x95A93B0
        public void GetUpdateOutputSize(){} // RVA: 0x3B45020
        public void GetOutputSize(){} // RVA: 0x950A7F0
        public void Reset(){} // RVA: 0x95A9460
        public void intToBytes(){} // RVA: 0x95A6D70
        public void getFlag(){} // RVA: 0x95A9610
        public void .cctor(){} // RVA: 0x95A9910
    }

    public class KCtrBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95A9990
        public void GetUnderlyingCipher(){} // RVA: 0x4976A0
        public void Init(){} // RVA: 0x95A9BC0
        public void get_AlgorithmName(){} // RVA: 0x95A9DF0
        public void get_IsPartialBlockOkay(){} // RVA: 0x3C2850
        public void GetBlockSize(){} // RVA: 0x95A9E60
        public void ReturnByte(){} // RVA: 0x95A9EB0
        public void ProcessBytes(){} // RVA: 0x95A9EC0
        public void CalculateByte(){} // RVA: 0x95AA020
        public void ProcessBlock(){} // RVA: 0x95AA160
        public void Reset(){} // RVA: 0x95AA460
        public void incrementCounterAt(){} // RVA: 0x95AA4F0
        public void checkCounter(){} // RVA: 0x2DD310
    }

    public class OcbBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95AA550
        public void GetUnderlyingCipher(){} // RVA: 0x2E07C0
        public void get_AlgorithmName(){} // RVA: 0x95AA990
        public void Init(){} // RVA: 0x95AAA00
        public void ProcessNonce(){} // RVA: 0x95AB3A0
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void GetMac(){} // RVA: 0x95AB660
        public void GetOutputSize(){} // RVA: 0x95AB740
        public void GetUpdateOutputSize(){} // RVA: 0x95AB770
        public void ProcessAadByte(){} // RVA: 0x95AB7A0
        public void ProcessAadBytes(){} // RVA: 0x95AB800
        public void ProcessByte(){} // RVA: 0x95AB8C0
        public void ProcessBytes(){} // RVA: 0x95AB940
        public void DoFinal(){} // RVA: 0x95ABA20
        public void Reset(){} // RVA: 0x95AC870 | overloaded x2
        public void Clear(){} // RVA: 0x95AC170
        public void GetLSub(){} // RVA: 0x95AC190
        public void ProcessHashBlock(){} // RVA: 0x95AC4D0
        public void ProcessMainBlock(){} // RVA: 0x95AC540
        public void UpdateHASH(){} // RVA: 0x95ACA40
        public void OCB_double(){} // RVA: 0x95ACBA0
        public void OCB_extend(){} // RVA: 0x95ACC70
        public void OCB_ntz(){} // RVA: 0x95ACCC0
        public void ShiftLeft(){} // RVA: 0x95ACCF0
        public void Xor(){} // RVA: 0x95ACD60
    }

    public class OfbBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95ACDC0
        public void GetUnderlyingCipher(){} // RVA: 0x6374D0
        public void Init(){} // RVA: 0x95AD020
        public void get_AlgorithmName(){} // RVA: 0x95AD250
        public void get_IsPartialBlockOkay(){} // RVA: 0x3C2850
        public void GetBlockSize(){} // RVA: 0x791DC0
        public void ProcessBlock(){} // RVA: 0x95AD360
        public void Reset(){} // RVA: 0x95AD590
    }

    public class OpenPgpCfbBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95AD610
        public void GetUnderlyingCipher(){} // RVA: 0x30B130
        public void get_AlgorithmName(){} // RVA: 0x95AD800
        public void get_IsPartialBlockOkay(){} // RVA: 0x3C2850
        public void GetBlockSize(){} // RVA: 0x95AD870
        public void ProcessBlock(){} // RVA: 0x95AD8C0
        public void Reset(){} // RVA: 0x95AD8F0
        public void Init(){} // RVA: 0x95AD970
        public void EncryptByte(){} // RVA: 0x95ADB90
        public void EncryptBlock(){} // RVA: 0x95ADBC0
        public void DecryptBlock(){} // RVA: 0x95AE120
    }

    public class SicBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95AE6D0
        public void GetUnderlyingCipher(){} // RVA: 0x2F8380
        public void Init(){} // RVA: 0x95AE8C0
        public void get_AlgorithmName(){} // RVA: 0x95AEC70
        public void get_IsPartialBlockOkay(){} // RVA: 0x3C2850
        public void GetBlockSize(){} // RVA: 0x95AECE0
        public void ProcessBlock(){} // RVA: 0x95AED30
        public void Reset(){} // RVA: 0x95AEEA0
    }

}