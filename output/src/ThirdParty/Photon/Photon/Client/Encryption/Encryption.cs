// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.Encryption
// Classes: 2
// Methods: 10

namespace ThirdParty.Photon.Photon.Client.Encryption
{
    public class ICryptoProvider
    {
        public object PublicKey;

        // ── Methods ──
        public void get_PublicKey(){} // RVA: 0x7FFD4E078E90
        public void DeriveSharedKey(){} // RVA: 0x7FFD4E090A40
        public void Encrypt(){}
        public void Decrypt(){}
    }

    public class IPhotonEncryptor
    {
        public object LogLevel;

        // ── Methods ──
        public void set_LogLevel(){} // RVA: 0x7FFD4E090ED0
        public void Init(){}
        public void Encrypt2(){}
        public void Decrypt2(){}
        public void CalculateEncryptedSize(){} // RVA: 0x7FFD4E0800D0
        public void CalculateFragmentLength(){} // RVA: 0x7FFD4E079960
    }

}