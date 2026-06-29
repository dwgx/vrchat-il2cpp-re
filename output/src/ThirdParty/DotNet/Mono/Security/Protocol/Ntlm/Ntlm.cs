// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
// Classes: 7
// Methods: 53

namespace ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
{
    public class ChallengeResponse : Object
    {
        public object magic;
        public object nullEncMagic;
        public object _disposed;
        public object _challenge;
        public object _lmpwd;
        public object _ntpwd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x664B410
        public void Finalize(){} // RVA: 0x664B6E0
        public void set_Password(){} // RVA: 0x664B7E0
        public void set_Challenge(){} // RVA: 0x664C080
        public void get_LM(){} // RVA: 0x664C220
        public void get_NT(){} // RVA: 0x664C290
        public void Dispose(){} // RVA: 0x664C3C0
        public void GetResponse(){} // RVA: 0x664C440
        public void PrepareDESKey(){} // RVA: 0x664C6D0
        public void PasswordToKey(){} // RVA: 0x664C8B0
        public void .cctor(){} // RVA: 0x664CAD0
    }

    public class ChallengeResponse2 : Object
    {
        public object magic;
        public object nullEncMagic;

        // ── Methods ──
        public void Compute_LM(){} // RVA: 0x664CC70
        public void Compute_NTLM_Password(){} // RVA: 0x664D210
        public void Compute_NTLM(){} // RVA: 0x664D530
        public void Compute_NTLMv2_Session(){} // RVA: 0x664D5A0
        public void Compute_NTLMv2(){} // RVA: 0x664DA20
        public void Compute(){} // RVA: 0x664E2A0
        public void GetResponse(){} // RVA: 0x664E5F0
        public void PrepareDESKey(){} // RVA: 0x664E890
        public void PasswordToKey(){} // RVA: 0x664EA70
        public void .cctor(){} // RVA: 0x664ECA0
    }

    public class MessageBase : Object
    {
        public object header;
        public object _type;
        public object _flags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_Flags(){} // RVA: 0x116A650
        public void set_Flags(){} // RVA: 0x116BB10
        public void get_Type(){} // RVA: 0xB8F8F0
        public void PrepareMessage(){} // RVA: 0x664EF00
        public void Decode(){} // RVA: 0x664F110
        public void CheckHeader(){} // RVA: 0x664F3D0
        public void GetBytes(){} // RVA: 0x87C0A0
        public void .cctor(){} // RVA: 0x664F500
    }

    public class NtlmSettings : Object
    {
        public object defaultAuthLevel;

        // ── Methods ──
        public void get_DefaultAuthLevel(){} // RVA: 0x664F5E0
        public void .cctor(){} // RVA: 0x664F640
    }

    public class Type1Message : MessageBase
    {
        public object _host;
        public object _domain;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x664F680
        public void set_Domain(){} // RVA: 0x664F790
        public void set_Host(){} // RVA: 0x664F890
        public void Decode(){} // RVA: 0x664F990
        public void GetBytes(){} // RVA: 0x664FBC0
    }

    public class Type2Message : MessageBase
    {
        public object _nonce;
        public object _targetName;
        public object _targetInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6650010
        public void Finalize(){} // RVA: 0x6650100
        public void get_Nonce(){} // RVA: 0x6650160
        public void get_TargetName(){} // RVA: 0xB700F0
        public void get_TargetInfo(){} // RVA: 0x66501E0
        public void Decode(){} // RVA: 0x6650260
        public void GetBytes(){} // RVA: 0x6650680
    }

    public class Type3Message : MessageBase
    {
        public object _level;
        public object _challenge;
        public object _host;
        public object _domain;
        public object _username;
        public object _password;
        public object _type2;
        public object _lm;
        public object _nt;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6650750
        public void Finalize(){} // RVA: 0x6650AF0
        public void set_Domain(){} // RVA: 0x6650B90
        public void set_Password(){} // RVA: 0xB6A8C0
        public void set_Username(){} // RVA: 0xD09D70
        public void Decode(){} // RVA: 0x6650C90
        public void DecodeString(){} // RVA: 0x6651200
        public void EncodeString(){} // RVA: 0x6651270
        public void GetBytes(){} // RVA: 0x6651310
    }

}