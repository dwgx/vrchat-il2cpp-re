// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 95
// Methods: 403

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class Matchmaking : Object
    {
        // ── Methods ──
        public void ReportResultsInsecure(){} // RVA: 0x7FFAC885E9C0
        public void GetStats(){} // RVA: 0x7FFAC885F020
        public void Browse(){} // RVA: 0x7FFAC885F270
        public void Browse2(){} // RVA: 0x7FFAC885F4C0
        public void Cancel(){} // RVA: 0x7FFAC885F950 | overloaded x2
        public void CreateAndEnqueueRoom(){} // RVA: 0x7FFAC885FAF0
        public void CreateAndEnqueueRoom2(){} // RVA: 0x7FFAC885FD70
        public void CreateRoom(){} // RVA: 0x7FFAC885FFB0
        public void CreateRoom2(){} // RVA: 0x7FFAC8860200
        public void Enqueue(){} // RVA: 0x7FFAC8860440
        public void Enqueue2(){} // RVA: 0x7FFAC8860690
        public void EnqueueRoom(){} // RVA: 0x7FFAC88608D0
        public void EnqueueRoom2(){} // RVA: 0x7FFAC8860AB0
        public void GetAdminSnapshot(){} // RVA: 0x7FFAC8860C80
        public void JoinRoom(){} // RVA: 0x7FFAC8860E30
        public void StartMatch(){} // RVA: 0x7FFAC8861000
        public void SetMatchFoundNotificationCallback(){} // RVA: 0x7FFAC88611A0
    }

    public class MatchmakingOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC884BAF0
        public void SetCreateRoomDataStore(){} // RVA: 0x7FFAC884BBA0
        public void ClearCreateRoomDataStore(){} // RVA: 0x7FFAC884BD10
        public void SetCreateRoomJoinPolicy(){} // RVA: 0x7FFAC884BDD0
        public void SetCreateRoomMaxUsers(){} // RVA: 0x7FFAC884BE90
        public void AddEnqueueAdditionalUser(){} // RVA: 0x7FFAC884BF50
        public void ClearEnqueueAdditionalUsers(){} // RVA: 0x7FFAC884C020
        public void SetEnqueueDataSettings(){} // RVA: 0x7FFAC884C380 | overloaded x3
        public void ClearEnqueueDataSettings(){} // RVA: 0x7FFAC884C4F0
        public void SetEnqueueIsDebug(){} // RVA: 0x7FFAC884C5B0
        public void SetEnqueueQueryKey(){} // RVA: 0x7FFAC884C670
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC884C7B0
    }

    public class Media : Object
    {
        // ── Methods ──
        public void ShareToFacebook(){} // RVA: 0x7FFAC88703C0
    }

    public class Message : Object
    {
        public 0x6B2555D8 Type; // 0x10
        public ulong IsError; // 0x18
        public Oculus.Platform.Models.Error RequestID; // 0x20
        public ExtraMessageTypesHandler HandleExtraMessageTypes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC884C8A0
        public void Finalize(){} // RVA: 0x7FFAC38D9870
        public void get_Type(){} // RVA: 0x7FFAC2F6E5C0
        public void get_IsError(){} // RVA: 0x7FFAC495C6A0
        public void get_RequestID(){} // RVA: 0x7FFAC2F247C0
        public void GetError(){} // RVA: 0x7FFAC2F4F0C0
        public void GetPingResult(){} // RVA: 0x7FFAC34F9180
        public void GetNetworkingPeer(){} // RVA: 0x7FFAC34F9180
        public void GetHttpTransferUpdate(){} // RVA: 0x7FFAC34F9180
        public void GetPlatformInitialize(){} // RVA: 0x7FFAC34F9180
        public void GetAbuseReportRecording(){} // RVA: 0x7FFAC34F9180
        public void GetAchievementDefinitions(){} // RVA: 0x7FFAC34F9180
        public void GetAchievementProgressList(){} // RVA: 0x7FFAC34F9180
        public void GetAchievementUpdate(){} // RVA: 0x7FFAC34F9180
        public void GetApplicationInviteList(){} // RVA: 0x7FFAC34F9180
        public void GetApplicationVersion(){} // RVA: 0x7FFAC34F9180
        public void GetAssetDetails(){} // RVA: 0x7FFAC34F9180
        public void GetAssetDetailsList(){} // RVA: 0x7FFAC34F9180
        public void GetAssetFileDeleteResult(){} // RVA: 0x7FFAC34F9180
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x7FFAC34F9180
        public void GetAssetFileDownloadResult(){} // RVA: 0x7FFAC34F9180
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x7FFAC34F9180
        public void GetAvatarEditorResult(){} // RVA: 0x7FFAC34F9180
        public void GetBlockedUserList(){} // RVA: 0x7FFAC34F9180
        public void GetCalApplicationFinalized(){} // RVA: 0x7FFAC34F9180
        public void GetCalApplicationProposed(){} // RVA: 0x7FFAC34F9180
        public void GetCalApplicationSuggestionList(){} // RVA: 0x7FFAC34F9180
        public void GetChallenge(){} // RVA: 0x7FFAC34F9180
        public void GetChallengeEntryList(){} // RVA: 0x7FFAC34F9180
        public void GetChallengeList(){} // RVA: 0x7FFAC34F9180
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x7FFAC34F9180
        public void GetCloudStorageData(){} // RVA: 0x7FFAC34F9180
        public void GetCloudStorageMetadata(){} // RVA: 0x7FFAC34F9180
        public void GetCloudStorageMetadataList(){} // RVA: 0x7FFAC34F9180
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x7FFAC34F9180
        public void GetDataStore(){} // RVA: 0x7FFAC34F9180
        public void GetDestinationList(){} // RVA: 0x7FFAC34F9180
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x7FFAC34F9180
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x7FFAC34F9180
        public void GetInstalledApplicationList(){} // RVA: 0x7FFAC34F9180
        public void GetInvitePanelResultInfo(){} // RVA: 0x7FFAC34F9180
        public void GetLaunchBlockFlowResult(){} // RVA: 0x7FFAC34F9180
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x7FFAC34F9180
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x7FFAC34F9180
        public void GetLaunchReportFlowResult(){} // RVA: 0x7FFAC34F9180
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x7FFAC34F9180
        public void GetLeaderboardDidUpdate(){} // RVA: 0x7FFAC2F21320
        public void GetLeaderboardEntryList(){} // RVA: 0x7FFAC34F9180
        public void GetLeaderboardList(){} // RVA: 0x7FFAC34F9180
        public void GetLinkedAccountList(){} // RVA: 0x7FFAC34F9180
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x7FFAC34F9180
        public void GetLivestreamingStartResult(){} // RVA: 0x7FFAC34F9180
        public void GetLivestreamingStatus(){} // RVA: 0x7FFAC34F9180
        public void GetLivestreamingVideoStats(){} // RVA: 0x7FFAC34F9180
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x7FFAC34F9180
        public void GetMatchmakingBrowseResult(){} // RVA: 0x7FFAC34F9180
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7FFAC34F9180
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7FFAC34F9180
        public void GetMatchmakingStats(){} // RVA: 0x7FFAC34F9180
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x7FFAC34F9180
        public void GetNetSyncConnection(){} // RVA: 0x7FFAC34F9180
        public void GetNetSyncSessionList(){} // RVA: 0x7FFAC34F9180
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x7FFAC34F9180
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7FFAC34F9180
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x7FFAC34F9180
        public void GetOrgScopedID(){} // RVA: 0x7FFAC34F9180
        public void GetParty(){} // RVA: 0x7FFAC34F9180
        public void GetPartyID(){} // RVA: 0x7FFAC34F9180
        public void GetPartyUpdateNotification(){} // RVA: 0x7FFAC34F9180
        public void GetPidList(){} // RVA: 0x7FFAC34F9180
        public void GetProductList(){} // RVA: 0x7FFAC34F9180
        public void GetPurchase(){} // RVA: 0x7FFAC34F9180
        public void GetPurchaseList(){} // RVA: 0x7FFAC34F9180
        public void GetRejoinDialogResult(){} // RVA: 0x7FFAC34F9180
        public void GetRoom(){} // RVA: 0x7FFAC34F9180
        public void GetRoomInviteNotification(){} // RVA: 0x7FFAC34F9180
        public void GetRoomInviteNotificationList(){} // RVA: 0x7FFAC34F9180
        public void GetRoomList(){} // RVA: 0x7FFAC34F9180
        public void GetSdkAccountList(){} // RVA: 0x7FFAC34F9180
        public void GetSendInvitesResult(){} // RVA: 0x7FFAC34F9180
        public void GetShareMediaResult(){} // RVA: 0x7FFAC34F9180
        public void GetString(){} // RVA: 0x7FFAC34F9180
        public void GetSystemVoipState(){} // RVA: 0x7FFAC34F9180
        public void GetUser(){} // RVA: 0x7FFAC34F9180
        public void GetUserAndRoomList(){} // RVA: 0x7FFAC34F9180
        public void GetUserCapabilityList(){} // RVA: 0x7FFAC34F9180
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x7FFAC34F9180
        public void GetUserList(){} // RVA: 0x7FFAC34F9180
        public void GetUserProof(){} // RVA: 0x7FFAC34F9180
        public void GetUserReportID(){} // RVA: 0x7FFAC34F9180
        public void ParseMessageHandle(){} // RVA: 0x7FFAC884CCC0
        public void PopMessage(){} // RVA: 0x7FFAC884F4A0
        public void set_HandleExtraMessageTypes(){} // RVA: 0x7FFAC884F650
        public void get_HandleExtraMessageTypes(){} // RVA: 0x7FFAC884F6F0
    }

    public class MessageWithAbuseReportRecording : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC884F8B0
        public void GetAbuseReportRecording(){} // RVA: 0x7FFAC884F900
        public void GetDataFromMessage(){} // RVA: 0x7FFAC884F940
    }

    public class MessageWithAchievementDefinitions : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC884FB60
        public void GetAchievementDefinitions(){} // RVA: 0x7FFAC884FBB0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC884FBF0
    }

    public class MessageWithAchievementProgressList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC884FCF0
        public void GetAchievementProgressList(){} // RVA: 0x7FFAC884FD40
        public void GetDataFromMessage(){} // RVA: 0x7FFAC884FD80
    }

    public class MessageWithAchievementUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC884FE80
        public void GetAchievementUpdate(){} // RVA: 0x7FFAC884FED0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC884FF10
    }

    public class MessageWithApplicationInviteList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8850190
        public void GetApplicationInviteList(){} // RVA: 0x7FFAC88501E0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8850220
    }

    public class MessageWithApplicationVersion : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8850320
        public void GetApplicationVersion(){} // RVA: 0x7FFAC8850370
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88503B0
    }

    public class MessageWithAssetDetails : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88504B0
        public void GetAssetDetails(){} // RVA: 0x7FFAC8850500
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8850540
    }

    public class MessageWithAssetDetailsList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8850640
        public void GetAssetDetailsList(){} // RVA: 0x7FFAC8850690
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88506D0
    }

    public class MessageWithAssetFileDeleteResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88507D0
        public void GetAssetFileDeleteResult(){} // RVA: 0x7FFAC8850820
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8850860
    }

    public class MessageWithAssetFileDownloadCancelResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8850960
        public void GetAssetFileDownloadCancelResult(){} // RVA: 0x7FFAC88509B0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88509F0
    }

    public class MessageWithAssetFileDownloadResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8850AF0
        public void GetAssetFileDownloadResult(){} // RVA: 0x7FFAC8850B40
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8850B80
    }

    public class MessageWithAssetFileDownloadUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8850DF0
        public void GetAssetFileDownloadUpdate(){} // RVA: 0x7FFAC8850E40
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8850E80
    }

    public class MessageWithAvatarEditorResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8851190
        public void GetAvatarEditorResult(){} // RVA: 0x7FFAC88511E0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8851220
    }

    public class MessageWithBlockedUserList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88513C0
        public void GetBlockedUserList(){} // RVA: 0x7FFAC8851410
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8851450
    }

    public class MessageWithCalApplicationFinalized : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8851550
        public void GetCalApplicationFinalized(){} // RVA: 0x7FFAC88515A0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88515E0
    }

    public class MessageWithCalApplicationProposed : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88518B0
        public void GetCalApplicationProposed(){} // RVA: 0x7FFAC8851900
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8851940
    }

    public class MessageWithCalApplicationSuggestionList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8851AD0
        public void GetCalApplicationSuggestionList(){} // RVA: 0x7FFAC8851B20
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8851B60
    }

    public class MessageWithChallenge : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8851C60
        public void GetChallenge(){} // RVA: 0x7FFAC8851CB0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8851CF0
    }

    public class MessageWithChallengeEntryList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8851F80
        public void GetChallengeEntryList(){} // RVA: 0x7FFAC8851FD0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8852010
    }

    public class MessageWithChallengeList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8851DF0
        public void GetChallengeList(){} // RVA: 0x7FFAC8851E40
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8851E80
    }

    public class MessageWithCloudStorageConflictMetadata : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8852110
        public void GetCloudStorageConflictMetadata(){} // RVA: 0x7FFAC8852160
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88521A0
    }

    public class MessageWithCloudStorageData : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88522A0
        public void GetCloudStorageData(){} // RVA: 0x7FFAC88522F0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8852330
    }

    public class MessageWithCloudStorageMetadataList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88525C0
        public void GetCloudStorageMetadataList(){} // RVA: 0x7FFAC8852610
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8852650
    }

    public class MessageWithCloudStorageMetadataUnderLocal : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8852430
        public void GetCloudStorageMetadata(){} // RVA: 0x7FFAC8852480
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88524C0
    }

    public class MessageWithCloudStorageUpdateResponse : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8852750
        public void GetCloudStorageUpdateResponse(){} // RVA: 0x7FFAC88527A0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88527E0
    }

    public class MessageWithDataStoreUnderPrivateUserDataStore : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88528E0
        public void GetDataStore(){} // RVA: 0x7FFAC8852930
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8852970
    }

    public class MessageWithDataStoreUnderPublicUserDataStore : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88529E0
        public void GetDataStore(){} // RVA: 0x7FFAC8852A30
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8852A70
    }

    public class MessageWithDestinationList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8852AE0
        public void GetDestinationList(){} // RVA: 0x7FFAC8852B30
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8852B70
    }

    public class MessageWithGroupPresenceJoinIntent : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8852C70
        public void GetGroupPresenceJoinIntent(){} // RVA: 0x7FFAC8852CC0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8852D00
    }

    public class MessageWithGroupPresenceLeaveIntent : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8852E00
        public void GetGroupPresenceLeaveIntent(){} // RVA: 0x7FFAC8852E50
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8852E90
    }

    public class MessageWithHttpTransferUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8859B10
        public void GetHttpTransferUpdate(){} // RVA: 0x7FFAC8859B60
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8859BA0
    }

    public class MessageWithInstalledApplicationList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8852F90
        public void GetInstalledApplicationList(){} // RVA: 0x7FFAC8852FE0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8853020
    }

    public class MessageWithInvitePanelResultInfo : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8853120
        public void GetInvitePanelResultInfo(){} // RVA: 0x7FFAC8853170
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88531B0
    }

    public class MessageWithLaunchBlockFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8853350
        public void GetLaunchBlockFlowResult(){} // RVA: 0x7FFAC88533A0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88533E0
    }

    public class MessageWithLaunchFriendRequestFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88535D0
        public void GetLaunchFriendRequestFlowResult(){} // RVA: 0x7FFAC8853620
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8853660
    }

    public class MessageWithLaunchInvitePanelFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8853850
        public void GetLaunchInvitePanelFlowResult(){} // RVA: 0x7FFAC88538A0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88538E0
    }

    public class MessageWithLaunchReportFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8853AF0
        public void GetLaunchReportFlowResult(){} // RVA: 0x7FFAC8853B40
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8853B80
    }

    public class MessageWithLaunchUnblockFlowResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8853D70
        public void GetLaunchUnblockFlowResult(){} // RVA: 0x7FFAC8853DC0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8853E00
    }

    public class MessageWithLeaderboardDidUpdate : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8859600
        public void GetLeaderboardDidUpdate(){} // RVA: 0x7FFAC8859680
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88596C0
    }

    public class MessageWithLeaderboardEntryList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8854180
        public void GetLeaderboardEntryList(){} // RVA: 0x7FFAC88541D0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8854210
    }

    public class MessageWithLeaderboardList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8853FF0
        public void GetLeaderboardList(){} // RVA: 0x7FFAC8854040
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8854080
    }

    public class MessageWithLinkedAccountList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8854310
        public void GetLinkedAccountList(){} // RVA: 0x7FFAC8854360
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88543A0
    }

    public class MessageWithLivestreamingApplicationStatus : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88544A0
        public void GetLivestreamingApplicationStatus(){} // RVA: 0x7FFAC88544F0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8854530
    }

    public class MessageWithLivestreamingStartResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88546D0
        public void GetLivestreamingStartResult(){} // RVA: 0x7FFAC8854720
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8854760
    }

    public class MessageWithLivestreamingStatus : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88548F0
        public void GetLivestreamingStatus(){} // RVA: 0x7FFAC8854940
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8854980
    }

    public class MessageWithLivestreamingVideoStats : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8854A80
        public void GetLivestreamingVideoStats(){} // RVA: 0x7FFAC8854AD0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8854B10
    }

    public class MessageWithMatchmakingAdminSnapshot : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8854DE0
        public void GetMatchmakingAdminSnapshot(){} // RVA: 0x7FFAC8854E30
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8854E70
    }

    public class MessageWithMatchmakingBrowseResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8859920
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7FFAC8859970
        public void GetRoomList(){} // RVA: 0x7FFAC88599C0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8859A10
    }

    public class MessageWithMatchmakingEnqueueResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8854F70
        public void GetMatchmakingEnqueueResult(){} // RVA: 0x7FFAC8854FC0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8855000
    }

    public class MessageWithMatchmakingEnqueueResultAndRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8855100
        public void GetMatchmakingEnqueueResultAndRoom(){} // RVA: 0x7FFAC8855150
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8855190
    }

    public class MessageWithMatchmakingNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88597F0
        public void GetRoom(){} // RVA: 0x7FFAC8859840
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8859880
    }

    public class MessageWithMatchmakingStatsUnderMatchmakingStats : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8855290
        public void GetMatchmakingStats(){} // RVA: 0x7FFAC88552E0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8855320
    }

    public class MessageWithMicrophoneAvailabilityState : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8855420
        public void GetMicrophoneAvailabilityState(){} // RVA: 0x7FFAC8855470
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88554B0
    }

    public class MessageWithNetSyncConnection : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8855650
        public void GetNetSyncConnection(){} // RVA: 0x7FFAC88556A0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88556E0
    }

    public class MessageWithNetSyncSessionList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88557E0
        public void GetNetSyncSessionList(){} // RVA: 0x7FFAC8855830
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8855870
    }

    public class MessageWithNetSyncSessionsChangedNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8855970
        public void GetNetSyncSessionsChangedNotification(){} // RVA: 0x7FFAC88559C0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8855A00
    }

    public class MessageWithNetSyncSetSessionPropertyResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8855C70
        public void GetNetSyncSetSessionPropertyResult(){} // RVA: 0x7FFAC8855CC0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8855D00
    }

    public class MessageWithNetSyncVoipAttenuationValueList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8855F10
        public void GetNetSyncVoipAttenuationValueList(){} // RVA: 0x7FFAC8855F60
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8855FA0
    }

    public class MessageWithNetworkingPeer : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88590D0
        public void GetNetworkingPeer(){} // RVA: 0x7FFAC8859120
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8859160
    }

    public class MessageWithOrgScopedID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88560A0
        public void GetOrgScopedID(){} // RVA: 0x7FFAC88560F0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8856130
    }

    public class MessageWithParty : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88562C0
        public void GetParty(){} // RVA: 0x7FFAC8856310
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8856350
    }

    public class MessageWithPartyID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8856520
        public void GetPartyID(){} // RVA: 0x7FFAC8856570
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88565B0
    }

    public class MessageWithPartyUnderCurrentParty : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88563F0
        public void GetParty(){} // RVA: 0x7FFAC8856440
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8856480
    }

    public class MessageWithPartyUpdateNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8856740
        public void GetPartyUpdateNotification(){} // RVA: 0x7FFAC8856790
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88567D0
    }

    public class MessageWithPidList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88568D0
        public void GetPidList(){} // RVA: 0x7FFAC8856920
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8856960
    }

    public class MessageWithPingResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8859310
        public void GetPingResult(){} // RVA: 0x7FFAC8859360
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88593A0
    }

    public class MessageWithPlatformInitialize : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8859CA0
        public void GetPlatformInitialize(){} // RVA: 0x7FFAC8859CF0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8859D30
    }

    public class MessageWithProductList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8856A60
        public void GetProductList(){} // RVA: 0x7FFAC8856AB0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8856AF0
    }

    public class MessageWithPurchase : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8856BF0
        public void GetPurchase(){} // RVA: 0x7FFAC8856C40
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8856C80
    }

    public class MessageWithPurchaseList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8856D80
        public void GetPurchaseList(){} // RVA: 0x7FFAC8856DD0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8856E10
    }

    public class MessageWithRejoinDialogResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8856F10
        public void GetRejoinDialogResult(){} // RVA: 0x7FFAC8856F60
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8856FA0
    }

    public class MessageWithRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8857140
        public void GetRoom(){} // RVA: 0x7FFAC8857190
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88571D0
    }

    public class MessageWithRoomInviteNotification : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8857660
        public void GetRoomInviteNotification(){} // RVA: 0x7FFAC88576B0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88576F0
    }

    public class MessageWithRoomInviteNotificationList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88577F0
        public void GetRoomInviteNotificationList(){} // RVA: 0x7FFAC8857840
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8857880
    }

    public class MessageWithRoomList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88574D0
        public void GetRoomList(){} // RVA: 0x7FFAC8857520
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8857560
    }

    public class MessageWithRoomUnderCurrentRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8857270
        public void GetRoom(){} // RVA: 0x7FFAC88572C0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8857300
    }

    public class MessageWithRoomUnderViewerRoom : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88573A0
        public void GetRoom(){} // RVA: 0x7FFAC88573F0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8857430
    }

    public class MessageWithSdkAccountList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8857980
        public void GetSdkAccountList(){} // RVA: 0x7FFAC88579D0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8857A10
    }

    public class MessageWithSendInvitesResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8857B10
        public void GetSendInvitesResult(){} // RVA: 0x7FFAC8857B60
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8857BA0
    }

    public class MessageWithShareMediaResult : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8857DB0
        public void GetShareMediaResult(){} // RVA: 0x7FFAC8857E00
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8857E40
    }

    public class MessageWithString : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8857FD0
        public void GetString(){} // RVA: 0x7FFAC8858020
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8858060
    }

    public class MessageWithSystemVoipState : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88580B0
        public void GetSystemVoipState(){} // RVA: 0x7FFAC8858100
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8858140
    }

    public class MessageWithUser : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8858330
        public void GetUser(){} // RVA: 0x7FFAC8858380
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88583C0
    }

    public class MessageWithUserAndRoomList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88584C0
        public void GetUserAndRoomList(){} // RVA: 0x7FFAC8858510
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8858550
    }

    public class MessageWithUserCapabilityList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88587E0
        public void GetUserCapabilityList(){} // RVA: 0x7FFAC8858830
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8858870
    }

    public class MessageWithUserDataStoreUpdateResponse : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8858970
        public void GetUserDataStoreUpdateResponse(){} // RVA: 0x7FFAC88589C0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8858A00
    }

    public class MessageWithUserList : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8858650
        public void GetUserList(){} // RVA: 0x7FFAC88586A0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC88586E0
    }

    public class MessageWithUserProof : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8858BA0
        public void GetUserProof(){} // RVA: 0x7FFAC8858BF0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8858C30
    }

    public class MessageWithUserReportID : Message`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8858E50
        public void GetUserReportID(){} // RVA: 0x7FFAC8858EA0
        public void GetDataFromMessage(){} // RVA: 0x7FFAC8858EE0
    }

    public class Message`1 : Message
    {
        public T Data;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70BF0
        public void get_Data(){} // RVA: 0x7FFAC2E8DC40
        public void GetDataFromMessage(){} // RVA: 0x7FFAC2E8DC40
    }

    public class MultiplayerErrorOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8859EC0
        public void SetErrorKey(){} // RVA: 0x7FFAC8859F70
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC885A030
    }

}