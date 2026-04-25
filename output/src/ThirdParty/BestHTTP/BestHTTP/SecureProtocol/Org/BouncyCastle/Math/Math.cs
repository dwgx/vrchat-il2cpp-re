// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math
// Classes: 2
// Methods: 124

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math
{
    public class BigInteger : Object
    {
        public int[][] BitCount;
        public int[] BitLength; // 0x8
        public long IntValue;
        public ulong LongValue;
        public int[] SignValue; // 0x10
        public byte[] ZeroEncoding; // 0x18
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger[] SMALL_CONSTANTS; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Zero; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger One; // 0x30
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Two; // 0x38
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Three; // 0x40
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Four; // 0x48
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Ten; // 0x50
        public byte[] BitLengthTable; // 0x58
        public int chunk2;
        public int chunk8;
        public int chunk10;
        public int chunk16;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger radix2; // 0x60
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger radix2E; // 0x68
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger radix8; // 0x70
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger radix8E; // 0x78
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger radix10; // 0x80
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger radix10E; // 0x88
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger radix16; // 0x90
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger radix16E; // 0x98
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom RandomSource; // 0xA0
        public int[] ExpWindowThresholds; // 0xA8
        public int BitsPerByte;
        public int BitsPerInt;
        public int BytesPerInt;
        public int[] magnitude; // 0x10
        public int sign; // 0x18
        public int nBits; // 0x1C
        public int nBitLength; // 0x20
        public int mQuote; // 0x24

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFACBF858B0
        public void GetByteLength(){} // RVA: 0x7FFACBF87D70
        public void Arbitrary(){} // RVA: 0x7FFACBF87D80
        public void .ctor(){} // RVA: 0x7FFACBF89350 | overloaded x9
        public void MakeMagnitude(){} // RVA: 0x7FFACBF88E00
        public void Abs(){} // RVA: 0x7FFACBF89730
        public void AddMagnitudes(){} // RVA: 0x7FFACBF89750
        public void Add(){} // RVA: 0x7FFACBF89810
        public void AddToMagnitude(){} // RVA: 0x7FFACBF898C0
        public void And(){} // RVA: 0x7FFACBF89AD0
        public void AndNot(){} // RVA: 0x7FFACBF89DC0
        public void get_BitCount(){} // RVA: 0x7FFACBF89E10
        public void BitCnt(){} // RVA: 0x7FFACBF89F50
        public void CalcBitLength(){} // RVA: 0x7FFACBF89F90
        public void get_BitLength(){} // RVA: 0x7FFACBF8A090
        public void BitLen(){} // RVA: 0x7FFACBF8A120
        public void QuickPow2Check(){} // RVA: 0x7FFACBF8A290
        public void CompareTo(){} // RVA: 0x7FFACBF8A530 | overloaded x3
        public void CompareNoLeadingZeroes(){} // RVA: 0x7FFACBF8A470
        public void Divide(){} // RVA: 0x7FFACBF8AF90 | overloaded x2
        public void DivideAndRemainder(){} // RVA: 0x7FFACBF8B1C0
        public void Equals(){} // RVA: 0x7FFACBF8B600
        public void IsEqualMagnitude(){} // RVA: 0x7FFACBF8B6B0
        public void Gcd(){} // RVA: 0x7FFACBF8B730
        public void GetHashCode(){} // RVA: 0x7FFACBF8B840
        public void Inc(){} // RVA: 0x7FFACBF8B8A0
        public void get_IntValue(){} // RVA: 0x7FFACBF8B9D0
        public void IsProbablePrime(){} // RVA: 0x7FFACBF8BA30 | overloaded x2
        public void CheckProbablePrime(){} // RVA: 0x7FFACBF8BBB0
        public void RabinMillerTest(){} // RVA: 0x7FFACBF8BE00 | overloaded x2
        public void get_LongValue(){} // RVA: 0x7FFACBF8C1E0
        public void Max(){} // RVA: 0x7FFACBF8C250
        public void Min(){} // RVA: 0x7FFACBF8C280
        public void Mod(){} // RVA: 0x7FFACBF8C2B0
        public void ModInverse(){} // RVA: 0x7FFACBF8C340
        public void ModInversePow2(){} // RVA: 0x7FFACBF8C620
        public void ModInverse32(){} // RVA: 0x7FFACBF8C8F0
        public void ModInverse64(){} // RVA: 0x7FFACBF8C930
        public void ExtEuclid(){} // RVA: 0x7FFACBF8C990
        public void ZeroOut(){} // RVA: 0x7FFACBF8CB10
        public void ModPow(){} // RVA: 0x7FFACBF8CB40
        public void ModPowBarrett(){} // RVA: 0x7FFACBF8CDD0
        public void ReduceBarrett(){} // RVA: 0x7FFACBF8D350
        public void ModPowMonty(){} // RVA: 0x7FFACBF8D4E0
        public void GetWindowList(){} // RVA: 0x7FFACBF8DE00
        public void CreateWindowEntry(){} // RVA: 0x7FFACBF8E030
        public void Square(){} // RVA: 0x7FFACBF8F180 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFACBF8EEB0 | overloaded x2
        public void GetMQuote(){} // RVA: 0x7FFACBF8E2F0
        public void MontgomeryReduce(){} // RVA: 0x7FFACBF8E3D0
        public void MultiplyMonty(){} // RVA: 0x7FFACBF8E550
        public void SquareMonty(){} // RVA: 0x7FFACBF8E9B0
        public void MultiplyMontyNIsOne(){} // RVA: 0x7FFACBF8EE70
        public void Negate(){} // RVA: 0x7FFACBF8F2F0
        public void NextProbablePrime(){} // RVA: 0x7FFACBF8F380
        public void Not(){} // RVA: 0x7FFACBF8F5A0
        public void Pow(){} // RVA: 0x7FFACBF8F5D0
        public void ProbablePrime(){} // RVA: 0x7FFACBF8F7F0
        public void Remainder(){} // RVA: 0x7FFACBF8FF20 | overloaded x3
        public void LastNBits(){} // RVA: 0x7FFACBF90230
        public void DivideWords(){} // RVA: 0x7FFACBF90390
        public void RemainderWords(){} // RVA: 0x7FFACBF904A0
        public void ShiftLeft(){} // RVA: 0x7FFACBF907B0 | overloaded x2
        public void ShiftLeftOneInPlace(){} // RVA: 0x7FFACBF90750
        public void ShiftRightInPlace(){} // RVA: 0x7FFACBF90940
        public void ShiftRightOneInPlace(){} // RVA: 0x7FFACBF90A70
        public void ShiftRight(){} // RVA: 0x7FFACBF90B00
        public void get_SignValue(){} // RVA: 0x7FFAC3157800
        public void Subtract(){} // RVA: 0x7FFACBF90EC0 | overloaded x2
        public void doSubBigLil(){} // RVA: 0x7FFACBF91060
        public void ToByteArray(){} // RVA: 0x7FFACBF911F0 | overloaded x2
        public void ToByteArrayUnsigned(){} // RVA: 0x7FFACBF911E0
        public void ToString(){} // RVA: 0x7FFACBF91F90 | overloaded x3
        public void AppendZeroExtendedString(){} // RVA: 0x7FFACBF92230
        public void CreateUValueOf(){} // RVA: 0x7FFACBF92300
        public void CreateValueOf(){} // RVA: 0x7FFACBF92490
        public void ValueOf(){} // RVA: 0x7FFACBF92560
        public void GetLowestSetBit(){} // RVA: 0x7FFACBF92640
        public void GetLowestSetBitMaskFirst(){} // RVA: 0x7FFACBF92660
        public void TestBit(){} // RVA: 0x7FFACBF926E0
        public void Or(){} // RVA: 0x7FFACBF927D0
        public void Xor(){} // RVA: 0x7FFACBF92AB0
        public void SetBit(){} // RVA: 0x7FFACBF92D90
        public void ClearBit(){} // RVA: 0x7FFACBF92EC0
        public void FlipBit(){} // RVA: 0x7FFACBF93010
        public void FlipExistingBit(){} // RVA: 0x7FFACBF93120
    }

    public class Primes : Object
    {
        public int SmallFactorLimit;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger One; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Two; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Three; // 0x18

        // ── Methods ──
        public void GenerateSTRandomPrime(){} // RVA: 0x7FFACBF93290
        public void EnhancedMRProbablePrimeTest(){} // RVA: 0x7FFACBF934A0
        public void HasAnySmallFactors(){} // RVA: 0x7FFACBF93AE0
        public void IsMRProbablePrime(){} // RVA: 0x7FFACBF93BC0
        public void IsMRProbablePrimeToBase(){} // RVA: 0x7FFACBF93EE0
        public void CheckCandidate(){} // RVA: 0x7FFACBF941A0
        public void ImplHasAnySmallFactors(){} // RVA: 0x7FFACBF94220
        public void ImplMRProbablePrimeToBase(){} // RVA: 0x7FFACBF94B90
        public void ImplSTRandomPrime(){} // RVA: 0x7FFACBF94D70
        public void Extract32(){} // RVA: 0x7FFACBF95B30
        public void Hash(){} // RVA: 0x7FFACBF95BE0
        public void HashGen(){} // RVA: 0x7FFACBF95C90
        public void Inc(){} // RVA: 0x7FFACBF95E70
        public void IsPrime32(){} // RVA: 0x7FFACBF95EC0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF96020
    }

}