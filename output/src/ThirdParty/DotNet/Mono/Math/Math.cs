// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Math
// Classes: 1
// Methods: 44

namespace ThirdParty.DotNet.Mono.Math
{
    public class BigInteger : Object
    {
        public uint Rng; // 0x10
        public uint[] data; // 0x18
        public uint[] smallPrimes;
        public System.Security.Cryptography.RandomNumberGenerator rng; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83816B0 | overloaded x5
        public void op_Implicit(){} // RVA: 0x7FFAC83817D0 | overloaded x2
        public void op_Addition(){} // RVA: 0x7FFAC8381880
        public void op_Subtraction(){} // RVA: 0x7FFAC8381A20
        public void op_Modulus(){} // RVA: 0x7FFAC8381D70 | overloaded x2
        public void op_Division(){} // RVA: 0x7FFAC8381DA0
        public void op_Multiply(){} // RVA: 0x7FFAC8381DD0
        public void op_LeftShift(){} // RVA: 0x7FFAC83820F0
        public void op_RightShift(){} // RVA: 0x7FFAC8382100
        public void get_Rng(){} // RVA: 0x7FFAC8382110
        public void GenerateRandom(){} // RVA: 0x7FFAC8382400 | overloaded x2
        public void BitCount(){} // RVA: 0x7FFAC8382560
        public void TestBit(){} // RVA: 0x7FFAC8382610
        public void SetBit(){} // RVA: 0x7FFAC8382710 | overloaded x2
        public void LowestSetBit(){} // RVA: 0x7FFAC8382770
        public void GetBytes(){} // RVA: 0x7FFAC8382880
        public void op_Equality(){} // RVA: 0x7FFAC8382B20 | overloaded x2
        public void op_Inequality(){} // RVA: 0x7FFAC8382BE0 | overloaded x2
        public void op_GreaterThan(){} // RVA: 0x7FFAC8382CA0
        public void op_LessThan(){} // RVA: 0x7FFAC8382CC0
        public void op_GreaterThanOrEqual(){} // RVA: 0x7FFAC8382CE0
        public void op_LessThanOrEqual(){} // RVA: 0x7FFAC8382D00
        public void ToString(){} // RVA: 0x7FFAC8383270 | overloaded x3
        public void Normalize(){} // RVA: 0x7FFAC8383190
        public void Clear(){} // RVA: 0x7FFAC83831E0
        public void GetHashCode(){} // RVA: 0x7FFAC8383230
        public void Equals(){} // RVA: 0x7FFAC83832C0
        public void ModInverse(){} // RVA: 0x7FFAC8383430
        public void ModPow(){} // RVA: 0x7FFAC8383440
        public void GeneratePseudoPrime(){} // RVA: 0x7FFAC83834D0
        public void Incr2(){} // RVA: 0x7FFAC8383530
        public void .cctor(){} // RVA: 0x7FFAC83835E0
    }

}