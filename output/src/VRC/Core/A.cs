// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 100
// Methods: 1978

namespace VRC.Core
{
    public class API
    {
        // ── Methods ──
        public void get_ClientGameServerVersion(){} // RVA: 0x7FFAFC301580
        public void .cctor(){} // RVA: 0x7FFAFC3015E0
        public void RegisterLogging(){} // RVA: 0x7FFAFC301B30
        public void SetClientVersion(){} // RVA: 0x7FFAFC301BE0
        public void GetClientVersion(){} // RVA: 0x7FFAFC301CA0
        public void SetStore(){} // RVA: 0x7FFAFC301D00
        public void GetStore(){} // RVA: 0x7FFAFC301DC0
        public void SetAllowRoaming(){} // RVA: 0x7FFAFC301E20
        public void GetAllowRoaming(){} // RVA: 0x7FFAFC301E80
        public void SetClientGameServerVersion(){} // RVA: 0x7FFAFC301EE0
        public void IsReady(){} // RVA: 0x7FFAFC301F40
        public void FromCacheOrNew(){} // RVA: 0x7FFAF2D33FA0
        public void CreateFromJson(){} // RVA: 0x7FFAF2D33FA0
        public void Fetch(){} // RVA: 0x7FFAF2D33FA0
        public void FetchAsync(){} // RVA: 0x7FFAF2ACD930
        public void DeleteAsync(){} // RVA: 0x7FFAF2ABCE50
        public void Delete(){} // RVA: 0x7FFAF2ADA310
        public void get_DeviceID(){} // RVA: 0x7FFAF8E30700
        public void SetApiUrlFromEnvironment(){} // RVA: 0x7FFAFC301FE0
        public void GetApiUrlForEnvironment(){} // RVA: 0x7FFAFC3021E0
        public void SetApiUrl(){} // RVA: 0x7FFAFC302310
        public void GetApiUrl(){} // RVA: 0x7FFAFC3023C0
        public void IsDevApi(){} // RVA: 0x7FFAFC302420
        public void IsDevCeApi(){} // RVA: 0x7FFAFC302500
        public void SendGetRequest(){} // RVA: 0x7FFAFC3025E0
        public void SendPostRequest(){} // RVA: 0x7FFAFC302700
        public void SendPostFormRequest(){} // RVA: 0x7FFAFC302820
        public void SendPostRawJsonRequest(){} // RVA: 0x7FFAFC302940
        public void SendPutRequest(){} // RVA: 0x7FFAFC302A60
        public void SendDeleteRequest(){} // RVA: 0x7FFAFC302B80
        public void SendRequest(){} // RVA: 0x7FFAFC302CA0
        public void SendRequestInternal(){} // RVA: 0x7FFAFC3033D0
        public void AuthenticateHTTPRequest(){} // RVA: 0x7FFAFC304970
        public void AuthenticateUnityWebRequest(){} // RVA: 0x7FFAFC304DE0
        public void PopulateHTTPRequestHeaders(){} // RVA: 0x7FFAFC305130
        public void PopulateUnityWebRequestHeaders(){} // RVA: 0x7FFAFC3055C0
        public void CertVerifyHTTPRequest(){} // RVA: 0x7FFAFC305890
        public void CertVerifyUnityWebRequest(){} // RVA: 0x7FFAFC305A40
        public void InitializeCertificateVerifier(){} // RVA: 0x7FFAFC305D00
        public void AppendQuery(){} // RVA: 0x7FFAFC305E30
        public void ConvertJsonListToModelList(){} // RVA: 0x7FFAF2ABCEC0
        public void get_IsVRCClient(){} // RVA: 0x7FFAFC305EE0
        public void set_IsVRCClient(){} // RVA: 0x7FFAFC305F40
        public void SetOnlineMode(){} // RVA: 0x7FFAFC305FA0
        public void ClearOnlineMode(){} // RVA: 0x7FFAFC306370
        public void IsOffline(){} // RVA: 0x7FFAFC306420
        public void GetServerEnvironmentForApiUrl(){} // RVA: 0x7FFAFC3064E0 | overloaded x2
        public void SendOfflineRequest(){} // RVA: 0x7FFAFC3067A0
        public void GenerateMergeCode(){} // RVA: 0x7FFAFC306E70
    }

    public class API2FA
    {
        // ── Methods ──
        public void get_requiresTwoFactorAuth(){} // RVA: 0x7FFAF2E08D50
        public void set_requiresTwoFactorAuth(){} // RVA: 0x7FFAF2E08D60
        public void get_scope(){} // RVA: 0x7FFAF2E55590
        public void set_scope(){} // RVA: 0x7FFAF2E555A0
        public void get_ticket(){} // RVA: 0x7FFAF2F77C50
        public void set_ticket(){} // RVA: 0x7FFAF2F734F0
        public void TimeBasedOneTimePasswordSupported(){} // RVA: 0x7FFAFC307AC0
        public void EmailBasedOneTimePasswordSupported(){} // RVA: 0x7FFAFC307B20
        public void OneTimePasswordSupported(){} // RVA: 0x7FFAFC307B80
        public void SmsSupported(){} // RVA: 0x7FFAFC307BE0
        public void ToString(){} // RVA: 0x7FFAFC307C40
        public void .ctor(){} // RVA: 0x7FFAFC307EA0
    }

    public class APIActivationSuccessfulTargetResult
    {
        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFAF2E08D50
        public void set_userId(){} // RVA: 0x7FFAF2E08D60
        public void get_gifts(){} // RVA: 0x7FFAF3B95CF0
        public void set_gifts(){} // RVA: 0x7FFAF2F25080
        public void get_isFriend(){} // RVA: 0x7FFAF3BD0170
        public void set_isFriend(){} // RVA: 0x7FFAF84DDFE0
        public void .ctor(){} // RVA: 0x7FFAFC324100
    }

    public class APICalendarEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3C5E30
        public void get_ownerId(){} // RVA: 0x7FFAF2E08D50
        public void set_ownerId(){} // RVA: 0x7FFAF2E08D60
        public void get_accessType(){} // RVA: 0x7FFAF3B95CF0
        public void set_accessType(){} // RVA: 0x7FFAF2F25080
        public void get_startsAt(){} // RVA: 0x7FFAF2F77C50
        public void set_startsAt(){} // RVA: 0x7FFAF855F010
        public void get_endsAt(){} // RVA: 0x7FFAF2F12D00
        public void set_endsAt(){} // RVA: 0x7FFAF49BABA0
        public void get_title(){} // RVA: 0x7FFAF2DCC010
        public void set_title(){} // RVA: 0x7FFAF2F13060
        public void get_description(){} // RVA: 0x7FFAF3246DE0
        public void set_description(){} // RVA: 0x7FFAF3604600
        public void get_category(){} // RVA: 0x7FFAF34CC8C0
        public void set_category(){} // RVA: 0x7FFAF345A650
        public void get_shortCode(){} // RVA: 0x7FFAF34B85E0
        public void set_shortCode(){} // RVA: 0x7FFAF345A5F0
        public void get_type(){} // RVA: 0x7FFAF34CC130
        public void set_type(){} // RVA: 0x7FFAF3595030
        public void get_isDraft(){} // RVA: 0x7FFAF41E23D0
        public void set_isDraft(){} // RVA: 0x7FFAF41E5610
        public void get_imageId(){} // RVA: 0x7FFAF2DF80B0
        public void set_imageId(){} // RVA: 0x7FFAF2DF80C0
        public void get_imageUrl(){} // RVA: 0x7FFAF2DF8120
        public void set_imageUrl(){} // RVA: 0x7FFAF2DF8130
        public void get_roleIds(){} // RVA: 0x7FFAF2EE5460
        public void set_roleIds(){} // RVA: 0x7FFAF2EE5470
        public void get_tags(){} // RVA: 0x7FFAF2EAA100
        public void set_tags(){} // RVA: 0x7FFAF2EAA110
        public void get_platforms(){} // RVA: 0x7FFAF3546D30
        public void set_platforms(){} // RVA: 0x7FFAF2E0E8A0
        public void get_languages(){} // RVA: 0x7FFAF2E0E900
        public void set_languages(){} // RVA: 0x7FFAF2E0E910
        public void get_parentId(){} // RVA: 0x7FFAF2E0E970
        public void set_parentId(){} // RVA: 0x7FFAF2E0E980
        public void get_hostEarlyJoinMinutes(){} // RVA: 0x7FFAF61E9380
        public void set_hostEarlyJoinMinutes(){} // RVA: 0x7FFAF8D2A290
        public void get_guestEarlyJoinMinutes(){} // RVA: 0x7FFAF68A1880
        public void set_guestEarlyJoinMinutes(){} // RVA: 0x7FFAF68A1890
        public void get_closeInstanceAfterEndMinutes(){} // RVA: 0x7FFAF9D86570
        public void set_closeInstanceAfterEndMinutes(){} // RVA: 0x7FFAFBEE9450
        public void get_usesInstanceOverflow(){} // RVA: 0x7FFAFC375AF0
        public void set_usesInstanceOverflow(){} // RVA: 0x7FFAFC375B00
        public void get_deletedAt(){} // RVA: 0x7FFAF3544E10
        public void set_deletedAt(){} // RVA: 0x7FFAF41B2E00
        public void get_userInterest(){} // RVA: 0x7FFAF35402E0
        public void set_userInterest(){} // RVA: 0x7FFAF37A4780
        public void get_featured(){} // RVA: 0x7FFAF311C530
        public void set_featured(){} // RVA: 0x7FFAF311C8F0
        public void get_interestedUserCount(){} // RVA: 0x7FFAF9A5CBE0
        public void set_interestedUserCount(){} // RVA: 0x7FFAF9A5CBF0
        public void UpdateData(){} // RVA: 0x7FFAFC3C5E80
        public void WriteField(){} // RVA: 0x7FFAFC3C6640
    }

    public class APICalendarEntryUserInterest
    {
        // ── Methods ──
        public void get_isFollowing(){} // RVA: 0x7FFAF2E55570
        public void set_isFollowing(){} // RVA: 0x7FFAF2E55580
        public void get_createdAt(){} // RVA: 0x7FFAF2E55590
        public void set_createdAt(){} // RVA: 0x7FFAF49BAB80
        public void get_updatedAt(){} // RVA: 0x7FFAF2F77C50
        public void set_updatedAt(){} // RVA: 0x7FFAF855F010
        public void .ctor(){} // RVA: 0x7FFAFC3C6AD0
    }

    public class APIEmoji
    {
        // ── Methods ──
        public void get_fileId(){} // RVA: 0x7FFAF2E08D50
        public void set_fileId(){} // RVA: 0x7FFAF2E08D60
        public void get_imageUrl(){} // RVA: 0x7FFAF2E55590
        public void set_imageUrl(){} // RVA: 0x7FFAF2E555A0
        public void get_animationStyle(){} // RVA: 0x7FFAF2F77C50
        public void set_animationStyle(){} // RVA: 0x7FFAF2F734F0
        public void get_maskTag(){} // RVA: 0x7FFAF2F12D00
        public void set_maskTag(){} // RVA: 0x7FFAF2F14450
        public void get_animated(){} // RVA: 0x7FFAF3DF2AB0
        public void set_animated(){} // RVA: 0x7FFAF3BA2C40
        public void get_frames(){} // RVA: 0x7FFAF60EA7C0
        public void set_frames(){} // RVA: 0x7FFAF672AFE0
        public void get_framesOverTime(){} // RVA: 0x7FFAF315FD40
        public void set_framesOverTime(){} // RVA: 0x7FFAF39B2F80
        public void get_loopStyle(){} // RVA: 0x7FFAF34CC8C0
        public void set_loopStyle(){} // RVA: 0x7FFAF345A650
        public void get_assetBundleId(){} // RVA: 0x7FFAF34B85E0
        public void set_assetBundleId(){} // RVA: 0x7FFAF345A5F0
        public void get_premium(){} // RVA: 0x7FFAF3056180
        public void set_premium(){} // RVA: 0x7FFAF304E530
        public void UploadEmoji(){} // RVA: 0x7FFAFC319E40 | overloaded x2
        public void Fetch(){} // RVA: 0x7FFAFC31A4A0
        public void .ctor(){} // RVA: 0x7FFAFC31A7D0
        public void <Fetch>g__ParseData|45_0(){} // RVA: 0x7FFAFC31A840
    }

    public class APIGiftActivationResult
    {
        // ── Methods ──
        public void get_dropValidationToken(){} // RVA: 0x7FFAF2E08D50
        public void set_dropValidationToken(){} // RVA: 0x7FFAF2E08D60
        public void get_giftValidationToken(){} // RVA: 0x7FFAF2E55590
        public void set_giftValidationToken(){} // RVA: 0x7FFAF2E555A0
        public void get_successfulGifts(){} // RVA: 0x7FFAF2F77C50
        public void set_successfulGifts(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAFC3240B0
    }

    public class APIGiftBundle
    {
        // ── Methods ──
        public void get_steamItemId(){} // RVA: 0x7FFAF2E08D50
        public void set_steamItemId(){} // RVA: 0x7FFAF2E08D60
        public void get_oculusSku(){} // RVA: 0x7FFAF2E55590
        public void set_oculusSku(){} // RVA: 0x7FFAF2E555A0
        public void get_googleProductId(){} // RVA: 0x7FFAF2F77C50
        public void set_googleProductId(){} // RVA: 0x7FFAF2F734F0
        public void get_googlePlanId(){} // RVA: 0x7FFAF2F12D00
        public void set_googlePlanId(){} // RVA: 0x7FFAF2F14450
        public void get_picoSku(){} // RVA: 0x7FFAF2DCC010
        public void set_picoSku(){} // RVA: 0x7FFAF2F13060
        public void get_amount(){} // RVA: 0x7FFAF315FD40
        public void set_amount(){} // RVA: 0x7FFAF39B2F80
        public void get_description(){} // RVA: 0x7FFAF34CC8C0
        public void set_description(){} // RVA: 0x7FFAF345A650
        public void get_period(){} // RVA: 0x7FFAF34B85E0
        public void set_period(){} // RVA: 0x7FFAF345A5F0
        public void get_periodAmount(){} // RVA: 0x7FFAF3773CB0
        public void set_periodAmount(){} // RVA: 0x7FFAF3779310
        public void get_tier(){} // RVA: 0x7FFAF66F9C20
        public void set_tier(){} // RVA: 0x7FFAF66F9C30
        public void get_bulkSize(){} // RVA: 0x7FFAF4B867F0
        public void set_bulkSize(){} // RVA: 0x7FFAF8ACE410
        public void get_discountPercentage(){} // RVA: 0x7FFAF68A1350
        public void set_discountPercentage(){} // RVA: 0x7FFAF68A1360
        public void get_licenseGroups(){} // RVA: 0x7FFAF2DF80B0
        public void set_licenseGroups(){} // RVA: 0x7FFAF2DF80C0
        public void .ctor(){} // RVA: 0x7FFAFC324010
    }

    public class APIGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3CA5F0 | overloaded x2
        public void get_ownerId(){} // RVA: 0x7FFAF2E08D50
        public void set_ownerId(){} // RVA: 0x7FFAF2E08D60
        public void get_name(){} // RVA: 0x7FFAF2E55590
        public void set_name(){} // RVA: 0x7FFAF2E555A0
        public void get_shortCode(){} // RVA: 0x7FFAF2F77C50
        public void set_shortCode(){} // RVA: 0x7FFAF2F734F0
        public void get_discriminator(){} // RVA: 0x7FFAF2F12D00
        public void set_discriminator(){} // RVA: 0x7FFAF2F14450
        public void get_description(){} // RVA: 0x7FFAF2DCC010
        public void set_description(){} // RVA: 0x7FFAF2F13060
        public void get_iconUrl(){} // RVA: 0x7FFAF3246DE0
        public void set_iconUrl(){} // RVA: 0x7FFAF3604600
        public void get_bannerUrl(){} // RVA: 0x7FFAF34CC8C0
        public void set_bannerUrl(){} // RVA: 0x7FFAF345A650
        public void get_memberCount(){} // RVA: 0x7FFAF4826590
        public void set_memberCount(){} // RVA: 0x7FFAF4826550
        public void get_onlineMemberCount(){} // RVA: 0x7FFAF66F9C00
        public void set_onlineMemberCount(){} // RVA: 0x7FFAF66F9C10
        public void get_memberCountSyncedAt(){} // RVA: 0x7FFAF34CC130
        public void set_memberCountSyncedAt(){} // RVA: 0x7FFAF3595030
        public void get_privacy(){} // RVA: 0x7FFAF2DF8040
        public void set_privacy(){} // RVA: 0x7FFAF2DF8050
        public void get_joinState(){} // RVA: 0x7FFAF2DF80B0
        public void set_joinState(){} // RVA: 0x7FFAF2DF80C0
        public void get_myMember(){} // RVA: 0x7FFAF2DF8120
        public void set_myMember(){} // RVA: 0x7FFAF2DF8130
        public void get_createdAt(){} // RVA: 0x7FFAF2EE5460
        public void set_createdAt(){} // RVA: 0x7FFAFB63A2E0
        public void get_updatedAt(){} // RVA: 0x7FFAF2EAA100
        public void set_updatedAt(){} // RVA: 0x7FFAF9384D30
        public void get_membershipStatus(){} // RVA: 0x7FFAF3546D30
        public void set_membershipStatus(){} // RVA: 0x7FFAF2E0E8A0
        public void get_bannerId(){} // RVA: 0x7FFAF2E0E900
        public void set_bannerId(){} // RVA: 0x7FFAF2E0E910
        public void get_iconId(){} // RVA: 0x7FFAF2E0E970
        public void set_iconId(){} // RVA: 0x7FFAF2E0E980
        public void get_rules(){} // RVA: 0x7FFAF2DF82A0
        public void set_rules(){} // RVA: 0x7FFAF2DF82B0
        public void get_initialRoleIds(){} // RVA: 0x7FFAF32A7DB0
        public void set_initialRoleIds(){} // RVA: 0x7FFAF30ED280
        public void get_isSystemGroup(){} // RVA: 0x7FFAF3CC08C0
        public void set_isSystemGroup(){} // RVA: 0x7FFAF3CBE9D0
        public void get_isVerified(){} // RVA: 0x7FFAF461CE60
        public void set_isVerified(){} // RVA: 0x7FFAF461CD60
        public void get_galleries(){} // RVA: 0x7FFAF35402E0
        public void set_galleries(){} // RVA: 0x7FFAF37A4780
        public void get_tags(){} // RVA: 0x7FFAF2FB7710
        public void set_tags(){} // RVA: 0x7FFAF2FB9930
        public void get_isSearchable(){} // RVA: 0x7FFAFC3715A0
        public void set_isSearchable(){} // RVA: 0x7FFAFC3715B0
        public void get_sizeQuality(){} // RVA: 0x7FFAF9E13390
        public void set_sizeQuality(){} // RVA: 0x7FFAF9E133A0
        public void get_activityQuality(){} // RVA: 0x7FFAF37C9990
        public void set_activityQuality(){} // RVA: 0x7FFAF8D2A2A0
        public void get_engagementQuality(){} // RVA: 0x7FFAF8BED7A0
        public void set_engagementQuality(){} // RVA: 0x7FFAF8BED7B0
        public void get_contentQuality(){} // RVA: 0x7FFAF8D2A640
        public void set_contentQuality(){} // RVA: 0x7FFAF8D2A650
        public void get_roles(){} // RVA: 0x7FFAF353E870
        public void set_roles(){} // RVA: 0x7FFAF3853F70
        public void get_links(){} // RVA: 0x7FFAF35433D0
        public void set_links(){} // RVA: 0x7FFAF3546DC0
        public void get_languages(){} // RVA: 0x7FFAF2DF85F0
        public void set_languages(){} // RVA: 0x7FFAF2DF8600
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFAF2DF8660
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFAF8D4CBE0
        public void get_storeId(){} // RVA: 0x7FFAF34AE130
        public void set_storeId(){} // RVA: 0x7FFAF383E9B0
        public void UpdateData(){} // RVA: 0x7FFAFC3CAC10
        public void GetGroup(){} // RVA: 0x7FFAFC3CB680
        public void FetchAllData(){} // RVA: 0x7FFAFC3CB880
        public void RequestToJoin(){} // RVA: 0x7FFAFC3CBD20
        public void LeaveGroup(){} // RVA: 0x7FFAFC3CC0E0
        public void GetGroupInvites(){} // RVA: 0x7FFAFC3CC460
        public void InviteUser(){} // RVA: 0x7FFAFC3CC8E0
        public void BanUser(){} // RVA: 0x7FFAFC3CCD10
        public void GetMembers(){} // RVA: 0x7FFAFC3CD140
        public void GetGroupCapacity(){} // RVA: 0x7FFAFC3CD710
        public void SetRepresentation(){} // RVA: 0x7FFAFC3CD830
        public void GetGroupGalleryImages(){} // RVA: 0x7FFAFC3CDCC0
        public void GetGroupProducts(){} // RVA: 0x7FFAFC3CE7E0
        public void GetGroupAnnouncements(){} // RVA: 0x7FFAFC3CEC20
        public void SetAnnouncementSubscription(){} // RVA: 0x7FFAFC3CF1A0
        public void SetEventAnnouncementSubscription(){} // RVA: 0x7FFAFC3CF600
        public void GetUsingShortCode(){} // RVA: 0x7FFAFC3CFA60
        public void StrictSearch(){} // RVA: 0x7FFAFC3CFD80
        public void GetActiveGroupInstances(){} // RVA: 0x7FFAFC3D01F0
        public void GetRoles(){} // RVA: 0x7FFAFC3D0650
        public void GetAllGroupPermissions(){} // RVA: 0x7FFAFC3D0A70
        public void GetGroupPermissions(){} // RVA: 0x7FFAFC3D0DA0
        public void ExtractPermissions(){} // RVA: 0x7FFAFC3D1210
    }

    public class APIGroupAnnouncement
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAF2E08D50
        public void set_groupId(){} // RVA: 0x7FFAF2E08D60
        public void get_authorId(){} // RVA: 0x7FFAF2E55590
        public void set_authorId(){} // RVA: 0x7FFAF2E555A0
        public void get_title(){} // RVA: 0x7FFAF2F77C50
        public void set_title(){} // RVA: 0x7FFAF2F734F0
        public void get_text(){} // RVA: 0x7FFAF2F12D00
        public void set_text(){} // RVA: 0x7FFAF2F14450
        public void get_imageUrl(){} // RVA: 0x7FFAF2DCC010
        public void set_imageUrl(){} // RVA: 0x7FFAF2F13060
        public void get_visibility(){} // RVA: 0x7FFAF3246DE0
        public void set_visibility(){} // RVA: 0x7FFAF3604600
        public void get_createdAt(){} // RVA: 0x7FFAF34CC8C0
        public void set_createdAt(){} // RVA: 0x7FFAF8224BB0
        public void get_updatedAt(){} // RVA: 0x7FFAF34B85E0
        public void set_updatedAt(){} // RVA: 0x7FFAF8AA62E0
        public void get_roleIds(){} // RVA: 0x7FFAF34CC130
        public void set_roleIds(){} // RVA: 0x7FFAF3595030
        public void SetLastPostReadAt(){} // RVA: 0x7FFAFC3D2D00
        public void .ctor(){} // RVA: 0x7FFAFC3D3110
    }

    public class APIGroupInstance
    {
        // ── Methods ──
        public void BuildRequest(){} // RVA: 0x7FFAFC3D31B0
        public void .ctor(){} // RVA: 0x7FFAFC3D3480
    }

    public class APIGroupInvite
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAF2E08D50
        public void set_groupId(){} // RVA: 0x7FFAF2E08D60
        public void get_userId(){} // RVA: 0x7FFAF2E55590
        public void set_userId(){} // RVA: 0x7FFAF2E555A0
        public void get_state(){} // RVA: 0x7FFAF2F77C50
        public void set_state(){} // RVA: 0x7FFAF2F734F0
        public void CancelRequest(){} // RVA: 0x7FFAFC3D2970
        public void .ctor(){} // RVA: 0x7FFAFC3D2C60
    }

    public class APIGroupJoinResponse
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAF2E08D50
        public void set_groupId(){} // RVA: 0x7FFAF2E08D60
        public void get_userId(){} // RVA: 0x7FFAF2E55590
        public void set_userId(){} // RVA: 0x7FFAF2E555A0
        public void get_createdAt(){} // RVA: 0x7FFAF2F77C50
        public void set_createdAt(){} // RVA: 0x7FFAF855F010
        public void get_isOnProfile(){} // RVA: 0x7FFAF3058B10
        public void set_isOnProfile(){} // RVA: 0x7FFAF3056190
        public void get_isOnNameplate(){} // RVA: 0x7FFAF304F730
        public void set_isOnNameplate(){} // RVA: 0x7FFAF3051140
        public void get_joinedAt(){} // RVA: 0x7FFAF2DCC010
        public void set_joinedAt(){} // RVA: 0x7FFAF358F010
        public void get_updatedAt(){} // RVA: 0x7FFAF3246DE0
        public void set_updatedAt(){} // RVA: 0x7FFAF476A190
        public void get_isActive(){} // RVA: 0x7FFAF331DB40
        public void set_isActive(){} // RVA: 0x7FFAF331DB50
        public void get_requestedJoin(){} // RVA: 0x7FFAF331B8D0
        public void set_requestedJoin(){} // RVA: 0x7FFAF8C6EF40
        public void get_inviteId(){} // RVA: 0x7FFAF34B85E0
        public void set_inviteId(){} // RVA: 0x7FFAF345A5F0
        public void .ctor(){} // RVA: 0x7FFAFC3D2920
    }

    public class APIGroupList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3D3620 | overloaded x2
    }

    public class APIGroupLocations
    {
        // ── Methods ──
        public void get_fetchedAt(){} // RVA: 0x7FFAF2E08D50
        public void set_fetchedAt(){} // RVA: 0x7FFAF49BAB90
        public void get_instances(){} // RVA: 0x7FFAF2E55590
        public void set_instances(){} // RVA: 0x7FFAF2E555A0
        public void GetLocations(){} // RVA: 0x7FFAFC3D3710
        public void .ctor(){} // RVA: 0x7FFAFC3D3A50
    }

    public class APIGroupMember
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC3D3F00
        public void get_groupId(){} // RVA: 0x7FFAF2E08D50
        public void set_groupId(){} // RVA: 0x7FFAF2E08D60
        public void get_userId(){} // RVA: 0x7FFAF2E55590
        public void set_userId(){} // RVA: 0x7FFAF2E555A0
        public void get_roleIds(){} // RVA: 0x7FFAF2F77C50
        public void set_roleIds(){} // RVA: 0x7FFAF2F734F0
        public void get_mRoleIds(){} // RVA: 0x7FFAF2F12D00
        public void set_mRoleIds(){} // RVA: 0x7FFAF2F14450
        public void get_permissions(){} // RVA: 0x7FFAF2DCC010
        public void set_permissions(){} // RVA: 0x7FFAF2F13060
        public void get_memberVisibility(){} // RVA: 0x7FFAF3246DE0
        public void set_memberVisibility(){} // RVA: 0x7FFAF3604600
        public void get_membershipStatus(){} // RVA: 0x7FFAF34CC8C0
        public void set_membershipStatus(){} // RVA: 0x7FFAF345A650
        public void get_isRepresenting(){} // RVA: 0x7FFAF461CD50
        public void set_isRepresenting(){} // RVA: 0x7FFAF3620090
        public void get_mutualGroup(){} // RVA: 0x7FFAF47D3080
        public void set_mutualGroup(){} // RVA: 0x7FFAF47D3090
        public void get_name(){} // RVA: 0x7FFAF34CC130
        public void set_name(){} // RVA: 0x7FFAF3595030
        public void get_ownerId(){} // RVA: 0x7FFAF2DF8040
        public void set_ownerId(){} // RVA: 0x7FFAF2DF8050
        public void get_shortCode(){} // RVA: 0x7FFAF2DF80B0
        public void set_shortCode(){} // RVA: 0x7FFAF2DF80C0
        public void get_discriminator(){} // RVA: 0x7FFAF2DF8120
        public void set_discriminator(){} // RVA: 0x7FFAF2DF8130
        public void get_iconUrl(){} // RVA: 0x7FFAF2EE5460
        public void set_iconUrl(){} // RVA: 0x7FFAF2EE5470
        public void get_bannerUrl(){} // RVA: 0x7FFAF2EAA100
        public void set_bannerUrl(){} // RVA: 0x7FFAF2EAA110
        public void get_privacy(){} // RVA: 0x7FFAF3546D30
        public void set_privacy(){} // RVA: 0x7FFAF2E0E8A0
        public void get_visibility(){} // RVA: 0x7FFAF2E0E900
        public void set_visibility(){} // RVA: 0x7FFAF2E0E910
        public void get_isSubscribedToAnnouncements(){} // RVA: 0x7FFAF3FDE150
        public void set_isSubscribedToAnnouncements(){} // RVA: 0x7FFAF4359FF0
        public void get_isSubscribedToEventAnnouncements(){} // RVA: 0x7FFAF915C3A0
        public void set_isSubscribedToEventAnnouncements(){} // RVA: 0x7FFAFC376CD0
        public void get_memberCount(){} // RVA: 0x7FFAF4759B70
        public void set_memberCount(){} // RVA: 0x7FFAF8D2A280
        public void get_joinedAt(){} // RVA: 0x7FFAF2DF82A0
        public void set_joinedAt(){} // RVA: 0x7FFAF8E7FBB0
        public void get_bannedAt(){} // RVA: 0x7FFAF32A7DB0
        public void set_bannedAt(){} // RVA: 0x7FFAF68A18C0
        public void get_lastPostReadAt(){} // RVA: 0x7FFAF3544E10
        public void set_lastPostReadAt(){} // RVA: 0x7FFAF41B2E00
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFAF35402E0
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFAF2FB7D00
        public void get_user(){} // RVA: 0x7FFAF2FB7710
        public void set_user(){} // RVA: 0x7FFAF2FB9930
        public void get_group(){} // RVA: 0x7FFAF2FB7D10
        public void set_group(){} // RVA: 0x7FFAF2FBA8C0
        public void GetMemberships(){} // RVA: 0x7FFAFC3D3F60
        public void SetVisibility(){} // RVA: 0x7FFAFC3D4340
        public void FetchGroup(){} // RVA: 0x7FFAFC3D4800
        public void GetRepresentation(){} // RVA: 0x7FFAFC3D4B50
    }

    public class APIGroupMemberList
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAF2E08D50
        public void set_groupId(){} // RVA: 0x7FFAF2E08D60
        public void get_members(){} // RVA: 0x7FFAF2E55590
        public void set_members(){} // RVA: 0x7FFAF2E555A0
        public void .ctor(){} // RVA: 0x7FFAFC3D52E0 | overloaded x2
    }

    public class APIGroupPosts
    {
        // ── Methods ──
        public void get_total(){} // RVA: 0x7FFAF4741440
        public void set_total(){} // RVA: 0x7FFAF4741450
        public void get_posts(){} // RVA: 0x7FFAF2E55590
        public void set_posts(){} // RVA: 0x7FFAF2E555A0
        public void .ctor(){} // RVA: 0x7FFAFC3D2CB0
    }

    public class APIGroupRole
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAF2E08D50
        public void set_groupId(){} // RVA: 0x7FFAF2E08D60
        public void get_name(){} // RVA: 0x7FFAF2E55590
        public void set_name(){} // RVA: 0x7FFAF2E555A0
        public void get_description(){} // RVA: 0x7FFAF2F77C50
        public void set_description(){} // RVA: 0x7FFAF2F734F0
        public void get_isSelfAssignable(){} // RVA: 0x7FFAF3058B10
        public void set_isSelfAssignable(){} // RVA: 0x7FFAF3056190
        public void get_requiresTwoFactor(){} // RVA: 0x7FFAF304F730
        public void set_requiresTwoFactor(){} // RVA: 0x7FFAF3051140
        public void get_isManagementRole(){} // RVA: 0x7FFAF3BEC490
        public void set_isManagementRole(){} // RVA: 0x7FFAF8A49000
        public void get_requiresPurchase(){} // RVA: 0x7FFAF3FCA520
        public void set_requiresPurchase(){} // RVA: 0x7FFAF8AA60A0
        public void get_createdAt(){} // RVA: 0x7FFAF2DCC010
        public void set_createdAt(){} // RVA: 0x7FFAF358F010
        public void get_updatedAt(){} // RVA: 0x7FFAF3246DE0
        public void set_updatedAt(){} // RVA: 0x7FFAF476A190
        public void get_defaultRole(){} // RVA: 0x7FFAF331DB40
        public void set_defaultRole(){} // RVA: 0x7FFAF331DB50
        public void get_order(){} // RVA: 0x7FFAF4826560
        public void set_order(){} // RVA: 0x7FFAF4826580
        public void get_permissions(){} // RVA: 0x7FFAF34B85E0
        public void set_permissions(){} // RVA: 0x7FFAF345A5F0
        public void .ctor(){} // RVA: 0x7FFAFC3D5440 | overloaded x2
    }

    public class APIGroupRoleList
    {
        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAF2E08D50
        public void set_groupId(){} // RVA: 0x7FFAF2E08D60
        public void get_roles(){} // RVA: 0x7FFAF2E55590
        public void set_roles(){} // RVA: 0x7FFAF2E555A0
        public void .ctor(){} // RVA: 0x7FFAFC3D5750 | overloaded x2
    }

    public class APIProductGifting
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class APIProductGiftingCheck
    {
        // ── Methods ──
        public void get_Eligible(){} // RVA: 0x7FFAF2E55570
        public void set_Eligible(){} // RVA: 0x7FFAF2E55580
        public void get_Reason(){} // RVA: 0x7FFAF2E55590
        public void set_Reason(){} // RVA: 0x7FFAF2E555A0
        public void get_EligibleProducts(){} // RVA: 0x7FFAF2F77C50
        public void set_EligibleProducts(){} // RVA: 0x7FFAF2F734F0
        public void get_IneligibleProducts(){} // RVA: 0x7FFAF2F12D00
        public void set_IneligibleProducts(){} // RVA: 0x7FFAF2F14450
        public void Check(){} // RVA: 0x7FFAFC374B40
        public void .ctor(){} // RVA: 0x7FFAFC375110
    }

    public class APIPurchasedGiftBundle
    {
        // ── Methods ──
        public void get_transactionId(){} // RVA: 0x7FFAF2E08D50
        public void set_transactionId(){} // RVA: 0x7FFAF2E08D60
        public void get_store(){} // RVA: 0x7FFAF2E55590
        public void set_store(){} // RVA: 0x7FFAF2E555A0
        public void get_steamItemId(){} // RVA: 0x7FFAF2F77C50
        public void set_steamItemId(){} // RVA: 0x7FFAF2F734F0
        public void get_oculusSku(){} // RVA: 0x7FFAF2F12D00
        public void set_oculusSku(){} // RVA: 0x7FFAF2F14450
        public void get_googleProductId(){} // RVA: 0x7FFAF2DCC010
        public void set_googleProductId(){} // RVA: 0x7FFAF2F13060
        public void get_googlePlanId(){} // RVA: 0x7FFAF3246DE0
        public void set_googlePlanId(){} // RVA: 0x7FFAF3604600
        public void get_picoSku(){} // RVA: 0x7FFAF34CC8C0
        public void set_picoSku(){} // RVA: 0x7FFAF345A650
        public void get_amount(){} // RVA: 0x7FFAF4826590
        public void set_amount(){} // RVA: 0x7FFAF4826550
        public void get_description(){} // RVA: 0x7FFAF34CC130
        public void set_description(){} // RVA: 0x7FFAF3595030
        public void get_period(){} // RVA: 0x7FFAF2DF8040
        public void set_period(){} // RVA: 0x7FFAF2DF8050
        public void get_consumed(){} // RVA: 0x7FFAF41EF990
        public void set_consumed(){} // RVA: 0x7FFAF41EEC00
        public void get_status(){} // RVA: 0x7FFAF2DF8120
        public void set_status(){} // RVA: 0x7FFAF2DF8130
        public void get_created_at(){} // RVA: 0x7FFAF2EE5460
        public void set_created_at(){} // RVA: 0x7FFAF2EE5470
        public void get_updated_at(){} // RVA: 0x7FFAF2EAA100
        public void set_updated_at(){} // RVA: 0x7FFAF2EAA110
        public void get_isBulkGift(){} // RVA: 0x7FFAF3DAD610
        public void set_isBulkGift(){} // RVA: 0x7FFAF8BDFB20
        public void get_targets(){} // RVA: 0x7FFAF2E0E900
        public void set_targets(){} // RVA: 0x7FFAF2E0E910
        public void get_bulkSize(){} // RVA: 0x7FFAF475C8F0
        public void set_bulkSize(){} // RVA: 0x7FFAF8D2A3B0
        public void get_discountPercentage(){} // RVA: 0x7FFAF4759B70
        public void set_discountPercentage(){} // RVA: 0x7FFAF8D2A280
        public void get_totalConsumed(){} // RVA: 0x7FFAF61E9380
        public void set_totalConsumed(){} // RVA: 0x7FFAF8D2A290
        public void get_totalUnconsumed(){} // RVA: 0x7FFAF68A1880
        public void set_totalUnconsumed(){} // RVA: 0x7FFAF68A1890
        public void get_failures(){} // RVA: 0x7FFAF9D86570
        public void set_failures(){} // RVA: 0x7FFAFBEE9450
        public void .ctor(){} // RVA: 0x7FFAFC324060
    }

    public class APIQueue
    {
        // ── Methods ──
        public void JoinQueue(){} // RVA: 0x7FFAFC37A420
        public void SetQueue(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void LeaveQueue(){} // RVA: 0x7FFAFC37A890
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class APIResponseHandler
    {
        // ── Methods ──
        public void HandleResponse(){} // RVA: 0x7FFAFC37D9C0
        public void extractResponseErrorMessage(){} // RVA: 0x7FFAFC37DBF0
        public void RetryRequest(){} // RVA: 0x7FFAFC37DD60
        public void .cctor(){} // RVA: 0x7FFAFC37E4D0
    }

    public class APISticker
    {
        // ── Methods ──
        public void get_fileId(){} // RVA: 0x7FFAF2E08D50
        public void set_fileId(){} // RVA: 0x7FFAF2E08D60
        public void get_imageUrl(){} // RVA: 0x7FFAF2E55590
        public void set_imageUrl(){} // RVA: 0x7FFAF2E555A0
        public void get_specialEffect(){} // RVA: 0x7FFAF2F77C50
        public void set_specialEffect(){} // RVA: 0x7FFAF2F734F0
        public void get_animationStyle(){} // RVA: 0x7FFAF2F12D00
        public void set_animationStyle(){} // RVA: 0x7FFAF2F14450
        public void get_maskTag(){} // RVA: 0x7FFAF2DCC010
        public void set_maskTag(){} // RVA: 0x7FFAF2F13060
        public void get_animated(){} // RVA: 0x7FFAF3DFA670
        public void set_animated(){} // RVA: 0x7FFAF3DF8E00
        public void get_frames(){} // RVA: 0x7FFAF315FD30
        public void set_frames(){} // RVA: 0x7FFAF338F350
        public void get_framesOverTime(){} // RVA: 0x7FFAF4826570
        public void set_framesOverTime(){} // RVA: 0x7FFAF4826000
        public void get_loopStyle(){} // RVA: 0x7FFAF34B85E0
        public void set_loopStyle(){} // RVA: 0x7FFAF345A5F0
        public void get_assetBundleId(){} // RVA: 0x7FFAF34CC130
        public void set_assetBundleId(){} // RVA: 0x7FFAF3595030
        public void UploadSticker(){} // RVA: 0x7FFAFC382240 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAFC382850
    }

    public class APISubscription
    {
        // ── Methods ──
        public void get_response(){} // RVA: 0x7FFAF2E08D50
        public void set_response(){} // RVA: 0x7FFAF2E08D60
        public void .ctor(){} // RVA: 0x7FFAFC382A00
    }

    public class APITutorial
    {
        // ── Methods ──
        public void get_IsTutorialCompleted(){} // RVA: 0x7FFAF2E55570
        public void set_IsTutorialCompleted(){} // RVA: 0x7FFAF2E55580
        public void get_CompletedAnyTutorial(){} // RVA: 0x7FFAF7974D70
        public void set_CompletedAnyTutorial(){} // RVA: 0x7FFAF79747C0
        public void get_TutorialKey(){} // RVA: 0x7FFAF2E55590
        public void set_TutorialKey(){} // RVA: 0x7FFAF2E555A0
        public void LoadTutorial(){} // RVA: 0x7FFAFC385330
        public void .ctor(){} // RVA: 0x7FFAFC385640
    }

    public class APIUIColorPalette
    {
        // ── Methods ──
        public void get_ownerId(){} // RVA: 0x7FFAF2E08D50
        public void set_ownerId(){} // RVA: 0x7FFAF2E08D60
        public void get_name(){} // RVA: 0x7FFAF2E55590
        public void set_name(){} // RVA: 0x7FFAF2E555A0
        public void get_highlights(){} // RVA: 0x7FFAF2F77C50
        public void set_highlights(){} // RVA: 0x7FFAF2F734F0
        public void get_icons(){} // RVA: 0x7FFAF2F12D00
        public void set_icons(){} // RVA: 0x7FFAF2F14450
        public void get_buttons(){} // RVA: 0x7FFAF2DCC010
        public void set_buttons(){} // RVA: 0x7FFAF2F13060
        public void get_backgrounds(){} // RVA: 0x7FFAF3246DE0
        public void set_backgrounds(){} // RVA: 0x7FFAF3604600
        public void get_text(){} // RVA: 0x7FFAF34CC8C0
        public void set_text(){} // RVA: 0x7FFAF345A650
        public void get_subtext(){} // RVA: 0x7FFAF34B85E0
        public void set_subtext(){} // RVA: 0x7FFAF345A5F0
        public void Fetch(){} // RVA: 0x7FFAFC3857E0
        public void Save(){} // RVA: 0x7FFAFC385B90
        public void GetCurrent(){} // RVA: 0x7FFAFC386470
        public void SetCurrent(){} // RVA: 0x7FFAFC386750
        public void Update(){} // RVA: 0x7FFAFC386B40
        public void .ctor(){} // RVA: 0x7FFAFC386E80
        public void .cctor(){} // RVA: 0x7FFAFC386ED0
    }

    public class APIUser
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFAFC3871D0
        public void GetLifeSpan(){} // RVA: 0x7FFAF3E0ED20
        public void get_blob(){} // RVA: 0x7FFAF2E08D50
        public void set_blob(){} // RVA: 0x7FFAF2E08D60
        public void get_displayName(){} // RVA: 0x7FFAF2E55590
        public void set_displayName(){} // RVA: 0x7FFAF2E555A0
        public void get_username(){} // RVA: 0x7FFAF2F77C50
        public void set_username(){} // RVA: 0x7FFAF2F734F0
        public void get_pronouns(){} // RVA: 0x7FFAF2F12D00
        public void set_pronouns(){} // RVA: 0x7FFAF2F14450
        public void get_bio(){} // RVA: 0x7FFAF2DCC010
        public void set_bio(){} // RVA: 0x7FFAF2F13060
        public void get_bioLinks(){} // RVA: 0x7FFAF3246DE0
        public void set_bioLinks(){} // RVA: 0x7FFAF3604600
        public void get_location(){} // RVA: 0x7FFAF34CC8C0
        public void set_location(){} // RVA: 0x7FFAF345A650
        public void get_avatarId(){} // RVA: 0x7FFAF34B85E0
        public void set_avatarId(){} // RVA: 0x7FFAF345A5F0
        public void get_fallbackId(){} // RVA: 0x7FFAF34CC130
        public void set_fallbackId(){} // RVA: 0x7FFAF3595030
        public void get_hasEmail(){} // RVA: 0x7FFAF41E23D0
        public void set_hasEmail(){} // RVA: 0x7FFAF41E5610
        public void get_isBoopingEnabled(){} // RVA: 0x7FFAF66F9C40
        public void set_isBoopingEnabled(){} // RVA: 0x7FFAF66F9C50
        public void get_hasBirthday(){} // RVA: 0x7FFAF8C585F0
        public void set_hasBirthday(){} // RVA: 0x7FFAF8C58600
        public void get_isFriend(){} // RVA: 0x7FFAF8C58610
        public void set_isFriend(){} // RVA: 0x7FFAF8C58620
        public void get_friendKey(){} // RVA: 0x7FFAF2DF80B0
        public void set_friendKey(){} // RVA: 0x7FFAF2DF80C0
        public void get_friendRequestStatus(){} // RVA: 0x7FFAF2DF8120
        public void set_friendRequestStatus(){} // RVA: 0x7FFAF2DF8130
        public void get_last_login(){} // RVA: 0x7FFAF2EE5460
        public void set_last_login(){} // RVA: 0x7FFAF2EE5470
        public void get_last_activity(){} // RVA: 0x7FFAF2EAA100
        public void set_last_activity(){} // RVA: 0x7FFAF2EAA110
        public void get_date_joined(){} // RVA: 0x7FFAF3546D30
        public void set_date_joined(){} // RVA: 0x7FFAF2E0E8A0
        public void get_developerType(){} // RVA: 0x7FFAF47C2470
        public void set_developerType(){} // RVA: 0x7FFAF47C2480
        public void get_events(){} // RVA: 0x7FFAF2E0E970
        public void set_events(){} // RVA: 0x7FFAF2E0E980
        public void get_acceptedTOSVersion(){} // RVA: 0x7FFAF61E9380
        public void set_acceptedTOSVersion(){} // RVA: 0x7FFAF8D2A290
        public void get_queuedInstance(){} // RVA: 0x7FFAF32A7DB0
        public void set_queuedInstance(){} // RVA: 0x7FFAF30ED280
        public void get_queuedInstancePosition(){} // RVA: 0x7FFAF8F1FCD0
        public void set_queuedInstancePosition(){} // RVA: 0x7FFAF9F92F70
        public void get_acceptedPrivacyVersion(){} // RVA: 0x7FFAF4736A00
        public void set_acceptedPrivacyVersion(){} // RVA: 0x7FFAF4516500
        public void get_currentAvatarImageUrl(){} // RVA: 0x7FFAF35402E0
        public void set_currentAvatarImageUrl(){} // RVA: 0x7FFAF37A4780
        public void get_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFAF2FB7710
        public void set_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFAF2FB9930
        public void get_currentAvatarTags(){} // RVA: 0x7FFAF2FB7D10
        public void set_currentAvatarTags(){} // RVA: 0x7FFAF2FBA8C0
        public void get_authToken(){} // RVA: 0x7FFAF304E660
        public void set_authToken(){} // RVA: 0x7FFAF304F420
        public void get_emailVerified(){} // RVA: 0x7FFAF32A48D0
        public void set_emailVerified(){} // RVA: 0x7FFAF32A24D0
        public void get_hasPendingEmail(){} // RVA: 0x7FFAFC387230
        public void set_hasPendingEmail(){} // RVA: 0x7FFAFC387240
        public void get_obfuscatedPendingEmail(){} // RVA: 0x7FFAF353E870
        public void set_obfuscatedPendingEmail(){} // RVA: 0x7FFAF3853F70
        public void get_friendIDs(){} // RVA: 0x7FFAF35433D0
        public void set_friendIDs(){} // RVA: 0x7FFAF3546DC0
        public void get_currentAvatarAssetUrl(){} // RVA: 0x7FFAF2DF85F0
        public void set_currentAvatarAssetUrl(){} // RVA: 0x7FFAF2DF8600
        public void get_steamDetails(){} // RVA: 0x7FFAF2DF8660
        public void set_steamDetails(){} // RVA: 0x7FFAF2DF8670
        public void get_travelingToLocation(){} // RVA: 0x7FFAF34AE130
        public void set_travelingToLocation(){} // RVA: 0x7FFAF383E9B0
        public void get_obfuscatedEmail(){} // RVA: 0x7FFAF383A610
        public void set_obfuscatedEmail(){} // RVA: 0x7FFAF3845D10
        public void get_unsubscribe(){} // RVA: 0x7FFAF8D2A600
        public void set_unsubscribe(){} // RVA: 0x7FFAF8D2A610
        public void get_hasLoggedInFromClient(){} // RVA: 0x7FFAF8D2A620
        public void set_hasLoggedInFromClient(){} // RVA: 0x7FFAF8D2A630
        public void get_pastDisplayNames(){} // RVA: 0x7FFAF3843DD0
        public void set_pastDisplayNames(){} // RVA: 0x7FFAF3843D70
        public void get_homeLocation(){} // RVA: 0x7FFAF32E0040
        public void set_homeLocation(){} // RVA: 0x7FFAF383E320
        public void get_tags(){} // RVA: 0x7FFAF32DF060
        public void set_tags(){} // RVA: 0x7FFAFC387250
        public void get_status(){} // RVA: 0x7FFAF3855BB0
        public void set_status(){} // RVA: 0x7FFAF3837C10
        public void get_statusDescription(){} // RVA: 0x7FFAF3833B50
        public void set_statusDescription(){} // RVA: 0x7FFAF384F550
        public void get_badges(){} // RVA: 0x7FFAF3540180
        public void set_badges(){} // RVA: 0x7FFAF3846D90
        public void get_statusHistory(){} // RVA: 0x7FFAF35474D0
        public void set_statusHistory(){} // RVA: 0x7FFAF384C360
        public void get_state(){} // RVA: 0x7FFAF3861150
        public void set_state(){} // RVA: 0x7FFAF3845560
        public void get_allowAvatarCopying(){} // RVA: 0x7FFAF8F829E0
        public void set_allowAvatarCopying(){} // RVA: 0x7FFAF8F829F0
        public void get_hasSharedConnectionsOptOut(){} // RVA: 0x7FFAF8F82A00
        public void set_hasSharedConnectionsOptOut(){} // RVA: 0x7FFAF8F82A10
        public void get_hasDiscordFriendsOptOut(){} // RVA: 0x7FFAF8F82A60
        public void set_hasDiscordFriendsOptOut(){} // RVA: 0x7FFAF8F82A70
        public void get_userIcon(){} // RVA: 0x7FFAF3855040
        public void set_userIcon(){} // RVA: 0x7FFAF383AAB0
        public void get_profilePicOverride(){} // RVA: 0x7FFAF3862150
        public void set_profilePicOverride(){} // RVA: 0x7FFAF3844B20
        public void get_note(){} // RVA: 0x7FFAF3507F60
        public void set_note(){} // RVA: 0x7FFAF3844790
        public void get_iconUrl(){} // RVA: 0x7FFAF38562D0
        public void set_iconUrl(){} // RVA: 0x7FFAF3844E00
        public void get_thumbnailUrl(){} // RVA: 0x7FFAF3863D70
        public void set_thumbnailUrl(){} // RVA: 0x7FFAF3836540
        public void get_hideContentFilterSettings(){} // RVA: 0x7FFAF474ABD0
        public void set_hideContentFilterSettings(){} // RVA: 0x7FFAF474ABE0
        public void get_contentFilters(){} // RVA: 0x7FFAF337BA20
        public void set_contentFilters(){} // RVA: 0x7FFAF38644F0
        public void get_userLanguageCode(){} // RVA: 0x7FFAF3864D60
        public void set_userLanguageCode(){} // RVA: 0x7FFAF3835A20
        public void get_ageVerified(){} // RVA: 0x7FFAF8F855B0
        public void set_ageVerified(){} // RVA: 0x7FFAFC3872C0
        public void get_isAdult(){} // RVA: 0x7FFAF413E9D0
        public void set_isAdult(){} // RVA: 0x7FFAFC3872D0
        public void get_ageVerificationStatus(){} // RVA: 0x7FFAF383D540
        public void set_ageVerificationStatus(){} // RVA: 0x7FFAF384D6A0
        public void get_discordId(){} // RVA: 0x7FFAF384E9A0
        public void set_discordId(){} // RVA: 0x7FFAF384F490
        public void get_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x7FFAF8F5DDD0
        public void set_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x7FFAFC3872E0
        public void get_completedTutorials(){} // RVA: 0x7FFAF384F7C0
        public void set_completedTutorials(){} // RVA: 0x7FFAF384BA80
        public void get_last_platform(){} // RVA: 0x7FFAF3838BD0
        public void set_last_platform(){} // RVA: 0x7FFAFC3872F0
        public void get_platform(){} // RVA: 0x7FFAF38415D0
        public void set_platform(){} // RVA: 0x7FFAF3843180
        public void get_last_mobile(){} // RVA: 0x7FFAF3840650
        public void set_last_mobile(){} // RVA: 0x7FFAF384F060
        public void get_twoFactorAuthEnabled(){} // RVA: 0x7FFAF8D0DEA0
        public void set_twoFactorAuthEnabled(){} // RVA: 0x7FFAF8D0DEB0
        public void get_twoFactorAuthMethods(){} // RVA: 0x7FFAF3840BA0
        public void set_twoFactorAuthMethods(){} // RVA: 0x7FFAF3844430
        public void get_LanguageTagsDictionary(){} // RVA: 0x7FFAFC387470
        public void get_languagesDisplayNames(){} // RVA: 0x7FFAF3844B90
        public void set_languagesDisplayNames(){} // RVA: 0x7FFAF384C4E0
        public void set_LanguagesShortNames(){} // RVA: 0x7FFAF3838A80
        public void get_LanguagesShortNames(){} // RVA: 0x7FFAF3833050
        public void SetUserLanguages(){} // RVA: 0x7FFAFC387900
        public void get_ShouldSeeInstanceByStatus(){} // RVA: 0x7FFAFC387CC0
        public void get_IsOnMobile(){} // RVA: 0x7FFAFC387D00
        public void get_profilePicImageUrl(){} // RVA: 0x7FFAFC387D20
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x7FFAFC387D40
        public void FetchBalance(){} // RVA: 0x7FFAFC387D60
        public void get_IsAccountVerified(){} // RVA: 0x7FFAF2E72850
        public void get_hasNoPowers(){} // RVA: 0x7FFAFC3880F0
        public void get_hasScriptingAccess(){} // RVA: 0x7FFAFC388140
        public void get_hasModerationPowers(){} // RVA: 0x7FFAFC388240
        public void get_hasVIPAccess(){} // RVA: 0x7FFAFC388300
        public void get_hasSuperPowers(){} // RVA: 0x7FFAFC388350
        public void get_canPublishWorldsAndAvatars(){} // RVA: 0x7FFAFC3883A0
        public void get_canPublishAllContent(){} // RVA: 0x7FFAFC3885C0
        public void get_canPublishAvatars(){} // RVA: 0x7FFAFC3886F0
        public void get_canPublishWorlds(){} // RVA: 0x7FFAFC388810
        public void get_canPublishProps(){} // RVA: 0x7FFAFC388930
        public void get_isUntrusted(){} // RVA: 0x7FFAFC388A50
        public void get_isNewUser(){} // RVA: 0x7FFAFC388AB0
        public void get_isEarlyAdopter(){} // RVA: 0x7FFAFC388B70
        public void get_isSupporter(){} // RVA: 0x7FFAFC388C30
        public void get_isCreator(){} // RVA: 0x7FFAFC388CF0
        public void get_hasBasicTrustLevel(){} // RVA: 0x7FFAFC388DB0
        public void get_hasKnownTrustLevel(){} // RVA: 0x7FFAFC388E80
        public void get_hasTrustedTrustLevel(){} // RVA: 0x7FFAFC388F50
        public void get_hasVeteranTrustLevel(){} // RVA: 0x7FFAFC389020
        public void get_hasLegendTrustLevel(){} // RVA: 0x7FFAFC389160
        public void get_hasNegativeTrustLevel(){} // RVA: 0x7FFAFC389230
        public void get_hasVeryNegativeTrustLevel(){} // RVA: 0x7FFAFC389300
        public void get_hasFeedbackAccess(){} // RVA: 0x7FFAFC3893C0
        public void get_showSocialRank(){} // RVA: 0x7FFAFC389480
        public void get_showModTag(){} // RVA: 0x7FFAFC389520
        public void get_canSetStatusOffline(){} // RVA: 0x7FFAFC3895C0
        public void get_statusIsSetToOffline(){} // RVA: 0x7FFAFC389620
        public void get_statusIsSetToJoinMe(){} // RVA: 0x7FFAFC389750
        public void get_statusIsSetToAskMe(){} // RVA: 0x7FFAFC3897F0
        public void get_statusIsSetToDoNotDisturb(){} // RVA: 0x7FFAFC389920
        public void get_statusDefaultDescriptionDisplayString(){} // RVA: 0x7FFAFC389A50
        public void truncatedBio(){} // RVA: 0x7FFAFC389BE0
        public void truncatedStatusDescription(){} // RVA: 0x7FFAFC389C50
        public void get_statusDescriptionDisplayString(){} // RVA: 0x7FFAFC389CC0
        public void get_statusValue(){} // RVA: 0x7FFAFC389D80
        public void get_CurrentLocation(){} // RVA: 0x7FFAFC389DF0
        public void get_canSeeAllUsersStatus(){} // RVA: 0x7FFAFC38A150
        public void MergeFieldsInto(){} // RVA: 0x7FFAFC38A1B0
        public void get_IsLoggedIn(){} // RVA: 0x7FFAFC38AA30
        public void get_IsSelf(){} // RVA: 0x7FFAFC38AAC0
        public void get_CurrentUser(){} // RVA: 0x7FFAFC38AC10
        public void set_CurrentUser(){} // RVA: 0x7FFAFC38AC70
        public void .ctor(){} // RVA: 0x7FFAFC38B010 | overloaded x2
        public void ReadField(){} // RVA: 0x7FFAFC38BEA0
        public void WriteField(){} // RVA: 0x7FFAFC38BF50
        public void InitialFetchCurrentUser(){} // RVA: 0x7FFAFC38C0E0
        public void Register(){} // RVA: 0x7FFAFC38C500
        public void UpdateAccountInfo(){} // RVA: 0x7FFAFC38CF30
        public void Login(){} // RVA: 0x7FFAFC38DA00
        public void VerifyTwoFactorAuthCode(){} // RVA: 0x7FFAFC38DEF0
        public void VerifyStepUpAuthCode(){} // RVA: 0x7FFAFC38E4E0
        public void ThirdPartyLogin(){} // RVA: 0x7FFAFC38F060
        public void DiscordLogin(){} // RVA: 0x7FFAFC38F470
        public void DiscordFinalizeLogin(){} // RVA: 0x7FFAFC38FA40
        public void DiscordLinkStatus(){} // RVA: 0x7FFAFC390530
        public void DiscordUnlink(){} // RVA: 0x7FFAFC390A20
        public void GoogleLogin(){} // RVA: 0x7FFAFC390D60
        public void GoogleFinalizeLogin(){} // RVA: 0x7FFAFC391460
        public void GoogleLinkStatus(){} // RVA: 0x7FFAFC391E10
        public void GoogleLink(){} // RVA: 0x7FFAFC392410
        public void GoogleUnlink(){} // RVA: 0x7FFAFC392A50
        public void DiscordAccess(){} // RVA: 0x7FFAFC392D70
        public void RedeemPromo(){} // RVA: 0x7FFAFC3930B0
        public void Logout(){} // RVA: 0x7FFAFC3934A0
        public void FetchPublishWorldsInformation(){} // RVA: 0x7FFAFC3935F0
        public void FetchUsers(){} // RVA: 0x7FFAFC394310 | overloaded x2
        public void FetchUser(){} // RVA: 0x7FFAFC393FA0
        public void FetchUsersSearchResults(){} // RVA: 0x7FFAFC3946F0
        public void FetchFriends(){} // RVA: 0x7FFAFC394B00
        public void AttemptVerification(){} // RVA: 0x7FFAFC395570
        public void TagsToDeveloperType(){} // RVA: 0x7FFAFC395630
        public void SetIsBoopingEnabled(){} // RVA: 0x7FFAFC3956A0
        public void AddLanguage(){} // RVA: 0x7FFAFC395B00
        public void RemoveLanguage(){} // RVA: 0x7FFAFC3960D0
        public void AddLink(){} // RVA: 0x7FFAFC396660
        public void ModifyLink(){} // RVA: 0x7FFAFC396BA0
        public void UpdateBio(){} // RVA: 0x7FFAFC397040
        public void UpdateContentFilters(){} // RVA: 0x7FFAFC397630
        public void UpdateUserLanguageCode(){} // RVA: 0x7FFAFC397A50
        public void AddNewStatusToHistory(){} // RVA: 0x7FFAFC398030
        public void StatusValueToString(){} // RVA: 0x7FFAFC3981F0
        public void StringToStatusValue(){} // RVA: 0x7FFAFC398350
        public void UnfriendUser(){} // RVA: 0x7FFAFC3985D0
        public void LocalAddFriend(){} // RVA: 0x7FFAFC3989E0
        public void IsFriendsWith(){} // RVA: 0x7FFAFC398C30
        public void get_HasRequestedToBeFriend(){} // RVA: 0x7FFAFC398E60
        public void set_HasRequestedToBeFriend(){} // RVA: 0x7FFAFC398EE0
        public void get_HasFriendRequestPending(){} // RVA: 0x7FFAFC398F80
        public void set_HasFriendRequestPending(){} // RVA: 0x7FFAFC399000
        public void SetAvatarPropertiesFromModel(){} // RVA: 0x7FFAFC3990A0
        public void SetAvatarFallbackPropertiesFromModel(){} // RVA: 0x7FFAFC399300
        public void Exists(){} // RVA: 0x7FFAFC3993F0
        public void HasTag(){} // RVA: 0x7FFAFC399430
        public void AddTag(){} // RVA: 0x7FFAFC3994A0
        public void RemoveTag(){} // RVA: 0x7FFAFC399540
        public void Equals(){} // RVA: 0x7FFAFC399690
        public void UpdateNote(){} // RVA: 0x7FFAFC399740
        public void SetUserInterests(){} // RVA: 0x7FFAFC399DD0
        public void GetUserInterests(){} // RVA: 0x7FFAFC39A0A0
        public void CheckIfPersistenceDataExistsForWorld(){} // RVA: 0x7FFAFC39A3B0
        public void ResetPersistenceDataForWorld(){} // RVA: 0x7FFAFC39A760
        public void ResetAllPersistenceDataForWorlds(){} // RVA: 0x7FFAFC39AB00
        public void UpdateBadge(){} // RVA: 0x7FFAFC39AE40
        public void ToString(){} // RVA: 0x7FFAFC39B6A0
        public void .cctor(){} // RVA: 0x7FFAFC39B9E0
    }

    public class AnalyticsInterface
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAFC3E44A0
        public void SetBuildVersion(){} // RVA: 0x7FFAFC3E45F0
        public void SetLogger(){} // RVA: 0x7FFAFC3E46A0
        public void Send(){} // RVA: 0x7FFAFC3E4790
        public void SetUserId(){} // RVA: 0x7FFAFC3E4860
        public void SetSessionId(){} // RVA: 0x7FFAFC3E4910
        public void GetSessionId(){} // RVA: 0x7FFAFC3E49D0
        public void SetUserProperties(){} // RVA: 0x7FFAFC3E4A70
        public void ClearCachedData(){} // RVA: 0x7FFAFC3E4B30
        public void OnApplicationQuit(){} // RVA: 0x7FFAFC3E4C70
        public void HasPendingEvents(){} // RVA: 0x7FFAFC3E4D40
        public void OnApplicationFocused(){} // RVA: 0x7FFAFC3E4E10
        public void OnApplicationPaused(){} // RVA: 0x7FFAFC3E4EB0
        public void CheckInstance(){} // RVA: 0x7FFAFC3E4F70
    }

    public class AnalyticsSDK
    {
        // ── Methods ──
        public void GetProjectTypeString(){} // RVA: 0x7FFAFC3E5050
        public void Initialize(){} // RVA: 0x7FFAFC3E5100
        public void LoggedInUserChanged(){} // RVA: 0x7FFAFC3E5260 | overloaded x2
        public void AddOtherProperties(){} // RVA: 0x7FFAFC3E54B0
        public void AvatarUploadFailed(){} // RVA: 0x7FFAFC3E5650
        public void WorldUploadFailed(){} // RVA: 0x7FFAFC3E57C0
        public void PropUploadFailed(){} // RVA: 0x7FFAFC3E5930
        public void ExampleCentralOpened(){} // RVA: 0x7FFAFC3E5AA0
        public void ExampleDownloaded(){} // RVA: 0x7FFAFC3E5C40
        public void ExamplePreviewed(){} // RVA: 0x7FFAFC3E5E80
        public void CheckInit(){} // RVA: 0x7FFAFC3E61F0
        public void BuildAndTestLaunched(){} // RVA: 0x7FFAFC3E6320
        public void ProjectPublished(){} // RVA: 0x7FFAFC3E65B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAFC3E69F0
    }

    public class ApiAccountUpgrade
    {
        // ── Methods ──
        public void get_isUpgrading(){} // RVA: 0x7FFAF2E55570
        public void set_isUpgrading(){} // RVA: 0x7FFAF2E55580
        public void get_subscribedToMarketingEmails(){} // RVA: 0x7FFAF7974D70
        public void set_subscribedToMarketingEmails(){} // RVA: 0x7FFAF79747C0
        public void get_hasEmail(){} // RVA: 0x7FFAF85A9770
        public void set_hasEmail(){} // RVA: 0x7FFAF85A9780
        public void get_emailVerified(){} // RVA: 0x7FFAF9579640
        public void set_emailVerified(){} // RVA: 0x7FFAF9579650
        public void .ctor(){} // RVA: 0x7FFAFC307EF0
        public void GetUpgradeStatus(){} // RVA: 0x7FFAFC307FB0
        public void UpgradeWithEmail(){} // RVA: 0x7FFAFC3082D0
        public void ParseErrorCode(){} // RVA: 0x7FFAFC308810
    }

    public class ApiAdminAssetBundle
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF2E08D50
        public void set_name(){} // RVA: 0x7FFAF2E08D60
        public void get_description(){} // RVA: 0x7FFAF2E55590
        public void set_description(){} // RVA: 0x7FFAF2E555A0
        public void get_imageUrl(){} // RVA: 0x7FFAF2F77C50
        public void set_imageUrl(){} // RVA: 0x7FFAF2F734F0
        public void get_tags(){} // RVA: 0x7FFAF2F12D00
        public void set_tags(){} // RVA: 0x7FFAF2F14450
        public void get_assetVersion(){} // RVA: 0x7FFAF36690C0
        public void set_assetVersion(){} // RVA: 0x7FFAF3669E60
        public void get_unityPackages(){} // RVA: 0x7FFAF3246DE0
        public void set_unityPackages(){} // RVA: 0x7FFAF3604600
        public void GetPlatformString(){} // RVA: 0x7FFAFC308EA0 | overloaded x2
        public void GetBundleLink(){} // RVA: 0x7FFAFC309030
        public void CreateAdminAssetBundle(){} // RVA: 0x7FFAFC3092F0
        public void AddPackageToBundle(){} // RVA: 0x7FFAFC309C30
        public void GetAdminAssetBundle(){} // RVA: 0x7FFAFC30A430
        public void GetAllAdminAssetBundles(){} // RVA: 0x7FFAFC30A760
        public void RequestDeleteBundle(){} // RVA: 0x7FFAFC30AF20
        public void SendPropertyUpdate(){} // RVA: 0x7FFAFC30B230
        public void .ctor(){} // RVA: 0x7FFAFC30BA40
    }

    public class ApiAdminAssetBundleFile
    {
        // ── Methods ──
        public void get_assetUrl(){} // RVA: 0x7FFAF2E08D50
        public void set_assetUrl(){} // RVA: 0x7FFAF2E08D60
        public void get_unityVersion(){} // RVA: 0x7FFAF2E55590
        public void set_unityVersion(){} // RVA: 0x7FFAF2E555A0
        public void get_platform(){} // RVA: 0x7FFAF2F77C50
        public void set_platform(){} // RVA: 0x7FFAF2F734F0
        public void get_assetVersion(){} // RVA: 0x7FFAF3A74570
        public void set_assetVersion(){} // RVA: 0x7FFAF3A74560
        public void GetCacheId(){} // RVA: 0x7FFAFC30BE20
        public void .ctor(){} // RVA: 0x7FFAFC30BFD0
    }

    public class ApiAuthContinue
    {
        // ── Methods ──
        public void get_continueToken(){} // RVA: 0x7FFAF2E08D50
        public void set_continueToken(){} // RVA: 0x7FFAF2E08D60
        public void get_requestedFields(){} // RVA: 0x7FFAF2E55590
        public void set_requestedFields(){} // RVA: 0x7FFAF2E555A0
        public void get_reservedName(){} // RVA: 0x7FFAF2F77C50
        public void set_reservedName(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAFC30C020
    }

    public class ApiAvatar
    {
        // ── Methods ──
        public void get_impostorUrl(){} // RVA: 0x7FFAF2E0E900
        public void set_impostorUrl(){} // RVA: 0x7FFAF2E0E910
        public void get_variant(){} // RVA: 0x7FFAF475C8F0
        public void set_variant(){} // RVA: 0x7FFAF8D2A3B0
        public void get_impostorUnityVersion(){} // RVA: 0x7FFAF2DF82A0
        public void set_impostorUnityVersion(){} // RVA: 0x7FFAF2DF82B0
        public void get_unityPackages(){} // RVA: 0x7FFAF32A7DB0
        public void set_unityPackages(){} // RVA: 0x7FFAF30ED280
        public void get_created_at(){} // RVA: 0x7FFAF3544E10
        public void set_created_at(){} // RVA: 0x7FFAF41B2E00
        public void get_updated_at(){} // RVA: 0x7FFAF35402E0
        public void set_updated_at(){} // RVA: 0x7FFAF2FB7D00
        public void get_attribution(){} // RVA: 0x7FFAF2FB7710
        public void set_attribution(){} // RVA: 0x7FFAF2FB9930
        public void get_offlineAnalysisScanStatus(){} // RVA: 0x7FFAF3E7BAD0
        public void set_offlineAnalysisScanStatus(){} // RVA: 0x7FFAF3E87860
        public void get_performanceRating(){} // RVA: 0x7FFAF304E660
        public void set_performanceRating(){} // RVA: 0x7FFAF304F420
        public void get_styles(){} // RVA: 0x7FFAF353EE80
        public void set_styles(){} // RVA: 0x7FFAF37C82E0
        public void get_productId(){} // RVA: 0x7FFAF353E870
        public void set_productId(){} // RVA: 0x7FFAF3853F70
        public void get_publishedListings(){} // RVA: 0x7FFAF35433D0
        public void set_publishedListings(){} // RVA: 0x7FFAF3546DC0
        public void get_lowestPrice(){} // RVA: 0x7FFAF2DF85F0
        public void set_lowestPrice(){} // RVA: 0x7FFAF8E57620
        public void get_highestPrice(){} // RVA: 0x7FFAF2DF8660
        public void set_highestPrice(){} // RVA: 0x7FFAF8D4CBE0
        public void get_acknowledgements(){} // RVA: 0x7FFAF34AE130
        public void set_acknowledgements(){} // RVA: 0x7FFAF383E9B0
        public void get_LoadError(){} // RVA: 0x7FFAF383A610
        public void set_LoadError(){} // RVA: 0x7FFAF3845D10
        public void .ctor(){} // RVA: 0x7FFAFC30C0C0
        public void Get(){} // RVA: 0x7FFAFC30C1E0
        public void AssignToThisUser(){} // RVA: 0x7FFAFC30C380
        public void AssignToThisUserAsFallback(){} // RVA: 0x7FFAFC30C800
        public void GetPerformanceRatingForPlatform(){} // RVA: 0x7FFAFC30CC80
        public void GetAssetUrl(){} // RVA: 0x7FFAFC30CD00
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFAFC30CEA0 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x7FFAFC30CFE0
        public void WriteField(){} // RVA: 0x7FFAFC30DB30
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFAFC30DB60
    }

    public class ApiAvatarLook
    {
        // ── Methods ──
        public void get_avatarId(){} // RVA: 0x7FFAF2E08D50
        public void set_avatarId(){} // RVA: 0x7FFAF2E08D60
        public void get_attachments(){} // RVA: 0x7FFAF2E55590
        public void set_attachments(){} // RVA: 0x7FFAF2E555A0
        public void GetLook(){} // RVA: 0x7FFAFC30E420
        public void UpdateThumbnail(){} // RVA: 0x7FFAFC30E5C0
        public void UpdateLook(){} // RVA: 0x7FFAFC30E710
        public void CreateLook(){} // RVA: 0x7FFAFC30E860
        public void WearLook(){} // RVA: 0x7FFAFC30EA00
        public void UploadThumbnail(){} // RVA: 0x7FFAFC30ED50
        public void .ctor(){} // RVA: 0x7FFAFC30EEF0
    }

    public class ApiAvatarModeration
    {
        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7FFAF4741440
        public void set_moderationType(){} // RVA: 0x7FFAF4741450
        public void get_targetAvatarId(){} // RVA: 0x7FFAF2E55590
        public void set_targetAvatarId(){} // RVA: 0x7FFAF2E555A0
        public void .ctor(){} // RVA: 0x7FFAFC312950
        public void ShouldCache(){} // RVA: 0x7FFAF2D8D320
        public void ReadField(){} // RVA: 0x7FFAFC312A10
        public void WriteField(){} // RVA: 0x7FFAFC312D90
        public void SendModeration(){} // RVA: 0x7FFAFC312F70
        public void DeleteModeration(){} // RVA: 0x7FFAFC3131B0
        public void FetchAllMine(){} // RVA: 0x7FFAFC3136D0
        public void FetchList(){} // RVA: 0x7FFAFC313730
        public void ModerationTypeToAPIString(){} // RVA: 0x7FFAFC313A20
    }

    public class ApiAvatarPart
    {
        // ── Methods ──
        public void get__created_at(){} // RVA: 0x7FFAF3546D30
        public void set__created_at(){} // RVA: 0x7FFAFC313DD0
        public void get__updated_at(){} // RVA: 0x7FFAF2E0E900
        public void set__updated_at(){} // RVA: 0x7FFAFC313DE0
        public void get_unityPackages(){} // RVA: 0x7FFAF2E0E970
        public void set_unityPackages(){} // RVA: 0x7FFAF2E0E980
        public void get_BundleSignature(){} // RVA: 0x7FFAF2DF82A0
        public void set_BundleSignature(){} // RVA: 0x7FFAF2DF82B0
        public void .ctor(){} // RVA: 0x7FFAFC313DF0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFAFC313F50 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x7FFAFC314030
        public void WriteField(){} // RVA: 0x7FFAFC3146F0
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFAFC3147B0
        public void GetAccessory(){} // RVA: 0x7FFAFC3149B0
        public void FetchList(){} // RVA: 0x7FFAFC314B50
    }

    public class ApiAvatarPartItemMetadata
    {
        // ── Methods ──
        public void get_avatarPartId(){} // RVA: 0x7FFAF2E08D50
        public void set_avatarPartId(){} // RVA: 0x7FFAF2E08D60
        public void .ctor(){} // RVA: 0x7FFAFC315640
    }

    public class ApiAvatarStyle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC315690
        public void get_styleName(){} // RVA: 0x7FFAF2E08D50
        public void set_styleName(){} // RVA: 0x7FFAF2E08D60
        public void get_lastModifiedById(){} // RVA: 0x7FFAF2E55590
        public void set_lastModifiedById(){} // RVA: 0x7FFAF2E555A0
        public void get_lastModifiedByDisplayName(){} // RVA: 0x7FFAF2F77C50
        public void set_lastModifiedByDisplayName(){} // RVA: 0x7FFAF2F734F0
        public void get_created_at(){} // RVA: 0x7FFAF2F12D00
        public void set_created_at(){} // RVA: 0x7FFAF49BABA0
        public void get_updated_at(){} // RVA: 0x7FFAF2DCC010
        public void set_updated_at(){} // RVA: 0x7FFAF358F010
    }

    public class ApiBadge
    {
        // ── Methods ──
        public void get_badgeId(){} // RVA: 0x7FFAF2E08D50
        public void set_badgeId(){} // RVA: 0x7FFAF2E08D60
        public void get_showcased(){} // RVA: 0x7FFAF2E09320
        public void set_showcased(){} // RVA: 0x7FFAF2E09330
        public void get_badgeName(){} // RVA: 0x7FFAF2F77C50
        public void set_badgeName(){} // RVA: 0x7FFAF2F734F0
        public void get_badgeDescription(){} // RVA: 0x7FFAF2F12D00
        public void set_badgeDescription(){} // RVA: 0x7FFAF2F14450
        public void get_badgeImageUrl(){} // RVA: 0x7FFAF2DCC010
        public void set_badgeImageUrl(){} // RVA: 0x7FFAF2F13060
        public void get_hidden(){} // RVA: 0x7FFAF3DFA670
        public void set_hidden(){} // RVA: 0x7FFAF3DF8E00
        public void get_assignedAt(){} // RVA: 0x7FFAF34CC8C0
        public void set_assignedAt(){} // RVA: 0x7FFAF8224BB0
        public void get_updatedAt(){} // RVA: 0x7FFAF34B85E0
        public void set_updatedAt(){} // RVA: 0x7FFAF8AA62E0
        public void get_assignedBy(){} // RVA: 0x7FFAF34CC130
        public void set_assignedBy(){} // RVA: 0x7FFAF3595030
        public void get_isQuantifiable(){} // RVA: 0x7FFAF41E23D0
        public void set_isQuantifiable(){} // RVA: 0x7FFAF41E5610
        public void get_quantity(){} // RVA: 0x7FFAF68A1350
        public void set_quantity(){} // RVA: 0x7FFAF68A1360
        public void .ctor(){} // RVA: 0x7FFAFC315750
    }

    public class ApiBindingCommandReference
    {
        // ── Methods ──
        public void get_command(){} // RVA: 0x7FFAF2E08D50
        public void set_command(){} // RVA: 0x7FFAF2E08D60
        public void get_parameters(){} // RVA: 0x7FFAF2E55590
        public void set_parameters(){} // RVA: 0x7FFAF2E555A0
        public void get_name(){} // RVA: 0x7FFAF2F77C50
        public void set_name(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAFC3157A0
        public void ToString(){} // RVA: 0x7FFAFC315840
    }

    public class ApiByteContainer
    {
        // ── Methods ──
        public void get_ResponseBytes(){} // RVA: 0x7FFAFC37CCD0
        public void Validate(){} // RVA: 0x7FFAFC37CD40
        public void .ctor(){} // RVA: 0x7FFAFC37C6A0
    }

    public class ApiCache
    {
        // ── Methods ──
        public void DefaultTimeProvider(){} // RVA: 0x7FFAFC315920
        public void get_Count(){} // RVA: 0x7FFAFC3159D0
        public void get_NextExpiryTTL(){} // RVA: 0x7FFAFC315BA0
        public void Fetch(){} // RVA: 0x7FFAF2ABE230
        public void Save(){} // RVA: 0x7FFAFC315E90
        public void Invalidate(){} // RVA: 0x7FFAFC316300
        public void CleanupTask(){} // RVA: 0x7FFAFC3165B0
        public void Cleanup(){} // RVA: 0x7FFAFC3165F0
        public void InvalidateFileIfVersionUnknown(){} // RVA: 0x7FFAFC316AF0
        public void Clear(){} // RVA: 0x7FFAFC316CA0
        public void .cctor(){} // RVA: 0x7FFAFC316F20
    }

    public class ApiCacheObject
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFAF2ABDBE0
        public void GetLifeSpan(){} // RVA: 0x7FFAF2AD1890
        public void Clone(){} // RVA: 0x7FFAF2ABCD60
        public void set_ExpiryTime(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ApiCalendarEntriesContainer
    {
        // ── Methods ──
        public void get_hasNext(){} // RVA: 0x7FFAF2E55570
        public void set_hasNext(){} // RVA: 0x7FFAF2E55580
        public void get_results(){} // RVA: 0x7FFAF2E55590
        public void set_results(){} // RVA: 0x7FFAF2E555A0
        public void get_totalCount(){} // RVA: 0x7FFAF4593800
        public void set_totalCount(){} // RVA: 0x7FFAF4596D80
        public void get_nextCursor(){} // RVA: 0x7FFAF2F12D00
        public void set_nextCursor(){} // RVA: 0x7FFAF2F14450
        public void .ctor(){} // RVA: 0x7FFAFC3C6A80
    }

    public class ApiCalendarResults
    {
        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFAF2E08D50
        public void set_results(){} // RVA: 0x7FFAF2E08D60
        public void get_totalCount(){} // RVA: 0x7FFAF3B95CF0
        public void set_totalCount(){} // RVA: 0x7FFAF2F25080
        public void .ctor(){} // RVA: 0x7FFAFC381D30
    }

    public class ApiCampaign
    {
        // ── Methods ──
        public void get_participantCount(){} // RVA: 0x7FFAF4741440
        public void set_participantCount(){} // RVA: 0x7FFAF4741450
        public void get_friendsContributing(){} // RVA: 0x7FFAF2E55590
        public void set_friendsContributing(){} // RVA: 0x7FFAF2E555A0
        public void get_endsAt(){} // RVA: 0x7FFAF2F77C50
        public void set_endsAt(){} // RVA: 0x7FFAF855F010
        public void get_raisedAmountUsd(){} // RVA: 0x7FFAF3A74570
        public void set_raisedAmountUsd(){} // RVA: 0x7FFAF3A74560
        public void get_userGiftCount(){} // RVA: 0x7FFAF470A600
        public void set_userGiftCount(){} // RVA: 0x7FFAF470A650
        public void get_giftGoalUsd(){} // RVA: 0x7FFAF36690C0
        public void set_giftGoalUsd(){} // RVA: 0x7FFAF3669E60
        public void get_goalSuccess(){} // RVA: 0x7FFAF2DF5520
        public void set_goalSuccess(){} // RVA: 0x7FFAF2DF5530
        public void get_rewards(){} // RVA: 0x7FFAF3246DE0
        public void set_rewards(){} // RVA: 0x7FFAF3604600
        public void GetCampaignAsync(){} // RVA: 0x7FFAFC3177C0
        public void .ctor(){} // RVA: 0x7FFAFC317960
    }

    public class ApiCampaignReward
    {
        // ── Methods ──
        public void get_title(){} // RVA: 0x7FFAF2E08D50
        public void set_title(){} // RVA: 0x7FFAF2E08D60
        public void get_description(){} // RVA: 0x7FFAF2E55590
        public void set_description(){} // RVA: 0x7FFAF2E555A0
        public void get_imageUrl(){} // RVA: 0x7FFAF2F77C50
        public void set_imageUrl(){} // RVA: 0x7FFAF2F734F0
        public void get_unlocked(){} // RVA: 0x7FFAF3058B10
        public void set_unlocked(){} // RVA: 0x7FFAF3056190
        public void get_progress(){} // RVA: 0x7FFAF2DCC010
        public void set_progress(){} // RVA: 0x7FFAF2F13060
        public void .ctor(){} // RVA: 0x7FFAFC3181C0
    }

    public class ApiCampaignRewardProgress
    {
        // ── Methods ──
        public void get_current(){} // RVA: 0x7FFAF4741440
        public void set_current(){} // RVA: 0x7FFAF4741450
        public void get_max(){} // RVA: 0x7FFAF4741460
        public void set_max(){} // RVA: 0x7FFAF4741470
        public void .ctor(){} // RVA: 0x7FFAFC318210
    }

    public class ApiCertificateVerifier
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAFC318260
        public void .ctor(){} // RVA: 0x7FFAF9FAAFC0
        public void Initialize(){} // RVA: 0x7FFAFC3182C0
        public void TestPublicKey(){} // RVA: 0x7FFAFC3183C0
        public void IsValid(){} // RVA: 0x7FFAFC318650
        public void ValidateCertificate(){} // RVA: 0x7FFAFC318890
        public void .cctor(){} // RVA: 0x7FFAFC318A50
    }

    public class ApiContainer
    {
        // ── Methods ──
        public void get_Cookies(){} // RVA: 0x7FFAF2DA8380
        public void set_Cookies(){} // RVA: 0x7FFAF2D8EE30
        public void get_Populated(){} // RVA: 0x7FFAF2DA84E0
        public void set_Populated(){} // RVA: 0x7FFAF2DA84F0
        public void get_PassedValidation(){} // RVA: 0x7FFAF31693D0
        public void set_PassedValidation(){} // RVA: 0x7FFAF39F3D70
        public void get_Code(){} // RVA: 0x7FFAF442C3B0
        public void set_Code(){} // RVA: 0x7FFAF4439FD0
        public void get_Text(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Text(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Data(){} // RVA: 0x7FFAF2DBB130
        public void set_Data(){} // RVA: 0x7FFAF2D8EE90
        public void get_DataTimestamp(){} // RVA: 0x7FFAF2F16280
        public void set_DataTimestamp(){} // RVA: 0x7FFAF2FADE90
        public void get_CreatedAt(){} // RVA: 0x7FFAF2F476A0
        public void set_CreatedAt(){} // RVA: 0x7FFAF2F4B830
        public void get_Error(){} // RVA: 0x7FFAFC37CE90
        public void set_Error(){} // RVA: 0x7FFAFC37CEC0
        public void get_Model(){} // RVA: 0x7FFAF2E08730
        public void set_Model(){} // RVA: 0x7FFAF2E08740
        public void .ctor(){} // RVA: 0x7FFAFC37D220
        public void setFromContainer(){} // RVA: 0x7FFAFC37D2F0
        public void Validate(){} // RVA: 0x7FFAFC37D500
        public void GetErrorMessage(){} // RVA: 0x7FFAFC37D550
        public void OnComplete(){} // RVA: 0x7FFAFC37D700
    }

    public class ApiContentModel`1
    {
        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7FFAF2ABC960
        public void ShouldCache(){} // RVA: 0x7FFAF2ABDBE0
        public void GetLifeSpan(){} // RVA: 0x7FFAF2AD1890
        public void get_name(){} // RVA: 0x7FFAF2ABCD60
        public void set_name(){} // RVA: 0x7FFAF2AD4B10
        public void get_imageUrl(){} // RVA: 0x7FFAF2ABCD60
        public void set_imageUrl(){} // RVA: 0x7FFAF2AD4B10
        public void get_authorName(){} // RVA: 0x7FFAF2ABCD60
        public void set_authorName(){} // RVA: 0x7FFAF2AD4B10
        public void get_authorId(){} // RVA: 0x7FFAF2ABCD60
        public void set_authorId(){} // RVA: 0x7FFAF2AD4B10
        public void get_assetUrl(){} // RVA: 0x7FFAF2ABCD60
        public void set_assetUrl(){} // RVA: 0x7FFAF2AD4B10
        public void get_description(){} // RVA: 0x7FFAF2ABCD60
        public void set_description(){} // RVA: 0x7FFAF2AD4B10
        public void get_tags(){} // RVA: 0x7FFAF2ABCD60
        public void set_tags(){} // RVA: 0x7FFAF2AD4B10
        public void get_thumbnailImageUrl(){} // RVA: 0x7FFAF2ABCD60
        public void set_thumbnailImageUrl(){} // RVA: 0x7FFAF2AD4B10
        public void get_version(){} // RVA: 0x7FFAF2ABD840
        public void set_version(){} // RVA: 0x7FFAF2AD4FA0
        public void get_releaseStatus(){} // RVA: 0x7FFAF2ABCD60
        public void set_releaseStatus(){} // RVA: 0x7FFAF2AD4B10
        public void get_featured(){} // RVA: 0x7FFAF2ABDBE0
        public void set_featured(){} // RVA: 0x7FFAF2AD5130
        public void get_unityPackageUpdated(){} // RVA: 0x7FFAF2ABDBE0
        public void set_unityPackageUpdated(){} // RVA: 0x7FFAF2AD5130
        public void get_unityVersion(){} // RVA: 0x7FFAF2ABCD60
        public void set_unityVersion(){} // RVA: 0x7FFAF2AD4B10
        public void get_apiVersion(){} // RVA: 0x7FFAF2ABD840
        public void set_apiVersion(){} // RVA: 0x7FFAF2AD4FA0
        public void get_platform(){} // RVA: 0x7FFAF2ABCD60
        public void set_platform(){} // RVA: 0x7FFAF2AD4B10
        public void get_assetVersion(){} // RVA: 0x7FFAF2ABCD60
        public void set_assetVersion(){} // RVA: 0x7FFAF2AD4B10
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void ReadField(){} // RVA: 0x7FFAF2AC1120
        public void Get(){} // RVA: 0x7FFAF2D33FA0
        public void FetchList(){} // RVA: 0x7FFAF2D33FA0
        public void AddLocal(){} // RVA: 0x7FFAF2D33FA0
        public void IsLocalById(){} // RVA: 0x7FFAF2ABDCC0
        public void get_IsLocal(){} // RVA: 0x7FFAF2ABDBE0
        public void Save(){} // RVA: 0x7FFAF2ADDC60
        public void SaveReleaseStatus(){} // RVA: 0x7FFAF2ADDC60
        public void GetAssetUrl(){} // RVA: 0x7FFAF2ABCD60
        public void HasTag(){} // RVA: 0x7FFAF2ABDE40
        public void AddTag(){} // RVA: 0x7FFAF2ABDE40
        public void RemoveTag(){} // RVA: 0x7FFAF2ABDE40
        public void UpdateVersionAndPlatform(){} // RVA: 0x7FFAF2AD4A50
        public void MakeRequestEndpoint(){}
        public void .cctor(){} // RVA: 0x7FFAF2AD4A80
    }

    public class ApiContentModel`1
    {
        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7FFAF639E9A0
        public void ShouldCache(){} // RVA: 0x7FFAF639ECD0
        public void GetLifeSpan(){} // RVA: 0x7FFAF639ED30
        public void get_name(){} // RVA: 0x7FFAF2E08D50
        public void set_name(){} // RVA: 0x7FFAF2E08D60
        public void get_imageUrl(){} // RVA: 0x7FFAF2E55590
        public void set_imageUrl(){} // RVA: 0x7FFAF2E555A0
        public void get_authorName(){} // RVA: 0x7FFAF2F77C50
        public void set_authorName(){} // RVA: 0x7FFAF2F734F0
        public void get_authorId(){} // RVA: 0x7FFAF2F12D00
        public void set_authorId(){} // RVA: 0x7FFAF2F14450
        public void get_assetUrl(){} // RVA: 0x7FFAF2DCC010
        public void set_assetUrl(){} // RVA: 0x7FFAF2F13060
        public void get_description(){} // RVA: 0x7FFAF3246DE0
        public void set_description(){} // RVA: 0x7FFAF3604600
        public void get_tags(){} // RVA: 0x7FFAF34CC8C0
        public void set_tags(){} // RVA: 0x7FFAF345A650
        public void get_thumbnailImageUrl(){} // RVA: 0x7FFAF34B85E0
        public void set_thumbnailImageUrl(){} // RVA: 0x7FFAF345A5F0
        public void get_version(){} // RVA: 0x7FFAF3773CB0
        public void set_version(){} // RVA: 0x7FFAF3779310
        public void get_releaseStatus(){} // RVA: 0x7FFAF2DF8040
        public void set_releaseStatus(){} // RVA: 0x7FFAF2DF8050
        public void get_featured(){} // RVA: 0x7FFAF41EF990
        public void set_featured(){} // RVA: 0x7FFAF41EEC00
        public void get_unityPackageUpdated(){} // RVA: 0x7FFAF639ED40
        public void set_unityPackageUpdated(){} // RVA: 0x7FFAF639ED50
        public void get_unityVersion(){} // RVA: 0x7FFAF2DF8120
        public void set_unityVersion(){} // RVA: 0x7FFAF2DF8130
        public void get_apiVersion(){} // RVA: 0x7FFAF34B02A0
        public void set_apiVersion(){} // RVA: 0x7FFAF639ED60
        public void get_platform(){} // RVA: 0x7FFAF2EAA100
        public void set_platform(){} // RVA: 0x7FFAF2EAA110
        public void get_assetVersion(){} // RVA: 0x7FFAF639ED70
        public void set_assetVersion(){} // RVA: 0x7FFAF639EE20
        public void .ctor(){} // RVA: 0x7FFAF639EEB0
        public void ReadField(){} // RVA: 0x7FFAF639EF80
        public void Get(){} // RVA: 0x7FFAF639F150
        public void FetchList(){} // RVA: 0x7FFAF639F890
        public void AddLocal(){} // RVA: 0x7FFAF63A1560
        public void IsLocalById(){} // RVA: 0x7FFAF63A1690
        public void get_IsLocal(){} // RVA: 0x7FFAF63A1790
        public void Save(){} // RVA: 0x7FFAF63A1870
        public void SaveReleaseStatus(){} // RVA: 0x7FFAF63A18F0
        public void GetAssetUrl(){} // RVA: 0x7FFAF2DCC010
        public void HasTag(){} // RVA: 0x7FFAF63A1E30
        public void AddTag(){} // RVA: 0x7FFAF63A1EA0
        public void RemoveTag(){} // RVA: 0x7FFAF63A1F40
        public void UpdateVersionAndPlatform(){} // RVA: 0x7FFAF63A20A0
        public void MakeRequestEndpoint(){} // RVA: 0x7FFAF63A2230
        public void .cctor(){} // RVA: 0x7FFAF63A2260
    }

    public class ApiContentModel`1
    {
        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7FFAF639E9A0
        public void ShouldCache(){} // RVA: 0x7FFAF639ECD0
        public void GetLifeSpan(){} // RVA: 0x7FFAF639ED30
        public void get_name(){} // RVA: 0x7FFAF2E08D50
        public void set_name(){} // RVA: 0x7FFAF2E08D60
        public void get_imageUrl(){} // RVA: 0x7FFAF2E55590
        public void set_imageUrl(){} // RVA: 0x7FFAF2E555A0
        public void get_authorName(){} // RVA: 0x7FFAF2F77C50
        public void set_authorName(){} // RVA: 0x7FFAF2F734F0
        public void get_authorId(){} // RVA: 0x7FFAF2F12D00
        public void set_authorId(){} // RVA: 0x7FFAF2F14450
        public void get_assetUrl(){} // RVA: 0x7FFAF2DCC010
        public void set_assetUrl(){} // RVA: 0x7FFAF2F13060
        public void get_description(){} // RVA: 0x7FFAF3246DE0
        public void set_description(){} // RVA: 0x7FFAF3604600
        public void get_tags(){} // RVA: 0x7FFAF34CC8C0
        public void set_tags(){} // RVA: 0x7FFAF345A650
        public void get_thumbnailImageUrl(){} // RVA: 0x7FFAF34B85E0
        public void set_thumbnailImageUrl(){} // RVA: 0x7FFAF345A5F0
        public void get_version(){} // RVA: 0x7FFAF3773CB0
        public void set_version(){} // RVA: 0x7FFAF3779310
        public void get_releaseStatus(){} // RVA: 0x7FFAF2DF8040
        public void set_releaseStatus(){} // RVA: 0x7FFAF2DF8050
        public void get_featured(){} // RVA: 0x7FFAF41EF990
        public void set_featured(){} // RVA: 0x7FFAF41EEC00
        public void get_unityPackageUpdated(){} // RVA: 0x7FFAF639ED40
        public void set_unityPackageUpdated(){} // RVA: 0x7FFAF639ED50
        public void get_unityVersion(){} // RVA: 0x7FFAF2DF8120
        public void set_unityVersion(){} // RVA: 0x7FFAF2DF8130
        public void get_apiVersion(){} // RVA: 0x7FFAF34B02A0
        public void set_apiVersion(){} // RVA: 0x7FFAF639ED60
        public void get_platform(){} // RVA: 0x7FFAF2EAA100
        public void set_platform(){} // RVA: 0x7FFAF2EAA110
        public void get_assetVersion(){} // RVA: 0x7FFAF639ED70
        public void set_assetVersion(){} // RVA: 0x7FFAF639EE20
        public void .ctor(){} // RVA: 0x7FFAF639EEB0
        public void ReadField(){} // RVA: 0x7FFAF639EF80
        public void Get(){} // RVA: 0x7FFAF639F150
        public void FetchList(){} // RVA: 0x7FFAF639F890
        public void AddLocal(){} // RVA: 0x7FFAF63A1560
        public void IsLocalById(){} // RVA: 0x7FFAF63A1690
        public void get_IsLocal(){} // RVA: 0x7FFAF63A1790
        public void Save(){} // RVA: 0x7FFAF63A1870
        public void SaveReleaseStatus(){} // RVA: 0x7FFAF63A18F0
        public void GetAssetUrl(){} // RVA: 0x7FFAF2DCC010
        public void HasTag(){} // RVA: 0x7FFAF63A1E30
        public void AddTag(){} // RVA: 0x7FFAF63A1EA0
        public void RemoveTag(){} // RVA: 0x7FFAF63A1F40
        public void UpdateVersionAndPlatform(){} // RVA: 0x7FFAF63A20A0
        public void MakeRequestEndpoint(){} // RVA: 0x7FFAF63A2230
        public void .cctor(){} // RVA: 0x7FFAF63A2260
    }

    public class ApiContentModel`1
    {
        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7FFAF639E9A0
        public void ShouldCache(){} // RVA: 0x7FFAF639ECD0
        public void GetLifeSpan(){} // RVA: 0x7FFAF639ED30
        public void get_name(){} // RVA: 0x7FFAF2E08D50
        public void set_name(){} // RVA: 0x7FFAF2E08D60
        public void get_imageUrl(){} // RVA: 0x7FFAF2E55590
        public void set_imageUrl(){} // RVA: 0x7FFAF2E555A0
        public void get_authorName(){} // RVA: 0x7FFAF2F77C50
        public void set_authorName(){} // RVA: 0x7FFAF2F734F0
        public void get_authorId(){} // RVA: 0x7FFAF2F12D00
        public void set_authorId(){} // RVA: 0x7FFAF2F14450
        public void get_assetUrl(){} // RVA: 0x7FFAF2DCC010
        public void set_assetUrl(){} // RVA: 0x7FFAF2F13060
        public void get_description(){} // RVA: 0x7FFAF3246DE0
        public void set_description(){} // RVA: 0x7FFAF3604600
        public void get_tags(){} // RVA: 0x7FFAF34CC8C0
        public void set_tags(){} // RVA: 0x7FFAF345A650
        public void get_thumbnailImageUrl(){} // RVA: 0x7FFAF34B85E0
        public void set_thumbnailImageUrl(){} // RVA: 0x7FFAF345A5F0
        public void get_version(){} // RVA: 0x7FFAF3773CB0
        public void set_version(){} // RVA: 0x7FFAF3779310
        public void get_releaseStatus(){} // RVA: 0x7FFAF2DF8040
        public void set_releaseStatus(){} // RVA: 0x7FFAF2DF8050
        public void get_featured(){} // RVA: 0x7FFAF41EF990
        public void set_featured(){} // RVA: 0x7FFAF41EEC00
        public void get_unityPackageUpdated(){} // RVA: 0x7FFAF639ED40
        public void set_unityPackageUpdated(){} // RVA: 0x7FFAF639ED50
        public void get_unityVersion(){} // RVA: 0x7FFAF2DF8120
        public void set_unityVersion(){} // RVA: 0x7FFAF2DF8130
        public void get_apiVersion(){} // RVA: 0x7FFAF34B02A0
        public void set_apiVersion(){} // RVA: 0x7FFAF639ED60
        public void get_platform(){} // RVA: 0x7FFAF2EAA100
        public void set_platform(){} // RVA: 0x7FFAF2EAA110
        public void get_assetVersion(){} // RVA: 0x7FFAF639ED70
        public void set_assetVersion(){} // RVA: 0x7FFAF639EE20
        public void .ctor(){} // RVA: 0x7FFAF639EEB0
        public void ReadField(){} // RVA: 0x7FFAF639EF80
        public void Get(){} // RVA: 0x7FFAF639F150
        public void FetchList(){} // RVA: 0x7FFAF639F890
        public void AddLocal(){} // RVA: 0x7FFAF63A1560
        public void IsLocalById(){} // RVA: 0x7FFAF63A1690
        public void get_IsLocal(){} // RVA: 0x7FFAF63A1790
        public void Save(){} // RVA: 0x7FFAF63A1870
        public void SaveReleaseStatus(){} // RVA: 0x7FFAF63A18F0
        public void GetAssetUrl(){} // RVA: 0x7FFAF2DCC010
        public void HasTag(){} // RVA: 0x7FFAF63A1E30
        public void AddTag(){} // RVA: 0x7FFAF63A1EA0
        public void RemoveTag(){} // RVA: 0x7FFAF63A1F40
        public void UpdateVersionAndPlatform(){} // RVA: 0x7FFAF63A20A0
        public void MakeRequestEndpoint(){} // RVA: 0x7FFAF63A2230
        public void .cctor(){} // RVA: 0x7FFAF63A2260
    }

    public class ApiCredentials
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFAFC3C6B20
        public void SetProfileIndex(){} // RVA: 0x7FFAFC3C6B50
        public void SetString(){} // RVA: 0x7FFAFC3C6BD0
        public void GetString(){} // RVA: 0x7FFAFC3C6E20
        public void Load(){} // RVA: 0x7FFAFC3C7010
        public void SetHumanName(){} // RVA: 0x7FFAFC3C7740
        public void Set(){} // RVA: 0x7FFAFC3C7850
        public void Set2faToken(){} // RVA: 0x7FFAFC3C7E40
        public void GetHumanName(){} // RVA: 0x7FFAFC3C8020
        public void GetAuthToken(){} // RVA: 0x7FFAFC3C8060
        public void GetTwoFactorAuthToken(){} // RVA: 0x7FFAFC3C80A0
        public void GetAuthTokenCookie(){} // RVA: 0x7FFAFC3C80E0
        public void GetTwoFactorAuthTokenCookie(){} // RVA: 0x7FFAFC3C8120
        public void GetAuthTokenProvider(){} // RVA: 0x7FFAFC3C8160
        public void GetAuthTokenProviderUserId(){} // RVA: 0x7FFAFC3C81A0
        public void IsLoaded(){} // RVA: 0x7FFAFC3C81E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ApiDictContainer
    {
        // ── Methods ──
        public void get_cacheLifetime(){} // RVA: 0x7FFAF2E9DE10
        public void set_cacheLifetime(){} // RVA: 0x7FFAF3A6C3A0
        public void get_ExpiryTime(){} // RVA: 0x7FFAF615BC50
        public void set_ExpiryTime(){} // RVA: 0x7FFAF615C0C0
        public void get_requiredFields(){} // RVA: 0x7FFAF2F77C50
        public void set_requiredFields(){} // RVA: 0x7FFAF2F734F0
        public void get_ResponseDictionary(){} // RVA: 0x7FFAFC37BB40
        public void .ctor(){} // RVA: 0x7FFAFC37BD20 | overloaded x2
        public void Validate(){} // RVA: 0x7FFAFC37BD90
        public void ShouldCache(){} // RVA: 0x7FFAFC37C0E0
        public void ShouldClearOnLevelLoad(){} // RVA: 0x7FFAF2D8D320
        public void GetLifeSpan(){} // RVA: 0x7FFAF2E9DE10
        public void Clone(){} // RVA: 0x7FFAFC37C0F0
        public void .cctor(){} // RVA: 0x7FFAFC37C170
        public void <Validate>b__17_0(){} // RVA: 0x7FFAFC37C240
    }

    public class ApiDroneSkin
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF2E08D50
        public void set_name(){} // RVA: 0x7FFAF2E08D60
        public void get_assetBundleId(){} // RVA: 0x7FFAF2E55590
        public void set_assetBundleId(){} // RVA: 0x7FFAF2E555A0
        public void get_viewfinderAssetBundleId(){} // RVA: 0x7FFAF2F77C50
        public void set_viewfinderAssetBundleId(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAFC318CA0
    }

    public class ApiEconomyAccountStatus
    {
        // ── Methods ──
        public void get_UserID(){} // RVA: 0x7FFAF2E08D50
        public void set_UserID(){} // RVA: 0x7FFAF2E08D60
        public void get_Blocked(){} // RVA: 0x7FFAF2E09320
        public void set_Blocked(){} // RVA: 0x7FFAF2E09330
        public void .ctor(){} // RVA: 0x7FFAFC3C8230
    }

    public class ApiEconomyStatus
    {
        // ── Methods ──
        public void get_EconomyIsOnline(){} // RVA: 0x7FFAF2E55570
        public void set_EconomyIsOnline(){} // RVA: 0x7FFAF2E55580
        public void get_EconomyState(){} // RVA: 0x7FFAF4741460
        public void set_EconomyState(){} // RVA: 0x7FFAF4741470
        public void .ctor(){} // RVA: 0x7FFAFC3C8280
    }

    public class ApiEconomyStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC318CF0
        public void get_SellerId(){} // RVA: 0x7FFAF2E08D50
        public void set_SellerId(){} // RVA: 0x7FFAF2E08D60
        public void get_SellerDisplayName(){} // RVA: 0x7FFAF2E55590
        public void set_SellerDisplayName(){} // RVA: 0x7FFAF2E555A0
        public void get_WorldId(){} // RVA: 0x7FFAF2F77C50
        public void set_WorldId(){} // RVA: 0x7FFAF2F734F0
        public void get_GroupId(){} // RVA: 0x7FFAF2F12D00
        public void set_GroupId(){} // RVA: 0x7FFAF2F14450
        public void get_StoreStatus(){} // RVA: 0x7FFAF36690C0
        public void set_StoreStatus(){} // RVA: 0x7FFAF3669E60
        public void get_DisplayName(){} // RVA: 0x7FFAF3246DE0
        public void set_DisplayName(){} // RVA: 0x7FFAF3604600
        public void get_Description(){} // RVA: 0x7FFAF34CC8C0
        public void set_Description(){} // RVA: 0x7FFAF345A650
        public void get_Tags(){} // RVA: 0x7FFAF34B85E0
        public void set_Tags(){} // RVA: 0x7FFAF345A5F0
        public void get_Listings(){} // RVA: 0x7FFAF34CC130
        public void set_Listings(){} // RVA: 0x7FFAF3595030
        public void get_ListingIDs(){} // RVA: 0x7FFAF2DF8040
        public void set_ListingIDs(){} // RVA: 0x7FFAF2DF8050
        public void get_IsGroupStore(){} // RVA: 0x7FFAFC318D40
        public void get_IsWorldStore(){} // RVA: 0x7FFAFC318D60
        public void ReadField(){} // RVA: 0x7FFAFC318D80
        public void WriteField(){} // RVA: 0x7FFAFC318FC0
        public void FetchStore(){} // RVA: 0x7FFAFC319120
    }

    public class ApiFieldAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF316D7E0
    }

    public class ApiFile
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF2E08D50
        public void set_name(){} // RVA: 0x7FFAF2E08D60
        public void get_order(){} // RVA: 0x7FFAF2E55590
        public void set_order(){} // RVA: 0x7FFAF49BAB80
        public void get_ownerId(){} // RVA: 0x7FFAF2F77C50
        public void set_ownerId(){} // RVA: 0x7FFAF2F734F0
        public void get_mimeType(){} // RVA: 0x7FFAF2F12D00
        public void set_mimeType(){} // RVA: 0x7FFAF2F14450
        public void get_extension(){} // RVA: 0x7FFAF2DCC010
        public void set_extension(){} // RVA: 0x7FFAF2F13060
        public void get_versions(){} // RVA: 0x7FFAF3246DE0
        public void set_versions(){} // RVA: 0x7FFAF3604600
        public void get_IsInitialized(){} // RVA: 0x7FFAF331DB40
        public void set_IsInitialized(){} // RVA: 0x7FFAF331DB50
        public void get_IsPendingInit(){} // RVA: 0x7FFAF331B8D0
        public void set_IsPendingInit(){} // RVA: 0x7FFAF8C6EF40
        public void .ctor(){} // RVA: 0x7FFAFC31BC50 | overloaded x3
        public void Create(){} // RVA: 0x7FFAFC31BDE0
        public void Refresh(){} // RVA: 0x7FFAFC31BF80
        public void DownloadFile(){} // RVA: 0x7FFAFC31BFC0
        public void ParseFileIdFromFileAPIUrl(){} // RVA: 0x7FFAFC31C630
        public void TryParseFileIdFromFileAPIUrl(){} // RVA: 0x7FFAFC31C6D0
        public void TryParseFileVersionFromFileAPIUrl(){} // RVA: 0x7FFAFC31C710
        public void TryParseFileIdAndVersionFromFileAPIUrl(){} // RVA: 0x7FFAFC31C760
        public void TryParseFileIdAndVersionAndVariantSuffixFromFileAPIUrl(){} // RVA: 0x7FFAFC31C7A0
        public void TryParseFileIdAndVersionAndVariantFromFileAPIUrl(){} // RVA: 0x7FFAFC31C820 | overloaded x2
        public void PerformRegexMatch(){} // RVA: 0x7FFAFC31C850
        public void TryGetImageAPIUrlFromFileAPIUrl(){} // RVA: 0x7FFAFC31D050
        public void OnDownloadFileCompleted(){} // RVA: 0x7FFAFC31D5B0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFAFC31DCB0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAFC31DCE0
        public void ToStringBrief(){} // RVA: 0x7FFAF3400560
        public void CreateNewVersion(){} // RVA: 0x7FFAFC31DF00
        public void HasExistingVersion(){} // RVA: 0x7FFAFC31E640
        public void HasExistingOrPendingVersion(){} // RVA: 0x7FFAFC31E700
        public void GetLatestVersionNumber(){} // RVA: 0x7FFAFC31E7E0
        public void GetLatestCompleteVersionNumber(){} // RVA: 0x7FFAFC31E840
        public void GetVersion(){} // RVA: 0x7FFAFC31E970
        public void GetLatestCompleteVersion(){} // RVA: 0x7FFAFC31EA10
        public void GetLatestVersion(){} // RVA: 0x7FFAFC31EA40
        public void DeleteVersion(){} // RVA: 0x7FFAFC31EAB0
        public void DeleteLatestVersion(){} // RVA: 0x7FFAFC31EDA0
        public void DownloadSignature(){} // RVA: 0x7FFAFC31F180
        public void GetFileURL(){} // RVA: 0x7FFAFC31F220 | overloaded x2
        public void GetFileRawURL(){} // RVA: 0x7FFAFC31F2B0 | overloaded x2
        public void GetDeltaURL(){} // RVA: 0x7FFAFC31F360 | overloaded x2
        public void GetDeltaRawURL(){} // RVA: 0x7FFAFC31F3F0 | overloaded x2
        public void GetSignatureURL(){} // RVA: 0x7FFAFC31F4A0 | overloaded x2
        public void GetSignatureRawURL(){} // RVA: 0x7FFAFC31F530 | overloaded x2
        public void GetFileApiURL(){} // RVA: 0x7FFAFC31F790 | overloaded x2
        public void GetFileVariantApiURL(){} // RVA: 0x7FFAFC31F8D0
        public void GetFileMD5(){} // RVA: 0x7FFAFC31FD60 | overloaded x2
        public void GetFileDescriptor(){} // RVA: 0x7FFAFC31FDE0
        public void IsLatestVersionQueued(){} // RVA: 0x7FFAFC31FE10
        public void HasQueuedOperation(){} // RVA: 0x7FFAFC31FEE0
        public void IsWaitingForUpload(){} // RVA: 0x7FFAFC320080
        public void IsInErrorState(){} // RVA: 0x7FFAFC320150
        public void StartSimpleUpload(){} // RVA: 0x7FFAFC320220
        public void StartMultipartUpload(){} // RVA: 0x7FFAFC3205B0
        public void FinishUpload(){} // RVA: 0x7FFAFC320990
        public void GetUploadStatus(){} // RVA: 0x7FFAFC320C20
        public void PutSimpleFileToURL(){} // RVA: 0x7FFAFC320E20
        public void PutMultipartDataToURL(){} // RVA: 0x7FFAFC321900
    }

    public class ApiGroupGalleryImage
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF2E08D50
        public void set_name(){} // RVA: 0x7FFAF2E08D60
        public void get_groupId(){} // RVA: 0x7FFAF2E55590
        public void set_groupId(){} // RVA: 0x7FFAF2E555A0
        public void get_galleryId(){} // RVA: 0x7FFAF2F77C50
        public void set_galleryId(){} // RVA: 0x7FFAF2F734F0
        public void get_fileId(){} // RVA: 0x7FFAF2F12D00
        public void set_fileId(){} // RVA: 0x7FFAF2F14450
        public void get_imageUrl(){} // RVA: 0x7FFAF2DCC010
        public void set_imageUrl(){} // RVA: 0x7FFAF2F13060
        public void get_createdAt(){} // RVA: 0x7FFAF3246DE0
        public void set_createdAt(){} // RVA: 0x7FFAF476A190
        public void get_approved(){} // RVA: 0x7FFAF331DB40
        public void set_approved(){} // RVA: 0x7FFAF331DB50
        public void get_approvedAt(){} // RVA: 0x7FFAF34B85E0
        public void set_approvedAt(){} // RVA: 0x7FFAF8AA62E0
        public void get_approvedByUserId(){} // RVA: 0x7FFAF34CC130
        public void set_approvedByUserId(){} // RVA: 0x7FFAF3595030
        public void get_submittedByUserId(){} // RVA: 0x7FFAF2DF8040
        public void set_submittedByUserId(){} // RVA: 0x7FFAF2DF8050
        public void get_file(){} // RVA: 0x7FFAF2DF80B0
        public void set_file(){} // RVA: 0x7FFAF2DF80C0
        public void .ctor(){} // RVA: 0x7FFAFC3D3160
    }

    public class ApiGroupInstanceAnnouncement
    {
        // ── Methods ──
        public void get_title(){} // RVA: 0x7FFAF2E08D50
        public void set_title(){} // RVA: 0x7FFAF2E08D60
        public void get_message(){} // RVA: 0x7FFAF2E55590
        public void set_message(){} // RVA: 0x7FFAF2E555A0
        public void get_imageId(){} // RVA: 0x7FFAF2F77C50
        public void set_imageId(){} // RVA: 0x7FFAF2F734F0
        public void get_imageVersion(){} // RVA: 0x7FFAF3A74570
        public void set_imageVersion(){} // RVA: 0x7FFAF3A74560
        public void .ctor(){} // RVA: 0x7FFAFC3C9C70 | overloaded x2
        public void SendAnnouncement(){} // RVA: 0x7FFAFC3C9DF0
    }

    public class ApiHypeTrainInfo
    {
        // ── Methods ──
        public void get_campaignId(){} // RVA: 0x7FFAF2E08D50
        public void set_campaignId(){} // RVA: 0x7FFAF2E08D60
        public void get_hypeTrainId(){} // RVA: 0x7FFAF2E55590
        public void set_hypeTrainId(){} // RVA: 0x7FFAF2E555A0
        public void get_cooldownSeconds(){} // RVA: 0x7FFAF4593800
        public void set_cooldownSeconds(){} // RVA: 0x7FFAF4596D80
        public void get_endDate(){} // RVA: 0x7FFAF2F12D00
        public void set_endDate(){} // RVA: 0x7FFAF49BABA0
        public void get_lastUpdatedAt(){} // RVA: 0x7FFAF2DCC010
        public void set_lastUpdatedAt(){} // RVA: 0x7FFAF358F010
        public void get_startDate(){} // RVA: 0x7FFAF3246DE0
        public void set_startDate(){} // RVA: 0x7FFAF476A190
        public void get_currentGiftCount(){} // RVA: 0x7FFAF4826570
        public void set_currentGiftCount(){} // RVA: 0x7FFAF4826000
        public void get_totalGiftGoal(){} // RVA: 0x7FFAF4826560
        public void set_totalGiftGoal(){} // RVA: 0x7FFAF4826580
        public void get_totalGiftContributors(){} // RVA: 0x7FFAF4826590
        public void set_totalGiftContributors(){} // RVA: 0x7FFAF4826550
        public void get_totalGiftsFromYouCount(){} // RVA: 0x7FFAF66F9C00
        public void set_totalGiftsFromYouCount(){} // RVA: 0x7FFAF66F9C10
        public void .ctor(){} // RVA: 0x7FFAFC3D58B0
    }

    public class ApiHypeTrainInstanceInfo
    {
        // ── Methods ──
        public void get_potentialTrain(){} // RVA: 0x7FFAF2E08D50
        public void set_potentialTrain(){} // RVA: 0x7FFAF2E08D60
        public void get_current(){} // RVA: 0x7FFAF2E55590
        public void set_current(){} // RVA: 0x7FFAF2E555A0
        public void get_history(){} // RVA: 0x7FFAF2F77C50
        public void set_history(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAFC3D5860
    }

    public class ApiImage
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFAF2D8D320
        public void FetchList(){} // RVA: 0x7FFAFC3241F0
        public void UploadImage(){} // RVA: 0x7FFAFC324D50
        public void .ctor(){} // RVA: 0x7FFAFC325150
    }

    public class ApiInfoPushSystem
    {
        // ── Methods ──
        public void get_isEnabled(){} // RVA: 0x7FFAF2E55570
        public void set_isEnabled(){} // RVA: 0x7FFAF2E55580
        public void get_releaseStatus(){} // RVA: 0x7FFAF2E55590
        public void set_releaseStatus(){} // RVA: 0x7FFAF2E555A0
        public void get_tags(){} // RVA: 0x7FFAF2F77C50
        public void set_tags(){} // RVA: 0x7FFAF2F734F0
        public void get_requireClientTags(){} // RVA: 0x7FFAF2F12D00
        public void set_requireClientTags(){} // RVA: 0x7FFAF2F14450
        public void get_priority(){} // RVA: 0x7FFAF36690C0
        public void set_priority(){} // RVA: 0x7FFAF3669E60
        public void get_startDate(){} // RVA: 0x7FFAF3246DE0
        public void set_startDate(){} // RVA: 0x7FFAF476A190
        public void get_endDate(){} // RVA: 0x7FFAF34CC8C0
        public void set_endDate(){} // RVA: 0x7FFAF8224BB0
        public void get_createdAt(){} // RVA: 0x7FFAF34B85E0
        public void set_createdAt(){} // RVA: 0x7FFAF8AA62E0
        public void get_updatedAt(){} // RVA: 0x7FFAF34CC130
        public void set_updatedAt(){} // RVA: 0x7FFAF461C650
        public void get_hash(){} // RVA: 0x7FFAF2DF8040
        public void set_hash(){} // RVA: 0x7FFAF2DF8050
        public void get_originalManifestId(){} // RVA: 0x7FFAF2DF80B0
        public void set_originalManifestId(){} // RVA: 0x7FFAF2DF80C0
        public void get_experiment(){} // RVA: 0x7FFAF2DF8120
        public void set_experiment(){} // RVA: 0x7FFAF2DF8130
        public void get_data(){} // RVA: 0x7FFAF2EE5460
        public void set_data(){} // RVA: 0x7FFAF2EE5470
        public void .ctor(){} // RVA: 0x7FFAFC3253F0
        public void GetLifeSpan(){} // RVA: 0x7FFAF639ED30
        public void FetchList(){} // RVA: 0x7FFAFC3254B0
        public void Save(){} // RVA: 0x7FFAFC325B70
    }

    public class ApiInventoryBundle
    {
        // ── Methods ──
        public void get_inventoryItemsToInstantiate(){} // RVA: 0x7FFAF2E08D50
        public void set_inventoryItemsToInstantiate(){} // RVA: 0x7FFAF2E08D60
        public void get_notificationDetails(){} // RVA: 0x7FFAF2E55590
        public void set_notificationDetails(){} // RVA: 0x7FFAF2E555A0
        public void .ctor(){} // RVA: 0x7FFAFC326560
    }

    public class ApiInventoryBundleDrop
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF2E08D50
        public void set_name(){} // RVA: 0x7FFAF2E08D60
        public void get_authorId(){} // RVA: 0x7FFAF2E55590
        public void set_authorId(){} // RVA: 0x7FFAF2E555A0
        public void get_targetGroup(){} // RVA: 0x7FFAF2F77C50
        public void set_targetGroup(){} // RVA: 0x7FFAF2F734F0
        public void get_templateIds(){} // RVA: 0x7FFAF2F12D00
        public void set_templateIds(){} // RVA: 0x7FFAF2F14450
        public void get_startDropDate(){} // RVA: 0x7FFAF2DCC010
        public void set_startDropDate(){} // RVA: 0x7FFAF358F010
        public void get_endDropDate(){} // RVA: 0x7FFAF3246DE0
        public void set_endDropDate(){} // RVA: 0x7FFAF476A190
        public void get_dropExpiryDate(){} // RVA: 0x7FFAF34CC8C0
        public void set_dropExpiryDate(){} // RVA: 0x7FFAF8224BB0
        public void get_status(){} // RVA: 0x7FFAF34B85E0
        public void set_status(){} // RVA: 0x7FFAF345A5F0
        public void get_tags(){} // RVA: 0x7FFAF34CC130
        public void set_tags(){} // RVA: 0x7FFAF3595030
        public void get_created_at(){} // RVA: 0x7FFAF2DF8040
        public void set_created_at(){} // RVA: 0x7FFAF461CD00
        public void get_updated_at(){} // RVA: 0x7FFAF2DF80B0
        public void set_updated_at(){} // RVA: 0x7FFAF461CF30
        public void get_notificationDetails(){} // RVA: 0x7FFAF2DF8120
        public void set_notificationDetails(){} // RVA: 0x7FFAF2DF8130
        public void FetchCurrentlyActiveBundleDrops(){} // RVA: 0x7FFAFC3265B0
        public void .ctor(){} // RVA: 0x7FFAFC3269F0
    }

    public class ApiInventoryItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC326B50
        public void get_templateId(){} // RVA: 0x7FFAF2E08D50
        public void set_templateId(){} // RVA: 0x7FFAF2E08D60
        public void get_name(){} // RVA: 0x7FFAF2E55590
        public void set_name(){} // RVA: 0x7FFAF2E555A0
        public void get_description(){} // RVA: 0x7FFAF2F77C50
        public void set_description(){} // RVA: 0x7FFAF2F734F0
        public void get_imageUrl(){} // RVA: 0x7FFAF2F12D00
        public void set_imageUrl(){} // RVA: 0x7FFAF2F14450
        public void get_attribution(){} // RVA: 0x7FFAF2DCC010
        public void set_attribution(){} // RVA: 0x7FFAF2F13060
        public void get_flags(){} // RVA: 0x7FFAF3246DE0
        public void set_flags(){} // RVA: 0x7FFAF3604600
        public void get_tags(){} // RVA: 0x7FFAF34CC8C0
        public void set_tags(){} // RVA: 0x7FFAF345A650
        public void get_collections(){} // RVA: 0x7FFAF34B85E0
        public void set_collections(){} // RVA: 0x7FFAF345A5F0
        public void get_itemType(){} // RVA: 0x7FFAF34CC130
        public void set_itemType(){} // RVA: 0x7FFAF3595030
        public void get_holderId(){} // RVA: 0x7FFAF2DF8040
        public void set_holderId(){} // RVA: 0x7FFAF2DF8050
        public void get_firstAncestor(){} // RVA: 0x7FFAF2DF80B0
        public void set_firstAncestor(){} // RVA: 0x7FFAF2DF80C0
        public void get_firstAncestorHolderId(){} // RVA: 0x7FFAF2DF8120
        public void set_firstAncestorHolderId(){} // RVA: 0x7FFAF2DF8130
        public void get_expiryDate(){} // RVA: 0x7FFAF2EE5460
        public void set_expiryDate(){} // RVA: 0x7FFAFB63A2E0
        public void get_created_at(){} // RVA: 0x7FFAF2EAA100
        public void set_created_at(){} // RVA: 0x7FFAF9384D30
        public void get_updated_at(){} // RVA: 0x7FFAF3546D30
        public void set_updated_at(){} // RVA: 0x7FFAFC313DD0
        public void get_template_created_at(){} // RVA: 0x7FFAF2E0E900
        public void set_template_created_at(){} // RVA: 0x7FFAFC313DE0
        public void get_template_updated_at(){} // RVA: 0x7FFAF2E0E970
        public void set_template_updated_at(){} // RVA: 0x7FFAF8AC6310
        public void get_isArchived(){} // RVA: 0x7FFAF2E0EAD0
        public void set_isArchived(){} // RVA: 0x7FFAF2E0EAE0
        public void get_isSeen(){} // RVA: 0x7FFAF435A2A0
        public void set_isSeen(){} // RVA: 0x7FFAF4355C20
        public void get_last_equipped_at(){} // RVA: 0x7FFAF32A7DB0
        public void set_last_equipped_at(){} // RVA: 0x7FFAF68A18C0
        public void get_equipSlots(){} // RVA: 0x7FFAF3544E10
        public void set_equipSlots(){} // RVA: 0x7FFAF37A6DE0
        public void get_equipSlot(){} // RVA: 0x7FFAF35402E0
        public void set_equipSlot(){} // RVA: 0x7FFAF37A4780
        public void get_quantity(){} // RVA: 0x7FFAF459E360
        public void set_quantity(){} // RVA: 0x7FFAF4598670
        public void get_quantifiable(){} // RVA: 0x7FFAF3E7E0D0
        public void set_quantifiable(){} // RVA: 0x7FFAF3E8A960
        public void get_defaultAttributes(){} // RVA: 0x7FFAF2FB7D10
        public void set_defaultAttributes(){} // RVA: 0x7FFAF2FBA8C0
        public void get_userAttributes(){} // RVA: 0x7FFAF304E660
        public void set_userAttributes(){} // RVA: 0x7FFAF304F420
        public void get_validateUserAttributes(){} // RVA: 0x7FFAF32A48D0
        public void set_validateUserAttributes(){} // RVA: 0x7FFAF32A24D0
        public void get_notificationDetails(){} // RVA: 0x7FFAF353E870
        public void set_notificationDetails(){} // RVA: 0x7FFAF3853F70
        public void get_status(){} // RVA: 0x7FFAF35433D0
        public void set_status(){} // RVA: 0x7FFAF3546DC0
        public void get_metadata(){} // RVA: 0x7FFAF2DF85F0
        public void set_metadata(){} // RVA: 0x7FFAF2DF8600
        public void get_Instantiatable(){} // RVA: 0x7FFAFC326C10
        public void get_Consumable(){} // RVA: 0x7FFAFC326C80
        public void get_Archivable(){} // RVA: 0x7FFAFC326CF0
        public void get_Trashable(){} // RVA: 0x7FFAFC326D60
        public void get_Cloneable(){} // RVA: 0x7FFAFC326DD0
        public void get_Equippable(){} // RVA: 0x7FFAFC326E40
        public void get_Equipped(){} // RVA: 0x7FFAFC326ED0
        public void get_IsUserGenerated(){} // RVA: 0x7FFAFC326F10
        public void get_IsTemplate(){} // RVA: 0x7FFAFC326F80
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFAFC3271D0 | overloaded x2
        public void GetModelForMetadataType(){} // RVA: 0x7FFAFC3273F0
        public void FetchList(){} // RVA: 0x7FFAFC327AC0
        public void Fetch(){} // RVA: 0x7FFAFC328F10
        public void SetIsArchived(){} // RVA: 0x7FFAFC329240
        public void SetIsSeen(){} // RVA: 0x7FFAFC3296D0
        public void Consume(){} // RVA: 0x7FFAFC329B60 | overloaded x2
        public void FetchInventoryTemplate(){} // RVA: 0x7FFAFC329EE0
        public void FetchInventoryTemplateAsync(){} // RVA: 0x7FFAFC32A210
        public void FetchUserInventoryItem(){} // RVA: 0x7FFAFC32A3B0
        public void Equip(){} // RVA: 0x7FFAFC32A700
        public void ClearEquipSlot(){} // RVA: 0x7FFAFC32AD40
        public void SaveUserAttributes(){} // RVA: 0x7FFAFC32B030
        public void FetchEquipped(){} // RVA: 0x7FFAFC32B5A0
        public void GetAttributes(){} // RVA: 0x7FFAFC32BBB0
        public void GetDefaultAttributes(){} // RVA: 0x7FFAFC32BEA0
        public void FetchAllTemplates(){} // RVA: 0x7FFAFC32C0E0
    }

    public class ApiInventoryItemContainer
    {
        // ── Methods ──
        public void get_data(){} // RVA: 0x7FFAF2E08D50
        public void set_data(){} // RVA: 0x7FFAF2E08D60
        public void get_totalCount(){} // RVA: 0x7FFAF3B95CF0
        public void set_totalCount(){} // RVA: 0x7FFAF2F25080
        public void .ctor(){} // RVA: 0x7FFAFC32D7D0
    }

    public class ApiInventoryJweToken
    {
        // ── Methods ──
        public void get_token(){} // RVA: 0x7FFAF2E08D50
        public void set_token(){} // RVA: 0x7FFAF2E08D60
        public void RequestSpawnToken(){} // RVA: 0x7FFAFC32D820
        public void RequestDirectShareToken(){} // RVA: 0x7FFAFC32DD20
        public void RequestPedestalShareToken(){} // RVA: 0x7FFAFC32E270
        public void RequestClone(){} // RVA: 0x7FFAFC32E980
        public void .ctor(){} // RVA: 0x7FFAFC32EE80
    }

    public class ApiJweToken
    {
        // ── Methods ──
        public void get_token(){} // RVA: 0x7FFAF2E08D50
        public void set_token(){} // RVA: 0x7FFAF2E08D60
        public void get_version(){} // RVA: 0x7FFAF3B95CF0
        public void set_version(){} // RVA: 0x7FFAF2F25080
        public void .ctor(){} // RVA: 0x7FFAFC32F030
    }

    public class ApiLeaderboard
    {
        // ── Methods ──
        public void get_userStats(){} // RVA: 0x7FFAF2E08D50
        public void set_userStats(){} // RVA: 0x7FFAF2E08D60
        public void get_leaderboard(){} // RVA: 0x7FFAF2E55590
        public void set_leaderboard(){} // RVA: 0x7FFAF2E555A0
        public void GetCurrentLeaderboardAsync(){} // RVA: 0x7FFAFC32F080
        public void GetPreviousLeaderboardAsync(){} // RVA: 0x7FFAFC32F1B0
        public void GetAnonymizationStateAsync(){} // RVA: 0x7FFAFC32F2E0
        public void SetAnonymizationStateAsync(){} // RVA: 0x7FFAFC32F410
        public void .ctor(){} // RVA: 0x7FFAFC32F560
    }

    public class ApiLeaderboardAnonymizationStatus
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFAF2E55570
        public void set_state(){} // RVA: 0x7FFAF2E55580
        public void get_displayName(){} // RVA: 0x7FFAF2E55590
        public void set_displayName(){} // RVA: 0x7FFAF2E555A0
        public void .ctor(){} // RVA: 0x7FFAFC331760
    }

    public class ApiLeaderboardData
    {
        // ── Methods ──
        public void get_startedAt(){} // RVA: 0x7FFAF2E08D50
        public void set_startedAt(){} // RVA: 0x7FFAF49BAB90
        public void get_endsAt(){} // RVA: 0x7FFAF2E55590
        public void set_endsAt(){} // RVA: 0x7FFAF49BAB80
        public void get_ranks(){} // RVA: 0x7FFAF2F77C50
        public void set_ranks(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAFC3316C0
    }

    public class ApiLeaderboardRank
    {
        // ── Methods ──
        public void get_displayName(){} // RVA: 0x7FFAF2E08D50
        public void set_displayName(){} // RVA: 0x7FFAF2E08D60
        public void get_iconUrl(){} // RVA: 0x7FFAF2E55590
        public void set_iconUrl(){} // RVA: 0x7FFAF2E555A0
        public void get_gifts(){} // RVA: 0x7FFAF4593800
        public void set_gifts(){} // RVA: 0x7FFAF4596D80
        public void get_isAnonymized(){} // RVA: 0x7FFAF33589C0
        public void set_isAnonymized(){} // RVA: 0x7FFAF3354A90
        public void get_isSelf(){} // RVA: 0x7FFAF3350370
        public void set_isSelf(){} // RVA: 0x7FFAF33505B0
        public void .ctor(){} // RVA: 0x7FFAFC331710
    }

    public class ApiLeaderboardUserStats
    {
        // ── Methods ──
        public void get_rank(){} // RVA: 0x7FFAF4741440
        public void set_rank(){} // RVA: 0x7FFAF4741450
        public void get_gifts(){} // RVA: 0x7FFAF4741460
        public void set_gifts(){} // RVA: 0x7FFAF4741470
        public void get_isAnonymized(){} // RVA: 0x7FFAF2E09320
        public void set_isAnonymized(){} // RVA: 0x7FFAF2E09330
        public void get_anonymizedDisplayName(){} // RVA: 0x7FFAF2F77C50
        public void set_anonymizedDisplayName(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAFC331670
    }

    public class ApiLedgerTransaction
    {
        // ── Methods ──
        public void get_Amount(){} // RVA: 0x7FFAF4741440
        public void set_Amount(){} // RVA: 0x7FFAF4741450
        public void get_RunningBalance(){} // RVA: 0x7FFAF4741460
        public void set_RunningBalance(){} // RVA: 0x7FFAF4741470
        public void get_Date(){} // RVA: 0x7FFAF2E55590
        public void set_Date(){} // RVA: 0x7FFAF49BAB80
        public void get_ListingDisplayName(){} // RVA: 0x7FFAF2F77C50
        public void set_ListingDisplayName(){} // RVA: 0x7FFAF2F734F0
        public void get_ListingID(){} // RVA: 0x7FFAF2F12D00
        public void set_ListingID(){} // RVA: 0x7FFAF2F14450
        public void get_ListingType(){} // RVA: 0x7FFAF2DCC010
        public void set_ListingType(){} // RVA: 0x7FFAF2F13060
        public void get_Platform(){} // RVA: 0x7FFAF3246DE0
        public void set_Platform(){} // RVA: 0x7FFAF3604600
        public void get_PurchaseId(){} // RVA: 0x7FFAF34CC8C0
        public void set_PurchaseId(){} // RVA: 0x7FFAF345A650
        public void get_Reason(){} // RVA: 0x7FFAF4826590
        public void set_Reason(){} // RVA: 0x7FFAF4826550
        public void get_ReasonLabel(){} // RVA: 0x7FFAF34CC130
        public void set_ReasonLabel(){} // RVA: 0x7FFAF3595030
        public void get_ToUserId(){} // RVA: 0x7FFAF2DF8040
        public void set_ToUserId(){} // RVA: 0x7FFAF2DF8050
        public void get_ToUserDisplayName(){} // RVA: 0x7FFAF2DF80B0
        public void set_ToUserDisplayName(){} // RVA: 0x7FFAF2DF80C0
        public void get_FromUserId(){} // RVA: 0x7FFAF2DF8120
        public void set_FromUserId(){} // RVA: 0x7FFAF2DF8130
        public void get_FromUserDisplayName(){} // RVA: 0x7FFAF2EE5460
        public void set_FromUserDisplayName(){} // RVA: 0x7FFAF2EE5470
        public void get_TransactionId(){} // RVA: 0x7FFAF2EAA100
        public void set_TransactionId(){} // RVA: 0x7FFAF9384D30
        public void get_TransactionLineId(){} // RVA: 0x7FFAF3546D30
        public void set_TransactionLineId(){} // RVA: 0x7FFAFC313DD0
        public void get_id(){} // RVA: 0x7FFAFC331800
        public void .ctor(){} // RVA: 0x7FFAFC3318A0
    }

    public class ApiLedgerTransactions
    {
        // ── Methods ──
        public void get_StartDate(){} // RVA: 0x7FFAF2E08D50
        public void set_StartDate(){} // RVA: 0x7FFAF49BAB90
        public void get_EndDate(){} // RVA: 0x7FFAF2E55590
        public void set_EndDate(){} // RVA: 0x7FFAF49BAB80
        public void get_Transactions(){} // RVA: 0x7FFAF2F77C50
        public void set_Transactions(){} // RVA: 0x7FFAF2F734F0
        public void .ctor(){} // RVA: 0x7FFAFC3317B0
    }

    public class ApiLicense
    {
        // ── Methods ──
        public void get_LicenseId(){} // RVA: 0x7FFAF2E08D50
        public void set_LicenseId(){} // RVA: 0x7FFAF2E08D60
        public void get_OwnerId(){} // RVA: 0x7FFAF2E55590
        public void set_OwnerId(){} // RVA: 0x7FFAF2E555A0
        public void get_OwnerDisplayName(){} // RVA: 0x7FFAF2F77C50
        public void set_OwnerDisplayName(){} // RVA: 0x7FFAF2F734F0
        public void get_LicenseHolderId(){} // RVA: 0x7FFAF2F12D00
        public void set_LicenseHolderId(){} // RVA: 0x7FFAF2F14450
        public void get_LicenseHolderDisplayName(){} // RVA: 0x7FFAF2DCC010
        public void set_LicenseHolderDisplayName(){} // RVA: 0x7FFAF2F13060
        public void get_ForType(){} // RVA: 0x7FFAF315FD40
        public void set_ForType(){} // RVA: 0x7FFAF39B2F80
        public void get_ForId(){} // RVA: 0x7FFAF34CC8C0
        public void set_ForId(){} // RVA: 0x7FFAF345A650
        public void get_ProductId(){} // RVA: 0x7FFAF34B85E0
        public void set_ProductId(){} // RVA: 0x7FFAF345A5F0
        public void get_ProductType(){} // RVA: 0x7FFAF3773CB0
        public void set_ProductType(){} // RVA: 0x7FFAF3779310
        public void get_IsActive(){} // RVA: 0x7FFAF9DE5D40
        public void set_IsActive(){} // RVA: 0x7FFAF9DE5D50
        public void get_UntilDate(){} // RVA: 0x7FFAF2DF8040
        public void set_UntilDate(){} // RVA: 0x7FFAF461CD00
        public void get_IsCurrent(){} // RVA: 0x7FFAF41EF990
        public void set_IsCurrent(){} // RVA: 0x7FFAF41EEC00
        public void get_Created(){} // RVA: 0x7FFAF2DF8120
        public void set_Created(){} // RVA: 0x7FFAF3967880
        public void get_ForAction(){} // RVA: 0x7FFAF2EE5460
        public void set_ForAction(){} // RVA: 0x7FFAF2EE5470
        public void get_ForName(){} // RVA: 0x7FFAF2EAA100
        public void set_ForName(){} // RVA: 0x7FFAF2EAA110
        public void get_LicenseHolderType(){} // RVA: 0x7FFAF3546D30
        public void set_LicenseHolderType(){} // RVA: 0x7FFAF2E0E8A0
        public void get_Notes(){} // RVA: 0x7FFAF2E0E900
        public void set_Notes(){} // RVA: 0x7FFAF2E0E910
        public void get_Tags(){} // RVA: 0x7FFAF2E0E970
        public void set_Tags(){} // RVA: 0x7FFAF2E0E980
        public void get_Updated(){} // RVA: 0x7FFAF2DF82A0
        public void set_Updated(){} // RVA: 0x7FFAF8E7FBB0
        public void FetchLicenses(){} // RVA: 0x7FFAFC3318F0
        public void FetchActiveLicenses(){} // RVA: 0x7FFAFC331BF0
        public void ReadField(){} // RVA: 0x7FFAFC332540
        public void WriteField(){} // RVA: 0x7FFAFC332960
        public void .ctor(){} // RVA: 0x7FFAFC332B70
    }

    public class ApiLicenseNote
    {
        // ── Methods ──
        public void get_CreatedAt(){} // RVA: 0x7FFAF2E08D50
        public void set_CreatedAt(){} // RVA: 0x7FFAF49BAB90
        public void get_Note(){} // RVA: 0x7FFAF2E55590
        public void set_Note(){} // RVA: 0x7FFAF2E555A0
        public void .ctor(){} // RVA: 0x7FFAFC332D40
    }

    public class ApiListContainer
    {
        // ── Methods ──
        public void get_ResponseList(){} // RVA: 0x7FFAFC37C2B0
        public void get_TotalCount(){} // RVA: 0x7FFAF304CEC0
        public void set_TotalCount(){} // RVA: 0x7FFAF304C530
        public void Validate(){} // RVA: 0x7FFAFC37C320
        public void .ctor(){} // RVA: 0x7FFAFC37C6A0
    }

    public class ApiLoadingScreen
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAF2E08D50
        public void set_name(){} // RVA: 0x7FFAF2E08D60
        public void get_assetBundleId(){} // RVA: 0x7FFAF2E55590
        public void set_assetBundleId(){} // RVA: 0x7FFAF2E555A0
        public void .ctor(){} // RVA: 0x7FFAFC332D90
    }

    public class ApiLocalizableString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
    }

    public class ApiMessage
    {
        // ── Methods ──
        public void get_slot(){} // RVA: 0x7FFAF4741440
        public void set_slot(){} // RVA: 0x7FFAF4741450
        public void get_message(){} // RVA: 0x7FFAF2E55590
        public void set_message(){} // RVA: 0x7FFAF2E555A0
        public void get_messageType(){} // RVA: 0x7FFAF2F77C50
        public void set_messageType(){} // RVA: 0x7FFAF2F734F0
        public void get_updatedAt(){} // RVA: 0x7FFAF2F12D00
        public void set_updatedAt(){} // RVA: 0x7FFAF49BABA0
        public void get_remainingCooldownMinutes(){} // RVA: 0x7FFAF36690C0
        public void set_remainingCooldownMinutes(){} // RVA: 0x7FFAF3669E60
        public void get_canBeUpdated(){} // RVA: 0x7FFAF2DF5520
        public void set_canBeUpdated(){} // RVA: 0x7FFAF2DF5530
        public void .ctor(){} // RVA: 0x7FFAFC332DE0
        public void FetchMessages(){} // RVA: 0x7FFAFC332FB0 | overloaded x2
        public void DeleteAllMessages(){} // RVA: 0x7FFAFC333450 | overloaded x2
        public void DeleteMessageInSlot(){} // RVA: 0x7FFAFC333910 | overloaded x2
        public void SetMessageInSlot(){} // RVA: 0x7FFAFC333E60 | overloaded x2
        public void truncatedMessage(){} // RVA: 0x7FFAFC334490
        public void ToString(){} // RVA: 0x7FFAFC334500
        public void .cctor(){} // RVA: 0x7FFAFC334710
    }

    public class ApiModel
    {
        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAF2DA8380
        public void set_id(){} // RVA: 0x7FFAF2D8EE30
        public void get_ExpiryTime(){} // RVA: 0x7FFAF3444EE0
        public void set_ExpiryTime(){} // RVA: 0x7FFAF34449A0
        public void get_Populated(){} // RVA: 0x7FFAF3198A80
        public void set_Populated(){} // RVA: 0x7FFAF3198B80
        public void get_FailedValidation(){} // RVA: 0x7FFAF36E6000
        public void set_FailedValidation(){} // RVA: 0x7FFAF43BAB20
        public void get_Endpoint(){} // RVA: 0x7FFAF30E74D0
        public void set_Endpoint(){} // RVA: 0x7FFAF2DBB890
        public void GetOrPutCachedMissingFieldList(){} // RVA: 0x7FFAFC334C20
        public void get_FieldsMissingFromOriginalResponse(){} // RVA: 0x7FFAF2E08730
        public void set_FieldsMissingFromOriginalResponse(){} // RVA: 0x7FFAF2E08740
        public void get_FieldsLockedForNetworkUpdates(){} // RVA: 0x7FFAF2E2E0E0
        public void set_FieldsLockedForNetworkUpdates(){} // RVA: 0x7FFAF2EE54D0
        public void GetCacheId(){} // RVA: 0x7FFAFC335500
        public void ComputeCacheId(){} // RVA: 0x7FFAFC3357C0
        public void ShouldCache(){} // RVA: 0x7FFAFC335BD0
        public void GetLifeSpan(){} // RVA: 0x7FFAFC335C10
        public void .ctor(){} // RVA: 0x7FFAFC335CF0 | overloaded x3
        public void Clone(){} // RVA: 0x7FFAFC335F80 | overloaded x3
        public void Save(){} // RVA: 0x7FFAFC3364D0
        public void SaveField(){} // RVA: 0x7FFAFC336510
        public void Post(){} // RVA: 0x7FFAFC3367E0
        public void Put(){} // RVA: 0x7FFAFC336820
        public void Fetch(){} // RVA: 0x7FFAFC336860
        public void PostAsync(){} // RVA: 0x7FFAF2D33FA0
        public void PutAsync(){} // RVA: 0x7FFAF2D33FA0
        public void FetchAsync(){} // RVA: 0x7FFAF2D33FA0
        public void Get(){} // RVA: 0x7FFAFC336890
        public void PostOrPut(){} // RVA: 0x7FFAFC337100
        public void Delete(){} // RVA: 0x7FFAFC3388E0
        public void DeleteAsync(){} // RVA: 0x7FFAFC338B80
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFAFC339E70 | overloaded x4
        public void PopulateMissingValuesFrom(){} // RVA: 0x7FFAFC33ABD0
        public void ExtractApiFields(){} // RVA: 0x7FFAFC33B090
        public void MakeModelContainer(){} // RVA: 0x7FFAFC33B470
        public void ReadField(){} // RVA: 0x7FFAFC33B6F0
        public void TryReadConvert(){} // RVA: 0x7FFAFC33BAE0
        public void WriteField(){} // RVA: 0x7FFAFC33CF90
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFAF2D8D320
        public void GetCreateFromJsonMethodInfo(){} // RVA: 0x7FFAFC33DF10
        public void ParseEnumValue(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void IsNumber(){} // RVA: 0x7FFAFC33E500
        public void DoubleCast(){} // RVA: 0x7FFAFC33E5B0
        public void TryWriteConvert(){} // RVA: 0x7FFAFC33E980
        public void ParseList(){} // RVA: 0x7FFAFC33FA90
        public void ParseDictionary(){} // RVA: 0x7FFAFC33FF50
        public void ParseModel(){} // RVA: 0x7FFAFC340750
        public void ParseLocalizableString(){} // RVA: 0x7FFAFC3409A0
        public void SendGetRequest(){} // RVA: 0x7FFAFC340B80
        public void SendPutRequest(){} // RVA: 0x7FFAFC340E30
        public void MakeRequestEndpoint(){} // RVA: 0x7FFAFC340F00
        public void get_RequiredProperties(){} // RVA: 0x7FFAFC340FB0
        public void get_TargetProperties(){} // RVA: 0x7FFAFC3415F0
        public void FindPropertyName(){} // RVA: 0x7FFAFC341A10
        public void FindProperty(){} // RVA: 0x7FFAFC341D20
        public void IsAdminWritableOnly(){} // RVA: 0x7FFAFC342210
        public void IsApiWritableOnly(){} // RVA: 0x7FFAFC342400
        public void .cctor(){} // RVA: 0x7FFAFC3425F0
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFAF2ABDBE0
        public void Validate(){}
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF63A2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFAF63A27C0
        public void Validate(){} // RVA: 0x7FFAF63A2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF63A2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFAF63A27C0
        public void Validate(){} // RVA: 0x7FFAF63A2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF63A2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFAF63A27C0
        public void Validate(){} // RVA: 0x7FFAF63A2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF63A2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFAF63A27C0
        public void Validate(){} // RVA: 0x7FFAF63A2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF63A2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFAF63A27C0
        public void Validate(){} // RVA: 0x7FFAF63A2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF63A2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFAF63A27C0
        public void Validate(){} // RVA: 0x7FFAF63A2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF63A2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFAF63A27C0
        public void Validate(){} // RVA: 0x7FFAF63A2890
    }

}