// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 82
// Methods: 110

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class AbuseReportRecording : Object
    {
        public string RecordingUuid; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C97EA0
    }

    public class AchievementDefinition : Object
    {
        public 0x665B46B8 Type; // 0x10
        public string Name; // 0x18
        public uint BitfieldLength; // 0x20
        public ulong Target; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C97FF0
    }

    public class AchievementProgress : Object
    {
        public string Bitfield; // 0x10
        public ulong Count; // 0x18
        public bool IsUnlocked; // 0x20
        public string Name; // 0x28
        public System.DateTime UnlockTime; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C98650
    }

    public class AchievementUpdate : Object
    {
        public bool JustUnlocked; // 0x10
        public string Name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C98DF0
    }

    public class ApplicationInvite : Object
    {
        public Oculus.Platform.Models.Destination DestinationOptional; // 0x10
        public Oculus.Platform.Models.Destination Destination; // 0x18
        public ulong ID; // 0x20
        public bool IsActive; // 0x28
        public string LobbySessionId; // 0x30
        public string MatchSessionId; // 0x38
        public Oculus.Platform.Models.User RecipientOptional; // 0x40
        public Oculus.Platform.Models.User Recipient; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C98FC0
    }

    public class ApplicationVersion : Object
    {
        public int CurrentCode; // 0x10
        public string CurrentName; // 0x18
        public int LatestCode; // 0x20
        public string LatestName; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C99A00
    }

    public class AssetDetails : Object
    {
        public ulong AssetId; // 0x10
        public string AssetType; // 0x18
        public string DownloadStatus; // 0x20
        public string Filepath; // 0x28
        public string IapStatus; // 0x30
        public Oculus.Platform.Models.LanguagePackInfo LanguageOptional; // 0x38
        public Oculus.Platform.Models.LanguagePackInfo Language; // 0x40
        public string Metadata; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C99D00
    }

    public class AssetFileDeleteResult : Object
    {
        public ulong AssetFileId; // 0x10
        public ulong AssetId; // 0x18
        public string Filepath; // 0x20
        public bool Success; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9A710
    }

    public class AssetFileDownloadCancelResult : Object
    {
        public ulong AssetFileId; // 0x10
        public ulong AssetId; // 0x18
        public string Filepath; // 0x20
        public bool Success; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9A990
    }

    public class AssetFileDownloadResult : Object
    {
        public ulong AssetId; // 0x10
        public string Filepath; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9AC10
    }

    public class AssetFileDownloadUpdate : Object
    {
        public ulong AssetFileId; // 0x10
        public ulong AssetId; // 0x18
        public ulong BytesTotal; // 0x20
        public long BytesTransferred; // 0x28
        public bool Completed; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9ADD0
    }

    public class AvatarEditorResult : Object
    {
        public bool RequestSent; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9B020
    }

    public class BlockedUser : Object
    {
        public ulong Id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9B0F0
    }

    public class CalApplicationFinalized : Object
    {
        public int CountdownMS; // 0x10
        public ulong ID; // 0x18
        public string LaunchDetails; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9B630
    }

    public class CalApplicationProposed : Object
    {
        public ulong ID; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9B840
    }

    public class CalApplicationSuggestion : Object
    {
        public ulong ID; // 0x10
        public string SocialContext; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9B900
    }

    public class Challenge : Object
    {
        public 0x665B4C38 CreationType; // 0x10
        public string Description; // 0x18
        public System.DateTime EndDate; // 0x20
        public ulong ID; // 0x28
        public 0x665BB4B8 InvitedUsersOptional; // 0x30
        public 0x665BB4B8 InvitedUsers; // 0x38
        public Oculus.Platform.Models.Leaderboard Leaderboard; // 0x40
        public 0x665BB4B8 ParticipantsOptional; // 0x48
        public 0x665BB4B8 Participants; // 0x50
        public System.DateTime StartDate; // 0x58
        public string Title; // 0x60
        public 0x665B4D40 Visibility; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9BF20
    }

    public class ChallengeEntry : Object
    {
        public string DisplayScore; // 0x10
        public byte[] ExtraData; // 0x18
        public ulong ID; // 0x20
        public int Rank; // 0x28
        public long Score; // 0x30
        public System.DateTime Timestamp; // 0x38
        public Oculus.Platform.Models.User User; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9CD50
    }

    public class CloudStorageConflictMetadata : Object
    {
        public Oculus.Platform.Models.CloudStorageMetadata Local; // 0x10
        public Oculus.Platform.Models.CloudStorageMetadata Remote; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9D790
    }

    public class CloudStorageData : Object
    {
        public string Bucket; // 0x10
        public byte[] Data; // 0x18
        public uint DataSize; // 0x20
        public string Key; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9D9D0
    }

    public class CloudStorageMetadata : Object
    {
        public string Bucket; // 0x10
        public long Counter; // 0x18
        public uint DataSize; // 0x20
        public string ExtraData; // 0x28
        public string Key; // 0x30
        public ulong SaveTime; // 0x38
        public 0x665B4D98 Status; // 0x40
        public string VersionHandle; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9DDC0
    }

    public class CloudStorageUpdateResponse : Object
    {
        public string Bucket; // 0x10
        public string Key; // 0x18
        public 0x665B4DF0 Status; // 0x20
        public string VersionHandle; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9E740
    }

    public class DeserializableList`1 : Object
    {
        public System.Collections.Generic.List`1<T> Count;
        public string System.Collections.Generic.ICollection<T>.IsReadOnly;
        public string Item;

        // ── Methods ──
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void GetEnumerator1(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void get_Data(){} // RVA: 0x7FFD4E078E90
        public void get_HasNextPage(){} // RVA: 0x7FFD4E079D00
        public void get_HasPreviousPage(){} // RVA: 0x7FFD4E079D00
        public void get_NextUrl(){} // RVA: 0x7FFD4E078E90
        public void get_PreviousUrl(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class Destination : Object
    {
        public string ApiName; // 0x10
        public string DeeplinkMessage; // 0x18
        public string DisplayName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9EAD0
    }

    public class Error : Object
    {
        public int Code; // 0x10
        public int HttpCode; // 0x14
        public string Message; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9F200
    }

    public class GroupPresenceJoinIntent : Object
    {
        public string DeeplinkMessage; // 0x10
        public string DestinationApiName; // 0x18
        public string LobbySessionId; // 0x20
        public string MatchSessionId; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9F270
    }

    public class GroupPresenceLeaveIntent : Object
    {
        public string DestinationApiName; // 0x10
        public string LobbySessionId; // 0x18
        public string MatchSessionId; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9F6A0
    }

    public class HttpTransferUpdate : Object
    {
        public ulong ID; // 0x10
        public byte[] Payload; // 0x18
        public bool IsCompleted; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9F9E0
    }

    public class InstalledApplication : Object
    {
        public string ApplicationId; // 0x10
        public string PackageName; // 0x18
        public string Status; // 0x20
        public int VersionCode; // 0x28
        public string VersionName; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53C9FC40
    }

    public class InvitePanelResultInfo : Object
    {
        public bool InvitesSent; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA03A0
    }

    public class LanguagePackInfo : Object
    {
        public string EnglishName; // 0x10
        public string NativeName; // 0x18
        public string Tag; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA0470
    }

    public class LaunchBlockFlowResult : Object
    {
        public bool DidBlock; // 0x10
        public bool DidCancel; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA07B0
    }

    public class LaunchDetails : Object
    {
        public string DeeplinkMessage; // 0x10
        public string DestinationApiName; // 0x18
        public string LaunchSource; // 0x20
        public 0x665B50B0 LaunchType; // 0x28
        public ulong RoomID; // 0x30
        public string TrackingID; // 0x38
        public 0x665BB4B8 UsersOptional; // 0x40
        public 0x665BB4B8 Users; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA08F0
    }

    public class LaunchFriendRequestFlowResult : Object
    {
        public bool DidCancel; // 0x10
        public bool DidSendRequest; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA0F60
    }

    public class LaunchInvitePanelFlowResult : Object
    {
        public 0x665BB4B8 InvitedUsers; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA10A0
    }

    public class LaunchReportFlowResult : Object
    {
        public bool DidCancel; // 0x10
        public ulong UserReportId; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA11F0
    }

    public class LaunchUnblockFlowResult : Object
    {
        public bool DidCancel; // 0x10
        public bool DidUnblock; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA1330
    }

    public class Leaderboard : Object
    {
        public string ApiName; // 0x10
        public Oculus.Platform.Models.Destination DestinationOptional; // 0x18
        public Oculus.Platform.Models.Destination Destination; // 0x20
        public ulong ID; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA1470
    }

    public class LeaderboardEntry : Object
    {
        public string DisplayScore; // 0x10
        public byte[] ExtraData; // 0x18
        public ulong ID; // 0x20
        public int Rank; // 0x28
        public long Score; // 0x30
        public Oculus.Platform.Models.SupplementaryMetric SupplementaryMetricOptional; // 0x38
        public Oculus.Platform.Models.SupplementaryMetric SupplementaryMetric; // 0x40
        public System.DateTime Timestamp; // 0x48
        public Oculus.Platform.Models.User User; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA1BD0
    }

    public class LinkedAccount : Object
    {
        public string AccessToken; // 0x10
        public 0x665B8AC8 ServiceProvider; // 0x18
        public string UserId; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA2890
    }

    public class LivestreamingApplicationStatus : Object
    {
        public bool StreamingEnabled; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA2E10
    }

    public class LivestreamingStartResult : Object
    {
        public 0x665B5268 StreamingResult; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA2EE0
    }

    public class LivestreamingStatus : Object
    {
        public bool CommentsVisible; // 0x10
        public bool IsPaused; // 0x11
        public bool LivestreamingEnabled; // 0x12
        public int LivestreamingType; // 0x14
        public bool MicEnabled; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA2FA0
    }

    public class LivestreamingVideoStats : Object
    {
        public int CommentCount; // 0x10
        public int ReactionCount; // 0x14
        public string TotalViews; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA31F0
    }

    public class MatchmakingAdminSnapshot : Object
    {
        public 0x665BA648 Candidates; // 0x10
        public double MyCurrentThreshold; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA3400
    }

    public class MatchmakingAdminSnapshotCandidate : Object
    {
        public bool CanMatch; // 0x10
        public double MyTotalScore; // 0x18
        public double TheirCurrentThreshold; // 0x20
        public double TheirTotalScore; // 0x28
        public string TraceId; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA35B0
    }

    public class MatchmakingBrowseResult : Object
    {
        public Oculus.Platform.Models.MatchmakingEnqueueResult EnqueueResult; // 0x10
        public 0x665BB098 Rooms; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA3B60
    }

    public class MatchmakingEnqueueResult : Object
    {
        public Oculus.Platform.Models.MatchmakingAdminSnapshot AdminSnapshotOptional; // 0x10
        public Oculus.Platform.Models.MatchmakingAdminSnapshot AdminSnapshot; // 0x18
        public uint AverageWait; // 0x20
        public uint MatchesInLastHourCount; // 0x24
        public uint MaxExpectedWait; // 0x28
        public string Pool; // 0x30
        public uint RecentMatchPercentage; // 0x38
        public string RequestHash; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA4380
    }

    public class MatchmakingEnqueueResultAndRoom : Object
    {
        public Oculus.Platform.Models.MatchmakingEnqueueResult MatchmakingEnqueueResult; // 0x10
        public Oculus.Platform.Models.Room Room; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA48E0
    }

    public class MatchmakingEnqueuedUser : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> CustomData; // 0x10
        public Oculus.Platform.Models.User UserOptional; // 0x18
        public Oculus.Platform.Models.User User; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA3DB0
    }

    public class MatchmakingStats : Object
    {
        public uint DrawCount; // 0x10
        public uint LossCount; // 0x14
        public uint SkillLevel; // 0x18
        public double SkillMean; // 0x20
        public double SkillStandardDeviation; // 0x28
        public uint WinCount; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA4B30
    }

    public class MicrophoneAvailabilityState : Object
    {
        public bool MicrophoneAvailable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA4DD0
    }

    public class NetSyncConnection : Object
    {
        public long ConnectionId; // 0x10
        public 0x665B7680 DisconnectReason; // 0x18
        public ulong SessionId; // 0x20
        public 0x665B7628 Status; // 0x28
        public string ZoneId; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA4EA0
    }

    public class NetSyncSession : Object
    {
        public long ConnectionId; // 0x10
        public bool Muted; // 0x18
        public ulong SessionId; // 0x20
        public ulong UserId; // 0x28
        public string VoipGroup; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA5170
    }

    public class NetSyncSessionsChangedNotification : Object
    {
        public long ConnectionId; // 0x10
        public 0x665BA9B8 Sessions; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA5720
    }

    public class NetSyncSetSessionPropertyResult : Object
    {
        public Oculus.Platform.Models.NetSyncSession Session; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA58D0
    }

    public class NetSyncVoipAttenuationValue : Object
    {
        public float Decibels; // 0x10
        public float Distance; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA5A20
    }

    public class NetworkingPeer : Object
    {
        public ulong ID; // 0x10
        public 0x665B78E8 State; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F840710
        public void get_ID(){} // RVA: 0x7FFD4E35C380
        public void set_ID(){} // RVA: 0x7FFD4F83EFB0
        public void get_State(){} // RVA: 0x7FFD4E577800
        public void set_State(){} // RVA: 0x7FFD4ED4CD10
    }

    public class OrgScopedID : Object
    {
        public ulong ID; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA5F00
    }

    public class Party : Object
    {
        public ulong ID; // 0x10
        public 0x665BB4B8 InvitedUsersOptional; // 0x18
        public 0x665BB4B8 InvitedUsers; // 0x20
        public Oculus.Platform.Models.User LeaderOptional; // 0x28
        public Oculus.Platform.Models.User Leader; // 0x30
        public Oculus.Platform.Models.Room RoomOptional; // 0x38
        public Oculus.Platform.Models.Room Room; // 0x40
        public 0x665BB4B8 UsersOptional; // 0x48
        public 0x665BB4B8 Users; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA5FC0
    }

    public class PartyID : Object
    {
        public ulong ID; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA6710
    }

    public class PartyUpdateNotification : Object
    {
        public 0x665B7890 Action; // 0x10
        public ulong PartyId; // 0x18
        public ulong SenderId; // 0x20
        public string UpdateTimestamp; // 0x28
        public string UserAlias; // 0x30
        public ulong UserId; // 0x38
        public string UserName; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA67D0
    }

    public class Pid : Object
    {
        public string Id; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA6C70
    }

    public class PingResult : Object
    {
        public ulong ID; // 0x10
        public System.Nullable`1<ulong> PingTimeUsec; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA71C0
        public void get_ID(){} // RVA: 0x7FFD4E35C380
        public void set_ID(){} // RVA: 0x7FFD4F83EFB0
        public void get_PingTimeUsec(){} // RVA: 0x7FFD53CA71D0
        public void get_IsTimeout(){} // RVA: 0x7FFD53CA7230
    }

    public class PlatformInitialize : Object
    {
        public 0x665B8440 Result; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA7270
    }

    public class Product : Object
    {
        public string Description; // 0x10
        public string FormattedPrice; // 0x18
        public string Name; // 0x20
        public string Sku; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA7330
    }

    public class Purchase : Object
    {
        public string DeveloperPayload; // 0x10
        public System.DateTime ExpirationTime; // 0x18
        public System.DateTime GrantTime; // 0x20
        public string ID; // 0x28
        public string ReportingId; // 0x30
        public string Sku; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA7B50
    }

    public class RejoinDialogResult : Object
    {
        public bool RejoinSelected; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA84A0
    }

    public class Room : Object
    {
        public ulong ApplicationID; // 0x10
        public System.Collections.Generic.Dictionary`2<string,string> DataStore; // 0x18
        public string Description; // 0x20
        public ulong ID; // 0x28
        public 0x665BB4B8 InvitedUsersOptional; // 0x30
        public 0x665BB4B8 InvitedUsers; // 0x38
        public bool IsMembershipLocked; // 0x40
        public 0x665B8860 JoinPolicy; // 0x44
        public 0x665B8808 Joinability; // 0x48
        public 0x665BA750 MatchedUsersOptional; // 0x50
        public 0x665BA750 MatchedUsers; // 0x58
        public uint MaxUsers; // 0x60
        public string Name; // 0x68
        public Oculus.Platform.Models.User OwnerOptional; // 0x70
        public Oculus.Platform.Models.User Owner; // 0x78
        public 0x665BB408 TeamsOptional; // 0x80
        public 0x665BB408 Teams; // 0x88
        public 0x665B8968 Type; // 0x90
        public 0x665BB4B8 UsersOptional; // 0x98
        public 0x665BB4B8 Users; // 0xA0
        public uint Version; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA8570
    }

    public class RoomInviteNotification : Object
    {
        public ulong ID; // 0x10
        public ulong RoomID; // 0x18
        public ulong SenderID; // 0x20
        public System.DateTime SentTime; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA9780
    }

    public class SdkAccount : Object
    {
        public 0x665B8A18 AccountType; // 0x10
        public ulong UserId; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CA9DA0
    }

    public class SendInvitesResult : Object
    {
        public 0x665B9410 Invites; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CAA290
    }

    public class ShareMediaResult : Object
    {
        public 0x665B8B20 Status; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CAA3E0
    }

    public class SupplementaryMetric : Object
    {
        public ulong ID; // 0x10
        public long Metric; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CAA4A0
    }

    public class SystemVoipState : Object
    {
        public 0x665B8F98 MicrophoneMuted; // 0x10
        public 0x665B8C80 Status; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CAA5D0
    }

    public class Team : Object
    {
        public 0x665BB4B8 AssignedUsers; // 0x10
        public int MaxUsers; // 0x18
        public int MinUsers; // 0x1C
        public string Name; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CAA700
    }

    public class User : Object
    {
        public string DisplayName; // 0x10
        public ulong ID; // 0x18
        public string ImageURL; // 0x20
        public string InviteToken; // 0x28
        public string OculusID; // 0x30
        public string Presence; // 0x38
        public string PresenceDeeplinkMessage; // 0x40
        public string PresenceDestinationApiName; // 0x48
        public string PresenceLobbySessionId; // 0x50
        public string PresenceMatchSessionId; // 0x58
        public 0x665B8DE0 PresenceStatus; // 0x60
        public string SmallImageUrl; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CAACE0
    }

    public class UserAndRoom : Object
    {
        public Oculus.Platform.Models.Room RoomOptional; // 0x10
        public Oculus.Platform.Models.Room Room; // 0x18
        public Oculus.Platform.Models.User User; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CABB40
    }

    public class UserCapability : Object
    {
        public string Description; // 0x10
        public bool IsEnabled; // 0x18
        public string Name; // 0x20
        public string ReasonCode; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CAC240
    }

    public class UserDataStoreUpdateResponse : Object
    {
        public bool Success; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CAC9D0
    }

    public class UserProof : Object
    {
        public string Value; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CACAA0
    }

    public class UserReportID : Object
    {
        public bool DidCancel; // 0x10
        public ulong ID; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53CACBF0
    }

}