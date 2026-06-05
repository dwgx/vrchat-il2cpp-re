// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.AmplitudeSDKWrapper
// Classes: 4
// Methods: 78

namespace ThirdParty.Other.AmplitudeSDKWrapper
{
    public class AmplitudeWrapper
    {
        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7FFAFC2EBD60
        public void set_Logger(){} // RVA: 0x7FFAFC2EBDC0
        public void add_OnExperimentsUpdated(){} // RVA: 0x7FFAFC2EBE80
        public void remove_OnExperimentsUpdated(){} // RVA: 0x7FFAFC2EBFD0
        public void get_Instance(){} // RVA: 0x7FFAFC2EC120
        public void set_Instance(){} // RVA: 0x7FFAFC2EC180
        public void Initialize(){} // RVA: 0x7FFAFC2EC240
        public void .ctor(){} // RVA: 0x7FFAFC2EC370
        public void Init(){} // RVA: 0x7FFAFC2EC5F0
        public void ClearCachedData(){} // RVA: 0x7FFAFC2ECC00
        public void OnApplicationFocused(){} // RVA: 0x7FFAF2D8D310
        public void OnApplicationPaused(){} // RVA: 0x7FFAFC2ECCB0
        public void OnApplicationQuit(){} // RVA: 0x7FFAFC2ECCD0
        public void HasPendingEvents(){} // RVA: 0x7FFAFC2ECD10
        public void SetUserId(){} // RVA: 0x7FFAFC2ECD50
        public void SetSessionId(){} // RVA: 0x7FFAFC2ECF80
        public void GetSessionId(){} // RVA: 0x7FFAF2F476A0
        public void SetBuildVersion(){} // RVA: 0x7FFAFC2ECF90
        public void InitializeUserId(){} // RVA: 0x7FFAFC2ED120
        public void InitializeDeviceId(){} // RVA: 0x7FFAF8E30700
        public void SetUserProperties(){} // RVA: 0x7FFAFC2ED190
        public void LogEvent(){} // RVA: 0x7FFAFC2ED320
        public void LogEventInternal(){} // RVA: 0x7FFAFC2ED510
        public void SaveSessionLastActiveTime(){} // RVA: 0x7FFAFC2EE360
        public void GetSessionLastActiveTime(){} // RVA: 0x7FFAFC2EE3F0
        public void ScheduleSaveEventCache(){} // RVA: 0x7FFAFC2EE470
        public void UpdateServer(){} // RVA: 0x7FFAFC2EE500
        public void UpdateServerDelayed(){} // RVA: 0x7FFAFC2EE880
        public void PostEvents(){} // RVA: 0x7FFAFC2EEAB0
        public void StartNewSession(){} // RVA: 0x7FFAFC2EF150
        public void StartSession(){} // RVA: 0x7FFAFC2EF400
        public void EndSession(){} // RVA: 0x7FFAFC2EF880
        public void SaveAndUploadEvents(){} // RVA: 0x7FFAFC2EFA90
        public void CurrentTimeMillis(){} // RVA: 0x7FFAFC2EFB30
        public void Hash(){} // RVA: 0x7FFAF30B4140
        public void Merge(){} // RVA: 0x7FFAF2ADDC60
        public void get_Experiments(){} // RVA: 0x7FFAFC2EFBE0
        public void set_Experiments(){} // RVA: 0x7FFAFC2EFC40
        public void IsInExperiment(){} // RVA: 0x7FFAFC2EFD00
        public void IsInExperimentSegment(){} // RVA: 0x7FFAFC2EFDD0
        public void GetExperimentPayloadValue(){} // RVA: 0x7FFAF2D33FA0 | overloaded x5
        public void GetExperimentAssignedSegmentName(){} // RVA: 0x7FFAFC2F00D0
        public void GetExperimentPayload(){} // RVA: 0x7FFAFC2F01B0
        public void SetExperiments(){} // RVA: 0x7FFAFC2F0870
        public void GetApiKey(){} // RVA: 0x7FFAFC2F0C20
        public void .cctor(){} // RVA: 0x7FFAFC2F0CC0
        public void <Init>b__63_0(){} // RVA: 0x7FFAFC2F0FA0
        public void <ClearCachedData>b__64_0(){} // RVA: 0x7FFAFC2F0FB0
        public void <ScheduleSaveEventCache>b__80_0(){} // RVA: 0x7FFAFC2F0FC0
        public void <ScheduleSaveEventCache>b__80_1(){} // RVA: 0x7FFAFC2F1070
        public void <UpdateServerDelayed>b__82_0(){} // RVA: 0x7FFAFC2F1090
        public void <SaveAndUploadEvents>b__87_0(){} // RVA: 0x7FFAFC2F1520
    }

    public class DatabaseHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2F4670
        public void AddEvent(){} // RVA: 0x7FFAFC2F4870
        public void GetEventCount(){} // RVA: 0x7FFAFC2F4A30
        public void GetEvents(){} // RVA: 0x7FFAFC2F4BA0
        public void RemoveEvents(){} // RVA: 0x7FFAFC2F4DD0
        public void RemoveEventsUpTo(){} // RVA: 0x7FFAFC2F5050
        public void SaveToCache(){} // RVA: 0x7FFAFC2F53C0
        public void LoadFromCache(){} // RVA: 0x7FFAFC2F56E0
        public void GetCacheFilePath(){} // RVA: 0x7FFAFC2F5D40
    }

    public class DeviceInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2F5DB0
        public void GetOsName(){} // RVA: 0x7FFAF2DA8380
        public void GetOsVersion(){} // RVA: 0x7FFAFC2F5DC0
        public void GetModel(){} // RVA: 0x7FFAF2D907C0
        public void GetDeviceName(){} // RVA: 0x7FFAF2DBB0C0
        public void GetLanguage(){} // RVA: 0x7FFAF2DBB130
        public void GetPlatform(){} // RVA: 0x7FFAF30E74D0
        public void CacheValues(){} // RVA: 0x7FFAFC2F5E00
    }

    public class LimitedConcurrencyLevelTaskScheduler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFC2F6390
        public void QueueTask(){} // RVA: 0x7FFAFC2F6490
        public void NotifyThreadPoolOfPendingWork(){} // RVA: 0x7FFAFC2F6680
        public void HasAnyPendingTasks(){} // RVA: 0x7FFAFC2F6700
        public void <NotifyThreadPoolOfPendingWork>b__5_0(){} // RVA: 0x7FFAFC2F6870
    }

}