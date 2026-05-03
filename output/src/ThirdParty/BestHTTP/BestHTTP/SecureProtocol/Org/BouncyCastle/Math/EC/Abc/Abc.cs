// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Abc
// Classes: 3
// Methods: 48

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Abc
{
    public class SimpleBigDecimal : Object
    {
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger bigInt; // 0x10
        public int scale; // 0x18
        public object field_2; // 0x3C1

        // ── Methods ──
        public void GetInstance(){} // RVA: 0x7FFE89F65E40
        public void .ctor(){} // RVA: 0x7FFE89F65F80 | overloaded x2
        public void CheckScale(){} // RVA: 0x7FFE89F66000
        public void AdjustScale(){} // RVA: 0x7FFE89F66070
        public void Add(){} // RVA: 0x7FFE89F66240 | overloaded x2
        public void Negate(){} // RVA: 0x7FFE89F662E0
        public void Subtract(){} // RVA: 0x7FFE89F66420 | overloaded x2
        public void Multiply(){} // RVA: 0x7FFE89F665B0 | overloaded x2
        public void Divide(){} // RVA: 0x7FFE89F66740 | overloaded x2
        public void ShiftLeft(){} // RVA: 0x7FFE89F667D0
        public void CompareTo(){} // RVA: 0x7FFE89F668F0 | overloaded x2
        public void Floor(){} // RVA: 0x7FFE89F66930
        public void Round(){} // RVA: 0x7FFE89F66960
        public void get_IntValue(){} // RVA: 0x7FFE89F66B30
        public void get_LongValue(){} // RVA: 0x7FFE89F66BA0
        public void get_Scale(){} // RVA: 0x7FFE813DB630
        public void ToString(){} // RVA: 0x7FFE89F66BE0
        public void Equals(){} // RVA: 0x7FFE89F66F60
        public void GetHashCode(){} // RVA: 0x7FFE87811700
    }

    public class Tnaf : Object
    {
        // ── Methods ──
        public void Norm(){} // RVA: 0x7FFE89F67180 | overloaded x2
        public void Round(){} // RVA: 0x7FFE89F67300
        public void ApproximateDivisionByN(){} // RVA: 0x7FFE89F67860
        public void TauAdicNaf(){} // RVA: 0x7FFE89F67A00
        public void Tau(){} // RVA: 0x7FFE89F67E60
        public void GetMu(){} // RVA: 0x7FFE89F67FF0 | overloaded x3
        public void GetLucas(){} // RVA: 0x7FFE89F68010
        public void GetTw(){} // RVA: 0x7FFE89F68240
        public void GetSi(){} // RVA: 0x7FFE89F687F0 | overloaded x2
        public void GetShiftsForCofactor(){} // RVA: 0x7FFE89F68AE0
        public void PartModReduction(){} // RVA: 0x7FFE89F68BA0
        public void MultiplyRTnaf(){} // RVA: 0x7FFE89F68EB0
        public void MultiplyTnaf(){} // RVA: 0x7FFE89F69180
        public void MultiplyFromTnaf(){} // RVA: 0x7FFE89F692C0
        public void TauAdicWNaf(){} // RVA: 0x7FFE89F69510
        public void GetPreComp(){} // RVA: 0x7FFE89F699C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE89F69C20
    }

    public class ZTauElement : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
    }

}