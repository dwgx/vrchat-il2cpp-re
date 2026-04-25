// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
// Classes: 14
// Methods: 202

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
    public class CbcBlockCipher : Object
    {
        public byte[] AlgorithmName; // 0x10
        public byte[] IsPartialBlockOkay; // 0x18
        public byte[] cbcNextV; // 0x20
        public int blockSize; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x30
        public bool encrypting; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA6A10
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC31D95E0
        public void Init(){} // RVA: 0x7FFACBBA6C00
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBA6E60
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFACBBA6ED0
        public void ProcessBlock(){} // RVA: 0x7FFACBBA6F20
        public void Reset(){} // RVA: 0x7FFACBBA70C0
        public void EncryptBlock(){} // RVA: 0x7FFACBBA7160
        public void DecryptBlock(){} // RVA: 0x7FFACBBA72D0
    }

    public class CcmBlockCipher : Object
    {
        public int AlgorithmName;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x10
        public byte[] macBlock; // 0x18
        public bool forEncryption; // 0x20
        public byte[] nonce; // 0x28
        public byte[] initialAssociatedText; // 0x30
        public int macSize; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters keyParam; // 0x40
        public System.IO.MemoryStream associatedText; // 0x48
        public System.IO.MemoryStream data; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA74F0
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2F3C380
        public void Init(){} // RVA: 0x7FFACBBA7830
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBA7C60
        public void GetBlockSize(){} // RVA: 0x7FFACBBA7CD0
        public void ProcessAadByte(){} // RVA: 0x7FFACBBA7D20
        public void ProcessAadBytes(){} // RVA: 0x7FFAC94653B0
        public void ProcessByte(){} // RVA: 0x7FFACBBA7D50
        public void ProcessBytes(){} // RVA: 0x7FFACBBA7D80
        public void DoFinal(){} // RVA: 0x7FFACBBA7E70
        public void Reset(){} // RVA: 0x7FFACBBA7F40
        public void GetMac(){} // RVA: 0x7FFACBBA7FD0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAC34F9180
        public void GetOutputSize(){} // RVA: 0x7FFACBBA8040
        public void ProcessPacket(){} // RVA: 0x7FFACBBA81C0 | overloaded x2
        public void CalculateMac(){} // RVA: 0x7FFACBBA8B30
        public void GetAssociatedTextLength(){} // RVA: 0x7FFACBBA9060
        public void HasAssociatedText(){} // RVA: 0x7FFACBBA90B0
        public void .cctor(){} // RVA: 0x7FFACBBA9110
    }

    public class CfbBlockCipher : Object
    {
        public byte[] AlgorithmName; // 0x10
        public byte[] IsPartialBlockOkay; // 0x18
        public byte[] cfbOutV; // 0x20
        public bool encrypting; // 0x28
        public int blockSize; // 0x2C
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA9150
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC31D95E0
        public void Init(){} // RVA: 0x7FFACBBA93B0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBA9570
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC3006850
        public void GetBlockSize(){} // RVA: 0x7FFAC3C891D0
        public void ProcessBlock(){} // RVA: 0x7FFACBBA9680
        public void EncryptBlock(){} // RVA: 0x7FFACBBA96B0
        public void DecryptBlock(){} // RVA: 0x7FFACBBA98E0
        public void Reset(){} // RVA: 0x7FFACBBA9B00
    }

    public class CtsBlockCipher : BufferedBlockCipher
    {
        public int blockSize; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBA9B80
        public void GetUpdateOutputSize(){} // RVA: 0x7FFACBBA0FB0
        public void GetOutputSize(){} // RVA: 0x7FFACBB135A0
        public void ProcessByte(){} // RVA: 0x7FFACBBA9DC0
        public void ProcessBytes(){} // RVA: 0x7FFACBBA9EC0
        public void DoFinal(){} // RVA: 0x7FFACBBAA1F0
    }

    public class EaxBlockCipher : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.SicBlockCipher AlgorithmName; // 0x10
        public bool forEncryption; // 0x18
        public int blockSize; // 0x1C
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac mac; // 0x20
        public byte[] nonceMac; // 0x28
        public byte[] associatedTextMac; // 0x30
        public byte[] macBlock; // 0x38
        public int macSize; // 0x40
        public byte[] bufBlock; // 0x48
        public int bufOff; // 0x50
        public bool cipherInitialized; // 0x54
        public byte[] initialAssociatedText; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBAA6E0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBAAA30
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2F3C380
        public void GetBlockSize(){} // RVA: 0x7FFAC8D711F0
        public void Init(){} // RVA: 0x7FFACBBAAAC0
        public void InitCipher(){} // RVA: 0x7FFACBBAAF90
        public void CalculateMac(){} // RVA: 0x7FFACBBAB060
        public void Reset(){} // RVA: 0x7FFACBBAB190 | overloaded x2
        public void ProcessAadByte(){} // RVA: 0x7FFACBBAB300
        public void ProcessAadBytes(){} // RVA: 0x7FFACBBAB3B0
        public void ProcessByte(){} // RVA: 0x7FFACBBAB480
        public void ProcessBytes(){} // RVA: 0x7FFACBBAB4E0
        public void DoFinal(){} // RVA: 0x7FFACBBAB590
        public void GetMac(){} // RVA: 0x7FFACBBAB990
        public void GetUpdateOutputSize(){} // RVA: 0x7FFACBBABA00
        public void GetOutputSize(){} // RVA: 0x7FFACBBABA30
        public void Process(){} // RVA: 0x7FFACBBABA60
        public void VerifyMac(){} // RVA: 0x7FFACBBABC80
    }

    public class GOfbBlockCipher : Object
    {
        public byte[] AlgorithmName; // 0x10
        public byte[] IsPartialBlockOkay; // 0x18
        public byte[] ofbOutV; // 0x20
        public int blockSize; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x30
        public bool firstStep; // 0x38
        public int N3; // 0x3C
        public int N4; // 0x40
        public int C1;
        public int C2;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBAF160
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC31D95E0
        public void Init(){} // RVA: 0x7FFACBBAF3F0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBAF620
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC3006850
        public void GetBlockSize(){} // RVA: 0x7FFAC32EC4C0
        public void ProcessBlock(){} // RVA: 0x7FFACBBAF690
        public void Reset(){} // RVA: 0x7FFACBBAFA30
        public void bytesToint(){} // RVA: 0x7FFACBBAFAB0
        public void intTobytes(){} // RVA: 0x7FFACBBAFB20
    }

    public class GcmBlockCipher : Object
    {
        public int AlgorithmName;
        public byte[] ctrBlock; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.Gcm.IGcmMultiplier multiplier; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.Gcm.IGcmExponentiator exp; // 0x28
        public bool forEncryption; // 0x30
        public bool initialised; // 0x31
        public int macSize; // 0x34
        public byte[] lastKey; // 0x38
        public byte[] nonce; // 0x40
        public byte[] initialAssociatedText; // 0x48
        public byte[] H; // 0x50
        public byte[] J0; // 0x58
        public byte[] bufBlock; // 0x60
        public byte[] macBlock; // 0x68
        public byte[] S; // 0x70
        public byte[] S_at; // 0x78
        public byte[] S_atPre; // 0x80
        public byte[] counter; // 0x88
        public uint blocksRemaining; // 0x90
        public int bufOff; // 0x94
        public ulong totalLength; // 0x98
        public byte[] atBlock; // 0xA0
        public int atBlockPos; // 0xA8
        public ulong atLength; // 0xB0
        public ulong atLengthPre; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBABD10 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBAC000
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2F247C0
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void Init(){} // RVA: 0x7FFACBBAC070
        public void GetMac(){} // RVA: 0x7FFACBBACBD0
        public void GetOutputSize(){} // RVA: 0x7FFACBBACCB0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFACBBACCE0
        public void ProcessAadByte(){} // RVA: 0x7FFACBBACD10
        public void ProcessAadBytes(){} // RVA: 0x7FFACBBACDA0
        public void InitCipher(){} // RVA: 0x7FFACBBACE80
        public void ProcessByte(){} // RVA: 0x7FFACBBAD010
        public void ProcessBytes(){} // RVA: 0x7FFACBBAD0F0
        public void DoFinal(){} // RVA: 0x7FFACBBAD3C0
        public void Reset(){} // RVA: 0x7FFACBBADE60 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x7FFACBBAE280
        public void ProcessPartial(){} // RVA: 0x7FFACBBAE710
        public void gHASH(){} // RVA: 0x7FFACBBAEA10
        public void gHASHBlock(){} // RVA: 0x7FFACBBAECC0 | overloaded x2
        public void gHASHPartial(){} // RVA: 0x7FFACBBAEE20
        public void GetNextCtrBlock(){} // RVA: 0x7FFACBBAEF10
        public void CheckStatus(){} // RVA: 0x7FFACBBAF0B0
    }

    public class IAeadBlockCipher
    {
        public object AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAC2C58E90
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2C58E90
        public void Init(){} // RVA: 0x7FFAC2C71580
        public void GetBlockSize(){} // RVA: 0x7FFAC2C59960
        public void ProcessAadByte(){} // RVA: 0x7FFAC2C71060
        public void ProcessAadBytes(){}
        public void ProcessByte(){}
        public void ProcessBytes(){}
        public void DoFinal(){}
        public void GetMac(){} // RVA: 0x7FFAC2C58E90
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAC2C600D0
        public void GetOutputSize(){} // RVA: 0x7FFAC2C600D0
        public void Reset(){} // RVA: 0x7FFAC2C70980
    }

    public class KCcmBlockCipher : Object
    {
        public int AlgorithmName;
        public int BITS_IN_BYTE; // 0x4
        public int MAX_MAC_BIT_LENGTH; // 0x8
        public int MIN_MAC_BIT_LENGTH; // 0xC
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher engine; // 0x10
        public int macSize; // 0x18
        public bool forEncryption; // 0x1C
        public byte[] initialAssociatedText; // 0x20
        public byte[] mac; // 0x28
        public byte[] macBlock; // 0x30
        public byte[] nonce; // 0x38
        public byte[] G1; // 0x40
        public byte[] buffer; // 0x48
        public byte[] s; // 0x50
        public byte[] counter; // 0x58
        public System.IO.MemoryStream associatedText; // 0x60
        public System.IO.MemoryStream data; // 0x68
        public int Nb_; // 0x70

        // ── Methods ──
        public void setNb(){} // RVA: 0x7FFACBBAFB90
        public void .ctor(){} // RVA: 0x7FFACBBAFC10 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBBB01C0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBB0700
        public void GetBlockSize(){} // RVA: 0x7FFACBBB0770
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2F3C380
        public void ProcessAadByte(){} // RVA: 0x7FFACBBB07C0
        public void ProcessAadBytes(){} // RVA: 0x7FFACBBB07F0
        public void ProcessAAD(){} // RVA: 0x7FFACBBB0820
        public void ProcessByte(){} // RVA: 0x7FFACBBB0EF0
        public void ProcessBytes(){} // RVA: 0x7FFACBBB0F20
        public void ProcessPacket(){} // RVA: 0x7FFACBBB1010
        public void ProcessBlock(){} // RVA: 0x7FFACBBB1CD0
        public void CalculateMac(){} // RVA: 0x7FFACBBB1F50
        public void DoFinal(){} // RVA: 0x7FFACBBB20A0
        public void GetMac(){} // RVA: 0x7FFACBBB2160
        public void GetUpdateOutputSize(){} // RVA: 0x7FFAC5DEA830
        public void GetOutputSize(){} // RVA: 0x7FFACBB135A0
        public void Reset(){} // RVA: 0x7FFACBBB2210
        public void intToBytes(){} // RVA: 0x7FFACBBAFB20
        public void getFlag(){} // RVA: 0x7FFACBBB23C0
        public void .cctor(){} // RVA: 0x7FFACBBB26C0
    }

    public class KCtrBlockCipher : Object
    {
        public byte[] AlgorithmName; // 0x10
        public byte[] IsPartialBlockOkay; // 0x18
        public byte[] ofbOutV; // 0x20
        public bool initialised; // 0x28
        public int byteCount; // 0x2C
        public int blockSize; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBB2740
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC31D0140
        public void Init(){} // RVA: 0x7FFACBBB2970
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBB2BA0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC3006850
        public void GetBlockSize(){} // RVA: 0x7FFACBBB2C10
        public void ReturnByte(){} // RVA: 0x7FFACBBB2C60
        public void ProcessBytes(){} // RVA: 0x7FFACBBB2C70
        public void CalculateByte(){} // RVA: 0x7FFACBBB2DD0
        public void ProcessBlock(){} // RVA: 0x7FFACBBB2F10
        public void Reset(){} // RVA: 0x7FFACBBB3210
        public void incrementCounterAt(){} // RVA: 0x7FFACBBB32A0
        public void checkCounter(){} // RVA: 0x7FFAC2F21310
    }

    public class OcbBlockCipher : Object
    {
        public int AlgorithmName;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher hashCipher; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher mainCipher; // 0x18
        public bool forEncryption; // 0x20
        public int macSize; // 0x24
        public byte[] initialAssociatedText; // 0x28
        public System.Collections.IList L; // 0x30
        public byte[] L_Asterisk; // 0x38
        public byte[] L_Dollar; // 0x40
        public byte[] KtopInput; // 0x48
        public byte[] Stretch; // 0x50
        public byte[] OffsetMAIN_0; // 0x58
        public byte[] hashBlock; // 0x60
        public byte[] mainBlock; // 0x68
        public int hashBlockPos; // 0x70
        public int mainBlockPos; // 0x74
        public long hashBlockCount; // 0x78
        public long mainBlockCount; // 0x80
        public byte[] OffsetHASH; // 0x88
        public byte[] Sum; // 0x90
        public byte[] OffsetMAIN; // 0x98
        public byte[] Checksum; // 0xA0
        public byte[] macBlock; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBB3300
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2F247C0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBB3740
        public void Init(){} // RVA: 0x7FFACBBB37B0
        public void ProcessNonce(){} // RVA: 0x7FFACBBB4150
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void GetMac(){} // RVA: 0x7FFACBBB4410
        public void GetOutputSize(){} // RVA: 0x7FFACBBB44F0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFACBBB4520
        public void ProcessAadByte(){} // RVA: 0x7FFACBBB4550
        public void ProcessAadBytes(){} // RVA: 0x7FFACBBB45B0
        public void ProcessByte(){} // RVA: 0x7FFACBBB4670
        public void ProcessBytes(){} // RVA: 0x7FFACBBB46F0
        public void DoFinal(){} // RVA: 0x7FFACBBB47D0
        public void Reset(){} // RVA: 0x7FFACBBB5620 | overloaded x2
        public void Clear(){} // RVA: 0x7FFACBBB4F20
        public void GetLSub(){} // RVA: 0x7FFACBBB4F40
        public void ProcessHashBlock(){} // RVA: 0x7FFACBBB5280
        public void ProcessMainBlock(){} // RVA: 0x7FFACBBB52F0
        public void UpdateHASH(){} // RVA: 0x7FFACBBB57F0
        public void OCB_double(){} // RVA: 0x7FFACBBB5950
        public void OCB_extend(){} // RVA: 0x7FFACBBB5A20
        public void OCB_ntz(){} // RVA: 0x7FFACBBB5A70
        public void ShiftLeft(){} // RVA: 0x7FFACBBB5AA0
        public void Xor(){} // RVA: 0x7FFACBBB5B10
    }

    public class OfbBlockCipher : Object
    {
        public byte[] AlgorithmName; // 0x10
        public byte[] IsPartialBlockOkay; // 0x18
        public byte[] ofbOutV; // 0x20
        public int blockSize; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBB5B70
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC31D95E0
        public void Init(){} // RVA: 0x7FFACBBB5DD0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBB6000
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC3006850
        public void GetBlockSize(){} // RVA: 0x7FFAC32EC4C0
        public void ProcessBlock(){} // RVA: 0x7FFACBBB6110
        public void Reset(){} // RVA: 0x7FFACBBB6340
    }

    public class OpenPgpCfbBlockCipher : Object
    {
        public byte[] AlgorithmName; // 0x10
        public byte[] IsPartialBlockOkay; // 0x18
        public byte[] FRE; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x28
        public int blockSize; // 0x30
        public int count; // 0x34
        public bool forEncryption; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBB63C0
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2F4F130
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBB65B0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC3006850
        public void GetBlockSize(){} // RVA: 0x7FFACBBB6620
        public void ProcessBlock(){} // RVA: 0x7FFACBBB6670
        public void Reset(){} // RVA: 0x7FFACBBB66A0
        public void Init(){} // RVA: 0x7FFACBBB6720
        public void EncryptByte(){} // RVA: 0x7FFACBBB6940
        public void EncryptBlock(){} // RVA: 0x7FFACBBB6970
        public void DecryptBlock(){} // RVA: 0x7FFACBBB6ED0
    }

    public class SicBlockCipher : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher AlgorithmName; // 0x10
        public int IsPartialBlockOkay; // 0x18
        public byte[] counter; // 0x20
        public byte[] counterOut; // 0x28
        public byte[] IV; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBB7480
        public void GetUnderlyingCipher(){} // RVA: 0x7FFAC2F3C380
        public void Init(){} // RVA: 0x7FFACBBB7670
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBB7A20
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC3006850
        public void GetBlockSize(){} // RVA: 0x7FFACBBB7A90
        public void ProcessBlock(){} // RVA: 0x7FFACBBB7AE0
        public void Reset(){} // RVA: 0x7FFACBBB7C50
    }

}