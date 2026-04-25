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
        public void .ctor(){} // RVA: 0x7FFACC0DD0A0
        public void get_WorldId(){} // RVA: 0x7FFAC2F3C380
        public void set_WorldId(){} // RVA: 0x7FFAC2F22E30
        public void get_Instance(){} // RVA: 0x7FFAC2F247C0
        public void set_Instance(){} // RVA: 0x7FFAC2F87E80
        public void get_isOffline(){} // RVA: 0x7FFAC300F9D0
        public void set_isOffline(){} // RVA: 0x7FFAC300F9E0
        public void get_isPrivate(){} // RVA: 0x7FFAC322AD20
        public void set_isPrivate(){} // RVA: 0x7FFAC376A610
        public void get_isWeb(){} // RVA: 0x7FFAC45F8AA0
        public void set_isWeb(){} // RVA: 0x7FFAC3F5A420
        public void get_isUnauthorized(){} // RVA: 0x7FFACC0DD3E0
        public void set_isUnauthorized(){} // RVA: 0x7FFACC0DD3F0
        public void get_isTraveling(){} // RVA: 0x7FFAC2F3C7C0
        public void set_isTraveling(){} // RVA: 0x7FFAC4422FB0
        public void ToString(){} // RVA: 0x7FFACC0DD400
    }

    public class User : Object
    {
        public string id; // 0x10
        public string username; // 0x18
        public string displayName; // 0x20
        public string bio; // 0x28
        public System.Collections.Immutable.ImmutableHashSet`1<string> bioLinks; // 0x30
        public string currentAvatar; // 0x38
        public string currentAvatarImageUrl; // 0x40
        public string currentAvatarThumbnailImageUrl; // 0x48
        public System.Collections.Immutable.ImmutableHashSet`1<string> currentAvatarTags; // 0x50
        public System.Collections.Immutable.ImmutableHashSet`1<string> tags; // 0x58
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
        public Transmtn.DTO.Location location; // 0xD0
        public string profilePicOverride; // 0xD8
        public string userIcon; // 0xE0
        public string fallbackAvatar; // 0xE8
        public string pronouns; // 0xF0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACC0DD4A0
        public void get_id(){} // RVA: 0x7FFAC2F3C380
        public void set_id(){} // RVA: 0x7FFAC2F22E30
        public void get_username(){} // RVA: 0x7FFAC2F247C0
        public void set_username(){} // RVA: 0x7FFAC2F87E80
        public void get_displayName(){} // RVA: 0x7FFAC2F4F0C0
        public void set_displayName(){} // RVA: 0x7FFAC2F4F0D0
        public void get_bio(){} // RVA: 0x7FFAC2F4F130
        public void set_bio(){} // RVA: 0x7FFAC2F22E90
        public void get_bioLinks(){} // RVA: 0x7FFAC31D95E0
        public void set_bioLinks(){} // RVA: 0x7FFAC2F4F890
        public void get_currentAvatar(){} // RVA: 0x7FFAC31D0140
        public void set_currentAvatar(){} // RVA: 0x7FFAC31D0C20
        public void get_currentAvatarImageUrl(){} // RVA: 0x7FFAC2F9E740
        public void set_currentAvatarImageUrl(){} // RVA: 0x7FFAC2F49200
        public void get_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFAC2F9C730
        public void set_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFAC2F9C740
        public void get_currentAvatarTags(){} // RVA: 0x7FFAC2FC20E0
        public void set_currentAvatarTags(){} // RVA: 0x7FFAC30794D0
        public void get_tags(){} // RVA: 0x7FFAC2FE9500
        public void set_tags(){} // RVA: 0x7FFAC2FE9510
        public void get_developerType(){} // RVA: 0x7FFAC2FBF370
        public void set_developerType(){} // RVA: 0x7FFAC2FBF380
        public void get_last_login(){} // RVA: 0x7FFAC2F9CD50
        public void set_last_login(){} // RVA: 0x7FFAC2F9CD60
        public void get_last_activity(){} // RVA: 0x7FFAC2FE9590
        public void set_last_activity(){} // RVA: 0x7FFAC2FE95A0
        public void get_last_platform(){} // RVA: 0x7FFAC30E5600
        public void set_last_platform(){} // RVA: 0x7FFAC30E06F0
        public void get_last_mobile(){} // RVA: 0x7FFAC32EF410
        public void set_last_mobile(){} // RVA: 0x7FFAC34D4AA0
        public void get_platform(){} // RVA: 0x7FFAC2F60010
        public void set_platform(){} // RVA: 0x7FFAC354E300
        public void get_status(){} // RVA: 0x7FFAC32EF640
        public void set_status(){} // RVA: 0x7FFAC354E360
        public void get_statusDescription(){} // RVA: 0x7FFAC354DFB0
        public void set_statusDescription(){} // RVA: 0x7FFAC354E3C0
        public void get_ageVerified(){} // RVA: 0x7FFAC45C9D50
        public void set_ageVerified(){} // RVA: 0x7FFAC37B1910
        public void get_ageVerificationStatus(){} // RVA: 0x7FFAC354B1A0
        public void set_ageVerificationStatus(){} // RVA: 0x7FFAC334B370
        public void get_state(){} // RVA: 0x7FFAC2F8C040
        public void set_state(){} // RVA: 0x7FFAC2F8C050
        public void get_friendKey(){} // RVA: 0x7FFAC2F8C0B0
        public void set_friendKey(){} // RVA: 0x7FFAC2F8C0C0
        public void get_allowAvatarCopying(){} // RVA: 0x7FFAC2F424C0
        public void set_allowAvatarCopying(){} // RVA: 0x7FFAC2F424D0
        public void get_isFriend(){} // RVA: 0x7FFAC906B7A0
        public void set_isFriend(){} // RVA: 0x7FFAC906B7B0
        public void get_friendRequestStatus(){} // RVA: 0x7FFAC3079460
        public void set_friendRequestStatus(){} // RVA: 0x7FFAC3079470
        public void get_location(){} // RVA: 0x7FFAC303E100
        public void set_location(){} // RVA: 0x7FFAC303E110
        public void get_profilePicOverride(){} // RVA: 0x7FFAC3540F70
        public void set_profilePicOverride(){} // RVA: 0x7FFAC2FA28A0
        public void get_userIcon(){} // RVA: 0x7FFAC2FA2900
        public void set_userIcon(){} // RVA: 0x7FFAC2FA2910
        public void get_fallbackAvatar(){} // RVA: 0x7FFAC2FA2970
        public void set_fallbackAvatar(){} // RVA: 0x7FFAC2FA2980
        public void get_pronouns(){} // RVA: 0x7FFAC2F8C2A0
        public void set_pronouns(){} // RVA: 0x7FFAC2F8C2B0
        public void ToString(){} // RVA: 0x7FFACC0DDF70
        public void Equals(){} // RVA: 0x7FFACC0DE010
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

}