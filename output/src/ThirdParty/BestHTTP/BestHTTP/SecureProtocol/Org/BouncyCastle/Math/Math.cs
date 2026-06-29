// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math
// Classes: 3
// Methods: 117

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math
{
    public class BigInteger : Object
    {
        public object primeLists;
        public object primeProducts;
        public object IMASK;
        public object UIMASK;
        public object ZeroMagnitude;
        public object ZeroEncoding;
        public object SMALL_CONSTANTS;
        public object Zero;
        public object One;
        public object Two;
        public object Three;
        public object Four;
        public object Ten;
        public object BitLengthTable;
        public object chunk2;
        public object chunk8;
        public object chunk10;
        public object chunk16;
        public object radix2;
        public object radix2E;
        public object radix8;
        public object radix8E;
        public object radix10;
        public object radix10E;
        public object radix16;
        public object radix16E;
        public object RandomSource;
        public object ExpWindowThresholds;
        public object BitsPerByte;
        public object BitsPerInt;
        public object BytesPerInt;
        public object magnitude;
        public object sign;
        public object nBits;
        public object nBitLength;
        public object mQuote;

        // ── Methods ──
        public void .cctor(){} // RVA: 0xA632750
        public void GetByteLength(){} // RVA: 0xA634C20
        public void Arbitrary(){} // RVA: 0xA634C30
        public void .ctor(){} // RVA: 0xA636220
        public void MakeMagnitude(){} // RVA: 0xA635CA0
        public void Abs(){} // RVA: 0xA636610
        public void AddMagnitudes(){} // RVA: 0xA636630
        public void Add(){} // RVA: 0xA636710
        public void AddToMagnitude(){} // RVA: 0xA6367C0
        public void And(){} // RVA: 0xA636960
        public void AndNot(){} // RVA: 0xA636CB0
        public void get_BitCount(){} // RVA: 0xA636D00
        public void BitCnt(){} // RVA: 0xA636E60
        public void CalcBitLength(){} // RVA: 0xA636EA0
        public void get_BitLength(){} // RVA: 0xA636FB0
        public void BitLen(){} // RVA: 0xA637040
        public void QuickPow2Check(){} // RVA: 0xA6371B0
        public void CompareTo(){} // RVA: 0xA637480
        public void CompareNoLeadingZeroes(){} // RVA: 0xA6373B0
        public void Divide(){} // RVA: 0xA638000
        public void DivideAndRemainder(){} // RVA: 0xA638230
        public void Equals(){} // RVA: 0xA638670
        public void IsEqualMagnitude(){} // RVA: 0xA638710
        public void Gcd(){} // RVA: 0xA638790
        public void GetHashCode(){} // RVA: 0xA638890
        public void Inc(){} // RVA: 0xA6388F0
        public void get_IntValue(){} // RVA: 0xA638A20
        public void IsProbablePrime(){} // RVA: 0xA638A80
        public void CheckProbablePrime(){} // RVA: 0xA638C00
        public void RabinMillerTest(){} // RVA: 0xA638E70
        public void get_LongValue(){} // RVA: 0xA639240
        public void Max(){} // RVA: 0xA6392C0
        public void Min(){} // RVA: 0xA6392F0
        public void Mod(){} // RVA: 0xA639320
        public void ModInverse(){} // RVA: 0xA6393B0
        public void ModInversePow2(){} // RVA: 0xA639690
        public void ModInverse32(){} // RVA: 0xA639960
        public void ModInverse64(){} // RVA: 0xA6399B0
        public void ExtEuclid(){} // RVA: 0xA639A10
        public void ZeroOut(){} // RVA: 0xA639B90
        public void ModPow(){} // RVA: 0xA639BC0
        public void ModPowBarrett(){} // RVA: 0xA639E50
        public void ReduceBarrett(){} // RVA: 0xA63A400
        public void ModPowMonty(){} // RVA: 0xA63A590
        public void GetWindowList(){} // RVA: 0xA63AEF0
        public void CreateWindowEntry(){} // RVA: 0xA63B170
        public void Square(){} // RVA: 0xA63C660
        public void Multiply(){} // RVA: 0xA63C300
        public void GetMQuote(){} // RVA: 0xA63B4F0
        public void MontgomeryReduce(){} // RVA: 0xA63B5C0
        public void MultiplyMonty(){} // RVA: 0xA63B780
        public void SquareMonty(){} // RVA: 0xA63BCC0
        public void MultiplyMontyNIsOne(){} // RVA: 0xA63C2C0
        public void Negate(){} // RVA: 0xA63C7D0
        public void NextProbablePrime(){} // RVA: 0xA63C860
        public void Not(){} // RVA: 0xA63CA80
        public void Pow(){} // RVA: 0xA63CAB0
        public void ProbablePrime(){} // RVA: 0xA63CCD0
        public void Remainder(){} // RVA: 0xA63D510
        public void LastNBits(){} // RVA: 0xA63D7E0
        public void DivideWords(){} // RVA: 0xA63D940
        public void RemainderWords(){} // RVA: 0xA63DA50
        public void ShiftLeft(){} // RVA: 0xA63DD60
        public void ShiftLeftOneInPlace(){} // RVA: 0xA63DD00
        public void ShiftRightInPlace(){} // RVA: 0xA63DEF0
        public void ShiftRightOneInPlace(){} // RVA: 0xA63E060
        public void ShiftRight(){} // RVA: 0xA63E100
        public void get_SignValue(){} // RVA: 0xE62D00
        public void Subtract(){} // RVA: 0xA63E4E0
        public void doSubBigLil(){} // RVA: 0xA63E680
        public void ToByteArray(){} // RVA: 0xA63E810
        public void ToByteArrayUnsigned(){} // RVA: 0xA63E800
        public void ToString(){} // RVA: 0xA63F5E0
        public void AppendZeroExtendedString(){} // RVA: 0xA63F870
        public void CreateUValueOf(){} // RVA: 0xA63F940
        public void CreateValueOf(){} // RVA: 0xA63FB40
        public void ValueOf(){} // RVA: 0xA63FC10
        public void GetLowestSetBit(){} // RVA: 0xA63FCF0
        public void GetLowestSetBitMaskFirst(){} // RVA: 0xA63FD10
        public void TestBit(){} // RVA: 0xA63FD90
        public void Or(){} // RVA: 0xA63FE70
        public void Xor(){} // RVA: 0xA6401A0
        public void SetBit(){} // RVA: 0xA6404D0
        public void ClearBit(){} // RVA: 0xA640600
        public void FlipBit(){} // RVA: 0xA640750
        public void FlipExistingBit(){} // RVA: 0xA640860
    }

    public class BigInteger[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Primes : Object
    {
        public object SmallFactorLimit;
        public object One;
        public object Two;
        public object Three;

        // ── Methods ──
        public void GenerateSTRandomPrime(){} // RVA: 0xA640A50
        public void EnhancedMRProbablePrimeTest(){} // RVA: 0xA640C60
        public void HasAnySmallFactors(){} // RVA: 0xA6412A0
        public void IsMRProbablePrime(){} // RVA: 0xA641380
        public void IsMRProbablePrimeToBase(){} // RVA: 0xA641690
        public void CheckCandidate(){} // RVA: 0xA641950
        public void ImplHasAnySmallFactors(){} // RVA: 0xA6419D0
        public void ImplMRProbablePrimeToBase(){} // RVA: 0xA642340
        public void ImplSTRandomPrime(){} // RVA: 0xA642520
        public void Extract32(){} // RVA: 0xA643310
        public void Hash(){} // RVA: 0xA6433C0
        public void HashGen(){} // RVA: 0xA643470
        public void Inc(){} // RVA: 0xA643650
        public void IsPrime32(){} // RVA: 0xA6436B0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA643810
    }

}