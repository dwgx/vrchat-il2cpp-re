// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 36
// Methods: 562

namespace VRC.Core
{
    public class ApiPurchaseCancelSubscriptionInfo : ApiModel
    {
        public int RefundableAmount; // 0x68
        public int NonRefundableAmount; // 0x6C
        public int TotalStacksToCancel; // 0x70
        public System.DateTime NewExpirationDate; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBEC7930
        public void get_RefundableAmount(){} // RVA: 0x7FFAC47BAB50
        public void set_RefundableAmount(){} // RVA: 0x7FFAC47BAB60
        public void get_NonRefundableAmount(){} // RVA: 0x7FFAC47BAB70
        public void set_NonRefundableAmount(){} // RVA: 0x7FFAC47BAB80
        public void get_TotalStacksToCancel(){} // RVA: 0x7FFAC3B99E80
        public void set_TotalStacksToCancel(){} // RVA: 0x7FFAC30B6520
        public void get_NewExpirationDate(){} // RVA: 0x7FFAC30E5600
        public void set_NewExpirationDate(){} // RVA: 0x7FFAC8246500
    }

    public class ApiPurchaseSubscriptionCancelledInfo : ApiModel
    {
        public int AmountRefunded; // 0x68
        public int TotalStacksCancelled; // 0x6C
        public System.DateTime NewExpirationDate; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBEC7980
        public void get_AmountRefunded(){} // RVA: 0x7FFAC47BAB50
        public void set_AmountRefunded(){} // RVA: 0x7FFAC47BAB60
        public void get_TotalStacksCancelled(){} // RVA: 0x7FFAC47BAB70
        public void set_TotalStacksCancelled(){} // RVA: 0x7FFAC47BAB80
        public void get_NewExpirationDate(){} // RVA: 0x7FFAC2FE9590
        public void set_NewExpirationDate(){} // RVA: 0x7FFAC4A2BA60
    }

    public class ApiReport : ApiModel
    {
        public string type; // 0x68
        public string category; // 0x70
        public string reason; // 0x78
        public string contentId; // 0x80
        public string description; // 0x88
        public VRC.Core.ApiReportDetails details; // 0x90
        public string contentName; // 0x98
        public string contentThumbnailImageUrl; // 0xA0

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAC2F9CD50
        public void set_type(){} // RVA: 0x7FFAC2F9CD60
        public void get_category(){} // RVA: 0x7FFAC2FE9590
        public void set_category(){} // RVA: 0x7FFAC2FE95A0
        public void get_reason(){} // RVA: 0x7FFAC30E5600
        public void set_reason(){} // RVA: 0x7FFAC30E06F0
        public void get_contentId(){} // RVA: 0x7FFAC32EF410
        public void set_contentId(){} // RVA: 0x7FFAC34D4AA0
        public void get_description(){} // RVA: 0x7FFAC2F60010
        public void set_description(){} // RVA: 0x7FFAC354E300
        public void get_details(){} // RVA: 0x7FFAC32EF640
        public void set_details(){} // RVA: 0x7FFAC354E360
        public void get_contentName(){} // RVA: 0x7FFAC354DFB0
        public void set_contentName(){} // RVA: 0x7FFAC354E3C0
        public void get_contentThumbnailImageUrl(){} // RVA: 0x7FFAC3543900
        public void set_contentThumbnailImageUrl(){} // RVA: 0x7FFAC354E420
        public void AddReport(){} // RVA: 0x7FFACBECB930
        public void FetchReports(){} // RVA: 0x7FFACBECBC50
        public void DeleteReport(){} // RVA: 0x7FFACBECC2F0
        public void .ctor(){} // RVA: 0x7FFACBECC600
    }

    public class ApiReportDetails : ApiModel
    {
        public System.Collections.Generic.List`1<string> suggestedWarnings; // 0x68
        public string instanceType; // 0x70
        public System.Nullable`1<bool> instanceAgeGated; // 0x78
        public System.Nullable`1<bool> userInSameInstance; // 0x7A
        public string imageType; // 0x80
        public string fileId; // 0x88
        public string holderId; // 0x90

        // ── Methods ──
        public void get_suggestedWarnings(){} // RVA: 0x7FFAC2F9CD50
        public void set_suggestedWarnings(){} // RVA: 0x7FFAC2F9CD60
        public void get_instanceType(){} // RVA: 0x7FFAC2FE9590
        public void set_instanceType(){} // RVA: 0x7FFAC2FE95A0
        public void get_instanceAgeGated(){} // RVA: 0x7FFAC87305F0
        public void set_instanceAgeGated(){} // RVA: 0x7FFACBECC7B0
        public void get_userInSameInstance(){} // RVA: 0x7FFACBECC7C0
        public void set_userInSameInstance(){} // RVA: 0x7FFACBECC7D0
        public void get_imageType(){} // RVA: 0x7FFAC32EF410
        public void set_imageType(){} // RVA: 0x7FFAC34D4AA0
        public void get_fileId(){} // RVA: 0x7FFAC2F60010
        public void set_fileId(){} // RVA: 0x7FFAC354E300
        public void get_holderId(){} // RVA: 0x7FFAC32EF640
        public void set_holderId(){} // RVA: 0x7FFAC354E360
        public void .ctor(){} // RVA: 0x7FFACBECC7E0
    }

    public class ApiReportResponse : ApiModel
    {
        public bool evidenceRequired; // 0x68
        public bool supportRequired; // 0x69

        // ── Methods ──
        public void get_evidenceRequired(){} // RVA: 0x7FFAC2FE9570
        public void set_evidenceRequired(){} // RVA: 0x7FFAC2FE9580
        public void get_supportRequired(){} // RVA: 0x7FFAC4670BD0
        public void set_supportRequired(){} // RVA: 0x7FFAC466E010
        public void .ctor(){} // RVA: 0x7FFACBECC880
    }

    public class ApiReportsContainer : ApiModel
    {
        public bool hasNext; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.ApiReport> results; // 0x70
        public int totalCount; // 0x78

        // ── Methods ──
        public void get_hasNext(){} // RVA: 0x7FFAC2FE9570
        public void set_hasNext(){} // RVA: 0x7FFAC2FE9580
        public void get_results(){} // RVA: 0x7FFAC2FE9590
        public void set_results(){} // RVA: 0x7FFAC2FE95A0
        public void get_totalCount(){} // RVA: 0x7FFAC4596EF0
        public void set_totalCount(){} // RVA: 0x7FFAC45963A0
        public void .ctor(){} // RVA: 0x7FFACBECC830
    }

    public class ApiSearchGroupResults : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.APIGroup> results; // 0x68
        public int totalCount; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFAC2F9CD50
        public void set_results(){} // RVA: 0x7FFAC2F9CD60
        public void get_totalCount(){} // RVA: 0x7FFAC3B99E80
        public void set_totalCount(){} // RVA: 0x7FFAC30B6520
        public void .ctor(){} // RVA: 0x7FFACBED2A70
    }

    public class ApiSearchUserResults : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.APIUser> results; // 0x68
        public int totalCount; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFAC2F9CD50
        public void set_results(){} // RVA: 0x7FFAC2F9CD60
        public void get_totalCount(){} // RVA: 0x7FFAC3B99E80
        public void set_totalCount(){} // RVA: 0x7FFAC30B6520
        public void .ctor(){} // RVA: 0x7FFACBED2A20
    }

    public class ApiSearchWorldResults : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.ApiWorld> results; // 0x68
        public int totalCount; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFAC2F9CD50
        public void set_results(){} // RVA: 0x7FFAC2F9CD60
        public void get_totalCount(){} // RVA: 0x7FFAC3B99E80
        public void set_totalCount(){} // RVA: 0x7FFAC30B6520
        public void .ctor(){} // RVA: 0x7FFACBED29D0
    }

    public class ApiSharedConnectionCounts : ApiModel
    {
        public float CacheLifetime;
        public int friends; // 0x68
        public int groups; // 0x6C

        // ── Methods ──
        public void get_CacheLifetime(){} // RVA: 0x7FFACBF26AF0
        public void get_friends(){} // RVA: 0x7FFAC47BAB50
        public void set_friends(){} // RVA: 0x7FFAC47BAB60
        public void get_groups(){} // RVA: 0x7FFAC47BAB70
        public void set_groups(){} // RVA: 0x7FFAC47BAB80
        public void FetchSharedConnectionCountsAsync(){} // RVA: 0x7FFACBF26C80
        public void GetLifeSpan(){} // RVA: 0x7FFACBF26AF0
        public void .ctor(){} // RVA: 0x7FFACBF26E30
    }

    public class ApiSteamVRChatFinalizeTransactionResponse : ApiVRChatSubscriptionBaseResponse
    {
        public string status; // 0x70

        // ── Methods ──
        public void get_status(){} // RVA: 0x7FFAC2FE9590
        public void set_status(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBEF12C0
    }

    public class ApiSteamVRChatSubscriptionSteamTransaction : ApiModel
    {
        public VRC.Core.ApiSteamVRChatSubscriptionWalletInformation walletInfo; // 0x68
        public string steamId; // 0x70
        public string orderId; // 0x78
        public string steamUrl; // 0x80
        public string transId; // 0x88

        // ── Methods ──
        public void get_walletInfo(){} // RVA: 0x7FFAC2F9CD50
        public void set_walletInfo(){} // RVA: 0x7FFAC2F9CD60
        public void get_steamId(){} // RVA: 0x7FFAC2FE9590
        public void set_steamId(){} // RVA: 0x7FFAC2FE95A0
        public void get_orderId(){} // RVA: 0x7FFAC30E5600
        public void set_orderId(){} // RVA: 0x7FFAC30E06F0
        public void get_steamUrl(){} // RVA: 0x7FFAC32EF410
        public void set_steamUrl(){} // RVA: 0x7FFAC34D4AA0
        public void get_transId(){} // RVA: 0x7FFAC2F60010
        public void set_transId(){} // RVA: 0x7FFAC354E300
        public void .ctor(){} // RVA: 0x7FFACBEF1950
    }

    public class ApiSteamVRChatSubscriptionTransaction : ApiVRChatSubscriptionBaseResponse
    {
        public string status; // 0x70
        public VRC.Core.ApiVRChatSubscription subscription; // 0x78
        public bool sandbox; // 0x80
        public string created_at; // 0x88
        public string updated_at; // 0x90
        public VRC.Core.ApiSteamVRChatSubscriptionSteamTransaction steam; // 0x98

        // ── Methods ──
        public void get_status(){} // RVA: 0x7FFAC2FE9590
        public void set_status(){} // RVA: 0x7FFAC2FE95A0
        public void get_subscription(){} // RVA: 0x7FFAC30E5600
        public void set_subscription(){} // RVA: 0x7FFAC30E06F0
        public void get_sandbox(){} // RVA: 0x7FFAC313E620
        public void set_sandbox(){} // RVA: 0x7FFAC313D3B0
        public void get_created_at(){} // RVA: 0x7FFAC2F60010
        public void set_created_at(){} // RVA: 0x7FFAC354E300
        public void get_updated_at(){} // RVA: 0x7FFAC32EF640
        public void set_updated_at(){} // RVA: 0x7FFAC354E360
        public void get_steam(){} // RVA: 0x7FFAC354DFB0
        public void set_steam(){} // RVA: 0x7FFAC354E3C0
        public void .ctor(){} // RVA: 0x7FFACBEF12C0
    }

    public class ApiSteamVRChatSubscriptionWalletInformation : ApiModel
    {
        public string state; // 0x68
        public string country; // 0x70
        public string currency; // 0x78
        public string status; // 0x80

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFAC2F9CD50
        public void set_state(){} // RVA: 0x7FFAC2F9CD60
        public void get_country(){} // RVA: 0x7FFAC2FE9590
        public void set_country(){} // RVA: 0x7FFAC2FE95A0
        public void get_currency(){} // RVA: 0x7FFAC30E5600
        public void set_currency(){} // RVA: 0x7FFAC30E06F0
        public void get_status(){} // RVA: 0x7FFAC32EF410
        public void set_status(){} // RVA: 0x7FFAC34D4AA0
        public void .ctor(){} // RVA: 0x7FFACBEF1900
    }

    public class ApiStoreShelf : ApiModel
    {
        public string ShelfTitle; // 0x68
        public string ShelfDescription; // 0x70
        public string ShelfLayout; // 0x78
        public System.DateTime UpdatedAt; // 0x80
        public System.DateTime CreatedAt; // 0x88
        public System.Collections.Generic.List`1<string> ListingIds; // 0x90
        public string ShelfVisibility; // 0x98
        public string StoreId; // 0xA0
        public string SellerId; // 0xA8
        public string HighlightListingId; // 0xB0
        public string ShelfTabBackgroundImageId; // 0xB8
        public string ShelfTabBackgroundImageUrl; // 0xC0
        public string ShelfBackgroundImageId; // 0xC8
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> ShelfBackgroundImageUrl; // 0xD0
        public VRC.Core.ApiProduct ShelfIconImageId; // 0xD8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBF21300
        public void get_ShelfTitle(){} // RVA: 0x7FFAC2F9CD50
        public void set_ShelfTitle(){} // RVA: 0x7FFAC2F9CD60
        public void get_ShelfDescription(){} // RVA: 0x7FFAC2FE9590
        public void set_ShelfDescription(){} // RVA: 0x7FFAC2FE95A0
        public void get_ShelfLayout(){} // RVA: 0x7FFAC30E5600
        public void set_ShelfLayout(){} // RVA: 0x7FFAC30E06F0
        public void get_UpdatedAt(){} // RVA: 0x7FFAC32EF410
        public void set_UpdatedAt(){} // RVA: 0x7FFAC4A2BA90
        public void get_CreatedAt(){} // RVA: 0x7FFAC2F60010
        public void set_CreatedAt(){} // RVA: 0x7FFAC4A2BA70
        public void get_ListingIds(){} // RVA: 0x7FFAC32EF640
        public void set_ListingIds(){} // RVA: 0x7FFAC354E360
        public void get_ShelfVisibility(){} // RVA: 0x7FFAC354DFB0
        public void set_ShelfVisibility(){} // RVA: 0x7FFAC354E3C0
        public void get_StoreId(){} // RVA: 0x7FFAC3543900
        public void set_StoreId(){} // RVA: 0x7FFAC354E420
        public void get_SellerId(){} // RVA: 0x7FFAC354B1A0
        public void set_SellerId(){} // RVA: 0x7FFAC334B370
        public void get_HighlightListingId(){} // RVA: 0x7FFAC2F8C040
        public void set_HighlightListingId(){} // RVA: 0x7FFAC2F8C050
        public void get_ShelfTabBackgroundImageId(){} // RVA: 0x7FFAC2F8C0B0
        public void set_ShelfTabBackgroundImageId(){} // RVA: 0x7FFAC2F8C0C0
        public void get_ShelfTabBackgroundImageUrl(){} // RVA: 0x7FFACBF21350
        public void get_ShelfBackgroundImageId(){} // RVA: 0x7FFAC2F8C120
        public void set_ShelfBackgroundImageId(){} // RVA: 0x7FFAC2F8C130
        public void get_ShelfBackgroundImageUrl(){} // RVA: 0x7FFACBF213C0
        public void get_ShelfIconImageId(){} // RVA: 0x7FFAC3079460
        public void set_ShelfIconImageId(){} // RVA: 0x7FFAC3079470
        public void get_ShelfIconImageUrl(){} // RVA: 0x7FFACBF21430
        public void get_Listings(){} // RVA: 0x7FFAC303E100
        public void set_Listings(){} // RVA: 0x7FFAC303E110
        public void get_HighlightListing(){} // RVA: 0x7FFAC3540F70
        public void set_HighlightListing(){} // RVA: 0x7FFAC2FA28A0
    }

    public class ApiStringArrayContainer : ApiContainer
    {
        public object responseArray;

        // ── Methods ──
        public void get_responseArray(){} // RVA: 0x7FFACBECD5E0
        public void Validate(){} // RVA: 0x7FFACBECD620
        public void .ctor(){} // RVA: 0x7FFACBECD430
    }

    public class ApiStringContainer : ApiContainer
    {
        public object ResponseString;

        // ── Methods ──
        public void get_ResponseString(){} // RVA: 0x7FFACBECD440
        public void Validate(){} // RVA: 0x7FFACBECD490
        public void .ctor(){} // RVA: 0x7FFACBECD430
    }

    public class ApiTokenBundle : ApiModel
    {
        public int steamItemId; // 0x68
        public string oculusSku; // 0x70
        public string googleProductId; // 0x78
        public string picoSku; // 0x80
        public int amount; // 0x88
        public string description; // 0x90
        public int tokens; // 0x98
        public string imageUrl; // 0xA0

        // ── Methods ──
        public void get_steamItemId(){} // RVA: 0x7FFAC47BAB50
        public void set_steamItemId(){} // RVA: 0x7FFAC47BAB60
        public void get_oculusSku(){} // RVA: 0x7FFAC2FE9590
        public void set_oculusSku(){} // RVA: 0x7FFAC2FE95A0
        public void get_googleProductId(){} // RVA: 0x7FFAC30E5600
        public void set_googleProductId(){} // RVA: 0x7FFAC30E06F0
        public void get_picoSku(){} // RVA: 0x7FFAC32EF410
        public void set_picoSku(){} // RVA: 0x7FFAC34D4AA0
        public void get_amount(){} // RVA: 0x7FFAC37EE8C0
        public void set_amount(){} // RVA: 0x7FFAC37F9DE0
        public void get_description(){} // RVA: 0x7FFAC32EF640
        public void set_description(){} // RVA: 0x7FFAC354E360
        public void get_tokens(){} // RVA: 0x7FFAC489E530
        public void set_tokens(){} // RVA: 0x7FFAC489E540
        public void get_imageUrl(){} // RVA: 0x7FFAC3543900
        public void set_imageUrl(){} // RVA: 0x7FFAC354E420
        public void Fetch(){} // RVA: 0x7FFACBED37E0
        public void .ctor(){} // RVA: 0x7FFACBED3AE0
    }

    public class ApiTokenPurchase : ApiTokenBundle
    {
        public System.DateTime PurchaseDate; // 0xA8

        // ── Methods ──
        public void get_PurchaseDate(){} // RVA: 0x7FFAC354B1A0
        public void set_PurchaseDate(){} // RVA: 0x7FFAC45C9F60
        public void .ctor(){} // RVA: 0x7FFACBED3AE0
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
        public System.DateTime Date; // 0xA8
        public int Amount; // 0xB0
        public int RunningBalance; // 0xB4
        public string ImageId; // 0xB8
        public string PurchaseId; // 0xC0
        public string TiliaRef; // 0xC8

        // ── Methods ──
        public void get_ListingID(){} // RVA: 0x7FFAC2F9CD50
        public void set_ListingID(){} // RVA: 0x7FFAC2F9CD60
        public void get_Name(){} // RVA: 0x7FFAC2FE9590
        public void set_Name(){} // RVA: 0x7FFAC2FE95A0
        public void get_SellerId(){} // RVA: 0x7FFAC30E5600
        public void set_SellerId(){} // RVA: 0x7FFAC30E06F0
        public void get_FromUserDisplayName(){} // RVA: 0x7FFAC32EF410
        public void set_FromUserDisplayName(){} // RVA: 0x7FFAC34D4AA0
        public void get_SellerDisplayName(){} // RVA: 0x7FFAC2F60010
        public void set_SellerDisplayName(){} // RVA: 0x7FFAC354E300
        public void get_BuyerId(){} // RVA: 0x7FFAC32EF640
        public void set_BuyerId(){} // RVA: 0x7FFAC354E360
        public void get_BuyerDisplayName(){} // RVA: 0x7FFAC354DFB0
        public void set_BuyerDisplayName(){} // RVA: 0x7FFAC354E3C0
        public void get_Type(){} // RVA: 0x7FFAC3543900
        public void set_Type(){} // RVA: 0x7FFAC354E420
        public void get_Date(){} // RVA: 0x7FFAC354B1A0
        public void set_Date(){} // RVA: 0x7FFAC45C9F60
        public void get_Amount(){} // RVA: 0x7FFAC4BF81F0
        public void set_Amount(){} // RVA: 0x7FFAC87B5A90
        public void get_RunningBalance(){} // RVA: 0x7FFAC6715300
        public void set_RunningBalance(){} // RVA: 0x7FFAC6715310
        public void get_ImageId(){} // RVA: 0x7FFAC2F8C0B0
        public void set_ImageId(){} // RVA: 0x7FFAC2F8C0C0
        public void get_PurchaseId(){} // RVA: 0x7FFAC2F8C120
        public void set_PurchaseId(){} // RVA: 0x7FFAC2F8C130
        public void get_TiliaRef(){} // RVA: 0x7FFAC3079460
        public void set_TiliaRef(){} // RVA: 0x7FFAC3079470
        public void get_TransactionImageUrl(){} // RVA: 0x7FFACBED4F00
        public void FetchList(){} // RVA: 0x7FFACBED4F70
        public void .ctor(){} // RVA: 0x7FFACBED5EA0
    }

    public class ApiUserIcon : ApiFile
    {
        public int MAX_USER_ICONS;
        public string endpoint;

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFAC2F21320
        public void FetchList(){} // RVA: 0x7FFACBEEE640
        public void UploadIcon(){} // RVA: 0x7FFACBEEF0B0
        public void .ctor(){} // RVA: 0x7FFACBE785E0
    }

    public class ApiUserPermission : ApiModel
    {
        public string ownerId; // 0x68
        public string name; // 0x70
        public System.Collections.Generic.Dictionary`2<string,object> data; // 0x78

        // ── Methods ──
        public void get_ownerId(){} // RVA: 0x7FFAC2F9CD50
        public void set_ownerId(){} // RVA: 0x7FFAC2F9CD60
        public void get_name(){} // RVA: 0x7FFAC2FE9590
        public void set_name(){} // RVA: 0x7FFAC2FE95A0
        public void get_data(){} // RVA: 0x7FFAC30E5600
        public void set_data(){} // RVA: 0x7FFAC30E06F0
        public void .ctor(){} // RVA: 0x7FFACBEF0400
    }

    public class ApiUserPermissions : Object
    {
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiUserPermission> permissions; // 0x10
        public int MAX_USER_ICONS;
        public int MAX_USER_IMAGES;

        // ── Methods ──
        public void GetPermission_UserIcon(){} // RVA: 0x7FFACBEEF720
        public void GetPermission_InvitePhotos(){} // RVA: 0x7FFACBEEF7A0
        public void GetPermission_ExtraFavoriteAvatars(){} // RVA: 0x7FFACBEEF820
        public void GetPermission_UserGallery(){} // RVA: 0x7FFACBEEF8A0
        public void GetPermission_ProfilePictureOverride(){} // RVA: 0x7FFACBEEF920
        public void GetPermission_MaximumUserIcons(){} // RVA: 0x7FFAC3408770
        public void GetPermission_MaximumUserImages(){} // RVA: 0x7FFAC3408770
        public void GetPermission_UseProps(){} // RVA: 0x7FFACBEEF9A0
        public void GetPermission_UploadProps(){} // RVA: 0x7FFACBEEFA20
        public void GetPermission_TestProps(){} // RVA: 0x7FFACBEEFAA0
        public void Clear(){} // RVA: 0x7FFACBEEFB20
        public void FetchPermissions(){} // RVA: 0x7FFACBEEFB70
        public void .ctor(){} // RVA: 0x7FFACBEEFE70
    }

    public class ApiUserPlatformList : ApiModel
    {
        public System.Collections.Generic.List`1<string> platforms; // 0x68

        // ── Methods ──
        public void get_platforms(){} // RVA: 0x7FFAC2F9CD50
        public void set_platforms(){} // RVA: 0x7FFAC2F9CD60
        public void .ctor(){} // RVA: 0x7FFACBEF0E60
    }

    public class ApiUserPlatforms : Object
    {
        public 0x6B0AFC18 platforms; // 0x10
        public VRC.Core.ApiUserPlatforms CurrentUserPlatforms;

        // ── Methods ──
        public void get_platforms(){} // RVA: 0x7FFAC2F6E5C0
        public void set_platforms(){} // RVA: 0x7FFAC2F240C0
        public void get_CurrentUserPlatforms(){} // RVA: 0x7FFACBEF0450
        public void set_CurrentUserPlatforms(){} // RVA: 0x7FFACBEF0490
        public void Fetch(){} // RVA: 0x7FFACBEF0530
        public void Clear(){} // RVA: 0x7FFACBEF0870
        public void get_SupportsStandaloneWindows(){} // RVA: 0x7FFACBEF0880
        public void get_SupportsAndroid(){} // RVA: 0x7FFACBEF0890
        public void get_SupportsiOS(){} // RVA: 0x7FFACBEF08A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ApiVRChatAdminSubscriptionTransaction : ApiVRChatSubscriptionBaseResponse
    {
        public string userId; // 0x70
        public string adminUserId; // 0x78
        public string expiry; // 0x80
        public VRC.Core.ApiVRChatSubscription subscription; // 0x88

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFAC2FE9590
        public void set_userId(){} // RVA: 0x7FFAC2FE95A0
        public void get_adminUserId(){} // RVA: 0x7FFAC30E5600
        public void set_adminUserId(){} // RVA: 0x7FFAC30E06F0
        public void get_expiry(){} // RVA: 0x7FFAC32EF410
        public void set_expiry(){} // RVA: 0x7FFAC34D4AA0
        public void get_subscription(){} // RVA: 0x7FFAC2F60010
        public void set_subscription(){} // RVA: 0x7FFAC354E300
        public void .ctor(){} // RVA: 0x7FFACBEF12C0
    }

    public class ApiVRChatProductDetails : ApiModel
    {
        public bool enabled; // 0x68
        public string productType; // 0x70
        public System.Nullable`1<0x6B0B3A50> Product; // 0x78
        public string endpoint; // 0x80
        public System.Collections.Generic.Dictionary`2<string,ApiVRChatProductStore> stores; // 0x88
        public Info subscriptionInfo; // 0x90
        public GiftInfo giftInfo; // 0x98
        public TokenInfo tokenInfo; // 0xA0
        public string description; // 0xA8

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFAC2FE9570
        public void set_enabled(){} // RVA: 0x7FFAC2FE9580
        public void get_productType(){} // RVA: 0x7FFAC2FE9590
        public void set_productType(){} // RVA: 0x7FFAC2FE95A0
        public void get_Product(){} // RVA: 0x7FFACBEF0FF0
        public void get_endpoint(){} // RVA: 0x7FFAC32EF410
        public void set_endpoint(){} // RVA: 0x7FFAC34D4AA0
        public void get_stores(){} // RVA: 0x7FFAC2F60010
        public void set_stores(){} // RVA: 0x7FFAC354E300
        public void get_subscriptionInfo(){} // RVA: 0x7FFAC32EF640
        public void set_subscriptionInfo(){} // RVA: 0x7FFAC354E360
        public void get_giftInfo(){} // RVA: 0x7FFAC354DFB0
        public void set_giftInfo(){} // RVA: 0x7FFAC354E3C0
        public void get_tokenInfo(){} // RVA: 0x7FFAC3543900
        public void set_tokenInfo(){} // RVA: 0x7FFAC354E420
        public void get_description(){} // RVA: 0x7FFAC354B1A0
        public void set_description(){} // RVA: 0x7FFAC334B370
        public void .ctor(){} // RVA: 0x7FFACBEF10E0
    }

    public class ApiVRChatSubscription : ApiModel
    {
        public string transactionId; // 0x68
        public string steamItemId; // 0x70
        public ulong amount; // 0x78
        public string description; // 0x80
        public string store; // 0x88
        public string period; // 0x90
        public bool active; // 0x98
        public string status; // 0xA0
        public int tier; // 0xA8
        public string starts; // 0xB0
        public string expires; // 0xB8
        public string created_at; // 0xC0
        public string updated_at; // 0xC8
        public bool isGift; // 0xD0
        public bool isBulkGift; // 0xD1
        public string giftedBy; // 0xD8
        public string giftedByDisplayName; // 0xE0
        public System.Collections.Generic.List`1<string> licenseGroups; // 0xE8
        public VendorData vendorData; // 0xF0

        // ── Methods ──
        public void get_transactionId(){} // RVA: 0x7FFAC2F9CD50
        public void set_transactionId(){} // RVA: 0x7FFAC2F9CD60
        public void get_steamItemId(){} // RVA: 0x7FFAC2FE9590
        public void set_steamItemId(){} // RVA: 0x7FFAC2FE95A0
        public void get_amount(){} // RVA: 0x7FFAC30E5600
        public void set_amount(){} // RVA: 0x7FFAC8246500
        public void get_description(){} // RVA: 0x7FFAC32EF410
        public void set_description(){} // RVA: 0x7FFAC34D4AA0
        public void get_store(){} // RVA: 0x7FFAC2F60010
        public void set_store(){} // RVA: 0x7FFAC354E300
        public void get_period(){} // RVA: 0x7FFAC32EF640
        public void set_period(){} // RVA: 0x7FFAC354E360
        public void get_active(){} // RVA: 0x7FFAC339A7F0
        public void set_active(){} // RVA: 0x7FFAC339FA20
        public void get_status(){} // RVA: 0x7FFAC3543900
        public void set_status(){} // RVA: 0x7FFAC354E420
        public void get_tier(){} // RVA: 0x7FFAC39055C0
        public void set_tier(){} // RVA: 0x7FFAC38FD010
        public void get_starts(){} // RVA: 0x7FFAC2F8C040
        public void set_starts(){} // RVA: 0x7FFAC2F8C050
        public void get_expires(){} // RVA: 0x7FFAC2F8C0B0
        public void set_expires(){} // RVA: 0x7FFAC2F8C0C0
        public void get_created_at(){} // RVA: 0x7FFAC2F8C120
        public void set_created_at(){} // RVA: 0x7FFAC2F8C130
        public void get_updated_at(){} // RVA: 0x7FFAC3079460
        public void set_updated_at(){} // RVA: 0x7FFAC3079470
        public void get_isGift(){} // RVA: 0x7FFAC33CFDE0
        public void set_isGift(){} // RVA: 0x7FFAC4323510
        public void get_isBulkGift(){} // RVA: 0x7FFAC8B3DE40
        public void set_isBulkGift(){} // RVA: 0x7FFAC8B3DE50
        public void get_giftedBy(){} // RVA: 0x7FFAC3540F70
        public void set_giftedBy(){} // RVA: 0x7FFAC2FA28A0
        public void get_giftedByDisplayName(){} // RVA: 0x7FFAC2FA2900
        public void set_giftedByDisplayName(){} // RVA: 0x7FFAC2FA2910
        public void get_licenseGroups(){} // RVA: 0x7FFAC2FA2970
        public void set_licenseGroups(){} // RVA: 0x7FFAC2FA2980
        public void get_vendorData(){} // RVA: 0x7FFAC2F8C2A0
        public void set_vendorData(){} // RVA: 0x7FFAC2F8C2B0
        public void ToString(){} // RVA: 0x7FFACBEF1310
        public void .ctor(){} // RVA: 0x7FFACBEF1860
    }

    public class ApiVRChatSubscriptionBaseResponse : ApiModel
    {
        public VRC.Core.ApiVRChatSubscriptionError error; // 0x68

        // ── Methods ──
        public void get_error(){} // RVA: 0x7FFAC2F9CD50
        public void set_error(){} // RVA: 0x7FFAC2F9CD60
        public void .ctor(){} // RVA: 0x7FFACBEF12C0
    }

    public class ApiVRChatSubscriptionError : Object
    {
        public int status_code; // 0x10
        public string message; // 0x18

        // ── Methods ──
        public void get_status_code(){} // RVA: 0x7FFAC2F6E5C0
        public void set_status_code(){} // RVA: 0x7FFAC2F240C0
        public void get_message(){} // RVA: 0x7FFAC2F247C0
        public void set_message(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ApiViewfinderSkin : ApiModel
    {
        public string name; // 0x68
        public string assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_assetBundleId(){} // RVA: 0x7FFAC2FE9590
        public void set_assetBundleId(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBEF0EB0
    }

    public class ApiWarpEffectSkin : ApiModel
    {
        public string name; // 0x68
        public string assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_assetBundleId(){} // RVA: 0x7FFAC2FE9590
        public void set_assetBundleId(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFACBEF19A0
    }

    public class ApiWorld : ApiModel
    {
        public VRC.Core.AssetVersion VERSION;
        public VRC.Core.AssetVersion name; // 0x8
        public float imageUrl;
        public float thumbnailImageUrl;
        public string authorName;
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiWorld> releaseStatus; // 0x10
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
        public System.DateTime unityPackageUrl; // 0xB0
        public string version; // 0xB8
        public string unityVersion; // 0xC0
        public System.Collections.Generic.List`1<string> apiVersion; // 0xC8
        public System.Collections.Generic.List`1<string> latestAssetVersion; // 0xD0
        public string created_at; // 0xD8
        public int updated_at; // 0xE0
        public string publicationDate; // 0xE8
        public int labsPublicationDate; // 0xF0
        public int udonProducts; // 0xF4
        public System.DateTime storeId; // 0xF8
        public System.DateTime platform; // 0x100
        public System.DateTime worldInstances; // 0x108
        public System.DateTime isAdminApproved; // 0x110
        public System.Collections.Generic.List`1<string> IsCommunityLabsWorld; // 0x118
        public string IsPublicPublishedWorld; // 0x120
        public string IsInternalWorld; // 0x128
        public System.Collections.Generic.List`1<VRC.Core.ApiWorldInstance> unityPackageUpdated; // 0x130
        public bool organization; // 0x138
        public string shouldAddToAuthor; // 0x140
        public bool favoriteId; // 0x148
        public string favorites; // 0x150
        public int visits; // 0x158
        public int popularity; // 0x15C
        public int heat; // 0x160
        public int detailed; // 0x164
        public bool defaultContentSettings; // 0x168
        public System.Collections.Generic.Dictionary`2<string,bool> assetVersion; // 0x170
        public string BundleSignature; // 0x178
        public bool isCurated; // 0x180
        public System.Text.RegularExpressions.Regex publicTags; // 0x18

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7FFACBEF19F0
        public void ShouldCache(){} // RVA: 0x7FFACBEF1BF0
        public void GetLifeSpan(){} // RVA: 0x7FFACBEF1C40
        public void get_name(){} // RVA: 0x7FFAC2F9CD50
        public void set_name(){} // RVA: 0x7FFAC2F9CD60
        public void get_imageUrl(){} // RVA: 0x7FFAC2FE9590
        public void set_imageUrl(){} // RVA: 0x7FFAC2FE95A0
        public void get_thumbnailImageUrl(){} // RVA: 0x7FFAC30E5600
        public void set_thumbnailImageUrl(){} // RVA: 0x7FFAC30E06F0
        public void get_authorName(){} // RVA: 0x7FFAC32EF410
        public void set_authorName(){} // RVA: 0x7FFAC34D4AA0
        public void get_releaseStatus(){} // RVA: 0x7FFAC2F60010
        public void set_releaseStatus(){} // RVA: 0x7FFAC354E300
        public void get_capacity(){} // RVA: 0x7FFAC3220660
        public void set_capacity(){} // RVA: 0x7FFAC34D2750
        public void get_recommendedCapacity(){} // RVA: 0x7FFAC3220670
        public void set_recommendedCapacity(){} // RVA: 0x7FFAC342B670
        public void get_occupants(){} // RVA: 0x7FFAC489E530
        public void set_occupants(){} // RVA: 0x7FFAC489E540
        public void get_publicOccupants(){} // RVA: 0x7FFAC489E520
        public void set_publicOccupants(){} // RVA: 0x7FFAC489EAA0
        public void get_privateOccupants(){} // RVA: 0x7FFAC489E510
        public void set_privateOccupants(){} // RVA: 0x7FFAC489E550
        public void get_authorId(){} // RVA: 0x7FFAC354B1A0
        public void set_authorId(){} // RVA: 0x7FFAC334B370
        public void get_createdAt(){} // RVA: 0x7FFAC2F8C040
        public void set_createdAt(){} // RVA: 0x7FFAC45CA6B0
        public void get_assetUrl(){} // RVA: 0x7FFAC2F8C0B0
        public void set_assetUrl(){} // RVA: 0x7FFAC2F8C0C0
        public void get_description(){} // RVA: 0x7FFAC2F8C120
        public void set_description(){} // RVA: 0x7FFAC2F8C130
        public void get_tags(){} // RVA: 0x7FFAC3079460
        public void set_tags(){} // RVA: 0x7FFAC3079470
        public void get_urlList(){} // RVA: 0x7FFAC303E100
        public void set_urlList(){} // RVA: 0x7FFAC303E110
        public void get_unityPackageUrl(){} // RVA: 0x7FFAC3540F70
        public void set_unityPackageUrl(){} // RVA: 0x7FFAC2FA28A0
        public void get_version(){} // RVA: 0x7FFAC4837F50
        public void set_version(){} // RVA: 0x7FFAC4837F60
        public void get_unityVersion(){} // RVA: 0x7FFAC2FA2970
        public void set_unityVersion(){} // RVA: 0x7FFAC2FA2980
        public void get_apiVersion(){} // RVA: 0x7FFAC60855D0
        public void set_apiVersion(){} // RVA: 0x7FFAC8A11630
        public void get_latestAssetVersion(){} // RVA: 0x7FFAC6715830
        public void set_latestAssetVersion(){} // RVA: 0x7FFAC6715840
        public void get_created_at(){} // RVA: 0x7FFAC3331F50
        public void set_created_at(){} // RVA: 0x7FFAC6715870
        public void get_updated_at(){} // RVA: 0x7FFAC34F6C80
        public void set_updated_at(){} // RVA: 0x7FFAC4196020
        public void get_publicationDate(){} // RVA: 0x7FFAC36D1F40
        public void set_publicationDate(){} // RVA: 0x7FFACBE64CE0
        public void get_labsPublicationDate(){} // RVA: 0x7FFAC354B170
        public void set_labsPublicationDate(){} // RVA: 0x7FFAC8B66FB0
        public void get_udonProducts(){} // RVA: 0x7FFAC33BC6D0
        public void set_udonProducts(){} // RVA: 0x7FFAC33B8580
        public void get_storeId(){} // RVA: 0x7FFAC313CBB0
        public void set_storeId(){} // RVA: 0x7FFAC3143400
        public void get_platform(){} // RVA: 0x7FFAC35466F0
        public void set_platform(){} // RVA: 0x7FFAC39C51C0
        public void get_worldInstances(){} // RVA: 0x7FFAC3544340
        public void get_isAdminApproved(){} // RVA: 0x7FFACBEF1C50
        public void get_IsCommunityLabsWorld(){} // RVA: 0x7FFACBEF1CD0
        public void get_IsPublicPublishedWorld(){} // RVA: 0x7FFACBEF1D40
        public void get_IsInternalWorld(){} // RVA: 0x7FFACBEF1DC0
        public void get_unityPackageUpdated(){} // RVA: 0x7FFACBEF1E20
        public void set_unityPackageUpdated(){} // RVA: 0x7FFACBEF1E30
        public void get_organization(){} // RVA: 0x7FFAC2F8C5F0
        public void set_organization(){} // RVA: 0x7FFAC2F8C600
        public void get_shouldAddToAuthor(){} // RVA: 0x7FFAC4138670
        public void set_shouldAddToAuthor(){} // RVA: 0x7FFAC412E500
        public void get_favoriteId(){} // RVA: 0x7FFAC354DFA0
        public void set_favoriteId(){} // RVA: 0x7FFAC39B99C0
        public void get_favorites(){} // RVA: 0x7FFACBEF1E40
        public void set_favorites(){} // RVA: 0x7FFAC99FDCE0
        public void get_visits(){} // RVA: 0x7FFACBEF1E50
        public void set_visits(){} // RVA: 0x7FFAC99FDD00
        public void get_popularity(){} // RVA: 0x7FFAC3642A70
        public void set_popularity(){} // RVA: 0x7FFAC3642540
        public void get_heat(){} // RVA: 0x7FFACBEC2370
        public void set_heat(){} // RVA: 0x7FFACBEC2380
        public void get_detailed(){} // RVA: 0x7FFAC400F720
        public void set_detailed(){} // RVA: 0x7FFAC409F1C0
        public void get_defaultContentSettings(){} // RVA: 0x7FFAC336D850
        public void set_defaultContentSettings(){} // RVA: 0x7FFAC39B5DB0
        public void get_assetVersion(){} // RVA: 0x7FFACBEF1E60
        public void set_assetVersion(){} // RVA: 0x7FFACBEF1F10
        public void get_BundleSignature(){} // RVA: 0x7FFAC336D860
        public void set_BundleSignature(){} // RVA: 0x7FFAC39CA130
        public void get_isCurated(){} // RVA: 0x7FFACBEF1FA0
        public void set_isCurated(){} // RVA: 0x7FFACBEF1FB0
        public void get_publicTags(){} // RVA: 0x7FFACBEF1FC0
        public void .ctor(){} // RVA: 0x7FFACBEF21C0
        public void ReadField(){} // RVA: 0x7FFACBEF23D0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFACBEF25B0 | overloaded x2
        public void ReadUnityPackages(){} // RVA: 0x7FFACBEF2690
        public void ReadUnityPackage(){} // RVA: 0x7FFACBEF2DE0
        public void WriteField(){} // RVA: 0x7FFACBEF3440
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFACBEF3ED0
        public void Save(){} // RVA: 0x7FFACBEF4330
        public void Fetch(){} // RVA: 0x7FFACBEF44E0
        public void FetchList(){} // RVA: 0x7FFACBEF5010
        public void FetchSearchResults(){} // RVA: 0x7FFACBEF54C0
        public void AddLocal(){} // RVA: 0x7FFACBEF59C0
        public void get_IsLocal(){} // RVA: 0x7FFACBEF5A90
        public void SetLocal(){} // RVA: 0x7FFACBEF5B70
        public void ShouldNotBeVisibleOptional(){} // RVA: 0x7FFACBEF5D40
        public void GetBestInstance(){} // RVA: 0x7FFACBEF60F0 | overloaded x2
        public void CreateNewInstanceAsync(){} // RVA: 0x7FFACBEF6350
        public void CreateNewInstance(){} // RVA: 0x7FFACBEF66C0
        public void FetchUploadedWorlds(){} // RVA: 0x7FFACBEF6B50
        public void PublishWorldToCommunityLabs(){} // RVA: 0x7FFACBEF7040
        public void UpdateVersionAndPlatform(){} // RVA: 0x7FFACBEF7380
        public void MakeRequestEndpoint(){} // RVA: 0x7FFACBEF74F0
        public void Merge(){} // RVA: 0x7FFACBEF7510
        public void .cctor(){} // RVA: 0x7FFACBEF7DE0
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
        public VRC.Core.ApiWorld ownerId; // 0xA8
        public 0x6B0B4FF8 tags; // 0xB0
        public string count; // 0xB8
        public System.Collections.Generic.List`1<string> capacity; // 0xC0
        public int recommendedCapacity; // 0xC8
        public int platforms; // 0xCC
        public int nonce; // 0xD0
        public System.Collections.Generic.Dictionary`2<string,int> clientVersion; // 0xD8
        public string gameServerVersion; // 0xE0
        public string region; // 0xE8
        public int active; // 0xF0
        public 0x6B0B5260 queueEnabled; // 0xF4
        public bool hasCapacityForYou; // 0xF8
        public bool queueSize; // 0xF9
        public bool closedAt; // 0xFA
        public int hardClose; // 0xFC
        public System.DateTime ageGate; // 0x100
        public bool contentSettings; // 0x108
        public bool IsClosed; // 0x109
        public System.Collections.Generic.Dictionary`2<string,bool> IsAgeGated; // 0x110
        public bool playerPersistenceEnabled; // 0x118
        public string calendarEntryId; // 0x120
        public System.Collections.Generic.List`1<VRC.Core.APIUser> users; // 0x128
        public System.Collections.Generic.List`1<string> ShouldSeeInstanceByType; // 0x130
        public bool roleIds; // 0x138
        public string roleRestricted; // 0x140
        public object groupAccessType;
        public bool id; // 0x8
        public System.Nullable`1<long> ProbablyExistsOnAPI; // 0x10
        public long MinPostIntervalSeconds;
        public long MaxPostDelaySeconds;

        // ── Methods ──
        public void get_location(){} // RVA: 0x7FFAC2F9CD50
        public void set_location(){} // RVA: 0x7FFAC2F9CD60
        public void get_name(){} // RVA: 0x7FFAC2FE9590
        public void set_name(){} // RVA: 0x7FFACBEFD240
        public void get_shortName(){} // RVA: 0x7FFAC30E5600
        public void set_shortName(){} // RVA: 0x7FFAC30E06F0
        public void get_secureName(){} // RVA: 0x7FFAC32EF410
        public void set_secureName(){} // RVA: 0x7FFAC34D4AA0
        public void get_displayName(){} // RVA: 0x7FFAC2F60010
        public void set_displayName(){} // RVA: 0x7FFAC354E300
        public void get_worldId(){} // RVA: 0x7FFAC32EF640
        public void set_worldId(){} // RVA: 0x7FFAC354E360
        public void get_instanceId(){} // RVA: 0x7FFAC354DFB0
        public void set_instanceId(){} // RVA: 0x7FFAC354E3C0
        public void get_instanceCode(){} // RVA: 0x7FFAC3543900
        public void set_instanceCode(){} // RVA: 0x7FFAC354E420
        public void get_world(){} // RVA: 0x7FFAC354B1A0
        public void set_world(){} // RVA: 0x7FFAC334B370
        public void get_type(){} // RVA: 0x7FFAC4BF81F0
        public void set_type(){} // RVA: 0x7FFAC87B5A90
        public void get_ownerId(){} // RVA: 0x7FFAC2F8C0B0
        public void set_ownerId(){} // RVA: 0x7FFAC2F8C0C0
        public void get_tags(){} // RVA: 0x7FFAC2F8C120
        public void set_tags(){} // RVA: 0x7FFAC2F8C130
        public void get_count(){} // RVA: 0x7FFAC3641480
        public void set_count(){} // RVA: 0x7FFAC623E970
        public void get_capacity(){} // RVA: 0x7FFAC43065A0
        public void set_capacity(){} // RVA: 0x7FFAC88C71C0
        public void get_recommendedCapacity(){} // RVA: 0x7FFAC3696B20
        public void set_recommendedCapacity(){} // RVA: 0x7FFAC4591C30
        public void get_platforms(){} // RVA: 0x7FFAC3540F70
        public void set_platforms(){} // RVA: 0x7FFAC2FA28A0
        public void get_nonce(){} // RVA: 0x7FFAC2FA2900
        public void set_nonce(){} // RVA: 0x7FFAC2FA2910
        public void get_clientVersion(){} // RVA: 0x7FFAC2FA2970
        public void set_clientVersion(){} // RVA: 0x7FFAC2FA2980
        public void get_gameServerVersion(){} // RVA: 0x7FFAC60855D0
        public void set_gameServerVersion(){} // RVA: 0x7FFAC8A11630
        public void get_region(){} // RVA: 0x7FFAC6715830
        public void set_region(){} // RVA: 0x7FFAC6715840
        public void get_active(){} // RVA: 0x7FFAC3C8E090
        public void set_active(){} // RVA: 0x7FFAC97AF8F0
        public void get_queueEnabled(){} // RVA: 0x7FFAC2F7DF90
        public void set_queueEnabled(){} // RVA: 0x7FFAC2F7DFA0
        public void get_hasCapacityForYou(){} // RVA: 0x7FFACB978DB0
        public void set_hasCapacityForYou(){} // RVA: 0x7FFACB9790C0
        public void get_queueSize(){} // RVA: 0x7FFAC3C8BB20
        public void set_queueSize(){} // RVA: 0x7FFAC97AF870
        public void get_closedAt(){} // RVA: 0x7FFAC34F6C80
        public void set_closedAt(){} // RVA: 0x7FFAC4196020
        public void get_hardClose(){} // RVA: 0x7FFAC4196030
        public void set_hardClose(){} // RVA: 0x7FFAC4196040
        public void get_ageGate(){} // RVA: 0x7FFAC45CA6A0
        public void set_ageGate(){} // RVA: 0x7FFAC45C9FB0
        public void get_contentSettings(){} // RVA: 0x7FFAC354B170
        public void set_contentSettings(){} // RVA: 0x7FFAC39B3E10
        public void get_IsClosed(){} // RVA: 0x7FFACBEFD330
        public void get_IsAgeGated(){} // RVA: 0x7FFACBEFD450
        public void get_playerPersistenceEnabled(){} // RVA: 0x7FFACBEC2310
        public void set_playerPersistenceEnabled(){} // RVA: 0x7FFACBEC2320
        public void get_calendarEntryId(){} // RVA: 0x7FFAC313CBB0
        public void set_calendarEntryId(){} // RVA: 0x7FFAC3143400
        public void get_users(){} // RVA: 0x7FFAC35466F0
        public void set_users(){} // RVA: 0x7FFAC39C51C0
        public void get_ShouldSeeInstanceByType(){} // RVA: 0x7FFACBEFD5A0
        public void get_roleIds(){} // RVA: 0x7FFAC3544340
        public void set_roleIds(){} // RVA: 0x7FFAC39A79B0
        public void get_roleRestricted(){} // RVA: 0x7FFACBEF1E20
        public void set_roleRestricted(){} // RVA: 0x7FFACBEF1E30
        public void get_groupAccessType(){} // RVA: 0x7FFAC2F8C5F0
        public void set_groupAccessType(){} // RVA: 0x7FFAC2F8C600
        public void get_id(){} // RVA: 0x7FFAC2F9CD50
        public void set_id(){} // RVA: 0x7FFACBEFD6C0
        public void .ctor(){} // RVA: 0x7FFACBEFDA50 | overloaded x3
        public void Init(){} // RVA: 0x7FFACBEFDA90
        public void Get(){} // RVA: 0x7FFACBEFE200
        public void MakeRequestEndpoint(){} // RVA: 0x7FFACBEFE490
        public void SetInstanceAccessTypeFromId(){} // RVA: 0x7FFACBEFE500
        public void ExtractInfoFromLocation(){} // RVA: 0x7FFACBEFE740
        public void BuildRequest(){} // RVA: 0x7FFACBEFEE30
        public void GetLifeSpan(){} // RVA: 0x7FFACBEFF510
        public void ReadField(){} // RVA: 0x7FFACBEFF520
        public void WriteField(){} // RVA: 0x7FFACBEFF8B0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFACBEFFA70 | overloaded x2
        public void ParseTags(){} // RVA: 0x7FFACBEFFB10
        public void ToString(){} // RVA: 0x7FFACBEFFDB0
        public void GetShortName(){} // RVA: 0x7FFACBEFFE70
        public void get_ProbablyExistsOnAPI(){} // RVA: 0x7FFACBF00210
        public void CreateOrFetch(){} // RVA: 0x7FFACBF00410 | overloaded x2
        public void CreateOrFetchAsync(){} // RVA: 0x7FFACBF00880 | overloaded x2
        public void CreateOrFetchAsyncInternal(){} // RVA: 0x7FFACBF00A50
        public void .cctor(){} // RVA: 0x7FFACBF00C70
        public void <get_ProbablyExistsOnAPI>b__165_0(){} // RVA: 0x7FFACBF00D40
    }

    public class AreaBase : Object
    {
        public object Endpoint;

        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AssetVersion : Object
    {
        public string UnityVersion; // 0x10
        public VRC.Core.UnityVersion UnityVersionObj; // 0x18
        public int ApiVersion; // 0x2C

        // ── Methods ──
        public void get_UnityVersion(){} // RVA: 0x7FFACBF11E10
        public void set_UnityVersion(){} // RVA: 0x7FFAC2F22E30
        public void get_UnityVersionObj(){} // RVA: 0x7FFACBF11F00
        public void get_ApiVersion(){} // RVA: 0x7FFAC3C891D0
        public void set_ApiVersion(){} // RVA: 0x7FFAC45B6490
        public void .ctor(){} // RVA: 0x7FFACBF12110 | overloaded x3
        public void ToString(){} // RVA: 0x7FFACBF12170
    }

}