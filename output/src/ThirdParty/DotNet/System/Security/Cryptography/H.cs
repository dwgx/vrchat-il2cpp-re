// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 9
// Methods: 73

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class HMAC : KeyedHashAlgorithm
    {
        public int BlockSizeValue; // 0x30
        public string Key; // 0x38
        public System.Security.Cryptography.HashAlgorithm HashName; // 0x40
        public System.Security.Cryptography.HashAlgorithm m_hash2; // 0x48
        public byte[] m_inner; // 0x50
        public byte[] m_outer; // 0x58
        public bool m_hashing; // 0x60

        // ── Methods ──
        public void get_BlockSizeValue(){} // RVA: 0x7FFAC2F7CCD0
        public void set_BlockSizeValue(){} // RVA: 0x7FFAC2F7CCE0
        public void UpdateIOPadBuffers(){} // RVA: 0x7FFAC8415360
        public void InitializeKey(){} // RVA: 0x7FFAC8415540
        public void get_Key(){} // RVA: 0x7FFAC8415800
        public void set_Key(){} // RVA: 0x7FFAC8415880
        public void get_HashName(){} // RVA: 0x7FFAC31D0140
        public void set_HashName(){} // RVA: 0x7FFAC8415900
        public void Create(){} // RVA: 0x7FFAC8415B20 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC8415C00
        public void HashCore(){} // RVA: 0x7FFAC8415C60
        public void HashFinal(){} // RVA: 0x7FFAC8415D70
        public void Dispose(){} // RVA: 0x7FFAC8415FA0
        public void GetHashAlgorithmWithFipsFallback(){} // RVA: 0x7FFAC8416060
        public void .ctor(){} // RVA: 0x7FFAC84160C0
    }

    public class HMACMD5 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8416130 | overloaded x2
    }

    public class HMACRIPEMD160 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8416510 | overloaded x2
    }

    public class HMACSHA1 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8416740 | overloaded x3
    }

    public class HMACSHA256 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8416970 | overloaded x2
    }

    public class HMACSHA384 : HMAC
    {
        public bool BlockSize; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8416BA0 | overloaded x2
        public void get_BlockSize(){} // RVA: 0x7FFAC8416D90
        public void get_ProduceLegacyHmacValues(){} // RVA: 0x7FFAC2FE9570
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x7FFAC8416DB0
    }

    public class HMACSHA512 : HMAC
    {
        public bool BlockSize; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8416E30 | overloaded x2
        public void get_BlockSize(){} // RVA: 0x7FFAC8416D90
        public void get_ProduceLegacyHmacValues(){} // RVA: 0x7FFAC2FE9570
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x7FFAC8416DB0
    }

    public class HashAlgorithm : Object
    {
        public bool HashSize; // 0x10
        public int Hash; // 0x14
        public byte[] InputBlockSize; // 0x18
        public int OutputBlockSize; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC840AB90 | overloaded x2
        public void get_HashSize(){} // RVA: 0x7FFAC33D5A20
        public void get_Hash(){} // RVA: 0x7FFAC840AC80
        public void ComputeHash(){} // RVA: 0x7FFAC840B1D0 | overloaded x3
        public void TryComputeHash(){} // RVA: 0x7FFAC840AE60
        public void CaptureHashCodeAndReinitialize(){} // RVA: 0x7FFAC840B460
        public void Dispose(){} // RVA: 0x7FFAC840B610 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC840B5D0
        public void get_InputBlockSize(){} // RVA: 0x7FFAC3013AF0
        public void get_OutputBlockSize(){} // RVA: 0x7FFAC3013AF0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0x7FFAC3006850
        public void get_CanReuseTransform(){} // RVA: 0x7FFAC3006850
        public void TransformBlock(){} // RVA: 0x7FFAC840B620
        public void TransformFinalBlock(){} // RVA: 0x7FFAC840B6D0
        public void ValidateTransformBlock(){} // RVA: 0x7FFAC840B820
        public void HashCore(){} // RVA: 0x7FFAC840B9E0 | overloaded x2
        public void HashFinal(){} // RVA: 0x7FFAC2C58E90
        public void Initialize(){} // RVA: 0x7FFAC2C70980
        public void TryHashFinal(){} // RVA: 0x7FFAC840BC20
    }

    public class HashAlgorithmName : ValueType
    {
        public string MD5; // 0x10

        // ── Methods ──
        public void get_MD5(){} // RVA: 0x7FFAC840BDE0
        public void get_SHA1(){} // RVA: 0x7FFAC840BE70
        public void get_SHA256(){} // RVA: 0x7FFAC840BF00
        public void get_SHA384(){} // RVA: 0x7FFAC840BF90
        public void get_SHA512(){} // RVA: 0x7FFAC840C020
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void get_Name(){} // RVA: 0x7FFAC3AD9F60
        public void ToString(){} // RVA: 0x7FFAC840C0B0
        public void Equals(){} // RVA: 0x7FFAC840C1C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC840C200
        public void op_Equality(){} // RVA: 0x7FFAC83BCF60
        public void op_Inequality(){} // RVA: 0x7FFAC83BD2B0
    }

}