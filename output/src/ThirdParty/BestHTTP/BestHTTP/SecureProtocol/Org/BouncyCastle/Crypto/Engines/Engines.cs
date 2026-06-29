// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
// Classes: 56
// Methods: 660

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
    public class AesEngine : Object
    {
        public object S;
        public object Si;
        public object rcon;
        public object T0;
        public object Tinv0;
        public object m1;
        public object m2;
        public object m3;
        public object m4;
        public object m5;
        public object ROUNDS;
        public object WorkingKey;
        public object C0;
        public object C1;
        public object C2;
        public object C3;
        public object forEncryption;
        public object s;
        public object BLOCK_SIZE;

        // ── Methods ──
        public void Shift(){} // RVA: 0x67114B0
        public void FFmulX(){} // RVA: 0xA2897D0
        public void FFmulX2(){} // RVA: 0xA2897F0
        public void Inv_Mcol(){} // RVA: 0xA289820
        public void SubWord(){} // RVA: 0xA2898D0
        public void GenerateWorkingKey(){} // RVA: 0xA2899B0
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xA28ACF0
        public void get_AlgorithmName(){} // RVA: 0xA28AFD0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void ProcessBlock(){} // RVA: 0xA28B010
        public void Reset(){} // RVA: 0xB43310
        public void UnPackBlock(){} // RVA: 0xA28B1E0
        public void PackBlock(){} // RVA: 0xA28B3A0
        public void EncryptBlock(){} // RVA: 0xA28B540
        public void DecryptBlock(){} // RVA: 0xA28C320
        public void .cctor(){} // RVA: 0xA28D0F0
    }

    public class AesFastEngine : Object
    {
        public object S;
        public object Si;
        public object rcon;
        public object T0;
        public object T1;
        public object T2;
        public object T3;
        public object Tinv0;
        public object Tinv1;
        public object Tinv2;
        public object Tinv3;
        public object m1;
        public object m2;
        public object m3;
        public object m4;
        public object m5;
        public object ROUNDS;
        public object WorkingKey;
        public object C0;
        public object C1;
        public object C2;
        public object C3;
        public object forEncryption;
        public object BLOCK_SIZE;

        // ── Methods ──
        public void Shift(){} // RVA: 0x67114B0
        public void FFmulX(){} // RVA: 0xA2897D0
        public void FFmulX2(){} // RVA: 0xA2897F0
        public void Inv_Mcol(){} // RVA: 0xA28D480
        public void SubWord(){} // RVA: 0xA28D530
        public void GenerateWorkingKey(){} // RVA: 0xA28D610
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xA28E950
        public void get_AlgorithmName(){} // RVA: 0xA28EAC0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void ProcessBlock(){} // RVA: 0xA28EB00
        public void Reset(){} // RVA: 0xB43310
        public void UnPackBlock(){} // RVA: 0xA28B1E0
        public void PackBlock(){} // RVA: 0xA28B3A0
        public void EncryptBlock(){} // RVA: 0xA28ECD0
        public void DecryptBlock(){} // RVA: 0xA28F930
        public void .cctor(){} // RVA: 0xA290590
    }

    public class AesLightEngine : Object
    {
        public object S;
        public object Si;
        public object rcon;
        public object m1;
        public object m2;
        public object m3;
        public object m4;
        public object m5;
        public object ROUNDS;
        public object WorkingKey;
        public object C0;
        public object C1;
        public object C2;
        public object C3;
        public object forEncryption;
        public object BLOCK_SIZE;

        // ── Methods ──
        public void Shift(){} // RVA: 0x67114B0
        public void FFmulX(){} // RVA: 0xA2897D0
        public void FFmulX2(){} // RVA: 0xA2897F0
        public void Mcol(){} // RVA: 0xA290CE0
        public void Inv_Mcol(){} // RVA: 0xA290D70
        public void SubWord(){} // RVA: 0xA290E20
        public void GenerateWorkingKey(){} // RVA: 0xA290F00
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xA292240
        public void get_AlgorithmName(){} // RVA: 0xA2923B0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void ProcessBlock(){} // RVA: 0xA2923F0
        public void Reset(){} // RVA: 0xB43310
        public void UnPackBlock(){} // RVA: 0xA28B1E0
        public void PackBlock(){} // RVA: 0xA28B3A0
        public void EncryptBlock(){} // RVA: 0xA2925C0
        public void DecryptBlock(){} // RVA: 0xA2938D0
        public void .cctor(){} // RVA: 0xA294650
    }

    public class AesWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA294890
    }

    public class BlowfishEngine : Object
    {
        public object KP;
        public object KS0;
        public object KS1;
        public object KS2;
        public object KS3;
        public object ROUNDS;
        public object BLOCK_SIZE;
        public object SBOX_SK;
        public object P_SZ;
        public object S0;
        public object S1;
        public object S2;
        public object S3;
        public object P;
        public object encrypting;
        public object workingKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2948E0
        public void Init(){} // RVA: 0xA294B80
        public void get_AlgorithmName(){} // RVA: 0xA294D30
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void ProcessBlock(){} // RVA: 0xA294D70
        public void Reset(){} // RVA: 0xB43310
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void F(){} // RVA: 0xA294F30
        public void ProcessTable(){} // RVA: 0xA294FC0
        public void SetKey(){} // RVA: 0xA2951A0
        public void EncryptBlock(){} // RVA: 0xA295570
        public void DecryptBlock(){} // RVA: 0xA295940
        public void .cctor(){} // RVA: 0xA295D10
    }

    public class CamelliaEngine : Object
    {
        public object initialised;
        public object _keyIs128;
        public object BLOCK_SIZE;
        public object subkey;
        public object kw;
        public object ke;
        public object state;
        public object SIGMA;
        public object SBOX1_1110;
        public object SBOX4_4404;
        public object SBOX2_0222;
        public object SBOX3_3033;

        // ── Methods ──
        public void rightRotate(){} // RVA: 0xA2960D0
        public void leftRotate(){} // RVA: 0xA2960F0
        public void roldq(){} // RVA: 0xA296110
        public void decroldq(){} // RVA: 0xA2962D0
        public void roldqo32(){} // RVA: 0xA2964A0
        public void decroldqo32(){} // RVA: 0xA296660
        public void bytes2uint(){} // RVA: 0xA296830
        public void uint2bytes(){} // RVA: 0xA296880
        public void camelliaF2(){} // RVA: 0xA2968E0
        public void camelliaFLs(){} // RVA: 0xA296C90
        public void setKey(){} // RVA: 0xA296DB0
        public void processBlock128(){} // RVA: 0xA298440
        public void processBlock192or256(){} // RVA: 0xA2989A0
        public void .ctor(){} // RVA: 0xA298F50
        public void Init(){} // RVA: 0xA299120
        public void get_AlgorithmName(){} // RVA: 0xA299240
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void ProcessBlock(){} // RVA: 0xA299280
        public void Reset(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA299430
    }

    public class CamelliaLightEngine : Object
    {
        public object BLOCK_SIZE;
        public object initialised;
        public object _keyis128;
        public object subkey;
        public object kw;
        public object ke;
        public object state;
        public object SIGMA;
        public object SBOX1;

        // ── Methods ──
        public void rightRotate(){} // RVA: 0xA2960D0
        public void leftRotate(){} // RVA: 0xA2960F0
        public void roldq(){} // RVA: 0xA296110
        public void decroldq(){} // RVA: 0xA2962D0
        public void roldqo32(){} // RVA: 0xA2964A0
        public void decroldqo32(){} // RVA: 0xA296660
        public void bytes2uint(){} // RVA: 0xA296830
        public void uint2bytes(){} // RVA: 0xA296880
        public void lRot8(){} // RVA: 0xA2997B0
        public void sbox2(){} // RVA: 0xA2997D0
        public void sbox3(){} // RVA: 0xA299860
        public void sbox4(){} // RVA: 0xA2998F0
        public void camelliaF2(){} // RVA: 0xA299980
        public void camelliaFLs(){} // RVA: 0xA299D30
        public void setKey(){} // RVA: 0xA299E50
        public void processBlock128(){} // RVA: 0xA29B500
        public void processBlock192or256(){} // RVA: 0xA29BAA0
        public void .ctor(){} // RVA: 0xA29C0B0
        public void get_AlgorithmName(){} // RVA: 0xA29C280
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void Init(){} // RVA: 0xA29C2C0
        public void ProcessBlock(){} // RVA: 0xA29C3E0
        public void Reset(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA29C590
    }

    public class CamelliaWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA29C740
    }

    public class Cast5Engine : Object
    {
        public object S1;
        public object S2;
        public object S3;
        public object S4;
        public object S5;
        public object S6;
        public object S7;
        public object S8;
        public object MAX_ROUNDS;
        public object RED_ROUNDS;
        public object BLOCK_SIZE;
        public object _Kr;
        public object _Km;
        public object _encrypting;
        public object _workingKey;
        public object _rounds;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA29C7A0
        public void Init(){} // RVA: 0xA29C8F0
        public void get_AlgorithmName(){} // RVA: 0xA29CAD0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void ProcessBlock(){} // RVA: 0xA29CB10
        public void Reset(){} // RVA: 0xB43310
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void SetKey(){} // RVA: 0xA29CD10
        public void EncryptBlock(){} // RVA: 0xA2A2390
        public void DecryptBlock(){} // RVA: 0xA2A25C0
        public void F1(){} // RVA: 0xA2A27F0
        public void F2(){} // RVA: 0xA2A2910
        public void F3(){} // RVA: 0xA2A2A30
        public void CAST_Encipher(){} // RVA: 0xA2A2B50
        public void CAST_Decipher(){} // RVA: 0xA2A2DA0
        public void Bits32ToInts(){} // RVA: 0xA2A3010
        public void IntsTo32bits(){} // RVA: 0xA2A3090
        public void .cctor(){} // RVA: 0xA2A3110
    }

    public class Cast6Engine : Cast5Engine
    {
        public object ROUNDS;
        public object BLOCK_SIZE;
        public object _Kr;
        public object _Km;
        public object _Tr;
        public object _Tm;
        public object _workingKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2A3690
        public void get_AlgorithmName(){} // RVA: 0xA2A3900
        public void Reset(){} // RVA: 0xB43310
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void SetKey(){} // RVA: 0xA2A3940
        public void EncryptBlock(){} // RVA: 0xA2A4590
        public void DecryptBlock(){} // RVA: 0xA2A4970
        public void CAST_Encipher(){} // RVA: 0xA2A4D50
        public void CAST_Decipher(){} // RVA: 0xA2A50C0
    }

    public class ChaCha7539Engine : Salsa20Engine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2A5430
        public void get_AlgorithmName(){} // RVA: 0xA2A54D0
        public void get_NonceSize(){} // RVA: 0x2AFB6E0
        public void AdvanceCounter(){} // RVA: 0xA2A5520
        public void ResetCounter(){} // RVA: 0xA2A55A0
        public void SetKey(){} // RVA: 0xA2A55D0
        public void GenerateKeyStream(){} // RVA: 0xA2A57D0
    }

    public class ChaChaEngine : Salsa20Engine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2A5930
        public void get_AlgorithmName(){} // RVA: 0xA2A5990
        public void AdvanceCounter(){} // RVA: 0xA2A59E0
        public void ResetCounter(){} // RVA: 0xA2A5A20
        public void SetKey(){} // RVA: 0xA2A5A60
        public void GenerateKeyStream(){} // RVA: 0xA2A57D0
        public void ChachaCore(){} // RVA: 0xA2A5D10
    }

    public class DesEdeEngine : DesEngine
    {
        public object workingKey1;
        public object workingKey2;
        public object workingKey3;
        public object forEncryption;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2A6480
        public void get_AlgorithmName(){} // RVA: 0xA2A68E0
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void ProcessBlock(){} // RVA: 0xA2A6920
        public void Reset(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xA2A6BB0
    }

    public class DesEdeWrapEngine : Object
    {
        public object engine;
        public object param;
        public object paramPlusIV;
        public object iv;
        public object forWrapping;
        public object IV2;
        public object sha1;
        public object digest;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2A6C00
        public void get_AlgorithmName(){} // RVA: 0xA2A7250
        public void Wrap(){} // RVA: 0xA2A7290
        public void Unwrap(){} // RVA: 0xA2A76F0
        public void CalculateCmsKeyChecksum(){} // RVA: 0xA2A7DA0
        public void CheckCmsKeyChecksum(){} // RVA: 0xA2A7E90
        public void reverse(){} // RVA: 0xA2A7F80
        public void .ctor(){} // RVA: 0xA2A8020
        public void .cctor(){} // RVA: 0xA2A8140
    }

    public class DesEngine : Object
    {
        public object BLOCK_SIZE;
        public object workingKey;
        public object bytebit;
        public object bigbyte;
        public object pc1;
        public object totrot;
        public object pc2;
        public object SP1;
        public object SP2;
        public object SP3;
        public object SP4;
        public object SP5;
        public object SP6;
        public object SP7;
        public object SP8;

        // ── Methods ──
        public void GetWorkingKey(){} // RVA: 0xB5DBF0
        public void Init(){} // RVA: 0xA2A8220
        public void get_AlgorithmName(){} // RVA: 0xA2A83E0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void ProcessBlock(){} // RVA: 0xA2A8420
        public void Reset(){} // RVA: 0xB43310
        public void GenerateWorkingKey(){} // RVA: 0xA2A85F0
        public void DesFunc(){} // RVA: 0xA2A8BE0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA2A92F0
    }

    public class Dstu7624Engine : Object
    {
        public object internalState;
        public object workingKey;
        public object roundKeys;
        public object wordsInBlock;
        public object wordsInKey;
        public object ROUNDS_128;
        public object ROUNDS_256;
        public object ROUNDS_512;
        public object roundsAmount;
        public object forEncryption;
        public object mdsMatrix;
        public object mdsInvMatrix;
        public object S0;
        public object S1;
        public object S2;
        public object S3;
        public object T0;
        public object T1;
        public object T2;
        public object T3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2A9BB0
        public void Init(){} // RVA: 0xA2A9CB0
        public void WorkingKeyExpandKT(){} // RVA: 0xA2AA1A0
        public void WorkingKeyExpandEven(){} // RVA: 0xA2AA490
        public void WorkingKeyExpandOdd(){} // RVA: 0xA2AA920
        public void ProcessBlock(){} // RVA: 0xA2AA9A0
        public void EncryptionRound(){} // RVA: 0xA2AAD40
        public void DecryptionRound(){} // RVA: 0xA2AAE10
        public void DecryptBlock_128(){} // RVA: 0xA2AAEE0
        public void EncryptBlock_128(){} // RVA: 0xA2AB480
        public void SubBytes(){} // RVA: 0xA2ABAF0
        public void InvSubBytes(){} // RVA: 0xA2ABDA0
        public void ShiftRows(){} // RVA: 0xA2AC050
        public void InvShiftRows(){} // RVA: 0xA2AC520
        public void AddRoundKey(){} // RVA: 0xA2AC9F0
        public void SubRoundKey(){} // RVA: 0xA2ACA70
        public void XorRoundKey(){} // RVA: 0xA2ACAF0
        public void MixColumn(){} // RVA: 0xA2ACB70
        public void MixColumns(){} // RVA: 0xA2ACCA0
        public void MixColumnInv(){} // RVA: 0xA2ACD60
        public void MixColumnsInv(){} // RVA: 0xA2ACF70
        public void MulX(){} // RVA: 0xA2AD030
        public void MulX2(){} // RVA: 0xA2AD060
        public void Rotate(){} // RVA: 0xA2AD0B0
        public void RotateLeft(){} // RVA: 0xA2AD0D0
        public void get_AlgorithmName(){} // RVA: 0xA2AD410
        public void GetBlockSize(){} // RVA: 0xA2AD450
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void Reset(){} // RVA: 0xA2AD460
        public void .cctor(){} // RVA: 0xA2AD490
    }

    public class Dstu7624WrapEngine : Object
    {
        public object param;
        public object engine;
        public object forWrapping;
        public object blockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2AD9F0
        public void get_AlgorithmName(){} // RVA: 0xA2ADB10
        public void Init(){} // RVA: 0xA2ADB50
        public void Wrap(){} // RVA: 0xA2ADD10
        public void Unwrap(){} // RVA: 0xA2AE4D0
    }

    public class ElGamalEngine : Object
    {
        public object key;
        public object random;
        public object forEncryption;
        public object bitSize;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA2AEE20
        public void Init(){} // RVA: 0xA2AEE60
        public void GetInputBlockSize(){} // RVA: 0xA2AF350
        public void GetOutputBlockSize(){} // RVA: 0xA2AF380
        public void ProcessBlock(){} // RVA: 0xA2AF3B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Gost28147Engine : Object
    {
        public object BlockSize;
        public object workingKey;
        public object forEncryption;
        public object S;
        public object Sbox_Default;
        public object ESbox_Test;
        public object ESbox_A;
        public object ESbox_B;
        public object ESbox_C;
        public object ESbox_D;
        public object DSbox_Test;
        public object DSbox_A;
        public object sBoxes;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA2AF990
        public void AddSBox(){} // RVA: 0xA2B0140
        public void .ctor(){} // RVA: 0xA2B0220
        public void Init(){} // RVA: 0xA2B02D0
        public void get_AlgorithmName(){} // RVA: 0xA2B0700
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void ProcessBlock(){} // RVA: 0xA2B0740
        public void Reset(){} // RVA: 0xB43310
        public void generateWorkingKey(){} // RVA: 0xA2B08F0
        public void Gost28147_mainStep(){} // RVA: 0xA2B0A60
        public void Gost28147Func(){} // RVA: 0xA2B0BE0
        public void bytesToint(){} // RVA: 0xA26A940
        public void intTobytes(){} // RVA: 0xA26A9C0
        public void GetSBox(){} // RVA: 0xA2B0FA0
        public void GetSBoxName(){} // RVA: 0xA2B1180
    }

    public class HC128Engine : Object
    {
        public object p;
        public object q;
        public object cnt;
        public object key;
        public object iv;
        public object initialised;
        public object buf;
        public object idx;

        // ── Methods ──
        public void F1(){} // RVA: 0xA2B14E0
        public void F2(){} // RVA: 0xA2B1510
        public void G1(){} // RVA: 0xA2B1540
        public void G2(){} // RVA: 0xA2B1570
        public void RotateLeft(){} // RVA: 0x69104D0
        public void RotateRight(){} // RVA: 0x67114B0
        public void H1(){} // RVA: 0xA2B15A0
        public void H2(){} // RVA: 0xA2B15F0
        public void Mod1024(){} // RVA: 0xA2B1640
        public void Mod512(){} // RVA: 0xA2B1650
        public void Dim(){} // RVA: 0xA2B1660
        public void Step(){} // RVA: 0xA2B1670
        public void Init(){} // RVA: 0xA2B1CC0
        public void get_AlgorithmName(){} // RVA: 0xA2B1C80
        public void GetByte(){} // RVA: 0xA2B2020
        public void ProcessBytes(){} // RVA: 0xA2B20B0
        public void Reset(){} // RVA: 0xA2B2380
        public void ReturnByte(){} // RVA: 0xA2B2390
        public void .ctor(){} // RVA: 0xA2B23B0
    }

    public class HC256Engine : Object
    {
        public object p;
        public object q;
        public object cnt;
        public object key;
        public object iv;
        public object initialised;
        public object buf;
        public object idx;

        // ── Methods ──
        public void Step(){} // RVA: 0xA2B2530
        public void Init(){} // RVA: 0xA2B2DA0
        public void get_AlgorithmName(){} // RVA: 0xA2B2D60
        public void GetByte(){} // RVA: 0xA2B3100
        public void ProcessBytes(){} // RVA: 0xA2B3190
        public void Reset(){} // RVA: 0xA2B3460
        public void ReturnByte(){} // RVA: 0xA2B3470
        public void RotateRight(){} // RVA: 0x67114B0
        public void .ctor(){} // RVA: 0xA2B3490
    }

    public class IdeaEngine : Object
    {
        public object BLOCK_SIZE;
        public object workingKey;
        public object MASK;
        public object BASE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xA2B3610
        public void get_AlgorithmName(){} // RVA: 0xA2B37C0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void ProcessBlock(){} // RVA: 0xA2B3800
        public void Reset(){} // RVA: 0xB43310
        public void BytesToWord(){} // RVA: 0xA2B39B0
        public void WordToBytes(){} // RVA: 0xA2B39F0
        public void Mul(){} // RVA: 0xA2B3A30
        public void IdeaFunc(){} // RVA: 0xA2B3B30
        public void ExpandKey(){} // RVA: 0xA2B3F30
        public void MulInv(){} // RVA: 0xA2B4150
        public void AddInv(){} // RVA: 0xA2B42A0
        public void InvertKey(){} // RVA: 0xA2B4300
        public void GenerateWorkingKey(){} // RVA: 0xA2B48B0
        public void .cctor(){} // RVA: 0xA2B48F0
    }

    public class IesEngine : Object
    {
        public object agree;
        public object kdf;
        public object mac;
        public object cipher;
        public object macBuf;
        public object forEncryption;
        public object privParam;
        public object pubParam;
        public object param;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2B4B40
        public void Init(){} // RVA: 0xA2B4D80
        public void DecryptBlock(){} // RVA: 0xA2B4F70
        public void EncryptBlock(){} // RVA: 0xA2B54F0
        public void GenerateKdfBytes(){} // RVA: 0xA2B5990
        public void ProcessBlock(){} // RVA: 0xA2B5A50
    }

    public class IsaacEngine : Object
    {
        public object sizeL;
        public object stateArraySize;
        public object engineState;
        public object results;
        public object a;
        public object b;
        public object c;
        public object index;
        public object keyStream;
        public object workingKey;
        public object initialised;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2B5BD0
        public void ReturnByte(){} // RVA: 0xA2B5D10
        public void ProcessBytes(){} // RVA: 0xA2B5DC0
        public void get_AlgorithmName(){} // RVA: 0xA2B6040
        public void Reset(){} // RVA: 0xA2B6080
        public void setKey(){} // RVA: 0xA2B6090
        public void isaac(){} // RVA: 0xA2B6640
        public void mix(){} // RVA: 0xA2B67C0
        public void .ctor(){} // RVA: 0xA2B6A00
        public void .cctor(){} // RVA: 0xA2B6AD0
    }

    public class NaccacheSternEngine : Object
    {
        public object forEncryption;
        public object key;
        public object lookup;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA2B6B30
        public void Init(){} // RVA: 0xA2B6B70
        public void set_Debug(){} // RVA: 0xB43310
        public void GetInputBlockSize(){} // RVA: 0xA2B7150
        public void GetOutputBlockSize(){} // RVA: 0xA2B71A0
        public void ProcessBlock(){} // RVA: 0xA2B71F0
        public void Encrypt(){} // RVA: 0xA2B7990
        public void AddCryptedBlocks(){} // RVA: 0xA2B7A80
        public void ProcessData(){} // RVA: 0xA2B7D40
        public void chineseRemainder(){} // RVA: 0xA2B7F30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class NoekeonEngine : Object
    {
        public object GenericSize;
        public object nullVector;
        public object roundConstants;
        public object state;
        public object subKeys;
        public object decryptKeys;
        public object _initialised;
        public object _forEncryption;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2B84F0
        public void get_AlgorithmName(){} // RVA: 0xA2B8660
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void Init(){} // RVA: 0xA2B86A0
        public void ProcessBlock(){} // RVA: 0xA2B8810
        public void Reset(){} // RVA: 0xB43310
        public void setKey(){} // RVA: 0xA2B89E0
        public void encryptBlock(){} // RVA: 0xA2B8B70
        public void decryptBlock(){} // RVA: 0xA2B93E0
        public void gamma(){} // RVA: 0xA2B9DA0
        public void theta(){} // RVA: 0xA2B9E60
        public void pi1(){} // RVA: 0xA2B9F50
        public void pi2(){} // RVA: 0xA2B9FB0
        public void rotl(){} // RVA: 0xA2BA010
        public void .cctor(){} // RVA: 0xA2BA030
    }

    public class NullEngine : Object
    {
        public object initialised;
        public object BlockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xF482F0
        public void get_AlgorithmName(){} // RVA: 0xA2BA1A0
        public void get_IsPartialBlockOkay(){} // RVA: 0xC2E4C0
        public void GetBlockSize(){} // RVA: 0xC3CCE0
        public void ProcessBlock(){} // RVA: 0xA2BA1E0
        public void Reset(){} // RVA: 0xB43310
    }

    public class RC2Engine : Object
    {
        public object piTable;
        public object BLOCK_SIZE;
        public object workingKey;
        public object encrypting;

        // ── Methods ──
        public void GenerateWorkingKey(){} // RVA: 0xA2BA3B0
        public void Init(){} // RVA: 0xA2BA700
        public void Reset(){} // RVA: 0xB43310
        public void get_AlgorithmName(){} // RVA: 0xA2BA9C0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void ProcessBlock(){} // RVA: 0xA2BAA00
        public void RotateWordLeft(){} // RVA: 0xA2BABC0
        public void EncryptBlock(){} // RVA: 0xA2BABE0
        public void DecryptBlock(){} // RVA: 0xA2BB140
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA2BB680
    }

    public class RC2WrapEngine : Object
    {
        public object engine;
        public object parameters;
        public object paramPlusIV;
        public object iv;
        public object forWrapping;
        public object sr;
        public object IV2;
        public object sha1;
        public object digest;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2BB760
        public void get_AlgorithmName(){} // RVA: 0xA2BBDB0
        public void Wrap(){} // RVA: 0xA2BBDF0
        public void Unwrap(){} // RVA: 0xA2BC3E0
        public void CalculateCmsKeyChecksum(){} // RVA: 0xA2BCD00
        public void CheckCmsKeyChecksum(){} // RVA: 0xA2BCDF0
        public void .ctor(){} // RVA: 0xA2BCEE0
        public void .cctor(){} // RVA: 0xA2BD000
    }

    public class RC4Engine : Object
    {
        public object STATE_LENGTH;
        public object engineState;
        public object x;
        public object y;
        public object workingKey;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2BD0E0
        public void get_AlgorithmName(){} // RVA: 0xA2BD270
        public void ReturnByte(){} // RVA: 0xA2BD2B0
        public void ProcessBytes(){} // RVA: 0xA2BD380
        public void Reset(){} // RVA: 0xA2BD5E0
        public void SetKey(){} // RVA: 0xA2BD5F0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA2BD860
    }

    public class RC532Engine : Object
    {
        public object _noRounds;
        public object _S;
        public object P32;
        public object Q32;
        public object forEncryption;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2BD8A0
        public void get_AlgorithmName(){} // RVA: 0xA2BD8B0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void Init(){} // RVA: 0xA2BD8F0
        public void ProcessBlock(){} // RVA: 0xA2BDBA0
        public void Reset(){} // RVA: 0xB43310
        public void SetKey(){} // RVA: 0xA2BDBD0
        public void EncryptBlock(){} // RVA: 0xA2BDF10
        public void DecryptBlock(){} // RVA: 0xA2BE180
        public void RotateLeft(){} // RVA: 0xA2BE400
        public void RotateRight(){} // RVA: 0xA2BE420
        public void BytesToWord(){} // RVA: 0x6744BE0
        public void WordToBytes(){} // RVA: 0x67405D0
        public void .cctor(){} // RVA: 0xA2BE440
    }

    public class RC564Engine : Object
    {
        public object wordSize;
        public object bytesPerWord;
        public object _noRounds;
        public object _S;
        public object P64;
        public object Q64;
        public object forEncryption;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2BD8A0
        public void get_AlgorithmName(){} // RVA: 0xA2BE4A0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0xA2BE4E0
        public void Init(){} // RVA: 0xA2BE540
        public void ProcessBlock(){} // RVA: 0xA2BE710
        public void Reset(){} // RVA: 0xB43310
        public void SetKey(){} // RVA: 0xA2BE740
        public void EncryptBlock(){} // RVA: 0xA2BEB90
        public void DecryptBlock(){} // RVA: 0xA2BEFF0
        public void RotateLeft(){} // RVA: 0xA2BF460
        public void RotateRight(){} // RVA: 0xA2BF4F0
        public void BytesToWord(){} // RVA: 0xA2BF580
        public void WordToBytes(){} // RVA: 0xA2BF630
        public void .cctor(){} // RVA: 0xA2BF6F0
    }

    public class RC6Engine : Object
    {
        public object wordSize;
        public object bytesPerWord;
        public object _noRounds;
        public object _S;
        public object P32;
        public object Q32;
        public object LGW;
        public object forEncryption;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_AlgorithmName(){} // RVA: 0xA2BF790
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0xA2BF7D0
        public void Init(){} // RVA: 0xA2BF830
        public void ProcessBlock(){} // RVA: 0xA2BF980
        public void Reset(){} // RVA: 0xB43310
        public void SetKey(){} // RVA: 0xA2BFB50
        public void EncryptBlock(){} // RVA: 0xA2BFFA0
        public void DecryptBlock(){} // RVA: 0xA2C0810
        public void RotateLeft(){} // RVA: 0xA2C1080
        public void RotateRight(){} // RVA: 0xA2C1110
        public void BytesToWord(){} // RVA: 0xA2C11A0
        public void WordToBytes(){} // RVA: 0xA2C1250
        public void .cctor(){} // RVA: 0xA2C1310
    }

    public class Rfc3211WrapEngine : Object
    {
        public object engine;
        public object param;
        public object forWrapping;
        public object rand;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2C13D0
        public void Init(){} // RVA: 0xA2C1490
        public void get_AlgorithmName(){} // RVA: 0xA2C17F0
        public void Wrap(){} // RVA: 0xA2C1870
        public void Unwrap(){} // RVA: 0xA2C1B20
    }

    public class Rfc3394WrapEngine : Object
    {
        public object engine;
        public object param;
        public object forWrapping;
        public object iv;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2C1FB0
        public void Init(){} // RVA: 0xA2C20E0
        public void get_AlgorithmName(){} // RVA: 0xA2C2460
        public void Wrap(){} // RVA: 0xA2C24B0
        public void Unwrap(){} // RVA: 0xA2C2810
    }

    public class RijndaelEngine : Object
    {
        public object MAXROUNDS;
        public object MAXKC;
        public object Logtable;
        public object Alogtable;
        public object S;
        public object Si;
        public object rcon;
        public object shifts0;
        public object shifts1;
        public object BC;
        public object BC_MASK;
        public object ROUNDS;
        public object blockBits;
        public object workingKey;
        public object A0;
        public object A1;
        public object A2;
        public object A3;
        public object forEncryption;
        public object shifts0SC;
        public object shifts1SC;

        // ── Methods ──
        public void Mul0x2(){} // RVA: 0xA2C2CB0
        public void Mul0x3(){} // RVA: 0xA2C2D50
        public void Mul0x9(){} // RVA: 0xA2C2DF0
        public void Mul0xb(){} // RVA: 0xA2C2E80
        public void Mul0xd(){} // RVA: 0xA2C2F10
        public void Mul0xe(){} // RVA: 0xA2C2FA0
        public void KeyAddition(){} // RVA: 0xA2C3030
        public void Shift(){} // RVA: 0xA2C30A0
        public void ShiftRow(){} // RVA: 0xA2C30D0
        public void ApplyS(){} // RVA: 0xA2C31B0
        public void Substitution(){} // RVA: 0xA2C3210
        public void MixColumn(){} // RVA: 0xA2C3380
        public void InvMixColumn(){} // RVA: 0xA2C3520
        public void GenerateWorkingKey(){} // RVA: 0xA2C38F0
        public void .ctor(){} // RVA: 0xA2C4250
        public void Init(){} // RVA: 0xA2C4750
        public void get_AlgorithmName(){} // RVA: 0xA2C4960
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0xA2C49A0
        public void ProcessBlock(){} // RVA: 0xA2C49B0
        public void Reset(){} // RVA: 0xB43310
        public void UnPackBlock(){} // RVA: 0xA2C4D00
        public void PackBlock(){} // RVA: 0xA2C4E40
        public void EncryptBlock(){} // RVA: 0xA2C4F00
        public void DecryptBlock(){} // RVA: 0xA2C5150
        public void .cctor(){} // RVA: 0xA2C53B0
    }

    public class RsaBlindedEngine : Object
    {
        public object core;
        public object key;
        public object random;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_AlgorithmName(){} // RVA: 0xA2C5BB0
        public void Init(){} // RVA: 0xA2C5BF0
        public void GetInputBlockSize(){} // RVA: 0xA2C60F0
        public void GetOutputBlockSize(){} // RVA: 0xA2C6140
        public void ProcessBlock(){} // RVA: 0xA2C6190
    }

    public class RsaBlindingEngine : Object
    {
        public object core;
        public object key;
        public object blindingFactor;
        public object forEncryption;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_AlgorithmName(){} // RVA: 0xA2C6560
        public void Init(){} // RVA: 0xA2C65A0
        public void GetInputBlockSize(){} // RVA: 0xA2C67E0
        public void GetOutputBlockSize(){} // RVA: 0xA2C6830
        public void ProcessBlock(){} // RVA: 0xA2C6880
        public void BlindMessage(){} // RVA: 0xA2C6A90
        public void UnblindMessage(){} // RVA: 0xA2C6B80
    }

    public class RsaCoreEngine : Object
    {
        public object key;
        public object forEncryption;
        public object bitSize;

        // ── Methods ──
        public void CheckInitialised(){} // RVA: 0xA2C6C60
        public void Init(){} // RVA: 0xA2C6CD0
        public void GetInputBlockSize(){} // RVA: 0xA2C6F00
        public void GetOutputBlockSize(){} // RVA: 0xA2C6F90
        public void ConvertInput(){} // RVA: 0xA2C7020
        public void ConvertOutput(){} // RVA: 0xA2C71E0
        public void ProcessBlock(){} // RVA: 0xA2C72F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RsaEngine : Object
    {
        public object core;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_AlgorithmName(){} // RVA: 0xA2C75B0
        public void Init(){} // RVA: 0xA2C75F0
        public void GetInputBlockSize(){} // RVA: 0xA2C7660
        public void GetOutputBlockSize(){} // RVA: 0xA2C76B0
        public void ProcessBlock(){} // RVA: 0xA2C7700
    }

    public class SM2Engine : Object
    {
        public object mDigest;
        public object mForEncryption;
        public object mECKey;
        public object mECParams;
        public object mCurveLength;
        public object mRandom;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Init(){} // RVA: 0xA2D1A00
        public void ProcessBlock(){} // RVA: 0xA2D1EC0
        public void CreateBasePointMultiplier(){} // RVA: 0xA2D1EF0
        public void Encrypt(){} // RVA: 0xA2D1F30
        public void Decrypt(){} // RVA: 0xA2D2530
        public void NotEncrypted(){} // RVA: 0xA2D2AA0
        public void Kdf(){} // RVA: 0xA2D2B10
        public void Xor(){} // RVA: 0xA2D2FD0
        public void NextK(){} // RVA: 0xA2D3040
        public void AddFieldElement(){} // RVA: 0xA2D3110
    }

    public class SM4Engine : Object
    {
        public object BlockSize;
        public object Sbox;
        public object CK;
        public object FK;
        public object rk;

        // ── Methods ──
        public void tau(){} // RVA: 0xA2D31A0
        public void L_ap(){} // RVA: 0xA2D32A0
        public void T_ap(){} // RVA: 0xA2D32C0
        public void ExpandKey(){} // RVA: 0xA2D3330
        public void L(){} // RVA: 0xA2D3B60
        public void T(){} // RVA: 0xA2D3B90
        public void Init(){} // RVA: 0xA2D3C10
        public void get_AlgorithmName(){} // RVA: 0xA2D3DE0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void ProcessBlock(){} // RVA: 0xA2D3E20
        public void Reset(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA2D4550
    }

    public class Salsa20Engine : Object
    {
        public object DEFAULT_ROUNDS;
        public object StateSize;
        public object TAU_SIGMA;
        public object sigma;
        public object tau;
        public object rounds;
        public object index;
        public object engineState;
        public object x;
        public object keyStream;
        public object initialised;
        public object cW0;
        public object cW1;
        public object cW2;

        // ── Methods ──
        public void PackTauOrSigma(){} // RVA: 0xA2C77A0
        public void .ctor(){} // RVA: 0xA2C7970
        public void Init(){} // RVA: 0xA2C7B40
        public void get_NonceSize(){} // RVA: 0x17FCE50
        public void get_AlgorithmName(){} // RVA: 0xA2C7EE0
        public void ReturnByte(){} // RVA: 0xA2C7FB0
        public void AdvanceCounter(){} // RVA: 0xA2C8090
        public void ProcessBytes(){} // RVA: 0xA2C80D0
        public void Reset(){} // RVA: 0xA2C83C0
        public void ResetCounter(){} // RVA: 0xA2C83E0
        public void SetKey(){} // RVA: 0xA2C8420
        public void GenerateKeyStream(){} // RVA: 0xA2C8820
        public void SalsaCore(){} // RVA: 0xA2C8940
        public void R(){} // RVA: 0x69104D0
        public void ResetLimitCounter(){} // RVA: 0xA2C90F0
        public void LimitExceeded(){} // RVA: 0xA2C9120
        public void .cctor(){} // RVA: 0xA2C9150
    }

    public class SeedEngine : Object
    {
        public object BlockSize;
        public object SS0;
        public object SS1;
        public object SS2;
        public object SS3;
        public object KC;
        public object wKey;
        public object forEncryption;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2C9490
        public void get_AlgorithmName(){} // RVA: 0xA2C9590
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void ProcessBlock(){} // RVA: 0xA2C95D0
        public void Reset(){} // RVA: 0xB43310
        public void createWorkingKey(){} // RVA: 0xA2C9920
        public void extractW1(){} // RVA: 0x44E8220
        public void extractW0(){} // RVA: 0xA2C9B80
        public void rotateLeft8(){} // RVA: 0xA2C9B90
        public void rotateRight8(){} // RVA: 0xA2C9BA0
        public void bytesToLong(){} // RVA: 0xA2C9BB0
        public void longToBytes(){} // RVA: 0xA2C9C00
        public void G(){} // RVA: 0xA2C9C50
        public void F(){} // RVA: 0xA2C9D40
        public void phaseCalc1(){} // RVA: 0xA2C9E00
        public void phaseCalc2(){} // RVA: 0xA2C9E50
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA2C9EE0
    }

    public class SeedWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2CA260
    }

    public class SerpentEngine : SerpentEngineBase
    {
        // ── Methods ──
        public void MakeWorkingKey(){} // RVA: 0xA2CA2B0
        public void EncryptBlock(){} // RVA: 0xA2CC150
        public void DecryptBlock(){} // RVA: 0xA2CDE00
        public void .ctor(){} // RVA: 0xA2CFCB0
    }

    public class SerpentEngineBase : Object
    {
        public object BlockSize;
        public object ROUNDS;
        public object PHI;
        public object encrypting;
        public object wKey;
        public object X0;
        public object X1;
        public object X2;
        public object X3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Init(){} // RVA: 0xA2CFD00
        public void get_AlgorithmName(){} // RVA: 0xA2CFEE0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0xA2CFF20
        public void ProcessBlock(){} // RVA: 0xA2CFF80
        public void Reset(){} // RVA: 0xB43310
        public void RotateLeft(){} // RVA: 0x69104D0
        public void RotateRight(){} // RVA: 0x67114B0
        public void Sb0(){} // RVA: 0xA2D01D0
        public void Ib0(){} // RVA: 0xA2D0230
        public void Sb1(){} // RVA: 0xA2D02A0
        public void Ib1(){} // RVA: 0xA2D0300
        public void Sb2(){} // RVA: 0xA2D0360
        public void Ib2(){} // RVA: 0xA2D03E0
        public void Sb3(){} // RVA: 0xA2D0450
        public void Ib3(){} // RVA: 0xA2D04D0
        public void Sb4(){} // RVA: 0xA2D0530
        public void Ib4(){} // RVA: 0xA2D0590
        public void Sb5(){} // RVA: 0xA2D0600
        public void Ib5(){} // RVA: 0xA2D0670
        public void Sb6(){} // RVA: 0xA2D06E0
        public void Ib6(){} // RVA: 0xA2D0740
        public void Sb7(){} // RVA: 0xA2D07B0
        public void Ib7(){} // RVA: 0xA2D0820
        public void LT(){} // RVA: 0xA2D08A0
        public void InverseLT(){} // RVA: 0xA2D0980
        public void MakeWorkingKey(){} // RVA: 0x87C540
        public void EncryptBlock(){} // RVA: 0x89C370
        public void DecryptBlock(){} // RVA: 0x89C370
        public void .cctor(){} // RVA: 0xA2D0A60
    }

    public class SkipjackEngine : Object
    {
        public object BLOCK_SIZE;
        public object ftable;
        public object key0;
        public object key1;
        public object key2;
        public object key3;
        public object encrypting;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2D0AA0
        public void get_AlgorithmName(){} // RVA: 0xA2D0F20
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void ProcessBlock(){} // RVA: 0xA2D0F60
        public void Reset(){} // RVA: 0xB43310
        public void G(){} // RVA: 0xA2D1130
        public void EncryptBlock(){} // RVA: 0xA2D12A0
        public void H(){} // RVA: 0xA2D14D0
        public void DecryptBlock(){} // RVA: 0xA2D1640
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA2D1880
    }

    public class TeaEngine : Object
    {
        public object rounds;
        public object block_size;
        public object delta;
        public object d_sum;
        public object _a;
        public object _b;
        public object _c;
        public object _d;
        public object _initialised;
        public object _forEncryption;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D0B040
        public void get_AlgorithmName(){} // RVA: 0xA2D47A0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void Init(){} // RVA: 0xA2D47E0
        public void ProcessBlock(){} // RVA: 0xA2D4940
        public void Reset(){} // RVA: 0xB43310
        public void setKey(){} // RVA: 0xA2D4B10
        public void encryptBlock(){} // RVA: 0xA2D4C40
        public void decryptBlock(){} // RVA: 0xA2D4E60
    }

    public class ThreefishEngine : Object
    {
        public object BLOCKSIZE_256;
        public object BLOCKSIZE_512;
        public object BLOCKSIZE_1024;
        public object TWEAK_SIZE_BYTES;
        public object TWEAK_SIZE_WORDS;
        public object ROUNDS_256;
        public object ROUNDS_512;
        public object ROUNDS_1024;
        public object MAX_ROUNDS;
        public object C_240;
        public object MOD9;
        public object MOD17;
        public object MOD5;
        public object MOD3;
        public object blocksizeBytes;
        public object blocksizeWords;
        public object currentBlock;
        public object t;
        public object kw;
        public object cipher;
        public object forEncryption;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA2D5080
        public void .ctor(){} // RVA: 0xA2D5440
        public void Init(){} // RVA: 0xA2D5BE0
        public void SetKey(){} // RVA: 0xA2D5EC0
        public void SetTweak(){} // RVA: 0xA2D6010
        public void get_AlgorithmName(){} // RVA: 0xA2D6180
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0xB8F8F0
        public void Reset(){} // RVA: 0xB43310
        public void ProcessBlock(){} // RVA: 0xA2D6450
        public void BytesToWord(){} // RVA: 0xA2D65D0
        public void WordToBytes(){} // RVA: 0xA2D6720
        public void RotlXor(){} // RVA: 0xA2D6840
        public void XorRotr(){} // RVA: 0xA2D6860
    }

    public class TnepresEngine : SerpentEngineBase
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA2DA330
        public void MakeWorkingKey(){} // RVA: 0xA2DA370
        public void EncryptBlock(){} // RVA: 0xA2DC1D0
        public void DecryptBlock(){} // RVA: 0xA2DDE90
        public void .ctor(){} // RVA: 0xA2DFD50
    }

    public class TwofishEngine : Object
    {
        public object P;
        public object P_00;
        public object P_01;
        public object P_02;
        public object P_03;
        public object P_04;
        public object P_10;
        public object P_11;
        public object P_12;
        public object P_13;
        public object P_14;
        public object P_20;
        public object P_21;
        public object P_22;
        public object P_23;
        public object P_24;
        public object P_30;
        public object P_31;
        public object P_32;
        public object P_33;
        public object P_34;
        public object GF256_FDBK;
        public object GF256_FDBK_2;
        public object GF256_FDBK_4;
        public object RS_GF_FDBK;
        public object ROUNDS;
        public object MAX_ROUNDS;
        public object BLOCK_SIZE;
        public object MAX_KEY_BITS;
        public object INPUT_WHITEN;
        public object OUTPUT_WHITEN;
        public object ROUND_SUBKEYS;
        public object TOTAL_SUBKEYS;
        public object SK_STEP;
        public object SK_BUMP;
        public object SK_ROTL;
        public object encrypting;
        public object gMDS0;
        public object gMDS1;
        public object gMDS2;
        public object gMDS3;
        public object gSubKeys;
        public object gSBox;
        public object k64Cnt;
        public object workingKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2DFDA0
        public void Init(){} // RVA: 0xA2E02E0
        public void get_AlgorithmName(){} // RVA: 0xA2E04B0
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void ProcessBlock(){} // RVA: 0xA2E04F0
        public void Reset(){} // RVA: 0xA2E06B0
        public void GetBlockSize(){} // RVA: 0x2AFB680
        public void SetKey(){} // RVA: 0xA2E06D0
        public void EncryptBlock(){} // RVA: 0xA2E1380
        public void DecryptBlock(){} // RVA: 0xA2E1A60
        public void F32(){} // RVA: 0xA2E2130
        public void RS_MDS_Encode(){} // RVA: 0xA2E2700
        public void RS_rem(){} // RVA: 0xA2E27F0
        public void LFSR1(){} // RVA: 0xA2E2850
        public void LFSR2(){} // RVA: 0xA2E2870
        public void Mx_X(){} // RVA: 0xA2E28A0
        public void Mx_Y(){} // RVA: 0xA2E28D0
        public void M_b0(){} // RVA: 0x18AF6A0
        public void M_b1(){} // RVA: 0xA2E2910
        public void M_b2(){} // RVA: 0xA2E2920
        public void M_b3(){} // RVA: 0xA2E2930
        public void Fe32_0(){} // RVA: 0xA2E2940
        public void Fe32_3(){} // RVA: 0xA2E29D0
        public void BytesTo32Bits(){} // RVA: 0x6744BE0
        public void Bits32ToBytes(){} // RVA: 0x67405D0
        public void .cctor(){} // RVA: 0xA2E2A60
    }

    public class VmpcEngine : Object
    {
        public object n;
        public object P;
        public object s;
        public object workingIV;
        public object workingKey;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA2E2B50
        public void Init(){} // RVA: 0xA2E2B90
        public void InitKey(){} // RVA: 0xA2E2E60
        public void ProcessBytes(){} // RVA: 0xA2E3100
        public void Reset(){} // RVA: 0xA2E3360
        public void ReturnByte(){} // RVA: 0xA2E3380
        public void .ctor(){} // RVA: 0xB43310
    }

    public class VmpcKsa3Engine : VmpcEngine
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA2E3480
        public void InitKey(){} // RVA: 0xA2E34C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class XSalsa20Engine : Salsa20Engine
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0xA2E3840
        public void get_NonceSize(){} // RVA: 0x2AFB690
        public void SetKey(){} // RVA: 0xA2E3880
        public void .ctor(){} // RVA: 0xA2E3D00
    }

    public class XteaEngine : Object
    {
        public object rounds;
        public object block_size;
        public object delta;
        public object _S;
        public object _sum0;
        public object _sum1;
        public object _initialised;
        public object _forEncryption;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA2E3DA0
        public void get_AlgorithmName(){} // RVA: 0xA2E3F10
        public void get_IsPartialBlockOkay(){} // RVA: 0xB43320
        public void GetBlockSize(){} // RVA: 0x17FCE50
        public void Init(){} // RVA: 0xA2E3F50
        public void ProcessBlock(){} // RVA: 0xA2E4200
        public void Reset(){} // RVA: 0xB43310
        public void setKey(){} // RVA: 0xA2E43D0
        public void encryptBlock(){} // RVA: 0xA2E4530
        public void decryptBlock(){} // RVA: 0xA2E4770
    }

}