// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 39
// Methods: 765

namespace VRC.Core
{
    public class ApiProp : ApiContentModel`1
    {
        public System.DateTime __created_at; // 0xD8
        public System.DateTime __updated_at; // 0xE0
        public System.Collections.Generic.List`1<UnityPackage> _unityPackages; // 0xE8
        public int _spawnType; // 0xF0
        public int _worldPlacementMask; // 0xF4
        public int _kind; // 0xF8
        public bool _scaleWithAvatar; // 0xFC
        public string PropsEndpoint;

        // ── Methods ──
        public void get__created_at(){} // RVA: 0x7FFE8181EA80
        public void set__created_at(){} // RVA: 0x7FFE89E6C790
        public void get__updated_at(){} // RVA: 0x7FFE8117C900
        public void set__updated_at(){} // RVA: 0x7FFE8A2C5BE0
        public void get_unityPackages(){} // RVA: 0x7FFE8117C970
        public void set_unityPackages(){} // RVA: 0x7FFE8117C980
        public void get_spawnType(){} // RVA: 0x7FFE843B5350
        public void set_spawnType(){} // RVA: 0x7FFE86DBACB0
        public void get_worldPlacementMask(){} // RVA: 0x7FFE84A61F50
        public void set_worldPlacementMask(){} // RVA: 0x7FFE84A61F60
        public void get_kind(){} // RVA: 0x7FFE82144660
        public void set_kind(){} // RVA: 0x7FFE8213C830
        public void get_scaleWithAvatar(){} // RVA: 0x7FFE8A3257E0
        public void set_scaleWithAvatar(){} // RVA: 0x7FFE8A3257F0
        public void get_BundleSignature(){} // RVA: 0x7FFE81828B50
        public void set_BundleSignature(){} // RVA: 0x7FFE81A58AB0
        public void .ctor(){} // RVA: 0x7FFE8A325800
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFE8A325960 | overloaded x2
        public void ProcessUnityPackages(){} // RVA: 0x7FFE8A325A40
        public void WriteField(){} // RVA: 0x7FFE8A326100
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFE8A3261C0
        public void GetProp(){} // RVA: 0x7FFE8A3263C0
    }

    public class ApiPropItemMetadata : ApiModel
    {
        public string _propId; // 0x68
        public int _worldPlacementMask; // 0x70
        public int _kind; // 0x74

        // ── Methods ──
        public void get_propId(){} // RVA: 0x7FFE81176D50
        public void set_propId(){} // RVA: 0x7FFE81176D60
        public void get_worldPlacementMask(){} // RVA: 0x7FFE81E60180
        public void set_worldPlacementMask(){} // RVA: 0x7FFE81293CF0
        public void get_kind(){} // RVA: 0x7FFE826A9B90
        public void set_kind(){} // RVA: 0x7FFE82B1F9C0
        public void .ctor(){} // RVA: 0x7FFE8A326860
    }

    public class ApiPurchase : ApiModel
    {
        public string _listingId; // 0x68
        public string _listingDisplayName; // 0x70
        public string _listingImageId; // 0x78
        public 0x664AE07C _listingType; // 0x80
        public string _listingVariantId; // 0x88
        public string _sellerId; // 0x90
        public string _sellerDisplayName; // 0x98
        public string _buyerId; // 0xA0
        public string _buyerDisplayName; // 0xA8
        public string _receiverId; // 0xB0
        public string _receiverDisplayName; // 0xB8
        public int _price; // 0xC0
        public int _quantity; // 0xC4
        public int _duration; // 0xC8
        public 0x664AE0D4 _durationType; // 0xCC
        public System.DateTime _purchaseDate; // 0xD0
        public System.DateTime _purchaseStartDate; // 0xD8
        public System.DateTime _purchaseEndDate; // 0xE0
        public bool _purchaseActive; // 0xE8
        public bool _purchaseLatest; // 0xE9
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> _products; // 0xF0
        public bool _isStackable; // 0xF8
        public bool _isRecurrable; // 0xF9
        public System.Collections.Generic.Dictionary`2<string,object> _purchaseToken; // 0x100
        public bool _isVoided; // 0x108
        public bool _isGift; // 0x109
        public int _purchaseUnitPrice; // 0x10C
        public bool _isRefundable; // 0x110
        public string _stackDurationType; // 0x118
        public int _stackDuration; // 0x120
        public int _stackPrice; // 0x124
        public int _stackQuantity; // 0x128
        public int _stackQuantityConsumed; // 0x12C
        public int _stackQuantityConsumedAtPurchase; // 0x130
        public int _stackQuantityUnconsumed; // 0x134
        public int _stackQuantityUnconsumedAtPurchase; // 0x138
        public string _tiliaTransactionId; // 0x140
        public bool _willRecur; // 0x148
        public bool _listingCurrentlyAvailable; // 0x149
        public System.DateTime _createdAtDate; // 0x150
        public string _purchaseID; // 0x158
        public System.DateTime _updatedAtDate; // 0x160
        public System.DateTime _purchaseOriginalEndDate; // 0x168
        public string _buyerIP; // 0x170
        public bool _isRecur; // 0x178
        public bool _isUnityLocalTest; // 0x179
        public string _licenseID; // 0x180
        public System.Collections.Generic.List`1<string> _purchaseStacks; // 0x188
        public int _purchaseTiliaFee; // 0x190
        public string _purchaseType; // 0x198
        public int _purchaseValue; // 0x1A0
        public int _purchaseVrcFee; // 0x1A4
        public string _refundStatus; // 0x1A8
        public string _sellerIP; // 0x1B0
        public int _stackTiliaFee; // 0x1B8
        public int _stackValue; // 0x1BC
        public int _stackVrcFee; // 0x1C0
        public bool _stackQuantityVoided; // 0x1C4
        public string _voidedBy; // 0x1C8
        public bool _voidedByAdmin; // 0x1D0
        public System.DateTime _voidedOnDate; // 0x1D8
        public int _purchaseTiliaFeeBasedOnStack; // 0x1E0
        public int _purchaseTiliaFeeDrift; // 0x1E4
        public int _purchaseVrcFeeBasedOnStack; // 0x1E8
        public bool _refunded; // 0x1EC
        public string _refundedBy; // 0x1F0
        public bool _refundedByAdmin; // 0x1F8
        public System.DateTime _refundedOnDate; // 0x200
        public System.Collections.Generic.List`1<string> _refundedStacks; // 0x208
        public string _refundReason; // 0x210
        public string _refundReasonType; // 0x218
        public string _refundTiliaTransactionId; // 0x220
        public object _refundTokenComponents; // 0x228
        public int _refundTokens; // 0x230
        public object _refundTokenSources; // 0x238
        public string _refundType; // 0x240
        public System.Collections.Generic.List`1<string> _voidedStacks; // 0x248
        public bool _voidedCompletely; // 0x250
        public object field_78; // 0x8548
        public object field_79; // 0x8700

        // ── Methods ──
        public void get_ListingId(){} // RVA: 0x7FFE81176D50
        public void set_ListingId(){} // RVA: 0x7FFE81176D60
        public void get_ListingDisplayName(){} // RVA: 0x7FFE811C3590
        public void set_ListingDisplayName(){} // RVA: 0x7FFE811C35A0
        public void get_ListingImageId(){} // RVA: 0x7FFE81463AE0
        public void set_ListingImageId(){} // RVA: 0x7FFE81464570
        public void get_ListingImageUrl(){} // RVA: 0x7FFE8A326950
        public void get_ListingType(){} // RVA: 0x7FFE81D30560
        public void set_ListingType(){} // RVA: 0x7FFE81D307B0
        public void get_ListingVariantId(){} // RVA: 0x7FFE8113A010
        public void set_ListingVariantId(){} // RVA: 0x7FFE81280F90
        public void get_SellerId(){} // RVA: 0x7FFE8154EB60
        public void set_SellerId(){} // RVA: 0x7FFE818CE320
        public void get_SellerDisplayName(){} // RVA: 0x7FFE817AE360
        public void set_SellerDisplayName(){} // RVA: 0x7FFE8171B470
        public void get_BuyerId(){} // RVA: 0x7FFE8179C860
        public void set_BuyerId(){} // RVA: 0x7FFE8171B4D0
        public void get_BuyerDisplayName(){} // RVA: 0x7FFE817AB5E0
        public void set_BuyerDisplayName(){} // RVA: 0x7FFE81857260
        public void get_ReceiverId(){} // RVA: 0x7FFE81166040
        public void set_ReceiverId(){} // RVA: 0x7FFE81166050
        public void get_ReceiverDisplayName(){} // RVA: 0x7FFE811660B0
        public void set_ReceiverDisplayName(){} // RVA: 0x7FFE811660C0
        public void get_id(){} // RVA: 0x7FFE81116380
        public void set_id(){} // RVA: 0x7FFE810FCE30
        public void get_Price(){} // RVA: 0x7FFE813AB640
        public void set_Price(){} // RVA: 0x7FFE813A4A00
        public void get_Quantity(){} // RVA: 0x7FFE82A3B5F0
        public void set_Quantity(){} // RVA: 0x7FFE86CE9440
        public void get_Duration(){} // RVA: 0x7FFE81790750
        public void set_Duration(){} // RVA: 0x7FFE8453D840
        public void get_DurationType(){} // RVA: 0x7FFE825F9DC0
        public void set_DurationType(){} // RVA: 0x7FFE86C708B0
        public void get_PurchaseDate(){} // RVA: 0x7FFE81218100
        public void set_PurchaseDate(){} // RVA: 0x7FFE87414000
        public void get_PurchaseStartDate(){} // RVA: 0x7FFE8181EA80
        public void set_PurchaseStartDate(){} // RVA: 0x7FFE89E6C790
        public void get_PurchaseEndDate(){} // RVA: 0x7FFE8117C900
        public void set_PurchaseEndDate(){} // RVA: 0x7FFE8A2C5BE0
        public void get_PurchaseActive(){} // RVA: 0x7FFE822A56E0
        public void set_PurchaseActive(){} // RVA: 0x7FFE82C080B0
        public void get_PurchaseLatest(){} // RVA: 0x7FFE871EB290
        public void set_PurchaseLatest(){} // RVA: 0x7FFE8A3269C0
        public void get_Products(){} // RVA: 0x7FFE811662A0
        public void set_Products(){} // RVA: 0x7FFE811662B0
        public void get_IsStackable(){} // RVA: 0x7FFE81F84060
        public void set_IsStackable(){} // RVA: 0x7FFE87B57E70
        public void get_IsRecurrable(){} // RVA: 0x7FFE81157F90
        public void set_IsRecurrable(){} // RVA: 0x7FFE81157FA0
        public void get_PurchaseToken(){} // RVA: 0x7FFE81828B50
        public void set_PurchaseToken(){} // RVA: 0x7FFE81A58AB0
        public void get_IsVoided(){} // RVA: 0x7FFE82472660
        public void set_IsVoided(){} // RVA: 0x7FFE82472670
        public void get_IsGift(){} // RVA: 0x7FFE82904DF0
        public void set_IsGift(){} // RVA: 0x7FFE82904650
        public void get_PurchaseUnitPrice(){} // RVA: 0x7FFE82862E00
        public void set_PurchaseUnitPrice(){} // RVA: 0x7FFE82868B60
        public void get_IsRefundable(){} // RVA: 0x7FFE81472650
        public void set_IsRefundable(){} // RVA: 0x7FFE81472660
        public void get_StackDurationType(){} // RVA: 0x7FFE81318010
        public void set_StackDurationType(){} // RVA: 0x7FFE81317920
        public void get_StackDuration(){} // RVA: 0x7FFE86DBACC0
        public void set_StackDuration(){} // RVA: 0x7FFE86DBACD0
        public void get_StackPrice(){} // RVA: 0x7FFE86C7E580
        public void set_StackPrice(){} // RVA: 0x7FFE86C7E590
        public void get_StackQuantity(){} // RVA: 0x7FFE86DBB070
        public void set_StackQuantity(){} // RVA: 0x7FFE86DBB080
        public void get_StackQuantityConsumed(){} // RVA: 0x7FFE8A3269D0
        public void set_StackQuantityConsumed(){} // RVA: 0x7FFE8A3269E0
        public void get_StackQuantityConsumedAtPurchase(){} // RVA: 0x7FFE8162C320
        public void set_StackQuantityConsumedAtPurchase(){} // RVA: 0x7FFE879054D0
        public void get_StackQuantityUnconsumed(){} // RVA: 0x7FFE8769D550
        public void set_StackQuantityUnconsumed(){} // RVA: 0x7FFE8A3269F0
        public void get_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x7FFE81F60BB0
        public void set_StackQuantityUnconsumedAtPurchase(){} // RVA: 0x7FFE86C70910
        public void get_TiliaTransactionId(){} // RVA: 0x7FFE811665F0
        public void set_TiliaTransactionId(){} // RVA: 0x7FFE81166600
        public void get_WillRecur(){} // RVA: 0x7FFE823E5620
        public void set_WillRecur(){} // RVA: 0x7FFE823F09C0
        public void get_ListingCurrentlyAvailable(){} // RVA: 0x7FFE89E9B290
        public void set_ListingCurrentlyAvailable(){} // RVA: 0x7FFE89C2ECB0
        public void get_CreatedAtDate(){} // RVA: 0x7FFE81790740
        public void set_CreatedAtDate(){} // RVA: 0x7FFE8A326A00
        public void get_PurchaseID(){} // RVA: 0x7FFE81B16560
        public void set_PurchaseID(){} // RVA: 0x7FFE81B21880
        public void get_UpdatedAtDate(){} // RVA: 0x7FFE81624E50
        public void set_UpdatedAtDate(){} // RVA: 0x7FFE88023340
        public void get_PurchaseOriginalEndDate(){} // RVA: 0x7FFE81B2CB70
        public void set_PurchaseOriginalEndDate(){} // RVA: 0x7FFE8A326A10
        public void get_BuyerIP(){} // RVA: 0x7FFE815BB6A0
        public void set_BuyerIP(){} // RVA: 0x7FFE81B38790
        public void get_IsRecur(){} // RVA: 0x7FFE8A326A20
        public void set_IsRecur(){} // RVA: 0x7FFE811CF6A0
        public void get_IsUnityLocalTest(){} // RVA: 0x7FFE8A326A30
        public void set_IsUnityLocalTest(){} // RVA: 0x7FFE8A326A40
        public void get_LicenseID(){} // RVA: 0x7FFE81B38340
        public void set_LicenseID(){} // RVA: 0x7FFE81B31180
        public void get_PurchaseStacks(){} // RVA: 0x7FFE81B295E0
        public void set_PurchaseStacks(){} // RVA: 0x7FFE81B2E3B0
        public void get_PurchaseTiliaFee(){} // RVA: 0x7FFE86DBDB60
        public void set_PurchaseTiliaFee(){} // RVA: 0x7FFE879EE3A0
        public void get_PurchaseType(){} // RVA: 0x7FFE8181EA60
        public void set_PurchaseType(){} // RVA: 0x7FFE81B33630
        public void get_PurchaseValue(){} // RVA: 0x7FFE8A326A50
        public void set_PurchaseValue(){} // RVA: 0x7FFE8A326A60
        public void get_PurchaseVrcFee(){} // RVA: 0x7FFE89AB5F30
        public void set_PurchaseVrcFee(){} // RVA: 0x7FFE89AB8E80
        public void get_RefundStatus(){} // RVA: 0x7FFE8182AF50
        public void set_RefundStatus(){} // RVA: 0x7FFE81B08F90
        public void get_SellerIP(){} // RVA: 0x7FFE81B23A60
        public void set_SellerIP(){} // RVA: 0x7FFE81B2ACE0
        public void get_StackTiliaFee(){} // RVA: 0x7FFE89E6CBB0
        public void set_StackTiliaFee(){} // RVA: 0x7FFE8A326A70
        public void get_StackValue(){} // RVA: 0x7FFE822FE450
        public void set_StackValue(){} // RVA: 0x7FFE8A326A80
        public void get_StackVrcFee(){} // RVA: 0x7FFE822F9BE0
        public void set_StackVrcFee(){} // RVA: 0x7FFE8A326A90
        public void get_StackQuantityVoided(){} // RVA: 0x7FFE8A326AA0
        public void set_StackQuantityVoided(){} // RVA: 0x7FFE8A326AB0
        public void get_VoidedBy(){} // RVA: 0x7FFE81B16E90
        public void set_VoidedBy(){} // RVA: 0x7FFE81B290E0
        public void get_VoidedByAdmin(){} // RVA: 0x7FFE89764140
        public void set_VoidedByAdmin(){} // RVA: 0x7FFE8A326AC0
        public void get_VoidedOnDate(){} // RVA: 0x7FFE81B23D60
        public void set_VoidedOnDate(){} // RVA: 0x7FFE8A326AD0
        public void get_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0x7FFE8A326AE0
        public void set_PurchaseTiliaFeeBasedOnStack(){} // RVA: 0x7FFE8A326AF0
        public void get_PurchaseTiliaFeeDrift(){} // RVA: 0x7FFE87453E40
        public void set_PurchaseTiliaFeeDrift(){} // RVA: 0x7FFE8A326B00
        public void get_PurchaseVrcFeeBasedOnStack(){} // RVA: 0x7FFE8A326B10
        public void set_PurchaseVrcFeeBasedOnStack(){} // RVA: 0x7FFE8A326B20
        public void get_Refunded(){} // RVA: 0x7FFE8A326B30
        public void set_Refunded(){} // RVA: 0x7FFE8A326B40
        public void get_RefundedBy(){} // RVA: 0x7FFE81B21230
        public void set_RefundedBy(){} // RVA: 0x7FFE81B374B0
        public void get_RefundedByAdmin(){} // RVA: 0x7FFE82A2CE90
        public void set_RefundedByAdmin(){} // RVA: 0x7FFE8A326B50
        public void get_RefundedOnDate(){} // RVA: 0x7FFE81B14500
        public void set_RefundedOnDate(){} // RVA: 0x7FFE8A326B60
        public void get_RefundedStacks(){} // RVA: 0x7FFE81B2DA70
        public void set_RefundedStacks(){} // RVA: 0x7FFE81B27F80
        public void get_RefundReason(){} // RVA: 0x7FFE81B0A180
        public void set_RefundReason(){} // RVA: 0x7FFE81B13850
        public void get_RefundReasonType(){} // RVA: 0x7FFE81B296E0
        public void set_RefundReasonType(){} // RVA: 0x7FFE81B38350
        public void get_RefundTiliaTransactionId(){} // RVA: 0x7FFE81B310E0
        public void set_RefundTiliaTransactionId(){} // RVA: 0x7FFE81B21BD0
        public void get_RefundTokenComponents(){} // RVA: 0x7FFE81B0D790
        public void set_RefundTokenComponents(){} // RVA: 0x7FFE81B34BA0
        public void get_RefundTokens(){} // RVA: 0x7FFE827C69B0
        public void set_RefundTokens(){} // RVA: 0x7FFE827C5530
        public void get_RefundTokenSources(){} // RVA: 0x7FFE81B20B50
        public void set_RefundTokenSources(){} // RVA: 0x7FFE81B2F9F0
        public void get_RefundType(){} // RVA: 0x7FFE81B26960
        public void set_RefundType(){} // RVA: 0x7FFE81B2E9D0
        public void get_VoidedStacks(){} // RVA: 0x7FFE81B0DEC0
        public void set_VoidedStacks(){} // RVA: 0x7FFE81B27CF0
        public void get_VoidedCompletely(){} // RVA: 0x7FFE8A326B70
        public void set_VoidedCompletely(){} // RVA: 0x7FFE8A326B80
        public void ReadField(){} // RVA: 0x7FFE8A326B90
        public void WriteField(){} // RVA: 0x7FFE8A326DD0
        public void GetCancelInformation(){} // RVA: 0x7FFE8A326F50
        public void Cancel(){} // RVA: 0x7FFE8A327830
        public void FetchList(){} // RVA: 0x7FFE8A3281A0
        public void FetchMostRecentActivePurchase(){} // RVA: 0x7FFE8A329150
        public void .ctor(){} // RVA: 0x7FFE8A329AB0
    }

    public class ApiPurchaseCancelSubscriptionInfo : ApiModel
    {
        public int _refundableAmount; // 0x68
        public int _nonRefundableAmount; // 0x6C
        public int _totalStacksToCancel; // 0x70
        public System.DateTime _newExpirationDate; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A3268B0
        public void get_RefundableAmount(){} // RVA: 0x7FFE82A22EF0
        public void set_RefundableAmount(){} // RVA: 0x7FFE82A22F00
        public void get_NonRefundableAmount(){} // RVA: 0x7FFE82A22F10
        public void set_NonRefundableAmount(){} // RVA: 0x7FFE82A22F20
        public void get_TotalStacksToCancel(){} // RVA: 0x7FFE81E60180
        public void set_TotalStacksToCancel(){} // RVA: 0x7FFE81293CF0
        public void get_NewExpirationDate(){} // RVA: 0x7FFE81463AE0
        public void set_NewExpirationDate(){} // RVA: 0x7FFE865EFE40
    }

    public class ApiPurchaseSubscriptionCancelledInfo : ApiModel
    {
        public int _amountRefunded; // 0x68
        public int _totalStacksCancelled; // 0x6C
        public System.DateTime _newExpirationDate; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A326900
        public void get_AmountRefunded(){} // RVA: 0x7FFE82A22EF0
        public void set_AmountRefunded(){} // RVA: 0x7FFE82A22F00
        public void get_TotalStacksCancelled(){} // RVA: 0x7FFE82A22F10
        public void set_TotalStacksCancelled(){} // RVA: 0x7FFE82A22F20
        public void get_NewExpirationDate(){} // RVA: 0x7FFE811C3590
        public void set_NewExpirationDate(){} // RVA: 0x7FFE82C95C70
    }

    public class ApiReport : ApiModel
    {
        public string _type; // 0x68
        public string _category; // 0x70
        public string _reason; // 0x78
        public string _contentId; // 0x80
        public string _description; // 0x88
        public VRC.Core.ApiReportDetails _details; // 0x90
        public string _contentName; // 0x98
        public string _contentThumbnailImageUrl; // 0xA0

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFE81176D50
        public void set_type(){} // RVA: 0x7FFE81176D60
        public void get_category(){} // RVA: 0x7FFE811C3590
        public void set_category(){} // RVA: 0x7FFE811C35A0
        public void get_reason(){} // RVA: 0x7FFE81463AE0
        public void set_reason(){} // RVA: 0x7FFE81464570
        public void get_contentId(){} // RVA: 0x7FFE81280C30
        public void set_contentId(){} // RVA: 0x7FFE81282380
        public void get_description(){} // RVA: 0x7FFE8113A010
        public void set_description(){} // RVA: 0x7FFE81280F90
        public void get_details(){} // RVA: 0x7FFE8154EB60
        public void set_details(){} // RVA: 0x7FFE818CE320
        public void get_contentName(){} // RVA: 0x7FFE817AE360
        public void set_contentName(){} // RVA: 0x7FFE8171B470
        public void get_contentThumbnailImageUrl(){} // RVA: 0x7FFE8179C860
        public void set_contentThumbnailImageUrl(){} // RVA: 0x7FFE8171B4D0
        public void AddReport(){} // RVA: 0x7FFE8A32A880
        public void FetchReports(){} // RVA: 0x7FFE8A32ABA0
        public void DeleteReport(){} // RVA: 0x7FFE8A32B240
        public void .ctor(){} // RVA: 0x7FFE8A32B550
    }

    public class ApiReportDetails : ApiModel
    {
        public System.Collections.Generic.List`1<string> _suggestedWarnings; // 0x68
        public string _instanceType; // 0x70
        public System.Nullable`1<bool> _instanceAgeGated; // 0x78
        public System.Nullable`1<bool> _userInSameInstance; // 0x7A
        public string _imageType; // 0x80
        public string _fileId; // 0x88
        public string _holderId; // 0x90

        // ── Methods ──
        public void get_suggestedWarnings(){} // RVA: 0x7FFE81176D50
        public void set_suggestedWarnings(){} // RVA: 0x7FFE81176D60
        public void get_instanceType(){} // RVA: 0x7FFE811C3590
        public void set_instanceType(){} // RVA: 0x7FFE811C35A0
        public void get_instanceAgeGated(){} // RVA: 0x7FFE86AD9D70
        public void set_instanceAgeGated(){} // RVA: 0x7FFE8A32B700
        public void get_userInSameInstance(){} // RVA: 0x7FFE8A32B710
        public void set_userInSameInstance(){} // RVA: 0x7FFE8A32B720
        public void get_imageType(){} // RVA: 0x7FFE81280C30
        public void set_imageType(){} // RVA: 0x7FFE81282380
        public void get_fileId(){} // RVA: 0x7FFE8113A010
        public void set_fileId(){} // RVA: 0x7FFE81280F90
        public void get_holderId(){} // RVA: 0x7FFE8154EB60
        public void set_holderId(){} // RVA: 0x7FFE818CE320
        public void .ctor(){} // RVA: 0x7FFE8A32B730
    }

    public class ApiReportResponse : ApiModel
    {
        public bool _evidenceRequired; // 0x68
        public bool _supportRequired; // 0x69

        // ── Methods ──
        public void get_evidenceRequired(){} // RVA: 0x7FFE811C3570
        public void set_evidenceRequired(){} // RVA: 0x7FFE811C3580
        public void get_supportRequired(){} // RVA: 0x7FFE85B63B60
        public void set_supportRequired(){} // RVA: 0x7FFE85B63740
        public void .ctor(){} // RVA: 0x7FFE8A32B7D0
    }

    public class ApiReportsContainer : ApiModel
    {
        public bool _hasNext; // 0x68
        public System.Collections.Generic.List`1<VRC.Core.ApiReport> _results; // 0x70
        public int _totalCount; // 0x78

        // ── Methods ──
        public void get_hasNext(){} // RVA: 0x7FFE811C3570
        public void set_hasNext(){} // RVA: 0x7FFE811C3580
        public void get_results(){} // RVA: 0x7FFE811C3590
        public void set_results(){} // RVA: 0x7FFE811C35A0
        public void get_totalCount(){} // RVA: 0x7FFE8286C0A0
        public void set_totalCount(){} // RVA: 0x7FFE82862F10
        public void .ctor(){} // RVA: 0x7FFE8A32B780
    }

    public class ApiSearchGroupResults : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.APIGroup> _results; // 0x68
        public int _totalCount; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFE81176D50
        public void set_results(){} // RVA: 0x7FFE81176D60
        public void get_totalCount(){} // RVA: 0x7FFE81E60180
        public void set_totalCount(){} // RVA: 0x7FFE81293CF0
        public void .ctor(){} // RVA: 0x7FFE8A3319C0
    }

    public class ApiSearchUserResults : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.APIUser> _results; // 0x68
        public int _totalCount; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFE81176D50
        public void set_results(){} // RVA: 0x7FFE81176D60
        public void get_totalCount(){} // RVA: 0x7FFE81E60180
        public void set_totalCount(){} // RVA: 0x7FFE81293CF0
        public void .ctor(){} // RVA: 0x7FFE8A331970
    }

    public class ApiSearchWorldResults : ApiModel
    {
        public System.Collections.Generic.List`1<VRC.Core.ApiWorld> _results; // 0x68
        public int _totalCount; // 0x70

        // ── Methods ──
        public void get_results(){} // RVA: 0x7FFE81176D50
        public void set_results(){} // RVA: 0x7FFE81176D60
        public void get_totalCount(){} // RVA: 0x7FFE81E60180
        public void set_totalCount(){} // RVA: 0x7FFE81293CF0
        public void .ctor(){} // RVA: 0x7FFE8A331920
    }

    public class ApiSharedConnectionCounts : ApiModel
    {
        public float DefaultCacheLifetime;
        public int _friends; // 0x68
        public int _groups; // 0x6C

        // ── Methods ──
        public void get_CacheLifetime(){} // RVA: 0x7FFE8A387260
        public void get_friends(){} // RVA: 0x7FFE82A22EF0
        public void set_friends(){} // RVA: 0x7FFE82A22F00
        public void get_groups(){} // RVA: 0x7FFE82A22F10
        public void set_groups(){} // RVA: 0x7FFE82A22F20
        public void FetchSharedConnectionCountsAsync(){} // RVA: 0x7FFE8A3873F0
        public void GetLifeSpan(){} // RVA: 0x7FFE8A387260
        public void .ctor(){} // RVA: 0x7FFE8A3875A0
    }

    public class ApiSteamVRChatFinalizeTransactionResponse : ApiVRChatSubscriptionBaseResponse
    {
        public string _status; // 0x70

        // ── Methods ──
        public void get_status(){} // RVA: 0x7FFE811C3590
        public void set_status(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A350430
    }

    public class ApiSteamVRChatSubscriptionSteamTransaction : ApiModel
    {
        public VRC.Core.ApiSteamVRChatSubscriptionWalletInformation _walletInfo; // 0x68
        public string _steamId; // 0x70
        public string _orderId; // 0x78
        public string _steamUrl; // 0x80
        public string _transId; // 0x88

        // ── Methods ──
        public void get_walletInfo(){} // RVA: 0x7FFE81176D50
        public void set_walletInfo(){} // RVA: 0x7FFE81176D60
        public void get_steamId(){} // RVA: 0x7FFE811C3590
        public void set_steamId(){} // RVA: 0x7FFE811C35A0
        public void get_orderId(){} // RVA: 0x7FFE81463AE0
        public void set_orderId(){} // RVA: 0x7FFE81464570
        public void get_steamUrl(){} // RVA: 0x7FFE81280C30
        public void set_steamUrl(){} // RVA: 0x7FFE81282380
        public void get_transId(){} // RVA: 0x7FFE8113A010
        public void set_transId(){} // RVA: 0x7FFE81280F90
        public void .ctor(){} // RVA: 0x7FFE8A350AC0
    }

    public class ApiSteamVRChatSubscriptionTransaction : ApiVRChatSubscriptionBaseResponse
    {
        public string _status; // 0x70
        public VRC.Core.ApiVRChatSubscription _subscription; // 0x78
        public bool _sandbox; // 0x80
        public string _created_at; // 0x88
        public string _updated_at; // 0x90
        public VRC.Core.ApiSteamVRChatSubscriptionSteamTransaction _steam; // 0x98

        // ── Methods ──
        public void get_status(){} // RVA: 0x7FFE811C3590
        public void set_status(){} // RVA: 0x7FFE811C35A0
        public void get_subscription(){} // RVA: 0x7FFE81463AE0
        public void set_subscription(){} // RVA: 0x7FFE81464570
        public void get_sandbox(){} // RVA: 0x7FFE813A1130
        public void set_sandbox(){} // RVA: 0x7FFE813A2040
        public void get_created_at(){} // RVA: 0x7FFE8113A010
        public void set_created_at(){} // RVA: 0x7FFE81280F90
        public void get_updated_at(){} // RVA: 0x7FFE8154EB60
        public void set_updated_at(){} // RVA: 0x7FFE818CE320
        public void get_steam(){} // RVA: 0x7FFE817AE360
        public void set_steam(){} // RVA: 0x7FFE8171B470
        public void .ctor(){} // RVA: 0x7FFE8A350430
    }

    public class ApiSteamVRChatSubscriptionWalletInformation : ApiModel
    {
        public string _state; // 0x68
        public string _country; // 0x70
        public string _currency; // 0x78
        public string _status; // 0x80

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFE81176D50
        public void set_state(){} // RVA: 0x7FFE81176D60
        public void get_country(){} // RVA: 0x7FFE811C3590
        public void set_country(){} // RVA: 0x7FFE811C35A0
        public void get_currency(){} // RVA: 0x7FFE81463AE0
        public void set_currency(){} // RVA: 0x7FFE81464570
        public void get_status(){} // RVA: 0x7FFE81280C30
        public void set_status(){} // RVA: 0x7FFE81282380
        public void .ctor(){} // RVA: 0x7FFE8A350A70
    }

    public class ApiStoreShelf : ApiModel
    {
        public string _shelfTitle; // 0x68
        public string _shelfDescription; // 0x70
        public string _shelfLayout; // 0x78
        public System.DateTime _updatedAt; // 0x80
        public System.DateTime _createdAt; // 0x88
        public System.Collections.Generic.List`1<string> _listingIds; // 0x90
        public string _shelfVisibility; // 0x98
        public string _storeId; // 0xA0
        public string _sellerId; // 0xA8
        public string _highlightListingId; // 0xB0
        public string _shelfTabBackgroundImageId; // 0xB8
        public string _shelfBackgroundImageId; // 0xC0
        public string _shelfIconImageId; // 0xC8
        public System.Collections.Generic.List`1<VRC.Core.ApiProduct> _listings; // 0xD0
        public VRC.Core.ApiProduct _highlightListing; // 0xD8
        public object field_15; // 0x4090
        public object field_16; // 0x4248
        public object field_17; // 0x4400

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A381A70
        public void get_ShelfTitle(){} // RVA: 0x7FFE81176D50
        public void set_ShelfTitle(){} // RVA: 0x7FFE81176D60
        public void get_ShelfDescription(){} // RVA: 0x7FFE811C3590
        public void set_ShelfDescription(){} // RVA: 0x7FFE811C35A0
        public void get_ShelfLayout(){} // RVA: 0x7FFE81463AE0
        public void set_ShelfLayout(){} // RVA: 0x7FFE81464570
        public void get_UpdatedAt(){} // RVA: 0x7FFE81280C30
        public void set_UpdatedAt(){} // RVA: 0x7FFE82C95C90
        public void get_CreatedAt(){} // RVA: 0x7FFE8113A010
        public void set_CreatedAt(){} // RVA: 0x7FFE82C95CA0
        public void get_ListingIds(){} // RVA: 0x7FFE8154EB60
        public void set_ListingIds(){} // RVA: 0x7FFE818CE320
        public void get_ShelfVisibility(){} // RVA: 0x7FFE817AE360
        public void set_ShelfVisibility(){} // RVA: 0x7FFE8171B470
        public void get_StoreId(){} // RVA: 0x7FFE8179C860
        public void set_StoreId(){} // RVA: 0x7FFE8171B4D0
        public void get_SellerId(){} // RVA: 0x7FFE817AB5E0
        public void set_SellerId(){} // RVA: 0x7FFE81857260
        public void get_HighlightListingId(){} // RVA: 0x7FFE81166040
        public void set_HighlightListingId(){} // RVA: 0x7FFE81166050
        public void get_ShelfTabBackgroundImageId(){} // RVA: 0x7FFE811660B0
        public void set_ShelfTabBackgroundImageId(){} // RVA: 0x7FFE811660C0
        public void get_ShelfTabBackgroundImageUrl(){} // RVA: 0x7FFE8A381AC0
        public void get_ShelfBackgroundImageId(){} // RVA: 0x7FFE81166120
        public void set_ShelfBackgroundImageId(){} // RVA: 0x7FFE81166130
        public void get_ShelfBackgroundImageUrl(){} // RVA: 0x7FFE8A381B30
        public void get_ShelfIconImageId(){} // RVA: 0x7FFE81253460
        public void set_ShelfIconImageId(){} // RVA: 0x7FFE81253470
        public void get_ShelfIconImageUrl(){} // RVA: 0x7FFE8A381BA0
        public void get_Listings(){} // RVA: 0x7FFE81218100
        public void set_Listings(){} // RVA: 0x7FFE81218110
        public void get_HighlightListing(){} // RVA: 0x7FFE8181EA80
        public void set_HighlightListing(){} // RVA: 0x7FFE8117C8A0
    }

    public class ApiStringArrayContainer : ApiContainer
    {
        // ── Methods ──
        public void get_responseArray(){} // RVA: 0x7FFE8A32C530
        public void Validate(){} // RVA: 0x7FFE8A32C570
        public void .ctor(){} // RVA: 0x7FFE8A32C380
    }

    public class ApiStringContainer : ApiContainer
    {
        // ── Methods ──
        public void get_ResponseString(){} // RVA: 0x7FFE8A32C390
        public void Validate(){} // RVA: 0x7FFE8A32C3E0
        public void .ctor(){} // RVA: 0x7FFE8A32C380
    }

    public class ApiTokenBundle : ApiModel
    {
        public int _steamItemId; // 0x68
        public string _oculusSku; // 0x70
        public string _googleProductId; // 0x78
        public string _picoSku; // 0x80
        public int _amount; // 0x88
        public string _description; // 0x90
        public int _tokens; // 0x98
        public string _imageUrl; // 0xA0

        // ── Methods ──
        public void get_steamItemId(){} // RVA: 0x7FFE82A22EF0
        public void set_steamItemId(){} // RVA: 0x7FFE82A22F00
        public void get_oculusSku(){} // RVA: 0x7FFE811C3590
        public void set_oculusSku(){} // RVA: 0x7FFE811C35A0
        public void get_googleProductId(){} // RVA: 0x7FFE81463AE0
        public void set_googleProductId(){} // RVA: 0x7FFE81464570
        public void get_picoSku(){} // RVA: 0x7FFE81280C30
        public void set_picoSku(){} // RVA: 0x7FFE81282380
        public void get_amount(){} // RVA: 0x7FFE8194AD00
        public void set_amount(){} // RVA: 0x7FFE8194A400
        public void get_description(){} // RVA: 0x7FFE8154EB60
        public void set_description(){} // RVA: 0x7FFE818CE320
        public void get_tokens(){} // RVA: 0x7FFE82B06A40
        public void set_tokens(){} // RVA: 0x7FFE82B06FA0
        public void get_imageUrl(){} // RVA: 0x7FFE8179C860
        public void set_imageUrl(){} // RVA: 0x7FFE8171B4D0
        public void Fetch(){} // RVA: 0x7FFE8A332730
        public void .ctor(){} // RVA: 0x7FFE8A332A30
    }

    public class ApiTokenPurchase : ApiTokenBundle
    {
        public System.DateTime _purchaseDate; // 0xA8

        // ── Methods ──
        public void get_PurchaseDate(){} // RVA: 0x7FFE817AB5E0
        public void set_PurchaseDate(){} // RVA: 0x7FFE82904630
        public void .ctor(){} // RVA: 0x7FFE8A332A30
    }

    public class ApiTransaction : ApiModel
    {
        public string _listingID; // 0x68
        public string _name; // 0x70
        public string _sellerId; // 0x78
        public string _fromUserDisplayName; // 0x80
        public string _sellerDisplayName; // 0x88
        public string _buyerId; // 0x90
        public string _buyerDisplayName; // 0x98
        public string _type; // 0xA0
        public System.DateTime _date; // 0xA8
        public int _amount; // 0xB0
        public int _runningBalance; // 0xB4
        public string _imageId; // 0xB8
        public string _purchaseId; // 0xC0
        public string _tiliaRef; // 0xC8
        public object field_14; // 0xC0E0

        // ── Methods ──
        public void get_ListingID(){} // RVA: 0x7FFE81176D50
        public void set_ListingID(){} // RVA: 0x7FFE81176D60
        public void get_Name(){} // RVA: 0x7FFE811C3590
        public void set_Name(){} // RVA: 0x7FFE811C35A0
        public void get_SellerId(){} // RVA: 0x7FFE81463AE0
        public void set_SellerId(){} // RVA: 0x7FFE81464570
        public void get_FromUserDisplayName(){} // RVA: 0x7FFE81280C30
        public void set_FromUserDisplayName(){} // RVA: 0x7FFE81282380
        public void get_SellerDisplayName(){} // RVA: 0x7FFE8113A010
        public void set_SellerDisplayName(){} // RVA: 0x7FFE81280F90
        public void get_BuyerId(){} // RVA: 0x7FFE8154EB60
        public void set_BuyerId(){} // RVA: 0x7FFE818CE320
        public void get_BuyerDisplayName(){} // RVA: 0x7FFE817AE360
        public void set_BuyerDisplayName(){} // RVA: 0x7FFE8171B470
        public void get_Type(){} // RVA: 0x7FFE8179C860
        public void set_Type(){} // RVA: 0x7FFE8171B4D0
        public void get_Date(){} // RVA: 0x7FFE817AB5E0
        public void set_Date(){} // RVA: 0x7FFE82904630
        public void get_Amount(){} // RVA: 0x7FFE82E64BF0
        public void set_Amount(){} // RVA: 0x7FFE86B5F1F0
        public void get_RunningBalance(){} // RVA: 0x7FFE84A61A20
        public void set_RunningBalance(){} // RVA: 0x7FFE84A61A30
        public void get_ImageId(){} // RVA: 0x7FFE811660B0
        public void set_ImageId(){} // RVA: 0x7FFE811660C0
        public void get_PurchaseId(){} // RVA: 0x7FFE81166120
        public void set_PurchaseId(){} // RVA: 0x7FFE81166130
        public void get_TiliaRef(){} // RVA: 0x7FFE81253460
        public void set_TiliaRef(){} // RVA: 0x7FFE81253470
        public void get_TransactionImageUrl(){} // RVA: 0x7FFE8A333E50
        public void FetchList(){} // RVA: 0x7FFE8A333EC0
        public void .ctor(){} // RVA: 0x7FFE8A334DF0
    }

    public class ApiUserIcon : ApiFile
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x7FFE810FB320
        public void FetchList(){} // RVA: 0x7FFE8A34D7B0
        public void UploadIcon(){} // RVA: 0x7FFE8A34E220
        public void .ctor(){} // RVA: 0x7FFE8A2D7590
    }

    public class ApiUserPermission : ApiModel
    {
        public string _ownerId; // 0x68
        public string _name; // 0x70
        public System.Collections.Generic.Dictionary`2<string,object> _data; // 0x78

        // ── Methods ──
        public void get_ownerId(){} // RVA: 0x7FFE81176D50
        public void set_ownerId(){} // RVA: 0x7FFE81176D60
        public void get_name(){} // RVA: 0x7FFE811C3590
        public void set_name(){} // RVA: 0x7FFE811C35A0
        public void get_data(){} // RVA: 0x7FFE81463AE0
        public void set_data(){} // RVA: 0x7FFE81464570
        public void .ctor(){} // RVA: 0x7FFE8A34F570
    }

    public class ApiUserPermissions : Object
    {
        // ── Methods ──
        public void GetPermission_UserIcon(){} // RVA: 0x7FFE8A34E890
        public void GetPermission_InvitePhotos(){} // RVA: 0x7FFE8A34E910
        public void GetPermission_ExtraFavoriteAvatars(){} // RVA: 0x7FFE8A34E990
        public void GetPermission_UserGallery(){} // RVA: 0x7FFE8A34EA10
        public void GetPermission_ProfilePictureOverride(){} // RVA: 0x7FFE8A34EA90
        public void GetPermission_MaximumUserIcons(){} // RVA: 0x7FFE81914040
        public void GetPermission_MaximumUserImages(){} // RVA: 0x7FFE81914040
        public void GetPermission_UseProps(){} // RVA: 0x7FFE8A34EB10
        public void GetPermission_UploadProps(){} // RVA: 0x7FFE8A34EB90
        public void GetPermission_TestProps(){} // RVA: 0x7FFE8A34EC10
        public void Clear(){} // RVA: 0x7FFE8A34EC90
        public void FetchPermissions(){} // RVA: 0x7FFE8A34ECE0
        public void .ctor(){} // RVA: 0x7FFE8A34EFE0
    }

    public class ApiUserPlatformList : ApiModel
    {
        public System.Collections.Generic.List`1<string> _platforms; // 0x68

        // ── Methods ──
        public void get_platforms(){} // RVA: 0x7FFE81176D50
        public void set_platforms(){} // RVA: 0x7FFE81176D60
        public void .ctor(){} // RVA: 0x7FFE8A34FFD0
    }

    public class ApiUserPlatforms : Object
    {
        public 0x664A8A8C _platforms; // 0x10
        public VRC.Core.ApiUserPlatforms _currentUserPlatforms;
        public object field_2; // 0xDE0
        public object field_3; // 0xDE1
        public object field_4; // 0xDE2

        // ── Methods ──
        public void get_platforms(){} // RVA: 0x7FFE811485C0
        public void set_platforms(){} // RVA: 0x7FFE810FE0C0
        public void get_CurrentUserPlatforms(){} // RVA: 0x7FFE8A34F5C0
        public void set_CurrentUserPlatforms(){} // RVA: 0x7FFE8A34F600
        public void Fetch(){} // RVA: 0x7FFE8A34F6A0
        public void Clear(){} // RVA: 0x7FFE8A34F9E0
        public void get_SupportsStandaloneWindows(){} // RVA: 0x7FFE8A34F9F0
        public void get_SupportsAndroid(){} // RVA: 0x7FFE8A34FA00
        public void get_SupportsiOS(){} // RVA: 0x7FFE8A34FA10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ApiVRChatAdminSubscriptionTransaction : ApiVRChatSubscriptionBaseResponse
    {
        public string _userId; // 0x70
        public string _adminUserId; // 0x78
        public string _expiry; // 0x80
        public VRC.Core.ApiVRChatSubscription _subscription; // 0x88

        // ── Methods ──
        public void get_userId(){} // RVA: 0x7FFE811C3590
        public void set_userId(){} // RVA: 0x7FFE811C35A0
        public void get_adminUserId(){} // RVA: 0x7FFE81463AE0
        public void set_adminUserId(){} // RVA: 0x7FFE81464570
        public void get_expiry(){} // RVA: 0x7FFE81280C30
        public void set_expiry(){} // RVA: 0x7FFE81282380
        public void get_subscription(){} // RVA: 0x7FFE8113A010
        public void set_subscription(){} // RVA: 0x7FFE81280F90
        public void .ctor(){} // RVA: 0x7FFE8A350430
    }

    public class ApiVRChatProductDetails : ApiModel
    {
        public bool _enabled; // 0x68
        public string _productType; // 0x70
        public System.Nullable`1<0x664AC8C4> productTypeEnum; // 0x78
        public string _endpoint; // 0x80
        public System.Collections.Generic.Dictionary`2<string,ApiVRChatProductStore> _stores; // 0x88
        public Info _subscriptionInfo; // 0x90
        public GiftInfo _giftInfo; // 0x98
        public TokenInfo _tokenInfo; // 0xA0
        public string _description; // 0xA8

        // ── Methods ──
        public void get_enabled(){} // RVA: 0x7FFE811C3570
        public void set_enabled(){} // RVA: 0x7FFE811C3580
        public void get_productType(){} // RVA: 0x7FFE811C3590
        public void set_productType(){} // RVA: 0x7FFE811C35A0
        public void get_Product(){} // RVA: 0x7FFE8A350160
        public void get_endpoint(){} // RVA: 0x7FFE81280C30
        public void set_endpoint(){} // RVA: 0x7FFE81282380
        public void get_stores(){} // RVA: 0x7FFE8113A010
        public void set_stores(){} // RVA: 0x7FFE81280F90
        public void get_subscriptionInfo(){} // RVA: 0x7FFE8154EB60
        public void set_subscriptionInfo(){} // RVA: 0x7FFE818CE320
        public void get_giftInfo(){} // RVA: 0x7FFE817AE360
        public void set_giftInfo(){} // RVA: 0x7FFE8171B470
        public void get_tokenInfo(){} // RVA: 0x7FFE8179C860
        public void set_tokenInfo(){} // RVA: 0x7FFE8171B4D0
        public void get_description(){} // RVA: 0x7FFE817AB5E0
        public void set_description(){} // RVA: 0x7FFE81857260
        public void .ctor(){} // RVA: 0x7FFE8A350250
    }

    public class ApiVRChatSubscription : ApiModel
    {
        public string _transactionId; // 0x68
        public string _steamItemId; // 0x70
        public ulong _amount; // 0x78
        public string _description; // 0x80
        public string _store; // 0x88
        public string _period; // 0x90
        public bool _active; // 0x98
        public string _status; // 0xA0
        public int _tier; // 0xA8
        public string _starts; // 0xB0
        public string _expires; // 0xB8
        public string _created_at; // 0xC0
        public string _updated_at; // 0xC8
        public bool _isGift; // 0xD0
        public bool _isBulkGift; // 0xD1
        public string _giftedBy; // 0xD8
        public string _giftedByDisplayName; // 0xE0
        public System.Collections.Generic.List`1<string> _licenseGroups; // 0xE8
        public VendorData _vendorData; // 0xF0

        // ── Methods ──
        public void get_transactionId(){} // RVA: 0x7FFE81176D50
        public void set_transactionId(){} // RVA: 0x7FFE81176D60
        public void get_steamItemId(){} // RVA: 0x7FFE811C3590
        public void set_steamItemId(){} // RVA: 0x7FFE811C35A0
        public void get_amount(){} // RVA: 0x7FFE81463AE0
        public void set_amount(){} // RVA: 0x7FFE865EFE40
        public void get_description(){} // RVA: 0x7FFE81280C30
        public void set_description(){} // RVA: 0x7FFE81282380
        public void get_store(){} // RVA: 0x7FFE8113A010
        public void set_store(){} // RVA: 0x7FFE81280F90
        public void get_period(){} // RVA: 0x7FFE8154EB60
        public void set_period(){} // RVA: 0x7FFE818CE320
        public void get_active(){} // RVA: 0x7FFE81611920
        public void set_active(){} // RVA: 0x7FFE81611930
        public void get_status(){} // RVA: 0x7FFE8179C860
        public void set_status(){} // RVA: 0x7FFE8171B4D0
        public void get_tier(){} // RVA: 0x7FFE81A338E0
        public void set_tier(){} // RVA: 0x7FFE81A34770
        public void get_starts(){} // RVA: 0x7FFE81166040
        public void set_starts(){} // RVA: 0x7FFE81166050
        public void get_expires(){} // RVA: 0x7FFE811660B0
        public void set_expires(){} // RVA: 0x7FFE811660C0
        public void get_created_at(){} // RVA: 0x7FFE81166120
        public void set_created_at(){} // RVA: 0x7FFE81166130
        public void get_updated_at(){} // RVA: 0x7FFE81253460
        public void set_updated_at(){} // RVA: 0x7FFE81253470
        public void get_isGift(){} // RVA: 0x7FFE81644E40
        public void set_isGift(){} // RVA: 0x7FFE82619150
        public void get_isBulkGift(){} // RVA: 0x7FFE86EE74B0
        public void set_isBulkGift(){} // RVA: 0x7FFE86EE74C0
        public void get_giftedBy(){} // RVA: 0x7FFE8181EA80
        public void set_giftedBy(){} // RVA: 0x7FFE8117C8A0
        public void get_giftedByDisplayName(){} // RVA: 0x7FFE8117C900
        public void set_giftedByDisplayName(){} // RVA: 0x7FFE8117C910
        public void get_licenseGroups(){} // RVA: 0x7FFE8117C970
        public void set_licenseGroups(){} // RVA: 0x7FFE8117C980
        public void get_vendorData(){} // RVA: 0x7FFE811662A0
        public void set_vendorData(){} // RVA: 0x7FFE811662B0
        public void ToString(){} // RVA: 0x7FFE8A350480
        public void .ctor(){} // RVA: 0x7FFE8A3509D0
    }

    public class ApiVRChatSubscriptionBaseResponse : ApiModel
    {
        public VRC.Core.ApiVRChatSubscriptionError _error; // 0x68

        // ── Methods ──
        public void get_error(){} // RVA: 0x7FFE81176D50
        public void set_error(){} // RVA: 0x7FFE81176D60
        public void .ctor(){} // RVA: 0x7FFE8A350430
    }

    public class ApiVRChatSubscriptionError : Object
    {
        public int _status_code; // 0x10
        public string _message; // 0x18

        // ── Methods ──
        public void get_status_code(){} // RVA: 0x7FFE811485C0
        public void set_status_code(){} // RVA: 0x7FFE810FE0C0
        public void get_message(){} // RVA: 0x7FFE810FE7C0
        public void set_message(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ApiViewfinderSkin : ApiModel
    {
        public string _name; // 0x68
        public string _assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_assetBundleId(){} // RVA: 0x7FFE811C3590
        public void set_assetBundleId(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A350020
    }

    public class ApiWarpEffectSkin : ApiModel
    {
        public string _name; // 0x68
        public string _assetBundleId; // 0x70

        // ── Methods ──
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_assetBundleId(){} // RVA: 0x7FFE811C3590
        public void set_assetBundleId(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE8A350B10
    }

    public class ApiWorld : ApiModel
    {
        public VRC.Core.AssetVersion _VERSION;
        public VRC.Core.AssetVersion MIN_LOADABLE_VERSION; // 0x8
        public float ListCacheTime;
        public float SingleRecordCacheTime;
        public string ADMIN_TAG_INTERNAL;
        public System.Collections.Generic.Dictionary`2<string,VRC.Core.ApiWorld> localWorlds; // 0x10
        public string LOCALIZED_INSTANCES_EXPERIMENT_KEY;
        public 0x664ACD3C _localizedInstancesExperimentState; // 0x18
        public bool _isLocalizedInstancesExperimentLoaded; // 0x1C
        public bool _hasLocalizedInstancesExposureSent; // 0x1D
        public string _name; // 0x68
        public string _imageUrl; // 0x70
        public string _thumbnailImageUrl; // 0x78
        public string _authorName; // 0x80
        public string _releaseStatus; // 0x88
        public int _capacity; // 0x90
        public int _recommendedCapacity; // 0x94
        public int _occupants; // 0x98
        public int _publicOccupants; // 0x9C
        public int _privateOccupants; // 0xA0
        public string _authorId; // 0xA8
        public System.DateTime _createdAt; // 0xB0
        public string _assetUrl; // 0xB8
        public string _description; // 0xC0
        public System.Collections.Generic.List`1<string> _tags; // 0xC8
        public System.Collections.Generic.List`1<string> _urlList; // 0xD0
        public string _unityPackageUrl; // 0xD8
        public int _version; // 0xE0
        public string _unityVersion; // 0xE8
        public int _apiVersion; // 0xF0
        public int _latestAssetVersion; // 0xF4
        public System.DateTime _created_at; // 0xF8
        public System.DateTime _updated_at; // 0x100
        public System.DateTime _publicationDate; // 0x108
        public System.DateTime _labsPublicationDate; // 0x110
        public System.Collections.Generic.List`1<string> _udonProducts; // 0x118
        public string _storeId; // 0x120
        public string _platform; // 0x128
        public System.Collections.Generic.List`1<VRC.Core.ApiWorldInstance> mWorldInstances; // 0x130
        public bool _unityPackageUpdated; // 0x138
        public string _organization; // 0x140
        public bool _shouldAddToAuthor; // 0x148
        public string _favoriteId; // 0x150
        public int _favorites; // 0x158
        public int _visits; // 0x15C
        public int _popularity; // 0x160
        public int _heat; // 0x164
        public bool _detailed; // 0x168
        public System.Collections.Generic.Dictionary`2<string,bool> _defaultContentSettings; // 0x170
        public string _bundleSignature; // 0x178

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0x7FFE8A350B60
        public void get_LocalizedInstancesExperimentState(){} // RVA: 0x7FFE8A350D60
        public void ShouldCache(){} // RVA: 0x7FFE8A351150
        public void GetLifeSpan(){} // RVA: 0x7FFE8A3511A0
        public void get_name(){} // RVA: 0x7FFE81176D50
        public void set_name(){} // RVA: 0x7FFE81176D60
        public void get_imageUrl(){} // RVA: 0x7FFE811C3590
        public void set_imageUrl(){} // RVA: 0x7FFE811C35A0
        public void get_thumbnailImageUrl(){} // RVA: 0x7FFE81463AE0
        public void set_thumbnailImageUrl(){} // RVA: 0x7FFE81464570
        public void get_authorName(){} // RVA: 0x7FFE81280C30
        public void set_authorName(){} // RVA: 0x7FFE81282380
        public void get_releaseStatus(){} // RVA: 0x7FFE8113A010
        public void set_releaseStatus(){} // RVA: 0x7FFE81280F90
        public void get_capacity(){} // RVA: 0x7FFE814AA220
        public void set_capacity(){} // RVA: 0x7FFE81C8DB30
        public void get_recommendedCapacity(){} // RVA: 0x7FFE814AA230
        public void set_recommendedCapacity(){} // RVA: 0x7FFE81680470
        public void get_occupants(){} // RVA: 0x7FFE82B06A40
        public void set_occupants(){} // RVA: 0x7FFE82B06FA0
        public void get_publicOccupants(){} // RVA: 0x7FFE82B06F90
        public void set_publicOccupants(){} // RVA: 0x7FFE82B06A30
        public void get_privateOccupants(){} // RVA: 0x7FFE82B06FB0
        public void set_privateOccupants(){} // RVA: 0x7FFE82B06FC0
        public void get_authorId(){} // RVA: 0x7FFE817AB5E0
        public void set_authorId(){} // RVA: 0x7FFE81857260
        public void get_createdAt(){} // RVA: 0x7FFE81166040
        public void set_createdAt(){} // RVA: 0x7FFE82904640
        public void get_assetUrl(){} // RVA: 0x7FFE811660B0
        public void set_assetUrl(){} // RVA: 0x7FFE811660C0
        public void get_description(){} // RVA: 0x7FFE81166120
        public void set_description(){} // RVA: 0x7FFE81166130
        public void get_tags(){} // RVA: 0x7FFE81253460
        public void set_tags(){} // RVA: 0x7FFE81253470
        public void get_urlList(){} // RVA: 0x7FFE81218100
        public void set_urlList(){} // RVA: 0x7FFE81218110
        public void get_unityPackageUrl(){} // RVA: 0x7FFE8181EA80
        public void set_unityPackageUrl(){} // RVA: 0x7FFE8117C8A0
        public void get_version(){} // RVA: 0x7FFE82AA02F0
        public void set_version(){} // RVA: 0x7FFE82AA0300
        public void get_unityVersion(){} // RVA: 0x7FFE8117C970
        public void set_unityVersion(){} // RVA: 0x7FFE8117C980
        public void get_apiVersion(){} // RVA: 0x7FFE843B5350
        public void set_apiVersion(){} // RVA: 0x7FFE86DBACB0
        public void get_latestAssetVersion(){} // RVA: 0x7FFE84A61F50
        public void set_latestAssetVersion(){} // RVA: 0x7FFE84A61F60
        public void get_created_at(){} // RVA: 0x7FFE8158D5D0
        public void set_created_at(){} // RVA: 0x7FFE84A61F90
        public void get_updated_at(){} // RVA: 0x7FFE81828B50
        public void set_updated_at(){} // RVA: 0x7FFE82472650
        public void get_publicationDate(){} // RVA: 0x7FFE8181E3D0
        public void set_publicationDate(){} // RVA: 0x7FFE813173C0
        public void get_labsPublicationDate(){} // RVA: 0x7FFE81317980
        public void set_labsPublicationDate(){} // RVA: 0x7FFE86F10630
        public void get_udonProducts(){} // RVA: 0x7FFE81318010
        public void set_udonProducts(){} // RVA: 0x7FFE81317920
        public void get_storeId(){} // RVA: 0x7FFE813A1DA0
        public void set_storeId(){} // RVA: 0x7FFE813A0830
        public void get_platform(){} // RVA: 0x7FFE8182B890
        public void set_platform(){} // RVA: 0x7FFE81B31E10
        public void get_worldInstances(){} // RVA: 0x7FFE81823850
        public void get_isAdminApproved(){} // RVA: 0x7FFE8A3511B0
        public void get_IsCommunityLabsWorld(){} // RVA: 0x7FFE8A351230
        public void get_IsPublicPublishedWorld(){} // RVA: 0x7FFE8A3512A0
        public void get_IsInternalWorld(){} // RVA: 0x7FFE8A351320
        public void get_unityPackageUpdated(){} // RVA: 0x7FFE8A351380
        public void set_unityPackageUpdated(){} // RVA: 0x7FFE8A351390
        public void get_organization(){} // RVA: 0x7FFE811665F0
        public void set_organization(){} // RVA: 0x7FFE81166600
        public void get_shouldAddToAuthor(){} // RVA: 0x7FFE823E5620
        public void set_shouldAddToAuthor(){} // RVA: 0x7FFE823F09C0
        public void get_favoriteId(){} // RVA: 0x7FFE81790740
        public void set_favoriteId(){} // RVA: 0x7FFE81B350B0
        public void get_favorites(){} // RVA: 0x7FFE8A3513A0
        public void set_favorites(){} // RVA: 0x7FFE87DA6580
        public void get_visits(){} // RVA: 0x7FFE8A3513B0
        public void set_visits(){} // RVA: 0x7FFE87DA65A0
        public void get_popularity(){} // RVA: 0x7FFE8178E0A0
        public void set_popularity(){} // RVA: 0x7FFE8178E8A0
        public void get_heat(){} // RVA: 0x7FFE8A3212D0
        public void set_heat(){} // RVA: 0x7FFE8A3212E0
        public void get_detailed(){} // RVA: 0x7FFE822E7DC0
        public void set_detailed(){} // RVA: 0x7FFE82367120
        public void get_defaultContentSettings(){} // RVA: 0x7FFE815BB6A0
        public void set_defaultContentSettings(){} // RVA: 0x7FFE81B38790
        public void get_assetVersion(){} // RVA: 0x7FFE8A3513C0
        public void set_assetVersion(){} // RVA: 0x7FFE8A351470
        public void get_BundleSignature(){} // RVA: 0x7FFE815BB1F0
        public void set_BundleSignature(){} // RVA: 0x7FFE81B10700
        public void get_isCurated(){} // RVA: 0x7FFE8A351500
        public void set_isCurated(){} // RVA: 0x7FFE8A351510
        public void get_publicTags(){} // RVA: 0x7FFE8A351520
        public void .ctor(){} // RVA: 0x7FFE8A351720
        public void ReadField(){} // RVA: 0x7FFE8A351930
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFE8A351B10 | overloaded x2
        public void ReadUnityPackages(){} // RVA: 0x7FFE8A351BF0
        public void ReadUnityPackage(){} // RVA: 0x7FFE8A352340
        public void WriteField(){} // RVA: 0x7FFE8A3529A0
        public void CopyDeserializedValuesTo(){} // RVA: 0x7FFE8A353810
        public void Save(){} // RVA: 0x7FFE8A353C70
        public void Fetch(){} // RVA: 0x7FFE8A353E20
        public void FetchList(){} // RVA: 0x7FFE8A354950
        public void FetchSearchResults(){} // RVA: 0x7FFE8A354E00
        public void AddLocal(){} // RVA: 0x7FFE8A355300
        public void get_IsLocal(){} // RVA: 0x7FFE8A3553D0
        public void SetLocal(){} // RVA: 0x7FFE8A3554B0
        public void ShouldNotBeVisibleOptional(){} // RVA: 0x7FFE8A355680
        public void GetBestInstance(){} // RVA: 0x7FFE8A355A30 | overloaded x2
        public void SendLocalizedInstancesExperimentExposure(){} // RVA: 0x7FFE8A355C90
        public void SendLocalizedInstancesExperimentEvent(){} // RVA: 0x7FFE8A355F50
        public void CreateNewInstanceAsync(){} // RVA: 0x7FFE8A3562C0
        public void CreateNewInstance(){} // RVA: 0x7FFE8A356680
        public void FetchUploadedWorlds(){} // RVA: 0x7FFE8A356B70
        public void PublishWorldToCommunityLabs(){} // RVA: 0x7FFE8A357060
        public void UpdateVersionAndPlatform(){} // RVA: 0x7FFE8A3573A0
        public void MakeRequestEndpoint(){} // RVA: 0x7FFE8A357510
        public void Merge(){} // RVA: 0x7FFE8A357530
        public void .cctor(){} // RVA: 0x7FFE8A357E00
    }

    public class ApiWorldInstance : ApiModel
    {
        public float CacheTime;
        public int MAX_NAME_LENGTH;
        public string _location; // 0x68
        public string _name; // 0x70
        public string _shortName; // 0x78
        public string _secureName; // 0x80
        public string _displayName; // 0x88
        public string _worldId; // 0x90
        public string _instanceId; // 0x98
        public VRC.Core.ApiWorld _world; // 0xA0
        public 0x664ADEC4 _type; // 0xA8
        public string _ownerId; // 0xB0
        public System.Collections.Generic.List`1<string> _tags; // 0xB8
        public int _count; // 0xC0
        public int _capacity; // 0xC4
        public int _recommendedCapacity; // 0xC8
        public System.Collections.Generic.Dictionary`2<string,int> _platforms; // 0xD0
        public string _nonce; // 0xD8
        public string _clientVersion; // 0xE0
        public int _gameServerVersion; // 0xE8
        public 0x664AE12C _region; // 0xEC
        public bool _active; // 0xF0
        public bool _queueEnabled; // 0xF1
        public bool _hasCapacityForYou; // 0xF2
        public int _queueSize; // 0xF4
        public System.DateTime _closedAt; // 0xF8
        public bool _hardClose; // 0x100
        public bool _ageGate; // 0x101
        public System.Collections.Generic.Dictionary`2<string,bool> _contentSettings; // 0x108
        public bool _playerPersistenceEnabled; // 0x110
        public string _calendarEntryId; // 0x118
        public System.Collections.Generic.List`1<VRC.Core.APIUser> _users; // 0x120
        public System.Collections.Generic.List`1<string> _roleIds; // 0x128
        public bool _roleRestricted; // 0x130
        public string _groupAccessType; // 0x138
        public string _minimumAvatarPerformance; // 0x140
        public System.Collections.Generic.Dictionary`2<string,double> _languageRatioMap; // 0x148
        public string _dominantLanguageCode; // 0x150
        public object _lastPostTimeLock;
        public bool _postInProgress; // 0x8
        public System.Nullable`1<long> _lastPostTime; // 0x10

        // ── Methods ──
        public void get_location(){} // RVA: 0x7FFE81176D50
        public void set_location(){} // RVA: 0x7FFE81176D60
        public void get_name(){} // RVA: 0x7FFE811C3590
        public void set_name(){} // RVA: 0x7FFE8A35D7C0
        public void get_shortName(){} // RVA: 0x7FFE81463AE0
        public void set_shortName(){} // RVA: 0x7FFE81464570
        public void get_secureName(){} // RVA: 0x7FFE81280C30
        public void set_secureName(){} // RVA: 0x7FFE81282380
        public void get_displayName(){} // RVA: 0x7FFE8113A010
        public void set_displayName(){} // RVA: 0x7FFE81280F90
        public void get_worldId(){} // RVA: 0x7FFE8154EB60
        public void set_worldId(){} // RVA: 0x7FFE818CE320
        public void get_instanceId(){} // RVA: 0x7FFE817AE360
        public void set_instanceId(){} // RVA: 0x7FFE8171B470
        public void get_world(){} // RVA: 0x7FFE8179C860
        public void set_world(){} // RVA: 0x7FFE8171B4D0
        public void get_type(){} // RVA: 0x7FFE81A338E0
        public void set_type(){} // RVA: 0x7FFE81A34770
        public void get_ownerId(){} // RVA: 0x7FFE81166040
        public void set_ownerId(){} // RVA: 0x7FFE81166050
        public void get_tags(){} // RVA: 0x7FFE811660B0
        public void set_tags(){} // RVA: 0x7FFE811660C0
        public void get_count(){} // RVA: 0x7FFE813AB640
        public void set_count(){} // RVA: 0x7FFE813A4A00
        public void get_capacity(){} // RVA: 0x7FFE82A3B5F0
        public void set_capacity(){} // RVA: 0x7FFE86CE9440
        public void get_recommendedCapacity(){} // RVA: 0x7FFE81790750
        public void set_recommendedCapacity(){} // RVA: 0x7FFE8453D840
        public void get_platforms(){} // RVA: 0x7FFE81218100
        public void set_platforms(){} // RVA: 0x7FFE81218110
        public void get_nonce(){} // RVA: 0x7FFE8181EA80
        public void set_nonce(){} // RVA: 0x7FFE8117C8A0
        public void get_clientVersion(){} // RVA: 0x7FFE8117C900
        public void set_clientVersion(){} // RVA: 0x7FFE8117C910
        public void get_gameServerVersion(){} // RVA: 0x7FFE82A3E380
        public void set_gameServerVersion(){} // RVA: 0x7FFE86DBADE0
        public void get_region(){} // RVA: 0x7FFE82A3B600
        public void set_region(){} // RVA: 0x7FFE86DBACA0
        public void get_active(){} // RVA: 0x7FFE8117CAD0
        public void set_active(){} // RVA: 0x7FFE8117CAE0
        public void get_queueEnabled(){} // RVA: 0x7FFE82145E40
        public void set_queueEnabled(){} // RVA: 0x7FFE82145F60
        public void get_hasCapacityForYou(){} // RVA: 0x7FFE82144680
        public void set_hasCapacityForYou(){} // RVA: 0x7FFE82146D10
        public void get_queueSize(){} // RVA: 0x7FFE84A61F50
        public void set_queueSize(){} // RVA: 0x7FFE84A61F60
        public void get_closedAt(){} // RVA: 0x7FFE8158D5D0
        public void set_closedAt(){} // RVA: 0x7FFE84A61F90
        public void get_hardClose(){} // RVA: 0x7FFE81F84400
        public void set_hardClose(){} // RVA: 0x7FFE81F84A40
        public void get_ageGate(){} // RVA: 0x7FFE82904E20
        public void set_ageGate(){} // RVA: 0x7FFE82904730
        public void get_contentSettings(){} // RVA: 0x7FFE8181E3D0
        public void set_contentSettings(){} // RVA: 0x7FFE81A60200
        public void get_IsClosed(){} // RVA: 0x7FFE8A35D8B0
        public void get_IsAgeGated(){} // RVA: 0x7FFE8A35D9D0
        public void get_playerPersistenceEnabled(){} // RVA: 0x7FFE81472650
        public void set_playerPersistenceEnabled(){} // RVA: 0x7FFE81472660
        public void get_calendarEntryId(){} // RVA: 0x7FFE81318010
        public void set_calendarEntryId(){} // RVA: 0x7FFE81317920
        public void get_users(){} // RVA: 0x7FFE813A1DA0
        public void set_users(){} // RVA: 0x7FFE813A0830
        public void get_ShouldSeeInstanceByType(){} // RVA: 0x7FFE8A35DB20
        public void get_roleIds(){} // RVA: 0x7FFE8182B890
        public void set_roleIds(){} // RVA: 0x7FFE81B31E10
        public void get_roleRestricted(){} // RVA: 0x7FFE87456560
        public void set_roleRestricted(){} // RVA: 0x7FFE876A0740
        public void get_groupAccessType(){} // RVA: 0x7FFE8181EA70
        public void set_groupAccessType(){} // RVA: 0x7FFE818254E0
        public void get_minimumAvatarPerformance(){} // RVA: 0x7FFE811665F0
        public void set_minimumAvatarPerformance(){} // RVA: 0x7FFE81166600
        public void get_languageRatioMap(){} // RVA: 0x7FFE81166660
        public void set_languageRatioMap(){} // RVA: 0x7FFE81166670
        public void get_dominantLanguageCode(){} // RVA: 0x7FFE81790740
        public void set_dominantLanguageCode(){} // RVA: 0x7FFE81B350B0
        public void get_id(){} // RVA: 0x7FFE81176D50
        public void set_id(){} // RVA: 0x7FFE8A35DC40
        public void .ctor(){} // RVA: 0x7FFE8A35DFD0 | overloaded x3
        public void Init(){} // RVA: 0x7FFE8A35E010
        public void Get(){} // RVA: 0x7FFE8A35E780
        public void MakeRequestEndpoint(){} // RVA: 0x7FFE8A35EA10
        public void SetInstanceAccessTypeFromId(){} // RVA: 0x7FFE8A35EA80
        public void ExtractInfoFromLocation(){} // RVA: 0x7FFE8A35ECF0
        public void BuildRequest(){} // RVA: 0x7FFE8A35F3E0
        public void GetLifeSpan(){} // RVA: 0x7FFE8A35FB30
        public void ReadField(){} // RVA: 0x7FFE8A35FB40
        public void WriteField(){} // RVA: 0x7FFE8A35FED0
        public void SetApiFieldsFromJson(){} // RVA: 0x7FFE8A360090 | overloaded x2
        public void ParseTags(){} // RVA: 0x7FFE8A360130
        public void ToString(){} // RVA: 0x7FFE8A3603D0
        public void GetShortName(){} // RVA: 0x7FFE8A360490
        public void get_ProbablyExistsOnAPI(){} // RVA: 0x7FFE8A360830
        public void CreateOrFetch(){} // RVA: 0x7FFE8A360A20 | overloaded x2
        public void CreateOrFetchAsync(){} // RVA: 0x7FFE8A360E90 | overloaded x2
        public void CreateOrFetchAsyncInternal(){} // RVA: 0x7FFE8A361060
        public void .cctor(){} // RVA: 0x7FFE8A361280
        public void <get_ProbablyExistsOnAPI>b__173_0(){} // RVA: 0x7FFE8A361350
    }

    public class AreaBase : Object
    {
        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AssetVersion : Object
    {
        public string _unityVersion; // 0x10
        public VRC.Core.UnityVersion _unityVersionObj; // 0x18
        public int _apiVersion; // 0x2C

        // ── Methods ──
        public void get_UnityVersion(){} // RVA: 0x7FFE8A372510
        public void set_UnityVersion(){} // RVA: 0x7FFE810FCE30
        public void get_UnityVersionObj(){} // RVA: 0x7FFE8A372600
        public void get_ApiVersion(){} // RVA: 0x7FFE81F84A50
        public void set_ApiVersion(){} // RVA: 0x7FFE82883A50
        public void .ctor(){} // RVA: 0x7FFE8A372810 | overloaded x3
        public void ToString(){} // RVA: 0x7FFE8A372870
    }

}