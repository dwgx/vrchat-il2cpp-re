// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Rfc8032
// Classes: 2
// Methods: 83

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Rfc8032
{
    public class Ed25519 : Object
    {
        public object M28L;
        public object M32L;
        public object PointBytes;
        public object ScalarUints;
        public object ScalarBytes;
        public object PrehashSize;
        public object PublicKeySize;
        public object SecretKeySize;
        public object SignatureSize;
        public object Dom2Prefix;
        public object P;
        public object L;
        public object L0;
        public object L1;
        public object L2;
        public object L3;
        public object L4;
        public object B_x;
        public object B_y;
        public object C_d;
        public object C_d2;
        public object C_d4;
        public object WnafWidthBase;
        public object PrecompBlocks;
        public object PrecompTeeth;
        public object PrecompSpacing;
        public object PrecompPoints;
        public object PrecompMask;
        public object precompLock;
        public object precompBaseTable;
        public object precompBase;

        // ── Methods ──
        public void CalculateS(){} // RVA: 0xA67F370
        public void CheckContextVar(){} // RVA: 0xA67F860
        public void CheckPointVar(){} // RVA: 0xA67F880
        public void CheckScalarVar(){} // RVA: 0xA67FA60
        public void CreateDigest(){} // RVA: 0xA67FC60
        public void CreatePrehash(){} // RVA: 0xA67FCE0
        public void Decode24(){} // RVA: 0xA10DF30
        public void Decode32(){} // RVA: 0xA67FD30
        public void DecodePointVar(){} // RVA: 0xA67FE70
        public void DecodeScalar(){} // RVA: 0xA6801E0
        public void Dom2(){} // RVA: 0xA680320
        public void Encode24(){} // RVA: 0xA10E630
        public void Encode32(){} // RVA: 0xA10A740
        public void Encode56(){} // RVA: 0xA680450
        public void EncodePoint(){} // RVA: 0xA680540
        public void GeneratePrivateKey(){} // RVA: 0xA680780
        public void GeneratePublicKey(){} // RVA: 0xA6807B0
        public void GetWnaf(){} // RVA: 0xA680940
        public void ImplSign(){} // RVA: 0xA6810C0
        public void ImplVerify(){} // RVA: 0xA681350
        public void PointAddVar(){} // RVA: 0xA681D40
        public void PointAddPrecomp(){} // RVA: 0xA682380
        public void PointCopy(){} // RVA: 0xA682970
        public void PointDouble(){} // RVA: 0xA682B50
        public void PointExtendXY(){} // RVA: 0xA683080
        public void PointLookup(){} // RVA: 0xA683140
        public void PointPrecompVar(){} // RVA: 0xA683390
        public void PointSetNeutral(){} // RVA: 0xA683770
        public void Precompute(){} // RVA: 0xA6838D0
        public void PruneScalar(){} // RVA: 0xA684770
        public void ReduceScalar(){} // RVA: 0xA6847D0
        public void ScalarMultBase(){} // RVA: 0xA6852C0
        public void ScalarMultBaseEncoded(){} // RVA: 0xA685780
        public void ScalarMultBaseYZ(){} // RVA: 0xA685830
        public void ScalarMultStrausVar(){} // RVA: 0xA685A10
        public void Sign(){} // RVA: 0xA685E50
        public void SignPrehash(){} // RVA: 0xA686280
        public void Verify(){} // RVA: 0xA686500
        public void VerifyPrehash(){} // RVA: 0xA686690
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA686840
    }

    public class Ed448 : Object
    {
        public object M26UL;
        public object M28UL;
        public object PointBytes;
        public object ScalarUints;
        public object ScalarBytes;
        public object PrehashSize;
        public object PublicKeySize;
        public object SecretKeySize;
        public object SignatureSize;
        public object Dom4Prefix;
        public object P;
        public object L;
        public object N;
        public object L_0;
        public object L_1;
        public object L_2;
        public object L_3;
        public object L_4;
        public object L_5;
        public object L_6;
        public object L_7;
        public object L4_0;
        public object L4_1;
        public object L4_2;
        public object L4_3;
        public object L4_4;
        public object L4_5;
        public object L4_6;
        public object L4_7;
        public object B_x;
        public object B_y;
        public object C_d;
        public object WnafWidthBase;
        public object PrecompBlocks;
        public object PrecompTeeth;
        public object PrecompSpacing;
        public object PrecompPoints;
        public object PrecompMask;
        public object precompLock;
        public object precompBaseTable;
        public object precompBase;

        // ── Methods ──
        public void CalculateS(){} // RVA: 0xA687680
        public void CheckContextVar(){} // RVA: 0xA687C40
        public void CheckPointVar(){} // RVA: 0xA687C60
        public void CheckScalarVar(){} // RVA: 0xA687E40
        public void CreatePrehash(){} // RVA: 0xA688060
        public void CreateXof(){} // RVA: 0xA6880B0
        public void Decode16(){} // RVA: 0xA688140
        public void Decode24(){} // RVA: 0xA10DF30
        public void Decode32(){} // RVA: 0xA688180
        public void DecodePointVar(){} // RVA: 0xA6882C0
        public void DecodeScalar(){} // RVA: 0xA6885D0
        public void Dom4(){} // RVA: 0xA688710
        public void Encode24(){} // RVA: 0xA10E630
        public void Encode32(){} // RVA: 0xA10A740
        public void Encode56(){} // RVA: 0xA688840
        public void EncodePoint(){} // RVA: 0xA688930
        public void GeneratePrivateKey(){} // RVA: 0xA680780
        public void GeneratePublicKey(){} // RVA: 0xA688A70
        public void GetWnaf(){} // RVA: 0xA688C10
        public void ImplSign(){} // RVA: 0xA6893A0
        public void ImplVerify(){} // RVA: 0xA689640
        public void PointAddVar(){} // RVA: 0xA689A40
        public void PointAddPrecomp(){} // RVA: 0xA689FB0
        public void PointCopy(){} // RVA: 0xA68A420
        public void PointDouble(){} // RVA: 0xA68A580
        public void PointExtendXY(){} // RVA: 0xA68A8F0
        public void PointLookup(){} // RVA: 0xA68A950
        public void PointPrecompVar(){} // RVA: 0xA68AAF0
        public void PointSetNeutral(){} // RVA: 0xA68ACF0
        public void Precompute(){} // RVA: 0xA68ADC0
        public void PruneScalar(){} // RVA: 0xA68B6A0
        public void ReduceScalar(){} // RVA: 0xA68B700
        public void ScalarMultBase(){} // RVA: 0xA68CD00
        public void ScalarMultBaseEncoded(){} // RVA: 0xA68D1B0
        public void ScalarMultBaseXY(){} // RVA: 0xA68D260
        public void ScalarMultStrausVar(){} // RVA: 0xA68D410
        public void Sign(){} // RVA: 0xA68D6D0
        public void SignPrehash(){} // RVA: 0xA68DB00
        public void Verify(){} // RVA: 0xA68DCD0
        public void VerifyPrehash(){} // RVA: 0xA68DE60
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA68E010
    }

}