// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Raw
// Classes: 13
// Methods: 383

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Raw
{
    public class Interleave : Object
    {
        public ulong M32;
        public ulong M64;
        public ulong M64R;

        // ── Methods ──
        public void Expand8to16(){} // RVA: 0x7FFACBF963F0
        public void Expand16to32(){} // RVA: 0x7FFACBF96420
        public void Expand32to64(){} // RVA: 0x7FFACBF96460
        public void Expand64To128(){} // RVA: 0x7FFACBF964F0
        public void Expand64To128Rev(){} // RVA: 0x7FFACBF965F0
        public void Shuffle(){} // RVA: 0x7FFACBF96770 | overloaded x2
        public void Shuffle2(){} // RVA: 0x7FFACBF96820
        public void Unshuffle(){} // RVA: 0x7FFACBF96900 | overloaded x2
        public void Unshuffle2(){} // RVA: 0x7FFACBF969B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Mod : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Security.SecureRandom RandomSource;

        // ── Methods ──
        public void Invert(){} // RVA: 0x7FFACBF96A20
        public void Random(){} // RVA: 0x7FFACBF97170
        public void Add(){} // RVA: 0x7FFACBF973C0
        public void Subtract(){} // RVA: 0x7FFACBF974C0
        public void InversionResult(){} // RVA: 0x7FFACBF975B0
        public void InversionStep(){} // RVA: 0x7FFACBF97660
        public void GetTrailingZeroes(){} // RVA: 0x7FFACBF978D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF978F0
    }

    public class Nat : Object
    {
        public ulong M;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBF979B0
        public void Add33At(){} // RVA: 0x7FFACBF97AD0 | overloaded x2
        public void Add33To(){} // RVA: 0x7FFACBF97C30 | overloaded x2
        public void AddBothTo(){} // RVA: 0x7FFACBF97D70 | overloaded x2
        public void AddDWordAt(){} // RVA: 0x7FFACBF97F00 | overloaded x2
        public void AddDWordTo(){} // RVA: 0x7FFACBF98070 | overloaded x2
        public void AddTo(){} // RVA: 0x7FFACBF98230 | overloaded x3
        public void AddToEachOther(){} // RVA: 0x7FFACBF982D0
        public void AddWordAt(){} // RVA: 0x7FFACBF983F0 | overloaded x2
        public void AddWordTo(){} // RVA: 0x7FFACBF98500 | overloaded x2
        public void CAdd(){} // RVA: 0x7FFACBF98580
        public void CMov(){} // RVA: 0x7FFACBF98620 | overloaded x2
        public void Copy(){} // RVA: 0x7FFACBF98770 | overloaded x3
        public void Copy64(){} // RVA: 0x7FFACBF98770 | overloaded x3
        public void Create(){} // RVA: 0x7FFACBF98820
        public void Create64(){} // RVA: 0x7FFACBF98860
        public void CSub(){} // RVA: 0x7FFACBF98940 | overloaded x2
        public void Dec(){} // RVA: 0x7FFACBF98A80 | overloaded x2
        public void DecAt(){} // RVA: 0x7FFACBF98B70 | overloaded x2
        public void Eq(){} // RVA: 0x7FFACBF98BD0
        public void FromBigInteger(){} // RVA: 0x7FFACBF98C30
        public void FromBigInteger64(){} // RVA: 0x7FFACBF98D60
        public void GetBit(){} // RVA: 0x7FFACBF98EC0
        public void Gte(){} // RVA: 0x7FFACBF98F20
        public void Inc(){} // RVA: 0x7FFACBF98FD0 | overloaded x2
        public void IncAt(){} // RVA: 0x7FFACBF990B0 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFACBF99110
        public void IsZero(){} // RVA: 0x7FFACBF99170
        public void Mul(){} // RVA: 0x7FFACBF994D0 | overloaded x3
        public void MulAddTo(){} // RVA: 0x7FFACBF997C0 | overloaded x2
        public void Mul31BothAdd(){} // RVA: 0x7FFACBF99910
        public void MulWord(){} // RVA: 0x7FFACBF99A50 | overloaded x2
        public void MulWordAddTo(){} // RVA: 0x7FFACBF99AF0
        public void MulWordDwordAddAt(){} // RVA: 0x7FFACBF99BA0
        public void ShiftDownBit(){} // RVA: 0x7FFACBF99D90 | overloaded x4
        public void ShiftDownBits(){} // RVA: 0x7FFACBF9A000 | overloaded x4
        public void ShiftDownWord(){} // RVA: 0x7FFACBF9A0D0
        public void ShiftUpBit(){} // RVA: 0x7FFACBF9A250 | overloaded x4
        public void ShiftUpBit64(){} // RVA: 0x7FFACBF9A2F0
        public void ShiftUpBits(){} // RVA: 0x7FFACBF9A640 | overloaded x4
        public void ShiftUpBits64(){} // RVA: 0x7FFACBF9A710 | overloaded x2
        public void Square(){} // RVA: 0x7FFACBF9A9D0 | overloaded x2
        public void SquareWordAdd(){} // RVA: 0x7FFACBF9AC90 | overloaded x2
        public void SquareWordAddTo(){} // RVA: 0x7FFACBF9AC90 | overloaded x2
        public void Sub(){} // RVA: 0x7FFACBF9ADC0 | overloaded x2
        public void Sub33At(){} // RVA: 0x7FFACBF9AF40 | overloaded x2
        public void Sub33From(){} // RVA: 0x7FFACBF9B0C0 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFACBF9B200 | overloaded x2
        public void SubDWordAt(){} // RVA: 0x7FFACBF9B390 | overloaded x2
        public void SubDWordFrom(){} // RVA: 0x7FFACBF9B510 | overloaded x2
        public void SubFrom(){} // RVA: 0x7FFACBF9B640 | overloaded x2
        public void SubWordAt(){} // RVA: 0x7FFACBF9B750 | overloaded x2
        public void SubWordFrom(){} // RVA: 0x7FFACBF9B860 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFACBF9B8E0
        public void Zero(){} // RVA: 0x7FFACBF9BA40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Nat128 : Object
    {
        public ulong M;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBF9BA80
        public void AddBothTo(){} // RVA: 0x7FFACBF9BB70
        public void AddTo(){} // RVA: 0x7FFACBF9BD40 | overloaded x2
        public void AddToEachOther(){} // RVA: 0x7FFACBF9BE50
        public void Copy(){} // RVA: 0x7FFACBF9C010 | overloaded x2
        public void Copy64(){} // RVA: 0x7FFACBF9C110 | overloaded x2
        public void Create(){} // RVA: 0x7FFACBF9C170
        public void Create64(){} // RVA: 0x7FFACBF9C1B0
        public void CreateExt(){} // RVA: 0x7FFACBF9C1F0
        public void CreateExt64(){} // RVA: 0x7FFACBF9C230
        public void Diff(){} // RVA: 0x7FFACBF9C270
        public void Eq(){} // RVA: 0x7FFACBF9C370
        public void Eq64(){} // RVA: 0x7FFACBF9C3D0
        public void FromBigInteger(){} // RVA: 0x7FFACBF9C430
        public void FromBigInteger64(){} // RVA: 0x7FFACBF9C560
        public void GetBit(){} // RVA: 0x7FFACBF9C6C0
        public void Gte(){} // RVA: 0x7FFACBF9C780 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFACBF9C7F0
        public void IsOne64(){} // RVA: 0x7FFACBF9C840
        public void IsZero(){} // RVA: 0x7FFACBF9C8A0
        public void IsZero64(){} // RVA: 0x7FFACBF9C8E0
        public void Mul(){} // RVA: 0x7FFACBF9CB30 | overloaded x2
        public void MulAddTo(){} // RVA: 0x7FFACBF9CF00 | overloaded x2
        public void Mul33Add(){} // RVA: 0x7FFACBF9D0D0
        public void MulWordAddExt(){} // RVA: 0x7FFACBF9D260
        public void Mul33DWordAdd(){} // RVA: 0x7FFACBF9D370
        public void Mul33WordAdd(){} // RVA: 0x7FFACBF9D440
        public void MulWordDwordAdd(){} // RVA: 0x7FFACBF9D510
        public void MulWordsAdd(){} // RVA: 0x7FFACBF9D5F0
        public void MulWord(){} // RVA: 0x7FFACBF9D690
        public void Square(){} // RVA: 0x7FFACBF9D990 | overloaded x2
        public void Sub(){} // RVA: 0x7FFACBF9DDB0 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFACBF9DF00
        public void SubFrom(){} // RVA: 0x7FFACBF9E0D0 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFACBF9E1E0
        public void ToBigInteger64(){} // RVA: 0x7FFACBF9E320
        public void Zero(){} // RVA: 0x7FFACBF9E420
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Nat160 : Object
    {
        public ulong M;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBF9E460
        public void AddBothTo(){} // RVA: 0x7FFACBF9E580
        public void AddTo(){} // RVA: 0x7FFACBF9E7C0 | overloaded x2
        public void AddToEachOther(){} // RVA: 0x7FFACBF9E920
        public void Copy(){} // RVA: 0x7FFACBF9EB60 | overloaded x2
        public void Create(){} // RVA: 0x7FFACBF9EC40
        public void CreateExt(){} // RVA: 0x7FFACBF9EC80
        public void Diff(){} // RVA: 0x7FFACBF9ECC0
        public void Eq(){} // RVA: 0x7FFACBF9EDC0
        public void FromBigInteger(){} // RVA: 0x7FFACBF9EE20
        public void GetBit(){} // RVA: 0x7FFACBF9EF50
        public void Gte(){} // RVA: 0x7FFACBF9F010 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFACBF9F080
        public void IsZero(){} // RVA: 0x7FFACBF9F0D0
        public void Mul(){} // RVA: 0x7FFACBF9F370 | overloaded x2
        public void MulAddTo(){} // RVA: 0x7FFACBF9F7E0 | overloaded x2
        public void Mul33Add(){} // RVA: 0x7FFACBF9F9F0
        public void MulWordAddExt(){} // RVA: 0x7FFACBF9FBC0
        public void Mul33DWordAdd(){} // RVA: 0x7FFACBF9FD00
        public void Mul33WordAdd(){} // RVA: 0x7FFACBF9FE00
        public void MulWordDwordAdd(){} // RVA: 0x7FFACBF9FED0
        public void MulWordsAdd(){} // RVA: 0x7FFACBF9FFB0
        public void MulWord(){} // RVA: 0x7FFACBFA0050
        public void Square(){} // RVA: 0x7FFACBFA0410 | overloaded x2
        public void Sub(){} // RVA: 0x7FFACBFA0950 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFACBFA0AE0
        public void SubFrom(){} // RVA: 0x7FFACBFA0D20 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFACBFA0E60
        public void Zero(){} // RVA: 0x7FFACBFA0FA0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Nat192 : Object
    {
        public ulong M;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBFA0FF0
        public void AddBothTo(){} // RVA: 0x7FFACBFA1140
        public void AddTo(){} // RVA: 0x7FFACBFA13E0 | overloaded x2
        public void AddToEachOther(){} // RVA: 0x7FFACBFA1560
        public void Copy(){} // RVA: 0x7FFACBFA1800 | overloaded x2
        public void Copy64(){} // RVA: 0x7FFACBFA1970 | overloaded x2
        public void Create(){} // RVA: 0x7FFACBFA19F0
        public void Create64(){} // RVA: 0x7FFACBFA1A30
        public void CreateExt(){} // RVA: 0x7FFACBFA1A70
        public void CreateExt64(){} // RVA: 0x7FFACBFA1AB0
        public void Diff(){} // RVA: 0x7FFACBFA1AF0
        public void Eq(){} // RVA: 0x7FFACBFA1BF0
        public void Eq64(){} // RVA: 0x7FFACBFA1C50
        public void FromBigInteger(){} // RVA: 0x7FFACBFA1CB0
        public void FromBigInteger64(){} // RVA: 0x7FFACBFA1DE0
        public void GetBit(){} // RVA: 0x7FFACBFA1F40
        public void Gte(){} // RVA: 0x7FFACBFA2000 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFACBFA2070
        public void IsOne64(){} // RVA: 0x7FFACBFA20C0
        public void IsZero(){} // RVA: 0x7FFACBFA2120
        public void IsZero64(){} // RVA: 0x7FFACBFA2160
        public void Mul(){} // RVA: 0x7FFACBFA2460 | overloaded x2
        public void MulAddTo(){} // RVA: 0x7FFACBFA2980 | overloaded x2
        public void Mul33Add(){} // RVA: 0x7FFACBFA2BE0
        public void MulWordAddExt(){} // RVA: 0x7FFACBFA2E00
        public void Mul33DWordAdd(){} // RVA: 0x7FFACBFA2F70
        public void Mul33WordAdd(){} // RVA: 0x7FFACBFA3070
        public void MulWordDwordAdd(){} // RVA: 0x7FFACBFA3140
        public void MulWord(){} // RVA: 0x7FFACBFA3220
        public void Square(){} // RVA: 0x7FFACBFA36C0 | overloaded x2
        public void Sub(){} // RVA: 0x7FFACBFA3D50 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFACBFA3F20
        public void SubFrom(){} // RVA: 0x7FFACBFA41B0 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFACBFA4330
        public void ToBigInteger64(){} // RVA: 0x7FFACBFA4470
        public void Zero(){} // RVA: 0x7FFACBFA4570
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Nat224 : Object
    {
        public ulong M;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBFA4760 | overloaded x2
        public void AddBothTo(){} // RVA: 0x7FFACBFA4B20 | overloaded x2
        public void AddTo(){} // RVA: 0x7FFACBFA4EA0 | overloaded x2
        public void AddToEachOther(){} // RVA: 0x7FFACBFA5060
        public void Copy(){} // RVA: 0x7FFACBFA5370 | overloaded x2
        public void Create(){} // RVA: 0x7FFACBFA54A0
        public void CreateExt(){} // RVA: 0x7FFACBFA54E0
        public void Diff(){} // RVA: 0x7FFACBFA5520
        public void Eq(){} // RVA: 0x7FFACBFA5620
        public void FromBigInteger(){} // RVA: 0x7FFACBFA5680
        public void GetBit(){} // RVA: 0x7FFACBFA57B0
        public void Gte(){} // RVA: 0x7FFACBFA5870 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFACBFA58E0
        public void IsZero(){} // RVA: 0x7FFACBFA5930
        public void Mul(){} // RVA: 0x7FFACBFA5C90 | overloaded x2
        public void MulAddTo(){} // RVA: 0x7FFACBFA6250 | overloaded x2
        public void Mul33Add(){} // RVA: 0x7FFACBFA6500
        public void MulByWord(){} // RVA: 0x7FFACBFA6770
        public void MulByWordAddTo(){} // RVA: 0x7FFACBFA6840
        public void MulWordAddTo(){} // RVA: 0x7FFACBFA69A0
        public void Mul33DWordAdd(){} // RVA: 0x7FFACBFA6B50
        public void Mul33WordAdd(){} // RVA: 0x7FFACBFA6C50
        public void MulWordDwordAdd(){} // RVA: 0x7FFACBFA6D20
        public void MulWord(){} // RVA: 0x7FFACBFA6E00
        public void Square(){} // RVA: 0x7FFACBFA73C0 | overloaded x2
        public void Sub(){} // RVA: 0x7FFACBFA7BE0 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFACBFA7E00
        public void SubFrom(){} // RVA: 0x7FFACBFA8100 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFACBFA82C0
        public void Zero(){} // RVA: 0x7FFACBFA8400
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Nat256 : Object
    {
        public ulong M;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFACBFA8620 | overloaded x2
        public void AddBothTo(){} // RVA: 0x7FFACBFA8A60 | overloaded x2
        public void AddTo(){} // RVA: 0x7FFACBFA8E40 | overloaded x2
        public void AddToEachOther(){} // RVA: 0x7FFACBFA9040
        public void Copy(){} // RVA: 0x7FFACBFA93C0 | overloaded x2
        public void Copy64(){} // RVA: 0x7FFACBFA9590 | overloaded x2
        public void Create(){} // RVA: 0x7FFACBFA9640
        public void Create64(){} // RVA: 0x7FFACBFA9680
        public void CreateExt(){} // RVA: 0x7FFACBFA96C0
        public void CreateExt64(){} // RVA: 0x7FFACBFA9700
        public void Diff(){} // RVA: 0x7FFACBFA9740
        public void Eq(){} // RVA: 0x7FFACBFA9840
        public void Eq64(){} // RVA: 0x7FFACBFA98A0
        public void FromBigInteger(){} // RVA: 0x7FFACBFA9900
        public void FromBigInteger64(){} // RVA: 0x7FFACBFA9A30
        public void GetBit(){} // RVA: 0x7FFACBFA9B90
        public void Gte(){} // RVA: 0x7FFACBFA9C50 | overloaded x2
        public void IsOne(){} // RVA: 0x7FFACBFA9CC0
        public void IsOne64(){} // RVA: 0x7FFACBFA9D10
        public void IsZero(){} // RVA: 0x7FFACBFA9D70
        public void IsZero64(){} // RVA: 0x7FFACBFA9DB0
        public void Mul(){} // RVA: 0x7FFACBFAA170 | overloaded x2
        public void MulAddTo(){} // RVA: 0x7FFACBFAA7E0 | overloaded x2
        public void Mul33Add(){} // RVA: 0x7FFACBFAAAE0
        public void MulByWord(){} // RVA: 0x7FFACBFAADA0
        public void MulByWordAddTo(){} // RVA: 0x7FFACBFAAE90
        public void MulWordAddTo(){} // RVA: 0x7FFACBFAB020
        public void Mul33DWordAdd(){} // RVA: 0x7FFACBFAB200
        public void Mul33WordAdd(){} // RVA: 0x7FFACBFAB300
        public void MulWordDwordAdd(){} // RVA: 0x7FFACBFAB3D0
        public void MulWord(){} // RVA: 0x7FFACBFAB4B0
        public void Square(){} // RVA: 0x7FFACBFABBB0 | overloaded x2
        public void Sub(){} // RVA: 0x7FFACBFAC570 | overloaded x2
        public void SubBothFrom(){} // RVA: 0x7FFACBFAC7D0
        public void SubFrom(){} // RVA: 0x7FFACBFACB30 | overloaded x2
        public void ToBigInteger(){} // RVA: 0x7FFACBFACD20
        public void ToBigInteger64(){} // RVA: 0x7FFACBFACE60
        public void Zero(){} // RVA: 0x7FFACBFACF60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Nat320 : Object
    {
        // ── Methods ──
        public void Copy64(){} // RVA: 0x7FFACBFAD060 | overloaded x2
        public void Create64(){} // RVA: 0x7FFACBFAD140
        public void CreateExt64(){} // RVA: 0x7FFACBFAD180
        public void Eq64(){} // RVA: 0x7FFACBFAD1C0
        public void FromBigInteger64(){} // RVA: 0x7FFACBFAD220
        public void IsOne64(){} // RVA: 0x7FFACBFAD380
        public void IsZero64(){} // RVA: 0x7FFACBFAD3E0
        public void ToBigInteger64(){} // RVA: 0x7FFACBFAD420
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Nat384 : Object
    {
        // ── Methods ──
        public void Mul(){} // RVA: 0x7FFACBFAD520
        public void Square(){} // RVA: 0x7FFACBFAD8A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Nat448 : Object
    {
        // ── Methods ──
        public void Copy64(){} // RVA: 0x7FFACBFADBA0 | overloaded x2
        public void Create64(){} // RVA: 0x7FFACBFADCD0
        public void CreateExt64(){} // RVA: 0x7FFACBFADD10
        public void Eq64(){} // RVA: 0x7FFACBFADD50
        public void FromBigInteger64(){} // RVA: 0x7FFACBFADDB0
        public void IsOne64(){} // RVA: 0x7FFACBFADF10
        public void IsZero64(){} // RVA: 0x7FFACBFADF70
        public void ToBigInteger64(){} // RVA: 0x7FFACBFADFB0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Nat512 : Object
    {
        // ── Methods ──
        public void Mul(){} // RVA: 0x7FFACBFAE0B0
        public void Square(){} // RVA: 0x7FFACBFAE430
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Nat576 : Object
    {
        // ── Methods ──
        public void Copy64(){} // RVA: 0x7FFACBFAE760 | overloaded x2
        public void Create64(){} // RVA: 0x7FFACBFAE8F0
        public void CreateExt64(){} // RVA: 0x7FFACBFAE930
        public void Eq64(){} // RVA: 0x7FFACBFAE970
        public void FromBigInteger64(){} // RVA: 0x7FFACBFAE9D0
        public void IsOne64(){} // RVA: 0x7FFACBFAEB30
        public void IsZero64(){} // RVA: 0x7FFACBFAEB90
        public void ToBigInteger64(){} // RVA: 0x7FFACBFAEBD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}