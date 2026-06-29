// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.AmplitudeSDKWrapper
// Classes: 4
// Methods: 76

namespace ThirdParty.Other.AmplitudeSDKWrapper
{
    public class AmplitudeWrapper : Object
    {
        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7B1676870
        public void set_Logger(){} // RVA: 0x7B16768D0
        public void get_DeviceIdOverride(){} // RVA: 0x7B1676990
        public void set_DeviceIdOverride(){} // RVA: 0x7B16769F0
        public void add_OnExperimentsUpdated(){} // RVA: 0x7B1676AB0
        public void remove_OnExperimentsUpdated(){} // RVA: 0x7B1676C00
        public void get_Instance(){} // RVA: 0x7B1676D50
        public void set_Instance(){} // RVA: 0x7B1676DB0
        public void Initialize(){} // RVA: 0x7B1676E70
        public void .ctor(){} // RVA: 0x7B1676FA0
        public void Init(){} // RVA: 0x7B16772A0
        public void ClearCachedData(){} // RVA: 0x7B1677960
        public void OnApplicationFocused(){} // RVA: 0x7A80D7310
        public void OnApplicationPaused(){} // RVA: 0x7B1677A10
        public void OnApplicationQuit(){} // RVA: 0x7B1677A30
        public void HasPendingEvents(){} // RVA: 0x7B1677A70
        public void SetUserId(){} // RVA: 0x7B1677AB0
        public void SetSessionId(){} // RVA: 0x7B1677C90
        public void GetSessionId(){} // RVA: 0x7A8292C30
        public void SetBuildVersion(){} // RVA: 0x7B1677CA0
        public void InitializeUserId(){} // RVA: 0x7B1677E00
        public void InitializeDeviceId(){} // RVA: 0x7B1677E70
        public void SetUserProperties(){} // RVA: 0x7B1677F60
        public void LogEvent(){} // RVA: 0x7B1678340
        public void LogEventInternal(){} // RVA: 0x7B1678540
        public void SaveSessionLastActiveTime(){} // RVA: 0x7B1679390
        public void GetSessionLastActiveTime(){} // RVA: 0x7B1679420
        public void ScheduleSaveEventCache(){} // RVA: 0x7B16794A0
        public void UpdateServer(){} // RVA: 0x7B1679530
        public void UpdateServerDelayed(){} // RVA: 0x7B16798B0
        public void PostEvents(){} // RVA: 0x7B1679AA0
        public void StartNewSession(){} // RVA: 0x7B167A130
        public void StartSession(){} // RVA: 0x7B167A3C0
        public void EndSession(){} // RVA: 0x7B167A830
        public void SaveAndUploadEvents(){} // RVA: 0x7B167AA40
        public void CurrentTimeMillis(){} // RVA: 0x7B167AAE0
        public void Hash(){} // RVA: 0x7A83BDC10
        public void Merge(){} // RVA: 0x7AA197310
        public void get_Experiments(){} // RVA: 0x7B167AB90
        public void set_Experiments(){} // RVA: 0x7B167ABF0
        public void IsInExperiment(){} // RVA: 0x7B167ACB0
        public void IsInExperimentSegment(){} // RVA: 0x7B167AD80
        public void GetExperimentPayloadValue(){} // RVA: 0x7A8051B10
        public void GetExperimentAssignedSegmentName(){} // RVA: 0x7B167B080
        public void GetExperimentPayload(){} // RVA: 0x7B167B160
        public void SetExperiments(){} // RVA: 0x7B167B820
        public void GetApiKey(){} // RVA: 0x7B167BBD0
        public void .cctor(){} // RVA: 0x7B167BC70
        public void <Init>b__68_0(){} // RVA: 0x7B167BF50
        public void <ClearCachedData>b__69_0(){} // RVA: 0x7B167BF60
        public void <ScheduleSaveEventCache>b__86_0(){} // RVA: 0x7B167BF70
        public void <ScheduleSaveEventCache>b__86_1(){} // RVA: 0x7B167C020
        public void <UpdateServerDelayed>b__88_0(){} // RVA: 0x7B167C040
        public void <SaveAndUploadEvents>b__93_0(){} // RVA: 0x7B167C480
    }

    public class DatabaseHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B167F560
        public void AddEvent(){} // RVA: 0x7B167F760
        public void GetEventCount(){} // RVA: 0x7B167F8F0
        public void GetEvents(){} // RVA: 0x7B167FA20
        public void RemoveEvents(){} // RVA: 0x7B167FC00
        public void RemoveEventsUpTo(){} // RVA: 0x7B167FE40
        public void SaveToCache(){} // RVA: 0x7B1680180
        public void LoadFromCache(){} // RVA: 0x7B1680470
        public void GetCacheFilePath(){} // RVA: 0x7B1680AB0
    }

    public class DeviceInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1680D60
        public void GetOsName(){} // RVA: 0x7A80F2570
        public void GetOsVersion(){} // RVA: 0x7B1680D70
        public void GetModel(){} // RVA: 0x7A80DA7B0
        public void GetDeviceName(){} // RVA: 0x7A81052C0
        public void GetLanguage(){} // RVA: 0x7A8105330
        public void GetPlatform(){} // RVA: 0x7A83F69F0
        public void CacheValues(){} // RVA: 0x7B1680DB0
    }

    public class LimitedConcurrencyLevelTaskScheduler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B1681160
        public void QueueTask(){} // RVA: 0x7B1681260
        public void NotifyThreadPoolOfPendingWork(){} // RVA: 0x7B1681420
        public void HasAnyPendingTasks(){} // RVA: 0x7B16814A0
        public void <NotifyThreadPoolOfPendingWork>b__5_0(){} // RVA: 0x7B16815E0
    }

}