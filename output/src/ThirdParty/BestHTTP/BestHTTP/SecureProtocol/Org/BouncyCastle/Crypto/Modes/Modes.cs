// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
// Classes: 14
// Methods: 202

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
    public class CbcBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC04DC60
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF30E74D0
        public void Init(){} // RVA: 0x7FFAFC04DE50
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC04E0B0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAF2D8D320
        public void GetBlockSize(){} // RVA: 0x7FFAFC04E120
        public void ProcessBlock(){} // RVA: 0x7FFAFC04E170
        public void Reset(){} // RVA: 0x7FFAFC04E310
        public void EncryptBlock(){} // RVA: 0x7FFAFC04E3B0
        public void DecryptBlock(){} // RVA: 0x7FFAFC04E520
    }

    public class CcmBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC04E740
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2DA8380
        public void Init(){} // RVA: 0x7FFAFC04EA80
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC04EEB0
        public void GetBlockSize(){} // RVA: 0x7FFAFC04EF20
        public void ProcessAadByte(){} // RVA: 0x7FFAFC04EF70
        public void ProcessAadBytes(){} // RVA: 0x7FFAF977CC50
        public void ProcessByte(){} // RVA: 0x7FFAFC04EFA0
        public void ProcessBytes(){} // RVA: 0x7FFAFC04EFD0
        public void DoFinal(){} // RVA: 0x7FFAFC04F0C0
        public void Reset(){} // RVA: 0x7FFAFC04F190
        public void GetMac(){} // RVA: 0x7FFAFC04F220
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAF2FC9240
        public void GetOutputSize(){} // RVA: 0x7FFAFC04F290
        public void ProcessPacket(){} // RVA: 0x7FFAFC04F410 | overloaded x2
        public void CalculateMac(){} // RVA: 0x7FFAFC04FD80
        public void GetAssociatedTextLength(){} // RVA: 0x7FFAFC0502B0
        public void HasAssociatedText(){} // RVA: 0x7FFAFC050300
        public void .cctor(){} // RVA: 0x7FFAFC050360
    }

    public class CfbBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0503A0
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF30E74D0
        public void Init(){} // RVA: 0x7FFAFC050600
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC0507C0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAF2E72850
        public void GetBlockSize(){} // RVA: 0x7FFAF3CB9F00
        public void ProcessBlock(){} // RVA: 0x7FFAFC0508D0
        public void EncryptBlock(){} // RVA: 0x7FFAFC050900
        public void DecryptBlock(){} // RVA: 0x7FFAFC050B30
        public void Reset(){} // RVA: 0x7FFAFC050D50
    }

    public class CtsBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC050DD0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAFC048200
        public void GetOutputSize(){} // RVA: 0x7FFAFBFBA7F0
        public void ProcessByte(){} // RVA: 0x7FFAFC051010
        public void ProcessBytes(){} // RVA: 0x7FFAFC051110
        public void DoFinal(){} // RVA: 0x7FFAFC051440
    }

    public class EaxBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC051930
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC051C80
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2DA8380
        public void GetBlockSize(){} // RVA: 0x7FFAF32A0280
        public void Init(){} // RVA: 0x7FFAFC051D10
        public void InitCipher(){} // RVA: 0x7FFAFC0521E0
        public void CalculateMac(){} // RVA: 0x7FFAFC0522B0
        public void Reset(){} // RVA: 0x7FFAFC0523E0 | overloaded x2
        public void ProcessAadByte(){} // RVA: 0x7FFAFC052550
        public void ProcessAadBytes(){} // RVA: 0x7FFAFC052600
        public void ProcessByte(){} // RVA: 0x7FFAFC0526D0
        public void ProcessBytes(){} // RVA: 0x7FFAFC052730
        public void DoFinal(){} // RVA: 0x7FFAFC0527E0
        public void GetMac(){} // RVA: 0x7FFAFC052BE0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAFC052C50
        public void GetOutputSize(){} // RVA: 0x7FFAFC052C80
        public void Process(){} // RVA: 0x7FFAFC052CB0
        public void VerifyMac(){} // RVA: 0x7FFAFC052ED0
    }

    public class GOfbBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0563B0
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF30E74D0
        public void Init(){} // RVA: 0x7FFAFC056640
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC056870
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAF2E72850
        public void GetBlockSize(){} // RVA: 0x7FFAF3241DC0
        public void ProcessBlock(){} // RVA: 0x7FFAFC0568E0
        public void Reset(){} // RVA: 0x7FFAFC056C80
        public void bytesToint(){} // RVA: 0x7FFAFC056D00
        public void intTobytes(){} // RVA: 0x7FFAFC056D70
    }

    public class GcmBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC052F60 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC053250
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2D907C0
        public void GetBlockSize(){} // RVA: 0x7FFAF4BBE2B0
        public void Init(){} // RVA: 0x7FFAFC0532C0
        public void GetMac(){} // RVA: 0x7FFAFC053E20
        public void GetOutputSize(){} // RVA: 0x7FFAFC053F00
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAFC053F30
        public void ProcessAadByte(){} // RVA: 0x7FFAFC053F60
        public void ProcessAadBytes(){} // RVA: 0x7FFAFC053FF0
        public void InitCipher(){} // RVA: 0x7FFAFC0540D0
        public void ProcessByte(){} // RVA: 0x7FFAFC054260
        public void ProcessBytes(){} // RVA: 0x7FFAFC054340
        public void DoFinal(){} // RVA: 0x7FFAFC054610
        public void Reset(){} // RVA: 0x7FFAFC0550B0 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x7FFAFC0554D0
        public void ProcessPartial(){} // RVA: 0x7FFAFC055960
        public void gHASH(){} // RVA: 0x7FFAFC055C60
        public void gHASHBlock(){} // RVA: 0x7FFAFC055F10 | overloaded x2
        public void gHASHPartial(){} // RVA: 0x7FFAFC056070
        public void GetNextCtrBlock(){} // RVA: 0x7FFAFC056160
        public void CheckStatus(){} // RVA: 0x7FFAFC056300
    }

    public class IAeadBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2ABCD60
        public void Init(){} // RVA: 0x7FFAF2AD5600
        public void GetBlockSize(){} // RVA: 0x7FFAF2ABD840
        public void ProcessAadByte(){} // RVA: 0x7FFAF2AD5130
        public void ProcessAadBytes(){}
        public void ProcessByte(){}
        public void ProcessBytes(){}
        public void DoFinal(){}
        public void GetMac(){} // RVA: 0x7FFAF2ABCD60
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAF2AC3FB0
        public void GetOutputSize(){} // RVA: 0x7FFAF2AC3FB0
        public void Reset(){} // RVA: 0x7FFAF2AD4A50
    }

    public class KCcmBlockCipher
    {
        // ── Methods ──
        public void setNb(){} // RVA: 0x7FFAFC056DE0
        public void .ctor(){} // RVA: 0x7FFAFC056E60 | overloaded x2
        public void Init(){} // RVA: 0x7FFAFC057410
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC057950
        public void GetBlockSize(){} // RVA: 0x7FFAFC0579C0
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2DA8380
        public void ProcessAadByte(){} // RVA: 0x7FFAFC057A10
        public void ProcessAadBytes(){} // RVA: 0x7FFAFC057A40
        public void ProcessAAD(){} // RVA: 0x7FFAFC057A70
        public void ProcessByte(){} // RVA: 0x7FFAFC058140
        public void ProcessBytes(){} // RVA: 0x7FFAFC058170
        public void ProcessPacket(){} // RVA: 0x7FFAFC058260
        public void ProcessBlock(){} // RVA: 0x7FFAFC058F20
        public void CalculateMac(){} // RVA: 0x7FFAFC0591A0
        public void DoFinal(){} // RVA: 0x7FFAFC0592F0
        public void GetMac(){} // RVA: 0x7FFAFC0593B0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAF65F5020
        public void GetOutputSize(){} // RVA: 0x7FFAFBFBA7F0
        public void Reset(){} // RVA: 0x7FFAFC059460
        public void intToBytes(){} // RVA: 0x7FFAFC056D70
        public void getFlag(){} // RVA: 0x7FFAFC059610
        public void .cctor(){} // RVA: 0x7FFAFC059910
    }

    public class KCtrBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC059990
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2F476A0
        public void Init(){} // RVA: 0x7FFAFC059BC0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC059DF0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAF2E72850
        public void GetBlockSize(){} // RVA: 0x7FFAFC059E60
        public void ReturnByte(){} // RVA: 0x7FFAFC059EB0
        public void ProcessBytes(){} // RVA: 0x7FFAFC059EC0
        public void CalculateByte(){} // RVA: 0x7FFAFC05A020
        public void ProcessBlock(){} // RVA: 0x7FFAFC05A160
        public void Reset(){} // RVA: 0x7FFAFC05A460
        public void incrementCounterAt(){} // RVA: 0x7FFAFC05A4F0
        public void checkCounter(){} // RVA: 0x7FFAF2D8D310
    }

    public class OcbBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC05A550
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2D907C0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC05A990
        public void Init(){} // RVA: 0x7FFAFC05AA00
        public void ProcessNonce(){} // RVA: 0x7FFAFC05B3A0
        public void GetBlockSize(){} // RVA: 0x7FFAF4BBE2B0
        public void GetMac(){} // RVA: 0x7FFAFC05B660
        public void GetOutputSize(){} // RVA: 0x7FFAFC05B740
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAFC05B770
        public void ProcessAadByte(){} // RVA: 0x7FFAFC05B7A0
        public void ProcessAadBytes(){} // RVA: 0x7FFAFC05B800
        public void ProcessByte(){} // RVA: 0x7FFAFC05B8C0
        public void ProcessBytes(){} // RVA: 0x7FFAFC05B940
        public void DoFinal(){} // RVA: 0x7FFAFC05BA20
        public void Reset(){} // RVA: 0x7FFAFC05C870 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAFC05C170
        public void GetLSub(){} // RVA: 0x7FFAFC05C190
        public void ProcessHashBlock(){} // RVA: 0x7FFAFC05C4D0
        public void ProcessMainBlock(){} // RVA: 0x7FFAFC05C540
        public void UpdateHASH(){} // RVA: 0x7FFAFC05CA40
        public void OCB_double(){} // RVA: 0x7FFAFC05CBA0
        public void OCB_extend(){} // RVA: 0x7FFAFC05CC70
        public void OCB_ntz(){} // RVA: 0x7FFAFC05CCC0
        public void ShiftLeft(){} // RVA: 0x7FFAFC05CCF0
        public void Xor(){} // RVA: 0x7FFAFC05CD60
    }

    public class OfbBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC05CDC0
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF30E74D0
        public void Init(){} // RVA: 0x7FFAFC05D020
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC05D250
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAF2E72850
        public void GetBlockSize(){} // RVA: 0x7FFAF3241DC0
        public void ProcessBlock(){} // RVA: 0x7FFAFC05D360
        public void Reset(){} // RVA: 0x7FFAFC05D590
    }

    public class OpenPgpCfbBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC05D610
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2DBB130
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC05D800
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAF2E72850
        public void GetBlockSize(){} // RVA: 0x7FFAFC05D870
        public void ProcessBlock(){} // RVA: 0x7FFAFC05D8C0
        public void Reset(){} // RVA: 0x7FFAFC05D8F0
        public void Init(){} // RVA: 0x7FFAFC05D970
        public void EncryptByte(){} // RVA: 0x7FFAFC05DB90
        public void EncryptBlock(){} // RVA: 0x7FFAFC05DBC0
        public void DecryptBlock(){} // RVA: 0x7FFAFC05E120
    }

    public class SicBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC05E6D0
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAF2DA8380
        public void Init(){} // RVA: 0x7FFAFC05E8C0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC05EC70
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAF2E72850
        public void GetBlockSize(){} // RVA: 0x7FFAFC05ECE0
        public void ProcessBlock(){} // RVA: 0x7FFAFC05ED30
        public void Reset(){} // RVA: 0x7FFAFC05EEA0
    }

}