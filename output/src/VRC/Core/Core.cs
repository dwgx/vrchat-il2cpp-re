// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 93
// Methods: 2462

namespace VRC.Core
{
    public class API : Object
    {
        public string ClientGameServerVersion;
        public string DeviceID;
        public string IsVRCClient;
        public string releaseApiUrl;
        public string _apiStore; // 0x8
        public bool _allowRoaming; // 0x10
        public int _clientGameServerVersion; // 0x14
        public string _clientVersion; // 0x18
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.m.String,BestHTTP.JSON.Json.Token>.get_Values _apiOnlineMode; // 0x20
        public float RESPONSE_CACHE_LIFETIME;
        public string LOG_CATEGORY;
        public URA.DateTime<string,String,System.Object>>.Contains> EndpointAccessTimes; // 0x28
        public int MAX_RETRY_COUNT;
        public float RETRY_DELAY_SECONDS;
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.rl Favorites; // 0x30
        public int _lastRequestId; // 0x38
        public URA.DateTime<string,ÏÏÎÏÍÏÌÎÏÍÏ.ÌÏÍÍÍ> _activeRequests; // 0x40
        public URA.woDigitYearMax<URA.DayNames<string,_TA_ECDSA_SHA_1>> _offlineQueries; // 0x48
        public bool <IsVRCClient>k__BackingField; // 0x50

        // ── Methods ──
        public void get_ClientGameServerVersion(){} // RVA: 0x7FFD5727A1A0
        public void .cctor(){} // RVA: 0x7FFD5727A200
        public void RegisterLogging(){} // RVA: 0x7FFD5727A750
        public void SetClientVersion(){} // RVA: 0x7FFD5727A800
        public void GetClientVersion(){} // RVA: 0x7FFD5727A8C0
        public void SetStore(){} // RVA: 0x7FFD5727A920
        public void GetStore(){} // RVA: 0x7FFD5727A9E0
        public void SetAllowRoaming(){} // RVA: 0x7FFD5727AA40
        public void GetAllowRoaming(){} // RVA: 0x7FFD5727AAA0
        public void SetClientGameServerVersion(){} // RVA: 0x7FFD5727AB00
        public void IsReady(){} // RVA: 0x7FFD5727AB60
        public void FromCacheOrNew(){} // RVA: 0x7FFD4E2ADC40
        public void CreateFromJson(){} // RVA: 0x7FFD4E2ADC40
        public void Fetch(){} // RVA: 0x7FFD4E2ADC40
        public void FetchAsync(){} // RVA: 0x7FFD4E0899E0
        public void DeleteAsync(){} // RVA: 0x7FFD4E078F80
        public void Delete(){} // RVA: 0x7FFD4E0961F0
        public void get_DeviceID(){} // RVA: 0x7FFD53F37AB0
        public void SetApiUrlFromEnvironment(){} // RVA: 0x7FFD5727AC00
        public void GetApiUrlForEnvironment(){} // RVA: 0x7FFD5727AE00
        public void SetApiUrl(){} // RVA: 0x7FFD5727AF30
        public void GetApiUrl(){} // RVA: 0x7FFD5727AFE0
        public void IsDevApi(){} // RVA: 0x7FFD5727B040
        public void IsDevCeApi(){} // RVA: 0x7FFD5727B120
        public void SendGetRequest(){} // RVA: 0x7FFD5727B200
        public void SendPostRequest(){} // RVA: 0x7FFD5727B320
        public void SendPostFormRequest(){} // RVA: 0x7FFD5727B440
        public void SendPostRawJsonRequest(){} // RVA: 0x7FFD5727B560
        public void SendPutRequest(){} // RVA: 0x7FFD5727B680
        public void SendDeleteRequest(){} // RVA: 0x7FFD5727B7A0
        public void SendRequest(){} // RVA: 0x7FFD5727B8C0
        public void SendRequestInternal(){} // RVA: 0x7FFD5727BFF0
        public void AuthenticateHTTPRequest(){} // RVA: 0x7FFD5727D590
        public void AuthenticateUnityWebRequest(){} // RVA: 0x7FFD5727DA00
        public void PopulateHTTPRequestHeaders(){} // RVA: 0x7FFD5727DD50
        public void PopulateUnityWebRequestHeaders(){} // RVA: 0x7FFD5727E1E0
        public void CertVerifyHTTPRequest(){} // RVA: 0x7FFD5727E4B0
        public void CertVerifyUnityWebRequest(){} // RVA: 0x7FFD5727E660
        public void InitializeCertificateVerifier(){} // RVA: 0x7FFD5727E920
        public void AppendQuery(){} // RVA: 0x7FFD5727EA50
        public void ConvertJsonListToModelList(){} // RVA: 0x7FFD4E078FF0
        public void get_IsVRCClient(){} // RVA: 0x7FFD5727EB00
        public void set_IsVRCClient(){} // RVA: 0x7FFD5727EB60
        public void SetOnlineMode(){} // RVA: 0x7FFD5727EBC0
        public void ClearOnlineMode(){} // RVA: 0x7FFD5727EF90
        public void IsOffline(){} // RVA: 0x7FFD5727F040
        public void GetServerEnvironmentForApiUrl(){} // RVA: 0x7FFD5727F100 | overloaded x2
        public void SendOfflineRequest(){} // RVA: 0x7FFD5727F3C0
        public void GenerateMergeCode(){} // RVA: 0x7FFD5727FA90
    }

    public class APICalendarEntryUserInterest : ApiModel
    {
        public bool isFollowing; // 0x68
        public DependencyInjector createdAt; // 0x70
        public DependencyInjector updatedAt; // 0x78

        // ── Methods ──
        public void get_isFollowing(){} // RVA: 0x7FFD4E409570
        public void set_isFollowing(){} // RVA: 0x7FFD4E409580
        public void get_createdAt(){} // RVA: 0x7FFD4E409590
        public void set_createdAt(){} // RVA: 0x7FFD4FE4BA60
        public void get_updatedAt(){} // RVA: 0x7FFD4E505600
        public void set_updatedAt(){} // RVA: 0x7FFD53666500
        public void .ctor(){} // RVA: 0x7FFD57332E90
    }

    public class APICampaignInfo : ApiModel
    {
        public object campaignActive;
        public object dataAvailable;
        public object endDate;
        public object globalGiftCount;
        public object globalGiftGoal;
        public object globalGiftGoalSuccess;
        public object globalParticipantCount;
        public object lastRefreshTime;
        public object localPurchaseCount;
        public object name;
        public object description;
        public object participatingFriends;
        public object rewards;
        public object startDate;
        public object globalDollarsGoal;
        public object globalDollarsRaised;
        public object globalPurchaseCount;
        public object includeGiftDrops;
        public object includeGifts;
        public object includeSubscriptions;
        public object slug;
        public object uDidIt;

        // ── Methods ──
        public void get_campaignActive(){} // RVA: 0x7FFD4E409570
        public void set_campaignActive(){} // RVA: 0x7FFD4E409580
        public void get_dataAvailable(){} // RVA: 0x7FFD4FA90BD0
        public void set_dataAvailable(){} // RVA: 0x7FFD4FA8E010
        public void get_endDate(){} // RVA: 0x7FFD4E409590
        public void set_endDate(){} // RVA: 0x7FFD4FE4BA60
        public void get_globalGiftCount(){} // RVA: 0x7FFD4F9B6EF0
        public void set_globalGiftCount(){} // RVA: 0x7FFD4F9B63A0
        public void get_globalGiftGoal(){} // RVA: 0x7FFD4F9B8F70
        public void set_globalGiftGoal(){} // RVA: 0x7FFD53E00310
        public void get_globalGiftGoalSuccess(){} // RVA: 0x7FFD4E55E620
        public void set_globalGiftGoalSuccess(){} // RVA: 0x7FFD4E55D3B0
        public void get_globalParticipantCount(){} // RVA: 0x7FFD4FAF5110
        public void set_globalParticipantCount(){} // RVA: 0x7FFD4FAF5150
        public void get_lastRefreshTime(){} // RVA: 0x7FFD4E380010
        public void set_lastRefreshTime(){} // RVA: 0x7FFD4E96E300
        public void get_localPurchaseCount(){} // RVA: 0x7FFD4E640660
        public void set_localPurchaseCount(){} // RVA: 0x7FFD4E8F2750
        public void get_name(){} // RVA: 0x7FFD4E96DFB0
        public void set_name(){} // RVA: 0x7FFD4E96E3C0
        public void get_description(){} // RVA: 0x7FFD4E963900
        public void set_description(){} // RVA: 0x7FFD4E96E420
        public void get_participatingFriends(){} // RVA: 0x7FFD4E96B1A0
        public void set_participatingFriends(){} // RVA: 0x7FFD4E76B370
        public void get_rewards(){} // RVA: 0x7FFD4E3AC040
        public void set_rewards(){} // RVA: 0x7FFD4E3AC050
        public void get_startDate(){} // RVA: 0x7FFD4E3AC0B0
        public void set_startDate(){} // RVA: 0x7FFD4F9E9F90
        public void get_globalDollarsGoal(){} // RVA: 0x7FFD4E55B720
        public void set_globalDollarsGoal(){} // RVA: 0x7FFD4E5634F0
        public void get_globalDollarsRaised(){} // RVA: 0x7FFD4FBF3250
        public void set_globalDollarsRaised(){} // RVA: 0x7FFD53D5FDA0
        public void get_globalPurchaseCount(){} // RVA: 0x7FFD4EA61480
        public void set_globalPurchaseCount(){} // RVA: 0x7FFD5165E970
        public void get_includeGiftDrops(){} // RVA: 0x7FFD4FB58E90
        public void set_includeGiftDrops(){} // RVA: 0x7FFD53E319A0
        public void get_includeGifts(){} // RVA: 0x7FFD4E752010
        public void set_includeGifts(){} // RVA: 0x7FFD5728A600
        public void get_includeSubscriptions(){} // RVA: 0x7FFD5728A610
        public void set_includeSubscriptions(){} // RVA: 0x7FFD5728A620
        public void get_slug(){} // RVA: 0x7FFD4E45E100
        public void set_slug(){} // RVA: 0x7FFD4E45E110
        public void get_uDidIt(){} // RVA: 0x7FFD4F1DD9E0
        public void set_uDidIt(){} // RVA: 0x7FFD53CE7210
        public void GetCampaignSummary(){} // RVA: 0x7FFD5728A630
        public void GetCampaignAnonymizationState(){} // RVA: 0x7FFD5728A830
        public void SetCampaignAnonymizationState(){} // RVA: 0x7FFD5728AB80
        public void GetCampaignLeaderboardFriends(){} // RVA: 0x7FFD5728B010
        public void GetCampaignLeaderboardGlobal(){} // RVA: 0x7FFD5728B080
        public void GetCampaignLeaderboard(){} // RVA: 0x7FFD5728B0F0
        public void .ctor(){} // RVA: 0x7FFD5728B430
    }

    public class APIEmoji : ApiModel
    {
        public string fileId; // 0x68
        public string imageUrl; // 0x70
        public string animationStyle; // 0x78
        public string maskTag; // 0x80
        public bool animated; // 0x88
        public int frames; // 0x8C
        public int framesOverTime; // 0x90
        public string loopStyle; // 0x98
        public string assetBundleId; // 0xA0
        public bool premium; // 0xA8
        public string endpoint;
        public string LOOP_STYLE_LINEAR;
        public string LOOP_STYLE_PINGPONG;

        // ── Methods ──
        public void get_fileId(){} // RVA: 0x7FFD4E3BCD50
        public void set_fileId(){} // RVA: 0x7FFD4E3BCD60
        public void get_imageUrl(){} // RVA: 0x7FFD4E409590
        public void set_imageUrl(){} // RVA: 0x7FFD4E4095A0
        public void get_animationStyle(){} // RVA: 0x7FFD4E505600
        public void set_animationStyle(){} // RVA: 0x7FFD4E5006F0
        public void get_maskTag(){} // RVA: 0x7FFD4E70F410
        public void set_maskTag(){} // RVA: 0x7FFD4E8F4AA0
        public void get_animated(){} // RVA: 0x7FFD4F2203A0
        public void set_animated(){} // RVA: 0x7FFD4F22C170
        public void get_frames(){} // RVA: 0x7FFD51376E80
        public void set_frames(){} // RVA: 0x7FFD519C0990
        public void get_framesOverTime(){} // RVA: 0x7FFD4E640660
        public void set_framesOverTime(){} // RVA: 0x7FFD4E8F2750
        public void get_loopStyle(){} // RVA: 0x7FFD4E96DFB0
        public void set_loopStyle(){} // RVA: 0x7FFD4E96E3C0
        public void get_assetBundleId(){} // RVA: 0x7FFD4E963900
        public void set_assetBundleId(){} // RVA: 0x7FFD4E96E420
        public void get_premium(){} // RVA: 0x7FFD4E561F10
        public void set_premium(){} // RVA: 0x7FFD4E55FE60
        public void UploadEmoji(){} // RVA: 0x7FFD5728D3C0 | overloaded x2
        public void Fetch(){} // RVA: 0x7FFD5728DA20
        public void .ctor(){} // RVA: 0x7FFD5728DD50
        public void <Fetch>g__ParseData|45_0(){} // RVA: 0x7FFD5728DDC0
    }

    public class APIGroup : ApiModel
    {
        public string ownerId; // 0x68
        public string name; // 0x70
        public string shortCode; // 0x78
        public string discriminator; // 0x80
        public string description; // 0x88
        public string iconUrl; // 0x90
        public string bannerUrl; // 0x98
        public int memberCount; // 0xA0
        public int onlineMemberCount; // 0xA4
        public string memberCountSyncedAt; // 0xA8
        public string privacy; // 0xB0
        public string joinState; // 0xB8
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.rms myMember; // 0xC0
        public DependencyInjector createdAt; // 0xC8
        public DependencyInjector updatedAt; // 0xD0
        public string membershipStatus; // 0xD8
        public string bannerId; // 0xE0
        public string iconId; // 0xE8
        public string rules; // 0xF0
        public URA.woDigitYearMax<string> initialRoleIds; // 0xF8
        public bool isSystemGroup; // 0x100
        public bool isVerified; // 0x101
        public URA.woDigitYearMax<ng> galleries; // 0x108
        public URA.woDigitYearMax<string> tags; // 0x110
        public bool isSearchable; // 0x118
        public int sizeQuality; // 0x11C
        public int activityQuality; // 0x120
        public int engagementQuality; // 0x124
        public int contentQuality; // 0x128
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.BackingField> roles; // 0x130
        public URA.woDigitYearMax<string> links; // 0x138
        public URA.woDigitYearMax<string> languages; // 0x140
        public DependencyInjector lastPostCreatedAt; // 0x148
        public string storeId; // 0x150

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57336030 | overloaded x2
        public void get_ownerId(){} // RVA: 0x7FFD4E3BCD50
        public void set_ownerId(){} // RVA: 0x7FFD4E3BCD60
        public void get_name(){} // RVA: 0x7FFD4E409590
        public void set_name(){} // RVA: 0x7FFD4E4095A0
        public void get_shortCode(){} // RVA: 0x7FFD4E505600
        public void set_shortCode(){} // RVA: 0x7FFD4E5006F0
        public void get_discriminator(){} // RVA: 0x7FFD4E70F410
        public void set_discriminator(){} // RVA: 0x7FFD4E8F4AA0
        public void get_description(){} // RVA: 0x7FFD4E380010
        public void set_description(){} // RVA: 0x7FFD4E96E300
        public void get_iconUrl(){} // RVA: 0x7FFD4E70F640
        public void set_iconUrl(){} // RVA: 0x7FFD4E96E360
        public void get_bannerUrl(){} // RVA: 0x7FFD4E96DFB0
        public void set_bannerUrl(){} // RVA: 0x7FFD4E96E3C0
        public void get_memberCount(){} // RVA: 0x7FFD4FCBE510
        public void set_memberCount(){} // RVA: 0x7FFD4FCBE550
        public void get_onlineMemberCount(){} // RVA: 0x7FFD51959470
        public void set_onlineMemberCount(){} // RVA: 0x7FFD51959480
        public void get_memberCountSyncedAt(){} // RVA: 0x7FFD4E96B1A0
        public void set_memberCountSyncedAt(){} // RVA: 0x7FFD4E76B370
        public void get_privacy(){} // RVA: 0x7FFD4E3AC040
        public void set_privacy(){} // RVA: 0x7FFD4E3AC050
        public void get_joinState(){} // RVA: 0x7FFD4E3AC0B0
        public void set_joinState(){} // RVA: 0x7FFD4E3AC0C0
        public void get_myMember(){} // RVA: 0x7FFD4E3AC120
        public void set_myMember(){} // RVA: 0x7FFD4E3AC130
        public void get_createdAt(){} // RVA: 0x7FFD4E499460
        public void set_createdAt(){} // RVA: 0x7FFD56D990D0
        public void get_updatedAt(){} // RVA: 0x7FFD4E45E100
        public void set_updatedAt(){} // RVA: 0x7FFD5448B850
        public void get_membershipStatus(){} // RVA: 0x7FFD4E960F70
        public void set_membershipStatus(){} // RVA: 0x7FFD4E3C28A0
        public void get_bannerId(){} // RVA: 0x7FFD4E3C2900
        public void set_bannerId(){} // RVA: 0x7FFD4E3C2910
        public void get_iconId(){} // RVA: 0x7FFD4E3C2970
        public void set_iconId(){} // RVA: 0x7FFD4E3C2980
        public void get_rules(){} // RVA: 0x7FFD4E3AC2A0
        public void set_rules(){} // RVA: 0x7FFD4E3AC2B0
        public void get_initialRoleIds(){} // RVA: 0x7FFD4E751F50
        public void set_initialRoleIds(){} // RVA: 0x7FFD4E8C4860
        public void get_isSystemGroup(){} // RVA: 0x7FFD4F0AB9C0
        public void set_isSystemGroup(){} // RVA: 0x7FFD4F0ADFF0
        public void get_isVerified(){} // RVA: 0x7FFD4F9EA040
        public void set_isVerified(){} // RVA: 0x7FFD4F9E9D10
        public void get_galleries(){} // RVA: 0x7FFD4EAF1F40
        public void set_galleries(){} // RVA: 0x7FFD4ED49BF0
        public void get_tags(){} // RVA: 0x7FFD4E96B170
        public void set_tags(){} // RVA: 0x7FFD4EDD3E10
        public void get_isSearchable(){} // RVA: 0x7FFD572E2310
        public void set_isSearchable(){} // RVA: 0x7FFD572E2320
        public void get_sizeQuality(){} // RVA: 0x7FFD54F1AC70
        public void set_sizeQuality(){} // RVA: 0x7FFD54F1AC80
        public void get_activityQuality(){} // RVA: 0x7FFD53E31640
        public void set_activityQuality(){} // RVA: 0x7FFD53E31650
        public void get_engagementQuality(){} // RVA: 0x7FFD53CF4E90
        public void set_engagementQuality(){} // RVA: 0x7FFD53CF4EA0
        public void get_contentQuality(){} // RVA: 0x7FFD53E319F0
        public void set_contentQuality(){} // RVA: 0x7FFD53E31A00
        public void get_roles(){} // RVA: 0x7FFD4E964340
        public void set_roles(){} // RVA: 0x7FFD4EDC79B0
        public void get_links(){} // RVA: 0x7FFD4E9622C0
        public void set_links(){} // RVA: 0x7FFD4EAF84B0
        public void get_languages(){} // RVA: 0x7FFD4E3AC5F0
        public void set_languages(){} // RVA: 0x7FFD4E3AC600
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFD4E3AC660
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFD53E53F90
        public void get_storeId(){} // RVA: 0x7FFD4E96DFA0
        public void set_storeId(){} // RVA: 0x7FFD4EDD99C0
        public void UpdateData(){} // RVA: 0x7FFD57336650
        public void GetGroup(){} // RVA: 0x7FFD573370C0
        public void FetchAllData(){} // RVA: 0x7FFD573372C0
        public void RequestToJoin(){} // RVA: 0x7FFD57337760
        public void LeaveGroup(){} // RVA: 0x7FFD57337B20
        public void GetGroupInvites(){} // RVA: 0x7FFD57337EA0
        public void InviteUser(){} // RVA: 0x7FFD57338320
        public void BanUser(){} // RVA: 0x7FFD57338750
        public void GetMembers(){} // RVA: 0x7FFD57338B80
        public void GetGroupCapacity(){} // RVA: 0x7FFD57339150
        public void SetRepresentation(){} // RVA: 0x7FFD57339270
        public void GetGroupGalleryImages(){} // RVA: 0x7FFD57339700
        public void GetGroupProducts(){} // RVA: 0x7FFD5733A220
        public void GetGroupAnnouncements(){} // RVA: 0x7FFD5733A660
        public void SetAnnouncementSubscription(){} // RVA: 0x7FFD5733ABE0
        public void SetEventAnnouncementSubscription(){} // RVA: 0x7FFD5733B040
        public void GetUsingShortCode(){} // RVA: 0x7FFD5733B4A0
        public void StrictSearch(){} // RVA: 0x7FFD5733B7C0
        public void GetActiveGroupInstances(){} // RVA: 0x7FFD5733BC30
        public void GetRoles(){} // RVA: 0x7FFD5733C090
        public void GetAllGroupPermissions(){} // RVA: 0x7FFD5733C4B0
        public void GetGroupPermissions(){} // RVA: 0x7FFD5733C7E0
        public void ExtractPermissions(){} // RVA: 0x7FFD5733CC50
    }

    public class APIGroupAnnouncement : ApiModel
    {
        public string groupId; // 0x68
        public string authorId; // 0x70
        public string title; // 0x78
        public string text; // 0x80
        public string imageUrl; // 0x88
        public string visibility; // 0x90
        public DependencyInjector createdAt; // 0x98
        public DependencyInjector updatedAt; // 0xA0
        public URA.woDigitYearMax<string> roleIds; // 0xA8

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFD4E3BCD50
        public void set_groupId(){} // RVA: 0x7FFD4E3BCD60
        public void get_authorId(){} // RVA: 0x7FFD4E409590
        public void set_authorId(){} // RVA: 0x7FFD4E4095A0
        public void get_title(){} // RVA: 0x7FFD4E505600
        public void set_title(){} // RVA: 0x7FFD4E5006F0
        public void get_text(){} // RVA: 0x7FFD4E70F410
        public void set_text(){} // RVA: 0x7FFD4E8F4AA0
        public void get_imageUrl(){} // RVA: 0x7FFD4E380010
        public void set_imageUrl(){} // RVA: 0x7FFD4E96E300
        public void get_visibility(){} // RVA: 0x7FFD4E70F640
        public void set_visibility(){} // RVA: 0x7FFD4E96E360
        public void get_createdAt(){} // RVA: 0x7FFD4E96DFB0
        public void set_createdAt(){} // RVA: 0x7FFD53221AA0
        public void get_updatedAt(){} // RVA: 0x7FFD4E963900
        public void set_updatedAt(){} // RVA: 0x7FFD53BAD950
        public void get_roleIds(){} // RVA: 0x7FFD4E96B1A0
        public void set_roleIds(){} // RVA: 0x7FFD4E76B370
        public void SetLastPostReadAt(){} // RVA: 0x7FFD5733E740
        public void .ctor(){} // RVA: 0x7FFD5733EB50
    }

    public class APIGroupList : ApiModel
    {
        public string ownerId; // 0x68
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.<pastDisplayNames>k__BackingField> groups; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5733EFD0 | overloaded x2
    }

    public class APIGroupMember : ApiModel
    {
        public string groupId; // 0x68
        public string userId; // 0x70
        public URA.woDigitYearMax<string> roleIds; // 0x78
        public URA.woDigitYearMax<string> mRoleIds; // 0x80
        public URA.woDigitYearMax<string> permissions; // 0x88
        public string memberVisibility; // 0x90
        public string membershipStatus; // 0x98
        public bool isRepresenting; // 0xA0
        public bool mutualGroup; // 0xA1
        public string name; // 0xA8
        public string ownerId; // 0xB0
        public string shortCode; // 0xB8
        public string discriminator; // 0xC0
        public string iconUrl; // 0xC8
        public string bannerUrl; // 0xD0
        public string privacy; // 0xD8
        public string visibility; // 0xE0
        public bool isSubscribedToAnnouncements; // 0xE8
        public bool isSubscribedToEventAnnouncements; // 0xE9
        public int memberCount; // 0xEC
        public DependencyInjector joinedAt; // 0xF0
        public DependencyInjector bannedAt; // 0xF8
        public DependencyInjector lastPostReadAt; // 0x100
        public DependencyInjector lastPostCreatedAt; // 0x108
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.reated user; // 0x110
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.<pastDisplayNames>k__BackingField group; // 0x118

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5733F8B0
        public void get_groupId(){} // RVA: 0x7FFD4E3BCD50
        public void set_groupId(){} // RVA: 0x7FFD4E3BCD60
        public void get_userId(){} // RVA: 0x7FFD4E409590
        public void set_userId(){} // RVA: 0x7FFD4E4095A0
        public void get_roleIds(){} // RVA: 0x7FFD4E505600
        public void set_roleIds(){} // RVA: 0x7FFD4E5006F0
        public void get_mRoleIds(){} // RVA: 0x7FFD4E70F410
        public void set_mRoleIds(){} // RVA: 0x7FFD4E8F4AA0
        public void get_permissions(){} // RVA: 0x7FFD4E380010
        public void set_permissions(){} // RVA: 0x7FFD4E96E300
        public void get_memberVisibility(){} // RVA: 0x7FFD4E70F640
        public void set_memberVisibility(){} // RVA: 0x7FFD4E96E360
        public void get_membershipStatus(){} // RVA: 0x7FFD4E96DFB0
        public void set_membershipStatus(){} // RVA: 0x7FFD4E96E3C0
        public void get_isRepresenting(){} // RVA: 0x7FFD4F9E9D50
        public void set_isRepresenting(){} // RVA: 0x7FFD4EBD1910
        public void get_mutualGroup(){} // RVA: 0x7FFD4FC68B60
        public void set_mutualGroup(){} // RVA: 0x7FFD4FC68B70
        public void get_name(){} // RVA: 0x7FFD4E96B1A0
        public void set_name(){} // RVA: 0x7FFD4E76B370
        public void get_ownerId(){} // RVA: 0x7FFD4E3AC040
        public void set_ownerId(){} // RVA: 0x7FFD4E3AC050
        public void get_shortCode(){} // RVA: 0x7FFD4E3AC0B0
        public void set_shortCode(){} // RVA: 0x7FFD4E3AC0C0
        public void get_discriminator(){} // RVA: 0x7FFD4E3AC120
        public void set_discriminator(){} // RVA: 0x7FFD4E3AC130
        public void get_iconUrl(){} // RVA: 0x7FFD4E499460
        public void set_iconUrl(){} // RVA: 0x7FFD4E499470
        public void get_bannerUrl(){} // RVA: 0x7FFD4E45E100
        public void set_bannerUrl(){} // RVA: 0x7FFD4E45E110
        public void get_privacy(){} // RVA: 0x7FFD4E960F70
        public void set_privacy(){} // RVA: 0x7FFD4E3C28A0
        public void get_visibility(){} // RVA: 0x7FFD4E3C2900
        public void set_visibility(){} // RVA: 0x7FFD4E3C2910
        public void get_isSubscribedToAnnouncements(){} // RVA: 0x7FFD4F3F4640
        public void set_isSubscribedToAnnouncements(){} // RVA: 0x7FFD4FDBC5B0
        public void get_isSubscribedToEventAnnouncements(){} // RVA: 0x7FFD54262E60
        public void set_isSubscribedToEventAnnouncements(){} // RVA: 0x7FFD572E7A40
        public void get_memberCount(){} // RVA: 0x7FFD4FBF3260
        public void set_memberCount(){} // RVA: 0x7FFD53E31620
        public void get_joinedAt(){} // RVA: 0x7FFD4E3AC2A0
        public void set_joinedAt(){} // RVA: 0x7FFD4FB667B0
        public void get_bannedAt(){} // RVA: 0x7FFD4E751F50
        public void set_bannedAt(){} // RVA: 0x7FFD51B35870
        public void get_lastPostReadAt(){} // RVA: 0x7FFD4E916C80
        public void set_lastPostReadAt(){} // RVA: 0x7FFD4F5B6020
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFD4EAF1F40
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFD57284CE0
        public void get_user(){} // RVA: 0x7FFD4E96B170
        public void set_user(){} // RVA: 0x7FFD4EDD3E10
        public void get_group(){} // RVA: 0x7FFD4E7DC6D0
        public void set_group(){} // RVA: 0x7FFD4E7D8580
        public void GetMemberships(){} // RVA: 0x7FFD5733F910
        public void SetVisibility(){} // RVA: 0x7FFD5733FCF0
        public void FetchGroup(){} // RVA: 0x7FFD573401B0
        public void GetRepresentation(){} // RVA: 0x7FFD57340500
    }

    public class APIGroupMemberList : ApiModel
    {
        public string groupId; // 0x68
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.rms> members; // 0x70

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFD4E3BCD50
        public void set_groupId(){} // RVA: 0x7FFD4E3BCD60
        public void get_members(){} // RVA: 0x7FFD4E409590
        public void set_members(){} // RVA: 0x7FFD4E4095A0
        public void .ctor(){} // RVA: 0x7FFD57340C90 | overloaded x2
    }

    public class APIGroupRole : ApiModel
    {
        public string groupId; // 0x68
        public string name; // 0x70
        public string description; // 0x78
        public bool isSelfAssignable; // 0x80
        public bool requiresTwoFactor; // 0x81
        public bool isManagementRole; // 0x82
        public bool requiresPurchase; // 0x83
        public DependencyInjector createdAt; // 0x88
        public DependencyInjector updatedAt; // 0x90
        public bool defaultRole; // 0x98
        public int order; // 0x9C
        public URA.woDigitYearMax<string> permissions; // 0xA0

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFD4E3BCD50
        public void set_groupId(){} // RVA: 0x7FFD4E3BCD60
        public void get_name(){} // RVA: 0x7FFD4E409590
        public void set_name(){} // RVA: 0x7FFD4E4095A0
        public void get_description(){} // RVA: 0x7FFD4E505600
        public void set_description(){} // RVA: 0x7FFD4E5006F0
        public void get_isSelfAssignable(){} // RVA: 0x7FFD4E55E620
        public void set_isSelfAssignable(){} // RVA: 0x7FFD4E55D3B0
        public void get_requiresTwoFactor(){} // RVA: 0x7FFD4E55DE70
        public void set_requiresTwoFactor(){} // RVA: 0x7FFD4E563D90
        public void get_isManagementRole(){} // RVA: 0x7FFD4EFFEE90
        public void set_isManagementRole(){} // RVA: 0x7FFD53B50670
        public void get_requiresPurchase(){} // RVA: 0x7FFD4F3C38F0
        public void set_requiresPurchase(){} // RVA: 0x7FFD53BAD710
        public void get_createdAt(){} // RVA: 0x7FFD4E380010
        public void set_createdAt(){} // RVA: 0x7FFD4FE4BA70
        public void get_updatedAt(){} // RVA: 0x7FFD4E70F640
        public void set_updatedAt(){} // RVA: 0x7FFD4EB25AA0
        public void get_defaultRole(){} // RVA: 0x7FFD4E7BA7F0
        public void set_defaultRole(){} // RVA: 0x7FFD4E7BFA20
        public void get_order(){} // RVA: 0x7FFD4FCBE520
        public void set_order(){} // RVA: 0x7FFD4FCBEAA0
        public void get_permissions(){} // RVA: 0x7FFD4E963900
        public void set_permissions(){} // RVA: 0x7FFD4E96E420
        public void .ctor(){} // RVA: 0x7FFD57340DF0 | overloaded x2
    }

    public class APIGroupRoleList : ApiModel
    {
        public string groupId; // 0x68
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.BackingField> roles; // 0x70

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFD4E3BCD50
        public void set_groupId(){} // RVA: 0x7FFD4E3BCD60
        public void get_roles(){} // RVA: 0x7FFD4E409590
        public void set_roles(){} // RVA: 0x7FFD4E4095A0
        public void .ctor(){} // RVA: 0x7FFD57341100 | overloaded x2
    }

    public class APISticker : ApiModel
    {
        public string fileId; // 0x68
        public string imageUrl; // 0x70
        public string specialEffect; // 0x78
        public string animationStyle; // 0x80
        public string maskTag; // 0x88
        public bool animated; // 0x90
        public int frames; // 0x94
        public int framesOverTime; // 0x98
        public string loopStyle; // 0xA0
        public string assetBundleId; // 0xA8
        public string endpoint;

        // ── Methods ──
        public void get_fileId(){} // RVA: 0x7FFD4E3BCD50
        public void set_fileId(){} // RVA: 0x7FFD4E3BCD60
        public void get_imageUrl(){} // RVA: 0x7FFD4E409590
        public void set_imageUrl(){} // RVA: 0x7FFD4E4095A0
        public void get_specialEffect(){} // RVA: 0x7FFD4E505600
        public void set_specialEffect(){} // RVA: 0x7FFD4E5006F0
        public void get_animationStyle(){} // RVA: 0x7FFD4E70F410
        public void set_animationStyle(){} // RVA: 0x7FFD4E8F4AA0
        public void get_maskTag(){} // RVA: 0x7FFD4E380010
        public void set_maskTag(){} // RVA: 0x7FFD4E96E300
        public void get_animated(){} // RVA: 0x7FFD4F22D160
        public void set_animated(){} // RVA: 0x7FFD4F2289B0
        public void get_frames(){} // RVA: 0x7FFD4E640670
        public void set_frames(){} // RVA: 0x7FFD4E84B670
        public void get_framesOverTime(){} // RVA: 0x7FFD4FCBE530
        public void set_framesOverTime(){} // RVA: 0x7FFD4FCBE540
        public void get_loopStyle(){} // RVA: 0x7FFD4E963900
        public void set_loopStyle(){} // RVA: 0x7FFD4E96E420
        public void get_assetBundleId(){} // RVA: 0x7FFD4E96B1A0
        public void set_assetBundleId(){} // RVA: 0x7FFD4E76B370
        public void UploadSticker(){} // RVA: 0x7FFD572F2FD0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD572F35E0
    }

    public class APITutorial : ApiModel
    {
        public string IsTutorialCompleted;
        public bool CompletedAnyTutorial; // 0x68
        public bool TutorialKey; // 0x69
        public string <TutorialKey>k__BackingField; // 0x70

        // ── Methods ──
        public void get_IsTutorialCompleted(){} // RVA: 0x7FFD4E409570
        public void set_IsTutorialCompleted(){} // RVA: 0x7FFD4E409580
        public void get_CompletedAnyTutorial(){} // RVA: 0x7FFD4FA90BD0
        public void set_CompletedAnyTutorial(){} // RVA: 0x7FFD4FA8E010
        public void get_TutorialKey(){} // RVA: 0x7FFD4E409590
        public void set_TutorialKey(){} // RVA: 0x7FFD4E4095A0
        public void LoadTutorial(){} // RVA: 0x7FFD572F60C0
        public void .ctor(){} // RVA: 0x7FFD572F63D0
    }

    public class APIUIColorPalette : ApiModel
    {
        public string ownerId; // 0x68
        public string name; // 0x70
        public string highlights; // 0x78
        public string icons; // 0x80
        public string buttons; // 0x88
        public string backgrounds; // 0x90
        public string text; // 0x98
        public string subtext; // 0xA0
        public string endpoint;
        public string endpoint_current;
        public URA.DateTime<string,ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.riginalError> _fakeApi;

        // ── Methods ──
        public void get_ownerId(){} // RVA: 0x7FFD4E3BCD50
        public void set_ownerId(){} // RVA: 0x7FFD4E3BCD60
        public void get_name(){} // RVA: 0x7FFD4E409590
        public void set_name(){} // RVA: 0x7FFD4E4095A0
        public void get_highlights(){} // RVA: 0x7FFD4E505600
        public void set_highlights(){} // RVA: 0x7FFD4E5006F0
        public void get_icons(){} // RVA: 0x7FFD4E70F410
        public void set_icons(){} // RVA: 0x7FFD4E8F4AA0
        public void get_buttons(){} // RVA: 0x7FFD4E380010
        public void set_buttons(){} // RVA: 0x7FFD4E96E300
        public void get_backgrounds(){} // RVA: 0x7FFD4E70F640
        public void set_backgrounds(){} // RVA: 0x7FFD4E96E360
        public void get_text(){} // RVA: 0x7FFD4E96DFB0
        public void set_text(){} // RVA: 0x7FFD4E96E3C0
        public void get_subtext(){} // RVA: 0x7FFD4E963900
        public void set_subtext(){} // RVA: 0x7FFD4E96E420
        public void Fetch(){} // RVA: 0x7FFD572F6570
        public void Save(){} // RVA: 0x7FFD572F6920
        public void GetCurrent(){} // RVA: 0x7FFD572F7200
        public void SetCurrent(){} // RVA: 0x7FFD572F74E0
        public void Update(){} // RVA: 0x7FFD572F78D0
        public void .ctor(){} // RVA: 0x7FFD572F7C10
        public void .cctor(){} // RVA: 0x7FFD572F7C60
    }

    public class APIUser : ApiModel
    {
        public float blob;
        public float displayName;
        public int username;
        public int pronouns;
        public string bio;
        public string bioLinks;
        public string location;
        public string avatarId;
        public string fallbackId;
        public string hasEmail;
        public string isBoopingEnabled;
        public string hasBirthday;
        public string isFriend;
        public string friendKey;
        public string friendRequestStatus; // 0x68
        public string last_login; // 0x70
        public string last_activity; // 0x78
        public string date_joined; // 0x80
        public string developerType; // 0x88
        public URA.woDigitYearMax<string> events; // 0x90
        public string acceptedTOSVersion; // 0x98
        public string queuedInstance; // 0xA0
        public string queuedInstancePosition; // 0xA8
        public bool acceptedPrivacyVersion; // 0xB0
        public bool currentAvatarImageUrl; // 0xB1
        public bool currentAvatarThumbnailImageUrl; // 0xB2
        public bool currentAvatarTags; // 0xB3
        public string authToken; // 0xB8
        public string emailVerified; // 0xC0
        public string hasPendingEmail; // 0xC8
        public string obfuscatedPendingEmail; // 0xD0
        public string friendIDs; // 0xD8
        public seCancelSubscriptionInfo currentAvatarAssetUrl; // 0xE0
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.k__BackingField> steamDetails; // 0xE8
        public int travelingToLocation; // 0xF0
        public string obfuscatedEmail; // 0xF8
        public int unsubscribe; // 0x100
        public int hasLoggedInFromClient; // 0x104
        public string pastDisplayNames; // 0x108
        public string homeLocation; // 0x110
        public URA.woDigitYearMax<string> tags; // 0x118
        public string status; // 0x120
        public bool statusDescription; // 0x128
        public bool badges; // 0x129
        public string statusHistory; // 0x130
        public URA.woDigitYearMax<string> state; // 0x138
        public string allowAvatarCopying; // 0x140
        public URA.DateTime<string,object> hasSharedConnectionsOptOut; // 0x148
        public string hasDiscordFriendsOptOut; // 0x150
        public string userIcon; // 0x158
        public bool profilePicOverride; // 0x160
        public bool note; // 0x161
        public URA.woDigitYearMax<string> iconUrl; // 0x168
        public string thumbnailUrl; // 0x170
        public URA.woDigitYearMax<string> hideContentFilterSettings; // 0x178
        public string contentFilters; // 0x180
        public string userLanguageCode; // 0x188
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.eBlocks> ageVerified; // 0x190
        public URA.woDigitYearMax<string> isAdult; // 0x198
        public string ageVerificationStatus; // 0x1A0
        public bool discordId; // 0x1A8
        public bool hasAcceptedDiscordSocialSDKPerms; // 0x1A9
        public bool last_platform; // 0x1AA
        public string platform; // 0x1B0
        public string last_mobile; // 0x1B8
        public string twoFactorAuthEnabled; // 0x1C0
        public string twoFactorAuthMethods; // 0x1C8
        public string LanguageTagsDictionary; // 0x1D0
        public bool languagesDisplayNames; // 0x1D8
        public URA.woDigitYearMax<string> LanguagesShortNames; // 0x1E0
        public string ShouldSeeInstanceByStatus; // 0x1E8
        public bool IsOnMobile; // 0x1F0
        public bool profilePicImageUrl; // 0x1F1
        public string profilePicThumbnailImageUrl; // 0x1F8
        public string IsAccountVerified; // 0x200
        public bool hasNoPowers; // 0x208
        public string hasScriptingAccess; // 0x210
        public string hasModerationPowers; // 0x218
        public string hasVIPAccess; // 0x220
        public bool hasSuperPowers; // 0x228
        public URA.DateTime<string,object> canPublishWorldsAndAvatars; // 0x230
        public URA.DateTime<string,string> canPublishAllContent;
        public URA.woDigitYearMax<string> canPublishAvatars; // 0x238
        public URA.woDigitYearMax<string> canPublishWorlds; // 0x240
        public mePatterns.MES_SIZE canPublishProps; // 0x8
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.reated isUntrusted; // 0x10

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFD572F7F60
        public void GetLifeSpan(){} // RVA: 0x7FFD4F29E010
        public void get_blob(){} // RVA: 0x7FFD4E3BCD50
        public void set_blob(){} // RVA: 0x7FFD4E3BCD60
        public void get_displayName(){} // RVA: 0x7FFD4E409590
        public void set_displayName(){} // RVA: 0x7FFD4E4095A0
        public void get_username(){} // RVA: 0x7FFD4E505600
        public void set_username(){} // RVA: 0x7FFD4E5006F0
        public void get_pronouns(){} // RVA: 0x7FFD4E70F410
        public void set_pronouns(){} // RVA: 0x7FFD4E8F4AA0
        public void get_bio(){} // RVA: 0x7FFD4E380010
        public void set_bio(){} // RVA: 0x7FFD4E96E300
        public void get_bioLinks(){} // RVA: 0x7FFD4E70F640
        public void set_bioLinks(){} // RVA: 0x7FFD4E96E360
        public void get_location(){} // RVA: 0x7FFD4E96DFB0
        public void set_location(){} // RVA: 0x7FFD4E96E3C0
        public void get_avatarId(){} // RVA: 0x7FFD4E963900
        public void set_avatarId(){} // RVA: 0x7FFD4E96E420
        public void get_fallbackId(){} // RVA: 0x7FFD4E96B1A0
        public void set_fallbackId(){} // RVA: 0x7FFD4E76B370
        public void get_hasEmail(){} // RVA: 0x7FFD4F6071E0
        public void set_hasEmail(){} // RVA: 0x7FFD4F606D30
        public void get_isBoopingEnabled(){} // RVA: 0x7FFD519594B0
        public void set_isBoopingEnabled(){} // RVA: 0x7FFD519594C0
        public void get_hasBirthday(){} // RVA: 0x7FFD53D5FD30
        public void set_hasBirthday(){} // RVA: 0x7FFD53D5FD40
        public void get_isFriend(){} // RVA: 0x7FFD53D5FD50
        public void set_isFriend(){} // RVA: 0x7FFD53D5FD60
        public void get_friendKey(){} // RVA: 0x7FFD4E3AC0B0
        public void set_friendKey(){} // RVA: 0x7FFD4E3AC0C0
        public void get_friendRequestStatus(){} // RVA: 0x7FFD4E3AC120
        public void set_friendRequestStatus(){} // RVA: 0x7FFD4E3AC130
        public void get_last_login(){} // RVA: 0x7FFD4E499460
        public void set_last_login(){} // RVA: 0x7FFD4E499470
        public void get_last_activity(){} // RVA: 0x7FFD4E45E100
        public void set_last_activity(){} // RVA: 0x7FFD4E45E110
        public void get_date_joined(){} // RVA: 0x7FFD4E960F70
        public void set_date_joined(){} // RVA: 0x7FFD4E3C28A0
        public void get_developerType(){} // RVA: 0x7FFD4FC57F50
        public void set_developerType(){} // RVA: 0x7FFD4FC57F60
        public void get_events(){} // RVA: 0x7FFD4E3C2970
        public void set_events(){} // RVA: 0x7FFD4E3C2980
        public void get_acceptedTOSVersion(){} // RVA: 0x7FFD514A55D0
        public void set_acceptedTOSVersion(){} // RVA: 0x7FFD53E31630
        public void get_queuedInstance(){} // RVA: 0x7FFD4E751F50
        public void set_queuedInstance(){} // RVA: 0x7FFD4E8C4860
        public void get_queuedInstancePosition(){} // RVA: 0x7FFD540268C0
        public void set_queuedInstancePosition(){} // RVA: 0x7FFD5509A8E0
        public void get_acceptedPrivacyVersion(){} // RVA: 0x7FFD4FBD0110
        public void set_acceptedPrivacyVersion(){} // RVA: 0x7FFD4F93E020
        public void get_currentAvatarImageUrl(){} // RVA: 0x7FFD4EAF1F40
        public void set_currentAvatarImageUrl(){} // RVA: 0x7FFD4ED49BF0
        public void get_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFD4E96B170
        public void set_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFD4EDD3E10
        public void get_currentAvatarTags(){} // RVA: 0x7FFD4E7DC6D0
        public void set_currentAvatarTags(){} // RVA: 0x7FFD4E7D8580
        public void get_authToken(){} // RVA: 0x7FFD4E55CBB0
        public void set_authToken(){} // RVA: 0x7FFD4E563400
        public void get_emailVerified(){} // RVA: 0x7FFD4E751A00
        public void set_emailVerified(){} // RVA: 0x7FFD4E74DA60
        public void get_hasPendingEmail(){} // RVA: 0x7FFD572F7FC0
        public void set_hasPendingEmail(){} // RVA: 0x7FFD572F7FD0
        public void get_obfuscatedPendingEmail(){} // RVA: 0x7FFD4E964340
        public void set_obfuscatedPendingEmail(){} // RVA: 0x7FFD4EDC79B0
        public void get_friendIDs(){} // RVA: 0x7FFD4E9622C0
        public void set_friendIDs(){} // RVA: 0x7FFD4EAF84B0
        public void get_currentAvatarAssetUrl(){} // RVA: 0x7FFD4E3AC5F0
        public void set_currentAvatarAssetUrl(){} // RVA: 0x7FFD4E3AC600
        public void get_steamDetails(){} // RVA: 0x7FFD4E3AC660
        public void set_steamDetails(){} // RVA: 0x7FFD4E3AC670
        public void get_travelingToLocation(){} // RVA: 0x7FFD4E96DFA0
        public void set_travelingToLocation(){} // RVA: 0x7FFD4EDD99C0
        public void get_obfuscatedEmail(){} // RVA: 0x7FFD4E962410
        public void set_obfuscatedEmail(){} // RVA: 0x7FFD4EDC74B0
        public void get_unsubscribe(){} // RVA: 0x7FFD53E319B0
        public void set_unsubscribe(){} // RVA: 0x7FFD53E319C0
        public void get_hasLoggedInFromClient(){} // RVA: 0x7FFD53E319D0
        public void set_hasLoggedInFromClient(){} // RVA: 0x7FFD53E319E0
        public void get_pastDisplayNames(){} // RVA: 0x7FFD4E96E2F0
        public void set_pastDisplayNames(){} // RVA: 0x7FFD4EDC80B0
        public void get_homeLocation(){} // RVA: 0x7FFD4E78D850
        public void set_homeLocation(){} // RVA: 0x7FFD4EDD5DB0
        public void get_tags(){} // RVA: 0x7FFD4E78D860
        public void set_tags(){} // RVA: 0x7FFD572F7FE0
        public void get_status(){} // RVA: 0x7FFD4E96B1B0
        public void set_status(){} // RVA: 0x7FFD4E923070
        public void get_statusDescription(){} // RVA: 0x7FFD4E9610C0
        public void set_statusDescription(){} // RVA: 0x7FFD4E923010
        public void get_badges(){} // RVA: 0x7FFD4E960F60
        public void set_badges(){} // RVA: 0x7FFD4EDCB1D0
        public void get_statusHistory(){} // RVA: 0x7FFD4E961C80
        public void set_statusHistory(){} // RVA: 0x7FFD4EDE8ED0
        public void get_state(){} // RVA: 0x7FFD4E96E2E0
        public void set_state(){} // RVA: 0x7FFD4EDC8AF0
        public void get_allowAvatarCopying(){} // RVA: 0x7FFD54089570
        public void set_allowAvatarCopying(){} // RVA: 0x7FFD54089580
        public void get_hasSharedConnectionsOptOut(){} // RVA: 0x7FFD54089590
        public void set_hasSharedConnectionsOptOut(){} // RVA: 0x7FFD540895A0
        public void get_hasDiscordFriendsOptOut(){} // RVA: 0x7FFD540895F0
        public void set_hasDiscordFriendsOptOut(){} // RVA: 0x7FFD54089600
        public void get_userIcon(){} // RVA: 0x7FFD4E969F30
        public void set_userIcon(){} // RVA: 0x7FFD4EDC7790
        public void get_profilePicOverride(){} // RVA: 0x7FFD4E964330
        public void set_profilePicOverride(){} // RVA: 0x7FFD4EDCC050
        public void get_note(){} // RVA: 0x7FFD4E9622B0
        public void set_note(){} // RVA: 0x7FFD4EDCD110
        public void get_iconUrl(){} // RVA: 0x7FFD4EDECB10
        public void set_iconUrl(){} // RVA: 0x7FFD4EDEF3F0
        public void get_thumbnailUrl(){} // RVA: 0x7FFD4EDE1920
        public void set_thumbnailUrl(){} // RVA: 0x7FFD4EDC8050
        public void get_hideContentFilterSettings(){} // RVA: 0x7FFD4FBE42D0
        public void set_hideContentFilterSettings(){} // RVA: 0x7FFD4FBE42E0
        public void get_contentFilters(){} // RVA: 0x7FFD4E818150
        public void set_contentFilters(){} // RVA: 0x7FFD4EDD1270
        public void get_userLanguageCode(){} // RVA: 0x7FFD4EDD1060
        public void set_userLanguageCode(){} // RVA: 0x7FFD4EDCC5A0
        public void get_ageVerified(){} // RVA: 0x7FFD5408C140
        public void set_ageVerified(){} // RVA: 0x7FFD572F8050
        public void get_isAdult(){} // RVA: 0x7FFD572F8060
        public void set_isAdult(){} // RVA: 0x7FFD572F8070
        public void get_ageVerificationStatus(){} // RVA: 0x7FFD4E961460
        public void set_ageVerificationStatus(){} // RVA: 0x7FFD4E964450
        public void get_discordId(){} // RVA: 0x7FFD4E964790
        public void set_discordId(){} // RVA: 0x7FFD4E96D230
        public void get_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x7FFD54064960
        public void set_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x7FFD572F8080
        public void get_last_platform(){} // RVA: 0x7FFD4E96BCB0
        public void set_last_platform(){} // RVA: 0x7FFD572F8090
        public void get_platform(){} // RVA: 0x7FFD4E961470
        public void set_platform(){} // RVA: 0x7FFD4E962420
        public void get_last_mobile(){} // RVA: 0x7FFD4E9693F0
        public void set_last_mobile(){} // RVA: 0x7FFD4E96AC80
        public void get_twoFactorAuthEnabled(){} // RVA: 0x7FFD544CDC00
        public void set_twoFactorAuthEnabled(){} // RVA: 0x7FFD572F8210
        public void get_twoFactorAuthMethods(){} // RVA: 0x7FFD4E962820
        public void set_twoFactorAuthMethods(){} // RVA: 0x7FFD4EDE7D40
        public void get_LanguageTagsDictionary(){} // RVA: 0x7FFD572F8220
        public void get_languagesDisplayNames(){} // RVA: 0x7FFD4E9613D0
        public void set_languagesDisplayNames(){} // RVA: 0x7FFD4EDCA7F0
        public void set_LanguagesShortNames(){} // RVA: 0x7FFD4EDD5A80
        public void get_LanguagesShortNames(){} // RVA: 0x7FFD4EDE9150
        public void SetUserLanguages(){} // RVA: 0x7FFD572F86B0
        public void get_ShouldSeeInstanceByStatus(){} // RVA: 0x7FFD572F8A70
        public void get_IsOnMobile(){} // RVA: 0x7FFD572F8AB0
        public void get_profilePicImageUrl(){} // RVA: 0x7FFD572F8AD0
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x7FFD572F8AF0
        public void FetchBalance(){} // RVA: 0x7FFD572F8B10
        public void get_IsAccountVerified(){} // RVA: 0x7FFD4E426850
        public void get_hasNoPowers(){} // RVA: 0x7FFD572F8EA0
        public void get_hasScriptingAccess(){} // RVA: 0x7FFD572F8EF0
        public void get_hasModerationPowers(){} // RVA: 0x7FFD572F8FF0
        public void get_hasVIPAccess(){} // RVA: 0x7FFD572F90B0
        public void get_hasSuperPowers(){} // RVA: 0x7FFD572F9100
        public void get_canPublishWorldsAndAvatars(){} // RVA: 0x7FFD572F9150
        public void get_canPublishAllContent(){} // RVA: 0x7FFD572F9370
        public void get_canPublishAvatars(){} // RVA: 0x7FFD572F94A0
        public void get_canPublishWorlds(){} // RVA: 0x7FFD572F95C0
        public void get_canPublishProps(){} // RVA: 0x7FFD572F96E0
        public void get_isUntrusted(){} // RVA: 0x7FFD572F9800
        public void get_isNewUser(){} // RVA: 0x7FFD572F9860
        public void get_isEarlyAdopter(){} // RVA: 0x7FFD572F9920
        public void get_isSupporter(){} // RVA: 0x7FFD572F99E0
        public void get_hasBasicTrustLevel(){} // RVA: 0x7FFD572F9AA0
        public void get_hasKnownTrustLevel(){} // RVA: 0x7FFD572F9B70
        public void get_hasTrustedTrustLevel(){} // RVA: 0x7FFD572F9C40
        public void get_hasVeteranTrustLevel(){} // RVA: 0x7FFD572F9D10
        public void get_hasLegendTrustLevel(){} // RVA: 0x7FFD572F9DE0
        public void get_hasNegativeTrustLevel(){} // RVA: 0x7FFD572F9EB0
        public void get_hasVeryNegativeTrustLevel(){} // RVA: 0x7FFD572F9F80
        public void get_hasFeedbackAccess(){} // RVA: 0x7FFD572FA040
        public void get_showSocialRank(){} // RVA: 0x7FFD572FA100
        public void get_showModTag(){} // RVA: 0x7FFD572FA1A0
        public void get_canSetStatusOffline(){} // RVA: 0x7FFD572FA240
        public void get_statusIsSetToOffline(){} // RVA: 0x7FFD572FA2A0
        public void get_statusIsSetToJoinMe(){} // RVA: 0x7FFD572FA3D0
        public void get_statusIsSetToAskMe(){} // RVA: 0x7FFD572FA470
        public void get_statusIsSetToDoNotDisturb(){} // RVA: 0x7FFD572FA5A0
        public void get_statusDefaultDescriptionDisplayString(){} // RVA: 0x7FFD572FA6D0
        public void truncatedBio(){} // RVA: 0x7FFD572FA860
        public void truncatedStatusDescription(){} // RVA: 0x7FFD572FA8D0
        public void get_statusDescriptionDisplayString(){} // RVA: 0x7FFD572FA940
        public void get_statusValue(){} // RVA: 0x7FFD572FAA00
        public void get_CurrentLocation(){} // RVA: 0x7FFD572FAA70
        public void get_canSeeAllUsersStatus(){} // RVA: 0x7FFD572FADD0
        public void MergeFieldsInto(){} // RVA: 0x7FFD572FAE30
        public void get_IsLoggedIn(){} // RVA: 0x7FFD572FB6B0
        public void get_IsSelf(){} // RVA: 0x7FFD572FB740
        public void get_CurrentUser(){} // RVA: 0x7FFD572FB890
        public void set_CurrentUser(){} // RVA: 0x7FFD572FB8F0
        public void .ctor(){} // RVA: 0x7FFD572FBC20 | overloaded x2
        public void ReadField(){} // RVA: 0x7FFD572FC9D0
        public void WriteField(){} // RVA: 0x7FFD572FCA80
        public void InitialFetchCurrentUser(){} // RVA: 0x7FFD572FCC10
        public void Register(){} // RVA: 0x7FFD572FD030
        public void UpdateAccountInfo(){} // RVA: 0x7FFD572FDA60
        public void Login(){} // RVA: 0x7FFD572FE530
        public void VerifyTwoFactorAuthCode(){} // RVA: 0x7FFD572FEA20
        public void VerifyStepUpAuthCode(){} // RVA: 0x7FFD572FF010
        public void ThirdPartyLogin(){} // RVA: 0x7FFD572FFB90
        public void DiscordLogin(){} // RVA: 0x7FFD572FFFA0
        public void DiscordFinalizeLogin(){} // RVA: 0x7FFD57300570
        public void DiscordLinkStatus(){} // RVA: 0x7FFD57301060
        public void DiscordUnlink(){} // RVA: 0x7FFD57301550
        public void DiscordAccess(){} // RVA: 0x7FFD57301890
        public void RedeemPromo(){} // RVA: 0x7FFD57301BD0
        public void Logout(){} // RVA: 0x7FFD57301FC0
        public void FetchPublishWorldsInformation(){} // RVA: 0x7FFD57302110
        public void FetchUsers(){} // RVA: 0x7FFD57302E30 | overloaded x2
        public void FetchUser(){} // RVA: 0x7FFD57302AC0
        public void FetchUsersSearchResults(){} // RVA: 0x7FFD57303210
        public void FetchFriends(){} // RVA: 0x7FFD57303620
        public void AttemptVerification(){} // RVA: 0x7FFD57304090
        public void TagsToDeveloperType(){} // RVA: 0x7FFD57304150
        public void SetIsBoopingEnabled(){} // RVA: 0x7FFD573041C0
        public void AddLanguage(){} // RVA: 0x7FFD57304620
        public void RemoveLanguage(){} // RVA: 0x7FFD57304BF0
        public void AddLink(){} // RVA: 0x7FFD57305180
        public void ModifyLink(){} // RVA: 0x7FFD573056C0
        public void UpdateBio(){} // RVA: 0x7FFD57305B60
        public void UpdateContentFilters(){} // RVA: 0x7FFD57306150
        public void UpdateUserLanguageCode(){} // RVA: 0x7FFD57306570
        public void AddNewStatusToHistory(){} // RVA: 0x7FFD57306A60
        public void StatusValueToString(){} // RVA: 0x7FFD57306C20
        public void StringToStatusValue(){} // RVA: 0x7FFD57306D80
        public void UnfriendUser(){} // RVA: 0x7FFD57307000
        public void LocalAddFriend(){} // RVA: 0x7FFD57307410
        public void IsFriendsWith(){} // RVA: 0x7FFD57307660
        public void get_HasRequestedToBeFriend(){} // RVA: 0x7FFD57307890
        public void set_HasRequestedToBeFriend(){} // RVA: 0x7FFD57307910
        public void get_HasFriendRequestPending(){} // RVA: 0x7FFD573079B0
        public void set_HasFriendRequestPending(){} // RVA: 0x7FFD57307A30
        public void SetAvatarPropertiesFromModel(){} // RVA: 0x7FFD57307AD0
        public void SetAvatarFallbackPropertiesFromModel(){} // RVA: 0x7FFD57307D30
        public void Exists(){} // RVA: 0x7FFD57307E20
        public void HasTag(){} // RVA: 0x7FFD57307E60
        public void AddTag(){} // RVA: 0x7FFD57307ED0
        public void RemoveTag(){} // RVA: 0x7FFD57307F70
        public void Equals(){} // RVA: 0x7FFD573080C0
        public void UpdateNote(){} // RVA: 0x7FFD57308170
        public void SetUserInterests(){} // RVA: 0x7FFD57308800
        public void GetUserInterests(){} // RVA: 0x7FFD57308AD0
        public void CheckIfPersistenceDataExistsForWorld(){} // RVA: 0x7FFD57308DE0
        public void ResetPersistenceDataForWorld(){} // RVA: 0x7FFD57309190
        public void ResetAllPersistenceDataForWorlds(){} // RVA: 0x7FFD57309530
        public void UpdateBadge(){} // RVA: 0x7FFD57309870
        public void ToString(){} // RVA: 0x7FFD5730A0D0
        public void .cctor(){} // RVA: 0x7FFD5730A410
    }

    public class ApiAdminAssetBundle : ApiModel
    {
        public string name; // 0x68
        public string description; // 0x70
        public string imageUrl; // 0x78
        public URA.woDigitYearMax<string> tags; // 0x80
        public int assetVersion; // 0x88
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ext> unityPackages; // 0x90

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_description(){} // RVA: 0x7FFD4E409590
        public void set_description(){} // RVA: 0x7FFD4E4095A0
        public void get_imageUrl(){} // RVA: 0x7FFD4E505600
        public void set_imageUrl(){} // RVA: 0x7FFD4E5006F0
        public void get_tags(){} // RVA: 0x7FFD4E70F410
        public void set_tags(){} // RVA: 0x7FFD4E8F4AA0
        public void get_assetVersion(){} // RVA: 0x7FFD4EC0E8C0
        public void set_assetVersion(){} // RVA: 0x7FFD4EC19DE0
        public void get_unityPackages(){} // RVA: 0x7FFD4E70F640
        public void set_unityPackages(){} // RVA: 0x7FFD4E96E360
        public void GetPlatformString(){} // RVA: 0x7FFD57281AC0 | overloaded x2
        public void GetBundleLink(){} // RVA: 0x7FFD57281C50
        public void CreateAdminAssetBundle(){} // RVA: 0x7FFD57281F10
        public void AddPackageToBundle(){} // RVA: 0x7FFD57282850
        public void GetAdminAssetBundle(){} // RVA: 0x7FFD57283050
        public void GetAllAdminAssetBundles(){} // RVA: 0x7FFD57283380
        public void RequestDeleteBundle(){} // RVA: 0x7FFD57283B40
        public void SendPropertyUpdate(){} // RVA: 0x7FFD57283E50
        public void .ctor(){} // RVA: 0x7FFD57284660
    }

    public class ApiAuthContinue : ApiModel
    {
        public object continueToken;
        public object requestedFields;
        public object reservedName;

        // ── Methods ──
        public void get_continueToken(){} // RVA: 0x7FFD4E3BCD50
        public void set_continueToken(){} // RVA: 0x7FFD4E3BCD60
        public void get_requestedFields(){} // RVA: 0x7FFD4E409590
        public void set_requestedFields(){} // RVA: 0x7FFD4E4095A0
        public void get_reservedName(){} // RVA: 0x7FFD4E505600
        public void set_reservedName(){} // RVA: 0x7FFD4E5006F0
        public void .ctor(){} // RVA: 0x7FFD57284C40
    }

    public class ApiAvatar : ApiContentModel`1
    {
        public URA.DateTime<?,string> impostorUrl; // 0xD8
        public string variant; // 0xE0
        public ptionHelper impostorUnityVersion; // 0xE8
        public string unityPackages; // 0xF0
        public URA.woDigitYearMax<sedTCPStream> created_at; // 0xF8
        public DependencyInjector updated_at; // 0x100
        public DependencyInjector attribution; // 0x108
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ubscription_start_time>k__BackingField offlineAnalysisScanStatus; // 0x110
        public ry<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.Data> performanceRating; // 0x118
        public string styles; // 0x120
        public URA.DateTime<string,string> productId; // 0x128
        public string publishedListings; // 0x130
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ift> lowestPrice; // 0x138
        public aphy<int> highestPrice; // 0x140
        public aphy<int> acknowledgements; // 0x148
        public string LoadError; // 0x150
        public string <LoadError>k__BackingField; // 0x158
        public string AvatarsEndpoint;

        // ── Methods ──
        public void get_impostorUrl(){} // RVA: 0x7FFD4E3C2900
        public void set_impostorUrl(){} // RVA: 0x7FFD4E3C2910
        public void get_variant(){} // RVA: 0x7FFD4FBF5FE0
        public void set_variant(){} // RVA: 0x7FFD53E31760
        public void get_impostorUnityVersion(){} // RVA: 0x7FFD4E3AC2A0
        public void set_impostorUnityVersion(){} // RVA: 0x7FFD4E3AC2B0
        public void get_unityPackages(){} // RVA: 0x7FFD4E751F50
        public void set_unityPackages(){} // RVA: 0x7FFD4E8C4860
        public void get_created_at(){} // RVA: 0x7FFD4E916C80
        public void set_created_at(){} // RVA: 0x7FFD4F5B6020
        public void get_updated_at(){} // RVA: 0x7FFD4EAF1F40
        public void set_updated_at(){} // RVA: 0x7FFD57284CE0
        public void get_attribution(){} // RVA: 0x7FFD4E96B170
        public void set_attribution(){} // RVA: 0x7FFD4EDD3E10
        public void get_offlineAnalysisScanStatus(){} // RVA: 0x7FFD4FD861E0
        public void set_offlineAnalysisScanStatus(){} // RVA: 0x7FFD4FD861F0
        public void get_performanceRating(){} // RVA: 0x7FFD4E55CBB0
        public void set_performanceRating(){} // RVA: 0x7FFD4E563400
        public void get_styles(){} // RVA: 0x7FFD4E9666F0
        public void set_styles(){} // RVA: 0x7FFD4EDE51C0
        public void get_productId(){} // RVA: 0x7FFD4E964340
        public void set_productId(){} // RVA: 0x7FFD4EDC79B0
        public void get_publishedListings(){} // RVA: 0x7FFD4E9622C0
        public void set_publishedListings(){} // RVA: 0x7FFD4EAF84B0
        public void get_lowestPrice(){} // RVA: 0x7FFD4E3AC5F0
        public void set_lowestPrice(){} // RVA: 0x7FFD53F5E9E0
        public void get_highestPrice(){} // RVA: 0x7FFD4E3AC660
        public void set_highestPrice(){} // RVA: 0x7FFD53E53F90
        public void get_acknowledgements(){} // RVA: 0x7FFD4E96DFA0
        public void set_acknowledgements(){} // RVA: 0x7FFD4EDD99C0
        public void get_LoadError(){} // RVA: 0x7FFD4E962410
        public void set_LoadError(){} // RVA: 0x7FFD4EDC74B0
        public void .ctor(){} // RVA: 0x7FFD57284CF0
        public void Get(){} // RVA: 0x7FFD57284E10
        public void AssignToThisUser(){} // RVA: 0x7FFD57284FB0
        public void AssignToThisUserAsFallback(){} // RVA: 0x7FFD57285430
        public void GetPerformanceRatingForPlatform(){} // RVA: 0x7FFD572858B0
        public void GetAssetUrl(){} // RVA: 0x7FFD57285930
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFD57285AD0 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x7FFD57285C10
        public void WriteField(){} // RVA: 0x7FFD57286760
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFD57286790
    }

    public class ApiAvatarModeration : ApiModel
    {
        public float moderationType;
        public IsPowerOfTwo targetAvatarId; // 0x68
        public string <targetAvatarId>k__BackingField; // 0x70

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7FFD4FBDAB50
        public void set_moderationType(){} // RVA: 0x7FFD4FBDAB60
        public void get_targetAvatarId(){} // RVA: 0x7FFD4E409590
        public void set_targetAvatarId(){} // RVA: 0x7FFD4E4095A0
        public void .ctor(){} // RVA: 0x7FFD57287050
        public void ShouldCache(){} // RVA: 0x7FFD4E341320
        public void ReadField(){} // RVA: 0x7FFD57287110
        public void WriteField(){} // RVA: 0x7FFD57287490
        public void SendModeration(){} // RVA: 0x7FFD57287670
        public void DeleteModeration(){} // RVA: 0x7FFD572878B0
        public void FetchAllMine(){} // RVA: 0x7FFD57287DD0
        public void FetchList(){} // RVA: 0x7FFD57287E30
        public void ModerationTypeToAPIString(){} // RVA: 0x7FFD57288120
    }

    public class ApiBadge : ApiModel
    {
        public string badgeId; // 0x68
        public bool showcased; // 0x70
        public string badgeName; // 0x78
        public string badgeDescription; // 0x80
        public string badgeImageUrl; // 0x88
        public bool hidden; // 0x90
        public DependencyInjector assignedAt; // 0x98
        public DependencyInjector updatedAt; // 0xA0
        public string assignedBy; // 0xA8

        // ── Methods ──
        public void get_badgeId(){} // RVA: 0x7FFD4E3BCD50
        public void set_badgeId(){} // RVA: 0x7FFD4E3BCD60
        public void get_showcased(){} // RVA: 0x7FFD4E3BD320
        public void set_showcased(){} // RVA: 0x7FFD4E3BD330
        public void get_badgeName(){} // RVA: 0x7FFD4E505600
        public void set_badgeName(){} // RVA: 0x7FFD4E5006F0
        public void get_badgeDescription(){} // RVA: 0x7FFD4E70F410
        public void set_badgeDescription(){} // RVA: 0x7FFD4E8F4AA0
        public void get_badgeImageUrl(){} // RVA: 0x7FFD4E380010
        public void set_badgeImageUrl(){} // RVA: 0x7FFD4E96E300
        public void get_hidden(){} // RVA: 0x7FFD4F22D160
        public void set_hidden(){} // RVA: 0x7FFD4F2289B0
        public void get_assignedAt(){} // RVA: 0x7FFD4E96DFB0
        public void set_assignedAt(){} // RVA: 0x7FFD53221AA0
        public void get_updatedAt(){} // RVA: 0x7FFD4E963900
        public void set_updatedAt(){} // RVA: 0x7FFD53BAD950
        public void get_assignedBy(){} // RVA: 0x7FFD4E96B1A0
        public void set_assignedBy(){} // RVA: 0x7FFD4E76B370
        public void .ctor(){} // RVA: 0x7FFD57288590
    }

    public class ApiCache : Object
    {
        public ormation<long> Count;
        public URA.DateTime<string,sToGet> NextExpiryTTL; // 0x8
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.d__169<sToGet> expiryQueue; // 0x10
        public itializeImpl CleanupDelay; // 0x18

        // ── Methods ──
        public void DefaultTimeProvider(){} // RVA: 0x7FFD57288760
        public void get_Count(){} // RVA: 0x7FFD57288810
        public void get_NextExpiryTTL(){} // RVA: 0x7FFD572889E0
        public void Fetch(){} // RVA: 0x7FFD4E07A350
        public void Save(){} // RVA: 0x7FFD57288CD0
        public void Invalidate(){} // RVA: 0x7FFD57289140
        public void CleanupTask(){} // RVA: 0x7FFD572893F0
        public void Cleanup(){} // RVA: 0x7FFD57289430
        public void InvalidateFileIfVersionUnknown(){} // RVA: 0x7FFD57289930
        public void Clear(){} // RVA: 0x7FFD57289AE0
        public void .cctor(){} // RVA: 0x7FFD57289D60
    }

    public class ApiCacheObject
    {
        public object ExpiryTime;

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFD4E079D00
        public void GetLifeSpan(){} // RVA: 0x7FFD4E08D880
        public void Clone(){} // RVA: 0x7FFD4E078E90
        public void set_ExpiryTime(){} // RVA: 0x7FFD4E090A40
    }

    public class ApiCampaignAnonymizationStatus : ApiModel
    {
        public bool isAnonymized; // 0x68
        public string anonymizedName; // 0x70

        // ── Methods ──
        public void get_isAnonymized(){} // RVA: 0x7FFD4E409570
        public void set_isAnonymized(){} // RVA: 0x7FFD4E409580
        public void get_anonymizedName(){} // RVA: 0x7FFD4E409590
        public void set_anonymizedName(){} // RVA: 0x7FFD4E4095A0
        public void .ctor(){} // RVA: 0x7FFD5728B740
    }

    public class ApiCampaignContributor : ApiModel
    {
        public string userId; // 0x68
        public string displayName; // 0x70
        public int giftCount; // 0x78
        public bool isAnonymized; // 0x7C
        public bool isSelf; // 0x7D

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFD4E3BCD50
        public void set_userId(){} // RVA: 0x7FFD4E3BCD60
        public void get_displayName(){} // RVA: 0x7FFD4E409590
        public void set_displayName(){} // RVA: 0x7FFD4E4095A0
        public void get_giftCount(){} // RVA: 0x7FFD4F9B6EF0
        public void set_giftCount(){} // RVA: 0x7FFD4F9B63A0
        public void get_isAnonymized(){} // RVA: 0x7FFD4E7EFDF0
        public void set_isAnonymized(){} // RVA: 0x7FFD4E7E9B20
        public void get_isSelf(){} // RVA: 0x7FFD4E7EAD30
        public void set_isSelf(){} // RVA: 0x7FFD4E7EC1E0
        public void .ctor(){} // RVA: 0x7FFD5728B790
    }

    public class ApiCampaignReward : ApiModel
    {
        public bool isUnlocked; // 0x68
        public string imageUrl; // 0x70
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.seCookieHeader>b__61_0 progression; // 0x78

        // ── Methods ──
        public void get_isUnlocked(){} // RVA: 0x7FFD4E409570
        public void set_isUnlocked(){} // RVA: 0x7FFD4E409580
        public void get_imageUrl(){} // RVA: 0x7FFD4E409590
        public void set_imageUrl(){} // RVA: 0x7FFD4E4095A0
        public void get_progression(){} // RVA: 0x7FFD4E505600
        public void set_progression(){} // RVA: 0x7FFD4E5006F0
        public void .ctor(){} // RVA: 0x7FFD5728B6A0
    }

    public class ApiCertificateVerifier : CertificateHandler
    {
        public object Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD5728B7E0
        public void .ctor(){} // RVA: 0x7FFD550B2940
        public void Initialize(){} // RVA: 0x7FFD5728B840
        public void TestPublicKey(){} // RVA: 0x7FFD5728B940
        public void IsValid(){} // RVA: 0x7FFD5728BBD0
        public void ValidateCertificate(){} // RVA: 0x7FFD5728BE10
        public void .cctor(){} // RVA: 0x7FFD5728BFD0
    }

    public class ApiContainer : Object
    {
        public URA.DateTime<string,string> Cookies; // 0x10
        public bool Populated; // 0x18
        public bool PassedValidation; // 0x19
        public int Code; // 0x1C
        public string Text; // 0x20
        public object Data; // 0x28
        public float DataTimestamp; // 0x30
        public string CreatedAt; // 0x38
        public string Error; // 0x40
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.tBundleId>k__BackingField Model; // 0x48
        public ileFullDirectoryInformation<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.InSlot>b__0> OnError; // 0x50
        public ileFullDirectoryInformation<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.InSlot>b__0> OnSuccess; // 0x58

        // ── Methods ──
        public void get_Cookies(){} // RVA: 0x7FFD4E35C380
        public void set_Cookies(){} // RVA: 0x7FFD4E342E30
        public void get_Populated(){} // RVA: 0x7FFD4E35C4E0
        public void set_Populated(){} // RVA: 0x7FFD4E35C4F0
        public void get_PassedValidation(){} // RVA: 0x7FFD4E648D50
        public void set_PassedValidation(){} // RVA: 0x7FFD4E935120
        public void get_Code(){} // RVA: 0x7FFD4F8557F0
        public void set_Code(){} // RVA: 0x7FFD4F8674D0
        public void get_Text(){} // RVA: 0x7FFD4E36F0C0
        public void set_Text(){} // RVA: 0x7FFD4E36F0D0
        public void get_Data(){} // RVA: 0x7FFD4E36F130
        public void set_Data(){} // RVA: 0x7FFD4E342E90
        public void get_DataTimestamp(){} // RVA: 0x7FFD4F060670
        public void set_DataTimestamp(){} // RVA: 0x7FFD4FB594E0
        public void get_CreatedAt(){} // RVA: 0x7FFD4E5F0140
        public void set_CreatedAt(){} // RVA: 0x7FFD4E5F0C20
        public void get_Error(){} // RVA: 0x7FFD572EDC20
        public void set_Error(){} // RVA: 0x7FFD572EDC50
        public void get_Model(){} // RVA: 0x7FFD4E3BC730
        public void set_Model(){} // RVA: 0x7FFD4E3BC740
        public void .ctor(){} // RVA: 0x7FFD572EDFB0
        public void setFromContainer(){} // RVA: 0x7FFD572EE080
        public void Validate(){} // RVA: 0x7FFD572EE290
        public void GetErrorMessage(){} // RVA: 0x7FFD572EE2E0
        public void OnComplete(){} // RVA: 0x7FFD572EE490
    }

    public class ApiContentModel`1 : ApiModel
    {
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.et_canPublishWorlds VERSION;
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.et_canPublishWorlds name; // 0x8
        public float imageUrl;
        public float authorName;
        public URA.DateTime<string,ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.et_pages> authorId; // 0x10
        public string assetUrl; // 0x68
        public string description; // 0x70
        public string tags; // 0x78
        public string thumbnailImageUrl; // 0x80
        public string version; // 0x88
        public string releaseStatus; // 0x90
        public URA.woDigitYearMax<string> featured; // 0x98
        public string unityPackageUpdated; // 0xA0
        public int unityVersion; // 0xA8
        public string apiVersion; // 0xB0
        public bool platform; // 0xB8
        public bool assetVersion; // 0xB9
        public string IsLocal; // 0xC0
        public int <apiVersion>k__BackingField; // 0xC8
        public string <platform>k__BackingField; // 0xD0

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7FFD4E078A90
        public void ShouldCache(){} // RVA: 0x7FFD4E079D00
        public void GetLifeSpan(){} // RVA: 0x7FFD4E08D880
        public void get_name(){} // RVA: 0x7FFD4E078E90
        public void set_name(){} // RVA: 0x7FFD4E090A40
        public void get_imageUrl(){} // RVA: 0x7FFD4E078E90
        public void set_imageUrl(){} // RVA: 0x7FFD4E090A40
        public void get_authorName(){} // RVA: 0x7FFD4E078E90
        public void set_authorName(){} // RVA: 0x7FFD4E090A40
        public void get_authorId(){} // RVA: 0x7FFD4E078E90
        public void set_authorId(){} // RVA: 0x7FFD4E090A40
        public void get_assetUrl(){} // RVA: 0x7FFD4E078E90
        public void set_assetUrl(){} // RVA: 0x7FFD4E090A40
        public void get_description(){} // RVA: 0x7FFD4E078E90
        public void set_description(){} // RVA: 0x7FFD4E090A40
        public void get_tags(){} // RVA: 0x7FFD4E078E90
        public void set_tags(){} // RVA: 0x7FFD4E090A40
        public void get_thumbnailImageUrl(){} // RVA: 0x7FFD4E078E90
        public void set_thumbnailImageUrl(){} // RVA: 0x7FFD4E090A40
        public void get_version(){} // RVA: 0x7FFD4E079960
        public void set_version(){} // RVA: 0x7FFD4E090ED0
        public void get_releaseStatus(){} // RVA: 0x7FFD4E078E90
        public void set_releaseStatus(){} // RVA: 0x7FFD4E090A40
        public void get_featured(){} // RVA: 0x7FFD4E079D00
        public void set_featured(){} // RVA: 0x7FFD4E091060
        public void get_unityPackageUpdated(){} // RVA: 0x7FFD4E079D00
        public void set_unityPackageUpdated(){} // RVA: 0x7FFD4E091060
        public void get_unityVersion(){} // RVA: 0x7FFD4E078E90
        public void set_unityVersion(){} // RVA: 0x7FFD4E090A40
        public void get_apiVersion(){} // RVA: 0x7FFD4E079960
        public void set_apiVersion(){} // RVA: 0x7FFD4E090ED0
        public void get_platform(){} // RVA: 0x7FFD4E078E90
        public void set_platform(){} // RVA: 0x7FFD4E090A40
        public void get_assetVersion(){} // RVA: 0x7FFD4E078E90
        public void set_assetVersion(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void ReadField(){} // RVA: 0x7FFD4E07D200
        public void Get(){} // RVA: 0x7FFD4E2ADC40
        public void FetchList(){} // RVA: 0x7FFD4E2ADC40
        public void AddLocal(){} // RVA: 0x7FFD4E2ADC40
        public void IsLocalById(){} // RVA: 0x7FFD4E079DE0
        public void get_IsLocal(){} // RVA: 0x7FFD4E079D00
        public void Save(){} // RVA: 0x7FFD4E099B30
        public void SaveReleaseStatus(){} // RVA: 0x7FFD4E099B30
        public void GetAssetUrl(){} // RVA: 0x7FFD4E078E90
        public void HasTag(){} // RVA: 0x7FFD4E079F60
        public void AddTag(){} // RVA: 0x7FFD4E079F60
        public void RemoveTag(){} // RVA: 0x7FFD4E079F60
        public void UpdateVersionAndPlatform(){} // RVA: 0x7FFD4E090980
        public void MakeRequestEndpoint(){}
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class ApiDictContainer : ApiContainer
    {
        public float cacheLifetime; // 0x60
        public aphy<long> ExpiryTime; // 0x68
        public string[] requiredFields; // 0x78
        public URA.DayNames<string,_TA_ECDSA_SHA_1> ResponseDictionary;

        // ── Methods ──
        public void get_cacheLifetime(){} // RVA: 0x7FFD4E451E10
        public void set_cacheLifetime(){} // RVA: 0x7FFD4EB55550
        public void get_ExpiryTime(){} // RVA: 0x7FFD513F87B0
        public void set_ExpiryTime(){} // RVA: 0x7FFD513F8C20
        public void get_requiredFields(){} // RVA: 0x7FFD4E505600
        public void set_requiredFields(){} // RVA: 0x7FFD4E5006F0
        public void get_ResponseDictionary(){} // RVA: 0x7FFD572EC8D0
        public void .ctor(){} // RVA: 0x7FFD572ECAB0 | overloaded x2
        public void Validate(){} // RVA: 0x7FFD572ECB20
        public void ShouldCache(){} // RVA: 0x7FFD572ECE70
        public void ShouldClearOnLevelLoad(){} // RVA: 0x7FFD4E341320
        public void GetLifeSpan(){} // RVA: 0x7FFD4E451E10
        public void Clone(){} // RVA: 0x7FFD572ECE80
        public void .cctor(){} // RVA: 0x7FFD572ECF00
        public void <Validate>b__17_0(){} // RVA: 0x7FFD572ECFD0
    }

    public class ApiDroneSkin : ApiModel
    {
        public string name; // 0x68
        public string assetBundleId; // 0x70
        public string viewfinderAssetBundleId; // 0x78

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_assetBundleId(){} // RVA: 0x7FFD4E409590
        public void set_assetBundleId(){} // RVA: 0x7FFD4E4095A0
        public void get_viewfinderAssetBundleId(){} // RVA: 0x7FFD4E505600
        public void set_viewfinderAssetBundleId(){} // RVA: 0x7FFD4E5006F0
        public void .ctor(){} // RVA: 0x7FFD5728C220
    }

    public class ApiEconomyStore : ApiModel
    {
        public string SellerId; // 0x68
        public string SellerDisplayName; // 0x70
        public string WorldId; // 0x78
        public string GroupId; // 0x80
        public ÏÍÏÍÍ StoreStatus; // 0x88
        public string DisplayName; // 0x90
        public string Description; // 0x98
        public URA.woDigitYearMax<string> Tags; // 0xA0
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ift> Listings; // 0xA8
        public URA.woDigitYearMax<string> ListingIDs; // 0xB0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5728C270
        public void get_SellerId(){} // RVA: 0x7FFD4E3BCD50
        public void set_SellerId(){} // RVA: 0x7FFD4E3BCD60
        public void get_SellerDisplayName(){} // RVA: 0x7FFD4E409590
        public void set_SellerDisplayName(){} // RVA: 0x7FFD4E4095A0
        public void get_WorldId(){} // RVA: 0x7FFD4E505600
        public void set_WorldId(){} // RVA: 0x7FFD4E5006F0
        public void get_GroupId(){} // RVA: 0x7FFD4E70F410
        public void set_GroupId(){} // RVA: 0x7FFD4E8F4AA0
        public void get_StoreStatus(){} // RVA: 0x7FFD4EC0E8C0
        public void set_StoreStatus(){} // RVA: 0x7FFD4EC19DE0
        public void get_DisplayName(){} // RVA: 0x7FFD4E70F640
        public void set_DisplayName(){} // RVA: 0x7FFD4E96E360
        public void get_Description(){} // RVA: 0x7FFD4E96DFB0
        public void set_Description(){} // RVA: 0x7FFD4E96E3C0
        public void get_Tags(){} // RVA: 0x7FFD4E963900
        public void set_Tags(){} // RVA: 0x7FFD4E96E420
        public void get_Listings(){} // RVA: 0x7FFD4E96B1A0
        public void set_Listings(){} // RVA: 0x7FFD4E76B370
        public void get_ListingIDs(){} // RVA: 0x7FFD4E3AC040
        public void set_ListingIDs(){} // RVA: 0x7FFD4E3AC050
        public void get_IsGroupStore(){} // RVA: 0x7FFD5728C2C0
        public void get_IsWorldStore(){} // RVA: 0x7FFD5728C2E0
        public void ReadField(){} // RVA: 0x7FFD5728C300
        public void WriteField(){} // RVA: 0x7FFD5728C540
        public void FetchStore(){} // RVA: 0x7FFD5728C6A0
    }

    public class ApiFile : ApiModel
    {
        public string name; // 0x68
        public aphy<int> order; // 0x70
        public string ownerId; // 0x78
        public string mimeType; // 0x80
        public string extension; // 0x88
        public URA.woDigitYearMax<?> versions; // 0x90
        public bool IsInitialized; // 0x98
        public bool IsPendingInit; // 0x99

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_order(){} // RVA: 0x7FFD4E409590
        public void set_order(){} // RVA: 0x7FFD4FE4BA60
        public void get_ownerId(){} // RVA: 0x7FFD4E505600
        public void set_ownerId(){} // RVA: 0x7FFD4E5006F0
        public void get_mimeType(){} // RVA: 0x7FFD4E70F410
        public void set_mimeType(){} // RVA: 0x7FFD4E8F4AA0
        public void get_extension(){} // RVA: 0x7FFD4E380010
        public void set_extension(){} // RVA: 0x7FFD4E96E300
        public void get_versions(){} // RVA: 0x7FFD4E70F640
        public void set_versions(){} // RVA: 0x7FFD4E96E360
        public void get_IsInitialized(){} // RVA: 0x7FFD4E7BA7F0
        public void set_IsInitialized(){} // RVA: 0x7FFD4E7BFA20
        public void get_IsPendingInit(){} // RVA: 0x7FFD4E7BC020
        public void set_IsPendingInit(){} // RVA: 0x7FFD53D76680
        public void .ctor(){} // RVA: 0x7FFD5728F1D0 | overloaded x3
        public void Create(){} // RVA: 0x7FFD5728F360
        public void Refresh(){} // RVA: 0x7FFD5728F500
        public void DownloadFile(){} // RVA: 0x7FFD5728F540
        public void ParseFileIdFromFileAPIUrl(){} // RVA: 0x7FFD5728FBB0
        public void TryParseFileIdFromFileAPIUrl(){} // RVA: 0x7FFD5728FC50
        public void TryParseFileVersionFromFileAPIUrl(){} // RVA: 0x7FFD5728FC90
        public void TryParseFileIdAndVersionFromFileAPIUrl(){} // RVA: 0x7FFD5728FCE0
        public void TryParseFileIdAndVersionAndVariantSuffixFromFileAPIUrl(){} // RVA: 0x7FFD5728FD20
        public void TryParseFileIdAndVersionAndVariantFromFileAPIUrl(){} // RVA: 0x7FFD5728FDA0 | overloaded x2
        public void PerformRegexMatch(){} // RVA: 0x7FFD5728FDD0
        public void TryGetImageAPIUrlFromFileAPIUrl(){} // RVA: 0x7FFD572905D0
        public void OnDownloadFileCompleted(){} // RVA: 0x7FFD57290B30
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFD57291230 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD57291260
        public void ToStringBrief(){} // RVA: 0x7FFD4E51EBD0
        public void CreateNewVersion(){} // RVA: 0x7FFD57291480
        public void HasExistingVersion(){} // RVA: 0x7FFD57291BC0
        public void HasExistingOrPendingVersion(){} // RVA: 0x7FFD57291C80
        public void GetLatestVersionNumber(){} // RVA: 0x7FFD57291D60
        public void GetLatestCompleteVersionNumber(){} // RVA: 0x7FFD57291DC0
        public void GetVersion(){} // RVA: 0x7FFD57291EF0
        public void GetLatestCompleteVersion(){} // RVA: 0x7FFD57291F90
        public void GetLatestVersion(){} // RVA: 0x7FFD57291FC0
        public void DeleteVersion(){} // RVA: 0x7FFD57292030
        public void DeleteLatestVersion(){} // RVA: 0x7FFD57292320
        public void DownloadSignature(){} // RVA: 0x7FFD57292700
        public void GetFileURL(){} // RVA: 0x7FFD572927A0 | overloaded x2
        public void GetFileRawURL(){} // RVA: 0x7FFD57292830 | overloaded x2
        public void GetDeltaURL(){} // RVA: 0x7FFD572928E0 | overloaded x2
        public void GetDeltaRawURL(){} // RVA: 0x7FFD57292970 | overloaded x2
        public void GetSignatureURL(){} // RVA: 0x7FFD57292A20 | overloaded x2
        public void GetSignatureRawURL(){} // RVA: 0x7FFD57292AB0 | overloaded x2
        public void GetFileApiURL(){} // RVA: 0x7FFD57292D10 | overloaded x2
        public void GetFileVariantApiURL(){} // RVA: 0x7FFD57292E50
        public void GetFileMD5(){} // RVA: 0x7FFD572932E0 | overloaded x2
        public void GetFileDescriptor(){} // RVA: 0x7FFD57293360
        public void IsLatestVersionQueued(){} // RVA: 0x7FFD57293390
        public void HasQueuedOperation(){} // RVA: 0x7FFD57293460
        public void IsWaitingForUpload(){} // RVA: 0x7FFD57293600
        public void IsInErrorState(){} // RVA: 0x7FFD572936D0
        public void StartSimpleUpload(){} // RVA: 0x7FFD572937A0
        public void StartMultipartUpload(){} // RVA: 0x7FFD57293B30
        public void FinishUpload(){} // RVA: 0x7FFD57293F10
        public void GetUploadStatus(){} // RVA: 0x7FFD572941A0
        public void PutSimpleFileToURL(){} // RVA: 0x7FFD572943A0
        public void PutMultipartDataToURL(){} // RVA: 0x7FFD57294E80
    }

    public class ApiGroupGalleryImage : ApiModel
    {
        public string name; // 0x68
        public string groupId; // 0x70
        public string galleryId; // 0x78
        public string fileId; // 0x80
        public string imageUrl; // 0x88
        public DependencyInjector createdAt; // 0x90
        public bool approved; // 0x98
        public DependencyInjector approvedAt; // 0xA0
        public string approvedByUserId; // 0xA8
        public string submittedByUserId; // 0xB0
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.? file; // 0xB8

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_groupId(){} // RVA: 0x7FFD4E409590
        public void set_groupId(){} // RVA: 0x7FFD4E4095A0
        public void get_galleryId(){} // RVA: 0x7FFD4E505600
        public void set_galleryId(){} // RVA: 0x7FFD4E5006F0
        public void get_fileId(){} // RVA: 0x7FFD4E70F410
        public void set_fileId(){} // RVA: 0x7FFD4E8F4AA0
        public void get_imageUrl(){} // RVA: 0x7FFD4E380010
        public void set_imageUrl(){} // RVA: 0x7FFD4E96E300
        public void get_createdAt(){} // RVA: 0x7FFD4E70F640
        public void set_createdAt(){} // RVA: 0x7FFD4EB25AA0
        public void get_approved(){} // RVA: 0x7FFD4E7BA7F0
        public void set_approved(){} // RVA: 0x7FFD4E7BFA20
        public void get_approvedAt(){} // RVA: 0x7FFD4E963900
        public void set_approvedAt(){} // RVA: 0x7FFD53BAD950
        public void get_approvedByUserId(){} // RVA: 0x7FFD4E96B1A0
        public void set_approvedByUserId(){} // RVA: 0x7FFD4E76B370
        public void get_submittedByUserId(){} // RVA: 0x7FFD4E3AC040
        public void set_submittedByUserId(){} // RVA: 0x7FFD4E3AC050
        public void get_file(){} // RVA: 0x7FFD4E3AC0B0
        public void set_file(){} // RVA: 0x7FFD4E3AC0C0
        public void .ctor(){} // RVA: 0x7FFD5733EBA0
    }

    public class ApiImage : ApiFile
    {
        public int MAX_IMAGES;
        public string endpoint;

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFD4E341320
        public void FetchList(){} // RVA: 0x7FFD57297680
        public void UploadImage(){} // RVA: 0x7FFD572981E0
        public void .ctor(){} // RVA: 0x7FFD572985E0
    }

    public class ApiInfoPushSystem : ApiModel
    {
        public float isEnabled;
        public bool releaseStatus; // 0x68
        public string tags; // 0x70
        public URA.woDigitYearMax<string> requireClientTags; // 0x78
        public URA.woDigitYearMax<string> priority; // 0x80
        public int startDate; // 0x88
        public DependencyInjector endDate; // 0x90
        public DependencyInjector createdAt; // 0x98
        public DependencyInjector updatedAt; // 0xA0
        public DependencyInjector hash; // 0xA8
        public string originalManifestId; // 0xB0
        public string data; // 0xB8
        public object <data>k__BackingField; // 0xC0
        public string ENDPOINT;

        // ── Methods ──
        public void get_isEnabled(){} // RVA: 0x7FFD4E409570
        public void set_isEnabled(){} // RVA: 0x7FFD4E409580
        public void get_releaseStatus(){} // RVA: 0x7FFD4E409590
        public void set_releaseStatus(){} // RVA: 0x7FFD4E4095A0
        public void get_tags(){} // RVA: 0x7FFD4E505600
        public void set_tags(){} // RVA: 0x7FFD4E5006F0
        public void get_requireClientTags(){} // RVA: 0x7FFD4E70F410
        public void set_requireClientTags(){} // RVA: 0x7FFD4E8F4AA0
        public void get_priority(){} // RVA: 0x7FFD4EC0E8C0
        public void set_priority(){} // RVA: 0x7FFD4EC19DE0
        public void get_startDate(){} // RVA: 0x7FFD4E70F640
        public void set_startDate(){} // RVA: 0x7FFD4EB25AA0
        public void get_endDate(){} // RVA: 0x7FFD4E96DFB0
        public void set_endDate(){} // RVA: 0x7FFD53221AA0
        public void get_createdAt(){} // RVA: 0x7FFD4E963900
        public void set_createdAt(){} // RVA: 0x7FFD53BAD950
        public void get_updatedAt(){} // RVA: 0x7FFD4E96B1A0
        public void set_updatedAt(){} // RVA: 0x7FFD4F9E9F60
        public void get_hash(){} // RVA: 0x7FFD4E3AC040
        public void set_hash(){} // RVA: 0x7FFD4E3AC050
        public void get_originalManifestId(){} // RVA: 0x7FFD4E3AC0B0
        public void set_originalManifestId(){} // RVA: 0x7FFD4E3AC0C0
        public void get_data(){} // RVA: 0x7FFD4E3AC120
        public void set_data(){} // RVA: 0x7FFD4E3AC130
        public void .ctor(){} // RVA: 0x7FFD57298880
        public void GetLifeSpan(){} // RVA: 0x7FFD5165E940
        public void FetchList(){} // RVA: 0x7FFD57298940
        public void Save(){} // RVA: 0x7FFD572991B0
    }

    public class ApiInventoryBundle : ApiModel
    {
        public URA.woDigitYearMax<string> inventoryItemsToInstantiate; // 0x68
        public _BackingField notificationDetails; // 0x70

        // ── Methods ──
        public void get_inventoryItemsToInstantiate(){} // RVA: 0x7FFD4E3BCD50
        public void set_inventoryItemsToInstantiate(){} // RVA: 0x7FFD4E3BCD60
        public void get_notificationDetails(){} // RVA: 0x7FFD4E409590
        public void set_notificationDetails(){} // RVA: 0x7FFD4E4095A0
        public void .ctor(){} // RVA: 0x7FFD57299B50
    }

    public class ApiInventoryBundleDrop : ApiModel
    {
        public string name;
        public string authorId; // 0x68
        public string targetGroup; // 0x70
        public string templateIds; // 0x78
        public URA.woDigitYearMax<string> startDropDate; // 0x80
        public DependencyInjector endDropDate; // 0x88
        public DependencyInjector dropExpiryDate; // 0x90
        public DependencyInjector status; // 0x98
        public string tags; // 0xA0
        public URA.woDigitYearMax<string> created_at; // 0xA8
        public DependencyInjector updated_at; // 0xB0
        public DependencyInjector notificationDetails; // 0xB8
        public _BackingField <notificationDetails>k__BackingField; // 0xC0

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_authorId(){} // RVA: 0x7FFD4E409590
        public void set_authorId(){} // RVA: 0x7FFD4E4095A0
        public void get_targetGroup(){} // RVA: 0x7FFD4E505600
        public void set_targetGroup(){} // RVA: 0x7FFD4E5006F0
        public void get_templateIds(){} // RVA: 0x7FFD4E70F410
        public void set_templateIds(){} // RVA: 0x7FFD4E8F4AA0
        public void get_startDropDate(){} // RVA: 0x7FFD4E380010
        public void set_startDropDate(){} // RVA: 0x7FFD4FE4BA70
        public void get_endDropDate(){} // RVA: 0x7FFD4E70F640
        public void set_endDropDate(){} // RVA: 0x7FFD4EB25AA0
        public void get_dropExpiryDate(){} // RVA: 0x7FFD4E96DFB0
        public void set_dropExpiryDate(){} // RVA: 0x7FFD53221AA0
        public void get_status(){} // RVA: 0x7FFD4E963900
        public void set_status(){} // RVA: 0x7FFD4E96E420
        public void get_tags(){} // RVA: 0x7FFD4E96B1A0
        public void set_tags(){} // RVA: 0x7FFD4E76B370
        public void get_created_at(){} // RVA: 0x7FFD4E3AC040
        public void set_created_at(){} // RVA: 0x7FFD4F9EA6B0
        public void get_updated_at(){} // RVA: 0x7FFD4E3AC0B0
        public void set_updated_at(){} // RVA: 0x7FFD4F9E9F90
        public void get_notificationDetails(){} // RVA: 0x7FFD4E3AC120
        public void set_notificationDetails(){} // RVA: 0x7FFD4E3AC130
        public void FetchCurrentlyActiveBundleDrops(){} // RVA: 0x7FFD57299BA0
        public void .ctor(){} // RVA: 0x7FFD57299FE0
    }

    public class ApiInventoryItem : ApiModel
    {
        public string templateId;
        public string name; // 0x68
        public string description; // 0x70
        public string imageUrl; // 0x78
        public string attribution; // 0x80
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ubscription_start_time>k__BackingField flags; // 0x88
        public URA.woDigitYearMax<string> tags; // 0x90
        public URA.woDigitYearMax<string> collections; // 0x98
        public URA.woDigitYearMax<string> itemType; // 0xA0
        public string holderId; // 0xA8
        public string firstAncestor; // 0xB0
        public string firstAncestorHolderId; // 0xB8
        public string expiryDate; // 0xC0
        public DependencyInjector created_at; // 0xC8
        public DependencyInjector updated_at; // 0xD0
        public DependencyInjector template_created_at; // 0xD8
        public DependencyInjector template_updated_at; // 0xE0
        public DependencyInjector isArchived; // 0xE8
        public bool isSeen; // 0xF0
        public bool last_equipped_at; // 0xF1
        public DependencyInjector equipSlots; // 0xF8
        public URA.woDigitYearMax<string> equipSlot; // 0x100
        public string quantity; // 0x108
        public int quantifiable; // 0x110
        public bool defaultAttributes; // 0x114
        public URA.DateTime<string,balGiftCount> userAttributes; // 0x118
        public URA.DateTime<string,object> validateUserAttributes; // 0x120
        public bool notificationDetails; // 0x128
        public _BackingField status; // 0x130
        public string metadata; // 0x138
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.tBundleId>k__BackingField Instantiatable; // 0x140
        public string Consumable;
        public string Archivable;
        public string Trashable;
        public string Cloneable;
        public string Equippable;
        public string Equipped;
        public string IsUserGenerated;
        public string IsTemplate;
        public string FLAG_QUANTIFIABLE;
        public string FLAG_QUANTIFIABLE_ALLOW_ZERO;
        public string FLAG_PREMIUM;
        public string FLAG_VRC_PLUS_EXCLUSIVE;
        public string ITEM_TYPE_STICKER;
        public string ITEM_TYPE_EMOJI;
        public string ITEM_TYPE_BUNDLE;
        public string ITEM_TYPE_PROP;
        public string ITEM_TYPE_DRONE_SKIN;
        public string ITEM_TYPE_PORTAL_SKIN;
        public string ITEM_TYPE_WARP_EFFECT;
        public string ITEM_TYPE_LOADING_SCREEN;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5729A140
        public void get_templateId(){} // RVA: 0x7FFD4E3BCD50
        public void set_templateId(){} // RVA: 0x7FFD4E3BCD60
        public void get_name(){} // RVA: 0x7FFD4E409590
        public void set_name(){} // RVA: 0x7FFD4E4095A0
        public void get_description(){} // RVA: 0x7FFD4E505600
        public void set_description(){} // RVA: 0x7FFD4E5006F0
        public void get_imageUrl(){} // RVA: 0x7FFD4E70F410
        public void set_imageUrl(){} // RVA: 0x7FFD4E8F4AA0
        public void get_attribution(){} // RVA: 0x7FFD4E380010
        public void set_attribution(){} // RVA: 0x7FFD4E96E300
        public void get_flags(){} // RVA: 0x7FFD4E70F640
        public void set_flags(){} // RVA: 0x7FFD4E96E360
        public void get_tags(){} // RVA: 0x7FFD4E96DFB0
        public void set_tags(){} // RVA: 0x7FFD4E96E3C0
        public void get_collections(){} // RVA: 0x7FFD4E963900
        public void set_collections(){} // RVA: 0x7FFD4E96E420
        public void get_itemType(){} // RVA: 0x7FFD4E96B1A0
        public void set_itemType(){} // RVA: 0x7FFD4E76B370
        public void get_holderId(){} // RVA: 0x7FFD4E3AC040
        public void set_holderId(){} // RVA: 0x7FFD4E3AC050
        public void get_firstAncestor(){} // RVA: 0x7FFD4E3AC0B0
        public void set_firstAncestor(){} // RVA: 0x7FFD4E3AC0C0
        public void get_firstAncestorHolderId(){} // RVA: 0x7FFD4E3AC120
        public void set_firstAncestorHolderId(){} // RVA: 0x7FFD4E3AC130
        public void get_expiryDate(){} // RVA: 0x7FFD4E499460
        public void set_expiryDate(){} // RVA: 0x7FFD56D990D0
        public void get_created_at(){} // RVA: 0x7FFD4E45E100
        public void set_created_at(){} // RVA: 0x7FFD5448B850
        public void get_updated_at(){} // RVA: 0x7FFD4E960F70
        public void set_updated_at(){} // RVA: 0x7FFD5729A200
        public void get_template_created_at(){} // RVA: 0x7FFD4E3C2900
        public void set_template_created_at(){} // RVA: 0x7FFD5729A210
        public void get_template_updated_at(){} // RVA: 0x7FFD4E3C2970
        public void set_template_updated_at(){} // RVA: 0x7FFD53BCD980
        public void get_isArchived(){} // RVA: 0x7FFD4E3C2AD0
        public void set_isArchived(){} // RVA: 0x7FFD4E3C2AE0
        public void get_isSeen(){} // RVA: 0x7FFD4F286790
        public void set_isSeen(){} // RVA: 0x7FFD4F282B70
        public void get_last_equipped_at(){} // RVA: 0x7FFD4E751F50
        public void set_last_equipped_at(){} // RVA: 0x7FFD51B35870
        public void get_equipSlots(){} // RVA: 0x7FFD4E916C80
        public void set_equipSlots(){} // RVA: 0x7FFD4E916750
        public void get_equipSlot(){} // RVA: 0x7FFD4EAF1F40
        public void set_equipSlot(){} // RVA: 0x7FFD4ED49BF0
        public void get_quantity(){} // RVA: 0x7FFD4ED671E0
        public void set_quantity(){} // RVA: 0x7FFD4F9B7C80
        public void get_quantifiable(){} // RVA: 0x7FFD5729A220
        public void set_quantifiable(){} // RVA: 0x7FFD5729A230
        public void get_defaultAttributes(){} // RVA: 0x7FFD4E7DC6D0
        public void set_defaultAttributes(){} // RVA: 0x7FFD4E7D8580
        public void get_userAttributes(){} // RVA: 0x7FFD4E55CBB0
        public void set_userAttributes(){} // RVA: 0x7FFD4E563400
        public void get_validateUserAttributes(){} // RVA: 0x7FFD4E751A00
        public void set_validateUserAttributes(){} // RVA: 0x7FFD4E74DA60
        public void get_notificationDetails(){} // RVA: 0x7FFD4E964340
        public void set_notificationDetails(){} // RVA: 0x7FFD4EDC79B0
        public void get_status(){} // RVA: 0x7FFD4E9622C0
        public void set_status(){} // RVA: 0x7FFD4EAF84B0
        public void get_metadata(){} // RVA: 0x7FFD4E3AC5F0
        public void set_metadata(){} // RVA: 0x7FFD4E3AC600
        public void get_Instantiatable(){} // RVA: 0x7FFD5729A240
        public void get_Consumable(){} // RVA: 0x7FFD5729A2B0
        public void get_Archivable(){} // RVA: 0x7FFD5729A320
        public void get_Trashable(){} // RVA: 0x7FFD5729A390
        public void get_Cloneable(){} // RVA: 0x7FFD5729A400
        public void get_Equippable(){} // RVA: 0x7FFD5729A470
        public void get_Equipped(){} // RVA: 0x7FFD5729A500
        public void get_IsUserGenerated(){} // RVA: 0x7FFD5729A540
        public void get_IsTemplate(){} // RVA: 0x7FFD5729A5B0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFD5729A800 | overloaded x2
        public void GetModelForMetadataType(){} // RVA: 0x7FFD5729AA20
        public void FetchList(){} // RVA: 0x7FFD5729AFB0
        public void Fetch(){} // RVA: 0x7FFD5729C400
        public void SetIsArchived(){} // RVA: 0x7FFD5729C730
        public void SetIsSeen(){} // RVA: 0x7FFD5729CBC0
        public void Consume(){} // RVA: 0x7FFD5729D050 | overloaded x2
        public void FetchInventoryTemplate(){} // RVA: 0x7FFD5729D3D0
        public void FetchInventoryTemplateAsync(){} // RVA: 0x7FFD5729D700
        public void FetchUserInventoryItem(){} // RVA: 0x7FFD5729D8A0
        public void Equip(){} // RVA: 0x7FFD5729DBF0
        public void ClearEquipSlot(){} // RVA: 0x7FFD5729E230
        public void SaveUserAttributes(){} // RVA: 0x7FFD5729E520
        public void FetchEquipped(){} // RVA: 0x7FFD5729EA90
        public void GetAttributes(){} // RVA: 0x7FFD5729F0A0
        public void GetDefaultAttributes(){} // RVA: 0x7FFD5729F390
        public void FetchAllTemplates(){} // RVA: 0x7FFD5729F5D0
    }

    public class ApiInventoryJweToken : ApiModel
    {
        public object token;

        // ── Methods ──
        public void get_token(){} // RVA: 0x7FFD4E3BCD50
        public void set_token(){} // RVA: 0x7FFD4E3BCD60
        public void RequestSpawnToken(){} // RVA: 0x7FFD572A0D10
        public void RequestDirectShareToken(){} // RVA: 0x7FFD572A1210
        public void RequestPedestalShareToken(){} // RVA: 0x7FFD572A1760
        public void RequestClone(){} // RVA: 0x7FFD572A1E70
        public void .ctor(){} // RVA: 0x7FFD572A2370
    }

    public class ApiLedgerTransaction : ApiModel
    {
        public int Amount; // 0x68
        public int RunningBalance; // 0x6C
        public DependencyInjector Date; // 0x70
        public string ListingDisplayName; // 0x78
        public string ListingID; // 0x80
        public string ListingType; // 0x88
        public string Platform; // 0x90
        public string PurchaseId; // 0x98
        public int Reason; // 0xA0
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ce_code ReasonLabel; // 0xA8
        public string ToUserId; // 0xB0
        public string ToUserDisplayName; // 0xB8
        public string FromUserId; // 0xC0
        public string FromUserDisplayName; // 0xC8
        public long TransactionId; // 0xD0
        public long TransactionLineId; // 0xD8

        // ── Methods ──
        public void get_Amount(){} // RVA: 0x7FFD4FBDAB50
        public void set_Amount(){} // RVA: 0x7FFD4FBDAB60
        public void get_RunningBalance(){} // RVA: 0x7FFD4FBDAB70
        public void set_RunningBalance(){} // RVA: 0x7FFD4FBDAB80
        public void get_Date(){} // RVA: 0x7FFD4E409590
        public void set_Date(){} // RVA: 0x7FFD4FE4BA60
        public void get_ListingDisplayName(){} // RVA: 0x7FFD4E505600
        public void set_ListingDisplayName(){} // RVA: 0x7FFD4E5006F0
        public void get_ListingID(){} // RVA: 0x7FFD4E70F410
        public void set_ListingID(){} // RVA: 0x7FFD4E8F4AA0
        public void get_ListingType(){} // RVA: 0x7FFD4E380010
        public void set_ListingType(){} // RVA: 0x7FFD4E96E300
        public void get_Platform(){} // RVA: 0x7FFD4E70F640
        public void set_Platform(){} // RVA: 0x7FFD4E96E360
        public void get_PurchaseId(){} // RVA: 0x7FFD4E96DFB0
        public void set_PurchaseId(){} // RVA: 0x7FFD4E96E3C0
        public void get_Reason(){} // RVA: 0x7FFD4FCBE510
        public void set_Reason(){} // RVA: 0x7FFD4FCBE550
        public void get_ReasonLabel(){} // RVA: 0x7FFD4E96B1A0
        public void set_ReasonLabel(){} // RVA: 0x7FFD4E76B370
        public void get_ToUserId(){} // RVA: 0x7FFD4E3AC040
        public void set_ToUserId(){} // RVA: 0x7FFD4E3AC050
        public void get_ToUserDisplayName(){} // RVA: 0x7FFD4E3AC0B0
        public void set_ToUserDisplayName(){} // RVA: 0x7FFD4E3AC0C0
        public void get_FromUserId(){} // RVA: 0x7FFD4E3AC120
        public void set_FromUserId(){} // RVA: 0x7FFD4E3AC130
        public void get_FromUserDisplayName(){} // RVA: 0x7FFD4E499460
        public void set_FromUserDisplayName(){} // RVA: 0x7FFD4E499470
        public void get_TransactionId(){} // RVA: 0x7FFD4E45E100
        public void set_TransactionId(){} // RVA: 0x7FFD5448B850
        public void get_TransactionLineId(){} // RVA: 0x7FFD4E960F70
        public void set_TransactionLineId(){} // RVA: 0x7FFD5729A200
        public void get_id(){} // RVA: 0x7FFD572A2570
        public void .ctor(){} // RVA: 0x7FFD572A2610
    }

    public class ApiLedgerTransactions : ApiModel
    {
        public DependencyInjector StartDate; // 0x68
        public DependencyInjector EndDate; // 0x70
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.lug> Transactions; // 0x78

        // ── Methods ──
        public void get_StartDate(){} // RVA: 0x7FFD4E3BCD50
        public void set_StartDate(){} // RVA: 0x7FFD4FE4BA80
        public void get_EndDate(){} // RVA: 0x7FFD4E409590
        public void set_EndDate(){} // RVA: 0x7FFD4FE4BA60
        public void get_Transactions(){} // RVA: 0x7FFD4E505600
        public void set_Transactions(){} // RVA: 0x7FFD4E5006F0
        public void .ctor(){} // RVA: 0x7FFD572A2520
    }

    public class ApiListContainer : ApiContainer
    {
        public int ResponseList; // 0x60

        // ── Methods ──
        public void get_ResponseList(){} // RVA: 0x7FFD572ED040
        public void get_TotalCount(){} // RVA: 0x7FFD4E558C20
        public void set_TotalCount(){} // RVA: 0x7FFD4E558C10
        public void Validate(){} // RVA: 0x7FFD572ED0B0
        public void .ctor(){} // RVA: 0x7FFD572ED430
    }

    public class ApiLoadingScreen : ApiModel
    {
        public string name; // 0x68
        public string assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_assetBundleId(){} // RVA: 0x7FFD4E409590
        public void set_assetBundleId(){} // RVA: 0x7FFD4E4095A0
        public void .ctor(){} // RVA: 0x7FFD572A3B00
    }

    public class ApiMessage : ApiModel
    {
        public URA.DateTime<ÏÏÍÍÌÌÎÍ,string> slot;
        public int message;
        public int messageType; // 0x68
        public string updatedAt; // 0x70
        public string remainingCooldownMinutes; // 0x78
        public DependencyInjector canBeUpdated; // 0x80
        public int <remainingCooldownMinutes>k__BackingField; // 0x88
        public bool <canBeUpdated>k__BackingField; // 0x8C

        // ── Methods ──
        public void get_slot(){} // RVA: 0x7FFD4FBDAB50
        public void set_slot(){} // RVA: 0x7FFD4FBDAB60
        public void get_message(){} // RVA: 0x7FFD4E409590
        public void set_message(){} // RVA: 0x7FFD4E4095A0
        public void get_messageType(){} // RVA: 0x7FFD4E505600
        public void set_messageType(){} // RVA: 0x7FFD4E5006F0
        public void get_updatedAt(){} // RVA: 0x7FFD4E70F410
        public void set_updatedAt(){} // RVA: 0x7FFD4FE4BA90
        public void get_remainingCooldownMinutes(){} // RVA: 0x7FFD4EC0E8C0
        public void set_remainingCooldownMinutes(){} // RVA: 0x7FFD4EC19DE0
        public void get_canBeUpdated(){} // RVA: 0x7FFD4E3A9520
        public void set_canBeUpdated(){} // RVA: 0x7FFD4E3A9530
        public void .ctor(){} // RVA: 0x7FFD572A3B50
        public void FetchMessages(){} // RVA: 0x7FFD572A3D20 | overloaded x2
        public void DeleteAllMessages(){} // RVA: 0x7FFD572A41C0 | overloaded x2
        public void DeleteMessageInSlot(){} // RVA: 0x7FFD572A4680 | overloaded x2
        public void SetMessageInSlot(){} // RVA: 0x7FFD572A4BD0 | overloaded x2
        public void truncatedMessage(){} // RVA: 0x7FFD572A5200
        public void ToString(){} // RVA: 0x7FFD572A5270
        public void .cctor(){} // RVA: 0x7FFD572A5480
    }

    public class ApiModel : Object
    {
        public URA.DateTime<string,ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.InSlot>b__0> id;
        public int ExpiryTime;
        public int Populated; // 0x8
        public object FailedValidation; // 0x10
        public string Endpoint; // 0x10
        public aphy<long> FieldsMissingFromOriginalResponse; // 0x18
        public bool FieldsLockedForNetworkUpdates; // 0x28
        public bool RequiredProperties; // 0x29
        public string TargetProperties; // 0x30
        public string _cacheIdInput; // 0x38
        public string _cacheId; // 0x40
        public em.MarkAborted.izeDefaultCase _cacheIdBuilder; // 0x18
        public URA.DateTime<int,URA.onsDepth<string>> _missingFieldCache; // 0x20
        public URA.onsDepth<string> <FieldsMissingFromOriginalResponse>k__BackingField; // 0x48
        public URA.onsDepth<string> <FieldsLockedForNetworkUpdates>k__BackingField; // 0x50
        public object supportedPlatforms; // 0x58
        public int RESPONSE_FIELDS_HASH_OFFSET;
        public int RESPONSE_FIELDS_HASH_MULTIPLIER;
        public object modelContainerType; // 0x60
        public URA.DateTime<?,m.jectMapInfo> CreateFromJsonCache; // 0x28
        public URA.DateTime<?,URA.DateTime<oRegistry<char>,object>> EnumValuesCache; // 0x30
        public URA.DateTime<?,URA.woDigitYearMax<string>> _requiredProperties; // 0x38
        public URA.DateTime<?,URA.woDigitYearMax<m.ber>> _targetProperties; // 0x40
        public URA.DateTime<m.ber,string> PropertyApiFieldNames; // 0x48
        public URA.DateTime<?,URA.DateTime<string,m.ber>> foundProperties; // 0x50

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFD4E35C380
        public void set_id(){} // RVA: 0x7FFD4E342E30
        public void get_ExpiryTime(){} // RVA: 0x7FFD4E9F3330
        public void set_ExpiryTime(){} // RVA: 0x7FFD4E9F34F0
        public void get_Populated(){} // RVA: 0x7FFD4E516BA0
        public void set_Populated(){} // RVA: 0x7FFD4F044F40
        public void get_FailedValidation(){} // RVA: 0x7FFD4EC8C550
        public void set_FailedValidation(){} // RVA: 0x7FFD4F7D4D70
        public void get_Endpoint(){} // RVA: 0x7FFD4E5F95E0
        public void set_Endpoint(){} // RVA: 0x7FFD4E36F890
        public void GetOrPutCachedMissingFieldList(){} // RVA: 0x7FFD572A5990
        public void get_FieldsMissingFromOriginalResponse(){} // RVA: 0x7FFD4E3BC730
        public void set_FieldsMissingFromOriginalResponse(){} // RVA: 0x7FFD4E3BC740
        public void get_FieldsLockedForNetworkUpdates(){} // RVA: 0x7FFD4E3E20E0
        public void set_FieldsLockedForNetworkUpdates(){} // RVA: 0x7FFD4E4994D0
        public void GetCacheId(){} // RVA: 0x7FFD572A6270
        public void ComputeCacheId(){} // RVA: 0x7FFD572A6530
        public void ShouldCache(){} // RVA: 0x7FFD572A6940
        public void GetLifeSpan(){} // RVA: 0x7FFD572A6980
        public void .ctor(){} // RVA: 0x7FFD572A6A60 | overloaded x3
        public void Clone(){} // RVA: 0x7FFD572A6CF0 | overloaded x3
        public void Save(){} // RVA: 0x7FFD572A7240
        public void SaveField(){} // RVA: 0x7FFD572A7280
        public void Post(){} // RVA: 0x7FFD572A7550
        public void Put(){} // RVA: 0x7FFD572A7590
        public void Fetch(){} // RVA: 0x7FFD572A75D0
        public void PostAsync(){} // RVA: 0x7FFD4E2ADC40
        public void PutAsync(){} // RVA: 0x7FFD4E2ADC40
        public void FetchAsync(){} // RVA: 0x7FFD4E2ADC40
        public void Get(){} // RVA: 0x7FFD572A7600
        public void PostOrPut(){} // RVA: 0x7FFD572A7E70
        public void Delete(){} // RVA: 0x7FFD572A9650
        public void DeleteAsync(){} // RVA: 0x7FFD572A98F0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFD572AABE0 | overloaded x4
        public void PopulateMissingValuesFrom(){} // RVA: 0x7FFD572AB940
        public void ExtractApiFields(){} // RVA: 0x7FFD572ABE00
        public void MakeModelContainer(){} // RVA: 0x7FFD572AC1E0
        public void ReadField(){} // RVA: 0x7FFD572AC460
        public void TryReadConvert(){} // RVA: 0x7FFD572AC850
        public void WriteField(){} // RVA: 0x7FFD572ADD00
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFD4E341320
        public void GetCreateFromJsonMethodInfo(){} // RVA: 0x7FFD572AEC80
        public void ParseEnumValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void IsNumber(){} // RVA: 0x7FFD572AF270
        public void DoubleCast(){} // RVA: 0x7FFD572AF320
        public void TryWriteConvert(){} // RVA: 0x7FFD572AF6F0
        public void ParseList(){} // RVA: 0x7FFD572B0800
        public void ParseDictionary(){} // RVA: 0x7FFD572B0CC0
        public void ParseModel(){} // RVA: 0x7FFD572B14C0
        public void ParseLocalizableString(){} // RVA: 0x7FFD572B1710
        public void SendGetRequest(){} // RVA: 0x7FFD572B18F0
        public void SendPutRequest(){} // RVA: 0x7FFD572B1BA0
        public void MakeRequestEndpoint(){} // RVA: 0x7FFD572B1C70
        public void get_RequiredProperties(){} // RVA: 0x7FFD572B1D20
        public void get_TargetProperties(){} // RVA: 0x7FFD572B2360
        public void FindPropertyName(){} // RVA: 0x7FFD572B2780
        public void FindProperty(){} // RVA: 0x7FFD572B2A90
        public void IsAdminWritableOnly(){} // RVA: 0x7FFD572B2F80
        public void IsApiWritableOnly(){} // RVA: 0x7FFD572B3170
        public void .cctor(){} // RVA: 0x7FFD572B3360
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFD4E079D00
        public void Validate(){}
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public URA.saAbbrevMonthNames<T1717580816> ResponseModels;

        // ── Methods ──
        public void get_ResponseModels(){} // RVA: 0x7FFD4E078E90
        public void set_ResponseModels(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Validate(){}
    }

    public class ApiModeration : ApiModel
    {
        public float moderationType;
        public IsPowerOfTwo moderatorUserId; // 0x68
        public string moderatorDisplayName; // 0x70
        public string targetUserId; // 0x78
        public string targetDisplayName; // 0x80
        public string reasonMessage; // 0x88
        public string details; // 0x90
        public URA.DateTime<string,object> created; // 0x98
        public DependencyInjector expires; // 0xA0
        public DependencyInjector isPermanent; // 0xA8
        public aphy<>k__BackingField> worldId; // 0xB0
        public bool instanceId; // 0xB8
        public string <worldId>k__BackingField; // 0xC0
        public string <instanceId>k__BackingField; // 0xC8

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7FFD4FBDAB50
        public void set_moderationType(){} // RVA: 0x7FFD4FBDAB60
        public void get_moderatorUserId(){} // RVA: 0x7FFD4E409590
        public void set_moderatorUserId(){} // RVA: 0x7FFD4E4095A0
        public void get_moderatorDisplayName(){} // RVA: 0x7FFD4E505600
        public void set_moderatorDisplayName(){} // RVA: 0x7FFD4E5006F0
        public void get_targetUserId(){} // RVA: 0x7FFD4E70F410
        public void set_targetUserId(){} // RVA: 0x7FFD4E8F4AA0
        public void get_targetDisplayName(){} // RVA: 0x7FFD4E380010
        public void set_targetDisplayName(){} // RVA: 0x7FFD4E96E300
        public void get_reasonMessage(){} // RVA: 0x7FFD4E70F640
        public void set_reasonMessage(){} // RVA: 0x7FFD4E96E360
        public void get_details(){} // RVA: 0x7FFD4E96DFB0
        public void set_details(){} // RVA: 0x7FFD4E96E3C0
        public void get_created(){} // RVA: 0x7FFD4E963900
        public void set_created(){} // RVA: 0x7FFD53BAD950
        public void get_expires(){} // RVA: 0x7FFD4E96B1A0
        public void set_expires(){} // RVA: 0x7FFD4F9E9F60
        public void get_isPermanent(){} // RVA: 0x7FFD4F611470
        public void set_isPermanent(){} // RVA: 0x7FFD4F60EB20
        public void get_worldId(){} // RVA: 0x7FFD4E3AC120
        public void set_worldId(){} // RVA: 0x7FFD4E3AC130
        public void get_instanceId(){} // RVA: 0x7FFD4E499460
        public void set_instanceId(){} // RVA: 0x7FFD4E499470
        public void .ctor(){} // RVA: 0x7FFD572B4A60 | overloaded x2
        public void ShouldCache(){} // RVA: 0x7FFD4E341320
        public void ReadField(){} // RVA: 0x7FFD572B4B00
        public void WriteField(){} // RVA: 0x7FFD572B4F80
        public void SendModeration(){} // RVA: 0x7FFD572B51B0
        public void SendVoteKick(){} // RVA: 0x7FFD572B5570
        public void DeleteModeration(){} // RVA: 0x7FFD572B58A0
        public void LocalFetchAll(){} // RVA: 0x7FFD572B5AC0
        public void ModerationTimeRangeToString(){} // RVA: 0x7FFD572B5DC0
        public void ContestModeration(){} // RVA: 0x7FFD572B5E60
    }

    public class ApiMutualFriend : ApiModel
    {
        public string id; // 0x68
        public string displayName; // 0x70
        public string status; // 0x78
        public string statusDescription; // 0x80
        public string currentAvatarImageUrl; // 0x88
        public string[] avatarThumbnail; // 0x90
        public string currentAvatarTags; // 0x98
        public string profilePicOverride; // 0xA0
        public string userIcon; // 0xA8
        public string world; // 0xB0
        public string instance; // 0xB8
        public string instanceType; // 0xC0
        public string travelingToWorld; // 0xC8
        public string travelingToInstance; // 0xD0
        public string[] platform; // 0xD8

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFD4E35C380
        public void set_id(){} // RVA: 0x7FFD4E342E30
        public void get_displayName(){} // RVA: 0x7FFD4E3BCD50
        public void set_displayName(){} // RVA: 0x7FFD4E3BCD60
        public void get_status(){} // RVA: 0x7FFD4E409590
        public void set_status(){} // RVA: 0x7FFD4E4095A0
        public void get_statusDescription(){} // RVA: 0x7FFD4E505600
        public void set_statusDescription(){} // RVA: 0x7FFD4E5006F0
        public void get_currentAvatarImageUrl(){} // RVA: 0x7FFD4E70F410
        public void set_currentAvatarImageUrl(){} // RVA: 0x7FFD4E8F4AA0
        public void get_avatarThumbnail(){} // RVA: 0x7FFD4E380010
        public void set_avatarThumbnail(){} // RVA: 0x7FFD4E96E300
        public void get_currentAvatarTags(){} // RVA: 0x7FFD4E70F640
        public void set_currentAvatarTags(){} // RVA: 0x7FFD4E96E360
        public void get_profilePicOverride(){} // RVA: 0x7FFD4E96DFB0
        public void set_profilePicOverride(){} // RVA: 0x7FFD4E96E3C0
        public void get_userIcon(){} // RVA: 0x7FFD4E963900
        public void set_userIcon(){} // RVA: 0x7FFD4E96E420
        public void get_world(){} // RVA: 0x7FFD4E96B1A0
        public void set_world(){} // RVA: 0x7FFD4E76B370
        public void get_instance(){} // RVA: 0x7FFD4E3AC040
        public void set_instance(){} // RVA: 0x7FFD4E3AC050
        public void get_instanceType(){} // RVA: 0x7FFD4E3AC0B0
        public void set_instanceType(){} // RVA: 0x7FFD4E3AC0C0
        public void get_travelingToWorld(){} // RVA: 0x7FFD4E3AC120
        public void set_travelingToWorld(){} // RVA: 0x7FFD4E3AC130
        public void get_travelingToInstance(){} // RVA: 0x7FFD4E499460
        public void set_travelingToInstance(){} // RVA: 0x7FFD4E499470
        public void get_platform(){} // RVA: 0x7FFD4E45E100
        public void set_platform(){} // RVA: 0x7FFD4E45E110
        public void get_groups(){} // RVA: 0x7FFD4E960F70
        public void set_groups(){} // RVA: 0x7FFD4E3C28A0
        public void get_profilePicImageUrl(){} // RVA: 0x7FFD57344D40
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x7FFD57344D60
        public void FetchMutualFriendsAsync(){} // RVA: 0x7FFD57344D90
        public void .ctor(){} // RVA: 0x7FFD57344F60
    }

    public class ApiMutualGroup : ApiModel
    {
        public string id; // 0x68
        public string name; // 0x70
        public string discriminator; // 0x78
        public string ownerId; // 0x80
        public int privacy; // 0x88
        public string memberCount; // 0x90
        public string shortCode; // 0x98
        public string description; // 0xA0
        public string bannerId; // 0xA8
        public string bannerUrl; // 0xB0
        public string iconId; // 0xB8
        public string iconUrl; // 0xC0

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFD4E35C380
        public void set_id(){} // RVA: 0x7FFD4E342E30
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_discriminator(){} // RVA: 0x7FFD4E409590
        public void set_discriminator(){} // RVA: 0x7FFD4E4095A0
        public void get_ownerId(){} // RVA: 0x7FFD4E505600
        public void set_ownerId(){} // RVA: 0x7FFD4E5006F0
        public void get_privacy(){} // RVA: 0x7FFD4E70F410
        public void set_privacy(){} // RVA: 0x7FFD4E8F4AA0
        public void get_memberCount(){} // RVA: 0x7FFD4EC0E8C0
        public void set_memberCount(){} // RVA: 0x7FFD4EC19DE0
        public void get_shortCode(){} // RVA: 0x7FFD4E70F640
        public void set_shortCode(){} // RVA: 0x7FFD4E96E360
        public void get_description(){} // RVA: 0x7FFD4E96DFB0
        public void set_description(){} // RVA: 0x7FFD4E96E3C0
        public void get_bannerId(){} // RVA: 0x7FFD4E963900
        public void set_bannerId(){} // RVA: 0x7FFD4E96E420
        public void get_bannerUrl(){} // RVA: 0x7FFD4E96B1A0
        public void set_bannerUrl(){} // RVA: 0x7FFD4E76B370
        public void get_iconId(){} // RVA: 0x7FFD4E3AC040
        public void set_iconId(){} // RVA: 0x7FFD4E3AC050
        public void get_iconUrl(){} // RVA: 0x7FFD4E3AC0B0
        public void set_iconUrl(){} // RVA: 0x7FFD4E3AC0C0
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFD4E3AC120
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFD4E3AC130
        public void FetchMutualGroupsAsync(){} // RVA: 0x7FFD57345C40
        public void .ctor(){} // RVA: 0x7FFD57345E10
    }

    public class ApiPlayerModeration : ApiModel
    {
        public float moderationType;
        public IsPowerOfTwo targetUserId; // 0x68
        public string targetDisplayName; // 0x70
        public string sourceUserId; // 0x78
        public string sourceDisplayName; // 0x80
        public string created; // 0x88
        public DependencyInjector <created>k__BackingField; // 0x90

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7FFD4FBDAB50
        public void set_moderationType(){} // RVA: 0x7FFD4FBDAB60
        public void get_targetUserId(){} // RVA: 0x7FFD4E409590
        public void set_targetUserId(){} // RVA: 0x7FFD4E4095A0
        public void get_targetDisplayName(){} // RVA: 0x7FFD4E505600
        public void set_targetDisplayName(){} // RVA: 0x7FFD4E5006F0
        public void get_sourceUserId(){} // RVA: 0x7FFD4E70F410
        public void set_sourceUserId(){} // RVA: 0x7FFD4E8F4AA0
        public void get_sourceDisplayName(){} // RVA: 0x7FFD4E380010
        public void set_sourceDisplayName(){} // RVA: 0x7FFD4E96E300
        public void get_created(){} // RVA: 0x7FFD4E70F640
        public void set_created(){} // RVA: 0x7FFD4EB25AA0
        public void .ctor(){} // RVA: 0x7FFD572B6BA0
        public void CreateRemovalModeration(){} // RVA: 0x7FFD572B6C60
        public void ShouldCache(){} // RVA: 0x7FFD4E341320
        public void ReadField(){} // RVA: 0x7FFD572B6D20
        public void WriteField(){} // RVA: 0x7FFD572B6F20
        public void SendModeration(){} // RVA: 0x7FFD572B7100
        public void DeleteModeration(){} // RVA: 0x7FFD572B7340
        public void FetchAllAgainstMe(){} // RVA: 0x7FFD572B7900
        public void FetchAllMine(){} // RVA: 0x7FFD572B7950
        public void FetchList(){} // RVA: 0x7FFD572B79A0
        public void ModerationTypeToAPIString(){} // RVA: 0x7FFD572B7C80
    }

    public class ApiPortalSkin : ApiModel
    {
        public string name; // 0x68
        public string assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_assetBundleId(){} // RVA: 0x7FFD4E409590
        public void set_assetBundleId(){} // RVA: 0x7FFD4E4095A0
        public void .ctor(){} // RVA: 0x7FFD572B8150
    }

    public class ApiPrint : ApiModel
    {
        public string note; // 0x68
        public string authorId; // 0x70
        public string authorName; // 0x78
        public string worldId; // 0x80
        public string worldName; // 0x88
        public string ownerId; // 0x90
        public DependencyInjector timestamp; // 0x98
        public s files; // 0xA0
        public DependencyInjector createdAt; // 0xA8

        // ── Methods ──
        public void get_note(){} // RVA: 0x7FFD4E3BCD50
        public void set_note(){} // RVA: 0x7FFD4E3BCD60
        public void get_authorId(){} // RVA: 0x7FFD4E409590
        public void set_authorId(){} // RVA: 0x7FFD4E4095A0
        public void get_authorName(){} // RVA: 0x7FFD4E505600
        public void set_authorName(){} // RVA: 0x7FFD4E5006F0
        public void get_worldId(){} // RVA: 0x7FFD4E70F410
        public void set_worldId(){} // RVA: 0x7FFD4E8F4AA0
        public void get_worldName(){} // RVA: 0x7FFD4E380010
        public void set_worldName(){} // RVA: 0x7FFD4E96E300
        public void get_ownerId(){} // RVA: 0x7FFD4E70F640
        public void set_ownerId(){} // RVA: 0x7FFD4E96E360
        public void get_timestamp(){} // RVA: 0x7FFD4E96DFB0
        public void set_timestamp(){} // RVA: 0x7FFD53221AA0
        public void get_files(){} // RVA: 0x7FFD4E963900
        public void set_files(){} // RVA: 0x7FFD4E96E420
        public void get_createdAt(){} // RVA: 0x7FFD4E96B1A0
        public void set_createdAt(){} // RVA: 0x7FFD4F9E9F60
        public void .ctor(){} // RVA: 0x7FFD572B81A0
        public void GetFileURL(){} // RVA: 0x7FFD572B82A0
        public void GetImageURL(){} // RVA: 0x7FFD572B82C0
        public void Upload(){} // RVA: 0x7FFD572B8310
        public void UpdatePrint(){} // RVA: 0x7FFD572B8830
        public void GetPrints(){} // RVA: 0x7FFD572B8C90
        public void GetPrint(){} // RVA: 0x7FFD572B91D0
    }

    public class ApiProduct : ApiModel
    {
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.t_verification_uri Type; // 0x68
        public DependencyInjector CreatedAt; // 0x70
        public DependencyInjector UpdatedAt; // 0x78
        public string SellerId; // 0x80
        public string AvatarId; // 0x88
        public string SellerDisplayName; // 0x90
        public string Name; // 0x98
        public string Description; // 0xA0
        public string Subtitle; // 0xA8
        public string ProductImageId; // 0xB0
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ubscription_start_time>k__BackingField ProductImageUrl; // 0xB8
        public string attribution; // 0xC0
        public URA.woDigitYearMax<string> LicenseId; // 0xC8
        public bool Tags; // 0xD0
        public DependencyInjector SoldByVrc; // 0xD8
        public URA.DateTime<string,object> UntilDate; // 0xE0
        public bool PurchaseToken; // 0xE8
        public URA.woDigitYearMax<string> IsVoided; // 0xF0
        public string ParentListings; // 0xF8
        public bool ProductTypeLabel; // 0x100
        public string Quantifiable; // 0x108
        public string GroupId; // 0x110
        public bool GroupRoleId; // 0x118
        public bool GroupAccess; // 0x119
        public string GroupAccessRemove; // 0x120
        public string InventoryItemTemplateId; // 0x128
        public int InventoryItemType; // 0x130
        public bool InventoryItemQuantity; // 0x134
        public string AssetDisabled; // 0x138
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.eyString ListingID; // 0x140
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ift> ListingType; // 0x148
        public URA.woDigitYearMax<string> Products; // 0x150
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ift> ProductIDs; // 0x158
        public bool HydratedProducts; // 0x160
        public bool Active; // 0x161
        public int SubscriberExclusive; // 0x164
        public int Price; // 0x168
        public DependencyInjector VrcPlusDiscountPrice; // 0x170
        public string AvailableToPurchaseUntilDate; // 0x178
        public string CollaboratorUserId; // 0x180
        public aphy<int> CollaboratorUserDisplayName; // 0x188
        public URA.woDigitYearMax<string> Stock; // 0x190
        public int StoreIDs; // 0x198
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ._BackingField Duration; // 0x19C
        public bool DurationType; // 0x1A0
        public bool Archived; // 0x1A1
        public bool Permanent; // 0x1A2
        public bool Instant; // 0x1A3
        public bool Stackable; // 0x1A4
        public bool Recurrable; // 0x1A5
        public bool Refundable; // 0x1A6
        public bool BuyerRefundable; // 0x1A7
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.__BackingField> ContextPreventsPurchase; // 0x1A8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD572E21E0
        public void get_Type(){} // RVA: 0x7FFD4FBDAB50
        public void set_Type(){} // RVA: 0x7FFD4FBDAB60
        public void get_CreatedAt(){} // RVA: 0x7FFD4E409590
        public void set_CreatedAt(){} // RVA: 0x7FFD4FE4BA60
        public void get_UpdatedAt(){} // RVA: 0x7FFD4E505600
        public void set_UpdatedAt(){} // RVA: 0x7FFD53666500
        public void get_SellerId(){} // RVA: 0x7FFD4E70F410
        public void set_SellerId(){} // RVA: 0x7FFD4E8F4AA0
        public void get_AvatarId(){} // RVA: 0x7FFD4E380010
        public void set_AvatarId(){} // RVA: 0x7FFD4E96E300
        public void get_SellerDisplayName(){} // RVA: 0x7FFD4E70F640
        public void set_SellerDisplayName(){} // RVA: 0x7FFD4E96E360
        public void get_Name(){} // RVA: 0x7FFD4E96DFB0
        public void set_Name(){} // RVA: 0x7FFD4E96E3C0
        public void get_Description(){} // RVA: 0x7FFD4E963900
        public void set_Description(){} // RVA: 0x7FFD4E96E420
        public void get_Subtitle(){} // RVA: 0x7FFD4E96B1A0
        public void set_Subtitle(){} // RVA: 0x7FFD4E76B370
        public void get_ProductImageId(){} // RVA: 0x7FFD4E3AC040
        public void set_ProductImageId(){} // RVA: 0x7FFD4E3AC050
        public void get_ProductImageUrl(){} // RVA: 0x7FFD572E22A0
        public void get_attribution(){} // RVA: 0x7FFD4E3AC0B0
        public void set_attribution(){} // RVA: 0x7FFD4E3AC0C0
        public void get_LicenseId(){} // RVA: 0x7FFD4E3AC120
        public void set_LicenseId(){} // RVA: 0x7FFD4E3AC130
        public void get_Tags(){} // RVA: 0x7FFD4E499460
        public void set_Tags(){} // RVA: 0x7FFD4E499470
        public void get_SoldByVrc(){} // RVA: 0x7FFD4E7EFDE0
        public void set_SoldByVrc(){} // RVA: 0x7FFD4F743510
        public void get_UntilDate(){} // RVA: 0x7FFD4E960F70
        public void set_UntilDate(){} // RVA: 0x7FFD5729A200
        public void get_PurchaseToken(){} // RVA: 0x7FFD4E3C2900
        public void set_PurchaseToken(){} // RVA: 0x7FFD4E3C2910
        public void get_IsVoided(){} // RVA: 0x7FFD4F3F4640
        public void set_IsVoided(){} // RVA: 0x7FFD4FDBC5B0
        public void get_ParentListings(){} // RVA: 0x7FFD4E3AC2A0
        public void set_ParentListings(){} // RVA: 0x7FFD4E3AC2B0
        public void get_ProductTypeLabel(){} // RVA: 0x7FFD4E751F50
        public void set_ProductTypeLabel(){} // RVA: 0x7FFD4E8C4860
        public void get_Quantifiable(){} // RVA: 0x7FFD4F0AB9C0
        public void set_Quantifiable(){} // RVA: 0x7FFD4F0ADFF0
        public void get_GroupId(){} // RVA: 0x7FFD4EAF1F40
        public void set_GroupId(){} // RVA: 0x7FFD4ED49BF0
        public void get_GroupRoleId(){} // RVA: 0x7FFD4E96B170
        public void set_GroupRoleId(){} // RVA: 0x7FFD4EDD3E10
        public void get_GroupAccess(){} // RVA: 0x7FFD572E2310
        public void set_GroupAccess(){} // RVA: 0x7FFD572E2320
        public void get_GroupAccessRemove(){} // RVA: 0x7FFD572E2330
        public void set_GroupAccessRemove(){} // RVA: 0x7FFD572E2340
        public void get_InventoryItemTemplateId(){} // RVA: 0x7FFD4E55CBB0
        public void set_InventoryItemTemplateId(){} // RVA: 0x7FFD4E563400
        public void get_InventoryItemType(){} // RVA: 0x7FFD4E9666F0
        public void set_InventoryItemType(){} // RVA: 0x7FFD4EDE51C0
        public void get_InventoryItemQuantity(){} // RVA: 0x7FFD4E7DC1B0
        public void set_InventoryItemQuantity(){} // RVA: 0x7FFD5497CD90
        public void get_AssetDisabled(){} // RVA: 0x7FFD572E2350
        public void set_AssetDisabled(){} // RVA: 0x7FFD572E2360
        public void get_ListingID(){} // RVA: 0x7FFD4E9622C0
        public void set_ListingID(){} // RVA: 0x7FFD4EAF84B0
        public void get_ListingType(){} // RVA: 0x7FFD4F4C0C00
        public void set_ListingType(){} // RVA: 0x7FFD4F4B1D60
        public void get_Products(){} // RVA: 0x7FFD4E3AC660
        public void set_Products(){} // RVA: 0x7FFD4E3AC670
        public void get_ProductIDs(){} // RVA: 0x7FFD4E96DFA0
        public void set_ProductIDs(){} // RVA: 0x7FFD4EDD99C0
        public void get_HydratedProducts(){} // RVA: 0x7FFD4E962410
        public void set_HydratedProducts(){} // RVA: 0x7FFD4EDC74B0
        public void get_Active(){} // RVA: 0x7FFD53E319B0
        public void set_Active(){} // RVA: 0x7FFD53E319C0
        public void get_SubscriberExclusive(){} // RVA: 0x7FFD53E319D0
        public void set_SubscriberExclusive(){} // RVA: 0x7FFD53E319E0
        public void get_Price(){} // RVA: 0x7FFD572E2370
        public void set_Price(){} // RVA: 0x7FFD572E2380
        public void get_VrcPlusDiscountPrice(){} // RVA: 0x7FFD5509AB00
        public void set_VrcPlusDiscountPrice(){} // RVA: 0x7FFD5509AB10
        public void get_AvailableToPurchaseUntilDate(){} // RVA: 0x7FFD4E78D850
        public void set_AvailableToPurchaseUntilDate(){} // RVA: 0x7FFD572E2390
        public void get_CollaboratorUserId(){} // RVA: 0x7FFD4E78D860
        public void set_CollaboratorUserId(){} // RVA: 0x7FFD4EDEA130
        public void get_CollaboratorUserDisplayName(){} // RVA: 0x7FFD4E96B1B0
        public void set_CollaboratorUserDisplayName(){} // RVA: 0x7FFD4E923070
        public void get_Stock(){} // RVA: 0x7FFD4E9610C0
        public void set_Stock(){} // RVA: 0x7FFD540894D0
        public void get_StoreIDs(){} // RVA: 0x7FFD4E960F60
        public void set_StoreIDs(){} // RVA: 0x7FFD4EDCB1D0
        public void get_Duration(){} // RVA: 0x7FFD54A65C90
        public void set_Duration(){} // RVA: 0x7FFD54A65CA0
        public void get_DurationType(){} // RVA: 0x7FFD4E50F4E0
        public void set_DurationType(){} // RVA: 0x7FFD4E7D1990
        public void get_Archived(){} // RVA: 0x7FFD572E23A0
        public void set_Archived(){} // RVA: 0x7FFD572E23B0
        public void get_Permanent(){} // RVA: 0x7FFD572E23C0
        public void set_Permanent(){} // RVA: 0x7FFD572E23D0
        public void get_Instant(){} // RVA: 0x7FFD572E23E0
        public void set_Instant(){} // RVA: 0x7FFD572E23F0
        public void get_Stackable(){} // RVA: 0x7FFD572E2400
        public void set_Stackable(){} // RVA: 0x7FFD572E2410
        public void get_Recurrable(){} // RVA: 0x7FFD572E2420
        public void set_Recurrable(){} // RVA: 0x7FFD572E2430
        public void get_Refundable(){} // RVA: 0x7FFD572E2440
        public void set_Refundable(){} // RVA: 0x7FFD572E2450
        public void get_BuyerRefundable(){} // RVA: 0x7FFD572E2460
        public void set_BuyerRefundable(){} // RVA: 0x7FFD572E2470
        public void get_ContextPreventsPurchase(){} // RVA: 0x7FFD572E2480
        public void set_ContextPreventsPurchase(){} // RVA: 0x7FFD572E2490
        public void get_ListingVariants(){} // RVA: 0x7FFD4E968F80
        public void set_ListingVariants(){} // RVA: 0x7FFD4EDD4D10
        public void Purchase(){} // RVA: 0x7FFD572E24A0
        public void ReadField(){} // RVA: 0x7FFD572E36A0
        public void WriteField(){} // RVA: 0x7FFD572E3AC0
        public void FetchListing(){} // RVA: 0x7FFD572E3F60
        public void FetchFullListing(){} // RVA: 0x7FFD572E4470
        public void FetchOwnListings(){} // RVA: 0x7FFD572E4980
        public void FetchOwnProducts(){} // RVA: 0x7FFD572E4E50
    }

    public class ApiProductPurchaseStatus : ApiModel
    {
        public string ProductId; // 0x68
        public string LicenseId; // 0x70
        public DependencyInjector Expiry; // 0x78

        // ── Methods ──
        public void get_ProductId(){} // RVA: 0x7FFD4E3BCD50
        public void set_ProductId(){} // RVA: 0x7FFD4E3BCD60
        public void get_LicenseId(){} // RVA: 0x7FFD4E409590
        public void set_LicenseId(){} // RVA: 0x7FFD4E4095A0
        public void get_Expiry(){} // RVA: 0x7FFD4E505600
        public void set_Expiry(){} // RVA: 0x7FFD53666500
        public void GetProductsPurchaseStatus(){} // RVA: 0x7FFD572E6150
        public void .ctor(){} // RVA: 0x7FFD572E6720
    }

    public class ApiProductVariant : ApiModel
    {
        public string ListingVariantID; // 0x68
        public int Quantity; // 0x70
        public int UnitPriceTokens; // 0x74
        public bool NonRefundable; // 0x78
        public DependencyInjector EffectiveFrom; // 0x80

        // ── Methods ──
        public void get_ListingVariantID(){} // RVA: 0x7FFD4E3BCD50
        public void set_ListingVariantID(){} // RVA: 0x7FFD4E3BCD60
        public void get_Quantity(){} // RVA: 0x7FFD4EFB9E80
        public void set_Quantity(){} // RVA: 0x7FFD4E4D6520
        public void get_UnitPriceTokens(){} // RVA: 0x7FFD4F7F9E20
        public void set_UnitPriceTokens(){} // RVA: 0x7FFD4FCD4C80
        public void get_NonRefundable(){} // RVA: 0x7FFD4E7EE5C0
        public void set_NonRefundable(){} // RVA: 0x7FFD4F140B50
        public void get_EffectiveFrom(){} // RVA: 0x7FFD4E70F410
        public void set_EffectiveFrom(){} // RVA: 0x7FFD4FE4BA90
        public void .ctor(){} // RVA: 0x7FFD572E6830
    }

    public class ApiProp : ApiContentModel`1
    {
        public DependencyInjector _created_at; // 0xD8
        public DependencyInjector _updated_at; // 0xE0
        public URA.woDigitYearMax<sedTCPStream> unityPackages; // 0xE8
        public int spawnType; // 0xF0
        public int worldPlacementMask; // 0xF4
        public bool scaleWithAvatar; // 0xF8
        public string BundleSignature;
        public string <BundleSignature>k__BackingField; // 0x100

        // ── Methods ──
        public void get__created_at(){} // RVA: 0x7FFD4E960F70
        public void set__created_at(){} // RVA: 0x7FFD5729A200
        public void get__updated_at(){} // RVA: 0x7FFD4E3C2900
        public void set__updated_at(){} // RVA: 0x7FFD5729A210
        public void get_unityPackages(){} // RVA: 0x7FFD4E3C2970
        public void set_unityPackages(){} // RVA: 0x7FFD4E3C2980
        public void get_spawnType(){} // RVA: 0x7FFD514A55D0
        public void set_spawnType(){} // RVA: 0x7FFD53E31630
        public void get_worldPlacementMask(){} // RVA: 0x7FFD51B35830
        public void set_worldPlacementMask(){} // RVA: 0x7FFD51B35840
        public void get_scaleWithAvatar(){} // RVA: 0x7FFD4F0AE090
        public void set_scaleWithAvatar(){} // RVA: 0x7FFD54BCF8F0
        public void get_BundleSignature(){} // RVA: 0x7FFD4E916C80
        public void set_BundleSignature(){} // RVA: 0x7FFD4E916750
        public void .ctor(){} // RVA: 0x7FFD572E6880
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFD572E69E0 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x7FFD572E6AC0
        public void WriteField(){} // RVA: 0x7FFD572E7180
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFD572E7240
        public void GetProp(){} // RVA: 0x7FFD572E7440
    }

    public class ApiPropItemMetadata : ApiModel
    {
        public string propId; // 0x68
        public int worldPlacementMask; // 0x70

        // ── Methods ──
        public void get_propId(){} // RVA: 0x7FFD4E3BCD50
        public void set_propId(){} // RVA: 0x7FFD4E3BCD60
        public void get_worldPlacementMask(){} // RVA: 0x7FFD4EFB9E80
        public void set_worldPlacementMask(){} // RVA: 0x7FFD4E4D6520
        public void .ctor(){} // RVA: 0x7FFD572E78E0
    }

    public class ApiPurchase : ApiModel
    {
        public string ListingId; // 0x68
        public string ListingDisplayName; // 0x70
        public string ListingImageId; // 0x78
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.eyString ListingImageUrl; // 0x80
        public string ListingType; // 0x88
        public string ListingVariantId; // 0x90
        public string SellerId; // 0x98
        public string SellerDisplayName; // 0xA0
        public string BuyerId; // 0xA8
        public string BuyerDisplayName; // 0xB0
        public string ReceiverId; // 0xB8
        public int ReceiverDisplayName; // 0xC0
        public int id; // 0xC4
        public int Price; // 0xC8
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ._BackingField Quantity; // 0xCC
        public DependencyInjector Duration; // 0xD0
        public DependencyInjector DurationType; // 0xD8
        public DependencyInjector PurchaseDate; // 0xE0
        public bool PurchaseStartDate; // 0xE8
        public bool PurchaseEndDate; // 0xE9
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ift> PurchaseActive; // 0xF0
        public bool PurchaseLatest; // 0xF8
        public bool Products; // 0xF9
        public URA.DateTime<string,object> IsStackable; // 0x100
        public bool IsRecurrable; // 0x108
        public bool PurchaseToken; // 0x109
        public int IsVoided; // 0x10C
        public bool IsGift; // 0x110
        public string PurchaseUnitPrice; // 0x118
        public int IsRefundable; // 0x120
        public int StackDurationType; // 0x124
        public int StackDuration; // 0x128
        public int StackPrice; // 0x12C
        public int StackQuantity; // 0x130
        public int StackQuantityConsumed; // 0x134
        public int StackQuantityConsumedAtPurchase; // 0x138
        public string StackQuantityUnconsumed; // 0x140
        public bool StackQuantityUnconsumedAtPurchase; // 0x148
        public bool TiliaTransactionId; // 0x149
        public DependencyInjector WillRecur; // 0x150
        public string ListingCurrentlyAvailable; // 0x158
        public DependencyInjector CreatedAtDate; // 0x160
        public DependencyInjector PurchaseID; // 0x168
        public string UpdatedAtDate; // 0x170
        public bool PurchaseOriginalEndDate; // 0x178
        public bool BuyerIP; // 0x179
        public string IsRecur; // 0x180
        public URA.woDigitYearMax<string> IsUnityLocalTest; // 0x188
        public int LicenseID; // 0x190
        public string PurchaseStacks; // 0x198
        public int PurchaseTiliaFee; // 0x1A0
        public int PurchaseType; // 0x1A4
        public string PurchaseValue; // 0x1A8
        public string PurchaseVrcFee; // 0x1B0
        public int RefundStatus; // 0x1B8
        public int SellerIP; // 0x1BC
        public int StackTiliaFee; // 0x1C0
        public bool StackValue; // 0x1C4
        public string StackVrcFee; // 0x1C8
        public bool StackQuantityVoided; // 0x1D0
        public DependencyInjector VoidedBy; // 0x1D8
        public int VoidedByAdmin; // 0x1E0
        public int VoidedOnDate; // 0x1E4
        public int PurchaseTiliaFeeBasedOnStack; // 0x1E8
        public bool PurchaseTiliaFeeDrift; // 0x1EC
        public string PurchaseVrcFeeBasedOnStack; // 0x1F0
        public bool Refunded; // 0x1F8
        public DependencyInjector RefundedBy; // 0x200
        public URA.woDigitYearMax<string> RefundedByAdmin; // 0x208
        public string RefundedOnDate; // 0x210
        public string RefundedStacks; // 0x218
        public string RefundReason; // 0x220
        public object RefundReasonType; // 0x228
        public int RefundTiliaTransactionId; // 0x230
        public object RefundTokenComponents; // 0x238
        public string RefundTokens; // 0x240
        public URA.woDigitYearMax<string> RefundTokenSources; // 0x248
        public bool RefundType; // 0x250

        // ── Methods ──
        public void get_ListingId(){} // RVA: 0x7FFD4E3BCD50
        public void set_ListingId(){} // RVA: 0x7FFD4E3BCD60
        public void get_ListingDisplayName(){} // RVA: 0x7FFD4E409590
        public void set_ListingDisplayName(){} // RVA: 0x7FFD4E4095A0
        public void get_ListingImageId(){} // RVA: 0x7FFD4E505600
        public void set_ListingImageId(){} // RVA: 0x7FFD4E5006F0
        public void get_ListingImageUrl(){} // RVA: 0x7FFD572E79D0
        public void get_ListingType(){} // RVA: 0x7FFD4E9929C0
        public void set_ListingType(){} // RVA: 0x7FFD4E992BF0
        public void get_ListingVariantId(){} // RVA: 0x7FFD4E380010
        public void set_ListingVariantId(){} // RVA: 0x7FFD4E96E300
        public void get_SellerId(){} // RVA: 0x7FFD4E70F640
        public void set_SellerId(){} // RVA: 0x7FFD4E96E360
        public void get_SellerDisplayName(){} // RVA: 0x7FFD4E96DFB0
        public void set_SellerDisplayName(){} // RVA: 0x7FFD4E96E3C0
        public void get_BuyerId(){} // RVA: 0x7FFD4E963900
        public void set_BuyerId(){} // RVA: 0x7FFD4E96E420
        public void get_BuyerDisplayName(){} // RVA: 0x7FFD4E96B1A0
        public void set_BuyerDisplayName(){} // RVA: 0x7FFD4E76B370
        public void get_ReceiverId(){} // RVA: 0x7FFD4E3AC040
        public void set_ReceiverId(){} // RVA: 0x7FFD4E3AC050
        public void get_ReceiverDisplayName(){} // RVA: 0x7FFD4E3AC0B0
        public void set_ReceiverDisplayName(){} // RVA: 0x7FFD4E3AC0C0
        public void get_id(){} // RVA: 0x7FFD4E35C380
        public void set_id(){} // RVA: 0x7FFD4E342E30
        public void get_Price(){} // RVA: 0x7FFD4E55B720
        public void set_Price(){} // RVA: 0x7FFD4E5634F0
        public void get_Quantity(){} // RVA: 0x7FFD4FBF3250
        public void set_Quantity(){} // RVA: 0x7FFD53D5FDA0
        public void get_Duration(){} // RVA: 0x7FFD4EA61480
        public void set_Duration(){} // RVA: 0x7FFD5165E970
        public void get_DurationType(){} // RVA: 0x7FFD4F7265A0
        public void set_DurationType(){} // RVA: 0x7FFD53CE71C0
        public void get_PurchaseDate(){} // RVA: 0x7FFD4E45E100
        public void set_PurchaseDate(){} // RVA: 0x7FFD5448B850
        public void get_PurchaseStartDate(){} // RVA: 0x7FFD4E960F70
        public void set_PurchaseStartDate(){} // RVA: 0x7FFD5729A200
        public void get_PurchaseEndDate(){} // RVA: 0x7FFD4E3C2900
        public void set_PurchaseEndDate(){} // RVA: 0x7FFD5729A210
        public void get_PurchaseActive(){} // RVA: 0x7FFD4F3F4640
        public void set_PurchaseActive(){} // RVA: 0x7FFD4FDBC5B0
        public void get_PurchaseLatest(){} // RVA: 0x7FFD54262E60
        public void set_PurchaseLatest(){} // RVA: 0x7FFD572E7A40
        public void get_Products(){} // RVA: 0x7FFD4E3AC2A0
        public void set_Products(){} // RVA: 0x7FFD4E3AC2B0
        public void get_IsStackable(){} // RVA: 0x7FFD4F0AE090
        public void set_IsStackable(){} // RVA: 0x7FFD54BCF8F0
        public void get_IsRecurrable(){} // RVA: 0x7FFD4E39DF90
        public void set_IsRecurrable(){} // RVA: 0x7FFD4E39DFA0
        public void get_PurchaseToken(){} // RVA: 0x7FFD4E916C80
        public void set_PurchaseToken(){} // RVA: 0x7FFD4E916750
        public void get_IsVoided(){} // RVA: 0x7FFD4F5B6030
        public void set_IsVoided(){} // RVA: 0x7FFD4F5B6040
        public void get_IsGift(){} // RVA: 0x7FFD4F9EA6A0
        public void set_IsGift(){} // RVA: 0x7FFD4F9E9FB0
        public void get_PurchaseUnitPrice(){} // RVA: 0x7FFD4F9B7A10
        public void set_PurchaseUnitPrice(){} // RVA: 0x7FFD4F9BAD60
        public void get_IsRefundable(){} // RVA: 0x7FFD4E607D90
        public void set_IsRefundable(){} // RVA: 0x7FFD4E605C40
        public void get_StackDurationType(){} // RVA: 0x7FFD4E7DC6D0
        public void set_StackDurationType(){} // RVA: 0x7FFD4E7D8580
        public void get_StackDuration(){} // RVA: 0x7FFD53E31640
        public void set_StackDuration(){} // RVA: 0x7FFD53E31650
        public void get_StackPrice(){} // RVA: 0x7FFD53CF4E90
        public void set_StackPrice(){} // RVA: 0x7FFD53CF4EA0
        public void get_StackQuantity(){} // RVA: 0x7FFD53E319F0
        public void set_StackQuantity(){} // RVA: 0x7FFD53E31A00
        public void get_StackQuantityConsumed(){} // RVA: 0x7FFD572E7A50
        public void set_StackQuantityConsumed(){} // RVA: 0x7FFD572E7A60
        public void get_StackQuantityConsumedAtPurchase(){} // RVA: 0x7FFD4E7DC1B0
        public void set_StackQuantityConsumedAtPurchase(){} // RVA: 0x7FFD5497CD90
        public void get_StackQuantityUnconsumed(){} // RVA: 0x7FFD54714E20
        public void set_StackQuantityUnconsumed(){} // RVA: 0x7FFD572E7A70
        public void get_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x7FFD4F0AEC30
        public void set_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x7FFD53CE7220
        public void get_TiliaTransactionId(){} // RVA: 0x7FFD4E3AC5F0
        public void set_TiliaTransactionId(){} // RVA: 0x7FFD4E3AC600
        public void get_WillRecur(){} // RVA: 0x7FFD4F558670
        public void set_WillRecur(){} // RVA: 0x7FFD4F54E500
        public void get_ListingCurrentlyAvailable(){} // RVA: 0x7FFD56E61C70
        public void set_ListingCurrentlyAvailable(){} // RVA: 0x7FFD572E7A80
        public void get_CreatedAtDate(){} // RVA: 0x7FFD4E96DFA0
        public void set_CreatedAtDate(){} // RVA: 0x7FFD572E7A90
        public void get_PurchaseID(){} // RVA: 0x7FFD4E962410
        public void set_PurchaseID(){} // RVA: 0x7FFD4EDC74B0
        public void get_UpdatedAtDate(){} // RVA: 0x7FFD4E7C98A0
        public void set_UpdatedAtDate(){} // RVA: 0x7FFD5509AAF0
        public void get_PurchaseOriginalEndDate(){} // RVA: 0x7FFD4E96E2F0
        public void set_PurchaseOriginalEndDate(){} // RVA: 0x7FFD572E7AA0
        public void get_BuyerIP(){} // RVA: 0x7FFD4E78D850
        public void set_BuyerIP(){} // RVA: 0x7FFD4EDD5DB0
        public void get_IsRecur(){} // RVA: 0x7FFD572E7AB0
        public void set_IsRecur(){} // RVA: 0x7FFD4E4156A0
        public void get_IsUnityLocalTest(){} // RVA: 0x7FFD572E7AC0
        public void set_IsUnityLocalTest(){} // RVA: 0x7FFD572E7AD0
        public void get_LicenseID(){} // RVA: 0x7FFD4E96B1B0
        public void set_LicenseID(){} // RVA: 0x7FFD4E923070
        public void get_PurchaseStacks(){} // RVA: 0x7FFD4E9610C0
        public void set_PurchaseStacks(){} // RVA: 0x7FFD4E923010
        public void get_PurchaseTiliaFee(){} // RVA: 0x7FFD53E344E0
        public void set_PurchaseTiliaFee(){} // RVA: 0x7FFD54A65C60
        public void get_PurchaseType(){} // RVA: 0x7FFD4E961C80
        public void set_PurchaseType(){} // RVA: 0x7FFD4EDE8ED0
        public void get_PurchaseValue(){} // RVA: 0x7FFD572E7AE0
        public void set_PurchaseValue(){} // RVA: 0x7FFD572E7AF0
        public void get_PurchaseVrcFee(){} // RVA: 0x7FFD572E7B00
        public void set_PurchaseVrcFee(){} // RVA: 0x7FFD572E7B10
        public void get_RefundStatus(){} // RVA: 0x7FFD4E968F80
        public void set_RefundStatus(){} // RVA: 0x7FFD4EDD4D10
        public void get_SellerIP(){} // RVA: 0x7FFD4E969F30
        public void set_SellerIP(){} // RVA: 0x7FFD4EDC7790
        public void get_StackTiliaFee(){} // RVA: 0x7FFD56E2F460
        public void set_StackTiliaFee(){} // RVA: 0x7FFD572E7B20
        public void get_StackValue(){} // RVA: 0x7FFD4F43F070
        public void set_StackValue(){} // RVA: 0x7FFD572E7B30
        public void get_StackVrcFee(){} // RVA: 0x7FFD4F439FC0
        public void set_StackVrcFee(){} // RVA: 0x7FFD572E7B40
        public void get_StackQuantityVoided(){} // RVA: 0x7FFD572E7B50
        public void set_StackQuantityVoided(){} // RVA: 0x7FFD572E7B60
        public void get_VoidedBy(){} // RVA: 0x7FFD4EDECB10
        public void set_VoidedBy(){} // RVA: 0x7FFD4EDEF3F0
        public void get_VoidedByAdmin(){} // RVA: 0x7FFD567C45C0
        public void set_VoidedByAdmin(){} // RVA: 0x7FFD572E7B70
        public void get_VoidedOnDate(){} // RVA: 0x7FFD4EDE0A30
        public void set_VoidedOnDate(){} // RVA: 0x7FFD572E7B80
        public void get_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0x7FFD572E7B90
        public void set_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0x7FFD572E7BA0
        public void get_PurchaseTiliaFeeDrift(){} // RVA: 0x7FFD544CB690
        public void set_PurchaseTiliaFeeDrift(){} // RVA: 0x7FFD572E7BB0
        public void get_PurchaseVrcFeeBasedOnStack(){} // RVA: 0x7FFD572E7BC0
        public void set_PurchaseVrcFeeBasedOnStack(){} // RVA: 0x7FFD572E7BD0
        public void get_Refunded(){} // RVA: 0x7FFD572E7BE0
        public void set_Refunded(){} // RVA: 0x7FFD572E7BF0
        public void get_RefundedBy(){} // RVA: 0x7FFD4E964EF0
        public void set_RefundedBy(){} // RVA: 0x7FFD4E961400
        public void get_RefundedByAdmin(){} // RVA: 0x7FFD4FBE4AF0
        public void set_RefundedByAdmin(){} // RVA: 0x7FFD572E7C00
        public void get_RefundedOnDate(){} // RVA: 0x7FFD4E964790
        public void set_RefundedOnDate(){} // RVA: 0x7FFD572E7C10
        public void get_RefundedStacks(){} // RVA: 0x7FFD4E964780
        public void set_RefundedStacks(){} // RVA: 0x7FFD4E96D290
        public void get_RefundReason(){} // RVA: 0x7FFD4E96BCB0
        public void set_RefundReason(){} // RVA: 0x7FFD4E963140
        public void get_RefundReasonType(){} // RVA: 0x7FFD4E961470
        public void set_RefundReasonType(){} // RVA: 0x7FFD4E962420
        public void get_RefundTiliaTransactionId(){} // RVA: 0x7FFD4E9693F0
        public void set_RefundTiliaTransactionId(){} // RVA: 0x7FFD4E96AC80
        public void get_RefundTokenComponents(){} // RVA: 0x7FFD4E960FB0
        public void set_RefundTokenComponents(){} // RVA: 0x7FFD4EDCE720
        public void get_RefundTokens(){} // RVA: 0x7FFD4F918B10
        public void set_RefundTokens(){} // RVA: 0x7FFD4F919B00
        public void get_RefundTokenSources(){} // RVA: 0x7FFD4E9613D0
        public void set_RefundTokenSources(){} // RVA: 0x7FFD4EDCA7F0
        public void get_RefundType(){} // RVA: 0x7FFD4EDE9150
        public void set_RefundType(){} // RVA: 0x7FFD4EDD5A80
        public void get_VoidedStacks(){} // RVA: 0x7FFD4EDC6830
        public void set_VoidedStacks(){} // RVA: 0x7FFD4EDC8760
        public void get_VoidedCompletely(){} // RVA: 0x7FFD572E7C20
        public void set_VoidedCompletely(){} // RVA: 0x7FFD572E7C30
        public void ReadField(){} // RVA: 0x7FFD572E7C40
        public void WriteField(){} // RVA: 0x7FFD572E7E80
        public void GetCancelInformation(){} // RVA: 0x7FFD572E8000
        public void Cancel(){} // RVA: 0x7FFD572E88E0
        public void FetchList(){} // RVA: 0x7FFD572E9250
        public void FetchMostRecentActivePurchase(){} // RVA: 0x7FFD572EA200
        public void .ctor(){} // RVA: 0x7FFD572EAB60
    }

    public class ApiReport : ApiModel
    {
        public string type; // 0x68
        public string category; // 0x70
        public string reason; // 0x78
        public string contentId; // 0x80
        public string description; // 0x88
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.rType>k__BackingField details; // 0x90
        public string contentName; // 0x98
        public string contentThumbnailImageUrl; // 0xA0

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFD4E3BCD50
        public void set_type(){} // RVA: 0x7FFD4E3BCD60
        public void get_category(){} // RVA: 0x7FFD4E409590
        public void set_category(){} // RVA: 0x7FFD4E4095A0
        public void get_reason(){} // RVA: 0x7FFD4E505600
        public void set_reason(){} // RVA: 0x7FFD4E5006F0
        public void get_contentId(){} // RVA: 0x7FFD4E70F410
        public void set_contentId(){} // RVA: 0x7FFD4E8F4AA0
        public void get_description(){} // RVA: 0x7FFD4E380010
        public void set_description(){} // RVA: 0x7FFD4E96E300
        public void get_details(){} // RVA: 0x7FFD4E70F640
        public void set_details(){} // RVA: 0x7FFD4E96E360
        public void get_contentName(){} // RVA: 0x7FFD4E96DFB0
        public void set_contentName(){} // RVA: 0x7FFD4E96E3C0
        public void get_contentThumbnailImageUrl(){} // RVA: 0x7FFD4E963900
        public void set_contentThumbnailImageUrl(){} // RVA: 0x7FFD4E96E420
        public void AddReport(){} // RVA: 0x7FFD572EB930
        public void FetchReports(){} // RVA: 0x7FFD572EBC50
        public void DeleteReport(){} // RVA: 0x7FFD572EC2F0
        public void .ctor(){} // RVA: 0x7FFD572EC600
    }

    public class ApiSharedConnectionCounts : ApiModel
    {
        public float CacheLifetime;
        public int friends; // 0x68
        public int groups; // 0x6C

        // ── Methods ──
        public void get_CacheLifetime(){} // RVA: 0x7FFD57346AF0
        public void get_friends(){} // RVA: 0x7FFD4FBDAB50
        public void set_friends(){} // RVA: 0x7FFD4FBDAB60
        public void get_groups(){} // RVA: 0x7FFD4FBDAB70
        public void set_groups(){} // RVA: 0x7FFD4FBDAB80
        public void FetchSharedConnectionCountsAsync(){} // RVA: 0x7FFD57346C80
        public void GetLifeSpan(){} // RVA: 0x7FFD57346AF0
        public void .ctor(){} // RVA: 0x7FFD57346E30
    }

    public class ApiStoreShelf : ApiModel
    {
        public string ShelfTitle; // 0x68
        public string ShelfDescription; // 0x70
        public string ShelfLayout; // 0x78
        public DependencyInjector UpdatedAt; // 0x80
        public DependencyInjector CreatedAt; // 0x88
        public URA.woDigitYearMax<string> ListingIds; // 0x90
        public string ShelfVisibility; // 0x98
        public string StoreId; // 0xA0
        public string SellerId; // 0xA8
        public string HighlightListingId; // 0xB0
        public string ShelfTabBackgroundImageId; // 0xB8
        public string ShelfTabBackgroundImageUrl; // 0xC0
        public string ShelfBackgroundImageId; // 0xC8
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ift> ShelfBackgroundImageUrl; // 0xD0
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ift ShelfIconImageId; // 0xD8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57341300
        public void get_ShelfTitle(){} // RVA: 0x7FFD4E3BCD50
        public void set_ShelfTitle(){} // RVA: 0x7FFD4E3BCD60
        public void get_ShelfDescription(){} // RVA: 0x7FFD4E409590
        public void set_ShelfDescription(){} // RVA: 0x7FFD4E4095A0
        public void get_ShelfLayout(){} // RVA: 0x7FFD4E505600
        public void set_ShelfLayout(){} // RVA: 0x7FFD4E5006F0
        public void get_UpdatedAt(){} // RVA: 0x7FFD4E70F410
        public void set_UpdatedAt(){} // RVA: 0x7FFD4FE4BA90
        public void get_CreatedAt(){} // RVA: 0x7FFD4E380010
        public void set_CreatedAt(){} // RVA: 0x7FFD4FE4BA70
        public void get_ListingIds(){} // RVA: 0x7FFD4E70F640
        public void set_ListingIds(){} // RVA: 0x7FFD4E96E360
        public void get_ShelfVisibility(){} // RVA: 0x7FFD4E96DFB0
        public void set_ShelfVisibility(){} // RVA: 0x7FFD4E96E3C0
        public void get_StoreId(){} // RVA: 0x7FFD4E963900
        public void set_StoreId(){} // RVA: 0x7FFD4E96E420
        public void get_SellerId(){} // RVA: 0x7FFD4E96B1A0
        public void set_SellerId(){} // RVA: 0x7FFD4E76B370
        public void get_HighlightListingId(){} // RVA: 0x7FFD4E3AC040
        public void set_HighlightListingId(){} // RVA: 0x7FFD4E3AC050
        public void get_ShelfTabBackgroundImageId(){} // RVA: 0x7FFD4E3AC0B0
        public void set_ShelfTabBackgroundImageId(){} // RVA: 0x7FFD4E3AC0C0
        public void get_ShelfTabBackgroundImageUrl(){} // RVA: 0x7FFD57341350
        public void get_ShelfBackgroundImageId(){} // RVA: 0x7FFD4E3AC120
        public void set_ShelfBackgroundImageId(){} // RVA: 0x7FFD4E3AC130
        public void get_ShelfBackgroundImageUrl(){} // RVA: 0x7FFD573413C0
        public void get_ShelfIconImageId(){} // RVA: 0x7FFD4E499460
        public void set_ShelfIconImageId(){} // RVA: 0x7FFD4E499470
        public void get_ShelfIconImageUrl(){} // RVA: 0x7FFD57341430
        public void get_Listings(){} // RVA: 0x7FFD4E45E100
        public void set_Listings(){} // RVA: 0x7FFD4E45E110
        public void get_HighlightListing(){} // RVA: 0x7FFD4E960F70
        public void set_HighlightListing(){} // RVA: 0x7FFD4E3C28A0
    }

    public class ApiTransaction : ApiModel
    {
        public string ListingID; // 0x68
        public string Name; // 0x70
        public string SellerId; // 0x78
        public string FromUserDisplayName; // 0x80
        public string SellerDisplayName; // 0x88
        public string BuyerId; // 0x90
        public string BuyerDisplayName; // 0x98
        public string Type; // 0xA0
        public DependencyInjector Date; // 0xA8
        public int Amount; // 0xB0
        public int RunningBalance; // 0xB4
        public string ImageId; // 0xB8
        public string PurchaseId; // 0xC0
        public string TiliaRef; // 0xC8

        // ── Methods ──
        public void get_ListingID(){} // RVA: 0x7FFD4E3BCD50
        public void set_ListingID(){} // RVA: 0x7FFD4E3BCD60
        public void get_Name(){} // RVA: 0x7FFD4E409590
        public void set_Name(){} // RVA: 0x7FFD4E4095A0
        public void get_SellerId(){} // RVA: 0x7FFD4E505600
        public void set_SellerId(){} // RVA: 0x7FFD4E5006F0
        public void get_FromUserDisplayName(){} // RVA: 0x7FFD4E70F410
        public void set_FromUserDisplayName(){} // RVA: 0x7FFD4E8F4AA0
        public void get_SellerDisplayName(){} // RVA: 0x7FFD4E380010
        public void set_SellerDisplayName(){} // RVA: 0x7FFD4E96E300
        public void get_BuyerId(){} // RVA: 0x7FFD4E70F640
        public void set_BuyerId(){} // RVA: 0x7FFD4E96E360
        public void get_BuyerDisplayName(){} // RVA: 0x7FFD4E96DFB0
        public void set_BuyerDisplayName(){} // RVA: 0x7FFD4E96E3C0
        public void get_Type(){} // RVA: 0x7FFD4E963900
        public void set_Type(){} // RVA: 0x7FFD4E96E420
        public void get_Date(){} // RVA: 0x7FFD4E96B1A0
        public void set_Date(){} // RVA: 0x7FFD4F9E9F60
        public void get_Amount(){} // RVA: 0x7FFD500181F0
        public void set_Amount(){} // RVA: 0x7FFD53BD5A90
        public void get_RunningBalance(){} // RVA: 0x7FFD51B35300
        public void set_RunningBalance(){} // RVA: 0x7FFD51B35310
        public void get_ImageId(){} // RVA: 0x7FFD4E3AC0B0
        public void set_ImageId(){} // RVA: 0x7FFD4E3AC0C0
        public void get_PurchaseId(){} // RVA: 0x7FFD4E3AC120
        public void set_PurchaseId(){} // RVA: 0x7FFD4E3AC130
        public void get_TiliaRef(){} // RVA: 0x7FFD4E499460
        public void set_TiliaRef(){} // RVA: 0x7FFD4E499470
        public void get_TransactionImageUrl(){} // RVA: 0x7FFD572F4F00
        public void FetchList(){} // RVA: 0x7FFD572F4F70
        public void .ctor(){} // RVA: 0x7FFD572F5EA0
    }

    public class ApiUserPermission : ApiModel
    {
        public object ownerId;
        public object name;
        public object data;

        // ── Methods ──
        public void get_ownerId(){} // RVA: 0x7FFD4E3BCD50
        public void set_ownerId(){} // RVA: 0x7FFD4E3BCD60
        public void get_name(){} // RVA: 0x7FFD4E409590
        public void set_name(){} // RVA: 0x7FFD4E4095A0
        public void get_data(){} // RVA: 0x7FFD4E505600
        public void set_data(){} // RVA: 0x7FFD4E5006F0
        public void .ctor(){} // RVA: 0x7FFD57310400
    }

    public class ApiUserPermissions : Object
    {
        // ── Methods ──
        public void GetPermission_UserIcon(){} // RVA: 0x7FFD5730F720
        public void GetPermission_InvitePhotos(){} // RVA: 0x7FFD5730F7A0
        public void GetPermission_ExtraFavoriteAvatars(){} // RVA: 0x7FFD5730F820
        public void GetPermission_UserGallery(){} // RVA: 0x7FFD5730F8A0
        public void GetPermission_ProfilePictureOverride(){} // RVA: 0x7FFD5730F920
        public void GetPermission_MaximumUserIcons(){} // RVA: 0x7FFD4E828770
        public void GetPermission_MaximumUserImages(){} // RVA: 0x7FFD4E828770
        public void GetPermission_UseProps(){} // RVA: 0x7FFD5730F9A0
        public void GetPermission_UploadProps(){} // RVA: 0x7FFD5730FA20
        public void GetPermission_TestProps(){} // RVA: 0x7FFD5730FAA0
        public void Clear(){} // RVA: 0x7FFD5730FB20
        public void FetchPermissions(){} // RVA: 0x7FFD5730FB70
        public void .ctor(){} // RVA: 0x7FFD5730FE70
    }

    public class ApiVRChatProductDetails : ApiModel
    {
        public bool enabled; // 0x68
        public string productType; // 0x70
        public aphy<t_verification_uri> Product; // 0x78
        public string endpoint; // 0x80
        public URA.DateTime<string,nsumedAtPurchase> stores; // 0x88
        public object subscriptionInfo; // 0x90
        public kQuantityConsumed giftInfo; // 0x98
        public Consumed tokenInfo; // 0xA0
        public string description; // 0xA8

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFD4E409570
        public void set_enabled(){} // RVA: 0x7FFD4E409580
        public void get_productType(){} // RVA: 0x7FFD4E409590
        public void set_productType(){} // RVA: 0x7FFD4E4095A0
        public void get_Product(){} // RVA: 0x7FFD57310FF0
        public void get_endpoint(){} // RVA: 0x7FFD4E70F410
        public void set_endpoint(){} // RVA: 0x7FFD4E8F4AA0
        public void get_stores(){} // RVA: 0x7FFD4E380010
        public void set_stores(){} // RVA: 0x7FFD4E96E300
        public void get_subscriptionInfo(){} // RVA: 0x7FFD4E70F640
        public void set_subscriptionInfo(){} // RVA: 0x7FFD4E96E360
        public void get_giftInfo(){} // RVA: 0x7FFD4E96DFB0
        public void set_giftInfo(){} // RVA: 0x7FFD4E96E3C0
        public void get_tokenInfo(){} // RVA: 0x7FFD4E963900
        public void set_tokenInfo(){} // RVA: 0x7FFD4E96E420
        public void get_description(){} // RVA: 0x7FFD4E96B1A0
        public void set_description(){} // RVA: 0x7FFD4E76B370
        public void .ctor(){} // RVA: 0x7FFD573110E0
    }

    public class ApiViewfinderSkin : ApiModel
    {
        public string name; // 0x68
        public string assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_assetBundleId(){} // RVA: 0x7FFD4E409590
        public void set_assetBundleId(){} // RVA: 0x7FFD4E4095A0
        public void .ctor(){} // RVA: 0x7FFD57310EB0
    }

    public class ApiWarpEffectSkin : ApiModel
    {
        public string name; // 0x68
        public string assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_assetBundleId(){} // RVA: 0x7FFD4E409590
        public void set_assetBundleId(){} // RVA: 0x7FFD4E4095A0
        public void .ctor(){} // RVA: 0x7FFD573119A0
    }

    public class ApiWorld : ApiModel
    {
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.et_canPublishWorlds VERSION;
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.et_canPublishWorlds name; // 0x8
        public float imageUrl;
        public float thumbnailImageUrl;
        public string authorName;
        public URA.DateTime<string,ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ThumbnailImageUrl>k__BackingField> releaseStatus; // 0x10
        public string capacity; // 0x68
        public string recommendedCapacity; // 0x70
        public string occupants; // 0x78
        public string publicOccupants; // 0x80
        public string privateOccupants; // 0x88
        public int authorId; // 0x90
        public int createdAt; // 0x94
        public int assetUrl; // 0x98
        public int description; // 0x9C
        public int tags; // 0xA0
        public string urlList; // 0xA8
        public DependencyInjector unityPackageUrl; // 0xB0
        public string version; // 0xB8
        public string unityVersion; // 0xC0
        public URA.woDigitYearMax<string> apiVersion; // 0xC8
        public URA.woDigitYearMax<string> latestAssetVersion; // 0xD0
        public string created_at; // 0xD8
        public int updated_at; // 0xE0
        public string publicationDate; // 0xE8
        public int labsPublicationDate; // 0xF0
        public int udonProducts; // 0xF4
        public DependencyInjector storeId; // 0xF8
        public DependencyInjector platform; // 0x100
        public DependencyInjector worldInstances; // 0x108
        public DependencyInjector isAdminApproved; // 0x110
        public URA.woDigitYearMax<string> IsCommunityLabsWorld; // 0x118
        public string IsPublicPublishedWorld; // 0x120
        public string IsInternalWorld; // 0x128
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.?> unityPackageUpdated; // 0x130
        public bool organization; // 0x138
        public string shouldAddToAuthor; // 0x140
        public bool favoriteId; // 0x148
        public string favorites; // 0x150
        public int visits; // 0x158
        public int popularity; // 0x15C
        public int heat; // 0x160
        public int detailed; // 0x164
        public bool defaultContentSettings; // 0x168
        public URA.DateTime<string,bool> assetVersion; // 0x170
        public string BundleSignature; // 0x178
        public bool isCurated; // 0x180
        public tor.neStore publicTags; // 0x18

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7FFD573119F0
        public void ShouldCache(){} // RVA: 0x7FFD57311BF0
        public void GetLifeSpan(){} // RVA: 0x7FFD57311C40
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_imageUrl(){} // RVA: 0x7FFD4E409590
        public void set_imageUrl(){} // RVA: 0x7FFD4E4095A0
        public void get_thumbnailImageUrl(){} // RVA: 0x7FFD4E505600
        public void set_thumbnailImageUrl(){} // RVA: 0x7FFD4E5006F0
        public void get_authorName(){} // RVA: 0x7FFD4E70F410
        public void set_authorName(){} // RVA: 0x7FFD4E8F4AA0
        public void get_releaseStatus(){} // RVA: 0x7FFD4E380010
        public void set_releaseStatus(){} // RVA: 0x7FFD4E96E300
        public void get_capacity(){} // RVA: 0x7FFD4E640660
        public void set_capacity(){} // RVA: 0x7FFD4E8F2750
        public void get_recommendedCapacity(){} // RVA: 0x7FFD4E640670
        public void set_recommendedCapacity(){} // RVA: 0x7FFD4E84B670
        public void get_occupants(){} // RVA: 0x7FFD4FCBE530
        public void set_occupants(){} // RVA: 0x7FFD4FCBE540
        public void get_publicOccupants(){} // RVA: 0x7FFD4FCBE520
        public void set_publicOccupants(){} // RVA: 0x7FFD4FCBEAA0
        public void get_privateOccupants(){} // RVA: 0x7FFD4FCBE510
        public void set_privateOccupants(){} // RVA: 0x7FFD4FCBE550
        public void get_authorId(){} // RVA: 0x7FFD4E96B1A0
        public void set_authorId(){} // RVA: 0x7FFD4E76B370
        public void get_createdAt(){} // RVA: 0x7FFD4E3AC040
        public void set_createdAt(){} // RVA: 0x7FFD4F9EA6B0
        public void get_assetUrl(){} // RVA: 0x7FFD4E3AC0B0
        public void set_assetUrl(){} // RVA: 0x7FFD4E3AC0C0
        public void get_description(){} // RVA: 0x7FFD4E3AC120
        public void set_description(){} // RVA: 0x7FFD4E3AC130
        public void get_tags(){} // RVA: 0x7FFD4E499460
        public void set_tags(){} // RVA: 0x7FFD4E499470
        public void get_urlList(){} // RVA: 0x7FFD4E45E100
        public void set_urlList(){} // RVA: 0x7FFD4E45E110
        public void get_unityPackageUrl(){} // RVA: 0x7FFD4E960F70
        public void set_unityPackageUrl(){} // RVA: 0x7FFD4E3C28A0
        public void get_version(){} // RVA: 0x7FFD4FC57F50
        public void set_version(){} // RVA: 0x7FFD4FC57F60
        public void get_unityVersion(){} // RVA: 0x7FFD4E3C2970
        public void set_unityVersion(){} // RVA: 0x7FFD4E3C2980
        public void get_apiVersion(){} // RVA: 0x7FFD514A55D0
        public void set_apiVersion(){} // RVA: 0x7FFD53E31630
        public void get_latestAssetVersion(){} // RVA: 0x7FFD51B35830
        public void set_latestAssetVersion(){} // RVA: 0x7FFD51B35840
        public void get_created_at(){} // RVA: 0x7FFD4E751F50
        public void set_created_at(){} // RVA: 0x7FFD51B35870
        public void get_updated_at(){} // RVA: 0x7FFD4E916C80
        public void set_updated_at(){} // RVA: 0x7FFD4F5B6020
        public void get_publicationDate(){} // RVA: 0x7FFD4EAF1F40
        public void set_publicationDate(){} // RVA: 0x7FFD57284CE0
        public void get_labsPublicationDate(){} // RVA: 0x7FFD4E96B170
        public void set_labsPublicationDate(){} // RVA: 0x7FFD53F86FB0
        public void get_udonProducts(){} // RVA: 0x7FFD4E7DC6D0
        public void set_udonProducts(){} // RVA: 0x7FFD4E7D8580
        public void get_storeId(){} // RVA: 0x7FFD4E55CBB0
        public void set_storeId(){} // RVA: 0x7FFD4E563400
        public void get_platform(){} // RVA: 0x7FFD4E9666F0
        public void set_platform(){} // RVA: 0x7FFD4EDE51C0
        public void get_worldInstances(){} // RVA: 0x7FFD4E964340
        public void get_isAdminApproved(){} // RVA: 0x7FFD57311C50
        public void get_IsCommunityLabsWorld(){} // RVA: 0x7FFD57311CD0
        public void get_IsPublicPublishedWorld(){} // RVA: 0x7FFD57311D40
        public void get_IsInternalWorld(){} // RVA: 0x7FFD57311DC0
        public void get_unityPackageUpdated(){} // RVA: 0x7FFD57311E20
        public void set_unityPackageUpdated(){} // RVA: 0x7FFD57311E30
        public void get_organization(){} // RVA: 0x7FFD4E3AC5F0
        public void set_organization(){} // RVA: 0x7FFD4E3AC600
        public void get_shouldAddToAuthor(){} // RVA: 0x7FFD4F558670
        public void set_shouldAddToAuthor(){} // RVA: 0x7FFD4F54E500
        public void get_favoriteId(){} // RVA: 0x7FFD4E96DFA0
        public void set_favoriteId(){} // RVA: 0x7FFD4EDD99C0
        public void get_favorites(){} // RVA: 0x7FFD57311E40
        public void set_favorites(){} // RVA: 0x7FFD54E1DCE0
        public void get_visits(){} // RVA: 0x7FFD57311E50
        public void set_visits(){} // RVA: 0x7FFD54E1DD00
        public void get_popularity(){} // RVA: 0x7FFD4EA62A70
        public void set_popularity(){} // RVA: 0x7FFD4EA62540
        public void get_heat(){} // RVA: 0x7FFD572E2370
        public void set_heat(){} // RVA: 0x7FFD572E2380
        public void get_detailed(){} // RVA: 0x7FFD4F42F720
        public void set_detailed(){} // RVA: 0x7FFD4F4BF1C0
        public void get_defaultContentSettings(){} // RVA: 0x7FFD4E78D850
        public void set_defaultContentSettings(){} // RVA: 0x7FFD4EDD5DB0
        public void get_assetVersion(){} // RVA: 0x7FFD57311E60
        public void set_assetVersion(){} // RVA: 0x7FFD57311F10
        public void get_BundleSignature(){} // RVA: 0x7FFD4E78D860
        public void set_BundleSignature(){} // RVA: 0x7FFD4EDEA130
        public void get_isCurated(){} // RVA: 0x7FFD57311FA0
        public void set_isCurated(){} // RVA: 0x7FFD57311FB0
        public void get_publicTags(){} // RVA: 0x7FFD57311FC0
        public void .ctor(){} // RVA: 0x7FFD573121C0
        public void ReadField(){} // RVA: 0x7FFD573123D0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFD573125B0 | overloaded x2
        public void ReadUnityPackages(){} // RVA: 0x7FFD57312690
        public void ReadUnityPackage(){} // RVA: 0x7FFD57312DE0
        public void WriteField(){} // RVA: 0x7FFD57313440
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFD57313ED0
        public void Save(){} // RVA: 0x7FFD57314330
        public void Fetch(){} // RVA: 0x7FFD573144E0
        public void FetchList(){} // RVA: 0x7FFD57315010
        public void FetchSearchResults(){} // RVA: 0x7FFD573154C0
        public void AddLocal(){} // RVA: 0x7FFD573159C0
        public void get_IsLocal(){} // RVA: 0x7FFD57315A90
        public void SetLocal(){} // RVA: 0x7FFD57315B70
        public void ShouldNotBeVisibleOptional(){} // RVA: 0x7FFD57315D40
        public void GetBestInstance(){} // RVA: 0x7FFD573160F0 | overloaded x2
        public void CreateNewInstanceAsync(){} // RVA: 0x7FFD57316350
        public void CreateNewInstance(){} // RVA: 0x7FFD573166C0
        public void FetchUploadedWorlds(){} // RVA: 0x7FFD57316B50
        public void PublishWorldToCommunityLabs(){} // RVA: 0x7FFD57317040
        public void UpdateVersionAndPlatform(){} // RVA: 0x7FFD57317380
        public void MakeRequestEndpoint(){} // RVA: 0x7FFD573174F0
        public void Merge(){} // RVA: 0x7FFD57317510
        public void .cctor(){} // RVA: 0x7FFD57317DE0
    }

    public class ApiWorldInstance : ApiModel
    {
        public float location;
        public int name;
        public string shortName; // 0x68
        public string secureName; // 0x70
        public string displayName; // 0x78
        public string worldId; // 0x80
        public string instanceId; // 0x88
        public string instanceCode; // 0x90
        public string world; // 0x98
        public string type; // 0xA0
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ThumbnailImageUrl>k__BackingField ownerId; // 0xA8
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ACHE_TIME tags; // 0xB0
        public string count; // 0xB8
        public URA.woDigitYearMax<string> capacity; // 0xC0
        public int recommendedCapacity; // 0xC8
        public int platforms; // 0xCC
        public int nonce; // 0xD0
        public URA.DateTime<string,int> clientVersion; // 0xD8
        public string gameServerVersion; // 0xE0
        public string region; // 0xE8
        public int active; // 0xF0
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ty>k__BackingField queueEnabled; // 0xF4
        public bool hasCapacityForYou; // 0xF8
        public bool queueSize; // 0xF9
        public bool closedAt; // 0xFA
        public int hardClose; // 0xFC
        public DependencyInjector ageGate; // 0x100
        public bool contentSettings; // 0x108
        public bool IsClosed; // 0x109
        public URA.DateTime<string,bool> IsAgeGated; // 0x110
        public bool playerPersistenceEnabled; // 0x118
        public string calendarEntryId; // 0x120
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.reated> users; // 0x128
        public URA.woDigitYearMax<string> ShouldSeeInstanceByType; // 0x130
        public bool roleIds; // 0x138
        public string roleRestricted; // 0x140
        public object groupAccessType;
        public bool id; // 0x8
        public aphy<long> ProbablyExistsOnAPI; // 0x10
        public long MinPostIntervalSeconds;
        public long MaxPostDelaySeconds;

        // ── Methods ──
        public void get_location(){} // RVA: 0x7FFD4E3BCD50
        public void set_location(){} // RVA: 0x7FFD4E3BCD60
        public void get_name(){} // RVA: 0x7FFD4E409590
        public void set_name(){} // RVA: 0x7FFD5731D240
        public void get_shortName(){} // RVA: 0x7FFD4E505600
        public void set_shortName(){} // RVA: 0x7FFD4E5006F0
        public void get_secureName(){} // RVA: 0x7FFD4E70F410
        public void set_secureName(){} // RVA: 0x7FFD4E8F4AA0
        public void get_displayName(){} // RVA: 0x7FFD4E380010
        public void set_displayName(){} // RVA: 0x7FFD4E96E300
        public void get_worldId(){} // RVA: 0x7FFD4E70F640
        public void set_worldId(){} // RVA: 0x7FFD4E96E360
        public void get_instanceId(){} // RVA: 0x7FFD4E96DFB0
        public void set_instanceId(){} // RVA: 0x7FFD4E96E3C0
        public void get_instanceCode(){} // RVA: 0x7FFD4E963900
        public void set_instanceCode(){} // RVA: 0x7FFD4E96E420
        public void get_world(){} // RVA: 0x7FFD4E96B1A0
        public void set_world(){} // RVA: 0x7FFD4E76B370
        public void get_type(){} // RVA: 0x7FFD500181F0
        public void set_type(){} // RVA: 0x7FFD53BD5A90
        public void get_ownerId(){} // RVA: 0x7FFD4E3AC0B0
        public void set_ownerId(){} // RVA: 0x7FFD4E3AC0C0
        public void get_tags(){} // RVA: 0x7FFD4E3AC120
        public void set_tags(){} // RVA: 0x7FFD4E3AC130
        public void get_count(){} // RVA: 0x7FFD4EA61480
        public void set_count(){} // RVA: 0x7FFD5165E970
        public void get_capacity(){} // RVA: 0x7FFD4F7265A0
        public void set_capacity(){} // RVA: 0x7FFD53CE71C0
        public void get_recommendedCapacity(){} // RVA: 0x7FFD4EAB6B20
        public void set_recommendedCapacity(){} // RVA: 0x7FFD4F9B1C30
        public void get_platforms(){} // RVA: 0x7FFD4E960F70
        public void set_platforms(){} // RVA: 0x7FFD4E3C28A0
        public void get_nonce(){} // RVA: 0x7FFD4E3C2900
        public void set_nonce(){} // RVA: 0x7FFD4E3C2910
        public void get_clientVersion(){} // RVA: 0x7FFD4E3C2970
        public void set_clientVersion(){} // RVA: 0x7FFD4E3C2980
        public void get_gameServerVersion(){} // RVA: 0x7FFD514A55D0
        public void set_gameServerVersion(){} // RVA: 0x7FFD53E31630
        public void get_region(){} // RVA: 0x7FFD51B35830
        public void set_region(){} // RVA: 0x7FFD51B35840
        public void get_active(){} // RVA: 0x7FFD4F0AE090
        public void set_active(){} // RVA: 0x7FFD54BCF8F0
        public void get_queueEnabled(){} // RVA: 0x7FFD4E39DF90
        public void set_queueEnabled(){} // RVA: 0x7FFD4E39DFA0
        public void get_hasCapacityForYou(){} // RVA: 0x7FFD56D98DB0
        public void set_hasCapacityForYou(){} // RVA: 0x7FFD56D990C0
        public void get_queueSize(){} // RVA: 0x7FFD4F0ABB20
        public void set_queueSize(){} // RVA: 0x7FFD54BCF870
        public void get_closedAt(){} // RVA: 0x7FFD4E916C80
        public void set_closedAt(){} // RVA: 0x7FFD4F5B6020
        public void get_hardClose(){} // RVA: 0x7FFD4F5B6030
        public void set_hardClose(){} // RVA: 0x7FFD4F5B6040
        public void get_ageGate(){} // RVA: 0x7FFD4F9EA6A0
        public void set_ageGate(){} // RVA: 0x7FFD4F9E9FB0
        public void get_contentSettings(){} // RVA: 0x7FFD4E96B170
        public void set_contentSettings(){} // RVA: 0x7FFD4EDD3E10
        public void get_IsClosed(){} // RVA: 0x7FFD5731D330
        public void get_IsAgeGated(){} // RVA: 0x7FFD5731D450
        public void get_playerPersistenceEnabled(){} // RVA: 0x7FFD572E2310
        public void set_playerPersistenceEnabled(){} // RVA: 0x7FFD572E2320
        public void get_calendarEntryId(){} // RVA: 0x7FFD4E55CBB0
        public void set_calendarEntryId(){} // RVA: 0x7FFD4E563400
        public void get_users(){} // RVA: 0x7FFD4E9666F0
        public void set_users(){} // RVA: 0x7FFD4EDE51C0
        public void get_ShouldSeeInstanceByType(){} // RVA: 0x7FFD5731D5A0
        public void get_roleIds(){} // RVA: 0x7FFD4E964340
        public void set_roleIds(){} // RVA: 0x7FFD4EDC79B0
        public void get_roleRestricted(){} // RVA: 0x7FFD57311E20
        public void set_roleRestricted(){} // RVA: 0x7FFD57311E30
        public void get_groupAccessType(){} // RVA: 0x7FFD4E3AC5F0
        public void set_groupAccessType(){} // RVA: 0x7FFD4E3AC600
        public void get_id(){} // RVA: 0x7FFD4E3BCD50
        public void set_id(){} // RVA: 0x7FFD5731D6C0
        public void .ctor(){} // RVA: 0x7FFD5731DA50 | overloaded x3
        public void Init(){} // RVA: 0x7FFD5731DA90
        public void Get(){} // RVA: 0x7FFD5731E200
        public void MakeRequestEndpoint(){} // RVA: 0x7FFD5731E490
        public void SetInstanceAccessTypeFromId(){} // RVA: 0x7FFD5731E500
        public void ExtractInfoFromLocation(){} // RVA: 0x7FFD5731E740
        public void BuildRequest(){} // RVA: 0x7FFD5731EE30
        public void GetLifeSpan(){} // RVA: 0x7FFD5731F510
        public void ReadField(){} // RVA: 0x7FFD5731F520
        public void WriteField(){} // RVA: 0x7FFD5731F8B0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFD5731FA70 | overloaded x2
        public void ParseTags(){} // RVA: 0x7FFD5731FB10
        public void ToString(){} // RVA: 0x7FFD5731FDB0
        public void GetShortName(){} // RVA: 0x7FFD5731FE70
        public void get_ProbablyExistsOnAPI(){} // RVA: 0x7FFD57320210
        public void CreateOrFetch(){} // RVA: 0x7FFD57320410 | overloaded x2
        public void CreateOrFetchAsync(){} // RVA: 0x7FFD57320880 | overloaded x2
        public void CreateOrFetchAsyncInternal(){} // RVA: 0x7FFD57320A50
        public void .cctor(){} // RVA: 0x7FFD57320C70
        public void <get_ProbablyExistsOnAPI>b__165_0(){} // RVA: 0x7FFD57320D40
    }

    public class AreaBase : Object
    {
        public object Endpoint;

        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AssetVersion : Object
    {
        public object UnityVersion;
        public object UnityVersionObj;
        public object ApiVersion;

        // ── Methods ──
        public void get_UnityVersion(){} // RVA: 0x7FFD57331E10
        public void set_UnityVersion(){} // RVA: 0x7FFD4E342E30
        public void get_UnityVersionObj(){} // RVA: 0x7FFD57331F00
        public void get_ApiVersion(){} // RVA: 0x7FFD4F0A91D0
        public void set_ApiVersion(){} // RVA: 0x7FFD4F9D6490
        public void .ctor(){} // RVA: 0x7FFD57332110 | overloaded x3
        public void ToString(){} // RVA: 0x7FFD57332170
    }

    public class BaseConfig : Object
    {
        public URA.DateTime<string,object> config; // 0x10
        public URA.saAbbrevMonthNames<object> EmptyList;
        public URA.DayNames<string,object> EmptyDictionary; // 0x8

        // ── Methods ──
        public void GetValue(){} // RVA: 0x7FFD573479E0
        public void Init(){} // RVA: 0x7FFD57347A90
        public void HasKey(){} // RVA: 0x7FFD57347AF0
        public void GetObject(){} // RVA: 0x7FFD57347B40
        public void GetString(){} // RVA: 0x7FFD57347BB0
        public void GetInt(){} // RVA: 0x7FFD57347C40
        public void GetBool(){} // RVA: 0x7FFD57347DB0
        public void GetFloat(){} // RVA: 0x7FFD57347F10
        public void GetList(){} // RVA: 0x7FFD57347FE0
        public void GetDictionary(){} // RVA: 0x7FFD573480A0
        public void GetListOfDictionaries(){} // RVA: 0x7FFD57348150
        public void GetObjectAtPath(){} // RVA: 0x7FFD57348490
        public void IsInitializedInternal(){} // RVA: 0x7FFD57348A20
        public void IsInitialized(){} // RVA: 0x7FFD4E8F2B40
        public void FetchConfig(){} // RVA: 0x7FFD4E099B30
        public void TryGet(){} // RVA: 0x7FFD4E07D200
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD57348B00
    }

    public class ConfigManager : Object
    {
        public object LocalConfig;
        public object WorldConfig;
        public object RemoteConfig;

        // ── Methods ──
        public void get_LocalConfig(){} // RVA: 0x7FFD57348D40
        public void set_LocalConfig(){} // RVA: 0x7FFD57348D80
        public void get_WorldConfig(){} // RVA: 0x7FFD57348E20
        public void set_WorldConfig(){} // RVA: 0x7FFD57348E60
        public void get_RemoteConfig(){} // RVA: 0x7FFD57348F00
        public void set_RemoteConfig(){} // RVA: 0x7FFD57348F40
        public void Initialize(){} // RVA: 0x7FFD57348FE0
        public void WorldConfigIDChange(){} // RVA: 0x7FFD57349200
        public void AssignTestLocalConfig(){} // RVA: 0x7FFD57349330
        public void AssignTestRemoteConfig(){} // RVA: 0x7FFD573493C0
    }

    public class ExtensionMethods : Object
    {
        public URA.leEastFrench<int> _componentIndices; // 0xFFFFFFFF
        public em.MarkAborted.izeDefaultCase _cachedStringBuilder;

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD573527B0
        public void GetOrAddComponent(){} // RVA: 0x7FFD4E2ADC40
        public void GetHierarchyPath(){} // RVA: 0x7FFD57352940
        public void GetShortHierarchyPath(){} // RVA: 0x7FFD57352CB0
        public void GetFriendlyGenericTypeName(){} // RVA: 0x7FFD57353130
        public void GetComponentsPooled(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void GetComponentsInChildrenPooled(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetComponentsInParentPooled(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetComponentInClone(){} // RVA: 0x7FFD573533F0
        public void Merge(){} // RVA: 0x7FFD4E090C80
        public void CopyQueryParametersTo(){} // RVA: 0x7FFD57354130
        public void .cctor(){} // RVA: 0x7FFD57354840
    }

    public class FavoriteArea : AreaBase
    {
        public object Endpoint;
        public object Worlds;
        public object VRCPlusWorlds;
        public object Avatars;
        public object Friends;

        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFD573287B0
        public void get_Worlds(){} // RVA: 0x7FFD4E36F0C0
        public void get_VRCPlusWorlds(){} // RVA: 0x7FFD4E36F130
        public void get_Avatars(){} // RVA: 0x7FFD4E5F95E0
        public void get_Friends(){} // RVA: 0x7FFD4E5F0140
        public void .ctor(){} // RVA: 0x7FFD573287F0
        public void ReloadRemoteConfigSettings(){} // RVA: 0x7FFD5732A020
        public void GetCollection(){} // RVA: 0x7FFD5732A6E0
        public void GetDefaultList(){} // RVA: 0x7FFD5732A770
        public void GetDefaultNameByTypeAndIndex(){} // RVA: 0x7FFD5732AB20
        public void GetNameByTypeAndIndex(){} // RVA: 0x7FFD5732AD30
        public void GetDefaultDisplayNameByTypeAndIndex(){} // RVA: 0x7FFD5732AE20
        public void GetIndexOf(){} // RVA: 0x7FFD5732B030
        public void IsFavorite(){} // RVA: 0x7FFD5732B0D0
        public void IsFavoriteByFavoriteId(){} // RVA: 0x7FFD5732B2D0
        public void GetFavorite(){} // RVA: 0x7FFD5732B4D0
        public void GetTotalFavoritesOfType(){} // RVA: 0x7FFD5732B6C0
        public void GetTotalAccessibleFavoritesOfType(){} // RVA: 0x7FFD5732B940
        public void GetMaximumFavorites(){} // RVA: 0x7FFD5732BBA0
        public void FindListContainingContentId(){} // RVA: 0x7FFD5732C4D0 | overloaded x4
        public void FindListContainingFavoriteId(){} // RVA: 0x7FFD5732C7F0 | overloaded x4
        public void FetchListDetails(){} // RVA: 0x7FFD5732CAA0
        public void FetchListMembers(){} // RVA: 0x7FFD5732CE00
        public void FetchLists(){} // RVA: 0x7FFD5732D0F0
        public void .cctor(){} // RVA: 0x7FFD5732D880
        public void <FetchListDetails>g__FirstNull|42_2(){} // RVA: 0x7FFD5732DEF0
        public void <FetchListDetails>g__ModelFromDefaults|42_3(){} // RVA: 0x7FFD5732DF40
        public void <FetchLists>g__FirstNull|44_2(){} // RVA: 0x7FFD5732DEF0
        public void <FetchLists>g__ModelFromDefaults|44_3(){} // RVA: 0x7FFD5732E2A0
    }

    public class FavoriteListModel : ApiModel
    {
        public int Endpoint;
        public int ownerId;
        public string ownerDisplayName; // 0x68
        public string name; // 0x70
        public string displayName; // 0x78
        public string type; // 0x80
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.tenceDataForWorlds visibility; // 0x88
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.ersistenceDataExistsForWorld tags; // 0x8C
        public URA.woDigitYearMax<string> requiresSubscription; // 0x90
        public bool Favorites; // 0x98
        public URA.woDigitYearMax<ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.capacity> _favorites; // 0xA0
        public URA.DateTime<string,ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.capacity> _favoritesById; // 0xA8
        public URA.DateTime<string,ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.capacity> _favoritesByContentId; // 0xB0

        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFD573414A0
        public void get_ownerId(){} // RVA: 0x7FFD4E3BCD50
        public void set_ownerId(){} // RVA: 0x7FFD4E3BCD60
        public void get_ownerDisplayName(){} // RVA: 0x7FFD4E409590
        public void set_ownerDisplayName(){} // RVA: 0x7FFD4E4095A0
        public void get_name(){} // RVA: 0x7FFD4E505600
        public void set_name(){} // RVA: 0x7FFD4E5006F0
        public void get_displayName(){} // RVA: 0x7FFD4E70F410
        public void set_displayName(){} // RVA: 0x7FFD4E8F4AA0
        public void get_type(){} // RVA: 0x7FFD4EC0E8C0
        public void set_type(){} // RVA: 0x7FFD4EC19DE0
        public void get_visibility(){} // RVA: 0x7FFD51376E80
        public void set_visibility(){} // RVA: 0x7FFD519C0990
        public void get_tags(){} // RVA: 0x7FFD4E70F640
        public void set_tags(){} // RVA: 0x7FFD4E96E360
        public void get_requiresSubscription(){} // RVA: 0x7FFD4E7BA7F0
        public void set_requiresSubscription(){} // RVA: 0x7FFD4E7BFA20
        public void get_Favorites(){} // RVA: 0x7FFD4E963900
        public void MakeRequestEndpoint(){} // RVA: 0x7FFD573414E0
        public void ReadField(){} // RVA: 0x7FFD573415E0
        public void WriteField(){} // RVA: 0x7FFD57341A60
        public void RemoveFavorite(){} // RVA: 0x7FFD57341C90
        public void Delete(){} // RVA: 0x7FFD57341D80
        public void ContainsFavoriteByContentId(){} // RVA: 0x7FFD57341F00
        public void ContainsFavoriteByFavoriteId(){} // RVA: 0x7FFD57341F90
        public void GetFavoriteByContentId(){} // RVA: 0x7FFD57342020
        public void GetFavoriteByFavoriteId(){} // RVA: 0x7FFD573420B0
        public void FetchMembers(){} // RVA: 0x7FFD57342140
        public void FetchMembersInternal(){} // RVA: 0x7FFD57342620
        public void Add(){} // RVA: 0x7FFD57342D00
        public void AddFavoriteIndexed(){} // RVA: 0x7FFD57343650
        public void RemoveFavoriteIndexed(){} // RVA: 0x7FFD57341C90
        public void ReplaceFavoritesIndexed(){} // RVA: 0x7FFD573437D0
        public void TruncatedFavoriteListName(){} // RVA: 0x7FFD57343AE0
        public void SetNameAndPrivacy(){} // RVA: 0x7FFD57343B50
        public void .ctor(){} // RVA: 0x7FFD57343E20
    }

    public class GC : Object
    {
        public int ÎÍÌÏÏÎÏÍÍÌÌÌÌÌÎÍÎÎÎÌÎÏÎ;
        public float ÎÌÍÎÏÎÌÏÏÌÍÎÍÍÎÏÌÍÌÎÏÎÍ;
        public int ÍÌÍÍÌÎÍÍÏÌÍÎÌÎÍÎÌÎÌÌÏÏÏ;
        public string ÏÌÌÎÎÎÏÌÎÍÎÏÌÏÏÏÌÏÎÏÎÍÏ;
        public object ÏÍÍÏÌÎÍÎÍÌÏÎÎÌÌÎÎÍÎÎÍÎÎ;
        public float ÎÌÌÌÍÌÎÏÎÏÏÍÍÏÎÍÏÎÍÏÎÌÎ; // 0x8
        public int ÌÎÏÏÍÌÎÌÌÌÏÍÏÏÎÏÍÍÌÏÎÏÏ; // 0xC
        public object ÍÌÏÎÏÏÌÌÍÏÍÌÏÌÎÌÏÍÍÎÍÏÏ; // 0x10
        public object ÌÍÎÌÍÌÏÌÎÍÏÌÍÎÍÍÌÌÏÏÍÌÎ; // 0x20
        public object ÏÏÍÌÌÍÏÍÌÏÎÏÍÍÌÏÍÍÎÎÌÌÎ; // 0x30
        public object ÎÌÎÏÍÏÌÍÍÌÌÎÌÏÏÎÏÍÌÎÍÍÍ; // 0x40

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD4EDC4840
        public void Equals(){} // RVA: 0x7FFD4EDC4900
        public void GetHashCode(){} // RVA: 0x7FFD4EDC4D40
        public void op_Implicit(){} // RVA: 0x7FFD4EDC50A0
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EDC5560
        public void .cctor(){} // RVA: 0x7FFD4EDC57C0
    }

    public class IVRCLogger
    {
        public object IsEnabled;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFD4E079D00
        public void LogOnceEvery(){}
        public void LogOnceEveryFormat(){}
        public void Log(){} // RVA: 0x7FFD4E090A40
        public void LogFormat(){} // RVA: 0x7FFD4E099B30
        public void LogWarning(){} // RVA: 0x7FFD4E090A40
        public void LogWarningFormat(){} // RVA: 0x7FFD4E099B30
        public void LogError(){} // RVA: 0x7FFD4E090A40
        public void LogErrorFormat(){} // RVA: 0x7FFD4E099B30
    }

    public class LazySingleton`1 : MonoBehaviour
    {
        public dle<T1717581008> Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD4E2ADC40
        public void CreateSingleton(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class LocalConfig : BaseConfig
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57349470
        public void SetValue(){} // RVA: 0x7FFD573495B0
        public void FetchConfig(){} // RVA: 0x7FFD57349650
        public void SaveConfig(){} // RVA: 0x7FFD57349970
    }

    public class MemoryEqualityComparer`1 : Object
    {
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.nc>d__168<T1717581024> Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Equals(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class NullLogger : Object
    {
        public object IsEnabled;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFD4E341320
        public void LogOnceEvery(){} // RVA: 0x7FFD4E341310
        public void LogOnceEveryFormat(){} // RVA: 0x7FFD4E341310
        public void Log(){} // RVA: 0x7FFD4E341310
        public void LogFormat(){} // RVA: 0x7FFD4E341310
        public void LogWarning(){} // RVA: 0x7FFD4E341310
        public void LogWarningFormat(){} // RVA: 0x7FFD4E341310
        public void LogError(){} // RVA: 0x7FFD4E341310
        public void LogErrorFormat(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class PipelineManager : MonoBehaviour
    {
        public URA.DateTime<2_FE_LONGS,string> BlueprintIdPrefixMap;
        public bool launchedFromSDKPipeline; // 0x20
        public bool completedSDKPipeline; // 0x21
        public string blueprintId; // 0x28
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.reated user; // 0x30
        public 2_FE_LONGS contentType; // 0x38
        public string assetBundleUnityVersion; // 0x40
        public le fallbackStatus; // 0x48
        public cellLayout owned; // 0x4C

        // ── Methods ──
        public void IsMyContent(){} // RVA: 0x7FFD56E4DED0
        public void AssignId(){} // RVA: 0x7FFD56E4E1A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void .cctor(){} // RVA: 0x7FFD56E4E630
        public void <IsMyContent>b__12_0(){} // RVA: 0x7FFD56E4E7F0
        public void <IsMyContent>b__12_1(){} // RVA: 0x7FFD56E4E900
        public void <IsMyContent>b__12_2(){} // RVA: 0x7FFD56E4E910
        public void <IsMyContent>b__12_3(){} // RVA: 0x7FFD56E4E900
    }

    public class PriorityQueue`1 : Object
    {
        public URA.woDigitYearMax<T1717581056> Data;
        public URA.woDigitYearMax<T1717581056> Count;
        public eCaptcha<T1717581056> reverseComparer;

        // ── Methods ──
        public void get_Data(){} // RVA: 0x7FFD4E078E90
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void .ctor(){} // RVA: 0x7FFD4E090ED0 | overloaded x2
        public void Concat(){} // RVA: 0x7FFD4E090A40
        public void Push(){} // RVA: 0x7FFD4E2ADC40
        public void Pop(){} // RVA: 0x7FFD4E079F60
        public void Peek(){} // RVA: 0x7FFD4E079F60
        public void PopNextMatch(){}
        public void RemoveWhere(){} // RVA: 0x7FFD4E090A40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class RemoteConfig : BaseConfig
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57349A50
        public void FetchConfig(){} // RVA: 0x7FFD57349AA0
    }

    public class UnityEventFilter : Object
    {
        public URA.onsDepth<?> _name;
        public dle<URA.DateTime<?,?>> _hideFlags; // 0x8
        public dle<URA.DateTime<?,?>> f_918; // 0x10
        public dle<string> ÏÌÎÍÏÍÎÎÍÍÏÌÎÎÎÍÍÌÏÏÏÏÌ; // 0x18
        public URA.DateTime<?,?> ÎÎÌÎÎÌÌÍÌÎÏÎÏÍÏÍÌÍÍÎÏÍÎ; // 0x20
        public URA.onsDepth<string> ÌÍÎÎÍÍÏÌÎÌÍÎÌÍÏÌÏÎÌÍÎÎÍ; // 0x28

        // ── Methods ──
        public void GetInstanceID(){} // RVA: 0x7FFD4EE7BBF0
        public void Equals(){} // RVA: 0x7FFD4EE7BC70
        public void GetHashCode(){} // RVA: 0x7FFD4EE7BCF0
        public void op_Implicit(){} // RVA: 0x7FFD4EE7BD70
        public void InitializeLazy(){} // RVA: 0x7FFD4EE7BE40
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EE7BFB0
        public void GetCachedPtr(){} // RVA: 0x7FFD4EE7C380
        public void set_name_2EEE284FFCA1(){} // RVA: 0x7FFD4EE7C5B0 | overloaded x2
        public void Instantiate(){} // RVA: 0x7FFD4EE7D080 | overloaded x4
        public void TryProcessEventFilter(){} // RVA: 0x7FFD4EE7D870 | overloaded x3
        public void TryProcessNetworkAction(){} // RVA: 0x7FFD4EE7DDC0
        public void ProcessEventFilter(){} // RVA: 0x7FFD4EE7DE60
        public void InitializeEventFilterState(){} // RVA: 0x7FFD4EE7DF00
        public void Destroy(){} // RVA: 0x7FFD4EE7E140
        public void ApplyEventFilteringLogic(){} // RVA: 0x7FFD4EE7E420
        public void .cctor(){} // RVA: 0x7FFD4EE7E710
        public void DestroyImmediate(){} // RVA: 0x7FFD4EE83130
        public void FindObjectsOfType(){} // RVA: 0x7FFD4EE83250
    }

    public class UnityVersion : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD57354C70
        public void CompareTo(){} // RVA: 0x7FFD57354C90
        public void Parse(){} // RVA: 0x7FFD57354D60
        public void TryParse(){} // RVA: 0x7FFD573551A0
        public void ToString(){} // RVA: 0x7FFD573555B0
        public void .cctor(){} // RVA: 0x7FFD57355860
    }

    public class UpdateDelegator : Object
    {
        public object _queueLock;
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.d__169<etionSource> _jobQueue; // 0x8
        public int MaxJobsPerFrame;

        // ── Methods ──
        public void Dispatch(){} // RVA: 0x7FFD57355940
        public void DispatchAfter(){} // RVA: 0x7FFD57355C60
        public void ManagedUpdate(){} // RVA: 0x7FFD57355E90
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD57356260
    }

    public class VRCCertificatePolicy : Object
    {
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.? _vRCCertificatePolicy;
        public ialized.ed ÍÍÎÎÎÏÎÏÎÍÎÏÍÏÏÍÍÍÏÎÏÏÎ; // 0x8

        // ── Methods ──
        public void CheckValidationResult(){} // RVA: 0x7FFD4EDFEDD0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Initialize(){} // RVA: 0x7FFD4EDFF120
        public void op_Implicit(){} // RVA: 0x7FFD4EDFF450
        public void CompareBaseObjects(){} // RVA: 0x7FFD4EDFF880
        public void IsNativeObjectAlive(){} // RVA: 0x7FFD4EDFF8C0
        public void GetCachedPtr(){} // RVA: 0x7FFD4EDFFBF0
        public void get_name(){} // RVA: 0x7FFD4EDFFCB0
        public void set_name(){} // RVA: 0x7FFD4EE00240
        public void Instantiate(){} // RVA: 0x7FFD4EE002E0
        public void InitVRCCertificatePolicy(){} // RVA: 0x7FFD4EE00610
        public void Equals(){} // RVA: 0x7FFD4EE007B0
        public void GetHashCode(){} // RVA: 0x7FFD4EE007F0
        public void ToString(){} // RVA: 0x7FFD4EE00990
        public void ToString_E009047AABDC(){} // RVA: 0x7FFD4EE00BC0
        public void InvokeComponentAction(){} // RVA: 0x7FFD4EE00C60
        public void IsInternalComponentActive(){} // RVA: 0x7FFD4EE00D00
    }

    public class VRCEvent : ApiModel
    {
        public object name;
        public object description;
        public object imageUrl;
        public object authorName;
        public object authorId;
        public object startTime;
        public object venueId;

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFD4E3BCD50
        public void set_name(){} // RVA: 0x7FFD4E3BCD60
        public void get_description(){} // RVA: 0x7FFD4E409590
        public void set_description(){} // RVA: 0x7FFD4E4095A0
        public void get_imageUrl(){} // RVA: 0x7FFD4E505600
        public void set_imageUrl(){} // RVA: 0x7FFD4E5006F0
        public void get_authorName(){} // RVA: 0x7FFD4E70F410
        public void set_authorName(){} // RVA: 0x7FFD4E8F4AA0
        public void get_authorId(){} // RVA: 0x7FFD4E380010
        public void set_authorId(){} // RVA: 0x7FFD4E96E300
        public void get_startTime(){} // RVA: 0x7FFD4E70F640
        public void set_startTime(){} // RVA: 0x7FFD4E96E360
        public void get_venueId(){} // RVA: 0x7FFD4E96DFB0
        public void set_venueId(){} // RVA: 0x7FFD4E96E3C0
        public void .ctor(){} // RVA: 0x7FFD57335930
        public void MakeEvents(){} // RVA: 0x7FFD573359D0
        public void ToString(){} // RVA: 0x7FFD57335D30
    }

    public class VRCLogger : Object
    {
        public bool IsPathOverridden;
        public ÏÎÏÍÍÌÏÍÌÌÍÍÌÎÎÎÌÎÌÍÎÌÍ.? LogFileNamePrefix; // 0x8
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.SetRequestHeader LogFilePath; // 0x10
        public JapaneseLangName.erns<string,ÏÎÏÍÍÌÏÍÌÌÍÍÌÎÎÎÌÎÌÍÎÌÍ.Identifiers> GlobalLogger; // 0x18
        public string _logFilePathOverride; // 0x20
        public dle<string> <LogFileNamePrefix>k__BackingField; // 0x28
        public ÏÎÏÍÍÌÏÍÌÌÍÍÌÎÎÎÌÎÌÍÎÌÍ.Identifiers _globalLogger; // 0x30
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.? _zLoggerHandler; // 0x38
        public object UnityLogPrefixFormat; // 0x40
        public object LogFilePrefixFormat; // 0x50
        public e OnMessageLogged; // 0x60

        // ── Methods ──
        public void get_IsPathOverridden(){} // RVA: 0x7FFD55283F80
        public void get_LogFileNamePrefix(){} // RVA: 0x7FFD55283FF0
        public void get_LogFilePath(){} // RVA: 0x7FFD55284050
        public void get_GlobalLogger(){} // RVA: 0x7FFD552841D0
        public void add_OnMessageLogged(){} // RVA: 0x7FFD552842E0
        public void remove_OnMessageLogged(){} // RVA: 0x7FFD55284430
        public void IsLogPathValid(){} // RVA: 0x7FFD55284580
        public void OverrideLogFilePath(){} // RVA: 0x7FFD55284710
        public void InitializeZLogger(){} // RVA: 0x7FFD55284A80
        public void TeardownZLogger(){} // RVA: 0x7FFD55284F60
        public void FilterLogEntry(){} // RVA: 0x7FFD55285260
        public void UnityLogFormatPrefix(){} // RVA: 0x7FFD552853B0
        public void LogFileFormatPrefix(){} // RVA: 0x7FFD55285460
        public void HandleInterceptedMessage(){} // RVA: 0x7FFD55285530
        public void HandleZLoggerInternalException_Unity(){} // RVA: 0x7FFD552856B0
        public void HandleZLoggerInternalException_File(){} // RVA: 0x7FFD55285830
        public void SetLoggingMode(){} // RVA: 0x7FFD552859B0
        public void GetCurrentLogLevel(){} // RVA: 0x7FFD55285A10
        public void GetLogger(){} // RVA: 0x7FFD55285A90
        public void RemoveStaleLogs(){} // RVA: 0x7FFD55285D70
        public void GenerateOutputLogFilename(){} // RVA: 0x7FFD55285FF0
        public void GetLogDirectory(){} // RVA: 0x7FFD55286270
        public void Log(){} // RVA: 0x7FFD55286910 | overloaded x2
        public void LogWarning(){} // RVA: 0x7FFD55286D20 | overloaded x2
        public void LogError(){} // RVA: 0x7FFD55287130 | overloaded x2
        public void LogException(){} // RVA: 0x7FFD55287690 | overloaded x2
        public void OnMain(){} // RVA: 0x7FFD55287AE0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD55287D10
    }

    public class ZLoggerHandlerLogger : Object
    {
        public formation<string,object[],?> UnityHandler; // 0x10
        public ode _unityHandler;
        public object _profilerMarkerLogFormat; // 0x8
        public object _profilerMarkerLogException; // 0x10

        // ── Methods ──
        public void get_UnityHandler(){} // RVA: 0x7FFD5528ADB0
        public void EnsureCapturedUnityHandler(){} // RVA: 0x7FFD5528AE10
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void SetUnityInterceptActive(){} // RVA: 0x7FFD5528AF50
        public void LogFormat(){} // RVA: 0x7FFD5528B050
        public void LogException(){} // RVA: 0x7FFD5528B6F0
        public void .cctor(){} // RVA: 0x7FFD5528B8F0
    }

}