// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.Encryption
// Classes: 4
// Methods: 25

namespace ThirdParty.Photon.Photon.Client.Encryption
{
    public class DiffieHellmanCryptoProvider : Object
    {
        public System.Numerics.BigInteger primeRoot;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D90350 | overloaded x2
        public void get_PublicKey(){} // RVA: 0x7FFE86D90490
        public void DeriveSharedKey(){} // RVA: 0x7FFE86D905B0
        public void PhotonBigIntArrayToMsBigIntArray(){} // RVA: 0x7FFE86D90C80
        public void MsBigIntArrayToPhotonBigIntArray(){} // RVA: 0x7FFE86D90DC0
        public void Encrypt(){} // RVA: 0x7FFE86D91060
        public void Decrypt(){} // RVA: 0x7FFE86D911A0
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void CalculatePublicKey(){} // RVA: 0x7FFE86D91330
        public void CalculateSharedKey(){} // RVA: 0x7FFE86D91430
        public void GenerateRandomSecret(){} // RVA: 0x7FFE86D914F0
        public void .cctor(){} // RVA: 0x7FFE86D91900
    }

    public class ICryptoProvider
    {
        // ── Methods ──
        public void get_PublicKey(){} // RVA: 0x7FFE80E2E2E0
        public void DeriveSharedKey(){} // RVA: 0x7FFE80E460A0
        public void Encrypt(){}
        public void Decrypt(){}
    }

    public class IPhotonEncryptor
    {
        // ── Methods ──
        public void set_LogLevel(){} // RVA: 0x7FFE80E46530
        public void Init(){}
        public void Encrypt2(){}
        public void Decrypt2(){}
        public void CalculateEncryptedSize(){} // RVA: 0x7FFE80E35520
        public void CalculateFragmentLength(){} // RVA: 0x7FFE80E2EDB0
    }

    public class OakleyGroups : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE86D919F0
    }

}