// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Transmtn.DTO
// Classes: 2
// Methods: 80

namespace ThirdParty.Other.Transmtn.DTO
{
    public class Location : Object
    {
        public string _worldId; // 0x10
        public string _instance; // 0x18
        public bool _isOffline; // 0x20
        public bool _isPrivate; // 0x21
        public bool _isWeb; // 0x22
        public bool _isUnauthorized; // 0x23
        public bool _isTraveling; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A543070
        public void get_WorldId(){} // RVA: 0x7FFE81116380
        public void set_WorldId(){} // RVA: 0x7FFE810FCE30
        public void get_Instance(){} // RVA: 0x7FFE810FE7C0
        public void set_Instance(){} // RVA: 0x7FFE81161E80
        public void get_isOffline(){} // RVA: 0x7FFE811E99D0
        public void set_isOffline(){} // RVA: 0x7FFE811E99E0
        public void get_isPrivate(){} // RVA: 0x7FFE814B5BF0
        public void set_isPrivate(){} // RVA: 0x7FFE818933B0
        public void get_isWeb(){} // RVA: 0x7FFE8292F1A0
        public void set_isWeb(){} // RVA: 0x7FFE822131E0
        public void get_isUnauthorized(){} // RVA: 0x7FFE8A5433B0
        public void set_isUnauthorized(){} // RVA: 0x7FFE8A5433C0
        public void get_isTraveling(){} // RVA: 0x7FFE811167C0
        public void set_isTraveling(){} // RVA: 0x7FFE812EB1B0
        public void ToString(){} // RVA: 0x7FFE8A5433D0
    }

    public class User : Object
    {
        public string _id; // 0x10
        public string _username; // 0x18
        public string _displayName; // 0x20
        public string _bio; // 0x28
        public System.Collections.Immutable.ImmutableHashSet`1<string> _bioLinks; // 0x30
        public string _currentAvatar; // 0x38
        public string _currentAvatarImageUrl; // 0x40
        public string _currentAvatarThumbnailImageUrl; // 0x48
        public System.Collections.Immutable.ImmutableHashSet`1<string> _currentAvatarTags; // 0x50
        public System.Collections.Immutable.ImmutableHashSet`1<string> _tags; // 0x58
        public string _developerType; // 0x60
        public string _last_login; // 0x68
        public string _last_activity; // 0x70
        public string _last_platform; // 0x78
        public string _last_mobile; // 0x80
        public string _platform; // 0x88
        public string _status; // 0x90
        public string _statusDescription; // 0x98
        public bool _ageVerified; // 0xA0
        public string _ageVerificationStatus; // 0xA8
        public string _state; // 0xB0
        public string _friendKey; // 0xB8
        public bool _allowAvatarCopying; // 0xC0
        public bool _isFriend; // 0xC1
        public string _friendRequestStatus; // 0xC8
        public Transmtn.DTO.Location _location; // 0xD0
        public string _profilePicOverride; // 0xD8
        public string _userIcon; // 0xE0
        public string _fallbackAvatar; // 0xE8
        public string _pronouns; // 0xF0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A543470
        public void get_id(){} // RVA: 0x7FFE81116380
        public void set_id(){} // RVA: 0x7FFE810FCE30
        public void get_username(){} // RVA: 0x7FFE810FE7C0
        public void set_username(){} // RVA: 0x7FFE81161E80
        public void get_displayName(){} // RVA: 0x7FFE811290C0
        public void set_displayName(){} // RVA: 0x7FFE811290D0
        public void get_bio(){} // RVA: 0x7FFE81129130
        public void set_bio(){} // RVA: 0x7FFE810FCE90
        public void get_bioLinks(){} // RVA: 0x7FFE8144E200
        public void set_bioLinks(){} // RVA: 0x7FFE81129890
        public void get_currentAvatar(){} // RVA: 0x7FFE8143BA80
        public void set_currentAvatar(){} // RVA: 0x7FFE81437330
        public void get_currentAvatarImageUrl(){} // RVA: 0x7FFE81178740
        public void set_currentAvatarImageUrl(){} // RVA: 0x7FFE81123200
        public void get_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFE81176730
        public void set_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFE81176740
        public void get_currentAvatarTags(){} // RVA: 0x7FFE8119C0E0
        public void set_currentAvatarTags(){} // RVA: 0x7FFE812534D0
        public void get_tags(){} // RVA: 0x7FFE811C3500
        public void set_tags(){} // RVA: 0x7FFE811C3510
        public void get_developerType(){} // RVA: 0x7FFE81199370
        public void set_developerType(){} // RVA: 0x7FFE81199380
        public void get_last_login(){} // RVA: 0x7FFE81176D50
        public void set_last_login(){} // RVA: 0x7FFE81176D60
        public void get_last_activity(){} // RVA: 0x7FFE811C3590
        public void set_last_activity(){} // RVA: 0x7FFE811C35A0
        public void get_last_platform(){} // RVA: 0x7FFE81463AE0
        public void set_last_platform(){} // RVA: 0x7FFE81464570
        public void get_last_mobile(){} // RVA: 0x7FFE81280C30
        public void set_last_mobile(){} // RVA: 0x7FFE81282380
        public void get_platform(){} // RVA: 0x7FFE8113A010
        public void set_platform(){} // RVA: 0x7FFE81280F90
        public void get_status(){} // RVA: 0x7FFE8154EB60
        public void set_status(){} // RVA: 0x7FFE818CE320
        public void get_statusDescription(){} // RVA: 0x7FFE817AE360
        public void set_statusDescription(){} // RVA: 0x7FFE8171B470
        public void get_ageVerified(){} // RVA: 0x7FFE820E9360
        public void set_ageVerified(){} // RVA: 0x7FFE818DBD80
        public void get_ageVerificationStatus(){} // RVA: 0x7FFE817AB5E0
        public void set_ageVerificationStatus(){} // RVA: 0x7FFE81857260
        public void get_state(){} // RVA: 0x7FFE81166040
        public void set_state(){} // RVA: 0x7FFE81166050
        public void get_friendKey(){} // RVA: 0x7FFE811660B0
        public void set_friendKey(){} // RVA: 0x7FFE811660C0
        public void get_allowAvatarCopying(){} // RVA: 0x7FFE8111C4C0
        public void set_allowAvatarCopying(){} // RVA: 0x7FFE8111C4D0
        public void get_isFriend(){} // RVA: 0x7FFE87413F50
        public void set_isFriend(){} // RVA: 0x7FFE87413F60
        public void get_friendRequestStatus(){} // RVA: 0x7FFE81253460
        public void set_friendRequestStatus(){} // RVA: 0x7FFE81253470
        public void get_location(){} // RVA: 0x7FFE81218100
        public void set_location(){} // RVA: 0x7FFE81218110
        public void get_profilePicOverride(){} // RVA: 0x7FFE8181EA80
        public void set_profilePicOverride(){} // RVA: 0x7FFE8117C8A0
        public void get_userIcon(){} // RVA: 0x7FFE8117C900
        public void set_userIcon(){} // RVA: 0x7FFE8117C910
        public void get_fallbackAvatar(){} // RVA: 0x7FFE8117C970
        public void set_fallbackAvatar(){} // RVA: 0x7FFE8117C980
        public void get_pronouns(){} // RVA: 0x7FFE811662A0
        public void set_pronouns(){} // RVA: 0x7FFE811662B0
        public void ToString(){} // RVA: 0x7FFE8A543F40
        public void Equals(){} // RVA: 0x7FFE8A543FE0
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

}