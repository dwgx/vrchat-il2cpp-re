// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
// Classes: 7
// Methods: 53

namespace ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
{
    public class ChallengeResponse : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9C05E0
        public void Finalize(){} // RVA: 0x7AD9C08B0
        public void set_Password(){} // RVA: 0x7AD9C09B0
        public void set_Challenge(){} // RVA: 0x7AD9C1250
        public void get_LM(){} // RVA: 0x7AD9C13F0
        public void get_NT(){} // RVA: 0x7AD9C1460
        public void Dispose(){} // RVA: 0x7AD9C1590
        public void GetResponse(){} // RVA: 0x7AD9C1610
        public void PrepareDESKey(){} // RVA: 0x7AD9C18A0
        public void PasswordToKey(){} // RVA: 0x7AD9C1A80
        public void .cctor(){} // RVA: 0x7AD9C1CA0
    }

    public class ChallengeResponse2 : Object
    {
        // ── Methods ──
        public void Compute_LM(){} // RVA: 0x7AD9C1E40
        public void Compute_NTLM_Password(){} // RVA: 0x7AD9C23E0
        public void Compute_NTLM(){} // RVA: 0x7AD9C2700
        public void Compute_NTLMv2_Session(){} // RVA: 0x7AD9C2770
        public void Compute_NTLMv2(){} // RVA: 0x7AD9C2BF0
        public void Compute(){} // RVA: 0x7AD9C3470
        public void GetResponse(){} // RVA: 0x7AD9C37C0
        public void PrepareDESKey(){} // RVA: 0x7AD9C3A60
        public void PasswordToKey(){} // RVA: 0x7AD9C3C40
        public void .cctor(){} // RVA: 0x7AD9C3E70
    }

    public class MessageBase : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_Flags(){} // RVA: 0x7A8668BC0
        public void set_Flags(){} // RVA: 0x7A8669360
        public void get_Type(){} // RVA: 0x7A8124910
        public void PrepareMessage(){} // RVA: 0x7AD9C40D0
        public void Decode(){} // RVA: 0x7AD9C42E0
        public void CheckHeader(){} // RVA: 0x7AD9C45B0
        public void GetBytes(){} // RVA: 0x7A7E00680
        public void .cctor(){} // RVA: 0x7AD9C46E0
    }

    public class NtlmSettings : Object
    {
        // ── Methods ──
        public void get_DefaultAuthLevel(){} // RVA: 0x7AD9C47C0
        public void .cctor(){} // RVA: 0x7AD9C4820
    }

    public class Type1Message : MessageBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9C4860
        public void set_Domain(){} // RVA: 0x7AD9C4970
        public void set_Host(){} // RVA: 0x7AD9C4A70
        public void Decode(){} // RVA: 0x7AD9C4B70
        public void GetBytes(){} // RVA: 0x7AD9C4DA0
    }

    public class Type2Message : MessageBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9C51F0
        public void Finalize(){} // RVA: 0x7AD9C52E0
        public void get_Nonce(){} // RVA: 0x7AD9C5340
        public void get_TargetName(){} // RVA: 0x7A81052C0
        public void get_TargetInfo(){} // RVA: 0x7AD9C53C0
        public void Decode(){} // RVA: 0x7AD9C5440
        public void GetBytes(){} // RVA: 0x7AD9C5860
    }

    public class Type3Message : MessageBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9C5930
        public void Finalize(){} // RVA: 0x7AD9C5CD0
        public void set_Domain(){} // RVA: 0x7AD9C5D70
        public void set_Password(){} // RVA: 0x7A80FF440
        public void set_Username(){} // RVA: 0x7A8296DE0
        public void Decode(){} // RVA: 0x7AD9C5E70
        public void DecodeString(){} // RVA: 0x7AD9C63E0
        public void EncodeString(){} // RVA: 0x7AD9C6450
        public void GetBytes(){} // RVA: 0x7AD9C64F0
    }

}