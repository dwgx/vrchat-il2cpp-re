// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.Encryption
// Classes: 4
// Methods: 23

namespace ThirdParty.Photon.Photon.Client.Encryption
{
    public class DiffieHellmanCryptoProvider : Object
    {
        public object primeRoot;
        public object prime;
        public object secret;
        public object publicKey;
        public object crypto;
        public object sharedKey;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CBCC90
        public void get_PublicKey(){} // RVA: 0x6CBCDD0
        public void DeriveSharedKey(){} // RVA: 0x6CBCEF0
        public void PhotonBigIntArrayToMsBigIntArray(){} // RVA: 0x6CBD5C0
        public void MsBigIntArrayToPhotonBigIntArray(){} // RVA: 0x6CBD700
        public void Encrypt(){} // RVA: 0x6CBD9A0
        public void Decrypt(){} // RVA: 0x6CBDAE0
        public void Dispose(){} // RVA: 0xB43310
        public void CalculatePublicKey(){} // RVA: 0x6CBDC70
        public void CalculateSharedKey(){} // RVA: 0x6CBDD70
        public void GenerateRandomSecret(){} // RVA: 0x6CBDE30
        public void .cctor(){} // RVA: 0x6CBE230
    }

    public class ICryptoProvider
    {
        // ── Methods ──
        public void get_PublicKey(){} // RVA: 0x87C0A0
        public void DeriveSharedKey(){} // RVA: 0x894320
        public void Encrypt(){} // RVA: 0x87D1E0
        public void Decrypt(){} // RVA: 0x87D1E0
    }

    public class IPhotonEncryptor
    {
        // ── Methods ──
        public void set_LogLevel(){} // RVA: 0x8944F0
        public void Init(){} // RVA: 0x89EE80
        public void Encrypt2(){} // RVA: 0x89C620
        public void Decrypt2(){} // RVA: 0x88D8F0
        public void CalculateEncryptedSize(){} // RVA: 0x881C20
        public void CalculateFragmentLength(){} // RVA: 0x87C130
    }

    public class OakleyGroups : Object
    {
        public object Generator;
        public object OakleyPrime768;
        public object OakleyPrime1024;
        public object OakleyPrime1536;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6CBE320
    }

}