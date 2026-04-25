// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Rfc8032
// Classes: 2
// Methods: 106

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC.Rfc8032
{
    public class Ed25519 : Object
    {
        public long M28L;
        public long M32L;
        public int PointBytes;
        public int ScalarUints;
        public int ScalarBytes;
        public int PrehashSize;
        public int PublicKeySize; // 0x4
        public int SecretKeySize; // 0x8
        public int SignatureSize; // 0xC
        public byte[] Dom2Prefix; // 0x10
        public uint[] P; // 0x18
        public uint[] L; // 0x20
        public int L0;
        public int L1;
        public int L2;
        public int L3;
        public int L4;
        public int[] B_x; // 0x28
        public int[] B_y; // 0x30
        public int[] C_d; // 0x38
        public int[] C_d2; // 0x40
        public int[] C_d4; // 0x48
        public int WnafWidthBase;
        public int PrecompBlocks;
        public int PrecompTeeth;
        public int PrecompSpacing;
        public int PrecompPoints;
        public int PrecompMask;
        public object precompLock; // 0x50
        public PointExt[] precompBaseTable; // 0x58
        public int[] precompBase; // 0x60

        // ── Methods ──
        public void CalculateS(){} // RVA: 0x7FFACBFCFEA0
        public void CheckContextVar(){} // RVA: 0x7FFACBFD0390
        public void CheckPointVar(){} // RVA: 0x7FFACBFD03B0
        public void CheckScalarVar(){} // RVA: 0x7FFACBFD0570
        public void CreateDigest(){} // RVA: 0x7FFACBFD0750
        public void CreatePrehash(){} // RVA: 0x7FFACBFD07D0
        public void Decode24(){} // RVA: 0x7FFACBA77520
        public void Decode32(){} // RVA: 0x7FFACBFD0820 | overloaded x2
        public void DecodePointVar(){} // RVA: 0x7FFACBFD0940
        public void DecodeScalar(){} // RVA: 0x7FFACBFD0CA0
        public void Dom2(){} // RVA: 0x7FFACBFD0DE0
        public void Encode24(){} // RVA: 0x7FFACBA77C20
        public void Encode32(){} // RVA: 0x7FFACBA73D00
        public void Encode56(){} // RVA: 0x7FFACBFD0F10
        public void EncodePoint(){} // RVA: 0x7FFACBFD1000
        public void GeneratePrivateKey(){} // RVA: 0x7FFACBFD1240
        public void GeneratePublicKey(){} // RVA: 0x7FFACBFD1270
        public void GetWnaf(){} // RVA: 0x7FFACBFD1400
        public void ImplSign(){} // RVA: 0x7FFACBFD1B30 | overloaded x3
        public void ImplVerify(){} // RVA: 0x7FFACBFD1DC0
        public void PointAddVar(){} // RVA: 0x7FFACBFD2750 | overloaded x2
        public void PointAddPrecomp(){} // RVA: 0x7FFACBFD2D30
        public void PointCopy(){} // RVA: 0x7FFACBFD3280 | overloaded x2
        public void PointDouble(){} // RVA: 0x7FFACBFD3450
        public void PointExtendXY(){} // RVA: 0x7FFACBFD3930 | overloaded x2
        public void PointLookup(){} // RVA: 0x7FFACBFD39D0
        public void PointPrecompVar(){} // RVA: 0x7FFACBFD3C00
        public void PointSetNeutral(){} // RVA: 0x7FFACBFD4140 | overloaded x2
        public void Precompute(){} // RVA: 0x7FFACBFD4260
        public void PruneScalar(){} // RVA: 0x7FFACBFD5120
        public void ReduceScalar(){} // RVA: 0x7FFACBFD5180
        public void ScalarMultBase(){} // RVA: 0x7FFACBFD5C70
        public void ScalarMultBaseEncoded(){} // RVA: 0x7FFACBFD6140
        public void ScalarMultBaseYZ(){} // RVA: 0x7FFACBFD61F0
        public void ScalarMultStrausVar(){} // RVA: 0x7FFACBFD63B0
        public void Sign(){} // RVA: 0x7FFACBFD67F0 | overloaded x4
        public void SignPrehash(){} // RVA: 0x7FFACBFD6C20 | overloaded x4
        public void Verify(){} // RVA: 0x7FFACBFD6EA0 | overloaded x2
        public void VerifyPrehash(){} // RVA: 0x7FFACBFD7030 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBFD71E0
    }

    public class Ed448 : Object
    {
        public ulong M26UL;
        public ulong M28UL;
        public int PointBytes;
        public int ScalarUints;
        public int ScalarBytes;
        public int PrehashSize;
        public int PublicKeySize; // 0x4
        public int SecretKeySize; // 0x8
        public int SignatureSize; // 0xC
        public byte[] Dom4Prefix; // 0x10
        public uint[] P; // 0x18
        public uint[] L; // 0x20
        public BestHTTP.SecureProtocol.Org.BouncyCastle.Math.BigInteger N; // 0x28
        public int L_0;
        public int L_1;
        public int L_2;
        public int L_3;
        public int L_4;
        public int L_5;
        public int L_6;
        public int L_7;
        public int L4_0;
        public int L4_1;
        public int L4_2;
        public int L4_3;
        public int L4_4;
        public int L4_5;
        public int L4_6;
        public int L4_7;
        public uint[] B_x; // 0x30
        public uint[] B_y; // 0x38
        public int C_d;
        public int WnafWidthBase;
        public int PrecompBlocks;
        public int PrecompTeeth;
        public int PrecompSpacing;
        public int PrecompPoints;
        public int PrecompMask;
        public object precompLock; // 0x40
        public PointExt[] precompBaseTable; // 0x48
        public uint[] precompBase; // 0x50

        // ── Methods ──
        public void CalculateS(){} // RVA: 0x7FFACBFD8020
        public void CheckContextVar(){} // RVA: 0x7FFACBFD85C0
        public void CheckPointVar(){} // RVA: 0x7FFACBFD85E0
        public void CheckScalarVar(){} // RVA: 0x7FFACBFD87B0
        public void CreatePrehash(){} // RVA: 0x7FFACBFD89B0
        public void CreateXof(){} // RVA: 0x7FFACBFD8A00
        public void Decode16(){} // RVA: 0x7FFACBFD8A90
        public void Decode24(){} // RVA: 0x7FFACBA77520
        public void Decode32(){} // RVA: 0x7FFACBFD8AD0 | overloaded x2
        public void DecodePointVar(){} // RVA: 0x7FFACBFD8BF0
        public void DecodeScalar(){} // RVA: 0x7FFACBFD8EE0
        public void Dom4(){} // RVA: 0x7FFACBFD9020
        public void Encode24(){} // RVA: 0x7FFACBA77C20
        public void Encode32(){} // RVA: 0x7FFACBA73D00
        public void Encode56(){} // RVA: 0x7FFACBFD9150
        public void EncodePoint(){} // RVA: 0x7FFACBFD9240
        public void GeneratePrivateKey(){} // RVA: 0x7FFACBFD1240
        public void GeneratePublicKey(){} // RVA: 0x7FFACBFD9380
        public void GetWnaf(){} // RVA: 0x7FFACBFD9520
        public void ImplSign(){} // RVA: 0x7FFACBFD9C60 | overloaded x3
        public void ImplVerify(){} // RVA: 0x7FFACBFD9F00
        public void PointAddVar(){} // RVA: 0x7FFACBFDA300
        public void PointAddPrecomp(){} // RVA: 0x7FFACBFDA850
        public void PointCopy(){} // RVA: 0x7FFACBFDACB0
        public void PointDouble(){} // RVA: 0x7FFACBFDADF0
        public void PointExtendXY(){} // RVA: 0x7FFACBFDB130
        public void PointLookup(){} // RVA: 0x7FFACBFDB180
        public void PointPrecompVar(){} // RVA: 0x7FFACBFDB300
        public void PointSetNeutral(){} // RVA: 0x7FFACBFDB500
        public void Precompute(){} // RVA: 0x7FFACBFDB5A0
        public void PruneScalar(){} // RVA: 0x7FFACBFDBE80
        public void ReduceScalar(){} // RVA: 0x7FFACBFDBEE0
        public void ScalarMultBase(){} // RVA: 0x7FFACBFDD500
        public void ScalarMultBaseEncoded(){} // RVA: 0x7FFACBFDD9B0
        public void ScalarMultBaseXY(){} // RVA: 0x7FFACBFDDA60
        public void ScalarMultStrausVar(){} // RVA: 0x7FFACBFDDBF0
        public void Sign(){} // RVA: 0x7FFACBFDDEB0 | overloaded x2
        public void SignPrehash(){} // RVA: 0x7FFACBFDE2E0 | overloaded x4
        public void Verify(){} // RVA: 0x7FFACBFDE4A0
        public void VerifyPrehash(){} // RVA: 0x7FFACBFDE630 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBFDE7E0
    }

}