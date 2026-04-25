// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.AmplitudeSDKWrapper
// Classes: 4
// Methods: 79

namespace ThirdParty.Other.AmplitudeSDKWrapper
{
    public class AmplitudeWrapper : Object
    {
        public string Logger;
        public int Instance;
        public int Experiments;
        public int EVENT_MAX_COUNT;
        public int EVENT_REMOVE_BATCH_SIZE;
        public int EVENT_UPLOAD_PERIOD_MILLISECONDS;
        public int EVENT_MIN_DELAY_BETWEEN_UPLOADS;
        public string EXPERIMENT_URL;
        public string EXPERIMENT_API_KEY;
        public string EXPERIMENT_API_DEV_KEY;
        public string EXPERIMENT_ERROR_MESSAGE;
        public long SESSION_TIMEOUT_MILLIS_PC;
        public long SESSION_TIMEOUT_MILLIS_MOBILE;
        public long MIN_TIME_BETWEEN_SESSIONS_MILLIS;
        public string SETTINGS_CONTAINER;
        public string SETTINGS_KEY_USER_ID;
        public string SETTINGS_SESSION_LAST_ACTIVE_TIME;
        public string SETTINGS_KEY_PREVIOUS_SESSION_ID;
        public int UPLOAD_RETRY_DELAY_MS;
        public int MAX_EVENTS_PER_SESSION;
        public string _apiKey; // 0x10
        public string _userId; // 0x18
        public string _deviceId; // 0x20
        public AmplitudeSDKWrapper.DeviceInfo _deviceInfo; // 0x28
        public string _buildVersionString; // 0x30
        public long _sessionId; // 0x38
        public System.Collections.Generic.Dictionary`2<string,object> _userProperties; // 0x40
        public object _paramLock; // 0x48
        public int _lastEventId; // 0x50
        public int _isUploading; // 0x54
        public int _isUpdateScheduled; // 0x58
        public AmplitudeSDKWrapper.DatabaseHelper _dbHelper; // 0x60
        public int _isCacheSaveScheduled; // 0x68
        public Settings _settings; // 0x70
        public bool _trackSession; // 0x78
        public bool _sessionOpen; // 0x79
        public AmplitudeSDKWrapper.LimitedConcurrencyLevelTaskScheduler _httpQueue; // 0x80
        public AmplitudeSDKWrapper.LimitedConcurrencyLevelTaskScheduler _logQueue; // 0x88
        public object _serverUpdateLock; // 0x90
        public int _serverUpdateScheduledTime; // 0x98
        public int _serverUpdateDelayMs; // 0x9C
        public int _serverUpdateBatchSize; // 0xA0
        public bool _isAppExiting; // 0xA4
        public long _sessionTimeoutMS; // 0xA8
        public bool _hasSentSuccessfullyAtLeastOnce; // 0xB0
        public bool _eventLimitPerSessionReached; // 0xB1
        public int _eventCountThisSession; // 0xB4
        public VRC.Core.IVRCLogger <Logger>k__BackingField;
        public System.Action OnExperimentsUpdated; // 0x8
        public AmplitudeSDKWrapper.AmplitudeWrapper <Instance>k__BackingField; // 0x10
        public System.Collections.Generic.Dictionary`2<string,ExperimentSegment> <Experiments>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7FFACBE44A80
        public void set_Logger(){} // RVA: 0x7FFACBE44AE0
        public void add_OnExperimentsUpdated(){} // RVA: 0x7FFACBE44B90
        public void remove_OnExperimentsUpdated(){} // RVA: 0x7FFACBE44CE0
        public void get_Instance(){} // RVA: 0x7FFACBE44E30
        public void set_Instance(){} // RVA: 0x7FFACBE44E90
        public void Initialize(){} // RVA: 0x7FFACBE44F50
        public void .ctor(){} // RVA: 0x7FFACBE45080
        public void Init(){} // RVA: 0x7FFACBE45300
        public void ClearCachedData(){} // RVA: 0x7FFACBE45910
        public void OnApplicationFocused(){} // RVA: 0x7FFAC2F21310
        public void OnApplicationPaused(){} // RVA: 0x7FFACBE459C0
        public void OnApplicationQuit(){} // RVA: 0x7FFACBE459E0
        public void HasPendingEvents(){} // RVA: 0x7FFACBE45A20
        public void SetUserId(){} // RVA: 0x7FFACBE45A60
        public void SetSessionId(){} // RVA: 0x7FFACBE45C90
        public void GetSessionId(){} // RVA: 0x7FFAC31D0140
        public void SetBuildVersion(){} // RVA: 0x7FFACBE45CA0
        public void InitializeUserId(){} // RVA: 0x7FFACBE45E30
        public void InitializeDeviceId(){} // RVA: 0x7FFAC8B17AB0
        public void SetUserProperties(){} // RVA: 0x7FFACBE45EA0
        public void LogEvent(){} // RVA: 0x7FFACBE46290 | overloaded x2
        public void CheckedLogEvent(){} // RVA: 0x7FFACBE46090
        public void SaveSessionLastActiveTime(){} // RVA: 0x7FFACBE471A0
        public void GetSessionLastActiveTime(){} // RVA: 0x7FFACBE47230
        public void ScheduleSaveEventCache(){} // RVA: 0x7FFACBE472B0
        public void UpdateServer(){} // RVA: 0x7FFACBE47340
        public void UpdateServerDelayed(){} // RVA: 0x7FFACBE476C0
        public void PostEvents(){} // RVA: 0x7FFACBE478F0
        public void StartNewSession(){} // RVA: 0x7FFACBE47F90
        public void StartSession(){} // RVA: 0x7FFACBE48240
        public void EndSession(){} // RVA: 0x7FFACBE486D0
        public void SaveAndUploadEvents(){} // RVA: 0x7FFACBE488E0
        public void CurrentTimeMillis(){} // RVA: 0x7FFACBE48980
        public void Hash(){} // RVA: 0x7FFAC31A13D0
        public void Merge(){} // RVA: 0x7FFAC2C79B30
        public void get_Experiments(){} // RVA: 0x7FFACBE48A90
        public void set_Experiments(){} // RVA: 0x7FFACBE48AF0
        public void IsInExperiment(){} // RVA: 0x7FFACBE48BB0
        public void IsInExperimentSegment(){} // RVA: 0x7FFACBE48C80
        public void GetExperimentPayloadValue(){} // RVA: 0x7FFAC2E8DC40 | overloaded x5
        public void GetExperimentAssignedSegmentName(){} // RVA: 0x7FFACBE48F80
        public void GetExperimentPayload(){} // RVA: 0x7FFACBE49060
        public void SetExperiments(){} // RVA: 0x7FFACBE49720
        public void GetApiKey(){} // RVA: 0x7FFACBE49AD0
        public void .cctor(){} // RVA: 0x7FFACBE49B70
        public void <Init>b__61_0(){} // RVA: 0x7FFACBE49D60
        public void <ClearCachedData>b__62_0(){} // RVA: 0x7FFACBE49D70
        public void <ScheduleSaveEventCache>b__79_0(){} // RVA: 0x7FFACBE49D80
        public void <ScheduleSaveEventCache>b__79_1(){} // RVA: 0x7FFACBE49E30
        public void <UpdateServerDelayed>b__81_0(){} // RVA: 0x7FFACBE49E50
        public void <SaveAndUploadEvents>b__86_0(){} // RVA: 0x7FFACBE4A2E0
    }

    public class DatabaseHelper : Object
    {
        public object objectLock; // 0x10
        public System.Collections.Generic.List`1<System.Collections.Generic.IReadOnlyDictionary`2<string,object>> RecordedEvents; // 0x18
        public string _cachePath; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE4D430
        public void AddEvent(){} // RVA: 0x7FFACBE4D630
        public void GetEventCount(){} // RVA: 0x7FFACBE4D7F0
        public void GetEvents(){} // RVA: 0x7FFACBE4D960
        public void RemoveEvents(){} // RVA: 0x7FFACBE4DB90
        public void RemoveEventsUpTo(){} // RVA: 0x7FFACBE4DE10
        public void SaveToCache(){} // RVA: 0x7FFACBE4E180
        public void LoadFromCache(){} // RVA: 0x7FFACBE4E4A0
        public void GetCacheFilePath(){} // RVA: 0x7FFACBE4EB00
    }

    public class DeviceInfo : Object
    {
        public string _osName; // 0x10
        public string _deviceModel; // 0x18
        public string _deviceName; // 0x20
        public string _systemLanguage; // 0x28
        public string _platform; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE4EB70
        public void GetOsName(){} // RVA: 0x7FFAC2F3C380
        public void GetOsVersion(){} // RVA: 0x7FFACBE4EB80
        public void GetModel(){} // RVA: 0x7FFAC2F247C0
        public void GetDeviceName(){} // RVA: 0x7FFAC2F4F0C0
        public void GetLanguage(){} // RVA: 0x7FFAC2F4F130
        public void GetPlatform(){} // RVA: 0x7FFAC31D95E0
        public void CacheValues(){} // RVA: 0x7FFACBE4EBC0
    }

    public class LimitedConcurrencyLevelTaskScheduler : Object
    {
        public System.Collections.Generic.LinkedList`1<System.Action> _tasks; // 0x10
        public int _maxDegreeOfParallelism; // 0x18
        public int _delegatesQueuedOrRunning; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBE4F150
        public void QueueTask(){} // RVA: 0x7FFACBE4F250
        public void NotifyThreadPoolOfPendingWork(){} // RVA: 0x7FFACBE4F440
        public void HasAnyPendingTasks(){} // RVA: 0x7FFACBE4F4C0
        public void <NotifyThreadPoolOfPendingWork>b__5_0(){} // RVA: 0x7FFACBE4F630
    }

}