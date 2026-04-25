// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 13
// Methods: 13

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class CalApplicationFinalized : Object
    {
        public int CountdownMS; // 0x10
        public ulong ID; // 0x18
        public string LaunchDetails; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887B630
    }

    public class CalApplicationProposed : Object
    {
        public ulong ID; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887B840
    }

    public class CalApplicationSuggestion : Object
    {
        public ulong ID; // 0x10
        public string SocialContext; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887B900
    }

    public class CalApplicationSuggestionList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887BAC0
    }

    public class Challenge : Object
    {
        public 0x6B254C38 CreationType; // 0x10
        public string Description; // 0x18
        public System.DateTime EndDate; // 0x20
        public ulong ID; // 0x28
        public Oculus.Platform.Models.UserList InvitedUsersOptional; // 0x30
        public Oculus.Platform.Models.UserList InvitedUsers; // 0x38
        public Oculus.Platform.Models.Leaderboard Leaderboard; // 0x40
        public Oculus.Platform.Models.UserList ParticipantsOptional; // 0x48
        public Oculus.Platform.Models.UserList Participants; // 0x50
        public System.DateTime StartDate; // 0x58
        public string Title; // 0x60
        public 0x6B254D40 Visibility; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887BF20
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
        public void .ctor(){} // RVA: 0x7FFAC887CD50
    }

    public class ChallengeEntryList : DeserializableList`1
    {
        public ulong TotalCount; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887D250
    }

    public class ChallengeList : DeserializableList`1
    {
        public ulong TotalCount; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887C810
    }

    public class CloudStorageConflictMetadata : Object
    {
        public Oculus.Platform.Models.CloudStorageMetadata Local; // 0x10
        public Oculus.Platform.Models.CloudStorageMetadata Remote; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887D790
    }

    public class CloudStorageData : Object
    {
        public string Bucket; // 0x10
        public byte[] Data; // 0x18
        public uint DataSize; // 0x20
        public string Key; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887D9D0
    }

    public class CloudStorageMetadata : Object
    {
        public string Bucket; // 0x10
        public long Counter; // 0x18
        public uint DataSize; // 0x20
        public string ExtraData; // 0x28
        public string Key; // 0x30
        public ulong SaveTime; // 0x38
        public 0x6B254D98 Status; // 0x40
        public string VersionHandle; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887DDC0
    }

    public class CloudStorageMetadataList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887E350
    }

    public class CloudStorageUpdateResponse : Object
    {
        public string Bucket; // 0x10
        public string Key; // 0x18
        public 0x6B254DF0 Status; // 0x20
        public string VersionHandle; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887E740
    }

}