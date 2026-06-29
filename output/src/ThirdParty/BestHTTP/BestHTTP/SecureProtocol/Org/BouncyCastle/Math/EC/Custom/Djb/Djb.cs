// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
// Classes: 4
// Methods: 61

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Djb
{
    public class Curve25519 : AbstractFpCurve
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1334260
        public void CloneCurve(){} // RVA: 0x7B13346B0
        public void SupportsCoordinateSystem(){} // RVA: 0x7B1334700
        public void get_Q(){} // RVA: 0x7B1334710
        public void get_Infinity(){} // RVA: 0x7A8178B90
        public void get_FieldSize(){} // RVA: 0x7B1334770
        public void FromBigInteger(){} // RVA: 0x7B13347E0
        public void CreateRawPoint(){} // RVA: 0x7B1334930
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7B13349D0
        public void .cctor(){} // RVA: 0x7B1334C60
    }

    public class Curve25519Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7B1334FD0
        public void AddExt(){} // RVA: 0x7B1335130
        public void AddOne(){} // RVA: 0x7B1335290
        public void FromBigInteger(){} // RVA: 0x7B1335450
        public void Half(){} // RVA: 0x7B1335550
        public void Multiply(){} // RVA: 0x7B1335670
        public void MultiplyAddToExt(){} // RVA: 0x7B1335730
        public void Negate(){} // RVA: 0x7B1335820
        public void Reduce(){} // RVA: 0x7B1335950
        public void Reduce27(){} // RVA: 0x7B1335BA0
        public void Square(){} // RVA: 0x7B1335D80
        public void SquareN(){} // RVA: 0x7B1335E30
        public void Subtract(){} // RVA: 0x7B1335F30
        public void SubtractExt(){} // RVA: 0x7B1336020
        public void Twice(){} // RVA: 0x7B1336100
        public void AddPTo(){} // RVA: 0x7B13362A0
        public void AddPExtTo(){} // RVA: 0x7B1336330
        public void SubPFrom(){} // RVA: 0x7B13364D0
        public void SubPExtFrom(){} // RVA: 0x7B1336560
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7B1336710
    }

    public class Curve25519FieldElement : AbstractFpFieldElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_IsZero(){} // RVA: 0x7B12D6F40
        public void get_IsOne(){} // RVA: 0x7B12D6FA0
        public void TestBitZero(){} // RVA: 0x7B12B10D0
        public void ToBigInteger(){} // RVA: 0x7B12D7000
        public void get_FieldName(){} // RVA: 0x7B1336AD0
        public void get_FieldSize(){} // RVA: 0x7B1336B10
        public void Add(){} // RVA: 0x7B1336B80
        public void AddOne(){} // RVA: 0x7B1336E10
        public void Subtract(){} // RVA: 0x7B1336F10
        public void Multiply(){} // RVA: 0x7B1337080
        public void Divide(){} // RVA: 0x7B13371F0
        public void Negate(){} // RVA: 0x7B13373B0
        public void Square(){} // RVA: 0x7B13374B0
        public void Invert(){} // RVA: 0x7B13375B0
        public void Sqrt(){} // RVA: 0x7B1337700
        public void Equals(){} // RVA: 0x7B12D82C0
        public void GetHashCode(){} // RVA: 0x7B1337C90
        public void .cctor(){} // RVA: 0x7B1337D90
    }

    public class Curve25519Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B12B2560
        public void Detach(){} // RVA: 0x7B1338070
        public void GetZCoord(){} // RVA: 0x7B1338180
        public void Add(){} // RVA: 0x7B13381E0
        public void Twice(){} // RVA: 0x7B1338CA0
        public void TwicePlus(){} // RVA: 0x7B1338D50
        public void ThreeTimes(){} // RVA: 0x7B1338E50
        public void Negate(){} // RVA: 0x7B1338EE0
        public void CalculateJacobianModifiedW(){} // RVA: 0x7B1338FE0
        public void GetJacobianModifiedW(){} // RVA: 0x7B1339210
        public void TwiceJacobianModified(){} // RVA: 0x7B1339360
    }

}