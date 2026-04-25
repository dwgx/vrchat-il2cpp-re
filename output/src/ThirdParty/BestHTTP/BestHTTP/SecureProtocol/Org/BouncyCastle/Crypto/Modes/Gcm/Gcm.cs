// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.Gcm
// Classes: 8
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.Gcm
{
    public class BasicGcmExponentiator : Object
    {
        public uint[] x; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBB7D30
        public void ExponentiateX(){} // RVA: 0x7FFACBBB7DE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BasicGcmMultiplier : Object
    {
        public uint[] H; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBB8040
        public void MultiplyH(){} // RVA: 0x7FFACBBB80F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GcmUtilities : Object
    {
        public uint E1;
        public ulong E1L;
        public uint[] LOOKUP;

        // ── Methods ──
        public void GenerateLookup(){} // RVA: 0x7FFACBBB8200
        public void OneAsBytes(){} // RVA: 0x7FFACBBB8300
        public void OneAsUints(){} // RVA: 0x7FFACBBB8360
        public void OneAsUlongs(){} // RVA: 0x7FFACBBB83C0
        public void AsBytes(){} // RVA: 0x7FFACBBB8540 | overloaded x4
        public void AsUints(){} // RVA: 0x7FFACBBB8640 | overloaded x2
        public void AsUlongs(){} // RVA: 0x7FFACBBB8750 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFACBBB89D0 | overloaded x3
        public void MultiplyP(){} // RVA: 0x7FFACBBB8BB0 | overloaded x2
        public void MultiplyP8(){} // RVA: 0x7FFACBBB8D90 | overloaded x2
        public void ShiftRight(){} // RVA: 0x7FFACBBB8F30 | overloaded x2
        public void ShiftRightN(){} // RVA: 0x7FFACBBB9080 | overloaded x2
        public void Xor(){} // RVA: 0x7FFACBABD930 | overloaded x10
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBBB9820
    }

    public class IGcmExponentiator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void ExponentiateX(){}
    }

    public class IGcmMultiplier
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void MultiplyH(){} // RVA: 0x7FFAC2C70A40
    }

    public class Tables1kGcmExponentiator : Object
    {
        public System.Collections.IList lookupPowX2; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBB99A0
        public void ExponentiateX(){} // RVA: 0x7FFACBBB9CB0
        public void EnsureAvailable(){} // RVA: 0x7FFACBBB9EE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Tables64kGcmMultiplier : Object
    {
        public byte[] H; // 0x10
        public uint[][][] M; // 0x18

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBCA040
        public void MultiplyH(){} // RVA: 0x7FFACBBCA9D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Tables8kGcmMultiplier : Object
    {
        public byte[] H; // 0x10
        public uint[][][] M; // 0x18
        public uint[] z; // 0x20

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFACBBCAB90
        public void MultiplyH(){} // RVA: 0x7FFACBBCB8F0
        public void .ctor(){} // RVA: 0x7FFACBBCBBD0
    }

}