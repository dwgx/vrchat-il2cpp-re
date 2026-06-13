// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
// Classes: 100
// Methods: 1663

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
    public class SecP128R1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP128R1_DEFAULT_COORDS;
        public int SECP128R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x947A2D0
        public void CloneCurve(){} // RVA: 0x947A700
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x947A760
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x947A7C0
        public void FromBigInteger(){} // RVA: 0x947A830
        public void CreateRawPoint(){} // RVA: 0x947AA70 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x947AB10
        public void .cctor(){} // RVA: 0x947AE80
    }

    public class SecP128R1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x947B250
        public void AddExt(){} // RVA: 0x947B490
        public void AddOne(){} // RVA: 0x947B610
        public void FromBigInteger(){} // RVA: 0x947B7D0
        public void Half(){} // RVA: 0x947BA80
        public void Multiply(){} // RVA: 0x947BC60
        public void MultiplyAddToExt(){} // RVA: 0x947BD20
        public void Negate(){} // RVA: 0x947BEA0
        public void Reduce(){} // RVA: 0x947C030
        public void Reduce32(){} // RVA: 0x947C180
        public void Square(){} // RVA: 0x947C340
        public void SquareN(){} // RVA: 0x947C3F0
        public void Subtract(){} // RVA: 0x947C4F0
        public void SubtractExt(){} // RVA: 0x947C690
        public void Twice(){} // RVA: 0x947C7D0
        public void AddPInvTo(){} // RVA: 0x947C970
        public void SubPInvFrom(){} // RVA: 0x947CA00
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x947CA70
    }

    public class SecP128R1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x947CE60
        public void get_IsOne(){} // RVA: 0x947CEA0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x947CF30
        public void get_FieldName(){} // RVA: 0x947D070
        public void get_FieldSize(){} // RVA: 0x947D0B0
        public void Add(){} // RVA: 0x947D120
        public void AddOne(){} // RVA: 0x947D290
        public void Subtract(){} // RVA: 0x947D390
        public void Multiply(){} // RVA: 0x947D500
        public void Divide(){} // RVA: 0x947D670
        public void Negate(){} // RVA: 0x947D830
        public void Square(){} // RVA: 0x947D930
        public void Invert(){} // RVA: 0x947DA30
        public void Sqrt(){} // RVA: 0x947DB80
        public void Equals(){} // RVA: 0x947DFE0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x947E050
        public void .cctor(){} // RVA: 0x947E150
    }

    public class SecP128R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x947E380
        public void Add(){} // RVA: 0x947E490
        public void Twice(){} // RVA: 0x947EF30
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x947F770
    }

    public class SecP160K1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP160K1_DEFAULT_COORDS;
        public int SECP160K1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x947F870
        public void CloneCurve(){} // RVA: 0x947FC10
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x947FC60
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x947FCC0
        public void FromBigInteger(){} // RVA: 0x947FD30
        public void CreateRawPoint(){} // RVA: 0x947FE80 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x947FF20
        public void .cctor(){} // RVA: 0x94802D0
    }

    public class SecP160K1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x9480770
        public void Add(){} // RVA: 0x9480880
        public void Twice(){} // RVA: 0x94811E0
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x9481A00
    }

    public class SecP160R1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP160R1_DEFAULT_COORDS;
        public int SECP160R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9481B00
        public void CloneCurve(){} // RVA: 0x9481F30
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x9481F80
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x9481FE0
        public void FromBigInteger(){} // RVA: 0x9482050
        public void CreateRawPoint(){} // RVA: 0x94821A0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x9482240
        public void .cctor(){} // RVA: 0x94825F0
    }

    public class SecP160R1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94829C0
        public void AddExt(){} // RVA: 0x9482AF0
        public void AddOne(){} // RVA: 0x9482D10
        public void FromBigInteger(){} // RVA: 0x9482E90
        public void Half(){} // RVA: 0x9482F80
        public void Multiply(){} // RVA: 0x94830B0
        public void MultiplyAddToExt(){} // RVA: 0x9483170
        public void Negate(){} // RVA: 0x9483350
        public void Reduce(){} // RVA: 0x9483430
        public void Reduce32(){} // RVA: 0x94835B0
        public void Square(){} // RVA: 0x9483720
        public void SquareN(){} // RVA: 0x94837D0
        public void Subtract(){} // RVA: 0x94838D0
        public void SubtractExt(){} // RVA: 0x9483950
        public void Twice(){} // RVA: 0x9483AF0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9483C40
    }

    public class SecP160R1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x9484110
        public void get_IsOne(){} // RVA: 0x9484150
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x94841B0
        public void get_FieldName(){} // RVA: 0x94841C0
        public void get_FieldSize(){} // RVA: 0x9484200
        public void Add(){} // RVA: 0x9484270
        public void AddOne(){} // RVA: 0x94843E0
        public void Subtract(){} // RVA: 0x94844E0
        public void Multiply(){} // RVA: 0x94846B0
        public void Divide(){} // RVA: 0x9484820
        public void Negate(){} // RVA: 0x94849E0
        public void Square(){} // RVA: 0x9484AE0
        public void Invert(){} // RVA: 0x9484BE0
        public void Sqrt(){} // RVA: 0x9484D30
        public void Equals(){} // RVA: 0x9485150 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94851C0
        public void .cctor(){} // RVA: 0x94852C0
    }

    public class SecP160R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94854D0
        public void Add(){} // RVA: 0x94855E0
        public void Twice(){} // RVA: 0x9485FF0
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x94869A0
    }

    public class SecP160R2Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP160R2_DEFAULT_COORDS;
        public int SECP160R2_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9486AA0
        public void CloneCurve(){} // RVA: 0x9486ED0
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x9486F20
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x9486F80
        public void FromBigInteger(){} // RVA: 0x9486FF0
        public void CreateRawPoint(){} // RVA: 0x9487140 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94871E0
        public void .cctor(){} // RVA: 0x9487590
    }

    public class SecP160R2Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x9487960
        public void AddExt(){} // RVA: 0x9487AB0
        public void AddOne(){} // RVA: 0x9487CD0
        public void FromBigInteger(){} // RVA: 0x9487E70
        public void Half(){} // RVA: 0x9487F60
        public void Multiply(){} // RVA: 0x9488090
        public void MultiplyAddToExt(){} // RVA: 0x9488150
        public void Negate(){} // RVA: 0x9488330
        public void Reduce(){} // RVA: 0x9488410
        public void Reduce32(){} // RVA: 0x9488610
        public void Square(){} // RVA: 0x94887C0
        public void SquareN(){} // RVA: 0x9488870
        public void Subtract(){} // RVA: 0x9488970
        public void SubtractExt(){} // RVA: 0x9488A00
        public void Twice(){} // RVA: 0x9488BA0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9488D10
    }

    public class SecP160R2FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x9484110
        public void get_IsOne(){} // RVA: 0x9484150
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x94841B0
        public void get_FieldName(){} // RVA: 0x9489150
        public void get_FieldSize(){} // RVA: 0x9489190
        public void Add(){} // RVA: 0x9489200
        public void AddOne(){} // RVA: 0x9489370
        public void Subtract(){} // RVA: 0x9489470
        public void Multiply(){} // RVA: 0x9489660
        public void Divide(){} // RVA: 0x94897D0
        public void Negate(){} // RVA: 0x9489990
        public void Square(){} // RVA: 0x9489A90
        public void Invert(){} // RVA: 0x9489B90
        public void Sqrt(){} // RVA: 0x9489CE0
        public void Equals(){} // RVA: 0x9485150 | overloaded x3
        public void GetHashCode(){} // RVA: 0x948A2B0
        public void .cctor(){} // RVA: 0x948A3B0
    }

    public class SecP160R2Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x948A5C0
        public void Add(){} // RVA: 0x948A6D0
        public void Twice(){} // RVA: 0x948B030
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x948B940
    }

    public class SecP192K1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP192K1_DEFAULT_COORDS;
        public int SECP192K1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x948BA40
        public void CloneCurve(){} // RVA: 0x948BDE0
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x948BE30
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x948BE90
        public void FromBigInteger(){} // RVA: 0x948BF00
        public void CreateRawPoint(){} // RVA: 0x948C050 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x948C0F0
        public void .cctor(){} // RVA: 0x948C370
    }

    public class SecP192K1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x948C740
        public void AddExt(){} // RVA: 0x948C890
        public void AddOne(){} // RVA: 0x948CAB0
        public void FromBigInteger(){} // RVA: 0x948CC50
        public void Half(){} // RVA: 0x948CD40
        public void Multiply(){} // RVA: 0x948CE70
        public void MultiplyAddToExt(){} // RVA: 0x948CF30
        public void Negate(){} // RVA: 0x948D110
        public void Reduce(){} // RVA: 0x948D200
        public void Reduce32(){} // RVA: 0x948D3E0
        public void Square(){} // RVA: 0x948D590
        public void SquareN(){} // RVA: 0x948D640
        public void Subtract(){} // RVA: 0x948D740
        public void SubtractExt(){} // RVA: 0x948D7D0
        public void Twice(){} // RVA: 0x948D970
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x948DAE0
    }

    public class SecP192K1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x948DFB0
        public void get_IsOne(){} // RVA: 0x948DFF0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x948E050
        public void get_FieldName(){} // RVA: 0x948E060
        public void get_FieldSize(){} // RVA: 0x948E0A0
        public void Add(){} // RVA: 0x948E110
        public void AddOne(){} // RVA: 0x948E380
        public void Subtract(){} // RVA: 0x948E480
        public void Multiply(){} // RVA: 0x948E670
        public void Divide(){} // RVA: 0x948E7E0
        public void Negate(){} // RVA: 0x948E9A0
        public void Square(){} // RVA: 0x948EAA0
        public void Invert(){} // RVA: 0x948EBA0
        public void Sqrt(){} // RVA: 0x948ECF0
        public void Equals(){} // RVA: 0x948F240 | overloaded x3
        public void GetHashCode(){} // RVA: 0x948F2B0
        public void .cctor(){} // RVA: 0x948F3B0
    }

    public class SecP192K1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x948F5C0
        public void Add(){} // RVA: 0x948F6D0
        public void Twice(){} // RVA: 0x9490030
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x9490850
    }

    public class SecP192R1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP192R1_DEFAULT_COORDS;
        public int SECP192R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9490950
        public void CloneCurve(){} // RVA: 0x9490D80
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x9490DD0
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x9490E30
        public void FromBigInteger(){} // RVA: 0x9490EA0
        public void CreateRawPoint(){} // RVA: 0x9490FF0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x9491090
        public void .cctor(){} // RVA: 0x9491310
    }

    public class SecP192R1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94916E0
        public void AddExt(){} // RVA: 0x94917F0
        public void AddOne(){} // RVA: 0x9491A10
        public void FromBigInteger(){} // RVA: 0x9491B70
        public void Half(){} // RVA: 0x9491C60
        public void Multiply(){} // RVA: 0x9491D90
        public void MultiplyAddToExt(){} // RVA: 0x9491E50
        public void Negate(){} // RVA: 0x9492030
        public void Reduce(){} // RVA: 0x9492120
        public void Reduce32(){} // RVA: 0x94923B0
        public void Square(){} // RVA: 0x9492510
        public void SquareN(){} // RVA: 0x94925C0
        public void Subtract(){} // RVA: 0x94926C0
        public void SubtractExt(){} // RVA: 0x94927D0
        public void Twice(){} // RVA: 0x9492970
        public void AddPInvTo(){} // RVA: 0x9492AB0
        public void SubPInvFrom(){} // RVA: 0x9492B60
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x9492C00
    }

    public class SecP192R1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x948DFB0
        public void get_IsOne(){} // RVA: 0x948DFF0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x948E050
        public void get_FieldName(){} // RVA: 0x9493040
        public void get_FieldSize(){} // RVA: 0x9493080
        public void Add(){} // RVA: 0x94930F0
        public void AddOne(){} // RVA: 0x9493260
        public void Subtract(){} // RVA: 0x94934A0
        public void Multiply(){} // RVA: 0x9493610
        public void Divide(){} // RVA: 0x9493780
        public void Negate(){} // RVA: 0x9493940
        public void Square(){} // RVA: 0x9493A40
        public void Invert(){} // RVA: 0x9493B40
        public void Sqrt(){} // RVA: 0x9493C90
        public void Equals(){} // RVA: 0x948F240 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94940C0
        public void .cctor(){} // RVA: 0x94941C0
    }

    public class SecP192R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94943D0
        public void Add(){} // RVA: 0x94944E0
        public void Twice(){} // RVA: 0x9494E40
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x9495620
    }

    public class SecP224K1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP224K1_DEFAULT_COORDS;
        public int SECP224K1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9495720
        public void CloneCurve(){} // RVA: 0x9495AC0
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x9495B10
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x9495B70
        public void FromBigInteger(){} // RVA: 0x9495BE0
        public void CreateRawPoint(){} // RVA: 0x9495D30 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x9495DD0
        public void .cctor(){} // RVA: 0x9496050
    }

    public class SecP224K1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x9496420
        public void AddExt(){} // RVA: 0x9496570
        public void AddOne(){} // RVA: 0x9496790
        public void FromBigInteger(){} // RVA: 0x9496930
        public void Half(){} // RVA: 0x9496A20
        public void Multiply(){} // RVA: 0x9496B50
        public void MultiplyAddToExt(){} // RVA: 0x9496C10
        public void Negate(){} // RVA: 0x9496DF0
        public void Reduce(){} // RVA: 0x9496EF0
        public void Reduce32(){} // RVA: 0x94970D0
        public void Square(){} // RVA: 0x9497280
        public void SquareN(){} // RVA: 0x9497330
        public void Subtract(){} // RVA: 0x9497430
        public void SubtractExt(){} // RVA: 0x94974C0
        public void Twice(){} // RVA: 0x9497660
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x94977D0
    }

    public class SecP224K1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] PRECOMP_POW2; // 0x8
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x9497CA0
        public void get_IsOne(){} // RVA: 0x9497CE0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x9497D40
        public void get_FieldName(){} // RVA: 0x9497D50
        public void get_FieldSize(){} // RVA: 0x9497D90
        public void Add(){} // RVA: 0x9497E00
        public void AddOne(){} // RVA: 0x9498070
        public void Subtract(){} // RVA: 0x9498170
        public void Multiply(){} // RVA: 0x9498360
        public void Divide(){} // RVA: 0x94984D0
        public void Negate(){} // RVA: 0x9498690
        public void Square(){} // RVA: 0x9498790
        public void Invert(){} // RVA: 0x9498890
        public void Sqrt(){} // RVA: 0x94989E0
        public void Equals(){} // RVA: 0x9499030 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94990A0
        public void .cctor(){} // RVA: 0x94991A0
    }

    public class SecP224K1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x9499480
        public void Add(){} // RVA: 0x9499590
        public void Twice(){} // RVA: 0x9499EF0
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x949A710
    }

    public class SecP224R1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP224R1_DEFAULT_COORDS;
        public int SECP224R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x949A810
        public void CloneCurve(){} // RVA: 0x949AC40
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x949AC90
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x949ACF0
        public void FromBigInteger(){} // RVA: 0x949AD60
        public void CreateRawPoint(){} // RVA: 0x949AEB0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x949AF50
        public void .cctor(){} // RVA: 0x949B1D0
    }

    public class SecP224R1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x949B5A0
        public void AddExt(){} // RVA: 0x949B6B0
        public void AddOne(){} // RVA: 0x949B8D0
        public void FromBigInteger(){} // RVA: 0x949BA30
        public void Half(){} // RVA: 0x949BB20
        public void Multiply(){} // RVA: 0x949BC50
        public void MultiplyAddToExt(){} // RVA: 0x949BD10
        public void Negate(){} // RVA: 0x949BEF0
        public void Reduce(){} // RVA: 0x949BFF0
        public void Reduce32(){} // RVA: 0x949C2B0
        public void Square(){} // RVA: 0x949C430
        public void SquareN(){} // RVA: 0x949C4E0
        public void Subtract(){} // RVA: 0x949C5E0
        public void SubtractExt(){} // RVA: 0x949C710
        public void Twice(){} // RVA: 0x949C8B0
        public void AddPInvTo(){} // RVA: 0x949C9F0
        public void SubPInvFrom(){} // RVA: 0x949CA90
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x949CB60
    }

    public class SecP224R1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x9497CA0
        public void get_IsOne(){} // RVA: 0x9497CE0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x9497D40
        public void get_FieldName(){} // RVA: 0x949CFA0
        public void get_FieldSize(){} // RVA: 0x949CFE0
        public void Add(){} // RVA: 0x949D050
        public void AddOne(){} // RVA: 0x949D1C0
        public void Subtract(){} // RVA: 0x949D2C0
        public void Multiply(){} // RVA: 0x949D430
        public void Divide(){} // RVA: 0x949D5A0
        public void Negate(){} // RVA: 0x949D760
        public void Square(){} // RVA: 0x949D860
        public void Invert(){} // RVA: 0x949D960
        public void Sqrt(){} // RVA: 0x949DAB0
        public void Equals(){} // RVA: 0x9499030 | overloaded x3
        public void GetHashCode(){} // RVA: 0x949DFE0
        public void IsSquare(){} // RVA: 0x949E0E0
        public void RM(){} // RVA: 0x949E3D0
        public void RP(){} // RVA: 0x949E5C0
        public void RS(){} // RVA: 0x949E9D0
        public void TrySqrt(){} // RVA: 0x949EAE0
        public void .cctor(){} // RVA: 0x949EFE0
    }

    public class SecP224R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x949F1F0
        public void Add(){} // RVA: 0x949F300
        public void Twice(){} // RVA: 0x949FC60
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x94A0320
    }

    public class SecP256K1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP256K1_DEFAULT_COORDS;
        public int SECP256K1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94A0420
        public void CloneCurve(){} // RVA: 0x94A07C0
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x94A0810
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x94A0870
        public void FromBigInteger(){} // RVA: 0x94A08E0
        public void CreateRawPoint(){} // RVA: 0x94A0A30 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94A0AD0
        public void .cctor(){} // RVA: 0x94A0D50
    }

    public class SecP256K1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94A1120
        public void AddExt(){} // RVA: 0x94A1270
        public void AddOne(){} // RVA: 0x94A1490
        public void FromBigInteger(){} // RVA: 0x94A1630
        public void Half(){} // RVA: 0x94A1720
        public void Multiply(){} // RVA: 0x94A1850
        public void MultiplyAddToExt(){} // RVA: 0x94A1910
        public void Negate(){} // RVA: 0x94A1AF0
        public void Reduce(){} // RVA: 0x94A1C00
        public void Reduce32(){} // RVA: 0x94A1DE0
        public void Square(){} // RVA: 0x94A1F90
        public void SquareN(){} // RVA: 0x94A2040
        public void Subtract(){} // RVA: 0x94A2140
        public void SubtractExt(){} // RVA: 0x94A21D0
        public void Twice(){} // RVA: 0x94A2370
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x94A24E0
    }

    public class SecP256K1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x94A29B0
        public void get_IsOne(){} // RVA: 0x94A29F0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x94A2A50
        public void get_FieldName(){} // RVA: 0x94A2A60
        public void get_FieldSize(){} // RVA: 0x94A2AA0
        public void Add(){} // RVA: 0x94A2B10
        public void AddOne(){} // RVA: 0x94A2D80
        public void Subtract(){} // RVA: 0x94A2E80
        public void Multiply(){} // RVA: 0x94A3070
        public void Divide(){} // RVA: 0x94A31E0
        public void Negate(){} // RVA: 0x94A33A0
        public void Square(){} // RVA: 0x94A34A0
        public void Invert(){} // RVA: 0x94A35A0
        public void Sqrt(){} // RVA: 0x94A36F0
        public void Equals(){} // RVA: 0x94A3CC0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94A3D30
        public void .cctor(){} // RVA: 0x94A3E30
    }

    public class SecP256K1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94A4040
        public void Add(){} // RVA: 0x94A4150
        public void Twice(){} // RVA: 0x94A4AB0
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x94A52D0
    }

    public class SecP256R1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP256R1_DEFAULT_COORDS;
        public int SECP256R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94A53D0
        public void CloneCurve(){} // RVA: 0x94A5800
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x94A5850
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x94A58B0
        public void FromBigInteger(){} // RVA: 0x94A5920
        public void CreateRawPoint(){} // RVA: 0x94A5A70 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94A5B10
        public void .cctor(){} // RVA: 0x94A5D90
    }

    public class SecP256R1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94A6160
        public void AddExt(){} // RVA: 0x94A6270
        public void AddOne(){} // RVA: 0x94A6420
        public void FromBigInteger(){} // RVA: 0x94A6580
        public void Half(){} // RVA: 0x94A6670
        public void Multiply(){} // RVA: 0x94A67A0
        public void MultiplyAddToExt(){} // RVA: 0x94A6860
        public void Negate(){} // RVA: 0x94A69D0
        public void Reduce(){} // RVA: 0x94A6AE0
        public void Reduce32(){} // RVA: 0x94A6D50
        public void Square(){} // RVA: 0x94A6F30
        public void SquareN(){} // RVA: 0x94A6FE0
        public void Subtract(){} // RVA: 0x94A70E0
        public void SubtractExt(){} // RVA: 0x94A7220
        public void Twice(){} // RVA: 0x94A7350
        public void AddPInvTo(){} // RVA: 0x94A7490
        public void SubPInvFrom(){} // RVA: 0x94A7590
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x94A7670
    }

    public class SecP256R1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x94A29B0
        public void get_IsOne(){} // RVA: 0x94A29F0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x94A2A50
        public void get_FieldName(){} // RVA: 0x94A7A10
        public void get_FieldSize(){} // RVA: 0x94A7A50
        public void Add(){} // RVA: 0x94A7AC0
        public void AddOne(){} // RVA: 0x94A7C30
        public void Subtract(){} // RVA: 0x94A7E70
        public void Multiply(){} // RVA: 0x94A7FE0
        public void Divide(){} // RVA: 0x94A8150
        public void Negate(){} // RVA: 0x94A8310
        public void Square(){} // RVA: 0x94A8410
        public void Invert(){} // RVA: 0x94A8510
        public void Sqrt(){} // RVA: 0x94A8660
        public void Equals(){} // RVA: 0x94A3CC0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94A8A90
        public void .cctor(){} // RVA: 0x94A8B90
    }

    public class SecP256R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94A8DA0
        public void Add(){} // RVA: 0x94A8EB0
        public void Twice(){} // RVA: 0x94A9950
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x94AA130
    }

    public class SecP384R1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP384R1_DEFAULT_COORDS;
        public int SECP384R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94AA230
        public void CloneCurve(){} // RVA: 0x94AA660
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x94AA6B0
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x94AA710
        public void FromBigInteger(){} // RVA: 0x94AA780
        public void CreateRawPoint(){} // RVA: 0x94AA8D0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94AA970
        public void .cctor(){} // RVA: 0x94AAC00
    }

    public class SecP384R1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94AAFD0
        public void AddExt(){} // RVA: 0x94AB130
        public void AddOne(){} // RVA: 0x94AB350
        public void FromBigInteger(){} // RVA: 0x94AB4B0
        public void Half(){} // RVA: 0x94AB5F0
        public void Multiply(){} // RVA: 0x94AB760
        public void Negate(){} // RVA: 0x94AB820
        public void Reduce(){} // RVA: 0x94AB960
        public void Reduce32(){} // RVA: 0x94ABCD0
        public void Square(){} // RVA: 0x94ABE80
        public void SquareN(){} // RVA: 0x94ABF30
        public void Subtract(){} // RVA: 0x94AC030
        public void SubtractExt(){} // RVA: 0x94AC1C0
        public void Twice(){} // RVA: 0x94AC360
        public void AddPInvTo(){} // RVA: 0x94AC4A0
        public void SubPInvFrom(){} // RVA: 0x94AC570
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x94AC640
    }

    public class SecP384R1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x94ACB50
        public void get_IsOne(){} // RVA: 0x94ACBB0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x94ACC10
        public void get_FieldName(){} // RVA: 0x94ACC30
        public void get_FieldSize(){} // RVA: 0x94ACC70
        public void Add(){} // RVA: 0x94ACCE0
        public void AddOne(){} // RVA: 0x94ACF70
        public void Subtract(){} // RVA: 0x94AD1B0
        public void Multiply(){} // RVA: 0x94AD320
        public void Divide(){} // RVA: 0x94AD490
        public void Negate(){} // RVA: 0x94AD650
        public void Square(){} // RVA: 0x94AD750
        public void Invert(){} // RVA: 0x94AD850
        public void Sqrt(){} // RVA: 0x94AD9A0
        public void Equals(){} // RVA: 0x94ADF20 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94ADF90
        public void .cctor(){} // RVA: 0x94AE090
    }

    public class SecP384R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94AE2A0
        public void Add(){} // RVA: 0x94AE3B0
        public void Twice(){} // RVA: 0x94AEDC0
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x94AF6A0
    }

    public class SecP521R1Curve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger q;
        public int SECP521R1_DEFAULT_COORDS;
        public int SECP521R1_FE_INTS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94AF7A0
        public void CloneCurve(){} // RVA: 0x94AFBD0
        public void SupportsCoordinateSystem(){} // RVA: 0x947A750
        public void get_Q(){} // RVA: 0x94AFC20
        public void get_Infinity(){} // RVA: 0x37E0E0
        public void get_FieldSize(){} // RVA: 0x94AFC80
        public void FromBigInteger(){} // RVA: 0x94AFCF0
        public void CreateRawPoint(){} // RVA: 0x94AFE40 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94AFEE0
        public void .cctor(){} // RVA: 0x94B0170
    }

    public class SecP521R1Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94B0540
        public void AddOne(){} // RVA: 0x94B06C0
        public void FromBigInteger(){} // RVA: 0x94B0860
        public void Half(){} // RVA: 0x94B0930
        public void Multiply(){} // RVA: 0x94B09C0
        public void Negate(){} // RVA: 0x94B0B50
        public void Reduce(){} // RVA: 0x94B0C90
        public void Reduce23(){} // RVA: 0x94B0E40
        public void Square(){} // RVA: 0x94B0F80
        public void SquareN(){} // RVA: 0x94B10C0
        public void Subtract(){} // RVA: 0x94B12F0
        public void Twice(){} // RVA: 0x94B13D0
        public void ImplMultiply(){} // RVA: 0x94B1460
        public void ImplSquare(){} // RVA: 0x94B1570
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x94B1620
    }

    public class SecP521R1FieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public uint[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x94B1970
        public void get_IsOne(){} // RVA: 0x94B19D0
        public void TestBitZero(){} // RVA: 0x947CF00
        public void ToBigInteger(){} // RVA: 0x94B1A30
        public void get_FieldName(){} // RVA: 0x94B1A50
        public void get_FieldSize(){} // RVA: 0x94B1A90
        public void Add(){} // RVA: 0x94B1B00
        public void AddOne(){} // RVA: 0x94B1DC0
        public void Subtract(){} // RVA: 0x94B2040
        public void Multiply(){} // RVA: 0x94B2270
        public void Divide(){} // RVA: 0x94B23E0
        public void Negate(){} // RVA: 0x94B25A0
        public void Square(){} // RVA: 0x94B27C0
        public void Invert(){} // RVA: 0x94B28C0
        public void Sqrt(){} // RVA: 0x94B2A10
        public void Equals(){} // RVA: 0x94B2D40 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94B2DB0
        public void .cctor(){} // RVA: 0x94B2EB0
    }

    public class SecP521R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94B30C0
        public void Add(){} // RVA: 0x94B31D0
        public void Twice(){} // RVA: 0x94B3F70
        public void TwicePlus(){} // RVA: 0x947F5F0
        public void ThreeTimes(){} // RVA: 0x947F6F0
        public void Negate(){} // RVA: 0x94B4A80
    }

    public class SecT113Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94B4B80
        public void AddExt(){} // RVA: 0x94B4BF0
        public void AddOne(){} // RVA: 0x94B4CA0
        public void AddTo(){} // RVA: 0x94B4CF0
        public void FromBigInteger(){} // RVA: 0x94B4D40
        public void HalfTrace(){} // RVA: 0x94B4D50
        public void Invert(){} // RVA: 0x94B5020
        public void Multiply(){} // RVA: 0x94B5250
        public void MultiplyAddToExt(){} // RVA: 0x94B52E0
        public void Reduce(){} // RVA: 0x94B53C0
        public void Reduce15(){} // RVA: 0x94B54A0
        public void Sqrt(){} // RVA: 0x94B5510
        public void Square(){} // RVA: 0x94B55E0
        public void SquareAddToExt(){} // RVA: 0x94B5690
        public void SquareN(){} // RVA: 0x94B57A0
        public void Trace(){} // RVA: 0x94B5970
        public void ImplMultiply(){} // RVA: 0x94B59A0
        public void ImplMulw(){} // RVA: 0x94B5BB0
        public void ImplSquare(){} // RVA: 0x94B5DE0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SecT113FieldElement
    {
        public ulong[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x94B5F80
        public void get_IsZero(){} // RVA: 0x94B5FE0
        public void TestBitZero(){} // RVA: 0x94B6020
        public void ToBigInteger(){} // RVA: 0x94B6050
        public void get_FieldName(){} // RVA: 0x94B6150
        public void get_FieldSize(){} // RVA: 0x20C72B0
        public void Add(){} // RVA: 0x94B6190
        public void AddOne(){} // RVA: 0x94B6340
        public void Subtract(){} // RVA: 0x4EE62A0
        public void Multiply(){} // RVA: 0x94B6460
        public void MultiplyMinusProduct(){} // RVA: 0x94B65A0
        public void MultiplyPlusProduct(){} // RVA: 0x94B65C0
        public void Divide(){} // RVA: 0x94B67F0
        public void Negate(){} // RVA: 0x1A3F520
        public void Square(){} // RVA: 0x94B6840
        public void SquareMinusProduct(){} // RVA: 0x94B6920
        public void SquarePlusProduct(){} // RVA: 0x94B6940
        public void SquarePow(){} // RVA: 0x94B6C10
        public void HalfTrace(){} // RVA: 0x94B6D10
        public void get_HasFastTrace(){} // RVA: 0x3C2850
        public void Trace(){} // RVA: 0x947CF00
        public void Invert(){} // RVA: 0x94B6DF0
        public void Sqrt(){} // RVA: 0x94B6ED0
        public void get_Representation(){} // RVA: 0x3E2CB0
        public void get_M(){} // RVA: 0x20C72B0
        public void get_K1(){} // RVA: 0x1730F70
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void Equals(){} // RVA: 0x94B7190 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94B7200
    }

    public class SecT113R1Curve
    {
        public int SECT113R1_DEFAULT_COORDS;
        public int SECT113R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94B72B0
        public void CloneCurve(){} // RVA: 0x94B7790
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x20C72B0
        public void FromBigInteger(){} // RVA: 0x94B77F0
        public void CreateRawPoint(){} // RVA: 0x94B7940 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x20C72B0
        public void get_IsTrinomial(){} // RVA: 0x3C2850
        public void get_K1(){} // RVA: 0x1730F70
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94B79E0
    }

    public class SecT113R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94B80A0
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94B8350
        public void Twice(){} // RVA: 0x94B8D40
        public void TwicePlus(){} // RVA: 0x94B9200
        public void Negate(){} // RVA: 0x94B98F0
    }

    public class SecT113R2Curve
    {
        public int SECT113R2_DEFAULT_COORDS;
        public int SECT113R2_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94B9AA0
        public void CloneCurve(){} // RVA: 0x94B9F80
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x20C72B0
        public void FromBigInteger(){} // RVA: 0x94B9FD0
        public void CreateRawPoint(){} // RVA: 0x94BA120 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x20C72B0
        public void get_IsTrinomial(){} // RVA: 0x3C2850
        public void get_K1(){} // RVA: 0x1730F70
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94BA1C0
    }

    public class SecT113R2Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94BA880
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94BA990
        public void Twice(){} // RVA: 0x94BB380
        public void TwicePlus(){} // RVA: 0x94BB840
        public void Negate(){} // RVA: 0x94BBF30
    }

    public class SecT131Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94BC0E0
        public void AddExt(){} // RVA: 0x94BC170
        public void AddOne(){} // RVA: 0x94BC250
        public void AddTo(){} // RVA: 0x94BC2B0
        public void FromBigInteger(){} // RVA: 0x94BC320
        public void HalfTrace(){} // RVA: 0x94BC330
        public void Invert(){} // RVA: 0x94BC5C0
        public void Multiply(){} // RVA: 0x94BC830
        public void MultiplyAddToExt(){} // RVA: 0x94BC8F0
        public void Reduce(){} // RVA: 0x94BCA20
        public void Reduce61(){} // RVA: 0x94BCB60
        public void Sqrt(){} // RVA: 0x94BCBF0
        public void Square(){} // RVA: 0x94BCD70
        public void SquareAddToExt(){} // RVA: 0x94BCEA0
        public void SquareN(){} // RVA: 0x94BD040
        public void Trace(){} // RVA: 0x94BD240
        public void ImplCompactExt(){} // RVA: 0x94BD290
        public void ImplMultiply(){} // RVA: 0x94BD380
        public void ImplMulw(){} // RVA: 0x94BD900
        public void ImplSquare(){} // RVA: 0x94BDB60
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x94BDC00
    }

    public class SecT131FieldElement
    {
        public ulong[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x94BDE60
        public void get_IsZero(){} // RVA: 0x94BDEC0
        public void TestBitZero(){} // RVA: 0x94B6020
        public void ToBigInteger(){} // RVA: 0x94BDF00
        public void get_FieldName(){} // RVA: 0x94BDF10
        public void get_FieldSize(){} // RVA: 0x94BDF50
        public void Add(){} // RVA: 0x94BDF60
        public void AddOne(){} // RVA: 0x94BE160
        public void Subtract(){} // RVA: 0x4EE62A0
        public void Multiply(){} // RVA: 0x94BE2D0
        public void MultiplyMinusProduct(){} // RVA: 0x94B65A0
        public void MultiplyPlusProduct(){} // RVA: 0x94BE440
        public void Divide(){} // RVA: 0x94B67F0
        public void Negate(){} // RVA: 0x1A3F520
        public void Square(){} // RVA: 0x94BE690
        public void SquareMinusProduct(){} // RVA: 0x94B6920
        public void SquarePlusProduct(){} // RVA: 0x94BE790
        public void SquarePow(){} // RVA: 0x94BE9A0
        public void HalfTrace(){} // RVA: 0x94BEAD0
        public void get_HasFastTrace(){} // RVA: 0x3C2850
        public void Trace(){} // RVA: 0x94BEBD0
        public void Invert(){} // RVA: 0x94BEC60
        public void Sqrt(){} // RVA: 0x94BED60
        public void get_Representation(){} // RVA: 0xA308B0
        public void get_M(){} // RVA: 0x94BDF50
        public void get_K1(){} // RVA: 0x3E2CB0
        public void get_K2(){} // RVA: 0xA308B0
        public void get_K3(){} // RVA: 0xA63AE0
        public void Equals(){} // RVA: 0x94BF100 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94BF170
    }

    public class SecT131R1Curve
    {
        public int SECT131R1_DEFAULT_COORDS;
        public int SECT131R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94BF220
        public void CloneCurve(){} // RVA: 0x94BF720
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94BDF50
        public void FromBigInteger(){} // RVA: 0x94BF770
        public void CreateRawPoint(){} // RVA: 0x94BF8C0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x94BDF50
        public void get_IsTrinomial(){} // RVA: 0x2DD320
        public void get_K1(){} // RVA: 0x3E2CB0
        public void get_K2(){} // RVA: 0xA308B0
        public void get_K3(){} // RVA: 0xA63AE0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94BF960
    }

    public class SecT131R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94C0070
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94C0180
        public void Twice(){} // RVA: 0x94C0B70
        public void TwicePlus(){} // RVA: 0x94C1030
        public void Negate(){} // RVA: 0x94C1720
    }

    public class SecT131R2Curve
    {
        public int SECT131R2_DEFAULT_COORDS;
        public int SECT131R2_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94C18D0
        public void CloneCurve(){} // RVA: 0x94C1DD0
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_FieldSize(){} // RVA: 0x94BDF50
        public void FromBigInteger(){} // RVA: 0x94C1E20
        public void CreateRawPoint(){} // RVA: 0x94C1F70 | overloaded x2
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x94BDF50
        public void get_IsTrinomial(){} // RVA: 0x2DD320
        public void get_K1(){} // RVA: 0x3E2CB0
        public void get_K2(){} // RVA: 0xA308B0
        public void get_K3(){} // RVA: 0xA63AE0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94C2010
    }

    public class SecT131R2Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94C2720
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94C2830
        public void Twice(){} // RVA: 0x94C3220
        public void TwicePlus(){} // RVA: 0x94C36E0
        public void Negate(){} // RVA: 0x94C3DD0
    }

    public class SecT163Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94BC0E0
        public void AddExt(){} // RVA: 0x94C3F80
        public void AddOne(){} // RVA: 0x94BC250
        public void AddTo(){} // RVA: 0x94BC2B0
        public void FromBigInteger(){} // RVA: 0x94C4090
        public void HalfTrace(){} // RVA: 0x94C40A0
        public void Invert(){} // RVA: 0x94C42E0
        public void Multiply(){} // RVA: 0x94C4580
        public void MultiplyAddToExt(){} // RVA: 0x94C4640
        public void Reduce(){} // RVA: 0x94C4700
        public void Reduce29(){} // RVA: 0x94C4890
        public void Sqrt(){} // RVA: 0x94C4910
        public void Square(){} // RVA: 0x94C4A90
        public void SquareAddToExt(){} // RVA: 0x94C4B90
        public void SquareN(){} // RVA: 0x94C4C90
        public void Trace(){} // RVA: 0x94C4E30
        public void ImplCompactExt(){} // RVA: 0x94C4E70
        public void ImplMultiply(){} // RVA: 0x94C4F60
        public void ImplMulw(){} // RVA: 0x94C54E0
        public void ImplSquare(){} // RVA: 0x94C56E0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x94C5760
    }

    public class SecT163FieldElement
    {
        public ulong[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x94BDE60
        public void get_IsZero(){} // RVA: 0x94BDEC0
        public void TestBitZero(){} // RVA: 0x94B6020
        public void ToBigInteger(){} // RVA: 0x94BDF00
        public void get_FieldName(){} // RVA: 0x94C5930
        public void get_FieldSize(){} // RVA: 0x20C7910
        public void Add(){} // RVA: 0x94C5970
        public void AddOne(){} // RVA: 0x94C5B70
        public void Subtract(){} // RVA: 0x4EE62A0
        public void Multiply(){} // RVA: 0x94C5CE0
        public void MultiplyMinusProduct(){} // RVA: 0x94B65A0
        public void MultiplyPlusProduct(){} // RVA: 0x94C5E50
        public void Divide(){} // RVA: 0x94B67F0
        public void Negate(){} // RVA: 0x1A3F520
        public void Square(){} // RVA: 0x94C60A0
        public void SquareMinusProduct(){} // RVA: 0x94B6920
        public void SquarePlusProduct(){} // RVA: 0x94C61A0
        public void SquarePow(){} // RVA: 0x94C6480
        public void HalfTrace(){} // RVA: 0x94C65B0
        public void get_HasFastTrace(){} // RVA: 0x3C2850
        public void Trace(){} // RVA: 0x94C66B0
        public void Invert(){} // RVA: 0x94C6730
        public void Sqrt(){} // RVA: 0x94C6830
        public void get_Representation(){} // RVA: 0xA308B0
        public void get_M(){} // RVA: 0x20C7910
        public void get_K1(){} // RVA: 0xA308B0
        public void get_K2(){} // RVA: 0xA850E0
        public void get_K3(){} // RVA: 0xA67BB0
        public void Equals(){} // RVA: 0x94BF100 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94C6BD0
    }

    public class SecT163K1Curve
    {
        public int SECT163K1_DEFAULT_COORDS;
        public int SECT163K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94C6C80
        public void CloneCurve(){} // RVA: 0x94C70E0
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void CreateDefaultMultiplier(){} // RVA: 0x94C7130
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x20C7910
        public void FromBigInteger(){} // RVA: 0x94C7170
        public void CreateRawPoint(){} // RVA: 0x94C72C0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x3C2850
        public void get_M(){} // RVA: 0x20C7910
        public void get_IsTrinomial(){} // RVA: 0x2DD320
        public void get_K1(){} // RVA: 0xA308B0
        public void get_K2(){} // RVA: 0xA850E0
        public void get_K3(){} // RVA: 0xA67BB0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94C7360
    }

    public class SecT163K1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94C7A70
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94C7B80
        public void Twice(){} // RVA: 0x94C8520
        public void TwicePlus(){} // RVA: 0x94C8990
        public void Negate(){} // RVA: 0x94C9000
    }

    public class SecT163R1Curve
    {
        public int SECT163R1_DEFAULT_COORDS;
        public int SECT163R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94C91B0
        public void CloneCurve(){} // RVA: 0x94C96B0
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x20C7910
        public void FromBigInteger(){} // RVA: 0x94C9700
        public void CreateRawPoint(){} // RVA: 0x94C9850 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x20C7910
        public void get_IsTrinomial(){} // RVA: 0x2DD320
        public void get_K1(){} // RVA: 0xA308B0
        public void get_K2(){} // RVA: 0xA850E0
        public void get_K3(){} // RVA: 0xA67BB0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94C98F0
    }

    public class SecT163R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94CA000
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94CA110
        public void Twice(){} // RVA: 0x94CAB00
        public void TwicePlus(){} // RVA: 0x94CAFC0
        public void Negate(){} // RVA: 0x94CB6B0
    }

    public class SecT163R2Curve
    {
        public int SECT163R2_DEFAULT_COORDS;
        public int SECT163R2_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94CB860
        public void CloneCurve(){} // RVA: 0x94CBD10
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x20C7910
        public void FromBigInteger(){} // RVA: 0x94CBD60
        public void CreateRawPoint(){} // RVA: 0x94CBEB0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x20C7910
        public void get_IsTrinomial(){} // RVA: 0x2DD320
        public void get_K1(){} // RVA: 0xA308B0
        public void get_K2(){} // RVA: 0xA850E0
        public void get_K3(){} // RVA: 0xA67BB0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94CBF50
    }

    public class SecT163R2Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94CC660
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94CC770
        public void Twice(){} // RVA: 0x94CD150
        public void TwicePlus(){} // RVA: 0x94CD5D0
        public void Negate(){} // RVA: 0x94CDC60
    }

    public class SecT193Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94B4BF0
        public void AddExt(){} // RVA: 0x94CDE10
        public void AddOne(){} // RVA: 0x94CDF50
        public void AddTo(){} // RVA: 0x94CDFD0
        public void FromBigInteger(){} // RVA: 0x94CE050
        public void HalfTrace(){} // RVA: 0x94CE060
        public void Invert(){} // RVA: 0x94CE2D0
        public void Multiply(){} // RVA: 0x94CE510
        public void MultiplyAddToExt(){} // RVA: 0x94CE5A0
        public void Reduce(){} // RVA: 0x94CE630
        public void Reduce63(){} // RVA: 0x94CE790
        public void Sqrt(){} // RVA: 0x94CE810
        public void Square(){} // RVA: 0x94CE960
        public void SquareAddToExt(){} // RVA: 0x94CEA50
        public void SquareN(){} // RVA: 0x94CEB40
        public void Trace(){} // RVA: 0x94B5970
        public void ImplCompactExt(){} // RVA: 0x94CECE0
        public void ImplExpand(){} // RVA: 0x94CEE40
        public void ImplMultiply(){} // RVA: 0x94CEF00
        public void ImplMulwAcc(){} // RVA: 0x94CF540
        public void ImplSquare(){} // RVA: 0x94CF7B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SecT193FieldElement
    {
        public ulong[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x94CF990
        public void get_IsZero(){} // RVA: 0x94CF9F0
        public void TestBitZero(){} // RVA: 0x94B6020
        public void ToBigInteger(){} // RVA: 0x94CFA30
        public void get_FieldName(){} // RVA: 0x94CFA40
        public void get_FieldSize(){} // RVA: 0x94CFA80
        public void Add(){} // RVA: 0x94CFA90
        public void AddOne(){} // RVA: 0x94CFC90
        public void Subtract(){} // RVA: 0x4EE62A0
        public void Multiply(){} // RVA: 0x94CFDF0
        public void MultiplyMinusProduct(){} // RVA: 0x94B65A0
        public void MultiplyPlusProduct(){} // RVA: 0x94CFF30
        public void Divide(){} // RVA: 0x94B67F0
        public void Negate(){} // RVA: 0x1A3F520
        public void Square(){} // RVA: 0x94D0160
        public void SquareMinusProduct(){} // RVA: 0x94B6920
        public void SquarePlusProduct(){} // RVA: 0x94D0240
        public void SquarePow(){} // RVA: 0x94D04F0
        public void HalfTrace(){} // RVA: 0x94D05F0
        public void get_HasFastTrace(){} // RVA: 0x3C2850
        public void Trace(){} // RVA: 0x947CF00
        public void Invert(){} // RVA: 0x94D06D0
        public void Sqrt(){} // RVA: 0x94D07B0
        public void get_Representation(){} // RVA: 0x3E2CB0
        public void get_M(){} // RVA: 0x94CFA80
        public void get_K1(){} // RVA: 0x13ADE30
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void Equals(){} // RVA: 0x94D0AF0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94D0B60
    }

    public class SecT193R1Curve
    {
        public int SECT193R1_DEFAULT_COORDS;
        public int SECT193R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94D0C10
        public void CloneCurve(){} // RVA: 0x94D10F0
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94CFA80
        public void FromBigInteger(){} // RVA: 0x94D1140
        public void CreateRawPoint(){} // RVA: 0x94D1290 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x94CFA80
        public void get_IsTrinomial(){} // RVA: 0x3C2850
        public void get_K1(){} // RVA: 0x13ADE30
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94D1330
    }

    public class SecT193R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94D1A80
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94D1B90
        public void Twice(){} // RVA: 0x94D2580
        public void TwicePlus(){} // RVA: 0x94D2A40
        public void Negate(){} // RVA: 0x94D3130
    }

    public class SecT193R2Curve
    {
        public int SECT193R2_DEFAULT_COORDS;
        public int SECT193R2_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94D32E0
        public void CloneCurve(){} // RVA: 0x94D37C0
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94CFA80
        public void FromBigInteger(){} // RVA: 0x94D3810
        public void CreateRawPoint(){} // RVA: 0x94D3960 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x94CFA80
        public void get_IsTrinomial(){} // RVA: 0x3C2850
        public void get_K1(){} // RVA: 0x13ADE30
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94D3A00
    }

    public class SecT193R2Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94D4150
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94D4260
        public void Twice(){} // RVA: 0x94D4C50
        public void TwicePlus(){} // RVA: 0x94D5110
        public void Negate(){} // RVA: 0x94D5800
    }

    public class SecT233Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94B4BF0
        public void AddExt(){} // RVA: 0x94D59B0
        public void AddOne(){} // RVA: 0x94CDF50
        public void AddTo(){} // RVA: 0x94CDFD0
        public void FromBigInteger(){} // RVA: 0x94D5B10
        public void HalfTrace(){} // RVA: 0x94D5B20
        public void Invert(){} // RVA: 0x94D5D90
        public void Multiply(){} // RVA: 0x94D6000
        public void MultiplyAddToExt(){} // RVA: 0x94D6090
        public void Reduce(){} // RVA: 0x94D6120
        public void Reduce23(){} // RVA: 0x94D62C0
        public void Sqrt(){} // RVA: 0x94D6340
        public void Square(){} // RVA: 0x94D65F0
        public void SquareAddToExt(){} // RVA: 0x94D66E0
        public void SquareN(){} // RVA: 0x94D67D0
        public void Trace(){} // RVA: 0x94D6980
        public void ImplCompactExt(){} // RVA: 0x94D69C0
        public void ImplExpand(){} // RVA: 0x94D6B10
        public void ImplMultiply(){} // RVA: 0x94D6BD0
        public void ImplMulwAcc(){} // RVA: 0x94D7210
        public void ImplSquare(){} // RVA: 0x94D7400
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SecT233FieldElement
    {
        public ulong[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x94CF990
        public void get_IsZero(){} // RVA: 0x94CF9F0
        public void TestBitZero(){} // RVA: 0x94B6020
        public void ToBigInteger(){} // RVA: 0x94CFA30
        public void get_FieldName(){} // RVA: 0x94D7550
        public void get_FieldSize(){} // RVA: 0x94D7590
        public void Add(){} // RVA: 0x94D75A0
        public void AddOne(){} // RVA: 0x94D77A0
        public void Subtract(){} // RVA: 0x4EE62A0
        public void Multiply(){} // RVA: 0x94D7900
        public void MultiplyMinusProduct(){} // RVA: 0x94B65A0
        public void MultiplyPlusProduct(){} // RVA: 0x94D7A40
        public void Divide(){} // RVA: 0x94B67F0
        public void Negate(){} // RVA: 0x1A3F520
        public void Square(){} // RVA: 0x94D7C70
        public void SquareMinusProduct(){} // RVA: 0x94B6920
        public void SquarePlusProduct(){} // RVA: 0x94D7D50
        public void SquarePow(){} // RVA: 0x94D7FF0
        public void HalfTrace(){} // RVA: 0x94D80F0
        public void get_HasFastTrace(){} // RVA: 0x3C2850
        public void Trace(){} // RVA: 0x94D81D0
        public void Invert(){} // RVA: 0x94D8210
        public void Sqrt(){} // RVA: 0x94D82F0
        public void get_Representation(){} // RVA: 0x3E2CB0
        public void get_M(){} // RVA: 0x94D7590
        public void get_K1(){} // RVA: 0x94D83D0
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void Equals(){} // RVA: 0x94D0AF0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94D8520
    }

    public class SecT233K1Curve
    {
        public int SECT233K1_DEFAULT_COORDS;
        public int SECT233K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94D85D0
        public void CloneCurve(){} // RVA: 0x94D8A10
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void CreateDefaultMultiplier(){} // RVA: 0x94D8A60
        public void get_FieldSize(){} // RVA: 0x94D7590
        public void FromBigInteger(){} // RVA: 0x94D8AA0
        public void CreateRawPoint(){} // RVA: 0x94D8BF0 | overloaded x2
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_IsKoblitz(){} // RVA: 0x3C2850
        public void get_M(){} // RVA: 0x94D7590
        public void get_IsTrinomial(){} // RVA: 0x3C2850
        public void get_K1(){} // RVA: 0x94D83D0
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94D8C90
    }

    public class SecT233K1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94D93E0
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94D94F0
        public void Twice(){} // RVA: 0x94D9E70
        public void TwicePlus(){} // RVA: 0x94DA370
        public void Negate(){} // RVA: 0x94DA9B0
    }

    public class SecT233R1Curve
    {
        public int SECT233R1_DEFAULT_COORDS;
        public int SECT233R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94DAB60
        public void CloneCurve(){} // RVA: 0x94DAFF0
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94D7590
        public void FromBigInteger(){} // RVA: 0x94DB040
        public void CreateRawPoint(){} // RVA: 0x94DB190 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x94D7590
        public void get_IsTrinomial(){} // RVA: 0x3C2850
        public void get_K1(){} // RVA: 0x94D83D0
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94DB230
    }

    public class SecT233R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94DB980
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94DBA90
        public void Twice(){} // RVA: 0x94DC470
        public void TwicePlus(){} // RVA: 0x94DC8F0
        public void Negate(){} // RVA: 0x94DCF80
    }

    public class SecT239Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94B4BF0
        public void AddExt(){} // RVA: 0x94D59B0
        public void AddOne(){} // RVA: 0x94CDF50
        public void AddTo(){} // RVA: 0x94CDFD0
        public void FromBigInteger(){} // RVA: 0x94DD130
        public void HalfTrace(){} // RVA: 0x94DD140
        public void Invert(){} // RVA: 0x94DD3B0
        public void Multiply(){} // RVA: 0x94DD660
        public void MultiplyAddToExt(){} // RVA: 0x94DD6F0
        public void Reduce(){} // RVA: 0x94DD780
        public void Reduce17(){} // RVA: 0x94DD920
        public void Sqrt(){} // RVA: 0x94DD9A0
        public void Square(){} // RVA: 0x94DDC90
        public void SquareAddToExt(){} // RVA: 0x94D66E0
        public void SquareN(){} // RVA: 0x94DDD80
        public void Trace(){} // RVA: 0x94DDF30
        public void ImplCompactExt(){} // RVA: 0x94DDF80
        public void ImplExpand(){} // RVA: 0x94DE0D0
        public void ImplMultiply(){} // RVA: 0x94DE190
        public void ImplMulwAcc(){} // RVA: 0x94DE7D0
        public void ImplSquare(){} // RVA: 0x94D7400
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SecT239FieldElement
    {
        public ulong[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x94CF990
        public void get_IsZero(){} // RVA: 0x94CF9F0
        public void TestBitZero(){} // RVA: 0x94B6020
        public void ToBigInteger(){} // RVA: 0x94CFA30
        public void get_FieldName(){} // RVA: 0x94DEAB0
        public void get_FieldSize(){} // RVA: 0x94DEAF0
        public void Add(){} // RVA: 0x94DEB00
        public void AddOne(){} // RVA: 0x94DED00
        public void Subtract(){} // RVA: 0x4EE62A0
        public void Multiply(){} // RVA: 0x94DEE60
        public void MultiplyMinusProduct(){} // RVA: 0x94B65A0
        public void MultiplyPlusProduct(){} // RVA: 0x94DEFA0
        public void Divide(){} // RVA: 0x94B67F0
        public void Negate(){} // RVA: 0x1A3F520
        public void Square(){} // RVA: 0x94DF1D0
        public void SquareMinusProduct(){} // RVA: 0x94B6920
        public void SquarePlusProduct(){} // RVA: 0x94DF2B0
        public void SquarePow(){} // RVA: 0x94DF550
        public void HalfTrace(){} // RVA: 0x94DF650
        public void get_HasFastTrace(){} // RVA: 0x3C2850
        public void Trace(){} // RVA: 0x94DF730
        public void Invert(){} // RVA: 0x94DF780
        public void Sqrt(){} // RVA: 0x94DF860
        public void get_Representation(){} // RVA: 0x3E2CB0
        public void get_M(){} // RVA: 0x94DEAF0
        public void get_K1(){} // RVA: 0x94DF940
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void Equals(){} // RVA: 0x94D0AF0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94DFA90
    }

    public class SecT239K1Curve
    {
        public int SECT239K1_DEFAULT_COORDS;
        public int SECT239K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94DFB40
        public void CloneCurve(){} // RVA: 0x94DFF80
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void CreateDefaultMultiplier(){} // RVA: 0x94DFFD0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94DEAF0
        public void FromBigInteger(){} // RVA: 0x94E0010
        public void CreateRawPoint(){} // RVA: 0x94E01E0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x3C2850
        public void get_M(){} // RVA: 0x94DEAF0
        public void get_IsTrinomial(){} // RVA: 0x3C2850
        public void get_K1(){} // RVA: 0x94DF940
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94E0280
    }

    public class SecT239K1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94E09D0
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94E0AE0
        public void Twice(){} // RVA: 0x94E1460
        public void TwicePlus(){} // RVA: 0x94E1960
        public void Negate(){} // RVA: 0x94E1FA0
    }

    public class SecT283Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94BC170
        public void AddExt(){} // RVA: 0x94E2150
        public void AddOne(){} // RVA: 0x94E22E0
        public void AddTo(){} // RVA: 0x94E2370
        public void FromBigInteger(){} // RVA: 0x94E2410
        public void HalfTrace(){} // RVA: 0x94E2420
        public void Invert(){} // RVA: 0x94E2630
        public void Multiply(){} // RVA: 0x94E2900
        public void MultiplyAddToExt(){} // RVA: 0x94E29C0
        public void Reduce(){} // RVA: 0x94E2A80
        public void Reduce37(){} // RVA: 0x94E2CB0
        public void Sqrt(){} // RVA: 0x94E2D30
        public void Square(){} // RVA: 0x94E2F20
        public void SquareAddToExt(){} // RVA: 0x94E2FD0
        public void SquareN(){} // RVA: 0x94E3080
        public void Trace(){} // RVA: 0x94E3180
        public void ImplCompactExt(){} // RVA: 0x94E31C0
        public void ImplExpand(){} // RVA: 0x94E3380
        public void ImplMultiply(){} // RVA: 0x94E3480
        public void ImplMulw(){} // RVA: 0x94E3B50
        public void ImplSquare(){} // RVA: 0x94E3D80
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x94E3EC0
    }

    public class SecT283FieldElement
    {
        public ulong[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x94E4120
        public void get_IsZero(){} // RVA: 0x94E4180
        public void TestBitZero(){} // RVA: 0x94B6020
        public void ToBigInteger(){} // RVA: 0x94E41C0
        public void get_FieldName(){} // RVA: 0x94E42C0
        public void get_FieldSize(){} // RVA: 0x94E4300
        public void Add(){} // RVA: 0x94E4310
        public void AddOne(){} // RVA: 0x94E4560
        public void Subtract(){} // RVA: 0x4EE62A0
        public void Multiply(){} // RVA: 0x94E4700
        public void MultiplyMinusProduct(){} // RVA: 0x94B65A0
        public void MultiplyPlusProduct(){} // RVA: 0x94E4870
        public void Divide(){} // RVA: 0x94B67F0
        public void Negate(){} // RVA: 0x1A3F520
        public void Square(){} // RVA: 0x94E4AC0
        public void SquareMinusProduct(){} // RVA: 0x94B6920
        public void SquarePlusProduct(){} // RVA: 0x94E4BC0
        public void SquarePow(){} // RVA: 0x94E4E40
        public void HalfTrace(){} // RVA: 0x94E4F70
        public void get_HasFastTrace(){} // RVA: 0x3C2850
        public void Trace(){} // RVA: 0x94E5070
        public void Invert(){} // RVA: 0x94E50F0
        public void Sqrt(){} // RVA: 0x94E51F0
        public void get_Representation(){} // RVA: 0xA308B0
        public void get_M(){} // RVA: 0x94E4300
        public void get_K1(){} // RVA: 0x66CCC0
        public void get_K2(){} // RVA: 0xA67BB0
        public void get_K3(){} // RVA: 0x210E2A0
        public void Equals(){} // RVA: 0x94E5430 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94E54A0
    }

    public class SecT283K1Curve
    {
        public int SECT283K1_DEFAULT_COORDS;
        public int SECT283K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94E5550
        public void CloneCurve(){} // RVA: 0x94E59B0
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void CreateDefaultMultiplier(){} // RVA: 0x94E5A00
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94E4300
        public void FromBigInteger(){} // RVA: 0x94E5A40
        public void CreateRawPoint(){} // RVA: 0x94E5B90 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x3C2850
        public void get_M(){} // RVA: 0x94E4300
        public void get_IsTrinomial(){} // RVA: 0x2DD320
        public void get_K1(){} // RVA: 0x66CCC0
        public void get_K2(){} // RVA: 0xA67BB0
        public void get_K3(){} // RVA: 0x210E2A0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94E5C30
    }

    public class SecT283K1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94E63D0
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94E64E0
        public void Twice(){} // RVA: 0x94E6E60
        public void TwicePlus(){} // RVA: 0x94E7360
        public void Negate(){} // RVA: 0x94E79A0
    }

    public class SecT283R1Curve
    {
        public int SECT283R1_DEFAULT_COORDS;
        public int SECT283R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94E7B50
        public void CloneCurve(){} // RVA: 0x94E8000
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94E4300
        public void FromBigInteger(){} // RVA: 0x94E8050
        public void CreateRawPoint(){} // RVA: 0x94E81A0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x94E4300
        public void get_IsTrinomial(){} // RVA: 0x2DD320
        public void get_K1(){} // RVA: 0x66CCC0
        public void get_K2(){} // RVA: 0xA67BB0
        public void get_K3(){} // RVA: 0x210E2A0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94E8240
    }

    public class SecT283R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94E89E0
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94E8AF0
        public void Twice(){} // RVA: 0x94E94D0
        public void TwicePlus(){} // RVA: 0x94E9950
        public void Negate(){} // RVA: 0x94E9FE0
    }

    public class SecT409Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94CDE10
        public void AddExt(){} // RVA: 0x94EA190
        public void AddOne(){} // RVA: 0x94EA200
        public void AddTo(){} // RVA: 0x94EA2C0
        public void FromBigInteger(){} // RVA: 0x94EA3A0
        public void HalfTrace(){} // RVA: 0x94EA3B0
        public void Invert(){} // RVA: 0x94EA5F0
        public void Multiply(){} // RVA: 0x94EA8B0
        public void MultiplyAddToExt(){} // RVA: 0x94EA940
        public void Reduce(){} // RVA: 0x94EAA00
        public void Reduce39(){} // RVA: 0x94EAC30
        public void Sqrt(){} // RVA: 0x94EACA0
        public void Square(){} // RVA: 0x94EAEE0
        public void SquareAddToExt(){} // RVA: 0x94EAF60
        public void SquareN(){} // RVA: 0x94EB010
        public void Trace(){} // RVA: 0x94B5970
        public void ImplCompactExt(){} // RVA: 0x94EB0D0
        public void ImplExpand(){} // RVA: 0x94EB370
        public void ImplMultiply(){} // RVA: 0x94EB4E0
        public void ImplMulwAcc(){} // RVA: 0x94EB5E0
        public void ImplSquare(){} // RVA: 0x94EB840
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SecT409FieldElement
    {
        public ulong[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x94EBB00
        public void get_IsZero(){} // RVA: 0x94EBB60
        public void TestBitZero(){} // RVA: 0x94B6020
        public void ToBigInteger(){} // RVA: 0x94EBBA0
        public void get_FieldName(){} // RVA: 0x94EBCA0
        public void get_FieldSize(){} // RVA: 0x94EBCE0
        public void Add(){} // RVA: 0x94EBCF0
        public void AddOne(){} // RVA: 0x94EBF70
        public void Subtract(){} // RVA: 0x4EE62A0
        public void Multiply(){} // RVA: 0x94EC120
        public void MultiplyMinusProduct(){} // RVA: 0x94B65A0
        public void MultiplyPlusProduct(){} // RVA: 0x94EC260
        public void Divide(){} // RVA: 0x94B67F0
        public void Negate(){} // RVA: 0x1A3F520
        public void Square(){} // RVA: 0x94EC490
        public void SquareMinusProduct(){} // RVA: 0x94B6920
        public void SquarePlusProduct(){} // RVA: 0x94EC570
        public void SquarePow(){} // RVA: 0x94EC7E0
        public void HalfTrace(){} // RVA: 0x94EC8E0
        public void get_HasFastTrace(){} // RVA: 0x3C2850
        public void Trace(){} // RVA: 0x947CF00
        public void Invert(){} // RVA: 0x94EC9C0
        public void Sqrt(){} // RVA: 0x94ECAA0
        public void get_Representation(){} // RVA: 0x3E2CB0
        public void get_M(){} // RVA: 0x94EBCE0
        public void get_K1(){} // RVA: 0x94ECB80
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void Equals(){} // RVA: 0x94ECCD0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94ECD40
    }

    public class SecT409K1Curve
    {
        public int SECT409K1_DEFAULT_COORDS;
        public int SECT409K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94ECDF0
        public void CloneCurve(){} // RVA: 0x94ED230
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void CreateDefaultMultiplier(){} // RVA: 0x94ED280
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94EBCE0
        public void FromBigInteger(){} // RVA: 0x94ED2C0
        public void CreateRawPoint(){} // RVA: 0x94ED410 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x3C2850
        public void get_M(){} // RVA: 0x94EBCE0
        public void get_IsTrinomial(){} // RVA: 0x3C2850
        public void get_K1(){} // RVA: 0x94ECB80
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94ED4B0
    }

    public class SecT409K1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94EDB00
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94EDC10
        public void Twice(){} // RVA: 0x94EE590
        public void TwicePlus(){} // RVA: 0x94EEA90
        public void Negate(){} // RVA: 0x94EF0D0
    }

    public class SecT409R1Curve
    {
        public int SECT409R1_DEFAULT_COORDS;
        public int SECT409R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94EF280
        public void CloneCurve(){} // RVA: 0x94EF710
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94EBCE0
        public void FromBigInteger(){} // RVA: 0x94EF760
        public void CreateRawPoint(){} // RVA: 0x94EF8B0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x94EBCE0
        public void get_IsTrinomial(){} // RVA: 0x3C2850
        public void get_K1(){} // RVA: 0x94ECB80
        public void get_K2(){} // RVA: 0x519240
        public void get_K3(){} // RVA: 0x519240
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94EF950
    }

    public class SecT409R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94EFFA0
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94F00B0
        public void Twice(){} // RVA: 0x94F0A90
        public void TwicePlus(){} // RVA: 0x94F0F10
        public void Negate(){} // RVA: 0x94F15A0
    }

    public class SecT571Field
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x94F17C0 | overloaded x2
        public void AddBothTo(){} // RVA: 0x94F1860
        public void AddExt(){} // RVA: 0x94F1900
        public void AddOne(){} // RVA: 0x94F1970
        public void AddTo(){} // RVA: 0x94F19E0
        public void FromBigInteger(){} // RVA: 0x94F1A30
        public void HalfTrace(){} // RVA: 0x94F1A40
        public void Invert(){} // RVA: 0x94F1C70
        public void Multiply(){} // RVA: 0x94F1FB0
        public void MultiplyAddToExt(){} // RVA: 0x94F2070
        public void Reduce(){} // RVA: 0x94F2170
        public void Reduce5(){} // RVA: 0x94F2330
        public void Sqrt(){} // RVA: 0x94F23B0
        public void Square(){} // RVA: 0x94F27A0
        public void SquareAddToExt(){} // RVA: 0x94F2850
        public void SquareN(){} // RVA: 0x94F2940
        public void Trace(){} // RVA: 0x94F2A40
        public void ImplMultiply(){} // RVA: 0x94F2A80
        public void ImplMulwAcc(){} // RVA: 0x94F2F80
        public void ImplSquare(){} // RVA: 0x94F31B0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x94F32E0
    }

    public class SecT571FieldElement
    {
        public ulong[] x; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x94F3540
        public void get_IsZero(){} // RVA: 0x94F35A0
        public void TestBitZero(){} // RVA: 0x94B6020
        public void ToBigInteger(){} // RVA: 0x94F35E0
        public void get_FieldName(){} // RVA: 0x94F36E0
        public void get_FieldSize(){} // RVA: 0x94F3720
        public void Add(){} // RVA: 0x94F3730
        public void AddOne(){} // RVA: 0x94F3900
        public void Subtract(){} // RVA: 0x4EE62A0
        public void Multiply(){} // RVA: 0x94F3A60
        public void MultiplyMinusProduct(){} // RVA: 0x94B65A0
        public void MultiplyPlusProduct(){} // RVA: 0x94F3BD0
        public void Divide(){} // RVA: 0x94B67F0
        public void Negate(){} // RVA: 0x1A3F520
        public void Square(){} // RVA: 0x94F3E20
        public void SquareMinusProduct(){} // RVA: 0x94B6920
        public void SquarePlusProduct(){} // RVA: 0x94F3F20
        public void SquarePow(){} // RVA: 0x94F41F0
        public void HalfTrace(){} // RVA: 0x94F4320
        public void get_HasFastTrace(){} // RVA: 0x3C2850
        public void Trace(){} // RVA: 0x94F4420
        public void Invert(){} // RVA: 0x94F44A0
        public void Sqrt(){} // RVA: 0x94F45A0
        public void get_Representation(){} // RVA: 0xA308B0
        public void get_M(){} // RVA: 0x94F3720
        public void get_K1(){} // RVA: 0x3E2CB0
        public void get_K2(){} // RVA: 0x66CCC0
        public void get_K3(){} // RVA: 0x5B1C70
        public void Equals(){} // RVA: 0x94F47E0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x94F4850
    }

    public class SecT571K1Curve
    {
        public int SECT571K1_DEFAULT_COORDS;
        public int SECT571K1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point m_infinity; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94F4900
        public void CloneCurve(){} // RVA: 0x94F4D60
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void CreateDefaultMultiplier(){} // RVA: 0x94F4DB0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94F3720
        public void FromBigInteger(){} // RVA: 0x94F4DF0
        public void CreateRawPoint(){} // RVA: 0x94F4F40 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x3C2850
        public void get_M(){} // RVA: 0x94F3720
        public void get_IsTrinomial(){} // RVA: 0x2DD320
        public void get_K1(){} // RVA: 0x3E2CB0
        public void get_K2(){} // RVA: 0x66CCC0
        public void get_K3(){} // RVA: 0x5B1C70
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94F4FE0
    }

    public class SecT571K1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94F5630
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94F5740
        public void Twice(){} // RVA: 0x94F60C0
        public void TwicePlus(){} // RVA: 0x94F65C0
        public void Negate(){} // RVA: 0x94F6C00
    }

    public class SecT571R1Curve
    {
        public int SECT571R1_DEFAULT_COORDS;
        public int SECT571R1_FE_LONGS;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point m_infinity; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement SecT571R1_B;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement SecT571R1_B_SQRT; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x94F6DB0
        public void CloneCurve(){} // RVA: 0x94F7230
        public void SupportsCoordinateSystem(){} // RVA: 0x94B77E0
        public void get_Infinity(){} // RVA: 0x3A5500
        public void get_FieldSize(){} // RVA: 0x94F3720
        public void FromBigInteger(){} // RVA: 0x94F7280
        public void CreateRawPoint(){} // RVA: 0x94F73D0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x2DD320
        public void get_M(){} // RVA: 0x94F3720
        public void get_IsTrinomial(){} // RVA: 0x2DD320
        public void get_K1(){} // RVA: 0x3E2CB0
        public void get_K2(){} // RVA: 0x66CCC0
        public void get_K3(){} // RVA: 0x5B1C70
        public void CreateCacheSafeLookupTable(){} // RVA: 0x94F7470
        public void .cctor(){} // RVA: 0x94F76F0
    }

    public class SecT571R1Point
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x947E360 | overloaded x3
        public void Detach(){} // RVA: 0x94F7D50
        public void get_YCoord(){} // RVA: 0x94B81B0
        public void get_CompressionYTilde(){} // RVA: 0x94B82C0
        public void Add(){} // RVA: 0x94F7E60
        public void Twice(){} // RVA: 0x94F8820
        public void TwicePlus(){} // RVA: 0x94F8C90
        public void Negate(){} // RVA: 0x94F9310
    }

}