// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform.Models
// Classes: 16
// Methods: 16

namespace ThirdParty.Oculus.Oculus.Platform.Models
{
    public class AbuseReportRecording : Object
    {
        public object RecordingUuid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B53A40
    }

    public class AchievementDefinition : Object
    {
        public object Type;
        public object Name;
        public object BitfieldLength;
        public object Target;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B53B90
    }

    public class AchievementDefinitionList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B53E00
    }

    public class AchievementProgress : Object
    {
        public object Bitfield;
        public object Count;
        public object IsUnlocked;
        public object Name;
        public object UnlockTime;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B541E0
    }

    public class AchievementProgressList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B54590
    }

    public class AchievementUpdate : Object
    {
        public object JustUnlocked;
        public object Name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B54970
    }

    public class ApplicationInvite : Object
    {
        public object DestinationOptional;
        public object Destination;
        public object ID;
        public object IsActive;
        public object LobbySessionId;
        public object MatchSessionId;
        public object RecipientOptional;
        public object Recipient;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B54B40
    }

    public class ApplicationInviteList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B551A0
    }

    public class ApplicationVersion : Object
    {
        public object CurrentCode;
        public object CurrentName;
        public object LatestCode;
        public object LatestName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B55580
    }

    public class AssetDetails : Object
    {
        public object AssetId;
        public object AssetType;
        public object DownloadStatus;
        public object Filepath;
        public object IapStatus;
        public object LanguageOptional;
        public object Language;
        public object Metadata;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B55890
    }

    public class AssetDetailsList : DeserializableList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B55FD0
    }

    public class AssetFileDeleteResult : Object
    {
        public object AssetFileId;
        public object AssetId;
        public object Filepath;
        public object Success;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B562A0
    }

    public class AssetFileDownloadCancelResult : Object
    {
        public object AssetFileId;
        public object AssetId;
        public object Filepath;
        public object Success;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B56520
    }

    public class AssetFileDownloadResult : Object
    {
        public object AssetId;
        public object Filepath;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B567A0
    }

    public class AssetFileDownloadUpdate : Object
    {
        public object AssetFileId;
        public object AssetId;
        public object BytesTotal;
        public object BytesTransferred;
        public object Completed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B56960
    }

    public class AvatarEditorResult : Object
    {
        public object RequestSent;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6B56BB0
    }

}