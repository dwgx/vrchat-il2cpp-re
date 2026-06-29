// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 3
// Methods: 29

namespace VRC.Core
{
    public class DiscordAccessDataObject : ApiModel
    {
        public object _accessToken;
        public object _tokenType;
        public object _expiresIn;
        public object _scope;

        // ── Methods ──
        public void get_accessToken(){} // RVA: 0xBBFF90
        public void set_accessToken(){} // RVA: 0xBBFFA0
        public void get_tokenType(){} // RVA: 0xC10050
        public void set_tokenType(){} // RVA: 0xC10060
        public void get_expiresIn(){} // RVA: 0x23ADD10
        public void set_expiresIn(){} // RVA: 0x23B2A80
        public void get_scope(){} // RVA: 0xCD48B0
        public void set_scope(){} // RVA: 0xCD3600
        public void .ctor(){} // RVA: 0xA50EEB0
    }

    public class DiscordDeviceCodeResponse : ApiModel
    {
        public object _device_code;
        public object _user_code;
        public object _verification_uri;
        public object _verification_uri_complete;
        public object _expires_in;
        public object _interval;

        // ── Methods ──
        public void get_device_code(){} // RVA: 0xBBFF90
        public void set_device_code(){} // RVA: 0xBBFFA0
        public void get_user_code(){} // RVA: 0xC10050
        public void set_user_code(){} // RVA: 0xC10060
        public void get_verification_uri(){} // RVA: 0xCD3320
        public void set_verification_uri(){} // RVA: 0xCD4740
        public void get_verification_uri_complete(){} // RVA: 0xCD48B0
        public void set_verification_uri_complete(){} // RVA: 0xCD3600
        public void get_expires_in(){} // RVA: 0x14780B0
        public void set_expires_in(){} // RVA: 0x147EE80
        public void get_interval(){} // RVA: 0x40A8A30
        public void set_interval(){} // RVA: 0x46CB6C0
        public void .ctor(){} // RVA: 0xA50EE60
    }

    public class DiscordLoginResponse : ApiModel
    {
        public object _user;
        public object _discordAccessData;
        public object _userNewlyAcceptedSocialSDKPerms;

        // ── Methods ──
        public void get_user(){} // RVA: 0xBBFF90
        public void set_user(){} // RVA: 0xBBFFA0
        public void get_discordAccessData(){} // RVA: 0xC10050
        public void set_discordAccessData(){} // RVA: 0xC10060
        public void get_userNewlyAcceptedSocialSDKPerms(){} // RVA: 0x1165710
        public void set_userNewlyAcceptedSocialSDKPerms(){} // RVA: 0x1F749D0
        public void .ctor(){} // RVA: 0xA50EF00
    }

}