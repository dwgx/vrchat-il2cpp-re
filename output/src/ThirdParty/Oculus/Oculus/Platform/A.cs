// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Oculus.Oculus.Platform
// Classes: 11
// Methods: 61

namespace ThirdParty.Oculus.Oculus.Platform
{
    public class AbuseReport : Object
    {
        // ── Methods ──
        public void ReportRequestHandled(){} // RVA: 0x7FFAC88685B0
        public void SetReportButtonPressedNotificationCallback(){} // RVA: 0x7FFAC8868750
    }

    public class AbuseReportOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8818CC0
        public void SetPreventPeopleChooser(){} // RVA: 0x7FFAC8818D70
        public void SetReportType(){} // RVA: 0x7FFAC8818E30
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC8818F00
    }

    public class Achievements : Object
    {
        // ── Methods ──
        public void AddCount(){} // RVA: 0x7FFAC88687C0
        public void AddFields(){} // RVA: 0x7FFAC8868A00
        public void GetAllDefinitions(){} // RVA: 0x7FFAC8868C60
        public void GetAllProgress(){} // RVA: 0x7FFAC8868E10
        public void GetDefinitionsByName(){} // RVA: 0x7FFAC8868FC0
        public void GetProgressByName(){} // RVA: 0x7FFAC8869270
        public void Unlock(){} // RVA: 0x7FFAC8869520
        public void GetNextAchievementDefinitionListPage(){} // RVA: 0x7FFAC8869750
        public void GetNextAchievementProgressListPage(){} // RVA: 0x7FFAC8869900
    }

    public class AdvancedAbuseReportOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8818FF0
        public void SetDeveloperDefinedContext(){} // RVA: 0x7FFAC88190A0
        public void ClearDeveloperDefinedContext(){} // RVA: 0x7FFAC8819210
        public void SetObjectType(){} // RVA: 0x7FFAC88192D0
        public void SetReportType(){} // RVA: 0x7FFAC8819410
        public void AddSuggestedUser(){} // RVA: 0x7FFAC88194D0
        public void ClearSuggestedUsers(){} // RVA: 0x7FFAC88195A0
        public void SetVideoMode(){} // RVA: 0x7FFAC8819660
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC8819720
    }

    public class AndroidPlatform : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC2F21320
        public void AsyncInitialize(){} // RVA: 0x7FFAC8819810
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Application : Object
    {
        // ── Methods ──
        public void GetVersion(){} // RVA: 0x7FFAC8869AB0
        public void LaunchOtherApp(){} // RVA: 0x7FFAC8869C60
    }

    public class ApplicationLifecycle : Object
    {
        // ── Methods ──
        public void GetLaunchDetails(){} // RVA: 0x7FFAC885BDA0
        public void LogDeeplinkResult(){} // RVA: 0x7FFAC885BE80
        public void SetLaunchIntentChangedNotificationCallback(){} // RVA: 0x7FFAC885BFB0
    }

    public class ApplicationOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8819860
        public void SetDeeplinkMessage(){} // RVA: 0x7FFAC8819910
        public void SetDestinationApiName(){} // RVA: 0x7FFAC8819A50
        public void SetLobbySessionId(){} // RVA: 0x7FFAC8819B90
        public void SetMatchSessionId(){} // RVA: 0x7FFAC8819CD0
        public void SetRoomId(){} // RVA: 0x7FFAC8819E10
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC8819EE0
    }

    public class AssetFile : Object
    {
        // ── Methods ──
        public void Delete(){} // RVA: 0x7FFAC8869E30
        public void DeleteById(){} // RVA: 0x7FFAC8869FF0
        public void DeleteByName(){} // RVA: 0x7FFAC886A1B0
        public void Download(){} // RVA: 0x7FFAC886A3E0
        public void DownloadById(){} // RVA: 0x7FFAC886A5A0
        public void DownloadByName(){} // RVA: 0x7FFAC886A760
        public void DownloadCancel(){} // RVA: 0x7FFAC886A990
        public void DownloadCancelById(){} // RVA: 0x7FFAC886AB50
        public void DownloadCancelByName(){} // RVA: 0x7FFAC886AD10
        public void GetList(){} // RVA: 0x7FFAC886AF40
        public void Status(){} // RVA: 0x7FFAC886B0F0
        public void StatusById(){} // RVA: 0x7FFAC886B2B0
        public void StatusByName(){} // RVA: 0x7FFAC886B470
        public void SetDownloadUpdateNotificationCallback(){} // RVA: 0x7FFAC886B6A0
    }

    public class Avatar : Object
    {
        // ── Methods ──
        public void LaunchAvatarEditor(){} // RVA: 0x7FFAC886B710
    }

    public class AvatarEditorOptions : Object
    {
        public UIntPtr Handle; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8819FD0
        public void SetSourceOverride(){} // RVA: 0x7FFAC881A080
        public void op_Explicit(){} // RVA: 0x7FFAC8818EF0
        public void Finalize(){} // RVA: 0x7FFAC881A1C0
    }

}