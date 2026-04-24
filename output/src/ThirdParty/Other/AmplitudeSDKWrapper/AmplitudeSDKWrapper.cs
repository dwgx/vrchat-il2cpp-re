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
        public matWarn>k__BackingField _deviceInfo; // 0x28
        public string _buildVersionString; // 0x30
        public long _sessionId; // 0x38
        public URA.DateTime<string,object> _userProperties; // 0x40
        public object _paramLock; // 0x48
        public int _lastEventId; // 0x50
        public int _isUploading; // 0x54
        public int _isUpdateScheduled; // 0x58
        public get_FormatEx _dbHelper; // 0x60
        public int _isCacheSaveScheduled; // 0x68
        public Ì _settings; // 0x70
        public bool _trackSession; // 0x78
        public bool _sessionOpen; // 0x79
        public ILogger _httpQueue; // 0x80
        public ILogger _logQueue; // 0x88
        public object _serverUpdateLock; // 0x90
        public int _serverUpdateScheduledTime; // 0x98
        public int _serverUpdateDelayMs; // 0x9C
        public int _serverUpdateBatchSize; // 0xA0
        public bool _isAppExiting; // 0xA4
        public long _sessionTimeoutMS; // 0xA8
        public bool _hasSentSuccessfullyAtLeastOnce; // 0xB0
        public bool _eventLimitPerSessionReached; // 0xB1
        public int _eventCountThisSession; // 0xB4
        public ÌÌÌÍÍÎÍÌÏÌÏÌÍÍÏ.t_clientVersion <Logger>k__BackingField;
        public ÎÌÍÏÏÌÍÏ OnExperimentsUpdated; // 0x8
        public t_CrlEntryDetails <Instance>k__BackingField; // 0x10
        public URA.DateTime<string,ult> <Experiments>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7FFD57264A80
        public void set_Logger(){} // RVA: 0x7FFD57264AE0
        public void add_OnExperimentsUpdated(){} // RVA: 0x7FFD57264B90
        public void remove_OnExperimentsUpdated(){} // RVA: 0x7FFD57264CE0
        public void get_Instance(){} // RVA: 0x7FFD57264E30
        public void set_Instance(){} // RVA: 0x7FFD57264E90
        public void Initialize(){} // RVA: 0x7FFD57264F50
        public void .ctor(){} // RVA: 0x7FFD57265080
        public void Init(){} // RVA: 0x7FFD57265300
        public void ClearCachedData(){} // RVA: 0x7FFD57265910
        public void OnApplicationFocused(){} // RVA: 0x7FFD4E341310
        public void OnApplicationPaused(){} // RVA: 0x7FFD572659C0
        public void OnApplicationQuit(){} // RVA: 0x7FFD572659E0
        public void HasPendingEvents(){} // RVA: 0x7FFD57265A20
        public void SetUserId(){} // RVA: 0x7FFD57265A60
        public void SetSessionId(){} // RVA: 0x7FFD57265C90
        public void GetSessionId(){} // RVA: 0x7FFD4E5F0140
        public void SetBuildVersion(){} // RVA: 0x7FFD57265CA0
        public void InitializeUserId(){} // RVA: 0x7FFD57265E30
        public void InitializeDeviceId(){} // RVA: 0x7FFD53F37AB0
        public void SetUserProperties(){} // RVA: 0x7FFD57265EA0
        public void LogEvent(){} // RVA: 0x7FFD57266290 | overloaded x2
        public void CheckedLogEvent(){} // RVA: 0x7FFD57266090
        public void SaveSessionLastActiveTime(){} // RVA: 0x7FFD572671A0
        public void GetSessionLastActiveTime(){} // RVA: 0x7FFD57267230
        public void ScheduleSaveEventCache(){} // RVA: 0x7FFD572672B0
        public void UpdateServer(){} // RVA: 0x7FFD57267340
        public void UpdateServerDelayed(){} // RVA: 0x7FFD572676C0
        public void PostEvents(){} // RVA: 0x7FFD572678F0
        public void StartNewSession(){} // RVA: 0x7FFD57267F90
        public void StartSession(){} // RVA: 0x7FFD57268240
        public void EndSession(){} // RVA: 0x7FFD572686D0
        public void SaveAndUploadEvents(){} // RVA: 0x7FFD572688E0
        public void CurrentTimeMillis(){} // RVA: 0x7FFD57268980
        public void Hash(){} // RVA: 0x7FFD4E5C13D0
        public void Merge(){} // RVA: 0x7FFD4E099B30
        public void get_Experiments(){} // RVA: 0x7FFD57268A90
        public void set_Experiments(){} // RVA: 0x7FFD57268AF0
        public void IsInExperiment(){} // RVA: 0x7FFD57268BB0
        public void IsInExperimentSegment(){} // RVA: 0x7FFD57268C80
        public void GetExperimentPayloadValue(){} // RVA: 0x7FFD4E2ADC40 | overloaded x5
        public void GetExperimentAssignedSegmentName(){} // RVA: 0x7FFD57268F80
        public void GetExperimentPayload(){} // RVA: 0x7FFD57269060
        public void SetExperiments(){} // RVA: 0x7FFD57269720
        public void GetApiKey(){} // RVA: 0x7FFD57269AD0
        public void .cctor(){} // RVA: 0x7FFD57269B70
        public void <Init>b__61_0(){} // RVA: 0x7FFD57269D60
        public void <ClearCachedData>b__62_0(){} // RVA: 0x7FFD57269D70
        public void <ScheduleSaveEventCache>b__79_0(){} // RVA: 0x7FFD57269D80
        public void <ScheduleSaveEventCache>b__79_1(){} // RVA: 0x7FFD57269E30
        public void <UpdateServerDelayed>b__81_0(){} // RVA: 0x7FFD57269E50
        public void <SaveAndUploadEvents>b__86_0(){} // RVA: 0x7FFD5726A2E0
    }

    public class DatabaseHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5726D430
        public void AddEvent(){} // RVA: 0x7FFD5726D630
        public void GetEventCount(){} // RVA: 0x7FFD5726D7F0
        public void GetEvents(){} // RVA: 0x7FFD5726D960
        public void RemoveEvents(){} // RVA: 0x7FFD5726DB90
        public void RemoveEventsUpTo(){} // RVA: 0x7FFD5726DE10
        public void SaveToCache(){} // RVA: 0x7FFD5726E180
        public void LoadFromCache(){} // RVA: 0x7FFD5726E4A0
        public void GetCacheFilePath(){} // RVA: 0x7FFD5726EB00
    }

    public class DeviceInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5726EB70
        public void GetOsName(){} // RVA: 0x7FFD4E35C380
        public void GetOsVersion(){} // RVA: 0x7FFD5726EB80
        public void GetModel(){} // RVA: 0x7FFD4E3447C0
        public void GetDeviceName(){} // RVA: 0x7FFD4E36F0C0
        public void GetLanguage(){} // RVA: 0x7FFD4E36F130
        public void GetPlatform(){} // RVA: 0x7FFD4E5F95E0
        public void CacheValues(){} // RVA: 0x7FFD5726EBC0
    }

    public class LimitedConcurrencyLevelTaskScheduler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5726F150
        public void QueueTask(){} // RVA: 0x7FFD5726F250
        public void NotifyThreadPoolOfPendingWork(){} // RVA: 0x7FFD5726F440
        public void HasAnyPendingTasks(){} // RVA: 0x7FFD5726F4C0
        public void <NotifyThreadPoolOfPendingWork>b__5_0(){} // RVA: 0x7FFD5726F630
    }

}