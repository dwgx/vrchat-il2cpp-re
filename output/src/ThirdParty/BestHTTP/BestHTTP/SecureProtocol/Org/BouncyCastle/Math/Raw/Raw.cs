// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Raw
// Classes: 13
// Methods: 283

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.Raw
{
    public class Interleave : Object
    {
        public object M32;
        public object M64;
        public object M64R;

        // ── Methods ──
        public void Expand8to16(){} // RVA: 0xA643BE0
        public void Expand16to32(){} // RVA: 0xA643C10
        public void Expand32to64(){} // RVA: 0xA643C50
        public void Expand64To128(){} // RVA: 0xA643CD0
        public void Expand64To128Rev(){} // RVA: 0xA643DD0
        public void Shuffle(){} // RVA: 0xA643F40
        public void Shuffle2(){} // RVA: 0xA643FF0
        public void Unshuffle(){} // RVA: 0xA6440B0
        public void Unshuffle2(){} // RVA: 0xA644160
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Mod : Object
    {
        public object RandomSource;

        // ── Methods ──
        public void Invert(){} // RVA: 0xA6441C0
        public void Random(){} // RVA: 0xA644A20
        public void Add(){} // RVA: 0xA644CA0
        public void Subtract(){} // RVA: 0xA644DC0
        public void InversionResult(){} // RVA: 0xA644EE0
        public void InversionStep(){} // RVA: 0xA644FC0
        public void GetTrailingZeroes(){} // RVA: 0xA645240
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA645260
    }

    public class Nat : Object
    {
        public object M;

        // ── Methods ──
        public void Add(){} // RVA: 0xA645320
        public void Add33At(){} // RVA: 0xA645480
        public void Add33To(){} // RVA: 0xA645600
        public void AddBothTo(){} // RVA: 0xA645780
        public void AddDWordAt(){} // RVA: 0xA645940
        public void AddDWordTo(){} // RVA: 0xA645AD0
        public void AddTo(){} // RVA: 0xA645CD0
        public void AddToEachOther(){} // RVA: 0xA645D80
        public void AddWordAt(){} // RVA: 0xA645EC0
        public void AddWordTo(){} // RVA: 0xA646000
        public void CAdd(){} // RVA: 0xA6460A0
        public void CMov(){} // RVA: 0xA646160
        public void Copy(){} // RVA: 0xA6462C0
        public void Copy64(){} // RVA: 0xA6462C0
        public void Create(){} // RVA: 0xA646370
        public void Create64(){} // RVA: 0xA6463B0
        public void CSub(){} // RVA: 0xA6464B0
        public void Dec(){} // RVA: 0xA646610
        public void DecAt(){} // RVA: 0xA646720
        public void Eq(){} // RVA: 0xA646790
        public void FromBigInteger(){} // RVA: 0xA646800
        public void FromBigInteger64(){} // RVA: 0xA646940
        public void GetBit(){} // RVA: 0xA646AB0
        public void Gte(){} // RVA: 0xA646B10
        public void Inc(){} // RVA: 0xA646BE0
        public void IncAt(){} // RVA: 0xA646CF0
        public void IsOne(){} // RVA: 0xA646D50
        public void IsZero(){} // RVA: 0xA646DC0
        public void Mul(){} // RVA: 0xA6471E0
        public void MulAddTo(){} // RVA: 0xA647560
        public void Mul31BothAdd(){} // RVA: 0xA647710
        public void MulWord(){} // RVA: 0xA647870
        public void MulWordAddTo(){} // RVA: 0xA647920
        public void MulWordDwordAddAt(){} // RVA: 0xA6479D0
        public void ShiftDownBit(){} // RVA: 0xA647C10
        public void ShiftDownBits(){} // RVA: 0xA647EE0
        public void ShiftDownWord(){} // RVA: 0xA647FD0
        public void ShiftUpBit(){} // RVA: 0xA648190
        public void ShiftUpBit64(){} // RVA: 0xA648240
        public void ShiftUpBits(){} // RVA: 0xA6485F0
        public void ShiftUpBits64(){} // RVA: 0xA6486E0
        public void Square(){} // RVA: 0xA648A50
        public void SquareWordAdd(){} // RVA: 0xA648E30
        public void SquareWordAddTo(){} // RVA: 0xA648E30
        public void Sub(){} // RVA: 0xA648FB0
        public void Sub33At(){} // RVA: 0xA649160
        public void Sub33From(){} // RVA: 0xA6492E0
        public void SubBothFrom(){} // RVA: 0xA649460
        public void SubDWordAt(){} // RVA: 0xA649620
        public void SubDWordFrom(){} // RVA: 0xA6497B0
        public void SubFrom(){} // RVA: 0xA649900
        public void SubWordAt(){} // RVA: 0xA649A40
        public void SubWordFrom(){} // RVA: 0xA649B70
        public void ToBigInteger(){} // RVA: 0xA649C00
        public void Zero(){} // RVA: 0xA649D80
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Nat128 : Object
    {
        public object M;

        // ── Methods ──
        public void Add(){} // RVA: 0xA649DD0
        public void AddBothTo(){} // RVA: 0xA649EC0
        public void AddTo(){} // RVA: 0xA64A090
        public void AddToEachOther(){} // RVA: 0xA64A1A0
        public void Copy(){} // RVA: 0xA64A370
        public void Copy64(){} // RVA: 0xA64A470
        public void Create(){} // RVA: 0xA64A4D0
        public void Create64(){} // RVA: 0xA64A510
        public void CreateExt(){} // RVA: 0xA64A550
        public void CreateExt64(){} // RVA: 0xA64A590
        public void Diff(){} // RVA: 0xA64A5D0
        public void Eq(){} // RVA: 0xA64A6F0
        public void Eq64(){} // RVA: 0xA64A760
        public void FromBigInteger(){} // RVA: 0xA64A7D0
        public void FromBigInteger64(){} // RVA: 0xA64A910
        public void GetBit(){} // RVA: 0xA64AA80
        public void Gte(){} // RVA: 0xA64AB50
        public void IsOne(){} // RVA: 0xA64ABF0
        public void IsOne64(){} // RVA: 0xA64AC50
        public void IsZero(){} // RVA: 0xA64ACB0
        public void IsZero64(){} // RVA: 0xA64AD10
        public void Mul(){} // RVA: 0xA64AF60
        public void MulAddTo(){} // RVA: 0xA64B320
        public void Mul33Add(){} // RVA: 0xA64B4E0
        public void MulWordAddExt(){} // RVA: 0xA64B660
        public void Mul33DWordAdd(){} // RVA: 0xA64B760
        public void Mul33WordAdd(){} // RVA: 0xA64B820
        public void MulWordDwordAdd(){} // RVA: 0xA64B900
        public void MulWordsAdd(){} // RVA: 0xA64B9F0
        public void MulWord(){} // RVA: 0xA64BAB0
        public void Square(){} // RVA: 0xA64BDD0
        public void Sub(){} // RVA: 0xA64C220
        public void SubBothFrom(){} // RVA: 0xA64C370
        public void SubFrom(){} // RVA: 0xA64C540
        public void ToBigInteger(){} // RVA: 0xA64C650
        public void ToBigInteger64(){} // RVA: 0xA64C7A0
        public void Zero(){} // RVA: 0xA64C8C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Nat160 : Object
    {
        public object M;

        // ── Methods ──
        public void Add(){} // RVA: 0xA64C900
        public void AddBothTo(){} // RVA: 0xA64CA20
        public void AddTo(){} // RVA: 0xA64CC60
        public void AddToEachOther(){} // RVA: 0xA64CDC0
        public void Copy(){} // RVA: 0xA64CFF0
        public void Create(){} // RVA: 0xA64D0D0
        public void CreateExt(){} // RVA: 0xA64D110
        public void Diff(){} // RVA: 0xA64D150
        public void Eq(){} // RVA: 0xA64D270
        public void FromBigInteger(){} // RVA: 0xA64D2E0
        public void GetBit(){} // RVA: 0xA64D420
        public void Gte(){} // RVA: 0xA64D4F0
        public void IsOne(){} // RVA: 0xA64D590
        public void IsZero(){} // RVA: 0xA64D5F0
        public void Mul(){} // RVA: 0xA64D8A0
        public void MulAddTo(){} // RVA: 0xA64DCF0
        public void Mul33Add(){} // RVA: 0xA64DF00
        public void MulWordAddExt(){} // RVA: 0xA64E0D0
        public void Mul33DWordAdd(){} // RVA: 0xA64E220
        public void Mul33WordAdd(){} // RVA: 0xA64E330
        public void MulWordDwordAdd(){} // RVA: 0xA64E410
        public void MulWordsAdd(){} // RVA: 0xA64E500
        public void MulWord(){} // RVA: 0xA64E5C0
        public void Square(){} // RVA: 0xA64E9A0
        public void Sub(){} // RVA: 0xA64EF00
        public void SubBothFrom(){} // RVA: 0xA64F090
        public void SubFrom(){} // RVA: 0xA64F2D0
        public void ToBigInteger(){} // RVA: 0xA64F410
        public void Zero(){} // RVA: 0xA64F560
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Nat192 : Object
    {
        public object M;

        // ── Methods ──
        public void Add(){} // RVA: 0xA64F5B0
        public void AddBothTo(){} // RVA: 0xA64F700
        public void AddTo(){} // RVA: 0xA64F9A0
        public void AddToEachOther(){} // RVA: 0xA64FB20
        public void Copy(){} // RVA: 0xA64FDC0
        public void Copy64(){} // RVA: 0xA64FF30
        public void Create(){} // RVA: 0xA64FFB0
        public void Create64(){} // RVA: 0xA64FFF0
        public void CreateExt(){} // RVA: 0xA650030
        public void CreateExt64(){} // RVA: 0xA650070
        public void Diff(){} // RVA: 0xA6500B0
        public void Eq(){} // RVA: 0xA6501D0
        public void Eq64(){} // RVA: 0xA650240
        public void FromBigInteger(){} // RVA: 0xA6502B0
        public void FromBigInteger64(){} // RVA: 0xA6503F0
        public void GetBit(){} // RVA: 0xA650560
        public void Gte(){} // RVA: 0xA650630
        public void IsOne(){} // RVA: 0xA6506D0
        public void IsOne64(){} // RVA: 0xA650730
        public void IsZero(){} // RVA: 0xA650790
        public void IsZero64(){} // RVA: 0xA6507F0
        public void Mul(){} // RVA: 0xA650AE0
        public void MulAddTo(){} // RVA: 0xA650FE0
        public void Mul33Add(){} // RVA: 0xA651220
        public void MulWordAddExt(){} // RVA: 0xA651440
        public void Mul33DWordAdd(){} // RVA: 0xA6515B0
        public void Mul33WordAdd(){} // RVA: 0xA6516C0
        public void MulWordDwordAdd(){} // RVA: 0xA6517A0
        public void MulWord(){} // RVA: 0xA651890
        public void Square(){} // RVA: 0xA651D50
        public void Sub(){} // RVA: 0xA652400
        public void SubBothFrom(){} // RVA: 0xA6525D0
        public void SubFrom(){} // RVA: 0xA652860
        public void ToBigInteger(){} // RVA: 0xA6529E0
        public void ToBigInteger64(){} // RVA: 0xA652B30
        public void Zero(){} // RVA: 0xA652C50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Nat224 : Object
    {
        public object M;

        // ── Methods ──
        public void Add(){} // RVA: 0xA652E40
        public void AddBothTo(){} // RVA: 0xA653200
        public void AddTo(){} // RVA: 0xA653580
        public void AddToEachOther(){} // RVA: 0xA653740
        public void Copy(){} // RVA: 0xA653A50
        public void Create(){} // RVA: 0xA653B80
        public void CreateExt(){} // RVA: 0xA653BC0
        public void Diff(){} // RVA: 0xA653C00
        public void Eq(){} // RVA: 0xA653D20
        public void FromBigInteger(){} // RVA: 0xA653D90
        public void GetBit(){} // RVA: 0xA653ED0
        public void Gte(){} // RVA: 0xA653FA0
        public void IsOne(){} // RVA: 0xA654040
        public void IsZero(){} // RVA: 0xA6540A0
        public void Mul(){} // RVA: 0xA6543E0
        public void MulAddTo(){} // RVA: 0xA654970
        public void Mul33Add(){} // RVA: 0xA654C00
        public void MulByWord(){} // RVA: 0xA654E60
        public void MulByWordAddTo(){} // RVA: 0xA654F40
        public void MulWordAddTo(){} // RVA: 0xA6550A0
        public void Mul33DWordAdd(){} // RVA: 0xA655250
        public void Mul33WordAdd(){} // RVA: 0xA655360
        public void MulWordDwordAdd(){} // RVA: 0xA655440
        public void MulWord(){} // RVA: 0xA655530
        public void Square(){} // RVA: 0xA655AF0
        public void Sub(){} // RVA: 0xA656340
        public void SubBothFrom(){} // RVA: 0xA656560
        public void SubFrom(){} // RVA: 0xA656860
        public void ToBigInteger(){} // RVA: 0xA656A20
        public void Zero(){} // RVA: 0xA656B70
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Nat256 : Object
    {
        public object M;

        // ── Methods ──
        public void Add(){} // RVA: 0xA656D90
        public void AddBothTo(){} // RVA: 0xA6571D0
        public void AddTo(){} // RVA: 0xA6575B0
        public void AddToEachOther(){} // RVA: 0xA6577B0
        public void Copy(){} // RVA: 0xA657B30
        public void Copy64(){} // RVA: 0xA657D00
        public void Create(){} // RVA: 0xA657DB0
        public void Create64(){} // RVA: 0xA657DF0
        public void CreateExt(){} // RVA: 0xA657E30
        public void CreateExt64(){} // RVA: 0xA657E70
        public void Diff(){} // RVA: 0xA657EB0
        public void Eq(){} // RVA: 0xA657FD0
        public void Eq64(){} // RVA: 0xA658040
        public void FromBigInteger(){} // RVA: 0xA6580B0
        public void FromBigInteger64(){} // RVA: 0xA6581F0
        public void GetBit(){} // RVA: 0xA658360
        public void Gte(){} // RVA: 0xA658430
        public void IsOne(){} // RVA: 0xA6584D0
        public void IsOne64(){} // RVA: 0xA658530
        public void IsZero(){} // RVA: 0xA658590
        public void IsZero64(){} // RVA: 0xA6585F0
        public void Mul(){} // RVA: 0xA658990
        public void MulAddTo(){} // RVA: 0xA658FF0
        public void Mul33Add(){} // RVA: 0xA6592C0
        public void MulByWord(){} // RVA: 0xA659570
        public void MulByWordAddTo(){} // RVA: 0xA659680
        public void MulWordAddTo(){} // RVA: 0xA659800
        public void Mul33DWordAdd(){} // RVA: 0xA6599E0
        public void Mul33WordAdd(){} // RVA: 0xA659AF0
        public void MulWordDwordAdd(){} // RVA: 0xA659BD0
        public void MulWord(){} // RVA: 0xA659CC0
        public void Square(){} // RVA: 0xA65A3E0
        public void Sub(){} // RVA: 0xA65ADD0
        public void SubBothFrom(){} // RVA: 0xA65B030
        public void SubFrom(){} // RVA: 0xA65B390
        public void ToBigInteger(){} // RVA: 0xA65B580
        public void ToBigInteger64(){} // RVA: 0xA65B6D0
        public void Zero(){} // RVA: 0xA65B7F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Nat320 : Object
    {
        // ── Methods ──
        public void Copy64(){} // RVA: 0xA65B8F0
        public void Create64(){} // RVA: 0xA65B9D0
        public void CreateExt64(){} // RVA: 0xA65BA10
        public void Eq64(){} // RVA: 0xA65BA50
        public void FromBigInteger64(){} // RVA: 0xA65BAC0
        public void IsOne64(){} // RVA: 0xA65BC30
        public void IsZero64(){} // RVA: 0xA65BC90
        public void ToBigInteger64(){} // RVA: 0xA65BCF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Nat384 : Object
    {
        // ── Methods ──
        public void Mul(){} // RVA: 0xA65BE10
        public void Square(){} // RVA: 0xA65C170
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Nat448 : Object
    {
        // ── Methods ──
        public void Copy64(){} // RVA: 0xA65C470
        public void Create64(){} // RVA: 0xA65C5A0
        public void CreateExt64(){} // RVA: 0xA65C5E0
        public void Eq64(){} // RVA: 0xA65C620
        public void FromBigInteger64(){} // RVA: 0xA65C690
        public void IsOne64(){} // RVA: 0xA65C800
        public void IsZero64(){} // RVA: 0xA65C860
        public void ToBigInteger64(){} // RVA: 0xA65C8C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Nat512 : Object
    {
        // ── Methods ──
        public void Mul(){} // RVA: 0xA65C9E0
        public void Square(){} // RVA: 0xA65CD50
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Nat576 : Object
    {
        // ── Methods ──
        public void Copy64(){} // RVA: 0xA65D090
        public void Create64(){} // RVA: 0xA65D220
        public void CreateExt64(){} // RVA: 0xA65D260
        public void Eq64(){} // RVA: 0xA65D2A0
        public void FromBigInteger64(){} // RVA: 0xA65D310
        public void IsOne64(){} // RVA: 0xA65D480
        public void IsZero64(){} // RVA: 0xA65D4E0
        public void ToBigInteger64(){} // RVA: 0xA65D540
        public void .ctor(){} // RVA: 0xB43310
    }

}