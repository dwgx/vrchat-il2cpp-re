// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.Encryption
// Classes: 4
// Methods: 25

namespace ThirdParty.Photon.Photon.Client.Encryption
{
    public class DiffieHellmanCryptoProvider : Object
    {
        public System.Numerics.BigInteger PublicKey;
        public System.Numerics.BigInteger prime; // 0x10
        public System.Numerics.BigInteger secret; // 0x20
        public System.Numerics.BigInteger publicKey; // 0x30
        public System.Security.Cryptography.Rijndael crypto; // 0x40
        public byte[] sharedKey; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89E6CD0 | overloaded x2
        public void get_PublicKey(){} // RVA: 0x7FFAC89E6E10
        public void DeriveSharedKey(){} // RVA: 0x7FFAC89E6F30
        public void PhotonBigIntArrayToMsBigIntArray(){} // RVA: 0x7FFAC89E7600
        public void MsBigIntArrayToPhotonBigIntArray(){} // RVA: 0x7FFAC89E7740
        public void Encrypt(){} // RVA: 0x7FFAC89E79E0
        public void Decrypt(){} // RVA: 0x7FFAC89E7B20
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void CalculatePublicKey(){} // RVA: 0x7FFAC89E7CB0
        public void CalculateSharedKey(){} // RVA: 0x7FFAC89E7DB0
        public void GenerateRandomSecret(){} // RVA: 0x7FFAC89E7E70
        public void .cctor(){} // RVA: 0x7FFAC89E8280
    }

    public class ICryptoProvider
    {
        public object PublicKey;

        // ── Methods ──
        public void get_PublicKey(){} // RVA: 0x7FFAC2C58E90
        public void DeriveSharedKey(){} // RVA: 0x7FFAC2C70A40
        public void Encrypt(){}
        public void Decrypt(){}
    }

    public class IPhotonEncryptor
    {
        public object LogLevel;

        // ── Methods ──
        public void set_LogLevel(){} // RVA: 0x7FFAC2C70ED0
        public void Init(){}
        public void Encrypt2(){}
        public void Decrypt2(){}
        public void CalculateEncryptedSize(){} // RVA: 0x7FFAC2C600D0
        public void CalculateFragmentLength(){} // RVA: 0x7FFAC2C59960
    }

    public class OakleyGroups : Object
    {
        public int Generator;
        public byte[] OakleyPrime768; // 0x8
        public byte[] OakleyPrime1024; // 0x10
        public byte[] OakleyPrime1536; // 0x18

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC89E8370
    }

}