// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 100
// Methods: 417

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Matchmaking
    {
        // ── Methods ──
        public void ReportResultsInsecure(){} // RVA: 0x7FFAF8B772E0
        public void GetStats(){} // RVA: 0x7FFAF8B77940
        public void Browse(){} // RVA: 0x7FFAF8B77B90
        public void Browse2(){} // RVA: 0x7FFAF8B77DE0
        public void Cancel(){} // RVA: 0x7FFAF8B78270 | overloaded x2
        public void CreateAndEnqueueRoom(){} // RVA: 0x7FFAF8B78410
        public void CreateAndEnqueueRoom2(){} // RVA: 0x7FFAF8B78690
        public void CreateRoom(){} // RVA: 0x7FFAF8B788D0
        public void CreateRoom2(){} // RVA: 0x7FFAF8B78B20
        public void Enqueue(){} // RVA: 0x7FFAF8B78D60
        public void Enqueue2(){} // RVA: 0x7FFAF8B78FB0
        public void EnqueueRoom(){} // RVA: 0x7FFAF8B791F0
        public void EnqueueRoom2(){} // RVA: 0x7FFAF8B793D0
        public void GetAdminSnapshot(){} // RVA: 0x7FFAF8B795A0
        public void JoinRoom(){} // RVA: 0x7FFAF8B79750
        public void StartMatch(){} // RVA: 0x7FFAF8B79920
        public void SetMatchFoundNotificationCallback(){} // RVA: 0x7FFAF8B79AC0
    }

    public class MatchmakingOptions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B64410
        public void SetCreateRoomDataStore(){} // RVA: 0x7FFAF8B644C0
        public void ClearCreateRoomDataStore(){} // RVA: 0x7FFAF8B64630
        public void SetCreateRoomJoinPolicy(){} // RVA: 0x7FFAF8B646F0
        public void SetCreateRoomMaxUsers(){} // RVA: 0x7FFAF8B647B0
        public void AddEnqueueAdditionalUser(){} // RVA: 0x7FFAF8B64870
        public void ClearEnqueueAdditionalUsers(){} // RVA: 0x7FFAF8B64940
        public void SetEnqueueDataSettings(){} // RVA: 0x7FFAF8B64CA0 | overloaded x3
        public void ClearEnqueueDataSettings(){} // RVA: 0x7FFAF8B64E10
        public void SetEnqueueIsDebug(){} // RVA: 0x7FFAF8B64ED0
        public void SetEnqueueQueryKey(){} // RVA: 0x7FFAF8B64F90
        public void op_Explicit(){} // RVA: 0x7FFAF8B31810
        public void Finalize(){} // RVA: 0x7FFAF8B650D0
    }

    public class Media
    {
        // ── Methods ──
        public void ShareToFacebook(){} // RVA: 0x7FFAF8B88CE0
    }

    public class Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B651C0
        public void Finalize(){} // RVA: 0x7FFAF3AB7BA0
        public void get_Type(){} // RVA: 0x7FFAF2DDA5C0
        public void get_IsError(){} // RVA: 0x7FFAF48EEC10
        public void get_RequestID(){} // RVA: 0x7FFAF2D907C0
        public void GetError(){} // RVA: 0x7FFAF2DBB0C0
        public void GetPingResult(){} // RVA: 0x7FFAF2FC9240
        public void GetNetworkingPeer(){} // RVA: 0x7FFAF2FC9240
        public void GetHttpTransferUpdate(){} // RVA: 0x7FFAF2FC9240
        public void GetPlatformInitialize(){} // RVA: 0x7FFAF2FC9240
        public void GetAbuseReportRecording(){} // RVA: 0x7FFAF2FC9240
        public void GetAchievementDefinitions(){} // RVA: 0x7FFAF2FC9240
        public void GetAchievementProgressList(){} // RVA: 0x7FFAF2FC9240
        public void GetAchievementUpdate(){} // RVA: 0x7FFAF2FC9240
        public void GetApplicationInviteList(){} // RVA: 0x7FFAF2FC9240
        public void GetApplicationVersion(){} // RVA: 0x7FFAF2FC9240
        public void GetAssetDetails(){} // RVA: 0x7FFAF2FC9240
        public void GetAssetDetailsList(){} // RVA: 0x7FFAF2FC9240
        public void GetAssetFileDeleteResult(){} // RVA: 0x7FFAF2FC9240
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x7FFAF2FC9240
        public void GetAssetFileDownloadResult(){} // RVA: 0x7FFAF2FC9240
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x7FFAF2FC9240
        public void GetAvatarEditorResult(){} // RVA: 0x7FFAF2FC9240
        public void GetBlockedUserList(){} // RVA: 0x7FFAF2FC9240
        public void GetCalApplicationFinalized(){} // RVA: 0x7FFAF2FC9240
        public void GetCalApplicationProposed(){} // RVA: 0x7FFAF2FC9240
        public void GetCalApplicationSuggestionList(){} // RVA: 0x7FFAF2FC9240
        public void GetChallenge(){} // RVA: 0x7FFAF2FC9240
        public void GetChallengeEntryList(){} // RVA: 0x7FFAF2FC9240
        public void GetChallengeList(){} // RVA: 0x7FFAF2FC9240
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x7FFAF2FC9240
        public void GetCloudStorageData(){} // RVA: 0x7FFAF2FC9240
        public void GetCloudStorageMetadata(){} // RVA: 0x7FFAF2FC9240
        public void GetCloudStorageMetadataList(){} // RVA: 0x7FFAF2FC9240
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x7FFAF2FC9240
        public void GetDataStore(){} // RVA: 0x7FFAF2FC9240
        public void GetDestinationList(){} // RVA: 0x7FFAF2FC9240
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x7FFAF2FC9240
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x7FFAF2FC9240
        public void GetInstalledApplicationList(){} // RVA: 0x7FFAF2FC9240
        public void GetInvitePanelResultInfo(){} // RVA: 0x7FFAF2FC9240
        public void GetLaunchBlockFlowResult(){} // RVA: 0x7FFAF2FC9240
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x7FFAF2FC9240
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x7FFAF2FC9240
        public void GetLaunchReportFlowResult(){} // RVA: 0x7FFAF2FC9240
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x7FFAF2FC9240
        public void GetLeaderboardDidUpdate(){} // RVA: 0x7FFAF2D8D320
        public void GetLeaderboardEntryList(){} // RVA: 0x7FFAF2FC9240
        public void GetLeaderboardList(){} // RVA: 0x7FFAF2FC9240
        public void GetLinkedAccountList(){} // RVA: 0x7FFAF2FC9240
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x7FFAF2FC9240
        public void GetLivestreamingStartResult(){} // RVA: 0x7FFAF2FC9240
        public void GetLivestreamingStatus(){} // RVA: 0x7FFAF2FC9240
        public void GetLivestreamingVideoStats(){} // RVA: 0x7FFAF2FC9240
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x7FFAF2FC9240
        public void GetMatchmakingBrowseResult(){} // RVA: 0x7FFAF2FC9240
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7FFAF2FC9240
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7FFAF2FC9240
        public void GetMatchmakingStats(){} // RVA: 0x7FFAF2FC9240
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x7FFAF2FC9240
        public void GetNetSyncConnection(){} // RVA: 0x7FFAF2FC9240
        public void GetNetSyncSessionList(){} // RVA: 0x7FFAF2FC9240
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x7FFAF2FC9240
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7FFAF2FC9240
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x7FFAF2FC9240
        public void GetOrgScopedID(){} // RVA: 0x7FFAF2FC9240
        public void GetParty(){} // RVA: 0x7FFAF2FC9240
        public void GetPartyID(){} // RVA: 0x7FFAF2FC9240
        public void GetPartyUpdateNotification(){} // RVA: 0x7FFAF2FC9240
        public void GetPidList(){} // RVA: 0x7FFAF2FC9240
        public void GetProductList(){} // RVA: 0x7FFAF2FC9240
        public void GetPurchase(){} // RVA: 0x7FFAF2FC9240
        public void GetPurchaseList(){} // RVA: 0x7FFAF2FC9240
        public void GetRejoinDialogResult(){} // RVA: 0x7FFAF2FC9240
        public void GetRoom(){} // RVA: 0x7FFAF2FC9240
        public void GetRoomInviteNotification(){} // RVA: 0x7FFAF2FC9240
        public void GetRoomInviteNotificationList(){} // RVA: 0x7FFAF2FC9240
        public void GetRoomList(){} // RVA: 0x7FFAF2FC9240
        public void GetSdkAccountList(){} // RVA: 0x7FFAF2FC9240
        public void GetSendInvitesResult(){} // RVA: 0x7FFAF2FC9240
        public void GetShareMediaResult(){} // RVA: 0x7FFAF2FC9240
        public void GetString(){} // RVA: 0x7FFAF2FC9240
        public void GetSystemVoipState(){} // RVA: 0x7FFAF2FC9240
        public void GetUser(){} // RVA: 0x7FFAF2FC9240
        public void GetUserAndRoomList(){} // RVA: 0x7FFAF2FC9240
        public void GetUserCapabilityList(){} // RVA: 0x7FFAF2FC9240
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x7FFAF2FC9240
        public void GetUserList(){} // RVA: 0x7FFAF2FC9240
        public void GetUserProof(){} // RVA: 0x7FFAF2FC9240
        public void GetUserReportID(){} // RVA: 0x7FFAF2FC9240
        public void ParseMessageHandle(){} // RVA: 0x7FFAF8B655E0
        public void PopMessage(){} // RVA: 0x7FFAF8B67DC0
        public void set_HandleExtraMessageTypes(){} // RVA: 0x7FFAF8B67F70
        public void get_HandleExtraMessageTypes(){} // RVA: 0x7FFAF8B68010
    }

    public class MessageWithAbuseReportRecording
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B681D0
        public void GetAbuseReportRecording(){} // RVA: 0x7FFAF8B68220
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B68260
    }

    public class MessageWithAchievementDefinitions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B68480
        public void GetAchievementDefinitions(){} // RVA: 0x7FFAF8B684D0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B68510
    }

    public class MessageWithAchievementProgressList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B68610
        public void GetAchievementProgressList(){} // RVA: 0x7FFAF8B68660
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B686A0
    }

    public class MessageWithAchievementUpdate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B687A0
        public void GetAchievementUpdate(){} // RVA: 0x7FFAF8B687F0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B68830
    }

    public class MessageWithApplicationInviteList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B68AB0
        public void GetApplicationInviteList(){} // RVA: 0x7FFAF8B68B00
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B68B40
    }

    public class MessageWithApplicationVersion
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B68C40
        public void GetApplicationVersion(){} // RVA: 0x7FFAF8B68C90
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B68CD0
    }

    public class MessageWithAssetDetails
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B68DD0
        public void GetAssetDetails(){} // RVA: 0x7FFAF8B68E20
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B68E60
    }

    public class MessageWithAssetDetailsList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B68F60
        public void GetAssetDetailsList(){} // RVA: 0x7FFAF8B68FB0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B68FF0
    }

    public class MessageWithAssetFileDeleteResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B690F0
        public void GetAssetFileDeleteResult(){} // RVA: 0x7FFAF8B69140
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B69180
    }

    public class MessageWithAssetFileDownloadCancelResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B69280
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x7FFAF8B692D0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B69310
    }

    public class MessageWithAssetFileDownloadResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B69410
        public void GetAssetFileDownloadResult(){} // RVA: 0x7FFAF8B69460
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B694A0
    }

    public class MessageWithAssetFileDownloadUpdate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B69710
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x7FFAF8B69760
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B697A0
    }

    public class MessageWithAvatarEditorResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B69AB0
        public void GetAvatarEditorResult(){} // RVA: 0x7FFAF8B69B00
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B69B40
    }

    public class MessageWithBlockedUserList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B69CE0
        public void GetBlockedUserList(){} // RVA: 0x7FFAF8B69D30
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B69D70
    }

    public class MessageWithCalApplicationFinalized
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B69E70
        public void GetCalApplicationFinalized(){} // RVA: 0x7FFAF8B69EC0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B69F00
    }

    public class MessageWithCalApplicationProposed
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6A1D0
        public void GetCalApplicationProposed(){} // RVA: 0x7FFAF8B6A220
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6A260
    }

    public class MessageWithCalApplicationSuggestionList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6A3F0
        public void GetCalApplicationSuggestionList(){} // RVA: 0x7FFAF8B6A440
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6A480
    }

    public class MessageWithChallenge
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6A580
        public void GetChallenge(){} // RVA: 0x7FFAF8B6A5D0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6A610
    }

    public class MessageWithChallengeEntryList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6A8A0
        public void GetChallengeEntryList(){} // RVA: 0x7FFAF8B6A8F0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6A930
    }

    public class MessageWithChallengeList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6A710
        public void GetChallengeList(){} // RVA: 0x7FFAF8B6A760
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6A7A0
    }

    public class MessageWithCloudStorageConflictMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6AA30
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x7FFAF8B6AA80
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6AAC0
    }

    public class MessageWithCloudStorageData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6ABC0
        public void GetCloudStorageData(){} // RVA: 0x7FFAF8B6AC10
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6AC50
    }

    public class MessageWithCloudStorageMetadataList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6AEE0
        public void GetCloudStorageMetadataList(){} // RVA: 0x7FFAF8B6AF30
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6AF70
    }

    public class MessageWithCloudStorageMetadataUnderLocal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6AD50
        public void GetCloudStorageMetadata(){} // RVA: 0x7FFAF8B6ADA0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6ADE0
    }

    public class MessageWithCloudStorageUpdateResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6B070
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x7FFAF8B6B0C0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6B100
    }

    public class MessageWithDataStoreUnderPrivateUserDataStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6B200
        public void GetDataStore(){} // RVA: 0x7FFAF8B6B250
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6B290
    }

    public class MessageWithDataStoreUnderPublicUserDataStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6B300
        public void GetDataStore(){} // RVA: 0x7FFAF8B6B350
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6B390
    }

    public class MessageWithDestinationList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6B400
        public void GetDestinationList(){} // RVA: 0x7FFAF8B6B450
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6B490
    }

    public class MessageWithGroupPresenceJoinIntent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6B590
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x7FFAF8B6B5E0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6B620
    }

    public class MessageWithGroupPresenceLeaveIntent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6B720
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x7FFAF8B6B770
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6B7B0
    }

    public class MessageWithHttpTransferUpdate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B72430
        public void GetHttpTransferUpdate(){} // RVA: 0x7FFAF8B72480
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B724C0
    }

    public class MessageWithInstalledApplicationList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6B8B0
        public void GetInstalledApplicationList(){} // RVA: 0x7FFAF8B6B900
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6B940
    }

    public class MessageWithInvitePanelResultInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6BA40
        public void GetInvitePanelResultInfo(){} // RVA: 0x7FFAF8B6BA90
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6BAD0
    }

    public class MessageWithLaunchBlockFlowResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6BC70
        public void GetLaunchBlockFlowResult(){} // RVA: 0x7FFAF8B6BCC0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6BD00
    }

    public class MessageWithLaunchFriendRequestFlowResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6BEF0
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x7FFAF8B6BF40
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6BF80
    }

    public class MessageWithLaunchInvitePanelFlowResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6C170
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x7FFAF8B6C1C0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6C200
    }

    public class MessageWithLaunchReportFlowResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6C410
        public void GetLaunchReportFlowResult(){} // RVA: 0x7FFAF8B6C460
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6C4A0
    }

    public class MessageWithLaunchUnblockFlowResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6C690
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x7FFAF8B6C6E0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6C720
    }

    public class MessageWithLeaderboardDidUpdate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B71F20
        public void GetLeaderboardDidUpdate(){} // RVA: 0x7FFAF8B71FA0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B71FE0
    }

    public class MessageWithLeaderboardEntryList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6CAA0
        public void GetLeaderboardEntryList(){} // RVA: 0x7FFAF8B6CAF0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6CB30
    }

    public class MessageWithLeaderboardList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6C910
        public void GetLeaderboardList(){} // RVA: 0x7FFAF8B6C960
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6C9A0
    }

    public class MessageWithLinkedAccountList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6CC30
        public void GetLinkedAccountList(){} // RVA: 0x7FFAF8B6CC80
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6CCC0
    }

    public class MessageWithLivestreamingApplicationStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6CDC0
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x7FFAF8B6CE10
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6CE50
    }

    public class MessageWithLivestreamingStartResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6CFF0
        public void GetLivestreamingStartResult(){} // RVA: 0x7FFAF8B6D040
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6D080
    }

    public class MessageWithLivestreamingStatus
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6D210
        public void GetLivestreamingStatus(){} // RVA: 0x7FFAF8B6D260
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6D2A0
    }

    public class MessageWithLivestreamingVideoStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6D3A0
        public void GetLivestreamingVideoStats(){} // RVA: 0x7FFAF8B6D3F0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6D430
    }

    public class MessageWithMatchmakingAdminSnapshot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6D700
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x7FFAF8B6D750
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6D790
    }

    public class MessageWithMatchmakingBrowseResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B72240
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7FFAF8B72290
        public void GetRoomList(){} // RVA: 0x7FFAF8B722E0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B72330
    }

    public class MessageWithMatchmakingEnqueueResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6D890
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7FFAF8B6D8E0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6D920
    }

    public class MessageWithMatchmakingEnqueueResultAndRoom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6DA20
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7FFAF8B6DA70
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6DAB0
    }

    public class MessageWithMatchmakingNotification
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B72110
        public void GetRoom(){} // RVA: 0x7FFAF8B72160
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B721A0
    }

    public class MessageWithMatchmakingStatsUnderMatchmakingStats
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6DBB0
        public void GetMatchmakingStats(){} // RVA: 0x7FFAF8B6DC00
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6DC40
    }

    public class MessageWithMicrophoneAvailabilityState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6DD40
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x7FFAF8B6DD90
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6DDD0
    }

    public class MessageWithNetSyncConnection
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6DF70
        public void GetNetSyncConnection(){} // RVA: 0x7FFAF8B6DFC0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6E000
    }

    public class MessageWithNetSyncSessionList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6E100
        public void GetNetSyncSessionList(){} // RVA: 0x7FFAF8B6E150
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6E190
    }

    public class MessageWithNetSyncSessionsChangedNotification
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6E290
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x7FFAF8B6E2E0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6E320
    }

    public class MessageWithNetSyncSetSessionPropertyResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6E590
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7FFAF8B6E5E0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6E620
    }

    public class MessageWithNetSyncVoipAttenuationValueList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6E830
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x7FFAF8B6E880
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6E8C0
    }

    public class MessageWithNetworkingPeer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B719F0
        public void GetNetworkingPeer(){} // RVA: 0x7FFAF8B71A40
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B71A80
    }

    public class MessageWithOrgScopedID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6E9C0
        public void GetOrgScopedID(){} // RVA: 0x7FFAF8B6EA10
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6EA50
    }

    public class MessageWithParty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6EBE0
        public void GetParty(){} // RVA: 0x7FFAF8B6EC30
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6EC70
    }

    public class MessageWithPartyID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6EE40
        public void GetPartyID(){} // RVA: 0x7FFAF8B6EE90
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6EED0
    }

    public class MessageWithPartyUnderCurrentParty
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6ED10
        public void GetParty(){} // RVA: 0x7FFAF8B6ED60
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6EDA0
    }

    public class MessageWithPartyUpdateNotification
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6F060
        public void GetPartyUpdateNotification(){} // RVA: 0x7FFAF8B6F0B0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6F0F0
    }

    public class MessageWithPidList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6F1F0
        public void GetPidList(){} // RVA: 0x7FFAF8B6F240
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6F280
    }

    public class MessageWithPingResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B71C30
        public void GetPingResult(){} // RVA: 0x7FFAF8B71C80
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B71CC0
    }

    public class MessageWithPlatformInitialize
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B725C0
        public void GetPlatformInitialize(){} // RVA: 0x7FFAF8B72610
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B72650
    }

    public class MessageWithProductList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6F380
        public void GetProductList(){} // RVA: 0x7FFAF8B6F3D0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6F410
    }

    public class MessageWithPurchase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6F510
        public void GetPurchase(){} // RVA: 0x7FFAF8B6F560
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6F5A0
    }

    public class MessageWithPurchaseList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6F6A0
        public void GetPurchaseList(){} // RVA: 0x7FFAF8B6F6F0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6F730
    }

    public class MessageWithRejoinDialogResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6F830
        public void GetRejoinDialogResult(){} // RVA: 0x7FFAF8B6F880
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6F8C0
    }

    public class MessageWithRoom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6FA60
        public void GetRoom(){} // RVA: 0x7FFAF8B6FAB0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6FAF0
    }

    public class MessageWithRoomInviteNotification
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6FF80
        public void GetRoomInviteNotification(){} // RVA: 0x7FFAF8B6FFD0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B70010
    }

    public class MessageWithRoomInviteNotificationList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B70110
        public void GetRoomInviteNotificationList(){} // RVA: 0x7FFAF8B70160
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B701A0
    }

    public class MessageWithRoomList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6FDF0
        public void GetRoomList(){} // RVA: 0x7FFAF8B6FE40
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6FE80
    }

    public class MessageWithRoomUnderCurrentRoom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6FB90
        public void GetRoom(){} // RVA: 0x7FFAF8B6FBE0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6FC20
    }

    public class MessageWithRoomUnderViewerRoom
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B6FCC0
        public void GetRoom(){} // RVA: 0x7FFAF8B6FD10
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B6FD50
    }

    public class MessageWithSdkAccountList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B702A0
        public void GetSdkAccountList(){} // RVA: 0x7FFAF8B702F0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B70330
    }

    public class MessageWithSendInvitesResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B70430
        public void GetSendInvitesResult(){} // RVA: 0x7FFAF8B70480
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B704C0
    }

    public class MessageWithShareMediaResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B706D0
        public void GetShareMediaResult(){} // RVA: 0x7FFAF8B70720
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B70760
    }

    public class MessageWithString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B708F0
        public void GetString(){} // RVA: 0x7FFAF8B70940
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B70980
    }

    public class MessageWithSystemVoipState
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B709D0
        public void GetSystemVoipState(){} // RVA: 0x7FFAF8B70A20
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B70A60
    }

    public class MessageWithUser
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B70C50
        public void GetUser(){} // RVA: 0x7FFAF8B70CA0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B70CE0
    }

    public class MessageWithUserAndRoomList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B70DE0
        public void GetUserAndRoomList(){} // RVA: 0x7FFAF8B70E30
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B70E70
    }

    public class MessageWithUserCapabilityList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B71100
        public void GetUserCapabilityList(){} // RVA: 0x7FFAF8B71150
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B71190
    }

    public class MessageWithUserDataStoreUpdateResponse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B71290
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x7FFAF8B712E0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B71320
    }

    public class MessageWithUserList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B70F70
        public void GetUserList(){} // RVA: 0x7FFAF8B70FC0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B71000
    }

    public class MessageWithUserProof
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B714C0
        public void GetUserProof(){} // RVA: 0x7FFAF8B71510
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B71550
    }

    public class MessageWithUserReportID
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8B71770
        public void GetUserReportID(){} // RVA: 0x7FFAF8B717C0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF8B71800
    }

    public class Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4CC0
        public void get_Data(){} // RVA: 0x7FFAF2D33FA0
        public void GetDataFromMessage(){} // RVA: 0x7FFAF2D33FA0
    }

    public class Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF66E72C0
        public void get_Data(){} // RVA: 0x7FFAF2DBB130
        public void GetDataFromMessage(){}
    }

    public class Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF66E72C0
        public void get_Data(){} // RVA: 0x7FFAF2DBB130
        public void GetDataFromMessage(){}
    }

    public class Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF66E72C0
        public void get_Data(){} // RVA: 0x7FFAF2DBB130
        public void GetDataFromMessage(){}
    }

    public class Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF66E72C0
        public void get_Data(){} // RVA: 0x7FFAF2DBB130
        public void GetDataFromMessage(){}
    }

    public class Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF66E72C0
        public void get_Data(){} // RVA: 0x7FFAF2DBB130
        public void GetDataFromMessage(){}
    }

    public class Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF66E72C0
        public void get_Data(){} // RVA: 0x7FFAF2DBB130
        public void GetDataFromMessage(){}
    }

}