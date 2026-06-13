// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
// Classes: 56
// Methods: 673

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
    public class AesEngine
    {
        public byte[] S;
        public byte[] Si; // 0x8

        // ── Methods ──
        public void Shift(){} // RVA: 0x5C98C70
        public void FFmulX(){} // RVA: 0x95E6880
        public void FFmulX2(){} // RVA: 0x95E68A0
        public void Inv_Mcol(){} // RVA: 0x95E68D0
        public void SubWord(){} // RVA: 0x95E6990
        public void GenerateWorkingKey(){} // RVA: 0x95E6A70
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x95E7DC0
        public void get_AlgorithmName(){} // RVA: 0x95E8090
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void ProcessBlock(){} // RVA: 0x95E80D0
        public void Reset(){} // RVA: 0x2DD310
        public void UnPackBlock(){} // RVA: 0x95E82A0
        public void PackBlock(){} // RVA: 0x95E8460
        public void EncryptBlock(){} // RVA: 0x95E8600
        public void DecryptBlock(){} // RVA: 0x95E93F0
        public void .cctor(){} // RVA: 0x95EA1B0
    }

    public class AesFastEngine
    {
        public byte[] S;
        public byte[] Si; // 0x8

        // ── Methods ──
        public void Shift(){} // RVA: 0x5C98C70
        public void FFmulX(){} // RVA: 0x95E6880
        public void FFmulX2(){} // RVA: 0x95E68A0
        public void Inv_Mcol(){} // RVA: 0x95EA540
        public void SubWord(){} // RVA: 0x95EA600
        public void GenerateWorkingKey(){} // RVA: 0x95EA6E0
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x95EBA30
        public void get_AlgorithmName(){} // RVA: 0x95EBBB0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void ProcessBlock(){} // RVA: 0x95EBBF0
        public void Reset(){} // RVA: 0x2DD310
        public void UnPackBlock(){} // RVA: 0x95E82A0
        public void PackBlock(){} // RVA: 0x95E8460
        public void EncryptBlock(){} // RVA: 0x95EBDC0
        public void DecryptBlock(){} // RVA: 0x95EC9D0
        public void .cctor(){} // RVA: 0x95ED5E0
    }

    public class AesLightEngine
    {
        public byte[] S;
        public byte[] Si; // 0x8

        // ── Methods ──
        public void Shift(){} // RVA: 0x5C98C70
        public void FFmulX(){} // RVA: 0x95E6880
        public void FFmulX2(){} // RVA: 0x95E68A0
        public void Mcol(){} // RVA: 0x95EDD30
        public void Inv_Mcol(){} // RVA: 0x95EDDC0
        public void SubWord(){} // RVA: 0x95EDE80
        public void GenerateWorkingKey(){} // RVA: 0x95EDF60
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x95EF2B0
        public void get_AlgorithmName(){} // RVA: 0x95EF430
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void ProcessBlock(){} // RVA: 0x95EF470
        public void Reset(){} // RVA: 0x2DD310
        public void UnPackBlock(){} // RVA: 0x95E82A0
        public void PackBlock(){} // RVA: 0x95E8460
        public void EncryptBlock(){} // RVA: 0x95EF640
        public void DecryptBlock(){} // RVA: 0x95F0890
        public void .cctor(){} // RVA: 0x95F1570
    }

    public class AesWrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95F17B0
    }

    public class BlowfishEngine
    {
        public uint[] KP;
        public uint[] KS0; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95F1800
        public void Init(){} // RVA: 0x95F1AA0
        public void get_AlgorithmName(){} // RVA: 0x95F1C50
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void ProcessBlock(){} // RVA: 0x95F1C90
        public void Reset(){} // RVA: 0x2DD310
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void F(){} // RVA: 0x95F1E50
        public void ProcessTable(){} // RVA: 0x95F1EE0
        public void SetKey(){} // RVA: 0x95F2090
        public void EncryptBlock(){} // RVA: 0x95F2430
        public void DecryptBlock(){} // RVA: 0x95F27F0
        public void .cctor(){} // RVA: 0x95F2BB0
    }

    public class CamelliaEngine
    {
        public bool initialised; // 0x10
        public bool _keyIs128; // 0x11

        // ── Methods ──
        public void rightRotate(){} // RVA: 0x95F2F70
        public void leftRotate(){} // RVA: 0x95F2F90
        public void roldq(){} // RVA: 0x95F2FB0
        public void decroldq(){} // RVA: 0x95F3170
        public void roldqo32(){} // RVA: 0x95F3340
        public void decroldqo32(){} // RVA: 0x95F3500
        public void bytes2uint(){} // RVA: 0x95F36D0
        public void uint2bytes(){} // RVA: 0x95F3720
        public void camelliaF2(){} // RVA: 0x95F3760
        public void camelliaFLs(){} // RVA: 0x95F3B10
        public void setKey(){} // RVA: 0x95F3C30
        public void processBlock128(){} // RVA: 0x95F52D0
        public void processBlock192or256(){} // RVA: 0x95F5800
        public void .ctor(){} // RVA: 0x95F5D80
        public void Init(){} // RVA: 0x95F5F50
        public void get_AlgorithmName(){} // RVA: 0x95F6070
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void ProcessBlock(){} // RVA: 0x95F60B0
        public void Reset(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x95F6260
    }

    public class CamelliaLightEngine
    {
        public int BLOCK_SIZE;
        public bool initialised; // 0x10

        // ── Methods ──
        public void rightRotate(){} // RVA: 0x95F2F70
        public void leftRotate(){} // RVA: 0x95F2F90
        public void roldq(){} // RVA: 0x95F2FB0
        public void decroldq(){} // RVA: 0x95F3170
        public void roldqo32(){} // RVA: 0x95F3340
        public void decroldqo32(){} // RVA: 0x95F3500
        public void bytes2uint(){} // RVA: 0x95F36D0
        public void uint2bytes(){} // RVA: 0x95F3720
        public void lRot8(){} // RVA: 0x95F65E0
        public void sbox2(){} // RVA: 0x95F6600
        public void sbox3(){} // RVA: 0x95F6690
        public void sbox4(){} // RVA: 0x95F6720
        public void camelliaF2(){} // RVA: 0x95F67B0
        public void camelliaFLs(){} // RVA: 0x95F6B50
        public void setKey(){} // RVA: 0x95F6C70
        public void processBlock128(){} // RVA: 0x95F8330
        public void processBlock192or256(){} // RVA: 0x95F88A0
        public void .ctor(){} // RVA: 0x95F8E70
        public void get_AlgorithmName(){} // RVA: 0x95F9040
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void Init(){} // RVA: 0x95F9080
        public void ProcessBlock(){} // RVA: 0x95F91A0
        public void Reset(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x95F9350
    }

    public class CamelliaWrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x95F9500
    }

    public class Cast5Engine
    {
        public uint[] S1;
        public uint[] S2; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x95F9560
        public void Init(){} // RVA: 0x95F96B0
        public void get_AlgorithmName(){} // RVA: 0x95F9890
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void ProcessBlock(){} // RVA: 0x95F98D0
        public void Reset(){} // RVA: 0x2DD310
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void SetKey(){} // RVA: 0x95F9AD0
        public void EncryptBlock(){} // RVA: 0x95FF140
        public void DecryptBlock(){} // RVA: 0x95FF370
        public void F1(){} // RVA: 0x95FF5A0
        public void F2(){} // RVA: 0x95FF6C0
        public void F3(){} // RVA: 0x95FF7E0
        public void CAST_Encipher(){} // RVA: 0x95FF900
        public void CAST_Decipher(){} // RVA: 0x95FFB40
        public void Bits32ToInts(){} // RVA: 0x95FFD80
        public void IntsTo32bits(){} // RVA: 0x95FFE00
        public void .cctor(){} // RVA: 0x95FFE80
    }

    public class Cast6Engine
    {
        public int ROUNDS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9600400
        public void get_AlgorithmName(){} // RVA: 0x9600670
        public void Reset(){} // RVA: 0x2DD310
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void SetKey(){} // RVA: 0x96006B0
        public void EncryptBlock(){} // RVA: 0x9601280
        public void DecryptBlock(){} // RVA: 0x9601660
        public void CAST_Encipher(){} // RVA: 0x9601A40
        public void CAST_Decipher(){} // RVA: 0x9601DC0
    }

    public class ChaCha7539Engine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9602140
        public void get_AlgorithmName(){} // RVA: 0x96021E0
        public void get_NonceSize(){} // RVA: 0x210E2A0
        public void AdvanceCounter(){} // RVA: 0x9602230
        public void ResetCounter(){} // RVA: 0x96022B0
        public void SetKey(){} // RVA: 0x96022E0
        public void GenerateKeyStream(){} // RVA: 0x96024F0
    }

    public class ChaChaEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9602650 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x96026B0
        public void AdvanceCounter(){} // RVA: 0x9602700
        public void ResetCounter(){} // RVA: 0x9602740
        public void SetKey(){} // RVA: 0x9602780
        public void GenerateKeyStream(){} // RVA: 0x96024F0
        public void ChachaCore(){} // RVA: 0x9602A40
    }

    public class DesEdeEngine
    {
        public int[] workingKey1; // 0x18

        // ── Methods ──
        public void Init(){} // RVA: 0x96031B0
        public void get_AlgorithmName(){} // RVA: 0x9603610
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void ProcessBlock(){} // RVA: 0x9603650
        public void Reset(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x96038E0
    }

    public class DesEdeWrapEngine
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.CbcBlockCipher engine; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x9603930
        public void get_AlgorithmName(){} // RVA: 0x9603F80
        public void Wrap(){} // RVA: 0x9603FC0
        public void Unwrap(){} // RVA: 0x9604420
        public void CalculateCmsKeyChecksum(){} // RVA: 0x9604AB0
        public void CheckCmsKeyChecksum(){} // RVA: 0x9604BA0
        public void reverse(){} // RVA: 0x9604C80
        public void .ctor(){} // RVA: 0x9604D10
        public void .cctor(){} // RVA: 0x9604E30
    }

    public class DesEngine
    {
        public int BLOCK_SIZE;
        public int[] workingKey; // 0x10

        // ── Methods ──
        public void GetWorkingKey(){} // RVA: 0x2F8380
        public void Init(){} // RVA: 0x9604F10
        public void get_AlgorithmName(){} // RVA: 0x96050E0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void ProcessBlock(){} // RVA: 0x9605120
        public void Reset(){} // RVA: 0x2DD310
        public void GenerateWorkingKey(){} // RVA: 0x96052F0
        public void DesFunc(){} // RVA: 0x9605880
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9605F60
    }

    public class Dstu7624Engine
    {
        public ulong[] internalState; // 0x10
        public ulong[] workingKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9606820
        public void Init(){} // RVA: 0x9606920
        public void WorkingKeyExpandKT(){} // RVA: 0x9606E00
        public void WorkingKeyExpandEven(){} // RVA: 0x96070E0
        public void WorkingKeyExpandOdd(){} // RVA: 0x9607590
        public void ProcessBlock(){} // RVA: 0x9607600
        public void EncryptionRound(){} // RVA: 0x9607990
        public void DecryptionRound(){} // RVA: 0x9607A50
        public void DecryptBlock_128(){} // RVA: 0x9607B10
        public void EncryptBlock_128(){} // RVA: 0x96080A0
        public void SubBytes(){} // RVA: 0x9608710
        public void InvSubBytes(){} // RVA: 0x96089B0
        public void ShiftRows(){} // RVA: 0x9608C50
        public void InvShiftRows(){} // RVA: 0x96090C0
        public void AddRoundKey(){} // RVA: 0x9609530
        public void SubRoundKey(){} // RVA: 0x96095A0
        public void XorRoundKey(){} // RVA: 0x9609610
        public void MixColumn(){} // RVA: 0x9609680
        public void MixColumns(){} // RVA: 0x96097B0
        public void MixColumnInv(){} // RVA: 0x9609860
        public void MixColumnsInv(){} // RVA: 0x9609A70
        public void MulX(){} // RVA: 0x9609B20
        public void MulX2(){} // RVA: 0x9609B50
        public void Rotate(){} // RVA: 0x9609BA0
        public void RotateLeft(){} // RVA: 0x9609BC0
        public void get_AlgorithmName(){} // RVA: 0x9609F00
        public void GetBlockSize(){} // RVA: 0x9609F40
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void Reset(){} // RVA: 0x9609F50
        public void .cctor(){} // RVA: 0x9609F80
    }

    public class Dstu7624WrapEngine
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter param; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x960A4E0
        public void get_AlgorithmName(){} // RVA: 0x960A600
        public void Init(){} // RVA: 0x960A640
        public void Wrap(){} // RVA: 0x960A800
        public void Unwrap(){} // RVA: 0x960B040
    }

    public class ElGamalEngine : get_AlgorithmName
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters key; // 0x10

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x960B9E0
        public void Init(){} // RVA: 0x960BA20
        public void GetInputBlockSize(){} // RVA: 0x960BF10
        public void GetOutputBlockSize(){} // RVA: 0x960BF40
        public void ProcessBlock(){} // RVA: 0x960BF70
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Gost28147Engine
    {
        public int BlockSize;
        public int[] workingKey; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x960C550
        public void AddSBox(){} // RVA: 0x960CD00
        public void .ctor(){} // RVA: 0x960CDE0
        public void Init(){} // RVA: 0x960CE90
        public void get_AlgorithmName(){} // RVA: 0x960D2C0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void ProcessBlock(){} // RVA: 0x960D300
        public void Reset(){} // RVA: 0x2DD310
        public void generateWorkingKey(){} // RVA: 0x960D4B0
        public void Gost28147_mainStep(){} // RVA: 0x960D620
        public void Gost28147Func(){} // RVA: 0x960D790
        public void bytesToint(){} // RVA: 0x95C8110
        public void intTobytes(){} // RVA: 0x95C8190
        public void GetSBox(){} // RVA: 0x960DAE0
        public void GetSBoxName(){} // RVA: 0x960DCC0
    }

    public class HC128Engine
    {
        public uint[] p; // 0x10

        // ── Methods ──
        public void F1(){} // RVA: 0x960E040
        public void F2(){} // RVA: 0x960E070
        public void G1(){} // RVA: 0x960E0A0
        public void G2(){} // RVA: 0x960E0D0
        public void RotateLeft(){} // RVA: 0x5E96E30
        public void RotateRight(){} // RVA: 0x5C98C70
        public void H1(){} // RVA: 0x960E100
        public void H2(){} // RVA: 0x960E150
        public void Mod1024(){} // RVA: 0x960E1A0
        public void Mod512(){} // RVA: 0x960E1B0
        public void Dim(){} // RVA: 0x960E1C0
        public void Step(){} // RVA: 0x960E1D0
        public void Init(){} // RVA: 0x960E7F0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x960E7B0
        public void GetByte(){} // RVA: 0x960EB60
        public void ProcessBytes(){} // RVA: 0x960EBF0
        public void Reset(){} // RVA: 0x960EE90
        public void ReturnByte(){} // RVA: 0x960EEA0
        public void .ctor(){} // RVA: 0x960EEC0
    }

    public class HC256Engine
    {
        public uint[] p; // 0x10

        // ── Methods ──
        public void Step(){} // RVA: 0x960F040
        public void Init(){} // RVA: 0x960F8C0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x960F880
        public void GetByte(){} // RVA: 0x960FC30
        public void ProcessBytes(){} // RVA: 0x960FCC0
        public void Reset(){} // RVA: 0x960FF60
        public void ReturnByte(){} // RVA: 0x960FF70
        public void RotateRight(){} // RVA: 0x5C98C70
        public void .ctor(){} // RVA: 0x960FF90
    }

    public class IdeaEngine
    {
        public int BLOCK_SIZE;
        public int[] workingKey; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x9610110
        public void get_AlgorithmName(){} // RVA: 0x96102C0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void ProcessBlock(){} // RVA: 0x9610300
        public void Reset(){} // RVA: 0x2DD310
        public void BytesToWord(){} // RVA: 0x96104B0
        public void WordToBytes(){} // RVA: 0x96104F0
        public void Mul(){} // RVA: 0x9610530
        public void IdeaFunc(){} // RVA: 0x9610630
        public void ExpandKey(){} // RVA: 0x9610A00
        public void MulInv(){} // RVA: 0x9610BF0
        public void AddInv(){} // RVA: 0x9610D40
        public void InvertKey(){} // RVA: 0x9610DA0
        public void GenerateWorkingKey(){} // RVA: 0x96112D0
        public void .cctor(){} // RVA: 0x9611310
    }

    public class IesEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9611560 | overloaded x2
        public void Init(){} // RVA: 0x96117A0
        public void DecryptBlock(){} // RVA: 0x9611990
        public void EncryptBlock(){} // RVA: 0x9611F10
        public void GenerateKdfBytes(){} // RVA: 0x96123C0
        public void ProcessBlock(){} // RVA: 0x9612480
    }

    public class IsaacEngine
    {
        public int sizeL;

        // ── Methods ──
        public void Init(){} // RVA: 0x96125F0
        public void ReturnByte(){} // RVA: 0x9612740
        public void ProcessBytes(){} // RVA: 0x96127F0
        public void get_AlgorithmName(){} // RVA: 0x9612A50
        public void Reset(){} // RVA: 0x9612A90
        public void setKey(){} // RVA: 0x9612AA0
        public void isaac(){} // RVA: 0x9613030
        public void mix(){} // RVA: 0x96131A0
        public void .ctor(){} // RVA: 0x96133E0
        public void .cctor(){} // RVA: 0x96134B0
    }

    public class NaccacheSternEngine
    {
        public bool forEncryption; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.NaccacheSternKeyParameters key; // 0x18

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x9613510
        public void Init(){} // RVA: 0x9613550
        public void set_Debug(){} // RVA: 0x2DD310
        public void GetInputBlockSize(){} // RVA: 0x9613B40
        public void GetOutputBlockSize(){} // RVA: 0x9613BA0
        public void ProcessBlock(){} // RVA: 0x9613C00
        public void Encrypt(){} // RVA: 0x9614380
        public void AddCryptedBlocks(){} // RVA: 0x9614470
        public void ProcessData(){} // RVA: 0x9614730
        public void chineseRemainder(){} // RVA: 0x9614920
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class NoekeonEngine
    {
        public int GenericSize;
        public uint[] nullVector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9614EE0
        public void get_AlgorithmName(){} // RVA: 0x9615050
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void Init(){} // RVA: 0x9615090
        public void ProcessBlock(){} // RVA: 0x9615200
        public void Reset(){} // RVA: 0x2DD310
        public void setKey(){} // RVA: 0x96153D0
        public void encryptBlock(){} // RVA: 0x9615560
        public void decryptBlock(){} // RVA: 0x9615DB0
        public void gamma(){} // RVA: 0x9616750
        public void theta(){} // RVA: 0x9616800
        public void pi1(){} // RVA: 0x96168F0
        public void pi2(){} // RVA: 0x9616950
        public void rotl(){} // RVA: 0x96169B0
        public void .cctor(){} // RVA: 0x96169D0
    }

    public class NullEngine
    {
        public bool initialised; // 0x10
        public int BlockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x6BD7E0
        public void get_AlgorithmName(){} // RVA: 0x9616B40
        public void get_IsPartialBlockOkay(){} // RVA: 0x3C2850
        public void GetBlockSize(){} // RVA: 0x3CFAF0
        public void ProcessBlock(){} // RVA: 0x9616B80
        public void Reset(){} // RVA: 0x2DD310
    }

    public class RC2Engine
    {
        public byte[] piTable;
        public int BLOCK_SIZE;

        // ── Methods ──
        public void GenerateWorkingKey(){} // RVA: 0x9616D50
        public void Init(){} // RVA: 0x9617040
        public void Reset(){} // RVA: 0x2DD310
        public void get_AlgorithmName(){} // RVA: 0x9617300
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void ProcessBlock(){} // RVA: 0x9617340
        public void RotateWordLeft(){} // RVA: 0x9617500
        public void EncryptBlock(){} // RVA: 0x9617520
        public void DecryptBlock(){} // RVA: 0x9617AA0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9617F90
    }

    public class RC2WrapEngine
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.CbcBlockCipher engine; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x9618070
        public void get_AlgorithmName(){} // RVA: 0x96186C0
        public void Wrap(){} // RVA: 0x9618700
        public void Unwrap(){} // RVA: 0x9618D00
        public void CalculateCmsKeyChecksum(){} // RVA: 0x9619620
        public void CheckCmsKeyChecksum(){} // RVA: 0x9619710
        public void .ctor(){} // RVA: 0x96197F0
        public void .cctor(){} // RVA: 0x9619910
    }

    public class RC4Engine
    {
        public int STATE_LENGTH;

        // ── Methods ──
        public void Init(){} // RVA: 0x96199F0
        public void get_AlgorithmName(){} // RVA: 0x9619B90
        public void ReturnByte(){} // RVA: 0x9619BD0
        public void ProcessBytes(){} // RVA: 0x9619CB0
        public void Reset(){} // RVA: 0x9619F00
        public void SetKey(){} // RVA: 0x9619F10
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x961A170
    }

    public class RC532Engine
    {
        public int _noRounds; // 0x10
        public int[] _S; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x961A1B0
        public void get_AlgorithmName(){} // RVA: 0x961A1C0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void Init(){} // RVA: 0x961A200
        public void ProcessBlock(){} // RVA: 0x961A4B0
        public void Reset(){} // RVA: 0x2DD310
        public void SetKey(){} // RVA: 0x961A4E0
        public void EncryptBlock(){} // RVA: 0x961A800
        public void DecryptBlock(){} // RVA: 0x961AA70
        public void RotateLeft(){} // RVA: 0x961AD00
        public void RotateRight(){} // RVA: 0x961AD20
        public void BytesToWord(){} // RVA: 0x5CCB580
        public void WordToBytes(){} // RVA: 0x5CC6FC0
        public void .cctor(){} // RVA: 0x961AD40
    }

    public class RC564Engine
    {
        public int wordSize;
        public int bytesPerWord; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x961A1B0
        public void get_AlgorithmName(){} // RVA: 0x961ADA0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x961ADE0
        public void Init(){} // RVA: 0x961AE40
        public void ProcessBlock(){} // RVA: 0x961B040
        public void Reset(){} // RVA: 0x2DD310
        public void SetKey(){} // RVA: 0x961B070
        public void EncryptBlock(){} // RVA: 0x961B4C0
        public void DecryptBlock(){} // RVA: 0x961B8B0
        public void RotateLeft(){} // RVA: 0x961BC90
        public void RotateRight(){} // RVA: 0x961BD20
        public void BytesToWord(){} // RVA: 0x961BDB0
        public void WordToBytes(){} // RVA: 0x961BE60
        public void .cctor(){} // RVA: 0x961BF10
    }

    public class RC6Engine
    {
        public int wordSize;
        public int bytesPerWord; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_AlgorithmName(){} // RVA: 0x961BFB0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x961BFF0
        public void Init(){} // RVA: 0x961C050
        public void ProcessBlock(){} // RVA: 0x961C1B0
        public void Reset(){} // RVA: 0x2DD310
        public void SetKey(){} // RVA: 0x961C380
        public void EncryptBlock(){} // RVA: 0x961C7D0
        public void DecryptBlock(){} // RVA: 0x961CF70
        public void RotateLeft(){} // RVA: 0x961D720
        public void RotateRight(){} // RVA: 0x961D7B0
        public void BytesToWord(){} // RVA: 0x961D840
        public void WordToBytes(){} // RVA: 0x961D8F0
        public void .cctor(){} // RVA: 0x961D9A0
    }

    public class Rfc3211WrapEngine
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.CbcBlockCipher engine; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x961DA60
        public void Init(){} // RVA: 0x961DB20
        public void get_AlgorithmName(){} // RVA: 0x961DE90
        public void Wrap(){} // RVA: 0x961DF10
        public void Unwrap(){} // RVA: 0x961E1C0
    }

    public class Rfc3394WrapEngine
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher engine; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x961E660
        public void Init(){} // RVA: 0x961E790
        public void get_AlgorithmName(){} // RVA: 0x961EB10
        public void Wrap(){} // RVA: 0x961EB60
        public void Unwrap(){} // RVA: 0x961EEC0
    }

    public class RijndaelEngine
    {
        public int MAXROUNDS;
        public int MAXKC; // 0x4

        // ── Methods ──
        public void Mul0x2(){} // RVA: 0x961F350
        public void Mul0x3(){} // RVA: 0x961F3F0
        public void Mul0x9(){} // RVA: 0x961F490
        public void Mul0xb(){} // RVA: 0x961F520
        public void Mul0xd(){} // RVA: 0x961F5B0
        public void Mul0xe(){} // RVA: 0x961F640
        public void KeyAddition(){} // RVA: 0x961F6D0
        public void Shift(){} // RVA: 0x961F740
        public void ShiftRow(){} // RVA: 0x961F770
        public void ApplyS(){} // RVA: 0x961F840
        public void Substitution(){} // RVA: 0x961F8A0
        public void MixColumn(){} // RVA: 0x961FA10
        public void InvMixColumn(){} // RVA: 0x961FBF0
        public void GenerateWorkingKey(){} // RVA: 0x961FFC0
        public void .ctor(){} // RVA: 0x9620850 | overloaded x2
        public void Init(){} // RVA: 0x9620D50
        public void get_AlgorithmName(){} // RVA: 0x9620FA0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x9620FE0
        public void ProcessBlock(){} // RVA: 0x9620FF0
        public void Reset(){} // RVA: 0x2DD310
        public void UnPackBlock(){} // RVA: 0x9621320
        public void PackBlock(){} // RVA: 0x9621440
        public void EncryptBlock(){} // RVA: 0x96214E0
        public void DecryptBlock(){} // RVA: 0x9621720
        public void .cctor(){} // RVA: 0x9621950
    }

    public class RsaBlindedEngine
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IRsa core; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9622150
        public void Init(){} // RVA: 0x9622190
        public void GetInputBlockSize(){} // RVA: 0x9622680
        public void GetOutputBlockSize(){} // RVA: 0x96226D0
        public void ProcessBlock(){} // RVA: 0x9622720
    }

    public class RsaBlindingEngine
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IRsa core; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9622AF0
        public void Init(){} // RVA: 0x9622B30
        public void GetInputBlockSize(){} // RVA: 0x9622D70
        public void GetOutputBlockSize(){} // RVA: 0x9622DC0
        public void ProcessBlock(){} // RVA: 0x9622E10
        public void BlindMessage(){} // RVA: 0x9623020
        public void UnblindMessage(){} // RVA: 0x9623110
    }

    public class RsaCoreEngine
    {
        // ── Methods ──
        public void CheckInitialised(){} // RVA: 0x96231F0
        public void Init(){} // RVA: 0x9623260
        public void GetInputBlockSize(){} // RVA: 0x9623490
        public void GetOutputBlockSize(){} // RVA: 0x9623520
        public void ConvertInput(){} // RVA: 0x96235B0
        public void ConvertOutput(){} // RVA: 0x9623770
        public void ProcessBlock(){} // RVA: 0x9623880
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RsaEngine
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IRsa core; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9623B50
        public void Init(){} // RVA: 0x9623B90
        public void GetInputBlockSize(){} // RVA: 0x9623C00
        public void GetOutputBlockSize(){} // RVA: 0x9623C50
        public void ProcessBlock(){} // RVA: 0x9623CA0
    }

    public class SM2Engine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void Init(){} // RVA: 0x962DC80
        public void ProcessBlock(){} // RVA: 0x962E140
        public void CreateBasePointMultiplier(){} // RVA: 0x962E170
        public void Encrypt(){} // RVA: 0x962E1B0
        public void Decrypt(){} // RVA: 0x962E7B0
        public void NotEncrypted(){} // RVA: 0x962ED10
        public void Kdf(){} // RVA: 0x962ED80
        public void Xor(){} // RVA: 0x962F240
        public void NextK(){} // RVA: 0x962F2B0
        public void AddFieldElement(){} // RVA: 0x962F380
    }

    public class SM4Engine
    {
        public int BlockSize;
        public byte[] Sbox;

        // ── Methods ──
        public void tau(){} // RVA: 0x962F410
        public void L_ap(){} // RVA: 0x962F4F0
        public void T_ap(){} // RVA: 0x962F510
        public void ExpandKey(){} // RVA: 0x962F580
        public void L(){} // RVA: 0x962FDC0
        public void T(){} // RVA: 0x962FDF0
        public void Init(){} // RVA: 0x962FE70
        public void get_AlgorithmName(){} // RVA: 0x9630050
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void ProcessBlock(){} // RVA: 0x9630090
        public void Reset(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x96307D0
    }

    public class Salsa20Engine
    {
        public int DEFAULT_ROUNDS;
        public int StateSize;

        // ── Methods ──
        public void PackTauOrSigma(){} // RVA: 0x9623D40
        public void .ctor(){} // RVA: 0x9623F10 | overloaded x2
        public void Init(){} // RVA: 0x96240E0
        public void get_NonceSize(){} // RVA: 0xA63AE0
        public void get_AlgorithmName(){} // RVA: 0x9624490
        public void ReturnByte(){} // RVA: 0x9624560
        public void AdvanceCounter(){} // RVA: 0x9624640
        public void ProcessBytes(){} // RVA: 0x9624680
        public void Reset(){} // RVA: 0x9624960
        public void ResetCounter(){} // RVA: 0x9624980
        public void SetKey(){} // RVA: 0x96249C0
        public void GenerateKeyStream(){} // RVA: 0x9624DD0
        public void SalsaCore(){} // RVA: 0x9624F00
        public void R(){} // RVA: 0x5E96E30
        public void ResetLimitCounter(){} // RVA: 0x9625630
        public void LimitExceeded(){} // RVA: 0x9625660 | overloaded x2
        public void .cctor(){} // RVA: 0x9625690
    }

    public class SeedEngine
    {
        public int BlockSize;
        public uint[] SS0;

        // ── Methods ──
        public void Init(){} // RVA: 0x96259E0
        public void get_AlgorithmName(){} // RVA: 0x9625AF0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void ProcessBlock(){} // RVA: 0x9625B30
        public void Reset(){} // RVA: 0x2DD310
        public void createWorkingKey(){} // RVA: 0x9625E70
        public void extractW1(){} // RVA: 0x3B45020
        public void extractW0(){} // RVA: 0x96260B0
        public void rotateLeft8(){} // RVA: 0x96260C0
        public void rotateRight8(){} // RVA: 0x96260D0
        public void bytesToLong(){} // RVA: 0x96260E0
        public void longToBytes(){} // RVA: 0x9626130
        public void G(){} // RVA: 0x9626190
        public void F(){} // RVA: 0x9626280
        public void phaseCalc1(){} // RVA: 0x9626340
        public void phaseCalc2(){} // RVA: 0x9626390
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9626420
    }

    public class SeedWrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96267A0
    }

    public class SerpentEngine
    {
        // ── Methods ──
        public void MakeWorkingKey(){} // RVA: 0x96267F0
        public void EncryptBlock(){} // RVA: 0x96286A0
        public void DecryptBlock(){} // RVA: 0x962A100
        public void .ctor(){} // RVA: 0x962BF80
    }

    public class SerpentEngineBase
    {
        public int BlockSize;
        public int ROUNDS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Init(){} // RVA: 0x962BFD0
        public void get_AlgorithmName(){} // RVA: 0x962C1B0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x962C1F0
        public void ProcessBlock(){} // RVA: 0x962C250
        public void Reset(){} // RVA: 0x2DD310
        public void RotateLeft(){} // RVA: 0x5E96E30
        public void RotateRight(){} // RVA: 0x5C98C70
        public void Sb0(){} // RVA: 0x962C4A0
        public void Ib0(){} // RVA: 0x962C500
        public void Sb1(){} // RVA: 0x962C560
        public void Ib1(){} // RVA: 0x962C5C0
        public void Sb2(){} // RVA: 0x962C620
        public void Ib2(){} // RVA: 0x962C6A0
        public void Sb3(){} // RVA: 0x962C710
        public void Ib3(){} // RVA: 0x962C790
        public void Sb4(){} // RVA: 0x962C7F0
        public void Ib4(){} // RVA: 0x962C850
        public void Sb5(){} // RVA: 0x962C8B0
        public void Ib5(){} // RVA: 0x962C910
        public void Sb6(){} // RVA: 0x962C990
        public void Ib6(){} // RVA: 0x962C9E0
        public void Sb7(){} // RVA: 0x962CA50
        public void Ib7(){} // RVA: 0x962CAC0
        public void LT(){} // RVA: 0x962CB40
        public void InverseLT(){} // RVA: 0x962CC20
        public void MakeWorkingKey(){} // RVA: 0xCE10
        public void EncryptBlock(){}
        public void DecryptBlock(){}
        public void .cctor(){} // RVA: 0x962CD00
    }

    public class SkipjackEngine
    {
        public int BLOCK_SIZE;
        public short[] ftable;

        // ── Methods ──
        public void Init(){} // RVA: 0x962CD40
        public void get_AlgorithmName(){} // RVA: 0x962D1A0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void ProcessBlock(){} // RVA: 0x962D1E0
        public void Reset(){} // RVA: 0x2DD310
        public void G(){} // RVA: 0x962D3B0
        public void EncryptBlock(){} // RVA: 0x962D520
        public void H(){} // RVA: 0x962D750
        public void DecryptBlock(){} // RVA: 0x962D8C0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x962DB00
    }

    public class TeaEngine
    {
        public int rounds;
        public int block_size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x629E0D0
        public void get_AlgorithmName(){} // RVA: 0x9630A20
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void Init(){} // RVA: 0x9630A60
        public void ProcessBlock(){} // RVA: 0x9630BC0
        public void Reset(){} // RVA: 0x2DD310
        public void setKey(){} // RVA: 0x9630D90
        public void encryptBlock(){} // RVA: 0x9630EC0
        public void decryptBlock(){} // RVA: 0x96310E0
    }

    public class ThreefishEngine
    {
        public int BLOCKSIZE_256;
        public int BLOCKSIZE_512;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x9631300
        public void .ctor(){} // RVA: 0x96316D0
        public void Init(){} // RVA: 0x9631E50 | overloaded x2
        public void SetKey(){} // RVA: 0x9632130
        public void SetTweak(){} // RVA: 0x9632290
        public void get_AlgorithmName(){} // RVA: 0x9632400
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0x32A5C0
        public void Reset(){} // RVA: 0x2DD310
        public void ProcessBlock(){} // RVA: 0x96326D0 | overloaded x2
        public void BytesToWord(){} // RVA: 0x9632850
        public void WordToBytes(){} // RVA: 0x96329A0
        public void RotlXor(){} // RVA: 0x9632AC0
        public void XorRotr(){} // RVA: 0x9632AE0
    }

    public class TnepresEngine
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x9636600
        public void MakeWorkingKey(){} // RVA: 0x9636640
        public void EncryptBlock(){} // RVA: 0x96384C0
        public void DecryptBlock(){} // RVA: 0x9639F40
        public void .ctor(){} // RVA: 0x963BDD0
    }

    public class TwofishEngine
    {
        public byte[,] P;
        public int P_00;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x963BE20
        public void Init(){} // RVA: 0x963C340
        public void get_AlgorithmName(){} // RVA: 0x963C510
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void ProcessBlock(){} // RVA: 0x963C550
        public void Reset(){} // RVA: 0x963C710
        public void GetBlockSize(){} // RVA: 0x210E2B0
        public void SetKey(){} // RVA: 0x963C730
        public void EncryptBlock(){} // RVA: 0x963D380
        public void DecryptBlock(){} // RVA: 0x963DA40
        public void F32(){} // RVA: 0x963E0F0
        public void RS_MDS_Encode(){} // RVA: 0x963E6D0
        public void RS_rem(){} // RVA: 0x963E7C0
        public void LFSR1(){} // RVA: 0x963E820
        public void LFSR2(){} // RVA: 0x963E840
        public void Mx_X(){} // RVA: 0x963E870
        public void Mx_Y(){} // RVA: 0x963E8A0
        public void M_b0(){} // RVA: 0xFEC6F0
        public void M_b1(){} // RVA: 0x963E8E0
        public void M_b2(){} // RVA: 0x963E8F0
        public void M_b3(){} // RVA: 0x963E900
        public void Fe32_0(){} // RVA: 0x963E910
        public void Fe32_3(){} // RVA: 0x963E990
        public void BytesTo32Bits(){} // RVA: 0x5CCB580
        public void Bits32ToBytes(){} // RVA: 0x5CC6FC0
        public void .cctor(){} // RVA: 0x963EA20
    }

    public class VmpcEngine
    {
        public byte n; // 0x10

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x963EB10
        public void Init(){} // RVA: 0x963EB50
        public void InitKey(){} // RVA: 0x963EE30
        public void ProcessBytes(){} // RVA: 0x963F0C0
        public void Reset(){} // RVA: 0x963F310
        public void ReturnByte(){} // RVA: 0x963F330
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class VmpcKsa3Engine
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x963F410
        public void InitKey(){} // RVA: 0x963F450
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class XSalsa20Engine
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x963F7B0
        public void get_NonceSize(){} // RVA: 0x210E290
        public void SetKey(){} // RVA: 0x963F7F0
        public void .ctor(){} // RVA: 0x963FC90
    }

    public class XteaEngine
    {
        public int rounds;
        public int block_size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x963FD30
        public void get_AlgorithmName(){} // RVA: 0x963FEA0
        public void get_IsPartialBlockOkay(){} // RVA: 0x2DD320
        public void GetBlockSize(){} // RVA: 0xA63AE0
        public void Init(){} // RVA: 0x963FEE0
        public void ProcessBlock(){} // RVA: 0x96401A0
        public void Reset(){} // RVA: 0x2DD310
        public void setKey(){} // RVA: 0x9640370
        public void encryptBlock(){} // RVA: 0x96404E0
        public void decryptBlock(){} // RVA: 0x9640720
    }

}