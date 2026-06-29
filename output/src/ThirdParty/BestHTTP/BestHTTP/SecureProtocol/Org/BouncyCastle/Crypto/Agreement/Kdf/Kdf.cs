// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
// Classes: 4
// Methods: 17

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
{
    public class ConcatenationKdfGenerator : Object
    {
        public object mDigest;
        public object mShared;
        public object mOtherInfo;
        public object mHLen;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA32B620
        public void Init(){} // RVA: 0xA32B6D0
        public void get_Digest(){} // RVA: 0xB5DBF0
        public void GenerateBytes(){} // RVA: 0xA32B880
    }

    public class DHKdfParameters : Object
    {
        public object algorithm;
        public object keySize;
        public object z;
        public object extraInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x717C740
        public void get_Algorithm(){} // RVA: 0xB5DBF0
        public void get_KeySize(){} // RVA: 0xE62D00
        public void GetZ(){} // RVA: 0xB700F0
        public void GetExtraInfo(){} // RVA: 0xB70160
    }

    public class DHKekGenerator : Object
    {
        public object digest;
        public object algorithm;
        public object keySize;
        public object z;
        public object partyAInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Init(){} // RVA: 0xA32BF80
        public void get_Digest(){} // RVA: 0xB5DBF0
        public void GenerateBytes(){} // RVA: 0xA32C120
    }

    public class ECDHKekGenerator : Object
    {
        public object kdf;
        public object algorithm;
        public object keySize;
        public object z;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA32C8F0
        public void Init(){} // RVA: 0xA32C9F0
        public void get_Digest(){} // RVA: 0xA32CB40
        public void GenerateBytes(){} // RVA: 0xA32CB90
    }

}