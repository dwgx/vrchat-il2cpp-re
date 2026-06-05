// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
// Classes: 4
// Methods: 18

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Agreement.Kdf
{
    public class ConcatenationKdfGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC136F00
        public void Init(){} // RVA: 0x7FFAFC136FB0
        public void get_Digest(){} // RVA: 0x7FFAF2DA8380
        public void GenerateBytes(){} // RVA: 0x7FFAFC137160
    }

    public class DHKdfParameters : .ctor
    {
        public object Digest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF91C4790 | overloaded x2
        public void get_Algorithm(){} // RVA: 0x7FFAF2DA8380
        public void get_KeySize(){} // RVA: 0x7FFAF306ED50
        public void GetZ(){} // RVA: 0x7FFAF2DBB0C0
        public void GetExtraInfo(){} // RVA: 0x7FFAF2DBB130
    }

    public class DHKekGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Init(){} // RVA: 0x7FFAFC137860
        public void get_Digest(){} // RVA: 0x7FFAF2DA8380
        public void GenerateBytes(){} // RVA: 0x7FFAFC137A00
    }

    public class ECDHKekGenerator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC138180
        public void Init(){} // RVA: 0x7FFAFC138280
        public void get_Digest(){} // RVA: 0x7FFAFC1383D0
        public void GenerateBytes(){} // RVA: 0x7FFAFC138420
    }

}