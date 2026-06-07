// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 100
// Methods: 2019

namespace VRC.Core
{
    public class API
    {
        // ── Methods ──
        public void get_ClientGameServerVersion(){} // RVA: 0x9851580
        public void .cctor(){} // RVA: 0x98515E0
        public void RegisterLogging(){} // RVA: 0x9851B30
        public void SetClientVersion(){} // RVA: 0x9851BE0
        public void GetClientVersion(){} // RVA: 0x9851CA0
        public void SetStore(){} // RVA: 0x9851D00
        public void GetStore(){} // RVA: 0x9851DC0
        public void SetAllowRoaming(){} // RVA: 0x9851E20
        public void GetAllowRoaming(){} // RVA: 0x9851E80
        public void SetClientGameServerVersion(){} // RVA: 0x9851EE0
        public void IsReady(){} // RVA: 0x9851F40
        public void FromCacheOrNew(){} // RVA: 0x283FA0
        public void CreateFromJson(){} // RVA: 0x283FA0
        public void Fetch(){} // RVA: 0x283FA0
        public void FetchAsync(){} // RVA: 0x1D930
        public void DeleteAsync(){} // RVA: 0xCE50
        public void Delete(){} // RVA: 0x2A310
        public void get_DeviceID(){} // RVA: 0x6380700
        public void SetApiUrlFromEnvironment(){} // RVA: 0x9851FE0
        public void GetApiUrlForEnvironment(){} // RVA: 0x98521E0
        public void SetApiUrl(){} // RVA: 0x9852310
        public void GetApiUrl(){} // RVA: 0x98523C0
        public void IsDevApi(){} // RVA: 0x9852420
        public void IsDevCeApi(){} // RVA: 0x9852500
        public void SendGetRequest(){} // RVA: 0x98525E0
        public void SendPostRequest(){} // RVA: 0x9852700
        public void SendPostFormRequest(){} // RVA: 0x9852820
        public void SendPostRawJsonRequest(){} // RVA: 0x9852940
        public void SendPutRequest(){} // RVA: 0x9852A60
        public void SendDeleteRequest(){} // RVA: 0x9852B80
        public void SendRequest(){} // RVA: 0x9852CA0
        public void SendRequestInternal(){} // RVA: 0x98533D0
        public void AuthenticateHTTPRequest(){} // RVA: 0x9854970
        public void AuthenticateUnityWebRequest(){} // RVA: 0x9854DE0
        public void PopulateHTTPRequestHeaders(){} // RVA: 0x9855130
        public void PopulateUnityWebRequestHeaders(){} // RVA: 0x98555C0
        public void CertVerifyHTTPRequest(){} // RVA: 0x9855890
        public void CertVerifyUnityWebRequest(){} // RVA: 0x9855A40
        public void InitializeCertificateVerifier(){} // RVA: 0x9855D00
        public void AppendQuery(){} // RVA: 0x9855E30
        public void ConvertJsonListToModelList(){} // RVA: 0xCEC0
        public void get_IsVRCClient(){} // RVA: 0x9855EE0
        public void set_IsVRCClient(){} // RVA: 0x9855F40
        public void SetOnlineMode(){} // RVA: 0x9855FA0
        public void ClearOnlineMode(){} // RVA: 0x9856370
        public void IsOffline(){} // RVA: 0x9856420
        public void GetServerEnvironmentForApiUrl(){} // RVA: 0x98564E0 | overloaded x2
        public void SendOfflineRequest(){} // RVA: 0x98567A0
        public void GenerateMergeCode(){} // RVA: 0x9856E70
    }

    public class API2FA
    {
        // ── Methods ──
        public void get_requiresTwoFactorAuth(){} // RVA: 0x358D50
        public void set_requiresTwoFactorAuth(){} // RVA: 0x358D60
        public void get_scope(){} // RVA: 0x3A5590
        public void set_scope(){} // RVA: 0x3A55A0
        public void get_ticket(){} // RVA: 0x4C7C50
        public void set_ticket(){} // RVA: 0x4C34F0
        public void TimeBasedOneTimePasswordSupported(){} // RVA: 0x9857AC0
        public void EmailBasedOneTimePasswordSupported(){} // RVA: 0x9857B20
        public void OneTimePasswordSupported(){} // RVA: 0x9857B80
        public void SmsSupported(){} // RVA: 0x9857BE0
        public void ToString(){} // RVA: 0x9857C40
        public void .ctor(){} // RVA: 0x9857EA0
    }

    public class APIActivationSuccessfulTargetResult
    {
        // ── Methods ──
        public void get_userId(){} // RVA: 0x358D50
        public void set_userId(){} // RVA: 0x358D60
        public void get_gifts(){} // RVA: 0x10E5CF0
        public void set_gifts(){} // RVA: 0x475080
        public void get_isFriend(){} // RVA: 0x1120170
        public void set_isFriend(){} // RVA: 0x5A2DFE0
        public void .ctor(){} // RVA: 0x9874100
    }

    public class APICalendarEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9915E30
        public void get_ownerId(){} // RVA: 0x358D50
        public void set_ownerId(){} // RVA: 0x358D60
        public void get_accessType(){} // RVA: 0x10E5CF0
        public void set_accessType(){} // RVA: 0x475080
        public void get_startsAt(){} // RVA: 0x4C7C50
        public void set_startsAt(){} // RVA: 0x5AAF010
        public void get_endsAt(){} // RVA: 0x462D00
        public void set_endsAt(){} // RVA: 0x1F0ABA0
        public void get_title(){} // RVA: 0x31C010
        public void set_title(){} // RVA: 0x463060
        public void get_description(){} // RVA: 0x796DE0
        public void set_description(){} // RVA: 0xB54600
        public void get_category(){} // RVA: 0xA1C8C0
        public void set_category(){} // RVA: 0x9AA650
        public void get_shortCode(){} // RVA: 0xA085E0
        public void set_shortCode(){} // RVA: 0x9AA5F0
        public void get_type(){} // RVA: 0xA1C130
        public void set_type(){} // RVA: 0xAE5030
        public void get_isDraft(){} // RVA: 0x17323D0
        public void set_isDraft(){} // RVA: 0x1735610
        public void get_imageId(){} // RVA: 0x3480B0
        public void set_imageId(){} // RVA: 0x3480C0
        public void get_imageUrl(){} // RVA: 0x348120
        public void set_imageUrl(){} // RVA: 0x348130
        public void get_roleIds(){} // RVA: 0x435460
        public void set_roleIds(){} // RVA: 0x435470
        public void get_tags(){} // RVA: 0x3FA100
        public void set_tags(){} // RVA: 0x3FA110
        public void get_platforms(){} // RVA: 0xA96D30
        public void set_platforms(){} // RVA: 0x35E8A0
        public void get_languages(){} // RVA: 0x35E900
        public void set_languages(){} // RVA: 0x35E910
        public void get_parentId(){} // RVA: 0x35E970
        public void set_parentId(){} // RVA: 0x35E980
        public void get_hostEarlyJoinMinutes(){} // RVA: 0x3739380
        public void set_hostEarlyJoinMinutes(){} // RVA: 0x627A290
        public void get_guestEarlyJoinMinutes(){} // RVA: 0x3DF1880
        public void set_guestEarlyJoinMinutes(){} // RVA: 0x3DF1890
        public void get_closeInstanceAfterEndMinutes(){} // RVA: 0x72D6570
        public void set_closeInstanceAfterEndMinutes(){} // RVA: 0x9439450
        public void get_usesInstanceOverflow(){} // RVA: 0x98C5AF0
        public void set_usesInstanceOverflow(){} // RVA: 0x98C5B00
        public void get_deletedAt(){} // RVA: 0xA94E10
        public void set_deletedAt(){} // RVA: 0x1702E00
        public void get_userInterest(){} // RVA: 0xA902E0
        public void set_userInterest(){} // RVA: 0xCF4780
        public void get_featured(){} // RVA: 0x66C530
        public void set_featured(){} // RVA: 0x66C8F0
        public void get_interestedUserCount(){} // RVA: 0x6FACBE0
        public void set_interestedUserCount(){} // RVA: 0x6FACBF0
        public void UpdateData(){} // RVA: 0x9915E80
        public void WriteField(){} // RVA: 0x9916640
    }

    public class APICalendarEntryUserInterest
    {
        // ── Methods ──
        public void get_isFollowing(){} // RVA: 0x3A5570
        public void set_isFollowing(){} // RVA: 0x3A5580
        public void get_createdAt(){} // RVA: 0x3A5590
        public void set_createdAt(){} // RVA: 0x1F0AB80
        public void get_updatedAt(){} // RVA: 0x4C7C50
        public void set_updatedAt(){} // RVA: 0x5AAF010
        public void .ctor(){} // RVA: 0x9916AD0
    }

    public class APIEmoji
    {
        // ── Methods ──
        public void get_fileId(){} // RVA: 0x358D50
        public void set_fileId(){} // RVA: 0x358D60
        public void get_imageUrl(){} // RVA: 0x3A5590
        public void set_imageUrl(){} // RVA: 0x3A55A0
        public void get_animationStyle(){} // RVA: 0x4C7C50
        public void set_animationStyle(){} // RVA: 0x4C34F0
        public void get_maskTag(){} // RVA: 0x462D00
        public void set_maskTag(){} // RVA: 0x464450
        public void get_animated(){} // RVA: 0x1342AB0
        public void set_animated(){} // RVA: 0x10F2C40
        public void get_frames(){} // RVA: 0x363A7C0
        public void set_frames(){} // RVA: 0x3C7AFE0
        public void get_framesOverTime(){} // RVA: 0x6AFD40
        public void set_framesOverTime(){} // RVA: 0xF02F80
        public void get_loopStyle(){} // RVA: 0xA1C8C0
        public void set_loopStyle(){} // RVA: 0x9AA650
        public void get_assetBundleId(){} // RVA: 0xA085E0
        public void set_assetBundleId(){} // RVA: 0x9AA5F0
        public void get_premium(){} // RVA: 0x5A6180
        public void set_premium(){} // RVA: 0x59E530
        public void UploadEmoji(){} // RVA: 0x9869E40 | overloaded x2
        public void Fetch(){} // RVA: 0x986A4A0
        public void .ctor(){} // RVA: 0x986A7D0
        public void <Fetch>g__ParseData|45_0(){} // RVA: 0x986A840
    }

    public class APIGiftActivationResult
    {
        // ── Methods ──
        public void get_dropValidationToken(){} // RVA: 0x358D50
        public void set_dropValidationToken(){} // RVA: 0x358D60
        public void get_giftValidationToken(){} // RVA: 0x3A5590
        public void set_giftValidationToken(){} // RVA: 0x3A55A0
        public void get_successfulGifts(){} // RVA: 0x4C7C50
        public void set_successfulGifts(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x98740B0
    }

    public class APIGiftBundle
    {
        // ── Methods ──
        public void get_steamItemId(){} // RVA: 0x358D50
        public void set_steamItemId(){} // RVA: 0x358D60
        public void get_oculusSku(){} // RVA: 0x3A5590
        public void set_oculusSku(){} // RVA: 0x3A55A0
        public void get_googleProductId(){} // RVA: 0x4C7C50
        public void set_googleProductId(){} // RVA: 0x4C34F0
        public void get_googlePlanId(){} // RVA: 0x462D00
        public void set_googlePlanId(){} // RVA: 0x464450
        public void get_picoSku(){} // RVA: 0x31C010
        public void set_picoSku(){} // RVA: 0x463060
        public void get_amount(){} // RVA: 0x6AFD40
        public void set_amount(){} // RVA: 0xF02F80
        public void get_description(){} // RVA: 0xA1C8C0
        public void set_description(){} // RVA: 0x9AA650
        public void get_period(){} // RVA: 0xA085E0
        public void set_period(){} // RVA: 0x9AA5F0
        public void get_periodAmount(){} // RVA: 0xCC3CB0
        public void set_periodAmount(){} // RVA: 0xCC9310
        public void get_tier(){} // RVA: 0x3C49C20
        public void set_tier(){} // RVA: 0x3C49C30
        public void get_bulkSize(){} // RVA: 0x20D67F0
        public void set_bulkSize(){} // RVA: 0x601E410
        public void get_discountPercentage(){} // RVA: 0x3DF1350
        public void set_discountPercentage(){} // RVA: 0x3DF1360
        public void get_licenseGroups(){} // RVA: 0x3480B0
        public void set_licenseGroups(){} // RVA: 0x3480C0
        public void .ctor(){} // RVA: 0x9874010
    }

    public class APIGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x991A5F0 | overloaded x2
        public void get_ownerId(){} // RVA: 0x358D50
        public void set_ownerId(){} // RVA: 0x358D60
        public void get_name(){} // RVA: 0x3A5590
        public void set_name(){} // RVA: 0x3A55A0
        public void get_shortCode(){} // RVA: 0x4C7C50
        public void set_shortCode(){} // RVA: 0x4C34F0
        public void get_discriminator(){} // RVA: 0x462D00
        public void set_discriminator(){} // RVA: 0x464450
        public void get_description(){} // RVA: 0x31C010
        public void set_description(){} // RVA: 0x463060
        public void get_iconUrl(){} // RVA: 0x796DE0
        public void set_iconUrl(){} // RVA: 0xB54600
        public void get_bannerUrl(){} // RVA: 0xA1C8C0
        public void set_bannerUrl(){} // RVA: 0x9AA650
        public void get_memberCount(){} // RVA: 0x1D76590
        public void set_memberCount(){} // RVA: 0x1D76550
        public void get_onlineMemberCount(){} // RVA: 0x3C49C00
        public void set_onlineMemberCount(){} // RVA: 0x3C49C10
        public void get_memberCountSyncedAt(){} // RVA: 0xA1C130
        public void set_memberCountSyncedAt(){} // RVA: 0xAE5030
        public void get_privacy(){} // RVA: 0x348040
        public void set_privacy(){} // RVA: 0x348050
        public void get_joinState(){} // RVA: 0x3480B0
        public void set_joinState(){} // RVA: 0x3480C0
        public void get_myMember(){} // RVA: 0x348120
        public void set_myMember(){} // RVA: 0x348130
        public void get_createdAt(){} // RVA: 0x435460
        public void set_createdAt(){} // RVA: 0x8B8A2E0
        public void get_updatedAt(){} // RVA: 0x3FA100
        public void set_updatedAt(){} // RVA: 0x68D4D30
        public void get_membershipStatus(){} // RVA: 0xA96D30
        public void set_membershipStatus(){} // RVA: 0x35E8A0
        public void get_bannerId(){} // RVA: 0x35E900
        public void set_bannerId(){} // RVA: 0x35E910
        public void get_iconId(){} // RVA: 0x35E970
        public void set_iconId(){} // RVA: 0x35E980
        public void get_rules(){} // RVA: 0x3482A0
        public void set_rules(){} // RVA: 0x3482B0
        public void get_initialRoleIds(){} // RVA: 0x7F7DB0
        public void set_initialRoleIds(){} // RVA: 0x63D280
        public void get_isSystemGroup(){} // RVA: 0x12108C0
        public void set_isSystemGroup(){} // RVA: 0x120E9D0
        public void get_isVerified(){} // RVA: 0x1B6CE60
        public void set_isVerified(){} // RVA: 0x1B6CD60
        public void get_galleries(){} // RVA: 0xA902E0
        public void set_galleries(){} // RVA: 0xCF4780
        public void get_tags(){} // RVA: 0x507710
        public void set_tags(){} // RVA: 0x509930
        public void get_isSearchable(){} // RVA: 0x98C15A0
        public void set_isSearchable(){} // RVA: 0x98C15B0
        public void get_sizeQuality(){} // RVA: 0x7363390
        public void set_sizeQuality(){} // RVA: 0x73633A0
        public void get_activityQuality(){} // RVA: 0xD19990
        public void set_activityQuality(){} // RVA: 0x627A2A0
        public void get_engagementQuality(){} // RVA: 0x613D7A0
        public void set_engagementQuality(){} // RVA: 0x613D7B0
        public void get_contentQuality(){} // RVA: 0x627A640
        public void set_contentQuality(){} // RVA: 0x627A650
        public void get_roles(){} // RVA: 0xA8E870
        public void set_roles(){} // RVA: 0xDA3F70
        public void get_links(){} // RVA: 0xA933D0
        public void set_links(){} // RVA: 0xA96DC0
        public void get_languages(){} // RVA: 0x3485F0
        public void set_languages(){} // RVA: 0x348600
        public void get_lastPostCreatedAt(){} // RVA: 0x348660
        public void set_lastPostCreatedAt(){} // RVA: 0x629CBE0
        public void get_storeId(){} // RVA: 0x9FE130
        public void set_storeId(){} // RVA: 0xD8E9B0
        public void UpdateData(){} // RVA: 0x991AC10
        public void GetGroup(){} // RVA: 0x991B680
        public void FetchAllData(){} // RVA: 0x991B880
        public void RequestToJoin(){} // RVA: 0x991BD20
        public void LeaveGroup(){} // RVA: 0x991C0E0
        public void GetGroupInvites(){} // RVA: 0x991C460
        public void InviteUser(){} // RVA: 0x991C8E0
        public void BanUser(){} // RVA: 0x991CD10
        public void GetMembers(){} // RVA: 0x991D140
        public void GetGroupCapacity(){} // RVA: 0x991D710
        public void SetRepresentation(){} // RVA: 0x991D830
        public void GetGroupGalleryImages(){} // RVA: 0x991DCC0
        public void GetGroupProducts(){} // RVA: 0x991E7E0
        public void GetGroupAnnouncements(){} // RVA: 0x991EC20
        public void SetAnnouncementSubscription(){} // RVA: 0x991F1A0
        public void SetEventAnnouncementSubscription(){} // RVA: 0x991F600
        public void GetUsingShortCode(){} // RVA: 0x991FA60
        public void StrictSearch(){} // RVA: 0x991FD80
        public void GetActiveGroupInstances(){} // RVA: 0x99201F0
        public void GetRoles(){} // RVA: 0x9920650
        public void GetAllGroupPermissions(){} // RVA: 0x9920A70
        public void GetGroupPermissions(){} // RVA: 0x9920DA0
        public void ExtractPermissions(){} // RVA: 0x9921210
    }

    public class APIGroupAnnouncement
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x358D50
        public void set_groupId(){} // RVA: 0x358D60
        public void get_authorId(){} // RVA: 0x3A5590
        public void set_authorId(){} // RVA: 0x3A55A0
        public void get_title(){} // RVA: 0x4C7C50
        public void set_title(){} // RVA: 0x4C34F0
        public void get_text(){} // RVA: 0x462D00
        public void set_text(){} // RVA: 0x464450
        public void get_imageUrl(){} // RVA: 0x31C010
        public void set_imageUrl(){} // RVA: 0x463060
        public void get_visibility(){} // RVA: 0x796DE0
        public void set_visibility(){} // RVA: 0xB54600
        public void get_createdAt(){} // RVA: 0xA1C8C0
        public void set_createdAt(){} // RVA: 0x5774BB0
        public void get_updatedAt(){} // RVA: 0xA085E0
        public void set_updatedAt(){} // RVA: 0x5FF62E0
        public void get_roleIds(){} // RVA: 0xA1C130
        public void set_roleIds(){} // RVA: 0xAE5030
        public void SetLastPostReadAt(){} // RVA: 0x9922D00
        public void .ctor(){} // RVA: 0x9923110
    }

    public class APIGroupInstance
    {
        // ── Methods ──
        public void BuildRequest(){} // RVA: 0x99231B0
        public void .ctor(){} // RVA: 0x9923480
    }

    public class APIGroupInvite
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x358D50
        public void set_groupId(){} // RVA: 0x358D60
        public void get_userId(){} // RVA: 0x3A5590
        public void set_userId(){} // RVA: 0x3A55A0
        public void get_state(){} // RVA: 0x4C7C50
        public void set_state(){} // RVA: 0x4C34F0
        public void CancelRequest(){} // RVA: 0x9922970
        public void .ctor(){} // RVA: 0x9922C60
    }

    public class APIGroupJoinResponse
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x358D50
        public void set_groupId(){} // RVA: 0x358D60
        public void get_userId(){} // RVA: 0x3A5590
        public void set_userId(){} // RVA: 0x3A55A0
        public void get_createdAt(){} // RVA: 0x4C7C50
        public void set_createdAt(){} // RVA: 0x5AAF010
        public void get_isOnProfile(){} // RVA: 0x5A8B10
        public void set_isOnProfile(){} // RVA: 0x5A6190
        public void get_isOnNameplate(){} // RVA: 0x59F730
        public void set_isOnNameplate(){} // RVA: 0x5A1140
        public void get_joinedAt(){} // RVA: 0x31C010
        public void set_joinedAt(){} // RVA: 0xADF010
        public void get_updatedAt(){} // RVA: 0x796DE0
        public void set_updatedAt(){} // RVA: 0x1CBA190
        public void get_isActive(){} // RVA: 0x86DB40
        public void set_isActive(){} // RVA: 0x86DB50
        public void get_requestedJoin(){} // RVA: 0x86B8D0
        public void set_requestedJoin(){} // RVA: 0x61BEF40
        public void get_inviteId(){} // RVA: 0xA085E0
        public void set_inviteId(){} // RVA: 0x9AA5F0
        public void .ctor(){} // RVA: 0x9922920
    }

    public class APIGroupList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9923620 | overloaded x2
    }

    public class APIGroupLocations
    {
        // ── Methods ──
        public void get_fetchedAt(){} // RVA: 0x358D50
        public void set_fetchedAt(){} // RVA: 0x1F0AB90
        public void get_instances(){} // RVA: 0x3A5590
        public void set_instances(){} // RVA: 0x3A55A0
        public void GetLocations(){} // RVA: 0x9923710
        public void .ctor(){} // RVA: 0x9923A50
    }

    public class APIGroupMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9923F00
        public void get_groupId(){} // RVA: 0x358D50
        public void set_groupId(){} // RVA: 0x358D60
        public void get_userId(){} // RVA: 0x3A5590
        public void set_userId(){} // RVA: 0x3A55A0
        public void get_roleIds(){} // RVA: 0x4C7C50
        public void set_roleIds(){} // RVA: 0x4C34F0
        public void get_mRoleIds(){} // RVA: 0x462D00
        public void set_mRoleIds(){} // RVA: 0x464450
        public void get_permissions(){} // RVA: 0x31C010
        public void set_permissions(){} // RVA: 0x463060
        public void get_memberVisibility(){} // RVA: 0x796DE0
        public void set_memberVisibility(){} // RVA: 0xB54600
        public void get_membershipStatus(){} // RVA: 0xA1C8C0
        public void set_membershipStatus(){} // RVA: 0x9AA650
        public void get_isRepresenting(){} // RVA: 0x1B6CD50
        public void set_isRepresenting(){} // RVA: 0xB70090
        public void get_mutualGroup(){} // RVA: 0x1D23080
        public void set_mutualGroup(){} // RVA: 0x1D23090
        public void get_name(){} // RVA: 0xA1C130
        public void set_name(){} // RVA: 0xAE5030
        public void get_ownerId(){} // RVA: 0x348040
        public void set_ownerId(){} // RVA: 0x348050
        public void get_shortCode(){} // RVA: 0x3480B0
        public void set_shortCode(){} // RVA: 0x3480C0
        public void get_discriminator(){} // RVA: 0x348120
        public void set_discriminator(){} // RVA: 0x348130
        public void get_iconUrl(){} // RVA: 0x435460
        public void set_iconUrl(){} // RVA: 0x435470
        public void get_bannerUrl(){} // RVA: 0x3FA100
        public void set_bannerUrl(){} // RVA: 0x3FA110
        public void get_privacy(){} // RVA: 0xA96D30
        public void set_privacy(){} // RVA: 0x35E8A0
        public void get_visibility(){} // RVA: 0x35E900
        public void set_visibility(){} // RVA: 0x35E910
        public void get_isSubscribedToAnnouncements(){} // RVA: 0x152E150
        public void set_isSubscribedToAnnouncements(){} // RVA: 0x18A9FF0
        public void get_isSubscribedToEventAnnouncements(){} // RVA: 0x66AC3A0
        public void set_isSubscribedToEventAnnouncements(){} // RVA: 0x98C6CD0
        public void get_memberCount(){} // RVA: 0x1CA9B70
        public void set_memberCount(){} // RVA: 0x627A280
        public void get_joinedAt(){} // RVA: 0x3482A0
        public void set_joinedAt(){} // RVA: 0x63CFBB0
        public void get_bannedAt(){} // RVA: 0x7F7DB0
        public void set_bannedAt(){} // RVA: 0x3DF18C0
        public void get_lastPostReadAt(){} // RVA: 0xA94E10
        public void set_lastPostReadAt(){} // RVA: 0x1702E00
        public void get_lastPostCreatedAt(){} // RVA: 0xA902E0
        public void set_lastPostCreatedAt(){} // RVA: 0x507D00
        public void get_user(){} // RVA: 0x507710
        public void set_user(){} // RVA: 0x509930
        public void get_group(){} // RVA: 0x507D10
        public void set_group(){} // RVA: 0x50A8C0
        public void GetMemberships(){} // RVA: 0x9923F60
        public void SetVisibility(){} // RVA: 0x9924340
        public void FetchGroup(){} // RVA: 0x9924800
        public void GetRepresentation(){} // RVA: 0x9924B50
    }

    public class APIGroupMemberList
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x358D50
        public void set_groupId(){} // RVA: 0x358D60
        public void get_members(){} // RVA: 0x3A5590
        public void set_members(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x99252E0 | overloaded x2
    }

    public class APIGroupPosts
    {
        // ── Methods ──
        public void get_total(){} // RVA: 0x1C91440
        public void set_total(){} // RVA: 0x1C91450
        public void get_posts(){} // RVA: 0x3A5590
        public void set_posts(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9922CB0
    }

    public class APIGroupRole
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x358D50
        public void set_groupId(){} // RVA: 0x358D60
        public void get_name(){} // RVA: 0x3A5590
        public void set_name(){} // RVA: 0x3A55A0
        public void get_description(){} // RVA: 0x4C7C50
        public void set_description(){} // RVA: 0x4C34F0
        public void get_isSelfAssignable(){} // RVA: 0x5A8B10
        public void set_isSelfAssignable(){} // RVA: 0x5A6190
        public void get_requiresTwoFactor(){} // RVA: 0x59F730
        public void set_requiresTwoFactor(){} // RVA: 0x5A1140
        public void get_isManagementRole(){} // RVA: 0x113C490
        public void set_isManagementRole(){} // RVA: 0x5F99000
        public void get_requiresPurchase(){} // RVA: 0x151A520
        public void set_requiresPurchase(){} // RVA: 0x5FF60A0
        public void get_createdAt(){} // RVA: 0x31C010
        public void set_createdAt(){} // RVA: 0xADF010
        public void get_updatedAt(){} // RVA: 0x796DE0
        public void set_updatedAt(){} // RVA: 0x1CBA190
        public void get_defaultRole(){} // RVA: 0x86DB40
        public void set_defaultRole(){} // RVA: 0x86DB50
        public void get_order(){} // RVA: 0x1D76560
        public void set_order(){} // RVA: 0x1D76580
        public void get_permissions(){} // RVA: 0xA085E0
        public void set_permissions(){} // RVA: 0x9AA5F0
        public void .ctor(){} // RVA: 0x9925440 | overloaded x2
    }

    public class APIGroupRoleList
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x358D50
        public void set_groupId(){} // RVA: 0x358D60
        public void get_roles(){} // RVA: 0x3A5590
        public void set_roles(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9925750 | overloaded x2
    }

    public class APIProductGifting
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class APIProductGiftingCheck
    {
        // ── Methods ──
        public void get_Eligible(){} // RVA: 0x3A5570
        public void set_Eligible(){} // RVA: 0x3A5580
        public void get_Reason(){} // RVA: 0x3A5590
        public void set_Reason(){} // RVA: 0x3A55A0
        public void get_EligibleProducts(){} // RVA: 0x4C7C50
        public void set_EligibleProducts(){} // RVA: 0x4C34F0
        public void get_IneligibleProducts(){} // RVA: 0x462D00
        public void set_IneligibleProducts(){} // RVA: 0x464450
        public void Check(){} // RVA: 0x98C4B40
        public void .ctor(){} // RVA: 0x98C5110
    }

    public class APIPurchasedGiftBundle
    {
        // ── Methods ──
        public void get_transactionId(){} // RVA: 0x358D50
        public void set_transactionId(){} // RVA: 0x358D60
        public void get_store(){} // RVA: 0x3A5590
        public void set_store(){} // RVA: 0x3A55A0
        public void get_steamItemId(){} // RVA: 0x4C7C50
        public void set_steamItemId(){} // RVA: 0x4C34F0
        public void get_oculusSku(){} // RVA: 0x462D00
        public void set_oculusSku(){} // RVA: 0x464450
        public void get_googleProductId(){} // RVA: 0x31C010
        public void set_googleProductId(){} // RVA: 0x463060
        public void get_googlePlanId(){} // RVA: 0x796DE0
        public void set_googlePlanId(){} // RVA: 0xB54600
        public void get_picoSku(){} // RVA: 0xA1C8C0
        public void set_picoSku(){} // RVA: 0x9AA650
        public void get_amount(){} // RVA: 0x1D76590
        public void set_amount(){} // RVA: 0x1D76550
        public void get_description(){} // RVA: 0xA1C130
        public void set_description(){} // RVA: 0xAE5030
        public void get_period(){} // RVA: 0x348040
        public void set_period(){} // RVA: 0x348050
        public void get_consumed(){} // RVA: 0x173F990
        public void set_consumed(){} // RVA: 0x173EC00
        public void get_status(){} // RVA: 0x348120
        public void set_status(){} // RVA: 0x348130
        public void get_created_at(){} // RVA: 0x435460
        public void set_created_at(){} // RVA: 0x435470
        public void get_updated_at(){} // RVA: 0x3FA100
        public void set_updated_at(){} // RVA: 0x3FA110
        public void get_isBulkGift(){} // RVA: 0x12FD610
        public void set_isBulkGift(){} // RVA: 0x612FB20
        public void get_targets(){} // RVA: 0x35E900
        public void set_targets(){} // RVA: 0x35E910
        public void get_bulkSize(){} // RVA: 0x1CAC8F0
        public void set_bulkSize(){} // RVA: 0x627A3B0
        public void get_discountPercentage(){} // RVA: 0x1CA9B70
        public void set_discountPercentage(){} // RVA: 0x627A280
        public void get_totalConsumed(){} // RVA: 0x3739380
        public void set_totalConsumed(){} // RVA: 0x627A290
        public void get_totalUnconsumed(){} // RVA: 0x3DF1880
        public void set_totalUnconsumed(){} // RVA: 0x3DF1890
        public void get_failures(){} // RVA: 0x72D6570
        public void set_failures(){} // RVA: 0x9439450
        public void .ctor(){} // RVA: 0x9874060
    }

    public class APIQueue
    {
        // ── Methods ──
        public void JoinQueue(){} // RVA: 0x98CA420
        public void SetQueue(){} // RVA: 0x2DEE30 | overloaded x2
        public void LeaveQueue(){} // RVA: 0x98CA890
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class APIResponseHandler
    {
        // ── Methods ──
        public void HandleResponse(){} // RVA: 0x98CD9C0
        public void extractResponseErrorMessage(){} // RVA: 0x98CDBF0
        public void RetryRequest(){} // RVA: 0x98CDD60
        public void .cctor(){} // RVA: 0x98CE4D0
    }

    public class APISticker
    {
        // ── Methods ──
        public void get_fileId(){} // RVA: 0x358D50
        public void set_fileId(){} // RVA: 0x358D60
        public void get_imageUrl(){} // RVA: 0x3A5590
        public void set_imageUrl(){} // RVA: 0x3A55A0
        public void get_specialEffect(){} // RVA: 0x4C7C50
        public void set_specialEffect(){} // RVA: 0x4C34F0
        public void get_animationStyle(){} // RVA: 0x462D00
        public void set_animationStyle(){} // RVA: 0x464450
        public void get_maskTag(){} // RVA: 0x31C010
        public void set_maskTag(){} // RVA: 0x463060
        public void get_animated(){} // RVA: 0x134A670
        public void set_animated(){} // RVA: 0x1348E00
        public void get_frames(){} // RVA: 0x6AFD30
        public void set_frames(){} // RVA: 0x8DF350
        public void get_framesOverTime(){} // RVA: 0x1D76570
        public void set_framesOverTime(){} // RVA: 0x1D76000
        public void get_loopStyle(){} // RVA: 0xA085E0
        public void set_loopStyle(){} // RVA: 0x9AA5F0
        public void get_assetBundleId(){} // RVA: 0xA1C130
        public void set_assetBundleId(){} // RVA: 0xAE5030
        public void UploadSticker(){} // RVA: 0x98D2240 | overloaded x2
        public void .ctor(){} // RVA: 0x98D2850
    }

    public class APISubscription
    {
        // ── Methods ──
        public void get_response(){} // RVA: 0x358D50
        public void set_response(){} // RVA: 0x358D60
        public void .ctor(){} // RVA: 0x98D2A00
    }

    public class APITutorial
    {
        // ── Methods ──
        public void get_IsTutorialCompleted(){} // RVA: 0x3A5570
        public void set_IsTutorialCompleted(){} // RVA: 0x3A5580
        public void get_CompletedAnyTutorial(){} // RVA: 0x4EC4D70
        public void set_CompletedAnyTutorial(){} // RVA: 0x4EC47C0
        public void get_TutorialKey(){} // RVA: 0x3A5590
        public void set_TutorialKey(){} // RVA: 0x3A55A0
        public void LoadTutorial(){} // RVA: 0x98D5330
        public void .ctor(){} // RVA: 0x98D5640
    }

    public class APIUIColorPalette
    {
        // ── Methods ──
        public void get_ownerId(){} // RVA: 0x358D50
        public void set_ownerId(){} // RVA: 0x358D60
        public void get_name(){} // RVA: 0x3A5590
        public void set_name(){} // RVA: 0x3A55A0
        public void get_highlights(){} // RVA: 0x4C7C50
        public void set_highlights(){} // RVA: 0x4C34F0
        public void get_icons(){} // RVA: 0x462D00
        public void set_icons(){} // RVA: 0x464450
        public void get_buttons(){} // RVA: 0x31C010
        public void set_buttons(){} // RVA: 0x463060
        public void get_backgrounds(){} // RVA: 0x796DE0
        public void set_backgrounds(){} // RVA: 0xB54600
        public void get_text(){} // RVA: 0xA1C8C0
        public void set_text(){} // RVA: 0x9AA650
        public void get_subtext(){} // RVA: 0xA085E0
        public void set_subtext(){} // RVA: 0x9AA5F0
        public void Fetch(){} // RVA: 0x98D57E0
        public void Save(){} // RVA: 0x98D5B90
        public void GetCurrent(){} // RVA: 0x98D6470
        public void SetCurrent(){} // RVA: 0x98D6750
        public void Update(){} // RVA: 0x98D6B40
        public void .ctor(){} // RVA: 0x98D6E80
        public void .cctor(){} // RVA: 0x98D6ED0
    }

    public class APIUser
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x98D71D0
        public void GetLifeSpan(){} // RVA: 0x135ED20
        public void get_blob(){} // RVA: 0x358D50
        public void set_blob(){} // RVA: 0x358D60
        public void get_displayName(){} // RVA: 0x3A5590
        public void set_displayName(){} // RVA: 0x3A55A0
        public void get_username(){} // RVA: 0x4C7C50
        public void set_username(){} // RVA: 0x4C34F0
        public void get_pronouns(){} // RVA: 0x462D00
        public void set_pronouns(){} // RVA: 0x464450
        public void get_bio(){} // RVA: 0x31C010
        public void set_bio(){} // RVA: 0x463060
        public void get_bioLinks(){} // RVA: 0x796DE0
        public void set_bioLinks(){} // RVA: 0xB54600
        public void get_location(){} // RVA: 0xA1C8C0
        public void set_location(){} // RVA: 0x9AA650
        public void get_avatarId(){} // RVA: 0xA085E0
        public void set_avatarId(){} // RVA: 0x9AA5F0
        public void get_fallbackId(){} // RVA: 0xA1C130
        public void set_fallbackId(){} // RVA: 0xAE5030
        public void get_hasEmail(){} // RVA: 0x17323D0
        public void set_hasEmail(){} // RVA: 0x1735610
        public void get_isBoopingEnabled(){} // RVA: 0x3C49C40
        public void set_isBoopingEnabled(){} // RVA: 0x3C49C50
        public void get_hasBirthday(){} // RVA: 0x61A85F0
        public void set_hasBirthday(){} // RVA: 0x61A8600
        public void get_isFriend(){} // RVA: 0x61A8610
        public void set_isFriend(){} // RVA: 0x61A8620
        public void get_friendKey(){} // RVA: 0x3480B0
        public void set_friendKey(){} // RVA: 0x3480C0
        public void get_friendRequestStatus(){} // RVA: 0x348120
        public void set_friendRequestStatus(){} // RVA: 0x348130
        public void get_last_login(){} // RVA: 0x435460
        public void set_last_login(){} // RVA: 0x435470
        public void get_last_activity(){} // RVA: 0x3FA100
        public void set_last_activity(){} // RVA: 0x3FA110
        public void get_date_joined(){} // RVA: 0xA96D30
        public void set_date_joined(){} // RVA: 0x35E8A0
        public void get_developerType(){} // RVA: 0x1D12470
        public void set_developerType(){} // RVA: 0x1D12480
        public void get_events(){} // RVA: 0x35E970
        public void set_events(){} // RVA: 0x35E980
        public void get_acceptedTOSVersion(){} // RVA: 0x3739380
        public void set_acceptedTOSVersion(){} // RVA: 0x627A290
        public void get_queuedInstance(){} // RVA: 0x7F7DB0
        public void set_queuedInstance(){} // RVA: 0x63D280
        public void get_queuedInstancePosition(){} // RVA: 0x646FCD0
        public void set_queuedInstancePosition(){} // RVA: 0x74E2F70
        public void get_acceptedPrivacyVersion(){} // RVA: 0x1C86A00
        public void set_acceptedPrivacyVersion(){} // RVA: 0x1A66500
        public void get_currentAvatarImageUrl(){} // RVA: 0xA902E0
        public void set_currentAvatarImageUrl(){} // RVA: 0xCF4780
        public void get_currentAvatarThumbnailImageUrl(){} // RVA: 0x507710
        public void set_currentAvatarThumbnailImageUrl(){} // RVA: 0x509930
        public void get_currentAvatarTags(){} // RVA: 0x507D10
        public void set_currentAvatarTags(){} // RVA: 0x50A8C0
        public void get_authToken(){} // RVA: 0x59E660
        public void set_authToken(){} // RVA: 0x59F420
        public void get_emailVerified(){} // RVA: 0x7F48D0
        public void set_emailVerified(){} // RVA: 0x7F24D0
        public void get_hasPendingEmail(){} // RVA: 0x98D7230
        public void set_hasPendingEmail(){} // RVA: 0x98D7240
        public void get_obfuscatedPendingEmail(){} // RVA: 0xA8E870
        public void set_obfuscatedPendingEmail(){} // RVA: 0xDA3F70
        public void get_friendIDs(){} // RVA: 0xA933D0
        public void set_friendIDs(){} // RVA: 0xA96DC0
        public void get_currentAvatarAssetUrl(){} // RVA: 0x3485F0
        public void set_currentAvatarAssetUrl(){} // RVA: 0x348600
        public void get_steamDetails(){} // RVA: 0x348660
        public void set_steamDetails(){} // RVA: 0x348670
        public void get_travelingToLocation(){} // RVA: 0x9FE130
        public void set_travelingToLocation(){} // RVA: 0xD8E9B0
        public void get_obfuscatedEmail(){} // RVA: 0xD8A610
        public void set_obfuscatedEmail(){} // RVA: 0xD95D10
        public void get_unsubscribe(){} // RVA: 0x627A600
        public void set_unsubscribe(){} // RVA: 0x627A610
        public void get_hasLoggedInFromClient(){} // RVA: 0x627A620
        public void set_hasLoggedInFromClient(){} // RVA: 0x627A630
        public void get_pastDisplayNames(){} // RVA: 0xD93DD0
        public void set_pastDisplayNames(){} // RVA: 0xD93D70
        public void get_homeLocation(){} // RVA: 0x830040
        public void set_homeLocation(){} // RVA: 0xD8E320
        public void get_tags(){} // RVA: 0x82F060
        public void set_tags(){} // RVA: 0x98D7250
        public void get_status(){} // RVA: 0xDA5BB0
        public void set_status(){} // RVA: 0xD87C10
        public void get_statusDescription(){} // RVA: 0xD83B50
        public void set_statusDescription(){} // RVA: 0xD9F550
        public void get_badges(){} // RVA: 0xA90180
        public void set_badges(){} // RVA: 0xD96D90
        public void get_statusHistory(){} // RVA: 0xA974D0
        public void set_statusHistory(){} // RVA: 0xD9C360
        public void get_state(){} // RVA: 0xDB1150
        public void set_state(){} // RVA: 0xD95560
        public void get_allowAvatarCopying(){} // RVA: 0x64D29E0
        public void set_allowAvatarCopying(){} // RVA: 0x64D29F0
        public void get_hasSharedConnectionsOptOut(){} // RVA: 0x64D2A00
        public void set_hasSharedConnectionsOptOut(){} // RVA: 0x64D2A10
        public void get_hasDiscordFriendsOptOut(){} // RVA: 0x64D2A60
        public void set_hasDiscordFriendsOptOut(){} // RVA: 0x64D2A70
        public void get_userIcon(){} // RVA: 0xDA5040
        public void set_userIcon(){} // RVA: 0xD8AAB0
        public void get_profilePicOverride(){} // RVA: 0xDB2150
        public void set_profilePicOverride(){} // RVA: 0xD94B20
        public void get_note(){} // RVA: 0xA57F60
        public void set_note(){} // RVA: 0xD94790
        public void get_iconUrl(){} // RVA: 0xDA62D0
        public void set_iconUrl(){} // RVA: 0xD94E00
        public void get_thumbnailUrl(){} // RVA: 0xDB3D70
        public void set_thumbnailUrl(){} // RVA: 0xD86540
        public void get_hideContentFilterSettings(){} // RVA: 0x1C9ABD0
        public void set_hideContentFilterSettings(){} // RVA: 0x1C9ABE0
        public void get_contentFilters(){} // RVA: 0x8CBA20
        public void set_contentFilters(){} // RVA: 0xDB44F0
        public void get_userLanguageCode(){} // RVA: 0xDB4D60
        public void set_userLanguageCode(){} // RVA: 0xD85A20
        public void get_ageVerified(){} // RVA: 0x64D55B0
        public void set_ageVerified(){} // RVA: 0x98D72C0
        public void get_isAdult(){} // RVA: 0x168E9D0
        public void set_isAdult(){} // RVA: 0x98D72D0
        public void get_ageVerificationStatus(){} // RVA: 0xD8D540
        public void set_ageVerificationStatus(){} // RVA: 0xD9D6A0
        public void get_discordId(){} // RVA: 0xD9E9A0
        public void set_discordId(){} // RVA: 0xD9F490
        public void get_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x64ADDD0
        public void set_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x98D72E0
        public void get_completedTutorials(){} // RVA: 0xD9F7C0
        public void set_completedTutorials(){} // RVA: 0xD9BA80
        public void get_last_platform(){} // RVA: 0xD88BD0
        public void set_last_platform(){} // RVA: 0x98D72F0
        public void get_platform(){} // RVA: 0xD915D0
        public void set_platform(){} // RVA: 0xD93180
        public void get_last_mobile(){} // RVA: 0xD90650
        public void set_last_mobile(){} // RVA: 0xD9F060
        public void get_twoFactorAuthEnabled(){} // RVA: 0x625DEA0
        public void set_twoFactorAuthEnabled(){} // RVA: 0x625DEB0
        public void get_twoFactorAuthMethods(){} // RVA: 0xD90BA0
        public void set_twoFactorAuthMethods(){} // RVA: 0xD94430
        public void get_LanguageTagsDictionary(){} // RVA: 0x98D7470
        public void get_languagesDisplayNames(){} // RVA: 0xD94B90
        public void set_languagesDisplayNames(){} // RVA: 0xD9C4E0
        public void set_LanguagesShortNames(){} // RVA: 0xD88A80
        public void get_LanguagesShortNames(){} // RVA: 0xD83050
        public void SetUserLanguages(){} // RVA: 0x98D7900
        public void get_ShouldSeeInstanceByStatus(){} // RVA: 0x98D7CC0
        public void get_IsOnMobile(){} // RVA: 0x98D7D00
        public void get_profilePicImageUrl(){} // RVA: 0x98D7D20
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x98D7D40
        public void FetchBalance(){} // RVA: 0x98D7D60
        public void get_IsAccountVerified(){} // RVA: 0x3C2850
        public void get_hasNoPowers(){} // RVA: 0x98D80F0
        public void get_hasScriptingAccess(){} // RVA: 0x98D8140
        public void get_hasModerationPowers(){} // RVA: 0x98D8240
        public void get_hasVIPAccess(){} // RVA: 0x98D8300
        public void get_hasSuperPowers(){} // RVA: 0x98D8350
        public void get_canPublishWorldsAndAvatars(){} // RVA: 0x98D83A0
        public void get_canPublishAllContent(){} // RVA: 0x98D85C0
        public void get_canPublishAvatars(){} // RVA: 0x98D86F0
        public void get_canPublishWorlds(){} // RVA: 0x98D8810
        public void get_canPublishProps(){} // RVA: 0x98D8930
        public void get_isUntrusted(){} // RVA: 0x98D8A50
        public void get_isNewUser(){} // RVA: 0x98D8AB0
        public void get_isEarlyAdopter(){} // RVA: 0x98D8B70
        public void get_isSupporter(){} // RVA: 0x98D8C30
        public void get_isCreator(){} // RVA: 0x98D8CF0
        public void get_hasBasicTrustLevel(){} // RVA: 0x98D8DB0
        public void get_hasKnownTrustLevel(){} // RVA: 0x98D8E80
        public void get_hasTrustedTrustLevel(){} // RVA: 0x98D8F50
        public void get_hasVeteranTrustLevel(){} // RVA: 0x98D9020
        public void get_hasLegendTrustLevel(){} // RVA: 0x98D9160
        public void get_hasNegativeTrustLevel(){} // RVA: 0x98D9230
        public void get_hasVeryNegativeTrustLevel(){} // RVA: 0x98D9300
        public void get_hasFeedbackAccess(){} // RVA: 0x98D93C0
        public void get_showSocialRank(){} // RVA: 0x98D9480
        public void get_showModTag(){} // RVA: 0x98D9520
        public void get_canSetStatusOffline(){} // RVA: 0x98D95C0
        public void get_statusIsSetToOffline(){} // RVA: 0x98D9620
        public void get_statusIsSetToJoinMe(){} // RVA: 0x98D9750
        public void get_statusIsSetToAskMe(){} // RVA: 0x98D97F0
        public void get_statusIsSetToDoNotDisturb(){} // RVA: 0x98D9920
        public void get_statusDefaultDescriptionDisplayString(){} // RVA: 0x98D9A50
        public void truncatedBio(){} // RVA: 0x98D9BE0
        public void truncatedStatusDescription(){} // RVA: 0x98D9C50
        public void get_statusDescriptionDisplayString(){} // RVA: 0x98D9CC0
        public void get_statusValue(){} // RVA: 0x98D9D80
        public void get_CurrentLocation(){} // RVA: 0x98D9DF0
        public void get_canSeeAllUsersStatus(){} // RVA: 0x98DA150
        public void MergeFieldsInto(){} // RVA: 0x98DA1B0
        public void get_IsLoggedIn(){} // RVA: 0x98DAA30
        public void get_IsSelf(){} // RVA: 0x98DAAC0
        public void get_CurrentUser(){} // RVA: 0x98DAC10
        public void set_CurrentUser(){} // RVA: 0x98DAC70
        public void .ctor(){} // RVA: 0x98DB010 | overloaded x2
        public void ReadField(){} // RVA: 0x98DBEA0
        public void WriteField(){} // RVA: 0x98DBF50
        public void InitialFetchCurrentUser(){} // RVA: 0x98DC0E0
        public void Register(){} // RVA: 0x98DC500
        public void UpdateAccountInfo(){} // RVA: 0x98DCF30
        public void Login(){} // RVA: 0x98DDA00
        public void VerifyTwoFactorAuthCode(){} // RVA: 0x98DDEF0
        public void VerifyStepUpAuthCode(){} // RVA: 0x98DE4E0
        public void ThirdPartyLogin(){} // RVA: 0x98DF060
        public void DiscordLogin(){} // RVA: 0x98DF470
        public void DiscordFinalizeLogin(){} // RVA: 0x98DFA40
        public void DiscordLinkStatus(){} // RVA: 0x98E0530
        public void DiscordUnlink(){} // RVA: 0x98E0A20
        public void GoogleLogin(){} // RVA: 0x98E0D60
        public void GoogleFinalizeLogin(){} // RVA: 0x98E1460
        public void GoogleLinkStatus(){} // RVA: 0x98E1E10
        public void GoogleLink(){} // RVA: 0x98E2410
        public void GoogleUnlink(){} // RVA: 0x98E2A50
        public void DiscordAccess(){} // RVA: 0x98E2D70
        public void RedeemPromo(){} // RVA: 0x98E30B0
        public void Logout(){} // RVA: 0x98E34A0
        public void FetchPublishWorldsInformation(){} // RVA: 0x98E35F0
        public void FetchUsers(){} // RVA: 0x98E4310 | overloaded x2
        public void FetchUser(){} // RVA: 0x98E3FA0
        public void FetchUsersSearchResults(){} // RVA: 0x98E46F0
        public void FetchFriends(){} // RVA: 0x98E4B00
        public void AttemptVerification(){} // RVA: 0x98E5570
        public void TagsToDeveloperType(){} // RVA: 0x98E5630
        public void SetIsBoopingEnabled(){} // RVA: 0x98E56A0
        public void AddLanguage(){} // RVA: 0x98E5B00
        public void RemoveLanguage(){} // RVA: 0x98E60D0
        public void AddLink(){} // RVA: 0x98E6660
        public void ModifyLink(){} // RVA: 0x98E6BA0
        public void UpdateBio(){} // RVA: 0x98E7040
        public void UpdateContentFilters(){} // RVA: 0x98E7630
        public void UpdateUserLanguageCode(){} // RVA: 0x98E7A50
        public void AddNewStatusToHistory(){} // RVA: 0x98E8030
        public void StatusValueToString(){} // RVA: 0x98E81F0
        public void StringToStatusValue(){} // RVA: 0x98E8350
        public void UnfriendUser(){} // RVA: 0x98E85D0
        public void LocalAddFriend(){} // RVA: 0x98E89E0
        public void IsFriendsWith(){} // RVA: 0x98E8C30
        public void get_HasRequestedToBeFriend(){} // RVA: 0x98E8E60
        public void set_HasRequestedToBeFriend(){} // RVA: 0x98E8EE0
        public void get_HasFriendRequestPending(){} // RVA: 0x98E8F80
        public void set_HasFriendRequestPending(){} // RVA: 0x98E9000
        public void SetAvatarPropertiesFromModel(){} // RVA: 0x98E90A0
        public void SetAvatarFallbackPropertiesFromModel(){} // RVA: 0x98E9300
        public void Exists(){} // RVA: 0x98E93F0
        public void HasTag(){} // RVA: 0x98E9430
        public void AddTag(){} // RVA: 0x98E94A0
        public void RemoveTag(){} // RVA: 0x98E9540
        public void Equals(){} // RVA: 0x98E9690
        public void UpdateNote(){} // RVA: 0x98E9740
        public void SetUserInterests(){} // RVA: 0x98E9DD0
        public void GetUserInterests(){} // RVA: 0x98EA0A0
        public void CheckIfPersistenceDataExistsForWorld(){} // RVA: 0x98EA3B0
        public void ResetPersistenceDataForWorld(){} // RVA: 0x98EA760
        public void ResetAllPersistenceDataForWorlds(){} // RVA: 0x98EAB00
        public void UpdateBadge(){} // RVA: 0x98EAE40
        public void ToString(){} // RVA: 0x98EB6A0
        public void .cctor(){} // RVA: 0x98EB9E0
    }

    public class AnalyticsInterface
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x99344A0
        public void SetBuildVersion(){} // RVA: 0x99345F0
        public void SetLogger(){} // RVA: 0x99346A0
        public void Send(){} // RVA: 0x9934790
        public void SetUserId(){} // RVA: 0x9934860
        public void SetSessionId(){} // RVA: 0x9934910
        public void GetSessionId(){} // RVA: 0x99349D0
        public void SetUserProperties(){} // RVA: 0x9934A70
        public void ClearCachedData(){} // RVA: 0x9934B30
        public void OnApplicationQuit(){} // RVA: 0x9934C70
        public void HasPendingEvents(){} // RVA: 0x9934D40
        public void OnApplicationFocused(){} // RVA: 0x9934E10
        public void OnApplicationPaused(){} // RVA: 0x9934EB0
        public void CheckInstance(){} // RVA: 0x9934F70
    }

    public class AnalyticsSDK
    {
        // ── Methods ──
        public void GetProjectTypeString(){} // RVA: 0x9935050
        public void Initialize(){} // RVA: 0x9935100
        public void LoggedInUserChanged(){} // RVA: 0x9935260 | overloaded x2
        public void AddOtherProperties(){} // RVA: 0x99354B0
        public void AvatarUploadFailed(){} // RVA: 0x9935650
        public void WorldUploadFailed(){} // RVA: 0x99357C0
        public void PropUploadFailed(){} // RVA: 0x9935930
        public void ExampleCentralOpened(){} // RVA: 0x9935AA0
        public void ExampleDownloaded(){} // RVA: 0x9935C40
        public void ExamplePreviewed(){} // RVA: 0x9935E80
        public void CheckInit(){} // RVA: 0x99361F0
        public void BuildAndTestLaunched(){} // RVA: 0x9936320
        public void ProjectPublished(){} // RVA: 0x99365B0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x99369F0
    }

    public class ApiAccountUpgrade
    {
        // ── Methods ──
        public void get_isUpgrading(){} // RVA: 0x3A5570
        public void set_isUpgrading(){} // RVA: 0x3A5580
        public void get_subscribedToMarketingEmails(){} // RVA: 0x4EC4D70
        public void set_subscribedToMarketingEmails(){} // RVA: 0x4EC47C0
        public void get_hasEmail(){} // RVA: 0x5AF9770
        public void set_hasEmail(){} // RVA: 0x5AF9780
        public void get_emailVerified(){} // RVA: 0x6AC9640
        public void set_emailVerified(){} // RVA: 0x6AC9650
        public void .ctor(){} // RVA: 0x9857EF0
        public void GetUpgradeStatus(){} // RVA: 0x9857FB0
        public void UpgradeWithEmail(){} // RVA: 0x98582D0
        public void ParseErrorCode(){} // RVA: 0x9858810
    }

    public class ApiAdminAssetBundle
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_description(){} // RVA: 0x3A5590
        public void set_description(){} // RVA: 0x3A55A0
        public void get_imageUrl(){} // RVA: 0x4C7C50
        public void set_imageUrl(){} // RVA: 0x4C34F0
        public void get_tags(){} // RVA: 0x462D00
        public void set_tags(){} // RVA: 0x464450
        public void get_assetVersion(){} // RVA: 0xBB90C0
        public void set_assetVersion(){} // RVA: 0xBB9E60
        public void get_unityPackages(){} // RVA: 0x796DE0
        public void set_unityPackages(){} // RVA: 0xB54600
        public void GetPlatformString(){} // RVA: 0x9858EA0 | overloaded x2
        public void GetBundleLink(){} // RVA: 0x9859030
        public void CreateAdminAssetBundle(){} // RVA: 0x98592F0
        public void AddPackageToBundle(){} // RVA: 0x9859C30
        public void GetAdminAssetBundle(){} // RVA: 0x985A430
        public void GetAllAdminAssetBundles(){} // RVA: 0x985A760
        public void RequestDeleteBundle(){} // RVA: 0x985AF20
        public void SendPropertyUpdate(){} // RVA: 0x985B230
        public void .ctor(){} // RVA: 0x985BA40
    }

    public class ApiAdminAssetBundleFile
    {
        // ── Methods ──
        public void get_assetUrl(){} // RVA: 0x358D50
        public void set_assetUrl(){} // RVA: 0x358D60
        public void get_unityVersion(){} // RVA: 0x3A5590
        public void set_unityVersion(){} // RVA: 0x3A55A0
        public void get_platform(){} // RVA: 0x4C7C50
        public void set_platform(){} // RVA: 0x4C34F0
        public void get_assetVersion(){} // RVA: 0xFC4570
        public void set_assetVersion(){} // RVA: 0xFC4560
        public void GetCacheId(){} // RVA: 0x985BE20
        public void .ctor(){} // RVA: 0x985BFD0
    }

    public class ApiAuthContinue
    {
        // ── Methods ──
        public void get_continueToken(){} // RVA: 0x358D50
        public void set_continueToken(){} // RVA: 0x358D60
        public void get_requestedFields(){} // RVA: 0x3A5590
        public void set_requestedFields(){} // RVA: 0x3A55A0
        public void get_reservedName(){} // RVA: 0x4C7C50
        public void set_reservedName(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x985C020
    }

    public class ApiAvatar
    {
        // ── Methods ──
        public void get_impostorUrl(){} // RVA: 0x35E900
        public void set_impostorUrl(){} // RVA: 0x35E910
        public void get_variant(){} // RVA: 0x1CAC8F0
        public void set_variant(){} // RVA: 0x627A3B0
        public void get_impostorUnityVersion(){} // RVA: 0x3482A0
        public void set_impostorUnityVersion(){} // RVA: 0x3482B0
        public void get_unityPackages(){} // RVA: 0x7F7DB0
        public void set_unityPackages(){} // RVA: 0x63D280
        public void get_created_at(){} // RVA: 0xA94E10
        public void set_created_at(){} // RVA: 0x1702E00
        public void get_updated_at(){} // RVA: 0xA902E0
        public void set_updated_at(){} // RVA: 0x507D00
        public void get_attribution(){} // RVA: 0x507710
        public void set_attribution(){} // RVA: 0x509930
        public void get_offlineAnalysisScanStatus(){} // RVA: 0x13CBAD0
        public void set_offlineAnalysisScanStatus(){} // RVA: 0x13D7860
        public void get_performanceRating(){} // RVA: 0x59E660
        public void set_performanceRating(){} // RVA: 0x59F420
        public void get_styles(){} // RVA: 0xA8EE80
        public void set_styles(){} // RVA: 0xD182E0
        public void get_productId(){} // RVA: 0xA8E870
        public void set_productId(){} // RVA: 0xDA3F70
        public void get_publishedListings(){} // RVA: 0xA933D0
        public void set_publishedListings(){} // RVA: 0xA96DC0
        public void get_lowestPrice(){} // RVA: 0x3485F0
        public void set_lowestPrice(){} // RVA: 0x63A7620
        public void get_highestPrice(){} // RVA: 0x348660
        public void set_highestPrice(){} // RVA: 0x629CBE0
        public void get_acknowledgements(){} // RVA: 0x9FE130
        public void set_acknowledgements(){} // RVA: 0xD8E9B0
        public void get_LoadError(){} // RVA: 0xD8A610
        public void set_LoadError(){} // RVA: 0xD95D10
        public void .ctor(){} // RVA: 0x985C0C0
        public void Get(){} // RVA: 0x985C1E0
        public void AssignToThisUser(){} // RVA: 0x985C380
        public void AssignToThisUserAsFallback(){} // RVA: 0x985C800
        public void GetPerformanceRatingForPlatform(){} // RVA: 0x985CC80
        public void GetAssetUrl(){} // RVA: 0x985CD00
        public void SetApiFieldsFromJson(){} // RVA: 0x985CEA0 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x985CFE0
        public void WriteField(){} // RVA: 0x985DB30
        public void CopyDeserializedValuesTo(){} // RVA: 0x985DB60
    }

    public class ApiAvatarLook
    {
        // ── Methods ──
        public void get_avatarId(){} // RVA: 0x358D50
        public void set_avatarId(){} // RVA: 0x358D60
        public void get_attachments(){} // RVA: 0x3A5590
        public void set_attachments(){} // RVA: 0x3A55A0
        public void GetLook(){} // RVA: 0x985E420
        public void UpdateThumbnail(){} // RVA: 0x985E5C0
        public void UpdateLook(){} // RVA: 0x985E710
        public void CreateLook(){} // RVA: 0x985E860
        public void WearLook(){} // RVA: 0x985EA00
        public void UploadThumbnail(){} // RVA: 0x985ED50
        public void .ctor(){} // RVA: 0x985EEF0
    }

    public class ApiAvatarModeration
    {
        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x1C91440
        public void set_moderationType(){} // RVA: 0x1C91450
        public void get_targetAvatarId(){} // RVA: 0x3A5590
        public void set_targetAvatarId(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9862950
        public void ShouldCache(){} // RVA: 0x2DD320
        public void ReadField(){} // RVA: 0x9862A10
        public void WriteField(){} // RVA: 0x9862D90
        public void SendModeration(){} // RVA: 0x9862F70
        public void DeleteModeration(){} // RVA: 0x98631B0
        public void FetchAllMine(){} // RVA: 0x98636D0
        public void FetchList(){} // RVA: 0x9863730
        public void ModerationTypeToAPIString(){} // RVA: 0x9863A20
    }

    public class ApiAvatarPart
    {
        // ── Methods ──
        public void get__created_at(){} // RVA: 0xA96D30
        public void set__created_at(){} // RVA: 0x9863DD0
        public void get__updated_at(){} // RVA: 0x35E900
        public void set__updated_at(){} // RVA: 0x9863DE0
        public void get_unityPackages(){} // RVA: 0x35E970
        public void set_unityPackages(){} // RVA: 0x35E980
        public void get_BundleSignature(){} // RVA: 0x3482A0
        public void set_BundleSignature(){} // RVA: 0x3482B0
        public void .ctor(){} // RVA: 0x9863DF0
        public void SetApiFieldsFromJson(){} // RVA: 0x9863F50 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x9864030
        public void WriteField(){} // RVA: 0x98646F0
        public void CopyDeserializedValuesTo(){} // RVA: 0x98647B0
        public void GetAccessory(){} // RVA: 0x98649B0
        public void FetchList(){} // RVA: 0x9864B50
    }

    public class ApiAvatarPartItemMetadata
    {
        // ── Methods ──
        public void get_avatarPartId(){} // RVA: 0x358D50
        public void set_avatarPartId(){} // RVA: 0x358D60
        public void .ctor(){} // RVA: 0x9865640
    }

    public class ApiAvatarStyle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9865690
        public void get_styleName(){} // RVA: 0x358D50
        public void set_styleName(){} // RVA: 0x358D60
        public void get_lastModifiedById(){} // RVA: 0x3A5590
        public void set_lastModifiedById(){} // RVA: 0x3A55A0
        public void get_lastModifiedByDisplayName(){} // RVA: 0x4C7C50
        public void set_lastModifiedByDisplayName(){} // RVA: 0x4C34F0
        public void get_created_at(){} // RVA: 0x462D00
        public void set_created_at(){} // RVA: 0x1F0ABA0
        public void get_updated_at(){} // RVA: 0x31C010
        public void set_updated_at(){} // RVA: 0xADF010
    }

    public class ApiBadge
    {
        // ── Methods ──
        public void get_badgeId(){} // RVA: 0x358D50
        public void set_badgeId(){} // RVA: 0x358D60
        public void get_showcased(){} // RVA: 0x359320
        public void set_showcased(){} // RVA: 0x359330
        public void get_badgeName(){} // RVA: 0x4C7C50
        public void set_badgeName(){} // RVA: 0x4C34F0
        public void get_badgeDescription(){} // RVA: 0x462D00
        public void set_badgeDescription(){} // RVA: 0x464450
        public void get_badgeImageUrl(){} // RVA: 0x31C010
        public void set_badgeImageUrl(){} // RVA: 0x463060
        public void get_hidden(){} // RVA: 0x134A670
        public void set_hidden(){} // RVA: 0x1348E00
        public void get_assignedAt(){} // RVA: 0xA1C8C0
        public void set_assignedAt(){} // RVA: 0x5774BB0
        public void get_updatedAt(){} // RVA: 0xA085E0
        public void set_updatedAt(){} // RVA: 0x5FF62E0
        public void get_assignedBy(){} // RVA: 0xA1C130
        public void set_assignedBy(){} // RVA: 0xAE5030
        public void get_isQuantifiable(){} // RVA: 0x17323D0
        public void set_isQuantifiable(){} // RVA: 0x1735610
        public void get_quantity(){} // RVA: 0x3DF1350
        public void set_quantity(){} // RVA: 0x3DF1360
        public void .ctor(){} // RVA: 0x9865750
    }

    public class ApiBindingCommandReference
    {
        // ── Methods ──
        public void get_command(){} // RVA: 0x358D50
        public void set_command(){} // RVA: 0x358D60
        public void get_parameters(){} // RVA: 0x3A5590
        public void set_parameters(){} // RVA: 0x3A55A0
        public void get_name(){} // RVA: 0x4C7C50
        public void set_name(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x98657A0
        public void ToString(){} // RVA: 0x9865840
    }

    public class ApiByteContainer
    {
        // ── Methods ──
        public void get_ResponseBytes(){} // RVA: 0x98CCCD0
        public void Validate(){} // RVA: 0x98CCD40
        public void .ctor(){} // RVA: 0x98CC6A0
    }

    public class ApiCache
    {
        // ── Methods ──
        public void DefaultTimeProvider(){} // RVA: 0x9865920
        public void get_Count(){} // RVA: 0x98659D0
        public void get_NextExpiryTTL(){} // RVA: 0x9865BA0
        public void Fetch(){} // RVA: 0xE230
        public void Save(){} // RVA: 0x9865E90
        public void Invalidate(){} // RVA: 0x9866300
        public void CleanupTask(){} // RVA: 0x98665B0
        public void Cleanup(){} // RVA: 0x98665F0
        public void InvalidateFileIfVersionUnknown(){} // RVA: 0x9866AF0
        public void Clear(){} // RVA: 0x9866CA0
        public void .cctor(){} // RVA: 0x9866F20
    }

    public class ApiCacheObject
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0xDBE0
        public void GetLifeSpan(){} // RVA: 0x21890
        public void Clone(){} // RVA: 0xCD60
        public void set_ExpiryTime(){} // RVA: 0x24B10
    }

    public class ApiCalendarEntriesContainer
    {
        // ── Methods ──
        public void get_hasNext(){} // RVA: 0x3A5570
        public void set_hasNext(){} // RVA: 0x3A5580
        public void get_results(){} // RVA: 0x3A5590
        public void set_results(){} // RVA: 0x3A55A0
        public void get_totalCount(){} // RVA: 0x1AE3800
        public void set_totalCount(){} // RVA: 0x1AE6D80
        public void get_nextCursor(){} // RVA: 0x462D00
        public void set_nextCursor(){} // RVA: 0x464450
        public void .ctor(){} // RVA: 0x9916A80
    }

    public class ApiCalendarResults
    {
        // ── Methods ──
        public void get_results(){} // RVA: 0x358D50
        public void set_results(){} // RVA: 0x358D60
        public void get_totalCount(){} // RVA: 0x10E5CF0
        public void set_totalCount(){} // RVA: 0x475080
        public void .ctor(){} // RVA: 0x98D1D30
    }

    public class ApiCampaign
    {
        // ── Methods ──
        public void get_participantCount(){} // RVA: 0x1C91440
        public void set_participantCount(){} // RVA: 0x1C91450
        public void get_friendsContributing(){} // RVA: 0x3A5590
        public void set_friendsContributing(){} // RVA: 0x3A55A0
        public void get_endsAt(){} // RVA: 0x4C7C50
        public void set_endsAt(){} // RVA: 0x5AAF010
        public void get_raisedAmountUsd(){} // RVA: 0xFC4570
        public void set_raisedAmountUsd(){} // RVA: 0xFC4560
        public void get_userGiftCount(){} // RVA: 0x1C5A600
        public void set_userGiftCount(){} // RVA: 0x1C5A650
        public void get_giftGoalUsd(){} // RVA: 0xBB90C0
        public void set_giftGoalUsd(){} // RVA: 0xBB9E60
        public void get_goalSuccess(){} // RVA: 0x345520
        public void set_goalSuccess(){} // RVA: 0x345530
        public void get_rewards(){} // RVA: 0x796DE0
        public void set_rewards(){} // RVA: 0xB54600
        public void GetCampaignAsync(){} // RVA: 0x98677C0
        public void .ctor(){} // RVA: 0x9867960
    }

    public class ApiCampaignReward
    {
        // ── Methods ──
        public void get_title(){} // RVA: 0x358D50
        public void set_title(){} // RVA: 0x358D60
        public void get_description(){} // RVA: 0x3A5590
        public void set_description(){} // RVA: 0x3A55A0
        public void get_imageUrl(){} // RVA: 0x4C7C50
        public void set_imageUrl(){} // RVA: 0x4C34F0
        public void get_unlocked(){} // RVA: 0x5A8B10
        public void set_unlocked(){} // RVA: 0x5A6190
        public void get_progress(){} // RVA: 0x31C010
        public void set_progress(){} // RVA: 0x463060
        public void .ctor(){} // RVA: 0x98681C0
    }

    public class ApiCampaignRewardProgress
    {
        // ── Methods ──
        public void get_current(){} // RVA: 0x1C91440
        public void set_current(){} // RVA: 0x1C91450
        public void get_max(){} // RVA: 0x1C91460
        public void set_max(){} // RVA: 0x1C91470
        public void .ctor(){} // RVA: 0x9868210
    }

    public class ApiCertificateVerifier
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x9868260
        public void .ctor(){} // RVA: 0x74FAFC0
        public void Initialize(){} // RVA: 0x98682C0
        public void TestPublicKey(){} // RVA: 0x98683C0
        public void IsValid(){} // RVA: 0x9868650
        public void ValidateCertificate(){} // RVA: 0x9868890
        public void .cctor(){} // RVA: 0x9868A50
    }

    public class ApiContainer
    {
        // ── Methods ──
        public void get_Cookies(){} // RVA: 0x2F8380
        public void set_Cookies(){} // RVA: 0x2DEE30
        public void get_Populated(){} // RVA: 0x2F84E0
        public void set_Populated(){} // RVA: 0x2F84F0
        public void get_PassedValidation(){} // RVA: 0x6B93D0
        public void set_PassedValidation(){} // RVA: 0xF43D70
        public void get_Code(){} // RVA: 0x197C3B0
        public void set_Code(){} // RVA: 0x1989FD0
        public void get_Text(){} // RVA: 0x30B0C0
        public void set_Text(){} // RVA: 0x30B0D0
        public void get_Data(){} // RVA: 0x30B130
        public void set_Data(){} // RVA: 0x2DEE90
        public void get_DataTimestamp(){} // RVA: 0x466280
        public void set_DataTimestamp(){} // RVA: 0x4FDE90
        public void get_CreatedAt(){} // RVA: 0x4976A0
        public void set_CreatedAt(){} // RVA: 0x49B830
        public void get_Error(){} // RVA: 0x98CCE90
        public void set_Error(){} // RVA: 0x98CCEC0
        public void get_Model(){} // RVA: 0x358730
        public void set_Model(){} // RVA: 0x358740
        public void .ctor(){} // RVA: 0x98CD220
        public void setFromContainer(){} // RVA: 0x98CD2F0
        public void Validate(){} // RVA: 0x98CD500
        public void GetErrorMessage(){} // RVA: 0x98CD550
        public void OnComplete(){} // RVA: 0x98CD700
    }

    public class ApiContentModel`1
    {
        // ── Methods ──
        public void get_VERSION(){} // RVA: 0xC960
        public void ShouldCache(){} // RVA: 0xDBE0
        public void GetLifeSpan(){} // RVA: 0x21890
        public void get_name(){} // RVA: 0xCD60
        public void set_name(){} // RVA: 0x24B10
        public void get_imageUrl(){} // RVA: 0xCD60
        public void set_imageUrl(){} // RVA: 0x24B10
        public void get_authorName(){} // RVA: 0xCD60
        public void set_authorName(){} // RVA: 0x24B10
        public void get_authorId(){} // RVA: 0xCD60
        public void set_authorId(){} // RVA: 0x24B10
        public void get_assetUrl(){} // RVA: 0xCD60
        public void set_assetUrl(){} // RVA: 0x24B10
        public void get_description(){} // RVA: 0xCD60
        public void set_description(){} // RVA: 0x24B10
        public void get_tags(){} // RVA: 0xCD60
        public void set_tags(){} // RVA: 0x24B10
        public void get_thumbnailImageUrl(){} // RVA: 0xCD60
        public void set_thumbnailImageUrl(){} // RVA: 0x24B10
        public void get_version(){} // RVA: 0xD840
        public void set_version(){} // RVA: 0x24FA0
        public void get_releaseStatus(){} // RVA: 0xCD60
        public void set_releaseStatus(){} // RVA: 0x24B10
        public void get_featured(){} // RVA: 0xDBE0
        public void set_featured(){} // RVA: 0x25130
        public void get_unityPackageUpdated(){} // RVA: 0xDBE0
        public void set_unityPackageUpdated(){} // RVA: 0x25130
        public void get_unityVersion(){} // RVA: 0xCD60
        public void set_unityVersion(){} // RVA: 0x24B10
        public void get_apiVersion(){} // RVA: 0xD840
        public void set_apiVersion(){} // RVA: 0x24FA0
        public void get_platform(){} // RVA: 0xCD60
        public void set_platform(){} // RVA: 0x24B10
        public void get_assetVersion(){} // RVA: 0xCD60
        public void set_assetVersion(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24B10
        public void ReadField(){} // RVA: 0x11120
        public void Get(){} // RVA: 0x283FA0
        public void FetchList(){} // RVA: 0x283FA0
        public void AddLocal(){} // RVA: 0x283FA0
        public void IsLocalById(){} // RVA: 0xDCC0
        public void get_IsLocal(){} // RVA: 0xDBE0
        public void Save(){} // RVA: 0x2DC60
        public void SaveReleaseStatus(){} // RVA: 0x2DC60
        public void GetAssetUrl(){} // RVA: 0xCD60
        public void HasTag(){} // RVA: 0xDE40
        public void AddTag(){} // RVA: 0xDE40
        public void RemoveTag(){} // RVA: 0xDE40
        public void UpdateVersionAndPlatform(){} // RVA: 0x24A50
        public void MakeRequestEndpoint(){}
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ApiCredentials
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x9916B20
        public void SetProfileIndex(){} // RVA: 0x9916B50
        public void SetString(){} // RVA: 0x9916BD0
        public void GetString(){} // RVA: 0x9916E20
        public void Load(){} // RVA: 0x9917010
        public void SetHumanName(){} // RVA: 0x9917740
        public void Set(){} // RVA: 0x9917850
        public void Set2faToken(){} // RVA: 0x9917E40
        public void GetHumanName(){} // RVA: 0x9918020
        public void GetAuthToken(){} // RVA: 0x9918060
        public void GetTwoFactorAuthToken(){} // RVA: 0x99180A0
        public void GetAuthTokenCookie(){} // RVA: 0x99180E0
        public void GetTwoFactorAuthTokenCookie(){} // RVA: 0x9918120
        public void GetAuthTokenProvider(){} // RVA: 0x9918160
        public void GetAuthTokenProviderUserId(){} // RVA: 0x99181A0
        public void IsLoaded(){} // RVA: 0x99181E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ApiDictContainer
    {
        // ── Methods ──
        public void get_cacheLifetime(){} // RVA: 0x3EDE10
        public void set_cacheLifetime(){} // RVA: 0xFBC3A0
        public void get_ExpiryTime(){} // RVA: 0x36ABC50
        public void set_ExpiryTime(){} // RVA: 0x36AC0C0
        public void get_requiredFields(){} // RVA: 0x4C7C50
        public void set_requiredFields(){} // RVA: 0x4C34F0
        public void get_ResponseDictionary(){} // RVA: 0x98CBB40
        public void .ctor(){} // RVA: 0x98CBD20 | overloaded x2
        public void Validate(){} // RVA: 0x98CBD90
        public void ShouldCache(){} // RVA: 0x98CC0E0
        public void ShouldClearOnLevelLoad(){} // RVA: 0x2DD320
        public void GetLifeSpan(){} // RVA: 0x3EDE10
        public void Clone(){} // RVA: 0x98CC0F0
        public void .cctor(){} // RVA: 0x98CC170
        public void <Validate>b__17_0(){} // RVA: 0x98CC240
    }

    public class ApiDroneSkin
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_assetBundleId(){} // RVA: 0x3A5590
        public void set_assetBundleId(){} // RVA: 0x3A55A0
        public void get_viewfinderAssetBundleId(){} // RVA: 0x4C7C50
        public void set_viewfinderAssetBundleId(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x9868CA0
    }

    public class ApiEconomyAccountStatus
    {
        // ── Methods ──
        public void get_UserID(){} // RVA: 0x358D50
        public void set_UserID(){} // RVA: 0x358D60
        public void get_Blocked(){} // RVA: 0x359320
        public void set_Blocked(){} // RVA: 0x359330
        public void .ctor(){} // RVA: 0x9918230
    }

    public class ApiEconomyStatus
    {
        // ── Methods ──
        public void get_EconomyIsOnline(){} // RVA: 0x3A5570
        public void set_EconomyIsOnline(){} // RVA: 0x3A5580
        public void get_EconomyState(){} // RVA: 0x1C91460
        public void set_EconomyState(){} // RVA: 0x1C91470
        public void .ctor(){} // RVA: 0x9918280
    }

    public class ApiEconomyStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9868CF0
        public void get_SellerId(){} // RVA: 0x358D50
        public void set_SellerId(){} // RVA: 0x358D60
        public void get_SellerDisplayName(){} // RVA: 0x3A5590
        public void set_SellerDisplayName(){} // RVA: 0x3A55A0
        public void get_WorldId(){} // RVA: 0x4C7C50
        public void set_WorldId(){} // RVA: 0x4C34F0
        public void get_GroupId(){} // RVA: 0x462D00
        public void set_GroupId(){} // RVA: 0x464450
        public void get_StoreStatus(){} // RVA: 0xBB90C0
        public void set_StoreStatus(){} // RVA: 0xBB9E60
        public void get_DisplayName(){} // RVA: 0x796DE0
        public void set_DisplayName(){} // RVA: 0xB54600
        public void get_Description(){} // RVA: 0xA1C8C0
        public void set_Description(){} // RVA: 0x9AA650
        public void get_Tags(){} // RVA: 0xA085E0
        public void set_Tags(){} // RVA: 0x9AA5F0
        public void get_Listings(){} // RVA: 0xA1C130
        public void set_Listings(){} // RVA: 0xAE5030
        public void get_ListingIDs(){} // RVA: 0x348040
        public void set_ListingIDs(){} // RVA: 0x348050
        public void get_IsGroupStore(){} // RVA: 0x9868D40
        public void get_IsWorldStore(){} // RVA: 0x9868D60
        public void ReadField(){} // RVA: 0x9868D80
        public void WriteField(){} // RVA: 0x9868FC0
        public void FetchStore(){} // RVA: 0x9869120
    }

    public class ApiFieldAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6BD7E0
    }

    public class ApiFile
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_order(){} // RVA: 0x3A5590
        public void set_order(){} // RVA: 0x1F0AB80
        public void get_ownerId(){} // RVA: 0x4C7C50
        public void set_ownerId(){} // RVA: 0x4C34F0
        public void get_mimeType(){} // RVA: 0x462D00
        public void set_mimeType(){} // RVA: 0x464450
        public void get_extension(){} // RVA: 0x31C010
        public void set_extension(){} // RVA: 0x463060
        public void get_versions(){} // RVA: 0x796DE0
        public void set_versions(){} // RVA: 0xB54600
        public void get_IsInitialized(){} // RVA: 0x86DB40
        public void set_IsInitialized(){} // RVA: 0x86DB50
        public void get_IsPendingInit(){} // RVA: 0x86B8D0
        public void set_IsPendingInit(){} // RVA: 0x61BEF40
        public void .ctor(){} // RVA: 0x986BC50 | overloaded x3
        public void Create(){} // RVA: 0x986BDE0
        public void Refresh(){} // RVA: 0x986BF80
        public void DownloadFile(){} // RVA: 0x986BFC0
        public void ParseFileIdFromFileAPIUrl(){} // RVA: 0x986C630
        public void TryParseFileIdFromFileAPIUrl(){} // RVA: 0x986C6D0
        public void TryParseFileVersionFromFileAPIUrl(){} // RVA: 0x986C710
        public void TryParseFileIdAndVersionFromFileAPIUrl(){} // RVA: 0x986C760
        public void TryParseFileIdAndVersionAndVariantSuffixFromFileAPIUrl(){} // RVA: 0x986C7A0
        public void TryParseFileIdAndVersionAndVariantFromFileAPIUrl(){} // RVA: 0x986C820 | overloaded x2
        public void PerformRegexMatch(){} // RVA: 0x986C850
        public void TryGetImageAPIUrlFromFileAPIUrl(){} // RVA: 0x986D050
        public void OnDownloadFileCompleted(){} // RVA: 0x986D5B0
        public void SetApiFieldsFromJson(){} // RVA: 0x986DCB0 | overloaded x2
        public void ToString(){} // RVA: 0x986DCE0
        public void ToStringBrief(){} // RVA: 0x950560
        public void CreateNewVersion(){} // RVA: 0x986DF00
        public void HasExistingVersion(){} // RVA: 0x986E640
        public void HasExistingOrPendingVersion(){} // RVA: 0x986E700
        public void GetLatestVersionNumber(){} // RVA: 0x986E7E0
        public void GetLatestCompleteVersionNumber(){} // RVA: 0x986E840
        public void GetVersion(){} // RVA: 0x986E970
        public void GetLatestCompleteVersion(){} // RVA: 0x986EA10
        public void GetLatestVersion(){} // RVA: 0x986EA40
        public void DeleteVersion(){} // RVA: 0x986EAB0
        public void DeleteLatestVersion(){} // RVA: 0x986EDA0
        public void DownloadSignature(){} // RVA: 0x986F180
        public void GetFileURL(){} // RVA: 0x986F220 | overloaded x2
        public void GetFileRawURL(){} // RVA: 0x986F2B0 | overloaded x2
        public void GetDeltaURL(){} // RVA: 0x986F360 | overloaded x2
        public void GetDeltaRawURL(){} // RVA: 0x986F3F0 | overloaded x2
        public void GetSignatureURL(){} // RVA: 0x986F4A0 | overloaded x2
        public void GetSignatureRawURL(){} // RVA: 0x986F530 | overloaded x2
        public void GetFileApiURL(){} // RVA: 0x986F790 | overloaded x2
        public void GetFileVariantApiURL(){} // RVA: 0x986F8D0
        public void GetFileMD5(){} // RVA: 0x986FD60 | overloaded x2
        public void GetFileDescriptor(){} // RVA: 0x986FDE0
        public void IsLatestVersionQueued(){} // RVA: 0x986FE10
        public void HasQueuedOperation(){} // RVA: 0x986FEE0
        public void IsWaitingForUpload(){} // RVA: 0x9870080
        public void IsInErrorState(){} // RVA: 0x9870150
        public void StartSimpleUpload(){} // RVA: 0x9870220
        public void StartMultipartUpload(){} // RVA: 0x98705B0
        public void FinishUpload(){} // RVA: 0x9870990
        public void GetUploadStatus(){} // RVA: 0x9870C20
        public void PutSimpleFileToURL(){} // RVA: 0x9870E20
        public void PutMultipartDataToURL(){} // RVA: 0x9871900
    }

    public class ApiGroupGalleryImage
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_groupId(){} // RVA: 0x3A5590
        public void set_groupId(){} // RVA: 0x3A55A0
        public void get_galleryId(){} // RVA: 0x4C7C50
        public void set_galleryId(){} // RVA: 0x4C34F0
        public void get_fileId(){} // RVA: 0x462D00
        public void set_fileId(){} // RVA: 0x464450
        public void get_imageUrl(){} // RVA: 0x31C010
        public void set_imageUrl(){} // RVA: 0x463060
        public void get_createdAt(){} // RVA: 0x796DE0
        public void set_createdAt(){} // RVA: 0x1CBA190
        public void get_approved(){} // RVA: 0x86DB40
        public void set_approved(){} // RVA: 0x86DB50
        public void get_approvedAt(){} // RVA: 0xA085E0
        public void set_approvedAt(){} // RVA: 0x5FF62E0
        public void get_approvedByUserId(){} // RVA: 0xA1C130
        public void set_approvedByUserId(){} // RVA: 0xAE5030
        public void get_submittedByUserId(){} // RVA: 0x348040
        public void set_submittedByUserId(){} // RVA: 0x348050
        public void get_file(){} // RVA: 0x3480B0
        public void set_file(){} // RVA: 0x3480C0
        public void .ctor(){} // RVA: 0x9923160
    }

    public class ApiGroupInstanceAnnouncement
    {
        // ── Methods ──
        public void get_title(){} // RVA: 0x358D50
        public void set_title(){} // RVA: 0x358D60
        public void get_message(){} // RVA: 0x3A5590
        public void set_message(){} // RVA: 0x3A55A0
        public void get_imageId(){} // RVA: 0x4C7C50
        public void set_imageId(){} // RVA: 0x4C34F0
        public void get_imageVersion(){} // RVA: 0xFC4570
        public void set_imageVersion(){} // RVA: 0xFC4560
        public void .ctor(){} // RVA: 0x9919C70 | overloaded x2
        public void SendAnnouncement(){} // RVA: 0x9919DF0
    }

    public class ApiHypeTrainInfo
    {
        // ── Methods ──
        public void get_campaignId(){} // RVA: 0x358D50
        public void set_campaignId(){} // RVA: 0x358D60
        public void get_hypeTrainId(){} // RVA: 0x3A5590
        public void set_hypeTrainId(){} // RVA: 0x3A55A0
        public void get_cooldownSeconds(){} // RVA: 0x1AE3800
        public void set_cooldownSeconds(){} // RVA: 0x1AE6D80
        public void get_endDate(){} // RVA: 0x462D00
        public void set_endDate(){} // RVA: 0x1F0ABA0
        public void get_lastUpdatedAt(){} // RVA: 0x31C010
        public void set_lastUpdatedAt(){} // RVA: 0xADF010
        public void get_startDate(){} // RVA: 0x796DE0
        public void set_startDate(){} // RVA: 0x1CBA190
        public void get_currentGiftCount(){} // RVA: 0x1D76570
        public void set_currentGiftCount(){} // RVA: 0x1D76000
        public void get_totalGiftGoal(){} // RVA: 0x1D76560
        public void set_totalGiftGoal(){} // RVA: 0x1D76580
        public void get_totalGiftContributors(){} // RVA: 0x1D76590
        public void set_totalGiftContributors(){} // RVA: 0x1D76550
        public void get_totalGiftsFromYouCount(){} // RVA: 0x3C49C00
        public void set_totalGiftsFromYouCount(){} // RVA: 0x3C49C10
        public void .ctor(){} // RVA: 0x99258B0
    }

    public class ApiHypeTrainInstanceInfo
    {
        // ── Methods ──
        public void get_potentialTrain(){} // RVA: 0x358D50
        public void set_potentialTrain(){} // RVA: 0x358D60
        public void get_current(){} // RVA: 0x3A5590
        public void set_current(){} // RVA: 0x3A55A0
        public void get_history(){} // RVA: 0x4C7C50
        public void set_history(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x9925860
    }

    public class ApiImage
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x2DD320
        public void FetchList(){} // RVA: 0x98741F0
        public void UploadImage(){} // RVA: 0x9874D50
        public void .ctor(){} // RVA: 0x9875150
    }

    public class ApiInfoPushSystem
    {
        // ── Methods ──
        public void get_isEnabled(){} // RVA: 0x3A5570
        public void set_isEnabled(){} // RVA: 0x3A5580
        public void get_releaseStatus(){} // RVA: 0x3A5590
        public void set_releaseStatus(){} // RVA: 0x3A55A0
        public void get_tags(){} // RVA: 0x4C7C50
        public void set_tags(){} // RVA: 0x4C34F0
        public void get_requireClientTags(){} // RVA: 0x462D00
        public void set_requireClientTags(){} // RVA: 0x464450
        public void get_priority(){} // RVA: 0xBB90C0
        public void set_priority(){} // RVA: 0xBB9E60
        public void get_startDate(){} // RVA: 0x796DE0
        public void set_startDate(){} // RVA: 0x1CBA190
        public void get_endDate(){} // RVA: 0xA1C8C0
        public void set_endDate(){} // RVA: 0x5774BB0
        public void get_createdAt(){} // RVA: 0xA085E0
        public void set_createdAt(){} // RVA: 0x5FF62E0
        public void get_updatedAt(){} // RVA: 0xA1C130
        public void set_updatedAt(){} // RVA: 0x1B6C650
        public void get_hash(){} // RVA: 0x348040
        public void set_hash(){} // RVA: 0x348050
        public void get_originalManifestId(){} // RVA: 0x3480B0
        public void set_originalManifestId(){} // RVA: 0x3480C0
        public void get_experiment(){} // RVA: 0x348120
        public void set_experiment(){} // RVA: 0x348130
        public void get_data(){} // RVA: 0x435460
        public void set_data(){} // RVA: 0x435470
        public void .ctor(){} // RVA: 0x98753F0
        public void GetLifeSpan(){} // RVA: 0x38EED30
        public void FetchList(){} // RVA: 0x98754B0
        public void Save(){} // RVA: 0x9875B70
    }

    public class ApiInventoryBundle
    {
        // ── Methods ──
        public void get_inventoryItemsToInstantiate(){} // RVA: 0x358D50
        public void set_inventoryItemsToInstantiate(){} // RVA: 0x358D60
        public void get_notificationDetails(){} // RVA: 0x3A5590
        public void set_notificationDetails(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9876560
    }

    public class ApiInventoryBundleDrop
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_authorId(){} // RVA: 0x3A5590
        public void set_authorId(){} // RVA: 0x3A55A0
        public void get_targetGroup(){} // RVA: 0x4C7C50
        public void set_targetGroup(){} // RVA: 0x4C34F0
        public void get_templateIds(){} // RVA: 0x462D00
        public void set_templateIds(){} // RVA: 0x464450
        public void get_startDropDate(){} // RVA: 0x31C010
        public void set_startDropDate(){} // RVA: 0xADF010
        public void get_endDropDate(){} // RVA: 0x796DE0
        public void set_endDropDate(){} // RVA: 0x1CBA190
        public void get_dropExpiryDate(){} // RVA: 0xA1C8C0
        public void set_dropExpiryDate(){} // RVA: 0x5774BB0
        public void get_status(){} // RVA: 0xA085E0
        public void set_status(){} // RVA: 0x9AA5F0
        public void get_tags(){} // RVA: 0xA1C130
        public void set_tags(){} // RVA: 0xAE5030
        public void get_created_at(){} // RVA: 0x348040
        public void set_created_at(){} // RVA: 0x1B6CD00
        public void get_updated_at(){} // RVA: 0x3480B0
        public void set_updated_at(){} // RVA: 0x1B6CF30
        public void get_notificationDetails(){} // RVA: 0x348120
        public void set_notificationDetails(){} // RVA: 0x348130
        public void FetchCurrentlyActiveBundleDrops(){} // RVA: 0x98765B0
        public void .ctor(){} // RVA: 0x98769F0
    }

    public class ApiInventoryItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9876B50
        public void get_templateId(){} // RVA: 0x358D50
        public void set_templateId(){} // RVA: 0x358D60
        public void get_name(){} // RVA: 0x3A5590
        public void set_name(){} // RVA: 0x3A55A0
        public void get_description(){} // RVA: 0x4C7C50
        public void set_description(){} // RVA: 0x4C34F0
        public void get_imageUrl(){} // RVA: 0x462D00
        public void set_imageUrl(){} // RVA: 0x464450
        public void get_attribution(){} // RVA: 0x31C010
        public void set_attribution(){} // RVA: 0x463060
        public void get_flags(){} // RVA: 0x796DE0
        public void set_flags(){} // RVA: 0xB54600
        public void get_tags(){} // RVA: 0xA1C8C0
        public void set_tags(){} // RVA: 0x9AA650
        public void get_collections(){} // RVA: 0xA085E0
        public void set_collections(){} // RVA: 0x9AA5F0
        public void get_itemType(){} // RVA: 0xA1C130
        public void set_itemType(){} // RVA: 0xAE5030
        public void get_holderId(){} // RVA: 0x348040
        public void set_holderId(){} // RVA: 0x348050
        public void get_firstAncestor(){} // RVA: 0x3480B0
        public void set_firstAncestor(){} // RVA: 0x3480C0
        public void get_firstAncestorHolderId(){} // RVA: 0x348120
        public void set_firstAncestorHolderId(){} // RVA: 0x348130
        public void get_expiryDate(){} // RVA: 0x435460
        public void set_expiryDate(){} // RVA: 0x8B8A2E0
        public void get_created_at(){} // RVA: 0x3FA100
        public void set_created_at(){} // RVA: 0x68D4D30
        public void get_updated_at(){} // RVA: 0xA96D30
        public void set_updated_at(){} // RVA: 0x9863DD0
        public void get_template_created_at(){} // RVA: 0x35E900
        public void set_template_created_at(){} // RVA: 0x9863DE0
        public void get_template_updated_at(){} // RVA: 0x35E970
        public void set_template_updated_at(){} // RVA: 0x6016310
        public void get_isArchived(){} // RVA: 0x35EAD0
        public void set_isArchived(){} // RVA: 0x35EAE0
        public void get_isSeen(){} // RVA: 0x18AA2A0
        public void set_isSeen(){} // RVA: 0x18A5C20
        public void get_last_equipped_at(){} // RVA: 0x7F7DB0
        public void set_last_equipped_at(){} // RVA: 0x3DF18C0
        public void get_equipSlots(){} // RVA: 0xA94E10
        public void set_equipSlots(){} // RVA: 0xCF6DE0
        public void get_equipSlot(){} // RVA: 0xA902E0
        public void set_equipSlot(){} // RVA: 0xCF4780
        public void get_quantity(){} // RVA: 0x1AEE360
        public void set_quantity(){} // RVA: 0x1AE8670
        public void get_quantifiable(){} // RVA: 0x13CE0D0
        public void set_quantifiable(){} // RVA: 0x13DA960
        public void get_defaultAttributes(){} // RVA: 0x507D10
        public void set_defaultAttributes(){} // RVA: 0x50A8C0
        public void get_userAttributes(){} // RVA: 0x59E660
        public void set_userAttributes(){} // RVA: 0x59F420
        public void get_validateUserAttributes(){} // RVA: 0x7F48D0
        public void set_validateUserAttributes(){} // RVA: 0x7F24D0
        public void get_notificationDetails(){} // RVA: 0xA8E870
        public void set_notificationDetails(){} // RVA: 0xDA3F70
        public void get_status(){} // RVA: 0xA933D0
        public void set_status(){} // RVA: 0xA96DC0
        public void get_metadata(){} // RVA: 0x3485F0
        public void set_metadata(){} // RVA: 0x348600
        public void get_Instantiatable(){} // RVA: 0x9876C10
        public void get_Consumable(){} // RVA: 0x9876C80
        public void get_Archivable(){} // RVA: 0x9876CF0
        public void get_Trashable(){} // RVA: 0x9876D60
        public void get_Cloneable(){} // RVA: 0x9876DD0
        public void get_Equippable(){} // RVA: 0x9876E40
        public void get_Equipped(){} // RVA: 0x9876ED0
        public void get_IsUserGenerated(){} // RVA: 0x9876F10
        public void get_IsTemplate(){} // RVA: 0x9876F80
        public void SetApiFieldsFromJson(){} // RVA: 0x98771D0 | overloaded x2
        public void GetModelForMetadataType(){} // RVA: 0x98773F0
        public void FetchList(){} // RVA: 0x9877AC0
        public void Fetch(){} // RVA: 0x9878F10
        public void SetIsArchived(){} // RVA: 0x9879240
        public void SetIsSeen(){} // RVA: 0x98796D0
        public void Consume(){} // RVA: 0x9879B60 | overloaded x2
        public void FetchInventoryTemplate(){} // RVA: 0x9879EE0
        public void FetchInventoryTemplateAsync(){} // RVA: 0x987A210
        public void FetchUserInventoryItem(){} // RVA: 0x987A3B0
        public void Equip(){} // RVA: 0x987A700
        public void ClearEquipSlot(){} // RVA: 0x987AD40
        public void SaveUserAttributes(){} // RVA: 0x987B030
        public void FetchEquipped(){} // RVA: 0x987B5A0
        public void GetAttributes(){} // RVA: 0x987BBB0
        public void GetDefaultAttributes(){} // RVA: 0x987BEA0
        public void FetchAllTemplates(){} // RVA: 0x987C0E0
    }

    public class ApiInventoryItemContainer
    {
        // ── Methods ──
        public void get_data(){} // RVA: 0x358D50
        public void set_data(){} // RVA: 0x358D60
        public void get_totalCount(){} // RVA: 0x10E5CF0
        public void set_totalCount(){} // RVA: 0x475080
        public void .ctor(){} // RVA: 0x987D7D0
    }

    public class ApiInventoryJweToken
    {
        // ── Methods ──
        public void get_token(){} // RVA: 0x358D50
        public void set_token(){} // RVA: 0x358D60
        public void RequestSpawnToken(){} // RVA: 0x987D820
        public void RequestDirectShareToken(){} // RVA: 0x987DD20
        public void RequestPedestalShareToken(){} // RVA: 0x987E270
        public void RequestClone(){} // RVA: 0x987E980
        public void .ctor(){} // RVA: 0x987EE80
    }

    public class ApiJweToken
    {
        // ── Methods ──
        public void get_token(){} // RVA: 0x358D50
        public void set_token(){} // RVA: 0x358D60
        public void get_version(){} // RVA: 0x10E5CF0
        public void set_version(){} // RVA: 0x475080
        public void .ctor(){} // RVA: 0x987F030
    }

    public class ApiLeaderboard
    {
        // ── Methods ──
        public void get_userStats(){} // RVA: 0x358D50
        public void set_userStats(){} // RVA: 0x358D60
        public void get_leaderboard(){} // RVA: 0x3A5590
        public void set_leaderboard(){} // RVA: 0x3A55A0
        public void GetCurrentLeaderboardAsync(){} // RVA: 0x987F080
        public void GetPreviousLeaderboardAsync(){} // RVA: 0x987F1B0
        public void GetAnonymizationStateAsync(){} // RVA: 0x987F2E0
        public void SetAnonymizationStateAsync(){} // RVA: 0x987F410
        public void .ctor(){} // RVA: 0x987F560
    }

    public class ApiLeaderboardAnonymizationStatus
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x3A5570
        public void set_state(){} // RVA: 0x3A5580
        public void get_displayName(){} // RVA: 0x3A5590
        public void set_displayName(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9881760
    }

    public class ApiLeaderboardData
    {
        // ── Methods ──
        public void get_startedAt(){} // RVA: 0x358D50
        public void set_startedAt(){} // RVA: 0x1F0AB90
        public void get_endsAt(){} // RVA: 0x3A5590
        public void set_endsAt(){} // RVA: 0x1F0AB80
        public void get_ranks(){} // RVA: 0x4C7C50
        public void set_ranks(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x98816C0
    }

    public class ApiLeaderboardRank
    {
        // ── Methods ──
        public void get_displayName(){} // RVA: 0x358D50
        public void set_displayName(){} // RVA: 0x358D60
        public void get_iconUrl(){} // RVA: 0x3A5590
        public void set_iconUrl(){} // RVA: 0x3A55A0
        public void get_gifts(){} // RVA: 0x1AE3800
        public void set_gifts(){} // RVA: 0x1AE6D80
        public void get_isAnonymized(){} // RVA: 0x8A89C0
        public void set_isAnonymized(){} // RVA: 0x8A4A90
        public void get_isSelf(){} // RVA: 0x8A0370
        public void set_isSelf(){} // RVA: 0x8A05B0
        public void .ctor(){} // RVA: 0x9881710
    }

    public class ApiLeaderboardUserStats
    {
        // ── Methods ──
        public void get_rank(){} // RVA: 0x1C91440
        public void set_rank(){} // RVA: 0x1C91450
        public void get_gifts(){} // RVA: 0x1C91460
        public void set_gifts(){} // RVA: 0x1C91470
        public void get_isAnonymized(){} // RVA: 0x359320
        public void set_isAnonymized(){} // RVA: 0x359330
        public void get_anonymizedDisplayName(){} // RVA: 0x4C7C50
        public void set_anonymizedDisplayName(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x9881670
    }

    public class ApiLedgerTransaction
    {
        // ── Methods ──
        public void get_Amount(){} // RVA: 0x1C91440
        public void set_Amount(){} // RVA: 0x1C91450
        public void get_RunningBalance(){} // RVA: 0x1C91460
        public void set_RunningBalance(){} // RVA: 0x1C91470
        public void get_Date(){} // RVA: 0x3A5590
        public void set_Date(){} // RVA: 0x1F0AB80
        public void get_ListingDisplayName(){} // RVA: 0x4C7C50
        public void set_ListingDisplayName(){} // RVA: 0x4C34F0
        public void get_ListingID(){} // RVA: 0x462D00
        public void set_ListingID(){} // RVA: 0x464450
        public void get_ListingType(){} // RVA: 0x31C010
        public void set_ListingType(){} // RVA: 0x463060
        public void get_Platform(){} // RVA: 0x796DE0
        public void set_Platform(){} // RVA: 0xB54600
        public void get_PurchaseId(){} // RVA: 0xA1C8C0
        public void set_PurchaseId(){} // RVA: 0x9AA650
        public void get_Reason(){} // RVA: 0x1D76590
        public void set_Reason(){} // RVA: 0x1D76550
        public void get_ReasonLabel(){} // RVA: 0xA1C130
        public void set_ReasonLabel(){} // RVA: 0xAE5030
        public void get_ToUserId(){} // RVA: 0x348040
        public void set_ToUserId(){} // RVA: 0x348050
        public void get_ToUserDisplayName(){} // RVA: 0x3480B0
        public void set_ToUserDisplayName(){} // RVA: 0x3480C0
        public void get_FromUserId(){} // RVA: 0x348120
        public void set_FromUserId(){} // RVA: 0x348130
        public void get_FromUserDisplayName(){} // RVA: 0x435460
        public void set_FromUserDisplayName(){} // RVA: 0x435470
        public void get_TransactionId(){} // RVA: 0x3FA100
        public void set_TransactionId(){} // RVA: 0x68D4D30
        public void get_TransactionLineId(){} // RVA: 0xA96D30
        public void set_TransactionLineId(){} // RVA: 0x9863DD0
        public void get_id(){} // RVA: 0x9881800
        public void .ctor(){} // RVA: 0x98818A0
    }

    public class ApiLedgerTransactions
    {
        // ── Methods ──
        public void get_StartDate(){} // RVA: 0x358D50
        public void set_StartDate(){} // RVA: 0x1F0AB90
        public void get_EndDate(){} // RVA: 0x3A5590
        public void set_EndDate(){} // RVA: 0x1F0AB80
        public void get_Transactions(){} // RVA: 0x4C7C50
        public void set_Transactions(){} // RVA: 0x4C34F0
        public void .ctor(){} // RVA: 0x98817B0
    }

    public class ApiLicense
    {
        // ── Methods ──
        public void get_LicenseId(){} // RVA: 0x358D50
        public void set_LicenseId(){} // RVA: 0x358D60
        public void get_OwnerId(){} // RVA: 0x3A5590
        public void set_OwnerId(){} // RVA: 0x3A55A0
        public void get_OwnerDisplayName(){} // RVA: 0x4C7C50
        public void set_OwnerDisplayName(){} // RVA: 0x4C34F0
        public void get_LicenseHolderId(){} // RVA: 0x462D00
        public void set_LicenseHolderId(){} // RVA: 0x464450
        public void get_LicenseHolderDisplayName(){} // RVA: 0x31C010
        public void set_LicenseHolderDisplayName(){} // RVA: 0x463060
        public void get_ForType(){} // RVA: 0x6AFD40
        public void set_ForType(){} // RVA: 0xF02F80
        public void get_ForId(){} // RVA: 0xA1C8C0
        public void set_ForId(){} // RVA: 0x9AA650
        public void get_ProductId(){} // RVA: 0xA085E0
        public void set_ProductId(){} // RVA: 0x9AA5F0
        public void get_ProductType(){} // RVA: 0xCC3CB0
        public void set_ProductType(){} // RVA: 0xCC9310
        public void get_IsActive(){} // RVA: 0x7335D40
        public void set_IsActive(){} // RVA: 0x7335D50
        public void get_UntilDate(){} // RVA: 0x348040
        public void set_UntilDate(){} // RVA: 0x1B6CD00
        public void get_IsCurrent(){} // RVA: 0x173F990
        public void set_IsCurrent(){} // RVA: 0x173EC00
        public void get_Created(){} // RVA: 0x348120
        public void set_Created(){} // RVA: 0xEB7880
        public void get_ForAction(){} // RVA: 0x435460
        public void set_ForAction(){} // RVA: 0x435470
        public void get_ForName(){} // RVA: 0x3FA100
        public void set_ForName(){} // RVA: 0x3FA110
        public void get_LicenseHolderType(){} // RVA: 0xA96D30
        public void set_LicenseHolderType(){} // RVA: 0x35E8A0
        public void get_Notes(){} // RVA: 0x35E900
        public void set_Notes(){} // RVA: 0x35E910
        public void get_Tags(){} // RVA: 0x35E970
        public void set_Tags(){} // RVA: 0x35E980
        public void get_Updated(){} // RVA: 0x3482A0
        public void set_Updated(){} // RVA: 0x63CFBB0
        public void FetchLicenses(){} // RVA: 0x98818F0
        public void FetchActiveLicenses(){} // RVA: 0x9881BF0
        public void ReadField(){} // RVA: 0x9882540
        public void WriteField(){} // RVA: 0x9882960
        public void .ctor(){} // RVA: 0x9882B70
    }

    public class ApiLicenseNote
    {
        // ── Methods ──
        public void get_CreatedAt(){} // RVA: 0x358D50
        public void set_CreatedAt(){} // RVA: 0x1F0AB90
        public void get_Note(){} // RVA: 0x3A5590
        public void set_Note(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9882D40
    }

    public class ApiListContainer
    {
        // ── Methods ──
        public void get_ResponseList(){} // RVA: 0x98CC2B0
        public void get_TotalCount(){} // RVA: 0x59CEC0
        public void set_TotalCount(){} // RVA: 0x59C530
        public void Validate(){} // RVA: 0x98CC320
        public void .ctor(){} // RVA: 0x98CC6A0
    }

    public class ApiLoadingScreen
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_assetBundleId(){} // RVA: 0x3A5590
        public void set_assetBundleId(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9882D90
    }

    public class ApiLocalizableString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
    }

    public class ApiMessage
    {
        // ── Methods ──
        public void get_slot(){} // RVA: 0x1C91440
        public void set_slot(){} // RVA: 0x1C91450
        public void get_message(){} // RVA: 0x3A5590
        public void set_message(){} // RVA: 0x3A55A0
        public void get_messageType(){} // RVA: 0x4C7C50
        public void set_messageType(){} // RVA: 0x4C34F0
        public void get_updatedAt(){} // RVA: 0x462D00
        public void set_updatedAt(){} // RVA: 0x1F0ABA0
        public void get_remainingCooldownMinutes(){} // RVA: 0xBB90C0
        public void set_remainingCooldownMinutes(){} // RVA: 0xBB9E60
        public void get_canBeUpdated(){} // RVA: 0x345520
        public void set_canBeUpdated(){} // RVA: 0x345530
        public void .ctor(){} // RVA: 0x9882DE0
        public void FetchMessages(){} // RVA: 0x9882FB0 | overloaded x2
        public void DeleteAllMessages(){} // RVA: 0x9883450 | overloaded x2
        public void DeleteMessageInSlot(){} // RVA: 0x9883910 | overloaded x2
        public void SetMessageInSlot(){} // RVA: 0x9883E60 | overloaded x2
        public void truncatedMessage(){} // RVA: 0x9884490
        public void ToString(){} // RVA: 0x9884500
        public void .cctor(){} // RVA: 0x9884710
    }

    public class ApiModel
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x2F8380
        public void set_id(){} // RVA: 0x2DEE30
        public void get_ExpiryTime(){} // RVA: 0x994EE0
        public void set_ExpiryTime(){} // RVA: 0x9949A0
        public void get_Populated(){} // RVA: 0x6E8A80
        public void set_Populated(){} // RVA: 0x6E8B80
        public void get_FailedValidation(){} // RVA: 0xC36000
        public void set_FailedValidation(){} // RVA: 0x190AB20
        public void get_Endpoint(){} // RVA: 0x6374D0
        public void set_Endpoint(){} // RVA: 0x30B890
        public void GetOrPutCachedMissingFieldList(){} // RVA: 0x9884C20
        public void get_FieldsMissingFromOriginalResponse(){} // RVA: 0x358730
        public void set_FieldsMissingFromOriginalResponse(){} // RVA: 0x358740
        public void get_FieldsLockedForNetworkUpdates(){} // RVA: 0x37E0E0
        public void set_FieldsLockedForNetworkUpdates(){} // RVA: 0x4354D0
        public void GetCacheId(){} // RVA: 0x9885500
        public void ComputeCacheId(){} // RVA: 0x98857C0
        public void ShouldCache(){} // RVA: 0x9885BD0
        public void GetLifeSpan(){} // RVA: 0x9885C10
        public void .ctor(){} // RVA: 0x9885CF0 | overloaded x3
        public void Clone(){} // RVA: 0x9885F80 | overloaded x3
        public void Save(){} // RVA: 0x98864D0
        public void SaveField(){} // RVA: 0x9886510
        public void Post(){} // RVA: 0x98867E0
        public void Put(){} // RVA: 0x9886820
        public void Fetch(){} // RVA: 0x9886860
        public void PostAsync(){} // RVA: 0x283FA0
        public void PutAsync(){} // RVA: 0x283FA0
        public void FetchAsync(){} // RVA: 0x283FA0
        public void Get(){} // RVA: 0x9886890
        public void PostOrPut(){} // RVA: 0x9887100
        public void Delete(){} // RVA: 0x98888E0
        public void DeleteAsync(){} // RVA: 0x9888B80
        public void SetApiFieldsFromJson(){} // RVA: 0x9889E70 | overloaded x4
        public void PopulateMissingValuesFrom(){} // RVA: 0x988ABD0
        public void ExtractApiFields(){} // RVA: 0x988B090
        public void MakeModelContainer(){} // RVA: 0x988B470
        public void ReadField(){} // RVA: 0x988B6F0
        public void TryReadConvert(){} // RVA: 0x988BAE0
        public void WriteField(){} // RVA: 0x988CF90
        public void CopyDeserializedValuesTo(){} // RVA: 0x2DD320
        public void GetCreateFromJsonMethodInfo(){} // RVA: 0x988DF10
        public void ParseEnumValue(){} // RVA: 0x283FA0 | overloaded x2
        public void IsNumber(){} // RVA: 0x988E500
        public void DoubleCast(){} // RVA: 0x988E5B0
        public void TryWriteConvert(){} // RVA: 0x988E980
        public void ParseList(){} // RVA: 0x988FA90
        public void ParseDictionary(){} // RVA: 0x988FF50
        public void ParseModel(){} // RVA: 0x9890750
        public void ParseLocalizableString(){} // RVA: 0x98909A0
        public void SendGetRequest(){} // RVA: 0x9890B80
        public void SendPutRequest(){} // RVA: 0x9890E30
        public void MakeRequestEndpoint(){} // RVA: 0x9890F00
        public void get_RequiredProperties(){} // RVA: 0x9890FB0
        public void get_TargetProperties(){} // RVA: 0x98915F0
        public void FindPropertyName(){} // RVA: 0x9891A10
        public void FindProperty(){} // RVA: 0x9891D20
        public void IsAdminWritableOnly(){} // RVA: 0x9892210
        public void IsApiWritableOnly(){} // RVA: 0x9892400
        public void .cctor(){} // RVA: 0x98925F0
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50 | overloaded x2
        public void ValidModelData(){} // RVA: 0xDBE0
        public void Validate(){}
    }

    public class ApiModelListContainer`1
    {
        // ── Methods ──
        public void get_ResponseModels(){} // RVA: 0xCD60
        public void set_ResponseModels(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x24A50
        public void Validate(){}
    }

    public class ApiModeration
    {
        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x1C91440
        public void set_moderationType(){} // RVA: 0x1C91450
        public void get_moderatorUserId(){} // RVA: 0x3A5590
        public void set_moderatorUserId(){} // RVA: 0x3A55A0
        public void get_moderatorDisplayName(){} // RVA: 0x4C7C50
        public void set_moderatorDisplayName(){} // RVA: 0x4C34F0
        public void get_targetUserId(){} // RVA: 0x462D00
        public void set_targetUserId(){} // RVA: 0x464450
        public void get_targetDisplayName(){} // RVA: 0x31C010
        public void set_targetDisplayName(){} // RVA: 0x463060
        public void get_reasonMessage(){} // RVA: 0x796DE0
        public void set_reasonMessage(){} // RVA: 0xB54600
        public void get_details(){} // RVA: 0xA1C8C0
        public void set_details(){} // RVA: 0x9AA650
        public void get_created(){} // RVA: 0xA085E0
        public void set_created(){} // RVA: 0x5FF62E0
        public void get_expires(){} // RVA: 0xA1C130
        public void set_expires(){} // RVA: 0x1B6C650
        public void get_isPermanent(){} // RVA: 0x173F990
        public void set_isPermanent(){} // RVA: 0x173EC00
        public void get_worldId(){} // RVA: 0x348120
        public void set_worldId(){} // RVA: 0x348130
        public void get_instanceId(){} // RVA: 0x435460
        public void set_instanceId(){} // RVA: 0x435470
        public void .ctor(){} // RVA: 0x9893CF0 | overloaded x2
        public void ShouldCache(){} // RVA: 0x2DD320
        public void ReadField(){} // RVA: 0x9893D90
        public void WriteField(){} // RVA: 0x9894210
        public void SendModeration(){} // RVA: 0x9894440
        public void SendVoteKick(){} // RVA: 0x9894800
        public void DeleteModeration(){} // RVA: 0x9894B30
        public void LocalFetchAll(){} // RVA: 0x9894D50
        public void ModerationTimeRangeToString(){} // RVA: 0x9895050
        public void ContestModeration(){} // RVA: 0x98950F0
    }

    public class ApiModerationResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ApiModerationResultExtensions
    {
        // ── Methods ──
        public void WasModerated(){} // RVA: 0x98BDC80
        public void GetModerationResult(){} // RVA: 0x98BDCA0
    }

    public class ApiMutualFriend
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x2F8380
        public void set_id(){} // RVA: 0x2DEE30
        public void get_displayName(){} // RVA: 0x358D50
        public void set_displayName(){} // RVA: 0x358D60
        public void get_status(){} // RVA: 0x3A5590
        public void set_status(){} // RVA: 0x3A55A0
        public void get_statusDescription(){} // RVA: 0x4C7C50
        public void set_statusDescription(){} // RVA: 0x4C34F0
        public void get_currentAvatarImageUrl(){} // RVA: 0x462D00
        public void set_currentAvatarImageUrl(){} // RVA: 0x464450
        public void get_avatarThumbnail(){} // RVA: 0x31C010
        public void set_avatarThumbnail(){} // RVA: 0x463060
        public void get_currentAvatarTags(){} // RVA: 0x796DE0
        public void set_currentAvatarTags(){} // RVA: 0xB54600
        public void get_profilePicOverride(){} // RVA: 0xA1C8C0
        public void set_profilePicOverride(){} // RVA: 0x9AA650
        public void get_userIcon(){} // RVA: 0xA085E0
        public void set_userIcon(){} // RVA: 0x9AA5F0
        public void get_world(){} // RVA: 0xA1C130
        public void set_world(){} // RVA: 0xAE5030
        public void get_instance(){} // RVA: 0x348040
        public void set_instance(){} // RVA: 0x348050
        public void get_instanceType(){} // RVA: 0x3480B0
        public void set_instanceType(){} // RVA: 0x3480C0
        public void get_travelingToWorld(){} // RVA: 0x348120
        public void set_travelingToWorld(){} // RVA: 0x348130
        public void get_travelingToInstance(){} // RVA: 0x435460
        public void set_travelingToInstance(){} // RVA: 0x435470
        public void get_platform(){} // RVA: 0x3FA100
        public void set_platform(){} // RVA: 0x3FA110
        public void get_groups(){} // RVA: 0xA96D30
        public void set_groups(){} // RVA: 0x35E8A0
        public void get_profilePicImageUrl(){} // RVA: 0x9929480
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x99294A0
        public void FetchMutualFriendsAsync(){} // RVA: 0x99294D0
        public void .ctor(){} // RVA: 0x99296A0
    }

    public class ApiMutualGroup
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x2F8380
        public void set_id(){} // RVA: 0x2DEE30
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_discriminator(){} // RVA: 0x3A5590
        public void set_discriminator(){} // RVA: 0x3A55A0
        public void get_ownerId(){} // RVA: 0x4C7C50
        public void set_ownerId(){} // RVA: 0x4C34F0
        public void get_privacy(){} // RVA: 0x462D00
        public void set_privacy(){} // RVA: 0x464450
        public void get_memberCount(){} // RVA: 0xBB90C0
        public void set_memberCount(){} // RVA: 0xBB9E60
        public void get_shortCode(){} // RVA: 0x796DE0
        public void set_shortCode(){} // RVA: 0xB54600
        public void get_description(){} // RVA: 0xA1C8C0
        public void set_description(){} // RVA: 0x9AA650
        public void get_bannerId(){} // RVA: 0xA085E0
        public void set_bannerId(){} // RVA: 0x9AA5F0
        public void get_bannerUrl(){} // RVA: 0xA1C130
        public void set_bannerUrl(){} // RVA: 0xAE5030
        public void get_iconId(){} // RVA: 0x348040
        public void set_iconId(){} // RVA: 0x348050
        public void get_iconUrl(){} // RVA: 0x3480B0
        public void set_iconUrl(){} // RVA: 0x3480C0
        public void get_lastPostCreatedAt(){} // RVA: 0x348120
        public void set_lastPostCreatedAt(){} // RVA: 0x348130
        public void FetchMutualGroupsAsync(){} // RVA: 0x992A380
        public void .ctor(){} // RVA: 0x992A550
    }

    public class ApiNotification
    {
        // ── Methods ──
        public void get_version(){} // RVA: 0x1C91440
        public void set_version(){} // RVA: 0x1C91450
        public void get_notificationType(){} // RVA: 0x1C91460
        public void set_notificationType(){} // RVA: 0x1C91470
        public void get_category(){} // RVA: 0x3A5590
        public void set_category(){} // RVA: 0x3A55A0
        public void get_isSystem(){} // RVA: 0x8A10E0
        public void set_isSystem(){} // RVA: 0x1688890
        public void get_senderUserId(){} // RVA: 0x462D00
        public void set_senderUserId(){} // RVA: 0x464450
        public void get_senderUsername(){} // RVA: 0x31C010
        public void set_senderUsername(){} // RVA: 0x463060
        public void get_receiverUserId(){} // RVA: 0x796DE0
        public void set_receiverUserId(){} // RVA: 0xB54600
        public void get_relatedNotificationsId(){} // RVA: 0xA1C8C0
        public void set_relatedNotificationsId(){} // RVA: 0x9AA650
        public void get_title(){} // RVA: 0xA085E0
        public void set_title(){} // RVA: 0x9AA5F0
        public void get_titleKey(){} // RVA: 0xA1C130
        public void set_titleKey(){} // RVA: 0xAE5030
        public void get_message(){} // RVA: 0x348040
        public void set_message(){} // RVA: 0x348050
        public void get_messageKey(){} // RVA: 0x3480B0
        public void set_messageKey(){} // RVA: 0x3480C0
        public void get_imageUrl(){} // RVA: 0x348120
        public void set_imageUrl(){} // RVA: 0x348130
        public void get_link(){} // RVA: 0x435460
        public void set_link(){} // RVA: 0x435470
        public void get_linkText(){} // RVA: 0x3FA100
        public void set_linkText(){} // RVA: 0x3FA110
        public void get_linkTextKey(){} // RVA: 0xA96D30
        public void set_linkTextKey(){} // RVA: 0x35E8A0
        public void get_responses(){} // RVA: 0x35E900
        public void set_responses(){} // RVA: 0x35E910
        public void get_expiresAt(){} // RVA: 0x35E970
        public void set_expiresAt(){} // RVA: 0x6016310
        public void get_expiryAfterSeen(){} // RVA: 0x3482A0
        public void set_expiryAfterSeen(){} // RVA: 0x63CFBB0
        public void get_seen(){} // RVA: 0x1209D80
        public void set_seen(){} // RVA: 0x7016FA0
        public void get_ignoreDND(){} // RVA: 0x339F90
        public void set_ignoreDND(){} // RVA: 0x339FA0
        public void get_canDelete(){} // RVA: 0x8B8A2F0
        public void set_canDelete(){} // RVA: 0x8B89CD0
        public void get_created_at(){} // RVA: 0xA94E10
        public void set_created_at(){} // RVA: 0x1702E00
        public void get_createdAt(){} // RVA: 0xA902E0
        public void set_createdAt(){} // RVA: 0x507D00
        public void get_updatedAt(){} // RVA: 0x507710
        public void set_updatedAt(){} // RVA: 0x63CFC00
        public void get_details(){} // RVA: 0x507D10
        public void set_details(){} // RVA: 0x50A8C0
        public void get_data(){} // RVA: 0x59E660
        public void set_data(){} // RVA: 0x59F420
        public void get_jobName(){} // RVA: 0xA8EE80
        public void set_jobName(){} // RVA: 0xD182E0
        public void get_jobColor(){} // RVA: 0xA8E870
        public void set_jobColor(){} // RVA: 0xDA3F70
        public void .ctor(){} // RVA: 0x98BDF80
        public void ShouldCache(){} // RVA: 0x2DD320
        public void ReadField(){} // RVA: 0x98BE020
        public void WriteField(){} // RVA: 0x98BE260
    }

    public class ApiPagedTransactions
    {
        // ── Methods ──
        public void get_Transactions(){} // RVA: 0x358D50
        public void set_Transactions(){} // RVA: 0x358D60
        public void get_TotalCount(){} // RVA: 0x10E5CF0
        public void set_TotalCount(){} // RVA: 0x475080
        public void FetchTransactions(){} // RVA: 0x98D2E60
        public void .ctor(){} // RVA: 0x98D3F60
    }

    public class ApiPendingTransaction
    {
        // ── Methods ──
        public void get_userId(){} // RVA: 0x358D50
        public void set_userId(){} // RVA: 0x358D60
        public void get_userDisplayName(){} // RVA: 0x3A5590
        public void set_userDisplayName(){} // RVA: 0x3A55A0
        public void get_targetUserId(){} // RVA: 0x4C7C50
        public void set_targetUserId(){} // RVA: 0x4C34F0
        public void get_targetDisplayName(){} // RVA: 0x462D00
        public void set_targetDisplayName(){} // RVA: 0x464450
        public void get_status(){} // RVA: 0x31C010
        public void set_status(){} // RVA: 0x463060
        public void get_pico(){} // RVA: 0x796DE0
        public void set_pico(){} // RVA: 0xB54600
        public void get_gplay(){} // RVA: 0xA1C8C0
        public void set_gplay(){} // RVA: 0x9AA650
        public void get_subscription(){} // RVA: 0xA085E0
        public void set_subscription(){} // RVA: 0x9AA5F0
        public void get_created_at(){} // RVA: 0xA1C130
        public void set_created_at(){} // RVA: 0xAE5030
        public void get_updated_at(){} // RVA: 0x348040
        public void set_updated_at(){} // RVA: 0x348050
        public void get_isGift(){} // RVA: 0x173F990
        public void set_isGift(){} // RVA: 0x173EC00
        public void get_isTokens(){} // RVA: 0x38EED40
        public void set_isTokens(){} // RVA: 0x38EED50
        public void .ctor(){} // RVA: 0x98F3090
    }

    public class ApiPlayerModeration
    {
        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x1C91440
        public void set_moderationType(){} // RVA: 0x1C91450
        public void get_targetUserId(){} // RVA: 0x3A5590
        public void set_targetUserId(){} // RVA: 0x3A55A0
        public void get_targetDisplayName(){} // RVA: 0x4C7C50
        public void set_targetDisplayName(){} // RVA: 0x4C34F0
        public void get_sourceUserId(){} // RVA: 0x462D00
        public void set_sourceUserId(){} // RVA: 0x464450
        public void get_sourceDisplayName(){} // RVA: 0x31C010
        public void set_sourceDisplayName(){} // RVA: 0x463060
        public void get_created(){} // RVA: 0x796DE0
        public void set_created(){} // RVA: 0x1CBA190
        public void .ctor(){} // RVA: 0x98BE3B0
        public void CreateRemovalModeration(){} // RVA: 0x98BE470
        public void ShouldCache(){} // RVA: 0x2DD320
        public void ReadField(){} // RVA: 0x98BE530
        public void WriteField(){} // RVA: 0x98BE730
        public void SendModeration(){} // RVA: 0x98BE910
        public void DeleteModeration(){} // RVA: 0x98BEB50
        public void FetchAllAgainstMe(){} // RVA: 0x98BF110
        public void FetchAllMine(){} // RVA: 0x98BF160
        public void FetchList(){} // RVA: 0x98BF1B0
        public void ModerationTypeToAPIString(){} // RVA: 0x98BF490
    }

}