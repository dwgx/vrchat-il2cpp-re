// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 10
// Methods: 10

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class MatchmakingAdminSnapshot : Object
    {
        public object Candidates;
        public object MyCurrentThreshold;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5EFA0
    }

    public class MatchmakingAdminSnapshotCandidate : Object
    {
        public object CanMatch;
        public object MyTotalScore;
        public object TheirCurrentThreshold;
        public object TheirTotalScore;
        public object TraceId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5F160
    }

    public class MatchmakingAdminSnapshotCandidateList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5F430
    }

    public class MatchmakingBrowseResult : Object
    {
        public object EnqueueResult;
        public object Rooms;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5F700
    }

    public class MatchmakingEnqueueResult : Object
    {
        public object AdminSnapshotOptional;
        public object AdminSnapshot;
        public object AverageWait;
        public object MatchesInLastHourCount;
        public object MaxExpectedWait;
        public object Pool;
        public object RecentMatchPercentage;
        public object RequestHash;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5FF10
    }

    public class MatchmakingEnqueueResultAndRoom : Object
    {
        public object MatchmakingEnqueueResult;
        public object Room;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B60470
    }

    public class MatchmakingEnqueuedUser : Object
    {
        public object CustomData;
        public object UserOptional;
        public object User;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5F950
    }

    public class MatchmakingEnqueuedUserList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B5FC40
    }

    public class MatchmakingStats : Object
    {
        public object DrawCount;
        public object LossCount;
        public object SkillLevel;
        public object SkillMean;
        public object SkillStandardDeviation;
        public object WinCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B606C0
    }

    public class MicrophoneAvailabilityState : Object
    {
        public object MicrophoneAvailable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B60960
    }

}