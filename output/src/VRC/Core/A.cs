// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 100
// Methods: 2140

namespace VRC.Core
{
    public class API : Object
    {
        public string API_URL;
        public string devApiUrl;
        public string devCeApiUrl;

        // ── Methods ──
        public void get_ClientGameServerVersion(){} // RVA: 0x7FFE8A2B3820
        public void .cctor(){} // RVA: 0x7FFE8A2B3880
        public void RegisterLogging(){} // RVA: 0x7FFE8A2B3DD0
        public void SetClientVersion(){} // RVA: 0x7FFE8A2B3E80
        public void GetClientVersion(){} // RVA: 0x7FFE8A2B3F40
        public void SetStore(){} // RVA: 0x7FFE8A2B3FA0
        public void GetStore(){} // RVA: 0x7FFE8A2B4060
        public void SetAllowRoaming(){} // RVA: 0x7FFE8A2B40C0
        public void GetAllowRoaming(){} // RVA: 0x7FFE8A2B4120
        public void SetClientGameServerVersion(){} // RVA: 0x7FFE8A2B4180
        public void IsReady(){} // RVA: 0x7FFE8A2B41E0
        public void FromCacheOrNew(){} // RVA: 0x7FFE810A1420
        public void CreateFromJson(){} // RVA: 0x7FFE810A1420
        public void Fetch(){} // RVA: 0x7FFE810A1420
        public void FetchAsync(){} // RVA: 0x7FFE80E3EEA0
        public void DeleteAsync(){} // RVA: 0x7FFE80E2E3D0
        public void Delete(){} // RVA: 0x7FFE80E4B8F0
        public void get_DeviceID(){} // RVA: 0x7FFE86EC1120
        public void SetApiUrlFromEnvironment(){} // RVA: 0x7FFE8A2B4280
        public void GetApiUrlForEnvironment(){} // RVA: 0x7FFE8A2B4480
        public void SetApiUrl(){} // RVA: 0x7FFE8A2B45B0
        public void GetApiUrl(){} // RVA: 0x7FFE8A2B4660
        public void IsDevApi(){} // RVA: 0x7FFE8A2B46C0
        public void IsDevCeApi(){} // RVA: 0x7FFE8A2B47A0
        public void SendGetRequest(){} // RVA: 0x7FFE8A2B4880
        public void SendPostRequest(){} // RVA: 0x7FFE8A2B49A0
        public void SendPostFormRequest(){} // RVA: 0x7FFE8A2B4AC0
        public void SendPostRawJsonRequest(){} // RVA: 0x7FFE8A2B4BE0
        public void SendPutRequest(){} // RVA: 0x7FFE8A2B4D00
        public void SendDeleteRequest(){} // RVA: 0x7FFE8A2B4E20
        public void SendRequest(){} // RVA: 0x7FFE8A2B4F40
        public void SendRequestInternal(){} // RVA: 0x7FFE8A2B5670
        public void AuthenticateHTTPRequest(){} // RVA: 0x7FFE8A2B6C10
        public void AuthenticateUnityWebRequest(){} // RVA: 0x7FFE8A2B7080
        public void PopulateHTTPRequestHeaders(){} // RVA: 0x7FFE8A2B73D0
        public void PopulateUnityWebRequestHeaders(){} // RVA: 0x7FFE8A2B7860
        public void CertVerifyHTTPRequest(){} // RVA: 0x7FFE8A2B7B30
        public void CertVerifyUnityWebRequest(){} // RVA: 0x7FFE8A2B7CE0
        public void InitializeCertificateVerifier(){} // RVA: 0x7FFE8A2B7FA0
        public void AppendQuery(){} // RVA: 0x7FFE8A2B80D0
        public void ConvertJsonListToModelList(){} // RVA: 0x7FFE80E2E440
        public void get_IsVRCClient(){} // RVA: 0x7FFE8A2B8180
        public void set_IsVRCClient(){} // RVA: 0x7FFE8A2B81E0
        public void SetOnlineMode(){} // RVA: 0x7FFE8A2B8240
        public void ClearOnlineMode(){} // RVA: 0x7FFE8A2B8610
        public void IsOffline(){} // RVA: 0x7FFE8A2B86C0
        public void GetServerEnvironmentForApiUrl(){} // RVA: 0x7FFE8A2B8780 | overloaded x2
        public void SendOfflineRequest(){} // RVA: 0x7FFE8A2B8A40
        public void GenerateMergeCode(){} // RVA: 0x7FFE8A2B9110
    }

    public class API2FA : ApiModel
    {
        public System.Collections.Generic.List`1<string> _requiresTwoFactorAuth; // 0x68
        public string _scope; // 0x70
        public string _ticket; // 0x78

        // ── Methods ──
        public void get_requiresTwoFactorAuth(){} // RVA: 0x7FFE81176D50
        public void set_requiresTwoFactorAuth(){} // RVA: 0x7FFE81176D60
        public void get_scope(){} // RVA: 0x7FFE811C3590
        public void set_scope(){} // RVA: 0x7FFE811C35A0
        public void get_ticket(){} // RVA: 0x7FFE81463AE0
        public void set_ticket(){} // RVA: 0x7FFE81464570
        public void TimeBasedOneTimePasswordSupported(){} // RVA: 0x7FFE8A2B9D60
        public void EmailBasedOneTimePasswordSupported(){} // RVA: 0x7FFE8A2B9DC0
        public void OneTimePasswordSupported(){} // RVA: 0x7FFE8A2B9E20
        public void SmsSupported(){} // RVA: 0x7FFE8A2B9E80
        public void ToString(){} // RVA: 0x7FFE8A2B9EE0
        public void .ctor(){} // RVA: 0x7FFE8A2BA140
    }

    public class APIActivationSuccessfulTargetResult : ApiModel
    {
        public string _userId; // 0x68
        public int _gifts; // 0x70
        public bool _isFriend; // 0x74

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFE81176D50
        public void set_userId(){} // RVA: 0x7FFE81176D60
        public void get_gifts(){} // RVA: 0x7FFE81E60180
        public void set_gifts(){} // RVA: 0x7FFE81293CF0
        public void get_isFriend(){} // RVA: 0x7FFE81E8DCD0
        public void set_isFriend(){} // RVA: 0x7FFE8656ED40
        public void .ctor(){} // RVA: 0x7FFE8A2D65E0
    }

    public class APICalendarEntry : ApiModel
    {
        public string _ownerId; // 0x68
        public 0x664ADEC4 _accessType; // 0x70
        public System.DateTime _startsAt; // 0x78
        public System.DateTime _endsAt; // 0x80
        public string _title; // 0x88
        public string _description; // 0x90
        public string _category; // 0x98
        public string _shortCode; // 0xA0
        public string _type; // 0xA8
        public bool _isDraft; // 0xB0
        public string _imageId; // 0xB8
        public string _imageUrl; // 0xC0
        public System.Collections.Generic.List`1<string> _roleIds; // 0xC8
        public System.Collections.Generic.List`1<string> _tags; // 0xD0
        public System.Collections.Generic.List`1<string> _platforms; // 0xD8
        public System.Collections.Generic.List`1<string> _languages; // 0xE0
        public string _parentId; // 0xE8
        public int _hostEarlyJoinMinutes; // 0xF0
        public int _guestEarlyJoinMinutes; // 0xF4
        public int _closeInstanceAfterEndMinutes; // 0xF8
        public bool _usesInstanceOverflow; // 0xFC
        public System.DateTime _deletedAt; // 0x100
        public VRC.Core.APICalendarEntryUserInterest _userInterest; // 0x108
        public bool _featured; // 0x110
        public int _interestedUserCount; // 0x114

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3728D0
        public void get_ownerId(){} // RVA: 0x7FFE81176D50
        public void set_ownerId(){} // RVA: 0x7FFE81176D60
        public void get_accessType(){} // RVA: 0x7FFE81E60180
        public void set_accessType(){} // RVA: 0x7FFE81293CF0
        public void get_startsAt(){} // RVA: 0x7FFE81463AE0
        public void set_startsAt(){} // RVA: 0x7FFE865EFE40
        public void get_endsAt(){} // RVA: 0x7FFE81280C30
        public void set_endsAt(){} // RVA: 0x7FFE82C95C90
        public void get_title(){} // RVA: 0x7FFE8113A010
        public void set_title(){} // RVA: 0x7FFE81280F90
        public void get_description(){} // RVA: 0x7FFE8154EB60
        public void set_description(){} // RVA: 0x7FFE818CE320
        public void get_category(){} // RVA: 0x7FFE817AE360
        public void set_category(){} // RVA: 0x7FFE8171B470
        public void get_shortCode(){} // RVA: 0x7FFE8179C860
        public void set_shortCode(){} // RVA: 0x7FFE8171B4D0
        public void get_type(){} // RVA: 0x7FFE817AB5E0
        public void set_type(){} // RVA: 0x7FFE81857260
        public void get_isDraft(){} // RVA: 0x7FFE824A0700
        public void set_isDraft(){} // RVA: 0x7FFE824A0BA0
        public void get_imageId(){} // RVA: 0x7FFE811660B0
        public void set_imageId(){} // RVA: 0x7FFE811660C0
        public void get_imageUrl(){} // RVA: 0x7FFE81166120
        public void set_imageUrl(){} // RVA: 0x7FFE81166130
        public void get_roleIds(){} // RVA: 0x7FFE81253460
        public void set_roleIds(){} // RVA: 0x7FFE81253470
        public void get_tags(){} // RVA: 0x7FFE81218100
        public void set_tags(){} // RVA: 0x7FFE81218110
        public void get_platforms(){} // RVA: 0x7FFE8181EA80
        public void set_platforms(){} // RVA: 0x7FFE8117C8A0
        public void get_languages(){} // RVA: 0x7FFE8117C900
        public void set_languages(){} // RVA: 0x7FFE8117C910
        public void get_parentId(){} // RVA: 0x7FFE8117C970
        public void set_parentId(){} // RVA: 0x7FFE8117C980
        public void get_hostEarlyJoinMinutes(){} // RVA: 0x7FFE843B5350
        public void set_hostEarlyJoinMinutes(){} // RVA: 0x7FFE86DBACB0
        public void get_guestEarlyJoinMinutes(){} // RVA: 0x7FFE84A61F50
        public void set_guestEarlyJoinMinutes(){} // RVA: 0x7FFE84A61F60
        public void get_closeInstanceAfterEndMinutes(){} // RVA: 0x7FFE82144660
        public void set_closeInstanceAfterEndMinutes(){} // RVA: 0x7FFE8213C830
        public void get_usesInstanceOverflow(){} // RVA: 0x7FFE8A3257E0
        public void set_usesInstanceOverflow(){} // RVA: 0x7FFE8A3257F0
        public void get_deletedAt(){} // RVA: 0x7FFE81828B50
        public void set_deletedAt(){} // RVA: 0x7FFE82472650
        public void get_userInterest(){} // RVA: 0x7FFE8181E3D0
        public void set_userInterest(){} // RVA: 0x7FFE81A60200
        public void get_featured(){} // RVA: 0x7FFE81472650
        public void set_featured(){} // RVA: 0x7FFE81472660
        public void get_interestedUserCount(){} // RVA: 0x7FFE87AEDA80
        public void set_interestedUserCount(){} // RVA: 0x7FFE87AEDA90
        public void UpdateData(){} // RVA: 0x7FFE8A372920
        public void WriteField(){} // RVA: 0x7FFE8A3730E0
    }

    public class APICalendarEntryUserInterest : ApiModel
    {
        public bool _isFollowing; // 0x68
        public System.DateTime _createdAt; // 0x70
        public System.DateTime _updatedAt; // 0x78

        // ── Methods ──
        public void get_isFollowing(){} // RVA: 0x7FFE811C3570
        public void set_isFollowing(){} // RVA: 0x7FFE811C3580
        public void get_createdAt(){} // RVA: 0x7FFE811C3590
        public void set_createdAt(){} // RVA: 0x7FFE82C95C70
        public void get_updatedAt(){} // RVA: 0x7FFE81463AE0
        public void set_updatedAt(){} // RVA: 0x7FFE865EFE40
        public void .ctor(){} // RVA: 0x7FFE8A373570
    }

    public class APICampaignInfo : ApiModel
    {
        public bool _campaignActive; // 0x68
        public bool _dataAvailable; // 0x69
        public System.DateTime _endDate; // 0x70
        public int _globalGiftCount; // 0x78
        public int _globalGiftGoal; // 0x7C
        public bool _globalGiftGoalSuccess; // 0x80
        public int _globalParticipantCount; // 0x84
        public string _lastRefreshTime; // 0x88
        public int _localPurchaseCount; // 0x90
        public string _name; // 0x98
        public string _description; // 0xA0
        public System.Collections.Generic.List`1<string> _participatingFriends; // 0xA8
        public System.Collections.Generic.List`1<VRC.Core.ApiCampaignReward> _rewards; // 0xB0
        public System.DateTime _startDate; // 0xB8
        public int _globalDollarsGoal; // 0xC0
        public int _globalDollarsRaised; // 0xC4
        public int _globalPurchaseCount; // 0xC8
        public bool _includeGiftDrops; // 0xCC
        public bool _includeGifts; // 0xCD
        public bool _includeSubscriptions; // 0xCE
        public string _slug; // 0xD0
        public bool _uDidIt; // 0xD8

        // ── Methods ──
        public void get_campaignActive(){} // RVA: 0x7FFE811C3570
        public void set_campaignActive(){} // RVA: 0x7FFE811C3580
        public void get_dataAvailable(){} // RVA: 0x7FFE85B63B60
        public void set_dataAvailable(){} // RVA: 0x7FFE85B63740
        public void get_endDate(){} // RVA: 0x7FFE811C3590
        public void set_endDate(){} // RVA: 0x7FFE82C95C70
        public void get_globalGiftCount(){} // RVA: 0x7FFE8286C0A0
        public void set_globalGiftCount(){} // RVA: 0x7FFE82862F10
        public void get_globalGiftGoal(){} // RVA: 0x7FFE8286B570
        public void set_globalGiftGoal(){} // RVA: 0x7FFE86D89990
        public void get_globalGiftGoalSuccess(){} // RVA: 0x7FFE813A1130
        public void set_globalGiftGoalSuccess(){} // RVA: 0x7FFE813A2040
        public void get_globalParticipantCount(){} // RVA: 0x7FFE829DF2E0
        public void set_globalParticipantCount(){} // RVA: 0x7FFE829DF3B0
        public void get_lastRefreshTime(){} // RVA: 0x7FFE8113A010
        public void set_lastRefreshTime(){} // RVA: 0x7FFE81280F90
        public void get_localPurchaseCount(){} // RVA: 0x7FFE814AA220
        public void set_localPurchaseCount(){} // RVA: 0x7FFE81C8DB30
        public void get_name(){} // RVA: 0x7FFE817AE360
        public void set_name(){} // RVA: 0x7FFE8171B470
        public void get_description(){} // RVA: 0x7FFE8179C860
        public void set_description(){} // RVA: 0x7FFE8171B4D0
        public void get_participatingFriends(){} // RVA: 0x7FFE817AB5E0
        public void set_participatingFriends(){} // RVA: 0x7FFE81857260
        public void get_rewards(){} // RVA: 0x7FFE81166040
        public void set_rewards(){} // RVA: 0x7FFE81166050
        public void get_startDate(){} // RVA: 0x7FFE811660B0
        public void set_startDate(){} // RVA: 0x7FFE82904810
        public void get_globalDollarsGoal(){} // RVA: 0x7FFE813AB640
        public void set_globalDollarsGoal(){} // RVA: 0x7FFE813A4A00
        public void get_globalDollarsRaised(){} // RVA: 0x7FFE82A3B5F0
        public void set_globalDollarsRaised(){} // RVA: 0x7FFE86CE9440
        public void get_globalPurchaseCount(){} // RVA: 0x7FFE81790750
        public void set_globalPurchaseCount(){} // RVA: 0x7FFE8453D840
        public void get_includeGiftDrops(){} // RVA: 0x7FFE81309DB0
        public void set_includeGiftDrops(){} // RVA: 0x7FFE86DBB020
        public void get_includeGifts(){} // RVA: 0x7FFE8130D470
        public void set_includeGifts(){} // RVA: 0x7FFE8A2C95C0
        public void get_includeSubscriptions(){} // RVA: 0x7FFE8A2C95D0
        public void set_includeSubscriptions(){} // RVA: 0x7FFE8A2C95E0
        public void get_slug(){} // RVA: 0x7FFE81218100
        public void set_slug(){} // RVA: 0x7FFE81218110
        public void get_uDidIt(){} // RVA: 0x7FFE82078290
        public void set_uDidIt(){} // RVA: 0x7FFE86C70900
        public void GetCampaignSummary(){} // RVA: 0x7FFE8A2C95F0
        public void GetCampaignAnonymizationState(){} // RVA: 0x7FFE8A2C97F0
        public void SetCampaignAnonymizationState(){} // RVA: 0x7FFE8A2C9B40
        public void GetCampaignLeaderboardFriends(){} // RVA: 0x7FFE8A2C9FD0
        public void GetCampaignLeaderboardGlobal(){} // RVA: 0x7FFE8A2CA040
        public void GetCampaignLeaderboard(){} // RVA: 0x7FFE8A2CA0B0
        public void .ctor(){} // RVA: 0x7FFE8A2CA3F0
    }

    public class APIEmoji : ApiModel
    {
        public string _fileId; // 0x68
        public string _imageUrl; // 0x70
        public string _animationStyle; // 0x78
        public string _maskTag; // 0x80
        public bool _animated; // 0x88
        public int _frames; // 0x8C
        public int _framesOverTime; // 0x90
        public string _loopStyle; // 0x98
        public string _assetBundleId; // 0xA0
        public bool _premium; // 0xA8

        // ── Methods ──
        public void get_fileId(){} // RVA: 0x7FFE81176D50
        public void set_fileId(){} // RVA: 0x7FFE81176D60
        public void get_imageUrl(){} // RVA: 0x7FFE811C3590
        public void set_imageUrl(){} // RVA: 0x7FFE811C35A0
        public void get_animationStyle(){} // RVA: 0x7FFE81463AE0
        public void set_animationStyle(){} // RVA: 0x7FFE81464570
        public void get_maskTag(){} // RVA: 0x7FFE81280C30
        public void set_maskTag(){} // RVA: 0x7FFE81282380
        public void get_animated(){} // RVA: 0x7FFE820C4230
        public void set_animated(){} // RVA: 0x7FFE820C0790
        public void get_frames(){} // RVA: 0x7FFE842B66B0
        public void set_frames(){} // RVA: 0x7FFE848F07E0
        public void get_framesOverTime(){} // RVA: 0x7FFE814AA220
        public void set_framesOverTime(){} // RVA: 0x7FFE81C8DB30
        public void get_loopStyle(){} // RVA: 0x7FFE817AE360
        public void set_loopStyle(){} // RVA: 0x7FFE8171B470
        public void get_assetBundleId(){} // RVA: 0x7FFE8179C860
        public void set_assetBundleId(){} // RVA: 0x7FFE8171B4D0
        public void get_premium(){} // RVA: 0x7FFE813A1D80
        public void set_premium(){} // RVA: 0x7FFE813AB660
        public void UploadEmoji(){} // RVA: 0x7FFE8A2CC380 | overloaded x2
        public void Fetch(){} // RVA: 0x7FFE8A2CC9E0
        public void .ctor(){} // RVA: 0x7FFE8A2CCD10
        public void <Fetch>g__ParseData|45_0(){} // RVA: 0x7FFE8A2CCD80
    }

    public class APIGiftBundle : ApiModel
    {
        public string _steamItemId; // 0x68
        public string _oculusSku; // 0x70
        public string _googleProductId; // 0x78
        public string _googlePlanId; // 0x80
        public string _picoSku; // 0x88
        public int _amount; // 0x90
        public string _description; // 0x98
        public string _period; // 0xA0
        public int _periodAmount; // 0xA8
        public int _tier; // 0xAC
        public int _bulkSize; // 0xB0
        public int _discountPercentage; // 0xB4
        public System.Collections.Generic.List`1<string> _licenseGroups; // 0xB8

        // ── Methods ──
        public void get_steamItemId(){} // RVA: 0x7FFE81176D50
        public void set_steamItemId(){} // RVA: 0x7FFE81176D60
        public void get_oculusSku(){} // RVA: 0x7FFE811C3590
        public void set_oculusSku(){} // RVA: 0x7FFE811C35A0
        public void get_googleProductId(){} // RVA: 0x7FFE81463AE0
        public void set_googleProductId(){} // RVA: 0x7FFE81464570
        public void get_googlePlanId(){} // RVA: 0x7FFE81280C30
        public void set_googlePlanId(){} // RVA: 0x7FFE81282380
        public void get_picoSku(){} // RVA: 0x7FFE8113A010
        public void set_picoSku(){} // RVA: 0x7FFE81280F90
        public void get_amount(){} // RVA: 0x7FFE814AA220
        public void set_amount(){} // RVA: 0x7FFE81C8DB30
        public void get_description(){} // RVA: 0x7FFE817AE360
        public void set_description(){} // RVA: 0x7FFE8171B470
        public void get_period(){} // RVA: 0x7FFE8179C860
        public void set_period(){} // RVA: 0x7FFE8171B4D0
        public void get_periodAmount(){} // RVA: 0x7FFE81A338E0
        public void set_periodAmount(){} // RVA: 0x7FFE81A34770
        public void get_tier(){} // RVA: 0x7FFE848BEEF0
        public void set_tier(){} // RVA: 0x7FFE848BEF00
        public void get_bulkSize(){} // RVA: 0x7FFE82E64BF0
        public void set_bulkSize(){} // RVA: 0x7FFE86B5F1F0
        public void get_discountPercentage(){} // RVA: 0x7FFE84A61A20
        public void set_discountPercentage(){} // RVA: 0x7FFE84A61A30
        public void get_licenseGroups(){} // RVA: 0x7FFE811660B0
        public void set_licenseGroups(){} // RVA: 0x7FFE811660C0
        public void .ctor(){} // RVA: 0x7FFE8A2D6540
    }

    public class APIGroup : ApiModel
    {
        public string _ownerId; // 0x68
        public string _name; // 0x70
        public string _shortCode; // 0x78
        public string _discriminator; // 0x80
        public string _description; // 0x88
        public string _iconUrl; // 0x90
        public string _bannerUrl; // 0x98
        public int _memberCount; // 0xA0
        public int _onlineMemberCount; // 0xA4
        public string _memberCountSyncedAt; // 0xA8
        public string _privacy; // 0xB0
        public string _joinState; // 0xB8
        public VRC.Core.APIGroupMember _myMember; // 0xC0
        public System.DateTime _createdAt; // 0xC8
        public System.DateTime _updatedAt; // 0xD0
        public string _membershipStatus; // 0xD8
        public string _bannerId; // 0xE0
        public string _iconId; // 0xE8
        public string _rules; // 0xF0
        public System.Collections.Generic.List`1<string> _initialRoleIds; // 0xF8
        public bool _isSystemGroup; // 0x100
        public bool _isVerified; // 0x101
        public System.Collections.Generic.List`1<GalleryObject> _galleries; // 0x108
        public System.Collections.Generic.List`1<string> _tags; // 0x110
        public bool _isSearchable; // 0x118
        public int _sizeQuality; // 0x11C
        public int _activityQuality; // 0x120
        public int _engagementQuality; // 0x124
        public int _contentQuality; // 0x128
        public System.Collections.Generic.List`1<VRC.Core.APIGroupRole> _roles; // 0x130
        public System.Collections.Generic.List`1<string> _links; // 0x138
        public System.Collections.Generic.List`1<string> _languages; // 0x140
        public System.DateTime _lastPostCreatedAt; // 0x148
        public string _storeId; // 0x150

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A376710 | overloaded x2
        public void get_ownerId(){} // RVA: 0x7FFE81176D50
        public void set_ownerId(){} // RVA: 0x7FFE81176D60
        public void get_name(){} // RVA: 0x7FFE811C3590
        public void set_name(){} // RVA: 0x7FFE811C35A0
        public void get_shortCode(){} // RVA: 0x7FFE81463AE0
        public void set_shortCode(){} // RVA: 0x7FFE81464570
        public void get_discriminator(){} // RVA: 0x7FFE81280C30
        public void set_discriminator(){} // RVA: 0x7FFE81282380
        public void get_description(){} // RVA: 0x7FFE8113A010
        public void set_description(){} // RVA: 0x7FFE81280F90
        public void get_iconUrl(){} // RVA: 0x7FFE8154EB60
        public void set_iconUrl(){} // RVA: 0x7FFE818CE320
        public void get_bannerUrl(){} // RVA: 0x7FFE817AE360
        public void set_bannerUrl(){} // RVA: 0x7FFE8171B470
        public void get_memberCount(){} // RVA: 0x7FFE82B06FB0
        public void set_memberCount(){} // RVA: 0x7FFE82B06FC0
        public void get_onlineMemberCount(){} // RVA: 0x7FFE848BEED0
        public void set_onlineMemberCount(){} // RVA: 0x7FFE848BEEE0
        public void get_memberCountSyncedAt(){} // RVA: 0x7FFE817AB5E0
        public void set_memberCountSyncedAt(){} // RVA: 0x7FFE81857260
        public void get_privacy(){} // RVA: 0x7FFE81166040
        public void set_privacy(){} // RVA: 0x7FFE81166050
        public void get_joinState(){} // RVA: 0x7FFE811660B0
        public void set_joinState(){} // RVA: 0x7FFE811660C0
        public void get_myMember(){} // RVA: 0x7FFE81166120
        public void set_myMember(){} // RVA: 0x7FFE81166130
        public void get_createdAt(){} // RVA: 0x7FFE81253460
        public void set_createdAt(){} // RVA: 0x7FFE89DBC280
        public void get_updatedAt(){} // RVA: 0x7FFE81218100
        public void set_updatedAt(){} // RVA: 0x7FFE87414000
        public void get_membershipStatus(){} // RVA: 0x7FFE8181EA80
        public void set_membershipStatus(){} // RVA: 0x7FFE8117C8A0
        public void get_bannerId(){} // RVA: 0x7FFE8117C900
        public void set_bannerId(){} // RVA: 0x7FFE8117C910
        public void get_iconId(){} // RVA: 0x7FFE8117C970
        public void set_iconId(){} // RVA: 0x7FFE8117C980
        public void get_rules(){} // RVA: 0x7FFE811662A0
        public void set_rules(){} // RVA: 0x7FFE811662B0
        public void get_initialRoleIds(){} // RVA: 0x7FFE8158D5D0
        public void set_initialRoleIds(){} // RVA: 0x7FFE81B0E4B0
        public void get_isSystemGroup(){} // RVA: 0x7FFE81F84400
        public void set_isSystemGroup(){} // RVA: 0x7FFE81F84A40
        public void get_isVerified(){} // RVA: 0x7FFE82904E20
        public void set_isVerified(){} // RVA: 0x7FFE82904730
        public void get_galleries(){} // RVA: 0x7FFE8181E3D0
        public void set_galleries(){} // RVA: 0x7FFE81A60200
        public void get_tags(){} // RVA: 0x7FFE81317980
        public void set_tags(){} // RVA: 0x7FFE813159A0
        public void get_isSearchable(){} // RVA: 0x7FFE89E6E4E0
        public void set_isSearchable(){} // RVA: 0x7FFE8A321280
        public void get_sizeQuality(){} // RVA: 0x7FFE87EA3510
        public void set_sizeQuality(){} // RVA: 0x7FFE87EA3520
        public void get_activityQuality(){} // RVA: 0x7FFE86DBACC0
        public void set_activityQuality(){} // RVA: 0x7FFE86DBACD0
        public void get_engagementQuality(){} // RVA: 0x7FFE86C7E580
        public void set_engagementQuality(){} // RVA: 0x7FFE86C7E590
        public void get_contentQuality(){} // RVA: 0x7FFE86DBB070
        public void set_contentQuality(){} // RVA: 0x7FFE86DBB080
        public void get_roles(){} // RVA: 0x7FFE81823850
        public void set_roles(){} // RVA: 0x7FFE81B31120
        public void get_links(){} // RVA: 0x7FFE8181EA70
        public void set_links(){} // RVA: 0x7FFE818254E0
        public void get_languages(){} // RVA: 0x7FFE811665F0
        public void set_languages(){} // RVA: 0x7FFE81166600
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFE81166660
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFE86DDD610
        public void get_storeId(){} // RVA: 0x7FFE81790740
        public void set_storeId(){} // RVA: 0x7FFE81B350B0
        public void UpdateData(){} // RVA: 0x7FFE8A376D30
        public void GetGroup(){} // RVA: 0x7FFE8A3777A0
        public void FetchAllData(){} // RVA: 0x7FFE8A3779A0
        public void RequestToJoin(){} // RVA: 0x7FFE8A377E40
        public void LeaveGroup(){} // RVA: 0x7FFE8A378200
        public void GetGroupInvites(){} // RVA: 0x7FFE8A378580
        public void InviteUser(){} // RVA: 0x7FFE8A378A00
        public void BanUser(){} // RVA: 0x7FFE8A378E30
        public void GetMembers(){} // RVA: 0x7FFE8A379260
        public void GetGroupCapacity(){} // RVA: 0x7FFE8A379830
        public void SetRepresentation(){} // RVA: 0x7FFE8A379950
        public void GetGroupGalleryImages(){} // RVA: 0x7FFE8A379DE0
        public void GetGroupProducts(){} // RVA: 0x7FFE8A37A900
        public void GetGroupAnnouncements(){} // RVA: 0x7FFE8A37AD40
        public void SetAnnouncementSubscription(){} // RVA: 0x7FFE8A37B2C0
        public void SetEventAnnouncementSubscription(){} // RVA: 0x7FFE8A37B720
        public void GetUsingShortCode(){} // RVA: 0x7FFE8A37BB80
        public void StrictSearch(){} // RVA: 0x7FFE8A37BEA0
        public void GetActiveGroupInstances(){} // RVA: 0x7FFE8A37C310
        public void GetRoles(){} // RVA: 0x7FFE8A37C770
        public void GetAllGroupPermissions(){} // RVA: 0x7FFE8A37CB90
        public void GetGroupPermissions(){} // RVA: 0x7FFE8A37CEC0
        public void ExtractPermissions(){} // RVA: 0x7FFE8A37D330
    }

    public class APIGroupAnnouncement : ApiModel
    {
        public string _groupId; // 0x68
        public string _authorId; // 0x70
        public string _title; // 0x78
        public string _text; // 0x80
        public string _imageUrl; // 0x88
        public string _visibility; // 0x90
        public System.DateTime _createdAt; // 0x98
        public System.DateTime _updatedAt; // 0xA0
        public System.Collections.Generic.List`1<string> _roleIds; // 0xA8

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFE81176D50
        public void set_groupId(){} // RVA: 0x7FFE81176D60
        public void get_authorId(){} // RVA: 0x7FFE811C3590
        public void set_authorId(){} // RVA: 0x7FFE811C35A0
        public void get_title(){} // RVA: 0x7FFE81463AE0
        public void set_title(){} // RVA: 0x7FFE81464570
        public void get_text(){} // RVA: 0x7FFE81280C30
        public void set_text(){} // RVA: 0x7FFE81282380
        public void get_imageUrl(){} // RVA: 0x7FFE8113A010
        public void set_imageUrl(){} // RVA: 0x7FFE81280F90
        public void get_visibility(){} // RVA: 0x7FFE8154EB60
        public void set_visibility(){} // RVA: 0x7FFE818CE320
        public void get_createdAt(){} // RVA: 0x7FFE817AE360
        public void set_createdAt(){} // RVA: 0x7FFE86225270
        public void get_updatedAt(){} // RVA: 0x7FFE8179C860
        public void set_updatedAt(){} // RVA: 0x7FFE86B370C0
        public void get_roleIds(){} // RVA: 0x7FFE817AB5E0
        public void set_roleIds(){} // RVA: 0x7FFE81857260
        public void SetLastPostReadAt(){} // RVA: 0x7FFE8A37EE20
        public void .ctor(){} // RVA: 0x7FFE8A37F230
    }

    public class APIGroupInstance : ApiWorldInstance
    {
        // ── Methods ──
        public void BuildRequest(){} // RVA: 0x7FFE8A37F2D0
        public void .ctor(){} // RVA: 0x7FFE8A37F5A0
    }

    public class APIGroupInvite : ApiModel
    {
        public string _groupId; // 0x68
        public string _userId; // 0x70
        public string _state; // 0x78

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFE81176D50
        public void set_groupId(){} // RVA: 0x7FFE81176D60
        public void get_userId(){} // RVA: 0x7FFE811C3590
        public void set_userId(){} // RVA: 0x7FFE811C35A0
        public void get_state(){} // RVA: 0x7FFE81463AE0
        public void set_state(){} // RVA: 0x7FFE81464570
        public void CancelRequest(){} // RVA: 0x7FFE8A37EA90
        public void .ctor(){} // RVA: 0x7FFE8A37ED80
    }

    public class APIGroupJoinResponse : ApiModel
    {
        public string _groupId; // 0x68
        public string _userId; // 0x70
        public System.DateTime _createdAt; // 0x78
        public bool _isOnProfile; // 0x80
        public bool _isOnNameplate; // 0x81
        public System.DateTime _joinedAt; // 0x88
        public System.DateTime _updatedAt; // 0x90
        public bool _isActive; // 0x98
        public bool _requestedJoin; // 0x99
        public string _inviteId; // 0xA0

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFE81176D50
        public void set_groupId(){} // RVA: 0x7FFE81176D60
        public void get_userId(){} // RVA: 0x7FFE811C3590
        public void set_userId(){} // RVA: 0x7FFE811C35A0
        public void get_createdAt(){} // RVA: 0x7FFE81463AE0
        public void set_createdAt(){} // RVA: 0x7FFE865EFE40
        public void get_isOnProfile(){} // RVA: 0x7FFE813A1130
        public void set_isOnProfile(){} // RVA: 0x7FFE813A2040
        public void get_isOnNameplate(){} // RVA: 0x7FFE813A1BA0
        public void set_isOnNameplate(){} // RVA: 0x7FFE8139FDD0
        public void get_joinedAt(){} // RVA: 0x7FFE8113A010
        public void set_joinedAt(){} // RVA: 0x7FFE82C95CA0
        public void get_updatedAt(){} // RVA: 0x7FFE8154EB60
        public void set_updatedAt(){} // RVA: 0x7FFE81854020
        public void get_isActive(){} // RVA: 0x7FFE81611920
        public void set_isActive(){} // RVA: 0x7FFE81611930
        public void get_requestedJoin(){} // RVA: 0x7FFE81610170
        public void set_requestedJoin(){} // RVA: 0x7FFE86CFFD10
        public void get_inviteId(){} // RVA: 0x7FFE8179C860
        public void set_inviteId(){} // RVA: 0x7FFE8171B4D0
        public void .ctor(){} // RVA: 0x7FFE8A37EA40
    }

    public class APIGroupList : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A37F740 | overloaded x2
    }

    public class APIGroupLocations : ApiModel
    {
        public System.DateTime _fetchedAt; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.ApiWorldInstance> _instances; // 0x70

        // ── Methods ──
        public void get_fetchedAt(){} // RVA: 0x7FFE81176D50
        public void set_fetchedAt(){} // RVA: 0x7FFE82C95C80
        public void get_instances(){} // RVA: 0x7FFE811C3590
        public void set_instances(){} // RVA: 0x7FFE811C35A0
        public void GetLocations(){} // RVA: 0x7FFE8A37F830
        public void .ctor(){} // RVA: 0x7FFE8A37FB70
    }

    public class APIGroupMember : ApiModel
    {
        public string _groupId; // 0x68
        public string _userId; // 0x70
        public System.Collections.Generic.List`1<string> _roleIds; // 0x78
        public System.Collections.Generic.List`1<string> _mRoleIds; // 0x80
        public System.Collections.Generic.List`1<string> _permissions; // 0x88
        public string _memberVisibility; // 0x90
        public string _membershipStatus; // 0x98
        public bool _isRepresenting; // 0xA0
        public bool _mutualGroup; // 0xA1
        public string _name; // 0xA8
        public string _ownerId; // 0xB0
        public string _shortCode; // 0xB8
        public string _discriminator; // 0xC0
        public string _iconUrl; // 0xC8
        public string _bannerUrl; // 0xD0
        public string _privacy; // 0xD8
        public string _visibility; // 0xE0
        public bool _isSubscribedToAnnouncements; // 0xE8
        public bool _isSubscribedToEventAnnouncements; // 0xE9
        public int _memberCount; // 0xEC
        public System.DateTime _joinedAt; // 0xF0
        public System.DateTime _bannedAt; // 0xF8
        public System.DateTime _lastPostReadAt; // 0x100
        public System.DateTime _lastPostCreatedAt; // 0x108
        public VRC.Core.APIUser _user; // 0x110
        public VRC.Core.APIGroup _group; // 0x118

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A380020
        public void get_groupId(){} // RVA: 0x7FFE81176D50
        public void set_groupId(){} // RVA: 0x7FFE81176D60
        public void get_userId(){} // RVA: 0x7FFE811C3590
        public void set_userId(){} // RVA: 0x7FFE811C35A0
        public void get_roleIds(){} // RVA: 0x7FFE81463AE0
        public void set_roleIds(){} // RVA: 0x7FFE81464570
        public void get_mRoleIds(){} // RVA: 0x7FFE81280C30
        public void set_mRoleIds(){} // RVA: 0x7FFE81282380
        public void get_permissions(){} // RVA: 0x7FFE8113A010
        public void set_permissions(){} // RVA: 0x7FFE81280F90
        public void get_memberVisibility(){} // RVA: 0x7FFE8154EB60
        public void set_memberVisibility(){} // RVA: 0x7FFE818CE320
        public void get_membershipStatus(){} // RVA: 0x7FFE817AE360
        public void set_membershipStatus(){} // RVA: 0x7FFE8171B470
        public void get_isRepresenting(){} // RVA: 0x7FFE820E9360
        public void set_isRepresenting(){} // RVA: 0x7FFE818DBD80
        public void get_mutualGroup(){} // RVA: 0x7FFE82AB0F00
        public void set_mutualGroup(){} // RVA: 0x7FFE82AB0F10
        public void get_name(){} // RVA: 0x7FFE817AB5E0
        public void set_name(){} // RVA: 0x7FFE81857260
        public void get_ownerId(){} // RVA: 0x7FFE81166040
        public void set_ownerId(){} // RVA: 0x7FFE81166050
        public void get_shortCode(){} // RVA: 0x7FFE811660B0
        public void set_shortCode(){} // RVA: 0x7FFE811660C0
        public void get_discriminator(){} // RVA: 0x7FFE81166120
        public void set_discriminator(){} // RVA: 0x7FFE81166130
        public void get_iconUrl(){} // RVA: 0x7FFE81253460
        public void set_iconUrl(){} // RVA: 0x7FFE81253470
        public void get_bannerUrl(){} // RVA: 0x7FFE81218100
        public void set_bannerUrl(){} // RVA: 0x7FFE81218110
        public void get_privacy(){} // RVA: 0x7FFE8181EA80
        public void set_privacy(){} // RVA: 0x7FFE8117C8A0
        public void get_visibility(){} // RVA: 0x7FFE8117C900
        public void set_visibility(){} // RVA: 0x7FFE8117C910
        public void get_isSubscribedToAnnouncements(){} // RVA: 0x7FFE822A56E0
        public void set_isSubscribedToAnnouncements(){} // RVA: 0x7FFE82C080B0
        public void get_isSubscribedToEventAnnouncements(){} // RVA: 0x7FFE871EB290
        public void set_isSubscribedToEventAnnouncements(){} // RVA: 0x7FFE8A3269C0
        public void get_memberCount(){} // RVA: 0x7FFE82A3B600
        public void set_memberCount(){} // RVA: 0x7FFE86DBACA0
        public void get_joinedAt(){} // RVA: 0x7FFE811662A0
        public void set_joinedAt(){} // RVA: 0x7FFE86F105E0
        public void get_bannedAt(){} // RVA: 0x7FFE8158D5D0
        public void set_bannedAt(){} // RVA: 0x7FFE84A61F90
        public void get_lastPostReadAt(){} // RVA: 0x7FFE81828B50
        public void set_lastPostReadAt(){} // RVA: 0x7FFE82472650
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFE8181E3D0
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFE813173C0
        public void get_user(){} // RVA: 0x7FFE81317980
        public void set_user(){} // RVA: 0x7FFE813159A0
        public void get_group(){} // RVA: 0x7FFE81318010
        public void set_group(){} // RVA: 0x7FFE81317920
        public void GetMemberships(){} // RVA: 0x7FFE8A380080
        public void SetVisibility(){} // RVA: 0x7FFE8A380460
        public void FetchGroup(){} // RVA: 0x7FFE8A380920
        public void GetRepresentation(){} // RVA: 0x7FFE8A380C70
    }

    public class APIGroupMemberList : ApiModel
    {
        public string _groupId; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APIGroupMember> _members; // 0x70

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFE81176D50
        public void set_groupId(){} // RVA: 0x7FFE81176D60
        public void get_members(){} // RVA: 0x7FFE811C3590
        public void set_members(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A381400 | overloaded x2
    }

    public class APIGroupPosts : ApiModel
    {
        public int _total; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APIGroupAnnouncement> _posts; // 0x70

        // ── Methods ──
        public void get_total(){} // RVA: 0x7FFE82A22EF0
        public void set_total(){} // RVA: 0x7FFE82A22F00
        public void get_posts(){} // RVA: 0x7FFE811C3590
        public void set_posts(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A37EDD0
    }

    public class APIGroupRole : ApiModel
    {
        public string _groupId; // 0x68
        public string _name; // 0x70
        public string _description; // 0x78
        public bool _isSelfAssignable; // 0x80
        public bool _requiresTwoFactor; // 0x81
        public bool _isManagementRole; // 0x82
        public bool _requiresPurchase; // 0x83
        public System.DateTime _createdAt; // 0x88
        public System.DateTime _updatedAt; // 0x90
        public bool _defaultRole; // 0x98
        public int _order; // 0x9C
        public System.Collections.Generic.List`1<string> _permissions; // 0xA0

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFE81176D50
        public void set_groupId(){} // RVA: 0x7FFE81176D60
        public void get_name(){} // RVA: 0x7FFE811C3590
        public void set_name(){} // RVA: 0x7FFE811C35A0
        public void get_description(){} // RVA: 0x7FFE81463AE0
        public void set_description(){} // RVA: 0x7FFE81464570
        public void get_isSelfAssignable(){} // RVA: 0x7FFE813A1130
        public void set_isSelfAssignable(){} // RVA: 0x7FFE813A2040
        public void get_requiresTwoFactor(){} // RVA: 0x7FFE813A1BA0
        public void set_requiresTwoFactor(){} // RVA: 0x7FFE8139FDD0
        public void get_isManagementRole(){} // RVA: 0x7FFE81EB0A60
        public void set_isManagementRole(){} // RVA: 0x7FFE86AD9DF0
        public void get_requiresPurchase(){} // RVA: 0x7FFE822C14E0
        public void set_requiresPurchase(){} // RVA: 0x7FFE86B36E80
        public void get_createdAt(){} // RVA: 0x7FFE8113A010
        public void set_createdAt(){} // RVA: 0x7FFE82C95CA0
        public void get_updatedAt(){} // RVA: 0x7FFE8154EB60
        public void set_updatedAt(){} // RVA: 0x7FFE81854020
        public void get_defaultRole(){} // RVA: 0x7FFE81611920
        public void set_defaultRole(){} // RVA: 0x7FFE81611930
        public void get_order(){} // RVA: 0x7FFE82B06F90
        public void set_order(){} // RVA: 0x7FFE82B06A30
        public void get_permissions(){} // RVA: 0x7FFE8179C860
        public void set_permissions(){} // RVA: 0x7FFE8171B4D0
        public void .ctor(){} // RVA: 0x7FFE8A381560 | overloaded x2
    }

    public class APIGroupRoleList : ApiModel
    {
        public string _groupId; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APIGroupRole> _roles; // 0x70

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x7FFE81176D50
        public void set_groupId(){} // RVA: 0x7FFE81176D60
        public void get_roles(){} // RVA: 0x7FFE811C3590
        public void set_roles(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A381870 | overloaded x2
    }

    public class APIProductGifting : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class APIProductGiftingCheck : ApiModel
    {
        public bool _eligible; // 0x68
        public string _reason; // 0x70
        public System.Collections.Generic.List`1<string> _eligibleProducts; // 0x78
        public System.Collections.Generic.List`1<string> _ineligibleProducts; // 0x80

        // ── Methods ──
        public void get_Eligible(){} // RVA: 0x7FFE811C3570
        public void set_Eligible(){} // RVA: 0x7FFE811C3580
        public void get_Reason(){} // RVA: 0x7FFE811C3590
        public void set_Reason(){} // RVA: 0x7FFE811C35A0
        public void get_EligibleProducts(){} // RVA: 0x7FFE81463AE0
        public void set_EligibleProducts(){} // RVA: 0x7FFE81464570
        public void get_IneligibleProducts(){} // RVA: 0x7FFE81280C30
        public void set_IneligibleProducts(){} // RVA: 0x7FFE81282380
        public void Check(){} // RVA: 0x7FFE8A324830
        public void .ctor(){} // RVA: 0x7FFE8A324E00
    }

    public class APIPurchasedGiftBundle : ApiModel
    {
        public string _transactionId; // 0x68
        public string _store; // 0x70
        public string _steamItemId; // 0x78
        public string _oculusSku; // 0x80
        public string _googleProductId; // 0x88
        public string _googlePlanId; // 0x90
        public string _picoSku; // 0x98
        public int _amount; // 0xA0
        public string _description; // 0xA8
        public string _period; // 0xB0
        public bool _consumed; // 0xB8
        public string _status; // 0xC0
        public string _created_at; // 0xC8
        public string _updated_at; // 0xD0
        public bool _isBulkGift; // 0xD8
        public string[] _targets; // 0xE0
        public int _bulkSize; // 0xE8
        public int _discountPercentage; // 0xEC
        public int _totalConsumed; // 0xF0
        public int _totalUnconsumed; // 0xF4
        public int _failures; // 0xF8

        // ── Methods ──
        public void get_transactionId(){} // RVA: 0x7FFE81176D50
        public void set_transactionId(){} // RVA: 0x7FFE81176D60
        public void get_store(){} // RVA: 0x7FFE811C3590
        public void set_store(){} // RVA: 0x7FFE811C35A0
        public void get_steamItemId(){} // RVA: 0x7FFE81463AE0
        public void set_steamItemId(){} // RVA: 0x7FFE81464570
        public void get_oculusSku(){} // RVA: 0x7FFE81280C30
        public void set_oculusSku(){} // RVA: 0x7FFE81282380
        public void get_googleProductId(){} // RVA: 0x7FFE8113A010
        public void set_googleProductId(){} // RVA: 0x7FFE81280F90
        public void get_googlePlanId(){} // RVA: 0x7FFE8154EB60
        public void set_googlePlanId(){} // RVA: 0x7FFE818CE320
        public void get_picoSku(){} // RVA: 0x7FFE817AE360
        public void set_picoSku(){} // RVA: 0x7FFE8171B470
        public void get_amount(){} // RVA: 0x7FFE82B06FB0
        public void set_amount(){} // RVA: 0x7FFE82B06FC0
        public void get_description(){} // RVA: 0x7FFE817AB5E0
        public void set_description(){} // RVA: 0x7FFE81857260
        public void get_period(){} // RVA: 0x7FFE81166040
        public void set_period(){} // RVA: 0x7FFE81166050
        public void get_consumed(){} // RVA: 0x7FFE824AEC00
        public void set_consumed(){} // RVA: 0x7FFE824AD2F0
        public void get_status(){} // RVA: 0x7FFE81166120
        public void set_status(){} // RVA: 0x7FFE81166130
        public void get_created_at(){} // RVA: 0x7FFE81253460
        public void set_created_at(){} // RVA: 0x7FFE81253470
        public void get_updated_at(){} // RVA: 0x7FFE81218100
        public void set_updated_at(){} // RVA: 0x7FFE81218110
        public void get_isBulkGift(){} // RVA: 0x7FFE82078290
        public void set_isBulkGift(){} // RVA: 0x7FFE86C70900
        public void get_targets(){} // RVA: 0x7FFE8117C900
        public void set_targets(){} // RVA: 0x7FFE8117C910
        public void get_bulkSize(){} // RVA: 0x7FFE82A3E380
        public void set_bulkSize(){} // RVA: 0x7FFE86DBADE0
        public void get_discountPercentage(){} // RVA: 0x7FFE82A3B600
        public void set_discountPercentage(){} // RVA: 0x7FFE86DBACA0
        public void get_totalConsumed(){} // RVA: 0x7FFE843B5350
        public void set_totalConsumed(){} // RVA: 0x7FFE86DBACB0
        public void get_totalUnconsumed(){} // RVA: 0x7FFE84A61F50
        public void set_totalUnconsumed(){} // RVA: 0x7FFE84A61F60
        public void get_failures(){} // RVA: 0x7FFE82144660
        public void set_failures(){} // RVA: 0x7FFE8213C830
        public void .ctor(){} // RVA: 0x7FFE8A2D6590
    }

    public class APIQueue : Object
    {
        // ── Methods ──
        public void JoinQueue(){} // RVA: 0x7FFE8A32A100
        public void SetQueue(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void LeaveQueue(){} // RVA: 0x7FFE8A32A570
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class APIResponseHandler : Object
    {
        // ── Methods ──
        public void HandleResponse(){} // RVA: 0x7FFE8A32D6A0
        public void extractResponseErrorMessage(){} // RVA: 0x7FFE8A32D8D0
        public void RetryRequest(){} // RVA: 0x7FFE8A32DA40
        public void .cctor(){} // RVA: 0x7FFE8A32E1B0
    }

    public class APISticker : ApiModel
    {
        public string _fileId; // 0x68
        public string _imageUrl; // 0x70
        public string _specialEffect; // 0x78
        public string _animationStyle; // 0x80
        public string _maskTag; // 0x88
        public bool _animated; // 0x90
        public int _frames; // 0x94
        public int _framesOverTime; // 0x98
        public string _loopStyle; // 0xA0
        public string _assetBundleId; // 0xA8

        // ── Methods ──
        public void get_fileId(){} // RVA: 0x7FFE81176D50
        public void set_fileId(){} // RVA: 0x7FFE81176D60
        public void get_imageUrl(){} // RVA: 0x7FFE811C3590
        public void set_imageUrl(){} // RVA: 0x7FFE811C35A0
        public void get_specialEffect(){} // RVA: 0x7FFE81463AE0
        public void set_specialEffect(){} // RVA: 0x7FFE81464570
        public void get_animationStyle(){} // RVA: 0x7FFE81280C30
        public void set_animationStyle(){} // RVA: 0x7FFE81282380
        public void get_maskTag(){} // RVA: 0x7FFE8113A010
        public void set_maskTag(){} // RVA: 0x7FFE81280F90
        public void get_animated(){} // RVA: 0x7FFE820BF400
        public void set_animated(){} // RVA: 0x7FFE820BFEB0
        public void get_frames(){} // RVA: 0x7FFE814AA230
        public void set_frames(){} // RVA: 0x7FFE81680470
        public void get_framesOverTime(){} // RVA: 0x7FFE82B06A40
        public void set_framesOverTime(){} // RVA: 0x7FFE82B06FA0
        public void get_loopStyle(){} // RVA: 0x7FFE8179C860
        public void set_loopStyle(){} // RVA: 0x7FFE8171B4D0
        public void get_assetBundleId(){} // RVA: 0x7FFE817AB5E0
        public void set_assetBundleId(){} // RVA: 0x7FFE81857260
        public void UploadSticker(){} // RVA: 0x7FFE8A331F20 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE8A332530
    }

    public class APISubscription : ApiModel
    {
        public System.Collections.Generic.Dictionary`2<string,object> _response; // 0x68

        // ── Methods ──
        public void get_response(){} // RVA: 0x7FFE81176D50
        public void set_response(){} // RVA: 0x7FFE81176D60
        public void .ctor(){} // RVA: 0x7FFE8A3326E0
    }

    public class APITutorial : ApiModel
    {
        public string VRCHAT_GET_TUTORIAL_ENDPOINT;
        public bool _isTutorialCompleted; // 0x68
        public bool _completedAnyTutorial; // 0x69

        // ── Methods ──
        public void get_IsTutorialCompleted(){} // RVA: 0x7FFE811C3570
        public void set_IsTutorialCompleted(){} // RVA: 0x7FFE811C3580
        public void get_CompletedAnyTutorial(){} // RVA: 0x7FFE85B63B60
        public void set_CompletedAnyTutorial(){} // RVA: 0x7FFE85B63740
        public void get_TutorialKey(){} // RVA: 0x7FFE811C3590
        public void set_TutorialKey(){} // RVA: 0x7FFE811C35A0
        public void LoadTutorial(){} // RVA: 0x7FFE8A335010
        public void .ctor(){} // RVA: 0x7FFE8A335320
    }

    public class APIUIColorPalette : ApiModel
    {
        public string _ownerId; // 0x68
        public string _name; // 0x70
        public string _highlights; // 0x78
        public string _icons; // 0x80
        public string _buttons; // 0x88
        public string _backgrounds; // 0x90
        public string _text; // 0x98
        public string _subtext; // 0xA0

        // ── Methods ──
        public void get_ownerId(){} // RVA: 0x7FFE81176D50
        public void set_ownerId(){} // RVA: 0x7FFE81176D60
        public void get_name(){} // RVA: 0x7FFE811C3590
        public void set_name(){} // RVA: 0x7FFE811C35A0
        public void get_highlights(){} // RVA: 0x7FFE81463AE0
        public void set_highlights(){} // RVA: 0x7FFE81464570
        public void get_icons(){} // RVA: 0x7FFE81280C30
        public void set_icons(){} // RVA: 0x7FFE81282380
        public void get_buttons(){} // RVA: 0x7FFE8113A010
        public void set_buttons(){} // RVA: 0x7FFE81280F90
        public void get_backgrounds(){} // RVA: 0x7FFE8154EB60
        public void set_backgrounds(){} // RVA: 0x7FFE818CE320
        public void get_text(){} // RVA: 0x7FFE817AE360
        public void set_text(){} // RVA: 0x7FFE8171B470
        public void get_subtext(){} // RVA: 0x7FFE8179C860
        public void set_subtext(){} // RVA: 0x7FFE8171B4D0
        public void Fetch(){} // RVA: 0x7FFE8A3354C0
        public void Save(){} // RVA: 0x7FFE8A335870
        public void GetCurrent(){} // RVA: 0x7FFE8A336150
        public void SetCurrent(){} // RVA: 0x7FFE8A336430
        public void Update(){} // RVA: 0x7FFE8A336820
        public void .ctor(){} // RVA: 0x7FFE8A336B60
        public void .cctor(){} // RVA: 0x7FFE8A336BB0
    }

    public class APIUser : ApiModel
    {
        public float SINGLE_RECORD_CACHE_TIME;
        public float SEARCH_CACHE_TIME;
        public int MAX_STATUS_DESCRIPTION_LENGTH;
        public int MAX_BIO_TEXT_LENGTH;
        public string STATUS_ONLINE_API_STRING;
        public string STATUS_JOIN_ME_API_STRING;
        public string STATUS_ASK_ME_API_STRING;
        public string STATUS_OFFLINE_API_STRING;
        public string STATUS_DO_NOT_DISTURB_API_STRING;
        public string STATUS_ONLINE_DEFAULT_DISPLAY_STRING;
        public string STATUS_JOIN_DEFAULT_ME_DISPLAY_STRING;
        public string STATUS_ASK_ME_DEFAULT_DISPLAY_STRING;
        public string STATUS_OFFLINE_DEFAULT_DISPLAY_STRING;
        public string STATUS_DO_NOT_DISTURB_DEFAULT_DISPLAY_STRING;
        public string _blob; // 0x68
        public string _displayName; // 0x70
        public string _username; // 0x78
        public string _pronouns; // 0x80
        public string _bio; // 0x88
        public System.Collections.Generic.List`1<string> _bioLinks; // 0x90
        public string _location; // 0x98
        public string _avatarId; // 0xA0
        public string _fallbackId; // 0xA8
        public bool _hasEmail; // 0xB0
        public bool _isBoopingEnabled; // 0xB1
        public bool _hasBirthday; // 0xB2
        public bool _isFriend; // 0xB3
        public string _friendKey; // 0xB8
        public string _friendRequestStatus; // 0xC0
        public string _last_login; // 0xC8
        public string _last_activity; // 0xD0
        public string _date_joined; // 0xD8
        public 0x664AB31C _developerType; // 0xE0
        public System.Collections.Generic.List`1<VRC.Core.VRCEvent> _events; // 0xE8
        public int _acceptedTOSVersion; // 0xF0
        public string _queuedInstance; // 0xF8
        public int _queuedInstancePosition; // 0x100
        public int _acceptedPrivacyVersion; // 0x104
        public string _currentAvatarImageUrl; // 0x108
        public string _currentAvatarThumbnailImageUrl; // 0x110
        public System.Collections.Generic.List`1<string> _currentAvatarTags; // 0x118
        public string _authToken; // 0x120
        public bool _emailVerified; // 0x128
        public bool _hasPendingEmail; // 0x129
        public string _obfuscatedPendingEmail; // 0x130
        public System.Collections.Generic.List`1<string> _friendIDs; // 0x138
        public string _currentAvatarAssetUrl; // 0x140
        public System.Collections.Generic.Dictionary`2<string,object> _steamDetails; // 0x148
        public string _travelingToLocation; // 0x150
        public string _obfuscatedEmail; // 0x158
        public bool _unsubscribe; // 0x160
        public bool _hasLoggedInFromClient; // 0x161
        public System.Collections.Generic.List`1<string> _pastDisplayNames; // 0x168
        public string _homeLocation; // 0x170
        public System.Collections.Generic.List`1<string> _tags; // 0x178
        public string _status; // 0x180
        public string _statusDescription; // 0x188
        public System.Collections.Generic.List`1<VRC.Core.ApiBadge> _badges; // 0x190
        public System.Collections.Generic.List`1<string> _statusHistory; // 0x198
        public string _state; // 0x1A0
        public bool _allowAvatarCopying; // 0x1A8
        public bool _hasSharedConnectionsOptOut; // 0x1A9
        public bool _hasDiscordFriendsOptOut; // 0x1AA
        public string _userIcon; // 0x1B0
        public string _profilePicOverride; // 0x1B8
        public string _note; // 0x1C0
        public string _iconUrl; // 0x1C8
        public string _thumbnailUrl; // 0x1D0
        public bool _hideContentFilterSettings; // 0x1D8
        public System.Collections.Generic.List`1<string> _contentFilters; // 0x1E0
        public string _userLanguageCode; // 0x1E8
        public bool _ageVerified; // 0x1F0
        public bool _isAdult; // 0x1F1
        public string _ageVerificationStatus; // 0x1F8
        public string _discordId; // 0x200
        public bool _hasAcceptedDiscordSocialSDKPerms; // 0x208
        public string _last_platform; // 0x210
        public string _platform; // 0x218
        public string _last_mobile; // 0x220
        public bool _twoFactorAuthEnabled; // 0x228
        public System.Collections.Generic.Dictionary`2<string,object> _twoFactorAuthMethods; // 0x230
        public System.Collections.Generic.Dictionary`2<string,string> _languageTagsDictionary;
        public System.Collections.Generic.List`1<string> _languagesDisplayNames; // 0x238
        public System.Collections.Generic.List`1<string> _languagesShortNames; // 0x240
        public System.Collections.Hashtable statusDefaultDescriptions; // 0x8
        public VRC.Core.APIUser _currentUser; // 0x10
        public object get_Default; // 0xFB30
        public object field_87;
        public object field_88; // 0xFCF8
        public object field_89;
        public object field_90; // 0xEAD0
        public object field_91;
        public object field_92;
        public object field_93; // 0x2081
        public object field_94;
        public object field_95;
        public object field_96;
        public object field_97;
        public object field_98;
        public object field_99; // 0xD1F0
        public object get_Default; // 0xA5E0
        public object field_101;
        public object field_102; // 0x1E00
        public object field_103; // 0x3140
        public object field_104; // 0xF260
        public bool field_105; // 0x1C28
        public object field_106; // 0x30A0
        public object field_107;
        public object field_108; // 0x3160
        public object field_109;
        public object field_110; // 0x1CB0
        public object field_111; // 0x1CB0
        public object field_112;
        public object field_113; // 0x10

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFE8A336EB0
        public void GetLifeSpan(){} // RVA: 0x7FFE820D9A10
        public void get_blob(){} // RVA: 0x7FFE81176D50
        public void set_blob(){} // RVA: 0x7FFE81176D60
        public void get_displayName(){} // RVA: 0x7FFE811C3590
        public void set_displayName(){} // RVA: 0x7FFE811C35A0
        public void get_username(){} // RVA: 0x7FFE81463AE0
        public void set_username(){} // RVA: 0x7FFE81464570
        public void get_pronouns(){} // RVA: 0x7FFE81280C30
        public void set_pronouns(){} // RVA: 0x7FFE81282380
        public void get_bio(){} // RVA: 0x7FFE8113A010
        public void set_bio(){} // RVA: 0x7FFE81280F90
        public void get_bioLinks(){} // RVA: 0x7FFE8154EB60
        public void set_bioLinks(){} // RVA: 0x7FFE818CE320
        public void get_location(){} // RVA: 0x7FFE817AE360
        public void set_location(){} // RVA: 0x7FFE8171B470
        public void get_avatarId(){} // RVA: 0x7FFE8179C860
        public void set_avatarId(){} // RVA: 0x7FFE8171B4D0
        public void get_fallbackId(){} // RVA: 0x7FFE817AB5E0
        public void set_fallbackId(){} // RVA: 0x7FFE81857260
        public void get_hasEmail(){} // RVA: 0x7FFE824A0700
        public void set_hasEmail(){} // RVA: 0x7FFE824A0BA0
        public void get_isBoopingEnabled(){} // RVA: 0x7FFE848BEF10
        public void set_isBoopingEnabled(){} // RVA: 0x7FFE848BEF20
        public void get_hasBirthday(){} // RVA: 0x7FFE86CE93D0
        public void set_hasBirthday(){} // RVA: 0x7FFE86CE93E0
        public void get_isFriend(){} // RVA: 0x7FFE86CE93F0
        public void set_isFriend(){} // RVA: 0x7FFE86CE9400
        public void get_friendKey(){} // RVA: 0x7FFE811660B0
        public void set_friendKey(){} // RVA: 0x7FFE811660C0
        public void get_friendRequestStatus(){} // RVA: 0x7FFE81166120
        public void set_friendRequestStatus(){} // RVA: 0x7FFE81166130
        public void get_last_login(){} // RVA: 0x7FFE81253460
        public void set_last_login(){} // RVA: 0x7FFE81253470
        public void get_last_activity(){} // RVA: 0x7FFE81218100
        public void set_last_activity(){} // RVA: 0x7FFE81218110
        public void get_date_joined(){} // RVA: 0x7FFE8181EA80
        public void set_date_joined(){} // RVA: 0x7FFE8117C8A0
        public void get_developerType(){} // RVA: 0x7FFE82AA02F0
        public void set_developerType(){} // RVA: 0x7FFE82AA0300
        public void get_events(){} // RVA: 0x7FFE8117C970
        public void set_events(){} // RVA: 0x7FFE8117C980
        public void get_acceptedTOSVersion(){} // RVA: 0x7FFE843B5350
        public void set_acceptedTOSVersion(){} // RVA: 0x7FFE86DBACB0
        public void get_queuedInstance(){} // RVA: 0x7FFE8158D5D0
        public void set_queuedInstance(){} // RVA: 0x7FFE81B0E4B0
        public void get_queuedInstancePosition(){} // RVA: 0x7FFE86FAEB50
        public void set_queuedInstancePosition(){} // RVA: 0x7FFE88023130
        public void get_acceptedPrivacyVersion(){} // RVA: 0x7FFE82A184B0
        public void set_acceptedPrivacyVersion(){} // RVA: 0x7FFE827ED250
        public void get_currentAvatarImageUrl(){} // RVA: 0x7FFE8181E3D0
        public void set_currentAvatarImageUrl(){} // RVA: 0x7FFE81A60200
        public void get_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFE81317980
        public void set_currentAvatarThumbnailImageUrl(){} // RVA: 0x7FFE813159A0
        public void get_currentAvatarTags(){} // RVA: 0x7FFE81318010
        public void set_currentAvatarTags(){} // RVA: 0x7FFE81317920
        public void get_authToken(){} // RVA: 0x7FFE813A1DA0
        public void set_authToken(){} // RVA: 0x7FFE813A0830
        public void get_emailVerified(){} // RVA: 0x7FFE8158C5E0
        public void set_emailVerified(){} // RVA: 0x7FFE8158E950
        public void get_hasPendingEmail(){} // RVA: 0x7FFE8A336F10
        public void set_hasPendingEmail(){} // RVA: 0x7FFE8A336F20
        public void get_obfuscatedPendingEmail(){} // RVA: 0x7FFE81823850
        public void set_obfuscatedPendingEmail(){} // RVA: 0x7FFE81B31120
        public void get_friendIDs(){} // RVA: 0x7FFE8181EA70
        public void set_friendIDs(){} // RVA: 0x7FFE818254E0
        public void get_currentAvatarAssetUrl(){} // RVA: 0x7FFE811665F0
        public void set_currentAvatarAssetUrl(){} // RVA: 0x7FFE81166600
        public void get_steamDetails(){} // RVA: 0x7FFE81166660
        public void set_steamDetails(){} // RVA: 0x7FFE81166670
        public void get_travelingToLocation(){} // RVA: 0x7FFE81790740
        public void set_travelingToLocation(){} // RVA: 0x7FFE81B350B0
        public void get_obfuscatedEmail(){} // RVA: 0x7FFE81B16560
        public void set_obfuscatedEmail(){} // RVA: 0x7FFE81B21880
        public void get_unsubscribe(){} // RVA: 0x7FFE86DBB030
        public void set_unsubscribe(){} // RVA: 0x7FFE86DBB040
        public void get_hasLoggedInFromClient(){} // RVA: 0x7FFE86DBB050
        public void set_hasLoggedInFromClient(){} // RVA: 0x7FFE86DBB060
        public void get_pastDisplayNames(){} // RVA: 0x7FFE81B2CB70
        public void set_pastDisplayNames(){} // RVA: 0x7FFE81B23F80
        public void get_homeLocation(){} // RVA: 0x7FFE815BB6A0
        public void set_homeLocation(){} // RVA: 0x7FFE81B38790
        public void get_tags(){} // RVA: 0x7FFE815BB1F0
        public void set_tags(){} // RVA: 0x7FFE8A336F30
        public void get_status(){} // RVA: 0x7FFE81B38340
        public void set_status(){} // RVA: 0x7FFE81B31180
        public void get_statusDescription(){} // RVA: 0x7FFE81B295E0
        public void set_statusDescription(){} // RVA: 0x7FFE81B2E3B0
        public void get_badges(){} // RVA: 0x7FFE81825EC0
        public void set_badges(){} // RVA: 0x7FFE81B2A360
        public void get_statusHistory(){} // RVA: 0x7FFE8181EA60
        public void set_statusHistory(){} // RVA: 0x7FFE81B33630
        public void get_state(){} // RVA: 0x7FFE81B32390
        public void set_state(){} // RVA: 0x7FFE81B21CA0
        public void get_allowAvatarCopying(){} // RVA: 0x7FFE87011A90
        public void set_allowAvatarCopying(){} // RVA: 0x7FFE87011AA0
        public void get_hasSharedConnectionsOptOut(){} // RVA: 0x7FFE87011AB0
        public void set_hasSharedConnectionsOptOut(){} // RVA: 0x7FFE87011AC0
        public void get_hasDiscordFriendsOptOut(){} // RVA: 0x7FFE87011B10
        public void set_hasDiscordFriendsOptOut(){} // RVA: 0x7FFE87011B20
        public void get_userIcon(){} // RVA: 0x7FFE81B23A60
        public void set_userIcon(){} // RVA: 0x7FFE81B2ACE0
        public void get_profilePicOverride(){} // RVA: 0x7FFE81B164E0
        public void set_profilePicOverride(){} // RVA: 0x7FFE81B38D70
        public void get_note(){} // RVA: 0x7FFE817EFE00
        public void set_note(){} // RVA: 0x7FFE81B0C930
        public void get_iconUrl(){} // RVA: 0x7FFE81B16E90
        public void set_iconUrl(){} // RVA: 0x7FFE81B290E0
        public void get_thumbnailUrl(){} // RVA: 0x7FFE81B32320
        public void set_thumbnailUrl(){} // RVA: 0x7FFE81B31B60
        public void get_hideContentFilterSettings(){} // RVA: 0x7FFE82A2C670
        public void set_hideContentFilterSettings(){} // RVA: 0x7FFE82A2C680
        public void get_contentFilters(){} // RVA: 0x7FFE816611A0
        public void set_contentFilters(){} // RVA: 0x7FFE81B31CF0
        public void get_userLanguageCode(){} // RVA: 0x7FFE81B27D50
        public void set_userLanguageCode(){} // RVA: 0x7FFE81B34FD0
        public void get_ageVerified(){} // RVA: 0x7FFE87014660
        public void set_ageVerified(){} // RVA: 0x7FFE8A336FA0
        public void get_isAdult(){} // RVA: 0x7FFE823EA970
        public void set_isAdult(){} // RVA: 0x7FFE8A336FB0
        public void get_ageVerificationStatus(){} // RVA: 0x7FFE81B20B40
        public void set_ageVerificationStatus(){} // RVA: 0x7FFE81B2E610
        public void get_discordId(){} // RVA: 0x7FFE81B14500
        public void set_discordId(){} // RVA: 0x7FFE81B317A0
        public void get_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x7FFE86FECE80
        public void set_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x7FFE8A336FC0
        public void get_last_platform(){} // RVA: 0x7FFE81B0A180
        public void set_last_platform(){} // RVA: 0x7FFE8A336FD0
        public void get_platform(){} // RVA: 0x7FFE81B296E0
        public void set_platform(){} // RVA: 0x7FFE81B38350
        public void get_last_mobile(){} // RVA: 0x7FFE81B310E0
        public void set_last_mobile(){} // RVA: 0x7FFE81B21BD0
        public void get_twoFactorAuthEnabled(){} // RVA: 0x7FFE874563B0
        public void set_twoFactorAuthEnabled(){} // RVA: 0x7FFE8A337150
        public void get_twoFactorAuthMethods(){} // RVA: 0x7FFE81B23A70
        public void set_twoFactorAuthMethods(){} // RVA: 0x7FFE81B39ED0
        public void get_LanguageTagsDictionary(){} // RVA: 0x7FFE8A337160
        public void get_languagesDisplayNames(){} // RVA: 0x7FFE81B20B50
        public void set_languagesDisplayNames(){} // RVA: 0x7FFE81B2F9F0
        public void set_LanguagesShortNames(){} // RVA: 0x7FFE81B2E9D0
        public void get_LanguagesShortNames(){} // RVA: 0x7FFE81B26960
        public void SetUserLanguages(){} // RVA: 0x7FFE8A3375F0
        public void get_ShouldSeeInstanceByStatus(){} // RVA: 0x7FFE8A3379B0
        public void get_IsOnMobile(){} // RVA: 0x7FFE8A3379F0
        public void get_profilePicImageUrl(){} // RVA: 0x7FFE8A337A10
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x7FFE8A337A30
        public void FetchBalance(){} // RVA: 0x7FFE8A337A50
        public void get_IsAccountVerified(){} // RVA: 0x7FFE811E0850
        public void get_hasNoPowers(){} // RVA: 0x7FFE8A337DE0
        public void get_hasScriptingAccess(){} // RVA: 0x7FFE8A337E30
        public void get_hasModerationPowers(){} // RVA: 0x7FFE8A337F30
        public void get_hasVIPAccess(){} // RVA: 0x7FFE8A337FF0
        public void get_hasSuperPowers(){} // RVA: 0x7FFE8A338040
        public void get_canPublishWorldsAndAvatars(){} // RVA: 0x7FFE8A338090
        public void get_canPublishAllContent(){} // RVA: 0x7FFE8A3382B0
        public void get_canPublishAvatars(){} // RVA: 0x7FFE8A3383E0
        public void get_canPublishWorlds(){} // RVA: 0x7FFE8A338500
        public void get_canPublishProps(){} // RVA: 0x7FFE8A338620
        public void get_isUntrusted(){} // RVA: 0x7FFE8A338740
        public void get_isNewUser(){} // RVA: 0x7FFE8A3387A0
        public void get_isEarlyAdopter(){} // RVA: 0x7FFE8A338860
        public void get_isSupporter(){} // RVA: 0x7FFE8A338920
        public void get_hasBasicTrustLevel(){} // RVA: 0x7FFE8A3389E0
        public void get_hasKnownTrustLevel(){} // RVA: 0x7FFE8A338AB0
        public void get_hasTrustedTrustLevel(){} // RVA: 0x7FFE8A338B80
        public void get_hasVeteranTrustLevel(){} // RVA: 0x7FFE8A338C50
        public void get_hasLegendTrustLevel(){} // RVA: 0x7FFE8A338D20
        public void get_hasNegativeTrustLevel(){} // RVA: 0x7FFE8A338DF0
        public void get_hasVeryNegativeTrustLevel(){} // RVA: 0x7FFE8A338EC0
        public void get_hasFeedbackAccess(){} // RVA: 0x7FFE8A338F80
        public void get_showSocialRank(){} // RVA: 0x7FFE8A339040
        public void get_showModTag(){} // RVA: 0x7FFE8A3390E0
        public void get_canSetStatusOffline(){} // RVA: 0x7FFE8A339180
        public void get_statusIsSetToOffline(){} // RVA: 0x7FFE8A3391E0
        public void get_statusIsSetToJoinMe(){} // RVA: 0x7FFE8A339310
        public void get_statusIsSetToAskMe(){} // RVA: 0x7FFE8A3393B0
        public void get_statusIsSetToDoNotDisturb(){} // RVA: 0x7FFE8A3394E0
        public void get_statusDefaultDescriptionDisplayString(){} // RVA: 0x7FFE8A339610
        public void truncatedBio(){} // RVA: 0x7FFE8A3397A0
        public void truncatedStatusDescription(){} // RVA: 0x7FFE8A339810
        public void get_statusDescriptionDisplayString(){} // RVA: 0x7FFE8A339880
        public void get_statusValue(){} // RVA: 0x7FFE8A339940
        public void get_CurrentLocation(){} // RVA: 0x7FFE8A3399B0
        public void get_canSeeAllUsersStatus(){} // RVA: 0x7FFE8A339D10
        public void MergeFieldsInto(){} // RVA: 0x7FFE8A339D70
        public void get_IsLoggedIn(){} // RVA: 0x7FFE8A33A5F0
        public void get_IsSelf(){} // RVA: 0x7FFE8A33A680
        public void get_CurrentUser(){} // RVA: 0x7FFE8A33A7D0
        public void set_CurrentUser(){} // RVA: 0x7FFE8A33A830
        public void .ctor(){} // RVA: 0x7FFE8A33AB60 | overloaded x2
        public void ReadField(){} // RVA: 0x7FFE8A33B980
        public void WriteField(){} // RVA: 0x7FFE8A33BA30
        public void InitialFetchCurrentUser(){} // RVA: 0x7FFE8A33BBC0
        public void Register(){} // RVA: 0x7FFE8A33BFE0
        public void UpdateAccountInfo(){} // RVA: 0x7FFE8A33CA10
        public void Login(){} // RVA: 0x7FFE8A33D4E0
        public void VerifyTwoFactorAuthCode(){} // RVA: 0x7FFE8A33D9D0
        public void VerifyStepUpAuthCode(){} // RVA: 0x7FFE8A33DFC0
        public void ThirdPartyLogin(){} // RVA: 0x7FFE8A33EB40
        public void DiscordLogin(){} // RVA: 0x7FFE8A33EF50
        public void DiscordFinalizeLogin(){} // RVA: 0x7FFE8A33F520
        public void DiscordLinkStatus(){} // RVA: 0x7FFE8A340010
        public void DiscordUnlink(){} // RVA: 0x7FFE8A340500
        public void DiscordAccess(){} // RVA: 0x7FFE8A340840
        public void RedeemPromo(){} // RVA: 0x7FFE8A340B80
        public void Logout(){} // RVA: 0x7FFE8A340F70
        public void FetchPublishWorldsInformation(){} // RVA: 0x7FFE8A3410C0
        public void FetchUsers(){} // RVA: 0x7FFE8A341DE0 | overloaded x2
        public void FetchUser(){} // RVA: 0x7FFE8A341A70
        public void FetchUsersSearchResults(){} // RVA: 0x7FFE8A3421C0
        public void FetchFriends(){} // RVA: 0x7FFE8A3425D0
        public void AttemptVerification(){} // RVA: 0x7FFE8A343040
        public void TagsToDeveloperType(){} // RVA: 0x7FFE8A343100
        public void SetIsBoopingEnabled(){} // RVA: 0x7FFE8A343170
        public void AddLanguage(){} // RVA: 0x7FFE8A3435D0
        public void RemoveLanguage(){} // RVA: 0x7FFE8A343BA0
        public void AddLink(){} // RVA: 0x7FFE8A344130
        public void ModifyLink(){} // RVA: 0x7FFE8A344670
        public void UpdateBio(){} // RVA: 0x7FFE8A344B10
        public void UpdateContentFilters(){} // RVA: 0x7FFE8A345100
        public void UpdateUserLanguageCode(){} // RVA: 0x7FFE8A345520
        public void AddNewStatusToHistory(){} // RVA: 0x7FFE8A345B00
        public void StatusValueToString(){} // RVA: 0x7FFE8A345CC0
        public void StringToStatusValue(){} // RVA: 0x7FFE8A345E20
        public void UnfriendUser(){} // RVA: 0x7FFE8A3460A0
        public void LocalAddFriend(){} // RVA: 0x7FFE8A3464B0
        public void IsFriendsWith(){} // RVA: 0x7FFE8A346700
        public void get_HasRequestedToBeFriend(){} // RVA: 0x7FFE8A346930
        public void set_HasRequestedToBeFriend(){} // RVA: 0x7FFE8A3469B0
        public void get_HasFriendRequestPending(){} // RVA: 0x7FFE8A346A50
        public void set_HasFriendRequestPending(){} // RVA: 0x7FFE8A346AD0
        public void SetAvatarPropertiesFromModel(){} // RVA: 0x7FFE8A346B70
        public void SetAvatarFallbackPropertiesFromModel(){} // RVA: 0x7FFE8A346DD0
        public void Exists(){} // RVA: 0x7FFE8A346EC0
        public void HasTag(){} // RVA: 0x7FFE8A346F00
        public void AddTag(){} // RVA: 0x7FFE8A346F70
        public void RemoveTag(){} // RVA: 0x7FFE8A347010
        public void Equals(){} // RVA: 0x7FFE8A347160
        public void UpdateNote(){} // RVA: 0x7FFE8A347210
        public void SetUserInterests(){} // RVA: 0x7FFE8A3478A0
        public void GetUserInterests(){} // RVA: 0x7FFE8A347B70
        public void CheckIfPersistenceDataExistsForWorld(){} // RVA: 0x7FFE8A347E80
        public void ResetPersistenceDataForWorld(){} // RVA: 0x7FFE8A348230
        public void ResetAllPersistenceDataForWorlds(){} // RVA: 0x7FFE8A3485D0
        public void UpdateBadge(){} // RVA: 0x7FFE8A348910
        public void ToString(){} // RVA: 0x7FFE8A349170
        public void .cctor(){} // RVA: 0x7FFE8A3494B0
    }

    public class AnalyticsInterface : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE8A390690
        public void SetBuildVersion(){} // RVA: 0x7FFE8A3907E0
        public void SetLogger(){} // RVA: 0x7FFE8A390890
        public void Send(){} // RVA: 0x7FFE8A390970
        public void SetUserId(){} // RVA: 0x7FFE8A390A60
        public void SetSessionId(){} // RVA: 0x7FFE8A390B10
        public void GetSessionId(){} // RVA: 0x7FFE8A390BD0
        public void SetUserProperties(){} // RVA: 0x7FFE8A390C70
        public void ClearCachedData(){} // RVA: 0x7FFE8A390D30
        public void OnApplicationQuit(){} // RVA: 0x7FFE8A390E70
        public void HasPendingEvents(){} // RVA: 0x7FFE8A390F40
        public void OnApplicationFocused(){} // RVA: 0x7FFE8A391010
        public void OnApplicationPaused(){} // RVA: 0x7FFE8A3910B0
        public void CheckInstance(){} // RVA: 0x7FFE8A391170
    }

    public class AnalyticsSDK : Object
    {
        // ── Methods ──
        public void GetProjectTypeString(){} // RVA: 0x7FFE8A391250
        public void Initialize(){} // RVA: 0x7FFE8A391300
        public void LoggedInUserChanged(){} // RVA: 0x7FFE8A391460 | overloaded x2
        public void AddOtherProperties(){} // RVA: 0x7FFE8A3916B0
        public void AvatarUploadFailed(){} // RVA: 0x7FFE8A391850
        public void WorldUploadFailed(){} // RVA: 0x7FFE8A3919C0
        public void PropUploadFailed(){} // RVA: 0x7FFE8A391B30
        public void ExampleCentralOpened(){} // RVA: 0x7FFE8A391CA0
        public void ExampleDownloaded(){} // RVA: 0x7FFE8A391E40
        public void ExamplePreviewed(){} // RVA: 0x7FFE8A392080
        public void CheckInit(){} // RVA: 0x7FFE8A3923F0
        public void BuildAndTestLaunched(){} // RVA: 0x7FFE8A392520
        public void ProjectPublished(){} // RVA: 0x7FFE8A3927B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE8A392BF0
    }

    public class ApiAccountUpgrade : ApiModel
    {
        public bool _isUpgrading; // 0x68
        public bool _subscribedToMarketingEmails; // 0x69
        public bool _hasEmail; // 0x6A
        public bool _emailVerified; // 0x6B

        // ── Methods ──
        public void get_isUpgrading(){} // RVA: 0x7FFE811C3570
        public void set_isUpgrading(){} // RVA: 0x7FFE811C3580
        public void get_subscribedToMarketingEmails(){} // RVA: 0x7FFE85B63B60
        public void set_subscribedToMarketingEmails(){} // RVA: 0x7FFE85B63740
        public void get_hasEmail(){} // RVA: 0x7FFE8663A5A0
        public void set_hasEmail(){} // RVA: 0x7FFE8663A5B0
        public void get_emailVerified(){} // RVA: 0x7FFE87608930
        public void set_emailVerified(){} // RVA: 0x7FFE87608940
        public void .ctor(){} // RVA: 0x7FFE8A2BA190
        public void GetUpgradeStatus(){} // RVA: 0x7FFE8A2BA250
        public void UpgradeWithEmail(){} // RVA: 0x7FFE8A2BA570
        public void ParseErrorCode(){} // RVA: 0x7FFE8A2BAAB0
    }

    public class ApiAdminAssetBundle : ApiModel
    {
        public string _name; // 0x68
        public string _description; // 0x70
        public string _imageUrl; // 0x78
        public System.Collections.Generic.List`1<string> _tags; // 0x80
        public int _assetVersion; // 0x88
        public System.Collections.Generic.List`1<VRC.Core.ApiAdminAssetBundleFile> _unityPackages; // 0x90

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_description(){} // RVA: 0x7FFE811C3590
        public void set_description(){} // RVA: 0x7FFE811C35A0
        public void get_imageUrl(){} // RVA: 0x7FFE81463AE0
        public void set_imageUrl(){} // RVA: 0x7FFE81464570
        public void get_tags(){} // RVA: 0x7FFE81280C30
        public void set_tags(){} // RVA: 0x7FFE81282380
        public void get_assetVersion(){} // RVA: 0x7FFE8194AD00
        public void set_assetVersion(){} // RVA: 0x7FFE8194A400
        public void get_unityPackages(){} // RVA: 0x7FFE8154EB60
        public void set_unityPackages(){} // RVA: 0x7FFE818CE320
        public void GetPlatformString(){} // RVA: 0x7FFE8A2BB140 | overloaded x2
        public void GetBundleLink(){} // RVA: 0x7FFE8A2BB2D0
        public void CreateAdminAssetBundle(){} // RVA: 0x7FFE8A2BB590
        public void AddPackageToBundle(){} // RVA: 0x7FFE8A2BBED0
        public void GetAdminAssetBundle(){} // RVA: 0x7FFE8A2BC6D0
        public void GetAllAdminAssetBundles(){} // RVA: 0x7FFE8A2BCA00
        public void RequestDeleteBundle(){} // RVA: 0x7FFE8A2BD1C0
        public void SendPropertyUpdate(){} // RVA: 0x7FFE8A2BD4D0
        public void .ctor(){} // RVA: 0x7FFE8A2BDCE0
    }

    public class ApiAdminAssetBundleFile : ApiModel
    {
        public string _assetUrl; // 0x68
        public string _unityVersion; // 0x70
        public string _platform; // 0x78
        public int _assetVersion; // 0x80

        // ── Methods ──
        public void get_assetUrl(){} // RVA: 0x7FFE81176D50
        public void set_assetUrl(){} // RVA: 0x7FFE81176D60
        public void get_unityVersion(){} // RVA: 0x7FFE811C3590
        public void set_unityVersion(){} // RVA: 0x7FFE811C35A0
        public void get_platform(){} // RVA: 0x7FFE81463AE0
        public void set_platform(){} // RVA: 0x7FFE81464570
        public void get_assetVersion(){} // RVA: 0x7FFE81D30560
        public void set_assetVersion(){} // RVA: 0x7FFE81D307B0
        public void GetCacheId(){} // RVA: 0x7FFE8A2BE0C0
        public void .ctor(){} // RVA: 0x7FFE8A2BE270
    }

    public class ApiAuthContinue : ApiModel
    {
        public string _continueToken; // 0x68
        public string[] _requestedFields; // 0x70
        public ReservedName _reservedName; // 0x78

        // ── Methods ──
        public void get_continueToken(){} // RVA: 0x7FFE81176D50
        public void set_continueToken(){} // RVA: 0x7FFE81176D60
        public void get_requestedFields(){} // RVA: 0x7FFE811C3590
        public void set_requestedFields(){} // RVA: 0x7FFE811C35A0
        public void get_reservedName(){} // RVA: 0x7FFE81463AE0
        public void set_reservedName(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE8A2BE2C0
    }

    public class ApiAvatar : ApiContentModel`1
    {
        public System.Collections.Generic.Dictionary`2<0x664A8A8C,string> performanceRatings; // 0xD8
        public string _impostorUrl; // 0xE0
        public 0x664A564C _variant; // 0xE8
        public string _impostorUnityVersion; // 0xF0
        public System.Collections.Generic.List`1<UnityPackage> _unityPackages; // 0xF8
        public System.DateTime _created_at; // 0x100
        public System.DateTime _updated_at; // 0x108
        public VRC.Core.ApiProductAttribution _attribution; // 0x110
        public 0x664A677C<VRC.Core.ApiAvatar> _offlineAnalysisScanStatus; // 0x118
        public string _performanceRating; // 0x120
        public System.Collections.Generic.Dictionary`2<string,string> _styles; // 0x128
        public string _productId; // 0x130
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> _publishedListings; // 0x138
        public System.Nullable`1<int> _lowestPrice; // 0x140
        public System.Nullable`1<int> _highestPrice; // 0x148
        public string _acknowledgements; // 0x150

        // ── Methods ──
        public void get_impostorUrl(){} // RVA: 0x7FFE8117C900
        public void set_impostorUrl(){} // RVA: 0x7FFE8117C910
        public void get_variant(){} // RVA: 0x7FFE82A3E380
        public void set_variant(){} // RVA: 0x7FFE86DBADE0
        public void get_impostorUnityVersion(){} // RVA: 0x7FFE811662A0
        public void set_impostorUnityVersion(){} // RVA: 0x7FFE811662B0
        public void get_unityPackages(){} // RVA: 0x7FFE8158D5D0
        public void set_unityPackages(){} // RVA: 0x7FFE81B0E4B0
        public void get_created_at(){} // RVA: 0x7FFE81828B50
        public void set_created_at(){} // RVA: 0x7FFE82472650
        public void get_updated_at(){} // RVA: 0x7FFE8181E3D0
        public void set_updated_at(){} // RVA: 0x7FFE813173C0
        public void get_attribution(){} // RVA: 0x7FFE81317980
        public void set_attribution(){} // RVA: 0x7FFE813159A0
        public void get_offlineAnalysisScanStatus(){} // RVA: 0x7FFE812BC010
        public void set_offlineAnalysisScanStatus(){} // RVA: 0x7FFE82BD1CF0
        public void get_performanceRating(){} // RVA: 0x7FFE813A1DA0
        public void set_performanceRating(){} // RVA: 0x7FFE813A0830
        public void get_styles(){} // RVA: 0x7FFE8182B890
        public void set_styles(){} // RVA: 0x7FFE81B31E10
        public void get_productId(){} // RVA: 0x7FFE81823850
        public void set_productId(){} // RVA: 0x7FFE81B31120
        public void get_publishedListings(){} // RVA: 0x7FFE8181EA70
        public void set_publishedListings(){} // RVA: 0x7FFE818254E0
        public void get_lowestPrice(){} // RVA: 0x7FFE811665F0
        public void set_lowestPrice(){} // RVA: 0x7FFE86EE8050
        public void get_highestPrice(){} // RVA: 0x7FFE81166660
        public void set_highestPrice(){} // RVA: 0x7FFE86DDD610
        public void get_acknowledgements(){} // RVA: 0x7FFE81790740
        public void set_acknowledgements(){} // RVA: 0x7FFE81B350B0
        public void get_LoadError(){} // RVA: 0x7FFE81B16560
        public void set_LoadError(){} // RVA: 0x7FFE81B21880
        public void .ctor(){} // RVA: 0x7FFE8A2BE360
        public void Get(){} // RVA: 0x7FFE8A2BE480
        public void AssignToThisUser(){} // RVA: 0x7FFE8A2BE620
        public void AssignToThisUserAsFallback(){} // RVA: 0x7FFE8A2BEAA0
        public void GetPerformanceRatingForPlatform(){} // RVA: 0x7FFE8A2BEF20
        public void GetAssetUrl(){} // RVA: 0x7FFE8A2BEFA0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFE8A2BF140 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x7FFE8A2BF280
        public void WriteField(){} // RVA: 0x7FFE8A2BFDD0
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFE8A2BFE00
    }

    public class ApiAvatarLook : ApiModel
    {
        public string _avatarId; // 0x68
        public System.Collections.Generic.List`1<Attachment> _attachments; // 0x70

        // ── Methods ──
        public void get_avatarId(){} // RVA: 0x7FFE81176D50
        public void set_avatarId(){} // RVA: 0x7FFE81176D60
        public void get_attachments(){} // RVA: 0x7FFE811C3590
        public void set_attachments(){} // RVA: 0x7FFE811C35A0
        public void GetLook(){} // RVA: 0x7FFE8A2C06C0
        public void UpdateThumbnail(){} // RVA: 0x7FFE8A2C0860
        public void UpdateLook(){} // RVA: 0x7FFE8A2C09B0
        public void CreateLook(){} // RVA: 0x7FFE8A2C0B00
        public void UploadThumbnail(){} // RVA: 0x7FFE8A2C0CA0
        public void .ctor(){} // RVA: 0x7FFE8A2C0E40
    }

    public class ApiAvatarModeration : ApiModel
    {
        public float ListCacheTime;
        public 0x664A5CD4 _moderationType; // 0x68

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7FFE82A22EF0
        public void set_moderationType(){} // RVA: 0x7FFE82A22F00
        public void get_targetAvatarId(){} // RVA: 0x7FFE811C3590
        public void set_targetAvatarId(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A2C4760
        public void ShouldCache(){} // RVA: 0x7FFE810FB320
        public void ReadField(){} // RVA: 0x7FFE8A2C4820
        public void WriteField(){} // RVA: 0x7FFE8A2C4BA0
        public void SendModeration(){} // RVA: 0x7FFE8A2C4D80
        public void DeleteModeration(){} // RVA: 0x7FFE8A2C4FC0
        public void FetchAllMine(){} // RVA: 0x7FFE8A2C54E0
        public void FetchList(){} // RVA: 0x7FFE8A2C5540
        public void ModerationTypeToAPIString(){} // RVA: 0x7FFE8A2C5830
    }

    public class ApiAvatarPart : ApiContentModel`1
    {
        public System.DateTime __created_at; // 0xD8
        public System.DateTime __updated_at; // 0xE0
        public System.Collections.Generic.List`1<UnityPackage> _unityPackages; // 0xE8
        public string AvatarPartEndpoint;

        // ── Methods ──
        public void get__created_at(){} // RVA: 0x7FFE8181EA80
        public void set__created_at(){} // RVA: 0x7FFE89E6C790
        public void get__updated_at(){} // RVA: 0x7FFE8117C900
        public void set__updated_at(){} // RVA: 0x7FFE8A2C5BE0
        public void get_unityPackages(){} // RVA: 0x7FFE8117C970
        public void set_unityPackages(){} // RVA: 0x7FFE8117C980
        public void get_BundleSignature(){} // RVA: 0x7FFE811662A0
        public void set_BundleSignature(){} // RVA: 0x7FFE811662B0
        public void .ctor(){} // RVA: 0x7FFE8A2C5BF0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFE8A2C5D50 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x7FFE8A2C5E30
        public void WriteField(){} // RVA: 0x7FFE8A2C64F0
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFE8A2C65B0
        public void GetAccessory(){} // RVA: 0x7FFE8A2C67B0
        public void FetchList(){} // RVA: 0x7FFE8A2C6950
    }

    public class ApiAvatarPartItemMetadata : ApiModel
    {
        public string _avatarPartId; // 0x68

        // ── Methods ──
        public void get_avatarPartId(){} // RVA: 0x7FFE81176D50
        public void set_avatarPartId(){} // RVA: 0x7FFE81176D60
        public void .ctor(){} // RVA: 0x7FFE8A2C7440
    }

    public class ApiAvatarStyle : ApiModel
    {
        public string _styleName; // 0x68
        public string _lastModifiedById; // 0x70
        public string _lastModifiedByDisplayName; // 0x78
        public System.DateTime _created_at; // 0x80
        public System.DateTime _updated_at; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2C7490
        public void get_styleName(){} // RVA: 0x7FFE81176D50
        public void set_styleName(){} // RVA: 0x7FFE81176D60
        public void get_lastModifiedById(){} // RVA: 0x7FFE811C3590
        public void set_lastModifiedById(){} // RVA: 0x7FFE811C35A0
        public void get_lastModifiedByDisplayName(){} // RVA: 0x7FFE81463AE0
        public void set_lastModifiedByDisplayName(){} // RVA: 0x7FFE81464570
        public void get_created_at(){} // RVA: 0x7FFE81280C30
        public void set_created_at(){} // RVA: 0x7FFE82C95C90
        public void get_updated_at(){} // RVA: 0x7FFE8113A010
        public void set_updated_at(){} // RVA: 0x7FFE82C95CA0
    }

    public class ApiBadge : ApiModel
    {
        public string _badgeId; // 0x68
        public bool _showcased; // 0x70
        public string _badgeName; // 0x78
        public string _badgeDescription; // 0x80
        public string _badgeImageUrl; // 0x88
        public bool _hidden; // 0x90
        public System.DateTime _assignedAt; // 0x98
        public System.DateTime _updatedAt; // 0xA0
        public string _assignedBy; // 0xA8

        // ── Methods ──
        public void get_badgeId(){} // RVA: 0x7FFE81176D50
        public void set_badgeId(){} // RVA: 0x7FFE81176D60
        public void get_showcased(){} // RVA: 0x7FFE81177320
        public void set_showcased(){} // RVA: 0x7FFE81177330
        public void get_badgeName(){} // RVA: 0x7FFE81463AE0
        public void set_badgeName(){} // RVA: 0x7FFE81464570
        public void get_badgeDescription(){} // RVA: 0x7FFE81280C30
        public void set_badgeDescription(){} // RVA: 0x7FFE81282380
        public void get_badgeImageUrl(){} // RVA: 0x7FFE8113A010
        public void set_badgeImageUrl(){} // RVA: 0x7FFE81280F90
        public void get_hidden(){} // RVA: 0x7FFE820BF400
        public void set_hidden(){} // RVA: 0x7FFE820BFEB0
        public void get_assignedAt(){} // RVA: 0x7FFE817AE360
        public void set_assignedAt(){} // RVA: 0x7FFE86225270
        public void get_updatedAt(){} // RVA: 0x7FFE8179C860
        public void set_updatedAt(){} // RVA: 0x7FFE86B370C0
        public void get_assignedBy(){} // RVA: 0x7FFE817AB5E0
        public void set_assignedBy(){} // RVA: 0x7FFE81857260
        public void .ctor(){} // RVA: 0x7FFE8A2C7550
    }

    public class ApiBindingCommandReference : ApiModel
    {
        public string _command; // 0x68
        public System.Collections.Generic.List`1<string> _parameters; // 0x70
        public string _name; // 0x78

        // ── Methods ──
        public void get_command(){} // RVA: 0x7FFE81176D50
        public void set_command(){} // RVA: 0x7FFE81176D60
        public void get_parameters(){} // RVA: 0x7FFE811C3590
        public void set_parameters(){} // RVA: 0x7FFE811C35A0
        public void get_name(){} // RVA: 0x7FFE81463AE0
        public void set_name(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE8A2C75A0
        public void ToString(){} // RVA: 0x7FFE8A2C7640
    }

    public class ApiByteContainer : ApiContainer
    {
        // ── Methods ──
        public void get_ResponseBytes(){} // RVA: 0x7FFE8A32C9B0
        public void Validate(){} // RVA: 0x7FFE8A32CA20
        public void .ctor(){} // RVA: 0x7FFE8A32C380
    }

    public class ApiCache : Object
    {
        public System.Func`1<long> TimeProvider;
        public System.Collections.Generic.Dictionary`2<string,CacheEntry> cache; // 0x8

        // ── Methods ──
        public void DefaultTimeProvider(){} // RVA: 0x7FFE8A2C7720
        public void get_Count(){} // RVA: 0x7FFE8A2C77D0
        public void get_NextExpiryTTL(){} // RVA: 0x7FFE8A2C79A0
        public void Fetch(){} // RVA: 0x7FFE80E2F7A0
        public void Save(){} // RVA: 0x7FFE8A2C7C90
        public void Invalidate(){} // RVA: 0x7FFE8A2C8100
        public void CleanupTask(){} // RVA: 0x7FFE8A2C83B0
        public void Cleanup(){} // RVA: 0x7FFE8A2C83F0
        public void InvalidateFileIfVersionUnknown(){} // RVA: 0x7FFE8A2C88F0
        public void Clear(){} // RVA: 0x7FFE8A2C8AA0
        public void .cctor(){} // RVA: 0x7FFE8A2C8D20
    }

    public class ApiCacheObject
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFE80E2F150
        public void GetLifeSpan(){} // RVA: 0x7FFE80E42E10
        public void Clone(){} // RVA: 0x7FFE80E2E2E0
        public void set_ExpiryTime(){} // RVA: 0x7FFE80E460A0
    }

    public class ApiCalendarEntriesContainer : ApiModel
    {
        public bool _hasNext; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APICalendarEntry> _results; // 0x70
        public int _totalCount; // 0x78
        public string _nextCursor; // 0x80

        // ── Methods ──
        public void get_hasNext(){} // RVA: 0x7FFE811C3570
        public void set_hasNext(){} // RVA: 0x7FFE811C3580
        public void get_results(){} // RVA: 0x7FFE811C3590
        public void set_results(){} // RVA: 0x7FFE811C35A0
        public void get_totalCount(){} // RVA: 0x7FFE8286C0A0
        public void set_totalCount(){} // RVA: 0x7FFE82862F10
        public void get_nextCursor(){} // RVA: 0x7FFE81280C30
        public void set_nextCursor(){} // RVA: 0x7FFE81282380
        public void .ctor(){} // RVA: 0x7FFE8A373520
    }

    public class ApiCalendarResults : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.APICalendarEntry> _results; // 0x68
        public int _totalCount; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFE81176D50
        public void set_results(){} // RVA: 0x7FFE81176D60
        public void get_totalCount(){} // RVA: 0x7FFE81E60180
        public void set_totalCount(){} // RVA: 0x7FFE81293CF0
        public void .ctor(){} // RVA: 0x7FFE8A331A10
    }

    public class ApiCampaignAnonymizationStatus : ApiModel
    {
        public bool _isAnonymized; // 0x68
        public string _anonymizedName; // 0x70

        // ── Methods ──
        public void get_isAnonymized(){} // RVA: 0x7FFE811C3570
        public void set_isAnonymized(){} // RVA: 0x7FFE811C3580
        public void get_anonymizedName(){} // RVA: 0x7FFE811C3590
        public void set_anonymizedName(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A2CA700
    }

    public class ApiCampaignContributor : ApiModel
    {
        public string _userId; // 0x68
        public string _displayName; // 0x70
        public int _giftCount; // 0x78
        public bool _isAnonymized; // 0x7C
        public bool _isSelf; // 0x7D

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFE81176D50
        public void set_userId(){} // RVA: 0x7FFE81176D60
        public void get_displayName(){} // RVA: 0x7FFE811C3590
        public void set_displayName(){} // RVA: 0x7FFE811C35A0
        public void get_giftCount(){} // RVA: 0x7FFE8286C0A0
        public void set_giftCount(){} // RVA: 0x7FFE82862F10
        public void get_isAnonymized(){} // RVA: 0x7FFE816402F0
        public void set_isAnonymized(){} // RVA: 0x7FFE81641190
        public void get_isSelf(){} // RVA: 0x7FFE816400B0
        public void set_isSelf(){} // RVA: 0x7FFE81643610
        public void .ctor(){} // RVA: 0x7FFE8A2CA750
    }

    public class ApiCampaignReward : ApiModel
    {
        public bool _isUnlocked; // 0x68
        public string _imageUrl; // 0x70
        public VRC.Core.ApiCampaignRewardProgression _progression; // 0x78

        // ── Methods ──
        public void get_isUnlocked(){} // RVA: 0x7FFE811C3570
        public void set_isUnlocked(){} // RVA: 0x7FFE811C3580
        public void get_imageUrl(){} // RVA: 0x7FFE811C3590
        public void set_imageUrl(){} // RVA: 0x7FFE811C35A0
        public void get_progression(){} // RVA: 0x7FFE81463AE0
        public void set_progression(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE8A2CA660
    }

    public class ApiCampaignRewardProgression : ApiModel
    {
        public int _required; // 0x68
        public int _current; // 0x6C

        // ── Methods ──
        public void get_required(){} // RVA: 0x7FFE82A22EF0
        public void set_required(){} // RVA: 0x7FFE82A22F00
        public void get_current(){} // RVA: 0x7FFE82A22F10
        public void set_current(){} // RVA: 0x7FFE82A22F20
        public void .ctor(){} // RVA: 0x7FFE8A2CA6B0
    }

    public class ApiCertificateVerifier : CertificateHandler
    {
        public VRC.Core.ApiCertificateVerifier _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE8A2CA7A0
        public void .ctor(){} // RVA: 0x7FFE8803B190
        public void Initialize(){} // RVA: 0x7FFE8A2CA800
        public void TestPublicKey(){} // RVA: 0x7FFE8A2CA900
        public void IsValid(){} // RVA: 0x7FFE8A2CAB90
        public void ValidateCertificate(){} // RVA: 0x7FFE8A2CADD0
        public void .cctor(){} // RVA: 0x7FFE8A2CAF90
    }

    public class ApiContainer : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> _cookies; // 0x10
        public bool _populated; // 0x18
        public bool _passedValidation; // 0x19
        public int _code; // 0x1C
        public string _text; // 0x20
        public object _data; // 0x28
        public float _dataTimestamp; // 0x30
        public string _createdAt; // 0x38
        public string responseError; // 0x40
        public VRC.Core.ApiModel _model; // 0x48

        // ── Methods ──
        public void get_Cookies(){} // RVA: 0x7FFE81116380
        public void set_Cookies(){} // RVA: 0x7FFE810FCE30
        public void get_Populated(){} // RVA: 0x7FFE811164E0
        public void set_Populated(){} // RVA: 0x7FFE811164F0
        public void get_PassedValidation(){} // RVA: 0x7FFE814B3730
        public void set_PassedValidation(){} // RVA: 0x7FFE81CD0510
        public void get_Code(){} // RVA: 0x7FFE82707EE0
        public void set_Code(){} // RVA: 0x7FFE82717690
        public void get_Text(){} // RVA: 0x7FFE811290C0
        public void set_Text(){} // RVA: 0x7FFE811290D0
        public void get_Data(){} // RVA: 0x7FFE81129130
        public void set_Data(){} // RVA: 0x7FFE810FCE90
        public void get_DataTimestamp(){} // RVA: 0x7FFE81284640
        public void set_DataTimestamp(){} // RVA: 0x7FFE81308960
        public void get_CreatedAt(){} // RVA: 0x7FFE8143BA80
        public void set_CreatedAt(){} // RVA: 0x7FFE81437330
        public void get_Error(){} // RVA: 0x7FFE8A32CB70
        public void set_Error(){} // RVA: 0x7FFE8A32CBA0
        public void get_Model(){} // RVA: 0x7FFE81176730
        public void set_Model(){} // RVA: 0x7FFE81176740
        public void .ctor(){} // RVA: 0x7FFE8A32CF00
        public void setFromContainer(){} // RVA: 0x7FFE8A32CFD0
        public void Validate(){} // RVA: 0x7FFE8A32D1E0
        public void GetErrorMessage(){} // RVA: 0x7FFE8A32D230
        public void OnComplete(){} // RVA: 0x7FFE8A32D3E0
    }

    public class ApiContentModel`1 : ApiModel
    {
        public VRC.Core.AssetVersion _VERSION;
        public VRC.Core.AssetVersion MIN_LOADABLE_VERSION;
        public float ListCacheTime;
        public float SingleRecordCacheTime;
        public System.Collections.Generic.Dictionary`2<string,T> localContent;
        public string _name;
        public string _imageUrl;
        public string _authorName;
        public string _authorId;
        public string _assetUrl;
        public string _description;
        public System.Collections.Generic.List`1<string> _tags;
        public string _thumbnailImageUrl;
        public int _version;
        public string _releaseStatus;
        public bool _featured;
        public bool _unityPackageUpdated;
        public string _unityVersion;

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7FFE80E2DEE0
        public void ShouldCache(){} // RVA: 0x7FFE80E2F150
        public void GetLifeSpan(){} // RVA: 0x7FFE80E42E10
        public void get_name(){} // RVA: 0x7FFE80E2E2E0
        public void set_name(){} // RVA: 0x7FFE80E460A0
        public void get_imageUrl(){} // RVA: 0x7FFE80E2E2E0
        public void set_imageUrl(){} // RVA: 0x7FFE80E460A0
        public void get_authorName(){} // RVA: 0x7FFE80E2E2E0
        public void set_authorName(){} // RVA: 0x7FFE80E460A0
        public void get_authorId(){} // RVA: 0x7FFE80E2E2E0
        public void set_authorId(){} // RVA: 0x7FFE80E460A0
        public void get_assetUrl(){} // RVA: 0x7FFE80E2E2E0
        public void set_assetUrl(){} // RVA: 0x7FFE80E460A0
        public void get_description(){} // RVA: 0x7FFE80E2E2E0
        public void set_description(){} // RVA: 0x7FFE80E460A0
        public void get_tags(){} // RVA: 0x7FFE80E2E2E0
        public void set_tags(){} // RVA: 0x7FFE80E460A0
        public void get_thumbnailImageUrl(){} // RVA: 0x7FFE80E2E2E0
        public void set_thumbnailImageUrl(){} // RVA: 0x7FFE80E460A0
        public void get_version(){} // RVA: 0x7FFE80E2EDB0
        public void set_version(){} // RVA: 0x7FFE80E46530
        public void get_releaseStatus(){} // RVA: 0x7FFE80E2E2E0
        public void set_releaseStatus(){} // RVA: 0x7FFE80E460A0
        public void get_featured(){} // RVA: 0x7FFE80E2F150
        public void set_featured(){} // RVA: 0x7FFE80E466C0
        public void get_unityPackageUpdated(){} // RVA: 0x7FFE80E2F150
        public void set_unityPackageUpdated(){} // RVA: 0x7FFE80E466C0
        public void get_unityVersion(){} // RVA: 0x7FFE80E2E2E0
        public void set_unityVersion(){} // RVA: 0x7FFE80E460A0
        public void get_apiVersion(){} // RVA: 0x7FFE80E2EDB0
        public void set_apiVersion(){} // RVA: 0x7FFE80E46530
        public void get_platform(){} // RVA: 0x7FFE80E2E2E0
        public void set_platform(){} // RVA: 0x7FFE80E460A0
        public void get_assetVersion(){} // RVA: 0x7FFE80E2E2E0
        public void set_assetVersion(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void ReadField(){} // RVA: 0x7FFE80E32650
        public void Get(){} // RVA: 0x7FFE810A1420
        public void FetchList(){} // RVA: 0x7FFE810A1420
        public void AddLocal(){} // RVA: 0x7FFE810A1420
        public void IsLocalById(){} // RVA: 0x7FFE80E2F230
        public void get_IsLocal(){} // RVA: 0x7FFE80E2F150
        public void Save(){} // RVA: 0x7FFE80E4F230
        public void SaveReleaseStatus(){} // RVA: 0x7FFE80E4F230
        public void GetAssetUrl(){} // RVA: 0x7FFE80E2E2E0
        public void HasTag(){} // RVA: 0x7FFE80E2F3B0
        public void AddTag(){} // RVA: 0x7FFE80E2F3B0
        public void RemoveTag(){} // RVA: 0x7FFE80E2F3B0
        public void UpdateVersionAndPlatform(){} // RVA: 0x7FFE80E45FE0
        public void MakeRequestEndpoint(){}
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ApiCredentials : Object
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7FFE8A3735C0
        public void SetProfileIndex(){} // RVA: 0x7FFE8A3735F0
        public void SetString(){} // RVA: 0x7FFE8A373670
        public void GetString(){} // RVA: 0x7FFE8A3738C0
        public void Load(){} // RVA: 0x7FFE8A373AB0
        public void SetHumanName(){} // RVA: 0x7FFE8A3741E0
        public void Set(){} // RVA: 0x7FFE8A3742F0
        public void Set2faToken(){} // RVA: 0x7FFE8A3748E0
        public void GetHumanName(){} // RVA: 0x7FFE8A374AC0
        public void GetAuthToken(){} // RVA: 0x7FFE8A374B00
        public void GetTwoFactorAuthToken(){} // RVA: 0x7FFE8A374B40
        public void GetAuthTokenCookie(){} // RVA: 0x7FFE8A374B80
        public void GetTwoFactorAuthTokenCookie(){} // RVA: 0x7FFE8A374BC0
        public void GetAuthTokenProvider(){} // RVA: 0x7FFE8A374C00
        public void GetAuthTokenProviderUserId(){} // RVA: 0x7FFE8A374C40
        public void IsLoaded(){} // RVA: 0x7FFE8A374C80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ApiDictContainer : ApiContainer
    {
        public float _cacheLifetime; // 0x60
        public System.Nullable`1<long> _expiryTime; // 0x68
        public string[] _requiredFields; // 0x78
        public System.Collections.Generic.IReadOnlyDictionary`2<string,Token> EmptyDictionary;

        // ── Methods ──
        public void get_cacheLifetime(){} // RVA: 0x7FFE8120BE10
        public void set_cacheLifetime(){} // RVA: 0x7FFE81D5D9B0
        public void get_ExpiryTime(){} // RVA: 0x7FFE8432FD10
        public void set_ExpiryTime(){} // RVA: 0x7FFE84330180
        public void get_requiredFields(){} // RVA: 0x7FFE81463AE0
        public void set_requiredFields(){} // RVA: 0x7FFE81464570
        public void get_ResponseDictionary(){} // RVA: 0x7FFE8A32B820
        public void .ctor(){} // RVA: 0x7FFE8A32BA00 | overloaded x2
        public void Validate(){} // RVA: 0x7FFE8A32BA70
        public void ShouldCache(){} // RVA: 0x7FFE8A32BDC0
        public void ShouldClearOnLevelLoad(){} // RVA: 0x7FFE810FB320
        public void GetLifeSpan(){} // RVA: 0x7FFE8120BE10
        public void Clone(){} // RVA: 0x7FFE8A32BDD0
        public void .cctor(){} // RVA: 0x7FFE8A32BE50
        public void <Validate>b__17_0(){} // RVA: 0x7FFE8A32BF20
    }

    public class ApiDroneSkin : ApiModel
    {
        public string _name; // 0x68
        public string _assetBundleId; // 0x70
        public string _viewfinderAssetBundleId; // 0x78

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_assetBundleId(){} // RVA: 0x7FFE811C3590
        public void set_assetBundleId(){} // RVA: 0x7FFE811C35A0
        public void get_viewfinderAssetBundleId(){} // RVA: 0x7FFE81463AE0
        public void set_viewfinderAssetBundleId(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE8A2CB1E0
    }

    public class ApiEconomyAccountStatus : ApiModel
    {
        public string _userID; // 0x68
        public bool _blocked; // 0x70

        // ── Methods ──
        public void get_UserID(){} // RVA: 0x7FFE81176D50
        public void set_UserID(){} // RVA: 0x7FFE81176D60
        public void get_Blocked(){} // RVA: 0x7FFE81177320
        public void set_Blocked(){} // RVA: 0x7FFE81177330
        public void .ctor(){} // RVA: 0x7FFE8A374CD0
    }

    public class ApiEconomyStatus : ApiModel
    {
        public bool _economyIsOnline; // 0x68
        public int _economyState; // 0x6C

        // ── Methods ──
        public void get_EconomyIsOnline(){} // RVA: 0x7FFE811C3570
        public void set_EconomyIsOnline(){} // RVA: 0x7FFE811C3580
        public void get_EconomyState(){} // RVA: 0x7FFE82A22F10
        public void set_EconomyState(){} // RVA: 0x7FFE82A22F20
        public void .ctor(){} // RVA: 0x7FFE8A374D20
    }

    public class ApiEconomyStore : ApiModel
    {
        public string _sellerId; // 0x68
        public string _sellerDisplayName; // 0x70
        public string _worldId; // 0x78
        public string _groupId; // 0x80
        public 0x664A6A94 _storeStatus; // 0x88
        public string _displayName; // 0x90
        public string _description; // 0x98
        public System.Collections.Generic.List`1<string> _tags; // 0xA0
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> _listings; // 0xA8
        public System.Collections.Generic.List`1<string> _listingIDs; // 0xB0
        public object field_10; // 0xA448
        public object field_11; // 0xA600

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2CB230
        public void get_SellerId(){} // RVA: 0x7FFE81176D50
        public void set_SellerId(){} // RVA: 0x7FFE81176D60
        public void get_SellerDisplayName(){} // RVA: 0x7FFE811C3590
        public void set_SellerDisplayName(){} // RVA: 0x7FFE811C35A0
        public void get_WorldId(){} // RVA: 0x7FFE81463AE0
        public void set_WorldId(){} // RVA: 0x7FFE81464570
        public void get_GroupId(){} // RVA: 0x7FFE81280C30
        public void set_GroupId(){} // RVA: 0x7FFE81282380
        public void get_StoreStatus(){} // RVA: 0x7FFE8194AD00
        public void set_StoreStatus(){} // RVA: 0x7FFE8194A400
        public void get_DisplayName(){} // RVA: 0x7FFE8154EB60
        public void set_DisplayName(){} // RVA: 0x7FFE818CE320
        public void get_Description(){} // RVA: 0x7FFE817AE360
        public void set_Description(){} // RVA: 0x7FFE8171B470
        public void get_Tags(){} // RVA: 0x7FFE8179C860
        public void set_Tags(){} // RVA: 0x7FFE8171B4D0
        public void get_Listings(){} // RVA: 0x7FFE817AB5E0
        public void set_Listings(){} // RVA: 0x7FFE81857260
        public void get_ListingIDs(){} // RVA: 0x7FFE81166040
        public void set_ListingIDs(){} // RVA: 0x7FFE81166050
        public void get_IsGroupStore(){} // RVA: 0x7FFE8A2CB280
        public void get_IsWorldStore(){} // RVA: 0x7FFE8A2CB2A0
        public void ReadField(){} // RVA: 0x7FFE8A2CB2C0
        public void WriteField(){} // RVA: 0x7FFE8A2CB500
        public void FetchStore(){} // RVA: 0x7FFE8A2CB660
    }

    public class ApiFieldAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE814B8390
    }

    public class ApiFile : ApiModel
    {
        public string _name; // 0x68
        public System.Nullable`1<int> _order; // 0x70
        public string _ownerId; // 0x78
        public string _mimeType; // 0x80
        public string _extension; // 0x88
        public System.Collections.Generic.List`1<Version> _versions; // 0x90
        public bool _isInitialized; // 0x98
        public bool _isPendingInit; // 0x99

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_order(){} // RVA: 0x7FFE811C3590
        public void set_order(){} // RVA: 0x7FFE82C95C70
        public void get_ownerId(){} // RVA: 0x7FFE81463AE0
        public void set_ownerId(){} // RVA: 0x7FFE81464570
        public void get_mimeType(){} // RVA: 0x7FFE81280C30
        public void set_mimeType(){} // RVA: 0x7FFE81282380
        public void get_extension(){} // RVA: 0x7FFE8113A010
        public void set_extension(){} // RVA: 0x7FFE81280F90
        public void get_versions(){} // RVA: 0x7FFE8154EB60
        public void set_versions(){} // RVA: 0x7FFE818CE320
        public void get_IsInitialized(){} // RVA: 0x7FFE81611920
        public void set_IsInitialized(){} // RVA: 0x7FFE81611930
        public void get_IsPendingInit(){} // RVA: 0x7FFE81610170
        public void set_IsPendingInit(){} // RVA: 0x7FFE86CFFD10
        public void .ctor(){} // RVA: 0x7FFE8A2CE190 | overloaded x3
        public void Create(){} // RVA: 0x7FFE8A2CE320
        public void Refresh(){} // RVA: 0x7FFE8A2CE4C0
        public void DownloadFile(){} // RVA: 0x7FFE8A2CE500
        public void ParseFileIdFromFileAPIUrl(){} // RVA: 0x7FFE8A2CEB70
        public void TryParseFileIdFromFileAPIUrl(){} // RVA: 0x7FFE8A2CEC10
        public void TryParseFileVersionFromFileAPIUrl(){} // RVA: 0x7FFE8A2CEC50
        public void TryParseFileIdAndVersionFromFileAPIUrl(){} // RVA: 0x7FFE8A2CECA0
        public void TryParseFileIdAndVersionAndVariantSuffixFromFileAPIUrl(){} // RVA: 0x7FFE8A2CECE0
        public void TryParseFileIdAndVersionAndVariantFromFileAPIUrl(){} // RVA: 0x7FFE8A2CED60 | overloaded x2
        public void PerformRegexMatch(){} // RVA: 0x7FFE8A2CED90
        public void TryGetImageAPIUrlFromFileAPIUrl(){} // RVA: 0x7FFE8A2CF590
        public void OnDownloadFileCompleted(){} // RVA: 0x7FFE8A2CFAE0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFE8A2D01E0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE8A2D0210
        public void ToStringBrief(){} // RVA: 0x7FFE81768340
        public void CreateNewVersion(){} // RVA: 0x7FFE8A2D0430
        public void HasExistingVersion(){} // RVA: 0x7FFE8A2D0B70
        public void HasExistingOrPendingVersion(){} // RVA: 0x7FFE8A2D0C30
        public void GetLatestVersionNumber(){} // RVA: 0x7FFE8A2D0D10
        public void GetLatestCompleteVersionNumber(){} // RVA: 0x7FFE8A2D0D70
        public void GetVersion(){} // RVA: 0x7FFE8A2D0EA0
        public void GetLatestCompleteVersion(){} // RVA: 0x7FFE8A2D0F40
        public void GetLatestVersion(){} // RVA: 0x7FFE8A2D0F70
        public void DeleteVersion(){} // RVA: 0x7FFE8A2D0FE0
        public void DeleteLatestVersion(){} // RVA: 0x7FFE8A2D12D0
        public void DownloadSignature(){} // RVA: 0x7FFE8A2D16B0
        public void GetFileURL(){} // RVA: 0x7FFE8A2D1750 | overloaded x2
        public void GetFileRawURL(){} // RVA: 0x7FFE8A2D17E0 | overloaded x2
        public void GetDeltaURL(){} // RVA: 0x7FFE8A2D1890 | overloaded x2
        public void GetDeltaRawURL(){} // RVA: 0x7FFE8A2D1920 | overloaded x2
        public void GetSignatureURL(){} // RVA: 0x7FFE8A2D19D0 | overloaded x2
        public void GetSignatureRawURL(){} // RVA: 0x7FFE8A2D1A60 | overloaded x2
        public void GetFileApiURL(){} // RVA: 0x7FFE8A2D1CC0 | overloaded x2
        public void GetFileVariantApiURL(){} // RVA: 0x7FFE8A2D1E00
        public void GetFileMD5(){} // RVA: 0x7FFE8A2D2290 | overloaded x2
        public void GetFileDescriptor(){} // RVA: 0x7FFE8A2D2310
        public void IsLatestVersionQueued(){} // RVA: 0x7FFE8A2D2340
        public void HasQueuedOperation(){} // RVA: 0x7FFE8A2D2410
        public void IsWaitingForUpload(){} // RVA: 0x7FFE8A2D25B0
        public void IsInErrorState(){} // RVA: 0x7FFE8A2D2680
        public void StartSimpleUpload(){} // RVA: 0x7FFE8A2D2750
        public void StartMultipartUpload(){} // RVA: 0x7FFE8A2D2AE0
        public void FinishUpload(){} // RVA: 0x7FFE8A2D2EC0
        public void GetUploadStatus(){} // RVA: 0x7FFE8A2D3150
        public void PutSimpleFileToURL(){} // RVA: 0x7FFE8A2D3350
        public void PutMultipartDataToURL(){} // RVA: 0x7FFE8A2D3E30
    }

    public class ApiGroupGalleryImage : ApiModel
    {
        public string _name; // 0x68
        public string _groupId; // 0x70
        public string _galleryId; // 0x78
        public string _fileId; // 0x80
        public string _imageUrl; // 0x88
        public System.DateTime _createdAt; // 0x90
        public bool _approved; // 0x98
        public System.DateTime _approvedAt; // 0xA0
        public string _approvedByUserId; // 0xA8
        public string _submittedByUserId; // 0xB0
        public VRC.Core.ApiFile _file; // 0xB8

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_groupId(){} // RVA: 0x7FFE811C3590
        public void set_groupId(){} // RVA: 0x7FFE811C35A0
        public void get_galleryId(){} // RVA: 0x7FFE81463AE0
        public void set_galleryId(){} // RVA: 0x7FFE81464570
        public void get_fileId(){} // RVA: 0x7FFE81280C30
        public void set_fileId(){} // RVA: 0x7FFE81282380
        public void get_imageUrl(){} // RVA: 0x7FFE8113A010
        public void set_imageUrl(){} // RVA: 0x7FFE81280F90
        public void get_createdAt(){} // RVA: 0x7FFE8154EB60
        public void set_createdAt(){} // RVA: 0x7FFE81854020
        public void get_approved(){} // RVA: 0x7FFE81611920
        public void set_approved(){} // RVA: 0x7FFE81611930
        public void get_approvedAt(){} // RVA: 0x7FFE8179C860
        public void set_approvedAt(){} // RVA: 0x7FFE86B370C0
        public void get_approvedByUserId(){} // RVA: 0x7FFE817AB5E0
        public void set_approvedByUserId(){} // RVA: 0x7FFE81857260
        public void get_submittedByUserId(){} // RVA: 0x7FFE81166040
        public void set_submittedByUserId(){} // RVA: 0x7FFE81166050
        public void get_file(){} // RVA: 0x7FFE811660B0
        public void set_file(){} // RVA: 0x7FFE811660C0
        public void .ctor(){} // RVA: 0x7FFE8A37F280
    }

    public class ApiImage : ApiFile
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFE810FB320
        public void FetchList(){} // RVA: 0x7FFE8A2D6630
        public void UploadImage(){} // RVA: 0x7FFE8A2D7190
        public void .ctor(){} // RVA: 0x7FFE8A2D7590
    }

    public class ApiInfoPushSystem : ApiModel
    {
        public float CacheTime;
        public bool _isEnabled; // 0x68
        public string _releaseStatus; // 0x70
        public System.Collections.Generic.List`1<string> _tags; // 0x78
        public System.Collections.Generic.List`1<string> _requireClientTags; // 0x80
        public int _priority; // 0x88
        public System.DateTime _startDate; // 0x90
        public System.DateTime _endDate; // 0x98
        public System.DateTime _createdAt; // 0xA0
        public System.DateTime _updatedAt; // 0xA8
        public string _hash; // 0xB0
        public string _originalManifestId; // 0xB8
        public AnalyticsExperiment _experiment; // 0xC0

        // ── Methods ──
        public void get_isEnabled(){} // RVA: 0x7FFE811C3570
        public void set_isEnabled(){} // RVA: 0x7FFE811C3580
        public void get_releaseStatus(){} // RVA: 0x7FFE811C3590
        public void set_releaseStatus(){} // RVA: 0x7FFE811C35A0
        public void get_tags(){} // RVA: 0x7FFE81463AE0
        public void set_tags(){} // RVA: 0x7FFE81464570
        public void get_requireClientTags(){} // RVA: 0x7FFE81280C30
        public void set_requireClientTags(){} // RVA: 0x7FFE81282380
        public void get_priority(){} // RVA: 0x7FFE8194AD00
        public void set_priority(){} // RVA: 0x7FFE8194A400
        public void get_startDate(){} // RVA: 0x7FFE8154EB60
        public void set_startDate(){} // RVA: 0x7FFE81854020
        public void get_endDate(){} // RVA: 0x7FFE817AE360
        public void set_endDate(){} // RVA: 0x7FFE86225270
        public void get_createdAt(){} // RVA: 0x7FFE8179C860
        public void set_createdAt(){} // RVA: 0x7FFE86B370C0
        public void get_updatedAt(){} // RVA: 0x7FFE817AB5E0
        public void set_updatedAt(){} // RVA: 0x7FFE82904630
        public void get_hash(){} // RVA: 0x7FFE81166040
        public void set_hash(){} // RVA: 0x7FFE81166050
        public void get_originalManifestId(){} // RVA: 0x7FFE811660B0
        public void set_originalManifestId(){} // RVA: 0x7FFE811660C0
        public void get_experiment(){} // RVA: 0x7FFE81166120
        public void set_experiment(){} // RVA: 0x7FFE81166130
        public void get_data(){} // RVA: 0x7FFE81253460
        public void set_data(){} // RVA: 0x7FFE81253470
        public void .ctor(){} // RVA: 0x7FFE8A2D7830
        public void GetLifeSpan(){} // RVA: 0x7FFE8453D810
        public void FetchList(){} // RVA: 0x7FFE8A2D78F0
        public void Save(){} // RVA: 0x7FFE8A2D7FB0
    }

    public class ApiInventoryBundle : ApiModel
    {
        public System.Collections.Generic.List`1<string> _inventoryItemsToInstantiate; // 0x68
        public ApiBundleDropNotificationDetails _notificationDetails; // 0x70

        // ── Methods ──
        public void get_inventoryItemsToInstantiate(){} // RVA: 0x7FFE81176D50
        public void set_inventoryItemsToInstantiate(){} // RVA: 0x7FFE81176D60
        public void get_notificationDetails(){} // RVA: 0x7FFE811C3590
        public void set_notificationDetails(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A2D89A0
    }

    public class ApiInventoryBundleDrop : ApiModel
    {
        public string ENDPOINT;
        public string _name; // 0x68
        public string _authorId; // 0x70
        public string _targetGroup; // 0x78
        public System.Collections.Generic.List`1<string> _templateIds; // 0x80
        public System.DateTime _startDropDate; // 0x88
        public System.DateTime _endDropDate; // 0x90
        public System.DateTime _dropExpiryDate; // 0x98
        public string _status; // 0xA0
        public System.Collections.Generic.List`1<string> _tags; // 0xA8
        public System.DateTime _created_at; // 0xB0
        public System.DateTime _updated_at; // 0xB8

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_authorId(){} // RVA: 0x7FFE811C3590
        public void set_authorId(){} // RVA: 0x7FFE811C35A0
        public void get_targetGroup(){} // RVA: 0x7FFE81463AE0
        public void set_targetGroup(){} // RVA: 0x7FFE81464570
        public void get_templateIds(){} // RVA: 0x7FFE81280C30
        public void set_templateIds(){} // RVA: 0x7FFE81282380
        public void get_startDropDate(){} // RVA: 0x7FFE8113A010
        public void set_startDropDate(){} // RVA: 0x7FFE82C95CA0
        public void get_endDropDate(){} // RVA: 0x7FFE8154EB60
        public void set_endDropDate(){} // RVA: 0x7FFE81854020
        public void get_dropExpiryDate(){} // RVA: 0x7FFE817AE360
        public void set_dropExpiryDate(){} // RVA: 0x7FFE86225270
        public void get_status(){} // RVA: 0x7FFE8179C860
        public void set_status(){} // RVA: 0x7FFE8171B4D0
        public void get_tags(){} // RVA: 0x7FFE817AB5E0
        public void set_tags(){} // RVA: 0x7FFE81857260
        public void get_created_at(){} // RVA: 0x7FFE81166040
        public void set_created_at(){} // RVA: 0x7FFE82904640
        public void get_updated_at(){} // RVA: 0x7FFE811660B0
        public void set_updated_at(){} // RVA: 0x7FFE82904810
        public void get_notificationDetails(){} // RVA: 0x7FFE81166120
        public void set_notificationDetails(){} // RVA: 0x7FFE81166130
        public void FetchCurrentlyActiveBundleDrops(){} // RVA: 0x7FFE8A2D89F0
        public void .ctor(){} // RVA: 0x7FFE8A2D8E30
    }

    public class ApiInventoryItem : ApiModel
    {
        public string ITEM_TEMPLATE_ID_PREFIX;
        public string _templateId; // 0x68
        public string _name; // 0x70
        public string _description; // 0x78
        public string _imageUrl; // 0x80
        public VRC.Core.ApiProductAttribution _attribution; // 0x88
        public System.Collections.Generic.List`1<string> _flags; // 0x90
        public System.Collections.Generic.List`1<string> _tags; // 0x98
        public System.Collections.Generic.List`1<string> _collections; // 0xA0
        public string _itemType; // 0xA8
        public string _holderId; // 0xB0
        public string _firstAncestor; // 0xB8
        public string _firstAncestorHolderId; // 0xC0
        public System.DateTime _expiryDate; // 0xC8
        public System.DateTime _created_at; // 0xD0
        public System.DateTime _updated_at; // 0xD8
        public System.DateTime _template_created_at; // 0xE0
        public System.DateTime _template_updated_at; // 0xE8
        public bool _isArchived; // 0xF0
        public bool _isSeen; // 0xF1
        public System.DateTime _last_equipped_at; // 0xF8
        public System.Collections.Generic.List`1<string> _equipSlots; // 0x100
        public string _equipSlot; // 0x108
        public int _quantity; // 0x110
        public bool _quantifiable; // 0x114
        public System.Collections.Generic.Dictionary`2<string,ItemAttribute> _defaultAttributes; // 0x118
        public System.Collections.Generic.Dictionary`2<string,object> _userAttributes; // 0x120
        public bool _validateUserAttributes; // 0x128
        public ApiBundleDropNotificationDetails _notificationDetails; // 0x130
        public string _status; // 0x138
        public VRC.Core.ApiModel _metadata; // 0x140
        public string ENDPOINT;
        public string FLAG_USER_GENERATED;
        public string FLAG_INSTANTIATABLE;
        public string FLAG_CONSUMABLE;
        public string FLAG_TRASHABLE;
        public string FLAG_ARCHIVABLE;
        public string FLAG_CLONEABLE;
        public string FLAG_EQUIPPABLE;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2D8F90
        public void get_templateId(){} // RVA: 0x7FFE81176D50
        public void set_templateId(){} // RVA: 0x7FFE81176D60
        public void get_name(){} // RVA: 0x7FFE811C3590
        public void set_name(){} // RVA: 0x7FFE811C35A0
        public void get_description(){} // RVA: 0x7FFE81463AE0
        public void set_description(){} // RVA: 0x7FFE81464570
        public void get_imageUrl(){} // RVA: 0x7FFE81280C30
        public void set_imageUrl(){} // RVA: 0x7FFE81282380
        public void get_attribution(){} // RVA: 0x7FFE8113A010
        public void set_attribution(){} // RVA: 0x7FFE81280F90
        public void get_flags(){} // RVA: 0x7FFE8154EB60
        public void set_flags(){} // RVA: 0x7FFE818CE320
        public void get_tags(){} // RVA: 0x7FFE817AE360
        public void set_tags(){} // RVA: 0x7FFE8171B470
        public void get_collections(){} // RVA: 0x7FFE8179C860
        public void set_collections(){} // RVA: 0x7FFE8171B4D0
        public void get_itemType(){} // RVA: 0x7FFE817AB5E0
        public void set_itemType(){} // RVA: 0x7FFE81857260
        public void get_holderId(){} // RVA: 0x7FFE81166040
        public void set_holderId(){} // RVA: 0x7FFE81166050
        public void get_firstAncestor(){} // RVA: 0x7FFE811660B0
        public void set_firstAncestor(){} // RVA: 0x7FFE811660C0
        public void get_firstAncestorHolderId(){} // RVA: 0x7FFE81166120
        public void set_firstAncestorHolderId(){} // RVA: 0x7FFE81166130
        public void get_expiryDate(){} // RVA: 0x7FFE81253460
        public void set_expiryDate(){} // RVA: 0x7FFE89DBC280
        public void get_created_at(){} // RVA: 0x7FFE81218100
        public void set_created_at(){} // RVA: 0x7FFE87414000
        public void get_updated_at(){} // RVA: 0x7FFE8181EA80
        public void set_updated_at(){} // RVA: 0x7FFE89E6C790
        public void get_template_created_at(){} // RVA: 0x7FFE8117C900
        public void set_template_created_at(){} // RVA: 0x7FFE8A2C5BE0
        public void get_template_updated_at(){} // RVA: 0x7FFE8117C970
        public void set_template_updated_at(){} // RVA: 0x7FFE86B570F0
        public void get_isArchived(){} // RVA: 0x7FFE8117CAD0
        public void set_isArchived(){} // RVA: 0x7FFE8117CAE0
        public void get_isSeen(){} // RVA: 0x7FFE82145E40
        public void set_isSeen(){} // RVA: 0x7FFE82145F60
        public void get_last_equipped_at(){} // RVA: 0x7FFE8158D5D0
        public void set_last_equipped_at(){} // RVA: 0x7FFE84A61F90
        public void get_equipSlots(){} // RVA: 0x7FFE81828B50
        public void set_equipSlots(){} // RVA: 0x7FFE81A58AB0
        public void get_equipSlot(){} // RVA: 0x7FFE8181E3D0
        public void set_equipSlot(){} // RVA: 0x7FFE81A60200
        public void get_quantity(){} // RVA: 0x7FFE81A812D0
        public void set_quantity(){} // RVA: 0x7FFE82862FB0
        public void get_quantifiable(){} // RVA: 0x7FFE8A2D9050
        public void set_quantifiable(){} // RVA: 0x7FFE8A2D9060
        public void get_defaultAttributes(){} // RVA: 0x7FFE81318010
        public void set_defaultAttributes(){} // RVA: 0x7FFE81317920
        public void get_userAttributes(){} // RVA: 0x7FFE813A1DA0
        public void set_userAttributes(){} // RVA: 0x7FFE813A0830
        public void get_validateUserAttributes(){} // RVA: 0x7FFE8158C5E0
        public void set_validateUserAttributes(){} // RVA: 0x7FFE8158E950
        public void get_notificationDetails(){} // RVA: 0x7FFE81823850
        public void set_notificationDetails(){} // RVA: 0x7FFE81B31120
        public void get_status(){} // RVA: 0x7FFE8181EA70
        public void set_status(){} // RVA: 0x7FFE818254E0
        public void get_metadata(){} // RVA: 0x7FFE811665F0
        public void set_metadata(){} // RVA: 0x7FFE81166600
        public void get_Instantiatable(){} // RVA: 0x7FFE8A2D9070
        public void get_Consumable(){} // RVA: 0x7FFE8A2D90E0
        public void get_Archivable(){} // RVA: 0x7FFE8A2D9150
        public void get_Trashable(){} // RVA: 0x7FFE8A2D91C0
        public void get_Cloneable(){} // RVA: 0x7FFE8A2D9230
        public void get_Equippable(){} // RVA: 0x7FFE8A2D92A0
        public void get_Equipped(){} // RVA: 0x7FFE8A2D9330
        public void get_IsUserGenerated(){} // RVA: 0x7FFE8A2D9370
        public void get_IsTemplate(){} // RVA: 0x7FFE8A2D93E0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFE8A2D9630 | overloaded x2
        public void GetModelForMetadataType(){} // RVA: 0x7FFE8A2D9850
        public void FetchList(){} // RVA: 0x7FFE8A2D9F20
        public void Fetch(){} // RVA: 0x7FFE8A2DB370
        public void SetIsArchived(){} // RVA: 0x7FFE8A2DB6A0
        public void SetIsSeen(){} // RVA: 0x7FFE8A2DBB30
        public void Consume(){} // RVA: 0x7FFE8A2DBFC0 | overloaded x2
        public void FetchInventoryTemplate(){} // RVA: 0x7FFE8A2DC340
        public void FetchInventoryTemplateAsync(){} // RVA: 0x7FFE8A2DC670
        public void FetchUserInventoryItem(){} // RVA: 0x7FFE8A2DC810
        public void Equip(){} // RVA: 0x7FFE8A2DCB60
        public void ClearEquipSlot(){} // RVA: 0x7FFE8A2DD1A0
        public void SaveUserAttributes(){} // RVA: 0x7FFE8A2DD490
        public void FetchEquipped(){} // RVA: 0x7FFE8A2DDA00
        public void GetAttributes(){} // RVA: 0x7FFE8A2DE010
        public void GetDefaultAttributes(){} // RVA: 0x7FFE8A2DE300
        public void FetchAllTemplates(){} // RVA: 0x7FFE8A2DE540
    }

    public class ApiInventoryItemContainer : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.ApiInventoryItem> _data; // 0x68
        public int _totalCount; // 0x70

        // ── Methods ──
        public void get_data(){} // RVA: 0x7FFE81176D50
        public void set_data(){} // RVA: 0x7FFE81176D60
        public void get_totalCount(){} // RVA: 0x7FFE81E60180
        public void set_totalCount(){} // RVA: 0x7FFE81293CF0
        public void .ctor(){} // RVA: 0x7FFE8A2DFC30
    }

    public class ApiInventoryJweToken : ApiModel
    {
        public string _token; // 0x68

        // ── Methods ──
        public void get_token(){} // RVA: 0x7FFE81176D50
        public void set_token(){} // RVA: 0x7FFE81176D60
        public void RequestSpawnToken(){} // RVA: 0x7FFE8A2DFC80
        public void RequestDirectShareToken(){} // RVA: 0x7FFE8A2E0180
        public void RequestPedestalShareToken(){} // RVA: 0x7FFE8A2E06D0
        public void RequestClone(){} // RVA: 0x7FFE8A2E0DE0
        public void .ctor(){} // RVA: 0x7FFE8A2E12E0
    }

    public class ApiLedgerTransaction : ApiModel
    {
        public int _amount; // 0x68
        public int _runningBalance; // 0x6C
        public System.DateTime _date; // 0x70
        public string _listingDisplayName; // 0x78
        public string _listingID; // 0x80
        public string _listingType; // 0x88
        public string _platform; // 0x90
        public string _purchaseId; // 0x98
        public int _reason; // 0xA0
        public VRC.Core.ApiLocalizableString _reasonLabel; // 0xA8
        public string _toUserId; // 0xB0
        public string _toUserDisplayName; // 0xB8
        public string _fromUserId; // 0xC0
        public string _fromUserDisplayName; // 0xC8
        public long _transactionId; // 0xD0
        public long _transactionLineId; // 0xD8
        public object field_16; // 0x8478

        // ── Methods ──
        public void get_Amount(){} // RVA: 0x7FFE82A22EF0
        public void set_Amount(){} // RVA: 0x7FFE82A22F00
        public void get_RunningBalance(){} // RVA: 0x7FFE82A22F10
        public void set_RunningBalance(){} // RVA: 0x7FFE82A22F20
        public void get_Date(){} // RVA: 0x7FFE811C3590
        public void set_Date(){} // RVA: 0x7FFE82C95C70
        public void get_ListingDisplayName(){} // RVA: 0x7FFE81463AE0
        public void set_ListingDisplayName(){} // RVA: 0x7FFE81464570
        public void get_ListingID(){} // RVA: 0x7FFE81280C30
        public void set_ListingID(){} // RVA: 0x7FFE81282380
        public void get_ListingType(){} // RVA: 0x7FFE8113A010
        public void set_ListingType(){} // RVA: 0x7FFE81280F90
        public void get_Platform(){} // RVA: 0x7FFE8154EB60
        public void set_Platform(){} // RVA: 0x7FFE818CE320
        public void get_PurchaseId(){} // RVA: 0x7FFE817AE360
        public void set_PurchaseId(){} // RVA: 0x7FFE8171B470
        public void get_Reason(){} // RVA: 0x7FFE82B06FB0
        public void set_Reason(){} // RVA: 0x7FFE82B06FC0
        public void get_ReasonLabel(){} // RVA: 0x7FFE817AB5E0
        public void set_ReasonLabel(){} // RVA: 0x7FFE81857260
        public void get_ToUserId(){} // RVA: 0x7FFE81166040
        public void set_ToUserId(){} // RVA: 0x7FFE81166050
        public void get_ToUserDisplayName(){} // RVA: 0x7FFE811660B0
        public void set_ToUserDisplayName(){} // RVA: 0x7FFE811660C0
        public void get_FromUserId(){} // RVA: 0x7FFE81166120
        public void set_FromUserId(){} // RVA: 0x7FFE81166130
        public void get_FromUserDisplayName(){} // RVA: 0x7FFE81253460
        public void set_FromUserDisplayName(){} // RVA: 0x7FFE81253470
        public void get_TransactionId(){} // RVA: 0x7FFE81218100
        public void set_TransactionId(){} // RVA: 0x7FFE87414000
        public void get_TransactionLineId(){} // RVA: 0x7FFE8181EA80
        public void set_TransactionLineId(){} // RVA: 0x7FFE89E6C790
        public void get_id(){} // RVA: 0x7FFE8A2E14E0
        public void .ctor(){} // RVA: 0x7FFE8A2E1580
    }

    public class ApiLedgerTransactions : ApiModel
    {
        public System.DateTime _startDate; // 0x68
        public System.DateTime _endDate; // 0x70
        public System.Collections.Generic.List`1<VRC.Core.ApiLedgerTransaction> _transactions; // 0x78

        // ── Methods ──
        public void get_StartDate(){} // RVA: 0x7FFE81176D50
        public void set_StartDate(){} // RVA: 0x7FFE82C95C80
        public void get_EndDate(){} // RVA: 0x7FFE811C3590
        public void set_EndDate(){} // RVA: 0x7FFE82C95C70
        public void get_Transactions(){} // RVA: 0x7FFE81463AE0
        public void set_Transactions(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE8A2E1490
    }

    public class ApiLicense : ApiModel
    {
        public string _licenseId; // 0x68
        public string _ownerId; // 0x70
        public string _ownerDisplayName; // 0x78
        public string _licenseHolderId; // 0x80
        public string _licenseHolderDisplayName; // 0x88
        public 0x664ADFCC _forType; // 0x90
        public string _forId; // 0x98
        public string _productId; // 0xA0
        public 0x664AE024 _productType; // 0xA8
        public bool _isActive; // 0xAC
        public System.DateTime _untilDate; // 0xB0
        public bool _isCurrent; // 0xB8
        public System.DateTime _created; // 0xC0
        public string _forAction; // 0xC8
        public string _forName; // 0xD0
        public string _licenseHolderType; // 0xD8
        public System.Collections.Generic.List`1<VRC.Core.ApiLicenseNote> _notes; // 0xE0
        public System.Collections.Generic.List`1<string> _tags; // 0xE8
        public System.DateTime _updated; // 0xF0

        // ── Methods ──
        public void get_LicenseId(){} // RVA: 0x7FFE81176D50
        public void set_LicenseId(){} // RVA: 0x7FFE81176D60
        public void get_OwnerId(){} // RVA: 0x7FFE811C3590
        public void set_OwnerId(){} // RVA: 0x7FFE811C35A0
        public void get_OwnerDisplayName(){} // RVA: 0x7FFE81463AE0
        public void set_OwnerDisplayName(){} // RVA: 0x7FFE81464570
        public void get_LicenseHolderId(){} // RVA: 0x7FFE81280C30
        public void set_LicenseHolderId(){} // RVA: 0x7FFE81282380
        public void get_LicenseHolderDisplayName(){} // RVA: 0x7FFE8113A010
        public void set_LicenseHolderDisplayName(){} // RVA: 0x7FFE81280F90
        public void get_ForType(){} // RVA: 0x7FFE814AA220
        public void set_ForType(){} // RVA: 0x7FFE81C8DB30
        public void get_ForId(){} // RVA: 0x7FFE817AE360
        public void set_ForId(){} // RVA: 0x7FFE8171B470
        public void get_ProductId(){} // RVA: 0x7FFE8179C860
        public void set_ProductId(){} // RVA: 0x7FFE8171B4D0
        public void get_ProductType(){} // RVA: 0x7FFE81A338E0
        public void set_ProductType(){} // RVA: 0x7FFE81A34770
        public void get_IsActive(){} // RVA: 0x7FFE87E75EC0
        public void set_IsActive(){} // RVA: 0x7FFE87E75ED0
        public void get_UntilDate(){} // RVA: 0x7FFE81166040
        public void set_UntilDate(){} // RVA: 0x7FFE82904640
        public void get_IsCurrent(){} // RVA: 0x7FFE824AEC00
        public void set_IsCurrent(){} // RVA: 0x7FFE824AD2F0
        public void get_Created(){} // RVA: 0x7FFE81166120
        public void set_Created(){} // RVA: 0x7FFE81C16D50
        public void get_ForAction(){} // RVA: 0x7FFE81253460
        public void set_ForAction(){} // RVA: 0x7FFE81253470
        public void get_ForName(){} // RVA: 0x7FFE81218100
        public void set_ForName(){} // RVA: 0x7FFE81218110
        public void get_LicenseHolderType(){} // RVA: 0x7FFE8181EA80
        public void set_LicenseHolderType(){} // RVA: 0x7FFE8117C8A0
        public void get_Notes(){} // RVA: 0x7FFE8117C900
        public void set_Notes(){} // RVA: 0x7FFE8117C910
        public void get_Tags(){} // RVA: 0x7FFE8117C970
        public void set_Tags(){} // RVA: 0x7FFE8117C980
        public void get_Updated(){} // RVA: 0x7FFE811662A0
        public void set_Updated(){} // RVA: 0x7FFE86F105E0
        public void FetchLicenses(){} // RVA: 0x7FFE8A2E15D0
        public void FetchActiveLicenses(){} // RVA: 0x7FFE8A2E18D0
        public void ReadField(){} // RVA: 0x7FFE8A2E2220
        public void WriteField(){} // RVA: 0x7FFE8A2E2640
        public void .ctor(){} // RVA: 0x7FFE8A2E2850
    }

    public class ApiLicenseNote : ApiModel
    {
        public System.DateTime _createdAt; // 0x68
        public string _note; // 0x70

        // ── Methods ──
        public void get_CreatedAt(){} // RVA: 0x7FFE81176D50
        public void set_CreatedAt(){} // RVA: 0x7FFE82C95C80
        public void get_Note(){} // RVA: 0x7FFE811C3590
        public void set_Note(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A2E2A20
    }

    public class ApiListContainer : ApiContainer
    {
        public int _totalCount; // 0x60
        public System.Collections.Generic.IReadOnlyList`1<T> _responseModels;

        // ── Methods ──
        public void get_ResponseList(){} // RVA: 0x7FFE8A32BF90
        public void get_TotalCount(){} // RVA: 0x7FFE8139EA30
        public void set_TotalCount(){} // RVA: 0x7FFE8139E520
        public void Validate(){} // RVA: 0x7FFE8A32C000
        public void .ctor(){} // RVA: 0x7FFE8A32C380
    }

    public class ApiLoadingScreen : ApiModel
    {
        public string _name; // 0x68
        public string _assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_assetBundleId(){} // RVA: 0x7FFE811C3590
        public void set_assetBundleId(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A2E2A70
    }

    public class ApiLocalizableString : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
    }

    public class ApiMessage : ApiModel
    {
        public System.Collections.Generic.Dictionary`2<dFixup.legate,string> messageTypeToMessageAPI;
        public int MaxMessageLength;
        public int _slot; // 0x68
        public string _message; // 0x70
        public string _messageType; // 0x78
        public System.DateTime _updatedAt; // 0x80

        // ── Methods ──
        public void get_slot(){} // RVA: 0x7FFE82A22EF0
        public void set_slot(){} // RVA: 0x7FFE82A22F00
        public void get_message(){} // RVA: 0x7FFE811C3590
        public void set_message(){} // RVA: 0x7FFE811C35A0
        public void get_messageType(){} // RVA: 0x7FFE81463AE0
        public void set_messageType(){} // RVA: 0x7FFE81464570
        public void get_updatedAt(){} // RVA: 0x7FFE81280C30
        public void set_updatedAt(){} // RVA: 0x7FFE82C95C90
        public void get_remainingCooldownMinutes(){} // RVA: 0x7FFE8194AD00
        public void set_remainingCooldownMinutes(){} // RVA: 0x7FFE8194A400
        public void get_canBeUpdated(){} // RVA: 0x7FFE81163520
        public void set_canBeUpdated(){} // RVA: 0x7FFE81163530
        public void .ctor(){} // RVA: 0x7FFE8A2E2AC0
        public void FetchMessages(){} // RVA: 0x7FFE8A2E2C90 | overloaded x2
        public void DeleteAllMessages(){} // RVA: 0x7FFE8A2E3130 | overloaded x2
        public void DeleteMessageInSlot(){} // RVA: 0x7FFE8A2E35F0 | overloaded x2
        public void SetMessageInSlot(){} // RVA: 0x7FFE8A2E3B40 | overloaded x2
        public void truncatedMessage(){} // RVA: 0x7FFE8A2E4170
        public void ToString(){} // RVA: 0x7FFE8A2E41E0
        public void .cctor(){} // RVA: 0x7FFE8A2E43F0
    }

    public class ApiModel : Object
    {
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiContainer> activeRequests;
        public int maximumParseDepth;
        public int currentRemainingDepth; // 0x8
        public Unity.Profiling.ProfilerMarker _setApiFieldsFromJsonProfilerMarker; // 0x10
        public string _id; // 0x10
        public System.Nullable`1<long> _expiryTime; // 0x18
        public bool _populated; // 0x28
        public bool _failedValidation; // 0x29
        public string _endpoint; // 0x30

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE81116380
        public void set_id(){} // RVA: 0x7FFE810FCE30
        public void get_ExpiryTime(){} // RVA: 0x7FFE81703940
        public void set_ExpiryTime(){} // RVA: 0x7FFE817036E0
        public void get_Populated(){} // RVA: 0x7FFE815F1380
        public void set_Populated(){} // RVA: 0x7FFE81C15740
        public void get_FailedValidation(){} // RVA: 0x7FFE819C2EA0
        public void set_FailedValidation(){} // RVA: 0x7FFE8268C820
        public void get_Endpoint(){} // RVA: 0x7FFE8144E200
        public void set_Endpoint(){} // RVA: 0x7FFE81129890
        public void GetOrPutCachedMissingFieldList(){} // RVA: 0x7FFE8A2E4900
        public void get_FieldsMissingFromOriginalResponse(){} // RVA: 0x7FFE81176730
        public void set_FieldsMissingFromOriginalResponse(){} // RVA: 0x7FFE81176740
        public void get_FieldsLockedForNetworkUpdates(){} // RVA: 0x7FFE8119C0E0
        public void set_FieldsLockedForNetworkUpdates(){} // RVA: 0x7FFE812534D0
        public void GetCacheId(){} // RVA: 0x7FFE8A2E51E0
        public void ComputeCacheId(){} // RVA: 0x7FFE8A2E54A0
        public void ShouldCache(){} // RVA: 0x7FFE8A2E58B0
        public void GetLifeSpan(){} // RVA: 0x7FFE8A2E58F0
        public void .ctor(){} // RVA: 0x7FFE8A2E59D0 | overloaded x3
        public void Clone(){} // RVA: 0x7FFE8A2E5C60 | overloaded x3
        public void Save(){} // RVA: 0x7FFE8A2E61B0
        public void SaveField(){} // RVA: 0x7FFE8A2E61F0
        public void Post(){} // RVA: 0x7FFE8A2E64C0
        public void Put(){} // RVA: 0x7FFE8A2E6500
        public void Fetch(){} // RVA: 0x7FFE8A2E6540
        public void PostAsync(){} // RVA: 0x7FFE810A1420
        public void PutAsync(){} // RVA: 0x7FFE810A1420
        public void FetchAsync(){} // RVA: 0x7FFE810A1420
        public void Get(){} // RVA: 0x7FFE8A2E6570
        public void PostOrPut(){} // RVA: 0x7FFE8A2E6DE0
        public void Delete(){} // RVA: 0x7FFE8A2E85C0
        public void DeleteAsync(){} // RVA: 0x7FFE8A2E8860
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFE8A2E9B50 | overloaded x4
        public void PopulateMissingValuesFrom(){} // RVA: 0x7FFE8A2EA8B0
        public void ExtractApiFields(){} // RVA: 0x7FFE8A2EAD70
        public void MakeModelContainer(){} // RVA: 0x7FFE8A2EB150
        public void ReadField(){} // RVA: 0x7FFE8A2EB3D0
        public void TryReadConvert(){} // RVA: 0x7FFE8A2EB7C0
        public void WriteField(){} // RVA: 0x7FFE8A2ECC70
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFE810FB320
        public void GetCreateFromJsonMethodInfo(){} // RVA: 0x7FFE8A2EDBF0
        public void ParseEnumValue(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void IsNumber(){} // RVA: 0x7FFE8A2EE1E0
        public void DoubleCast(){} // RVA: 0x7FFE8A2EE290
        public void TryWriteConvert(){} // RVA: 0x7FFE8A2EE660
        public void ParseList(){} // RVA: 0x7FFE8A2EF770
        public void ParseDictionary(){} // RVA: 0x7FFE8A2EFC30
        public void ParseModel(){} // RVA: 0x7FFE8A2F0430
        public void ParseLocalizableString(){} // RVA: 0x7FFE8A2F0680
        public void SendGetRequest(){} // RVA: 0x7FFE8A2F0860
        public void SendPutRequest(){} // RVA: 0x7FFE8A2F0B10
        public void MakeRequestEndpoint(){} // RVA: 0x7FFE8A2F0BE0
        public void get_RequiredProperties(){} // RVA: 0x7FFE8A2F0C90
        public void get_TargetProperties(){} // RVA: 0x7FFE8A2F12D0
        public void FindPropertyName(){} // RVA: 0x7FFE8A2F16F0
        public void FindProperty(){} // RVA: 0x7FFE8A2F1A00
        public void IsAdminWritableOnly(){} // RVA: 0x7FFE8A2F1EF0
        public void IsApiWritableOnly(){} // RVA: 0x7FFE8A2F20E0
        public void .cctor(){} // RVA: 0x7FFE8A2F22D0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0 | overloaded x2
        public void ValidModelData(){} // RVA: 0x7FFE80E2F150
        public void Validate(){}
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public System.Collections.Generic.IReadOnlyList`1<T> _responseModels;

        // ── Methods ──
        public void get_ResponseModels(){} // RVA: 0x7FFE80E2E2E0
        public void set_ResponseModels(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Validate(){}
    }

    public class ApiModeration : ApiModel
    {
        public float ListCacheTime;
        public 0x664A900C _moderationType; // 0x68
        public string _moderatorUserId; // 0x70
        public string _moderatorDisplayName; // 0x78
        public string _targetUserId; // 0x80
        public string _targetDisplayName; // 0x88
        public string _reasonMessage; // 0x90
        public System.Collections.Generic.Dictionary`2<string,object> _details; // 0x98
        public System.DateTime _created; // 0xA0
        public System.DateTime _expires; // 0xA8
        public System.Nullable`1<0x664A9064> expiresRange; // 0xB0
        public bool _isPermanent; // 0xB8

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7FFE82A22EF0
        public void set_moderationType(){} // RVA: 0x7FFE82A22F00
        public void get_moderatorUserId(){} // RVA: 0x7FFE811C3590
        public void set_moderatorUserId(){} // RVA: 0x7FFE811C35A0
        public void get_moderatorDisplayName(){} // RVA: 0x7FFE81463AE0
        public void set_moderatorDisplayName(){} // RVA: 0x7FFE81464570
        public void get_targetUserId(){} // RVA: 0x7FFE81280C30
        public void set_targetUserId(){} // RVA: 0x7FFE81282380
        public void get_targetDisplayName(){} // RVA: 0x7FFE8113A010
        public void set_targetDisplayName(){} // RVA: 0x7FFE81280F90
        public void get_reasonMessage(){} // RVA: 0x7FFE8154EB60
        public void set_reasonMessage(){} // RVA: 0x7FFE818CE320
        public void get_details(){} // RVA: 0x7FFE817AE360
        public void set_details(){} // RVA: 0x7FFE8171B470
        public void get_created(){} // RVA: 0x7FFE8179C860
        public void set_created(){} // RVA: 0x7FFE86B370C0
        public void get_expires(){} // RVA: 0x7FFE817AB5E0
        public void set_expires(){} // RVA: 0x7FFE82904630
        public void get_isPermanent(){} // RVA: 0x7FFE824AEC00
        public void set_isPermanent(){} // RVA: 0x7FFE824AD2F0
        public void get_worldId(){} // RVA: 0x7FFE81166120
        public void set_worldId(){} // RVA: 0x7FFE81166130
        public void get_instanceId(){} // RVA: 0x7FFE81253460
        public void set_instanceId(){} // RVA: 0x7FFE81253470
        public void .ctor(){} // RVA: 0x7FFE8A2F39D0 | overloaded x2
        public void ShouldCache(){} // RVA: 0x7FFE810FB320
        public void ReadField(){} // RVA: 0x7FFE8A2F3A70
        public void WriteField(){} // RVA: 0x7FFE8A2F3EF0
        public void SendModeration(){} // RVA: 0x7FFE8A2F4120
        public void SendVoteKick(){} // RVA: 0x7FFE8A2F44E0
        public void DeleteModeration(){} // RVA: 0x7FFE8A2F4810
        public void LocalFetchAll(){} // RVA: 0x7FFE8A2F4A30
        public void ModerationTimeRangeToString(){} // RVA: 0x7FFE8A2F4D30
        public void ContestModeration(){} // RVA: 0x7FFE8A2F4DD0
    }

    public class ApiModerationResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ApiModerationResultExtensions : Object
    {
        // ── Methods ──
        public void WasModerated(){} // RVA: 0x7FFE8A2F53E0
        public void GetModerationResult(){} // RVA: 0x7FFE8A2F5400
    }

    public class ApiMutualFriend : ApiModel
    {
        public string _displayName; // 0x68
        public string _status; // 0x70
        public string _statusDescription; // 0x78
        public string _currentAvatarImageUrl; // 0x80
        public string _avatarThumbnail; // 0x88
        public string[] _currentAvatarTags; // 0x90
        public string _profilePicOverride; // 0x98
        public string _userIcon; // 0xA0
        public string _world; // 0xA8
        public string _instance; // 0xB0
        public string _instanceType; // 0xB8
        public string _travelingToWorld; // 0xC0
        public string _travelingToInstance; // 0xC8
        public string _platform; // 0xD0
        public string[] _groups; // 0xD8
        public object field_15; // 0x5A48
        public object field_16; // 0x5C00
        public object field_17; // 0x5DB8

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE81116380
        public void set_id(){} // RVA: 0x7FFE810FCE30
        public void get_displayName(){} // RVA: 0x7FFE81176D50
        public void set_displayName(){} // RVA: 0x7FFE81176D60
        public void get_status(){} // RVA: 0x7FFE811C3590
        public void set_status(){} // RVA: 0x7FFE811C35A0
        public void get_statusDescription(){} // RVA: 0x7FFE81463AE0
        public void set_statusDescription(){} // RVA: 0x7FFE81464570
        public void get_currentAvatarImageUrl(){} // RVA: 0x7FFE81280C30
        public void set_currentAvatarImageUrl(){} // RVA: 0x7FFE81282380
        public void get_avatarThumbnail(){} // RVA: 0x7FFE8113A010
        public void set_avatarThumbnail(){} // RVA: 0x7FFE81280F90
        public void get_currentAvatarTags(){} // RVA: 0x7FFE8154EB60
        public void set_currentAvatarTags(){} // RVA: 0x7FFE818CE320
        public void get_profilePicOverride(){} // RVA: 0x7FFE817AE360
        public void set_profilePicOverride(){} // RVA: 0x7FFE8171B470
        public void get_userIcon(){} // RVA: 0x7FFE8179C860
        public void set_userIcon(){} // RVA: 0x7FFE8171B4D0
        public void get_world(){} // RVA: 0x7FFE817AB5E0
        public void set_world(){} // RVA: 0x7FFE81857260
        public void get_instance(){} // RVA: 0x7FFE81166040
        public void set_instance(){} // RVA: 0x7FFE81166050
        public void get_instanceType(){} // RVA: 0x7FFE811660B0
        public void set_instanceType(){} // RVA: 0x7FFE811660C0
        public void get_travelingToWorld(){} // RVA: 0x7FFE81166120
        public void set_travelingToWorld(){} // RVA: 0x7FFE81166130
        public void get_travelingToInstance(){} // RVA: 0x7FFE81253460
        public void set_travelingToInstance(){} // RVA: 0x7FFE81253470
        public void get_platform(){} // RVA: 0x7FFE81218100
        public void set_platform(){} // RVA: 0x7FFE81218110
        public void get_groups(){} // RVA: 0x7FFE8181EA80
        public void set_groups(){} // RVA: 0x7FFE8117C8A0
        public void get_profilePicImageUrl(){} // RVA: 0x7FFE8A3854B0
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0x7FFE8A3854D0
        public void FetchMutualFriendsAsync(){} // RVA: 0x7FFE8A385500
        public void .ctor(){} // RVA: 0x7FFE8A3856D0
    }

    public class ApiMutualGroup : ApiModel
    {
        public string _name; // 0x68
        public string _discriminator; // 0x70
        public string _ownerId; // 0x78
        public string _privacy; // 0x80
        public int _memberCount; // 0x88
        public string _shortCode; // 0x90
        public string _description; // 0x98
        public string _bannerId; // 0xA0
        public string _bannerUrl; // 0xA8
        public string _iconId; // 0xB0
        public string _iconUrl; // 0xB8
        public string _lastPostCreatedAt; // 0xC0
        public object field_12; // 0x7580

        // ── Methods ──
        public void get_id(){} // RVA: 0x7FFE81116380
        public void set_id(){} // RVA: 0x7FFE810FCE30
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_discriminator(){} // RVA: 0x7FFE811C3590
        public void set_discriminator(){} // RVA: 0x7FFE811C35A0
        public void get_ownerId(){} // RVA: 0x7FFE81463AE0
        public void set_ownerId(){} // RVA: 0x7FFE81464570
        public void get_privacy(){} // RVA: 0x7FFE81280C30
        public void set_privacy(){} // RVA: 0x7FFE81282380
        public void get_memberCount(){} // RVA: 0x7FFE8194AD00
        public void set_memberCount(){} // RVA: 0x7FFE8194A400
        public void get_shortCode(){} // RVA: 0x7FFE8154EB60
        public void set_shortCode(){} // RVA: 0x7FFE818CE320
        public void get_description(){} // RVA: 0x7FFE817AE360
        public void set_description(){} // RVA: 0x7FFE8171B470
        public void get_bannerId(){} // RVA: 0x7FFE8179C860
        public void set_bannerId(){} // RVA: 0x7FFE8171B4D0
        public void get_bannerUrl(){} // RVA: 0x7FFE817AB5E0
        public void set_bannerUrl(){} // RVA: 0x7FFE81857260
        public void get_iconId(){} // RVA: 0x7FFE81166040
        public void set_iconId(){} // RVA: 0x7FFE81166050
        public void get_iconUrl(){} // RVA: 0x7FFE811660B0
        public void set_iconUrl(){} // RVA: 0x7FFE811660C0
        public void get_lastPostCreatedAt(){} // RVA: 0x7FFE81166120
        public void set_lastPostCreatedAt(){} // RVA: 0x7FFE81166130
        public void FetchMutualGroupsAsync(){} // RVA: 0x7FFE8A3863B0
        public void .ctor(){} // RVA: 0x7FFE8A386580
    }

    public class ApiNotification : ApiModel
    {
        public int _version; // 0x68
        public 0x664A937C _notificationType; // 0x6C
        public string _category; // 0x70
        public bool _isSystem; // 0x78
        public string _senderUserId; // 0x80
        public string _senderUsername; // 0x88
        public string _receiverUserId; // 0x90
        public string _relatedNotificationsId; // 0x98
        public string _title; // 0xA0
        public string _titleKey; // 0xA8
        public string _message; // 0xB0
        public string _messageKey; // 0xB8
        public string _imageUrl; // 0xC0
        public string _link; // 0xC8
        public string _linkText; // 0xD0
        public string _linkTextKey; // 0xD8
        public object[] _responses; // 0xE0
        public System.DateTime _expiresAt; // 0xE8
        public System.Nullable`1<int> _expiryAfterSeen; // 0xF0
        public bool _seen; // 0xF8
        public bool _ignoreDND; // 0xF9
        public bool _canDelete; // 0xFA
        public System.DateTime _created_at; // 0x100
        public System.DateTime _createdAt; // 0x108
        public System.DateTime _updatedAt; // 0x110
        public System.Collections.Generic.Dictionary`2<string,object> _details; // 0x118
        public System.Collections.Generic.Dictionary`2<string,string> _data; // 0x120
        public string _jobName; // 0x128
        public string _jobColor; // 0x130

        // ── Methods ──
        public void get_version(){} // RVA: 0x7FFE82A22EF0
        public void set_version(){} // RVA: 0x7FFE82A22F00
        public void get_notificationType(){} // RVA: 0x7FFE82A22F10
        public void set_notificationType(){} // RVA: 0x7FFE82A22F20
        public void get_category(){} // RVA: 0x7FFE811C3590
        public void set_category(){} // RVA: 0x7FFE811C35A0
        public void get_isSystem(){} // RVA: 0x7FFE816400C0
        public void set_isSystem(){} // RVA: 0x7FFE81FE6AC0
        public void get_senderUserId(){} // RVA: 0x7FFE81280C30
        public void set_senderUserId(){} // RVA: 0x7FFE81282380
        public void get_senderUsername(){} // RVA: 0x7FFE8113A010
        public void set_senderUsername(){} // RVA: 0x7FFE81280F90
        public void get_receiverUserId(){} // RVA: 0x7FFE8154EB60
        public void set_receiverUserId(){} // RVA: 0x7FFE818CE320
        public void get_relatedNotificationsId(){} // RVA: 0x7FFE817AE360
        public void set_relatedNotificationsId(){} // RVA: 0x7FFE8171B470
        public void get_title(){} // RVA: 0x7FFE8179C860
        public void set_title(){} // RVA: 0x7FFE8171B4D0
        public void get_titleKey(){} // RVA: 0x7FFE817AB5E0
        public void set_titleKey(){} // RVA: 0x7FFE81857260
        public void get_message(){} // RVA: 0x7FFE81166040
        public void set_message(){} // RVA: 0x7FFE81166050
        public void get_messageKey(){} // RVA: 0x7FFE811660B0
        public void set_messageKey(){} // RVA: 0x7FFE811660C0
        public void get_imageUrl(){} // RVA: 0x7FFE81166120
        public void set_imageUrl(){} // RVA: 0x7FFE81166130
        public void get_link(){} // RVA: 0x7FFE81253460
        public void set_link(){} // RVA: 0x7FFE81253470
        public void get_linkText(){} // RVA: 0x7FFE81218100
        public void set_linkText(){} // RVA: 0x7FFE81218110
        public void get_linkTextKey(){} // RVA: 0x7FFE8181EA80
        public void set_linkTextKey(){} // RVA: 0x7FFE8117C8A0
        public void get_responses(){} // RVA: 0x7FFE8117C900
        public void set_responses(){} // RVA: 0x7FFE8117C910
        public void get_expiresAt(){} // RVA: 0x7FFE8117C970
        public void set_expiresAt(){} // RVA: 0x7FFE86B570F0
        public void get_expiryAfterSeen(){} // RVA: 0x7FFE811662A0
        public void set_expiryAfterSeen(){} // RVA: 0x7FFE86F105E0
        public void get_seen(){} // RVA: 0x7FFE81F84060
        public void set_seen(){} // RVA: 0x7FFE87B57E70
        public void get_ignoreDND(){} // RVA: 0x7FFE81157F90
        public void set_ignoreDND(){} // RVA: 0x7FFE81157FA0
        public void get_canDelete(){} // RVA: 0x7FFE89DBC560
        public void set_canDelete(){} // RVA: 0x7FFE89DBC570
        public void get_created_at(){} // RVA: 0x7FFE81828B50
        public void set_created_at(){} // RVA: 0x7FFE82472650
        public void get_createdAt(){} // RVA: 0x7FFE8181E3D0
        public void set_createdAt(){} // RVA: 0x7FFE813173C0
        public void get_updatedAt(){} // RVA: 0x7FFE81317980
        public void set_updatedAt(){} // RVA: 0x7FFE86F10630
        public void get_details(){} // RVA: 0x7FFE81318010
        public void set_details(){} // RVA: 0x7FFE81317920
        public void get_data(){} // RVA: 0x7FFE813A1DA0
        public void set_data(){} // RVA: 0x7FFE813A0830
        public void get_jobName(){} // RVA: 0x7FFE8182B890
        public void set_jobName(){} // RVA: 0x7FFE81B31E10
        public void get_jobColor(){} // RVA: 0x7FFE81823850
        public void set_jobColor(){} // RVA: 0x7FFE81B31120
        public void .ctor(){} // RVA: 0x7FFE8A2F56E0
        public void ShouldCache(){} // RVA: 0x7FFE810FB320
        public void ReadField(){} // RVA: 0x7FFE8A2F5780
        public void WriteField(){} // RVA: 0x7FFE8A2F59C0
    }

    public class ApiPagedTransactions : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.ApiTransaction> _transactions; // 0x68
        public int _totalCount; // 0x70

        // ── Methods ──
        public void get_Transactions(){} // RVA: 0x7FFE81176D50
        public void set_Transactions(){} // RVA: 0x7FFE81176D60
        public void get_TotalCount(){} // RVA: 0x7FFE81E60180
        public void set_TotalCount(){} // RVA: 0x7FFE81293CF0
        public void FetchTransactions(){} // RVA: 0x7FFE8A332B40
        public void .ctor(){} // RVA: 0x7FFE8A333C40
    }

    public class ApiPendingTransaction : ApiModel
    {
        public string _userId; // 0x68
        public string _userDisplayName; // 0x70
        public string _targetUserId; // 0x78
        public string _targetDisplayName; // 0x80
        public string _status; // 0x88
        public Pico _pico; // 0x90
        public GPlay _gplay; // 0x98
        public Subscription _subscription; // 0xA0
        public string _created_at; // 0xA8
        public string _updated_at; // 0xB0
        public bool _isGift; // 0xB8
        public bool _isTokens; // 0xB9

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFE81176D50
        public void set_userId(){} // RVA: 0x7FFE81176D60
        public void get_userDisplayName(){} // RVA: 0x7FFE811C3590
        public void set_userDisplayName(){} // RVA: 0x7FFE811C35A0
        public void get_targetUserId(){} // RVA: 0x7FFE81463AE0
        public void set_targetUserId(){} // RVA: 0x7FFE81464570
        public void get_targetDisplayName(){} // RVA: 0x7FFE81280C30
        public void set_targetDisplayName(){} // RVA: 0x7FFE81282380
        public void get_status(){} // RVA: 0x7FFE8113A010
        public void set_status(){} // RVA: 0x7FFE81280F90
        public void get_pico(){} // RVA: 0x7FFE8154EB60
        public void set_pico(){} // RVA: 0x7FFE818CE320
        public void get_gplay(){} // RVA: 0x7FFE817AE360
        public void set_gplay(){} // RVA: 0x7FFE8171B470
        public void get_subscription(){} // RVA: 0x7FFE8179C860
        public void set_subscription(){} // RVA: 0x7FFE8171B4D0
        public void get_created_at(){} // RVA: 0x7FFE817AB5E0
        public void set_created_at(){} // RVA: 0x7FFE81857260
        public void get_updated_at(){} // RVA: 0x7FFE81166040
        public void set_updated_at(){} // RVA: 0x7FFE81166050
        public void get_isGift(){} // RVA: 0x7FFE824AEC00
        public void set_isGift(){} // RVA: 0x7FFE824AD2F0
        public void get_isTokens(){} // RVA: 0x7FFE8453D820
        public void set_isTokens(){} // RVA: 0x7FFE8453D830
        public void .ctor(){} // RVA: 0x7FFE8A350070
    }

    public class ApiPlayerModeration : ApiModel
    {
        public float ListCacheTime;
        public 0x664A942C _moderationType; // 0x68
        public string _targetUserId; // 0x70
        public string _targetDisplayName; // 0x78
        public string _sourceUserId; // 0x80
        public string _sourceDisplayName; // 0x88

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7FFE82A22EF0
        public void set_moderationType(){} // RVA: 0x7FFE82A22F00
        public void get_targetUserId(){} // RVA: 0x7FFE811C3590
        public void set_targetUserId(){} // RVA: 0x7FFE811C35A0
        public void get_targetDisplayName(){} // RVA: 0x7FFE81463AE0
        public void set_targetDisplayName(){} // RVA: 0x7FFE81464570
        public void get_sourceUserId(){} // RVA: 0x7FFE81280C30
        public void set_sourceUserId(){} // RVA: 0x7FFE81282380
        public void get_sourceDisplayName(){} // RVA: 0x7FFE8113A010
        public void set_sourceDisplayName(){} // RVA: 0x7FFE81280F90
        public void get_created(){} // RVA: 0x7FFE8154EB60
        public void set_created(){} // RVA: 0x7FFE81854020
        public void .ctor(){} // RVA: 0x7FFE8A2F5B10
        public void CreateRemovalModeration(){} // RVA: 0x7FFE8A2F5BD0
        public void ShouldCache(){} // RVA: 0x7FFE810FB320
        public void ReadField(){} // RVA: 0x7FFE8A2F5C90
        public void WriteField(){} // RVA: 0x7FFE8A2F5E90
        public void SendModeration(){} // RVA: 0x7FFE8A2F6070
        public void DeleteModeration(){} // RVA: 0x7FFE8A2F62B0
        public void FetchAllAgainstMe(){} // RVA: 0x7FFE8A2F6870
        public void FetchAllMine(){} // RVA: 0x7FFE8A2F68C0
        public void FetchList(){} // RVA: 0x7FFE8A2F6910
        public void ModerationTypeToAPIString(){} // RVA: 0x7FFE8A2F6BF0
    }

    public class ApiPortalSkin : ApiModel
    {
        public string _name; // 0x68
        public string _assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_assetBundleId(){} // RVA: 0x7FFE811C3590
        public void set_assetBundleId(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A2F70C0
    }

    public class ApiPrint : ApiModel
    {
        public string _note; // 0x68
        public string _authorId; // 0x70
        public string _authorName; // 0x78
        public string _worldId; // 0x80
        public string _worldName; // 0x88
        public string _ownerId; // 0x90
        public System.DateTime _timestamp; // 0x98
        public PrintFile _files; // 0xA0
        public System.DateTime _createdAt; // 0xA8

        // ── Methods ──
        public void get_note(){} // RVA: 0x7FFE81176D50
        public void set_note(){} // RVA: 0x7FFE81176D60
        public void get_authorId(){} // RVA: 0x7FFE811C3590
        public void set_authorId(){} // RVA: 0x7FFE811C35A0
        public void get_authorName(){} // RVA: 0x7FFE81463AE0
        public void set_authorName(){} // RVA: 0x7FFE81464570
        public void get_worldId(){} // RVA: 0x7FFE81280C30
        public void set_worldId(){} // RVA: 0x7FFE81282380
        public void get_worldName(){} // RVA: 0x7FFE8113A010
        public void set_worldName(){} // RVA: 0x7FFE81280F90
        public void get_ownerId(){} // RVA: 0x7FFE8154EB60
        public void set_ownerId(){} // RVA: 0x7FFE818CE320
        public void get_timestamp(){} // RVA: 0x7FFE817AE360
        public void set_timestamp(){} // RVA: 0x7FFE86225270
        public void get_files(){} // RVA: 0x7FFE8179C860
        public void set_files(){} // RVA: 0x7FFE8171B4D0
        public void get_createdAt(){} // RVA: 0x7FFE817AB5E0
        public void set_createdAt(){} // RVA: 0x7FFE82904630
        public void .ctor(){} // RVA: 0x7FFE8A31F690
        public void GetFileURL(){} // RVA: 0x7FFE8A31F790
        public void GetImageURL(){} // RVA: 0x7FFE8A31F7B0
        public void Upload(){} // RVA: 0x7FFE8A31F800
        public void UpdatePrint(){} // RVA: 0x7FFE8A31FD20
        public void GetPrints(){} // RVA: 0x7FFE8A320180
        public void GetPrint(){} // RVA: 0x7FFE8A3206C0
    }

    public class ApiProduct : ApiModel
    {
        public 0x664AE024 _type; // 0x68
        public System.DateTime _createdAt; // 0x70
        public System.DateTime _updatedAt; // 0x78
        public string _sellerId; // 0x80
        public string _avatarId; // 0x88
        public string _sellerDisplayName; // 0x90
        public string _name; // 0x98
        public string _description; // 0xA0
        public string _subtitle; // 0xA8
        public string _productImageId; // 0xB0
        public VRC.Core.ApiProductAttribution _attribution; // 0xB8
        public string _licenseId; // 0xC0
        public System.Collections.Generic.List`1<string> _tags; // 0xC8
        public bool _soldByVrc; // 0xD0
        public System.DateTime _untilDate; // 0xD8
        public System.Collections.Generic.Dictionary`2<string,object> _purchaseToken; // 0xE0
        public bool _isVoided; // 0xE8
        public System.Collections.Generic.List`1<string> _parentListings; // 0xF0
        public string _productTypeLabel; // 0xF8
        public bool _quantifiable; // 0x100
        public string _groupId; // 0x108
        public string _groupRoleId; // 0x110
        public bool _groupAccess; // 0x118
        public bool _groupAccessRemove; // 0x119
        public string _inventoryItemTemplateId; // 0x120
        public string _inventoryItemType; // 0x128
        public int _inventoryItemQuantity; // 0x130
        public bool _assetDisabled; // 0x134
        public string _listingID; // 0x138
        public 0x664AE07C _listingType; // 0x140
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> _products; // 0x148
        public System.Collections.Generic.List`1<string> _productIDs; // 0x150
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> _hydratedProducts; // 0x158
        public bool _active; // 0x160
        public bool _subscriberExclusive; // 0x161
        public int _price; // 0x164
        public int _vrcPlusDiscountPrice; // 0x168
        public System.DateTime _availableToPurchaseUntilDate; // 0x170
        public string _collaboratorUserId; // 0x178
        public string _collaboratorUserDisplayName; // 0x180
        public System.Nullable`1<int> _stock; // 0x188
        public System.Collections.Generic.List`1<string> _storeIDs; // 0x190
        public int _duration; // 0x198
        public 0x664AE0D4 _durationType; // 0x19C
        public bool _archived; // 0x1A0
        public bool _permanent; // 0x1A1
        public bool _instant; // 0x1A2
        public bool _stackable; // 0x1A3
        public bool _recurrable; // 0x1A4
        public bool _refundable; // 0x1A5
        public bool _buyerRefundable; // 0x1A6
        public bool _contextPreventsPurchase; // 0x1A7
        public System.Collections.Generic.List`1<VRC.Core.ApiProductVariant> _listingVariants; // 0x1A8
        public object field_53; // 0x4B40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A321150
        public void get_Type(){} // RVA: 0x7FFE82A22EF0
        public void set_Type(){} // RVA: 0x7FFE82A22F00
        public void get_CreatedAt(){} // RVA: 0x7FFE811C3590
        public void set_CreatedAt(){} // RVA: 0x7FFE82C95C70
        public void get_UpdatedAt(){} // RVA: 0x7FFE81463AE0
        public void set_UpdatedAt(){} // RVA: 0x7FFE865EFE40
        public void get_SellerId(){} // RVA: 0x7FFE81280C30
        public void set_SellerId(){} // RVA: 0x7FFE81282380
        public void get_AvatarId(){} // RVA: 0x7FFE8113A010
        public void set_AvatarId(){} // RVA: 0x7FFE81280F90
        public void get_SellerDisplayName(){} // RVA: 0x7FFE8154EB60
        public void set_SellerDisplayName(){} // RVA: 0x7FFE818CE320
        public void get_Name(){} // RVA: 0x7FFE817AE360
        public void set_Name(){} // RVA: 0x7FFE8171B470
        public void get_Description(){} // RVA: 0x7FFE8179C860
        public void set_Description(){} // RVA: 0x7FFE8171B4D0
        public void get_Subtitle(){} // RVA: 0x7FFE817AB5E0
        public void set_Subtitle(){} // RVA: 0x7FFE81857260
        public void get_ProductImageId(){} // RVA: 0x7FFE81166040
        public void set_ProductImageId(){} // RVA: 0x7FFE81166050
        public void get_ProductImageUrl(){} // RVA: 0x7FFE8A321210
        public void get_attribution(){} // RVA: 0x7FFE811660B0
        public void set_attribution(){} // RVA: 0x7FFE811660C0
        public void get_LicenseId(){} // RVA: 0x7FFE81166120
        public void set_LicenseId(){} // RVA: 0x7FFE81166130
        public void get_Tags(){} // RVA: 0x7FFE81253460
        public void set_Tags(){} // RVA: 0x7FFE81253470
        public void get_SoldByVrc(){} // RVA: 0x7FFE81644E40
        public void set_SoldByVrc(){} // RVA: 0x7FFE82619150
        public void get_UntilDate(){} // RVA: 0x7FFE8181EA80
        public void set_UntilDate(){} // RVA: 0x7FFE89E6C790
        public void get_PurchaseToken(){} // RVA: 0x7FFE8117C900
        public void set_PurchaseToken(){} // RVA: 0x7FFE8117C910
        public void get_IsVoided(){} // RVA: 0x7FFE822A56E0
        public void set_IsVoided(){} // RVA: 0x7FFE82C080B0
        public void get_ParentListings(){} // RVA: 0x7FFE811662A0
        public void set_ParentListings(){} // RVA: 0x7FFE811662B0
        public void get_ProductTypeLabel(){} // RVA: 0x7FFE8158D5D0
        public void set_ProductTypeLabel(){} // RVA: 0x7FFE81B0E4B0
        public void get_Quantifiable(){} // RVA: 0x7FFE81F84400
        public void set_Quantifiable(){} // RVA: 0x7FFE81F84A40
        public void get_GroupId(){} // RVA: 0x7FFE8181E3D0
        public void set_GroupId(){} // RVA: 0x7FFE81A60200
        public void get_GroupRoleId(){} // RVA: 0x7FFE81317980
        public void set_GroupRoleId(){} // RVA: 0x7FFE813159A0
        public void get_GroupAccess(){} // RVA: 0x7FFE89E6E4E0
        public void set_GroupAccess(){} // RVA: 0x7FFE8A321280
        public void get_GroupAccessRemove(){} // RVA: 0x7FFE8A321290
        public void set_GroupAccessRemove(){} // RVA: 0x7FFE8A3212A0
        public void get_InventoryItemTemplateId(){} // RVA: 0x7FFE813A1DA0
        public void set_InventoryItemTemplateId(){} // RVA: 0x7FFE813A0830
        public void get_InventoryItemType(){} // RVA: 0x7FFE8182B890
        public void set_InventoryItemType(){} // RVA: 0x7FFE81B31E10
        public void get_InventoryItemQuantity(){} // RVA: 0x7FFE8162C320
        public void set_InventoryItemQuantity(){} // RVA: 0x7FFE879054D0
        public void get_AssetDisabled(){} // RVA: 0x7FFE8A3212B0
        public void set_AssetDisabled(){} // RVA: 0x7FFE8A3212C0
        public void get_ListingID(){} // RVA: 0x7FFE8181EA70
        public void set_ListingID(){} // RVA: 0x7FFE818254E0
        public void get_ListingType(){} // RVA: 0x7FFE8234B330
        public void set_ListingType(){} // RVA: 0x7FFE82352360
        public void get_Products(){} // RVA: 0x7FFE81166660
        public void set_Products(){} // RVA: 0x7FFE81166670
        public void get_ProductIDs(){} // RVA: 0x7FFE81790740
        public void set_ProductIDs(){} // RVA: 0x7FFE81B350B0
        public void get_HydratedProducts(){} // RVA: 0x7FFE81B16560
        public void set_HydratedProducts(){} // RVA: 0x7FFE81B21880
        public void get_Active(){} // RVA: 0x7FFE86DBB030
        public void set_Active(){} // RVA: 0x7FFE86DBB040
        public void get_SubscriberExclusive(){} // RVA: 0x7FFE86DBB050
        public void set_SubscriberExclusive(){} // RVA: 0x7FFE86DBB060
        public void get_Price(){} // RVA: 0x7FFE8A3212D0
        public void set_Price(){} // RVA: 0x7FFE8A3212E0
        public void get_VrcPlusDiscountPrice(){} // RVA: 0x7FFE88023350
        public void set_VrcPlusDiscountPrice(){} // RVA: 0x7FFE88023360
        public void get_AvailableToPurchaseUntilDate(){} // RVA: 0x7FFE815BB6A0
        public void set_AvailableToPurchaseUntilDate(){} // RVA: 0x7FFE8A3212F0
        public void get_CollaboratorUserId(){} // RVA: 0x7FFE815BB1F0
        public void set_CollaboratorUserId(){} // RVA: 0x7FFE81B10700
        public void get_CollaboratorUserDisplayName(){} // RVA: 0x7FFE81B38340
        public void set_CollaboratorUserDisplayName(){} // RVA: 0x7FFE81B31180
        public void get_Stock(){} // RVA: 0x7FFE81B295E0
        public void set_Stock(){} // RVA: 0x7FFE870119F0
        public void get_StoreIDs(){} // RVA: 0x7FFE81825EC0
        public void set_StoreIDs(){} // RVA: 0x7FFE81B2A360
        public void get_Duration(){} // RVA: 0x7FFE879EE3D0
        public void set_Duration(){} // RVA: 0x7FFE879EE3E0
        public void get_DurationType(){} // RVA: 0x7FFE816244E0
        public void set_DurationType(){} // RVA: 0x7FFE816235B0
        public void get_Archived(){} // RVA: 0x7FFE8A321300
        public void set_Archived(){} // RVA: 0x7FFE8A321310
        public void get_Permanent(){} // RVA: 0x7FFE8A321320
        public void set_Permanent(){} // RVA: 0x7FFE8A321330
        public void get_Instant(){} // RVA: 0x7FFE8A321340
        public void set_Instant(){} // RVA: 0x7FFE8A321350
        public void get_Stackable(){} // RVA: 0x7FFE8A321360
        public void set_Stackable(){} // RVA: 0x7FFE8A321370
        public void get_Recurrable(){} // RVA: 0x7FFE8A321380
        public void set_Recurrable(){} // RVA: 0x7FFE8A321390
        public void get_Refundable(){} // RVA: 0x7FFE8A3213A0
        public void set_Refundable(){} // RVA: 0x7FFE8A3213B0
        public void get_BuyerRefundable(){} // RVA: 0x7FFE8A3213C0
        public void set_BuyerRefundable(){} // RVA: 0x7FFE8A3213D0
        public void get_ContextPreventsPurchase(){} // RVA: 0x7FFE8A3213E0
        public void set_ContextPreventsPurchase(){} // RVA: 0x7FFE8A3213F0
        public void get_ListingVariants(){} // RVA: 0x7FFE8182AF50
        public void set_ListingVariants(){} // RVA: 0x7FFE81B08F90
        public void Purchase(){} // RVA: 0x7FFE8A321400
        public void ReadField(){} // RVA: 0x7FFE8A322600
        public void WriteField(){} // RVA: 0x7FFE8A322A20
        public void FetchListing(){} // RVA: 0x7FFE8A322EC0
        public void FetchFullListing(){} // RVA: 0x7FFE8A3233D0
        public void FetchOwnListings(){} // RVA: 0x7FFE8A3238E0
        public void FetchOwnProducts(){} // RVA: 0x7FFE8A323DB0
    }

    public class ApiProductAttribution : ApiModel
    {
        public VRC.Core.ApiProductCreator _creator; // 0x68
        public VRC.Core.ApiProductPublisher _publisher; // 0x70
        public string _collaborationId; // 0x78

        // ── Methods ──
        public void get_creator(){} // RVA: 0x7FFE81176D50
        public void set_creator(){} // RVA: 0x7FFE81176D60
        public void get_publisher(){} // RVA: 0x7FFE811C3590
        public void set_publisher(){} // RVA: 0x7FFE811C35A0
        public void get_collaborationId(){} // RVA: 0x7FFE81463AE0
        public void set_collaborationId(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE8A381980
    }

    public class ApiProductCreator : ApiModel
    {
        public string _userId; // 0x68
        public string _customName; // 0x70

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFE81176D50
        public void set_userId(){} // RVA: 0x7FFE81176D60
        public void get_customName(){} // RVA: 0x7FFE811C3590
        public void set_customName(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A3819D0
    }

    public class ApiProductPublisher : ApiModel
    {
        public string _userId; // 0x68
        public string _customName; // 0x70

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFE81176D50
        public void set_userId(){} // RVA: 0x7FFE81176D60
        public void get_customName(){} // RVA: 0x7FFE811C3590
        public void set_customName(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A381A20
    }

    public class ApiProductPurchaseStatus : ApiModel
    {
        public string _productId; // 0x68
        public string _licenseId; // 0x70
        public System.DateTime _expiry; // 0x78

        // ── Methods ──
        public void get_ProductId(){} // RVA: 0x7FFE81176D50
        public void set_ProductId(){} // RVA: 0x7FFE81176D60
        public void get_LicenseId(){} // RVA: 0x7FFE811C3590
        public void set_LicenseId(){} // RVA: 0x7FFE811C35A0
        public void get_Expiry(){} // RVA: 0x7FFE81463AE0
        public void set_Expiry(){} // RVA: 0x7FFE865EFE40
        public void GetProductsPurchaseStatus(){} // RVA: 0x7FFE8A3250B0
        public void .ctor(){} // RVA: 0x7FFE8A325680
    }

    public class ApiProductVariant : ApiModel
    {
        public string _listingVariantID; // 0x68
        public int _quantity; // 0x70
        public int _unitPriceTokens; // 0x74
        public bool _nonRefundable; // 0x78
        public System.DateTime _effectiveFrom; // 0x80

        // ── Methods ──
        public void get_ListingVariantID(){} // RVA: 0x7FFE81176D50
        public void set_ListingVariantID(){} // RVA: 0x7FFE81176D60
        public void get_Quantity(){} // RVA: 0x7FFE81E60180
        public void set_Quantity(){} // RVA: 0x7FFE81293CF0
        public void get_UnitPriceTokens(){} // RVA: 0x7FFE826A9B90
        public void set_UnitPriceTokens(){} // RVA: 0x7FFE82B1F9C0
        public void get_NonRefundable(){} // RVA: 0x7FFE816400C0
        public void set_NonRefundable(){} // RVA: 0x7FFE81FE6AC0
        public void get_EffectiveFrom(){} // RVA: 0x7FFE81280C30
        public void set_EffectiveFrom(){} // RVA: 0x7FFE82C95C90
        public void .ctor(){} // RVA: 0x7FFE8A325790
    }

}