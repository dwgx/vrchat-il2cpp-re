// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
// Classes: 7
// Methods: 55

namespace ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
{
    public class ChallengeResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8682A60 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF8682D30
        public void set_Password(){} // RVA: 0x7FFAF8682E30
        public void set_Challenge(){} // RVA: 0x7FFAF86836D0
        public void get_LM(){} // RVA: 0x7FFAF8683870
        public void get_NT(){} // RVA: 0x7FFAF86838E0
        public void Dispose(){} // RVA: 0x7FFAF8683A10 | overloaded x2
        public void GetResponse(){} // RVA: 0x7FFAF8683A90
        public void PrepareDESKey(){} // RVA: 0x7FFAF8683D20
        public void PasswordToKey(){} // RVA: 0x7FFAF8683F20
        public void .cctor(){} // RVA: 0x7FFAF8684140
    }

    public class ChallengeResponse2
    {
        // ── Methods ──
        public void Compute_LM(){} // RVA: 0x7FFAF86842E0
        public void Compute_NTLM_Password(){} // RVA: 0x7FFAF8684880
        public void Compute_NTLM(){} // RVA: 0x7FFAF8684BA0
        public void Compute_NTLMv2_Session(){} // RVA: 0x7FFAF8684C10
        public void Compute_NTLMv2(){} // RVA: 0x7FFAF8685090
        public void Compute(){} // RVA: 0x7FFAF8685910
        public void GetResponse(){} // RVA: 0x7FFAF8685C60
        public void PrepareDESKey(){} // RVA: 0x7FFAF8685F00
        public void PasswordToKey(){} // RVA: 0x7FFAF8686100
        public void .cctor(){} // RVA: 0x7FFAF8686330
    }

    public class MessageBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void get_Flags(){} // RVA: 0x7FFAF335BED0
        public void set_Flags(){} // RVA: 0x7FFAF335C660
        public void get_Type(){} // RVA: 0x7FFAF2DDA5C0
        public void PrepareMessage(){} // RVA: 0x7FFAF8686590
        public void Decode(){} // RVA: 0x7FFAF86867A0
        public void CheckHeader(){} // RVA: 0x7FFAF8686A70
        public void GetBytes(){} // RVA: 0x7FFAF2ABCD60
        public void .cctor(){} // RVA: 0x7FFAF8686BA0
    }

    public class NtlmSettings
    {
        public object Domain;

        // ── Methods ──
        public void get_DefaultAuthLevel(){} // RVA: 0x7FFAF8686C80
        public void .cctor(){} // RVA: 0x7FFAF8686CE0
    }

    public class Type1Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8686D20
        public void set_Domain(){} // RVA: 0x7FFAF8686E30
        public void set_Host(){} // RVA: 0x7FFAF8686F30
        public void Decode(){} // RVA: 0x7FFAF8687030
        public void GetBytes(){} // RVA: 0x7FFAF8687260
    }

    public class Type2Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86876B0
        public void Finalize(){} // RVA: 0x7FFAF86877A0
        public void get_Nonce(){} // RVA: 0x7FFAF8687800
        public void get_TargetName(){} // RVA: 0x7FFAF2DBB0C0
        public void get_TargetInfo(){} // RVA: 0x7FFAF8687880
        public void Decode(){} // RVA: 0x7FFAF8687900
        public void GetBytes(){} // RVA: 0x7FFAF8687D20
    }

    public class Type3Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8687DF0
        public void Finalize(){} // RVA: 0x7FFAF8688180
        public void set_Domain(){} // RVA: 0x7FFAF8688220
        public void set_Password(){} // RVA: 0x7FFAF2DB5200
        public void set_Username(){} // RVA: 0x7FFAF2F4B830
        public void Decode(){} // RVA: 0x7FFAF8688320
        public void DecodeString(){} // RVA: 0x7FFAF8688890
        public void EncodeString(){} // RVA: 0x7FFAF8688900
        public void GetBytes(){} // RVA: 0x7FFAF86889A0
    }

}