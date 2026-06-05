// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 9
// Methods: 73

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class HMAC
    {
        // ── Methods ──
        public void get_BlockSizeValue(){} // RVA: 0x7FFAF2DE8CD0
        public void set_BlockSizeValue(){} // RVA: 0x7FFAF2DE8CE0
        public void UpdateIOPadBuffers(){} // RVA: 0x7FFAF872DDD0
        public void InitializeKey(){} // RVA: 0x7FFAF872DFB0
        public void get_Key(){} // RVA: 0x7FFAF872E270
        public void set_Key(){} // RVA: 0x7FFAF872E2F0
        public void get_HashName(){} // RVA: 0x7FFAF2F476A0
        public void set_HashName(){} // RVA: 0x7FFAF872E370
        public void Create(){} // RVA: 0x7FFAF872E590 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAF872E670
        public void HashCore(){} // RVA: 0x7FFAF872E6D0
        public void HashFinal(){} // RVA: 0x7FFAF872E7E0
        public void Dispose(){} // RVA: 0x7FFAF872EA10
        public void GetHashAlgorithmWithFipsFallback(){} // RVA: 0x7FFAF872EAD0
        public void .ctor(){} // RVA: 0x7FFAF872EB30
    }

    public class HMACMD5
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF872EBA0 | overloaded x2
    }

    public class HMACRIPEMD160
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF872EF80 | overloaded x2
    }

    public class HMACSHA1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF872F1B0 | overloaded x3
    }

    public class HMACSHA256
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF872F3E0 | overloaded x2
    }

    public class HMACSHA384
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF872F610 | overloaded x2
        public void get_BlockSize(){} // RVA: 0x7FFAF872F800
        public void get_ProduceLegacyHmacValues(){} // RVA: 0x7FFAF2E55570
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x7FFAF872F820
    }

    public class HMACSHA512
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF872F8A0 | overloaded x2
        public void get_BlockSize(){} // RVA: 0x7FFAF872F800
        public void get_ProduceLegacyHmacValues(){} // RVA: 0x7FFAF2E55570
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x7FFAF872F820
    }

    public class HashAlgorithm
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void Create(){} // RVA: 0x7FFAF8723600 | overloaded x2
        public void get_HashSize(){} // RVA: 0x7FFAF335BED0
        public void get_Hash(){} // RVA: 0x7FFAF87236F0
        public void ComputeHash(){} // RVA: 0x7FFAF8723C40 | overloaded x3
        public void TryComputeHash(){} // RVA: 0x7FFAF87238D0
        public void CaptureHashCodeAndReinitialize(){} // RVA: 0x7FFAF8723ED0
        public void Dispose(){} // RVA: 0x7FFAF8724080 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAF8724040
        public void get_InputBlockSize(){} // RVA: 0x7FFAF2E7FAF0
        public void get_OutputBlockSize(){} // RVA: 0x7FFAF2E7FAF0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAF2E72850
        public void get_CanReuseTransform(){} // RVA: 0x7FFAF2E72850
        public void TransformBlock(){} // RVA: 0x7FFAF8724090
        public void TransformFinalBlock(){} // RVA: 0x7FFAF8724140
        public void ValidateTransformBlock(){} // RVA: 0x7FFAF8724290
        public void HashCore(){} // RVA: 0x7FFAF8724450 | overloaded x2
        public void HashFinal(){} // RVA: 0x7FFAF2ABCD60
        public void Initialize(){} // RVA: 0x7FFAF2AD4A50
        public void TryHashFinal(){} // RVA: 0x7FFAF8724690
    }

    public class HashAlgorithmName
    {
        // ── Methods ──
        public void get_MD5(){} // RVA: 0x7FFAF8724850
        public void get_SHA1(){} // RVA: 0x7FFAF87248E0
        public void get_SHA256(){} // RVA: 0x7FFAF8724970
        public void get_SHA384(){} // RVA: 0x7FFAF8724A00
        public void get_SHA512(){} // RVA: 0x7FFAF8724A90
        public void .ctor(){} // RVA: 0x7FFAF3ABA2F0
        public void get_Name(){} // RVA: 0x7FFAF4584690
        public void ToString(){} // RVA: 0x7FFAF8724B20
        public void Equals(){} // RVA: 0x7FFAF8724C30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8724C70
        public void op_Equality(){} // RVA: 0x7FFAF86D5A10
        public void op_Inequality(){} // RVA: 0x7FFAF86D5D60
    }

}