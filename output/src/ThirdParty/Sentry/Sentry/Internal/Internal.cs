// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal
// Classes: 73
// Methods: 531

namespace ThirdParty.Sentry.Sentry.Internal
{
    public class AotHelper : Object
    {
        public string IsTrimmed;
        public bool <IsTrimmed>k__BackingField;
        public bool IsNativeAot;

        // ── Methods ──
        public void get_IsTrimmed(){} // RVA: 0x7FFAC8B8F950
        public void .cctor(){} // RVA: 0x7FFAC8B8F9B0
    }

    public class AppDomainAdapter : Object
    {
        public Sentry.Internal.AppDomainAdapter Instance;
        public System.UnhandledExceptionEventHandler UnhandledException; // 0x10
        public System.EventHandler ProcessExit; // 0x18
        public System.EventHandler`1<System.Threading.Tasks.UnobservedTaskExceptionEventArgs> UnobservedTaskException; // 0x20

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8B8FA60
        public void .ctor(){} // RVA: 0x7FFAC8B8FAC0
        public void add_UnhandledException(){} // RVA: 0x7FFAC8B8FCC0
        public void remove_UnhandledException(){} // RVA: 0x7FFAC8B8FDB0
        public void add_ProcessExit(){} // RVA: 0x7FFAC8B8FEA0
        public void remove_ProcessExit(){} // RVA: 0x7FFAC8B8FF90
        public void add_UnobservedTaskException(){} // RVA: 0x7FFAC8B90080
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFAC8B90180
        public void OnProcessExit(){} // RVA: 0x7FFAC7797E30
        public void OnUnhandledException(){} // RVA: 0x7FFAC8B90280
        public void OnUnobservedTaskException(){} // RVA: 0x7FFAC8B902A0
        public void .cctor(){} // RVA: 0x7FFAC8B902C0
    }

    public class ApplicationVersionLocator : Object
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7FFAC8B90370
    }

    public class AutoClearingList`1 : Object
    {
        public System.Collections.Generic.IList`1<T> Count;
        public bool IsReadOnly;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C76500
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
    }

    public class BackgroundWorker : Object
    {
        public Sentry.Extensibility.ITransport WorkerTask; // 0x10
        public Sentry.SentryOptions QueuedItems; // 0x18
        public Sentry.Internal.ConcurrentQueueLite`1<Sentry.Protocol.Envelopes.Envelope> _queue; // 0x20
        public int _maxItems; // 0x28
        public System.Threading.CancellationTokenSource _shutdownSource; // 0x30
        public System.Threading.SemaphoreSlim _queuedEnvelopeSemaphore; // 0x38
        public bool _disposed; // 0x40
        public int _currentItems; // 0x44
        public System.EventHandler OnFlushObjectReceived; // 0x48
        public System.Threading.Tasks.Task <WorkerTask>k__BackingField; // 0x50

        // ── Methods ──
        public void add_OnFlushObjectReceived(){} // RVA: 0x7FFAC8B90480
        public void remove_OnFlushObjectReceived(){} // RVA: 0x7FFAC8B90570
        public void get_WorkerTask(){} // RVA: 0x7FFAC2FC20E0
        public void get_QueuedItems(){} // RVA: 0x7FFAC8B90660
        public void .ctor(){} // RVA: 0x7FFAC8B906B0
        public void EnqueueEnvelope(){} // RVA: 0x7FFAC8B90B50 | overloaded x2
        public void ProcessQueuedItems(){} // RVA: 0x7FFAC8B90EC0
        public void DoWorkAsync(){} // RVA: 0x7FFAC8B90EE0
        public void FlushAsync(){} // RVA: 0x7FFAC8B910B0
        public void DoFlushAsync(){} // RVA: 0x7FFAC8B91290
        public void SendFinalClientReportAsync(){} // RVA: 0x7FFAC8B914B0
        public void Dispose(){} // RVA: 0x7FFAC8B916C0
    }

    public class ClientReport : Object
    {
        public System.DateTimeOffset Timestamp; // 0x10
        public System.Collections.Generic.IReadOnlyDictionary`2<Sentry.Internal.DiscardReasonWithCategory,int> DiscardedEvents; // 0x20

        // ── Methods ──
        public void get_Timestamp(){} // RVA: 0x7FFAC4422E80
        public void get_DiscardedEvents(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC6CEBDD0
        public void WriteTo(){} // RVA: 0x7FFAC8B95D70
        public void FromJson(){} // RVA: 0x7FFAC8B96A40
    }

    public class ClientReportRecorder : Object
    {
        public Sentry.SentryOptions DiscardedEvents; // 0x10
        public Sentry.Infrastructure.ISystemClock _clock; // 0x18
        public Sentry.Internal.ThreadsafeCounterDictionary`1<Sentry.Internal.DiscardReasonWithCategory> _discardedEvents; // 0x20

        // ── Methods ──
        public void get_DiscardedEvents(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC8B97920
        public void RecordDiscardedEvent(){} // RVA: 0x7FFAC8B97C10
        public void GenerateClientReport(){} // RVA: 0x7FFAC8B97D90
        public void Load(){} // RVA: 0x7FFAC8B98040
    }

    public class ConcurrentQueueLite`1 : Object
    {
        public System.Collections.Generic.List`1<T> Count;

        // ── Methods ──
        public void Enqueue(){} // RVA: 0x7FFAC2E8DC40
        public void TryDequeue(){} // RVA: 0x7FFAC2C59F60
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void TryPeek(){} // RVA: 0x7FFAC2C59F60
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class Constants : Object
    {
        public string DsnEnvironmentVariable;
        public string ReleaseEnvironmentVariable;
        public string EnvironmentEnvironmentVariable;
        public string ProductionEnvironmentSetting;
        public string StagingEnvironmentSetting;
        public string DevelopmentEnvironmentSetting;
        public string DebugEnvironmentSetting;
        public string SdkName;
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAC8B983E0
        public void WriteScope(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DataCategory : ValueType
    {
        public Sentry.Internal.DataCategory Sentry.Internal.IEnumeration.Value;
        public Sentry.Internal.DataCategory Default; // 0x8
        public Sentry.Internal.DataCategory Error; // 0x10
        public Sentry.Internal.DataCategory Internal; // 0x18
        public Sentry.Internal.DataCategory Security; // 0x20
        public Sentry.Internal.DataCategory Session; // 0x28
        public Sentry.Internal.DataCategory Span; // 0x30
        public Sentry.Internal.DataCategory Transaction; // 0x38
        public Sentry.Internal.DataCategory Profile; // 0x40
        public string _value; // 0x10

        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x7FFAC3AD9F60
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void CompareTo(){} // RVA: 0x7FFAC8B99300 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8B993F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8B994C0
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void .cctor(){} // RVA: 0x7FFAC8B994F0
    }

    public class DebugStackTrace : SentryStackTrace
    {
        public Sentry.SentryOptions DebugImages; // 0x20
        public System.Collections.Generic.Dictionary`2<System.Guid,int> _debugImageIndexByModule; // 0x28
        public int DebugImageMissing;
        public bool _debugImagesMerged; // 0x30
        public System.Text.RegularExpressions.Regex RegexAsyncFunctionName;
        public System.Text.RegularExpressions.Regex RegexAnonymousFunction; // 0x8
        public System.Text.RegularExpressions.Regex RegexAsyncReturn; // 0x10
        public System.Text.RegularExpressions.Regex RegexNativeAOTInfo; // 0x18
        public System.Collections.Generic.List`1<Sentry.Protocol.DebugImage> <DebugImages>k__BackingField; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B99D10
        public void get_DebugImages(){} // RVA: 0x7FFAC31D0140
        public void Create(){} // RVA: 0x7FFAC8B9A030 | overloaded x2
        public void MergeDebugImagesInto(){} // RVA: 0x7FFAC8B9A5D0
        public void CreateFrames(){} // RVA: 0x7FFAC8B9AEF0
        public void TryCreateManagedFrame(){} // RVA: 0x7FFAC8B9B070
        public void CreateFrame(){} // RVA: 0x7FFAC8B9B7E0
        public void GetRelativeAddressMode(){} // RVA: 0x7FFAC8B9B9E0
        public void DemangleAsyncFunctionName(){} // RVA: 0x7FFAC8B9BA80
        public void DemangleAnonymousFunction(){} // RVA: 0x7FFAC8B9BD00
        public void DemangleLambdaReturnType(){} // RVA: 0x7FFAC8B9BEE0
        public void TryReadAssemblyFromDisk(){} // RVA: 0x7FFAC8B9C090
        public void AddManagedModuleDebugImage(){} // RVA: 0x7FFAC8B9C2C0
        public void GetManagedModuleDebugImage(){} // RVA: 0x7FFAC8B9C4F0
        public void .cctor(){} // RVA: 0x7FFAC8B9C970
    }

    public class DelegateEventProcessor : Object
    {
        public System.Func`2<Sentry.SentryEvent,Sentry.SentryEvent> _func; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Process(){} // RVA: 0x7FFAC7793490
    }

    public class DelegateTransactionProcessor : Object
    {
        public System.Func`2<Sentry.SentryTransaction,Sentry.SentryTransaction> _func; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Process(){} // RVA: 0x7FFAC7793490
    }

    public class DelimitedPrefixOrPatternMatcher : Object
    {
        public char <delimiter>P; // 0x10
        public 0x6B0C1288 <comparison>P; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B9D9D0
        public void IsMatch(){} // RVA: 0x7FFAC8B9D9E0
    }

    public class DiscardReason : ValueType
    {
        public Sentry.Internal.DiscardReason Sentry.Internal.IEnumeration.Value;
        public Sentry.Internal.DiscardReason CacheOverflow; // 0x8
        public Sentry.Internal.DiscardReason EventProcessor; // 0x10
        public Sentry.Internal.DiscardReason NetworkError; // 0x18
        public Sentry.Internal.DiscardReason QueueOverflow; // 0x20
        public Sentry.Internal.DiscardReason RateLimitBackoff; // 0x28
        public Sentry.Internal.DiscardReason SampleRate; // 0x30
        public string _value; // 0x10

        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x7FFAC3AD9F60
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void WithCategory(){} // RVA: 0x7FFAC8B9DCF0
        public void CompareTo(){} // RVA: 0x7FFAC8B9DD20 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8B9DE10 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8B994C0
        public void ToString(){} // RVA: 0x7FFAC3AD9F60
        public void .cctor(){} // RVA: 0x7FFAC8B9DEE0
    }

    public class DiscardReasonWithCategory : ValueType
    {
        public Sentry.Internal.DiscardReason Reason; // 0x10
        public Sentry.Internal.DataCategory Category; // 0x18

        // ── Methods ──
        public void get_Reason(){} // RVA: 0x7FFAC3AD9F60
        public void get_Category(){} // RVA: 0x7FFAC4420220
        public void .ctor(){} // RVA: 0x7FFAC60F4340 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAC8B9E730 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8B9E920 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8B9E9C0
        public void ToString(){} // RVA: 0x7FFAC8B9EA90
    }

    public class Disposable : Object
    {
        public System.Action _dispose; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Dispose(){} // RVA: 0x7FFAC3D3B830
        public void Create(){} // RVA: 0x7FFAC8B9EB70
    }

    public class DuplicateEventDetectionEventProcessor : Object
    {
        public Sentry.SentryOptions _options; // 0x10
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<object,object> _capturedObjects; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B9EC00
        public void Process(){} // RVA: 0x7FFAC8B9ED20
        public void IsDuplicate(){} // RVA: 0x7FFAC8B9EED0
    }

    public class Enricher : Object
    {
        public string DefaultIpAddress;
        public Sentry.SentryOptions _options; // 0x10
        public System.Lazy`1<Sentry.Protocol.Runtime> _runtimeLazy; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B9F300
        public void Apply(){} // RVA: 0x7FFAC8B9FDF0 | overloaded x2
    }

    public class ExceptionHandlingSynchronizationContext : SynchronizationContext
    {
        public System.Action`1<System.Exception> <exceptionHandler>P; // 0x18
        public System.Threading.SynchronizationContext <innerContext>P; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BA01A0
        public void Post(){} // RVA: 0x7FFAC8BA0250
    }

    public class ExceptionTypeFilter`1 : Object
    {
        public System.Type _filteredType;

        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFAC2C59F60
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class FileSystemBase : Object
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x7FFAC8BA0510 | overloaded x3
        public void DirectoryExists(){} // RVA: 0x7FFAC8BA05A0
        public void FileExists(){} // RVA: 0x7FFAC8BA05B0
        public void GetFileCreationTime(){} // RVA: 0x7FFAC8BA05C0
        public void ReadAllTextFromFile(){} // RVA: 0x7FFAC8BA0730
        public void OpenFileForReading(){} // RVA: 0x7FFAC8BA0810
        public void CreateDirectory(){} // RVA: 0x7FFAC2C59F60
        public void DeleteDirectory(){}
        public void CreateFileForWriting(){} // RVA: 0x7FFAC2C5D200
        public void WriteAllTextToFile(){} // RVA: 0x7FFAC2C5D200
        public void MoveFile(){}
        public void DeleteFile(){} // RVA: 0x7FFAC2C59F60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GrowableArray`1 : ValueType
    {
        public T[] Item;
        public int Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void Reserve(){} // RVA: 0x7FFAC2C70ED0
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void AddRange(){} // RVA: 0x7FFAC2C70A40
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveRange(){} // RVA: 0x7FFAC2C72E60
        public void get_Empty(){} // RVA: 0x7FFAC2C59D00
        public void Trim(){} // RVA: 0x7FFAC2C70ED0
        public void get_EmptyCapacity(){} // RVA: 0x7FFAC2C59D00
        public void ToString(){} // RVA: 0x7FFAC2C58E90
        public void Foreach(){} // RVA: 0x7FFAC2E8DC40
        public void Search(){} // RVA: 0x7FFAC2E8DC40
        public void get_UnderlyingArray(){} // RVA: 0x7FFAC2C58E90
        public void Realloc(){} // RVA: 0x7FFAC2C70ED0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class HashableGrowableArray`1 : ValueType
    {
        public Sentry.Internal.GrowableArray`1<T> Item;
        public int Count;
        public bool _sealed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void Seal(){} // RVA: 0x7FFAC2C70980
        public void Trim(){} // RVA: 0x7FFAC2C70ED0
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void GetHashCode(){} // RVA: 0x7FFAC2C59960
        public void Equals(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class Hub : Object
    {
        public object ExceptionToSpanMap; // 0x10
        public Sentry.Infrastructure.ISystemClock ScopeManager; // 0x18
        public Sentry.ISessionManager Metrics; // 0x20
        public Sentry.SentryOptions IsEnabled; // 0x28
        public Sentry.Internal.RandomValuesFactory Options; // 0x30
        public int CurrentScope; // 0x38
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Exception,Sentry.ISpan> CurrentClient; // 0x40
        public Sentry.Internal.IInternalScopeManager LastEventId; // 0x48
        public Sentry.IMetricAggregator <Metrics>k__BackingField; // 0x50
        public int _isEnabled; // 0x58

        // ── Methods ──
        public void get_ExceptionToSpanMap(){} // RVA: 0x7FFAC2F9E740
        public void get_ScopeManager(){} // RVA: 0x7FFAC2F9C730
        public void get_Metrics(){} // RVA: 0x7FFAC2FC20E0
        public void get_IsEnabled(){} // RVA: 0x7FFAC8BA0820
        public void get_Options(){} // RVA: 0x7FFAC2F4F130
        public void get_CurrentScope(){} // RVA: 0x7FFAC8BA0830
        public void get_CurrentClient(){} // RVA: 0x7FFAC8BA0900
        public void .ctor(){} // RVA: 0x7FFAC8BA09D0
        public void ConfigureScope(){} // RVA: 0x7FFAC8BA13D0
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAC8BA1490
        public void PushScope(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void RestoreScope(){} // RVA: 0x7FFAC8BA16F0
        public void BindClient(){} // RVA: 0x7FFAC8BA17C0
        public void StartTransaction(){} // RVA: 0x7FFAC8BA1840 | overloaded x2
        public void BindException(){} // RVA: 0x7FFAC8BA1E30
        public void GetSpan(){} // RVA: 0x7FFAC8BA1FC0
        public void GetTraceHeader(){} // RVA: 0x7FFAC8BA1FF0
        public void GetBaggage(){} // RVA: 0x7FFAC8BA20C0
        public void ContinueTrace(){} // RVA: 0x7FFAC8BA2330 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFAC8BA26C0
        public void PauseSession(){} // RVA: 0x7FFAC8BA2840
        public void ResumeSession(){} // RVA: 0x7FFAC8BA2A50
        public void EndSession(){} // RVA: 0x7FFAC8BA2F90 | overloaded x2
        public void GetLinkedSpan(){} // RVA: 0x7FFAC8BA3010
        public void ApplyTraceContextToEvent(){} // RVA: 0x7FFAC8BA33A0 | overloaded x2
        public void CaptureEnvelope(){} // RVA: 0x7FFAC8BA3590
        public void AddBreadcrumbForException(){} // RVA: 0x7FFAC8BA3600
        public void CaptureEvent(){} // RVA: 0x7FFAC8BA3B50 | overloaded x4
        public void CaptureUserFeedback(){} // RVA: 0x7FFAC8BA3F90
        public void CaptureTransaction(){} // RVA: 0x7FFAC8BA40E0 | overloaded x2
        public void CaptureMetrics(){} // RVA: 0x7FFAC8BA41E0
        public void CaptureCodeLocations(){} // RVA: 0x7FFAC8BA4570
        public void StartSpan(){} // RVA: 0x7FFAC8BA4820
        public void CaptureSession(){} // RVA: 0x7FFAC8BA49D0
        public void CaptureCheckIn(){} // RVA: 0x7FFAC8BA4B00
        public void FlushAsync(){} // RVA: 0x7FFAC8BA4D90
        public void Dispose(){} // RVA: 0x7FFAC8BA4F60
        public void get_LastEventId(){} // RVA: 0x7FFAC8BA5110
    }

    public class IAppDomain
    {
        // ── Methods ──
        public void add_UnhandledException(){} // RVA: 0x7FFAC2C70A40
        public void remove_UnhandledException(){} // RVA: 0x7FFAC2C70A40
        public void add_ProcessExit(){} // RVA: 0x7FFAC2C70A40
        public void remove_ProcessExit(){} // RVA: 0x7FFAC2C70A40
        public void add_UnobservedTaskException(){} // RVA: 0x7FFAC2C70A40
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFAC2C70A40
    }

    public class IClientReportRecorder
    {
        // ── Methods ──
        public void RecordDiscardedEvent(){}
        public void GenerateClientReport(){} // RVA: 0x7FFAC2C58E90
        public void Load(){} // RVA: 0x7FFAC2C70A40
    }

    public class ICloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IEnumeration
    {
        public object Value;

        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFAC2C58E90
    }

    public class IEnumeration`1
    {
    }

    public class IFileSystem
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x3
        public void DirectoryExists(){} // RVA: 0x7FFAC2C59F60
        public void FileExists(){} // RVA: 0x7FFAC2C59F60
        public void GetFileCreationTime(){}
        public void ReadAllTextFromFile(){} // RVA: 0x7FFAC2C58F40
        public void OpenFileForReading(){} // RVA: 0x7FFAC2C58F40
        public void CreateDirectory(){} // RVA: 0x7FFAC2C59F60
        public void DeleteDirectory(){}
        public void CreateFileForWriting(){} // RVA: 0x7FFAC2C5D200
        public void WriteAllTextToFile(){} // RVA: 0x7FFAC2C5D200
        public void MoveFile(){}
        public void DeleteFile(){} // RVA: 0x7FFAC2C59F60
    }

    public class IInternalScopeManager
    {
        public object ScopeStackContainer;

        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7FFAC2C588A0
        public void RestoreScope(){} // RVA: 0x7FFAC2C70A40
        public void get_ScopeStackContainer(){} // RVA: 0x7FFAC2C58E90
    }

    public class IPing
    {
        // ── Methods ──
        public void IsAvailableAsync(){}
    }

    public class IStackFrame
    {
        public object Frame;

        // ── Methods ──
        public void get_Frame(){} // RVA: 0x7FFAC2C58E90
        public void GetNativeImageBase(){} // RVA: 0x7FFAC2C58E90
        public void GetNativeIP(){} // RVA: 0x7FFAC2C58E90
        public void HasNativeImage(){} // RVA: 0x7FFAC2C59D00
        public void GetFileColumnNumber(){} // RVA: 0x7FFAC2C59960
        public void GetFileLineNumber(){} // RVA: 0x7FFAC2C59960
        public void GetFileName(){} // RVA: 0x7FFAC2C58E90
        public void GetILOffset(){} // RVA: 0x7FFAC2C59960
        public void GetMethod(){} // RVA: 0x7FFAC2C58E90
        public void ToString(){} // RVA: 0x7FFAC2C58E90
    }

    public class IStringOrRegexMatcher
    {
        // ── Methods ──
        public void IsMatch(){} // RVA: 0x7FFAC2C5D200
    }

    public class ITransactionProfiler
    {
        // ── Methods ──
        public void Finish(){} // RVA: 0x7FFAC2C70980
        public void Collect(){} // RVA: 0x7FFAC2C58F40
    }

    public class ITransactionProfilerFactory
    {
        // ── Methods ──
        public void Start(){}
    }

    public class IUpdatable
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x7FFAC2C70A40
    }

    public class IUpdatable`1
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x7FFAC2E8DC40
    }

    public class InstallationIdHelper : Object
    {
        public Sentry.SentryOptions <options>P; // 0x10
        public object _installationIdLock; // 0x18
        public string _installationId; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BA5A10
        public void TryGetInstallationId(){} // RVA: 0x7FFAC8BA5B10
        public void TryGetPersistentInstallationId(){} // RVA: 0x7FFAC8BA5E20
        public void TryGetHardwareInstallationId(){} // RVA: 0x7FFAC8BA6470
        public void GetMachineNameInstallationId(){} // RVA: 0x7FFAC8BA6860
    }

    public class Json : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Load(){} // RVA: 0x7FFAC2E8DC40
    }

    public class Lock : Object
    {
        public Sentry.Internal.Signal _signal; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BA69D0
        public void AcquireAsync(){} // RVA: 0x7FFAC8BA6A70
        public void Dispose(){} // RVA: 0x7FFAC8BA6C60
    }

    public class MainExceptionProcessor : Object
    {
        public string SentryStackTraceFactoryAccessor;
        public string ExceptionDataTagKey;
        public string ExceptionDataContextKey;
        public Sentry.SentryOptions _options; // 0x10
        public System.Func`1<Sentry.Extensibility.ISentryStackTraceFactory> <SentryStackTraceFactoryAccessor>k__BackingField; // 0x18

        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void Process(){} // RVA: 0x7FFAC8BA70B0
        public void CreateSentryExceptions(){} // RVA: 0x7FFAC8BA71D0
        public void WalkExceptions(){} // RVA: 0x7FFAC8BA7420 | overloaded x2
        public void MoveExceptionDataToEvent(){} // RVA: 0x7FFAC8BA7600
        public void BuildSentryException(){} // RVA: 0x7FFAC8BA80F0
        public void GetMechanism(){} // RVA: 0x7FFAC8BA8490
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
        public Sentry.Internal.Enricher _enricher; // 0x10
        public Sentry.SentryOptions _options; // 0x18
        public System.Func`1<Sentry.Extensibility.ISentryStackTraceFactory> <SentryStackTraceFactoryAccessor>k__BackingField; // 0x20

        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Release(){} // RVA: 0x7FFAC8BA9BC0
        public void get_Distribution(){} // RVA: 0x7FFAC8BA9BF0
        public void .ctor(){} // RVA: 0x7FFAC8BA9C10
        public void Process(){} // RVA: 0x7FFAC8BA9D90
        public void AddMemoryInfo(){} // RVA: 0x7FFAC2F21310
        public void AddThreadPoolInfo(){} // RVA: 0x7FFAC8BAAE20
        public void CultureInfoToDictionary(){} // RVA: 0x7FFAC8BAAF70
    }

    public class ModuleExtensions : Object
    {
        public string UnknownLocation;

        // ── Methods ──
        public void GetNameOrScopeName(){} // RVA: 0x7FFAC8BAB2A0
    }

    public class NoOpSpan : Object
    {
        public Sentry.ISpan Instance;
        public string SpanId; // 0x10

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8BAB390
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_SpanId(){} // RVA: 0x7FFAC8BAB3F0
        public void get_ParentSpanId(){} // RVA: 0x7FFAC8BAB450
        public void get_TraceId(){} // RVA: 0x7FFAC8BAB4D0
        public void get_IsSampled(){} // RVA: 0x7FFAC34F9180
        public void get_Tags(){} // RVA: 0x7FFAC8BAB530
        public void get_Extra(){} // RVA: 0x7FFAC8BAB590
        public void get_StartTimestamp(){} // RVA: 0x7FFAC3FB3780
        public void get_EndTimestamp(){} // RVA: 0x7FFAC684A7D0
        public void get_IsFinished(){} // RVA: 0x7FFAC2F21320
        public void get_Operation(){} // RVA: 0x7FFAC8BAB5F0
        public void set_Operation(){} // RVA: 0x7FFAC2F21310
        public void get_Description(){} // RVA: 0x7FFAC34F9180
        public void set_Description(){} // RVA: 0x7FFAC2F21310
        public void get_Status(){} // RVA: 0x7FFAC34F9180
        public void set_Status(){} // RVA: 0x7FFAC2F21310
        public void StartChild(){} // RVA: 0x7FFAC44F81E0
        public void Finish(){} // RVA: 0x7FFAC2F21310 | overloaded x4
        public void SetTag(){} // RVA: 0x7FFAC2F21310
        public void UnsetTag(){} // RVA: 0x7FFAC2F21310
        public void SetExtra(){} // RVA: 0x7FFAC2F21310
        public void GetTraceHeader(){} // RVA: 0x7FFAC8BAB630
        public void get_Measurements(){} // RVA: 0x7FFAC8BAB690
        public void SetMeasurement(){} // RVA: 0x7FFAC2F21310
        public void get_Origin(){} // RVA: 0x7FFAC2F3C380
        public void set_Origin(){} // RVA: 0x7FFAC2F22E30
        public void .cctor(){} // RVA: 0x7FFAC8BAB6F0
    }

    public class NoOpTransaction : NoOpSpan
    {
        public Sentry.ITransactionTracer Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8BAB790
        public void .ctor(){} // RVA: 0x7FFAC8BAB7F0
        public void get_Sdk(){} // RVA: 0x7FFAC8BAB840
        public void get_Name(){} // RVA: 0x7FFAC8BAB890
        public void set_Name(){} // RVA: 0x7FFAC2F21310
        public void get_IsParentSampled(){} // RVA: 0x7FFAC34F9180
        public void set_IsParentSampled(){} // RVA: 0x7FFAC2F21310
        public void get_NameSource(){} // RVA: 0x7FFAC34F9180
        public void get_Distribution(){} // RVA: 0x7FFAC8BAB8D0
        public void set_Distribution(){} // RVA: 0x7FFAC2F21310
        public void get_Level(){} // RVA: 0x7FFAC34F9180
        public void set_Level(){} // RVA: 0x7FFAC2F21310
        public void get_Request(){} // RVA: 0x7FFAC8BAB910
        public void set_Request(){} // RVA: 0x7FFAC2F21310
        public void get_Contexts(){} // RVA: 0x7FFAC8BAB950
        public void set_Contexts(){} // RVA: 0x7FFAC2F21310
        public void get_User(){} // RVA: 0x7FFAC8BAB9A0
        public void set_User(){} // RVA: 0x7FFAC2F21310
        public void get_Platform(){} // RVA: 0x7FFAC34F9180
        public void set_Platform(){} // RVA: 0x7FFAC2F21310
        public void get_Release(){} // RVA: 0x7FFAC34F9180
        public void set_Release(){} // RVA: 0x7FFAC2F21310
        public void get_Environment(){} // RVA: 0x7FFAC34F9180
        public void set_Environment(){} // RVA: 0x7FFAC2F21310
        public void get_TransactionName(){} // RVA: 0x7FFAC34F9180
        public void set_TransactionName(){} // RVA: 0x7FFAC2F21310
        public void get_Fingerprint(){} // RVA: 0x7FFAC8BAB9E0
        public void set_Fingerprint(){} // RVA: 0x7FFAC2F21310
        public void get_Spans(){} // RVA: 0x7FFAC8BABA40
        public void get_Breadcrumbs(){} // RVA: 0x7FFAC8BABAA0
        public void GetLastActiveSpan(){} // RVA: 0x7FFAC34F9180
        public void AddBreadcrumb(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8BABB00
    }

    public class ObjectExtensions : Object
    {
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<object,System.Collections.Generic.Dictionary`2<string,object>> Map;

        // ── Methods ──
        public void get_Map(){} // RVA: 0x7FFAC8BABBE0
        public void AssociatedProperties(){} // RVA: 0x7FFAC8BABC40
        public void SetFused(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetFused(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC8BABEE0
    }

    public class OriginHelper : Object
    {
        public string Manual;
        public string ValidOriginPattern;
        public System.Text.RegularExpressions.Regex ValidOrigin;

        // ── Methods ──
        public void IsValidOrigin(){} // RVA: 0x7FFAC8BAC0C0
        public void TryParse(){} // RVA: 0x7FFAC8BAC170
        public void SetOrigin(){} // RVA: 0x7FFAC8BAC1D0
        public void .cctor(){} // RVA: 0x7FFAC8BAC3E0
    }

    public class PartialStream : Stream
    {
        public System.IO.Stream CanRead; // 0x28
        public long CanSeek; // 0x30
        public System.Nullable`1<long> CanWrite; // 0x38
        public long Length; // 0x48

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFAC8BAC4C0
        public void get_CanSeek(){} // RVA: 0x7FFAC8BAC4F0
        public void get_CanWrite(){} // RVA: 0x7FFAC2F21320
        public void get_Length(){} // RVA: 0x7FFAC8BAC520
        public void get_Position(){} // RVA: 0x7FFAC2F9C730
        public void set_Position(){} // RVA: 0x7FFAC8BAC5B0
        public void .ctor(){} // RVA: 0x7FFAC8BAC660
        public void ReadAsync(){} // RVA: 0x7FFAC8BAC730
        public void Seek(){} // RVA: 0x7FFAC8BAC9C0
        public void Read(){} // RVA: 0x7FFAC8BACAF0
        public void SetLength(){} // RVA: 0x7FFAC8BACC40
        public void Write(){} // RVA: 0x7FFAC8BACC80
        public void Flush(){} // RVA: 0x7FFAC8BACCC0
    }

    public class PiiExtensions : Object
    {
        public string RedactedText;
        public System.Text.RegularExpressions.Regex AuthRegex;
        public System.Text.RegularExpressions.Regex UserInfoMatcher; // 0x8

        // ── Methods ──
        public void RedactUrl(){} // RVA: 0x7FFAC8BAD1D0
        public void RedactAuth(){} // RVA: 0x7FFAC8BAD440
        public void .cctor(){} // RVA: 0x7FFAC8BAD720
    }

    public class PollingNetworkStatusListener : Object
    {
        public Sentry.SentryOptions LazyPing; // 0x10
        public Sentry.Internal.IPing Ping; // 0x18
        public int Online; // 0x20
        public int _maxDelayInMilliseconds; // 0x24
        public System.Func`2<int,int> _backoffFunction; // 0x28
        public bool _online; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BADC30 | overloaded x2
        public void get_LazyPing(){} // RVA: 0x7FFAC8BADE50
        public void get_Ping(){} // RVA: 0x7FFAC8BADF30
        public void get_Online(){} // RVA: 0x7FFAC8BAE040
        public void set_Online(){} // RVA: 0x7FFAC8BAE050
        public void WaitForNetworkOnlineAsync(){} // RVA: 0x7FFAC8BAE060
        public void <get_LazyPing>b__8_0(){} // RVA: 0x7FFAC8BAE270
    }

    public class PooledBuffer`1 : ValueType
    {
        public T[] Array;

        // ── Methods ──
        public void get_Array(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70ED0
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class PrefixOrPatternMatcher : Object
    {
        public 0x6B0C1288 <comparison>P; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void IsMatch(){} // RVA: 0x7FFAC8BAEC90
    }

    public class ProcessInfo : Object
    {
        public Sentry.Internal.ProcessInfo StartupTime;
        public System.Nullable`1<System.DateTimeOffset> BootTime; // 0x10
        public System.Nullable`1<System.DateTimeOffset> PreciseAppStartupTask; // 0x28
        public System.Threading.Tasks.Task _preciseAppStartupTask; // 0x40
        public System.Nullable`1<int> _id; // 0x48

        // ── Methods ──
        public void get_StartupTime(){} // RVA: 0x7FFAC4AB3E90
        public void set_StartupTime(){} // RVA: 0x7FFAC4AB3EB0
        public void get_BootTime(){} // RVA: 0x7FFAC4B71360
        public void get_PreciseAppStartupTask(){} // RVA: 0x7FFAC8BAEE00
        public void set_PreciseAppStartupTask(){} // RVA: 0x7FFAC8BAEE10
        public void GetId(){} // RVA: 0x7FFAC8BAEE70
        public void GetCurrentProcessId(){} // RVA: 0x7FFAC8BAEED0
        public void .ctor(){} // RVA: 0x7FFAC8BAEFB0
        public void GetStartupTime(){} // RVA: 0x7FFAC8BAF840
        public void ApplicationIsActivated(){} // RVA: 0x7FFAC8BAFA00
        public void GetForegroundWindow(){} // RVA: 0x7FFAC8BAFDD0
        public void GetWindowThreadProcessId(){} // RVA: 0x7FFAC8BAFE40
    }

    public class RandomValuesFactory : Object
    {
        // ── Methods ──
        public void NextInt(){} // RVA: 0x7FFAC2C60290 | overloaded x2
        public void NextDouble(){} // RVA: 0x7FFAC2C5EB60
        public void NextBytes(){} // RVA: 0x7FFAC2C70A40
        public void NextBool(){} // RVA: 0x7FFAC8BB0100
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ReadOnlyFileSystem : FileSystemBase
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7FFAC2F21320
        public void DeleteDirectory(){} // RVA: 0x7FFAC2F21320
        public void CreateFileForWriting(){} // RVA: 0x7FFAC8BB0160
        public void WriteAllTextToFile(){} // RVA: 0x7FFAC2F21320
        public void MoveFile(){} // RVA: 0x7FFAC2F21320
        public void DeleteFile(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ReadWriteFileSystem : FileSystemBase
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7FFAC8BB0200
        public void DeleteDirectory(){} // RVA: 0x7FFAC8BB0230
        public void CreateFileForWriting(){} // RVA: 0x7FFAC8BB0260
        public void WriteAllTextToFile(){} // RVA: 0x7FFAC8BB0340
        public void MoveFile(){} // RVA: 0x7FFAC8BB0370
        public void DeleteFile(){} // RVA: 0x7FFAC8BB03E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class RealStackFrame : Object
    {
        public System.Diagnostics.StackFrame Frame; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Frame(){} // RVA: 0x7FFAC2F3C380
        public void ToString(){} // RVA: 0x7FFAC3CE8330
        public void GetFileColumnNumber(){} // RVA: 0x7FFAC87BB0A0
        public void GetFileLineNumber(){} // RVA: 0x7FFAC84E9CA0
        public void GetFileName(){} // RVA: 0x7FFAC880FE40
        public void GetILOffset(){} // RVA: 0x7FFAC88045A0
        public void GetMethod(){} // RVA: 0x7FFAC33088E0
        public void GetNativeImageBase(){} // RVA: 0x7FFAC34F9180
        public void GetNativeIP(){} // RVA: 0x7FFAC34F9180
        public void HasNativeImage(){} // RVA: 0x7FFAC2F21320
    }

    public class ScopeObserver : Object
    {
        public Sentry.SentryOptions _options; // 0x10
        public string _name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84642F0
        public void AddBreadcrumb(){} // RVA: 0x7FFAC8BB04D0
        public void AddBreadcrumbImpl(){} // RVA: 0x7FFAC2C70A40
        public void SetExtra(){} // RVA: 0x7FFAC8BB06E0
        public void SetExtraImpl(){} // RVA: 0x7FFAC2C79B30
        public void SetTag(){} // RVA: 0x7FFAC8BB0A40
        public void SetTagImpl(){} // RVA: 0x7FFAC2C79B30
        public void UnsetTag(){} // RVA: 0x7FFAC8BB0C20
        public void UnsetTagImpl(){} // RVA: 0x7FFAC2C70A40
        public void SetUser(){} // RVA: 0x7FFAC8BB0DC0
        public void SetUserImpl(){} // RVA: 0x7FFAC2C70A40
        public void UnsetUserImpl(){} // RVA: 0x7FFAC2C70980
    }

    public class SdkComposer : Object
    {
        public Sentry.SentryOptions _options; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BB1080
        public void CreateTransport(){} // RVA: 0x7FFAC8BB1190
        public void CreateHttpTransport(){} // RVA: 0x7FFAC8BB17E0
        public void CreateBackgroundWorker(){} // RVA: 0x7FFAC8BB1AB0
    }

    public class SentryScopeManager : Object
    {
        public Sentry.Internal.ScopeStack.IScopeStackContainer ScopeStackContainer; // 0x10
        public Sentry.SentryOptions ScopeAndClientStack; // 0x18
        public System.Func`1<System.Collections.Generic.KeyValuePair`2<Sentry.Scope,Sentry.ISentryClient>[]> NewStack; // 0x20

        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7FFAC2F3C380
        public void get_ScopeAndClientStack(){} // RVA: 0x7FFAC8BB1C10
        public void set_ScopeAndClientStack(){} // RVA: 0x7FFAC8BB1D00
        public void get_NewStack(){} // RVA: 0x7FFAC2F4F0C0
        public void get_IsGlobalMode(){} // RVA: 0x7FFAC8BB1D60
        public void .ctor(){} // RVA: 0x7FFAC8BB1DF0
        public void GetCurrent(){} // RVA: 0x7FFAC8BB2150
        public void ConfigureScope(){} // RVA: 0x7FFAC8BB21A0
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAC8BB2330
        public void PushScope(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void RestoreScope(){} // RVA: 0x7FFAC8BB2530
        public void BindClient(){} // RVA: 0x7FFAC8BB2990
        public void Dispose(){} // RVA: 0x7FFAC8BB2CA0
    }

    public class SentryStopwatch : ValueType
    {
        public double StartDateTimeOffset;
        public double CurrentDateTimeOffset; // 0x8
        public long Elapsed; // 0x10
        public System.DateTimeOffset ElapsedNanoseconds; // 0x18

        // ── Methods ──
        public void StartNew(){} // RVA: 0x7FFAC8BB2F90
        public void get_StartDateTimeOffset(){} // RVA: 0x7FFAC4A927D0
        public void get_CurrentDateTimeOffset(){} // RVA: 0x7FFAC8BB3070
        public void Diff(){} // RVA: 0x7FFAC8BB3130
        public void get_Elapsed(){} // RVA: 0x7FFAC8BB3180
        public void get_ElapsedNanoseconds(){} // RVA: 0x7FFAC8BB3270
        public void .cctor(){} // RVA: 0x7FFAC8BB3360
    }

    public class SerializableExtensions : Object
    {
        // ── Methods ──
        public void SerializeToStringAsync(){} // RVA: 0x7FFAC8BB3420
        public void SerializeToString(){} // RVA: 0x7FFAC8BB36C0
    }

    public class SettingLocator : Object
    {
        public Sentry.SentryOptions AssemblyForAttributes; // 0x10
        public System.Reflection.Assembly <AssemblyForAttributes>k__BackingField; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BB4570
        public void get_AssemblyForAttributes(){} // RVA: 0x7FFAC2F247C0
        public void set_AssemblyForAttributes(){} // RVA: 0x7FFAC2F87E80
        public void GetEnvironmentVariable(){} // RVA: 0x7FFAC8BB4630
        public void GetDsn(){} // RVA: 0x7FFAC8BB4640
        public void GetEnvironment(){} // RVA: 0x7FFAC8BB4790 | overloaded x2
        public void GetRelease(){} // RVA: 0x7FFAC8BB48C0
    }

    public class Signal : Object
    {
        public object _lock; // 0x10
        public System.Threading.SemaphoreSlim _semaphore; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BB4AB0
        public void Release(){} // RVA: 0x7FFAC8BB4C10
        public void WaitAsync(){} // RVA: 0x7FFAC8BB4DB0
        public void Dispose(){} // RVA: 0x7FFAC8BB4DE0
    }

    public class StringOrRegex : Object
    {
        public System.Text.RegularExpressions.Regex _regex; // 0x10
        public string _prefix; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC8BB4E90 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC8BB4F20
        public void Equals(){} // RVA: 0x7FFAC8BB4F90
        public void GetHashCode(){} // RVA: 0x7FFAC49DB960
    }

    public class StringOrRegexExtensions : Object
    {
        // ── Methods ──
        public void MatchesAny(){} // RVA: 0x7FFAC8BB5090
    }

    public class SynchronizedRandomValuesFactory : RandomValuesFactory
    {
        public System.Threading.AsyncLocal`1<System.Random> Random;

        // ── Methods ──
        public void get_Random(){} // RVA: 0x7FFAC8BB5290
        public void NextInt(){} // RVA: 0x7FFAC8BB5430 | overloaded x2
        public void NextDouble(){} // RVA: 0x7FFAC8BB54B0
        public void NextBytes(){} // RVA: 0x7FFAC8BB5520
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8BB5590
    }

    public class TcpPing : Object
    {
        public string <hostToCheck>P; // 0x10
        public int <portToCheck>P; // 0x18
        public System.Net.NetworkInformation.Ping _ping; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BB5650
        public void IsAvailableAsync(){} // RVA: 0x7FFAC8BB5880
    }

    public class ThreadPoolInfo : Object
    {
        public int MinWorkerThreads; // 0x10
        public int MinCompletionPortThreads; // 0x14
        public int MaxWorkerThreads; // 0x18
        public int MaxCompletionPortThreads; // 0x1C
        public int AvailableWorkerThreads; // 0x20
        public int AvailableCompletionPortThreads; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BB5F10
        public void get_MinWorkerThreads(){} // RVA: 0x7FFAC2F6E5C0
        public void get_MinCompletionPortThreads(){} // RVA: 0x7FFAC33D5A20
        public void get_MaxWorkerThreads(){} // RVA: 0x7FFAC3157800
        public void get_MaxCompletionPortThreads(){} // RVA: 0x7FFAC44357F0
        public void get_AvailableWorkerThreads(){} // RVA: 0x7FFAC30DBBE0
        public void get_AvailableCompletionPortThreads(){} // RVA: 0x7FFAC3921980
        public void WriteTo(){} // RVA: 0x7FFAC8BB5F40
    }

    public class ThreadsafeCounterDictionary`1 : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<T,CounterItem<T>> Count;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Increment(){} // RVA: 0x7FFAC2E8DC40
        public void ReadAndReset(){} // RVA: 0x7FFAC2E8DC40
        public void ReadAllAndReset(){} // RVA: 0x7FFAC2C58E90
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void ContainsKey(){} // RVA: 0x7FFAC2E8DC40
        public void TryGetValue(){} // RVA: 0x7FFAC2E8DC40
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void get_Keys(){} // RVA: 0x7FFAC2C58E90
        public void get_Values(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

}