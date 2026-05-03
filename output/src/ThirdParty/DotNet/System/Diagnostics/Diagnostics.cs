// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics
// Classes: 56
// Methods: 428

namespace ThirdParty.DotNet.System.Diagnostics
{
    public class Activity : Object
    {
        public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<string,string>> s_emptyBaggageTags;
        public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<string,object>> s_emptyTagObjects; // 0x8
        public System.Collections.Generic.IEnumerable`1<System.Diagnostics.ActivityLink> s_emptyLinks; // 0x10
        public System.Collections.Generic.IEnumerable`1<System.Diagnostics.ActivityEvent> s_emptyEvents; // 0x18
        public System.Diagnostics.ActivitySource s_defaultSource; // 0x20
        public string s_uniqSuffix; // 0x28
        public long s_currentRootId; // 0x30
        public System.EventHandler`1<System.Diagnostics.ActivityChangedEventArgs> CurrentChanged; // 0x38
        public string _traceState; // 0x10
        public dFixup.ÎÍÎÍÏÍÎ _state; // 0x18
        public string _id; // 0x20
        public string _rootId; // 0x28
        public string _parentId; // 0x30
        public string _parentSpanId; // 0x38
        public string _traceId; // 0x40
        public string _spanId; // 0x48
        public byte _w3CIdFlags; // 0x50
        public byte _parentTraceFlags; // 0x51

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFE81463AE0
        public void get_Parent(){} // RVA: 0x7FFE81280C30
        public void get_Duration(){} // RVA: 0x7FFE8113A010
        public void set_Duration(){} // RVA: 0x7FFE82C95CA0
        public void get_StartTimeUtc(){} // RVA: 0x7FFE8154EB60
        public void get_Id(){} // RVA: 0x7FFE873190E0
        public void get_ParentId(){} // RVA: 0x7FFE873192B0
        public void get_RootId(){} // RVA: 0x7FFE873194A0
        public void get_TagObjects(){} // RVA: 0x7FFE87319580
        public void get_Baggage(){} // RVA: 0x7FFE873195F0
        public void SetEndTime(){} // RVA: 0x7FFE87319690
        public void Stop(){} // RVA: 0x7FFE873198B0
        public void get_TraceStateString(){} // RVA: 0x7FFE87319D70
        public void get_SpanId(){} // RVA: 0x7FFE87319D90
        public void get_TraceId(){} // RVA: 0x7FFE87319ED0
        public void get_ActivityTraceFlags(){} // RVA: 0x7FFE87319F50
        public void set_ActivityTraceFlags(){} // RVA: 0x7FFE87319F80
        public void get_ParentSpanId(){} // RVA: 0x7FFE87319F90
        public void IsW3CId(){} // RVA: 0x7FFE8731A220
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void SetCustomProperty(){} // RVA: 0x7FFE8731A320
        public void GetCustomProperty(){} // RVA: 0x7FFE8731A5F0
        public void NotifyError(){} // RVA: 0x7FFE8731A7D0
        public void GetRootId(){} // RVA: 0x7FFE8731A810
        public void GetRandomNumber(){} // RVA: 0x7FFE8731A890
        public void TrySetTraceIdFromParent(){} // RVA: 0x7FFE8731A8D0
        public void TrySetTraceFlagsFromParent(){} // RVA: 0x7FFE8731AD00
        public void get_W3CIdFlagsSet(){} // RVA: 0x7FFE8731AF50
        public void get_IsStopped(){} // RVA: 0x7FFE8731AF60
        public void set_IsStopped(){} // RVA: 0x7FFE8731AF70
        public void get_IdFormat(){} // RVA: 0x7FFE8731AFA0
        public void get_Current(){} // RVA: 0x7FFE8731AFB0
        public void SetCurrent(){} // RVA: 0x7FFE8731B030
        public void GetUtcNow(){} // RVA: 0x7FFE8731B1B0
        public void .cctor(){} // RVA: 0x7FFE8731B200
        public void <get_Baggage>g__Iterate|87_0(){} // RVA: 0x7FFE8731B750
    }

    public class ActivityChangedEventArgs : ValueType
    {
        public System.Diagnostics.Activity _previous; // 0x10
        public System.Diagnostics.Activity _current; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
        public void set_Previous(){} // RVA: 0x7FFE81D7E9E0
        public void set_Current(){} // RVA: 0x7FFE826F4230
    }

    public class ActivityContext : ValueType
    {
        public System.Diagnostics.ActivityTraceId _traceId; // 0x10
        public System.Diagnostics.ActivitySpanId _spanId; // 0x18
        public 0x666CC674 _traceFlags; // 0x20
        public string _traceState; // 0x28
        public bool _isRemote; // 0x30

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7FFE8284EF60
        public void get_SpanId(){} // RVA: 0x7FFE826F4210
        public void get_TraceFlags(){} // RVA: 0x7FFE811485C0
        public void get_TraceState(){} // RVA: 0x7FFE810FE7C0
        public void get_IsRemote(){} // RVA: 0x7FFE811E99D0
        public void Equals(){} // RVA: 0x7FFE8731C760 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE8731C810
        public void GetHashCode(){} // RVA: 0x7FFE8731C850
    }

    public class ActivityEvent : ValueType
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8731C9D0
    }

    public class ActivityLink : ValueType
    {
        public TagsLinkedList _tags; // 0x10
        public System.Diagnostics.ActivityContext _context; // 0x18

        // ── Methods ──
        public void get_Context(){} // RVA: 0x7FFE82D284A0
        public void get_Tags(){} // RVA: 0x7FFE8284EF60
        public void Equals(){} // RVA: 0x7FFE8731CBA0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE8731CC30
        public void GetHashCode(){} // RVA: 0x7FFE8731CCE0
    }

    public class ActivityListener : Object
    {
        public System.Action`1<System.Diagnostics.Activity> _activityStopped; // 0x10
        public System.Func`2<System.Diagnostics.ActivitySource,bool> _shouldListenTo; // 0x18

        // ── Methods ──
        public void get_ActivityStopped(){} // RVA: 0x7FFE81116380
        public void get_ShouldListenTo(){} // RVA: 0x7FFE810FE7C0
        public void Dispose(){} // RVA: 0x7FFE8731D020
    }

    public class ActivitySource : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8731D070
        public void Dispose(){} // RVA: 0x7FFE8731D3D0
        public void AddListener(){} // RVA: 0x7FFE8731D4B0
        public void DetachListener(){} // RVA: 0x7FFE8731D5B0
        public void NotifyActivityStop(){} // RVA: 0x7FFE8731D7A0
        public void .cctor(){} // RVA: 0x7FFE8731D910
    }

    public class ActivitySpanId : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void CreateFromString(){} // RVA: 0x7FFE8731C350
        public void ToHexString(){} // RVA: 0x7FFE8731C4F0
        public void ToString(){} // RVA: 0x7FFE8731C4F0
        public void Equals(){} // RVA: 0x7FFE8731C540 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8731C600
    }

    public class ActivityTraceId : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
        public void CreateFromString(){} // RVA: 0x7FFE8731BED0
        public void ToHexString(){} // RVA: 0x7FFE8731C070
        public void ToString(){} // RVA: 0x7FFE8731C070
        public void Equals(){} // RVA: 0x7FFE8731C0C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE8731C180
        public void HexByteFromChars(){} // RVA: 0x7FFE8731C1E0
        public void IsLowerCaseHexAndNotAllZeros(){} // RVA: 0x7FFE8731C2A0
    }

    public class AsyncStreamReader : Object
    {
        // ── Methods ──
        public void Close(){} // RVA: 0x7FFE81148FC0
        public void Dispose(){} // RVA: 0x7FFE877695F0
        public void CancelOperation(){} // RVA: 0x7FFE81F0FA70
    }

    public class BooleanSwitch : Switch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877649A0
    }

    public class ConditionalAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class CorrelationManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_LogicalOperationStack(){} // RVA: 0x7FFE87764A40
        public void GetLogicalOperationStack(){} // RVA: 0x7FFE87764A50
    }

    public class DebuggableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class Debugger : Object
    {
        public string DefaultCategory;

        // ── Methods ──
        public void get_IsAttached(){} // RVA: 0x7FFE86936F90
        public void IsAttached_internal(){} // RVA: 0x7FFE86936FE0
        public void IsLogging(){} // RVA: 0x7FFE810FB320
        public void Log_icall(){} // RVA: 0x7FFE810FB310
        public void Log(){} // RVA: 0x7FFE86937000
        public void NotifyOfCrossThreadDependency(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86937050
    }

    public class DebuggerBrowsableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86936C50
    }

    public class DebuggerDisplayAttribute : Attribute
    {
        public string name; // 0x10
        public string value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86936DD0
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void set_Type(){} // RVA: 0x7FFE811290D0
    }

    public class DebuggerHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DebuggerNonUserCodeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DebuggerStepThroughAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DebuggerTypeProxyAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86936CC0
    }

    public class DefaultTraceListener : TraceListener
    {
        public bool OnWin32;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE8776F7B0
        public void GetPrefix(){} // RVA: 0x7FFE8776FA40
        public void .ctor(){} // RVA: 0x7FFE8776FAC0
        public void get_LogFileName(){} // RVA: 0x7FFE8143BA80
        public void WriteWindowsDebugString(){} // RVA: 0x7FFE8776FB50
        public void WriteDebugString(){} // RVA: 0x7FFE8776FB60
        public void WriteMonoTrace(){} // RVA: 0x7FFE8776FC00
        public void WritePrefix(){} // RVA: 0x7FFE8776FE20
        public void WriteImpl(){} // RVA: 0x7FFE8776FEB0
        public void WriteLogFile(){} // RVA: 0x7FFE87770040
        public void Write(){} // RVA: 0x7FFE87770250
        public void WriteLine(){} // RVA: 0x7FFE87770260
    }

    public class DiagEnumerator`1 : ValueType
    {
        public System.Diagnostics.DiagNode`1<T> s_Empty;
        public System.Diagnostics.DiagNode`1<T> _nextNode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void get_Current(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFE80E2E2E0
        public void MoveNext(){} // RVA: 0x7FFE80E2F150
        public void Reset(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class DiagNode`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
    }

    public class DiagnosticSourceEventSource : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8731DE10
        public void .cctor(){} // RVA: 0x7FFE8731DF20
    }

    public class DiagnosticsConfigurationHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87714B20
        public void Create(){} // RVA: 0x7FFE87714B50
    }

    public class EnhancedStackFrame : StackFrame
    {
        public string _fileName; // 0x48
        public int _lineNumber; // 0x50
        public int _colNumber; // 0x54

        // ── Methods ──
        public void get_StackFrame(){} // RVA: 0x7FFE811C3500
        public void get_IsRecursive(){} // RVA: 0x7FFE86F8D3B0
        public void set_IsRecursive(){} // RVA: 0x7FFE86F8D3D0
        public void get_MethodInfo(){} // RVA: 0x7FFE81199370
        public void .ctor(){} // RVA: 0x7FFE86F8D3F0
        public void IsEquivalent(){} // RVA: 0x7FFE86F8D550
        public void GetFileColumnNumber(){} // RVA: 0x7FFE819EA920
        public void GetFileLineNumber(){} // RVA: 0x7FFE8139DAD0
        public void GetFileName(){} // RVA: 0x7FFE81176730
        public void GetILOffset(){} // RVA: 0x7FFE86F8D5E0
        public void GetMethod(){} // RVA: 0x7FFE86F8D610
        public void GetNativeOffset(){} // RVA: 0x7FFE86F8D640
        public void ToString(){} // RVA: 0x7FFE86F8D670
    }

    public class EnhancedStackTrace : StackTrace
    {
        public System.Collections.Generic.List`1<System.Diagnostics.EnhancedStackFrame> _frames; // 0x28

        // ── Methods ──
        public void Current(){} // RVA: 0x7FFE86F8D6A0
        public void .ctor(){} // RVA: 0x7FFE86F8D9B0 | overloaded x2
        public void get_FrameCount(){} // RVA: 0x7FFE86F8DAC0
        public void GetFrame(){} // RVA: 0x7FFE86F8DB10
        public void GetFrames(){} // RVA: 0x7FFE86F8E550 | overloaded x3
        public void ToString(){} // RVA: 0x7FFE86F8DBE0
        public void Append(){} // RVA: 0x7FFE86F8DCB0
        public void GetEnumerator(){} // RVA: 0x7FFE86F8DEC0
        public void System.Collections.Generic.IEnumerable<System.Diagnostics.EnhancedStackFrame>.GetEnumerator(){} // RVA: 0x7FFE86F8DF00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86F8DFF0
        public void TryGetFullPath(){} // RVA: 0x7FFE86F8E0E0
        public void .cctor(){} // RVA: 0x7FFE86F8E1A0
        public void GetMethodDisplayString(){} // RVA: 0x7FFE86F8E9D0
        public void IsFSharpAsync(){} // RVA: 0x7FFE86F8FAA0
        public void TryResolveGeneratedName(){} // RVA: 0x7FFE86F8FC20
        public void TryResolveSourceMethod(){} // RVA: 0x7FFE86F90780
        public void GetOrdinal(){} // RVA: 0x7FFE86F90DD0
        public void GetMatchHint(){} // RVA: 0x7FFE86F91120
        public void TryParseGeneratedName(){} // RVA: 0x7FFE86F91230
        public void IndexOfBalancedParenthesis(){} // RVA: 0x7FFE86F91570
        public void GetPrefix(){} // RVA: 0x7FFE86F91610
        public void GetParameter(){} // RVA: 0x7FFE86F91810
        public void GetValueTupleParameter(){} // RVA: 0x7FFE86F91D30
        public void GetValueTupleParameterName(){} // RVA: 0x7FFE86F91EF0
        public void ShowInStackTrace(){} // RVA: 0x7FFE86F92130
        public void IsStackTraceHidden(){} // RVA: 0x7FFE86F93080
        public void TryResolveStateMachineMethod(){} // RVA: 0x7FFE86F934C0
        public void <TryResolveStateMachineMethod>g__GetDeclaredMethods|33_0(){} // RVA: 0x7FFE86F939E0
    }

    public class ExceptionExtensions : Object
    {
        // ── Methods ──
        public void SetStackTracesString(){} // RVA: 0x7FFE86F93CB0
        public void Demystify(){} // RVA: 0x7FFE810A1420
        public void ToStringDemystified(){} // RVA: 0x7FFE86F93D30
        public void .cctor(){} // RVA: 0x7FFE86F93DC0
    }

    public class MonitoringDescriptionAttribute : DescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877702B0
        public void get_Description(){} // RVA: 0x7FFE81116380
    }

    public class Process : Component
    {
        public bool haveProcessId; // 0x28
        public int processId; // 0x2C
        public bool haveProcessHandle; // 0x30
        public Microsoft.Win32.SafeHandles.SafeProcessHandle m_processHandle; // 0x38
        public bool isRemoteMachine; // 0x40
        public string machineName; // 0x48
        public int m_processAccess; // 0x50
        public System.Diagnostics.ProcessThreadCollection threads; // 0x58
        public System.Diagnostics.ProcessModuleCollection modules; // 0x60

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87769C00 | overloaded x2
        public void get_Associated(){} // RVA: 0x7FFE87769CE0
        public void get_HasExited(){} // RVA: 0x7FFE87769CF0
        public void GetProcessTimes(){} // RVA: 0x7FFE8776A0A0
        public void get_Handle(){} // RVA: 0x7FFE8776A310
        public void get_Id(){} // RVA: 0x7FFE8776A3E0
        public void get_StartInfo(){} // RVA: 0x7FFE8776A400
        public void set_StartInfo(){} // RVA: 0x7FFE8776A560
        public void get_StartTime(){} // RVA: 0x7FFE8776A610
        public void get_SynchronizingObject(){} // RVA: 0x7FFE8776A690
        public void ReleaseProcessHandle(){} // RVA: 0x7FFE8776A860
        public void CompletionCallback(){} // RVA: 0x7FFE8776A890
        public void Dispose(){} // RVA: 0x7FFE8776A8B0
        public void Close(){} // RVA: 0x7FFE8776A900
        public void EnsureState(){} // RVA: 0x7FFE8776AD90
        public void EnsureWatchingForExit(){} // RVA: 0x7FFE8776B010
        public void GetCurrentProcess(){} // RVA: 0x7FFE8776B1F0
        public void OnExited(){} // RVA: 0x7FFE8776B300
        public void GetProcessHandle(){} // RVA: 0x7FFE8776BB40 | overloaded x2
        public void OpenProcessHandle(){} // RVA: 0x7FFE8776BB50
        public void Refresh(){} // RVA: 0x7FFE8776BC00
        public void SetProcessHandle(){} // RVA: 0x7FFE8776BCC0
        public void SetProcessId(){} // RVA: 0x7FFE8776BD30
        public void Start(){} // RVA: 0x7FFE8776C1E0 | overloaded x3
        public void Kill(){} // RVA: 0x7FFE8776C3A0
        public void StopWatchingForExit(){} // RVA: 0x7FFE8776C490
        public void ToString(){} // RVA: 0x7FFE8776C6E0
        public void ProcessName_icall(){} // RVA: 0x7FFE8776C800
        public void ProcessName_internal(){} // RVA: 0x7FFE8776C8A0
        public void get_ProcessName(){} // RVA: 0x7FFE8776CA20
        public void ShellExecuteEx_internal(){} // RVA: 0x7FFE810FB320
        public void CreateProcess_internal(){} // RVA: 0x7FFE810FB320
        public void StartWithShellExecuteEx(){} // RVA: 0x7FFE8776CD00
        public void CreatePipe(){} // RVA: 0x7FFE8776D130
        public void get_IsWindows(){} // RVA: 0x7FFE869A8880
        public void StartWithCreateProcess(){} // RVA: 0x7FFE8776D550
        public void FillUserInfo(){} // RVA: 0x7FFE8776E760
        public void RaiseOnExited(){} // RVA: 0x7FFE8776EA40
    }

    public class ProcessInfo : Object
    {
    }

    public class ProcessModuleCollection : ReadOnlyCollectionBase
    {
    }

    public class ProcessStartInfo : Object
    {
        public string fileName; // 0x10
        public string arguments; // 0x18
        public string directory; // 0x20
        public string verb; // 0x28
        public 0x66529FEC windowStyle; // 0x30
        public bool errorDialog; // 0x34
        public UIntPtr errorDialogParentHandle; // 0x38
        public bool useShellExecute; // 0x40
        public string userName; // 0x48
        public string domain; // 0x50
        public System.Security.SecureString password; // 0x58
        public string passwordInClearText; // 0x60
        public bool loadUserProfile; // 0x68
        public bool redirectStandardInput; // 0x69
        public bool redirectStandardOutput; // 0x6A
        public bool redirectStandardError; // 0x6B
        public System.Text.Encoding standardOutputEncoding; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8776ECD0 | overloaded x2
        public void get_ArgumentList(){} // RVA: 0x7FFE8776ED90
        public void get_Arguments(){} // RVA: 0x7FFE8776EE60
        public void set_Arguments(){} // RVA: 0x7FFE81161E80
        public void get_EnvironmentVariables(){} // RVA: 0x7FFE8776EEC0
        public void get_RedirectStandardInput(){} // RVA: 0x7FFE85B63B60
        public void get_RedirectStandardOutput(){} // RVA: 0x7FFE8663A5A0
        public void get_RedirectStandardError(){} // RVA: 0x7FFE87608930
        public void get_StandardErrorEncoding(){} // RVA: 0x7FFE81463AE0
        public void get_StandardOutputEncoding(){} // RVA: 0x7FFE811C3590
        public void get_UseShellExecute(){} // RVA: 0x7FFE811B6C00
        public void get_UserName(){} // RVA: 0x7FFE8776F510
        public void get_Password(){} // RVA: 0x7FFE811C3500
        public void get_Domain(){} // RVA: 0x7FFE8776F570
        public void get_LoadUserProfile(){} // RVA: 0x7FFE811C3570
        public void get_FileName(){} // RVA: 0x7FFE8776F5D0
        public void get_WorkingDirectory(){} // RVA: 0x7FFE8776F630
        public void get_HaveEnvVars(){} // RVA: 0x7FFE8776F690
        public void get_StandardInputEncoding(){} // RVA: 0x7FFE817AB5E0
        public void .cctor(){} // RVA: 0x7FFE8776F6A0
    }

    public class ProcessThreadCollection : ReadOnlyCollectionBase
    {
    }

    public class ProcessThreadTimes : Object
    {
        public long create; // 0x10

        // ── Methods ──
        public void get_StartTime(){} // RVA: 0x7FFE8776EBA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ProcessWaitHandle : WaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8776F750
    }

    public class ResolvedMethod : Object
    {
        public System.Reflection.MethodBase _methodBase; // 0x10
        public System.Type _declaringType; // 0x18
        public bool _isAsync; // 0x20
        public bool _isLambda; // 0x21
        public System.Diagnostics.ResolvedParameter _returnParameter; // 0x28
        public string _name; // 0x30
        public System.Nullable`1<int> _ordinal; // 0x38
        public string _genericArguments; // 0x40
        public System.Type[] _resolvedGenericArguments; // 0x48
        public System.Reflection.MethodBase _subMethodBase; // 0x50
        public string _subMethod; // 0x58
        public System.Collections.Generic.Enumerable.EnumerableIList`1<System.Diagnostics.ResolvedParameter> _parameters; // 0x60
        public System.Collections.Generic.Enumerable.EnumerableIList`1<System.Diagnostics.ResolvedParameter> _subMethodParameters; // 0x68
        public int _recurseCount; // 0x70

        // ── Methods ──
        public void get_MethodBase(){} // RVA: 0x7FFE81116380
        public void set_MethodBase(){} // RVA: 0x7FFE810FCE30
        public void get_DeclaringType(){} // RVA: 0x7FFE810FE7C0
        public void set_DeclaringType(){} // RVA: 0x7FFE81161E80
        public void get_IsAsync(){} // RVA: 0x7FFE811E99D0
        public void set_IsAsync(){} // RVA: 0x7FFE811E99E0
        public void get_IsLambda(){} // RVA: 0x7FFE814B5BF0
        public void set_IsLambda(){} // RVA: 0x7FFE818933B0
        public void get_ReturnParameter(){} // RVA: 0x7FFE81129130
        public void set_ReturnParameter(){} // RVA: 0x7FFE810FCE90
        public void get_Name(){} // RVA: 0x7FFE8144E200
        public void set_Name(){} // RVA: 0x7FFE81129890
        public void get_Ordinal(){} // RVA: 0x7FFE8143BA80
        public void set_Ordinal(){} // RVA: 0x7FFE81CDDAA0
        public void get_GenericArguments(){} // RVA: 0x7FFE81178740
        public void set_GenericArguments(){} // RVA: 0x7FFE81123200
        public void get_ResolvedGenericArguments(){} // RVA: 0x7FFE81176730
        public void set_ResolvedGenericArguments(){} // RVA: 0x7FFE81176740
        public void get_SubMethodBase(){} // RVA: 0x7FFE8119C0E0
        public void set_SubMethodBase(){} // RVA: 0x7FFE812534D0
        public void get_SubMethod(){} // RVA: 0x7FFE811C3500
        public void set_SubMethod(){} // RVA: 0x7FFE811C3510
        public void get_Parameters(){} // RVA: 0x7FFE81199370
        public void set_Parameters(){} // RVA: 0x7FFE81199380
        public void get_SubMethodParameters(){} // RVA: 0x7FFE81176D50
        public void set_SubMethodParameters(){} // RVA: 0x7FFE81176D60
        public void get_RecurseCount(){} // RVA: 0x7FFE81E60180
        public void set_RecurseCount(){} // RVA: 0x7FFE81293CF0
        public void IsSequentialEquivalent(){} // RVA: 0x7FFE86F93F20
        public void ToString(){} // RVA: 0x7FFE86F940F0
        public void Append(){} // RVA: 0x7FFE86F94190 | overloaded x2
        public void AppendDeclaringTypeName(){} // RVA: 0x7FFE86F94BD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ResolvedParameter : Object
    {
        public string _name; // 0x10
        public System.Type _resolvedType; // 0x18
        public string _prefix; // 0x20
        public bool _isDynamicType; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void get_ResolvedType(){} // RVA: 0x7FFE810FE7C0
        public void set_ResolvedType(){} // RVA: 0x7FFE81161E80
        public void get_Prefix(){} // RVA: 0x7FFE811290C0
        public void set_Prefix(){} // RVA: 0x7FFE811290D0
        public void get_IsDynamicType(){} // RVA: 0x7FFE815F1380
        public void set_IsDynamicType(){} // RVA: 0x7FFE81C15740
        public void .ctor(){} // RVA: 0x7FFE81161E80
        public void ToString(){} // RVA: 0x7FFE86F94C90
        public void Append(){} // RVA: 0x7FFE86F94D20
        public void AppendTypeName(){} // RVA: 0x7FFE86F94FB0
    }

    public class StackFrame : Object
    {
        // ── Methods ──
        public void get_frame_info(){} // RVA: 0x7FFE86937100
        public void .ctor(){} // RVA: 0x7FFE869371C0 | overloaded x3
        public void GetFileLineNumber(){} // RVA: 0x7FFE81D46090
        public void GetFileColumnNumber(){} // RVA: 0x7FFE816311C0
        public void GetFileName(){} // RVA: 0x7FFE8144E200
        public void GetSecureFileName(){} // RVA: 0x7FFE86937280
        public void GetILOffset(){} // RVA: 0x7FFE811485C0
        public void GetMethod(){} // RVA: 0x7FFE81129130
        public void GetNativeOffset(){} // RVA: 0x7FFE8164B230
        public void GetMethodAddress(){} // RVA: 0x7FFE810FE7C0
        public void GetMethodIndex(){} // RVA: 0x7FFE8151D690
        public void GetInternalMethodName(){} // RVA: 0x7FFE81178740
        public void ToString(){} // RVA: 0x7FFE869372F0
    }

    public class StackTrace : Object
    {
        public int METHODS_TO_SKIP;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x11
        public void init_frames(){} // RVA: 0x7FFE86937570
        public void get_trace(){} // RVA: 0x7FFE86937810
        public void get_FrameCount(){} // RVA: 0x7FFE84473010
        public void GetFrame(){} // RVA: 0x7FFE86937BE0
        public void GetFrames(){} // RVA: 0x7FFE86937C50
        public void GetAotId(){} // RVA: 0x7FFE86937E10
        public void AddFrames(){} // RVA: 0x7FFE86937EC0
        public void GetFullNameForStackTrace(){} // RVA: 0x7FFE86938470
        public void ConvertAsyncStateMachineMethod(){} // RVA: 0x7FFE86938C10
        public void ToString(){} // RVA: 0x7FFE86939060 | overloaded x2
    }

    public class StackTraceHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Stopwatch : Object
    {
        public long Frequency;
        public bool IsHighResolution; // 0x8
        public long elapsed; // 0x10
        public long started; // 0x18

        // ── Methods ──
        public void GetTimestamp(){} // RVA: 0x7FFE86A81570
        public void StartNew(){} // RVA: 0x7FFE87770350
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_Elapsed(){} // RVA: 0x7FFE877703F0
        public void get_ElapsedMilliseconds(){} // RVA: 0x7FFE87770500
        public void get_ElapsedTicks(){} // RVA: 0x7FFE87770650
        public void get_IsRunning(){} // RVA: 0x7FFE811E99D0
        public void Reset(){} // RVA: 0x7FFE877706C0
        public void Start(){} // RVA: 0x7FFE877706D0
        public void Stop(){} // RVA: 0x7FFE87770730
        public void Restart(){} // RVA: 0x7FFE877707B0
        public void .cctor(){} // RVA: 0x7FFE87770810
    }

    public class StringBuilderExtentions : Object
    {
        // ── Methods ──
        public void AppendDemystified(){} // RVA: 0x7FFE86F95020
        public void AppendInnerException(){} // RVA: 0x7FFE86F954D0
    }

    public class Switch : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87764DB0 | overloaded x2
        public void _pruneCachedSwitches(){} // RVA: 0x7FFE877651A0
        public void .cctor(){} // RVA: 0x7FFE87765800
    }

    public class SwitchLevelAttribute : Attribute
    {
        public System.Type type; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE877658E0
        public void set_SwitchLevelType(){} // RVA: 0x7FFE877658E0
    }

    public class SynchronizedList`1 : Object
    {
        public System.Collections.Generic.List`1<T> _list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void AddIfNotExist(){} // RVA: 0x7FFE810A1420
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void EnumWithAction(){} // RVA: 0x7FFE80E4F230
    }

    public class Trace : Object
    {
        public System.Diagnostics.CorrelationManager correlationManager;
        public object field_1; // 0x102
        public object field_2; // 0x103

        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x7FFE877659D0
        public void get_AutoFlush(){} // RVA: 0x7FFE87765A20
        public void get_CorrelationManager(){} // RVA: 0x7FFE87765AB0
        public void WriteLine(){} // RVA: 0x7FFE87765B90
    }

    public class TraceEventCache : Object
    {
        public int processId;
        public string processName; // 0x8
        public long timeStamp; // 0x10
        public System.DateTime dateTime; // 0x18
        public string stackTrace; // 0x20
        public object field_5; // 0x105

        // ── Methods ──
        public void get_Callstack(){} // RVA: 0x7FFE87765BE0
        public void get_LogicalOperationStack(){} // RVA: 0x7FFE87765CC0
        public void get_DateTime(){} // RVA: 0x7FFE87765DB0
        public void get_ProcessId(){} // RVA: 0x7FFE87765E90
        public void get_ThreadId(){} // RVA: 0x7FFE87765EE0
        public void get_Timestamp(){} // RVA: 0x7FFE87766060
        public void InitProcessInfo(){} // RVA: 0x7FFE877660C0
        public void GetProcessId(){} // RVA: 0x7FFE87765E90
        public void GetThreadId(){} // RVA: 0x7FFE86A3EB10
        public void .ctor(){} // RVA: 0x7FFE87766240
    }

    public class TraceFilter : Object
    {
        // ── Methods ──
        public void ShouldTrace(){} // RVA: 0x7FFE877662B0 | overloaded x2
    }

    public class TraceInternal : Object
    {
        public string appName;
        public System.Diagnostics.TraceListenerCollection listeners; // 0x8
        public bool autoFlush; // 0x10
        public bool useGlobalLock; // 0x11
        public int indentLevel; // 0xFFFF

        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x7FFE87766300
        public void get_AutoFlush(){} // RVA: 0x7FFE87766800
        public void get_UseGlobalLock(){} // RVA: 0x7FFE87766860
        public void get_IndentLevel(){} // RVA: 0x7FFE877668C0
        public void get_IndentSize(){} // RVA: 0x7FFE87766960
        public void InitializeSettings(){} // RVA: 0x7FFE810FB310
        public void WriteLine(){} // RVA: 0x7FFE877669C0
        public void .cctor(){} // RVA: 0x7FFE87767240
    }

    public class TraceListener : MarshalByRefObject
    {
        public int indentLevel; // 0x18
        public int indentSize; // 0x1C
        public 0x66529A6C traceOptions; // 0x20
        public bool needIndent; // 0x24
        public string listenerName; // 0x28
        public System.Diagnostics.TraceFilter filter; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87767370
        public void get_IsThreadSafe(){} // RVA: 0x7FFE810FB320
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void Flush(){} // RVA: 0x7FFE810FB310
        public void set_IndentLevel(){} // RVA: 0x7FFE87767440
        public void set_IndentSize(){} // RVA: 0x7FFE87767460
        public void get_Filter(){} // RVA: 0x7FFE8144E200
        public void get_NeedIndent(){} // RVA: 0x7FFE811167C0
        public void set_NeedIndent(){} // RVA: 0x7FFE812EB1B0
        public void get_TraceOutputOptions(){} // RVA: 0x7FFE8151D690
        public void Write(){} // RVA: 0x7FFE80E460A0
        public void WriteIndent(){} // RVA: 0x7FFE87767520
        public void WriteLine(){} // RVA: 0x7FFE80E460A0
        public void TraceEvent(){} // RVA: 0x7FFE877675E0
        public void WriteHeader(){} // RVA: 0x7FFE87767800
        public void WriteFooter(){} // RVA: 0x7FFE877679A0
        public void IsEnabled(){} // RVA: 0x7FFE87768400
    }

    public class TraceListenerCollection : Object
    {
        public System.Collections.ArrayList list; // 0x10
        public object field_1; // 0x116
        public object field_2; // 0x117
        public object field_3; // 0x118
        public object field_4; // 0x119
        public object field_5; // 0x11A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87768410
        public void get_Count(){} // RVA: 0x7FFE8154F670
        public void Add(){} // RVA: 0x7FFE87768550
        public void Clear(){} // RVA: 0x7FFE87768730
        public void GetEnumerator(){} // RVA: 0x7FFE8670DE60
        public void InitializeListener(){} // RVA: 0x7FFE877687D0
        public void RemoveAt(){} // RVA: 0x7FFE87768960
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE87768B20
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE87768B50
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE810FB320
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE87768C90
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE8693D400
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE8693D6A0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE87768F30
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE877691D0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE827C4A80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE811E0850
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE87769390
    }

    public class TraceSwitch : Switch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87769550
    }

    public class TypeNameHelper : Object
    {
        // ── Methods ──
        public void GetTypeDisplayName(){} // RVA: 0x7FFE86F95580
        public void AppendTypeDisplayName(){} // RVA: 0x7FFE86F95660
        public void GetTypeNameForGenericType(){} // RVA: 0x7FFE86F956F0
        public void ProcessType(){} // RVA: 0x7FFE86F95810
        public void ProcessArrayType(){} // RVA: 0x7FFE86F95E00
        public void ProcessGenericType(){} // RVA: 0x7FFE86F96010
        public void .cctor(){} // RVA: 0x7FFE86F96640
    }

    public class ValueTupleResolvedParameter : ResolvedParameter
    {
        public System.Collections.Generic.IList`1<string> _tupleNames; // 0x30

        // ── Methods ──
        public void get_TupleNames(){} // RVA: 0x7FFE8144E200
        public void .ctor(){} // RVA: 0x7FFE86F974A0
        public void AppendTypeName(){} // RVA: 0x7FFE86F97550
        public void AppendValueTupleParameterName(){} // RVA: 0x7FFE86F97840
    }

}