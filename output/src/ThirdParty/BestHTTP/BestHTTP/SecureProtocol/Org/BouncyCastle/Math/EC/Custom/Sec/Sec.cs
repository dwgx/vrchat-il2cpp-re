// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
// Classes: 100
// Methods: 1663

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
    public class SecP128R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP128R1_DEFAULT_COORDS;
        public int SECP128R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EDC6A0
        public void CloneCurve(){} // RVA: 0x7FFE89EDCAD0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89EDCB30
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89EDCB90
        public void FromBigInteger(){} // RVA: 0x7FFE89EDCC00
        public void CreateRawPoint(){} // RVA: 0x7FFE89EDCE40 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89EDCEE0
        public void .cctor(){} // RVA: 0x7FFE89EDD250
    }

    public class SecP128R1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89EDD620
        public void AddExt(){} // RVA: 0x7FFE89EDD860
        public void AddOne(){} // RVA: 0x7FFE89EDD9E0
        public void FromBigInteger(){} // RVA: 0x7FFE89EDDBA0
        public void Half(){} // RVA: 0x7FFE89EDDE50
        public void Multiply(){} // RVA: 0x7FFE89EDE030
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89EDE0F0
        public void Negate(){} // RVA: 0x7FFE89EDE270
        public void Reduce(){} // RVA: 0x7FFE89EDE400
        public void Reduce32(){} // RVA: 0x7FFE89EDE550
        public void Square(){} // RVA: 0x7FFE89EDE710
        public void SquareN(){} // RVA: 0x7FFE89EDE7C0
        public void Subtract(){} // RVA: 0x7FFE89EDE8C0
        public void SubtractExt(){} // RVA: 0x7FFE89EDEA60
        public void Twice(){} // RVA: 0x7FFE89EDEBA0
        public void AddPInvTo(){} // RVA: 0x7FFE89EDED40
        public void SubPInvFrom(){} // RVA: 0x7FFE89EDEDD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EDEE40
    }

    public class SecP128R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2; // 0x239
        public object field_3; // 0x23A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89EDF230
        public void get_IsOne(){} // RVA: 0x7FFE89EDF270
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89EDF300
        public void get_FieldName(){} // RVA: 0x7FFE89EDF440
        public void get_FieldSize(){} // RVA: 0x7FFE89EDF480
        public void Add(){} // RVA: 0x7FFE89EDF4F0
        public void AddOne(){} // RVA: 0x7FFE89EDF660
        public void Subtract(){} // RVA: 0x7FFE89EDF760
        public void Multiply(){} // RVA: 0x7FFE89EDF8D0
        public void Divide(){} // RVA: 0x7FFE89EDFA40
        public void Negate(){} // RVA: 0x7FFE89EDFC00
        public void Square(){} // RVA: 0x7FFE89EDFD00
        public void Invert(){} // RVA: 0x7FFE89EDFE00
        public void Sqrt(){} // RVA: 0x7FFE89EDFF50
        public void Equals(){} // RVA: 0x7FFE89EE03B0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89EE0420
        public void .cctor(){} // RVA: 0x7FFE89EE0520
    }

    public class SecP128R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89EE0750
        public void Add(){} // RVA: 0x7FFE89EE0860
        public void Twice(){} // RVA: 0x7FFE89EE1300
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89EE1B40
    }

    public class SecP160K1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP160K1_DEFAULT_COORDS;
        public int SECP160K1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE1C40
        public void CloneCurve(){} // RVA: 0x7FFE89EE1FE0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89EE2030
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89EE2090
        public void FromBigInteger(){} // RVA: 0x7FFE89EE2100
        public void CreateRawPoint(){} // RVA: 0x7FFE89EE2250 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89EE22F0
        public void .cctor(){} // RVA: 0x7FFE89EE26A0
    }

    public class SecP160K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89EE2B40
        public void Add(){} // RVA: 0x7FFE89EE2C50
        public void Twice(){} // RVA: 0x7FFE89EE35B0
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89EE3DD0
    }

    public class SecP160R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP160R1_DEFAULT_COORDS;
        public int SECP160R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE3ED0
        public void CloneCurve(){} // RVA: 0x7FFE89EE4300
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89EE4350
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89EE43B0
        public void FromBigInteger(){} // RVA: 0x7FFE89EE4420
        public void CreateRawPoint(){} // RVA: 0x7FFE89EE4570 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89EE4610
        public void .cctor(){} // RVA: 0x7FFE89EE49C0
    }

    public class SecP160R1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89EE4D90
        public void AddExt(){} // RVA: 0x7FFE89EE4EC0
        public void AddOne(){} // RVA: 0x7FFE89EE50E0
        public void FromBigInteger(){} // RVA: 0x7FFE89EE5260
        public void Half(){} // RVA: 0x7FFE89EE5350
        public void Multiply(){} // RVA: 0x7FFE89EE5480
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89EE5540
        public void Negate(){} // RVA: 0x7FFE89EE5720
        public void Reduce(){} // RVA: 0x7FFE89EE5800
        public void Reduce32(){} // RVA: 0x7FFE89EE5980
        public void Square(){} // RVA: 0x7FFE89EE5AF0
        public void SquareN(){} // RVA: 0x7FFE89EE5BA0
        public void Subtract(){} // RVA: 0x7FFE89EE5CA0
        public void SubtractExt(){} // RVA: 0x7FFE89EE5D20
        public void Twice(){} // RVA: 0x7FFE89EE5EC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EE6010
    }

    public class SecP160R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2; // 0x245
        public object field_3; // 0x246

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89EE64E0
        public void get_IsOne(){} // RVA: 0x7FFE89EE6520
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89EE6580
        public void get_FieldName(){} // RVA: 0x7FFE89EE6590
        public void get_FieldSize(){} // RVA: 0x7FFE89EE65D0
        public void Add(){} // RVA: 0x7FFE89EE6640
        public void AddOne(){} // RVA: 0x7FFE89EE67B0
        public void Subtract(){} // RVA: 0x7FFE89EE68B0
        public void Multiply(){} // RVA: 0x7FFE89EE6A80
        public void Divide(){} // RVA: 0x7FFE89EE6BF0
        public void Negate(){} // RVA: 0x7FFE89EE6DB0
        public void Square(){} // RVA: 0x7FFE89EE6EB0
        public void Invert(){} // RVA: 0x7FFE89EE6FB0
        public void Sqrt(){} // RVA: 0x7FFE89EE7100
        public void Equals(){} // RVA: 0x7FFE89EE7520 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89EE7590
        public void .cctor(){} // RVA: 0x7FFE89EE7690
    }

    public class SecP160R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89EE78A0
        public void Add(){} // RVA: 0x7FFE89EE79B0
        public void Twice(){} // RVA: 0x7FFE89EE83C0
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89EE8D70
    }

    public class SecP160R2Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP160R2_DEFAULT_COORDS;
        public int SECP160R2_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE8E70
        public void CloneCurve(){} // RVA: 0x7FFE89EE92A0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89EE92F0
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89EE9350
        public void FromBigInteger(){} // RVA: 0x7FFE89EE93C0
        public void CreateRawPoint(){} // RVA: 0x7FFE89EE9510 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89EE95B0
        public void .cctor(){} // RVA: 0x7FFE89EE9960
    }

    public class SecP160R2Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89EE9D30
        public void AddExt(){} // RVA: 0x7FFE89EE9E80
        public void AddOne(){} // RVA: 0x7FFE89EEA0A0
        public void FromBigInteger(){} // RVA: 0x7FFE89EEA240
        public void Half(){} // RVA: 0x7FFE89EEA330
        public void Multiply(){} // RVA: 0x7FFE89EEA460
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89EEA520
        public void Negate(){} // RVA: 0x7FFE89EEA700
        public void Reduce(){} // RVA: 0x7FFE89EEA7E0
        public void Reduce32(){} // RVA: 0x7FFE89EEA9E0
        public void Square(){} // RVA: 0x7FFE89EEAB90
        public void SquareN(){} // RVA: 0x7FFE89EEAC40
        public void Subtract(){} // RVA: 0x7FFE89EEAD40
        public void SubtractExt(){} // RVA: 0x7FFE89EEADD0
        public void Twice(){} // RVA: 0x7FFE89EEAF70
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EEB0E0
    }

    public class SecP160R2FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2; // 0x24D
        public object field_3; // 0x24E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89EE64E0
        public void get_IsOne(){} // RVA: 0x7FFE89EE6520
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89EE6580
        public void get_FieldName(){} // RVA: 0x7FFE89EEB520
        public void get_FieldSize(){} // RVA: 0x7FFE89EEB560
        public void Add(){} // RVA: 0x7FFE89EEB5D0
        public void AddOne(){} // RVA: 0x7FFE89EEB740
        public void Subtract(){} // RVA: 0x7FFE89EEB840
        public void Multiply(){} // RVA: 0x7FFE89EEBA30
        public void Divide(){} // RVA: 0x7FFE89EEBBA0
        public void Negate(){} // RVA: 0x7FFE89EEBD60
        public void Square(){} // RVA: 0x7FFE89EEBE60
        public void Invert(){} // RVA: 0x7FFE89EEBF60
        public void Sqrt(){} // RVA: 0x7FFE89EEC0B0
        public void Equals(){} // RVA: 0x7FFE89EE7520 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89EEC680
        public void .cctor(){} // RVA: 0x7FFE89EEC780
    }

    public class SecP160R2Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89EEC990
        public void Add(){} // RVA: 0x7FFE89EECAA0
        public void Twice(){} // RVA: 0x7FFE89EED400
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89EEDD10
    }

    public class SecP192K1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP192K1_DEFAULT_COORDS;
        public int SECP192K1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EEDE10
        public void CloneCurve(){} // RVA: 0x7FFE89EEE1B0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89EEE200
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89EEE260
        public void FromBigInteger(){} // RVA: 0x7FFE89EEE2D0
        public void CreateRawPoint(){} // RVA: 0x7FFE89EEE420 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89EEE4C0
        public void .cctor(){} // RVA: 0x7FFE89EEE740
    }

    public class SecP192K1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89EEEB10
        public void AddExt(){} // RVA: 0x7FFE89EEEC60
        public void AddOne(){} // RVA: 0x7FFE89EEEE80
        public void FromBigInteger(){} // RVA: 0x7FFE89EEF020
        public void Half(){} // RVA: 0x7FFE89EEF110
        public void Multiply(){} // RVA: 0x7FFE89EEF240
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89EEF300
        public void Negate(){} // RVA: 0x7FFE89EEF4E0
        public void Reduce(){} // RVA: 0x7FFE89EEF5D0
        public void Reduce32(){} // RVA: 0x7FFE89EEF7B0
        public void Square(){} // RVA: 0x7FFE89EEF960
        public void SquareN(){} // RVA: 0x7FFE89EEFA10
        public void Subtract(){} // RVA: 0x7FFE89EEFB10
        public void SubtractExt(){} // RVA: 0x7FFE89EEFBA0
        public void Twice(){} // RVA: 0x7FFE89EEFD40
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EEFEB0
    }

    public class SecP192K1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2; // 0x255
        public object field_3; // 0x256

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89EF0380
        public void get_IsOne(){} // RVA: 0x7FFE89EF03C0
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89EF0420
        public void get_FieldName(){} // RVA: 0x7FFE89EF0430
        public void get_FieldSize(){} // RVA: 0x7FFE89EF0470
        public void Add(){} // RVA: 0x7FFE89EF04E0
        public void AddOne(){} // RVA: 0x7FFE89EF0750
        public void Subtract(){} // RVA: 0x7FFE89EF0850
        public void Multiply(){} // RVA: 0x7FFE89EF0A40
        public void Divide(){} // RVA: 0x7FFE89EF0BB0
        public void Negate(){} // RVA: 0x7FFE89EF0D70
        public void Square(){} // RVA: 0x7FFE89EF0E70
        public void Invert(){} // RVA: 0x7FFE89EF0F70
        public void Sqrt(){} // RVA: 0x7FFE89EF10C0
        public void Equals(){} // RVA: 0x7FFE89EF1610 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89EF1680
        public void .cctor(){} // RVA: 0x7FFE89EF1780
    }

    public class SecP192K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89EF1990
        public void Add(){} // RVA: 0x7FFE89EF1AA0
        public void Twice(){} // RVA: 0x7FFE89EF2400
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89EF2C20
    }

    public class SecP192R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP192R1_DEFAULT_COORDS;
        public int SECP192R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EF2D20
        public void CloneCurve(){} // RVA: 0x7FFE89EF3150
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89EF31A0
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89EF3200
        public void FromBigInteger(){} // RVA: 0x7FFE89EF3270
        public void CreateRawPoint(){} // RVA: 0x7FFE89EF33C0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89EF3460
        public void .cctor(){} // RVA: 0x7FFE89EF36E0
    }

    public class SecP192R1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89EF3AB0
        public void AddExt(){} // RVA: 0x7FFE89EF3BC0
        public void AddOne(){} // RVA: 0x7FFE89EF3DE0
        public void FromBigInteger(){} // RVA: 0x7FFE89EF3F40
        public void Half(){} // RVA: 0x7FFE89EF4030
        public void Multiply(){} // RVA: 0x7FFE89EF4160
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89EF4220
        public void Negate(){} // RVA: 0x7FFE89EF4400
        public void Reduce(){} // RVA: 0x7FFE89EF44F0
        public void Reduce32(){} // RVA: 0x7FFE89EF4780
        public void Square(){} // RVA: 0x7FFE89EF48E0
        public void SquareN(){} // RVA: 0x7FFE89EF4990
        public void Subtract(){} // RVA: 0x7FFE89EF4A90
        public void SubtractExt(){} // RVA: 0x7FFE89EF4BA0
        public void Twice(){} // RVA: 0x7FFE89EF4D40
        public void AddPInvTo(){} // RVA: 0x7FFE89EF4E80
        public void SubPInvFrom(){} // RVA: 0x7FFE89EF4F30
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EF4FD0
    }

    public class SecP192R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2; // 0x25D
        public object field_3; // 0x25E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89EF0380
        public void get_IsOne(){} // RVA: 0x7FFE89EF03C0
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89EF0420
        public void get_FieldName(){} // RVA: 0x7FFE89EF5410
        public void get_FieldSize(){} // RVA: 0x7FFE89EF5450
        public void Add(){} // RVA: 0x7FFE89EF54C0
        public void AddOne(){} // RVA: 0x7FFE89EF5630
        public void Subtract(){} // RVA: 0x7FFE89EF5870
        public void Multiply(){} // RVA: 0x7FFE89EF59E0
        public void Divide(){} // RVA: 0x7FFE89EF5B50
        public void Negate(){} // RVA: 0x7FFE89EF5D10
        public void Square(){} // RVA: 0x7FFE89EF5E10
        public void Invert(){} // RVA: 0x7FFE89EF5F10
        public void Sqrt(){} // RVA: 0x7FFE89EF6060
        public void Equals(){} // RVA: 0x7FFE89EF1610 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89EF6490
        public void .cctor(){} // RVA: 0x7FFE89EF6590
    }

    public class SecP192R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89EF67A0
        public void Add(){} // RVA: 0x7FFE89EF68B0
        public void Twice(){} // RVA: 0x7FFE89EF7210
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89EF79F0
    }

    public class SecP224K1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP224K1_DEFAULT_COORDS;
        public int SECP224K1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EF7AF0
        public void CloneCurve(){} // RVA: 0x7FFE89EF7E90
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89EF7EE0
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89EF7F40
        public void FromBigInteger(){} // RVA: 0x7FFE89EF7FB0
        public void CreateRawPoint(){} // RVA: 0x7FFE89EF8100 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89EF81A0
        public void .cctor(){} // RVA: 0x7FFE89EF8420
    }

    public class SecP224K1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89EF87F0
        public void AddExt(){} // RVA: 0x7FFE89EF8940
        public void AddOne(){} // RVA: 0x7FFE89EF8B60
        public void FromBigInteger(){} // RVA: 0x7FFE89EF8D00
        public void Half(){} // RVA: 0x7FFE89EF8DF0
        public void Multiply(){} // RVA: 0x7FFE89EF8F20
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89EF8FE0
        public void Negate(){} // RVA: 0x7FFE89EF91C0
        public void Reduce(){} // RVA: 0x7FFE89EF92C0
        public void Reduce32(){} // RVA: 0x7FFE89EF94A0
        public void Square(){} // RVA: 0x7FFE89EF9650
        public void SquareN(){} // RVA: 0x7FFE89EF9700
        public void Subtract(){} // RVA: 0x7FFE89EF9800
        public void SubtractExt(){} // RVA: 0x7FFE89EF9890
        public void Twice(){} // RVA: 0x7FFE89EF9A30
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EF9BA0
    }

    public class SecP224K1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] PRECOMP_POW2; // 0x8
        public uint[] x; // 0x10
        public object field_3; // 0x265

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89EFA070
        public void get_IsOne(){} // RVA: 0x7FFE89EFA0B0
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89EFA110
        public void get_FieldName(){} // RVA: 0x7FFE89EFA120
        public void get_FieldSize(){} // RVA: 0x7FFE89EFA160
        public void Add(){} // RVA: 0x7FFE89EFA1D0
        public void AddOne(){} // RVA: 0x7FFE89EFA440
        public void Subtract(){} // RVA: 0x7FFE89EFA540
        public void Multiply(){} // RVA: 0x7FFE89EFA730
        public void Divide(){} // RVA: 0x7FFE89EFA8A0
        public void Negate(){} // RVA: 0x7FFE89EFAA60
        public void Square(){} // RVA: 0x7FFE89EFAB60
        public void Invert(){} // RVA: 0x7FFE89EFAC60
        public void Sqrt(){} // RVA: 0x7FFE89EFADB0
        public void Equals(){} // RVA: 0x7FFE89EFB400 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89EFB470
        public void .cctor(){} // RVA: 0x7FFE89EFB570
    }

    public class SecP224K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89EFB850
        public void Add(){} // RVA: 0x7FFE89EFB960
        public void Twice(){} // RVA: 0x7FFE89EFC2C0
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89EFCAE0
    }

    public class SecP224R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP224R1_DEFAULT_COORDS;
        public int SECP224R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EFCBE0
        public void CloneCurve(){} // RVA: 0x7FFE89EFD010
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89EFD060
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89EFD0C0
        public void FromBigInteger(){} // RVA: 0x7FFE89EFD130
        public void CreateRawPoint(){} // RVA: 0x7FFE89EFD280 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89EFD320
        public void .cctor(){} // RVA: 0x7FFE89EFD5A0
    }

    public class SecP224R1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89EFD970
        public void AddExt(){} // RVA: 0x7FFE89EFDA80
        public void AddOne(){} // RVA: 0x7FFE89EFDCA0
        public void FromBigInteger(){} // RVA: 0x7FFE89EFDE00
        public void Half(){} // RVA: 0x7FFE89EFDEF0
        public void Multiply(){} // RVA: 0x7FFE89EFE020
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89EFE0E0
        public void Negate(){} // RVA: 0x7FFE89EFE2C0
        public void Reduce(){} // RVA: 0x7FFE89EFE3C0
        public void Reduce32(){} // RVA: 0x7FFE89EFE680
        public void Square(){} // RVA: 0x7FFE89EFE800
        public void SquareN(){} // RVA: 0x7FFE89EFE8B0
        public void Subtract(){} // RVA: 0x7FFE89EFE9B0
        public void SubtractExt(){} // RVA: 0x7FFE89EFEAE0
        public void Twice(){} // RVA: 0x7FFE89EFEC80
        public void AddPInvTo(){} // RVA: 0x7FFE89EFEDC0
        public void SubPInvFrom(){} // RVA: 0x7FFE89EFEE60
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89EFEF30
    }

    public class SecP224R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2; // 0x26D
        public object field_3; // 0x26E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89EFA070
        public void get_IsOne(){} // RVA: 0x7FFE89EFA0B0
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89EFA110
        public void get_FieldName(){} // RVA: 0x7FFE89EFF370
        public void get_FieldSize(){} // RVA: 0x7FFE89EFF3B0
        public void Add(){} // RVA: 0x7FFE89EFF420
        public void AddOne(){} // RVA: 0x7FFE89EFF590
        public void Subtract(){} // RVA: 0x7FFE89EFF690
        public void Multiply(){} // RVA: 0x7FFE89EFF800
        public void Divide(){} // RVA: 0x7FFE89EFF970
        public void Negate(){} // RVA: 0x7FFE89EFFB30
        public void Square(){} // RVA: 0x7FFE89EFFC30
        public void Invert(){} // RVA: 0x7FFE89EFFD30
        public void Sqrt(){} // RVA: 0x7FFE89EFFE80
        public void Equals(){} // RVA: 0x7FFE89EFB400 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F003B0
        public void IsSquare(){} // RVA: 0x7FFE89F004B0
        public void RM(){} // RVA: 0x7FFE89F007A0
        public void RP(){} // RVA: 0x7FFE89F00990
        public void RS(){} // RVA: 0x7FFE89F00DA0
        public void TrySqrt(){} // RVA: 0x7FFE89F00EB0
        public void .cctor(){} // RVA: 0x7FFE89F013B0
    }

    public class SecP224R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F015C0
        public void Add(){} // RVA: 0x7FFE89F016D0
        public void Twice(){} // RVA: 0x7FFE89F02030
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89F026F0
    }

    public class SecP256K1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP256K1_DEFAULT_COORDS;
        public int SECP256K1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F027F0
        public void CloneCurve(){} // RVA: 0x7FFE89F02B90
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89F02BE0
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89F02C40
        public void FromBigInteger(){} // RVA: 0x7FFE89F02CB0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F02E00 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F02EA0
        public void .cctor(){} // RVA: 0x7FFE89F03120
    }

    public class SecP256K1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F034F0
        public void AddExt(){} // RVA: 0x7FFE89F03640
        public void AddOne(){} // RVA: 0x7FFE89F03860
        public void FromBigInteger(){} // RVA: 0x7FFE89F03A00
        public void Half(){} // RVA: 0x7FFE89F03AF0
        public void Multiply(){} // RVA: 0x7FFE89F03C20
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F03CE0
        public void Negate(){} // RVA: 0x7FFE89F03EC0
        public void Reduce(){} // RVA: 0x7FFE89F03FD0
        public void Reduce32(){} // RVA: 0x7FFE89F041B0
        public void Square(){} // RVA: 0x7FFE89F04360
        public void SquareN(){} // RVA: 0x7FFE89F04410
        public void Subtract(){} // RVA: 0x7FFE89F04510
        public void SubtractExt(){} // RVA: 0x7FFE89F045A0
        public void Twice(){} // RVA: 0x7FFE89F04740
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F048B0
    }

    public class SecP256K1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2;
        public object field_3;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89F04D80
        public void get_IsOne(){} // RVA: 0x7FFE89F04DC0
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89F04E20
        public void get_FieldName(){} // RVA: 0x7FFE89F04E30
        public void get_FieldSize(){} // RVA: 0x7FFE89F04E70
        public void Add(){} // RVA: 0x7FFE89F04EE0
        public void AddOne(){} // RVA: 0x7FFE89F05150
        public void Subtract(){} // RVA: 0x7FFE89F05250
        public void Multiply(){} // RVA: 0x7FFE89F05440
        public void Divide(){} // RVA: 0x7FFE89F055B0
        public void Negate(){} // RVA: 0x7FFE89F05770
        public void Square(){} // RVA: 0x7FFE89F05870
        public void Invert(){} // RVA: 0x7FFE89F05970
        public void Sqrt(){} // RVA: 0x7FFE89F05AC0
        public void Equals(){} // RVA: 0x7FFE89F06090 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F06100
        public void .cctor(){} // RVA: 0x7FFE89F06200
    }

    public class SecP256K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F06410
        public void Add(){} // RVA: 0x7FFE89F06520
        public void Twice(){} // RVA: 0x7FFE89F06E80
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89F076A0
    }

    public class SecP256R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP256R1_DEFAULT_COORDS;
        public int SECP256R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F077A0
        public void CloneCurve(){} // RVA: 0x7FFE89F07BD0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89F07C20
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89F07C80
        public void FromBigInteger(){} // RVA: 0x7FFE89F07CF0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F07E40 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F07EE0
        public void .cctor(){} // RVA: 0x7FFE89F08160
    }

    public class SecP256R1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F08530
        public void AddExt(){} // RVA: 0x7FFE89F08640
        public void AddOne(){} // RVA: 0x7FFE89F087F0
        public void FromBigInteger(){} // RVA: 0x7FFE89F08950
        public void Half(){} // RVA: 0x7FFE89F08A40
        public void Multiply(){} // RVA: 0x7FFE89F08B70
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F08C30
        public void Negate(){} // RVA: 0x7FFE89F08DA0
        public void Reduce(){} // RVA: 0x7FFE89F08EB0
        public void Reduce32(){} // RVA: 0x7FFE89F09120
        public void Square(){} // RVA: 0x7FFE89F09300
        public void SquareN(){} // RVA: 0x7FFE89F093B0
        public void Subtract(){} // RVA: 0x7FFE89F094B0
        public void SubtractExt(){} // RVA: 0x7FFE89F095F0
        public void Twice(){} // RVA: 0x7FFE89F09720
        public void AddPInvTo(){} // RVA: 0x7FFE89F09860
        public void SubPInvFrom(){} // RVA: 0x7FFE89F09960
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F09A40
    }

    public class SecP256R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2; // 0x27D
        public object field_3; // 0x27E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89F04D80
        public void get_IsOne(){} // RVA: 0x7FFE89F04DC0
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89F04E20
        public void get_FieldName(){} // RVA: 0x7FFE89F09DE0
        public void get_FieldSize(){} // RVA: 0x7FFE89F09E20
        public void Add(){} // RVA: 0x7FFE89F09E90
        public void AddOne(){} // RVA: 0x7FFE89F0A000
        public void Subtract(){} // RVA: 0x7FFE89F0A240
        public void Multiply(){} // RVA: 0x7FFE89F0A3B0
        public void Divide(){} // RVA: 0x7FFE89F0A520
        public void Negate(){} // RVA: 0x7FFE89F0A6E0
        public void Square(){} // RVA: 0x7FFE89F0A7E0
        public void Invert(){} // RVA: 0x7FFE89F0A8E0
        public void Sqrt(){} // RVA: 0x7FFE89F0AA30
        public void Equals(){} // RVA: 0x7FFE89F06090 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F0AE60
        public void .cctor(){} // RVA: 0x7FFE89F0AF60
    }

    public class SecP256R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F0B170
        public void Add(){} // RVA: 0x7FFE89F0B280
        public void Twice(){} // RVA: 0x7FFE89F0BD20
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89F0C500
    }

    public class SecP384R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP384R1_DEFAULT_COORDS;
        public int SECP384R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F0C600
        public void CloneCurve(){} // RVA: 0x7FFE89F0CA30
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89F0CA80
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89F0CAE0
        public void FromBigInteger(){} // RVA: 0x7FFE89F0CB50
        public void CreateRawPoint(){} // RVA: 0x7FFE89F0CCA0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F0CD40
        public void .cctor(){} // RVA: 0x7FFE89F0CFD0
    }

    public class SecP384R1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F0D3A0
        public void AddExt(){} // RVA: 0x7FFE89F0D500
        public void AddOne(){} // RVA: 0x7FFE89F0D720
        public void FromBigInteger(){} // RVA: 0x7FFE89F0D880
        public void Half(){} // RVA: 0x7FFE89F0D9C0
        public void Multiply(){} // RVA: 0x7FFE89F0DB30
        public void Negate(){} // RVA: 0x7FFE89F0DBF0
        public void Reduce(){} // RVA: 0x7FFE89F0DD30
        public void Reduce32(){} // RVA: 0x7FFE89F0E0A0
        public void Square(){} // RVA: 0x7FFE89F0E250
        public void SquareN(){} // RVA: 0x7FFE89F0E300
        public void Subtract(){} // RVA: 0x7FFE89F0E400
        public void SubtractExt(){} // RVA: 0x7FFE89F0E590
        public void Twice(){} // RVA: 0x7FFE89F0E730
        public void AddPInvTo(){} // RVA: 0x7FFE89F0E870
        public void SubPInvFrom(){} // RVA: 0x7FFE89F0E940
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F0EA10
    }

    public class SecP384R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2; // 0x285
        public object field_3; // 0x286

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89F0EF20
        public void get_IsOne(){} // RVA: 0x7FFE89F0EF80
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89F0EFE0
        public void get_FieldName(){} // RVA: 0x7FFE89F0F000
        public void get_FieldSize(){} // RVA: 0x7FFE89F0F040
        public void Add(){} // RVA: 0x7FFE89F0F0B0
        public void AddOne(){} // RVA: 0x7FFE89F0F340
        public void Subtract(){} // RVA: 0x7FFE89F0F580
        public void Multiply(){} // RVA: 0x7FFE89F0F6F0
        public void Divide(){} // RVA: 0x7FFE89F0F860
        public void Negate(){} // RVA: 0x7FFE89F0FA20
        public void Square(){} // RVA: 0x7FFE89F0FB20
        public void Invert(){} // RVA: 0x7FFE89F0FC20
        public void Sqrt(){} // RVA: 0x7FFE89F0FD70
        public void Equals(){} // RVA: 0x7FFE89F102F0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F10360
        public void .cctor(){} // RVA: 0x7FFE89F10460
    }

    public class SecP384R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F10670
        public void Add(){} // RVA: 0x7FFE89F10780
        public void Twice(){} // RVA: 0x7FFE89F11190
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89F11A70
    }

    public class SecP521R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP521R1_DEFAULT_COORDS;
        public int SECP521R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F11B70
        public void CloneCurve(){} // RVA: 0x7FFE89F11FA0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89EDCB20
        public void get_Q(){} // RVA: 0x7FFE89F11FF0
        public void get_Infinity(){} // RVA: 0x7FFE8119C0E0
        public void get_FieldSize(){} // RVA: 0x7FFE89F12050
        public void FromBigInteger(){} // RVA: 0x7FFE89F120C0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F12210 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F122B0
        public void .cctor(){} // RVA: 0x7FFE89F12540
    }

    public class SecP521R1Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F12910
        public void AddOne(){} // RVA: 0x7FFE89F12A90
        public void FromBigInteger(){} // RVA: 0x7FFE89F12C30
        public void Half(){} // RVA: 0x7FFE89F12D00
        public void Multiply(){} // RVA: 0x7FFE89F12D90
        public void Negate(){} // RVA: 0x7FFE89F12F20
        public void Reduce(){} // RVA: 0x7FFE89F13060
        public void Reduce23(){} // RVA: 0x7FFE89F13210
        public void Square(){} // RVA: 0x7FFE89F13350
        public void SquareN(){} // RVA: 0x7FFE89F13490
        public void Subtract(){} // RVA: 0x7FFE89F136C0
        public void Twice(){} // RVA: 0x7FFE89F137A0
        public void ImplMultiply(){} // RVA: 0x7FFE89F13830
        public void ImplSquare(){} // RVA: 0x7FFE89F13940
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F139F0
    }

    public class SecP521R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10
        public object field_2; // 0x28D
        public object field_3; // 0x28E

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFE89F13D40
        public void get_IsOne(){} // RVA: 0x7FFE89F13DA0
        public void TestBitZero(){} // RVA: 0x7FFE89EDF2D0
        public void ToBigInteger(){} // RVA: 0x7FFE89F13E00
        public void get_FieldName(){} // RVA: 0x7FFE89F13E20
        public void get_FieldSize(){} // RVA: 0x7FFE89F13E60
        public void Add(){} // RVA: 0x7FFE89F13ED0
        public void AddOne(){} // RVA: 0x7FFE89F14190
        public void Subtract(){} // RVA: 0x7FFE89F14410
        public void Multiply(){} // RVA: 0x7FFE89F14640
        public void Divide(){} // RVA: 0x7FFE89F147B0
        public void Negate(){} // RVA: 0x7FFE89F14970
        public void Square(){} // RVA: 0x7FFE89F14B90
        public void Invert(){} // RVA: 0x7FFE89F14C90
        public void Sqrt(){} // RVA: 0x7FFE89F14DE0
        public void Equals(){} // RVA: 0x7FFE89F15110 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F15180
        public void .cctor(){} // RVA: 0x7FFE89F15280
    }

    public class SecP521R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F15490
        public void Add(){} // RVA: 0x7FFE89F155A0
        public void Twice(){} // RVA: 0x7FFE89F16340
        public void TwicePlus(){} // RVA: 0x7FFE89EE19C0
        public void ThreeTimes(){} // RVA: 0x7FFE89EE1AC0
        public void Negate(){} // RVA: 0x7FFE89F16E50
    }

    public class SecT113Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F16F50
        public void AddExt(){} // RVA: 0x7FFE89F16FC0
        public void AddOne(){} // RVA: 0x7FFE89F17070
        public void AddTo(){} // RVA: 0x7FFE89F170C0
        public void FromBigInteger(){} // RVA: 0x7FFE89F17110
        public void HalfTrace(){} // RVA: 0x7FFE89F17120
        public void Invert(){} // RVA: 0x7FFE89F173F0
        public void Multiply(){} // RVA: 0x7FFE89F17620
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F176B0
        public void Reduce(){} // RVA: 0x7FFE89F17790
        public void Reduce15(){} // RVA: 0x7FFE89F17870
        public void Sqrt(){} // RVA: 0x7FFE89F178E0
        public void Square(){} // RVA: 0x7FFE89F179B0
        public void SquareAddToExt(){} // RVA: 0x7FFE89F17A60
        public void SquareN(){} // RVA: 0x7FFE89F17B70
        public void Trace(){} // RVA: 0x7FFE89F17D40
        public void ImplMultiply(){} // RVA: 0x7FFE89F17D70
        public void ImplMulw(){} // RVA: 0x7FFE89F17F80
        public void ImplSquare(){} // RVA: 0x7FFE89F181B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SecT113FieldElement : AbstractF2mFieldElement
    {
        public ulong[] x; // 0x10
        public object field_1; // 0x291
        public object field_2; // 0x292
        public object field_3; // 0x293
        public object field_4; // 0x294
        public object field_5; // 0x295
        public object field_6; // 0x296
        public object field_7; // 0x297
        public object field_8; // 0x298
        public object field_9; // 0x299

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFE89F18350
        public void get_IsZero(){} // RVA: 0x7FFE89F183B0
        public void TestBitZero(){} // RVA: 0x7FFE89F183F0
        public void ToBigInteger(){} // RVA: 0x7FFE89F18420
        public void get_FieldName(){} // RVA: 0x7FFE89F18520
        public void get_FieldSize(){} // RVA: 0x7FFE82E556B0
        public void Add(){} // RVA: 0x7FFE89F18560
        public void AddOne(){} // RVA: 0x7FFE89F18710
        public void Subtract(){} // RVA: 0x7FFE85B3A4A0
        public void Multiply(){} // RVA: 0x7FFE89F18830
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE89F18970
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE89F18990
        public void Divide(){} // RVA: 0x7FFE89F18BC0
        public void Negate(){} // RVA: 0x7FFE827C4A80
        public void Square(){} // RVA: 0x7FFE89F18C10
        public void SquareMinusProduct(){} // RVA: 0x7FFE89F18CF0
        public void SquarePlusProduct(){} // RVA: 0x7FFE89F18D10
        public void SquarePow(){} // RVA: 0x7FFE89F18FE0
        public void HalfTrace(){} // RVA: 0x7FFE89F190E0
        public void get_HasFastTrace(){} // RVA: 0x7FFE811E0850
        public void Trace(){} // RVA: 0x7FFE89EDF2D0
        public void Invert(){} // RVA: 0x7FFE89F191C0
        public void Sqrt(){} // RVA: 0x7FFE89F192A0
        public void get_Representation(){} // RVA: 0x7FFE81200CB0
        public void get_M(){} // RVA: 0x7FFE82E556B0
        public void get_K1(){} // RVA: 0x7FFE8249F650
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void Equals(){} // RVA: 0x7FFE89F19560 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F195D0
    }

    public class SecT113R1Curve : AbstractF2mCurve
    {
        public int SECT113R1_DEFAULT_COORDS;
        public int SECT113R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point m_infinity; // 0x58
        public object field_3; // 0x29B
        public object field_4; // 0x29C
        public object field_5; // 0x29D
        public object field_6; // 0x29E
        public object field_7; // 0x29F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F19680
        public void CloneCurve(){} // RVA: 0x7FFE89F19B60
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE82E556B0
        public void FromBigInteger(){} // RVA: 0x7FFE89F19BC0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F19D10 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE82E556B0
        public void get_IsTrinomial(){} // RVA: 0x7FFE811E0850
        public void get_K1(){} // RVA: 0x7FFE8249F650
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F19DB0
    }

    public class SecT113R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F1A470
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F1A720
        public void Twice(){} // RVA: 0x7FFE89F1B110
        public void TwicePlus(){} // RVA: 0x7FFE89F1B5D0
        public void Negate(){} // RVA: 0x7FFE89F1BCC0
    }

    public class SecT113R2Curve : AbstractF2mCurve
    {
        public int SECT113R2_DEFAULT_COORDS;
        public int SECT113R2_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Point m_infinity; // 0x58
        public object field_3; // 0x2A6
        public object field_4; // 0x2A7
        public object field_5; // 0x2A8
        public object field_6; // 0x2A9
        public object field_7; // 0x2AA

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F1BE70
        public void CloneCurve(){} // RVA: 0x7FFE89F1C350
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE82E556B0
        public void FromBigInteger(){} // RVA: 0x7FFE89F1C3A0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F1C4F0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE82E556B0
        public void get_IsTrinomial(){} // RVA: 0x7FFE811E0850
        public void get_K1(){} // RVA: 0x7FFE8249F650
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F1C590
    }

    public class SecT113R2Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F1CC50
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F1CD60
        public void Twice(){} // RVA: 0x7FFE89F1D750
        public void TwicePlus(){} // RVA: 0x7FFE89F1DC10
        public void Negate(){} // RVA: 0x7FFE89F1E300
    }

    public class SecT131Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F1E4B0
        public void AddExt(){} // RVA: 0x7FFE89F1E540
        public void AddOne(){} // RVA: 0x7FFE89F1E620
        public void AddTo(){} // RVA: 0x7FFE89F1E680
        public void FromBigInteger(){} // RVA: 0x7FFE89F1E6F0
        public void HalfTrace(){} // RVA: 0x7FFE89F1E700
        public void Invert(){} // RVA: 0x7FFE89F1E990
        public void Multiply(){} // RVA: 0x7FFE89F1EC00
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F1ECC0
        public void Reduce(){} // RVA: 0x7FFE89F1EDF0
        public void Reduce61(){} // RVA: 0x7FFE89F1EF30
        public void Sqrt(){} // RVA: 0x7FFE89F1EFC0
        public void Square(){} // RVA: 0x7FFE89F1F140
        public void SquareAddToExt(){} // RVA: 0x7FFE89F1F270
        public void SquareN(){} // RVA: 0x7FFE89F1F410
        public void Trace(){} // RVA: 0x7FFE89F1F610
        public void ImplCompactExt(){} // RVA: 0x7FFE89F1F660
        public void ImplMultiply(){} // RVA: 0x7FFE89F1F750
        public void ImplMulw(){} // RVA: 0x7FFE89F1FCD0
        public void ImplSquare(){} // RVA: 0x7FFE89F1FF30
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F1FFD0
    }

    public class SecT131FieldElement : AbstractF2mFieldElement
    {
        public ulong[] x; // 0x10
        public object field_1; // 0x2B1
        public object field_2; // 0x2B2
        public object field_3; // 0x2B3
        public object field_4; // 0x2B4
        public object field_5; // 0x2B5
        public object field_6; // 0x2B6
        public object field_7; // 0x2B7
        public object field_8; // 0x2B8
        public object field_9; // 0x2B9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFE89F20230
        public void get_IsZero(){} // RVA: 0x7FFE89F20290
        public void TestBitZero(){} // RVA: 0x7FFE89F183F0
        public void ToBigInteger(){} // RVA: 0x7FFE89F202D0
        public void get_FieldName(){} // RVA: 0x7FFE89F202E0
        public void get_FieldSize(){} // RVA: 0x7FFE89F20320
        public void Add(){} // RVA: 0x7FFE89F20330
        public void AddOne(){} // RVA: 0x7FFE89F20530
        public void Subtract(){} // RVA: 0x7FFE85B3A4A0
        public void Multiply(){} // RVA: 0x7FFE89F206A0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE89F18970
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE89F20810
        public void Divide(){} // RVA: 0x7FFE89F18BC0
        public void Negate(){} // RVA: 0x7FFE827C4A80
        public void Square(){} // RVA: 0x7FFE89F20A60
        public void SquareMinusProduct(){} // RVA: 0x7FFE89F18CF0
        public void SquarePlusProduct(){} // RVA: 0x7FFE89F20B60
        public void SquarePow(){} // RVA: 0x7FFE89F20D70
        public void HalfTrace(){} // RVA: 0x7FFE89F20EA0
        public void get_HasFastTrace(){} // RVA: 0x7FFE811E0850
        public void Trace(){} // RVA: 0x7FFE89F20FA0
        public void Invert(){} // RVA: 0x7FFE89F21030
        public void Sqrt(){} // RVA: 0x7FFE89F21130
        public void get_Representation(){} // RVA: 0x7FFE817BF630
        public void get_M(){} // RVA: 0x7FFE89F20320
        public void get_K1(){} // RVA: 0x7FFE81200CB0
        public void get_K2(){} // RVA: 0x7FFE817BF630
        public void get_K3(){} // RVA: 0x7FFE82199910
        public void Equals(){} // RVA: 0x7FFE89F214D0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F21540
    }

    public class SecT131R1Curve : AbstractF2mCurve
    {
        public int SECT131R1_DEFAULT_COORDS;
        public int SECT131R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Point m_infinity; // 0x58
        public object field_3; // 0x2BB
        public object field_4; // 0x2BC
        public object field_5; // 0x2BD
        public object field_6; // 0x2BE
        public object field_7; // 0x2BF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F215F0
        public void CloneCurve(){} // RVA: 0x7FFE89F21AF0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F20320
        public void FromBigInteger(){} // RVA: 0x7FFE89F21B40
        public void CreateRawPoint(){} // RVA: 0x7FFE89F21C90 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE89F20320
        public void get_IsTrinomial(){} // RVA: 0x7FFE810FB320
        public void get_K1(){} // RVA: 0x7FFE81200CB0
        public void get_K2(){} // RVA: 0x7FFE817BF630
        public void get_K3(){} // RVA: 0x7FFE82199910
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F21D30
    }

    public class SecT131R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F22440
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F22550
        public void Twice(){} // RVA: 0x7FFE89F22F40
        public void TwicePlus(){} // RVA: 0x7FFE89F23400
        public void Negate(){} // RVA: 0x7FFE89F23AF0
    }

    public class SecT131R2Curve : AbstractF2mCurve
    {
        public int SECT131R2_DEFAULT_COORDS;
        public int SECT131R2_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point m_infinity; // 0x58
        public object field_3; // 0x2C6
        public object field_4; // 0x2C7
        public object field_5; // 0x2C8
        public object field_6; // 0x2C9
        public object field_7; // 0x2CA

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F23CA0
        public void CloneCurve(){} // RVA: 0x7FFE89F241A0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_FieldSize(){} // RVA: 0x7FFE89F20320
        public void FromBigInteger(){} // RVA: 0x7FFE89F241F0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F24340 | overloaded x2
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE89F20320
        public void get_IsTrinomial(){} // RVA: 0x7FFE810FB320
        public void get_K1(){} // RVA: 0x7FFE81200CB0
        public void get_K2(){} // RVA: 0x7FFE817BF630
        public void get_K3(){} // RVA: 0x7FFE82199910
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F243E0
    }

    public class SecT131R2Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F24AF0
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F24C00
        public void Twice(){} // RVA: 0x7FFE89F255F0
        public void TwicePlus(){} // RVA: 0x7FFE89F25AB0
        public void Negate(){} // RVA: 0x7FFE89F261A0
    }

    public class SecT163Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F1E4B0
        public void AddExt(){} // RVA: 0x7FFE89F26350
        public void AddOne(){} // RVA: 0x7FFE89F1E620
        public void AddTo(){} // RVA: 0x7FFE89F1E680
        public void FromBigInteger(){} // RVA: 0x7FFE89F26460
        public void HalfTrace(){} // RVA: 0x7FFE89F26470
        public void Invert(){} // RVA: 0x7FFE89F266B0
        public void Multiply(){} // RVA: 0x7FFE89F26950
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F26A10
        public void Reduce(){} // RVA: 0x7FFE89F26AD0
        public void Reduce29(){} // RVA: 0x7FFE89F26C60
        public void Sqrt(){} // RVA: 0x7FFE89F26CE0
        public void Square(){} // RVA: 0x7FFE89F26E60
        public void SquareAddToExt(){} // RVA: 0x7FFE89F26F60
        public void SquareN(){} // RVA: 0x7FFE89F27060
        public void Trace(){} // RVA: 0x7FFE89F27200
        public void ImplCompactExt(){} // RVA: 0x7FFE89F27240
        public void ImplMultiply(){} // RVA: 0x7FFE89F27330
        public void ImplMulw(){} // RVA: 0x7FFE89F278B0
        public void ImplSquare(){} // RVA: 0x7FFE89F27AB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F27B30
    }

    public class SecT163FieldElement : AbstractF2mFieldElement
    {
        public ulong[] x; // 0x10
        public object field_1; // 0x2D1
        public object field_2; // 0x2D2
        public object field_3; // 0x2D3
        public object field_4; // 0x2D4
        public object field_5; // 0x2D5
        public object field_6; // 0x2D6
        public object field_7; // 0x2D7
        public object field_8; // 0x2D8
        public object field_9; // 0x2D9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFE89F20230
        public void get_IsZero(){} // RVA: 0x7FFE89F20290
        public void TestBitZero(){} // RVA: 0x7FFE89F183F0
        public void ToBigInteger(){} // RVA: 0x7FFE89F202D0
        public void get_FieldName(){} // RVA: 0x7FFE89F27D00
        public void get_FieldSize(){} // RVA: 0x7FFE82E55D10
        public void Add(){} // RVA: 0x7FFE89F27D40
        public void AddOne(){} // RVA: 0x7FFE89F27F40
        public void Subtract(){} // RVA: 0x7FFE85B3A4A0
        public void Multiply(){} // RVA: 0x7FFE89F280B0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE89F18970
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE89F28220
        public void Divide(){} // RVA: 0x7FFE89F18BC0
        public void Negate(){} // RVA: 0x7FFE827C4A80
        public void Square(){} // RVA: 0x7FFE89F28470
        public void SquareMinusProduct(){} // RVA: 0x7FFE89F18CF0
        public void SquarePlusProduct(){} // RVA: 0x7FFE89F28570
        public void SquarePow(){} // RVA: 0x7FFE89F28850
        public void HalfTrace(){} // RVA: 0x7FFE89F28980
        public void get_HasFastTrace(){} // RVA: 0x7FFE811E0850
        public void Trace(){} // RVA: 0x7FFE89F28A80
        public void Invert(){} // RVA: 0x7FFE89F28B00
        public void Sqrt(){} // RVA: 0x7FFE89F28C00
        public void get_Representation(){} // RVA: 0x7FFE817BF630
        public void get_M(){} // RVA: 0x7FFE82E55D10
        public void get_K1(){} // RVA: 0x7FFE817BF630
        public void get_K2(){} // RVA: 0x7FFE81815210
        public void get_K3(){} // RVA: 0x7FFE817F39D0
        public void Equals(){} // RVA: 0x7FFE89F214D0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F28FA0
    }

    public class SecT163K1Curve : AbstractF2mCurve
    {
        public int SECT163K1_DEFAULT_COORDS;
        public int SECT163K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point m_infinity; // 0x58
        public object field_3; // 0x2DB
        public object field_4; // 0x2DC
        public object field_5; // 0x2DD
        public object field_6; // 0x2DE
        public object field_7; // 0x2DF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F29050
        public void CloneCurve(){} // RVA: 0x7FFE89F294B0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFE89F29500
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE82E55D10
        public void FromBigInteger(){} // RVA: 0x7FFE89F29540
        public void CreateRawPoint(){} // RVA: 0x7FFE89F29690 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE811E0850
        public void get_M(){} // RVA: 0x7FFE82E55D10
        public void get_IsTrinomial(){} // RVA: 0x7FFE810FB320
        public void get_K1(){} // RVA: 0x7FFE817BF630
        public void get_K2(){} // RVA: 0x7FFE81815210
        public void get_K3(){} // RVA: 0x7FFE817F39D0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F29730
    }

    public class SecT163K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F29E40
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F29F50
        public void Twice(){} // RVA: 0x7FFE89F2A8F0
        public void TwicePlus(){} // RVA: 0x7FFE89F2AD60
        public void Negate(){} // RVA: 0x7FFE89F2B3D0
    }

    public class SecT163R1Curve : AbstractF2mCurve
    {
        public int SECT163R1_DEFAULT_COORDS;
        public int SECT163R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Point m_infinity; // 0x58
        public object field_3; // 0x2E6
        public object field_4; // 0x2E7
        public object field_5; // 0x2E8
        public object field_6; // 0x2E9
        public object field_7; // 0x2EA

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F2B580
        public void CloneCurve(){} // RVA: 0x7FFE89F2BA80
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE82E55D10
        public void FromBigInteger(){} // RVA: 0x7FFE89F2BAD0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F2BC20 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE82E55D10
        public void get_IsTrinomial(){} // RVA: 0x7FFE810FB320
        public void get_K1(){} // RVA: 0x7FFE817BF630
        public void get_K2(){} // RVA: 0x7FFE81815210
        public void get_K3(){} // RVA: 0x7FFE817F39D0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F2BCC0
    }

    public class SecT163R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F2C3D0
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F2C4E0
        public void Twice(){} // RVA: 0x7FFE89F2CED0
        public void TwicePlus(){} // RVA: 0x7FFE89F2D390
        public void Negate(){} // RVA: 0x7FFE89F2DA80
    }

    public class SecT163R2Curve : AbstractF2mCurve
    {
        public int SECT163R2_DEFAULT_COORDS;
        public int SECT163R2_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Point m_infinity; // 0x58
        public object field_3; // 0x2F1
        public object field_4; // 0x2F2
        public object field_5; // 0x2F3
        public object field_6; // 0x2F4
        public object field_7; // 0x2F5

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F2DC30
        public void CloneCurve(){} // RVA: 0x7FFE89F2E0E0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE82E55D10
        public void FromBigInteger(){} // RVA: 0x7FFE89F2E130
        public void CreateRawPoint(){} // RVA: 0x7FFE89F2E280 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE82E55D10
        public void get_IsTrinomial(){} // RVA: 0x7FFE810FB320
        public void get_K1(){} // RVA: 0x7FFE817BF630
        public void get_K2(){} // RVA: 0x7FFE81815210
        public void get_K3(){} // RVA: 0x7FFE817F39D0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F2E320
    }

    public class SecT163R2Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F2EA30
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F2EB40
        public void Twice(){} // RVA: 0x7FFE89F2F520
        public void TwicePlus(){} // RVA: 0x7FFE89F2F9A0
        public void Negate(){} // RVA: 0x7FFE89F30030
    }

    public class SecT193Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F16FC0
        public void AddExt(){} // RVA: 0x7FFE89F301E0
        public void AddOne(){} // RVA: 0x7FFE89F30320
        public void AddTo(){} // RVA: 0x7FFE89F303A0
        public void FromBigInteger(){} // RVA: 0x7FFE89F30420
        public void HalfTrace(){} // RVA: 0x7FFE89F30430
        public void Invert(){} // RVA: 0x7FFE89F306A0
        public void Multiply(){} // RVA: 0x7FFE89F308E0
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F30970
        public void Reduce(){} // RVA: 0x7FFE89F30A00
        public void Reduce63(){} // RVA: 0x7FFE89F30B60
        public void Sqrt(){} // RVA: 0x7FFE89F30BE0
        public void Square(){} // RVA: 0x7FFE89F30D30
        public void SquareAddToExt(){} // RVA: 0x7FFE89F30E20
        public void SquareN(){} // RVA: 0x7FFE89F30F10
        public void Trace(){} // RVA: 0x7FFE89F17D40
        public void ImplCompactExt(){} // RVA: 0x7FFE89F310B0
        public void ImplExpand(){} // RVA: 0x7FFE89F31210
        public void ImplMultiply(){} // RVA: 0x7FFE89F312D0
        public void ImplMulwAcc(){} // RVA: 0x7FFE89F31910
        public void ImplSquare(){} // RVA: 0x7FFE89F31B80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SecT193FieldElement : AbstractF2mFieldElement
    {
        public ulong[] x; // 0x10
        public object field_1; // 0x2FC
        public object field_2; // 0x2FD
        public object field_3; // 0x2FE
        public object field_4; // 0x2FF
        public object field_5; // 0x300
        public object field_6; // 0x301
        public object field_7; // 0x302
        public object field_8; // 0x303
        public object field_9; // 0x304

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFE89F31D60
        public void get_IsZero(){} // RVA: 0x7FFE89F31DC0
        public void TestBitZero(){} // RVA: 0x7FFE89F183F0
        public void ToBigInteger(){} // RVA: 0x7FFE89F31E00
        public void get_FieldName(){} // RVA: 0x7FFE89F31E10
        public void get_FieldSize(){} // RVA: 0x7FFE89F31E50
        public void Add(){} // RVA: 0x7FFE89F31E60
        public void AddOne(){} // RVA: 0x7FFE89F32060
        public void Subtract(){} // RVA: 0x7FFE85B3A4A0
        public void Multiply(){} // RVA: 0x7FFE89F321C0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE89F18970
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE89F32300
        public void Divide(){} // RVA: 0x7FFE89F18BC0
        public void Negate(){} // RVA: 0x7FFE827C4A80
        public void Square(){} // RVA: 0x7FFE89F32530
        public void SquareMinusProduct(){} // RVA: 0x7FFE89F18CF0
        public void SquarePlusProduct(){} // RVA: 0x7FFE89F32610
        public void SquarePow(){} // RVA: 0x7FFE89F328C0
        public void HalfTrace(){} // RVA: 0x7FFE89F329C0
        public void get_HasFastTrace(){} // RVA: 0x7FFE811E0850
        public void Trace(){} // RVA: 0x7FFE89EDF2D0
        public void Invert(){} // RVA: 0x7FFE89F32AA0
        public void Sqrt(){} // RVA: 0x7FFE89F32B80
        public void get_Representation(){} // RVA: 0x7FFE81200CB0
        public void get_M(){} // RVA: 0x7FFE89F31E50
        public void get_K1(){} // RVA: 0x7FFE82127E50
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void Equals(){} // RVA: 0x7FFE89F32EC0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F32F30
    }

    public class SecT193R1Curve : AbstractF2mCurve
    {
        public int SECT193R1_DEFAULT_COORDS;
        public int SECT193R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point m_infinity; // 0x58
        public object field_3; // 0x306
        public object field_4; // 0x307
        public object field_5; // 0x308
        public object field_6; // 0x309
        public object field_7; // 0x30A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F32FE0
        public void CloneCurve(){} // RVA: 0x7FFE89F334C0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F31E50
        public void FromBigInteger(){} // RVA: 0x7FFE89F33510
        public void CreateRawPoint(){} // RVA: 0x7FFE89F33660 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE89F31E50
        public void get_IsTrinomial(){} // RVA: 0x7FFE811E0850
        public void get_K1(){} // RVA: 0x7FFE82127E50
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F33700
    }

    public class SecT193R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F33E50
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F33F60
        public void Twice(){} // RVA: 0x7FFE89F34950
        public void TwicePlus(){} // RVA: 0x7FFE89F34E10
        public void Negate(){} // RVA: 0x7FFE89F35500
    }

    public class SecT193R2Curve : AbstractF2mCurve
    {
        public int SECT193R2_DEFAULT_COORDS;
        public int SECT193R2_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point m_infinity; // 0x58
        public object field_3; // 0x311
        public object field_4; // 0x312
        public object field_5; // 0x313
        public object field_6; // 0x314
        public object field_7; // 0x315

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F356B0
        public void CloneCurve(){} // RVA: 0x7FFE89F35B90
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F31E50
        public void FromBigInteger(){} // RVA: 0x7FFE89F35BE0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F35D30 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE89F31E50
        public void get_IsTrinomial(){} // RVA: 0x7FFE811E0850
        public void get_K1(){} // RVA: 0x7FFE82127E50
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F35DD0
    }

    public class SecT193R2Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F36520
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F36630
        public void Twice(){} // RVA: 0x7FFE89F37020
        public void TwicePlus(){} // RVA: 0x7FFE89F374E0
        public void Negate(){} // RVA: 0x7FFE89F37BD0
    }

    public class SecT233Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F16FC0
        public void AddExt(){} // RVA: 0x7FFE89F37D80
        public void AddOne(){} // RVA: 0x7FFE89F30320
        public void AddTo(){} // RVA: 0x7FFE89F303A0
        public void FromBigInteger(){} // RVA: 0x7FFE89F37EE0
        public void HalfTrace(){} // RVA: 0x7FFE89F37EF0
        public void Invert(){} // RVA: 0x7FFE89F38160
        public void Multiply(){} // RVA: 0x7FFE89F383D0
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F38460
        public void Reduce(){} // RVA: 0x7FFE89F384F0
        public void Reduce23(){} // RVA: 0x7FFE89F38690
        public void Sqrt(){} // RVA: 0x7FFE89F38710
        public void Square(){} // RVA: 0x7FFE89F389C0
        public void SquareAddToExt(){} // RVA: 0x7FFE89F38AB0
        public void SquareN(){} // RVA: 0x7FFE89F38BA0
        public void Trace(){} // RVA: 0x7FFE89F38D50
        public void ImplCompactExt(){} // RVA: 0x7FFE89F38D90
        public void ImplExpand(){} // RVA: 0x7FFE89F38EE0
        public void ImplMultiply(){} // RVA: 0x7FFE89F38FA0
        public void ImplMulwAcc(){} // RVA: 0x7FFE89F395E0
        public void ImplSquare(){} // RVA: 0x7FFE89F397D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SecT233FieldElement : AbstractF2mFieldElement
    {
        public ulong[] x; // 0x10
        public object field_1; // 0x31C
        public object field_2; // 0x31D
        public object field_3; // 0x31E
        public object field_4; // 0x31F
        public object field_5; // 0x320
        public object field_6; // 0x321
        public object field_7; // 0x322
        public object field_8; // 0x323
        public object field_9; // 0x324

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFE89F31D60
        public void get_IsZero(){} // RVA: 0x7FFE89F31DC0
        public void TestBitZero(){} // RVA: 0x7FFE89F183F0
        public void ToBigInteger(){} // RVA: 0x7FFE89F31E00
        public void get_FieldName(){} // RVA: 0x7FFE89F39920
        public void get_FieldSize(){} // RVA: 0x7FFE89F39960
        public void Add(){} // RVA: 0x7FFE89F39970
        public void AddOne(){} // RVA: 0x7FFE89F39B70
        public void Subtract(){} // RVA: 0x7FFE85B3A4A0
        public void Multiply(){} // RVA: 0x7FFE89F39CD0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE89F18970
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE89F39E10
        public void Divide(){} // RVA: 0x7FFE89F18BC0
        public void Negate(){} // RVA: 0x7FFE827C4A80
        public void Square(){} // RVA: 0x7FFE89F3A040
        public void SquareMinusProduct(){} // RVA: 0x7FFE89F18CF0
        public void SquarePlusProduct(){} // RVA: 0x7FFE89F3A120
        public void SquarePow(){} // RVA: 0x7FFE89F3A3C0
        public void HalfTrace(){} // RVA: 0x7FFE89F3A4C0
        public void get_HasFastTrace(){} // RVA: 0x7FFE811E0850
        public void Trace(){} // RVA: 0x7FFE89F3A5A0
        public void Invert(){} // RVA: 0x7FFE89F3A5E0
        public void Sqrt(){} // RVA: 0x7FFE89F3A6C0
        public void get_Representation(){} // RVA: 0x7FFE81200CB0
        public void get_M(){} // RVA: 0x7FFE89F39960
        public void get_K1(){} // RVA: 0x7FFE89F3A7A0
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void Equals(){} // RVA: 0x7FFE89F32EC0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F3A8F0
    }

    public class SecT233K1Curve : AbstractF2mCurve
    {
        public int SECT233K1_DEFAULT_COORDS;
        public int SECT233K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point m_infinity; // 0x58
        public object field_3; // 0x326
        public object field_4; // 0x327
        public object field_5; // 0x328
        public object field_6; // 0x329
        public object field_7; // 0x32A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F3A9A0
        public void CloneCurve(){} // RVA: 0x7FFE89F3ADE0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFE89F3AE30
        public void get_FieldSize(){} // RVA: 0x7FFE89F39960
        public void FromBigInteger(){} // RVA: 0x7FFE89F3AE70
        public void CreateRawPoint(){} // RVA: 0x7FFE89F3AFC0 | overloaded x2
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_IsKoblitz(){} // RVA: 0x7FFE811E0850
        public void get_M(){} // RVA: 0x7FFE89F39960
        public void get_IsTrinomial(){} // RVA: 0x7FFE811E0850
        public void get_K1(){} // RVA: 0x7FFE89F3A7A0
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F3B060
    }

    public class SecT233K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F3B7B0
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F3B8C0
        public void Twice(){} // RVA: 0x7FFE89F3C240
        public void TwicePlus(){} // RVA: 0x7FFE89F3C740
        public void Negate(){} // RVA: 0x7FFE89F3CD80
    }

    public class SecT233R1Curve : AbstractF2mCurve
    {
        public int SECT233R1_DEFAULT_COORDS;
        public int SECT233R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Point m_infinity; // 0x58
        public object field_3; // 0x331
        public object field_4; // 0x332
        public object field_5; // 0x333
        public object field_6; // 0x334
        public object field_7; // 0x335

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F3CF30
        public void CloneCurve(){} // RVA: 0x7FFE89F3D3C0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F39960
        public void FromBigInteger(){} // RVA: 0x7FFE89F3D410
        public void CreateRawPoint(){} // RVA: 0x7FFE89F3D560 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE89F39960
        public void get_IsTrinomial(){} // RVA: 0x7FFE811E0850
        public void get_K1(){} // RVA: 0x7FFE89F3A7A0
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F3D600
    }

    public class SecT233R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F3DD50
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F3DE60
        public void Twice(){} // RVA: 0x7FFE89F3E840
        public void TwicePlus(){} // RVA: 0x7FFE89F3ECC0
        public void Negate(){} // RVA: 0x7FFE89F3F350
    }

    public class SecT239Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F16FC0
        public void AddExt(){} // RVA: 0x7FFE89F37D80
        public void AddOne(){} // RVA: 0x7FFE89F30320
        public void AddTo(){} // RVA: 0x7FFE89F303A0
        public void FromBigInteger(){} // RVA: 0x7FFE89F3F500
        public void HalfTrace(){} // RVA: 0x7FFE89F3F510
        public void Invert(){} // RVA: 0x7FFE89F3F780
        public void Multiply(){} // RVA: 0x7FFE89F3FA30
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F3FAC0
        public void Reduce(){} // RVA: 0x7FFE89F3FB50
        public void Reduce17(){} // RVA: 0x7FFE89F3FCF0
        public void Sqrt(){} // RVA: 0x7FFE89F3FD70
        public void Square(){} // RVA: 0x7FFE89F40060
        public void SquareAddToExt(){} // RVA: 0x7FFE89F38AB0
        public void SquareN(){} // RVA: 0x7FFE89F40150
        public void Trace(){} // RVA: 0x7FFE89F40300
        public void ImplCompactExt(){} // RVA: 0x7FFE89F40350
        public void ImplExpand(){} // RVA: 0x7FFE89F404A0
        public void ImplMultiply(){} // RVA: 0x7FFE89F40560
        public void ImplMulwAcc(){} // RVA: 0x7FFE89F40BA0
        public void ImplSquare(){} // RVA: 0x7FFE89F397D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SecT239FieldElement : AbstractF2mFieldElement
    {
        public ulong[] x; // 0x10
        public object field_1; // 0x33C
        public object field_2; // 0x33D
        public object field_3; // 0x33E
        public object field_4; // 0x33F
        public object field_5; // 0x340
        public object field_6; // 0x341
        public object field_7; // 0x342
        public object field_8; // 0x343
        public object field_9; // 0x344

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFE89F31D60
        public void get_IsZero(){} // RVA: 0x7FFE89F31DC0
        public void TestBitZero(){} // RVA: 0x7FFE89F183F0
        public void ToBigInteger(){} // RVA: 0x7FFE89F31E00
        public void get_FieldName(){} // RVA: 0x7FFE89F40E80
        public void get_FieldSize(){} // RVA: 0x7FFE89F40EC0
        public void Add(){} // RVA: 0x7FFE89F40ED0
        public void AddOne(){} // RVA: 0x7FFE89F410D0
        public void Subtract(){} // RVA: 0x7FFE85B3A4A0
        public void Multiply(){} // RVA: 0x7FFE89F41230
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE89F18970
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE89F41370
        public void Divide(){} // RVA: 0x7FFE89F18BC0
        public void Negate(){} // RVA: 0x7FFE827C4A80
        public void Square(){} // RVA: 0x7FFE89F415A0
        public void SquareMinusProduct(){} // RVA: 0x7FFE89F18CF0
        public void SquarePlusProduct(){} // RVA: 0x7FFE89F41680
        public void SquarePow(){} // RVA: 0x7FFE89F41920
        public void HalfTrace(){} // RVA: 0x7FFE89F41A20
        public void get_HasFastTrace(){} // RVA: 0x7FFE811E0850
        public void Trace(){} // RVA: 0x7FFE89F41B00
        public void Invert(){} // RVA: 0x7FFE89F41B50
        public void Sqrt(){} // RVA: 0x7FFE89F41C30
        public void get_Representation(){} // RVA: 0x7FFE81200CB0
        public void get_M(){} // RVA: 0x7FFE89F40EC0
        public void get_K1(){} // RVA: 0x7FFE89F41D10
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void Equals(){} // RVA: 0x7FFE89F32EC0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F41E60
    }

    public class SecT239K1Curve : AbstractF2mCurve
    {
        public int SECT239K1_DEFAULT_COORDS;
        public int SECT239K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point m_infinity; // 0x58
        public object field_3; // 0x346
        public object field_4; // 0x347
        public object field_5; // 0x348
        public object field_6; // 0x349
        public object field_7; // 0x34A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F41F10
        public void CloneCurve(){} // RVA: 0x7FFE89F42350
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFE89F423A0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F40EC0
        public void FromBigInteger(){} // RVA: 0x7FFE89F423E0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F425B0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE811E0850
        public void get_M(){} // RVA: 0x7FFE89F40EC0
        public void get_IsTrinomial(){} // RVA: 0x7FFE811E0850
        public void get_K1(){} // RVA: 0x7FFE89F41D10
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F42650
    }

    public class SecT239K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F42DA0
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F42EB0
        public void Twice(){} // RVA: 0x7FFE89F43830
        public void TwicePlus(){} // RVA: 0x7FFE89F43D30
        public void Negate(){} // RVA: 0x7FFE89F44370
    }

    public class SecT283Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F1E540
        public void AddExt(){} // RVA: 0x7FFE89F44520
        public void AddOne(){} // RVA: 0x7FFE89F446B0
        public void AddTo(){} // RVA: 0x7FFE89F44740
        public void FromBigInteger(){} // RVA: 0x7FFE89F447E0
        public void HalfTrace(){} // RVA: 0x7FFE89F447F0
        public void Invert(){} // RVA: 0x7FFE89F44A00
        public void Multiply(){} // RVA: 0x7FFE89F44CD0
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F44D90
        public void Reduce(){} // RVA: 0x7FFE89F44E50
        public void Reduce37(){} // RVA: 0x7FFE89F45080
        public void Sqrt(){} // RVA: 0x7FFE89F45100
        public void Square(){} // RVA: 0x7FFE89F452F0
        public void SquareAddToExt(){} // RVA: 0x7FFE89F453A0
        public void SquareN(){} // RVA: 0x7FFE89F45450
        public void Trace(){} // RVA: 0x7FFE89F45550
        public void ImplCompactExt(){} // RVA: 0x7FFE89F45590
        public void ImplExpand(){} // RVA: 0x7FFE89F45750
        public void ImplMultiply(){} // RVA: 0x7FFE89F45850
        public void ImplMulw(){} // RVA: 0x7FFE89F45F20
        public void ImplSquare(){} // RVA: 0x7FFE89F46150
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F46290
    }

    public class SecT283FieldElement : AbstractF2mFieldElement
    {
        public ulong[] x; // 0x10
        public object field_1; // 0x351
        public object field_2; // 0x352
        public object field_3; // 0x353
        public object field_4; // 0x354
        public object field_5; // 0x355
        public object field_6; // 0x356
        public object field_7; // 0x357
        public object field_8; // 0x358
        public object field_9; // 0x359

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFE89F464F0
        public void get_IsZero(){} // RVA: 0x7FFE89F46550
        public void TestBitZero(){} // RVA: 0x7FFE89F183F0
        public void ToBigInteger(){} // RVA: 0x7FFE89F46590
        public void get_FieldName(){} // RVA: 0x7FFE89F46690
        public void get_FieldSize(){} // RVA: 0x7FFE89F466D0
        public void Add(){} // RVA: 0x7FFE89F466E0
        public void AddOne(){} // RVA: 0x7FFE89F46930
        public void Subtract(){} // RVA: 0x7FFE85B3A4A0
        public void Multiply(){} // RVA: 0x7FFE89F46AD0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE89F18970
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE89F46C40
        public void Divide(){} // RVA: 0x7FFE89F18BC0
        public void Negate(){} // RVA: 0x7FFE827C4A80
        public void Square(){} // RVA: 0x7FFE89F46E90
        public void SquareMinusProduct(){} // RVA: 0x7FFE89F18CF0
        public void SquarePlusProduct(){} // RVA: 0x7FFE89F46F90
        public void SquarePow(){} // RVA: 0x7FFE89F47210
        public void HalfTrace(){} // RVA: 0x7FFE89F47340
        public void get_HasFastTrace(){} // RVA: 0x7FFE811E0850
        public void Trace(){} // RVA: 0x7FFE89F47440
        public void Invert(){} // RVA: 0x7FFE89F474C0
        public void Sqrt(){} // RVA: 0x7FFE89F475C0
        public void get_Representation(){} // RVA: 0x7FFE817BF630
        public void get_M(){} // RVA: 0x7FFE89F466D0
        public void get_K1(){} // RVA: 0x7FFE81474A10
        public void get_K2(){} // RVA: 0x7FFE817F39D0
        public void get_K3(){} // RVA: 0x7FFE835C1DE0
        public void Equals(){} // RVA: 0x7FFE89F47800 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F47870
    }

    public class SecT283K1Curve : AbstractF2mCurve
    {
        public int SECT283K1_DEFAULT_COORDS;
        public int SECT283K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point m_infinity; // 0x58
        public object field_3; // 0x35B
        public object field_4; // 0x35C
        public object field_5; // 0x35D
        public object field_6; // 0x35E
        public object field_7; // 0x35F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F47920
        public void CloneCurve(){} // RVA: 0x7FFE89F47D80
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFE89F47DD0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F466D0
        public void FromBigInteger(){} // RVA: 0x7FFE89F47E10
        public void CreateRawPoint(){} // RVA: 0x7FFE89F47F60 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE811E0850
        public void get_M(){} // RVA: 0x7FFE89F466D0
        public void get_IsTrinomial(){} // RVA: 0x7FFE810FB320
        public void get_K1(){} // RVA: 0x7FFE81474A10
        public void get_K2(){} // RVA: 0x7FFE817F39D0
        public void get_K3(){} // RVA: 0x7FFE835C1DE0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F48000
    }

    public class SecT283K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F487A0
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F488B0
        public void Twice(){} // RVA: 0x7FFE89F49230
        public void TwicePlus(){} // RVA: 0x7FFE89F49730
        public void Negate(){} // RVA: 0x7FFE89F49D70
    }

    public class SecT283R1Curve : AbstractF2mCurve
    {
        public int SECT283R1_DEFAULT_COORDS;
        public int SECT283R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Point m_infinity; // 0x58
        public object field_3; // 0x366
        public object field_4; // 0x367
        public object field_5; // 0x368
        public object field_6; // 0x369
        public object field_7; // 0x36A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F49F20
        public void CloneCurve(){} // RVA: 0x7FFE89F4A3D0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F466D0
        public void FromBigInteger(){} // RVA: 0x7FFE89F4A420
        public void CreateRawPoint(){} // RVA: 0x7FFE89F4A570 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE89F466D0
        public void get_IsTrinomial(){} // RVA: 0x7FFE810FB320
        public void get_K1(){} // RVA: 0x7FFE81474A10
        public void get_K2(){} // RVA: 0x7FFE817F39D0
        public void get_K3(){} // RVA: 0x7FFE835C1DE0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F4A610
    }

    public class SecT283R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F4ADB0
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F4AEC0
        public void Twice(){} // RVA: 0x7FFE89F4B8A0
        public void TwicePlus(){} // RVA: 0x7FFE89F4BD20
        public void Negate(){} // RVA: 0x7FFE89F4C3B0
    }

    public class SecT409Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F301E0
        public void AddExt(){} // RVA: 0x7FFE89F4C560
        public void AddOne(){} // RVA: 0x7FFE89F4C5D0
        public void AddTo(){} // RVA: 0x7FFE89F4C690
        public void FromBigInteger(){} // RVA: 0x7FFE89F4C770
        public void HalfTrace(){} // RVA: 0x7FFE89F4C780
        public void Invert(){} // RVA: 0x7FFE89F4C9C0
        public void Multiply(){} // RVA: 0x7FFE89F4CC80
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F4CD10
        public void Reduce(){} // RVA: 0x7FFE89F4CDD0
        public void Reduce39(){} // RVA: 0x7FFE89F4D000
        public void Sqrt(){} // RVA: 0x7FFE89F4D070
        public void Square(){} // RVA: 0x7FFE89F4D2B0
        public void SquareAddToExt(){} // RVA: 0x7FFE89F4D330
        public void SquareN(){} // RVA: 0x7FFE89F4D3E0
        public void Trace(){} // RVA: 0x7FFE89F17D40
        public void ImplCompactExt(){} // RVA: 0x7FFE89F4D4A0
        public void ImplExpand(){} // RVA: 0x7FFE89F4D740
        public void ImplMultiply(){} // RVA: 0x7FFE89F4D8B0
        public void ImplMulwAcc(){} // RVA: 0x7FFE89F4D9B0
        public void ImplSquare(){} // RVA: 0x7FFE89F4DC10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SecT409FieldElement : AbstractF2mFieldElement
    {
        public ulong[] x; // 0x10
        public object field_1; // 0x371
        public object field_2; // 0x372
        public object field_3; // 0x373
        public object field_4; // 0x374
        public object field_5; // 0x375
        public object field_6; // 0x376
        public object field_7; // 0x377
        public object field_8; // 0x378
        public object field_9; // 0x379

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFE89F4DED0
        public void get_IsZero(){} // RVA: 0x7FFE89F4DF30
        public void TestBitZero(){} // RVA: 0x7FFE89F183F0
        public void ToBigInteger(){} // RVA: 0x7FFE89F4DF70
        public void get_FieldName(){} // RVA: 0x7FFE89F4E070
        public void get_FieldSize(){} // RVA: 0x7FFE89F4E0B0
        public void Add(){} // RVA: 0x7FFE89F4E0C0
        public void AddOne(){} // RVA: 0x7FFE89F4E340
        public void Subtract(){} // RVA: 0x7FFE85B3A4A0
        public void Multiply(){} // RVA: 0x7FFE89F4E4F0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE89F18970
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE89F4E630
        public void Divide(){} // RVA: 0x7FFE89F18BC0
        public void Negate(){} // RVA: 0x7FFE827C4A80
        public void Square(){} // RVA: 0x7FFE89F4E860
        public void SquareMinusProduct(){} // RVA: 0x7FFE89F18CF0
        public void SquarePlusProduct(){} // RVA: 0x7FFE89F4E940
        public void SquarePow(){} // RVA: 0x7FFE89F4EBB0
        public void HalfTrace(){} // RVA: 0x7FFE89F4ECB0
        public void get_HasFastTrace(){} // RVA: 0x7FFE811E0850
        public void Trace(){} // RVA: 0x7FFE89EDF2D0
        public void Invert(){} // RVA: 0x7FFE89F4ED90
        public void Sqrt(){} // RVA: 0x7FFE89F4EE70
        public void get_Representation(){} // RVA: 0x7FFE81200CB0
        public void get_M(){} // RVA: 0x7FFE89F4E0B0
        public void get_K1(){} // RVA: 0x7FFE89F4EF50
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void Equals(){} // RVA: 0x7FFE89F4F0A0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F4F110
    }

    public class SecT409K1Curve : AbstractF2mCurve
    {
        public int SECT409K1_DEFAULT_COORDS;
        public int SECT409K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Point m_infinity; // 0x58
        public object field_3; // 0x37B
        public object field_4; // 0x37C
        public object field_5; // 0x37D
        public object field_6; // 0x37E
        public object field_7; // 0x37F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F4F1C0
        public void CloneCurve(){} // RVA: 0x7FFE89F4F600
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFE89F4F650
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F4E0B0
        public void FromBigInteger(){} // RVA: 0x7FFE89F4F690
        public void CreateRawPoint(){} // RVA: 0x7FFE89F4F7E0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE811E0850
        public void get_M(){} // RVA: 0x7FFE89F4E0B0
        public void get_IsTrinomial(){} // RVA: 0x7FFE811E0850
        public void get_K1(){} // RVA: 0x7FFE89F4EF50
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F4F880
    }

    public class SecT409K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F4FED0
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F4FFE0
        public void Twice(){} // RVA: 0x7FFE89F50960
        public void TwicePlus(){} // RVA: 0x7FFE89F50E60
        public void Negate(){} // RVA: 0x7FFE89F514A0
    }

    public class SecT409R1Curve : AbstractF2mCurve
    {
        public int SECT409R1_DEFAULT_COORDS;
        public int SECT409R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point m_infinity; // 0x58
        public object field_3; // 0x386
        public object field_4; // 0x387
        public object field_5; // 0x388
        public object field_6; // 0x389
        public object field_7; // 0x38A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F51650
        public void CloneCurve(){} // RVA: 0x7FFE89F51AE0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F4E0B0
        public void FromBigInteger(){} // RVA: 0x7FFE89F51B30
        public void CreateRawPoint(){} // RVA: 0x7FFE89F51C80 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE89F4E0B0
        public void get_IsTrinomial(){} // RVA: 0x7FFE811E0850
        public void get_K1(){} // RVA: 0x7FFE89F4EF50
        public void get_K2(){} // RVA: 0x7FFE813240E0
        public void get_K3(){} // RVA: 0x7FFE813240E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F51D20
    }

    public class SecT409R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F52370
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F52480
        public void Twice(){} // RVA: 0x7FFE89F52E60
        public void TwicePlus(){} // RVA: 0x7FFE89F532E0
        public void Negate(){} // RVA: 0x7FFE89F53970
    }

    public class SecT571Field : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE89F53B90 | overloaded x2
        public void AddBothTo(){} // RVA: 0x7FFE89F53C30
        public void AddExt(){} // RVA: 0x7FFE89F53CD0
        public void AddOne(){} // RVA: 0x7FFE89F53D40
        public void AddTo(){} // RVA: 0x7FFE89F53DB0
        public void FromBigInteger(){} // RVA: 0x7FFE89F53E00
        public void HalfTrace(){} // RVA: 0x7FFE89F53E10
        public void Invert(){} // RVA: 0x7FFE89F54040
        public void Multiply(){} // RVA: 0x7FFE89F54380
        public void MultiplyAddToExt(){} // RVA: 0x7FFE89F54440
        public void Reduce(){} // RVA: 0x7FFE89F54540
        public void Reduce5(){} // RVA: 0x7FFE89F54700
        public void Sqrt(){} // RVA: 0x7FFE89F54780
        public void Square(){} // RVA: 0x7FFE89F54B70
        public void SquareAddToExt(){} // RVA: 0x7FFE89F54C20
        public void SquareN(){} // RVA: 0x7FFE89F54D10
        public void Trace(){} // RVA: 0x7FFE89F54E10
        public void ImplMultiply(){} // RVA: 0x7FFE89F54E50
        public void ImplMulwAcc(){} // RVA: 0x7FFE89F55350
        public void ImplSquare(){} // RVA: 0x7FFE89F55580
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F556B0
    }

    public class SecT571FieldElement : AbstractF2mFieldElement
    {
        public ulong[] x; // 0x10
        public object field_1; // 0x391
        public object field_2; // 0x392
        public object field_3; // 0x393
        public object field_4; // 0x394
        public object field_5; // 0x395
        public object field_6; // 0x396
        public object field_7; // 0x397
        public object field_8; // 0x398
        public object field_9; // 0x399

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFE89F55910
        public void get_IsZero(){} // RVA: 0x7FFE89F55970
        public void TestBitZero(){} // RVA: 0x7FFE89F183F0
        public void ToBigInteger(){} // RVA: 0x7FFE89F559B0
        public void get_FieldName(){} // RVA: 0x7FFE89F55AB0
        public void get_FieldSize(){} // RVA: 0x7FFE89F55AF0
        public void Add(){} // RVA: 0x7FFE89F55B00
        public void AddOne(){} // RVA: 0x7FFE89F55CD0
        public void Subtract(){} // RVA: 0x7FFE85B3A4A0
        public void Multiply(){} // RVA: 0x7FFE89F55E30
        public void MultiplyMinusProduct(){} // RVA: 0x7FFE89F18970
        public void MultiplyPlusProduct(){} // RVA: 0x7FFE89F55FA0
        public void Divide(){} // RVA: 0x7FFE89F18BC0
        public void Negate(){} // RVA: 0x7FFE827C4A80
        public void Square(){} // RVA: 0x7FFE89F561F0
        public void SquareMinusProduct(){} // RVA: 0x7FFE89F18CF0
        public void SquarePlusProduct(){} // RVA: 0x7FFE89F562F0
        public void SquarePow(){} // RVA: 0x7FFE89F565C0
        public void HalfTrace(){} // RVA: 0x7FFE89F566F0
        public void get_HasFastTrace(){} // RVA: 0x7FFE811E0850
        public void Trace(){} // RVA: 0x7FFE89F567F0
        public void Invert(){} // RVA: 0x7FFE89F56870
        public void Sqrt(){} // RVA: 0x7FFE89F56970
        public void get_Representation(){} // RVA: 0x7FFE817BF630
        public void get_M(){} // RVA: 0x7FFE89F55AF0
        public void get_K1(){} // RVA: 0x7FFE81200CB0
        public void get_K2(){} // RVA: 0x7FFE81474A10
        public void get_K3(){} // RVA: 0x7FFE813B49D0
        public void Equals(){} // RVA: 0x7FFE89F56BB0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFE89F56C20
    }

    public class SecT571K1Curve : AbstractF2mCurve
    {
        public int SECT571K1_DEFAULT_COORDS;
        public int SECT571K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point m_infinity; // 0x58
        public object field_3; // 0x39B
        public object field_4; // 0x39C
        public object field_5; // 0x39D
        public object field_6; // 0x39E
        public object field_7; // 0x39F

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F56CD0
        public void CloneCurve(){} // RVA: 0x7FFE89F57130
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFE89F57180
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F55AF0
        public void FromBigInteger(){} // RVA: 0x7FFE89F571C0
        public void CreateRawPoint(){} // RVA: 0x7FFE89F57310 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE811E0850
        public void get_M(){} // RVA: 0x7FFE89F55AF0
        public void get_IsTrinomial(){} // RVA: 0x7FFE810FB320
        public void get_K1(){} // RVA: 0x7FFE81200CB0
        public void get_K2(){} // RVA: 0x7FFE81474A10
        public void get_K3(){} // RVA: 0x7FFE813B49D0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F573B0
    }

    public class SecT571K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F57A00
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F57B10
        public void Twice(){} // RVA: 0x7FFE89F58490
        public void TwicePlus(){} // RVA: 0x7FFE89F58990
        public void Negate(){} // RVA: 0x7FFE89F58FD0
    }

    public class SecT571R1Curve : AbstractF2mCurve
    {
        public int SECT571R1_DEFAULT_COORDS;
        public int SECT571R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point m_infinity; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement SecT571R1_B;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement SecT571R1_B_SQRT; // 0x8
        public object field_5; // 0x3A6
        public object field_6; // 0x3A7
        public object field_7; // 0x3A8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F59180
        public void CloneCurve(){} // RVA: 0x7FFE89F59600
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFE89F19BB0
        public void get_Infinity(){} // RVA: 0x7FFE811C3500
        public void get_FieldSize(){} // RVA: 0x7FFE89F55AF0
        public void FromBigInteger(){} // RVA: 0x7FFE89F59650
        public void CreateRawPoint(){} // RVA: 0x7FFE89F597A0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFE810FB320
        public void get_M(){} // RVA: 0x7FFE89F55AF0
        public void get_IsTrinomial(){} // RVA: 0x7FFE810FB320
        public void get_K1(){} // RVA: 0x7FFE81200CB0
        public void get_K2(){} // RVA: 0x7FFE81474A10
        public void get_K3(){} // RVA: 0x7FFE813B49D0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFE89F59840
        public void .cctor(){} // RVA: 0x7FFE89F59AC0
    }

    public class SecT571R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89EE0730 | overloaded x3
        public void Detach(){} // RVA: 0x7FFE89F5A120
        public void get_YCoord(){} // RVA: 0x7FFE89F1A580
        public void get_CompressionYTilde(){} // RVA: 0x7FFE89F1A690
        public void Add(){} // RVA: 0x7FFE89F5A230
        public void Twice(){} // RVA: 0x7FFE89F5ABF0
        public void TwicePlus(){} // RVA: 0x7FFE89F5B060
        public void Negate(){} // RVA: 0x7FFE89F5B6E0
    }

}