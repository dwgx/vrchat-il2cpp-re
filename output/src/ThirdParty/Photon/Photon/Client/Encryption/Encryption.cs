// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.Encryption
// Classes: 4
// Methods: 25

namespace ThirdParty.Photon.Photon.Client.Encryption
{
    public class DiffieHellmanCryptoProvider
    {
        public System.Numerics.BigInteger primeRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x624F930 | overloaded x2
        public void get_PublicKey(){} // RVA: 0x624FA70
        public void DeriveSharedKey(){} // RVA: 0x624FB90
        public void PhotonBigIntArrayToMsBigIntArray(){} // RVA: 0x6250260
        public void MsBigIntArrayToPhotonBigIntArray(){} // RVA: 0x62503A0
        public void Encrypt(){} // RVA: 0x6250640
        public void Decrypt(){} // RVA: 0x6250780
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void CalculatePublicKey(){} // RVA: 0x6250910
        public void CalculateSharedKey(){} // RVA: 0x6250A10
        public void GenerateRandomSecret(){} // RVA: 0x6250AD0
        public void .cctor(){} // RVA: 0x6250EE0
    }

    public class ICryptoProvider
    {
        // ── Methods ──
        public void get_PublicKey(){} // RVA: 0xCD60
        public void DeriveSharedKey(){} // RVA: 0x24B10
        public void Encrypt(){}
        public void Decrypt(){}
    }

    public class IPhotonEncryptor
    {
        // ── Methods ──
        public void set_LogLevel(){} // RVA: 0x24FA0
        public void Init(){}
        public void Encrypt2(){}
        public void Decrypt2(){}
        public void CalculateEncryptedSize(){} // RVA: 0x13FB0
        public void CalculateFragmentLength(){} // RVA: 0xD840
    }

    public class OakleyGroups
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x6250FD0
    }

}