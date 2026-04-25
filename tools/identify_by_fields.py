#!/usr/bin/env python3
"""Identify remaining ComplexComponents by their field names."""
import json, sys, re
from pathlib import Path

sys.stdout.reconfigure(encoding='utf-8')
BASE_DIR = Path(__file__).resolve().parent.parent

# Field data from runtime scanning (141 remaining classes)
field_data = [
{"va":"0x33E7C3D0","fc":7,"fn":[]},
{"va":"0x3341F6C0","fc":4,"fn":[]},
{"va":"0x336BD380","fc":5,"fn":["_layout","_avatarPanel","_avatarUnavailableBanner","_favoriteButton"]},
{"va":"0x334A4510","fc":9,"fn":["NoReportsMessage","HeaderText","TotalReportsText","_scrollRect","_radioButtonSelectorGroup","showMore"]},
{"va":"0x3397F150","fc":0,"fn":[]},
{"va":"0x3409E320","fc":8,"fn":[]},
{"va":"0x3198A3F0","fc":0,"fn":[]},
{"va":"0x33AE6A30","fc":23,"fn":["_creditsNeededForPurchaseText","_currentCreditBalanceText","_allCreditBundleOptionsPanel","_otherCreditBundleOptionsPanel","_bestCreditBundle","_secondBestCreditBundle","_thirdBestCreditBundle","_creditPurchasesCurrentlyUnavailableMessage","_processingOverlay","_cancelProcessingButton","_backButton"]},
{"va":"0x344B7E10","fc":0,"fn":[]},
{"va":"0x34156790","fc":8,"fn":[]},
{"va":"0x33A17210","fc":0,"fn":[]},
{"va":"0x339771B0","fc":6,"fn":["_titleText","_backButton","_shuffleButton"]},
{"va":"0x336EDA60","fc":45,"fn":["_standaloneScrimSize","_mainText","_recipientUserIcon","_recipientUserIconBinding","_recipientUserIconText","_recipientNameText","_purchaseSubtitleText","_subscriptionPanel","_subscriptionGroupImage","_subscriptionListingImage","_nonSubscriptionPanel","_thumbnailQuantityText"]},
{"va":"0x3198A9F0","fc":0,"fn":[]},
{"va":"0x336EC030","fc":50,"fn":["subscribeMonthlyButton","subscribeYearlyButton","notYetSupportedOnThisPlatformButton","subscriptionRewards","subscriberBanner","nonSubscriberBanner","introductoryOfferSubscriptionButtons","introductoryOfferCountdownBanner"]},
{"va":"0x33640840","fc":0,"fn":[]},
{"va":"0x30BA84B0","fc":2,"fn":[]},
{"va":"0x33639BE0","fc":8,"fn":["_title","_closeButton","_contentList","_scrollRect","_sortDropdown","_dropdownPersistence"]},
{"va":"0x338F5B40","fc":26,"fn":["_myStuffFoldout","_myStuffOptions","_foldoutTooltip","_worldsMyStuff","_headerText","_cellSizeToggle","_cellSizeToggleIcon","_collapsedCellImage","_expandedCellImage","_cellSizeToggleTooltip","_pinnedHeader"]},
{"va":"0x3395C030","fc":30,"fn":["_searchTypeRelevance","_searchTypeCustom","_sortByLastUpdated","_sortByPopular","_sortByTrust","_sortByLastLoggedIn"]},
{"va":"0x315D3760","fc":7,"fn":["_visibilityButton","_viewUserProfileButton","_removeItemButton","_detailsPanel"]},
{"va":"0x3362A130","fc":7,"fn":["_visibilityButton","_viewUserProfileButton","_removeItemButton","_detailsPanel"]},
{"va":"0x319BC170","fc":0,"fn":[]},
{"va":"0x3474B150","fc":0,"fn":[]},
{"va":"0x340FC990","fc":3,"fn":[]},
{"va":"0x3387E410","fc":0,"fn":[]},
{"va":"0x33466FB0","fc":2,"fn":["icon"]},
{"va":"0x34665F90","fc":0,"fn":[]},
{"va":"0x339D71D0","fc":4,"fn":["_panel","_title","_reportGroupButton"]},
{"va":"0x33BCE5A0","fc":15,"fn":["_productTitleText","_expirationText","_expirationHeader","_addSubscriptionHeader","_updateSubscriptionHeader","_chooseSubscriptionHeader","_addTimeHeader","_subscriptionOptions","_subscriptionOptionsListBinding","_subscriptionPrefab"]},
{"va":"0x333D0ED0","fc":158,"fn":[]},
{"va":"0x33A176A0","fc":9,"fn":["_searchTypeSize","_searchTypeActivity","_searchTypeEngagement","_searchTypeContent"]},
{"va":"0x33C2C710","fc":3,"fn":[]},
{"va":"0x33AADBF0","fc":8,"fn":["_worldInformationPanel","_addToPlaylistHeaderButton","_reportWorldButton","_goToAuthorButton"]},
{"va":"0x33C64030","fc":0,"fn":[]},
{"va":"0x33633470","fc":24,"fn":["_scrollRect","_radioButtonSelectorGroup"]},
{"va":"0x34115040","fc":12,"fn":[]},
{"va":"0x319BEE90","fc":7,"fn":["_selectionBinding"]},
{"va":"0x3374E6B0","fc":8,"fn":["previewStyle","dragHandler","rotator"]},
{"va":"0x33454670","fc":7,"fn":["_monthToView","_calendarMonthPanel","_calendarSideList","_searchButton","_calendarEventsFilterButton","_calendarEventsFilterBadge"]},
{"va":"0x3366E860","fc":5,"fn":["selectionBinding"]},
{"va":"0x335E2460","fc":11,"fn":["_listBinding","_optionPrefab"]},
{"va":"0x33CED4B0","fc":160,"fn":[]},
{"va":"0x33787240","fc":78,"fn":[]},
{"va":"0x3404F100","fc":3,"fn":[]},
{"va":"0x3389C510","fc":0,"fn":[]},
{"va":"0x3404F810","fc":20,"fn":[]},
{"va":"0x339D6AB0","fc":55,"fn":["_modalPanel","_nameText","Image","_thumbnailQuantityText","_bundleBanner","_styleElement","_listingTypeKeyText","_productTypeIconLabel","_subscriptionPanel","_subscriptionExpirationText","_subscriptionRefundabilityArticleId","_listingTypeInfoText"]},
{"va":"0x340DE9C0","fc":1,"fn":[]},
{"va":"0x34831B50","fc":0,"fn":[]},
{"va":"0x3403C6C0","fc":18,"fn":[]},
{"va":"0x338178E0","fc":37,"fn":["_scrollRect","_avatarSidePanel","_avatarListView","_optionalViews","_optionalAvatarsHeader","_optionalAvatarsListView","_searchButton","_currentAvatarButton","_currentAvatarLabel","_buttonGroup","_buttons","_VRCPlusGetMoreAvatars"]},
{"va":"0x33A75550","fc":28,"fn":[]},
{"va":"0x33C9D5D0","fc":23,"fn":["_vrchatStoreTab","_avatarsSpotlightTab","_accessoriesTab","_worldStoresTab","_groupStoresTab","_marketplaceTabSelectorGroup","_vrchatStoreMenu","_avatarsSpotlightMenu","_accessoriesMenu","_worldStoresMenu","_groupStoresMenu","_processingOverlay"]},
{"va":"0x34665A90","fc":0,"fn":[]},
{"va":"0x33C4FAD0","fc":88,"fn":[]},
{"va":"0x334A4BE0","fc":1,"fn":[]},
{"va":"0x333CB3A0","fc":27,"fn":[]},
{"va":"0x333FD0F0","fc":0,"fn":[]},
{"va":"0x31A10520","fc":25,"fn":["colorPickerCanvasGroup","inspectorCanvasGroup","sidebarCanvasGroup","colorPicker","prevButton","nextButton","quantityInfo"]},
{"va":"0x31A29D00","fc":8,"fn":[]},
{"va":"0x3368CFD0","fc":0,"fn":[]},
{"va":"0x33997480","fc":15,"fn":["_profileAvatarImage","_profileIconImage","_defaultUserIcon","_defaultUserIconText","_editProfileImageButtons","_editProfileIconButtons","_profileIconUIContainer","_editIconModalPrefab","_editPictureModalPrefab","_bioField","_addABioPanel","_bioScrollView"]},
{"va":"0x33BE4D60","fc":8,"fn":["_standaloneScrimSize","_listBinding","_productListingPrefab"]},
{"va":"0x3411C030","fc":18,"fn":[]},
{"va":"0x333FCFB0","fc":0,"fn":[]},
{"va":"0x338D5F50","fc":0,"fn":[]},
{"va":"0x33389370","fc":0,"fn":[]},
{"va":"0x335FA520","fc":10,"fn":["_listBinding","_optionPrefab","_grid"]},
{"va":"0x339FF100","fc":34,"fn":["headerText","zoomSlider","mirrorButton","acceptTextureButton","cancelButton","previewImage","textureSelectionCanvasGroup","emojiParticleSystemSelection","saveToDiskButton","fpsSliderParent","fpsSlider","textureConfirmationSectionParent"]},
{"va":"0x33638EF0","fc":1,"fn":["_warningText"]},
{"va":"0x336A4500","fc":0,"fn":[]},
{"va":"0x333D07B0","fc":9,"fn":["_public","_friendsOnly","_private","_clearPlaylist","_editPlaylistInputField"]},
{"va":"0x34981150","fc":22,"fn":[]},
{"va":"0x337BD740","fc":66,"fn":["_listingTitleText","_listingAuthorText","_limitedAvailabilityPanel","_limitedTimeContainer","_limitedTimeText","_limitedQuantityContainer","_limitedQuantityText","_consumableQuantityContainer","_consumableQuantityText","_listingTypePanel","_listingTypeValueText","_purchasedDatePanel"]},
{"va":"0x33CEC1B0","fc":3,"fn":["videoPlayerControls","titleText","target"]},
{"va":"0x339B60C0","fc":0,"fn":[]},
{"va":"0x33BE5860","fc":5,"fn":["closeButton","purchaseTypeSelectionToggles","applyButton","cancelButton"]},
{"va":"0x33A6C1B0","fc":13,"fn":["groupListBinding","groupTogglePrefab","instanceTypeSelectAllButton","instanceTypeDeselectAllButton","selectAllButton","deselectAllButton","closeButton","instanceTypeSelectionToggles","applyButton","cancelButton"]},
{"va":"0x349AABF0","fc":0,"fn":[]},
{"va":"0x33AB4A30","fc":0,"fn":[]},
{"va":"0x340FDF30","fc":0,"fn":[]},
{"va":"0x33A6F910","fc":11,"fn":["_title","_closeButton","_scrollRect","_sectionElements","_dropdownPersistence"]},
{"va":"0x33638350","fc":17,"fn":["_productTitle","_enterPeriodText","_periodText","_costText","_discountText","_periodInputField","_decrementButton","_incrementButton","_submitButton","_cancelButton"]},
{"va":"0x339B6800","fc":10,"fn":["_title","_content","_contentBlockPrefab","_scrollRect","_backToTheTopButton","_sectionLinks","_articleBody"]},
{"va":"0x33E85F70","fc":5,"fn":[]},
{"va":"0x33EF5210","fc":2,"fn":[]},
{"va":"0x33FD7720","fc":15,"fn":[]},
{"va":"0x3343E830","fc":0,"fn":[]},
{"va":"0x339F57E0","fc":24,"fn":["searchFieldButton","searchGroupEventsFieldButton","groupLandingPageButton","groupActivityButton","groupEventsButton","groupExploreButton","groupsLandingPage","groupActivityPage","calendarEventPanel","groupsDiscoveryPanel","groupEventsFilterButton","groupEventsFilterBadge"]},
{"va":"0x33C0EB50","fc":40,"fn":["headerText","friendsButton","invitesButton","friendRequestsButton","reportsMenu","onlineFriendsCount","inviteCount","friendRequestCount","worldCellPrefab","avatarCellPrefab","friendCellPrefab","viewMorePrefab"]},
{"va":"0x33A14F20","fc":19,"fn":["_selectedAvatarPanel","_avatarName","_exploreAvatarsPanel","_avatarCollectionsPanel","_currentAvatarPanel","_tabSelector"]},
{"va":"0x33EE6920","fc":3,"fn":[]},
{"va":"0x3370C710","fc":23,"fn":["_selectedAvatarPanel","_selectedAvatarName","_title","_closeButton","_scrollRect","_avatarDetailsButton","_avatarListView","_filterButton","_breadcrumbIndicator"]},
{"va":"0x33631310","fc":7,"fn":[]},
{"va":"0x33CC46E0","fc":0,"fn":[]},
{"va":"0x33519500","fc":0,"fn":[]},
{"va":"0x33EF5090","fc":3,"fn":[]},
{"va":"0x33CA8030","fc":19,"fn":["applyButton","closeButton","cancelButton","searchButton","_filterTitle","_filterListContainer","_stylesListBinding","_activeStylesListBinding"]},
{"va":"0x33C272E0","fc":14,"fn":["_namePlaylistInputField","_renamePlaylistButton","_clearPlaylistButton","_privacyHeader","_setPrivacyPrivateButton","_setPrivacyFriendsButton","_setPrivacyPublicButton"]},
{"va":"0x33A6E550","fc":0,"fn":[]},
{"va":"0x339B5230","fc":3,"fn":[]},
{"va":"0x340FDC30","fc":1,"fn":[]},
{"va":"0x341DF210","fc":0,"fn":[]},
{"va":"0x33837620","fc":1,"fn":[]},
{"va":"0x340577F0","fc":7,"fn":[]},
{"va":"0x33836F60","fc":31,"fn":["_scrollRect","_status","_statusIcon","search","_buttonGroup","_buttons","_headerText","_cellSizeToggle","_cellSizeToggleIcon","_collapsedCellImage","_expandedCellImage","_groupNameInputField"]},
{"va":"0x33A76F10","fc":21,"fn":[]},
{"va":"0x3404EED0","fc":2,"fn":[]},
{"va":"0x33A1D9E0","fc":18,"fn":["loadingOverlay","closeButton","cancelButton","confirmButton","friendsTab","instancesTab","userCellPrefab","searchUsersButton","userListBinding","userList","defaultUserSearchText","userSearchText"]},
{"va":"0x3370C030","fc":7,"fn":["_subtitle","_closeButton","_showcaseToggle","_hideToggle","_showcaseToggleButton"]},
{"va":"0x33CEEC20","fc":26,"fn":["title","editTitleButton","colorPicker","colorPickerHSV","save","close"]},
{"va":"0x349C3E70","fc":0,"fn":[]},
{"va":"0x31A29AD0","fc":4,"fn":[]},
{"va":"0x33A170D0","fc":0,"fn":[]},
{"va":"0x338D6090","fc":0,"fn":[]},
{"va":"0x34992F40","fc":13,"fn":[]},
{"va":"0x336322A0","fc":39,"fn":["_backButton","_reportButton","_eventTitleText","_eventDateText","_eventImageBinding","_livePill","_categoryPill","_categoryPillText","_instancesButton","_followButton","_groupButton","_shareButton"]},
{"va":"0x3374D540","fc":2,"fn":["_listPanel","_searchButton"]},
{"va":"0x3411DD80","fc":6,"fn":[]},
{"va":"0x33561010","fc":0,"fn":[]},
{"va":"0x335F8030","fc":9,"fn":[]},
{"va":"0x33C2E0B0","fc":2,"fn":["closeButtons"]},
{"va":"0x337858F0","fc":5,"fn":[]},
{"va":"0x33A6F2D0","fc":0,"fn":[]},
{"va":"0x34006560","fc":4,"fn":[]},
{"va":"0x333A99E0","fc":3,"fn":["_buttonFalse","_buttonTrue"]},
{"va":"0x3374F840","fc":35,"fn":["_bundleOpeningPanel","_bundleOpeningImage","_bundleTransform","_bundleClaimedClip","_confettiPanel","_confettiImage","_bundleClaimedCanvas","_bundleName","_bundleContentsTotal","_itemDetailsCell","_scrollContentsRect","_bundleContentsList"]},
{"va":"0x33AEEF20","fc":1,"fn":[]},
{"va":"0x337A4030","fc":13,"fn":["statusListBinding","statusTogglePrefab","statusSelectAllButton","statusDeselectAllButton","availabilitySelectAllButton","availabilityDeselectAllButton","closeButton","availabilitySelectionToggles","statusSelectionToggles","applyButton","cancelButton"]},
{"va":"0x33519C50","fc":26,"fn":["closeButton","moveUpButton","moveDownButton","nameplateToggle","subscribeToNotificationsForGroupButton","subscribeToEventNotificationsForGroupButton","reportGroupButton","leaveGroupButton","roleDisplayObject"]},
{"va":"0x33757930","fc":49,"fn":[]},
{"va":"0x336F5930","fc":5,"fn":["_noRefundAvailable","_detailsInformation","_detailsPanel","_toggleCancelImmediately"]},
{"va":"0x335A0930","fc":2,"fn":["_background"]},
{"va":"0x33A1F6B0","fc":4,"fn":[]},
{"va":"0x33BEE740","fc":4,"fn":["_bottomRow","_label","_buttonsGroup","closeButtons"]},
{"va":"0x3376E320","fc":49,"fn":["shareDirect","dropPrintCanvasGroup","dropPrint","printAsPrint","copyUrlButton","shareAsPedestal","loadingOverlay","closeButton","pageRect","selectShareMethodCanvasGroup","selectShareMethodRect","headerText"]},
{"va":"0x33560E10","fc":26,"fn":["_vrcplayer","_laserSelectRegion"]},
{"va":"0x3408E930","fc":5,"fn":[]},
{"va":"0x31A2B8B0","fc":5,"fn":[]},
{"va":"0x33C4F360","fc":0,"fn":[]},
]

# Keyword-based identification rules
rules = [
    (["credit", "purchase", "bundle"], "CreditPurchasePanel"),
    (["subscribe", "subscription", "subscriberBanner"], "VRCPlusSubscriptionPanel"),
    (["recipient", "gift", "purchaseSubtitle"], "GiftingPanel"),
    (["_productTitle", "_subscriptionOptions", "_addSubscriptionHeader"], "SubscriptionOptionsPanel"),
    (["_searchType", "_sortBy"], "SearchSortFilter"),
    (["_avatarPanel", "_favoriteButton", "_avatarUnavailableBanner"], "AvatarPreviewPanel"),
    (["NoReportsMessage", "TotalReportsText", "_radioButtonSelectorGroup"], "ReportsPanel"),
    (["_calendarMonth", "_calendarSideList", "_calendarEventsFilter"], "CalendarMenu"),
    (["_myStuffFoldout", "_worldsMyStuff", "_cellSizeToggle", "_pinnedHeader"], "WorldsBrowser"),
    (["_worldInformationPanel", "_reportWorldButton", "_goToAuthorButton"], "WorldDetailsPanel"),
    (["_avatarSidePanel", "_avatarListView", "_VRCPlusGetMoreAvatars"], "AvatarSelectionMenu"),
    (["_vrchatStoreTab", "_marketplaceTabSelectorGroup", "_accessoriesTab"], "MarketplaceMenu"),
    (["colorPicker", "inspectorCanvasGroup", "sidebarCanvasGroup", "quantityInfo"], "ItemCustomizer"),
    (["_profileAvatarImage", "_bioField", "_editProfileImageButtons"], "ProfileEditor"),
    (["_productListingPrefab", "_listBinding"], "ProductListingPanel"),
    (["_listBinding", "_optionPrefab", "_grid"], "ListOptionSelector"),
    (["_listBinding", "_optionPrefab"], "ListOptionView"),
    (["zoomSlider", "mirrorButton", "acceptTextureButton", "emojiParticleSystemSelection"], "TextureEditor"),
    (["_public", "_friendsOnly", "_private", "_clearPlaylist", "_editPlaylistInputField"], "PlaylistPrivacySettings"),
    (["_listingTitleText", "_listingAuthorText", "_limitedAvailabilityPanel"], "StoreListingDetails"),
    (["videoPlayerControls", "titleText", "target"], "VideoPlayer"),
    (["purchaseTypeSelectionToggles", "applyButton"], "PurchaseTypeSelector"),
    (["groupListBinding", "instanceTypeSelectAllButton", "instanceTypeSelectionToggles"], "GroupInstanceFilter"),
    (["_title", "_closeButton", "_sectionElements", "_dropdownPersistence"], "SectionListPanel"),
    (["_productTitle", "_periodInputField", "_costText", "_discountText"], "SubscriptionPeriodSelector"),
    (["_articleBody", "_contentBlockPrefab", "_sectionLinks"], "ArticleViewer"),
    (["searchFieldButton", "groupLandingPageButton", "groupActivityButton", "groupExploreButton"], "GroupsMenu"),
    (["friendsButton", "invitesButton", "friendRequestsButton", "onlineFriendsCount"], "SocialMenu"),
    (["_selectedAvatarPanel", "_avatarName", "_exploreAvatarsPanel", "_tabSelector"], "AvatarMenu"),
    (["_selectedAvatarPanel", "_selectedAvatarName", "_avatarDetailsButton", "_avatarListView", "_filterButton"], "AvatarFavoritesMenu"),
    (["_filterTitle", "_filterListContainer", "_stylesListBinding"], "StyleFilterPanel"),
    (["_namePlaylistInputField", "_renamePlaylistButton", "_setPrivacyPrivateButton"], "PlaylistSettingsPanel"),
    (["_status", "_statusIcon", "_groupNameInputField", "_cellSizeToggle"], "GroupBrowser"),
    (["loadingOverlay", "friendsTab", "instancesTab", "userCellPrefab", "searchUsersButton"], "UserInvitePanel"),
    (["_showcaseToggle", "_hideToggle", "_showcaseToggleButton"], "ShowcaseTogglePanel"),
    (["colorPicker", "colorPickerHSV", "editTitleButton", "save"], "ColorPickerEditor"),
    (["_eventTitleText", "_eventDateText", "_livePill", "_instancesButton"], "EventDetailsPanel"),
    (["_bundleOpeningPanel", "_bundleClaimedClip", "_confettiPanel", "_bundleName"], "BundleOpeningPanel"),
    (["statusListBinding", "statusSelectionToggles", "availabilitySelectionToggles"], "StatusFilterPanel"),
    (["moveUpButton", "moveDownButton", "nameplateToggle", "leaveGroupButton", "reportGroupButton"], "GroupOptionsPanel"),
    (["_noRefundAvailable", "_detailsInformation", "_toggleCancelImmediately"], "RefundPanel"),
    (["shareDirect", "dropPrint", "printAsPrint", "copyUrlButton", "shareAsPedestal"], "SharePrintPanel"),
    (["_vrcplayer", "_laserSelectRegion"], "PlayerInteraction"),
    (["_buttonFalse", "_buttonTrue"], "BooleanToggle"),
    (["_bottomRow", "_label", "_buttonsGroup", "closeButtons"], "DialogFooter"),
    (["closeButtons"], "CloseablePanel"),
    (["_titleText", "_backButton", "_shuffleButton"], "PlaylistHeader"),
    (["_visibilityButton", "_viewUserProfileButton", "_removeItemButton"], "ItemCell"),
    (["selectionBinding"], "SelectionBinding"),
    (["_selectionBinding"], "SelectionBindingHost"),
    (["previewStyle", "dragHandler", "rotator"], "AvatarPreviewRotator"),
    (["_modalPanel", "_nameText", "_bundleBanner", "_listingTypeKeyText"], "ProductDetailsModal"),
    (["_listPanel", "_searchButton"], "SearchableListPanel"),
    (["icon"], "IconComponent"),
    (["_panel", "_title", "_reportGroupButton"], "GroupReportPanel"),
    (["_warningText"], "WarningDisplay"),
    (["_background"], "BackgroundComponent"),
    (["_scrollRect", "_radioButtonSelectorGroup"], "RadioButtonList"),
]

# Load dump for current names
with open(BASE_DIR / 'output' / 'deobfuscated_dump.json', 'r', encoding='utf-8') as f:
    dump = json.load(f)

va_to_type = {}
for ns, types in dump['namespaces'].items():
    for t in types:
        va = t.get('va', '').upper()
        if va:
            va_to_type[va] = t

# Apply rules
identified = []
for entry in field_data:
    va = entry['va'].upper()
    fields = [f.lower() for f in entry['fn']]
    if not fields:
        continue

    best_match = None
    best_score = 0
    for keywords, name in rules:
        score = sum(1 for kw in keywords if any(kw.lower() in f for f in fields))
        if score > best_score and score >= min(2, len(keywords)):
            best_score = score
            best_match = name

    if best_match:
        typ = va_to_type.get(va, {})
        current = typ.get('name', '?')
        if 'ComplexComponent' in current:
            identified.append({
                'va': entry['va'],
                'current_name': current,
                'suggested_name': best_match,
                'confidence': 'high' if best_score >= 3 else 'medium',
                'key_fields': entry['fn'][:5],
                'field_count': entry['fc'],
            })

# Print results
print(f"Field-based identification: {len(identified)} classes")
print()
for i in sorted(identified, key=lambda x: x['suggested_name']):
    print(f"  [{i['confidence']:6s}] {i['current_name']:45s} -> {i['suggested_name']}")
    print(f"          fields: {', '.join(i['key_fields'][:4])}")

# Save
output = {
    'generated_by': 'identify_by_fields.py',
    'method': 'Field name keyword matching from runtime MethodInfo scan',
    'identifications': identified,
    'stats': {'total': len(identified), 'high': sum(1 for i in identified if i['confidence']=='high'), 'medium': sum(1 for i in identified if i['confidence']=='medium')},
}
with open(BASE_DIR / 'output' / 'field_based_identifications.json', 'w', encoding='utf-8') as f:
    json.dump(output, f, ensure_ascii=False, indent=2)
print(f"\nSaved to output/field_based_identifications.json")
