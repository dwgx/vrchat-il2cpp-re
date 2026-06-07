// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
// Classes: 33
// Methods: 537

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
    public class Blake2bDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x964BC40 | overloaded x5
        public void Init(){} // RVA: 0x964BFC0
        public void InitializeInternalState(){} // RVA: 0x964C3A0
        public void Update(){} // RVA: 0x964C570
        public void BlockUpdate(){} // RVA: 0x964C620
        public void DoFinal(){} // RVA: 0x964C770
        public void Reset(){} // RVA: 0x964C950
        public void Compress(){} // RVA: 0x964CA30
        public void G(){} // RVA: 0x964D2E0
        public void Rotr64(){} // RVA: 0x5C9A7F0
        public void get_AlgorithmName(){} // RVA: 0x964D520
        public void GetDigestSize(){} // RVA: 0x32A5C0
        public void GetByteLength(){} // RVA: 0x21118B0
        public void ClearKey(){} // RVA: 0x964D560
        public void ClearSalt(){} // RVA: 0x964D5C0
        public void .cctor(){} // RVA: 0x964D5E0
    }

    public class Blake2sDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x964DF40 | overloaded x5
        public void Init(){} // RVA: 0x964E2C0
        public void InitializeInternalState(){} // RVA: 0x964E770
        public void Update(){} // RVA: 0x964E920
        public void BlockUpdate(){} // RVA: 0x964E9D0
        public void DoFinal(){} // RVA: 0x964EB20
        public void Reset(){} // RVA: 0x964ED20
        public void Compress(){} // RVA: 0x964EDF0
        public void G(){} // RVA: 0x964F550
        public void rotr32(){} // RVA: 0x964F740
        public void get_AlgorithmName(){} // RVA: 0x964F760
        public void GetDigestSize(){} // RVA: 0x32A5C0
        public void GetByteLength(){} // RVA: 0xC6A420
        public void ClearKey(){} // RVA: 0x964D560
        public void ClearSalt(){} // RVA: 0x964D5C0
        public void .cctor(){} // RVA: 0x964F7A0
    }

    public class Dstu7564Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x964FCB0 | overloaded x2
        public void CopyIn(){} // RVA: 0x964F970
        public void get_AlgorithmName(){} // RVA: 0x964FF50
        public void GetDigestSize(){} // RVA: 0x32A5C0
        public void GetByteLength(){} // RVA: 0x8ABED0
        public void Update(){} // RVA: 0x964FF90
        public void BlockUpdate(){} // RVA: 0x9650000
        public void DoFinal(){} // RVA: 0x9650110
        public void Reset(){} // RVA: 0x9651700 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x9650550
        public void P(){} // RVA: 0x9650790
        public void Q(){} // RVA: 0x9650830
        public void MixColumn(){} // RVA: 0x9650910
        public void MixColumns(){} // RVA: 0x9650A50
        public void Rotate(){} // RVA: 0x9609BA0
        public void ShiftRows(){} // RVA: 0x9650C40
        public void SubBytes(){} // RVA: 0x9651420
        public void Copy(){} // RVA: 0x96516A0
        public void .cctor(){} // RVA: 0x9651790
    }

    public class GeneralDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9651B00 | overloaded x2
        public void CopyIn(){} // RVA: 0x9651BF0
        public void Update(){} // RVA: 0x9651C50
        public void BlockUpdate(){} // RVA: 0x9651CD0
        public void Finish(){} // RVA: 0x9651E50
        public void Reset(){} // RVA: 0x24B10 | overloaded x2
        public void GetByteLength(){} // RVA: 0xC6A420
        public void ProcessWord(){} // RVA: 0x2BAA0
        public void ProcessLength(){} // RVA: 0x24CC0
        public void ProcessBlock(){} // RVA: 0x24A50
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void GetDigestSize(){} // RVA: 0xD840
        public void DoFinal(){}
        public void Copy(){} // RVA: 0xCD60
    }

    public class Gost3411Digest
    {
        // ── Methods ──
        public void MakeC(){} // RVA: 0x9651F70
        public void .ctor(){} // RVA: 0x9653040 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x9653760
        public void GetDigestSize(){} // RVA: 0x210E300
        public void Update(){} // RVA: 0x96537A0
        public void BlockUpdate(){} // RVA: 0x9653880
        public void P(){} // RVA: 0x9653A10
        public void A(){} // RVA: 0x9653B20
        public void E(){} // RVA: 0x9653BF0
        public void fw(){} // RVA: 0x9653CF0
        public void processBlock(){} // RVA: 0x9653F00
        public void finish(){} // RVA: 0x96543C0
        public void DoFinal(){} // RVA: 0x96544C0
        public void Reset(){} // RVA: 0x96549A0 | overloaded x2
        public void sumByteArray(){} // RVA: 0x96547A0
        public void cpyBytesToShort(){} // RVA: 0x9654820
        public void cpyShortToBytes(){} // RVA: 0x96548B0
        public void GetByteLength(){} // RVA: 0x210E300
        public void Copy(){} // RVA: 0x9654940
        public void .cctor(){} // RVA: 0x9654D20
    }

    public class Gost3411_2012Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9654E00
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void Copy(){} // RVA: 0xCD60
        public void DoFinal(){} // RVA: 0x9655350
        public void GetByteLength(){} // RVA: 0xC6A420
        public void GetDigestSize(){} // RVA: 0xD840
        public void Reset(){} // RVA: 0x9655B00 | overloaded x2
        public void Update(){} // RVA: 0x9655C80
        public void BlockUpdate(){} // RVA: 0x9655EC0
        public void F(){} // RVA: 0x9656210
        public void xor512(){} // RVA: 0x9657640
        public void E(){} // RVA: 0x9657690
        public void g_N(){} // RVA: 0x9657920
        public void addMod512(){} // RVA: 0x9657AE0 | overloaded x2
        public void reverse(){} // RVA: 0x9657B50
        public void .cctor(){} // RVA: 0x9657BC0
    }

    public class Gost3411_2012_256Digest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x9658370
        public void .ctor(){} // RVA: 0x9658450 | overloaded x2
        public void GetDigestSize(){} // RVA: 0x210E300
        public void DoFinal(){} // RVA: 0x9658500
        public void Copy(){} // RVA: 0x96585B0
        public void .cctor(){} // RVA: 0x96586A0
    }

    public class Gost3411_2012_512Digest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x9658780
        public void .ctor(){} // RVA: 0x9658860 | overloaded x2
        public void GetDigestSize(){} // RVA: 0xC6A420
        public void Copy(){} // RVA: 0x9658910
        public void .cctor(){} // RVA: 0x9658A00
    }

    public class KeccakDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9658C00 | overloaded x3
        public void CopyIn(){} // RVA: 0x9658D90
        public void get_AlgorithmName(){} // RVA: 0x9658E30
        public void GetDigestSize(){} // RVA: 0x9658E80
        public void Update(){} // RVA: 0x9658E90
        public void BlockUpdate(){} // RVA: 0x9658F20
        public void DoFinal(){} // RVA: 0x9658F80 | overloaded x2
        public void Reset(){} // RVA: 0x965A700 | overloaded x2
        public void GetByteLength(){} // RVA: 0x9659020
        public void Init(){} // RVA: 0x9659030
        public void InitSponge(){} // RVA: 0x9659210
        public void Absorb(){} // RVA: 0x9659350
        public void AbsorbBits(){} // RVA: 0x9659530
        public void PadAndSwitchToSqueezingPhase(){} // RVA: 0x96596A0
        public void Squeeze(){} // RVA: 0x9659890
        public void KeccakAbsorb(){} // RVA: 0x96599F0
        public void KeccakExtract(){} // RVA: 0x9659A90
        public void KeccakPermutation(){} // RVA: 0x9659BD0
        public void Copy(){} // RVA: 0x965A6A0
        public void .cctor(){} // RVA: 0x965A800
    }

    public class LongDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x965AA10 | overloaded x2
        public void CopyIn(){} // RVA: 0x965AB60
        public void Update(){} // RVA: 0x965AC50
        public void BlockUpdate(){} // RVA: 0x965ACC0
        public void Finish(){} // RVA: 0x965AEA0
        public void Reset(){} // RVA: 0x24B10 | overloaded x2
        public void ProcessWord(){} // RVA: 0x965B0A0
        public void AdjustByteCounts(){} // RVA: 0x965B120
        public void ProcessLength(){} // RVA: 0x965B150
        public void ProcessBlock(){} // RVA: 0x965B1C0
        public void Ch(){} // RVA: 0x5C9A810
        public void Maj(){} // RVA: 0x5C9A820
        public void Sum0(){} // RVA: 0x965BBC0
        public void Sum1(){} // RVA: 0x965BC00
        public void Sigma0(){} // RVA: 0x965BC40
        public void Sigma1(){} // RVA: 0x965BC70
        public void GetByteLength(){} // RVA: 0x32A5C0
        public void get_AlgorithmName(){} // RVA: 0xCD60
        public void GetDigestSize(){} // RVA: 0xD840
        public void DoFinal(){}
        public void Copy(){} // RVA: 0xCD60
        public void .cctor(){} // RVA: 0x965BCA0
    }

    public class MD2Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x965BEF0 | overloaded x2
        public void CopyIn(){} // RVA: 0x965C070
        public void get_AlgorithmName(){} // RVA: 0x965C140
        public void GetDigestSize(){} // RVA: 0x210E2B0
        public void GetByteLength(){} // RVA: 0x210E2B0
        public void DoFinal(){} // RVA: 0x965C180
        public void Reset(){} // RVA: 0x965C9E0 | overloaded x2
        public void Update(){} // RVA: 0x965C360
        public void BlockUpdate(){} // RVA: 0x965C3D0
        public void ProcessChecksum(){} // RVA: 0x965C560
        public void ProcessBlock(){} // RVA: 0x965C690
        public void Copy(){} // RVA: 0x965C830
        public void .cctor(){} // RVA: 0x965CA70
    }

    public class MD4Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x965CC00 | overloaded x2
        public void CopyIn(){} // RVA: 0x965CCC0
        public void get_AlgorithmName(){} // RVA: 0x965CD70
        public void GetDigestSize(){} // RVA: 0x210E2B0
        public void ProcessWord(){} // RVA: 0x965CDB0
        public void ProcessLength(){} // RVA: 0x965CE80
        public void UnpackWord(){} // RVA: 0x965CEF0
        public void DoFinal(){} // RVA: 0x965CF60
        public void Reset(){} // RVA: 0x965DC60 | overloaded x2
        public void RotateLeft(){} // RVA: 0x96169B0
        public void F(){} // RVA: 0x5BDDCD0
        public void G(){} // RVA: 0x5BDDCE0
        public void H(){} // RVA: 0x5BDDCF0
        public void ProcessBlock(){} // RVA: 0x965D1B0
        public void Copy(){} // RVA: 0x965DB70
    }

    public class MD5Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x965DDA0 | overloaded x2
        public void CopyIn(){} // RVA: 0x965CCC0
        public void get_AlgorithmName(){} // RVA: 0x965DE60
        public void GetDigestSize(){} // RVA: 0x210E2B0
        public void ProcessWord(){} // RVA: 0x965DEA0
        public void ProcessLength(){} // RVA: 0x965DF60
        public void DoFinal(){} // RVA: 0x965CF60
        public void Reset(){} // RVA: 0x965F2F0 | overloaded x2
        public void RotateLeft(){} // RVA: 0x5E96E30
        public void F(){} // RVA: 0x5C8CF00
        public void G(){} // RVA: 0x5C8CF20
        public void H(){} // RVA: 0x5C8CEF0
        public void K(){} // RVA: 0x965E010
        public void ProcessBlock(){} // RVA: 0x965E020
        public void Copy(){} // RVA: 0x965F290
        public void .cctor(){} // RVA: 0x965F380
    }

    public class NonMemoableDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x965F500
        public void get_AlgorithmName(){} // RVA: 0x965F5B0
        public void GetDigestSize(){} // RVA: 0x965F600
        public void Update(){} // RVA: 0x965F650
        public void BlockUpdate(){} // RVA: 0x965F6B0
        public void DoFinal(){} // RVA: 0x965F740
        public void Reset(){} // RVA: 0x965F7B0
        public void GetByteLength(){} // RVA: 0x965F800
    }

    public class NullDigest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x965F850
        public void GetByteLength(){} // RVA: 0x519240
        public void GetDigestSize(){} // RVA: 0x65DABF0
        public void Update(){} // RVA: 0x5E58960
        public void BlockUpdate(){} // RVA: 0x5E58A20
        public void DoFinal(){} // RVA: 0x965F890
        public void Reset(){} // RVA: 0x965FA20
        public void .ctor(){} // RVA: 0x965FA50
    }

    public class RipeMD128Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x965FBA0 | overloaded x2
        public void CopyIn(){} // RVA: 0x965CCC0
        public void get_AlgorithmName(){} // RVA: 0x965FC60
        public void GetDigestSize(){} // RVA: 0x210E2B0
        public void ProcessWord(){} // RVA: 0x965CDB0
        public void ProcessLength(){} // RVA: 0x965CE80
        public void UnpackWord(){} // RVA: 0x965CEF0
        public void DoFinal(){} // RVA: 0x965CF60
        public void Reset(){} // RVA: 0x9661710 | overloaded x2
        public void RL(){} // RVA: 0x96169B0
        public void F1(){} // RVA: 0x965FCC0 | overloaded x2
        public void F2(){} // RVA: 0x965FCF0 | overloaded x2
        public void F3(){} // RVA: 0x965FD30 | overloaded x2
        public void F4(){} // RVA: 0x965FD70 | overloaded x2
        public void FF1(){} // RVA: 0x965FCC0
        public void FF2(){} // RVA: 0x965FDB0
        public void FF3(){} // RVA: 0x965FDF0
        public void FF4(){} // RVA: 0x965FE30
        public void ProcessBlock(){} // RVA: 0x965FE70
        public void Copy(){} // RVA: 0x9661620
    }

    public class RipeMD160Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9661850 | overloaded x2
        public void CopyIn(){} // RVA: 0x9661910
        public void get_AlgorithmName(){} // RVA: 0x96619D0
        public void GetDigestSize(){} // RVA: 0x5FAB20
        public void ProcessWord(){} // RVA: 0x9661A10
        public void ProcessLength(){} // RVA: 0x9661AE0
        public void UnpackWord(){} // RVA: 0x965CEF0
        public void DoFinal(){} // RVA: 0x9661B50
        public void Reset(){} // RVA: 0x9666790 | overloaded x2
        public void RL(){} // RVA: 0x96169B0
        public void F1(){} // RVA: 0x5BDDCF0
        public void F2(){} // RVA: 0x5BDDCD0
        public void F3(){} // RVA: 0x965FCA0
        public void F4(){} // RVA: 0x965FCB0
        public void F5(){} // RVA: 0x9661E00
        public void ProcessBlock(){} // RVA: 0x9661E10
        public void Copy(){} // RVA: 0x96666A0
    }

    public class RipeMD256Digest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x9666820
        public void GetDigestSize(){} // RVA: 0x210E300
        public void .ctor(){} // RVA: 0x9666910 | overloaded x2
        public void CopyIn(){} // RVA: 0x96669D0
        public void ProcessWord(){} // RVA: 0x9666AA0
        public void ProcessLength(){} // RVA: 0x9666B70
        public void UnpackWord(){} // RVA: 0x965CEF0
        public void DoFinal(){} // RVA: 0x9666BE0
        public void Reset(){} // RVA: 0x9668820 | overloaded x2
        public void RL(){} // RVA: 0x96169B0
        public void F1(){} // RVA: 0x965FCC0 | overloaded x2
        public void F2(){} // RVA: 0x965FCF0 | overloaded x2
        public void F3(){} // RVA: 0x965FD30 | overloaded x2
        public void F4(){} // RVA: 0x965FD70 | overloaded x2
        public void FF1(){} // RVA: 0x965FCC0
        public void FF2(){} // RVA: 0x965FDB0
        public void FF3(){} // RVA: 0x965FDF0
        public void FF4(){} // RVA: 0x965FE30
        public void ProcessBlock(){} // RVA: 0x9666FB0
        public void Copy(){} // RVA: 0x9668730
    }

    public class RipeMD320Digest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x96688B0
        public void GetDigestSize(){} // RVA: 0x210E2E0
        public void .ctor(){} // RVA: 0x96689A0 | overloaded x2
        public void CopyIn(){} // RVA: 0x9668A60
        public void ProcessWord(){} // RVA: 0x9668B40
        public void ProcessLength(){} // RVA: 0x9668C10
        public void UnpackWord(){} // RVA: 0x965CEF0
        public void DoFinal(){} // RVA: 0x9668C80
        public void Reset(){} // RVA: 0x966DB10 | overloaded x2
        public void RL(){} // RVA: 0x96169B0
        public void F1(){} // RVA: 0x5BDDCF0
        public void F2(){} // RVA: 0x5BDDCD0
        public void F3(){} // RVA: 0x965FCA0
        public void F4(){} // RVA: 0x965FCB0
        public void F5(){} // RVA: 0x9661E00
        public void ProcessBlock(){} // RVA: 0x9669100
        public void Copy(){} // RVA: 0x966DA20
    }

    public class SM3Digest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x9677A20
        public void .ctor(){} // RVA: 0x9677D30 | overloaded x2
        public void CopyIn(){} // RVA: 0x9677F10
        public void get_AlgorithmName(){} // RVA: 0x9677FA0
        public void GetDigestSize(){} // RVA: 0x210E300
        public void Copy(){} // RVA: 0x9677FE0
        public void Reset(){} // RVA: 0x9678160 | overloaded x2
        public void DoFinal(){} // RVA: 0x9678280
        public void ProcessWord(){} // RVA: 0x9678360
        public void ProcessLength(){} // RVA: 0x9678430
        public void P0(){} // RVA: 0x9678510
        public void P1(){} // RVA: 0x9678540
        public void FF0(){} // RVA: 0x5BDDCF0
        public void FF1(){} // RVA: 0x5BDDCE0
        public void GG0(){} // RVA: 0x5BDDCF0
        public void GG1(){} // RVA: 0x5BDDCD0
        public void ProcessBlock(){} // RVA: 0x9678570
    }

    public class Sha1Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x966DC50 | overloaded x2
        public void CopyIn(){} // RVA: 0x9661910
        public void get_AlgorithmName(){} // RVA: 0x966DD10
        public void GetDigestSize(){} // RVA: 0x5FAB20
        public void ProcessWord(){} // RVA: 0x966DD50
        public void ProcessLength(){} // RVA: 0x966DE20
        public void DoFinal(){} // RVA: 0x966DE90
        public void Reset(){} // RVA: 0x966E980 | overloaded x2
        public void F(){} // RVA: 0x5C8CF00
        public void H(){} // RVA: 0x5C8CEF0
        public void G(){} // RVA: 0x966E130
        public void ProcessBlock(){} // RVA: 0x966E140
        public void Copy(){} // RVA: 0x966E920
    }

    public class Sha224Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x966EAC0 | overloaded x2
        public void CopyIn(){} // RVA: 0x96669D0
        public void get_AlgorithmName(){} // RVA: 0x966EB80
        public void GetDigestSize(){} // RVA: 0xF00450
        public void ProcessWord(){} // RVA: 0x966EBC0
        public void ProcessLength(){} // RVA: 0x966EC90
        public void DoFinal(){} // RVA: 0x966ED00
        public void Reset(){} // RVA: 0x966FA30 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x966F060
        public void Ch(){} // RVA: 0x5C98C90
        public void Maj(){} // RVA: 0x5C98CA0
        public void Sum0(){} // RVA: 0x966F950
        public void Sum1(){} // RVA: 0x966F990
        public void Theta0(){} // RVA: 0x960E040
        public void Theta1(){} // RVA: 0x960E070
        public void Copy(){} // RVA: 0x966F9D0
        public void .cctor(){} // RVA: 0x966FAC0
    }

    public class Sha256Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x966FC70 | overloaded x2
        public void CopyIn(){} // RVA: 0x96669D0
        public void get_AlgorithmName(){} // RVA: 0x966FD30
        public void GetDigestSize(){} // RVA: 0x210E300
        public void ProcessWord(){} // RVA: 0x966EBC0
        public void ProcessLength(){} // RVA: 0x966EC90
        public void DoFinal(){} // RVA: 0x966FD70
        public void Reset(){} // RVA: 0x9670B40 | overloaded x2
        public void initHs(){} // RVA: 0x9670130
        public void ProcessBlock(){} // RVA: 0x9670170
        public void Sum1Ch(){} // RVA: 0x9670A40
        public void Sum0Maj(){} // RVA: 0x9670A90
        public void Theta0(){} // RVA: 0x960E040
        public void Theta1(){} // RVA: 0x960E070
        public void Copy(){} // RVA: 0x9670AE0
        public void .cctor(){} // RVA: 0x9670BD0
    }

    public class Sha384Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9670D00 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9670D60
        public void GetDigestSize(){} // RVA: 0x210E2D0
        public void DoFinal(){} // RVA: 0x9670DA0
        public void Reset(){} // RVA: 0x96712E0 | overloaded x2
        public void Copy(){} // RVA: 0x9671250
    }

    public class Sha3Digest
    {
        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0x9671370
        public void .ctor(){} // RVA: 0x9671540 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x96715A0
        public void DoFinal(){} // RVA: 0x9671670 | overloaded x2
        public void Copy(){} // RVA: 0x9671810
    }

    public class Sha512Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96718F0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9671950
        public void GetDigestSize(){} // RVA: 0xC6A420
        public void DoFinal(){} // RVA: 0x9671990
        public void Reset(){} // RVA: 0x9672050 | overloaded x2
        public void Copy(){} // RVA: 0x9671FC0
    }

    public class Sha512tDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96722C0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9672350
        public void GetDigestSize(){} // RVA: 0xBB90C0
        public void DoFinal(){} // RVA: 0x9672420
        public void Reset(){} // RVA: 0x9672E20 | overloaded x2
        public void tIvGenerate(){} // RVA: 0x96725F0
        public void UInt64_To_BE(){} // RVA: 0x9672B90
        public void UInt32_To_BE(){} // RVA: 0x9672C90
        public void Copy(){} // RVA: 0x9672D60
    }

    public class ShakeDigest
    {
        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0x9672F80
        public void .ctor(){} // RVA: 0x9673180 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x96731E0
        public void DoFinal(){} // RVA: 0x96733D0 | overloaded x4
        public void DoOutput(){} // RVA: 0x96732E0
        public void Copy(){} // RVA: 0x9673560
    }

    public class ShortenedDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x96735F0
        public void get_AlgorithmName(){} // RVA: 0x9673740
        public void GetDigestSize(){} // RVA: 0x5BED50
        public void Update(){} // RVA: 0x9673870
        public void BlockUpdate(){} // RVA: 0x96738D0
        public void DoFinal(){} // RVA: 0x9673960
        public void Reset(){} // RVA: 0x9673A40
        public void GetByteLength(){} // RVA: 0x9673A90
    }

    public class SkeinDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9673BB0 | overloaded x2
        public void Reset(){} // RVA: 0x95CC890 | overloaded x2
        public void Copy(){} // RVA: 0x9673E70
        public void get_AlgorithmName(){} // RVA: 0x9673FB0
        public void GetDigestSize(){} // RVA: 0xF3F910
        public void GetByteLength(){} // RVA: 0x9674170
        public void Init(){} // RVA: 0x96741B0
        public void Update(){} // RVA: 0x95CC8F0
        public void BlockUpdate(){} // RVA: 0x95CC910
        public void DoFinal(){} // RVA: 0x95CC940
    }

    public class SkeinEngine
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x96741D0
        public void InitialState(){} // RVA: 0x9674590
        public void VariantIdentifier(){} // RVA: 0x9674690
        public void .ctor(){} // RVA: 0x9674930 | overloaded x2
        public void CopyIn(){} // RVA: 0x96749A0
        public void Clone(){} // RVA: 0x9674D20
        public void Copy(){} // RVA: 0x9674DC0
        public void Reset(){} // RVA: 0x9675EF0 | overloaded x2
        public void get_OutputSize(){} // RVA: 0x5BED50
        public void get_BlockSize(){} // RVA: 0x7F0310
        public void Init(){} // RVA: 0x9674FA0
        public void InitParams(){} // RVA: 0x96751A0
        public void CreateInitialState(){} // RVA: 0x9675850
        public void UbiComplete(){} // RVA: 0x9675F40
        public void UbiInit(){} // RVA: 0x9675FB0
        public void UbiFinal(){} // RVA: 0x9676080
        public void CheckInitialised(){} // RVA: 0x96760B0
        public void Update(){} // RVA: 0x96761D0 | overloaded x2
        public void DoFinal(){} // RVA: 0x9676250
        public void Output(){} // RVA: 0x9676520
    }

    public class TigerDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9678C80 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x9678E90
        public void GetDigestSize(){} // RVA: 0x210E290
        public void GetByteLength(){} // RVA: 0xC6A420
        public void ProcessWord(){} // RVA: 0x9678ED0
        public void Update(){} // RVA: 0x9679040
        public void BlockUpdate(){} // RVA: 0x96790B0
        public void RoundABC(){} // RVA: 0x9679220
        public void RoundBCA(){} // RVA: 0x9679410
        public void RoundCAB(){} // RVA: 0x9679600
        public void KeySchedule(){} // RVA: 0x96797F0
        public void ProcessBlock(){} // RVA: 0x9679B10
        public void UnpackWord(){} // RVA: 0x9679FD0
        public void ProcessLength(){} // RVA: 0x967A0C0
        public void Finish(){} // RVA: 0x967A0F0
        public void DoFinal(){} // RVA: 0x967A1E0
        public void Reset(){} // RVA: 0x967A490 | overloaded x2
        public void Copy(){} // RVA: 0x967A430
        public void .cctor(){} // RVA: 0x967A5A0
    }

    public class WhirlpoolDigest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x967A880
        public void .ctor(){} // RVA: 0x967B8A0 | overloaded x2
        public void packIntoLong(){} // RVA: 0x967B820
        public void maskWithReductionPolynomial(){} // RVA: 0x967B880
        public void get_AlgorithmName(){} // RVA: 0x967BC20
        public void GetDigestSize(){} // RVA: 0xC6A420
        public void DoFinal(){} // RVA: 0x967BC60
        public void Reset(){} // RVA: 0x967D3F0 | overloaded x2
        public void processFilledBuffer(){} // RVA: 0x967C050
        public void bytesToLongFromBuffer(){} // RVA: 0x967C250
        public void convertLongToByteArray(){} // RVA: 0x967C370
        public void processBlock(){} // RVA: 0x967C3D0
        public void Update(){} // RVA: 0x967CD80
        public void increment(){} // RVA: 0x967CEE0
        public void BlockUpdate(){} // RVA: 0x967D000
        public void finish(){} // RVA: 0x967D1B0
        public void copyBitLength(){} // RVA: 0x967D300
        public void GetByteLength(){} // RVA: 0xC6A420
        public void Copy(){} // RVA: 0x967D390
    }

}