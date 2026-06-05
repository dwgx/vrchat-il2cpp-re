// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
// Classes: 4
// Methods: 68

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
{
    public class Curve25519
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBFAE460
        public void CloneCurve(){} // RVA: 0x7FFAFBFAE890
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFAFBFAE8E0
        public void get_Q(){} // RVA: 0x7FFAFBFAE8F0
        public void get_Infinity(){} // RVA: 0x7FFAF2E2E0E0
        public void get_FieldSize(){} // RVA: 0x7FFAFBFAE950
        public void FromBigInteger(){} // RVA: 0x7FFAFBFAE9C0
        public void CreateRawPoint(){} // RVA: 0x7FFAFBFAEB10 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFAFBFAEBB0
        public void .cctor(){} // RVA: 0x7FFAFBFAEE30
    }

    public class Curve25519Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAFBFAF1A0
        public void AddExt(){} // RVA: 0x7FFAFBFAF2E0
        public void AddOne(){} // RVA: 0x7FFAFBFAF410
        public void FromBigInteger(){} // RVA: 0x7FFAFBFAF5A0
        public void Half(){} // RVA: 0x7FFAFBFAF690
        public void Multiply(){} // RVA: 0x7FFAFBFAF7B0
        public void MultiplyAddToExt(){} // RVA: 0x7FFAFBFAF870
        public void Negate(){} // RVA: 0x7FFAFBFAF950
        public void Reduce(){} // RVA: 0x7FFAFBFAFA60
        public void Reduce27(){} // RVA: 0x7FFAFBFAFC90
        public void Square(){} // RVA: 0x7FFAFBFAFE30
        public void SquareN(){} // RVA: 0x7FFAFBFAFEE0
        public void Subtract(){} // RVA: 0x7FFAFBFAFFE0
        public void SubtractExt(){} // RVA: 0x7FFAFBFB00D0
        public void Twice(){} // RVA: 0x7FFAFBFB01A0
        public void AddPTo(){} // RVA: 0x7FFAFBFB0310
        public void AddPExtTo(){} // RVA: 0x7FFAFBFB03A0
        public void SubPFrom(){} // RVA: 0x7FFAFBFB0540
        public void SubPExtFrom(){} // RVA: 0x7FFAFBFB05C0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFBFB0760
    }

    public class Curve25519FieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFAFBF529B0
        public void get_IsOne(){} // RVA: 0x7FFAFBF529F0
        public void TestBitZero(){} // RVA: 0x7FFAFBF2CF00
        public void ToBigInteger(){} // RVA: 0x7FFAFBF52A50
        public void get_FieldName(){} // RVA: 0x7FFAFBFB0B10
        public void get_FieldSize(){} // RVA: 0x7FFAFBFB0B50
        public void Add(){} // RVA: 0x7FFAFBFB0BC0
        public void AddOne(){} // RVA: 0x7FFAFBFB0E40
        public void Subtract(){} // RVA: 0x7FFAFBFB0F40
        public void Multiply(){} // RVA: 0x7FFAFBFB10B0
        public void Divide(){} // RVA: 0x7FFAFBFB1220
        public void Negate(){} // RVA: 0x7FFAFBFB13E0
        public void Square(){} // RVA: 0x7FFAFBFB14E0
        public void Invert(){} // RVA: 0x7FFAFBFB15E0
        public void Sqrt(){} // RVA: 0x7FFAFBFB1730
        public void Equals(){} // RVA: 0x7FFAFBF53CC0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFAFBFB1C90
        public void .cctor(){} // RVA: 0x7FFAFBFB1D90
    }

    public class Curve25519Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBF2E360 | overloaded x3
        public void Detach(){} // RVA: 0x7FFAFBFB2070
        public void GetZCoord(){} // RVA: 0x7FFAFBFB2180
        public void Add(){} // RVA: 0x7FFAFBFB21E0
        public void Twice(){} // RVA: 0x7FFAFBFB2C70
        public void TwicePlus(){} // RVA: 0x7FFAFBFB2D20
        public void ThreeTimes(){} // RVA: 0x7FFAFBFB2E20
        public void Negate(){} // RVA: 0x7FFAFBFB2EB0
        public void CalculateJacobianModifiedW(){} // RVA: 0x7FFAFBFB2FB0
        public void GetJacobianModifiedW(){} // RVA: 0x7FFAFBFB31D0
        public void TwiceJacobianModified(){} // RVA: 0x7FFAFBFB3320
    }

}