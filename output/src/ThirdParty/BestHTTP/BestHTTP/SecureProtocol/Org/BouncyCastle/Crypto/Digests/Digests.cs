// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
// Classes: 33
// Methods: 459

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
    public class Blake2bDigest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1484820
        public void Init(){} // RVA: 0x7B1484BB0
        public void InitializeInternalState(){} // RVA: 0x7B1484F90
        public void Update(){} // RVA: 0x7B1485160
        public void BlockUpdate(){} // RVA: 0x7B1485210
        public void DoFinal(){} // RVA: 0x7B1485360
        public void Reset(){} // RVA: 0x7B1485540
        public void Compress(){} // RVA: 0x7B1485620
        public void G(){} // RVA: 0x7B1485D20
        public void Rotr64(){} // RVA: 0x7ADA88A90
        public void get_AlgorithmName(){} // RVA: 0x7B1485F80
        public void GetDigestSize(){} // RVA: 0x7A8124910
        public void GetByteLength(){} // RVA: 0x7A9F260C0
        public void ClearKey(){} // RVA: 0x7B1485FC0
        public void ClearSalt(){} // RVA: 0x7B1486020
        public void .cctor(){} // RVA: 0x7B1486040
    }

    public class Blake2sDigest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14869A0
        public void Init(){} // RVA: 0x7B1486D30
        public void InitializeInternalState(){} // RVA: 0x7B14871E0
        public void Update(){} // RVA: 0x7B1487390
        public void BlockUpdate(){} // RVA: 0x7B1487440
        public void DoFinal(){} // RVA: 0x7B1487590
        public void Reset(){} // RVA: 0x7B1487790
        public void Compress(){} // RVA: 0x7B1487860
        public void G(){} // RVA: 0x7B1487FC0
        public void rotr32(){} // RVA: 0x7B14881A0
        public void get_AlgorithmName(){} // RVA: 0x7B14881C0
        public void GetDigestSize(){} // RVA: 0x7A8124910
        public void GetByteLength(){} // RVA: 0x7A88EE450
        public void ClearKey(){} // RVA: 0x7B1485FC0
        public void ClearSalt(){} // RVA: 0x7B1486020
        public void .cctor(){} // RVA: 0x7B1488200
    }

    public class Dstu7564Digest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1488710
        public void CopyIn(){} // RVA: 0x7B14883D0
        public void get_AlgorithmName(){} // RVA: 0x7B14889B0
        public void GetDigestSize(){} // RVA: 0x7A8124910
        public void GetByteLength(){} // RVA: 0x7A8668BC0
        public void Update(){} // RVA: 0x7B14889F0
        public void BlockUpdate(){} // RVA: 0x7B1488A60
        public void DoFinal(){} // RVA: 0x7B1488B90
        public void Reset(){} // RVA: 0x7B148A1C0
        public void ProcessBlock(){} // RVA: 0x7B1488FE0
        public void P(){} // RVA: 0x7B1489210
        public void Q(){} // RVA: 0x7B14892C0
        public void MixColumn(){} // RVA: 0x7B14893A0
        public void MixColumns(){} // RVA: 0x7B14894E0
        public void Rotate(){} // RVA: 0x7B1441B20
        public void ShiftRows(){} // RVA: 0x7B14896E0
        public void SubBytes(){} // RVA: 0x7B1489ED0
        public void Copy(){} // RVA: 0x7B148A160
        public void .cctor(){} // RVA: 0x7B148A250
    }

    public class GeneralDigest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B148A5C0
        public void CopyIn(){} // RVA: 0x7B148A6B0
        public void Update(){} // RVA: 0x7B148A710
        public void BlockUpdate(){} // RVA: 0x7B148A790
        public void Finish(){} // RVA: 0x7B148A930
        public void Reset(){} // RVA: 0x7A7E18800
        public void GetByteLength(){} // RVA: 0x7A88EE450
        public void ProcessWord(){} // RVA: 0x7A7E1D590
        public void ProcessLength(){} // RVA: 0x7A7E188D0
        public void ProcessBlock(){} // RVA: 0x7A7E18770
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void GetDigestSize(){} // RVA: 0x7A7E00710
        public void DoFinal(){} // RVA: 0x7A7E09FB0
        public void Copy(){} // RVA: 0x7A7E00680
    }

    public class Gost3411Digest : Object
    {
        // ── Methods ──
        public void MakeC(){} // RVA: 0x7B148AA50
        public void .ctor(){} // RVA: 0x7B148BB40
        public void get_AlgorithmName(){} // RVA: 0x7B148C260
        public void GetDigestSize(){} // RVA: 0x7A9F22B70
        public void Update(){} // RVA: 0x7B148C2A0
        public void BlockUpdate(){} // RVA: 0x7B148C380
        public void P(){} // RVA: 0x7B148C530
        public void A(){} // RVA: 0x7B148C650
        public void E(){} // RVA: 0x7B148C720
        public void fw(){} // RVA: 0x7B148C820
        public void processBlock(){} // RVA: 0x7B148CA50
        public void finish(){} // RVA: 0x7B148CFF0
        public void DoFinal(){} // RVA: 0x7B148D0F0
        public void Reset(){} // RVA: 0x7B148D600
        public void sumByteArray(){} // RVA: 0x7B148D3D0
        public void cpyBytesToShort(){} // RVA: 0x7B148D460
        public void cpyShortToBytes(){} // RVA: 0x7B148D500
        public void GetByteLength(){} // RVA: 0x7A9F22B70
        public void Copy(){} // RVA: 0x7B148D5A0
        public void .cctor(){} // RVA: 0x7B148D970
    }

    public class Gost3411_2012Digest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B148DA50
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void Copy(){} // RVA: 0x7A7E00680
        public void DoFinal(){} // RVA: 0x7B148DFA0
        public void GetByteLength(){} // RVA: 0x7A88EE450
        public void GetDigestSize(){} // RVA: 0x7A7E00710
        public void Reset(){} // RVA: 0x7B148E7D0
        public void Update(){} // RVA: 0x7B148E950
        public void BlockUpdate(){} // RVA: 0x7B148EBD0
        public void F(){} // RVA: 0x7B148EF60
        public void xor512(){} // RVA: 0x7B14903B0
        public void E(){} // RVA: 0x7B1490410
        public void g_N(){} // RVA: 0x7B14906F0
        public void addMod512(){} // RVA: 0x7B14908D0
        public void reverse(){} // RVA: 0x7B1490950
        public void .cctor(){} // RVA: 0x7B14909C0
    }

    public class Gost3411_2012_256Digest : Gost3411_2012Digest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B1491170
        public void .ctor(){} // RVA: 0x7B1491250
        public void GetDigestSize(){} // RVA: 0x7A9F22B70
        public void DoFinal(){} // RVA: 0x7B1491300
        public void Copy(){} // RVA: 0x7B14913B0
        public void .cctor(){} // RVA: 0x7B14914A0
    }

    public class Gost3411_2012_512Digest : Gost3411_2012Digest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B1491580
        public void .ctor(){} // RVA: 0x7B1491660
        public void GetDigestSize(){} // RVA: 0x7A88EE450
        public void Copy(){} // RVA: 0x7B1491710
        public void .cctor(){} // RVA: 0x7B1491800
    }

    public class KeccakDigest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1491A00
        public void CopyIn(){} // RVA: 0x7B1491B90
        public void get_AlgorithmName(){} // RVA: 0x7B1491C30
        public void GetDigestSize(){} // RVA: 0x7B1491C80
        public void Update(){} // RVA: 0x7B1491C90
        public void BlockUpdate(){} // RVA: 0x7B1491D20
        public void DoFinal(){} // RVA: 0x7B1491D80
        public void Reset(){} // RVA: 0x7B1493570
        public void GetByteLength(){} // RVA: 0x7B1491E20
        public void Init(){} // RVA: 0x7B1491E30
        public void InitSponge(){} // RVA: 0x7B1492010
        public void Absorb(){} // RVA: 0x7B1492140
        public void AbsorbBits(){} // RVA: 0x7B1492320
        public void PadAndSwitchToSqueezingPhase(){} // RVA: 0x7B1492490
        public void Squeeze(){} // RVA: 0x7B1492640
        public void KeccakAbsorb(){} // RVA: 0x7B14927A0
        public void KeccakExtract(){} // RVA: 0x7B1492860
        public void KeccakPermutation(){} // RVA: 0x7B14929B0
        public void Copy(){} // RVA: 0x7B1493510
        public void .cctor(){} // RVA: 0x7B1493670
    }

    public class LongDigest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1493880
        public void CopyIn(){} // RVA: 0x7B14939D0
        public void Update(){} // RVA: 0x7B1493AC0
        public void BlockUpdate(){} // RVA: 0x7B1493B30
        public void Finish(){} // RVA: 0x7B1493D20
        public void Reset(){} // RVA: 0x7A7E18800
        public void ProcessWord(){} // RVA: 0x7B1493F20
        public void AdjustByteCounts(){} // RVA: 0x7B1493FA0
        public void ProcessLength(){} // RVA: 0x7B1493FD0
        public void ProcessBlock(){} // RVA: 0x7B1494040
        public void Ch(){} // RVA: 0x7ADA88AB0
        public void Maj(){} // RVA: 0x7ADA88AC0
        public void Sum0(){} // RVA: 0x7B1494A30
        public void Sum1(){} // RVA: 0x7B1494A70
        public void Sigma0(){} // RVA: 0x7B1494AB0
        public void Sigma1(){} // RVA: 0x7B1494AE0
        public void GetByteLength(){} // RVA: 0x7A8124910
        public void get_AlgorithmName(){} // RVA: 0x7A7E00680
        public void GetDigestSize(){} // RVA: 0x7A7E00710
        public void DoFinal(){} // RVA: 0x7A7E09FB0
        public void Copy(){} // RVA: 0x7A7E00680
        public void .cctor(){} // RVA: 0x7B1494B10
    }

    public class MD2Digest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1494D60
        public void CopyIn(){} // RVA: 0x7B1494EE0
        public void get_AlgorithmName(){} // RVA: 0x7B1494FB0
        public void GetDigestSize(){} // RVA: 0x7A9F22B20
        public void GetByteLength(){} // RVA: 0x7A9F22B20
        public void DoFinal(){} // RVA: 0x7B1494FF0
        public void Reset(){} // RVA: 0x7B1495880
        public void Update(){} // RVA: 0x7B14951D0
        public void BlockUpdate(){} // RVA: 0x7B1495240
        public void ProcessChecksum(){} // RVA: 0x7B14953E0
        public void ProcessBlock(){} // RVA: 0x7B1495520
        public void Copy(){} // RVA: 0x7B14956D0
        public void .cctor(){} // RVA: 0x7B1495910
    }

    public class MD4Digest : GeneralDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1495AA0
        public void CopyIn(){} // RVA: 0x7B1495B60
        public void get_AlgorithmName(){} // RVA: 0x7B1495C10
        public void GetDigestSize(){} // RVA: 0x7A9F22B20
        public void ProcessWord(){} // RVA: 0x7B1495C50
        public void ProcessLength(){} // RVA: 0x7B1495D20
        public void UnpackWord(){} // RVA: 0x7B1495D90
        public void DoFinal(){} // RVA: 0x7B1495E00
        public void Reset(){} // RVA: 0x7B1496B40
        public void RotateLeft(){} // RVA: 0x7B144EAA0
        public void F(){} // RVA: 0x7AD9CB890
        public void G(){} // RVA: 0x7AD9CB8A0
        public void H(){} // RVA: 0x7AD9CB8B0
        public void ProcessBlock(){} // RVA: 0x7B1496060
        public void Copy(){} // RVA: 0x7B1496A50
    }

    public class MD5Digest : GeneralDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1496C80
        public void CopyIn(){} // RVA: 0x7B1495B60
        public void get_AlgorithmName(){} // RVA: 0x7B1496D40
        public void GetDigestSize(){} // RVA: 0x7A9F22B20
        public void ProcessWord(){} // RVA: 0x7B1496D80
        public void ProcessLength(){} // RVA: 0x7B1496E40
        public void DoFinal(){} // RVA: 0x7B1495E00
        public void Reset(){} // RVA: 0x7B14981F0
        public void RotateLeft(){} // RVA: 0x7ADC859A0
        public void F(){} // RVA: 0x7ADA7B090
        public void G(){} // RVA: 0x7ADA7B0B0
        public void H(){} // RVA: 0x7ADA7B080
        public void K(){} // RVA: 0x7B1496F10
        public void ProcessBlock(){} // RVA: 0x7B1496F20
        public void Copy(){} // RVA: 0x7B1498190
        public void .cctor(){} // RVA: 0x7B1498280
    }

    public class NonMemoableDigest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1498400
        public void get_AlgorithmName(){} // RVA: 0x7B14984B0
        public void GetDigestSize(){} // RVA: 0x7B1498500
        public void Update(){} // RVA: 0x7B1498550
        public void BlockUpdate(){} // RVA: 0x7B14985B0
        public void DoFinal(){} // RVA: 0x7B1498640
        public void Reset(){} // RVA: 0x7B14986B0
        public void GetByteLength(){} // RVA: 0x7B1498700
    }

    public class NullDigest : Object
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B1498750
        public void GetByteLength(){} // RVA: 0x7A82D1450
        public void GetDigestSize(){} // RVA: 0x7AE3C9490
        public void Update(){} // RVA: 0x7ADC47380
        public void BlockUpdate(){} // RVA: 0x7ADC47440
        public void DoFinal(){} // RVA: 0x7B1498790
        public void Reset(){} // RVA: 0x7B1498920
        public void .ctor(){} // RVA: 0x7B1498950
    }

    public class RipeMD128Digest : GeneralDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1498AA0
        public void CopyIn(){} // RVA: 0x7B1495B60
        public void get_AlgorithmName(){} // RVA: 0x7B1498B60
        public void GetDigestSize(){} // RVA: 0x7A9F22B20
        public void ProcessWord(){} // RVA: 0x7B1495C50
        public void ProcessLength(){} // RVA: 0x7B1495D20
        public void UnpackWord(){} // RVA: 0x7B1495D90
        public void DoFinal(){} // RVA: 0x7B1495E00
        public void Reset(){} // RVA: 0x7B149A690
        public void RL(){} // RVA: 0x7B144EAA0
        public void F1(){} // RVA: 0x7B1498BC0
        public void F2(){} // RVA: 0x7B1498BF0
        public void F3(){} // RVA: 0x7B1498C30
        public void F4(){} // RVA: 0x7B1498C70
        public void FF1(){} // RVA: 0x7B1498BC0
        public void FF2(){} // RVA: 0x7B1498CB0
        public void FF3(){} // RVA: 0x7B1498CF0
        public void FF4(){} // RVA: 0x7B1498D30
        public void ProcessBlock(){} // RVA: 0x7B1498D70
        public void Copy(){} // RVA: 0x7B149A5A0
    }

    public class RipeMD160Digest : GeneralDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B149A7D0
        public void CopyIn(){} // RVA: 0x7B149A890
        public void get_AlgorithmName(){} // RVA: 0x7B149A950
        public void GetDigestSize(){} // RVA: 0x7A83B4040
        public void ProcessWord(){} // RVA: 0x7B149A990
        public void ProcessLength(){} // RVA: 0x7B149AA60
        public void UnpackWord(){} // RVA: 0x7B1495D90
        public void DoFinal(){} // RVA: 0x7B149AAD0
        public void Reset(){} // RVA: 0x7B149F750
        public void RL(){} // RVA: 0x7B144EAA0
        public void F1(){} // RVA: 0x7AD9CB8B0
        public void F2(){} // RVA: 0x7AD9CB890
        public void F3(){} // RVA: 0x7B1498BA0
        public void F4(){} // RVA: 0x7B1498BB0
        public void F5(){} // RVA: 0x7B149AD90
        public void ProcessBlock(){} // RVA: 0x7B149ADA0
        public void Copy(){} // RVA: 0x7B149F660
    }

    public class RipeMD256Digest : GeneralDigest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B149F7E0
        public void GetDigestSize(){} // RVA: 0x7A9F22B70
        public void .ctor(){} // RVA: 0x7B149F8D0
        public void CopyIn(){} // RVA: 0x7B149F990
        public void ProcessWord(){} // RVA: 0x7B149FA60
        public void ProcessLength(){} // RVA: 0x7B149FB30
        public void UnpackWord(){} // RVA: 0x7B1495D90
        public void DoFinal(){} // RVA: 0x7B149FBA0
        public void Reset(){} // RVA: 0x7B14A1880
        public void RL(){} // RVA: 0x7B144EAA0
        public void F1(){} // RVA: 0x7B1498BC0
        public void F2(){} // RVA: 0x7B1498BF0
        public void F3(){} // RVA: 0x7B1498C30
        public void F4(){} // RVA: 0x7B1498C70
        public void FF1(){} // RVA: 0x7B1498BC0
        public void FF2(){} // RVA: 0x7B1498CB0
        public void FF3(){} // RVA: 0x7B1498CF0
        public void FF4(){} // RVA: 0x7B1498D30
        public void ProcessBlock(){} // RVA: 0x7B149FF80
        public void Copy(){} // RVA: 0x7B14A1790
    }

    public class RipeMD320Digest : GeneralDigest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7B14A1910
        public void GetDigestSize(){} // RVA: 0x7A9F22B50
        public void .ctor(){} // RVA: 0x7B14A1A00
        public void CopyIn(){} // RVA: 0x7B14A1AC0
        public void ProcessWord(){} // RVA: 0x7B14A1BA0
        public void ProcessLength(){} // RVA: 0x7B14A1C70
        public void UnpackWord(){} // RVA: 0x7B1495D90
        public void DoFinal(){} // RVA: 0x7B14A1CE0
        public void Reset(){} // RVA: 0x7B14A6B90
        public void RL(){} // RVA: 0x7B144EAA0
        public void F1(){} // RVA: 0x7AD9CB8B0
        public void F2(){} // RVA: 0x7AD9CB890
        public void F3(){} // RVA: 0x7B1498BA0
        public void F4(){} // RVA: 0x7B1498BB0
        public void F5(){} // RVA: 0x7B149AD90
        public void ProcessBlock(){} // RVA: 0x7B14A2170
        public void Copy(){} // RVA: 0x7B14A6AA0
    }

    public class SM3Digest : GeneralDigest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B14B0C60
        public void .ctor(){} // RVA: 0x7B14B0F70
        public void CopyIn(){} // RVA: 0x7B14B1150
        public void get_AlgorithmName(){} // RVA: 0x7B14B11E0
        public void GetDigestSize(){} // RVA: 0x7A9F22B70
        public void Copy(){} // RVA: 0x7B14B1220
        public void Reset(){} // RVA: 0x7B14B13A0
        public void DoFinal(){} // RVA: 0x7B14B14C0
        public void ProcessWord(){} // RVA: 0x7B14B15C0
        public void ProcessLength(){} // RVA: 0x7B14B1690
        public void P0(){} // RVA: 0x7B14B1770
        public void P1(){} // RVA: 0x7B14B17A0
        public void FF0(){} // RVA: 0x7AD9CB8B0
        public void FF1(){} // RVA: 0x7AD9CB8A0
        public void GG0(){} // RVA: 0x7AD9CB8B0
        public void GG1(){} // RVA: 0x7AD9CB890
        public void ProcessBlock(){} // RVA: 0x7B14B17D0
    }

    public class Sha1Digest : GeneralDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14A6CD0
        public void CopyIn(){} // RVA: 0x7B149A890
        public void get_AlgorithmName(){} // RVA: 0x7B14A6D90
        public void GetDigestSize(){} // RVA: 0x7A83B4040
        public void ProcessWord(){} // RVA: 0x7B14A6DD0
        public void ProcessLength(){} // RVA: 0x7B14A6EA0
        public void DoFinal(){} // RVA: 0x7B14A6F10
        public void Reset(){} // RVA: 0x7B14A7AE0
        public void F(){} // RVA: 0x7ADA7B090
        public void H(){} // RVA: 0x7ADA7B080
        public void G(){} // RVA: 0x7B14A71B0
        public void ProcessBlock(){} // RVA: 0x7B14A71C0
        public void Copy(){} // RVA: 0x7B14A7A80
    }

    public class Sha224Digest : GeneralDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14A7C20
        public void CopyIn(){} // RVA: 0x7B149F990
        public void get_AlgorithmName(){} // RVA: 0x7B14A7CE0
        public void GetDigestSize(){} // RVA: 0x7A8CCA610
        public void ProcessWord(){} // RVA: 0x7B14A7D20
        public void ProcessLength(){} // RVA: 0x7B14A7DF0
        public void DoFinal(){} // RVA: 0x7B14A7E60
        public void Reset(){} // RVA: 0x7B14A8B70
        public void ProcessBlock(){} // RVA: 0x7B14A81C0
        public void Ch(){} // RVA: 0x7ADA86DF0
        public void Maj(){} // RVA: 0x7ADA86E00
        public void Sum0(){} // RVA: 0x7B14A8A90
        public void Sum1(){} // RVA: 0x7B14A8AD0
        public void Theta0(){} // RVA: 0x7B1445F70
        public void Theta1(){} // RVA: 0x7B1445FA0
        public void Copy(){} // RVA: 0x7B14A8B10
        public void .cctor(){} // RVA: 0x7B14A8C00
    }

    public class Sha256Digest : GeneralDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14A8DB0
        public void CopyIn(){} // RVA: 0x7B149F990
        public void get_AlgorithmName(){} // RVA: 0x7B14A8E70
        public void GetDigestSize(){} // RVA: 0x7A9F22B70
        public void ProcessWord(){} // RVA: 0x7B14A7D20
        public void ProcessLength(){} // RVA: 0x7B14A7DF0
        public void DoFinal(){} // RVA: 0x7B14A8EB0
        public void Reset(){} // RVA: 0x7B14A9C60
        public void initHs(){} // RVA: 0x7B14A9270
        public void ProcessBlock(){} // RVA: 0x7B14A92B0
        public void Sum1Ch(){} // RVA: 0x7B14A9B60
        public void Sum0Maj(){} // RVA: 0x7B14A9BB0
        public void Theta0(){} // RVA: 0x7B1445F70
        public void Theta1(){} // RVA: 0x7B1445FA0
        public void Copy(){} // RVA: 0x7B14A9C00
        public void .cctor(){} // RVA: 0x7B14A9CF0
    }

    public class Sha384Digest : LongDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14A9E20
        public void get_AlgorithmName(){} // RVA: 0x7B14A9E80
        public void GetDigestSize(){} // RVA: 0x7A9F22B40
        public void DoFinal(){} // RVA: 0x7B14A9EC0
        public void Reset(){} // RVA: 0x7B14AA400
        public void Copy(){} // RVA: 0x7B14AA370
    }

    public class Sha3Digest : KeccakDigest
    {
        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0x7B14AA490
        public void .ctor(){} // RVA: 0x7B14AA660
        public void get_AlgorithmName(){} // RVA: 0x7B14AA6C0
        public void DoFinal(){} // RVA: 0x7B14AA790
        public void Copy(){} // RVA: 0x7B14AA930
    }

    public class Sha512Digest : LongDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14AAA10
        public void get_AlgorithmName(){} // RVA: 0x7B14AAA70
        public void GetDigestSize(){} // RVA: 0x7A88EE450
        public void DoFinal(){} // RVA: 0x7B14AAAB0
        public void Reset(){} // RVA: 0x7B14AB170
        public void Copy(){} // RVA: 0x7B14AB0E0
    }

    public class Sha512tDigest : LongDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14AB3E0
        public void get_AlgorithmName(){} // RVA: 0x7B14AB470
        public void GetDigestSize(){} // RVA: 0x7A897F560
        public void DoFinal(){} // RVA: 0x7B14AB540
        public void Reset(){} // RVA: 0x7B14AC000
        public void tIvGenerate(){} // RVA: 0x7B14AB860
        public void UInt64_To_BE(){} // RVA: 0x7B14ABE00
        public void UInt32_To_BE(){} // RVA: 0x7B14ABE70
        public void Copy(){} // RVA: 0x7B14ABF40
    }

    public class ShakeDigest : KeccakDigest
    {
        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0x7B14AC160
        public void .ctor(){} // RVA: 0x7B14AC360
        public void get_AlgorithmName(){} // RVA: 0x7B14AC3C0
        public void DoFinal(){} // RVA: 0x7B14AC5B0
        public void DoOutput(){} // RVA: 0x7B14AC4C0
        public void Copy(){} // RVA: 0x7B14AC740
    }

    public class ShortenedDigest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14AC7D0
        public void get_AlgorithmName(){} // RVA: 0x7B14AC920
        public void GetDigestSize(){} // RVA: 0x7A83782A0
        public void Update(){} // RVA: 0x7B14ACA50
        public void BlockUpdate(){} // RVA: 0x7B14ACAB0
        public void DoFinal(){} // RVA: 0x7B14ACB40
        public void Reset(){} // RVA: 0x7B14ACC20
        public void GetByteLength(){} // RVA: 0x7B14ACC70
    }

    public class SkeinDigest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14ACD90
        public void Reset(){} // RVA: 0x7B1403C30
        public void Copy(){} // RVA: 0x7B14AD050
        public void get_AlgorithmName(){} // RVA: 0x7B14AD190
        public void GetDigestSize(){} // RVA: 0x7A8D0A110
        public void GetByteLength(){} // RVA: 0x7B14AD350
        public void Init(){} // RVA: 0x7B14AD390
        public void Update(){} // RVA: 0x7B1403C90
        public void BlockUpdate(){} // RVA: 0x7B1403CB0
        public void DoFinal(){} // RVA: 0x7B1403CE0
    }

    public class SkeinEngine : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B14AD3B0
        public void InitialState(){} // RVA: 0x7B14AD770
        public void VariantIdentifier(){} // RVA: 0x7B14AD870
        public void .ctor(){} // RVA: 0x7B14ADB20
        public void CopyIn(){} // RVA: 0x7B14ADB90
        public void Clone(){} // RVA: 0x7B14ADF10
        public void Copy(){} // RVA: 0x7B14ADFB0
        public void Reset(){} // RVA: 0x7B14AF100
        public void get_OutputSize(){} // RVA: 0x7A83782A0
        public void get_BlockSize(){} // RVA: 0x7A858ABE0
        public void Init(){} // RVA: 0x7B14AE190
        public void InitParams(){} // RVA: 0x7B14AE390
        public void CreateInitialState(){} // RVA: 0x7B14AEA50
        public void UbiComplete(){} // RVA: 0x7B14AF150
        public void UbiInit(){} // RVA: 0x7B14AF1C0
        public void UbiFinal(){} // RVA: 0x7B14AF290
        public void CheckInitialised(){} // RVA: 0x7B14AF2C0
        public void Update(){} // RVA: 0x7B14AF3E0
        public void DoFinal(){} // RVA: 0x7B14AF460
        public void Output(){} // RVA: 0x7B14AF730
    }

    public class TigerDigest : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B14B1F40
        public void get_AlgorithmName(){} // RVA: 0x7B14B2150
        public void GetDigestSize(){} // RVA: 0x7A9F22B00
        public void GetByteLength(){} // RVA: 0x7A88EE450
        public void ProcessWord(){} // RVA: 0x7B14B2190
        public void Update(){} // RVA: 0x7B14B2300
        public void BlockUpdate(){} // RVA: 0x7B14B2370
        public void RoundABC(){} // RVA: 0x7B14B24F0
        public void RoundBCA(){} // RVA: 0x7B14B26E0
        public void RoundCAB(){} // RVA: 0x7B14B28D0
        public void KeySchedule(){} // RVA: 0x7B14B2AC0
        public void ProcessBlock(){} // RVA: 0x7B14B2D60
        public void UnpackWord(){} // RVA: 0x7B14B3230
        public void ProcessLength(){} // RVA: 0x7B14B3320
        public void Finish(){} // RVA: 0x7B14B3350
        public void DoFinal(){} // RVA: 0x7B14B3440
        public void Reset(){} // RVA: 0x7B14B3700
        public void Copy(){} // RVA: 0x7B14B36A0
        public void .cctor(){} // RVA: 0x7B14B3810
    }

    public class WhirlpoolDigest : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7B14B3AF0
        public void .ctor(){} // RVA: 0x7B14B4B00
        public void packIntoLong(){} // RVA: 0x7B14B4A80
        public void maskWithReductionPolynomial(){} // RVA: 0x7B14B4AE0
        public void get_AlgorithmName(){} // RVA: 0x7B14B4E80
        public void GetDigestSize(){} // RVA: 0x7A88EE450
        public void DoFinal(){} // RVA: 0x7B14B4EC0
        public void Reset(){} // RVA: 0x7B14B66B0
        public void processFilledBuffer(){} // RVA: 0x7B14B52C0
        public void bytesToLongFromBuffer(){} // RVA: 0x7B14B54A0
        public void convertLongToByteArray(){} // RVA: 0x7B14B55C0
        public void processBlock(){} // RVA: 0x7B14B5620
        public void Update(){} // RVA: 0x7B14B5FE0
        public void increment(){} // RVA: 0x7B14B6150
        public void BlockUpdate(){} // RVA: 0x7B14B6280
        public void finish(){} // RVA: 0x7B14B6460
        public void copyBitLength(){} // RVA: 0x7B14B65B0
        public void GetByteLength(){} // RVA: 0x7A88EE450
        public void Copy(){} // RVA: 0x7B14B6650
    }

}