// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 10
// Methods: 10

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class MatchmakingAdminSnapshot : Object
    {
        public Oculus.Platform.Models.MatchmakingAdminSnapshotCandidateList Candidates; // 0x10
        public double MyCurrentThreshold; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8883400
    }

    public class MatchmakingAdminSnapshotCandidate : Object
    {
        public bool CanMatch; // 0x10
        public double MyTotalScore; // 0x18
        public double TheirCurrentThreshold; // 0x20
        public double TheirTotalScore; // 0x28
        public string TraceId; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88835B0
    }

    public class MatchmakingAdminSnapshotCandidateList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8883880
    }

    public class MatchmakingBrowseResult : Object
    {
        public Oculus.Platform.Models.MatchmakingEnqueueResult EnqueueResult; // 0x10
        public Oculus.Platform.Models.RoomList Rooms; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8883B60
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
        public void .ctor(){} // RVA: 0x7FFAC8884380
    }

    public class MatchmakingEnqueueResultAndRoom : Object
    {
        public Oculus.Platform.Models.MatchmakingEnqueueResult MatchmakingEnqueueResult; // 0x10
        public Oculus.Platform.Models.Room Room; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88848E0
    }

    public class MatchmakingEnqueuedUser : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> CustomData; // 0x10
        public Oculus.Platform.Models.User UserOptional; // 0x18
        public Oculus.Platform.Models.User User; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8883DB0
    }

    public class MatchmakingEnqueuedUserList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC88840A0
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
        public void .ctor(){} // RVA: 0x7FFAC8884B30
    }

    public class MicrophoneAvailabilityState : Object
    {
        public bool MicrophoneAvailable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8884DD0
    }

}