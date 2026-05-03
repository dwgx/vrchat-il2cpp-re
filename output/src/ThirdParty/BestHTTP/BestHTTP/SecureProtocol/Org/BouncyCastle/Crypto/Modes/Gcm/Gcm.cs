// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.Gcm
// Classes: 8
// Methods: 55

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Modes.Gcm
{
    public class BasicGcmExponentiator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A011350
        public void ExponentiateX(){} // RVA: 0x7FFE8A011400
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BasicGcmMultiplier : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A011660
        public void MultiplyH(){} // RVA: 0x7FFE8A011710
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GcmUtilities : Object
    {
        // ── Methods ──
        public void GenerateLookup(){} // RVA: 0x7FFE8A011820
        public void OneAsBytes(){} // RVA: 0x7FFE8A011920
        public void OneAsUints(){} // RVA: 0x7FFE8A011980
        public void OneAsUlongs(){} // RVA: 0x7FFE8A0119E0
        public void AsBytes(){} // RVA: 0x7FFE8A011B60 | overloaded x4
        public void AsUints(){} // RVA: 0x7FFE8A011C60 | overloaded x2
        public void AsUlongs(){} // RVA: 0x7FFE8A011D70 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFE8A011FF0 | overloaded x3
        public void MultiplyP(){} // RVA: 0x7FFE8A0121D0 | overloaded x2
        public void MultiplyP8(){} // RVA: 0x7FFE8A0123B0 | overloaded x2
        public void ShiftRight(){} // RVA: 0x7FFE8A012550 | overloaded x2
        public void ShiftRightN(){} // RVA: 0x7FFE8A0126A0 | overloaded x2
        public void Xor(){} // RVA: 0x7FFE89F16F50 | overloaded x10
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A012E40
    }

    public class IGcmExponentiator
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void ExponentiateX(){}
    }

    public class IGcmMultiplier
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void MultiplyH(){} // RVA: 0x7FFE80E460A0
    }

    public class Tables1kGcmExponentiator : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A012FC0
        public void ExponentiateX(){} // RVA: 0x7FFE8A0132D0
        public void EnsureAvailable(){} // RVA: 0x7FFE8A013500
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Tables64kGcmMultiplier : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A023660
        public void MultiplyH(){} // RVA: 0x7FFE8A023FF0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Tables8kGcmMultiplier : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE8A0241B0
        public void MultiplyH(){} // RVA: 0x7FFE8A024F10
        public void .ctor(){} // RVA: 0x7FFE8A0251F0
    }

}