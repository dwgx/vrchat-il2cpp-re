// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
// Classes: 14
// Methods: 195

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
    public class CbcBlockCipher : Object
    {
        public object IV;
        public object cbcV;
        public object cbcNextV;
        public object blockSize;
        public object cipher;
        public object encrypting;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA23FB50
        public void GetUnderlyingCipher(){} // RVA: 0xD33E60
        public void Init(){} // RVA: 0xA23FD40
        public void get_AlgorithmName(){} // RVA: 0xA23FFA0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0xA240010
        public void ProcessBlock(){} // RVA: 0xA240060
        public void Reset(){} // RVA: 0xA240200
        public void EncryptBlock(){} // RVA: 0xA2402A0
        public void DecryptBlock(){} // RVA: 0xA240410
    }

    public class CcmBlockCipher : Object
    {
        public object BlockSize;
        public object cipher;
        public object macBlock;
        public object forEncryption;
        public object nonce;
        public object initialAssociatedText;
        public object macSize;
        public object keyParam;
        public object associatedText;
        public object data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA240650
        public void GetUnderlyingCipher(){} // RVA: 0xB5DBF0
        public void Init(){} // RVA: 0xA240990
        public void get_AlgorithmName(){} // RVA: 0xA240DD0
        public void GetBlockSize(){} // RVA: 0xA240E40
        public void ProcessAadByte(){} // RVA: 0xA240E90
        public void ProcessAadBytes(){} // RVA: 0x772B560
        public void ProcessByte(){} // RVA: 0xA240EC0
        public void ProcessBytes(){} // RVA: 0xA240EF0
        public void DoFinal(){} // RVA: 0xA240FE0
        public void Reset(){} // RVA: 0xA2410B0
        public void GetMac(){} // RVA: 0xA241140
        public void GetUpdateOutputSize(){} // RVA: 0xDAC980
        public void GetOutputSize(){} // RVA: 0xA2411B0
        public void ProcessPacket(){} // RVA: 0xA241330
        public void CalculateMac(){} // RVA: 0xA241CB0
        public void GetAssociatedTextLength(){} // RVA: 0xA2421E0
        public void HasAssociatedText(){} // RVA: 0xA242230
        public void .cctor(){} // RVA: 0xA242290
    }

    public class CfbBlockCipher : Object
    {
        public object IV;
        public object cfbV;
        public object cfbOutV;
        public object encrypting;
        public object blockSize;
        public object cipher;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2422D0
        public void GetUnderlyingCipher(){} // RVA: 0xD33E60
        public void Init(){} // RVA: 0xA242530
        public void get_AlgorithmName(){} // RVA: 0xA2426F0
        public void get_IsPartialBlockOkay(){} // RVA: 0xC2E4C0
        public void GetBlockSize(){} // RVA: 0x1AE5AC0
        public void ProcessBlock(){} // RVA: 0xA242800
        public void EncryptBlock(){} // RVA: 0xA242830
        public void DecryptBlock(){} // RVA: 0xA242A70
        public void Reset(){} // RVA: 0xA242CA0
    }

    public class CtsBlockCipher : BufferedBlockCipher
    {
        public object blockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA242D20
        public void GetUpdateOutputSize(){} // RVA: 0xA23A1A0
        public void GetOutputSize(){} // RVA: 0xA1AC180
        public void ProcessByte(){} // RVA: 0xA242F60
        public void ProcessBytes(){} // RVA: 0xA243060
        public void DoFinal(){} // RVA: 0xA2433C0
    }

    public class EaxBlockCipher : Object
    {
        public object cipher;
        public object forEncryption;
        public object blockSize;
        public object mac;
        public object nonceMac;
        public object associatedTextMac;
        public object macBlock;
        public object macSize;
        public object bufBlock;
        public object bufOff;
        public object cipherInitialized;
        public object initialAssociatedText;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA243900
        public void get_AlgorithmName(){} // RVA: 0xA243C50
        public void GetUnderlyingCipher(){} // RVA: 0xB5DBF0
        public void GetBlockSize(){} // RVA: 0x10AD020
        public void Init(){} // RVA: 0xA243CE0
        public void InitCipher(){} // RVA: 0xA2441B0
        public void CalculateMac(){} // RVA: 0xA244280
        public void Reset(){} // RVA: 0xA2443A0
        public void ProcessAadByte(){} // RVA: 0xA244510
        public void ProcessAadBytes(){} // RVA: 0xA2445C0
        public void ProcessByte(){} // RVA: 0xA244690
        public void ProcessBytes(){} // RVA: 0xA2446F0
        public void DoFinal(){} // RVA: 0xA2447B0
        public void GetMac(){} // RVA: 0xA244BA0
        public void GetUpdateOutputSize(){} // RVA: 0xA244C10
        public void GetOutputSize(){} // RVA: 0xA244C40
        public void Process(){} // RVA: 0xA244C70
        public void VerifyMac(){} // RVA: 0xA244E90
    }

    public class GOfbBlockCipher : Object
    {
        public object IV;
        public object ofbV;
        public object ofbOutV;
        public object blockSize;
        public object cipher;
        public object firstStep;
        public object N3;
        public object N4;
        public object C1;
        public object C2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA248390
        public void GetUnderlyingCipher(){} // RVA: 0xD33E60
        public void Init(){} // RVA: 0xA248620
        public void get_AlgorithmName(){} // RVA: 0xA248850
        public void get_IsPartialBlockOkay(){} // RVA: 0xC2E4C0
        public void GetBlockSize(){} // RVA: 0x1065D50
        public void ProcessBlock(){} // RVA: 0xA2488C0
        public void Reset(){} // RVA: 0xA248C90
        public void bytesToint(){} // RVA: 0xA248D10
        public void intTobytes(){} // RVA: 0xA248D80
    }

    public class GcmBlockCipher : Object
    {
        public object BlockSize;
        public object ctrBlock;
        public object cipher;
        public object multiplier;
        public object exp;
        public object forEncryption;
        public object initialised;
        public object macSize;
        public object lastKey;
        public object nonce;
        public object initialAssociatedText;
        public object H;
        public object J0;
        public object bufBlock;
        public object macBlock;
        public object S;
        public object S_at;
        public object S_atPre;
        public object counter;
        public object blocksRemaining;
        public object bufOff;
        public object totalLength;
        public object atBlock;
        public object atBlockPos;
        public object atLength;
        public object atLengthPre;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA244F30
        public void get_AlgorithmName(){} // RVA: 0xA245220
        public void GetUnderlyingCipher(){} // RVA: 0xB465B0
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void Init(){} // RVA: 0xA245290
        public void GetMac(){} // RVA: 0xA245E10
        public void GetOutputSize(){} // RVA: 0xA245EF0
        public void GetUpdateOutputSize(){} // RVA: 0xA245F20
        public void ProcessAadByte(){} // RVA: 0xA245F50
        public void ProcessAadBytes(){} // RVA: 0xA245FE0
        public void InitCipher(){} // RVA: 0xA2460D0
        public void ProcessByte(){} // RVA: 0xA246250
        public void ProcessBytes(){} // RVA: 0xA246330
        public void DoFinal(){} // RVA: 0xA246610
        public void Reset(){} // RVA: 0xA2470C0
        public void ProcessBlock(){} // RVA: 0xA2474E0
        public void ProcessPartial(){} // RVA: 0xA247950
        public void gHASH(){} // RVA: 0xA247C70
        public void gHASHBlock(){} // RVA: 0xA247F30
        public void gHASHPartial(){} // RVA: 0xA248080
        public void GetNextCtrBlock(){} // RVA: 0xA248170
        public void CheckStatus(){} // RVA: 0xA2482E0
    }

    public class IAeadBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x87C0A0
        public void GetUnderlyingCipher(){} // RVA: 0x87C0A0
        public void Init(){} // RVA: 0x894DF0
        public void GetBlockSize(){} // RVA: 0x87C130
        public void ProcessAadByte(){} // RVA: 0x894750
        public void ProcessAadBytes(){} // RVA: 0x89B9B0
        public void ProcessByte(){} // RVA: 0x883350
        public void ProcessBytes(){} // RVA: 0x885B90
        public void DoFinal(){} // RVA: 0x885970
        public void GetMac(){} // RVA: 0x87C0A0
        public void GetUpdateOutputSize(){} // RVA: 0x881C20
        public void GetOutputSize(){} // RVA: 0x881C20
        public void Reset(){} // RVA: 0x894290
    }

    public class KCcmBlockCipher : Object
    {
        public object BYTES_IN_INT;
        public object BITS_IN_BYTE;
        public object MAX_MAC_BIT_LENGTH;
        public object MIN_MAC_BIT_LENGTH;
        public object engine;
        public object macSize;
        public object forEncryption;
        public object initialAssociatedText;
        public object mac;
        public object macBlock;
        public object nonce;
        public object G1;
        public object buffer;
        public object s;
        public object counter;
        public object associatedText;
        public object data;
        public object Nb_;

        // ── Methods ──
        public void setNb(){} // RVA: 0xA248DF0
        public void .ctor(){} // RVA: 0xA248E70
        public void Init(){} // RVA: 0xA249440
        public void get_AlgorithmName(){} // RVA: 0xA249990
        public void GetBlockSize(){} // RVA: 0xA249A00
        public void GetUnderlyingCipher(){} // RVA: 0xB5DBF0
        public void ProcessAadByte(){} // RVA: 0xA249A50
        public void ProcessAadBytes(){} // RVA: 0xA249A80
        public void ProcessAAD(){} // RVA: 0xA249AB0
        public void ProcessByte(){} // RVA: 0xA24A190
        public void ProcessBytes(){} // RVA: 0xA24A1C0
        public void ProcessPacket(){} // RVA: 0xA24A2B0
        public void ProcessBlock(){} // RVA: 0xA24AE90
        public void CalculateMac(){} // RVA: 0xA24B130
        public void DoFinal(){} // RVA: 0xA24B2A0
        public void GetMac(){} // RVA: 0xA24B360
        public void GetUpdateOutputSize(){} // RVA: 0x44E8220
        public void GetOutputSize(){} // RVA: 0xA1AC180
        public void Reset(){} // RVA: 0xA24B410
        public void intToBytes(){} // RVA: 0xA248D80
        public void getFlag(){} // RVA: 0xA24B5C0
        public void .cctor(){} // RVA: 0xA24B8C0
    }

    public class KCtrBlockCipher : Object
    {
        public object IV;
        public object ofbV;
        public object ofbOutV;
        public object initialised;
        public object byteCount;
        public object blockSize;
        public object cipher;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA24B940
        public void GetUnderlyingCipher(){} // RVA: 0xD05CA0
        public void Init(){} // RVA: 0xA24BB70
        public void get_AlgorithmName(){} // RVA: 0xA24BDA0
        public void get_IsPartialBlockOkay(){} // RVA: 0xC2E4C0
        public void GetBlockSize(){} // RVA: 0xA24BE10
        public void ReturnByte(){} // RVA: 0xA24BE60
        public void ProcessBytes(){} // RVA: 0xA24BE70
        public void CalculateByte(){} // RVA: 0xA24BFF0
        public void ProcessBlock(){} // RVA: 0xA24C130
        public void Reset(){} // RVA: 0xA24C460
        public void incrementCounterAt(){} // RVA: 0xA24C4F0
        public void checkCounter(){} // RVA: 0xB43310
    }

    public class OcbBlockCipher : Object
    {
        public object BLOCK_SIZE;
        public object hashCipher;
        public object mainCipher;
        public object forEncryption;
        public object macSize;
        public object initialAssociatedText;
        public object L;
        public object L_Asterisk;
        public object L_Dollar;
        public object KtopInput;
        public object Stretch;
        public object OffsetMAIN_0;
        public object hashBlock;
        public object mainBlock;
        public object hashBlockPos;
        public object mainBlockPos;
        public object hashBlockCount;
        public object mainBlockCount;
        public object OffsetHASH;
        public object Sum;
        public object OffsetMAIN;
        public object Checksum;
        public object macBlock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA24C550
        public void GetUnderlyingCipher(){} // RVA: 0xB465B0
        public void get_AlgorithmName(){} // RVA: 0xA24C990
        public void Init(){} // RVA: 0xA24CA00
        public void ProcessNonce(){} // RVA: 0xA24D3D0
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void GetMac(){} // RVA: 0xA24D690
        public void GetOutputSize(){} // RVA: 0xA24D770
        public void GetUpdateOutputSize(){} // RVA: 0xA24D7A0
        public void ProcessAadByte(){} // RVA: 0xA24D7D0
        public void ProcessAadBytes(){} // RVA: 0xA24D830
        public void ProcessByte(){} // RVA: 0xA24D8F0
        public void ProcessBytes(){} // RVA: 0xA24D970
        public void DoFinal(){} // RVA: 0xA24DA70
        public void Reset(){} // RVA: 0xA24EA50
        public void Clear(){} // RVA: 0xA24E250
        public void GetLSub(){} // RVA: 0xA24E270
        public void ProcessHashBlock(){} // RVA: 0xA24E680
        public void ProcessMainBlock(){} // RVA: 0xA24E6F0
        public void UpdateHASH(){} // RVA: 0xA24EC20
        public void OCB_double(){} // RVA: 0xA24EDB0
        public void OCB_extend(){} // RVA: 0xA24EE70
        public void OCB_ntz(){} // RVA: 0xA24EED0
        public void ShiftLeft(){} // RVA: 0xA24EF00
        public void Xor(){} // RVA: 0xA24EF70
    }

    public class OfbBlockCipher : Object
    {
        public object IV;
        public object ofbV;
        public object ofbOutV;
        public object blockSize;
        public object cipher;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA24EFD0
        public void GetUnderlyingCipher(){} // RVA: 0xD33E60
        public void Init(){} // RVA: 0xA24F230
        public void get_AlgorithmName(){} // RVA: 0xA24F450
        public void get_IsPartialBlockOkay(){} // RVA: 0xC2E4C0
        public void GetBlockSize(){} // RVA: 0x1065D50
        public void ProcessBlock(){} // RVA: 0xA24F560
        public void Reset(){} // RVA: 0xA24F790
    }

    public class OpenPgpCfbBlockCipher : Object
    {
        public object IV;
        public object FR;
        public object FRE;
        public object cipher;
        public object blockSize;
        public object count;
        public object forEncryption;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA24F810
        public void GetUnderlyingCipher(){} // RVA: 0xB70160
        public void get_AlgorithmName(){} // RVA: 0xA24FA00
        public void get_IsPartialBlockOkay(){} // RVA: 0xC2E4C0
        public void GetBlockSize(){} // RVA: 0xA24FA70
        public void ProcessBlock(){} // RVA: 0xA24FAC0
        public void Reset(){} // RVA: 0xA24FAF0
        public void Init(){} // RVA: 0xA24FB70
        public void EncryptByte(){} // RVA: 0xA24FD90
        public void EncryptBlock(){} // RVA: 0xA24FDC0
        public void DecryptBlock(){} // RVA: 0xA250350
    }

    public class SicBlockCipher : Object
    {
        public object cipher;
        public object blockSize;
        public object counter;
        public object counterOut;
        public object IV;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA250900
        public void GetUnderlyingCipher(){} // RVA: 0xB5DBF0
        public void Init(){} // RVA: 0xA250AF0
        public void get_AlgorithmName(){} // RVA: 0xA250E90
        public void get_IsPartialBlockOkay(){} // RVA: 0xC2E4C0
        public void GetBlockSize(){} // RVA: 0xA250F00
        public void ProcessBlock(){} // RVA: 0xA250F50
        public void Reset(){} // RVA: 0xA2510D0
    }

}