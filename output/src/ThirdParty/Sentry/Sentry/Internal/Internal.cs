// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal
// Classes: 73
// Methods: 531

namespace ThirdParty.Sentry.Sentry.Internal
{
    public class AotHelper : Object
    {
        public string SuppressionJustification;

        // ── Methods ──
        public void get_IsTrimmed(){} // RVA: 0x7FFE86F38FD0
        public void .cctor(){} // RVA: 0x7FFE86F39030
    }

    public class AppDomainAdapter : Object
    {
        public Sentry.Internal.AppDomainAdapter _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE86F390E0
        public void .ctor(){} // RVA: 0x7FFE86F39140
        public void add_UnhandledException(){} // RVA: 0x7FFE86F39340
        public void remove_UnhandledException(){} // RVA: 0x7FFE86F39430
        public void add_ProcessExit(){} // RVA: 0x7FFE86F39520
        public void remove_ProcessExit(){} // RVA: 0x7FFE86F39610
        public void add_UnobservedTaskException(){} // RVA: 0x7FFE86F39700
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFE86F39800
        public void OnProcessExit(){} // RVA: 0x7FFE85A88580
        public void OnUnhandledException(){} // RVA: 0x7FFE86F39900
        public void OnUnobservedTaskException(){} // RVA: 0x7FFE86F39920
        public void .cctor(){} // RVA: 0x7FFE86F39940
    }

    public class ApplicationVersionLocator : Object
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7FFE86F399F0
    }

    public class AutoClearingList`1 : Object
    {
        public System.Collections.Generic.IList`1<T> _list;
        public bool _clearOnNextAdd;
        public object field_2; // 0x2D7

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E4BC00
        public void Add(){} // RVA: 0x7FFE810A1420
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
    }

    public class BackgroundWorker : Object
    {
        public Sentry.Extensibility.ITransport _transport; // 0x10
        public Sentry.SentryOptions _options; // 0x18

        // ── Methods ──
        public void add_OnFlushObjectReceived(){} // RVA: 0x7FFE86F39B00
        public void remove_OnFlushObjectReceived(){} // RVA: 0x7FFE86F39BF0
        public void get_WorkerTask(){} // RVA: 0x7FFE8119C0E0
        public void get_QueuedItems(){} // RVA: 0x7FFE86F39CE0
        public void .ctor(){} // RVA: 0x7FFE86F39D30
        public void EnqueueEnvelope(){} // RVA: 0x7FFE86F3A1D0 | overloaded x2
        public void ProcessQueuedItems(){} // RVA: 0x7FFE86F3A540
        public void DoWorkAsync(){} // RVA: 0x7FFE86F3A560
        public void FlushAsync(){} // RVA: 0x7FFE86F3A730
        public void DoFlushAsync(){} // RVA: 0x7FFE86F3A910
        public void SendFinalClientReportAsync(){} // RVA: 0x7FFE86F3AB30
        public void Dispose(){} // RVA: 0x7FFE86F3AD40
    }

    public class ClientReport : Object
    {
        public System.DateTimeOffset _timestamp; // 0x10
        public System.Collections.Generic.IReadOnlyDictionary`2<Sentry.Internal.DiscardReasonWithCategory,int> _discardedEvents; // 0x20

        // ── Methods ──
        public void get_Timestamp(){} // RVA: 0x7FFE826F6B90
        public void get_DiscardedEvents(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE850722B0
        public void WriteTo(){} // RVA: 0x7FFE86F3F3F0
        public void FromJson(){} // RVA: 0x7FFE86F400C0
    }

    public class ClientReportRecorder : Object
    {
        public Sentry.SentryOptions _options; // 0x10

        // ── Methods ──
        public void get_DiscardedEvents(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE86F40FA0
        public void RecordDiscardedEvent(){} // RVA: 0x7FFE86F41290
        public void GenerateClientReport(){} // RVA: 0x7FFE86F41410
        public void Load(){} // RVA: 0x7FFE86F416C0
    }

    public class ConcurrentQueueLite`1 : Object
    {
        public System.Collections.Generic.List`1<T> _queue;
        public object field_1; // 0x2DF

        // ── Methods ──
        public void Enqueue(){} // RVA: 0x7FFE810A1420
        public void TryDequeue(){} // RVA: 0x7FFE80E2F3B0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void TryPeek(){} // RVA: 0x7FFE80E2F3B0
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class Constants : Object
    {
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFE86F41A60
        public void WriteScope(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DataCategory : ValueType
    {
        public Sentry.Internal.DataCategory Attachment;

        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x7FFE8284EF60
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void CompareTo(){} // RVA: 0x7FFE86F42980 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE86F42A70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86F42B40
        public void ToString(){} // RVA: 0x7FFE8284EF60
        public void .cctor(){} // RVA: 0x7FFE86F42B70
    }

    public class DebugStackTrace : SentryStackTrace
    {
        public Sentry.SentryOptions _options; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F43390
        public void get_DebugImages(){} // RVA: 0x7FFE8143BA80
        public void Create(){} // RVA: 0x7FFE86F436B0 | overloaded x2
        public void MergeDebugImagesInto(){} // RVA: 0x7FFE86F43C50
        public void CreateFrames(){} // RVA: 0x7FFE86F44570
        public void TryCreateManagedFrame(){} // RVA: 0x7FFE86F446F0
        public void CreateFrame(){} // RVA: 0x7FFE86F44E60
        public void GetRelativeAddressMode(){} // RVA: 0x7FFE86F45060
        public void DemangleAsyncFunctionName(){} // RVA: 0x7FFE86F45100
        public void DemangleAnonymousFunction(){} // RVA: 0x7FFE86F45380
        public void DemangleLambdaReturnType(){} // RVA: 0x7FFE86F45560
        public void TryReadAssemblyFromDisk(){} // RVA: 0x7FFE86F45710
        public void AddManagedModuleDebugImage(){} // RVA: 0x7FFE86F45940
        public void GetManagedModuleDebugImage(){} // RVA: 0x7FFE86F45B70
        public void .cctor(){} // RVA: 0x7FFE86F45FF0
    }

    public class DelegateEventProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Process(){} // RVA: 0x7FFE85A7C5E0
    }

    public class DelegateTransactionProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Process(){} // RVA: 0x7FFE85A7C5E0
    }

    public class DelimitedPrefixOrPatternMatcher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F47050
        public void IsMatch(){} // RVA: 0x7FFE86F47060
    }

    public class DiscardReason : ValueType
    {
        public Sentry.Internal.DiscardReason BeforeSend;

        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x7FFE8284EF60
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void WithCategory(){} // RVA: 0x7FFE86F47370
        public void CompareTo(){} // RVA: 0x7FFE86F473A0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE86F47490 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86F42B40
        public void ToString(){} // RVA: 0x7FFE8284EF60
        public void .cctor(){} // RVA: 0x7FFE86F47560
    }

    public class DiscardReasonWithCategory : ValueType
    {
        public Sentry.Internal.DiscardReason _reason; // 0x10
        public Sentry.Internal.DataCategory _category; // 0x18

        // ── Methods ──
        public void get_Reason(){} // RVA: 0x7FFE8284EF60
        public void get_Category(){} // RVA: 0x7FFE826F4210
        public void .ctor(){} // RVA: 0x7FFE84459530 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFE86F47DB0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE86F47FA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86F48040
        public void ToString(){} // RVA: 0x7FFE86F48110
    }

    public class Disposable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Dispose(){} // RVA: 0x7FFE82001D60
        public void Create(){} // RVA: 0x7FFE86F481F0
    }

    public class DuplicateEventDetectionEventProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F48280
        public void Process(){} // RVA: 0x7FFE86F483A0
        public void IsDuplicate(){} // RVA: 0x7FFE86F48550
    }

    public class Enricher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F48980
        public void Apply(){} // RVA: 0x7FFE86F49470 | overloaded x2
    }

    public class ExceptionHandlingSynchronizationContext : SynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F49820
        public void Post(){} // RVA: 0x7FFE86F498D0
    }

    public class ExceptionTypeFilter`1 : Object
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFE80E2F3B0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class FileSystemBase : Object
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x7FFE86F49B90 | overloaded x3
        public void DirectoryExists(){} // RVA: 0x7FFE86F49C20
        public void FileExists(){} // RVA: 0x7FFE86F49C30
        public void GetFileCreationTime(){} // RVA: 0x7FFE86F49C40
        public void ReadAllTextFromFile(){} // RVA: 0x7FFE86F49DB0
        public void OpenFileForReading(){} // RVA: 0x7FFE86F49E90
        public void CreateDirectory(){} // RVA: 0x7FFE80E2F3B0
        public void DeleteDirectory(){}
        public void CreateFileForWriting(){} // RVA: 0x7FFE80E32650
        public void WriteAllTextToFile(){} // RVA: 0x7FFE80E32650
        public void MoveFile(){}
        public void DeleteFile(){} // RVA: 0x7FFE80E2F3B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GrowableArray`1 : ValueType
    {
        public T[] array;
        public int arrayLength;
        public Sample[] array; // 0x10
        public int arrayLength; // 0x18
        public object |EYf; // 0x658

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void Reserve(){} // RVA: 0x7FFE80E46530
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void AddRange(){} // RVA: 0x7FFE80E460A0
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void RemoveRange(){} // RVA: 0x7FFE80E484C0
        public void get_Empty(){} // RVA: 0x7FFE80E2F150
        public void Trim(){} // RVA: 0x7FFE80E46530
        public void get_EmptyCapacity(){} // RVA: 0x7FFE80E2F150
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
        public void Foreach(){} // RVA: 0x7FFE810A1420
        public void Search(){} // RVA: 0x7FFE810A1420
        public void get_UnderlyingArray(){} // RVA: 0x7FFE80E2E2E0
        public void Realloc(){} // RVA: 0x7FFE80E46530
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class HashableGrowableArray`1 : ValueType
    {
        public Sentry.Internal.GrowableArray`1<T> _items;
        public int _hashCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void Seal(){} // RVA: 0x7FFE80E45FE0
        public void Trim(){} // RVA: 0x7FFE80E46530
        public void Add(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE80E2EDB0
        public void Equals(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

    public class Hub : Object
    {
        public object _sessionPauseLock; // 0x10
        public Sentry.Infrastructure.ISystemClock _clock; // 0x18
        public Sentry.ISessionManager _sessionManager; // 0x20
        public Sentry.SentryOptions _options; // 0x28
        public Sentry.Internal.RandomValuesFactory _randomValuesFactory; // 0x30
        public int _isPersistedSessionRecovered; // 0x38
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Exception,Sentry.ISpan> _exceptionToSpanMap; // 0x40
        public Sentry.Internal.IInternalScopeManager _scopeManager; // 0x48

        // ── Methods ──
        public void get_ExceptionToSpanMap(){} // RVA: 0x7FFE81178740
        public void get_ScopeManager(){} // RVA: 0x7FFE81176730
        public void get_Metrics(){} // RVA: 0x7FFE8119C0E0
        public void get_IsEnabled(){} // RVA: 0x7FFE86F49EA0
        public void get_Options(){} // RVA: 0x7FFE81129130
        public void get_CurrentScope(){} // RVA: 0x7FFE86F49EB0
        public void get_CurrentClient(){} // RVA: 0x7FFE86F49F80
        public void .ctor(){} // RVA: 0x7FFE86F4A050
        public void ConfigureScope(){} // RVA: 0x7FFE86F4AA50
        public void ConfigureScopeAsync(){} // RVA: 0x7FFE86F4AB10
        public void PushScope(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void RestoreScope(){} // RVA: 0x7FFE86F4AD70
        public void BindClient(){} // RVA: 0x7FFE86F4AE40
        public void StartTransaction(){} // RVA: 0x7FFE86F4AEC0 | overloaded x2
        public void BindException(){} // RVA: 0x7FFE86F4B4B0
        public void GetSpan(){} // RVA: 0x7FFE86F4B640
        public void GetTraceHeader(){} // RVA: 0x7FFE86F4B670
        public void GetBaggage(){} // RVA: 0x7FFE86F4B740
        public void ContinueTrace(){} // RVA: 0x7FFE86F4B9B0 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFE86F4BD40
        public void PauseSession(){} // RVA: 0x7FFE86F4BEC0
        public void ResumeSession(){} // RVA: 0x7FFE86F4C0D0
        public void EndSession(){} // RVA: 0x7FFE86F4C610 | overloaded x2
        public void GetLinkedSpan(){} // RVA: 0x7FFE86F4C690
        public void ApplyTraceContextToEvent(){} // RVA: 0x7FFE86F4CA20 | overloaded x2
        public void CaptureEnvelope(){} // RVA: 0x7FFE86F4CC10
        public void AddBreadcrumbForException(){} // RVA: 0x7FFE86F4CC80
        public void CaptureEvent(){} // RVA: 0x7FFE86F4D1D0 | overloaded x4
        public void CaptureUserFeedback(){} // RVA: 0x7FFE86F4D610
        public void CaptureTransaction(){} // RVA: 0x7FFE86F4D760 | overloaded x2
        public void CaptureMetrics(){} // RVA: 0x7FFE86F4D860
        public void CaptureCodeLocations(){} // RVA: 0x7FFE86F4DBF0
        public void StartSpan(){} // RVA: 0x7FFE86F4DEA0
        public void CaptureSession(){} // RVA: 0x7FFE86F4E050
        public void CaptureCheckIn(){} // RVA: 0x7FFE86F4E180
        public void FlushAsync(){} // RVA: 0x7FFE86F4E410
        public void Dispose(){} // RVA: 0x7FFE86F4E5E0
        public void get_LastEventId(){} // RVA: 0x7FFE86F4E790
    }

    public class IAppDomain
    {
        // ── Methods ──
        public void add_UnhandledException(){} // RVA: 0x7FFE80E460A0
        public void remove_UnhandledException(){} // RVA: 0x7FFE80E460A0
        public void add_ProcessExit(){} // RVA: 0x7FFE80E460A0
        public void remove_ProcessExit(){} // RVA: 0x7FFE80E460A0
        public void add_UnobservedTaskException(){} // RVA: 0x7FFE80E460A0
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFE80E460A0
    }

    public class IClientReportRecorder
    {
        // ── Methods ──
        public void RecordDiscardedEvent(){}
        public void GenerateClientReport(){} // RVA: 0x7FFE80E2E2E0
        public void Load(){} // RVA: 0x7FFE80E460A0
    }

    public class ICloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFE810A1420
    }

    public class IEnumeration
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IEnumeration`1
    {
    }

    public class IFileSystem
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x7FFE80E3FC10 | overloaded x3
        public void DirectoryExists(){} // RVA: 0x7FFE80E2F3B0
        public void FileExists(){} // RVA: 0x7FFE80E2F3B0
        public void GetFileCreationTime(){}
        public void ReadAllTextFromFile(){} // RVA: 0x7FFE80E2E390
        public void OpenFileForReading(){} // RVA: 0x7FFE80E2E390
        public void CreateDirectory(){} // RVA: 0x7FFE80E2F3B0
        public void DeleteDirectory(){}
        public void CreateFileForWriting(){} // RVA: 0x7FFE80E32650
        public void WriteAllTextToFile(){} // RVA: 0x7FFE80E32650
        public void MoveFile(){}
        public void DeleteFile(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IInternalScopeManager
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7FFE80E2DCF0
        public void RestoreScope(){} // RVA: 0x7FFE80E460A0
        public void get_ScopeStackContainer(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IPing
    {
        // ── Methods ──
        public void IsAvailableAsync(){}
    }

    public class IStackFrame
    {
        // ── Methods ──
        public void get_Frame(){} // RVA: 0x7FFE80E2E2E0
        public void GetNativeImageBase(){} // RVA: 0x7FFE80E2E2E0
        public void GetNativeIP(){} // RVA: 0x7FFE80E2E2E0
        public void HasNativeImage(){} // RVA: 0x7FFE80E2F150
        public void GetFileColumnNumber(){} // RVA: 0x7FFE80E2EDB0
        public void GetFileLineNumber(){} // RVA: 0x7FFE80E2EDB0
        public void GetFileName(){} // RVA: 0x7FFE80E2E2E0
        public void GetILOffset(){} // RVA: 0x7FFE80E2EDB0
        public void GetMethod(){} // RVA: 0x7FFE80E2E2E0
        public void ToString(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IStringOrRegexMatcher
    {
        // ── Methods ──
        public void IsMatch(){} // RVA: 0x7FFE80E32650
    }

    public class ITransactionProfiler
    {
        // ── Methods ──
        public void Finish(){} // RVA: 0x7FFE80E45FE0
        public void Collect(){} // RVA: 0x7FFE80E2E390
    }

    public class ITransactionProfilerFactory
    {
        // ── Methods ──
        public void Start(){}
    }

    public class IUpdatable
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x7FFE80E460A0
    }

    public class IUpdatable`1
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x7FFE810A1420
    }

    public class InstallationIdHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F4F090
        public void TryGetInstallationId(){} // RVA: 0x7FFE86F4F190
        public void TryGetPersistentInstallationId(){} // RVA: 0x7FFE86F4F4A0
        public void TryGetHardwareInstallationId(){} // RVA: 0x7FFE86F4FAF0
        public void GetMachineNameInstallationId(){} // RVA: 0x7FFE86F4FEE0
    }

    public class Json : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Load(){} // RVA: 0x7FFE810A1420
    }

    public class Lock : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F50050
        public void AcquireAsync(){} // RVA: 0x7FFE86F500F0
        public void Dispose(){} // RVA: 0x7FFE86F502E0
    }

    public class MainExceptionProcessor : Object
    {
        public string ExceptionDataKeyPrefix;

        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void Process(){} // RVA: 0x7FFE86F50730
        public void CreateSentryExceptions(){} // RVA: 0x7FFE86F50850
        public void WalkExceptions(){} // RVA: 0x7FFE86F50AA0 | overloaded x2
        public void MoveExceptionDataToEvent(){} // RVA: 0x7FFE86F50C80
        public void BuildSentryException(){} // RVA: 0x7FFE86F51770
        public void GetMechanism(){} // RVA: 0x7FFE86F51B10
    }

    public class MainSentryEventProcessor : Object
    {
        public string CultureInfoKey;
        public string CurrentUiCultureKey;
        public string MemoryInfoKey;

        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x7FFE811290C0
        public void get_Release(){} // RVA: 0x7FFE86F53240
        public void get_Distribution(){} // RVA: 0x7FFE86F53270
        public void .ctor(){} // RVA: 0x7FFE86F53290
        public void Process(){} // RVA: 0x7FFE86F53410
        public void AddMemoryInfo(){} // RVA: 0x7FFE810FB310
        public void AddThreadPoolInfo(){} // RVA: 0x7FFE86F544A0
        public void CultureInfoToDictionary(){} // RVA: 0x7FFE86F545F0
    }

    public class ModuleExtensions : Object
    {
        // ── Methods ──
        public void GetNameOrScopeName(){} // RVA: 0x7FFE86F54920
    }

    public class NoOpSpan : Object
    {
        public Sentry.ISpan _instance;
        public string _origin; // 0x10
        public object field_2; // 0x301
        public object field_3; // 0x302
        public object field_4; // 0x303
        public object field_5; // 0x304
        public object field_6; // 0x305
        public object field_7; // 0x306
        public object field_8; // 0x307
        public object field_9; // 0x308
        public object field_10; // 0x309
        public object field_11; // 0x30A
        public object field_12; // 0x30B
        public object field_13; // 0x30C
        public object field_14; // 0x30D

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE86F54A10
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_SpanId(){} // RVA: 0x7FFE86F54A70
        public void get_ParentSpanId(){} // RVA: 0x7FFE86F54AD0
        public void get_TraceId(){} // RVA: 0x7FFE86F54B50
        public void get_IsSampled(){} // RVA: 0x7FFE813240E0
        public void get_Tags(){} // RVA: 0x7FFE86F54BB0
        public void get_Extra(){} // RVA: 0x7FFE86F54C10
        public void get_StartTimestamp(){} // RVA: 0x7FFE822CCD10
        public void get_EndTimestamp(){} // RVA: 0x7FFE84BAB710
        public void get_IsFinished(){} // RVA: 0x7FFE810FB320
        public void get_Operation(){} // RVA: 0x7FFE86F54C70
        public void set_Operation(){} // RVA: 0x7FFE810FB310
        public void get_Description(){} // RVA: 0x7FFE813240E0
        public void set_Description(){} // RVA: 0x7FFE810FB310
        public void get_Status(){} // RVA: 0x7FFE813240E0
        public void set_Status(){} // RVA: 0x7FFE810FB310
        public void StartChild(){} // RVA: 0x7FFE827C4A80
        public void Finish(){} // RVA: 0x7FFE810FB310 | overloaded x4
        public void SetTag(){} // RVA: 0x7FFE810FB310
        public void UnsetTag(){} // RVA: 0x7FFE810FB310
        public void SetExtra(){} // RVA: 0x7FFE810FB310
        public void GetTraceHeader(){} // RVA: 0x7FFE86F54CB0
        public void get_Measurements(){} // RVA: 0x7FFE86F54D10
        public void SetMeasurement(){} // RVA: 0x7FFE810FB310
        public void get_Origin(){} // RVA: 0x7FFE81116380
        public void set_Origin(){} // RVA: 0x7FFE810FCE30
        public void .cctor(){} // RVA: 0x7FFE86F54D70
    }

    public class NoOpTransaction : NoOpSpan
    {
        public Sentry.ITransactionTracer _instance;
        public object field_1; // 0x310
        public object field_2; // 0x311
        public object field_3; // 0x312
        public object field_4; // 0x313
        public object field_5; // 0x314
        public object field_6; // 0x315
        public object field_7; // 0x316
        public object field_8; // 0x317
        public object field_9; // 0x318
        public object field_10; // 0x319
        public object field_11; // 0x31A
        public object field_12; // 0x31B
        public object field_13; // 0x31C
        public object field_14; // 0x31D
        public object field_15; // 0x31E
        public object field_16; // 0x31F

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE86F54E10
        public void .ctor(){} // RVA: 0x7FFE86F54E70
        public void get_Sdk(){} // RVA: 0x7FFE86F54EC0
        public void get_Name(){} // RVA: 0x7FFE86F54F10
        public void set_Name(){} // RVA: 0x7FFE810FB310
        public void get_IsParentSampled(){} // RVA: 0x7FFE813240E0
        public void set_IsParentSampled(){} // RVA: 0x7FFE810FB310
        public void get_NameSource(){} // RVA: 0x7FFE813240E0
        public void get_Distribution(){} // RVA: 0x7FFE86F54F50
        public void set_Distribution(){} // RVA: 0x7FFE810FB310
        public void get_Level(){} // RVA: 0x7FFE813240E0
        public void set_Level(){} // RVA: 0x7FFE810FB310
        public void get_Request(){} // RVA: 0x7FFE86F54F90
        public void set_Request(){} // RVA: 0x7FFE810FB310
        public void get_Contexts(){} // RVA: 0x7FFE86F54FD0
        public void set_Contexts(){} // RVA: 0x7FFE810FB310
        public void get_User(){} // RVA: 0x7FFE86F55020
        public void set_User(){} // RVA: 0x7FFE810FB310
        public void get_Platform(){} // RVA: 0x7FFE813240E0
        public void set_Platform(){} // RVA: 0x7FFE810FB310
        public void get_Release(){} // RVA: 0x7FFE813240E0
        public void set_Release(){} // RVA: 0x7FFE810FB310
        public void get_Environment(){} // RVA: 0x7FFE813240E0
        public void set_Environment(){} // RVA: 0x7FFE810FB310
        public void get_TransactionName(){} // RVA: 0x7FFE813240E0
        public void set_TransactionName(){} // RVA: 0x7FFE810FB310
        public void get_Fingerprint(){} // RVA: 0x7FFE86F55060
        public void set_Fingerprint(){} // RVA: 0x7FFE810FB310
        public void get_Spans(){} // RVA: 0x7FFE86F550C0
        public void get_Breadcrumbs(){} // RVA: 0x7FFE86F55120
        public void GetLastActiveSpan(){} // RVA: 0x7FFE813240E0
        public void AddBreadcrumb(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86F55180
    }

    public class ObjectExtensions : Object
    {
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<object,System.Collections.Generic.Dictionary`2<string,object>> _map;

        // ── Methods ──
        public void get_Map(){} // RVA: 0x7FFE86F55260
        public void AssociatedProperties(){} // RVA: 0x7FFE86F552C0
        public void SetFused(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetFused(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE86F55560
    }

    public class OriginHelper : Object
    {
        // ── Methods ──
        public void IsValidOrigin(){} // RVA: 0x7FFE86F55740
        public void TryParse(){} // RVA: 0x7FFE86F557F0
        public void SetOrigin(){} // RVA: 0x7FFE86F55850
        public void .cctor(){} // RVA: 0x7FFE86F55A60
    }

    public class PartialStream : Stream
    {
        public System.IO.Stream _innerStream; // 0x28
        public long _offset; // 0x30
        public System.Nullable`1<long> _length; // 0x38
        public long _position; // 0x48
        public object field_4; // 0x322

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFE86F55B40
        public void get_CanSeek(){} // RVA: 0x7FFE86F55B70
        public void get_CanWrite(){} // RVA: 0x7FFE810FB320
        public void get_Length(){} // RVA: 0x7FFE86F55BA0
        public void get_Position(){} // RVA: 0x7FFE81176730
        public void set_Position(){} // RVA: 0x7FFE86F55C30
        public void .ctor(){} // RVA: 0x7FFE86F55CE0
        public void ReadAsync(){} // RVA: 0x7FFE86F55DB0
        public void Seek(){} // RVA: 0x7FFE86F56040
        public void Read(){} // RVA: 0x7FFE86F56170
        public void SetLength(){} // RVA: 0x7FFE86F562C0
        public void Write(){} // RVA: 0x7FFE86F56300
        public void Flush(){} // RVA: 0x7FFE86F56340
    }

    public class PiiExtensions : Object
    {
        // ── Methods ──
        public void RedactUrl(){} // RVA: 0x7FFE86F56850
        public void RedactAuth(){} // RVA: 0x7FFE86F56AC0
        public void .cctor(){} // RVA: 0x7FFE86F56DA0
    }

    public class PollingNetworkStatusListener : Object
    {
        public Sentry.SentryOptions _options; // 0x10
        public Sentry.Internal.IPing _testPing; // 0x18
        public int _delayInMilliseconds; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F572B0 | overloaded x2
        public void get_LazyPing(){} // RVA: 0x7FFE86F574D0
        public void get_Ping(){} // RVA: 0x7FFE86F575B0
        public void get_Online(){} // RVA: 0x7FFE86F576C0
        public void set_Online(){} // RVA: 0x7FFE86F576D0
        public void WaitForNetworkOnlineAsync(){} // RVA: 0x7FFE86F576E0
        public void <get_LazyPing>b__8_0(){} // RVA: 0x7FFE86F578F0
    }

    public class PooledBuffer`1 : ValueType
    {
        public T[] _array;

        // ── Methods ──
        public void get_Array(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E46530
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class PrefixOrPatternMatcher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void IsMatch(){} // RVA: 0x7FFE86F58310
    }

    public class ProcessInfo : Object
    {
        public Sentry.Internal.ProcessInfo Instance;
        public System.Nullable`1<System.DateTimeOffset> _startupTime; // 0x10
        public System.Nullable`1<System.DateTimeOffset> _bootTime; // 0x28

        // ── Methods ──
        public void get_StartupTime(){} // RVA: 0x7FFE82D1D7C0
        public void set_StartupTime(){} // RVA: 0x7FFE82D1D7E0
        public void get_BootTime(){} // RVA: 0x7FFE82DDC4A0
        public void get_PreciseAppStartupTask(){} // RVA: 0x7FFE86F58480
        public void set_PreciseAppStartupTask(){} // RVA: 0x7FFE86F58490
        public void GetId(){} // RVA: 0x7FFE86F584F0
        public void GetCurrentProcessId(){} // RVA: 0x7FFE86F58550
        public void .ctor(){} // RVA: 0x7FFE86F58630
        public void GetStartupTime(){} // RVA: 0x7FFE86F58EC0
        public void ApplicationIsActivated(){} // RVA: 0x7FFE86F59080
        public void GetForegroundWindow(){} // RVA: 0x7FFE86F59450
        public void GetWindowThreadProcessId(){} // RVA: 0x7FFE86F594C0
    }

    public class RandomValuesFactory : Object
    {
        // ── Methods ──
        public void NextInt(){} // RVA: 0x7FFE80E356E0 | overloaded x2
        public void NextDouble(){} // RVA: 0x7FFE80E33FB0
        public void NextBytes(){} // RVA: 0x7FFE80E460A0
        public void NextBool(){} // RVA: 0x7FFE86F59780
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ReadOnlyFileSystem : FileSystemBase
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7FFE810FB320
        public void DeleteDirectory(){} // RVA: 0x7FFE810FB320
        public void CreateFileForWriting(){} // RVA: 0x7FFE86F597E0
        public void WriteAllTextToFile(){} // RVA: 0x7FFE810FB320
        public void MoveFile(){} // RVA: 0x7FFE810FB320
        public void DeleteFile(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ReadWriteFileSystem : FileSystemBase
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7FFE86F59880
        public void DeleteDirectory(){} // RVA: 0x7FFE86F598B0
        public void CreateFileForWriting(){} // RVA: 0x7FFE86F598E0
        public void WriteAllTextToFile(){} // RVA: 0x7FFE86F599C0
        public void MoveFile(){} // RVA: 0x7FFE86F599F0
        public void DeleteFile(){} // RVA: 0x7FFE86F59A60
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class RealStackFrame : Object
    {
        public System.Diagnostics.StackFrame _frame; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Frame(){} // RVA: 0x7FFE81116380
        public void ToString(){} // RVA: 0x7FFE81DE31E0
        public void GetFileColumnNumber(){} // RVA: 0x7FFE815888E0
        public void GetFileLineNumber(){} // RVA: 0x7FFE81588A80
        public void GetFileName(){} // RVA: 0x7FFE81588760
        public void GetILOffset(){} // RVA: 0x7FFE86BADCC0
        public void GetMethod(){} // RVA: 0x7FFE81567090
        public void GetNativeImageBase(){} // RVA: 0x7FFE813240E0
        public void GetNativeIP(){} // RVA: 0x7FFE813240E0
        public void HasNativeImage(){} // RVA: 0x7FFE810FB320
    }

    public class ScopeObserver : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680DC00
        public void AddBreadcrumb(){} // RVA: 0x7FFE86F59B50
        public void AddBreadcrumbImpl(){} // RVA: 0x7FFE80E460A0
        public void SetExtra(){} // RVA: 0x7FFE86F59D60
        public void SetExtraImpl(){} // RVA: 0x7FFE80E4F230
        public void SetTag(){} // RVA: 0x7FFE86F5A0C0
        public void SetTagImpl(){} // RVA: 0x7FFE80E4F230
        public void UnsetTag(){} // RVA: 0x7FFE86F5A2A0
        public void UnsetTagImpl(){} // RVA: 0x7FFE80E460A0
        public void SetUser(){} // RVA: 0x7FFE86F5A440
        public void SetUserImpl(){} // RVA: 0x7FFE80E460A0
        public void UnsetUserImpl(){} // RVA: 0x7FFE80E45FE0
    }

    public class SdkComposer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F5A700
        public void CreateTransport(){} // RVA: 0x7FFE86F5A810
        public void CreateHttpTransport(){} // RVA: 0x7FFE86F5AE60
        public void CreateBackgroundWorker(){} // RVA: 0x7FFE86F5B130
    }

    public class SentryScopeManager : Object
    {
        public Sentry.Internal.ScopeStack.IScopeStackContainer _scopeStackContainer; // 0x10
        public Sentry.SentryOptions _options; // 0x18
        public System.Func`1<System.Collections.Generic.KeyValuePair`2<Sentry.Scope,Sentry.ISentryClient>[]> _newStack; // 0x20
        public object field_3; // 0x32E

        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7FFE81116380
        public void get_ScopeAndClientStack(){} // RVA: 0x7FFE86F5B290
        public void set_ScopeAndClientStack(){} // RVA: 0x7FFE86F5B380
        public void get_NewStack(){} // RVA: 0x7FFE811290C0
        public void get_IsGlobalMode(){} // RVA: 0x7FFE86F5B3E0
        public void .ctor(){} // RVA: 0x7FFE86F5B470
        public void GetCurrent(){} // RVA: 0x7FFE86F5B7D0
        public void ConfigureScope(){} // RVA: 0x7FFE86F5B820
        public void ConfigureScopeAsync(){} // RVA: 0x7FFE86F5B9B0
        public void PushScope(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void RestoreScope(){} // RVA: 0x7FFE86F5BBB0
        public void BindClient(){} // RVA: 0x7FFE86F5C010
        public void Dispose(){} // RVA: 0x7FFE86F5C320
    }

    public class SentryStopwatch : ValueType
    {
        public double StopwatchTicksPerTimeSpanTick;
        public double StopwatchTicksPerNs; // 0x8
        public long _startTimestamp; // 0x10
        public System.DateTimeOffset _startDateTimeOffset; // 0x18

        // ── Methods ──
        public void StartNew(){} // RVA: 0x7FFE86F5C610
        public void get_StartDateTimeOffset(){} // RVA: 0x7FFE82CF9F60
        public void get_CurrentDateTimeOffset(){} // RVA: 0x7FFE86F5C6F0
        public void Diff(){} // RVA: 0x7FFE86F5C7B0
        public void get_Elapsed(){} // RVA: 0x7FFE86F5C800
        public void get_ElapsedNanoseconds(){} // RVA: 0x7FFE86F5C8F0
        public void .cctor(){} // RVA: 0x7FFE86F5C9E0
    }

    public class SerializableExtensions : Object
    {
        // ── Methods ──
        public void SerializeToStringAsync(){} // RVA: 0x7FFE86F5CAA0
        public void SerializeToString(){} // RVA: 0x7FFE86F5CD40
    }

    public class SettingLocator : Object
    {
        public Sentry.SentryOptions _options; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F5DBF0
        public void get_AssemblyForAttributes(){} // RVA: 0x7FFE810FE7C0
        public void set_AssemblyForAttributes(){} // RVA: 0x7FFE81161E80
        public void GetEnvironmentVariable(){} // RVA: 0x7FFE86F5DCB0
        public void GetDsn(){} // RVA: 0x7FFE86F5DCC0
        public void GetEnvironment(){} // RVA: 0x7FFE86F5DE10 | overloaded x2
        public void GetRelease(){} // RVA: 0x7FFE86F5DF40
    }

    public class Signal : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F5E130
        public void Release(){} // RVA: 0x7FFE86F5E290
        public void WaitAsync(){} // RVA: 0x7FFE86F5E430
        public void Dispose(){} // RVA: 0x7FFE86F5E460
    }

    public class StringOrRegex : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE86F5E510 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE86F5E5A0
        public void Equals(){} // RVA: 0x7FFE86F5E610
        public void GetHashCode(){} // RVA: 0x7FFE82C46B00
    }

    public class StringOrRegexExtensions : Object
    {
        // ── Methods ──
        public void MatchesAny(){} // RVA: 0x7FFE86F5E710
    }

    public class SynchronizedRandomValuesFactory : RandomValuesFactory
    {
        public System.Threading.AsyncLocal`1<System.Random> LocalRandom;

        // ── Methods ──
        public void get_Random(){} // RVA: 0x7FFE86F5E910
        public void NextInt(){} // RVA: 0x7FFE86F5EAB0 | overloaded x2
        public void NextDouble(){} // RVA: 0x7FFE86F5EB30
        public void NextBytes(){} // RVA: 0x7FFE86F5EBA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86F5EC10
    }

    public class TcpPing : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F5ECD0
        public void IsAvailableAsync(){} // RVA: 0x7FFE86F5EF00
    }

    public class ThreadPoolInfo : Object
    {
        public int _minWorkerThreads; // 0x10
        public int _minCompletionPortThreads; // 0x14
        public int _maxWorkerThreads; // 0x18
        public int _maxCompletionPortThreads; // 0x1C
        public int _availableWorkerThreads; // 0x20
        public int _availableCompletionPortThreads; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F5F590
        public void get_MinWorkerThreads(){} // RVA: 0x7FFE811485C0
        public void get_MinCompletionPortThreads(){} // RVA: 0x7FFE8164B230
        public void get_MaxWorkerThreads(){} // RVA: 0x7FFE813DB630
        public void get_MaxCompletionPortThreads(){} // RVA: 0x7FFE82707EE0
        public void get_AvailableWorkerThreads(){} // RVA: 0x7FFE8151D690
        public void get_AvailableCompletionPortThreads(){} // RVA: 0x7FFE81A56130
        public void WriteTo(){} // RVA: 0x7FFE86F5F5C0
    }

    public class ThreadsafeCounterDictionary`1 : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<T,CounterItem<T>> _items;
        public object field_1; // 0x340
        public object field_2; // 0x341
        public object field_3; // 0x342

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Increment(){} // RVA: 0x7FFE810A1420
        public void ReadAndReset(){} // RVA: 0x7FFE810A1420
        public void ReadAllAndReset(){} // RVA: 0x7FFE80E2E2E0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

}