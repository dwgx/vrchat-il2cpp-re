// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 95
// Methods: 403

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Matchmaking : Object
    {
        // ── Methods ──
        public void ReportResultsInsecure(){} // RVA: 0x7FFE86C080B0
        public void GetStats(){} // RVA: 0x7FFE86C08710
        public void Browse(){} // RVA: 0x7FFE86C08960
        public void Browse2(){} // RVA: 0x7FFE86C08BB0
        public void Cancel(){} // RVA: 0x7FFE86C09040 | overloaded x2
        public void CreateAndEnqueueRoom(){} // RVA: 0x7FFE86C091E0
        public void CreateAndEnqueueRoom2(){} // RVA: 0x7FFE86C09460
        public void CreateRoom(){} // RVA: 0x7FFE86C096A0
        public void CreateRoom2(){} // RVA: 0x7FFE86C098F0
        public void Enqueue(){} // RVA: 0x7FFE86C09B30
        public void Enqueue2(){} // RVA: 0x7FFE86C09D80
        public void EnqueueRoom(){} // RVA: 0x7FFE86C09FC0
        public void EnqueueRoom2(){} // RVA: 0x7FFE86C0A1A0
        public void GetAdminSnapshot(){} // RVA: 0x7FFE86C0A370
        public void JoinRoom(){} // RVA: 0x7FFE86C0A520
        public void StartMatch(){} // RVA: 0x7FFE86C0A6F0
        public void SetMatchFoundNotificationCallback(){} // RVA: 0x7FFE86C0A890
    }

    public class MatchmakingOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF51E0
        public void SetCreateRoomDataStore(){} // RVA: 0x7FFE86BF5290
        public void ClearCreateRoomDataStore(){} // RVA: 0x7FFE86BF5400
        public void SetCreateRoomJoinPolicy(){} // RVA: 0x7FFE86BF54C0
        public void SetCreateRoomMaxUsers(){} // RVA: 0x7FFE86BF5580
        public void AddEnqueueAdditionalUser(){} // RVA: 0x7FFE86BF5640
        public void ClearEnqueueAdditionalUsers(){} // RVA: 0x7FFE86BF5710
        public void SetEnqueueDataSettings(){} // RVA: 0x7FFE86BF5A70 | overloaded x3
        public void ClearEnqueueDataSettings(){} // RVA: 0x7FFE86BF5BE0
        public void SetEnqueueIsDebug(){} // RVA: 0x7FFE86BF5CA0
        public void SetEnqueueQueryKey(){} // RVA: 0x7FFE86BF5D60
        public void op_Explicit(){} // RVA: 0x7FFE86BC25E0
        public void Finalize(){} // RVA: 0x7FFE86BF5EA0
    }

    public class Media : Object
    {
        // ── Methods ──
        public void ShareToFacebook(){} // RVA: 0x7FFE86C19AB0
    }

    public class Message : Object
    {
        public dFixup.legate type; // 0x10
        public ulong requestID; // 0x18
        public Oculus.Platform.Models.Error error; // 0x20
        public ExtraMessageTypesHandler _handleExtraMessageTypes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF5F90
        public void Finalize(){} // RVA: 0x7FFE81D7E0B0
        public void get_Type(){} // RVA: 0x7FFE811485C0
        public void get_IsError(){} // RVA: 0x7FFE82BC81D0
        public void get_RequestID(){} // RVA: 0x7FFE810FE7C0
        public void GetError(){} // RVA: 0x7FFE811290C0
        public void GetPingResult(){} // RVA: 0x7FFE813240E0
        public void GetNetworkingPeer(){} // RVA: 0x7FFE813240E0
        public void GetHttpTransferUpdate(){} // RVA: 0x7FFE813240E0
        public void GetPlatformInitialize(){} // RVA: 0x7FFE813240E0
        public void GetAbuseReportRecording(){} // RVA: 0x7FFE813240E0
        public void GetAchievementDefinitions(){} // RVA: 0x7FFE813240E0
        public void GetAchievementProgressList(){} // RVA: 0x7FFE813240E0
        public void GetAchievementUpdate(){} // RVA: 0x7FFE813240E0
        public void GetApplicationInviteList(){} // RVA: 0x7FFE813240E0
        public void GetApplicationVersion(){} // RVA: 0x7FFE813240E0
        public void GetAssetDetails(){} // RVA: 0x7FFE813240E0
        public void GetAssetDetailsList(){} // RVA: 0x7FFE813240E0
        public void GetAssetFileDeleteResult(){} // RVA: 0x7FFE813240E0
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x7FFE813240E0
        public void GetAssetFileDownloadResult(){} // RVA: 0x7FFE813240E0
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x7FFE813240E0
        public void GetAvatarEditorResult(){} // RVA: 0x7FFE813240E0
        public void GetBlockedUserList(){} // RVA: 0x7FFE813240E0
        public void GetCalApplicationFinalized(){} // RVA: 0x7FFE813240E0
        public void GetCalApplicationProposed(){} // RVA: 0x7FFE813240E0
        public void GetCalApplicationSuggestionList(){} // RVA: 0x7FFE813240E0
        public void GetChallenge(){} // RVA: 0x7FFE813240E0
        public void GetChallengeEntryList(){} // RVA: 0x7FFE813240E0
        public void GetChallengeList(){} // RVA: 0x7FFE813240E0
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x7FFE813240E0
        public void GetCloudStorageData(){} // RVA: 0x7FFE813240E0
        public void GetCloudStorageMetadata(){} // RVA: 0x7FFE813240E0
        public void GetCloudStorageMetadataList(){} // RVA: 0x7FFE813240E0
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x7FFE813240E0
        public void GetDataStore(){} // RVA: 0x7FFE813240E0
        public void GetDestinationList(){} // RVA: 0x7FFE813240E0
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x7FFE813240E0
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x7FFE813240E0
        public void GetInstalledApplicationList(){} // RVA: 0x7FFE813240E0
        public void GetInvitePanelResultInfo(){} // RVA: 0x7FFE813240E0
        public void GetLaunchBlockFlowResult(){} // RVA: 0x7FFE813240E0
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x7FFE813240E0
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x7FFE813240E0
        public void GetLaunchReportFlowResult(){} // RVA: 0x7FFE813240E0
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x7FFE813240E0
        public void GetLeaderboardDidUpdate(){} // RVA: 0x7FFE810FB320
        public void GetLeaderboardEntryList(){} // RVA: 0x7FFE813240E0
        public void GetLeaderboardList(){} // RVA: 0x7FFE813240E0
        public void GetLinkedAccountList(){} // RVA: 0x7FFE813240E0
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x7FFE813240E0
        public void GetLivestreamingStartResult(){} // RVA: 0x7FFE813240E0
        public void GetLivestreamingStatus(){} // RVA: 0x7FFE813240E0
        public void GetLivestreamingVideoStats(){} // RVA: 0x7FFE813240E0
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x7FFE813240E0
        public void GetMatchmakingBrowseResult(){} // RVA: 0x7FFE813240E0
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7FFE813240E0
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7FFE813240E0
        public void GetMatchmakingStats(){} // RVA: 0x7FFE813240E0
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x7FFE813240E0
        public void GetNetSyncConnection(){} // RVA: 0x7FFE813240E0
        public void GetNetSyncSessionList(){} // RVA: 0x7FFE813240E0
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x7FFE813240E0
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7FFE813240E0
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x7FFE813240E0
        public void GetOrgScopedID(){} // RVA: 0x7FFE813240E0
        public void GetParty(){} // RVA: 0x7FFE813240E0
        public void GetPartyID(){} // RVA: 0x7FFE813240E0
        public void GetPartyUpdateNotification(){} // RVA: 0x7FFE813240E0
        public void GetPidList(){} // RVA: 0x7FFE813240E0
        public void GetProductList(){} // RVA: 0x7FFE813240E0
        public void GetPurchase(){} // RVA: 0x7FFE813240E0
        public void GetPurchaseList(){} // RVA: 0x7FFE813240E0
        public void GetRejoinDialogResult(){} // RVA: 0x7FFE813240E0
        public void GetRoom(){} // RVA: 0x7FFE813240E0
        public void GetRoomInviteNotification(){} // RVA: 0x7FFE813240E0
        public void GetRoomInviteNotificationList(){} // RVA: 0x7FFE813240E0
        public void GetRoomList(){} // RVA: 0x7FFE813240E0
        public void GetSdkAccountList(){} // RVA: 0x7FFE813240E0
        public void GetSendInvitesResult(){} // RVA: 0x7FFE813240E0
        public void GetShareMediaResult(){} // RVA: 0x7FFE813240E0
        public void GetString(){} // RVA: 0x7FFE813240E0
        public void GetSystemVoipState(){} // RVA: 0x7FFE813240E0
        public void GetUser(){} // RVA: 0x7FFE813240E0
        public void GetUserAndRoomList(){} // RVA: 0x7FFE813240E0
        public void GetUserCapabilityList(){} // RVA: 0x7FFE813240E0
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x7FFE813240E0
        public void GetUserList(){} // RVA: 0x7FFE813240E0
        public void GetUserProof(){} // RVA: 0x7FFE813240E0
        public void GetUserReportID(){} // RVA: 0x7FFE813240E0
        public void ParseMessageHandle(){} // RVA: 0x7FFE86BF63B0
        public void PopMessage(){} // RVA: 0x7FFE86BF8B90
        public void set_HandleExtraMessageTypes(){} // RVA: 0x7FFE86BF8D40
        public void get_HandleExtraMessageTypes(){} // RVA: 0x7FFE86BF8DE0
    }

    public class MessageWithAbuseReportRecording : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF8FA0
        public void GetAbuseReportRecording(){} // RVA: 0x7FFE86BF8FF0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BF9030
    }

    public class MessageWithAchievementDefinitions : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF9250
        public void GetAchievementDefinitions(){} // RVA: 0x7FFE86BF92A0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BF92E0
    }

    public class MessageWithAchievementProgressList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF93E0
        public void GetAchievementProgressList(){} // RVA: 0x7FFE86BF9430
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BF9470
    }

    public class MessageWithAchievementUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF9570
        public void GetAchievementUpdate(){} // RVA: 0x7FFE86BF95C0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BF9600
    }

    public class MessageWithApplicationInviteList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF9880
        public void GetApplicationInviteList(){} // RVA: 0x7FFE86BF98D0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BF9910
    }

    public class MessageWithApplicationVersion : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF9A10
        public void GetApplicationVersion(){} // RVA: 0x7FFE86BF9A60
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BF9AA0
    }

    public class MessageWithAssetDetails : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF9BA0
        public void GetAssetDetails(){} // RVA: 0x7FFE86BF9BF0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BF9C30
    }

    public class MessageWithAssetDetailsList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF9D30
        public void GetAssetDetailsList(){} // RVA: 0x7FFE86BF9D80
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BF9DC0
    }

    public class MessageWithAssetFileDeleteResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BF9EC0
        public void GetAssetFileDeleteResult(){} // RVA: 0x7FFE86BF9F10
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BF9F50
    }

    public class MessageWithAssetFileDownloadCancelResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFA050
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x7FFE86BFA0A0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFA0E0
    }

    public class MessageWithAssetFileDownloadResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFA1E0
        public void GetAssetFileDownloadResult(){} // RVA: 0x7FFE86BFA230
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFA270
    }

    public class MessageWithAssetFileDownloadUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFA4E0
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x7FFE86BFA530
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFA570
    }

    public class MessageWithAvatarEditorResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFA880
        public void GetAvatarEditorResult(){} // RVA: 0x7FFE86BFA8D0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFA910
    }

    public class MessageWithBlockedUserList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFAAB0
        public void GetBlockedUserList(){} // RVA: 0x7FFE86BFAB00
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFAB40
    }

    public class MessageWithCalApplicationFinalized : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFAC40
        public void GetCalApplicationFinalized(){} // RVA: 0x7FFE86BFAC90
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFACD0
    }

    public class MessageWithCalApplicationProposed : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFAFA0
        public void GetCalApplicationProposed(){} // RVA: 0x7FFE86BFAFF0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFB030
    }

    public class MessageWithCalApplicationSuggestionList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFB1C0
        public void GetCalApplicationSuggestionList(){} // RVA: 0x7FFE86BFB210
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFB250
    }

    public class MessageWithChallenge : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFB350
        public void GetChallenge(){} // RVA: 0x7FFE86BFB3A0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFB3E0
    }

    public class MessageWithChallengeEntryList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFB670
        public void GetChallengeEntryList(){} // RVA: 0x7FFE86BFB6C0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFB700
    }

    public class MessageWithChallengeList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFB4E0
        public void GetChallengeList(){} // RVA: 0x7FFE86BFB530
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFB570
    }

    public class MessageWithCloudStorageConflictMetadata : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFB800
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x7FFE86BFB850
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFB890
    }

    public class MessageWithCloudStorageData : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFB990
        public void GetCloudStorageData(){} // RVA: 0x7FFE86BFB9E0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFBA20
    }

    public class MessageWithCloudStorageMetadataList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFBCB0
        public void GetCloudStorageMetadataList(){} // RVA: 0x7FFE86BFBD00
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFBD40
    }

    public class MessageWithCloudStorageMetadataUnderLocal : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFBB20
        public void GetCloudStorageMetadata(){} // RVA: 0x7FFE86BFBB70
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFBBB0
    }

    public class MessageWithCloudStorageUpdateResponse : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFBE40
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x7FFE86BFBE90
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFBED0
    }

    public class MessageWithDataStoreUnderPrivateUserDataStore : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFBFD0
        public void GetDataStore(){} // RVA: 0x7FFE86BFC020
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFC060
    }

    public class MessageWithDataStoreUnderPublicUserDataStore : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFC0D0
        public void GetDataStore(){} // RVA: 0x7FFE86BFC120
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFC160
    }

    public class MessageWithDestinationList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFC1D0
        public void GetDestinationList(){} // RVA: 0x7FFE86BFC220
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFC260
    }

    public class MessageWithGroupPresenceJoinIntent : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFC360
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x7FFE86BFC3B0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFC3F0
    }

    public class MessageWithGroupPresenceLeaveIntent : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFC4F0
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x7FFE86BFC540
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFC580
    }

    public class MessageWithHttpTransferUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C03200
        public void GetHttpTransferUpdate(){} // RVA: 0x7FFE86C03250
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C03290
    }

    public class MessageWithInstalledApplicationList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFC680
        public void GetInstalledApplicationList(){} // RVA: 0x7FFE86BFC6D0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFC710
    }

    public class MessageWithInvitePanelResultInfo : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFC810
        public void GetInvitePanelResultInfo(){} // RVA: 0x7FFE86BFC860
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFC8A0
    }

    public class MessageWithLaunchBlockFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFCA40
        public void GetLaunchBlockFlowResult(){} // RVA: 0x7FFE86BFCA90
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFCAD0
    }

    public class MessageWithLaunchFriendRequestFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFCCC0
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x7FFE86BFCD10
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFCD50
    }

    public class MessageWithLaunchInvitePanelFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFCF40
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x7FFE86BFCF90
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFCFD0
    }

    public class MessageWithLaunchReportFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFD1E0
        public void GetLaunchReportFlowResult(){} // RVA: 0x7FFE86BFD230
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFD270
    }

    public class MessageWithLaunchUnblockFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFD460
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x7FFE86BFD4B0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFD4F0
    }

    public class MessageWithLeaderboardDidUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C02CF0
        public void GetLeaderboardDidUpdate(){} // RVA: 0x7FFE86C02D70
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C02DB0
    }

    public class MessageWithLeaderboardEntryList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFD870
        public void GetLeaderboardEntryList(){} // RVA: 0x7FFE86BFD8C0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFD900
    }

    public class MessageWithLeaderboardList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFD6E0
        public void GetLeaderboardList(){} // RVA: 0x7FFE86BFD730
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFD770
    }

    public class MessageWithLinkedAccountList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFDA00
        public void GetLinkedAccountList(){} // RVA: 0x7FFE86BFDA50
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFDA90
    }

    public class MessageWithLivestreamingApplicationStatus : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFDB90
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x7FFE86BFDBE0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFDC20
    }

    public class MessageWithLivestreamingStartResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFDDC0
        public void GetLivestreamingStartResult(){} // RVA: 0x7FFE86BFDE10
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFDE50
    }

    public class MessageWithLivestreamingStatus : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFDFE0
        public void GetLivestreamingStatus(){} // RVA: 0x7FFE86BFE030
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFE070
    }

    public class MessageWithLivestreamingVideoStats : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFE170
        public void GetLivestreamingVideoStats(){} // RVA: 0x7FFE86BFE1C0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFE200
    }

    public class MessageWithMatchmakingAdminSnapshot : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFE4D0
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x7FFE86BFE520
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFE560
    }

    public class MessageWithMatchmakingBrowseResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C03010
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7FFE86C03060
        public void GetRoomList(){} // RVA: 0x7FFE86C030B0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C03100
    }

    public class MessageWithMatchmakingEnqueueResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFE660
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7FFE86BFE6B0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFE6F0
    }

    public class MessageWithMatchmakingEnqueueResultAndRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFE7F0
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7FFE86BFE840
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFE880
    }

    public class MessageWithMatchmakingNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C02EE0
        public void GetRoom(){} // RVA: 0x7FFE86C02F30
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C02F70
    }

    public class MessageWithMatchmakingStatsUnderMatchmakingStats : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFE980
        public void GetMatchmakingStats(){} // RVA: 0x7FFE86BFE9D0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFEA10
    }

    public class MessageWithMicrophoneAvailabilityState : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFEB10
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x7FFE86BFEB60
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFEBA0
    }

    public class MessageWithNetSyncConnection : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFED40
        public void GetNetSyncConnection(){} // RVA: 0x7FFE86BFED90
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFEDD0
    }

    public class MessageWithNetSyncSessionList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFEED0
        public void GetNetSyncSessionList(){} // RVA: 0x7FFE86BFEF20
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFEF60
    }

    public class MessageWithNetSyncSessionsChangedNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFF060
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x7FFE86BFF0B0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFF0F0
    }

    public class MessageWithNetSyncSetSessionPropertyResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFF360
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7FFE86BFF3B0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFF3F0
    }

    public class MessageWithNetSyncVoipAttenuationValueList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFF600
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x7FFE86BFF650
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFF690
    }

    public class MessageWithNetworkingPeer : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C027C0
        public void GetNetworkingPeer(){} // RVA: 0x7FFE86C02810
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C02850
    }

    public class MessageWithOrgScopedID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFF790
        public void GetOrgScopedID(){} // RVA: 0x7FFE86BFF7E0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFF820
    }

    public class MessageWithParty : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFF9B0
        public void GetParty(){} // RVA: 0x7FFE86BFFA00
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFFA40
    }

    public class MessageWithPartyID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFFC10
        public void GetPartyID(){} // RVA: 0x7FFE86BFFC60
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFFCA0
    }

    public class MessageWithPartyUnderCurrentParty : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFFAE0
        public void GetParty(){} // RVA: 0x7FFE86BFFB30
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFFB70
    }

    public class MessageWithPartyUpdateNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFFE30
        public void GetPartyUpdateNotification(){} // RVA: 0x7FFE86BFFE80
        public void GetDataFromMessage(){} // RVA: 0x7FFE86BFFEC0
    }

    public class MessageWithPidList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86BFFFC0
        public void GetPidList(){} // RVA: 0x7FFE86C00010
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C00050
    }

    public class MessageWithPingResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C02A00
        public void GetPingResult(){} // RVA: 0x7FFE86C02A50
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C02A90
    }

    public class MessageWithPlatformInitialize : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C03390
        public void GetPlatformInitialize(){} // RVA: 0x7FFE86C033E0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C03420
    }

    public class MessageWithProductList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C00150
        public void GetProductList(){} // RVA: 0x7FFE86C001A0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C001E0
    }

    public class MessageWithPurchase : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C002E0
        public void GetPurchase(){} // RVA: 0x7FFE86C00330
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C00370
    }

    public class MessageWithPurchaseList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C00470
        public void GetPurchaseList(){} // RVA: 0x7FFE86C004C0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C00500
    }

    public class MessageWithRejoinDialogResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C00600
        public void GetRejoinDialogResult(){} // RVA: 0x7FFE86C00650
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C00690
    }

    public class MessageWithRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C00830
        public void GetRoom(){} // RVA: 0x7FFE86C00880
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C008C0
    }

    public class MessageWithRoomInviteNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C00D50
        public void GetRoomInviteNotification(){} // RVA: 0x7FFE86C00DA0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C00DE0
    }

    public class MessageWithRoomInviteNotificationList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C00EE0
        public void GetRoomInviteNotificationList(){} // RVA: 0x7FFE86C00F30
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C00F70
    }

    public class MessageWithRoomList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C00BC0
        public void GetRoomList(){} // RVA: 0x7FFE86C00C10
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C00C50
    }

    public class MessageWithRoomUnderCurrentRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C00960
        public void GetRoom(){} // RVA: 0x7FFE86C009B0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C009F0
    }

    public class MessageWithRoomUnderViewerRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C00A90
        public void GetRoom(){} // RVA: 0x7FFE86C00AE0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C00B20
    }

    public class MessageWithSdkAccountList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C01070
        public void GetSdkAccountList(){} // RVA: 0x7FFE86C010C0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C01100
    }

    public class MessageWithSendInvitesResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C01200
        public void GetSendInvitesResult(){} // RVA: 0x7FFE86C01250
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C01290
    }

    public class MessageWithShareMediaResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C014A0
        public void GetShareMediaResult(){} // RVA: 0x7FFE86C014F0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C01530
    }

    public class MessageWithString : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C016C0
        public void GetString(){} // RVA: 0x7FFE86C01710
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C01750
    }

    public class MessageWithSystemVoipState : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C017A0
        public void GetSystemVoipState(){} // RVA: 0x7FFE86C017F0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C01830
    }

    public class MessageWithUser : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C01A20
        public void GetUser(){} // RVA: 0x7FFE86C01A70
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C01AB0
    }

    public class MessageWithUserAndRoomList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C01BB0
        public void GetUserAndRoomList(){} // RVA: 0x7FFE86C01C00
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C01C40
    }

    public class MessageWithUserCapabilityList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C01ED0
        public void GetUserCapabilityList(){} // RVA: 0x7FFE86C01F20
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C01F60
    }

    public class MessageWithUserDataStoreUpdateResponse : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C02060
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x7FFE86C020B0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C020F0
    }

    public class MessageWithUserList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C01D40
        public void GetUserList(){} // RVA: 0x7FFE86C01D90
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C01DD0
    }

    public class MessageWithUserProof : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C02290
        public void GetUserProof(){} // RVA: 0x7FFE86C022E0
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C02320
    }

    public class MessageWithUserReportID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C02540
        public void GetUserReportID(){} // RVA: 0x7FFE86C02590
        public void GetDataFromMessage(){} // RVA: 0x7FFE86C025D0
    }

    public class Message`1 : Message
    {
        public T data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46250
        public void get_Data(){} // RVA: 0x7FFE810A1420
        public void GetDataFromMessage(){} // RVA: 0x7FFE810A1420
    }

    public class MultiplayerErrorOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86C035B0
        public void SetErrorKey(){} // RVA: 0x7FFE86C03660
        public void op_Explicit(){} // RVA: 0x7FFE86BC25E0
        public void Finalize(){} // RVA: 0x7FFE86C03720
    }

}