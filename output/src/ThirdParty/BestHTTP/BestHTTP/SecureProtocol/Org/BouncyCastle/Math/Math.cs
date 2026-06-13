// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math
// Classes: 2
// Methods: 124

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math
{
    public class BigInteger
    {
        public int[][] Factor;
        public int[] IsProvablyComposite; // 0x8
        public long IsNotPrimePower;
        public ulong .ctor;
        public int[] ZeroMagnitude; // 0x10

        // ── Methods ──
        public void .cctor(){} // RVA: 0x998A9F0
        public void GetByteLength(){} // RVA: 0x998CEB0
        public void Arbitrary(){} // RVA: 0x998CEC0
        public void .ctor(){} // RVA: 0x998E490 | overloaded x9
        public void MakeMagnitude(){} // RVA: 0x998DF40
        public void Abs(){} // RVA: 0x998E870
        public void AddMagnitudes(){} // RVA: 0x998E890
        public void Add(){} // RVA: 0x998E950
        public void AddToMagnitude(){} // RVA: 0x998EA00
        public void And(){} // RVA: 0x998EC10
        public void AndNot(){} // RVA: 0x998EF00
        public void get_BitCount(){} // RVA: 0x998EF50
        public void BitCnt(){} // RVA: 0x998F090
        public void CalcBitLength(){} // RVA: 0x998F0D0
        public void get_BitLength(){} // RVA: 0x998F1D0
        public void BitLen(){} // RVA: 0x998F260
        public void QuickPow2Check(){} // RVA: 0x998F3D0
        public void CompareTo(){} // RVA: 0x998F670 | overloaded x3
        public void CompareNoLeadingZeroes(){} // RVA: 0x998F5B0
        public void Divide(){} // RVA: 0x99900D0 | overloaded x2
        public void DivideAndRemainder(){} // RVA: 0x9990300
        public void Equals(){} // RVA: 0x9990740
        public void IsEqualMagnitude(){} // RVA: 0x99907F0
        public void Gcd(){} // RVA: 0x9990870
        public void GetHashCode(){} // RVA: 0x9990980
        public void Inc(){} // RVA: 0x99909E0
        public void get_IntValue(){} // RVA: 0x9990B10
        public void IsProbablePrime(){} // RVA: 0x9990B70 | overloaded x2
        public void CheckProbablePrime(){} // RVA: 0x9990CF0
        public void RabinMillerTest(){} // RVA: 0x9990F40 | overloaded x2
        public void get_LongValue(){} // RVA: 0x9991320
        public void Max(){} // RVA: 0x9991390
        public void Min(){} // RVA: 0x99913C0
        public void Mod(){} // RVA: 0x99913F0
        public void ModInverse(){} // RVA: 0x9991480
        public void ModInversePow2(){} // RVA: 0x9991760
        public void ModInverse32(){} // RVA: 0x9991A30
        public void ModInverse64(){} // RVA: 0x9991A70
        public void ExtEuclid(){} // RVA: 0x9991AD0
        public void ZeroOut(){} // RVA: 0x9991C50
        public void ModPow(){} // RVA: 0x9991C80
        public void ModPowBarrett(){} // RVA: 0x9991F10
        public void ReduceBarrett(){} // RVA: 0x9992490
        public void ModPowMonty(){} // RVA: 0x9992620
        public void GetWindowList(){} // RVA: 0x9992F40
        public void CreateWindowEntry(){} // RVA: 0x9993170
        public void Square(){} // RVA: 0x99942C0 | overloaded x2
        public void Multiply(){} // RVA: 0x9993FF0 | overloaded x2
        public void GetMQuote(){} // RVA: 0x9993430
        public void MontgomeryReduce(){} // RVA: 0x9993510
        public void MultiplyMonty(){} // RVA: 0x9993690
        public void SquareMonty(){} // RVA: 0x9993AF0
        public void MultiplyMontyNIsOne(){} // RVA: 0x9993FB0
        public void Negate(){} // RVA: 0x9994430
        public void NextProbablePrime(){} // RVA: 0x99944C0
        public void Not(){} // RVA: 0x99946E0
        public void Pow(){} // RVA: 0x9994710
        public void ProbablePrime(){} // RVA: 0x9994930
        public void Remainder(){} // RVA: 0x9995060 | overloaded x3
        public void LastNBits(){} // RVA: 0x9995370
        public void DivideWords(){} // RVA: 0x99954D0
        public void RemainderWords(){} // RVA: 0x99955E0
        public void ShiftLeft(){} // RVA: 0x99958F0 | overloaded x2
        public void ShiftLeftOneInPlace(){} // RVA: 0x9995890
        public void ShiftRightInPlace(){} // RVA: 0x9995A80
        public void ShiftRightOneInPlace(){} // RVA: 0x9995BB0
        public void ShiftRight(){} // RVA: 0x9995C40
        public void get_SignValue(){} // RVA: 0x5BED50
        public void Subtract(){} // RVA: 0x9996000 | overloaded x2
        public void doSubBigLil(){} // RVA: 0x99961A0
        public void ToByteArray(){} // RVA: 0x9996330 | overloaded x2
        public void ToByteArrayUnsigned(){} // RVA: 0x9996320
        public void ToString(){} // RVA: 0x99970D0 | overloaded x3
        public void AppendZeroExtendedString(){} // RVA: 0x9997370
        public void CreateUValueOf(){} // RVA: 0x9997440
        public void CreateValueOf(){} // RVA: 0x99975D0
        public void ValueOf(){} // RVA: 0x99976A0
        public void GetLowestSetBit(){} // RVA: 0x9997780
        public void GetLowestSetBitMaskFirst(){} // RVA: 0x99977A0
        public void TestBit(){} // RVA: 0x9997820
        public void Or(){} // RVA: 0x9997910
        public void Xor(){} // RVA: 0x9997BF0
        public void SetBit(){} // RVA: 0x9997ED0
        public void ClearBit(){} // RVA: 0x9998000
        public void FlipBit(){} // RVA: 0x9998150
        public void FlipExistingBit(){} // RVA: 0x9998260
    }

    public class Primes
    {
        // ── Methods ──
        public void GenerateSTRandomPrime(){} // RVA: 0x99983D0
        public void EnhancedMRProbablePrimeTest(){} // RVA: 0x99985E0
        public void HasAnySmallFactors(){} // RVA: 0x9998C20
        public void IsMRProbablePrime(){} // RVA: 0x9998D00
        public void IsMRProbablePrimeToBase(){} // RVA: 0x9999020
        public void CheckCandidate(){} // RVA: 0x99992E0
        public void ImplHasAnySmallFactors(){} // RVA: 0x9999360
        public void ImplMRProbablePrimeToBase(){} // RVA: 0x9999CD0
        public void ImplSTRandomPrime(){} // RVA: 0x9999EB0
        public void Extract32(){} // RVA: 0x999AC70
        public void Hash(){} // RVA: 0x999AD20
        public void HashGen(){} // RVA: 0x999ADD0
        public void Inc(){} // RVA: 0x999AFB0
        public void IsPrime32(){} // RVA: 0x999B000
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x999B160
    }

}