// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
// Classes: 33
// Methods: 537

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Digests
{
    public class Blake2bDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0FBC40 | overloaded x5
        public void Init(){} // RVA: 0x7FFAFC0FBFC0
        public void InitializeInternalState(){} // RVA: 0x7FFAFC0FC3A0
        public void Update(){} // RVA: 0x7FFAFC0FC570
        public void BlockUpdate(){} // RVA: 0x7FFAFC0FC620
        public void DoFinal(){} // RVA: 0x7FFAFC0FC770
        public void Reset(){} // RVA: 0x7FFAFC0FC950
        public void Compress(){} // RVA: 0x7FFAFC0FCA30
        public void G(){} // RVA: 0x7FFAFC0FD2E0
        public void Rotr64(){} // RVA: 0x7FFAF874A7F0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC0FD520
        public void GetDigestSize(){} // RVA: 0x7FFAF2DDA5C0
        public void GetByteLength(){} // RVA: 0x7FFAF4BC18B0
        public void ClearKey(){} // RVA: 0x7FFAFC0FD560
        public void ClearSalt(){} // RVA: 0x7FFAFC0FD5C0
        public void .cctor(){} // RVA: 0x7FFAFC0FD5E0
    }

    public class Blake2sDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0FDF40 | overloaded x5
        public void Init(){} // RVA: 0x7FFAFC0FE2C0
        public void InitializeInternalState(){} // RVA: 0x7FFAFC0FE770
        public void Update(){} // RVA: 0x7FFAFC0FE920
        public void BlockUpdate(){} // RVA: 0x7FFAFC0FE9D0
        public void DoFinal(){} // RVA: 0x7FFAFC0FEB20
        public void Reset(){} // RVA: 0x7FFAFC0FED20
        public void Compress(){} // RVA: 0x7FFAFC0FEDF0
        public void G(){} // RVA: 0x7FFAFC0FF550
        public void rotr32(){} // RVA: 0x7FFAFC0FF740
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC0FF760
        public void GetDigestSize(){} // RVA: 0x7FFAF2DDA5C0
        public void GetByteLength(){} // RVA: 0x7FFAF371A420
        public void ClearKey(){} // RVA: 0x7FFAFC0FD560
        public void ClearSalt(){} // RVA: 0x7FFAFC0FD5C0
        public void .cctor(){} // RVA: 0x7FFAFC0FF7A0
    }

    public class Dstu7564Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC0FFCB0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC0FF970
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC0FFF50
        public void GetDigestSize(){} // RVA: 0x7FFAF2DDA5C0
        public void GetByteLength(){} // RVA: 0x7FFAF335BED0
        public void Update(){} // RVA: 0x7FFAFC0FFF90
        public void BlockUpdate(){} // RVA: 0x7FFAFC100000
        public void DoFinal(){} // RVA: 0x7FFAFC100110
        public void Reset(){} // RVA: 0x7FFAFC101700 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x7FFAFC100550
        public void P(){} // RVA: 0x7FFAFC100790
        public void Q(){} // RVA: 0x7FFAFC100830
        public void MixColumn(){} // RVA: 0x7FFAFC100910
        public void MixColumns(){} // RVA: 0x7FFAFC100A50
        public void Rotate(){} // RVA: 0x7FFAFC0B9BA0
        public void ShiftRows(){} // RVA: 0x7FFAFC100C40
        public void SubBytes(){} // RVA: 0x7FFAFC101420
        public void Copy(){} // RVA: 0x7FFAFC1016A0
        public void .cctor(){} // RVA: 0x7FFAFC101790
    }

    public class GeneralDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC101B00 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC101BF0
        public void Update(){} // RVA: 0x7FFAFC101C50
        public void BlockUpdate(){} // RVA: 0x7FFAFC101CD0
        public void Finish(){} // RVA: 0x7FFAFC101E50
        public void Reset(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void GetByteLength(){} // RVA: 0x7FFAF371A420
        public void ProcessWord(){} // RVA: 0x7FFAF2ADBAA0
        public void ProcessLength(){} // RVA: 0x7FFAF2AD4CC0
        public void ProcessBlock(){} // RVA: 0x7FFAF2AD4A50
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void GetDigestSize(){} // RVA: 0x7FFAF2ABD840
        public void DoFinal(){}
        public void Copy(){} // RVA: 0x7FFAF2ABCD60
    }

    public class Gost3411Digest
    {
        // ── Methods ──
        public void MakeC(){} // RVA: 0x7FFAFC101F70
        public void .ctor(){} // RVA: 0x7FFAFC103040 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC103760
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE300
        public void Update(){} // RVA: 0x7FFAFC1037A0
        public void BlockUpdate(){} // RVA: 0x7FFAFC103880
        public void P(){} // RVA: 0x7FFAFC103A10
        public void A(){} // RVA: 0x7FFAFC103B20
        public void E(){} // RVA: 0x7FFAFC103BF0
        public void fw(){} // RVA: 0x7FFAFC103CF0
        public void processBlock(){} // RVA: 0x7FFAFC103F00
        public void finish(){} // RVA: 0x7FFAFC1043C0
        public void DoFinal(){} // RVA: 0x7FFAFC1044C0
        public void Reset(){} // RVA: 0x7FFAFC1049A0 | overloaded x2
        public void sumByteArray(){} // RVA: 0x7FFAFC1047A0
        public void cpyBytesToShort(){} // RVA: 0x7FFAFC104820
        public void cpyShortToBytes(){} // RVA: 0x7FFAFC1048B0
        public void GetByteLength(){} // RVA: 0x7FFAF4BBE300
        public void Copy(){} // RVA: 0x7FFAFC104940
        public void .cctor(){} // RVA: 0x7FFAFC104D20
    }

    public class Gost3411_2012Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC104E00
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void Copy(){} // RVA: 0x7FFAF2ABCD60
        public void DoFinal(){} // RVA: 0x7FFAFC105350
        public void GetByteLength(){} // RVA: 0x7FFAF371A420
        public void GetDigestSize(){} // RVA: 0x7FFAF2ABD840
        public void Reset(){} // RVA: 0x7FFAFC105B00 | overloaded x2
        public void Update(){} // RVA: 0x7FFAFC105C80
        public void BlockUpdate(){} // RVA: 0x7FFAFC105EC0
        public void F(){} // RVA: 0x7FFAFC106210
        public void xor512(){} // RVA: 0x7FFAFC107640
        public void E(){} // RVA: 0x7FFAFC107690
        public void g_N(){} // RVA: 0x7FFAFC107920
        public void addMod512(){} // RVA: 0x7FFAFC107AE0 | overloaded x2
        public void reverse(){} // RVA: 0x7FFAFC107B50
        public void .cctor(){} // RVA: 0x7FFAFC107BC0
    }

    public class Gost3411_2012_256Digest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC108370
        public void .ctor(){} // RVA: 0x7FFAFC108450 | overloaded x2
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE300
        public void DoFinal(){} // RVA: 0x7FFAFC108500
        public void Copy(){} // RVA: 0x7FFAFC1085B0
        public void .cctor(){} // RVA: 0x7FFAFC1086A0
    }

    public class Gost3411_2012_512Digest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC108780
        public void .ctor(){} // RVA: 0x7FFAFC108860 | overloaded x2
        public void GetDigestSize(){} // RVA: 0x7FFAF371A420
        public void Copy(){} // RVA: 0x7FFAFC108910
        public void .cctor(){} // RVA: 0x7FFAFC108A00
    }

    public class KeccakDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC108C00 | overloaded x3
        public void CopyIn(){} // RVA: 0x7FFAFC108D90
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC108E30
        public void GetDigestSize(){} // RVA: 0x7FFAFC108E80
        public void Update(){} // RVA: 0x7FFAFC108E90
        public void BlockUpdate(){} // RVA: 0x7FFAFC108F20
        public void DoFinal(){} // RVA: 0x7FFAFC108F80 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAFC10A700 | overloaded x2
        public void GetByteLength(){} // RVA: 0x7FFAFC109020
        public void Init(){} // RVA: 0x7FFAFC109030
        public void InitSponge(){} // RVA: 0x7FFAFC109210
        public void Absorb(){} // RVA: 0x7FFAFC109350
        public void AbsorbBits(){} // RVA: 0x7FFAFC109530
        public void PadAndSwitchToSqueezingPhase(){} // RVA: 0x7FFAFC1096A0
        public void Squeeze(){} // RVA: 0x7FFAFC109890
        public void KeccakAbsorb(){} // RVA: 0x7FFAFC1099F0
        public void KeccakExtract(){} // RVA: 0x7FFAFC109A90
        public void KeccakPermutation(){} // RVA: 0x7FFAFC109BD0
        public void Copy(){} // RVA: 0x7FFAFC10A6A0
        public void .cctor(){} // RVA: 0x7FFAFC10A800
    }

    public class LongDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC10AA10 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC10AB60
        public void Update(){} // RVA: 0x7FFAFC10AC50
        public void BlockUpdate(){} // RVA: 0x7FFAFC10ACC0
        public void Finish(){} // RVA: 0x7FFAFC10AEA0
        public void Reset(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void ProcessWord(){} // RVA: 0x7FFAFC10B0A0
        public void AdjustByteCounts(){} // RVA: 0x7FFAFC10B120
        public void ProcessLength(){} // RVA: 0x7FFAFC10B150
        public void ProcessBlock(){} // RVA: 0x7FFAFC10B1C0
        public void Ch(){} // RVA: 0x7FFAF874A810
        public void Maj(){} // RVA: 0x7FFAF874A820
        public void Sum0(){} // RVA: 0x7FFAFC10BBC0
        public void Sum1(){} // RVA: 0x7FFAFC10BC00
        public void Sigma0(){} // RVA: 0x7FFAFC10BC40
        public void Sigma1(){} // RVA: 0x7FFAFC10BC70
        public void GetByteLength(){} // RVA: 0x7FFAF2DDA5C0
        public void get_AlgorithmName(){} // RVA: 0x7FFAF2ABCD60
        public void GetDigestSize(){} // RVA: 0x7FFAF2ABD840
        public void DoFinal(){}
        public void Copy(){} // RVA: 0x7FFAF2ABCD60
        public void .cctor(){} // RVA: 0x7FFAFC10BCA0
    }

    public class MD2Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC10BEF0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC10C070
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC10C140
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE2B0
        public void GetByteLength(){} // RVA: 0x7FFAF4BBE2B0
        public void DoFinal(){} // RVA: 0x7FFAFC10C180
        public void Reset(){} // RVA: 0x7FFAFC10C9E0 | overloaded x2
        public void Update(){} // RVA: 0x7FFAFC10C360
        public void BlockUpdate(){} // RVA: 0x7FFAFC10C3D0
        public void ProcessChecksum(){} // RVA: 0x7FFAFC10C560
        public void ProcessBlock(){} // RVA: 0x7FFAFC10C690
        public void Copy(){} // RVA: 0x7FFAFC10C830
        public void .cctor(){} // RVA: 0x7FFAFC10CA70
    }

    public class MD4Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC10CC00 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC10CCC0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC10CD70
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE2B0
        public void ProcessWord(){} // RVA: 0x7FFAFC10CDB0
        public void ProcessLength(){} // RVA: 0x7FFAFC10CE80
        public void UnpackWord(){} // RVA: 0x7FFAFC10CEF0
        public void DoFinal(){} // RVA: 0x7FFAFC10CF60
        public void Reset(){} // RVA: 0x7FFAFC10DC60 | overloaded x2
        public void RotateLeft(){} // RVA: 0x7FFAFC0C69B0
        public void F(){} // RVA: 0x7FFAF868DCD0
        public void G(){} // RVA: 0x7FFAF868DCE0
        public void H(){} // RVA: 0x7FFAF868DCF0
        public void ProcessBlock(){} // RVA: 0x7FFAFC10D1B0
        public void Copy(){} // RVA: 0x7FFAFC10DB70
    }

    public class MD5Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC10DDA0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC10CCC0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC10DE60
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE2B0
        public void ProcessWord(){} // RVA: 0x7FFAFC10DEA0
        public void ProcessLength(){} // RVA: 0x7FFAFC10DF60
        public void DoFinal(){} // RVA: 0x7FFAFC10CF60
        public void Reset(){} // RVA: 0x7FFAFC10F2F0 | overloaded x2
        public void RotateLeft(){} // RVA: 0x7FFAF8946E30
        public void F(){} // RVA: 0x7FFAF873CF00
        public void G(){} // RVA: 0x7FFAF873CF20
        public void H(){} // RVA: 0x7FFAF873CEF0
        public void K(){} // RVA: 0x7FFAFC10E010
        public void ProcessBlock(){} // RVA: 0x7FFAFC10E020
        public void Copy(){} // RVA: 0x7FFAFC10F290
        public void .cctor(){} // RVA: 0x7FFAFC10F380
    }

    public class NonMemoableDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC10F500
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC10F5B0
        public void GetDigestSize(){} // RVA: 0x7FFAFC10F600
        public void Update(){} // RVA: 0x7FFAFC10F650
        public void BlockUpdate(){} // RVA: 0x7FFAFC10F6B0
        public void DoFinal(){} // RVA: 0x7FFAFC10F740
        public void Reset(){} // RVA: 0x7FFAFC10F7B0
        public void GetByteLength(){} // RVA: 0x7FFAFC10F800
    }

    public class NullDigest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC10F850
        public void GetByteLength(){} // RVA: 0x7FFAF2FC9240
        public void GetDigestSize(){} // RVA: 0x7FFAF908ABF0
        public void Update(){} // RVA: 0x7FFAF8908960
        public void BlockUpdate(){} // RVA: 0x7FFAF8908A20
        public void DoFinal(){} // RVA: 0x7FFAFC10F890
        public void Reset(){} // RVA: 0x7FFAFC10FA20
        public void .ctor(){} // RVA: 0x7FFAFC10FA50
    }

    public class RipeMD128Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC10FBA0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC10CCC0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC10FC60
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE2B0
        public void ProcessWord(){} // RVA: 0x7FFAFC10CDB0
        public void ProcessLength(){} // RVA: 0x7FFAFC10CE80
        public void UnpackWord(){} // RVA: 0x7FFAFC10CEF0
        public void DoFinal(){} // RVA: 0x7FFAFC10CF60
        public void Reset(){} // RVA: 0x7FFAFC111710 | overloaded x2
        public void RL(){} // RVA: 0x7FFAFC0C69B0
        public void F1(){} // RVA: 0x7FFAFC10FCC0 | overloaded x2
        public void F2(){} // RVA: 0x7FFAFC10FCF0 | overloaded x2
        public void F3(){} // RVA: 0x7FFAFC10FD30 | overloaded x2
        public void F4(){} // RVA: 0x7FFAFC10FD70 | overloaded x2
        public void FF1(){} // RVA: 0x7FFAFC10FCC0
        public void FF2(){} // RVA: 0x7FFAFC10FDB0
        public void FF3(){} // RVA: 0x7FFAFC10FDF0
        public void FF4(){} // RVA: 0x7FFAFC10FE30
        public void ProcessBlock(){} // RVA: 0x7FFAFC10FE70
        public void Copy(){} // RVA: 0x7FFAFC111620
    }

    public class RipeMD160Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC111850 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC111910
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC1119D0
        public void GetDigestSize(){} // RVA: 0x7FFAF30AAB20
        public void ProcessWord(){} // RVA: 0x7FFAFC111A10
        public void ProcessLength(){} // RVA: 0x7FFAFC111AE0
        public void UnpackWord(){} // RVA: 0x7FFAFC10CEF0
        public void DoFinal(){} // RVA: 0x7FFAFC111B50
        public void Reset(){} // RVA: 0x7FFAFC116790 | overloaded x2
        public void RL(){} // RVA: 0x7FFAFC0C69B0
        public void F1(){} // RVA: 0x7FFAF868DCF0
        public void F2(){} // RVA: 0x7FFAF868DCD0
        public void F3(){} // RVA: 0x7FFAFC10FCA0
        public void F4(){} // RVA: 0x7FFAFC10FCB0
        public void F5(){} // RVA: 0x7FFAFC111E00
        public void ProcessBlock(){} // RVA: 0x7FFAFC111E10
        public void Copy(){} // RVA: 0x7FFAFC1166A0
    }

    public class RipeMD256Digest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC116820
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE300
        public void .ctor(){} // RVA: 0x7FFAFC116910 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC1169D0
        public void ProcessWord(){} // RVA: 0x7FFAFC116AA0
        public void ProcessLength(){} // RVA: 0x7FFAFC116B70
        public void UnpackWord(){} // RVA: 0x7FFAFC10CEF0
        public void DoFinal(){} // RVA: 0x7FFAFC116BE0
        public void Reset(){} // RVA: 0x7FFAFC118820 | overloaded x2
        public void RL(){} // RVA: 0x7FFAFC0C69B0
        public void F1(){} // RVA: 0x7FFAFC10FCC0 | overloaded x2
        public void F2(){} // RVA: 0x7FFAFC10FCF0 | overloaded x2
        public void F3(){} // RVA: 0x7FFAFC10FD30 | overloaded x2
        public void F4(){} // RVA: 0x7FFAFC10FD70 | overloaded x2
        public void FF1(){} // RVA: 0x7FFAFC10FCC0
        public void FF2(){} // RVA: 0x7FFAFC10FDB0
        public void FF3(){} // RVA: 0x7FFAFC10FDF0
        public void FF4(){} // RVA: 0x7FFAFC10FE30
        public void ProcessBlock(){} // RVA: 0x7FFAFC116FB0
        public void Copy(){} // RVA: 0x7FFAFC118730
    }

    public class RipeMD320Digest
    {
        // ── Methods ──
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC1188B0
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE2E0
        public void .ctor(){} // RVA: 0x7FFAFC1189A0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC118A60
        public void ProcessWord(){} // RVA: 0x7FFAFC118B40
        public void ProcessLength(){} // RVA: 0x7FFAFC118C10
        public void UnpackWord(){} // RVA: 0x7FFAFC10CEF0
        public void DoFinal(){} // RVA: 0x7FFAFC118C80
        public void Reset(){} // RVA: 0x7FFAFC11DB10 | overloaded x2
        public void RL(){} // RVA: 0x7FFAFC0C69B0
        public void F1(){} // RVA: 0x7FFAF868DCF0
        public void F2(){} // RVA: 0x7FFAF868DCD0
        public void F3(){} // RVA: 0x7FFAFC10FCA0
        public void F4(){} // RVA: 0x7FFAFC10FCB0
        public void F5(){} // RVA: 0x7FFAFC111E00
        public void ProcessBlock(){} // RVA: 0x7FFAFC119100
        public void Copy(){} // RVA: 0x7FFAFC11DA20
    }

    public class SM3Digest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC127A20
        public void .ctor(){} // RVA: 0x7FFAFC127D30 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC127F10
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC127FA0
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE300
        public void Copy(){} // RVA: 0x7FFAFC127FE0
        public void Reset(){} // RVA: 0x7FFAFC128160 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFAFC128280
        public void ProcessWord(){} // RVA: 0x7FFAFC128360
        public void ProcessLength(){} // RVA: 0x7FFAFC128430
        public void P0(){} // RVA: 0x7FFAFC128510
        public void P1(){} // RVA: 0x7FFAFC128540
        public void FF0(){} // RVA: 0x7FFAF868DCF0
        public void FF1(){} // RVA: 0x7FFAF868DCE0
        public void GG0(){} // RVA: 0x7FFAF868DCF0
        public void GG1(){} // RVA: 0x7FFAF868DCD0
        public void ProcessBlock(){} // RVA: 0x7FFAFC128570
    }

    public class Sha1Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC11DC50 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC111910
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC11DD10
        public void GetDigestSize(){} // RVA: 0x7FFAF30AAB20
        public void ProcessWord(){} // RVA: 0x7FFAFC11DD50
        public void ProcessLength(){} // RVA: 0x7FFAFC11DE20
        public void DoFinal(){} // RVA: 0x7FFAFC11DE90
        public void Reset(){} // RVA: 0x7FFAFC11E980 | overloaded x2
        public void F(){} // RVA: 0x7FFAF873CF00
        public void H(){} // RVA: 0x7FFAF873CEF0
        public void G(){} // RVA: 0x7FFAFC11E130
        public void ProcessBlock(){} // RVA: 0x7FFAFC11E140
        public void Copy(){} // RVA: 0x7FFAFC11E920
    }

    public class Sha224Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC11EAC0 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC1169D0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC11EB80
        public void GetDigestSize(){} // RVA: 0x7FFAF39B0450
        public void ProcessWord(){} // RVA: 0x7FFAFC11EBC0
        public void ProcessLength(){} // RVA: 0x7FFAFC11EC90
        public void DoFinal(){} // RVA: 0x7FFAFC11ED00
        public void Reset(){} // RVA: 0x7FFAFC11FA30 | overloaded x2
        public void ProcessBlock(){} // RVA: 0x7FFAFC11F060
        public void Ch(){} // RVA: 0x7FFAF8748C90
        public void Maj(){} // RVA: 0x7FFAF8748CA0
        public void Sum0(){} // RVA: 0x7FFAFC11F950
        public void Sum1(){} // RVA: 0x7FFAFC11F990
        public void Theta0(){} // RVA: 0x7FFAFC0BE040
        public void Theta1(){} // RVA: 0x7FFAFC0BE070
        public void Copy(){} // RVA: 0x7FFAFC11F9D0
        public void .cctor(){} // RVA: 0x7FFAFC11FAC0
    }

    public class Sha256Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC11FC70 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC1169D0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC11FD30
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE300
        public void ProcessWord(){} // RVA: 0x7FFAFC11EBC0
        public void ProcessLength(){} // RVA: 0x7FFAFC11EC90
        public void DoFinal(){} // RVA: 0x7FFAFC11FD70
        public void Reset(){} // RVA: 0x7FFAFC120B40 | overloaded x2
        public void initHs(){} // RVA: 0x7FFAFC120130
        public void ProcessBlock(){} // RVA: 0x7FFAFC120170
        public void Sum1Ch(){} // RVA: 0x7FFAFC120A40
        public void Sum0Maj(){} // RVA: 0x7FFAFC120A90
        public void Theta0(){} // RVA: 0x7FFAFC0BE040
        public void Theta1(){} // RVA: 0x7FFAFC0BE070
        public void Copy(){} // RVA: 0x7FFAFC120AE0
        public void .cctor(){} // RVA: 0x7FFAFC120BD0
    }

    public class Sha384Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC120D00 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC120D60
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE2D0
        public void DoFinal(){} // RVA: 0x7FFAFC120DA0
        public void Reset(){} // RVA: 0x7FFAFC1212E0 | overloaded x2
        public void Copy(){} // RVA: 0x7FFAFC121250
    }

    public class Sha3Digest
    {
        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0x7FFAFC121370
        public void .ctor(){} // RVA: 0x7FFAFC121540 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC1215A0
        public void DoFinal(){} // RVA: 0x7FFAFC121670 | overloaded x2
        public void Copy(){} // RVA: 0x7FFAFC121810
    }

    public class Sha512Digest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1218F0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC121950
        public void GetDigestSize(){} // RVA: 0x7FFAF371A420
        public void DoFinal(){} // RVA: 0x7FFAFC121990
        public void Reset(){} // RVA: 0x7FFAFC122050 | overloaded x2
        public void Copy(){} // RVA: 0x7FFAFC121FC0
    }

    public class Sha512tDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1222C0 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC122350
        public void GetDigestSize(){} // RVA: 0x7FFAF36690C0
        public void DoFinal(){} // RVA: 0x7FFAFC122420
        public void Reset(){} // RVA: 0x7FFAFC122E20 | overloaded x2
        public void tIvGenerate(){} // RVA: 0x7FFAFC1225F0
        public void UInt64_To_BE(){} // RVA: 0x7FFAFC122B90
        public void UInt32_To_BE(){} // RVA: 0x7FFAFC122C90
        public void Copy(){} // RVA: 0x7FFAFC122D60
    }

    public class ShakeDigest
    {
        // ── Methods ──
        public void CheckBitLength(){} // RVA: 0x7FFAFC122F80
        public void .ctor(){} // RVA: 0x7FFAFC123180 | overloaded x3
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC1231E0
        public void DoFinal(){} // RVA: 0x7FFAFC1233D0 | overloaded x4
        public void DoOutput(){} // RVA: 0x7FFAFC1232E0
        public void Copy(){} // RVA: 0x7FFAFC123560
    }

    public class ShortenedDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC1235F0
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC123740
        public void GetDigestSize(){} // RVA: 0x7FFAF306ED50
        public void Update(){} // RVA: 0x7FFAFC123870
        public void BlockUpdate(){} // RVA: 0x7FFAFC1238D0
        public void DoFinal(){} // RVA: 0x7FFAFC123960
        public void Reset(){} // RVA: 0x7FFAFC123A40
        public void GetByteLength(){} // RVA: 0x7FFAFC123A90
    }

    public class SkeinDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC123BB0 | overloaded x2
        public void Reset(){} // RVA: 0x7FFAFC07C890 | overloaded x2
        public void Copy(){} // RVA: 0x7FFAFC123E70
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC123FB0
        public void GetDigestSize(){} // RVA: 0x7FFAF39EF910
        public void GetByteLength(){} // RVA: 0x7FFAFC124170
        public void Init(){} // RVA: 0x7FFAFC1241B0
        public void Update(){} // RVA: 0x7FFAFC07C8F0
        public void BlockUpdate(){} // RVA: 0x7FFAFC07C910
        public void DoFinal(){} // RVA: 0x7FFAFC07C940
    }

    public class SkeinEngine
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC1241D0
        public void InitialState(){} // RVA: 0x7FFAFC124590
        public void VariantIdentifier(){} // RVA: 0x7FFAFC124690
        public void .ctor(){} // RVA: 0x7FFAFC124930 | overloaded x2
        public void CopyIn(){} // RVA: 0x7FFAFC1249A0
        public void Clone(){} // RVA: 0x7FFAFC124D20
        public void Copy(){} // RVA: 0x7FFAFC124DC0
        public void Reset(){} // RVA: 0x7FFAFC125EF0 | overloaded x2
        public void get_OutputSize(){} // RVA: 0x7FFAF306ED50
        public void get_BlockSize(){} // RVA: 0x7FFAF32A0310
        public void Init(){} // RVA: 0x7FFAFC124FA0
        public void InitParams(){} // RVA: 0x7FFAFC1251A0
        public void CreateInitialState(){} // RVA: 0x7FFAFC125850
        public void UbiComplete(){} // RVA: 0x7FFAFC125F40
        public void UbiInit(){} // RVA: 0x7FFAFC125FB0
        public void UbiFinal(){} // RVA: 0x7FFAFC126080
        public void CheckInitialised(){} // RVA: 0x7FFAFC1260B0
        public void Update(){} // RVA: 0x7FFAFC1261D0 | overloaded x2
        public void DoFinal(){} // RVA: 0x7FFAFC126250
        public void Output(){} // RVA: 0x7FFAFC126520
    }

    public class TigerDigest
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC128C80 | overloaded x2
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC128E90
        public void GetDigestSize(){} // RVA: 0x7FFAF4BBE290
        public void GetByteLength(){} // RVA: 0x7FFAF371A420
        public void ProcessWord(){} // RVA: 0x7FFAFC128ED0
        public void Update(){} // RVA: 0x7FFAFC129040
        public void BlockUpdate(){} // RVA: 0x7FFAFC1290B0
        public void RoundABC(){} // RVA: 0x7FFAFC129220
        public void RoundBCA(){} // RVA: 0x7FFAFC129410
        public void RoundCAB(){} // RVA: 0x7FFAFC129600
        public void KeySchedule(){} // RVA: 0x7FFAFC1297F0
        public void ProcessBlock(){} // RVA: 0x7FFAFC129B10
        public void UnpackWord(){} // RVA: 0x7FFAFC129FD0
        public void ProcessLength(){} // RVA: 0x7FFAFC12A0C0
        public void Finish(){} // RVA: 0x7FFAFC12A0F0
        public void DoFinal(){} // RVA: 0x7FFAFC12A1E0
        public void Reset(){} // RVA: 0x7FFAFC12A490 | overloaded x2
        public void Copy(){} // RVA: 0x7FFAFC12A430
        public void .cctor(){} // RVA: 0x7FFAFC12A5A0
    }

    public class WhirlpoolDigest
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFC12A880
        public void .ctor(){} // RVA: 0x7FFAFC12B8A0 | overloaded x2
        public void packIntoLong(){} // RVA: 0x7FFAFC12B820
        public void maskWithReductionPolynomial(){} // RVA: 0x7FFAFC12B880
        public void get_AlgorithmName(){} // RVA: 0x7FFAFC12BC20
        public void GetDigestSize(){} // RVA: 0x7FFAF371A420
        public void DoFinal(){} // RVA: 0x7FFAFC12BC60
        public void Reset(){} // RVA: 0x7FFAFC12D3F0 | overloaded x2
        public void processFilledBuffer(){} // RVA: 0x7FFAFC12C050
        public void bytesToLongFromBuffer(){} // RVA: 0x7FFAFC12C250
        public void convertLongToByteArray(){} // RVA: 0x7FFAFC12C370
        public void processBlock(){} // RVA: 0x7FFAFC12C3D0
        public void Update(){} // RVA: 0x7FFAFC12CD80
        public void increment(){} // RVA: 0x7FFAFC12CEE0
        public void BlockUpdate(){} // RVA: 0x7FFAFC12D000
        public void finish(){} // RVA: 0x7FFAFC12D1B0
        public void copyBitLength(){} // RVA: 0x7FFAFC12D300
        public void GetByteLength(){} // RVA: 0x7FFAF371A420
        public void Copy(){} // RVA: 0x7FFAFC12D390
    }

}