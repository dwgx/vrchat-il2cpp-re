// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 27
// Methods: 466

namespace VRC.Core
{
    public class APIGroup : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5C2330
        public void get_ownerId(){} // RVA: 0xBBFF90
        public void set_ownerId(){} // RVA: 0xBBFFA0
        public void get_name(){} // RVA: 0xC10050
        public void set_name(){} // RVA: 0xC10060
        public void get_shortCode(){} // RVA: 0xCD3320
        public void set_shortCode(){} // RVA: 0xCD4740
        public void get_discriminator(){} // RVA: 0xCD48B0
        public void set_discriminator(){} // RVA: 0xCD3600
        public void get_description(){} // RVA: 0xB813B0
        public void set_description(){} // RVA: 0xD5CBB0
        public void get_iconUrl(){} // RVA: 0x1069350
        public void set_iconUrl(){} // RVA: 0xD5CC10
        public void get_bannerUrl(){} // RVA: 0x106A7D0
        public void set_bannerUrl(){} // RVA: 0xD5CC70
        public void get_memberCount(){} // RVA: 0x262A8F0
        public void set_memberCount(){} // RVA: 0x262A940
        public void get_onlineMemberCount(){} // RVA: 0x6C8E620
        public void set_onlineMemberCount(){} // RVA: 0x6C8E630
        public void get_memberCountSyncedAt(){} // RVA: 0x12EB090
        public void set_memberCountSyncedAt(){} // RVA: 0x13B1040
        public void get_privacy(){} // RVA: 0xBAE340
        public void set_privacy(){} // RVA: 0xBAE350
        public void get_joinState(){} // RVA: 0xBAE3B0
        public void set_joinState(){} // RVA: 0xBAE3C0
        public void get_myMember(){} // RVA: 0xBAE420
        public void set_myMember(){} // RVA: 0xBAE430
        public void get_createdAt(){} // RVA: 0xCA4D80
        public void set_createdAt(){} // RVA: 0x981B490
        public void get_updatedAt(){} // RVA: 0xC68EB0
        public void set_updatedAt(){} // RVA: 0x7339DC0
        public void get_membershipStatus(){} // RVA: 0x135D730
        public void set_membershipStatus(){} // RVA: 0xBC5AD0
        public void get_bannerId(){} // RVA: 0xBC5B30
        public void set_bannerId(){} // RVA: 0xBC5B40
        public void get_iconId(){} // RVA: 0xBC5BA0
        public void set_iconId(){} // RVA: 0xBC5BB0
        public void get_rules(){} // RVA: 0xBAE5A0
        public void set_rules(){} // RVA: 0xBAE5B0
        public void get_initialRoleIds(){} // RVA: 0x135A7B0
        public void set_initialRoleIds(){} // RVA: 0xEC0BB0
        public void get_isSystemGroup(){} // RVA: 0x2443BA0
        public void set_isSystemGroup(){} // RVA: 0x2443BB0
        public void get_isVerified(){} // RVA: 0x24440E0
        public void set_isVerified(){} // RVA: 0x2443E20
        public void get_galleries(){} // RVA: 0x10B9D50
        public void set_galleries(){} // RVA: 0x15B7570
        public void get_tags(){} // RVA: 0xD9E3D0
        public void set_tags(){} // RVA: 0xD9D290
        public void get_isSearchable(){} // RVA: 0xEF50C0
        public void set_isSearchable(){} // RVA: 0xEF3230
        public void get_sizeQuality(){} // RVA: 0x80D0C00
        public void set_sizeQuality(){} // RVA: 0xA5C2950
        public void get_activityQuality(){} // RVA: 0x15D7C60
        public void set_activityQuality(){} // RVA: 0x6CE7A90
        public void get_engagementQuality(){} // RVA: 0x6BB0770
        public void set_engagementQuality(){} // RVA: 0x6BB0780
        public void get_contentQuality(){} // RVA: 0x6CE7E30
        public void set_contentQuality(){} // RVA: 0x6CE7E40
        public void get_roles(){} // RVA: 0x135EDB0
        public void set_roles(){} // RVA: 0x1658000
        public void get_links(){} // RVA: 0x135A170
        public void set_links(){} // RVA: 0x1365A40
        public void get_languages(){} // RVA: 0xBAE8F0
        public void set_languages(){} // RVA: 0xBAE900
        public void get_lastPostCreatedAt(){} // RVA: 0xBAE960
        public void set_lastPostCreatedAt(){} // RVA: 0x6D09B50
        public void get_storeId(){} // RVA: 0x12CDBF0
        public void set_storeId(){} // RVA: 0x164A230
        public void UpdateData(){} // RVA: 0xA5C2960
        public void GetGroup(){} // RVA: 0xA5C33D0
        public void FetchAllData(){} // RVA: 0xA5C35F0
        public void RequestToJoin(){} // RVA: 0xA5C3A90
        public void LeaveGroup(){} // RVA: 0xA5C3E60
        public void GetGroupInvites(){} // RVA: 0xA5C41E0
        public void InviteUser(){} // RVA: 0xA5C4660
        public void BanUser(){} // RVA: 0xA5C4AA0
        public void GetMembers(){} // RVA: 0xA5C4EE0
        public void GetGroupCapacity(){} // RVA: 0xA5C54B0
        public void SetRepresentation(){} // RVA: 0xA5C55C0
        public void GetGroupGalleryImages(){} // RVA: 0xA5C5A50
        public void GetGroupProducts(){} // RVA: 0xA5C6570
        public void GetGroupAnnouncements(){} // RVA: 0xA5C69D0
        public void SetAnnouncementSubscription(){} // RVA: 0xA5C6F50
        public void SetEventAnnouncementSubscription(){} // RVA: 0xA5C73B0
        public void GetUsingShortCode(){} // RVA: 0xA5C7810
        public void StrictSearch(){} // RVA: 0xA5C7B40
        public void GetActiveGroupInstances(){} // RVA: 0xA5C7FB0
        public void GetRoles(){} // RVA: 0xA5C8410
        public void GetAllGroupPermissions(){} // RVA: 0xA5C8830
        public void GetGroupPermissions(){} // RVA: 0xA5C8B60
        public void ExtractPermissions(){} // RVA: 0xA5C8FE0
    }

    public class APIGroupAnnouncement : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0xBBFF90
        public void set_groupId(){} // RVA: 0xBBFFA0
        public void get_authorId(){} // RVA: 0xC10050
        public void set_authorId(){} // RVA: 0xC10060
        public void get_title(){} // RVA: 0xCD3320
        public void set_title(){} // RVA: 0xCD4740
        public void get_text(){} // RVA: 0xCD48B0
        public void set_text(){} // RVA: 0xCD3600
        public void get_imageUrl(){} // RVA: 0xB813B0
        public void set_imageUrl(){} // RVA: 0xD5CBB0
        public void get_visibility(){} // RVA: 0x1069350
        public void set_visibility(){} // RVA: 0xD5CC10
        public void get_createdAt(){} // RVA: 0x106A7D0
        public void set_createdAt(){} // RVA: 0x6A6A800
        public void get_updatedAt(){} // RVA: 0x106A050
        public void set_updatedAt(){} // RVA: 0x6A6A810
        public void get_roleIds(){} // RVA: 0x12EB090
        public void set_roleIds(){} // RVA: 0x13B1040
        public void SetLastPostReadAt(){} // RVA: 0xA5CAAE0
        public void .ctor(){} // RVA: 0xA5CAEF0
    }

    public class APIGroupInstance : ApiWorldInstance
    {
        // ── Methods ──
        public void BuildRequest(){} // RVA: 0xA5CAF90
        public void .ctor(){} // RVA: 0xA5CB240
    }

    public class APIGroupInvite : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0xBBFF90
        public void set_groupId(){} // RVA: 0xBBFFA0
        public void get_userId(){} // RVA: 0xC10050
        public void set_userId(){} // RVA: 0xC10060
        public void get_state(){} // RVA: 0xCD3320
        public void set_state(){} // RVA: 0xCD4740
        public void CancelRequest(){} // RVA: 0xA5CA740
        public void .ctor(){} // RVA: 0xA5CAA40
    }

    public class APIGroupJoinResponse : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0xBBFF90
        public void set_groupId(){} // RVA: 0xBBFFA0
        public void get_userId(){} // RVA: 0xC10050
        public void set_userId(){} // RVA: 0xC10060
        public void get_createdAt(){} // RVA: 0xCD3320
        public void set_createdAt(){} // RVA: 0x6529A50
        public void get_isOnProfile(){} // RVA: 0xE3F400
        public void set_isOnProfile(){} // RVA: 0xE3CFC0
        public void get_isOnNameplate(){} // RVA: 0xE3A050
        public void set_isOnNameplate(){} // RVA: 0xE3F3F0
        public void get_joinedAt(){} // RVA: 0xB813B0
        public void set_joinedAt(){} // RVA: 0x13AA640
        public void get_updatedAt(){} // RVA: 0x1069350
        public void set_updatedAt(){} // RVA: 0x25687F0
        public void get_isActive(){} // RVA: 0x11319D0
        public void set_isActive(){} // RVA: 0x112ECB0
        public void get_requestedJoin(){} // RVA: 0x1133080
        public void set_requestedJoin(){} // RVA: 0x6C31AC0
        public void get_inviteId(){} // RVA: 0x106A050
        public void set_inviteId(){} // RVA: 0xD5CCD0
        public void .ctor(){} // RVA: 0xA5CA6F0
    }

    public class APIGroupList : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5CB3E0
    }

    public class APIGroupLocations : ApiModel
    {
        // ── Methods ──
        public void get_fetchedAt(){} // RVA: 0xBBFF90
        public void set_fetchedAt(){} // RVA: 0x278E9A0
        public void get_instances(){} // RVA: 0xC10050
        public void set_instances(){} // RVA: 0xC10060
        public void GetLocations(){} // RVA: 0xA5CB4D0
        public void .ctor(){} // RVA: 0xA5CB820
    }

    public class APIGroupMember : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5CBCB0
        public void get_groupId(){} // RVA: 0xBBFF90
        public void set_groupId(){} // RVA: 0xBBFFA0
        public void get_userId(){} // RVA: 0xC10050
        public void set_userId(){} // RVA: 0xC10060
        public void get_roleIds(){} // RVA: 0xCD3320
        public void set_roleIds(){} // RVA: 0xCD4740
        public void get_mRoleIds(){} // RVA: 0xCD48B0
        public void set_mRoleIds(){} // RVA: 0xCD3600
        public void get_permissions(){} // RVA: 0xB813B0
        public void set_permissions(){} // RVA: 0xD5CBB0
        public void get_memberVisibility(){} // RVA: 0x1069350
        public void set_memberVisibility(){} // RVA: 0xD5CC10
        public void get_membershipStatus(){} // RVA: 0x106A7D0
        public void set_membershipStatus(){} // RVA: 0xD5CC70
        public void get_isRepresenting(){} // RVA: 0x2443C20
        public void set_isRepresenting(){} // RVA: 0x143D170
        public void get_mutualGroup(){} // RVA: 0x25D1680
        public void set_mutualGroup(){} // RVA: 0x25D1690
        public void get_name(){} // RVA: 0x12EB090
        public void set_name(){} // RVA: 0x13B1040
        public void get_ownerId(){} // RVA: 0xBAE340
        public void set_ownerId(){} // RVA: 0xBAE350
        public void get_shortCode(){} // RVA: 0xBAE3B0
        public void set_shortCode(){} // RVA: 0xBAE3C0
        public void get_discriminator(){} // RVA: 0xBAE420
        public void set_discriminator(){} // RVA: 0xBAE430
        public void get_iconUrl(){} // RVA: 0xCA4D80
        public void set_iconUrl(){} // RVA: 0xCA4D90
        public void get_bannerUrl(){} // RVA: 0xC68EB0
        public void set_bannerUrl(){} // RVA: 0xC68EC0
        public void get_privacy(){} // RVA: 0x135D730
        public void set_privacy(){} // RVA: 0xBC5AD0
        public void get_visibility(){} // RVA: 0xBC5B30
        public void set_visibility(){} // RVA: 0xBC5B40
        public void get_isSubscribedToAnnouncements(){} // RVA: 0x1DFD090
        public void set_isSubscribedToAnnouncements(){} // RVA: 0x216A2B0
        public void get_isSubscribedToEventAnnouncements(){} // RVA: 0x71164B0
        public void set_isSubscribedToEventAnnouncements(){} // RVA: 0xA56E320
        public void get_memberCount(){} // RVA: 0x255B920
        public void set_memberCount(){} // RVA: 0x6CE7A70
        public void get_joinedAt(){} // RVA: 0xBAE5A0
        public void set_joinedAt(){} // RVA: 0x6E3F2A0
        public void get_bannedAt(){} // RVA: 0x135A7B0
        public void set_bannedAt(){} // RVA: 0xA51CD50
        public void get_lastPostReadAt(){} // RVA: 0x10B4170
        public void set_lastPostReadAt(){} // RVA: 0x1FDB9B0
        public void get_lastPostCreatedAt(){} // RVA: 0x10B9D50
        public void set_lastPostCreatedAt(){} // RVA: 0xD9D280
        public void get_user(){} // RVA: 0xD9E3D0
        public void set_user(){} // RVA: 0xD9D290
        public void get_group(){} // RVA: 0xDA0520
        public void set_group(){} // RVA: 0xD9D570
        public void GetMemberships(){} // RVA: 0xA5CBD10
        public void SetVisibility(){} // RVA: 0xA5CC0F0
        public void FetchGroup(){} // RVA: 0xA5CC5C0
        public void GetRepresentation(){} // RVA: 0xA5CC910
    }

    public class APIGroupMemberList : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0xBBFF90
        public void set_groupId(){} // RVA: 0xBBFFA0
        public void get_members(){} // RVA: 0xC10050
        public void set_members(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA5CD090
    }

    public class APIGroupPosts : ApiModel
    {
        // ── Methods ──
        public void get_total(){} // RVA: 0x2536460
        public void set_total(){} // RVA: 0x25406E0
        public void get_posts(){} // RVA: 0xC10050
        public void set_posts(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA5CAA90
    }

    public class APIGroupRole : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0xBBFF90
        public void set_groupId(){} // RVA: 0xBBFFA0
        public void get_name(){} // RVA: 0xC10050
        public void set_name(){} // RVA: 0xC10060
        public void get_description(){} // RVA: 0xCD3320
        public void set_description(){} // RVA: 0xCD4740
        public void get_isSelfAssignable(){} // RVA: 0xE3F400
        public void set_isSelfAssignable(){} // RVA: 0xE3CFC0
        public void get_requiresTwoFactor(){} // RVA: 0xE3A050
        public void set_requiresTwoFactor(){} // RVA: 0xE3F3F0
        public void get_isManagementRole(){} // RVA: 0x1A177C0
        public void set_isManagementRole(){} // RVA: 0x6A0DA90
        public void get_requiresPurchase(){} // RVA: 0x1DE6270
        public void set_requiresPurchase(){} // RVA: 0x6A6A5D0
        public void get_createdAt(){} // RVA: 0xB813B0
        public void set_createdAt(){} // RVA: 0x13AA640
        public void get_updatedAt(){} // RVA: 0x1069350
        public void set_updatedAt(){} // RVA: 0x25687F0
        public void get_defaultRole(){} // RVA: 0x11319D0
        public void set_defaultRole(){} // RVA: 0x112ECB0
        public void get_order(){} // RVA: 0x262A910
        public void set_order(){} // RVA: 0x262A920
        public void get_permissions(){} // RVA: 0x106A050
        public void set_permissions(){} // RVA: 0xD5CCD0
        public void .ctor(){} // RVA: 0xA5CD1F0
    }

    public class APIGroupRoleList : ApiModel
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0xBBFF90
        public void set_groupId(){} // RVA: 0xBBFFA0
        public void get_roles(){} // RVA: 0xC10050
        public void set_roles(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA5CD500
    }

    public class AnalyticsInterface : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0xA5DBEE0
        public void SetBuildVersion(){} // RVA: 0xA5DC040
        public void SetLogger(){} // RVA: 0xA5DC0F0
        public void Send(){} // RVA: 0xA5DC1E0
        public void SendWithTimestamp(){} // RVA: 0xA5DC2B0
        public void SetUserId(){} // RVA: 0xA5DC390
        public void SetSessionId(){} // RVA: 0xA5DC440
        public void GetSessionId(){} // RVA: 0xA5DC500
        public void SetUserProperties(){} // RVA: 0xA5DC5A0
        public void ClearCachedData(){} // RVA: 0xA5DC660
        public void OnApplicationQuit(){} // RVA: 0xA5DC7A0
        public void HasPendingEvents(){} // RVA: 0xA5DC870
        public void OnApplicationFocused(){} // RVA: 0xA5DC940
        public void OnApplicationPaused(){} // RVA: 0xA5DC9E0
        public void CheckInstance(){} // RVA: 0xA5DCAA0
    }

    public class AnalyticsSDK : Object
    {
        // ── Methods ──
        public void GetProjectTypeString(){} // RVA: 0xA5DCB80
        public void Initialize(){} // RVA: 0xA5DCC30
        public void LoggedInUserChanged(){} // RVA: 0xA5DCDA0
        public void AddOtherProperties(){} // RVA: 0xA5DCFF0
        public void AvatarUploadFailed(){} // RVA: 0xA5DD160
        public void WorldUploadFailed(){} // RVA: 0xA5DD2D0
        public void PropUploadFailed(){} // RVA: 0xA5DD440
        public void ExampleCentralOpened(){} // RVA: 0xA5DD5B0
        public void ExampleDownloaded(){} // RVA: 0xA5DD750
        public void ExamplePreviewed(){} // RVA: 0xA5DD990
        public void CheckInit(){} // RVA: 0xA5DDD00
        public void BuildAndTestLaunched(){} // RVA: 0xA5DDE30
        public void ProjectPublished(){} // RVA: 0xA5DE0C0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0xA5DE520
    }

    public class ApiBindingCommandReference[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiEconomyAccountStatus : ApiModel
    {
        // ── Methods ──
        public void get_UserID(){} // RVA: 0xBBFF90
        public void set_UserID(){} // RVA: 0xBBFFA0
        public void get_Blocked(){} // RVA: 0xBC03E0
        public void set_Blocked(){} // RVA: 0xBC03F0
        public void .ctor(){} // RVA: 0xA5BFF60
    }

    public class ApiEconomyStatus : ApiModel
    {
        // ── Methods ──
        public void get_EconomyIsOnline(){} // RVA: 0xC10030
        public void set_EconomyIsOnline(){} // RVA: 0xC10040
        public void get_EconomyState(){} // RVA: 0x25406F0
        public void set_EconomyState(){} // RVA: 0x2540700
        public void .ctor(){} // RVA: 0xA5BFFB0
    }

    public class ApiGroupGalleryImage : ApiModel
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_groupId(){} // RVA: 0xC10050
        public void set_groupId(){} // RVA: 0xC10060
        public void get_galleryId(){} // RVA: 0xCD3320
        public void set_galleryId(){} // RVA: 0xCD4740
        public void get_fileId(){} // RVA: 0xCD48B0
        public void set_fileId(){} // RVA: 0xCD3600
        public void get_imageUrl(){} // RVA: 0xB813B0
        public void set_imageUrl(){} // RVA: 0xD5CBB0
        public void get_createdAt(){} // RVA: 0x1069350
        public void set_createdAt(){} // RVA: 0x25687F0
        public void get_approved(){} // RVA: 0x11319D0
        public void set_approved(){} // RVA: 0x112ECB0
        public void get_approvedAt(){} // RVA: 0x106A050
        public void set_approvedAt(){} // RVA: 0x6A6A810
        public void get_approvedByUserId(){} // RVA: 0x12EB090
        public void set_approvedByUserId(){} // RVA: 0x13B1040
        public void get_submittedByUserId(){} // RVA: 0xBAE340
        public void set_submittedByUserId(){} // RVA: 0xBAE350
        public void get_file(){} // RVA: 0xBAE3B0
        public void set_file(){} // RVA: 0xBAE3C0
        public void .ctor(){} // RVA: 0xA5CAF40
    }

    public class ApiGroupInstanceAnnouncement : ApiModel
    {
        // ── Methods ──
        public void get_title(){} // RVA: 0xBBFF90
        public void set_title(){} // RVA: 0xBBFFA0
        public void get_message(){} // RVA: 0xC10050
        public void set_message(){} // RVA: 0xC10060
        public void get_imageId(){} // RVA: 0xCD3320
        public void set_imageId(){} // RVA: 0xCD4740
        public void get_imageVersion(){} // RVA: 0xD34760
        public void set_imageVersion(){} // RVA: 0xD34750
        public void .ctor(){} // RVA: 0xA5C19B0
        public void SendAnnouncement(){} // RVA: 0xA5C1B30
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DB10
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DC80
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiMutualFriend : ApiModel
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0xB5DBF0
        public void set_id(){} // RVA: 0xB44D60
        public void get_displayName(){} // RVA: 0xBBFF90
        public void set_displayName(){} // RVA: 0xBBFFA0
        public void get_status(){} // RVA: 0xC10050
        public void set_status(){} // RVA: 0xC10060
        public void get_statusDescription(){} // RVA: 0xCD3320
        public void set_statusDescription(){} // RVA: 0xCD4740
        public void get_currentAvatarImageUrl(){} // RVA: 0xCD48B0
        public void set_currentAvatarImageUrl(){} // RVA: 0xCD3600
        public void get_avatarThumbnail(){} // RVA: 0xB813B0
        public void set_avatarThumbnail(){} // RVA: 0xD5CBB0
        public void get_currentAvatarTags(){} // RVA: 0x1069350
        public void set_currentAvatarTags(){} // RVA: 0xD5CC10
        public void get_profilePicOverride(){} // RVA: 0x106A7D0
        public void set_profilePicOverride(){} // RVA: 0xD5CC70
        public void get_userIcon(){} // RVA: 0x106A050
        public void set_userIcon(){} // RVA: 0xD5CCD0
        public void get_world(){} // RVA: 0x12EB090
        public void set_world(){} // RVA: 0x13B1040
        public void get_instance(){} // RVA: 0xBAE340
        public void set_instance(){} // RVA: 0xBAE350
        public void get_instanceType(){} // RVA: 0xBAE3B0
        public void set_instanceType(){} // RVA: 0xBAE3C0
        public void get_travelingToWorld(){} // RVA: 0xBAE420
        public void set_travelingToWorld(){} // RVA: 0xBAE430
        public void get_travelingToInstance(){} // RVA: 0xCA4D80
        public void set_travelingToInstance(){} // RVA: 0xCA4D90
        public void get_platform(){} // RVA: 0xC68EB0
        public void set_platform(){} // RVA: 0xC68EC0
        public void get_groups(){} // RVA: 0x135D730
        public void set_groups(){} // RVA: 0xBC5AD0
        public void get_profilePicImageUrl(){} // RVA: 0xA5D11D0
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0xA5D11F0
        public void FetchMutualFriendsAsync(){} // RVA: 0xA5D1220
        public void .ctor(){} // RVA: 0xA5D13F0
    }

    public class ApiMutualGroup : ApiModel
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0xB5DBF0
        public void set_id(){} // RVA: 0xB44D60
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_discriminator(){} // RVA: 0xC10050
        public void set_discriminator(){} // RVA: 0xC10060
        public void get_ownerId(){} // RVA: 0xCD3320
        public void set_ownerId(){} // RVA: 0xCD4740
        public void get_privacy(){} // RVA: 0xCD48B0
        public void set_privacy(){} // RVA: 0xCD3600
        public void get_memberCount(){} // RVA: 0x14780B0
        public void set_memberCount(){} // RVA: 0x147EE80
        public void get_shortCode(){} // RVA: 0x1069350
        public void set_shortCode(){} // RVA: 0xD5CC10
        public void get_description(){} // RVA: 0x106A7D0
        public void set_description(){} // RVA: 0xD5CC70
        public void get_bannerId(){} // RVA: 0x106A050
        public void set_bannerId(){} // RVA: 0xD5CCD0
        public void get_bannerUrl(){} // RVA: 0x12EB090
        public void set_bannerUrl(){} // RVA: 0x13B1040
        public void get_iconId(){} // RVA: 0xBAE340
        public void set_iconId(){} // RVA: 0xBAE350
        public void get_iconUrl(){} // RVA: 0xBAE3B0
        public void set_iconUrl(){} // RVA: 0xBAE3C0
        public void get_lastPostCreatedAt(){} // RVA: 0xBAE420
        public void set_lastPostCreatedAt(){} // RVA: 0xBAE430
        public void FetchMutualGroupsAsync(){} // RVA: 0xA5D20E0
        public void .ctor(){} // RVA: 0xA5D22B0
    }

    public class ApiPlayerModeration[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiSharedConnectionCounts : ApiModel
    {
        // ── Methods ──
        public void get_CacheLifetime(){} // RVA: 0xA5D2FA0
        public void get_friends(){} // RVA: 0x2536460
        public void set_friends(){} // RVA: 0x25406E0
        public void get_groups(){} // RVA: 0x25406F0
        public void set_groups(){} // RVA: 0x2540700
        public void FetchSharedConnectionCountsAsync(){} // RVA: 0xA5D3090
        public void GetLifeSpan(){} // RVA: 0xA5D2FA0
        public void .ctor(){} // RVA: 0xA5D3240
    }

    public class ApiStoreShelf : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5CD7F0
        public void get_ShelfTitle(){} // RVA: 0xBBFF90
        public void set_ShelfTitle(){} // RVA: 0xBBFFA0
        public void get_ShelfDescription(){} // RVA: 0xC10050
        public void set_ShelfDescription(){} // RVA: 0xC10060
        public void get_ShelfLayout(){} // RVA: 0xCD3320
        public void set_ShelfLayout(){} // RVA: 0xCD4740
        public void get_UpdatedAt(){} // RVA: 0xCD48B0
        public void set_UpdatedAt(){} // RVA: 0x278E9B0
        public void get_CreatedAt(){} // RVA: 0xB813B0
        public void set_CreatedAt(){} // RVA: 0x13AA640
        public void get_ListingIds(){} // RVA: 0x1069350
        public void set_ListingIds(){} // RVA: 0xD5CC10
        public void get_ShelfVisibility(){} // RVA: 0x106A7D0
        public void set_ShelfVisibility(){} // RVA: 0xD5CC70
        public void get_StoreId(){} // RVA: 0x106A050
        public void set_StoreId(){} // RVA: 0xD5CCD0
        public void get_SellerId(){} // RVA: 0x12EB090
        public void set_SellerId(){} // RVA: 0x13B1040
        public void get_HighlightListingId(){} // RVA: 0xBAE340
        public void set_HighlightListingId(){} // RVA: 0xBAE350
        public void get_ShelfTabBackgroundImageId(){} // RVA: 0xBAE3B0
        public void set_ShelfTabBackgroundImageId(){} // RVA: 0xBAE3C0
        public void get_ShelfTabBackgroundImageUrl(){} // RVA: 0xA57B660
        public void get_ShelfBackgroundImageId(){} // RVA: 0xBAE420
        public void set_ShelfBackgroundImageId(){} // RVA: 0xBAE430
        public void get_ShelfBackgroundImageUrl(){} // RVA: 0xA5CD840
        public void get_ShelfIconImageId(){} // RVA: 0xCA4D80
        public void set_ShelfIconImageId(){} // RVA: 0xCA4D90
        public void get_ShelfIconImageUrl(){} // RVA: 0xA5CD880
        public void get_Listings(){} // RVA: 0xC68EB0
        public void set_Listings(){} // RVA: 0xC68EC0
        public void get_HighlightListing(){} // RVA: 0x135D730
        public void set_HighlightListing(){} // RVA: 0xBC5AD0
    }

}