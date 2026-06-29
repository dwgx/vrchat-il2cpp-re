// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 100
// Methods: 403

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class MatchmakingOptions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA06D0
        public void SetCreateRoomDataStore(){} // RVA: 0x7ADEA0780
        public void ClearCreateRoomDataStore(){} // RVA: 0x7ADEA08F0
        public void SetCreateRoomJoinPolicy(){} // RVA: 0x7ADEA09B0
        public void SetCreateRoomMaxUsers(){} // RVA: 0x7ADEA0A70
        public void AddEnqueueAdditionalUser(){} // RVA: 0x7ADEA0B30
        public void ClearEnqueueAdditionalUsers(){} // RVA: 0x7ADEA0C00
        public void SetEnqueueDataSettings(){} // RVA: 0x7ADEA0F60
        public void ClearEnqueueDataSettings(){} // RVA: 0x7ADEA10D0
        public void SetEnqueueIsDebug(){} // RVA: 0x7ADEA1190
        public void SetEnqueueQueryKey(){} // RVA: 0x7ADEA1250
        public void op_Explicit(){} // RVA: 0x7ADE6D8D0
        public void Finalize(){} // RVA: 0x7ADEA1390
        public void Handle(){} // RVA: 0x7B3FB4428
    }

    public class Message : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA1480
        public void Finalize(){} // RVA: 0x7A8DBE140
        public void get_Type(){} // RVA: 0x7A8124910
        public void get_IsError(){} // RVA: 0x7A9C435A0
        public void get_RequestID(){} // RVA: 0x7A80DA7B0
        public void GetError(){} // RVA: 0x7A81052C0
        public void GetPingResult(){} // RVA: 0x7A82D1450
        public void GetNetworkingPeer(){} // RVA: 0x7A82D1450
        public void GetHttpTransferUpdate(){} // RVA: 0x7A82D1450
        public void GetPlatformInitialize(){} // RVA: 0x7A82D1450
        public void GetAbuseReportRecording(){} // RVA: 0x7A82D1450
        public void GetAchievementDefinitions(){} // RVA: 0x7A82D1450
        public void GetAchievementProgressList(){} // RVA: 0x7A82D1450
        public void GetAchievementUpdate(){} // RVA: 0x7A82D1450
        public void GetApplicationInviteList(){} // RVA: 0x7A82D1450
        public void GetApplicationVersion(){} // RVA: 0x7A82D1450
        public void GetAssetDetails(){} // RVA: 0x7A82D1450
        public void GetAssetDetailsList(){} // RVA: 0x7A82D1450
        public void GetAssetFileDeleteResult(){} // RVA: 0x7A82D1450
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x7A82D1450
        public void GetAssetFileDownloadResult(){} // RVA: 0x7A82D1450
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x7A82D1450
        public void GetAvatarEditorResult(){} // RVA: 0x7A82D1450
        public void GetBlockedUserList(){} // RVA: 0x7A82D1450
        public void GetCalApplicationFinalized(){} // RVA: 0x7A82D1450
        public void GetCalApplicationProposed(){} // RVA: 0x7A82D1450
        public void GetCalApplicationSuggestionList(){} // RVA: 0x7A82D1450
        public void GetChallenge(){} // RVA: 0x7A82D1450
        public void GetChallengeEntryList(){} // RVA: 0x7A82D1450
        public void GetChallengeList(){} // RVA: 0x7A82D1450
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x7A82D1450
        public void GetCloudStorageData(){} // RVA: 0x7A82D1450
        public void GetCloudStorageMetadata(){} // RVA: 0x7A82D1450
        public void GetCloudStorageMetadataList(){} // RVA: 0x7A82D1450
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x7A82D1450
        public void GetDataStore(){} // RVA: 0x7A82D1450
        public void GetDestinationList(){} // RVA: 0x7A82D1450
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x7A82D1450
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x7A82D1450
        public void GetInstalledApplicationList(){} // RVA: 0x7A82D1450
        public void GetInvitePanelResultInfo(){} // RVA: 0x7A82D1450
        public void GetLaunchBlockFlowResult(){} // RVA: 0x7A82D1450
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x7A82D1450
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x7A82D1450
        public void GetLaunchReportFlowResult(){} // RVA: 0x7A82D1450
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x7A82D1450
        public void GetLeaderboardDidUpdate(){} // RVA: 0x7A80D7320
        public void GetLeaderboardEntryList(){} // RVA: 0x7A82D1450
        public void GetLeaderboardList(){} // RVA: 0x7A82D1450
        public void GetLinkedAccountList(){} // RVA: 0x7A82D1450
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x7A82D1450
        public void GetLivestreamingStartResult(){} // RVA: 0x7A82D1450
        public void GetLivestreamingStatus(){} // RVA: 0x7A82D1450
        public void GetLivestreamingVideoStats(){} // RVA: 0x7A82D1450
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x7A82D1450
        public void GetMatchmakingBrowseResult(){} // RVA: 0x7A82D1450
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7A82D1450
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7A82D1450
        public void GetMatchmakingStats(){} // RVA: 0x7A82D1450
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x7A82D1450
        public void GetNetSyncConnection(){} // RVA: 0x7A82D1450
        public void GetNetSyncSessionList(){} // RVA: 0x7A82D1450
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x7A82D1450
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7A82D1450
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x7A82D1450
        public void GetOrgScopedID(){} // RVA: 0x7A82D1450
        public void GetParty(){} // RVA: 0x7A82D1450
        public void GetPartyID(){} // RVA: 0x7A82D1450
        public void GetPartyUpdateNotification(){} // RVA: 0x7A82D1450
        public void GetPidList(){} // RVA: 0x7A82D1450
        public void GetProductList(){} // RVA: 0x7A82D1450
        public void GetPurchase(){} // RVA: 0x7A82D1450
        public void GetPurchaseList(){} // RVA: 0x7A82D1450
        public void GetRejoinDialogResult(){} // RVA: 0x7A82D1450
        public void GetRoom(){} // RVA: 0x7A82D1450
        public void GetRoomInviteNotification(){} // RVA: 0x7A82D1450
        public void GetRoomInviteNotificationList(){} // RVA: 0x7A82D1450
        public void GetRoomList(){} // RVA: 0x7A82D1450
        public void GetSdkAccountList(){} // RVA: 0x7A82D1450
        public void GetSendInvitesResult(){} // RVA: 0x7A82D1450
        public void GetShareMediaResult(){} // RVA: 0x7A82D1450
        public void GetString(){} // RVA: 0x7A82D1450
        public void GetSystemVoipState(){} // RVA: 0x7A82D1450
        public void GetUser(){} // RVA: 0x7A82D1450
        public void GetUserAndRoomList(){} // RVA: 0x7A82D1450
        public void GetUserCapabilityList(){} // RVA: 0x7A82D1450
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x7A82D1450
        public void GetUserList(){} // RVA: 0x7A82D1450
        public void GetUserProof(){} // RVA: 0x7A82D1450
        public void GetUserReportID(){} // RVA: 0x7A82D1450
        public void ParseMessageHandle(){} // RVA: 0x7ADEA18A0
        public void PopMessage(){} // RVA: 0x7ADEA4080
        public void set_HandleExtraMessageTypes(){} // RVA: 0x7ADEA4230
        public void get_HandleExtraMessageTypes(){} // RVA: 0x7ADEA42D0
        public void type(){} // RVA: 0x7B41F3B08
    }

    public class MessageWithAbuseReportRecording : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA4490
        public void GetAbuseReportRecording(){} // RVA: 0x7ADEA44E0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA4520
    }

    public class MessageWithAchievementDefinitions : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA4740
        public void GetAchievementDefinitions(){} // RVA: 0x7ADEA4790
        public void GetDataFromMessage(){} // RVA: 0x7ADEA47D0
    }

    public class MessageWithAchievementProgressList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA48D0
        public void GetAchievementProgressList(){} // RVA: 0x7ADEA4920
        public void GetDataFromMessage(){} // RVA: 0x7ADEA4960
    }

    public class MessageWithAchievementUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA4A60
        public void GetAchievementUpdate(){} // RVA: 0x7ADEA4AB0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA4AF0
    }

    public class MessageWithApplicationInviteList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA4D70
        public void GetApplicationInviteList(){} // RVA: 0x7ADEA4DC0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA4E00
    }

    public class MessageWithApplicationVersion : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA4F00
        public void GetApplicationVersion(){} // RVA: 0x7ADEA4F50
        public void GetDataFromMessage(){} // RVA: 0x7ADEA4F90
    }

    public class MessageWithAssetDetails : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA5090
        public void GetAssetDetails(){} // RVA: 0x7ADEA50E0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA5120
    }

    public class MessageWithAssetDetailsList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA5220
        public void GetAssetDetailsList(){} // RVA: 0x7ADEA5270
        public void GetDataFromMessage(){} // RVA: 0x7ADEA52B0
    }

    public class MessageWithAssetFileDeleteResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA53B0
        public void GetAssetFileDeleteResult(){} // RVA: 0x7ADEA5400
        public void GetDataFromMessage(){} // RVA: 0x7ADEA5440
    }

    public class MessageWithAssetFileDownloadCancelResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA5540
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x7ADEA5590
        public void GetDataFromMessage(){} // RVA: 0x7ADEA55D0
    }

    public class MessageWithAssetFileDownloadResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA56D0
        public void GetAssetFileDownloadResult(){} // RVA: 0x7ADEA5720
        public void GetDataFromMessage(){} // RVA: 0x7ADEA5760
    }

    public class MessageWithAssetFileDownloadUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA59D0
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x7ADEA5A20
        public void GetDataFromMessage(){} // RVA: 0x7ADEA5A60
    }

    public class MessageWithAvatarEditorResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA5D70
        public void GetAvatarEditorResult(){} // RVA: 0x7ADEA5DC0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA5E00
    }

    public class MessageWithBlockedUserList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA5FA0
        public void GetBlockedUserList(){} // RVA: 0x7ADEA5FF0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA6030
    }

    public class MessageWithCalApplicationFinalized : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA6130
        public void GetCalApplicationFinalized(){} // RVA: 0x7ADEA6180
        public void GetDataFromMessage(){} // RVA: 0x7ADEA61C0
    }

    public class MessageWithCalApplicationProposed : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA6490
        public void GetCalApplicationProposed(){} // RVA: 0x7ADEA64E0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA6520
    }

    public class MessageWithCalApplicationSuggestionList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA66B0
        public void GetCalApplicationSuggestionList(){} // RVA: 0x7ADEA6700
        public void GetDataFromMessage(){} // RVA: 0x7ADEA6740
    }

    public class MessageWithChallenge : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA6840
        public void GetChallenge(){} // RVA: 0x7ADEA6890
        public void GetDataFromMessage(){} // RVA: 0x7ADEA68D0
    }

    public class MessageWithChallengeEntryList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA6B60
        public void GetChallengeEntryList(){} // RVA: 0x7ADEA6BB0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA6BF0
    }

    public class MessageWithChallengeList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA69D0
        public void GetChallengeList(){} // RVA: 0x7ADEA6A20
        public void GetDataFromMessage(){} // RVA: 0x7ADEA6A60
    }

    public class MessageWithCloudStorageConflictMetadata : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA6CF0
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x7ADEA6D40
        public void GetDataFromMessage(){} // RVA: 0x7ADEA6D80
    }

    public class MessageWithCloudStorageData : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA6E80
        public void GetCloudStorageData(){} // RVA: 0x7ADEA6ED0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA6F10
    }

    public class MessageWithCloudStorageMetadataList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA71A0
        public void GetCloudStorageMetadataList(){} // RVA: 0x7ADEA71F0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA7230
    }

    public class MessageWithCloudStorageMetadataUnderLocal : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA7010
        public void GetCloudStorageMetadata(){} // RVA: 0x7ADEA7060
        public void GetDataFromMessage(){} // RVA: 0x7ADEA70A0
    }

    public class MessageWithCloudStorageUpdateResponse : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA7330
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x7ADEA7380
        public void GetDataFromMessage(){} // RVA: 0x7ADEA73C0
    }

    public class MessageWithDataStoreUnderPrivateUserDataStore : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA74C0
        public void GetDataStore(){} // RVA: 0x7ADEA7510
        public void GetDataFromMessage(){} // RVA: 0x7ADEA7550
    }

    public class MessageWithDataStoreUnderPublicUserDataStore : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA75C0
        public void GetDataStore(){} // RVA: 0x7ADEA7610
        public void GetDataFromMessage(){} // RVA: 0x7ADEA7650
    }

    public class MessageWithDestinationList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA76C0
        public void GetDestinationList(){} // RVA: 0x7ADEA7710
        public void GetDataFromMessage(){} // RVA: 0x7ADEA7750
    }

    public class MessageWithGroupPresenceJoinIntent : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA7850
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x7ADEA78A0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA78E0
    }

    public class MessageWithGroupPresenceLeaveIntent : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA79E0
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x7ADEA7A30
        public void GetDataFromMessage(){} // RVA: 0x7ADEA7A70
    }

    public class MessageWithInstalledApplicationList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA7B70
        public void GetInstalledApplicationList(){} // RVA: 0x7ADEA7BC0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA7C00
    }

    public class MessageWithInvitePanelResultInfo : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA7D00
        public void GetInvitePanelResultInfo(){} // RVA: 0x7ADEA7D50
        public void GetDataFromMessage(){} // RVA: 0x7ADEA7D90
    }

    public class MessageWithLaunchBlockFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA7F30
        public void GetLaunchBlockFlowResult(){} // RVA: 0x7ADEA7F80
        public void GetDataFromMessage(){} // RVA: 0x7ADEA7FC0
    }

    public class MessageWithLaunchFriendRequestFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA81B0
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x7ADEA8200
        public void GetDataFromMessage(){} // RVA: 0x7ADEA8240
    }

    public class MessageWithLaunchInvitePanelFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA8430
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x7ADEA8480
        public void GetDataFromMessage(){} // RVA: 0x7ADEA84C0
    }

    public class MessageWithLaunchReportFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA86D0
        public void GetLaunchReportFlowResult(){} // RVA: 0x7ADEA8720
        public void GetDataFromMessage(){} // RVA: 0x7ADEA8760
    }

    public class MessageWithLaunchUnblockFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA8950
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x7ADEA89A0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA89E0
    }

    public class MessageWithLeaderboardEntryList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA8D60
        public void GetLeaderboardEntryList(){} // RVA: 0x7ADEA8DB0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA8DF0
    }

    public class MessageWithLeaderboardList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA8BD0
        public void GetLeaderboardList(){} // RVA: 0x7ADEA8C20
        public void GetDataFromMessage(){} // RVA: 0x7ADEA8C60
    }

    public class MessageWithLinkedAccountList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA8EF0
        public void GetLinkedAccountList(){} // RVA: 0x7ADEA8F40
        public void GetDataFromMessage(){} // RVA: 0x7ADEA8F80
    }

    public class MessageWithLivestreamingApplicationStatus : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA9080
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x7ADEA90D0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA9110
    }

    public class MessageWithLivestreamingStartResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA92B0
        public void GetLivestreamingStartResult(){} // RVA: 0x7ADEA9300
        public void GetDataFromMessage(){} // RVA: 0x7ADEA9340
    }

    public class MessageWithLivestreamingStatus : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA94D0
        public void GetLivestreamingStatus(){} // RVA: 0x7ADEA9520
        public void GetDataFromMessage(){} // RVA: 0x7ADEA9560
    }

    public class MessageWithLivestreamingVideoStats : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA9660
        public void GetLivestreamingVideoStats(){} // RVA: 0x7ADEA96B0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA96F0
    }

    public class MessageWithMatchmakingAdminSnapshot : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA99C0
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x7ADEA9A10
        public void GetDataFromMessage(){} // RVA: 0x7ADEA9A50
    }

    public class MessageWithMatchmakingEnqueueResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA9B50
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7ADEA9BA0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA9BE0
    }

    public class MessageWithMatchmakingEnqueueResultAndRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA9CE0
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7ADEA9D30
        public void GetDataFromMessage(){} // RVA: 0x7ADEA9D70
    }

    public class MessageWithMatchmakingStatsUnderMatchmakingStats : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEA9E70
        public void GetMatchmakingStats(){} // RVA: 0x7ADEA9EC0
        public void GetDataFromMessage(){} // RVA: 0x7ADEA9F00
    }

    public class MessageWithMicrophoneAvailabilityState : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADEAA000
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x7ADEAA050
        public void GetDataFromMessage(){} // RVA: 0x7ADEAA090
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E188D0
        public void get_Data(){} // RVA: 0x7A8051B10
        public void GetDataFromMessage(){} // RVA: 0x7A8051B10
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

    public class Message`1 : Message
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABA2A290
        public void get_Data(){} // RVA: 0x7A8105330
        public void GetDataFromMessage(){} // RVA: 0x7A7E063E0
    }

}