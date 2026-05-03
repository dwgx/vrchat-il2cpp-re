// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
// Classes: 7
// Methods: 55

namespace ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
{
    public class ChallengeResponse : Object
    {
        public byte[] magic;
        public byte[] nullEncMagic; // 0x8
        public bool _disposed; // 0x10
        public byte[] _challenge; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE867138B0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE86713B80
        public void set_Password(){} // RVA: 0x7FFE86713C80
        public void set_Challenge(){} // RVA: 0x7FFE86714520
        public void get_LM(){} // RVA: 0x7FFE867146C0
        public void get_NT(){} // RVA: 0x7FFE86714730
        public void Dispose(){} // RVA: 0x7FFE86714860 | overloaded x2
        public void GetResponse(){} // RVA: 0x7FFE867148E0
        public void PrepareDESKey(){} // RVA: 0x7FFE86714B70
        public void PasswordToKey(){} // RVA: 0x7FFE86714D70
        public void .cctor(){} // RVA: 0x7FFE86714F90
    }

    public class ChallengeResponse2 : Object
    {
        // ── Methods ──
        public void Compute_LM(){} // RVA: 0x7FFE86715130
        public void Compute_NTLM_Password(){} // RVA: 0x7FFE867156D0
        public void Compute_NTLM(){} // RVA: 0x7FFE867159F0
        public void Compute_NTLMv2_Session(){} // RVA: 0x7FFE86715A60
        public void Compute_NTLMv2(){} // RVA: 0x7FFE86715EE0
        public void Compute(){} // RVA: 0x7FFE86716760
        public void GetResponse(){} // RVA: 0x7FFE86716AB0
        public void PrepareDESKey(){} // RVA: 0x7FFE86716D50
        public void PasswordToKey(){} // RVA: 0x7FFE86716F50
        public void .cctor(){} // RVA: 0x7FFE86717180
    }

    public class MessageBase : Object
    {
        public byte[] header;
        public int _type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void get_Flags(){} // RVA: 0x7FFE8164B230
        public void set_Flags(){} // RVA: 0x7FFE8164E0F0
        public void get_Type(){} // RVA: 0x7FFE811485C0
        public void PrepareMessage(){} // RVA: 0x7FFE867173E0
        public void Decode(){} // RVA: 0x7FFE867175F0
        public void CheckHeader(){} // RVA: 0x7FFE867178C0
        public void GetBytes(){} // RVA: 0x7FFE80E2E2E0
        public void .cctor(){} // RVA: 0x7FFE867179F0
    }

    public class NtlmSettings : Object
    {
        public 0x6667E1D4 defaultAuthLevel;

        // ── Methods ──
        public void get_DefaultAuthLevel(){} // RVA: 0x7FFE86717AD0
        public void .cctor(){} // RVA: 0x7FFE86717B30
    }

    public class Type1Message : MessageBase
    {
        public string _host; // 0x18
        public string _domain; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86717B70
        public void set_Domain(){} // RVA: 0x7FFE86717C80
        public void set_Host(){} // RVA: 0x7FFE86717D80
        public void Decode(){} // RVA: 0x7FFE86717E80
        public void GetBytes(){} // RVA: 0x7FFE867180B0
    }

    public class Type2Message : MessageBase
    {
        public byte[] _nonce; // 0x18
        public string _targetName; // 0x20
        public byte[] _targetInfo; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86718500
        public void Finalize(){} // RVA: 0x7FFE867185F0
        public void get_Nonce(){} // RVA: 0x7FFE86718650
        public void get_TargetName(){} // RVA: 0x7FFE811290C0
        public void get_TargetInfo(){} // RVA: 0x7FFE867186D0
        public void Decode(){} // RVA: 0x7FFE86718750
        public void GetBytes(){} // RVA: 0x7FFE86718B70
    }

    public class Type3Message : MessageBase
    {
        public 0x6667E1D4 _level; // 0x18
        public byte[] _challenge; // 0x20
        public string _host; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86718C40
        public void Finalize(){} // RVA: 0x7FFE86718FD0
        public void set_Domain(){} // RVA: 0x7FFE86719070
        public void set_Password(){} // RVA: 0x7FFE81123200
        public void set_Username(){} // RVA: 0x7FFE81437330
        public void Decode(){} // RVA: 0x7FFE86719170
        public void DecodeString(){} // RVA: 0x7FFE867196E0
        public void EncodeString(){} // RVA: 0x7FFE86719750
        public void GetBytes(){} // RVA: 0x7FFE867197F0
    }

}