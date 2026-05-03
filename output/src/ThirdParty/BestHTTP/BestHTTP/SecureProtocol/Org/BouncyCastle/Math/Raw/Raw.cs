// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Raw
// Classes: 13
// Methods: 383

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Raw
{
    public class Interleave : Object
    {
        // ── Methods ──
        public void Expand8to16(){} // RVA: 0x7FFE8A3F6F60
        public void Expand16to32(){} // RVA: 0x7FFE8A3F6F90
        public void Expand32to64(){} // RVA: 0x7FFE8A3F6FD0
        public void Expand64To128(){} // RVA: 0x7FFE8A3F7060
        public void Expand64To128Rev(){} // RVA: 0x7FFE8A3F7160
        public void Shuffle(){} // RVA: 0x7FFE8A3F72E0 | overloaded x2
        public void Shuffle2(){} // RVA: 0x7FFE8A3F7390
        public void Unshuffle(){} // RVA: 0x7FFE8A3F7470 | overloaded x2
        public void Unshuffle2(){} // RVA: 0x7FFE8A3F7520
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Mod : Object
    {
        // ── Methods ──
        public void Invert(){} // RVA: 0x7FFE8A3F7590
        public void Random(){} // RVA: 0x7FFE8A3F7CE0
        public void Add(){} // RVA: 0x7FFE8A3F7F30
        public void Subtract(){} // RVA: 0x7FFE8A3F8030
        public void InversionResult(){} // RVA: 0x7FFE8A3F8120
        public void InversionStep(){} // RVA: 0x7FFE8A3F81D0
        public void GetTrailingZeroes(){} // RVA: 0x7FFE8A3F8440
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A3F8460
    }

    public class Nat : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE8A3F8520
        public void Add33At(){} // RVA: 0x7FFE8A3F8640 | overloaded x2
        public void Add33To(){} // RVA: 0x7FFE8A3F87A0 | overloaded x2
        public void AddBothTo(){} // RVA: 0x7FFE8A3F88E0 | overloaded x2
        public void AddDWordAt(){} // RVA: 0x7FFE8A3F8A70 | overloaded x2
        public void AddDWordTo(){} // RVA: 0x7FFE8A3F8BE0 | overloaded x2
        public void AddTo(){} // RVA: 0x7FFE8A3F8DA0 | overloaded x3
        public void AddToEachOther(){} // RVA: 0x7FFE8A3F8E40
        public void AddWordAt(){} // RVA: 0x7FFE8A3F8F60 | overloaded x2
        public void AddWordTo(){} // RVA: 0x7FFE8A3F9070 | overloaded x2
        public void CAdd(){} // RVA: 0x7FFE8A3F90F0
        public void CMov(){} // RVA: 0x7FFE8A3F9190 | overloaded x2
        public void Copy(){} // RVA: 0x7FFE8A3F92E0 | overloaded x3
        public void Copy64(){} // RVA: 0x7FFE8A3F92E0 | overloaded x3
        public void Create(){} // RVA: 0x7FFE8A3F9390
        public void Create64(){} // RVA: 0x7FFE8A3F93D0
        public void CSub(){} // RVA: 0x7FFE8A3F94B0 | overloaded x2
        public void Dec(){} // RVA: 0x7FFE8A3F95F0 | overloaded x2
        public void DecAt(){} // RVA: 0x7FFE8A3F96E0 | overloaded x2
        public void Eq(){} // RVA: 0x7FFE8A3F9740
        public void FromBigInteger(){} // RVA: 0x7FFE8A3F97A0
        public void FromBigInteger64(){} // RVA: 0x7FFE8A3F98D0
        public void GetBit(){} // RVA: 0x7FFE8A3F9A30
        public void Gte(){} // RVA: 0x7FFE8A3F9A90
        public void Inc(){} // RVA: 0x7FFE8A3F9B40 | overloaded x2
        public void IncAt(){} // RVA: 0x7FFE8A3F9C20 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFE8A3F9C80
        public void IsZero(){} // RVA: 0x7FFE8A3F9CE0
        public void Mul(){} // RVA: 0x7FFE8A3FA040 | overloaded x3
        public void MulAddTo(){} // RVA: 0x7FFE8A3FA330 | overloaded x2
        public void Mul31BothAdd(){} // RVA: 0x7FFE8A3FA480
        public void MulWord(){} // RVA: 0x7FFE8A3FA5C0 | overloaded x2
        public void MulWordAddTo(){} // RVA: 0x7FFE8A3FA660
        public void MulWordDwordAddAt(){} // RVA: 0x7FFE8A3FA710
        public void ShiftDownBit(){} // RVA: 0x7FFE8A3FA900 | overloaded x4
        public void ShiftDownBits(){} // RVA: 0x7FFE8A3FAB70 | overloaded x4
        public void ShiftDownWord(){} // RVA: 0x7FFE8A3FAC40
        public void ShiftUpBit(){} // RVA: 0x7FFE8A3FADC0 | overloaded x4
        public void ShiftUpBit64(){} // RVA: 0x7FFE8A3FAE60
        public void ShiftUpBits(){} // RVA: 0x7FFE8A3FB1B0 | overloaded x4
        public void ShiftUpBits64(){} // RVA: 0x7FFE8A3FB280 | overloaded x2
        public void Square(){} // RVA: 0x7FFE8A3FB540 | overloaded x2
        public void SquareWordAdd(){} // RVA: 0x7FFE8A3FB800 | overloaded x2
        public void SquareWordAddTo(){} // RVA: 0x7FFE8A3FB800 | overloaded x2
        public void Sub(){} // RVA: 0x7FFE8A3FB930 | overloaded x2
        public void Sub33At(){} // RVA: 0x7FFE8A3FBAB0 | overloaded x2
        public void Sub33From(){} // RVA: 0x7FFE8A3FBC30 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFE8A3FBD70 | overloaded x2
        public void SubDWordAt(){} // RVA: 0x7FFE8A3FBF00 | overloaded x2
        public void SubDWordFrom(){} // RVA: 0x7FFE8A3FC080 | overloaded x2
        public void SubFrom(){} // RVA: 0x7FFE8A3FC1B0 | overloaded x2
        public void SubWordAt(){} // RVA: 0x7FFE8A3FC2C0 | overloaded x2
        public void SubWordFrom(){} // RVA: 0x7FFE8A3FC3D0 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFE8A3FC450
        public void Zero(){} // RVA: 0x7FFE8A3FC5B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Nat128 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE8A3FC5F0
        public void AddBothTo(){} // RVA: 0x7FFE8A3FC6E0
        public void AddTo(){} // RVA: 0x7FFE8A3FC8B0 | overloaded x2
        public void AddToEachOther(){} // RVA: 0x7FFE8A3FC9C0
        public void Copy(){} // RVA: 0x7FFE8A3FCB80 | overloaded x2
        public void Copy64(){} // RVA: 0x7FFE8A3FCC80 | overloaded x2
        public void Create(){} // RVA: 0x7FFE8A3FCCE0
        public void Create64(){} // RVA: 0x7FFE8A3FCD20
        public void CreateExt(){} // RVA: 0x7FFE8A3FCD60
        public void CreateExt64(){} // RVA: 0x7FFE8A3FCDA0
        public void Diff(){} // RVA: 0x7FFE8A3FCDE0
        public void Eq(){} // RVA: 0x7FFE8A3FCEE0
        public void Eq64(){} // RVA: 0x7FFE8A3FCF40
        public void FromBigInteger(){} // RVA: 0x7FFE8A3FCFA0
        public void FromBigInteger64(){} // RVA: 0x7FFE8A3FD0D0
        public void GetBit(){} // RVA: 0x7FFE8A3FD230
        public void Gte(){} // RVA: 0x7FFE8A3FD2F0 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFE8A3FD360
        public void IsOne64(){} // RVA: 0x7FFE8A3FD3B0
        public void IsZero(){} // RVA: 0x7FFE8A3FD410
        public void IsZero64(){} // RVA: 0x7FFE8A3FD450
        public void Mul(){} // RVA: 0x7FFE8A3FD6A0 | overloaded x2
        public void MulAddTo(){} // RVA: 0x7FFE8A3FDA70 | overloaded x2
        public void Mul33Add(){} // RVA: 0x7FFE8A3FDC40
        public void MulWordAddExt(){} // RVA: 0x7FFE8A3FDDD0
        public void Mul33DWordAdd(){} // RVA: 0x7FFE8A3FDEE0
        public void Mul33WordAdd(){} // RVA: 0x7FFE8A3FDFB0
        public void MulWordDwordAdd(){} // RVA: 0x7FFE8A3FE080
        public void MulWordsAdd(){} // RVA: 0x7FFE8A3FE160
        public void MulWord(){} // RVA: 0x7FFE8A3FE200
        public void Square(){} // RVA: 0x7FFE8A3FE500 | overloaded x2
        public void Sub(){} // RVA: 0x7FFE8A3FE920 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFE8A3FEA70
        public void SubFrom(){} // RVA: 0x7FFE8A3FEC40 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFE8A3FED50
        public void ToBigInteger64(){} // RVA: 0x7FFE8A3FEE90
        public void Zero(){} // RVA: 0x7FFE8A3FEF90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Nat160 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE8A3FEFD0
        public void AddBothTo(){} // RVA: 0x7FFE8A3FF0F0
        public void AddTo(){} // RVA: 0x7FFE8A3FF330 | overloaded x2
        public void AddToEachOther(){} // RVA: 0x7FFE8A3FF490
        public void Copy(){} // RVA: 0x7FFE8A3FF6D0 | overloaded x2
        public void Create(){} // RVA: 0x7FFE8A3FF7B0
        public void CreateExt(){} // RVA: 0x7FFE8A3FF7F0
        public void Diff(){} // RVA: 0x7FFE8A3FF830
        public void Eq(){} // RVA: 0x7FFE8A3FF930
        public void FromBigInteger(){} // RVA: 0x7FFE8A3FF990
        public void GetBit(){} // RVA: 0x7FFE8A3FFAC0
        public void Gte(){} // RVA: 0x7FFE8A3FFB80 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFE8A3FFBF0
        public void IsZero(){} // RVA: 0x7FFE8A3FFC40
        public void Mul(){} // RVA: 0x7FFE8A3FFEE0 | overloaded x2
        public void MulAddTo(){} // RVA: 0x7FFE8A400350 | overloaded x2
        public void Mul33Add(){} // RVA: 0x7FFE8A400560
        public void MulWordAddExt(){} // RVA: 0x7FFE8A400730
        public void Mul33DWordAdd(){} // RVA: 0x7FFE8A400870
        public void Mul33WordAdd(){} // RVA: 0x7FFE8A400970
        public void MulWordDwordAdd(){} // RVA: 0x7FFE8A400A40
        public void MulWordsAdd(){} // RVA: 0x7FFE8A400B20
        public void MulWord(){} // RVA: 0x7FFE8A400BC0
        public void Square(){} // RVA: 0x7FFE8A400F80 | overloaded x2
        public void Sub(){} // RVA: 0x7FFE8A4014C0 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFE8A401650
        public void SubFrom(){} // RVA: 0x7FFE8A401890 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFE8A4019D0
        public void Zero(){} // RVA: 0x7FFE8A401B10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Nat192 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE8A401B60
        public void AddBothTo(){} // RVA: 0x7FFE8A401CB0
        public void AddTo(){} // RVA: 0x7FFE8A401F50 | overloaded x2
        public void AddToEachOther(){} // RVA: 0x7FFE8A4020D0
        public void Copy(){} // RVA: 0x7FFE8A402370 | overloaded x2
        public void Copy64(){} // RVA: 0x7FFE8A4024E0 | overloaded x2
        public void Create(){} // RVA: 0x7FFE8A402560
        public void Create64(){} // RVA: 0x7FFE8A4025A0
        public void CreateExt(){} // RVA: 0x7FFE8A4025E0
        public void CreateExt64(){} // RVA: 0x7FFE8A402620
        public void Diff(){} // RVA: 0x7FFE8A402660
        public void Eq(){} // RVA: 0x7FFE8A402760
        public void Eq64(){} // RVA: 0x7FFE8A4027C0
        public void FromBigInteger(){} // RVA: 0x7FFE8A402820
        public void FromBigInteger64(){} // RVA: 0x7FFE8A402950
        public void GetBit(){} // RVA: 0x7FFE8A402AB0
        public void Gte(){} // RVA: 0x7FFE8A402B70 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFE8A402BE0
        public void IsOne64(){} // RVA: 0x7FFE8A402C30
        public void IsZero(){} // RVA: 0x7FFE8A402C90
        public void IsZero64(){} // RVA: 0x7FFE8A402CD0
        public void Mul(){} // RVA: 0x7FFE8A402FD0 | overloaded x2
        public void MulAddTo(){} // RVA: 0x7FFE8A4034F0 | overloaded x2
        public void Mul33Add(){} // RVA: 0x7FFE8A403750
        public void MulWordAddExt(){} // RVA: 0x7FFE8A403970
        public void Mul33DWordAdd(){} // RVA: 0x7FFE8A403AE0
        public void Mul33WordAdd(){} // RVA: 0x7FFE8A403BE0
        public void MulWordDwordAdd(){} // RVA: 0x7FFE8A403CB0
        public void MulWord(){} // RVA: 0x7FFE8A403D90
        public void Square(){} // RVA: 0x7FFE8A404230 | overloaded x2
        public void Sub(){} // RVA: 0x7FFE8A4048C0 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFE8A404A90
        public void SubFrom(){} // RVA: 0x7FFE8A404D20 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFE8A404EA0
        public void ToBigInteger64(){} // RVA: 0x7FFE8A404FE0
        public void Zero(){} // RVA: 0x7FFE8A4050E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Nat224 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE8A4052D0 | overloaded x2
        public void AddBothTo(){} // RVA: 0x7FFE8A405690 | overloaded x2
        public void AddTo(){} // RVA: 0x7FFE8A405A10 | overloaded x2
        public void AddToEachOther(){} // RVA: 0x7FFE8A405BD0
        public void Copy(){} // RVA: 0x7FFE8A405EE0 | overloaded x2
        public void Create(){} // RVA: 0x7FFE8A406010
        public void CreateExt(){} // RVA: 0x7FFE8A406050
        public void Diff(){} // RVA: 0x7FFE8A406090
        public void Eq(){} // RVA: 0x7FFE8A406190
        public void FromBigInteger(){} // RVA: 0x7FFE8A4061F0
        public void GetBit(){} // RVA: 0x7FFE8A406320
        public void Gte(){} // RVA: 0x7FFE8A4063E0 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFE8A406450
        public void IsZero(){} // RVA: 0x7FFE8A4064A0
        public void Mul(){} // RVA: 0x7FFE8A406800 | overloaded x2
        public void MulAddTo(){} // RVA: 0x7FFE8A406DC0 | overloaded x2
        public void Mul33Add(){} // RVA: 0x7FFE8A407070
        public void MulByWord(){} // RVA: 0x7FFE8A4072E0
        public void MulByWordAddTo(){} // RVA: 0x7FFE8A4073B0
        public void MulWordAddTo(){} // RVA: 0x7FFE8A407510
        public void Mul33DWordAdd(){} // RVA: 0x7FFE8A4076C0
        public void Mul33WordAdd(){} // RVA: 0x7FFE8A4077C0
        public void MulWordDwordAdd(){} // RVA: 0x7FFE8A407890
        public void MulWord(){} // RVA: 0x7FFE8A407970
        public void Square(){} // RVA: 0x7FFE8A407F30 | overloaded x2
        public void Sub(){} // RVA: 0x7FFE8A408750 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFE8A408970
        public void SubFrom(){} // RVA: 0x7FFE8A408C70 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFE8A408E30
        public void Zero(){} // RVA: 0x7FFE8A408F70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Nat256 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE8A409190 | overloaded x2
        public void AddBothTo(){} // RVA: 0x7FFE8A4095D0 | overloaded x2
        public void AddTo(){} // RVA: 0x7FFE8A4099B0 | overloaded x2
        public void AddToEachOther(){} // RVA: 0x7FFE8A409BB0
        public void Copy(){} // RVA: 0x7FFE8A409F30 | overloaded x2
        public void Copy64(){} // RVA: 0x7FFE8A40A100 | overloaded x2
        public void Create(){} // RVA: 0x7FFE8A40A1B0
        public void Create64(){} // RVA: 0x7FFE8A40A1F0
        public void CreateExt(){} // RVA: 0x7FFE8A40A230
        public void CreateExt64(){} // RVA: 0x7FFE8A40A270
        public void Diff(){} // RVA: 0x7FFE8A40A2B0
        public void Eq(){} // RVA: 0x7FFE8A40A3B0
        public void Eq64(){} // RVA: 0x7FFE8A40A410
        public void FromBigInteger(){} // RVA: 0x7FFE8A40A470
        public void FromBigInteger64(){} // RVA: 0x7FFE8A40A5A0
        public void GetBit(){} // RVA: 0x7FFE8A40A700
        public void Gte(){} // RVA: 0x7FFE8A40A7C0 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFE8A40A830
        public void IsOne64(){} // RVA: 0x7FFE8A40A880
        public void IsZero(){} // RVA: 0x7FFE8A40A8E0
        public void IsZero64(){} // RVA: 0x7FFE8A40A920
        public void Mul(){} // RVA: 0x7FFE8A40ACE0 | overloaded x2
        public void MulAddTo(){} // RVA: 0x7FFE8A40B350 | overloaded x2
        public void Mul33Add(){} // RVA: 0x7FFE8A40B650
        public void MulByWord(){} // RVA: 0x7FFE8A40B910
        public void MulByWordAddTo(){} // RVA: 0x7FFE8A40BA00
        public void MulWordAddTo(){} // RVA: 0x7FFE8A40BB90
        public void Mul33DWordAdd(){} // RVA: 0x7FFE8A40BD70
        public void Mul33WordAdd(){} // RVA: 0x7FFE8A40BE70
        public void MulWordDwordAdd(){} // RVA: 0x7FFE8A40BF40
        public void MulWord(){} // RVA: 0x7FFE8A40C020
        public void Square(){} // RVA: 0x7FFE8A40C720 | overloaded x2
        public void Sub(){} // RVA: 0x7FFE8A40D0E0 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFE8A40D340
        public void SubFrom(){} // RVA: 0x7FFE8A40D6A0 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFE8A40D890
        public void ToBigInteger64(){} // RVA: 0x7FFE8A40D9D0
        public void Zero(){} // RVA: 0x7FFE8A40DAD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Nat320 : Object
    {
        // ── Methods ──
        public void Copy64(){} // RVA: 0x7FFE8A40DBD0 | overloaded x2
        public void Create64(){} // RVA: 0x7FFE8A40DCB0
        public void CreateExt64(){} // RVA: 0x7FFE8A40DCF0
        public void Eq64(){} // RVA: 0x7FFE8A40DD30
        public void FromBigInteger64(){} // RVA: 0x7FFE8A40DD90
        public void IsOne64(){} // RVA: 0x7FFE8A40DEF0
        public void IsZero64(){} // RVA: 0x7FFE8A40DF50
        public void ToBigInteger64(){} // RVA: 0x7FFE8A40DF90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Nat384 : Object
    {
        // ── Methods ──
        public void Mul(){} // RVA: 0x7FFE8A40E090
        public void Square(){} // RVA: 0x7FFE8A40E410
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Nat448 : Object
    {
        // ── Methods ──
        public void Copy64(){} // RVA: 0x7FFE8A40E710 | overloaded x2
        public void Create64(){} // RVA: 0x7FFE8A40E840
        public void CreateExt64(){} // RVA: 0x7FFE8A40E880
        public void Eq64(){} // RVA: 0x7FFE8A40E8C0
        public void FromBigInteger64(){} // RVA: 0x7FFE8A40E920
        public void IsOne64(){} // RVA: 0x7FFE8A40EA80
        public void IsZero64(){} // RVA: 0x7FFE8A40EAE0
        public void ToBigInteger64(){} // RVA: 0x7FFE8A40EB20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Nat512 : Object
    {
        // ── Methods ──
        public void Mul(){} // RVA: 0x7FFE8A40EC20
        public void Square(){} // RVA: 0x7FFE8A40EFA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Nat576 : Object
    {
        // ── Methods ──
        public void Copy64(){} // RVA: 0x7FFE8A40F2D0 | overloaded x2
        public void Create64(){} // RVA: 0x7FFE8A40F460
        public void CreateExt64(){} // RVA: 0x7FFE8A40F4A0
        public void Eq64(){} // RVA: 0x7FFE8A40F4E0
        public void FromBigInteger64(){} // RVA: 0x7FFE8A40F540
        public void IsOne64(){} // RVA: 0x7FFE8A40F6A0
        public void IsZero64(){} // RVA: 0x7FFE8A40F700
        public void ToBigInteger64(){} // RVA: 0x7FFE8A40F740
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}