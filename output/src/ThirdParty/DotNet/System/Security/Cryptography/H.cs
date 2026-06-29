// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 9
// Methods: 59

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class HMAC : KeyedHashAlgorithm
    {
        // ── Methods ──
        public void get_BlockSizeValue(){} // RVA: 0x7A8133100
        public void set_BlockSizeValue(){} // RVA: 0x7A8133110
        public void UpdateIOPadBuffers(){} // RVA: 0x7ADA6BDC0
        public void InitializeKey(){} // RVA: 0x7ADA6BFB0
        public void get_Key(){} // RVA: 0x7ADA6C270
        public void set_Key(){} // RVA: 0x7ADA6C2F0
        public void get_HashName(){} // RVA: 0x7A8292C30
        public void set_HashName(){} // RVA: 0x7ADA6C370
        public void Create(){} // RVA: 0x7ADA6C590
        public void Initialize(){} // RVA: 0x7ADA6C670
        public void HashCore(){} // RVA: 0x7ADA6C6D0
        public void HashFinal(){} // RVA: 0x7ADA6C7E0
        public void Dispose(){} // RVA: 0x7ADA6CA10
        public void GetHashAlgorithmWithFipsFallback(){} // RVA: 0x7ADA6CAD0
        public void .ctor(){} // RVA: 0x7ADA6CB30
    }

    public class HMACMD5 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA6CBA0
    }

    public class HMACRIPEMD160 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA6CF80
    }

    public class HMACSHA1 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA6D1B0
    }

    public class HMACSHA256 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA6D3E0
    }

    public class HMACSHA384 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA6D610
        public void get_BlockSize(){} // RVA: 0x7ADA6D820
        public void get_ProduceLegacyHmacValues(){} // RVA: 0x7A81A00C0
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x7ADA6D840
    }

    public class HMACSHA512 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA6D8C0
        public void get_BlockSize(){} // RVA: 0x7ADA6D820
        public void get_ProduceLegacyHmacValues(){} // RVA: 0x7A81A00C0
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x7ADA6D840
    }

    public class HashAlgorithm : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void Create(){} // RVA: 0x7ADA615F0
        public void get_HashSize(){} // RVA: 0x7A8668BC0
        public void get_Hash(){} // RVA: 0x7ADA616E0
        public void ComputeHash(){} // RVA: 0x7ADA61C30
        public void TryComputeHash(){} // RVA: 0x7ADA618C0
        public void CaptureHashCodeAndReinitialize(){} // RVA: 0x7ADA61EC0
        public void Dispose(){} // RVA: 0x7ADA62070
        public void Clear(){} // RVA: 0x7ADA62030
        public void get_InputBlockSize(){} // RVA: 0x7A81CA9D0
        public void get_OutputBlockSize(){} // RVA: 0x7A81CA9D0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7A81BD750
        public void get_CanReuseTransform(){} // RVA: 0x7A81BD750
        public void TransformBlock(){} // RVA: 0x7ADA62080
        public void TransformFinalBlock(){} // RVA: 0x7ADA62130
        public void ValidateTransformBlock(){} // RVA: 0x7ADA62280
        public void HashCore(){} // RVA: 0x7ADA62440
        public void HashFinal(){} // RVA: 0x7A7E00680
        public void Initialize(){} // RVA: 0x7A7E18770
        public void TryHashFinal(){} // RVA: 0x7ADA62680
    }

    public class HashAlgorithmName : ValueType
    {
        // ── Methods ──
        public void get_MD5(){} // RVA: 0x7ADA62840
        public void get_SHA1(){} // RVA: 0x7ADA628D0
        public void get_SHA256(){} // RVA: 0x7ADA62960
        public void get_SHA384(){} // RVA: 0x7ADA629F0
        public void get_SHA512(){} // RVA: 0x7ADA62A80
        public void .ctor(){} // RVA: 0x7A7637E60
        public void get_Name(){} // RVA: 0x7A765F710
        public void ToString(){} // RVA: 0x7A7E2F910
        public void Equals(){} // RVA: 0x7A7E2FA20
        public void GetHashCode(){} // RVA: 0x7A7E2FA60
        public void op_Equality(){} // RVA: 0x7ADA13920
        public void op_Inequality(){} // RVA: 0x7ADA13C70
    }

}