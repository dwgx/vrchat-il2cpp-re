// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Rfc8032
// Classes: 2
// Methods: 106

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Rfc8032
{
    public class Ed25519 : Object
    {
        // ── Methods ──
        public void CalculateS(){} // RVA: 0x7FFE8A430A10
        public void CheckContextVar(){} // RVA: 0x7FFE8A430F00
        public void CheckPointVar(){} // RVA: 0x7FFE8A430F20
        public void CheckScalarVar(){} // RVA: 0x7FFE8A4310E0
        public void CreateDigest(){} // RVA: 0x7FFE8A4312C0
        public void CreatePrehash(){} // RVA: 0x7FFE8A431340
        public void Decode24(){} // RVA: 0x7FFE89ED0B40
        public void Decode32(){} // RVA: 0x7FFE8A431390 | overloaded x2
        public void DecodePointVar(){} // RVA: 0x7FFE8A4314B0
        public void DecodeScalar(){} // RVA: 0x7FFE8A431810
        public void Dom2(){} // RVA: 0x7FFE8A431950
        public void Encode24(){} // RVA: 0x7FFE89ED1240
        public void Encode32(){} // RVA: 0x7FFE89ECD320
        public void Encode56(){} // RVA: 0x7FFE8A431A80
        public void EncodePoint(){} // RVA: 0x7FFE8A431B70
        public void GeneratePrivateKey(){} // RVA: 0x7FFE8A431DB0
        public void GeneratePublicKey(){} // RVA: 0x7FFE8A431DE0
        public void GetWnaf(){} // RVA: 0x7FFE8A431F70
        public void ImplSign(){} // RVA: 0x7FFE8A4326A0 | overloaded x3
        public void ImplVerify(){} // RVA: 0x7FFE8A432930
        public void PointAddVar(){} // RVA: 0x7FFE8A4332C0 | overloaded x2
        public void PointAddPrecomp(){} // RVA: 0x7FFE8A4338A0
        public void PointCopy(){} // RVA: 0x7FFE8A433DF0 | overloaded x2
        public void PointDouble(){} // RVA: 0x7FFE8A433FC0
        public void PointExtendXY(){} // RVA: 0x7FFE8A4344A0 | overloaded x2
        public void PointLookup(){} // RVA: 0x7FFE8A434540
        public void PointPrecompVar(){} // RVA: 0x7FFE8A434770
        public void PointSetNeutral(){} // RVA: 0x7FFE8A434CB0 | overloaded x2
        public void Precompute(){} // RVA: 0x7FFE8A434DD0
        public void PruneScalar(){} // RVA: 0x7FFE8A435C90
        public void ReduceScalar(){} // RVA: 0x7FFE8A435CF0
        public void ScalarMultBase(){} // RVA: 0x7FFE8A4367E0
        public void ScalarMultBaseEncoded(){} // RVA: 0x7FFE8A436CB0
        public void ScalarMultBaseYZ(){} // RVA: 0x7FFE8A436D60
        public void ScalarMultStrausVar(){} // RVA: 0x7FFE8A436F20
        public void Sign(){} // RVA: 0x7FFE8A437360 | overloaded x4
        public void SignPrehash(){} // RVA: 0x7FFE8A437790 | overloaded x4
        public void Verify(){} // RVA: 0x7FFE8A437A10 | overloaded x2
        public void VerifyPrehash(){} // RVA: 0x7FFE8A437BA0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A437D50
    }

    public class Ed448 : Object
    {
        // ── Methods ──
        public void CalculateS(){} // RVA: 0x7FFE8A438B90
        public void CheckContextVar(){} // RVA: 0x7FFE8A439130
        public void CheckPointVar(){} // RVA: 0x7FFE8A439150
        public void CheckScalarVar(){} // RVA: 0x7FFE8A439320
        public void CreatePrehash(){} // RVA: 0x7FFE8A439520
        public void CreateXof(){} // RVA: 0x7FFE8A439570
        public void Decode16(){} // RVA: 0x7FFE8A439600
        public void Decode24(){} // RVA: 0x7FFE89ED0B40
        public void Decode32(){} // RVA: 0x7FFE8A439640 | overloaded x2
        public void DecodePointVar(){} // RVA: 0x7FFE8A439760
        public void DecodeScalar(){} // RVA: 0x7FFE8A439A50
        public void Dom4(){} // RVA: 0x7FFE8A439B90
        public void Encode24(){} // RVA: 0x7FFE89ED1240
        public void Encode32(){} // RVA: 0x7FFE89ECD320
        public void Encode56(){} // RVA: 0x7FFE8A439CC0
        public void EncodePoint(){} // RVA: 0x7FFE8A439DB0
        public void GeneratePrivateKey(){} // RVA: 0x7FFE8A431DB0
        public void GeneratePublicKey(){} // RVA: 0x7FFE8A439EF0
        public void GetWnaf(){} // RVA: 0x7FFE8A43A090
        public void ImplSign(){} // RVA: 0x7FFE8A43A7D0 | overloaded x3
        public void ImplVerify(){} // RVA: 0x7FFE8A43AA70
        public void PointAddVar(){} // RVA: 0x7FFE8A43AE70
        public void PointAddPrecomp(){} // RVA: 0x7FFE8A43B3C0
        public void PointCopy(){} // RVA: 0x7FFE8A43B820
        public void PointDouble(){} // RVA: 0x7FFE8A43B960
        public void PointExtendXY(){} // RVA: 0x7FFE8A43BCA0
        public void PointLookup(){} // RVA: 0x7FFE8A43BCF0
        public void PointPrecompVar(){} // RVA: 0x7FFE8A43BE70
        public void PointSetNeutral(){} // RVA: 0x7FFE8A43C070
        public void Precompute(){} // RVA: 0x7FFE8A43C110
        public void PruneScalar(){} // RVA: 0x7FFE8A43C9F0
        public void ReduceScalar(){} // RVA: 0x7FFE8A43CA50
        public void ScalarMultBase(){} // RVA: 0x7FFE8A43E070
        public void ScalarMultBaseEncoded(){} // RVA: 0x7FFE8A43E520
        public void ScalarMultBaseXY(){} // RVA: 0x7FFE8A43E5D0
        public void ScalarMultStrausVar(){} // RVA: 0x7FFE8A43E760
        public void Sign(){} // RVA: 0x7FFE8A43EA20 | overloaded x2
        public void SignPrehash(){} // RVA: 0x7FFE8A43EE50 | overloaded x4
        public void Verify(){} // RVA: 0x7FFE8A43F010
        public void VerifyPrehash(){} // RVA: 0x7FFE8A43F1A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A43F350
    }

}