// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal
// Classes: 97
// Methods: 629

namespace ThirdParty.Sentry.Sentry.Internal
{
    public class AotHelper
    {
        // ── Methods ──
        public void get_IsTrimmed(){} // RVA: 0x7FFAF8EA85D0
        public void .cctor(){} // RVA: 0x7FFAF8EA8630
    }

    public class AppDomainAdapter
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF8EA86E0
        public void .ctor(){} // RVA: 0x7FFAF8EA8740
        public void add_UnhandledException(){} // RVA: 0x7FFAF8EA8940
        public void remove_UnhandledException(){} // RVA: 0x7FFAF8EA8A30
        public void add_ProcessExit(){} // RVA: 0x7FFAF8EA8B20
        public void remove_ProcessExit(){} // RVA: 0x7FFAF8EA8C10
        public void add_UnobservedTaskException(){} // RVA: 0x7FFAF8EA8D00
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFAF8EA8E00
        public void OnProcessExit(){} // RVA: 0x7FFAF7975180
        public void OnUnhandledException(){} // RVA: 0x7FFAF8EA8F00
        public void OnUnobservedTaskException(){} // RVA: 0x7FFAF8EA8F20
        public void .cctor(){} // RVA: 0x7FFAF8EA8F40
    }

    public class ApplicationVersionLocator
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7FFAF8EA8FF0
    }

    public class AutoClearingList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2ADA620
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void Contains(){} // RVA: 0x7FFAF2D33FA0
        public void CopyTo(){} // RVA: 0x7FFAF2ADBAA0
        public void Remove(){} // RVA: 0x7FFAF2D33FA0
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2ABDBE0
        public void IndexOf(){} // RVA: 0x7FFAF2D33FA0
        public void Insert(){} // RVA: 0x7FFAF2D33FA0
        public void RemoveAt(){} // RVA: 0x7FFAF2AD4FA0
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void set_Item(){} // RVA: 0x7FFAF2D33FA0
    }

    public class AutoClearingList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF802B770
        public void Add(){} // RVA: 0x7FFAF802B880
        public void GetEnumerator(){} // RVA: 0x7FFAF5DD6E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF802B950
        public void Clear(){} // RVA: 0x7FFAF802B9A0
        public void Contains(){} // RVA: 0x7FFAF802B9F0
        public void CopyTo(){} // RVA: 0x7FFAF802BA50
        public void Remove(){} // RVA: 0x7FFAF802BAC0
        public void get_Count(){} // RVA: 0x7FFAF624A400
        public void get_IsReadOnly(){} // RVA: 0x7FFAF802BB20
        public void IndexOf(){} // RVA: 0x7FFAF802BB70
        public void Insert(){} // RVA: 0x7FFAF802BBD0
        public void RemoveAt(){} // RVA: 0x7FFAF802BCB0
        public void get_Item(){} // RVA: 0x7FFAF802BD10
        public void set_Item(){} // RVA: 0x7FFAF802BD70
    }

    public class BackgroundWorker
    {
        // ── Methods ──
        public void add_OnFlushObjectReceived(){} // RVA: 0x7FFAF8EA9100
        public void remove_OnFlushObjectReceived(){} // RVA: 0x7FFAF8EA91F0
        public void get_WorkerTask(){} // RVA: 0x7FFAF2E2E0E0
        public void get_QueuedItems(){} // RVA: 0x7FFAF8EA92E0
        public void .ctor(){} // RVA: 0x7FFAF8EA9330
        public void EnqueueEnvelope(){} // RVA: 0x7FFAF8EA97D0 | overloaded x2
        public void ProcessQueuedItems(){} // RVA: 0x7FFAF8EA9B40
        public void DoWorkAsync(){} // RVA: 0x7FFAF8EA9B60
        public void FlushAsync(){} // RVA: 0x7FFAF8EA9D30
        public void DoFlushAsync(){} // RVA: 0x7FFAF8EA9F10
        public void SendFinalClientReportAsync(){} // RVA: 0x7FFAF8EAA130
        public void Dispose(){} // RVA: 0x7FFAF8EAA340
    }

    public class ClientReport
    {
        // ── Methods ──
        public void get_Timestamp(){} // RVA: 0x7FFAF441ABE0
        public void get_DiscardedEvents(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF6EE7830
        public void WriteTo(){} // RVA: 0x7FFAF8EAE9F0
        public void FromJson(){} // RVA: 0x7FFAF8EAF6C0
    }

    public class ClientReportRecorder
    {
        // ── Methods ──
        public void get_DiscardedEvents(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF8EB05A0
        public void RecordDiscardedEvent(){} // RVA: 0x7FFAF8EB0890
        public void GenerateClientReport(){} // RVA: 0x7FFAF8EB0A10
        public void Load(){} // RVA: 0x7FFAF8EB0CC0
    }

    public class ConcurrentQueueLite`1
    {
        // ── Methods ──
        public void Enqueue(){} // RVA: 0x7FFAF2D33FA0
        public void TryDequeue(){} // RVA: 0x7FFAF2ABDE40
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void get_IsEmpty(){} // RVA: 0x7FFAF2ABDBE0
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void TryPeek(){} // RVA: 0x7FFAF2ABDE40
        public void ToArray(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class Constants
    {
    }

    public class ContextWriter
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAF8EB1060
        public void WriteScope(){}
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DataCategory
    {
        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x7FFAF4584690
        public void .ctor(){} // RVA: 0x7FFAF3ABA2F0
        public void CompareTo(){} // RVA: 0x7FFAF8EB1F80 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAF8EB2070 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8EB2140
        public void ToString(){} // RVA: 0x7FFAF4584690
        public void .cctor(){} // RVA: 0x7FFAF8EB2170
    }

    public class DebugStackTrace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EB2990
        public void get_DebugImages(){} // RVA: 0x7FFAF2F476A0
        public void Create(){} // RVA: 0x7FFAF8EB2CB0 | overloaded x2
        public void MergeDebugImagesInto(){} // RVA: 0x7FFAF8EB3250
        public void CreateFrames(){} // RVA: 0x7FFAF8EB3B70
        public void TryCreateManagedFrame(){} // RVA: 0x7FFAF8EB3CF0
        public void CreateFrame(){} // RVA: 0x7FFAF8EB4460
        public void GetRelativeAddressMode(){} // RVA: 0x7FFAF8EB4660
        public void DemangleAsyncFunctionName(){} // RVA: 0x7FFAF8EB4700
        public void DemangleAnonymousFunction(){} // RVA: 0x7FFAF8EB4980
        public void DemangleLambdaReturnType(){} // RVA: 0x7FFAF8EB4B60
        public void TryReadAssemblyFromDisk(){} // RVA: 0x7FFAF8EB4D10
        public void AddManagedModuleDebugImage(){} // RVA: 0x7FFAF8EB4F40
        public void GetManagedModuleDebugImage(){} // RVA: 0x7FFAF8EB5170
        public void .cctor(){} // RVA: 0x7FFAF8EB55F0
    }

    public class DelegateEventProcessor : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Process(){} // RVA: 0x7FFAF533D780
    }

    public class DelegateTransactionProcessor : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Process(){} // RVA: 0x7FFAF533D780
    }

    public class DelimitedPrefixOrPatternMatcher : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EB6650
        public void IsMatch(){} // RVA: 0x7FFAF8EB6660
    }

    public class DiscardReason
    {
        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x7FFAF4584690
        public void .ctor(){} // RVA: 0x7FFAF3ABA2F0
        public void WithCategory(){} // RVA: 0x7FFAF8EB6970
        public void CompareTo(){} // RVA: 0x7FFAF8EB69A0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAF8EB6A90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8EB2140
        public void ToString(){} // RVA: 0x7FFAF4584690
        public void .cctor(){} // RVA: 0x7FFAF8EB6B60
    }

    public class DiscardReasonWithCategory
    {
        // ── Methods ──
        public void get_Reason(){} // RVA: 0x7FFAF4584690
        public void get_Category(){} // RVA: 0x7FFAF44189C0
        public void .ctor(){} // RVA: 0x7FFAF6278AF0 | overloaded x2
        public void CompareTo(){} // RVA: 0x7FFAF8EB73B0 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAF8EB75A0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8EB7640
        public void ToString(){} // RVA: 0x7FFAF8EB7710
    }

    public class Disposable
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Dispose(){} // RVA: 0x7FFAF3D31E30
        public void Create(){} // RVA: 0x7FFAF8EB77F0
    }

    public class DuplicateEventDetectionEventProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EB7880
        public void Process(){} // RVA: 0x7FFAF8EB79A0
        public void IsDuplicate(){} // RVA: 0x7FFAF8EB7B50
    }

    public class Enricher
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EB7F80
        public void Apply(){} // RVA: 0x7FFAF8EB8A70 | overloaded x2
    }

    public class ExceptionHandlingSynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EB8E20
        public void Post(){} // RVA: 0x7FFAF8EB8ED0
    }

    public class ExceptionTypeFilter`1
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFAF2ABDE40
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class FileSystemBase
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x7FFAF8EB9190 | overloaded x3
        public void DirectoryExists(){} // RVA: 0x7FFAF8EB9220
        public void FileExists(){} // RVA: 0x7FFAF8EB9230
        public void GetFileCreationTime(){} // RVA: 0x7FFAF8EB9240
        public void ReadAllTextFromFile(){} // RVA: 0x7FFAF8EB93B0
        public void OpenFileForReading(){} // RVA: 0x7FFAF8EB9490
        public void CreateDirectory(){} // RVA: 0x7FFAF2ABDE40
        public void DeleteDirectory(){}
        public void CreateFileForWriting(){} // RVA: 0x7FFAF2AC1120
        public void WriteAllTextToFile(){} // RVA: 0x7FFAF2AC1120
        public void MoveFile(){}
        public void DeleteFile(){} // RVA: 0x7FFAF2ABDE40
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class GrowableArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4FA0
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void set_Item(){} // RVA: 0x7FFAF2D33FA0
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void Reserve(){} // RVA: 0x7FFAF2AD4FA0
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void AddRange(){} // RVA: 0x7FFAF2AD4B10
        public void Insert(){} // RVA: 0x7FFAF2D33FA0
        public void RemoveRange(){} // RVA: 0x7FFAF2AD6EE0
        public void get_Empty(){} // RVA: 0x7FFAF2ABDBE0
        public void Trim(){} // RVA: 0x7FFAF2AD4FA0
        public void get_EmptyCapacity(){} // RVA: 0x7FFAF2ABDBE0
        public void ToString(){} // RVA: 0x7FFAF2ABCD60
        public void Foreach(){} // RVA: 0x7FFAF2D33FA0
        public void Search(){} // RVA: 0x7FFAF2D33FA0
        public void get_UnderlyingArray(){} // RVA: 0x7FFAF2ABCD60
        public void Realloc(){} // RVA: 0x7FFAF2AD4FA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
    }

    public class GrowableArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5F62BE0
        public void get_Item(){} // RVA: 0x7FFAF5F64360
        public void set_Item(){} // RVA: 0x7FFAF5F64390
        public void get_Count(){} // RVA: 0x7FFAF4959890
        public void Reserve(){} // RVA: 0x7FFAF5F62D60
        public void Clear(){} // RVA: 0x7FFAF5F62DB0
        public void Add(){} // RVA: 0x7FFAF5F643B0
        public void AddRange(){} // RVA: 0x7FFAF5F64430
        public void Insert(){} // RVA: 0x7FFAF5F646C0
        public void RemoveRange(){} // RVA: 0x7FFAF5F64820
        public void get_Empty(){} // RVA: 0x7FFAF5F63520
        public void Trim(){} // RVA: 0x7FFAF5F63530
        public void get_EmptyCapacity(){} // RVA: 0x7FFAF47D6810
        public void ToString(){} // RVA: 0x7FFAF5F64980
        public void Foreach(){} // RVA: 0x7FFAF2D33FA0
        public void Search(){} // RVA: 0x7FFAF2D33FA0
        public void get_UnderlyingArray(){} // RVA: 0x7FFAF4584690
        public void Realloc(){} // RVA: 0x7FFAF5F63A00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF5F63AD0
        public void GetEnumerator(){} // RVA: 0x7FFAF5F63AD0
    }

    public class GrowableArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5F62BE0
        public void get_Item(){} // RVA: 0x7FFAF5F64360
        public void set_Item(){} // RVA: 0x7FFAF5F64390
        public void get_Count(){} // RVA: 0x7FFAF4959890
        public void Reserve(){} // RVA: 0x7FFAF5F62D60
        public void Clear(){} // RVA: 0x7FFAF5F62DB0
        public void Add(){} // RVA: 0x7FFAF5F643B0
        public void AddRange(){} // RVA: 0x7FFAF5F64430
        public void Insert(){} // RVA: 0x7FFAF5F646C0
        public void RemoveRange(){} // RVA: 0x7FFAF5F64820
        public void get_Empty(){} // RVA: 0x7FFAF5F63520
        public void Trim(){} // RVA: 0x7FFAF5F63530
        public void get_EmptyCapacity(){} // RVA: 0x7FFAF47D6810
        public void ToString(){} // RVA: 0x7FFAF5F64980
        public void Foreach(){} // RVA: 0x7FFAF2D33FA0
        public void Search(){} // RVA: 0x7FFAF2D33FA0
        public void get_UnderlyingArray(){} // RVA: 0x7FFAF4584690
        public void Realloc(){} // RVA: 0x7FFAF5F63A00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF5F63AD0
        public void GetEnumerator(){} // RVA: 0x7FFAF5F63AD0
    }

    public class GrowableArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5F62BE0
        public void get_Item(){} // RVA: 0x7FFAF5F62C90
        public void set_Item(){} // RVA: 0x7FFAF5F62CD0
        public void get_Count(){} // RVA: 0x7FFAF4959890
        public void Reserve(){} // RVA: 0x7FFAF5F62D60
        public void Clear(){} // RVA: 0x7FFAF5F62DB0
        public void Add(){} // RVA: 0x7FFAF5F62DC0
        public void AddRange(){} // RVA: 0x7FFAF5F62EA0
        public void Insert(){} // RVA: 0x7FFAF5F631C0
        public void RemoveRange(){} // RVA: 0x7FFAF5F633B0
        public void get_Empty(){} // RVA: 0x7FFAF5F63520
        public void Trim(){} // RVA: 0x7FFAF5F63530
        public void get_EmptyCapacity(){} // RVA: 0x7FFAF47D6810
        public void ToString(){} // RVA: 0x7FFAF5F637C0
        public void Foreach(){} // RVA: 0x7FFAF2D33FA0
        public void Search(){} // RVA: 0x7FFAF2D33FA0
        public void get_UnderlyingArray(){} // RVA: 0x7FFAF4584690
        public void Realloc(){} // RVA: 0x7FFAF5F63A00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF5F63AD0
        public void GetEnumerator(){} // RVA: 0x7FFAF5F63AD0
    }

    public class GrowableArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5F62BE0
        public void get_Item(){} // RVA: 0x7FFAF5F63BB0
        public void set_Item(){} // RVA: 0x7FFAF5F63BE0
        public void get_Count(){} // RVA: 0x7FFAF4959890
        public void Reserve(){} // RVA: 0x7FFAF5F62D60
        public void Clear(){} // RVA: 0x7FFAF5F62DB0
        public void Add(){} // RVA: 0x7FFAF5F63C10
        public void AddRange(){} // RVA: 0x7FFAF5F63C90
        public void Insert(){} // RVA: 0x7FFAF5F63F30
        public void RemoveRange(){} // RVA: 0x7FFAF5F64040
        public void get_Empty(){} // RVA: 0x7FFAF5F63520
        public void Trim(){} // RVA: 0x7FFAF5F63530
        public void get_EmptyCapacity(){} // RVA: 0x7FFAF47D6810
        public void ToString(){} // RVA: 0x7FFAF5F64130
        public void Foreach(){} // RVA: 0x7FFAF2D33FA0
        public void Search(){} // RVA: 0x7FFAF2D33FA0
        public void get_UnderlyingArray(){} // RVA: 0x7FFAF4584690
        public void Realloc(){} // RVA: 0x7FFAF5F63A00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF5F63AD0
        public void GetEnumerator(){} // RVA: 0x7FFAF5F63AD0
    }

    public class HashableGrowableArray`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4FA0
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void set_Item(){} // RVA: 0x7FFAF2D33FA0
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void Seal(){} // RVA: 0x7FFAF2AD4A50
        public void Trim(){} // RVA: 0x7FFAF2AD4FA0
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void GetHashCode(){} // RVA: 0x7FFAF2ABD840
        public void Equals(){} // RVA: 0x7FFAF2ABDE40 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
    }

    public class Hub
    {
        // ── Methods ──
        public void get_ExceptionToSpanMap(){} // RVA: 0x7FFAF2E0A740
        public void get_ScopeManager(){} // RVA: 0x7FFAF2E08730
        public void get_Metrics(){} // RVA: 0x7FFAF2E2E0E0
        public void get_IsEnabled(){} // RVA: 0x7FFAF8EB94A0
        public void get_Options(){} // RVA: 0x7FFAF2DBB130
        public void get_CurrentScope(){} // RVA: 0x7FFAF8EB94B0
        public void get_CurrentClient(){} // RVA: 0x7FFAF8EB9580
        public void .ctor(){} // RVA: 0x7FFAF8EB9650
        public void ConfigureScope(){} // RVA: 0x7FFAF8EBA050
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAF8EBA110
        public void PushScope(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void RestoreScope(){} // RVA: 0x7FFAF8EBA370
        public void BindClient(){} // RVA: 0x7FFAF8EBA440
        public void StartTransaction(){} // RVA: 0x7FFAF8EBA4C0 | overloaded x2
        public void BindException(){} // RVA: 0x7FFAF8EBAAB0
        public void GetSpan(){} // RVA: 0x7FFAF8EBAC40
        public void GetTraceHeader(){} // RVA: 0x7FFAF8EBAC70
        public void GetBaggage(){} // RVA: 0x7FFAF8EBAD40
        public void ContinueTrace(){} // RVA: 0x7FFAF8EBAFB0 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFAF8EBB340
        public void PauseSession(){} // RVA: 0x7FFAF8EBB4C0
        public void ResumeSession(){} // RVA: 0x7FFAF8EBB6D0
        public void EndSession(){} // RVA: 0x7FFAF8EBBC10 | overloaded x2
        public void GetLinkedSpan(){} // RVA: 0x7FFAF8EBBC90
        public void ApplyTraceContextToEvent(){} // RVA: 0x7FFAF8EBC020 | overloaded x2
        public void CaptureEnvelope(){} // RVA: 0x7FFAF8EBC210
        public void AddBreadcrumbForException(){} // RVA: 0x7FFAF8EBC280
        public void CaptureEvent(){} // RVA: 0x7FFAF8EBC7D0 | overloaded x4
        public void CaptureUserFeedback(){} // RVA: 0x7FFAF8EBCC10
        public void CaptureTransaction(){} // RVA: 0x7FFAF8EBCD60 | overloaded x2
        public void CaptureMetrics(){} // RVA: 0x7FFAF8EBCE60
        public void CaptureCodeLocations(){} // RVA: 0x7FFAF8EBD1F0
        public void StartSpan(){} // RVA: 0x7FFAF8EBD4A0
        public void CaptureSession(){} // RVA: 0x7FFAF8EBD650
        public void CaptureCheckIn(){} // RVA: 0x7FFAF8EBD780
        public void FlushAsync(){} // RVA: 0x7FFAF8EBDA10
        public void Dispose(){} // RVA: 0x7FFAF8EBDBE0
        public void get_LastEventId(){} // RVA: 0x7FFAF8EBDD90
    }

    public class IAppDomain
    {
        // ── Methods ──
        public void add_UnhandledException(){} // RVA: 0x7FFAF2AD4B10
        public void remove_UnhandledException(){} // RVA: 0x7FFAF2AD4B10
        public void add_ProcessExit(){} // RVA: 0x7FFAF2AD4B10
        public void remove_ProcessExit(){} // RVA: 0x7FFAF2AD4B10
        public void add_UnobservedTaskException(){} // RVA: 0x7FFAF2AD4B10
        public void remove_UnobservedTaskException(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IClientReportRecorder
    {
        // ── Methods ──
        public void RecordDiscardedEvent(){}
        public void GenerateClientReport(){} // RVA: 0x7FFAF2ABCD60
        public void Load(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ICloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7FFAF2D33FA0
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
        public void get_Value(){} // RVA: 0x7FFAF2ABCD60
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
        public void EnumerateFiles(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x3
        public void DirectoryExists(){} // RVA: 0x7FFAF2ABDE40
        public void FileExists(){} // RVA: 0x7FFAF2ABDE40
        public void GetFileCreationTime(){}
        public void ReadAllTextFromFile(){} // RVA: 0x7FFAF2ABCE10
        public void OpenFileForReading(){} // RVA: 0x7FFAF2ABCE10
        public void CreateDirectory(){} // RVA: 0x7FFAF2ABDE40
        public void DeleteDirectory(){}
        public void CreateFileForWriting(){} // RVA: 0x7FFAF2AC1120
        public void WriteAllTextToFile(){} // RVA: 0x7FFAF2AC1120
        public void MoveFile(){}
        public void DeleteFile(){} // RVA: 0x7FFAF2ABDE40
    }

    public class IInternalScopeManager
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7FFAF2ABC770
        public void RestoreScope(){} // RVA: 0x7FFAF2AD4B10
        public void get_ScopeStackContainer(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IPing
    {
        // ── Methods ──
        public void IsAvailableAsync(){}
    }

    public class IStackFrame
    {
        // ── Methods ──
        public void get_Frame(){} // RVA: 0x7FFAF2ABCD60
        public void GetNativeImageBase(){} // RVA: 0x7FFAF2ABCD60
        public void GetNativeIP(){} // RVA: 0x7FFAF2ABCD60
        public void HasNativeImage(){} // RVA: 0x7FFAF2ABDBE0
        public void GetFileColumnNumber(){} // RVA: 0x7FFAF2ABD840
        public void GetFileLineNumber(){} // RVA: 0x7FFAF2ABD840
        public void GetFileName(){} // RVA: 0x7FFAF2ABCD60
        public void GetILOffset(){} // RVA: 0x7FFAF2ABD840
        public void GetMethod(){} // RVA: 0x7FFAF2ABCD60
        public void ToString(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IStringOrRegexMatcher
    {
        // ── Methods ──
        public void IsMatch(){} // RVA: 0x7FFAF2AC1120
    }

    public class ITransactionProfiler
    {
        // ── Methods ──
        public void Finish(){} // RVA: 0x7FFAF2AD4A50
        public void Collect(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ITransactionProfilerFactory
    {
        // ── Methods ──
        public void Start(){}
    }

    public class IUpdatable
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IUpdatable`1
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x7FFAF2D33FA0
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
        public void .ctor(){} // RVA: 0x7FFAF8EBE690
        public void TryGetInstallationId(){} // RVA: 0x7FFAF8EBE790
        public void TryGetPersistentInstallationId(){} // RVA: 0x7FFAF8EBEAA0
        public void TryGetHardwareInstallationId(){} // RVA: 0x7FFAF8EBF0F0
        public void GetMachineNameInstallationId(){} // RVA: 0x7FFAF8EBF4E0
    }

    public class Json
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void Load(){} // RVA: 0x7FFAF2D33FA0
    }

    public class Lock
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EBF650
        public void AcquireAsync(){} // RVA: 0x7FFAF8EBF6F0
        public void Dispose(){} // RVA: 0x7FFAF8EBF8E0
    }

    public class MainExceptionProcessor
    {
        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void Process(){} // RVA: 0x7FFAF8EBFD30
        public void CreateSentryExceptions(){} // RVA: 0x7FFAF8EBFE50
        public void WalkExceptions(){} // RVA: 0x7FFAF8EC00A0 | overloaded x2
        public void MoveExceptionDataToEvent(){} // RVA: 0x7FFAF8EC0280
        public void BuildSentryException(){} // RVA: 0x7FFAF8EC0D70
        public void GetMechanism(){} // RVA: 0x7FFAF8EC1110
    }

    public class MainSentryEventProcessor
    {
        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Release(){} // RVA: 0x7FFAF8EC2840
        public void get_Distribution(){} // RVA: 0x7FFAF8EC2870
        public void .ctor(){} // RVA: 0x7FFAF8EC2890
        public void Process(){} // RVA: 0x7FFAF8EC2A10
        public void AddMemoryInfo(){} // RVA: 0x7FFAF2D8D310
        public void AddThreadPoolInfo(){} // RVA: 0x7FFAF8EC3AA0
        public void CultureInfoToDictionary(){} // RVA: 0x7FFAF8EC3BF0
    }

    public class ModuleExtensions
    {
        // ── Methods ──
        public void GetNameOrScopeName(){} // RVA: 0x7FFAF8EC3F20
    }

    public class NoOpSpan
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF8EC4010
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_SpanId(){} // RVA: 0x7FFAF8EC4070
        public void get_ParentSpanId(){} // RVA: 0x7FFAF8EC40D0
        public void get_TraceId(){} // RVA: 0x7FFAF8EC4150
        public void get_IsSampled(){} // RVA: 0x7FFAF2FC9240
        public void get_Tags(){} // RVA: 0x7FFAF8EC41B0
        public void get_Extra(){} // RVA: 0x7FFAF8EC4210
        public void get_StartTimestamp(){} // RVA: 0x7FFAF3FD9E90
        public void get_EndTimestamp(){} // RVA: 0x7FFAF69EED10
        public void get_IsFinished(){} // RVA: 0x7FFAF2D8D320
        public void get_Operation(){} // RVA: 0x7FFAF8EC4270
        public void set_Operation(){} // RVA: 0x7FFAF2D8D310
        public void get_Description(){} // RVA: 0x7FFAF2FC9240
        public void set_Description(){} // RVA: 0x7FFAF2D8D310
        public void get_Status(){} // RVA: 0x7FFAF2FC9240
        public void set_Status(){} // RVA: 0x7FFAF2D8D310
        public void StartChild(){} // RVA: 0x7FFAF44EF520
        public void Finish(){} // RVA: 0x7FFAF2D8D310 | overloaded x4
        public void SetTag(){} // RVA: 0x7FFAF2D8D310
        public void UnsetTag(){} // RVA: 0x7FFAF2D8D310
        public void SetExtra(){} // RVA: 0x7FFAF2D8D310
        public void GetTraceHeader(){} // RVA: 0x7FFAF8EC42B0
        public void get_Measurements(){} // RVA: 0x7FFAF8EC4310
        public void SetMeasurement(){} // RVA: 0x7FFAF2D8D310
        public void get_Origin(){} // RVA: 0x7FFAF2DA8380
        public void set_Origin(){} // RVA: 0x7FFAF2D8EE30
        public void .cctor(){} // RVA: 0x7FFAF8EC4370
    }

    public class NoOpTransaction
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF8EC4410
        public void .ctor(){} // RVA: 0x7FFAF8EC4470
        public void get_Sdk(){} // RVA: 0x7FFAF8EC44C0
        public void get_Name(){} // RVA: 0x7FFAF8EC4510
        public void set_Name(){} // RVA: 0x7FFAF2D8D310
        public void get_IsParentSampled(){} // RVA: 0x7FFAF2FC9240
        public void set_IsParentSampled(){} // RVA: 0x7FFAF2D8D310
        public void get_NameSource(){} // RVA: 0x7FFAF2FC9240
        public void get_Distribution(){} // RVA: 0x7FFAF8EC4550
        public void set_Distribution(){} // RVA: 0x7FFAF2D8D310
        public void get_Level(){} // RVA: 0x7FFAF2FC9240
        public void set_Level(){} // RVA: 0x7FFAF2D8D310
        public void get_Request(){} // RVA: 0x7FFAF8EC4590
        public void set_Request(){} // RVA: 0x7FFAF2D8D310
        public void get_Contexts(){} // RVA: 0x7FFAF8EC45D0
        public void set_Contexts(){} // RVA: 0x7FFAF2D8D310
        public void get_User(){} // RVA: 0x7FFAF8EC4620
        public void set_User(){} // RVA: 0x7FFAF2D8D310
        public void get_Platform(){} // RVA: 0x7FFAF2FC9240
        public void set_Platform(){} // RVA: 0x7FFAF2D8D310
        public void get_Release(){} // RVA: 0x7FFAF2FC9240
        public void set_Release(){} // RVA: 0x7FFAF2D8D310
        public void get_Environment(){} // RVA: 0x7FFAF2FC9240
        public void set_Environment(){} // RVA: 0x7FFAF2D8D310
        public void get_TransactionName(){} // RVA: 0x7FFAF2FC9240
        public void set_TransactionName(){} // RVA: 0x7FFAF2D8D310
        public void get_Fingerprint(){} // RVA: 0x7FFAF8EC4660
        public void set_Fingerprint(){} // RVA: 0x7FFAF2D8D310
        public void get_Spans(){} // RVA: 0x7FFAF8EC46C0
        public void get_Breadcrumbs(){} // RVA: 0x7FFAF8EC4720
        public void GetLastActiveSpan(){} // RVA: 0x7FFAF2FC9240
        public void AddBreadcrumb(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8EC4780
    }

    public class ObjectExtensions
    {
        public object controlPath;

        // ── Methods ──
        public void get_Map(){} // RVA: 0x7FFAF8EC4860
        public void AssociatedProperties(){} // RVA: 0x7FFAF8EC48C0
        public void SetFused(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetFused(){} // RVA: 0x7FFAF2D33FA0
        public void .cctor(){} // RVA: 0x7FFAF8EC4B60
    }

    public class OriginHelper
    {
        // ── Methods ──
        public void IsValidOrigin(){} // RVA: 0x7FFAF8EC4D40
        public void TryParse(){} // RVA: 0x7FFAF8EC4DF0
        public void SetOrigin(){} // RVA: 0x7FFAF8EC4E50
        public void .cctor(){} // RVA: 0x7FFAF8EC5060
    }

    public class PartialStream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7FFAF8EC5140
        public void get_CanSeek(){} // RVA: 0x7FFAF8EC5170
        public void get_CanWrite(){} // RVA: 0x7FFAF2D8D320
        public void get_Length(){} // RVA: 0x7FFAF8EC51A0
        public void get_Position(){} // RVA: 0x7FFAF2E08730
        public void set_Position(){} // RVA: 0x7FFAF8EC5230
        public void .ctor(){} // RVA: 0x7FFAF8EC52E0
        public void ReadAsync(){} // RVA: 0x7FFAF8EC53B0
        public void Seek(){} // RVA: 0x7FFAF8EC5640
        public void Read(){} // RVA: 0x7FFAF8EC5770
        public void SetLength(){} // RVA: 0x7FFAF8EC58C0
        public void Write(){} // RVA: 0x7FFAF8EC5900
        public void Flush(){} // RVA: 0x7FFAF8EC5940
    }

    public class PiiExtensions
    {
        // ── Methods ──
        public void RedactUrl(){} // RVA: 0x7FFAF8EC5E50
        public void RedactAuth(){} // RVA: 0x7FFAF8EC60C0
        public void .cctor(){} // RVA: 0x7FFAF8EC63A0
    }

    public class PollingNetworkStatusListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EC68B0 | overloaded x2
        public void get_LazyPing(){} // RVA: 0x7FFAF8EC6AD0
        public void get_Ping(){} // RVA: 0x7FFAF8EC6BB0
        public void get_Online(){} // RVA: 0x7FFAF8EC6CC0
        public void set_Online(){} // RVA: 0x7FFAF8EC6CD0
        public void WaitForNetworkOnlineAsync(){} // RVA: 0x7FFAF8EC6CE0
        public void <get_LazyPing>b__8_0(){} // RVA: 0x7FFAF8EC6EF0
    }

    public class PooledBuffer`1
    {
        // ── Methods ──
        public void get_Array(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2AD4FA0
        public void Dispose(){} // RVA: 0x7FFAF2AD4A50
    }

    public class PooledBuffer`1
    {
        // ── Methods ──
        public void get_Array(){} // RVA: 0x7FFAF4584690
        public void .ctor(){} // RVA: 0x7FFAF68A6720
        public void Dispose(){} // RVA: 0x7FFAF68A67D0
    }

    public class PrefixOrPatternMatcher : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void IsMatch(){} // RVA: 0x7FFAF8EC7910
    }

    public class ProcessInfo
    {
        // ── Methods ──
        public void get_StartupTime(){} // RVA: 0x7FFAF4A40220
        public void set_StartupTime(){} // RVA: 0x7FFAF4A40200
        public void get_BootTime(){} // RVA: 0x7FFAF4AFE840
        public void get_PreciseAppStartupTask(){} // RVA: 0x7FFAF8EC7A80
        public void set_PreciseAppStartupTask(){} // RVA: 0x7FFAF8EC7A90
        public void GetId(){} // RVA: 0x7FFAF8EC7AF0
        public void GetCurrentProcessId(){} // RVA: 0x7FFAF8EC7B50
        public void .ctor(){} // RVA: 0x7FFAF8EC7C30
        public void GetStartupTime(){} // RVA: 0x7FFAF8EC84C0
        public void ApplicationIsActivated(){} // RVA: 0x7FFAF8EC8680
        public void GetForegroundWindow(){} // RVA: 0x7FFAF8EC8A50
        public void GetWindowThreadProcessId(){} // RVA: 0x7FFAF8EC8AC0
    }

    public class RandomValuesFactory
    {
        // ── Methods ──
        public void NextInt(){} // RVA: 0x7FFAF2AC4170 | overloaded x2
        public void NextDouble(){} // RVA: 0x7FFAF2AC2A40
        public void NextBytes(){} // RVA: 0x7FFAF2AD4B10
        public void NextBool(){} // RVA: 0x7FFAF8EC8D80
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ReadOnlyFileSystem
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7FFAF2D8D320
        public void DeleteDirectory(){} // RVA: 0x7FFAF2D8D320
        public void CreateFileForWriting(){} // RVA: 0x7FFAF8EC8DE0
        public void WriteAllTextToFile(){} // RVA: 0x7FFAF2D8D320
        public void MoveFile(){} // RVA: 0x7FFAF2D8D320
        public void DeleteFile(){} // RVA: 0x7FFAF2D8D320
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ReadWriteFileSystem
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7FFAF8EC8E80
        public void DeleteDirectory(){} // RVA: 0x7FFAF8EC8EB0
        public void CreateFileForWriting(){} // RVA: 0x7FFAF8EC8EE0
        public void WriteAllTextToFile(){} // RVA: 0x7FFAF8EC8FC0
        public void MoveFile(){} // RVA: 0x7FFAF8EC8FF0
        public void DeleteFile(){} // RVA: 0x7FFAF8EC9060
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class RealStackFrame
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Frame(){} // RVA: 0x7FFAF2DA8380
        public void ToString(){} // RVA: 0x7FFAF3AFC4B0
        public void GetFileColumnNumber(){} // RVA: 0x7FFAF32A0250
        public void GetFileLineNumber(){} // RVA: 0x7FFAF32A01B0
        public void GetFileName(){} // RVA: 0x7FFAF32A02E0
        public void GetILOffset(){} // RVA: 0x7FFAF8B1CEF0
        public void GetMethod(){} // RVA: 0x7FFAF325C2C0
        public void GetNativeImageBase(){} // RVA: 0x7FFAF2FC9240
        public void GetNativeIP(){} // RVA: 0x7FFAF2FC9240
        public void HasNativeImage(){} // RVA: 0x7FFAF2D8D320
    }

    public class ScopeObserver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877CD00
        public void AddBreadcrumb(){} // RVA: 0x7FFAF8EC9150
        public void AddBreadcrumbImpl(){} // RVA: 0x7FFAF2AD4B10
        public void SetExtra(){} // RVA: 0x7FFAF8EC9360
        public void SetExtraImpl(){} // RVA: 0x7FFAF2ADDC60
        public void SetTag(){} // RVA: 0x7FFAF8EC96C0
        public void SetTagImpl(){} // RVA: 0x7FFAF2ADDC60
        public void UnsetTag(){} // RVA: 0x7FFAF8EC98A0
        public void UnsetTagImpl(){} // RVA: 0x7FFAF2AD4B10
        public void SetUser(){} // RVA: 0x7FFAF8EC9A40
        public void SetUserImpl(){} // RVA: 0x7FFAF2AD4B10
        public void UnsetUserImpl(){} // RVA: 0x7FFAF2AD4A50
    }

    public class SdkComposer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8EC9D00
        public void CreateTransport(){} // RVA: 0x7FFAF8EC9E10
        public void CreateHttpTransport(){} // RVA: 0x7FFAF8ECA460
        public void CreateBackgroundWorker(){} // RVA: 0x7FFAF8ECA730
    }

    public class SentryScopeManager
    {
        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7FFAF2DA8380
        public void get_ScopeAndClientStack(){} // RVA: 0x7FFAF8ECA890
        public void set_ScopeAndClientStack(){} // RVA: 0x7FFAF8ECA980
        public void get_NewStack(){} // RVA: 0x7FFAF2DBB0C0
        public void get_IsGlobalMode(){} // RVA: 0x7FFAF8ECA9E0
        public void .ctor(){} // RVA: 0x7FFAF8ECAA70
        public void GetCurrent(){} // RVA: 0x7FFAF8ECADD0
        public void ConfigureScope(){} // RVA: 0x7FFAF8ECAE20
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAF8ECAFB0
        public void PushScope(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void RestoreScope(){} // RVA: 0x7FFAF8ECB1B0
        public void BindClient(){} // RVA: 0x7FFAF8ECB610
        public void Dispose(){} // RVA: 0x7FFAF8ECB920
    }

    public class SentryStopwatch
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7FFAF8ECBC10
        public void get_StartDateTimeOffset(){} // RVA: 0x7FFAF4A1F090
        public void get_CurrentDateTimeOffset(){} // RVA: 0x7FFAF8ECBCF0
        public void Diff(){} // RVA: 0x7FFAF8ECBDB0
        public void get_Elapsed(){} // RVA: 0x7FFAF8ECBE00
        public void get_ElapsedNanoseconds(){} // RVA: 0x7FFAF8ECBEF0
        public void .cctor(){} // RVA: 0x7FFAF8ECBFE0
    }

    public class SerializableExtensions
    {
        // ── Methods ──
        public void SerializeToStringAsync(){} // RVA: 0x7FFAF8ECC0A0
        public void SerializeToString(){} // RVA: 0x7FFAF8ECC340
    }

    public class SettingLocator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8ECD1F0
        public void get_AssemblyForAttributes(){} // RVA: 0x7FFAF2D907C0
        public void set_AssemblyForAttributes(){} // RVA: 0x7FFAF2DF3E80
        public void GetEnvironmentVariable(){} // RVA: 0x7FFAF8ECD2B0
        public void GetDsn(){} // RVA: 0x7FFAF8ECD2C0
        public void GetEnvironment(){} // RVA: 0x7FFAF8ECD410 | overloaded x2
        public void GetRelease(){} // RVA: 0x7FFAF8ECD540
    }

    public class Signal
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8ECD730
        public void Release(){} // RVA: 0x7FFAF8ECD890
        public void WaitAsync(){} // RVA: 0x7FFAF8ECDA30
        public void Dispose(){} // RVA: 0x7FFAF8ECDA60
    }

    public class StringOrRegex
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAF8ECDB10 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF8ECDBA0
        public void Equals(){} // RVA: 0x7FFAF8ECDC10
        public void GetHashCode(){} // RVA: 0x7FFAF496C800
    }

    public class StringOrRegexExtensions
    {
        // ── Methods ──
        public void MatchesAny(){} // RVA: 0x7FFAF8ECDD10
    }

    public class SynchronizedRandomValuesFactory
    {
        // ── Methods ──
        public void get_Random(){} // RVA: 0x7FFAF8ECDF10
        public void NextInt(){} // RVA: 0x7FFAF8ECE0B0 | overloaded x2
        public void NextDouble(){} // RVA: 0x7FFAF8ECE130
        public void NextBytes(){} // RVA: 0x7FFAF8ECE1A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8ECE210
    }

    public class TcpPing : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8ECE2D0
        public void IsAvailableAsync(){} // RVA: 0x7FFAF8ECE500
    }

    public class ThreadPoolInfo
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8ECEB90
        public void get_MinWorkerThreads(){} // RVA: 0x7FFAF2DDA5C0
        public void get_MinCompletionPortThreads(){} // RVA: 0x7FFAF335BED0
        public void get_MaxWorkerThreads(){} // RVA: 0x7FFAF306ED50
        public void get_MaxCompletionPortThreads(){} // RVA: 0x7FFAF442C3B0
        public void get_AvailableWorkerThreads(){} // RVA: 0x7FFAF3210030
        public void get_AvailableCompletionPortThreads(){} // RVA: 0x7FFAF379F5B0
        public void WriteTo(){} // RVA: 0x7FFAF8ECEBC0
    }

    public class ThreadsafeCounterDictionary`1
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void Increment(){} // RVA: 0x7FFAF2D33FA0
        public void ReadAndReset(){} // RVA: 0x7FFAF2D33FA0
        public void ReadAllAndReset(){} // RVA: 0x7FFAF2ABCD60
        public void GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF2ABCD60
        public void get_Count(){} // RVA: 0x7FFAF2ABD840
        public void ContainsKey(){} // RVA: 0x7FFAF2D33FA0
        public void TryGetValue(){} // RVA: 0x7FFAF2D33FA0
        public void get_Item(){} // RVA: 0x7FFAF2D33FA0
        public void get_Keys(){} // RVA: 0x7FFAF2ABCD60
        public void get_Values(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

}