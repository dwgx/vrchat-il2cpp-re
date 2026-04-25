// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics
// Classes: 56
// Methods: 428

namespace ThirdParty.DotNet.System.Diagnostics
{
    public class Activity : Object
    {
        public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<string,string>> Source;
        public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<string,object>> Parent; // 0x8
        public System.Collections.Generic.IEnumerable`1<System.Diagnostics.ActivityLink> Duration; // 0x10
        public System.Collections.Generic.IEnumerable`1<System.Diagnostics.ActivityEvent> StartTimeUtc; // 0x18
        public System.Diagnostics.ActivitySource Id; // 0x20
        public string ParentId; // 0x28
        public long RootId; // 0x30
        public System.EventHandler`1<System.Diagnostics.ActivityChangedEventArgs> TagObjects; // 0x38
        public string Baggage; // 0x10
        public 0x6B2D1A18 TraceStateString; // 0x18
        public string SpanId; // 0x20
        public string TraceId; // 0x28
        public string ActivityTraceFlags; // 0x30
        public string ParentSpanId; // 0x38
        public string W3CIdFlagsSet; // 0x40
        public string IsStopped; // 0x48
        public byte IdFormat; // 0x50
        public byte Current; // 0x51
        public TagsLinkedList _tags; // 0x58
        public BaggageLinkedList _baggage; // 0x60
        public System.Collections.Generic.Dictionary`2<string,object> _customProperties; // 0x68
        public System.Diagnostics.Activity _previousActiveActivity; // 0x70
        public System.Diagnostics.ActivitySource <Source>k__BackingField; // 0x78
        public System.Diagnostics.Activity <Parent>k__BackingField; // 0x80
        public System.TimeSpan <Duration>k__BackingField; // 0x88
        public System.DateTime <StartTimeUtc>k__BackingField; // 0x90
        public System.Threading.AsyncLocal`1<System.Diagnostics.Activity> s_current; // 0x40

        // ── Methods ──
        public void get_Source(){} // RVA: 0x7FFAC30E5600
        public void get_Parent(){} // RVA: 0x7FFAC32EF410
        public void get_Duration(){} // RVA: 0x7FFAC2F60010
        public void set_Duration(){} // RVA: 0x7FFAC4A2BA70
        public void get_StartTimeUtc(){} // RVA: 0x7FFAC32EF640
        public void get_Id(){} // RVA: 0x7FFAC8F70C90
        public void get_ParentId(){} // RVA: 0x7FFAC8F70E60
        public void get_RootId(){} // RVA: 0x7FFAC8F71050
        public void get_TagObjects(){} // RVA: 0x7FFAC8F71130
        public void get_Baggage(){} // RVA: 0x7FFAC8F711A0
        public void SetEndTime(){} // RVA: 0x7FFAC8F71240
        public void Stop(){} // RVA: 0x7FFAC8F71460
        public void get_TraceStateString(){} // RVA: 0x7FFAC8F71920
        public void get_SpanId(){} // RVA: 0x7FFAC8F71940
        public void get_TraceId(){} // RVA: 0x7FFAC8F71A80
        public void get_ActivityTraceFlags(){} // RVA: 0x7FFAC8F71B00
        public void set_ActivityTraceFlags(){} // RVA: 0x7FFAC8F71B30
        public void get_ParentSpanId(){} // RVA: 0x7FFAC8F71B40
        public void IsW3CId(){} // RVA: 0x7FFAC8F71DD0
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void SetCustomProperty(){} // RVA: 0x7FFAC8F71ED0
        public void GetCustomProperty(){} // RVA: 0x7FFAC8F721A0
        public void NotifyError(){} // RVA: 0x7FFAC8F72380
        public void GetRootId(){} // RVA: 0x7FFAC8F723C0
        public void GetRandomNumber(){} // RVA: 0x7FFAC8F72440
        public void TrySetTraceIdFromParent(){} // RVA: 0x7FFAC8F72480
        public void TrySetTraceFlagsFromParent(){} // RVA: 0x7FFAC8F728B0
        public void get_W3CIdFlagsSet(){} // RVA: 0x7FFAC8F72B00
        public void get_IsStopped(){} // RVA: 0x7FFAC8F72B10
        public void set_IsStopped(){} // RVA: 0x7FFAC8F72B20
        public void get_IdFormat(){} // RVA: 0x7FFAC8F72B50
        public void get_Current(){} // RVA: 0x7FFAC8F72B60
        public void SetCurrent(){} // RVA: 0x7FFAC8F72BE0
        public void GetUtcNow(){} // RVA: 0x7FFAC8F72D60
        public void .cctor(){} // RVA: 0x7FFAC8F72DB0
        public void <get_Baggage>g__Iterate|87_0(){} // RVA: 0x7FFAC8F73300
    }

    public class ActivityChangedEventArgs : ValueType
    {
        public System.Diagnostics.Activity Previous; // 0x10
        public System.Diagnostics.Activity Current; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC41AE4B0
        public void set_Previous(){} // RVA: 0x7FFAC38DFE40
        public void set_Current(){} // RVA: 0x7FFAC4420240
    }

    public class ActivityContext : ValueType
    {
        public System.Diagnostics.ActivityTraceId TraceId; // 0x10
        public System.Diagnostics.ActivitySpanId SpanId; // 0x18
        public 0x6B2D1B20 TraceFlags; // 0x20
        public string TraceState; // 0x28
        public bool IsRemote; // 0x30

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7FFAC3AD9F60
        public void get_SpanId(){} // RVA: 0x7FFAC4420220
        public void get_TraceFlags(){} // RVA: 0x7FFAC2F6E5C0
        public void get_TraceState(){} // RVA: 0x7FFAC2F247C0
        public void get_IsRemote(){} // RVA: 0x7FFAC300F9D0
        public void Equals(){} // RVA: 0x7FFAC8F74310 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC8F743C0
        public void GetHashCode(){} // RVA: 0x7FFAC8F74400
    }

    public class ActivityEvent : ValueType
    {
        public System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<string,object>> s_emptyTags;
        public TagsLinkedList _tags; // 0x10
        public string <Name>k__BackingField; // 0x18
        public System.DateTimeOffset <Timestamp>k__BackingField; // 0x20

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8F74580
    }

    public class ActivityLink : ValueType
    {
        public TagsLinkedList Context; // 0x10
        public System.Diagnostics.ActivityContext Tags; // 0x18

        // ── Methods ──
        public void get_Context(){} // RVA: 0x7FFAC4ABEA30
        public void get_Tags(){} // RVA: 0x7FFAC3AD9F60
        public void Equals(){} // RVA: 0x7FFAC8F74750 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFAC8F747E0
        public void GetHashCode(){} // RVA: 0x7FFAC8F74890
    }

    public class ActivityListener : Object
    {
        public System.Action`1<System.Diagnostics.Activity> ActivityStopped; // 0x10
        public System.Func`2<System.Diagnostics.ActivitySource,bool> ShouldListenTo; // 0x18

        // ── Methods ──
        public void get_ActivityStopped(){} // RVA: 0x7FFAC2F3C380
        public void get_ShouldListenTo(){} // RVA: 0x7FFAC2F247C0
        public void Dispose(){} // RVA: 0x7FFAC8F74BD0
    }

    public class ActivitySource : Object
    {
        public System.Diagnostics.SynchronizedList`1<System.Diagnostics.ActivitySource> s_activeSources;
        public System.Diagnostics.SynchronizedList`1<System.Diagnostics.ActivityListener> s_allListeners; // 0x8
        public System.Diagnostics.SynchronizedList`1<System.Diagnostics.ActivityListener> _listeners; // 0x10
        public string <Name>k__BackingField; // 0x18
        public string <Version>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F74C20
        public void Dispose(){} // RVA: 0x7FFAC8F74F80
        public void AddListener(){} // RVA: 0x7FFAC8F75060
        public void DetachListener(){} // RVA: 0x7FFAC8F75160
        public void NotifyActivityStop(){} // RVA: 0x7FFAC8F75350
        public void .cctor(){} // RVA: 0x7FFAC8F754C0
    }

    public class ActivitySpanId : ValueType
    {
        public string _hexString; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void CreateFromString(){} // RVA: 0x7FFAC8F73F00
        public void ToHexString(){} // RVA: 0x7FFAC8F740A0
        public void ToString(){} // RVA: 0x7FFAC8F740A0
        public void Equals(){} // RVA: 0x7FFAC8F740F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8F741B0
    }

    public class ActivityTraceId : ValueType
    {
        public string _hexString; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
        public void CreateFromString(){} // RVA: 0x7FFAC8F73A80
        public void ToHexString(){} // RVA: 0x7FFAC8F73C20
        public void ToString(){} // RVA: 0x7FFAC8F73C20
        public void Equals(){} // RVA: 0x7FFAC8F73C70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8F73D30
        public void HexByteFromChars(){} // RVA: 0x7FFAC8F73D90
        public void IsLowerCaseHexAndNotAllZeros(){} // RVA: 0x7FFAC8F73E50
    }

    public class AsyncStreamReader : Object
    {
        public System.IO.Stream stream; // 0x10
        public System.Text.Encoding encoding; // 0x18
        public System.Text.Decoder decoder; // 0x20
        public byte[] byteBuffer; // 0x28
        public char[] charBuffer; // 0x30
        public bool cancelOperation; // 0x38
        public System.Threading.ManualResetEvent eofEvent; // 0x40
        public object syncObject; // 0x48
        public System.IAsyncResult asyncReadResult; // 0x50

        // ── Methods ──
        public void Close(){} // RVA: 0x7FFAC2F6EFC0
        public void Dispose(){} // RVA: 0x7FFAC93C0EC0
        public void CancelOperation(){} // RVA: 0x7FFAC3C4CFE0
    }

    public class BooleanSwitch : Switch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93BC270
    }

    public class ConditionalAttribute : Attribute
    {
        public string <ConditionString>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class CorrelationManager : Object
    {
        public object LogicalOperationStack;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_LogicalOperationStack(){} // RVA: 0x7FFAC93BC310
        public void GetLogicalOperationStack(){} // RVA: 0x7FFAC93BC320
    }

    public class DebuggableAttribute : Attribute
    {
        public 0x6B0DC928 m_debuggingModes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class Debugger : Object
    {
        public string IsAttached;

        // ── Methods ──
        public void get_IsAttached(){} // RVA: 0x7FFAC858D780
        public void IsAttached_internal(){} // RVA: 0x7FFAC858D7D0
        public void IsLogging(){} // RVA: 0x7FFAC2F21320
        public void Log_icall(){} // RVA: 0x7FFAC2F21310
        public void Log(){} // RVA: 0x7FFAC858D7F0
        public void NotifyOfCrossThreadDependency(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC858D840
    }

    public class DebuggerBrowsableAttribute : Attribute
    {
        public 0x6B0DC9D8 state; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC858D440
    }

    public class DebuggerDisplayAttribute : Attribute
    {
        public string Name; // 0x10
        public string Type; // 0x18
        public string type; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC858D5C0
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void set_Type(){} // RVA: 0x7FFAC2F4F0D0
    }

    public class DebuggerHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DebuggerNonUserCodeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DebuggerStepThroughAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DebuggerTypeProxyAttribute : Attribute
    {
        public string typeName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC858D4B0
    }

    public class DefaultTraceListener : TraceListener
    {
        public bool LogFileName;
        public string MonoTracePrefix; // 0x8
        public string MonoTraceFile; // 0x10
        public string logFileName; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC93C7080
        public void GetPrefix(){} // RVA: 0x7FFAC93C7310
        public void .ctor(){} // RVA: 0x7FFAC93C7390
        public void get_LogFileName(){} // RVA: 0x7FFAC31D0140
        public void WriteWindowsDebugString(){} // RVA: 0x7FFAC93C7420
        public void WriteDebugString(){} // RVA: 0x7FFAC93C7430
        public void WriteMonoTrace(){} // RVA: 0x7FFAC93C74D0
        public void WritePrefix(){} // RVA: 0x7FFAC93C76F0
        public void WriteImpl(){} // RVA: 0x7FFAC93C7780
        public void WriteLogFile(){} // RVA: 0x7FFAC93C7910
        public void Write(){} // RVA: 0x7FFAC93C7B20
        public void WriteLine(){} // RVA: 0x7FFAC93C7B30
    }

    public class DiagEnumerator`1 : ValueType
    {
        public System.Diagnostics.DiagNode`1<T> Current;
        public System.Diagnostics.DiagNode`1<T> System.Collections.IEnumerator.Current;
        public System.Diagnostics.DiagNode`1<T> _currentNode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void get_Current(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x7FFAC2C58E90
        public void MoveNext(){} // RVA: 0x7FFAC2C59D00
        public void Reset(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class DiagNode`1 : Object
    {
        public T Value;
        public System.Diagnostics.DiagNode`1<T> Next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
    }

    public class DiagnosticSourceEventSource : EventSource
    {
        public System.Diagnostics.DiagnosticSourceEventSource Log;
        public string AspNetCoreHostingKeywordValue; // 0x20
        public string EntityFrameworkCoreCommandsKeywordValue; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8F759C0
        public void .cctor(){} // RVA: 0x7FFAC8F75AD0
    }

    public class DiagnosticsConfigurationHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC936C3F0
        public void Create(){} // RVA: 0x7FFAC936C420
    }

    public class EnhancedStackFrame : StackFrame
    {
        public string StackFrame; // 0x48
        public int IsRecursive; // 0x50
        public int MethodInfo; // 0x54
        public System.Diagnostics.StackFrame <StackFrame>k__BackingField; // 0x58
        public System.Diagnostics.ResolvedMethod <MethodInfo>k__BackingField; // 0x60

        // ── Methods ──
        public void get_StackFrame(){} // RVA: 0x7FFAC2FE9500
        public void get_IsRecursive(){} // RVA: 0x7FFAC8BE3D50
        public void set_IsRecursive(){} // RVA: 0x7FFAC8BE3D70
        public void get_MethodInfo(){} // RVA: 0x7FFAC2FBF370
        public void .ctor(){} // RVA: 0x7FFAC8BE3D90
        public void IsEquivalent(){} // RVA: 0x7FFAC8BE3EF0
        public void GetFileColumnNumber(){} // RVA: 0x7FFAC38913D0
        public void GetFileLineNumber(){} // RVA: 0x7FFAC30F10E0
        public void GetFileName(){} // RVA: 0x7FFAC2F9C730
        public void GetILOffset(){} // RVA: 0x7FFAC8BE3F80
        public void GetMethod(){} // RVA: 0x7FFAC8BE3FB0
        public void GetNativeOffset(){} // RVA: 0x7FFAC8BE3FE0
        public void ToString(){} // RVA: 0x7FFAC8BE4010
    }

    public class EnhancedStackTrace : StackTrace
    {
        public System.Collections.Generic.List`1<System.Diagnostics.EnhancedStackFrame> FrameCount; // 0x28
        public System.Type StackTraceHiddenAttributeType;
        public System.Type AsyncIteratorStateMachineAttributeType; // 0x8

        // ── Methods ──
        public void Current(){} // RVA: 0x7FFAC8BE4040
        public void .ctor(){} // RVA: 0x7FFAC8BE4350 | overloaded x2
        public void get_FrameCount(){} // RVA: 0x7FFAC8BE4460
        public void GetFrame(){} // RVA: 0x7FFAC8BE44B0
        public void GetFrames(){} // RVA: 0x7FFAC8BE4EF0 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAC8BE4580
        public void Append(){} // RVA: 0x7FFAC8BE4650
        public void GetEnumerator(){} // RVA: 0x7FFAC8BE4860
        public void System.Collections.Generic.IEnumerable<System.Diagnostics.EnhancedStackFrame>.GetEnumerator(){} // RVA: 0x7FFAC8BE48A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8BE4990
        public void TryGetFullPath(){} // RVA: 0x7FFAC8BE4A80
        public void .cctor(){} // RVA: 0x7FFAC8BE4B40
        public void GetMethodDisplayString(){} // RVA: 0x7FFAC8BE5370
        public void IsFSharpAsync(){} // RVA: 0x7FFAC8BE6440
        public void TryResolveGeneratedName(){} // RVA: 0x7FFAC8BE65C0
        public void TryResolveSourceMethod(){} // RVA: 0x7FFAC8BE7120
        public void GetOrdinal(){} // RVA: 0x7FFAC8BE7770
        public void GetMatchHint(){} // RVA: 0x7FFAC8BE7AC0
        public void TryParseGeneratedName(){} // RVA: 0x7FFAC8BE7BD0
        public void IndexOfBalancedParenthesis(){} // RVA: 0x7FFAC8BE7F10
        public void GetPrefix(){} // RVA: 0x7FFAC8BE7FB0
        public void GetParameter(){} // RVA: 0x7FFAC8BE81B0
        public void GetValueTupleParameter(){} // RVA: 0x7FFAC8BE86D0
        public void GetValueTupleParameterName(){} // RVA: 0x7FFAC8BE8890
        public void ShowInStackTrace(){} // RVA: 0x7FFAC8BE8AD0
        public void IsStackTraceHidden(){} // RVA: 0x7FFAC8BE9A20
        public void TryResolveStateMachineMethod(){} // RVA: 0x7FFAC8BE9E60
        public void <TryResolveStateMachineMethod>g__GetDeclaredMethods|33_0(){} // RVA: 0x7FFAC8BEA380
    }

    public class ExceptionExtensions : Object
    {
        public System.Reflection.FieldInfo stackTraceString;

        // ── Methods ──
        public void SetStackTracesString(){} // RVA: 0x7FFAC8BEA650
        public void Demystify(){} // RVA: 0x7FFAC2E8DC40
        public void ToStringDemystified(){} // RVA: 0x7FFAC8BEA6D0
        public void .cctor(){} // RVA: 0x7FFAC8BEA760
    }

    public class MonitoringDescriptionAttribute : DescriptionAttribute
    {
        public object Description;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93C7B80
        public void get_Description(){} // RVA: 0x7FFAC2F3C380
    }

    public class Process : Component
    {
        public bool Associated; // 0x28
        public int HasExited; // 0x2C
        public bool Handle; // 0x30
        public Microsoft.Win32.SafeHandles.SafeProcessHandle Id; // 0x38
        public bool StartInfo; // 0x40
        public string StartTime; // 0x48
        public int SynchronizingObject; // 0x50
        public System.Diagnostics.ProcessThreadCollection ProcessName; // 0x58
        public System.Diagnostics.ProcessModuleCollection IsWindows; // 0x60
        public bool haveWorkingSetLimits; // 0x68
        public bool havePriorityClass; // 0x69
        public System.Diagnostics.ProcessStartInfo startInfo; // 0x70
        public bool watchForExit; // 0x78
        public bool watchingForExit; // 0x79
        public System.EventHandler onExited; // 0x80
        public bool exited; // 0x88
        public int exitCode; // 0x8C
        public bool signaled; // 0x90
        public bool haveExitTime; // 0x91
        public bool raisedOnExited; // 0x92
        public System.Threading.RegisteredWaitHandle registeredWaitHandle; // 0x98
        public System.Threading.WaitHandle waitHandle; // 0xA0
        public System.ComponentModel.ISynchronizeInvoke synchronizingObject; // 0xA8
        public System.IO.StreamReader standardOutput; // 0xB0
        public System.IO.StreamWriter standardInput; // 0xB8
        public System.IO.StreamReader standardError; // 0xC0
        public bool disposed; // 0xC8
        public 0x6B130C50 outputStreamReadMode; // 0xCC
        public 0x6B130C50 errorStreamReadMode; // 0xD0
        public 0x6B130C50 inputStreamReadMode; // 0xD4
        public System.Diagnostics.AsyncStreamReader output; // 0xD8
        public System.Diagnostics.AsyncStreamReader error; // 0xE0
        public string process_name; // 0xE8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93C14D0 | overloaded x2
        public void get_Associated(){} // RVA: 0x7FFAC93C15B0
        public void get_HasExited(){} // RVA: 0x7FFAC93C15C0
        public void GetProcessTimes(){} // RVA: 0x7FFAC93C1970
        public void get_Handle(){} // RVA: 0x7FFAC93C1BE0
        public void get_Id(){} // RVA: 0x7FFAC93C1CB0
        public void get_StartInfo(){} // RVA: 0x7FFAC93C1CD0
        public void set_StartInfo(){} // RVA: 0x7FFAC93C1E30
        public void get_StartTime(){} // RVA: 0x7FFAC93C1EE0
        public void get_SynchronizingObject(){} // RVA: 0x7FFAC93C1F60
        public void ReleaseProcessHandle(){} // RVA: 0x7FFAC93C2130
        public void CompletionCallback(){} // RVA: 0x7FFAC93C2160
        public void Dispose(){} // RVA: 0x7FFAC93C2180
        public void Close(){} // RVA: 0x7FFAC93C21D0
        public void EnsureState(){} // RVA: 0x7FFAC93C2660
        public void EnsureWatchingForExit(){} // RVA: 0x7FFAC93C28E0
        public void GetCurrentProcess(){} // RVA: 0x7FFAC93C2AC0
        public void OnExited(){} // RVA: 0x7FFAC93C2BD0
        public void GetProcessHandle(){} // RVA: 0x7FFAC93C3410 | overloaded x2
        public void OpenProcessHandle(){} // RVA: 0x7FFAC93C3420
        public void Refresh(){} // RVA: 0x7FFAC93C34D0
        public void SetProcessHandle(){} // RVA: 0x7FFAC93C3590
        public void SetProcessId(){} // RVA: 0x7FFAC93C3600
        public void Start(){} // RVA: 0x7FFAC93C3AB0 | overloaded x3
        public void Kill(){} // RVA: 0x7FFAC93C3C70
        public void StopWatchingForExit(){} // RVA: 0x7FFAC93C3D60
        public void ToString(){} // RVA: 0x7FFAC93C3FB0
        public void ProcessName_icall(){} // RVA: 0x7FFAC93C40D0
        public void ProcessName_internal(){} // RVA: 0x7FFAC93C4170
        public void get_ProcessName(){} // RVA: 0x7FFAC93C42F0
        public void ShellExecuteEx_internal(){} // RVA: 0x7FFAC2F21320
        public void CreateProcess_internal(){} // RVA: 0x7FFAC2F21320
        public void StartWithShellExecuteEx(){} // RVA: 0x7FFAC93C45D0
        public void CreatePipe(){} // RVA: 0x7FFAC93C4A00
        public void get_IsWindows(){} // RVA: 0x7FFAC85FF0B0
        public void StartWithCreateProcess(){} // RVA: 0x7FFAC93C4E20
        public void FillUserInfo(){} // RVA: 0x7FFAC93C6030
        public void RaiseOnExited(){} // RVA: 0x7FFAC93C6310
    }

    public class ProcessInfo : Object
    {
    }

    public class ProcessModuleCollection : ReadOnlyCollectionBase
    {
    }

    public class ProcessStartInfo : Object
    {
        public string ArgumentList; // 0x10
        public string Arguments; // 0x18
        public string EnvironmentVariables; // 0x20
        public string RedirectStandardInput; // 0x28
        public 0x6B1310C8 RedirectStandardOutput; // 0x30
        public bool RedirectStandardError; // 0x34
        public UIntPtr StandardErrorEncoding; // 0x38
        public bool StandardOutputEncoding; // 0x40
        public string UseShellExecute; // 0x48
        public string UserName; // 0x50
        public System.Security.SecureString Password; // 0x58
        public string Domain; // 0x60
        public bool LoadUserProfile; // 0x68
        public bool FileName; // 0x69
        public bool WorkingDirectory; // 0x6A
        public bool HaveEnvVars; // 0x6B
        public System.Text.Encoding StandardInputEncoding; // 0x70
        public System.Text.Encoding standardErrorEncoding; // 0x78
        public bool createNoWindow; // 0x80
        public System.WeakReference weakParentProcess; // 0x88
        public System.Collections.Specialized.StringDictionary environmentVariables; // 0x90
        public string[] empty;
        public System.Collections.ObjectModel.Collection`1<string> _argumentList; // 0x98
        public System.Collections.Generic.IDictionary`2<string,string> environment; // 0xA0
        public System.Text.Encoding <StandardInputEncoding>k__BackingField; // 0xA8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93C65A0 | overloaded x2
        public void get_ArgumentList(){} // RVA: 0x7FFAC93C6660
        public void get_Arguments(){} // RVA: 0x7FFAC93C6730
        public void set_Arguments(){} // RVA: 0x7FFAC2F87E80
        public void get_EnvironmentVariables(){} // RVA: 0x7FFAC93C6790
        public void get_RedirectStandardInput(){} // RVA: 0x7FFAC4670BD0
        public void get_RedirectStandardOutput(){} // RVA: 0x7FFAC8290C80
        public void get_RedirectStandardError(){} // RVA: 0x7FFAC92601C0
        public void get_StandardErrorEncoding(){} // RVA: 0x7FFAC30E5600
        public void get_StandardOutputEncoding(){} // RVA: 0x7FFAC2FE9590
        public void get_UseShellExecute(){} // RVA: 0x7FFAC2FDCC00
        public void get_UserName(){} // RVA: 0x7FFAC93C6DE0
        public void get_Password(){} // RVA: 0x7FFAC2FE9500
        public void get_Domain(){} // RVA: 0x7FFAC93C6E40
        public void get_LoadUserProfile(){} // RVA: 0x7FFAC2FE9570
        public void get_FileName(){} // RVA: 0x7FFAC93C6EA0
        public void get_WorkingDirectory(){} // RVA: 0x7FFAC93C6F00
        public void get_HaveEnvVars(){} // RVA: 0x7FFAC93C6F60
        public void get_StandardInputEncoding(){} // RVA: 0x7FFAC354B1A0
        public void .cctor(){} // RVA: 0x7FFAC93C6F70
    }

    public class ProcessThreadCollection : ReadOnlyCollectionBase
    {
    }

    public class ProcessThreadTimes : Object
    {
        public long StartTime; // 0x10
        public long exit; // 0x18
        public long kernel; // 0x20
        public long user; // 0x28

        // ── Methods ──
        public void get_StartTime(){} // RVA: 0x7FFAC93C6470
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ProcessWaitHandle : WaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93C7020
    }

    public class ResolvedMethod : Object
    {
        public System.Reflection.MethodBase MethodBase; // 0x10
        public System.Type DeclaringType; // 0x18
        public bool IsAsync; // 0x20
        public bool IsLambda; // 0x21
        public System.Diagnostics.ResolvedParameter ReturnParameter; // 0x28
        public string Name; // 0x30
        public System.Nullable`1<int> Ordinal; // 0x38
        public string GenericArguments; // 0x40
        public System.Type[] ResolvedGenericArguments; // 0x48
        public System.Reflection.MethodBase SubMethodBase; // 0x50
        public string SubMethod; // 0x58
        public System.Collections.Generic.Enumerable.EnumerableIList`1<System.Diagnostics.ResolvedParameter> Parameters; // 0x60
        public System.Collections.Generic.Enumerable.EnumerableIList`1<System.Diagnostics.ResolvedParameter> SubMethodParameters; // 0x68
        public int RecurseCount; // 0x70

        // ── Methods ──
        public void get_MethodBase(){} // RVA: 0x7FFAC2F3C380
        public void set_MethodBase(){} // RVA: 0x7FFAC2F22E30
        public void get_DeclaringType(){} // RVA: 0x7FFAC2F247C0
        public void set_DeclaringType(){} // RVA: 0x7FFAC2F87E80
        public void get_IsAsync(){} // RVA: 0x7FFAC300F9D0
        public void set_IsAsync(){} // RVA: 0x7FFAC300F9E0
        public void get_IsLambda(){} // RVA: 0x7FFAC322AD20
        public void set_IsLambda(){} // RVA: 0x7FFAC376A610
        public void get_ReturnParameter(){} // RVA: 0x7FFAC2F4F130
        public void set_ReturnParameter(){} // RVA: 0x7FFAC2F22E90
        public void get_Name(){} // RVA: 0x7FFAC31D95E0
        public void set_Name(){} // RVA: 0x7FFAC2F4F890
        public void get_Ordinal(){} // RVA: 0x7FFAC31D0140
        public void set_Ordinal(){} // RVA: 0x7FFAC35233F0
        public void get_GenericArguments(){} // RVA: 0x7FFAC2F9E740
        public void set_GenericArguments(){} // RVA: 0x7FFAC2F49200
        public void get_ResolvedGenericArguments(){} // RVA: 0x7FFAC2F9C730
        public void set_ResolvedGenericArguments(){} // RVA: 0x7FFAC2F9C740
        public void get_SubMethodBase(){} // RVA: 0x7FFAC2FC20E0
        public void set_SubMethodBase(){} // RVA: 0x7FFAC30794D0
        public void get_SubMethod(){} // RVA: 0x7FFAC2FE9500
        public void set_SubMethod(){} // RVA: 0x7FFAC2FE9510
        public void get_Parameters(){} // RVA: 0x7FFAC2FBF370
        public void set_Parameters(){} // RVA: 0x7FFAC2FBF380
        public void get_SubMethodParameters(){} // RVA: 0x7FFAC2F9CD50
        public void set_SubMethodParameters(){} // RVA: 0x7FFAC2F9CD60
        public void get_RecurseCount(){} // RVA: 0x7FFAC3B99E80
        public void set_RecurseCount(){} // RVA: 0x7FFAC30B6520
        public void IsSequentialEquivalent(){} // RVA: 0x7FFAC8BEA8C0
        public void ToString(){} // RVA: 0x7FFAC8BEAA90
        public void Append(){} // RVA: 0x7FFAC8BEAB30 | overloaded x2
        public void AppendDeclaringTypeName(){} // RVA: 0x7FFAC8BEB570
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ResolvedParameter : Object
    {
        public string Name; // 0x10
        public System.Type ResolvedType; // 0x18
        public string Prefix; // 0x20
        public bool IsDynamicType; // 0x28

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void get_ResolvedType(){} // RVA: 0x7FFAC2F247C0
        public void set_ResolvedType(){} // RVA: 0x7FFAC2F87E80
        public void get_Prefix(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Prefix(){} // RVA: 0x7FFAC2F4F0D0
        public void get_IsDynamicType(){} // RVA: 0x7FFAC30F6BA0
        public void set_IsDynamicType(){} // RVA: 0x7FFAC3C24F40
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
        public void ToString(){} // RVA: 0x7FFAC8BEB630
        public void Append(){} // RVA: 0x7FFAC8BEB6C0
        public void AppendTypeName(){} // RVA: 0x7FFAC8BEB950
    }

    public class StackFrame : Object
    {
        public int OFFSET_UNKNOWN;
        public int ilOffset; // 0x10
        public int nativeOffset; // 0x14
        public long methodAddress; // 0x18
        public uint methodIndex; // 0x20
        public System.Reflection.MethodBase methodBase; // 0x28
        public string fileName; // 0x30
        public int lineNumber; // 0x38
        public int columnNumber; // 0x3C
        public string internalMethodName; // 0x40

        // ── Methods ──
        public void get_frame_info(){} // RVA: 0x7FFAC858D8F0
        public void .ctor(){} // RVA: 0x7FFAC858D9B0 | overloaded x3
        public void GetFileLineNumber(){} // RVA: 0x7FFAC358A870
        public void GetFileColumnNumber(){} // RVA: 0x7FFAC33BD4A0
        public void GetFileName(){} // RVA: 0x7FFAC31D95E0
        public void GetSecureFileName(){} // RVA: 0x7FFAC858DA70
        public void GetILOffset(){} // RVA: 0x7FFAC2F6E5C0
        public void GetMethod(){} // RVA: 0x7FFAC2F4F130
        public void GetNativeOffset(){} // RVA: 0x7FFAC33D5A20
        public void GetMethodAddress(){} // RVA: 0x7FFAC2F247C0
        public void GetMethodIndex(){} // RVA: 0x7FFAC30DBBE0
        public void GetInternalMethodName(){} // RVA: 0x7FFAC2F9E740
        public void ToString(){} // RVA: 0x7FFAC858DAE0
    }

    public class StackTrace : Object
    {
        public int FrameCount;
        public string prefix;
        public System.Diagnostics.StackFrame[] frames; // 0x10
        public System.Diagnostics.StackTrace[] captured_traces; // 0x18
        public bool debug_info; // 0x20
        public bool isAotidSet;
        public string aotid; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x11
        public void init_frames(){} // RVA: 0x7FFAC858DD60
        public void get_trace(){} // RVA: 0x7FFAC858E000
        public void get_FrameCount(){} // RVA: 0x7FFAC610DBD0
        public void GetFrame(){} // RVA: 0x7FFAC858E3D0
        public void GetFrames(){} // RVA: 0x7FFAC858E440
        public void GetAotId(){} // RVA: 0x7FFAC858E600
        public void AddFrames(){} // RVA: 0x7FFAC858E6B0
        public void GetFullNameForStackTrace(){} // RVA: 0x7FFAC858EC60
        public void ConvertAsyncStateMachineMethod(){} // RVA: 0x7FFAC858F400
        public void ToString(){} // RVA: 0x7FFAC858F850 | overloaded x2
    }

    public class StackTraceHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Stopwatch : Object
    {
        public long Elapsed;
        public bool ElapsedMilliseconds; // 0x8
        public long ElapsedTicks; // 0x10
        public long IsRunning; // 0x18
        public bool is_running; // 0x20

        // ── Methods ──
        public void GetTimestamp(){} // RVA: 0x7FFAC86D7DC0
        public void StartNew(){} // RVA: 0x7FFAC93C7C20
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_Elapsed(){} // RVA: 0x7FFAC93C7CC0
        public void get_ElapsedMilliseconds(){} // RVA: 0x7FFAC93C7DD0
        public void get_ElapsedTicks(){} // RVA: 0x7FFAC93C7F20
        public void get_IsRunning(){} // RVA: 0x7FFAC300F9D0
        public void Reset(){} // RVA: 0x7FFAC93C7F90
        public void Start(){} // RVA: 0x7FFAC93C7FA0
        public void Stop(){} // RVA: 0x7FFAC93C8000
        public void Restart(){} // RVA: 0x7FFAC93C8080
        public void .cctor(){} // RVA: 0x7FFAC93C80E0
    }

    public class StringBuilderExtentions : Object
    {
        // ── Methods ──
        public void AppendDemystified(){} // RVA: 0x7FFAC8BEB9C0
        public void AppendInnerException(){} // RVA: 0x7FFAC8BEBE70
    }

    public class Switch : Object
    {
        public string description; // 0x10
        public string displayName; // 0x18
        public string switchValueString; // 0x20
        public string defaultValue; // 0x28
        public System.Collections.Generic.List`1<System.WeakReference> switches;
        public int s_LastCollectionCount; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93BC680 | overloaded x2
        public void _pruneCachedSwitches(){} // RVA: 0x7FFAC93BCA70
        public void .cctor(){} // RVA: 0x7FFAC93BD0D0
    }

    public class SwitchLevelAttribute : Attribute
    {
        public System.Type SwitchLevelType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93BD1B0
        public void set_SwitchLevelType(){} // RVA: 0x7FFAC93BD1B0
    }

    public class SynchronizedList`1 : Object
    {
        public System.Collections.Generic.List`1<T> Count;
        public uint _version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void AddIfNotExist(){} // RVA: 0x7FFAC2E8DC40
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void EnumWithAction(){} // RVA: 0x7FFAC2C79B30
    }

    public class Trace : Object
    {
        public System.Diagnostics.CorrelationManager Listeners;

        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x7FFAC93BD2A0
        public void get_AutoFlush(){} // RVA: 0x7FFAC93BD2F0
        public void get_CorrelationManager(){} // RVA: 0x7FFAC93BD380
        public void WriteLine(){} // RVA: 0x7FFAC93BD460
    }

    public class TraceEventCache : Object
    {
        public int Callstack;
        public string LogicalOperationStack; // 0x8
        public long DateTime; // 0x10
        public System.DateTime ProcessId; // 0x18
        public string ThreadId; // 0x20

        // ── Methods ──
        public void get_Callstack(){} // RVA: 0x7FFAC93BD4B0
        public void get_LogicalOperationStack(){} // RVA: 0x7FFAC93BD590
        public void get_DateTime(){} // RVA: 0x7FFAC93BD680
        public void get_ProcessId(){} // RVA: 0x7FFAC93BD760
        public void get_ThreadId(){} // RVA: 0x7FFAC93BD7B0
        public void get_Timestamp(){} // RVA: 0x7FFAC93BD930
        public void InitProcessInfo(){} // RVA: 0x7FFAC93BD990
        public void GetProcessId(){} // RVA: 0x7FFAC93BD760
        public void GetThreadId(){} // RVA: 0x7FFAC8695330
        public void .ctor(){} // RVA: 0x7FFAC93BDB10
    }

    public class TraceFilter : Object
    {
        // ── Methods ──
        public void ShouldTrace(){} // RVA: 0x7FFAC93BDB80 | overloaded x2
    }

    public class TraceInternal : Object
    {
        public string Listeners;
        public System.Diagnostics.TraceListenerCollection AutoFlush; // 0x8
        public bool UseGlobalLock; // 0x10
        public bool IndentLevel; // 0x11
        public int IndentSize; // 0xFFFF
        public int indentSize; // 0x14
        public object critSec; // 0x18

        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x7FFAC93BDBD0
        public void get_AutoFlush(){} // RVA: 0x7FFAC93BE0D0
        public void get_UseGlobalLock(){} // RVA: 0x7FFAC93BE130
        public void get_IndentLevel(){} // RVA: 0x7FFAC93BE190
        public void get_IndentSize(){} // RVA: 0x7FFAC93BE230
        public void InitializeSettings(){} // RVA: 0x7FFAC2F21310
        public void WriteLine(){} // RVA: 0x7FFAC93BE290
        public void .cctor(){} // RVA: 0x7FFAC93BEB10
    }

    public class TraceListener : MarshalByRefObject
    {
        public int IsThreadSafe; // 0x18
        public int IndentLevel; // 0x1C
        public 0x6B130B48 IndentSize; // 0x20
        public bool Filter; // 0x24
        public string NeedIndent; // 0x28
        public System.Diagnostics.TraceFilter TraceOutputOptions; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93BEC40
        public void get_IsThreadSafe(){} // RVA: 0x7FFAC2F21320
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void Flush(){} // RVA: 0x7FFAC2F21310
        public void set_IndentLevel(){} // RVA: 0x7FFAC93BED10
        public void set_IndentSize(){} // RVA: 0x7FFAC93BED30
        public void get_Filter(){} // RVA: 0x7FFAC31D95E0
        public void get_NeedIndent(){} // RVA: 0x7FFAC2F3C7C0
        public void set_NeedIndent(){} // RVA: 0x7FFAC4422FB0
        public void get_TraceOutputOptions(){} // RVA: 0x7FFAC30DBBE0
        public void Write(){} // RVA: 0x7FFAC2C70A40
        public void WriteIndent(){} // RVA: 0x7FFAC93BEDF0
        public void WriteLine(){} // RVA: 0x7FFAC2C70A40
        public void TraceEvent(){} // RVA: 0x7FFAC93BEEB0
        public void WriteHeader(){} // RVA: 0x7FFAC93BF0D0
        public void WriteFooter(){} // RVA: 0x7FFAC93BF270
        public void IsEnabled(){} // RVA: 0x7FFAC93BFCD0
    }

    public class TraceListenerCollection : Object
    {
        public System.Collections.ArrayList Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93BFCE0
        public void get_Count(){} // RVA: 0x7FFAC8593680
        public void Add(){} // RVA: 0x7FFAC93BFE20
        public void Clear(){} // RVA: 0x7FFAC93C0000
        public void GetEnumerator(){} // RVA: 0x7FFAC8364560
        public void InitializeListener(){} // RVA: 0x7FFAC93C00A0
        public void RemoveAt(){} // RVA: 0x7FFAC93C0230
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC93C03F0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC93C0420
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC93C0560
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC8593C20
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC8593EC0
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC93C0800
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC93C0AA0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC44F81E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC3006850
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC93C0C60
    }

    public class TraceSwitch : Switch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93C0E20
    }

    public class TypeNameHelper : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,string> BuiltInTypeNames;
        public System.Collections.Generic.Dictionary`2<string,string> FSharpTypeNames; // 0x8

        // ── Methods ──
        public void GetTypeDisplayName(){} // RVA: 0x7FFAC8BEBF20
        public void AppendTypeDisplayName(){} // RVA: 0x7FFAC8BEC000
        public void GetTypeNameForGenericType(){} // RVA: 0x7FFAC8BEC090
        public void ProcessType(){} // RVA: 0x7FFAC8BEC1B0
        public void ProcessArrayType(){} // RVA: 0x7FFAC8BEC7A0
        public void ProcessGenericType(){} // RVA: 0x7FFAC8BEC9B0
        public void .cctor(){} // RVA: 0x7FFAC8BECFE0
    }

    public class ValueTupleResolvedParameter : ResolvedParameter
    {
        public System.Collections.Generic.IList`1<string> TupleNames; // 0x30

        // ── Methods ──
        public void get_TupleNames(){} // RVA: 0x7FFAC31D95E0
        public void .ctor(){} // RVA: 0x7FFAC8BEDE40
        public void AppendTypeName(){} // RVA: 0x7FFAC8BEDEF0
        public void AppendValueTupleParameterName(){} // RVA: 0x7FFAC8BEE1E0
    }

}