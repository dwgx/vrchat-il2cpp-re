// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Photon.Photon.Client.Encryption
// Classes: 4
// Methods: 25

namespace ThirdParty.Photon.Photon.Client.Encryption
{
    public class DiffieHellmanCryptoProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CFF930 | overloaded x2
        public void get_PublicKey(){} // RVA: 0x7FFAF8CFFA70
        public void DeriveSharedKey(){} // RVA: 0x7FFAF8CFFB90
        public void PhotonBigIntArrayToMsBigIntArray(){} // RVA: 0x7FFAF8D00260
        public void MsBigIntArrayToPhotonBigIntArray(){} // RVA: 0x7FFAF8D003A0
        public void Encrypt(){} // RVA: 0x7FFAF8D00640
        public void Decrypt(){} // RVA: 0x7FFAF8D00780
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void CalculatePublicKey(){} // RVA: 0x7FFAF8D00910
        public void CalculateSharedKey(){} // RVA: 0x7FFAF8D00A10
        public void GenerateRandomSecret(){} // RVA: 0x7FFAF8D00AD0
        public void .cctor(){} // RVA: 0x7FFAF8D00EE0
    }

    public class ICryptoProvider
    {
        // ── Methods ──
        public void get_PublicKey(){} // RVA: 0x7FFAF2ABCD60
        public void DeriveSharedKey(){} // RVA: 0x7FFAF2AD4B10
        public void Encrypt(){}
        public void Decrypt(){}
    }

    public class IPhotonEncryptor
    {
        // ── Methods ──
        public void set_LogLevel(){} // RVA: 0x7FFAF2AD4FA0
        public void Init(){}
        public void Encrypt2(){}
        public void Decrypt2(){}
        public void CalculateEncryptedSize(){} // RVA: 0x7FFAF2AC3FB0
        public void CalculateFragmentLength(){} // RVA: 0x7FFAF2ABD840
    }

    public class OakleyGroups
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8D00FD0
    }

}