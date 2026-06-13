// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 3
// Methods: 29

namespace VRC.Core
{
    public class DiscordAccessDataObject
    {
        public string <accessToken>k__BackingField; // 0x68
        public string <tokenType>k__BackingField; // 0x70
        public int <expiresIn>k__BackingField; // 0x78
        public string <scope>k__BackingField; // 0x80

        // ── Methods ──
        public void get_accessToken(){} // RVA: 0x358D50
        public void set_accessToken(){} // RVA: 0x358D60
        public void get_tokenType(){} // RVA: 0x3A5590
        public void set_tokenType(){} // RVA: 0x3A55A0
        public void get_expiresIn(){} // RVA: 0x1AE3800
        public void set_expiresIn(){} // RVA: 0x1AE6D80
        public void get_scope(){} // RVA: 0x462D00
        public void set_scope(){} // RVA: 0x464450
        public void .ctor(){} // RVA: 0x9868C00
    }

    public class DiscordDeviceCodeResponse
    {
        public string <device_code>k__BackingField; // 0x68
        public string <user_code>k__BackingField; // 0x70
        public string <verification_uri>k__BackingField; // 0x78
        public string <verification_uri_complete>k__BackingField; // 0x80
        public int <expires_in>k__BackingField; // 0x88
        public int <interval>k__BackingField; // 0x8C

        // ── Methods ──
        public void get_device_code(){} // RVA: 0x358D50
        public void set_device_code(){} // RVA: 0x358D60
        public void get_user_code(){} // RVA: 0x3A5590
        public void set_user_code(){} // RVA: 0x3A55A0
        public void get_verification_uri(){} // RVA: 0x4C7C50
        public void set_verification_uri(){} // RVA: 0x4C34F0
        public void get_verification_uri_complete(){} // RVA: 0x462D00
        public void set_verification_uri_complete(){} // RVA: 0x464450
        public void get_expires_in(){} // RVA: 0xBB90C0
        public void set_expires_in(){} // RVA: 0xBB9E60
        public void get_interval(){} // RVA: 0x363A7C0
        public void set_interval(){} // RVA: 0x3C7AFE0
        public void .ctor(){} // RVA: 0x9868BB0
    }

    public class DiscordLoginResponse
    {
        public VRC.Core.APIUser <user>k__BackingField; // 0x68
        public VRC.Core.DiscordAccessDataObject <discordAccessData>k__BackingField; // 0x70
        public bool <userNewlyAcceptedSocialSDKPerms>k__BackingField; // 0x78

        // ── Methods ──
        public void get_user(){} // RVA: 0x358D50
        public void set_user(){} // RVA: 0x358D60
        public void get_discordAccessData(){} // RVA: 0x3A5590
        public void set_discordAccessData(){} // RVA: 0x3A55A0
        public void get_userNewlyAcceptedSocialSDKPerms(){} // RVA: 0x8A10E0
        public void set_userNewlyAcceptedSocialSDKPerms(){} // RVA: 0x1688890
        public void .ctor(){} // RVA: 0x9868C50
    }

}