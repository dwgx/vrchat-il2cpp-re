// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 3
// Methods: 29

namespace VRC.Core
{
    public class DiscordAccessDataObject : ApiModel
    {
        public string _accessToken; // 0x68
        public string _tokenType; // 0x70
        public int _expiresIn; // 0x78
        public string _scope; // 0x80

        // ── Methods ──
        public void get_accessToken(){} // RVA: 0x7FFE81176D50
        public void set_accessToken(){} // RVA: 0x7FFE81176D60
        public void get_tokenType(){} // RVA: 0x7FFE811C3590
        public void set_tokenType(){} // RVA: 0x7FFE811C35A0
        public void get_expiresIn(){} // RVA: 0x7FFE8286C0A0
        public void set_expiresIn(){} // RVA: 0x7FFE82862F10
        public void get_scope(){} // RVA: 0x7FFE81280C30
        public void set_scope(){} // RVA: 0x7FFE81282380
        public void .ctor(){} // RVA: 0x7FFE8A2CB140
    }

    public class DiscordDeviceCodeResponse : ApiModel
    {
        public string _device_code; // 0x68
        public string _user_code; // 0x70
        public string _verification_uri; // 0x78
        public string _verification_uri_complete; // 0x80
        public int _expires_in; // 0x88
        public int _interval; // 0x8C

        // ── Methods ──
        public void get_device_code(){} // RVA: 0x7FFE81176D50
        public void set_device_code(){} // RVA: 0x7FFE81176D60
        public void get_user_code(){} // RVA: 0x7FFE811C3590
        public void set_user_code(){} // RVA: 0x7FFE811C35A0
        public void get_verification_uri(){} // RVA: 0x7FFE81463AE0
        public void set_verification_uri(){} // RVA: 0x7FFE81464570
        public void get_verification_uri_complete(){} // RVA: 0x7FFE81280C30
        public void set_verification_uri_complete(){} // RVA: 0x7FFE81282380
        public void get_expires_in(){} // RVA: 0x7FFE8194AD00
        public void set_expires_in(){} // RVA: 0x7FFE8194A400
        public void get_interval(){} // RVA: 0x7FFE842B66B0
        public void set_interval(){} // RVA: 0x7FFE848F07E0
        public void .ctor(){} // RVA: 0x7FFE8A2CB0F0
    }

    public class DiscordLoginResponse : ApiModel
    {
        public VRC.Core.APIUser _user; // 0x68
        public VRC.Core.DiscordAccessDataObject _discordAccessData; // 0x70
        public bool _userNewlyAcceptedSocialSDKPerms; // 0x78

        // ── Methods ──
        public void get_user(){} // RVA: 0x7FFE81176D50
        public void set_user(){} // RVA: 0x7FFE81176D60
        public void get_discordAccessData(){} // RVA: 0x7FFE811C3590
        public void set_discordAccessData(){} // RVA: 0x7FFE811C35A0
        public void get_userNewlyAcceptedSocialSDKPerms(){} // RVA: 0x7FFE816400C0
        public void set_userNewlyAcceptedSocialSDKPerms(){} // RVA: 0x7FFE81FE6AC0
        public void .ctor(){} // RVA: 0x7FFE8A2CB190
    }

}