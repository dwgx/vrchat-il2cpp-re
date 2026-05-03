// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 9
// Methods: 73

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class HMAC : KeyedHashAlgorithm
    {
        public int blockSizeValue; // 0x30
        public string m_hashName; // 0x38
        public System.Security.Cryptography.HashAlgorithm m_hash1; // 0x40

        // ── Methods ──
        public void get_BlockSizeValue(){} // RVA: 0x7FFE81156CD0
        public void set_BlockSizeValue(){} // RVA: 0x7FFE81156CE0
        public void UpdateIOPadBuffers(){} // RVA: 0x7FFE867BEC70
        public void InitializeKey(){} // RVA: 0x7FFE867BEE50
        public void get_Key(){} // RVA: 0x7FFE867BF110
        public void set_Key(){} // RVA: 0x7FFE867BF190
        public void get_HashName(){} // RVA: 0x7FFE8143BA80
        public void set_HashName(){} // RVA: 0x7FFE867BF210
        public void Create(){} // RVA: 0x7FFE867BF430 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFE867BF510
        public void HashCore(){} // RVA: 0x7FFE867BF570
        public void HashFinal(){} // RVA: 0x7FFE867BF680
        public void Dispose(){} // RVA: 0x7FFE867BF8B0
        public void GetHashAlgorithmWithFipsFallback(){} // RVA: 0x7FFE867BF970
        public void .ctor(){} // RVA: 0x7FFE867BF9D0
    }

    public class HMACMD5 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867BFA40 | overloaded x2
    }

    public class HMACRIPEMD160 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867BFE20 | overloaded x2
    }

    public class HMACSHA1 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C0050 | overloaded x3
    }

    public class HMACSHA256 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C0280 | overloaded x2
    }

    public class HMACSHA384 : HMAC
    {
        public bool m_useLegacyBlockSize; // 0x68
        public object field_1; // 0x2F9

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C04B0 | overloaded x2
        public void get_BlockSize(){} // RVA: 0x7FFE867C06A0
        public void get_ProduceLegacyHmacValues(){} // RVA: 0x7FFE811C3570
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x7FFE867C06C0
    }

    public class HMACSHA512 : HMAC
    {
        public bool m_useLegacyBlockSize; // 0x68
        public object field_1; // 0x2FB

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867C0740 | overloaded x2
        public void get_BlockSize(){} // RVA: 0x7FFE867C06A0
        public void get_ProduceLegacyHmacValues(){} // RVA: 0x7FFE811C3570
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x7FFE867C06C0
    }

    public class HashAlgorithm : Object
    {
        public bool _disposed; // 0x10
        public int HashSizeValue; // 0x14
        public byte[] HashValue; // 0x18
        public int State; // 0x20
        public object field_4; // 0x2CA
        public object field_5; // 0x2CB

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE867B44A0 | overloaded x2
        public void get_HashSize(){} // RVA: 0x7FFE8164B230
        public void get_Hash(){} // RVA: 0x7FFE867B4590
        public void ComputeHash(){} // RVA: 0x7FFE867B4AE0 | overloaded x3
        public void TryComputeHash(){} // RVA: 0x7FFE867B4770
        public void CaptureHashCodeAndReinitialize(){} // RVA: 0x7FFE867B4D70
        public void Dispose(){} // RVA: 0x7FFE867B4F20 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE867B4EE0
        public void get_InputBlockSize(){} // RVA: 0x7FFE811EDAF0
        public void get_OutputBlockSize(){} // RVA: 0x7FFE811EDAF0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFE811E0850
        public void get_CanReuseTransform(){} // RVA: 0x7FFE811E0850
        public void TransformBlock(){} // RVA: 0x7FFE867B4F30
        public void TransformFinalBlock(){} // RVA: 0x7FFE867B4FE0
        public void ValidateTransformBlock(){} // RVA: 0x7FFE867B5130
        public void HashCore(){} // RVA: 0x7FFE867B52F0 | overloaded x2
        public void HashFinal(){} // RVA: 0x7FFE80E2E2E0
        public void Initialize(){} // RVA: 0x7FFE80E45FE0
        public void TryHashFinal(){} // RVA: 0x7FFE867B5530
    }

    public class HashAlgorithmName : ValueType
    {
        public string _name; // 0x10
        public object field_1; // 0x2BF
        public object field_2; // 0x2C0
        public object field_3; // 0x2C1
        public object field_4; // 0xBD4D
        public object field_5; // 0x9060

        // ── Methods ──
        public void get_MD5(){} // RVA: 0x7FFE867B56F0
        public void get_SHA1(){} // RVA: 0x7FFE867B5780
        public void get_SHA256(){} // RVA: 0x7FFE867B5810
        public void get_SHA384(){} // RVA: 0x7FFE867B58A0
        public void get_SHA512(){} // RVA: 0x7FFE867B5930
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void get_Name(){} // RVA: 0x7FFE8284EF60
        public void ToString(){} // RVA: 0x7FFE867B59C0
        public void Equals(){} // RVA: 0x7FFE867B5AD0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE867B5B10
        public void op_Equality(){} // RVA: 0x7FFE86766860
        public void op_Inequality(){} // RVA: 0x7FFE86766BB0
    }

}