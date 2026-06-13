// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 100
// Methods: 1978

namespace VRC.Core
{
    public class API
    {
        public string API_URL;
        public string devApiUrl;
        public string devCeApiUrl;

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
        public System.Collections.Generic.List`1<string> <requiresTwoFactorAuth>k__BackingField; // 0x68
        public string <scope>k__BackingField; // 0x70
        public string <ticket>k__BackingField; // 0x78

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
        public string <userId>k__BackingField; // 0x68
        public int <gifts>k__BackingField; // 0x70
        public bool <isFriend>k__BackingField; // 0x74

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
        public string <ownerId>k__BackingField; // 0x68
        public 0x657CFC60 <accessType>k__BackingField; // 0x70
        public System.DateTime <startsAt>k__BackingField; // 0x78
        public System.DateTime <endsAt>k__BackingField; // 0x80
        public string <title>k__BackingField; // 0x88
        public string <description>k__BackingField; // 0x90
        public string <category>k__BackingField; // 0x98
        public string <shortCode>k__BackingField; // 0xA0
        public string <type>k__BackingField; // 0xA8
        public bool <isDraft>k__BackingField; // 0xB0
        public string <imageId>k__BackingField; // 0xB8
        public string <imageUrl>k__BackingField; // 0xC0
        public System.Collections.Generic.List`1<string> <roleIds>k__BackingField; // 0xC8
        public System.Collections.Generic.List`1<string> <tags>k__BackingField; // 0xD0
        public System.Collections.Generic.List`1<string> <platforms>k__BackingField; // 0xD8
        public System.Collections.Generic.List`1<string> <languages>k__BackingField; // 0xE0
        public string <parentId>k__BackingField; // 0xE8
        public int <hostEarlyJoinMinutes>k__BackingField; // 0xF0
        public int <guestEarlyJoinMinutes>k__BackingField; // 0xF4
        public int <closeInstanceAfterEndMinutes>k__BackingField; // 0xF8
        public bool <usesInstanceOverflow>k__BackingField; // 0xFC
        public System.DateTime <deletedAt>k__BackingField; // 0x100
        public VRC.Core.APICalendarEntryUserInterest <userInterest>k__BackingField; // 0x108
        public bool <featured>k__BackingField; // 0x110
        public int <interestedUserCount>k__BackingField; // 0x114

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
        public bool <isFollowing>k__BackingField; // 0x68
        public System.DateTime <createdAt>k__BackingField; // 0x70
        public System.DateTime <updatedAt>k__BackingField; // 0x78

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
        public string <fileId>k__BackingField; // 0x68
        public string <imageUrl>k__BackingField; // 0x70
        public string <animationStyle>k__BackingField; // 0x78
        public string <maskTag>k__BackingField; // 0x80
        public bool <animated>k__BackingField; // 0x88
        public int <frames>k__BackingField; // 0x8C
        public int <framesOverTime>k__BackingField; // 0x90
        public string <loopStyle>k__BackingField; // 0x98
        public string <assetBundleId>k__BackingField; // 0xA0
        public bool <premium>k__BackingField; // 0xA8

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
        public VRC.Core.ApiJweToken <dropValidationToken>k__BackingField; // 0x68
        public VRC.Core.ApiJweToken <giftValidationToken>k__BackingField; // 0x70
        public System.Collections.Generic.List`1<VRC.Core.APIActivationSuccessfulTargetResult> <successfulGifts>k__BackingField; // 0x78

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
        public string <steamItemId>k__BackingField; // 0x68
        public string <oculusSku>k__BackingField; // 0x70
        public string <googleProductId>k__BackingField; // 0x78
        public string <googlePlanId>k__BackingField; // 0x80
        public string <picoSku>k__BackingField; // 0x88
        public int <amount>k__BackingField; // 0x90
        public string <description>k__BackingField; // 0x98
        public string <period>k__BackingField; // 0xA0
        public int <periodAmount>k__BackingField; // 0xA8
        public int <tier>k__BackingField; // 0xAC
        public int <bulkSize>k__BackingField; // 0xB0
        public int <discountPercentage>k__BackingField; // 0xB4
        public System.Collections.Generic.List`1<string> <licenseGroups>k__BackingField; // 0xB8

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
        public string <ownerId>k__BackingField; // 0x68
        public string <name>k__BackingField; // 0x70
        public string <shortCode>k__BackingField; // 0x78
        public string <discriminator>k__BackingField; // 0x80
        public string <description>k__BackingField; // 0x88
        public string <iconUrl>k__BackingField; // 0x90
        public string <bannerUrl>k__BackingField; // 0x98
        public int <memberCount>k__BackingField; // 0xA0
        public int <onlineMemberCount>k__BackingField; // 0xA4
        public string <memberCountSyncedAt>k__BackingField; // 0xA8
        public string <privacy>k__BackingField; // 0xB0
        public string <joinState>k__BackingField; // 0xB8
        public VRC.Core.APIGroupMember <myMember>k__BackingField; // 0xC0
        public System.DateTime <createdAt>k__BackingField; // 0xC8
        public System.DateTime <updatedAt>k__BackingField; // 0xD0
        public string <membershipStatus>k__BackingField; // 0xD8
        public string <bannerId>k__BackingField; // 0xE0
        public string <iconId>k__BackingField; // 0xE8
        public string <rules>k__BackingField; // 0xF0
        public System.Collections.Generic.List`1<string> <initialRoleIds>k__BackingField; // 0xF8
        public bool <isSystemGroup>k__BackingField; // 0x100
        public bool <isVerified>k__BackingField; // 0x101
        public System.Collections.Generic.List`1<GalleryObject> <galleries>k__BackingField; // 0x108
        public System.Collections.Generic.List`1<string> <tags>k__BackingField; // 0x110
        public bool <isSearchable>k__BackingField; // 0x118
        public int <sizeQuality>k__BackingField; // 0x11C
        public int <activityQuality>k__BackingField; // 0x120
        public int <engagementQuality>k__BackingField; // 0x124
        public int <contentQuality>k__BackingField; // 0x128
        public System.Collections.Generic.List`1<VRC.Core.APIGroupRole> <roles>k__BackingField; // 0x130
        public System.Collections.Generic.List`1<string> <links>k__BackingField; // 0x138
        public System.Collections.Generic.List`1<string> <languages>k__BackingField; // 0x140
        public System.DateTime <lastPostCreatedAt>k__BackingField; // 0x148
        public string <storeId>k__BackingField; // 0x150

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
        public string <groupId>k__BackingField; // 0x68
        public string <authorId>k__BackingField; // 0x70
        public string <title>k__BackingField; // 0x78
        public string <text>k__BackingField; // 0x80
        public string <imageUrl>k__BackingField; // 0x88
        public string <visibility>k__BackingField; // 0x90
        public System.DateTime <createdAt>k__BackingField; // 0x98
        public System.DateTime <updatedAt>k__BackingField; // 0xA0
        public System.Collections.Generic.List`1<string> <roleIds>k__BackingField; // 0xA8

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
        public string <groupId>k__BackingField; // 0x68
        public string <userId>k__BackingField; // 0x70
        public string <state>k__BackingField; // 0x78

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
        public string <groupId>k__BackingField; // 0x68
        public string <userId>k__BackingField; // 0x70
        public System.DateTime <createdAt>k__BackingField; // 0x78
        public bool <isOnProfile>k__BackingField; // 0x80
        public bool <isOnNameplate>k__BackingField; // 0x81
        public System.DateTime <joinedAt>k__BackingField; // 0x88
        public System.DateTime <updatedAt>k__BackingField; // 0x90
        public bool <isActive>k__BackingField; // 0x98
        public bool <requestedJoin>k__BackingField; // 0x99
        public string <inviteId>k__BackingField; // 0xA0

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
        public System.DateTime <fetchedAt>k__BackingField; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.ApiWorldInstance> <instances>k__BackingField; // 0x70

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
        public string <groupId>k__BackingField; // 0x68
        public string <userId>k__BackingField; // 0x70
        public System.Collections.Generic.List`1<string> <roleIds>k__BackingField; // 0x78
        public System.Collections.Generic.List`1<string> <mRoleIds>k__BackingField; // 0x80
        public System.Collections.Generic.List`1<string> <permissions>k__BackingField; // 0x88
        public string <memberVisibility>k__BackingField; // 0x90
        public string <membershipStatus>k__BackingField; // 0x98
        public bool <isRepresenting>k__BackingField; // 0xA0
        public bool <mutualGroup>k__BackingField; // 0xA1
        public string <name>k__BackingField; // 0xA8
        public string <ownerId>k__BackingField; // 0xB0
        public string <shortCode>k__BackingField; // 0xB8
        public string <discriminator>k__BackingField; // 0xC0
        public string <iconUrl>k__BackingField; // 0xC8
        public string <bannerUrl>k__BackingField; // 0xD0
        public string <privacy>k__BackingField; // 0xD8
        public string <visibility>k__BackingField; // 0xE0
        public bool <isSubscribedToAnnouncements>k__BackingField; // 0xE8
        public bool <isSubscribedToEventAnnouncements>k__BackingField; // 0xE9
        public int <memberCount>k__BackingField; // 0xEC
        public System.DateTime <joinedAt>k__BackingField; // 0xF0
        public System.DateTime <bannedAt>k__BackingField; // 0xF8
        public System.DateTime <lastPostReadAt>k__BackingField; // 0x100
        public System.DateTime <lastPostCreatedAt>k__BackingField; // 0x108
        public VRC.Core.APIUser <user>k__BackingField; // 0x110
        public VRC.Core.APIGroup <group>k__BackingField; // 0x118

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
        public string <groupId>k__BackingField; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APIGroupMember> <members>k__BackingField; // 0x70

        // ── Methods ──
        public void get_groupId(){} // RVA: 0x358D50
        public void set_groupId(){} // RVA: 0x358D60
        public void get_members(){} // RVA: 0x3A5590
        public void set_members(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x99252E0 | overloaded x2
    }

    public class APIGroupPosts
    {
        public int <total>k__BackingField; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APIGroupAnnouncement> <posts>k__BackingField; // 0x70

        // ── Methods ──
        public void get_total(){} // RVA: 0x1C91440
        public void set_total(){} // RVA: 0x1C91450
        public void get_posts(){} // RVA: 0x3A5590
        public void set_posts(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9922CB0
    }

    public class APIGroupRole
    {
        public string <groupId>k__BackingField; // 0x68
        public string <name>k__BackingField; // 0x70
        public string <description>k__BackingField; // 0x78
        public bool <isSelfAssignable>k__BackingField; // 0x80
        public bool <requiresTwoFactor>k__BackingField; // 0x81
        public bool <isManagementRole>k__BackingField; // 0x82
        public bool <requiresPurchase>k__BackingField; // 0x83
        public System.DateTime <createdAt>k__BackingField; // 0x88
        public System.DateTime <updatedAt>k__BackingField; // 0x90
        public bool <defaultRole>k__BackingField; // 0x98
        public int <order>k__BackingField; // 0x9C
        public System.Collections.Generic.List`1<string> <permissions>k__BackingField; // 0xA0

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
        public string <groupId>k__BackingField; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APIGroupRole> <roles>k__BackingField; // 0x70

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
        public bool <Eligible>k__BackingField; // 0x68
        public string <Reason>k__BackingField; // 0x70
        public System.Collections.Generic.List`1<string> <EligibleProducts>k__BackingField; // 0x78
        public System.Collections.Generic.List`1<string> <IneligibleProducts>k__BackingField; // 0x80

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
        public string <transactionId>k__BackingField; // 0x68
        public string <store>k__BackingField; // 0x70
        public string <steamItemId>k__BackingField; // 0x78
        public string <oculusSku>k__BackingField; // 0x80
        public string <googleProductId>k__BackingField; // 0x88
        public string <googlePlanId>k__BackingField; // 0x90
        public string <picoSku>k__BackingField; // 0x98
        public int <amount>k__BackingField; // 0xA0
        public string <description>k__BackingField; // 0xA8
        public string <period>k__BackingField; // 0xB0
        public bool <consumed>k__BackingField; // 0xB8
        public string <status>k__BackingField; // 0xC0
        public string <created_at>k__BackingField; // 0xC8
        public string <updated_at>k__BackingField; // 0xD0
        public bool <isBulkGift>k__BackingField; // 0xD8
        public string[] <targets>k__BackingField; // 0xE0
        public int <bulkSize>k__BackingField; // 0xE8
        public int <discountPercentage>k__BackingField; // 0xEC
        public int <totalConsumed>k__BackingField; // 0xF0
        public int <totalUnconsumed>k__BackingField; // 0xF4
        public int <failures>k__BackingField; // 0xF8

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
        public string <fileId>k__BackingField; // 0x68
        public string <imageUrl>k__BackingField; // 0x70
        public string <specialEffect>k__BackingField; // 0x78
        public string <animationStyle>k__BackingField; // 0x80
        public string <maskTag>k__BackingField; // 0x88
        public bool <animated>k__BackingField; // 0x90
        public int <frames>k__BackingField; // 0x94
        public int <framesOverTime>k__BackingField; // 0x98
        public string <loopStyle>k__BackingField; // 0xA0
        public string <assetBundleId>k__BackingField; // 0xA8

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
        public System.Collections.Generic.Dictionary`2<string,object> <response>k__BackingField; // 0x68

        // ── Methods ──
        public void get_response(){} // RVA: 0x358D50
        public void set_response(){} // RVA: 0x358D60
        public void .ctor(){} // RVA: 0x98D2A00
    }

    public class APITutorial
    {
        public string VRCHAT_GET_TUTORIAL_ENDPOINT;
        public bool <IsTutorialCompleted>k__BackingField; // 0x68
        public bool <CompletedAnyTutorial>k__BackingField; // 0x69

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
        public string <ownerId>k__BackingField; // 0x68
        public string <name>k__BackingField; // 0x70
        public string <highlights>k__BackingField; // 0x78
        public string <icons>k__BackingField; // 0x80
        public string <buttons>k__BackingField; // 0x88
        public string <backgrounds>k__BackingField; // 0x90
        public string <text>k__BackingField; // 0x98
        public string <subtext>k__BackingField; // 0xA0

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
        public string <blob>k__BackingField; // 0x68
        public string <displayName>k__BackingField; // 0x70
        public string <username>k__BackingField; // 0x78
        public string <pronouns>k__BackingField; // 0x80
        public string <bio>k__BackingField; // 0x88
        public System.Collections.Generic.List`1<string> <bioLinks>k__BackingField; // 0x90
        public string <location>k__BackingField; // 0x98
        public string <avatarId>k__BackingField; // 0xA0
        public string <fallbackId>k__BackingField; // 0xA8
        public bool <hasEmail>k__BackingField; // 0xB0
        public bool <isBoopingEnabled>k__BackingField; // 0xB1
        public bool <hasBirthday>k__BackingField; // 0xB2
        public bool <isFriend>k__BackingField; // 0xB3
        public string <friendKey>k__BackingField; // 0xB8
        public string <friendRequestStatus>k__BackingField; // 0xC0
        public string <last_login>k__BackingField; // 0xC8
        public string <last_activity>k__BackingField; // 0xD0
        public string <date_joined>k__BackingField; // 0xD8
        public 0x657CCE50 <developerType>k__BackingField; // 0xE0
        public System.Collections.Generic.List`1<VRC.Core.VRCEvent> <events>k__BackingField; // 0xE8
        public int <acceptedTOSVersion>k__BackingField; // 0xF0
        public string <queuedInstance>k__BackingField; // 0xF8
        public int <queuedInstancePosition>k__BackingField; // 0x100
        public int <acceptedPrivacyVersion>k__BackingField; // 0x104
        public string <currentAvatarImageUrl>k__BackingField; // 0x108
        public string <currentAvatarThumbnailImageUrl>k__BackingField; // 0x110
        public System.Collections.Generic.List`1<string> <currentAvatarTags>k__BackingField; // 0x118
        public string <authToken>k__BackingField; // 0x120
        public bool <emailVerified>k__BackingField; // 0x128
        public bool <hasPendingEmail>k__BackingField; // 0x129
        public string <obfuscatedPendingEmail>k__BackingField; // 0x130
        public System.Collections.Generic.List`1<string> <friendIDs>k__BackingField; // 0x138
        public string <currentAvatarAssetUrl>k__BackingField; // 0x140
        public System.Collections.Generic.Dictionary`2<string,object> <steamDetails>k__BackingField; // 0x148
        public string <travelingToLocation>k__BackingField; // 0x150
        public string <obfuscatedEmail>k__BackingField; // 0x158
        public bool <unsubscribe>k__BackingField; // 0x160
        public bool <hasLoggedInFromClient>k__BackingField; // 0x161
        public System.Collections.Generic.List`1<string> <pastDisplayNames>k__BackingField; // 0x168
        public string <homeLocation>k__BackingField; // 0x170
        public System.Collections.Generic.List`1<string> _tags; // 0x178
        public string <status>k__BackingField; // 0x180
        public string <statusDescription>k__BackingField; // 0x188
        public System.Collections.Generic.List`1<VRC.Core.ApiBadge> <badges>k__BackingField; // 0x190
        public System.Collections.Generic.List`1<string> <statusHistory>k__BackingField; // 0x198
        public string <state>k__BackingField; // 0x1A0
        public bool <allowAvatarCopying>k__BackingField; // 0x1A8
        public bool <hasSharedConnectionsOptOut>k__BackingField; // 0x1A9
        public bool <hasDiscordFriendsOptOut>k__BackingField; // 0x1AA
        public string <userIcon>k__BackingField; // 0x1B0
        public string <profilePicOverride>k__BackingField; // 0x1B8
        public string <note>k__BackingField; // 0x1C0
        public string <iconUrl>k__BackingField; // 0x1C8
        public string <thumbnailUrl>k__BackingField; // 0x1D0
        public bool <hideContentFilterSettings>k__BackingField; // 0x1D8
        public System.Collections.Generic.List`1<string> <contentFilters>k__BackingField; // 0x1E0
        public string <userLanguageCode>k__BackingField; // 0x1E8
        public bool <ageVerified>k__BackingField; // 0x1F0
        public bool <isAdult>k__BackingField; // 0x1F1
        public string <ageVerificationStatus>k__BackingField; // 0x1F8
        public string <discordId>k__BackingField; // 0x200
        public bool <hasAcceptedDiscordSocialSDKPerms>k__BackingField; // 0x208
        public System.Collections.Generic.List`1<string> <completedTutorials>k__BackingField; // 0x210
        public string _last_platform; // 0x218
        public string <platform>k__BackingField; // 0x220
        public string <last_mobile>k__BackingField; // 0x228
        public bool <twoFactorAuthEnabled>k__BackingField; // 0x230
        public System.Collections.Generic.Dictionary`2<string,object> <twoFactorAuthMethods>k__BackingField; // 0x238
        public System.Collections.Generic.Dictionary`2<string,string> _languageTagsDictionary;
        public System.Collections.Generic.List`1<string> _languagesDisplayNames; // 0x240
        public System.Collections.Generic.List`1<string> <LanguagesShortNames>k__BackingField; // 0x248
        public System.Collections.Hashtable statusDefaultDescriptions; // 0x8
        public VRC.Core.APIUser <CurrentUser>k__BackingField; // 0x10

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
        public bool <isUpgrading>k__BackingField; // 0x68
        public bool <subscribedToMarketingEmails>k__BackingField; // 0x69
        public bool <hasEmail>k__BackingField; // 0x6A
        public bool <emailVerified>k__BackingField; // 0x6B

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
        public string <name>k__BackingField; // 0x68
        public string <description>k__BackingField; // 0x70
        public string <imageUrl>k__BackingField; // 0x78
        public System.Collections.Generic.List`1<string> <tags>k__BackingField; // 0x80
        public int <assetVersion>k__BackingField; // 0x88
        public System.Collections.Generic.List`1<VRC.Core.ApiAdminAssetBundleFile> <unityPackages>k__BackingField; // 0x90

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
        public string <assetUrl>k__BackingField; // 0x68
        public string <unityVersion>k__BackingField; // 0x70
        public string <platform>k__BackingField; // 0x78
        public int <assetVersion>k__BackingField; // 0x80

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
        public string <continueToken>k__BackingField; // 0x68
        public string[] <requestedFields>k__BackingField; // 0x70
        public ReservedName <reservedName>k__BackingField; // 0x78

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
        public System.Collections.Generic.Dictionary`2<0x657CA5C0,string> performanceRatings; // 0xD8
        public string <impostorUrl>k__BackingField; // 0xE0
        public 0x657C6C58 <variant>k__BackingField; // 0xE8
        public string <impostorUnityVersion>k__BackingField; // 0xF0
        public System.Collections.Generic.List`1<UnityPackage> <unityPackages>k__BackingField; // 0xF8
        public System.DateTime <created_at>k__BackingField; // 0x100
        public System.DateTime <updated_at>k__BackingField; // 0x108
        public VRC.Core.ApiProductAttribution <attribution>k__BackingField; // 0x110
        public 0x657C7CD8<VRC.Core.ApiAvatar> <offlineAnalysisScanStatus>k__BackingField; // 0x118
        public string <performanceRating>k__BackingField; // 0x120
        public System.Collections.Generic.Dictionary`2<string,string> <styles>k__BackingField; // 0x128
        public string <productId>k__BackingField; // 0x130
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> <publishedListings>k__BackingField; // 0x138
        public System.Nullable`1<int> <lowestPrice>k__BackingField; // 0x140
        public System.Nullable`1<int> <highestPrice>k__BackingField; // 0x148
        public string <acknowledgements>k__BackingField; // 0x150

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
        public string <avatarId>k__BackingField; // 0x68
        public System.Collections.Generic.List`1<Attachment> <attachments>k__BackingField; // 0x70

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
        public float ListCacheTime;
        public 0x657C7338 <moderationType>k__BackingField; // 0x68

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
        public System.DateTime <_created_at>k__BackingField; // 0xD8
        public System.DateTime <_updated_at>k__BackingField; // 0xE0
        public System.Collections.Generic.List`1<UnityPackage> <unityPackages>k__BackingField; // 0xE8
        public string AvatarPartEndpoint;

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
        public string <avatarPartId>k__BackingField; // 0x68

        // ── Methods ──
        public void get_avatarPartId(){} // RVA: 0x358D50
        public void set_avatarPartId(){} // RVA: 0x358D60
        public void .ctor(){} // RVA: 0x9865640
    }

    public class ApiAvatarStyle
    {
        public string <styleName>k__BackingField; // 0x68
        public string <lastModifiedById>k__BackingField; // 0x70
        public string <lastModifiedByDisplayName>k__BackingField; // 0x78
        public System.DateTime <created_at>k__BackingField; // 0x80
        public System.DateTime <updated_at>k__BackingField; // 0x88

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
        public string <badgeId>k__BackingField; // 0x68
        public bool <showcased>k__BackingField; // 0x70
        public string <badgeName>k__BackingField; // 0x78
        public string <badgeDescription>k__BackingField; // 0x80
        public string <badgeImageUrl>k__BackingField; // 0x88
        public bool <hidden>k__BackingField; // 0x90
        public System.DateTime <assignedAt>k__BackingField; // 0x98
        public System.DateTime <updatedAt>k__BackingField; // 0xA0
        public string <assignedBy>k__BackingField; // 0xA8
        public bool <isQuantifiable>k__BackingField; // 0xB0
        public int <quantity>k__BackingField; // 0xB4

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
        public string <command>k__BackingField; // 0x68
        public System.Collections.Generic.List`1<string> <parameters>k__BackingField; // 0x70
        public string <name>k__BackingField; // 0x78

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
        public System.Func`1<long> TimeProvider;
        public System.Collections.Generic.Dictionary`2<string,CacheEntry> cache; // 0x8

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
        public bool <hasNext>k__BackingField; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.APICalendarEntry> <results>k__BackingField; // 0x70
        public int <totalCount>k__BackingField; // 0x78
        public string <nextCursor>k__BackingField; // 0x80

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
        public System.Collections.Generic.List`1<VRC.Core.APICalendarEntry> <results>k__BackingField; // 0x68
        public int <totalCount>k__BackingField; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x358D50
        public void set_results(){} // RVA: 0x358D60
        public void get_totalCount(){} // RVA: 0x10E5CF0
        public void set_totalCount(){} // RVA: 0x475080
        public void .ctor(){} // RVA: 0x98D1D30
    }

    public class ApiCampaign
    {
        public int <participantCount>k__BackingField; // 0x68
        public System.Collections.Generic.List`1<string> <friendsContributing>k__BackingField; // 0x70
        public System.DateTime <endsAt>k__BackingField; // 0x78
        public int <raisedAmountUsd>k__BackingField; // 0x80
        public int <userGiftCount>k__BackingField; // 0x84
        public int <giftGoalUsd>k__BackingField; // 0x88
        public bool <goalSuccess>k__BackingField; // 0x8C
        public System.Collections.Generic.List`1<VRC.Core.ApiCampaignReward> <rewards>k__BackingField; // 0x90

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
        public string <title>k__BackingField; // 0x68
        public string <description>k__BackingField; // 0x70
        public string <imageUrl>k__BackingField; // 0x78
        public bool <unlocked>k__BackingField; // 0x80
        public VRC.Core.ApiCampaignRewardProgress <progress>k__BackingField; // 0x88

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
        public int <current>k__BackingField; // 0x68
        public int <max>k__BackingField; // 0x6C

        // ── Methods ──
        public void get_current(){} // RVA: 0x1C91440
        public void set_current(){} // RVA: 0x1C91450
        public void get_max(){} // RVA: 0x1C91460
        public void set_max(){} // RVA: 0x1C91470
        public void .ctor(){} // RVA: 0x9868210
    }

    public class ApiCertificateVerifier
    {
        public VRC.Core.ApiCertificateVerifier _instance;

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
        public System.Collections.Generic.Dictionary`2<string,string> <Cookies>k__BackingField; // 0x10
        public bool <Populated>k__BackingField; // 0x18
        public bool <PassedValidation>k__BackingField; // 0x19
        public int <Code>k__BackingField; // 0x1C
        public string <Text>k__BackingField; // 0x20
        public object <Data>k__BackingField; // 0x28
        public float <DataTimestamp>k__BackingField; // 0x30
        public string <CreatedAt>k__BackingField; // 0x38
        public string responseError; // 0x40
        public VRC.Core.ApiModel <Model>k__BackingField; // 0x48

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
        public VRC.Core.AssetVersion _VERSION;
        public VRC.Core.AssetVersion MIN_LOADABLE_VERSION;
        public float ListCacheTime;
        public float SingleRecordCacheTime;
        public System.Collections.Generic.Dictionary`2<string,T> localContent;
        public string <name>k__BackingField;
        public string <imageUrl>k__BackingField;
        public string <authorName>k__BackingField;
        public string <authorId>k__BackingField;
        public string <assetUrl>k__BackingField;
        public string <description>k__BackingField;
        public System.Collections.Generic.List`1<string> <tags>k__BackingField;
        public string <thumbnailImageUrl>k__BackingField;
        public int <version>k__BackingField;
        public string <releaseStatus>k__BackingField;
        public bool <featured>k__BackingField;
        public bool <unityPackageUpdated>k__BackingField;
        public string <unityVersion>k__BackingField;

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

    public class ApiContentModel`1
    {
        public VRC.Core.AssetVersion _VERSION;
        public VRC.Core.AssetVersion MIN_LOADABLE_VERSION; // 0x8
        public float ListCacheTime;
        public float SingleRecordCacheTime;
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiAvatar> localContent; // 0x10
        public string <name>k__BackingField; // 0x68
        public string <imageUrl>k__BackingField; // 0x70
        public string <authorName>k__BackingField; // 0x78
        public string <authorId>k__BackingField; // 0x80
        public string <assetUrl>k__BackingField; // 0x88
        public string <description>k__BackingField; // 0x90
        public System.Collections.Generic.List`1<string> <tags>k__BackingField; // 0x98
        public string <thumbnailImageUrl>k__BackingField; // 0xA0
        public int <version>k__BackingField; // 0xA8
        public string <releaseStatus>k__BackingField; // 0xB0
        public bool <featured>k__BackingField; // 0xB8
        public bool <unityPackageUpdated>k__BackingField; // 0xB9
        public string <unityVersion>k__BackingField; // 0xC0

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x38EE9A0
        public void ShouldCache(){} // RVA: 0x38EECD0
        public void GetLifeSpan(){} // RVA: 0x38EED30
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_imageUrl(){} // RVA: 0x3A5590
        public void set_imageUrl(){} // RVA: 0x3A55A0
        public void get_authorName(){} // RVA: 0x4C7C50
        public void set_authorName(){} // RVA: 0x4C34F0
        public void get_authorId(){} // RVA: 0x462D00
        public void set_authorId(){} // RVA: 0x464450
        public void get_assetUrl(){} // RVA: 0x31C010
        public void set_assetUrl(){} // RVA: 0x463060
        public void get_description(){} // RVA: 0x796DE0
        public void set_description(){} // RVA: 0xB54600
        public void get_tags(){} // RVA: 0xA1C8C0
        public void set_tags(){} // RVA: 0x9AA650
        public void get_thumbnailImageUrl(){} // RVA: 0xA085E0
        public void set_thumbnailImageUrl(){} // RVA: 0x9AA5F0
        public void get_version(){} // RVA: 0xCC3CB0
        public void set_version(){} // RVA: 0xCC9310
        public void get_releaseStatus(){} // RVA: 0x348040
        public void set_releaseStatus(){} // RVA: 0x348050
        public void get_featured(){} // RVA: 0x173F990
        public void set_featured(){} // RVA: 0x173EC00
        public void get_unityPackageUpdated(){} // RVA: 0x38EED40
        public void set_unityPackageUpdated(){} // RVA: 0x38EED50
        public void get_unityVersion(){} // RVA: 0x348120
        public void set_unityVersion(){} // RVA: 0x348130
        public void get_apiVersion(){} // RVA: 0xA002A0
        public void set_apiVersion(){} // RVA: 0x38EED60
        public void get_platform(){} // RVA: 0x3FA100
        public void set_platform(){} // RVA: 0x3FA110
        public void get_assetVersion(){} // RVA: 0x38EED70
        public void set_assetVersion(){} // RVA: 0x38EEE20
        public void .ctor(){} // RVA: 0x38EEEB0
        public void ReadField(){} // RVA: 0x38EEF80
        public void Get(){} // RVA: 0x38EF150
        public void FetchList(){} // RVA: 0x38EF890
        public void AddLocal(){} // RVA: 0x38F1560
        public void IsLocalById(){} // RVA: 0x38F1690
        public void get_IsLocal(){} // RVA: 0x38F1790
        public void Save(){} // RVA: 0x38F1870
        public void SaveReleaseStatus(){} // RVA: 0x38F18F0
        public void GetAssetUrl(){} // RVA: 0x31C010
        public void HasTag(){} // RVA: 0x38F1E30
        public void AddTag(){} // RVA: 0x38F1EA0
        public void RemoveTag(){} // RVA: 0x38F1F40
        public void UpdateVersionAndPlatform(){} // RVA: 0x38F20A0
        public void MakeRequestEndpoint(){} // RVA: 0x38F2230
        public void .cctor(){} // RVA: 0x38F2260
    }

    public class ApiContentModel`1
    {
        public VRC.Core.AssetVersion _VERSION;
        public VRC.Core.AssetVersion MIN_LOADABLE_VERSION; // 0x8
        public float ListCacheTime;
        public float SingleRecordCacheTime;
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiAvatarPart> localContent; // 0x10
        public string <name>k__BackingField; // 0x68
        public string <imageUrl>k__BackingField; // 0x70
        public string <authorName>k__BackingField; // 0x78
        public string <authorId>k__BackingField; // 0x80
        public string <assetUrl>k__BackingField; // 0x88
        public string <description>k__BackingField; // 0x90
        public System.Collections.Generic.List`1<string> <tags>k__BackingField; // 0x98
        public string <thumbnailImageUrl>k__BackingField; // 0xA0
        public int <version>k__BackingField; // 0xA8
        public string <releaseStatus>k__BackingField; // 0xB0
        public bool <featured>k__BackingField; // 0xB8
        public bool <unityPackageUpdated>k__BackingField; // 0xB9
        public string <unityVersion>k__BackingField; // 0xC0

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x38EE9A0
        public void ShouldCache(){} // RVA: 0x38EECD0
        public void GetLifeSpan(){} // RVA: 0x38EED30
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_imageUrl(){} // RVA: 0x3A5590
        public void set_imageUrl(){} // RVA: 0x3A55A0
        public void get_authorName(){} // RVA: 0x4C7C50
        public void set_authorName(){} // RVA: 0x4C34F0
        public void get_authorId(){} // RVA: 0x462D00
        public void set_authorId(){} // RVA: 0x464450
        public void get_assetUrl(){} // RVA: 0x31C010
        public void set_assetUrl(){} // RVA: 0x463060
        public void get_description(){} // RVA: 0x796DE0
        public void set_description(){} // RVA: 0xB54600
        public void get_tags(){} // RVA: 0xA1C8C0
        public void set_tags(){} // RVA: 0x9AA650
        public void get_thumbnailImageUrl(){} // RVA: 0xA085E0
        public void set_thumbnailImageUrl(){} // RVA: 0x9AA5F0
        public void get_version(){} // RVA: 0xCC3CB0
        public void set_version(){} // RVA: 0xCC9310
        public void get_releaseStatus(){} // RVA: 0x348040
        public void set_releaseStatus(){} // RVA: 0x348050
        public void get_featured(){} // RVA: 0x173F990
        public void set_featured(){} // RVA: 0x173EC00
        public void get_unityPackageUpdated(){} // RVA: 0x38EED40
        public void set_unityPackageUpdated(){} // RVA: 0x38EED50
        public void get_unityVersion(){} // RVA: 0x348120
        public void set_unityVersion(){} // RVA: 0x348130
        public void get_apiVersion(){} // RVA: 0xA002A0
        public void set_apiVersion(){} // RVA: 0x38EED60
        public void get_platform(){} // RVA: 0x3FA100
        public void set_platform(){} // RVA: 0x3FA110
        public void get_assetVersion(){} // RVA: 0x38EED70
        public void set_assetVersion(){} // RVA: 0x38EEE20
        public void .ctor(){} // RVA: 0x38EEEB0
        public void ReadField(){} // RVA: 0x38EEF80
        public void Get(){} // RVA: 0x38EF150
        public void FetchList(){} // RVA: 0x38EF890
        public void AddLocal(){} // RVA: 0x38F1560
        public void IsLocalById(){} // RVA: 0x38F1690
        public void get_IsLocal(){} // RVA: 0x38F1790
        public void Save(){} // RVA: 0x38F1870
        public void SaveReleaseStatus(){} // RVA: 0x38F18F0
        public void GetAssetUrl(){} // RVA: 0x31C010
        public void HasTag(){} // RVA: 0x38F1E30
        public void AddTag(){} // RVA: 0x38F1EA0
        public void RemoveTag(){} // RVA: 0x38F1F40
        public void UpdateVersionAndPlatform(){} // RVA: 0x38F20A0
        public void MakeRequestEndpoint(){} // RVA: 0x38F2230
        public void .cctor(){} // RVA: 0x38F2260
    }

    public class ApiContentModel`1
    {
        public VRC.Core.AssetVersion _VERSION;
        public VRC.Core.AssetVersion MIN_LOADABLE_VERSION; // 0x8
        public float ListCacheTime;
        public float SingleRecordCacheTime;
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiProp> localContent; // 0x10
        public string <name>k__BackingField; // 0x68
        public string <imageUrl>k__BackingField; // 0x70
        public string <authorName>k__BackingField; // 0x78
        public string <authorId>k__BackingField; // 0x80
        public string <assetUrl>k__BackingField; // 0x88
        public string <description>k__BackingField; // 0x90
        public System.Collections.Generic.List`1<string> <tags>k__BackingField; // 0x98
        public string <thumbnailImageUrl>k__BackingField; // 0xA0
        public int <version>k__BackingField; // 0xA8
        public string <releaseStatus>k__BackingField; // 0xB0
        public bool <featured>k__BackingField; // 0xB8
        public bool <unityPackageUpdated>k__BackingField; // 0xB9
        public string <unityVersion>k__BackingField; // 0xC0

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x38EE9A0
        public void ShouldCache(){} // RVA: 0x38EECD0
        public void GetLifeSpan(){} // RVA: 0x38EED30
        public void get_name(){} // RVA: 0x358D50
        public void set_name(){} // RVA: 0x358D60
        public void get_imageUrl(){} // RVA: 0x3A5590
        public void set_imageUrl(){} // RVA: 0x3A55A0
        public void get_authorName(){} // RVA: 0x4C7C50
        public void set_authorName(){} // RVA: 0x4C34F0
        public void get_authorId(){} // RVA: 0x462D00
        public void set_authorId(){} // RVA: 0x464450
        public void get_assetUrl(){} // RVA: 0x31C010
        public void set_assetUrl(){} // RVA: 0x463060
        public void get_description(){} // RVA: 0x796DE0
        public void set_description(){} // RVA: 0xB54600
        public void get_tags(){} // RVA: 0xA1C8C0
        public void set_tags(){} // RVA: 0x9AA650
        public void get_thumbnailImageUrl(){} // RVA: 0xA085E0
        public void set_thumbnailImageUrl(){} // RVA: 0x9AA5F0
        public void get_version(){} // RVA: 0xCC3CB0
        public void set_version(){} // RVA: 0xCC9310
        public void get_releaseStatus(){} // RVA: 0x348040
        public void set_releaseStatus(){} // RVA: 0x348050
        public void get_featured(){} // RVA: 0x173F990
        public void set_featured(){} // RVA: 0x173EC00
        public void get_unityPackageUpdated(){} // RVA: 0x38EED40
        public void set_unityPackageUpdated(){} // RVA: 0x38EED50
        public void get_unityVersion(){} // RVA: 0x348120
        public void set_unityVersion(){} // RVA: 0x348130
        public void get_apiVersion(){} // RVA: 0xA002A0
        public void set_apiVersion(){} // RVA: 0x38EED60
        public void get_platform(){} // RVA: 0x3FA100
        public void set_platform(){} // RVA: 0x3FA110
        public void get_assetVersion(){} // RVA: 0x38EED70
        public void set_assetVersion(){} // RVA: 0x38EEE20
        public void .ctor(){} // RVA: 0x38EEEB0
        public void ReadField(){} // RVA: 0x38EEF80
        public void Get(){} // RVA: 0x38EF150
        public void FetchList(){} // RVA: 0x38EF890
        public void AddLocal(){} // RVA: 0x38F1560
        public void IsLocalById(){} // RVA: 0x38F1690
        public void get_IsLocal(){} // RVA: 0x38F1790
        public void Save(){} // RVA: 0x38F1870
        public void SaveReleaseStatus(){} // RVA: 0x38F18F0
        public void GetAssetUrl(){} // RVA: 0x31C010
        public void HasTag(){} // RVA: 0x38F1E30
        public void AddTag(){} // RVA: 0x38F1EA0
        public void RemoveTag(){} // RVA: 0x38F1F40
        public void UpdateVersionAndPlatform(){} // RVA: 0x38F20A0
        public void MakeRequestEndpoint(){} // RVA: 0x38F2230
        public void .cctor(){} // RVA: 0x38F2260
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
        public float <cacheLifetime>k__BackingField; // 0x60
        public System.Nullable`1<long> <ExpiryTime>k__BackingField; // 0x68
        public string[] <requiredFields>k__BackingField; // 0x78
        public System.Collections.Generic.IReadOnlyDictionary`2<string,Token> EmptyDictionary;

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
        public string <name>k__BackingField; // 0x68
        public string <assetBundleId>k__BackingField; // 0x70
        public string <viewfinderAssetBundleId>k__BackingField; // 0x78

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
        public string <UserID>k__BackingField; // 0x68
        public bool <Blocked>k__BackingField; // 0x70

        // ── Methods ──
        public void get_UserID(){} // RVA: 0x358D50
        public void set_UserID(){} // RVA: 0x358D60
        public void get_Blocked(){} // RVA: 0x359320
        public void set_Blocked(){} // RVA: 0x359330
        public void .ctor(){} // RVA: 0x9918230
    }

    public class ApiEconomyStatus
    {
        public bool <EconomyIsOnline>k__BackingField; // 0x68
        public int <EconomyState>k__BackingField; // 0x6C

        // ── Methods ──
        public void get_EconomyIsOnline(){} // RVA: 0x3A5570
        public void set_EconomyIsOnline(){} // RVA: 0x3A5580
        public void get_EconomyState(){} // RVA: 0x1C91460
        public void set_EconomyState(){} // RVA: 0x1C91470
        public void .ctor(){} // RVA: 0x9918280
    }

    public class ApiEconomyStore
    {
        public string <SellerId>k__BackingField; // 0x68
        public string <SellerDisplayName>k__BackingField; // 0x70
        public string <WorldId>k__BackingField; // 0x78
        public string <GroupId>k__BackingField; // 0x80
        public 0x657C7FF0 <StoreStatus>k__BackingField; // 0x88
        public string <DisplayName>k__BackingField; // 0x90
        public string <Description>k__BackingField; // 0x98
        public System.Collections.Generic.List`1<string> <Tags>k__BackingField; // 0xA0
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> <Listings>k__BackingField; // 0xA8
        public System.Collections.Generic.List`1<string> <ListingIDs>k__BackingField; // 0xB0

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
        public string <name>k__BackingField; // 0x68
        public System.Nullable`1<int> <order>k__BackingField; // 0x70
        public string <ownerId>k__BackingField; // 0x78
        public string <mimeType>k__BackingField; // 0x80
        public string <extension>k__BackingField; // 0x88
        public System.Collections.Generic.List`1<Version> <versions>k__BackingField; // 0x90
        public bool <IsInitialized>k__BackingField; // 0x98
        public bool <IsPendingInit>k__BackingField; // 0x99

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
        public string <name>k__BackingField; // 0x68
        public string <groupId>k__BackingField; // 0x70
        public string <galleryId>k__BackingField; // 0x78
        public string _fileId; // 0x80
        public string <imageUrl>k__BackingField; // 0x88
        public System.DateTime <createdAt>k__BackingField; // 0x90
        public bool <approved>k__BackingField; // 0x98
        public System.DateTime <approvedAt>k__BackingField; // 0xA0
        public string <approvedByUserId>k__BackingField; // 0xA8
        public string <submittedByUserId>k__BackingField; // 0xB0
        public VRC.Core.ApiFile <file>k__BackingField; // 0xB8

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
        public string <title>k__BackingField; // 0x68
        public string <message>k__BackingField; // 0x70
        public string <imageId>k__BackingField; // 0x78
        public int <imageVersion>k__BackingField; // 0x80

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
        public string <campaignId>k__BackingField; // 0x68
        public string <hypeTrainId>k__BackingField; // 0x70
        public int <cooldownSeconds>k__BackingField; // 0x78
        public System.DateTime <endDate>k__BackingField; // 0x80
        public long <lastUpdatedAt>k__BackingField; // 0x88
        public System.DateTime <startDate>k__BackingField; // 0x90
        public int <currentGiftCount>k__BackingField; // 0x98
        public int <totalGiftGoal>k__BackingField; // 0x9C
        public int <totalGiftContributors>k__BackingField; // 0xA0
        public int <totalGiftsFromYouCount>k__BackingField; // 0xA4

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
        public VRC.Core.ApiPotentialHypeTrainInfo <potentialTrain>k__BackingField; // 0x68
        public VRC.Core.ApiHypeTrainInfo <current>k__BackingField; // 0x70
        public System.Collections.Generic.List`1<VRC.Core.ApiHypeTrainInfo> <history>k__BackingField; // 0x78

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
        public float CacheTime;
        public bool <isEnabled>k__BackingField; // 0x68
        public string <releaseStatus>k__BackingField; // 0x70
        public System.Collections.Generic.List`1<string> <tags>k__BackingField; // 0x78
        public System.Collections.Generic.List`1<string> <requireClientTags>k__BackingField; // 0x80
        public int <priority>k__BackingField; // 0x88
        public System.DateTime <startDate>k__BackingField; // 0x90
        public System.DateTime <endDate>k__BackingField; // 0x98
        public System.DateTime <createdAt>k__BackingField; // 0xA0
        public System.DateTime <updatedAt>k__BackingField; // 0xA8
        public string <hash>k__BackingField; // 0xB0
        public string <originalManifestId>k__BackingField; // 0xB8
        public AnalyticsExperiment <experiment>k__BackingField; // 0xC0

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
        public System.Collections.Generic.List`1<string> <inventoryItemsToInstantiate>k__BackingField; // 0x68
        public ApiBundleDropNotificationDetails <notificationDetails>k__BackingField; // 0x70

        // ── Methods ──
        public void get_inventoryItemsToInstantiate(){} // RVA: 0x358D50
        public void set_inventoryItemsToInstantiate(){} // RVA: 0x358D60
        public void get_notificationDetails(){} // RVA: 0x3A5590
        public void set_notificationDetails(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9876560
    }

    public class ApiInventoryBundleDrop
    {
        public string ENDPOINT;
        public string <name>k__BackingField; // 0x68
        public string <authorId>k__BackingField; // 0x70
        public string <targetGroup>k__BackingField; // 0x78
        public System.Collections.Generic.List`1<string> <templateIds>k__BackingField; // 0x80
        public System.DateTime <startDropDate>k__BackingField; // 0x88
        public System.DateTime <endDropDate>k__BackingField; // 0x90
        public System.DateTime <dropExpiryDate>k__BackingField; // 0x98
        public string <status>k__BackingField; // 0xA0
        public System.Collections.Generic.List`1<string> <tags>k__BackingField; // 0xA8
        public System.DateTime <created_at>k__BackingField; // 0xB0
        public System.DateTime <updated_at>k__BackingField; // 0xB8

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
        public string ITEM_TEMPLATE_ID_PREFIX;
        public string <templateId>k__BackingField; // 0x68
        public string <name>k__BackingField; // 0x70
        public string <description>k__BackingField; // 0x78
        public string <imageUrl>k__BackingField; // 0x80
        public VRC.Core.ApiProductAttribution <attribution>k__BackingField; // 0x88
        public System.Collections.Generic.List`1<string> <flags>k__BackingField; // 0x90
        public System.Collections.Generic.List`1<string> <tags>k__BackingField; // 0x98
        public System.Collections.Generic.List`1<string> <collections>k__BackingField; // 0xA0
        public string <itemType>k__BackingField; // 0xA8
        public string <holderId>k__BackingField; // 0xB0
        public string <firstAncestor>k__BackingField; // 0xB8
        public string <firstAncestorHolderId>k__BackingField; // 0xC0
        public System.DateTime <expiryDate>k__BackingField; // 0xC8
        public System.DateTime <created_at>k__BackingField; // 0xD0
        public System.DateTime <updated_at>k__BackingField; // 0xD8
        public System.DateTime <template_created_at>k__BackingField; // 0xE0
        public System.DateTime <template_updated_at>k__BackingField; // 0xE8
        public bool <isArchived>k__BackingField; // 0xF0
        public bool <isSeen>k__BackingField; // 0xF1
        public System.DateTime <last_equipped_at>k__BackingField; // 0xF8
        public System.Collections.Generic.List`1<string> <equipSlots>k__BackingField; // 0x100
        public string <equipSlot>k__BackingField; // 0x108
        public int <quantity>k__BackingField; // 0x110
        public bool <quantifiable>k__BackingField; // 0x114
        public System.Collections.Generic.Dictionary`2<string,ItemAttribute> <defaultAttributes>k__BackingField; // 0x118
        public System.Collections.Generic.Dictionary`2<string,object> <userAttributes>k__BackingField; // 0x120
        public bool <validateUserAttributes>k__BackingField; // 0x128
        public ApiBundleDropNotificationDetails <notificationDetails>k__BackingField; // 0x130
        public string <status>k__BackingField; // 0x138
        public VRC.Core.ApiModel <metadata>k__BackingField; // 0x140
        public string ENDPOINT;
        public string FLAG_USER_GENERATED;
        public string FLAG_INSTANTIATABLE;
        public string FLAG_CONSUMABLE;
        public string FLAG_TRASHABLE;
        public string FLAG_ARCHIVABLE;
        public string FLAG_CLONEABLE;
        public string FLAG_EQUIPPABLE;

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
        public System.Collections.Generic.List`1<VRC.Core.ApiInventoryItem> <data>k__BackingField; // 0x68
        public int <totalCount>k__BackingField; // 0x70

        // ── Methods ──
        public void get_data(){} // RVA: 0x358D50
        public void set_data(){} // RVA: 0x358D60
        public void get_totalCount(){} // RVA: 0x10E5CF0
        public void set_totalCount(){} // RVA: 0x475080
        public void .ctor(){} // RVA: 0x987D7D0
    }

    public class ApiInventoryJweToken
    {
        public string <token>k__BackingField; // 0x68

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
        public string <token>k__BackingField; // 0x68
        public int <version>k__BackingField; // 0x70

        // ── Methods ──
        public void get_token(){} // RVA: 0x358D50
        public void set_token(){} // RVA: 0x358D60
        public void get_version(){} // RVA: 0x10E5CF0
        public void set_version(){} // RVA: 0x475080
        public void .ctor(){} // RVA: 0x987F030
    }

    public class ApiLeaderboard
    {
        public VRC.Core.ApiLeaderboardUserStats <userStats>k__BackingField; // 0x68
        public VRC.Core.ApiLeaderboardData <leaderboard>k__BackingField; // 0x70

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
        public bool <state>k__BackingField; // 0x68
        public string <displayName>k__BackingField; // 0x70

        // ── Methods ──
        public void get_state(){} // RVA: 0x3A5570
        public void set_state(){} // RVA: 0x3A5580
        public void get_displayName(){} // RVA: 0x3A5590
        public void set_displayName(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9881760
    }

    public class ApiLeaderboardData
    {
        public System.DateTime <startedAt>k__BackingField; // 0x68
        public System.DateTime <endsAt>k__BackingField; // 0x70
        public System.Collections.Generic.List`1<VRC.Core.ApiLeaderboardRank> <ranks>k__BackingField; // 0x78

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
        public string <displayName>k__BackingField; // 0x68
        public string <iconUrl>k__BackingField; // 0x70
        public int <gifts>k__BackingField; // 0x78
        public bool <isAnonymized>k__BackingField; // 0x7C
        public bool <isSelf>k__BackingField; // 0x7D

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
        public int <rank>k__BackingField; // 0x68
        public int <gifts>k__BackingField; // 0x6C
        public bool <isAnonymized>k__BackingField; // 0x70
        public string <anonymizedDisplayName>k__BackingField; // 0x78

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
        public int <Amount>k__BackingField; // 0x68
        public int <RunningBalance>k__BackingField; // 0x6C
        public System.DateTime <Date>k__BackingField; // 0x70
        public string <ListingDisplayName>k__BackingField; // 0x78
        public string <ListingID>k__BackingField; // 0x80
        public string <ListingType>k__BackingField; // 0x88
        public string <Platform>k__BackingField; // 0x90
        public string <PurchaseId>k__BackingField; // 0x98
        public int <Reason>k__BackingField; // 0xA0
        public VRC.Core.ApiLocalizableString <ReasonLabel>k__BackingField; // 0xA8
        public string <ToUserId>k__BackingField; // 0xB0
        public string <ToUserDisplayName>k__BackingField; // 0xB8
        public string <FromUserId>k__BackingField; // 0xC0
        public string <FromUserDisplayName>k__BackingField; // 0xC8
        public long <TransactionId>k__BackingField; // 0xD0
        public long <TransactionLineId>k__BackingField; // 0xD8

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
        public System.DateTime <StartDate>k__BackingField; // 0x68
        public System.DateTime <EndDate>k__BackingField; // 0x70
        public System.Collections.Generic.List`1<VRC.Core.ApiLedgerTransaction> <Transactions>k__BackingField; // 0x78

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
        public string <LicenseId>k__BackingField; // 0x68
        public string <OwnerId>k__BackingField; // 0x70
        public string <OwnerDisplayName>k__BackingField; // 0x78
        public string <LicenseHolderId>k__BackingField; // 0x80
        public string <LicenseHolderDisplayName>k__BackingField; // 0x88
        public 0x657CFD68 <ForType>k__BackingField; // 0x90
        public string <ForId>k__BackingField; // 0x98
        public string <ProductId>k__BackingField; // 0xA0
        public 0x657CFDC0 <ProductType>k__BackingField; // 0xA8
        public bool <IsActive>k__BackingField; // 0xAC
        public System.DateTime <UntilDate>k__BackingField; // 0xB0
        public bool <IsCurrent>k__BackingField; // 0xB8
        public System.DateTime <Created>k__BackingField; // 0xC0
        public string <ForAction>k__BackingField; // 0xC8
        public string <ForName>k__BackingField; // 0xD0
        public string <LicenseHolderType>k__BackingField; // 0xD8
        public System.Collections.Generic.List`1<VRC.Core.ApiLicenseNote> <Notes>k__BackingField; // 0xE0
        public System.Collections.Generic.List`1<string> <Tags>k__BackingField; // 0xE8
        public System.DateTime <Updated>k__BackingField; // 0xF0

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
        public System.DateTime <CreatedAt>k__BackingField; // 0x68
        public string <Note>k__BackingField; // 0x70

        // ── Methods ──
        public void get_CreatedAt(){} // RVA: 0x358D50
        public void set_CreatedAt(){} // RVA: 0x1F0AB90
        public void get_Note(){} // RVA: 0x3A5590
        public void set_Note(){} // RVA: 0x3A55A0
        public void .ctor(){} // RVA: 0x9882D40
    }

    public class ApiListContainer
    {
        public int <TotalCount>k__BackingField; // 0x60

        // ── Methods ──
        public void get_ResponseList(){} // RVA: 0x98CC2B0
        public void get_TotalCount(){} // RVA: 0x59CEC0
        public void set_TotalCount(){} // RVA: 0x59C530
        public void Validate(){} // RVA: 0x98CC320
        public void .ctor(){} // RVA: 0x98CC6A0
    }

    public class ApiLoadingScreen
    {
        public string <name>k__BackingField; // 0x68
        public string <assetBundleId>k__BackingField; // 0x70

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
        public System.Collections.Generic.Dictionary`2<0x657CA3B0,string> messageTypeToMessageAPI;
        public int MaxMessageLength;
        public int <slot>k__BackingField; // 0x68
        public string <message>k__BackingField; // 0x70
        public string <messageType>k__BackingField; // 0x78
        public System.DateTime <updatedAt>k__BackingField; // 0x80

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
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiContainer> activeRequests;
        public int maximumParseDepth;
        public int currentRemainingDepth; // 0x8
        public Unity.Profiling.ProfilerMarker _setApiFieldsFromJsonProfilerMarker; // 0x10
        public string <id>k__BackingField; // 0x10
        public System.Nullable`1<long> <ExpiryTime>k__BackingField; // 0x18
        public bool <Populated>k__BackingField; // 0x28
        public bool <FailedValidation>k__BackingField; // 0x29
        public string <Endpoint>k__BackingField; // 0x30

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

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x38F2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x38F27C0
        public void Validate(){} // RVA: 0x38F2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x38F2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x38F27C0
        public void Validate(){} // RVA: 0x38F2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x38F2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x38F27C0
        public void Validate(){} // RVA: 0x38F2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x38F2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x38F27C0
        public void Validate(){} // RVA: 0x38F2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x38F2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x38F27C0
        public void Validate(){} // RVA: 0x38F2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x38F2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x38F27C0
        public void Validate(){} // RVA: 0x38F2890
    }

    public class ApiModelContainer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x38F2770 | overloaded x2
        public void ValidModelData(){} // RVA: 0x38F27C0
        public void Validate(){} // RVA: 0x38F2890
    }

}