// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.AmplitudeSDKWrapper
// Classes: 4
// Methods: 76

namespace ThirdParty.Other.AmplitudeSDKWrapper
{
    public class AmplitudeWrapper : Object
    {
        public object EVENT_LOG_URL;
        public object EVENT_UPLOAD_THRESHOLD;
        public object EVENT_UPLOAD_MAX_BATCH_SIZE;
        public object EVENT_MAX_COUNT;
        public object EVENT_REMOVE_BATCH_SIZE;
        public object EVENT_UPLOAD_PERIOD_MILLISECONDS;
        public object EVENT_MIN_DELAY_BETWEEN_UPLOADS;
        public object EXPERIMENT_URL;
        public object EXPERIMENT_API_KEY;
        public object EXPERIMENT_API_DEV_KEY;
        public object EXPERIMENT_ERROR_MESSAGE;
        public object SESSION_TIMEOUT_MILLIS_PC;
        public object SESSION_TIMEOUT_MILLIS_MOBILE;
        public object MIN_TIME_BETWEEN_SESSIONS_MILLIS;
        public object SETTINGS_CONTAINER;
        public object SETTINGS_KEY_USER_ID;
        public object SETTINGS_SESSION_LAST_ACTIVE_TIME;
        public object SETTINGS_KEY_PREVIOUS_SESSION_ID;
        public object UPLOAD_RETRY_DELAY_MS;
        public object MAX_EVENTS_PER_SESSION;
        public object _startupTimeTicks;
        public object _startupTimeUtcMs;
        public object _timeProvider;
        public object _apiKey;
        public object _userId;
        public object _deviceId;
        public object _deviceInfo;
        public object _buildVersionString;
        public object _sessionId;
        public object _userProperties;
        public object _paramLock;
        public object _lastEventId;
        public object _isUploading;
        public object _isUpdateScheduled;
        public object _dbHelper;
        public object _isCacheSaveScheduled;
        public object _settings;
        public object _trackSession;
        public object _sessionOpen;
        public object _httpQueue;
        public object _logQueue;
        public object _serverUpdateLock;
        public object _serverUpdateScheduledTime;
        public object _serverUpdateDelayMs;
        public object _serverUpdateBatchSize;
        public object _isAppExiting;
        public object _sessionTimeoutMS;
        public object _hasSentSuccessfullyAtLeastOnce;
        public object _eventLimitPerSessionReached;
        public object _eventCountThisSession;
        public object _logger;
        public object _deviceIdOverride;
        public object OnExperimentsUpdated;
        public object _instance;
        public object _experiments;

        // ── Methods ──
        public void get_Logger(){} // RVA: 0xA4E1AD0
        public void set_Logger(){} // RVA: 0xA4E1B30
        public void get_DeviceIdOverride(){} // RVA: 0xA4E1BF0
        public void set_DeviceIdOverride(){} // RVA: 0xA4E1C50
        public void add_OnExperimentsUpdated(){} // RVA: 0xA4E1D10
        public void remove_OnExperimentsUpdated(){} // RVA: 0xA4E1E60
        public void get_Instance(){} // RVA: 0xA4E1FB0
        public void set_Instance(){} // RVA: 0xA4E2010
        public void Initialize(){} // RVA: 0xA4E20D0
        public void .ctor(){} // RVA: 0xA4E2200
        public void Init(){} // RVA: 0xA4E2500
        public void ClearCachedData(){} // RVA: 0xA4E2D10
        public void OnApplicationFocused(){} // RVA: 0xB43310
        public void OnApplicationPaused(){} // RVA: 0xA4E2DC0
        public void OnApplicationQuit(){} // RVA: 0xA4E2DE0
        public void HasPendingEvents(){} // RVA: 0xA4E2E20
        public void SetUserId(){} // RVA: 0xA4E2E60
        public void SetSessionId(){} // RVA: 0xA4E3040
        public void GetSessionId(){} // RVA: 0xD05CA0
        public void SetBuildVersion(){} // RVA: 0xA4E3050
        public void InitializeUserId(){} // RVA: 0xA4E31B0
        public void InitializeDeviceId(){} // RVA: 0xA4E3220
        public void SetUserProperties(){} // RVA: 0xA4E32E0
        public void LogEvent(){} // RVA: 0xA4E36C0
        public void LogEventInternal(){} // RVA: 0xA4E38C0
        public void SaveSessionLastActiveTime(){} // RVA: 0xA4E46E0
        public void GetSessionLastActiveTime(){} // RVA: 0xA4E4770
        public void ScheduleSaveEventCache(){} // RVA: 0xA4E47F0
        public void UpdateServer(){} // RVA: 0xA4E4880
        public void UpdateServerDelayed(){} // RVA: 0xA4E4C00
        public void PostEvents(){} // RVA: 0xA4E4DF0
        public void StartNewSession(){} // RVA: 0xA4E5470
        public void StartSession(){} // RVA: 0xA4E5700
        public void EndSession(){} // RVA: 0xA4E5B70
        public void SaveAndUploadEvents(){} // RVA: 0xA4E5D80
        public void CurrentTimeMillis(){} // RVA: 0xA4E5E20
        public void Hash(){} // RVA: 0xE8FE30
        public void Merge(){} // RVA: 0x2D5A140
        public void get_Experiments(){} // RVA: 0xA4E5ED0
        public void set_Experiments(){} // RVA: 0xA4E5F30
        public void IsInExperiment(){} // RVA: 0xA4E5FF0
        public void IsInExperimentSegment(){} // RVA: 0xA4E60C0
        public void GetExperimentPayloadValue(){} // RVA: 0xA94080
        public void GetExperimentAssignedSegmentName(){} // RVA: 0xA4E63C0
        public void GetExperimentPayload(){} // RVA: 0xA4E64A0
        public void SetExperiments(){} // RVA: 0xA4E6B30
        public void GetApiKey(){} // RVA: 0xA4E6EE0
        public void .cctor(){} // RVA: 0xA4E6F80
        public void <Init>b__68_0(){} // RVA: 0xA4E7260
        public void <ClearCachedData>b__69_0(){} // RVA: 0xA4E7270
        public void <ScheduleSaveEventCache>b__86_0(){} // RVA: 0xA4E7280
        public void <ScheduleSaveEventCache>b__86_1(){} // RVA: 0xA4E7330
        public void <UpdateServerDelayed>b__88_0(){} // RVA: 0xA4E7350
        public void <SaveAndUploadEvents>b__93_0(){} // RVA: 0xA4E7790
    }

    public class DatabaseHelper : Object
    {
        public object objectLock;
        public object RecordedEvents;
        public object _cachePath;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4EA7B0
        public void AddEvent(){} // RVA: 0xA4EA980
        public void GetEventCount(){} // RVA: 0xA4EAB10
        public void GetEvents(){} // RVA: 0xA4EAC40
        public void RemoveEvents(){} // RVA: 0xA4EAE20
        public void RemoveEventsUpTo(){} // RVA: 0xA4EB060
        public void SaveToCache(){} // RVA: 0xA4EB3A0
        public void LoadFromCache(){} // RVA: 0xA4EB690
        public void GetCacheFilePath(){} // RVA: 0xA4EBCC0
    }

    public class DeviceInfo : Object
    {
        public object _osName;
        public object _deviceModel;
        public object _deviceName;
        public object _systemLanguage;
        public object _platform;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4EBF70
        public void GetOsName(){} // RVA: 0xB5DBF0
        public void GetOsVersion(){} // RVA: 0xA4EBF80
        public void GetModel(){} // RVA: 0xB465B0
        public void GetDeviceName(){} // RVA: 0xB700F0
        public void GetLanguage(){} // RVA: 0xB70160
        public void GetPlatform(){} // RVA: 0xD33E60
        public void CacheValues(){} // RVA: 0xA4EBFC0
    }

    public class LimitedConcurrencyLevelTaskScheduler : Object
    {
        public object _tasks;
        public object _maxDegreeOfParallelism;
        public object _delegatesQueuedOrRunning;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA4EC2B0
        public void QueueTask(){} // RVA: 0xA4EC3B0
        public void NotifyThreadPoolOfPendingWork(){} // RVA: 0xA4EC570
        public void HasAnyPendingTasks(){} // RVA: 0xA4EC5F0
        public void <NotifyThreadPoolOfPendingWork>b__5_0(){} // RVA: 0xA4EC730
    }

}