// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math
// Classes: 2
// Methods: 124

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math
{
    public class BigInteger : Object
    {
        public int[][] primeLists;
        public int[] primeProducts; // 0x8
        public long IMASK;
        public ulong UIMASK;
        public int[] ZeroMagnitude; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8A3E6420
        public void GetByteLength(){} // RVA: 0x7FFE8A3E88E0
        public void Arbitrary(){} // RVA: 0x7FFE8A3E88F0
        public void .ctor(){} // RVA: 0x7FFE8A3E9EC0 | overloaded x9
        public void MakeMagnitude(){} // RVA: 0x7FFE8A3E9970
        public void Abs(){} // RVA: 0x7FFE8A3EA2A0
        public void AddMagnitudes(){} // RVA: 0x7FFE8A3EA2C0
        public void Add(){} // RVA: 0x7FFE8A3EA380
        public void AddToMagnitude(){} // RVA: 0x7FFE8A3EA430
        public void And(){} // RVA: 0x7FFE8A3EA640
        public void AndNot(){} // RVA: 0x7FFE8A3EA930
        public void get_BitCount(){} // RVA: 0x7FFE8A3EA980
        public void BitCnt(){} // RVA: 0x7FFE8A3EAAC0
        public void CalcBitLength(){} // RVA: 0x7FFE8A3EAB00
        public void get_BitLength(){} // RVA: 0x7FFE8A3EAC00
        public void BitLen(){} // RVA: 0x7FFE8A3EAC90
        public void QuickPow2Check(){} // RVA: 0x7FFE8A3EAE00
        public void CompareTo(){} // RVA: 0x7FFE8A3EB0A0 | overloaded x3
        public void CompareNoLeadingZeroes(){} // RVA: 0x7FFE8A3EAFE0
        public void Divide(){} // RVA: 0x7FFE8A3EBB00 | overloaded x2
        public void DivideAndRemainder(){} // RVA: 0x7FFE8A3EBD30
        public void Equals(){} // RVA: 0x7FFE8A3EC170
        public void IsEqualMagnitude(){} // RVA: 0x7FFE8A3EC220
        public void Gcd(){} // RVA: 0x7FFE8A3EC2A0
        public void GetHashCode(){} // RVA: 0x7FFE8A3EC3B0
        public void Inc(){} // RVA: 0x7FFE8A3EC410
        public void get_IntValue(){} // RVA: 0x7FFE8A3EC540
        public void IsProbablePrime(){} // RVA: 0x7FFE8A3EC5A0 | overloaded x2
        public void CheckProbablePrime(){} // RVA: 0x7FFE8A3EC720
        public void RabinMillerTest(){} // RVA: 0x7FFE8A3EC970 | overloaded x2
        public void get_LongValue(){} // RVA: 0x7FFE8A3ECD50
        public void Max(){} // RVA: 0x7FFE8A3ECDC0
        public void Min(){} // RVA: 0x7FFE8A3ECDF0
        public void Mod(){} // RVA: 0x7FFE8A3ECE20
        public void ModInverse(){} // RVA: 0x7FFE8A3ECEB0
        public void ModInversePow2(){} // RVA: 0x7FFE8A3ED190
        public void ModInverse32(){} // RVA: 0x7FFE8A3ED460
        public void ModInverse64(){} // RVA: 0x7FFE8A3ED4A0
        public void ExtEuclid(){} // RVA: 0x7FFE8A3ED500
        public void ZeroOut(){} // RVA: 0x7FFE8A3ED680
        public void ModPow(){} // RVA: 0x7FFE8A3ED6B0
        public void ModPowBarrett(){} // RVA: 0x7FFE8A3ED940
        public void ReduceBarrett(){} // RVA: 0x7FFE8A3EDEC0
        public void ModPowMonty(){} // RVA: 0x7FFE8A3EE050
        public void GetWindowList(){} // RVA: 0x7FFE8A3EE970
        public void CreateWindowEntry(){} // RVA: 0x7FFE8A3EEBA0
        public void Square(){} // RVA: 0x7FFE8A3EFCF0 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFE8A3EFA20 | overloaded x2
        public void GetMQuote(){} // RVA: 0x7FFE8A3EEE60
        public void MontgomeryReduce(){} // RVA: 0x7FFE8A3EEF40
        public void MultiplyMonty(){} // RVA: 0x7FFE8A3EF0C0
        public void SquareMonty(){} // RVA: 0x7FFE8A3EF520
        public void MultiplyMontyNIsOne(){} // RVA: 0x7FFE8A3EF9E0
        public void Negate(){} // RVA: 0x7FFE8A3EFE60
        public void NextProbablePrime(){} // RVA: 0x7FFE8A3EFEF0
        public void Not(){} // RVA: 0x7FFE8A3F0110
        public void Pow(){} // RVA: 0x7FFE8A3F0140
        public void ProbablePrime(){} // RVA: 0x7FFE8A3F0360
        public void Remainder(){} // RVA: 0x7FFE8A3F0A90 | overloaded x3
        public void LastNBits(){} // RVA: 0x7FFE8A3F0DA0
        public void DivideWords(){} // RVA: 0x7FFE8A3F0F00
        public void RemainderWords(){} // RVA: 0x7FFE8A3F1010
        public void ShiftLeft(){} // RVA: 0x7FFE8A3F1320 | overloaded x2
        public void ShiftLeftOneInPlace(){} // RVA: 0x7FFE8A3F12C0
        public void ShiftRightInPlace(){} // RVA: 0x7FFE8A3F14B0
        public void ShiftRightOneInPlace(){} // RVA: 0x7FFE8A3F15E0
        public void ShiftRight(){} // RVA: 0x7FFE8A3F1670
        public void get_SignValue(){} // RVA: 0x7FFE813DB630
        public void Subtract(){} // RVA: 0x7FFE8A3F1A30 | overloaded x2
        public void doSubBigLil(){} // RVA: 0x7FFE8A3F1BD0
        public void ToByteArray(){} // RVA: 0x7FFE8A3F1D60 | overloaded x2
        public void ToByteArrayUnsigned(){} // RVA: 0x7FFE8A3F1D50
        public void ToString(){} // RVA: 0x7FFE8A3F2B00 | overloaded x3
        public void AppendZeroExtendedString(){} // RVA: 0x7FFE8A3F2DA0
        public void CreateUValueOf(){} // RVA: 0x7FFE8A3F2E70
        public void CreateValueOf(){} // RVA: 0x7FFE8A3F3000
        public void ValueOf(){} // RVA: 0x7FFE8A3F30D0
        public void GetLowestSetBit(){} // RVA: 0x7FFE8A3F31B0
        public void GetLowestSetBitMaskFirst(){} // RVA: 0x7FFE8A3F31D0
        public void TestBit(){} // RVA: 0x7FFE8A3F3250
        public void Or(){} // RVA: 0x7FFE8A3F3340
        public void Xor(){} // RVA: 0x7FFE8A3F3620
        public void SetBit(){} // RVA: 0x7FFE8A3F3900
        public void ClearBit(){} // RVA: 0x7FFE8A3F3A30
        public void FlipBit(){} // RVA: 0x7FFE8A3F3B80
        public void FlipExistingBit(){} // RVA: 0x7FFE8A3F3C90
    }

    public class Primes : Object
    {
        // ── Methods ──
        public void GenerateSTRandomPrime(){} // RVA: 0x7FFE8A3F3E00
        public void EnhancedMRProbablePrimeTest(){} // RVA: 0x7FFE8A3F4010
        public void HasAnySmallFactors(){} // RVA: 0x7FFE8A3F4650
        public void IsMRProbablePrime(){} // RVA: 0x7FFE8A3F4730
        public void IsMRProbablePrimeToBase(){} // RVA: 0x7FFE8A3F4A50
        public void CheckCandidate(){} // RVA: 0x7FFE8A3F4D10
        public void ImplHasAnySmallFactors(){} // RVA: 0x7FFE8A3F4D90
        public void ImplMRProbablePrimeToBase(){} // RVA: 0x7FFE8A3F5700
        public void ImplSTRandomPrime(){} // RVA: 0x7FFE8A3F58E0
        public void Extract32(){} // RVA: 0x7FFE8A3F66A0
        public void Hash(){} // RVA: 0x7FFE8A3F6750
        public void HashGen(){} // RVA: 0x7FFE8A3F6800
        public void Inc(){} // RVA: 0x7FFE8A3F69E0
        public void IsPrime32(){} // RVA: 0x7FFE8A3F6A30
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A3F6B90
    }

}