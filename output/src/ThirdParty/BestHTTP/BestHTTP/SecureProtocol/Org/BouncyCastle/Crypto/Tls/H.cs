// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
// Classes: 6
// Methods: 17

namespace ThirdParty.BestHTTP.BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
    public class HandshakeType : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HashAlgorithm : Object
    {
        // ── Methods ──
        public void GetName(){} // RVA: 0x7FFE89F90330
        public void GetText(){} // RVA: 0x7FFE89F90480
        public void IsPrivate(){} // RVA: 0x7FFE89F90610
        public void IsRecognized(){} // RVA: 0x7FFE89F90620
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HeartbeatExtension : Object
    {
        public byte mMode; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F90630
        public void get_Mode(){} // RVA: 0x7FFE811C55E0
        public void Encode(){} // RVA: 0x7FFE89F906C0
        public void Parse(){} // RVA: 0x7FFE89F90740
    }

    public class HeartbeatMessage : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89F90850
        public void Encode(){} // RVA: 0x7FFE89F909C0
        public void Parse(){} // RVA: 0x7FFE89F90B90
    }

    public class HeartbeatMessageType : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE89F90200
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HeartbeatMode : Object
    {
        // ── Methods ──
        public void IsValid(){} // RVA: 0x7FFE89F90200
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}