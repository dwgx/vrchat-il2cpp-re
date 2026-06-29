// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 17
// Methods: 17

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class LanguagePackInfo : Object
    {
        public object EnglishName;
        public object NativeName;
        public object Tag;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5BFF0
    }

    public class LaunchBlockFlowResult : Object
    {
        public object DidBlock;
        public object DidCancel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5C340
    }

    public class LaunchDetails : Object
    {
        public object DeeplinkMessage;
        public object DestinationApiName;
        public object LaunchSource;
        public object LaunchType;
        public object RoomID;
        public object TrackingID;
        public object UsersOptional;
        public object Users;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5C480
    }

    public class LaunchFriendRequestFlowResult : Object
    {
        public object DidCancel;
        public object DidSendRequest;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5CB00
    }

    public class LaunchInvitePanelFlowResult : Object
    {
        public object InvitedUsers;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5CC40
    }

    public class LaunchReportFlowResult : Object
    {
        public object DidCancel;
        public object UserReportId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5CD90
    }

    public class LaunchUnblockFlowResult : Object
    {
        public object DidCancel;
        public object DidUnblock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5CED0
    }

    public class Leaderboard : Object
    {
        public object ApiName;
        public object DestinationOptional;
        public object Destination;
        public object ID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5D010
    }

    public class LeaderboardEntry : Object
    {
        public object DisplayScore;
        public object ExtraData;
        public object ID;
        public object Rank;
        public object Score;
        public object SupplementaryMetricOptional;
        public object SupplementaryMetric;
        public object Timestamp;
        public object User;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5D770
    }

    public class LeaderboardEntryList : DeserializableList`1
    {
        public object TotalCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5DF00
    }

    public class LeaderboardList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5D390
    }

    public class LinkedAccount : Object
    {
        public object AccessToken;
        public object ServiceProvider;
        public object UserId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5E430
    }

    public class LinkedAccountList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5E6E0
    }

    public class LivestreamingApplicationStatus : Object
    {
        public object StreamingEnabled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5E9B0
    }

    public class LivestreamingStartResult : Object
    {
        public object StreamingResult;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5EA80
    }

    public class LivestreamingStatus : Object
    {
        public object CommentsVisible;
        public object IsPaused;
        public object LivestreamingEnabled;
        public object LivestreamingType;
        public object MicEnabled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5EB40
    }

    public class LivestreamingVideoStats : Object
    {
        public object CommentCount;
        public object ReactionCount;
        public object TotalViews;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5ED90
    }

}