// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core
// Classes: 100
// Methods: 1947

namespace VRC.Core
{
    public class API : Object
    {
        public object API_URL;
        public object devApiUrl;
        public object devCeApiUrl;
        public object releaseApiUrl;
        public object _apiStore;
        public object _allowRoaming;
        public object _clientGameServerVersion;
        public object _clientVersion;
        public object _apiOnlineMode;
        public object RESPONSE_CACHE_LIFETIME;
        public object LOG_CATEGORY;
        public object EndpointAccessTimes;
        public object MAX_RETRY_COUNT;
        public object RETRY_DELAY_SECONDS;
        public object Favorites;
        public object _lastRequestId;
        public object _activeRequests;
        public object _offlineQueries;
        public object _isVRCClient;

        // ── Methods ──
        public void get_ClientGameServerVersion(){} // RVA: 0xA4F7580
        public void .cctor(){} // RVA: 0xA4F75E0
        public void RegisterLogging(){} // RVA: 0xA4F7B30
        public void SetClientVersion(){} // RVA: 0xA4F7BE0
        public void GetClientVersion(){} // RVA: 0xA4F7CA0
        public void SetStore(){} // RVA: 0xA4F7D00
        public void GetStore(){} // RVA: 0xA4F7DC0
        public void SetAllowRoaming(){} // RVA: 0xA4F7E20
        public void GetAllowRoaming(){} // RVA: 0xA4F7E80
        public void SetClientGameServerVersion(){} // RVA: 0xA4F7EE0
        public void IsReady(){} // RVA: 0xA4F7F40
        public void FromCacheOrNew(){} // RVA: 0x2D53B80
        public void CreateFromJson(){} // RVA: 0x2D52D90
        public void Fetch(){} // RVA: 0x2D53650
        public void FetchAsync(){} // RVA: 0x2D539F0
        public void DeleteAsync(){} // RVA: 0x87C5C0
        public void Delete(){} // RVA: 0x899D10
        public void get_DeviceID(){} // RVA: 0x6DED910
        public void SetApiUrlFromEnvironment(){} // RVA: 0xA4F7FE0
        public void GetApiUrlForEnvironment(){} // RVA: 0xA4F81E0
        public void SetApiUrl(){} // RVA: 0xA4F8310
        public void GetApiUrl(){} // RVA: 0xA4F83C0
        public void IsDevApi(){} // RVA: 0xA4F8420
        public void IsDevCeApi(){} // RVA: 0xA4F8500
        public void SendGetRequest(){} // RVA: 0xA4F85E0
        public void SendPostRequest(){} // RVA: 0xA4F8700
        public void SendPostFormRequest(){} // RVA: 0xA4F8820
        public void SendPostRawJsonRequest(){} // RVA: 0xA4F8940
        public void SendPutRequest(){} // RVA: 0xA4F8A60
        public void SendDeleteRequest(){} // RVA: 0xA4F8B80
        public void SendRequest(){} // RVA: 0xA4F8CA0
        public void SendRequestInternal(){} // RVA: 0xA4F93D0
        public void AuthenticateHTTPRequest(){} // RVA: 0xA4FA960
        public void AuthenticateUnityWebRequest(){} // RVA: 0xA4FADD0
        public void PopulateHTTPRequestHeaders(){} // RVA: 0xA4FB120
        public void PopulateUnityWebRequestHeaders(){} // RVA: 0xA4FB540
        public void CertVerifyHTTPRequest(){} // RVA: 0xA4FB7D0
        public void CertVerifyUnityWebRequest(){} // RVA: 0xA4FB980
        public void InitializeCertificateVerifier(){} // RVA: 0xA4FBAC0
        public void AppendQuery(){} // RVA: 0xA4FBBF0
        public void ConvertJsonListToModelList(){} // RVA: 0x2D52760
        public void get_IsVRCClient(){} // RVA: 0xA4FBCB0
        public void set_IsVRCClient(){} // RVA: 0xA4FBD10
        public void SetOnlineMode(){} // RVA: 0xA4FBD70
        public void ClearOnlineMode(){} // RVA: 0xA4FC140
        public void IsOffline(){} // RVA: 0xA4FC1F0
        public void GetServerEnvironmentForApiUrl(){} // RVA: 0xA4FC2B0
        public void SendOfflineRequest(){} // RVA: 0xA4FC570
        public void GenerateMergeCode(){} // RVA: 0xA4FCC50
    }

    public class API2FA : ApiModel
    {
        public object _requiresTwoFactorAuth;
        public object _scope;
        public object _ticket;
        public object TIME_BASED_ONE_TIME_PASSWORD_AUTHENTICATION;
        public object EMAIL_BASED_ONE_TIME_PASSWORD_AUTHENTICATION;
        public object ONE_TIME_PASSWORD_AUTHENTICATION;
        public object SMS_AUTHENTICATION;

        // ── Methods ──
        public void get_requiresTwoFactorAuth(){} // RVA: 0xBBFF90
        public void set_requiresTwoFactorAuth(){} // RVA: 0xBBFFA0
        public void get_scope(){} // RVA: 0xC10050
        public void set_scope(){} // RVA: 0xC10060
        public void get_ticket(){} // RVA: 0xCD3320
        public void set_ticket(){} // RVA: 0xCD4740
        public void TimeBasedOneTimePasswordSupported(){} // RVA: 0xA4FD890
        public void EmailBasedOneTimePasswordSupported(){} // RVA: 0xA4FD8F0
        public void OneTimePasswordSupported(){} // RVA: 0xA4FD950
        public void SmsSupported(){} // RVA: 0xA4FD9B0
        public void ToString(){} // RVA: 0xA4FDA10
        public void .ctor(){} // RVA: 0xA4FDC20
    }

    public class APICalendarEntry[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class APIGiftBundle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class APIGroupInvite[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class APIGroupMember[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class APIQueue : Object
    {
        public object queueInstance;

        // ── Methods ──
        public void JoinQueue(){} // RVA: 0xA571A30
        public void SetQueue(){} // RVA: 0xB44D60
        public void LeaveQueue(){} // RVA: 0xA571EB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class APIUIColorPalette : ApiModel
    {
        public object _ownerId;
        public object _name;
        public object _highlights;
        public object _icons;
        public object _buttons;
        public object _backgrounds;
        public object _text;
        public object _subtext;
        public object endpoint;
        public object endpoint_current;
        public object _fakeApi;

        // ── Methods ──
        public void get_ownerId(){} // RVA: 0xBBFF90
        public void set_ownerId(){} // RVA: 0xBBFFA0
        public void get_name(){} // RVA: 0xC10050
        public void set_name(){} // RVA: 0xC10060
        public void get_highlights(){} // RVA: 0xCD3320
        public void set_highlights(){} // RVA: 0xCD4740
        public void get_icons(){} // RVA: 0xCD48B0
        public void set_icons(){} // RVA: 0xCD3600
        public void get_buttons(){} // RVA: 0xB813B0
        public void set_buttons(){} // RVA: 0xD5CBB0
        public void get_backgrounds(){} // RVA: 0x1069350
        public void set_backgrounds(){} // RVA: 0xD5CC10
        public void get_text(){} // RVA: 0x106A7D0
        public void set_text(){} // RVA: 0xD5CC70
        public void get_subtext(){} // RVA: 0x106A050
        public void set_subtext(){} // RVA: 0xD5CCD0
        public void Fetch(){} // RVA: 0xA57CD10
        public void Save(){} // RVA: 0xA57D0C0
        public void GetCurrent(){} // RVA: 0xA57D9B0
        public void SetCurrent(){} // RVA: 0xA57DC90
        public void Update(){} // RVA: 0xA57E090
        public void .ctor(){} // RVA: 0xA57E3D0
        public void .cctor(){} // RVA: 0xA57E420
    }

    public class APIUser : ApiModel
    {
        public object SINGLE_RECORD_CACHE_TIME;
        public object SEARCH_CACHE_TIME;
        public object MAX_STATUS_DESCRIPTION_LENGTH;
        public object MAX_BIO_TEXT_LENGTH;
        public object STATUS_ONLINE_API_STRING;
        public object STATUS_JOIN_ME_API_STRING;
        public object STATUS_ASK_ME_API_STRING;
        public object STATUS_OFFLINE_API_STRING;
        public object STATUS_DO_NOT_DISTURB_API_STRING;
        public object STATUS_ONLINE_DEFAULT_DISPLAY_STRING;
        public object STATUS_JOIN_DEFAULT_ME_DISPLAY_STRING;
        public object STATUS_ASK_ME_DEFAULT_DISPLAY_STRING;
        public object STATUS_OFFLINE_DEFAULT_DISPLAY_STRING;
        public object STATUS_DO_NOT_DISTURB_DEFAULT_DISPLAY_STRING;
        public object _blob;
        public object _displayName;
        public object _username;
        public object _pronouns;
        public object _bio;
        public object _bioLinks;
        public object _location;
        public object _avatarId;
        public object _fallbackId;
        public object _hasEmail;
        public object _isBoopingEnabled;
        public object _hasBirthday;
        public object _isFriend;
        public object _friendKey;
        public object _friendRequestStatus;
        public object _last_login;
        public object _last_activity;
        public object _date_joined;
        public object _developerType;
        public object _events;
        public object _acceptedTOSVersion;
        public object _queuedInstance;
        public object _queuedInstancePosition;
        public object _acceptedPrivacyVersion;
        public object _currentAvatarImageUrl;
        public object _currentAvatarThumbnailImageUrl;
        public object _currentAvatarTags;
        public object _authToken;
        public object _emailVerified;
        public object _hasPendingEmail;
        public object _obfuscatedPendingEmail;
        public object _friendIDs;
        public object _currentAvatarAssetUrl;
        public object _steamDetails;
        public object _travelingToLocation;
        public object _obfuscatedEmail;
        public object _unsubscribe;
        public object _hasLoggedInFromClient;
        public object _pastDisplayNames;
        public object _homeLocation;
        public object _tags;
        public object _status;
        public object _statusDescription;
        public object _badges;
        public object _statusHistory;
        public object _state;
        public object _allowAvatarCopying;
        public object _hasSharedConnectionsOptOut;
        public object _hasDiscordFriendsOptOut;
        public object _userIcon;
        public object _profilePicOverride;
        public object _note;
        public object _iconUrl;
        public object _thumbnailUrl;
        public object _hideContentFilterSettings;
        public object _contentFilters;
        public object _userLanguageCode;
        public object _ageVerified;
        public object _isAdult;
        public object _ageVerificationStatus;
        public object _discordId;
        public object _hasAcceptedDiscordSocialSDKPerms;
        public object _completedTutorials;
        public object _last_platform;
        public object _platform;
        public object _last_mobile;
        public object _twoFactorAuthEnabled;
        public object _twoFactorAuthMethods;
        public object _languageTagsDictionary;
        public object _languagesDisplayNames;
        public object _languagesShortNames;
        public object statusDefaultDescriptions;
        public object _currentUser;

        // ── Methods ──
        public void ShouldCache(){} // RVA: 0xA57E710
        public void GetLifeSpan(){} // RVA: 0x1BFEAE0
        public void get_blob(){} // RVA: 0xBBFF90
        public void set_blob(){} // RVA: 0xBBFFA0
        public void get_displayName(){} // RVA: 0xC10050
        public void set_displayName(){} // RVA: 0xC10060
        public void get_username(){} // RVA: 0xCD3320
        public void set_username(){} // RVA: 0xCD4740
        public void get_pronouns(){} // RVA: 0xCD48B0
        public void set_pronouns(){} // RVA: 0xCD3600
        public void get_bio(){} // RVA: 0xB813B0
        public void set_bio(){} // RVA: 0xD5CBB0
        public void get_bioLinks(){} // RVA: 0x1069350
        public void set_bioLinks(){} // RVA: 0xD5CC10
        public void get_location(){} // RVA: 0x106A7D0
        public void set_location(){} // RVA: 0xD5CC70
        public void get_avatarId(){} // RVA: 0x106A050
        public void set_avatarId(){} // RVA: 0xD5CCD0
        public void get_fallbackId(){} // RVA: 0x12EB090
        public void set_fallbackId(){} // RVA: 0x13B1040
        public void get_hasEmail(){} // RVA: 0x2009180
        public void set_hasEmail(){} // RVA: 0x20097F0
        public void get_isBoopingEnabled(){} // RVA: 0x6A8AF80
        public void set_isBoopingEnabled(){} // RVA: 0x6A8AF90
        public void get_hasBirthday(){} // RVA: 0x6C1B1C0
        public void set_hasBirthday(){} // RVA: 0x6C1B1D0
        public void get_isFriend(){} // RVA: 0x6C1B1E0
        public void set_isFriend(){} // RVA: 0x6C1B1F0
        public void get_friendKey(){} // RVA: 0xBAE3B0
        public void set_friendKey(){} // RVA: 0xBAE3C0
        public void get_friendRequestStatus(){} // RVA: 0xBAE420
        public void set_friendRequestStatus(){} // RVA: 0xBAE430
        public void get_last_login(){} // RVA: 0xCA4D80
        public void set_last_login(){} // RVA: 0xCA4D90
        public void get_last_activity(){} // RVA: 0xC68EB0
        public void set_last_activity(){} // RVA: 0xC68EC0
        public void get_date_joined(){} // RVA: 0x135D730
        public void set_date_joined(){} // RVA: 0xBC5AD0
        public void get_developerType(){} // RVA: 0x25C0CD0
        public void set_developerType(){} // RVA: 0x25C0CE0
        public void get_events(){} // RVA: 0xBC5BA0
        public void set_events(){} // RVA: 0xBC5BB0
        public void get_acceptedTOSVersion(){} // RVA: 0x255B930
        public void set_acceptedTOSVersion(){} // RVA: 0x6CE7A80
        public void get_queuedInstance(){} // RVA: 0x135A7B0
        public void set_queuedInstance(){} // RVA: 0xEC0BB0
        public void get_queuedInstancePosition(){} // RVA: 0x2643A30
        public void set_queuedInstancePosition(){} // RVA: 0x2644F00
        public void get_acceptedPrivacyVersion(){} // RVA: 0x2531210
        public void set_acceptedPrivacyVersion(){} // RVA: 0x232C690
        public void get_currentAvatarImageUrl(){} // RVA: 0x10B9D50
        public void set_currentAvatarImageUrl(){} // RVA: 0x15B7570
        public void get_currentAvatarThumbnailImageUrl(){} // RVA: 0xD9E3D0
        public void set_currentAvatarThumbnailImageUrl(){} // RVA: 0xD9D290
        public void get_currentAvatarTags(){} // RVA: 0xDA0520
        public void set_currentAvatarTags(){} // RVA: 0xD9D570
        public void get_authToken(){} // RVA: 0x114AC20
        public void set_authToken(){} // RVA: 0x1149C90
        public void get_emailVerified(){} // RVA: 0x186B250
        public void set_emailVerified(){} // RVA: 0x1868AE0
        public void get_hasPendingEmail(){} // RVA: 0xA57E770
        public void set_hasPendingEmail(){} // RVA: 0xA57E780
        public void get_obfuscatedPendingEmail(){} // RVA: 0x135EDB0
        public void set_obfuscatedPendingEmail(){} // RVA: 0x1658000
        public void get_friendIDs(){} // RVA: 0x135A170
        public void set_friendIDs(){} // RVA: 0x1365A40
        public void get_currentAvatarAssetUrl(){} // RVA: 0xBAE8F0
        public void set_currentAvatarAssetUrl(){} // RVA: 0xBAE900
        public void get_steamDetails(){} // RVA: 0xBAE960
        public void set_steamDetails(){} // RVA: 0xBAE970
        public void get_travelingToLocation(){} // RVA: 0x12CDBF0
        public void set_travelingToLocation(){} // RVA: 0x164A230
        public void get_obfuscatedEmail(){} // RVA: 0x1661250
        public void set_obfuscatedEmail(){} // RVA: 0x166A5F0
        public void get_unsubscribe(){} // RVA: 0x6CE7E10
        public void set_unsubscribe(){} // RVA: 0x6CE7E20
        public void get_hasLoggedInFromClient(){} // RVA: 0x1B5A240
        public void set_hasLoggedInFromClient(){} // RVA: 0x1B52910
        public void get_pastDisplayNames(){} // RVA: 0x164B8E0
        public void set_pastDisplayNames(){} // RVA: 0x16601C0
        public void get_homeLocation(){} // RVA: 0x10F9C30
        public void set_homeLocation(){} // RVA: 0x1659C50
        public void get_tags(){} // RVA: 0x10F9390
        public void set_tags(){} // RVA: 0xA57E790
        public void get_status(){} // RVA: 0x165EBC0
        public void set_status(){} // RVA: 0x1651590
        public void get_statusDescription(){} // RVA: 0x1667D40
        public void set_statusDescription(){} // RVA: 0x1669D30
        public void get_badges(){} // RVA: 0x13659D0
        public void set_badges(){} // RVA: 0x166D270
        public void get_statusHistory(){} // RVA: 0x135C160
        public void set_statusHistory(){} // RVA: 0x16614A0
        public void get_state(){} // RVA: 0x1664460
        public void set_state(){} // RVA: 0x16679E0
        public void get_allowAvatarCopying(){} // RVA: 0x6F3ED50
        public void set_allowAvatarCopying(){} // RVA: 0x6F3ED60
        public void get_hasSharedConnectionsOptOut(){} // RVA: 0x6F3ED70
        public void set_hasSharedConnectionsOptOut(){} // RVA: 0x6F3ED80
        public void get_hasDiscordFriendsOptOut(){} // RVA: 0x6F3EDD0
        public void set_hasDiscordFriendsOptOut(){} // RVA: 0x6F3EDE0
        public void get_userIcon(){} // RVA: 0x165E8F0
        public void set_userIcon(){} // RVA: 0x165C4D0
        public void get_profilePicOverride(){} // RVA: 0x1659CB0
        public void set_profilePicOverride(){} // RVA: 0x163A980
        public void get_note(){} // RVA: 0x1344890
        public void set_note(){} // RVA: 0x1662780
        public void get_iconUrl(){} // RVA: 0x1655DD0
        public void set_iconUrl(){} // RVA: 0x16694D0
        public void get_thumbnailUrl(){} // RVA: 0x1654670
        public void set_thumbnailUrl(){} // RVA: 0x16612E0
        public void get_hideContentFilterSettings(){} // RVA: 0x80D00A0
        public void set_hideContentFilterSettings(){} // RVA: 0xA57E800
        public void get_contentFilters(){} // RVA: 0x1184410
        public void set_contentFilters(){} // RVA: 0x163ACA0
        public void get_userLanguageCode(){} // RVA: 0x164FF50
        public void set_userLanguageCode(){} // RVA: 0x16529A0
        public void get_ageVerified(){} // RVA: 0x2548D20
        public void set_ageVerified(){} // RVA: 0x2548D30
        public void get_isAdult(){} // RVA: 0x1B900A0
        public void set_isAdult(){} // RVA: 0x2548CF0
        public void get_ageVerificationStatus(){} // RVA: 0x136ECA0
        public void set_ageVerificationStatus(){} // RVA: 0x164C9D0
        public void get_discordId(){} // RVA: 0x165F4F0
        public void set_discordId(){} // RVA: 0x164A160
        public void get_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0x6F1A120
        public void set_hasAcceptedDiscordSocialSDKPerms(){} // RVA: 0xA57E810
        public void get_completedTutorials(){} // RVA: 0x1640C90
        public void set_completedTutorials(){} // RVA: 0x1668690
        public void get_last_platform(){} // RVA: 0x165F950
        public void set_last_platform(){} // RVA: 0xA57E820
        public void get_platform(){} // RVA: 0x1667A40
        public void set_platform(){} // RVA: 0x163A9E0
        public void get_last_mobile(){} // RVA: 0x165A670
        public void set_last_mobile(){} // RVA: 0x1661A80
        public void get_twoFactorAuthEnabled(){} // RVA: 0x6CCAFC0
        public void set_twoFactorAuthEnabled(){} // RVA: 0x6CCAFD0
        public void get_twoFactorAuthMethods(){} // RVA: 0x163F650
        public void set_twoFactorAuthMethods(){} // RVA: 0x1656720
        public void get_LanguageTagsDictionary(){} // RVA: 0xA57E9A0
        public void get_languagesDisplayNames(){} // RVA: 0x164AA90
        public void set_languagesDisplayNames(){} // RVA: 0x164B2D0
        public void set_LanguagesShortNames(){} // RVA: 0x164E760
        public void get_LanguagesShortNames(){} // RVA: 0x165DF30
        public void SetUserLanguages(){} // RVA: 0xA57EE30
        public void get_ShouldSeeInstanceByStatus(){} // RVA: 0xA57F1D0
        public void get_IsOnMobile(){} // RVA: 0xA57F210
        public void get_profilePicImageUrl(){} // RVA: 0xA57F230
        public void get_profilePicThumbnailImageUrl(){} // RVA: 0xA57F250
        public void FetchBalance(){} // RVA: 0xA57F270
        public void get_IsAccountVerified(){} // RVA: 0xC2E4C0
        public void get_hasNoPowers(){} // RVA: 0xA57F610
        public void get_hasScriptingAccess(){} // RVA: 0xA57F660
        public void get_hasModerationPowers(){} // RVA: 0xA57F760
        public void get_hasVIPAccess(){} // RVA: 0xA57F820
        public void get_hasSuperPowers(){} // RVA: 0xA57F870
        public void get_canPublishWorldsAndAvatars(){} // RVA: 0xA57F8C0
        public void get_canPublishAllContent(){} // RVA: 0xA57FAE0
        public void get_canPublishAvatars(){} // RVA: 0xA57FC10
        public void get_canPublishWorlds(){} // RVA: 0xA57FD30
        public void get_canPublishProps(){} // RVA: 0xA57FE50
        public void get_isUntrusted(){} // RVA: 0xA57FF70
        public void get_isNewUser(){} // RVA: 0xA57FFD0
        public void get_isEarlyAdopter(){} // RVA: 0xA580090
        public void get_isSupporter(){} // RVA: 0xA580150
        public void get_isCreator(){} // RVA: 0xA580210
        public void get_hasBasicTrustLevel(){} // RVA: 0xA5802D0
        public void get_hasKnownTrustLevel(){} // RVA: 0xA5803A0
        public void get_hasTrustedTrustLevel(){} // RVA: 0xA580470
        public void get_hasVeteranTrustLevel(){} // RVA: 0xA580540
        public void get_hasLegendTrustLevel(){} // RVA: 0xA580680
        public void get_hasNegativeTrustLevel(){} // RVA: 0xA580750
        public void get_hasVeryNegativeTrustLevel(){} // RVA: 0xA580820
        public void get_hasFeedbackAccess(){} // RVA: 0xA5808E0
        public void get_showSocialRank(){} // RVA: 0xA5809A0
        public void get_showModTag(){} // RVA: 0xA580A40
        public void get_canSetStatusOffline(){} // RVA: 0xA580AE0
        public void get_statusIsSetToOffline(){} // RVA: 0xA580B40
        public void get_statusIsSetToJoinMe(){} // RVA: 0xA580C70
        public void get_statusIsSetToAskMe(){} // RVA: 0xA580D10
        public void get_statusIsSetToDoNotDisturb(){} // RVA: 0xA580E40
        public void get_statusDefaultDescriptionDisplayString(){} // RVA: 0xA580F70
        public void truncatedBio(){} // RVA: 0xA5810F0
        public void truncatedStatusDescription(){} // RVA: 0xA5811D0
        public void get_statusDescriptionDisplayString(){} // RVA: 0xA5812A0
        public void get_statusValue(){} // RVA: 0xA581320
        public void get_CurrentLocation(){} // RVA: 0xA581390
        public void get_canSeeAllUsersStatus(){} // RVA: 0xA581730
        public void MergeFieldsInto(){} // RVA: 0xA581790
        public void get_IsLoggedIn(){} // RVA: 0xA582010
        public void get_IsSelf(){} // RVA: 0xA5820A0
        public void get_CurrentUser(){} // RVA: 0xA5821F0
        public void set_CurrentUser(){} // RVA: 0xA582250
        public void .ctor(){} // RVA: 0xA5825F0
        public void ReadField(){} // RVA: 0xA583480
        public void WriteField(){} // RVA: 0xA583530
        public void InitialFetchCurrentUser(){} // RVA: 0xA5836C0
        public void Register(){} // RVA: 0xA583AE0
        public void UpdateAccountInfo(){} // RVA: 0xA584510
        public void Login(){} // RVA: 0xA584FE0
        public void VerifyTwoFactorAuthCode(){} // RVA: 0xA5854D0
        public void VerifyStepUpAuthCode(){} // RVA: 0xA585AC0
        public void ThirdPartyLogin(){} // RVA: 0xA586640
        public void DiscordLogin(){} // RVA: 0xA586A50
        public void DiscordFinalizeLogin(){} // RVA: 0xA587030
        public void DiscordLinkStatus(){} // RVA: 0xA587B20
        public void DiscordUnlink(){} // RVA: 0xA588010
        public void GoogleLogin(){} // RVA: 0xA588350
        public void GoogleFinalizeLogin(){} // RVA: 0xA588A70
        public void GoogleLinkStatus(){} // RVA: 0xA589420
        public void GoogleLink(){} // RVA: 0xA589A30
        public void GoogleUnlink(){} // RVA: 0xA58A090
        public void DiscordAccess(){} // RVA: 0xA58A3B0
        public void RedeemPromo(){} // RVA: 0xA58A6F0
        public void Logout(){} // RVA: 0xA58AAE0
        public void FetchPublishWorldsInformation(){} // RVA: 0xA58AC30
        public void FetchUsers(){} // RVA: 0xA58B960
        public void FetchUser(){} // RVA: 0xA58B5F0
        public void FetchUsersSearchResults(){} // RVA: 0xA58BD40
        public void FetchFriends(){} // RVA: 0xA58C150
        public void AttemptVerification(){} // RVA: 0xA58CBC0
        public void TagsToDeveloperType(){} // RVA: 0xA58CC80
        public void SetIsBoopingEnabled(){} // RVA: 0xA58CCF0
        public void AddLanguage(){} // RVA: 0xA58D160
        public void RemoveLanguage(){} // RVA: 0xA58D730
        public void AddLink(){} // RVA: 0xA58DCC0
        public void ModifyLink(){} // RVA: 0xA58E210
        public void UpdateBio(){} // RVA: 0xA58E6D0
        public void UpdateContentFilters(){} // RVA: 0xA58ECC0
        public void UpdateUserLanguageCode(){} // RVA: 0xA58F0E0
        public void AddNewStatusToHistory(){} // RVA: 0xA58F6C0
        public void StatusValueToString(){} // RVA: 0xA58F8A0
        public void StringToStatusValue(){} // RVA: 0xA58FA00
        public void UnfriendUser(){} // RVA: 0xA58FC80
        public void LocalAddFriend(){} // RVA: 0xA5900B0
        public void IsFriendsWith(){} // RVA: 0xA590300
        public void get_HasRequestedToBeFriend(){} // RVA: 0xA590540
        public void set_HasRequestedToBeFriend(){} // RVA: 0xA5905C0
        public void get_HasFriendRequestPending(){} // RVA: 0xA590660
        public void set_HasFriendRequestPending(){} // RVA: 0xA5906E0
        public void SetAvatarPropertiesFromModel(){} // RVA: 0xA590780
        public void SetAvatarFallbackPropertiesFromModel(){} // RVA: 0xA5909E0
        public void Exists(){} // RVA: 0xA590AD0
        public void HasTag(){} // RVA: 0xA590B10
        public void AddTag(){} // RVA: 0xA590B80
        public void RemoveTag(){} // RVA: 0xA590C20
        public void Equals(){} // RVA: 0xA590D70
        public void UpdateNote(){} // RVA: 0xA590E20
        public void SetUserInterests(){} // RVA: 0xA5914E0
        public void GetUserInterests(){} // RVA: 0xA5917C0
        public void CheckIfPersistenceDataExistsForWorld(){} // RVA: 0xA591AD0
        public void ResetPersistenceDataForWorld(){} // RVA: 0xA591E80
        public void ResetAllPersistenceDataForWorlds(){} // RVA: 0xA592220
        public void UpdateBadge(){} // RVA: 0xA592570
        public void ToString(){} // RVA: 0xA592DD0
        public void .cctor(){} // RVA: 0xA593110
    }

    public class APIUser[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiAccountUpgrade : ApiModel
    {
        public object _isUpgrading;
        public object _subscribedToMarketingEmails;
        public object _hasEmail;
        public object _emailVerified;

        // ── Methods ──
        public void get_isUpgrading(){} // RVA: 0xC10030
        public void set_isUpgrading(){} // RVA: 0xC10040
        public void get_subscribedToMarketingEmails(){} // RVA: 0x6296240
        public void set_subscribedToMarketingEmails(){} // RVA: 0x6296250
        public void get_hasEmail(){} // RVA: 0x6573C70
        public void set_hasEmail(){} // RVA: 0x6573C80
        public void get_emailVerified(){} // RVA: 0x752DCA0
        public void set_emailVerified(){} // RVA: 0x752DCB0
        public void .ctor(){} // RVA: 0xA4FDC70
        public void GetUpgradeStatus(){} // RVA: 0xA4FDD30
        public void UpgradeWithEmail(){} // RVA: 0xA4FE050
        public void ParseErrorCode(){} // RVA: 0xA4FE5A0
    }

    public class ApiAdminAssetBundle : ApiModel
    {
        public object _name;
        public object _description;
        public object _imageUrl;
        public object _tags;
        public object _assetVersion;
        public object _unityPackages;

        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_description(){} // RVA: 0xC10050
        public void set_description(){} // RVA: 0xC10060
        public void get_imageUrl(){} // RVA: 0xCD3320
        public void set_imageUrl(){} // RVA: 0xCD4740
        public void get_tags(){} // RVA: 0xCD48B0
        public void set_tags(){} // RVA: 0xCD3600
        public void get_assetVersion(){} // RVA: 0x14780B0
        public void set_assetVersion(){} // RVA: 0x147EE80
        public void get_unityPackages(){} // RVA: 0x1069350
        public void set_unityPackages(){} // RVA: 0xD5CC10
        public void GetPlatformString(){} // RVA: 0xA4FEC10
        public void GetBundleLink(){} // RVA: 0xA4FEDA0
        public void CreateAdminAssetBundle(){} // RVA: 0xA4FF060
        public void AddPackageToBundle(){} // RVA: 0xA4FF9A0
        public void GetAdminAssetBundle(){} // RVA: 0xA5001A0
        public void GetAllAdminAssetBundles(){} // RVA: 0xA5004D0
        public void RequestDeleteBundle(){} // RVA: 0xA500C90
        public void SendPropertyUpdate(){} // RVA: 0xA500FB0
        public void .ctor(){} // RVA: 0xA5017C0
    }

    public class ApiAdminAssetBundleFile : ApiModel
    {
        public object _assetUrl;
        public object _unityVersion;
        public object _platform;
        public object _assetVersion;

        // ── Methods ──
        public void get_assetUrl(){} // RVA: 0xBBFF90
        public void set_assetUrl(){} // RVA: 0xBBFFA0
        public void get_unityVersion(){} // RVA: 0xC10050
        public void set_unityVersion(){} // RVA: 0xC10060
        public void get_platform(){} // RVA: 0xCD3320
        public void set_platform(){} // RVA: 0xCD4740
        public void get_assetVersion(){} // RVA: 0xD34760
        public void set_assetVersion(){} // RVA: 0xD34750
        public void GetCacheId(){} // RVA: 0xA501B70
        public void .ctor(){} // RVA: 0xA501CF0
    }

    public class ApiAdminAssetBundleFile[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiAuthContinue : ApiModel
    {
        public object _continueToken;
        public object _requestedFields;
        public object _reservedName;

        // ── Methods ──
        public void get_continueToken(){} // RVA: 0xBBFF90
        public void set_continueToken(){} // RVA: 0xBBFFA0
        public void get_requestedFields(){} // RVA: 0xC10050
        public void set_requestedFields(){} // RVA: 0xC10060
        public void get_reservedName(){} // RVA: 0xCD3320
        public void set_reservedName(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA501D40
    }

    public class ApiAvatar : ApiContentModel`1
    {
        public object performanceRatings;
        public object _impostorUrl;
        public object _variant;
        public object _impostorUnityVersion;
        public object _unityPackages;
        public object _created_at;
        public object _updated_at;
        public object _attribution;
        public object _offlineAnalysisScanStatus;
        public object _performanceRating;
        public object _styles;
        public object _productId;
        public object _publishedListings;
        public object _lowestPrice;
        public object _highestPrice;
        public object _acknowledgements;
        public object _loadError;
        public object AvatarsEndpoint;

        // ── Methods ──
        public void get_impostorUrl(){} // RVA: 0xBC5B30
        public void set_impostorUrl(){} // RVA: 0xBC5B40
        public void get_variant(){} // RVA: 0x485FD30
        public void set_variant(){} // RVA: 0x485FD40
        public void get_impostorUnityVersion(){} // RVA: 0xBAE5A0
        public void set_impostorUnityVersion(){} // RVA: 0xBAE5B0
        public void get_unityPackages(){} // RVA: 0x135A7B0
        public void set_unityPackages(){} // RVA: 0xEC0BB0
        public void get_created_at(){} // RVA: 0x10B4170
        public void set_created_at(){} // RVA: 0x1FDB9B0
        public void get_updated_at(){} // RVA: 0x10B9D50
        public void set_updated_at(){} // RVA: 0xD9D280
        public void get_attribution(){} // RVA: 0xD9E3D0
        public void set_attribution(){} // RVA: 0xD9D290
        public void get_offlineAnalysisScanStatus(){} // RVA: 0x1AE6530
        public void set_offlineAnalysisScanStatus(){} // RVA: 0x1CA09C0
        public void get_performanceRating(){} // RVA: 0x114AC20
        public void set_performanceRating(){} // RVA: 0x1149C90
        public void get_styles(){} // RVA: 0xE3C930
        public void set_styles(){} // RVA: 0xE3D020
        public void get_productId(){} // RVA: 0x135EDB0
        public void set_productId(){} // RVA: 0x1658000
        public void get_publishedListings(){} // RVA: 0x135A170
        public void set_publishedListings(){} // RVA: 0x1365A40
        public void get_lowestPrice(){} // RVA: 0xBAE8F0
        public void set_lowestPrice(){} // RVA: 0x6E15240
        public void get_highestPrice(){} // RVA: 0xBAE960
        public void set_highestPrice(){} // RVA: 0x6D09B50
        public void get_acknowledgements(){} // RVA: 0x12CDBF0
        public void set_acknowledgements(){} // RVA: 0x164A230
        public void get_LoadError(){} // RVA: 0x1661250
        public void set_LoadError(){} // RVA: 0x166A5F0
        public void .ctor(){} // RVA: 0xA501DE0
        public void Get(){} // RVA: 0xA501F00
        public void AssignToThisUser(){} // RVA: 0xA5020A0
        public void AssignToThisUserAsFallback(){} // RVA: 0xA502520
        public void GetPerformanceRatingForPlatform(){} // RVA: 0xA5029B0
        public void GetAssetUrl(){} // RVA: 0xA502A30
        public void SetApiFieldsFromJson(){} // RVA: 0xA502BD0
        public void ProcessUnityPackages(){} // RVA: 0xA502D10
        public void WriteField(){} // RVA: 0xA503C60
        public void CopyDeserializedValuesTo(){} // RVA: 0xA503C90
    }

    public class ApiAvatarLook : ApiModel
    {
        public object _avatarId;
        public object _attachments;
        public object LooksEndpoint;

        // ── Methods ──
        public void get_avatarId(){} // RVA: 0xBBFF90
        public void set_avatarId(){} // RVA: 0xBBFFA0
        public void get_attachments(){} // RVA: 0xC10050
        public void set_attachments(){} // RVA: 0xC10060
        public void GetLook(){} // RVA: 0xA504540
        public void UpdateThumbnail(){} // RVA: 0xA5046E0
        public void UpdateLook(){} // RVA: 0xA504830
        public void CreateLook(){} // RVA: 0xA504980
        public void WearLook(){} // RVA: 0xA504B20
        public void UploadThumbnail(){} // RVA: 0xA504E70
        public void .ctor(){} // RVA: 0xA505010
    }

    public class ApiAvatarModeration : ApiModel
    {
        public object ListCacheTime;
        public object _moderationType;
        public object _targetAvatarId;

        // ── Methods ──
        public void get_moderationType(){} // RVA: 0x2536460
        public void set_moderationType(){} // RVA: 0x25406E0
        public void get_targetAvatarId(){} // RVA: 0xC10050
        public void set_targetAvatarId(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA508AF0
        public void ShouldCache(){} // RVA: 0xB43320
        public void ReadField(){} // RVA: 0xA508BB0
        public void WriteField(){} // RVA: 0xA508F30
        public void SendModeration(){} // RVA: 0xA509110
        public void DeleteModeration(){} // RVA: 0xA509350
        public void FetchAllMine(){} // RVA: 0xA509870
        public void FetchList(){} // RVA: 0xA5098D0
        public void ModerationTypeToAPIString(){} // RVA: 0xA509BC0
    }

    public class ApiAvatarModeration[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiAvatarPart[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiAvatarStyle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiAvatar[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiBadge : ApiModel
    {
        public object _badgeId;
        public object _showcased;
        public object _badgeName;
        public object _badgeDescription;
        public object _badgeImageUrl;
        public object _hidden;
        public object _assignedAt;
        public object _updatedAt;
        public object _assignedBy;
        public object _isQuantifiable;
        public object _quantity;

        // ── Methods ──
        public void get_badgeId(){} // RVA: 0xBBFF90
        public void set_badgeId(){} // RVA: 0xBBFFA0
        public void get_showcased(){} // RVA: 0xBC03E0
        public void set_showcased(){} // RVA: 0xBC03F0
        public void get_badgeName(){} // RVA: 0xCD3320
        public void set_badgeName(){} // RVA: 0xCD4740
        public void get_badgeDescription(){} // RVA: 0xCD48B0
        public void set_badgeDescription(){} // RVA: 0xCD3600
        public void get_badgeImageUrl(){} // RVA: 0xB813B0
        public void set_badgeImageUrl(){} // RVA: 0xD5CBB0
        public void get_hidden(){} // RVA: 0x1C4D9A0
        public void set_hidden(){} // RVA: 0x1C4DB10
        public void get_assignedAt(){} // RVA: 0x106A7D0
        public void set_assignedAt(){} // RVA: 0x6A6A800
        public void get_updatedAt(){} // RVA: 0x106A050
        public void set_updatedAt(){} // RVA: 0x6A6A810
        public void get_assignedBy(){} // RVA: 0x12EB090
        public void set_assignedBy(){} // RVA: 0x13B1040
        public void get_isQuantifiable(){} // RVA: 0x2009180
        public void set_isQuantifiable(){} // RVA: 0x20097F0
        public void get_quantity(){} // RVA: 0x68504F0
        public void set_quantity(){} // RVA: 0x798F510
        public void .ctor(){} // RVA: 0xA50BAE0
    }

    public class ApiBadge[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiCache : Object
    {
        public object TimeProvider;
        public object cache;
        public object expiryQueue;
        public object CleanupDelay;

        // ── Methods ──
        public void Fetch(){} // RVA: 0x2D72800
        public void DefaultTimeProvider(){} // RVA: 0xA50BCB0
        public void get_Count(){} // RVA: 0xA50BD60
        public void get_NextExpiryTTL(){} // RVA: 0xA50BF10
        public void Save(){} // RVA: 0xA50C1D0
        public void Invalidate(){} // RVA: 0xA50C620
        public void CleanupTask(){} // RVA: 0xA50C8B0
        public void Cleanup(){} // RVA: 0xA50C8F0
        public void InvalidateFileIfVersionUnknown(){} // RVA: 0xA50CD90
        public void Clear(){} // RVA: 0xA50CF40
        public void .cctor(){} // RVA: 0xA50D190
    }

    public class ApiCacheObject
    {
        // ── Methods ──
        public void ShouldCache(){} // RVA: 0x87D280
        public void GetLifeSpan(){} // RVA: 0x890F90
        public void Clone(){} // RVA: 0x87C0A0
        public void set_ExpiryTime(){} // RVA: 0x894320
    }

    public class ApiCertificateVerifier : CertificateHandler
    {
        public object _instance;
        public object publicKeys;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0xA50E4F0
        public void .ctor(){} // RVA: 0x812BCB0
        public void Initialize(){} // RVA: 0xA50E550
        public void TestPublicKey(){} // RVA: 0xA50E650
        public void IsValid(){} // RVA: 0xA50E900
        public void ValidateCertificate(){} // RVA: 0xA50EB40
        public void .cctor(){} // RVA: 0xA50ED00
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
        public void get_VERSION(){} // RVA: 0x87C0D0
        public void ShouldCache(){} // RVA: 0x87D280
        public void GetLifeSpan(){} // RVA: 0x890F90
        public void get_name(){} // RVA: 0x87C0A0
        public void set_name(){} // RVA: 0x894320
        public void get_imageUrl(){} // RVA: 0x87C0A0
        public void set_imageUrl(){} // RVA: 0x894320
        public void get_authorName(){} // RVA: 0x87C0A0
        public void set_authorName(){} // RVA: 0x894320
        public void get_authorId(){} // RVA: 0x87C0A0
        public void set_authorId(){} // RVA: 0x894320
        public void get_assetUrl(){} // RVA: 0x87C0A0
        public void set_assetUrl(){} // RVA: 0x894320
        public void get_description(){} // RVA: 0x87C0A0
        public void set_description(){} // RVA: 0x894320
        public void get_tags(){} // RVA: 0x87C0A0
        public void set_tags(){} // RVA: 0x894320
        public void get_thumbnailImageUrl(){} // RVA: 0x87C0A0
        public void set_thumbnailImageUrl(){} // RVA: 0x894320
        public void get_version(){} // RVA: 0x87C130
        public void set_version(){} // RVA: 0x8944F0
        public void get_releaseStatus(){} // RVA: 0x87C0A0
        public void set_releaseStatus(){} // RVA: 0x894320
        public void get_featured(){} // RVA: 0x87D280
        public void set_featured(){} // RVA: 0x894750
        public void get_unityPackageUpdated(){} // RVA: 0x87D280
        public void set_unityPackageUpdated(){} // RVA: 0x894750
        public void get_unityVersion(){} // RVA: 0x87C0A0
        public void set_unityVersion(){} // RVA: 0x894320
        public void get_apiVersion(){} // RVA: 0x87C130
        public void set_apiVersion(){} // RVA: 0x8944F0
        public void get_platform(){} // RVA: 0x87C0A0
        public void set_platform(){} // RVA: 0x894320
        public void get_assetVersion(){} // RVA: 0x87C0A0
        public void set_assetVersion(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894320
        public void ReadField(){} // RVA: 0x87D3C0
        public void Get(){} // RVA: 0xA94080
        public void FetchList(){} // RVA: 0xA94080
        public void AddLocal(){} // RVA: 0xA94080
        public void IsLocalById(){} // RVA: 0x87D390
        public void get_IsLocal(){} // RVA: 0x87D280
        public void Save(){} // RVA: 0x8943B0
        public void SaveReleaseStatus(){} // RVA: 0x8943B0
        public void GetAssetUrl(){} // RVA: 0x87C0A0
        public void HasTag(){} // RVA: 0x87D350
        public void AddTag(){} // RVA: 0x87D350
        public void RemoveTag(){} // RVA: 0x87D350
        public void UpdateVersionAndPlatform(){} // RVA: 0x894290
        public void MakeRequestEndpoint(){} // RVA: 0x881D20
        public void .cctor(){} // RVA: 0x8942F0
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

    public class ApiDroneSkin : ApiModel
    {
        public object _name;
        public object _assetBundleId;
        public object _viewfinderAssetBundleId;

        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_assetBundleId(){} // RVA: 0xC10050
        public void set_assetBundleId(){} // RVA: 0xC10060
        public void get_viewfinderAssetBundleId(){} // RVA: 0xCD3320
        public void set_viewfinderAssetBundleId(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA50EF50
    }

    public class ApiFieldAttribute : Attribute
    {
        public object required;
        public object name;
        public object isAdminWritableOnly;
        public object isApiWritableOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xF482F0
    }

    public class ApiFile : ApiModel
    {
        public object _name;
        public object _order;
        public object _ownerId;
        public object _mimeType;
        public object _extension;
        public object _versions;
        public object _isInitialized;
        public object _isPendingInit;

        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_order(){} // RVA: 0xC10050
        public void set_order(){} // RVA: 0x278E9C0
        public void get_ownerId(){} // RVA: 0xCD3320
        public void set_ownerId(){} // RVA: 0xCD4740
        public void get_mimeType(){} // RVA: 0xCD48B0
        public void set_mimeType(){} // RVA: 0xCD3600
        public void get_extension(){} // RVA: 0xB813B0
        public void set_extension(){} // RVA: 0xD5CBB0
        public void get_versions(){} // RVA: 0x1069350
        public void set_versions(){} // RVA: 0xD5CC10
        public void get_IsInitialized(){} // RVA: 0x11319D0
        public void set_IsInitialized(){} // RVA: 0x112ECB0
        public void get_IsPendingInit(){} // RVA: 0x1133080
        public void set_IsPendingInit(){} // RVA: 0x6C31AC0
        public void .ctor(){} // RVA: 0xA511EC0
        public void Create(){} // RVA: 0xA512050
        public void Refresh(){} // RVA: 0xA512210
        public void DownloadFile(){} // RVA: 0xA512250
        public void ParseFileIdFromFileAPIUrl(){} // RVA: 0xA512860
        public void TryParseFileIdFromFileAPIUrl(){} // RVA: 0xA5128D0
        public void TryParseFileVersionFromFileAPIUrl(){} // RVA: 0xA512910
        public void TryParseFileIdAndVersionFromFileAPIUrl(){} // RVA: 0xA512960
        public void TryParseFileIdAndVersionAndVariantSuffixFromFileAPIUrl(){} // RVA: 0xA5129A0
        public void TryParseFileIdAndVersionAndVariantFromFileAPIUrl(){} // RVA: 0xA512A20
        public void PerformRegexMatch(){} // RVA: 0xA512A50
        public void TryGetImageAPIUrlFromFileAPIUrl(){} // RVA: 0xA513240
        public void OnDownloadFileCompleted(){} // RVA: 0xA513780
        public void SetApiFieldsFromJson(){} // RVA: 0xA513E70
        public void ToString(){} // RVA: 0xA513EA0
        public void ToStringBrief(){} // RVA: 0x2538380
        public void CreateNewVersion(){} // RVA: 0xA5140C0
        public void HasExistingVersion(){} // RVA: 0xA514800
        public void HasExistingOrPendingVersion(){} // RVA: 0xA5148D0
        public void GetLatestVersionNumber(){} // RVA: 0xA5149C0
        public void GetLatestCompleteVersionNumber(){} // RVA: 0xA514A20
        public void GetVersion(){} // RVA: 0xA514B70
        public void GetLatestCompleteVersion(){} // RVA: 0xA514C10
        public void GetLatestVersion(){} // RVA: 0xA514C40
        public void DeleteVersion(){} // RVA: 0xA514CB0
        public void DeleteLatestVersion(){} // RVA: 0xA514FA0
        public void DownloadSignature(){} // RVA: 0xA515380
        public void GetFileURL(){} // RVA: 0xA515420
        public void GetFileRawURL(){} // RVA: 0xA5154B0
        public void GetDeltaURL(){} // RVA: 0xA515560
        public void GetDeltaRawURL(){} // RVA: 0xA5155F0
        public void GetSignatureURL(){} // RVA: 0xA5156A0
        public void GetSignatureRawURL(){} // RVA: 0xA515730
        public void GetFileApiURL(){} // RVA: 0xA515990
        public void GetFileVariantApiURL(){} // RVA: 0xA515AC0
        public void GetFileMD5(){} // RVA: 0xA515F30
        public void GetFileDescriptor(){} // RVA: 0xA515FB0
        public void IsLatestVersionQueued(){} // RVA: 0xA515FE0
        public void HasQueuedOperation(){} // RVA: 0xA5160B0
        public void IsWaitingForUpload(){} // RVA: 0xA516250
        public void IsInErrorState(){} // RVA: 0xA516320
        public void StartSimpleUpload(){} // RVA: 0xA5163F0
        public void StartMultipartUpload(){} // RVA: 0xA516780
        public void FinishUpload(){} // RVA: 0xA516B60
        public void GetUploadStatus(){} // RVA: 0xA516DF0
        public void PutSimpleFileToURL(){} // RVA: 0xA516FF0
        public void PutMultipartDataToURL(){} // RVA: 0xA517A60
    }

    public class ApiHypeTrainInfo : ApiModel
    {
        public object _campaignId;
        public object _hypeTrainId;
        public object _cooldownSeconds;
        public object _endDate;
        public object _lastUpdatedAt;
        public object _startDate;
        public object _currentGiftCount;
        public object _totalGiftGoal;
        public object _totalGiftContributors;
        public object _totalGiftsFromYouCount;

        // ── Methods ──
        public void get_campaignId(){} // RVA: 0xBBFF90
        public void set_campaignId(){} // RVA: 0xBBFFA0
        public void get_hypeTrainId(){} // RVA: 0xC10050
        public void set_hypeTrainId(){} // RVA: 0xC10060
        public void get_cooldownSeconds(){} // RVA: 0x23ADD10
        public void set_cooldownSeconds(){} // RVA: 0x23B2A80
        public void get_endDate(){} // RVA: 0xCD48B0
        public void set_endDate(){} // RVA: 0x278E9B0
        public void get_lastUpdatedAt(){} // RVA: 0xB813B0
        public void set_lastUpdatedAt(){} // RVA: 0x13AA640
        public void get_startDate(){} // RVA: 0x1069350
        public void set_startDate(){} // RVA: 0x25687F0
        public void get_currentGiftCount(){} // RVA: 0x262A930
        public void set_currentGiftCount(){} // RVA: 0x262A900
        public void get_totalGiftGoal(){} // RVA: 0x262A910
        public void set_totalGiftGoal(){} // RVA: 0x262A920
        public void get_totalGiftContributors(){} // RVA: 0x262A8F0
        public void set_totalGiftContributors(){} // RVA: 0x262A940
        public void get_totalGiftsFromYouCount(){} // RVA: 0x6C8E620
        public void set_totalGiftsFromYouCount(){} // RVA: 0x6C8E630
        public void .ctor(){} // RVA: 0xA5CD660
    }

    public class ApiHypeTrainInfo[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiHypeTrainInstanceInfo : ApiModel
    {
        public object _potentialTrain;
        public object _current;
        public object _history;

        // ── Methods ──
        public void get_potentialTrain(){} // RVA: 0xBBFF90
        public void set_potentialTrain(){} // RVA: 0xBBFFA0
        public void get_current(){} // RVA: 0xC10050
        public void set_current(){} // RVA: 0xC10060
        public void get_history(){} // RVA: 0xCD3320
        public void set_history(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA5CD610
    }

    public class ApiInfoPushSystem : ApiModel
    {
        public object CacheTime;
        public object _isEnabled;
        public object _releaseStatus;
        public object _tags;
        public object _requireClientTags;
        public object _priority;
        public object _startDate;
        public object _endDate;
        public object _createdAt;
        public object _updatedAt;
        public object _hash;
        public object _originalManifestId;
        public object _experiment;
        public object _data;
        public object ENDPOINT;

        // ── Methods ──
        public void get_isEnabled(){} // RVA: 0xC10030
        public void set_isEnabled(){} // RVA: 0xC10040
        public void get_releaseStatus(){} // RVA: 0xC10050
        public void set_releaseStatus(){} // RVA: 0xC10060
        public void get_tags(){} // RVA: 0xCD3320
        public void set_tags(){} // RVA: 0xCD4740
        public void get_requireClientTags(){} // RVA: 0xCD48B0
        public void set_requireClientTags(){} // RVA: 0xCD3600
        public void get_priority(){} // RVA: 0x14780B0
        public void set_priority(){} // RVA: 0x147EE80
        public void get_startDate(){} // RVA: 0x1069350
        public void set_startDate(){} // RVA: 0x25687F0
        public void get_endDate(){} // RVA: 0x106A7D0
        public void set_endDate(){} // RVA: 0x6A6A800
        public void get_createdAt(){} // RVA: 0x106A050
        public void set_createdAt(){} // RVA: 0x6A6A810
        public void get_updatedAt(){} // RVA: 0x12EB090
        public void set_updatedAt(){} // RVA: 0x24440F0
        public void get_hash(){} // RVA: 0xBAE340
        public void set_hash(){} // RVA: 0xBAE350
        public void get_originalManifestId(){} // RVA: 0xBAE3B0
        public void set_originalManifestId(){} // RVA: 0xBAE3C0
        public void get_experiment(){} // RVA: 0xBAE420
        public void set_experiment(){} // RVA: 0xBAE430
        public void get_data(){} // RVA: 0xCA4D80
        public void set_data(){} // RVA: 0xCA4D90
        public void .ctor(){} // RVA: 0xA51B4F0
        public void GetLifeSpan(){} // RVA: 0x421A220
        public void FetchList(){} // RVA: 0xA51B5B0
        public void Save(){} // RVA: 0xA51BC70
    }

    public class ApiInfoPushSystem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiInventoryBundleDrop[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiInventoryItem : ApiModel
    {
        public object ITEM_TEMPLATE_ID_PREFIX;
        public object _templateId;
        public object _name;
        public object _description;
        public object _imageUrl;
        public object _attribution;
        public object _flags;
        public object _tags;
        public object _collections;
        public object _itemType;
        public object _holderId;
        public object _firstAncestor;
        public object _firstAncestorHolderId;
        public object _expiryDate;
        public object _created_at;
        public object _updated_at;
        public object _template_created_at;
        public object _template_updated_at;
        public object _isArchived;
        public object _isSeen;
        public object _last_equipped_at;
        public object _equipSlots;
        public object _equipSlot;
        public object _quantity;
        public object _quantifiable;
        public object _defaultAttributes;
        public object _userAttributes;
        public object _validateUserAttributes;
        public object _notificationDetails;
        public object _status;
        public object _metadata;
        public object ENDPOINT;
        public object FLAG_USER_GENERATED;
        public object FLAG_INSTANTIATABLE;
        public object FLAG_CONSUMABLE;
        public object FLAG_TRASHABLE;
        public object FLAG_ARCHIVABLE;
        public object FLAG_CLONEABLE;
        public object FLAG_EQUIPPABLE;
        public object FLAG_QUANTIFIABLE;
        public object FLAG_QUANTIFIABLE_ALLOW_ZERO;
        public object FLAG_PREMIUM;
        public object FLAG_VRC_PLUS_EXCLUSIVE;
        public object FLAG_GLOBAL;
        public object ITEM_TYPE_STICKER;
        public object ITEM_TYPE_EMOJI;
        public object ITEM_TYPE_BUNDLE;
        public object ITEM_TYPE_PROP;
        public object ITEM_TYPE_ACCESSORY;
        public object ITEM_TYPE_AVATAR_LOOK;
        public object ITEM_TYPE_DRONE_SKIN;
        public object ITEM_TYPE_PORTAL_SKIN;
        public object ITEM_TYPE_WARP_EFFECT;
        public object ITEM_TYPE_LOADING_SCREEN;
        public object ITEM_TYPE_ICON_FRAME;
        public object ITEM_TYPE_NAMEPLATE_EFFECT;
        public object ITEM_TYPE_PROFILE_EFFECT;
        public object ITEM_TYPE_PROFILE_BACKGROUND;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA51CC90
        public void get_templateId(){} // RVA: 0xBBFF90
        public void set_templateId(){} // RVA: 0xBBFFA0
        public void get_name(){} // RVA: 0xC10050
        public void set_name(){} // RVA: 0xC10060
        public void get_description(){} // RVA: 0xCD3320
        public void set_description(){} // RVA: 0xCD4740
        public void get_imageUrl(){} // RVA: 0xCD48B0
        public void set_imageUrl(){} // RVA: 0xCD3600
        public void get_attribution(){} // RVA: 0xB813B0
        public void set_attribution(){} // RVA: 0xD5CBB0
        public void get_flags(){} // RVA: 0x1069350
        public void set_flags(){} // RVA: 0xD5CC10
        public void get_tags(){} // RVA: 0x106A7D0
        public void set_tags(){} // RVA: 0xD5CC70
        public void get_collections(){} // RVA: 0x106A050
        public void set_collections(){} // RVA: 0xD5CCD0
        public void get_itemType(){} // RVA: 0x12EB090
        public void set_itemType(){} // RVA: 0x13B1040
        public void get_holderId(){} // RVA: 0xBAE340
        public void set_holderId(){} // RVA: 0xBAE350
        public void get_firstAncestor(){} // RVA: 0xBAE3B0
        public void set_firstAncestor(){} // RVA: 0xBAE3C0
        public void get_firstAncestorHolderId(){} // RVA: 0xBAE420
        public void set_firstAncestorHolderId(){} // RVA: 0xBAE430
        public void get_expiryDate(){} // RVA: 0xCA4D80
        public void set_expiryDate(){} // RVA: 0x981B490
        public void get_created_at(){} // RVA: 0xC68EB0
        public void set_created_at(){} // RVA: 0x7339DC0
        public void get_updated_at(){} // RVA: 0x135D730
        public void set_updated_at(){} // RVA: 0x485FCF0
        public void get_template_created_at(){} // RVA: 0xBC5B30
        public void set_template_created_at(){} // RVA: 0x485FD20
        public void get_template_updated_at(){} // RVA: 0xBC5BA0
        public void set_template_updated_at(){} // RVA: 0x6A8AFA0
        public void get_isArchived(){} // RVA: 0xBC5D20
        public void set_isArchived(){} // RVA: 0xBC5D30
        public void get_isSeen(){} // RVA: 0x21656F0
        public void set_isSeen(){} // RVA: 0x216AB00
        public void get_last_equipped_at(){} // RVA: 0x135A7B0
        public void set_last_equipped_at(){} // RVA: 0xA51CD50
        public void get_equipSlots(){} // RVA: 0x10B4170
        public void set_equipSlots(){} // RVA: 0x15B42C0
        public void get_equipSlot(){} // RVA: 0x10B9D50
        public void set_equipSlot(){} // RVA: 0x15B7570
        public void get_quantity(){} // RVA: 0x23A4510
        public void set_quantity(){} // RVA: 0x23A4120
        public void get_quantifiable(){} // RVA: 0x1CB30D0
        public void set_quantifiable(){} // RVA: 0x1CAFDD0
        public void get_defaultAttributes(){} // RVA: 0xDA0520
        public void set_defaultAttributes(){} // RVA: 0xD9D570
        public void get_userAttributes(){} // RVA: 0x114AC20
        public void set_userAttributes(){} // RVA: 0x1149C90
        public void get_validateUserAttributes(){} // RVA: 0x186B250
        public void set_validateUserAttributes(){} // RVA: 0x1868AE0
        public void get_notificationDetails(){} // RVA: 0x135EDB0
        public void set_notificationDetails(){} // RVA: 0x1658000
        public void get_status(){} // RVA: 0x135A170
        public void set_status(){} // RVA: 0x1365A40
        public void get_metadata(){} // RVA: 0xBAE8F0
        public void set_metadata(){} // RVA: 0xBAE900
        public void get_IsGlobal(){} // RVA: 0xA51CD60
        public void get_Instantiatable(){} // RVA: 0xA51CDD0
        public void get_Consumable(){} // RVA: 0xA51CE40
        public void get_Archivable(){} // RVA: 0xA51CEB0
        public void get_Trashable(){} // RVA: 0xA51CF20
        public void get_Cloneable(){} // RVA: 0xA51CF90
        public void get_Equippable(){} // RVA: 0xA51D000
        public void get_Equipped(){} // RVA: 0xA51D090
        public void get_IsUserGenerated(){} // RVA: 0xA51D0D0
        public void get_IsTemplate(){} // RVA: 0xA51D140
        public void SetApiFieldsFromJson(){} // RVA: 0xA51D390
        public void GetModelForMetadataType(){} // RVA: 0xA51D5B0
        public void FetchList(){} // RVA: 0xA51DE90
        public void Fetch(){} // RVA: 0xA51F1E0
        public void SetIsArchived(){} // RVA: 0xA51F510
        public void SetIsSeen(){} // RVA: 0xA51F9A0
        public void Consume(){} // RVA: 0xA51FE30
        public void FetchInventoryTemplate(){} // RVA: 0xA5201D0
        public void FetchInventoryTemplateAsync(){} // RVA: 0xA520500
        public void FetchUserInventoryItem(){} // RVA: 0xA5206A0
        public void Equip(){} // RVA: 0xA5209F0
        public void ClearEquipSlot(){} // RVA: 0xA521030
        public void SaveUserAttributes(){} // RVA: 0xA521330
        public void FetchEquipped(){} // RVA: 0xA5218B0
        public void GetAttributes(){} // RVA: 0xA521ED0
        public void GetDefaultAttributes(){} // RVA: 0xA5221E0
        public void FetchAllTemplates(){} // RVA: 0xA522440
        public void FetchCosmeticsIndex(){} // RVA: 0xA522AE0
    }

    public class ApiInventoryItem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiInventoryJweToken : ApiModel
    {
        public object _token;
        public object ENDPOINT_SPAWN;
        public object ENDPOINT_CLONE_DIRECT;
        public object ENDPOINT_CLONE_PEDESTAL;
        public object ENDPOINT_CLONE_TOKEN;

        // ── Methods ──
        public void get_token(){} // RVA: 0xBBFF90
        public void set_token(){} // RVA: 0xBBFFA0
        public void RequestSpawnToken(){} // RVA: 0xA523F80
        public void RequestDirectShareToken(){} // RVA: 0xA524480
        public void RequestPedestalShareToken(){} // RVA: 0xA5249F0
        public void RequestClone(){} // RVA: 0xA5250F0
        public void .ctor(){} // RVA: 0xA525600
    }

    public class ApiLicense : ApiModel
    {
        public object _licenseId;
        public object _ownerId;
        public object _ownerDisplayName;
        public object _licenseHolderId;
        public object _licenseHolderDisplayName;
        public object _forType;
        public object _forId;
        public object _productId;
        public object _productType;
        public object _isActive;
        public object _untilDate;
        public object _isCurrent;
        public object _created;
        public object _forAction;
        public object _forName;
        public object _licenseHolderType;
        public object _notes;
        public object _tags;
        public object _updated;

        // ── Methods ──
        public void get_LicenseId(){} // RVA: 0xBBFF90
        public void set_LicenseId(){} // RVA: 0xBBFFA0
        public void get_OwnerId(){} // RVA: 0xC10050
        public void set_OwnerId(){} // RVA: 0xC10060
        public void get_OwnerDisplayName(){} // RVA: 0xCD3320
        public void set_OwnerDisplayName(){} // RVA: 0xCD4740
        public void get_LicenseHolderId(){} // RVA: 0xCD48B0
        public void set_LicenseHolderId(){} // RVA: 0xCD3600
        public void get_LicenseHolderDisplayName(){} // RVA: 0xB813B0
        public void set_LicenseHolderDisplayName(){} // RVA: 0xD5CBB0
        public void get_ForType(){} // RVA: 0xF3A950
        public void set_ForType(){} // RVA: 0x17AFA20
        public void get_ForId(){} // RVA: 0x106A7D0
        public void set_ForId(){} // RVA: 0xD5CC70
        public void get_ProductId(){} // RVA: 0x106A050
        public void set_ProductId(){} // RVA: 0xD5CCD0
        public void get_ProductType(){} // RVA: 0x158C700
        public void set_ProductType(){} // RVA: 0x158BEC0
        public void get_IsActive(){} // RVA: 0xA528110
        public void set_IsActive(){} // RVA: 0xA528120
        public void get_UntilDate(){} // RVA: 0xBAE340
        public void set_UntilDate(){} // RVA: 0x2443FC0
        public void get_IsCurrent(){} // RVA: 0x20119F0
        public void set_IsCurrent(){} // RVA: 0x2013510
        public void get_Created(){} // RVA: 0xBAE420
        public void set_Created(){} // RVA: 0x1765100
        public void get_ForAction(){} // RVA: 0xCA4D80
        public void set_ForAction(){} // RVA: 0xCA4D90
        public void get_ForName(){} // RVA: 0xC68EB0
        public void set_ForName(){} // RVA: 0xC68EC0
        public void get_LicenseHolderType(){} // RVA: 0x135D730
        public void set_LicenseHolderType(){} // RVA: 0xBC5AD0
        public void get_Notes(){} // RVA: 0xBC5B30
        public void set_Notes(){} // RVA: 0xBC5B40
        public void get_Tags(){} // RVA: 0xBC5BA0
        public void set_Tags(){} // RVA: 0xBC5BB0
        public void get_Updated(){} // RVA: 0xBAE5A0
        public void set_Updated(){} // RVA: 0x6E3F2A0
        public void FetchLicenses(){} // RVA: 0xA528130
        public void FetchActiveLicenses(){} // RVA: 0xA528430
        public void ReadField(){} // RVA: 0xA528D80
        public void WriteField(){} // RVA: 0xA5291A0
        public void .ctor(){} // RVA: 0xA5293B0
    }

    public class ApiLicense[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiMessage : ApiModel
    {
        public object messageTypeToMessageAPI;
        public object MaxMessageLength;
        public object _slot;
        public object _message;
        public object _messageType;
        public object _updatedAt;
        public object _remainingCooldownMinutes;
        public object _canBeUpdated;

        // ── Methods ──
        public void get_slot(){} // RVA: 0x2536460
        public void set_slot(){} // RVA: 0x25406E0
        public void get_message(){} // RVA: 0xC10050
        public void set_message(){} // RVA: 0xC10060
        public void get_messageType(){} // RVA: 0xCD3320
        public void set_messageType(){} // RVA: 0xCD4740
        public void get_updatedAt(){} // RVA: 0xCD48B0
        public void set_updatedAt(){} // RVA: 0x278E9B0
        public void get_remainingCooldownMinutes(){} // RVA: 0x14780B0
        public void set_remainingCooldownMinutes(){} // RVA: 0x147EE80
        public void get_canBeUpdated(){} // RVA: 0xBAB4F0
        public void set_canBeUpdated(){} // RVA: 0xBAB500
        public void .ctor(){} // RVA: 0xA529620
        public void FetchMessages(){} // RVA: 0xA5297F0
        public void DeleteAllMessages(){} // RVA: 0xA529C90
        public void DeleteMessageInSlot(){} // RVA: 0xA52A150
        public void SetMessageInSlot(){} // RVA: 0xA52A6B0
        public void truncatedMessage(){} // RVA: 0xA52ACE0
        public void ToString(){} // RVA: 0xA52ADB0
        public void .cctor(){} // RVA: 0xA52AFB0
    }

    public class ApiMessage[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiModel : Object
    {
        public object activeRequests;
        public object maximumParseDepth;
        public object currentRemainingDepth;
        public object _setApiFieldsFromJsonProfilerMarker;
        public object _id;
        public object _expiryTime;
        public object _populated;
        public object _failedValidation;
        public object _endpoint;
        public object _cacheIdInput;
        public object _cacheId;
        public object _cacheIdBuilder;
        public object _missingFieldCache;
        public object _fieldsMissingFromOriginalResponse;
        public object _fieldsLockedForNetworkUpdates;
        public object supportedPlatforms;
        public object RESPONSE_FIELDS_HASH_OFFSET;
        public object RESPONSE_FIELDS_HASH_MULTIPLIER;
        public object modelContainerType;
        public object CreateFromJsonCache;
        public object EnumValuesCache;
        public object _requiredProperties;
        public object _targetProperties;
        public object PropertyApiFieldNames;
        public object foundProperties;

        // ── Methods ──
        public void get_id(){} // RVA: 0xB5DBF0
        public void set_id(){} // RVA: 0xB44D60
        public void get_ExpiryTime(){} // RVA: 0x125EE60
        public void set_ExpiryTime(){} // RVA: 0x125D9D0
        public void get_Populated(){} // RVA: 0xF73960
        public void set_Populated(){} // RVA: 0xF73A60
        public void get_FailedValidation(){} // RVA: 0x14F7430
        public void set_FailedValidation(){} // RVA: 0x21CBB70
        public void get_Endpoint(){} // RVA: 0xD33E60
        public void set_Endpoint(){} // RVA: 0xB708C0
        public void GetOrPutCachedMissingFieldList(){} // RVA: 0xA52B4C0
        public void get_FieldsMissingFromOriginalResponse(){} // RVA: 0xBBF8F0
        public void set_FieldsMissingFromOriginalResponse(){} // RVA: 0xBBF900
        public void get_FieldsLockedForNetworkUpdates(){} // RVA: 0xBE58B0
        public void set_FieldsLockedForNetworkUpdates(){} // RVA: 0xCA4DF0
        public void GetCacheId(){} // RVA: 0xA52BD80
        public void ComputeCacheId(){} // RVA: 0xA52C040
        public void ShouldCache(){} // RVA: 0xA52C460
        public void GetLifeSpan(){} // RVA: 0xA52C4A0
        public void .ctor(){} // RVA: 0xA52C580
        public void Clone(){} // RVA: 0xA52C810
        public void Save(){} // RVA: 0xA52CD70
        public void SaveField(){} // RVA: 0xA52CDB0
        public void Post(){} // RVA: 0xA52D080
        public void Put(){} // RVA: 0xA52D0C0
        public void Fetch(){} // RVA: 0xA52D100
        public void PostAsync(){} // RVA: 0xA94080
        public void PutAsync(){} // RVA: 0xA94080
        public void FetchAsync(){} // RVA: 0x2D72F40
        public void Get(){} // RVA: 0xA52D130
        public void PostOrPut(){} // RVA: 0xA52D990
        public void Delete(){} // RVA: 0xA52F180
        public void DeleteAsync(){} // RVA: 0xA52F420
        public void SetApiFieldsFromJson(){} // RVA: 0xA530710
        public void PopulateMissingValuesFrom(){} // RVA: 0xA531490
        public void ExtractApiFields(){} // RVA: 0xA531990
        public void MakeModelContainer(){} // RVA: 0xA531D70
        public void ReadField(){} // RVA: 0xA532010
        public void TryReadConvert(){} // RVA: 0xA532400
        public void WriteField(){} // RVA: 0xA533840
        public void CopyDeserializedValuesTo(){} // RVA: 0xB43320
        public void GetCreateFromJsonMethodInfo(){} // RVA: 0xA5347A0
        public void ParseEnumValue(){} // RVA: 0x2D73150
        public void IsNumber(){} // RVA: 0xA534DB0
        public void DoubleCast(){} // RVA: 0xA534E20
        public void TryWriteConvert(){} // RVA: 0xA535120
        public void ParseList(){} // RVA: 0xA5361B0
        public void ParseDictionary(){} // RVA: 0xA536660
        public void ParseModel(){} // RVA: 0xA536E60
        public void ParseLocalizableString(){} // RVA: 0xA5370B0
        public void SendGetRequest(){} // RVA: 0xA537290
        public void SendPutRequest(){} // RVA: 0xA537540
        public void MakeRequestEndpoint(){} // RVA: 0xA537610
        public void get_RequiredProperties(){} // RVA: 0xA5376C0
        public void get_TargetProperties(){} // RVA: 0xA537D00
        public void FindPropertyName(){} // RVA: 0xA538100
        public void FindProperty(){} // RVA: 0xA538420
        public void IsAdminWritableOnly(){} // RVA: 0xA538910
        public void IsApiWritableOnly(){} // RVA: 0xA538B00
        public void .cctor(){} // RVA: 0xA538CF0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DB10
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DB10
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DB10
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DB10
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DB10
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DB10
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DB10
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DB10
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DC80
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelContainer`1 : ApiDictContainer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DB10
        public void ValidModelData(){} // RVA: 0x421DCD0
        public void Validate(){} // RVA: 0x421DDA0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
        public void .ctor(){} // RVA: 0x421DF50
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x421DF50
        public void get_ResponseModels(){} // RVA: 0xBBFF90
        public void set_ResponseModels(){} // RVA: 0xBBFFA0
        public void Validate(){} // RVA: 0x421DFD0
    }

    public class ApiModelListContainer`1 : ApiListContainer
    {
        public object _responseModels;

        // ── Methods ──
        public void get_ResponseModels(){} // RVA: 0x87C0A0
        public void set_ResponseModels(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0x894290
        public void Validate(){} // RVA: 0x87DB70
    }

    public class ApiModeration[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiPendingTransaction : ApiModel
    {
        public object _userId;
        public object _userDisplayName;
        public object _targetUserId;
        public object _targetDisplayName;
        public object _status;
        public object _pico;
        public object _gplay;
        public object _subscription;
        public object _created_at;
        public object _updated_at;
        public object _isGift;
        public object _isTokens;

        // ── Methods ──
        public void get_userId(){} // RVA: 0xBBFF90
        public void set_userId(){} // RVA: 0xBBFFA0
        public void get_userDisplayName(){} // RVA: 0xC10050
        public void set_userDisplayName(){} // RVA: 0xC10060
        public void get_targetUserId(){} // RVA: 0xCD3320
        public void set_targetUserId(){} // RVA: 0xCD4740
        public void get_targetDisplayName(){} // RVA: 0xCD48B0
        public void set_targetDisplayName(){} // RVA: 0xCD3600
        public void get_status(){} // RVA: 0xB813B0
        public void set_status(){} // RVA: 0xD5CBB0
        public void get_pico(){} // RVA: 0x1069350
        public void set_pico(){} // RVA: 0xD5CC10
        public void get_gplay(){} // RVA: 0x106A7D0
        public void set_gplay(){} // RVA: 0xD5CC70
        public void get_subscription(){} // RVA: 0x106A050
        public void set_subscription(){} // RVA: 0xD5CCD0
        public void get_created_at(){} // RVA: 0x12EB090
        public void set_created_at(){} // RVA: 0x13B1040
        public void get_updated_at(){} // RVA: 0xBAE340
        public void set_updated_at(){} // RVA: 0xBAE350
        public void get_isGift(){} // RVA: 0x20119F0
        public void set_isGift(){} // RVA: 0x2013510
        public void get_isTokens(){} // RVA: 0x2558540
        public void set_isTokens(){} // RVA: 0x421A230
        public void .ctor(){} // RVA: 0xA59A940
    }

    public class ApiPendingTransaction[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiPlayerModeration[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiPortalSkin : ApiModel
    {
        public object _name;
        public object _assetBundleId;

        // ── Methods ──
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_assetBundleId(){} // RVA: 0xC10050
        public void set_assetBundleId(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA566440
    }

    public class ApiPotentialHypeTrainInfo : ApiModel
    {
        public object _currentGiftCount;
        public object _minGiftsToStart;
        public object _endDate;

        // ── Methods ──
        public void get_currentGiftCount(){} // RVA: 0x2536460
        public void set_currentGiftCount(){} // RVA: 0x25406E0
        public void get_minGiftsToStart(){} // RVA: 0x25406F0
        public void set_minGiftsToStart(){} // RVA: 0x2540700
        public void get_endDate(){} // RVA: 0xC10050
        public void set_endDate(){} // RVA: 0x278E9C0
        public void .ctor(){} // RVA: 0xA5CD6B0
    }

    public class ApiProduct : ApiModel
    {
        public object _type;
        public object _createdAt;
        public object _updatedAt;
        public object _sellerId;
        public object _avatarId;
        public object _sellerDisplayName;
        public object _name;
        public object _description;
        public object _subtitle;
        public object _productImageId;
        public object _attribution;
        public object _licenseId;
        public object _tags;
        public object _soldByVrc;
        public object _untilDate;
        public object _purchaseToken;
        public object _isVoided;
        public object _parentListings;
        public object _productTypeLabel;
        public object _quantifiable;
        public object _groupId;
        public object _groupRoleId;
        public object _groupAccess;
        public object _groupAccessRemove;
        public object _inventoryItemTemplateId;
        public object _inventoryItemType;
        public object _inventoryItemQuantity;
        public object _assetDisabled;
        public object _listingID;
        public object _listingType;
        public object _products;
        public object _productIDs;
        public object _hydratedProducts;
        public object _active;
        public object _subscriberExclusive;
        public object _containsCompanionProduct;
        public object _containedProductTypes;
        public object _price;
        public object _vrcPlusDiscountPrice;
        public object _availableToPurchaseUntilDate;
        public object _collaboratorUserId;
        public object _collaboratorUserDisplayName;
        public object _stock;
        public object _storeIDs;
        public object _duration;
        public object _durationType;
        public object _archived;
        public object _permanent;
        public object _instant;
        public object _stackable;
        public object _recurrable;
        public object _refundable;
        public object _buyerRefundable;
        public object _contextPreventsPurchase;
        public object _listingVariants;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA567F30
        public void get_Type(){} // RVA: 0x2536460
        public void set_Type(){} // RVA: 0x25406E0
        public void get_CreatedAt(){} // RVA: 0xC10050
        public void set_CreatedAt(){} // RVA: 0x278E9C0
        public void get_UpdatedAt(){} // RVA: 0xCD3320
        public void set_UpdatedAt(){} // RVA: 0x6529A50
        public void get_SellerId(){} // RVA: 0xCD48B0
        public void set_SellerId(){} // RVA: 0xCD3600
        public void get_AvatarId(){} // RVA: 0xB813B0
        public void set_AvatarId(){} // RVA: 0xD5CBB0
        public void get_SellerDisplayName(){} // RVA: 0x1069350
        public void set_SellerDisplayName(){} // RVA: 0xD5CC10
        public void get_Name(){} // RVA: 0x106A7D0
        public void set_Name(){} // RVA: 0xD5CC70
        public void get_Description(){} // RVA: 0x106A050
        public void set_Description(){} // RVA: 0xD5CCD0
        public void get_Subtitle(){} // RVA: 0x12EB090
        public void set_Subtitle(){} // RVA: 0x13B1040
        public void get_ProductImageId(){} // RVA: 0xBAE340
        public void set_ProductImageId(){} // RVA: 0xBAE350
        public void get_ProductImageUrl(){} // RVA: 0xA567FF0
        public void get_attribution(){} // RVA: 0xBAE3B0
        public void set_attribution(){} // RVA: 0xBAE3C0
        public void get_LicenseId(){} // RVA: 0xBAE420
        public void set_LicenseId(){} // RVA: 0xBAE430
        public void get_Tags(){} // RVA: 0xCA4D80
        public void set_Tags(){} // RVA: 0xCA4D90
        public void get_SoldByVrc(){} // RVA: 0x1A6FCB0
        public void set_SoldByVrc(){} // RVA: 0x1A6FC50
        public void get_UntilDate(){} // RVA: 0x135D730
        public void set_UntilDate(){} // RVA: 0x485FCF0
        public void get_PurchaseToken(){} // RVA: 0xBC5B30
        public void set_PurchaseToken(){} // RVA: 0xBC5B40
        public void get_IsVoided(){} // RVA: 0x1DFD090
        public void set_IsVoided(){} // RVA: 0x216A2B0
        public void get_ParentListings(){} // RVA: 0xBAE5A0
        public void set_ParentListings(){} // RVA: 0xBAE5B0
        public void get_ProductTypeLabel(){} // RVA: 0x135A7B0
        public void set_ProductTypeLabel(){} // RVA: 0xEC0BB0
        public void get_Quantifiable(){} // RVA: 0x2443BA0
        public void set_Quantifiable(){} // RVA: 0x2443BB0
        public void get_GroupId(){} // RVA: 0x10B9D50
        public void set_GroupId(){} // RVA: 0x15B7570
        public void get_GroupRoleId(){} // RVA: 0xD9E3D0
        public void set_GroupRoleId(){} // RVA: 0xD9D290
        public void get_GroupAccess(){} // RVA: 0xEF50C0
        public void set_GroupAccess(){} // RVA: 0xEF3230
        public void get_GroupAccessRemove(){} // RVA: 0xA568030
        public void set_GroupAccessRemove(){} // RVA: 0xA568040
        public void get_InventoryItemTemplateId(){} // RVA: 0x114AC20
        public void set_InventoryItemTemplateId(){} // RVA: 0x1149C90
        public void get_InventoryItemType(){} // RVA: 0xE3C930
        public void set_InventoryItemType(){} // RVA: 0xE3D020
        public void get_InventoryItemQuantity(){} // RVA: 0x114AC30
        public void set_InventoryItemQuantity(){} // RVA: 0x1AE2D20
        public void get_AssetDisabled(){} // RVA: 0x79F26E0
        public void set_AssetDisabled(){} // RVA: 0x79F26F0
        public void get_ListingID(){} // RVA: 0x135A170
        public void set_ListingID(){} // RVA: 0x1365A40
        public void get_ListingType(){} // RVA: 0x1A7DF50
        public void set_ListingType(){} // RVA: 0x1EC4A00
        public void get_Products(){} // RVA: 0xBAE960
        public void set_Products(){} // RVA: 0xBAE970
        public void get_ProductIDs(){} // RVA: 0x12CDBF0
        public void set_ProductIDs(){} // RVA: 0x164A230
        public void get_HydratedProducts(){} // RVA: 0x1661250
        public void set_HydratedProducts(){} // RVA: 0x166A5F0
        public void get_Active(){} // RVA: 0x6CE7E10
        public void set_Active(){} // RVA: 0x6CE7E20
        public void get_SubscriberExclusive(){} // RVA: 0x1B5A240
        public void set_SubscriberExclusive(){} // RVA: 0x1B52910
        public void get_ContainsCompanionProduct(){} // RVA: 0xA568050
        public void set_ContainsCompanionProduct(){} // RVA: 0xA568060
        public void get_ContainedProductTypes(){} // RVA: 0x164B8E0
        public void set_ContainedProductTypes(){} // RVA: 0x16601C0
        public void get_Price(){} // RVA: 0x11446A0
        public void set_Price(){} // RVA: 0x1EC4A10
        public void get_VrcPlusDiscountPrice(){} // RVA: 0x7A10230
        public void set_VrcPlusDiscountPrice(){} // RVA: 0xA568070
        public void get_AvailableToPurchaseUntilDate(){} // RVA: 0x10F9390
        public void set_AvailableToPurchaseUntilDate(){} // RVA: 0xA568080
        public void get_CollaboratorUserId(){} // RVA: 0x165EBC0
        public void set_CollaboratorUserId(){} // RVA: 0x1651590
        public void get_CollaboratorUserDisplayName(){} // RVA: 0x1667D40
        public void set_CollaboratorUserDisplayName(){} // RVA: 0x1669D30
        public void get_Stock(){} // RVA: 0x13659D0
        public void set_Stock(){} // RVA: 0x6F3ECE0
        public void get_StoreIDs(){} // RVA: 0x135C160
        public void set_StoreIDs(){} // RVA: 0x16614A0
        public void get_Duration(){} // RVA: 0xA568090
        public void set_Duration(){} // RVA: 0xA5680A0
        public void get_DurationType(){} // RVA: 0x9C46630
        public void set_DurationType(){} // RVA: 0x9C498E0
        public void get_Archived(){} // RVA: 0x6F3ED50
        public void set_Archived(){} // RVA: 0x6F3ED60
        public void get_Permanent(){} // RVA: 0x6F3ED70
        public void set_Permanent(){} // RVA: 0x6F3ED80
        public void get_Instant(){} // RVA: 0x6F3EDD0
        public void set_Instant(){} // RVA: 0x6F3EDE0
        public void get_Stackable(){} // RVA: 0xA5680B0
        public void set_Stackable(){} // RVA: 0xA5680C0
        public void get_Recurrable(){} // RVA: 0x22E54C0
        public void set_Recurrable(){} // RVA: 0x22E1B80
        public void get_Refundable(){} // RVA: 0xA5680D0
        public void set_Refundable(){} // RVA: 0xA5680E0
        public void get_BuyerRefundable(){} // RVA: 0xA5680F0
        public void set_BuyerRefundable(){} // RVA: 0xA568100
        public void get_ContextPreventsPurchase(){} // RVA: 0xA568110
        public void set_ContextPreventsPurchase(){} // RVA: 0xA568120
        public void get_ListingVariants(){} // RVA: 0x165E8F0
        public void set_ListingVariants(){} // RVA: 0x165C4D0
        public void Purchase(){} // RVA: 0xA568130
        public void ReadField(){} // RVA: 0xA569330
        public void WriteField(){} // RVA: 0xA569750
        public void FetchListing(){} // RVA: 0xA569BE0
        public void FetchFullListing(){} // RVA: 0xA56A0F0
        public void FetchOwnListings(){} // RVA: 0xA56A600
        public void FetchOwnProducts(){} // RVA: 0xA56AAE0
    }

    public class ApiProductAttribution : ApiModel
    {
        public object _creator;
        public object _publisher;
        public object _collaborationId;

        // ── Methods ──
        public void get_creator(){} // RVA: 0xBBFF90
        public void set_creator(){} // RVA: 0xBBFFA0
        public void get_publisher(){} // RVA: 0xC10050
        public void set_publisher(){} // RVA: 0xC10060
        public void get_collaborationId(){} // RVA: 0xCD3320
        public void set_collaborationId(){} // RVA: 0xCD4740
        public void .ctor(){} // RVA: 0xA5CD700
    }

    public class ApiProductCreator : ApiModel
    {
        public object _userId;
        public object _customName;

        // ── Methods ──
        public void get_userId(){} // RVA: 0xBBFF90
        public void set_userId(){} // RVA: 0xBBFFA0
        public void get_customName(){} // RVA: 0xC10050
        public void set_customName(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA5CD750
    }

    public class ApiProductPublisher : ApiModel
    {
        public object _userId;
        public object _customName;

        // ── Methods ──
        public void get_userId(){} // RVA: 0xBBFF90
        public void set_userId(){} // RVA: 0xBBFFA0
        public void get_customName(){} // RVA: 0xC10050
        public void set_customName(){} // RVA: 0xC10060
        public void .ctor(){} // RVA: 0xA5CD7A0
    }

    public class ApiProduct[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiPurchase[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiStoreShelf[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiTokenBundle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiUserIcon[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiUserPermission[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiUserPermissions : Object
    {
        public object permissions;
        public object MAX_USER_ICONS;
        public object MAX_USER_IMAGES;

        // ── Methods ──
        public void GetPermission_UserIcon(){} // RVA: 0xA598EF0
        public void GetPermission_InvitePhotos(){} // RVA: 0xA598F70
        public void GetPermission_ExtraFavoriteAvatars(){} // RVA: 0xA598FF0
        public void GetPermission_UserGallery(){} // RVA: 0xA599070
        public void GetPermission_ProfilePictureOverride(){} // RVA: 0xA5990F0
        public void GetPermission_MaximumUserIcons(){} // RVA: 0x151F890
        public void GetPermission_MaximumUserImages(){} // RVA: 0x151F890
        public void GetPermission_UseProps(){} // RVA: 0xA599170
        public void GetPermission_UploadProps(){} // RVA: 0xA5991F0
        public void GetPermission_TestProps(){} // RVA: 0xA599270
        public void Clear(){} // RVA: 0xA5992F0
        public void FetchPermissions(){} // RVA: 0xA599340
        public void .ctor(){} // RVA: 0xA599640
    }

    public class ApiVRChatSubscription[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ApiWorld : ApiModel
    {
        public object _VERSION;
        public object MIN_LOADABLE_VERSION;
        public object ListCacheTime;
        public object SingleRecordCacheTime;
        public object ADMIN_TAG_INTERNAL;
        public object localWorlds;
        public object LOCALIZED_INSTANCES_EXPERIMENT_KEY;
        public object _localizedInstancesExperimentState;
        public object _isLocalizedInstancesExperimentLoaded;
        public object _hasLocalizedInstancesExposureSent;
        public object LOCALIZED_INSTANCE_RATIO_TOLERANCE;
        public object _name;
        public object _imageUrl;
        public object _thumbnailImageUrl;
        public object _authorName;
        public object _releaseStatus;
        public object _capacity;
        public object _recommendedCapacity;
        public object _occupants;
        public object _publicOccupants;
        public object _privateOccupants;
        public object _authorId;
        public object _createdAt;
        public object _assetUrl;
        public object _description;
        public object _tags;
        public object _urlList;
        public object _unityPackageUrl;
        public object _version;
        public object _unityVersion;
        public object _apiVersion;
        public object _latestAssetVersion;
        public object _created_at;
        public object _updated_at;
        public object _publicationDate;
        public object _labsPublicationDate;
        public object _udonProducts;
        public object _storeId;
        public object _platform;
        public object mWorldInstances;
        public object _unityPackageUpdated;
        public object _organization;
        public object _shouldAddToAuthor;
        public object _favoriteId;
        public object _favorites;
        public object _visits;
        public object _popularity;
        public object _heat;
        public object _detailed;
        public object _defaultContentSettings;
        public object _bundleSignature;
        public object _isCurated;
        public object _safeUrlChars;

        // ── Methods ──
        public void get_VERSION(){} // RVA: 0xA59B430
        public void get_LocalizedInstancesExperimentState(){} // RVA: 0xA59B610
        public void ShouldCache(){} // RVA: 0xA59BA00
        public void GetLifeSpan(){} // RVA: 0xA59BA50
        public void get_name(){} // RVA: 0xBBFF90
        public void set_name(){} // RVA: 0xBBFFA0
        public void get_imageUrl(){} // RVA: 0xC10050
        public void set_imageUrl(){} // RVA: 0xC10060
        public void get_thumbnailImageUrl(){} // RVA: 0xCD3320
        public void set_thumbnailImageUrl(){} // RVA: 0xCD4740
        public void get_authorName(){} // RVA: 0xCD48B0
        public void set_authorName(){} // RVA: 0xCD3600
        public void get_releaseStatus(){} // RVA: 0xB813B0
        public void set_releaseStatus(){} // RVA: 0xD5CBB0
        public void get_capacity(){} // RVA: 0xF3A950
        public void set_capacity(){} // RVA: 0x17AFA20
        public void get_recommendedCapacity(){} // RVA: 0xF3A940
        public void set_recommendedCapacity(){} // RVA: 0x11A0AB0
        public void get_occupants(){} // RVA: 0x262A930
        public void set_occupants(){} // RVA: 0x262A900
        public void get_publicOccupants(){} // RVA: 0x262A910
        public void set_publicOccupants(){} // RVA: 0x262A920
        public void get_privateOccupants(){} // RVA: 0x262A8F0
        public void set_privateOccupants(){} // RVA: 0x262A940
        public void get_authorId(){} // RVA: 0x12EB090
        public void set_authorId(){} // RVA: 0x13B1040
        public void get_createdAt(){} // RVA: 0xBAE340
        public void set_createdAt(){} // RVA: 0x2443FC0
        public void get_assetUrl(){} // RVA: 0xBAE3B0
        public void set_assetUrl(){} // RVA: 0xBAE3C0
        public void get_description(){} // RVA: 0xBAE420
        public void set_description(){} // RVA: 0xBAE430
        public void get_tags(){} // RVA: 0xCA4D80
        public void set_tags(){} // RVA: 0xCA4D90
        public void get_urlList(){} // RVA: 0xC68EB0
        public void set_urlList(){} // RVA: 0xC68EC0
        public void get_unityPackageUrl(){} // RVA: 0x135D730
        public void set_unityPackageUrl(){} // RVA: 0xBC5AD0
        public void get_version(){} // RVA: 0x25C0CD0
        public void set_version(){} // RVA: 0x25C0CE0
        public void get_unityVersion(){} // RVA: 0xBC5BA0
        public void set_unityVersion(){} // RVA: 0xBC5BB0
        public void get_apiVersion(){} // RVA: 0x255B930
        public void set_apiVersion(){} // RVA: 0x6CE7A80
        public void get_latestAssetVersion(){} // RVA: 0x1AE9B20
        public void set_latestAssetVersion(){} // RVA: 0xA51A150
        public void get_created_at(){} // RVA: 0x135A7B0
        public void set_created_at(){} // RVA: 0xA51CD50
        public void get_updated_at(){} // RVA: 0x10B4170
        public void set_updated_at(){} // RVA: 0x1FDB9B0
        public void get_publicationDate(){} // RVA: 0x10B9D50
        public void set_publicationDate(){} // RVA: 0xD9D280
        public void get_labsPublicationDate(){} // RVA: 0xD9E3D0
        public void set_labsPublicationDate(){} // RVA: 0x6E3F2F0
        public void get_udonProducts(){} // RVA: 0xDA0520
        public void set_udonProducts(){} // RVA: 0xD9D570
        public void get_storeId(){} // RVA: 0x114AC20
        public void set_storeId(){} // RVA: 0x1149C90
        public void get_platform(){} // RVA: 0xE3C930
        public void set_platform(){} // RVA: 0xE3D020
        public void get_worldInstances(){} // RVA: 0x135EDB0
        public void get_isAdminApproved(){} // RVA: 0xA59BA60
        public void get_IsCommunityLabsWorld(){} // RVA: 0xA59BAE0
        public void get_IsPublicPublishedWorld(){} // RVA: 0xA59BB50
        public void get_IsInternalWorld(){} // RVA: 0xA59BBD0
        public void get_unityPackageUpdated(){} // RVA: 0x10B3C80
        public void set_unityPackageUpdated(){} // RVA: 0x10B4A80
        public void get_organization(){} // RVA: 0xBAE8F0
        public void set_organization(){} // RVA: 0xBAE900
        public void get_shouldAddToAuthor(){} // RVA: 0x2540EB0
        public void set_shouldAddToAuthor(){} // RVA: 0x6CE7AD0
        public void get_favoriteId(){} // RVA: 0x12CDBF0
        public void set_favoriteId(){} // RVA: 0x164A230
        public void get_favorites(){} // RVA: 0xA59BC30
        public void set_favorites(){} // RVA: 0x7DCDC90
        public void get_visits(){} // RVA: 0xA59BC40
        public void set_visits(){} // RVA: 0x7DCDCB0
        public void get_popularity(){} // RVA: 0x12CE890
        public void set_popularity(){} // RVA: 0x12CCFE0
        public void get_heat(){} // RVA: 0x79FAAB0
        public void set_heat(){} // RVA: 0x79FAAC0
        public void get_detailed(){} // RVA: 0x1E55000
        public void set_detailed(){} // RVA: 0x1EC9230
        public void get_defaultContentSettings(){} // RVA: 0x10F9C30
        public void set_defaultContentSettings(){} // RVA: 0x1659C50
        public void get_assetVersion(){} // RVA: 0xA59BC50
        public void set_assetVersion(){} // RVA: 0xA59BD00
        public void get_BundleSignature(){} // RVA: 0x10F9390
        public void set_BundleSignature(){} // RVA: 0x165AF80
        public void get_isCurated(){} // RVA: 0xA59BD90
        public void set_isCurated(){} // RVA: 0xA59BDA0
        public void get_publicTags(){} // RVA: 0xA59BDB0
        public void .ctor(){} // RVA: 0xA59BFB0
        public void ReadField(){} // RVA: 0xA59C1C0
        public void SetApiFieldsFromJson(){} // RVA: 0xA59C3A0
        public void ReadUnityPackages(){} // RVA: 0xA59C480
        public void ReadUnityPackage(){} // RVA: 0xA59CDF0
        public void WriteField(){} // RVA: 0xA59D4D0
        public void CopyDeserializedValuesTo(){} // RVA: 0xA59E350
        public void Save(){} // RVA: 0xA59E7B0
        public void Fetch(){} // RVA: 0xA59E960
        public void FetchList(){} // RVA: 0xA59F470
        public void FetchSearchResults(){} // RVA: 0xA59F920
        public void AddLocal(){} // RVA: 0xA59FE20
        public void get_IsLocal(){} // RVA: 0xA59FEF0
        public void SetLocal(){} // RVA: 0xA59FFD0
        public void ShouldNotBeVisibleOptional(){} // RVA: 0xA5A01A0
        public void GetBestInstance(){} // RVA: 0xA5A0560
        public void SendLocalizedInstancesExperimentExposure(){} // RVA: 0xA5A07D0
        public void SendLocalizedInstancesExperimentEvent(){} // RVA: 0xA5A0A90
        public void CreateNewInstanceAsync(){} // RVA: 0xA5A1260
        public void CreateNewInstance(){} // RVA: 0xA5A1630
        public void FetchUploadedWorlds(){} // RVA: 0xA5A1B20
        public void PublishWorldToCommunityLabs(){} // RVA: 0xA5A2010
        public void UpdateVersionAndPlatform(){} // RVA: 0xA5A2350
        public void MakeRequestEndpoint(){} // RVA: 0xA5A24C0
        public void Merge(){} // RVA: 0xA5A24E0
        public void .cctor(){} // RVA: 0xA5A2DB0
    }

    public class ApiWorldInstance : ApiModel
    {
        public object CacheTime;
        public object MAX_NAME_LENGTH;
        public object _location;
        public object _name;
        public object _shortName;
        public object _secureName;
        public object _displayName;
        public object _worldId;
        public object _instanceId;
        public object _world;
        public object _type;
        public object _ownerId;
        public object _tags;
        public object _count;
        public object _capacity;
        public object _recommendedCapacity;
        public object _platforms;
        public object _nonce;
        public object _clientVersion;
        public object _gameServerVersion;
        public object _region;
        public object _active;
        public object _queueEnabled;
        public object _hasCapacityForYou;
        public object _queueSize;
        public object _closedAt;
        public object _hardClose;
        public object _ageGate;
        public object _contentSettings;
        public object _playerPersistenceEnabled;
        public object _calendarEntryId;
        public object _hypeTrain;
        public object _users;
        public object _roleIds;
        public object _roleRestricted;
        public object _groupAccessType;
        public object _minimumAvatarPerformance;
        public object _languageRatioMap;
        public object _dominantLanguageCode;
        public object _lastPostTimeLock;
        public object _postInProgress;
        public object _lastPostTime;
        public object MinPostIntervalSeconds;
        public object MaxPostDelaySeconds;

        // ── Methods ──
        public void get_location(){} // RVA: 0xBBFF90
        public void set_location(){} // RVA: 0xBBFFA0
        public void get_name(){} // RVA: 0xC10050
        public void set_name(){} // RVA: 0xA5A89C0
        public void get_shortName(){} // RVA: 0xCD3320
        public void set_shortName(){} // RVA: 0xCD4740
        public void get_secureName(){} // RVA: 0xCD48B0
        public void set_secureName(){} // RVA: 0xCD3600
        public void get_displayName(){} // RVA: 0xB813B0
        public void set_displayName(){} // RVA: 0xD5CBB0
        public void get_worldId(){} // RVA: 0x1069350
        public void set_worldId(){} // RVA: 0xD5CC10
        public void get_instanceId(){} // RVA: 0x106A7D0
        public void set_instanceId(){} // RVA: 0xD5CC70
        public void get_world(){} // RVA: 0x106A050
        public void set_world(){} // RVA: 0xD5CCD0
        public void get_type(){} // RVA: 0x158C700
        public void set_type(){} // RVA: 0x158BEC0
        public void get_ownerId(){} // RVA: 0xBAE340
        public void set_ownerId(){} // RVA: 0xBAE350
        public void get_tags(){} // RVA: 0xBAE3B0
        public void set_tags(){} // RVA: 0xBAE3C0
        public void get_count(){} // RVA: 0xE35F30
        public void set_count(){} // RVA: 0xE3CFA0
        public void get_capacity(){} // RVA: 0x485F8A0
        public void set_capacity(){} // RVA: 0x485F8B0
        public void get_recommendedCapacity(){} // RVA: 0x12CE7D0
        public void set_recommendedCapacity(){} // RVA: 0x421A240
        public void get_platforms(){} // RVA: 0xC68EB0
        public void set_platforms(){} // RVA: 0xC68EC0
        public void get_nonce(){} // RVA: 0x135D730
        public void set_nonce(){} // RVA: 0xBC5AD0
        public void get_clientVersion(){} // RVA: 0xBC5B30
        public void set_clientVersion(){} // RVA: 0xBC5B40
        public void get_gameServerVersion(){} // RVA: 0x485FD30
        public void set_gameServerVersion(){} // RVA: 0x485FD40
        public void get_region(){} // RVA: 0x255B920
        public void set_region(){} // RVA: 0x6CE7A70
        public void get_active(){} // RVA: 0xBC5D20
        public void set_active(){} // RVA: 0xBC5D30
        public void get_queueEnabled(){} // RVA: 0x21656F0
        public void set_queueEnabled(){} // RVA: 0x216AB00
        public void get_hasCapacityForYou(){} // RVA: 0x6A621D0
        public void set_hasCapacityForYou(){} // RVA: 0x6A621E0
        public void get_queueSize(){} // RVA: 0x1AE9B20
        public void set_queueSize(){} // RVA: 0xA51A150
        public void get_closedAt(){} // RVA: 0x135A7B0
        public void set_closedAt(){} // RVA: 0xA51CD50
        public void get_hardClose(){} // RVA: 0x2443BA0
        public void set_hardClose(){} // RVA: 0x2443BB0
        public void get_ageGate(){} // RVA: 0x24440E0
        public void set_ageGate(){} // RVA: 0x2443E20
        public void get_contentSettings(){} // RVA: 0x10B9D50
        public void set_contentSettings(){} // RVA: 0x15B7570
        public void get_IsClosed(){} // RVA: 0xA5A8B10
        public void get_IsAgeGated(){} // RVA: 0xA5A8C30
        public void get_playerPersistenceEnabled(){} // RVA: 0x1184420
        public void set_playerPersistenceEnabled(){} // RVA: 0x1EBEA50
        public void get_calendarEntryId(){} // RVA: 0xDA0520
        public void set_calendarEntryId(){} // RVA: 0xD9D570
        public void get_hypeTrain(){} // RVA: 0x114AC20
        public void set_hypeTrain(){} // RVA: 0x1149C90
        public void get_users(){} // RVA: 0xE3C930
        public void set_users(){} // RVA: 0xE3D020
        public void get_ShouldSeeInstanceByType(){} // RVA: 0xA5A8D80
        public void get_roleIds(){} // RVA: 0x135EDB0
        public void set_roleIds(){} // RVA: 0x1658000
        public void get_roleRestricted(){} // RVA: 0x10B3C80
        public void set_roleRestricted(){} // RVA: 0x10B4A80
        public void get_groupAccessType(){} // RVA: 0xBAE8F0
        public void set_groupAccessType(){} // RVA: 0xBAE900
        public void get_minimumAvatarPerformance(){} // RVA: 0xBAE960
        public void set_minimumAvatarPerformance(){} // RVA: 0xBAE970
        public void get_languageRatioMap(){} // RVA: 0x12CDBF0
        public void set_languageRatioMap(){} // RVA: 0x164A230
        public void get_dominantLanguageCode(){} // RVA: 0x1661250
        public void set_dominantLanguageCode(){} // RVA: 0x166A5F0
        public void get_id(){} // RVA: 0xBBFF90
        public void set_id(){} // RVA: 0xA5A8EA0
        public void .ctor(){} // RVA: 0xA5A9290
        public void Init(){} // RVA: 0xA5A92D0
        public void Get(){} // RVA: 0xA5A9B00
        public void MakeRequestEndpoint(){} // RVA: 0xA5A9D90
        public void SetInstanceAccessTypeFromId(){} // RVA: 0xA5A9E00
        public void ExtractInfoFromLocation(){} // RVA: 0xA5AA070
        public void BuildRequest(){} // RVA: 0xA5AA770
        public void GetLifeSpan(){} // RVA: 0xA5AAE90
        public void ReadField(){} // RVA: 0xA5AAEA0
        public void WriteField(){} // RVA: 0xA5AB230
        public void SetApiFieldsFromJson(){} // RVA: 0xA5AB3F0
        public void ParseTags(){} // RVA: 0xA5AB490
        public void ToString(){} // RVA: 0xA5AB740
        public void GetShortName(){} // RVA: 0xA5AB7F0
        public void get_ProbablyExistsOnAPI(){} // RVA: 0xA5ABB90
        public void CreateOrFetch(){} // RVA: 0xA5ABD80
        public void CreateOrFetchAsync(){} // RVA: 0xA5AC1F0
        public void CreateOrFetchAsyncInternal(){} // RVA: 0xA5AC3C0
        public void .cctor(){} // RVA: 0xA5AC5E0
        public void <get_ProbablyExistsOnAPI>b__177_0(){} // RVA: 0xA5AC6B0
    }

    public class ApiWorldInstance[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class AreaBase : Object
    {
        // ── Methods ──
        public void get_Endpoint(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AssetVersion : Object
    {
        public object _unityVersion;
        public object _unityVersionObj;
        public object _apiVersion;

        // ── Methods ──
        public void get_UnityVersion(){} // RVA: 0xA5BD840
        public void set_UnityVersion(){} // RVA: 0xB44D60
        public void get_UnityVersionObj(){} // RVA: 0xA5BD8F0
        public void get_ApiVersion(){} // RVA: 0x1AE5AC0
        public void set_ApiVersion(){} // RVA: 0x23E55F0
        public void .ctor(){} // RVA: 0xA5BDAB0
        public void ToString(){} // RVA: 0xA5BDB10
    }

}