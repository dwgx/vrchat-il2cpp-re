// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn.DTO
// Classes: 2
// Methods: 80

namespace ThirdParty.Other.Transmtn.DTO
{
    public class Location : Object
    {
        public string WorldId; // 0x10
        public string Instance; // 0x18
        public bool isOffline; // 0x20
        public bool isPrivate; // 0x21
        public bool isWeb; // 0x22
        public bool isUnauthorized; // 0x23
        public bool isTraveling; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574FD0A0
        public void get_WorldId(){} // RVA: 0x7FFD4E35C380
        public void set_WorldId(){} // RVA: 0x7FFD4E342E30
        public void get_Instance(){} // RVA: 0x7FFD4E3447C0
        public void set_Instance(){} // RVA: 0x7FFD4E3A7E80
        public void get_isOffline(){} // RVA: 0x7FFD4E42F9D0
        public void set_isOffline(){} // RVA: 0x7FFD4E42F9E0
        public void get_isPrivate(){} // RVA: 0x7FFD4E64AD20
        public void set_isPrivate(){} // RVA: 0x7FFD4EB8A610
        public void get_isWeb(){} // RVA: 0x7FFD4FA18AA0
        public void set_isWeb(){} // RVA: 0x7FFD4F37A420
        public void get_isUnauthorized(){} // RVA: 0x7FFD574FD3E0
        public void set_isUnauthorized(){} // RVA: 0x7FFD574FD3F0
        public void get_isTraveling(){} // RVA: 0x7FFD4E35C7C0
        public void set_isTraveling(){} // RVA: 0x7FFD4F842FB0
        public void ToString(){} // RVA: 0x7FFD574FD400
    }

    public class User : Object
    {
        public string id; // 0x10
        public string username; // 0x18
        public string displayName; // 0x20
        public string bio; // 0x28
        public fset2096.?<string> bioLinks; // 0x30
        public string currentAvatar; // 0x38
        public string currentAvatarImageUrl; // 0x40
        public string currentAvatarThumbnailImageUrl; // 0x48
        public fset2096.?<string> currentAvatarTags; // 0x50
        public fset2096.?<string> tags; // 0x58
        public string developerType; // 0x60
        public string last_login; // 0x68
        public string last_activity; // 0x70
        public string last_platform; // 0x78
        public string last_mobile; // 0x80
        public string platform; // 0x88
        public string status; // 0x90
        public string statusDescription; // 0x98
        public bool ageVerified; // 0xA0
        public string ageVerificationStatus; // 0xA8
        public string state; // 0xB0
        public string friendKey; // 0xB8
        public bool allowAvatarCopying; // 0xC0
        public bool isFriend; // 0xC1
        public string friendRequestStatus; // 0xC8
        public 384.? location; // 0xD0
        public string profilePicOverride; // 0xD8
        public string userIcon; // 0xE0
        public string fallbackAvatar; // 0xE8
        public string pronouns; // 0xF0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD574FD4A0
        public void get_id(){} // RVA: 0x7FFD4E35C380
        public void set_id(){} // RVA: 0x7FFD4E342E30
        public void get_username(){} // RVA: 0x7FFD4E3447C0
        public void set_username(){} // RVA: 0x7FFD4E3A7E80
        public void get_displayName(){} // RVA: 0x7FFD4E36F0C0
        public void set_displayName(){} // RVA: 0x7FFD4E36F0D0
        public void get_bio(){} // RVA: 0x7FFD4E36F130
        public void set_bio(){} // RVA: 0x7FFD4E342E90
        public void get_bioLinks(){} // RVA: 0x7FFD4E5F95E0
        public void set_bioLinks(){} // RVA: 0x7FFD4E36F890
        public void get_currentAvatar(){} // RVA: 0x7FFD4E5F0140
        public void set_currentAvatar(){} // RVA: 0x7FFD4E5F0C20
        public void get_currentAvatarImageUrl(){} // RVA: 0x7FFD4E3BE740
        public void set_currentAvatarImageUrl(){} // RVA: 0x7FFD4E369200
        public void get_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFD4E3BC730
        public void set_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFD4E3BC740
        public void get_currentAvatarTags(){} // RVA: 0x7FFD4E3E20E0
        public void set_currentAvatarTags(){} // RVA: 0x7FFD4E4994D0
        public void get_tags(){} // RVA: 0x7FFD4E409500
        public void set_tags(){} // RVA: 0x7FFD4E409510
        public void get_developerType(){} // RVA: 0x7FFD4E3DF370
        public void set_developerType(){} // RVA: 0x7FFD4E3DF380
        public void get_last_login(){} // RVA: 0x7FFD4E3BCD50
        public void set_last_login(){} // RVA: 0x7FFD4E3BCD60
        public void get_last_activity(){} // RVA: 0x7FFD4E409590
        public void set_last_activity(){} // RVA: 0x7FFD4E4095A0
        public void get_last_platform(){} // RVA: 0x7FFD4E505600
        public void set_last_platform(){} // RVA: 0x7FFD4E5006F0
        public void get_last_mobile(){} // RVA: 0x7FFD4E70F410
        public void set_last_mobile(){} // RVA: 0x7FFD4E8F4AA0
        public void get_platform(){} // RVA: 0x7FFD4E380010
        public void set_platform(){} // RVA: 0x7FFD4E96E300
        public void get_status(){} // RVA: 0x7FFD4E70F640
        public void set_status(){} // RVA: 0x7FFD4E96E360
        public void get_statusDescription(){} // RVA: 0x7FFD4E96DFB0
        public void set_statusDescription(){} // RVA: 0x7FFD4E96E3C0
        public void get_ageVerified(){} // RVA: 0x7FFD4F9E9D50
        public void set_ageVerified(){} // RVA: 0x7FFD4EBD1910
        public void get_ageVerificationStatus(){} // RVA: 0x7FFD4E96B1A0
        public void set_ageVerificationStatus(){} // RVA: 0x7FFD4E76B370
        public void get_state(){} // RVA: 0x7FFD4E3AC040
        public void set_state(){} // RVA: 0x7FFD4E3AC050
        public void get_friendKey(){} // RVA: 0x7FFD4E3AC0B0
        public void set_friendKey(){} // RVA: 0x7FFD4E3AC0C0
        public void get_allowAvatarCopying(){} // RVA: 0x7FFD4E3624C0
        public void set_allowAvatarCopying(){} // RVA: 0x7FFD4E3624D0
        public void get_isFriend(){} // RVA: 0x7FFD5448B7A0
        public void set_isFriend(){} // RVA: 0x7FFD5448B7B0
        public void get_friendRequestStatus(){} // RVA: 0x7FFD4E499460
        public void set_friendRequestStatus(){} // RVA: 0x7FFD4E499470
        public void get_location(){} // RVA: 0x7FFD4E45E100
        public void set_location(){} // RVA: 0x7FFD4E45E110
        public void get_profilePicOverride(){} // RVA: 0x7FFD4E960F70
        public void set_profilePicOverride(){} // RVA: 0x7FFD4E3C28A0
        public void get_userIcon(){} // RVA: 0x7FFD4E3C2900
        public void set_userIcon(){} // RVA: 0x7FFD4E3C2910
        public void get_fallbackAvatar(){} // RVA: 0x7FFD4E3C2970
        public void set_fallbackAvatar(){} // RVA: 0x7FFD4E3C2980
        public void get_pronouns(){} // RVA: 0x7FFD4E3AC2A0
        public void set_pronouns(){} // RVA: 0x7FFD4E3AC2B0
        public void ToString(){} // RVA: 0x7FFD574FDF70
        public void Equals(){} // RVA: 0x7FFD574FE010
        public void GetHashCode(){} // RVA: 0x7FFD4E9FB750
    }

}