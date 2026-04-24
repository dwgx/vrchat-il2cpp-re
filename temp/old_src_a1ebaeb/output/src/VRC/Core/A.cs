// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 100
// Methods: 2329

namespace VRC.Core
{
    public class API : Object
    {
        public object devCeApiUrl; // 0x30BD8DB0
        public object _allowRoaming; // 0x30BD8DB0
        public object _apiOnlineMode; // 0x30BD8DB0
        public object EndpointAccessTimes; // 0x30BD8DB0
        public object Favorites; // 0x30BD8DB0
        public object _offlineQueries; // 0x30BD8DB0

        // ── Original Methods ──
        public void get_ClientGameServerVersion(){} // RVA: 0x7ffab1875e80
        public void .cctor(){} // RVA: 0x7ffab1875ee0
        public void RegisterLogging(){} // RVA: 0x7ffab1876430
        public void IsReady(){} // RVA: 0x7ffab1876840
        public void FromCacheOrNew(){} // RVA: 0x7ffaa887e5c0
        public void CreateFromJson(){} // RVA: 0x7ffaa887e5c0
        public void Fetch(){} // RVA: 0x7ffaa887e5c0
        public void FetchAsync(){} // RVA: 0x7ffaa8659d20
        public void DeleteAsync(){} // RVA: 0x7ffaa86492c0
        public void Delete(){} // RVA: 0x7ffaa8666530
        public void get_DeviceID(){} // RVA: 0x7ffaae538cb0
        public void IsDevApi(){} // RVA: 0x7ffab1876d20
        public void IsDevCeApi(){} // RVA: 0x7ffab1876e00
        public void SendGetRequest(){} // RVA: 0x7ffab1876ee0
        public void SendPostRequest(){} // RVA: 0x7ffab1877000
        public void SendPostFormRequest(){} // RVA: 0x7ffab1877120
        public void SendPostRawJsonRequest(){} // RVA: 0x7ffab1877240
        public void SendPutRequest(){} // RVA: 0x7ffab1877360
        public void SendDeleteRequest(){} // RVA: 0x7ffab1877480
        public void SendRequest(){} // RVA: 0x7ffab18775a0
        public void SendRequestInternal(){} // RVA: 0x7ffab1877cd0
        public void AuthenticateHTTPRequest(){} // RVA: 0x7ffab1879270
        public void AuthenticateUnityWebRequest(){} // RVA: 0x7ffab18796e0
        public void PopulateHTTPRequestHeaders(){} // RVA: 0x7ffab1879a30
        public void PopulateUnityWebRequestHeaders(){} // RVA: 0x7ffab1879ec0
        public void CertVerifyHTTPRequest(){} // RVA: 0x7ffab187a190
        public void CertVerifyUnityWebRequest(){} // RVA: 0x7ffab187a340
        public void InitializeCertificateVerifier(){} // RVA: 0x7ffab187a600
        public void AppendQuery(){} // RVA: 0x7ffab187a730
        public void ConvertJsonListToModelList(){} // RVA: 0x7ffaa8649330
        public void get_IsVRCClient(){} // RVA: 0x7ffab187a7e0
        public void set_IsVRCClient(){} // RVA: 0x7ffab187a840
        public void ClearOnlineMode(){} // RVA: 0x7ffab187ac70
        public void IsOffline(){} // RVA: 0x7ffab187ad20
        public void SendOfflineRequest(){} // RVA: 0x7ffab187b0a0
        public void GenerateMergeCode(){} // RVA: 0x7ffab187b770
        // ── Binary Analysis Named ──
        public void SetClientVersion(){} // RVA: 0x7ffab18764e0
        public void GetClientVersion(){} // RVA: 0x7ffab18765a0
        public void SetStore(){} // RVA: 0x7ffab1876600
        public void GetStore(){} // RVA: 0x7ffab18766c0
        public void SetAllowRoaming(){} // RVA: 0x7ffab1876720
        public void GetAllowRoaming(){} // RVA: 0x7ffab1876780
        public void SetClientGameServerVersion(){} // RVA: 0x7ffab18767e0
        public void SetApiUrlFromEnvironment(){} // RVA: 0x7ffab18768e0
        public void GetApiUrlForEnvironment(){} // RVA: 0x7ffab1876ae0
        public void SetApiUrl(){} // RVA: 0x7ffab1876c10
        public void GetApiUrl(){} // RVA: 0x7ffab1876cc0
        public void SetOnlineMode(){} // RVA: 0x7ffab187a8a0
        public void GetServerEnvironmentForApiUrl(){} // RVA: 0x7ffab187ade0
        public void GetServerEnvironmentForApiUrl(){} // RVA: 0x7ffab187ade0
    }

    public class APICalendarEntryUserInterest : ApiModel
    {
        public object _updatedAt; // 0x34562620, was: <updatedAt>k__BackingField

        // ── Original Methods ──
        public void get_isFollowing(){} // RVA: 0x7ffaa89fa570
        public void set_isFollowing(){} // RVA: 0x7ffaa89fa580
        public void get_createdAt(){} // RVA: 0x7ffaa89fa590
        public void set_createdAt(){} // RVA: 0x7ffaaa5ccbf0
        public void get_updatedAt(){} // RVA: 0x7ffaa8af68f0
        public void set_updatedAt(){} // RVA: 0x7ffaadc676b0
        public void .ctor(){} // RVA: 0x7ffab192eb60
    }

    public class APIEmoji : ApiModel
    {
        public object _animationStyle; // 0x34561240, was: <animationStyle>k__BackingFiel
        public object _frames; // 0x34561240, was: <frames>k__BackingField
        public object _assetBundleId; // 0x34561240, was: <assetBundleId>k__BackingField
        public object LOOP_STYLE_LINEAR; // 0x34561240

        // ── Original Methods ──
        public void get_fileId(){} // RVA: 0x7ffaa89add50
        public void set_fileId(){} // RVA: 0x7ffaa89add60
        public void get_imageUrl(){} // RVA: 0x7ffaa89fa590
        public void set_imageUrl(){} // RVA: 0x7ffaa89fa5a0
        public void get_animationStyle(){} // RVA: 0x7ffaa8af68f0
        public void set_animationStyle(){} // RVA: 0x7ffaa8af19e0
        public void get_maskTag(){} // RVA: 0x7ffaa8d1a3b0
        public void set_maskTag(){} // RVA: 0x7ffaa8efece0
        public void get_animated(){} // RVA: 0x7ffaa98372b0
        public void set_animated(){} // RVA: 0x7ffaa9836fb0
        public void get_frames(){} // RVA: 0x7ffaab965cc0
        public void set_frames(){} // RVA: 0x7ffaabfb3540
        public void get_framesOverTime(){} // RVA: 0x7ffaa8c4abe0
        public void set_framesOverTime(){} // RVA: 0x7ffaa8efe560
        public void get_loopStyle(){} // RVA: 0x7ffaa8f75d20
        public void set_loopStyle(){} // RVA: 0x7ffaa8f7b0d0
        public void get_assetBundleId(){} // RVA: 0x7ffaa8f78170
        public void set_assetBundleId(){} // RVA: 0x7ffaa8f7b130
        public void get_premium(){} // RVA: 0x7ffaa8b704c0
        public void set_premium(){} // RVA: 0x7ffaa8b69410
        public void UploadEmoji(){} // RVA: 0x7ffab18890a0
        public void UploadEmoji(){} // RVA: 0x7ffab18890a0
        public void Fetch(){} // RVA: 0x7ffab1889700
        public void .ctor(){} // RVA: 0x7ffab1889a30
        public void <Fetch>g__ParseData|45_0(){} // RVA: 0x7ffab1889aa0
    }

    public class APIGroup : ApiModel
    {
        public object _shortCode; // 0x3444DC80, was: <shortCode>k__BackingField
        public object _iconUrl; // 0x3444DC80, was: <iconUrl>k__BackingField
        public object _onlineMemberCount; // 0x3444DC80, was: <onlineMemberCount>k__BackingF
        public object _joinState; // 0x3444DC80, was: <joinState>k__BackingField
        public object _updatedAt; // 0x3444DC80, was: <updatedAt>k__BackingField
        public object _iconId; // 0x3444DC80, was: <iconId>k__BackingField
        public object _isSystemGroup; // 0x3444DC80, was: <isSystemGroup>k__BackingField
        public object _tags; // 0x3444DC80, was: <tags>k__BackingField
        public object _activityQuality; // 0x3444DC80, was: <activityQuality>k__BackingFie
        public object _roles; // 0x3444DC80, was: <roles>k__BackingField
        public object _lastPostCreatedAt; // 0x3444DC80, was: <lastPostCreatedAt>k__BackingF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1931d00
        public void .ctor(){} // RVA: 0x7ffab1931d00
        public void get_ownerId(){} // RVA: 0x7ffaa89add50
        public void set_ownerId(){} // RVA: 0x7ffaa89add60
        public void get_name(){} // RVA: 0x7ffaa89fa590
        public void set_name(){} // RVA: 0x7ffaa89fa5a0
        public void get_shortCode(){} // RVA: 0x7ffaa8af68f0
        public void set_shortCode(){} // RVA: 0x7ffaa8af19e0
        public void get_discriminator(){} // RVA: 0x7ffaa8d1a3b0
        public void set_discriminator(){} // RVA: 0x7ffaa8efece0
        public void get_description(){} // RVA: 0x7ffaa8971010
        public void set_description(){} // RVA: 0x7ffaa8f7b010
        public void get_iconUrl(){} // RVA: 0x7ffaa8d1b980
        public void set_iconUrl(){} // RVA: 0x7ffaa8f7b070
        public void get_bannerUrl(){} // RVA: 0x7ffaa8f75d20
        public void set_bannerUrl(){} // RVA: 0x7ffaa8f7b0d0
        public void get_memberCount(){} // RVA: 0x7ffaaa2a7de0
        public void set_memberCount(){} // RVA: 0x7ffaaa2a7dd0
        public void get_onlineMemberCount(){} // RVA: 0x7ffaabf46920
        public void set_onlineMemberCount(){} // RVA: 0x7ffaabf46930
        public void get_memberCountSyncedAt(){} // RVA: 0x7ffaa8f74720
        public void set_memberCountSyncedAt(){} // RVA: 0x7ffaa8d71dc0
        public void get_privacy(){} // RVA: 0x7ffaa899d040
        public void set_privacy(){} // RVA: 0x7ffaa899d050
        public void get_joinState(){} // RVA: 0x7ffaa899d0b0
        public void set_joinState(){} // RVA: 0x7ffaa899d0c0
        public void get_myMember(){} // RVA: 0x7ffaa899d120
        public void set_myMember(){} // RVA: 0x7ffaa899d130
        public void get_createdAt(){} // RVA: 0x7ffaa8a8a460
        public void set_createdAt(){} // RVA: 0x7ffab0cf2590
        public void get_updatedAt(){} // RVA: 0x7ffaa8a4f100
        public void set_updatedAt(){} // RVA: 0x7ffaaea8d820
        public void get_membershipStatus(){} // RVA: 0x7ffaa8f6dbf0
        public void set_membershipStatus(){} // RVA: 0x7ffaa89b38a0
        public void get_bannerId(){} // RVA: 0x7ffaa89b3900
        public void set_bannerId(){} // RVA: 0x7ffaa89b3910
        public void get_iconId(){} // RVA: 0x7ffaa89b3970
        public void set_iconId(){} // RVA: 0x7ffaa89b3980
        public void get_rules(){} // RVA: 0x7ffaa899d2a0
        public void set_rules(){} // RVA: 0x7ffaa899d2b0
        public void get_initialRoleIds(){} // RVA: 0x7ffaa8d57210
        public void set_initialRoleIds(){} // RVA: 0x7ffaa8ecd8e0
        public void get_isSystemGroup(){} // RVA: 0x7ffaa96c9090
        public void set_isSystemGroup(){} // RVA: 0x7ffaa96c8b10
        public void get_isVerified(){} // RVA: 0x7ffaa9feead0
        public void set_isVerified(){} // RVA: 0x7ffaa9fee970
        public void get_galleries(){} // RVA: 0x7ffaa9102670
        public void set_galleries(){} // RVA: 0x7ffaa9354440
        public void get_tags(){} // RVA: 0x7ffaa8f76f40
        public void set_tags(){} // RVA: 0x7ffaa93fc460
        public void get_isSearchable(){} // RVA: 0x7ffaa9ace660
        public void set_isSearchable(){} // RVA: 0x7ffaa9abbc70
        public void get_sizeQuality(){} // RVA: 0x7ffaaf51cbd0
        public void set_sizeQuality(){} // RVA: 0x7ffaaf51cbe0
        public void get_activityQuality(){} // RVA: 0x7ffaae432850
        public void set_activityQuality(){} // RVA: 0x7ffaae432860
        public void get_engagementQuality(){} // RVA: 0x7ffaae2f60a0
        public void set_engagementQuality(){} // RVA: 0x7ffaae2f60b0
        public void get_contentQuality(){} // RVA: 0x7ffaae432c10
        public void set_contentQuality(){} // RVA: 0x7ffaae432c20
        public void get_roles(){} // RVA: 0x7ffaa8f7aa40
        public void set_roles(){} // RVA: 0x7ffaa93f4640
        public void get_links(){} // RVA: 0x7ffaa8f76810
        public void set_links(){} // RVA: 0x7ffaa9101830
        public void get_languages(){} // RVA: 0x7ffaa899d5f0
        public void set_languages(){} // RVA: 0x7ffaa899d600
        public void get_lastPostCreatedAt(){} // RVA: 0x7ffaa899d660
        public void set_lastPostCreatedAt(){} // RVA: 0x7ffaae4551b0
        public void get_storeId(){} // RVA: 0x7ffaa8f6e840
        public void set_storeId(){} // RVA: 0x7ffaa93ec470
        public void UpdateData(){} // RVA: 0x7ffab1932320
        public void FetchAllData(){} // RVA: 0x7ffab1932f90
        public void RequestToJoin(){} // RVA: 0x7ffab1933430
        public void LeaveGroup(){} // RVA: 0x7ffab19337f0
        public void InviteUser(){} // RVA: 0x7ffab1933ff0
        public void BanUser(){} // RVA: 0x7ffab1934420
        public void StrictSearch(){} // RVA: 0x7ffab1937490
        public void ExtractPermissions(){} // RVA: 0x7ffab1938920
        // ── Binary Analysis Named ──
        public void GetGroup(){} // RVA: 0x7ffab1932d90
        public void GetGroupInvites(){} // RVA: 0x7ffab1933b70
        public void GetMembers(){} // RVA: 0x7ffab1934850
        public void GetGroupCapacity(){} // RVA: 0x7ffab1934e20
        public void SetRepresentation(){} // RVA: 0x7ffab1934f40
        public void GetGroupGalleryImages(){} // RVA: 0x7ffab19353d0
        public void GetGroupProducts(){} // RVA: 0x7ffab1935ef0
        public void GetGroupAnnouncements(){} // RVA: 0x7ffab1936330
        public void SetAnnouncementSubscription(){} // RVA: 0x7ffab19368b0
        public void SetEventAnnouncementSubscription(){} // RVA: 0x7ffab1936d10
        public void GetUsingShortCode(){} // RVA: 0x7ffab1937170
        public void GetActiveGroupInstances(){} // RVA: 0x7ffab1937900
        public void GetRoles(){} // RVA: 0x7ffab1937d60
        public void GetAllGroupPermissions(){} // RVA: 0x7ffab1938180
        public void GetGroupPermissions(){} // RVA: 0x7ffab19384b0
    }

    public class APIGroupAnnouncement : ApiModel
    {
        public object _title; // 0x347114D0, was: <title>k__BackingField
        public object _visibility; // 0x347114D0, was: <visibility>k__BackingField
        public object _roleIds; // 0x347114D0, was: <roleIds>k__BackingField

        // ── Original Methods ──
        public void get_groupId(){} // RVA: 0x7ffaa89add50
        public void set_groupId(){} // RVA: 0x7ffaa89add60
        public void get_authorId(){} // RVA: 0x7ffaa89fa590
        public void set_authorId(){} // RVA: 0x7ffaa89fa5a0
        public void get_title(){} // RVA: 0x7ffaa8af68f0
        public void set_title(){} // RVA: 0x7ffaa8af19e0
        public void get_text(){} // RVA: 0x7ffaa8d1a3b0
        public void set_text(){} // RVA: 0x7ffaa8efece0
        public void get_imageUrl(){} // RVA: 0x7ffaa8971010
        public void set_imageUrl(){} // RVA: 0x7ffaa8f7b010
        public void get_visibility(){} // RVA: 0x7ffaa8d1b980
        public void set_visibility(){} // RVA: 0x7ffaa8f7b070
        public void get_createdAt(){} // RVA: 0x7ffaa8f75d20
        public void set_createdAt(){} // RVA: 0x7ffaad836400
        public void get_updatedAt(){} // RVA: 0x7ffaa8f78170
        public void set_updatedAt(){} // RVA: 0x7ffaae1aeb60
        public void get_roleIds(){} // RVA: 0x7ffaa8f74720
        public void set_roleIds(){} // RVA: 0x7ffaa8d71dc0
        public void .ctor(){} // RVA: 0x7ffab193a820
        // ── Binary Analysis Named ──
        public void SetLastPostReadAt(){} // RVA: 0x7ffab193a410
    }

    public class APIGroupList : ApiModel
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab193aca0
        public void .ctor(){} // RVA: 0x7ffab193aca0
    }

    public class APIGroupMember : ApiModel
    {
        public object _roleIds; // 0x3444E0D0, was: <roleIds>k__BackingField
        public object _memberVisibility; // 0x3444E0D0, was: <memberVisibility>k__BackingFi
        public object _mutualGroup; // 0x3444E0D0, was: <mutualGroup>k__BackingField
        public object _shortCode; // 0x3444E0D0, was: <shortCode>k__BackingField
        public object _bannerUrl; // 0x3444E0D0, was: <bannerUrl>k__BackingField
        public object _isSubscribedToAnnouncements; // 0x3444E0D0, was: <isSubscribedToAnnouncements>k
        public object _joinedAt; // 0x3444E0D0, was: <joinedAt>k__BackingField
        public object _lastPostCreatedAt; // 0x3444E0D0, was: <lastPostCreatedAt>k__BackingF
        public object _groupId; // 0xB3F6FFF0, was: ÌÌÌÎÎÌÍÏÌÍÍÍÍÌÎÎÌÎÌÌÏÌÏ

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab193b580
        public void get_groupId(){} // RVA: 0x7ffaa89add50
        public void set_groupId(){} // RVA: 0x7ffaa89add60
        public void get_userId(){} // RVA: 0x7ffaa89fa590
        public void set_userId(){} // RVA: 0x7ffaa89fa5a0
        public void get_roleIds(){} // RVA: 0x7ffaa8af68f0
        public void set_roleIds(){} // RVA: 0x7ffaa8af19e0
        public void get_mRoleIds(){} // RVA: 0x7ffaa8d1a3b0
        public void set_mRoleIds(){} // RVA: 0x7ffaa8efece0
        public void get_permissions(){} // RVA: 0x7ffaa8971010
        public void set_permissions(){} // RVA: 0x7ffaa8f7b010
        public void get_memberVisibility(){} // RVA: 0x7ffaa8d1b980
        public void set_memberVisibility(){} // RVA: 0x7ffaa8f7b070
        public void get_membershipStatus(){} // RVA: 0x7ffaa8f75d20
        public void set_membershipStatus(){} // RVA: 0x7ffaa8f7b0d0
        public void get_isRepresenting(){} // RVA: 0x7ffaa9feeae0
        public void set_isRepresenting(){} // RVA: 0x7ffaa91d7fd0
        public void get_mutualGroup(){} // RVA: 0x7ffaaa250a70
        public void set_mutualGroup(){} // RVA: 0x7ffaaa250a80
        public void get_name(){} // RVA: 0x7ffaa8f74720
        public void set_name(){} // RVA: 0x7ffaa8d71dc0
        public void get_ownerId(){} // RVA: 0x7ffaa899d040
        public void set_ownerId(){} // RVA: 0x7ffaa899d050
        public void get_shortCode(){} // RVA: 0x7ffaa899d0b0
        public void set_shortCode(){} // RVA: 0x7ffaa899d0c0
        public void get_discriminator(){} // RVA: 0x7ffaa899d120
        public void set_discriminator(){} // RVA: 0x7ffaa899d130
        public void get_iconUrl(){} // RVA: 0x7ffaa8a8a460
        public void set_iconUrl(){} // RVA: 0x7ffaa8a8a470
        public void get_bannerUrl(){} // RVA: 0x7ffaa8a4f100
        public void set_bannerUrl(){} // RVA: 0x7ffaa8a4f110
        public void get_privacy(){} // RVA: 0x7ffaa8f6dbf0
        public void set_privacy(){} // RVA: 0x7ffaa89b38a0
        public void get_visibility(){} // RVA: 0x7ffaa89b3900
        public void set_visibility(){} // RVA: 0x7ffaa89b3910
        public void get_isSubscribedToAnnouncements(){} // RVA: 0x7ffaa9a11140
        public void set_isSubscribedToAnnouncements(){} // RVA: 0x7ffaaa3a4030
        public void get_isSubscribedToEventAnnouncements(){} // RVA: 0x7ffaae864de0
        public void set_isSubscribedToEventAnnouncements(){} // RVA: 0x7ffab18e3700
        public void get_memberCount(){} // RVA: 0x7ffaaa1db150
        public void set_memberCount(){} // RVA: 0x7ffaae432830
        public void get_joinedAt(){} // RVA: 0x7ffaa899d2a0
        public void set_joinedAt(){} // RVA: 0x7ffaaa15f360
        public void get_bannedAt(){} // RVA: 0x7ffaa8d57210
        public void set_bannedAt(){} // RVA: 0x7ffaac120980
        public void get_lastPostReadAt(){} // RVA: 0x7ffaa8f205f0
        public void set_lastPostReadAt(){} // RVA: 0x7ffaa9bdaba0
        public void get_lastPostCreatedAt(){} // RVA: 0x7ffaa9102670
        public void set_lastPostCreatedAt(){} // RVA: 0x7ffab18809c0
        public void get_user(){} // RVA: 0x7ffaa8f76f40
        public void set_user(){} // RVA: 0x7ffaa93fc460
        public void get_group(){} // RVA: 0x7ffaa8de7450
        public void set_group(){} // RVA: 0x7ffaa8de5d60
        public void FetchGroup(){} // RVA: 0x7ffab193be80
        // ── Binary Analysis Named ──
        public void GetMemberships(){} // RVA: 0x7ffab193b5e0
        public void SetVisibility(){} // RVA: 0x7ffab193b9c0
        public void GetRepresentation(){} // RVA: 0x7ffab193c1d0
    }

    public class APIGroupMemberList : ApiModel
    {
        // ── Original Methods ──
        public void get_groupId(){} // RVA: 0x7ffaa89add50
        public void set_groupId(){} // RVA: 0x7ffaa89add60
        public void get_members(){} // RVA: 0x7ffaa89fa590
        public void set_members(){} // RVA: 0x7ffaa89fa5a0
        public void .ctor(){} // RVA: 0x7ffab193c960
        public void .ctor(){} // RVA: 0x7ffab193c960
    }

    public class APIGroupRole : ApiModel
    {
        public object _description; // 0x34712890, was: <description>k__BackingField
        public object _isManagementRole; // 0x34712890, was: <isManagementRole>k__BackingFi
        public object _updatedAt; // 0x34712890, was: <updatedAt>k__BackingField
        public object _permissions; // 0x34712890, was: <permissions>k__BackingField

        // ── Original Methods ──
        public void get_groupId(){} // RVA: 0x7ffaa89add50
        public void set_groupId(){} // RVA: 0x7ffaa89add60
        public void get_name(){} // RVA: 0x7ffaa89fa590
        public void set_name(){} // RVA: 0x7ffaa89fa5a0
        public void get_description(){} // RVA: 0x7ffaa8af68f0
        public void set_description(){} // RVA: 0x7ffaa8af19e0
        public void get_isSelfAssignable(){} // RVA: 0x7ffaa8b680a0
        public void set_isSelfAssignable(){} // RVA: 0x7ffaa8b70520
        public void get_requiresTwoFactor(){} // RVA: 0x7ffaa8b6bbc0
        public void set_requiresTwoFactor(){} // RVA: 0x7ffaa8b67c00
        public void get_isManagementRole(){} // RVA: 0x7ffaa9619810
        public void set_isManagementRole(){} // RVA: 0x7ffaae151880
        public void get_requiresPurchase(){} // RVA: 0x7ffaa99cff90
        public void set_requiresPurchase(){} // RVA: 0x7ffaae1ae920
        public void get_createdAt(){} // RVA: 0x7ffaa8971010
        public void set_createdAt(){} // RVA: 0x7ffaaa5564d0
        public void get_updatedAt(){} // RVA: 0x7ffaa8d1b980
        public void set_updatedAt(){} // RVA: 0x7ffaa9132e80
        public void get_defaultRole(){} // RVA: 0x7ffaa8dcb5d0
        public void set_defaultRole(){} // RVA: 0x7ffaa8dc7aa0
        public void get_order(){} // RVA: 0x7ffaaa2a7db0
        public void set_order(){} // RVA: 0x7ffaaa2a7dc0
        public void get_permissions(){} // RVA: 0x7ffaa8f78170
        public void set_permissions(){} // RVA: 0x7ffaa8f7b130
        public void .ctor(){} // RVA: 0x7ffab193cac0
        public void .ctor(){} // RVA: 0x7ffab193cac0
    }

    public class APIGroupRoleList : ApiModel
    {
        // ── Original Methods ──
        public void get_groupId(){} // RVA: 0x7ffaa89add50
        public void set_groupId(){} // RVA: 0x7ffaa89add60
        public void get_roles(){} // RVA: 0x7ffaa89fa590
        public void set_roles(){} // RVA: 0x7ffaa89fa5a0
        public void .ctor(){} // RVA: 0x7ffab193cdd0
        public void .ctor(){} // RVA: 0x7ffab193cdd0
    }

    public class APISticker : ApiModel
    {
        public object _specialEffect; // 0x345605C0, was: <specialEffect>k__BackingField
        public object _animated; // 0x345605C0, was: <animated>k__BackingField
        public object _loopStyle; // 0x345605C0, was: <loopStyle>k__BackingField

        // ── Original Methods ──
        public void get_fileId(){} // RVA: 0x7ffaa89add50
        public void set_fileId(){} // RVA: 0x7ffaa89add60
        public void get_imageUrl(){} // RVA: 0x7ffaa89fa590
        public void set_imageUrl(){} // RVA: 0x7ffaa89fa5a0
        public void get_specialEffect(){} // RVA: 0x7ffaa8af68f0
        public void set_specialEffect(){} // RVA: 0x7ffaa8af19e0
        public void get_animationStyle(){} // RVA: 0x7ffaa8d1a3b0
        public void set_animationStyle(){} // RVA: 0x7ffaa8efece0
        public void get_maskTag(){} // RVA: 0x7ffaa8971010
        public void set_maskTag(){} // RVA: 0x7ffaa8f7b010
        public void get_animated(){} // RVA: 0x7ffaa982f2b0
        public void set_animated(){} // RVA: 0x7ffaa9839000
        public void get_frames(){} // RVA: 0x7ffaa8c4abd0
        public void set_frames(){} // RVA: 0x7ffaa8e5e660
        public void get_framesOverTime(){} // RVA: 0x7ffaaa2a8330
        public void set_framesOverTime(){} // RVA: 0x7ffaaa2a8340
        public void get_loopStyle(){} // RVA: 0x7ffaa8f78170
        public void set_loopStyle(){} // RVA: 0x7ffaa8f7b130
        public void get_assetBundleId(){} // RVA: 0x7ffaa8f74720
        public void set_assetBundleId(){} // RVA: 0x7ffaa8d71dc0
        public void UploadSticker(){} // RVA: 0x7ffab18eec90
        public void UploadSticker(){} // RVA: 0x7ffab18eec90
        public void .ctor(){} // RVA: 0x7ffab18ef2a0
    }

    public class APITutorial : ApiModel
    {
        public object _completedAnyTutorial; // 0x34780030, was: <CompletedAnyTutorial>k__Backi

        // ── Original Methods ──
        public void get_IsTutorialCompleted(){} // RVA: 0x7ffaa89fa570
        public void set_IsTutorialCompleted(){} // RVA: 0x7ffaa89fa580
        public void get_CompletedAnyTutorial(){} // RVA: 0x7ffaaa08e8f0
        public void set_CompletedAnyTutorial(){} // RVA: 0x7ffaaa08ffa0
        public void get_TutorialKey(){} // RVA: 0x7ffaa89fa590
        public void set_TutorialKey(){} // RVA: 0x7ffaa89fa5a0
        public void LoadTutorial(){} // RVA: 0x7ffab18f1d80
        public void .ctor(){} // RVA: 0x7ffab18f2090
    }

    public class APIUIColorPalette : ApiModel
    {
        public object _highlights; // 0x34780480, was: <highlights>k__BackingField
        public object _backgrounds; // 0x34780480, was: <backgrounds>k__BackingField
        public object endpoint; // 0x34780480

        // ── Original Methods ──
        public void get_ownerId(){} // RVA: 0x7ffaa89add50
        public void set_ownerId(){} // RVA: 0x7ffaa89add60
        public void get_name(){} // RVA: 0x7ffaa89fa590
        public void set_name(){} // RVA: 0x7ffaa89fa5a0
        public void get_highlights(){} // RVA: 0x7ffaa8af68f0
        public void set_highlights(){} // RVA: 0x7ffaa8af19e0
        public void get_icons(){} // RVA: 0x7ffaa8d1a3b0
        public void set_icons(){} // RVA: 0x7ffaa8efece0
        public void get_buttons(){} // RVA: 0x7ffaa8971010
        public void set_buttons(){} // RVA: 0x7ffaa8f7b010
        public void get_backgrounds(){} // RVA: 0x7ffaa8d1b980
        public void set_backgrounds(){} // RVA: 0x7ffaa8f7b070
        public void get_text(){} // RVA: 0x7ffaa8f75d20
        public void set_text(){} // RVA: 0x7ffaa8f7b0d0
        public void get_subtext(){} // RVA: 0x7ffaa8f78170
        public void set_subtext(){} // RVA: 0x7ffaa8f7b130
        public void Fetch(){} // RVA: 0x7ffab18f2230
        public void Save(){} // RVA: 0x7ffab18f25e0
        public void Update(){} // RVA: 0x7ffab18f3590
        public void .ctor(){} // RVA: 0x7ffab18f38d0
        public void .cctor(){} // RVA: 0x7ffab18f3920
        // ── Binary Analysis Named ──
        public void GetCurrent(){} // RVA: 0x7ffab18f2ec0
        public void SetCurrent(){} // RVA: 0x7ffab18f31a0
    }

    public class APIUser : ApiModel
    {
        public object MAX_STATUS_DESCRIPTION_LENGTH; // 0x3429F8C0
        public object STATUS_JOIN_ME_API_STRING; // 0x3429F8C0
        public object STATUS_DO_NOT_DISTURB_API_STRING; // 0x3429F8C0
        public object STATUS_ASK_ME_DEFAULT_DISPLAY_STRING; // 0x3429F8C0
        public object _blob; // 0x3429F8C0, was: <blob>k__BackingField
        public object _pronouns; // 0x3429F8C0, was: <pronouns>k__BackingField
        public object _location; // 0x3429F8C0, was: <location>k__BackingField
        public object _hasEmail; // 0x3429F8C0, was: <hasEmail>k__BackingField
        public object _isFriend; // 0x3429F8C0, was: <isFriend>k__BackingField
        public object _last_login; // 0x3429F8C0, was: <last_login>k__BackingField
        public object _developerType; // 0x3429F8C0, was: <developerType>k__BackingField
        public object _queuedInstance; // 0x3429F8C0, was: <queuedInstance>k__BackingFiel
        public object _currentAvatarImageUrl; // 0x3429F8C0, was: <currentAvatarImageUrl>k__Back
        public object _authToken; // 0x3429F8C0, was: <authToken>k__BackingField
        public object _obfuscatedPendingEmail; // 0x3429F8C0, was: <obfuscatedPendingEmail>k__Bac
        public object _steamDetails; // 0x3429F8C0, was: <steamDetails>k__BackingField
        public object _unsubscribe; // 0x3429F8C0, was: <unsubscribe>k__BackingField
        public object _homeLocation; // 0x3429F8C0, was: <homeLocation>k__BackingField
        public object _statusDescription; // 0x3429F8C0, was: <statusDescription>k__BackingF
        public object _state; // 0x3429F8C0, was: <state>k__BackingField
        public object _hasDiscordFriendsOptOut; // 0x3429F8C0, was: <hasDiscordFriendsOptOut>k__Ba
        public object _note; // 0x3429F8C0, was: <note>k__BackingField
        public object _hideContentFilterSettings; // 0x3429F8C0, was: <hideContentFilterSettings>k__
        public object _ageVerified; // 0x3429F8C0, was: <ageVerified>k__BackingField
        public object _discordId; // 0x3429F8C0, was: <discordId>k__BackingField
        public object _platform; // 0x3429F8C0, was: <platform>k__BackingField
        public object _twoFactorAuthMethods; // 0x3429F8C0, was: <twoFactorAuthMethods>k__Backi
        public object _languagesShortNames; // 0x3429F8C0, was: <LanguagesShortNames>k__Backin
        public object System.Collections.Generic; // 0x330A9140

        // ── Original Methods ──
        public void ShouldCache(){} // RVA: 0x7ffab18f3c20
        public void get_blob(){} // RVA: 0x7ffaa89add50
        public void set_blob(){} // RVA: 0x7ffaa89add60
        public void get_displayName(){} // RVA: 0x7ffaa89fa590
        public void set_displayName(){} // RVA: 0x7ffaa89fa5a0
        public void get_username(){} // RVA: 0x7ffaa8af68f0
        public void set_username(){} // RVA: 0x7ffaa8af19e0
        public void get_pronouns(){} // RVA: 0x7ffaa8d1a3b0
        public void set_pronouns(){} // RVA: 0x7ffaa8efece0
        public void get_bio(){} // RVA: 0x7ffaa8971010
        public void set_bio(){} // RVA: 0x7ffaa8f7b010
        public void get_bioLinks(){} // RVA: 0x7ffaa8d1b980
        public void set_bioLinks(){} // RVA: 0x7ffaa8f7b070
        public void get_location(){} // RVA: 0x7ffaa8f75d20
        public void set_location(){} // RVA: 0x7ffaa8f7b0d0
        public void get_avatarId(){} // RVA: 0x7ffaa8f78170
        public void set_avatarId(){} // RVA: 0x7ffaa8f7b130
        public void get_fallbackId(){} // RVA: 0x7ffaa8f74720
        public void set_fallbackId(){} // RVA: 0x7ffaa8d71dc0
        public void get_hasEmail(){} // RVA: 0x7ffaa9c06d20
        public void set_hasEmail(){} // RVA: 0x7ffaa9c096e0
        public void get_isBoopingEnabled(){} // RVA: 0x7ffaabf46960
        public void set_isBoopingEnabled(){} // RVA: 0x7ffaabf46970
        public void get_hasBirthday(){} // RVA: 0x7ffaae360f40
        public void set_hasBirthday(){} // RVA: 0x7ffaae360f50
        public void get_isFriend(){} // RVA: 0x7ffaae360f60
        public void set_isFriend(){} // RVA: 0x7ffaae360f70
        public void get_friendKey(){} // RVA: 0x7ffaa899d0b0
        public void set_friendKey(){} // RVA: 0x7ffaa899d0c0
        public void get_friendRequestStatus(){} // RVA: 0x7ffaa899d120
        public void set_friendRequestStatus(){} // RVA: 0x7ffaa899d130
        public void get_last_login(){} // RVA: 0x7ffaa8a8a460
        public void set_last_login(){} // RVA: 0x7ffaa8a8a470
        public void get_last_activity(){} // RVA: 0x7ffaa8a4f100
        public void set_last_activity(){} // RVA: 0x7ffaa8a4f110
        public void get_date_joined(){} // RVA: 0x7ffaa8f6dbf0
        public void set_date_joined(){} // RVA: 0x7ffaa89b38a0
        public void get_developerType(){} // RVA: 0x7ffaaa23fe60
        public void set_developerType(){} // RVA: 0x7ffaaa23fe70
        public void get_events(){} // RVA: 0x7ffaa89b3970
        public void set_events(){} // RVA: 0x7ffaa89b3980
        public void get_acceptedTOSVersion(){} // RVA: 0x7ffaaba8f7a0
        public void set_acceptedTOSVersion(){} // RVA: 0x7ffaae432840
        public void get_queuedInstance(){} // RVA: 0x7ffaa8d57210
        public void set_queuedInstance(){} // RVA: 0x7ffaa8ecd8e0
        public void get_queuedInstancePosition(){} // RVA: 0x7ffaae6287e0
        public void set_queuedInstancePosition(){} // RVA: 0x7ffaaf69c850
        public void get_acceptedPrivacyVersion(){} // RVA: 0x7ffaaa1b8000
        public void set_acceptedPrivacyVersion(){} // RVA: 0x7ffaa9f3c2c0
        public void get_currentAvatarImageUrl(){} // RVA: 0x7ffaa9102670
        public void set_currentAvatarImageUrl(){} // RVA: 0x7ffaa9354440
        public void get_currentAvatarThumbnailImageUrl(){} // RVA: 0x7ffaa8f76f40
        public void set_currentAvatarThumbnailImageUrl(){} // RVA: 0x7ffaa93fc460
        public void get_currentAvatarTags(){} // RVA: 0x7ffaa8de7450
        public void set_currentAvatarTags(){} // RVA: 0x7ffaa8de5d60
        public void get_authToken(){} // RVA: 0x7ffaa8b68c40
        public void set_authToken(){} // RVA: 0x7ffaa8b6fd10
        public void get_emailVerified(){} // RVA: 0x7ffaa8d5b050
        public void set_emailVerified(){} // RVA: 0x7ffaa8d5a940
        public void get_hasPendingEmail(){} // RVA: 0x7ffab18f3c80
        public void set_hasPendingEmail(){} // RVA: 0x7ffab18f3c90
        public void get_obfuscatedPendingEmail(){} // RVA: 0x7ffaa8f7aa40
        public void set_obfuscatedPendingEmail(){} // RVA: 0x7ffaa93f4640
        public void get_friendIDs(){} // RVA: 0x7ffaa8f76810
        public void set_friendIDs(){} // RVA: 0x7ffaa9101830
        public void get_currentAvatarAssetUrl(){} // RVA: 0x7ffaa899d5f0
        public void set_currentAvatarAssetUrl(){} // RVA: 0x7ffaa899d600
        public void get_steamDetails(){} // RVA: 0x7ffaa899d660
        public void set_steamDetails(){} // RVA: 0x7ffaa899d670
        public void get_travelingToLocation(){} // RVA: 0x7ffaa8f6e840
        public void set_travelingToLocation(){} // RVA: 0x7ffaa93ec470
        public void get_obfuscatedEmail(){} // RVA: 0x7ffaa8f77ed0
        public void set_obfuscatedEmail(){} // RVA: 0x7ffaa93f6970
        public void get_unsubscribe(){} // RVA: 0x7ffaae432bd0
        public void set_unsubscribe(){} // RVA: 0x7ffaae432be0
        public void get_hasLoggedInFromClient(){} // RVA: 0x7ffaae432bf0
        public void set_hasLoggedInFromClient(){} // RVA: 0x7ffaae432c00
        public void get_pastDisplayNames(){} // RVA: 0x7ffaa8f70c30
        public void set_pastDisplayNames(){} // RVA: 0x7ffaa93e3af0
        public void get_homeLocation(){} // RVA: 0x7ffaa8d916d0
        public void set_homeLocation(){} // RVA: 0x7ffaa93f45e0
        public void get_tags(){} // RVA: 0x7ffaa8d92160
        public void set_tags(){} // RVA: 0x7ffab18f3ca0
        public void get_status(){} // RVA: 0x7ffaa8f74160
        public void set_status(){} // RVA: 0x7ffaa8f2e920
        public void get_statusDescription(){} // RVA: 0x7ffaa8f6f0b0
        public void set_statusDescription(){} // RVA: 0x7ffaa8f2e8c0
        public void get_badges(){} // RVA: 0x7ffaa8f77bc0
        public void set_badges(){} // RVA: 0x7ffaa93f5420
        public void get_statusHistory(){} // RVA: 0x7ffaa8f75d50
        public void set_statusHistory(){} // RVA: 0x7ffaa94036f0
        public void get_state(){} // RVA: 0x7ffaa8f74750
        public void set_state(){} // RVA: 0x7ffaa93e77a0
        public void get_allowAvatarCopying(){} // RVA: 0x7ffaae68b4d0
        public void set_allowAvatarCopying(){} // RVA: 0x7ffaae68b4e0
        public void get_hasSharedConnectionsOptOut(){} // RVA: 0x7ffaae68b4f0
        public void set_hasSharedConnectionsOptOut(){} // RVA: 0x7ffaae68b500
        public void get_hasDiscordFriendsOptOut(){} // RVA: 0x7ffaae68b550
        public void set_hasDiscordFriendsOptOut(){} // RVA: 0x7ffaae68b560
        public void get_userIcon(){} // RVA: 0x7ffaa8f6f0f0
        public void set_userIcon(){} // RVA: 0x7ffaa93d9af0
        public void get_profilePicOverride(){} // RVA: 0x7ffaa8f78130
        public void set_profilePicOverride(){} // RVA: 0x7ffaa93e4fb0
        public void get_note(){} // RVA: 0x7ffaa8f73670
        public void set_note(){} // RVA: 0x7ffaa93e9360
        public void get_iconUrl(){} // RVA: 0x7ffaa93d5320
        public void set_iconUrl(){} // RVA: 0x7ffaa93e3d80
        public void get_thumbnailUrl(){} // RVA: 0x7ffaa93d4100
        public void set_thumbnailUrl(){} // RVA: 0x7ffaa93e7fd0
        public void get_hideContentFilterSettings(){} // RVA: 0x7ffaaa1cc1c0
        public void set_hideContentFilterSettings(){} // RVA: 0x7ffaaa1cc1d0
        public void get_contentFilters(){} // RVA: 0x7ffaa8e19790
        public void set_contentFilters(){} // RVA: 0x7ffaa93fdbe0
        public void get_userLanguageCode(){} // RVA: 0x7ffaa93d15b0
        public void set_userLanguageCode(){} // RVA: 0x7ffaa93d3cc0
        public void get_ageVerified(){} // RVA: 0x7ffaae68e0a0
        public void set_ageVerified(){} // RVA: 0x7ffab18f3d10
        public void get_isAdult(){} // RVA: 0x7ffab18f3d20
        public void set_isAdult(){} // RVA: 0x7ffab18f3d30
        public void get_ageVerificationStatus(){} // RVA: 0x7ffaa8f74aa0
        public void set_ageVerificationStatus(){} // RVA: 0x7ffaa8f744d0
        public void get_discordId(){} // RVA: 0x7ffaa8f7aa00
        public void set_discordId(){} // RVA: 0x7ffaa8f77dc0
        public void get_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x7ffaae6668c0
        public void set_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x7ffab18f3d40
        public void get_last_platform(){} // RVA: 0x7ffaa8f6dbe0
        public void set_last_platform(){} // RVA: 0x7ffab18f3d50
        public void get_platform(){} // RVA: 0x7ffaa8f70430
        public void set_platform(){} // RVA: 0x7ffaa8f7aac0
        public void get_last_mobile(){} // RVA: 0x7ffaa8f74760
        public void set_last_mobile(){} // RVA: 0x7ffaa8f6e0b0
        public void get_twoFactorAuthEnabled(){} // RVA: 0x7ffaaeacfbd0
        public void set_twoFactorAuthEnabled(){} // RVA: 0x7ffab18f3ed0
        public void get_twoFactorAuthMethods(){} // RVA: 0x7ffaa8f76170
        public void set_twoFactorAuthMethods(){} // RVA: 0x7ffaa93d3600
        public void get_LanguageTagsDictionary(){} // RVA: 0x7ffab18f3ee0
        public void get_languagesDisplayNames(){} // RVA: 0x7ffaa8f6ff20
        public void set_languagesDisplayNames(){} // RVA: 0x7ffaa93d64a0
        public void set_LanguagesShortNames(){} // RVA: 0x7ffaa93d5a40
        public void get_LanguagesShortNames(){} // RVA: 0x7ffaa93e4de0
        public void get_ShouldSeeInstanceByStatus(){} // RVA: 0x7ffab18f4730
        public void get_IsOnMobile(){} // RVA: 0x7ffab18f4770
        public void get_profilePicImageUrl(){} // RVA: 0x7ffab18f4790
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x7ffab18f47b0
        public void FetchBalance(){} // RVA: 0x7ffab18f47d0
        public void get_IsAccountVerified(){} // RVA: 0x7ffaa8a17850
        public void get_hasNoPowers(){} // RVA: 0x7ffab18f4b60
        public void get_hasScriptingAccess(){} // RVA: 0x7ffab18f4bb0
        public void get_hasModerationPowers(){} // RVA: 0x7ffab18f4cb0
        public void get_hasVIPAccess(){} // RVA: 0x7ffab18f4d70
        public void get_hasSuperPowers(){} // RVA: 0x7ffab18f4dc0
        public void get_canPublishWorldsAndAvatars(){} // RVA: 0x7ffab18f4e10
        public void get_canPublishAllContent(){} // RVA: 0x7ffab18f5030
        public void get_canPublishAvatars(){} // RVA: 0x7ffab18f5160
        public void get_canPublishWorlds(){} // RVA: 0x7ffab18f5280
        public void get_canPublishProps(){} // RVA: 0x7ffab18f53a0
        public void get_isUntrusted(){} // RVA: 0x7ffab18f54c0
        public void get_isNewUser(){} // RVA: 0x7ffab18f5520
        public void get_isEarlyAdopter(){} // RVA: 0x7ffab18f55e0
        public void get_isSupporter(){} // RVA: 0x7ffab18f56a0
        public void get_hasBasicTrustLevel(){} // RVA: 0x7ffab18f5760
        public void get_hasKnownTrustLevel(){} // RVA: 0x7ffab18f5830
        public void get_hasTrustedTrustLevel(){} // RVA: 0x7ffab18f5900
        public void get_hasVeteranTrustLevel(){} // RVA: 0x7ffab18f59d0
        public void get_hasLegendTrustLevel(){} // RVA: 0x7ffab18f5aa0
        public void get_hasNegativeTrustLevel(){} // RVA: 0x7ffab18f5b70
        public void get_hasVeryNegativeTrustLevel(){} // RVA: 0x7ffab18f5c40
        public void get_hasFeedbackAccess(){} // RVA: 0x7ffab18f5d00
        public void get_showSocialRank(){} // RVA: 0x7ffab18f5dc0
        public void get_showModTag(){} // RVA: 0x7ffab18f5e60
        public void get_canSetStatusOffline(){} // RVA: 0x7ffab18f5f00
        public void get_statusIsSetToOffline(){} // RVA: 0x7ffab18f5f60
        public void get_statusIsSetToJoinMe(){} // RVA: 0x7ffab18f6090
        public void get_statusIsSetToAskMe(){} // RVA: 0x7ffab18f6130
        public void get_statusIsSetToDoNotDisturb(){} // RVA: 0x7ffab18f6260
        public void get_statusDefaultDescriptionDisplayString(){} // RVA: 0x7ffab18f6390
        public void truncatedBio(){} // RVA: 0x7ffab18f6520
        public void truncatedStatusDescription(){} // RVA: 0x7ffab18f6590
        public void get_statusDescriptionDisplayString(){} // RVA: 0x7ffab18f6600
        public void get_statusValue(){} // RVA: 0x7ffab18f66c0
        public void get_CurrentLocation(){} // RVA: 0x7ffab18f6730
        public void get_canSeeAllUsersStatus(){} // RVA: 0x7ffab18f6a90
        public void MergeFieldsInto(){} // RVA: 0x7ffab18f6af0
        public void get_IsLoggedIn(){} // RVA: 0x7ffab18f7370
        public void get_IsSelf(){} // RVA: 0x7ffab18f7400
        public void get_CurrentUser(){} // RVA: 0x7ffab18f7550
        public void set_CurrentUser(){} // RVA: 0x7ffab18f75b0
        public void .ctor(){} // RVA: 0x7ffab18f78e0
        public void .ctor(){} // RVA: 0x7ffab18f78e0
        public void ReadField(){} // RVA: 0x7ffab18f8690
        public void WriteField(){} // RVA: 0x7ffab18f8740
        public void InitialFetchCurrentUser(){} // RVA: 0x7ffab18f88d0
        public void Register(){} // RVA: 0x7ffab18f8cf0
        public void UpdateAccountInfo(){} // RVA: 0x7ffab18f9720
        public void Login(){} // RVA: 0x7ffab18fa1f0
        public void VerifyTwoFactorAuthCode(){} // RVA: 0x7ffab18fa6e0
        public void VerifyStepUpAuthCode(){} // RVA: 0x7ffab18facd0
        public void ThirdPartyLogin(){} // RVA: 0x7ffab18fb850
        public void DiscordLogin(){} // RVA: 0x7ffab18fbc60
        public void DiscordFinalizeLogin(){} // RVA: 0x7ffab18fc230
        public void DiscordLinkStatus(){} // RVA: 0x7ffab18fcd20
        public void DiscordUnlink(){} // RVA: 0x7ffab18fd210
        public void DiscordAccess(){} // RVA: 0x7ffab18fd550
        public void RedeemPromo(){} // RVA: 0x7ffab18fd890
        public void Logout(){} // RVA: 0x7ffab18fdc80
        public void FetchPublishWorldsInformation(){} // RVA: 0x7ffab18fddd0
        public void FetchUsers(){} // RVA: 0x7ffab18feaf0
        public void FetchUser(){} // RVA: 0x7ffab18fe780
        public void FetchUsers(){} // RVA: 0x7ffab18feaf0
        public void FetchUsersSearchResults(){} // RVA: 0x7ffab18feed0
        public void FetchFriends(){} // RVA: 0x7ffab18ff2e0
        public void AttemptVerification(){} // RVA: 0x7ffab18ffd50
        public void TagsToDeveloperType(){} // RVA: 0x7ffab18ffe10
        public void AddLanguage(){} // RVA: 0x7ffab19002e0
        public void RemoveLanguage(){} // RVA: 0x7ffab19008b0
        public void AddLink(){} // RVA: 0x7ffab1900e40
        public void ModifyLink(){} // RVA: 0x7ffab1901380
        public void UpdateBio(){} // RVA: 0x7ffab1901820
        public void UpdateContentFilters(){} // RVA: 0x7ffab1901e10
        public void UpdateUserLanguageCode(){} // RVA: 0x7ffab1902230
        public void AddNewStatusToHistory(){} // RVA: 0x7ffab1902720
        public void StatusValueToString(){} // RVA: 0x7ffab19028e0
        public void StringToStatusValue(){} // RVA: 0x7ffab1902a40
        public void UnfriendUser(){} // RVA: 0x7ffab1902cc0
        public void LocalAddFriend(){} // RVA: 0x7ffab19030d0
        public void IsFriendsWith(){} // RVA: 0x7ffab1903320
        public void get_HasRequestedToBeFriend(){} // RVA: 0x7ffab1903550
        public void set_HasRequestedToBeFriend(){} // RVA: 0x7ffab19035d0
        public void get_HasFriendRequestPending(){} // RVA: 0x7ffab1903670
        public void set_HasFriendRequestPending(){} // RVA: 0x7ffab19036f0
        public void Exists(){} // RVA: 0x7ffab1903ae0
        public void HasTag(){} // RVA: 0x7ffab1903b20
        public void AddTag(){} // RVA: 0x7ffab1903b90
        public void RemoveTag(){} // RVA: 0x7ffab1903c30
        public void Equals(){} // RVA: 0x7ffab1903d80
        public void UpdateNote(){} // RVA: 0x7ffab1903e30
        public void ResetPersistenceDataForWorld(){} // RVA: 0x7ffab1904e50
        public void ResetAllPersistenceDataForWorlds(){} // RVA: 0x7ffab19051f0
        public void UpdateBadge(){} // RVA: 0x7ffab1905530
        public void ToString(){} // RVA: 0x7ffab1905d90
        public void .cctor(){} // RVA: 0x7ffab19060d0
        // ── Binary Analysis Named ──
        public void GetLifeSpan(){} // RVA: 0x7ffaa988f980
        public void SetUserLanguages(){} // RVA: 0x7ffab18f4370
        public void SetIsBoopingEnabled(){} // RVA: 0x7ffab18ffe80
        public void SetAvatarPropertiesFromModel(){} // RVA: 0x7ffab1903790
        public void SetAvatarFallbackPropertiesFromModel(){} // RVA: 0x7ffab19039f0
        public void SetUserInterests(){} // RVA: 0x7ffab19044c0
        public void GetUserInterests(){} // RVA: 0x7ffab1904790
        public void CheckIfPersistenceDataExistsForWorld(){} // RVA: 0x7ffab1904aa0
    }

    public class ApiAdminAssetBundle : ApiModel
    {
        public object _imageUrl; // 0x348BFA90, was: <imageUrl>k__BackingField
        public object _unityPackages; // 0x348BFA90, was: <unityPackages>k__BackingField

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_description(){} // RVA: 0x7ffaa89fa590
        public void set_description(){} // RVA: 0x7ffaa89fa5a0
        public void get_imageUrl(){} // RVA: 0x7ffaa8af68f0
        public void set_imageUrl(){} // RVA: 0x7ffaa8af19e0
        public void get_tags(){} // RVA: 0x7ffaa8d1a3b0
        public void set_tags(){} // RVA: 0x7ffaa8efece0
        public void get_assetVersion(){} // RVA: 0x7ffaa9221d50
        public void set_assetVersion(){} // RVA: 0x7ffaa92217c0
        public void get_unityPackages(){} // RVA: 0x7ffaa8d1b980
        public void set_unityPackages(){} // RVA: 0x7ffaa8f7b070
        public void CreateAdminAssetBundle(){} // RVA: 0x7ffab187dbf0
        public void AddPackageToBundle(){} // RVA: 0x7ffab187e530
        public void RequestDeleteBundle(){} // RVA: 0x7ffab187f820
        public void SendPropertyUpdate(){} // RVA: 0x7ffab187fb30
        public void .ctor(){} // RVA: 0x7ffab1880340
        // ── Binary Analysis Named ──
        public void GetPlatformString(){} // RVA: 0x7ffab187d7a0
        public void GetPlatformString(){} // RVA: 0x7ffab187d7a0
        public void GetBundleLink(){} // RVA: 0x7ffab187d930
        public void GetAdminAssetBundle(){} // RVA: 0x7ffab187ed30
        public void GetAllAdminAssetBundles(){} // RVA: 0x7ffab187f060
    }

    public class ApiAvatar : ApiContentModel`1
    {
        public object _variant; // 0x3198ADE0, was: <variant>k__BackingField
        public object _created_at; // 0x3198ADE0, was: <created_at>k__BackingField
        public object _offlineAnalysisScanStatus; // 0x3198ADE0, was: <offlineAnalysisScanStatus>k__
        public object _productId; // 0x3198ADE0, was: <productId>k__BackingField
        public object _highestPrice; // 0x3198ADE0, was: <highestPrice>k__BackingField
        public object AvatarsEndpoint; // 0x3198ADE0

        // ── Original Methods ──
        public void get_impostorUrl(){} // RVA: 0x7ffaa89b3900
        public void set_impostorUrl(){} // RVA: 0x7ffaa89b3910
        public void get_variant(){} // RVA: 0x7ffaaa1dded0
        public void set_variant(){} // RVA: 0x7ffaae432980
        public void get_impostorUnityVersion(){} // RVA: 0x7ffaa899d2a0
        public void set_impostorUnityVersion(){} // RVA: 0x7ffaa899d2b0
        public void get_unityPackages(){} // RVA: 0x7ffaa8d57210
        public void set_unityPackages(){} // RVA: 0x7ffaa8ecd8e0
        public void get_created_at(){} // RVA: 0x7ffaa8f205f0
        public void set_created_at(){} // RVA: 0x7ffaa9bdaba0
        public void get_updated_at(){} // RVA: 0x7ffaa9102670
        public void set_updated_at(){} // RVA: 0x7ffab18809c0
        public void get_attribution(){} // RVA: 0x7ffaa8f76f40
        public void set_attribution(){} // RVA: 0x7ffaa93fc460
        public void get_offlineAnalysisScanStatus(){} // RVA: 0x7ffaaa36dc60
        public void set_offlineAnalysisScanStatus(){} // RVA: 0x7ffaaa36dc70
        public void get_performanceRating(){} // RVA: 0x7ffaa8b68c40
        public void set_performanceRating(){} // RVA: 0x7ffaa8b6fd10
        public void get_styles(){} // RVA: 0x7ffaa8f78450
        public void set_styles(){} // RVA: 0x7ffaa93ff110
        public void get_productId(){} // RVA: 0x7ffaa8f7aa40
        public void set_productId(){} // RVA: 0x7ffaa93f4640
        public void get_publishedListings(){} // RVA: 0x7ffaa8f76810
        public void set_publishedListings(){} // RVA: 0x7ffaa9101830
        public void get_lowestPrice(){} // RVA: 0x7ffaa899d5f0
        public void set_lowestPrice(){} // RVA: 0x7ffaae55fbe0
        public void get_highestPrice(){} // RVA: 0x7ffaa899d660
        public void set_highestPrice(){} // RVA: 0x7ffaae4551b0
        public void get_acknowledgements(){} // RVA: 0x7ffaa8f6e840
        public void set_acknowledgements(){} // RVA: 0x7ffaa93ec470
        public void get_LoadError(){} // RVA: 0x7ffaa8f77ed0
        public void set_LoadError(){} // RVA: 0x7ffaa93f6970
        public void .ctor(){} // RVA: 0x7ffab18809d0
        public void AssignToThisUser(){} // RVA: 0x7ffab1880c90
        public void AssignToThisUserAsFallback(){} // RVA: 0x7ffab1881110
        public void ProcessUnityPackages(){} // RVA: 0x7ffab18818f0
        public void WriteField(){} // RVA: 0x7ffab1882440
        public void CopyDeserializedValuesTo(){} // RVA: 0x7ffab1882470
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffab1880af0
        public void GetPerformanceRatingForPlatform(){} // RVA: 0x7ffab1881590
        public void GetAssetUrl(){} // RVA: 0x7ffab1881610
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab18817b0
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab18817b0
    }

    public class ApiAvatarModeration : ApiModel
    {
        public object _targetAvatarId; // 0x34664BB0, was: <targetAvatarId>k__BackingFiel
        public object moderationType; // 0x17000A63

        // ── Original Methods ──
        public void get_moderationType(){} // RVA: 0x7ffaaa1c2a40
        public void set_moderationType(){} // RVA: 0x7ffaaa1c2a50
        public void get_targetAvatarId(){} // RVA: 0x7ffaa89fa590
        public void set_targetAvatarId(){} // RVA: 0x7ffaa89fa5a0
        public void .ctor(){} // RVA: 0x7ffab1882d30
        public void ShouldCache(){} // RVA: 0x7ffaa8932320
        public void ReadField(){} // RVA: 0x7ffab1882df0
        public void WriteField(){} // RVA: 0x7ffab1883170
        public void SendModeration(){} // RVA: 0x7ffab1883350
        public void DeleteModeration(){} // RVA: 0x7ffab1883590
        public void FetchAllMine(){} // RVA: 0x7ffab1883ab0
        public void FetchList(){} // RVA: 0x7ffab1883b10
        public void ModerationTypeToAPIString(){} // RVA: 0x7ffab1883e00
    }

    public class ApiBadge : ApiModel
    {
        public object _badgeName; // 0x34710030, was: <badgeName>k__BackingField
        public object _hidden; // 0x34710030, was: <hidden>k__BackingField
        public object _assignedBy; // 0x34710030, was: <assignedBy>k__BackingField

        // ── Original Methods ──
        public void get_badgeId(){} // RVA: 0x7ffaa89add50
        public void set_badgeId(){} // RVA: 0x7ffaa89add60
        public void get_showcased(){} // RVA: 0x7ffaa89ae320
        public void set_showcased(){} // RVA: 0x7ffaa89ae330
        public void get_badgeName(){} // RVA: 0x7ffaa8af68f0
        public void set_badgeName(){} // RVA: 0x7ffaa8af19e0
        public void get_badgeDescription(){} // RVA: 0x7ffaa8d1a3b0
        public void set_badgeDescription(){} // RVA: 0x7ffaa8efece0
        public void get_badgeImageUrl(){} // RVA: 0x7ffaa8971010
        public void set_badgeImageUrl(){} // RVA: 0x7ffaa8f7b010
        public void get_hidden(){} // RVA: 0x7ffaa982f2b0
        public void set_hidden(){} // RVA: 0x7ffaa9839000
        public void get_assignedAt(){} // RVA: 0x7ffaa8f75d20
        public void set_assignedAt(){} // RVA: 0x7ffaad836400
        public void get_updatedAt(){} // RVA: 0x7ffaa8f78170
        public void set_updatedAt(){} // RVA: 0x7ffaae1aeb60
        public void get_assignedBy(){} // RVA: 0x7ffaa8f74720
        public void set_assignedBy(){} // RVA: 0x7ffaa8d71dc0
        public void .ctor(){} // RVA: 0x7ffab1884270
    }

    public class ApiCache : Object
    {
        public object expiryQueue; // 0x3166AC20

        // ── Original Methods ──
        public void DefaultTimeProvider(){} // RVA: 0x7ffab1884440
        public void get_Count(){} // RVA: 0x7ffab18844f0
        public void get_NextExpiryTTL(){} // RVA: 0x7ffab18846c0
        public void Fetch(){} // RVA: 0x7ffaa864a690
        public void Save(){} // RVA: 0x7ffab18849b0
        public void Invalidate(){} // RVA: 0x7ffab1884e20
        public void CleanupTask(){} // RVA: 0x7ffab18850d0
        public void Cleanup(){} // RVA: 0x7ffab1885110
        public void InvalidateFileIfVersionUnknown(){} // RVA: 0x7ffab1885610
        public void Clear(){} // RVA: 0x7ffab18857c0
        public void .cctor(){} // RVA: 0x7ffab1885a40
    }

    public class ApiCacheObject
    {
        // ── Original Methods ──
        public void ShouldCache(){} // RVA: 0x7ffaa864a040
        public void Clone(){} // RVA: 0x7ffaa86491d0
        public void set_ExpiryTime(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void GetLifeSpan(){} // RVA: 0x7ffaa865dbc0
    }

    public class ApiCampaignAnonymizationStatus : ApiModel
    {
        // ── Original Methods ──
        public void get_isAnonymized(){} // RVA: 0x7ffaa89fa570
        public void set_isAnonymized(){} // RVA: 0x7ffaa89fa580
        public void get_anonymizedName(){} // RVA: 0x7ffaa89fa590
        public void set_anonymizedName(){} // RVA: 0x7ffaa89fa5a0
        public void .ctor(){} // RVA: 0x7ffab1887420
    }

    public class ApiCampaignContributor : ApiModel
    {
        public object _giftCount; // 0x34226EC0, was: <giftCount>k__BackingField

        // ── Original Methods ──
        public void get_userId(){} // RVA: 0x7ffaa89add50
        public void set_userId(){} // RVA: 0x7ffaa89add60
        public void get_displayName(){} // RVA: 0x7ffaa89fa590
        public void set_displayName(){} // RVA: 0x7ffaa89fa5a0
        public void get_giftCount(){} // RVA: 0x7ffaa9fb1a70
        public void set_giftCount(){} // RVA: 0x7ffaa9fb1a60
        public void get_isAnonymized(){} // RVA: 0x7ffaa8dfe510
        public void set_isAnonymized(){} // RVA: 0x7ffaa8e00810
        public void get_isSelf(){} // RVA: 0x7ffaa8df82d0
        public void set_isSelf(){} // RVA: 0x7ffaa8dfa590
        public void .ctor(){} // RVA: 0x7ffab1887470
    }

    public class ApiCampaignReward : ApiModel
    {
        public object _progression; // 0x34227450, was: <progression>k__BackingField

        // ── Original Methods ──
        public void get_isUnlocked(){} // RVA: 0x7ffaa89fa570
        public void set_isUnlocked(){} // RVA: 0x7ffaa89fa580
        public void get_imageUrl(){} // RVA: 0x7ffaa89fa590
        public void set_imageUrl(){} // RVA: 0x7ffaa89fa5a0
        public void get_progression(){} // RVA: 0x7ffaa8af68f0
        public void set_progression(){} // RVA: 0x7ffaa8af19e0
        public void .ctor(){} // RVA: 0x7ffab1887380
    }

    public class ApiCertificateVerifier : CertificateHandler
    {
        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffab18874c0
        public void .ctor(){} // RVA: 0x7ffaaf6b48b0
        public void Initialize(){} // RVA: 0x7ffab1887520
        public void TestPublicKey(){} // RVA: 0x7ffab1887620
        public void IsValid(){} // RVA: 0x7ffab18878b0
        public void ValidateCertificate(){} // RVA: 0x7ffab1887af0
        public void .cctor(){} // RVA: 0x7ffab1887cb0
    }

    public class ApiContainer : Object
    {
        public object _passedValidation; // 0x30CE2570, was: <PassedValidation>k__BackingFi
        public object _data; // 0x30CE2570, was: <Data>k__BackingField
        public object responseError; // 0x30CE2570
        public object OnSuccess; // 0x30CE2570

        // ── Original Methods ──
        public void get_Cookies(){} // RVA: 0x7ffaa894d380
        public void set_Cookies(){} // RVA: 0x7ffaa8933e30
        public void get_Populated(){} // RVA: 0x7ffaa894d4e0
        public void set_Populated(){} // RVA: 0x7ffaa894d4f0
        public void get_PassedValidation(){} // RVA: 0x7ffaa8c53420
        public void set_PassedValidation(){} // RVA: 0x7ffaa8f41f20
        public void get_Code(){} // RVA: 0x7ffaa9e5ac10
        public void set_Code(){} // RVA: 0x7ffaa9e6a2e0
        public void get_Text(){} // RVA: 0x7ffaa89600c0
        public void set_Text(){} // RVA: 0x7ffaa89600d0
        public void get_Data(){} // RVA: 0x7ffaa8960130
        public void set_Data(){} // RVA: 0x7ffaa8933e90
        public void get_DataTimestamp(){} // RVA: 0x7ffaa9672970
        public void set_DataTimestamp(){} // RVA: 0x7ffaaa150900
        public void get_CreatedAt(){} // RVA: 0x7ffaa8bf45b0
        public void set_CreatedAt(){} // RVA: 0x7ffaa8bf45c0
        public void get_Error(){} // RVA: 0x7ffab18e98e0
        public void set_Error(){} // RVA: 0x7ffab18e9910
        public void get_Model(){} // RVA: 0x7ffaa89ad730
        public void set_Model(){} // RVA: 0x7ffaa89ad740
        public void .ctor(){} // RVA: 0x7ffab18e9c70
        public void setFromContainer(){} // RVA: 0x7ffab18e9d40
        public void Validate(){} // RVA: 0x7ffab18e9f50
        public void OnComplete(){} // RVA: 0x7ffab18ea150
        // ── Binary Analysis Named ──
        public void GetErrorMessage(){} // RVA: 0x7ffab18e9fa0
    }

    public class ApiContentModel`1 : ApiModel
    {
        public object ListCacheTime; // 0x30BEB0B0
        public object _name; // 0x30BEB0B0, was: <name>k__BackingField
        public object _authorId; // 0x30BEB0B0, was: <authorId>k__BackingField
        public object _tags; // 0x30BEB0B0, was: <tags>k__BackingField
        public object _releaseStatus; // 0x30BEB0B0, was: <releaseStatus>k__BackingField
        public object _unityVersion; // 0x30BEB0B0, was: <unityVersion>k__BackingField
        public object _VERSION; // 0x319AA9A0
        public object SingleRecordCacheTime; // 0x319AA9A0
        public object _imageUrl; // 0x319AA9A0, was: <imageUrl>k__BackingField
        public object _assetUrl; // 0x319AA9A0, was: <assetUrl>k__BackingField

        // ── Original Methods ──
        public void get_VERSION(){} // RVA: 0x7ffaa8648dd0
        public void ShouldCache(){} // RVA: 0x7ffaa864a040
        public void get_name(){} // RVA: 0x7ffaa86491d0
        public void set_name(){} // RVA: 0x7ffaa8660d80
        public void get_imageUrl(){} // RVA: 0x7ffaa86491d0
        public void set_imageUrl(){} // RVA: 0x7ffaa8660d80
        public void get_authorName(){} // RVA: 0x7ffaa86491d0
        public void set_authorName(){} // RVA: 0x7ffaa8660d80
        public void get_authorId(){} // RVA: 0x7ffaa86491d0
        public void set_authorId(){} // RVA: 0x7ffaa8660d80
        public void get_assetUrl(){} // RVA: 0x7ffaa86491d0
        public void set_assetUrl(){} // RVA: 0x7ffaa8660d80
        public void get_description(){} // RVA: 0x7ffaa86491d0
        public void set_description(){} // RVA: 0x7ffaa8660d80
        public void get_tags(){} // RVA: 0x7ffaa86491d0
        public void set_tags(){} // RVA: 0x7ffaa8660d80
        public void get_thumbnailImageUrl(){} // RVA: 0x7ffaa86491d0
        public void set_thumbnailImageUrl(){} // RVA: 0x7ffaa8660d80
        public void get_version(){} // RVA: 0x7ffaa8649ca0
        public void set_version(){} // RVA: 0x7ffaa8661210
        public void get_releaseStatus(){} // RVA: 0x7ffaa86491d0
        public void set_releaseStatus(){} // RVA: 0x7ffaa8660d80
        public void get_featured(){} // RVA: 0x7ffaa864a040
        public void set_featured(){} // RVA: 0x7ffaa86613a0
        public void get_unityPackageUpdated(){} // RVA: 0x7ffaa864a040
        public void set_unityPackageUpdated(){} // RVA: 0x7ffaa86613a0
        public void get_unityVersion(){} // RVA: 0x7ffaa86491d0
        public void set_unityVersion(){} // RVA: 0x7ffaa8660d80
        public void get_apiVersion(){} // RVA: 0x7ffaa8649ca0
        public void set_apiVersion(){} // RVA: 0x7ffaa8661210
        public void get_platform(){} // RVA: 0x7ffaa86491d0
        public void set_platform(){} // RVA: 0x7ffaa8660d80
        public void get_assetVersion(){} // RVA: 0x7ffaa86491d0
        public void set_assetVersion(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void ReadField(){} // RVA: 0x7ffaa864d540
        public void FetchList(){} // RVA: 0x7ffaa887e5c0
        public void AddLocal(){} // RVA: 0x7ffaa887e5c0
        public void IsLocalById(){} // RVA: 0x7ffaa864a120
        public void get_IsLocal(){} // RVA: 0x7ffaa864a040
        public void Save(){} // RVA: 0x7ffaa8669e70
        public void SaveReleaseStatus(){} // RVA: 0x7ffaa8669e70
        public void HasTag(){} // RVA: 0x7ffaa864a2a0
        public void AddTag(){} // RVA: 0x7ffaa864a2a0
        public void RemoveTag(){} // RVA: 0x7ffaa864a2a0
        public void UpdateVersionAndPlatform(){} // RVA: 0x7ffaa8660cc0
        public void MakeRequestEndpoint(){}
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetLifeSpan(){} // RVA: 0x7ffaa865dbc0
        public void Get(){} // RVA: 0x7ffaa887e5c0
        public void GetAssetUrl(){} // RVA: 0x7ffaa86491d0
    }

    public class ApiContentModel`1 : ApiModel
    {
        public object ListCacheTime; // 0x319AA9A0
        public object _name; // 0x319AA9A0, was: <name>k__BackingField
        public object _authorId; // 0x319AA9A0, was: <authorId>k__BackingField
        public object _tags; // 0x319AA9A0, was: <tags>k__BackingField
        public object _releaseStatus; // 0x319AA9A0, was: <releaseStatus>k__BackingField
        public object _unityVersion; // 0x319AA9A0, was: <unityVersion>k__BackingField
        public object performanceRatings; // 0x3198ADE0
        public object _impostorUnityVersion; // 0x3198ADE0, was: <impostorUnityVersion>k__Backi
        public object _updated_at; // 0x3198ADE0, was: <updated_at>k__BackingField

        // ── Original Methods ──
        public void get_VERSION(){} // RVA: 0x7ffaabc500d0
        public void ShouldCache(){} // RVA: 0x7ffaabc50400
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_imageUrl(){} // RVA: 0x7ffaa89fa590
        public void set_imageUrl(){} // RVA: 0x7ffaa89fa5a0
        public void get_authorName(){} // RVA: 0x7ffaa8af68f0
        public void set_authorName(){} // RVA: 0x7ffaa8af19e0
        public void get_authorId(){} // RVA: 0x7ffaa8d1a3b0
        public void set_authorId(){} // RVA: 0x7ffaa8efece0
        public void get_assetUrl(){} // RVA: 0x7ffaa8971010
        public void set_assetUrl(){} // RVA: 0x7ffaa8f7b010
        public void get_description(){} // RVA: 0x7ffaa8d1b980
        public void set_description(){} // RVA: 0x7ffaa8f7b070
        public void get_tags(){} // RVA: 0x7ffaa8f75d20
        public void set_tags(){} // RVA: 0x7ffaa8f7b0d0
        public void get_thumbnailImageUrl(){} // RVA: 0x7ffaa8f78170
        public void set_thumbnailImageUrl(){} // RVA: 0x7ffaa8f7b130
        public void get_version(){} // RVA: 0x7ffaa9325970
        public void set_version(){} // RVA: 0x7ffaa932b8c0
        public void get_releaseStatus(){} // RVA: 0x7ffaa899d040
        public void set_releaseStatus(){} // RVA: 0x7ffaa899d050
        public void get_featured(){} // RVA: 0x7ffaa9c12640
        public void set_featured(){} // RVA: 0x7ffaa9c14170
        public void get_unityPackageUpdated(){} // RVA: 0x7ffaabc50470
        public void set_unityPackageUpdated(){} // RVA: 0x7ffaabc50480
        public void get_unityVersion(){} // RVA: 0x7ffaa899d120
        public void set_unityVersion(){} // RVA: 0x7ffaa899d130
        public void get_apiVersion(){} // RVA: 0x7ffaa906c660
        public void set_apiVersion(){} // RVA: 0x7ffaabc50490
        public void get_platform(){} // RVA: 0x7ffaa8a4f100
        public void set_platform(){} // RVA: 0x7ffaa8a4f110
        public void get_assetVersion(){} // RVA: 0x7ffaabc504a0
        public void set_assetVersion(){} // RVA: 0x7ffaabc50550
        public void .ctor(){} // RVA: 0x7ffaabc505e0
        public void ReadField(){} // RVA: 0x7ffaabc506b0
        public void FetchList(){} // RVA: 0x7ffaabc50fc0
        public void AddLocal(){} // RVA: 0x7ffaabc52bd0
        public void IsLocalById(){} // RVA: 0x7ffaabc52d00
        public void get_IsLocal(){} // RVA: 0x7ffaabc52e00
        public void Save(){} // RVA: 0x7ffaabc52ee0
        public void SaveReleaseStatus(){} // RVA: 0x7ffaabc52f60
        public void HasTag(){} // RVA: 0x7ffaabc534a0
        public void AddTag(){} // RVA: 0x7ffaabc53510
        public void RemoveTag(){} // RVA: 0x7ffaabc535b0
        public void UpdateVersionAndPlatform(){} // RVA: 0x7ffaabc53710
        public void MakeRequestEndpoint(){} // RVA: 0x7ffaabc538a0
        public void .cctor(){} // RVA: 0x7ffaabc538d0
        // ── Binary Analysis Named ──
        public void GetLifeSpan(){} // RVA: 0x7ffaabc50460
        public void Get(){} // RVA: 0x7ffaabc50880
        public void GetAssetUrl(){} // RVA: 0x7ffaa8971010
    }

    public class ApiContentModel`1 : ApiModel
    {
        public object ListCacheTime; // 0x34766830
        public object _name; // 0x34766830, was: <name>k__BackingField
        public object _authorId; // 0x34766830, was: <authorId>k__BackingField
        public object _tags; // 0x34766830, was: <tags>k__BackingField
        public object _releaseStatus; // 0x34766830, was: <releaseStatus>k__BackingField
        public object _unityVersion; // 0x34766830, was: <unityVersion>k__BackingField
        public object __created_at; // 0x3474A6C0, was: <_created_at>k__BackingField
        public object _spawnType; // 0x3474A6C0, was: <spawnType>k__BackingField
        public object PropsEndpoint; // 0x3474A6C0

        // ── Original Methods ──
        public void get_VERSION(){} // RVA: 0x7ffaabc500d0
        public void ShouldCache(){} // RVA: 0x7ffaabc50400
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_imageUrl(){} // RVA: 0x7ffaa89fa590
        public void set_imageUrl(){} // RVA: 0x7ffaa89fa5a0
        public void get_authorName(){} // RVA: 0x7ffaa8af68f0
        public void set_authorName(){} // RVA: 0x7ffaa8af19e0
        public void get_authorId(){} // RVA: 0x7ffaa8d1a3b0
        public void set_authorId(){} // RVA: 0x7ffaa8efece0
        public void get_assetUrl(){} // RVA: 0x7ffaa8971010
        public void set_assetUrl(){} // RVA: 0x7ffaa8f7b010
        public void get_description(){} // RVA: 0x7ffaa8d1b980
        public void set_description(){} // RVA: 0x7ffaa8f7b070
        public void get_tags(){} // RVA: 0x7ffaa8f75d20
        public void set_tags(){} // RVA: 0x7ffaa8f7b0d0
        public void get_thumbnailImageUrl(){} // RVA: 0x7ffaa8f78170
        public void set_thumbnailImageUrl(){} // RVA: 0x7ffaa8f7b130
        public void get_version(){} // RVA: 0x7ffaa9325970
        public void set_version(){} // RVA: 0x7ffaa932b8c0
        public void get_releaseStatus(){} // RVA: 0x7ffaa899d040
        public void set_releaseStatus(){} // RVA: 0x7ffaa899d050
        public void get_featured(){} // RVA: 0x7ffaa9c12640
        public void set_featured(){} // RVA: 0x7ffaa9c14170
        public void get_unityPackageUpdated(){} // RVA: 0x7ffaabc50470
        public void set_unityPackageUpdated(){} // RVA: 0x7ffaabc50480
        public void get_unityVersion(){} // RVA: 0x7ffaa899d120
        public void set_unityVersion(){} // RVA: 0x7ffaa899d130
        public void get_apiVersion(){} // RVA: 0x7ffaa906c660
        public void set_apiVersion(){} // RVA: 0x7ffaabc50490
        public void get_platform(){} // RVA: 0x7ffaa8a4f100
        public void set_platform(){} // RVA: 0x7ffaa8a4f110
        public void get_assetVersion(){} // RVA: 0x7ffaabc504a0
        public void set_assetVersion(){} // RVA: 0x7ffaabc50550
        public void .ctor(){} // RVA: 0x7ffaabc505e0
        public void ReadField(){} // RVA: 0x7ffaabc506b0
        public void FetchList(){} // RVA: 0x7ffaabc50fc0
        public void AddLocal(){} // RVA: 0x7ffaabc52bd0
        public void IsLocalById(){} // RVA: 0x7ffaabc52d00
        public void get_IsLocal(){} // RVA: 0x7ffaabc52e00
        public void Save(){} // RVA: 0x7ffaabc52ee0
        public void SaveReleaseStatus(){} // RVA: 0x7ffaabc52f60
        public void HasTag(){} // RVA: 0x7ffaabc534a0
        public void AddTag(){} // RVA: 0x7ffaabc53510
        public void RemoveTag(){} // RVA: 0x7ffaabc535b0
        public void UpdateVersionAndPlatform(){} // RVA: 0x7ffaabc53710
        public void MakeRequestEndpoint(){} // RVA: 0x7ffaabc538a0
        public void .cctor(){} // RVA: 0x7ffaabc538d0
        // ── Binary Analysis Named ──
        public void GetLifeSpan(){} // RVA: 0x7ffaabc50460
        public void Get(){} // RVA: 0x7ffaabc50880
        public void GetAssetUrl(){} // RVA: 0x7ffaa8971010
    }

    public class ApiDictContainer : ApiContainer
    {
        public object _requiredFields; // 0x30CE2390, was: <requiredFields>k__BackingFiel

        // ── Original Methods ──
        public void get_cacheLifetime(){} // RVA: 0x7ffaa8a42e10
        public void set_cacheLifetime(){} // RVA: 0x7ffaa9165910
        public void get_ExpiryTime(){} // RVA: 0x7ffaab9e9f20
        public void set_ExpiryTime(){} // RVA: 0x7ffaab9ea390
        public void get_requiredFields(){} // RVA: 0x7ffaa8af68f0
        public void set_requiredFields(){} // RVA: 0x7ffaa8af19e0
        public void get_ResponseDictionary(){} // RVA: 0x7ffab18e8590
        public void .ctor(){} // RVA: 0x7ffab18e8770
        public void .ctor(){} // RVA: 0x7ffab18e8770
        public void Validate(){} // RVA: 0x7ffab18e87e0
        public void ShouldCache(){} // RVA: 0x7ffab18e8b30
        public void ShouldClearOnLevelLoad(){} // RVA: 0x7ffaa8932320
        public void Clone(){} // RVA: 0x7ffab18e8b40
        public void .cctor(){} // RVA: 0x7ffab18e8bc0
        public void <Validate>b__17_0(){} // RVA: 0x7ffab18e8c90
        // ── Binary Analysis Named ──
        public void GetLifeSpan(){} // RVA: 0x7ffaa8a42e10
    }

    public class ApiDroneSkin : ApiModel
    {
        public object _viewfinderAssetBundleId; // 0x34710700, was: <viewfinderAssetBundleId>k__Ba

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_assetBundleId(){} // RVA: 0x7ffaa89fa590
        public void set_assetBundleId(){} // RVA: 0x7ffaa89fa5a0
        public void get_viewfinderAssetBundleId(){} // RVA: 0x7ffaa8af68f0
        public void set_viewfinderAssetBundleId(){} // RVA: 0x7ffaa8af19e0
        public void .ctor(){} // RVA: 0x7ffab1887f00
    }

    public class ApiEconomyStore : ApiModel
    {
        public object _worldId; // 0x34710C90, was: <WorldId>k__BackingField
        public object _displayName; // 0x34710C90, was: <DisplayName>k__BackingField
        public object _listings; // 0x34710C90, was: <Listings>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1887f50
        public void get_SellerId(){} // RVA: 0x7ffaa89add50
        public void set_SellerId(){} // RVA: 0x7ffaa89add60
        public void get_SellerDisplayName(){} // RVA: 0x7ffaa89fa590
        public void set_SellerDisplayName(){} // RVA: 0x7ffaa89fa5a0
        public void get_WorldId(){} // RVA: 0x7ffaa8af68f0
        public void set_WorldId(){} // RVA: 0x7ffaa8af19e0
        public void get_GroupId(){} // RVA: 0x7ffaa8d1a3b0
        public void set_GroupId(){} // RVA: 0x7ffaa8efece0
        public void get_StoreStatus(){} // RVA: 0x7ffaa9221d50
        public void set_StoreStatus(){} // RVA: 0x7ffaa92217c0
        public void get_DisplayName(){} // RVA: 0x7ffaa8d1b980
        public void set_DisplayName(){} // RVA: 0x7ffaa8f7b070
        public void get_Description(){} // RVA: 0x7ffaa8f75d20
        public void set_Description(){} // RVA: 0x7ffaa8f7b0d0
        public void get_Tags(){} // RVA: 0x7ffaa8f78170
        public void set_Tags(){} // RVA: 0x7ffaa8f7b130
        public void get_Listings(){} // RVA: 0x7ffaa8f74720
        public void set_Listings(){} // RVA: 0x7ffaa8d71dc0
        public void get_ListingIDs(){} // RVA: 0x7ffaa899d040
        public void set_ListingIDs(){} // RVA: 0x7ffaa899d050
        public void get_IsGroupStore(){} // RVA: 0x7ffab1887fa0
        public void get_IsWorldStore(){} // RVA: 0x7ffab1887fc0
        public void ReadField(){} // RVA: 0x7ffab1887fe0
        public void WriteField(){} // RVA: 0x7ffab1888220
        public void FetchStore(){} // RVA: 0x7ffab1888380
    }

    public class ApiFile : ApiModel
    {
        public object _ownerId; // 0x344270E0, was: <ownerId>k__BackingField
        public object _versions; // 0x344270E0, was: <versions>k__BackingField

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_order(){} // RVA: 0x7ffaa89fa590
        public void set_order(){} // RVA: 0x7ffaaa5ccbf0
        public void get_ownerId(){} // RVA: 0x7ffaa8af68f0
        public void set_ownerId(){} // RVA: 0x7ffaa8af19e0
        public void get_mimeType(){} // RVA: 0x7ffaa8d1a3b0
        public void set_mimeType(){} // RVA: 0x7ffaa8efece0
        public void get_extension(){} // RVA: 0x7ffaa8971010
        public void set_extension(){} // RVA: 0x7ffaa8f7b010
        public void get_versions(){} // RVA: 0x7ffaa8d1b980
        public void set_versions(){} // RVA: 0x7ffaa8f7b070
        public void get_IsInitialized(){} // RVA: 0x7ffaa8dcb5d0
        public void set_IsInitialized(){} // RVA: 0x7ffaa8dc7aa0
        public void get_IsPendingInit(){} // RVA: 0x7ffaa8dcb3b0
        public void set_IsPendingInit(){} // RVA: 0x7ffaae377890
        public void .ctor(){} // RVA: 0x7ffab188aeb0
        public void .ctor(){} // RVA: 0x7ffab188aeb0
        public void .ctor(){} // RVA: 0x7ffab188aeb0
        public void Create(){} // RVA: 0x7ffab188b040
        public void Refresh(){} // RVA: 0x7ffab188b1e0
        public void ParseFileIdFromFileAPIUrl(){} // RVA: 0x7ffab188b890
        public void TryParseFileIdFromFileAPIUrl(){} // RVA: 0x7ffab188b930
        public void TryParseFileVersionFromFileAPIUrl(){} // RVA: 0x7ffab188b970
        public void TryParseFileIdAndVersionFromFileAPIUrl(){} // RVA: 0x7ffab188b9c0
        public void TryParseFileIdAndVersionAndVariantSuffixFromFileAPIUrl(){} // RVA: 0x7ffab188ba00
        public void TryParseFileIdAndVersionAndVariantFromFileAPIUrl(){} // RVA: 0x7ffab188ba80
        public void TryParseFileIdAndVersionAndVariantFromFileAPIUrl(){} // RVA: 0x7ffab188ba80
        public void PerformRegexMatch(){} // RVA: 0x7ffab188bab0
        public void TryGetImageAPIUrlFromFileAPIUrl(){} // RVA: 0x7ffab188c2b0
        public void OnDownloadFileCompleted(){} // RVA: 0x7ffab188c810
        public void ToString(){} // RVA: 0x7ffab188cf40
        public void ToStringBrief(){} // RVA: 0x7ffaa8b17b80
        public void CreateNewVersion(){} // RVA: 0x7ffab188d160
        public void HasExistingVersion(){} // RVA: 0x7ffab188d8a0
        public void HasExistingOrPendingVersion(){} // RVA: 0x7ffab188d960
        public void DeleteVersion(){} // RVA: 0x7ffab188dd10
        public void DeleteLatestVersion(){} // RVA: 0x7ffab188e000
        public void IsLatestVersionQueued(){} // RVA: 0x7ffab188f070
        public void HasQueuedOperation(){} // RVA: 0x7ffab188f140
        public void IsWaitingForUpload(){} // RVA: 0x7ffab188f2e0
        public void IsInErrorState(){} // RVA: 0x7ffab188f3b0
        public void StartSimpleUpload(){} // RVA: 0x7ffab188f480
        public void StartMultipartUpload(){} // RVA: 0x7ffab188f810
        public void FinishUpload(){} // RVA: 0x7ffab188fbf0
        public void PutSimpleFileToURL(){} // RVA: 0x7ffab1890080
        public void PutMultipartDataToURL(){} // RVA: 0x7ffab1890b60
        // ── Binary Analysis Named ──
        public void DownloadFile(){} // RVA: 0x7ffab188b220
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab188cf10
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab188cf10
        public void GetLatestVersionNumber(){} // RVA: 0x7ffab188da40
        public void GetLatestCompleteVersionNumber(){} // RVA: 0x7ffab188daa0
        public void GetVersion(){} // RVA: 0x7ffab188dbd0
        public void GetLatestCompleteVersion(){} // RVA: 0x7ffab188dc70
        public void GetLatestVersion(){} // RVA: 0x7ffab188dca0
        public void DownloadSignature(){} // RVA: 0x7ffab188e3e0
        public void GetFileURL(){} // RVA: 0x7ffab188e480
        public void GetFileURL(){} // RVA: 0x7ffab188e480
        public void GetFileRawURL(){} // RVA: 0x7ffab188e510
        public void GetFileRawURL(){} // RVA: 0x7ffab188e510
        public void GetDeltaURL(){} // RVA: 0x7ffab188e5c0
        public void GetDeltaURL(){} // RVA: 0x7ffab188e5c0
        public void GetDeltaRawURL(){} // RVA: 0x7ffab188e650
        public void GetDeltaRawURL(){} // RVA: 0x7ffab188e650
        public void GetSignatureURL(){} // RVA: 0x7ffab188e700
        public void GetSignatureURL(){} // RVA: 0x7ffab188e700
        public void GetSignatureRawURL(){} // RVA: 0x7ffab188e790
        public void GetSignatureRawURL(){} // RVA: 0x7ffab188e790
        public void GetFileApiURL(){} // RVA: 0x7ffab188e9f0
        public void GetFileApiURL(){} // RVA: 0x7ffab188e9f0
        public void GetFileVariantApiURL(){} // RVA: 0x7ffab188eb30
        public void GetFileMD5(){} // RVA: 0x7ffab188efc0
        public void GetFileMD5(){} // RVA: 0x7ffab188efc0
        public void GetFileDescriptor(){} // RVA: 0x7ffab188f040
        public void GetUploadStatus(){} // RVA: 0x7ffab188fe80
    }

    public class ApiGroupGalleryImage : ApiModel
    {
        public object _galleryId; // 0x34711E20, was: <galleryId>k__BackingField
        public object _createdAt; // 0x34711E20, was: <createdAt>k__BackingField
        public object _approvedByUserId; // 0x34711E20, was: <approvedByUserId>k__BackingFi

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_groupId(){} // RVA: 0x7ffaa89fa590
        public void set_groupId(){} // RVA: 0x7ffaa89fa5a0
        public void get_galleryId(){} // RVA: 0x7ffaa8af68f0
        public void set_galleryId(){} // RVA: 0x7ffaa8af19e0
        public void get_fileId(){} // RVA: 0x7ffaa8d1a3b0
        public void set_fileId(){} // RVA: 0x7ffaa8efece0
        public void get_imageUrl(){} // RVA: 0x7ffaa8971010
        public void set_imageUrl(){} // RVA: 0x7ffaa8f7b010
        public void get_createdAt(){} // RVA: 0x7ffaa8d1b980
        public void set_createdAt(){} // RVA: 0x7ffaa9132e80
        public void get_approved(){} // RVA: 0x7ffaa8dcb5d0
        public void set_approved(){} // RVA: 0x7ffaa8dc7aa0
        public void get_approvedAt(){} // RVA: 0x7ffaa8f78170
        public void set_approvedAt(){} // RVA: 0x7ffaae1aeb60
        public void get_approvedByUserId(){} // RVA: 0x7ffaa8f74720
        public void set_approvedByUserId(){} // RVA: 0x7ffaa8d71dc0
        public void get_submittedByUserId(){} // RVA: 0x7ffaa899d040
        public void set_submittedByUserId(){} // RVA: 0x7ffaa899d050
        public void get_file(){} // RVA: 0x7ffaa899d0b0
        public void set_file(){} // RVA: 0x7ffaa899d0c0
        public void .ctor(){} // RVA: 0x7ffab193a870
    }

    public class ApiImage : ApiFile
    {
        // ── Original Methods ──
        public void ShouldCache(){} // RVA: 0x7ffaa8932320
        public void FetchList(){} // RVA: 0x7ffab1893360
        public void UploadImage(){} // RVA: 0x7ffab1893ec0
        public void .ctor(){} // RVA: 0x7ffab18942c0
    }

    public class ApiInfoPushSystem : ApiModel
    {
        public object _releaseStatus; // 0x34712E20, was: <releaseStatus>k__BackingField
        public object _priority; // 0x34712E20, was: <priority>k__BackingField
        public object _createdAt; // 0x34712E20, was: <createdAt>k__BackingField
        public object _originalManifestId; // 0x34712E20, was: <originalManifestId>k__Backing

        // ── Original Methods ──
        public void get_isEnabled(){} // RVA: 0x7ffaa89fa570
        public void set_isEnabled(){} // RVA: 0x7ffaa89fa580
        public void get_releaseStatus(){} // RVA: 0x7ffaa89fa590
        public void set_releaseStatus(){} // RVA: 0x7ffaa89fa5a0
        public void get_tags(){} // RVA: 0x7ffaa8af68f0
        public void set_tags(){} // RVA: 0x7ffaa8af19e0
        public void get_requireClientTags(){} // RVA: 0x7ffaa8d1a3b0
        public void set_requireClientTags(){} // RVA: 0x7ffaa8efece0
        public void get_priority(){} // RVA: 0x7ffaa9221d50
        public void set_priority(){} // RVA: 0x7ffaa92217c0
        public void get_startDate(){} // RVA: 0x7ffaa8d1b980
        public void set_startDate(){} // RVA: 0x7ffaa9132e80
        public void get_endDate(){} // RVA: 0x7ffaa8f75d20
        public void set_endDate(){} // RVA: 0x7ffaad836400
        public void get_createdAt(){} // RVA: 0x7ffaa8f78170
        public void set_createdAt(){} // RVA: 0x7ffaae1aeb60
        public void get_updatedAt(){} // RVA: 0x7ffaa8f74720
        public void set_updatedAt(){} // RVA: 0x7ffaa9fee770
        public void get_hash(){} // RVA: 0x7ffaa899d040
        public void set_hash(){} // RVA: 0x7ffaa899d050
        public void get_originalManifestId(){} // RVA: 0x7ffaa899d0b0
        public void set_originalManifestId(){} // RVA: 0x7ffaa899d0c0
        public void get_data(){} // RVA: 0x7ffaa899d120
        public void set_data(){} // RVA: 0x7ffaa899d130
        public void .ctor(){} // RVA: 0x7ffab1894560
        public void FetchList(){} // RVA: 0x7ffab1894620
        public void Save(){} // RVA: 0x7ffab1894e90
        // ── Binary Analysis Named ──
        public void GetLifeSpan(){} // RVA: 0x7ffaabc50460
    }

    public class ApiInventoryBundle : ApiModel
    {
        // ── Original Methods ──
        public void get_inventoryItemsToInstantiate(){} // RVA: 0x7ffaa89add50
        public void set_inventoryItemsToInstantiate(){} // RVA: 0x7ffaa89add60
        public void get_notificationDetails(){} // RVA: 0x7ffaa89fa590
        public void set_notificationDetails(){} // RVA: 0x7ffaa89fa5a0
        public void .ctor(){} // RVA: 0x7ffab1895830
    }

    public class ApiInventoryBundleDrop : ApiModel
    {
        public object _authorId; // 0x34560030, was: <authorId>k__BackingField
        public object _startDropDate; // 0x34560030, was: <startDropDate>k__BackingField
        public object _status; // 0x34560030, was: <status>k__BackingField
        public object _updated_at; // 0x34560030, was: <updated_at>k__BackingField

        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_authorId(){} // RVA: 0x7ffaa89fa590
        public void set_authorId(){} // RVA: 0x7ffaa89fa5a0
        public void get_targetGroup(){} // RVA: 0x7ffaa8af68f0
        public void set_targetGroup(){} // RVA: 0x7ffaa8af19e0
        public void get_templateIds(){} // RVA: 0x7ffaa8d1a3b0
        public void set_templateIds(){} // RVA: 0x7ffaa8efece0
        public void get_startDropDate(){} // RVA: 0x7ffaa8971010
        public void set_startDropDate(){} // RVA: 0x7ffaaa5564d0
        public void get_endDropDate(){} // RVA: 0x7ffaa8d1b980
        public void set_endDropDate(){} // RVA: 0x7ffaa9132e80
        public void get_dropExpiryDate(){} // RVA: 0x7ffaa8f75d20
        public void set_dropExpiryDate(){} // RVA: 0x7ffaad836400
        public void get_status(){} // RVA: 0x7ffaa8f78170
        public void set_status(){} // RVA: 0x7ffaa8f7b130
        public void get_tags(){} // RVA: 0x7ffaa8f74720
        public void set_tags(){} // RVA: 0x7ffaa8d71dc0
        public void get_created_at(){} // RVA: 0x7ffaa899d040
        public void set_created_at(){} // RVA: 0x7ffaa9feeaa0
        public void get_updated_at(){} // RVA: 0x7ffaa899d0b0
        public void set_updated_at(){} // RVA: 0x7ffaa9feeab0
        public void get_notificationDetails(){} // RVA: 0x7ffaa899d120
        public void set_notificationDetails(){} // RVA: 0x7ffaa899d130
        public void FetchCurrentlyActiveBundleDrops(){} // RVA: 0x7ffab1895880
        public void .ctor(){} // RVA: 0x7ffab1895cc0
    }

    public class ApiInventoryItem : ApiModel
    {
        public object _name; // 0x30BBA7D0, was: <name>k__BackingField
        public object _attribution; // 0x30BBA7D0, was: <attribution>k__BackingField
        public object _collections; // 0x30BBA7D0, was: <collections>k__BackingField
        public object _firstAncestor; // 0x30BBA7D0, was: <firstAncestor>k__BackingField
        public object _created_at; // 0x30BBA7D0, was: <created_at>k__BackingField
        public object _template_updated_at; // 0x30BBA7D0, was: <template_updated_at>k__Backin
        public object _last_equipped_at; // 0x30BBA7D0, was: <last_equipped_at>k__BackingFi
        public object _quantity; // 0x30BBA7D0, was: <quantity>k__BackingField
        public object _userAttributes; // 0x30BBA7D0, was: <userAttributes>k__BackingFiel
        public object _status; // 0x30BBA7D0, was: <status>k__BackingField
        public object FLAG_USER_GENERATED; // 0x30BBA7D0
        public object FLAG_TRASHABLE; // 0x30BBA7D0
        public object FLAG_EQUIPPABLE; // 0x30BBA7D0
        public object FLAG_PREMIUM; // 0x30BBA7D0
        public object ITEM_TYPE_EMOJI; // 0x30BBA7D0
        public object ITEM_TYPE_DRONE_SKIN; // 0x30BBA7D0
        public object ITEM_TYPE_LOADING_SCREEN; // 0x30BBA7D0
        public object GetStatus; // 0xB419EFA0
        public object IValueTaskSource`1; // 0x330A49E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1895e20
        public void get_templateId(){} // RVA: 0x7ffaa89add50
        public void set_templateId(){} // RVA: 0x7ffaa89add60
        public void get_name(){} // RVA: 0x7ffaa89fa590
        public void set_name(){} // RVA: 0x7ffaa89fa5a0
        public void get_description(){} // RVA: 0x7ffaa8af68f0
        public void set_description(){} // RVA: 0x7ffaa8af19e0
        public void get_imageUrl(){} // RVA: 0x7ffaa8d1a3b0
        public void set_imageUrl(){} // RVA: 0x7ffaa8efece0
        public void get_attribution(){} // RVA: 0x7ffaa8971010
        public void set_attribution(){} // RVA: 0x7ffaa8f7b010
        public void get_flags(){} // RVA: 0x7ffaa8d1b980
        public void set_flags(){} // RVA: 0x7ffaa8f7b070
        public void get_tags(){} // RVA: 0x7ffaa8f75d20
        public void set_tags(){} // RVA: 0x7ffaa8f7b0d0
        public void get_collections(){} // RVA: 0x7ffaa8f78170
        public void set_collections(){} // RVA: 0x7ffaa8f7b130
        public void get_itemType(){} // RVA: 0x7ffaa8f74720
        public void set_itemType(){} // RVA: 0x7ffaa8d71dc0
        public void get_holderId(){} // RVA: 0x7ffaa899d040
        public void set_holderId(){} // RVA: 0x7ffaa899d050
        public void get_firstAncestor(){} // RVA: 0x7ffaa899d0b0
        public void set_firstAncestor(){} // RVA: 0x7ffaa899d0c0
        public void get_firstAncestorHolderId(){} // RVA: 0x7ffaa899d120
        public void set_firstAncestorHolderId(){} // RVA: 0x7ffaa899d130
        public void get_expiryDate(){} // RVA: 0x7ffaa8a8a460
        public void set_expiryDate(){} // RVA: 0x7ffab0cf2590
        public void get_created_at(){} // RVA: 0x7ffaa8a4f100
        public void set_created_at(){} // RVA: 0x7ffaaea8d820
        public void get_updated_at(){} // RVA: 0x7ffaa8f6dbf0
        public void set_updated_at(){} // RVA: 0x7ffab1895ee0
        public void get_template_created_at(){} // RVA: 0x7ffaa89b3900
        public void set_template_created_at(){} // RVA: 0x7ffab1895ef0
        public void get_template_updated_at(){} // RVA: 0x7ffaa89b3970
        public void set_template_updated_at(){} // RVA: 0x7ffaae1ceb90
        public void get_isArchived(){} // RVA: 0x7ffaa89b3ad0
        public void set_isArchived(){} // RVA: 0x7ffaa89b3ae0
        public void get_isSeen(){} // RVA: 0x7ffaa98b1d50
        public void set_isSeen(){} // RVA: 0x7ffaa98c11a0
        public void get_last_equipped_at(){} // RVA: 0x7ffaa8d57210
        public void set_last_equipped_at(){} // RVA: 0x7ffaac120980
        public void get_equipSlots(){} // RVA: 0x7ffaa8f205f0
        public void set_equipSlots(){} // RVA: 0x7ffaa8f20bd0
        public void get_equipSlot(){} // RVA: 0x7ffaa9102670
        public void set_equipSlot(){} // RVA: 0x7ffaa9354440
        public void get_quantity(){} // RVA: 0x7ffaa936f8e0
        public void set_quantity(){} // RVA: 0x7ffaa9fbd7b0
        public void get_quantifiable(){} // RVA: 0x7ffab1895f00
        public void set_quantifiable(){} // RVA: 0x7ffab1895f10
        public void get_defaultAttributes(){} // RVA: 0x7ffaa8de7450
        public void set_defaultAttributes(){} // RVA: 0x7ffaa8de5d60
        public void get_userAttributes(){} // RVA: 0x7ffaa8b68c40
        public void set_userAttributes(){} // RVA: 0x7ffaa8b6fd10
        public void get_validateUserAttributes(){} // RVA: 0x7ffaa8d5b050
        public void set_validateUserAttributes(){} // RVA: 0x7ffaa8d5a940
        public void get_notificationDetails(){} // RVA: 0x7ffaa8f7aa40
        public void set_notificationDetails(){} // RVA: 0x7ffaa93f4640
        public void get_status(){} // RVA: 0x7ffaa8f76810
        public void set_status(){} // RVA: 0x7ffaa9101830
        public void get_metadata(){} // RVA: 0x7ffaa899d5f0
        public void set_metadata(){} // RVA: 0x7ffaa899d600
        public void get_Instantiatable(){} // RVA: 0x7ffab1895f20
        public void get_Consumable(){} // RVA: 0x7ffab1895f90
        public void get_Archivable(){} // RVA: 0x7ffab1896000
        public void get_Trashable(){} // RVA: 0x7ffab1896070
        public void get_Cloneable(){} // RVA: 0x7ffab18960e0
        public void get_Equippable(){} // RVA: 0x7ffab1896150
        public void get_Equipped(){} // RVA: 0x7ffab18961e0
        public void get_IsUserGenerated(){} // RVA: 0x7ffab1896220
        public void get_IsTemplate(){} // RVA: 0x7ffab1896290
        public void FetchList(){} // RVA: 0x7ffab1896c90
        public void Fetch(){} // RVA: 0x7ffab18980e0
        public void Consume(){} // RVA: 0x7ffab1898d30
        public void Consume(){} // RVA: 0x7ffab1898d30
        public void FetchInventoryTemplate(){} // RVA: 0x7ffab18990b0
        public void FetchInventoryTemplateAsync(){} // RVA: 0x7ffab18993e0
        public void FetchUserInventoryItem(){} // RVA: 0x7ffab1899580
        public void Equip(){} // RVA: 0x7ffab18998d0
        public void ClearEquipSlot(){} // RVA: 0x7ffab1899f10
        public void SaveUserAttributes(){} // RVA: 0x7ffab189a200
        public void FetchEquipped(){} // RVA: 0x7ffab189a770
        public void FetchAllTemplates(){} // RVA: 0x7ffab189b2b0
        // ── Binary Analysis Named ──
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab18964e0
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab18964e0
        public void GetModelForMetadataType(){} // RVA: 0x7ffab1896700
        public void SetIsArchived(){} // RVA: 0x7ffab1898410
        public void SetIsSeen(){} // RVA: 0x7ffab18988a0
        public void GetAttributes(){} // RVA: 0x7ffab189ad80
        public void GetDefaultAttributes(){} // RVA: 0x7ffab189b070
    }

    public class ApiInventoryJweToken : ApiModel
    {
        public object ENDPOINT_CLONE_DIRECT; // 0x35CE19F0

        // ── Original Methods ──
        public void get_token(){} // RVA: 0x7ffaa89add50
        public void set_token(){} // RVA: 0x7ffaa89add60
        public void RequestSpawnToken(){} // RVA: 0x7ffab189c9f0
        public void RequestDirectShareToken(){} // RVA: 0x7ffab189cef0
        public void RequestPedestalShareToken(){} // RVA: 0x7ffab189d440
        public void RequestClone(){} // RVA: 0x7ffab189db50
        public void .ctor(){} // RVA: 0x7ffab189e050
    }

    public class ApiLedgerTransaction : ApiModel
    {
        public object _date; // 0x347486A0, was: <Date>k__BackingField
        public object _listingType; // 0x347486A0, was: <ListingType>k__BackingField
        public object _reason; // 0x347486A0, was: <Reason>k__BackingField
        public object _toUserDisplayName; // 0x347486A0, was: <ToUserDisplayName>k__BackingF
        public object _transactionId; // 0x347486A0, was: <TransactionId>k__BackingField
        public object `Ǐf; // 0x3408CB50

        // ── Original Methods ──
        public void get_Amount(){} // RVA: 0x7ffaaa1c2a40
        public void set_Amount(){} // RVA: 0x7ffaaa1c2a50
        public void get_RunningBalance(){} // RVA: 0x7ffaaa1c2a60
        public void set_RunningBalance(){} // RVA: 0x7ffaaa1c2a70
        public void get_Date(){} // RVA: 0x7ffaa89fa590
        public void set_Date(){} // RVA: 0x7ffaaa5ccbf0
        public void get_ListingDisplayName(){} // RVA: 0x7ffaa8af68f0
        public void set_ListingDisplayName(){} // RVA: 0x7ffaa8af19e0
        public void get_ListingID(){} // RVA: 0x7ffaa8d1a3b0
        public void set_ListingID(){} // RVA: 0x7ffaa8efece0
        public void get_ListingType(){} // RVA: 0x7ffaa8971010
        public void set_ListingType(){} // RVA: 0x7ffaa8f7b010
        public void get_Platform(){} // RVA: 0x7ffaa8d1b980
        public void set_Platform(){} // RVA: 0x7ffaa8f7b070
        public void get_PurchaseId(){} // RVA: 0x7ffaa8f75d20
        public void set_PurchaseId(){} // RVA: 0x7ffaa8f7b0d0
        public void get_Reason(){} // RVA: 0x7ffaaa2a7de0
        public void set_Reason(){} // RVA: 0x7ffaaa2a7dd0
        public void get_ReasonLabel(){} // RVA: 0x7ffaa8f74720
        public void set_ReasonLabel(){} // RVA: 0x7ffaa8d71dc0
        public void get_ToUserId(){} // RVA: 0x7ffaa899d040
        public void set_ToUserId(){} // RVA: 0x7ffaa899d050
        public void get_ToUserDisplayName(){} // RVA: 0x7ffaa899d0b0
        public void set_ToUserDisplayName(){} // RVA: 0x7ffaa899d0c0
        public void get_FromUserId(){} // RVA: 0x7ffaa899d120
        public void set_FromUserId(){} // RVA: 0x7ffaa899d130
        public void get_FromUserDisplayName(){} // RVA: 0x7ffaa8a8a460
        public void set_FromUserDisplayName(){} // RVA: 0x7ffaa8a8a470
        public void get_TransactionId(){} // RVA: 0x7ffaa8a4f100
        public void set_TransactionId(){} // RVA: 0x7ffaaea8d820
        public void get_TransactionLineId(){} // RVA: 0x7ffaa8f6dbf0
        public void set_TransactionLineId(){} // RVA: 0x7ffab1895ee0
        public void get_id(){} // RVA: 0x7ffab189e250
        public void .ctor(){} // RVA: 0x7ffab189e2f0
    }

    public class ApiLedgerTransactions : ApiModel
    {
        public object _transactions; // 0x34832D70, was: <Transactions>k__BackingField
        public object GetStatus; // 0xB419EFA0

        // ── Original Methods ──
        public void get_StartDate(){} // RVA: 0x7ffaa89add50
        public void set_StartDate(){} // RVA: 0x7ffaaa5ccc00
        public void get_EndDate(){} // RVA: 0x7ffaa89fa590
        public void set_EndDate(){} // RVA: 0x7ffaaa5ccbf0
        public void get_Transactions(){} // RVA: 0x7ffaa8af68f0
        public void set_Transactions(){} // RVA: 0x7ffaa8af19e0
        public void .ctor(){} // RVA: 0x7ffab189e200
    }

    public class ApiListContainer : ApiContainer
    {
        // ── Original Methods ──
        public void get_ResponseList(){} // RVA: 0x7ffab18e8d00
        public void get_TotalCount(){} // RVA: 0x7ffaa8b645f0
        public void set_TotalCount(){} // RVA: 0x7ffaa8b64600
        public void Validate(){} // RVA: 0x7ffab18e8d70
        public void .ctor(){} // RVA: 0x7ffab18e90f0
    }

    public class ApiLoadingScreen : ApiModel
    {
        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_assetBundleId(){} // RVA: 0x7ffaa89fa590
        public void set_assetBundleId(){} // RVA: 0x7ffaa89fa5a0
        public void .ctor(){} // RVA: 0x7ffab189f7e0
    }

    public class ApiMessage : ApiModel
    {
        public object _slot; // 0x347138B0, was: <slot>k__BackingField
        public object _updatedAt; // 0x347138B0, was: <updatedAt>k__BackingField

        // ── Original Methods ──
        public void get_slot(){} // RVA: 0x7ffaaa1c2a40
        public void set_slot(){} // RVA: 0x7ffaaa1c2a50
        public void get_message(){} // RVA: 0x7ffaa89fa590
        public void set_message(){} // RVA: 0x7ffaa89fa5a0
        public void get_messageType(){} // RVA: 0x7ffaa8af68f0
        public void set_messageType(){} // RVA: 0x7ffaa8af19e0
        public void get_updatedAt(){} // RVA: 0x7ffaa8d1a3b0
        public void set_updatedAt(){} // RVA: 0x7ffaaa5ccbe0
        public void get_remainingCooldownMinutes(){} // RVA: 0x7ffaa9221d50
        public void set_remainingCooldownMinutes(){} // RVA: 0x7ffaa92217c0
        public void get_canBeUpdated(){} // RVA: 0x7ffaa899a520
        public void set_canBeUpdated(){} // RVA: 0x7ffaa899a530
        public void .ctor(){} // RVA: 0x7ffab189f830
        public void FetchMessages(){} // RVA: 0x7ffab189fa00
        public void FetchMessages(){} // RVA: 0x7ffab189fa00
        public void DeleteAllMessages(){} // RVA: 0x7ffab189fea0
        public void DeleteAllMessages(){} // RVA: 0x7ffab189fea0
        public void DeleteMessageInSlot(){} // RVA: 0x7ffab18a0360
        public void DeleteMessageInSlot(){} // RVA: 0x7ffab18a0360
        public void truncatedMessage(){} // RVA: 0x7ffab18a0ee0
        public void ToString(){} // RVA: 0x7ffab18a0f50
        public void .cctor(){} // RVA: 0x7ffab18a1160
        // ── Binary Analysis Named ──
        public void SetMessageInSlot(){} // RVA: 0x7ffab18a08b0
        public void SetMessageInSlot(){} // RVA: 0x7ffab18a08b0
    }

    public class ApiModel : Object
    {
        public object currentRemainingDepth; // 0x30BBAAE0
        public object _expiryTime; // 0x30BBAAE0, was: <ExpiryTime>k__BackingField
        public object _endpoint; // 0x30BBAAE0, was: <Endpoint>k__BackingField
        public object _cacheIdBuilder; // 0x30BBAAE0
        public object _fieldsLockedForNetworkUpdates; // 0x30BBAAE0, was: <FieldsLockedForNetworkUpdates
        public object RESPONSE_FIELDS_HASH_MULTIPLIER; // 0x30BBAAE0
        public object EnumValuesCache; // 0x30BBAAE0
        public object PropertyApiFieldNames; // 0x30BBAAE0
        public object value; // 0x3145E1C8
        public object ITEM_TEMPLATE_ID_PREFIX; // 0x30BBA7D0
        public object _description; // 0x30BBA7D0, was: <description>k__BackingField
        public object _flags; // 0x30BBA7D0, was: <flags>k__BackingField
        public object _itemType; // 0x30BBA7D0, was: <itemType>k__BackingField

        // ── Original Methods ──
        public void get_id(){} // RVA: 0x7ffaa894d380
        public void set_id(){} // RVA: 0x7ffaa8933e30
        public void get_ExpiryTime(){} // RVA: 0x7ffaa8ffff10
        public void set_ExpiryTime(){} // RVA: 0x7ffaa9001710
        public void get_Populated(){} // RVA: 0x7ffaa8b0edb0
        public void set_Populated(){} // RVA: 0x7ffaa96574d0
        public void get_FailedValidation(){} // RVA: 0x7ffaa92971f0
        public void set_FailedValidation(){} // RVA: 0x7ffaa9dde1d0
        public void get_Endpoint(){} // RVA: 0x7ffaa8bfcc80
        public void set_Endpoint(){} // RVA: 0x7ffaa8960890
        public void get_FieldsMissingFromOriginalResponse(){} // RVA: 0x7ffaa89ad730
        public void set_FieldsMissingFromOriginalResponse(){} // RVA: 0x7ffaa89ad740
        public void get_FieldsLockedForNetworkUpdates(){} // RVA: 0x7ffaa89d30e0
        public void set_FieldsLockedForNetworkUpdates(){} // RVA: 0x7ffaa8a8a4d0
        public void ComputeCacheId(){} // RVA: 0x7ffab18a2210
        public void ShouldCache(){} // RVA: 0x7ffab18a2620
        public void .ctor(){} // RVA: 0x7ffab18a2740
        public void .ctor(){} // RVA: 0x7ffab18a2740
        public void .ctor(){} // RVA: 0x7ffab18a2740
        public void Clone(){} // RVA: 0x7ffab18a29d0
        public void Clone(){} // RVA: 0x7ffab18a29d0
        public void Clone(){} // RVA: 0x7ffab18a29d0
        public void Save(){} // RVA: 0x7ffab18a2f20
        public void SaveField(){} // RVA: 0x7ffab18a2f60
        public void Post(){} // RVA: 0x7ffab18a3230
        public void Put(){} // RVA: 0x7ffab18a3270
        public void Fetch(){} // RVA: 0x7ffab18a32b0
        public void PostAsync(){} // RVA: 0x7ffaa887e5c0
        public void PutAsync(){} // RVA: 0x7ffaa887e5c0
        public void FetchAsync(){} // RVA: 0x7ffaa887e5c0
        public void PostOrPut(){} // RVA: 0x7ffab18a3b50
        public void Delete(){} // RVA: 0x7ffab18a5330
        public void DeleteAsync(){} // RVA: 0x7ffab18a55d0
        public void PopulateMissingValuesFrom(){} // RVA: 0x7ffab18a7620
        public void ExtractApiFields(){} // RVA: 0x7ffab18a7ae0
        public void MakeModelContainer(){} // RVA: 0x7ffab18a7ec0
        public void ReadField(){} // RVA: 0x7ffab18a8140
        public void TryReadConvert(){} // RVA: 0x7ffab18a8530
        public void WriteField(){} // RVA: 0x7ffab18a99e0
        public void CopyDeserializedValuesTo(){} // RVA: 0x7ffaa8932320
        public void ParseEnumValue(){} // RVA: 0x7ffaa887e5c0
        public void ParseEnumValue(){} // RVA: 0x7ffaa887e5c0
        public void IsNumber(){} // RVA: 0x7ffab18aaf50
        public void TryWriteConvert(){} // RVA: 0x7ffab18ab3d0
        public void ParseList(){} // RVA: 0x7ffab18ac4e0
        public void ParseDictionary(){} // RVA: 0x7ffab18ac9a0
        public void ParseModel(){} // RVA: 0x7ffab18ad1a0
        public void ParseLocalizableString(){} // RVA: 0x7ffab18ad3f0
        public void SendGetRequest(){} // RVA: 0x7ffab18ad5d0
        public void SendPutRequest(){} // RVA: 0x7ffab18ad880
        public void MakeRequestEndpoint(){} // RVA: 0x7ffab18ad950
        public void get_RequiredProperties(){} // RVA: 0x7ffab18ada00
        public void get_TargetProperties(){} // RVA: 0x7ffab18ae040
        public void FindPropertyName(){} // RVA: 0x7ffab18ae460
        public void FindProperty(){} // RVA: 0x7ffab18ae770
        public void IsAdminWritableOnly(){} // RVA: 0x7ffab18aec60
        public void IsApiWritableOnly(){} // RVA: 0x7ffab18aee50
        public void .cctor(){} // RVA: 0x7ffab18af040
        // ── Binary Analysis Named ──
        public void GetOrPutCachedMissingFieldList(){} // RVA: 0x7ffab18a1670
        public void GetCacheId(){} // RVA: 0x7ffab18a1f50
        public void GetLifeSpan(){} // RVA: 0x7ffab18a2660
        public void Get(){} // RVA: 0x7ffab18a32e0
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab18a68c0
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab18a68c0
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab18a68c0
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab18a68c0
        public void GetCreateFromJsonMethodInfo(){} // RVA: 0x7ffab18aa960
        public void DoubleCast(){} // RVA: 0x7ffab18ab000
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void ValidModelData(){} // RVA: 0x7ffaa864a040
        public void Validate(){}
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void .ctor(){} // RVA: 0x7ffaabc53de0
        public void ValidModelData(){} // RVA: 0x7ffaabc53e30
        public void Validate(){} // RVA: 0x7ffaabc53f00
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa86491d0
        public void set_ResponseModels(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void Validate(){}
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Original Methods ──
        public void get_ResponseModels(){} // RVA: 0x7ffaa89add50
        public void set_ResponseModels(){} // RVA: 0x7ffaa89add60
        public void .ctor(){} // RVA: 0x7ffaabc540b0
        public void Validate(){} // RVA: 0x7ffaabc54130
    }

    public class ApiModeration : ApiModel
    {
        public object _moderatorUserId; // 0x346645F0, was: <moderatorUserId>k__BackingFie
        public object _targetDisplayName; // 0x346645F0, was: <targetDisplayName>k__BackingF
        public object _created; // 0x346645F0, was: <created>k__BackingField
        public object _isPermanent; // 0x346645F0, was: <isPermanent>k__BackingField
        public object Z; // 0x3024ED20

        // ── Original Methods ──
        public void get_moderationType(){} // RVA: 0x7ffaaa1c2a40
        public void set_moderationType(){} // RVA: 0x7ffaaa1c2a50
        public void get_moderatorUserId(){} // RVA: 0x7ffaa89fa590
        public void set_moderatorUserId(){} // RVA: 0x7ffaa89fa5a0
        public void get_moderatorDisplayName(){} // RVA: 0x7ffaa8af68f0
        public void set_moderatorDisplayName(){} // RVA: 0x7ffaa8af19e0
        public void get_targetUserId(){} // RVA: 0x7ffaa8d1a3b0
        public void set_targetUserId(){} // RVA: 0x7ffaa8efece0
        public void get_targetDisplayName(){} // RVA: 0x7ffaa8971010
        public void set_targetDisplayName(){} // RVA: 0x7ffaa8f7b010
        public void get_reasonMessage(){} // RVA: 0x7ffaa8d1b980
        public void set_reasonMessage(){} // RVA: 0x7ffaa8f7b070
        public void get_details(){} // RVA: 0x7ffaa8f75d20
        public void set_details(){} // RVA: 0x7ffaa8f7b0d0
        public void get_created(){} // RVA: 0x7ffaa8f78170
        public void set_created(){} // RVA: 0x7ffaae1aeb60
        public void get_expires(){} // RVA: 0x7ffaa8f74720
        public void set_expires(){} // RVA: 0x7ffaa9fee770
        public void get_isPermanent(){} // RVA: 0x7ffaa9c12640
        public void set_isPermanent(){} // RVA: 0x7ffaa9c14170
        public void get_worldId(){} // RVA: 0x7ffaa899d120
        public void set_worldId(){} // RVA: 0x7ffaa899d130
        public void get_instanceId(){} // RVA: 0x7ffaa8a8a460
        public void set_instanceId(){} // RVA: 0x7ffaa8a8a470
        public void .ctor(){} // RVA: 0x7ffab18b0740
        public void .ctor(){} // RVA: 0x7ffab18b0740
        public void ShouldCache(){} // RVA: 0x7ffaa8932320
        public void ReadField(){} // RVA: 0x7ffab18b07e0
        public void WriteField(){} // RVA: 0x7ffab18b0c60
        public void SendModeration(){} // RVA: 0x7ffab18b0e90
        public void SendVoteKick(){} // RVA: 0x7ffab18b1250
        public void DeleteModeration(){} // RVA: 0x7ffab18b1580
        public void LocalFetchAll(){} // RVA: 0x7ffab18b17a0
        public void ModerationTimeRangeToString(){} // RVA: 0x7ffab18b1aa0
        public void ContestModeration(){} // RVA: 0x7ffab18b1b40
    }

    public class ApiMutualFriend : ApiModel
    {
        public object _statusDescription; // 0x34749440, was: <statusDescription>k__BackingF
        public object _currentAvatarTags; // 0x34749440, was: <currentAvatarTags>k__BackingF
        public object _world; // 0x34749440, was: <world>k__BackingField
        public object _travelingToWorld; // 0x34749440, was: <travelingToWorld>k__BackingFi
        public object _groups; // 0x34749440, was: <groups>k__BackingField

        // ── Original Methods ──
        public void get_id(){} // RVA: 0x7ffaa894d380
        public void set_id(){} // RVA: 0x7ffaa8933e30
        public void get_displayName(){} // RVA: 0x7ffaa89add50
        public void set_displayName(){} // RVA: 0x7ffaa89add60
        public void get_status(){} // RVA: 0x7ffaa89fa590
        public void set_status(){} // RVA: 0x7ffaa89fa5a0
        public void get_statusDescription(){} // RVA: 0x7ffaa8af68f0
        public void set_statusDescription(){} // RVA: 0x7ffaa8af19e0
        public void get_currentAvatarImageUrl(){} // RVA: 0x7ffaa8d1a3b0
        public void set_currentAvatarImageUrl(){} // RVA: 0x7ffaa8efece0
        public void get_avatarThumbnail(){} // RVA: 0x7ffaa8971010
        public void set_avatarThumbnail(){} // RVA: 0x7ffaa8f7b010
        public void get_currentAvatarTags(){} // RVA: 0x7ffaa8d1b980
        public void set_currentAvatarTags(){} // RVA: 0x7ffaa8f7b070
        public void get_profilePicOverride(){} // RVA: 0x7ffaa8f75d20
        public void set_profilePicOverride(){} // RVA: 0x7ffaa8f7b0d0
        public void get_userIcon(){} // RVA: 0x7ffaa8f78170
        public void set_userIcon(){} // RVA: 0x7ffaa8f7b130
        public void get_world(){} // RVA: 0x7ffaa8f74720
        public void set_world(){} // RVA: 0x7ffaa8d71dc0
        public void get_instance(){} // RVA: 0x7ffaa899d040
        public void set_instance(){} // RVA: 0x7ffaa899d050
        public void get_instanceType(){} // RVA: 0x7ffaa899d0b0
        public void set_instanceType(){} // RVA: 0x7ffaa899d0c0
        public void get_travelingToWorld(){} // RVA: 0x7ffaa899d120
        public void set_travelingToWorld(){} // RVA: 0x7ffaa899d130
        public void get_travelingToInstance(){} // RVA: 0x7ffaa8a8a460
        public void set_travelingToInstance(){} // RVA: 0x7ffaa8a8a470
        public void get_platform(){} // RVA: 0x7ffaa8a4f100
        public void set_platform(){} // RVA: 0x7ffaa8a4f110
        public void get_groups(){} // RVA: 0x7ffaa8f6dbf0
        public void set_groups(){} // RVA: 0x7ffaa89b38a0
        public void get_profilePicImageUrl(){} // RVA: 0x7ffab1940a10
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x7ffab1940a30
        public void FetchMutualFriendsAsync(){} // RVA: 0x7ffab1940a60
        public void .ctor(){} // RVA: 0x7ffab1940c30
    }

    public class ApiMutualGroup : ApiModel
    {
        public object _ownerId; // 0x34749890, was: <ownerId>k__BackingField
        public object _shortCode; // 0x34749890, was: <shortCode>k__BackingField
        public object _bannerUrl; // 0x34749890, was: <bannerUrl>k__BackingField
        public object _lastPostCreatedAt; // 0x34749890, was: <lastPostCreatedAt>k__BackingF

        // ── Original Methods ──
        public void get_id(){} // RVA: 0x7ffaa894d380
        public void set_id(){} // RVA: 0x7ffaa8933e30
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_discriminator(){} // RVA: 0x7ffaa89fa590
        public void set_discriminator(){} // RVA: 0x7ffaa89fa5a0
        public void get_ownerId(){} // RVA: 0x7ffaa8af68f0
        public void set_ownerId(){} // RVA: 0x7ffaa8af19e0
        public void get_privacy(){} // RVA: 0x7ffaa8d1a3b0
        public void set_privacy(){} // RVA: 0x7ffaa8efece0
        public void get_memberCount(){} // RVA: 0x7ffaa9221d50
        public void set_memberCount(){} // RVA: 0x7ffaa92217c0
        public void get_shortCode(){} // RVA: 0x7ffaa8d1b980
        public void set_shortCode(){} // RVA: 0x7ffaa8f7b070
        public void get_description(){} // RVA: 0x7ffaa8f75d20
        public void set_description(){} // RVA: 0x7ffaa8f7b0d0
        public void get_bannerId(){} // RVA: 0x7ffaa8f78170
        public void set_bannerId(){} // RVA: 0x7ffaa8f7b130
        public void get_bannerUrl(){} // RVA: 0x7ffaa8f74720
        public void set_bannerUrl(){} // RVA: 0x7ffaa8d71dc0
        public void get_iconId(){} // RVA: 0x7ffaa899d040
        public void set_iconId(){} // RVA: 0x7ffaa899d050
        public void get_iconUrl(){} // RVA: 0x7ffaa899d0b0
        public void set_iconUrl(){} // RVA: 0x7ffaa899d0c0
        public void get_lastPostCreatedAt(){} // RVA: 0x7ffaa899d120
        public void set_lastPostCreatedAt(){} // RVA: 0x7ffaa899d130
        public void FetchMutualGroupsAsync(){} // RVA: 0x7ffab1941910
        public void .ctor(){} // RVA: 0x7ffab1941ae0
    }

    public class ApiPlayerModeration : ApiModel
    {
        public object _targetUserId; // 0x34664030, was: <targetUserId>k__BackingField
        public object _sourceDisplayName; // 0x34664030, was: <sourceDisplayName>k__BackingF

        // ── Original Methods ──
        public void get_moderationType(){} // RVA: 0x7ffaaa1c2a40
        public void set_moderationType(){} // RVA: 0x7ffaaa1c2a50
        public void get_targetUserId(){} // RVA: 0x7ffaa89fa590
        public void set_targetUserId(){} // RVA: 0x7ffaa89fa5a0
        public void get_targetDisplayName(){} // RVA: 0x7ffaa8af68f0
        public void set_targetDisplayName(){} // RVA: 0x7ffaa8af19e0
        public void get_sourceUserId(){} // RVA: 0x7ffaa8d1a3b0
        public void set_sourceUserId(){} // RVA: 0x7ffaa8efece0
        public void get_sourceDisplayName(){} // RVA: 0x7ffaa8971010
        public void set_sourceDisplayName(){} // RVA: 0x7ffaa8f7b010
        public void get_created(){} // RVA: 0x7ffaa8d1b980
        public void set_created(){} // RVA: 0x7ffaa9132e80
        public void .ctor(){} // RVA: 0x7ffab18b2880
        public void CreateRemovalModeration(){} // RVA: 0x7ffab18b2940
        public void ShouldCache(){} // RVA: 0x7ffaa8932320
        public void ReadField(){} // RVA: 0x7ffab18b2a00
        public void WriteField(){} // RVA: 0x7ffab18b2c00
        public void SendModeration(){} // RVA: 0x7ffab18b2de0
        public void DeleteModeration(){} // RVA: 0x7ffab18b3020
        public void FetchAllAgainstMe(){} // RVA: 0x7ffab18b35e0
        public void FetchAllMine(){} // RVA: 0x7ffab18b3630
        public void FetchList(){} // RVA: 0x7ffab18b3680
        public void ModerationTypeToAPIString(){} // RVA: 0x7ffab18b3960
    }

    public class ApiPortalSkin : ApiModel
    {
        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_assetBundleId(){} // RVA: 0x7ffaa89fa590
        public void set_assetBundleId(){} // RVA: 0x7ffaa89fa5a0
        public void .ctor(){} // RVA: 0x7ffab18b3e30
    }

    public class ApiPrint : ApiModel
    {
        public object _authorName; // 0x3474A3B0, was: <authorName>k__BackingField
        public object _ownerId; // 0x3474A3B0, was: <ownerId>k__BackingField
        public object _createdAt; // 0x3474A3B0, was: <createdAt>k__BackingField

        // ── Original Methods ──
        public void get_note(){} // RVA: 0x7ffaa89add50
        public void set_note(){} // RVA: 0x7ffaa89add60
        public void get_authorId(){} // RVA: 0x7ffaa89fa590
        public void set_authorId(){} // RVA: 0x7ffaa89fa5a0
        public void get_authorName(){} // RVA: 0x7ffaa8af68f0
        public void set_authorName(){} // RVA: 0x7ffaa8af19e0
        public void get_worldId(){} // RVA: 0x7ffaa8d1a3b0
        public void set_worldId(){} // RVA: 0x7ffaa8efece0
        public void get_worldName(){} // RVA: 0x7ffaa8971010
        public void set_worldName(){} // RVA: 0x7ffaa8f7b010
        public void get_ownerId(){} // RVA: 0x7ffaa8d1b980
        public void set_ownerId(){} // RVA: 0x7ffaa8f7b070
        public void get_timestamp(){} // RVA: 0x7ffaa8f75d20
        public void set_timestamp(){} // RVA: 0x7ffaad836400
        public void get_files(){} // RVA: 0x7ffaa8f78170
        public void set_files(){} // RVA: 0x7ffaa8f7b130
        public void get_createdAt(){} // RVA: 0x7ffaa8f74720
        public void set_createdAt(){} // RVA: 0x7ffaa9fee770
        public void .ctor(){} // RVA: 0x7ffab18b3e80
        public void Upload(){} // RVA: 0x7ffab18b3ff0
        public void UpdatePrint(){} // RVA: 0x7ffab18b4510
        // ── Binary Analysis Named ──
        public void GetFileURL(){} // RVA: 0x7ffab18b3f80
        public void GetImageURL(){} // RVA: 0x7ffab18b3fa0
        public void GetPrints(){} // RVA: 0x7ffab18b4970
        public void GetPrint(){} // RVA: 0x7ffab18b4eb0
    }

    public class ApiProduct : ApiModel
    {
        public object _updatedAt; // 0x34782450, was: <UpdatedAt>k__BackingField
        public object _sellerDisplayName; // 0x34782450, was: <SellerDisplayName>k__BackingF
        public object _subtitle; // 0x34782450, was: <Subtitle>k__BackingField
        public object _licenseId; // 0x34782450, was: <LicenseId>k__BackingField
        public object _untilDate; // 0x34782450, was: <UntilDate>k__BackingField
        public object _parentListings; // 0x34782450, was: <ParentListings>k__BackingFiel
        public object _groupId; // 0x34782450, was: <GroupId>k__BackingField
        public object _groupAccessRemove; // 0x34782450, was: <GroupAccessRemove>k__BackingF
        public object _inventoryItemQuantity; // 0x34782450, was: <InventoryItemQuantity>k__Back
        public object _listingType; // 0x34782450, was: <ListingType>k__BackingField
        public object _hydratedProducts; // 0x34782450, was: <HydratedProducts>k__BackingFi
        public object _price; // 0x34782450, was: <Price>k__BackingField
        public object _collaboratorUserId; // 0x34782450, was: <CollaboratorUserId>k__Backing
        public object _storeIDs; // 0x34782450, was: <StoreIDs>k__BackingField
        public object _archived; // 0x34782450, was: <Archived>k__BackingField
        public object _stackable; // 0x34782450, was: <Stackable>k__BackingField
        public object _buyerRefundable; // 0x34782450, was: <BuyerRefundable>k__BackingFie

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab18ddec0
        public void get_Type(){} // RVA: 0x7ffaaa1c2a40
        public void set_Type(){} // RVA: 0x7ffaaa1c2a50
        public void get_CreatedAt(){} // RVA: 0x7ffaa89fa590
        public void set_CreatedAt(){} // RVA: 0x7ffaaa5ccbf0
        public void get_UpdatedAt(){} // RVA: 0x7ffaa8af68f0
        public void set_UpdatedAt(){} // RVA: 0x7ffaadc676b0
        public void get_SellerId(){} // RVA: 0x7ffaa8d1a3b0
        public void set_SellerId(){} // RVA: 0x7ffaa8efece0
        public void get_AvatarId(){} // RVA: 0x7ffaa8971010
        public void set_AvatarId(){} // RVA: 0x7ffaa8f7b010
        public void get_SellerDisplayName(){} // RVA: 0x7ffaa8d1b980
        public void set_SellerDisplayName(){} // RVA: 0x7ffaa8f7b070
        public void get_Name(){} // RVA: 0x7ffaa8f75d20
        public void set_Name(){} // RVA: 0x7ffaa8f7b0d0
        public void get_Description(){} // RVA: 0x7ffaa8f78170
        public void set_Description(){} // RVA: 0x7ffaa8f7b130
        public void get_Subtitle(){} // RVA: 0x7ffaa8f74720
        public void set_Subtitle(){} // RVA: 0x7ffaa8d71dc0
        public void get_ProductImageId(){} // RVA: 0x7ffaa899d040
        public void set_ProductImageId(){} // RVA: 0x7ffaa899d050
        public void get_ProductImageUrl(){} // RVA: 0x7ffab18ddf80
        public void get_attribution(){} // RVA: 0x7ffaa899d0b0
        public void set_attribution(){} // RVA: 0x7ffaa899d0c0
        public void get_LicenseId(){} // RVA: 0x7ffaa899d120
        public void set_LicenseId(){} // RVA: 0x7ffaa899d130
        public void get_Tags(){} // RVA: 0x7ffaa8a8a460
        public void set_Tags(){} // RVA: 0x7ffaa8a8a470
        public void get_SoldByVrc(){} // RVA: 0x7ffaa8dfbd60
        public void set_SoldByVrc(){} // RVA: 0x7ffaa9d744d0
        public void get_UntilDate(){} // RVA: 0x7ffaa8f6dbf0
        public void set_UntilDate(){} // RVA: 0x7ffab1895ee0
        public void get_PurchaseToken(){} // RVA: 0x7ffaa89b3900
        public void set_PurchaseToken(){} // RVA: 0x7ffaa89b3910
        public void get_IsVoided(){} // RVA: 0x7ffaa9a11140
        public void set_IsVoided(){} // RVA: 0x7ffaaa3a4030
        public void get_ParentListings(){} // RVA: 0x7ffaa899d2a0
        public void set_ParentListings(){} // RVA: 0x7ffaa899d2b0
        public void get_ProductTypeLabel(){} // RVA: 0x7ffaa8d57210
        public void set_ProductTypeLabel(){} // RVA: 0x7ffaa8ecd8e0
        public void get_Quantifiable(){} // RVA: 0x7ffaa96c9090
        public void set_Quantifiable(){} // RVA: 0x7ffaa96c8b10
        public void get_GroupId(){} // RVA: 0x7ffaa9102670
        public void set_GroupId(){} // RVA: 0x7ffaa9354440
        public void get_GroupRoleId(){} // RVA: 0x7ffaa8f76f40
        public void set_GroupRoleId(){} // RVA: 0x7ffaa93fc460
        public void get_GroupAccess(){} // RVA: 0x7ffaa9ace660
        public void set_GroupAccess(){} // RVA: 0x7ffaa9abbc70
        public void get_GroupAccessRemove(){} // RVA: 0x7ffaa9acc110
        public void set_GroupAccessRemove(){} // RVA: 0x7ffaa9ab7b20
        public void get_InventoryItemTemplateId(){} // RVA: 0x7ffaa8b68c40
        public void set_InventoryItemTemplateId(){} // RVA: 0x7ffaa8b6fd10
        public void get_InventoryItemType(){} // RVA: 0x7ffaa8f78450
        public void set_InventoryItemType(){} // RVA: 0x7ffaa93ff110
        public void get_InventoryItemQuantity(){} // RVA: 0x7ffaa8de6c30
        public void set_InventoryItemQuantity(){} // RVA: 0x7ffaaef7ed60
        public void get_AssetDisabled(){} // RVA: 0x7ffab18ddff0
        public void set_AssetDisabled(){} // RVA: 0x7ffab18de000
        public void get_ListingID(){} // RVA: 0x7ffaa8f76810
        public void set_ListingID(){} // RVA: 0x7ffaa9101830
        public void get_ListingType(){} // RVA: 0x7ffab18de010
        public void set_ListingType(){} // RVA: 0x7ffab18de020
        public void get_Products(){} // RVA: 0x7ffaa899d660
        public void set_Products(){} // RVA: 0x7ffaa899d670
        public void get_ProductIDs(){} // RVA: 0x7ffaa8f6e840
        public void set_ProductIDs(){} // RVA: 0x7ffaa93ec470
        public void get_HydratedProducts(){} // RVA: 0x7ffaa8f77ed0
        public void set_HydratedProducts(){} // RVA: 0x7ffaa93f6970
        public void get_Active(){} // RVA: 0x7ffaae432bd0
        public void set_Active(){} // RVA: 0x7ffaae432be0
        public void get_SubscriberExclusive(){} // RVA: 0x7ffaae432bf0
        public void set_SubscriberExclusive(){} // RVA: 0x7ffaae432c00
        public void get_Price(){} // RVA: 0x7ffab18de030
        public void set_Price(){} // RVA: 0x7ffab18de040
        public void get_VrcPlusDiscountPrice(){} // RVA: 0x7ffaaf69ca70
        public void set_VrcPlusDiscountPrice(){} // RVA: 0x7ffaaf69ca80
        public void get_AvailableToPurchaseUntilDate(){} // RVA: 0x7ffaa8d916d0
        public void set_AvailableToPurchaseUntilDate(){} // RVA: 0x7ffab18de050
        public void get_CollaboratorUserId(){} // RVA: 0x7ffaa8d92160
        public void set_CollaboratorUserId(){} // RVA: 0x7ffaa93d3040
        public void get_CollaboratorUserDisplayName(){} // RVA: 0x7ffaa8f74160
        public void set_CollaboratorUserDisplayName(){} // RVA: 0x7ffaa8f2e920
        public void get_Stock(){} // RVA: 0x7ffaa8f6f0b0
        public void set_Stock(){} // RVA: 0x7ffaae68b430
        public void get_StoreIDs(){} // RVA: 0x7ffaa8f77bc0
        public void set_StoreIDs(){} // RVA: 0x7ffaa93f5420
        public void get_Duration(){} // RVA: 0x7ffaaf067c70
        public void set_Duration(){} // RVA: 0x7ffaaf067c80
        public void get_DurationType(){} // RVA: 0x7ffaa8b007d0
        public void set_DurationType(){} // RVA: 0x7ffaa8ddb8a0
        public void get_Archived(){} // RVA: 0x7ffab18de060
        public void set_Archived(){} // RVA: 0x7ffab18de070
        public void get_Permanent(){} // RVA: 0x7ffab18de080
        public void set_Permanent(){} // RVA: 0x7ffab18de090
        public void get_Instant(){} // RVA: 0x7ffab18de0a0
        public void set_Instant(){} // RVA: 0x7ffab18de0b0
        public void get_Stackable(){} // RVA: 0x7ffab18de0c0
        public void set_Stackable(){} // RVA: 0x7ffab18de0d0
        public void get_Recurrable(){} // RVA: 0x7ffab18de0e0
        public void set_Recurrable(){} // RVA: 0x7ffab18de0f0
        public void get_Refundable(){} // RVA: 0x7ffab18de100
        public void set_Refundable(){} // RVA: 0x7ffab18de110
        public void get_BuyerRefundable(){} // RVA: 0x7ffab18de120
        public void set_BuyerRefundable(){} // RVA: 0x7ffab18de130
        public void get_ContextPreventsPurchase(){} // RVA: 0x7ffab18de140
        public void set_ContextPreventsPurchase(){} // RVA: 0x7ffab18de150
        public void get_ListingVariants(){} // RVA: 0x7ffaa8f6f0e0
        public void set_ListingVariants(){} // RVA: 0x7ffaa93ff2c0
        public void Purchase(){} // RVA: 0x7ffab18de160
        public void ReadField(){} // RVA: 0x7ffab18df360
        public void WriteField(){} // RVA: 0x7ffab18df780
        public void FetchListing(){} // RVA: 0x7ffab18dfc20
        public void FetchFullListing(){} // RVA: 0x7ffab18e0130
        public void FetchOwnListings(){} // RVA: 0x7ffab18e0640
        public void FetchOwnProducts(){} // RVA: 0x7ffab18e0b10
    }

    public class ApiProductPurchaseStatus : ApiModel
    {
        public object _expiry; // 0x347830B0, was: <Expiry>k__BackingField

        // ── Original Methods ──
        public void get_ProductId(){} // RVA: 0x7ffaa89add50
        public void set_ProductId(){} // RVA: 0x7ffaa89add60
        public void get_LicenseId(){} // RVA: 0x7ffaa89fa590
        public void set_LicenseId(){} // RVA: 0x7ffaa89fa5a0
        public void get_Expiry(){} // RVA: 0x7ffaa8af68f0
        public void set_Expiry(){} // RVA: 0x7ffaadc676b0
        public void .ctor(){} // RVA: 0x7ffab18e23e0
        // ── Binary Analysis Named ──
        public void GetProductsPurchaseStatus(){} // RVA: 0x7ffab18e1e10
    }

    public class ApiProductVariant : ApiModel
    {
        public object _unitPriceTokens; // 0x34783500, was: <UnitPriceTokens>k__BackingFie

        // ── Original Methods ──
        public void get_ListingVariantID(){} // RVA: 0x7ffaa89add50
        public void set_ListingVariantID(){} // RVA: 0x7ffaa89add60
        public void get_Quantity(){} // RVA: 0x7ffaa95c5a20
        public void set_Quantity(){} // RVA: 0x7ffaa8ac7670
        public void get_UnitPriceTokens(){} // RVA: 0x7ffaa9e03940
        public void set_UnitPriceTokens(){} // RVA: 0x7ffaaa2bddd0
        public void get_NonRefundable(){} // RVA: 0x7ffaa8e00670
        public void set_NonRefundable(){} // RVA: 0x7ffaa97510e0
        public void get_EffectiveFrom(){} // RVA: 0x7ffaa8d1a3b0
        public void set_EffectiveFrom(){} // RVA: 0x7ffaaa5ccbe0
        public void .ctor(){} // RVA: 0x7ffab18e24f0
    }

    public class ApiProp : ApiContentModel`1
    {
        public object _unityPackages; // 0x3474A6C0, was: <unityPackages>k__BackingField
        public object _scaleWithAvatar; // 0x3474A6C0, was: <scaleWithAvatar>k__BackingFie

        // ── Original Methods ──
        public void get__created_at(){} // RVA: 0x7ffaa8f6dbf0
        public void set__created_at(){} // RVA: 0x7ffab1895ee0
        public void get__updated_at(){} // RVA: 0x7ffaa89b3900
        public void set__updated_at(){} // RVA: 0x7ffab1895ef0
        public void get_unityPackages(){} // RVA: 0x7ffaa89b3970
        public void set_unityPackages(){} // RVA: 0x7ffaa89b3980
        public void get_spawnType(){} // RVA: 0x7ffaaba8f7a0
        public void set_spawnType(){} // RVA: 0x7ffaae432840
        public void get_worldPlacementMask(){} // RVA: 0x7ffaac120940
        public void set_worldPlacementMask(){} // RVA: 0x7ffaac120950
        public void get_scaleWithAvatar(){} // RVA: 0x7ffaa96c75d0
        public void set_scaleWithAvatar(){} // RVA: 0x7ffaaf1d18c0
        public void get_BundleSignature(){} // RVA: 0x7ffaa8f205f0
        public void set_BundleSignature(){} // RVA: 0x7ffaa8f20bd0
        public void .ctor(){} // RVA: 0x7ffab18e2540
        public void ProcessUnityPackages(){} // RVA: 0x7ffab18e2780
        public void WriteField(){} // RVA: 0x7ffab18e2e40
        public void CopyDeserializedValuesTo(){} // RVA: 0x7ffab18e2f00
        // ── Binary Analysis Named ──
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab18e26a0
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab18e26a0
        public void GetProp(){} // RVA: 0x7ffab18e3100
    }

    public class ApiPropItemMetadata : ApiModel
    {
        // ── Original Methods ──
        public void get_propId(){} // RVA: 0x7ffaa89add50
        public void set_propId(){} // RVA: 0x7ffaa89add60
        public void get_worldPlacementMask(){} // RVA: 0x7ffaa95c5a20
        public void set_worldPlacementMask(){} // RVA: 0x7ffaa8ac7670
        public void .ctor(){} // RVA: 0x7ffab18e35a0
    }

    public class ApiPurchase : ApiModel
    {
        public object _listingImageId; // 0x34783950, was: <ListingImageId>k__BackingFiel
        public object _sellerId; // 0x34783950, was: <SellerId>k__BackingField
        public object _buyerDisplayName; // 0x34783950, was: <BuyerDisplayName>k__BackingFi
        public object _price; // 0x34783950, was: <Price>k__BackingField
        public object _durationType; // 0x34783950, was: <DurationType>k__BackingField
        public object _purchaseEndDate; // 0x34783950, was: <PurchaseEndDate>k__BackingFie
        public object _products; // 0x34783950, was: <Products>k__BackingField
        public object _purchaseToken; // 0x34783950, was: <PurchaseToken>k__BackingField
        public object _purchaseUnitPrice; // 0x34783950, was: <PurchaseUnitPrice>k__BackingF
        public object _stackDuration; // 0x34783950, was: <StackDuration>k__BackingField
        public object _stackQuantityConsumed; // 0x34783950, was: <StackQuantityConsumed>k__Back
        public object _stackQuantityUnconsumedAtPurchase; // 0x34783950, was: <StackQuantityUnconsumedAtPurc
        public object _listingCurrentlyAvailable; // 0x34783950, was: <ListingCurrentlyAvailable>k__
        public object _updatedAtDate; // 0x34783950, was: <UpdatedAtDate>k__BackingField
        public object _isRecur; // 0x34783950, was: <IsRecur>k__BackingField
        public object _purchaseStacks; // 0x34783950, was: <PurchaseStacks>k__BackingFiel
        public object _purchaseValue; // 0x34783950, was: <PurchaseValue>k__BackingField
        public object _sellerIP; // 0x34783950, was: <SellerIP>k__BackingField
        public object _stackVrcFee; // 0x34783950, was: <StackVrcFee>k__BackingField
        public object _voidedByAdmin; // 0x34783950, was: <VoidedByAdmin>k__BackingField
        public object _purchaseTiliaFeeDrift; // 0x34783950, was: <PurchaseTiliaFeeDrift>k__Back
        public object _refundedBy; // 0x34783950, was: <RefundedBy>k__BackingField
        public object _refundedStacks; // 0x34783950, was: <RefundedStacks>k__BackingFiel
        public object _refundTiliaTransactionId; // 0x34783950, was: <RefundTiliaTransactionId>k__B
        public object _refundTokenSources; // 0x34783950, was: <RefundTokenSources>k__Backing
        public object _voidedCompletely; // 0x34783950, was: <VoidedCompletely>k__BackingFi
        public object _listingId; // 0xB41F4950, was: ÏÌÎÍÏÍÍÏÍÏÏÎÍÍÍÎÎÍÏÎÎÎÌ
        public object _listingDisplayName; // 0xB2F08F70, was: ÎÎÍÎÏÌÌÎÍÌÍÏÎÍÏÍÎÏÎÎÌÌÎ
        public object `Ǐf; // 0x340CE110

        // ── Original Methods ──
        public void get_ListingId(){} // RVA: 0x7ffaa89add50
        public void set_ListingId(){} // RVA: 0x7ffaa89add60
        public void get_ListingDisplayName(){} // RVA: 0x7ffaa89fa590
        public void set_ListingDisplayName(){} // RVA: 0x7ffaa89fa5a0
        public void get_ListingImageId(){} // RVA: 0x7ffaa8af68f0
        public void set_ListingImageId(){} // RVA: 0x7ffaa8af19e0
        public void get_ListingImageUrl(){} // RVA: 0x7ffab18e3690
        public void get_ListingType(){} // RVA: 0x7ffaa8fa2c90
        public void set_ListingType(){} // RVA: 0x7ffaa8fa3510
        public void get_ListingVariantId(){} // RVA: 0x7ffaa8971010
        public void set_ListingVariantId(){} // RVA: 0x7ffaa8f7b010
        public void get_SellerId(){} // RVA: 0x7ffaa8d1b980
        public void set_SellerId(){} // RVA: 0x7ffaa8f7b070
        public void get_SellerDisplayName(){} // RVA: 0x7ffaa8f75d20
        public void set_SellerDisplayName(){} // RVA: 0x7ffaa8f7b0d0
        public void get_BuyerId(){} // RVA: 0x7ffaa8f78170
        public void set_BuyerId(){} // RVA: 0x7ffaa8f7b130
        public void get_BuyerDisplayName(){} // RVA: 0x7ffaa8f74720
        public void set_BuyerDisplayName(){} // RVA: 0x7ffaa8d71dc0
        public void get_ReceiverId(){} // RVA: 0x7ffaa899d040
        public void set_ReceiverId(){} // RVA: 0x7ffaa899d050
        public void get_ReceiverDisplayName(){} // RVA: 0x7ffaa899d0b0
        public void set_ReceiverDisplayName(){} // RVA: 0x7ffaa899d0c0
        public void get_id(){} // RVA: 0x7ffaa894d380
        public void set_id(){} // RVA: 0x7ffaa8933e30
        public void get_Price(){} // RVA: 0x7ffaa8b6fed0
        public void set_Price(){} // RVA: 0x7ffaa8b69300
        public void get_Quantity(){} // RVA: 0x7ffaaa1db140
        public void set_Quantity(){} // RVA: 0x7ffaae360fb0
        public void get_Duration(){} // RVA: 0x7ffaa906c660
        public void set_Duration(){} // RVA: 0x7ffaabc50490
        public void get_DurationType(){} // RVA: 0x7ffaa9d2b2b0
        public void set_DurationType(){} // RVA: 0x7ffaae2e83d0
        public void get_PurchaseDate(){} // RVA: 0x7ffaa8a4f100
        public void set_PurchaseDate(){} // RVA: 0x7ffaaea8d820
        public void get_PurchaseStartDate(){} // RVA: 0x7ffaa8f6dbf0
        public void set_PurchaseStartDate(){} // RVA: 0x7ffab1895ee0
        public void get_PurchaseEndDate(){} // RVA: 0x7ffaa89b3900
        public void set_PurchaseEndDate(){} // RVA: 0x7ffab1895ef0
        public void get_PurchaseActive(){} // RVA: 0x7ffaa9a11140
        public void set_PurchaseActive(){} // RVA: 0x7ffaaa3a4030
        public void get_PurchaseLatest(){} // RVA: 0x7ffaae864de0
        public void set_PurchaseLatest(){} // RVA: 0x7ffab18e3700
        public void get_Products(){} // RVA: 0x7ffaa899d2a0
        public void set_Products(){} // RVA: 0x7ffaa899d2b0
        public void get_IsStackable(){} // RVA: 0x7ffaa96c75d0
        public void set_IsStackable(){} // RVA: 0x7ffaaf1d18c0
        public void get_IsRecurrable(){} // RVA: 0x7ffaa898ef90
        public void set_IsRecurrable(){} // RVA: 0x7ffaa898efa0
        public void get_PurchaseToken(){} // RVA: 0x7ffaa8f205f0
        public void set_PurchaseToken(){} // RVA: 0x7ffaa8f20bd0
        public void get_IsVoided(){} // RVA: 0x7ffaa9bdabb0
        public void set_IsVoided(){} // RVA: 0x7ffaa9bdabc0
        public void get_IsGift(){} // RVA: 0x7ffaa9fee6b0
        public void set_IsGift(){} // RVA: 0x7ffaa9fee670
        public void get_PurchaseUnitPrice(){} // RVA: 0x7ffaa9fb71c0
        public void set_PurchaseUnitPrice(){} // RVA: 0x7ffaa9fb8400
        public void get_IsRefundable(){} // RVA: 0x7ffaa8c09ad0
        public void set_IsRefundable(){} // RVA: 0x7ffaa8c0bc40
        public void get_StackDurationType(){} // RVA: 0x7ffaa8de7450
        public void set_StackDurationType(){} // RVA: 0x7ffaa8de5d60
        public void get_StackDuration(){} // RVA: 0x7ffaae432850
        public void set_StackDuration(){} // RVA: 0x7ffaae432860
        public void get_StackPrice(){} // RVA: 0x7ffaae2f60a0
        public void set_StackPrice(){} // RVA: 0x7ffaae2f60b0
        public void get_StackQuantity(){} // RVA: 0x7ffaae432c10
        public void set_StackQuantity(){} // RVA: 0x7ffaae432c20
        public void get_StackQuantityConsumed(){} // RVA: 0x7ffab18e3710
        public void set_StackQuantityConsumed(){} // RVA: 0x7ffab18e3720
        public void get_StackQuantityConsumedAtPurchase(){} // RVA: 0x7ffaa8de6c30
        public void set_StackQuantityConsumedAtPurchase(){} // RVA: 0x7ffaaef7ed60
        public void get_StackQuantityUnconsumed(){} // RVA: 0x7ffaaed16df0
        public void set_StackQuantityUnconsumed(){} // RVA: 0x7ffab18e3730
        public void get_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x7ffaa96cb0d0
        public void set_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x7ffaae2e8430
        public void get_TiliaTransactionId(){} // RVA: 0x7ffaa899d5f0
        public void set_TiliaTransactionId(){} // RVA: 0x7ffaa899d600
        public void get_WillRecur(){} // RVA: 0x7ffaa9b4da80
        public void set_WillRecur(){} // RVA: 0x7ffaa9b58ef0
        public void get_ListingCurrentlyAvailable(){} // RVA: 0x7ffab145d950
        public void set_ListingCurrentlyAvailable(){} // RVA: 0x7ffab18e3740
        public void get_CreatedAtDate(){} // RVA: 0x7ffaa8f6e840
        public void set_CreatedAtDate(){} // RVA: 0x7ffab18e3750
        public void get_PurchaseID(){} // RVA: 0x7ffaa8f77ed0
        public void set_PurchaseID(){} // RVA: 0x7ffaa93f6970
        public void get_UpdatedAtDate(){} // RVA: 0x7ffaa8dde460
        public void set_UpdatedAtDate(){} // RVA: 0x7ffaaf69ca60
        public void get_PurchaseOriginalEndDate(){} // RVA: 0x7ffaa8f70c30
        public void set_PurchaseOriginalEndDate(){} // RVA: 0x7ffab18e3760
        public void get_BuyerIP(){} // RVA: 0x7ffaa8d916d0
        public void set_BuyerIP(){} // RVA: 0x7ffaa93f45e0
        public void get_IsRecur(){} // RVA: 0x7ffab18e3770
        public void set_IsRecur(){} // RVA: 0x7ffaa8a066a0
        public void get_IsUnityLocalTest(){} // RVA: 0x7ffab18e3780
        public void set_IsUnityLocalTest(){} // RVA: 0x7ffab18e3790
        public void get_LicenseID(){} // RVA: 0x7ffaa8f74160
        public void set_LicenseID(){} // RVA: 0x7ffaa8f2e920
        public void get_PurchaseStacks(){} // RVA: 0x7ffaa8f6f0b0
        public void set_PurchaseStacks(){} // RVA: 0x7ffaa8f2e8c0
        public void get_PurchaseTiliaFee(){} // RVA: 0x7ffaae435700
        public void set_PurchaseTiliaFee(){} // RVA: 0x7ffaaf067c40
        public void get_PurchaseType(){} // RVA: 0x7ffaa8f75d50
        public void set_PurchaseType(){} // RVA: 0x7ffaa94036f0
        public void get_PurchaseValue(){} // RVA: 0x7ffab18e37a0
        public void set_PurchaseValue(){} // RVA: 0x7ffab18e37b0
        public void get_PurchaseVrcFee(){} // RVA: 0x7ffab18e37c0
        public void set_PurchaseVrcFee(){} // RVA: 0x7ffab18e37d0
        public void get_RefundStatus(){} // RVA: 0x7ffaa8f6f0e0
        public void set_RefundStatus(){} // RVA: 0x7ffaa93ff2c0
        public void get_SellerIP(){} // RVA: 0x7ffaa8f6f0f0
        public void set_SellerIP(){} // RVA: 0x7ffaa93d9af0
        public void get_StackTiliaFee(){} // RVA: 0x7ffab142f4b0
        public void set_StackTiliaFee(){} // RVA: 0x7ffab18e37e0
        public void get_StackValue(){} // RVA: 0x7ffaa9a6c2f0
        public void set_StackValue(){} // RVA: 0x7ffab18e37f0
        public void get_StackVrcFee(){} // RVA: 0x7ffaa9a6c580
        public void set_StackVrcFee(){} // RVA: 0x7ffab18e3800
        public void get_StackQuantityVoided(){} // RVA: 0x7ffab18e3810
        public void set_StackQuantityVoided(){} // RVA: 0x7ffab18e3820
        public void get_VoidedBy(){} // RVA: 0x7ffaa93d5320
        public void set_VoidedBy(){} // RVA: 0x7ffaa93e3d80
        public void get_VoidedByAdmin(){} // RVA: 0x7ffab0dcefb0
        public void set_VoidedByAdmin(){} // RVA: 0x7ffab18e3830
        public void get_VoidedOnDate(){} // RVA: 0x7ffaa93e8b10
        public void set_VoidedOnDate(){} // RVA: 0x7ffab18e3840
        public void get_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0x7ffab18e3850
        public void set_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0x7ffab18e3860
        public void get_PurchaseTiliaFeeDrift(){} // RVA: 0x7ffaaeacd660
        public void set_PurchaseTiliaFeeDrift(){} // RVA: 0x7ffab18e3870
        public void get_PurchaseVrcFeeBasedOnStack(){} // RVA: 0x7ffab18e3880
        public void set_PurchaseVrcFeeBasedOnStack(){} // RVA: 0x7ffab18e3890
        public void get_Refunded(){} // RVA: 0x7ffab18e38a0
        public void set_Refunded(){} // RVA: 0x7ffab18e38b0
        public void get_RefundedBy(){} // RVA: 0x7ffaa8f6fa20
        public void set_RefundedBy(){} // RVA: 0x7ffaa8f774b0
        public void get_RefundedByAdmin(){} // RVA: 0x7ffaaa1cc9e0
        public void set_RefundedByAdmin(){} // RVA: 0x7ffab18e38c0
        public void get_RefundedOnDate(){} // RVA: 0x7ffaa8f7aa00
        public void set_RefundedOnDate(){} // RVA: 0x7ffab18e38d0
        public void get_RefundedStacks(){} // RVA: 0x7ffaa8f74940
        public void set_RefundedStacks(){} // RVA: 0x7ffaa8f77e20
        public void get_RefundReason(){} // RVA: 0x7ffaa8f6dbe0
        public void set_RefundReason(){} // RVA: 0x7ffaa8f6f550
        public void get_RefundReasonType(){} // RVA: 0x7ffaa8f70430
        public void set_RefundReasonType(){} // RVA: 0x7ffaa8f7aac0
        public void get_RefundTiliaTransactionId(){} // RVA: 0x7ffaa8f74760
        public void set_RefundTiliaTransactionId(){} // RVA: 0x7ffaa8f6e0b0
        public void get_RefundTokenComponents(){} // RVA: 0x7ffaa8f75b00
        public void set_RefundTokenComponents(){} // RVA: 0x7ffaa93e8560
        public void get_RefundTokens(){} // RVA: 0x7ffaa9f197b0
        public void set_RefundTokens(){} // RVA: 0x7ffaa9f19790
        public void get_RefundTokenSources(){} // RVA: 0x7ffaa8f6ff20
        public void set_RefundTokenSources(){} // RVA: 0x7ffaa93d64a0
        public void get_RefundType(){} // RVA: 0x7ffaa93e4de0
        public void set_RefundType(){} // RVA: 0x7ffaa93d5a40
        public void get_VoidedStacks(){} // RVA: 0x7ffaa93e4a80
        public void set_VoidedStacks(){} // RVA: 0x7ffaa93fd280
        public void get_VoidedCompletely(){} // RVA: 0x7ffab18e38e0
        public void set_VoidedCompletely(){} // RVA: 0x7ffab18e38f0
        public void ReadField(){} // RVA: 0x7ffab18e3900
        public void WriteField(){} // RVA: 0x7ffab18e3b40
        public void Cancel(){} // RVA: 0x7ffab18e45a0
        public void FetchList(){} // RVA: 0x7ffab18e4f10
        public void FetchMostRecentActivePurchase(){} // RVA: 0x7ffab18e5ec0
        public void .ctor(){} // RVA: 0x7ffab18e6820
        // ── Binary Analysis Named ──
        public void GetCancelInformation(){} // RVA: 0x7ffab18e3cc0
    }

    public class ApiReport : ApiModel
    {
        public object _reason; // 0x3474AE40, was: <reason>k__BackingField
        public object _details; // 0x3474AE40, was: <details>k__BackingField

        // ── Original Methods ──
        public void get_type(){} // RVA: 0x7ffaa89add50
        public void set_type(){} // RVA: 0x7ffaa89add60
        public void get_category(){} // RVA: 0x7ffaa89fa590
        public void set_category(){} // RVA: 0x7ffaa89fa5a0
        public void get_reason(){} // RVA: 0x7ffaa8af68f0
        public void set_reason(){} // RVA: 0x7ffaa8af19e0
        public void get_contentId(){} // RVA: 0x7ffaa8d1a3b0
        public void set_contentId(){} // RVA: 0x7ffaa8efece0
        public void get_description(){} // RVA: 0x7ffaa8971010
        public void set_description(){} // RVA: 0x7ffaa8f7b010
        public void get_details(){} // RVA: 0x7ffaa8d1b980
        public void set_details(){} // RVA: 0x7ffaa8f7b070
        public void get_contentName(){} // RVA: 0x7ffaa8f75d20
        public void set_contentName(){} // RVA: 0x7ffaa8f7b0d0
        public void get_contentThumbnailImageUrl(){} // RVA: 0x7ffaa8f78170
        public void set_contentThumbnailImageUrl(){} // RVA: 0x7ffaa8f7b130
        public void AddReport(){} // RVA: 0x7ffab18e75f0
        public void FetchReports(){} // RVA: 0x7ffab18e7910
        public void DeleteReport(){} // RVA: 0x7ffab18e7fb0
        public void .ctor(){} // RVA: 0x7ffab18e82c0
    }

    public class ApiSharedConnectionCounts : ApiModel
    {
        public object _groups; // 0x3474B3D0, was: <groups>k__BackingField

        // ── Original Methods ──
        public void get_CacheLifetime(){} // RVA: 0x7ffab19427c0
        public void get_friends(){} // RVA: 0x7ffaaa1c2a40
        public void set_friends(){} // RVA: 0x7ffaaa1c2a50
        public void get_groups(){} // RVA: 0x7ffaaa1c2a60
        public void set_groups(){} // RVA: 0x7ffaaa1c2a70
        public void FetchSharedConnectionCountsAsync(){} // RVA: 0x7ffab1942950
        public void .ctor(){} // RVA: 0x7ffab1942b00
        // ── Binary Analysis Named ──
        public void GetLifeSpan(){} // RVA: 0x7ffab19427c0
    }

    public class ApiStoreShelf : ApiModel
    {
        public object _shelfLayout; // 0x347E8030, was: <ShelfLayout>k__BackingField
        public object _listingIds; // 0x347E8030, was: <ListingIds>k__BackingField
        public object _sellerId; // 0x347E8030, was: <SellerId>k__BackingField
        public object _shelfBackgroundImageId; // 0x347E8030, was: <ShelfBackgroundImageId>k__Bac
        public object _highlightListing; // 0x347E8030, was: <HighlightListing>k__BackingFi

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab193cfd0
        public void get_ShelfTitle(){} // RVA: 0x7ffaa89add50
        public void set_ShelfTitle(){} // RVA: 0x7ffaa89add60
        public void get_ShelfDescription(){} // RVA: 0x7ffaa89fa590
        public void set_ShelfDescription(){} // RVA: 0x7ffaa89fa5a0
        public void get_ShelfLayout(){} // RVA: 0x7ffaa8af68f0
        public void set_ShelfLayout(){} // RVA: 0x7ffaa8af19e0
        public void get_UpdatedAt(){} // RVA: 0x7ffaa8d1a3b0
        public void set_UpdatedAt(){} // RVA: 0x7ffaaa5ccbe0
        public void get_CreatedAt(){} // RVA: 0x7ffaa8971010
        public void set_CreatedAt(){} // RVA: 0x7ffaaa5564d0
        public void get_ListingIds(){} // RVA: 0x7ffaa8d1b980
        public void set_ListingIds(){} // RVA: 0x7ffaa8f7b070
        public void get_ShelfVisibility(){} // RVA: 0x7ffaa8f75d20
        public void set_ShelfVisibility(){} // RVA: 0x7ffaa8f7b0d0
        public void get_StoreId(){} // RVA: 0x7ffaa8f78170
        public void set_StoreId(){} // RVA: 0x7ffaa8f7b130
        public void get_SellerId(){} // RVA: 0x7ffaa8f74720
        public void set_SellerId(){} // RVA: 0x7ffaa8d71dc0
        public void get_HighlightListingId(){} // RVA: 0x7ffaa899d040
        public void set_HighlightListingId(){} // RVA: 0x7ffaa899d050
        public void get_ShelfTabBackgroundImageId(){} // RVA: 0x7ffaa899d0b0
        public void set_ShelfTabBackgroundImageId(){} // RVA: 0x7ffaa899d0c0
        public void get_ShelfTabBackgroundImageUrl(){} // RVA: 0x7ffab193d020
        public void get_ShelfBackgroundImageId(){} // RVA: 0x7ffaa899d120
        public void set_ShelfBackgroundImageId(){} // RVA: 0x7ffaa899d130
        public void get_ShelfBackgroundImageUrl(){} // RVA: 0x7ffab193d090
        public void get_ShelfIconImageId(){} // RVA: 0x7ffaa8a8a460
        public void set_ShelfIconImageId(){} // RVA: 0x7ffaa8a8a470
        public void get_ShelfIconImageUrl(){} // RVA: 0x7ffab193d100
        public void get_Listings(){} // RVA: 0x7ffaa8a4f100
        public void set_Listings(){} // RVA: 0x7ffaa8a4f110
        public void get_HighlightListing(){} // RVA: 0x7ffaa8f6dbf0
        public void set_HighlightListing(){} // RVA: 0x7ffaa89b38a0
    }

    public class ApiTransaction : ApiModel
    {
        public object _sellerId; // 0x3474BAA0, was: <SellerId>k__BackingField
        public object _buyerId; // 0x3474BAA0, was: <BuyerId>k__BackingField
        public object _date; // 0x3474BAA0, was: <Date>k__BackingField
        public object _imageId; // 0x3474BAA0, was: <ImageId>k__BackingField

        // ── Original Methods ──
        public void get_ListingID(){} // RVA: 0x7ffaa89add50
        public void set_ListingID(){} // RVA: 0x7ffaa89add60
        public void get_Name(){} // RVA: 0x7ffaa89fa590
        public void set_Name(){} // RVA: 0x7ffaa89fa5a0
        public void get_SellerId(){} // RVA: 0x7ffaa8af68f0
        public void set_SellerId(){} // RVA: 0x7ffaa8af19e0
        public void get_FromUserDisplayName(){} // RVA: 0x7ffaa8d1a3b0
        public void set_FromUserDisplayName(){} // RVA: 0x7ffaa8efece0
        public void get_SellerDisplayName(){} // RVA: 0x7ffaa8971010
        public void set_SellerDisplayName(){} // RVA: 0x7ffaa8f7b010
        public void get_BuyerId(){} // RVA: 0x7ffaa8d1b980
        public void set_BuyerId(){} // RVA: 0x7ffaa8f7b070
        public void get_BuyerDisplayName(){} // RVA: 0x7ffaa8f75d20
        public void set_BuyerDisplayName(){} // RVA: 0x7ffaa8f7b0d0
        public void get_Type(){} // RVA: 0x7ffaa8f78170
        public void set_Type(){} // RVA: 0x7ffaa8f7b130
        public void get_Date(){} // RVA: 0x7ffaa8f74720
        public void set_Date(){} // RVA: 0x7ffaa9fee770
        public void get_Amount(){} // RVA: 0x7ffaaa5f96a0
        public void set_Amount(){} // RVA: 0x7ffaae1d6ca0
        public void get_RunningBalance(){} // RVA: 0x7ffaac120410
        public void set_RunningBalance(){} // RVA: 0x7ffaac120420
        public void get_ImageId(){} // RVA: 0x7ffaa899d0b0
        public void set_ImageId(){} // RVA: 0x7ffaa899d0c0
        public void get_PurchaseId(){} // RVA: 0x7ffaa899d120
        public void set_PurchaseId(){} // RVA: 0x7ffaa899d130
        public void get_TiliaRef(){} // RVA: 0x7ffaa8a8a460
        public void set_TiliaRef(){} // RVA: 0x7ffaa8a8a470
        public void get_TransactionImageUrl(){} // RVA: 0x7ffab18f0bc0
        public void FetchList(){} // RVA: 0x7ffab18f0c30
        public void .ctor(){} // RVA: 0x7ffab18f1b60
    }

    public class ApiUserPermission : ApiModel
    {
        public object _data; // 0x368E1170, was: <data>k__BackingField

        // ── Original Methods ──
        public void get_ownerId(){} // RVA: 0x7ffaa89add50
        public void set_ownerId(){} // RVA: 0x7ffaa89add60
        public void get_name(){} // RVA: 0x7ffaa89fa590
        public void set_name(){} // RVA: 0x7ffaa89fa5a0
        public void get_data(){} // RVA: 0x7ffaa8af68f0
        public void set_data(){} // RVA: 0x7ffaa8af19e0
        public void .ctor(){} // RVA: 0x7ffab190c0c0
    }

    public class ApiUserPermissions : Object
    {
        public object MAX_USER_IMAGES; // 0x368E0E70
        public object System.Collections.Generic; // 0xB412CF40

        // ── Original Methods ──
        public void Clear(){} // RVA: 0x7ffab190b7e0
        public void FetchPermissions(){} // RVA: 0x7ffab190b830
        public void .ctor(){} // RVA: 0x7ffab190bb30
        // ── Binary Analysis Named ──
        public void GetPermission_UserIcon(){} // RVA: 0x7ffab190b3e0
        public void GetPermission_InvitePhotos(){} // RVA: 0x7ffab190b460
        public void GetPermission_ExtraFavoriteAvatars(){} // RVA: 0x7ffab190b4e0
        public void GetPermission_UserGallery(){} // RVA: 0x7ffab190b560
        public void GetPermission_ProfilePictureOverride(){} // RVA: 0x7ffab190b5e0
        public void GetPermission_MaximumUserIcons(){} // RVA: 0x7ffaa8e2ebb0
        public void GetPermission_MaximumUserImages(){} // RVA: 0x7ffaa8e2ebb0
        public void GetPermission_UseProps(){} // RVA: 0x7ffab190b660
        public void GetPermission_UploadProps(){} // RVA: 0x7ffab190b6e0
        public void GetPermission_TestProps(){} // RVA: 0x7ffab190b760
    }

    public class ApiVRChatProductDetails : ApiModel
    {
        public object productTypeEnum; // 0x345FC030
        public object _subscriptionInfo; // 0x345FC030, was: <subscriptionInfo>k__BackingFi
        public object _description; // 0x345FC030, was: <description>k__BackingField

        // ── Original Methods ──
        public void get_enabled(){} // RVA: 0x7ffaa89fa570
        public void set_enabled(){} // RVA: 0x7ffaa89fa580
        public void get_productType(){} // RVA: 0x7ffaa89fa590
        public void set_productType(){} // RVA: 0x7ffaa89fa5a0
        public void get_Product(){} // RVA: 0x7ffab190ccb0
        public void get_endpoint(){} // RVA: 0x7ffaa8d1a3b0
        public void set_endpoint(){} // RVA: 0x7ffaa8efece0
        public void get_stores(){} // RVA: 0x7ffaa8971010
        public void set_stores(){} // RVA: 0x7ffaa8f7b010
        public void get_subscriptionInfo(){} // RVA: 0x7ffaa8d1b980
        public void set_subscriptionInfo(){} // RVA: 0x7ffaa8f7b070
        public void get_giftInfo(){} // RVA: 0x7ffaa8f75d20
        public void set_giftInfo(){} // RVA: 0x7ffaa8f7b0d0
        public void get_tokenInfo(){} // RVA: 0x7ffaa8f78170
        public void set_tokenInfo(){} // RVA: 0x7ffaa8f7b130
        public void get_description(){} // RVA: 0x7ffaa8f74720
        public void set_description(){} // RVA: 0x7ffaa8d71dc0
        public void .ctor(){} // RVA: 0x7ffab190cda0
    }

    public class ApiViewfinderSkin : ApiModel
    {
        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_assetBundleId(){} // RVA: 0x7ffaa89fa590
        public void set_assetBundleId(){} // RVA: 0x7ffaa89fa5a0
        public void .ctor(){} // RVA: 0x7ffab190cb70
    }

    public class ApiWarpEffectSkin : ApiModel
    {
        // ── Original Methods ──
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_assetBundleId(){} // RVA: 0x7ffaa89fa590
        public void set_assetBundleId(){} // RVA: 0x7ffaa89fa5a0
        public void .ctor(){} // RVA: 0x7ffab190d660
    }

    public class ApiWorld : ApiModel
    {
        public object ListCacheTime; // 0x34225CD0
        public object localWorlds; // 0x34225CD0
        public object _thumbnailImageUrl; // 0x34225CD0, was: <thumbnailImageUrl>k__BackingF
        public object _capacity; // 0x34225CD0, was: <capacity>k__BackingField
        public object _publicOccupants; // 0x34225CD0, was: <publicOccupants>k__BackingFie
        public object _createdAt; // 0x34225CD0, was: <createdAt>k__BackingField
        public object _tags; // 0x34225CD0, was: <tags>k__BackingField
        public object _version; // 0x34225CD0, was: <version>k__BackingField
        public object _latestAssetVersion; // 0x34225CD0, was: <latestAssetVersion>k__Backing
        public object _publicationDate; // 0x34225CD0, was: <publicationDate>k__BackingFie
        public object _storeId; // 0x34225CD0, was: <storeId>k__BackingField
        public object _unityPackageUpdated; // 0x34225CD0, was: <unityPackageUpdated>k__Backin
        public object _favoriteId; // 0x34225CD0, was: <favoriteId>k__BackingField
        public object _popularity; // 0x34225CD0, was: <popularity>k__BackingField
        public object _defaultContentSettings; // 0x34225CD0, was: <defaultContentSettings>k__Bac
        public object _safeUrlChars; // 0x34225CD0
        public object GetStatus; // 0xB419EFA0
        public object IValueTaskSource`1; // 0x330A5900

        // ── Original Methods ──
        public void get_VERSION(){} // RVA: 0x7ffab190d6b0
        public void ShouldCache(){} // RVA: 0x7ffab190d8b0
        public void get_name(){} // RVA: 0x7ffaa89add50
        public void set_name(){} // RVA: 0x7ffaa89add60
        public void get_imageUrl(){} // RVA: 0x7ffaa89fa590
        public void set_imageUrl(){} // RVA: 0x7ffaa89fa5a0
        public void get_thumbnailImageUrl(){} // RVA: 0x7ffaa8af68f0
        public void set_thumbnailImageUrl(){} // RVA: 0x7ffaa8af19e0
        public void get_authorName(){} // RVA: 0x7ffaa8d1a3b0
        public void set_authorName(){} // RVA: 0x7ffaa8efece0
        public void get_releaseStatus(){} // RVA: 0x7ffaa8971010
        public void set_releaseStatus(){} // RVA: 0x7ffaa8f7b010
        public void get_capacity(){} // RVA: 0x7ffaa8c4abe0
        public void set_capacity(){} // RVA: 0x7ffaa8efe560
        public void get_recommendedCapacity(){} // RVA: 0x7ffaa8c4abd0
        public void set_recommendedCapacity(){} // RVA: 0x7ffaa8e5e660
        public void get_occupants(){} // RVA: 0x7ffaaa2a8330
        public void set_occupants(){} // RVA: 0x7ffaaa2a8340
        public void get_publicOccupants(){} // RVA: 0x7ffaaa2a7db0
        public void set_publicOccupants(){} // RVA: 0x7ffaaa2a7dc0
        public void get_privateOccupants(){} // RVA: 0x7ffaaa2a7de0
        public void set_privateOccupants(){} // RVA: 0x7ffaaa2a7dd0
        public void get_authorId(){} // RVA: 0x7ffaa8f74720
        public void set_authorId(){} // RVA: 0x7ffaa8d71dc0
        public void get_createdAt(){} // RVA: 0x7ffaa899d040
        public void set_createdAt(){} // RVA: 0x7ffaa9feeaa0
        public void get_assetUrl(){} // RVA: 0x7ffaa899d0b0
        public void set_assetUrl(){} // RVA: 0x7ffaa899d0c0
        public void get_description(){} // RVA: 0x7ffaa899d120
        public void set_description(){} // RVA: 0x7ffaa899d130
        public void get_tags(){} // RVA: 0x7ffaa8a8a460
        public void set_tags(){} // RVA: 0x7ffaa8a8a470
        public void get_urlList(){} // RVA: 0x7ffaa8a4f100
        public void set_urlList(){} // RVA: 0x7ffaa8a4f110
        public void get_unityPackageUrl(){} // RVA: 0x7ffaa8f6dbf0
        public void set_unityPackageUrl(){} // RVA: 0x7ffaa89b38a0
        public void get_version(){} // RVA: 0x7ffaaa23fe60
        public void set_version(){} // RVA: 0x7ffaaa23fe70
        public void get_unityVersion(){} // RVA: 0x7ffaa89b3970
        public void set_unityVersion(){} // RVA: 0x7ffaa89b3980
        public void get_apiVersion(){} // RVA: 0x7ffaaba8f7a0
        public void set_apiVersion(){} // RVA: 0x7ffaae432840
        public void get_latestAssetVersion(){} // RVA: 0x7ffaac120940
        public void set_latestAssetVersion(){} // RVA: 0x7ffaac120950
        public void get_created_at(){} // RVA: 0x7ffaa8d57210
        public void set_created_at(){} // RVA: 0x7ffaac120980
        public void get_updated_at(){} // RVA: 0x7ffaa8f205f0
        public void set_updated_at(){} // RVA: 0x7ffaa9bdaba0
        public void get_publicationDate(){} // RVA: 0x7ffaa9102670
        public void set_publicationDate(){} // RVA: 0x7ffab18809c0
        public void get_labsPublicationDate(){} // RVA: 0x7ffaa8f76f40
        public void set_labsPublicationDate(){} // RVA: 0x7ffaae5881b0
        public void get_udonProducts(){} // RVA: 0x7ffaa8de7450
        public void set_udonProducts(){} // RVA: 0x7ffaa8de5d60
        public void get_storeId(){} // RVA: 0x7ffaa8b68c40
        public void set_storeId(){} // RVA: 0x7ffaa8b6fd10
        public void get_platform(){} // RVA: 0x7ffaa8f78450
        public void set_platform(){} // RVA: 0x7ffaa93ff110
        public void get_worldInstances(){} // RVA: 0x7ffaa8f7aa40
        public void get_isAdminApproved(){} // RVA: 0x7ffab190d910
        public void get_IsCommunityLabsWorld(){} // RVA: 0x7ffab190d990
        public void get_IsPublicPublishedWorld(){} // RVA: 0x7ffab190da00
        public void get_IsInternalWorld(){} // RVA: 0x7ffab190da80
        public void get_unityPackageUpdated(){} // RVA: 0x7ffab190dae0
        public void set_unityPackageUpdated(){} // RVA: 0x7ffab190daf0
        public void get_organization(){} // RVA: 0x7ffaa899d5f0
        public void set_organization(){} // RVA: 0x7ffaa899d600
        public void get_shouldAddToAuthor(){} // RVA: 0x7ffaa9b4da80
        public void set_shouldAddToAuthor(){} // RVA: 0x7ffaa9b58ef0
        public void get_favoriteId(){} // RVA: 0x7ffaa8f6e840
        public void set_favoriteId(){} // RVA: 0x7ffaa93ec470
        public void get_favorites(){} // RVA: 0x7ffab190db00
        public void set_favorites(){} // RVA: 0x7ffaaf41fc40
        public void get_visits(){} // RVA: 0x7ffab190db10
        public void set_visits(){} // RVA: 0x7ffaaf41fc60
        public void get_popularity(){} // RVA: 0x7ffaa9069090
        public void set_popularity(){} // RVA: 0x7ffaa906c5b0
        public void get_heat(){} // RVA: 0x7ffab18de030
        public void set_heat(){} // RVA: 0x7ffab18de040
        public void get_detailed(){} // RVA: 0x7ffaa9a59660
        public void set_detailed(){} // RVA: 0x7ffab190db20
        public void get_defaultContentSettings(){} // RVA: 0x7ffaa8d916d0
        public void set_defaultContentSettings(){} // RVA: 0x7ffaa93f45e0
        public void get_assetVersion(){} // RVA: 0x7ffab190db30
        public void set_assetVersion(){} // RVA: 0x7ffab190dbe0
        public void get_BundleSignature(){} // RVA: 0x7ffaa8d92160
        public void set_BundleSignature(){} // RVA: 0x7ffaa93d3040
        public void get_isCurated(){} // RVA: 0x7ffab190dc70
        public void set_isCurated(){} // RVA: 0x7ffab190dc80
        public void get_publicTags(){} // RVA: 0x7ffab190dc90
        public void .ctor(){} // RVA: 0x7ffab190de90
        public void ReadField(){} // RVA: 0x7ffab190e0a0
        public void ReadUnityPackages(){} // RVA: 0x7ffab190e360
        public void ReadUnityPackage(){} // RVA: 0x7ffab190eab0
        public void WriteField(){} // RVA: 0x7ffab190f110
        public void CopyDeserializedValuesTo(){} // RVA: 0x7ffab190fba0
        public void Save(){} // RVA: 0x7ffab1910000
        public void Fetch(){} // RVA: 0x7ffab19101b0
        public void FetchList(){} // RVA: 0x7ffab1910ce0
        public void FetchSearchResults(){} // RVA: 0x7ffab1911190
        public void AddLocal(){} // RVA: 0x7ffab1911690
        public void get_IsLocal(){} // RVA: 0x7ffab1911760
        public void ShouldNotBeVisibleOptional(){} // RVA: 0x7ffab1911a10
        public void CreateNewInstanceAsync(){} // RVA: 0x7ffab1912020
        public void CreateNewInstance(){} // RVA: 0x7ffab1912390
        public void FetchUploadedWorlds(){} // RVA: 0x7ffab1912820
        public void PublishWorldToCommunityLabs(){} // RVA: 0x7ffab1912d10
        public void UpdateVersionAndPlatform(){} // RVA: 0x7ffab1913050
        public void MakeRequestEndpoint(){} // RVA: 0x7ffab19131c0
        public void Merge(){} // RVA: 0x7ffab19131e0
        public void .cctor(){} // RVA: 0x7ffab1913ab0
        // ── Binary Analysis Named ──
        public void GetLifeSpan(){} // RVA: 0x7ffab190d900
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab190e280
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab190e280
        public void SetLocal(){} // RVA: 0x7ffab1911840
        public void GetBestInstance(){} // RVA: 0x7ffab1911dc0
        public void GetBestInstance(){} // RVA: 0x7ffab1911dc0
    }

    public class ApiWorldInstance : ApiModel
    {
        public object _location; // 0x342255C0, was: <location>k__BackingField
        public object _secureName; // 0x342255C0, was: <secureName>k__BackingField
        public object _instanceId; // 0x342255C0, was: <instanceId>k__BackingField
        public object _type; // 0x342255C0, was: <type>k__BackingField
        public object _count; // 0x342255C0, was: <count>k__BackingField
        public object _platforms; // 0x342255C0, was: <platforms>k__BackingField
        public object _gameServerVersion; // 0x342255C0, was: <gameServerVersion>k__BackingF
        public object _queueEnabled; // 0x342255C0, was: <queueEnabled>k__BackingField
        public object _closedAt; // 0x342255C0, was: <closedAt>k__BackingField
        public object _contentSettings; // 0x342255C0, was: <contentSettings>k__BackingFie
        public object _users; // 0x342255C0, was: <users>k__BackingField
        public object _groupAccessType; // 0x342255C0, was: <groupAccessType>k__BackingFie
        public object _lastPostTime; // 0x342255C0
        public object System.Threading.Tasks.Sources; // 0x330A56E0
        public object Ǐf; // 0xA8659140

        // ── Original Methods ──
        public void get_location(){} // RVA: 0x7ffaa89add50
        public void set_location(){} // RVA: 0x7ffaa89add60
        public void get_name(){} // RVA: 0x7ffaa89fa590
        public void set_name(){} // RVA: 0x7ffab1918f10
        public void get_shortName(){} // RVA: 0x7ffaa8af68f0
        public void set_shortName(){} // RVA: 0x7ffaa8af19e0
        public void get_secureName(){} // RVA: 0x7ffaa8d1a3b0
        public void set_secureName(){} // RVA: 0x7ffaa8efece0
        public void get_displayName(){} // RVA: 0x7ffaa8971010
        public void set_displayName(){} // RVA: 0x7ffaa8f7b010
        public void get_worldId(){} // RVA: 0x7ffaa8d1b980
        public void set_worldId(){} // RVA: 0x7ffaa8f7b070
        public void get_instanceId(){} // RVA: 0x7ffaa8f75d20
        public void set_instanceId(){} // RVA: 0x7ffaa8f7b0d0
        public void get_instanceCode(){} // RVA: 0x7ffaa8f78170
        public void set_instanceCode(){} // RVA: 0x7ffaa8f7b130
        public void get_world(){} // RVA: 0x7ffaa8f74720
        public void set_world(){} // RVA: 0x7ffaa8d71dc0
        public void get_type(){} // RVA: 0x7ffaaa5f96a0
        public void set_type(){} // RVA: 0x7ffaae1d6ca0
        public void get_ownerId(){} // RVA: 0x7ffaa899d0b0
        public void set_ownerId(){} // RVA: 0x7ffaa899d0c0
        public void get_tags(){} // RVA: 0x7ffaa899d120
        public void set_tags(){} // RVA: 0x7ffaa899d130
        public void get_count(){} // RVA: 0x7ffaa906c660
        public void set_count(){} // RVA: 0x7ffaabc50490
        public void get_capacity(){} // RVA: 0x7ffaa9d2b2b0
        public void set_capacity(){} // RVA: 0x7ffaae2e83d0
        public void get_recommendedCapacity(){} // RVA: 0x7ffaa90bdfd0
        public void set_recommendedCapacity(){} // RVA: 0x7ffaa9fb8260
        public void get_platforms(){} // RVA: 0x7ffaa8f6dbf0
        public void set_platforms(){} // RVA: 0x7ffaa89b38a0
        public void get_nonce(){} // RVA: 0x7ffaa89b3900
        public void set_nonce(){} // RVA: 0x7ffaa89b3910
        public void get_clientVersion(){} // RVA: 0x7ffaa89b3970
        public void set_clientVersion(){} // RVA: 0x7ffaa89b3980
        public void get_gameServerVersion(){} // RVA: 0x7ffaaba8f7a0
        public void set_gameServerVersion(){} // RVA: 0x7ffaae432840
        public void get_region(){} // RVA: 0x7ffaac120940
        public void set_region(){} // RVA: 0x7ffaac120950
        public void get_active(){} // RVA: 0x7ffaa96c75d0
        public void set_active(){} // RVA: 0x7ffaaf1d18c0
        public void get_queueEnabled(){} // RVA: 0x7ffaa898ef90
        public void set_queueEnabled(){} // RVA: 0x7ffaa898efa0
        public void get_hasCapacityForYou(){} // RVA: 0x7ffab0cf25c0
        public void set_hasCapacityForYou(){} // RVA: 0x7ffab0cf25a0
        public void get_queueSize(){} // RVA: 0x7ffaa96c76b0
        public void set_queueSize(){} // RVA: 0x7ffaaf1d1840
        public void get_closedAt(){} // RVA: 0x7ffaa8f205f0
        public void set_closedAt(){} // RVA: 0x7ffaa9bdaba0
        public void get_hardClose(){} // RVA: 0x7ffaa9bdabb0
        public void set_hardClose(){} // RVA: 0x7ffaa9bdabc0
        public void get_ageGate(){} // RVA: 0x7ffaa9fee6b0
        public void set_ageGate(){} // RVA: 0x7ffaa9fee670
        public void get_contentSettings(){} // RVA: 0x7ffaa8f76f40
        public void set_contentSettings(){} // RVA: 0x7ffaa93fc460
        public void get_IsClosed(){} // RVA: 0x7ffab1919000
        public void get_IsAgeGated(){} // RVA: 0x7ffab1919120
        public void get_playerPersistenceEnabled(){} // RVA: 0x7ffaa9ace660
        public void set_playerPersistenceEnabled(){} // RVA: 0x7ffaa9abbc70
        public void get_calendarEntryId(){} // RVA: 0x7ffaa8b68c40
        public void set_calendarEntryId(){} // RVA: 0x7ffaa8b6fd10
        public void get_users(){} // RVA: 0x7ffaa8f78450
        public void set_users(){} // RVA: 0x7ffaa93ff110
        public void get_ShouldSeeInstanceByType(){} // RVA: 0x7ffab1919270
        public void get_roleIds(){} // RVA: 0x7ffaa8f7aa40
        public void set_roleIds(){} // RVA: 0x7ffaa93f4640
        public void get_roleRestricted(){} // RVA: 0x7ffab190dae0
        public void set_roleRestricted(){} // RVA: 0x7ffab190daf0
        public void get_groupAccessType(){} // RVA: 0x7ffaa899d5f0
        public void set_groupAccessType(){} // RVA: 0x7ffaa899d600
        public void get_id(){} // RVA: 0x7ffaa89add50
        public void set_id(){} // RVA: 0x7ffab1919390
        public void .ctor(){} // RVA: 0x7ffab1919720
        public void .ctor(){} // RVA: 0x7ffab1919720
        public void .ctor(){} // RVA: 0x7ffab1919720
        public void Init(){} // RVA: 0x7ffab1919760
        public void MakeRequestEndpoint(){} // RVA: 0x7ffab191a160
        public void ExtractInfoFromLocation(){} // RVA: 0x7ffab191a410
        public void BuildRequest(){} // RVA: 0x7ffab191ab00
        public void ReadField(){} // RVA: 0x7ffab191b1f0
        public void WriteField(){} // RVA: 0x7ffab191b580
        public void ParseTags(){} // RVA: 0x7ffab191b7e0
        public void ToString(){} // RVA: 0x7ffab191ba80
        public void get_ProbablyExistsOnAPI(){} // RVA: 0x7ffab191bee0
        public void CreateOrFetch(){} // RVA: 0x7ffab191c0e0
        public void CreateOrFetch(){} // RVA: 0x7ffab191c0e0
        public void CreateOrFetchAsync(){} // RVA: 0x7ffab191c550
        public void CreateOrFetchAsync(){} // RVA: 0x7ffab191c550
        public void CreateOrFetchAsyncInternal(){} // RVA: 0x7ffab191c720
        public void .cctor(){} // RVA: 0x7ffab191c940
        public void <get_ProbablyExistsOnAPI>b__165_0(){} // RVA: 0x7ffab191ca10
        // ── Binary Analysis Named ──
        public void Get(){} // RVA: 0x7ffab1919ed0
        public void SetInstanceAccessTypeFromId(){} // RVA: 0x7ffab191a1d0
        public void GetLifeSpan(){} // RVA: 0x7ffab191b1e0
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab191b740
        public void SetApiFieldsFromJson(){} // RVA: 0x7ffab191b740
        public void GetShortName(){} // RVA: 0x7ffab191bb40
    }

    public class AreaBase : Object
    {
        // ── Original Methods ──
        public void get_Endpoint(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class AssetVersion : Object
    {
        public object _apiVersion; // 0x374609C0
        public object UnityVersion; // 0x17000E93

        // ── Original Methods ──
        public void get_UnityVersion(){} // RVA: 0x7ffab192dae0
        public void set_UnityVersion(){} // RVA: 0x7ffaa8933e30
        public void get_UnityVersionObj(){} // RVA: 0x7ffab192dbd0
        public void get_ApiVersion(){} // RVA: 0x7ffaa96cc980
        public void set_ApiVersion(){} // RVA: 0x7ffaa9fdb500
        public void .ctor(){} // RVA: 0x7ffab192dde0
        public void .ctor(){} // RVA: 0x7ffab192dde0
        public void .ctor(){} // RVA: 0x7ffab192dde0
        public void ToString(){} // RVA: 0x7ffab192de40
    }

}