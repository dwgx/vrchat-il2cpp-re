// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
// Classes: 7
// Methods: 55

namespace ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
{
    public class ChallengeResponse
    {
        public byte[] magic;
        public byte[] nullEncMagic; // 0x8
        public bool _disposed; // 0x10
        public byte[] _challenge; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD2A60 | overloaded x2
        public void Finalize(){} // RVA: 0x5BD2D30
        public void set_Password(){} // RVA: 0x5BD2E30
        public void set_Challenge(){} // RVA: 0x5BD36D0
        public void get_LM(){} // RVA: 0x5BD3870
        public void get_NT(){} // RVA: 0x5BD38E0
        public void Dispose(){} // RVA: 0x5BD3A10 | overloaded x2
        public void GetResponse(){} // RVA: 0x5BD3A90
        public void PrepareDESKey(){} // RVA: 0x5BD3D20
        public void PasswordToKey(){} // RVA: 0x5BD3F20
        public void .cctor(){} // RVA: 0x5BD4140
    }

    public class ChallengeResponse2
    {
        // ── Methods ──
        public void Compute_LM(){} // RVA: 0x5BD42E0
        public void Compute_NTLM_Password(){} // RVA: 0x5BD4880
        public void Compute_NTLM(){} // RVA: 0x5BD4BA0
        public void Compute_NTLMv2_Session(){} // RVA: 0x5BD4C10
        public void Compute_NTLMv2(){} // RVA: 0x5BD5090
        public void Compute(){} // RVA: 0x5BD5910
        public void GetResponse(){} // RVA: 0x5BD5C60
        public void PrepareDESKey(){} // RVA: 0x5BD5F00
        public void PasswordToKey(){} // RVA: 0x5BD6100
        public void .cctor(){} // RVA: 0x5BD6330
    }

    public class MessageBase
    {
        public byte[] header;
        public int _type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void get_Flags(){} // RVA: 0x8ABED0
        public void set_Flags(){} // RVA: 0x8AC660
        public void get_Type(){} // RVA: 0x32A5C0
        public void PrepareMessage(){} // RVA: 0x5BD6590
        public void Decode(){} // RVA: 0x5BD67A0
        public void CheckHeader(){} // RVA: 0x5BD6A70
        public void GetBytes(){} // RVA: 0xCD60
        public void .cctor(){} // RVA: 0x5BD6BA0
    }

    public class NtlmSettings
    {
        public 0x659A5D48 Domain;

        // ── Methods ──
        public void get_DefaultAuthLevel(){} // RVA: 0x5BD6C80
        public void .cctor(){} // RVA: 0x5BD6CE0
    }

    public class Type1Message
    {
        public string _host; // 0x18
        public string _domain; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD6D20
        public void set_Domain(){} // RVA: 0x5BD6E30
        public void set_Host(){} // RVA: 0x5BD6F30
        public void Decode(){} // RVA: 0x5BD7030
        public void GetBytes(){} // RVA: 0x5BD7260
    }

    public class Type2Message
    {
        public byte[] _nonce; // 0x18
        public string _targetName; // 0x20
        public byte[] _targetInfo; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD76B0
        public void Finalize(){} // RVA: 0x5BD77A0
        public void get_Nonce(){} // RVA: 0x5BD7800
        public void get_TargetName(){} // RVA: 0x30B0C0
        public void get_TargetInfo(){} // RVA: 0x5BD7880
        public void Decode(){} // RVA: 0x5BD7900
        public void GetBytes(){} // RVA: 0x5BD7D20
    }

    public class Type3Message
    {
        public 0x659A5D48 _level; // 0x18
        public byte[] _challenge; // 0x20
        public string _host; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5BD7DF0
        public void Finalize(){} // RVA: 0x5BD8180
        public void set_Domain(){} // RVA: 0x5BD8220
        public void set_Password(){} // RVA: 0x305200
        public void set_Username(){} // RVA: 0x49B830
        public void Decode(){} // RVA: 0x5BD8320
        public void DecodeString(){} // RVA: 0x5BD8890
        public void EncodeString(){} // RVA: 0x5BD8900
        public void GetBytes(){} // RVA: 0x5BD89A0
    }

}