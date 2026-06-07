// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 95
// Methods: 403

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Matchmaking
    {
        // ── Methods ──
        public void ReportResultsInsecure(){} // RVA: 0x60C72E0
        public void GetStats(){} // RVA: 0x60C7940
        public void Browse(){} // RVA: 0x60C7B90
        public void Browse2(){} // RVA: 0x60C7DE0
        public void Cancel(){} // RVA: 0x60C8270 | overloaded x2
        public void CreateAndEnqueueRoom(){} // RVA: 0x60C8410
        public void CreateAndEnqueueRoom2(){} // RVA: 0x60C8690
        public void CreateRoom(){} // RVA: 0x60C88D0
        public void CreateRoom2(){} // RVA: 0x60C8B20
        public void Enqueue(){} // RVA: 0x60C8D60
        public void Enqueue2(){} // RVA: 0x60C8FB0
        public void EnqueueRoom(){} // RVA: 0x60C91F0
        public void EnqueueRoom2(){} // RVA: 0x60C93D0
        public void GetAdminSnapshot(){} // RVA: 0x60C95A0
        public void JoinRoom(){} // RVA: 0x60C9750
        public void StartMatch(){} // RVA: 0x60C9920
        public void SetMatchFoundNotificationCallback(){} // RVA: 0x60C9AC0
    }

    public class MatchmakingOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B4410
        public void SetCreateRoomDataStore(){} // RVA: 0x60B44C0
        public void ClearCreateRoomDataStore(){} // RVA: 0x60B4630
        public void SetCreateRoomJoinPolicy(){} // RVA: 0x60B46F0
        public void SetCreateRoomMaxUsers(){} // RVA: 0x60B47B0
        public void AddEnqueueAdditionalUser(){} // RVA: 0x60B4870
        public void ClearEnqueueAdditionalUsers(){} // RVA: 0x60B4940
        public void SetEnqueueDataSettings(){} // RVA: 0x60B4CA0 | overloaded x3
        public void ClearEnqueueDataSettings(){} // RVA: 0x60B4E10
        public void SetEnqueueIsDebug(){} // RVA: 0x60B4ED0
        public void SetEnqueueQueryKey(){} // RVA: 0x60B4F90
        public void op_Explicit(){} // RVA: 0x6081810
        public void Finalize(){} // RVA: 0x60B50D0
    }

    public class Media
    {
        // ── Methods ──
        public void ShareToFacebook(){} // RVA: 0x60D8CE0
    }

    public class Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B51C0
        public void Finalize(){} // RVA: 0x1007BA0
        public void get_Type(){} // RVA: 0x32A5C0
        public void get_IsError(){} // RVA: 0x1E3EC10
        public void get_RequestID(){} // RVA: 0x2E07C0
        public void GetError(){} // RVA: 0x30B0C0
        public void GetPingResult(){} // RVA: 0x519240
        public void GetNetworkingPeer(){} // RVA: 0x519240
        public void GetHttpTransferUpdate(){} // RVA: 0x519240
        public void GetPlatformInitialize(){} // RVA: 0x519240
        public void GetAbuseReportRecording(){} // RVA: 0x519240
        public void GetAchievementDefinitions(){} // RVA: 0x519240
        public void GetAchievementProgressList(){} // RVA: 0x519240
        public void GetAchievementUpdate(){} // RVA: 0x519240
        public void GetApplicationInviteList(){} // RVA: 0x519240
        public void GetApplicationVersion(){} // RVA: 0x519240
        public void GetAssetDetails(){} // RVA: 0x519240
        public void GetAssetDetailsList(){} // RVA: 0x519240
        public void GetAssetFileDeleteResult(){} // RVA: 0x519240
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x519240
        public void GetAssetFileDownloadResult(){} // RVA: 0x519240
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x519240
        public void GetAvatarEditorResult(){} // RVA: 0x519240
        public void GetBlockedUserList(){} // RVA: 0x519240
        public void GetCalApplicationFinalized(){} // RVA: 0x519240
        public void GetCalApplicationProposed(){} // RVA: 0x519240
        public void GetCalApplicationSuggestionList(){} // RVA: 0x519240
        public void GetChallenge(){} // RVA: 0x519240
        public void GetChallengeEntryList(){} // RVA: 0x519240
        public void GetChallengeList(){} // RVA: 0x519240
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x519240
        public void GetCloudStorageData(){} // RVA: 0x519240
        public void GetCloudStorageMetadata(){} // RVA: 0x519240
        public void GetCloudStorageMetadataList(){} // RVA: 0x519240
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x519240
        public void GetDataStore(){} // RVA: 0x519240
        public void GetDestinationList(){} // RVA: 0x519240
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x519240
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x519240
        public void GetInstalledApplicationList(){} // RVA: 0x519240
        public void GetInvitePanelResultInfo(){} // RVA: 0x519240
        public void GetLaunchBlockFlowResult(){} // RVA: 0x519240
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x519240
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x519240
        public void GetLaunchReportFlowResult(){} // RVA: 0x519240
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x519240
        public void GetLeaderboardDidUpdate(){} // RVA: 0x2DD320
        public void GetLeaderboardEntryList(){} // RVA: 0x519240
        public void GetLeaderboardList(){} // RVA: 0x519240
        public void GetLinkedAccountList(){} // RVA: 0x519240
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x519240
        public void GetLivestreamingStartResult(){} // RVA: 0x519240
        public void GetLivestreamingStatus(){} // RVA: 0x519240
        public void GetLivestreamingVideoStats(){} // RVA: 0x519240
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x519240
        public void GetMatchmakingBrowseResult(){} // RVA: 0x519240
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x519240
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x519240
        public void GetMatchmakingStats(){} // RVA: 0x519240
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x519240
        public void GetNetSyncConnection(){} // RVA: 0x519240
        public void GetNetSyncSessionList(){} // RVA: 0x519240
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x519240
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x519240
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x519240
        public void GetOrgScopedID(){} // RVA: 0x519240
        public void GetParty(){} // RVA: 0x519240
        public void GetPartyID(){} // RVA: 0x519240
        public void GetPartyUpdateNotification(){} // RVA: 0x519240
        public void GetPidList(){} // RVA: 0x519240
        public void GetProductList(){} // RVA: 0x519240
        public void GetPurchase(){} // RVA: 0x519240
        public void GetPurchaseList(){} // RVA: 0x519240
        public void GetRejoinDialogResult(){} // RVA: 0x519240
        public void GetRoom(){} // RVA: 0x519240
        public void GetRoomInviteNotification(){} // RVA: 0x519240
        public void GetRoomInviteNotificationList(){} // RVA: 0x519240
        public void GetRoomList(){} // RVA: 0x519240
        public void GetSdkAccountList(){} // RVA: 0x519240
        public void GetSendInvitesResult(){} // RVA: 0x519240
        public void GetShareMediaResult(){} // RVA: 0x519240
        public void GetString(){} // RVA: 0x519240
        public void GetSystemVoipState(){} // RVA: 0x519240
        public void GetUser(){} // RVA: 0x519240
        public void GetUserAndRoomList(){} // RVA: 0x519240
        public void GetUserCapabilityList(){} // RVA: 0x519240
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x519240
        public void GetUserList(){} // RVA: 0x519240
        public void GetUserProof(){} // RVA: 0x519240
        public void GetUserReportID(){} // RVA: 0x519240
        public void ParseMessageHandle(){} // RVA: 0x60B55E0
        public void PopMessage(){} // RVA: 0x60B7DC0
        public void set_HandleExtraMessageTypes(){} // RVA: 0x60B7F70
        public void get_HandleExtraMessageTypes(){} // RVA: 0x60B8010
    }

    public class MessageWithAbuseReportRecording
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B81D0
        public void GetAbuseReportRecording(){} // RVA: 0x60B8220
        public void GetDataFromMessage(){} // RVA: 0x60B8260
    }

    public class MessageWithAchievementDefinitions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B8480
        public void GetAchievementDefinitions(){} // RVA: 0x60B84D0
        public void GetDataFromMessage(){} // RVA: 0x60B8510
    }

    public class MessageWithAchievementProgressList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B8610
        public void GetAchievementProgressList(){} // RVA: 0x60B8660
        public void GetDataFromMessage(){} // RVA: 0x60B86A0
    }

    public class MessageWithAchievementUpdate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B87A0
        public void GetAchievementUpdate(){} // RVA: 0x60B87F0
        public void GetDataFromMessage(){} // RVA: 0x60B8830
    }

    public class MessageWithApplicationInviteList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B8AB0
        public void GetApplicationInviteList(){} // RVA: 0x60B8B00
        public void GetDataFromMessage(){} // RVA: 0x60B8B40
    }

    public class MessageWithApplicationVersion
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B8C40
        public void GetApplicationVersion(){} // RVA: 0x60B8C90
        public void GetDataFromMessage(){} // RVA: 0x60B8CD0
    }

    public class MessageWithAssetDetails
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B8DD0
        public void GetAssetDetails(){} // RVA: 0x60B8E20
        public void GetDataFromMessage(){} // RVA: 0x60B8E60
    }

    public class MessageWithAssetDetailsList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B8F60
        public void GetAssetDetailsList(){} // RVA: 0x60B8FB0
        public void GetDataFromMessage(){} // RVA: 0x60B8FF0
    }

    public class MessageWithAssetFileDeleteResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B90F0
        public void GetAssetFileDeleteResult(){} // RVA: 0x60B9140
        public void GetDataFromMessage(){} // RVA: 0x60B9180
    }

    public class MessageWithAssetFileDownloadCancelResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B9280
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x60B92D0
        public void GetDataFromMessage(){} // RVA: 0x60B9310
    }

    public class MessageWithAssetFileDownloadResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B9410
        public void GetAssetFileDownloadResult(){} // RVA: 0x60B9460
        public void GetDataFromMessage(){} // RVA: 0x60B94A0
    }

    public class MessageWithAssetFileDownloadUpdate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B9710
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x60B9760
        public void GetDataFromMessage(){} // RVA: 0x60B97A0
    }

    public class MessageWithAvatarEditorResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B9AB0
        public void GetAvatarEditorResult(){} // RVA: 0x60B9B00
        public void GetDataFromMessage(){} // RVA: 0x60B9B40
    }

    public class MessageWithBlockedUserList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B9CE0
        public void GetBlockedUserList(){} // RVA: 0x60B9D30
        public void GetDataFromMessage(){} // RVA: 0x60B9D70
    }

    public class MessageWithCalApplicationFinalized
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60B9E70
        public void GetCalApplicationFinalized(){} // RVA: 0x60B9EC0
        public void GetDataFromMessage(){} // RVA: 0x60B9F00
    }

    public class MessageWithCalApplicationProposed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BA1D0
        public void GetCalApplicationProposed(){} // RVA: 0x60BA220
        public void GetDataFromMessage(){} // RVA: 0x60BA260
    }

    public class MessageWithCalApplicationSuggestionList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BA3F0
        public void GetCalApplicationSuggestionList(){} // RVA: 0x60BA440
        public void GetDataFromMessage(){} // RVA: 0x60BA480
    }

    public class MessageWithChallenge
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BA580
        public void GetChallenge(){} // RVA: 0x60BA5D0
        public void GetDataFromMessage(){} // RVA: 0x60BA610
    }

    public class MessageWithChallengeEntryList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BA8A0
        public void GetChallengeEntryList(){} // RVA: 0x60BA8F0
        public void GetDataFromMessage(){} // RVA: 0x60BA930
    }

    public class MessageWithChallengeList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BA710
        public void GetChallengeList(){} // RVA: 0x60BA760
        public void GetDataFromMessage(){} // RVA: 0x60BA7A0
    }

    public class MessageWithCloudStorageConflictMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BAA30
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x60BAA80
        public void GetDataFromMessage(){} // RVA: 0x60BAAC0
    }

    public class MessageWithCloudStorageData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BABC0
        public void GetCloudStorageData(){} // RVA: 0x60BAC10
        public void GetDataFromMessage(){} // RVA: 0x60BAC50
    }

    public class MessageWithCloudStorageMetadataList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BAEE0
        public void GetCloudStorageMetadataList(){} // RVA: 0x60BAF30
        public void GetDataFromMessage(){} // RVA: 0x60BAF70
    }

    public class MessageWithCloudStorageMetadataUnderLocal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BAD50
        public void GetCloudStorageMetadata(){} // RVA: 0x60BADA0
        public void GetDataFromMessage(){} // RVA: 0x60BADE0
    }

    public class MessageWithCloudStorageUpdateResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BB070
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x60BB0C0
        public void GetDataFromMessage(){} // RVA: 0x60BB100
    }

    public class MessageWithDataStoreUnderPrivateUserDataStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BB200
        public void GetDataStore(){} // RVA: 0x60BB250
        public void GetDataFromMessage(){} // RVA: 0x60BB290
    }

    public class MessageWithDataStoreUnderPublicUserDataStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BB300
        public void GetDataStore(){} // RVA: 0x60BB350
        public void GetDataFromMessage(){} // RVA: 0x60BB390
    }

    public class MessageWithDestinationList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BB400
        public void GetDestinationList(){} // RVA: 0x60BB450
        public void GetDataFromMessage(){} // RVA: 0x60BB490
    }

    public class MessageWithGroupPresenceJoinIntent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BB590
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x60BB5E0
        public void GetDataFromMessage(){} // RVA: 0x60BB620
    }

    public class MessageWithGroupPresenceLeaveIntent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BB720
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x60BB770
        public void GetDataFromMessage(){} // RVA: 0x60BB7B0
    }

    public class MessageWithHttpTransferUpdate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C2430
        public void GetHttpTransferUpdate(){} // RVA: 0x60C2480
        public void GetDataFromMessage(){} // RVA: 0x60C24C0
    }

    public class MessageWithInstalledApplicationList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BB8B0
        public void GetInstalledApplicationList(){} // RVA: 0x60BB900
        public void GetDataFromMessage(){} // RVA: 0x60BB940
    }

    public class MessageWithInvitePanelResultInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BBA40
        public void GetInvitePanelResultInfo(){} // RVA: 0x60BBA90
        public void GetDataFromMessage(){} // RVA: 0x60BBAD0
    }

    public class MessageWithLaunchBlockFlowResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BBC70
        public void GetLaunchBlockFlowResult(){} // RVA: 0x60BBCC0
        public void GetDataFromMessage(){} // RVA: 0x60BBD00
    }

    public class MessageWithLaunchFriendRequestFlowResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BBEF0
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x60BBF40
        public void GetDataFromMessage(){} // RVA: 0x60BBF80
    }

    public class MessageWithLaunchInvitePanelFlowResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BC170
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x60BC1C0
        public void GetDataFromMessage(){} // RVA: 0x60BC200
    }

    public class MessageWithLaunchReportFlowResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BC410
        public void GetLaunchReportFlowResult(){} // RVA: 0x60BC460
        public void GetDataFromMessage(){} // RVA: 0x60BC4A0
    }

    public class MessageWithLaunchUnblockFlowResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BC690
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x60BC6E0
        public void GetDataFromMessage(){} // RVA: 0x60BC720
    }

    public class MessageWithLeaderboardDidUpdate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C1F20
        public void GetLeaderboardDidUpdate(){} // RVA: 0x60C1FA0
        public void GetDataFromMessage(){} // RVA: 0x60C1FE0
    }

    public class MessageWithLeaderboardEntryList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BCAA0
        public void GetLeaderboardEntryList(){} // RVA: 0x60BCAF0
        public void GetDataFromMessage(){} // RVA: 0x60BCB30
    }

    public class MessageWithLeaderboardList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BC910
        public void GetLeaderboardList(){} // RVA: 0x60BC960
        public void GetDataFromMessage(){} // RVA: 0x60BC9A0
    }

    public class MessageWithLinkedAccountList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BCC30
        public void GetLinkedAccountList(){} // RVA: 0x60BCC80
        public void GetDataFromMessage(){} // RVA: 0x60BCCC0
    }

    public class MessageWithLivestreamingApplicationStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BCDC0
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x60BCE10
        public void GetDataFromMessage(){} // RVA: 0x60BCE50
    }

    public class MessageWithLivestreamingStartResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BCFF0
        public void GetLivestreamingStartResult(){} // RVA: 0x60BD040
        public void GetDataFromMessage(){} // RVA: 0x60BD080
    }

    public class MessageWithLivestreamingStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BD210
        public void GetLivestreamingStatus(){} // RVA: 0x60BD260
        public void GetDataFromMessage(){} // RVA: 0x60BD2A0
    }

    public class MessageWithLivestreamingVideoStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BD3A0
        public void GetLivestreamingVideoStats(){} // RVA: 0x60BD3F0
        public void GetDataFromMessage(){} // RVA: 0x60BD430
    }

    public class MessageWithMatchmakingAdminSnapshot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BD700
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x60BD750
        public void GetDataFromMessage(){} // RVA: 0x60BD790
    }

    public class MessageWithMatchmakingBrowseResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C2240
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x60C2290
        public void GetRoomList(){} // RVA: 0x60C22E0
        public void GetDataFromMessage(){} // RVA: 0x60C2330
    }

    public class MessageWithMatchmakingEnqueueResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BD890
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x60BD8E0
        public void GetDataFromMessage(){} // RVA: 0x60BD920
    }

    public class MessageWithMatchmakingEnqueueResultAndRoom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BDA20
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x60BDA70
        public void GetDataFromMessage(){} // RVA: 0x60BDAB0
    }

    public class MessageWithMatchmakingNotification
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C2110
        public void GetRoom(){} // RVA: 0x60C2160
        public void GetDataFromMessage(){} // RVA: 0x60C21A0
    }

    public class MessageWithMatchmakingStatsUnderMatchmakingStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BDBB0
        public void GetMatchmakingStats(){} // RVA: 0x60BDC00
        public void GetDataFromMessage(){} // RVA: 0x60BDC40
    }

    public class MessageWithMicrophoneAvailabilityState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BDD40
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x60BDD90
        public void GetDataFromMessage(){} // RVA: 0x60BDDD0
    }

    public class MessageWithNetSyncConnection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BDF70
        public void GetNetSyncConnection(){} // RVA: 0x60BDFC0
        public void GetDataFromMessage(){} // RVA: 0x60BE000
    }

    public class MessageWithNetSyncSessionList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BE100
        public void GetNetSyncSessionList(){} // RVA: 0x60BE150
        public void GetDataFromMessage(){} // RVA: 0x60BE190
    }

    public class MessageWithNetSyncSessionsChangedNotification
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BE290
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x60BE2E0
        public void GetDataFromMessage(){} // RVA: 0x60BE320
    }

    public class MessageWithNetSyncSetSessionPropertyResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BE590
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x60BE5E0
        public void GetDataFromMessage(){} // RVA: 0x60BE620
    }

    public class MessageWithNetSyncVoipAttenuationValueList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BE830
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x60BE880
        public void GetDataFromMessage(){} // RVA: 0x60BE8C0
    }

    public class MessageWithNetworkingPeer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C19F0
        public void GetNetworkingPeer(){} // RVA: 0x60C1A40
        public void GetDataFromMessage(){} // RVA: 0x60C1A80
    }

    public class MessageWithOrgScopedID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BE9C0
        public void GetOrgScopedID(){} // RVA: 0x60BEA10
        public void GetDataFromMessage(){} // RVA: 0x60BEA50
    }

    public class MessageWithParty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BEBE0
        public void GetParty(){} // RVA: 0x60BEC30
        public void GetDataFromMessage(){} // RVA: 0x60BEC70
    }

    public class MessageWithPartyID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BEE40
        public void GetPartyID(){} // RVA: 0x60BEE90
        public void GetDataFromMessage(){} // RVA: 0x60BEED0
    }

    public class MessageWithPartyUnderCurrentParty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BED10
        public void GetParty(){} // RVA: 0x60BED60
        public void GetDataFromMessage(){} // RVA: 0x60BEDA0
    }

    public class MessageWithPartyUpdateNotification
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BF060
        public void GetPartyUpdateNotification(){} // RVA: 0x60BF0B0
        public void GetDataFromMessage(){} // RVA: 0x60BF0F0
    }

    public class MessageWithPidList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BF1F0
        public void GetPidList(){} // RVA: 0x60BF240
        public void GetDataFromMessage(){} // RVA: 0x60BF280
    }

    public class MessageWithPingResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C1C30
        public void GetPingResult(){} // RVA: 0x60C1C80
        public void GetDataFromMessage(){} // RVA: 0x60C1CC0
    }

    public class MessageWithPlatformInitialize
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C25C0
        public void GetPlatformInitialize(){} // RVA: 0x60C2610
        public void GetDataFromMessage(){} // RVA: 0x60C2650
    }

    public class MessageWithProductList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BF380
        public void GetProductList(){} // RVA: 0x60BF3D0
        public void GetDataFromMessage(){} // RVA: 0x60BF410
    }

    public class MessageWithPurchase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BF510
        public void GetPurchase(){} // RVA: 0x60BF560
        public void GetDataFromMessage(){} // RVA: 0x60BF5A0
    }

    public class MessageWithPurchaseList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BF6A0
        public void GetPurchaseList(){} // RVA: 0x60BF6F0
        public void GetDataFromMessage(){} // RVA: 0x60BF730
    }

    public class MessageWithRejoinDialogResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BF830
        public void GetRejoinDialogResult(){} // RVA: 0x60BF880
        public void GetDataFromMessage(){} // RVA: 0x60BF8C0
    }

    public class MessageWithRoom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BFA60
        public void GetRoom(){} // RVA: 0x60BFAB0
        public void GetDataFromMessage(){} // RVA: 0x60BFAF0
    }

    public class MessageWithRoomInviteNotification
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BFF80
        public void GetRoomInviteNotification(){} // RVA: 0x60BFFD0
        public void GetDataFromMessage(){} // RVA: 0x60C0010
    }

    public class MessageWithRoomInviteNotificationList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C0110
        public void GetRoomInviteNotificationList(){} // RVA: 0x60C0160
        public void GetDataFromMessage(){} // RVA: 0x60C01A0
    }

    public class MessageWithRoomList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BFDF0
        public void GetRoomList(){} // RVA: 0x60BFE40
        public void GetDataFromMessage(){} // RVA: 0x60BFE80
    }

    public class MessageWithRoomUnderCurrentRoom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BFB90
        public void GetRoom(){} // RVA: 0x60BFBE0
        public void GetDataFromMessage(){} // RVA: 0x60BFC20
    }

    public class MessageWithRoomUnderViewerRoom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60BFCC0
        public void GetRoom(){} // RVA: 0x60BFD10
        public void GetDataFromMessage(){} // RVA: 0x60BFD50
    }

    public class MessageWithSdkAccountList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C02A0
        public void GetSdkAccountList(){} // RVA: 0x60C02F0
        public void GetDataFromMessage(){} // RVA: 0x60C0330
    }

    public class MessageWithSendInvitesResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C0430
        public void GetSendInvitesResult(){} // RVA: 0x60C0480
        public void GetDataFromMessage(){} // RVA: 0x60C04C0
    }

    public class MessageWithShareMediaResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C06D0
        public void GetShareMediaResult(){} // RVA: 0x60C0720
        public void GetDataFromMessage(){} // RVA: 0x60C0760
    }

    public class MessageWithString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C08F0
        public void GetString(){} // RVA: 0x60C0940
        public void GetDataFromMessage(){} // RVA: 0x60C0980
    }

    public class MessageWithSystemVoipState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C09D0
        public void GetSystemVoipState(){} // RVA: 0x60C0A20
        public void GetDataFromMessage(){} // RVA: 0x60C0A60
    }

    public class MessageWithUser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C0C50
        public void GetUser(){} // RVA: 0x60C0CA0
        public void GetDataFromMessage(){} // RVA: 0x60C0CE0
    }

    public class MessageWithUserAndRoomList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C0DE0
        public void GetUserAndRoomList(){} // RVA: 0x60C0E30
        public void GetDataFromMessage(){} // RVA: 0x60C0E70
    }

    public class MessageWithUserCapabilityList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C1100
        public void GetUserCapabilityList(){} // RVA: 0x60C1150
        public void GetDataFromMessage(){} // RVA: 0x60C1190
    }

    public class MessageWithUserDataStoreUpdateResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C1290
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x60C12E0
        public void GetDataFromMessage(){} // RVA: 0x60C1320
    }

    public class MessageWithUserList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C0F70
        public void GetUserList(){} // RVA: 0x60C0FC0
        public void GetDataFromMessage(){} // RVA: 0x60C1000
    }

    public class MessageWithUserProof
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C14C0
        public void GetUserProof(){} // RVA: 0x60C1510
        public void GetDataFromMessage(){} // RVA: 0x60C1550
    }

    public class MessageWithUserReportID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C1770
        public void GetUserReportID(){} // RVA: 0x60C17C0
        public void GetDataFromMessage(){} // RVA: 0x60C1800
    }

    public class Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24CC0
        public void get_Data(){} // RVA: 0x283FA0
        public void GetDataFromMessage(){} // RVA: 0x283FA0
    }

    public class MultiplayerErrorOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x60C27E0
        public void SetErrorKey(){} // RVA: 0x60C2890
        public void op_Explicit(){} // RVA: 0x6081810
        public void Finalize(){} // RVA: 0x60C2950
    }

}