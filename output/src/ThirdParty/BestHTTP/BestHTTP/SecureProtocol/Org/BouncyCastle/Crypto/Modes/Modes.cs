// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
// Classes: 14
// Methods: 202

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes
{
    public class CbcBlockCipher : Object
    {
        public byte[] IV; // 0x10
        public byte[] cbcV; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A000030
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE8144E200
        public void Init(){} // RVA: 0x7FFE8A000220
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A000480
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE8A0004F0
        public void ProcessBlock(){} // RVA: 0x7FFE8A000540
        public void Reset(){} // RVA: 0x7FFE8A0006E0
        public void EncryptBlock(){} // RVA: 0x7FFE8A000780
        public void DecryptBlock(){} // RVA: 0x7FFE8A0008F0
    }

    public class CcmBlockCipher : Object
    {
        public int BlockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A000B10
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE81116380
        public void Init(){} // RVA: 0x7FFE8A000E50
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A001280
        public void GetBlockSize(){} // RVA: 0x7FFE8A0012F0
        public void ProcessAadByte(){} // RVA: 0x7FFE8A001340
        public void ProcessAadBytes(){} // RVA: 0x7FFE8780DAF0
        public void ProcessByte(){} // RVA: 0x7FFE8A001370
        public void ProcessBytes(){} // RVA: 0x7FFE8A0013A0
        public void DoFinal(){} // RVA: 0x7FFE8A001490
        public void Reset(){} // RVA: 0x7FFE8A001560
        public void GetMac(){} // RVA: 0x7FFE8A0015F0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE813240E0
        public void GetOutputSize(){} // RVA: 0x7FFE8A001660
        public void ProcessPacket(){} // RVA: 0x7FFE8A0017E0 | overloaded x2
        public void CalculateMac(){} // RVA: 0x7FFE8A002150
        public void GetAssociatedTextLength(){} // RVA: 0x7FFE8A002680
        public void HasAssociatedText(){} // RVA: 0x7FFE8A0026D0
        public void .cctor(){} // RVA: 0x7FFE8A002730
    }

    public class CfbBlockCipher : Object
    {
        public byte[] IV; // 0x10
        public byte[] cfbV; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A002770
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE8144E200
        public void Init(){} // RVA: 0x7FFE8A0029D0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A002B90
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE811E0850
        public void GetBlockSize(){} // RVA: 0x7FFE81F84A50
        public void ProcessBlock(){} // RVA: 0x7FFE8A002CA0
        public void EncryptBlock(){} // RVA: 0x7FFE8A002CD0
        public void DecryptBlock(){} // RVA: 0x7FFE8A002F00
        public void Reset(){} // RVA: 0x7FFE8A003120
    }

    public class CtsBlockCipher : BufferedBlockCipher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0031A0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE89FFA5D0
        public void GetOutputSize(){} // RVA: 0x7FFE89F6CBC0
        public void ProcessByte(){} // RVA: 0x7FFE8A0033E0
        public void ProcessBytes(){} // RVA: 0x7FFE8A0034E0
        public void DoFinal(){} // RVA: 0x7FFE8A003810
    }

    public class EaxBlockCipher : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.SicBlockCipher cipher; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A003D00
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A004050
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE81116380
        public void GetBlockSize(){} // RVA: 0x7FFE81588880
        public void Init(){} // RVA: 0x7FFE8A0040E0
        public void InitCipher(){} // RVA: 0x7FFE8A0045B0
        public void CalculateMac(){} // RVA: 0x7FFE8A004680
        public void Reset(){} // RVA: 0x7FFE8A0047B0 | overloaded x2
        public void ProcessAadByte(){} // RVA: 0x7FFE8A004920
        public void ProcessAadBytes(){} // RVA: 0x7FFE8A0049D0
        public void ProcessByte(){} // RVA: 0x7FFE8A004AA0
        public void ProcessBytes(){} // RVA: 0x7FFE8A004B00
        public void DoFinal(){} // RVA: 0x7FFE8A004BB0
        public void GetMac(){} // RVA: 0x7FFE8A004FB0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE8A005020
        public void GetOutputSize(){} // RVA: 0x7FFE8A005050
        public void Process(){} // RVA: 0x7FFE8A005080
        public void VerifyMac(){} // RVA: 0x7FFE8A0052A0
    }

    public class GOfbBlockCipher : Object
    {
        public byte[] IV; // 0x10
        public byte[] ofbV; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A008780
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE8144E200
        public void Init(){} // RVA: 0x7FFE8A008A10
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A008C40
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE811E0850
        public void GetBlockSize(){} // RVA: 0x7FFE81549710
        public void ProcessBlock(){} // RVA: 0x7FFE8A008CB0
        public void Reset(){} // RVA: 0x7FFE8A009050
        public void bytesToint(){} // RVA: 0x7FFE8A0090D0
        public void intTobytes(){} // RVA: 0x7FFE8A009140
    }

    public class GcmBlockCipher : Object
    {
        public int BlockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A005330 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A005620
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE810FE7C0
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void Init(){} // RVA: 0x7FFE8A005690
        public void GetMac(){} // RVA: 0x7FFE8A0061F0
        public void GetOutputSize(){} // RVA: 0x7FFE8A0062D0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE8A006300
        public void ProcessAadByte(){} // RVA: 0x7FFE8A006330
        public void ProcessAadBytes(){} // RVA: 0x7FFE8A0063C0
        public void InitCipher(){} // RVA: 0x7FFE8A0064A0
        public void ProcessByte(){} // RVA: 0x7FFE8A006630
        public void ProcessBytes(){} // RVA: 0x7FFE8A006710
        public void DoFinal(){} // RVA: 0x7FFE8A0069E0
        public void Reset(){} // RVA: 0x7FFE8A007480 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x7FFE8A0078A0
        public void ProcessPartial(){} // RVA: 0x7FFE8A007D30
        public void gHASH(){} // RVA: 0x7FFE8A008030
        public void gHASHBlock(){} // RVA: 0x7FFE8A0082E0 | overloaded x2
        public void gHASHPartial(){} // RVA: 0x7FFE8A008440
        public void GetNextCtrBlock(){} // RVA: 0x7FFE8A008530
        public void CheckStatus(){} // RVA: 0x7FFE8A0086D0
    }

    public class IAeadBlockCipher
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE80E2E2E0
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE80E2E2E0
        public void Init(){} // RVA: 0x7FFE80E46BE0
        public void GetBlockSize(){} // RVA: 0x7FFE80E2EDB0
        public void ProcessAadByte(){} // RVA: 0x7FFE80E466C0
        public void ProcessAadBytes(){}
        public void ProcessByte(){}
        public void ProcessBytes(){}
        public void DoFinal(){}
        public void GetMac(){} // RVA: 0x7FFE80E2E2E0
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE80E35520
        public void GetOutputSize(){} // RVA: 0x7FFE80E35520
        public void Reset(){} // RVA: 0x7FFE80E45FE0
    }

    public class KCcmBlockCipher : Object
    {
        public int BYTES_IN_INT;

        // ── Methods ──
        public void setNb(){} // RVA: 0x7FFE8A0091B0
        public void .ctor(){} // RVA: 0x7FFE8A009230 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8A0097E0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A009D20
        public void GetBlockSize(){} // RVA: 0x7FFE8A009D90
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE81116380
        public void ProcessAadByte(){} // RVA: 0x7FFE8A009DE0
        public void ProcessAadBytes(){} // RVA: 0x7FFE8A009E10
        public void ProcessAAD(){} // RVA: 0x7FFE8A009E40
        public void ProcessByte(){} // RVA: 0x7FFE8A00A510
        public void ProcessBytes(){} // RVA: 0x7FFE8A00A540
        public void ProcessPacket(){} // RVA: 0x7FFE8A00A630
        public void ProcessBlock(){} // RVA: 0x7FFE8A00B2F0
        public void CalculateMac(){} // RVA: 0x7FFE8A00B570
        public void DoFinal(){} // RVA: 0x7FFE8A00B6C0
        public void GetMac(){} // RVA: 0x7FFE8A00B780
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE8481AF30
        public void GetOutputSize(){} // RVA: 0x7FFE89F6CBC0
        public void Reset(){} // RVA: 0x7FFE8A00B830
        public void intToBytes(){} // RVA: 0x7FFE8A009140
        public void getFlag(){} // RVA: 0x7FFE8A00B9E0
        public void .cctor(){} // RVA: 0x7FFE8A00BCE0
    }

    public class KCtrBlockCipher : Object
    {
        public byte[] IV; // 0x10
        public byte[] ofbV; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A00BD60
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE8143BA80
        public void Init(){} // RVA: 0x7FFE8A00BF90
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A00C1C0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE811E0850
        public void GetBlockSize(){} // RVA: 0x7FFE8A00C230
        public void ReturnByte(){} // RVA: 0x7FFE8A00C280
        public void ProcessBytes(){} // RVA: 0x7FFE8A00C290
        public void CalculateByte(){} // RVA: 0x7FFE8A00C3F0
        public void ProcessBlock(){} // RVA: 0x7FFE8A00C530
        public void Reset(){} // RVA: 0x7FFE8A00C830
        public void incrementCounterAt(){} // RVA: 0x7FFE8A00C8C0
        public void checkCounter(){} // RVA: 0x7FFE810FB310
    }

    public class OcbBlockCipher : Object
    {
        public int BLOCK_SIZE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A00C920
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE810FE7C0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A00CD60
        public void Init(){} // RVA: 0x7FFE8A00CDD0
        public void ProcessNonce(){} // RVA: 0x7FFE8A00D770
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void GetMac(){} // RVA: 0x7FFE8A00DA30
        public void GetOutputSize(){} // RVA: 0x7FFE8A00DB10
        public void GetUpdateOutputSize(){} // RVA: 0x7FFE8A00DB40
        public void ProcessAadByte(){} // RVA: 0x7FFE8A00DB70
        public void ProcessAadBytes(){} // RVA: 0x7FFE8A00DBD0
        public void ProcessByte(){} // RVA: 0x7FFE8A00DC90
        public void ProcessBytes(){} // RVA: 0x7FFE8A00DD10
        public void DoFinal(){} // RVA: 0x7FFE8A00DDF0
        public void Reset(){} // RVA: 0x7FFE8A00EC40 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE8A00E540
        public void GetLSub(){} // RVA: 0x7FFE8A00E560
        public void ProcessHashBlock(){} // RVA: 0x7FFE8A00E8A0
        public void ProcessMainBlock(){} // RVA: 0x7FFE8A00E910
        public void UpdateHASH(){} // RVA: 0x7FFE8A00EE10
        public void OCB_double(){} // RVA: 0x7FFE8A00EF70
        public void OCB_extend(){} // RVA: 0x7FFE8A00F040
        public void OCB_ntz(){} // RVA: 0x7FFE8A00F090
        public void ShiftLeft(){} // RVA: 0x7FFE8A00F0C0
        public void Xor(){} // RVA: 0x7FFE8A00F130
    }

    public class OfbBlockCipher : Object
    {
        public byte[] IV; // 0x10
        public byte[] ofbV; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A00F190
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE8144E200
        public void Init(){} // RVA: 0x7FFE8A00F3F0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A00F620
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE811E0850
        public void GetBlockSize(){} // RVA: 0x7FFE81549710
        public void ProcessBlock(){} // RVA: 0x7FFE8A00F730
        public void Reset(){} // RVA: 0x7FFE8A00F960
    }

    public class OpenPgpCfbBlockCipher : Object
    {
        public byte[] IV; // 0x10
        public byte[] FR; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A00F9E0
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE81129130
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A00FBD0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE811E0850
        public void GetBlockSize(){} // RVA: 0x7FFE8A00FC40
        public void ProcessBlock(){} // RVA: 0x7FFE8A00FC90
        public void Reset(){} // RVA: 0x7FFE8A00FCC0
        public void Init(){} // RVA: 0x7FFE8A00FD40
        public void EncryptByte(){} // RVA: 0x7FFE8A00FF60
        public void EncryptBlock(){} // RVA: 0x7FFE8A00FF90
        public void DecryptBlock(){} // RVA: 0x7FFE8A0104F0
    }

    public class SicBlockCipher : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher cipher; // 0x10
        public int blockSize; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A010AA0
        public void GetUnderlyingCipher(){} // RVA: 0x7FFE81116380
        public void Init(){} // RVA: 0x7FFE8A010C90
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A011040
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE811E0850
        public void GetBlockSize(){} // RVA: 0x7FFE8A0110B0
        public void ProcessBlock(){} // RVA: 0x7FFE8A011100
        public void Reset(){} // RVA: 0x7FFE8A011270
    }

}