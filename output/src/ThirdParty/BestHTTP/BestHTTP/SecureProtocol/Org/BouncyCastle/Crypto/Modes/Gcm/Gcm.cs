// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.Gcm
// Classes: 8
// Methods: 35

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.Gcm
{
    public class BasicGcmExponentiator : Object
    {
        public object x;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2511B0
        public void ExponentiateX(){} // RVA: 0xA251260
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BasicGcmMultiplier : Object
    {
        public object H;

        // ── Methods ──
        public void Init(){} // RVA: 0xA2514B0
        public void MultiplyH(){} // RVA: 0xA251560
        public void .ctor(){} // RVA: 0xB43310
    }

    public class GcmUtilities : Object
    {
        public object E1;
        public object E1L;
        public object LOOKUP;

        // ── Methods ──
        public void GenerateLookup(){} // RVA: 0xA251670
        public void OneAsBytes(){} // RVA: 0xA251770
        public void OneAsUints(){} // RVA: 0xA2517D0
        public void OneAsUlongs(){} // RVA: 0xA251830
        public void AsBytes(){} // RVA: 0xA2519B0
        public void AsUints(){} // RVA: 0xA251AA0
        public void AsUlongs(){} // RVA: 0xA251BB0
        public void Multiply(){} // RVA: 0xA251E30
        public void MultiplyP(){} // RVA: 0xA252010
        public void MultiplyP8(){} // RVA: 0xA2521F0
        public void ShiftRight(){} // RVA: 0xA252390
        public void ShiftRightN(){} // RVA: 0xA2524E0
        public void Xor(){} // RVA: 0xA1556D0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA252CB0
    }

    public class IGcmExponentiator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void ExponentiateX(){} // RVA: 0x8947D0
    }

    public class IGcmMultiplier
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x894320
        public void MultiplyH(){} // RVA: 0x894320
    }

    public class Tables1kGcmExponentiator : Object
    {
        public object lookupPowX2;

        // ── Methods ──
        public void Init(){} // RVA: 0xA252E30
        public void ExponentiateX(){} // RVA: 0xA253160
        public void EnsureAvailable(){} // RVA: 0xA253390
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Tables64kGcmMultiplier : Object
    {
        public object H;
        public object M;

        // ── Methods ──
        public void Init(){} // RVA: 0xA263990
        public void MultiplyH(){} // RVA: 0xA2643A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Tables8kGcmMultiplier : Object
    {
        public object H;
        public object M;
        public object z;

        // ── Methods ──
        public void Init(){} // RVA: 0xA264560
        public void MultiplyH(){} // RVA: 0xA265300
        public void .ctor(){} // RVA: 0xA2655E0
    }

}