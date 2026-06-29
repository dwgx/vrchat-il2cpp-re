// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal
// Classes: 78
// Methods: 607

namespace ThirdParty.Sentry.Sentry.Internal
{
    public class AotHelper : Object
    {
        public object SuppressionJustification;
        public object _isTrimmed;
        public object IsNativeAot;

        // ── Methods ──
        public void get_IsTrimmed(){} // RVA: 0x6E68BF0
        public void .cctor(){} // RVA: 0x6E68C50
    }

    public class AppDomainAdapter : Object
    {
        public object _instance;
        public object UnhandledException;
        public object ProcessExit;
        public object UnobservedTaskException;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6E68D00
        public void .ctor(){} // RVA: 0x6E68D60
        public void add_UnhandledException(){} // RVA: 0x6E68F60
        public void remove_UnhandledException(){} // RVA: 0x6E69050
        public void add_ProcessExit(){} // RVA: 0x6E69140
        public void remove_ProcessExit(){} // RVA: 0x6E69230
        public void add_UnobservedTaskException(){} // RVA: 0x6E69320
        public void remove_UnobservedTaskException(){} // RVA: 0x6E69430
        public void OnProcessExit(){} // RVA: 0x59516C0
        public void OnUnhandledException(){} // RVA: 0x6E69540
        public void OnUnobservedTaskException(){} // RVA: 0x6E69560
        public void .cctor(){} // RVA: 0x6E69580
    }

    public class ApplicationVersionLocator : Object
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x6E69630
    }

    public class AutoClearingList`1 : Object
    {
        public object _list;
        public object _clearOnNextAdd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x899250
        public void Add(){} // RVA: 0xA94080
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void Remove(){} // RVA: 0xA94080
        public void get_Count(){} // RVA: 0x87C130
        public void get_IsReadOnly(){} // RVA: 0x87D280
        public void IndexOf(){} // RVA: 0xA94080
        public void Insert(){} // RVA: 0xA94080
        public void RemoveAt(){} // RVA: 0x8944F0
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
    }

    public class AutoClearingList`1 : Object
    {
        public object _list;
        public object _clearOnNextAdd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x609BA00
        public void Add(){} // RVA: 0x609BB10
        public void GetEnumerator(){} // RVA: 0x3DD7DA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x609BBE0
        public void Clear(){} // RVA: 0x609BC30
        public void Contains(){} // RVA: 0x609BC80
        public void CopyTo(){} // RVA: 0x609BCE0
        public void Remove(){} // RVA: 0x609BD50
        public void get_Count(){} // RVA: 0x42066B0
        public void get_IsReadOnly(){} // RVA: 0x609BDB0
        public void IndexOf(){} // RVA: 0x609BE00
        public void Insert(){} // RVA: 0x609BE60
        public void RemoveAt(){} // RVA: 0x609BF40
        public void get_Item(){} // RVA: 0x609BFA0
        public void set_Item(){} // RVA: 0x609C000
    }

    public class BackgroundWorker : Object
    {
        public object _transport;
        public object _options;
        public object _queue;
        public object _maxItems;
        public object _shutdownSource;
        public object _queuedEnvelopeSemaphore;
        public object _disposed;
        public object _currentItems;
        public object OnFlushObjectReceived;
        public object _workerTask;

        // ── Methods ──
        public void add_OnFlushObjectReceived(){} // RVA: 0x6E697F0
        public void remove_OnFlushObjectReceived(){} // RVA: 0x6E698E0
        public void get_WorkerTask(){} // RVA: 0xBE58B0
        public void get_QueuedItems(){} // RVA: 0x6E699D0
        public void .ctor(){} // RVA: 0x6E69A20
        public void EnqueueEnvelope(){} // RVA: 0x6E69ED0
        public void ProcessQueuedItems(){} // RVA: 0x6E6A240
        public void DoWorkAsync(){} // RVA: 0x6E6A260
        public void FlushAsync(){} // RVA: 0x6E6A430
        public void DoFlushAsync(){} // RVA: 0x6E6A610
        public void SendFinalClientReportAsync(){} // RVA: 0x6E6A830
        public void Dispose(){} // RVA: 0x6E6AA40
    }

    public class ClientReport : Object
    {
        public object _timestamp;
        public object _discardedEvents;

        // ── Methods ──
        public void get_Timestamp(){} // RVA: 0x22343B0
        public void get_DiscardedEvents(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0x4F35120
        public void WriteTo(){} // RVA: 0x6E6EF90
        public void FromJson(){} // RVA: 0x6E6FCB0
    }

    public class ClientReportRecorder : Object
    {
        public object _options;
        public object _clock;
        public object _discardedEvents;

        // ── Methods ──
        public void get_DiscardedEvents(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0x6E70EA0
        public void RecordDiscardedEvent(){} // RVA: 0x6E71190
        public void GenerateClientReport(){} // RVA: 0x6E71310
        public void Load(){} // RVA: 0x6E715C0
    }

    public class ConcurrentQueueLite`1 : Object
    {
        public object _queue;

        // ── Methods ──
        public void Enqueue(){} // RVA: 0xA94080
        public void TryDequeue(){} // RVA: 0x87D350
        public void get_Count(){} // RVA: 0x87C130
        public void get_IsEmpty(){} // RVA: 0x87D280
        public void Clear(){} // RVA: 0x894290
        public void TryPeek(){} // RVA: 0x87D350
        public void ToArray(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894290
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x6E71970
        public void WriteScope(){} // RVA: 0x89EAF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DataCategory : ValueType
    {
        public object Attachment;
        public object Default;
        public object Error;
        public object Internal;
        public object Security;
        public object Session;
        public object Span;
        public object Transaction;
        public object Profile;
        public object _value;

        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x77900
        public void .ctor(){} // RVA: 0x47F10
        public void CompareTo(){} // RVA: 0x8F6B30
        public void Equals(){} // RVA: 0x8F6C20
        public void GetHashCode(){} // RVA: 0x8F6C30
        public void ToString(){} // RVA: 0x77900
        public void .cctor(){} // RVA: 0x6E72A80
    }

    public class DebugStackTrace : SentryStackTrace
    {
        public object _options;
        public object _debugImageIndexByModule;
        public object DebugImageMissing;
        public object _debugImagesMerged;
        public object RegexAsyncFunctionName;
        public object RegexAnonymousFunction;
        public object RegexAsyncReturn;
        public object RegexNativeAOTInfo;
        public object _debugImages;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E732A0
        public void get_DebugImages(){} // RVA: 0xD05CA0
        public void Create(){} // RVA: 0x6E735D0
        public void MergeDebugImagesInto(){} // RVA: 0x6E73B60
        public void CreateFrames(){} // RVA: 0x6E74490
        public void TryCreateManagedFrame(){} // RVA: 0x6E74610
        public void CreateFrame(){} // RVA: 0x6E74D70
        public void GetRelativeAddressMode(){} // RVA: 0x6E74F70
        public void DemangleAsyncFunctionName(){} // RVA: 0x6E75000
        public void DemangleAnonymousFunction(){} // RVA: 0x6E75280
        public void DemangleLambdaReturnType(){} // RVA: 0x6E75450
        public void TryReadAssemblyFromDisk(){} // RVA: 0x6E75600
        public void AddManagedModuleDebugImage(){} // RVA: 0x6E75830
        public void GetManagedModuleDebugImage(){} // RVA: 0x6E75A60
        public void .cctor(){} // RVA: 0x6E75EE0
    }

    public class DelegateEventProcessor : Object
    {
        public object _func;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Process(){} // RVA: 0x31D2090
    }

    public class DelegateTransactionProcessor : Object
    {
        public object _func;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Process(){} // RVA: 0x31D2090
    }

    public class DelimitedPrefixOrPatternMatcher : Object
    {
        public object <delimiter>P;
        public object <comparison>P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E76F00
        public void IsMatch(){} // RVA: 0x6E76F10
    }

    public class DiscardReason : ValueType
    {
        public object BeforeSend;
        public object CacheOverflow;
        public object EventProcessor;
        public object NetworkError;
        public object QueueOverflow;
        public object RateLimitBackoff;
        public object SampleRate;
        public object _value;

        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x77900
        public void .ctor(){} // RVA: 0x47F10
        public void WithCategory(){} // RVA: 0x8F6C60
        public void CompareTo(){} // RVA: 0x8F6D30
        public void Equals(){} // RVA: 0x8F6E20
        public void GetHashCode(){} // RVA: 0x8F6C30
        public void ToString(){} // RVA: 0x77900
        public void .cctor(){} // RVA: 0x6E77400
    }

    public class DiscardReasonWithCategory : ValueType
    {
        public object _reason;
        public object _category;

        // ── Methods ──
        public void get_Reason(){} // RVA: 0x77900
        public void get_Category(){} // RVA: 0x77ED0
        public void .ctor(){} // RVA: 0x6D3E60
        public void CompareTo(){} // RVA: 0x8F70D0
        public void Equals(){} // RVA: 0x8F71D0
        public void GetHashCode(){} // RVA: 0x8F71E0
        public void ToString(){} // RVA: 0x8F71F0
    }

    public class Disposable : Object
    {
        public object _dispose;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Dispose(){} // RVA: 0x1B68170
        public void Create(){} // RVA: 0x6E78090
    }

    public class DuplicateEventDetectionEventProcessor : Object
    {
        public object _options;
        public object _capturedObjects;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E78120
        public void Process(){} // RVA: 0x6E78240
        public void IsDuplicate(){} // RVA: 0x6E783F0
    }

    public class Enricher : Object
    {
        public object DefaultIpAddress;
        public object _options;
        public object _runtimeLazy;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E78810
        public void Apply(){} // RVA: 0x6E79300
    }

    public class ExceptionHandlingSynchronizationContext : SynchronizationContext
    {
        public object <exceptionHandler>P;
        public object <innerContext>P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E796B0
        public void Post(){} // RVA: 0x6E79760
    }

    public class ExceptionTypeFilter`1 : Object
    {
        public object _filteredType;

        // ── Methods ──
        public void Filter(){} // RVA: 0x87D350
        public void .ctor(){} // RVA: 0x894290
    }

    public class FileSystemBase : Object
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x6E79A20
        public void DirectoryExists(){} // RVA: 0x6E79AB0
        public void FileExists(){} // RVA: 0x6E79AC0
        public void GetFileCreationTime(){} // RVA: 0x6E79AD0
        public void ReadAllTextFromFile(){} // RVA: 0x6E79C40
        public void OpenFileForReading(){} // RVA: 0x6E79D20
        public void CreateDirectory(){} // RVA: 0x87D350
        public void DeleteDirectory(){} // RVA: 0x87F360
        public void CreateFileForWriting(){} // RVA: 0x87D3C0
        public void WriteAllTextToFile(){} // RVA: 0x87D3C0
        public void MoveFile(){} // RVA: 0x880830
        public void DeleteFile(){} // RVA: 0x87D350
        public void .ctor(){} // RVA: 0xB43310
    }

    public class GrowableArray`1 : ValueType
    {
        public object array;
        public object arrayLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8944F0
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void get_Count(){} // RVA: 0x87C130
        public void Reserve(){} // RVA: 0x8944F0
        public void Clear(){} // RVA: 0x894290
        public void Add(){} // RVA: 0xA94080
        public void AddRange(){} // RVA: 0x894320
        public void Insert(){} // RVA: 0xA94080
        public void RemoveRange(){} // RVA: 0x8965E0
        public void get_Empty(){} // RVA: 0x87D280
        public void Trim(){} // RVA: 0x8944F0
        public void get_EmptyCapacity(){} // RVA: 0x87D280
        public void ToString(){} // RVA: 0x87C0A0
        public void Foreach(){} // RVA: 0xA94080
        public void Search(){} // RVA: 0xA94080
        public void get_UnderlyingArray(){} // RVA: 0x87C0A0
        public void Realloc(){} // RVA: 0x8944F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void GetEnumerator(){} // RVA: 0x87C0A0
    }

    public class GrowableArray`1 : ValueType
    {
        public object array;
        public object arrayLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x310440
        public void get_Item(){} // RVA: 0x310450
        public void set_Item(){} // RVA: 0x310480
        public void get_Count(){} // RVA: 0x14790
        public void Reserve(){} // RVA: 0x30FD70
        public void Clear(){} // RVA: 0x30FDC0
        public void Add(){} // RVA: 0x3104A0
        public void AddRange(){} // RVA: 0x3104B0
        public void Insert(){} // RVA: 0x3104C0
        public void RemoveRange(){} // RVA: 0x3104D0
        public void get_Empty(){} // RVA: 0x30FFC0
        public void Trim(){} // RVA: 0x30FFD0
        public void get_EmptyCapacity(){} // RVA: 0x88E70
        public void ToString(){} // RVA: 0x310660
        public void Foreach(){} // RVA: 0xA94080
        public void Search(){} // RVA: 0xA94080
        public void get_UnderlyingArray(){} // RVA: 0x77900
        public void Realloc(){} // RVA: 0x30FFF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x310000
        public void GetEnumerator(){} // RVA: 0x310000
    }

    public class GrowableArray`1 : ValueType
    {
        public object array;
        public object arrayLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x310440
        public void get_Item(){} // RVA: 0x310450
        public void set_Item(){} // RVA: 0x310480
        public void get_Count(){} // RVA: 0x14790
        public void Reserve(){} // RVA: 0x30FD70
        public void Clear(){} // RVA: 0x30FDC0
        public void Add(){} // RVA: 0x3104A0
        public void AddRange(){} // RVA: 0x3104B0
        public void Insert(){} // RVA: 0x3104C0
        public void RemoveRange(){} // RVA: 0x3104D0
        public void get_Empty(){} // RVA: 0x30FFC0
        public void Trim(){} // RVA: 0x30FFD0
        public void get_EmptyCapacity(){} // RVA: 0x88E70
        public void ToString(){} // RVA: 0x310660
        public void Foreach(){} // RVA: 0xA94080
        public void Search(){} // RVA: 0xA94080
        public void get_UnderlyingArray(){} // RVA: 0x77900
        public void Realloc(){} // RVA: 0x30FFF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x310000
        public void GetEnumerator(){} // RVA: 0x310000
    }

    public class GrowableArray`1 : ValueType
    {
        public object array;
        public object arrayLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x30FC90
        public void get_Item(){} // RVA: 0x30FCA0
        public void set_Item(){} // RVA: 0x30FCE0
        public void get_Count(){} // RVA: 0x14790
        public void Reserve(){} // RVA: 0x30FD70
        public void Clear(){} // RVA: 0x30FDC0
        public void Add(){} // RVA: 0x30FDD0
        public void AddRange(){} // RVA: 0x30FDF0
        public void Insert(){} // RVA: 0x30FE00
        public void RemoveRange(){} // RVA: 0x30FE20
        public void get_Empty(){} // RVA: 0x30FFC0
        public void Trim(){} // RVA: 0x30FFD0
        public void get_EmptyCapacity(){} // RVA: 0x88E70
        public void ToString(){} // RVA: 0x30FFE0
        public void Foreach(){} // RVA: 0xA94080
        public void Search(){} // RVA: 0xA94080
        public void get_UnderlyingArray(){} // RVA: 0x77900
        public void Realloc(){} // RVA: 0x30FFF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x310000
        public void GetEnumerator(){} // RVA: 0x310000
    }

    public class GrowableArray`1 : ValueType
    {
        public object array;
        public object arrayLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3100E0
        public void get_Item(){} // RVA: 0x310190
        public void set_Item(){} // RVA: 0x3101C0
        public void get_Count(){} // RVA: 0x14790
        public void Reserve(){} // RVA: 0x30FD70
        public void Clear(){} // RVA: 0x30FDC0
        public void Add(){} // RVA: 0x3101F0
        public void AddRange(){} // RVA: 0x310200
        public void Insert(){} // RVA: 0x310210
        public void RemoveRange(){} // RVA: 0x310320
        public void get_Empty(){} // RVA: 0x30FFC0
        public void Trim(){} // RVA: 0x30FFD0
        public void get_EmptyCapacity(){} // RVA: 0x88E70
        public void ToString(){} // RVA: 0x310420
        public void Foreach(){} // RVA: 0xA94080
        public void Search(){} // RVA: 0xA94080
        public void get_UnderlyingArray(){} // RVA: 0x77900
        public void Realloc(){} // RVA: 0x30FFF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x310000
        public void GetEnumerator(){} // RVA: 0x310430
    }

    public class HashableGrowableArray`1 : ValueType
    {
        public object _items;
        public object _hashCode;
        public object _sealed;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8944F0
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void get_Count(){} // RVA: 0x87C130
        public void Seal(){} // RVA: 0x894290
        public void Trim(){} // RVA: 0x8944F0
        public void Add(){} // RVA: 0xA94080
        public void GetHashCode(){} // RVA: 0x87C130
        public void Equals(){} // RVA: 0x87D350
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    }

    public class Hub : Object
    {
        public object _sessionPauseLock;
        public object _clock;
        public object _sessionManager;
        public object _options;
        public object _randomValuesFactory;
        public object _isPersistedSessionRecovered;
        public object _exceptionToSpanMap;
        public object _scopeManager;
        public object _metrics;
        public object _isEnabled;

        // ── Methods ──
        public void get_ExceptionToSpanMap(){} // RVA: 0xBC1B30
        public void get_ScopeManager(){} // RVA: 0xBBF8F0
        public void get_Metrics(){} // RVA: 0xBE58B0
        public void get_IsEnabled(){} // RVA: 0x6E79D30
        public void get_Options(){} // RVA: 0xB70160
        public void get_CurrentScope(){} // RVA: 0x6E79D40
        public void get_CurrentClient(){} // RVA: 0x6E79E10
        public void .ctor(){} // RVA: 0x6E79EE0
        public void ConfigureScope(){} // RVA: 0x6E7A970
        public void ConfigureScopeAsync(){} // RVA: 0x6E7AA30
        public void PushScope(){} // RVA: 0xA94080
        public void RestoreScope(){} // RVA: 0x6E7AC90
        public void BindClient(){} // RVA: 0x6E7AD60
        public void StartTransaction(){} // RVA: 0x6E7ADE0
        public void BindException(){} // RVA: 0x6E7B3D0
        public void GetSpan(){} // RVA: 0x6E7B560
        public void GetTraceHeader(){} // RVA: 0x6E7B590
        public void GetBaggage(){} // RVA: 0x6E7B660
        public void ContinueTrace(){} // RVA: 0x6E7B8C0
        public void StartSession(){} // RVA: 0x6E7BC30
        public void PauseSession(){} // RVA: 0x6E7BDB0
        public void ResumeSession(){} // RVA: 0x6E7BF90
        public void EndSession(){} // RVA: 0x6E7C4A0
        public void GetLinkedSpan(){} // RVA: 0x6E7C520
        public void ApplyTraceContextToEvent(){} // RVA: 0x6E7C8A0
        public void CaptureEnvelope(){} // RVA: 0x6E7CA90
        public void AddBreadcrumbForException(){} // RVA: 0x6E7CB00
        public void CaptureEvent(){} // RVA: 0x6E7D050
        public void CaptureUserFeedback(){} // RVA: 0x6E7D480
        public void CaptureTransaction(){} // RVA: 0x6E7D5D0
        public void CaptureMetrics(){} // RVA: 0x6E7D6D0
        public void CaptureCodeLocations(){} // RVA: 0x6E7DA90
        public void StartSpan(){} // RVA: 0x6E7DD50
        public void CaptureSession(){} // RVA: 0x6E7DF00
        public void CaptureCheckIn(){} // RVA: 0x6E7E030
        public void FlushAsync(){} // RVA: 0x6E7E2B0
        public void Dispose(){} // RVA: 0x6E7E480
        public void get_LastEventId(){} // RVA: 0x6E7E630
    }

    public class IAppDomain
    {
        // ── Methods ──
        public void add_UnhandledException(){} // RVA: 0x894320
        public void remove_UnhandledException(){} // RVA: 0x894320
        public void add_ProcessExit(){} // RVA: 0x894320
        public void remove_ProcessExit(){} // RVA: 0x894320
        public void add_UnobservedTaskException(){} // RVA: 0x894320
        public void remove_UnobservedTaskException(){} // RVA: 0x894320
    }

    public class IClientReportRecorder
    {
        // ── Methods ──
        public void RecordDiscardedEvent(){} // RVA: 0x895920
        public void GenerateClientReport(){} // RVA: 0x87C0A0
        public void Load(){} // RVA: 0x894320
    }

    public class ICloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0xA94080
    }

    public class IEnumeration
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x87C0A0
    }

    public class IFileSystem
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x88E290
        public void DirectoryExists(){} // RVA: 0x87D350
        public void FileExists(){} // RVA: 0x87D350
        public void GetFileCreationTime(){} // RVA: 0x87BF80
        public void ReadAllTextFromFile(){} // RVA: 0x87C540
        public void OpenFileForReading(){} // RVA: 0x87C540
        public void CreateDirectory(){} // RVA: 0x87D350
        public void DeleteDirectory(){} // RVA: 0x87F360
        public void CreateFileForWriting(){} // RVA: 0x87D3C0
        public void WriteAllTextToFile(){} // RVA: 0x87D3C0
        public void MoveFile(){} // RVA: 0x880830
        public void DeleteFile(){} // RVA: 0x87D350
    }

    public class IInternalScopeManager
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x87BEB0
        public void RestoreScope(){} // RVA: 0x894320
        public void get_ScopeStackContainer(){} // RVA: 0x87C0A0
    }

    public class IPing
    {
        // ── Methods ──
        public void IsAvailableAsync(){} // RVA: 0x881D60
    }

    public class IStackFrame
    {
        // ── Methods ──
        public void get_Frame(){} // RVA: 0x87C0A0
        public void GetNativeImageBase(){} // RVA: 0x87C0A0
        public void GetNativeIP(){} // RVA: 0x87C0A0
        public void HasNativeImage(){} // RVA: 0x87D280
        public void GetFileColumnNumber(){} // RVA: 0x87C130
        public void GetFileLineNumber(){} // RVA: 0x87C130
        public void GetFileName(){} // RVA: 0x87C0A0
        public void GetILOffset(){} // RVA: 0x87C130
        public void GetMethod(){} // RVA: 0x87C0A0
        public void ToString(){} // RVA: 0x87C0A0
    }

    public class IStringOrRegexMatcher
    {
        // ── Methods ──
        public void IsMatch(){} // RVA: 0x87D3C0
    }

    public class ITransactionProfiler
    {
        // ── Methods ──
        public void Finish(){} // RVA: 0x894290
        public void Collect(){} // RVA: 0x87C540
    }

    public class ITransactionProfilerFactory
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x881FC0
    }

    public class IUpdatable
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x894320
    }

    public class IUpdatable`1
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0xA94080
    }

    public class InstallationIdHelper : Object
    {
        public object <options>P;
        public object _installationIdLock;
        public object _installationId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E7EF30
        public void TryGetInstallationId(){} // RVA: 0x6E7F030
        public void TryGetPersistentInstallationId(){} // RVA: 0x6E7F3C0
        public void TryGetHardwareInstallationId(){} // RVA: 0x6E7FA10
        public void GetMachineNameInstallationId(){} // RVA: 0x6E7FE60
    }

    public class Json : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0xA94080
        public void Load(){} // RVA: 0xA94080
    }

    public class Lock : Object
    {
        public object _signal;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E7FFD0
        public void AcquireAsync(){} // RVA: 0x6E80070
        public void Dispose(){} // RVA: 0x6E80260
    }

    public class MainExceptionProcessor : Object
    {
        public object ExceptionDataKeyPrefix;
        public object ExceptionDataTagKey;
        public object ExceptionDataContextKey;
        public object _options;
        public object _sentryStackTraceFactoryAccessor;

        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void Process(){} // RVA: 0x6E806B0
        public void CreateSentryExceptions(){} // RVA: 0x6E807D0
        public void WalkExceptions(){} // RVA: 0x6E80A20
        public void MoveExceptionDataToEvent(){} // RVA: 0x6E80C00
        public void BuildSentryException(){} // RVA: 0x6E816B0
        public void GetMechanism(){} // RVA: 0x6E81A50
    }

    public class MainSentryEventProcessor : Object
    {
        public object CultureInfoKey;
        public object CurrentUiCultureKey;
        public object MemoryInfoKey;
        public object ThreadPoolInfoKey;
        public object IsDynamicCodeKey;
        public object IsDynamicCodeCompiledKey;
        public object IsDynamicCodeSupportedKey;
        public object _enricher;
        public object _options;
        public object _sentryStackTraceFactoryAccessor;

        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0xB700F0
        public void get_Release(){} // RVA: 0x6E830C0
        public void get_Distribution(){} // RVA: 0x6E830F0
        public void .ctor(){} // RVA: 0x6E83110
        public void Process(){} // RVA: 0x6E83290
        public void AddMemoryInfo(){} // RVA: 0xB43310
        public void AddThreadPoolInfo(){} // RVA: 0x6E84310
        public void CultureInfoToDictionary(){} // RVA: 0x6E84470
    }

    public class ModuleExtensions : Object
    {
        public object UnknownLocation;

        // ── Methods ──
        public void GetNameOrScopeName(){} // RVA: 0x6E84890
    }

    public class NoOpSpan : Object
    {
        public object _instance;
        public object _origin;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6E84980
        public void .ctor(){} // RVA: 0xB43310
        public void get_SpanId(){} // RVA: 0x6E849E0
        public void get_ParentSpanId(){} // RVA: 0x6E84A40
        public void get_TraceId(){} // RVA: 0x6E84AC0
        public void get_IsSampled(){} // RVA: 0xDAC980
        public void get_Tags(){} // RVA: 0x6E84B20
        public void get_Extra(){} // RVA: 0x6E84B80
        public void get_StartTimestamp(){} // RVA: 0x1DF4930
        public void get_EndTimestamp(){} // RVA: 0x49DF8B0
        public void get_IsFinished(){} // RVA: 0xB43320
        public void get_Operation(){} // RVA: 0x1584680
        public void set_Operation(){} // RVA: 0xB43310
        public void get_Description(){} // RVA: 0xDAC980
        public void set_Description(){} // RVA: 0xB43310
        public void get_Status(){} // RVA: 0xDAC980
        public void set_Status(){} // RVA: 0xB43310
        public void StartChild(){} // RVA: 0x2303260
        public void Finish(){} // RVA: 0xB43310
        public void SetTag(){} // RVA: 0xB43310
        public void UnsetTag(){} // RVA: 0xB43310
        public void SetExtra(){} // RVA: 0xB43310
        public void GetTraceHeader(){} // RVA: 0x6E84BE0
        public void get_Measurements(){} // RVA: 0x6E84C40
        public void SetMeasurement(){} // RVA: 0xB43310
        public void get_Origin(){} // RVA: 0xB5DBF0
        public void set_Origin(){} // RVA: 0xB44D60
        public void .cctor(){} // RVA: 0x6E84CA0
    }

    public class NoOpTransaction : NoOpSpan
    {
        public object _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6E84D40
        public void .ctor(){} // RVA: 0x6E84DA0
        public void get_Sdk(){} // RVA: 0x6E84DF0
        public void get_Name(){} // RVA: 0x1584680
        public void set_Name(){} // RVA: 0xB43310
        public void get_IsParentSampled(){} // RVA: 0xDAC980
        public void set_IsParentSampled(){} // RVA: 0xB43310
        public void get_NameSource(){} // RVA: 0xDAC980
        public void get_Distribution(){} // RVA: 0x1584680
        public void set_Distribution(){} // RVA: 0xB43310
        public void get_Level(){} // RVA: 0xDAC980
        public void set_Level(){} // RVA: 0xB43310
        public void get_Request(){} // RVA: 0x6E84E40
        public void set_Request(){} // RVA: 0xB43310
        public void get_Contexts(){} // RVA: 0x6E84E80
        public void set_Contexts(){} // RVA: 0xB43310
        public void get_User(){} // RVA: 0x6E84ED0
        public void set_User(){} // RVA: 0xB43310
        public void get_Platform(){} // RVA: 0xDAC980
        public void set_Platform(){} // RVA: 0xB43310
        public void get_Release(){} // RVA: 0xDAC980
        public void set_Release(){} // RVA: 0xB43310
        public void get_Environment(){} // RVA: 0xDAC980
        public void set_Environment(){} // RVA: 0xB43310
        public void get_TransactionName(){} // RVA: 0xDAC980
        public void set_TransactionName(){} // RVA: 0xB43310
        public void get_Fingerprint(){} // RVA: 0x6E84F10
        public void set_Fingerprint(){} // RVA: 0xB43310
        public void get_Spans(){} // RVA: 0x6E84F70
        public void get_Breadcrumbs(){} // RVA: 0x6E84FD0
        public void GetLastActiveSpan(){} // RVA: 0xDAC980
        public void AddBreadcrumb(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6E85030
    }

    public class ObjectExtensions : Object
    {
        public object _map;

        // ── Methods ──
        public void get_Map(){} // RVA: 0x6E85110
        public void AssociatedProperties(){} // RVA: 0x6E85170
        public void SetFused(){} // RVA: 0xA94080
        public void GetFused(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x6E85410
    }

    public class OriginHelper : Object
    {
        public object Manual;
        public object ValidOriginPattern;
        public object ValidOrigin;

        // ── Methods ──
        public void IsValidOrigin(){} // RVA: 0x6E855F0
        public void TryParse(){} // RVA: 0x6E856A0
        public void SetOrigin(){} // RVA: 0x6E85700
        public void .cctor(){} // RVA: 0x6E858D0
    }

    public class PartialStream : Stream
    {
        public object _innerStream;
        public object _offset;
        public object _length;
        public object _position;

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x6E859B0
        public void get_CanSeek(){} // RVA: 0x6E859E0
        public void get_CanWrite(){} // RVA: 0xB43320
        public void get_Length(){} // RVA: 0x6E85A10
        public void get_Position(){} // RVA: 0xBBF8F0
        public void set_Position(){} // RVA: 0x6E85AA0
        public void .ctor(){} // RVA: 0x6E85B50
        public void ReadAsync(){} // RVA: 0x6E85C20
        public void Seek(){} // RVA: 0x6E85EB0
        public void Read(){} // RVA: 0x6E85FE0
        public void SetLength(){} // RVA: 0x6E86150
        public void Write(){} // RVA: 0x6E86190
        public void Flush(){} // RVA: 0x6E861D0
    }

    public class PiiExtensions : Object
    {
        public object RedactedText;
        public object AuthRegex;
        public object UserInfoMatcher;

        // ── Methods ──
        public void RedactUrl(){} // RVA: 0x6E866E0
        public void RedactAuth(){} // RVA: 0x6E86950
        public void .cctor(){} // RVA: 0x6E86C20
    }

    public class PollingNetworkStatusListener : Object
    {
        public object _options;
        public object _testPing;
        public object _delayInMilliseconds;
        public object _maxDelayInMilliseconds;
        public object _backoffFunction;
        public object _online;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E87140
        public void get_LazyPing(){} // RVA: 0x6E87370
        public void get_Ping(){} // RVA: 0x6E87450
        public void get_Online(){} // RVA: 0x6E87560
        public void set_Online(){} // RVA: 0x6E87570
        public void WaitForNetworkOnlineAsync(){} // RVA: 0x6E87580
        public void <get_LazyPing>b__8_0(){} // RVA: 0x6E87790
    }

    public class PooledBuffer`1 : ValueType
    {
        public object _array;

        // ── Methods ──
        public void get_Array(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x8944F0
        public void Dispose(){} // RVA: 0x894290
    }

    public class PooledBuffer`1 : ValueType
    {
        public object _array;

        // ── Methods ──
        public void get_Array(){} // RVA: 0x77900
        public void .ctor(){} // RVA: 0x47BC90
        public void Dispose(){} // RVA: 0x47BCA0
    }

    public class PrefixOrPatternMatcher : Object
    {
        public object <comparison>P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void IsMatch(){} // RVA: 0x6E88170
    }

    public class ProcessInfo : Object
    {
        public object Instance;
        public object _startupTime;
        public object _bootTime;
        public object _preciseAppStartupTask;
        public object _id;

        // ── Methods ──
        public void get_StartupTime(){} // RVA: 0x2817240
        public void set_StartupTime(){} // RVA: 0x2817210
        public void get_BootTime(){} // RVA: 0x28D53F0
        public void get_PreciseAppStartupTask(){} // RVA: 0x6E882E0
        public void set_PreciseAppStartupTask(){} // RVA: 0x6E882F0
        public void GetId(){} // RVA: 0x6E88350
        public void GetCurrentProcessId(){} // RVA: 0x6E883B0
        public void .ctor(){} // RVA: 0x6E884A0
        public void GetStartupTime(){} // RVA: 0x6E88D20
        public void ApplicationIsActivated(){} // RVA: 0x6E88EE0
        public void GetForegroundWindow(){} // RVA: 0x6E892A0
        public void GetWindowThreadProcessId(){} // RVA: 0x6E89310
    }

    public class RandomValuesFactory : Object
    {
        // ── Methods ──
        public void NextInt(){} // RVA: 0x8830B0
        public void NextDouble(){} // RVA: 0x8820E0
        public void NextBytes(){} // RVA: 0x894320
        public void NextBool(){} // RVA: 0x6E895D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReadOnlyFileSystem : FileSystemBase
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0xB43320
        public void DeleteDirectory(){} // RVA: 0xB43320
        public void CreateFileForWriting(){} // RVA: 0x6E89630
        public void WriteAllTextToFile(){} // RVA: 0xB43320
        public void MoveFile(){} // RVA: 0xB43320
        public void DeleteFile(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ReadWriteFileSystem : FileSystemBase
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x6E896D0
        public void DeleteDirectory(){} // RVA: 0x6E89700
        public void CreateFileForWriting(){} // RVA: 0x6E89730
        public void WriteAllTextToFile(){} // RVA: 0x6E89810
        public void MoveFile(){} // RVA: 0x6E89840
        public void DeleteFile(){} // RVA: 0x6E898B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class RealStackFrame : Object
    {
        public object _frame;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Frame(){} // RVA: 0xB5DBF0
        public void ToString(){} // RVA: 0x1910690
        public void GetFileColumnNumber(){} // RVA: 0x10ACB60
        public void GetFileLineNumber(){} // RVA: 0x10AD380
        public void GetFileName(){} // RVA: 0x10AD460
        public void GetILOffset(){} // RVA: 0x6AE07D0
        public void GetMethod(){} // RVA: 0x1085C80
        public void GetNativeImageBase(){} // RVA: 0xDAC980
        public void GetNativeIP(){} // RVA: 0xDAC980
        public void HasNativeImage(){} // RVA: 0xB43320
    }

    public class ScopeObserver : Object
    {
        public object _options;
        public object _name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x67462E0
        public void AddBreadcrumb(){} // RVA: 0x6E899A0
        public void AddBreadcrumbImpl(){} // RVA: 0x894320
        public void SetExtra(){} // RVA: 0x6E89BB0
        public void SetExtraImpl(){} // RVA: 0x8943B0
        public void SetTag(){} // RVA: 0x6E89F10
        public void SetTagImpl(){} // RVA: 0x8943B0
        public void UnsetTag(){} // RVA: 0x6E8A0F0
        public void UnsetTagImpl(){} // RVA: 0x894320
        public void SetUser(){} // RVA: 0x6E8A290
        public void SetUserImpl(){} // RVA: 0x894320
        public void UnsetUserImpl(){} // RVA: 0x894290
    }

    public class SdkComposer : Object
    {
        public object _options;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E8A550
        public void CreateTransport(){} // RVA: 0x6E8A660
        public void CreateHttpTransport(){} // RVA: 0x6E8AD00
        public void CreateBackgroundWorker(){} // RVA: 0x6E8AFD0
    }

    public class SentryScopeManager : Object
    {
        public object _scopeStackContainer;
        public object _options;
        public object _newStack;

        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0xB5DBF0
        public void get_ScopeAndClientStack(){} // RVA: 0x6E8B130
        public void set_ScopeAndClientStack(){} // RVA: 0x6E8B220
        public void get_NewStack(){} // RVA: 0xB700F0
        public void get_IsGlobalMode(){} // RVA: 0x6E8B280
        public void .ctor(){} // RVA: 0x6E8B300
        public void GetCurrent(){} // RVA: 0x6E8B670
        public void ConfigureScope(){} // RVA: 0x6E8B6C0
        public void ConfigureScopeAsync(){} // RVA: 0x6E8B860
        public void PushScope(){} // RVA: 0xA94080
        public void RestoreScope(){} // RVA: 0x6E8BA70
        public void BindClient(){} // RVA: 0x6E8BEE0
        public void Dispose(){} // RVA: 0x6E8C1F0
    }

    public class SentryStopwatch : ValueType
    {
        public object StopwatchTicksPerTimeSpanTick;
        public object StopwatchTicksPerNs;
        public object _startTimestamp;
        public object _startDateTimeOffset;

        // ── Methods ──
        public void StartNew(){} // RVA: 0x6E8C4F0
        public void get_StartDateTimeOffset(){} // RVA: 0xCB720
        public void get_CurrentDateTimeOffset(){} // RVA: 0x8F75E0
        public void Diff(){} // RVA: 0x8F7610
        public void get_Elapsed(){} // RVA: 0x8F7660
        public void get_ElapsedNanoseconds(){} // RVA: 0x8F7670
        public void .cctor(){} // RVA: 0x6E8C8C0
    }

    public class SerializableExtensions : Object
    {
        // ── Methods ──
        public void SerializeToStringAsync(){} // RVA: 0x6E8C980
        public void SerializeToString(){} // RVA: 0x6E8CC40
    }

    public class SettingLocator : Object
    {
        public object _options;
        public object _assemblyForAttributes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E8DB00
        public void get_AssemblyForAttributes(){} // RVA: 0xB465B0
        public void set_AssemblyForAttributes(){} // RVA: 0xBA9BA0
        public void GetEnvironmentVariable(){} // RVA: 0x6E8DBC0
        public void GetDsn(){} // RVA: 0x6E8DBD0
        public void GetEnvironment(){} // RVA: 0x6E8DD20
        public void GetRelease(){} // RVA: 0x6E8DF00
    }

    public class Signal : Object
    {
        public object _lock;
        public object _semaphore;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E8E0C0
        public void Release(){} // RVA: 0x6E8E220
        public void WaitAsync(){} // RVA: 0x6E8E390
        public void Dispose(){} // RVA: 0x6E8E3C0
    }

    public class StringOrRegex : Object
    {
        public object _regex;
        public object _prefix;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void op_Implicit(){} // RVA: 0x6E8E470
        public void ToString(){} // RVA: 0x6E8E500
        public void Equals(){} // RVA: 0x6E8E570
        public void GetHashCode(){} // RVA: 0x273F540
    }

    public class StringOrRegexExtensions : Object
    {
        // ── Methods ──
        public void MatchesAny(){} // RVA: 0x6E8E660
    }

    public class StringOrRegex[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SynchronizedRandomValuesFactory : RandomValuesFactory
    {
        public object LocalRandom;

        // ── Methods ──
        public void get_Random(){} // RVA: 0x6E8E880
        public void NextInt(){} // RVA: 0x6E8EA20
        public void NextDouble(){} // RVA: 0x6E8EAA0
        public void NextBytes(){} // RVA: 0x6E8EB10
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6E8EB80
    }

    public class TcpPing : Object
    {
        public object <hostToCheck>P;
        public object <portToCheck>P;
        public object _ping;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E8EC40
        public void IsAvailableAsync(){} // RVA: 0x6E8EE70
    }

    public class ThreadPoolInfo : Object
    {
        public object _minWorkerThreads;
        public object _minCompletionPortThreads;
        public object _maxWorkerThreads;
        public object _maxCompletionPortThreads;
        public object _availableWorkerThreads;
        public object _availableCompletionPortThreads;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E8F500
        public void get_MinWorkerThreads(){} // RVA: 0xB8F8F0
        public void get_MinCompletionPortThreads(){} // RVA: 0x116A650
        public void get_MaxWorkerThreads(){} // RVA: 0xE62D00
        public void get_MaxCompletionPortThreads(){} // RVA: 0x2244FB0
        public void get_AvailableWorkerThreads(){} // RVA: 0xFEAE90
        public void get_AvailableCompletionPortThreads(){} // RVA: 0x15AF000
        public void WriteTo(){} // RVA: 0x6E8F530
    }

    public class ThreadsafeCounterDictionary`1 : Object
    {
        public object _items;

        // ── Methods ──
        public void Add(){} // RVA: 0xA94080
        public void Increment(){} // RVA: 0xA94080
        public void ReadAndReset(){} // RVA: 0xA94080
        public void ReadAllAndReset(){} // RVA: 0x87C0A0
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void get_Count(){} // RVA: 0x87C130
        public void ContainsKey(){} // RVA: 0xA94080
        public void TryGetValue(){} // RVA: 0xA94080
        public void get_Item(){} // RVA: 0xA94080
        public void get_Keys(){} // RVA: 0x87C0A0
        public void get_Values(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894290
    }

}