// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Security.Cryptography
// Classes: 9
// Methods: 59

namespace ThirdParty.DotNet.System.Security.Cryptography
{
    public class HMAC : KeyedHashAlgorithm
    {
        public object blockSizeValue;
        public object m_hashName;
        public object m_hash1;
        public object m_hash2;
        public object m_inner;
        public object m_outer;
        public object m_hashing;

        // ── Methods ──
        public void get_BlockSizeValue(){} // RVA: 0xB9E080
        public void set_BlockSizeValue(){} // RVA: 0xB9E090
        public void UpdateIOPadBuffers(){} // RVA: 0x66F6400
        public void InitializeKey(){} // RVA: 0x66F65F0
        public void get_Key(){} // RVA: 0x66F68B0
        public void set_Key(){} // RVA: 0x66F6930
        public void get_HashName(){} // RVA: 0xD05CA0
        public void set_HashName(){} // RVA: 0x66F69B0
        public void Create(){} // RVA: 0x66F6BD0
        public void Initialize(){} // RVA: 0x66F6CB0
        public void HashCore(){} // RVA: 0x66F6D10
        public void HashFinal(){} // RVA: 0x66F6E20
        public void Dispose(){} // RVA: 0x66F7050
        public void GetHashAlgorithmWithFipsFallback(){} // RVA: 0x66F7110
        public void .ctor(){} // RVA: 0x66F7170
    }

    public class HMACMD5 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F71E0
    }

    public class HMACRIPEMD160 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F75C0
    }

    public class HMACSHA1 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F77F0
    }

    public class HMACSHA256 : HMAC
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F7A20
    }

    public class HMACSHA384 : HMAC
    {
        public object m_useLegacyBlockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F7C50
        public void get_BlockSize(){} // RVA: 0x66F7E60
        public void get_ProduceLegacyHmacValues(){} // RVA: 0xC10030
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x66F7E80
    }

    public class HMACSHA512 : HMAC
    {
        public object m_useLegacyBlockSize;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x66F7F00
        public void get_BlockSize(){} // RVA: 0x66F7E60
        public void get_ProduceLegacyHmacValues(){} // RVA: 0xC10030
        public void set_ProduceLegacyHmacValues(){} // RVA: 0x66F7E80
    }

    public class HashAlgorithm : Object
    {
        public object _disposed;
        public object HashSizeValue;
        public object HashValue;
        public object State;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void Create(){} // RVA: 0x66EBC00
        public void get_HashSize(){} // RVA: 0x116A650
        public void get_Hash(){} // RVA: 0x66EBCF0
        public void ComputeHash(){} // RVA: 0x66EC240
        public void TryComputeHash(){} // RVA: 0x66EBED0
        public void CaptureHashCodeAndReinitialize(){} // RVA: 0x66EC4D0
        public void Dispose(){} // RVA: 0x66EC680
        public void Clear(){} // RVA: 0x66EC640
        public void get_InputBlockSize(){} // RVA: 0xC3CCE0
        public void get_OutputBlockSize(){} // RVA: 0xC3CCE0
        public void get_CanTransformMultipleBlocks(){} // RVA: 0xC2E4C0
        public void get_CanReuseTransform(){} // RVA: 0xC2E4C0
        public void TransformBlock(){} // RVA: 0x66EC690
        public void TransformFinalBlock(){} // RVA: 0x66EC740
        public void ValidateTransformBlock(){} // RVA: 0x66EC890
        public void HashCore(){} // RVA: 0x66ECA50
        public void HashFinal(){} // RVA: 0x87C0A0
        public void Initialize(){} // RVA: 0x894290
        public void TryHashFinal(){} // RVA: 0x66ECC90
    }

    public class HashAlgorithmName : ValueType
    {
        public object _name;

        // ── Methods ──
        public void get_MD5(){} // RVA: 0x66ECE50
        public void get_SHA1(){} // RVA: 0x66ECEE0
        public void get_SHA256(){} // RVA: 0x66ECF70
        public void get_SHA384(){} // RVA: 0x66ED000
        public void get_SHA512(){} // RVA: 0x66ED090
        public void .ctor(){} // RVA: 0x47F10
        public void get_Name(){} // RVA: 0x77900
        public void ToString(){} // RVA: 0x8AC510
        public void Equals(){} // RVA: 0x8AC5F0
        public void GetHashCode(){} // RVA: 0x8AC630
        public void op_Equality(){} // RVA: 0x669E2F0
        public void op_Inequality(){} // RVA: 0x669E640
    }

}