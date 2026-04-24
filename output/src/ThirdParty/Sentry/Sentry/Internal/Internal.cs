// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal
// Classes: 20
// Methods: 191

namespace ThirdParty.Sentry.Sentry.Internal
{
    public class AutoClearingList`1 : Object
    {
        public URA.?<RGBA_ETC2_SRGB.ts> Count; // 0x10
        public bool IsReadOnly; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E096500
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
    }

    public class ConcurrentQueueLite`1 : Object
    {
        public URA.woDigitYearMax<T1717641808> Count;

        // ── Methods ──
        public void Enqueue(){} // RVA: 0x7FFD4E2ADC40
        public void TryDequeue(){} // RVA: 0x7FFD4E079F60
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void TryPeek(){} // RVA: 0x7FFD4E079F60
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class DuplicateEventDetectionEventProcessor : Object
    {
        public RGBA_ETC2_SRGB.ionAsync>d__5`3 _options; // 0x10
        public ArgCount.ent<object,object> _capturedObjects; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53FBEC00
        public void Process(){} // RVA: 0x7FFD53FBED20
        public void IsDuplicate(){} // RVA: 0x7FFD53FBEED0
    }

    public class ExceptionTypeFilter`1 : Object
    {
        public object _filteredType;

        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFD4E079F60
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class GrowableArray`1 : ValueType
    {
        public T1717641904[] Item;
        public int Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void Reserve(){} // RVA: 0x7FFD4E090ED0
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void AddRange(){} // RVA: 0x7FFD4E090A40
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void RemoveRange(){} // RVA: 0x7FFD4E092E60
        public void get_Empty(){} // RVA: 0x7FFD4E079D00
        public void Trim(){} // RVA: 0x7FFD4E090ED0
        public void get_EmptyCapacity(){} // RVA: 0x7FFD4E079D00
        public void ToString(){} // RVA: 0x7FFD4E078E90
        public void Foreach(){} // RVA: 0x7FFD4E2ADC40
        public void Search(){} // RVA: 0x7FFD4E2ADC40
        public void get_UnderlyingArray(){} // RVA: 0x7FFD4E078E90
        public void Realloc(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class HashableGrowableArray`1 : ValueType
    {
        public IsPerformanceMonitoringEnabled.cesSampler<T1717641840> Item;
        public int Count;
        public bool _sealed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void Seal(){} // RVA: 0x7FFD4E090980
        public void Trim(){} // RVA: 0x7FFD4E090ED0
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E079960
        public void Equals(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class Hub : Object
    {
        public object ExceptionToSpanMap; // 0x10
        public tingSystem>.UpdateFrom.gMeta ScopeManager; // 0x18
        public RGBA_ETC2_SRGB.d__3`1 Metrics; // 0x20
        public RGBA_ETC2_SRGB.ionAsync>d__5`3 IsEnabled; // 0x28
        public IsPerformanceMonitoringEnabled.d Options; // 0x30
        public int CurrentScope; // 0x38
        public ArgCount.ent<ÏÏÍÍÎÎ,RGBA_ETC2_SRGB.waitWithCancellationAsync>d__4`1> CurrentClient; // 0x40
        public IsPerformanceMonitoringEnabled.er>b__0 LastEventId; // 0x48
        public RGBA_ETC2_SRGB.Action <Metrics>k__BackingField; // 0x50
        public int _isEnabled; // 0x58

        // ── Methods ──
        public void get_ExceptionToSpanMap(){} // RVA: 0x7FFD4E3BE740
        public void get_ScopeManager(){} // RVA: 0x7FFD4E3BC730
        public void get_Metrics(){} // RVA: 0x7FFD4E3E20E0
        public void get_IsEnabled(){} // RVA: 0x7FFD53FC0820
        public void get_Options(){} // RVA: 0x7FFD4E36F130
        public void get_CurrentScope(){} // RVA: 0x7FFD53FC0830
        public void get_CurrentClient(){} // RVA: 0x7FFD53FC0900
        public void .ctor(){} // RVA: 0x7FFD53FC09D0
        public void ConfigureScope(){} // RVA: 0x7FFD53FC13D0
        public void ConfigureScopeAsync(){} // RVA: 0x7FFD53FC1490
        public void PushScope(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void RestoreScope(){} // RVA: 0x7FFD53FC16F0
        public void BindClient(){} // RVA: 0x7FFD53FC17C0
        public void StartTransaction(){} // RVA: 0x7FFD53FC1840 | overloaded x2
        public void BindException(){} // RVA: 0x7FFD53FC1E30
        public void GetSpan(){} // RVA: 0x7FFD53FC1FC0
        public void GetTraceHeader(){} // RVA: 0x7FFD53FC1FF0
        public void GetBaggage(){} // RVA: 0x7FFD53FC20C0
        public void ContinueTrace(){} // RVA: 0x7FFD53FC2330 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFD53FC26C0
        public void PauseSession(){} // RVA: 0x7FFD53FC2840
        public void ResumeSession(){} // RVA: 0x7FFD53FC2A50
        public void EndSession(){} // RVA: 0x7FFD53FC2F90 | overloaded x2
        public void GetLinkedSpan(){} // RVA: 0x7FFD53FC3010
        public void ApplyTraceContextToEvent(){} // RVA: 0x7FFD53FC33A0 | overloaded x2
        public void CaptureEnvelope(){} // RVA: 0x7FFD53FC3590
        public void AddBreadcrumbForException(){} // RVA: 0x7FFD53FC3600
        public void CaptureEvent(){} // RVA: 0x7FFD53FC3B50 | overloaded x4
        public void CaptureUserFeedback(){} // RVA: 0x7FFD53FC3F90
        public void CaptureTransaction(){} // RVA: 0x7FFD53FC40E0 | overloaded x2
        public void CaptureMetrics(){} // RVA: 0x7FFD53FC41E0
        public void CaptureCodeLocations(){} // RVA: 0x7FFD53FC4570
        public void StartSpan(){} // RVA: 0x7FFD53FC4820
        public void CaptureSession(){} // RVA: 0x7FFD53FC49D0
        public void CaptureCheckIn(){} // RVA: 0x7FFD53FC4B00
        public void FlushAsync(){} // RVA: 0x7FFD53FC4D90
        public void Dispose(){} // RVA: 0x7FFD53FC4F60
        public void get_LastEventId(){} // RVA: 0x7FFD53FC5110
    }

    public class IClientReportRecorder
    {
        // ── Methods ──
        public void RecordDiscardedEvent(){}
        public void GenerateClientReport(){} // RVA: 0x7FFD4E078E90
        public void Load(){} // RVA: 0x7FFD4E090A40
    }

    public class ICloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFD4E2ADC40
    }

    public class IUpdatable`1
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x7FFD4E2ADC40
    }

    public class Json : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void Load(){} // RVA: 0x7FFD4E2ADC40
    }

    public class MainExceptionProcessor : Object
    {
        public string SentryStackTraceFactoryAccessor;
        public string ExceptionDataTagKey;
        public string ExceptionDataContextKey;
        public RGBA_ETC2_SRGB.ionAsync>d__5`3 _options; // 0x10
        public ormation<?> <SentryStackTraceFactoryAccessor>k__BackingField; // 0x18

        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x7FFD4E3447C0
        public void .ctor(){} // RVA: 0x7FFD4E90C240
        public void Process(){} // RVA: 0x7FFD53FC70B0
        public void CreateSentryExceptions(){} // RVA: 0x7FFD53FC71D0
        public void WalkExceptions(){} // RVA: 0x7FFD53FC7420 | overloaded x2
        public void MoveExceptionDataToEvent(){} // RVA: 0x7FFD53FC7600
        public void BuildSentryException(){} // RVA: 0x7FFD53FC80F0
        public void GetMechanism(){} // RVA: 0x7FFD53FC8490
    }

    public class MainSentryEventProcessor : Object
    {
        public string SentryStackTraceFactoryAccessor;
        public string Release;
        public string Distribution;
        public string ThreadPoolInfoKey;
        public string IsDynamicCodeKey;
        public string IsDynamicCodeCompiledKey;
        public string IsDynamicCodeSupportedKey;
        public IsPerformanceMonitoringEnabled.AppInclude _enricher; // 0x10
        public RGBA_ETC2_SRGB.ionAsync>d__5`3 _options; // 0x18
        public ormation<?> <SentryStackTraceFactoryAccessor>k__BackingField; // 0x20

        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x7FFD4E36F0C0
        public void get_Release(){} // RVA: 0x7FFD53FC9BC0
        public void get_Distribution(){} // RVA: 0x7FFD53FC9BF0
        public void .ctor(){} // RVA: 0x7FFD53FC9C10
        public void Process(){} // RVA: 0x7FFD53FC9D90
        public void AddMemoryInfo(){} // RVA: 0x7FFD4E341310
        public void AddThreadPoolInfo(){} // RVA: 0x7FFD53FCAE20
        public void CultureInfoToDictionary(){} // RVA: 0x7FFD53FCAF70
    }

    public class ObjectExtensions : Object
    {
        public ArgCount.ent<object,URA.DateTime<string,object>> Map;

        // ── Methods ──
        public void get_Map(){} // RVA: 0x7FFD53FCBBE0
        public void AssociatedProperties(){} // RVA: 0x7FFD53FCBC40
        public void SetFused(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetFused(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD53FCBEE0
    }

    public class PollingNetworkStatusListener : Object
    {
        public RGBA_ETC2_SRGB.ionAsync>d__5`3 LazyPing; // 0x10
        public IsPerformanceMonitoringEnabled.Crashed>k__BackingField Ping; // 0x18
        public int Online; // 0x20
        public int _maxDelayInMilliseconds; // 0x24
        public n<int,int> _backoffFunction; // 0x28
        public bool _online; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53FCDC30 | overloaded x2
        public void get_LazyPing(){} // RVA: 0x7FFD53FCDE50
        public void get_Ping(){} // RVA: 0x7FFD53FCDF30
        public void get_Online(){} // RVA: 0x7FFD53FCE040
        public void set_Online(){} // RVA: 0x7FFD53FCE050
        public void WaitForNetworkOnlineAsync(){} // RVA: 0x7FFD53FCE060
        public void <get_LazyPing>b__8_0(){} // RVA: 0x7FFD53FCE270
    }

    public class PooledBuffer`1 : ValueType
    {
        public T1717642064[] Array;

        // ── Methods ──
        public void get_Array(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class SentryScopeManager : Object
    {
        public ield.ssionDenied ScopeStackContainer; // 0x10
        public RGBA_ETC2_SRGB.ionAsync>d__5`3 ScopeAndClientStack; // 0x18
        public ormation<URA.mes<RGBA_ETC2_SRGB.ult,RGBA_ETC2_SRGB.ation`2>[]> NewStack; // 0x20

        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7FFD4E35C380
        public void get_ScopeAndClientStack(){} // RVA: 0x7FFD53FD1C10
        public void set_ScopeAndClientStack(){} // RVA: 0x7FFD53FD1D00
        public void get_NewStack(){} // RVA: 0x7FFD4E36F0C0
        public void get_IsGlobalMode(){} // RVA: 0x7FFD53FD1D60
        public void .ctor(){} // RVA: 0x7FFD53FD1DF0
        public void GetCurrent(){} // RVA: 0x7FFD53FD2150
        public void ConfigureScope(){} // RVA: 0x7FFD53FD21A0
        public void ConfigureScopeAsync(){} // RVA: 0x7FFD53FD2330
        public void PushScope(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void RestoreScope(){} // RVA: 0x7FFD53FD2530
        public void BindClient(){} // RVA: 0x7FFD53FD2990
        public void Dispose(){} // RVA: 0x7FFD53FD2CA0
    }

    public class SettingLocator : Object
    {
        public RGBA_ETC2_SRGB.ionAsync>d__5`3 AssemblyForAttributes; // 0x10
        public m.ormation <AssemblyForAttributes>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53FD4570
        public void get_AssemblyForAttributes(){} // RVA: 0x7FFD4E3447C0
        public void set_AssemblyForAttributes(){} // RVA: 0x7FFD4E3A7E80
        public void GetEnvironmentVariable(){} // RVA: 0x7FFD53FD4630
        public void GetDsn(){} // RVA: 0x7FFD53FD4640
        public void GetEnvironment(){} // RVA: 0x7FFD53FD4790 | overloaded x2
        public void GetRelease(){} // RVA: 0x7FFD53FD48C0
    }

    public class StringOrRegex : Object
    {
        public tor.neStore _regex; // 0x10
        public string _prefix; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD53FD4E90 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD53FD4F20
        public void Equals(){} // RVA: 0x7FFD53FD4F90
        public void GetHashCode(){} // RVA: 0x7FFD4FDFB960
    }

    public class ThreadsafeCounterDictionary`1 : Object
    {
        public JapaneseLangName.erns<T1717642128,dStatus<T1717642128>> Count;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Increment(){} // RVA: 0x7FFD4E2ADC40
        public void ReadAndReset(){} // RVA: 0x7FFD4E2ADC40
        public void ReadAllAndReset(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void ContainsKey(){} // RVA: 0x7FFD4E2ADC40
        public void TryGetValue(){} // RVA: 0x7FFD4E2ADC40
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void get_Keys(){} // RVA: 0x7FFD4E078E90
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

}