// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 100
// Methods: 1378

namespace VRC.Core
{
    public class API2FA : ApiModel
    {
        // ── Methods ──
        public void get_requiresTwoFactorAuth(){} // RVA: 0x7A8153390
        public void set_requiresTwoFactorAuth(){} // RVA: 0x7A81533A0
        public void get_scope(){} // RVA: 0x7A81A00E0
        public void set_scope(){} // RVA: 0x7A81A00F0
        public void get_ticket(){} // RVA: 0x7A82C2060
        public void set_ticket(){} // RVA: 0x7A82C0530
        public void TimeBasedOneTimePasswordSupported(){} // RVA: 0x7B16928C0
        public void EmailBasedOneTimePasswordSupported(){} // RVA: 0x7B1692920
        public void OneTimePasswordSupported(){} // RVA: 0x7B1692980
        public void SmsSupported(){} // RVA: 0x7B16929E0
        public void ToString(){} // RVA: 0x7B1692A40
        public void .ctor(){} // RVA: 0x7B1692CA0
    }

    public class APIActivationSuccessfulTargetResult : ApiModel
    {
        // ── Methods ──
        public void get_userId(){} // RVA: 0x7A8153390
        public void set_userId(){} // RVA: 0x7A81533A0
        public void get_gifts(){} // RVA: 0x7A8EA8210
        public void set_gifts(){} // RVA: 0x7A8270510
        public void get_isFriend(){} // RVA: 0x7A8EE1FF0
        public void set_isFriend(){} // RVA: 0x7AD81A310
        public void .ctor(){} // RVA: 0x7B16AEEC0
    }

    public class APICalendarEntry : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17517D0
        public void get_ownerId(){} // RVA: 0x7A8153390
        public void set_ownerId(){} // RVA: 0x7A81533A0
        public void get_accessType(){} // RVA: 0x7A8EA8210
        public void set_accessType(){} // RVA: 0x7A8270510
        public void get_startsAt(){} // RVA: 0x7A82C2060
        public void set_startsAt(){} // RVA: 0x7AD89C580
        public void get_endsAt(){} // RVA: 0x7A825E100
        public void set_endsAt(){} // RVA: 0x7A9D11630
        public void get_title(){} // RVA: 0x7A81163D0
        public void set_title(){} // RVA: 0x7A825E460
        public void get_description(){} // RVA: 0x7A8555100
        public void set_description(){} // RVA: 0x7A8919DE0
        public void get_category(){} // RVA: 0x7A87D9C10
        public void set_category(){} // RVA: 0x7A8744720
        public void get_shortCode(){} // RVA: 0x7A87C5850
        public void set_shortCode(){} // RVA: 0x7A87446C0
        public void get_type(){} // RVA: 0x7A87D9480
        public void set_type(){} // RVA: 0x7A8881790
        public void get_isDraft(){} // RVA: 0x7A94ED040
        public void set_isDraft(){} // RVA: 0x7A94F0290
        public void get_imageId(){} // RVA: 0x7A8142680
        public void set_imageId(){} // RVA: 0x7A8142690
        public void get_imageUrl(){} // RVA: 0x7A81426F0
        public void set_imageUrl(){} // RVA: 0x7A8142700
        public void get_roleIds(){} // RVA: 0x7A82305B0
        public void set_roleIds(){} // RVA: 0x7A82305C0
        public void get_tags(){} // RVA: 0x7A81F50F0
        public void set_tags(){} // RVA: 0x7A81F5100
        public void get_platforms(){} // RVA: 0x7A8854870
        public void set_platforms(){} // RVA: 0x7A8158EF0
        public void get_languages(){} // RVA: 0x7A8158F50
        public void set_languages(){} // RVA: 0x7A8158F60
        public void get_parentId(){} // RVA: 0x7A8158FC0
        public void set_parentId(){} // RVA: 0x7A8158FD0
        public void get_hostEarlyJoinMinutes(){} // RVA: 0x7AB52C0D0
        public void set_hostEarlyJoinMinutes(){} // RVA: 0x7AE0660F0
        public void get_guestEarlyJoinMinutes(){} // RVA: 0x7ABBECE40
        public void set_guestEarlyJoinMinutes(){} // RVA: 0x7ABBECE50
        public void get_closeInstanceAfterEndMinutes(){} // RVA: 0x7AF0B6750
        public void set_closeInstanceAfterEndMinutes(){} // RVA: 0x7B126CF70
        public void get_usesInstanceOverflow(){} // RVA: 0x7B1701000
        public void set_usesInstanceOverflow(){} // RVA: 0x7B1701010
        public void get_deletedAt(){} // RVA: 0x7A8852A30
        public void set_deletedAt(){} // RVA: 0x7A94BD7B0
        public void get_userInterest(){} // RVA: 0x7A884DED0
        public void set_userInterest(){} // RVA: 0x7A8AB6790
        public void get_featured(){} // RVA: 0x7A8401420
        public void set_featured(){} // RVA: 0x7A84017D0
        public void get_interestedUserCount(){} // RVA: 0x7AED8BDB0
        public void set_interestedUserCount(){} // RVA: 0x7AED8BDC0
        public void UpdateData(){} // RVA: 0x7B1751820
        public void WriteField(){} // RVA: 0x7B1751FF0
    }

    public class APICalendarEntryUserInterest : ApiModel
    {
        // ── Methods ──
        public void get_isFollowing(){} // RVA: 0x7A81A00C0
        public void set_isFollowing(){} // RVA: 0x7A81A00D0
        public void get_createdAt(){} // RVA: 0x7A81A00E0
        public void set_createdAt(){} // RVA: 0x7A9D11610
        public void get_updatedAt(){} // RVA: 0x7A82C2060
        public void set_updatedAt(){} // RVA: 0x7AD89C580
        public void .ctor(){} // RVA: 0x7B1752480
    }

    public class APIEmoji : ApiModel
    {
        // ── Methods ──
        public void get_fileId(){} // RVA: 0x7A8153390
        public void set_fileId(){} // RVA: 0x7A81533A0
        public void get_imageUrl(){} // RVA: 0x7A81A00E0
        public void set_imageUrl(){} // RVA: 0x7A81A00F0
        public void get_animationStyle(){} // RVA: 0x7A82C2060
        public void set_animationStyle(){} // RVA: 0x7A82C0530
        public void get_maskTag(){} // RVA: 0x7A825E100
        public void set_maskTag(){} // RVA: 0x7A825F860
        public void get_animated(){} // RVA: 0x7A90FA160
        public void set_animated(){} // RVA: 0x7A90F9520
        public void get_frames(){} // RVA: 0x7AB40DAB0
        public void set_frames(){} // RVA: 0x7ABA6C530
        public void get_framesOverTime(){} // RVA: 0x7A846C760
        public void set_framesOverTime(){} // RVA: 0x7A8CCD330
        public void get_loopStyle(){} // RVA: 0x7A87D9C10
        public void set_loopStyle(){} // RVA: 0x7A8744720
        public void get_assetBundleId(){} // RVA: 0x7A87C5850
        public void set_assetBundleId(){} // RVA: 0x7A87446C0
        public void get_premium(){} // RVA: 0x7A835F4E0
        public void set_premium(){} // RVA: 0x7A8357960
        public void UploadEmoji(){} // RVA: 0x7B16A4BD0
        public void Fetch(){} // RVA: 0x7B16A5230
        public void .ctor(){} // RVA: 0x7B16A5560
        public void <Fetch>g__ParseData|45_0(){} // RVA: 0x7B16A55D0
    }

    public class APIGiftActivationResult : ApiModel
    {
        // ── Methods ──
        public void get_dropValidationToken(){} // RVA: 0x7A8153390
        public void set_dropValidationToken(){} // RVA: 0x7A81533A0
        public void get_giftValidationToken(){} // RVA: 0x7A81A00E0
        public void set_giftValidationToken(){} // RVA: 0x7A81A00F0
        public void get_successfulGifts(){} // RVA: 0x7A82C2060
        public void set_successfulGifts(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7B16AEE70
    }

    public class APIGiftBundle : ApiModel
    {
        // ── Methods ──
        public void get_steamItemId(){} // RVA: 0x7A8153390
        public void set_steamItemId(){} // RVA: 0x7A81533A0
        public void get_oculusSku(){} // RVA: 0x7A81A00E0
        public void set_oculusSku(){} // RVA: 0x7A81A00F0
        public void get_googleProductId(){} // RVA: 0x7A82C2060
        public void set_googleProductId(){} // RVA: 0x7A82C0530
        public void get_googlePlanId(){} // RVA: 0x7A825E100
        public void set_googlePlanId(){} // RVA: 0x7A825F860
        public void get_picoSku(){} // RVA: 0x7A81163D0
        public void set_picoSku(){} // RVA: 0x7A825E460
        public void get_amount(){} // RVA: 0x7A846C760
        public void set_amount(){} // RVA: 0x7A8CCD330
        public void get_description(){} // RVA: 0x7A87D9C10
        public void set_description(){} // RVA: 0x7A8744720
        public void get_period(){} // RVA: 0x7A87C5850
        public void set_period(){} // RVA: 0x7A87446C0
        public void get_periodAmount(){} // RVA: 0x7A8A69800
        public void set_periodAmount(){} // RVA: 0x7A8A67200
        public void get_tier(){} // RVA: 0x7ABA39100
        public void set_tier(){} // RVA: 0x7ABA39110
        public void get_bulkSize(){} // RVA: 0x7A9EEB080
        public void set_bulkSize(){} // RVA: 0x7ADE0AE80
        public void get_discountPercentage(){} // RVA: 0x7ABBEC920
        public void set_discountPercentage(){} // RVA: 0x7ABBEC930
        public void get_licenseGroups(){} // RVA: 0x7A8142680
        public void set_licenseGroups(){} // RVA: 0x7A8142690
        public void .ctor(){} // RVA: 0x7B16AEDD0
    }

    public class APIProductGifting : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class APIProductGiftingCheck : ApiModel
    {
        // ── Methods ──
        public void get_Eligible(){} // RVA: 0x7A81A00C0
        public void set_Eligible(){} // RVA: 0x7A81A00D0
        public void get_Reason(){} // RVA: 0x7A81A00E0
        public void set_Reason(){} // RVA: 0x7A81A00F0
        public void get_EligibleProducts(){} // RVA: 0x7A82C2060
        public void set_EligibleProducts(){} // RVA: 0x7A82C0530
        public void get_IneligibleProducts(){} // RVA: 0x7A825E100
        public void set_IneligibleProducts(){} // RVA: 0x7A825F860
        public void Check(){} // RVA: 0x7B1700050
        public void .ctor(){} // RVA: 0x7B1700620
    }

    public class APIPurchasedGiftBundle : ApiModel
    {
        // ── Methods ──
        public void get_transactionId(){} // RVA: 0x7A8153390
        public void set_transactionId(){} // RVA: 0x7A81533A0
        public void get_store(){} // RVA: 0x7A81A00E0
        public void set_store(){} // RVA: 0x7A81A00F0
        public void get_steamItemId(){} // RVA: 0x7A82C2060
        public void set_steamItemId(){} // RVA: 0x7A82C0530
        public void get_oculusSku(){} // RVA: 0x7A825E100
        public void set_oculusSku(){} // RVA: 0x7A825F860
        public void get_googleProductId(){} // RVA: 0x7A81163D0
        public void set_googleProductId(){} // RVA: 0x7A825E460
        public void get_googlePlanId(){} // RVA: 0x7A8555100
        public void set_googlePlanId(){} // RVA: 0x7A8919DE0
        public void get_picoSku(){} // RVA: 0x7A87D9C10
        public void set_picoSku(){} // RVA: 0x7A8744720
        public void get_amount(){} // RVA: 0x7A9B79A40
        public void set_amount(){} // RVA: 0x7A9B79A00
        public void get_description(){} // RVA: 0x7A87D9480
        public void set_description(){} // RVA: 0x7A8881790
        public void get_period(){} // RVA: 0x7A8142610
        public void set_period(){} // RVA: 0x7A8142620
        public void get_consumed(){} // RVA: 0x7A94FA690
        public void set_consumed(){} // RVA: 0x7A94F9900
        public void get_status(){} // RVA: 0x7A81426F0
        public void set_status(){} // RVA: 0x7A8142700
        public void get_created_at(){} // RVA: 0x7A82305B0
        public void set_created_at(){} // RVA: 0x7A82305C0
        public void get_updated_at(){} // RVA: 0x7A81F50F0
        public void set_updated_at(){} // RVA: 0x7A81F5100
        public void get_isBulkGift(){} // RVA: 0x7A90B4C50
        public void set_isBulkGift(){} // RVA: 0x7ADF1BE00
        public void get_targets(){} // RVA: 0x7A8158F50
        public void set_targets(){} // RVA: 0x7A8158F60
        public void get_bulkSize(){} // RVA: 0x7A9AAEF70
        public void set_bulkSize(){} // RVA: 0x7AE066210
        public void get_discountPercentage(){} // RVA: 0x7A9AAC1C0
        public void set_discountPercentage(){} // RVA: 0x7AE0660E0
        public void get_totalConsumed(){} // RVA: 0x7AB52C0D0
        public void set_totalConsumed(){} // RVA: 0x7AE0660F0
        public void get_totalUnconsumed(){} // RVA: 0x7ABBECE40
        public void set_totalUnconsumed(){} // RVA: 0x7ABBECE50
        public void get_failures(){} // RVA: 0x7AF0B6750
        public void set_failures(){} // RVA: 0x7B126CF70
        public void .ctor(){} // RVA: 0x7B16AEE20
    }

    public class APIResponseHandler : Object
    {
        // ── Methods ──
        public void HandleResponse(){} // RVA: 0x7B1708F20
        public void extractResponseErrorMessage(){} // RVA: 0x7B1709150
        public void RetryRequest(){} // RVA: 0x7B17092C0
        public void .cctor(){} // RVA: 0x7B1709A30
    }

    public class APISticker : ApiModel
    {
        // ── Methods ──
        public void get_fileId(){} // RVA: 0x7A8153390
        public void set_fileId(){} // RVA: 0x7A81533A0
        public void get_imageUrl(){} // RVA: 0x7A81A00E0
        public void set_imageUrl(){} // RVA: 0x7A81A00F0
        public void get_specialEffect(){} // RVA: 0x7A82C2060
        public void set_specialEffect(){} // RVA: 0x7A82C0530
        public void get_animationStyle(){} // RVA: 0x7A825E100
        public void set_animationStyle(){} // RVA: 0x7A825F860
        public void get_maskTag(){} // RVA: 0x7A81163D0
        public void set_maskTag(){} // RVA: 0x7A825E460
        public void get_animated(){} // RVA: 0x7A9101D40
        public void set_animated(){} // RVA: 0x7A91004C0
        public void get_frames(){} // RVA: 0x7A846C750
        public void set_frames(){} // RVA: 0x7A869B9F0
        public void get_framesOverTime(){} // RVA: 0x7A9B79A20
        public void set_framesOverTime(){} // RVA: 0x7A9B794B0
        public void get_loopStyle(){} // RVA: 0x7A87C5850
        public void set_loopStyle(){} // RVA: 0x7A87446C0
        public void get_assetBundleId(){} // RVA: 0x7A87D9480
        public void set_assetBundleId(){} // RVA: 0x7A8881790
        public void UploadSticker(){} // RVA: 0x7B170D7D0
        public void .ctor(){} // RVA: 0x7B170DDE0
    }

    public class APISubscription : ApiModel
    {
        // ── Methods ──
        public void get_response(){} // RVA: 0x7A8153390
        public void set_response(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7B170DF90
    }

    public class APITutorial : ApiModel
    {
        // ── Methods ──
        public void get_IsTutorialCompleted(){} // RVA: 0x7A81A00C0
        public void set_IsTutorialCompleted(){} // RVA: 0x7A81A00D0
        public void get_CompletedAnyTutorial(){} // RVA: 0x7ACF04410
        public void set_CompletedAnyTutorial(){} // RVA: 0x7ACF040C0
        public void get_TutorialKey(){} // RVA: 0x7A81A00E0
        public void set_TutorialKey(){} // RVA: 0x7A81A00F0
        public void LoadTutorial(){} // RVA: 0x7B17109A0
        public void .ctor(){} // RVA: 0x7B1710CB0
    }

    public class ApiAccountUpgrade : ApiModel
    {
        // ── Methods ──
        public void get_isUpgrading(){} // RVA: 0x7A81A00C0
        public void set_isUpgrading(){} // RVA: 0x7A81A00D0
        public void get_subscribedToMarketingEmails(){} // RVA: 0x7ACF04410
        public void set_subscribedToMarketingEmails(){} // RVA: 0x7ACF040C0
        public void get_hasEmail(){} // RVA: 0x7AD8E6CE0
        public void set_hasEmail(){} // RVA: 0x7AD8E6CF0
        public void get_emailVerified(){} // RVA: 0x7AE8B9BA0
        public void set_emailVerified(){} // RVA: 0x7AE8B9BB0
        public void .ctor(){} // RVA: 0x7B1692CF0
        public void GetUpgradeStatus(){} // RVA: 0x7B1692DB0
        public void UpgradeWithEmail(){} // RVA: 0x7B16930D0
        public void ParseErrorCode(){} // RVA: 0x7B1693620
    }

    public class ApiAvatarLook : ApiModel
    {
        // ── Methods ──
        public void get_avatarId(){} // RVA: 0x7A8153390
        public void set_avatarId(){} // RVA: 0x7A81533A0
        public void get_attachments(){} // RVA: 0x7A81A00E0
        public void set_attachments(){} // RVA: 0x7A81A00F0
        public void GetLook(){} // RVA: 0x7B1699200
        public void UpdateThumbnail(){} // RVA: 0x7B16993A0
        public void UpdateLook(){} // RVA: 0x7B16994F0
        public void CreateLook(){} // RVA: 0x7B1699640
        public void WearLook(){} // RVA: 0x7B16997E0
        public void UploadThumbnail(){} // RVA: 0x7B1699B30
        public void .ctor(){} // RVA: 0x7B1699CD0
    }

    public class ApiAvatarModeration : ApiModel
    {
        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7A9A93870
        public void set_moderationType(){} // RVA: 0x7A9A93880
        public void get_targetAvatarId(){} // RVA: 0x7A81A00E0
        public void set_targetAvatarId(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B169D7B0
        public void ShouldCache(){} // RVA: 0x7A80D7320
        public void ReadField(){} // RVA: 0x7B169D870
        public void WriteField(){} // RVA: 0x7B169DBF0
        public void SendModeration(){} // RVA: 0x7B169DDD0
        public void DeleteModeration(){} // RVA: 0x7B169E010
        public void FetchAllMine(){} // RVA: 0x7B169E530
        public void FetchList(){} // RVA: 0x7B169E590
        public void ModerationTypeToAPIString(){} // RVA: 0x7B169E880
    }

    public class ApiAvatarPart : ApiContentModel`1
    {
        // ── Methods ──
        public void get__created_at(){} // RVA: 0x7A8854870
        public void set__created_at(){} // RVA: 0x7B169EC30
        public void get__updated_at(){} // RVA: 0x7A8158F50
        public void set__updated_at(){} // RVA: 0x7B169EC40
        public void get_unityPackages(){} // RVA: 0x7A8158FC0
        public void set_unityPackages(){} // RVA: 0x7A8158FD0
        public void get_BundleSignature(){} // RVA: 0x7A8142870
        public void set_BundleSignature(){} // RVA: 0x7A8142880
        public void .ctor(){} // RVA: 0x7B169EC50
        public void SetApiFieldsFromJson(){} // RVA: 0x7B169EDB0
        public void ProcessUnityPackages(){} // RVA: 0x7B169EE90
        public void WriteField(){} // RVA: 0x7B169F550
        public void CopyDeserializedValuesTo(){} // RVA: 0x7B169F610
        public void GetAccessory(){} // RVA: 0x7B169F810
        public void FetchList(){} // RVA: 0x7B169F9B0
    }

    public class ApiAvatarPartItemMetadata : ApiModel
    {
        // ── Methods ──
        public void get_avatarPartId(){} // RVA: 0x7A8153390
        public void set_avatarPartId(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7B16A04C0
    }

    public class ApiAvatarStyle : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16A0510
        public void get_styleName(){} // RVA: 0x7A8153390
        public void set_styleName(){} // RVA: 0x7A81533A0
        public void get_lastModifiedById(){} // RVA: 0x7A81A00E0
        public void set_lastModifiedById(){} // RVA: 0x7A81A00F0
        public void get_lastModifiedByDisplayName(){} // RVA: 0x7A82C2060
        public void set_lastModifiedByDisplayName(){} // RVA: 0x7A82C0530
        public void get_created_at(){} // RVA: 0x7A825E100
        public void set_created_at(){} // RVA: 0x7A9D11630
        public void get_updated_at(){} // RVA: 0x7A81163D0
        public void set_updated_at(){} // RVA: 0x7A887B550
    }

    public class ApiBindingCommandReference : ApiModel
    {
        // ── Methods ──
        public void get_command(){} // RVA: 0x7A8153390
        public void set_command(){} // RVA: 0x7A81533A0
        public void get_parameters(){} // RVA: 0x7A81A00E0
        public void set_parameters(){} // RVA: 0x7A81A00F0
        public void get_name(){} // RVA: 0x7A82C2060
        public void set_name(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7B16A0620
        public void ToString(){} // RVA: 0x7B16A06C0
    }

    public class ApiByteContainer : ApiContainer
    {
        // ── Methods ──
        public void get_ResponseBytes(){} // RVA: 0x7B1708230
        public void Validate(){} // RVA: 0x7B17082A0
        public void .ctor(){} // RVA: 0x7B1707BF0
    }

    public class ApiCacheObject
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7A7E01900
        public void GetLifeSpan(){} // RVA: 0x7A7E155B0
        public void Clone(){} // RVA: 0x7A7E00680
        public void set_ExpiryTime(){} // RVA: 0x7A7E18800
    }

    public class ApiCalendarEntriesContainer : ApiModel
    {
        // ── Methods ──
        public void get_hasNext(){} // RVA: 0x7A81A00C0
        public void set_hasNext(){} // RVA: 0x7A81A00D0
        public void get_results(){} // RVA: 0x7A81A00E0
        public void set_results(){} // RVA: 0x7A81A00F0
        public void get_totalCount(){} // RVA: 0x7A989D5C0
        public void set_totalCount(){} // RVA: 0x7A98A0B60
        public void get_nextCursor(){} // RVA: 0x7A825E100
        public void set_nextCursor(){} // RVA: 0x7A825F860
        public void .ctor(){} // RVA: 0x7B1752430
    }

    public class ApiCalendarResults : ApiModel
    {
        // ── Methods ──
        public void get_results(){} // RVA: 0x7A8153390
        public void set_results(){} // RVA: 0x7A81533A0
        public void get_totalCount(){} // RVA: 0x7A8EA8210
        public void set_totalCount(){} // RVA: 0x7A8270510
        public void .ctor(){} // RVA: 0x7B170D2A0
    }

    public class ApiCampaign : ApiModel
    {
        // ── Methods ──
        public void get_participantCount(){} // RVA: 0x7A9A93870
        public void set_participantCount(){} // RVA: 0x7A9A93880
        public void get_friendsContributing(){} // RVA: 0x7A81A00E0
        public void set_friendsContributing(){} // RVA: 0x7A81A00F0
        public void get_endsAt(){} // RVA: 0x7A82C2060
        public void set_endsAt(){} // RVA: 0x7AD89C580
        public void get_raisedAmountUsd(){} // RVA: 0x7A8D6DF30
        public void set_raisedAmountUsd(){} // RVA: 0x7A8D6DF20
        public void get_userGiftCount(){} // RVA: 0x7A9A18C60
        public void set_userGiftCount(){} // RVA: 0x7A9A18CB0
        public void get_giftGoalUsd(){} // RVA: 0x7A897F560
        public void set_giftGoalUsd(){} // RVA: 0x7A8980300
        public void get_goalSuccess(){} // RVA: 0x7A813FAC0
        public void set_goalSuccess(){} // RVA: 0x7A813FAD0
        public void get_rewards(){} // RVA: 0x7A8555100
        public void set_rewards(){} // RVA: 0x7A8919DE0
        public void GetCampaignAsync(){} // RVA: 0x7B16A2520
        public void .ctor(){} // RVA: 0x7B16A26C0
    }

    public class ApiCampaignReward : ApiModel
    {
        // ── Methods ──
        public void get_title(){} // RVA: 0x7A8153390
        public void set_title(){} // RVA: 0x7A81533A0
        public void get_description(){} // RVA: 0x7A81A00E0
        public void set_description(){} // RVA: 0x7A81A00F0
        public void get_imageUrl(){} // RVA: 0x7A82C2060
        public void set_imageUrl(){} // RVA: 0x7A82C0530
        public void get_unlocked(){} // RVA: 0x7A8361EA0
        public void set_unlocked(){} // RVA: 0x7A835F4F0
        public void get_progress(){} // RVA: 0x7A81163D0
        public void set_progress(){} // RVA: 0x7A825E460
        public void .ctor(){} // RVA: 0x7B16A2F40
    }

    public class ApiCampaignRewardProgress : ApiModel
    {
        // ── Methods ──
        public void get_current(){} // RVA: 0x7A9A93870
        public void set_current(){} // RVA: 0x7A9A93880
        public void get_max(){} // RVA: 0x7A9A93890
        public void set_max(){} // RVA: 0x7A9A938A0
        public void .ctor(){} // RVA: 0x7B16A2F90
    }

    public class ApiContainer : Object
    {
        // ── Methods ──
        public void get_Cookies(){} // RVA: 0x7A80F2570
        public void set_Cookies(){} // RVA: 0x7A80D8E20
        public void get_Populated(){} // RVA: 0x7A80F26D0
        public void set_Populated(){} // RVA: 0x7A80F26E0
        public void get_PassedValidation(){} // RVA: 0x7A8475E20
        public void set_PassedValidation(){} // RVA: 0x7A8D0E640
        public void get_Code(){} // RVA: 0x7A9739200
        public void set_Code(){} // RVA: 0x7A9746990
        public void get_Text(){} // RVA: 0x7A81052C0
        public void set_Text(){} // RVA: 0x7A81052D0
        public void get_Data(){} // RVA: 0x7A8105330
        public void set_Data(){} // RVA: 0x7A80D8E80
        public void get_DataTimestamp(){} // RVA: 0x7A8261690
        public void set_DataTimestamp(){} // RVA: 0x7A9A79990
        public void get_CreatedAt(){} // RVA: 0x7A8292C30
        public void set_CreatedAt(){} // RVA: 0x7A8296DE0
        public void get_Error(){} // RVA: 0x7B17083F0
        public void set_Error(){} // RVA: 0x7B1708420
        public void get_Model(){} // RVA: 0x7A8152D80
        public void set_Model(){} // RVA: 0x7A8152D90
        public void .ctor(){} // RVA: 0x7B1708780
        public void setFromContainer(){} // RVA: 0x7B1708850
        public void Validate(){} // RVA: 0x7B1708A60
        public void GetErrorMessage(){} // RVA: 0x7B1708AB0
        public void OnComplete(){} // RVA: 0x7B1708C60
    }

    public class ApiContentModel`1 : ApiModel
    {
        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7AB6D6EA0
        public void ShouldCache(){} // RVA: 0x7AB6D71D0
        public void GetLifeSpan(){} // RVA: 0x7AB6D7230
        public void get_name(){} // RVA: 0x7A8153390
        public void set_name(){} // RVA: 0x7A81533A0
        public void get_imageUrl(){} // RVA: 0x7A81A00E0
        public void set_imageUrl(){} // RVA: 0x7A81A00F0
        public void get_authorName(){} // RVA: 0x7A82C2060
        public void set_authorName(){} // RVA: 0x7A82C0530
        public void get_authorId(){} // RVA: 0x7A825E100
        public void set_authorId(){} // RVA: 0x7A825F860
        public void get_assetUrl(){} // RVA: 0x7A81163D0
        public void set_assetUrl(){} // RVA: 0x7A825E460
        public void get_description(){} // RVA: 0x7A8555100
        public void set_description(){} // RVA: 0x7A8919DE0
        public void get_tags(){} // RVA: 0x7A87D9C10
        public void set_tags(){} // RVA: 0x7A8744720
        public void get_thumbnailImageUrl(){} // RVA: 0x7A87C5850
        public void set_thumbnailImageUrl(){} // RVA: 0x7A87446C0
        public void get_version(){} // RVA: 0x7A8A69800
        public void set_version(){} // RVA: 0x7A8A67200
        public void get_releaseStatus(){} // RVA: 0x7A8142610
        public void set_releaseStatus(){} // RVA: 0x7A8142620
        public void get_featured(){} // RVA: 0x7A94FA690
        public void set_featured(){} // RVA: 0x7A94F9900
        public void get_unityPackageUpdated(){} // RVA: 0x7AB6D7240
        public void set_unityPackageUpdated(){} // RVA: 0x7AB6D7250
        public void get_unityVersion(){} // RVA: 0x7A81426F0
        public void set_unityVersion(){} // RVA: 0x7A8142700
        public void get_apiVersion(){} // RVA: 0x7A87BD4F0
        public void set_apiVersion(){} // RVA: 0x7AB6D7260
        public void get_platform(){} // RVA: 0x7A81F50F0
        public void set_platform(){} // RVA: 0x7A81F5100
        public void get_assetVersion(){} // RVA: 0x7AB6D7270
        public void set_assetVersion(){} // RVA: 0x7AB6D7320
        public void .ctor(){} // RVA: 0x7AB6D73B0
        public void ReadField(){} // RVA: 0x7AB6D7480
        public void Get(){} // RVA: 0x7AB6D7650
        public void FetchList(){} // RVA: 0x7AB6D7D90
        public void AddLocal(){} // RVA: 0x7AB6D9A60
        public void IsLocalById(){} // RVA: 0x7AB6D9B90
        public void get_IsLocal(){} // RVA: 0x7AB6D9C90
        public void Save(){} // RVA: 0x7AB6D9D70
        public void SaveReleaseStatus(){} // RVA: 0x7AB6D9DF0
        public void GetAssetUrl(){} // RVA: 0x7A81163D0
        public void HasTag(){} // RVA: 0x7AB6DA330
        public void AddTag(){} // RVA: 0x7AB6DA3A0
        public void RemoveTag(){} // RVA: 0x7AB6DA440
        public void UpdateVersionAndPlatform(){} // RVA: 0x7AB6DA5A0
        public void MakeRequestEndpoint(){} // RVA: 0x7AB6DA730
        public void .cctor(){} // RVA: 0x7AB6DA760
    }

    public class ApiContentModel`1 : ApiModel
    {
        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7AB6D6EA0
        public void ShouldCache(){} // RVA: 0x7AB6D71D0
        public void GetLifeSpan(){} // RVA: 0x7AB6D7230
        public void get_name(){} // RVA: 0x7A8153390
        public void set_name(){} // RVA: 0x7A81533A0
        public void get_imageUrl(){} // RVA: 0x7A81A00E0
        public void set_imageUrl(){} // RVA: 0x7A81A00F0
        public void get_authorName(){} // RVA: 0x7A82C2060
        public void set_authorName(){} // RVA: 0x7A82C0530
        public void get_authorId(){} // RVA: 0x7A825E100
        public void set_authorId(){} // RVA: 0x7A825F860
        public void get_assetUrl(){} // RVA: 0x7A81163D0
        public void set_assetUrl(){} // RVA: 0x7A825E460
        public void get_description(){} // RVA: 0x7A8555100
        public void set_description(){} // RVA: 0x7A8919DE0
        public void get_tags(){} // RVA: 0x7A87D9C10
        public void set_tags(){} // RVA: 0x7A8744720
        public void get_thumbnailImageUrl(){} // RVA: 0x7A87C5850
        public void set_thumbnailImageUrl(){} // RVA: 0x7A87446C0
        public void get_version(){} // RVA: 0x7A8A69800
        public void set_version(){} // RVA: 0x7A8A67200
        public void get_releaseStatus(){} // RVA: 0x7A8142610
        public void set_releaseStatus(){} // RVA: 0x7A8142620
        public void get_featured(){} // RVA: 0x7A94FA690
        public void set_featured(){} // RVA: 0x7A94F9900
        public void get_unityPackageUpdated(){} // RVA: 0x7AB6D7240
        public void set_unityPackageUpdated(){} // RVA: 0x7AB6D7250
        public void get_unityVersion(){} // RVA: 0x7A81426F0
        public void set_unityVersion(){} // RVA: 0x7A8142700
        public void get_apiVersion(){} // RVA: 0x7A87BD4F0
        public void set_apiVersion(){} // RVA: 0x7AB6D7260
        public void get_platform(){} // RVA: 0x7A81F50F0
        public void set_platform(){} // RVA: 0x7A81F5100
        public void get_assetVersion(){} // RVA: 0x7AB6D7270
        public void set_assetVersion(){} // RVA: 0x7AB6D7320
        public void .ctor(){} // RVA: 0x7AB6D73B0
        public void ReadField(){} // RVA: 0x7AB6D7480
        public void Get(){} // RVA: 0x7AB6D7650
        public void FetchList(){} // RVA: 0x7AB6D7D90
        public void AddLocal(){} // RVA: 0x7AB6D9A60
        public void IsLocalById(){} // RVA: 0x7AB6D9B90
        public void get_IsLocal(){} // RVA: 0x7AB6D9C90
        public void Save(){} // RVA: 0x7AB6D9D70
        public void SaveReleaseStatus(){} // RVA: 0x7AB6D9DF0
        public void GetAssetUrl(){} // RVA: 0x7A81163D0
        public void HasTag(){} // RVA: 0x7AB6DA330
        public void AddTag(){} // RVA: 0x7AB6DA3A0
        public void RemoveTag(){} // RVA: 0x7AB6DA440
        public void UpdateVersionAndPlatform(){} // RVA: 0x7AB6DA5A0
        public void MakeRequestEndpoint(){} // RVA: 0x7AB6DA730
        public void .cctor(){} // RVA: 0x7AB6DA760
    }

    public class ApiCredentials : Object
    {
        // ── Methods ──
        public void Clear(){} // RVA: 0x7B17524D0
        public void SetProfileIndex(){} // RVA: 0x7B1752500
        public void SetString(){} // RVA: 0x7B1752580
        public void GetString(){} // RVA: 0x7B17527D0
        public void Load(){} // RVA: 0x7B17529C0
        public void SetHumanName(){} // RVA: 0x7B17530F0
        public void Set(){} // RVA: 0x7B1753200
        public void Set2faToken(){} // RVA: 0x7B17537F0
        public void GetHumanName(){} // RVA: 0x7B17539D0
        public void GetAuthToken(){} // RVA: 0x7B1753A10
        public void GetTwoFactorAuthToken(){} // RVA: 0x7B1753A50
        public void GetAuthTokenCookie(){} // RVA: 0x7B1753A90
        public void GetTwoFactorAuthTokenCookie(){} // RVA: 0x7B1753AD0
        public void GetAuthTokenProvider(){} // RVA: 0x7B1753B10
        public void GetAuthTokenProviderUserId(){} // RVA: 0x7B1753B50
        public void IsLoaded(){} // RVA: 0x7B1753B90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ApiDictContainer : ApiContainer
    {
        // ── Methods ──
        public void get_cacheLifetime(){} // RVA: 0x7A81E8E60
        public void set_cacheLifetime(){} // RVA: 0x7A8D9F8A0
        public void get_ExpiryTime(){} // RVA: 0x7AB490FA0
        public void set_ExpiryTime(){} // RVA: 0x7AB491430
        public void get_requiredFields(){} // RVA: 0x7A82C2060
        public void set_requiredFields(){} // RVA: 0x7A82C0530
        public void get_ResponseDictionary(){} // RVA: 0x7B1707090
        public void .ctor(){} // RVA: 0x7B1707270
        public void Validate(){} // RVA: 0x7B17072E0
        public void ShouldCache(){} // RVA: 0x7B1707630
        public void ShouldClearOnLevelLoad(){} // RVA: 0x7A80D7320
        public void GetLifeSpan(){} // RVA: 0x7A81E8E60
        public void Clone(){} // RVA: 0x7B1707640
        public void .cctor(){} // RVA: 0x7B17076C0
        public void <Validate>b__17_0(){} // RVA: 0x7B1707790
    }

    public class ApiEconomyAccountStatus : ApiModel
    {
        // ── Methods ──
        public void get_UserID(){} // RVA: 0x7A8153390
        public void set_UserID(){} // RVA: 0x7A81533A0
        public void get_Blocked(){} // RVA: 0x7A8153980
        public void set_Blocked(){} // RVA: 0x7A8153990
        public void .ctor(){} // RVA: 0x7B1753BE0
    }

    public class ApiEconomyStatus : ApiModel
    {
        // ── Methods ──
        public void get_EconomyIsOnline(){} // RVA: 0x7A81A00C0
        public void set_EconomyIsOnline(){} // RVA: 0x7A81A00D0
        public void get_EconomyState(){} // RVA: 0x7A9A93890
        public void set_EconomyState(){} // RVA: 0x7A9A938A0
        public void .ctor(){} // RVA: 0x7B1753C30
    }

    public class ApiEconomyStore : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B16A3A80
        public void get_SellerId(){} // RVA: 0x7A8153390
        public void set_SellerId(){} // RVA: 0x7A81533A0
        public void get_SellerDisplayName(){} // RVA: 0x7A81A00E0
        public void set_SellerDisplayName(){} // RVA: 0x7A81A00F0
        public void get_WorldId(){} // RVA: 0x7A82C2060
        public void set_WorldId(){} // RVA: 0x7A82C0530
        public void get_GroupId(){} // RVA: 0x7A825E100
        public void set_GroupId(){} // RVA: 0x7A825F860
        public void get_StoreStatus(){} // RVA: 0x7A897F560
        public void set_StoreStatus(){} // RVA: 0x7A8980300
        public void get_DisplayName(){} // RVA: 0x7A8555100
        public void set_DisplayName(){} // RVA: 0x7A8919DE0
        public void get_Description(){} // RVA: 0x7A87D9C10
        public void set_Description(){} // RVA: 0x7A8744720
        public void get_Tags(){} // RVA: 0x7A87C5850
        public void set_Tags(){} // RVA: 0x7A87446C0
        public void get_Listings(){} // RVA: 0x7A87D9480
        public void set_Listings(){} // RVA: 0x7A8881790
        public void get_ListingIDs(){} // RVA: 0x7A8142610
        public void set_ListingIDs(){} // RVA: 0x7A8142620
        public void get_IsGroupStore(){} // RVA: 0x7B16A3AD0
        public void get_IsWorldStore(){} // RVA: 0x7B16A3AF0
        public void ReadField(){} // RVA: 0x7B16A3B10
        public void WriteField(){} // RVA: 0x7B16A3D50
        public void FetchStore(){} // RVA: 0x7B16A3EB0
    }

    public class ApiFieldAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A847A240
    }

    public class ApiGroupInstanceAnnouncement : ApiModel
    {
        // ── Methods ──
        public void get_title(){} // RVA: 0x7A8153390
        public void set_title(){} // RVA: 0x7A81533A0
        public void get_message(){} // RVA: 0x7A81A00E0
        public void set_message(){} // RVA: 0x7A81A00F0
        public void get_imageId(){} // RVA: 0x7A82C2060
        public void set_imageId(){} // RVA: 0x7A82C0530
        public void get_imageVersion(){} // RVA: 0x7A8D6DF30
        public void set_imageVersion(){} // RVA: 0x7A8D6DF20
        public void .ctor(){} // RVA: 0x7B1755630
        public void SendAnnouncement(){} // RVA: 0x7B17557B0
    }

    public class ApiImage : ApiFile
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7A80D7320
        public void FetchList(){} // RVA: 0x7B16AEFB0
        public void UploadImage(){} // RVA: 0x7B16AFB10
        public void .ctor(){} // RVA: 0x7B16AFF10
    }

    public class ApiInventoryBundle : ApiModel
    {
        // ── Methods ──
        public void get_inventoryItemsToInstantiate(){} // RVA: 0x7A8153390
        public void set_inventoryItemsToInstantiate(){} // RVA: 0x7A81533A0
        public void get_notificationDetails(){} // RVA: 0x7A81A00E0
        public void set_notificationDetails(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B16B1300
    }

    public class ApiInventoryBundleDrop : ApiModel
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A8153390
        public void set_name(){} // RVA: 0x7A81533A0
        public void get_authorId(){} // RVA: 0x7A81A00E0
        public void set_authorId(){} // RVA: 0x7A81A00F0
        public void get_targetGroup(){} // RVA: 0x7A82C2060
        public void set_targetGroup(){} // RVA: 0x7A82C0530
        public void get_templateIds(){} // RVA: 0x7A825E100
        public void set_templateIds(){} // RVA: 0x7A825F860
        public void get_startDropDate(){} // RVA: 0x7A81163D0
        public void set_startDropDate(){} // RVA: 0x7A887B550
        public void get_endDropDate(){} // RVA: 0x7A8555100
        public void set_endDropDate(){} // RVA: 0x7A9ABC8A0
        public void get_dropExpiryDate(){} // RVA: 0x7A87D9C10
        public void set_dropExpiryDate(){} // RVA: 0x7AD543B50
        public void get_status(){} // RVA: 0x7A87C5850
        public void set_status(){} // RVA: 0x7A87446C0
        public void get_tags(){} // RVA: 0x7A87D9480
        public void set_tags(){} // RVA: 0x7A8881790
        public void get_created_at(){} // RVA: 0x7A8142610
        public void set_created_at(){} // RVA: 0x7A9905F10
        public void get_updated_at(){} // RVA: 0x7A8142680
        public void set_updated_at(){} // RVA: 0x7A9906150
        public void get_notificationDetails(){} // RVA: 0x7A81426F0
        public void set_notificationDetails(){} // RVA: 0x7A8142700
        public void FetchCurrentlyActiveBundleDrops(){} // RVA: 0x7B16B1350
        public void .ctor(){} // RVA: 0x7B16B17A0
    }

    public class ApiInventoryItemContainer : ApiModel
    {
        // ── Methods ──
        public void get_data(){} // RVA: 0x7A8153390
        public void set_data(){} // RVA: 0x7A81533A0
        public void get_totalCount(){} // RVA: 0x7A8EA8210
        public void set_totalCount(){} // RVA: 0x7A8270510
        public void .ctor(){} // RVA: 0x7B16B85E0
    }

    public class ApiJweToken : ApiModel
    {
        // ── Methods ──
        public void get_token(){} // RVA: 0x7A8153390
        public void set_token(){} // RVA: 0x7A81533A0
        public void get_version(){} // RVA: 0x7A8EA8210
        public void set_version(){} // RVA: 0x7A8270510
        public void .ctor(){} // RVA: 0x7B16B9E70
    }

    public class ApiLeaderboard : ApiModel
    {
        // ── Methods ──
        public void get_userStats(){} // RVA: 0x7A8153390
        public void set_userStats(){} // RVA: 0x7A81533A0
        public void get_leaderboard(){} // RVA: 0x7A81A00E0
        public void set_leaderboard(){} // RVA: 0x7A81A00F0
        public void GetCurrentLeaderboardAsync(){} // RVA: 0x7B16B9EC0
        public void GetPreviousLeaderboardAsync(){} // RVA: 0x7B16B9FF0
        public void GetAnonymizationStateAsync(){} // RVA: 0x7B16BA120
        public void SetAnonymizationStateAsync(){} // RVA: 0x7B16BA250
        public void .ctor(){} // RVA: 0x7B16BA3A0
    }

    public class ApiLeaderboardAnonymizationStatus : ApiModel
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7A81A00C0
        public void set_state(){} // RVA: 0x7A81A00D0
        public void get_displayName(){} // RVA: 0x7A81A00E0
        public void set_displayName(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B16BC640
    }

    public class ApiLeaderboardData : ApiModel
    {
        // ── Methods ──
        public void get_startedAt(){} // RVA: 0x7A8153390
        public void set_startedAt(){} // RVA: 0x7A9D11620
        public void get_endsAt(){} // RVA: 0x7A81A00E0
        public void set_endsAt(){} // RVA: 0x7A9D11610
        public void get_ranks(){} // RVA: 0x7A82C2060
        public void set_ranks(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7B16BC5A0
    }

    public class ApiLeaderboardRank : ApiModel
    {
        // ── Methods ──
        public void get_displayName(){} // RVA: 0x7A8153390
        public void set_displayName(){} // RVA: 0x7A81533A0
        public void get_iconUrl(){} // RVA: 0x7A81A00E0
        public void set_iconUrl(){} // RVA: 0x7A81A00F0
        public void get_gifts(){} // RVA: 0x7A989D5C0
        public void set_gifts(){} // RVA: 0x7A98A0B60
        public void get_isAnonymized(){} // RVA: 0x7A86655E0
        public void set_isAnonymized(){} // RVA: 0x7A86616D0
        public void get_isSelf(){} // RVA: 0x7A865D020
        public void set_isSelf(){} // RVA: 0x7A865D260
        public void .ctor(){} // RVA: 0x7B16BC5F0
    }

    public class ApiLeaderboardUserStats : ApiModel
    {
        // ── Methods ──
        public void get_rank(){} // RVA: 0x7A9A93870
        public void set_rank(){} // RVA: 0x7A9A93880
        public void get_gifts(){} // RVA: 0x7A9A93890
        public void set_gifts(){} // RVA: 0x7A9A938A0
        public void get_isAnonymized(){} // RVA: 0x7A8153980
        public void set_isAnonymized(){} // RVA: 0x7A8153990
        public void get_anonymizedDisplayName(){} // RVA: 0x7A82C2060
        public void set_anonymizedDisplayName(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7B16BC550
    }

    public class ApiLedgerTransaction : ApiModel
    {
        // ── Methods ──
        public void get_Amount(){} // RVA: 0x7A9A93870
        public void set_Amount(){} // RVA: 0x7A9A93880
        public void get_RunningBalance(){} // RVA: 0x7A9A93890
        public void set_RunningBalance(){} // RVA: 0x7A9A938A0
        public void get_Date(){} // RVA: 0x7A81A00E0
        public void set_Date(){} // RVA: 0x7A9D11610
        public void get_ListingDisplayName(){} // RVA: 0x7A82C2060
        public void set_ListingDisplayName(){} // RVA: 0x7A82C0530
        public void get_ListingID(){} // RVA: 0x7A825E100
        public void set_ListingID(){} // RVA: 0x7A825F860
        public void get_ListingType(){} // RVA: 0x7A81163D0
        public void set_ListingType(){} // RVA: 0x7A825E460
        public void get_Platform(){} // RVA: 0x7A8555100
        public void set_Platform(){} // RVA: 0x7A8919DE0
        public void get_PurchaseId(){} // RVA: 0x7A87D9C10
        public void set_PurchaseId(){} // RVA: 0x7A8744720
        public void get_Reason(){} // RVA: 0x7A9B79A40
        public void set_Reason(){} // RVA: 0x7A9B79A00
        public void get_ReasonLabel(){} // RVA: 0x7A87D9480
        public void set_ReasonLabel(){} // RVA: 0x7A8881790
        public void get_ToUserId(){} // RVA: 0x7A8142610
        public void set_ToUserId(){} // RVA: 0x7A8142620
        public void get_ToUserDisplayName(){} // RVA: 0x7A8142680
        public void set_ToUserDisplayName(){} // RVA: 0x7A8142690
        public void get_FromUserId(){} // RVA: 0x7A81426F0
        public void set_FromUserId(){} // RVA: 0x7A8142700
        public void get_FromUserDisplayName(){} // RVA: 0x7A82305B0
        public void set_FromUserDisplayName(){} // RVA: 0x7A82305C0
        public void get_TransactionId(){} // RVA: 0x7A81F50F0
        public void set_TransactionId(){} // RVA: 0x7AE6C3A40
        public void get_TransactionLineId(){} // RVA: 0x7A8854870
        public void set_TransactionLineId(){} // RVA: 0x7B169EC30
        public void get_id(){} // RVA: 0x7B16BC6E0
        public void .ctor(){} // RVA: 0x7B16BC780
    }

    public class ApiLedgerTransactions : ApiModel
    {
        // ── Methods ──
        public void get_StartDate(){} // RVA: 0x7A8153390
        public void set_StartDate(){} // RVA: 0x7A9D11620
        public void get_EndDate(){} // RVA: 0x7A81A00E0
        public void set_EndDate(){} // RVA: 0x7A9D11610
        public void get_Transactions(){} // RVA: 0x7A82C2060
        public void set_Transactions(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7B16BC690
    }

    public class ApiLicenseNote : ApiModel
    {
        // ── Methods ──
        public void get_CreatedAt(){} // RVA: 0x7A8153390
        public void set_CreatedAt(){} // RVA: 0x7A9D11620
        public void get_Note(){} // RVA: 0x7A81A00E0
        public void set_Note(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B16BDC20
    }

    public class ApiListContainer : ApiContainer
    {
        // ── Methods ──
        public void get_ResponseList(){} // RVA: 0x7B1707800
        public void get_TotalCount(){} // RVA: 0x7A83562E0
        public void set_TotalCount(){} // RVA: 0x7A8355940
        public void Validate(){} // RVA: 0x7B1707870
        public void .ctor(){} // RVA: 0x7B1707BF0
    }

    public class ApiLoadingScreen : ApiModel
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A8153390
        public void set_name(){} // RVA: 0x7A81533A0
        public void get_assetBundleId(){} // RVA: 0x7A81A00E0
        public void set_assetBundleId(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B16BDC70
    }

    public class ApiLocalizableString : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB6DAF40
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB6DAF40
    }

    public class ApiModeration : ApiModel
    {
        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7A9A93870
        public void set_moderationType(){} // RVA: 0x7A9A93880
        public void get_moderatorUserId(){} // RVA: 0x7A81A00E0
        public void set_moderatorUserId(){} // RVA: 0x7A81A00F0
        public void get_moderatorDisplayName(){} // RVA: 0x7A82C2060
        public void set_moderatorDisplayName(){} // RVA: 0x7A82C0530
        public void get_targetUserId(){} // RVA: 0x7A825E100
        public void set_targetUserId(){} // RVA: 0x7A825F860
        public void get_targetDisplayName(){} // RVA: 0x7A81163D0
        public void set_targetDisplayName(){} // RVA: 0x7A825E460
        public void get_reasonMessage(){} // RVA: 0x7A8555100
        public void set_reasonMessage(){} // RVA: 0x7A8919DE0
        public void get_details(){} // RVA: 0x7A87D9C10
        public void set_details(){} // RVA: 0x7A8744720
        public void get_created(){} // RVA: 0x7A87C5850
        public void set_created(){} // RVA: 0x7ADDE2D30
        public void get_expires(){} // RVA: 0x7A87D9480
        public void set_expires(){} // RVA: 0x7A9905850
        public void get_isPermanent(){} // RVA: 0x7A94FA690
        public void set_isPermanent(){} // RVA: 0x7A94F9900
        public void get_worldId(){} // RVA: 0x7A81426F0
        public void set_worldId(){} // RVA: 0x7A8142700
        public void get_instanceId(){} // RVA: 0x7A82305B0
        public void set_instanceId(){} // RVA: 0x7A82305C0
        public void .ctor(){} // RVA: 0x7B16CEC30
        public void ShouldCache(){} // RVA: 0x7A80D7320
        public void ReadField(){} // RVA: 0x7B16CECD0
        public void WriteField(){} // RVA: 0x7B16CF150
        public void SendModeration(){} // RVA: 0x7B16CF380
        public void SendVoteKick(){} // RVA: 0x7B16CF740
        public void DeleteModeration(){} // RVA: 0x7B16CFA70
        public void LocalFetchAll(){} // RVA: 0x7B16CFC90
        public void ModerationTimeRangeToString(){} // RVA: 0x7B16CFF90
        public void ContestModeration(){} // RVA: 0x7B16D0030
    }

    public class ApiModerationResult : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ApiModerationResultExtensions : Object
    {
        // ── Methods ──
        public void WasModerated(){} // RVA: 0x7B16F9190
        public void GetModerationResult(){} // RVA: 0x7B16F91B0
    }

    public class ApiNotification : ApiModel
    {
        // ── Methods ──
        public void get_version(){} // RVA: 0x7A9A93870
        public void set_version(){} // RVA: 0x7A9A93880
        public void get_notificationType(){} // RVA: 0x7A9A93890
        public void set_notificationType(){} // RVA: 0x7A9A938A0
        public void get_category(){} // RVA: 0x7A81A00E0
        public void set_category(){} // RVA: 0x7A81A00F0
        public void get_isSystem(){} // RVA: 0x7A865DD90
        public void set_isSystem(){} // RVA: 0x7A9442C00
        public void get_senderUserId(){} // RVA: 0x7A825E100
        public void set_senderUserId(){} // RVA: 0x7A825F860
        public void get_senderUsername(){} // RVA: 0x7A81163D0
        public void set_senderUsername(){} // RVA: 0x7A825E460
        public void get_receiverUserId(){} // RVA: 0x7A8555100
        public void set_receiverUserId(){} // RVA: 0x7A8919DE0
        public void get_relatedNotificationsId(){} // RVA: 0x7A87D9C10
        public void set_relatedNotificationsId(){} // RVA: 0x7A8744720
        public void get_title(){} // RVA: 0x7A87C5850
        public void set_title(){} // RVA: 0x7A87446C0
        public void get_titleKey(){} // RVA: 0x7A87D9480
        public void set_titleKey(){} // RVA: 0x7A8881790
        public void get_message(){} // RVA: 0x7A8142610
        public void set_message(){} // RVA: 0x7A8142620
        public void get_messageKey(){} // RVA: 0x7A8142680
        public void set_messageKey(){} // RVA: 0x7A8142690
        public void get_imageUrl(){} // RVA: 0x7A81426F0
        public void set_imageUrl(){} // RVA: 0x7A8142700
        public void get_link(){} // RVA: 0x7A82305B0
        public void set_link(){} // RVA: 0x7A82305C0
        public void get_linkText(){} // RVA: 0x7A81F50F0
        public void set_linkText(){} // RVA: 0x7A81F5100
        public void get_linkTextKey(){} // RVA: 0x7A8854870
        public void set_linkTextKey(){} // RVA: 0x7A8158EF0
        public void get_responses(){} // RVA: 0x7A8158F50
        public void set_responses(){} // RVA: 0x7A8158F60
        public void get_expiresAt(){} // RVA: 0x7A8158FC0
        public void set_expiresAt(){} // RVA: 0x7ADE02E90
        public void get_expiryAfterSeen(){} // RVA: 0x7A8142870
        public void set_expiryAfterSeen(){} // RVA: 0x7AE1BD200
        public void get_seen(){} // RVA: 0x7A8F95560
        public void set_seen(){} // RVA: 0x7AEDF5D50
        public void get_ignoreDND(){} // RVA: 0x7A81343D0
        public void set_ignoreDND(){} // RVA: 0x7A81343E0
        public void get_canDelete(){} // RVA: 0x7B09A01A0
        public void set_canDelete(){} // RVA: 0x7B09A01C0
        public void get_created_at(){} // RVA: 0x7A8852A30
        public void set_created_at(){} // RVA: 0x7A94BD7B0
        public void get_createdAt(){} // RVA: 0x7A884DED0
        public void set_createdAt(){} // RVA: 0x7A9A836D0
        public void get_updatedAt(){} // RVA: 0x7A884F050
        public void set_updatedAt(){} // RVA: 0x7AE1BD250
        public void get_details(){} // RVA: 0x7A864CFF0
        public void set_details(){} // RVA: 0x7A864C880
        public void get_data(){} // RVA: 0x7A8357A90
        public void set_data(){} // RVA: 0x7A8358860
        public void get_jobName(){} // RVA: 0x7A884CA70
        public void set_jobName(){} // RVA: 0x7A8ADA650
        public void get_jobColor(){} // RVA: 0x7A884C460
        public void set_jobColor(){} // RVA: 0x7A8B68960
        public void .ctor(){} // RVA: 0x7B16F9490
        public void ShouldCache(){} // RVA: 0x7A80D7320
        public void ReadField(){} // RVA: 0x7B16F9530
        public void WriteField(){} // RVA: 0x7B16F9770
    }

    public class ApiPagedTransactions : ApiModel
    {
        // ── Methods ──
        public void get_Transactions(){} // RVA: 0x7A8153390
        public void set_Transactions(){} // RVA: 0x7A81533A0
        public void get_TotalCount(){} // RVA: 0x7A8EA8210
        public void set_TotalCount(){} // RVA: 0x7A8270510
        public void FetchTransactions(){} // RVA: 0x7B170E3F0
        public void .ctor(){} // RVA: 0x7B170F560
    }

    public class ApiPlayerModeration : ApiModel
    {
        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x7A9A93870
        public void set_moderationType(){} // RVA: 0x7A9A93880
        public void get_targetUserId(){} // RVA: 0x7A81A00E0
        public void set_targetUserId(){} // RVA: 0x7A81A00F0
        public void get_targetDisplayName(){} // RVA: 0x7A82C2060
        public void set_targetDisplayName(){} // RVA: 0x7A82C0530
        public void get_sourceUserId(){} // RVA: 0x7A825E100
        public void set_sourceUserId(){} // RVA: 0x7A825F860
        public void get_sourceDisplayName(){} // RVA: 0x7A81163D0
        public void set_sourceDisplayName(){} // RVA: 0x7A825E460
        public void get_created(){} // RVA: 0x7A8555100
        public void set_created(){} // RVA: 0x7A9ABC8A0
        public void .ctor(){} // RVA: 0x7B16F98C0
        public void CreateRemovalModeration(){} // RVA: 0x7B16F9980
        public void ShouldCache(){} // RVA: 0x7A80D7320
        public void ReadField(){} // RVA: 0x7B16F9A40
        public void WriteField(){} // RVA: 0x7B16F9C40
        public void SendModeration(){} // RVA: 0x7B16F9E20
        public void DeleteModeration(){} // RVA: 0x7B16FA060
        public void FetchAllAgainstMe(){} // RVA: 0x7B16FA610
        public void FetchAllMine(){} // RVA: 0x7B16FA660
        public void FetchList(){} // RVA: 0x7B16FA6B0
        public void ModerationTypeToAPIString(){} // RVA: 0x7B16FA9A0
    }

    public class ApiPrint : ApiModel
    {
        // ── Methods ──
        public void get_note(){} // RVA: 0x7A8153390
        public void set_note(){} // RVA: 0x7A81533A0
        public void get_authorId(){} // RVA: 0x7A81A00E0
        public void set_authorId(){} // RVA: 0x7A81A00F0
        public void get_authorName(){} // RVA: 0x7A82C2060
        public void set_authorName(){} // RVA: 0x7A82C0530
        public void get_worldId(){} // RVA: 0x7A825E100
        public void set_worldId(){} // RVA: 0x7A825F860
        public void get_worldName(){} // RVA: 0x7A81163D0
        public void set_worldName(){} // RVA: 0x7A825E460
        public void get_ownerId(){} // RVA: 0x7A8555100
        public void set_ownerId(){} // RVA: 0x7A8919DE0
        public void get_timestamp(){} // RVA: 0x7A87D9C10
        public void set_timestamp(){} // RVA: 0x7AD543B50
        public void get_files(){} // RVA: 0x7A87C5850
        public void set_files(){} // RVA: 0x7A87446C0
        public void get_createdAt(){} // RVA: 0x7A87D9480
        public void set_createdAt(){} // RVA: 0x7A9905850
        public void .ctor(){} // RVA: 0x7B16FAED0
        public void GetFileURL(){} // RVA: 0x7B16FAFD0
        public void GetImageURL(){} // RVA: 0x7B16FAFF0
        public void Upload(){} // RVA: 0x7B16FB040
        public void UpdatePrint(){} // RVA: 0x7B16FB560
        public void GetPrints(){} // RVA: 0x7B16FB9C0
        public void GetPrint(){} // RVA: 0x7B16FBF00
    }

    public class ApiProductPurchaseStatus : ApiModel
    {
        // ── Methods ──
        public void get_ProductId(){} // RVA: 0x7A8153390
        public void set_ProductId(){} // RVA: 0x7A81533A0
        public void get_LicenseId(){} // RVA: 0x7A81A00E0
        public void set_LicenseId(){} // RVA: 0x7A81A00F0
        public void get_Expiry(){} // RVA: 0x7A82C2060
        public void set_Expiry(){} // RVA: 0x7AD89C580
        public void GetProductsPurchaseStatus(){} // RVA: 0x7B17008D0
        public void .ctor(){} // RVA: 0x7B1700EA0
    }

    public class ApiProductVariant : ApiModel
    {
        // ── Methods ──
        public void get_ListingVariantID(){} // RVA: 0x7A8153390
        public void set_ListingVariantID(){} // RVA: 0x7A81533A0
        public void get_Quantity(){} // RVA: 0x7A8EA8210
        public void set_Quantity(){} // RVA: 0x7A8270510
        public void get_UnitPriceTokens(){} // RVA: 0x7A96E4F70
        public void set_UnitPriceTokens(){} // RVA: 0x7A9B90E90
        public void get_NonRefundable(){} // RVA: 0x7A865DD90
        public void set_NonRefundable(){} // RVA: 0x7A9442C00
        public void get_EffectiveFrom(){} // RVA: 0x7A825E100
        public void set_EffectiveFrom(){} // RVA: 0x7A9D11630
        public void .ctor(){} // RVA: 0x7B1700FB0
    }

    public class ApiProp : ApiContentModel`1
    {
        // ── Methods ──
        public void get__created_at(){} // RVA: 0x7A8854870
        public void set__created_at(){} // RVA: 0x7B169EC30
        public void get__updated_at(){} // RVA: 0x7A8158F50
        public void set__updated_at(){} // RVA: 0x7B169EC40
        public void get_unityPackages(){} // RVA: 0x7A8158FC0
        public void set_unityPackages(){} // RVA: 0x7A8158FD0
        public void get_spawnType(){} // RVA: 0x7AB52C0D0
        public void set_spawnType(){} // RVA: 0x7AE0660F0
        public void get_worldPlacementMask(){} // RVA: 0x7ABBECE40
        public void set_worldPlacementMask(){} // RVA: 0x7ABBECE50
        public void get_kind(){} // RVA: 0x7AF0B6750
        public void set_kind(){} // RVA: 0x7B126CF70
        public void get_scaleWithAvatar(){} // RVA: 0x7B1701000
        public void set_scaleWithAvatar(){} // RVA: 0x7B1701010
        public void get_BundleSignature(){} // RVA: 0x7A8852A30
        public void set_BundleSignature(){} // RVA: 0x7A8AB8FD0
        public void .ctor(){} // RVA: 0x7B1701020
        public void SetApiFieldsFromJson(){} // RVA: 0x7B1701180
        public void ProcessUnityPackages(){} // RVA: 0x7B1701260
        public void WriteField(){} // RVA: 0x7B1701920
        public void CopyDeserializedValuesTo(){} // RVA: 0x7B17019E0
        public void GetProp(){} // RVA: 0x7B1701BE0
    }

    public class ApiPropItemMetadata : ApiModel
    {
        // ── Methods ──
        public void get_propId(){} // RVA: 0x7A8153390
        public void set_propId(){} // RVA: 0x7A81533A0
        public void get_worldPlacementMask(){} // RVA: 0x7A8EA8210
        public void set_worldPlacementMask(){} // RVA: 0x7A8270510
        public void get_kind(){} // RVA: 0x7A96E4F70
        public void set_kind(){} // RVA: 0x7A9B90E90
        public void .ctor(){} // RVA: 0x7B1702070
    }

    public class ApiPurchase : ApiModel
    {
        // ── Methods ──
        public void get_ListingId(){} // RVA: 0x7A8153390
        public void set_ListingId(){} // RVA: 0x7A81533A0
        public void get_ListingDisplayName(){} // RVA: 0x7A81A00E0
        public void set_ListingDisplayName(){} // RVA: 0x7A81A00F0
        public void get_ListingImageId(){} // RVA: 0x7A82C2060
        public void set_ListingImageId(){} // RVA: 0x7A82C0530
        public void get_ListingImageUrl(){} // RVA: 0x7B1702160
        public void get_ListingType(){} // RVA: 0x7A8D6DF30
        public void set_ListingType(){} // RVA: 0x7A8D6DF20
        public void get_ListingVariantId(){} // RVA: 0x7A81163D0
        public void set_ListingVariantId(){} // RVA: 0x7A825E460
        public void get_SellerId(){} // RVA: 0x7A8555100
        public void set_SellerId(){} // RVA: 0x7A8919DE0
        public void get_SellerDisplayName(){} // RVA: 0x7A87D9C10
        public void set_SellerDisplayName(){} // RVA: 0x7A8744720
        public void get_BuyerId(){} // RVA: 0x7A87C5850
        public void set_BuyerId(){} // RVA: 0x7A87446C0
        public void get_BuyerDisplayName(){} // RVA: 0x7A87D9480
        public void set_BuyerDisplayName(){} // RVA: 0x7A8881790
        public void get_ReceiverId(){} // RVA: 0x7A8142610
        public void set_ReceiverId(){} // RVA: 0x7A8142620
        public void get_ReceiverDisplayName(){} // RVA: 0x7A8142680
        public void set_ReceiverDisplayName(){} // RVA: 0x7A8142690
        public void get_id(){} // RVA: 0x7A80F2570
        public void set_id(){} // RVA: 0x7A80D8E20
        public void get_Price(){} // RVA: 0x7A8357940
        public void set_Price(){} // RVA: 0x7A8360AA0
        public void get_Quantity(){} // RVA: 0x7A9AAC1B0
        public void set_Quantity(){} // RVA: 0x7ADF94DD0
        public void get_Duration(){} // RVA: 0x7A87BD4F0
        public void set_Duration(){} // RVA: 0x7AB6D7260
        public void get_DurationType(){} // RVA: 0x7A961A4D0
        public void set_DurationType(){} // RVA: 0x7ADF1BDC0
        public void get_PurchaseDate(){} // RVA: 0x7A81F50F0
        public void set_PurchaseDate(){} // RVA: 0x7AE6C3A40
        public void get_PurchaseStartDate(){} // RVA: 0x7A8854870
        public void set_PurchaseStartDate(){} // RVA: 0x7B169EC30
        public void get_PurchaseEndDate(){} // RVA: 0x7A8158F50
        public void set_PurchaseEndDate(){} // RVA: 0x7B169EC40
        public void get_PurchaseActive(){} // RVA: 0x7A92C23E0
        public void set_PurchaseActive(){} // RVA: 0x7A96655B0
        public void get_PurchaseLatest(){} // RVA: 0x7AE49A7A0
        public void set_PurchaseLatest(){} // RVA: 0x7B17021D0
        public void get_Products(){} // RVA: 0x7A8142870
        public void set_Products(){} // RVA: 0x7A8142880
        public void get_IsStackable(){} // RVA: 0x7A8F95560
        public void set_IsStackable(){} // RVA: 0x7AEDF5D50
        public void get_IsRecurrable(){} // RVA: 0x7A81343D0
        public void set_IsRecurrable(){} // RVA: 0x7A81343E0
        public void get_PurchaseToken(){} // RVA: 0x7A8852A30
        public void set_PurchaseToken(){} // RVA: 0x7A8AB8FD0
        public void get_IsVoided(){} // RVA: 0x7A94BD7C0
        public void set_IsVoided(){} // RVA: 0x7A94BD7D0
        public void get_IsGift(){} // RVA: 0x7A9905F50
        public void set_IsGift(){} // RVA: 0x7A9906160
        public void get_PurchaseUnitPrice(){} // RVA: 0x7A98A7730
        public void set_PurchaseUnitPrice(){} // RVA: 0x7A989D5B0
        public void get_IsRefundable(){} // RVA: 0x7A8401420
        public void set_IsRefundable(){} // RVA: 0x7A84017D0
        public void get_StackDurationType(){} // RVA: 0x7A864CFF0
        public void set_StackDurationType(){} // RVA: 0x7A864C880
        public void get_StackDuration(){} // RVA: 0x7A8ADBD10
        public void set_StackDuration(){} // RVA: 0x7AE066100
        public void get_StackPrice(){} // RVA: 0x7ADF29B00
        public void set_StackPrice(){} // RVA: 0x7ADF29B10
        public void get_StackQuantity(){} // RVA: 0x7AE0664A0
        public void set_StackQuantity(){} // RVA: 0x7AE0664B0
        public void get_StackQuantityConsumed(){} // RVA: 0x7B17021E0
        public void set_StackQuantityConsumed(){} // RVA: 0x7B17021F0
        public void get_StackQuantityConsumedAtPurchase(){} // RVA: 0x7A864B2A0
        public void set_StackQuantityConsumedAtPurchase(){} // RVA: 0x7AEBB3140
        public void get_StackQuantityUnconsumed(){} // RVA: 0x7AE94DA90
        public void set_StackQuantityUnconsumed(){} // RVA: 0x7B1702200
        public void get_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x7A8F9BFE0
        public void set_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x7ADF1BE10
        public void get_TiliaTransactionId(){} // RVA: 0x7A8142BC0
        public void set_TiliaTransactionId(){} // RVA: 0x7A8142BD0
        public void get_WillRecur(){} // RVA: 0x7A9437E00
        public void set_WillRecur(){} // RVA: 0x7A9440AF0
        public void get_ListingCurrentlyAvailable(){} // RVA: 0x7B126C9A0
        public void set_ListingCurrentlyAvailable(){} // RVA: 0x7B0F61350
        public void get_CreatedAtDate(){} // RVA: 0x7A87BB380
        public void set_CreatedAtDate(){} // RVA: 0x7B1702210
        public void get_PurchaseID(){} // RVA: 0x7A8B4D7B0
        public void set_PurchaseID(){} // RVA: 0x7A8B59B40
        public void get_UpdatedAtDate(){} // RVA: 0x7A863E8E0
        public void set_UpdatedAtDate(){} // RVA: 0x7AF2C2F10
        public void get_PurchaseOriginalEndDate(){} // RVA: 0x7A8B57910
        public void set_PurchaseOriginalEndDate(){} // RVA: 0x7B1702220
        public void get_BuyerIP(){} // RVA: 0x7A85ECF50
        public void set_BuyerIP(){} // RVA: 0x7A8B51A20
        public void get_IsRecur(){} // RVA: 0x7B1702230
        public void set_IsRecur(){} // RVA: 0x7A81AC3C0
        public void get_IsUnityLocalTest(){} // RVA: 0x7B1702240
        public void set_IsUnityLocalTest(){} // RVA: 0x7B1702250
        public void get_LicenseID(){} // RVA: 0x7A8B6A790
        public void set_LicenseID(){} // RVA: 0x7A8B4AC60
        public void get_PurchaseStacks(){} // RVA: 0x7A8B46B20
        public void set_PurchaseStacks(){} // RVA: 0x7A8B639C0
        public void get_PurchaseTiliaFee(){} // RVA: 0x7AE068FD0
        public void set_PurchaseTiliaFee(){} // RVA: 0x7AEC8BB70
        public void get_PurchaseType(){} // RVA: 0x7A8855020
        public void set_PurchaseType(){} // RVA: 0x7A8B60460
        public void get_PurchaseValue(){} // RVA: 0x7B1702260
        public void set_PurchaseValue(){} // RVA: 0x7B1702270
        public void get_PurchaseVrcFee(){} // RVA: 0x7B0E03580
        public void set_PurchaseVrcFee(){} // RVA: 0x7B0E00EA0
        public void get_RefundStatus(){} // RVA: 0x7A8852B30
        public void set_RefundStatus(){} // RVA: 0x7A8B66E80
        public void get_SellerIP(){} // RVA: 0x7A8B69B70
        public void set_SellerIP(){} // RVA: 0x7A8B4DC50
        public void get_StackTiliaFee(){} // RVA: 0x7B1702280
        public void set_StackTiliaFee(){} // RVA: 0x7B1702290
        public void get_StackValue(){} // RVA: 0x7A934A750
        public void set_StackValue(){} // RVA: 0x7B17022A0
        public void get_StackVrcFee(){} // RVA: 0x7A9345EC0
        public void set_StackVrcFee(){} // RVA: 0x7B17022B0
        public void get_StackQuantityVoided(){} // RVA: 0x7B17022C0
        public void set_StackQuantityVoided(){} // RVA: 0x7B17022D0
        public void get_VoidedBy(){} // RVA: 0x7A8B6AFA0
        public void set_VoidedBy(){} // RVA: 0x7A8B58B30
        public void get_VoidedByAdmin(){} // RVA: 0x7B17022E0
        public void set_VoidedByAdmin(){} // RVA: 0x7B17022F0
        public void get_VoidedOnDate(){} // RVA: 0x7A8B5ED30
        public void set_VoidedOnDate(){} // RVA: 0x7B1702300
        public void get_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0x7B1232FC0
        public void set_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0x7B1702310
        public void get_PurchaseTiliaFeeDrift(){} // RVA: 0x7AE703F30
        public void set_PurchaseTiliaFeeDrift(){} // RVA: 0x7B1702320
        public void get_PurchaseVrcFeeBasedOnStack(){} // RVA: 0x7B1702330
        public void set_PurchaseVrcFeeBasedOnStack(){} // RVA: 0x7B1702340
        public void get_Refunded(){} // RVA: 0x7B1702350
        public void set_Refunded(){} // RVA: 0x7B1702360
        public void get_RefundedBy(){} // RVA: 0x7A8B562C0
        public void set_RefundedBy(){} // RVA: 0x7A8B4A930
        public void get_RefundedByAdmin(){} // RVA: 0x7A9A9D8A0
        public void set_RefundedByAdmin(){} // RVA: 0x7B1702370
        public void get_RefundedOnDate(){} // RVA: 0x7A8B62DA0
        public void set_RefundedOnDate(){} // RVA: 0x7B1702380
        public void get_RefundedStacks(){} // RVA: 0x7A8B5B150
        public void set_RefundedStacks(){} // RVA: 0x7A8B48310
        public void get_RefundReason(){} // RVA: 0x7A8B63C30
        public void set_RefundReason(){} // RVA: 0x7A8B5FB80
        public void get_RefundReasonType(){} // RVA: 0x7A8B4BD50
        public void set_RefundReasonType(){} // RVA: 0x7A8B5EDA0
        public void get_RefundTiliaTransactionId(){} // RVA: 0x7A8B54F00
        public void set_RefundTiliaTransactionId(){} // RVA: 0x7A8B56C80
        public void get_RefundTokenComponents(){} // RVA: 0x7A8B53E80
        public void set_RefundTokenComponents(){} // RVA: 0x7A8B634D0
        public void get_RefundTokens(){} // RVA: 0x7A97F9C60
        public void set_RefundTokens(){} // RVA: 0x7A97FAE70
        public void get_RefundTokenSources(){} // RVA: 0x7A8B54430
        public void set_RefundTokenSources(){} // RVA: 0x7A8B580C0
        public void get_RefundType(){} // RVA: 0x7A8B588C0
        public void set_RefundType(){} // RVA: 0x7A8B605E0
        public void get_VoidedStacks(){} // RVA: 0x7A8B45F80
        public void set_VoidedStacks(){} // RVA: 0x7A8B4BC00
        public void get_VoidedCompletely(){} // RVA: 0x7B1702390
        public void set_VoidedCompletely(){} // RVA: 0x7B17023A0
        public void ReadField(){} // RVA: 0x7B17023B0
        public void WriteField(){} // RVA: 0x7B17025F0
        public void GetCancelInformation(){} // RVA: 0x7B1702770
        public void Cancel(){} // RVA: 0x7B1703050
        public void FetchList(){} // RVA: 0x7B17039C0
        public void FetchMostRecentActivePurchase(){} // RVA: 0x7B1704970
        public void .ctor(){} // RVA: 0x7B17052D0
    }

    public class ApiPurchaseCancelSubscriptionInfo : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B17020C0
        public void get_RefundableAmount(){} // RVA: 0x7A9A93870
        public void set_RefundableAmount(){} // RVA: 0x7A9A93880
        public void get_NonRefundableAmount(){} // RVA: 0x7A9A93890
        public void set_NonRefundableAmount(){} // RVA: 0x7A9A938A0
        public void get_TotalStacksToCancel(){} // RVA: 0x7A8EA8210
        public void set_TotalStacksToCancel(){} // RVA: 0x7A8270510
        public void get_NewExpirationDate(){} // RVA: 0x7A82C2060
        public void set_NewExpirationDate(){} // RVA: 0x7AD89C580
    }

    public class ApiPurchaseSubscriptionCancelledInfo : ApiModel
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1702110
        public void get_AmountRefunded(){} // RVA: 0x7A9A93870
        public void set_AmountRefunded(){} // RVA: 0x7A9A93880
        public void get_TotalStacksCancelled(){} // RVA: 0x7A9A93890
        public void set_TotalStacksCancelled(){} // RVA: 0x7A9A938A0
        public void get_NewExpirationDate(){} // RVA: 0x7A81A00E0
        public void set_NewExpirationDate(){} // RVA: 0x7A9D11610
    }

    public class ApiReport : ApiModel
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7A8153390
        public void set_type(){} // RVA: 0x7A81533A0
        public void get_category(){} // RVA: 0x7A81A00E0
        public void set_category(){} // RVA: 0x7A81A00F0
        public void get_reason(){} // RVA: 0x7A82C2060
        public void set_reason(){} // RVA: 0x7A82C0530
        public void get_contentId(){} // RVA: 0x7A825E100
        public void set_contentId(){} // RVA: 0x7A825F860
        public void get_description(){} // RVA: 0x7A81163D0
        public void set_description(){} // RVA: 0x7A825E460
        public void get_details(){} // RVA: 0x7A8555100
        public void set_details(){} // RVA: 0x7A8919DE0
        public void get_contentName(){} // RVA: 0x7A87D9C10
        public void set_contentName(){} // RVA: 0x7A8744720
        public void get_contentThumbnailImageUrl(){} // RVA: 0x7A87C5850
        public void set_contentThumbnailImageUrl(){} // RVA: 0x7A87446C0
        public void AddReport(){} // RVA: 0x7B17060D0
        public void FetchReports(){} // RVA: 0x7B1706400
        public void DeleteReport(){} // RVA: 0x7B1706AB0
        public void .ctor(){} // RVA: 0x7B1706DC0
    }

    public class ApiReportDetails : ApiModel
    {
        // ── Methods ──
        public void get_suggestedWarnings(){} // RVA: 0x7A8153390
        public void set_suggestedWarnings(){} // RVA: 0x7A81533A0
        public void get_instanceType(){} // RVA: 0x7A81A00E0
        public void set_instanceType(){} // RVA: 0x7A81A00F0
        public void get_instanceAgeGated(){} // RVA: 0x7ADD85260
        public void set_instanceAgeGated(){} // RVA: 0x7B1706F70
        public void get_userInSameInstance(){} // RVA: 0x7B1706F80
        public void set_userInSameInstance(){} // RVA: 0x7B1706F90
        public void get_imageType(){} // RVA: 0x7A825E100
        public void set_imageType(){} // RVA: 0x7A825F860
        public void get_fileId(){} // RVA: 0x7A81163D0
        public void set_fileId(){} // RVA: 0x7A825E460
        public void get_holderId(){} // RVA: 0x7A8555100
        public void set_holderId(){} // RVA: 0x7A8919DE0
        public void get_targetUserId(){} // RVA: 0x7A87D9C10
        public void set_targetUserId(){} // RVA: 0x7A8744720
        public void .ctor(){} // RVA: 0x7B1706FA0
    }

    public class ApiReportResponse : ApiModel
    {
        // ── Methods ──
        public void get_evidenceRequired(){} // RVA: 0x7A81A00C0
        public void set_evidenceRequired(){} // RVA: 0x7A81A00D0
        public void get_supportRequired(){} // RVA: 0x7ACF04410
        public void set_supportRequired(){} // RVA: 0x7ACF040C0
        public void .ctor(){} // RVA: 0x7B1707040
    }

    public class ApiReportsContainer : ApiModel
    {
        // ── Methods ──
        public void get_hasNext(){} // RVA: 0x7A81A00C0
        public void set_hasNext(){} // RVA: 0x7A81A00D0
        public void get_results(){} // RVA: 0x7A81A00E0
        public void set_results(){} // RVA: 0x7A81A00F0
        public void get_totalCount(){} // RVA: 0x7A989D5C0
        public void set_totalCount(){} // RVA: 0x7A98A0B60
        public void .ctor(){} // RVA: 0x7B1706FF0
    }

    public class ApiSearchGroupResults : ApiModel
    {
        // ── Methods ──
        public void get_results(){} // RVA: 0x7A8153390
        public void set_results(){} // RVA: 0x7A81533A0
        public void get_totalCount(){} // RVA: 0x7A8EA8210
        public void set_totalCount(){} // RVA: 0x7A8270510
        public void .ctor(){} // RVA: 0x7B170D250
    }

    public class ApiSearchUserResults : ApiModel
    {
        // ── Methods ──
        public void get_results(){} // RVA: 0x7A8153390
        public void set_results(){} // RVA: 0x7A81533A0
        public void get_totalCount(){} // RVA: 0x7A8EA8210
        public void set_totalCount(){} // RVA: 0x7A8270510
        public void .ctor(){} // RVA: 0x7B170D200
    }

    public class ApiSearchWorldResults : ApiModel
    {
        // ── Methods ──
        public void get_results(){} // RVA: 0x7A8153390
        public void set_results(){} // RVA: 0x7A81533A0
        public void get_totalCount(){} // RVA: 0x7A8EA8210
        public void set_totalCount(){} // RVA: 0x7A8270510
        public void .ctor(){} // RVA: 0x7B170D1B0
    }

    public class ApiSteamVRChatFinalizeTransactionResponse : ApiVRChatSubscriptionBaseResponse
    {
        // ── Methods ──
        public void get_status(){} // RVA: 0x7A81A00E0
        public void set_status(){} // RVA: 0x7A81A00F0
        public void get_giftValidationToken(){} // RVA: 0x7A82C2060
        public void set_giftValidationToken(){} // RVA: 0x7A82C0530
        public void get_subscription(){} // RVA: 0x7A825E100
        public void set_subscription(){} // RVA: 0x7A825F860
        public void .ctor(){} // RVA: 0x7B172EC70
    }

    public class ApiSteamVRChatSubscriptionSteamTransaction : ApiModel
    {
        // ── Methods ──
        public void get_walletInfo(){} // RVA: 0x7A8153390
        public void set_walletInfo(){} // RVA: 0x7A81533A0
        public void get_steamId(){} // RVA: 0x7A81A00E0
        public void set_steamId(){} // RVA: 0x7A81A00F0
        public void get_orderId(){} // RVA: 0x7A82C2060
        public void set_orderId(){} // RVA: 0x7A82C0530
        public void get_steamUrl(){} // RVA: 0x7A825E100
        public void set_steamUrl(){} // RVA: 0x7A825F860
        public void get_transId(){} // RVA: 0x7A81163D0
        public void set_transId(){} // RVA: 0x7A825E460
        public void .ctor(){} // RVA: 0x7B172F300
    }

    public class ApiSteamVRChatSubscriptionTransaction : ApiVRChatSubscriptionBaseResponse
    {
        // ── Methods ──
        public void get_status(){} // RVA: 0x7A81A00E0
        public void set_status(){} // RVA: 0x7A81A00F0
        public void get_subscription(){} // RVA: 0x7A82C2060
        public void set_subscription(){} // RVA: 0x7A82C0530
        public void get_sandbox(){} // RVA: 0x7A8361EA0
        public void set_sandbox(){} // RVA: 0x7A835F4F0
        public void get_created_at(){} // RVA: 0x7A81163D0
        public void set_created_at(){} // RVA: 0x7A825E460
        public void get_updated_at(){} // RVA: 0x7A8555100
        public void set_updated_at(){} // RVA: 0x7A8919DE0
        public void get_steam(){} // RVA: 0x7A87D9C10
        public void set_steam(){} // RVA: 0x7A8744720
        public void .ctor(){} // RVA: 0x7B172EC70
    }

    public class ApiSteamVRChatSubscriptionWalletInformation : ApiModel
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7A8153390
        public void set_state(){} // RVA: 0x7A81533A0
        public void get_country(){} // RVA: 0x7A81A00E0
        public void set_country(){} // RVA: 0x7A81A00F0
        public void get_currency(){} // RVA: 0x7A82C2060
        public void set_currency(){} // RVA: 0x7A82C0530
        public void get_status(){} // RVA: 0x7A825E100
        public void set_status(){} // RVA: 0x7A825F860
        public void .ctor(){} // RVA: 0x7B172F2B0
    }

    public class ApiStringArrayContainer : ApiContainer
    {
        // ── Methods ──
        public void get_responseArray(){} // RVA: 0x7B1707DA0
        public void Validate(){} // RVA: 0x7B1707DE0
        public void .ctor(){} // RVA: 0x7B1707BF0
    }

    public class ApiStringContainer : ApiContainer
    {
        // ── Methods ──
        public void get_ResponseString(){} // RVA: 0x7B1707C00
        public void Validate(){} // RVA: 0x7B1707C50
        public void .ctor(){} // RVA: 0x7B1707BF0
    }

    public class ApiTokenBundle : ApiModel
    {
        // ── Methods ──
        public void get_steamItemId(){} // RVA: 0x7A9A93870
        public void set_steamItemId(){} // RVA: 0x7A9A93880
        public void get_oculusSku(){} // RVA: 0x7A81A00E0
        public void set_oculusSku(){} // RVA: 0x7A81A00F0
        public void get_googleProductId(){} // RVA: 0x7A82C2060
        public void set_googleProductId(){} // RVA: 0x7A82C0530
        public void get_picoSku(){} // RVA: 0x7A825E100
        public void set_picoSku(){} // RVA: 0x7A825F860
        public void get_amount(){} // RVA: 0x7A897F560
        public void set_amount(){} // RVA: 0x7A8980300
        public void get_description(){} // RVA: 0x7A8555100
        public void set_description(){} // RVA: 0x7A8919DE0
        public void get_tokens(){} // RVA: 0x7A9B79A20
        public void set_tokens(){} // RVA: 0x7A9B794B0
        public void get_imageUrl(){} // RVA: 0x7A87C5850
        public void set_imageUrl(){} // RVA: 0x7A87446C0
        public void Fetch(){} // RVA: 0x7B170DFE0
        public void .ctor(){} // RVA: 0x7B170E2E0
    }

    public class ApiTokenPurchase : ApiTokenBundle
    {
        // ── Methods ──
        public void get_PurchaseDate(){} // RVA: 0x7A87D9480
        public void set_PurchaseDate(){} // RVA: 0x7A9905850
        public void .ctor(){} // RVA: 0x7B170E2E0
    }

    public class ApiTransaction : ApiModel
    {
        // ── Methods ──
        public void get_ListingID(){} // RVA: 0x7A8153390
        public void set_ListingID(){} // RVA: 0x7A81533A0
        public void get_Name(){} // RVA: 0x7A81A00E0
        public void set_Name(){} // RVA: 0x7A81A00F0
        public void get_SellerId(){} // RVA: 0x7A82C2060
        public void set_SellerId(){} // RVA: 0x7A82C0530
        public void get_FromUserDisplayName(){} // RVA: 0x7A825E100
        public void set_FromUserDisplayName(){} // RVA: 0x7A825F860
        public void get_SellerDisplayName(){} // RVA: 0x7A81163D0
        public void set_SellerDisplayName(){} // RVA: 0x7A825E460
        public void get_BuyerId(){} // RVA: 0x7A8555100
        public void set_BuyerId(){} // RVA: 0x7A8919DE0
        public void get_BuyerDisplayName(){} // RVA: 0x7A87D9C10
        public void set_BuyerDisplayName(){} // RVA: 0x7A8744720
        public void get_Type(){} // RVA: 0x7A87C5850
        public void set_Type(){} // RVA: 0x7A87446C0
        public void get_Date(){} // RVA: 0x7A87D9480
        public void set_Date(){} // RVA: 0x7A9905850
        public void get_Amount(){} // RVA: 0x7A9EEB080
        public void set_Amount(){} // RVA: 0x7ADE0AE80
        public void get_RunningBalance(){} // RVA: 0x7ABBEC920
        public void set_RunningBalance(){} // RVA: 0x7ABBEC930
        public void get_ImageId(){} // RVA: 0x7A8142680
        public void set_ImageId(){} // RVA: 0x7A8142690
        public void get_PurchaseId(){} // RVA: 0x7A81426F0
        public void set_PurchaseId(){} // RVA: 0x7A8142700
        public void get_TiliaRef(){} // RVA: 0x7A82305B0
        public void set_TiliaRef(){} // RVA: 0x7A82305C0
        public void get_TransactionImageUrl(){} // RVA: 0x7B170F770
        public void FetchList(){} // RVA: 0x7B170F7E0
        public void .ctor(){} // RVA: 0x7B1710780
    }

    public class ApiUserIcon : ApiFile
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7A80D7320
        public void FetchList(){} // RVA: 0x7B172BF60
        public void UploadIcon(){} // RVA: 0x7B172C9D0
        public void .ctor(){} // RVA: 0x7B16AFF10
    }

    public class ApiUserPermission : ApiModel
    {
        // ── Methods ──
        public void get_ownerId(){} // RVA: 0x7A8153390
        public void set_ownerId(){} // RVA: 0x7A81533A0
        public void get_name(){} // RVA: 0x7A81A00E0
        public void set_name(){} // RVA: 0x7A81A00F0
        public void get_data(){} // RVA: 0x7A82C2060
        public void set_data(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7B172DD40
    }

    public class ApiUserPlatformList : ApiModel
    {
        // ── Methods ──
        public void get_platforms(){} // RVA: 0x7A8153390
        public void set_platforms(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7B172E7C0
    }

    public class ApiUserPlatforms : Object
    {
        // ── Methods ──
        public void get_platforms(){} // RVA: 0x7A8124910
        public void set_platforms(){} // RVA: 0x7A80DA0C0
        public void get_CurrentUserPlatforms(){} // RVA: 0x7B172DD90
        public void set_CurrentUserPlatforms(){} // RVA: 0x7B172DDD0
        public void Fetch(){} // RVA: 0x7B172DE70
        public void Clear(){} // RVA: 0x7B172E1C0
        public void get_SupportsStandaloneWindows(){} // RVA: 0x7B172E1D0
        public void get_SupportsAndroid(){} // RVA: 0x7B172E1E0
        public void get_SupportsiOS(){} // RVA: 0x7B172E1F0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ApiVRChatAdminSubscriptionTransaction : ApiVRChatSubscriptionBaseResponse
    {
        // ── Methods ──
        public void get_userId(){} // RVA: 0x7A81A00E0
        public void set_userId(){} // RVA: 0x7A81A00F0
        public void get_adminUserId(){} // RVA: 0x7A82C2060
        public void set_adminUserId(){} // RVA: 0x7A82C0530
        public void get_expiry(){} // RVA: 0x7A825E100
        public void set_expiry(){} // RVA: 0x7A825F860
        public void get_subscription(){} // RVA: 0x7A81163D0
        public void set_subscription(){} // RVA: 0x7A825E460
        public void .ctor(){} // RVA: 0x7B172EC70
    }

    public class ApiVRChatGiftTransactionResponse : ApiVRChatSubscriptionBaseResponse
    {
        // ── Methods ──
        public void get_giftValidationToken(){} // RVA: 0x7A81A00E0
        public void set_giftValidationToken(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B172EC70
    }

    public class ApiVRChatProductDetails : ApiModel
    {
        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7A81A00C0
        public void set_enabled(){} // RVA: 0x7A81A00D0
        public void get_productType(){} // RVA: 0x7A81A00E0
        public void set_productType(){} // RVA: 0x7A81A00F0
        public void get_Product(){} // RVA: 0x7B172E950
        public void get_endpoint(){} // RVA: 0x7A825E100
        public void set_endpoint(){} // RVA: 0x7A825F860
        public void get_stores(){} // RVA: 0x7A81163D0
        public void set_stores(){} // RVA: 0x7A825E460
        public void get_subscriptionInfo(){} // RVA: 0x7A8555100
        public void set_subscriptionInfo(){} // RVA: 0x7A8919DE0
        public void get_giftInfo(){} // RVA: 0x7A87D9C10
        public void set_giftInfo(){} // RVA: 0x7A8744720
        public void get_tokenInfo(){} // RVA: 0x7A87C5850
        public void set_tokenInfo(){} // RVA: 0x7A87446C0
        public void get_description(){} // RVA: 0x7A87D9480
        public void set_description(){} // RVA: 0x7A8881790
        public void .ctor(){} // RVA: 0x7B172EA40
    }

    public class ApiVRChatSubscription : ApiModel
    {
        // ── Methods ──
        public void get_transactionId(){} // RVA: 0x7A8153390
        public void set_transactionId(){} // RVA: 0x7A81533A0
        public void get_steamItemId(){} // RVA: 0x7A81A00E0
        public void set_steamItemId(){} // RVA: 0x7A81A00F0
        public void get_amount(){} // RVA: 0x7A82C2060
        public void set_amount(){} // RVA: 0x7AD89C580
        public void get_description(){} // RVA: 0x7A825E100
        public void set_description(){} // RVA: 0x7A825F860
        public void get_store(){} // RVA: 0x7A81163D0
        public void set_store(){} // RVA: 0x7A825E460
        public void get_period(){} // RVA: 0x7A8555100
        public void set_period(){} // RVA: 0x7A8919DE0
        public void get_active(){} // RVA: 0x7A862ABC0
        public void set_active(){} // RVA: 0x7A862ABD0
        public void get_status(){} // RVA: 0x7A87C5850
        public void set_status(){} // RVA: 0x7A87446C0
        public void get_tier(){} // RVA: 0x7A8A69800
        public void set_tier(){} // RVA: 0x7A8A67200
        public void get_starts(){} // RVA: 0x7A8142610
        public void set_starts(){} // RVA: 0x7A8142620
        public void get_expires(){} // RVA: 0x7A8142680
        public void set_expires(){} // RVA: 0x7A8142690
        public void get_created_at(){} // RVA: 0x7A81426F0
        public void set_created_at(){} // RVA: 0x7A8142700
        public void get_updated_at(){} // RVA: 0x7A82305B0
        public void set_updated_at(){} // RVA: 0x7A82305C0
        public void get_isGift(){} // RVA: 0x7A86665A0
        public void set_isGift(){} // RVA: 0x7A8FB8F70
        public void get_isBulkGift(){} // RVA: 0x7A8FB9510
        public void set_isBulkGift(){} // RVA: 0x7AE193680
        public void get_giftedBy(){} // RVA: 0x7A8854870
        public void set_giftedBy(){} // RVA: 0x7A8158EF0
        public void get_giftedByDisplayName(){} // RVA: 0x7A8158F50
        public void set_giftedByDisplayName(){} // RVA: 0x7A8158F60
        public void get_licenseGroups(){} // RVA: 0x7A8158FC0
        public void set_licenseGroups(){} // RVA: 0x7A8158FD0
        public void get_vendorData(){} // RVA: 0x7A8142870
        public void set_vendorData(){} // RVA: 0x7A8142880
        public void ToString(){} // RVA: 0x7B172ECC0
        public void .ctor(){} // RVA: 0x7B172F210
    }

    public class ApiVRChatSubscriptionBaseResponse : ApiModel
    {
        // ── Methods ──
        public void get_error(){} // RVA: 0x7A8153390
        public void set_error(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7B172EC70
    }

    public class ApiVRChatSubscriptionDetails : ApiModel
    {
        // ── Methods ──
        public void get_amount(){} // RVA: 0x7A9A93870
        public void set_amount(){} // RVA: 0x7A9A93880
        public void get_description(){} // RVA: 0x7A81A00E0
        public void set_description(){} // RVA: 0x7A81A00F0
        public void get_period(){} // RVA: 0x7A82C2060
        public void set_period(){} // RVA: 0x7A82C0530
        public void .ctor(){} // RVA: 0x7B172EC20
    }

    public class ApiVRChatSubscriptionError : Object
    {
        // ── Methods ──
        public void get_status_code(){} // RVA: 0x7A8124910
        public void set_status_code(){} // RVA: 0x7A80DA0C0
        public void get_message(){} // RVA: 0x7A80DA7B0
        public void set_message(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ApiViewfinderSkin : ApiModel
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A8153390
        public void set_name(){} // RVA: 0x7A81533A0
        public void get_assetBundleId(){} // RVA: 0x7A81A00E0
        public void set_assetBundleId(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B172E810
    }

    public class ApiWarpEffectSkin : ApiModel
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0x7A8153390
        public void set_name(){} // RVA: 0x7A81533A0
        public void get_assetBundleId(){} // RVA: 0x7A81A00E0
        public void set_assetBundleId(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7B172F350
    }

    public class AssetVersion : Object
    {
        // ── Methods ──
        public void get_UnityVersion(){} // RVA: 0x7B1751420
        public void set_UnityVersion(){} // RVA: 0x7A80D8E20
        public void get_UnityVersionObj(){} // RVA: 0x7B1751510
        public void get_ApiVersion(){} // RVA: 0x7A8F9ACE0
        public void set_ApiVersion(){} // RVA: 0x7A98B6D80
        public void .ctor(){} // RVA: 0x7B1751710
        public void ToString(){} // RVA: 0x7B1751770
    }

}