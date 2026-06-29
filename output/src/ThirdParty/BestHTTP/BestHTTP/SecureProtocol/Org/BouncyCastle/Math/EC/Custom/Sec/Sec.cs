// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
// Classes: 100
// Methods: 1492

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Custom.Sec
{
    public class SecP128R1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP128R1_DEFAULT_COORDS;
        public object SECP128R1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA119BC0
        public void CloneCurve(){} // RVA: 0xA11A010
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA11A070
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA11A0D0
        public void FromBigInteger(){} // RVA: 0xA11A140
        public void CreateRawPoint(){} // RVA: 0xA11A380
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA11A420
        public void .cctor(){} // RVA: 0xA11A7C0
    }

    public class SecP128R1Field : Object
    {
        public object P;
        public object PExt;
        public object PExtInv;
        public object P3;
        public object PExt7;

        // ── Methods ──
        public void Add(){} // RVA: 0xA11ABA0
        public void AddExt(){} // RVA: 0xA11ADD0
        public void AddOne(){} // RVA: 0xA11AF60
        public void FromBigInteger(){} // RVA: 0xA11B140
        public void Half(){} // RVA: 0xA11B410
        public void Multiply(){} // RVA: 0xA11B5F0
        public void MultiplyAddToExt(){} // RVA: 0xA11B6B0
        public void Negate(){} // RVA: 0xA11B970
        public void Reduce(){} // RVA: 0xA11BB20
        public void Reduce32(){} // RVA: 0xA11BC70
        public void Square(){} // RVA: 0xA11BE40
        public void SquareN(){} // RVA: 0xA11BEF0
        public void Subtract(){} // RVA: 0xA11BFF0
        public void SubtractExt(){} // RVA: 0xA11C190
        public void Twice(){} // RVA: 0xA11C300
        public void AddPInvTo(){} // RVA: 0xA11C4B0
        public void SubPInvFrom(){} // RVA: 0xA11C520
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA11C590
    }

    public class SecP128R1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA11C980
        public void get_IsOne(){} // RVA: 0xA11C9E0
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA11CA70
        public void get_FieldName(){} // RVA: 0xA11CBC0
        public void get_FieldSize(){} // RVA: 0xA11CC00
        public void Add(){} // RVA: 0xA11CC70
        public void AddOne(){} // RVA: 0xA11CDE0
        public void Subtract(){} // RVA: 0xA11CEE0
        public void Multiply(){} // RVA: 0xA11D050
        public void Divide(){} // RVA: 0xA11D1C0
        public void Negate(){} // RVA: 0xA11D380
        public void Square(){} // RVA: 0xA11D480
        public void Invert(){} // RVA: 0xA11D580
        public void Sqrt(){} // RVA: 0xA11D6D0
        public void Equals(){} // RVA: 0xA11DB50
        public void GetHashCode(){} // RVA: 0xA11DBC0
        public void .cctor(){} // RVA: 0xA11DCC0
    }

    public class SecP128R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA11DEF0
        public void Add(){} // RVA: 0xA11E000
        public void Twice(){} // RVA: 0xA11E970
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA11F1B0
    }

    public class SecP160K1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP160K1_DEFAULT_COORDS;
        public object SECP160K1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11F2B0
        public void CloneCurve(){} // RVA: 0xA11F650
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA11F6A0
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA11F700
        public void FromBigInteger(){} // RVA: 0xA11F770
        public void CreateRawPoint(){} // RVA: 0xA11F8C0
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA11F960
        public void .cctor(){} // RVA: 0xA11FD40
    }

    public class SecP160K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA1201F0
        public void Add(){} // RVA: 0xA120300
        public void Twice(){} // RVA: 0xA120C70
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA121290
    }

    public class SecP160R1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP160R1_DEFAULT_COORDS;
        public object SECP160R1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA121390
        public void CloneCurve(){} // RVA: 0xA1217E0
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA121830
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA121890
        public void FromBigInteger(){} // RVA: 0xA121900
        public void CreateRawPoint(){} // RVA: 0xA121A50
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA121AF0
        public void .cctor(){} // RVA: 0xA121ED0
    }

    public class SecP160R1Field : Object
    {
        public object P;
        public object PExt;
        public object PExtInv;
        public object P4;
        public object PExt9;
        public object PInv;

        // ── Methods ──
        public void Add(){} // RVA: 0xA1222B0
        public void AddExt(){} // RVA: 0xA122400
        public void AddOne(){} // RVA: 0xA122660
        public void FromBigInteger(){} // RVA: 0xA122820
        public void Half(){} // RVA: 0xA122930
        public void Multiply(){} // RVA: 0xA122A60
        public void MultiplyAddToExt(){} // RVA: 0xA122B20
        public void Negate(){} // RVA: 0xA122D30
        public void Reduce(){} // RVA: 0xA122E30
        public void Reduce32(){} // RVA: 0xA122FB0
        public void Square(){} // RVA: 0xA123150
        public void SquareN(){} // RVA: 0xA123200
        public void Subtract(){} // RVA: 0xA123300
        public void SubtractExt(){} // RVA: 0xA123380
        public void Twice(){} // RVA: 0xA123560
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1236D0
    }

    public class SecP160R1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA123BC0
        public void get_IsOne(){} // RVA: 0xA123C20
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA123C80
        public void get_FieldName(){} // RVA: 0xA123C90
        public void get_FieldSize(){} // RVA: 0xA123CD0
        public void Add(){} // RVA: 0xA123D40
        public void AddOne(){} // RVA: 0xA123EB0
        public void Subtract(){} // RVA: 0xA123FB0
        public void Multiply(){} // RVA: 0xA124180
        public void Divide(){} // RVA: 0xA1242F0
        public void Negate(){} // RVA: 0xA1244B0
        public void Square(){} // RVA: 0xA1245B0
        public void Invert(){} // RVA: 0xA1246B0
        public void Sqrt(){} // RVA: 0xA124800
        public void Equals(){} // RVA: 0xA124C40
        public void GetHashCode(){} // RVA: 0xA124CB0
        public void .cctor(){} // RVA: 0xA124DB0
    }

    public class SecP160R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA124FC0
        public void Add(){} // RVA: 0xA1250D0
        public void Twice(){} // RVA: 0xA125B00
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA126390
    }

    public class SecP160R2Curve : AbstractFpCurve
    {
        public object q;
        public object SECP160R2_DEFAULT_COORDS;
        public object SECP160R2_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA126490
        public void CloneCurve(){} // RVA: 0xA1268E0
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA126930
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA126990
        public void FromBigInteger(){} // RVA: 0xA126A00
        public void CreateRawPoint(){} // RVA: 0xA126B50
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA126BF0
        public void .cctor(){} // RVA: 0xA126FD0
    }

    public class SecP160R2Field : Object
    {
        public object P;
        public object PExt;
        public object PExtInv;
        public object P4;
        public object PExt9;
        public object PInv33;

        // ── Methods ──
        public void Add(){} // RVA: 0xA1273B0
        public void AddExt(){} // RVA: 0xA127510
        public void AddOne(){} // RVA: 0xA127770
        public void FromBigInteger(){} // RVA: 0xA127940
        public void Half(){} // RVA: 0xA127A50
        public void Multiply(){} // RVA: 0xA127B80
        public void MultiplyAddToExt(){} // RVA: 0xA127C40
        public void Negate(){} // RVA: 0xA127E50
        public void Reduce(){} // RVA: 0xA127F50
        public void Reduce32(){} // RVA: 0xA128160
        public void Square(){} // RVA: 0xA128330
        public void SquareN(){} // RVA: 0xA1283E0
        public void Subtract(){} // RVA: 0xA1284E0
        public void SubtractExt(){} // RVA: 0xA128570
        public void Twice(){} // RVA: 0xA128750
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1288E0
    }

    public class SecP160R2FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA123BC0
        public void get_IsOne(){} // RVA: 0xA123C20
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA123C80
        public void get_FieldName(){} // RVA: 0xA128D40
        public void get_FieldSize(){} // RVA: 0xA128D80
        public void Add(){} // RVA: 0xA128DF0
        public void AddOne(){} // RVA: 0xA128F60
        public void Subtract(){} // RVA: 0xA129060
        public void Multiply(){} // RVA: 0xA129250
        public void Divide(){} // RVA: 0xA1293C0
        public void Negate(){} // RVA: 0xA129580
        public void Square(){} // RVA: 0xA129680
        public void Invert(){} // RVA: 0xA129780
        public void Sqrt(){} // RVA: 0xA1298D0
        public void Equals(){} // RVA: 0xA124C40
        public void GetHashCode(){} // RVA: 0xA129EC0
        public void .cctor(){} // RVA: 0xA129FC0
    }

    public class SecP160R2Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA12A1D0
        public void Add(){} // RVA: 0xA12A2E0
        public void Twice(){} // RVA: 0xA12AC50
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA12B310
    }

    public class SecP192K1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP192K1_DEFAULT_COORDS;
        public object SECP192K1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA12B410
        public void CloneCurve(){} // RVA: 0xA12B7B0
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA12B800
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA12B860
        public void FromBigInteger(){} // RVA: 0xA12B8D0
        public void CreateRawPoint(){} // RVA: 0xA12BA20
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA12BAC0
        public void .cctor(){} // RVA: 0xA12BD60
    }

    public class SecP192K1Field : Object
    {
        public object P;
        public object PExt;
        public object PExtInv;
        public object P5;
        public object PExt11;
        public object PInv33;

        // ── Methods ──
        public void Add(){} // RVA: 0xA12C140
        public void AddExt(){} // RVA: 0xA12C2A0
        public void AddOne(){} // RVA: 0xA12C500
        public void FromBigInteger(){} // RVA: 0xA12C6D0
        public void Half(){} // RVA: 0xA12C7E0
        public void Multiply(){} // RVA: 0xA12C910
        public void MultiplyAddToExt(){} // RVA: 0xA12C9D0
        public void Negate(){} // RVA: 0xA12CBE0
        public void Reduce(){} // RVA: 0xA12CD00
        public void Reduce32(){} // RVA: 0xA12CF20
        public void Square(){} // RVA: 0xA12D0F0
        public void SquareN(){} // RVA: 0xA12D1A0
        public void Subtract(){} // RVA: 0xA12D2A0
        public void SubtractExt(){} // RVA: 0xA12D330
        public void Twice(){} // RVA: 0xA12D510
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA12D6A0
    }

    public class SecP192K1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA12DB90
        public void get_IsOne(){} // RVA: 0xA12DBF0
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA12DC50
        public void get_FieldName(){} // RVA: 0xA12DC60
        public void get_FieldSize(){} // RVA: 0xA12DCA0
        public void Add(){} // RVA: 0xA12DD10
        public void AddOne(){} // RVA: 0xA12DFA0
        public void Subtract(){} // RVA: 0xA12E0A0
        public void Multiply(){} // RVA: 0xA12E290
        public void Divide(){} // RVA: 0xA12E400
        public void Negate(){} // RVA: 0xA12E5C0
        public void Square(){} // RVA: 0xA12E6C0
        public void Invert(){} // RVA: 0xA12E7C0
        public void Sqrt(){} // RVA: 0xA12E910
        public void Equals(){} // RVA: 0xA12EE70
        public void GetHashCode(){} // RVA: 0xA12EEE0
        public void .cctor(){} // RVA: 0xA12EFE0
    }

    public class SecP192K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA12F1F0
        public void Add(){} // RVA: 0xA12F300
        public void Twice(){} // RVA: 0xA12FC70
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA130290
    }

    public class SecP192R1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP192R1_DEFAULT_COORDS;
        public object SECP192R1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA130390
        public void CloneCurve(){} // RVA: 0xA1307E0
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA130830
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA130890
        public void FromBigInteger(){} // RVA: 0xA130900
        public void CreateRawPoint(){} // RVA: 0xA130A50
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA130AF0
        public void .cctor(){} // RVA: 0xA130D90
    }

    public class SecP192R1Field : Object
    {
        public object P;
        public object PExt;
        public object PExtInv;
        public object P5;
        public object PExt11;

        // ── Methods ──
        public void Add(){} // RVA: 0xA131170
        public void AddExt(){} // RVA: 0xA131310
        public void AddOne(){} // RVA: 0xA131570
        public void FromBigInteger(){} // RVA: 0xA131780
        public void Half(){} // RVA: 0xA131890
        public void Multiply(){} // RVA: 0xA1319C0
        public void MultiplyAddToExt(){} // RVA: 0xA131A80
        public void Negate(){} // RVA: 0xA131C90
        public void Reduce(){} // RVA: 0xA131DB0
        public void Reduce32(){} // RVA: 0xA132060
        public void Square(){} // RVA: 0xA1321E0
        public void SquareN(){} // RVA: 0xA132290
        public void Subtract(){} // RVA: 0xA132390
        public void SubtractExt(){} // RVA: 0xA1324A0
        public void Twice(){} // RVA: 0xA132680
        public void AddPInvTo(){} // RVA: 0xA132860
        public void SubPInvFrom(){} // RVA: 0xA132900
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA132990
    }

    public class SecP192R1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA12DB90
        public void get_IsOne(){} // RVA: 0xA12DBF0
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA12DC50
        public void get_FieldName(){} // RVA: 0xA132DF0
        public void get_FieldSize(){} // RVA: 0xA132E30
        public void Add(){} // RVA: 0xA132EA0
        public void AddOne(){} // RVA: 0xA133010
        public void Subtract(){} // RVA: 0xA133110
        public void Multiply(){} // RVA: 0xA133280
        public void Divide(){} // RVA: 0xA1333F0
        public void Negate(){} // RVA: 0xA1335B0
        public void Square(){} // RVA: 0xA1336B0
        public void Invert(){} // RVA: 0xA1337B0
        public void Sqrt(){} // RVA: 0xA133900
        public void Equals(){} // RVA: 0xA12EE70
        public void GetHashCode(){} // RVA: 0xA133D50
        public void .cctor(){} // RVA: 0xA133E50
    }

    public class SecP192R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA134060
        public void Add(){} // RVA: 0xA134170
        public void Twice(){} // RVA: 0xA134AE0
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA1351A0
    }

    public class SecP224K1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP224K1_DEFAULT_COORDS;
        public object SECP224K1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1352A0
        public void CloneCurve(){} // RVA: 0xA135640
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA135690
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA1356F0
        public void FromBigInteger(){} // RVA: 0xA135760
        public void CreateRawPoint(){} // RVA: 0xA1358B0
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA135950
        public void .cctor(){} // RVA: 0xA135BE0
    }

    public class SecP224K1Field : Object
    {
        public object P;
        public object PExt;
        public object PExtInv;
        public object P6;
        public object PExt13;
        public object PInv33;

        // ── Methods ──
        public void Add(){} // RVA: 0xA135FC0
        public void AddExt(){} // RVA: 0xA136120
        public void AddOne(){} // RVA: 0xA136380
        public void FromBigInteger(){} // RVA: 0xA136550
        public void Half(){} // RVA: 0xA136660
        public void Multiply(){} // RVA: 0xA136790
        public void MultiplyAddToExt(){} // RVA: 0xA136850
        public void Negate(){} // RVA: 0xA136A60
        public void Reduce(){} // RVA: 0xA136B80
        public void Reduce32(){} // RVA: 0xA136DA0
        public void Square(){} // RVA: 0xA136F70
        public void SquareN(){} // RVA: 0xA137020
        public void Subtract(){} // RVA: 0xA137120
        public void SubtractExt(){} // RVA: 0xA1371B0
        public void Twice(){} // RVA: 0xA137390
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA137520
    }

    public class SecP224K1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object PRECOMP_POW2;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA137A10
        public void get_IsOne(){} // RVA: 0xA137A70
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA137AD0
        public void get_FieldName(){} // RVA: 0xA137AE0
        public void get_FieldSize(){} // RVA: 0xA137B20
        public void Add(){} // RVA: 0xA137B90
        public void AddOne(){} // RVA: 0xA137E20
        public void Subtract(){} // RVA: 0xA137F20
        public void Multiply(){} // RVA: 0xA138110
        public void Divide(){} // RVA: 0xA138280
        public void Negate(){} // RVA: 0xA138440
        public void Square(){} // RVA: 0xA138540
        public void Invert(){} // RVA: 0xA138640
        public void Sqrt(){} // RVA: 0xA138790
        public void Equals(){} // RVA: 0xA138E10
        public void GetHashCode(){} // RVA: 0xA138E80
        public void .cctor(){} // RVA: 0xA138F80
    }

    public class SecP224K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA139260
        public void Add(){} // RVA: 0xA139370
        public void Twice(){} // RVA: 0xA139CE0
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA13A300
    }

    public class SecP224R1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP224R1_DEFAULT_COORDS;
        public object SECP224R1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA13A400
        public void CloneCurve(){} // RVA: 0xA13A850
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA13A8A0
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA13A900
        public void FromBigInteger(){} // RVA: 0xA13A970
        public void CreateRawPoint(){} // RVA: 0xA13AAC0
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA13AB60
        public void .cctor(){} // RVA: 0xA13ADF0
    }

    public class SecP224R1Field : Object
    {
        public object P;
        public object PExt;
        public object PExtInv;
        public object P6;
        public object PExt13;

        // ── Methods ──
        public void Add(){} // RVA: 0xA13B1D0
        public void AddExt(){} // RVA: 0xA13B2F0
        public void AddOne(){} // RVA: 0xA13B550
        public void FromBigInteger(){} // RVA: 0xA13B6E0
        public void Half(){} // RVA: 0xA13B7F0
        public void Multiply(){} // RVA: 0xA13B920
        public void MultiplyAddToExt(){} // RVA: 0xA13B9E0
        public void Negate(){} // RVA: 0xA13BBF0
        public void Reduce(){} // RVA: 0xA13BD10
        public void Reduce32(){} // RVA: 0xA13C010
        public void Square(){} // RVA: 0xA13C1A0
        public void SquareN(){} // RVA: 0xA13C250
        public void Subtract(){} // RVA: 0xA13C350
        public void SubtractExt(){} // RVA: 0xA13C470
        public void Twice(){} // RVA: 0xA13C650
        public void AddPInvTo(){} // RVA: 0xA13C7B0
        public void SubPInvFrom(){} // RVA: 0xA13C860
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA13C910
    }

    public class SecP224R1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA137A10
        public void get_IsOne(){} // RVA: 0xA137A70
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA137AD0
        public void get_FieldName(){} // RVA: 0xA13CD70
        public void get_FieldSize(){} // RVA: 0xA13CDB0
        public void Add(){} // RVA: 0xA13CE20
        public void AddOne(){} // RVA: 0xA13CF90
        public void Subtract(){} // RVA: 0xA13D090
        public void Multiply(){} // RVA: 0xA13D200
        public void Divide(){} // RVA: 0xA13D370
        public void Negate(){} // RVA: 0xA13D530
        public void Square(){} // RVA: 0xA13D630
        public void Invert(){} // RVA: 0xA13D730
        public void Sqrt(){} // RVA: 0xA13D880
        public void Equals(){} // RVA: 0xA138E10
        public void GetHashCode(){} // RVA: 0xA13DCC0
        public void IsSquare(){} // RVA: 0xA13DDC0
        public void RM(){} // RVA: 0xA13E0B0
        public void RP(){} // RVA: 0xA13E2A0
        public void RS(){} // RVA: 0xA13E6B0
        public void TrySqrt(){} // RVA: 0xA13E7D0
        public void .cctor(){} // RVA: 0xA13ECE0
    }

    public class SecP224R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA13EEF0
        public void Add(){} // RVA: 0xA13F000
        public void Twice(){} // RVA: 0xA13F970
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA140030
    }

    public class SecP256K1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP256K1_DEFAULT_COORDS;
        public object SECP256K1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA140130
        public void CloneCurve(){} // RVA: 0xA1404D0
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA140520
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA140580
        public void FromBigInteger(){} // RVA: 0xA1405F0
        public void CreateRawPoint(){} // RVA: 0xA140740
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA1407E0
        public void .cctor(){} // RVA: 0xA140A70
    }

    public class SecP256K1Field : Object
    {
        public object P;
        public object PExt;
        public object PExtInv;
        public object P7;
        public object PExt15;
        public object PInv33;

        // ── Methods ──
        public void Add(){} // RVA: 0xA140E50
        public void AddExt(){} // RVA: 0xA140FB0
        public void AddOne(){} // RVA: 0xA141210
        public void FromBigInteger(){} // RVA: 0xA1413E0
        public void Half(){} // RVA: 0xA1414F0
        public void Multiply(){} // RVA: 0xA141620
        public void MultiplyAddToExt(){} // RVA: 0xA1416E0
        public void Negate(){} // RVA: 0xA1418F0
        public void Reduce(){} // RVA: 0xA141A20
        public void Reduce32(){} // RVA: 0xA141C40
        public void Square(){} // RVA: 0xA141E10
        public void SquareN(){} // RVA: 0xA141EC0
        public void Subtract(){} // RVA: 0xA141FC0
        public void SubtractExt(){} // RVA: 0xA142050
        public void Twice(){} // RVA: 0xA142230
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1423C0
    }

    public class SecP256K1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA1428B0
        public void get_IsOne(){} // RVA: 0xA142910
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA142970
        public void get_FieldName(){} // RVA: 0xA142980
        public void get_FieldSize(){} // RVA: 0xA1429C0
        public void Add(){} // RVA: 0xA142A30
        public void AddOne(){} // RVA: 0xA142CC0
        public void Subtract(){} // RVA: 0xA142DC0
        public void Multiply(){} // RVA: 0xA142FB0
        public void Divide(){} // RVA: 0xA143120
        public void Negate(){} // RVA: 0xA1432E0
        public void Square(){} // RVA: 0xA1433E0
        public void Invert(){} // RVA: 0xA1434E0
        public void Sqrt(){} // RVA: 0xA143630
        public void Equals(){} // RVA: 0xA143C30
        public void GetHashCode(){} // RVA: 0xA143CA0
        public void .cctor(){} // RVA: 0xA143DA0
    }

    public class SecP256K1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA143FB0
        public void Add(){} // RVA: 0xA1440C0
        public void Twice(){} // RVA: 0xA144A30
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA145050
    }

    public class SecP256R1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP256R1_DEFAULT_COORDS;
        public object SECP256R1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA145150
        public void CloneCurve(){} // RVA: 0xA1455A0
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA1455F0
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA145650
        public void FromBigInteger(){} // RVA: 0xA1456C0
        public void CreateRawPoint(){} // RVA: 0xA145810
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA1458B0
        public void .cctor(){} // RVA: 0xA145B40
    }

    public class SecP256R1Field : Object
    {
        public object P;
        public object PExt;
        public object P7;
        public object PExt15;

        // ── Methods ──
        public void Add(){} // RVA: 0xA145F20
        public void AddExt(){} // RVA: 0xA146040
        public void AddOne(){} // RVA: 0xA146220
        public void FromBigInteger(){} // RVA: 0xA1463B0
        public void Half(){} // RVA: 0xA1464C0
        public void Multiply(){} // RVA: 0xA1465F0
        public void MultiplyAddToExt(){} // RVA: 0xA1466B0
        public void Negate(){} // RVA: 0xA146830
        public void Reduce(){} // RVA: 0xA146960
        public void Reduce32(){} // RVA: 0xA146BD0
        public void Square(){} // RVA: 0xA146DA0
        public void SquareN(){} // RVA: 0xA146E50
        public void Subtract(){} // RVA: 0xA146F50
        public void SubtractExt(){} // RVA: 0xA147090
        public void Twice(){} // RVA: 0xA1471F0
        public void AddPInvTo(){} // RVA: 0xA147350
        public void SubPInvFrom(){} // RVA: 0xA147430
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA147510
    }

    public class SecP256R1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA1428B0
        public void get_IsOne(){} // RVA: 0xA142910
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA142970
        public void get_FieldName(){} // RVA: 0xA1478D0
        public void get_FieldSize(){} // RVA: 0xA147910
        public void Add(){} // RVA: 0xA147980
        public void AddOne(){} // RVA: 0xA147AF0
        public void Subtract(){} // RVA: 0xA147BF0
        public void Multiply(){} // RVA: 0xA147D60
        public void Divide(){} // RVA: 0xA147ED0
        public void Negate(){} // RVA: 0xA148090
        public void Square(){} // RVA: 0xA148190
        public void Invert(){} // RVA: 0xA148290
        public void Sqrt(){} // RVA: 0xA1483E0
        public void Equals(){} // RVA: 0xA143C30
        public void GetHashCode(){} // RVA: 0xA148830
        public void .cctor(){} // RVA: 0xA148930
    }

    public class SecP256R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA148B40
        public void Add(){} // RVA: 0xA148C50
        public void Twice(){} // RVA: 0xA149740
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA149F40
    }

    public class SecP384R1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP384R1_DEFAULT_COORDS;
        public object SECP384R1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA14A040
        public void CloneCurve(){} // RVA: 0xA14A490
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA14A4E0
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA14A540
        public void FromBigInteger(){} // RVA: 0xA14A5B0
        public void CreateRawPoint(){} // RVA: 0xA14A700
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA14A7A0
        public void .cctor(){} // RVA: 0xA14AA50
    }

    public class SecP384R1Field : Object
    {
        public object P;
        public object PExt;
        public object PExtInv;
        public object P11;
        public object PExt23;

        // ── Methods ──
        public void Add(){} // RVA: 0xA14AE30
        public void AddExt(){} // RVA: 0xA14AFB0
        public void AddOne(){} // RVA: 0xA14B210
        public void FromBigInteger(){} // RVA: 0xA14B3A0
        public void Half(){} // RVA: 0xA14B500
        public void Multiply(){} // RVA: 0xA14B690
        public void Negate(){} // RVA: 0xA14B750
        public void Reduce(){} // RVA: 0xA14B8B0
        public void Reduce32(){} // RVA: 0xA14BC40
        public void Square(){} // RVA: 0xA14BDF0
        public void SquareN(){} // RVA: 0xA14BEA0
        public void Subtract(){} // RVA: 0xA14BFA0
        public void SubtractExt(){} // RVA: 0xA14C140
        public void Twice(){} // RVA: 0xA14C320
        public void AddPInvTo(){} // RVA: 0xA14C480
        public void SubPInvFrom(){} // RVA: 0xA14C550
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA14C620
    }

    public class SecP384R1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA14CB70
        public void get_IsOne(){} // RVA: 0xA14CBD0
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA14CC30
        public void get_FieldName(){} // RVA: 0xA14CC50
        public void get_FieldSize(){} // RVA: 0xA14CC90
        public void Add(){} // RVA: 0xA14CD00
        public void AddOne(){} // RVA: 0xA14CFC0
        public void Subtract(){} // RVA: 0xA14D0C0
        public void Multiply(){} // RVA: 0xA14D3A0
        public void Divide(){} // RVA: 0xA14D510
        public void Negate(){} // RVA: 0xA14D6D0
        public void Square(){} // RVA: 0xA14D7D0
        public void Invert(){} // RVA: 0xA14D8D0
        public void Sqrt(){} // RVA: 0xA14DA20
        public void Equals(){} // RVA: 0xA14DFB0
        public void GetHashCode(){} // RVA: 0xA14E020
        public void .cctor(){} // RVA: 0xA14E120
    }

    public class SecP384R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA14E330
        public void Add(){} // RVA: 0xA14E440
        public void Twice(){} // RVA: 0xA14EE60
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA14FE50
    }

    public class SecP521R1Curve : AbstractFpCurve
    {
        public object q;
        public object SECP521R1_DEFAULT_COORDS;
        public object SECP521R1_FE_INTS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA14FF50
        public void CloneCurve(){} // RVA: 0xA1503A0
        public void SupportsCoordinateSystem(){} // RVA: 0xA11A060
        public void get_Q(){} // RVA: 0xA1503F0
        public void get_Infinity(){} // RVA: 0xBE58B0
        public void get_FieldSize(){} // RVA: 0xA150450
        public void FromBigInteger(){} // RVA: 0xA1504C0
        public void CreateRawPoint(){} // RVA: 0xA150610
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA1506B0
        public void .cctor(){} // RVA: 0xA150950
    }

    public class SecP521R1Field : Object
    {
        public object P;
        public object P16;

        // ── Methods ──
        public void Add(){} // RVA: 0xA150D30
        public void AddOne(){} // RVA: 0xA150EE0
        public void FromBigInteger(){} // RVA: 0xA1510A0
        public void Half(){} // RVA: 0xA151180
        public void Multiply(){} // RVA: 0xA151210
        public void Negate(){} // RVA: 0xA1513A0
        public void Reduce(){} // RVA: 0xA151500
        public void Reduce23(){} // RVA: 0xA1516E0
        public void Square(){} // RVA: 0xA151860
        public void SquareN(){} // RVA: 0xA1519A0
        public void Subtract(){} // RVA: 0xA151BC0
        public void Twice(){} // RVA: 0xA151CE0
        public void ImplMultiply(){} // RVA: 0xA151D80
        public void ImplSquare(){} // RVA: 0xA151E90
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA151F40
    }

    public class SecP521R1FieldElement : AbstractFpFieldElement
    {
        public object Q;
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsZero(){} // RVA: 0xA1522B0
        public void get_IsOne(){} // RVA: 0xA152310
        public void TestBitZero(){} // RVA: 0xA11CA40
        public void ToBigInteger(){} // RVA: 0xA152370
        public void get_FieldName(){} // RVA: 0xA152390
        public void get_FieldSize(){} // RVA: 0xA1523D0
        public void Add(){} // RVA: 0xA152440
        public void AddOne(){} // RVA: 0xA152720
        public void Subtract(){} // RVA: 0xA1529E0
        public void Multiply(){} // RVA: 0xA152C40
        public void Divide(){} // RVA: 0xA152DB0
        public void Negate(){} // RVA: 0xA152F70
        public void Square(){} // RVA: 0xA1531C0
        public void Invert(){} // RVA: 0xA1532C0
        public void Sqrt(){} // RVA: 0xA153410
        public void Equals(){} // RVA: 0xA153770
        public void GetHashCode(){} // RVA: 0xA1537E0
        public void .cctor(){} // RVA: 0xA1538E0
    }

    public class SecP521R1Point : AbstractFpPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA153AF0
        public void Add(){} // RVA: 0xA153C00
        public void Twice(){} // RVA: 0xA154A50
        public void TwicePlus(){} // RVA: 0xA11F030
        public void ThreeTimes(){} // RVA: 0xA11F130
        public void Negate(){} // RVA: 0xA1555D0
    }

    public class SecT113Field : Object
    {
        public object M49;
        public object M57;

        // ── Methods ──
        public void Add(){} // RVA: 0xA1556D0
        public void AddExt(){} // RVA: 0xA155740
        public void AddOne(){} // RVA: 0xA1557F0
        public void AddTo(){} // RVA: 0xA155840
        public void FromBigInteger(){} // RVA: 0xA155890
        public void HalfTrace(){} // RVA: 0xA1558A0
        public void Invert(){} // RVA: 0xA155B70
        public void Multiply(){} // RVA: 0xA155DB0
        public void MultiplyAddToExt(){} // RVA: 0xA155E40
        public void Reduce(){} // RVA: 0xA155F20
        public void Reduce15(){} // RVA: 0xA156000
        public void Sqrt(){} // RVA: 0xA156070
        public void Square(){} // RVA: 0xA156140
        public void SquareAddToExt(){} // RVA: 0xA1561F0
        public void SquareN(){} // RVA: 0xA156300
        public void Trace(){} // RVA: 0xA1564D0
        public void ImplMultiply(){} // RVA: 0xA156500
        public void ImplMulw(){} // RVA: 0xA156710
        public void ImplSquare(){} // RVA: 0xA156940
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SecT113FieldElement : AbstractF2mFieldElement
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsOne(){} // RVA: 0xA156AE0
        public void get_IsZero(){} // RVA: 0xA156B50
        public void TestBitZero(){} // RVA: 0xA156BB0
        public void ToBigInteger(){} // RVA: 0xA156BE0
        public void get_FieldName(){} // RVA: 0xA156D00
        public void get_FieldSize(){} // RVA: 0x2950660
        public void Add(){} // RVA: 0xA156D40
        public void AddOne(){} // RVA: 0xA156EF0
        public void Subtract(){} // RVA: 0x5BA5570
        public void Multiply(){} // RVA: 0xA157010
        public void MultiplyMinusProduct(){} // RVA: 0xA157150
        public void MultiplyPlusProduct(){} // RVA: 0xA157170
        public void Divide(){} // RVA: 0xA1573A0
        public void Negate(){} // RVA: 0x2303260
        public void Square(){} // RVA: 0xA1573F0
        public void SquareMinusProduct(){} // RVA: 0xA1574D0
        public void SquarePlusProduct(){} // RVA: 0xA1574F0
        public void SquarePow(){} // RVA: 0xA1577D0
        public void HalfTrace(){} // RVA: 0xA1578D0
        public void get_HasFastTrace(){} // RVA: 0xC2E4C0
        public void Trace(){} // RVA: 0xA1579B0
        public void Invert(){} // RVA: 0xA1579E0
        public void Sqrt(){} // RVA: 0xA157AC0
        public void get_Representation(){} // RVA: 0xC50A80
        public void get_M(){} // RVA: 0x2950660
        public void get_K1(){} // RVA: 0x2006E40
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void Equals(){} // RVA: 0xA157D80
        public void GetHashCode(){} // RVA: 0xA157DF0
    }

    public class SecT113R1Curve : AbstractF2mCurve
    {
        public object SECT113R1_DEFAULT_COORDS;
        public object SECT113R1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA157EA0
        public void CloneCurve(){} // RVA: 0xA158380
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0x2950660
        public void FromBigInteger(){} // RVA: 0xA1583E0
        public void CreateRawPoint(){} // RVA: 0xA158530
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0x2950660
        public void get_IsTrinomial(){} // RVA: 0xC2E4C0
        public void get_K1(){} // RVA: 0x2006E40
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA1585D0
    }

    public class SecT113R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA158CD0
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA158F80
        public void Twice(){} // RVA: 0xA159970
        public void TwicePlus(){} // RVA: 0xA159E30
        public void Negate(){} // RVA: 0xA15A530
    }

    public class SecT113R2Curve : AbstractF2mCurve
    {
        public object SECT113R2_DEFAULT_COORDS;
        public object SECT113R2_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA15A6E0
        public void CloneCurve(){} // RVA: 0xA15ABC0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0x2950660
        public void FromBigInteger(){} // RVA: 0xA15AC10
        public void CreateRawPoint(){} // RVA: 0xA15AD60
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0x2950660
        public void get_IsTrinomial(){} // RVA: 0xC2E4C0
        public void get_K1(){} // RVA: 0x2006E40
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA15AE00
    }

    public class SecT113R2Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA15B500
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA15B610
        public void Twice(){} // RVA: 0xA15C000
        public void TwicePlus(){} // RVA: 0xA15C4C0
        public void Negate(){} // RVA: 0xA15CBC0
    }

    public class SecT131Field : Object
    {
        public object M03;
        public object M44;
        public object ROOT_Z;

        // ── Methods ──
        public void Add(){} // RVA: 0xA15CD70
        public void AddExt(){} // RVA: 0xA15CE00
        public void AddOne(){} // RVA: 0xA15CEE0
        public void AddTo(){} // RVA: 0xA15CF40
        public void FromBigInteger(){} // RVA: 0xA15CFB0
        public void HalfTrace(){} // RVA: 0xA15CFC0
        public void Invert(){} // RVA: 0xA15D250
        public void Multiply(){} // RVA: 0xA15D4C0
        public void MultiplyAddToExt(){} // RVA: 0xA15D580
        public void Reduce(){} // RVA: 0xA15D6B0
        public void Reduce61(){} // RVA: 0xA15D7F0
        public void Sqrt(){} // RVA: 0xA15D880
        public void Square(){} // RVA: 0xA15DA00
        public void SquareAddToExt(){} // RVA: 0xA15DB30
        public void SquareN(){} // RVA: 0xA15DCD0
        public void Trace(){} // RVA: 0xA15DEE0
        public void ImplCompactExt(){} // RVA: 0xA15DF30
        public void ImplMultiply(){} // RVA: 0xA15E020
        public void ImplMulw(){} // RVA: 0xA15E620
        public void ImplSquare(){} // RVA: 0xA15E880
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA15E920
    }

    public class SecT131FieldElement : AbstractF2mFieldElement
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsOne(){} // RVA: 0xA15EB80
        public void get_IsZero(){} // RVA: 0xA15EBF0
        public void TestBitZero(){} // RVA: 0xA156BB0
        public void ToBigInteger(){} // RVA: 0xA15EC50
        public void get_FieldName(){} // RVA: 0xA15EC60
        public void get_FieldSize(){} // RVA: 0xA15ECA0
        public void Add(){} // RVA: 0xA15ECB0
        public void AddOne(){} // RVA: 0xA15EEB0
        public void Subtract(){} // RVA: 0x5BA5570
        public void Multiply(){} // RVA: 0xA15F020
        public void MultiplyMinusProduct(){} // RVA: 0xA157150
        public void MultiplyPlusProduct(){} // RVA: 0xA15F190
        public void Divide(){} // RVA: 0xA1573A0
        public void Negate(){} // RVA: 0x2303260
        public void Square(){} // RVA: 0xA15F3F0
        public void SquareMinusProduct(){} // RVA: 0xA1574D0
        public void SquarePlusProduct(){} // RVA: 0xA15F4F0
        public void SquarePow(){} // RVA: 0xA15F700
        public void HalfTrace(){} // RVA: 0xA15F830
        public void get_HasFastTrace(){} // RVA: 0xC2E4C0
        public void Trace(){} // RVA: 0xA15F930
        public void Invert(){} // RVA: 0xA15F9C0
        public void Sqrt(){} // RVA: 0xA15FAC0
        public void get_Representation(){} // RVA: 0x12FC4A0
        public void get_M(){} // RVA: 0xA15ECA0
        public void get_K1(){} // RVA: 0xC50A80
        public void get_K2(){} // RVA: 0x12FC4A0
        public void get_K3(){} // RVA: 0x17FCE50
        public void Equals(){} // RVA: 0xA15FE70
        public void GetHashCode(){} // RVA: 0xA15FEE0
    }

    public class SecT131R1Curve : AbstractF2mCurve
    {
        public object SECT131R1_DEFAULT_COORDS;
        public object SECT131R1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA15FF90
        public void CloneCurve(){} // RVA: 0xA1604A0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA15ECA0
        public void FromBigInteger(){} // RVA: 0xA1604F0
        public void CreateRawPoint(){} // RVA: 0xA160640
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0xA15ECA0
        public void get_IsTrinomial(){} // RVA: 0xB43320
        public void get_K1(){} // RVA: 0xC50A80
        public void get_K2(){} // RVA: 0x12FC4A0
        public void get_K3(){} // RVA: 0x17FCE50
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA1606E0
    }

    public class SecT131R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA160E30
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA160F40
        public void Twice(){} // RVA: 0xA161930
        public void TwicePlus(){} // RVA: 0xA161DF0
        public void Negate(){} // RVA: 0xA1624F0
    }

    public class SecT131R2Curve : AbstractF2mCurve
    {
        public object SECT131R2_DEFAULT_COORDS;
        public object SECT131R2_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1626A0
        public void CloneCurve(){} // RVA: 0xA162BB0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_FieldSize(){} // RVA: 0xA15ECA0
        public void FromBigInteger(){} // RVA: 0xA162C00
        public void CreateRawPoint(){} // RVA: 0xA162D50
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0xA15ECA0
        public void get_IsTrinomial(){} // RVA: 0xB43320
        public void get_K1(){} // RVA: 0xC50A80
        public void get_K2(){} // RVA: 0x12FC4A0
        public void get_K3(){} // RVA: 0x17FCE50
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA162DF0
    }

    public class SecT131R2Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA163540
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA163650
        public void Twice(){} // RVA: 0xA164040
        public void TwicePlus(){} // RVA: 0xA164500
        public void Negate(){} // RVA: 0xA164C00
    }

    public class SecT163Field : Object
    {
        public object M35;
        public object M55;
        public object ROOT_Z;

        // ── Methods ──
        public void Add(){} // RVA: 0xA15CD70
        public void AddExt(){} // RVA: 0xA164DB0
        public void AddOne(){} // RVA: 0xA15CEE0
        public void AddTo(){} // RVA: 0xA15CF40
        public void FromBigInteger(){} // RVA: 0xA164EC0
        public void HalfTrace(){} // RVA: 0xA164ED0
        public void Invert(){} // RVA: 0xA165110
        public void Multiply(){} // RVA: 0xA1653B0
        public void MultiplyAddToExt(){} // RVA: 0xA165470
        public void Reduce(){} // RVA: 0xA165530
        public void Reduce29(){} // RVA: 0xA1656C0
        public void Sqrt(){} // RVA: 0xA165740
        public void Square(){} // RVA: 0xA1658C0
        public void SquareAddToExt(){} // RVA: 0xA1659C0
        public void SquareN(){} // RVA: 0xA165AC0
        public void Trace(){} // RVA: 0xA165C60
        public void ImplCompactExt(){} // RVA: 0xA165CA0
        public void ImplMultiply(){} // RVA: 0xA165D90
        public void ImplMulw(){} // RVA: 0xA166390
        public void ImplSquare(){} // RVA: 0xA166590
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA166610
    }

    public class SecT163FieldElement : AbstractF2mFieldElement
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsOne(){} // RVA: 0xA15EB80
        public void get_IsZero(){} // RVA: 0xA15EBF0
        public void TestBitZero(){} // RVA: 0xA156BB0
        public void ToBigInteger(){} // RVA: 0xA15EC50
        public void get_FieldName(){} // RVA: 0xA1667E0
        public void get_FieldSize(){} // RVA: 0x2950B90
        public void Add(){} // RVA: 0xA166820
        public void AddOne(){} // RVA: 0xA166A20
        public void Subtract(){} // RVA: 0x5BA5570
        public void Multiply(){} // RVA: 0xA166B90
        public void MultiplyMinusProduct(){} // RVA: 0xA157150
        public void MultiplyPlusProduct(){} // RVA: 0xA166D00
        public void Divide(){} // RVA: 0xA1573A0
        public void Negate(){} // RVA: 0x2303260
        public void Square(){} // RVA: 0xA166F60
        public void SquareMinusProduct(){} // RVA: 0xA1574D0
        public void SquarePlusProduct(){} // RVA: 0xA167060
        public void SquarePow(){} // RVA: 0xA167350
        public void HalfTrace(){} // RVA: 0xA167480
        public void get_HasFastTrace(){} // RVA: 0xC2E4C0
        public void Trace(){} // RVA: 0xA167580
        public void Invert(){} // RVA: 0xA167600
        public void Sqrt(){} // RVA: 0xA167700
        public void get_Representation(){} // RVA: 0x12FC4A0
        public void get_M(){} // RVA: 0x2950B90
        public void get_K1(){} // RVA: 0x12FC4A0
        public void get_K2(){} // RVA: 0x13510C0
        public void get_K3(){} // RVA: 0x132D270
        public void Equals(){} // RVA: 0xA15FE70
        public void GetHashCode(){} // RVA: 0xA167AB0
    }

    public class SecT163K1Curve : AbstractF2mCurve
    {
        public object SECT163K1_DEFAULT_COORDS;
        public object SECT163K1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA167B60
        public void CloneCurve(){} // RVA: 0xA167FC0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void CreateDefaultMultiplier(){} // RVA: 0xA168010
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0x2950B90
        public void FromBigInteger(){} // RVA: 0xA168050
        public void CreateRawPoint(){} // RVA: 0xA1681A0
        public void get_IsKoblitz(){} // RVA: 0xC2E4C0
        public void get_M(){} // RVA: 0x2950B90
        public void get_IsTrinomial(){} // RVA: 0xB43320
        public void get_K1(){} // RVA: 0x12FC4A0
        public void get_K2(){} // RVA: 0x13510C0
        public void get_K3(){} // RVA: 0x132D270
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA168240
    }

    public class SecT163K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA168990
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA168AA0
        public void Twice(){} // RVA: 0xA169430
        public void TwicePlus(){} // RVA: 0xA1698B0
        public void Negate(){} // RVA: 0xA169F20
    }

    public class SecT163R1Curve : AbstractF2mCurve
    {
        public object SECT163R1_DEFAULT_COORDS;
        public object SECT163R1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA16A0D0
        public void CloneCurve(){} // RVA: 0xA16A5E0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0x2950B90
        public void FromBigInteger(){} // RVA: 0xA16A630
        public void CreateRawPoint(){} // RVA: 0xA16A780
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0x2950B90
        public void get_IsTrinomial(){} // RVA: 0xB43320
        public void get_K1(){} // RVA: 0x12FC4A0
        public void get_K2(){} // RVA: 0x13510C0
        public void get_K3(){} // RVA: 0x132D270
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA16A820
    }

    public class SecT163R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA16AF70
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA16B080
        public void Twice(){} // RVA: 0xA16BA70
        public void TwicePlus(){} // RVA: 0xA16BF30
        public void Negate(){} // RVA: 0xA16C630
    }

    public class SecT163R2Curve : AbstractF2mCurve
    {
        public object SECT163R2_DEFAULT_COORDS;
        public object SECT163R2_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA16C7E0
        public void CloneCurve(){} // RVA: 0xA16CC90
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0x2950B90
        public void FromBigInteger(){} // RVA: 0xA16CCE0
        public void CreateRawPoint(){} // RVA: 0xA16CE30
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0x2950B90
        public void get_IsTrinomial(){} // RVA: 0xB43320
        public void get_K1(){} // RVA: 0x12FC4A0
        public void get_K2(){} // RVA: 0x13510C0
        public void get_K3(){} // RVA: 0x132D270
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA16CED0
    }

    public class SecT163R2Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA16D620
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA16D730
        public void Twice(){} // RVA: 0xA16E100
        public void TwicePlus(){} // RVA: 0xA16E570
        public void Negate(){} // RVA: 0xA16EC00
    }

    public class SecT193Field : Object
    {
        public object M01;
        public object M49;

        // ── Methods ──
        public void Add(){} // RVA: 0xA155740
        public void AddExt(){} // RVA: 0xA16EDB0
        public void AddOne(){} // RVA: 0xA16EEF0
        public void AddTo(){} // RVA: 0xA16EF70
        public void FromBigInteger(){} // RVA: 0xA16EFF0
        public void HalfTrace(){} // RVA: 0xA16F000
        public void Invert(){} // RVA: 0xA16F270
        public void Multiply(){} // RVA: 0xA16F4C0
        public void MultiplyAddToExt(){} // RVA: 0xA16F550
        public void Reduce(){} // RVA: 0xA16F5E0
        public void Reduce63(){} // RVA: 0xA16F740
        public void Sqrt(){} // RVA: 0xA16F7C0
        public void Square(){} // RVA: 0xA16F910
        public void SquareAddToExt(){} // RVA: 0xA16FA00
        public void SquareN(){} // RVA: 0xA16FAF0
        public void Trace(){} // RVA: 0xA1564D0
        public void ImplCompactExt(){} // RVA: 0xA16FC90
        public void ImplExpand(){} // RVA: 0xA16FDF0
        public void ImplMultiply(){} // RVA: 0xA16FEB0
        public void ImplMulwAcc(){} // RVA: 0xA1704E0
        public void ImplSquare(){} // RVA: 0xA170750
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SecT193FieldElement : AbstractF2mFieldElement
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsOne(){} // RVA: 0xA170930
        public void get_IsZero(){} // RVA: 0xA1709A0
        public void TestBitZero(){} // RVA: 0xA156BB0
        public void ToBigInteger(){} // RVA: 0xA170A00
        public void get_FieldName(){} // RVA: 0xA170A10
        public void get_FieldSize(){} // RVA: 0xA170A50
        public void Add(){} // RVA: 0xA170A60
        public void AddOne(){} // RVA: 0xA170C60
        public void Subtract(){} // RVA: 0x5BA5570
        public void Multiply(){} // RVA: 0xA170DC0
        public void MultiplyMinusProduct(){} // RVA: 0xA157150
        public void MultiplyPlusProduct(){} // RVA: 0xA170F00
        public void Divide(){} // RVA: 0xA1573A0
        public void Negate(){} // RVA: 0x2303260
        public void Square(){} // RVA: 0xA171130
        public void SquareMinusProduct(){} // RVA: 0xA1574D0
        public void SquarePlusProduct(){} // RVA: 0xA171210
        public void SquarePow(){} // RVA: 0xA1714C0
        public void HalfTrace(){} // RVA: 0xA1715C0
        public void get_HasFastTrace(){} // RVA: 0xC2E4C0
        public void Trace(){} // RVA: 0xA1579B0
        public void Invert(){} // RVA: 0xA1716A0
        public void Sqrt(){} // RVA: 0xA171780
        public void get_Representation(){} // RVA: 0xC50A80
        public void get_M(){} // RVA: 0xA170A50
        public void get_K1(){} // RVA: 0x1C8BCF0
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void Equals(){} // RVA: 0xA171AD0
        public void GetHashCode(){} // RVA: 0xA171B40
    }

    public class SecT193R1Curve : AbstractF2mCurve
    {
        public object SECT193R1_DEFAULT_COORDS;
        public object SECT193R1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA171BF0
        public void CloneCurve(){} // RVA: 0xA1720D0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA170A50
        public void FromBigInteger(){} // RVA: 0xA172120
        public void CreateRawPoint(){} // RVA: 0xA172270
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0xA170A50
        public void get_IsTrinomial(){} // RVA: 0xC2E4C0
        public void get_K1(){} // RVA: 0x1C8BCF0
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA172310
    }

    public class SecT193R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA172AA0
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA172BB0
        public void Twice(){} // RVA: 0xA1735A0
        public void TwicePlus(){} // RVA: 0xA173A60
        public void Negate(){} // RVA: 0xA174160
    }

    public class SecT193R2Curve : AbstractF2mCurve
    {
        public object SECT193R2_DEFAULT_COORDS;
        public object SECT193R2_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA174310
        public void CloneCurve(){} // RVA: 0xA1747F0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA170A50
        public void FromBigInteger(){} // RVA: 0xA174840
        public void CreateRawPoint(){} // RVA: 0xA174990
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0xA170A50
        public void get_IsTrinomial(){} // RVA: 0xC2E4C0
        public void get_K1(){} // RVA: 0x1C8BCF0
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA174A30
    }

    public class SecT193R2Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA1751C0
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA1752D0
        public void Twice(){} // RVA: 0xA175CC0
        public void TwicePlus(){} // RVA: 0xA176180
        public void Negate(){} // RVA: 0xA176880
    }

    public class SecT233Field : Object
    {
        public object M41;
        public object M59;

        // ── Methods ──
        public void Add(){} // RVA: 0xA155740
        public void AddExt(){} // RVA: 0xA176A30
        public void AddOne(){} // RVA: 0xA16EEF0
        public void AddTo(){} // RVA: 0xA16EF70
        public void FromBigInteger(){} // RVA: 0xA176B90
        public void HalfTrace(){} // RVA: 0xA176BA0
        public void Invert(){} // RVA: 0xA176E10
        public void Multiply(){} // RVA: 0xA177090
        public void MultiplyAddToExt(){} // RVA: 0xA177120
        public void Reduce(){} // RVA: 0xA1771B0
        public void Reduce23(){} // RVA: 0xA177350
        public void Sqrt(){} // RVA: 0xA1773D0
        public void Square(){} // RVA: 0xA177690
        public void SquareAddToExt(){} // RVA: 0xA177780
        public void SquareN(){} // RVA: 0xA177870
        public void Trace(){} // RVA: 0xA177A20
        public void ImplCompactExt(){} // RVA: 0xA177A60
        public void ImplExpand(){} // RVA: 0xA177BB0
        public void ImplMultiply(){} // RVA: 0xA177C70
        public void ImplMulwAcc(){} // RVA: 0xA1782A0
        public void ImplSquare(){} // RVA: 0xA178490
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SecT233FieldElement : AbstractF2mFieldElement
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsOne(){} // RVA: 0xA170930
        public void get_IsZero(){} // RVA: 0xA1709A0
        public void TestBitZero(){} // RVA: 0xA156BB0
        public void ToBigInteger(){} // RVA: 0xA170A00
        public void get_FieldName(){} // RVA: 0xA1785E0
        public void get_FieldSize(){} // RVA: 0xA178620
        public void Add(){} // RVA: 0xA178630
        public void AddOne(){} // RVA: 0xA178830
        public void Subtract(){} // RVA: 0x5BA5570
        public void Multiply(){} // RVA: 0xA178990
        public void MultiplyMinusProduct(){} // RVA: 0xA157150
        public void MultiplyPlusProduct(){} // RVA: 0xA178AD0
        public void Divide(){} // RVA: 0xA1573A0
        public void Negate(){} // RVA: 0x2303260
        public void Square(){} // RVA: 0xA178D00
        public void SquareMinusProduct(){} // RVA: 0xA1574D0
        public void SquarePlusProduct(){} // RVA: 0xA178DE0
        public void SquarePow(){} // RVA: 0xA179090
        public void HalfTrace(){} // RVA: 0xA179190
        public void get_HasFastTrace(){} // RVA: 0xC2E4C0
        public void Trace(){} // RVA: 0xA179270
        public void Invert(){} // RVA: 0xA1792B0
        public void Sqrt(){} // RVA: 0xA179390
        public void get_Representation(){} // RVA: 0xC50A80
        public void get_M(){} // RVA: 0xA178620
        public void get_K1(){} // RVA: 0xA179470
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void Equals(){} // RVA: 0xA171AD0
        public void GetHashCode(){} // RVA: 0xA1795C0
    }

    public class SecT233K1Curve : AbstractF2mCurve
    {
        public object SECT233K1_DEFAULT_COORDS;
        public object SECT233K1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA179670
        public void CloneCurve(){} // RVA: 0xA179AB0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void CreateDefaultMultiplier(){} // RVA: 0xA179B00
        public void get_FieldSize(){} // RVA: 0xA178620
        public void FromBigInteger(){} // RVA: 0xA179B40
        public void CreateRawPoint(){} // RVA: 0xA179C90
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_IsKoblitz(){} // RVA: 0xC2E4C0
        public void get_M(){} // RVA: 0xA178620
        public void get_IsTrinomial(){} // RVA: 0xC2E4C0
        public void get_K1(){} // RVA: 0xA179470
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA179D30
    }

    public class SecT233K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA17A4C0
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA17A5D0
        public void Twice(){} // RVA: 0xA17AF40
        public void TwicePlus(){} // RVA: 0xA17B430
        public void Negate(){} // RVA: 0xA17BA70
    }

    public class SecT233R1Curve : AbstractF2mCurve
    {
        public object SECT233R1_DEFAULT_COORDS;
        public object SECT233R1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA17BC20
        public void CloneCurve(){} // RVA: 0xA17C0B0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA178620
        public void FromBigInteger(){} // RVA: 0xA17C100
        public void CreateRawPoint(){} // RVA: 0xA17C250
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0xA178620
        public void get_IsTrinomial(){} // RVA: 0xC2E4C0
        public void get_K1(){} // RVA: 0xA179470
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA17C2F0
    }

    public class SecT233R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA17CA80
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA17CB90
        public void Twice(){} // RVA: 0xA17D560
        public void TwicePlus(){} // RVA: 0xA17D9D0
        public void Negate(){} // RVA: 0xA17E060
    }

    public class SecT239Field : Object
    {
        public object M47;
        public object M60;

        // ── Methods ──
        public void Add(){} // RVA: 0xA155740
        public void AddExt(){} // RVA: 0xA176A30
        public void AddOne(){} // RVA: 0xA16EEF0
        public void AddTo(){} // RVA: 0xA16EF70
        public void FromBigInteger(){} // RVA: 0xA17E210
        public void HalfTrace(){} // RVA: 0xA17E220
        public void Invert(){} // RVA: 0xA17E490
        public void Multiply(){} // RVA: 0xA17E750
        public void MultiplyAddToExt(){} // RVA: 0xA17E7E0
        public void Reduce(){} // RVA: 0xA17E870
        public void Reduce17(){} // RVA: 0xA17EA10
        public void Sqrt(){} // RVA: 0xA17EA90
        public void Square(){} // RVA: 0xA17ED80
        public void SquareAddToExt(){} // RVA: 0xA177780
        public void SquareN(){} // RVA: 0xA17EE70
        public void Trace(){} // RVA: 0xA17F020
        public void ImplCompactExt(){} // RVA: 0xA17F070
        public void ImplExpand(){} // RVA: 0xA17F1C0
        public void ImplMultiply(){} // RVA: 0xA17F280
        public void ImplMulwAcc(){} // RVA: 0xA17F8B0
        public void ImplSquare(){} // RVA: 0xA178490
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SecT239FieldElement : AbstractF2mFieldElement
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsOne(){} // RVA: 0xA170930
        public void get_IsZero(){} // RVA: 0xA1709A0
        public void TestBitZero(){} // RVA: 0xA156BB0
        public void ToBigInteger(){} // RVA: 0xA170A00
        public void get_FieldName(){} // RVA: 0xA17FB90
        public void get_FieldSize(){} // RVA: 0xA17FBD0
        public void Add(){} // RVA: 0xA17FBE0
        public void AddOne(){} // RVA: 0xA17FDE0
        public void Subtract(){} // RVA: 0x5BA5570
        public void Multiply(){} // RVA: 0xA17FF40
        public void MultiplyMinusProduct(){} // RVA: 0xA157150
        public void MultiplyPlusProduct(){} // RVA: 0xA180080
        public void Divide(){} // RVA: 0xA1573A0
        public void Negate(){} // RVA: 0x2303260
        public void Square(){} // RVA: 0xA1802B0
        public void SquareMinusProduct(){} // RVA: 0xA1574D0
        public void SquarePlusProduct(){} // RVA: 0xA180390
        public void SquarePow(){} // RVA: 0xA180640
        public void HalfTrace(){} // RVA: 0xA180740
        public void get_HasFastTrace(){} // RVA: 0xC2E4C0
        public void Trace(){} // RVA: 0xA180820
        public void Invert(){} // RVA: 0xA180870
        public void Sqrt(){} // RVA: 0xA180950
        public void get_Representation(){} // RVA: 0xC50A80
        public void get_M(){} // RVA: 0xA17FBD0
        public void get_K1(){} // RVA: 0xA180A30
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void Equals(){} // RVA: 0xA171AD0
        public void GetHashCode(){} // RVA: 0xA180B80
    }

    public class SecT239K1Curve : AbstractF2mCurve
    {
        public object SECT239K1_DEFAULT_COORDS;
        public object SECT239K1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA180C30
        public void CloneCurve(){} // RVA: 0xA181070
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void CreateDefaultMultiplier(){} // RVA: 0xA1810C0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA17FBD0
        public void FromBigInteger(){} // RVA: 0xA181100
        public void CreateRawPoint(){} // RVA: 0xA1812D0
        public void get_IsKoblitz(){} // RVA: 0xC2E4C0
        public void get_M(){} // RVA: 0xA17FBD0
        public void get_IsTrinomial(){} // RVA: 0xC2E4C0
        public void get_K1(){} // RVA: 0xA180A30
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA181370
    }

    public class SecT239K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA181B00
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA181C10
        public void Twice(){} // RVA: 0xA182580
        public void TwicePlus(){} // RVA: 0xA182A70
        public void Negate(){} // RVA: 0xA1830B0
    }

    public class SecT283Field : Object
    {
        public object M27;
        public object M57;
        public object ROOT_Z;

        // ── Methods ──
        public void Add(){} // RVA: 0xA15CE00
        public void AddExt(){} // RVA: 0xA183260
        public void AddOne(){} // RVA: 0xA1833F0
        public void AddTo(){} // RVA: 0xA183480
        public void FromBigInteger(){} // RVA: 0xA183520
        public void HalfTrace(){} // RVA: 0xA183530
        public void Invert(){} // RVA: 0xA183740
        public void Multiply(){} // RVA: 0xA183A10
        public void MultiplyAddToExt(){} // RVA: 0xA183AD0
        public void Reduce(){} // RVA: 0xA183B90
        public void Reduce37(){} // RVA: 0xA183DC0
        public void Sqrt(){} // RVA: 0xA183E40
        public void Square(){} // RVA: 0xA184030
        public void SquareAddToExt(){} // RVA: 0xA1840E0
        public void SquareN(){} // RVA: 0xA184190
        public void Trace(){} // RVA: 0xA184290
        public void ImplCompactExt(){} // RVA: 0xA1842D0
        public void ImplExpand(){} // RVA: 0xA184490
        public void ImplMultiply(){} // RVA: 0xA184590
        public void ImplMulw(){} // RVA: 0xA184C90
        public void ImplSquare(){} // RVA: 0xA184EC0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA185000
    }

    public class SecT283FieldElement : AbstractF2mFieldElement
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsOne(){} // RVA: 0xA185260
        public void get_IsZero(){} // RVA: 0xA1852D0
        public void TestBitZero(){} // RVA: 0xA156BB0
        public void ToBigInteger(){} // RVA: 0xA185330
        public void get_FieldName(){} // RVA: 0xA185450
        public void get_FieldSize(){} // RVA: 0xA185490
        public void Add(){} // RVA: 0xA1854A0
        public void AddOne(){} // RVA: 0xA1856F0
        public void Subtract(){} // RVA: 0x5BA5570
        public void Multiply(){} // RVA: 0xA185890
        public void MultiplyMinusProduct(){} // RVA: 0xA157150
        public void MultiplyPlusProduct(){} // RVA: 0xA185A00
        public void Divide(){} // RVA: 0xA1573A0
        public void Negate(){} // RVA: 0x2303260
        public void Square(){} // RVA: 0xA185C60
        public void SquareMinusProduct(){} // RVA: 0xA1574D0
        public void SquarePlusProduct(){} // RVA: 0xA185D60
        public void SquarePow(){} // RVA: 0xA185FF0
        public void HalfTrace(){} // RVA: 0xA186120
        public void get_HasFastTrace(){} // RVA: 0xC2E4C0
        public void Trace(){} // RVA: 0xA186220
        public void Invert(){} // RVA: 0xA1862A0
        public void Sqrt(){} // RVA: 0xA1863A0
        public void get_Representation(){} // RVA: 0x12FC4A0
        public void get_M(){} // RVA: 0xA185490
        public void get_K1(){} // RVA: 0xEF4110
        public void get_K2(){} // RVA: 0x132D270
        public void get_K3(){} // RVA: 0x2AFB6E0
        public void Equals(){} // RVA: 0xA1865E0
        public void GetHashCode(){} // RVA: 0xA186650
    }

    public class SecT283K1Curve : AbstractF2mCurve
    {
        public object SECT283K1_DEFAULT_COORDS;
        public object SECT283K1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA186700
        public void CloneCurve(){} // RVA: 0xA186B60
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void CreateDefaultMultiplier(){} // RVA: 0xA186BB0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA185490
        public void FromBigInteger(){} // RVA: 0xA186BF0
        public void CreateRawPoint(){} // RVA: 0xA186D40
        public void get_IsKoblitz(){} // RVA: 0xC2E4C0
        public void get_M(){} // RVA: 0xA185490
        public void get_IsTrinomial(){} // RVA: 0xB43320
        public void get_K1(){} // RVA: 0xEF4110
        public void get_K2(){} // RVA: 0x132D270
        public void get_K3(){} // RVA: 0x2AFB6E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA186DE0
    }

    public class SecT283K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA1875C0
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA1876D0
        public void Twice(){} // RVA: 0xA188040
        public void TwicePlus(){} // RVA: 0xA188530
        public void Negate(){} // RVA: 0xA188B70
    }

    public class SecT283R1Curve : AbstractF2mCurve
    {
        public object SECT283R1_DEFAULT_COORDS;
        public object SECT283R1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA188D20
        public void CloneCurve(){} // RVA: 0xA1891D0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA185490
        public void FromBigInteger(){} // RVA: 0xA189220
        public void CreateRawPoint(){} // RVA: 0xA189370
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0xA185490
        public void get_IsTrinomial(){} // RVA: 0xB43320
        public void get_K1(){} // RVA: 0xEF4110
        public void get_K2(){} // RVA: 0x132D270
        public void get_K3(){} // RVA: 0x2AFB6E0
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA189410
    }

    public class SecT283R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA189BF0
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA189D00
        public void Twice(){} // RVA: 0xA18A6D0
        public void TwicePlus(){} // RVA: 0xA18AB40
        public void Negate(){} // RVA: 0xA18B1D0
    }

    public class SecT409Field : Object
    {
        public object M25;
        public object M59;

        // ── Methods ──
        public void Add(){} // RVA: 0xA16EDB0
        public void AddExt(){} // RVA: 0xA18B380
        public void AddOne(){} // RVA: 0xA18B400
        public void AddTo(){} // RVA: 0xA18B4C0
        public void FromBigInteger(){} // RVA: 0xA18B5A0
        public void HalfTrace(){} // RVA: 0xA18B5B0
        public void Invert(){} // RVA: 0xA18B7F0
        public void Multiply(){} // RVA: 0xA18BAD0
        public void MultiplyAddToExt(){} // RVA: 0xA18BB60
        public void Reduce(){} // RVA: 0xA18BC20
        public void Reduce39(){} // RVA: 0xA18BE70
        public void Sqrt(){} // RVA: 0xA18BEE0
        public void Square(){} // RVA: 0xA18C120
        public void SquareAddToExt(){} // RVA: 0xA18C1A0
        public void SquareN(){} // RVA: 0xA18C250
        public void Trace(){} // RVA: 0xA1564D0
        public void ImplCompactExt(){} // RVA: 0xA18C310
        public void ImplExpand(){} // RVA: 0xA18C5B0
        public void ImplMultiply(){} // RVA: 0xA18C720
        public void ImplMulwAcc(){} // RVA: 0xA18C820
        public void ImplSquare(){} // RVA: 0xA18CAA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SecT409FieldElement : AbstractF2mFieldElement
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsOne(){} // RVA: 0xA18CD60
        public void get_IsZero(){} // RVA: 0xA18CDD0
        public void TestBitZero(){} // RVA: 0xA156BB0
        public void ToBigInteger(){} // RVA: 0xA18CE30
        public void get_FieldName(){} // RVA: 0xA18CF50
        public void get_FieldSize(){} // RVA: 0xA18CF90
        public void Add(){} // RVA: 0xA18CFA0
        public void AddOne(){} // RVA: 0xA18D220
        public void Subtract(){} // RVA: 0x5BA5570
        public void Multiply(){} // RVA: 0xA18D3D0
        public void MultiplyMinusProduct(){} // RVA: 0xA157150
        public void MultiplyPlusProduct(){} // RVA: 0xA18D510
        public void Divide(){} // RVA: 0xA1573A0
        public void Negate(){} // RVA: 0x2303260
        public void Square(){} // RVA: 0xA18D850
        public void SquareMinusProduct(){} // RVA: 0xA1574D0
        public void SquarePlusProduct(){} // RVA: 0xA18D930
        public void SquarePow(){} // RVA: 0xA18DC10
        public void HalfTrace(){} // RVA: 0xA18DD10
        public void get_HasFastTrace(){} // RVA: 0xC2E4C0
        public void Trace(){} // RVA: 0xA1579B0
        public void Invert(){} // RVA: 0xA18DDF0
        public void Sqrt(){} // RVA: 0xA18DED0
        public void get_Representation(){} // RVA: 0xC50A80
        public void get_M(){} // RVA: 0xA18CF90
        public void get_K1(){} // RVA: 0xA18DFB0
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void Equals(){} // RVA: 0xA18E100
        public void GetHashCode(){} // RVA: 0xA18E170
    }

    public class SecT409K1Curve : AbstractF2mCurve
    {
        public object SECT409K1_DEFAULT_COORDS;
        public object SECT409K1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA18E220
        public void CloneCurve(){} // RVA: 0xA18E660
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void CreateDefaultMultiplier(){} // RVA: 0xA18E6B0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA18CF90
        public void FromBigInteger(){} // RVA: 0xA18E6F0
        public void CreateRawPoint(){} // RVA: 0xA18E840
        public void get_IsKoblitz(){} // RVA: 0xC2E4C0
        public void get_M(){} // RVA: 0xA18CF90
        public void get_IsTrinomial(){} // RVA: 0xC2E4C0
        public void get_K1(){} // RVA: 0xA18DFB0
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA18E8E0
    }

    public class SecT409K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA18EF60
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA18F070
        public void Twice(){} // RVA: 0xA18F9E0
        public void TwicePlus(){} // RVA: 0xA18FED0
        public void Negate(){} // RVA: 0xA190510
    }

    public class SecT409R1Curve : AbstractF2mCurve
    {
        public object SECT409R1_DEFAULT_COORDS;
        public object SECT409R1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA1906C0
        public void CloneCurve(){} // RVA: 0xA190B50
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA18CF90
        public void FromBigInteger(){} // RVA: 0xA190BA0
        public void CreateRawPoint(){} // RVA: 0xA190CF0
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0xA18CF90
        public void get_IsTrinomial(){} // RVA: 0xC2E4C0
        public void get_K1(){} // RVA: 0xA18DFB0
        public void get_K2(){} // RVA: 0xDAC980
        public void get_K3(){} // RVA: 0xDAC980
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA190D90
    }

    public class SecT409R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA191410
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA191520
        public void Twice(){} // RVA: 0xA191EF0
        public void TwicePlus(){} // RVA: 0xA192360
        public void Negate(){} // RVA: 0xA1929F0
    }

    public class SecT571Field : Object
    {
        public object M59;
        public object RM;
        public object ROOT_Z;

        // ── Methods ──
        public void Add(){} // RVA: 0xA192C20
        public void AddBothTo(){} // RVA: 0xA192CE0
        public void AddExt(){} // RVA: 0xA192DB0
        public void AddOne(){} // RVA: 0xA192E30
        public void AddTo(){} // RVA: 0xA192EB0
        public void FromBigInteger(){} // RVA: 0xA192F10
        public void HalfTrace(){} // RVA: 0xA192F20
        public void Invert(){} // RVA: 0xA193160
        public void Multiply(){} // RVA: 0xA1934A0
        public void MultiplyAddToExt(){} // RVA: 0xA193560
        public void Reduce(){} // RVA: 0xA193660
        public void Reduce5(){} // RVA: 0xA193830
        public void Sqrt(){} // RVA: 0xA1938B0
        public void Square(){} // RVA: 0xA193CE0
        public void SquareAddToExt(){} // RVA: 0xA193D90
        public void SquareN(){} // RVA: 0xA193E80
        public void Trace(){} // RVA: 0xA193F80
        public void ImplMultiply(){} // RVA: 0xA193FC0
        public void ImplMulwAcc(){} // RVA: 0xA194560
        public void ImplSquare(){} // RVA: 0xA1947C0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA1948F0
    }

    public class SecT571FieldElement : AbstractF2mFieldElement
    {
        public object x;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_IsOne(){} // RVA: 0xA194B50
        public void get_IsZero(){} // RVA: 0xA194BC0
        public void TestBitZero(){} // RVA: 0xA156BB0
        public void ToBigInteger(){} // RVA: 0xA194C20
        public void get_FieldName(){} // RVA: 0xA194D40
        public void get_FieldSize(){} // RVA: 0xA194D80
        public void Add(){} // RVA: 0xA194D90
        public void AddOne(){} // RVA: 0xA194F60
        public void Subtract(){} // RVA: 0x5BA5570
        public void Multiply(){} // RVA: 0xA1950D0
        public void MultiplyMinusProduct(){} // RVA: 0xA157150
        public void MultiplyPlusProduct(){} // RVA: 0xA195240
        public void Divide(){} // RVA: 0xA1573A0
        public void Negate(){} // RVA: 0x2303260
        public void Square(){} // RVA: 0xA1954A0
        public void SquareMinusProduct(){} // RVA: 0xA1574D0
        public void SquarePlusProduct(){} // RVA: 0xA1955A0
        public void SquarePow(){} // RVA: 0xA195870
        public void HalfTrace(){} // RVA: 0xA1959A0
        public void get_HasFastTrace(){} // RVA: 0xC2E4C0
        public void Trace(){} // RVA: 0xA195AA0
        public void Invert(){} // RVA: 0xA195B20
        public void Sqrt(){} // RVA: 0xA195C20
        public void get_Representation(){} // RVA: 0x12FC4A0
        public void get_M(){} // RVA: 0xA194D80
        public void get_K1(){} // RVA: 0xC50A80
        public void get_K2(){} // RVA: 0xEF4110
        public void get_K3(){} // RVA: 0xE49B40
        public void Equals(){} // RVA: 0xA195E60
        public void GetHashCode(){} // RVA: 0xA195ED0
    }

    public class SecT571K1Curve : AbstractF2mCurve
    {
        public object SECT571K1_DEFAULT_COORDS;
        public object SECT571K1_FE_LONGS;
        public object m_infinity;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA195F80
        public void CloneCurve(){} // RVA: 0xA1963E0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void CreateDefaultMultiplier(){} // RVA: 0xA196430
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA194D80
        public void FromBigInteger(){} // RVA: 0xA196470
        public void CreateRawPoint(){} // RVA: 0xA1965C0
        public void get_IsKoblitz(){} // RVA: 0xC2E4C0
        public void get_M(){} // RVA: 0xA194D80
        public void get_IsTrinomial(){} // RVA: 0xB43320
        public void get_K1(){} // RVA: 0xC50A80
        public void get_K2(){} // RVA: 0xEF4110
        public void get_K3(){} // RVA: 0xE49B40
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA196660
    }

    public class SecT571K1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA196CF0
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA196E00
        public void Twice(){} // RVA: 0xA197770
        public void TwicePlus(){} // RVA: 0xA197C60
        public void Negate(){} // RVA: 0xA1982A0
    }

    public class SecT571R1Curve : AbstractF2mCurve
    {
        public object SECT571R1_DEFAULT_COORDS;
        public object SECT571R1_FE_LONGS;
        public object m_infinity;
        public object SecT571R1_B;
        public object SecT571R1_B_SQRT;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA198450
        public void CloneCurve(){} // RVA: 0xA1988D0
        public void SupportsCoordinateSystem(){} // RVA: 0xA1583D0
        public void get_Infinity(){} // RVA: 0xC0FFC0
        public void get_FieldSize(){} // RVA: 0xA194D80
        public void FromBigInteger(){} // RVA: 0xA198920
        public void CreateRawPoint(){} // RVA: 0xA198A70
        public void get_IsKoblitz(){} // RVA: 0xB43320
        public void get_M(){} // RVA: 0xA194D80
        public void get_IsTrinomial(){} // RVA: 0xB43320
        public void get_K1(){} // RVA: 0xC50A80
        public void get_K2(){} // RVA: 0xEF4110
        public void get_K3(){} // RVA: 0xE49B40
        public void CreateCacheSafeLookupTable(){} // RVA: 0xA198B10
        public void .cctor(){} // RVA: 0xA198DB0
    }

    public class SecT571R1Point : AbstractF2mPoint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA11DED0
        public void Detach(){} // RVA: 0xA199430
        public void get_YCoord(){} // RVA: 0xA158DE0
        public void get_CompressionYTilde(){} // RVA: 0xA158EF0
        public void Add(){} // RVA: 0xA199540
        public void Twice(){} // RVA: 0xA199EF0
        public void TwicePlus(){} // RVA: 0xA19A360
        public void Negate(){} // RVA: 0xA19A9E0
    }

}