// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 3
// Methods: 29

namespace VRC.Core
{
    public class DiscordAccessDataObject : ApiModel
    {
        public string accessToken; // 0x68
        public string tokenType; // 0x70
        public int expiresIn; // 0x78
        public string scope; // 0x80

        // ── Methods ──
        public void get_accessToken(){} // RVA: 0x7FFAC2F9CD50
        public void set_accessToken(){} // RVA: 0x7FFAC2F9CD60
        public void get_tokenType(){} // RVA: 0x7FFAC2FE9590
        public void set_tokenType(){} // RVA: 0x7FFAC2FE95A0
        public void get_expiresIn(){} // RVA: 0x7FFAC4596EF0
        public void set_expiresIn(){} // RVA: 0x7FFAC45963A0
        public void get_scope(){} // RVA: 0x7FFAC32EF410
        public void set_scope(){} // RVA: 0x7FFAC34D4AA0
        public void .ctor(){} // RVA: 0x7FFACBE6C180
    }

    public class DiscordDeviceCodeResponse : ApiModel
    {
        public string device_code; // 0x68
        public string user_code; // 0x70
        public string verification_uri; // 0x78
        public string verification_uri_complete; // 0x80
        public int expires_in; // 0x88
        public int interval; // 0x8C

        // ── Methods ──
        public void get_device_code(){} // RVA: 0x7FFAC2F9CD50
        public void set_device_code(){} // RVA: 0x7FFAC2F9CD60
        public void get_user_code(){} // RVA: 0x7FFAC2FE9590
        public void set_user_code(){} // RVA: 0x7FFAC2FE95A0
        public void get_verification_uri(){} // RVA: 0x7FFAC30E5600
        public void set_verification_uri(){} // RVA: 0x7FFAC30E06F0
        public void get_verification_uri_complete(){} // RVA: 0x7FFAC32EF410
        public void set_verification_uri_complete(){} // RVA: 0x7FFAC34D4AA0
        public void get_expires_in(){} // RVA: 0x7FFAC37EE8C0
        public void set_expires_in(){} // RVA: 0x7FFAC37F9DE0
        public void get_interval(){} // RVA: 0x7FFAC5F56E80
        public void set_interval(){} // RVA: 0x7FFAC65A0990
        public void .ctor(){} // RVA: 0x7FFACBE6C130
    }

    public class DiscordLoginResponse : ApiModel
    {
        public VRC.Core.APIUser user; // 0x68
        public VRC.Core.DiscordAccessDataObject discordAccessData; // 0x70
        public bool userNewlyAcceptedSocialSDKPerms; // 0x78

        // ── Methods ──
        public void get_user(){} // RVA: 0x7FFAC2F9CD50
        public void set_user(){} // RVA: 0x7FFAC2F9CD60
        public void get_discordAccessData(){} // RVA: 0x7FFAC2FE9590
        public void set_discordAccessData(){} // RVA: 0x7FFAC2FE95A0
        public void get_userNewlyAcceptedSocialSDKPerms(){} // RVA: 0x7FFAC33CE5C0
        public void set_userNewlyAcceptedSocialSDKPerms(){} // RVA: 0x7FFAC3D20B50
        public void .ctor(){} // RVA: 0x7FFACBE6C1D0
    }

}