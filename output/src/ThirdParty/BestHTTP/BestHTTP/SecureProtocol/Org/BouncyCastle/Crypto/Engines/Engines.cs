// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
// Classes: 56
// Methods: 660

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Engines
{
    public class AesEngine : Object
    {
        // ── Methods ──
        public void Shift(){} // RVA: 0x7ADA86DD0
        public void FFmulX(){} // RVA: 0x7B141E240
        public void FFmulX2(){} // RVA: 0x7B141E260
        public void Inv_Mcol(){} // RVA: 0x7B141E290
        public void SubWord(){} // RVA: 0x7B141E340
        public void GenerateWorkingKey(){} // RVA: 0x7B141E420
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7B141F760
        public void get_AlgorithmName(){} // RVA: 0x7B141FA40
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void ProcessBlock(){} // RVA: 0x7B141FA80
        public void Reset(){} // RVA: 0x7A80D7310
        public void UnPackBlock(){} // RVA: 0x7B141FC50
        public void PackBlock(){} // RVA: 0x7B141FE10
        public void EncryptBlock(){} // RVA: 0x7B141FFB0
        public void DecryptBlock(){} // RVA: 0x7B1420D90
        public void .cctor(){} // RVA: 0x7B1421B60
    }

    public class AesFastEngine : Object
    {
        // ── Methods ──
        public void Shift(){} // RVA: 0x7ADA86DD0
        public void FFmulX(){} // RVA: 0x7B141E240
        public void FFmulX2(){} // RVA: 0x7B141E260
        public void Inv_Mcol(){} // RVA: 0x7B1421EF0
        public void SubWord(){} // RVA: 0x7B1421FA0
        public void GenerateWorkingKey(){} // RVA: 0x7B1422080
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7B14233C0
        public void get_AlgorithmName(){} // RVA: 0x7B1423530
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void ProcessBlock(){} // RVA: 0x7B1423570
        public void Reset(){} // RVA: 0x7A80D7310
        public void UnPackBlock(){} // RVA: 0x7B141FC50
        public void PackBlock(){} // RVA: 0x7B141FE10
        public void EncryptBlock(){} // RVA: 0x7B1423740
        public void DecryptBlock(){} // RVA: 0x7B14243A0
        public void .cctor(){} // RVA: 0x7B1425000
    }

    public class AesLightEngine : Object
    {
        // ── Methods ──
        public void Shift(){} // RVA: 0x7ADA86DD0
        public void FFmulX(){} // RVA: 0x7B141E240
        public void FFmulX2(){} // RVA: 0x7B141E260
        public void Mcol(){} // RVA: 0x7B1425750
        public void Inv_Mcol(){} // RVA: 0x7B14257E0
        public void SubWord(){} // RVA: 0x7B1425890
        public void GenerateWorkingKey(){} // RVA: 0x7B1425970
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7B1426CB0
        public void get_AlgorithmName(){} // RVA: 0x7B1426E20
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void ProcessBlock(){} // RVA: 0x7B1426E60
        public void Reset(){} // RVA: 0x7A80D7310
        public void UnPackBlock(){} // RVA: 0x7B141FC50
        public void PackBlock(){} // RVA: 0x7B141FE10
        public void EncryptBlock(){} // RVA: 0x7B1427030
        public void DecryptBlock(){} // RVA: 0x7B1428340
        public void .cctor(){} // RVA: 0x7B14290C0
    }

    public class AesWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1429300
    }

    public class BlowfishEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1429350
        public void Init(){} // RVA: 0x7B14295F0
        public void get_AlgorithmName(){} // RVA: 0x7B14297A0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void ProcessBlock(){} // RVA: 0x7B14297E0
        public void Reset(){} // RVA: 0x7A80D7310
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void F(){} // RVA: 0x7B14299A0
        public void ProcessTable(){} // RVA: 0x7B1429A30
        public void SetKey(){} // RVA: 0x7B1429C10
        public void EncryptBlock(){} // RVA: 0x7B1429FE0
        public void DecryptBlock(){} // RVA: 0x7B142A3B0
        public void .cctor(){} // RVA: 0x7B142A780
    }

    public class CamelliaEngine : Object
    {
        // ── Methods ──
        public void rightRotate(){} // RVA: 0x7B142AB40
        public void leftRotate(){} // RVA: 0x7B142AB60
        public void roldq(){} // RVA: 0x7B142AB80
        public void decroldq(){} // RVA: 0x7B142AD40
        public void roldqo32(){} // RVA: 0x7B142AF10
        public void decroldqo32(){} // RVA: 0x7B142B0D0
        public void bytes2uint(){} // RVA: 0x7B142B2A0
        public void uint2bytes(){} // RVA: 0x7B142B2F0
        public void camelliaF2(){} // RVA: 0x7B142B350
        public void camelliaFLs(){} // RVA: 0x7B142B700
        public void setKey(){} // RVA: 0x7B142B820
        public void processBlock128(){} // RVA: 0x7B142CEB0
        public void processBlock192or256(){} // RVA: 0x7B142D410
        public void .ctor(){} // RVA: 0x7B142D9C0
        public void Init(){} // RVA: 0x7B142DB90
        public void get_AlgorithmName(){} // RVA: 0x7B142DCB0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void ProcessBlock(){} // RVA: 0x7B142DCF0
        public void Reset(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B142DEA0
    }

    public class CamelliaLightEngine : Object
    {
        // ── Methods ──
        public void rightRotate(){} // RVA: 0x7B142AB40
        public void leftRotate(){} // RVA: 0x7B142AB60
        public void roldq(){} // RVA: 0x7B142AB80
        public void decroldq(){} // RVA: 0x7B142AD40
        public void roldqo32(){} // RVA: 0x7B142AF10
        public void decroldqo32(){} // RVA: 0x7B142B0D0
        public void bytes2uint(){} // RVA: 0x7B142B2A0
        public void uint2bytes(){} // RVA: 0x7B142B2F0
        public void lRot8(){} // RVA: 0x7B142E220
        public void sbox2(){} // RVA: 0x7B142E240
        public void sbox3(){} // RVA: 0x7B142E2D0
        public void sbox4(){} // RVA: 0x7B142E360
        public void camelliaF2(){} // RVA: 0x7B142E3F0
        public void camelliaFLs(){} // RVA: 0x7B142E7A0
        public void setKey(){} // RVA: 0x7B142E8C0
        public void processBlock128(){} // RVA: 0x7B142FF70
        public void processBlock192or256(){} // RVA: 0x7B1430510
        public void .ctor(){} // RVA: 0x7B1430B20
        public void get_AlgorithmName(){} // RVA: 0x7B1430CF0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void Init(){} // RVA: 0x7B1430D30
        public void ProcessBlock(){} // RVA: 0x7B1430E50
        public void Reset(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1431000
    }

    public class CamelliaWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14311B0
    }

    public class Cast5Engine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1431210
        public void Init(){} // RVA: 0x7B1431360
        public void get_AlgorithmName(){} // RVA: 0x7B1431540
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void ProcessBlock(){} // RVA: 0x7B1431580
        public void Reset(){} // RVA: 0x7A80D7310
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void SetKey(){} // RVA: 0x7B1431780
        public void EncryptBlock(){} // RVA: 0x7B1436E00
        public void DecryptBlock(){} // RVA: 0x7B1437030
        public void F1(){} // RVA: 0x7B1437260
        public void F2(){} // RVA: 0x7B1437380
        public void F3(){} // RVA: 0x7B14374A0
        public void CAST_Encipher(){} // RVA: 0x7B14375C0
        public void CAST_Decipher(){} // RVA: 0x7B1437810
        public void Bits32ToInts(){} // RVA: 0x7B1437A80
        public void IntsTo32bits(){} // RVA: 0x7B1437B00
        public void .cctor(){} // RVA: 0x7B1437B80
    }

    public class Cast6Engine : Cast5Engine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1438100
        public void get_AlgorithmName(){} // RVA: 0x7B1438370
        public void Reset(){} // RVA: 0x7A80D7310
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void SetKey(){} // RVA: 0x7B14383B0
        public void EncryptBlock(){} // RVA: 0x7B1439000
        public void DecryptBlock(){} // RVA: 0x7B14393E0
        public void CAST_Encipher(){} // RVA: 0x7B14397C0
        public void CAST_Decipher(){} // RVA: 0x7B1439B30
    }

    public class ChaCha7539Engine : Salsa20Engine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1439EA0
        public void get_AlgorithmName(){} // RVA: 0x7B1439F40
        public void get_NonceSize(){} // RVA: 0x7A9F22B10
        public void AdvanceCounter(){} // RVA: 0x7B1439F90
        public void ResetCounter(){} // RVA: 0x7B143A010
        public void SetKey(){} // RVA: 0x7B143A040
        public void GenerateKeyStream(){} // RVA: 0x7B143A240
    }

    public class ChaChaEngine : Salsa20Engine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B143A3A0
        public void get_AlgorithmName(){} // RVA: 0x7B143A400
        public void AdvanceCounter(){} // RVA: 0x7B143A450
        public void ResetCounter(){} // RVA: 0x7B143A490
        public void SetKey(){} // RVA: 0x7B143A4D0
        public void GenerateKeyStream(){} // RVA: 0x7B143A240
        public void ChachaCore(){} // RVA: 0x7B143A780
    }

    public class DesEdeEngine : DesEngine
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B143AEF0
        public void get_AlgorithmName(){} // RVA: 0x7B143B350
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void ProcessBlock(){} // RVA: 0x7B143B390
        public void Reset(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7B143B620
    }

    public class DesEdeWrapEngine : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B143B670
        public void get_AlgorithmName(){} // RVA: 0x7B143BCC0
        public void Wrap(){} // RVA: 0x7B143BD00
        public void Unwrap(){} // RVA: 0x7B143C160
        public void CalculateCmsKeyChecksum(){} // RVA: 0x7B143C810
        public void CheckCmsKeyChecksum(){} // RVA: 0x7B143C900
        public void reverse(){} // RVA: 0x7B143C9F0
        public void .ctor(){} // RVA: 0x7B143CA90
        public void .cctor(){} // RVA: 0x7B143CBB0
    }

    public class DesEngine : Object
    {
        // ── Methods ──
        public void GetWorkingKey(){} // RVA: 0x7A80F2570
        public void Init(){} // RVA: 0x7B143CC90
        public void get_AlgorithmName(){} // RVA: 0x7B143CE50
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void ProcessBlock(){} // RVA: 0x7B143CE90
        public void Reset(){} // RVA: 0x7A80D7310
        public void GenerateWorkingKey(){} // RVA: 0x7B143D060
        public void DesFunc(){} // RVA: 0x7B143D650
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B143DD60
    }

    public class Dstu7624Engine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B143E620
        public void Init(){} // RVA: 0x7B143E720
        public void WorkingKeyExpandKT(){} // RVA: 0x7B143EC10
        public void WorkingKeyExpandEven(){} // RVA: 0x7B143EF00
        public void WorkingKeyExpandOdd(){} // RVA: 0x7B143F390
        public void ProcessBlock(){} // RVA: 0x7B143F410
        public void EncryptionRound(){} // RVA: 0x7B143F7B0
        public void DecryptionRound(){} // RVA: 0x7B143F880
        public void DecryptBlock_128(){} // RVA: 0x7B143F950
        public void EncryptBlock_128(){} // RVA: 0x7B143FEF0
        public void SubBytes(){} // RVA: 0x7B1440560
        public void InvSubBytes(){} // RVA: 0x7B1440810
        public void ShiftRows(){} // RVA: 0x7B1440AC0
        public void InvShiftRows(){} // RVA: 0x7B1440F90
        public void AddRoundKey(){} // RVA: 0x7B1441460
        public void SubRoundKey(){} // RVA: 0x7B14414E0
        public void XorRoundKey(){} // RVA: 0x7B1441560
        public void MixColumn(){} // RVA: 0x7B14415E0
        public void MixColumns(){} // RVA: 0x7B1441710
        public void MixColumnInv(){} // RVA: 0x7B14417D0
        public void MixColumnsInv(){} // RVA: 0x7B14419E0
        public void MulX(){} // RVA: 0x7B1441AA0
        public void MulX2(){} // RVA: 0x7B1441AD0
        public void Rotate(){} // RVA: 0x7B1441B20
        public void RotateLeft(){} // RVA: 0x7B1441B40
        public void get_AlgorithmName(){} // RVA: 0x7B1441E80
        public void GetBlockSize(){} // RVA: 0x7B1441EC0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void Reset(){} // RVA: 0x7B1441ED0
        public void .cctor(){} // RVA: 0x7B1441F00
    }

    public class Dstu7624WrapEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1442460
        public void get_AlgorithmName(){} // RVA: 0x7B1442580
        public void Init(){} // RVA: 0x7B14425C0
        public void Wrap(){} // RVA: 0x7B1442780
        public void Unwrap(){} // RVA: 0x7B1442F40
    }

    public class ElGamalEngine : Object
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B1443890
        public void Init(){} // RVA: 0x7B14438D0
        public void GetInputBlockSize(){} // RVA: 0x7B1443DC0
        public void GetOutputBlockSize(){} // RVA: 0x7B1443DF0
        public void ProcessBlock(){} // RVA: 0x7B1443E20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Gost28147Engine : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B1444400
        public void AddSBox(){} // RVA: 0x7B1444BB0
        public void .ctor(){} // RVA: 0x7B1444C90
        public void Init(){} // RVA: 0x7B1444D40
        public void get_AlgorithmName(){} // RVA: 0x7B1445170
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void ProcessBlock(){} // RVA: 0x7B14451B0
        public void Reset(){} // RVA: 0x7A80D7310
        public void generateWorkingKey(){} // RVA: 0x7B1445360
        public void Gost28147_mainStep(){} // RVA: 0x7B14454D0
        public void Gost28147Func(){} // RVA: 0x7B1445650
        public void bytesToint(){} // RVA: 0x7B13FF350
        public void intTobytes(){} // RVA: 0x7B13FF3D0
        public void GetSBox(){} // RVA: 0x7B1445A10
        public void GetSBoxName(){} // RVA: 0x7B1445BF0
    }

    public class HC128Engine : Object
    {
        // ── Methods ──
        public void F1(){} // RVA: 0x7B1445F70
        public void F2(){} // RVA: 0x7B1445FA0
        public void G1(){} // RVA: 0x7B1445FD0
        public void G2(){} // RVA: 0x7B1446000
        public void RotateLeft(){} // RVA: 0x7ADC859A0
        public void RotateRight(){} // RVA: 0x7ADA86DD0
        public void H1(){} // RVA: 0x7B1446030
        public void H2(){} // RVA: 0x7B1446080
        public void Mod1024(){} // RVA: 0x7B14460D0
        public void Mod512(){} // RVA: 0x7B14460E0
        public void Dim(){} // RVA: 0x7B14460F0
        public void Step(){} // RVA: 0x7B1446100
        public void Init(){} // RVA: 0x7B1446750
        public void get_AlgorithmName(){} // RVA: 0x7B1446710
        public void GetByte(){} // RVA: 0x7B1446AB0
        public void ProcessBytes(){} // RVA: 0x7B1446B40
        public void Reset(){} // RVA: 0x7B1446E10
        public void ReturnByte(){} // RVA: 0x7B1446E20
        public void .ctor(){} // RVA: 0x7B1446E40
    }

    public class HC256Engine : Object
    {
        // ── Methods ──
        public void Step(){} // RVA: 0x7B1446FC0
        public void Init(){} // RVA: 0x7B1447830
        public void get_AlgorithmName(){} // RVA: 0x7B14477F0
        public void GetByte(){} // RVA: 0x7B1447B90
        public void ProcessBytes(){} // RVA: 0x7B1447C20
        public void Reset(){} // RVA: 0x7B1447EF0
        public void ReturnByte(){} // RVA: 0x7B1447F00
        public void RotateRight(){} // RVA: 0x7ADA86DD0
        public void .ctor(){} // RVA: 0x7B1447F20
    }

    public class IdeaEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7B14480A0
        public void get_AlgorithmName(){} // RVA: 0x7B1448250
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void ProcessBlock(){} // RVA: 0x7B1448290
        public void Reset(){} // RVA: 0x7A80D7310
        public void BytesToWord(){} // RVA: 0x7B1448440
        public void WordToBytes(){} // RVA: 0x7B1448480
        public void Mul(){} // RVA: 0x7B14484C0
        public void IdeaFunc(){} // RVA: 0x7B14485C0
        public void ExpandKey(){} // RVA: 0x7B14489C0
        public void MulInv(){} // RVA: 0x7B1448BE0
        public void AddInv(){} // RVA: 0x7B1448D30
        public void InvertKey(){} // RVA: 0x7B1448D90
        public void GenerateWorkingKey(){} // RVA: 0x7B1449340
        public void .cctor(){} // RVA: 0x7B1449380
    }

    public class IesEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14495D0
        public void Init(){} // RVA: 0x7B1449810
        public void DecryptBlock(){} // RVA: 0x7B1449A00
        public void EncryptBlock(){} // RVA: 0x7B1449F80
        public void GenerateKdfBytes(){} // RVA: 0x7B144A420
        public void ProcessBlock(){} // RVA: 0x7B144A4E0
    }

    public class IsaacEngine : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B144A660
        public void ReturnByte(){} // RVA: 0x7B144A7A0
        public void ProcessBytes(){} // RVA: 0x7B144A850
        public void get_AlgorithmName(){} // RVA: 0x7B144AAD0
        public void Reset(){} // RVA: 0x7B144AB10
        public void setKey(){} // RVA: 0x7B144AB20
        public void isaac(){} // RVA: 0x7B144B0D0
        public void mix(){} // RVA: 0x7B144B250
        public void .ctor(){} // RVA: 0x7B144B490
        public void .cctor(){} // RVA: 0x7B144B560
    }

    public class NaccacheSternEngine : Object
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B144B5C0
        public void Init(){} // RVA: 0x7B144B600
        public void set_Debug(){} // RVA: 0x7A80D7310
        public void GetInputBlockSize(){} // RVA: 0x7B144BBE0
        public void GetOutputBlockSize(){} // RVA: 0x7B144BC30
        public void ProcessBlock(){} // RVA: 0x7B144BC80
        public void Encrypt(){} // RVA: 0x7B144C420
        public void AddCryptedBlocks(){} // RVA: 0x7B144C510
        public void ProcessData(){} // RVA: 0x7B144C7D0
        public void chineseRemainder(){} // RVA: 0x7B144C9C0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class NoekeonEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B144CF80
        public void get_AlgorithmName(){} // RVA: 0x7B144D0F0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void Init(){} // RVA: 0x7B144D130
        public void ProcessBlock(){} // RVA: 0x7B144D2A0
        public void Reset(){} // RVA: 0x7A80D7310
        public void setKey(){} // RVA: 0x7B144D470
        public void encryptBlock(){} // RVA: 0x7B144D600
        public void decryptBlock(){} // RVA: 0x7B144DE70
        public void gamma(){} // RVA: 0x7B144E830
        public void theta(){} // RVA: 0x7B144E8F0
        public void pi1(){} // RVA: 0x7B144E9E0
        public void pi2(){} // RVA: 0x7B144EA40
        public void rotl(){} // RVA: 0x7B144EAA0
        public void .cctor(){} // RVA: 0x7B144EAC0
    }

    public class NullEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7A847A240
        public void get_AlgorithmName(){} // RVA: 0x7B144EC30
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A81BD750
        public void GetBlockSize(){} // RVA: 0x7A81CA9D0
        public void ProcessBlock(){} // RVA: 0x7B144EC70
        public void Reset(){} // RVA: 0x7A80D7310
    }

    public class RC2Engine : Object
    {
        // ── Methods ──
        public void GenerateWorkingKey(){} // RVA: 0x7B144EE40
        public void Init(){} // RVA: 0x7B144F190
        public void Reset(){} // RVA: 0x7A80D7310
        public void get_AlgorithmName(){} // RVA: 0x7B144F450
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void ProcessBlock(){} // RVA: 0x7B144F490
        public void RotateWordLeft(){} // RVA: 0x7B144F650
        public void EncryptBlock(){} // RVA: 0x7B144F670
        public void DecryptBlock(){} // RVA: 0x7B144FBD0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1450110
    }

    public class RC2WrapEngine : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14501F0
        public void get_AlgorithmName(){} // RVA: 0x7B1450840
        public void Wrap(){} // RVA: 0x7B1450880
        public void Unwrap(){} // RVA: 0x7B1450E70
        public void CalculateCmsKeyChecksum(){} // RVA: 0x7B1451790
        public void CheckCmsKeyChecksum(){} // RVA: 0x7B1451880
        public void .ctor(){} // RVA: 0x7B1451970
        public void .cctor(){} // RVA: 0x7B1451A90
    }

    public class RC4Engine : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B1451B70
        public void get_AlgorithmName(){} // RVA: 0x7B1451D00
        public void ReturnByte(){} // RVA: 0x7B1451D40
        public void ProcessBytes(){} // RVA: 0x7B1451E10
        public void Reset(){} // RVA: 0x7B1452070
        public void SetKey(){} // RVA: 0x7B1452080
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B14522F0
    }

    public class RC532Engine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1452330
        public void get_AlgorithmName(){} // RVA: 0x7B1452340
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void Init(){} // RVA: 0x7B1452380
        public void ProcessBlock(){} // RVA: 0x7B1452630
        public void Reset(){} // RVA: 0x7A80D7310
        public void SetKey(){} // RVA: 0x7B1452660
        public void EncryptBlock(){} // RVA: 0x7B14529A0
        public void DecryptBlock(){} // RVA: 0x7B1452C10
        public void RotateLeft(){} // RVA: 0x7B1452E90
        public void RotateRight(){} // RVA: 0x7B1452EB0
        public void BytesToWord(){} // RVA: 0x7ADAB97D0
        public void WordToBytes(){} // RVA: 0x7ADAB51C0
        public void .cctor(){} // RVA: 0x7B1452ED0
    }

    public class RC564Engine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1452330
        public void get_AlgorithmName(){} // RVA: 0x7B1452F30
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7B1452F70
        public void Init(){} // RVA: 0x7B1452FD0
        public void ProcessBlock(){} // RVA: 0x7B14531D0
        public void Reset(){} // RVA: 0x7A80D7310
        public void SetKey(){} // RVA: 0x7B1453200
        public void EncryptBlock(){} // RVA: 0x7B1453650
        public void DecryptBlock(){} // RVA: 0x7B1453AB0
        public void RotateLeft(){} // RVA: 0x7B1453F20
        public void RotateRight(){} // RVA: 0x7B1453FB0
        public void BytesToWord(){} // RVA: 0x7B1454040
        public void WordToBytes(){} // RVA: 0x7B14540F0
        public void .cctor(){} // RVA: 0x7B14541B0
    }

    public class RC6Engine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_AlgorithmName(){} // RVA: 0x7B1454250
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7B1454290
        public void Init(){} // RVA: 0x7B14542F0
        public void ProcessBlock(){} // RVA: 0x7B1454440
        public void Reset(){} // RVA: 0x7A80D7310
        public void SetKey(){} // RVA: 0x7B1454610
        public void EncryptBlock(){} // RVA: 0x7B1454A60
        public void DecryptBlock(){} // RVA: 0x7B14552D0
        public void RotateLeft(){} // RVA: 0x7B1455B40
        public void RotateRight(){} // RVA: 0x7B1455BD0
        public void BytesToWord(){} // RVA: 0x7B1455C60
        public void WordToBytes(){} // RVA: 0x7B1455D10
        public void .cctor(){} // RVA: 0x7B1455DD0
    }

    public class Rfc3211WrapEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1455E90
        public void Init(){} // RVA: 0x7B1455F50
        public void get_AlgorithmName(){} // RVA: 0x7B14562B0
        public void Wrap(){} // RVA: 0x7B1456330
        public void Unwrap(){} // RVA: 0x7B14565E0
    }

    public class Rfc3394WrapEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1456A70
        public void Init(){} // RVA: 0x7B1456BA0
        public void get_AlgorithmName(){} // RVA: 0x7B1456F20
        public void Wrap(){} // RVA: 0x7B1456F70
        public void Unwrap(){} // RVA: 0x7B14572D0
    }

    public class RijndaelEngine : Object
    {
        // ── Methods ──
        public void Mul0x2(){} // RVA: 0x7B1457770
        public void Mul0x3(){} // RVA: 0x7B1457810
        public void Mul0x9(){} // RVA: 0x7B14578B0
        public void Mul0xb(){} // RVA: 0x7B1457940
        public void Mul0xd(){} // RVA: 0x7B14579D0
        public void Mul0xe(){} // RVA: 0x7B1457A60
        public void KeyAddition(){} // RVA: 0x7B1457AF0
        public void Shift(){} // RVA: 0x7B1457B60
        public void ShiftRow(){} // RVA: 0x7B1457B90
        public void ApplyS(){} // RVA: 0x7B1457C70
        public void Substitution(){} // RVA: 0x7B1457CD0
        public void MixColumn(){} // RVA: 0x7B1457E40
        public void InvMixColumn(){} // RVA: 0x7B1457FE0
        public void GenerateWorkingKey(){} // RVA: 0x7B14583B0
        public void .ctor(){} // RVA: 0x7B1458D10
        public void Init(){} // RVA: 0x7B1459210
        public void get_AlgorithmName(){} // RVA: 0x7B1459460
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7B14594A0
        public void ProcessBlock(){} // RVA: 0x7B14594B0
        public void Reset(){} // RVA: 0x7A80D7310
        public void UnPackBlock(){} // RVA: 0x7B1459800
        public void PackBlock(){} // RVA: 0x7B1459940
        public void EncryptBlock(){} // RVA: 0x7B1459A00
        public void DecryptBlock(){} // RVA: 0x7B1459C50
        public void .cctor(){} // RVA: 0x7B1459EB0
    }

    public class RsaBlindedEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_AlgorithmName(){} // RVA: 0x7B145A6B0
        public void Init(){} // RVA: 0x7B145A6F0
        public void GetInputBlockSize(){} // RVA: 0x7B145ABF0
        public void GetOutputBlockSize(){} // RVA: 0x7B145AC40
        public void ProcessBlock(){} // RVA: 0x7B145AC90
    }

    public class RsaBlindingEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_AlgorithmName(){} // RVA: 0x7B145B060
        public void Init(){} // RVA: 0x7B145B0A0
        public void GetInputBlockSize(){} // RVA: 0x7B145B2E0
        public void GetOutputBlockSize(){} // RVA: 0x7B145B330
        public void ProcessBlock(){} // RVA: 0x7B145B380
        public void BlindMessage(){} // RVA: 0x7B145B590
        public void UnblindMessage(){} // RVA: 0x7B145B680
    }

    public class RsaCoreEngine : Object
    {
        // ── Methods ──
        public void CheckInitialised(){} // RVA: 0x7B145B760
        public void Init(){} // RVA: 0x7B145B7D0
        public void GetInputBlockSize(){} // RVA: 0x7B145BA00
        public void GetOutputBlockSize(){} // RVA: 0x7B145BA90
        public void ConvertInput(){} // RVA: 0x7B145BB20
        public void ConvertOutput(){} // RVA: 0x7B145BCE0
        public void ProcessBlock(){} // RVA: 0x7B145BDF0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RsaEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_AlgorithmName(){} // RVA: 0x7B145C0B0
        public void Init(){} // RVA: 0x7B145C0F0
        public void GetInputBlockSize(){} // RVA: 0x7B145C160
        public void GetOutputBlockSize(){} // RVA: 0x7B145C1B0
        public void ProcessBlock(){} // RVA: 0x7B145C200
    }

    public class SM2Engine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Init(){} // RVA: 0x7B1466500
        public void ProcessBlock(){} // RVA: 0x7B14669C0
        public void CreateBasePointMultiplier(){} // RVA: 0x7B14669F0
        public void Encrypt(){} // RVA: 0x7B1466A30
        public void Decrypt(){} // RVA: 0x7B1467030
        public void NotEncrypted(){} // RVA: 0x7B14675A0
        public void Kdf(){} // RVA: 0x7B1467610
        public void Xor(){} // RVA: 0x7B1467AD0
        public void NextK(){} // RVA: 0x7B1467B40
        public void AddFieldElement(){} // RVA: 0x7B1467C10
    }

    public class SM4Engine : Object
    {
        // ── Methods ──
        public void tau(){} // RVA: 0x7B1467CA0
        public void L_ap(){} // RVA: 0x7B1467DA0
        public void T_ap(){} // RVA: 0x7B1467DC0
        public void ExpandKey(){} // RVA: 0x7B1467E30
        public void L(){} // RVA: 0x7B1468660
        public void T(){} // RVA: 0x7B1468690
        public void Init(){} // RVA: 0x7B1468710
        public void get_AlgorithmName(){} // RVA: 0x7B14688E0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void ProcessBlock(){} // RVA: 0x7B1468920
        public void Reset(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1469050
    }

    public class Salsa20Engine : Object
    {
        // ── Methods ──
        public void PackTauOrSigma(){} // RVA: 0x7B145C2A0
        public void .ctor(){} // RVA: 0x7B145C470
        public void Init(){} // RVA: 0x7B145C640
        public void get_NonceSize(){} // RVA: 0x7A88217C0
        public void get_AlgorithmName(){} // RVA: 0x7B145C9E0
        public void ReturnByte(){} // RVA: 0x7B145CAB0
        public void AdvanceCounter(){} // RVA: 0x7B145CB90
        public void ProcessBytes(){} // RVA: 0x7B145CBD0
        public void Reset(){} // RVA: 0x7B145CEC0
        public void ResetCounter(){} // RVA: 0x7B145CEE0
        public void SetKey(){} // RVA: 0x7B145CF20
        public void GenerateKeyStream(){} // RVA: 0x7B145D320
        public void SalsaCore(){} // RVA: 0x7B145D440
        public void R(){} // RVA: 0x7ADC859A0
        public void ResetLimitCounter(){} // RVA: 0x7B145DBF0
        public void LimitExceeded(){} // RVA: 0x7B145DC20
        public void .cctor(){} // RVA: 0x7B145DC50
    }

    public class SeedEngine : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B145DF90
        public void get_AlgorithmName(){} // RVA: 0x7B145E090
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void ProcessBlock(){} // RVA: 0x7B145E0D0
        public void Reset(){} // RVA: 0x7A80D7310
        public void createWorkingKey(){} // RVA: 0x7B145E420
        public void extractW1(){} // RVA: 0x7AB93BE00
        public void extractW0(){} // RVA: 0x7B145E680
        public void rotateLeft8(){} // RVA: 0x7B145E690
        public void rotateRight8(){} // RVA: 0x7B145E6A0
        public void bytesToLong(){} // RVA: 0x7B145E6B0
        public void longToBytes(){} // RVA: 0x7B145E700
        public void G(){} // RVA: 0x7B145E750
        public void F(){} // RVA: 0x7B145E840
        public void phaseCalc1(){} // RVA: 0x7B145E900
        public void phaseCalc2(){} // RVA: 0x7B145E950
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B145E9E0
    }

    public class SeedWrapEngine : Rfc3394WrapEngine
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B145ED60
    }

    public class SerpentEngine : SerpentEngineBase
    {
        // ── Methods ──
        public void MakeWorkingKey(){} // RVA: 0x7B145EDB0
        public void EncryptBlock(){} // RVA: 0x7B1460C50
        public void DecryptBlock(){} // RVA: 0x7B1462900
        public void .ctor(){} // RVA: 0x7B14647B0
    }

    public class SerpentEngineBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Init(){} // RVA: 0x7B1464800
        public void get_AlgorithmName(){} // RVA: 0x7B14649E0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7B1464A20
        public void ProcessBlock(){} // RVA: 0x7B1464A80
        public void Reset(){} // RVA: 0x7A80D7310
        public void RotateLeft(){} // RVA: 0x7ADC859A0
        public void RotateRight(){} // RVA: 0x7ADA86DD0
        public void Sb0(){} // RVA: 0x7B1464CD0
        public void Ib0(){} // RVA: 0x7B1464D30
        public void Sb1(){} // RVA: 0x7B1464DA0
        public void Ib1(){} // RVA: 0x7B1464E00
        public void Sb2(){} // RVA: 0x7B1464E60
        public void Ib2(){} // RVA: 0x7B1464EE0
        public void Sb3(){} // RVA: 0x7B1464F50
        public void Ib3(){} // RVA: 0x7B1464FD0
        public void Sb4(){} // RVA: 0x7B1465030
        public void Ib4(){} // RVA: 0x7B1465090
        public void Sb5(){} // RVA: 0x7B1465100
        public void Ib5(){} // RVA: 0x7B1465170
        public void Sb6(){} // RVA: 0x7B14651E0
        public void Ib6(){} // RVA: 0x7B1465240
        public void Sb7(){} // RVA: 0x7B14652B0
        public void Ib7(){} // RVA: 0x7B1465320
        public void LT(){} // RVA: 0x7B14653A0
        public void InverseLT(){} // RVA: 0x7B1465480
        public void MakeWorkingKey(){} // RVA: 0x7A7E00B20
        public void EncryptBlock(){} // RVA: 0x7A7E1E270
        public void DecryptBlock(){} // RVA: 0x7A7E1E270
        public void .cctor(){} // RVA: 0x7B1465560
    }

    public class SkipjackEngine : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7B14655A0
        public void get_AlgorithmName(){} // RVA: 0x7B1465A20
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void ProcessBlock(){} // RVA: 0x7B1465A60
        public void Reset(){} // RVA: 0x7A80D7310
        public void G(){} // RVA: 0x7B1465C30
        public void EncryptBlock(){} // RVA: 0x7B1465DA0
        public void H(){} // RVA: 0x7B1465FD0
        public void DecryptBlock(){} // RVA: 0x7B1466140
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1466380
    }

    public class TeaEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE089FA0
        public void get_AlgorithmName(){} // RVA: 0x7B14692A0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void Init(){} // RVA: 0x7B14692E0
        public void ProcessBlock(){} // RVA: 0x7B1469440
        public void Reset(){} // RVA: 0x7A80D7310
        public void setKey(){} // RVA: 0x7B1469610
        public void encryptBlock(){} // RVA: 0x7B1469740
        public void decryptBlock(){} // RVA: 0x7B1469960
    }

    public class ThreefishEngine : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B1469B80
        public void .ctor(){} // RVA: 0x7B1469F40
        public void Init(){} // RVA: 0x7B146A6E0
        public void SetKey(){} // RVA: 0x7B146A9C0
        public void SetTweak(){} // RVA: 0x7B146AB10
        public void get_AlgorithmName(){} // RVA: 0x7B146AC80
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A8124910
        public void Reset(){} // RVA: 0x7A80D7310
        public void ProcessBlock(){} // RVA: 0x7B146AF50
        public void BytesToWord(){} // RVA: 0x7B146B0D0
        public void WordToBytes(){} // RVA: 0x7B146B220
        public void RotlXor(){} // RVA: 0x7B146B340
        public void XorRotr(){} // RVA: 0x7B146B360
    }

    public class TnepresEngine : SerpentEngineBase
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B146EE30
        public void MakeWorkingKey(){} // RVA: 0x7B146EE70
        public void EncryptBlock(){} // RVA: 0x7B1470CD0
        public void DecryptBlock(){} // RVA: 0x7B1472990
        public void .ctor(){} // RVA: 0x7B1474850
    }

    public class TwofishEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14748A0
        public void Init(){} // RVA: 0x7B1474DE0
        public void get_AlgorithmName(){} // RVA: 0x7B1474FB0
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void ProcessBlock(){} // RVA: 0x7B1474FF0
        public void Reset(){} // RVA: 0x7B14751B0
        public void GetBlockSize(){} // RVA: 0x7A9F22B20
        public void SetKey(){} // RVA: 0x7B14751D0
        public void EncryptBlock(){} // RVA: 0x7B1475E80
        public void DecryptBlock(){} // RVA: 0x7B1476560
        public void F32(){} // RVA: 0x7B1476C30
        public void RS_MDS_Encode(){} // RVA: 0x7B1477200
        public void RS_rem(){} // RVA: 0x7B14772F0
        public void LFSR1(){} // RVA: 0x7B1477350
        public void LFSR2(){} // RVA: 0x7B1477370
        public void Mx_X(){} // RVA: 0x7B14773A0
        public void Mx_Y(){} // RVA: 0x7B14773D0
        public void M_b0(){} // RVA: 0x7A8D963F0
        public void M_b1(){} // RVA: 0x7B1477410
        public void M_b2(){} // RVA: 0x7B1477420
        public void M_b3(){} // RVA: 0x7B1477430
        public void Fe32_0(){} // RVA: 0x7B1477440
        public void Fe32_3(){} // RVA: 0x7B14774D0
        public void BytesTo32Bits(){} // RVA: 0x7ADAB97D0
        public void Bits32ToBytes(){} // RVA: 0x7ADAB51C0
        public void .cctor(){} // RVA: 0x7B1477560
    }

    public class VmpcEngine : Object
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B1477650
        public void Init(){} // RVA: 0x7B1477690
        public void InitKey(){} // RVA: 0x7B1477960
        public void ProcessBytes(){} // RVA: 0x7B1477C00
        public void Reset(){} // RVA: 0x7B1477E60
        public void ReturnByte(){} // RVA: 0x7B1477E80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class VmpcKsa3Engine : VmpcEngine
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B1477F80
        public void InitKey(){} // RVA: 0x7B1477FC0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class XSalsa20Engine : Salsa20Engine
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B1478340
        public void get_NonceSize(){} // RVA: 0x7A9F22B00
        public void SetKey(){} // RVA: 0x7B1478380
        public void .ctor(){} // RVA: 0x7B1478800
    }

    public class XteaEngine : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14788A0
        public void get_AlgorithmName(){} // RVA: 0x7B1478A10
        public void get_IsPartialBlockOkay(){} // RVA: 0x7A80D7320
        public void GetBlockSize(){} // RVA: 0x7A88217C0
        public void Init(){} // RVA: 0x7B1478A50
        public void ProcessBlock(){} // RVA: 0x7B1478D00
        public void Reset(){} // RVA: 0x7A80D7310
        public void setKey(){} // RVA: 0x7B1478ED0
        public void encryptBlock(){} // RVA: 0x7B1479030
        public void decryptBlock(){} // RVA: 0x7B1479270
    }

}