// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 17
// Methods: 17

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class LanguagePackInfo : Object
    {
        public string EnglishName; // 0x10
        public string NativeName; // 0x18
        public string Tag; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8880470
    }

    public class LaunchBlockFlowResult : Object
    {
        public bool DidBlock; // 0x10
        public bool DidCancel; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88807B0
    }

    public class LaunchDetails : Object
    {
        public string DeeplinkMessage; // 0x10
        public string DestinationApiName; // 0x18
        public string LaunchSource; // 0x20
        public 0x6B2550B0 LaunchType; // 0x28
        public ulong RoomID; // 0x30
        public string TrackingID; // 0x38
        public Oculus.Platform.Models.UserList UsersOptional; // 0x40
        public Oculus.Platform.Models.UserList Users; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88808F0
    }

    public class LaunchFriendRequestFlowResult : Object
    {
        public bool DidCancel; // 0x10
        public bool DidSendRequest; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8880F60
    }

    public class LaunchInvitePanelFlowResult : Object
    {
        public Oculus.Platform.Models.UserList InvitedUsers; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88810A0
    }

    public class LaunchReportFlowResult : Object
    {
        public bool DidCancel; // 0x10
        public ulong UserReportId; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88811F0
    }

    public class LaunchUnblockFlowResult : Object
    {
        public bool DidCancel; // 0x10
        public bool DidUnblock; // 0x11

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8881330
    }

    public class Leaderboard : Object
    {
        public string ApiName; // 0x10
        public Oculus.Platform.Models.Destination DestinationOptional; // 0x18
        public Oculus.Platform.Models.Destination Destination; // 0x20
        public ulong ID; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8881470
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
        public void .ctor(){} // RVA: 0x7FFAC8881BD0
    }

    public class LeaderboardEntryList : DeserializableList`1
    {
        public ulong TotalCount; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8882350
    }

    public class LeaderboardList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88817E0
    }

    public class LinkedAccount : Object
    {
        public string AccessToken; // 0x10
        public 0x6B258AC8 ServiceProvider; // 0x18
        public string UserId; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8882890
    }

    public class LinkedAccountList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8882B30
    }

    public class LivestreamingApplicationStatus : Object
    {
        public bool StreamingEnabled; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8882E10
    }

    public class LivestreamingStartResult : Object
    {
        public 0x6B255268 StreamingResult; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8882EE0
    }

    public class LivestreamingStatus : Object
    {
        public bool CommentsVisible; // 0x10
        public bool IsPaused; // 0x11
        public bool LivestreamingEnabled; // 0x12
        public int LivestreamingType; // 0x14
        public bool MicEnabled; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8882FA0
    }

    public class LivestreamingVideoStats : Object
    {
        public int CommentCount; // 0x10
        public int ReactionCount; // 0x14
        public string TotalViews; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88831F0
    }

}