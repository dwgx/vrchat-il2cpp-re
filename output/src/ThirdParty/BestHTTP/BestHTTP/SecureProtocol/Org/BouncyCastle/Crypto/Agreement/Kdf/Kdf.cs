// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
// Classes: 4
// Methods: 18

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
{
    public class ConcatenationKdfGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9686F00
        public void Init(){} // RVA: 0x9686FB0
        public void get_Digest(){} // RVA: 0x2F8380
        public void GenerateBytes(){} // RVA: 0x9687160
    }

    public class DHKdfParameters : .ctor
    {
        public object Digest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6714790 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x2F8380
        public void get_KeySize(){} // RVA: 0x5BED50
        public void GetZ(){} // RVA: 0x30B0C0
        public void GetExtraInfo(){} // RVA: 0x30B130
    }

    public class DHKekGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Init(){} // RVA: 0x9687860
        public void get_Digest(){} // RVA: 0x2F8380
        public void GenerateBytes(){} // RVA: 0x9687A00
    }

    public class ECDHKekGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9688180
        public void Init(){} // RVA: 0x9688280
        public void get_Digest(){} // RVA: 0x96883D0
        public void GenerateBytes(){} // RVA: 0x9688420
    }

}