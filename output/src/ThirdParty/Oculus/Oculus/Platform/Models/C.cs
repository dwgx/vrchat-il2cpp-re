// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 13
// Methods: 13

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class CalApplicationFinalized : Object
    {
        public object CountdownMS;
        public object ID;
        public object LaunchDetails;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B571A0
    }

    public class CalApplicationProposed : Object
    {
        public object ID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B573B0
    }

    public class CalApplicationSuggestion : Object
    {
        public object ID;
        public object SocialContext;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B57470
    }

    public class CalApplicationSuggestionList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B57630
    }

    public class Challenge : Object
    {
        public object CreationType;
        public object Description;
        public object EndDate;
        public object ID;
        public object InvitedUsersOptional;
        public object InvitedUsers;
        public object Leaderboard;
        public object ParticipantsOptional;
        public object Participants;
        public object StartDate;
        public object Title;
        public object Visibility;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B57A80
    }

    public class ChallengeEntry : Object
    {
        public object DisplayScore;
        public object ExtraData;
        public object ID;
        public object Rank;
        public object Score;
        public object Timestamp;
        public object User;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B588B0
    }

    public class ChallengeEntryList : DeserializableList`1
    {
        public object TotalCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B58DB0
    }

    public class ChallengeList : DeserializableList`1
    {
        public object TotalCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B58380
    }

    public class CloudStorageConflictMetadata : Object
    {
        public object Local;
        public object Remote;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B592E0
    }

    public class CloudStorageData : Object
    {
        public object Bucket;
        public object Data;
        public object DataSize;
        public object Key;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B59520
    }

    public class CloudStorageMetadata : Object
    {
        public object Bucket;
        public object Counter;
        public object DataSize;
        public object ExtraData;
        public object Key;
        public object SaveTime;
        public object Status;
        public object VersionHandle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B59910
    }

    public class CloudStorageMetadataList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B59EB0
    }

    public class CloudStorageUpdateResponse : Object
    {
        public object Bucket;
        public object Key;
        public object Status;
        public object VersionHandle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5A290
    }

}