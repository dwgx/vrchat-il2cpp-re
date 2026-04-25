// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
// Classes: 56
// Methods: 673

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
    public class AesEngine : Object
    {
        public byte[] AlgorithmName;
        public byte[] IsPartialBlockOkay; // 0x8
        public byte[] rcon; // 0x10
        public uint[] T0; // 0x18
        public uint[] Tinv0; // 0x20
        public uint m1;
        public uint m2;
        public uint m3;
        public uint m4;
        public uint m5;
        public int ROUNDS; // 0x10
        public uint[][] WorkingKey; // 0x18
        public uint C0; // 0x20
        public uint C1; // 0x24
        public uint C2; // 0x28
        public uint C3; // 0x2C
        public bool forEncryption; // 0x30
        public byte[] s; // 0x38
        public int BLOCK_SIZE;

        // ── Methods ──
        public void Shift(){} // RVA: 0x7FFAC8430200
        public void FFmulX(){} // RVA: 0x7FFACBBEF640
        public void FFmulX2(){} // RVA: 0x7FFACBBEF660
        public void Inv_Mcol(){} // RVA: 0x7FFACBBEF690
        public void SubWord(){} // RVA: 0x7FFACBBEF750
        public void GenerateWorkingKey(){} // RVA: 0x7FFACBBEF830
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFACBBF0B80
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBF0E50
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void ProcessBlock(){} // RVA: 0x7FFACBBF0E90
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void UnPackBlock(){} // RVA: 0x7FFACBBF1060
        public void PackBlock(){} // RVA: 0x7FFACBBF1220
        public void EncryptBlock(){} // RVA: 0x7FFACBBF13C0
        public void DecryptBlock(){} // RVA: 0x7FFACBBF21B0
        public void .cctor(){} // RVA: 0x7FFACBBF2F70
    }

    public class AesFastEngine : Object
    {
        public byte[] AlgorithmName;
        public byte[] IsPartialBlockOkay; // 0x8
        public byte[] rcon; // 0x10
        public uint[] T0; // 0x18
        public uint[] T1; // 0x20
        public uint[] T2; // 0x28
        public uint[] T3; // 0x30
        public uint[] Tinv0; // 0x38
        public uint[] Tinv1; // 0x40
        public uint[] Tinv2; // 0x48
        public uint[] Tinv3; // 0x50
        public uint m1;
        public uint m2;
        public uint m3;
        public uint m4;
        public uint m5;
        public int ROUNDS; // 0x10
        public uint[][] WorkingKey; // 0x18
        public uint C0; // 0x20
        public uint C1; // 0x24
        public uint C2; // 0x28
        public uint C3; // 0x2C
        public bool forEncryption; // 0x30
        public int BLOCK_SIZE;

        // ── Methods ──
        public void Shift(){} // RVA: 0x7FFAC8430200
        public void FFmulX(){} // RVA: 0x7FFACBBEF640
        public void FFmulX2(){} // RVA: 0x7FFACBBEF660
        public void Inv_Mcol(){} // RVA: 0x7FFACBBF3300
        public void SubWord(){} // RVA: 0x7FFACBBF33C0
        public void GenerateWorkingKey(){} // RVA: 0x7FFACBBF34A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFACBBF47F0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBF4970
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void ProcessBlock(){} // RVA: 0x7FFACBBF49B0
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void UnPackBlock(){} // RVA: 0x7FFACBBF1060
        public void PackBlock(){} // RVA: 0x7FFACBBF1220
        public void EncryptBlock(){} // RVA: 0x7FFACBBF4B80
        public void DecryptBlock(){} // RVA: 0x7FFACBBF5790
        public void .cctor(){} // RVA: 0x7FFACBBF63A0
    }

    public class AesLightEngine : Object
    {
        public byte[] AlgorithmName;
        public byte[] IsPartialBlockOkay; // 0x8
        public byte[] rcon; // 0x10
        public uint m1;
        public uint m2;
        public uint m3;
        public uint m4;
        public uint m5;
        public int ROUNDS; // 0x10
        public uint[][] WorkingKey; // 0x18
        public uint C0; // 0x20
        public uint C1; // 0x24
        public uint C2; // 0x28
        public uint C3; // 0x2C
        public bool forEncryption; // 0x30
        public int BLOCK_SIZE;

        // ── Methods ──
        public void Shift(){} // RVA: 0x7FFAC8430200
        public void FFmulX(){} // RVA: 0x7FFACBBEF640
        public void FFmulX2(){} // RVA: 0x7FFACBBEF660
        public void Mcol(){} // RVA: 0x7FFACBBF6AF0
        public void Inv_Mcol(){} // RVA: 0x7FFACBBF6B80
        public void SubWord(){} // RVA: 0x7FFACBBF6C40
        public void GenerateWorkingKey(){} // RVA: 0x7FFACBBF6D20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFACBBF8070
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBF81F0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void ProcessBlock(){} // RVA: 0x7FFACBBF8230
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void UnPackBlock(){} // RVA: 0x7FFACBBF1060
        public void PackBlock(){} // RVA: 0x7FFACBBF1220
        public void EncryptBlock(){} // RVA: 0x7FFACBBF8400
        public void DecryptBlock(){} // RVA: 0x7FFACBBF9650
        public void .cctor(){} // RVA: 0x7FFACBBFA330
    }

    public class AesWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBFA570
    }

    public class BlowfishEngine : Object
    {
        public uint[] AlgorithmName;
        public uint[] IsPartialBlockOkay; // 0x8
        public uint[] KS1; // 0x10
        public uint[] KS2; // 0x18
        public uint[] KS3; // 0x20
        public int ROUNDS; // 0x28
        public int BLOCK_SIZE;
        public int SBOX_SK; // 0x2C
        public int P_SZ; // 0x30
        public uint[] S0; // 0x10
        public uint[] S1; // 0x18
        public uint[] S2; // 0x20
        public uint[] S3; // 0x28
        public uint[] P; // 0x30
        public bool encrypting; // 0x38
        public byte[] workingKey; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBBFA5C0
        public void Init(){} // RVA: 0x7FFACBBFA860
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBFAA10
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void ProcessBlock(){} // RVA: 0x7FFACBBFAA50
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void F(){} // RVA: 0x7FFACBBFAC10
        public void ProcessTable(){} // RVA: 0x7FFACBBFACA0
        public void SetKey(){} // RVA: 0x7FFACBBFAE50
        public void EncryptBlock(){} // RVA: 0x7FFACBBFB1F0
        public void DecryptBlock(){} // RVA: 0x7FFACBBFB5B0
        public void .cctor(){} // RVA: 0x7FFACBBFB970
    }

    public class CamelliaEngine : Object
    {
        public bool AlgorithmName; // 0x10
        public bool IsPartialBlockOkay; // 0x11
        public int BLOCK_SIZE;
        public uint[] subkey; // 0x18
        public uint[] kw; // 0x20
        public uint[] ke; // 0x28
        public uint[] state; // 0x30
        public uint[] SIGMA;
        public uint[] SBOX1_1110; // 0x8
        public uint[] SBOX4_4404; // 0x10
        public uint[] SBOX2_0222; // 0x18
        public uint[] SBOX3_3033; // 0x20

        // ── Methods ──
        public void rightRotate(){} // RVA: 0x7FFACBBFBD30
        public void leftRotate(){} // RVA: 0x7FFACBBFBD50
        public void roldq(){} // RVA: 0x7FFACBBFBD70
        public void decroldq(){} // RVA: 0x7FFACBBFBF30
        public void roldqo32(){} // RVA: 0x7FFACBBFC100
        public void decroldqo32(){} // RVA: 0x7FFACBBFC2C0
        public void bytes2uint(){} // RVA: 0x7FFACBBFC490
        public void uint2bytes(){} // RVA: 0x7FFACBBFC4E0
        public void camelliaF2(){} // RVA: 0x7FFACBBFC520
        public void camelliaFLs(){} // RVA: 0x7FFACBBFC8D0
        public void setKey(){} // RVA: 0x7FFACBBFC9F0
        public void processBlock128(){} // RVA: 0x7FFACBBFE090
        public void processBlock192or256(){} // RVA: 0x7FFACBBFE5C0
        public void .ctor(){} // RVA: 0x7FFACBBFEB40
        public void Init(){} // RVA: 0x7FFACBBFED10
        public void get_AlgorithmName(){} // RVA: 0x7FFACBBFEE30
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void ProcessBlock(){} // RVA: 0x7FFACBBFEE70
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBBFF020
    }

    public class CamelliaLightEngine : Object
    {
        public int AlgorithmName;
        public bool IsPartialBlockOkay; // 0x10
        public bool _keyis128; // 0x11
        public uint[] subkey; // 0x18
        public uint[] kw; // 0x20
        public uint[] ke; // 0x28
        public uint[] state; // 0x30
        public uint[] SIGMA;
        public byte[] SBOX1; // 0x8

        // ── Methods ──
        public void rightRotate(){} // RVA: 0x7FFACBBFBD30
        public void leftRotate(){} // RVA: 0x7FFACBBFBD50
        public void roldq(){} // RVA: 0x7FFACBBFBD70
        public void decroldq(){} // RVA: 0x7FFACBBFBF30
        public void roldqo32(){} // RVA: 0x7FFACBBFC100
        public void decroldqo32(){} // RVA: 0x7FFACBBFC2C0
        public void bytes2uint(){} // RVA: 0x7FFACBBFC490
        public void uint2bytes(){} // RVA: 0x7FFACBBFC4E0
        public void lRot8(){} // RVA: 0x7FFACBBFF3A0
        public void sbox2(){} // RVA: 0x7FFACBBFF3C0
        public void sbox3(){} // RVA: 0x7FFACBBFF450
        public void sbox4(){} // RVA: 0x7FFACBBFF4E0
        public void camelliaF2(){} // RVA: 0x7FFACBBFF570
        public void camelliaFLs(){} // RVA: 0x7FFACBBFF910
        public void setKey(){} // RVA: 0x7FFACBBFFA30
        public void processBlock128(){} // RVA: 0x7FFACBC010F0
        public void processBlock192or256(){} // RVA: 0x7FFACBC01660
        public void .ctor(){} // RVA: 0x7FFACBC01C30
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC01E00
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void Init(){} // RVA: 0x7FFACBC01E40
        public void ProcessBlock(){} // RVA: 0x7FFACBC01F60
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC02110
    }

    public class CamelliaWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC022C0
    }

    public class Cast5Engine : Object
    {
        public uint[] AlgorithmName;
        public uint[] IsPartialBlockOkay; // 0x8
        public uint[] S3; // 0x10
        public uint[] S4; // 0x18
        public uint[] S5; // 0x20
        public uint[] S6; // 0x28
        public uint[] S7; // 0x30
        public uint[] S8; // 0x38
        public int MAX_ROUNDS; // 0x40
        public int RED_ROUNDS; // 0x44
        public int BLOCK_SIZE;
        public int[] _Kr; // 0x10
        public uint[] _Km; // 0x18
        public bool _encrypting; // 0x20
        public byte[] _workingKey; // 0x28
        public int _rounds; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC02320
        public void Init(){} // RVA: 0x7FFACBC02470
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC02650
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void ProcessBlock(){} // RVA: 0x7FFACBC02690
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void SetKey(){} // RVA: 0x7FFACBC02890
        public void EncryptBlock(){} // RVA: 0x7FFACBC07F00
        public void DecryptBlock(){} // RVA: 0x7FFACBC08130
        public void F1(){} // RVA: 0x7FFACBC08360
        public void F2(){} // RVA: 0x7FFACBC08480
        public void F3(){} // RVA: 0x7FFACBC085A0
        public void CAST_Encipher(){} // RVA: 0x7FFACBC086C0
        public void CAST_Decipher(){} // RVA: 0x7FFACBC08900
        public void Bits32ToInts(){} // RVA: 0x7FFACBC08B40
        public void IntsTo32bits(){} // RVA: 0x7FFACBC08BC0
        public void .cctor(){} // RVA: 0x7FFACBC08C40
    }

    public class Cast6Engine : Cast5Engine
    {
        public int AlgorithmName;
        public int BLOCK_SIZE;
        public int[] _Kr; // 0x38
        public uint[] _Km; // 0x40
        public int[] _Tr; // 0x48
        public uint[] _Tm; // 0x50
        public uint[] _workingKey; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC091C0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC09430
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void SetKey(){} // RVA: 0x7FFACBC09470
        public void EncryptBlock(){} // RVA: 0x7FFACBC0A040
        public void DecryptBlock(){} // RVA: 0x7FFACBC0A420
        public void CAST_Encipher(){} // RVA: 0x7FFACBC0A800
        public void CAST_Decipher(){} // RVA: 0x7FFACBC0AB80
    }

    public class ChaCha7539Engine : Salsa20Engine
    {
        public object AlgorithmName;
        public object NonceSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC0AF00
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC0AFA0
        public void get_NonceSize(){} // RVA: 0x7FFAC530B5A0
        public void AdvanceCounter(){} // RVA: 0x7FFACBC0AFF0
        public void ResetCounter(){} // RVA: 0x7FFACBC0B070
        public void SetKey(){} // RVA: 0x7FFACBC0B0A0
        public void GenerateKeyStream(){} // RVA: 0x7FFACBC0B2B0
    }

    public class ChaChaEngine : Salsa20Engine
    {
        public object AlgorithmName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC0B410 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC0B470
        public void AdvanceCounter(){} // RVA: 0x7FFACBC0B4C0
        public void ResetCounter(){} // RVA: 0x7FFACBC0B500
        public void SetKey(){} // RVA: 0x7FFACBC0B540
        public void GenerateKeyStream(){} // RVA: 0x7FFACBC0B2B0
        public void ChachaCore(){} // RVA: 0x7FFACBC0B800
    }

    public class DesEdeEngine : DesEngine
    {
        public int[] AlgorithmName; // 0x18
        public int[] workingKey2; // 0x20
        public int[] workingKey3; // 0x28
        public bool forEncryption; // 0x30

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC0BF70
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC0C3D0
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void ProcessBlock(){} // RVA: 0x7FFACBC0C410
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFACBC0C6A0
    }

    public class DesEdeWrapEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.CbcBlockCipher AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter param; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ParametersWithIV paramPlusIV; // 0x20
        public byte[] iv; // 0x28
        public bool forWrapping; // 0x30
        public byte[] IV2;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest sha1; // 0x38
        public byte[] digest; // 0x40

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC0C6F0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC0CD40
        public void Wrap(){} // RVA: 0x7FFACBC0CD80
        public void Unwrap(){} // RVA: 0x7FFACBC0D1E0
        public void CalculateCmsKeyChecksum(){} // RVA: 0x7FFACBC0D870
        public void CheckCmsKeyChecksum(){} // RVA: 0x7FFACBC0D960
        public void reverse(){} // RVA: 0x7FFACBC0DA40
        public void .ctor(){} // RVA: 0x7FFACBC0DAD0
        public void .cctor(){} // RVA: 0x7FFACBC0DBF0
    }

    public class DesEngine : Object
    {
        public int AlgorithmName;
        public int[] IsPartialBlockOkay; // 0x10
        public short[] bytebit;
        public int[] bigbyte; // 0x8
        public byte[] pc1; // 0x10
        public byte[] totrot; // 0x18
        public byte[] pc2; // 0x20
        public uint[] SP1; // 0x28
        public uint[] SP2; // 0x30
        public uint[] SP3; // 0x38
        public uint[] SP4; // 0x40
        public uint[] SP5; // 0x48
        public uint[] SP6; // 0x50
        public uint[] SP7; // 0x58
        public uint[] SP8; // 0x60

        // ── Methods ──
        public void GetWorkingKey(){} // RVA: 0x7FFAC2F3C380
        public void Init(){} // RVA: 0x7FFACBC0DCD0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC0DEA0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void ProcessBlock(){} // RVA: 0x7FFACBC0DEE0
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void GenerateWorkingKey(){} // RVA: 0x7FFACBC0E0B0
        public void DesFunc(){} // RVA: 0x7FFACBC0E640
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC0ED20
    }

    public class Dstu7624Engine : Object
    {
        public ulong[] AlgorithmName; // 0x10
        public ulong[] IsPartialBlockOkay; // 0x18
        public ulong[][] roundKeys; // 0x20
        public int wordsInBlock; // 0x28
        public int wordsInKey; // 0x2C
        public int ROUNDS_128;
        public int ROUNDS_256;
        public int ROUNDS_512;
        public int roundsAmount; // 0x30
        public bool forEncryption; // 0x34
        public ulong mdsMatrix;
        public ulong mdsInvMatrix;
        public byte[] S0;
        public byte[] S1; // 0x8
        public byte[] S2; // 0x10
        public byte[] S3; // 0x18
        public byte[] T0; // 0x20
        public byte[] T1; // 0x28
        public byte[] T2; // 0x30
        public byte[] T3; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC0F5E0
        public void Init(){} // RVA: 0x7FFACBC0F6E0
        public void WorkingKeyExpandKT(){} // RVA: 0x7FFACBC0FBC0
        public void WorkingKeyExpandEven(){} // RVA: 0x7FFACBC0FEA0
        public void WorkingKeyExpandOdd(){} // RVA: 0x7FFACBC10350
        public void ProcessBlock(){} // RVA: 0x7FFACBC103C0
        public void EncryptionRound(){} // RVA: 0x7FFACBC10750
        public void DecryptionRound(){} // RVA: 0x7FFACBC10810
        public void DecryptBlock_128(){} // RVA: 0x7FFACBC108D0
        public void EncryptBlock_128(){} // RVA: 0x7FFACBC10E60
        public void SubBytes(){} // RVA: 0x7FFACBC114D0
        public void InvSubBytes(){} // RVA: 0x7FFACBC11770
        public void ShiftRows(){} // RVA: 0x7FFACBC11A10
        public void InvShiftRows(){} // RVA: 0x7FFACBC11E80
        public void AddRoundKey(){} // RVA: 0x7FFACBC122F0
        public void SubRoundKey(){} // RVA: 0x7FFACBC12360
        public void XorRoundKey(){} // RVA: 0x7FFACBC123D0
        public void MixColumn(){} // RVA: 0x7FFACBC12440
        public void MixColumns(){} // RVA: 0x7FFACBC12570
        public void MixColumnInv(){} // RVA: 0x7FFACBC12620
        public void MixColumnsInv(){} // RVA: 0x7FFACBC12830
        public void MulX(){} // RVA: 0x7FFACBC128E0
        public void MulX2(){} // RVA: 0x7FFACBC12910
        public void Rotate(){} // RVA: 0x7FFACBC12960
        public void RotateLeft(){} // RVA: 0x7FFACBC12980
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC12CC0
        public void GetBlockSize(){} // RVA: 0x7FFACBC12D00
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void Reset(){} // RVA: 0x7FFACBC12D10
        public void .cctor(){} // RVA: 0x7FFACBC12D40
    }

    public class Dstu7624WrapEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines.Dstu7624Engine engine; // 0x18
        public bool forWrapping; // 0x20
        public int blockSize; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC132A0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC133C0
        public void Init(){} // RVA: 0x7FFACBC13400
        public void Wrap(){} // RVA: 0x7FFACBC135C0
        public void Unwrap(){} // RVA: 0x7FFACBC13E00
    }

    public class ElGamalEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x18
        public bool forEncryption; // 0x20
        public int bitSize; // 0x24

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC147A0
        public void Init(){} // RVA: 0x7FFACBC147E0
        public void GetInputBlockSize(){} // RVA: 0x7FFACBC14CD0
        public void GetOutputBlockSize(){} // RVA: 0x7FFACBC14D00
        public void ProcessBlock(){} // RVA: 0x7FFACBC14D30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Gost28147Engine : Object
    {
        public int AlgorithmName;
        public int[] IsPartialBlockOkay; // 0x10
        public bool forEncryption; // 0x18
        public byte[] S; // 0x20
        public byte[] Sbox_Default;
        public byte[] ESbox_Test; // 0x8
        public byte[] ESbox_A; // 0x10
        public byte[] ESbox_B; // 0x18
        public byte[] ESbox_C; // 0x20
        public byte[] ESbox_D; // 0x28
        public byte[] DSbox_Test; // 0x30
        public byte[] DSbox_A; // 0x38
        public System.Collections.IDictionary sBoxes; // 0x40

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBC15310
        public void AddSBox(){} // RVA: 0x7FFACBC15AC0
        public void .ctor(){} // RVA: 0x7FFACBC15BA0
        public void Init(){} // RVA: 0x7FFACBC15C50
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC16080
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void ProcessBlock(){} // RVA: 0x7FFACBC160C0
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void generateWorkingKey(){} // RVA: 0x7FFACBC16270
        public void Gost28147_mainStep(){} // RVA: 0x7FFACBC163E0
        public void Gost28147Func(){} // RVA: 0x7FFACBC16550
        public void bytesToint(){} // RVA: 0x7FFACBBD0ED0
        public void intTobytes(){} // RVA: 0x7FFACBBD0F50
        public void GetSBox(){} // RVA: 0x7FFACBC168A0
        public void GetSBoxName(){} // RVA: 0x7FFACBC16A80
    }

    public class HC128Engine : Object
    {
        public uint[] AlgorithmName; // 0x10
        public uint[] q; // 0x18
        public uint cnt; // 0x20
        public byte[] key; // 0x28
        public byte[] iv; // 0x30
        public bool initialised; // 0x38
        public byte[] buf; // 0x40
        public int idx; // 0x48

        // ── Methods ──
        public void F1(){} // RVA: 0x7FFACBC16E00
        public void F2(){} // RVA: 0x7FFACBC16E30
        public void G1(){} // RVA: 0x7FFACBC16E60
        public void G2(){} // RVA: 0x7FFACBC16E90
        public void RotateLeft(){} // RVA: 0x7FFAC862E4A0
        public void RotateRight(){} // RVA: 0x7FFAC8430200
        public void H1(){} // RVA: 0x7FFACBC16EC0
        public void H2(){} // RVA: 0x7FFACBC16F10
        public void Mod1024(){} // RVA: 0x7FFACBC16F60
        public void Mod512(){} // RVA: 0x7FFACBC16F70
        public void Dim(){} // RVA: 0x7FFACBC16F80
        public void Step(){} // RVA: 0x7FFACBC16F90
        public void Init(){} // RVA: 0x7FFACBC175B0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC17570
        public void GetByte(){} // RVA: 0x7FFACBC17920
        public void ProcessBytes(){} // RVA: 0x7FFACBC179B0
        public void Reset(){} // RVA: 0x7FFACBC17C50
        public void ReturnByte(){} // RVA: 0x7FFACBC17C60
        public void .ctor(){} // RVA: 0x7FFACBC17C80
    }

    public class HC256Engine : Object
    {
        public uint[] AlgorithmName; // 0x10
        public uint[] q; // 0x18
        public uint cnt; // 0x20
        public byte[] key; // 0x28
        public byte[] iv; // 0x30
        public bool initialised; // 0x38
        public byte[] buf; // 0x40
        public int idx; // 0x48

        // ── Methods ──
        public void Step(){} // RVA: 0x7FFACBC17E00
        public void Init(){} // RVA: 0x7FFACBC18680 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC18640
        public void GetByte(){} // RVA: 0x7FFACBC189F0
        public void ProcessBytes(){} // RVA: 0x7FFACBC18A80
        public void Reset(){} // RVA: 0x7FFACBC18D20
        public void ReturnByte(){} // RVA: 0x7FFACBC18D30
        public void RotateRight(){} // RVA: 0x7FFAC8430200
        public void .ctor(){} // RVA: 0x7FFACBC18D50
    }

    public class IdeaEngine : Object
    {
        public int AlgorithmName;
        public int[] IsPartialBlockOkay; // 0x10
        public int MASK;
        public int BASE; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFACBC18ED0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC19080
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void ProcessBlock(){} // RVA: 0x7FFACBC190C0
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void BytesToWord(){} // RVA: 0x7FFACBC19270
        public void WordToBytes(){} // RVA: 0x7FFACBC192B0
        public void Mul(){} // RVA: 0x7FFACBC192F0
        public void IdeaFunc(){} // RVA: 0x7FFACBC193F0
        public void ExpandKey(){} // RVA: 0x7FFACBC197C0
        public void MulInv(){} // RVA: 0x7FFACBC199B0
        public void AddInv(){} // RVA: 0x7FFACBC19B00
        public void InvertKey(){} // RVA: 0x7FFACBC19B60
        public void GenerateWorkingKey(){} // RVA: 0x7FFACBC1A090
        public void .cctor(){} // RVA: 0x7FFACBC1A0D0
    }

    public class IesEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBasicAgreement agree; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDerivationFunction kdf; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IMac mac; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.BufferedBlockCipher cipher; // 0x28
        public byte[] macBuf; // 0x30
        public bool forEncryption; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters privParam; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters pubParam; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.IesParameters param; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC1A320 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBC1A560
        public void DecryptBlock(){} // RVA: 0x7FFACBC1A750
        public void EncryptBlock(){} // RVA: 0x7FFACBC1ACD0
        public void GenerateKdfBytes(){} // RVA: 0x7FFACBC1B180
        public void ProcessBlock(){} // RVA: 0x7FFACBC1B240
    }

    public class IsaacEngine : Object
    {
        public int AlgorithmName;
        public int stateArraySize; // 0x4
        public uint[] engineState; // 0x10
        public uint[] results; // 0x18
        public uint a; // 0x20
        public uint b; // 0x24
        public uint c; // 0x28
        public int index; // 0x2C
        public byte[] keyStream; // 0x30
        public byte[] workingKey; // 0x38
        public bool initialised; // 0x40

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC1B3B0
        public void ReturnByte(){} // RVA: 0x7FFACBC1B500
        public void ProcessBytes(){} // RVA: 0x7FFACBC1B5B0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC1B810
        public void Reset(){} // RVA: 0x7FFACBC1B850
        public void setKey(){} // RVA: 0x7FFACBC1B860
        public void isaac(){} // RVA: 0x7FFACBC1BDF0
        public void mix(){} // RVA: 0x7FFACBC1BF60
        public void .ctor(){} // RVA: 0x7FFACBC1C1A0
        public void .cctor(){} // RVA: 0x7FFACBC1C270
    }

    public class NaccacheSternEngine : Object
    {
        public bool AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.NaccacheSternKeyParameters Debug; // 0x18
        public System.Collections.IList[] lookup; // 0x20

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC1C2D0
        public void Init(){} // RVA: 0x7FFACBC1C310
        public void set_Debug(){} // RVA: 0x7FFAC2F21310
        public void GetInputBlockSize(){} // RVA: 0x7FFACBC1C900
        public void GetOutputBlockSize(){} // RVA: 0x7FFACBC1C960
        public void ProcessBlock(){} // RVA: 0x7FFACBC1C9C0
        public void Encrypt(){} // RVA: 0x7FFACBC1D140
        public void AddCryptedBlocks(){} // RVA: 0x7FFACBC1D230
        public void ProcessData(){} // RVA: 0x7FFACBC1D4F0
        public void chineseRemainder(){} // RVA: 0x7FFACBC1D6E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class NoekeonEngine : Object
    {
        public int AlgorithmName;
        public uint[] IsPartialBlockOkay;
        public uint[] roundConstants; // 0x8
        public uint[] state; // 0x10
        public uint[] subKeys; // 0x18
        public uint[] decryptKeys; // 0x20
        public bool _initialised; // 0x28
        public bool _forEncryption; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC1DCA0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC1DE10
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void Init(){} // RVA: 0x7FFACBC1DE50
        public void ProcessBlock(){} // RVA: 0x7FFACBC1DFC0
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void setKey(){} // RVA: 0x7FFACBC1E190
        public void encryptBlock(){} // RVA: 0x7FFACBC1E320
        public void decryptBlock(){} // RVA: 0x7FFACBC1EB70
        public void gamma(){} // RVA: 0x7FFACBC1F510
        public void theta(){} // RVA: 0x7FFACBC1F5C0
        public void pi1(){} // RVA: 0x7FFACBC1F6B0
        public void pi2(){} // RVA: 0x7FFACBC1F710
        public void rotl(){} // RVA: 0x7FFACBC1F770
        public void .cctor(){} // RVA: 0x7FFACBC1F790
    }

    public class NullEngine : Object
    {
        public bool AlgorithmName; // 0x10
        public int IsPartialBlockOkay;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFAC322C870
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC1F900
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC3006850
        public void GetBlockSize(){} // RVA: 0x7FFAC3013AF0
        public void ProcessBlock(){} // RVA: 0x7FFACBC1F940
        public void Reset(){} // RVA: 0x7FFAC2F21310
    }

    public class RC2Engine : Object
    {
        public byte[] AlgorithmName;
        public int IsPartialBlockOkay;
        public int[] workingKey; // 0x10
        public bool encrypting; // 0x18

        // ── Methods ──
        public void GenerateWorkingKey(){} // RVA: 0x7FFACBC1FB10
        public void Init(){} // RVA: 0x7FFACBC1FE00
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC200C0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void ProcessBlock(){} // RVA: 0x7FFACBC20100
        public void RotateWordLeft(){} // RVA: 0x7FFACBC202C0
        public void EncryptBlock(){} // RVA: 0x7FFACBC202E0
        public void DecryptBlock(){} // RVA: 0x7FFACBC20860
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC20D50
    }

    public class RC2WrapEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.CbcBlockCipher AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.ICipherParameters parameters; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ParametersWithIV paramPlusIV; // 0x20
        public byte[] iv; // 0x28
        public bool forWrapping; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom sr; // 0x38
        public byte[] IV2;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest sha1; // 0x40
        public byte[] digest; // 0x48

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC20E30
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC21480
        public void Wrap(){} // RVA: 0x7FFACBC214C0
        public void Unwrap(){} // RVA: 0x7FFACBC21AC0
        public void CalculateCmsKeyChecksum(){} // RVA: 0x7FFACBC223E0
        public void CheckCmsKeyChecksum(){} // RVA: 0x7FFACBC224D0
        public void .ctor(){} // RVA: 0x7FFACBC225B0
        public void .cctor(){} // RVA: 0x7FFACBC226D0
    }

    public class RC4Engine : Object
    {
        public int AlgorithmName;
        public byte[] engineState; // 0x10
        public int x; // 0x18
        public int y; // 0x1C
        public byte[] workingKey; // 0x20

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC227B0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC22950
        public void ReturnByte(){} // RVA: 0x7FFACBC22990
        public void ProcessBytes(){} // RVA: 0x7FFACBC22A70
        public void Reset(){} // RVA: 0x7FFACBC22CC0
        public void SetKey(){} // RVA: 0x7FFACBC22CD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC22F30
    }

    public class RC532Engine : Object
    {
        public int AlgorithmName; // 0x10
        public int[] IsPartialBlockOkay; // 0x18
        public int P32;
        public int Q32; // 0x4
        public bool forEncryption; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC22F70
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC22F80
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void Init(){} // RVA: 0x7FFACBC22FC0
        public void ProcessBlock(){} // RVA: 0x7FFACBC23270
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void SetKey(){} // RVA: 0x7FFACBC232A0
        public void EncryptBlock(){} // RVA: 0x7FFACBC235C0
        public void DecryptBlock(){} // RVA: 0x7FFACBC23830
        public void RotateLeft(){} // RVA: 0x7FFACBC23AC0
        public void RotateRight(){} // RVA: 0x7FFACBC23AE0
        public void BytesToWord(){} // RVA: 0x7FFAC8462B70
        public void WordToBytes(){} // RVA: 0x7FFAC845E5B0
        public void .cctor(){} // RVA: 0x7FFACBC23B00
    }

    public class RC564Engine : Object
    {
        public int AlgorithmName;
        public int IsPartialBlockOkay; // 0x4
        public int _noRounds; // 0x10
        public long[] _S; // 0x18
        public long P64; // 0x8
        public long Q64; // 0x10
        public bool forEncryption; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC22F70
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC23B60
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFACBC23BA0
        public void Init(){} // RVA: 0x7FFACBC23C00
        public void ProcessBlock(){} // RVA: 0x7FFACBC23E00
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void SetKey(){} // RVA: 0x7FFACBC23E30
        public void EncryptBlock(){} // RVA: 0x7FFACBC24280
        public void DecryptBlock(){} // RVA: 0x7FFACBC24670
        public void RotateLeft(){} // RVA: 0x7FFACBC24A50
        public void RotateRight(){} // RVA: 0x7FFACBC24AE0
        public void BytesToWord(){} // RVA: 0x7FFACBC24B70
        public void WordToBytes(){} // RVA: 0x7FFACBC24C20
        public void .cctor(){} // RVA: 0x7FFACBC24CD0
    }

    public class RC6Engine : Object
    {
        public int AlgorithmName;
        public int IsPartialBlockOkay; // 0x4
        public int _noRounds; // 0x8
        public int[] _S; // 0x10
        public int P32; // 0xC
        public int Q32; // 0x10
        public int LGW; // 0x14
        public bool forEncryption; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC24D70
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFACBC24DB0
        public void Init(){} // RVA: 0x7FFACBC24E10
        public void ProcessBlock(){} // RVA: 0x7FFACBC24F70
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void SetKey(){} // RVA: 0x7FFACBC25140
        public void EncryptBlock(){} // RVA: 0x7FFACBC25590
        public void DecryptBlock(){} // RVA: 0x7FFACBC25D30
        public void RotateLeft(){} // RVA: 0x7FFACBC264E0
        public void RotateRight(){} // RVA: 0x7FFACBC26570
        public void BytesToWord(){} // RVA: 0x7FFACBC26600
        public void WordToBytes(){} // RVA: 0x7FFACBC266B0
        public void .cctor(){} // RVA: 0x7FFACBC26760
    }

    public class Rfc3211WrapEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.CbcBlockCipher AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ParametersWithIV param; // 0x18
        public bool forWrapping; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom rand; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC26820
        public void Init(){} // RVA: 0x7FFACBC268E0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC26C50
        public void Wrap(){} // RVA: 0x7FFACBC26CD0
        public void Unwrap(){} // RVA: 0x7FFACBC26F80
    }

    public class Rfc3394WrapEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IBlockCipher AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.KeyParameter param; // 0x18
        public bool forWrapping; // 0x20
        public byte[] iv; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC27420
        public void Init(){} // RVA: 0x7FFACBC27550
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC278D0
        public void Wrap(){} // RVA: 0x7FFACBC27920
        public void Unwrap(){} // RVA: 0x7FFACBC27C80
    }

    public class RijndaelEngine : Object
    {
        public int AlgorithmName;
        public int IsPartialBlockOkay; // 0x4
        public byte[] Logtable; // 0x8
        public byte[] Alogtable; // 0x10
        public byte[] S; // 0x18
        public byte[] Si; // 0x20
        public byte[] rcon; // 0x28
        public byte[][] shifts0; // 0x30
        public byte[][] shifts1; // 0x38
        public int BC; // 0x10
        public long BC_MASK; // 0x18
        public int ROUNDS; // 0x20
        public int blockBits; // 0x24
        public long[][] workingKey; // 0x28
        public long A0; // 0x30
        public long A1; // 0x38
        public long A2; // 0x40
        public long A3; // 0x48
        public bool forEncryption; // 0x50
        public byte[] shifts0SC; // 0x58
        public byte[] shifts1SC; // 0x60

        // ── Methods ──
        public void Mul0x2(){} // RVA: 0x7FFACBC28110
        public void Mul0x3(){} // RVA: 0x7FFACBC281B0
        public void Mul0x9(){} // RVA: 0x7FFACBC28250
        public void Mul0xb(){} // RVA: 0x7FFACBC282E0
        public void Mul0xd(){} // RVA: 0x7FFACBC28370
        public void Mul0xe(){} // RVA: 0x7FFACBC28400
        public void KeyAddition(){} // RVA: 0x7FFACBC28490
        public void Shift(){} // RVA: 0x7FFACBC28500
        public void ShiftRow(){} // RVA: 0x7FFACBC28530
        public void ApplyS(){} // RVA: 0x7FFACBC28600
        public void Substitution(){} // RVA: 0x7FFACBC28660
        public void MixColumn(){} // RVA: 0x7FFACBC287D0
        public void InvMixColumn(){} // RVA: 0x7FFACBC289B0
        public void GenerateWorkingKey(){} // RVA: 0x7FFACBC28D80
        public void .ctor(){} // RVA: 0x7FFACBC29610 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBC29B10
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC29D60
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFACBC29DA0
        public void ProcessBlock(){} // RVA: 0x7FFACBC29DB0
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void UnPackBlock(){} // RVA: 0x7FFACBC2A0E0
        public void PackBlock(){} // RVA: 0x7FFACBC2A200
        public void EncryptBlock(){} // RVA: 0x7FFACBC2A2A0
        public void DecryptBlock(){} // RVA: 0x7FFACBC2A4E0
        public void .cctor(){} // RVA: 0x7FFACBC2A710
    }

    public class RsaBlindedEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IRsa AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom random; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC2AF10
        public void Init(){} // RVA: 0x7FFACBC2AF50
        public void GetInputBlockSize(){} // RVA: 0x7FFACBC2B440
        public void GetOutputBlockSize(){} // RVA: 0x7FFACBC2B490
        public void ProcessBlock(){} // RVA: 0x7FFACBC2B4E0
    }

    public class RsaBlindingEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IRsa AlgorithmName; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger blindingFactor; // 0x20
        public bool forEncryption; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC2B8B0
        public void Init(){} // RVA: 0x7FFACBC2B8F0
        public void GetInputBlockSize(){} // RVA: 0x7FFACBC2BB30
        public void GetOutputBlockSize(){} // RVA: 0x7FFACBC2BB80
        public void ProcessBlock(){} // RVA: 0x7FFACBC2BBD0
        public void BlindMessage(){} // RVA: 0x7FFACBC2BDE0
        public void UnblindMessage(){} // RVA: 0x7FFACBC2BED0
    }

    public class RsaCoreEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key; // 0x10
        public bool forEncryption; // 0x18
        public int bitSize; // 0x1C

        // ── Methods ──
        public void CheckInitialised(){} // RVA: 0x7FFACBC2BFB0
        public void Init(){} // RVA: 0x7FFACBC2C020
        public void GetInputBlockSize(){} // RVA: 0x7FFACBC2C250
        public void GetOutputBlockSize(){} // RVA: 0x7FFACBC2C2E0
        public void ConvertInput(){} // RVA: 0x7FFACBC2C370
        public void ConvertOutput(){} // RVA: 0x7FFACBC2C530
        public void ProcessBlock(){} // RVA: 0x7FFACBC2C640
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RsaEngine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IRsa AlgorithmName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC2C910
        public void Init(){} // RVA: 0x7FFACBC2C950
        public void GetInputBlockSize(){} // RVA: 0x7FFACBC2C9C0
        public void GetOutputBlockSize(){} // RVA: 0x7FFACBC2CA10
        public void ProcessBlock(){} // RVA: 0x7FFACBC2CA60
    }

    public class SM2Engine : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.IDigest mDigest; // 0x10
        public bool mForEncryption; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECKeyParameters mECKey; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Parameters.ECDomainParameters mECParams; // 0x28
        public int mCurveLength; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom mRandom; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBC36A40
        public void ProcessBlock(){} // RVA: 0x7FFACBC36F00
        public void CreateBasePointMultiplier(){} // RVA: 0x7FFACBC36F30
        public void Encrypt(){} // RVA: 0x7FFACBC36F70
        public void Decrypt(){} // RVA: 0x7FFACBC37570
        public void NotEncrypted(){} // RVA: 0x7FFACBC37AD0
        public void Kdf(){} // RVA: 0x7FFACBC37B40
        public void Xor(){} // RVA: 0x7FFACBC38000
        public void NextK(){} // RVA: 0x7FFACBC38070
        public void AddFieldElement(){} // RVA: 0x7FFACBC38140
    }

    public class SM4Engine : Object
    {
        public int AlgorithmName;
        public byte[] IsPartialBlockOkay;
        public uint[] CK; // 0x8
        public uint[] FK; // 0x10
        public uint[] rk; // 0x10

        // ── Methods ──
        public void tau(){} // RVA: 0x7FFACBC381D0
        public void L_ap(){} // RVA: 0x7FFACBC382B0
        public void T_ap(){} // RVA: 0x7FFACBC382D0
        public void ExpandKey(){} // RVA: 0x7FFACBC38340
        public void L(){} // RVA: 0x7FFACBC38B80
        public void T(){} // RVA: 0x7FFACBC38BB0
        public void Init(){} // RVA: 0x7FFACBC38C30
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC38E10
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void ProcessBlock(){} // RVA: 0x7FFACBC38E50
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC39590
    }

    public class Salsa20Engine : Object
    {
        public int NonceSize;
        public int AlgorithmName;
        public uint[] TAU_SIGMA; // 0x8
        public byte[] sigma; // 0x10
        public byte[] tau; // 0x18
        public int rounds; // 0x10
        public int index; // 0x14
        public uint[] engineState; // 0x18
        public uint[] x; // 0x20
        public byte[] keyStream; // 0x28
        public bool initialised; // 0x30
        public uint cW0; // 0x34
        public uint cW1; // 0x38
        public uint cW2; // 0x3C

        // ── Methods ──
        public void PackTauOrSigma(){} // RVA: 0x7FFACBC2CB00
        public void .ctor(){} // RVA: 0x7FFACBC2CCD0 | overloaded x2
        public void Init(){} // RVA: 0x7FFACBC2CEA0
        public void get_NonceSize(){} // RVA: 0x7FFAC3ED8E80
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC2D250
        public void ReturnByte(){} // RVA: 0x7FFACBC2D320
        public void AdvanceCounter(){} // RVA: 0x7FFACBC2D400
        public void ProcessBytes(){} // RVA: 0x7FFACBC2D440
        public void Reset(){} // RVA: 0x7FFACBC2D720
        public void ResetCounter(){} // RVA: 0x7FFACBC2D740
        public void SetKey(){} // RVA: 0x7FFACBC2D780
        public void GenerateKeyStream(){} // RVA: 0x7FFACBC2DB90
        public void SalsaCore(){} // RVA: 0x7FFACBC2DCC0
        public void R(){} // RVA: 0x7FFAC862E4A0
        public void ResetLimitCounter(){} // RVA: 0x7FFACBC2E3F0
        public void LimitExceeded(){} // RVA: 0x7FFACBC2E420 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFACBC2E450
    }

    public class SeedEngine : Object
    {
        public int AlgorithmName;
        public uint[] IsPartialBlockOkay;
        public uint[] SS1; // 0x8
        public uint[] SS2; // 0x10
        public uint[] SS3; // 0x18
        public uint[] KC; // 0x20
        public int[] wKey; // 0x10
        public bool forEncryption; // 0x18

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC2E7A0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC2E8B0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void ProcessBlock(){} // RVA: 0x7FFACBC2E8F0
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void createWorkingKey(){} // RVA: 0x7FFACBC2EC30
        public void extractW1(){} // RVA: 0x7FFAC5DEA830
        public void extractW0(){} // RVA: 0x7FFACBC2EE70
        public void rotateLeft8(){} // RVA: 0x7FFACBC2EE80
        public void rotateRight8(){} // RVA: 0x7FFACBC2EE90
        public void bytesToLong(){} // RVA: 0x7FFACBC2EEA0
        public void longToBytes(){} // RVA: 0x7FFACBC2EEF0
        public void G(){} // RVA: 0x7FFACBC2EF50
        public void F(){} // RVA: 0x7FFACBC2F040
        public void phaseCalc1(){} // RVA: 0x7FFACBC2F100
        public void phaseCalc2(){} // RVA: 0x7FFACBC2F150
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC2F1E0
    }

    public class SeedWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC2F560
    }

    public class SerpentEngine : SerpentEngineBase
    {
        // ── Methods ──
        public void MakeWorkingKey(){} // RVA: 0x7FFACBC2F5B0
        public void EncryptBlock(){} // RVA: 0x7FFACBC31460
        public void DecryptBlock(){} // RVA: 0x7FFACBC32EC0
        public void .ctor(){} // RVA: 0x7FFACBC34D40
    }

    public class SerpentEngineBase : Object
    {
        public int AlgorithmName;
        public int IsPartialBlockOkay;
        public int PHI;
        public bool encrypting; // 0x10
        public int[] wKey; // 0x18
        public int X0; // 0x20
        public int X1; // 0x24
        public int X2; // 0x28
        public int X3; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Init(){} // RVA: 0x7FFACBC34D90
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC34F70
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFACBC34FB0
        public void ProcessBlock(){} // RVA: 0x7FFACBC35010
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void RotateLeft(){} // RVA: 0x7FFAC862E4A0
        public void RotateRight(){} // RVA: 0x7FFAC8430200
        public void Sb0(){} // RVA: 0x7FFACBC35260
        public void Ib0(){} // RVA: 0x7FFACBC352C0
        public void Sb1(){} // RVA: 0x7FFACBC35320
        public void Ib1(){} // RVA: 0x7FFACBC35380
        public void Sb2(){} // RVA: 0x7FFACBC353E0
        public void Ib2(){} // RVA: 0x7FFACBC35460
        public void Sb3(){} // RVA: 0x7FFACBC354D0
        public void Ib3(){} // RVA: 0x7FFACBC35550
        public void Sb4(){} // RVA: 0x7FFACBC355B0
        public void Ib4(){} // RVA: 0x7FFACBC35610
        public void Sb5(){} // RVA: 0x7FFACBC35670
        public void Ib5(){} // RVA: 0x7FFACBC356D0
        public void Sb6(){} // RVA: 0x7FFACBC35750
        public void Ib6(){} // RVA: 0x7FFACBC357A0
        public void Sb7(){} // RVA: 0x7FFACBC35810
        public void Ib7(){} // RVA: 0x7FFACBC35880
        public void LT(){} // RVA: 0x7FFACBC35900
        public void InverseLT(){} // RVA: 0x7FFACBC359E0
        public void MakeWorkingKey(){} // RVA: 0x7FFAC2C58F40
        public void EncryptBlock(){}
        public void DecryptBlock(){}
        public void .cctor(){} // RVA: 0x7FFACBC35AC0
    }

    public class SkipjackEngine : Object
    {
        public int AlgorithmName;
        public short[] IsPartialBlockOkay;
        public int[] key0; // 0x10
        public int[] key1; // 0x18
        public int[] key2; // 0x20
        public int[] key3; // 0x28
        public bool encrypting; // 0x30

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBC35B00
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC35F60
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void ProcessBlock(){} // RVA: 0x7FFACBC35FA0
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void G(){} // RVA: 0x7FFACBC36170
        public void EncryptBlock(){} // RVA: 0x7FFACBC362E0
        public void H(){} // RVA: 0x7FFACBC36510
        public void DecryptBlock(){} // RVA: 0x7FFACBC36680
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBC368C0
    }

    public class TeaEngine : Object
    {
        public int AlgorithmName;
        public int IsPartialBlockOkay;
        public uint delta;
        public uint d_sum;
        public uint _a; // 0x10
        public uint _b; // 0x14
        public uint _c; // 0x18
        public uint _d; // 0x1C
        public bool _initialised; // 0x20
        public bool _forEncryption; // 0x21

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3D3C410
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC397E0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void Init(){} // RVA: 0x7FFACBC39820
        public void ProcessBlock(){} // RVA: 0x7FFACBC39980
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void setKey(){} // RVA: 0x7FFACBC39B50
        public void encryptBlock(){} // RVA: 0x7FFACBC39C80
        public void decryptBlock(){} // RVA: 0x7FFACBC39EA0
    }

    public class ThreefishEngine : Object
    {
        public int AlgorithmName;
        public int IsPartialBlockOkay;
        public int BLOCKSIZE_1024;
        public int TWEAK_SIZE_BYTES;
        public int TWEAK_SIZE_WORDS;
        public int ROUNDS_256;
        public int ROUNDS_512;
        public int ROUNDS_1024;
        public int MAX_ROUNDS;
        public ulong C_240;
        public int[] MOD9;
        public int[] MOD17; // 0x8
        public int[] MOD5; // 0x10
        public int[] MOD3; // 0x18
        public int blocksizeBytes; // 0x10
        public int blocksizeWords; // 0x14
        public ulong[] currentBlock; // 0x18
        public ulong[] t; // 0x20
        public ulong[] kw; // 0x28
        public ThreefishCipher cipher; // 0x30
        public bool forEncryption; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBC3A0C0
        public void .ctor(){} // RVA: 0x7FFACBC3A490
        public void Init(){} // RVA: 0x7FFACBC3AC10 | overloaded x2
        public void SetKey(){} // RVA: 0x7FFACBC3AEF0
        public void SetTweak(){} // RVA: 0x7FFACBC3B050
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC3B1C0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC2F6E5C0
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void ProcessBlock(){} // RVA: 0x7FFACBC3B490 | overloaded x2
        public void BytesToWord(){} // RVA: 0x7FFACBC3B610
        public void WordToBytes(){} // RVA: 0x7FFACBC3B760
        public void RotlXor(){} // RVA: 0x7FFACBC3B880
        public void XorRotr(){} // RVA: 0x7FFACBC3B8A0
    }

    public class TnepresEngine : SerpentEngineBase
    {
        public object AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC3F3C0
        public void MakeWorkingKey(){} // RVA: 0x7FFACBC3F400
        public void EncryptBlock(){} // RVA: 0x7FFACBC41280
        public void DecryptBlock(){} // RVA: 0x7FFACBC42D00
        public void .ctor(){} // RVA: 0x7FFACBC44B90
    }

    public class TwofishEngine : Object
    {
        public byte[,] AlgorithmName;
        public int IsPartialBlockOkay;
        public int P_01;
        public int P_02;
        public int P_03;
        public int P_04;
        public int P_10;
        public int P_11;
        public int P_12;
        public int P_13;
        public int P_14;
        public int P_20;
        public int P_21;
        public int P_22;
        public int P_23;
        public int P_24;
        public int P_30;
        public int P_31;
        public int P_32;
        public int P_33;
        public int P_34;
        public int GF256_FDBK;
        public int GF256_FDBK_2;
        public int GF256_FDBK_4;
        public int RS_GF_FDBK;
        public int ROUNDS;
        public int MAX_ROUNDS;
        public int BLOCK_SIZE;
        public int MAX_KEY_BITS;
        public int INPUT_WHITEN;
        public int OUTPUT_WHITEN;
        public int ROUND_SUBKEYS;
        public int TOTAL_SUBKEYS;
        public int SK_STEP;
        public int SK_BUMP;
        public int SK_ROTL;
        public bool encrypting; // 0x10
        public int[] gMDS0; // 0x18
        public int[] gMDS1; // 0x20
        public int[] gMDS2; // 0x28
        public int[] gMDS3; // 0x30
        public int[] gSubKeys; // 0x38
        public int[] gSBox; // 0x40
        public int k64Cnt; // 0x48
        public byte[] workingKey; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC44BE0
        public void Init(){} // RVA: 0x7FFACBC45100
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC452D0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void ProcessBlock(){} // RVA: 0x7FFACBC45310
        public void Reset(){} // RVA: 0x7FFACBC454D0
        public void GetBlockSize(){} // RVA: 0x7FFAC530B540
        public void SetKey(){} // RVA: 0x7FFACBC454F0
        public void EncryptBlock(){} // RVA: 0x7FFACBC46140
        public void DecryptBlock(){} // RVA: 0x7FFACBC46800
        public void F32(){} // RVA: 0x7FFACBC46EB0
        public void RS_MDS_Encode(){} // RVA: 0x7FFACBC47490
        public void RS_rem(){} // RVA: 0x7FFACBC47580
        public void LFSR1(){} // RVA: 0x7FFACBC475E0
        public void LFSR2(){} // RVA: 0x7FFACBC47600
        public void Mx_X(){} // RVA: 0x7FFACBC47630
        public void Mx_Y(){} // RVA: 0x7FFACBC47660
        public void M_b0(){} // RVA: 0x7FFAC85A61A0
        public void M_b1(){} // RVA: 0x7FFACBC476A0
        public void M_b2(){} // RVA: 0x7FFACBC476B0
        public void M_b3(){} // RVA: 0x7FFACBC476C0
        public void Fe32_0(){} // RVA: 0x7FFACBC476D0
        public void Fe32_3(){} // RVA: 0x7FFACBC47750
        public void BytesTo32Bits(){} // RVA: 0x7FFAC8462B70
        public void Bits32ToBytes(){} // RVA: 0x7FFAC845E5B0
        public void .cctor(){} // RVA: 0x7FFACBC477E0
    }

    public class VmpcEngine : Object
    {
        public byte AlgorithmName; // 0x10
        public byte[] P; // 0x18
        public byte s; // 0x20
        public byte[] workingIV; // 0x28
        public byte[] workingKey; // 0x30

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC478D0
        public void Init(){} // RVA: 0x7FFACBC47910
        public void InitKey(){} // RVA: 0x7FFACBC47BF0
        public void ProcessBytes(){} // RVA: 0x7FFACBC47E80
        public void Reset(){} // RVA: 0x7FFACBC480D0
        public void ReturnByte(){} // RVA: 0x7FFACBC480F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class VmpcKsa3Engine : VmpcEngine
    {
        public object AlgorithmName;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC481D0
        public void InitKey(){} // RVA: 0x7FFACBC48210
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class XSalsa20Engine : Salsa20Engine
    {
        public object AlgorithmName;
        public object NonceSize;

        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC48570
        public void get_NonceSize(){} // RVA: 0x7FFAC530B550
        public void SetKey(){} // RVA: 0x7FFACBC485B0
        public void .ctor(){} // RVA: 0x7FFACBC48A50
    }

    public class XteaEngine : Object
    {
        public int AlgorithmName;
        public int IsPartialBlockOkay;
        public int delta;
        public uint[] _S; // 0x10
        public uint[] _sum0; // 0x18
        public uint[] _sum1; // 0x20
        public bool _initialised; // 0x28
        public bool _forEncryption; // 0x29

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBC48AF0
        public void get_AlgorithmName(){} // RVA: 0x7FFACBC48C60
        public void get_IsPartialBlockOkay(){} // RVA: 0x7FFAC2F21320
        public void GetBlockSize(){} // RVA: 0x7FFAC3ED8E80
        public void Init(){} // RVA: 0x7FFACBC48CA0
        public void ProcessBlock(){} // RVA: 0x7FFACBC48F60
        public void Reset(){} // RVA: 0x7FFAC2F21310
        public void setKey(){} // RVA: 0x7FFACBC49130
        public void encryptBlock(){} // RVA: 0x7FFACBC492A0
        public void decryptBlock(){} // RVA: 0x7FFACBC494E0
    }

}