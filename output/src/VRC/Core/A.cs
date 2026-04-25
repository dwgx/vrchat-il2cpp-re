// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 100
// Methods: 2301

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
        public 0x6B0AC360 _apiOnlineMode; // 0x20
        public float RESPONSE_CACHE_LIFETIME;
        public string LOG_CATEGORY;
        public System.Collections.Generic.Dictionary`2<string,EndpointAccessEntry> EndpointAccessTimes; // 0x28
        public int MAX_RETRY_COUNT;
        public float RETRY_DELAY_SECONDS;
        public VRC.Core.FavoriteArea Favorites; // 0x30
        public int _lastRequestId; // 0x38
        public System.Collections.Generic.Dictionary`2<string,BestHTTP.HTTPRequest> _activeRequests; // 0x40
        public System.Collections.Generic.List`1<System.Collections.Generic.IReadOnlyDictionary`2<string,Token>> _offlineQueries; // 0x48
        public bool <IsVRCClient>k__BackingField; // 0x50

        // ── Methods ──
        public void get_ClientGameServerVersion(){} // RVA: 0x7FFACBE5A1A0
        public void .cctor(){} // RVA: 0x7FFACBE5A200
        public void RegisterLogging(){} // RVA: 0x7FFACBE5A750
        public void SetClientVersion(){} // RVA: 0x7FFACBE5A800
        public void GetClientVersion(){} // RVA: 0x7FFACBE5A8C0
        public void SetStore(){} // RVA: 0x7FFACBE5A920
        public void GetStore(){} // RVA: 0x7FFACBE5A9E0
        public void SetAllowRoaming(){} // RVA: 0x7FFACBE5AA40
        public void GetAllowRoaming(){} // RVA: 0x7FFACBE5AAA0
        public void SetClientGameServerVersion(){} // RVA: 0x7FFACBE5AB00
        public void IsReady(){} // RVA: 0x7FFACBE5AB60
        public void FromCacheOrNew(){} // RVA: 0x7FFAC2E8DC40
        public void CreateFromJson(){} // RVA: 0x7FFAC2E8DC40
        public void Fetch(){} // RVA: 0x7FFAC2E8DC40
        public void FetchAsync(){} // RVA: 0x7FFAC2C699E0
        public void DeleteAsync(){} // RVA: 0x7FFAC2C58F80
        public void Delete(){} // RVA: 0x7FFAC2C761F0
        public void get_DeviceID(){} // RVA: 0x7FFAC8B17AB0
        public void SetApiUrlFromEnvironment(){} // RVA: 0x7FFACBE5AC00
        public void GetApiUrlForEnvironment(){} // RVA: 0x7FFACBE5AE00
        public void SetApiUrl(){} // RVA: 0x7FFACBE5AF30
        public void GetApiUrl(){} // RVA: 0x7FFACBE5AFE0
        public void IsDevApi(){} // RVA: 0x7FFACBE5B040
        public void IsDevCeApi(){} // RVA: 0x7FFACBE5B120
        public void SendGetRequest(){} // RVA: 0x7FFACBE5B200
        public void SendPostRequest(){} // RVA: 0x7FFACBE5B320
        public void SendPostFormRequest(){} // RVA: 0x7FFACBE5B440
        public void SendPostRawJsonRequest(){} // RVA: 0x7FFACBE5B560
        public void SendPutRequest(){} // RVA: 0x7FFACBE5B680
        public void SendDeleteRequest(){} // RVA: 0x7FFACBE5B7A0
        public void SendRequest(){} // RVA: 0x7FFACBE5B8C0
        public void SendRequestInternal(){} // RVA: 0x7FFACBE5BFF0
        public void AuthenticateHTTPRequest(){} // RVA: 0x7FFACBE5D590
        public void AuthenticateUnityWebRequest(){} // RVA: 0x7FFACBE5DA00
        public void PopulateHTTPRequestHeaders(){} // RVA: 0x7FFACBE5DD50
        public void PopulateUnityWebRequestHeaders(){} // RVA: 0x7FFACBE5E1E0
        public void CertVerifyHTTPRequest(){} // RVA: 0x7FFACBE5E4B0
        public void CertVerifyUnityWebRequest(){} // RVA: 0x7FFACBE5E660
        public void InitializeCertificateVerifier(){} // RVA: 0x7FFACBE5E920
        public void AppendQuery(){} // RVA: 0x7FFACBE5EA50
        public void ConvertJsonListToModelList(){} // RVA: 0x7FFAC2C58FF0
        public void get_IsVRCClient(){} // RVA: 0x7FFACBE5EB00
        public void set_IsVRCClient(){} // RVA: 0x7FFACBE5EB60
        public void SetOnlineMode(){} // RVA: 0x7FFACBE5EBC0
        public void ClearOnlineMode(){} // RVA: 0x7FFACBE5EF90
        public void IsOffline(){} // RVA: 0x7FFACBE5F040
        public void GetServerEnvironmentForApiUrl(){} // RVA: 0x7FFACBE5F100 | overloaded x2
        public void SendOfflineRequest(){} // RVA: 0x7FFACBE5F3C0
        public void GenerateMergeCode(){} // RVA: 0x7FFACBE5FA90
    }

    public class API2FA : ApiModel
    {
        public System.Collections.Generic.List`1<string> requiresTwoFactorAuth; // 0x68
        public string scope; // 0x70
        public string ticket; // 0x78
        public string TIME_BASED_ONE_TIME_PASSWORD_AUTHENTICATION;
        public string EMAIL_BASED_ONE_TIME_PASSWORD_AUTHENTICATION;
        public string ONE_TIME_PASSWORD_AUTHENTICATION;
        public string SMS_AUTHENTICATION;

        // ── Methods ──
        public void get_requiresTwoFactorAuth(){} // RVA: 0x7FFAC2F9CD50
        public void set_requiresTwoFactorAuth(){} // RVA: 0x7FFAC2F9CD60
        public void get_scope(){} // RVA: 0x7FFAC2FE9590
        public void set_scope(){} // RVA: 0x7FFAC2FE95A0
        public void get_ticket(){} // RVA: 0x7FFAC30E5600
        public void set_ticket(){} // RVA: 0x7FFAC30E06F0
        public void TimeBasedOneTimePasswordSupported(){} // RVA: 0x7FFACBE606E0
        public void EmailBasedOneTimePasswordSupported(){} // RVA: 0x7FFACBE60740
        public void OneTimePasswordSupported(){} // RVA: 0x7FFACBE607A0
        public void SmsSupported(){} // RVA: 0x7FFACBE60800
        public void ToString(){} // RVA: 0x7FFACBE60860
        public void .ctor(){} // RVA: 0x7FFACBE60AC0
    }

    public class APIActivationSuccessfulTargetResult : ApiModel
    {
        public string userId; // 0x68
        public int gifts; // 0x70
        public bool isFriend; // 0x74

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFAC2F9CD50
        public void set_userId(){} // RVA: 0x7FFAC2F9CD60
        public void get_gifts(){} // RVA: 0x7FFAC3B99E80
        public void set_gifts(){} // RVA: 0x7FFAC30B6520
        public void get_isFriend(){} // RVA: 0x7FFAC3BCD8B0
        public void set_isFriend(){} // RVA: 0x7FFAC81C5400
        public void .ctor(){} // RVA: 0x7FFACBE77630
    }

    public class APICalendarEntry : ApiModel
    {
        public string ownerId; // 0x68
        public 0x6B0B4FF8 accessType; // 0x70
        public System.DateTime startsAt; // 0x78
        public System.DateTime endsAt; // 0x80
        public string title; // 0x88
        public string description; // 0x90
        public string category; // 0x98
        public string shortCode; // 0xA0
        public string type; // 0xA8
        public bool isDraft; // 0xB0
        public string imageId; // 0xB8
        public string imageUrl; // 0xC0
        public System.Collections.Generic.List`1<string> roleIds; // 0xC8
        public System.Collections.Generic.List`1<string> tags; // 0xD0
        public System.Collections.Generic.List`1<string> platforms; // 0xD8
        public System.Collections.Generic.List`1<string> languages; // 0xE0
        public string parentId; // 0xE8
        public int hostEarlyJoinMinutes; // 0xF0
        public int guestEarlyJoinMinutes; // 0xF4
        public int closeInstanceAfterEndMinutes; // 0xF8
        public bool usesInstanceOverflow; // 0xFC
        public System.DateTime deletedAt; // 0x100
        public VRC.Core.APICalendarEntryUserInterest userInterest; // 0x108
        public bool featured; // 0x110
        public int interestedUserCount; // 0x114

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF121D0
        public void get_ownerId(){} // RVA: 0x7FFAC2F9CD50
        public void set_ownerId(){} // RVA: 0x7FFAC2F9CD60
        public void get_accessType(){} // RVA: 0x7FFAC3B99E80
        public void set_accessType(){} // RVA: 0x7FFAC30B6520
        public void get_startsAt(){} // RVA: 0x7FFAC30E5600
        public void set_startsAt(){} // RVA: 0x7FFAC8246500
        public void get_endsAt(){} // RVA: 0x7FFAC32EF410
        public void set_endsAt(){} // RVA: 0x7FFAC4A2BA90
        public void get_title(){} // RVA: 0x7FFAC2F60010
        public void set_title(){} // RVA: 0x7FFAC354E300
        public void get_description(){} // RVA: 0x7FFAC32EF640
        public void set_description(){} // RVA: 0x7FFAC354E360
        public void get_category(){} // RVA: 0x7FFAC354DFB0
        public void set_category(){} // RVA: 0x7FFAC354E3C0
        public void get_shortCode(){} // RVA: 0x7FFAC3543900
        public void set_shortCode(){} // RVA: 0x7FFAC354E420
        public void get_type(){} // RVA: 0x7FFAC354B1A0
        public void set_type(){} // RVA: 0x7FFAC334B370
        public void get_isDraft(){} // RVA: 0x7FFAC41E71E0
        public void set_isDraft(){} // RVA: 0x7FFAC41E6D30
        public void get_imageId(){} // RVA: 0x7FFAC2F8C0B0
        public void set_imageId(){} // RVA: 0x7FFAC2F8C0C0
        public void get_imageUrl(){} // RVA: 0x7FFAC2F8C120
        public void set_imageUrl(){} // RVA: 0x7FFAC2F8C130
        public void get_roleIds(){} // RVA: 0x7FFAC3079460
        public void set_roleIds(){} // RVA: 0x7FFAC3079470
        public void get_tags(){} // RVA: 0x7FFAC303E100
        public void set_tags(){} // RVA: 0x7FFAC303E110
        public void get_platforms(){} // RVA: 0x7FFAC3540F70
        public void set_platforms(){} // RVA: 0x7FFAC2FA28A0
        public void get_languages(){} // RVA: 0x7FFAC2FA2900
        public void set_languages(){} // RVA: 0x7FFAC2FA2910
        public void get_parentId(){} // RVA: 0x7FFAC2FA2970
        public void set_parentId(){} // RVA: 0x7FFAC2FA2980
        public void get_hostEarlyJoinMinutes(){} // RVA: 0x7FFAC60855D0
        public void set_hostEarlyJoinMinutes(){} // RVA: 0x7FFAC8A11630
        public void get_guestEarlyJoinMinutes(){} // RVA: 0x7FFAC6715830
        public void set_guestEarlyJoinMinutes(){} // RVA: 0x7FFAC6715840
        public void get_closeInstanceAfterEndMinutes(){} // RVA: 0x7FFAC3E69BA0
        public void set_closeInstanceAfterEndMinutes(){} // RVA: 0x7FFAC3E69950
        public void get_usesInstanceOverflow(){} // RVA: 0x7FFACBF12220
        public void set_usesInstanceOverflow(){} // RVA: 0x7FFACBF12230
        public void get_deletedAt(){} // RVA: 0x7FFAC34F6C80
        public void set_deletedAt(){} // RVA: 0x7FFAC4196020
        public void get_userInterest(){} // RVA: 0x7FFAC36D1F40
        public void set_userInterest(){} // RVA: 0x7FFAC3929BF0
        public void get_featured(){} // RVA: 0x7FFAC31E7D90
        public void set_featured(){} // RVA: 0x7FFAC31E5C40
        public void get_interestedUserCount(){} // RVA: 0x7FFAC9745510
        public void set_interestedUserCount(){} // RVA: 0x7FFAC9745520
        public void UpdateData(){} // RVA: 0x7FFACBF12240
        public void WriteField(){} // RVA: 0x7FFACBF12A00
    }

    public class APICalendarEntryUserInterest : ApiModel
    {
        public bool isFollowing; // 0x68
        public System.DateTime createdAt; // 0x70
        public System.DateTime updatedAt; // 0x78

        // ── Methods ──
        public void get_isFollowing(){} // RVA: 0x7FFAC2FE9570
        public void set_isFollowing(){} // RVA: 0x7FFAC2FE9580
        public void get_createdAt(){} // RVA: 0x7FFAC2FE9590
        public void set_createdAt(){} // RVA: 0x7FFAC4A2BA60
        public void get_updatedAt(){} // RVA: 0x7FFAC30E5600
        public void set_updatedAt(){} // RVA: 0x7FFAC8246500
        public void .ctor(){} // RVA: 0x7FFACBF12E90
    }

    public class APICampaignInfo : ApiModel
    {
        public bool campaignActive; // 0x68
        public bool dataAvailable; // 0x69
        public System.DateTime endDate; // 0x70
        public int globalGiftCount; // 0x78
        public int globalGiftGoal; // 0x7C
        public bool globalGiftGoalSuccess; // 0x80
        public int globalParticipantCount; // 0x84
        public string lastRefreshTime; // 0x88
        public int localPurchaseCount; // 0x90
        public string name; // 0x98
        public string description; // 0xA0
        public System.Collections.Generic.List`1<string> participatingFriends; // 0xA8
        public System.Collections.Generic.List`1<VRC.Core.ApiCampaignReward> rewards; // 0xB0
        public System.DateTime startDate; // 0xB8
        public int globalDollarsGoal; // 0xC0
        public int globalDollarsRaised; // 0xC4
        public int globalPurchaseCount; // 0xC8
        public bool includeGiftDrops; // 0xCC
        public bool includeGifts; // 0xCD
        public bool includeSubscriptions; // 0xCE
        public string slug; // 0xD0
        public bool uDidIt; // 0xD8

        // ── Methods ──
        public void get_campaignActive(){} // RVA: 0x7FFAC2FE9570
        public void set_campaignActive(){} // RVA: 0x7FFAC2FE9580
        public void get_dataAvailable(){} // RVA: 0x7FFAC4670BD0
        public void set_dataAvailable(){} // RVA: 0x7FFAC466E010
        public void get_endDate(){} // RVA: 0x7FFAC2FE9590
        public void set_endDate(){} // RVA: 0x7FFAC4A2BA60
        public void get_globalGiftCount(){} // RVA: 0x7FFAC4596EF0
        public void set_globalGiftCount(){} // RVA: 0x7FFAC45963A0
        public void get_globalGiftGoal(){} // RVA: 0x7FFAC4598F70
        public void set_globalGiftGoal(){} // RVA: 0x7FFAC89E0310
        public void get_globalGiftGoalSuccess(){} // RVA: 0x7FFAC313E620
        public void set_globalGiftGoalSuccess(){} // RVA: 0x7FFAC313D3B0
        public void get_globalParticipantCount(){} // RVA: 0x7FFAC46D5110
        public void set_globalParticipantCount(){} // RVA: 0x7FFAC46D5150
        public void get_lastRefreshTime(){} // RVA: 0x7FFAC2F60010
        public void set_lastRefreshTime(){} // RVA: 0x7FFAC354E300
        public void get_localPurchaseCount(){} // RVA: 0x7FFAC3220660
        public void set_localPurchaseCount(){} // RVA: 0x7FFAC34D2750
        public void get_name(){} // RVA: 0x7FFAC354DFB0
        public void set_name(){} // RVA: 0x7FFAC354E3C0
        public void get_description(){} // RVA: 0x7FFAC3543900
        public void set_description(){} // RVA: 0x7FFAC354E420
        public void get_participatingFriends(){} // RVA: 0x7FFAC354B1A0
        public void set_participatingFriends(){} // RVA: 0x7FFAC334B370
        public void get_rewards(){} // RVA: 0x7FFAC2F8C040
        public void set_rewards(){} // RVA: 0x7FFAC2F8C050
        public void get_startDate(){} // RVA: 0x7FFAC2F8C0B0
        public void set_startDate(){} // RVA: 0x7FFAC45C9F90
        public void get_globalDollarsGoal(){} // RVA: 0x7FFAC313B720
        public void set_globalDollarsGoal(){} // RVA: 0x7FFAC31434F0
        public void get_globalDollarsRaised(){} // RVA: 0x7FFAC47D3250
        public void set_globalDollarsRaised(){} // RVA: 0x7FFAC893FDA0
        public void get_globalPurchaseCount(){} // RVA: 0x7FFAC3641480
        public void set_globalPurchaseCount(){} // RVA: 0x7FFAC623E970
        public void get_includeGiftDrops(){} // RVA: 0x7FFAC4738E90
        public void set_includeGiftDrops(){} // RVA: 0x7FFAC8A119A0
        public void get_includeGifts(){} // RVA: 0x7FFAC3332010
        public void set_includeGifts(){} // RVA: 0x7FFACBE6A600
        public void get_includeSubscriptions(){} // RVA: 0x7FFACBE6A610
        public void set_includeSubscriptions(){} // RVA: 0x7FFACBE6A620
        public void get_slug(){} // RVA: 0x7FFAC303E100
        public void set_slug(){} // RVA: 0x7FFAC303E110
        public void get_uDidIt(){} // RVA: 0x7FFAC3DBD9E0
        public void set_uDidIt(){} // RVA: 0x7FFAC88C7210
        public void GetCampaignSummary(){} // RVA: 0x7FFACBE6A630
        public void GetCampaignAnonymizationState(){} // RVA: 0x7FFACBE6A830
        public void SetCampaignAnonymizationState(){} // RVA: 0x7FFACBE6AB80
        public void GetCampaignLeaderboardFriends(){} // RVA: 0x7FFACBE6B010
        public void GetCampaignLeaderboardGlobal(){} // RVA: 0x7FFACBE6B080
        public void GetCampaignLeaderboard(){} // RVA: 0x7FFACBE6B0F0
        public void .ctor(){} // RVA: 0x7FFACBE6B430
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
        public void get_fileId(){} // RVA: 0x7FFAC2F9CD50
        public void set_fileId(){} // RVA: 0x7FFAC2F9CD60
        public void get_imageUrl(){} // RVA: 0x7FFAC2FE9590
        public void set_imageUrl(){} // RVA: 0x7FFAC2FE95A0
        public void get_animationStyle(){} // RVA: 0x7FFAC30E5600
        public void set_animationStyle(){} // RVA: 0x7FFAC30E06F0
        public void get_maskTag(){} // RVA: 0x7FFAC32EF410
        public void set_maskTag(){} // RVA: 0x7FFAC34D4AA0
        public void get_animated(){} // RVA: 0x7FFAC3E003A0
        public void set_animated(){} // RVA: 0x7FFAC3E0C170
        public void get_frames(){} // RVA: 0x7FFAC5F56E80
        public void set_frames(){} // RVA: 0x7FFAC65A0990
        public void get_framesOverTime(){} // RVA: 0x7FFAC3220660
        public void set_framesOverTime(){} // RVA: 0x7FFAC34D2750
        public void get_loopStyle(){} // RVA: 0x7FFAC354DFB0
        public void set_loopStyle(){} // RVA: 0x7FFAC354E3C0
        public void get_assetBundleId(){} // RVA: 0x7FFAC3543900
        public void set_assetBundleId(){} // RVA: 0x7FFAC354E420
        public void get_premium(){} // RVA: 0x7FFAC3141F10
        public void set_premium(){} // RVA: 0x7FFAC313FE60
        public void UploadEmoji(){} // RVA: 0x7FFACBE6D3C0 | overloaded x2
        public void Fetch(){} // RVA: 0x7FFACBE6DA20
        public void .ctor(){} // RVA: 0x7FFACBE6DD50
        public void <Fetch>g__ParseData|45_0(){} // RVA: 0x7FFACBE6DDC0
    }

    public class APIGiftBundle : ApiModel
    {
        public string steamItemId; // 0x68
        public string oculusSku; // 0x70
        public string googleProductId; // 0x78
        public string googlePlanId; // 0x80
        public string picoSku; // 0x88
        public int amount; // 0x90
        public string description; // 0x98
        public string period; // 0xA0
        public int periodAmount; // 0xA8
        public int tier; // 0xAC
        public int bulkSize; // 0xB0
        public int discountPercentage; // 0xB4
        public System.Collections.Generic.List`1<string> licenseGroups; // 0xB8

        // ── Methods ──
        public void get_steamItemId(){} // RVA: 0x7FFAC2F9CD50
        public void set_steamItemId(){} // RVA: 0x7FFAC2F9CD60
        public void get_oculusSku(){} // RVA: 0x7FFAC2FE9590
        public void set_oculusSku(){} // RVA: 0x7FFAC2FE95A0
        public void get_googleProductId(){} // RVA: 0x7FFAC30E5600
        public void set_googleProductId(){} // RVA: 0x7FFAC30E06F0
        public void get_googlePlanId(){} // RVA: 0x7FFAC32EF410
        public void set_googlePlanId(){} // RVA: 0x7FFAC34D4AA0
        public void get_picoSku(){} // RVA: 0x7FFAC2F60010
        public void set_picoSku(){} // RVA: 0x7FFAC354E300
        public void get_amount(){} // RVA: 0x7FFAC3220660
        public void set_amount(){} // RVA: 0x7FFAC34D2750
        public void get_description(){} // RVA: 0x7FFAC354DFB0
        public void set_description(){} // RVA: 0x7FFAC354E3C0
        public void get_period(){} // RVA: 0x7FFAC3543900
        public void set_period(){} // RVA: 0x7FFAC354E420
        public void get_periodAmount(){} // RVA: 0x7FFAC39055C0
        public void set_periodAmount(){} // RVA: 0x7FFAC38FD010
        public void get_tier(){} // RVA: 0x7FFAC6539490
        public void set_tier(){} // RVA: 0x7FFAC65394A0
        public void get_bulkSize(){} // RVA: 0x7FFAC4BF81F0
        public void set_bulkSize(){} // RVA: 0x7FFAC87B5A90
        public void get_discountPercentage(){} // RVA: 0x7FFAC6715300
        public void set_discountPercentage(){} // RVA: 0x7FFAC6715310
        public void get_licenseGroups(){} // RVA: 0x7FFAC2F8C0B0
        public void set_licenseGroups(){} // RVA: 0x7FFAC2F8C0C0
        public void .ctor(){} // RVA: 0x7FFACBE77590
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
        public VRC.Core.APIGroupMember myMember; // 0xC0
        public System.DateTime createdAt; // 0xC8
        public System.DateTime updatedAt; // 0xD0
        public string membershipStatus; // 0xD8
        public string bannerId; // 0xE0
        public string iconId; // 0xE8
        public string rules; // 0xF0
        public System.Collections.Generic.List`1<string> initialRoleIds; // 0xF8
        public bool isSystemGroup; // 0x100
        public bool isVerified; // 0x101
        public System.Collections.Generic.List`1<GalleryObject> galleries; // 0x108
        public System.Collections.Generic.List`1<string> tags; // 0x110
        public bool isSearchable; // 0x118
        public int sizeQuality; // 0x11C
        public int activityQuality; // 0x120
        public int engagementQuality; // 0x124
        public int contentQuality; // 0x128
        public System.Collections.Generic.List`1<VRC.Core.APIGroupRole> roles; // 0x130
        public System.Collections.Generic.List`1<string> links; // 0x138
        public System.Collections.Generic.List`1<string> languages; // 0x140
        public System.DateTime lastPostCreatedAt; // 0x148
        public string storeId; // 0x150

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF16030 | overloaded x2
        public void get_ownerId(){} // RVA: 0x7FFAC2F9CD50
        public void set_ownerId(){} // RVA: 0x7FFAC2F9CD60
        public void get_name(){} // RVA: 0x7FFAC2FE9590
        public void set_name(){} // RVA: 0x7FFAC2FE95A0
        public void get_shortCode(){} // RVA: 0x7FFAC30E5600
        public void set_shortCode(){} // RVA: 0x7FFAC30E06F0
        public void get_discriminator(){} // RVA: 0x7FFAC32EF410
        public void set_discriminator(){} // RVA: 0x7FFAC34D4AA0
        public void get_description(){} // RVA: 0x7FFAC2F60010
        public void set_description(){} // RVA: 0x7FFAC354E300
        public void get_iconUrl(){} // RVA: 0x7FFAC32EF640
        public void set_iconUrl(){} // RVA: 0x7FFAC354E360
        public void get_bannerUrl(){} // RVA: 0x7FFAC354DFB0
        public void set_bannerUrl(){} // RVA: 0x7FFAC354E3C0
        public void get_memberCount(){} // RVA: 0x7FFAC489E510
        public void set_memberCount(){} // RVA: 0x7FFAC489E550
        public void get_onlineMemberCount(){} // RVA: 0x7FFAC6539470
        public void set_onlineMemberCount(){} // RVA: 0x7FFAC6539480
        public void get_memberCountSyncedAt(){} // RVA: 0x7FFAC354B1A0
        public void set_memberCountSyncedAt(){} // RVA: 0x7FFAC334B370
        public void get_privacy(){} // RVA: 0x7FFAC2F8C040
        public void set_privacy(){} // RVA: 0x7FFAC2F8C050
        public void get_joinState(){} // RVA: 0x7FFAC2F8C0B0
        public void set_joinState(){} // RVA: 0x7FFAC2F8C0C0
        public void get_myMember(){} // RVA: 0x7FFAC2F8C120
        public void set_myMember(){} // RVA: 0x7FFAC2F8C130
        public void get_createdAt(){} // RVA: 0x7FFAC3079460
        public void set_createdAt(){} // RVA: 0x7FFACB9790D0
        public void get_updatedAt(){} // RVA: 0x7FFAC303E100
        public void set_updatedAt(){} // RVA: 0x7FFAC906B850
        public void get_membershipStatus(){} // RVA: 0x7FFAC3540F70
        public void set_membershipStatus(){} // RVA: 0x7FFAC2FA28A0
        public void get_bannerId(){} // RVA: 0x7FFAC2FA2900
        public void set_bannerId(){} // RVA: 0x7FFAC2FA2910
        public void get_iconId(){} // RVA: 0x7FFAC2FA2970
        public void set_iconId(){} // RVA: 0x7FFAC2FA2980
        public void get_rules(){} // RVA: 0x7FFAC2F8C2A0
        public void set_rules(){} // RVA: 0x7FFAC2F8C2B0
        public void get_initialRoleIds(){} // RVA: 0x7FFAC3331F50
        public void set_initialRoleIds(){} // RVA: 0x7FFAC34A4860
        public void get_isSystemGroup(){} // RVA: 0x7FFAC3C8B9C0
        public void set_isSystemGroup(){} // RVA: 0x7FFAC3C8DFF0
        public void get_isVerified(){} // RVA: 0x7FFAC45CA040
        public void set_isVerified(){} // RVA: 0x7FFAC45C9D10
        public void get_galleries(){} // RVA: 0x7FFAC36D1F40
        public void set_galleries(){} // RVA: 0x7FFAC3929BF0
        public void get_tags(){} // RVA: 0x7FFAC354B170
        public void set_tags(){} // RVA: 0x7FFAC39B3E10
        public void get_isSearchable(){} // RVA: 0x7FFACBEC2310
        public void set_isSearchable(){} // RVA: 0x7FFACBEC2320
        public void get_sizeQuality(){} // RVA: 0x7FFAC9AFAC70
        public void set_sizeQuality(){} // RVA: 0x7FFAC9AFAC80
        public void get_activityQuality(){} // RVA: 0x7FFAC8A11640
        public void set_activityQuality(){} // RVA: 0x7FFAC8A11650
        public void get_engagementQuality(){} // RVA: 0x7FFAC88D4E90
        public void set_engagementQuality(){} // RVA: 0x7FFAC88D4EA0
        public void get_contentQuality(){} // RVA: 0x7FFAC8A119F0
        public void set_contentQuality(){} // RVA: 0x7FFAC8A11A00
        public void get_roles(){} // RVA: 0x7FFAC3544340
        public void set_roles(){} // RVA: 0x7FFAC39A79B0
        public void get_links(){} // RVA: 0x7FFAC35422C0
        public void set_links(){} // RVA: 0x7FFAC36D84B0
        public void get_languages(){} // RVA: 0x7FFAC2F8C5F0
        public void set_languages(){} // RVA: 0x7FFAC2F8C600
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFAC2F8C660
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFAC8A33F90
        public void get_storeId(){} // RVA: 0x7FFAC354DFA0
        public void set_storeId(){} // RVA: 0x7FFAC39B99C0
        public void UpdateData(){} // RVA: 0x7FFACBF16650
        public void GetGroup(){} // RVA: 0x7FFACBF170C0
        public void FetchAllData(){} // RVA: 0x7FFACBF172C0
        public void RequestToJoin(){} // RVA: 0x7FFACBF17760
        public void LeaveGroup(){} // RVA: 0x7FFACBF17B20
        public void GetGroupInvites(){} // RVA: 0x7FFACBF17EA0
        public void InviteUser(){} // RVA: 0x7FFACBF18320
        public void BanUser(){} // RVA: 0x7FFACBF18750
        public void GetMembers(){} // RVA: 0x7FFACBF18B80
        public void GetGroupCapacity(){} // RVA: 0x7FFACBF19150
        public void SetRepresentation(){} // RVA: 0x7FFACBF19270
        public void GetGroupGalleryImages(){} // RVA: 0x7FFACBF19700
        public void GetGroupProducts(){} // RVA: 0x7FFACBF1A220
        public void GetGroupAnnouncements(){} // RVA: 0x7FFACBF1A660
        public void SetAnnouncementSubscription(){} // RVA: 0x7FFACBF1ABE0
        public void SetEventAnnouncementSubscription(){} // RVA: 0x7FFACBF1B040
        public void GetUsingShortCode(){} // RVA: 0x7FFACBF1B4A0
        public void StrictSearch(){} // RVA: 0x7FFACBF1B7C0
        public void GetActiveGroupInstances(){} // RVA: 0x7FFACBF1BC30
        public void GetRoles(){} // RVA: 0x7FFACBF1C090
        public void GetAllGroupPermissions(){} // RVA: 0x7FFACBF1C4B0
        public void GetGroupPermissions(){} // RVA: 0x7FFACBF1C7E0
        public void ExtractPermissions(){} // RVA: 0x7FFACBF1CC50
    }

    public class APIGroupAnnouncement : ApiModel
    {
        public string groupId; // 0x68
        public string authorId; // 0x70
        public string title; // 0x78
        public string text; // 0x80
        public string imageUrl; // 0x88
        public string visibility; // 0x90
        public System.DateTime createdAt; // 0x98
        public System.DateTime updatedAt; // 0xA0
        public System.Collections.Generic.List`1<string> roleIds; // 0xA8

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAC2F9CD50
        public void set_groupId(){} // RVA: 0x7FFAC2F9CD60
        public void get_authorId(){} // RVA: 0x7FFAC2FE9590
        public void set_authorId(){} // RVA: 0x7FFAC2FE95A0
        public void get_title(){} // RVA: 0x7FFAC30E5600
        public void set_title(){} // RVA: 0x7FFAC30E06F0
        public void get_text(){} // RVA: 0x7FFAC32EF410
        public void set_text(){} // RVA: 0x7FFAC34D4AA0
        public void get_imageUrl(){} // RVA: 0x7FFAC2F60010
        public void set_imageUrl(){} // RVA: 0x7FFAC354E300
        public void get_visibility(){} // RVA: 0x7FFAC32EF640
        public void set_visibility(){} // RVA: 0x7FFAC354E360
        public void get_createdAt(){} // RVA: 0x7FFAC354DFB0
        public void set_createdAt(){} // RVA: 0x7FFAC7E01AA0
        public void get_updatedAt(){} // RVA: 0x7FFAC3543900
        public void set_updatedAt(){} // RVA: 0x7FFAC878D950
        public void get_roleIds(){} // RVA: 0x7FFAC354B1A0
        public void set_roleIds(){} // RVA: 0x7FFAC334B370
        public void SetLastPostReadAt(){} // RVA: 0x7FFACBF1E740
        public void .ctor(){} // RVA: 0x7FFACBF1EB50
    }

    public class APIGroupInstance : ApiWorldInstance
    {
        // ── Methods ──
        public void BuildRequest(){} // RVA: 0x7FFACBF1EBF0
        public void .ctor(){} // RVA: 0x7FFACBF1EE30
    }

    public class APIGroupInvite : ApiModel
    {
        public string groupId; // 0x68
        public string userId; // 0x70
        public string state; // 0x78

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAC2F9CD50
        public void set_groupId(){} // RVA: 0x7FFAC2F9CD60
        public void get_userId(){} // RVA: 0x7FFAC2FE9590
        public void set_userId(){} // RVA: 0x7FFAC2FE95A0
        public void get_state(){} // RVA: 0x7FFAC30E5600
        public void set_state(){} // RVA: 0x7FFAC30E06F0
        public void CancelRequest(){} // RVA: 0x7FFACBF1E3B0
        public void .ctor(){} // RVA: 0x7FFACBF1E6A0
    }

    public class APIGroupJoinResponse : ApiModel
    {
        public string groupId; // 0x68
        public string userId; // 0x70
        public System.DateTime createdAt; // 0x78
        public bool isOnProfile; // 0x80
        public bool isOnNameplate; // 0x81
        public System.DateTime joinedAt; // 0x88
        public System.DateTime updatedAt; // 0x90
        public bool isActive; // 0x98
        public bool requestedJoin; // 0x99
        public string inviteId; // 0xA0

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAC2F9CD50
        public void set_groupId(){} // RVA: 0x7FFAC2F9CD60
        public void get_userId(){} // RVA: 0x7FFAC2FE9590
        public void set_userId(){} // RVA: 0x7FFAC2FE95A0
        public void get_createdAt(){} // RVA: 0x7FFAC30E5600
        public void set_createdAt(){} // RVA: 0x7FFAC8246500
        public void get_isOnProfile(){} // RVA: 0x7FFAC313E620
        public void set_isOnProfile(){} // RVA: 0x7FFAC313D3B0
        public void get_isOnNameplate(){} // RVA: 0x7FFAC313DE70
        public void set_isOnNameplate(){} // RVA: 0x7FFAC3143D90
        public void get_joinedAt(){} // RVA: 0x7FFAC2F60010
        public void set_joinedAt(){} // RVA: 0x7FFAC4A2BA70
        public void get_updatedAt(){} // RVA: 0x7FFAC32EF640
        public void set_updatedAt(){} // RVA: 0x7FFAC3705AA0
        public void get_isActive(){} // RVA: 0x7FFAC339A7F0
        public void set_isActive(){} // RVA: 0x7FFAC339FA20
        public void get_requestedJoin(){} // RVA: 0x7FFAC339C020
        public void set_requestedJoin(){} // RVA: 0x7FFAC8956680
        public void get_inviteId(){} // RVA: 0x7FFAC3543900
        public void set_inviteId(){} // RVA: 0x7FFAC354E420
        public void .ctor(){} // RVA: 0x7FFACBF1E360
    }

    public class APIGroupList : ApiModel
    {
        public string ownerId; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APIGroup> groups; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF1EFD0 | overloaded x2
    }

    public class APIGroupLocations : ApiModel
    {
        public System.DateTime fetchedAt; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.ApiWorldInstance> instances; // 0x70
        public System.Collections.Generic.Dictionary`2<string,System.Collections.Generic.IList`1<VRC.Core.ApiWorldInstance>> sortedLocations; // 0x78

        // ── Methods ──
        public void get_fetchedAt(){} // RVA: 0x7FFAC2F9CD50
        public void set_fetchedAt(){} // RVA: 0x7FFAC4A2BA80
        public void get_instances(){} // RVA: 0x7FFAC2FE9590
        public void set_instances(){} // RVA: 0x7FFAC2FE95A0
        public void GetLocations(){} // RVA: 0x7FFACBF1F0C0
        public void .ctor(){} // RVA: 0x7FFACBF1F400
    }

    public class APIGroupMember : ApiModel
    {
        public string groupId; // 0x68
        public string userId; // 0x70
        public System.Collections.Generic.List`1<string> roleIds; // 0x78
        public System.Collections.Generic.List`1<string> mRoleIds; // 0x80
        public System.Collections.Generic.List`1<string> permissions; // 0x88
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
        public System.DateTime joinedAt; // 0xF0
        public System.DateTime bannedAt; // 0xF8
        public System.DateTime lastPostReadAt; // 0x100
        public System.DateTime lastPostCreatedAt; // 0x108
        public VRC.Core.APIUser user; // 0x110
        public VRC.Core.APIGroup group; // 0x118

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF1F8B0
        public void get_groupId(){} // RVA: 0x7FFAC2F9CD50
        public void set_groupId(){} // RVA: 0x7FFAC2F9CD60
        public void get_userId(){} // RVA: 0x7FFAC2FE9590
        public void set_userId(){} // RVA: 0x7FFAC2FE95A0
        public void get_roleIds(){} // RVA: 0x7FFAC30E5600
        public void set_roleIds(){} // RVA: 0x7FFAC30E06F0
        public void get_mRoleIds(){} // RVA: 0x7FFAC32EF410
        public void set_mRoleIds(){} // RVA: 0x7FFAC34D4AA0
        public void get_permissions(){} // RVA: 0x7FFAC2F60010
        public void set_permissions(){} // RVA: 0x7FFAC354E300
        public void get_memberVisibility(){} // RVA: 0x7FFAC32EF640
        public void set_memberVisibility(){} // RVA: 0x7FFAC354E360
        public void get_membershipStatus(){} // RVA: 0x7FFAC354DFB0
        public void set_membershipStatus(){} // RVA: 0x7FFAC354E3C0
        public void get_isRepresenting(){} // RVA: 0x7FFAC45C9D50
        public void set_isRepresenting(){} // RVA: 0x7FFAC37B1910
        public void get_mutualGroup(){} // RVA: 0x7FFAC4848B60
        public void set_mutualGroup(){} // RVA: 0x7FFAC4848B70
        public void get_name(){} // RVA: 0x7FFAC354B1A0
        public void set_name(){} // RVA: 0x7FFAC334B370
        public void get_ownerId(){} // RVA: 0x7FFAC2F8C040
        public void set_ownerId(){} // RVA: 0x7FFAC2F8C050
        public void get_shortCode(){} // RVA: 0x7FFAC2F8C0B0
        public void set_shortCode(){} // RVA: 0x7FFAC2F8C0C0
        public void get_discriminator(){} // RVA: 0x7FFAC2F8C120
        public void set_discriminator(){} // RVA: 0x7FFAC2F8C130
        public void get_iconUrl(){} // RVA: 0x7FFAC3079460
        public void set_iconUrl(){} // RVA: 0x7FFAC3079470
        public void get_bannerUrl(){} // RVA: 0x7FFAC303E100
        public void set_bannerUrl(){} // RVA: 0x7FFAC303E110
        public void get_privacy(){} // RVA: 0x7FFAC3540F70
        public void set_privacy(){} // RVA: 0x7FFAC2FA28A0
        public void get_visibility(){} // RVA: 0x7FFAC2FA2900
        public void set_visibility(){} // RVA: 0x7FFAC2FA2910
        public void get_isSubscribedToAnnouncements(){} // RVA: 0x7FFAC3FD4640
        public void set_isSubscribedToAnnouncements(){} // RVA: 0x7FFAC499C5B0
        public void get_isSubscribedToEventAnnouncements(){} // RVA: 0x7FFAC8E42E60
        public void set_isSubscribedToEventAnnouncements(){} // RVA: 0x7FFACBEC7A40
        public void get_memberCount(){} // RVA: 0x7FFAC47D3260
        public void set_memberCount(){} // RVA: 0x7FFAC8A11620
        public void get_joinedAt(){} // RVA: 0x7FFAC2F8C2A0
        public void set_joinedAt(){} // RVA: 0x7FFAC47467B0
        public void get_bannedAt(){} // RVA: 0x7FFAC3331F50
        public void set_bannedAt(){} // RVA: 0x7FFAC6715870
        public void get_lastPostReadAt(){} // RVA: 0x7FFAC34F6C80
        public void set_lastPostReadAt(){} // RVA: 0x7FFAC4196020
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFAC36D1F40
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFACBE64CE0
        public void get_user(){} // RVA: 0x7FFAC354B170
        public void set_user(){} // RVA: 0x7FFAC39B3E10
        public void get_group(){} // RVA: 0x7FFAC33BC6D0
        public void set_group(){} // RVA: 0x7FFAC33B8580
        public void GetMemberships(){} // RVA: 0x7FFACBF1F910
        public void SetVisibility(){} // RVA: 0x7FFACBF1FCF0
        public void FetchGroup(){} // RVA: 0x7FFACBF201B0
        public void GetRepresentation(){} // RVA: 0x7FFACBF20500
    }

    public class APIGroupMemberList : ApiModel
    {
        public string groupId; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APIGroupMember> members; // 0x70

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAC2F9CD50
        public void set_groupId(){} // RVA: 0x7FFAC2F9CD60
        public void get_members(){} // RVA: 0x7FFAC2FE9590
        public void set_members(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBF20C90 | overloaded x2
    }

    public class APIGroupPosts : ApiModel
    {
        public int total; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APIGroupAnnouncement> posts; // 0x70

        // ── Methods ──
        public void get_total(){} // RVA: 0x7FFAC47BAB50
        public void set_total(){} // RVA: 0x7FFAC47BAB60
        public void get_posts(){} // RVA: 0x7FFAC2FE9590
        public void set_posts(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBF1E6F0
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
        public System.DateTime createdAt; // 0x88
        public System.DateTime updatedAt; // 0x90
        public bool defaultRole; // 0x98
        public int order; // 0x9C
        public System.Collections.Generic.List`1<string> permissions; // 0xA0

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAC2F9CD50
        public void set_groupId(){} // RVA: 0x7FFAC2F9CD60
        public void get_name(){} // RVA: 0x7FFAC2FE9590
        public void set_name(){} // RVA: 0x7FFAC2FE95A0
        public void get_description(){} // RVA: 0x7FFAC30E5600
        public void set_description(){} // RVA: 0x7FFAC30E06F0
        public void get_isSelfAssignable(){} // RVA: 0x7FFAC313E620
        public void set_isSelfAssignable(){} // RVA: 0x7FFAC313D3B0
        public void get_requiresTwoFactor(){} // RVA: 0x7FFAC313DE70
        public void set_requiresTwoFactor(){} // RVA: 0x7FFAC3143D90
        public void get_isManagementRole(){} // RVA: 0x7FFAC3BDEE90
        public void set_isManagementRole(){} // RVA: 0x7FFAC8730670
        public void get_requiresPurchase(){} // RVA: 0x7FFAC3FA38F0
        public void set_requiresPurchase(){} // RVA: 0x7FFAC878D710
        public void get_createdAt(){} // RVA: 0x7FFAC2F60010
        public void set_createdAt(){} // RVA: 0x7FFAC4A2BA70
        public void get_updatedAt(){} // RVA: 0x7FFAC32EF640
        public void set_updatedAt(){} // RVA: 0x7FFAC3705AA0
        public void get_defaultRole(){} // RVA: 0x7FFAC339A7F0
        public void set_defaultRole(){} // RVA: 0x7FFAC339FA20
        public void get_order(){} // RVA: 0x7FFAC489E520
        public void set_order(){} // RVA: 0x7FFAC489EAA0
        public void get_permissions(){} // RVA: 0x7FFAC3543900
        public void set_permissions(){} // RVA: 0x7FFAC354E420
        public void .ctor(){} // RVA: 0x7FFACBF20DF0 | overloaded x2
    }

    public class APIGroupRoleList : ApiModel
    {
        public string groupId; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APIGroupRole> roles; // 0x70

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFAC2F9CD50
        public void set_groupId(){} // RVA: 0x7FFAC2F9CD60
        public void get_roles(){} // RVA: 0x7FFAC2FE9590
        public void set_roles(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBF21100 | overloaded x2
    }

    public class APIProductGifting : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class APIProductGiftingCheck : ApiModel
    {
        public bool Eligible; // 0x68
        public string Reason; // 0x70
        public System.Collections.Generic.List`1<string> EligibleProducts; // 0x78
        public System.Collections.Generic.List`1<string> IneligibleProducts; // 0x80

        // ── Methods ──
        public void get_Eligible(){} // RVA: 0x7FFAC2FE9570
        public void set_Eligible(){} // RVA: 0x7FFAC2FE9580
        public void get_Reason(){} // RVA: 0x7FFAC2FE9590
        public void set_Reason(){} // RVA: 0x7FFAC2FE95A0
        public void get_EligibleProducts(){} // RVA: 0x7FFAC30E5600
        public void set_EligibleProducts(){} // RVA: 0x7FFAC30E06F0
        public void get_IneligibleProducts(){} // RVA: 0x7FFAC32EF410
        public void set_IneligibleProducts(){} // RVA: 0x7FFAC34D4AA0
        public void Check(){} // RVA: 0x7FFACBEC58D0
        public void .ctor(){} // RVA: 0x7FFACBEC5EA0
    }

    public class APIPurchasedGiftBundle : ApiModel
    {
        public string transactionId; // 0x68
        public string store; // 0x70
        public string steamItemId; // 0x78
        public string oculusSku; // 0x80
        public string googleProductId; // 0x88
        public string googlePlanId; // 0x90
        public string picoSku; // 0x98
        public int amount; // 0xA0
        public string description; // 0xA8
        public string period; // 0xB0
        public bool consumed; // 0xB8
        public string status; // 0xC0
        public string created_at; // 0xC8
        public string updated_at; // 0xD0
        public bool isBulkGift; // 0xD8
        public string[] targets; // 0xE0
        public int bulkSize; // 0xE8
        public int discountPercentage; // 0xEC
        public int totalConsumed; // 0xF0
        public int totalUnconsumed; // 0xF4
        public int failures; // 0xF8

        // ── Methods ──
        public void get_transactionId(){} // RVA: 0x7FFAC2F9CD50
        public void set_transactionId(){} // RVA: 0x7FFAC2F9CD60
        public void get_store(){} // RVA: 0x7FFAC2FE9590
        public void set_store(){} // RVA: 0x7FFAC2FE95A0
        public void get_steamItemId(){} // RVA: 0x7FFAC30E5600
        public void set_steamItemId(){} // RVA: 0x7FFAC30E06F0
        public void get_oculusSku(){} // RVA: 0x7FFAC32EF410
        public void set_oculusSku(){} // RVA: 0x7FFAC34D4AA0
        public void get_googleProductId(){} // RVA: 0x7FFAC2F60010
        public void set_googleProductId(){} // RVA: 0x7FFAC354E300
        public void get_googlePlanId(){} // RVA: 0x7FFAC32EF640
        public void set_googlePlanId(){} // RVA: 0x7FFAC354E360
        public void get_picoSku(){} // RVA: 0x7FFAC354DFB0
        public void set_picoSku(){} // RVA: 0x7FFAC354E3C0
        public void get_amount(){} // RVA: 0x7FFAC489E510
        public void set_amount(){} // RVA: 0x7FFAC489E550
        public void get_description(){} // RVA: 0x7FFAC354B1A0
        public void set_description(){} // RVA: 0x7FFAC334B370
        public void get_period(){} // RVA: 0x7FFAC2F8C040
        public void set_period(){} // RVA: 0x7FFAC2F8C050
        public void get_consumed(){} // RVA: 0x7FFAC41F1470
        public void set_consumed(){} // RVA: 0x7FFAC41EEB20
        public void get_status(){} // RVA: 0x7FFAC2F8C120
        public void set_status(){} // RVA: 0x7FFAC2F8C130
        public void get_created_at(){} // RVA: 0x7FFAC3079460
        public void set_created_at(){} // RVA: 0x7FFAC3079470
        public void get_updated_at(){} // RVA: 0x7FFAC303E100
        public void set_updated_at(){} // RVA: 0x7FFAC303E110
        public void get_isBulkGift(){} // RVA: 0x7FFAC3DBD9E0
        public void set_isBulkGift(){} // RVA: 0x7FFAC88C7210
        public void get_targets(){} // RVA: 0x7FFAC2FA2900
        public void set_targets(){} // RVA: 0x7FFAC2FA2910
        public void get_bulkSize(){} // RVA: 0x7FFAC47D5FE0
        public void set_bulkSize(){} // RVA: 0x7FFAC8A11760
        public void get_discountPercentage(){} // RVA: 0x7FFAC47D3260
        public void set_discountPercentage(){} // RVA: 0x7FFAC8A11620
        public void get_totalConsumed(){} // RVA: 0x7FFAC60855D0
        public void set_totalConsumed(){} // RVA: 0x7FFAC8A11630
        public void get_totalUnconsumed(){} // RVA: 0x7FFAC6715830
        public void set_totalUnconsumed(){} // RVA: 0x7FFAC6715840
        public void get_failures(){} // RVA: 0x7FFAC3E69BA0
        public void set_failures(){} // RVA: 0x7FFAC3E69950
        public void .ctor(){} // RVA: 0x7FFACBE775E0
    }

    public class APIQueue : Object
    {
        public VRC.Core.ApiWorldInstance queueInstance; // 0x10

        // ── Methods ──
        public void JoinQueue(){} // RVA: 0x7FFACBECB1B0
        public void SetQueue(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void LeaveQueue(){} // RVA: 0x7FFACBECB620
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class APIResponseHandler : Object
    {
        public Unity.Profiling.ProfilerMarker _connectionTimedOutProfilerMarker;
        public Unity.Profiling.ProfilerMarker _responseTimedOutProfilerMarker; // 0x8
        public Unity.Profiling.ProfilerMarker _abortedProfilerMarker; // 0x10
        public Unity.Profiling.ProfilerMarker _errorProfilerMarker; // 0x18
        public System.Threading.SemaphoreSlim _offMainResponseSemaphore; // 0x20

        // ── Methods ──
        public void HandleResponse(){} // RVA: 0x7FFACBECE750
        public void extractResponseErrorMessage(){} // RVA: 0x7FFACBECE980
        public void RetryRequest(){} // RVA: 0x7FFACBECEAF0
        public void .cctor(){} // RVA: 0x7FFACBECF260
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
        public void get_fileId(){} // RVA: 0x7FFAC2F9CD50
        public void set_fileId(){} // RVA: 0x7FFAC2F9CD60
        public void get_imageUrl(){} // RVA: 0x7FFAC2FE9590
        public void set_imageUrl(){} // RVA: 0x7FFAC2FE95A0
        public void get_specialEffect(){} // RVA: 0x7FFAC30E5600
        public void set_specialEffect(){} // RVA: 0x7FFAC30E06F0
        public void get_animationStyle(){} // RVA: 0x7FFAC32EF410
        public void set_animationStyle(){} // RVA: 0x7FFAC34D4AA0
        public void get_maskTag(){} // RVA: 0x7FFAC2F60010
        public void set_maskTag(){} // RVA: 0x7FFAC354E300
        public void get_animated(){} // RVA: 0x7FFAC3E0D160
        public void set_animated(){} // RVA: 0x7FFAC3E089B0
        public void get_frames(){} // RVA: 0x7FFAC3220670
        public void set_frames(){} // RVA: 0x7FFAC342B670
        public void get_framesOverTime(){} // RVA: 0x7FFAC489E530
        public void set_framesOverTime(){} // RVA: 0x7FFAC489E540
        public void get_loopStyle(){} // RVA: 0x7FFAC3543900
        public void set_loopStyle(){} // RVA: 0x7FFAC354E420
        public void get_assetBundleId(){} // RVA: 0x7FFAC354B1A0
        public void set_assetBundleId(){} // RVA: 0x7FFAC334B370
        public void UploadSticker(){} // RVA: 0x7FFACBED2FD0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFACBED35E0
    }

    public class APISubscription : ApiModel
    {
        public System.Collections.Generic.Dictionary`2<string,object> response; // 0x68

        // ── Methods ──
        public void get_response(){} // RVA: 0x7FFAC2F9CD50
        public void set_response(){} // RVA: 0x7FFAC2F9CD60
        public void .ctor(){} // RVA: 0x7FFACBED3790
    }

    public class APITutorial : ApiModel
    {
        public string IsTutorialCompleted;
        public bool CompletedAnyTutorial; // 0x68
        public bool TutorialKey; // 0x69
        public string <TutorialKey>k__BackingField; // 0x70

        // ── Methods ──
        public void get_IsTutorialCompleted(){} // RVA: 0x7FFAC2FE9570
        public void set_IsTutorialCompleted(){} // RVA: 0x7FFAC2FE9580
        public void get_CompletedAnyTutorial(){} // RVA: 0x7FFAC4670BD0
        public void set_CompletedAnyTutorial(){} // RVA: 0x7FFAC466E010
        public void get_TutorialKey(){} // RVA: 0x7FFAC2FE9590
        public void set_TutorialKey(){} // RVA: 0x7FFAC2FE95A0
        public void LoadTutorial(){} // RVA: 0x7FFACBED60C0
        public void .ctor(){} // RVA: 0x7FFACBED63D0
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
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.APIUIColorPalette> _fakeApi;

        // ── Methods ──
        public void get_ownerId(){} // RVA: 0x7FFAC2F9CD50
        public void set_ownerId(){} // RVA: 0x7FFAC2F9CD60
        public void get_name(){} // RVA: 0x7FFAC2FE9590
        public void set_name(){} // RVA: 0x7FFAC2FE95A0
        public void get_highlights(){} // RVA: 0x7FFAC30E5600
        public void set_highlights(){} // RVA: 0x7FFAC30E06F0
        public void get_icons(){} // RVA: 0x7FFAC32EF410
        public void set_icons(){} // RVA: 0x7FFAC34D4AA0
        public void get_buttons(){} // RVA: 0x7FFAC2F60010
        public void set_buttons(){} // RVA: 0x7FFAC354E300
        public void get_backgrounds(){} // RVA: 0x7FFAC32EF640
        public void set_backgrounds(){} // RVA: 0x7FFAC354E360
        public void get_text(){} // RVA: 0x7FFAC354DFB0
        public void set_text(){} // RVA: 0x7FFAC354E3C0
        public void get_subtext(){} // RVA: 0x7FFAC3543900
        public void set_subtext(){} // RVA: 0x7FFAC354E420
        public void Fetch(){} // RVA: 0x7FFACBED6570
        public void Save(){} // RVA: 0x7FFACBED6920
        public void GetCurrent(){} // RVA: 0x7FFACBED7200
        public void SetCurrent(){} // RVA: 0x7FFACBED74E0
        public void Update(){} // RVA: 0x7FFACBED78D0
        public void .ctor(){} // RVA: 0x7FFACBED7C10
        public void .cctor(){} // RVA: 0x7FFACBED7C60
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
        public System.Collections.Generic.List`1<string> events; // 0x90
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
        public 0x6B0B24A8 currentAvatarAssetUrl; // 0xE0
        public System.Collections.Generic.List`1<VRC.Core.VRCEvent> steamDetails; // 0xE8
        public int travelingToLocation; // 0xF0
        public string obfuscatedEmail; // 0xF8
        public int unsubscribe; // 0x100
        public int hasLoggedInFromClient; // 0x104
        public string pastDisplayNames; // 0x108
        public string homeLocation; // 0x110
        public System.Collections.Generic.List`1<string> tags; // 0x118
        public string status; // 0x120
        public bool statusDescription; // 0x128
        public bool badges; // 0x129
        public string statusHistory; // 0x130
        public System.Collections.Generic.List`1<string> state; // 0x138
        public string allowAvatarCopying; // 0x140
        public System.Collections.Generic.Dictionary`2<string,object> hasSharedConnectionsOptOut; // 0x148
        public string hasDiscordFriendsOptOut; // 0x150
        public string userIcon; // 0x158
        public bool profilePicOverride; // 0x160
        public bool note; // 0x161
        public System.Collections.Generic.List`1<string> iconUrl; // 0x168
        public string thumbnailUrl; // 0x170
        public System.Collections.Generic.List`1<string> hideContentFilterSettings; // 0x178
        public string contentFilters; // 0x180
        public string userLanguageCode; // 0x188
        public System.Collections.Generic.List`1<VRC.Core.ApiBadge> ageVerified; // 0x190
        public System.Collections.Generic.List`1<string> isAdult; // 0x198
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
        public System.Collections.Generic.List`1<string> LanguagesShortNames; // 0x1E0
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
        public System.Collections.Generic.Dictionary`2<string,object> canPublishWorldsAndAvatars; // 0x230
        public System.Collections.Generic.Dictionary`2<string,string> canPublishAllContent;
        public System.Collections.Generic.List`1<string> canPublishAvatars; // 0x238
        public System.Collections.Generic.List`1<string> canPublishWorlds; // 0x240
        public System.Collections.Hashtable canPublishProps; // 0x8
        public VRC.Core.APIUser isUntrusted; // 0x10

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFACBED7F60
        public void GetLifeSpan(){} // RVA: 0x7FFAC3E7E010
        public void get_blob(){} // RVA: 0x7FFAC2F9CD50
        public void set_blob(){} // RVA: 0x7FFAC2F9CD60
        public void get_displayName(){} // RVA: 0x7FFAC2FE9590
        public void set_displayName(){} // RVA: 0x7FFAC2FE95A0
        public void get_username(){} // RVA: 0x7FFAC30E5600
        public void set_username(){} // RVA: 0x7FFAC30E06F0
        public void get_pronouns(){} // RVA: 0x7FFAC32EF410
        public void set_pronouns(){} // RVA: 0x7FFAC34D4AA0
        public void get_bio(){} // RVA: 0x7FFAC2F60010
        public void set_bio(){} // RVA: 0x7FFAC354E300
        public void get_bioLinks(){} // RVA: 0x7FFAC32EF640
        public void set_bioLinks(){} // RVA: 0x7FFAC354E360
        public void get_location(){} // RVA: 0x7FFAC354DFB0
        public void set_location(){} // RVA: 0x7FFAC354E3C0
        public void get_avatarId(){} // RVA: 0x7FFAC3543900
        public void set_avatarId(){} // RVA: 0x7FFAC354E420
        public void get_fallbackId(){} // RVA: 0x7FFAC354B1A0
        public void set_fallbackId(){} // RVA: 0x7FFAC334B370
        public void get_hasEmail(){} // RVA: 0x7FFAC41E71E0
        public void set_hasEmail(){} // RVA: 0x7FFAC41E6D30
        public void get_isBoopingEnabled(){} // RVA: 0x7FFAC65394B0
        public void set_isBoopingEnabled(){} // RVA: 0x7FFAC65394C0
        public void get_hasBirthday(){} // RVA: 0x7FFAC893FD30
        public void set_hasBirthday(){} // RVA: 0x7FFAC893FD40
        public void get_isFriend(){} // RVA: 0x7FFAC893FD50
        public void set_isFriend(){} // RVA: 0x7FFAC893FD60
        public void get_friendKey(){} // RVA: 0x7FFAC2F8C0B0
        public void set_friendKey(){} // RVA: 0x7FFAC2F8C0C0
        public void get_friendRequestStatus(){} // RVA: 0x7FFAC2F8C120
        public void set_friendRequestStatus(){} // RVA: 0x7FFAC2F8C130
        public void get_last_login(){} // RVA: 0x7FFAC3079460
        public void set_last_login(){} // RVA: 0x7FFAC3079470
        public void get_last_activity(){} // RVA: 0x7FFAC303E100
        public void set_last_activity(){} // RVA: 0x7FFAC303E110
        public void get_date_joined(){} // RVA: 0x7FFAC3540F70
        public void set_date_joined(){} // RVA: 0x7FFAC2FA28A0
        public void get_developerType(){} // RVA: 0x7FFAC4837F50
        public void set_developerType(){} // RVA: 0x7FFAC4837F60
        public void get_events(){} // RVA: 0x7FFAC2FA2970
        public void set_events(){} // RVA: 0x7FFAC2FA2980
        public void get_acceptedTOSVersion(){} // RVA: 0x7FFAC60855D0
        public void set_acceptedTOSVersion(){} // RVA: 0x7FFAC8A11630
        public void get_queuedInstance(){} // RVA: 0x7FFAC3331F50
        public void set_queuedInstance(){} // RVA: 0x7FFAC34A4860
        public void get_queuedInstancePosition(){} // RVA: 0x7FFAC8C068C0
        public void set_queuedInstancePosition(){} // RVA: 0x7FFAC9C7A8E0
        public void get_acceptedPrivacyVersion(){} // RVA: 0x7FFAC47B0110
        public void set_acceptedPrivacyVersion(){} // RVA: 0x7FFAC451E020
        public void get_currentAvatarImageUrl(){} // RVA: 0x7FFAC36D1F40
        public void set_currentAvatarImageUrl(){} // RVA: 0x7FFAC3929BF0
        public void get_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFAC354B170
        public void set_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFAC39B3E10
        public void get_currentAvatarTags(){} // RVA: 0x7FFAC33BC6D0
        public void set_currentAvatarTags(){} // RVA: 0x7FFAC33B8580
        public void get_authToken(){} // RVA: 0x7FFAC313CBB0
        public void set_authToken(){} // RVA: 0x7FFAC3143400
        public void get_emailVerified(){} // RVA: 0x7FFAC3331A00
        public void set_emailVerified(){} // RVA: 0x7FFAC332DA60
        public void get_hasPendingEmail(){} // RVA: 0x7FFACBED7FC0
        public void set_hasPendingEmail(){} // RVA: 0x7FFACBED7FD0
        public void get_obfuscatedPendingEmail(){} // RVA: 0x7FFAC3544340
        public void set_obfuscatedPendingEmail(){} // RVA: 0x7FFAC39A79B0
        public void get_friendIDs(){} // RVA: 0x7FFAC35422C0
        public void set_friendIDs(){} // RVA: 0x7FFAC36D84B0
        public void get_currentAvatarAssetUrl(){} // RVA: 0x7FFAC2F8C5F0
        public void set_currentAvatarAssetUrl(){} // RVA: 0x7FFAC2F8C600
        public void get_steamDetails(){} // RVA: 0x7FFAC2F8C660
        public void set_steamDetails(){} // RVA: 0x7FFAC2F8C670
        public void get_travelingToLocation(){} // RVA: 0x7FFAC354DFA0
        public void set_travelingToLocation(){} // RVA: 0x7FFAC39B99C0
        public void get_obfuscatedEmail(){} // RVA: 0x7FFAC3542410
        public void set_obfuscatedEmail(){} // RVA: 0x7FFAC39A74B0
        public void get_unsubscribe(){} // RVA: 0x7FFAC8A119B0
        public void set_unsubscribe(){} // RVA: 0x7FFAC8A119C0
        public void get_hasLoggedInFromClient(){} // RVA: 0x7FFAC8A119D0
        public void set_hasLoggedInFromClient(){} // RVA: 0x7FFAC8A119E0
        public void get_pastDisplayNames(){} // RVA: 0x7FFAC354E2F0
        public void set_pastDisplayNames(){} // RVA: 0x7FFAC39A80B0
        public void get_homeLocation(){} // RVA: 0x7FFAC336D850
        public void set_homeLocation(){} // RVA: 0x7FFAC39B5DB0
        public void get_tags(){} // RVA: 0x7FFAC336D860
        public void set_tags(){} // RVA: 0x7FFACBED7FE0
        public void get_status(){} // RVA: 0x7FFAC354B1B0
        public void set_status(){} // RVA: 0x7FFAC3503070
        public void get_statusDescription(){} // RVA: 0x7FFAC35410C0
        public void set_statusDescription(){} // RVA: 0x7FFAC3503010
        public void get_badges(){} // RVA: 0x7FFAC3540F60
        public void set_badges(){} // RVA: 0x7FFAC39AB1D0
        public void get_statusHistory(){} // RVA: 0x7FFAC3541C80
        public void set_statusHistory(){} // RVA: 0x7FFAC39C8ED0
        public void get_state(){} // RVA: 0x7FFAC354E2E0
        public void set_state(){} // RVA: 0x7FFAC39A8AF0
        public void get_allowAvatarCopying(){} // RVA: 0x7FFAC8C69570
        public void set_allowAvatarCopying(){} // RVA: 0x7FFAC8C69580
        public void get_hasSharedConnectionsOptOut(){} // RVA: 0x7FFAC8C69590
        public void set_hasSharedConnectionsOptOut(){} // RVA: 0x7FFAC8C695A0
        public void get_hasDiscordFriendsOptOut(){} // RVA: 0x7FFAC8C695F0
        public void set_hasDiscordFriendsOptOut(){} // RVA: 0x7FFAC8C69600
        public void get_userIcon(){} // RVA: 0x7FFAC3549F30
        public void set_userIcon(){} // RVA: 0x7FFAC39A7790
        public void get_profilePicOverride(){} // RVA: 0x7FFAC3544330
        public void set_profilePicOverride(){} // RVA: 0x7FFAC39AC050
        public void get_note(){} // RVA: 0x7FFAC35422B0
        public void set_note(){} // RVA: 0x7FFAC39AD110
        public void get_iconUrl(){} // RVA: 0x7FFAC39CCB10
        public void set_iconUrl(){} // RVA: 0x7FFAC39CF3F0
        public void get_thumbnailUrl(){} // RVA: 0x7FFAC39C1920
        public void set_thumbnailUrl(){} // RVA: 0x7FFAC39A8050
        public void get_hideContentFilterSettings(){} // RVA: 0x7FFAC47C42D0
        public void set_hideContentFilterSettings(){} // RVA: 0x7FFAC47C42E0
        public void get_contentFilters(){} // RVA: 0x7FFAC33F8150
        public void set_contentFilters(){} // RVA: 0x7FFAC39B1270
        public void get_userLanguageCode(){} // RVA: 0x7FFAC39B1060
        public void set_userLanguageCode(){} // RVA: 0x7FFAC39AC5A0
        public void get_ageVerified(){} // RVA: 0x7FFAC8C6C140
        public void set_ageVerified(){} // RVA: 0x7FFACBED8050
        public void get_isAdult(){} // RVA: 0x7FFACBED8060
        public void set_isAdult(){} // RVA: 0x7FFACBED8070
        public void get_ageVerificationStatus(){} // RVA: 0x7FFAC3541460
        public void set_ageVerificationStatus(){} // RVA: 0x7FFAC3544450
        public void get_discordId(){} // RVA: 0x7FFAC3544790
        public void set_discordId(){} // RVA: 0x7FFAC354D230
        public void get_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x7FFAC8C44960
        public void set_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x7FFACBED8080
        public void get_last_platform(){} // RVA: 0x7FFAC354BCB0
        public void set_last_platform(){} // RVA: 0x7FFACBED8090
        public void get_platform(){} // RVA: 0x7FFAC3541470
        public void set_platform(){} // RVA: 0x7FFAC3542420
        public void get_last_mobile(){} // RVA: 0x7FFAC35493F0
        public void set_last_mobile(){} // RVA: 0x7FFAC354AC80
        public void get_twoFactorAuthEnabled(){} // RVA: 0x7FFAC90ADC00
        public void set_twoFactorAuthEnabled(){} // RVA: 0x7FFACBED8210
        public void get_twoFactorAuthMethods(){} // RVA: 0x7FFAC3542820
        public void set_twoFactorAuthMethods(){} // RVA: 0x7FFAC39C7D40
        public void get_LanguageTagsDictionary(){} // RVA: 0x7FFACBED8220
        public void get_languagesDisplayNames(){} // RVA: 0x7FFAC35413D0
        public void set_languagesDisplayNames(){} // RVA: 0x7FFAC39AA7F0
        public void set_LanguagesShortNames(){} // RVA: 0x7FFAC39B5A80
        public void get_LanguagesShortNames(){} // RVA: 0x7FFAC39C9150
        public void SetUserLanguages(){} // RVA: 0x7FFACBED86B0
        public void get_ShouldSeeInstanceByStatus(){} // RVA: 0x7FFACBED8A70
        public void get_IsOnMobile(){} // RVA: 0x7FFACBED8AB0
        public void get_profilePicImageUrl(){} // RVA: 0x7FFACBED8AD0
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x7FFACBED8AF0
        public void FetchBalance(){} // RVA: 0x7FFACBED8B10
        public void get_IsAccountVerified(){} // RVA: 0x7FFAC3006850
        public void get_hasNoPowers(){} // RVA: 0x7FFACBED8EA0
        public void get_hasScriptingAccess(){} // RVA: 0x7FFACBED8EF0
        public void get_hasModerationPowers(){} // RVA: 0x7FFACBED8FF0
        public void get_hasVIPAccess(){} // RVA: 0x7FFACBED90B0
        public void get_hasSuperPowers(){} // RVA: 0x7FFACBED9100
        public void get_canPublishWorldsAndAvatars(){} // RVA: 0x7FFACBED9150
        public void get_canPublishAllContent(){} // RVA: 0x7FFACBED9370
        public void get_canPublishAvatars(){} // RVA: 0x7FFACBED94A0
        public void get_canPublishWorlds(){} // RVA: 0x7FFACBED95C0
        public void get_canPublishProps(){} // RVA: 0x7FFACBED96E0
        public void get_isUntrusted(){} // RVA: 0x7FFACBED9800
        public void get_isNewUser(){} // RVA: 0x7FFACBED9860
        public void get_isEarlyAdopter(){} // RVA: 0x7FFACBED9920
        public void get_isSupporter(){} // RVA: 0x7FFACBED99E0
        public void get_hasBasicTrustLevel(){} // RVA: 0x7FFACBED9AA0
        public void get_hasKnownTrustLevel(){} // RVA: 0x7FFACBED9B70
        public void get_hasTrustedTrustLevel(){} // RVA: 0x7FFACBED9C40
        public void get_hasVeteranTrustLevel(){} // RVA: 0x7FFACBED9D10
        public void get_hasLegendTrustLevel(){} // RVA: 0x7FFACBED9DE0
        public void get_hasNegativeTrustLevel(){} // RVA: 0x7FFACBED9EB0
        public void get_hasVeryNegativeTrustLevel(){} // RVA: 0x7FFACBED9F80
        public void get_hasFeedbackAccess(){} // RVA: 0x7FFACBEDA040
        public void get_showSocialRank(){} // RVA: 0x7FFACBEDA100
        public void get_showModTag(){} // RVA: 0x7FFACBEDA1A0
        public void get_canSetStatusOffline(){} // RVA: 0x7FFACBEDA240
        public void get_statusIsSetToOffline(){} // RVA: 0x7FFACBEDA2A0
        public void get_statusIsSetToJoinMe(){} // RVA: 0x7FFACBEDA3D0
        public void get_statusIsSetToAskMe(){} // RVA: 0x7FFACBEDA470
        public void get_statusIsSetToDoNotDisturb(){} // RVA: 0x7FFACBEDA5A0
        public void get_statusDefaultDescriptionDisplayString(){} // RVA: 0x7FFACBEDA6D0
        public void truncatedBio(){} // RVA: 0x7FFACBEDA860
        public void truncatedStatusDescription(){} // RVA: 0x7FFACBEDA8D0
        public void get_statusDescriptionDisplayString(){} // RVA: 0x7FFACBEDA940
        public void get_statusValue(){} // RVA: 0x7FFACBEDAA00
        public void get_CurrentLocation(){} // RVA: 0x7FFACBEDAA70
        public void get_canSeeAllUsersStatus(){} // RVA: 0x7FFACBEDADD0
        public void MergeFieldsInto(){} // RVA: 0x7FFACBEDAE30
        public void get_IsLoggedIn(){} // RVA: 0x7FFACBEDB6B0
        public void get_IsSelf(){} // RVA: 0x7FFACBEDB740
        public void get_CurrentUser(){} // RVA: 0x7FFACBEDB890
        public void set_CurrentUser(){} // RVA: 0x7FFACBEDB8F0
        public void .ctor(){} // RVA: 0x7FFACBEDBC20 | overloaded x2
        public void ReadField(){} // RVA: 0x7FFACBEDC9D0
        public void WriteField(){} // RVA: 0x7FFACBEDCA80
        public void InitialFetchCurrentUser(){} // RVA: 0x7FFACBEDCC10
        public void Register(){} // RVA: 0x7FFACBEDD030
        public void UpdateAccountInfo(){} // RVA: 0x7FFACBEDDA60
        public void Login(){} // RVA: 0x7FFACBEDE530
        public void VerifyTwoFactorAuthCode(){} // RVA: 0x7FFACBEDEA20
        public void VerifyStepUpAuthCode(){} // RVA: 0x7FFACBEDF010
        public void ThirdPartyLogin(){} // RVA: 0x7FFACBEDFB90
        public void DiscordLogin(){} // RVA: 0x7FFACBEDFFA0
        public void DiscordFinalizeLogin(){} // RVA: 0x7FFACBEE0570
        public void DiscordLinkStatus(){} // RVA: 0x7FFACBEE1060
        public void DiscordUnlink(){} // RVA: 0x7FFACBEE1550
        public void DiscordAccess(){} // RVA: 0x7FFACBEE1890
        public void RedeemPromo(){} // RVA: 0x7FFACBEE1BD0
        public void Logout(){} // RVA: 0x7FFACBEE1FC0
        public void FetchPublishWorldsInformation(){} // RVA: 0x7FFACBEE2110
        public void FetchUsers(){} // RVA: 0x7FFACBEE2E30 | overloaded x2
        public void FetchUser(){} // RVA: 0x7FFACBEE2AC0
        public void FetchUsersSearchResults(){} // RVA: 0x7FFACBEE3210
        public void FetchFriends(){} // RVA: 0x7FFACBEE3620
        public void AttemptVerification(){} // RVA: 0x7FFACBEE4090
        public void TagsToDeveloperType(){} // RVA: 0x7FFACBEE4150
        public void SetIsBoopingEnabled(){} // RVA: 0x7FFACBEE41C0
        public void AddLanguage(){} // RVA: 0x7FFACBEE4620
        public void RemoveLanguage(){} // RVA: 0x7FFACBEE4BF0
        public void AddLink(){} // RVA: 0x7FFACBEE5180
        public void ModifyLink(){} // RVA: 0x7FFACBEE56C0
        public void UpdateBio(){} // RVA: 0x7FFACBEE5B60
        public void UpdateContentFilters(){} // RVA: 0x7FFACBEE6150
        public void UpdateUserLanguageCode(){} // RVA: 0x7FFACBEE6570
        public void AddNewStatusToHistory(){} // RVA: 0x7FFACBEE6A60
        public void StatusValueToString(){} // RVA: 0x7FFACBEE6C20
        public void StringToStatusValue(){} // RVA: 0x7FFACBEE6D80
        public void UnfriendUser(){} // RVA: 0x7FFACBEE7000
        public void LocalAddFriend(){} // RVA: 0x7FFACBEE7410
        public void IsFriendsWith(){} // RVA: 0x7FFACBEE7660
        public void get_HasRequestedToBeFriend(){} // RVA: 0x7FFACBEE7890
        public void set_HasRequestedToBeFriend(){} // RVA: 0x7FFACBEE7910
        public void get_HasFriendRequestPending(){} // RVA: 0x7FFACBEE79B0
        public void set_HasFriendRequestPending(){} // RVA: 0x7FFACBEE7A30
        public void SetAvatarPropertiesFromModel(){} // RVA: 0x7FFACBEE7AD0
        public void SetAvatarFallbackPropertiesFromModel(){} // RVA: 0x7FFACBEE7D30
        public void Exists(){} // RVA: 0x7FFACBEE7E20
        public void HasTag(){} // RVA: 0x7FFACBEE7E60
        public void AddTag(){} // RVA: 0x7FFACBEE7ED0
        public void RemoveTag(){} // RVA: 0x7FFACBEE7F70
        public void Equals(){} // RVA: 0x7FFACBEE80C0
        public void UpdateNote(){} // RVA: 0x7FFACBEE8170
        public void SetUserInterests(){} // RVA: 0x7FFACBEE8800
        public void GetUserInterests(){} // RVA: 0x7FFACBEE8AD0
        public void CheckIfPersistenceDataExistsForWorld(){} // RVA: 0x7FFACBEE8DE0
        public void ResetPersistenceDataForWorld(){} // RVA: 0x7FFACBEE9190
        public void ResetAllPersistenceDataForWorlds(){} // RVA: 0x7FFACBEE9530
        public void UpdateBadge(){} // RVA: 0x7FFACBEE9870
        public void ToString(){} // RVA: 0x7FFACBEEA0D0
        public void .cctor(){} // RVA: 0x7FFACBEEA410
    }

    public class AnalyticsInterface : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFACBF2FDC0
        public void SetBuildVersion(){} // RVA: 0x7FFACBF2FF10
        public void SetLogger(){} // RVA: 0x7FFACBF2FFC0
        public void Send(){} // RVA: 0x7FFACBF300A0
        public void SetUserId(){} // RVA: 0x7FFACBF30190
        public void SetSessionId(){} // RVA: 0x7FFACBF30240
        public void GetSessionId(){} // RVA: 0x7FFACBF30300
        public void SetUserProperties(){} // RVA: 0x7FFACBF303A0
        public void ClearCachedData(){} // RVA: 0x7FFACBF30460
        public void OnApplicationQuit(){} // RVA: 0x7FFACBF305A0
        public void HasPendingEvents(){} // RVA: 0x7FFACBF30670
        public void OnApplicationFocused(){} // RVA: 0x7FFACBF30740
        public void OnApplicationPaused(){} // RVA: 0x7FFACBF307E0
        public void CheckInstance(){} // RVA: 0x7FFACBF308A0
    }

    public class AnalyticsSDK : Object
    {
        public bool _isInitialized;
        public string _lastLoggedInUserId; // 0x8
        public string API_KEY;
        public string API_KEY_DEV;
        public string EVENT_NAME_LOGIN_SUCCESS;
        public string EVENT_NAME_UPDATE_AVATAR_FAILED;
        public string EVENT_NAME_CREATE_AVATAR_FAILED;
        public string EVENT_NAME_UPDATE_WORLD_FAILED;
        public string EVENT_NAME_CREATE_WORLD_FAILED;
        public string EVENT_NAME_UPDATE_PROP_FAILED;
        public string EVENT_NAME_CREATE_PROP_FAILED;
        public string EVENT_NAME_EXAMPLE_CENTRAL_OPENED;
        public string EVENT_NAME_EXAMPLE_DOWNLOADED;
        public string EVENT_NAME_EXAMPLE_PREVIEWED;
        public string EVENT_NAME_BUILD_AND_TEST_LAUNCHED;
        public string EVENT_PROP_USER_ID;
        public string EVENT_PROP_SDK_VERSION;
        public string EVENT_PROP_UNITY_VERSION;
        public string EVENT_PROP_MODEL_ID;
        public string EVENT_PROP_EXAMPLE_NAME;
        public string EVENT_PROP_EXAMPLE_VERSION;
        public string EVENT_PROP_TEST_PLATFORM_NAME;
        public string EVENT_PROP_DEVICE;
        public string EVENT_PROP_CONTENT_TYPE;
        public string EVENT_PROP_PACKAGES;
        public string EVENT_PROP_PACKAGE_ID;
        public string EVENT_PROP_PACKAGE_VERSION;
        public string EVENT_PROP_CONTENT_ID;
        public string EVENT_PROP_PROJECT_TYPE;
        public string EVENT_NAME_PROJECT_PUBLISHED;
        public int EVENT_LIMIT_EXAMPLE_PREVIEWED;
        public int TIME_LIMIT_EXAMPLE_PREVIEWED;
        public int eventCounterExamplePreviewed; // 0x10
        public System.DateTime lastResetTimeExamplePreviewed; // 0x18

        // ── Methods ──
        public void GetProjectTypeString(){} // RVA: 0x7FFACBF30980
        public void Initialize(){} // RVA: 0x7FFACBF30A30
        public void LoggedInUserChanged(){} // RVA: 0x7FFACBF30B90 | overloaded x2
        public void AddOtherProperties(){} // RVA: 0x7FFACBF30DE0
        public void AvatarUploadFailed(){} // RVA: 0x7FFACBF30F80
        public void WorldUploadFailed(){} // RVA: 0x7FFACBF310F0
        public void PropUploadFailed(){} // RVA: 0x7FFACBF31260
        public void ExampleCentralOpened(){} // RVA: 0x7FFACBF313D0
        public void ExampleDownloaded(){} // RVA: 0x7FFACBF31570
        public void ExamplePreviewed(){} // RVA: 0x7FFACBF317B0
        public void CheckInit(){} // RVA: 0x7FFACBF31B20
        public void BuildAndTestLaunched(){} // RVA: 0x7FFACBF31C50
        public void ProjectPublished(){} // RVA: 0x7FFACBF31EE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFACBF32320
    }

    public class ApiAccountUpgrade : ApiModel
    {
        public bool isUpgrading; // 0x68
        public bool subscribedToMarketingEmails; // 0x69
        public bool hasEmail; // 0x6A
        public bool emailVerified; // 0x6B

        // ── Methods ──
        public void get_isUpgrading(){} // RVA: 0x7FFAC2FE9570
        public void set_isUpgrading(){} // RVA: 0x7FFAC2FE9580
        public void get_subscribedToMarketingEmails(){} // RVA: 0x7FFAC4670BD0
        public void set_subscribedToMarketingEmails(){} // RVA: 0x7FFAC466E010
        public void get_hasEmail(){} // RVA: 0x7FFAC8290C80
        public void set_hasEmail(){} // RVA: 0x7FFAC8290C90
        public void get_emailVerified(){} // RVA: 0x7FFAC92601C0
        public void set_emailVerified(){} // RVA: 0x7FFAC92601D0
        public void .ctor(){} // RVA: 0x7FFACBE60B10
        public void GetUpgradeStatus(){} // RVA: 0x7FFACBE60BD0
        public void UpgradeWithEmail(){} // RVA: 0x7FFACBE60EF0
        public void ParseErrorCode(){} // RVA: 0x7FFACBE61430
    }

    public class ApiAdminAssetBundle : ApiModel
    {
        public string name; // 0x68
        public string description; // 0x70
        public string imageUrl; // 0x78
        public System.Collections.Generic.List`1<string> tags; // 0x80
        public int assetVersion; // 0x88
        public System.Collections.Generic.List`1<VRC.Core.ApiAdminAssetBundleFile> unityPackages; // 0x90

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_description(){} // RVA: 0x7FFAC2FE9590
        public void set_description(){} // RVA: 0x7FFAC2FE95A0
        public void get_imageUrl(){} // RVA: 0x7FFAC30E5600
        public void set_imageUrl(){} // RVA: 0x7FFAC30E06F0
        public void get_tags(){} // RVA: 0x7FFAC32EF410
        public void set_tags(){} // RVA: 0x7FFAC34D4AA0
        public void get_assetVersion(){} // RVA: 0x7FFAC37EE8C0
        public void set_assetVersion(){} // RVA: 0x7FFAC37F9DE0
        public void get_unityPackages(){} // RVA: 0x7FFAC32EF640
        public void set_unityPackages(){} // RVA: 0x7FFAC354E360
        public void GetPlatformString(){} // RVA: 0x7FFACBE61AC0 | overloaded x2
        public void GetBundleLink(){} // RVA: 0x7FFACBE61C50
        public void CreateAdminAssetBundle(){} // RVA: 0x7FFACBE61F10
        public void AddPackageToBundle(){} // RVA: 0x7FFACBE62850
        public void GetAdminAssetBundle(){} // RVA: 0x7FFACBE63050
        public void GetAllAdminAssetBundles(){} // RVA: 0x7FFACBE63380
        public void RequestDeleteBundle(){} // RVA: 0x7FFACBE63B40
        public void SendPropertyUpdate(){} // RVA: 0x7FFACBE63E50
        public void .ctor(){} // RVA: 0x7FFACBE64660
    }

    public class ApiAdminAssetBundleFile : ApiModel
    {
        public string assetUrl; // 0x68
        public string unityVersion; // 0x70
        public string platform; // 0x78
        public int assetVersion; // 0x80

        // ── Methods ──
        public void get_assetUrl(){} // RVA: 0x7FFAC2F9CD50
        public void set_assetUrl(){} // RVA: 0x7FFAC2F9CD60
        public void get_unityVersion(){} // RVA: 0x7FFAC2FE9590
        public void set_unityVersion(){} // RVA: 0x7FFAC2FE95A0
        public void get_platform(){} // RVA: 0x7FFAC30E5600
        public void set_platform(){} // RVA: 0x7FFAC30E06F0
        public void get_assetVersion(){} // RVA: 0x7FFAC35729C0
        public void set_assetVersion(){} // RVA: 0x7FFAC3572BF0
        public void GetCacheId(){} // RVA: 0x7FFACBE64A40
        public void .ctor(){} // RVA: 0x7FFACBE64BF0
    }

    public class ApiAuthContinue : ApiModel
    {
        public string continueToken; // 0x68
        public string[] requestedFields; // 0x70
        public ReservedName reservedName; // 0x78

        // ── Methods ──
        public void get_continueToken(){} // RVA: 0x7FFAC2F9CD50
        public void set_continueToken(){} // RVA: 0x7FFAC2F9CD60
        public void get_requestedFields(){} // RVA: 0x7FFAC2FE9590
        public void set_requestedFields(){} // RVA: 0x7FFAC2FE95A0
        public void get_reservedName(){} // RVA: 0x7FFAC30E5600
        public void set_reservedName(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFACBE64C40
    }

    public class ApiAvatar : ApiContentModel`1
    {
        public System.Collections.Generic.Dictionary`2<0x6B0AFC18,string> impostorUrl; // 0xD8
        public string variant; // 0xE0
        public 0x6B0ACE60 impostorUnityVersion; // 0xE8
        public string unityPackages; // 0xF0
        public System.Collections.Generic.List`1<UnityPackage> created_at; // 0xF8
        public System.DateTime updated_at; // 0x100
        public System.DateTime attribution; // 0x108
        public VRC.Core.ApiProductAttribution offlineAnalysisScanStatus; // 0x110
        public 0x6B0AD960<VRC.Core.ApiAvatar> performanceRating; // 0x118
        public string styles; // 0x120
        public System.Collections.Generic.Dictionary`2<string,string> productId; // 0x128
        public string publishedListings; // 0x130
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> lowestPrice; // 0x138
        public System.Nullable`1<int> highestPrice; // 0x140
        public System.Nullable`1<int> acknowledgements; // 0x148
        public string LoadError; // 0x150
        public string <LoadError>k__BackingField; // 0x158
        public string AvatarsEndpoint;

        // ── Methods ──
        public void get_impostorUrl(){} // RVA: 0x7FFAC2FA2900
        public void set_impostorUrl(){} // RVA: 0x7FFAC2FA2910
        public void get_variant(){} // RVA: 0x7FFAC47D5FE0
        public void set_variant(){} // RVA: 0x7FFAC8A11760
        public void get_impostorUnityVersion(){} // RVA: 0x7FFAC2F8C2A0
        public void set_impostorUnityVersion(){} // RVA: 0x7FFAC2F8C2B0
        public void get_unityPackages(){} // RVA: 0x7FFAC3331F50
        public void set_unityPackages(){} // RVA: 0x7FFAC34A4860
        public void get_created_at(){} // RVA: 0x7FFAC34F6C80
        public void set_created_at(){} // RVA: 0x7FFAC4196020
        public void get_updated_at(){} // RVA: 0x7FFAC36D1F40
        public void set_updated_at(){} // RVA: 0x7FFACBE64CE0
        public void get_attribution(){} // RVA: 0x7FFAC354B170
        public void set_attribution(){} // RVA: 0x7FFAC39B3E10
        public void get_offlineAnalysisScanStatus(){} // RVA: 0x7FFAC49661E0
        public void set_offlineAnalysisScanStatus(){} // RVA: 0x7FFAC49661F0
        public void get_performanceRating(){} // RVA: 0x7FFAC313CBB0
        public void set_performanceRating(){} // RVA: 0x7FFAC3143400
        public void get_styles(){} // RVA: 0x7FFAC35466F0
        public void set_styles(){} // RVA: 0x7FFAC39C51C0
        public void get_productId(){} // RVA: 0x7FFAC3544340
        public void set_productId(){} // RVA: 0x7FFAC39A79B0
        public void get_publishedListings(){} // RVA: 0x7FFAC35422C0
        public void set_publishedListings(){} // RVA: 0x7FFAC36D84B0
        public void get_lowestPrice(){} // RVA: 0x7FFAC2F8C5F0
        public void set_lowestPrice(){} // RVA: 0x7FFAC8B3E9E0
        public void get_highestPrice(){} // RVA: 0x7FFAC2F8C660
        public void set_highestPrice(){} // RVA: 0x7FFAC8A33F90
        public void get_acknowledgements(){} // RVA: 0x7FFAC354DFA0
        public void set_acknowledgements(){} // RVA: 0x7FFAC39B99C0
        public void get_LoadError(){} // RVA: 0x7FFAC3542410
        public void set_LoadError(){} // RVA: 0x7FFAC39A74B0
        public void .ctor(){} // RVA: 0x7FFACBE64CF0
        public void Get(){} // RVA: 0x7FFACBE64E10
        public void AssignToThisUser(){} // RVA: 0x7FFACBE64FB0
        public void AssignToThisUserAsFallback(){} // RVA: 0x7FFACBE65430
        public void GetPerformanceRatingForPlatform(){} // RVA: 0x7FFACBE658B0
        public void GetAssetUrl(){} // RVA: 0x7FFACBE65930
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFACBE65AD0 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x7FFACBE65C10
        public void WriteField(){} // RVA: 0x7FFACBE66760
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFACBE66790
    }

    public class ApiAvatarModeration : ApiModel
    {
        public float moderationType;
        public 0x6B0AD070 targetAvatarId; // 0x68
        public string <targetAvatarId>k__BackingField; // 0x70

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7FFAC47BAB50
        public void set_moderationType(){} // RVA: 0x7FFAC47BAB60
        public void get_targetAvatarId(){} // RVA: 0x7FFAC2FE9590
        public void set_targetAvatarId(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBE67050
        public void ShouldCache(){} // RVA: 0x7FFAC2F21320
        public void ReadField(){} // RVA: 0x7FFACBE67110
        public void WriteField(){} // RVA: 0x7FFACBE67490
        public void SendModeration(){} // RVA: 0x7FFACBE67670
        public void DeleteModeration(){} // RVA: 0x7FFACBE678B0
        public void FetchAllMine(){} // RVA: 0x7FFACBE67DD0
        public void FetchList(){} // RVA: 0x7FFACBE67E30
        public void ModerationTypeToAPIString(){} // RVA: 0x7FFACBE68120
    }

    public class ApiAvatarStyle : ApiModel
    {
        public string styleName; // 0x68
        public string lastModifiedById; // 0x70
        public string lastModifiedByDisplayName; // 0x78
        public System.DateTime created_at; // 0x80
        public System.DateTime updated_at; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE684D0
        public void get_styleName(){} // RVA: 0x7FFAC2F9CD50
        public void set_styleName(){} // RVA: 0x7FFAC2F9CD60
        public void get_lastModifiedById(){} // RVA: 0x7FFAC2FE9590
        public void set_lastModifiedById(){} // RVA: 0x7FFAC2FE95A0
        public void get_lastModifiedByDisplayName(){} // RVA: 0x7FFAC30E5600
        public void set_lastModifiedByDisplayName(){} // RVA: 0x7FFAC30E06F0
        public void get_created_at(){} // RVA: 0x7FFAC32EF410
        public void set_created_at(){} // RVA: 0x7FFAC4A2BA90
        public void get_updated_at(){} // RVA: 0x7FFAC2F60010
        public void set_updated_at(){} // RVA: 0x7FFAC4A2BA70
    }

    public class ApiBadge : ApiModel
    {
        public string badgeId; // 0x68
        public bool showcased; // 0x70
        public string badgeName; // 0x78
        public string badgeDescription; // 0x80
        public string badgeImageUrl; // 0x88
        public bool hidden; // 0x90
        public System.DateTime assignedAt; // 0x98
        public System.DateTime updatedAt; // 0xA0
        public string assignedBy; // 0xA8

        // ── Methods ──
        public void get_badgeId(){} // RVA: 0x7FFAC2F9CD50
        public void set_badgeId(){} // RVA: 0x7FFAC2F9CD60
        public void get_showcased(){} // RVA: 0x7FFAC2F9D320
        public void set_showcased(){} // RVA: 0x7FFAC2F9D330
        public void get_badgeName(){} // RVA: 0x7FFAC30E5600
        public void set_badgeName(){} // RVA: 0x7FFAC30E06F0
        public void get_badgeDescription(){} // RVA: 0x7FFAC32EF410
        public void set_badgeDescription(){} // RVA: 0x7FFAC34D4AA0
        public void get_badgeImageUrl(){} // RVA: 0x7FFAC2F60010
        public void set_badgeImageUrl(){} // RVA: 0x7FFAC354E300
        public void get_hidden(){} // RVA: 0x7FFAC3E0D160
        public void set_hidden(){} // RVA: 0x7FFAC3E089B0
        public void get_assignedAt(){} // RVA: 0x7FFAC354DFB0
        public void set_assignedAt(){} // RVA: 0x7FFAC7E01AA0
        public void get_updatedAt(){} // RVA: 0x7FFAC3543900
        public void set_updatedAt(){} // RVA: 0x7FFAC878D950
        public void get_assignedBy(){} // RVA: 0x7FFAC354B1A0
        public void set_assignedBy(){} // RVA: 0x7FFAC334B370
        public void .ctor(){} // RVA: 0x7FFACBE68590
    }

    public class ApiBindingCommandReference : ApiModel
    {
        public string command; // 0x68
        public System.Collections.Generic.List`1<string> parameters; // 0x70
        public string name; // 0x78

        // ── Methods ──
        public void get_command(){} // RVA: 0x7FFAC2F9CD50
        public void set_command(){} // RVA: 0x7FFAC2F9CD60
        public void get_parameters(){} // RVA: 0x7FFAC2FE9590
        public void set_parameters(){} // RVA: 0x7FFAC2FE95A0
        public void get_name(){} // RVA: 0x7FFAC30E5600
        public void set_name(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFACBE685E0
        public void ToString(){} // RVA: 0x7FFACBE68680
    }

    public class ApiByteContainer : ApiContainer
    {
        public object ResponseBytes;

        // ── Methods ──
        public void get_ResponseBytes(){} // RVA: 0x7FFACBECDA60
        public void Validate(){} // RVA: 0x7FFACBECDAD0
        public void .ctor(){} // RVA: 0x7FFACBECD430
    }

    public class ApiCache : Object
    {
        public System.Func`1<long> Count;
        public System.Collections.Generic.Dictionary`2<string,CacheEntry> NextExpiryTTL; // 0x8
        public VRC.Core.PriorityQueue`1<CacheEntry> expiryQueue; // 0x10
        public UnityEngine.WaitForSeconds CleanupDelay; // 0x18

        // ── Methods ──
        public void DefaultTimeProvider(){} // RVA: 0x7FFACBE68760
        public void get_Count(){} // RVA: 0x7FFACBE68810
        public void get_NextExpiryTTL(){} // RVA: 0x7FFACBE689E0
        public void Fetch(){} // RVA: 0x7FFAC2C5A350
        public void Save(){} // RVA: 0x7FFACBE68CD0
        public void Invalidate(){} // RVA: 0x7FFACBE69140
        public void CleanupTask(){} // RVA: 0x7FFACBE693F0
        public void Cleanup(){} // RVA: 0x7FFACBE69430
        public void InvalidateFileIfVersionUnknown(){} // RVA: 0x7FFACBE69930
        public void Clear(){} // RVA: 0x7FFACBE69AE0
        public void .cctor(){} // RVA: 0x7FFACBE69D60
    }

    public class ApiCacheObject
    {
        public object ExpiryTime;

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFAC2C59D00
        public void GetLifeSpan(){} // RVA: 0x7FFAC2C6D880
        public void Clone(){} // RVA: 0x7FFAC2C58E90
        public void set_ExpiryTime(){} // RVA: 0x7FFAC2C70A40
    }

    public class ApiCalendarEntriesContainer : ApiModel
    {
        public bool hasNext; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APICalendarEntry> results; // 0x70
        public int totalCount; // 0x78
        public string nextCursor; // 0x80

        // ── Methods ──
        public void get_hasNext(){} // RVA: 0x7FFAC2FE9570
        public void set_hasNext(){} // RVA: 0x7FFAC2FE9580
        public void get_results(){} // RVA: 0x7FFAC2FE9590
        public void set_results(){} // RVA: 0x7FFAC2FE95A0
        public void get_totalCount(){} // RVA: 0x7FFAC4596EF0
        public void set_totalCount(){} // RVA: 0x7FFAC45963A0
        public void get_nextCursor(){} // RVA: 0x7FFAC32EF410
        public void set_nextCursor(){} // RVA: 0x7FFAC34D4AA0
        public void .ctor(){} // RVA: 0x7FFACBF12E40
    }

    public class ApiCalendarResults : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.APICalendarEntry> results; // 0x68
        public int totalCount; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFAC2F9CD50
        public void set_results(){} // RVA: 0x7FFAC2F9CD60
        public void get_totalCount(){} // RVA: 0x7FFAC3B99E80
        public void set_totalCount(){} // RVA: 0x7FFAC30B6520
        public void .ctor(){} // RVA: 0x7FFACBED2AC0
    }

    public class ApiCampaignAnonymizationStatus : ApiModel
    {
        public bool isAnonymized; // 0x68
        public string anonymizedName; // 0x70

        // ── Methods ──
        public void get_isAnonymized(){} // RVA: 0x7FFAC2FE9570
        public void set_isAnonymized(){} // RVA: 0x7FFAC2FE9580
        public void get_anonymizedName(){} // RVA: 0x7FFAC2FE9590
        public void set_anonymizedName(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBE6B740
    }

    public class ApiCampaignContributor : ApiModel
    {
        public string userId; // 0x68
        public string displayName; // 0x70
        public int giftCount; // 0x78
        public bool isAnonymized; // 0x7C
        public bool isSelf; // 0x7D

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFAC2F9CD50
        public void set_userId(){} // RVA: 0x7FFAC2F9CD60
        public void get_displayName(){} // RVA: 0x7FFAC2FE9590
        public void set_displayName(){} // RVA: 0x7FFAC2FE95A0
        public void get_giftCount(){} // RVA: 0x7FFAC4596EF0
        public void set_giftCount(){} // RVA: 0x7FFAC45963A0
        public void get_isAnonymized(){} // RVA: 0x7FFAC33CFDF0
        public void set_isAnonymized(){} // RVA: 0x7FFAC33C9B20
        public void get_isSelf(){} // RVA: 0x7FFAC33CAD30
        public void set_isSelf(){} // RVA: 0x7FFAC33CC1E0
        public void .ctor(){} // RVA: 0x7FFACBE6B790
    }

    public class ApiCampaignReward : ApiModel
    {
        public bool isUnlocked; // 0x68
        public string imageUrl; // 0x70
        public VRC.Core.ApiCampaignRewardProgression progression; // 0x78

        // ── Methods ──
        public void get_isUnlocked(){} // RVA: 0x7FFAC2FE9570
        public void set_isUnlocked(){} // RVA: 0x7FFAC2FE9580
        public void get_imageUrl(){} // RVA: 0x7FFAC2FE9590
        public void set_imageUrl(){} // RVA: 0x7FFAC2FE95A0
        public void get_progression(){} // RVA: 0x7FFAC30E5600
        public void set_progression(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFACBE6B6A0
    }

    public class ApiCampaignRewardProgression : ApiModel
    {
        public int required; // 0x68
        public int current; // 0x6C

        // ── Methods ──
        public void get_required(){} // RVA: 0x7FFAC47BAB50
        public void set_required(){} // RVA: 0x7FFAC47BAB60
        public void get_current(){} // RVA: 0x7FFAC47BAB70
        public void set_current(){} // RVA: 0x7FFAC47BAB80
        public void .ctor(){} // RVA: 0x7FFACBE6B6F0
    }

    public class ApiCertificateVerifier : CertificateHandler
    {
        public VRC.Core.ApiCertificateVerifier Instance;
        public string[] publicKeys; // 0x8

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFACBE6B7E0
        public void .ctor(){} // RVA: 0x7FFAC9C92940
        public void Initialize(){} // RVA: 0x7FFACBE6B840
        public void TestPublicKey(){} // RVA: 0x7FFACBE6B940
        public void IsValid(){} // RVA: 0x7FFACBE6BBD0
        public void ValidateCertificate(){} // RVA: 0x7FFACBE6BE10
        public void .cctor(){} // RVA: 0x7FFACBE6BFD0
    }

    public class ApiContainer : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> Cookies; // 0x10
        public bool Populated; // 0x18
        public bool PassedValidation; // 0x19
        public int Code; // 0x1C
        public string Text; // 0x20
        public object Data; // 0x28
        public float DataTimestamp; // 0x30
        public string CreatedAt; // 0x38
        public string Error; // 0x40
        public VRC.Core.ApiModel Model; // 0x48
        public System.Action`1<VRC.Core.ApiContainer> OnError; // 0x50
        public System.Action`1<VRC.Core.ApiContainer> OnSuccess; // 0x58

        // ── Methods ──
        public void get_Cookies(){} // RVA: 0x7FFAC2F3C380
        public void set_Cookies(){} // RVA: 0x7FFAC2F22E30
        public void get_Populated(){} // RVA: 0x7FFAC2F3C4E0
        public void set_Populated(){} // RVA: 0x7FFAC2F3C4F0
        public void get_PassedValidation(){} // RVA: 0x7FFAC3228D50
        public void set_PassedValidation(){} // RVA: 0x7FFAC3515120
        public void get_Code(){} // RVA: 0x7FFAC44357F0
        public void set_Code(){} // RVA: 0x7FFAC44474D0
        public void get_Text(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Text(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Data(){} // RVA: 0x7FFAC2F4F130
        public void set_Data(){} // RVA: 0x7FFAC2F22E90
        public void get_DataTimestamp(){} // RVA: 0x7FFAC3C40670
        public void set_DataTimestamp(){} // RVA: 0x7FFAC47394E0
        public void get_CreatedAt(){} // RVA: 0x7FFAC31D0140
        public void set_CreatedAt(){} // RVA: 0x7FFAC31D0C20
        public void get_Error(){} // RVA: 0x7FFACBECDC20
        public void set_Error(){} // RVA: 0x7FFACBECDC50
        public void get_Model(){} // RVA: 0x7FFAC2F9C730
        public void set_Model(){} // RVA: 0x7FFAC2F9C740
        public void .ctor(){} // RVA: 0x7FFACBECDFB0
        public void setFromContainer(){} // RVA: 0x7FFACBECE080
        public void Validate(){} // RVA: 0x7FFACBECE290
        public void GetErrorMessage(){} // RVA: 0x7FFACBECE2E0
        public void OnComplete(){} // RVA: 0x7FFACBECE490
    }

    public class ApiContentModel`1 : ApiModel
    {
        public VRC.Core.AssetVersion VERSION;
        public VRC.Core.AssetVersion name;
        public float imageUrl;
        public float authorName;
        public System.Collections.Generic.Dictionary`2<string,T> authorId;
        public string assetUrl;
        public string description;
        public string tags;
        public string thumbnailImageUrl;
        public string version;
        public string releaseStatus;
        public System.Collections.Generic.List`1<string> featured;
        public string unityPackageUpdated;
        public int unityVersion;
        public string apiVersion;
        public bool platform;
        public bool assetVersion;
        public string IsLocal;
        public int <apiVersion>k__BackingField;
        public string <platform>k__BackingField;

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7FFAC2C58A90
        public void ShouldCache(){} // RVA: 0x7FFAC2C59D00
        public void GetLifeSpan(){} // RVA: 0x7FFAC2C6D880
        public void get_name(){} // RVA: 0x7FFAC2C58E90
        public void set_name(){} // RVA: 0x7FFAC2C70A40
        public void get_imageUrl(){} // RVA: 0x7FFAC2C58E90
        public void set_imageUrl(){} // RVA: 0x7FFAC2C70A40
        public void get_authorName(){} // RVA: 0x7FFAC2C58E90
        public void set_authorName(){} // RVA: 0x7FFAC2C70A40
        public void get_authorId(){} // RVA: 0x7FFAC2C58E90
        public void set_authorId(){} // RVA: 0x7FFAC2C70A40
        public void get_assetUrl(){} // RVA: 0x7FFAC2C58E90
        public void set_assetUrl(){} // RVA: 0x7FFAC2C70A40
        public void get_description(){} // RVA: 0x7FFAC2C58E90
        public void set_description(){} // RVA: 0x7FFAC2C70A40
        public void get_tags(){} // RVA: 0x7FFAC2C58E90
        public void set_tags(){} // RVA: 0x7FFAC2C70A40
        public void get_thumbnailImageUrl(){} // RVA: 0x7FFAC2C58E90
        public void set_thumbnailImageUrl(){} // RVA: 0x7FFAC2C70A40
        public void get_version(){} // RVA: 0x7FFAC2C59960
        public void set_version(){} // RVA: 0x7FFAC2C70ED0
        public void get_releaseStatus(){} // RVA: 0x7FFAC2C58E90
        public void set_releaseStatus(){} // RVA: 0x7FFAC2C70A40
        public void get_featured(){} // RVA: 0x7FFAC2C59D00
        public void set_featured(){} // RVA: 0x7FFAC2C71060
        public void get_unityPackageUpdated(){} // RVA: 0x7FFAC2C59D00
        public void set_unityPackageUpdated(){} // RVA: 0x7FFAC2C71060
        public void get_unityVersion(){} // RVA: 0x7FFAC2C58E90
        public void set_unityVersion(){} // RVA: 0x7FFAC2C70A40
        public void get_apiVersion(){} // RVA: 0x7FFAC2C59960
        public void set_apiVersion(){} // RVA: 0x7FFAC2C70ED0
        public void get_platform(){} // RVA: 0x7FFAC2C58E90
        public void set_platform(){} // RVA: 0x7FFAC2C70A40
        public void get_assetVersion(){} // RVA: 0x7FFAC2C58E90
        public void set_assetVersion(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void ReadField(){} // RVA: 0x7FFAC2C5D200
        public void Get(){} // RVA: 0x7FFAC2E8DC40
        public void FetchList(){} // RVA: 0x7FFAC2E8DC40
        public void AddLocal(){} // RVA: 0x7FFAC2E8DC40
        public void IsLocalById(){} // RVA: 0x7FFAC2C59DE0
        public void get_IsLocal(){} // RVA: 0x7FFAC2C59D00
        public void Save(){} // RVA: 0x7FFAC2C79B30
        public void SaveReleaseStatus(){} // RVA: 0x7FFAC2C79B30
        public void GetAssetUrl(){} // RVA: 0x7FFAC2C58E90
        public void HasTag(){} // RVA: 0x7FFAC2C59F60
        public void AddTag(){} // RVA: 0x7FFAC2C59F60
        public void RemoveTag(){} // RVA: 0x7FFAC2C59F60
        public void UpdateVersionAndPlatform(){} // RVA: 0x7FFAC2C70980
        public void MakeRequestEndpoint(){}
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class ApiCredentials : Object
    {
        public string SECURE_PLAYER_PREFS_PW;
        public string authToken;
        public BestHTTP.Cookies.Cookie authTokenCookie; // 0x8
        public string twoFactorAuthToken; // 0x10
        public BestHTTP.Cookies.Cookie twoFactorAuthTokenCookie; // 0x18
        public string provider; // 0x20
        public string providerUserId; // 0x28
        public string humanName; // 0x30
        public System.Nullable`1<uint> index; // 0x38

        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFACBF12EE0
        public void SetProfileIndex(){} // RVA: 0x7FFACBF12F10
        public void SetString(){} // RVA: 0x7FFACBF12F90
        public void GetString(){} // RVA: 0x7FFACBF131E0
        public void Load(){} // RVA: 0x7FFACBF133D0
        public void SetHumanName(){} // RVA: 0x7FFACBF13B00
        public void Set(){} // RVA: 0x7FFACBF13C10
        public void Set2faToken(){} // RVA: 0x7FFACBF14200
        public void GetHumanName(){} // RVA: 0x7FFACBF143E0
        public void GetAuthToken(){} // RVA: 0x7FFACBF14420
        public void GetTwoFactorAuthToken(){} // RVA: 0x7FFACBF14460
        public void GetAuthTokenCookie(){} // RVA: 0x7FFACBF144A0
        public void GetTwoFactorAuthTokenCookie(){} // RVA: 0x7FFACBF144E0
        public void GetAuthTokenProvider(){} // RVA: 0x7FFACBF14520
        public void GetAuthTokenProviderUserId(){} // RVA: 0x7FFACBF14560
        public void IsLoaded(){} // RVA: 0x7FFACBF145A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ApiDictContainer : ApiContainer
    {
        public float cacheLifetime; // 0x60
        public System.Nullable`1<long> ExpiryTime; // 0x68
        public string[] requiredFields; // 0x78
        public System.Collections.Generic.IReadOnlyDictionary`2<string,Token> ResponseDictionary;

        // ── Methods ──
        public void get_cacheLifetime(){} // RVA: 0x7FFAC3031E10
        public void set_cacheLifetime(){} // RVA: 0x7FFAC3735550
        public void get_ExpiryTime(){} // RVA: 0x7FFAC5FD87B0
        public void set_ExpiryTime(){} // RVA: 0x7FFAC5FD8C20
        public void get_requiredFields(){} // RVA: 0x7FFAC30E5600
        public void set_requiredFields(){} // RVA: 0x7FFAC30E06F0
        public void get_ResponseDictionary(){} // RVA: 0x7FFACBECC8D0
        public void .ctor(){} // RVA: 0x7FFACBECCAB0 | overloaded x2
        public void Validate(){} // RVA: 0x7FFACBECCB20
        public void ShouldCache(){} // RVA: 0x7FFACBECCE70
        public void ShouldClearOnLevelLoad(){} // RVA: 0x7FFAC2F21320
        public void GetLifeSpan(){} // RVA: 0x7FFAC3031E10
        public void Clone(){} // RVA: 0x7FFACBECCE80
        public void .cctor(){} // RVA: 0x7FFACBECCF00
        public void <Validate>b__17_0(){} // RVA: 0x7FFACBECCFD0
    }

    public class ApiDroneSkin : ApiModel
    {
        public string name; // 0x68
        public string assetBundleId; // 0x70
        public string viewfinderAssetBundleId; // 0x78

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_assetBundleId(){} // RVA: 0x7FFAC2FE9590
        public void set_assetBundleId(){} // RVA: 0x7FFAC2FE95A0
        public void get_viewfinderAssetBundleId(){} // RVA: 0x7FFAC30E5600
        public void set_viewfinderAssetBundleId(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFACBE6C220
    }

    public class ApiEconomyAccountStatus : ApiModel
    {
        public string UserID; // 0x68
        public bool Blocked; // 0x70

        // ── Methods ──
        public void get_UserID(){} // RVA: 0x7FFAC2F9CD50
        public void set_UserID(){} // RVA: 0x7FFAC2F9CD60
        public void get_Blocked(){} // RVA: 0x7FFAC2F9D320
        public void set_Blocked(){} // RVA: 0x7FFAC2F9D330
        public void .ctor(){} // RVA: 0x7FFACBF145F0
    }

    public class ApiEconomyStatus : ApiModel
    {
        public bool EconomyIsOnline; // 0x68
        public int EconomyState; // 0x6C

        // ── Methods ──
        public void get_EconomyIsOnline(){} // RVA: 0x7FFAC2FE9570
        public void set_EconomyIsOnline(){} // RVA: 0x7FFAC2FE9580
        public void get_EconomyState(){} // RVA: 0x7FFAC47BAB70
        public void set_EconomyState(){} // RVA: 0x7FFAC47BAB80
        public void .ctor(){} // RVA: 0x7FFACBF14640
    }

    public class ApiEconomyStore : ApiModel
    {
        public string SellerId; // 0x68
        public string SellerDisplayName; // 0x70
        public string WorldId; // 0x78
        public string GroupId; // 0x80
        public 0x6B0ADC78 StoreStatus; // 0x88
        public string DisplayName; // 0x90
        public string Description; // 0x98
        public System.Collections.Generic.List`1<string> Tags; // 0xA0
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> Listings; // 0xA8
        public System.Collections.Generic.List`1<string> ListingIDs; // 0xB0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE6C270
        public void get_SellerId(){} // RVA: 0x7FFAC2F9CD50
        public void set_SellerId(){} // RVA: 0x7FFAC2F9CD60
        public void get_SellerDisplayName(){} // RVA: 0x7FFAC2FE9590
        public void set_SellerDisplayName(){} // RVA: 0x7FFAC2FE95A0
        public void get_WorldId(){} // RVA: 0x7FFAC30E5600
        public void set_WorldId(){} // RVA: 0x7FFAC30E06F0
        public void get_GroupId(){} // RVA: 0x7FFAC32EF410
        public void set_GroupId(){} // RVA: 0x7FFAC34D4AA0
        public void get_StoreStatus(){} // RVA: 0x7FFAC37EE8C0
        public void set_StoreStatus(){} // RVA: 0x7FFAC37F9DE0
        public void get_DisplayName(){} // RVA: 0x7FFAC32EF640
        public void set_DisplayName(){} // RVA: 0x7FFAC354E360
        public void get_Description(){} // RVA: 0x7FFAC354DFB0
        public void set_Description(){} // RVA: 0x7FFAC354E3C0
        public void get_Tags(){} // RVA: 0x7FFAC3543900
        public void set_Tags(){} // RVA: 0x7FFAC354E420
        public void get_Listings(){} // RVA: 0x7FFAC354B1A0
        public void set_Listings(){} // RVA: 0x7FFAC334B370
        public void get_ListingIDs(){} // RVA: 0x7FFAC2F8C040
        public void set_ListingIDs(){} // RVA: 0x7FFAC2F8C050
        public void get_IsGroupStore(){} // RVA: 0x7FFACBE6C2C0
        public void get_IsWorldStore(){} // RVA: 0x7FFACBE6C2E0
        public void ReadField(){} // RVA: 0x7FFACBE6C300
        public void WriteField(){} // RVA: 0x7FFACBE6C540
        public void FetchStore(){} // RVA: 0x7FFACBE6C6A0
    }

    public class ApiFieldAttribute : Attribute
    {
        public bool required; // 0x10
        public string name; // 0x18
        public bool isAdminWritableOnly; // 0x20
        public bool isApiWritableOnly; // 0x21

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC322C870
    }

    public class ApiFile : ApiModel
    {
        public string name; // 0x68
        public System.Nullable`1<int> order; // 0x70
        public string ownerId; // 0x78
        public string mimeType; // 0x80
        public string extension; // 0x88
        public System.Collections.Generic.List`1<Version> versions; // 0x90
        public bool IsInitialized; // 0x98
        public bool IsPendingInit; // 0x99

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_order(){} // RVA: 0x7FFAC2FE9590
        public void set_order(){} // RVA: 0x7FFAC4A2BA60
        public void get_ownerId(){} // RVA: 0x7FFAC30E5600
        public void set_ownerId(){} // RVA: 0x7FFAC30E06F0
        public void get_mimeType(){} // RVA: 0x7FFAC32EF410
        public void set_mimeType(){} // RVA: 0x7FFAC34D4AA0
        public void get_extension(){} // RVA: 0x7FFAC2F60010
        public void set_extension(){} // RVA: 0x7FFAC354E300
        public void get_versions(){} // RVA: 0x7FFAC32EF640
        public void set_versions(){} // RVA: 0x7FFAC354E360
        public void get_IsInitialized(){} // RVA: 0x7FFAC339A7F0
        public void set_IsInitialized(){} // RVA: 0x7FFAC339FA20
        public void get_IsPendingInit(){} // RVA: 0x7FFAC339C020
        public void set_IsPendingInit(){} // RVA: 0x7FFAC8956680
        public void .ctor(){} // RVA: 0x7FFACBE6F1D0 | overloaded x3
        public void Create(){} // RVA: 0x7FFACBE6F360
        public void Refresh(){} // RVA: 0x7FFACBE6F500
        public void DownloadFile(){} // RVA: 0x7FFACBE6F540
        public void ParseFileIdFromFileAPIUrl(){} // RVA: 0x7FFACBE6FBB0
        public void TryParseFileIdFromFileAPIUrl(){} // RVA: 0x7FFACBE6FC50
        public void TryParseFileVersionFromFileAPIUrl(){} // RVA: 0x7FFACBE6FC90
        public void TryParseFileIdAndVersionFromFileAPIUrl(){} // RVA: 0x7FFACBE6FCE0
        public void TryParseFileIdAndVersionAndVariantSuffixFromFileAPIUrl(){} // RVA: 0x7FFACBE6FD20
        public void TryParseFileIdAndVersionAndVariantFromFileAPIUrl(){} // RVA: 0x7FFACBE6FDA0 | overloaded x2
        public void PerformRegexMatch(){} // RVA: 0x7FFACBE6FDD0
        public void TryGetImageAPIUrlFromFileAPIUrl(){} // RVA: 0x7FFACBE705D0
        public void OnDownloadFileCompleted(){} // RVA: 0x7FFACBE70B30
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFACBE71230 | overloaded x2
        public void ToString(){} // RVA: 0x7FFACBE71260
        public void ToStringBrief(){} // RVA: 0x7FFAC30FEBD0
        public void CreateNewVersion(){} // RVA: 0x7FFACBE71480
        public void HasExistingVersion(){} // RVA: 0x7FFACBE71BC0
        public void HasExistingOrPendingVersion(){} // RVA: 0x7FFACBE71C80
        public void GetLatestVersionNumber(){} // RVA: 0x7FFACBE71D60
        public void GetLatestCompleteVersionNumber(){} // RVA: 0x7FFACBE71DC0
        public void GetVersion(){} // RVA: 0x7FFACBE71EF0
        public void GetLatestCompleteVersion(){} // RVA: 0x7FFACBE71F90
        public void GetLatestVersion(){} // RVA: 0x7FFACBE71FC0
        public void DeleteVersion(){} // RVA: 0x7FFACBE72030
        public void DeleteLatestVersion(){} // RVA: 0x7FFACBE72320
        public void DownloadSignature(){} // RVA: 0x7FFACBE72700
        public void GetFileURL(){} // RVA: 0x7FFACBE727A0 | overloaded x2
        public void GetFileRawURL(){} // RVA: 0x7FFACBE72830 | overloaded x2
        public void GetDeltaURL(){} // RVA: 0x7FFACBE728E0 | overloaded x2
        public void GetDeltaRawURL(){} // RVA: 0x7FFACBE72970 | overloaded x2
        public void GetSignatureURL(){} // RVA: 0x7FFACBE72A20 | overloaded x2
        public void GetSignatureRawURL(){} // RVA: 0x7FFACBE72AB0 | overloaded x2
        public void GetFileApiURL(){} // RVA: 0x7FFACBE72D10 | overloaded x2
        public void GetFileVariantApiURL(){} // RVA: 0x7FFACBE72E50
        public void GetFileMD5(){} // RVA: 0x7FFACBE732E0 | overloaded x2
        public void GetFileDescriptor(){} // RVA: 0x7FFACBE73360
        public void IsLatestVersionQueued(){} // RVA: 0x7FFACBE73390
        public void HasQueuedOperation(){} // RVA: 0x7FFACBE73460
        public void IsWaitingForUpload(){} // RVA: 0x7FFACBE73600
        public void IsInErrorState(){} // RVA: 0x7FFACBE736D0
        public void StartSimpleUpload(){} // RVA: 0x7FFACBE737A0
        public void StartMultipartUpload(){} // RVA: 0x7FFACBE73B30
        public void FinishUpload(){} // RVA: 0x7FFACBE73F10
        public void GetUploadStatus(){} // RVA: 0x7FFACBE741A0
        public void PutSimpleFileToURL(){} // RVA: 0x7FFACBE743A0
        public void PutMultipartDataToURL(){} // RVA: 0x7FFACBE74E80
    }

    public class ApiGroupGalleryImage : ApiModel
    {
        public string name; // 0x68
        public string groupId; // 0x70
        public string galleryId; // 0x78
        public string fileId; // 0x80
        public string imageUrl; // 0x88
        public System.DateTime createdAt; // 0x90
        public bool approved; // 0x98
        public System.DateTime approvedAt; // 0xA0
        public string approvedByUserId; // 0xA8
        public string submittedByUserId; // 0xB0
        public VRC.Core.ApiFile file; // 0xB8

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_groupId(){} // RVA: 0x7FFAC2FE9590
        public void set_groupId(){} // RVA: 0x7FFAC2FE95A0
        public void get_galleryId(){} // RVA: 0x7FFAC30E5600
        public void set_galleryId(){} // RVA: 0x7FFAC30E06F0
        public void get_fileId(){} // RVA: 0x7FFAC32EF410
        public void set_fileId(){} // RVA: 0x7FFAC34D4AA0
        public void get_imageUrl(){} // RVA: 0x7FFAC2F60010
        public void set_imageUrl(){} // RVA: 0x7FFAC354E300
        public void get_createdAt(){} // RVA: 0x7FFAC32EF640
        public void set_createdAt(){} // RVA: 0x7FFAC3705AA0
        public void get_approved(){} // RVA: 0x7FFAC339A7F0
        public void set_approved(){} // RVA: 0x7FFAC339FA20
        public void get_approvedAt(){} // RVA: 0x7FFAC3543900
        public void set_approvedAt(){} // RVA: 0x7FFAC878D950
        public void get_approvedByUserId(){} // RVA: 0x7FFAC354B1A0
        public void set_approvedByUserId(){} // RVA: 0x7FFAC334B370
        public void get_submittedByUserId(){} // RVA: 0x7FFAC2F8C040
        public void set_submittedByUserId(){} // RVA: 0x7FFAC2F8C050
        public void get_file(){} // RVA: 0x7FFAC2F8C0B0
        public void set_file(){} // RVA: 0x7FFAC2F8C0C0
        public void .ctor(){} // RVA: 0x7FFACBF1EBA0
    }

    public class ApiImage : ApiFile
    {
        public int MAX_IMAGES;
        public string endpoint;

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFAC2F21320
        public void FetchList(){} // RVA: 0x7FFACBE77680
        public void UploadImage(){} // RVA: 0x7FFACBE781E0
        public void .ctor(){} // RVA: 0x7FFACBE785E0
    }

    public class ApiInfoPushSystem : ApiModel
    {
        public float isEnabled;
        public bool releaseStatus; // 0x68
        public string tags; // 0x70
        public System.Collections.Generic.List`1<string> requireClientTags; // 0x78
        public System.Collections.Generic.List`1<string> priority; // 0x80
        public int startDate; // 0x88
        public System.DateTime endDate; // 0x90
        public System.DateTime createdAt; // 0x98
        public System.DateTime updatedAt; // 0xA0
        public System.DateTime hash; // 0xA8
        public string originalManifestId; // 0xB0
        public string data; // 0xB8
        public Data <data>k__BackingField; // 0xC0
        public string ENDPOINT;

        // ── Methods ──
        public void get_isEnabled(){} // RVA: 0x7FFAC2FE9570
        public void set_isEnabled(){} // RVA: 0x7FFAC2FE9580
        public void get_releaseStatus(){} // RVA: 0x7FFAC2FE9590
        public void set_releaseStatus(){} // RVA: 0x7FFAC2FE95A0
        public void get_tags(){} // RVA: 0x7FFAC30E5600
        public void set_tags(){} // RVA: 0x7FFAC30E06F0
        public void get_requireClientTags(){} // RVA: 0x7FFAC32EF410
        public void set_requireClientTags(){} // RVA: 0x7FFAC34D4AA0
        public void get_priority(){} // RVA: 0x7FFAC37EE8C0
        public void set_priority(){} // RVA: 0x7FFAC37F9DE0
        public void get_startDate(){} // RVA: 0x7FFAC32EF640
        public void set_startDate(){} // RVA: 0x7FFAC3705AA0
        public void get_endDate(){} // RVA: 0x7FFAC354DFB0
        public void set_endDate(){} // RVA: 0x7FFAC7E01AA0
        public void get_createdAt(){} // RVA: 0x7FFAC3543900
        public void set_createdAt(){} // RVA: 0x7FFAC878D950
        public void get_updatedAt(){} // RVA: 0x7FFAC354B1A0
        public void set_updatedAt(){} // RVA: 0x7FFAC45C9F60
        public void get_hash(){} // RVA: 0x7FFAC2F8C040
        public void set_hash(){} // RVA: 0x7FFAC2F8C050
        public void get_originalManifestId(){} // RVA: 0x7FFAC2F8C0B0
        public void set_originalManifestId(){} // RVA: 0x7FFAC2F8C0C0
        public void get_data(){} // RVA: 0x7FFAC2F8C120
        public void set_data(){} // RVA: 0x7FFAC2F8C130
        public void .ctor(){} // RVA: 0x7FFACBE78880
        public void GetLifeSpan(){} // RVA: 0x7FFAC623E940
        public void FetchList(){} // RVA: 0x7FFACBE78940
        public void Save(){} // RVA: 0x7FFACBE791B0
    }

    public class ApiInventoryBundle : ApiModel
    {
        public System.Collections.Generic.List`1<string> inventoryItemsToInstantiate; // 0x68
        public ApiBundleDropNotificationDetails notificationDetails; // 0x70

        // ── Methods ──
        public void get_inventoryItemsToInstantiate(){} // RVA: 0x7FFAC2F9CD50
        public void set_inventoryItemsToInstantiate(){} // RVA: 0x7FFAC2F9CD60
        public void get_notificationDetails(){} // RVA: 0x7FFAC2FE9590
        public void set_notificationDetails(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBE79B50
    }

    public class ApiInventoryBundleDrop : ApiModel
    {
        public string name;
        public string authorId; // 0x68
        public string targetGroup; // 0x70
        public string templateIds; // 0x78
        public System.Collections.Generic.List`1<string> startDropDate; // 0x80
        public System.DateTime endDropDate; // 0x88
        public System.DateTime dropExpiryDate; // 0x90
        public System.DateTime status; // 0x98
        public string tags; // 0xA0
        public System.Collections.Generic.List`1<string> created_at; // 0xA8
        public System.DateTime updated_at; // 0xB0
        public System.DateTime notificationDetails; // 0xB8
        public ApiBundleDropNotificationDetails <notificationDetails>k__BackingField; // 0xC0

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_authorId(){} // RVA: 0x7FFAC2FE9590
        public void set_authorId(){} // RVA: 0x7FFAC2FE95A0
        public void get_targetGroup(){} // RVA: 0x7FFAC30E5600
        public void set_targetGroup(){} // RVA: 0x7FFAC30E06F0
        public void get_templateIds(){} // RVA: 0x7FFAC32EF410
        public void set_templateIds(){} // RVA: 0x7FFAC34D4AA0
        public void get_startDropDate(){} // RVA: 0x7FFAC2F60010
        public void set_startDropDate(){} // RVA: 0x7FFAC4A2BA70
        public void get_endDropDate(){} // RVA: 0x7FFAC32EF640
        public void set_endDropDate(){} // RVA: 0x7FFAC3705AA0
        public void get_dropExpiryDate(){} // RVA: 0x7FFAC354DFB0
        public void set_dropExpiryDate(){} // RVA: 0x7FFAC7E01AA0
        public void get_status(){} // RVA: 0x7FFAC3543900
        public void set_status(){} // RVA: 0x7FFAC354E420
        public void get_tags(){} // RVA: 0x7FFAC354B1A0
        public void set_tags(){} // RVA: 0x7FFAC334B370
        public void get_created_at(){} // RVA: 0x7FFAC2F8C040
        public void set_created_at(){} // RVA: 0x7FFAC45CA6B0
        public void get_updated_at(){} // RVA: 0x7FFAC2F8C0B0
        public void set_updated_at(){} // RVA: 0x7FFAC45C9F90
        public void get_notificationDetails(){} // RVA: 0x7FFAC2F8C120
        public void set_notificationDetails(){} // RVA: 0x7FFAC2F8C130
        public void FetchCurrentlyActiveBundleDrops(){} // RVA: 0x7FFACBE79BA0
        public void .ctor(){} // RVA: 0x7FFACBE79FE0
    }

    public class ApiInventoryItem : ApiModel
    {
        public string templateId;
        public string name; // 0x68
        public string description; // 0x70
        public string imageUrl; // 0x78
        public string attribution; // 0x80
        public VRC.Core.ApiProductAttribution flags; // 0x88
        public System.Collections.Generic.List`1<string> tags; // 0x90
        public System.Collections.Generic.List`1<string> collections; // 0x98
        public System.Collections.Generic.List`1<string> itemType; // 0xA0
        public string holderId; // 0xA8
        public string firstAncestor; // 0xB0
        public string firstAncestorHolderId; // 0xB8
        public string expiryDate; // 0xC0
        public System.DateTime created_at; // 0xC8
        public System.DateTime updated_at; // 0xD0
        public System.DateTime template_created_at; // 0xD8
        public System.DateTime template_updated_at; // 0xE0
        public System.DateTime isArchived; // 0xE8
        public bool isSeen; // 0xF0
        public bool last_equipped_at; // 0xF1
        public System.DateTime equipSlots; // 0xF8
        public System.Collections.Generic.List`1<string> equipSlot; // 0x100
        public string quantity; // 0x108
        public int quantifiable; // 0x110
        public bool defaultAttributes; // 0x114
        public System.Collections.Generic.Dictionary`2<string,ItemAttribute> userAttributes; // 0x118
        public System.Collections.Generic.Dictionary`2<string,object> validateUserAttributes; // 0x120
        public bool notificationDetails; // 0x128
        public ApiBundleDropNotificationDetails status; // 0x130
        public string metadata; // 0x138
        public VRC.Core.ApiModel Instantiatable; // 0x140
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
        public void .ctor(){} // RVA: 0x7FFACBE7A140
        public void get_templateId(){} // RVA: 0x7FFAC2F9CD50
        public void set_templateId(){} // RVA: 0x7FFAC2F9CD60
        public void get_name(){} // RVA: 0x7FFAC2FE9590
        public void set_name(){} // RVA: 0x7FFAC2FE95A0
        public void get_description(){} // RVA: 0x7FFAC30E5600
        public void set_description(){} // RVA: 0x7FFAC30E06F0
        public void get_imageUrl(){} // RVA: 0x7FFAC32EF410
        public void set_imageUrl(){} // RVA: 0x7FFAC34D4AA0
        public void get_attribution(){} // RVA: 0x7FFAC2F60010
        public void set_attribution(){} // RVA: 0x7FFAC354E300
        public void get_flags(){} // RVA: 0x7FFAC32EF640
        public void set_flags(){} // RVA: 0x7FFAC354E360
        public void get_tags(){} // RVA: 0x7FFAC354DFB0
        public void set_tags(){} // RVA: 0x7FFAC354E3C0
        public void get_collections(){} // RVA: 0x7FFAC3543900
        public void set_collections(){} // RVA: 0x7FFAC354E420
        public void get_itemType(){} // RVA: 0x7FFAC354B1A0
        public void set_itemType(){} // RVA: 0x7FFAC334B370
        public void get_holderId(){} // RVA: 0x7FFAC2F8C040
        public void set_holderId(){} // RVA: 0x7FFAC2F8C050
        public void get_firstAncestor(){} // RVA: 0x7FFAC2F8C0B0
        public void set_firstAncestor(){} // RVA: 0x7FFAC2F8C0C0
        public void get_firstAncestorHolderId(){} // RVA: 0x7FFAC2F8C120
        public void set_firstAncestorHolderId(){} // RVA: 0x7FFAC2F8C130
        public void get_expiryDate(){} // RVA: 0x7FFAC3079460
        public void set_expiryDate(){} // RVA: 0x7FFACB9790D0
        public void get_created_at(){} // RVA: 0x7FFAC303E100
        public void set_created_at(){} // RVA: 0x7FFAC906B850
        public void get_updated_at(){} // RVA: 0x7FFAC3540F70
        public void set_updated_at(){} // RVA: 0x7FFACBE7A200
        public void get_template_created_at(){} // RVA: 0x7FFAC2FA2900
        public void set_template_created_at(){} // RVA: 0x7FFACBE7A210
        public void get_template_updated_at(){} // RVA: 0x7FFAC2FA2970
        public void set_template_updated_at(){} // RVA: 0x7FFAC87AD980
        public void get_isArchived(){} // RVA: 0x7FFAC2FA2AD0
        public void set_isArchived(){} // RVA: 0x7FFAC2FA2AE0
        public void get_isSeen(){} // RVA: 0x7FFAC3E66790
        public void set_isSeen(){} // RVA: 0x7FFAC3E62B70
        public void get_last_equipped_at(){} // RVA: 0x7FFAC3331F50
        public void set_last_equipped_at(){} // RVA: 0x7FFAC6715870
        public void get_equipSlots(){} // RVA: 0x7FFAC34F6C80
        public void set_equipSlots(){} // RVA: 0x7FFAC34F6750
        public void get_equipSlot(){} // RVA: 0x7FFAC36D1F40
        public void set_equipSlot(){} // RVA: 0x7FFAC3929BF0
        public void get_quantity(){} // RVA: 0x7FFAC39471E0
        public void set_quantity(){} // RVA: 0x7FFAC4597C80
        public void get_quantifiable(){} // RVA: 0x7FFACBE7A220
        public void set_quantifiable(){} // RVA: 0x7FFACBE7A230
        public void get_defaultAttributes(){} // RVA: 0x7FFAC33BC6D0
        public void set_defaultAttributes(){} // RVA: 0x7FFAC33B8580
        public void get_userAttributes(){} // RVA: 0x7FFAC313CBB0
        public void set_userAttributes(){} // RVA: 0x7FFAC3143400
        public void get_validateUserAttributes(){} // RVA: 0x7FFAC3331A00
        public void set_validateUserAttributes(){} // RVA: 0x7FFAC332DA60
        public void get_notificationDetails(){} // RVA: 0x7FFAC3544340
        public void set_notificationDetails(){} // RVA: 0x7FFAC39A79B0
        public void get_status(){} // RVA: 0x7FFAC35422C0
        public void set_status(){} // RVA: 0x7FFAC36D84B0
        public void get_metadata(){} // RVA: 0x7FFAC2F8C5F0
        public void set_metadata(){} // RVA: 0x7FFAC2F8C600
        public void get_Instantiatable(){} // RVA: 0x7FFACBE7A240
        public void get_Consumable(){} // RVA: 0x7FFACBE7A2B0
        public void get_Archivable(){} // RVA: 0x7FFACBE7A320
        public void get_Trashable(){} // RVA: 0x7FFACBE7A390
        public void get_Cloneable(){} // RVA: 0x7FFACBE7A400
        public void get_Equippable(){} // RVA: 0x7FFACBE7A470
        public void get_Equipped(){} // RVA: 0x7FFACBE7A500
        public void get_IsUserGenerated(){} // RVA: 0x7FFACBE7A540
        public void get_IsTemplate(){} // RVA: 0x7FFACBE7A5B0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFACBE7A800 | overloaded x2
        public void GetModelForMetadataType(){} // RVA: 0x7FFACBE7AA20
        public void FetchList(){} // RVA: 0x7FFACBE7AFB0
        public void Fetch(){} // RVA: 0x7FFACBE7C400
        public void SetIsArchived(){} // RVA: 0x7FFACBE7C730
        public void SetIsSeen(){} // RVA: 0x7FFACBE7CBC0
        public void Consume(){} // RVA: 0x7FFACBE7D050 | overloaded x2
        public void FetchInventoryTemplate(){} // RVA: 0x7FFACBE7D3D0
        public void FetchInventoryTemplateAsync(){} // RVA: 0x7FFACBE7D700
        public void FetchUserInventoryItem(){} // RVA: 0x7FFACBE7D8A0
        public void Equip(){} // RVA: 0x7FFACBE7DBF0
        public void ClearEquipSlot(){} // RVA: 0x7FFACBE7E230
        public void SaveUserAttributes(){} // RVA: 0x7FFACBE7E520
        public void FetchEquipped(){} // RVA: 0x7FFACBE7EA90
        public void GetAttributes(){} // RVA: 0x7FFACBE7F0A0
        public void GetDefaultAttributes(){} // RVA: 0x7FFACBE7F390
        public void FetchAllTemplates(){} // RVA: 0x7FFACBE7F5D0
    }

    public class ApiInventoryItemContainer : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.ApiInventoryItem> data; // 0x68
        public int totalCount; // 0x70

        // ── Methods ──
        public void get_data(){} // RVA: 0x7FFAC2F9CD50
        public void set_data(){} // RVA: 0x7FFAC2F9CD60
        public void get_totalCount(){} // RVA: 0x7FFAC3B99E80
        public void set_totalCount(){} // RVA: 0x7FFAC30B6520
        public void .ctor(){} // RVA: 0x7FFACBE80CC0
    }

    public class ApiInventoryJweToken : ApiModel
    {
        public string token; // 0x68
        public string ENDPOINT_SPAWN;
        public string ENDPOINT_CLONE_DIRECT;
        public string ENDPOINT_CLONE_PEDESTAL;
        public string ENDPOINT_CLONE_TOKEN;

        // ── Methods ──
        public void get_token(){} // RVA: 0x7FFAC2F9CD50
        public void set_token(){} // RVA: 0x7FFAC2F9CD60
        public void RequestSpawnToken(){} // RVA: 0x7FFACBE80D10
        public void RequestDirectShareToken(){} // RVA: 0x7FFACBE81210
        public void RequestPedestalShareToken(){} // RVA: 0x7FFACBE81760
        public void RequestClone(){} // RVA: 0x7FFACBE81E70
        public void .ctor(){} // RVA: 0x7FFACBE82370
    }

    public class ApiLedgerTransaction : ApiModel
    {
        public int Amount; // 0x68
        public int RunningBalance; // 0x6C
        public System.DateTime Date; // 0x70
        public string ListingDisplayName; // 0x78
        public string ListingID; // 0x80
        public string ListingType; // 0x88
        public string Platform; // 0x90
        public string PurchaseId; // 0x98
        public int Reason; // 0xA0
        public VRC.Core.ApiLocalizableString ReasonLabel; // 0xA8
        public string ToUserId; // 0xB0
        public string ToUserDisplayName; // 0xB8
        public string FromUserId; // 0xC0
        public string FromUserDisplayName; // 0xC8
        public long TransactionId; // 0xD0
        public long TransactionLineId; // 0xD8

        // ── Methods ──
        public void get_Amount(){} // RVA: 0x7FFAC47BAB50
        public void set_Amount(){} // RVA: 0x7FFAC47BAB60
        public void get_RunningBalance(){} // RVA: 0x7FFAC47BAB70
        public void set_RunningBalance(){} // RVA: 0x7FFAC47BAB80
        public void get_Date(){} // RVA: 0x7FFAC2FE9590
        public void set_Date(){} // RVA: 0x7FFAC4A2BA60
        public void get_ListingDisplayName(){} // RVA: 0x7FFAC30E5600
        public void set_ListingDisplayName(){} // RVA: 0x7FFAC30E06F0
        public void get_ListingID(){} // RVA: 0x7FFAC32EF410
        public void set_ListingID(){} // RVA: 0x7FFAC34D4AA0
        public void get_ListingType(){} // RVA: 0x7FFAC2F60010
        public void set_ListingType(){} // RVA: 0x7FFAC354E300
        public void get_Platform(){} // RVA: 0x7FFAC32EF640
        public void set_Platform(){} // RVA: 0x7FFAC354E360
        public void get_PurchaseId(){} // RVA: 0x7FFAC354DFB0
        public void set_PurchaseId(){} // RVA: 0x7FFAC354E3C0
        public void get_Reason(){} // RVA: 0x7FFAC489E510
        public void set_Reason(){} // RVA: 0x7FFAC489E550
        public void get_ReasonLabel(){} // RVA: 0x7FFAC354B1A0
        public void set_ReasonLabel(){} // RVA: 0x7FFAC334B370
        public void get_ToUserId(){} // RVA: 0x7FFAC2F8C040
        public void set_ToUserId(){} // RVA: 0x7FFAC2F8C050
        public void get_ToUserDisplayName(){} // RVA: 0x7FFAC2F8C0B0
        public void set_ToUserDisplayName(){} // RVA: 0x7FFAC2F8C0C0
        public void get_FromUserId(){} // RVA: 0x7FFAC2F8C120
        public void set_FromUserId(){} // RVA: 0x7FFAC2F8C130
        public void get_FromUserDisplayName(){} // RVA: 0x7FFAC3079460
        public void set_FromUserDisplayName(){} // RVA: 0x7FFAC3079470
        public void get_TransactionId(){} // RVA: 0x7FFAC303E100
        public void set_TransactionId(){} // RVA: 0x7FFAC906B850
        public void get_TransactionLineId(){} // RVA: 0x7FFAC3540F70
        public void set_TransactionLineId(){} // RVA: 0x7FFACBE7A200
        public void get_id(){} // RVA: 0x7FFACBE82570
        public void .ctor(){} // RVA: 0x7FFACBE82610
    }

    public class ApiLedgerTransactions : ApiModel
    {
        public System.DateTime StartDate; // 0x68
        public System.DateTime EndDate; // 0x70
        public System.Collections.Generic.List`1<VRC.Core.ApiLedgerTransaction> Transactions; // 0x78

        // ── Methods ──
        public void get_StartDate(){} // RVA: 0x7FFAC2F9CD50
        public void set_StartDate(){} // RVA: 0x7FFAC4A2BA80
        public void get_EndDate(){} // RVA: 0x7FFAC2FE9590
        public void set_EndDate(){} // RVA: 0x7FFAC4A2BA60
        public void get_Transactions(){} // RVA: 0x7FFAC30E5600
        public void set_Transactions(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFACBE82520
    }

    public class ApiLicense : ApiModel
    {
        public string LicenseId; // 0x68
        public string OwnerId; // 0x70
        public string OwnerDisplayName; // 0x78
        public string LicenseHolderId; // 0x80
        public string LicenseHolderDisplayName; // 0x88
        public 0x6B0B5100 ForType; // 0x90
        public string ForId; // 0x98
        public string ProductId; // 0xA0
        public 0x6B0B5158 ProductType; // 0xA8
        public bool IsActive; // 0xAC
        public System.DateTime UntilDate; // 0xB0
        public bool IsCurrent; // 0xB8
        public System.DateTime Created; // 0xC0
        public string ForAction; // 0xC8
        public string ForName; // 0xD0
        public string LicenseHolderType; // 0xD8
        public System.Collections.Generic.List`1<VRC.Core.ApiLicenseNote> Notes; // 0xE0
        public System.Collections.Generic.List`1<string> Tags; // 0xE8
        public System.DateTime Updated; // 0xF0

        // ── Methods ──
        public void get_LicenseId(){} // RVA: 0x7FFAC2F9CD50
        public void set_LicenseId(){} // RVA: 0x7FFAC2F9CD60
        public void get_OwnerId(){} // RVA: 0x7FFAC2FE9590
        public void set_OwnerId(){} // RVA: 0x7FFAC2FE95A0
        public void get_OwnerDisplayName(){} // RVA: 0x7FFAC30E5600
        public void set_OwnerDisplayName(){} // RVA: 0x7FFAC30E06F0
        public void get_LicenseHolderId(){} // RVA: 0x7FFAC32EF410
        public void set_LicenseHolderId(){} // RVA: 0x7FFAC34D4AA0
        public void get_LicenseHolderDisplayName(){} // RVA: 0x7FFAC2F60010
        public void set_LicenseHolderDisplayName(){} // RVA: 0x7FFAC354E300
        public void get_ForType(){} // RVA: 0x7FFAC3220660
        public void set_ForType(){} // RVA: 0x7FFAC34D2750
        public void get_ForId(){} // RVA: 0x7FFAC354DFB0
        public void set_ForId(){} // RVA: 0x7FFAC354E3C0
        public void get_ProductId(){} // RVA: 0x7FFAC3543900
        public void set_ProductId(){} // RVA: 0x7FFAC354E420
        public void get_ProductType(){} // RVA: 0x7FFAC39055C0
        public void set_ProductType(){} // RVA: 0x7FFAC38FD010
        public void get_IsActive(){} // RVA: 0x7FFAC9ACD620
        public void set_IsActive(){} // RVA: 0x7FFAC9ACD630
        public void get_UntilDate(){} // RVA: 0x7FFAC2F8C040
        public void set_UntilDate(){} // RVA: 0x7FFAC45CA6B0
        public void get_IsCurrent(){} // RVA: 0x7FFAC41F1470
        public void set_IsCurrent(){} // RVA: 0x7FFAC41EEB20
        public void get_Created(){} // RVA: 0x7FFAC2F8C120
        public void set_Created(){} // RVA: 0x7FFAC45CA280
        public void get_ForAction(){} // RVA: 0x7FFAC3079460
        public void set_ForAction(){} // RVA: 0x7FFAC3079470
        public void get_ForName(){} // RVA: 0x7FFAC303E100
        public void set_ForName(){} // RVA: 0x7FFAC303E110
        public void get_LicenseHolderType(){} // RVA: 0x7FFAC3540F70
        public void set_LicenseHolderType(){} // RVA: 0x7FFAC2FA28A0
        public void get_Notes(){} // RVA: 0x7FFAC2FA2900
        public void set_Notes(){} // RVA: 0x7FFAC2FA2910
        public void get_Tags(){} // RVA: 0x7FFAC2FA2970
        public void set_Tags(){} // RVA: 0x7FFAC2FA2980
        public void get_Updated(){} // RVA: 0x7FFAC2F8C2A0
        public void set_Updated(){} // RVA: 0x7FFAC47467B0
        public void FetchLicenses(){} // RVA: 0x7FFACBE82660
        public void FetchActiveLicenses(){} // RVA: 0x7FFACBE82960
        public void ReadField(){} // RVA: 0x7FFACBE832B0
        public void WriteField(){} // RVA: 0x7FFACBE836D0
        public void .ctor(){} // RVA: 0x7FFACBE838E0
    }

    public class ApiLicenseNote : ApiModel
    {
        public System.DateTime CreatedAt; // 0x68
        public string Note; // 0x70

        // ── Methods ──
        public void get_CreatedAt(){} // RVA: 0x7FFAC2F9CD50
        public void set_CreatedAt(){} // RVA: 0x7FFAC4A2BA80
        public void get_Note(){} // RVA: 0x7FFAC2FE9590
        public void set_Note(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBE83AB0
    }

    public class ApiListContainer : ApiContainer
    {
        public int ResponseList; // 0x60

        // ── Methods ──
        public void get_ResponseList(){} // RVA: 0x7FFACBECD040
        public void get_TotalCount(){} // RVA: 0x7FFAC3138C20
        public void set_TotalCount(){} // RVA: 0x7FFAC3138C10
        public void Validate(){} // RVA: 0x7FFACBECD0B0
        public void .ctor(){} // RVA: 0x7FFACBECD430
    }

    public class ApiLoadingScreen : ApiModel
    {
        public string name; // 0x68
        public string assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_assetBundleId(){} // RVA: 0x7FFAC2FE9590
        public void set_assetBundleId(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBE83B00
    }

    public class ApiLocalizableString : Object
    {
        public string key; // 0x10
        public string fallback; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
    }

    public class ApiMessage : ApiModel
    {
        public System.Collections.Generic.Dictionary`2<0x6B0AFA08,string> slot;
        public int message;
        public int messageType; // 0x68
        public string updatedAt; // 0x70
        public string remainingCooldownMinutes; // 0x78
        public System.DateTime canBeUpdated; // 0x80
        public int <remainingCooldownMinutes>k__BackingField; // 0x88
        public bool <canBeUpdated>k__BackingField; // 0x8C

        // ── Methods ──
        public void get_slot(){} // RVA: 0x7FFAC47BAB50
        public void set_slot(){} // RVA: 0x7FFAC47BAB60
        public void get_message(){} // RVA: 0x7FFAC2FE9590
        public void set_message(){} // RVA: 0x7FFAC2FE95A0
        public void get_messageType(){} // RVA: 0x7FFAC30E5600
        public void set_messageType(){} // RVA: 0x7FFAC30E06F0
        public void get_updatedAt(){} // RVA: 0x7FFAC32EF410
        public void set_updatedAt(){} // RVA: 0x7FFAC4A2BA90
        public void get_remainingCooldownMinutes(){} // RVA: 0x7FFAC37EE8C0
        public void set_remainingCooldownMinutes(){} // RVA: 0x7FFAC37F9DE0
        public void get_canBeUpdated(){} // RVA: 0x7FFAC2F89520
        public void set_canBeUpdated(){} // RVA: 0x7FFAC2F89530
        public void .ctor(){} // RVA: 0x7FFACBE83B50
        public void FetchMessages(){} // RVA: 0x7FFACBE83D20 | overloaded x2
        public void DeleteAllMessages(){} // RVA: 0x7FFACBE841C0 | overloaded x2
        public void DeleteMessageInSlot(){} // RVA: 0x7FFACBE84680 | overloaded x2
        public void SetMessageInSlot(){} // RVA: 0x7FFACBE84BD0 | overloaded x2
        public void truncatedMessage(){} // RVA: 0x7FFACBE85200
        public void ToString(){} // RVA: 0x7FFACBE85270
        public void .cctor(){} // RVA: 0x7FFACBE85480
    }

    public class ApiModel : Object
    {
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiContainer> id;
        public int ExpiryTime;
        public int Populated; // 0x8
        public Unity.Profiling.ProfilerMarker FailedValidation; // 0x10
        public string Endpoint; // 0x10
        public System.Nullable`1<long> FieldsMissingFromOriginalResponse; // 0x18
        public bool FieldsLockedForNetworkUpdates; // 0x28
        public bool RequiredProperties; // 0x29
        public string TargetProperties; // 0x30
        public string _cacheIdInput; // 0x38
        public string _cacheId; // 0x40
        public System.Text.StringBuilder _cacheIdBuilder; // 0x18
        public System.Collections.Generic.Dictionary`2<int,System.Collections.Generic.HashSet`1<string>> _missingFieldCache; // 0x20
        public System.Collections.Generic.HashSet`1<string> <FieldsMissingFromOriginalResponse>k__BackingField; // 0x48
        public System.Collections.Generic.HashSet`1<string> <FieldsLockedForNetworkUpdates>k__BackingField; // 0x50
        public 0x6B0AFC18 supportedPlatforms; // 0x58
        public int RESPONSE_FIELDS_HASH_OFFSET;
        public int RESPONSE_FIELDS_HASH_MULTIPLIER;
        public System.Type modelContainerType; // 0x60
        public System.Collections.Generic.Dictionary`2<System.Type,System.Reflection.MethodInfo> CreateFromJsonCache; // 0x28
        public System.Collections.Generic.Dictionary`2<System.Type,System.Collections.Generic.Dictionary`2<System.ReadOnlyMemory`1<char>,object>> EnumValuesCache; // 0x30
        public System.Collections.Generic.Dictionary`2<System.Type,System.Collections.Generic.List`1<string>> _requiredProperties; // 0x38
        public System.Collections.Generic.Dictionary`2<System.Type,System.Collections.Generic.List`1<System.Reflection.PropertyInfo>> _targetProperties; // 0x40
        public System.Collections.Generic.Dictionary`2<System.Reflection.PropertyInfo,string> PropertyApiFieldNames; // 0x48
        public System.Collections.Generic.Dictionary`2<System.Type,System.Collections.Generic.Dictionary`2<string,System.Reflection.PropertyInfo>> foundProperties; // 0x50

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFAC2F3C380
        public void set_id(){} // RVA: 0x7FFAC2F22E30
        public void get_ExpiryTime(){} // RVA: 0x7FFAC35D3330
        public void set_ExpiryTime(){} // RVA: 0x7FFAC35D34F0
        public void get_Populated(){} // RVA: 0x7FFAC30F6BA0
        public void set_Populated(){} // RVA: 0x7FFAC3C24F40
        public void get_FailedValidation(){} // RVA: 0x7FFAC386C550
        public void set_FailedValidation(){} // RVA: 0x7FFAC43B4D70
        public void get_Endpoint(){} // RVA: 0x7FFAC31D95E0
        public void set_Endpoint(){} // RVA: 0x7FFAC2F4F890
        public void GetOrPutCachedMissingFieldList(){} // RVA: 0x7FFACBE85990
        public void get_FieldsMissingFromOriginalResponse(){} // RVA: 0x7FFAC2F9C730
        public void set_FieldsMissingFromOriginalResponse(){} // RVA: 0x7FFAC2F9C740
        public void get_FieldsLockedForNetworkUpdates(){} // RVA: 0x7FFAC2FC20E0
        public void set_FieldsLockedForNetworkUpdates(){} // RVA: 0x7FFAC30794D0
        public void GetCacheId(){} // RVA: 0x7FFACBE86270
        public void ComputeCacheId(){} // RVA: 0x7FFACBE86530
        public void ShouldCache(){} // RVA: 0x7FFACBE86940
        public void GetLifeSpan(){} // RVA: 0x7FFACBE86980
        public void .ctor(){} // RVA: 0x7FFACBE86A60 | overloaded x3
        public void Clone(){} // RVA: 0x7FFACBE86CF0 | overloaded x3
        public void Save(){} // RVA: 0x7FFACBE87240
        public void SaveField(){} // RVA: 0x7FFACBE87280
        public void Post(){} // RVA: 0x7FFACBE87550
        public void Put(){} // RVA: 0x7FFACBE87590
        public void Fetch(){} // RVA: 0x7FFACBE875D0
        public void PostAsync(){} // RVA: 0x7FFAC2E8DC40
        public void PutAsync(){} // RVA: 0x7FFAC2E8DC40
        public void FetchAsync(){} // RVA: 0x7FFAC2E8DC40
        public void Get(){} // RVA: 0x7FFACBE87600
        public void PostOrPut(){} // RVA: 0x7FFACBE87E70
        public void Delete(){} // RVA: 0x7FFACBE89650
        public void DeleteAsync(){} // RVA: 0x7FFACBE898F0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFACBE8ABE0 | overloaded x4
        public void PopulateMissingValuesFrom(){} // RVA: 0x7FFACBE8B940
        public void ExtractApiFields(){} // RVA: 0x7FFACBE8BE00
        public void MakeModelContainer(){} // RVA: 0x7FFACBE8C1E0
        public void ReadField(){} // RVA: 0x7FFACBE8C460
        public void TryReadConvert(){} // RVA: 0x7FFACBE8C850
        public void WriteField(){} // RVA: 0x7FFACBE8DD00
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFAC2F21320
        public void GetCreateFromJsonMethodInfo(){} // RVA: 0x7FFACBE8EC80
        public void ParseEnumValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void IsNumber(){} // RVA: 0x7FFACBE8F270
        public void DoubleCast(){} // RVA: 0x7FFACBE8F320
        public void TryWriteConvert(){} // RVA: 0x7FFACBE8F6F0
        public void ParseList(){} // RVA: 0x7FFACBE90800
        public void ParseDictionary(){} // RVA: 0x7FFACBE90CC0
        public void ParseModel(){} // RVA: 0x7FFACBE914C0
        public void ParseLocalizableString(){} // RVA: 0x7FFACBE91710
        public void SendGetRequest(){} // RVA: 0x7FFACBE918F0
        public void SendPutRequest(){} // RVA: 0x7FFACBE91BA0
        public void MakeRequestEndpoint(){} // RVA: 0x7FFACBE91C70
        public void get_RequiredProperties(){} // RVA: 0x7FFACBE91D20
        public void get_TargetProperties(){} // RVA: 0x7FFACBE92360
        public void FindPropertyName(){} // RVA: 0x7FFACBE92780
        public void FindProperty(){} // RVA: 0x7FFACBE92A90
        public void IsAdminWritableOnly(){} // RVA: 0x7FFACBE92F80
        public void IsApiWritableOnly(){} // RVA: 0x7FFACBE93170
        public void .cctor(){} // RVA: 0x7FFACBE93360
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFAC2C59D00
        public void Validate(){}
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public System.Collections.Generic.IReadOnlyList`1<T> ResponseModels;

        // ── Methods ──
        public void get_ResponseModels(){} // RVA: 0x7FFAC2C58E90
        public void set_ResponseModels(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Validate(){}
    }

    public class ApiModeration : ApiModel
    {
        public float moderationType;
        public 0x6B0B0198 moderatorUserId; // 0x68
        public string moderatorDisplayName; // 0x70
        public string targetUserId; // 0x78
        public string targetDisplayName; // 0x80
        public string reasonMessage; // 0x88
        public string details; // 0x90
        public System.Collections.Generic.Dictionary`2<string,object> created; // 0x98
        public System.DateTime expires; // 0xA0
        public System.DateTime isPermanent; // 0xA8
        public System.Nullable`1<0x6B0B01F0> worldId; // 0xB0
        public bool instanceId; // 0xB8
        public string <worldId>k__BackingField; // 0xC0
        public string <instanceId>k__BackingField; // 0xC8

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7FFAC47BAB50
        public void set_moderationType(){} // RVA: 0x7FFAC47BAB60
        public void get_moderatorUserId(){} // RVA: 0x7FFAC2FE9590
        public void set_moderatorUserId(){} // RVA: 0x7FFAC2FE95A0
        public void get_moderatorDisplayName(){} // RVA: 0x7FFAC30E5600
        public void set_moderatorDisplayName(){} // RVA: 0x7FFAC30E06F0
        public void get_targetUserId(){} // RVA: 0x7FFAC32EF410
        public void set_targetUserId(){} // RVA: 0x7FFAC34D4AA0
        public void get_targetDisplayName(){} // RVA: 0x7FFAC2F60010
        public void set_targetDisplayName(){} // RVA: 0x7FFAC354E300
        public void get_reasonMessage(){} // RVA: 0x7FFAC32EF640
        public void set_reasonMessage(){} // RVA: 0x7FFAC354E360
        public void get_details(){} // RVA: 0x7FFAC354DFB0
        public void set_details(){} // RVA: 0x7FFAC354E3C0
        public void get_created(){} // RVA: 0x7FFAC3543900
        public void set_created(){} // RVA: 0x7FFAC878D950
        public void get_expires(){} // RVA: 0x7FFAC354B1A0
        public void set_expires(){} // RVA: 0x7FFAC45C9F60
        public void get_isPermanent(){} // RVA: 0x7FFAC41F1470
        public void set_isPermanent(){} // RVA: 0x7FFAC41EEB20
        public void get_worldId(){} // RVA: 0x7FFAC2F8C120
        public void set_worldId(){} // RVA: 0x7FFAC2F8C130
        public void get_instanceId(){} // RVA: 0x7FFAC3079460
        public void set_instanceId(){} // RVA: 0x7FFAC3079470
        public void .ctor(){} // RVA: 0x7FFACBE94A60 | overloaded x2
        public void ShouldCache(){} // RVA: 0x7FFAC2F21320
        public void ReadField(){} // RVA: 0x7FFACBE94B00
        public void WriteField(){} // RVA: 0x7FFACBE94F80
        public void SendModeration(){} // RVA: 0x7FFACBE951B0
        public void SendVoteKick(){} // RVA: 0x7FFACBE95570
        public void DeleteModeration(){} // RVA: 0x7FFACBE958A0
        public void LocalFetchAll(){} // RVA: 0x7FFACBE95AC0
        public void ModerationTimeRangeToString(){} // RVA: 0x7FFACBE95DC0
        public void ContestModeration(){} // RVA: 0x7FFACBE95E60
    }

    public class ApiModerationResult : Object
    {
        public string[] fields; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ApiModerationResultExtensions : Object
    {
        // ── Methods ──
        public void WasModerated(){} // RVA: 0x7FFACBE96470
        public void GetModerationResult(){} // RVA: 0x7FFACBE96490
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
        public void get_id(){} // RVA: 0x7FFAC2F3C380
        public void set_id(){} // RVA: 0x7FFAC2F22E30
        public void get_displayName(){} // RVA: 0x7FFAC2F9CD50
        public void set_displayName(){} // RVA: 0x7FFAC2F9CD60
        public void get_status(){} // RVA: 0x7FFAC2FE9590
        public void set_status(){} // RVA: 0x7FFAC2FE95A0
        public void get_statusDescription(){} // RVA: 0x7FFAC30E5600
        public void set_statusDescription(){} // RVA: 0x7FFAC30E06F0
        public void get_currentAvatarImageUrl(){} // RVA: 0x7FFAC32EF410
        public void set_currentAvatarImageUrl(){} // RVA: 0x7FFAC34D4AA0
        public void get_avatarThumbnail(){} // RVA: 0x7FFAC2F60010
        public void set_avatarThumbnail(){} // RVA: 0x7FFAC354E300
        public void get_currentAvatarTags(){} // RVA: 0x7FFAC32EF640
        public void set_currentAvatarTags(){} // RVA: 0x7FFAC354E360
        public void get_profilePicOverride(){} // RVA: 0x7FFAC354DFB0
        public void set_profilePicOverride(){} // RVA: 0x7FFAC354E3C0
        public void get_userIcon(){} // RVA: 0x7FFAC3543900
        public void set_userIcon(){} // RVA: 0x7FFAC354E420
        public void get_world(){} // RVA: 0x7FFAC354B1A0
        public void set_world(){} // RVA: 0x7FFAC334B370
        public void get_instance(){} // RVA: 0x7FFAC2F8C040
        public void set_instance(){} // RVA: 0x7FFAC2F8C050
        public void get_instanceType(){} // RVA: 0x7FFAC2F8C0B0
        public void set_instanceType(){} // RVA: 0x7FFAC2F8C0C0
        public void get_travelingToWorld(){} // RVA: 0x7FFAC2F8C120
        public void set_travelingToWorld(){} // RVA: 0x7FFAC2F8C130
        public void get_travelingToInstance(){} // RVA: 0x7FFAC3079460
        public void set_travelingToInstance(){} // RVA: 0x7FFAC3079470
        public void get_platform(){} // RVA: 0x7FFAC303E100
        public void set_platform(){} // RVA: 0x7FFAC303E110
        public void get_groups(){} // RVA: 0x7FFAC3540F70
        public void set_groups(){} // RVA: 0x7FFAC2FA28A0
        public void get_profilePicImageUrl(){} // RVA: 0x7FFACBF24D40
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x7FFACBF24D60
        public void FetchMutualFriendsAsync(){} // RVA: 0x7FFACBF24D90
        public void .ctor(){} // RVA: 0x7FFACBF24F60
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
        public void get_id(){} // RVA: 0x7FFAC2F3C380
        public void set_id(){} // RVA: 0x7FFAC2F22E30
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_discriminator(){} // RVA: 0x7FFAC2FE9590
        public void set_discriminator(){} // RVA: 0x7FFAC2FE95A0
        public void get_ownerId(){} // RVA: 0x7FFAC30E5600
        public void set_ownerId(){} // RVA: 0x7FFAC30E06F0
        public void get_privacy(){} // RVA: 0x7FFAC32EF410
        public void set_privacy(){} // RVA: 0x7FFAC34D4AA0
        public void get_memberCount(){} // RVA: 0x7FFAC37EE8C0
        public void set_memberCount(){} // RVA: 0x7FFAC37F9DE0
        public void get_shortCode(){} // RVA: 0x7FFAC32EF640
        public void set_shortCode(){} // RVA: 0x7FFAC354E360
        public void get_description(){} // RVA: 0x7FFAC354DFB0
        public void set_description(){} // RVA: 0x7FFAC354E3C0
        public void get_bannerId(){} // RVA: 0x7FFAC3543900
        public void set_bannerId(){} // RVA: 0x7FFAC354E420
        public void get_bannerUrl(){} // RVA: 0x7FFAC354B1A0
        public void set_bannerUrl(){} // RVA: 0x7FFAC334B370
        public void get_iconId(){} // RVA: 0x7FFAC2F8C040
        public void set_iconId(){} // RVA: 0x7FFAC2F8C050
        public void get_iconUrl(){} // RVA: 0x7FFAC2F8C0B0
        public void set_iconUrl(){} // RVA: 0x7FFAC2F8C0C0
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFAC2F8C120
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFAC2F8C130
        public void FetchMutualGroupsAsync(){} // RVA: 0x7FFACBF25C40
        public void .ctor(){} // RVA: 0x7FFACBF25E10
    }

    public class ApiNotification : ApiModel
    {
        public int version; // 0x68
        public 0x6B0B0508 notificationType; // 0x6C
        public string category; // 0x70
        public bool isSystem; // 0x78
        public string senderUserId; // 0x80
        public string senderUsername; // 0x88
        public string receiverUserId; // 0x90
        public string relatedNotificationsId; // 0x98
        public string title; // 0xA0
        public string titleKey; // 0xA8
        public string message; // 0xB0
        public string messageKey; // 0xB8
        public string imageUrl; // 0xC0
        public string link; // 0xC8
        public string linkText; // 0xD0
        public string linkTextKey; // 0xD8
        public object[] responses; // 0xE0
        public System.DateTime expiresAt; // 0xE8
        public System.Nullable`1<int> expiryAfterSeen; // 0xF0
        public bool seen; // 0xF8
        public bool ignoreDND; // 0xF9
        public bool canDelete; // 0xFA
        public System.DateTime created_at; // 0x100
        public System.DateTime createdAt; // 0x108
        public System.DateTime updatedAt; // 0x110
        public System.Collections.Generic.Dictionary`2<string,object> details; // 0x118
        public System.Collections.Generic.Dictionary`2<string,string> data; // 0x120
        public string jobName; // 0x128
        public string jobColor; // 0x130

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFAC47BAB50
        public void set_version(){} // RVA: 0x7FFAC47BAB60
        public void get_notificationType(){} // RVA: 0x7FFAC47BAB70
        public void set_notificationType(){} // RVA: 0x7FFAC47BAB80
        public void get_category(){} // RVA: 0x7FFAC2FE9590
        public void set_category(){} // RVA: 0x7FFAC2FE95A0
        public void get_isSystem(){} // RVA: 0x7FFAC33CE5C0
        public void set_isSystem(){} // RVA: 0x7FFAC3D20B50
        public void get_senderUserId(){} // RVA: 0x7FFAC32EF410
        public void set_senderUserId(){} // RVA: 0x7FFAC34D4AA0
        public void get_senderUsername(){} // RVA: 0x7FFAC2F60010
        public void set_senderUsername(){} // RVA: 0x7FFAC354E300
        public void get_receiverUserId(){} // RVA: 0x7FFAC32EF640
        public void set_receiverUserId(){} // RVA: 0x7FFAC354E360
        public void get_relatedNotificationsId(){} // RVA: 0x7FFAC354DFB0
        public void set_relatedNotificationsId(){} // RVA: 0x7FFAC354E3C0
        public void get_title(){} // RVA: 0x7FFAC3543900
        public void set_title(){} // RVA: 0x7FFAC354E420
        public void get_titleKey(){} // RVA: 0x7FFAC354B1A0
        public void set_titleKey(){} // RVA: 0x7FFAC334B370
        public void get_message(){} // RVA: 0x7FFAC2F8C040
        public void set_message(){} // RVA: 0x7FFAC2F8C050
        public void get_messageKey(){} // RVA: 0x7FFAC2F8C0B0
        public void set_messageKey(){} // RVA: 0x7FFAC2F8C0C0
        public void get_imageUrl(){} // RVA: 0x7FFAC2F8C120
        public void set_imageUrl(){} // RVA: 0x7FFAC2F8C130
        public void get_link(){} // RVA: 0x7FFAC3079460
        public void set_link(){} // RVA: 0x7FFAC3079470
        public void get_linkText(){} // RVA: 0x7FFAC303E100
        public void set_linkText(){} // RVA: 0x7FFAC303E110
        public void get_linkTextKey(){} // RVA: 0x7FFAC3540F70
        public void set_linkTextKey(){} // RVA: 0x7FFAC2FA28A0
        public void get_responses(){} // RVA: 0x7FFAC2FA2900
        public void set_responses(){} // RVA: 0x7FFAC2FA2910
        public void get_expiresAt(){} // RVA: 0x7FFAC2FA2970
        public void set_expiresAt(){} // RVA: 0x7FFAC87AD980
        public void get_expiryAfterSeen(){} // RVA: 0x7FFAC2F8C2A0
        public void set_expiryAfterSeen(){} // RVA: 0x7FFAC47467B0
        public void get_seen(){} // RVA: 0x7FFAC3C8E090
        public void set_seen(){} // RVA: 0x7FFAC97AF8F0
        public void get_ignoreDND(){} // RVA: 0x7FFAC2F7DF90
        public void set_ignoreDND(){} // RVA: 0x7FFAC2F7DFA0
        public void get_canDelete(){} // RVA: 0x7FFACB978DB0
        public void set_canDelete(){} // RVA: 0x7FFACB9790C0
        public void get_created_at(){} // RVA: 0x7FFAC34F6C80
        public void set_created_at(){} // RVA: 0x7FFAC4196020
        public void get_createdAt(){} // RVA: 0x7FFAC36D1F40
        public void set_createdAt(){} // RVA: 0x7FFACBE64CE0
        public void get_updatedAt(){} // RVA: 0x7FFAC354B170
        public void set_updatedAt(){} // RVA: 0x7FFAC8B66FB0
        public void get_details(){} // RVA: 0x7FFAC33BC6D0
        public void set_details(){} // RVA: 0x7FFAC33B8580
        public void get_data(){} // RVA: 0x7FFAC313CBB0
        public void set_data(){} // RVA: 0x7FFAC3143400
        public void get_jobName(){} // RVA: 0x7FFAC35466F0
        public void set_jobName(){} // RVA: 0x7FFAC39C51C0
        public void get_jobColor(){} // RVA: 0x7FFAC3544340
        public void set_jobColor(){} // RVA: 0x7FFAC39A79B0
        public void .ctor(){} // RVA: 0x7FFACBE96770
        public void ShouldCache(){} // RVA: 0x7FFAC2F21320
        public void ReadField(){} // RVA: 0x7FFACBE96810
        public void WriteField(){} // RVA: 0x7FFACBE96A50
    }

    public class ApiPagedTransactions : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.ApiTransaction> Transactions; // 0x68
        public int TotalCount; // 0x70

        // ── Methods ──
        public void get_Transactions(){} // RVA: 0x7FFAC2F9CD50
        public void set_Transactions(){} // RVA: 0x7FFAC2F9CD60
        public void get_TotalCount(){} // RVA: 0x7FFAC3B99E80
        public void set_TotalCount(){} // RVA: 0x7FFAC30B6520
        public void FetchTransactions(){} // RVA: 0x7FFACBED3BF0
        public void .ctor(){} // RVA: 0x7FFACBED4CF0
    }

    public class ApiPendingTransaction : ApiModel
    {
        public string userId; // 0x68
        public string userDisplayName; // 0x70
        public string targetUserId; // 0x78
        public string targetDisplayName; // 0x80
        public string status; // 0x88
        public Pico pico; // 0x90
        public GPlay gplay; // 0x98
        public Subscription subscription; // 0xA0
        public string created_at; // 0xA8
        public string updated_at; // 0xB0
        public bool isGift; // 0xB8
        public bool isTokens; // 0xB9

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFAC2F9CD50
        public void set_userId(){} // RVA: 0x7FFAC2F9CD60
        public void get_userDisplayName(){} // RVA: 0x7FFAC2FE9590
        public void set_userDisplayName(){} // RVA: 0x7FFAC2FE95A0
        public void get_targetUserId(){} // RVA: 0x7FFAC30E5600
        public void set_targetUserId(){} // RVA: 0x7FFAC30E06F0
        public void get_targetDisplayName(){} // RVA: 0x7FFAC32EF410
        public void set_targetDisplayName(){} // RVA: 0x7FFAC34D4AA0
        public void get_status(){} // RVA: 0x7FFAC2F60010
        public void set_status(){} // RVA: 0x7FFAC354E300
        public void get_pico(){} // RVA: 0x7FFAC32EF640
        public void set_pico(){} // RVA: 0x7FFAC354E360
        public void get_gplay(){} // RVA: 0x7FFAC354DFB0
        public void set_gplay(){} // RVA: 0x7FFAC354E3C0
        public void get_subscription(){} // RVA: 0x7FFAC3543900
        public void set_subscription(){} // RVA: 0x7FFAC354E420
        public void get_created_at(){} // RVA: 0x7FFAC354B1A0
        public void set_created_at(){} // RVA: 0x7FFAC334B370
        public void get_updated_at(){} // RVA: 0x7FFAC2F8C040
        public void set_updated_at(){} // RVA: 0x7FFAC2F8C050
        public void get_isGift(){} // RVA: 0x7FFAC41F1470
        public void set_isGift(){} // RVA: 0x7FFAC41EEB20
        public void get_isTokens(){} // RVA: 0x7FFAC623E950
        public void set_isTokens(){} // RVA: 0x7FFAC623E960
        public void .ctor(){} // RVA: 0x7FFACBEF0F00
    }

    public class ApiPlayerModeration : ApiModel
    {
        public float moderationType;
        public 0x6B0B05B8 targetUserId; // 0x68
        public string targetDisplayName; // 0x70
        public string sourceUserId; // 0x78
        public string sourceDisplayName; // 0x80
        public string created; // 0x88
        public System.DateTime <created>k__BackingField; // 0x90

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7FFAC47BAB50
        public void set_moderationType(){} // RVA: 0x7FFAC47BAB60
        public void get_targetUserId(){} // RVA: 0x7FFAC2FE9590
        public void set_targetUserId(){} // RVA: 0x7FFAC2FE95A0
        public void get_targetDisplayName(){} // RVA: 0x7FFAC30E5600
        public void set_targetDisplayName(){} // RVA: 0x7FFAC30E06F0
        public void get_sourceUserId(){} // RVA: 0x7FFAC32EF410
        public void set_sourceUserId(){} // RVA: 0x7FFAC34D4AA0
        public void get_sourceDisplayName(){} // RVA: 0x7FFAC2F60010
        public void set_sourceDisplayName(){} // RVA: 0x7FFAC354E300
        public void get_created(){} // RVA: 0x7FFAC32EF640
        public void set_created(){} // RVA: 0x7FFAC3705AA0
        public void .ctor(){} // RVA: 0x7FFACBE96BA0
        public void CreateRemovalModeration(){} // RVA: 0x7FFACBE96C60
        public void ShouldCache(){} // RVA: 0x7FFAC2F21320
        public void ReadField(){} // RVA: 0x7FFACBE96D20
        public void WriteField(){} // RVA: 0x7FFACBE96F20
        public void SendModeration(){} // RVA: 0x7FFACBE97100
        public void DeleteModeration(){} // RVA: 0x7FFACBE97340
        public void FetchAllAgainstMe(){} // RVA: 0x7FFACBE97900
        public void FetchAllMine(){} // RVA: 0x7FFACBE97950
        public void FetchList(){} // RVA: 0x7FFACBE979A0
        public void ModerationTypeToAPIString(){} // RVA: 0x7FFACBE97C80
    }

    public class ApiPortalSkin : ApiModel
    {
        public string name; // 0x68
        public string assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_assetBundleId(){} // RVA: 0x7FFAC2FE9590
        public void set_assetBundleId(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBE98150
    }

    public class ApiPrint : ApiModel
    {
        public string note; // 0x68
        public string authorId; // 0x70
        public string authorName; // 0x78
        public string worldId; // 0x80
        public string worldName; // 0x88
        public string ownerId; // 0x90
        public System.DateTime timestamp; // 0x98
        public PrintFile files; // 0xA0
        public System.DateTime createdAt; // 0xA8

        // ── Methods ──
        public void get_note(){} // RVA: 0x7FFAC2F9CD50
        public void set_note(){} // RVA: 0x7FFAC2F9CD60
        public void get_authorId(){} // RVA: 0x7FFAC2FE9590
        public void set_authorId(){} // RVA: 0x7FFAC2FE95A0
        public void get_authorName(){} // RVA: 0x7FFAC30E5600
        public void set_authorName(){} // RVA: 0x7FFAC30E06F0
        public void get_worldId(){} // RVA: 0x7FFAC32EF410
        public void set_worldId(){} // RVA: 0x7FFAC34D4AA0
        public void get_worldName(){} // RVA: 0x7FFAC2F60010
        public void set_worldName(){} // RVA: 0x7FFAC354E300
        public void get_ownerId(){} // RVA: 0x7FFAC32EF640
        public void set_ownerId(){} // RVA: 0x7FFAC354E360
        public void get_timestamp(){} // RVA: 0x7FFAC354DFB0
        public void set_timestamp(){} // RVA: 0x7FFAC7E01AA0
        public void get_files(){} // RVA: 0x7FFAC3543900
        public void set_files(){} // RVA: 0x7FFAC354E420
        public void get_createdAt(){} // RVA: 0x7FFAC354B1A0
        public void set_createdAt(){} // RVA: 0x7FFAC45C9F60
        public void .ctor(){} // RVA: 0x7FFACBE981A0
        public void GetFileURL(){} // RVA: 0x7FFACBE982A0
        public void GetImageURL(){} // RVA: 0x7FFACBE982C0
        public void Upload(){} // RVA: 0x7FFACBE98310
        public void UpdatePrint(){} // RVA: 0x7FFACBE98830
        public void GetPrints(){} // RVA: 0x7FFACBE98C90
        public void GetPrint(){} // RVA: 0x7FFACBE991D0
    }

    public class ApiProduct : ApiModel
    {
        public 0x6B0B5158 Type; // 0x68
        public System.DateTime CreatedAt; // 0x70
        public System.DateTime UpdatedAt; // 0x78
        public string SellerId; // 0x80
        public string AvatarId; // 0x88
        public string SellerDisplayName; // 0x90
        public string Name; // 0x98
        public string Description; // 0xA0
        public string Subtitle; // 0xA8
        public string ProductImageId; // 0xB0
        public VRC.Core.ApiProductAttribution ProductImageUrl; // 0xB8
        public string attribution; // 0xC0
        public System.Collections.Generic.List`1<string> LicenseId; // 0xC8
        public bool Tags; // 0xD0
        public System.DateTime SoldByVrc; // 0xD8
        public System.Collections.Generic.Dictionary`2<string,object> UntilDate; // 0xE0
        public bool PurchaseToken; // 0xE8
        public System.Collections.Generic.List`1<string> IsVoided; // 0xF0
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
        public 0x6B0B51B0 ListingID; // 0x140
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> ListingType; // 0x148
        public System.Collections.Generic.List`1<string> Products; // 0x150
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> ProductIDs; // 0x158
        public bool HydratedProducts; // 0x160
        public bool Active; // 0x161
        public int SubscriberExclusive; // 0x164
        public int Price; // 0x168
        public System.DateTime VrcPlusDiscountPrice; // 0x170
        public string AvailableToPurchaseUntilDate; // 0x178
        public string CollaboratorUserId; // 0x180
        public System.Nullable`1<int> CollaboratorUserDisplayName; // 0x188
        public System.Collections.Generic.List`1<string> Stock; // 0x190
        public int StoreIDs; // 0x198
        public 0x6B0B5208 Duration; // 0x19C
        public bool DurationType; // 0x1A0
        public bool Archived; // 0x1A1
        public bool Permanent; // 0x1A2
        public bool Instant; // 0x1A3
        public bool Stackable; // 0x1A4
        public bool Recurrable; // 0x1A5
        public bool Refundable; // 0x1A6
        public bool BuyerRefundable; // 0x1A7
        public System.Collections.Generic.List`1<VRC.Core.ApiProductVariant> ContextPreventsPurchase; // 0x1A8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBEC21E0
        public void get_Type(){} // RVA: 0x7FFAC47BAB50
        public void set_Type(){} // RVA: 0x7FFAC47BAB60
        public void get_CreatedAt(){} // RVA: 0x7FFAC2FE9590
        public void set_CreatedAt(){} // RVA: 0x7FFAC4A2BA60
        public void get_UpdatedAt(){} // RVA: 0x7FFAC30E5600
        public void set_UpdatedAt(){} // RVA: 0x7FFAC8246500
        public void get_SellerId(){} // RVA: 0x7FFAC32EF410
        public void set_SellerId(){} // RVA: 0x7FFAC34D4AA0
        public void get_AvatarId(){} // RVA: 0x7FFAC2F60010
        public void set_AvatarId(){} // RVA: 0x7FFAC354E300
        public void get_SellerDisplayName(){} // RVA: 0x7FFAC32EF640
        public void set_SellerDisplayName(){} // RVA: 0x7FFAC354E360
        public void get_Name(){} // RVA: 0x7FFAC354DFB0
        public void set_Name(){} // RVA: 0x7FFAC354E3C0
        public void get_Description(){} // RVA: 0x7FFAC3543900
        public void set_Description(){} // RVA: 0x7FFAC354E420
        public void get_Subtitle(){} // RVA: 0x7FFAC354B1A0
        public void set_Subtitle(){} // RVA: 0x7FFAC334B370
        public void get_ProductImageId(){} // RVA: 0x7FFAC2F8C040
        public void set_ProductImageId(){} // RVA: 0x7FFAC2F8C050
        public void get_ProductImageUrl(){} // RVA: 0x7FFACBEC22A0
        public void get_attribution(){} // RVA: 0x7FFAC2F8C0B0
        public void set_attribution(){} // RVA: 0x7FFAC2F8C0C0
        public void get_LicenseId(){} // RVA: 0x7FFAC2F8C120
        public void set_LicenseId(){} // RVA: 0x7FFAC2F8C130
        public void get_Tags(){} // RVA: 0x7FFAC3079460
        public void set_Tags(){} // RVA: 0x7FFAC3079470
        public void get_SoldByVrc(){} // RVA: 0x7FFAC33CFDE0
        public void set_SoldByVrc(){} // RVA: 0x7FFAC4323510
        public void get_UntilDate(){} // RVA: 0x7FFAC3540F70
        public void set_UntilDate(){} // RVA: 0x7FFACBE7A200
        public void get_PurchaseToken(){} // RVA: 0x7FFAC2FA2900
        public void set_PurchaseToken(){} // RVA: 0x7FFAC2FA2910
        public void get_IsVoided(){} // RVA: 0x7FFAC3FD4640
        public void set_IsVoided(){} // RVA: 0x7FFAC499C5B0
        public void get_ParentListings(){} // RVA: 0x7FFAC2F8C2A0
        public void set_ParentListings(){} // RVA: 0x7FFAC2F8C2B0
        public void get_ProductTypeLabel(){} // RVA: 0x7FFAC3331F50
        public void set_ProductTypeLabel(){} // RVA: 0x7FFAC34A4860
        public void get_Quantifiable(){} // RVA: 0x7FFAC3C8B9C0
        public void set_Quantifiable(){} // RVA: 0x7FFAC3C8DFF0
        public void get_GroupId(){} // RVA: 0x7FFAC36D1F40
        public void set_GroupId(){} // RVA: 0x7FFAC3929BF0
        public void get_GroupRoleId(){} // RVA: 0x7FFAC354B170
        public void set_GroupRoleId(){} // RVA: 0x7FFAC39B3E10
        public void get_GroupAccess(){} // RVA: 0x7FFACBEC2310
        public void set_GroupAccess(){} // RVA: 0x7FFACBEC2320
        public void get_GroupAccessRemove(){} // RVA: 0x7FFACBEC2330
        public void set_GroupAccessRemove(){} // RVA: 0x7FFACBEC2340
        public void get_InventoryItemTemplateId(){} // RVA: 0x7FFAC313CBB0
        public void set_InventoryItemTemplateId(){} // RVA: 0x7FFAC3143400
        public void get_InventoryItemType(){} // RVA: 0x7FFAC35466F0
        public void set_InventoryItemType(){} // RVA: 0x7FFAC39C51C0
        public void get_InventoryItemQuantity(){} // RVA: 0x7FFAC33BC1B0
        public void set_InventoryItemQuantity(){} // RVA: 0x7FFAC955CD90
        public void get_AssetDisabled(){} // RVA: 0x7FFACBEC2350
        public void set_AssetDisabled(){} // RVA: 0x7FFACBEC2360
        public void get_ListingID(){} // RVA: 0x7FFAC35422C0
        public void set_ListingID(){} // RVA: 0x7FFAC36D84B0
        public void get_ListingType(){} // RVA: 0x7FFAC40A0C00
        public void set_ListingType(){} // RVA: 0x7FFAC4091D60
        public void get_Products(){} // RVA: 0x7FFAC2F8C660
        public void set_Products(){} // RVA: 0x7FFAC2F8C670
        public void get_ProductIDs(){} // RVA: 0x7FFAC354DFA0
        public void set_ProductIDs(){} // RVA: 0x7FFAC39B99C0
        public void get_HydratedProducts(){} // RVA: 0x7FFAC3542410
        public void set_HydratedProducts(){} // RVA: 0x7FFAC39A74B0
        public void get_Active(){} // RVA: 0x7FFAC8A119B0
        public void set_Active(){} // RVA: 0x7FFAC8A119C0
        public void get_SubscriberExclusive(){} // RVA: 0x7FFAC8A119D0
        public void set_SubscriberExclusive(){} // RVA: 0x7FFAC8A119E0
        public void get_Price(){} // RVA: 0x7FFACBEC2370
        public void set_Price(){} // RVA: 0x7FFACBEC2380
        public void get_VrcPlusDiscountPrice(){} // RVA: 0x7FFAC9C7AB00
        public void set_VrcPlusDiscountPrice(){} // RVA: 0x7FFAC9C7AB10
        public void get_AvailableToPurchaseUntilDate(){} // RVA: 0x7FFAC336D850
        public void set_AvailableToPurchaseUntilDate(){} // RVA: 0x7FFACBEC2390
        public void get_CollaboratorUserId(){} // RVA: 0x7FFAC336D860
        public void set_CollaboratorUserId(){} // RVA: 0x7FFAC39CA130
        public void get_CollaboratorUserDisplayName(){} // RVA: 0x7FFAC354B1B0
        public void set_CollaboratorUserDisplayName(){} // RVA: 0x7FFAC3503070
        public void get_Stock(){} // RVA: 0x7FFAC35410C0
        public void set_Stock(){} // RVA: 0x7FFAC8C694D0
        public void get_StoreIDs(){} // RVA: 0x7FFAC3540F60
        public void set_StoreIDs(){} // RVA: 0x7FFAC39AB1D0
        public void get_Duration(){} // RVA: 0x7FFAC9645C90
        public void set_Duration(){} // RVA: 0x7FFAC9645CA0
        public void get_DurationType(){} // RVA: 0x7FFAC30EF4E0
        public void set_DurationType(){} // RVA: 0x7FFAC33B1990
        public void get_Archived(){} // RVA: 0x7FFACBEC23A0
        public void set_Archived(){} // RVA: 0x7FFACBEC23B0
        public void get_Permanent(){} // RVA: 0x7FFACBEC23C0
        public void set_Permanent(){} // RVA: 0x7FFACBEC23D0
        public void get_Instant(){} // RVA: 0x7FFACBEC23E0
        public void set_Instant(){} // RVA: 0x7FFACBEC23F0
        public void get_Stackable(){} // RVA: 0x7FFACBEC2400
        public void set_Stackable(){} // RVA: 0x7FFACBEC2410
        public void get_Recurrable(){} // RVA: 0x7FFACBEC2420
        public void set_Recurrable(){} // RVA: 0x7FFACBEC2430
        public void get_Refundable(){} // RVA: 0x7FFACBEC2440
        public void set_Refundable(){} // RVA: 0x7FFACBEC2450
        public void get_BuyerRefundable(){} // RVA: 0x7FFACBEC2460
        public void set_BuyerRefundable(){} // RVA: 0x7FFACBEC2470
        public void get_ContextPreventsPurchase(){} // RVA: 0x7FFACBEC2480
        public void set_ContextPreventsPurchase(){} // RVA: 0x7FFACBEC2490
        public void get_ListingVariants(){} // RVA: 0x7FFAC3548F80
        public void set_ListingVariants(){} // RVA: 0x7FFAC39B4D10
        public void Purchase(){} // RVA: 0x7FFACBEC24A0
        public void ReadField(){} // RVA: 0x7FFACBEC36A0
        public void WriteField(){} // RVA: 0x7FFACBEC3AC0
        public void FetchListing(){} // RVA: 0x7FFACBEC3F60
        public void FetchFullListing(){} // RVA: 0x7FFACBEC4470
        public void FetchOwnListings(){} // RVA: 0x7FFACBEC4980
        public void FetchOwnProducts(){} // RVA: 0x7FFACBEC4E50
    }

    public class ApiProductAttribution : ApiModel
    {
        public VRC.Core.ApiProductCreator creator; // 0x68
        public VRC.Core.ApiProductPublisher publisher; // 0x70
        public string collaborationId; // 0x78

        // ── Methods ──
        public void get_creator(){} // RVA: 0x7FFAC2F9CD50
        public void set_creator(){} // RVA: 0x7FFAC2F9CD60
        public void get_publisher(){} // RVA: 0x7FFAC2FE9590
        public void set_publisher(){} // RVA: 0x7FFAC2FE95A0
        public void get_collaborationId(){} // RVA: 0x7FFAC30E5600
        public void set_collaborationId(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFACBF21210
    }

    public class ApiProductCreator : ApiModel
    {
        public string userId; // 0x68
        public string customName; // 0x70

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFAC2F9CD50
        public void set_userId(){} // RVA: 0x7FFAC2F9CD60
        public void get_customName(){} // RVA: 0x7FFAC2FE9590
        public void set_customName(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBF21260
    }

    public class ApiProductPublisher : ApiModel
    {
        public string userId; // 0x68
        public string customName; // 0x70

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFAC2F9CD50
        public void set_userId(){} // RVA: 0x7FFAC2F9CD60
        public void get_customName(){} // RVA: 0x7FFAC2FE9590
        public void set_customName(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBF212B0
    }

    public class ApiProductPurchaseStatus : ApiModel
    {
        public string ProductId; // 0x68
        public string LicenseId; // 0x70
        public System.DateTime Expiry; // 0x78

        // ── Methods ──
        public void get_ProductId(){} // RVA: 0x7FFAC2F9CD50
        public void set_ProductId(){} // RVA: 0x7FFAC2F9CD60
        public void get_LicenseId(){} // RVA: 0x7FFAC2FE9590
        public void set_LicenseId(){} // RVA: 0x7FFAC2FE95A0
        public void get_Expiry(){} // RVA: 0x7FFAC30E5600
        public void set_Expiry(){} // RVA: 0x7FFAC8246500
        public void GetProductsPurchaseStatus(){} // RVA: 0x7FFACBEC6150
        public void .ctor(){} // RVA: 0x7FFACBEC6720
    }

    public class ApiProductVariant : ApiModel
    {
        public string ListingVariantID; // 0x68
        public int Quantity; // 0x70
        public int UnitPriceTokens; // 0x74
        public bool NonRefundable; // 0x78
        public System.DateTime EffectiveFrom; // 0x80

        // ── Methods ──
        public void get_ListingVariantID(){} // RVA: 0x7FFAC2F9CD50
        public void set_ListingVariantID(){} // RVA: 0x7FFAC2F9CD60
        public void get_Quantity(){} // RVA: 0x7FFAC3B99E80
        public void set_Quantity(){} // RVA: 0x7FFAC30B6520
        public void get_UnitPriceTokens(){} // RVA: 0x7FFAC43D9E20
        public void set_UnitPriceTokens(){} // RVA: 0x7FFAC48B4C80
        public void get_NonRefundable(){} // RVA: 0x7FFAC33CE5C0
        public void set_NonRefundable(){} // RVA: 0x7FFAC3D20B50
        public void get_EffectiveFrom(){} // RVA: 0x7FFAC32EF410
        public void set_EffectiveFrom(){} // RVA: 0x7FFAC4A2BA90
        public void .ctor(){} // RVA: 0x7FFACBEC6830
    }

    public class ApiProp : ApiContentModel`1
    {
        public System.DateTime _created_at; // 0xD8
        public System.DateTime _updated_at; // 0xE0
        public System.Collections.Generic.List`1<UnityPackage> unityPackages; // 0xE8
        public int spawnType; // 0xF0
        public int worldPlacementMask; // 0xF4
        public bool scaleWithAvatar; // 0xF8
        public string BundleSignature;
        public string <BundleSignature>k__BackingField; // 0x100

        // ── Methods ──
        public void get__created_at(){} // RVA: 0x7FFAC3540F70
        public void set__created_at(){} // RVA: 0x7FFACBE7A200
        public void get__updated_at(){} // RVA: 0x7FFAC2FA2900
        public void set__updated_at(){} // RVA: 0x7FFACBE7A210
        public void get_unityPackages(){} // RVA: 0x7FFAC2FA2970
        public void set_unityPackages(){} // RVA: 0x7FFAC2FA2980
        public void get_spawnType(){} // RVA: 0x7FFAC60855D0
        public void set_spawnType(){} // RVA: 0x7FFAC8A11630
        public void get_worldPlacementMask(){} // RVA: 0x7FFAC6715830
        public void set_worldPlacementMask(){} // RVA: 0x7FFAC6715840
        public void get_scaleWithAvatar(){} // RVA: 0x7FFAC3C8E090
        public void set_scaleWithAvatar(){} // RVA: 0x7FFAC97AF8F0
        public void get_BundleSignature(){} // RVA: 0x7FFAC34F6C80
        public void set_BundleSignature(){} // RVA: 0x7FFAC34F6750
        public void .ctor(){} // RVA: 0x7FFACBEC6880
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFACBEC69E0 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x7FFACBEC6AC0
        public void WriteField(){} // RVA: 0x7FFACBEC7180
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFACBEC7240
        public void GetProp(){} // RVA: 0x7FFACBEC7440
    }

    public class ApiPropItemMetadata : ApiModel
    {
        public string propId; // 0x68
        public int worldPlacementMask; // 0x70

        // ── Methods ──
        public void get_propId(){} // RVA: 0x7FFAC2F9CD50
        public void set_propId(){} // RVA: 0x7FFAC2F9CD60
        public void get_worldPlacementMask(){} // RVA: 0x7FFAC3B99E80
        public void set_worldPlacementMask(){} // RVA: 0x7FFAC30B6520
        public void .ctor(){} // RVA: 0x7FFACBEC78E0
    }

    public class ApiPurchase : ApiModel
    {
        public string ListingId; // 0x68
        public string ListingDisplayName; // 0x70
        public string ListingImageId; // 0x78
        public 0x6B0B51B0 ListingImageUrl; // 0x80
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
        public 0x6B0B5208 Quantity; // 0xCC
        public System.DateTime Duration; // 0xD0
        public System.DateTime DurationType; // 0xD8
        public System.DateTime PurchaseDate; // 0xE0
        public bool PurchaseStartDate; // 0xE8
        public bool PurchaseEndDate; // 0xE9
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> PurchaseActive; // 0xF0
        public bool PurchaseLatest; // 0xF8
        public bool Products; // 0xF9
        public System.Collections.Generic.Dictionary`2<string,object> IsStackable; // 0x100
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
        public System.DateTime WillRecur; // 0x150
        public string ListingCurrentlyAvailable; // 0x158
        public System.DateTime CreatedAtDate; // 0x160
        public System.DateTime PurchaseID; // 0x168
        public string UpdatedAtDate; // 0x170
        public bool PurchaseOriginalEndDate; // 0x178
        public bool BuyerIP; // 0x179
        public string IsRecur; // 0x180
        public System.Collections.Generic.List`1<string> IsUnityLocalTest; // 0x188
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
        public System.DateTime VoidedBy; // 0x1D8
        public int VoidedByAdmin; // 0x1E0
        public int VoidedOnDate; // 0x1E4
        public int PurchaseTiliaFeeBasedOnStack; // 0x1E8
        public bool PurchaseTiliaFeeDrift; // 0x1EC
        public string PurchaseVrcFeeBasedOnStack; // 0x1F0
        public bool Refunded; // 0x1F8
        public System.DateTime RefundedBy; // 0x200
        public System.Collections.Generic.List`1<string> RefundedByAdmin; // 0x208
        public string RefundedOnDate; // 0x210
        public string RefundedStacks; // 0x218
        public string RefundReason; // 0x220
        public object RefundReasonType; // 0x228
        public int RefundTiliaTransactionId; // 0x230
        public object RefundTokenComponents; // 0x238
        public string RefundTokens; // 0x240
        public System.Collections.Generic.List`1<string> RefundTokenSources; // 0x248
        public bool RefundType; // 0x250

        // ── Methods ──
        public void get_ListingId(){} // RVA: 0x7FFAC2F9CD50
        public void set_ListingId(){} // RVA: 0x7FFAC2F9CD60
        public void get_ListingDisplayName(){} // RVA: 0x7FFAC2FE9590
        public void set_ListingDisplayName(){} // RVA: 0x7FFAC2FE95A0
        public void get_ListingImageId(){} // RVA: 0x7FFAC30E5600
        public void set_ListingImageId(){} // RVA: 0x7FFAC30E06F0
        public void get_ListingImageUrl(){} // RVA: 0x7FFACBEC79D0
        public void get_ListingType(){} // RVA: 0x7FFAC35729C0
        public void set_ListingType(){} // RVA: 0x7FFAC3572BF0
        public void get_ListingVariantId(){} // RVA: 0x7FFAC2F60010
        public void set_ListingVariantId(){} // RVA: 0x7FFAC354E300
        public void get_SellerId(){} // RVA: 0x7FFAC32EF640
        public void set_SellerId(){} // RVA: 0x7FFAC354E360
        public void get_SellerDisplayName(){} // RVA: 0x7FFAC354DFB0
        public void set_SellerDisplayName(){} // RVA: 0x7FFAC354E3C0
        public void get_BuyerId(){} // RVA: 0x7FFAC3543900
        public void set_BuyerId(){} // RVA: 0x7FFAC354E420
        public void get_BuyerDisplayName(){} // RVA: 0x7FFAC354B1A0
        public void set_BuyerDisplayName(){} // RVA: 0x7FFAC334B370
        public void get_ReceiverId(){} // RVA: 0x7FFAC2F8C040
        public void set_ReceiverId(){} // RVA: 0x7FFAC2F8C050
        public void get_ReceiverDisplayName(){} // RVA: 0x7FFAC2F8C0B0
        public void set_ReceiverDisplayName(){} // RVA: 0x7FFAC2F8C0C0
        public void get_id(){} // RVA: 0x7FFAC2F3C380
        public void set_id(){} // RVA: 0x7FFAC2F22E30
        public void get_Price(){} // RVA: 0x7FFAC313B720
        public void set_Price(){} // RVA: 0x7FFAC31434F0
        public void get_Quantity(){} // RVA: 0x7FFAC47D3250
        public void set_Quantity(){} // RVA: 0x7FFAC893FDA0
        public void get_Duration(){} // RVA: 0x7FFAC3641480
        public void set_Duration(){} // RVA: 0x7FFAC623E970
        public void get_DurationType(){} // RVA: 0x7FFAC43065A0
        public void set_DurationType(){} // RVA: 0x7FFAC88C71C0
        public void get_PurchaseDate(){} // RVA: 0x7FFAC303E100
        public void set_PurchaseDate(){} // RVA: 0x7FFAC906B850
        public void get_PurchaseStartDate(){} // RVA: 0x7FFAC3540F70
        public void set_PurchaseStartDate(){} // RVA: 0x7FFACBE7A200
        public void get_PurchaseEndDate(){} // RVA: 0x7FFAC2FA2900
        public void set_PurchaseEndDate(){} // RVA: 0x7FFACBE7A210
        public void get_PurchaseActive(){} // RVA: 0x7FFAC3FD4640
        public void set_PurchaseActive(){} // RVA: 0x7FFAC499C5B0
        public void get_PurchaseLatest(){} // RVA: 0x7FFAC8E42E60
        public void set_PurchaseLatest(){} // RVA: 0x7FFACBEC7A40
        public void get_Products(){} // RVA: 0x7FFAC2F8C2A0
        public void set_Products(){} // RVA: 0x7FFAC2F8C2B0
        public void get_IsStackable(){} // RVA: 0x7FFAC3C8E090
        public void set_IsStackable(){} // RVA: 0x7FFAC97AF8F0
        public void get_IsRecurrable(){} // RVA: 0x7FFAC2F7DF90
        public void set_IsRecurrable(){} // RVA: 0x7FFAC2F7DFA0
        public void get_PurchaseToken(){} // RVA: 0x7FFAC34F6C80
        public void set_PurchaseToken(){} // RVA: 0x7FFAC34F6750
        public void get_IsVoided(){} // RVA: 0x7FFAC4196030
        public void set_IsVoided(){} // RVA: 0x7FFAC4196040
        public void get_IsGift(){} // RVA: 0x7FFAC45CA6A0
        public void set_IsGift(){} // RVA: 0x7FFAC45C9FB0
        public void get_PurchaseUnitPrice(){} // RVA: 0x7FFAC4597A10
        public void set_PurchaseUnitPrice(){} // RVA: 0x7FFAC459AD60
        public void get_IsRefundable(){} // RVA: 0x7FFAC31E7D90
        public void set_IsRefundable(){} // RVA: 0x7FFAC31E5C40
        public void get_StackDurationType(){} // RVA: 0x7FFAC33BC6D0
        public void set_StackDurationType(){} // RVA: 0x7FFAC33B8580
        public void get_StackDuration(){} // RVA: 0x7FFAC8A11640
        public void set_StackDuration(){} // RVA: 0x7FFAC8A11650
        public void get_StackPrice(){} // RVA: 0x7FFAC88D4E90
        public void set_StackPrice(){} // RVA: 0x7FFAC88D4EA0
        public void get_StackQuantity(){} // RVA: 0x7FFAC8A119F0
        public void set_StackQuantity(){} // RVA: 0x7FFAC8A11A00
        public void get_StackQuantityConsumed(){} // RVA: 0x7FFACBEC7A50
        public void set_StackQuantityConsumed(){} // RVA: 0x7FFACBEC7A60
        public void get_StackQuantityConsumedAtPurchase(){} // RVA: 0x7FFAC33BC1B0
        public void set_StackQuantityConsumedAtPurchase(){} // RVA: 0x7FFAC955CD90
        public void get_StackQuantityUnconsumed(){} // RVA: 0x7FFAC92F4E20
        public void set_StackQuantityUnconsumed(){} // RVA: 0x7FFACBEC7A70
        public void get_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x7FFAC3C8EC30
        public void set_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x7FFAC88C7220
        public void get_TiliaTransactionId(){} // RVA: 0x7FFAC2F8C5F0
        public void set_TiliaTransactionId(){} // RVA: 0x7FFAC2F8C600
        public void get_WillRecur(){} // RVA: 0x7FFAC4138670
        public void set_WillRecur(){} // RVA: 0x7FFAC412E500
        public void get_ListingCurrentlyAvailable(){} // RVA: 0x7FFACBA41C70
        public void set_ListingCurrentlyAvailable(){} // RVA: 0x7FFACBEC7A80
        public void get_CreatedAtDate(){} // RVA: 0x7FFAC354DFA0
        public void set_CreatedAtDate(){} // RVA: 0x7FFACBEC7A90
        public void get_PurchaseID(){} // RVA: 0x7FFAC3542410
        public void set_PurchaseID(){} // RVA: 0x7FFAC39A74B0
        public void get_UpdatedAtDate(){} // RVA: 0x7FFAC33A98A0
        public void set_UpdatedAtDate(){} // RVA: 0x7FFAC9C7AAF0
        public void get_PurchaseOriginalEndDate(){} // RVA: 0x7FFAC354E2F0
        public void set_PurchaseOriginalEndDate(){} // RVA: 0x7FFACBEC7AA0
        public void get_BuyerIP(){} // RVA: 0x7FFAC336D850
        public void set_BuyerIP(){} // RVA: 0x7FFAC39B5DB0
        public void get_IsRecur(){} // RVA: 0x7FFACBEC7AB0
        public void set_IsRecur(){} // RVA: 0x7FFAC2FF56A0
        public void get_IsUnityLocalTest(){} // RVA: 0x7FFACBEC7AC0
        public void set_IsUnityLocalTest(){} // RVA: 0x7FFACBEC7AD0
        public void get_LicenseID(){} // RVA: 0x7FFAC354B1B0
        public void set_LicenseID(){} // RVA: 0x7FFAC3503070
        public void get_PurchaseStacks(){} // RVA: 0x7FFAC35410C0
        public void set_PurchaseStacks(){} // RVA: 0x7FFAC3503010
        public void get_PurchaseTiliaFee(){} // RVA: 0x7FFAC8A144E0
        public void set_PurchaseTiliaFee(){} // RVA: 0x7FFAC9645C60
        public void get_PurchaseType(){} // RVA: 0x7FFAC3541C80
        public void set_PurchaseType(){} // RVA: 0x7FFAC39C8ED0
        public void get_PurchaseValue(){} // RVA: 0x7FFACBEC7AE0
        public void set_PurchaseValue(){} // RVA: 0x7FFACBEC7AF0
        public void get_PurchaseVrcFee(){} // RVA: 0x7FFACBEC7B00
        public void set_PurchaseVrcFee(){} // RVA: 0x7FFACBEC7B10
        public void get_RefundStatus(){} // RVA: 0x7FFAC3548F80
        public void set_RefundStatus(){} // RVA: 0x7FFAC39B4D10
        public void get_SellerIP(){} // RVA: 0x7FFAC3549F30
        public void set_SellerIP(){} // RVA: 0x7FFAC39A7790
        public void get_StackTiliaFee(){} // RVA: 0x7FFACBA0F460
        public void set_StackTiliaFee(){} // RVA: 0x7FFACBEC7B20
        public void get_StackValue(){} // RVA: 0x7FFAC401F070
        public void set_StackValue(){} // RVA: 0x7FFACBEC7B30
        public void get_StackVrcFee(){} // RVA: 0x7FFAC4019FC0
        public void set_StackVrcFee(){} // RVA: 0x7FFACBEC7B40
        public void get_StackQuantityVoided(){} // RVA: 0x7FFACBEC7B50
        public void set_StackQuantityVoided(){} // RVA: 0x7FFACBEC7B60
        public void get_VoidedBy(){} // RVA: 0x7FFAC39CCB10
        public void set_VoidedBy(){} // RVA: 0x7FFAC39CF3F0
        public void get_VoidedByAdmin(){} // RVA: 0x7FFACB3A45C0
        public void set_VoidedByAdmin(){} // RVA: 0x7FFACBEC7B70
        public void get_VoidedOnDate(){} // RVA: 0x7FFAC39C0A30
        public void set_VoidedOnDate(){} // RVA: 0x7FFACBEC7B80
        public void get_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0x7FFACBEC7B90
        public void set_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0x7FFACBEC7BA0
        public void get_PurchaseTiliaFeeDrift(){} // RVA: 0x7FFAC90AB690
        public void set_PurchaseTiliaFeeDrift(){} // RVA: 0x7FFACBEC7BB0
        public void get_PurchaseVrcFeeBasedOnStack(){} // RVA: 0x7FFACBEC7BC0
        public void set_PurchaseVrcFeeBasedOnStack(){} // RVA: 0x7FFACBEC7BD0
        public void get_Refunded(){} // RVA: 0x7FFACBEC7BE0
        public void set_Refunded(){} // RVA: 0x7FFACBEC7BF0
        public void get_RefundedBy(){} // RVA: 0x7FFAC3544EF0
        public void set_RefundedBy(){} // RVA: 0x7FFAC3541400
        public void get_RefundedByAdmin(){} // RVA: 0x7FFAC47C4AF0
        public void set_RefundedByAdmin(){} // RVA: 0x7FFACBEC7C00
        public void get_RefundedOnDate(){} // RVA: 0x7FFAC3544790
        public void set_RefundedOnDate(){} // RVA: 0x7FFACBEC7C10
        public void get_RefundedStacks(){} // RVA: 0x7FFAC3544780
        public void set_RefundedStacks(){} // RVA: 0x7FFAC354D290
        public void get_RefundReason(){} // RVA: 0x7FFAC354BCB0
        public void set_RefundReason(){} // RVA: 0x7FFAC3543140
        public void get_RefundReasonType(){} // RVA: 0x7FFAC3541470
        public void set_RefundReasonType(){} // RVA: 0x7FFAC3542420
        public void get_RefundTiliaTransactionId(){} // RVA: 0x7FFAC35493F0
        public void set_RefundTiliaTransactionId(){} // RVA: 0x7FFAC354AC80
        public void get_RefundTokenComponents(){} // RVA: 0x7FFAC3540FB0
        public void set_RefundTokenComponents(){} // RVA: 0x7FFAC39AE720
        public void get_RefundTokens(){} // RVA: 0x7FFAC44F8B10
        public void set_RefundTokens(){} // RVA: 0x7FFAC44F9B00
        public void get_RefundTokenSources(){} // RVA: 0x7FFAC35413D0
        public void set_RefundTokenSources(){} // RVA: 0x7FFAC39AA7F0
        public void get_RefundType(){} // RVA: 0x7FFAC39C9150
        public void set_RefundType(){} // RVA: 0x7FFAC39B5A80
        public void get_VoidedStacks(){} // RVA: 0x7FFAC39A6830
        public void set_VoidedStacks(){} // RVA: 0x7FFAC39A8760
        public void get_VoidedCompletely(){} // RVA: 0x7FFACBEC7C20
        public void set_VoidedCompletely(){} // RVA: 0x7FFACBEC7C30
        public void ReadField(){} // RVA: 0x7FFACBEC7C40
        public void WriteField(){} // RVA: 0x7FFACBEC7E80
        public void GetCancelInformation(){} // RVA: 0x7FFACBEC8000
        public void Cancel(){} // RVA: 0x7FFACBEC88E0
        public void FetchList(){} // RVA: 0x7FFACBEC9250
        public void FetchMostRecentActivePurchase(){} // RVA: 0x7FFACBECA200
        public void .ctor(){} // RVA: 0x7FFACBECAB60
    }

}