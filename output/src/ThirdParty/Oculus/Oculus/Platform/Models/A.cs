// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 16
// Methods: 16

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class AbuseReportRecording : Object
    {
        public string RecordingUuid; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8877EA0
    }

    public class AchievementDefinition : Object
    {
        public 0x6B2546B8 Type; // 0x10
        public string Name; // 0x18
        public uint BitfieldLength; // 0x20
        public ulong Target; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8877FF0
    }

    public class AchievementDefinitionList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8878260
    }

    public class AchievementProgress : Object
    {
        public string Bitfield; // 0x10
        public ulong Count; // 0x18
        public bool IsUnlocked; // 0x20
        public string Name; // 0x28
        public System.DateTime UnlockTime; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8878650
    }

    public class AchievementProgressList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8878A00
    }

    public class AchievementUpdate : Object
    {
        public bool JustUnlocked; // 0x10
        public string Name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8878DF0
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
        public void .ctor(){} // RVA: 0x7FFAC8878FC0
    }

    public class ApplicationInviteList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8879610
    }

    public class ApplicationVersion : Object
    {
        public int CurrentCode; // 0x10
        public string CurrentName; // 0x18
        public int LatestCode; // 0x20
        public string LatestName; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8879A00
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
        public void .ctor(){} // RVA: 0x7FFAC8879D00
    }

    public class AssetDetailsList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887A430
    }

    public class AssetFileDeleteResult : Object
    {
        public ulong AssetFileId; // 0x10
        public ulong AssetId; // 0x18
        public string Filepath; // 0x20
        public bool Success; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887A710
    }

    public class AssetFileDownloadCancelResult : Object
    {
        public ulong AssetFileId; // 0x10
        public ulong AssetId; // 0x18
        public string Filepath; // 0x20
        public bool Success; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887A990
    }

    public class AssetFileDownloadResult : Object
    {
        public ulong AssetId; // 0x10
        public string Filepath; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887AC10
    }

    public class AssetFileDownloadUpdate : Object
    {
        public ulong AssetFileId; // 0x10
        public ulong AssetId; // 0x18
        public ulong BytesTotal; // 0x20
        public long BytesTransferred; // 0x28
        public bool Completed; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887ADD0
    }

    public class AvatarEditorResult : Object
    {
        public bool RequestSent; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC887B020
    }

}