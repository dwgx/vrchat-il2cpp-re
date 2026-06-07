// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 9
// Methods: 73

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class HMAC
    {
        // ── Methods ──
        public void get_BlockSizeValue(){} // RVA: 0x338CD0
        public void set_BlockSizeValue(){} // RVA: 0x338CE0
        public void UpdateIOPadBuffers(){} // RVA: 0x5C7DDD0
        public void InitializeKey(){} // RVA: 0x5C7DFB0
        public void get_Key(){} // RVA: 0x5C7E270
        public void set_Key(){} // RVA: 0x5C7E2F0
        public void get_HashName(){} // RVA: 0x4976A0
        public void set_HashName(){} // RVA: 0x5C7E370
        public void Create(){} // RVA: 0x5C7E590 | overloaded x2
        public void Initialize(){} // RVA: 0x5C7E670
        public void HashCore(){} // RVA: 0x5C7E6D0
        public void HashFinal(){} // RVA: 0x5C7E7E0
        public void Dispose(){} // RVA: 0x5C7EA10
        public void GetHashAlgorithmWithFipsFallback(){} // RVA: 0x5C7EAD0
        public void .ctor(){} // RVA: 0x5C7EB30
    }

    public class HMACMD5
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C7EBA0 | overloaded x2
    }

    public class HMACRIPEMD160
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C7EF80 | overloaded x2
    }

    public class HMACSHA1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C7F1B0 | overloaded x3
    }

    public class HMACSHA256
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C7F3E0 | overloaded x2
    }

    public class HMACSHA384
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C7F610 | overloaded x2
        public void get_BlockSize(){} // RVA: 0x5C7F800
        public void get_ProduceLegacyHmacValues(){} // RVA: 0x3A5570
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x5C7F820
    }

    public class HMACSHA512
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C7F8A0 | overloaded x2
        public void get_BlockSize(){} // RVA: 0x5C7F800
        public void get_ProduceLegacyHmacValues(){} // RVA: 0x3A5570
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x5C7F820
    }

    public class HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x5C73600 | overloaded x2
        public void get_HashSize(){} // RVA: 0x8ABED0
        public void get_Hash(){} // RVA: 0x5C736F0
        public void ComputeHash(){} // RVA: 0x5C73C40 | overloaded x3
        public void TryComputeHash(){} // RVA: 0x5C738D0
        public void CaptureHashCodeAndReinitialize(){} // RVA: 0x5C73ED0
        public void Dispose(){} // RVA: 0x5C74080 | overloaded x2
        public void Clear(){} // RVA: 0x5C74040
        public void get_InputBlockSize(){} // RVA: 0x3CFAF0
        public void get_OutputBlockSize(){} // RVA: 0x3CFAF0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x3C2850
        public void get_CanReuseTransform(){} // RVA: 0x3C2850
        public void TransformBlock(){} // RVA: 0x5C74090
        public void TransformFinalBlock(){} // RVA: 0x5C74140
        public void ValidateTransformBlock(){} // RVA: 0x5C74290
        public void HashCore(){} // RVA: 0x5C74450 | overloaded x2
        public void HashFinal(){} // RVA: 0xCD60
        public void Initialize(){} // RVA: 0x24A50
        public void TryHashFinal(){} // RVA: 0x5C74690
    }

    public class HashAlgorithmName
    {
        // ── Methods ──
        public void get_MD5(){} // RVA: 0x5C74850
        public void get_SHA1(){} // RVA: 0x5C748E0
        public void get_SHA256(){} // RVA: 0x5C74970
        public void get_SHA384(){} // RVA: 0x5C74A00
        public void get_SHA512(){} // RVA: 0x5C74A90
        public void .ctor(){} // RVA: 0x100A2F0
        public void get_Name(){} // RVA: 0x1AD4690
        public void ToString(){} // RVA: 0x5C74B20
        public void Equals(){} // RVA: 0x5C74C30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x5C74C70
        public void op_Equality(){} // RVA: 0x5C25A10
        public void op_Inequality(){} // RVA: 0x5C25D60
    }

}