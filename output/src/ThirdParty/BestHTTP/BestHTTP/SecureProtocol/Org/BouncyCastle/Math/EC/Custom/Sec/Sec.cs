// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
// Classes: 100
// Methods: 1663

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
    public class SecP128R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA83080
        public void CloneCurve(){} // RVA: 0x7FFACBA834B0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBA83510
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBA83570
        public void FromBigInteger(){} // RVA: 0x7FFACBA835E0
        public void CreateRawPoint(){} // RVA: 0x7FFACBA83820 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBA838C0
        public void .cctor(){} // RVA: 0x7FFACBA83C30
    }

    public class SecP128R1Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint[] PExtInv; // 0x10
        public uint P3;
        public uint PExt7;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBA84000
        public void AddExt(){} // RVA: 0x7FFACBA84240
        public void AddOne(){} // RVA: 0x7FFACBA843C0
        public void FromBigInteger(){} // RVA: 0x7FFACBA84580
        public void Half(){} // RVA: 0x7FFACBA84830
        public void Multiply(){} // RVA: 0x7FFACBA84A10
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBA84AD0
        public void Negate(){} // RVA: 0x7FFACBA84C50
        public void Reduce(){} // RVA: 0x7FFACBA84DE0
        public void Reduce32(){} // RVA: 0x7FFACBA84F30
        public void Square(){} // RVA: 0x7FFACBA850F0
        public void SquareN(){} // RVA: 0x7FFACBA851A0
        public void Subtract(){} // RVA: 0x7FFACBA852A0
        public void SubtractExt(){} // RVA: 0x7FFACBA85440
        public void Twice(){} // RVA: 0x7FFACBA85580
        public void AddPInvTo(){} // RVA: 0x7FFACBA85720
        public void SubPInvFrom(){} // RVA: 0x7FFACBA857B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA85820
    }

    public class SecP128R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBA85C10
        public void get_IsOne(){} // RVA: 0x7FFACBA85C50
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBA85CE0
        public void get_FieldName(){} // RVA: 0x7FFACBA85E20
        public void get_FieldSize(){} // RVA: 0x7FFACBA85E60
        public void Add(){} // RVA: 0x7FFACBA85ED0
        public void AddOne(){} // RVA: 0x7FFACBA86040
        public void Subtract(){} // RVA: 0x7FFACBA86140
        public void Multiply(){} // RVA: 0x7FFACBA862B0
        public void Divide(){} // RVA: 0x7FFACBA86420
        public void Negate(){} // RVA: 0x7FFACBA865E0
        public void Square(){} // RVA: 0x7FFACBA866E0
        public void Invert(){} // RVA: 0x7FFACBA867E0
        public void Sqrt(){} // RVA: 0x7FFACBA86930
        public void Equals(){} // RVA: 0x7FFACBA86D90 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBA86E00
        public void .cctor(){} // RVA: 0x7FFACBA86F00
    }

    public class SecP128R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBA87130
        public void Add(){} // RVA: 0x7FFACBA87240
        public void Twice(){} // RVA: 0x7FFACBA87CE0
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBA88520
    }

    public class SecP160K1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA88620
        public void CloneCurve(){} // RVA: 0x7FFACBA889C0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBA88A10
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBA88A70
        public void FromBigInteger(){} // RVA: 0x7FFACBA88AE0
        public void CreateRawPoint(){} // RVA: 0x7FFACBA88C30 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBA88CD0
        public void .cctor(){} // RVA: 0x7FFACBA89080
    }

    public class SecP160K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBA89520
        public void Add(){} // RVA: 0x7FFACBA89630
        public void Twice(){} // RVA: 0x7FFACBA89F90
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBA8A7B0
    }

    public class SecP160R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA8A8B0
        public void CloneCurve(){} // RVA: 0x7FFACBA8ACE0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBA8AD30
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBA8AD90
        public void FromBigInteger(){} // RVA: 0x7FFACBA8AE00
        public void CreateRawPoint(){} // RVA: 0x7FFACBA8AF50 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBA8AFF0
        public void .cctor(){} // RVA: 0x7FFACBA8B3A0
    }

    public class SecP160R1Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint[] PExtInv; // 0x10
        public uint P4;
        public uint PExt9;
        public uint PInv;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBA8B770
        public void AddExt(){} // RVA: 0x7FFACBA8B8A0
        public void AddOne(){} // RVA: 0x7FFACBA8BAC0
        public void FromBigInteger(){} // RVA: 0x7FFACBA8BC40
        public void Half(){} // RVA: 0x7FFACBA8BD30
        public void Multiply(){} // RVA: 0x7FFACBA8BE60
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBA8BF20
        public void Negate(){} // RVA: 0x7FFACBA8C100
        public void Reduce(){} // RVA: 0x7FFACBA8C1E0
        public void Reduce32(){} // RVA: 0x7FFACBA8C360
        public void Square(){} // RVA: 0x7FFACBA8C4D0
        public void SquareN(){} // RVA: 0x7FFACBA8C580
        public void Subtract(){} // RVA: 0x7FFACBA8C680
        public void SubtractExt(){} // RVA: 0x7FFACBA8C700
        public void Twice(){} // RVA: 0x7FFACBA8C8A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA8C9F0
    }

    public class SecP160R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBA8CEC0
        public void get_IsOne(){} // RVA: 0x7FFACBA8CF00
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBA8CF60
        public void get_FieldName(){} // RVA: 0x7FFACBA8CF70
        public void get_FieldSize(){} // RVA: 0x7FFACBA8CFB0
        public void Add(){} // RVA: 0x7FFACBA8D020
        public void AddOne(){} // RVA: 0x7FFACBA8D190
        public void Subtract(){} // RVA: 0x7FFACBA8D290
        public void Multiply(){} // RVA: 0x7FFACBA8D460
        public void Divide(){} // RVA: 0x7FFACBA8D5D0
        public void Negate(){} // RVA: 0x7FFACBA8D790
        public void Square(){} // RVA: 0x7FFACBA8D890
        public void Invert(){} // RVA: 0x7FFACBA8D990
        public void Sqrt(){} // RVA: 0x7FFACBA8DAE0
        public void Equals(){} // RVA: 0x7FFACBA8DF00 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBA8DF70
        public void .cctor(){} // RVA: 0x7FFACBA8E070
    }

    public class SecP160R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBA8E280
        public void Add(){} // RVA: 0x7FFACBA8E390
        public void Twice(){} // RVA: 0x7FFACBA8EDA0
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBA8F750
    }

    public class SecP160R2Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA8F850
        public void CloneCurve(){} // RVA: 0x7FFACBA8FC80
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBA8FCD0
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBA8FD30
        public void FromBigInteger(){} // RVA: 0x7FFACBA8FDA0
        public void CreateRawPoint(){} // RVA: 0x7FFACBA8FEF0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBA8FF90
        public void .cctor(){} // RVA: 0x7FFACBA90340
    }

    public class SecP160R2Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint[] PExtInv; // 0x10
        public uint P4;
        public uint PExt9;
        public uint PInv33;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBA90710
        public void AddExt(){} // RVA: 0x7FFACBA90860
        public void AddOne(){} // RVA: 0x7FFACBA90A80
        public void FromBigInteger(){} // RVA: 0x7FFACBA90C20
        public void Half(){} // RVA: 0x7FFACBA90D10
        public void Multiply(){} // RVA: 0x7FFACBA90E40
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBA90F00
        public void Negate(){} // RVA: 0x7FFACBA910E0
        public void Reduce(){} // RVA: 0x7FFACBA911C0
        public void Reduce32(){} // RVA: 0x7FFACBA913C0
        public void Square(){} // RVA: 0x7FFACBA91570
        public void SquareN(){} // RVA: 0x7FFACBA91620
        public void Subtract(){} // RVA: 0x7FFACBA91720
        public void SubtractExt(){} // RVA: 0x7FFACBA917B0
        public void Twice(){} // RVA: 0x7FFACBA91950
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA91AC0
    }

    public class SecP160R2FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBA8CEC0
        public void get_IsOne(){} // RVA: 0x7FFACBA8CF00
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBA8CF60
        public void get_FieldName(){} // RVA: 0x7FFACBA91F00
        public void get_FieldSize(){} // RVA: 0x7FFACBA91F40
        public void Add(){} // RVA: 0x7FFACBA91FB0
        public void AddOne(){} // RVA: 0x7FFACBA92120
        public void Subtract(){} // RVA: 0x7FFACBA92220
        public void Multiply(){} // RVA: 0x7FFACBA92410
        public void Divide(){} // RVA: 0x7FFACBA92580
        public void Negate(){} // RVA: 0x7FFACBA92740
        public void Square(){} // RVA: 0x7FFACBA92840
        public void Invert(){} // RVA: 0x7FFACBA92940
        public void Sqrt(){} // RVA: 0x7FFACBA92A90
        public void Equals(){} // RVA: 0x7FFACBA8DF00 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBA93060
        public void .cctor(){} // RVA: 0x7FFACBA93160
    }

    public class SecP160R2Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBA93370
        public void Add(){} // RVA: 0x7FFACBA93480
        public void Twice(){} // RVA: 0x7FFACBA93DE0
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBA946F0
    }

    public class SecP192K1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA947F0
        public void CloneCurve(){} // RVA: 0x7FFACBA94B90
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBA94BE0
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBA94C40
        public void FromBigInteger(){} // RVA: 0x7FFACBA94CB0
        public void CreateRawPoint(){} // RVA: 0x7FFACBA94E00 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBA94EA0
        public void .cctor(){} // RVA: 0x7FFACBA95120
    }

    public class SecP192K1Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint[] PExtInv; // 0x10
        public uint P5;
        public uint PExt11;
        public uint PInv33;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBA954F0
        public void AddExt(){} // RVA: 0x7FFACBA95640
        public void AddOne(){} // RVA: 0x7FFACBA95860
        public void FromBigInteger(){} // RVA: 0x7FFACBA95A00
        public void Half(){} // RVA: 0x7FFACBA95AF0
        public void Multiply(){} // RVA: 0x7FFACBA95C20
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBA95CE0
        public void Negate(){} // RVA: 0x7FFACBA95EC0
        public void Reduce(){} // RVA: 0x7FFACBA95FB0
        public void Reduce32(){} // RVA: 0x7FFACBA96190
        public void Square(){} // RVA: 0x7FFACBA96340
        public void SquareN(){} // RVA: 0x7FFACBA963F0
        public void Subtract(){} // RVA: 0x7FFACBA964F0
        public void SubtractExt(){} // RVA: 0x7FFACBA96580
        public void Twice(){} // RVA: 0x7FFACBA96720
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA96890
    }

    public class SecP192K1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBA96D60
        public void get_IsOne(){} // RVA: 0x7FFACBA96DA0
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBA96E00
        public void get_FieldName(){} // RVA: 0x7FFACBA96E10
        public void get_FieldSize(){} // RVA: 0x7FFACBA96E50
        public void Add(){} // RVA: 0x7FFACBA96EC0
        public void AddOne(){} // RVA: 0x7FFACBA97130
        public void Subtract(){} // RVA: 0x7FFACBA97230
        public void Multiply(){} // RVA: 0x7FFACBA97420
        public void Divide(){} // RVA: 0x7FFACBA97590
        public void Negate(){} // RVA: 0x7FFACBA97750
        public void Square(){} // RVA: 0x7FFACBA97850
        public void Invert(){} // RVA: 0x7FFACBA97950
        public void Sqrt(){} // RVA: 0x7FFACBA97AA0
        public void Equals(){} // RVA: 0x7FFACBA97FF0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBA98060
        public void .cctor(){} // RVA: 0x7FFACBA98160
    }

    public class SecP192K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBA98370
        public void Add(){} // RVA: 0x7FFACBA98480
        public void Twice(){} // RVA: 0x7FFACBA98DE0
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBA99600
    }

    public class SecP192R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA99700
        public void CloneCurve(){} // RVA: 0x7FFACBA99B30
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBA99B80
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBA99BE0
        public void FromBigInteger(){} // RVA: 0x7FFACBA99C50
        public void CreateRawPoint(){} // RVA: 0x7FFACBA99DA0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBA99E40
        public void .cctor(){} // RVA: 0x7FFACBA9A0C0
    }

    public class SecP192R1Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint[] PExtInv; // 0x10
        public uint P5;
        public uint PExt11;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBA9A490
        public void AddExt(){} // RVA: 0x7FFACBA9A5A0
        public void AddOne(){} // RVA: 0x7FFACBA9A7C0
        public void FromBigInteger(){} // RVA: 0x7FFACBA9A920
        public void Half(){} // RVA: 0x7FFACBA9AA10
        public void Multiply(){} // RVA: 0x7FFACBA9AB40
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBA9AC00
        public void Negate(){} // RVA: 0x7FFACBA9ADE0
        public void Reduce(){} // RVA: 0x7FFACBA9AED0
        public void Reduce32(){} // RVA: 0x7FFACBA9B160
        public void Square(){} // RVA: 0x7FFACBA9B2C0
        public void SquareN(){} // RVA: 0x7FFACBA9B370
        public void Subtract(){} // RVA: 0x7FFACBA9B470
        public void SubtractExt(){} // RVA: 0x7FFACBA9B580
        public void Twice(){} // RVA: 0x7FFACBA9B720
        public void AddPInvTo(){} // RVA: 0x7FFACBA9B860
        public void SubPInvFrom(){} // RVA: 0x7FFACBA9B910
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBA9B9B0
    }

    public class SecP192R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBA96D60
        public void get_IsOne(){} // RVA: 0x7FFACBA96DA0
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBA96E00
        public void get_FieldName(){} // RVA: 0x7FFACBA9BDF0
        public void get_FieldSize(){} // RVA: 0x7FFACBA9BE30
        public void Add(){} // RVA: 0x7FFACBA9BEA0
        public void AddOne(){} // RVA: 0x7FFACBA9C010
        public void Subtract(){} // RVA: 0x7FFACBA9C250
        public void Multiply(){} // RVA: 0x7FFACBA9C3C0
        public void Divide(){} // RVA: 0x7FFACBA9C530
        public void Negate(){} // RVA: 0x7FFACBA9C6F0
        public void Square(){} // RVA: 0x7FFACBA9C7F0
        public void Invert(){} // RVA: 0x7FFACBA9C8F0
        public void Sqrt(){} // RVA: 0x7FFACBA9CA40
        public void Equals(){} // RVA: 0x7FFACBA97FF0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBA9CE70
        public void .cctor(){} // RVA: 0x7FFACBA9CF70
    }

    public class SecP192R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBA9D180
        public void Add(){} // RVA: 0x7FFACBA9D290
        public void Twice(){} // RVA: 0x7FFACBA9DBF0
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBA9E3D0
    }

    public class SecP224K1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA9E4D0
        public void CloneCurve(){} // RVA: 0x7FFACBA9E870
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBA9E8C0
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBA9E920
        public void FromBigInteger(){} // RVA: 0x7FFACBA9E990
        public void CreateRawPoint(){} // RVA: 0x7FFACBA9EAE0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBA9EB80
        public void .cctor(){} // RVA: 0x7FFACBA9EE00
    }

    public class SecP224K1Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint[] PExtInv; // 0x10
        public uint P6;
        public uint PExt13;
        public uint PInv33;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBA9F1D0
        public void AddExt(){} // RVA: 0x7FFACBA9F320
        public void AddOne(){} // RVA: 0x7FFACBA9F540
        public void FromBigInteger(){} // RVA: 0x7FFACBA9F6E0
        public void Half(){} // RVA: 0x7FFACBA9F7D0
        public void Multiply(){} // RVA: 0x7FFACBA9F900
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBA9F9C0
        public void Negate(){} // RVA: 0x7FFACBA9FBA0
        public void Reduce(){} // RVA: 0x7FFACBA9FCA0
        public void Reduce32(){} // RVA: 0x7FFACBA9FE80
        public void Square(){} // RVA: 0x7FFACBAA0030
        public void SquareN(){} // RVA: 0x7FFACBAA00E0
        public void Subtract(){} // RVA: 0x7FFACBAA01E0
        public void SubtractExt(){} // RVA: 0x7FFACBAA0270
        public void Twice(){} // RVA: 0x7FFACBAA0410
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBAA0580
    }

    public class SecP224K1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x8
        public uint[] FieldName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBAA0A50
        public void get_IsOne(){} // RVA: 0x7FFACBAA0A90
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBAA0AF0
        public void get_FieldName(){} // RVA: 0x7FFACBAA0B00
        public void get_FieldSize(){} // RVA: 0x7FFACBAA0B40
        public void Add(){} // RVA: 0x7FFACBAA0BB0
        public void AddOne(){} // RVA: 0x7FFACBAA0E20
        public void Subtract(){} // RVA: 0x7FFACBAA0F20
        public void Multiply(){} // RVA: 0x7FFACBAA1110
        public void Divide(){} // RVA: 0x7FFACBAA1280
        public void Negate(){} // RVA: 0x7FFACBAA1440
        public void Square(){} // RVA: 0x7FFACBAA1540
        public void Invert(){} // RVA: 0x7FFACBAA1640
        public void Sqrt(){} // RVA: 0x7FFACBAA1790
        public void Equals(){} // RVA: 0x7FFACBAA1DE0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAA1E50
        public void .cctor(){} // RVA: 0x7FFACBAA1F50
    }

    public class SecP224K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAA2230
        public void Add(){} // RVA: 0x7FFACBAA2340
        public void Twice(){} // RVA: 0x7FFACBAA2CA0
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBAA34C0
    }

    public class SecP224R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAA35C0
        public void CloneCurve(){} // RVA: 0x7FFACBAA39F0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBAA3A40
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBAA3AA0
        public void FromBigInteger(){} // RVA: 0x7FFACBAA3B10
        public void CreateRawPoint(){} // RVA: 0x7FFACBAA3C60 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAA3D00
        public void .cctor(){} // RVA: 0x7FFACBAA3F80
    }

    public class SecP224R1Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint[] PExtInv; // 0x10
        public uint P6;
        public uint PExt13;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBAA4350
        public void AddExt(){} // RVA: 0x7FFACBAA4460
        public void AddOne(){} // RVA: 0x7FFACBAA4680
        public void FromBigInteger(){} // RVA: 0x7FFACBAA47E0
        public void Half(){} // RVA: 0x7FFACBAA48D0
        public void Multiply(){} // RVA: 0x7FFACBAA4A00
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBAA4AC0
        public void Negate(){} // RVA: 0x7FFACBAA4CA0
        public void Reduce(){} // RVA: 0x7FFACBAA4DA0
        public void Reduce32(){} // RVA: 0x7FFACBAA5060
        public void Square(){} // RVA: 0x7FFACBAA51E0
        public void SquareN(){} // RVA: 0x7FFACBAA5290
        public void Subtract(){} // RVA: 0x7FFACBAA5390
        public void SubtractExt(){} // RVA: 0x7FFACBAA54C0
        public void Twice(){} // RVA: 0x7FFACBAA5660
        public void AddPInvTo(){} // RVA: 0x7FFACBAA57A0
        public void SubPInvFrom(){} // RVA: 0x7FFACBAA5840
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBAA5910
    }

    public class SecP224R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBAA0A50
        public void get_IsOne(){} // RVA: 0x7FFACBAA0A90
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBAA0AF0
        public void get_FieldName(){} // RVA: 0x7FFACBAA5D50
        public void get_FieldSize(){} // RVA: 0x7FFACBAA5D90
        public void Add(){} // RVA: 0x7FFACBAA5E00
        public void AddOne(){} // RVA: 0x7FFACBAA5F70
        public void Subtract(){} // RVA: 0x7FFACBAA6070
        public void Multiply(){} // RVA: 0x7FFACBAA61E0
        public void Divide(){} // RVA: 0x7FFACBAA6350
        public void Negate(){} // RVA: 0x7FFACBAA6510
        public void Square(){} // RVA: 0x7FFACBAA6610
        public void Invert(){} // RVA: 0x7FFACBAA6710
        public void Sqrt(){} // RVA: 0x7FFACBAA6860
        public void Equals(){} // RVA: 0x7FFACBAA1DE0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAA6D90
        public void IsSquare(){} // RVA: 0x7FFACBAA6E90
        public void RM(){} // RVA: 0x7FFACBAA7180
        public void RP(){} // RVA: 0x7FFACBAA7370
        public void RS(){} // RVA: 0x7FFACBAA7780
        public void TrySqrt(){} // RVA: 0x7FFACBAA7890
        public void .cctor(){} // RVA: 0x7FFACBAA7D90
    }

    public class SecP224R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAA7FA0
        public void Add(){} // RVA: 0x7FFACBAA80B0
        public void Twice(){} // RVA: 0x7FFACBAA8A10
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBAA90D0
    }

    public class SecP256K1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAA91D0
        public void CloneCurve(){} // RVA: 0x7FFACBAA9570
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBAA95C0
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBAA9620
        public void FromBigInteger(){} // RVA: 0x7FFACBAA9690
        public void CreateRawPoint(){} // RVA: 0x7FFACBAA97E0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAA9880
        public void .cctor(){} // RVA: 0x7FFACBAA9B00
    }

    public class SecP256K1Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint[] PExtInv; // 0x10
        public uint P7;
        public uint PExt15;
        public uint PInv33;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBAA9ED0
        public void AddExt(){} // RVA: 0x7FFACBAAA020
        public void AddOne(){} // RVA: 0x7FFACBAAA240
        public void FromBigInteger(){} // RVA: 0x7FFACBAAA3E0
        public void Half(){} // RVA: 0x7FFACBAAA4D0
        public void Multiply(){} // RVA: 0x7FFACBAAA600
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBAAA6C0
        public void Negate(){} // RVA: 0x7FFACBAAA8A0
        public void Reduce(){} // RVA: 0x7FFACBAAA9B0
        public void Reduce32(){} // RVA: 0x7FFACBAAAB90
        public void Square(){} // RVA: 0x7FFACBAAAD40
        public void SquareN(){} // RVA: 0x7FFACBAAADF0
        public void Subtract(){} // RVA: 0x7FFACBAAAEF0
        public void SubtractExt(){} // RVA: 0x7FFACBAAAF80
        public void Twice(){} // RVA: 0x7FFACBAAB120
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBAAB290
    }

    public class SecP256K1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBAAB760
        public void get_IsOne(){} // RVA: 0x7FFACBAAB7A0
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBAAB800
        public void get_FieldName(){} // RVA: 0x7FFACBAAB810
        public void get_FieldSize(){} // RVA: 0x7FFACBAAB850
        public void Add(){} // RVA: 0x7FFACBAAB8C0
        public void AddOne(){} // RVA: 0x7FFACBAABB30
        public void Subtract(){} // RVA: 0x7FFACBAABC30
        public void Multiply(){} // RVA: 0x7FFACBAABE20
        public void Divide(){} // RVA: 0x7FFACBAABF90
        public void Negate(){} // RVA: 0x7FFACBAAC150
        public void Square(){} // RVA: 0x7FFACBAAC250
        public void Invert(){} // RVA: 0x7FFACBAAC350
        public void Sqrt(){} // RVA: 0x7FFACBAAC4A0
        public void Equals(){} // RVA: 0x7FFACBAACA70 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAACAE0
        public void .cctor(){} // RVA: 0x7FFACBAACBE0
    }

    public class SecP256K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAACDF0
        public void Add(){} // RVA: 0x7FFACBAACF00
        public void Twice(){} // RVA: 0x7FFACBAAD860
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBAAE080
    }

    public class SecP256R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAAE180
        public void CloneCurve(){} // RVA: 0x7FFACBAAE5B0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBAAE600
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBAAE660
        public void FromBigInteger(){} // RVA: 0x7FFACBAAE6D0
        public void CreateRawPoint(){} // RVA: 0x7FFACBAAE820 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAAE8C0
        public void .cctor(){} // RVA: 0x7FFACBAAEB40
    }

    public class SecP256R1Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint P7;
        public uint PExt15;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBAAEF10
        public void AddExt(){} // RVA: 0x7FFACBAAF020
        public void AddOne(){} // RVA: 0x7FFACBAAF1D0
        public void FromBigInteger(){} // RVA: 0x7FFACBAAF330
        public void Half(){} // RVA: 0x7FFACBAAF420
        public void Multiply(){} // RVA: 0x7FFACBAAF550
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBAAF610
        public void Negate(){} // RVA: 0x7FFACBAAF780
        public void Reduce(){} // RVA: 0x7FFACBAAF890
        public void Reduce32(){} // RVA: 0x7FFACBAAFB00
        public void Square(){} // RVA: 0x7FFACBAAFCE0
        public void SquareN(){} // RVA: 0x7FFACBAAFD90
        public void Subtract(){} // RVA: 0x7FFACBAAFE90
        public void SubtractExt(){} // RVA: 0x7FFACBAAFFD0
        public void Twice(){} // RVA: 0x7FFACBAB0100
        public void AddPInvTo(){} // RVA: 0x7FFACBAB0240
        public void SubPInvFrom(){} // RVA: 0x7FFACBAB0340
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBAB0420
    }

    public class SecP256R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBAAB760
        public void get_IsOne(){} // RVA: 0x7FFACBAAB7A0
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBAAB800
        public void get_FieldName(){} // RVA: 0x7FFACBAB07C0
        public void get_FieldSize(){} // RVA: 0x7FFACBAB0800
        public void Add(){} // RVA: 0x7FFACBAB0870
        public void AddOne(){} // RVA: 0x7FFACBAB09E0
        public void Subtract(){} // RVA: 0x7FFACBAB0C20
        public void Multiply(){} // RVA: 0x7FFACBAB0D90
        public void Divide(){} // RVA: 0x7FFACBAB0F00
        public void Negate(){} // RVA: 0x7FFACBAB10C0
        public void Square(){} // RVA: 0x7FFACBAB11C0
        public void Invert(){} // RVA: 0x7FFACBAB12C0
        public void Sqrt(){} // RVA: 0x7FFACBAB1410
        public void Equals(){} // RVA: 0x7FFACBAACA70 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAB1840
        public void .cctor(){} // RVA: 0x7FFACBAB1940
    }

    public class SecP256R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAB1B50
        public void Add(){} // RVA: 0x7FFACBAB1C60
        public void Twice(){} // RVA: 0x7FFACBAB2700
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBAB2EE0
    }

    public class SecP384R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAB2FE0
        public void CloneCurve(){} // RVA: 0x7FFACBAB3410
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBAB3460
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBAB34C0
        public void FromBigInteger(){} // RVA: 0x7FFACBAB3530
        public void CreateRawPoint(){} // RVA: 0x7FFACBAB3680 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAB3720
        public void .cctor(){} // RVA: 0x7FFACBAB39B0
    }

    public class SecP384R1Field : Object
    {
        public uint[] P;
        public uint[] PExt; // 0x8
        public uint[] PExtInv; // 0x10
        public uint P11;
        public uint PExt23;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBAB3D80
        public void AddExt(){} // RVA: 0x7FFACBAB3EE0
        public void AddOne(){} // RVA: 0x7FFACBAB4100
        public void FromBigInteger(){} // RVA: 0x7FFACBAB4260
        public void Half(){} // RVA: 0x7FFACBAB43A0
        public void Multiply(){} // RVA: 0x7FFACBAB4510
        public void Negate(){} // RVA: 0x7FFACBAB45D0
        public void Reduce(){} // RVA: 0x7FFACBAB4710
        public void Reduce32(){} // RVA: 0x7FFACBAB4A80
        public void Square(){} // RVA: 0x7FFACBAB4C30
        public void SquareN(){} // RVA: 0x7FFACBAB4CE0
        public void Subtract(){} // RVA: 0x7FFACBAB4DE0
        public void SubtractExt(){} // RVA: 0x7FFACBAB4F70
        public void Twice(){} // RVA: 0x7FFACBAB5110
        public void AddPInvTo(){} // RVA: 0x7FFACBAB5250
        public void SubPInvFrom(){} // RVA: 0x7FFACBAB5320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBAB53F0
    }

    public class SecP384R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBAB5900
        public void get_IsOne(){} // RVA: 0x7FFACBAB5960
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBAB59C0
        public void get_FieldName(){} // RVA: 0x7FFACBAB59E0
        public void get_FieldSize(){} // RVA: 0x7FFACBAB5A20
        public void Add(){} // RVA: 0x7FFACBAB5A90
        public void AddOne(){} // RVA: 0x7FFACBAB5D20
        public void Subtract(){} // RVA: 0x7FFACBAB5F60
        public void Multiply(){} // RVA: 0x7FFACBAB60D0
        public void Divide(){} // RVA: 0x7FFACBAB6240
        public void Negate(){} // RVA: 0x7FFACBAB6400
        public void Square(){} // RVA: 0x7FFACBAB6500
        public void Invert(){} // RVA: 0x7FFACBAB6600
        public void Sqrt(){} // RVA: 0x7FFACBAB6750
        public void Equals(){} // RVA: 0x7FFACBAB6CD0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAB6D40
        public void .cctor(){} // RVA: 0x7FFACBAB6E40
    }

    public class SecP384R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAB7050
        public void Add(){} // RVA: 0x7FFACBAB7160
        public void Twice(){} // RVA: 0x7FFACBAB7B70
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBAB8450
    }

    public class SecP521R1Curve : AbstractFpCurve
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Q;
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Point m_infinity; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAB8550
        public void CloneCurve(){} // RVA: 0x7FFACBAB8980
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBA83500
        public void get_Q(){} // RVA: 0x7FFACBAB89D0
        public void get_Infinity(){} // RVA: 0x7FFAC2FC20E0
        public void get_FieldSize(){} // RVA: 0x7FFACBAB8A30
        public void FromBigInteger(){} // RVA: 0x7FFACBAB8AA0
        public void CreateRawPoint(){} // RVA: 0x7FFACBAB8BF0 | overloaded x2
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAB8C90
        public void .cctor(){} // RVA: 0x7FFACBAB8F20
    }

    public class SecP521R1Field : Object
    {
        public uint[] P;
        public int P16;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBAB92F0
        public void AddOne(){} // RVA: 0x7FFACBAB9470
        public void FromBigInteger(){} // RVA: 0x7FFACBAB9610
        public void Half(){} // RVA: 0x7FFACBAB96E0
        public void Multiply(){} // RVA: 0x7FFACBAB9770
        public void Negate(){} // RVA: 0x7FFACBAB9900
        public void Reduce(){} // RVA: 0x7FFACBAB9A40
        public void Reduce23(){} // RVA: 0x7FFACBAB9BF0
        public void Square(){} // RVA: 0x7FFACBAB9D30
        public void SquareN(){} // RVA: 0x7FFACBAB9E70
        public void Subtract(){} // RVA: 0x7FFACBABA0A0
        public void Twice(){} // RVA: 0x7FFACBABA180
        public void ImplMultiply(){} // RVA: 0x7FFACBABA210
        public void ImplSquare(){} // RVA: 0x7FFACBABA320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBABA3D0
    }

    public class SecP521R1FieldElement : AbstractFpFieldElement
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IsZero;
        public uint[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsZero(){} // RVA: 0x7FFACBABA720
        public void get_IsOne(){} // RVA: 0x7FFACBABA780
        public void TestBitZero(){} // RVA: 0x7FFACBA85CB0
        public void ToBigInteger(){} // RVA: 0x7FFACBABA7E0
        public void get_FieldName(){} // RVA: 0x7FFACBABA800
        public void get_FieldSize(){} // RVA: 0x7FFACBABA840
        public void Add(){} // RVA: 0x7FFACBABA8B0
        public void AddOne(){} // RVA: 0x7FFACBABAB70
        public void Subtract(){} // RVA: 0x7FFACBABADF0
        public void Multiply(){} // RVA: 0x7FFACBABB020
        public void Divide(){} // RVA: 0x7FFACBABB190
        public void Negate(){} // RVA: 0x7FFACBABB350
        public void Square(){} // RVA: 0x7FFACBABB570
        public void Invert(){} // RVA: 0x7FFACBABB670
        public void Sqrt(){} // RVA: 0x7FFACBABB7C0
        public void Equals(){} // RVA: 0x7FFACBABBAF0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBABBB60
        public void .cctor(){} // RVA: 0x7FFACBABBC60
    }

    public class SecP521R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBABBE70
        public void Add(){} // RVA: 0x7FFACBABBF80
        public void Twice(){} // RVA: 0x7FFACBABCD20
        public void TwicePlus(){} // RVA: 0x7FFACBA883A0
        public void ThreeTimes(){} // RVA: 0x7FFACBA884A0
        public void Negate(){} // RVA: 0x7FFACBABD830
    }

    public class SecT113Field : Object
    {
        public ulong M49;
        public ulong M57;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBABD930
        public void AddExt(){} // RVA: 0x7FFACBABD9A0
        public void AddOne(){} // RVA: 0x7FFACBABDA50
        public void AddTo(){} // RVA: 0x7FFACBABDAA0
        public void FromBigInteger(){} // RVA: 0x7FFACBABDAF0
        public void HalfTrace(){} // RVA: 0x7FFACBABDB00
        public void Invert(){} // RVA: 0x7FFACBABDDD0
        public void Multiply(){} // RVA: 0x7FFACBABE000
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBABE090
        public void Reduce(){} // RVA: 0x7FFACBABE170
        public void Reduce15(){} // RVA: 0x7FFACBABE250
        public void Sqrt(){} // RVA: 0x7FFACBABE2C0
        public void Square(){} // RVA: 0x7FFACBABE390
        public void SquareAddToExt(){} // RVA: 0x7FFACBABE440
        public void SquareN(){} // RVA: 0x7FFACBABE550
        public void Trace(){} // RVA: 0x7FFACBABE720
        public void ImplMultiply(){} // RVA: 0x7FFACBABE750
        public void ImplMulw(){} // RVA: 0x7FFACBABE960
        public void ImplSquare(){} // RVA: 0x7FFACBABEB90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SecT113FieldElement : AbstractF2mFieldElement
    {
        public ulong[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFACBABED30
        public void get_IsZero(){} // RVA: 0x7FFACBABED90
        public void TestBitZero(){} // RVA: 0x7FFACBABEDD0
        public void ToBigInteger(){} // RVA: 0x7FFACBABEE00
        public void get_FieldName(){} // RVA: 0x7FFACBABEF00
        public void get_FieldSize(){} // RVA: 0x7FFAC4BE8CB0
        public void Add(){} // RVA: 0x7FFACBABEF40
        public void AddOne(){} // RVA: 0x7FFACBABF0F0
        public void Subtract(){} // RVA: 0x7FFAC77C53C0
        public void Multiply(){} // RVA: 0x7FFACBABF210
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBABF350
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBABF370
        public void Divide(){} // RVA: 0x7FFACBABF5A0
        public void Negate(){} // RVA: 0x7FFAC44F81E0
        public void Square(){} // RVA: 0x7FFACBABF5F0
        public void SquareMinusProduct(){} // RVA: 0x7FFACBABF6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBABF6F0
        public void SquarePow(){} // RVA: 0x7FFACBABF9C0
        public void HalfTrace(){} // RVA: 0x7FFACBABFAC0
        public void get_HasFastTrace(){} // RVA: 0x7FFAC3006850
        public void Trace(){} // RVA: 0x7FFACBA85CB0
        public void Invert(){} // RVA: 0x7FFACBABFBA0
        public void Sqrt(){} // RVA: 0x7FFACBABFC80
        public void get_Representation(){} // RVA: 0x7FFAC3026CB0
        public void get_M(){} // RVA: 0x7FFAC4BE8CB0
        public void get_K1(){} // RVA: 0x7FFAC41E44C0
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void Equals(){} // RVA: 0x7FFACBABFF40 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBABFFB0
    }

    public class SecT113R1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAC0060
        public void CloneCurve(){} // RVA: 0x7FFACBAC0540
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFAC4BE8CB0
        public void FromBigInteger(){} // RVA: 0x7FFACBAC05A0
        public void CreateRawPoint(){} // RVA: 0x7FFACBAC06F0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFAC4BE8CB0
        public void get_IsTrinomial(){} // RVA: 0x7FFAC3006850
        public void get_K1(){} // RVA: 0x7FFAC41E44C0
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAC0790
    }

    public class SecT113R1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAC0E50
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAC1100
        public void Twice(){} // RVA: 0x7FFACBAC1AF0
        public void TwicePlus(){} // RVA: 0x7FFACBAC1FB0
        public void Negate(){} // RVA: 0x7FFACBAC26A0
    }

    public class SecT113R2Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAC2850
        public void CloneCurve(){} // RVA: 0x7FFACBAC2D30
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFAC4BE8CB0
        public void FromBigInteger(){} // RVA: 0x7FFACBAC2D80
        public void CreateRawPoint(){} // RVA: 0x7FFACBAC2ED0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFAC4BE8CB0
        public void get_IsTrinomial(){} // RVA: 0x7FFAC3006850
        public void get_K1(){} // RVA: 0x7FFAC41E44C0
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAC2F70
    }

    public class SecT113R2Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAC3630
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAC3740
        public void Twice(){} // RVA: 0x7FFACBAC4130
        public void TwicePlus(){} // RVA: 0x7FFACBAC45F0
        public void Negate(){} // RVA: 0x7FFACBAC4CE0
    }

    public class SecT131Field : Object
    {
        public ulong M03;
        public ulong M44;
        public ulong[] ROOT_Z;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBAC4E90
        public void AddExt(){} // RVA: 0x7FFACBAC4F20
        public void AddOne(){} // RVA: 0x7FFACBAC5000
        public void AddTo(){} // RVA: 0x7FFACBAC5060
        public void FromBigInteger(){} // RVA: 0x7FFACBAC50D0
        public void HalfTrace(){} // RVA: 0x7FFACBAC50E0
        public void Invert(){} // RVA: 0x7FFACBAC5370
        public void Multiply(){} // RVA: 0x7FFACBAC55E0
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBAC56A0
        public void Reduce(){} // RVA: 0x7FFACBAC57D0
        public void Reduce61(){} // RVA: 0x7FFACBAC5910
        public void Sqrt(){} // RVA: 0x7FFACBAC59A0
        public void Square(){} // RVA: 0x7FFACBAC5B20
        public void SquareAddToExt(){} // RVA: 0x7FFACBAC5C50
        public void SquareN(){} // RVA: 0x7FFACBAC5DF0
        public void Trace(){} // RVA: 0x7FFACBAC5FF0
        public void ImplCompactExt(){} // RVA: 0x7FFACBAC6040
        public void ImplMultiply(){} // RVA: 0x7FFACBAC6130
        public void ImplMulw(){} // RVA: 0x7FFACBAC66B0
        public void ImplSquare(){} // RVA: 0x7FFACBAC6910
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBAC69B0
    }

    public class SecT131FieldElement : AbstractF2mFieldElement
    {
        public ulong[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFACBAC6C10
        public void get_IsZero(){} // RVA: 0x7FFACBAC6C70
        public void TestBitZero(){} // RVA: 0x7FFACBABEDD0
        public void ToBigInteger(){} // RVA: 0x7FFACBAC6CB0
        public void get_FieldName(){} // RVA: 0x7FFACBAC6CC0
        public void get_FieldSize(){} // RVA: 0x7FFACBAC6D00
        public void Add(){} // RVA: 0x7FFACBAC6D10
        public void AddOne(){} // RVA: 0x7FFACBAC6F10
        public void Subtract(){} // RVA: 0x7FFAC77C53C0
        public void Multiply(){} // RVA: 0x7FFACBAC7080
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBABF350
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBAC71F0
        public void Divide(){} // RVA: 0x7FFACBABF5A0
        public void Negate(){} // RVA: 0x7FFAC44F81E0
        public void Square(){} // RVA: 0x7FFACBAC7440
        public void SquareMinusProduct(){} // RVA: 0x7FFACBABF6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBAC7540
        public void SquarePow(){} // RVA: 0x7FFACBAC7750
        public void HalfTrace(){} // RVA: 0x7FFACBAC7880
        public void get_HasFastTrace(){} // RVA: 0x7FFAC3006850
        public void Trace(){} // RVA: 0x7FFACBAC7980
        public void Invert(){} // RVA: 0x7FFACBAC7A10
        public void Sqrt(){} // RVA: 0x7FFACBAC7B10
        public void get_Representation(){} // RVA: 0x7FFAC366FE20
        public void get_M(){} // RVA: 0x7FFACBAC6D00
        public void get_K1(){} // RVA: 0x7FFAC3026CB0
        public void get_K2(){} // RVA: 0x7FFAC366FE20
        public void get_K3(){} // RVA: 0x7FFAC3ED8E80
        public void Equals(){} // RVA: 0x7FFACBAC7EB0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAC7F20
    }

    public class SecT131R1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAC7FD0
        public void CloneCurve(){} // RVA: 0x7FFACBAC84D0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAC6D00
        public void FromBigInteger(){} // RVA: 0x7FFACBAC8520
        public void CreateRawPoint(){} // RVA: 0x7FFACBAC8670 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFACBAC6D00
        public void get_IsTrinomial(){} // RVA: 0x7FFAC2F21320
        public void get_K1(){} // RVA: 0x7FFAC3026CB0
        public void get_K2(){} // RVA: 0x7FFAC366FE20
        public void get_K3(){} // RVA: 0x7FFAC3ED8E80
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAC8710
    }

    public class SecT131R1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAC8E20
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAC8F30
        public void Twice(){} // RVA: 0x7FFACBAC9920
        public void TwicePlus(){} // RVA: 0x7FFACBAC9DE0
        public void Negate(){} // RVA: 0x7FFACBACA4D0
    }

    public class SecT131R2Curve : AbstractF2mCurve
    {
        public int FieldSize;
        public int Infinity;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBACA680
        public void CloneCurve(){} // RVA: 0x7FFACBACAB80
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_FieldSize(){} // RVA: 0x7FFACBAC6D00
        public void FromBigInteger(){} // RVA: 0x7FFACBACABD0
        public void CreateRawPoint(){} // RVA: 0x7FFACBACAD20 | overloaded x2
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFACBAC6D00
        public void get_IsTrinomial(){} // RVA: 0x7FFAC2F21320
        public void get_K1(){} // RVA: 0x7FFAC3026CB0
        public void get_K2(){} // RVA: 0x7FFAC366FE20
        public void get_K3(){} // RVA: 0x7FFAC3ED8E80
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBACADC0
    }

    public class SecT131R2Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBACB4D0
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBACB5E0
        public void Twice(){} // RVA: 0x7FFACBACBFD0
        public void TwicePlus(){} // RVA: 0x7FFACBACC490
        public void Negate(){} // RVA: 0x7FFACBACCB80
    }

    public class SecT163Field : Object
    {
        public ulong M35;
        public ulong M55;
        public ulong[] ROOT_Z;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBAC4E90
        public void AddExt(){} // RVA: 0x7FFACBACCD30
        public void AddOne(){} // RVA: 0x7FFACBAC5000
        public void AddTo(){} // RVA: 0x7FFACBAC5060
        public void FromBigInteger(){} // RVA: 0x7FFACBACCE40
        public void HalfTrace(){} // RVA: 0x7FFACBACCE50
        public void Invert(){} // RVA: 0x7FFACBACD090
        public void Multiply(){} // RVA: 0x7FFACBACD330
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBACD3F0
        public void Reduce(){} // RVA: 0x7FFACBACD4B0
        public void Reduce29(){} // RVA: 0x7FFACBACD640
        public void Sqrt(){} // RVA: 0x7FFACBACD6C0
        public void Square(){} // RVA: 0x7FFACBACD840
        public void SquareAddToExt(){} // RVA: 0x7FFACBACD940
        public void SquareN(){} // RVA: 0x7FFACBACDA40
        public void Trace(){} // RVA: 0x7FFACBACDBE0
        public void ImplCompactExt(){} // RVA: 0x7FFACBACDC20
        public void ImplMultiply(){} // RVA: 0x7FFACBACDD10
        public void ImplMulw(){} // RVA: 0x7FFACBACE290
        public void ImplSquare(){} // RVA: 0x7FFACBACE490
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBACE510
    }

    public class SecT163FieldElement : AbstractF2mFieldElement
    {
        public ulong[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFACBAC6C10
        public void get_IsZero(){} // RVA: 0x7FFACBAC6C70
        public void TestBitZero(){} // RVA: 0x7FFACBABEDD0
        public void ToBigInteger(){} // RVA: 0x7FFACBAC6CB0
        public void get_FieldName(){} // RVA: 0x7FFACBACE6E0
        public void get_FieldSize(){} // RVA: 0x7FFAC4BE9310
        public void Add(){} // RVA: 0x7FFACBACE720
        public void AddOne(){} // RVA: 0x7FFACBACE920
        public void Subtract(){} // RVA: 0x7FFAC77C53C0
        public void Multiply(){} // RVA: 0x7FFACBACEA90
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBABF350
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBACEC00
        public void Divide(){} // RVA: 0x7FFACBABF5A0
        public void Negate(){} // RVA: 0x7FFAC44F81E0
        public void Square(){} // RVA: 0x7FFACBACEE50
        public void SquareMinusProduct(){} // RVA: 0x7FFACBABF6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBACEF50
        public void SquarePow(){} // RVA: 0x7FFACBACF230
        public void HalfTrace(){} // RVA: 0x7FFACBACF360
        public void get_HasFastTrace(){} // RVA: 0x7FFAC3006850
        public void Trace(){} // RVA: 0x7FFACBACF460
        public void Invert(){} // RVA: 0x7FFACBACF4E0
        public void Sqrt(){} // RVA: 0x7FFACBACF5E0
        public void get_Representation(){} // RVA: 0x7FFAC366FE20
        public void get_M(){} // RVA: 0x7FFAC4BE9310
        public void get_K1(){} // RVA: 0x7FFAC366FE20
        public void get_K2(){} // RVA: 0x7FFAC36A9850
        public void get_K3(){} // RVA: 0x7FFAC36AE2C0
        public void Equals(){} // RVA: 0x7FFACBAC7EB0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBACF980
    }

    public class SecT163K1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBACFA30
        public void CloneCurve(){} // RVA: 0x7FFACBACFE90
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFACBACFEE0
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFAC4BE9310
        public void FromBigInteger(){} // RVA: 0x7FFACBACFF20
        public void CreateRawPoint(){} // RVA: 0x7FFACBAD0070 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC3006850
        public void get_M(){} // RVA: 0x7FFAC4BE9310
        public void get_IsTrinomial(){} // RVA: 0x7FFAC2F21320
        public void get_K1(){} // RVA: 0x7FFAC366FE20
        public void get_K2(){} // RVA: 0x7FFAC36A9850
        public void get_K3(){} // RVA: 0x7FFAC36AE2C0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAD0110
    }

    public class SecT163K1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAD0820
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAD0930
        public void Twice(){} // RVA: 0x7FFACBAD12D0
        public void TwicePlus(){} // RVA: 0x7FFACBAD1740
        public void Negate(){} // RVA: 0x7FFACBAD1DB0
    }

    public class SecT163R1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAD1F60
        public void CloneCurve(){} // RVA: 0x7FFACBAD2460
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFAC4BE9310
        public void FromBigInteger(){} // RVA: 0x7FFACBAD24B0
        public void CreateRawPoint(){} // RVA: 0x7FFACBAD2600 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFAC4BE9310
        public void get_IsTrinomial(){} // RVA: 0x7FFAC2F21320
        public void get_K1(){} // RVA: 0x7FFAC366FE20
        public void get_K2(){} // RVA: 0x7FFAC36A9850
        public void get_K3(){} // RVA: 0x7FFAC36AE2C0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAD26A0
    }

    public class SecT163R1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAD2DB0
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAD2EC0
        public void Twice(){} // RVA: 0x7FFACBAD38B0
        public void TwicePlus(){} // RVA: 0x7FFACBAD3D70
        public void Negate(){} // RVA: 0x7FFACBAD4460
    }

    public class SecT163R2Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAD4610
        public void CloneCurve(){} // RVA: 0x7FFACBAD4AC0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFAC4BE9310
        public void FromBigInteger(){} // RVA: 0x7FFACBAD4B10
        public void CreateRawPoint(){} // RVA: 0x7FFACBAD4C60 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFAC4BE9310
        public void get_IsTrinomial(){} // RVA: 0x7FFAC2F21320
        public void get_K1(){} // RVA: 0x7FFAC366FE20
        public void get_K2(){} // RVA: 0x7FFAC36A9850
        public void get_K3(){} // RVA: 0x7FFAC36AE2C0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAD4D00
    }

    public class SecT163R2Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAD5410
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAD5520
        public void Twice(){} // RVA: 0x7FFACBAD5F00
        public void TwicePlus(){} // RVA: 0x7FFACBAD6380
        public void Negate(){} // RVA: 0x7FFACBAD6A10
    }

    public class SecT193Field : Object
    {
        public ulong M01;
        public ulong M49;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBABD9A0
        public void AddExt(){} // RVA: 0x7FFACBAD6BC0
        public void AddOne(){} // RVA: 0x7FFACBAD6D00
        public void AddTo(){} // RVA: 0x7FFACBAD6D80
        public void FromBigInteger(){} // RVA: 0x7FFACBAD6E00
        public void HalfTrace(){} // RVA: 0x7FFACBAD6E10
        public void Invert(){} // RVA: 0x7FFACBAD7080
        public void Multiply(){} // RVA: 0x7FFACBAD72C0
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBAD7350
        public void Reduce(){} // RVA: 0x7FFACBAD73E0
        public void Reduce63(){} // RVA: 0x7FFACBAD7540
        public void Sqrt(){} // RVA: 0x7FFACBAD75C0
        public void Square(){} // RVA: 0x7FFACBAD7710
        public void SquareAddToExt(){} // RVA: 0x7FFACBAD7800
        public void SquareN(){} // RVA: 0x7FFACBAD78F0
        public void Trace(){} // RVA: 0x7FFACBABE720
        public void ImplCompactExt(){} // RVA: 0x7FFACBAD7A90
        public void ImplExpand(){} // RVA: 0x7FFACBAD7BF0
        public void ImplMultiply(){} // RVA: 0x7FFACBAD7CB0
        public void ImplMulwAcc(){} // RVA: 0x7FFACBAD82F0
        public void ImplSquare(){} // RVA: 0x7FFACBAD8560
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SecT193FieldElement : AbstractF2mFieldElement
    {
        public ulong[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFACBAD8740
        public void get_IsZero(){} // RVA: 0x7FFACBAD87A0
        public void TestBitZero(){} // RVA: 0x7FFACBABEDD0
        public void ToBigInteger(){} // RVA: 0x7FFACBAD87E0
        public void get_FieldName(){} // RVA: 0x7FFACBAD87F0
        public void get_FieldSize(){} // RVA: 0x7FFACBAD8830
        public void Add(){} // RVA: 0x7FFACBAD8840
        public void AddOne(){} // RVA: 0x7FFACBAD8A40
        public void Subtract(){} // RVA: 0x7FFAC77C53C0
        public void Multiply(){} // RVA: 0x7FFACBAD8BA0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBABF350
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBAD8CE0
        public void Divide(){} // RVA: 0x7FFACBABF5A0
        public void Negate(){} // RVA: 0x7FFAC44F81E0
        public void Square(){} // RVA: 0x7FFACBAD8F10
        public void SquareMinusProduct(){} // RVA: 0x7FFACBABF6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBAD8FF0
        public void SquarePow(){} // RVA: 0x7FFACBAD92A0
        public void HalfTrace(){} // RVA: 0x7FFACBAD93A0
        public void get_HasFastTrace(){} // RVA: 0x7FFAC3006850
        public void Trace(){} // RVA: 0x7FFACBA85CB0
        public void Invert(){} // RVA: 0x7FFACBAD9480
        public void Sqrt(){} // RVA: 0x7FFACBAD9560
        public void get_Representation(){} // RVA: 0x7FFAC3026CB0
        public void get_M(){} // RVA: 0x7FFACBAD8830
        public void get_K1(){} // RVA: 0x7FFAC3E454F0
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void Equals(){} // RVA: 0x7FFACBAD98A0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAD9910
    }

    public class SecT193R1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAD99C0
        public void CloneCurve(){} // RVA: 0x7FFACBAD9EA0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAD8830
        public void FromBigInteger(){} // RVA: 0x7FFACBAD9EF0
        public void CreateRawPoint(){} // RVA: 0x7FFACBADA040 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFACBAD8830
        public void get_IsTrinomial(){} // RVA: 0x7FFAC3006850
        public void get_K1(){} // RVA: 0x7FFAC3E454F0
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBADA0E0
    }

    public class SecT193R1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBADA830
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBADA940
        public void Twice(){} // RVA: 0x7FFACBADB330
        public void TwicePlus(){} // RVA: 0x7FFACBADB7F0
        public void Negate(){} // RVA: 0x7FFACBADBEE0
    }

    public class SecT193R2Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBADC090
        public void CloneCurve(){} // RVA: 0x7FFACBADC570
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAD8830
        public void FromBigInteger(){} // RVA: 0x7FFACBADC5C0
        public void CreateRawPoint(){} // RVA: 0x7FFACBADC710 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFACBAD8830
        public void get_IsTrinomial(){} // RVA: 0x7FFAC3006850
        public void get_K1(){} // RVA: 0x7FFAC3E454F0
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBADC7B0
    }

    public class SecT193R2Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBADCF00
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBADD010
        public void Twice(){} // RVA: 0x7FFACBADDA00
        public void TwicePlus(){} // RVA: 0x7FFACBADDEC0
        public void Negate(){} // RVA: 0x7FFACBADE5B0
    }

    public class SecT233Field : Object
    {
        public ulong M41;
        public ulong M59;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBABD9A0
        public void AddExt(){} // RVA: 0x7FFACBADE760
        public void AddOne(){} // RVA: 0x7FFACBAD6D00
        public void AddTo(){} // RVA: 0x7FFACBAD6D80
        public void FromBigInteger(){} // RVA: 0x7FFACBADE8C0
        public void HalfTrace(){} // RVA: 0x7FFACBADE8D0
        public void Invert(){} // RVA: 0x7FFACBADEB40
        public void Multiply(){} // RVA: 0x7FFACBADEDB0
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBADEE40
        public void Reduce(){} // RVA: 0x7FFACBADEED0
        public void Reduce23(){} // RVA: 0x7FFACBADF070
        public void Sqrt(){} // RVA: 0x7FFACBADF0F0
        public void Square(){} // RVA: 0x7FFACBADF3A0
        public void SquareAddToExt(){} // RVA: 0x7FFACBADF490
        public void SquareN(){} // RVA: 0x7FFACBADF580
        public void Trace(){} // RVA: 0x7FFACBADF730
        public void ImplCompactExt(){} // RVA: 0x7FFACBADF770
        public void ImplExpand(){} // RVA: 0x7FFACBADF8C0
        public void ImplMultiply(){} // RVA: 0x7FFACBADF980
        public void ImplMulwAcc(){} // RVA: 0x7FFACBADFFC0
        public void ImplSquare(){} // RVA: 0x7FFACBAE01B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SecT233FieldElement : AbstractF2mFieldElement
    {
        public ulong[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFACBAD8740
        public void get_IsZero(){} // RVA: 0x7FFACBAD87A0
        public void TestBitZero(){} // RVA: 0x7FFACBABEDD0
        public void ToBigInteger(){} // RVA: 0x7FFACBAD87E0
        public void get_FieldName(){} // RVA: 0x7FFACBAE0300
        public void get_FieldSize(){} // RVA: 0x7FFACBAE0340
        public void Add(){} // RVA: 0x7FFACBAE0350
        public void AddOne(){} // RVA: 0x7FFACBAE0550
        public void Subtract(){} // RVA: 0x7FFAC77C53C0
        public void Multiply(){} // RVA: 0x7FFACBAE06B0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBABF350
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBAE07F0
        public void Divide(){} // RVA: 0x7FFACBABF5A0
        public void Negate(){} // RVA: 0x7FFAC44F81E0
        public void Square(){} // RVA: 0x7FFACBAE0A20
        public void SquareMinusProduct(){} // RVA: 0x7FFACBABF6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBAE0B00
        public void SquarePow(){} // RVA: 0x7FFACBAE0DA0
        public void HalfTrace(){} // RVA: 0x7FFACBAE0EA0
        public void get_HasFastTrace(){} // RVA: 0x7FFAC3006850
        public void Trace(){} // RVA: 0x7FFACBAE0F80
        public void Invert(){} // RVA: 0x7FFACBAE0FC0
        public void Sqrt(){} // RVA: 0x7FFACBAE10A0
        public void get_Representation(){} // RVA: 0x7FFAC3026CB0
        public void get_M(){} // RVA: 0x7FFACBAE0340
        public void get_K1(){} // RVA: 0x7FFACBAE1180
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void Equals(){} // RVA: 0x7FFACBAD98A0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAE12D0
    }

    public class SecT233K1Curve : AbstractF2mCurve
    {
        public int FieldSize;
        public int Infinity;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAE1380
        public void CloneCurve(){} // RVA: 0x7FFACBAE17C0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFACBAE1810
        public void get_FieldSize(){} // RVA: 0x7FFACBAE0340
        public void FromBigInteger(){} // RVA: 0x7FFACBAE1850
        public void CreateRawPoint(){} // RVA: 0x7FFACBAE19A0 | overloaded x2
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_IsKoblitz(){} // RVA: 0x7FFAC3006850
        public void get_M(){} // RVA: 0x7FFACBAE0340
        public void get_IsTrinomial(){} // RVA: 0x7FFAC3006850
        public void get_K1(){} // RVA: 0x7FFACBAE1180
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAE1A40
    }

    public class SecT233K1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAE2190
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAE22A0
        public void Twice(){} // RVA: 0x7FFACBAE2C20
        public void TwicePlus(){} // RVA: 0x7FFACBAE3120
        public void Negate(){} // RVA: 0x7FFACBAE3760
    }

    public class SecT233R1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAE3910
        public void CloneCurve(){} // RVA: 0x7FFACBAE3DA0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAE0340
        public void FromBigInteger(){} // RVA: 0x7FFACBAE3DF0
        public void CreateRawPoint(){} // RVA: 0x7FFACBAE3F40 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFACBAE0340
        public void get_IsTrinomial(){} // RVA: 0x7FFAC3006850
        public void get_K1(){} // RVA: 0x7FFACBAE1180
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAE3FE0
    }

    public class SecT233R1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAE4730
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAE4840
        public void Twice(){} // RVA: 0x7FFACBAE5220
        public void TwicePlus(){} // RVA: 0x7FFACBAE56A0
        public void Negate(){} // RVA: 0x7FFACBAE5D30
    }

    public class SecT239Field : Object
    {
        public ulong M47;
        public ulong M60;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBABD9A0
        public void AddExt(){} // RVA: 0x7FFACBADE760
        public void AddOne(){} // RVA: 0x7FFACBAD6D00
        public void AddTo(){} // RVA: 0x7FFACBAD6D80
        public void FromBigInteger(){} // RVA: 0x7FFACBAE5EE0
        public void HalfTrace(){} // RVA: 0x7FFACBAE5EF0
        public void Invert(){} // RVA: 0x7FFACBAE6160
        public void Multiply(){} // RVA: 0x7FFACBAE6410
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBAE64A0
        public void Reduce(){} // RVA: 0x7FFACBAE6530
        public void Reduce17(){} // RVA: 0x7FFACBAE66D0
        public void Sqrt(){} // RVA: 0x7FFACBAE6750
        public void Square(){} // RVA: 0x7FFACBAE6A40
        public void SquareAddToExt(){} // RVA: 0x7FFACBADF490
        public void SquareN(){} // RVA: 0x7FFACBAE6B30
        public void Trace(){} // RVA: 0x7FFACBAE6CE0
        public void ImplCompactExt(){} // RVA: 0x7FFACBAE6D30
        public void ImplExpand(){} // RVA: 0x7FFACBAE6E80
        public void ImplMultiply(){} // RVA: 0x7FFACBAE6F40
        public void ImplMulwAcc(){} // RVA: 0x7FFACBAE7580
        public void ImplSquare(){} // RVA: 0x7FFACBAE01B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SecT239FieldElement : AbstractF2mFieldElement
    {
        public ulong[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFACBAD8740
        public void get_IsZero(){} // RVA: 0x7FFACBAD87A0
        public void TestBitZero(){} // RVA: 0x7FFACBABEDD0
        public void ToBigInteger(){} // RVA: 0x7FFACBAD87E0
        public void get_FieldName(){} // RVA: 0x7FFACBAE7860
        public void get_FieldSize(){} // RVA: 0x7FFACBAE78A0
        public void Add(){} // RVA: 0x7FFACBAE78B0
        public void AddOne(){} // RVA: 0x7FFACBAE7AB0
        public void Subtract(){} // RVA: 0x7FFAC77C53C0
        public void Multiply(){} // RVA: 0x7FFACBAE7C10
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBABF350
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBAE7D50
        public void Divide(){} // RVA: 0x7FFACBABF5A0
        public void Negate(){} // RVA: 0x7FFAC44F81E0
        public void Square(){} // RVA: 0x7FFACBAE7F80
        public void SquareMinusProduct(){} // RVA: 0x7FFACBABF6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBAE8060
        public void SquarePow(){} // RVA: 0x7FFACBAE8300
        public void HalfTrace(){} // RVA: 0x7FFACBAE8400
        public void get_HasFastTrace(){} // RVA: 0x7FFAC3006850
        public void Trace(){} // RVA: 0x7FFACBAE84E0
        public void Invert(){} // RVA: 0x7FFACBAE8530
        public void Sqrt(){} // RVA: 0x7FFACBAE8610
        public void get_Representation(){} // RVA: 0x7FFAC3026CB0
        public void get_M(){} // RVA: 0x7FFACBAE78A0
        public void get_K1(){} // RVA: 0x7FFACBAE86F0
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void Equals(){} // RVA: 0x7FFACBAD98A0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAE8840
    }

    public class SecT239K1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAE88F0
        public void CloneCurve(){} // RVA: 0x7FFACBAE8D30
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFACBAE8D80
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAE78A0
        public void FromBigInteger(){} // RVA: 0x7FFACBAE8DC0
        public void CreateRawPoint(){} // RVA: 0x7FFACBAE8F90 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC3006850
        public void get_M(){} // RVA: 0x7FFACBAE78A0
        public void get_IsTrinomial(){} // RVA: 0x7FFAC3006850
        public void get_K1(){} // RVA: 0x7FFACBAE86F0
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAE9030
    }

    public class SecT239K1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAE9780
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAE9890
        public void Twice(){} // RVA: 0x7FFACBAEA210
        public void TwicePlus(){} // RVA: 0x7FFACBAEA710
        public void Negate(){} // RVA: 0x7FFACBAEAD50
    }

    public class SecT283Field : Object
    {
        public ulong M27;
        public ulong M57;
        public ulong[] ROOT_Z;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBAC4F20
        public void AddExt(){} // RVA: 0x7FFACBAEAF00
        public void AddOne(){} // RVA: 0x7FFACBAEB090
        public void AddTo(){} // RVA: 0x7FFACBAEB120
        public void FromBigInteger(){} // RVA: 0x7FFACBAEB1C0
        public void HalfTrace(){} // RVA: 0x7FFACBAEB1D0
        public void Invert(){} // RVA: 0x7FFACBAEB3E0
        public void Multiply(){} // RVA: 0x7FFACBAEB6B0
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBAEB770
        public void Reduce(){} // RVA: 0x7FFACBAEB830
        public void Reduce37(){} // RVA: 0x7FFACBAEBA60
        public void Sqrt(){} // RVA: 0x7FFACBAEBAE0
        public void Square(){} // RVA: 0x7FFACBAEBCD0
        public void SquareAddToExt(){} // RVA: 0x7FFACBAEBD80
        public void SquareN(){} // RVA: 0x7FFACBAEBE30
        public void Trace(){} // RVA: 0x7FFACBAEBF30
        public void ImplCompactExt(){} // RVA: 0x7FFACBAEBF70
        public void ImplExpand(){} // RVA: 0x7FFACBAEC130
        public void ImplMultiply(){} // RVA: 0x7FFACBAEC230
        public void ImplMulw(){} // RVA: 0x7FFACBAEC900
        public void ImplSquare(){} // RVA: 0x7FFACBAECB30
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBAECC70
    }

    public class SecT283FieldElement : AbstractF2mFieldElement
    {
        public ulong[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFACBAECED0
        public void get_IsZero(){} // RVA: 0x7FFACBAECF30
        public void TestBitZero(){} // RVA: 0x7FFACBABEDD0
        public void ToBigInteger(){} // RVA: 0x7FFACBAECF70
        public void get_FieldName(){} // RVA: 0x7FFACBAED070
        public void get_FieldSize(){} // RVA: 0x7FFACBAED0B0
        public void Add(){} // RVA: 0x7FFACBAED0C0
        public void AddOne(){} // RVA: 0x7FFACBAED310
        public void Subtract(){} // RVA: 0x7FFAC77C53C0
        public void Multiply(){} // RVA: 0x7FFACBAED4B0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBABF350
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBAED620
        public void Divide(){} // RVA: 0x7FFACBABF5A0
        public void Negate(){} // RVA: 0x7FFAC44F81E0
        public void Square(){} // RVA: 0x7FFACBAED870
        public void SquareMinusProduct(){} // RVA: 0x7FFACBABF6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBAED970
        public void SquarePow(){} // RVA: 0x7FFACBAEDBF0
        public void HalfTrace(){} // RVA: 0x7FFACBAEDD20
        public void get_HasFastTrace(){} // RVA: 0x7FFAC3006850
        public void Trace(){} // RVA: 0x7FFACBAEDE20
        public void Invert(){} // RVA: 0x7FFACBAEDEA0
        public void Sqrt(){} // RVA: 0x7FFACBAEDFA0
        public void get_Representation(){} // RVA: 0x7FFAC366FE20
        public void get_M(){} // RVA: 0x7FFACBAED0B0
        public void get_K1(){} // RVA: 0x7FFAC31E48B0
        public void get_K2(){} // RVA: 0x7FFAC36AE2C0
        public void get_K3(){} // RVA: 0x7FFAC530B5A0
        public void Equals(){} // RVA: 0x7FFACBAEE1E0 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAEE250
    }

    public class SecT283K1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAEE300
        public void CloneCurve(){} // RVA: 0x7FFACBAEE760
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFACBAEE7B0
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAED0B0
        public void FromBigInteger(){} // RVA: 0x7FFACBAEE7F0
        public void CreateRawPoint(){} // RVA: 0x7FFACBAEE940 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC3006850
        public void get_M(){} // RVA: 0x7FFACBAED0B0
        public void get_IsTrinomial(){} // RVA: 0x7FFAC2F21320
        public void get_K1(){} // RVA: 0x7FFAC31E48B0
        public void get_K2(){} // RVA: 0x7FFAC36AE2C0
        public void get_K3(){} // RVA: 0x7FFAC530B5A0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAEE9E0
    }

    public class SecT283K1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAEF180
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAEF290
        public void Twice(){} // RVA: 0x7FFACBAEFC10
        public void TwicePlus(){} // RVA: 0x7FFACBAF0110
        public void Negate(){} // RVA: 0x7FFACBAF0750
    }

    public class SecT283R1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAF0900
        public void CloneCurve(){} // RVA: 0x7FFACBAF0DB0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAED0B0
        public void FromBigInteger(){} // RVA: 0x7FFACBAF0E00
        public void CreateRawPoint(){} // RVA: 0x7FFACBAF0F50 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFACBAED0B0
        public void get_IsTrinomial(){} // RVA: 0x7FFAC2F21320
        public void get_K1(){} // RVA: 0x7FFAC31E48B0
        public void get_K2(){} // RVA: 0x7FFAC36AE2C0
        public void get_K3(){} // RVA: 0x7FFAC530B5A0
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAF0FF0
    }

    public class SecT283R1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAF1790
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAF18A0
        public void Twice(){} // RVA: 0x7FFACBAF2280
        public void TwicePlus(){} // RVA: 0x7FFACBAF2700
        public void Negate(){} // RVA: 0x7FFACBAF2D90
    }

    public class SecT409Field : Object
    {
        public ulong M25;
        public ulong M59;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBAD6BC0
        public void AddExt(){} // RVA: 0x7FFACBAF2F40
        public void AddOne(){} // RVA: 0x7FFACBAF2FB0
        public void AddTo(){} // RVA: 0x7FFACBAF3070
        public void FromBigInteger(){} // RVA: 0x7FFACBAF3150
        public void HalfTrace(){} // RVA: 0x7FFACBAF3160
        public void Invert(){} // RVA: 0x7FFACBAF33A0
        public void Multiply(){} // RVA: 0x7FFACBAF3660
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBAF36F0
        public void Reduce(){} // RVA: 0x7FFACBAF37B0
        public void Reduce39(){} // RVA: 0x7FFACBAF39E0
        public void Sqrt(){} // RVA: 0x7FFACBAF3A50
        public void Square(){} // RVA: 0x7FFACBAF3C90
        public void SquareAddToExt(){} // RVA: 0x7FFACBAF3D10
        public void SquareN(){} // RVA: 0x7FFACBAF3DC0
        public void Trace(){} // RVA: 0x7FFACBABE720
        public void ImplCompactExt(){} // RVA: 0x7FFACBAF3E80
        public void ImplExpand(){} // RVA: 0x7FFACBAF4120
        public void ImplMultiply(){} // RVA: 0x7FFACBAF4290
        public void ImplMulwAcc(){} // RVA: 0x7FFACBAF4390
        public void ImplSquare(){} // RVA: 0x7FFACBAF45F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SecT409FieldElement : AbstractF2mFieldElement
    {
        public ulong[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFACBAF48B0
        public void get_IsZero(){} // RVA: 0x7FFACBAF4910
        public void TestBitZero(){} // RVA: 0x7FFACBABEDD0
        public void ToBigInteger(){} // RVA: 0x7FFACBAF4950
        public void get_FieldName(){} // RVA: 0x7FFACBAF4A50
        public void get_FieldSize(){} // RVA: 0x7FFACBAF4A90
        public void Add(){} // RVA: 0x7FFACBAF4AA0
        public void AddOne(){} // RVA: 0x7FFACBAF4D20
        public void Subtract(){} // RVA: 0x7FFAC77C53C0
        public void Multiply(){} // RVA: 0x7FFACBAF4ED0
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBABF350
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBAF5010
        public void Divide(){} // RVA: 0x7FFACBABF5A0
        public void Negate(){} // RVA: 0x7FFAC44F81E0
        public void Square(){} // RVA: 0x7FFACBAF5240
        public void SquareMinusProduct(){} // RVA: 0x7FFACBABF6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBAF5320
        public void SquarePow(){} // RVA: 0x7FFACBAF5590
        public void HalfTrace(){} // RVA: 0x7FFACBAF5690
        public void get_HasFastTrace(){} // RVA: 0x7FFAC3006850
        public void Trace(){} // RVA: 0x7FFACBA85CB0
        public void Invert(){} // RVA: 0x7FFACBAF5770
        public void Sqrt(){} // RVA: 0x7FFACBAF5850
        public void get_Representation(){} // RVA: 0x7FFAC3026CB0
        public void get_M(){} // RVA: 0x7FFACBAF4A90
        public void get_K1(){} // RVA: 0x7FFACBAF5930
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void Equals(){} // RVA: 0x7FFACBAF5A80 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAF5AF0
    }

    public class SecT409K1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAF5BA0
        public void CloneCurve(){} // RVA: 0x7FFACBAF5FE0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFACBAF6030
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAF4A90
        public void FromBigInteger(){} // RVA: 0x7FFACBAF6070
        public void CreateRawPoint(){} // RVA: 0x7FFACBAF61C0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC3006850
        public void get_M(){} // RVA: 0x7FFACBAF4A90
        public void get_IsTrinomial(){} // RVA: 0x7FFAC3006850
        public void get_K1(){} // RVA: 0x7FFACBAF5930
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAF6260
    }

    public class SecT409K1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAF68B0
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAF69C0
        public void Twice(){} // RVA: 0x7FFACBAF7340
        public void TwicePlus(){} // RVA: 0x7FFACBAF7840
        public void Negate(){} // RVA: 0x7FFACBAF7E80
    }

    public class SecT409R1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAF8030
        public void CloneCurve(){} // RVA: 0x7FFACBAF84C0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAF4A90
        public void FromBigInteger(){} // RVA: 0x7FFACBAF8510
        public void CreateRawPoint(){} // RVA: 0x7FFACBAF8660 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFACBAF4A90
        public void get_IsTrinomial(){} // RVA: 0x7FFAC3006850
        public void get_K1(){} // RVA: 0x7FFACBAF5930
        public void get_K2(){} // RVA: 0x7FFAC34F9180
        public void get_K3(){} // RVA: 0x7FFAC34F9180
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAF8700
    }

    public class SecT409R1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAF8D50
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAF8E60
        public void Twice(){} // RVA: 0x7FFACBAF9840
        public void TwicePlus(){} // RVA: 0x7FFACBAF9CC0
        public void Negate(){} // RVA: 0x7FFACBAFA350
    }

    public class SecT571Field : Object
    {
        public ulong M59;
        public ulong RM;
        public ulong[] ROOT_Z;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBAFA570 | overloaded x2
        public void AddBothTo(){} // RVA: 0x7FFACBAFA610
        public void AddExt(){} // RVA: 0x7FFACBAFA6B0
        public void AddOne(){} // RVA: 0x7FFACBAFA720
        public void AddTo(){} // RVA: 0x7FFACBAFA790
        public void FromBigInteger(){} // RVA: 0x7FFACBAFA7E0
        public void HalfTrace(){} // RVA: 0x7FFACBAFA7F0
        public void Invert(){} // RVA: 0x7FFACBAFAA20
        public void Multiply(){} // RVA: 0x7FFACBAFAD60
        public void MultiplyAddToExt(){} // RVA: 0x7FFACBAFAE20
        public void Reduce(){} // RVA: 0x7FFACBAFAF20
        public void Reduce5(){} // RVA: 0x7FFACBAFB0E0
        public void Sqrt(){} // RVA: 0x7FFACBAFB160
        public void Square(){} // RVA: 0x7FFACBAFB550
        public void SquareAddToExt(){} // RVA: 0x7FFACBAFB600
        public void SquareN(){} // RVA: 0x7FFACBAFB6F0
        public void Trace(){} // RVA: 0x7FFACBAFB7F0
        public void ImplMultiply(){} // RVA: 0x7FFACBAFB830
        public void ImplMulwAcc(){} // RVA: 0x7FFACBAFBD30
        public void ImplSquare(){} // RVA: 0x7FFACBAFBF60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBAFC090
    }

    public class SecT571FieldElement : AbstractF2mFieldElement
    {
        public ulong[] IsOne; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x3
        public void get_IsOne(){} // RVA: 0x7FFACBAFC2F0
        public void get_IsZero(){} // RVA: 0x7FFACBAFC350
        public void TestBitZero(){} // RVA: 0x7FFACBABEDD0
        public void ToBigInteger(){} // RVA: 0x7FFACBAFC390
        public void get_FieldName(){} // RVA: 0x7FFACBAFC490
        public void get_FieldSize(){} // RVA: 0x7FFACBAFC4D0
        public void Add(){} // RVA: 0x7FFACBAFC4E0
        public void AddOne(){} // RVA: 0x7FFACBAFC6B0
        public void Subtract(){} // RVA: 0x7FFAC77C53C0
        public void Multiply(){} // RVA: 0x7FFACBAFC810
        public void MultiplyMinusProduct(){} // RVA: 0x7FFACBABF350
        public void MultiplyPlusProduct(){} // RVA: 0x7FFACBAFC980
        public void Divide(){} // RVA: 0x7FFACBABF5A0
        public void Negate(){} // RVA: 0x7FFAC44F81E0
        public void Square(){} // RVA: 0x7FFACBAFCBD0
        public void SquareMinusProduct(){} // RVA: 0x7FFACBABF6D0
        public void SquarePlusProduct(){} // RVA: 0x7FFACBAFCCD0
        public void SquarePow(){} // RVA: 0x7FFACBAFCFA0
        public void HalfTrace(){} // RVA: 0x7FFACBAFD0D0
        public void get_HasFastTrace(){} // RVA: 0x7FFAC3006850
        public void Trace(){} // RVA: 0x7FFACBAFD1D0
        public void Invert(){} // RVA: 0x7FFACBAFD250
        public void Sqrt(){} // RVA: 0x7FFACBAFD350
        public void get_Representation(){} // RVA: 0x7FFAC366FE20
        public void get_M(){} // RVA: 0x7FFACBAFC4D0
        public void get_K1(){} // RVA: 0x7FFAC3026CB0
        public void get_K2(){} // RVA: 0x7FFAC31E48B0
        public void get_K3(){} // RVA: 0x7FFAC314F980
        public void Equals(){} // RVA: 0x7FFACBAFD590 | overloaded x3
        public void GetHashCode(){} // RVA: 0x7FFACBAFD600
    }

    public class SecT571K1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point IsKoblitz; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAFD6B0
        public void CloneCurve(){} // RVA: 0x7FFACBAFDB10
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void CreateDefaultMultiplier(){} // RVA: 0x7FFACBAFDB60
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAFC4D0
        public void FromBigInteger(){} // RVA: 0x7FFACBAFDBA0
        public void CreateRawPoint(){} // RVA: 0x7FFACBAFDCF0 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC3006850
        public void get_M(){} // RVA: 0x7FFACBAFC4D0
        public void get_IsTrinomial(){} // RVA: 0x7FFAC2F21320
        public void get_K1(){} // RVA: 0x7FFAC3026CB0
        public void get_K2(){} // RVA: 0x7FFAC31E48B0
        public void get_K3(){} // RVA: 0x7FFAC314F980
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBAFDD90
    }

    public class SecT571K1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBAFE3E0
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBAFE4F0
        public void Twice(){} // RVA: 0x7FFACBAFEE70
        public void TwicePlus(){} // RVA: 0x7FFACBAFF370
        public void Negate(){} // RVA: 0x7FFACBAFF9B0
    }

    public class SecT571R1Curve : AbstractF2mCurve
    {
        public int Infinity;
        public int FieldSize;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point IsKoblitz; // 0x58
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement M;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement IsTrinomial; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBAFFB60
        public void CloneCurve(){} // RVA: 0x7FFACBAFFFE0
        public void SupportsCoordinateSystem(){} // RVA: 0x7FFACBAC0590
        public void get_Infinity(){} // RVA: 0x7FFAC2FE9500
        public void get_FieldSize(){} // RVA: 0x7FFACBAFC4D0
        public void FromBigInteger(){} // RVA: 0x7FFACBB00030
        public void CreateRawPoint(){} // RVA: 0x7FFACBB00180 | overloaded x2
        public void get_IsKoblitz(){} // RVA: 0x7FFAC2F21320
        public void get_M(){} // RVA: 0x7FFACBAFC4D0
        public void get_IsTrinomial(){} // RVA: 0x7FFAC2F21320
        public void get_K1(){} // RVA: 0x7FFAC3026CB0
        public void get_K2(){} // RVA: 0x7FFAC31E48B0
        public void get_K3(){} // RVA: 0x7FFAC314F980
        public void CreateCacheSafeLookupTable(){} // RVA: 0x7FFACBB00220
        public void .cctor(){} // RVA: 0x7FFACBB004A0
    }

    public class SecT571R1Point : AbstractF2mPoint
    {
        public object YCoord;
        public object CompressionYTilde;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA87110 | overloaded x3
        public void Detach(){} // RVA: 0x7FFACBB00B00
        public void get_YCoord(){} // RVA: 0x7FFACBAC0F60
        public void get_CompressionYTilde(){} // RVA: 0x7FFACBAC1070
        public void Add(){} // RVA: 0x7FFACBB00C10
        public void Twice(){} // RVA: 0x7FFACBB015D0
        public void TwicePlus(){} // RVA: 0x7FFACBB01A40
        public void Negate(){} // RVA: 0x7FFACBB020C0
    }

}