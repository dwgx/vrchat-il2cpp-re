// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.AmplitudeSDKWrapper
// Classes: 4
// Methods: 79

namespace ThirdParty.Other.AmplitudeSDKWrapper
{
    public class AmplitudeWrapper : Object
    {
        public object EVENT_UPLOAD_MAX_BATCH_SIZE; // 0x31669F30
        public object EVENT_UPLOAD_PERIOD_MILLISECONDS; // 0x31669F30
        public object EXPERIMENT_API_KEY; // 0x31669F30
        public object SESSION_TIMEOUT_MILLIS_PC; // 0x31669F30
        public object SETTINGS_CONTAINER; // 0x31669F30
        public object SETTINGS_KEY_PREVIOUS_SESSION_ID; // 0x31669F30
        public object _apiKey; // 0x31669F30
        public object _deviceInfo; // 0x31669F30
        public object _userProperties; // 0x31669F30
        public object _isUploading; // 0x31669F30
        public object _isCacheSaveScheduled; // 0x31669F30
        public object _sessionOpen; // 0x31669F30
        public object _serverUpdateLock; // 0x31669F30
        public object _serverUpdateBatchSize; // 0x31669F30
        public object _hasSentSuccessfullyAtLeastOnce; // 0x31669F30
        public object _logger; // 0x31669F30, was: <Logger>k__BackingField
        public object _experiments; // 0x31669F30, was: <Experiments>k__BackingField
        public object Dictionary`2; // 0xB412BC00

        // ── Original Methods ──
        public void get_Logger(){} // RVA: 0x7ffab1860760
        public void set_Logger(){} // RVA: 0x7ffab18607c0
        public void add_OnExperimentsUpdated(){} // RVA: 0x7ffab1860870
        public void remove_OnExperimentsUpdated(){} // RVA: 0x7ffab18609c0
        public void get_Instance(){} // RVA: 0x7ffab1860b10
        public void set_Instance(){} // RVA: 0x7ffab1860b70
        public void Initialize(){} // RVA: 0x7ffab1860c30
        public void .ctor(){} // RVA: 0x7ffab1860d60
        public void Init(){} // RVA: 0x7ffab1860fe0
        public void ClearCachedData(){} // RVA: 0x7ffab18615f0
        public void OnApplicationFocused(){} // RVA: 0x7ffaa8932310
        public void OnApplicationPaused(){} // RVA: 0x7ffab18616a0
        public void OnApplicationQuit(){} // RVA: 0x7ffab18616c0
        public void HasPendingEvents(){} // RVA: 0x7ffab1861700
        public void InitializeUserId(){} // RVA: 0x7ffab1861b10
        public void InitializeDeviceId(){} // RVA: 0x7ffaae538cb0
        public void LogEvent(){} // RVA: 0x7ffab1861f70
        public void LogEvent(){} // RVA: 0x7ffab1861f70
        public void SaveSessionLastActiveTime(){} // RVA: 0x7ffab1862e80
        public void ScheduleSaveEventCache(){} // RVA: 0x7ffab1862f90
        public void UpdateServer(){} // RVA: 0x7ffab1863020
        public void UpdateServerDelayed(){} // RVA: 0x7ffab18633a0
        public void PostEvents(){} // RVA: 0x7ffab18635d0
        public void StartNewSession(){} // RVA: 0x7ffab1863c70
        public void StartSession(){} // RVA: 0x7ffab1863f20
        public void EndSession(){} // RVA: 0x7ffab18643b0
        public void SaveAndUploadEvents(){} // RVA: 0x7ffab18645c0
        public void CurrentTimeMillis(){} // RVA: 0x7ffab1864660
        public void Hash(){} // RVA: 0x7ffaa8bc5cb0
        public void Merge(){} // RVA: 0x7ffaa8669e70
        public void get_Experiments(){} // RVA: 0x7ffab1864770
        public void set_Experiments(){} // RVA: 0x7ffab18647d0
        public void IsInExperiment(){} // RVA: 0x7ffab1864890
        public void IsInExperimentSegment(){} // RVA: 0x7ffab1864960
        public void .cctor(){} // RVA: 0x7ffab1865850
        public void <Init>b__61_0(){} // RVA: 0x7ffab1865a40
        public void <ClearCachedData>b__62_0(){} // RVA: 0x7ffab1865a50
        public void <ScheduleSaveEventCache>b__79_0(){} // RVA: 0x7ffab1865a60
        public void <ScheduleSaveEventCache>b__79_1(){} // RVA: 0x7ffab1865b10
        public void <UpdateServerDelayed>b__81_0(){} // RVA: 0x7ffab1865b30
        public void <SaveAndUploadEvents>b__86_0(){} // RVA: 0x7ffab1865fc0
        // ── Binary Analysis Named ──
        public void SetUserId(){} // RVA: 0x7ffab1861740
        public void SetSessionId(){} // RVA: 0x7ffab1861970
        public void GetSessionId(){} // RVA: 0x7ffaa8bf45b0
        public void SetBuildVersion(){} // RVA: 0x7ffab1861980
        public void SetUserProperties(){} // RVA: 0x7ffab1861b80
        public void CheckedLogEvent(){} // RVA: 0x7ffab1861d70
        public void GetSessionLastActiveTime(){} // RVA: 0x7ffab1862f10
        public void GetExperimentPayloadValue(){} // RVA: 0x7ffaa887e5c0
        public void GetExperimentAssignedSegmentName(){} // RVA: 0x7ffab1864c60
        public void GetExperimentPayload(){} // RVA: 0x7ffab1864d40
        public void GetExperimentPayloadValue(){} // RVA: 0x7ffaa887e5c0
        public void GetExperimentPayloadValue(){} // RVA: 0x7ffaa887e5c0
        public void GetExperimentPayloadValue(){} // RVA: 0x7ffaa887e5c0
        public void GetExperimentPayloadValue(){} // RVA: 0x7ffaa887e5c0
        public void SetExperiments(){} // RVA: 0x7ffab1865400
        public void GetApiKey(){} // RVA: 0x7ffab18657b0
    }

    public class DatabaseHelper : Object
    {
        public object _cachePath; // 0x36845DA0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab1869110
        public void AddEvent(){} // RVA: 0x7ffab1869310
        public void RemoveEvents(){} // RVA: 0x7ffab1869870
        public void RemoveEventsUpTo(){} // RVA: 0x7ffab1869af0
        public void SaveToCache(){} // RVA: 0x7ffab1869e60
        public void LoadFromCache(){} // RVA: 0x7ffab186a180
        // ── Binary Analysis Named ──
        public void GetEventCount(){} // RVA: 0x7ffab18694d0
        public void GetEvents(){} // RVA: 0x7ffab1869640
        public void GetCacheFilePath(){} // RVA: 0x7ffab186a7e0
    }

    public class DeviceInfo : Object
    {
        public object _deviceName; // 0x368460A0
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab186a850
        public void CacheValues(){} // RVA: 0x7ffab186a8a0
        // ── Binary Analysis Named ──
        public void GetOsName(){} // RVA: 0x7ffaa894d380
        public void GetOsVersion(){} // RVA: 0x7ffab186a860
        public void GetModel(){} // RVA: 0x7ffaa89357c0
        public void GetDeviceName(){} // RVA: 0x7ffaa89600c0
        public void GetLanguage(){} // RVA: 0x7ffaa8960130
        public void GetPlatform(){} // RVA: 0x7ffaa8bfcc80
    }

    public class LimitedConcurrencyLevelTaskScheduler : Object
    {
        public object _delegatesQueuedOrRunning; // 0x36846220
        public object _containerName; // 0x31A2BAC0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffab186ae30
        public void QueueTask(){} // RVA: 0x7ffab186af30
        public void NotifyThreadPoolOfPendingWork(){} // RVA: 0x7ffab186b120
        public void HasAnyPendingTasks(){} // RVA: 0x7ffab186b1a0
        public void <NotifyThreadPoolOfPendingWork>b__5_0(){} // RVA: 0x7ffab186b310
    }

}