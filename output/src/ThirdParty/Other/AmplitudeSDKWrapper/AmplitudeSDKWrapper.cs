// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.AmplitudeSDKWrapper
// Classes: 4
// Methods: 79

namespace ThirdParty.Other.AmplitudeSDKWrapper
{
    public class AmplitudeWrapper : Object
    {
        public string EVENT_LOG_URL;
        public int EVENT_UPLOAD_THRESHOLD;
        public int EVENT_UPLOAD_MAX_BATCH_SIZE;

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7FFE8A29E0A0
        public void set_Logger(){} // RVA: 0x7FFE8A29E100
        public void add_OnExperimentsUpdated(){} // RVA: 0x7FFE8A29E1B0
        public void remove_OnExperimentsUpdated(){} // RVA: 0x7FFE8A29E300
        public void get_Instance(){} // RVA: 0x7FFE8A29E450
        public void set_Instance(){} // RVA: 0x7FFE8A29E4B0
        public void Initialize(){} // RVA: 0x7FFE8A29E570
        public void .ctor(){} // RVA: 0x7FFE8A29E6A0
        public void Init(){} // RVA: 0x7FFE8A29E920
        public void ClearCachedData(){} // RVA: 0x7FFE8A29EF30
        public void OnApplicationFocused(){} // RVA: 0x7FFE810FB310
        public void OnApplicationPaused(){} // RVA: 0x7FFE8A29EFE0
        public void OnApplicationQuit(){} // RVA: 0x7FFE8A29F000
        public void HasPendingEvents(){} // RVA: 0x7FFE8A29F040
        public void SetUserId(){} // RVA: 0x7FFE8A29F080
        public void SetSessionId(){} // RVA: 0x7FFE8A29F2B0
        public void GetSessionId(){} // RVA: 0x7FFE8143BA80
        public void SetBuildVersion(){} // RVA: 0x7FFE8A29F2C0
        public void InitializeUserId(){} // RVA: 0x7FFE8A29F450
        public void InitializeDeviceId(){} // RVA: 0x7FFE86EC1120
        public void SetUserProperties(){} // RVA: 0x7FFE8A29F4C0
        public void LogEvent(){} // RVA: 0x7FFE8A29F8B0 | overloaded x2
        public void CheckedLogEvent(){} // RVA: 0x7FFE8A29F6B0
        public void SaveSessionLastActiveTime(){} // RVA: 0x7FFE8A2A07C0
        public void GetSessionLastActiveTime(){} // RVA: 0x7FFE8A2A0850
        public void ScheduleSaveEventCache(){} // RVA: 0x7FFE8A2A08D0
        public void UpdateServer(){} // RVA: 0x7FFE8A2A0960
        public void UpdateServerDelayed(){} // RVA: 0x7FFE8A2A0CE0
        public void PostEvents(){} // RVA: 0x7FFE8A2A0F10
        public void StartNewSession(){} // RVA: 0x7FFE8A2A15B0
        public void StartSession(){} // RVA: 0x7FFE8A2A1860
        public void EndSession(){} // RVA: 0x7FFE8A2A1CF0
        public void SaveAndUploadEvents(){} // RVA: 0x7FFE8A2A1F00
        public void CurrentTimeMillis(){} // RVA: 0x7FFE8A2A1FA0
        public void Hash(){} // RVA: 0x7FFE81407EB0
        public void Merge(){} // RVA: 0x7FFE80E4F230
        public void get_Experiments(){} // RVA: 0x7FFE8A2A20B0
        public void set_Experiments(){} // RVA: 0x7FFE8A2A2110
        public void IsInExperiment(){} // RVA: 0x7FFE8A2A21D0
        public void IsInExperimentSegment(){} // RVA: 0x7FFE8A2A22A0
        public void GetExperimentPayloadValue(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void GetExperimentAssignedSegmentName(){} // RVA: 0x7FFE8A2A25A0
        public void GetExperimentPayload(){} // RVA: 0x7FFE8A2A2680
        public void SetExperiments(){} // RVA: 0x7FFE8A2A2D40
        public void GetApiKey(){} // RVA: 0x7FFE8A2A30F0
        public void .cctor(){} // RVA: 0x7FFE8A2A3190
        public void <Init>b__61_0(){} // RVA: 0x7FFE8A2A3380
        public void <ClearCachedData>b__62_0(){} // RVA: 0x7FFE8A2A3390
        public void <ScheduleSaveEventCache>b__79_0(){} // RVA: 0x7FFE8A2A33A0
        public void <ScheduleSaveEventCache>b__79_1(){} // RVA: 0x7FFE8A2A3450
        public void <UpdateServerDelayed>b__81_0(){} // RVA: 0x7FFE8A2A3470
        public void <SaveAndUploadEvents>b__86_0(){} // RVA: 0x7FFE8A2A3900
    }

    public class DatabaseHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2A6A50
        public void AddEvent(){} // RVA: 0x7FFE8A2A6C50
        public void GetEventCount(){} // RVA: 0x7FFE8A2A6E10
        public void GetEvents(){} // RVA: 0x7FFE8A2A6F80
        public void RemoveEvents(){} // RVA: 0x7FFE8A2A71B0
        public void RemoveEventsUpTo(){} // RVA: 0x7FFE8A2A7430
        public void SaveToCache(){} // RVA: 0x7FFE8A2A77A0
        public void LoadFromCache(){} // RVA: 0x7FFE8A2A7AC0
        public void GetCacheFilePath(){} // RVA: 0x7FFE8A2A8120
    }

    public class DeviceInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2A8190
        public void GetOsName(){} // RVA: 0x7FFE81116380
        public void GetOsVersion(){} // RVA: 0x7FFE8A2A81A0
        public void GetModel(){} // RVA: 0x7FFE810FE7C0
        public void GetDeviceName(){} // RVA: 0x7FFE811290C0
        public void GetLanguage(){} // RVA: 0x7FFE81129130
        public void GetPlatform(){} // RVA: 0x7FFE8144E200
        public void CacheValues(){} // RVA: 0x7FFE8A2A81E0
    }

    public class LimitedConcurrencyLevelTaskScheduler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8A2A8770
        public void QueueTask(){} // RVA: 0x7FFE8A2A8870
        public void NotifyThreadPoolOfPendingWork(){} // RVA: 0x7FFE8A2A8A60
        public void HasAnyPendingTasks(){} // RVA: 0x7FFE8A2A8AE0
        public void <NotifyThreadPoolOfPendingWork>b__5_0(){} // RVA: 0x7FFE8A2A8C50
    }

}