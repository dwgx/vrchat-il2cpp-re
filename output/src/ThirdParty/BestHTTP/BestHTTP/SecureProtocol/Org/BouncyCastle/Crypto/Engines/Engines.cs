// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
// Classes: 56
// Methods: 673

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
    public class AesEngine : Object
    {
        public byte[] S;
        public byte[] Si; // 0x8

        // ── Methods ──
        public void Shift(){} // RVA: 0x7FFE867D9B10
        public void FFmulX(){} // RVA: 0x7FFE8A048C60
        public void FFmulX2(){} // RVA: 0x7FFE8A048C80
        public void Inv_Mcol(){} // RVA: 0x7FFE8A048CB0
        public void SubWord(){} // RVA: 0x7FFE8A048D70
        public void GenerateWorkingKey(){} // RVA: 0x7FFE8A048E50
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8A04A1A0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A04A470
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void ProcessBlock(){} // RVA: 0x7FFE8A04A4B0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void UnPackBlock(){} // RVA: 0x7FFE8A04A680
        public void PackBlock(){} // RVA: 0x7FFE8A04A840
        public void EncryptBlock(){} // RVA: 0x7FFE8A04A9E0
        public void DecryptBlock(){} // RVA: 0x7FFE8A04B7D0
        public void .cctor(){} // RVA: 0x7FFE8A04C590
    }

    public class AesFastEngine : Object
    {
        public byte[] S;
        public byte[] Si; // 0x8

        // ── Methods ──
        public void Shift(){} // RVA: 0x7FFE867D9B10
        public void FFmulX(){} // RVA: 0x7FFE8A048C60
        public void FFmulX2(){} // RVA: 0x7FFE8A048C80
        public void Inv_Mcol(){} // RVA: 0x7FFE8A04C920
        public void SubWord(){} // RVA: 0x7FFE8A04C9E0
        public void GenerateWorkingKey(){} // RVA: 0x7FFE8A04CAC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8A04DE10
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A04DF90
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void ProcessBlock(){} // RVA: 0x7FFE8A04DFD0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void UnPackBlock(){} // RVA: 0x7FFE8A04A680
        public void PackBlock(){} // RVA: 0x7FFE8A04A840
        public void EncryptBlock(){} // RVA: 0x7FFE8A04E1A0
        public void DecryptBlock(){} // RVA: 0x7FFE8A04EDB0
        public void .cctor(){} // RVA: 0x7FFE8A04F9C0
    }

    public class AesLightEngine : Object
    {
        public byte[] S;
        public byte[] Si; // 0x8

        // ── Methods ──
        public void Shift(){} // RVA: 0x7FFE867D9B10
        public void FFmulX(){} // RVA: 0x7FFE8A048C60
        public void FFmulX2(){} // RVA: 0x7FFE8A048C80
        public void Mcol(){} // RVA: 0x7FFE8A050110
        public void Inv_Mcol(){} // RVA: 0x7FFE8A0501A0
        public void SubWord(){} // RVA: 0x7FFE8A050260
        public void GenerateWorkingKey(){} // RVA: 0x7FFE8A050340
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8A051690
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A051810
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void ProcessBlock(){} // RVA: 0x7FFE8A051850
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void UnPackBlock(){} // RVA: 0x7FFE8A04A680
        public void PackBlock(){} // RVA: 0x7FFE8A04A840
        public void EncryptBlock(){} // RVA: 0x7FFE8A051A20
        public void DecryptBlock(){} // RVA: 0x7FFE8A052C70
        public void .cctor(){} // RVA: 0x7FFE8A053950
    }

    public class AesWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A053B90
    }

    public class BlowfishEngine : Object
    {
        public uint[] KP;
        public uint[] KS0; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A053BE0
        public void Init(){} // RVA: 0x7FFE8A053E80
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A054030
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void ProcessBlock(){} // RVA: 0x7FFE8A054070
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void F(){} // RVA: 0x7FFE8A054230
        public void ProcessTable(){} // RVA: 0x7FFE8A0542C0
        public void SetKey(){} // RVA: 0x7FFE8A054470
        public void EncryptBlock(){} // RVA: 0x7FFE8A054810
        public void DecryptBlock(){} // RVA: 0x7FFE8A054BD0
        public void .cctor(){} // RVA: 0x7FFE8A054F90
    }

    public class CamelliaEngine : Object
    {
        public bool initialised; // 0x10
        public bool _keyIs128; // 0x11

        // ── Methods ──
        public void rightRotate(){} // RVA: 0x7FFE8A055350
        public void leftRotate(){} // RVA: 0x7FFE8A055370
        public void roldq(){} // RVA: 0x7FFE8A055390
        public void decroldq(){} // RVA: 0x7FFE8A055550
        public void roldqo32(){} // RVA: 0x7FFE8A055720
        public void decroldqo32(){} // RVA: 0x7FFE8A0558E0
        public void bytes2uint(){} // RVA: 0x7FFE8A055AB0
        public void uint2bytes(){} // RVA: 0x7FFE8A055B00
        public void camelliaF2(){} // RVA: 0x7FFE8A055B40
        public void camelliaFLs(){} // RVA: 0x7FFE8A055EF0
        public void setKey(){} // RVA: 0x7FFE8A056010
        public void processBlock128(){} // RVA: 0x7FFE8A0576B0
        public void processBlock192or256(){} // RVA: 0x7FFE8A057BE0
        public void .ctor(){} // RVA: 0x7FFE8A058160
        public void Init(){} // RVA: 0x7FFE8A058330
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A058450
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void ProcessBlock(){} // RVA: 0x7FFE8A058490
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A058640
    }

    public class CamelliaLightEngine : Object
    {
        public int BLOCK_SIZE;
        public bool initialised; // 0x10

        // ── Methods ──
        public void rightRotate(){} // RVA: 0x7FFE8A055350
        public void leftRotate(){} // RVA: 0x7FFE8A055370
        public void roldq(){} // RVA: 0x7FFE8A055390
        public void decroldq(){} // RVA: 0x7FFE8A055550
        public void roldqo32(){} // RVA: 0x7FFE8A055720
        public void decroldqo32(){} // RVA: 0x7FFE8A0558E0
        public void bytes2uint(){} // RVA: 0x7FFE8A055AB0
        public void uint2bytes(){} // RVA: 0x7FFE8A055B00
        public void lRot8(){} // RVA: 0x7FFE8A0589C0
        public void sbox2(){} // RVA: 0x7FFE8A0589E0
        public void sbox3(){} // RVA: 0x7FFE8A058A70
        public void sbox4(){} // RVA: 0x7FFE8A058B00
        public void camelliaF2(){} // RVA: 0x7FFE8A058B90
        public void camelliaFLs(){} // RVA: 0x7FFE8A058F30
        public void setKey(){} // RVA: 0x7FFE8A059050
        public void processBlock128(){} // RVA: 0x7FFE8A05A710
        public void processBlock192or256(){} // RVA: 0x7FFE8A05AC80
        public void .ctor(){} // RVA: 0x7FFE8A05B250
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A05B420
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void Init(){} // RVA: 0x7FFE8A05B460
        public void ProcessBlock(){} // RVA: 0x7FFE8A05B580
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A05B730
    }

    public class CamelliaWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A05B8E0
    }

    public class Cast5Engine : Object
    {
        public uint[] S1;
        public uint[] S2; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A05B940
        public void Init(){} // RVA: 0x7FFE8A05BA90
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A05BC70
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void ProcessBlock(){} // RVA: 0x7FFE8A05BCB0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void SetKey(){} // RVA: 0x7FFE8A05BEB0
        public void EncryptBlock(){} // RVA: 0x7FFE8A061520
        public void DecryptBlock(){} // RVA: 0x7FFE8A061750
        public void F1(){} // RVA: 0x7FFE8A061980
        public void F2(){} // RVA: 0x7FFE8A061AA0
        public void F3(){} // RVA: 0x7FFE8A061BC0
        public void CAST_Encipher(){} // RVA: 0x7FFE8A061CE0
        public void CAST_Decipher(){} // RVA: 0x7FFE8A061F20
        public void Bits32ToInts(){} // RVA: 0x7FFE8A062160
        public void IntsTo32bits(){} // RVA: 0x7FFE8A0621E0
        public void .cctor(){} // RVA: 0x7FFE8A062260
    }

    public class Cast6Engine : Cast5Engine
    {
        public int ROUNDS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0627E0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A062A50
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void SetKey(){} // RVA: 0x7FFE8A062A90
        public void EncryptBlock(){} // RVA: 0x7FFE8A063660
        public void DecryptBlock(){} // RVA: 0x7FFE8A063A40
        public void CAST_Encipher(){} // RVA: 0x7FFE8A063E20
        public void CAST_Decipher(){} // RVA: 0x7FFE8A0641A0
    }

    public class ChaCha7539Engine : Salsa20Engine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A064520
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0645C0
        public void get_NonceSize(){} // RVA: 0x7FFE835C1DE0
        public void AdvanceCounter(){} // RVA: 0x7FFE8A064610
        public void ResetCounter(){} // RVA: 0x7FFE8A064690
        public void SetKey(){} // RVA: 0x7FFE8A0646C0
        public void GenerateKeyStream(){} // RVA: 0x7FFE8A0648D0
    }

    public class ChaChaEngine : Salsa20Engine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A064A30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A064A90
        public void AdvanceCounter(){} // RVA: 0x7FFE8A064AE0
        public void ResetCounter(){} // RVA: 0x7FFE8A064B20
        public void SetKey(){} // RVA: 0x7FFE8A064B60
        public void GenerateKeyStream(){} // RVA: 0x7FFE8A0648D0
        public void ChachaCore(){} // RVA: 0x7FFE8A064E20
    }

    public class DesEdeEngine : DesEngine
    {
        public int[] workingKey1; // 0x18

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A065590
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0659F0
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void ProcessBlock(){} // RVA: 0x7FFE8A065A30
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE8A065CC0
    }

    public class DesEdeWrapEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.CbcBlockCipher engine; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A065D10
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A066360
        public void Wrap(){} // RVA: 0x7FFE8A0663A0
        public void Unwrap(){} // RVA: 0x7FFE8A066800
        public void CalculateCmsKeyChecksum(){} // RVA: 0x7FFE8A066E90
        public void CheckCmsKeyChecksum(){} // RVA: 0x7FFE8A066F80
        public void reverse(){} // RVA: 0x7FFE8A067060
        public void .ctor(){} // RVA: 0x7FFE8A0670F0
        public void .cctor(){} // RVA: 0x7FFE8A067210
    }

    public class DesEngine : Object
    {
        public int BLOCK_SIZE;
        public int[] workingKey; // 0x10

        // ── Methods ──
        public void GetWorkingKey(){} // RVA: 0x7FFE81116380
        public void Init(){} // RVA: 0x7FFE8A0672F0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0674C0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void ProcessBlock(){} // RVA: 0x7FFE8A067500
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void GenerateWorkingKey(){} // RVA: 0x7FFE8A0676D0
        public void DesFunc(){} // RVA: 0x7FFE8A067C60
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A068340
    }

    public class Dstu7624Engine : Object
    {
        public ulong[] internalState; // 0x10
        public ulong[] workingKey; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A068C00
        public void Init(){} // RVA: 0x7FFE8A068D00
        public void WorkingKeyExpandKT(){} // RVA: 0x7FFE8A0691E0
        public void WorkingKeyExpandEven(){} // RVA: 0x7FFE8A0694C0
        public void WorkingKeyExpandOdd(){} // RVA: 0x7FFE8A069970
        public void ProcessBlock(){} // RVA: 0x7FFE8A0699E0
        public void EncryptionRound(){} // RVA: 0x7FFE8A069D70
        public void DecryptionRound(){} // RVA: 0x7FFE8A069E30
        public void DecryptBlock_128(){} // RVA: 0x7FFE8A069EF0
        public void EncryptBlock_128(){} // RVA: 0x7FFE8A06A480
        public void SubBytes(){} // RVA: 0x7FFE8A06AAF0
        public void InvSubBytes(){} // RVA: 0x7FFE8A06AD90
        public void ShiftRows(){} // RVA: 0x7FFE8A06B030
        public void InvShiftRows(){} // RVA: 0x7FFE8A06B4A0
        public void AddRoundKey(){} // RVA: 0x7FFE8A06B910
        public void SubRoundKey(){} // RVA: 0x7FFE8A06B980
        public void XorRoundKey(){} // RVA: 0x7FFE8A06B9F0
        public void MixColumn(){} // RVA: 0x7FFE8A06BA60
        public void MixColumns(){} // RVA: 0x7FFE8A06BB90
        public void MixColumnInv(){} // RVA: 0x7FFE8A06BC40
        public void MixColumnsInv(){} // RVA: 0x7FFE8A06BE50
        public void MulX(){} // RVA: 0x7FFE8A06BF00
        public void MulX2(){} // RVA: 0x7FFE8A06BF30
        public void Rotate(){} // RVA: 0x7FFE8A06BF80
        public void RotateLeft(){} // RVA: 0x7FFE8A06BFA0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A06C2E0
        public void GetBlockSize(){} // RVA: 0x7FFE8A06C320
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void Reset(){} // RVA: 0x7FFE8A06C330
        public void .cctor(){} // RVA: 0x7FFE8A06C360
    }

    public class Dstu7624WrapEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter param; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A06C8C0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A06C9E0
        public void Init(){} // RVA: 0x7FFE8A06CA20
        public void Wrap(){} // RVA: 0x7FFE8A06CBE0
        public void Unwrap(){} // RVA: 0x7FFE8A06D420
    }

    public class ElGamalEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters key; // 0x10

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A06DDC0
        public void Init(){} // RVA: 0x7FFE8A06DE00
        public void GetInputBlockSize(){} // RVA: 0x7FFE8A06E2F0
        public void GetOutputBlockSize(){} // RVA: 0x7FFE8A06E320
        public void ProcessBlock(){} // RVA: 0x7FFE8A06E350
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Gost28147Engine : Object
    {
        public int BlockSize;
        public int[] workingKey; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A06E930
        public void AddSBox(){} // RVA: 0x7FFE8A06F0E0
        public void .ctor(){} // RVA: 0x7FFE8A06F1C0
        public void Init(){} // RVA: 0x7FFE8A06F270
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A06F6A0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void ProcessBlock(){} // RVA: 0x7FFE8A06F6E0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void generateWorkingKey(){} // RVA: 0x7FFE8A06F890
        public void Gost28147_mainStep(){} // RVA: 0x7FFE8A06FA00
        public void Gost28147Func(){} // RVA: 0x7FFE8A06FB70
        public void bytesToint(){} // RVA: 0x7FFE8A02A4F0
        public void intTobytes(){} // RVA: 0x7FFE8A02A570
        public void GetSBox(){} // RVA: 0x7FFE8A06FEC0
        public void GetSBoxName(){} // RVA: 0x7FFE8A0700A0
    }

    public class HC128Engine : Object
    {
        public uint[] p; // 0x10

        // ── Methods ──
        public void F1(){} // RVA: 0x7FFE8A070420
        public void F2(){} // RVA: 0x7FFE8A070450
        public void G1(){} // RVA: 0x7FFE8A070480
        public void G2(){} // RVA: 0x7FFE8A0704B0
        public void RotateLeft(){} // RVA: 0x7FFE869D7C70
        public void RotateRight(){} // RVA: 0x7FFE867D9B10
        public void H1(){} // RVA: 0x7FFE8A0704E0
        public void H2(){} // RVA: 0x7FFE8A070530
        public void Mod1024(){} // RVA: 0x7FFE8A070580
        public void Mod512(){} // RVA: 0x7FFE8A070590
        public void Dim(){} // RVA: 0x7FFE8A0705A0
        public void Step(){} // RVA: 0x7FFE8A0705B0
        public void Init(){} // RVA: 0x7FFE8A070BD0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A070B90
        public void GetByte(){} // RVA: 0x7FFE8A070F40
        public void ProcessBytes(){} // RVA: 0x7FFE8A070FD0
        public void Reset(){} // RVA: 0x7FFE8A071270
        public void ReturnByte(){} // RVA: 0x7FFE8A071280
        public void .ctor(){} // RVA: 0x7FFE8A0712A0
    }

    public class HC256Engine : Object
    {
        public uint[] p; // 0x10

        // ── Methods ──
        public void Step(){} // RVA: 0x7FFE8A071420
        public void Init(){} // RVA: 0x7FFE8A071CA0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A071C60
        public void GetByte(){} // RVA: 0x7FFE8A072010
        public void ProcessBytes(){} // RVA: 0x7FFE8A0720A0
        public void Reset(){} // RVA: 0x7FFE8A072340
        public void ReturnByte(){} // RVA: 0x7FFE8A072350
        public void RotateRight(){} // RVA: 0x7FFE867D9B10
        public void .ctor(){} // RVA: 0x7FFE8A072370
    }

    public class IdeaEngine : Object
    {
        public int BLOCK_SIZE;
        public int[] workingKey; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8A0724F0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0726A0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void ProcessBlock(){} // RVA: 0x7FFE8A0726E0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void BytesToWord(){} // RVA: 0x7FFE8A072890
        public void WordToBytes(){} // RVA: 0x7FFE8A0728D0
        public void Mul(){} // RVA: 0x7FFE8A072910
        public void IdeaFunc(){} // RVA: 0x7FFE8A072A10
        public void ExpandKey(){} // RVA: 0x7FFE8A072DE0
        public void MulInv(){} // RVA: 0x7FFE8A072FD0
        public void AddInv(){} // RVA: 0x7FFE8A073120
        public void InvertKey(){} // RVA: 0x7FFE8A073180
        public void GenerateWorkingKey(){} // RVA: 0x7FFE8A0736B0
        public void .cctor(){} // RVA: 0x7FFE8A0736F0
    }

    public class IesEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A073940 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8A073B80
        public void DecryptBlock(){} // RVA: 0x7FFE8A073D70
        public void EncryptBlock(){} // RVA: 0x7FFE8A0742F0
        public void GenerateKdfBytes(){} // RVA: 0x7FFE8A0747A0
        public void ProcessBlock(){} // RVA: 0x7FFE8A074860
    }

    public class IsaacEngine : Object
    {
        public int sizeL;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A0749D0
        public void ReturnByte(){} // RVA: 0x7FFE8A074B20
        public void ProcessBytes(){} // RVA: 0x7FFE8A074BD0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A074E30
        public void Reset(){} // RVA: 0x7FFE8A074E70
        public void setKey(){} // RVA: 0x7FFE8A074E80
        public void isaac(){} // RVA: 0x7FFE8A075410
        public void mix(){} // RVA: 0x7FFE8A075580
        public void .ctor(){} // RVA: 0x7FFE8A0757C0
        public void .cctor(){} // RVA: 0x7FFE8A075890
    }

    public class NaccacheSternEngine : Object
    {
        public bool forEncryption; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.NaccacheSternKeyParameters key; // 0x18

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0758F0
        public void Init(){} // RVA: 0x7FFE8A075930
        public void set_Debug(){} // RVA: 0x7FFE810FB310
        public void GetInputBlockSize(){} // RVA: 0x7FFE8A075F20
        public void GetOutputBlockSize(){} // RVA: 0x7FFE8A075F80
        public void ProcessBlock(){} // RVA: 0x7FFE8A075FE0
        public void Encrypt(){} // RVA: 0x7FFE8A076760
        public void AddCryptedBlocks(){} // RVA: 0x7FFE8A076850
        public void ProcessData(){} // RVA: 0x7FFE8A076B10
        public void chineseRemainder(){} // RVA: 0x7FFE8A076D00
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class NoekeonEngine : Object
    {
        public int GenericSize;
        public uint[] nullVector;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0772C0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A077430
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void Init(){} // RVA: 0x7FFE8A077470
        public void ProcessBlock(){} // RVA: 0x7FFE8A0775E0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void setKey(){} // RVA: 0x7FFE8A0777B0
        public void encryptBlock(){} // RVA: 0x7FFE8A077940
        public void decryptBlock(){} // RVA: 0x7FFE8A078190
        public void gamma(){} // RVA: 0x7FFE8A078B30
        public void theta(){} // RVA: 0x7FFE8A078BE0
        public void pi1(){} // RVA: 0x7FFE8A078CD0
        public void pi2(){} // RVA: 0x7FFE8A078D30
        public void rotl(){} // RVA: 0x7FFE8A078D90
        public void .cctor(){} // RVA: 0x7FFE8A078DB0
    }

    public class NullEngine : Object
    {
        public bool initialised; // 0x10
        public int BlockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE814B8390
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A078F20
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE811E0850
        public void GetBlockSize(){} // RVA: 0x7FFE811EDAF0
        public void ProcessBlock(){} // RVA: 0x7FFE8A078F60
        public void Reset(){} // RVA: 0x7FFE810FB310
    }

    public class RC2Engine : Object
    {
        public byte[] piTable;
        public int BLOCK_SIZE;

        // ── Methods ──
        public void GenerateWorkingKey(){} // RVA: 0x7FFE8A079130
        public void Init(){} // RVA: 0x7FFE8A079420
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0796E0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void ProcessBlock(){} // RVA: 0x7FFE8A079720
        public void RotateWordLeft(){} // RVA: 0x7FFE8A0798E0
        public void EncryptBlock(){} // RVA: 0x7FFE8A079900
        public void DecryptBlock(){} // RVA: 0x7FFE8A079E80
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A07A370
    }

    public class RC2WrapEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.CbcBlockCipher engine; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A07A450
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A07AAA0
        public void Wrap(){} // RVA: 0x7FFE8A07AAE0
        public void Unwrap(){} // RVA: 0x7FFE8A07B0E0
        public void CalculateCmsKeyChecksum(){} // RVA: 0x7FFE8A07BA00
        public void CheckCmsKeyChecksum(){} // RVA: 0x7FFE8A07BAF0
        public void .ctor(){} // RVA: 0x7FFE8A07BBD0
        public void .cctor(){} // RVA: 0x7FFE8A07BCF0
    }

    public class RC4Engine : Object
    {
        public int STATE_LENGTH;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A07BDD0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A07BF70
        public void ReturnByte(){} // RVA: 0x7FFE8A07BFB0
        public void ProcessBytes(){} // RVA: 0x7FFE8A07C090
        public void Reset(){} // RVA: 0x7FFE8A07C2E0
        public void SetKey(){} // RVA: 0x7FFE8A07C2F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A07C550
    }

    public class RC532Engine : Object
    {
        public int _noRounds; // 0x10
        public int[] _S; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A07C590
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A07C5A0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void Init(){} // RVA: 0x7FFE8A07C5E0
        public void ProcessBlock(){} // RVA: 0x7FFE8A07C890
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void SetKey(){} // RVA: 0x7FFE8A07C8C0
        public void EncryptBlock(){} // RVA: 0x7FFE8A07CBE0
        public void DecryptBlock(){} // RVA: 0x7FFE8A07CE50
        public void RotateLeft(){} // RVA: 0x7FFE8A07D0E0
        public void RotateRight(){} // RVA: 0x7FFE8A07D100
        public void BytesToWord(){} // RVA: 0x7FFE8680C480
        public void WordToBytes(){} // RVA: 0x7FFE86807EC0
        public void .cctor(){} // RVA: 0x7FFE8A07D120
    }

    public class RC564Engine : Object
    {
        public int wordSize;
        public int bytesPerWord; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A07C590
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A07D180
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE8A07D1C0
        public void Init(){} // RVA: 0x7FFE8A07D220
        public void ProcessBlock(){} // RVA: 0x7FFE8A07D420
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void SetKey(){} // RVA: 0x7FFE8A07D450
        public void EncryptBlock(){} // RVA: 0x7FFE8A07D8A0
        public void DecryptBlock(){} // RVA: 0x7FFE8A07DC90
        public void RotateLeft(){} // RVA: 0x7FFE8A07E070
        public void RotateRight(){} // RVA: 0x7FFE8A07E100
        public void BytesToWord(){} // RVA: 0x7FFE8A07E190
        public void WordToBytes(){} // RVA: 0x7FFE8A07E240
        public void .cctor(){} // RVA: 0x7FFE8A07E2F0
    }

    public class RC6Engine : Object
    {
        public int wordSize;
        public int bytesPerWord; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A07E390
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE8A07E3D0
        public void Init(){} // RVA: 0x7FFE8A07E430
        public void ProcessBlock(){} // RVA: 0x7FFE8A07E590
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void SetKey(){} // RVA: 0x7FFE8A07E760
        public void EncryptBlock(){} // RVA: 0x7FFE8A07EBB0
        public void DecryptBlock(){} // RVA: 0x7FFE8A07F350
        public void RotateLeft(){} // RVA: 0x7FFE8A07FB00
        public void RotateRight(){} // RVA: 0x7FFE8A07FB90
        public void BytesToWord(){} // RVA: 0x7FFE8A07FC20
        public void WordToBytes(){} // RVA: 0x7FFE8A07FCD0
        public void .cctor(){} // RVA: 0x7FFE8A07FD80
    }

    public class Rfc3211WrapEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.CbcBlockCipher engine; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A07FE40
        public void Init(){} // RVA: 0x7FFE8A07FF00
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A080270
        public void Wrap(){} // RVA: 0x7FFE8A0802F0
        public void Unwrap(){} // RVA: 0x7FFE8A0805A0
    }

    public class Rfc3394WrapEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher engine; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A080A40
        public void Init(){} // RVA: 0x7FFE8A080B70
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A080EF0
        public void Wrap(){} // RVA: 0x7FFE8A080F40
        public void Unwrap(){} // RVA: 0x7FFE8A0812A0
    }

    public class RijndaelEngine : Object
    {
        public int MAXROUNDS;
        public int MAXKC; // 0x4

        // ── Methods ──
        public void Mul0x2(){} // RVA: 0x7FFE8A081730
        public void Mul0x3(){} // RVA: 0x7FFE8A0817D0
        public void Mul0x9(){} // RVA: 0x7FFE8A081870
        public void Mul0xb(){} // RVA: 0x7FFE8A081900
        public void Mul0xd(){} // RVA: 0x7FFE8A081990
        public void Mul0xe(){} // RVA: 0x7FFE8A081A20
        public void KeyAddition(){} // RVA: 0x7FFE8A081AB0
        public void Shift(){} // RVA: 0x7FFE8A081B20
        public void ShiftRow(){} // RVA: 0x7FFE8A081B50
        public void ApplyS(){} // RVA: 0x7FFE8A081C20
        public void Substitution(){} // RVA: 0x7FFE8A081C80
        public void MixColumn(){} // RVA: 0x7FFE8A081DF0
        public void InvMixColumn(){} // RVA: 0x7FFE8A081FD0
        public void GenerateWorkingKey(){} // RVA: 0x7FFE8A0823A0
        public void .ctor(){} // RVA: 0x7FFE8A082C30 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8A083130
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A083380
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE8A0833C0
        public void ProcessBlock(){} // RVA: 0x7FFE8A0833D0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void UnPackBlock(){} // RVA: 0x7FFE8A083700
        public void PackBlock(){} // RVA: 0x7FFE8A083820
        public void EncryptBlock(){} // RVA: 0x7FFE8A0838C0
        public void DecryptBlock(){} // RVA: 0x7FFE8A083B00
        public void .cctor(){} // RVA: 0x7FFE8A083D30
    }

    public class RsaBlindedEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IRsa core; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A084530
        public void Init(){} // RVA: 0x7FFE8A084570
        public void GetInputBlockSize(){} // RVA: 0x7FFE8A084A60
        public void GetOutputBlockSize(){} // RVA: 0x7FFE8A084AB0
        public void ProcessBlock(){} // RVA: 0x7FFE8A084B00
    }

    public class RsaBlindingEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IRsa core; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A084ED0
        public void Init(){} // RVA: 0x7FFE8A084F10
        public void GetInputBlockSize(){} // RVA: 0x7FFE8A085150
        public void GetOutputBlockSize(){} // RVA: 0x7FFE8A0851A0
        public void ProcessBlock(){} // RVA: 0x7FFE8A0851F0
        public void BlindMessage(){} // RVA: 0x7FFE8A085400
        public void UnblindMessage(){} // RVA: 0x7FFE8A0854F0
    }

    public class RsaCoreEngine : Object
    {
        // ── Methods ──
        public void CheckInitialised(){} // RVA: 0x7FFE8A0855D0
        public void Init(){} // RVA: 0x7FFE8A085640
        public void GetInputBlockSize(){} // RVA: 0x7FFE8A085870
        public void GetOutputBlockSize(){} // RVA: 0x7FFE8A085900
        public void ConvertInput(){} // RVA: 0x7FFE8A085990
        public void ConvertOutput(){} // RVA: 0x7FFE8A085B50
        public void ProcessBlock(){} // RVA: 0x7FFE8A085C60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RsaEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IRsa core; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A085F30
        public void Init(){} // RVA: 0x7FFE8A085F70
        public void GetInputBlockSize(){} // RVA: 0x7FFE8A085FE0
        public void GetOutputBlockSize(){} // RVA: 0x7FFE8A086030
        public void ProcessBlock(){} // RVA: 0x7FFE8A086080
    }

    public class SM2Engine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8A090060
        public void ProcessBlock(){} // RVA: 0x7FFE8A090520
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFE8A090550
        public void Encrypt(){} // RVA: 0x7FFE8A090590
        public void Decrypt(){} // RVA: 0x7FFE8A090B90
        public void NotEncrypted(){} // RVA: 0x7FFE8A0910F0
        public void Kdf(){} // RVA: 0x7FFE8A091160
        public void Xor(){} // RVA: 0x7FFE8A091620
        public void NextK(){} // RVA: 0x7FFE8A091690
        public void AddFieldElement(){} // RVA: 0x7FFE8A091760
    }

    public class SM4Engine : Object
    {
        public int BlockSize;
        public byte[] Sbox;

        // ── Methods ──
        public void tau(){} // RVA: 0x7FFE8A0917F0
        public void L_ap(){} // RVA: 0x7FFE8A0918D0
        public void T_ap(){} // RVA: 0x7FFE8A0918F0
        public void ExpandKey(){} // RVA: 0x7FFE8A091960
        public void L(){} // RVA: 0x7FFE8A0921A0
        public void T(){} // RVA: 0x7FFE8A0921D0
        public void Init(){} // RVA: 0x7FFE8A092250
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A092430
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void ProcessBlock(){} // RVA: 0x7FFE8A092470
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A092BB0
    }

    public class Salsa20Engine : Object
    {
        public int DEFAULT_ROUNDS;
        public int StateSize;

        // ── Methods ──
        public void PackTauOrSigma(){} // RVA: 0x7FFE8A086120
        public void .ctor(){} // RVA: 0x7FFE8A0862F0 | overloaded x2
        public void Init(){} // RVA: 0x7FFE8A0864C0
        public void get_NonceSize(){} // RVA: 0x7FFE82199910
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A086870
        public void ReturnByte(){} // RVA: 0x7FFE8A086940
        public void AdvanceCounter(){} // RVA: 0x7FFE8A086A20
        public void ProcessBytes(){} // RVA: 0x7FFE8A086A60
        public void Reset(){} // RVA: 0x7FFE8A086D40
        public void ResetCounter(){} // RVA: 0x7FFE8A086D60
        public void SetKey(){} // RVA: 0x7FFE8A086DA0
        public void GenerateKeyStream(){} // RVA: 0x7FFE8A0871B0
        public void SalsaCore(){} // RVA: 0x7FFE8A0872E0
        public void R(){} // RVA: 0x7FFE869D7C70
        public void ResetLimitCounter(){} // RVA: 0x7FFE8A087A10
        public void LimitExceeded(){} // RVA: 0x7FFE8A087A40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE8A087A70
    }

    public class SeedEngine : Object
    {
        public int BlockSize;
        public uint[] SS0;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A087DC0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A087ED0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void ProcessBlock(){} // RVA: 0x7FFE8A087F10
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void createWorkingKey(){} // RVA: 0x7FFE8A088250
        public void extractW1(){} // RVA: 0x7FFE8481AF30
        public void extractW0(){} // RVA: 0x7FFE8A088490
        public void rotateLeft8(){} // RVA: 0x7FFE8A0884A0
        public void rotateRight8(){} // RVA: 0x7FFE8A0884B0
        public void bytesToLong(){} // RVA: 0x7FFE8A0884C0
        public void longToBytes(){} // RVA: 0x7FFE8A088510
        public void G(){} // RVA: 0x7FFE8A088570
        public void F(){} // RVA: 0x7FFE8A088660
        public void phaseCalc1(){} // RVA: 0x7FFE8A088720
        public void phaseCalc2(){} // RVA: 0x7FFE8A088770
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A088800
    }

    public class SeedWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A088B80
    }

    public class SerpentEngine : SerpentEngineBase
    {
        // ── Methods ──
        public void MakeWorkingKey(){} // RVA: 0x7FFE8A088BD0
        public void EncryptBlock(){} // RVA: 0x7FFE8A08AA80
        public void DecryptBlock(){} // RVA: 0x7FFE8A08C4E0
        public void .ctor(){} // RVA: 0x7FFE8A08E360
    }

    public class SerpentEngineBase : Object
    {
        public int BlockSize;
        public int ROUNDS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Init(){} // RVA: 0x7FFE8A08E3B0
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A08E590
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE8A08E5D0
        public void ProcessBlock(){} // RVA: 0x7FFE8A08E630
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void RotateLeft(){} // RVA: 0x7FFE869D7C70
        public void RotateRight(){} // RVA: 0x7FFE867D9B10
        public void Sb0(){} // RVA: 0x7FFE8A08E880
        public void Ib0(){} // RVA: 0x7FFE8A08E8E0
        public void Sb1(){} // RVA: 0x7FFE8A08E940
        public void Ib1(){} // RVA: 0x7FFE8A08E9A0
        public void Sb2(){} // RVA: 0x7FFE8A08EA00
        public void Ib2(){} // RVA: 0x7FFE8A08EA80
        public void Sb3(){} // RVA: 0x7FFE8A08EAF0
        public void Ib3(){} // RVA: 0x7FFE8A08EB70
        public void Sb4(){} // RVA: 0x7FFE8A08EBD0
        public void Ib4(){} // RVA: 0x7FFE8A08EC30
        public void Sb5(){} // RVA: 0x7FFE8A08EC90
        public void Ib5(){} // RVA: 0x7FFE8A08ECF0
        public void Sb6(){} // RVA: 0x7FFE8A08ED70
        public void Ib6(){} // RVA: 0x7FFE8A08EDC0
        public void Sb7(){} // RVA: 0x7FFE8A08EE30
        public void Ib7(){} // RVA: 0x7FFE8A08EEA0
        public void LT(){} // RVA: 0x7FFE8A08EF20
        public void InverseLT(){} // RVA: 0x7FFE8A08F000
        public void MakeWorkingKey(){} // RVA: 0x7FFE80E2E390
        public void EncryptBlock(){}
        public void DecryptBlock(){}
        public void .cctor(){} // RVA: 0x7FFE8A08F0E0
    }

    public class SkipjackEngine : Object
    {
        public int BLOCK_SIZE;
        public short[] ftable;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A08F120
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A08F580
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void ProcessBlock(){} // RVA: 0x7FFE8A08F5C0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void G(){} // RVA: 0x7FFE8A08F790
        public void EncryptBlock(){} // RVA: 0x7FFE8A08F900
        public void H(){} // RVA: 0x7FFE8A08FB30
        public void DecryptBlock(){} // RVA: 0x7FFE8A08FCA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A08FEE0
    }

    public class TeaEngine : Object
    {
        public int rounds;
        public int block_size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86DDEB00
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A092E00
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void Init(){} // RVA: 0x7FFE8A092E40
        public void ProcessBlock(){} // RVA: 0x7FFE8A092FA0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void setKey(){} // RVA: 0x7FFE8A093170
        public void encryptBlock(){} // RVA: 0x7FFE8A0932A0
        public void decryptBlock(){} // RVA: 0x7FFE8A0934C0
    }

    public class ThreefishEngine : Object
    {
        public int BLOCKSIZE_256;
        public int BLOCKSIZE_512;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A0936E0
        public void .ctor(){} // RVA: 0x7FFE8A093AB0
        public void Init(){} // RVA: 0x7FFE8A094230 | overloaded x2
        public void SetKey(){} // RVA: 0x7FFE8A094510
        public void SetTweak(){} // RVA: 0x7FFE8A094670
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0947E0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE811485C0
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void ProcessBlock(){} // RVA: 0x7FFE8A094AB0 | overloaded x2
        public void BytesToWord(){} // RVA: 0x7FFE8A094C30
        public void WordToBytes(){} // RVA: 0x7FFE8A094D80
        public void RotlXor(){} // RVA: 0x7FFE8A094EA0
        public void XorRotr(){} // RVA: 0x7FFE8A094EC0
    }

    public class TnepresEngine : SerpentEngineBase
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0989E0
        public void MakeWorkingKey(){} // RVA: 0x7FFE8A098A20
        public void EncryptBlock(){} // RVA: 0x7FFE8A09A8A0
        public void DecryptBlock(){} // RVA: 0x7FFE8A09C320
        public void .ctor(){} // RVA: 0x7FFE8A09E1B0
    }

    public class TwofishEngine : Object
    {
        public byte[,] P;
        public int P_00;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A09E200
        public void Init(){} // RVA: 0x7FFE8A09E720
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A09E8F0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void ProcessBlock(){} // RVA: 0x7FFE8A09E930
        public void Reset(){} // RVA: 0x7FFE8A09EAF0
        public void GetBlockSize(){} // RVA: 0x7FFE835C1D80
        public void SetKey(){} // RVA: 0x7FFE8A09EB10
        public void EncryptBlock(){} // RVA: 0x7FFE8A09F760
        public void DecryptBlock(){} // RVA: 0x7FFE8A09FE20
        public void F32(){} // RVA: 0x7FFE8A0A04D0
        public void RS_MDS_Encode(){} // RVA: 0x7FFE8A0A0AB0
        public void RS_rem(){} // RVA: 0x7FFE8A0A0BA0
        public void LFSR1(){} // RVA: 0x7FFE8A0A0C00
        public void LFSR2(){} // RVA: 0x7FFE8A0A0C20
        public void Mx_X(){} // RVA: 0x7FFE8A0A0C50
        public void Mx_Y(){} // RVA: 0x7FFE8A0A0C80
        public void M_b0(){} // RVA: 0x7FFE81D53FE0
        public void M_b1(){} // RVA: 0x7FFE8A0A0CC0
        public void M_b2(){} // RVA: 0x7FFE8A0A0CD0
        public void M_b3(){} // RVA: 0x7FFE8A0A0CE0
        public void Fe32_0(){} // RVA: 0x7FFE8A0A0CF0
        public void Fe32_3(){} // RVA: 0x7FFE8A0A0D70
        public void BytesTo32Bits(){} // RVA: 0x7FFE8680C480
        public void Bits32ToBytes(){} // RVA: 0x7FFE86807EC0
        public void .cctor(){} // RVA: 0x7FFE8A0A0E00
    }

    public class VmpcEngine : Object
    {
        public byte n; // 0x10

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0A0EF0
        public void Init(){} // RVA: 0x7FFE8A0A0F30
        public void InitKey(){} // RVA: 0x7FFE8A0A1210
        public void ProcessBytes(){} // RVA: 0x7FFE8A0A14A0
        public void Reset(){} // RVA: 0x7FFE8A0A16F0
        public void ReturnByte(){} // RVA: 0x7FFE8A0A1710
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class VmpcKsa3Engine : VmpcEngine
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0A17F0
        public void InitKey(){} // RVA: 0x7FFE8A0A1830
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class XSalsa20Engine : Salsa20Engine
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0A1B90
        public void get_NonceSize(){} // RVA: 0x7FFE835C1D90
        public void SetKey(){} // RVA: 0x7FFE8A0A1BD0
        public void .ctor(){} // RVA: 0x7FFE8A0A2070
    }

    public class XteaEngine : Object
    {
        public int rounds;
        public int block_size;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A0A2110
        public void get_AlgorithmName(){} // RVA: 0x7FFE8A0A2280
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFE810FB320
        public void GetBlockSize(){} // RVA: 0x7FFE82199910
        public void Init(){} // RVA: 0x7FFE8A0A22C0
        public void ProcessBlock(){} // RVA: 0x7FFE8A0A2580
        public void Reset(){} // RVA: 0x7FFE810FB310
        public void setKey(){} // RVA: 0x7FFE8A0A2750
        public void encryptBlock(){} // RVA: 0x7FFE8A0A28C0
        public void decryptBlock(){} // RVA: 0x7FFE8A0A2B00
    }

}