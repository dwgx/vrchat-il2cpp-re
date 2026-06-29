// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.Encryption
// Classes: 4
// Methods: 23

namespace ThirdParty.Photon.Photon.Client.Encryption
{
    public class DiffieHellmanCryptoProvider : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE03B860
        public void get_PublicKey(){} // RVA: 0x7AE03B9A0
        public void DeriveSharedKey(){} // RVA: 0x7AE03BAC0
        public void PhotonBigIntArrayToMsBigIntArray(){} // RVA: 0x7AE03C190
        public void MsBigIntArrayToPhotonBigIntArray(){} // RVA: 0x7AE03C2D0
        public void Encrypt(){} // RVA: 0x7AE03C570
        public void Decrypt(){} // RVA: 0x7AE03C6B0
        public void Dispose(){} // RVA: 0x7A80D7310
        public void CalculatePublicKey(){} // RVA: 0x7AE03C840
        public void CalculateSharedKey(){} // RVA: 0x7AE03C940
        public void GenerateRandomSecret(){} // RVA: 0x7AE03CA00
        public void .cctor(){} // RVA: 0x7AE03CE10
    }

    public class ICryptoProvider
    {
        // ── Methods ──
        public void get_PublicKey(){} // RVA: 0x7A7E00680
        public void DeriveSharedKey(){} // RVA: 0x7A7E18800
        public void Encrypt(){} // RVA: 0x7A7E017C0
        public void Decrypt(){} // RVA: 0x7A7E017C0
    }

    public class IPhotonEncryptor
    {
        // ── Methods ──
        public void set_LogLevel(){} // RVA: 0x7A7E189D0
        public void Init(){} // RVA: 0x7A7E23210
        public void Encrypt2(){} // RVA: 0x7A7E208A0
        public void Decrypt2(){} // RVA: 0x7A7E11E60
        public void CalculateEncryptedSize(){} // RVA: 0x7A7E062A0
        public void CalculateFragmentLength(){} // RVA: 0x7A7E00710
    }

    public class OakleyGroups : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE03CF00
    }

}