// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal
// Classes: 97
// Methods: 629

namespace ThirdParty.Sentry.Sentry.Internal
{
    public class AotHelper
    {
        public string SuppressionJustification;

        // ── Methods ──
        public void get_IsTrimmed(){} // RVA: 0x63F85D0
        public void .cctor(){} // RVA: 0x63F8630
    }

    public class AppDomainAdapter
    {
        public Sentry.Internal.AppDomainAdapter <Instance>k__BackingField;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x63F86E0
        public void .ctor(){} // RVA: 0x63F8740
        public void add_UnhandledException(){} // RVA: 0x63F8940
        public void remove_UnhandledException(){} // RVA: 0x63F8A30
        public void add_ProcessExit(){} // RVA: 0x63F8B20
        public void remove_ProcessExit(){} // RVA: 0x63F8C10
        public void add_UnobservedTaskException(){} // RVA: 0x63F8D00
        public void remove_UnobservedTaskException(){} // RVA: 0x63F8E00
        public void OnProcessExit(){} // RVA: 0x4EC5180
        public void OnUnhandledException(){} // RVA: 0x63F8F00
        public void OnUnobservedTaskException(){} // RVA: 0x63F8F20
        public void .cctor(){} // RVA: 0x63F8F40
    }

    public class ApplicationVersionLocator
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x63F8FF0
    }

    public class AutoClearingList`1
    {
        public System.Collections.Generic.IList`1<T> _list;
        public bool _clearOnNextAdd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2A620
        public void Add(){} // RVA: 0x283FA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void Remove(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void get_IsReadOnly(){} // RVA: 0xDBE0
        public void IndexOf(){} // RVA: 0x283FA0
        public void Insert(){} // RVA: 0x283FA0
        public void RemoveAt(){} // RVA: 0x24FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
    }

    public class AutoClearingList`1
    {
        public System.Collections.Generic.IList`1<Sentry.SubstringOrRegexPattern> _list; // 0x10
        public bool _clearOnNextAdd; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x557B770
        public void Add(){} // RVA: 0x557B880
        public void GetEnumerator(){} // RVA: 0x3326E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x557B950
        public void Clear(){} // RVA: 0x557B9A0
        public void Contains(){} // RVA: 0x557B9F0
        public void CopyTo(){} // RVA: 0x557BA50
        public void Remove(){} // RVA: 0x557BAC0
        public void get_Count(){} // RVA: 0x379A400
        public void get_IsReadOnly(){} // RVA: 0x557BB20
        public void IndexOf(){} // RVA: 0x557BB70
        public void Insert(){} // RVA: 0x557BBD0
        public void RemoveAt(){} // RVA: 0x557BCB0
        public void get_Item(){} // RVA: 0x557BD10
        public void set_Item(){} // RVA: 0x557BD70
    }

    public class BackgroundWorker
    {
        public Sentry.Extensibility.ITransport _transport; // 0x10
        public Sentry.SentryOptions _options; // 0x18

        // ── Methods ──
        public void add_OnFlushObjectReceived(){} // RVA: 0x63F9100
        public void remove_OnFlushObjectReceived(){} // RVA: 0x63F91F0
        public void get_WorkerTask(){} // RVA: 0x37E0E0
        public void get_QueuedItems(){} // RVA: 0x63F92E0
        public void .ctor(){} // RVA: 0x63F9330
        public void EnqueueEnvelope(){} // RVA: 0x63F97D0 | overloaded x2
        public void ProcessQueuedItems(){} // RVA: 0x63F9B40
        public void DoWorkAsync(){} // RVA: 0x63F9B60
        public void FlushAsync(){} // RVA: 0x63F9D30
        public void DoFlushAsync(){} // RVA: 0x63F9F10
        public void SendFinalClientReportAsync(){} // RVA: 0x63FA130
        public void Dispose(){} // RVA: 0x63FA340
    }

    public class ClientReport
    {
        public System.DateTimeOffset <Timestamp>k__BackingField; // 0x10
        public System.Collections.Generic.IReadOnlyDictionary`2<Sentry.Internal.DiscardReasonWithCategory,int> <DiscardedEvents>k__BackingField; // 0x20

        // ── Methods ──
        public void get_Timestamp(){} // RVA: 0x196ABE0
        public void get_DiscardedEvents(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x4437830
        public void WriteTo(){} // RVA: 0x63FE9F0
        public void FromJson(){} // RVA: 0x63FF6C0
    }

    public class ClientReportRecorder
    {
        public Sentry.SentryOptions _options; // 0x10

        // ── Methods ──
        public void get_DiscardedEvents(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x64005A0
        public void RecordDiscardedEvent(){} // RVA: 0x6400890
        public void GenerateClientReport(){} // RVA: 0x6400A10
        public void Load(){} // RVA: 0x6400CC0
    }

    public class ConcurrentQueueLite`1
    {
        public System.Collections.Generic.List`1<T> _queue;

        // ── Methods ──
        public void Enqueue(){} // RVA: 0x283FA0
        public void TryDequeue(){} // RVA: 0xDE40
        public void get_Count(){} // RVA: 0xD840
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void Clear(){} // RVA: 0x24A50
        public void TryPeek(){} // RVA: 0xDE40
        public void ToArray(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24A50
    }

    public class Constants
    {
    }

    public class ContextWriter
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x6401060
        public void WriteScope(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DataCategory
    {
        public Sentry.Internal.DataCategory Attachment;

        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x1AD4690
        public void .ctor(){} // RVA: 0x100A2F0
        public void CompareTo(){} // RVA: 0x6401F80 | overloaded x2
        public void Equals(){} // RVA: 0x6402070 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6402140
        public void ToString(){} // RVA: 0x1AD4690
        public void .cctor(){} // RVA: 0x6402170
    }

    public class DebugStackTrace
    {
        public Sentry.SentryOptions _options; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6402990
        public void get_DebugImages(){} // RVA: 0x4976A0
        public void Create(){} // RVA: 0x6402CB0 | overloaded x2
        public void MergeDebugImagesInto(){} // RVA: 0x6403250
        public void CreateFrames(){} // RVA: 0x6403B70
        public void TryCreateManagedFrame(){} // RVA: 0x6403CF0
        public void CreateFrame(){} // RVA: 0x6404460
        public void GetRelativeAddressMode(){} // RVA: 0x6404660
        public void DemangleAsyncFunctionName(){} // RVA: 0x6404700
        public void DemangleAnonymousFunction(){} // RVA: 0x6404980
        public void DemangleLambdaReturnType(){} // RVA: 0x6404B60
        public void TryReadAssemblyFromDisk(){} // RVA: 0x6404D10
        public void AddManagedModuleDebugImage(){} // RVA: 0x6404F40
        public void GetManagedModuleDebugImage(){} // RVA: 0x6405170
        public void .cctor(){} // RVA: 0x64055F0
    }

    public class DelegateEventProcessor : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Process(){} // RVA: 0x288D780
    }

    public class DelegateTransactionProcessor : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Process(){} // RVA: 0x288D780
    }

    public class DelimitedPrefixOrPatternMatcher : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6406650
        public void IsMatch(){} // RVA: 0x6406660
    }

    public class DiscardReason
    {
        public Sentry.Internal.DiscardReason BeforeSend;

        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x1AD4690
        public void .ctor(){} // RVA: 0x100A2F0
        public void WithCategory(){} // RVA: 0x6406970
        public void CompareTo(){} // RVA: 0x64069A0 | overloaded x2
        public void Equals(){} // RVA: 0x6406A90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6402140
        public void ToString(){} // RVA: 0x1AD4690
        public void .cctor(){} // RVA: 0x6406B60
    }

    public class DiscardReasonWithCategory
    {
        public Sentry.Internal.DiscardReason <Reason>k__BackingField; // 0x10
        public Sentry.Internal.DataCategory <Category>k__BackingField; // 0x18

        // ── Methods ──
        public void get_Reason(){} // RVA: 0x1AD4690
        public void get_Category(){} // RVA: 0x19689C0
        public void .ctor(){} // RVA: 0x37C8AF0 | overloaded x2
        public void CompareTo(){} // RVA: 0x64073B0 | overloaded x2
        public void Equals(){} // RVA: 0x64075A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x6407640
        public void ToString(){} // RVA: 0x6407710
    }

    public class Disposable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Dispose(){} // RVA: 0x1281E30
        public void Create(){} // RVA: 0x64077F0
    }

    public class DuplicateEventDetectionEventProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6407880
        public void Process(){} // RVA: 0x64079A0
        public void IsDuplicate(){} // RVA: 0x6407B50
    }

    public class Enricher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6407F80
        public void Apply(){} // RVA: 0x6408A70 | overloaded x2
    }

    public class ExceptionHandlingSynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6408E20
        public void Post(){} // RVA: 0x6408ED0
    }

    public class ExceptionTypeFilter`1
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0xDE40
        public void .ctor(){} // RVA: 0x24A50
    }

    public class FileSystemBase
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x6409190 | overloaded x3
        public void DirectoryExists(){} // RVA: 0x6409220
        public void FileExists(){} // RVA: 0x6409230
        public void GetFileCreationTime(){} // RVA: 0x6409240
        public void ReadAllTextFromFile(){} // RVA: 0x64093B0
        public void OpenFileForReading(){} // RVA: 0x6409490
        public void CreateDirectory(){} // RVA: 0xDE40
        public void DeleteDirectory(){}
        public void CreateFileForWriting(){} // RVA: 0x11120
        public void WriteAllTextToFile(){} // RVA: 0x11120
        public void MoveFile(){}
        public void DeleteFile(){} // RVA: 0xDE40
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class GrowableArray`1
    {
        public T[] array;
        public int arrayLength;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void Reserve(){} // RVA: 0x24FA0
        public void Clear(){} // RVA: 0x24A50
        public void Add(){} // RVA: 0x283FA0
        public void AddRange(){} // RVA: 0x24B10
        public void Insert(){} // RVA: 0x283FA0
        public void RemoveRange(){} // RVA: 0x26EE0
        public void get_Empty(){} // RVA: 0xDBE0
        public void Trim(){} // RVA: 0x24FA0
        public void get_EmptyCapacity(){} // RVA: 0xDBE0
        public void ToString(){} // RVA: 0xCD60
        public void Foreach(){} // RVA: 0x283FA0
        public void Search(){} // RVA: 0x283FA0
        public void get_UnderlyingArray(){} // RVA: 0xCD60
        public void Realloc(){} // RVA: 0x24FA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void GetEnumerator(){} // RVA: 0xCD60
    }

    public class GrowableArray`1
    {
        public Sample[] array; // 0x10
        public int arrayLength; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x34B2BE0
        public void get_Item(){} // RVA: 0x34B4360
        public void set_Item(){} // RVA: 0x34B4390
        public void get_Count(){} // RVA: 0x1EA9890
        public void Reserve(){} // RVA: 0x34B2D60
        public void Clear(){} // RVA: 0x34B2DB0
        public void Add(){} // RVA: 0x34B43B0
        public void AddRange(){} // RVA: 0x34B4430
        public void Insert(){} // RVA: 0x34B46C0
        public void RemoveRange(){} // RVA: 0x34B4820
        public void get_Empty(){} // RVA: 0x34B3520
        public void Trim(){} // RVA: 0x34B3530
        public void get_EmptyCapacity(){} // RVA: 0x1D26810
        public void ToString(){} // RVA: 0x34B4980
        public void Foreach(){} // RVA: 0x283FA0
        public void Search(){} // RVA: 0x283FA0
        public void get_UnderlyingArray(){} // RVA: 0x1AD4690
        public void Realloc(){} // RVA: 0x34B3A00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34B3AD0
        public void GetEnumerator(){} // RVA: 0x34B3AD0
    }

    public class GrowableArray`1
    {
        public Sentry.SentryStackFrame[] array; // 0x10
        public int arrayLength; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x34B2BE0
        public void get_Item(){} // RVA: 0x34B4360
        public void set_Item(){} // RVA: 0x34B4390
        public void get_Count(){} // RVA: 0x1EA9890
        public void Reserve(){} // RVA: 0x34B2D60
        public void Clear(){} // RVA: 0x34B2DB0
        public void Add(){} // RVA: 0x34B43B0
        public void AddRange(){} // RVA: 0x34B4430
        public void Insert(){} // RVA: 0x34B46C0
        public void RemoveRange(){} // RVA: 0x34B4820
        public void get_Empty(){} // RVA: 0x34B3520
        public void Trim(){} // RVA: 0x34B3530
        public void get_EmptyCapacity(){} // RVA: 0x1D26810
        public void ToString(){} // RVA: 0x34B4980
        public void Foreach(){} // RVA: 0x283FA0
        public void Search(){} // RVA: 0x283FA0
        public void get_UnderlyingArray(){} // RVA: 0x1AD4690
        public void Realloc(){} // RVA: 0x34B3A00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34B3AD0
        public void GetEnumerator(){} // RVA: 0x34B3AD0
    }

    public class GrowableArray`1
    {
        public Sentry.Internal.GrowableArray`1<int>[] array; // 0x10
        public int arrayLength; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x34B2BE0
        public void get_Item(){} // RVA: 0x34B2C90
        public void set_Item(){} // RVA: 0x34B2CD0
        public void get_Count(){} // RVA: 0x1EA9890
        public void Reserve(){} // RVA: 0x34B2D60
        public void Clear(){} // RVA: 0x34B2DB0
        public void Add(){} // RVA: 0x34B2DC0
        public void AddRange(){} // RVA: 0x34B2EA0
        public void Insert(){} // RVA: 0x34B31C0
        public void RemoveRange(){} // RVA: 0x34B33B0
        public void get_Empty(){} // RVA: 0x34B3520
        public void Trim(){} // RVA: 0x34B3530
        public void get_EmptyCapacity(){} // RVA: 0x1D26810
        public void ToString(){} // RVA: 0x34B37C0
        public void Foreach(){} // RVA: 0x283FA0
        public void Search(){} // RVA: 0x283FA0
        public void get_UnderlyingArray(){} // RVA: 0x1AD4690
        public void Realloc(){} // RVA: 0x34B3A00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34B3AD0
        public void GetEnumerator(){} // RVA: 0x34B3AD0
    }

    public class GrowableArray`1
    {
        public int[] array; // 0x10
        public int arrayLength; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x34B2BE0
        public void get_Item(){} // RVA: 0x34B3BB0
        public void set_Item(){} // RVA: 0x34B3BE0
        public void get_Count(){} // RVA: 0x1EA9890
        public void Reserve(){} // RVA: 0x34B2D60
        public void Clear(){} // RVA: 0x34B2DB0
        public void Add(){} // RVA: 0x34B3C10
        public void AddRange(){} // RVA: 0x34B3C90
        public void Insert(){} // RVA: 0x34B3F30
        public void RemoveRange(){} // RVA: 0x34B4040
        public void get_Empty(){} // RVA: 0x34B3520
        public void Trim(){} // RVA: 0x34B3530
        public void get_EmptyCapacity(){} // RVA: 0x1D26810
        public void ToString(){} // RVA: 0x34B4130
        public void Foreach(){} // RVA: 0x283FA0
        public void Search(){} // RVA: 0x283FA0
        public void get_UnderlyingArray(){} // RVA: 0x1AD4690
        public void Realloc(){} // RVA: 0x34B3A00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34B3AD0
        public void GetEnumerator(){} // RVA: 0x34B3AD0
    }

    public class HashableGrowableArray`1
    {
        public Sentry.Internal.GrowableArray`1<T> _items;
        public int _hashCode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void Seal(){} // RVA: 0x24A50
        public void Trim(){} // RVA: 0x24FA0
        public void Add(){} // RVA: 0x283FA0
        public void GetHashCode(){} // RVA: 0xD840
        public void Equals(){} // RVA: 0xDE40 | overloaded x2
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class Hub
    {
        public object _sessionPauseLock; // 0x10
        public Sentry.Infrastructure.ISystemClock _clock; // 0x18
        public Sentry.ISessionManager _sessionManager; // 0x20
        public Sentry.SentryOptions _options; // 0x28
        public Sentry.Internal.RandomValuesFactory _randomValuesFactory; // 0x30
        public int _isPersistedSessionRecovered; // 0x38
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<System.Exception,Sentry.ISpan> <ExceptionToSpanMap>k__BackingField; // 0x40
        public Sentry.Internal.IInternalScopeManager <ScopeManager>k__BackingField; // 0x48

        // ── Methods ──
        public void get_ExceptionToSpanMap(){} // RVA: 0x35A740
        public void get_ScopeManager(){} // RVA: 0x358730
        public void get_Metrics(){} // RVA: 0x37E0E0
        public void get_IsEnabled(){} // RVA: 0x64094A0
        public void get_Options(){} // RVA: 0x30B130
        public void get_CurrentScope(){} // RVA: 0x64094B0
        public void get_CurrentClient(){} // RVA: 0x6409580
        public void .ctor(){} // RVA: 0x6409650
        public void ConfigureScope(){} // RVA: 0x640A050
        public void ConfigureScopeAsync(){} // RVA: 0x640A110
        public void PushScope(){} // RVA: 0x283FA0 | overloaded x2
        public void RestoreScope(){} // RVA: 0x640A370
        public void BindClient(){} // RVA: 0x640A440
        public void StartTransaction(){} // RVA: 0x640A4C0 | overloaded x2
        public void BindException(){} // RVA: 0x640AAB0
        public void GetSpan(){} // RVA: 0x640AC40
        public void GetTraceHeader(){} // RVA: 0x640AC70
        public void GetBaggage(){} // RVA: 0x640AD40
        public void ContinueTrace(){} // RVA: 0x640AFB0 | overloaded x2
        public void StartSession(){} // RVA: 0x640B340
        public void PauseSession(){} // RVA: 0x640B4C0
        public void ResumeSession(){} // RVA: 0x640B6D0
        public void EndSession(){} // RVA: 0x640BC10 | overloaded x2
        public void GetLinkedSpan(){} // RVA: 0x640BC90
        public void ApplyTraceContextToEvent(){} // RVA: 0x640C020 | overloaded x2
        public void CaptureEnvelope(){} // RVA: 0x640C210
        public void AddBreadcrumbForException(){} // RVA: 0x640C280
        public void CaptureEvent(){} // RVA: 0x640C7D0 | overloaded x4
        public void CaptureUserFeedback(){} // RVA: 0x640CC10
        public void CaptureTransaction(){} // RVA: 0x640CD60 | overloaded x2
        public void CaptureMetrics(){} // RVA: 0x640CE60
        public void CaptureCodeLocations(){} // RVA: 0x640D1F0
        public void StartSpan(){} // RVA: 0x640D4A0
        public void CaptureSession(){} // RVA: 0x640D650
        public void CaptureCheckIn(){} // RVA: 0x640D780
        public void FlushAsync(){} // RVA: 0x640DA10
        public void Dispose(){} // RVA: 0x640DBE0
        public void get_LastEventId(){} // RVA: 0x640DD90
    }

    public class IAppDomain
    {
        // ── Methods ──
        public void add_UnhandledException(){} // RVA: 0x24B10
        public void remove_UnhandledException(){} // RVA: 0x24B10
        public void add_ProcessExit(){} // RVA: 0x24B10
        public void remove_ProcessExit(){} // RVA: 0x24B10
        public void add_UnobservedTaskException(){} // RVA: 0x24B10
        public void remove_UnobservedTaskException(){} // RVA: 0x24B10
    }

    public class IClientReportRecorder
    {
        // ── Methods ──
        public void RecordDiscardedEvent(){}
        public void GenerateClientReport(){} // RVA: 0xCD60
        public void Load(){} // RVA: 0x24B10
    }

    public class ICloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x283FA0
    }

    public class ICloneable`1
    {
    }

    public class ICloneable`1
    {
    }

    public class ICloneable`1
    {
    }

    public class ICloneable`1
    {
    }

    public class ICloneable`1
    {
    }

    public class ICloneable`1
    {
    }

    public class ICloneable`1
    {
    }

    public class ICloneable`1
    {
    }

    public class IEnumeration
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0xCD60
    }

    public class IEnumeration`1
    {
    }

    public class IEnumeration`1
    {
    }

    public class IEnumeration`1
    {
    }

    public class IFileSystem
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x1E6A0 | overloaded x3
        public void DirectoryExists(){} // RVA: 0xDE40
        public void FileExists(){} // RVA: 0xDE40
        public void GetFileCreationTime(){}
        public void ReadAllTextFromFile(){} // RVA: 0xCE10
        public void OpenFileForReading(){} // RVA: 0xCE10
        public void CreateDirectory(){} // RVA: 0xDE40
        public void DeleteDirectory(){}
        public void CreateFileForWriting(){} // RVA: 0x11120
        public void WriteAllTextToFile(){} // RVA: 0x11120
        public void MoveFile(){}
        public void DeleteFile(){} // RVA: 0xDE40
    }

    public class IInternalScopeManager
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0xC770
        public void RestoreScope(){} // RVA: 0x24B10
        public void get_ScopeStackContainer(){} // RVA: 0xCD60
    }

    public class IPing
    {
        // ── Methods ──
        public void IsAvailableAsync(){}
    }

    public class IStackFrame
    {
        // ── Methods ──
        public void get_Frame(){} // RVA: 0xCD60
        public void GetNativeImageBase(){} // RVA: 0xCD60
        public void GetNativeIP(){} // RVA: 0xCD60
        public void HasNativeImage(){} // RVA: 0xDBE0
        public void GetFileColumnNumber(){} // RVA: 0xD840
        public void GetFileLineNumber(){} // RVA: 0xD840
        public void GetFileName(){} // RVA: 0xCD60
        public void GetILOffset(){} // RVA: 0xD840
        public void GetMethod(){} // RVA: 0xCD60
        public void ToString(){} // RVA: 0xCD60
    }

    public class IStringOrRegexMatcher
    {
        // ── Methods ──
        public void IsMatch(){} // RVA: 0x11120
    }

    public class ITransactionProfiler
    {
        // ── Methods ──
        public void Finish(){} // RVA: 0x24A50
        public void Collect(){} // RVA: 0xCE10
    }

    public class ITransactionProfilerFactory
    {
        // ── Methods ──
        public void Start(){}
    }

    public class IUpdatable
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x24B10
    }

    public class IUpdatable`1
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x283FA0
    }

    public class IUpdatable`1
    {
    }

    public class IUpdatable`1
    {
    }

    public class IUpdatable`1
    {
    }

    public class IUpdatable`1
    {
    }

    public class IUpdatable`1
    {
    }

    public class IUpdatable`1
    {
    }

    public class IUpdatable`1
    {
    }

    public class IUpdatable`1
    {
    }

    public class InstallationIdHelper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x640E690
        public void TryGetInstallationId(){} // RVA: 0x640E790
        public void TryGetPersistentInstallationId(){} // RVA: 0x640EAA0
        public void TryGetHardwareInstallationId(){} // RVA: 0x640F0F0
        public void GetMachineNameInstallationId(){} // RVA: 0x640F4E0
    }

    public class Json
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x283FA0 | overloaded x2
        public void Load(){} // RVA: 0x283FA0
    }

    public class Lock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x640F650
        public void AcquireAsync(){} // RVA: 0x640F6F0
        public void Dispose(){} // RVA: 0x640F8E0
    }

    public class MainExceptionProcessor
    {
        public string ExceptionDataKeyPrefix;

        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void Process(){} // RVA: 0x640FD30
        public void CreateSentryExceptions(){} // RVA: 0x640FE50
        public void WalkExceptions(){} // RVA: 0x64100A0 | overloaded x2
        public void MoveExceptionDataToEvent(){} // RVA: 0x6410280
        public void BuildSentryException(){} // RVA: 0x6410D70
        public void GetMechanism(){} // RVA: 0x6411110
    }

    public class MainSentryEventProcessor
    {
        public string CultureInfoKey;
        public string CurrentUiCultureKey;
        public string MemoryInfoKey;

        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x30B0C0
        public void get_Release(){} // RVA: 0x6412840
        public void get_Distribution(){} // RVA: 0x6412870
        public void .ctor(){} // RVA: 0x6412890
        public void Process(){} // RVA: 0x6412A10
        public void AddMemoryInfo(){} // RVA: 0x2DD310
        public void AddThreadPoolInfo(){} // RVA: 0x6413AA0
        public void CultureInfoToDictionary(){} // RVA: 0x6413BF0
    }

    public class ModuleExtensions
    {
        // ── Methods ──
        public void GetNameOrScopeName(){} // RVA: 0x6413F20
    }

    public class NoOpSpan
    {
        public Sentry.ISpan <Instance>k__BackingField;
        public string <Origin>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6414010
        public void .ctor(){} // RVA: 0x2DD310
        public void get_SpanId(){} // RVA: 0x6414070
        public void get_ParentSpanId(){} // RVA: 0x64140D0
        public void get_TraceId(){} // RVA: 0x6414150
        public void get_IsSampled(){} // RVA: 0x519240
        public void get_Tags(){} // RVA: 0x64141B0
        public void get_Extra(){} // RVA: 0x6414210
        public void get_StartTimestamp(){} // RVA: 0x1529E90
        public void get_EndTimestamp(){} // RVA: 0x3F3ED10
        public void get_IsFinished(){} // RVA: 0x2DD320
        public void get_Operation(){} // RVA: 0x6414270
        public void set_Operation(){} // RVA: 0x2DD310
        public void get_Description(){} // RVA: 0x519240
        public void set_Description(){} // RVA: 0x2DD310
        public void get_Status(){} // RVA: 0x519240
        public void set_Status(){} // RVA: 0x2DD310
        public void StartChild(){} // RVA: 0x1A3F520
        public void Finish(){} // RVA: 0x2DD310 | overloaded x4
        public void SetTag(){} // RVA: 0x2DD310
        public void UnsetTag(){} // RVA: 0x2DD310
        public void SetExtra(){} // RVA: 0x2DD310
        public void GetTraceHeader(){} // RVA: 0x64142B0
        public void get_Measurements(){} // RVA: 0x6414310
        public void SetMeasurement(){} // RVA: 0x2DD310
        public void get_Origin(){} // RVA: 0x2F8380
        public void set_Origin(){} // RVA: 0x2DEE30
        public void .cctor(){} // RVA: 0x6414370
    }

    public class NoOpTransaction
    {
        public Sentry.ITransactionTracer <Instance>k__BackingField;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6414410
        public void .ctor(){} // RVA: 0x6414470
        public void get_Sdk(){} // RVA: 0x64144C0
        public void get_Name(){} // RVA: 0x6414510
        public void set_Name(){} // RVA: 0x2DD310
        public void get_IsParentSampled(){} // RVA: 0x519240
        public void set_IsParentSampled(){} // RVA: 0x2DD310
        public void get_NameSource(){} // RVA: 0x519240
        public void get_Distribution(){} // RVA: 0x6414550
        public void set_Distribution(){} // RVA: 0x2DD310
        public void get_Level(){} // RVA: 0x519240
        public void set_Level(){} // RVA: 0x2DD310
        public void get_Request(){} // RVA: 0x6414590
        public void set_Request(){} // RVA: 0x2DD310
        public void get_Contexts(){} // RVA: 0x64145D0
        public void set_Contexts(){} // RVA: 0x2DD310
        public void get_User(){} // RVA: 0x6414620
        public void set_User(){} // RVA: 0x2DD310
        public void get_Platform(){} // RVA: 0x519240
        public void set_Platform(){} // RVA: 0x2DD310
        public void get_Release(){} // RVA: 0x519240
        public void set_Release(){} // RVA: 0x2DD310
        public void get_Environment(){} // RVA: 0x519240
        public void set_Environment(){} // RVA: 0x2DD310
        public void get_TransactionName(){} // RVA: 0x519240
        public void set_TransactionName(){} // RVA: 0x2DD310
        public void get_Fingerprint(){} // RVA: 0x6414660
        public void set_Fingerprint(){} // RVA: 0x2DD310
        public void get_Spans(){} // RVA: 0x64146C0
        public void get_Breadcrumbs(){} // RVA: 0x6414720
        public void GetLastActiveSpan(){} // RVA: 0x519240
        public void AddBreadcrumb(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x6414780
    }

    public class ObjectExtensions
    {
        public System.Runtime.CompilerServices.ConditionalWeakTable`2<object,System.Collections.Generic.Dictionary`2<string,object>> controlPath;

        // ── Methods ──
        public void get_Map(){} // RVA: 0x6414860
        public void AssociatedProperties(){} // RVA: 0x64148C0
        public void SetFused(){} // RVA: 0x283FA0 | overloaded x2
        public void GetFused(){} // RVA: 0x283FA0
        public void .cctor(){} // RVA: 0x6414B60
    }

    public class OriginHelper
    {
        // ── Methods ──
        public void IsValidOrigin(){} // RVA: 0x6414D40
        public void TryParse(){} // RVA: 0x6414DF0
        public void SetOrigin(){} // RVA: 0x6414E50
        public void .cctor(){} // RVA: 0x6415060
    }

    public class PartialStream
    {
        public System.IO.Stream _innerStream; // 0x28
        public long _offset; // 0x30
        public System.Nullable`1<long> _length; // 0x38
        public long _position; // 0x48

        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x6415140
        public void get_CanSeek(){} // RVA: 0x6415170
        public void get_CanWrite(){} // RVA: 0x2DD320
        public void get_Length(){} // RVA: 0x64151A0
        public void get_Position(){} // RVA: 0x358730
        public void set_Position(){} // RVA: 0x6415230
        public void .ctor(){} // RVA: 0x64152E0
        public void ReadAsync(){} // RVA: 0x64153B0
        public void Seek(){} // RVA: 0x6415640
        public void Read(){} // RVA: 0x6415770
        public void SetLength(){} // RVA: 0x64158C0
        public void Write(){} // RVA: 0x6415900
        public void Flush(){} // RVA: 0x6415940
    }

    public class PiiExtensions
    {
        // ── Methods ──
        public void RedactUrl(){} // RVA: 0x6415E50
        public void RedactAuth(){} // RVA: 0x64160C0
        public void .cctor(){} // RVA: 0x64163A0
    }

    public class PollingNetworkStatusListener
    {
        public Sentry.SentryOptions _options; // 0x10
        public Sentry.Internal.IPing _testPing; // 0x18
        public int _delayInMilliseconds; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64168B0 | overloaded x2
        public void get_LazyPing(){} // RVA: 0x6416AD0
        public void get_Ping(){} // RVA: 0x6416BB0
        public void get_Online(){} // RVA: 0x6416CC0
        public void set_Online(){} // RVA: 0x6416CD0
        public void WaitForNetworkOnlineAsync(){} // RVA: 0x6416CE0
        public void <get_LazyPing>b__8_0(){} // RVA: 0x6416EF0
    }

    public class PooledBuffer`1
    {
        public T[] <Array>k__BackingField;

        // ── Methods ──
        public void get_Array(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24FA0
        public void Dispose(){} // RVA: 0x24A50
    }

    public class PooledBuffer`1
    {
        public byte[] <Array>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Array(){} // RVA: 0x1AD4690
        public void .ctor(){} // RVA: 0x3DF6720
        public void Dispose(){} // RVA: 0x3DF67D0
    }

    public class PrefixOrPatternMatcher : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void IsMatch(){} // RVA: 0x6417910
    }

    public class ProcessInfo
    {
        public Sentry.Internal.ProcessInfo Instance;
        public System.Nullable`1<System.DateTimeOffset> <StartupTime>k__BackingField; // 0x10
        public System.Nullable`1<System.DateTimeOffset> <BootTime>k__BackingField; // 0x28

        // ── Methods ──
        public void get_StartupTime(){} // RVA: 0x1F90220
        public void set_StartupTime(){} // RVA: 0x1F90200
        public void get_BootTime(){} // RVA: 0x204E840
        public void get_PreciseAppStartupTask(){} // RVA: 0x6417A80
        public void set_PreciseAppStartupTask(){} // RVA: 0x6417A90
        public void GetId(){} // RVA: 0x6417AF0
        public void GetCurrentProcessId(){} // RVA: 0x6417B50
        public void .ctor(){} // RVA: 0x6417C30
        public void GetStartupTime(){} // RVA: 0x64184C0
        public void ApplicationIsActivated(){} // RVA: 0x6418680
        public void GetForegroundWindow(){} // RVA: 0x6418A50
        public void GetWindowThreadProcessId(){} // RVA: 0x6418AC0
    }

    public class RandomValuesFactory
    {
        // ── Methods ──
        public void NextInt(){} // RVA: 0x14170 | overloaded x2
        public void NextDouble(){} // RVA: 0x12A40
        public void NextBytes(){} // RVA: 0x24B10
        public void NextBool(){} // RVA: 0x6418D80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ReadOnlyFileSystem
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x2DD320
        public void DeleteDirectory(){} // RVA: 0x2DD320
        public void CreateFileForWriting(){} // RVA: 0x6418DE0
        public void WriteAllTextToFile(){} // RVA: 0x2DD320
        public void MoveFile(){} // RVA: 0x2DD320
        public void DeleteFile(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ReadWriteFileSystem
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x6418E80
        public void DeleteDirectory(){} // RVA: 0x6418EB0
        public void CreateFileForWriting(){} // RVA: 0x6418EE0
        public void WriteAllTextToFile(){} // RVA: 0x6418FC0
        public void MoveFile(){} // RVA: 0x6418FF0
        public void DeleteFile(){} // RVA: 0x6419060
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class RealStackFrame
    {
        public System.Diagnostics.StackFrame _frame; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Frame(){} // RVA: 0x2F8380
        public void ToString(){} // RVA: 0x104C4B0
        public void GetFileColumnNumber(){} // RVA: 0x7F0250
        public void GetFileLineNumber(){} // RVA: 0x7F01B0
        public void GetFileName(){} // RVA: 0x7F02E0
        public void GetILOffset(){} // RVA: 0x606CEF0
        public void GetMethod(){} // RVA: 0x7AC2C0
        public void GetNativeImageBase(){} // RVA: 0x519240
        public void GetNativeIP(){} // RVA: 0x519240
        public void HasNativeImage(){} // RVA: 0x2DD320
    }

    public class ScopeObserver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCCD00
        public void AddBreadcrumb(){} // RVA: 0x6419150
        public void AddBreadcrumbImpl(){} // RVA: 0x24B10
        public void SetExtra(){} // RVA: 0x6419360
        public void SetExtraImpl(){} // RVA: 0x2DC60
        public void SetTag(){} // RVA: 0x64196C0
        public void SetTagImpl(){} // RVA: 0x2DC60
        public void UnsetTag(){} // RVA: 0x64198A0
        public void UnsetTagImpl(){} // RVA: 0x24B10
        public void SetUser(){} // RVA: 0x6419A40
        public void SetUserImpl(){} // RVA: 0x24B10
        public void UnsetUserImpl(){} // RVA: 0x24A50
    }

    public class SdkComposer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6419D00
        public void CreateTransport(){} // RVA: 0x6419E10
        public void CreateHttpTransport(){} // RVA: 0x641A460
        public void CreateBackgroundWorker(){} // RVA: 0x641A730
    }

    public class SentryScopeManager
    {
        public Sentry.Internal.ScopeStack.IScopeStackContainer <ScopeStackContainer>k__BackingField; // 0x10
        public Sentry.SentryOptions _options; // 0x18
        public System.Func`1<System.Collections.Generic.KeyValuePair`2<Sentry.Scope,Sentry.ISentryClient>[]> <NewStack>k__BackingField; // 0x20

        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x2F8380
        public void get_ScopeAndClientStack(){} // RVA: 0x641A890
        public void set_ScopeAndClientStack(){} // RVA: 0x641A980
        public void get_NewStack(){} // RVA: 0x30B0C0
        public void get_IsGlobalMode(){} // RVA: 0x641A9E0
        public void .ctor(){} // RVA: 0x641AA70
        public void GetCurrent(){} // RVA: 0x641ADD0
        public void ConfigureScope(){} // RVA: 0x641AE20
        public void ConfigureScopeAsync(){} // RVA: 0x641AFB0
        public void PushScope(){} // RVA: 0x283FA0 | overloaded x2
        public void RestoreScope(){} // RVA: 0x641B1B0
        public void BindClient(){} // RVA: 0x641B610
        public void Dispose(){} // RVA: 0x641B920
    }

    public class SentryStopwatch
    {
        public double StopwatchTicksPerTimeSpanTick;
        public double StopwatchTicksPerNs; // 0x8
        public long _startTimestamp; // 0x10
        public System.DateTimeOffset _startDateTimeOffset; // 0x18

        // ── Methods ──
        public void StartNew(){} // RVA: 0x641BC10
        public void get_StartDateTimeOffset(){} // RVA: 0x1F6F090
        public void get_CurrentDateTimeOffset(){} // RVA: 0x641BCF0
        public void Diff(){} // RVA: 0x641BDB0
        public void get_Elapsed(){} // RVA: 0x641BE00
        public void get_ElapsedNanoseconds(){} // RVA: 0x641BEF0
        public void .cctor(){} // RVA: 0x641BFE0
    }

    public class SerializableExtensions
    {
        // ── Methods ──
        public void SerializeToStringAsync(){} // RVA: 0x641C0A0
        public void SerializeToString(){} // RVA: 0x641C340
    }

    public class SettingLocator
    {
        public Sentry.SentryOptions _options; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x641D1F0
        public void get_AssemblyForAttributes(){} // RVA: 0x2E07C0
        public void set_AssemblyForAttributes(){} // RVA: 0x343E80
        public void GetEnvironmentVariable(){} // RVA: 0x641D2B0
        public void GetDsn(){} // RVA: 0x641D2C0
        public void GetEnvironment(){} // RVA: 0x641D410 | overloaded x2
        public void GetRelease(){} // RVA: 0x641D540
    }

    public class Signal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x641D730
        public void Release(){} // RVA: 0x641D890
        public void WaitAsync(){} // RVA: 0x641DA30
        public void Dispose(){} // RVA: 0x641DA60
    }

    public class StringOrRegex
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void op_Implicit(){} // RVA: 0x641DB10 | overloaded x2
        public void ToString(){} // RVA: 0x641DBA0
        public void Equals(){} // RVA: 0x641DC10
        public void GetHashCode(){} // RVA: 0x1EBC800
    }

    public class StringOrRegexExtensions
    {
        // ── Methods ──
        public void MatchesAny(){} // RVA: 0x641DD10
    }

    public class SynchronizedRandomValuesFactory
    {
        public System.Threading.AsyncLocal`1<System.Random> LocalRandom;

        // ── Methods ──
        public void get_Random(){} // RVA: 0x641DF10
        public void NextInt(){} // RVA: 0x641E0B0 | overloaded x2
        public void NextDouble(){} // RVA: 0x641E130
        public void NextBytes(){} // RVA: 0x641E1A0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x641E210
    }

    public class TcpPing : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x641E2D0
        public void IsAvailableAsync(){} // RVA: 0x641E500
    }

    public class ThreadPoolInfo
    {
        public int <MinWorkerThreads>k__BackingField; // 0x10
        public int <MinCompletionPortThreads>k__BackingField; // 0x14
        public int <MaxWorkerThreads>k__BackingField; // 0x18
        public int <MaxCompletionPortThreads>k__BackingField; // 0x1C
        public int <AvailableWorkerThreads>k__BackingField; // 0x20
        public int <AvailableCompletionPortThreads>k__BackingField; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x641EB90
        public void get_MinWorkerThreads(){} // RVA: 0x32A5C0
        public void get_MinCompletionPortThreads(){} // RVA: 0x8ABED0
        public void get_MaxWorkerThreads(){} // RVA: 0x5BED50
        public void get_MaxCompletionPortThreads(){} // RVA: 0x197C3B0
        public void get_AvailableWorkerThreads(){} // RVA: 0x760030
        public void get_AvailableCompletionPortThreads(){} // RVA: 0xCEF5B0
        public void WriteTo(){} // RVA: 0x641EBC0
    }

    public class ThreadsafeCounterDictionary`1
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<T,CounterItem<T>> _items;

        // ── Methods ──
        public void Add(){} // RVA: 0x283FA0
        public void Increment(){} // RVA: 0x283FA0
        public void ReadAndReset(){} // RVA: 0x283FA0
        public void ReadAllAndReset(){} // RVA: 0xCD60
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void get_Count(){} // RVA: 0xD840
        public void ContainsKey(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void get_Keys(){} // RVA: 0xCD60
        public void get_Values(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24A50
    }

}