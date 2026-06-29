import json, os

assignments = [
    (0,  'AvatarDetailsPanel',           'high',   'fields _selectedAvatarPanel/_avatarPriceContainer/_primaryPurchaseButton/_avatarNameText/_performanceRankText'),
    (1,  'AvatarListItemCell',            'high',   'fields _avatarPanel/_authorCell/_image/_nameField/_favoriteButtonText with UpdateHeight method'),
    (2,  'SearchResultsTabBar',           'high',   'fields _searchAllButton/_searchWorldsButton/_searchAvatarsButton/_searchUsersButton each with CountText'),
    (3,  'SearchFilterSourcePanel',       'high',   'fields _sourceFoldoutToggle/_sourceListBinding/_sourceSelectAllButton/_sourceDeselectAllButton/_accessTypeFoldoutToggle'),
    (4,  'NotificationActionCell',        'high',   'fields _NotificationActions/_AcceptButton/_DeclineButton/_RespondButton/_ViewProfileButton/_ReportButton/_WalletButton'),
    (5,  'GeneralSettingsPanel',          'high',   'inherits TrackingCalibrationBase; fields _showTooltips/_preferredLanguage/_afkDetection/_oneHandedMovement/_wingPersistence'),
    (6,  'MarketplaceListingCell',        'high',   'inherits UIscrollRectfootnote; fields _listingTitleText/_listingAuthorText/_limitedAvailabilityPanel/_limitedTimeContainer'),
    (7,  'EmojiPickerGrid',               'high',   'fields pickers/pickerPrefab/content/scrollRect/searchQuery/searchUserTags/expandedCount/collapsedCount/collapseRows'),
    (8,  'WorldDetailPanel',              'high',   'fields _worldInstanceInfoPane/_instancesListBinding/_tagsListBinding/_contentWarningsListBinding/_instancePrefab/_worldPrefab'),
    (9,  'PhotonPeerExtended',            'medium', 'inherits PhotonPeer; fields _debugBuild/_clientVersion/_useInitV3/_enableEncryptedFlag/_nativeEncryptorApiVersion'),
    (10, 'MarketplaceListingDetailCell',  'high',   'inherits UIscrollRectfootnote; fields _modalPanel/_bundleBanner/_listingTypeKeyText/_productTypeIconLabel/_subscriptionPanel/_subscriptionExpirationText'),
    (12, 'CreateInstancePanel',           'high',   'fields createInstanceButton/changeGroupButton/changeRolesButton/changeInstanceTypeButton/selectedGroupText/queueEnabledToggle'),
    (13, 'CameraAvatarOverlayUI',         'high',   'fields avatarImage/dragHandler/cameraButton/cameraButtonText/nameButton/nameText/reparentPanel'),
    (14, 'AvatarPerformanceDetailsPanel', 'high',   'fields _avatarPanel/_overallPerformanceRatingIcon/_overallPerformance/_trianglesField/_boundsField/_skinnedMeshesField/_textureMemoryField'),
    (15, 'ShareContentPanel',             'high',   'fields shareDirect/dropPrintCanvasGroup/dropPrint/printAsPrint/copyUrlButton/shareAsPedestal/selectShareMethodCanvasGroup'),
    (18, 'CreateInstanceSettingsPanel',   'high',   'fields parent/createInstanceButton/changeGroupButton/changeRolesButton/setDefaultSettingsToggle/queueEnabledToggle/selectedGroupText'),
    (19, 'EventDetailPanel',              'high',   'fields _eventTitleText/_eventDateText/_eventImageBinding/_livePill/_categoryPill/_reportButton/_backButton'),
    (20, 'MarketplaceProductCell',        'high',   'fields _nameText/_itemCost/_purchaseButton/_previewButton/_ownedBanner/_premiumBanner/_styleElement/_descriptionPanel'),
    (21, 'SubscriptionPurchasePanel',     'high',   'field subscribeMonthlyButton with OnApplicationFocus, inherits UIk__BackingField'),
    (22, 'GiftPurchaseConfirmPanel',      'high',   'inherits UIscrollRectfootnote; fields _recipientUserIcon/_recipientNameText/_purchaseSubtitleText/_subscriptionPanel/_thumbnailQuantityText'),
    (23, 'AvatarPurchasePanel',           'high',   'fields _titleText/_purchaseButton/_giftButton/_avatarUnavailableBanner/_priceAndPurchaseButtonContainer'),
    (24, 'WorldCell',                     'high',   'fields ThumbnailImage/Name/UserCount/FriendCount/IconFriendCount/_contentWarningBanner/_platformPrefab/_toolTip'),
    (25, 'PhotoCapturePanel',             'high',   'fields cancelButton/retakeButton/addNoteButton/printAndSaveButton/printCreationCameraPrefab/printPositionTransform'),
    (26, 'ReportSubmitPanel',             'high',   'fields _submitButton/_closeButton/_reportingInfoObject/_whatsReportedText/_togglePrefab/_categoryList'),
    (27, 'EmojiPickerCell',               'medium', 'fields image/nameText/nameFade/newBadgeHover/selectedOutline/buttonHover/animationPlayer/exclusiveBackground'),
    (28, 'MarketplaceOrderHistoryCell',   'high',   'fields _name/_itemCost/_purchaseDateValueText/_viewProductButton/_renewSubButton/_cancelSubButton/_resubscribeButton/_giftInformation'),
    (29, 'WorldInstanceCell',             'high',   'fields InstanceName/InstanceType/UserCount/FriendCount/WorldName/HypeTrainIcon/RegionIcon/FavoriteIcon/AgeGateIcon'),
    (30, 'AvatarSidebarPanel',            'high',   'inherits UIk__BackingField; fields _avatarSidePanel/_avatarListView/_searchButton/_currentAvatarButton/_VRCPlusGetMoreAvatars'),
    (32, 'PrintEditorPanel',              'high',   'fields itemsPanel/previewPanel/transformPanel/variablesPanel/cancelButton/acceptButton/undoButton/redoButton/resetButton/itemCellPrefab'),
    (33, 'GroupAnnouncementCell',         'high',   'fields headerText/announcementDateText/imageBinding/imageButton/groupImage/groupName/announcementText'),
    (34, 'QuickMenuHandCoachPanel',       'high',   'fields handCoachAnimator/handCoachHeadTransform/leftCoachWristTransform/rightCoachWristTransform/hmdRenderer/qmPinchForwardAngle with OnDrawGizmos'),
    (35, 'UdonActionMenuPanel',           'high',   'fields titleText/contextText/closeButton/groupPrevButton/groupNextButton/groupInputField/groupContainer/actionMenu'),
    (37, 'JoinInstancePanel',             'high',   'fields _closeButton/_joinButton/_historyButton/_dropPortalButton/_instanceNameInputField/_groupInstanceFields/_worldNameText/_instanceTypeText'),
    (38, 'DroneControllerSettingsPanel',  'high',   'fields canvasGroup/presetSubmenuButton/scrollRect/cameraTilt/maxAngleSlider/expoPitchSlider/expoRollSlider/expoYawSlider/expoThrottleSlider'),
    (43, 'EmojiEditorPanel',              'high',   'fields headerText/zoomSlider/mirrorButton/acceptTextureButton/cancelButton/previewImage/emojiParticleSystemSelection/emojiMaskPicker/fpsSlider'),
    (44, 'WorldFavoritesPanel',           'high',   'fields _filterButton/_avatarCategoriesList/_avatarCategoryPrefab/_avatarCellPrefab/_selectedAvatarPanel/_sortDropdown'),
    (48, 'ReportTypeSelectionPanel',      'high',   'fields ReportUser/ReportAvatar/ReportWorld/ReportGroup/ReportInstance/ReportSticker/ReportEmoji/ReportPrint/ButtonSection/UserSection'),
    (49, 'ImageCarouselPanel',            'high',   'fields _leftButton/_rightButton/_rightPos/_leftPos/_centerPos/_imageContainer/_scrollTime/_displayImage/_slideImage'),
    (58, 'AvatarCollectionPanel',         'high',   'fields _avatarListSelectorListBinding/_collectionSelectorGroup/_avatarListView/_avatarListLockedBanner/_sortDropdown/_looksFoldout/_avatarsFoldout'),
    (59, 'VRCPlusSubscriptionPanel',      'high',   'inherits UIk__BackingField; fields scrollRect/NonSubParent/CampaignPanel/GiftingLeaderboard/VRCPlusBanners/RewardPanel/ManageSubscriptionLink'),
    (62, 'UserProfileTabsPanel',          'high',   'fields editProfileButton/userProfilePanelButtonWithIndicator/userWalletPanelButtonWithIndicator/userMediaPanelButtonWithIndicator/userWalletPanel'),
    (63, 'VRCPlusCampaignPanel',          'high',   'fields giftToFriend/giftDrop/contributionInfoParent/participatingCount/contributedFriendCount/friendParticipantImageBindings/campaignEndDate/campaignTitleText'),
    (64, 'GraphicsSettingsPanel',         'high',   'inherits TrackingCalibrationBase; fields _graphicsQuality/_antiAliasing/_mirrorResolution/_shadowQuality/_lodQuality/_thirdPersonView'),
    (65, 'AvatarBrowsePanel',             'high',   'fields _filterButton/_scrollRect/_avatarCategoriesList/_avatarCategoryPrefab/_selectedAvatarPanel/_timeToRefresh/_sortDropdown'),
    (66, 'FriendListPanel',               'medium', 'inherits UIk__BackingFieldComponentImpl; fields _scrollRect/_status/_statusIcon/search/_buttonGroup/_buttons/_headerText/_cellSizeToggle'),
    (67, 'WorldInstanceListPanel',        'high',   'fields _friendListBinding/_nonFriendListBinding/_friendWorldInstancePrefab/_worldInstancePrefab/_sortDropdown/emptyObject/emptyLabel'),
    (68, 'WorldSearchFilterPanel',        'high',   'inherits UIk__BackingField; fields _myStuffFoldout/_worldsMyStuff/_worldsMyStuffPlaylists/_worldCategoryPicker/_dropdownFilter'),
    (69, 'AvatarPreviewCamera',           'high',   'fields renderCamera/previewScene/previewSceneRenderSet/avatarContainer/cameraReplacementShader/blitDepthMaterial/lookThumbnailPostProcessor'),
    (70, 'StorePurchaseItemPanel',        'high',   'fields PurchaseButtonGameObject/OwnedPanel/ProcessingGameObject/SubscribedBanner/NameText/DescriptionText/PriceText/ExpireText/PuchaseButtonText'),
    (72, 'SearchSortOptionsPanel',        'high',   'inherits UIscrollRectfootnote; fields _searchTypeRelevance/_searchTypeCustom/_sortByLastUpdated/_sortByPopular/_sortByTrust/_sortByLastLoggedIn'),
    (73, 'GroupInfoPanel',                'high',   'inherits ButtonIndicatorBase; fields reportGroupButton/shareButton/groupNameText/showGalleryButtonWithIndicator/showMembersButtonWithIndicator'),
    (74, 'ControllerSettingsPanel',       'high',   'fields canvasGroup/mainControllerTypeLabel/keyboardAndMouseControllerTypeLabel/deadzoneSlider/controllerKBSensitivitySlider/controllerMouseSensitivitySlider'),
    (75, 'BundlePurchasePanel',           'high',   'inherits UIk__BackingField; fields buyMenu/processingTransactionMenu/purchaseBundlesParent/buyBundleButtonPrefab/ownedBundleButton'),
    (77, 'MarketplaceInventoryPanel',     'high',   'fields previewPanel/itemsBinding/exploreMarketplaceButton/itemCellPrefab/infoIcon'),
    (78, 'ContentThumbnailCell',          'high',   'inherits ContainerPromptBaseImpl; fields _noThumbnailTexture/_image/_title/_favoriteIcon/_platformPrefab/_contentWarningBanner/_scanStatusFailed/_scanStatusPending'),
]

with open('D:/Project/vrchat-il2cpp-re/output/wf_shards/shard_00.json', 'r', encoding='utf-8') as f:
    data = json.load(f)

idx_to_name = {i: d['original_name'] for i, d in enumerate(data)}

results = []
for idx, proposed, conf, reason in assignments:
    results.append({
        'original_name': idx_to_name[idx],
        'proposed_name': proposed,
        'confidence': conf,
        'reason': reason
    })

os.makedirs('D:/Project/vrchat-il2cpp-re/output/wf_results', exist_ok=True)
with open('D:/Project/vrchat-il2cpp-re/output/wf_results/shard_00.json', 'w', encoding='utf-8') as f:
    json.dump(results, f, ensure_ascii=False, indent=2)

print(f"Written {len(results)} entries")
