// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 100
// Methods: 1338

namespace VRC.Core
{
    public class APIActivationSuccessfulTargetResult : ApiModel
    {
        public object _userId;
        public object _gifts;
        public object _isFriend;

        // ── Methods ──
        public void get_userId(){} // RVA: 0xBBFF90
        public void set_userId(){} // RVA: 0xBBFFA0
        public void get_gifts(){} // RVA: 0x19C6270
        public void set_gifts(){} // RVA: 0xCE5450
        public void get_isFriend(){} // RVA: 0x19FAC10
        public void set_isFriend(){} // RVA: 0x64A7EE0
        public void .ctor(){} // RVA: 0xA51A200
    }

    public class APICalendarEntry : ApiModel
    {
        public object _ownerId;
        public object _accessType;
        public object _startsAt;
        public object _endsAt;
        public object _title;
        public object _description;
        public object _category;
        public object _shortCode;
        public object _type;
        public object _isDraft;
        public object _imageId;
        public object _imageUrl;
        public object _roleIds;
        public object _tags;
        public object _platforms;
        public object _languages;
        public object _parentId;
        public object _hostEarlyJoinMinutes;
        public object _guestEarlyJoinMinutes;
        public object _closeInstanceAfterEndMinutes;
        public object _usesInstanceOverflow;
        public object _deletedAt;
        public object _userInterest;
        public object _featured;
        public object _interestedUserCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA5BDB70
        public void get_ownerId(){} // RVA: 0xBBFF90
        public void set_ownerId(){} // RVA: 0xBBFFA0
        public void get_accessType(){} // RVA: 0x19C6270
        public void set_accessType(){} // RVA: 0xCE5450
        public void get_startsAt(){} // RVA: 0xCD3320
        public void set_startsAt(){} // RVA: 0x6529A50
        public void get_endsAt(){} // RVA: 0xCD48B0
        public void set_endsAt(){} // RVA: 0x278E9B0
        public void get_title(){} // RVA: 0xB813B0
        public void set_title(){} // RVA: 0xD5CBB0
        public void get_description(){} // RVA: 0x1069350
        public void set_description(){} // RVA: 0xD5CC10
        public void get_category(){} // RVA: 0x106A7D0
        public void set_category(){} // RVA: 0xD5CC70
        public void get_shortCode(){} // RVA: 0x106A050
        public void set_shortCode(){} // RVA: 0xD5CCD0
        public void get_type(){} // RVA: 0x12EB090
        public void set_type(){} // RVA: 0x13B1040
        public void get_isDraft(){} // RVA: 0x2009180
        public void set_isDraft(){} // RVA: 0x20097F0
        public void get_imageId(){} // RVA: 0xBAE3B0
        public void set_imageId(){} // RVA: 0xBAE3C0
        public void get_imageUrl(){} // RVA: 0xBAE420
        public void set_imageUrl(){} // RVA: 0xBAE430
        public void get_roleIds(){} // RVA: 0xCA4D80
        public void set_roleIds(){} // RVA: 0xCA4D90
        public void get_tags(){} // RVA: 0xC68EB0
        public void set_tags(){} // RVA: 0xC68EC0
        public void get_platforms(){} // RVA: 0x135D730
        public void set_platforms(){} // RVA: 0xBC5AD0
        public void get_languages(){} // RVA: 0xBC5B30
        public void set_languages(){} // RVA: 0xBC5B40
        public void get_parentId(){} // RVA: 0xBC5BA0
        public void set_parentId(){} // RVA: 0xBC5BB0
        public void get_hostEarlyJoinMinutes(){} // RVA: 0x255B930
        public void set_hostEarlyJoinMinutes(){} // RVA: 0x6CE7A80
        public void get_guestEarlyJoinMinutes(){} // RVA: 0x1AE9B20
        public void set_guestEarlyJoinMinutes(){} // RVA: 0xA51A150
        public void get_closeInstanceAfterEndMinutes(){} // RVA: 0x7E45E60
        public void set_closeInstanceAfterEndMinutes(){} // RVA: 0x485FE90
        public void get_usesInstanceOverflow(){} // RVA: 0x255BDF0
        public void set_usesInstanceOverflow(){} // RVA: 0xA56CFA0
        public void get_deletedAt(){} // RVA: 0x10B4170
        public void set_deletedAt(){} // RVA: 0x1FDB9B0
        public void get_userInterest(){} // RVA: 0x10B9D50
        public void set_userInterest(){} // RVA: 0x15B7570
        public void get_featured(){} // RVA: 0x1184420
        public void set_featured(){} // RVA: 0x1EBEA50
        public void get_interestedUserCount(){} // RVA: 0x80F08F0
        public void set_interestedUserCount(){} // RVA: 0x7DCD9F0
        public void UpdateData(){} // RVA: 0xA5BDBC0
        public void WriteField(){} // RVA: 0xA5BE390
    }

    public class APICalendarEntryUserInterest : ApiModel
    {
        public object _isFollowing;
        public object _createdAt;
        public object _updatedAt;

        // ── Methods ──
        public void get_isFollowing(){} // RVA: 0xC10030
        public void set_isFollowing(){} // RVA: 0xC10040
        public void get_createdAt(){} // RVA: 0xC10050
        public void set_createdAt(){} // RVA: 0x278E9C0
        public void get_updatedAt(){} // RVA: 0xCD3320
        public void set_updatedAt(){} // RVA: 0x6529A50
        public void .ctor(){} // RVA: 0xA5BE820
    }

    public class APIEmoji : ApiModel
    {
        public object _fileId;
        public object _imageUrl;
        public object _animationStyle;
        public object _maskTag;
        public object _animated;
        public object _frames;
        public object _framesOverTime;
        public object _loopStyle;
        public object _assetBundleId;
        public object _premium;
        public object endpoint;
        public object LOOP_STYLE_LINEAR;
        public object LOOP_STYLE_PINGPONG;

        // ── Methods ──
        public void get_fileId(){} // RVA: 0xBBFF90
        public void set_fileId(){} // RVA: 0xBBFFA0
        public void get_imageUrl(){} // RVA: 0xC10050
        public void set_imageUrl(){} // RVA: 0xC10060
        public void get_animationStyle(){} // RVA: 0xCD3320
        public void set_animationStyle(){} // RVA: 0xCD4740
        public void get_maskTag(){} // RVA: 0xCD48B0
        public void set_maskTag(){} // RVA: 0xCD3600
        public void get_animated(){} // RVA: 0x1C556E0
        public void set_animated(){} // RVA: 0x19CAF90
        public void get_frames(){} // RVA: 0x40A8A30
        public void set_frames(){} // RVA: 0x46CB6C0
        public void get_framesOverTime(){} // RVA: 0xF3A950
        public void set_framesOverTime(){} // RVA: 0x17AFA20
        public void get_loopStyle(){} // RVA: 0x106A7D0
        public void set_loopStyle(){} // RVA: 0xD5CC70
        public void get_assetBundleId(){} // RVA: 0x106A050
        public void set_assetBundleId(){} // RVA: 0xD5CCD0
        public void get_premium(){} // RVA: 0xE3F3E0
        public void set_premium(){} // RVA: 0xE3EB10
        public void UploadEmoji(){} // RVA: 0xA5100F0
        public void Fetch(){} // RVA: 0xA510740
        public void .ctor(){} // RVA: 0xA510A70
        public void <Fetch>g__ParseData|45_0(){} // RVA: 0xA510AE0
    }

    public class APIGiftActivationResult : ApiModel
    {
        public object _dropValidationToken;
        public object _giftValidationToken;
        public object _successfulGifts;

        // ── Methods ──
        public void get_dropValidationToken(){} // RVA: 0xBBFF90
        public void set_dropValidationToken(){} // RVA: 0xBBFFA0
        public void get_giftValidationToken(){} // RVA: 0xC10050
        public void set_giftValidationToken(){} // RVA: 0xC10060
        public void get_successfulGifts(){} // RVA: 0xCD3320
        public void set_successfulGifts(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA51A1B0
    }

    public class APIGiftBundle : ApiModel
    {
        public object _steamItemId;
        public object _oculusSku;
        public object _googleProductId;
        public object _googlePlanId;
        public object _picoSku;
        public object _amount;
        public object _description;
        public object _period;
        public object _periodAmount;
        public object _tier;
        public object _bulkSize;
        public object _discountPercentage;
        public object _licenseGroups;

        // ── Methods ──
        public void get_steamItemId(){} // RVA: 0xBBFF90
        public void set_steamItemId(){} // RVA: 0xBBFFA0
        public void get_oculusSku(){} // RVA: 0xC10050
        public void set_oculusSku(){} // RVA: 0xC10060
        public void get_googleProductId(){} // RVA: 0xCD3320
        public void set_googleProductId(){} // RVA: 0xCD4740
        public void get_googlePlanId(){} // RVA: 0xCD48B0
        public void set_googlePlanId(){} // RVA: 0xCD3600
        public void get_picoSku(){} // RVA: 0xB813B0
        public void set_picoSku(){} // RVA: 0xD5CBB0
        public void get_amount(){} // RVA: 0xF3A950
        public void set_amount(){} // RVA: 0x17AFA20
        public void get_description(){} // RVA: 0x106A7D0
        public void set_description(){} // RVA: 0xD5CC70
        public void get_period(){} // RVA: 0x106A050
        public void set_period(){} // RVA: 0xD5CCD0
        public void get_periodAmount(){} // RVA: 0x158C700
        public void set_periodAmount(){} // RVA: 0x158BEC0
        public void get_tier(){} // RVA: 0x68504E0
        public void set_tier(){} // RVA: 0x6AEE270
        public void get_bulkSize(){} // RVA: 0x295D4E0
        public void set_bulkSize(){} // RVA: 0x6A92F20
        public void get_discountPercentage(){} // RVA: 0x68504F0
        public void set_discountPercentage(){} // RVA: 0x798F510
        public void get_licenseGroups(){} // RVA: 0xBAE3B0
        public void set_licenseGroups(){} // RVA: 0xBAE3C0
        public void .ctor(){} // RVA: 0xA51A100
    }

    public class APIProductGifting : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class APIProductGiftingCheck : ApiModel
    {
        public object _eligible;
        public object _reason;
        public object _eligibleProducts;
        public object _ineligibleProducts;

        // ── Methods ──
        public void get_Eligible(){} // RVA: 0xC10030
        public void set_Eligible(){} // RVA: 0xC10040
        public void get_Reason(){} // RVA: 0xC10050
        public void set_Reason(){} // RVA: 0xC10060
        public void get_EligibleProducts(){} // RVA: 0xCD3320
        public void set_EligibleProducts(){} // RVA: 0xCD4740
        public void get_IneligibleProducts(){} // RVA: 0xCD48B0
        public void set_IneligibleProducts(){} // RVA: 0xCD3600
        public void Check(){} // RVA: 0xA56B560
        public void .ctor(){} // RVA: 0xA56BB30
    }

    public class APIPurchasedGiftBundle : ApiModel
    {
        public object _transactionId;
        public object _store;
        public object _steamItemId;
        public object _oculusSku;
        public object _googleProductId;
        public object _googlePlanId;
        public object _picoSku;
        public object _amount;
        public object _description;
        public object _period;
        public object _consumed;
        public object _status;
        public object _created_at;
        public object _updated_at;
        public object _isBulkGift;
        public object _targets;
        public object _bulkSize;
        public object _discountPercentage;
        public object _totalConsumed;
        public object _totalUnconsumed;
        public object _failures;

        // ── Methods ──
        public void get_transactionId(){} // RVA: 0xBBFF90
        public void set_transactionId(){} // RVA: 0xBBFFA0
        public void get_store(){} // RVA: 0xC10050
        public void set_store(){} // RVA: 0xC10060
        public void get_steamItemId(){} // RVA: 0xCD3320
        public void set_steamItemId(){} // RVA: 0xCD4740
        public void get_oculusSku(){} // RVA: 0xCD48B0
        public void set_oculusSku(){} // RVA: 0xCD3600
        public void get_googleProductId(){} // RVA: 0xB813B0
        public void set_googleProductId(){} // RVA: 0xD5CBB0
        public void get_googlePlanId(){} // RVA: 0x1069350
        public void set_googlePlanId(){} // RVA: 0xD5CC10
        public void get_picoSku(){} // RVA: 0x106A7D0
        public void set_picoSku(){} // RVA: 0xD5CC70
        public void get_amount(){} // RVA: 0x262A8F0
        public void set_amount(){} // RVA: 0x262A940
        public void get_description(){} // RVA: 0x12EB090
        public void set_description(){} // RVA: 0x13B1040
        public void get_period(){} // RVA: 0xBAE340
        public void set_period(){} // RVA: 0xBAE350
        public void get_consumed(){} // RVA: 0x20119F0
        public void set_consumed(){} // RVA: 0x2013510
        public void get_status(){} // RVA: 0xBAE420
        public void set_status(){} // RVA: 0xBAE430
        public void get_created_at(){} // RVA: 0xCA4D80
        public void set_created_at(){} // RVA: 0xCA4D90
        public void get_updated_at(){} // RVA: 0xC68EB0
        public void set_updated_at(){} // RVA: 0xC68EC0
        public void get_isBulkGift(){} // RVA: 0x11629E0
        public void set_isBulkGift(){} // RVA: 0x1AE6E90
        public void get_targets(){} // RVA: 0xBC5B30
        public void set_targets(){} // RVA: 0xBC5B40
        public void get_bulkSize(){} // RVA: 0x485FD30
        public void set_bulkSize(){} // RVA: 0x485FD40
        public void get_discountPercentage(){} // RVA: 0x255B920
        public void set_discountPercentage(){} // RVA: 0x6CE7A70
        public void get_totalConsumed(){} // RVA: 0x255B930
        public void set_totalConsumed(){} // RVA: 0x6CE7A80
        public void get_totalUnconsumed(){} // RVA: 0x1AE9B20
        public void set_totalUnconsumed(){} // RVA: 0xA51A150
        public void get_failures(){} // RVA: 0x7E45E60
        public void set_failures(){} // RVA: 0x485FE90
        public void .ctor(){} // RVA: 0xA51A160
    }

    public class APIResponseHandler : Object
    {
        public object _connectionTimedOutProfilerMarker;
        public object _responseTimedOutProfilerMarker;
        public object _abortedProfilerMarker;
        public object _errorProfilerMarker;
        public object _offMainResponseSemaphore;

        // ── Methods ──
        public void HandleResponse(){} // RVA: 0xA574F50
        public void extractResponseErrorMessage(){} // RVA: 0xA575180
        public void RetryRequest(){} // RVA: 0xA5752F0
        public void .cctor(){} // RVA: 0xA575A50
    }

    public class APISticker : ApiModel
    {
        public object _fileId;
        public object _imageUrl;
        public object _specialEffect;
        public object _animationStyle;
        public object _maskTag;
        public object _animated;
        public object _frames;
        public object _framesOverTime;
        public object _loopStyle;
        public object _assetBundleId;
        public object endpoint;

        // ── Methods ──
        public void get_fileId(){} // RVA: 0xBBFF90
        public void set_fileId(){} // RVA: 0xBBFFA0
        public void get_imageUrl(){} // RVA: 0xC10050
        public void set_imageUrl(){} // RVA: 0xC10060
        public void get_specialEffect(){} // RVA: 0xCD3320
        public void set_specialEffect(){} // RVA: 0xCD4740
        public void get_animationStyle(){} // RVA: 0xCD48B0
        public void set_animationStyle(){} // RVA: 0xCD3600
        public void get_maskTag(){} // RVA: 0xB813B0
        public void set_maskTag(){} // RVA: 0xD5CBB0
        public void get_animated(){} // RVA: 0x1C4D9A0
        public void set_animated(){} // RVA: 0x1C4DB10
        public void get_frames(){} // RVA: 0xF3A940
        public void set_frames(){} // RVA: 0x11A0AB0
        public void get_framesOverTime(){} // RVA: 0x262A930
        public void set_framesOverTime(){} // RVA: 0x262A900
        public void get_loopStyle(){} // RVA: 0x106A050
        public void set_loopStyle(){} // RVA: 0xD5CCD0
        public void get_assetBundleId(){} // RVA: 0x12EB090
        public void set_assetBundleId(){} // RVA: 0x13B1040
        public void UploadSticker(){} // RVA: 0xA5796D0
        public void .ctor(){} // RVA: 0xA579CD0
    }

    public class APISubscription : ApiModel
    {
        public object _response;

        // ── Methods ──
        public void get_response(){} // RVA: 0xBBFF90
        public void set_response(){} // RVA: 0xBBFFA0
        public void .ctor(){} // RVA: 0xA579E80
    }

    public class APITutorial : ApiModel
    {
        public object VRCHAT_GET_TUTORIAL_ENDPOINT;
        public object _isTutorialCompleted;
        public object _completedAnyTutorial;
        public object _tutorialKey;

        // ── Methods ──
        public void get_IsTutorialCompleted(){} // RVA: 0xC10030
        public void set_IsTutorialCompleted(){} // RVA: 0xC10040
        public void get_CompletedAnyTutorial(){} // RVA: 0x6296240
        public void set_CompletedAnyTutorial(){} // RVA: 0x6296250
        public void get_TutorialKey(){} // RVA: 0xC10050
        public void set_TutorialKey(){} // RVA: 0xC10060
        public void LoadTutorial(){} // RVA: 0xA57C860
        public void .ctor(){} // RVA: 0xA57CB70
    }

    public class ApiAvatarPart : ApiContentModel`1
    {
        public object __created_at;
        public object __updated_at;
        public object _unityPackages;
        public object AvatarPartEndpoint;
        public object _bundleSignature;

        // ── Methods ──
        public void get__created_at(){} // RVA: 0x135D730
        public void set__created_at(){} // RVA: 0x485FCF0
        public void get__updated_at(){} // RVA: 0xBC5B30
        public void set__updated_at(){} // RVA: 0x485FD20
        public void get_unityPackages(){} // RVA: 0xBC5BA0
        public void set_unityPackages(){} // RVA: 0xBC5BB0
        public void get_BundleSignature(){} // RVA: 0xBAE5A0
        public void set_BundleSignature(){} // RVA: 0xBAE5B0
        public void .ctor(){} // RVA: 0xA509F70
        public void SetApiFieldsFromJson(){} // RVA: 0xA50A0D0
        public void ProcessUnityPackages(){} // RVA: 0xA50A1B0
        public void WriteField(){} // RVA: 0xA50AA60
        public void CopyDeserializedValuesTo(){} // RVA: 0xA50AB20
        public void GetAccessory(){} // RVA: 0xA50AD20
        public void FetchList(){} // RVA: 0xA50AEC0
    }

    public class ApiAvatarPartItemMetadata : ApiModel
    {
        public object _avatarPartId;

        // ── Methods ──
        public void get_avatarPartId(){} // RVA: 0xBBFF90
        public void set_avatarPartId(){} // RVA: 0xBBFFA0
        public void .ctor(){} // RVA: 0xA50B9D0
    }

    public class ApiAvatarStyle : ApiModel
    {
        public object _styleName;
        public object _lastModifiedById;
        public object _lastModifiedByDisplayName;
        public object _created_at;
        public object _updated_at;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA50BA20
        public void get_styleName(){} // RVA: 0xBBFF90
        public void set_styleName(){} // RVA: 0xBBFFA0
        public void get_lastModifiedById(){} // RVA: 0xC10050
        public void set_lastModifiedById(){} // RVA: 0xC10060
        public void get_lastModifiedByDisplayName(){} // RVA: 0xCD3320
        public void set_lastModifiedByDisplayName(){} // RVA: 0xCD4740
        public void get_created_at(){} // RVA: 0xCD48B0
        public void set_created_at(){} // RVA: 0x278E9B0
        public void get_updated_at(){} // RVA: 0xB813B0
        public void set_updated_at(){} // RVA: 0x13AA640
    }

    public class ApiBindingCommandReference : ApiModel
    {
        public object _command;
        public object _parameters;
        public object _name;

        // ── Methods ──
        public void get_command(){} // RVA: 0xBBFF90
        public void set_command(){} // RVA: 0xBBFFA0
        public void get_parameters(){} // RVA: 0xC10050
        public void set_parameters(){} // RVA: 0xC10060
        public void get_name(){} // RVA: 0xCD3320
        public void set_name(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA50BB30
        public void ToString(){} // RVA: 0xA50BBD0
    }

    public class ApiByteContainer : ApiContainer
    {
        // ── Methods ──
        public void get_ResponseBytes(){} // RVA: 0xA574270
        public void Validate(){} // RVA: 0xA5742E0
        public void .ctor(){} // RVA: 0xA573C70
    }

    public class ApiCalendarEntriesContainer : ApiModel
    {
        public object _hasNext;
        public object _results;
        public object _totalCount;
        public object _nextCursor;

        // ── Methods ──
        public void get_hasNext(){} // RVA: 0xC10030
        public void set_hasNext(){} // RVA: 0xC10040
        public void get_results(){} // RVA: 0xC10050
        public void set_results(){} // RVA: 0xC10060
        public void get_totalCount(){} // RVA: 0x23ADD10
        public void set_totalCount(){} // RVA: 0x23B2A80
        public void get_nextCursor(){} // RVA: 0xCD48B0
        public void set_nextCursor(){} // RVA: 0xCD3600
        public void .ctor(){} // RVA: 0xA5BE7D0
    }

    public class ApiCalendarResults : ApiModel
    {
        public object _results;
        public object _totalCount;

        // ── Methods ──
        public void get_results(){} // RVA: 0xBBFF90
        public void set_results(){} // RVA: 0xBBFFA0
        public void get_totalCount(){} // RVA: 0x19C6270
        public void set_totalCount(){} // RVA: 0xCE5450
        public void .ctor(){} // RVA: 0xA5791A0
    }

    public class ApiCampaign : ApiModel
    {
        public object _participantCount;
        public object _friendsContributing;
        public object _endsAt;
        public object _raisedAmountUsd;
        public object _userGiftCount;
        public object _giftGoalUsd;
        public object _goalSuccess;
        public object _rewards;

        // ── Methods ──
        public void get_participantCount(){} // RVA: 0x2536460
        public void set_participantCount(){} // RVA: 0x25406E0
        public void get_friendsContributing(){} // RVA: 0xC10050
        public void set_friendsContributing(){} // RVA: 0xC10060
        public void get_endsAt(){} // RVA: 0xCD3320
        public void set_endsAt(){} // RVA: 0x6529A50
        public void get_raisedAmountUsd(){} // RVA: 0xD34760
        public void set_raisedAmountUsd(){} // RVA: 0xD34750
        public void get_userGiftCount(){} // RVA: 0xD34730
        public void set_userGiftCount(){} // RVA: 0xD34790
        public void get_giftGoalUsd(){} // RVA: 0x14780B0
        public void set_giftGoalUsd(){} // RVA: 0x147EE80
        public void get_goalSuccess(){} // RVA: 0xBAB4F0
        public void set_goalSuccess(){} // RVA: 0xBAB500
        public void get_rewards(){} // RVA: 0x1069350
        public void set_rewards(){} // RVA: 0xD5CC10
        public void GetCampaignAsync(){} // RVA: 0xA50DA30
        public void .ctor(){} // RVA: 0xA50DBD0
    }

    public class ApiCampaignReward : ApiModel
    {
        public object _title;
        public object _description;
        public object _imageUrl;
        public object _unlocked;
        public object _progress;

        // ── Methods ──
        public void get_title(){} // RVA: 0xBBFF90
        public void set_title(){} // RVA: 0xBBFFA0
        public void get_description(){} // RVA: 0xC10050
        public void set_description(){} // RVA: 0xC10060
        public void get_imageUrl(){} // RVA: 0xCD3320
        public void set_imageUrl(){} // RVA: 0xCD4740
        public void get_unlocked(){} // RVA: 0xE3F400
        public void set_unlocked(){} // RVA: 0xE3CFC0
        public void get_progress(){} // RVA: 0xB813B0
        public void set_progress(){} // RVA: 0xD5CBB0
        public void .ctor(){} // RVA: 0xA50E450
    }

    public class ApiCampaignRewardProgress : ApiModel
    {
        public object _current;
        public object _max;

        // ── Methods ──
        public void get_current(){} // RVA: 0x2536460
        public void set_current(){} // RVA: 0x25406E0
        public void get_max(){} // RVA: 0x25406F0
        public void set_max(){} // RVA: 0x2540700
        public void .ctor(){} // RVA: 0xA50E4A0
    }

    public class ApiContainer : Object
    {
        public object _cookies;
        public object _populated;
        public object _passedValidation;
        public object _code;
        public object _text;
        public object _data;
        public object _dataTimestamp;
        public object _createdAt;
        public object responseError;
        public object _model;
        public object OnError;
        public object OnSuccess;

        // ── Methods ──
        public void get_Cookies(){} // RVA: 0xB5DBF0
        public void set_Cookies(){} // RVA: 0xB44D60
        public void get_Populated(){} // RVA: 0xB5DD50
        public void set_Populated(){} // RVA: 0xB5DD60
        public void get_PassedValidation(){} // RVA: 0xF43F30
        public void set_PassedValidation(){} // RVA: 0x17F4D80
        public void get_Code(){} // RVA: 0x2244FB0
        public void set_Code(){} // RVA: 0x22735B0
        public void get_Text(){} // RVA: 0xB700F0
        public void set_Text(){} // RVA: 0xB70100
        public void get_Data(){} // RVA: 0xB70160
        public void set_Data(){} // RVA: 0xB44DC0
        public void get_DataTimestamp(){} // RVA: 0xCD64A0
        public void set_DataTimestamp(){} // RVA: 0xD96F20
        public void get_CreatedAt(){} // RVA: 0xD05CA0
        public void set_CreatedAt(){} // RVA: 0xD09D70
        public void get_Error(){} // RVA: 0xA574430
        public void set_Error(){} // RVA: 0xA574460
        public void get_Model(){} // RVA: 0xBBF8F0
        public void set_Model(){} // RVA: 0xBBF900
        public void .ctor(){} // RVA: 0xA5747C0
        public void setFromContainer(){} // RVA: 0xA574890
        public void Validate(){} // RVA: 0xA574AA0
        public void GetErrorMessage(){} // RVA: 0xA574AF0
        public void OnComplete(){} // RVA: 0xA574C90
    }

    public class ApiContentModel`1 : ApiModel
    {
        public object _VERSION;
        public object MIN_LOADABLE_VERSION;
        public object ListCacheTime;
        public object SingleRecordCacheTime;
        public object localContent;
        public object _name;
        public object _imageUrl;
        public object _authorName;
        public object _authorId;
        public object _assetUrl;
        public object _description;
        public object _tags;
        public object _thumbnailImageUrl;
        public object _version;
        public object _releaseStatus;
        public object _featured;
        public object _unityPackageUpdated;
        public object _unityVersion;
        public object _apiVersion;
        public object _platform;

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x4219EB0
        public void ShouldCache(){} // RVA: 0x421A1C0
        public void GetLifeSpan(){} // RVA: 0x421A220
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_imageUrl(){} // RVA: 0xC10050
        public void set_imageUrl(){} // RVA: 0xC10060
        public void get_authorName(){} // RVA: 0xCD3320
        public void set_authorName(){} // RVA: 0xCD4740
        public void get_authorId(){} // RVA: 0xCD48B0
        public void set_authorId(){} // RVA: 0xCD3600
        public void get_assetUrl(){} // RVA: 0xB813B0
        public void set_assetUrl(){} // RVA: 0xD5CBB0
        public void get_description(){} // RVA: 0x1069350
        public void set_description(){} // RVA: 0xD5CC10
        public void get_tags(){} // RVA: 0x106A7D0
        public void set_tags(){} // RVA: 0xD5CC70
        public void get_thumbnailImageUrl(){} // RVA: 0x106A050
        public void set_thumbnailImageUrl(){} // RVA: 0xD5CCD0
        public void get_version(){} // RVA: 0x158C700
        public void set_version(){} // RVA: 0x158BEC0
        public void get_releaseStatus(){} // RVA: 0xBAE340
        public void set_releaseStatus(){} // RVA: 0xBAE350
        public void get_featured(){} // RVA: 0x20119F0
        public void set_featured(){} // RVA: 0x2013510
        public void get_unityPackageUpdated(){} // RVA: 0x2558540
        public void set_unityPackageUpdated(){} // RVA: 0x421A230
        public void get_unityVersion(){} // RVA: 0xBAE420
        public void set_unityVersion(){} // RVA: 0xBAE430
        public void get_apiVersion(){} // RVA: 0x12CE7D0
        public void set_apiVersion(){} // RVA: 0x421A240
        public void get_platform(){} // RVA: 0xC68EB0
        public void set_platform(){} // RVA: 0xC68EC0
        public void get_assetVersion(){} // RVA: 0x421A250
        public void set_assetVersion(){} // RVA: 0x421A300
        public void .ctor(){} // RVA: 0x421A390
        public void ReadField(){} // RVA: 0x421A460
        public void Get(){} // RVA: 0x421A630
        public void FetchList(){} // RVA: 0x421AD70
        public void AddLocal(){} // RVA: 0x421CA70
        public void IsLocalById(){} // RVA: 0x421CBA0
        public void get_IsLocal(){} // RVA: 0x421CCA0
        public void Save(){} // RVA: 0x421CD80
        public void SaveReleaseStatus(){} // RVA: 0x421CE00
        public void GetAssetUrl(){} // RVA: 0xB813B0
        public void HasTag(){} // RVA: 0x421D340
        public void AddTag(){} // RVA: 0x421D3B0
        public void RemoveTag(){} // RVA: 0x421D450
        public void UpdateVersionAndPlatform(){} // RVA: 0x421D5B0
        public void MakeRequestEndpoint(){} // RVA: 0x421D740
        public void .cctor(){} // RVA: 0x421D770
    }

    public class ApiCredentials : Object
    {
        public object SECURE_PLAYER_PREFS_PW;
        public object authToken;
        public object authTokenCookie;
        public object twoFactorAuthToken;
        public object twoFactorAuthTokenCookie;
        public object provider;
        public object providerUserId;
        public object humanName;
        public object index;

        // ── Methods ──
        public void Clear(){} // RVA: 0xA5BE870
        public void SetProfileIndex(){} // RVA: 0xA5BE8A0
        public void SetString(){} // RVA: 0xA5BE920
        public void GetString(){} // RVA: 0xA5BEB70
        public void Load(){} // RVA: 0xA5BED60
        public void SetHumanName(){} // RVA: 0xA5BF490
        public void Set(){} // RVA: 0xA5BF5A0
        public void Set2faToken(){} // RVA: 0xA5BFB70
        public void GetHumanName(){} // RVA: 0xA5BFD50
        public void GetAuthToken(){} // RVA: 0xA5BFD90
        public void GetTwoFactorAuthToken(){} // RVA: 0xA5BFDD0
        public void GetAuthTokenCookie(){} // RVA: 0xA5BFE10
        public void GetTwoFactorAuthTokenCookie(){} // RVA: 0xA5BFE50
        public void GetAuthTokenProvider(){} // RVA: 0xA5BFE90
        public void GetAuthTokenProviderUserId(){} // RVA: 0xA5BFED0
        public void IsLoaded(){} // RVA: 0xA5BFF10
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ApiDictContainer : ApiContainer
    {
        public object _cacheLifetime;
        public object _expiryTime;
        public object _requiredFields;
        public object EmptyDictionary;

        // ── Methods ──
        public void get_cacheLifetime(){} // RVA: 0xC5C4A0
        public void set_cacheLifetime(){} // RVA: 0x18AD0F0
        public void get_ExpiryTime(){} // RVA: 0x4127AD0
        public void set_ExpiryTime(){} // RVA: 0x4127F60
        public void get_requiredFields(){} // RVA: 0xCD3320
        public void set_requiredFields(){} // RVA: 0xCD4740
        public void get_ResponseDictionary(){} // RVA: 0xA573190
        public void .ctor(){} // RVA: 0xA573330
        public void Validate(){} // RVA: 0xA5733A0
        public void ShouldCache(){} // RVA: 0xA5736B0
        public void ShouldClearOnLevelLoad(){} // RVA: 0xB43320
        public void GetLifeSpan(){} // RVA: 0xC5C4A0
        public void Clone(){} // RVA: 0xA5736C0
        public void .cctor(){} // RVA: 0xA573740
        public void <Validate>b__17_0(){} // RVA: 0xA573810
    }

    public class ApiEconomyAccountStatus : ApiModel
    {
        public object _userID;
        public object _blocked;

        // ── Methods ──
        public void get_UserID(){} // RVA: 0xBBFF90
        public void set_UserID(){} // RVA: 0xBBFFA0
        public void get_Blocked(){} // RVA: 0xBC03E0
        public void set_Blocked(){} // RVA: 0xBC03F0
        public void .ctor(){} // RVA: 0xA5BFF60
    }

    public class ApiEconomyStore : ApiModel
    {
        public object _sellerId;
        public object _sellerDisplayName;
        public object _worldId;
        public object _groupId;
        public object _storeStatus;
        public object _displayName;
        public object _description;
        public object _tags;
        public object _listings;
        public object _listingIDs;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA50EFA0
        public void get_SellerId(){} // RVA: 0xBBFF90
        public void set_SellerId(){} // RVA: 0xBBFFA0
        public void get_SellerDisplayName(){} // RVA: 0xC10050
        public void set_SellerDisplayName(){} // RVA: 0xC10060
        public void get_WorldId(){} // RVA: 0xCD3320
        public void set_WorldId(){} // RVA: 0xCD4740
        public void get_GroupId(){} // RVA: 0xCD48B0
        public void set_GroupId(){} // RVA: 0xCD3600
        public void get_StoreStatus(){} // RVA: 0x14780B0
        public void set_StoreStatus(){} // RVA: 0x147EE80
        public void get_DisplayName(){} // RVA: 0x1069350
        public void set_DisplayName(){} // RVA: 0xD5CC10
        public void get_Description(){} // RVA: 0x106A7D0
        public void set_Description(){} // RVA: 0xD5CC70
        public void get_Tags(){} // RVA: 0x106A050
        public void set_Tags(){} // RVA: 0xD5CCD0
        public void get_Listings(){} // RVA: 0x12EB090
        public void set_Listings(){} // RVA: 0x13B1040
        public void get_ListingIDs(){} // RVA: 0xBAE340
        public void set_ListingIDs(){} // RVA: 0xBAE350
        public void get_IsGroupStore(){} // RVA: 0xA50EFF0
        public void get_IsWorldStore(){} // RVA: 0xA50F010
        public void ReadField(){} // RVA: 0xA50F030
        public void WriteField(){} // RVA: 0xA50F270
        public void FetchStore(){} // RVA: 0xA50F3D0
    }

    public class ApiIconFrameMetadata : ApiProfileInventoryMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA56CEA0
    }

    public class ApiImage : ApiFile
    {
        public object MAX_IMAGES;
        public object endpoint;

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0xB43320
        public void FetchList(){} // RVA: 0xA51A2F0
        public void UploadImage(){} // RVA: 0xA51AE50
        public void .ctor(){} // RVA: 0xA51B250
    }

    public class ApiInventoryAsset : ApiModel
    {
        public object TYPE_BASE;
        public object _type;
        public object _url;
        public object _animated;
        public object _animationDuration;
        public object _animationFramesPerSecond;

        // ── Methods ──
        public void get_type(){} // RVA: 0xBBFF90
        public void set_type(){} // RVA: 0xBBFFA0
        public void get_url(){} // RVA: 0xC10050
        public void set_url(){} // RVA: 0xC10060
        public void get_animated(){} // RVA: 0x1165710
        public void set_animated(){} // RVA: 0x1F749D0
        public void get_animationDuration(){} // RVA: 0xB6B280
        public void set_animationDuration(){} // RVA: 0xB6B290
        public void get_animationFramesPerSecond(){} // RVA: 0xB6B2A0
        public void set_animationFramesPerSecond(){} // RVA: 0xB6B2B0
        public void .ctor(){} // RVA: 0xA51C640
    }

    public class ApiInventoryBundle : ApiModel
    {
        public object _inventoryItemsToInstantiate;
        public object _notificationDetails;

        // ── Methods ──
        public void get_inventoryItemsToInstantiate(){} // RVA: 0xBBFF90
        public void set_inventoryItemsToInstantiate(){} // RVA: 0xBBFFA0
        public void get_notificationDetails(){} // RVA: 0xC10050
        public void set_notificationDetails(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA51C690
    }

    public class ApiInventoryBundleDrop : ApiModel
    {
        public object ENDPOINT;
        public object _name;
        public object _authorId;
        public object _targetGroup;
        public object _templateIds;
        public object _startDropDate;
        public object _endDropDate;
        public object _dropExpiryDate;
        public object _status;
        public object _tags;
        public object _created_at;
        public object _updated_at;
        public object _notificationDetails;

        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_authorId(){} // RVA: 0xC10050
        public void set_authorId(){} // RVA: 0xC10060
        public void get_targetGroup(){} // RVA: 0xCD3320
        public void set_targetGroup(){} // RVA: 0xCD4740
        public void get_templateIds(){} // RVA: 0xCD48B0
        public void set_templateIds(){} // RVA: 0xCD3600
        public void get_startDropDate(){} // RVA: 0xB813B0
        public void set_startDropDate(){} // RVA: 0x13AA640
        public void get_endDropDate(){} // RVA: 0x1069350
        public void set_endDropDate(){} // RVA: 0x25687F0
        public void get_dropExpiryDate(){} // RVA: 0x106A7D0
        public void set_dropExpiryDate(){} // RVA: 0x6A6A800
        public void get_status(){} // RVA: 0x106A050
        public void set_status(){} // RVA: 0xD5CCD0
        public void get_tags(){} // RVA: 0x12EB090
        public void set_tags(){} // RVA: 0x13B1040
        public void get_created_at(){} // RVA: 0xBAE340
        public void set_created_at(){} // RVA: 0x2443FC0
        public void get_updated_at(){} // RVA: 0xBAE3B0
        public void set_updated_at(){} // RVA: 0x2443D90
        public void get_notificationDetails(){} // RVA: 0xBAE420
        public void set_notificationDetails(){} // RVA: 0xBAE430
        public void FetchCurrentlyActiveBundleDrops(){} // RVA: 0xA51C6E0
        public void .ctor(){} // RVA: 0xA51CB30
    }

    public class ApiInventoryItemContainer : ApiModel
    {
        public object _data;
        public object _totalCount;

        // ── Methods ──
        public void get_data(){} // RVA: 0xBBFF90
        public void set_data(){} // RVA: 0xBBFFA0
        public void get_totalCount(){} // RVA: 0x19C6270
        public void set_totalCount(){} // RVA: 0xCE5450
        public void .ctor(){} // RVA: 0xA523F30
    }

    public class ApiJweToken : ApiModel
    {
        public object _token;
        public object _version;

        // ── Methods ──
        public void get_token(){} // RVA: 0xBBFF90
        public void set_token(){} // RVA: 0xBBFFA0
        public void get_version(){} // RVA: 0x19C6270
        public void set_version(){} // RVA: 0xCE5450
        public void .ctor(){} // RVA: 0xA5257B0
    }

    public class ApiLeaderboard : ApiModel
    {
        public object _userStats;
        public object _leaderboard;

        // ── Methods ──
        public void get_userStats(){} // RVA: 0xBBFF90
        public void set_userStats(){} // RVA: 0xBBFFA0
        public void get_leaderboard(){} // RVA: 0xC10050
        public void set_leaderboard(){} // RVA: 0xC10060
        public void GetCurrentLeaderboardAsync(){} // RVA: 0xA525800
        public void GetPreviousLeaderboardAsync(){} // RVA: 0xA525930
        public void GetAnonymizationStateAsync(){} // RVA: 0xA525A60
        public void SetAnonymizationStateAsync(){} // RVA: 0xA525B90
        public void .ctor(){} // RVA: 0xA525CE0
    }

    public class ApiLeaderboardAnonymizationStatus : ApiModel
    {
        public object _state;
        public object _displayName;

        // ── Methods ──
        public void get_state(){} // RVA: 0xC10030
        public void set_state(){} // RVA: 0xC10040
        public void get_displayName(){} // RVA: 0xC10050
        public void set_displayName(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA527F80
    }

    public class ApiLeaderboardData : ApiModel
    {
        public object _startedAt;
        public object _endsAt;
        public object _ranks;

        // ── Methods ──
        public void get_startedAt(){} // RVA: 0xBBFF90
        public void set_startedAt(){} // RVA: 0x278E9A0
        public void get_endsAt(){} // RVA: 0xC10050
        public void set_endsAt(){} // RVA: 0x278E9C0
        public void get_ranks(){} // RVA: 0xCD3320
        public void set_ranks(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA527EE0
    }

    public class ApiLeaderboardRank : ApiModel
    {
        public object _displayName;
        public object _iconUrl;
        public object _gifts;
        public object _isAnonymized;
        public object _isSelf;

        // ── Methods ──
        public void get_displayName(){} // RVA: 0xBBFF90
        public void set_displayName(){} // RVA: 0xBBFFA0
        public void get_iconUrl(){} // RVA: 0xC10050
        public void set_iconUrl(){} // RVA: 0xC10060
        public void get_gifts(){} // RVA: 0x23ADD10
        public void set_gifts(){} // RVA: 0x23B2A80
        public void get_isAnonymized(){} // RVA: 0x1163160
        public void set_isAnonymized(){} // RVA: 0x1164780
        public void get_isSelf(){} // RVA: 0x115E290
        public void set_isSelf(){} // RVA: 0x1161D50
        public void .ctor(){} // RVA: 0xA527F30
    }

    public class ApiLeaderboardUserStats : ApiModel
    {
        public object _rank;
        public object _gifts;
        public object _isAnonymized;
        public object _anonymizedDisplayName;

        // ── Methods ──
        public void get_rank(){} // RVA: 0x2536460
        public void set_rank(){} // RVA: 0x25406E0
        public void get_gifts(){} // RVA: 0x25406F0
        public void set_gifts(){} // RVA: 0x2540700
        public void get_isAnonymized(){} // RVA: 0xBC03E0
        public void set_isAnonymized(){} // RVA: 0xBC03F0
        public void get_anonymizedDisplayName(){} // RVA: 0xCD3320
        public void set_anonymizedDisplayName(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA527E90
    }

    public class ApiLedgerTransaction : ApiModel
    {
        public object _amount;
        public object _runningBalance;
        public object _date;
        public object _listingDisplayName;
        public object _listingID;
        public object _listingType;
        public object _platform;
        public object _purchaseId;
        public object _reason;
        public object _reasonLabel;
        public object _toUserId;
        public object _toUserDisplayName;
        public object _fromUserId;
        public object _fromUserDisplayName;
        public object _transactionId;
        public object _transactionLineId;

        // ── Methods ──
        public void get_Amount(){} // RVA: 0x2536460
        public void set_Amount(){} // RVA: 0x25406E0
        public void get_RunningBalance(){} // RVA: 0x25406F0
        public void set_RunningBalance(){} // RVA: 0x2540700
        public void get_Date(){} // RVA: 0xC10050
        public void set_Date(){} // RVA: 0x278E9C0
        public void get_ListingDisplayName(){} // RVA: 0xCD3320
        public void set_ListingDisplayName(){} // RVA: 0xCD4740
        public void get_ListingID(){} // RVA: 0xCD48B0
        public void set_ListingID(){} // RVA: 0xCD3600
        public void get_ListingType(){} // RVA: 0xB813B0
        public void set_ListingType(){} // RVA: 0xD5CBB0
        public void get_Platform(){} // RVA: 0x1069350
        public void set_Platform(){} // RVA: 0xD5CC10
        public void get_PurchaseId(){} // RVA: 0x106A7D0
        public void set_PurchaseId(){} // RVA: 0xD5CC70
        public void get_Reason(){} // RVA: 0x262A8F0
        public void set_Reason(){} // RVA: 0x262A940
        public void get_ReasonLabel(){} // RVA: 0x12EB090
        public void set_ReasonLabel(){} // RVA: 0x13B1040
        public void get_ToUserId(){} // RVA: 0xBAE340
        public void set_ToUserId(){} // RVA: 0xBAE350
        public void get_ToUserDisplayName(){} // RVA: 0xBAE3B0
        public void set_ToUserDisplayName(){} // RVA: 0xBAE3C0
        public void get_FromUserId(){} // RVA: 0xBAE420
        public void set_FromUserId(){} // RVA: 0xBAE430
        public void get_FromUserDisplayName(){} // RVA: 0xCA4D80
        public void set_FromUserDisplayName(){} // RVA: 0xCA4D90
        public void get_TransactionId(){} // RVA: 0xC68EB0
        public void set_TransactionId(){} // RVA: 0x7339DC0
        public void get_TransactionLineId(){} // RVA: 0x135D730
        public void set_TransactionLineId(){} // RVA: 0x485FCF0
        public void get_id(){} // RVA: 0xA528020
        public void .ctor(){} // RVA: 0xA5280C0
    }

    public class ApiLedgerTransactions : ApiModel
    {
        public object _startDate;
        public object _endDate;
        public object _transactions;

        // ── Methods ──
        public void get_StartDate(){} // RVA: 0xBBFF90
        public void set_StartDate(){} // RVA: 0x278E9A0
        public void get_EndDate(){} // RVA: 0xC10050
        public void set_EndDate(){} // RVA: 0x278E9C0
        public void get_Transactions(){} // RVA: 0xCD3320
        public void set_Transactions(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA527FD0
    }

    public class ApiLicenseNote : ApiModel
    {
        public object _createdAt;
        public object _note;

        // ── Methods ──
        public void get_CreatedAt(){} // RVA: 0xBBFF90
        public void set_CreatedAt(){} // RVA: 0x278E9A0
        public void get_Note(){} // RVA: 0xC10050
        public void set_Note(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA529580
    }

    public class ApiListContainer : ApiContainer
    {
        public object _totalCount;

        // ── Methods ──
        public void get_ResponseList(){} // RVA: 0xA573880
        public void get_TotalCount(){} // RVA: 0xD347A0
        public void set_TotalCount(){} // RVA: 0xD34740
        public void Validate(){} // RVA: 0xA5738F0
        public void .ctor(){} // RVA: 0xA573C70
    }

    public class ApiLoadingScreen : ApiModel
    {
        public object _name;
        public object _assetBundleId;

        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_assetBundleId(){} // RVA: 0xC10050
        public void set_assetBundleId(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA5295D0
    }

    public class ApiLocalizableString : Object
    {
        public object key;
        public object fallback;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void ValidModelData(){} // RVA: 0x87D280
        public void Validate(){} // RVA: 0x87DB70
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
    }

    public class ApiModeration : ApiModel
    {
        public object ListCacheTime;
        public object _moderationType;
        public object _moderatorUserId;
        public object _moderatorDisplayName;
        public object _targetUserId;
        public object _targetDisplayName;
        public object _reasonMessage;
        public object _details;
        public object _created;
        public object _expires;
        public object expiresRange;
        public object _isPermanent;
        public object _worldId;
        public object _instanceId;

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x2536460
        public void set_moderationType(){} // RVA: 0x25406E0
        public void get_moderatorUserId(){} // RVA: 0xC10050
        public void set_moderatorUserId(){} // RVA: 0xC10060
        public void get_moderatorDisplayName(){} // RVA: 0xCD3320
        public void set_moderatorDisplayName(){} // RVA: 0xCD4740
        public void get_targetUserId(){} // RVA: 0xCD48B0
        public void set_targetUserId(){} // RVA: 0xCD3600
        public void get_targetDisplayName(){} // RVA: 0xB813B0
        public void set_targetDisplayName(){} // RVA: 0xD5CBB0
        public void get_reasonMessage(){} // RVA: 0x1069350
        public void set_reasonMessage(){} // RVA: 0xD5CC10
        public void get_details(){} // RVA: 0x106A7D0
        public void set_details(){} // RVA: 0xD5CC70
        public void get_created(){} // RVA: 0x106A050
        public void set_created(){} // RVA: 0x6A6A810
        public void get_expires(){} // RVA: 0x12EB090
        public void set_expires(){} // RVA: 0x24440F0
        public void get_isPermanent(){} // RVA: 0x20119F0
        public void set_isPermanent(){} // RVA: 0x2013510
        public void get_worldId(){} // RVA: 0xBAE420
        public void set_worldId(){} // RVA: 0xBAE430
        public void get_instanceId(){} // RVA: 0xCA4D80
        public void set_instanceId(){} // RVA: 0xCA4D90
        public void .ctor(){} // RVA: 0xA53A370
        public void ShouldCache(){} // RVA: 0xB43320
        public void ReadField(){} // RVA: 0xA53A410
        public void WriteField(){} // RVA: 0xA53A890
        public void SendModeration(){} // RVA: 0xA53AAC0
        public void SendVoteKick(){} // RVA: 0xA53AE80
        public void DeleteModeration(){} // RVA: 0xA53B1B0
        public void LocalFetchAll(){} // RVA: 0xA53B3D0
        public void ModerationTimeRangeToString(){} // RVA: 0xA53B6D0
        public void ContestModeration(){} // RVA: 0xA53B770
    }

    public class ApiModerationResult : Object
    {
        public object fields;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ApiModerationResultExtensions : Object
    {
        // ── Methods ──
        public void WasModerated(){} // RVA: 0xA564750
        public void GetModerationResult(){} // RVA: 0xA564770
    }

    public class ApiNameplateEffectMetadata : ApiProfileInventoryMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA56CEA0
    }

    public class ApiNotification : ApiModel
    {
        public object _version;
        public object _notificationType;
        public object _category;
        public object _isSystem;
        public object _senderUserId;
        public object _senderUsername;
        public object _receiverUserId;
        public object _relatedNotificationsId;
        public object _title;
        public object _titleKey;
        public object _message;
        public object _messageKey;
        public object _imageUrl;
        public object _link;
        public object _linkText;
        public object _linkTextKey;
        public object _responses;
        public object _expiresAt;
        public object _expiryAfterSeen;
        public object _seen;
        public object _ignoreDND;
        public object _canDelete;
        public object _created_at;
        public object _createdAt;
        public object _updatedAt;
        public object _details;
        public object _data;
        public object _jobName;
        public object _jobColor;

        // ── Methods ──
        public void get_version(){} // RVA: 0x2536460
        public void set_version(){} // RVA: 0x25406E0
        public void get_notificationType(){} // RVA: 0x25406F0
        public void set_notificationType(){} // RVA: 0x2540700
        public void get_category(){} // RVA: 0xC10050
        public void set_category(){} // RVA: 0xC10060
        public void get_isSystem(){} // RVA: 0x1165710
        public void set_isSystem(){} // RVA: 0x1F749D0
        public void get_senderUserId(){} // RVA: 0xCD48B0
        public void set_senderUserId(){} // RVA: 0xCD3600
        public void get_senderUsername(){} // RVA: 0xB813B0
        public void set_senderUsername(){} // RVA: 0xD5CBB0
        public void get_receiverUserId(){} // RVA: 0x1069350
        public void set_receiverUserId(){} // RVA: 0xD5CC10
        public void get_relatedNotificationsId(){} // RVA: 0x106A7D0
        public void set_relatedNotificationsId(){} // RVA: 0xD5CC70
        public void get_title(){} // RVA: 0x106A050
        public void set_title(){} // RVA: 0xD5CCD0
        public void get_titleKey(){} // RVA: 0x12EB090
        public void set_titleKey(){} // RVA: 0x13B1040
        public void get_message(){} // RVA: 0xBAE340
        public void set_message(){} // RVA: 0xBAE350
        public void get_messageKey(){} // RVA: 0xBAE3B0
        public void set_messageKey(){} // RVA: 0xBAE3C0
        public void get_imageUrl(){} // RVA: 0xBAE420
        public void set_imageUrl(){} // RVA: 0xBAE430
        public void get_link(){} // RVA: 0xCA4D80
        public void set_link(){} // RVA: 0xCA4D90
        public void get_linkText(){} // RVA: 0xC68EB0
        public void set_linkText(){} // RVA: 0xC68EC0
        public void get_linkTextKey(){} // RVA: 0x135D730
        public void set_linkTextKey(){} // RVA: 0xBC5AD0
        public void get_responses(){} // RVA: 0xBC5B30
        public void set_responses(){} // RVA: 0xBC5B40
        public void get_expiresAt(){} // RVA: 0xBC5BA0
        public void set_expiresAt(){} // RVA: 0x6A8AFA0
        public void get_expiryAfterSeen(){} // RVA: 0xBAE5A0
        public void set_expiryAfterSeen(){} // RVA: 0x6E3F2A0
        public void get_seen(){} // RVA: 0x1AE5AD0
        public void set_seen(){} // RVA: 0x1AE3600
        public void get_ignoreDND(){} // RVA: 0xB9F4D0
        public void set_ignoreDND(){} // RVA: 0xB9F4E0
        public void get_canDelete(){} // RVA: 0x981B050
        public void set_canDelete(){} // RVA: 0x981B350
        public void get_created_at(){} // RVA: 0x10B4170
        public void set_created_at(){} // RVA: 0x1FDB9B0
        public void get_createdAt(){} // RVA: 0x10B9D50
        public void set_createdAt(){} // RVA: 0xD9D280
        public void get_updatedAt(){} // RVA: 0xD9E3D0
        public void set_updatedAt(){} // RVA: 0x6E3F2F0
        public void get_details(){} // RVA: 0xDA0520
        public void set_details(){} // RVA: 0xD9D570
        public void get_data(){} // RVA: 0x114AC20
        public void set_data(){} // RVA: 0x1149C90
        public void get_jobName(){} // RVA: 0xE3C930
        public void set_jobName(){} // RVA: 0xE3D020
        public void get_jobColor(){} // RVA: 0x135EDB0
        public void set_jobColor(){} // RVA: 0x1658000
        public void .ctor(){} // RVA: 0xA564A50
        public void ShouldCache(){} // RVA: 0xB43320
        public void ReadField(){} // RVA: 0xA564AF0
        public void WriteField(){} // RVA: 0xA564D30
    }

    public class ApiPagedTransactions : ApiModel
    {
        public object _transactions;
        public object _totalCount;

        // ── Methods ──
        public void get_Transactions(){} // RVA: 0xBBFF90
        public void set_Transactions(){} // RVA: 0xBBFFA0
        public void get_TotalCount(){} // RVA: 0x19C6270
        public void set_TotalCount(){} // RVA: 0xCE5450
        public void FetchTransactions(){} // RVA: 0xA57A2E0
        public void .ctor(){} // RVA: 0xA57B450
    }

    public class ApiPlayerModeration : ApiModel
    {
        public object ListCacheTime;
        public object _moderationType;
        public object _targetUserId;
        public object _targetDisplayName;
        public object _sourceUserId;
        public object _sourceDisplayName;
        public object _created;

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x2536460
        public void set_moderationType(){} // RVA: 0x25406E0
        public void get_targetUserId(){} // RVA: 0xC10050
        public void set_targetUserId(){} // RVA: 0xC10060
        public void get_targetDisplayName(){} // RVA: 0xCD3320
        public void set_targetDisplayName(){} // RVA: 0xCD4740
        public void get_sourceUserId(){} // RVA: 0xCD48B0
        public void set_sourceUserId(){} // RVA: 0xCD3600
        public void get_sourceDisplayName(){} // RVA: 0xB813B0
        public void set_sourceDisplayName(){} // RVA: 0xD5CBB0
        public void get_created(){} // RVA: 0x1069350
        public void set_created(){} // RVA: 0x25687F0
        public void .ctor(){} // RVA: 0xA564E80
        public void CreateRemovalModeration(){} // RVA: 0xA564F40
        public void ShouldCache(){} // RVA: 0xB43320
        public void ReadField(){} // RVA: 0xA565000
        public void WriteField(){} // RVA: 0xA565200
        public void SendModeration(){} // RVA: 0xA5653E0
        public void DeleteModeration(){} // RVA: 0xA565620
        public void FetchAllAgainstMe(){} // RVA: 0xA565BD0
        public void FetchAllMine(){} // RVA: 0xA565C20
        public void FetchList(){} // RVA: 0xA565C70
        public void ModerationTypeToAPIString(){} // RVA: 0xA565F60
    }

    public class ApiPrint : ApiModel
    {
        public object _note;
        public object _authorId;
        public object _authorName;
        public object _worldId;
        public object _worldName;
        public object _ownerId;
        public object _timestamp;
        public object _files;
        public object _createdAt;

        // ── Methods ──
        public void get_note(){} // RVA: 0xBBFF90
        public void set_note(){} // RVA: 0xBBFFA0
        public void get_authorId(){} // RVA: 0xC10050
        public void set_authorId(){} // RVA: 0xC10060
        public void get_authorName(){} // RVA: 0xCD3320
        public void set_authorName(){} // RVA: 0xCD4740
        public void get_worldId(){} // RVA: 0xCD48B0
        public void set_worldId(){} // RVA: 0xCD3600
        public void get_worldName(){} // RVA: 0xB813B0
        public void set_worldName(){} // RVA: 0xD5CBB0
        public void get_ownerId(){} // RVA: 0x1069350
        public void set_ownerId(){} // RVA: 0xD5CC10
        public void get_timestamp(){} // RVA: 0x106A7D0
        public void set_timestamp(){} // RVA: 0x6A6A800
        public void get_files(){} // RVA: 0x106A050
        public void set_files(){} // RVA: 0xD5CCD0
        public void get_createdAt(){} // RVA: 0x12EB090
        public void set_createdAt(){} // RVA: 0x24440F0
        public void .ctor(){} // RVA: 0xA566490
        public void GetFileURL(){} // RVA: 0xA566590
        public void GetImageURL(){} // RVA: 0xA5665B0
        public void Upload(){} // RVA: 0xA566600
        public void UpdatePrint(){} // RVA: 0xA566B20
        public void GetPrints(){} // RVA: 0xA566F80
        public void GetPrint(){} // RVA: 0xA5674C0
    }

    public class ApiProductPurchaseStatus : ApiModel
    {
        public object _productId;
        public object _licenseId;
        public object _expiry;

        // ── Methods ──
        public void get_ProductId(){} // RVA: 0xBBFF90
        public void set_ProductId(){} // RVA: 0xBBFFA0
        public void get_LicenseId(){} // RVA: 0xC10050
        public void set_LicenseId(){} // RVA: 0xC10060
        public void get_Expiry(){} // RVA: 0xCD3320
        public void set_Expiry(){} // RVA: 0x6529A50
        public void GetProductsPurchaseStatus(){} // RVA: 0xA56BDE0
        public void .ctor(){} // RVA: 0xA56C390
    }

    public class ApiProductVariant : ApiModel
    {
        public object _listingVariantID;
        public object _quantity;
        public object _unitPriceTokens;
        public object _nonRefundable;
        public object _effectiveFrom;

        // ── Methods ──
        public void get_ListingVariantID(){} // RVA: 0xBBFF90
        public void set_ListingVariantID(){} // RVA: 0xBBFFA0
        public void get_Quantity(){} // RVA: 0x19C6270
        public void set_Quantity(){} // RVA: 0xCE5450
        public void get_UnitPriceTokens(){} // RVA: 0x21EA4F0
        public void set_UnitPriceTokens(){} // RVA: 0x26432E0
        public void get_NonRefundable(){} // RVA: 0x1165710
        public void set_NonRefundable(){} // RVA: 0x1F749D0
        public void get_EffectiveFrom(){} // RVA: 0xCD48B0
        public void set_EffectiveFrom(){} // RVA: 0x278E9B0
        public void .ctor(){} // RVA: 0xA56C4A0
    }

    public class ApiProfileBackgroundMetadata : ApiProfileInventoryMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA56CEA0
    }

    public class ApiProfileBanner : ApiFile
    {
        public object MAX_USER_BANNERS;

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0xB43320
        public void FetchList(){} // RVA: 0xA56C4F0
        public void .ctor(){} // RVA: 0xA51B250
    }

    public class ApiProfileEffectMetadata : ApiProfileInventoryMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xA56CEA0
    }

    public class ApiProfileInventoryMetadata : ApiModel
    {
        public object _assets;
        public object _animated;

        // ── Methods ──
        public void get_assets(){} // RVA: 0xBBFF90
        public void set_assets(){} // RVA: 0xBBFFA0
        public void get_animated(){} // RVA: 0xBC03E0
        public void set_animated(){} // RVA: 0xBC03F0
        public void get_BaseAsset(){} // RVA: 0xA56CD00
        public void .ctor(){} // RVA: 0xA56CEA0
    }

    public class ApiProfileTheme : ApiModel
    {
        public object _name;
        public object _iconColor;
        public object _buttonColor;
        public object _subtextColor;

        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_iconColor(){} // RVA: 0xC10050
        public void set_iconColor(){} // RVA: 0xC10060
        public void get_buttonColor(){} // RVA: 0xCD3320
        public void set_buttonColor(){} // RVA: 0xCD4740
        public void get_subtextColor(){} // RVA: 0xCD48B0
        public void set_subtextColor(){} // RVA: 0xCD3600
        public void FetchList(){} // RVA: 0xA56CEF0
        public void Save(){} // RVA: 0xA56CF10
        public void Delete(){} // RVA: 0xA56CF30
        public void .ctor(){} // RVA: 0xA56CF50
    }

    public class ApiProp : ApiContentModel`1
    {
        public object __created_at;
        public object __updated_at;
        public object _unityPackages;
        public object _spawnType;
        public object _worldPlacementMask;
        public object _kind;
        public object _scaleWithAvatar;
        public object _visibilityType;
        public object PropsEndpoint;
        public object _bundleSignature;

        // ── Methods ──
        public void get__created_at(){} // RVA: 0x135D730
        public void set__created_at(){} // RVA: 0x485FCF0
        public void get__updated_at(){} // RVA: 0xBC5B30
        public void set__updated_at(){} // RVA: 0x485FD20
        public void get_unityPackages(){} // RVA: 0xBC5BA0
        public void set_unityPackages(){} // RVA: 0xBC5BB0
        public void get_spawnType(){} // RVA: 0x255B930
        public void set_spawnType(){} // RVA: 0x6CE7A80
        public void get_worldPlacementMask(){} // RVA: 0x1AE9B20
        public void set_worldPlacementMask(){} // RVA: 0xA51A150
        public void get_kind(){} // RVA: 0x7E45E60
        public void set_kind(){} // RVA: 0x485FE90
        public void get_scaleWithAvatar(){} // RVA: 0x255BDF0
        public void set_scaleWithAvatar(){} // RVA: 0xA56CFA0
        public void get_visibilityType(){} // RVA: 0x10B4170
        public void set_visibilityType(){} // RVA: 0x15B42C0
        public void get_BundleSignature(){} // RVA: 0x10B9D50
        public void set_BundleSignature(){} // RVA: 0x15B7570
        public void .ctor(){} // RVA: 0xA56CFB0
        public void SetApiFieldsFromJson(){} // RVA: 0xA56D110
        public void ProcessUnityPackages(){} // RVA: 0xA56D1F0
        public void WriteField(){} // RVA: 0xA56DAA0
        public void CopyDeserializedValuesTo(){} // RVA: 0xA56DB60
        public void GetProp(){} // RVA: 0xA56DD60
    }

    public class ApiPropItemMetadata : ApiModel
    {
        public object _propId;
        public object _worldPlacementMask;
        public object _kind;

        // ── Methods ──
        public void get_propId(){} // RVA: 0xBBFF90
        public void set_propId(){} // RVA: 0xBBFFA0
        public void get_worldPlacementMask(){} // RVA: 0x19C6270
        public void set_worldPlacementMask(){} // RVA: 0xCE5450
        public void get_kind(){} // RVA: 0x21EA4F0
        public void set_kind(){} // RVA: 0x26432E0
        public void .ctor(){} // RVA: 0xA56E1F0
    }

    public class ApiPurchase : ApiModel
    {
        public object _listingId;
        public object _listingDisplayName;
        public object _listingImageId;
        public object _listingType;
        public object _listingVariantId;
        public object _sellerId;
        public object _sellerDisplayName;
        public object _buyerId;
        public object _buyerDisplayName;
        public object _receiverId;
        public object _receiverDisplayName;
        public object _price;
        public object _quantity;
        public object _duration;
        public object _durationType;
        public object _purchaseDate;
        public object _purchaseStartDate;
        public object _purchaseEndDate;
        public object _purchaseActive;
        public object _purchaseLatest;
        public object _products;
        public object _isStackable;
        public object _isRecurrable;
        public object _purchaseToken;
        public object _isVoided;
        public object _isGift;
        public object _purchaseUnitPrice;
        public object _isRefundable;
        public object _stackDurationType;
        public object _stackDuration;
        public object _stackPrice;
        public object _stackQuantity;
        public object _stackQuantityConsumed;
        public object _stackQuantityConsumedAtPurchase;
        public object _stackQuantityUnconsumed;
        public object _stackQuantityUnconsumedAtPurchase;
        public object _tiliaTransactionId;
        public object _willRecur;
        public object _listingCurrentlyAvailable;
        public object _createdAtDate;
        public object _purchaseID;
        public object _updatedAtDate;
        public object _purchaseOriginalEndDate;
        public object _buyerIP;
        public object _isRecur;
        public object _isUnityLocalTest;
        public object _licenseID;
        public object _purchaseStacks;
        public object _purchaseTiliaFee;
        public object _purchaseType;
        public object _purchaseValue;
        public object _purchaseVrcFee;
        public object _refundStatus;
        public object _sellerIP;
        public object _stackTiliaFee;
        public object _stackValue;
        public object _stackVrcFee;
        public object _stackQuantityVoided;
        public object _voidedBy;
        public object _voidedByAdmin;
        public object _voidedOnDate;
        public object _purchaseTiliaFeeBasedOnStack;
        public object _purchaseTiliaFeeDrift;
        public object _purchaseVrcFeeBasedOnStack;
        public object _refunded;
        public object _refundedBy;
        public object _refundedByAdmin;
        public object _refundedOnDate;
        public object _refundedStacks;
        public object _refundReason;
        public object _refundReasonType;
        public object _refundTiliaTransactionId;
        public object _refundTokenComponents;
        public object _refundTokens;
        public object _refundTokenSources;
        public object _refundType;
        public object _voidedStacks;
        public object _voidedCompletely;

        // ── Methods ──
        public void get_ListingId(){} // RVA: 0xBBFF90
        public void set_ListingId(){} // RVA: 0xBBFFA0
        public void get_ListingDisplayName(){} // RVA: 0xC10050
        public void set_ListingDisplayName(){} // RVA: 0xC10060
        public void get_ListingImageId(){} // RVA: 0xCD3320
        public void set_ListingImageId(){} // RVA: 0xCD4740
        public void get_ListingImageUrl(){} // RVA: 0xA56E2E0
        public void get_ListingType(){} // RVA: 0xD34760
        public void set_ListingType(){} // RVA: 0xD34750
        public void get_ListingVariantId(){} // RVA: 0xB813B0
        public void set_ListingVariantId(){} // RVA: 0xD5CBB0
        public void get_SellerId(){} // RVA: 0x1069350
        public void set_SellerId(){} // RVA: 0xD5CC10
        public void get_SellerDisplayName(){} // RVA: 0x106A7D0
        public void set_SellerDisplayName(){} // RVA: 0xD5CC70
        public void get_BuyerId(){} // RVA: 0x106A050
        public void set_BuyerId(){} // RVA: 0xD5CCD0
        public void get_BuyerDisplayName(){} // RVA: 0x12EB090
        public void set_BuyerDisplayName(){} // RVA: 0x13B1040
        public void get_ReceiverId(){} // RVA: 0xBAE340
        public void set_ReceiverId(){} // RVA: 0xBAE350
        public void get_ReceiverDisplayName(){} // RVA: 0xBAE3B0
        public void set_ReceiverDisplayName(){} // RVA: 0xBAE3C0
        public void get_id(){} // RVA: 0xB5DBF0
        public void set_id(){} // RVA: 0xB44D60
        public void get_Price(){} // RVA: 0xE35F30
        public void set_Price(){} // RVA: 0xE3CFA0
        public void get_Quantity(){} // RVA: 0x485F8A0
        public void set_Quantity(){} // RVA: 0x485F8B0
        public void get_Duration(){} // RVA: 0x12CE7D0
        public void set_Duration(){} // RVA: 0x421A240
        public void get_DurationType(){} // RVA: 0x214AA20
        public void set_DurationType(){} // RVA: 0x6BA2C20
        public void get_PurchaseDate(){} // RVA: 0xC68EB0
        public void set_PurchaseDate(){} // RVA: 0x7339DC0
        public void get_PurchaseStartDate(){} // RVA: 0x135D730
        public void set_PurchaseStartDate(){} // RVA: 0x485FCF0
        public void get_PurchaseEndDate(){} // RVA: 0xBC5B30
        public void set_PurchaseEndDate(){} // RVA: 0x485FD20
        public void get_PurchaseActive(){} // RVA: 0x1DFD090
        public void set_PurchaseActive(){} // RVA: 0x216A2B0
        public void get_PurchaseLatest(){} // RVA: 0x71164B0
        public void set_PurchaseLatest(){} // RVA: 0xA56E320
        public void get_Products(){} // RVA: 0xBAE5A0
        public void set_Products(){} // RVA: 0xBAE5B0
        public void get_IsStackable(){} // RVA: 0x1AE5AD0
        public void set_IsStackable(){} // RVA: 0x1AE3600
        public void get_IsRecurrable(){} // RVA: 0xB9F4D0
        public void set_IsRecurrable(){} // RVA: 0xB9F4E0
        public void get_PurchaseToken(){} // RVA: 0x10B4170
        public void set_PurchaseToken(){} // RVA: 0x15B42C0
        public void get_IsVoided(){} // RVA: 0x1FDB9C0
        public void set_IsVoided(){} // RVA: 0x1FDB9D0
        public void get_IsGift(){} // RVA: 0x2443DE0
        public void set_IsGift(){} // RVA: 0x2444100
        public void get_PurchaseUnitPrice(){} // RVA: 0x23B0EB0
        public void set_PurchaseUnitPrice(){} // RVA: 0x23ABE50
        public void get_IsRefundable(){} // RVA: 0x1184420
        public void set_IsRefundable(){} // RVA: 0x1EBEA50
        public void get_StackDurationType(){} // RVA: 0xDA0520
        public void set_StackDurationType(){} // RVA: 0xD9D570
        public void get_StackDuration(){} // RVA: 0x15D7C60
        public void set_StackDuration(){} // RVA: 0x6CE7A90
        public void get_StackPrice(){} // RVA: 0x6BB0770
        public void set_StackPrice(){} // RVA: 0x6BB0780
        public void get_StackQuantity(){} // RVA: 0x6CE7E30
        public void set_StackQuantity(){} // RVA: 0x6CE7E40
        public void get_StackQuantityConsumed(){} // RVA: 0xA56E330
        public void set_StackQuantityConsumed(){} // RVA: 0xA56E340
        public void get_StackQuantityConsumedAtPurchase(){} // RVA: 0x114AC30
        public void set_StackQuantityConsumedAtPurchase(){} // RVA: 0x1AE2D20
        public void get_StackQuantityUnconsumed(){} // RVA: 0x75C0A30
        public void set_StackQuantityUnconsumed(){} // RVA: 0xA56E350
        public void get_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x6BA2C40
        public void set_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x6BA2C50
        public void get_TiliaTransactionId(){} // RVA: 0xBAE8F0
        public void set_TiliaTransactionId(){} // RVA: 0xBAE900
        public void get_WillRecur(){} // RVA: 0x2540EB0
        public void set_WillRecur(){} // RVA: 0x6CE7AD0
        public void get_ListingCurrentlyAvailable(){} // RVA: 0xA0D8320
        public void set_ListingCurrentlyAvailable(){} // RVA: 0x9D9B7B0
        public void get_CreatedAtDate(){} // RVA: 0x12CDBF0
        public void set_CreatedAtDate(){} // RVA: 0xA56E360
        public void get_PurchaseID(){} // RVA: 0x1661250
        public void set_PurchaseID(){} // RVA: 0x166A5F0
        public void get_UpdatedAtDate(){} // RVA: 0x1143F90
        public void set_UpdatedAtDate(){} // RVA: 0x1AE8DF0
        public void get_PurchaseOriginalEndDate(){} // RVA: 0x164B8E0
        public void set_PurchaseOriginalEndDate(){} // RVA: 0xA56E370
        public void get_BuyerIP(){} // RVA: 0x10F9C30
        public void set_BuyerIP(){} // RVA: 0x1659C50
        public void get_IsRecur(){} // RVA: 0x1B93340
        public void set_IsRecur(){} // RVA: 0xC1C7A0
        public void get_IsUnityLocalTest(){} // RVA: 0x1B8D060
        public void set_IsUnityLocalTest(){} // RVA: 0x1B93350
        public void get_LicenseID(){} // RVA: 0x165EBC0
        public void set_LicenseID(){} // RVA: 0x1651590
        public void get_PurchaseStacks(){} // RVA: 0x1667D40
        public void set_PurchaseStacks(){} // RVA: 0x1669D30
        public void get_PurchaseTiliaFee(){} // RVA: 0x6CEA800
        public void set_PurchaseTiliaFee(){} // RVA: 0x78F9B60
        public void get_PurchaseType(){} // RVA: 0x135C160
        public void set_PurchaseType(){} // RVA: 0x16614A0
        public void get_PurchaseValue(){} // RVA: 0xA568090
        public void set_PurchaseValue(){} // RVA: 0xA5680A0
        public void get_PurchaseVrcFee(){} // RVA: 0x9C46630
        public void set_PurchaseVrcFee(){} // RVA: 0x9C498E0
        public void get_RefundStatus(){} // RVA: 0x135A180
        public void set_RefundStatus(){} // RVA: 0x164D690
        public void get_SellerIP(){} // RVA: 0x165E8F0
        public void set_SellerIP(){} // RVA: 0x165C4D0
        public void get_StackTiliaFee(){} // RVA: 0xA56E380
        public void set_StackTiliaFee(){} // RVA: 0xA56E390
        public void get_StackValue(){} // RVA: 0x1E5B6F0
        public void set_StackValue(){} // RVA: 0xA56E3A0
        public void get_StackVrcFee(){} // RVA: 0x1E60D80
        public void set_StackVrcFee(){} // RVA: 0xA56E3B0
        public void get_StackQuantityVoided(){} // RVA: 0xA56E3C0
        public void set_StackQuantityVoided(){} // RVA: 0xA56E3D0
        public void get_VoidedBy(){} // RVA: 0x1655DD0
        public void set_VoidedBy(){} // RVA: 0x16694D0
        public void get_VoidedByAdmin(){} // RVA: 0xA56E3E0
        public void set_VoidedByAdmin(){} // RVA: 0xA56E3F0
        public void get_VoidedOnDate(){} // RVA: 0x165AD10
        public void set_VoidedOnDate(){} // RVA: 0xA56E400
        public void get_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0xA56E410
        public void set_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0xA56E420
        public void get_PurchaseTiliaFeeDrift(){} // RVA: 0x7379CB0
        public void set_PurchaseTiliaFeeDrift(){} // RVA: 0xA56E430
        public void get_PurchaseVrcFeeBasedOnStack(){} // RVA: 0xA0A05C0
        public void set_PurchaseVrcFeeBasedOnStack(){} // RVA: 0xA56E440
        public void get_Refunded(){} // RVA: 0xA56E450
        public void set_Refunded(){} // RVA: 0xA56E460
        public void get_RefundedBy(){} // RVA: 0x1659260
        public void set_RefundedBy(){} // RVA: 0x165DAA0
        public void get_RefundedByAdmin(){} // RVA: 0x7A0F5B0
        public void set_RefundedByAdmin(){} // RVA: 0xA56E470
        public void get_RefundedOnDate(){} // RVA: 0x165F4F0
        public void set_RefundedOnDate(){} // RVA: 0xA56E480
        public void get_RefundedStacks(){} // RVA: 0x164EDD0
        public void set_RefundedStacks(){} // RVA: 0x1651390
        public void get_RefundReason(){} // RVA: 0x1640C90
        public void set_RefundReason(){} // RVA: 0x1668690
        public void get_RefundReasonType(){} // RVA: 0x165F950
        public void set_RefundReasonType(){} // RVA: 0x164BF20
        public void get_RefundTiliaTransactionId(){} // RVA: 0x1667A40
        public void set_RefundTiliaTransactionId(){} // RVA: 0x163A9E0
        public void get_RefundTokenComponents(){} // RVA: 0x165A670
        public void set_RefundTokenComponents(){} // RVA: 0x1661A80
        public void get_RefundTokens(){} // RVA: 0x2304EB0
        public void set_RefundTokens(){} // RVA: 0x2303FA0
        public void get_RefundTokenSources(){} // RVA: 0x163F650
        public void set_RefundTokenSources(){} // RVA: 0x1656720
        public void get_RefundType(){} // RVA: 0x164AA90
        public void set_RefundType(){} // RVA: 0x164B2D0
        public void get_VoidedStacks(){} // RVA: 0x165DF30
        public void set_VoidedStacks(){} // RVA: 0x164E760
        public void get_VoidedCompletely(){} // RVA: 0xA56E490
        public void set_VoidedCompletely(){} // RVA: 0xA56E4A0
        public void ReadField(){} // RVA: 0xA56E4B0
        public void WriteField(){} // RVA: 0xA56E6F0
        public void GetCancelInformation(){} // RVA: 0xA56E870
        public void Cancel(){} // RVA: 0xA56F150
        public void FetchList(){} // RVA: 0xA56FAC0
        public void FetchMostRecentActivePurchase(){} // RVA: 0xA570A70
        public void .ctor(){} // RVA: 0xA5713D0
    }

    public class ApiPurchaseCancelSubscriptionInfo : ApiModel
    {
        public object _refundableAmount;
        public object _nonRefundableAmount;
        public object _totalStacksToCancel;
        public object _newExpirationDate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA56E240
        public void get_RefundableAmount(){} // RVA: 0x2536460
        public void set_RefundableAmount(){} // RVA: 0x25406E0
        public void get_NonRefundableAmount(){} // RVA: 0x25406F0
        public void set_NonRefundableAmount(){} // RVA: 0x2540700
        public void get_TotalStacksToCancel(){} // RVA: 0x19C6270
        public void set_TotalStacksToCancel(){} // RVA: 0xCE5450
        public void get_NewExpirationDate(){} // RVA: 0xCD3320
        public void set_NewExpirationDate(){} // RVA: 0x6529A50
    }

    public class ApiPurchaseSubscriptionCancelledInfo : ApiModel
    {
        public object _amountRefunded;
        public object _totalStacksCancelled;
        public object _newExpirationDate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA56E290
        public void get_AmountRefunded(){} // RVA: 0x2536460
        public void set_AmountRefunded(){} // RVA: 0x25406E0
        public void get_TotalStacksCancelled(){} // RVA: 0x25406F0
        public void set_TotalStacksCancelled(){} // RVA: 0x2540700
        public void get_NewExpirationDate(){} // RVA: 0xC10050
        public void set_NewExpirationDate(){} // RVA: 0x278E9C0
    }

    public class ApiReport : ApiModel
    {
        public object _type;
        public object _category;
        public object _reason;
        public object _contentId;
        public object _description;
        public object _details;
        public object _contentName;
        public object _contentThumbnailImageUrl;

        // ── Methods ──
        public void get_type(){} // RVA: 0xBBFF90
        public void set_type(){} // RVA: 0xBBFFA0
        public void get_category(){} // RVA: 0xC10050
        public void set_category(){} // RVA: 0xC10060
        public void get_reason(){} // RVA: 0xCD3320
        public void set_reason(){} // RVA: 0xCD4740
        public void get_contentId(){} // RVA: 0xCD48B0
        public void set_contentId(){} // RVA: 0xCD3600
        public void get_description(){} // RVA: 0xB813B0
        public void set_description(){} // RVA: 0xD5CBB0
        public void get_details(){} // RVA: 0x1069350
        public void set_details(){} // RVA: 0xD5CC10
        public void get_contentName(){} // RVA: 0x106A7D0
        public void set_contentName(){} // RVA: 0xD5CC70
        public void get_contentThumbnailImageUrl(){} // RVA: 0x106A050
        public void set_contentThumbnailImageUrl(){} // RVA: 0xD5CCD0
        public void AddReport(){} // RVA: 0xA5721D0
        public void FetchReports(){} // RVA: 0xA572500
        public void DeleteReport(){} // RVA: 0xA572BB0
        public void .ctor(){} // RVA: 0xA572EC0
    }

    public class ApiReportDetails : ApiModel
    {
        public object _suggestedWarnings;
        public object _instanceType;
        public object _instanceAgeGated;
        public object _userInSameInstance;
        public object _imageType;
        public object _fileId;
        public object _holderId;
        public object _targetUserId;

        // ── Methods ──
        public void get_suggestedWarnings(){} // RVA: 0xBBFF90
        public void set_suggestedWarnings(){} // RVA: 0xBBFFA0
        public void get_instanceType(){} // RVA: 0xC10050
        public void set_instanceType(){} // RVA: 0xC10060
        public void get_instanceAgeGated(){} // RVA: 0x6A0DA10
        public void set_instanceAgeGated(){} // RVA: 0xA573070
        public void get_userInSameInstance(){} // RVA: 0xA573080
        public void set_userInSameInstance(){} // RVA: 0xA573090
        public void get_imageType(){} // RVA: 0xCD48B0
        public void set_imageType(){} // RVA: 0xCD3600
        public void get_fileId(){} // RVA: 0xB813B0
        public void set_fileId(){} // RVA: 0xD5CBB0
        public void get_holderId(){} // RVA: 0x1069350
        public void set_holderId(){} // RVA: 0xD5CC10
        public void get_targetUserId(){} // RVA: 0x106A7D0
        public void set_targetUserId(){} // RVA: 0xD5CC70
        public void .ctor(){} // RVA: 0xA5730A0
    }

    public class ApiReportResponse : ApiModel
    {
        public object _evidenceRequired;
        public object _supportRequired;

        // ── Methods ──
        public void get_evidenceRequired(){} // RVA: 0xC10030
        public void set_evidenceRequired(){} // RVA: 0xC10040
        public void get_supportRequired(){} // RVA: 0x6296240
        public void set_supportRequired(){} // RVA: 0x6296250
        public void .ctor(){} // RVA: 0xA573140
    }

    public class ApiReportsContainer : ApiModel
    {
        public object _hasNext;
        public object _results;
        public object _totalCount;

        // ── Methods ──
        public void get_hasNext(){} // RVA: 0xC10030
        public void set_hasNext(){} // RVA: 0xC10040
        public void get_results(){} // RVA: 0xC10050
        public void set_results(){} // RVA: 0xC10060
        public void get_totalCount(){} // RVA: 0x23ADD10
        public void set_totalCount(){} // RVA: 0x23B2A80
        public void .ctor(){} // RVA: 0xA5730F0
    }

    public class ApiSearchGroupResults : ApiModel
    {
        public object _results;
        public object _totalCount;

        // ── Methods ──
        public void get_results(){} // RVA: 0xBBFF90
        public void set_results(){} // RVA: 0xBBFFA0
        public void get_totalCount(){} // RVA: 0x19C6270
        public void set_totalCount(){} // RVA: 0xCE5450
        public void .ctor(){} // RVA: 0xA579150
    }

    public class ApiSearchUserResults : ApiModel
    {
        public object _results;
        public object _totalCount;

        // ── Methods ──
        public void get_results(){} // RVA: 0xBBFF90
        public void set_results(){} // RVA: 0xBBFFA0
        public void get_totalCount(){} // RVA: 0x19C6270
        public void set_totalCount(){} // RVA: 0xCE5450
        public void .ctor(){} // RVA: 0xA579100
    }

    public class ApiSearchWorldResults : ApiModel
    {
        public object _results;
        public object _totalCount;

        // ── Methods ──
        public void get_results(){} // RVA: 0xBBFF90
        public void set_results(){} // RVA: 0xBBFFA0
        public void get_totalCount(){} // RVA: 0x19C6270
        public void set_totalCount(){} // RVA: 0xCE5450
        public void .ctor(){} // RVA: 0xA5790B0
    }

    public class ApiSteamVRChatFinalizeTransactionResponse : ApiVRChatSubscriptionBaseResponse
    {
        public object _status;
        public object _giftValidationToken;
        public object _subscription;

        // ── Methods ──
        public void get_status(){} // RVA: 0xC10050
        public void set_status(){} // RVA: 0xC10060
        public void get_giftValidationToken(){} // RVA: 0xCD3320
        public void set_giftValidationToken(){} // RVA: 0xCD4740
        public void get_subscription(){} // RVA: 0xCD48B0
        public void set_subscription(){} // RVA: 0xCD3600
        public void .ctor(){} // RVA: 0xA59AD30
    }

    public class ApiSteamVRChatSubscriptionSteamTransaction : ApiModel
    {
        public object _walletInfo;
        public object _steamId;
        public object _orderId;
        public object _steamUrl;
        public object _transId;

        // ── Methods ──
        public void get_walletInfo(){} // RVA: 0xBBFF90
        public void set_walletInfo(){} // RVA: 0xBBFFA0
        public void get_steamId(){} // RVA: 0xC10050
        public void set_steamId(){} // RVA: 0xC10060
        public void get_orderId(){} // RVA: 0xCD3320
        public void set_orderId(){} // RVA: 0xCD4740
        public void get_steamUrl(){} // RVA: 0xCD48B0
        public void set_steamUrl(){} // RVA: 0xCD3600
        public void get_transId(){} // RVA: 0xB813B0
        public void set_transId(){} // RVA: 0xD5CBB0
        public void .ctor(){} // RVA: 0xA59B390
    }

    public class ApiSteamVRChatSubscriptionTransaction : ApiVRChatSubscriptionBaseResponse
    {
        public object _status;
        public object _subscription;
        public object _sandbox;
        public object _created_at;
        public object _updated_at;
        public object _steam;

        // ── Methods ──
        public void get_status(){} // RVA: 0xC10050
        public void set_status(){} // RVA: 0xC10060
        public void get_subscription(){} // RVA: 0xCD3320
        public void set_subscription(){} // RVA: 0xCD4740
        public void get_sandbox(){} // RVA: 0xE3F400
        public void set_sandbox(){} // RVA: 0xE3CFC0
        public void get_created_at(){} // RVA: 0xB813B0
        public void set_created_at(){} // RVA: 0xD5CBB0
        public void get_updated_at(){} // RVA: 0x1069350
        public void set_updated_at(){} // RVA: 0xD5CC10
        public void get_steam(){} // RVA: 0x106A7D0
        public void set_steam(){} // RVA: 0xD5CC70
        public void .ctor(){} // RVA: 0xA59AD30
    }

    public class ApiSteamVRChatSubscriptionWalletInformation : ApiModel
    {
        public object _state;
        public object _country;
        public object _currency;
        public object _status;

        // ── Methods ──
        public void get_state(){} // RVA: 0xBBFF90
        public void set_state(){} // RVA: 0xBBFFA0
        public void get_country(){} // RVA: 0xC10050
        public void set_country(){} // RVA: 0xC10060
        public void get_currency(){} // RVA: 0xCD3320
        public void set_currency(){} // RVA: 0xCD4740
        public void get_status(){} // RVA: 0xCD48B0
        public void set_status(){} // RVA: 0xCD3600
        public void .ctor(){} // RVA: 0xA59B340
    }

    public class ApiStringArrayContainer : ApiContainer
    {
        // ── Methods ──
        public void get_responseArray(){} // RVA: 0xA573DE0
        public void Validate(){} // RVA: 0xA573E20
        public void .ctor(){} // RVA: 0xA573C70
    }

    public class ApiStringContainer : ApiContainer
    {
        // ── Methods ──
        public void get_ResponseString(){} // RVA: 0xA573C80
        public void Validate(){} // RVA: 0xA573CA0
        public void .ctor(){} // RVA: 0xA573C70
    }

    public class ApiTokenBundle : ApiModel
    {
        public object _steamItemId;
        public object _oculusSku;
        public object _googleProductId;
        public object _picoSku;
        public object _amount;
        public object _description;
        public object _tokens;
        public object _imageUrl;

        // ── Methods ──
        public void get_steamItemId(){} // RVA: 0x2536460
        public void set_steamItemId(){} // RVA: 0x25406E0
        public void get_oculusSku(){} // RVA: 0xC10050
        public void set_oculusSku(){} // RVA: 0xC10060
        public void get_googleProductId(){} // RVA: 0xCD3320
        public void set_googleProductId(){} // RVA: 0xCD4740
        public void get_picoSku(){} // RVA: 0xCD48B0
        public void set_picoSku(){} // RVA: 0xCD3600
        public void get_amount(){} // RVA: 0x14780B0
        public void set_amount(){} // RVA: 0x147EE80
        public void get_description(){} // RVA: 0x1069350
        public void set_description(){} // RVA: 0xD5CC10
        public void get_tokens(){} // RVA: 0x262A930
        public void set_tokens(){} // RVA: 0x262A900
        public void get_imageUrl(){} // RVA: 0x106A050
        public void set_imageUrl(){} // RVA: 0xD5CCD0
        public void Fetch(){} // RVA: 0xA579ED0
        public void .ctor(){} // RVA: 0xA57A1D0
    }

    public class ApiTokenPurchase : ApiTokenBundle
    {
        public object _purchaseDate;

        // ── Methods ──
        public void get_PurchaseDate(){} // RVA: 0x12EB090
        public void set_PurchaseDate(){} // RVA: 0x24440F0
        public void .ctor(){} // RVA: 0xA57A1D0
    }

    public class ApiTransaction : ApiModel
    {
        public object _listingID;
        public object _name;
        public object _sellerId;
        public object _fromUserDisplayName;
        public object _sellerDisplayName;
        public object _buyerId;
        public object _buyerDisplayName;
        public object _type;
        public object _date;
        public object _amount;
        public object _runningBalance;
        public object _imageId;
        public object _purchaseId;
        public object _tiliaRef;

        // ── Methods ──
        public void get_ListingID(){} // RVA: 0xBBFF90
        public void set_ListingID(){} // RVA: 0xBBFFA0
        public void get_Name(){} // RVA: 0xC10050
        public void set_Name(){} // RVA: 0xC10060
        public void get_SellerId(){} // RVA: 0xCD3320
        public void set_SellerId(){} // RVA: 0xCD4740
        public void get_FromUserDisplayName(){} // RVA: 0xCD48B0
        public void set_FromUserDisplayName(){} // RVA: 0xCD3600
        public void get_SellerDisplayName(){} // RVA: 0xB813B0
        public void set_SellerDisplayName(){} // RVA: 0xD5CBB0
        public void get_BuyerId(){} // RVA: 0x1069350
        public void set_BuyerId(){} // RVA: 0xD5CC10
        public void get_BuyerDisplayName(){} // RVA: 0x106A7D0
        public void set_BuyerDisplayName(){} // RVA: 0xD5CC70
        public void get_Type(){} // RVA: 0x106A050
        public void set_Type(){} // RVA: 0xD5CCD0
        public void get_Date(){} // RVA: 0x12EB090
        public void set_Date(){} // RVA: 0x24440F0
        public void get_Amount(){} // RVA: 0x295D4E0
        public void set_Amount(){} // RVA: 0x6A92F20
        public void get_RunningBalance(){} // RVA: 0x68504F0
        public void set_RunningBalance(){} // RVA: 0x798F510
        public void get_ImageId(){} // RVA: 0xBAE3B0
        public void set_ImageId(){} // RVA: 0xBAE3C0
        public void get_PurchaseId(){} // RVA: 0xBAE420
        public void set_PurchaseId(){} // RVA: 0xBAE430
        public void get_TiliaRef(){} // RVA: 0xCA4D80
        public void set_TiliaRef(){} // RVA: 0xCA4D90
        public void get_TransactionImageUrl(){} // RVA: 0xA57B660
        public void FetchList(){} // RVA: 0xA57B6A0
        public void .ctor(){} // RVA: 0xA57C640
    }

    public class ApiUserIcon : ApiFile
    {
        public object MAX_USER_ICONS;
        public object endpoint;

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0xB43320
        public void FetchList(){} // RVA: 0xA597E10
        public void UploadIcon(){} // RVA: 0xA598880
        public void .ctor(){} // RVA: 0xA51B250
    }

    public class ApiUserPermission : ApiModel
    {
        public object _ownerId;
        public object _name;
        public object _data;

        // ── Methods ──
        public void get_ownerId(){} // RVA: 0xBBFF90
        public void set_ownerId(){} // RVA: 0xBBFFA0
        public void get_name(){} // RVA: 0xC10050
        public void set_name(){} // RVA: 0xC10060
        public void get_data(){} // RVA: 0xCD3320
        public void set_data(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA599BF0
    }

    public class ApiUserPlatformList : ApiModel
    {
        public object _platforms;

        // ── Methods ──
        public void get_platforms(){} // RVA: 0xBBFF90
        public void set_platforms(){} // RVA: 0xBBFFA0
        public void .ctor(){} // RVA: 0xA59A670
    }

    public class ApiUserPlatforms : Object
    {
        public object _platforms;
        public object _currentUserPlatforms;

        // ── Methods ──
        public void get_platforms(){} // RVA: 0xB8F8F0
        public void set_platforms(){} // RVA: 0xB460A0
        public void get_CurrentUserPlatforms(){} // RVA: 0xA599C40
        public void set_CurrentUserPlatforms(){} // RVA: 0xA599C80
        public void Fetch(){} // RVA: 0xA599D20
        public void Clear(){} // RVA: 0xA59A070
        public void get_SupportsStandaloneWindows(){} // RVA: 0xA59A080
        public void get_SupportsAndroid(){} // RVA: 0xA59A090
        public void get_SupportsiOS(){} // RVA: 0xA59A0A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ApiUserProfile : ApiModel
    {
        public object _displayName;
        public object _bio;
        public object _pronouns;
        public object _status;
        public object _statusDescription;
        public object _location;
        public object _badges;
        public object _trustTags;
        public object _bioLinks;
        public object _languageTags;
        public object _hasVrcPlus;
        public object _isSeller;
        public object _ageVerified;
        public object _ageVerificationStatus;
        public object _note;
        public object _icon;
        public object _banner;
        public object _background;
        public object _theme;
        public object _iconFrame;
        public object _profileEffect;

        // ── Methods ──
        public void get_displayName(){} // RVA: 0xBBFF90
        public void set_displayName(){} // RVA: 0xBBFFA0
        public void get_bio(){} // RVA: 0xC10050
        public void set_bio(){} // RVA: 0xC10060
        public void get_pronouns(){} // RVA: 0xCD3320
        public void set_pronouns(){} // RVA: 0xCD4740
        public void get_status(){} // RVA: 0xCD48B0
        public void set_status(){} // RVA: 0xCD3600
        public void get_statusDescription(){} // RVA: 0xB813B0
        public void set_statusDescription(){} // RVA: 0xD5CBB0
        public void get_location(){} // RVA: 0x1069350
        public void set_location(){} // RVA: 0xD5CC10
        public void get_badges(){} // RVA: 0x106A7D0
        public void set_badges(){} // RVA: 0xD5CC70
        public void get_trustTags(){} // RVA: 0x106A050
        public void set_trustTags(){} // RVA: 0xD5CCD0
        public void get_bioLinks(){} // RVA: 0x12EB090
        public void set_bioLinks(){} // RVA: 0x13B1040
        public void get_languageTags(){} // RVA: 0xBAE340
        public void set_languageTags(){} // RVA: 0xBAE350
        public void get_hasVrcPlus(){} // RVA: 0x20119F0
        public void set_hasVrcPlus(){} // RVA: 0x2013510
        public void get_isSeller(){} // RVA: 0x2558540
        public void set_isSeller(){} // RVA: 0x421A230
        public void get_ageVerified(){} // RVA: 0x6FB28F0
        public void set_ageVerified(){} // RVA: 0x6FB2900
        public void get_ageVerificationStatus(){} // RVA: 0xBAE420
        public void set_ageVerificationStatus(){} // RVA: 0xBAE430
        public void get_note(){} // RVA: 0xCA4D80
        public void set_note(){} // RVA: 0xCA4D90
        public void get_icon(){} // RVA: 0xC68EB0
        public void set_icon(){} // RVA: 0xC68EC0
        public void get_banner(){} // RVA: 0x135D730
        public void set_banner(){} // RVA: 0xBC5AD0
        public void get_background(){} // RVA: 0xBC5B30
        public void set_background(){} // RVA: 0xBC5B40
        public void get_theme(){} // RVA: 0xBC5BA0
        public void set_theme(){} // RVA: 0xBC5BB0
        public void get_iconFrame(){} // RVA: 0xBAE5A0
        public void set_iconFrame(){} // RVA: 0xBAE5B0
        public void get_profileEffect(){} // RVA: 0x135A7B0
        public void set_profileEffect(){} // RVA: 0xEC0BB0
        public void Save(){} // RVA: 0xA56CF10
        public void Get(){} // RVA: 0xA56CF10
        public void .ctor(){} // RVA: 0xA59A6C0
    }

    public class ApiVRChatAdminSubscriptionTransaction : ApiVRChatSubscriptionBaseResponse
    {
        public object _userId;
        public object _adminUserId;
        public object _expiry;
        public object _subscription;

        // ── Methods ──
        public void get_userId(){} // RVA: 0xC10050
        public void set_userId(){} // RVA: 0xC10060
        public void get_adminUserId(){} // RVA: 0xCD3320
        public void set_adminUserId(){} // RVA: 0xCD4740
        public void get_expiry(){} // RVA: 0xCD48B0
        public void set_expiry(){} // RVA: 0xCD3600
        public void get_subscription(){} // RVA: 0xB813B0
        public void set_subscription(){} // RVA: 0xD5CBB0
        public void .ctor(){} // RVA: 0xA59AD30
    }

    public class ApiVRChatGiftTransactionResponse : ApiVRChatSubscriptionBaseResponse
    {
        public object _giftValidationToken;

        // ── Methods ──
        public void get_giftValidationToken(){} // RVA: 0xC10050
        public void set_giftValidationToken(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA59AD30
    }

    public class ApiVRChatProductDetails : ApiModel
    {
        public object _enabled;
        public object _productType;
        public object productTypeEnum;
        public object _endpoint;
        public object _stores;
        public object _subscriptionInfo;
        public object _giftInfo;
        public object _tokenInfo;
        public object _description;

        // ── Methods ──
        public void get_enabled(){} // RVA: 0xC10030
        public void set_enabled(){} // RVA: 0xC10040
        public void get_productType(){} // RVA: 0xC10050
        public void set_productType(){} // RVA: 0xC10060
        public void get_Product(){} // RVA: 0xA59AA30
        public void get_endpoint(){} // RVA: 0xCD48B0
        public void set_endpoint(){} // RVA: 0xCD3600
        public void get_stores(){} // RVA: 0xB813B0
        public void set_stores(){} // RVA: 0xD5CBB0
        public void get_subscriptionInfo(){} // RVA: 0x1069350
        public void set_subscriptionInfo(){} // RVA: 0xD5CC10
        public void get_giftInfo(){} // RVA: 0x106A7D0
        public void set_giftInfo(){} // RVA: 0xD5CC70
        public void get_tokenInfo(){} // RVA: 0x106A050
        public void set_tokenInfo(){} // RVA: 0xD5CCD0
        public void get_description(){} // RVA: 0x12EB090
        public void set_description(){} // RVA: 0x13B1040
        public void .ctor(){} // RVA: 0xA59AB10
    }

    public class ApiVRChatSubscription : ApiModel
    {
        public object _transactionId;
        public object _steamItemId;
        public object _amount;
        public object _description;
        public object _store;
        public object _period;
        public object _active;
        public object _status;
        public object _tier;
        public object _starts;
        public object _expires;
        public object _created_at;
        public object _updated_at;
        public object _isGift;
        public object _isBulkGift;
        public object _giftedBy;
        public object _giftedByDisplayName;
        public object _licenseGroups;
        public object _vendorData;

        // ── Methods ──
        public void get_transactionId(){} // RVA: 0xBBFF90
        public void set_transactionId(){} // RVA: 0xBBFFA0
        public void get_steamItemId(){} // RVA: 0xC10050
        public void set_steamItemId(){} // RVA: 0xC10060
        public void get_amount(){} // RVA: 0xCD3320
        public void set_amount(){} // RVA: 0x6529A50
        public void get_description(){} // RVA: 0xCD48B0
        public void set_description(){} // RVA: 0xCD3600
        public void get_store(){} // RVA: 0xB813B0
        public void set_store(){} // RVA: 0xD5CBB0
        public void get_period(){} // RVA: 0x1069350
        public void set_period(){} // RVA: 0xD5CC10
        public void get_active(){} // RVA: 0x11319D0
        public void set_active(){} // RVA: 0x112ECB0
        public void get_status(){} // RVA: 0x106A050
        public void set_status(){} // RVA: 0xD5CCD0
        public void get_tier(){} // RVA: 0x158C700
        public void set_tier(){} // RVA: 0x158BEC0
        public void get_starts(){} // RVA: 0xBAE340
        public void set_starts(){} // RVA: 0xBAE350
        public void get_expires(){} // RVA: 0xBAE3B0
        public void set_expires(){} // RVA: 0xBAE3C0
        public void get_created_at(){} // RVA: 0xBAE420
        public void set_created_at(){} // RVA: 0xBAE430
        public void get_updated_at(){} // RVA: 0xCA4D80
        public void set_updated_at(){} // RVA: 0xCA4D90
        public void get_isGift(){} // RVA: 0x1A6FCB0
        public void set_isGift(){} // RVA: 0x1A6FC50
        public void get_isBulkGift(){} // RVA: 0x1A70140
        public void set_isBulkGift(){} // RVA: 0x6E146E0
        public void get_giftedBy(){} // RVA: 0x135D730
        public void set_giftedBy(){} // RVA: 0xBC5AD0
        public void get_giftedByDisplayName(){} // RVA: 0xBC5B30
        public void set_giftedByDisplayName(){} // RVA: 0xBC5B40
        public void get_licenseGroups(){} // RVA: 0xBC5BA0
        public void set_licenseGroups(){} // RVA: 0xBC5BB0
        public void get_vendorData(){} // RVA: 0xBAE5A0
        public void set_vendorData(){} // RVA: 0xBAE5B0
        public void ToString(){} // RVA: 0xA59AD80
        public void .ctor(){} // RVA: 0xA59B2A0
    }

    public class ApiVRChatSubscriptionBaseResponse : ApiModel
    {
        public object _error;

        // ── Methods ──
        public void get_error(){} // RVA: 0xBBFF90
        public void set_error(){} // RVA: 0xBBFFA0
        public void .ctor(){} // RVA: 0xA59AD30
    }

    public class ApiVRChatSubscriptionDetails : ApiModel
    {
        public object _amount;
        public object _description;
        public object _period;

        // ── Methods ──
        public void get_amount(){} // RVA: 0x2536460
        public void set_amount(){} // RVA: 0x25406E0
        public void get_description(){} // RVA: 0xC10050
        public void set_description(){} // RVA: 0xC10060
        public void get_period(){} // RVA: 0xCD3320
        public void set_period(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA59ACE0
    }

    public class ApiVRChatSubscriptionError : Object
    {
        public object _status_code;
        public object _message;

        // ── Methods ──
        public void get_status_code(){} // RVA: 0xB8F8F0
        public void set_status_code(){} // RVA: 0xB460A0
        public void get_message(){} // RVA: 0xB465B0
        public void set_message(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ApiViewfinderSkin : ApiModel
    {
        public object _name;
        public object _assetBundleId;

        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_assetBundleId(){} // RVA: 0xC10050
        public void set_assetBundleId(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA59A8F0
    }

    public class ApiWarpEffectSkin : ApiModel
    {
        public object _name;
        public object _assetBundleId;

        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_assetBundleId(){} // RVA: 0xC10050
        public void set_assetBundleId(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA59B3E0
    }

}