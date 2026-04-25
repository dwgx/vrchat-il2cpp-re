// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Abc
// Classes: 3
// Methods: 48

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Abc
{
    public class SimpleBigDecimal : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger IntValue; // 0x10
        public int LongValue; // 0x18

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFACBB0C820
        public void .ctor(){} // RVA: 0x7FFACBB0C960 | overloaded x2
        public void CheckScale(){} // RVA: 0x7FFACBB0C9E0
        public void AdjustScale(){} // RVA: 0x7FFACBB0CA50
        public void Add(){} // RVA: 0x7FFACBB0CC20 | overloaded x2
        public void Negate(){} // RVA: 0x7FFACBB0CCC0
        public void Subtract(){} // RVA: 0x7FFACBB0CE00 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFACBB0CF90 | overloaded x2
        public void Divide(){} // RVA: 0x7FFACBB0D120 | overloaded x2
        public void ShiftLeft(){} // RVA: 0x7FFACBB0D1B0
        public void CompareTo(){} // RVA: 0x7FFACBB0D2D0 | overloaded x2
        public void Floor(){} // RVA: 0x7FFACBB0D310
        public void Round(){} // RVA: 0x7FFACBB0D340
        public void get_IntValue(){} // RVA: 0x7FFACBB0D510
        public void get_LongValue(){} // RVA: 0x7FFACBB0D580
        public void get_Scale(){} // RVA: 0x7FFAC3157800
        public void ToString(){} // RVA: 0x7FFACBB0D5C0
        public void Equals(){} // RVA: 0x7FFACBB0D940
        public void GetHashCode(){} // RVA: 0x7FFAC9468FC0
    }

    public class Tnaf : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger MinusOne;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger MinusTwo; // 0x8
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger MinusThree; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger Four; // 0x18
        public sbyte Width;
        public sbyte Pow2Width;
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Abc.ZTauElement[] Alpha0; // 0x20
        public sbyte[][] Alpha0Tnaf; // 0x28
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Abc.ZTauElement[] Alpha1; // 0x30
        public sbyte[][] Alpha1Tnaf; // 0x38

        // ── Methods ──
        public void Norm(){} // RVA: 0x7FFACBB0DB60 | overloaded x2
        public void Round(){} // RVA: 0x7FFACBB0DCE0
        public void ApproximateDivisionByN(){} // RVA: 0x7FFACBB0E240
        public void TauAdicNaf(){} // RVA: 0x7FFACBB0E3E0
        public void Tau(){} // RVA: 0x7FFACBB0E840
        public void GetMu(){} // RVA: 0x7FFACBB0E9D0 | overloaded x3
        public void GetLucas(){} // RVA: 0x7FFACBB0E9F0
        public void GetTw(){} // RVA: 0x7FFACBB0EC20
        public void GetSi(){} // RVA: 0x7FFACBB0F1D0 | overloaded x2
        public void GetShiftsForCofactor(){} // RVA: 0x7FFACBB0F4C0
        public void PartModReduction(){} // RVA: 0x7FFACBB0F580
        public void MultiplyRTnaf(){} // RVA: 0x7FFACBB0F890
        public void MultiplyTnaf(){} // RVA: 0x7FFACBB0FB60
        public void MultiplyFromTnaf(){} // RVA: 0x7FFACBB0FCA0
        public void TauAdicWNaf(){} // RVA: 0x7FFACBB0FEF0
        public void GetPreComp(){} // RVA: 0x7FFACBB103A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBB10600
    }

    public class ZTauElement : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger u; // 0x10
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger v; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
    }

}