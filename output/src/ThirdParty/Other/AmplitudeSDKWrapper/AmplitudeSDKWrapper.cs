// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.AmplitudeSDKWrapper
// Classes: 4
// Methods: 78

namespace ThirdParty.Other.AmplitudeSDKWrapper
{
    public class AmplitudeWrapper
    {
        public string EVENT_LOG_URL;
        public int EVENT_UPLOAD_THRESHOLD;
        public int EVENT_UPLOAD_MAX_BATCH_SIZE;

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x983BD60
        public void set_Logger(){} // RVA: 0x983BDC0
        public void add_OnExperimentsUpdated(){} // RVA: 0x983BE80
        public void remove_OnExperimentsUpdated(){} // RVA: 0x983BFD0
        public void get_Instance(){} // RVA: 0x983C120
        public void set_Instance(){} // RVA: 0x983C180
        public void Initialize(){} // RVA: 0x983C240
        public void .ctor(){} // RVA: 0x983C370
        public void Init(){} // RVA: 0x983C5F0
        public void ClearCachedData(){} // RVA: 0x983CC00
        public void OnApplicationFocused(){} // RVA: 0x2DD310
        public void OnApplicationPaused(){} // RVA: 0x983CCB0
        public void OnApplicationQuit(){} // RVA: 0x983CCD0
        public void HasPendingEvents(){} // RVA: 0x983CD10
        public void SetUserId(){} // RVA: 0x983CD50
        public void SetSessionId(){} // RVA: 0x983CF80
        public void GetSessionId(){} // RVA: 0x4976A0
        public void SetBuildVersion(){} // RVA: 0x983CF90
        public void InitializeUserId(){} // RVA: 0x983D120
        public void InitializeDeviceId(){} // RVA: 0x6380700
        public void SetUserProperties(){} // RVA: 0x983D190
        public void LogEvent(){} // RVA: 0x983D320
        public void LogEventInternal(){} // RVA: 0x983D510
        public void SaveSessionLastActiveTime(){} // RVA: 0x983E360
        public void GetSessionLastActiveTime(){} // RVA: 0x983E3F0
        public void ScheduleSaveEventCache(){} // RVA: 0x983E470
        public void UpdateServer(){} // RVA: 0x983E500
        public void UpdateServerDelayed(){} // RVA: 0x983E880
        public void PostEvents(){} // RVA: 0x983EAB0
        public void StartNewSession(){} // RVA: 0x983F150
        public void StartSession(){} // RVA: 0x983F400
        public void EndSession(){} // RVA: 0x983F880
        public void SaveAndUploadEvents(){} // RVA: 0x983FA90
        public void CurrentTimeMillis(){} // RVA: 0x983FB30
        public void Hash(){} // RVA: 0x604140
        public void Merge(){} // RVA: 0x2DC60
        public void get_Experiments(){} // RVA: 0x983FBE0
        public void set_Experiments(){} // RVA: 0x983FC40
        public void IsInExperiment(){} // RVA: 0x983FD00
        public void IsInExperimentSegment(){} // RVA: 0x983FDD0
        public void GetExperimentPayloadValue(){} // RVA: 0x283FA0 | overloaded x5
        public void GetExperimentAssignedSegmentName(){} // RVA: 0x98400D0
        public void GetExperimentPayload(){} // RVA: 0x98401B0
        public void SetExperiments(){} // RVA: 0x9840870
        public void GetApiKey(){} // RVA: 0x9840C20
        public void .cctor(){} // RVA: 0x9840CC0
        public void <Init>b__63_0(){} // RVA: 0x9840FA0
        public void <ClearCachedData>b__64_0(){} // RVA: 0x9840FB0
        public void <ScheduleSaveEventCache>b__80_0(){} // RVA: 0x9840FC0
        public void <ScheduleSaveEventCache>b__80_1(){} // RVA: 0x9841070
        public void <UpdateServerDelayed>b__82_0(){} // RVA: 0x9841090
        public void <SaveAndUploadEvents>b__87_0(){} // RVA: 0x9841520
    }

    public class DatabaseHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9844670
        public void AddEvent(){} // RVA: 0x9844870
        public void GetEventCount(){} // RVA: 0x9844A30
        public void GetEvents(){} // RVA: 0x9844BA0
        public void RemoveEvents(){} // RVA: 0x9844DD0
        public void RemoveEventsUpTo(){} // RVA: 0x9845050
        public void SaveToCache(){} // RVA: 0x98453C0
        public void LoadFromCache(){} // RVA: 0x98456E0
        public void GetCacheFilePath(){} // RVA: 0x9845D40
    }

    public class DeviceInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9845DB0
        public void GetOsName(){} // RVA: 0x2F8380
        public void GetOsVersion(){} // RVA: 0x9845DC0
        public void GetModel(){} // RVA: 0x2E07C0
        public void GetDeviceName(){} // RVA: 0x30B0C0
        public void GetLanguage(){} // RVA: 0x30B130
        public void GetPlatform(){} // RVA: 0x6374D0
        public void CacheValues(){} // RVA: 0x9845E00
    }

    public class LimitedConcurrencyLevelTaskScheduler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x9846390
        public void QueueTask(){} // RVA: 0x9846490
        public void NotifyThreadPoolOfPendingWork(){} // RVA: 0x9846680
        public void HasAnyPendingTasks(){} // RVA: 0x9846700
        public void <NotifyThreadPoolOfPendingWork>b__5_0(){} // RVA: 0x9846870
    }

}