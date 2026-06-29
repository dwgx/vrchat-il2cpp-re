// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Internal
// Classes: 78
// Methods: 607

namespace ThirdParty.Sentry.Sentry.Internal
{
    public class AotHelper : Object
    {
        // ── Methods ──
        public void get_IsTrimmed(){} // RVA: 0x7AE1E6090
        public void .cctor(){} // RVA: 0x7AE1E60F0
    }

    public class AppDomainAdapter : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AE1E61A0
        public void .ctor(){} // RVA: 0x7AE1E6200
        public void add_UnhandledException(){} // RVA: 0x7AE1E6400
        public void remove_UnhandledException(){} // RVA: 0x7AE1E64F0
        public void add_ProcessExit(){} // RVA: 0x7AE1E65E0
        public void remove_ProcessExit(){} // RVA: 0x7AE1E66D0
        public void add_UnobservedTaskException(){} // RVA: 0x7AE1E67C0
        public void remove_UnobservedTaskException(){} // RVA: 0x7AE1E68D0
        public void OnProcessExit(){} // RVA: 0x7ACD587F0
        public void OnUnhandledException(){} // RVA: 0x7AE1E69E0
        public void OnUnobservedTaskException(){} // RVA: 0x7AE1E6A00
        public void .cctor(){} // RVA: 0x7AE1E6A20
    }

    public class ApplicationVersionLocator : Object
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7AE1E6AD0
    }

    public class AutoClearingList`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1D550
        public void Add(){} // RVA: 0x7A8051B10
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void Clear(){} // RVA: 0x7A7E18770
        public void Contains(){} // RVA: 0x7A8051B10
        public void CopyTo(){} // RVA: 0x7A7E1D590
        public void Remove(){} // RVA: 0x7A8051B10
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_IsReadOnly(){} // RVA: 0x7A7E01900
        public void IndexOf(){} // RVA: 0x7A8051B10
        public void Insert(){} // RVA: 0x7A8051B10
        public void RemoveAt(){} // RVA: 0x7A7E189D0
        public void get_Item(){} // RVA: 0x7A8051B10
        public void set_Item(){} // RVA: 0x7A8051B10
    }

    public class AutoClearingList`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD339B50
        public void Add(){} // RVA: 0x7AD339C60
        public void GetEnumerator(){} // RVA: 0x7AB11E7D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD339D30
        public void Clear(){} // RVA: 0x7AD339D80
        public void Contains(){} // RVA: 0x7AD339DD0
        public void CopyTo(){} // RVA: 0x7AD339E30
        public void Remove(){} // RVA: 0x7AD339EA0
        public void get_Count(){} // RVA: 0x7AB5867E0
        public void get_IsReadOnly(){} // RVA: 0x7AD339F00
        public void IndexOf(){} // RVA: 0x7AD339F50
        public void Insert(){} // RVA: 0x7AD339FB0
        public void RemoveAt(){} // RVA: 0x7AD33A090
        public void get_Item(){} // RVA: 0x7AD33A0F0
        public void set_Item(){} // RVA: 0x7AD33A150
    }

    public class BackgroundWorker : Object
    {
        // ── Methods ──
        public void add_OnFlushObjectReceived(){} // RVA: 0x7AE1E6BE0
        public void remove_OnFlushObjectReceived(){} // RVA: 0x7AE1E6CD0
        public void get_WorkerTask(){} // RVA: 0x7A8178B90
        public void get_QueuedItems(){} // RVA: 0x7AE1E6DC0
        public void .ctor(){} // RVA: 0x7AE1E6E10
        public void EnqueueEnvelope(){} // RVA: 0x7AE1E72C0
        public void ProcessQueuedItems(){} // RVA: 0x7AE1E7630
        public void DoWorkAsync(){} // RVA: 0x7AE1E7650
        public void FlushAsync(){} // RVA: 0x7AE1E7820
        public void DoFlushAsync(){} // RVA: 0x7AE1E7A00
        public void SendFinalClientReportAsync(){} // RVA: 0x7AE1E7C20
        public void Dispose(){} // RVA: 0x7AE1E7E30
    }

    public class ClientReport : Object
    {
        // ── Methods ──
        public void get_Timestamp(){} // RVA: 0x7A97277F0
        public void get_DiscardedEvents(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7AC226430
        public void WriteTo(){} // RVA: 0x7AE1EC520
        public void FromJson(){} // RVA: 0x7AE1ED240
    }

    public class ClientReportRecorder : Object
    {
        // ── Methods ──
        public void get_DiscardedEvents(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7AE1EE430
        public void RecordDiscardedEvent(){} // RVA: 0x7AE1EE720
        public void GenerateClientReport(){} // RVA: 0x7AE1EE8A0
        public void Load(){} // RVA: 0x7AE1EEB50
    }

    public class ConcurrentQueueLite`1 : Object
    {
        // ── Methods ──
        public void Enqueue(){} // RVA: 0x7A8051B10
        public void TryDequeue(){} // RVA: 0x7A7E019D0
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_IsEmpty(){} // RVA: 0x7A7E01900
        public void Clear(){} // RVA: 0x7A7E18770
        public void TryPeek(){} // RVA: 0x7A7E019D0
        public void ToArray(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7AE1EEF00
        public void WriteScope(){} // RVA: 0x7A7E22E80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DataCategory : ValueType
    {
        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x7A765F710
        public void .ctor(){} // RVA: 0x7A7637E60
        public void CompareTo(){} // RVA: 0x7A7E77590
        public void Equals(){} // RVA: 0x7A7E77680
        public void GetHashCode(){} // RVA: 0x7A7E77690
        public void ToString(){} // RVA: 0x7A765F710
        public void .cctor(){} // RVA: 0x7AE1F0010
    }

    public class DebugStackTrace : SentryStackTrace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1F0830
        public void get_DebugImages(){} // RVA: 0x7A8292C30
        public void Create(){} // RVA: 0x7AE1F0B60
        public void MergeDebugImagesInto(){} // RVA: 0x7AE1F10F0
        public void CreateFrames(){} // RVA: 0x7AE1F1A20
        public void TryCreateManagedFrame(){} // RVA: 0x7AE1F1BA0
        public void CreateFrame(){} // RVA: 0x7AE1F2300
        public void GetRelativeAddressMode(){} // RVA: 0x7AE1F2500
        public void DemangleAsyncFunctionName(){} // RVA: 0x7AE1F25A0
        public void DemangleAnonymousFunction(){} // RVA: 0x7AE1F2820
        public void DemangleLambdaReturnType(){} // RVA: 0x7AE1F29F0
        public void TryReadAssemblyFromDisk(){} // RVA: 0x7AE1F2BA0
        public void AddManagedModuleDebugImage(){} // RVA: 0x7AE1F2DD0
        public void GetManagedModuleDebugImage(){} // RVA: 0x7AE1F3000
        public void .cctor(){} // RVA: 0x7AE1F3480
    }

    public class DelegateEventProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Process(){} // RVA: 0x7ACEFA0B0
    }

    public class DelegateTransactionProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Process(){} // RVA: 0x7ACEFA0B0
    }

    public class DelimitedPrefixOrPatternMatcher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1F44A0
        public void IsMatch(){} // RVA: 0x7AE1F44B0
    }

    public class DiscardReason : ValueType
    {
        // ── Methods ──
        public void Sentry.Internal.IEnumeration.get_Value(){} // RVA: 0x7A765F710
        public void .ctor(){} // RVA: 0x7A7637E60
        public void WithCategory(){} // RVA: 0x7A7E776C0
        public void CompareTo(){} // RVA: 0x7A7E77790
        public void Equals(){} // RVA: 0x7A7E77880
        public void GetHashCode(){} // RVA: 0x7A7E77690
        public void ToString(){} // RVA: 0x7A765F710
        public void .cctor(){} // RVA: 0x7AE1F49A0
    }

    public class DiscardReasonWithCategory : ValueType
    {
        // ── Methods ──
        public void get_Reason(){} // RVA: 0x7A765F710
        public void get_Category(){} // RVA: 0x7A765F080
        public void .ctor(){} // RVA: 0x7A7C66120
        public void CompareTo(){} // RVA: 0x7A7E77B30
        public void Equals(){} // RVA: 0x7A7E77C30
        public void GetHashCode(){} // RVA: 0x7A7E77C40
        public void ToString(){} // RVA: 0x7A7E77C50
    }

    public class Disposable : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Dispose(){} // RVA: 0x7A9038740
        public void Create(){} // RVA: 0x7AE1F5630
    }

    public class DuplicateEventDetectionEventProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1F56C0
        public void Process(){} // RVA: 0x7AE1F57E0
        public void IsDuplicate(){} // RVA: 0x7AE1F5990
    }

    public class Enricher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1F5DB0
        public void Apply(){} // RVA: 0x7AE1F68A0
    }

    public class ExceptionHandlingSynchronizationContext : SynchronizationContext
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1F6C50
        public void Post(){} // RVA: 0x7AE1F6D00
    }

    public class ExceptionTypeFilter`1 : Object
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7A7E019D0
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class FileSystemBase : Object
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x7AE1F6FC0
        public void DirectoryExists(){} // RVA: 0x7AE1F7050
        public void FileExists(){} // RVA: 0x7AE1F7060
        public void GetFileCreationTime(){} // RVA: 0x7AE1F7070
        public void ReadAllTextFromFile(){} // RVA: 0x7AE1F71E0
        public void OpenFileForReading(){} // RVA: 0x7AE1F72C0
        public void CreateDirectory(){} // RVA: 0x7A7E019D0
        public void DeleteDirectory(){} // RVA: 0x7A7E03AD0
        public void CreateFileForWriting(){} // RVA: 0x7A7E01A40
        public void WriteAllTextToFile(){} // RVA: 0x7A7E01A40
        public void MoveFile(){} // RVA: 0x7A7E04EB0
        public void DeleteFile(){} // RVA: 0x7A7E019D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class GrowableArray`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E189D0
        public void get_Item(){} // RVA: 0x7A8051B10
        public void set_Item(){} // RVA: 0x7A8051B10
        public void get_Count(){} // RVA: 0x7A7E00710
        public void Reserve(){} // RVA: 0x7A7E189D0
        public void Clear(){} // RVA: 0x7A7E18770
        public void Add(){} // RVA: 0x7A8051B10
        public void AddRange(){} // RVA: 0x7A7E18800
        public void Insert(){} // RVA: 0x7A8051B10
        public void RemoveRange(){} // RVA: 0x7A7E1ABE0
        public void get_Empty(){} // RVA: 0x7A7E01900
        public void Trim(){} // RVA: 0x7A7E189D0
        public void get_EmptyCapacity(){} // RVA: 0x7A7E01900
        public void ToString(){} // RVA: 0x7A7E00680
        public void Foreach(){} // RVA: 0x7A8051B10
        public void Search(){} // RVA: 0x7A8051B10
        public void get_UnderlyingArray(){} // RVA: 0x7A7E00680
        public void Realloc(){} // RVA: 0x7A7E189D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void GetEnumerator(){} // RVA: 0x7A7E00680
    }

    public class GrowableArray`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A78CE010
        public void get_Item(){} // RVA: 0x7A78CE020
        public void set_Item(){} // RVA: 0x7A78CE050
        public void get_Count(){} // RVA: 0x7A75FEFA0
        public void Reserve(){} // RVA: 0x7A78CD940
        public void Clear(){} // RVA: 0x7A78CD990
        public void Add(){} // RVA: 0x7A78CE070
        public void AddRange(){} // RVA: 0x7A78CE080
        public void Insert(){} // RVA: 0x7A78CE090
        public void RemoveRange(){} // RVA: 0x7A78CE0A0
        public void get_Empty(){} // RVA: 0x7A78CDB90
        public void Trim(){} // RVA: 0x7A78CDBA0
        public void get_EmptyCapacity(){} // RVA: 0x7A7673DE0
        public void ToString(){} // RVA: 0x7A78CE230
        public void Foreach(){} // RVA: 0x7A8051B10
        public void Search(){} // RVA: 0x7A8051B10
        public void get_UnderlyingArray(){} // RVA: 0x7A765F710
        public void Realloc(){} // RVA: 0x7A78CDBC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A78CDBD0
        public void GetEnumerator(){} // RVA: 0x7A78CDBD0
    }

    public class GrowableArray`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A78CE010
        public void get_Item(){} // RVA: 0x7A78CE020
        public void set_Item(){} // RVA: 0x7A78CE050
        public void get_Count(){} // RVA: 0x7A75FEFA0
        public void Reserve(){} // RVA: 0x7A78CD940
        public void Clear(){} // RVA: 0x7A78CD990
        public void Add(){} // RVA: 0x7A78CE070
        public void AddRange(){} // RVA: 0x7A78CE080
        public void Insert(){} // RVA: 0x7A78CE090
        public void RemoveRange(){} // RVA: 0x7A78CE0A0
        public void get_Empty(){} // RVA: 0x7A78CDB90
        public void Trim(){} // RVA: 0x7A78CDBA0
        public void get_EmptyCapacity(){} // RVA: 0x7A7673DE0
        public void ToString(){} // RVA: 0x7A78CE230
        public void Foreach(){} // RVA: 0x7A8051B10
        public void Search(){} // RVA: 0x7A8051B10
        public void get_UnderlyingArray(){} // RVA: 0x7A765F710
        public void Realloc(){} // RVA: 0x7A78CDBC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A78CDBD0
        public void GetEnumerator(){} // RVA: 0x7A78CDBD0
    }

    public class GrowableArray`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A78CD860
        public void get_Item(){} // RVA: 0x7A78CD870
        public void set_Item(){} // RVA: 0x7A78CD8B0
        public void get_Count(){} // RVA: 0x7A75FEFA0
        public void Reserve(){} // RVA: 0x7A78CD940
        public void Clear(){} // RVA: 0x7A78CD990
        public void Add(){} // RVA: 0x7A78CD9A0
        public void AddRange(){} // RVA: 0x7A78CD9C0
        public void Insert(){} // RVA: 0x7A78CD9D0
        public void RemoveRange(){} // RVA: 0x7A78CD9F0
        public void get_Empty(){} // RVA: 0x7A78CDB90
        public void Trim(){} // RVA: 0x7A78CDBA0
        public void get_EmptyCapacity(){} // RVA: 0x7A7673DE0
        public void ToString(){} // RVA: 0x7A78CDBB0
        public void Foreach(){} // RVA: 0x7A8051B10
        public void Search(){} // RVA: 0x7A8051B10
        public void get_UnderlyingArray(){} // RVA: 0x7A765F710
        public void Realloc(){} // RVA: 0x7A78CDBC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A78CDBD0
        public void GetEnumerator(){} // RVA: 0x7A78CDBD0
    }

    public class GrowableArray`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A78CDCB0
        public void get_Item(){} // RVA: 0x7A78CDD60
        public void set_Item(){} // RVA: 0x7A78CDD90
        public void get_Count(){} // RVA: 0x7A75FEFA0
        public void Reserve(){} // RVA: 0x7A78CD940
        public void Clear(){} // RVA: 0x7A78CD990
        public void Add(){} // RVA: 0x7A78CDDC0
        public void AddRange(){} // RVA: 0x7A78CDDD0
        public void Insert(){} // RVA: 0x7A78CDDE0
        public void RemoveRange(){} // RVA: 0x7A78CDEF0
        public void get_Empty(){} // RVA: 0x7A78CDB90
        public void Trim(){} // RVA: 0x7A78CDBA0
        public void get_EmptyCapacity(){} // RVA: 0x7A7673DE0
        public void ToString(){} // RVA: 0x7A78CDFF0
        public void Foreach(){} // RVA: 0x7A8051B10
        public void Search(){} // RVA: 0x7A8051B10
        public void get_UnderlyingArray(){} // RVA: 0x7A765F710
        public void Realloc(){} // RVA: 0x7A78CDBC0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A78CDBD0
        public void GetEnumerator(){} // RVA: 0x7A78CE000
    }

    public class HashableGrowableArray`1 : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E189D0
        public void get_Item(){} // RVA: 0x7A8051B10
        public void set_Item(){} // RVA: 0x7A8051B10
        public void get_Count(){} // RVA: 0x7A7E00710
        public void Seal(){} // RVA: 0x7A7E18770
        public void Trim(){} // RVA: 0x7A7E189D0
        public void Add(){} // RVA: 0x7A8051B10
        public void GetHashCode(){} // RVA: 0x7A7E00710
        public void Equals(){} // RVA: 0x7A7E019D0
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
    }

    public class Hub : Object
    {
        // ── Methods ──
        public void get_ExceptionToSpanMap(){} // RVA: 0x7A8154D80
        public void get_ScopeManager(){} // RVA: 0x7A8152D80
        public void get_Metrics(){} // RVA: 0x7A8178B90
        public void get_IsEnabled(){} // RVA: 0x7AE1F72D0
        public void get_Options(){} // RVA: 0x7A8105330
        public void get_CurrentScope(){} // RVA: 0x7AE1F72E0
        public void get_CurrentClient(){} // RVA: 0x7AE1F73B0
        public void .ctor(){} // RVA: 0x7AE1F7480
        public void ConfigureScope(){} // RVA: 0x7AE1F7EA0
        public void ConfigureScopeAsync(){} // RVA: 0x7AE1F7F60
        public void PushScope(){} // RVA: 0x7A8051B10
        public void RestoreScope(){} // RVA: 0x7AE1F81C0
        public void BindClient(){} // RVA: 0x7AE1F8290
        public void StartTransaction(){} // RVA: 0x7AE1F8310
        public void BindException(){} // RVA: 0x7AE1F8900
        public void GetSpan(){} // RVA: 0x7AE1F8A90
        public void GetTraceHeader(){} // RVA: 0x7AE1F8AC0
        public void GetBaggage(){} // RVA: 0x7AE1F8B90
        public void ContinueTrace(){} // RVA: 0x7AE1F8DF0
        public void StartSession(){} // RVA: 0x7AE1F9180
        public void PauseSession(){} // RVA: 0x7AE1F9300
        public void ResumeSession(){} // RVA: 0x7AE1F94E0
        public void EndSession(){} // RVA: 0x7AE1F99F0
        public void GetLinkedSpan(){} // RVA: 0x7AE1F9A70
        public void ApplyTraceContextToEvent(){} // RVA: 0x7AE1F9DF0
        public void CaptureEnvelope(){} // RVA: 0x7AE1F9FE0
        public void AddBreadcrumbForException(){} // RVA: 0x7AE1FA050
        public void CaptureEvent(){} // RVA: 0x7AE1FA5A0
        public void CaptureUserFeedback(){} // RVA: 0x7AE1FA9D0
        public void CaptureTransaction(){} // RVA: 0x7AE1FAB20
        public void CaptureMetrics(){} // RVA: 0x7AE1FAC20
        public void CaptureCodeLocations(){} // RVA: 0x7AE1FAFB0
        public void StartSpan(){} // RVA: 0x7AE1FB270
        public void CaptureSession(){} // RVA: 0x7AE1FB420
        public void CaptureCheckIn(){} // RVA: 0x7AE1FB550
        public void FlushAsync(){} // RVA: 0x7AE1FB7D0
        public void Dispose(){} // RVA: 0x7AE1FB9A0
        public void get_LastEventId(){} // RVA: 0x7AE1FBB50
    }

    public class IAppDomain
    {
        // ── Methods ──
        public void add_UnhandledException(){} // RVA: 0x7A7E18800
        public void remove_UnhandledException(){} // RVA: 0x7A7E18800
        public void add_ProcessExit(){} // RVA: 0x7A7E18800
        public void remove_ProcessExit(){} // RVA: 0x7A7E18800
        public void add_UnobservedTaskException(){} // RVA: 0x7A7E18800
        public void remove_UnobservedTaskException(){} // RVA: 0x7A7E18800
    }

    public class IClientReportRecorder
    {
        // ── Methods ──
        public void RecordDiscardedEvent(){} // RVA: 0x7A7E19DB0
        public void GenerateClientReport(){} // RVA: 0x7A7E00680
        public void Load(){} // RVA: 0x7A7E18800
    }

    public class ICloneable`1
    {
        // ── Methods ──
        public void Clone(){} // RVA: 0x7A8051B10
    }

    public class IEnumeration
    {
        // ── Methods ──
        public void get_Value(){} // RVA: 0x7A7E00680
    }

    public class IFileSystem
    {
        // ── Methods ──
        public void EnumerateFiles(){} // RVA: 0x7A7E12800
        public void DirectoryExists(){} // RVA: 0x7A7E019D0
        public void FileExists(){} // RVA: 0x7A7E019D0
        public void GetFileCreationTime(){} // RVA: 0x7A7E00560
        public void ReadAllTextFromFile(){} // RVA: 0x7A7E00B20
        public void OpenFileForReading(){} // RVA: 0x7A7E00B20
        public void CreateDirectory(){} // RVA: 0x7A7E019D0
        public void DeleteDirectory(){} // RVA: 0x7A7E03AD0
        public void CreateFileForWriting(){} // RVA: 0x7A7E01A40
        public void WriteAllTextToFile(){} // RVA: 0x7A7E01A40
        public void MoveFile(){} // RVA: 0x7A7E04EB0
        public void DeleteFile(){} // RVA: 0x7A7E019D0
    }

    public class IInternalScopeManager
    {
        // ── Methods ──
        public void GetCurrent(){} // RVA: 0x7A7E00490
        public void RestoreScope(){} // RVA: 0x7A7E18800
        public void get_ScopeStackContainer(){} // RVA: 0x7A7E00680
    }

    public class IPing
    {
        // ── Methods ──
        public void IsAvailableAsync(){} // RVA: 0x7A7E063E0
    }

    public class IStackFrame
    {
        // ── Methods ──
        public void get_Frame(){} // RVA: 0x7A7E00680
        public void GetNativeImageBase(){} // RVA: 0x7A7E00680
        public void GetNativeIP(){} // RVA: 0x7A7E00680
        public void HasNativeImage(){} // RVA: 0x7A7E01900
        public void GetFileColumnNumber(){} // RVA: 0x7A7E00710
        public void GetFileLineNumber(){} // RVA: 0x7A7E00710
        public void GetFileName(){} // RVA: 0x7A7E00680
        public void GetILOffset(){} // RVA: 0x7A7E00710
        public void GetMethod(){} // RVA: 0x7A7E00680
        public void ToString(){} // RVA: 0x7A7E00680
    }

    public class IStringOrRegexMatcher
    {
        // ── Methods ──
        public void IsMatch(){} // RVA: 0x7A7E01A40
    }

    public class ITransactionProfiler
    {
        // ── Methods ──
        public void Finish(){} // RVA: 0x7A7E18770
        public void Collect(){} // RVA: 0x7A7E00B20
    }

    public class ITransactionProfilerFactory
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7A7E06640
    }

    public class IUpdatable
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x7A7E18800
    }

    public class IUpdatable`1
    {
        // ── Methods ──
        public void UpdateFrom(){} // RVA: 0x7A8051B10
    }

    public class InstallationIdHelper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1FC450
        public void TryGetInstallationId(){} // RVA: 0x7AE1FC550
        public void TryGetPersistentInstallationId(){} // RVA: 0x7AE1FC830
        public void TryGetHardwareInstallationId(){} // RVA: 0x7AE1FCE80
        public void GetMachineNameInstallationId(){} // RVA: 0x7AE1FD270
    }

    public class Json : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7A8051B10
        public void Load(){} // RVA: 0x7A8051B10
    }

    public class Lock : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1FD3E0
        public void AcquireAsync(){} // RVA: 0x7AE1FD480
        public void Dispose(){} // RVA: 0x7AE1FD670
    }

    public class MainExceptionProcessor : Object
    {
        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void Process(){} // RVA: 0x7AE1FDAC0
        public void CreateSentryExceptions(){} // RVA: 0x7AE1FDBE0
        public void WalkExceptions(){} // RVA: 0x7AE1FDE30
        public void MoveExceptionDataToEvent(){} // RVA: 0x7AE1FE010
        public void BuildSentryException(){} // RVA: 0x7AE1FEAC0
        public void GetMechanism(){} // RVA: 0x7AE1FEE60
    }

    public class MainSentryEventProcessor : Object
    {
        // ── Methods ──
        public void get_SentryStackTraceFactoryAccessor(){} // RVA: 0x7A81052C0
        public void get_Release(){} // RVA: 0x7AE200590
        public void get_Distribution(){} // RVA: 0x7AE2005C0
        public void .ctor(){} // RVA: 0x7AE2005E0
        public void Process(){} // RVA: 0x7AE200760
        public void AddMemoryInfo(){} // RVA: 0x7A80D7310
        public void AddThreadPoolInfo(){} // RVA: 0x7AE2017E0
        public void CultureInfoToDictionary(){} // RVA: 0x7AE201940
    }

    public class ModuleExtensions : Object
    {
        // ── Methods ──
        public void GetNameOrScopeName(){} // RVA: 0x7AE201C70
    }

    public class NoOpSpan : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AE201D60
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_SpanId(){} // RVA: 0x7AE201DC0
        public void get_ParentSpanId(){} // RVA: 0x7AE201E20
        public void get_TraceId(){} // RVA: 0x7AE201EA0
        public void get_IsSampled(){} // RVA: 0x7A82D1450
        public void get_Tags(){} // RVA: 0x7AE201F00
        public void get_Extra(){} // RVA: 0x7AE201F60
        public void get_StartTimestamp(){} // RVA: 0x7A92BE230
        public void get_EndTimestamp(){} // RVA: 0x7ABD32370
        public void get_IsFinished(){} // RVA: 0x7A80D7320
        public void get_Operation(){} // RVA: 0x7AE201FC0
        public void set_Operation(){} // RVA: 0x7A80D7310
        public void get_Description(){} // RVA: 0x7A82D1450
        public void set_Description(){} // RVA: 0x7A80D7310
        public void get_Status(){} // RVA: 0x7A82D1450
        public void set_Status(){} // RVA: 0x7A80D7310
        public void StartChild(){} // RVA: 0x7A97F8BA0
        public void Finish(){} // RVA: 0x7A80D7310
        public void SetTag(){} // RVA: 0x7A80D7310
        public void UnsetTag(){} // RVA: 0x7A80D7310
        public void SetExtra(){} // RVA: 0x7A80D7310
        public void GetTraceHeader(){} // RVA: 0x7AE202000
        public void get_Measurements(){} // RVA: 0x7AE202060
        public void SetMeasurement(){} // RVA: 0x7A80D7310
        public void get_Origin(){} // RVA: 0x7A80F2570
        public void set_Origin(){} // RVA: 0x7A80D8E20
        public void .cctor(){} // RVA: 0x7AE2020C0
    }

    public class NoOpTransaction : NoOpSpan
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AE202160
        public void .ctor(){} // RVA: 0x7AE2021C0
        public void get_Sdk(){} // RVA: 0x7AE202210
        public void get_Name(){} // RVA: 0x7AE202260
        public void set_Name(){} // RVA: 0x7A80D7310
        public void get_IsParentSampled(){} // RVA: 0x7A82D1450
        public void set_IsParentSampled(){} // RVA: 0x7A80D7310
        public void get_NameSource(){} // RVA: 0x7A82D1450
        public void get_Distribution(){} // RVA: 0x7AE2022A0
        public void set_Distribution(){} // RVA: 0x7A80D7310
        public void get_Level(){} // RVA: 0x7A82D1450
        public void set_Level(){} // RVA: 0x7A80D7310
        public void get_Request(){} // RVA: 0x7AE2022E0
        public void set_Request(){} // RVA: 0x7A80D7310
        public void get_Contexts(){} // RVA: 0x7AE202320
        public void set_Contexts(){} // RVA: 0x7A80D7310
        public void get_User(){} // RVA: 0x7AE202370
        public void set_User(){} // RVA: 0x7A80D7310
        public void get_Platform(){} // RVA: 0x7A82D1450
        public void set_Platform(){} // RVA: 0x7A80D7310
        public void get_Release(){} // RVA: 0x7A82D1450
        public void set_Release(){} // RVA: 0x7A80D7310
        public void get_Environment(){} // RVA: 0x7A82D1450
        public void set_Environment(){} // RVA: 0x7A80D7310
        public void get_TransactionName(){} // RVA: 0x7A82D1450
        public void set_TransactionName(){} // RVA: 0x7A80D7310
        public void get_Fingerprint(){} // RVA: 0x7AE2023B0
        public void set_Fingerprint(){} // RVA: 0x7A80D7310
        public void get_Spans(){} // RVA: 0x7AE202410
        public void get_Breadcrumbs(){} // RVA: 0x7AE202470
        public void GetLastActiveSpan(){} // RVA: 0x7A82D1450
        public void AddBreadcrumb(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE2024D0
    }

    public class ObjectExtensions : Object
    {
        // ── Methods ──
        public void get_Map(){} // RVA: 0x7AE2025B0
        public void AssociatedProperties(){} // RVA: 0x7AE202610
        public void SetFused(){} // RVA: 0x7A8051B10
        public void GetFused(){} // RVA: 0x7A8051B10
        public void .cctor(){} // RVA: 0x7AE2028B0
    }

    public class OriginHelper : Object
    {
        // ── Methods ──
        public void IsValidOrigin(){} // RVA: 0x7AE202A90
        public void TryParse(){} // RVA: 0x7AE202B40
        public void SetOrigin(){} // RVA: 0x7AE202BA0
        public void .cctor(){} // RVA: 0x7AE202D70
    }

    public class PartialStream : Stream
    {
        // ── Methods ──
        public void get_CanRead(){} // RVA: 0x7AE202E50
        public void get_CanSeek(){} // RVA: 0x7AE202E80
        public void get_CanWrite(){} // RVA: 0x7A80D7320
        public void get_Length(){} // RVA: 0x7AE202EB0
        public void get_Position(){} // RVA: 0x7A8152D80
        public void set_Position(){} // RVA: 0x7AE202F40
        public void .ctor(){} // RVA: 0x7AE202FF0
        public void ReadAsync(){} // RVA: 0x7AE2030C0
        public void Seek(){} // RVA: 0x7AE203350
        public void Read(){} // RVA: 0x7AE203480
        public void SetLength(){} // RVA: 0x7AE2035F0
        public void Write(){} // RVA: 0x7AE203630
        public void Flush(){} // RVA: 0x7AE203670
    }

    public class PiiExtensions : Object
    {
        // ── Methods ──
        public void RedactUrl(){} // RVA: 0x7AE203B80
        public void RedactAuth(){} // RVA: 0x7AE203DF0
        public void .cctor(){} // RVA: 0x7AE2040C0
    }

    public class PollingNetworkStatusListener : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2045E0
        public void get_LazyPing(){} // RVA: 0x7AE204810
        public void get_Ping(){} // RVA: 0x7AE2048F0
        public void get_Online(){} // RVA: 0x7AE204A00
        public void set_Online(){} // RVA: 0x7AE204A10
        public void WaitForNetworkOnlineAsync(){} // RVA: 0x7AE204A20
        public void <get_LazyPing>b__8_0(){} // RVA: 0x7AE204C30
    }

    public class PooledBuffer`1 : ValueType
    {
        // ── Methods ──
        public void get_Array(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E189D0
        public void Dispose(){} // RVA: 0x7A7E18770
    }

    public class PooledBuffer`1 : ValueType
    {
        // ── Methods ──
        public void get_Array(){} // RVA: 0x7A765F710
        public void .ctor(){} // RVA: 0x7A7A13BE0
        public void Dispose(){} // RVA: 0x7A7A13BF0
    }

    public class PrefixOrPatternMatcher : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void IsMatch(){} // RVA: 0x7AE205670
    }

    public class ProcessInfo : Object
    {
        // ── Methods ──
        public void get_StartupTime(){} // RVA: 0x7A9D9B400
        public void set_StartupTime(){} // RVA: 0x7A9D9B3E0
        public void get_BootTime(){} // RVA: 0x7A9E5FAC0
        public void get_PreciseAppStartupTask(){} // RVA: 0x7AE2057E0
        public void set_PreciseAppStartupTask(){} // RVA: 0x7AE2057F0
        public void GetId(){} // RVA: 0x7AE205850
        public void GetCurrentProcessId(){} // RVA: 0x7AE2058B0
        public void .ctor(){} // RVA: 0x7AE2059A0
        public void GetStartupTime(){} // RVA: 0x7AE206220
        public void ApplicationIsActivated(){} // RVA: 0x7AE2063E0
        public void GetForegroundWindow(){} // RVA: 0x7AE2067A0
        public void GetWindowThreadProcessId(){} // RVA: 0x7AE206810
    }

    public class RandomValuesFactory : Object
    {
        // ── Methods ──
        public void NextInt(){} // RVA: 0x7A7E076F0
        public void NextDouble(){} // RVA: 0x7A7E06760
        public void NextBytes(){} // RVA: 0x7A7E18800
        public void NextBool(){} // RVA: 0x7AE206AD0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ReadOnlyFileSystem : FileSystemBase
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7A80D7320
        public void DeleteDirectory(){} // RVA: 0x7A80D7320
        public void CreateFileForWriting(){} // RVA: 0x7AE206B30
        public void WriteAllTextToFile(){} // RVA: 0x7A80D7320
        public void MoveFile(){} // RVA: 0x7A80D7320
        public void DeleteFile(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ReadWriteFileSystem : FileSystemBase
    {
        // ── Methods ──
        public void CreateDirectory(){} // RVA: 0x7AE206BD0
        public void DeleteDirectory(){} // RVA: 0x7AE206C00
        public void CreateFileForWriting(){} // RVA: 0x7AE206C30
        public void WriteAllTextToFile(){} // RVA: 0x7AE206D10
        public void MoveFile(){} // RVA: 0x7AE206D40
        public void DeleteFile(){} // RVA: 0x7AE206DB0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class RealStackFrame : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Frame(){} // RVA: 0x7A80F2570
        public void ToString(){} // RVA: 0x7A8E1FCB0
        public void GetFileColumnNumber(){} // RVA: 0x7A858AB20
        public void GetFileLineNumber(){} // RVA: 0x7A858AA80
        public void GetFileName(){} // RVA: 0x7A858ABB0
        public void GetILOffset(){} // RVA: 0x7ADE59240
        public void GetMethod(){} // RVA: 0x7A856A750
        public void GetNativeImageBase(){} // RVA: 0x7A82D1450
        public void GetNativeIP(){} // RVA: 0x7A82D1450
        public void HasNativeImage(){} // RVA: 0x7A80D7320
    }

    public class ScopeObserver : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADABAF10
        public void AddBreadcrumb(){} // RVA: 0x7AE206EA0
        public void AddBreadcrumbImpl(){} // RVA: 0x7A7E18800
        public void SetExtra(){} // RVA: 0x7AE2070B0
        public void SetExtraImpl(){} // RVA: 0x7A7E18890
        public void SetTag(){} // RVA: 0x7AE207410
        public void SetTagImpl(){} // RVA: 0x7A7E18890
        public void UnsetTag(){} // RVA: 0x7AE2075F0
        public void UnsetTagImpl(){} // RVA: 0x7A7E18800
        public void SetUser(){} // RVA: 0x7AE207790
        public void SetUserImpl(){} // RVA: 0x7A7E18800
        public void UnsetUserImpl(){} // RVA: 0x7A7E18770
    }

    public class SdkComposer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE207A50
        public void CreateTransport(){} // RVA: 0x7AE207B60
        public void CreateHttpTransport(){} // RVA: 0x7AE2081B0
        public void CreateBackgroundWorker(){} // RVA: 0x7AE208480
    }

    public class SentryScopeManager : Object
    {
        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7A80F2570
        public void get_ScopeAndClientStack(){} // RVA: 0x7AE2085E0
        public void set_ScopeAndClientStack(){} // RVA: 0x7AE2086D0
        public void get_NewStack(){} // RVA: 0x7A81052C0
        public void get_IsGlobalMode(){} // RVA: 0x7AE208730
        public void .ctor(){} // RVA: 0x7AE2087B0
        public void GetCurrent(){} // RVA: 0x7AE208B20
        public void ConfigureScope(){} // RVA: 0x7AE208B70
        public void ConfigureScopeAsync(){} // RVA: 0x7AE208D10
        public void PushScope(){} // RVA: 0x7A8051B10
        public void RestoreScope(){} // RVA: 0x7AE208F20
        public void BindClient(){} // RVA: 0x7AE209390
        public void Dispose(){} // RVA: 0x7AE2096A0
    }

    public class SentryStopwatch : ValueType
    {
        // ── Methods ──
        public void StartNew(){} // RVA: 0x7AE2099A0
        public void get_StartDateTimeOffset(){} // RVA: 0x7A76B2030
        public void get_CurrentDateTimeOffset(){} // RVA: 0x7A7E77FA0
        public void Diff(){} // RVA: 0x7A7E77FD0
        public void get_Elapsed(){} // RVA: 0x7A7E78020
        public void get_ElapsedNanoseconds(){} // RVA: 0x7A7E78030
        public void .cctor(){} // RVA: 0x7AE209D70
    }

    public class SerializableExtensions : Object
    {
        // ── Methods ──
        public void SerializeToStringAsync(){} // RVA: 0x7AE209E30
        public void SerializeToString(){} // RVA: 0x7AE20A0F0
    }

    public class SettingLocator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE20AFB0
        public void get_AssemblyForAttributes(){} // RVA: 0x7A80DA7B0
        public void set_AssemblyForAttributes(){} // RVA: 0x7A813E420
        public void GetEnvironmentVariable(){} // RVA: 0x7AE20B070
        public void GetDsn(){} // RVA: 0x7AE20B080
        public void GetEnvironment(){} // RVA: 0x7AE20B1D0
        public void GetRelease(){} // RVA: 0x7AE20B300
    }

    public class Signal : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE20B4F0
        public void Release(){} // RVA: 0x7AE20B650
        public void WaitAsync(){} // RVA: 0x7AE20B7C0
        public void Dispose(){} // RVA: 0x7AE20B7F0
    }

    public class StringOrRegex : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void op_Implicit(){} // RVA: 0x7AE20B8A0
        public void ToString(){} // RVA: 0x7AE20B930
        public void Equals(){} // RVA: 0x7AE20B9A0
        public void GetHashCode(){} // RVA: 0x7A9CC18D0
    }

    public class StringOrRegexExtensions : Object
    {
        // ── Methods ──
        public void MatchesAny(){} // RVA: 0x7AE20BA90
    }

    public class StringOrRegex[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SynchronizedRandomValuesFactory : RandomValuesFactory
    {
        // ── Methods ──
        public void get_Random(){} // RVA: 0x7AE20BCB0
        public void NextInt(){} // RVA: 0x7AE20BE50
        public void NextDouble(){} // RVA: 0x7AE20BED0
        public void NextBytes(){} // RVA: 0x7AE20BF40
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE20BFB0
    }

    public class TcpPing : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE20C070
        public void IsAvailableAsync(){} // RVA: 0x7AE20C2B0
    }

    public class ThreadPoolInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE20C940
        public void get_MinWorkerThreads(){} // RVA: 0x7A8124910
        public void get_MinCompletionPortThreads(){} // RVA: 0x7A8668BC0
        public void get_MaxWorkerThreads(){} // RVA: 0x7A83782A0
        public void get_MaxCompletionPortThreads(){} // RVA: 0x7A9739200
        public void get_AvailableWorkerThreads(){} // RVA: 0x7A851DB90
        public void get_AvailableCompletionPortThreads(){} // RVA: 0x7A8AB15F0
        public void WriteTo(){} // RVA: 0x7AE20C970
    }

    public class ThreadsafeCounterDictionary`1 : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7A8051B10
        public void Increment(){} // RVA: 0x7A8051B10
        public void ReadAndReset(){} // RVA: 0x7A8051B10
        public void ReadAllAndReset(){} // RVA: 0x7A7E00680
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void get_Count(){} // RVA: 0x7A7E00710
        public void ContainsKey(){} // RVA: 0x7A8051B10
        public void TryGetValue(){} // RVA: 0x7A8051B10
        public void get_Item(){} // RVA: 0x7A8051B10
        public void get_Keys(){} // RVA: 0x7A7E00680
        public void get_Values(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E18770
    }

}