// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
// Classes: 7
// Methods: 55

namespace ThirdParty.DotNet.Mono.Security.Protocol.Ntlm
{
    public class ChallengeResponse : Object
    {
        public byte[] Password;
        public byte[] Challenge; // 0x8
        public bool LM; // 0x10
        public byte[] NT; // 0x18
        public byte[] _lmpwd; // 0x20
        public byte[] _ntpwd; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8369FB0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC836A280
        public void set_Password(){} // RVA: 0x7FFAC836A380
        public void set_Challenge(){} // RVA: 0x7FFAC836AC20
        public void get_LM(){} // RVA: 0x7FFAC836ADC0
        public void get_NT(){} // RVA: 0x7FFAC836AE30
        public void Dispose(){} // RVA: 0x7FFAC836AF60 | overloaded x2
        public void GetResponse(){} // RVA: 0x7FFAC836AFE0
        public void PrepareDESKey(){} // RVA: 0x7FFAC836B270
        public void PasswordToKey(){} // RVA: 0x7FFAC836B470
        public void .cctor(){} // RVA: 0x7FFAC836B690
    }

    public class ChallengeResponse2 : Object
    {
        public byte[] magic;
        public byte[] nullEncMagic; // 0x8

        // ── Methods ──
        public void Compute_LM(){} // RVA: 0x7FFAC836B830
        public void Compute_NTLM_Password(){} // RVA: 0x7FFAC836BDD0
        public void Compute_NTLM(){} // RVA: 0x7FFAC836C0F0
        public void Compute_NTLMv2_Session(){} // RVA: 0x7FFAC836C160
        public void Compute_NTLMv2(){} // RVA: 0x7FFAC836C5E0
        public void Compute(){} // RVA: 0x7FFAC836CE60
        public void GetResponse(){} // RVA: 0x7FFAC836D1B0
        public void PrepareDESKey(){} // RVA: 0x7FFAC836D450
        public void PasswordToKey(){} // RVA: 0x7FFAC836D650
        public void .cctor(){} // RVA: 0x7FFAC836D880
    }

    public class MessageBase : Object
    {
        public byte[] Flags;
        public int Type; // 0x10
        public 0x6B284440 _flags; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void get_Flags(){} // RVA: 0x7FFAC33D5A20
        public void set_Flags(){} // RVA: 0x7FFAC33D4990
        public void get_Type(){} // RVA: 0x7FFAC2F6E5C0
        public void PrepareMessage(){} // RVA: 0x7FFAC836DAE0
        public void Decode(){} // RVA: 0x7FFAC836DCF0
        public void CheckHeader(){} // RVA: 0x7FFAC836DFC0
        public void GetBytes(){} // RVA: 0x7FFAC2C58E90
        public void .cctor(){} // RVA: 0x7FFAC836E0F0
    }

    public class NtlmSettings : Object
    {
        public 0x6B2843E8 DefaultAuthLevel;

        // ── Methods ──
        public void get_DefaultAuthLevel(){} // RVA: 0x7FFAC836E1D0
        public void .cctor(){} // RVA: 0x7FFAC836E230
    }

    public class Type1Message : MessageBase
    {
        public string Domain; // 0x18
        public string Host; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC836E270
        public void set_Domain(){} // RVA: 0x7FFAC836E380
        public void set_Host(){} // RVA: 0x7FFAC836E480
        public void Decode(){} // RVA: 0x7FFAC836E580
        public void GetBytes(){} // RVA: 0x7FFAC836E7B0
    }

    public class Type2Message : MessageBase
    {
        public byte[] Nonce; // 0x18
        public string TargetName; // 0x20
        public byte[] TargetInfo; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC836EC00
        public void Finalize(){} // RVA: 0x7FFAC836ECF0
        public void get_Nonce(){} // RVA: 0x7FFAC836ED50
        public void get_TargetName(){} // RVA: 0x7FFAC2F4F0C0
        public void get_TargetInfo(){} // RVA: 0x7FFAC836EDD0
        public void Decode(){} // RVA: 0x7FFAC836EE50
        public void GetBytes(){} // RVA: 0x7FFAC836F270
    }

    public class Type3Message : MessageBase
    {
        public 0x6B2843E8 Domain; // 0x18
        public byte[] Password; // 0x20
        public string Username; // 0x28
        public string _domain; // 0x30
        public string _username; // 0x38
        public string _password; // 0x40
        public Mono.Security.Protocol.Ntlm.Type2Message _type2; // 0x48
        public byte[] _lm; // 0x50
        public byte[] _nt; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC836F340
        public void Finalize(){} // RVA: 0x7FFAC836F6D0
        public void set_Domain(){} // RVA: 0x7FFAC836F770
        public void set_Password(){} // RVA: 0x7FFAC2F49200
        public void set_Username(){} // RVA: 0x7FFAC31D0C20
        public void Decode(){} // RVA: 0x7FFAC836F870
        public void DecodeString(){} // RVA: 0x7FFAC836FDE0
        public void EncodeString(){} // RVA: 0x7FFAC836FE50
        public void GetBytes(){} // RVA: 0x7FFAC836FEF0
    }

}