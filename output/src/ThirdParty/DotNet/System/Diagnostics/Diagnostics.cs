// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics
// Classes: 57
// Methods: 430

namespace ThirdParty.DotNet.System.Diagnostics
{
    public class Activity : Object
    {
        public object s_emptyBaggageTags;
        public object s_emptyTagObjects;
        public object s_emptyLinks;
        public object s_emptyEvents;
        public object s_defaultSource;
        public object s_uniqSuffix;
        public object s_currentRootId;
        public object CurrentChanged;
        public object _traceState;
        public object _state;
        public object _id;
        public object _rootId;
        public object _parentId;
        public object _parentSpanId;
        public object _traceId;
        public object _spanId;
        public object _w3CIdFlags;
        public object _parentTraceFlags;
        public object _tags;
        public object _baggage;
        public object _customProperties;
        public object _previousActiveActivity;
        public object _source;
        public object _parent;
        public object _duration;
        public object _startTimeUtc;
        public object s_current;

        // ── Methods ──
        public void get_Source(){} // RVA: 0xCD3320
        public void get_Parent(){} // RVA: 0xCD48B0
        public void get_Duration(){} // RVA: 0xB813B0
        public void set_Duration(){} // RVA: 0x13AA640
        public void get_StartTimeUtc(){} // RVA: 0x1069350
        public void get_Id(){} // RVA: 0x723EFB0
        public void get_ParentId(){} // RVA: 0x723F180
        public void get_RootId(){} // RVA: 0x723F370
        public void get_TagObjects(){} // RVA: 0x723F3E0
        public void get_Baggage(){} // RVA: 0x723F450
        public void SetEndTime(){} // RVA: 0x723F4F0
        public void Stop(){} // RVA: 0x723F710
        public void get_TraceStateString(){} // RVA: 0x723FBD0
        public void get_SpanId(){} // RVA: 0x723FBF0
        public void get_TraceId(){} // RVA: 0x723FD30
        public void get_ActivityTraceFlags(){} // RVA: 0x723FDB0
        public void set_ActivityTraceFlags(){} // RVA: 0x723FDE0
        public void get_ParentSpanId(){} // RVA: 0x723FDF0
        public void IsW3CId(){} // RVA: 0x7240080
        public void Dispose(){} // RVA: 0xB43310
        public void SetCustomProperty(){} // RVA: 0x7240180
        public void GetCustomProperty(){} // RVA: 0x7240420
        public void NotifyError(){} // RVA: 0x72405C0
        public void GetRootId(){} // RVA: 0x7240600
        public void GetRandomNumber(){} // RVA: 0x7240760
        public void TrySetTraceIdFromParent(){} // RVA: 0x72407A0
        public void TrySetTraceFlagsFromParent(){} // RVA: 0x7240C00
        public void get_W3CIdFlagsSet(){} // RVA: 0x7240E50
        public void get_IsStopped(){} // RVA: 0x7240E60
        public void set_IsStopped(){} // RVA: 0x7240E70
        public void get_IdFormat(){} // RVA: 0x7240EA0
        public void get_Current(){} // RVA: 0x7240EB0
        public void SetCurrent(){} // RVA: 0x7240F30
        public void GetUtcNow(){} // RVA: 0x72410B0
        public void .cctor(){} // RVA: 0x7241100
        public void <get_Baggage>g__Iterate|87_0(){} // RVA: 0x7241630
    }

    public class ActivityChangedEventArgs : ValueType
    {
        public object _previous;
        public object _current;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
        public void set_Previous(){} // RVA: 0x47F10
        public void set_Current(){} // RVA: 0x77E70
    }

    public class ActivityContext : ValueType
    {
        public object _traceId;
        public object _spanId;
        public object _traceFlags;
        public object _traceState;
        public object _isRemote;

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x77900
        public void get_SpanId(){} // RVA: 0x77ED0
        public void get_TraceFlags(){} // RVA: 0x8C7E0
        public void get_TraceState(){} // RVA: 0x931A0
        public void get_IsRemote(){} // RVA: 0xA62B0
        public void Equals(){} // RVA: 0x908E70
        public void op_Equality(){} // RVA: 0x72426D0
        public void GetHashCode(){} // RVA: 0x908F20
    }

    public class ActivityEvent : ValueType
    {
        public object s_emptyTags;
        public object _tags;
        public object _name;
        public object _timestamp;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x72428A0
    }

    public class ActivityLink : ValueType
    {
        public object _tags;
        public object _context;

        // ── Methods ──
        public void get_Context(){} // RVA: 0xDEB50
        public void get_Tags(){} // RVA: 0x77900
        public void Equals(){} // RVA: 0x9090C0
        public void op_Equality(){} // RVA: 0x7242B00
        public void GetHashCode(){} // RVA: 0x909170
    }

    public class ActivityListener : Object
    {
        public object _activityStopped;
        public object _shouldListenTo;

        // ── Methods ──
        public void get_ActivityStopped(){} // RVA: 0xB5DBF0
        public void get_ShouldListenTo(){} // RVA: 0xB465B0
        public void Dispose(){} // RVA: 0x7242EF0
    }

    public class ActivitySource : Object
    {
        public object s_activeSources;
        public object s_allListeners;
        public object _listeners;
        public object _name;
        public object _version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7242F40
        public void Dispose(){} // RVA: 0x72432A0
        public void AddListener(){} // RVA: 0x7243380
        public void DetachListener(){} // RVA: 0x7243480
        public void NotifyActivityStop(){} // RVA: 0x7243670
        public void .cctor(){} // RVA: 0x72437E0
    }

    public class ActivitySpanId : ValueType
    {
        public object _hexString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void CreateFromString(){} // RVA: 0x7242220
        public void ToHexString(){} // RVA: 0x908930
        public void ToString(){} // RVA: 0x908930
        public void Equals(){} // RVA: 0x908980
        public void GetHashCode(){} // RVA: 0x908A40
    }

    public class ActivityTraceId : ValueType
    {
        public object _hexString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x47F10
        public void CreateFromString(){} // RVA: 0x7241DB0
        public void ToHexString(){} // RVA: 0x9087C0
        public void ToString(){} // RVA: 0x9087C0
        public void Equals(){} // RVA: 0x908810
        public void GetHashCode(){} // RVA: 0x9088D0
        public void HexByteFromChars(){} // RVA: 0x72420B0
        public void IsLowerCaseHexAndNotAllZeros(){} // RVA: 0x7242170
    }

    public class AsyncStreamReader : Object
    {
        public object stream;
        public object encoding;
        public object decoder;
        public object byteBuffer;
        public object charBuffer;
        public object cancelOperation;
        public object eofEvent;
        public object syncObject;
        public object asyncReadResult;

        // ── Methods ──
        public void Close(){} // RVA: 0xB90310
        public void Dispose(){} // RVA: 0x76897C0
        public void CancelOperation(){} // RVA: 0x1A9DEA0
    }

    public class BooleanSwitch : Switch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7684E30
    }

    public class ConditionalAttribute : Attribute
    {
        public object _conditionString;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class CorrelationManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_LogicalOperationStack(){} // RVA: 0x7684ED0
        public void GetLogicalOperationStack(){} // RVA: 0x7684EE0
    }

    public class DebuggableAttribute : Attribute
    {
        public object m_debuggingModes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class Debugger : Object
    {
        public object DefaultCategory;

        // ── Methods ──
        public void get_IsAttached(){} // RVA: 0x686FBB0
        public void IsAttached_internal(){} // RVA: 0x686FC00
        public void IsLogging(){} // RVA: 0xB43320
        public void Log_icall(){} // RVA: 0xB43310
        public void Log(){} // RVA: 0x686FC20
        public void NotifyOfCrossThreadDependency(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x686FC70
    }

    public class DebuggerBrowsableAttribute : Attribute
    {
        public object state;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x686F890
    }

    public class DebuggerDisplayAttribute : Attribute
    {
        public object name;
        public object value;
        public object type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x686F9F0
        public void set_Name(){} // RVA: 0xB44D60
        public void set_Type(){} // RVA: 0xB70100
    }

    public class DebuggerHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DebuggerNonUserCodeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DebuggerStepThroughAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DebuggerTypeProxyAttribute : Attribute
    {
        public object typeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x686F900
    }

    public class DefaultTraceListener : TraceListener
    {
        public object OnWin32;
        public object MonoTracePrefix;
        public object MonoTraceFile;
        public object logFileName;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x768F540
        public void GetPrefix(){} // RVA: 0x768F7E0
        public void .ctor(){} // RVA: 0x768F860
        public void get_LogFileName(){} // RVA: 0xD05CA0
        public void WriteWindowsDebugString(){} // RVA: 0x768F8F0
        public void WriteDebugString(){} // RVA: 0x768F900
        public void WriteMonoTrace(){} // RVA: 0x768F9A0
        public void WritePrefix(){} // RVA: 0x768FBC0
        public void WriteImpl(){} // RVA: 0x768FC50
        public void WriteLogFile(){} // RVA: 0x768FDE0
        public void Write(){} // RVA: 0x7690000
        public void WriteLine(){} // RVA: 0x7690010
    }

    public class DiagEnumerator`1 : ValueType
    {
        public object s_Empty;
        public object _nextNode;
        public object _currentNode;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void get_Current(){} // RVA: 0xA94080
        public void System.Collections.IEnumerator.get_Current(){} // RVA: 0x87C0A0
        public void MoveNext(){} // RVA: 0x87D280
        public void Reset(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class DiagNode`1 : Object
    {
        public object Value;
        public object Next;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
    }

    public class DiagnosticSourceEventSource : EventSource
    {
        public object Log;
        public object AspNetCoreHostingKeywordValue;
        public object EntityFrameworkCoreCommandsKeywordValue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7243CE0
        public void .cctor(){} // RVA: 0x7243DF0
    }

    public class DiagnosticsConfigurationHandler : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7634C70
        public void Create(){} // RVA: 0x7634CA0
    }

    public class EnhancedStackFrame : StackFrame
    {
        public object _fileName;
        public object _lineNumber;
        public object _colNumber;
        public object _stackFrame;
        public object _methodInfo;

        // ── Methods ──
        public void get_StackFrame(){} // RVA: 0xC0FFC0
        public void get_IsRecursive(){} // RVA: 0x6EBD430
        public void set_IsRecursive(){} // RVA: 0x6EBD450
        public void get_MethodInfo(){} // RVA: 0xBE2C60
        public void .ctor(){} // RVA: 0x6EBD470
        public void IsEquivalent(){} // RVA: 0x6EBD5D0
        public void GetFileColumnNumber(){} // RVA: 0x15443F0
        public void GetFileLineNumber(){} // RVA: 0xE32C80
        public void GetFileName(){} // RVA: 0xBBF8F0
        public void GetILOffset(){} // RVA: 0x6EBD660
        public void GetMethod(){} // RVA: 0x6EBD690
        public void GetNativeOffset(){} // RVA: 0x6EBD6C0
        public void ToString(){} // RVA: 0x6EBD6F0
    }

    public class EnhancedStackTrace : StackTrace
    {
        public object _frames;
        public object StackTraceHiddenAttributeType;
        public object AsyncIteratorStateMachineAttributeType;

        // ── Methods ──
        public void Current(){} // RVA: 0x6EBD720
        public void .ctor(){} // RVA: 0x6EBDA30
        public void get_FrameCount(){} // RVA: 0x6EBDB40
        public void GetFrame(){} // RVA: 0x6EBDB90
        public void GetFrames(){} // RVA: 0x6EBE5C0
        public void ToString(){} // RVA: 0x6EBDC60
        public void Append(){} // RVA: 0x6EBDD30
        public void GetEnumerator(){} // RVA: 0x6EBDF40
        public void System.Collections.Generic.IEnumerable<System.Diagnostics.EnhancedStackFrame>.GetEnumerator(){} // RVA: 0x6EBDF80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6EBE070
        public void TryGetFullPath(){} // RVA: 0x6EBE160
        public void .cctor(){} // RVA: 0x6EBE220
        public void GetMethodDisplayString(){} // RVA: 0x6EBEA30
        public void IsFSharpAsync(){} // RVA: 0x6EBFBB0
        public void TryResolveGeneratedName(){} // RVA: 0x6EBFD20
        public void TryResolveSourceMethod(){} // RVA: 0x6EC0860
        public void GetOrdinal(){} // RVA: 0x6EC0E90
        public void GetMatchHint(){} // RVA: 0x6EC11F0
        public void TryParseGeneratedName(){} // RVA: 0x6EC1300
        public void IndexOfBalancedParenthesis(){} // RVA: 0x6EC1640
        public void GetPrefix(){} // RVA: 0x6EC16E0
        public void GetParameter(){} // RVA: 0x6EC18A0
        public void GetValueTupleParameter(){} // RVA: 0x6EC1F10
        public void GetValueTupleParameterName(){} // RVA: 0x6EC20D0
        public void ShowInStackTrace(){} // RVA: 0x6EC2310
        public void IsStackTraceHidden(){} // RVA: 0x6EC32A0
        public void TryResolveStateMachineMethod(){} // RVA: 0x6EC3700
        public void <TryResolveStateMachineMethod>g__GetDeclaredMethods|33_0(){} // RVA: 0x6EC3C10
    }

    public class ExceptionExtensions : Object
    {
        public object stackTraceString;

        // ── Methods ──
        public void SetStackTracesString(){} // RVA: 0x6EC3E60
        public void Demystify(){} // RVA: 0xA94080
        public void ToStringDemystified(){} // RVA: 0x6EC3EE0
        public void .cctor(){} // RVA: 0x6EC3F70
    }

    public class MonitoringDescriptionAttribute : DescriptionAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7690060
        public void get_Description(){} // RVA: 0xB5DBF0
    }

    public class Process : Component
    {
        public object haveProcessId;
        public object processId;
        public object haveProcessHandle;
        public object m_processHandle;
        public object isRemoteMachine;
        public object machineName;
        public object m_processAccess;
        public object threads;
        public object modules;
        public object haveWorkingSetLimits;
        public object havePriorityClass;
        public object startInfo;
        public object watchForExit;
        public object watchingForExit;
        public object onExited;
        public object exited;
        public object exitCode;
        public object signaled;
        public object haveExitTime;
        public object raisedOnExited;
        public object registeredWaitHandle;
        public object waitHandle;
        public object synchronizingObject;
        public object standardOutput;
        public object standardInput;
        public object standardError;
        public object disposed;
        public object outputStreamReadMode;
        public object errorStreamReadMode;
        public object inputStreamReadMode;
        public object output;
        public object error;
        public object process_name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7689D90
        public void get_Associated(){} // RVA: 0x7689E70
        public void get_HasExited(){} // RVA: 0x7689E80
        public void GetProcessTimes(){} // RVA: 0x768A230
        public void get_Handle(){} // RVA: 0x768A480
        public void get_Id(){} // RVA: 0x768A550
        public void get_StartInfo(){} // RVA: 0x768A570
        public void set_StartInfo(){} // RVA: 0x768A6D0
        public void get_StartTime(){} // RVA: 0x768A780
        public void get_SynchronizingObject(){} // RVA: 0x768A800
        public void ReleaseProcessHandle(){} // RVA: 0x768A9E0
        public void CompletionCallback(){} // RVA: 0x768AA10
        public void Dispose(){} // RVA: 0x768AA30
        public void Close(){} // RVA: 0x768AA80
        public void EnsureState(){} // RVA: 0x768AF10
        public void EnsureWatchingForExit(){} // RVA: 0x768B190
        public void GetCurrentProcess(){} // RVA: 0x768B340
        public void OnExited(){} // RVA: 0x768B450
        public void GetProcessHandle(){} // RVA: 0x768BCB0
        public void OpenProcessHandle(){} // RVA: 0x768BCC0
        public void Refresh(){} // RVA: 0x768BD70
        public void SetProcessHandle(){} // RVA: 0x768BE30
        public void SetProcessId(){} // RVA: 0x768BEA0
        public void Start(){} // RVA: 0x768C330
        public void Kill(){} // RVA: 0x768C4F0
        public void StopWatchingForExit(){} // RVA: 0x768C5D0
        public void ToString(){} // RVA: 0x768C7F0
        public void ProcessName_icall(){} // RVA: 0x768C900
        public void ProcessName_internal(){} // RVA: 0x768C9A0
        public void get_ProcessName(){} // RVA: 0x768CB20
        public void ShellExecuteEx_internal(){} // RVA: 0xB43320
        public void CreateProcess_internal(){} // RVA: 0xB43320
        public void StartWithShellExecuteEx(){} // RVA: 0x768CDF0
        public void CreatePipe(){} // RVA: 0x768D1F0
        public void get_IsWindows(){} // RVA: 0x68E0EC0
        public void StartWithCreateProcess(){} // RVA: 0x768D580
        public void FillUserInfo(){} // RVA: 0x768E770
        public void RaiseOnExited(){} // RVA: 0x768E9E0
    }

    public class ProcessStartInfo : Object
    {
        public object fileName;
        public object arguments;
        public object directory;
        public object verb;
        public object windowStyle;
        public object errorDialog;
        public object errorDialogParentHandle;
        public object useShellExecute;
        public object userName;
        public object domain;
        public object password;
        public object passwordInClearText;
        public object loadUserProfile;
        public object redirectStandardInput;
        public object redirectStandardOutput;
        public object redirectStandardError;
        public object standardOutputEncoding;
        public object standardErrorEncoding;
        public object createNoWindow;
        public object weakParentProcess;
        public object environmentVariables;
        public object empty;
        public object _argumentList;
        public object environment;
        public object _standardInputEncoding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x768EC30
        public void get_ArgumentList(){} // RVA: 0x768ECF0
        public void get_Arguments(){} // RVA: 0x7503900
        public void set_Arguments(){} // RVA: 0xBA9BA0
        public void get_EnvironmentVariables(){} // RVA: 0x768EDC0
        public void get_RedirectStandardInput(){} // RVA: 0x6296240
        public void get_RedirectStandardOutput(){} // RVA: 0x6573C70
        public void get_RedirectStandardError(){} // RVA: 0x752DCA0
        public void get_StandardErrorEncoding(){} // RVA: 0xCD3320
        public void get_StandardOutputEncoding(){} // RVA: 0xC10050
        public void get_UseShellExecute(){} // RVA: 0xC02470
        public void get_UserName(){} // RVA: 0x768F3E0
        public void get_Password(){} // RVA: 0xC0FFC0
        public void get_Domain(){} // RVA: 0x768F400
        public void get_LoadUserProfile(){} // RVA: 0xC10030
        public void get_FileName(){} // RVA: 0x7502EF0
        public void get_WorkingDirectory(){} // RVA: 0x752B0B0
        public void get_HaveEnvVars(){} // RVA: 0x768F420
        public void get_StandardInputEncoding(){} // RVA: 0x12EB090
        public void .cctor(){} // RVA: 0x768F430
    }

    public class ProcessThreadTimes : Object
    {
        public object create;
        public object exit;
        public object kernel;
        public object user;

        // ── Methods ──
        public void get_StartTime(){} // RVA: 0x768EB00
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ProcessWaitHandle : WaitHandle
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x768F4E0
    }

    public class ResolvedMethod : Object
    {
        public object _methodBase;
        public object _declaringType;
        public object _isAsync;
        public object _isLambda;
        public object _returnParameter;
        public object _name;
        public object _ordinal;
        public object _genericArguments;
        public object _resolvedGenericArguments;
        public object _subMethodBase;
        public object _subMethod;
        public object _parameters;
        public object _subMethodParameters;
        public object _recurseCount;

        // ── Methods ──
        public void get_MethodBase(){} // RVA: 0xB5DBF0
        public void set_MethodBase(){} // RVA: 0xB44D60
        public void get_DeclaringType(){} // RVA: 0xB465B0
        public void set_DeclaringType(){} // RVA: 0xBA9BA0
        public void get_IsAsync(){} // RVA: 0xC38360
        public void set_IsAsync(){} // RVA: 0xC38370
        public void get_IsLambda(){} // RVA: 0xF45EE0
        public void set_IsLambda(){} // RVA: 0x1AD91E0
        public void get_ReturnParameter(){} // RVA: 0xB70160
        public void set_ReturnParameter(){} // RVA: 0xB44DC0
        public void get_Name(){} // RVA: 0xD33E60
        public void set_Name(){} // RVA: 0xB708C0
        public void get_Ordinal(){} // RVA: 0xD05CA0
        public void set_Ordinal(){} // RVA: 0xE9F6B0
        public void get_GenericArguments(){} // RVA: 0xBC1B30
        public void set_GenericArguments(){} // RVA: 0xB6A8C0
        public void get_ResolvedGenericArguments(){} // RVA: 0xBBF8F0
        public void set_ResolvedGenericArguments(){} // RVA: 0xBBF900
        public void get_SubMethodBase(){} // RVA: 0xBE58B0
        public void set_SubMethodBase(){} // RVA: 0xCA4DF0
        public void get_SubMethod(){} // RVA: 0xC0FFC0
        public void set_SubMethod(){} // RVA: 0xC0FFD0
        public void get_Parameters(){} // RVA: 0xBE2C60
        public void set_Parameters(){} // RVA: 0xBE2C70
        public void get_SubMethodParameters(){} // RVA: 0xBBFF90
        public void set_SubMethodParameters(){} // RVA: 0xBBFFA0
        public void get_RecurseCount(){} // RVA: 0x19C6270
        public void set_RecurseCount(){} // RVA: 0xCE5450
        public void IsSequentialEquivalent(){} // RVA: 0x6EC40A0
        public void ToString(){} // RVA: 0x6EC4260
        public void Append(){} // RVA: 0x6EC4300
        public void AppendDeclaringTypeName(){} // RVA: 0x6EC4D20
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ResolvedParameter : Object
    {
        public object _name;
        public object _resolvedType;
        public object _prefix;
        public object _isDynamicType;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void set_Name(){} // RVA: 0xB44D60
        public void get_ResolvedType(){} // RVA: 0xB465B0
        public void set_ResolvedType(){} // RVA: 0xBA9BA0
        public void get_Prefix(){} // RVA: 0xB700F0
        public void set_Prefix(){} // RVA: 0xB70100
        public void get_IsDynamicType(){} // RVA: 0xF73960
        public void set_IsDynamicType(){} // RVA: 0xF73A60
        public void .ctor(){} // RVA: 0xBA9BA0
        public void ToString(){} // RVA: 0x6EC4DD0
        public void Append(){} // RVA: 0x6EC4E60
        public void AppendTypeName(){} // RVA: 0x6EC50E0
    }

    public class StackFrame : Object
    {
        public object OFFSET_UNKNOWN;
        public object ilOffset;
        public object nativeOffset;
        public object methodAddress;
        public object methodIndex;
        public object methodBase;
        public object fileName;
        public object lineNumber;
        public object columnNumber;
        public object internalMethodName;

        // ── Methods ──
        public void get_frame_info(){} // RVA: 0x686FD20
        public void .ctor(){} // RVA: 0x686FDE0
        public void GetFileLineNumber(){} // RVA: 0x18A0130
        public void GetFileColumnNumber(){} // RVA: 0x114DAD0
        public void GetFileName(){} // RVA: 0xD33E60
        public void GetSecureFileName(){} // RVA: 0x686FEA0
        public void GetILOffset(){} // RVA: 0xB8F8F0
        public void GetMethod(){} // RVA: 0xB70160
        public void GetNativeOffset(){} // RVA: 0x116A650
        public void GetMethodAddress(){} // RVA: 0xB465B0
        public void GetMethodIndex(){} // RVA: 0xFEAE90
        public void GetInternalMethodName(){} // RVA: 0xBC1B30
        public void ToString(){} // RVA: 0x686FF10
    }

    public class StackFrame[] : Array
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

    public class StackTrace : Object
    {
        public object METHODS_TO_SKIP;
        public object prefix;
        public object frames;
        public object captured_traces;
        public object debug_info;
        public object isAotidSet;
        public object aotid;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void init_frames(){} // RVA: 0x6870180
        public void get_trace(){} // RVA: 0x6870420
        public void get_FrameCount(){} // RVA: 0x427BCF0
        public void GetFrame(){} // RVA: 0x68708F0
        public void GetFrames(){} // RVA: 0x6870960
        public void GetAotId(){} // RVA: 0x6870B20
        public void AddFrames(){} // RVA: 0x6870BD0
        public void GetFullNameForStackTrace(){} // RVA: 0x6871140
        public void ConvertAsyncStateMachineMethod(){} // RVA: 0x68718D0
        public void ToString(){} // RVA: 0x6871D20
    }

    public class StackTraceHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StackTraceHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StackTraceHiddenAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class StackTrace[] : Array
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

    public class Stopwatch : Object
    {
        public object Frequency;
        public object IsHighResolution;
        public object elapsed;
        public object started;
        public object is_running;

        // ── Methods ──
        public void GetTimestamp(){} // RVA: 0x69B7F50
        public void StartNew(){} // RVA: 0x7690100
        public void .ctor(){} // RVA: 0xB43310
        public void get_Elapsed(){} // RVA: 0x76901A0
        public void get_ElapsedMilliseconds(){} // RVA: 0x76902B0
        public void get_ElapsedTicks(){} // RVA: 0x7690400
        public void get_IsRunning(){} // RVA: 0xC38360
        public void Reset(){} // RVA: 0x7690470
        public void Start(){} // RVA: 0x7690480
        public void Stop(){} // RVA: 0x76904E0
        public void Restart(){} // RVA: 0x7690560
        public void .cctor(){} // RVA: 0x76905C0
    }

    public class StringBuilderExtentions : Object
    {
        // ── Methods ──
        public void AppendDemystified(){} // RVA: 0x6EC5150
        public void AppendInnerException(){} // RVA: 0x6EC5600
    }

    public class Switch : Object
    {
        public object description;
        public object displayName;
        public object switchValueString;
        public object defaultValue;
        public object switches;
        public object s_LastCollectionCount;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7685230
        public void _pruneCachedSwitches(){} // RVA: 0x76855E0
        public void .cctor(){} // RVA: 0x7685C10
    }

    public class SwitchLevelAttribute : Attribute
    {
        public object type;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7685CF0
        public void set_SwitchLevelType(){} // RVA: 0x7685CF0
    }

    public class SynchronizedList`1 : Object
    {
        public object _list;
        public object _version;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void Add(){} // RVA: 0xA94080
        public void AddIfNotExist(){} // RVA: 0xA94080
        public void Remove(){} // RVA: 0xA94080
        public void get_Count(){} // RVA: 0x87C130
        public void EnumWithAction(){} // RVA: 0x8943B0
    }

    public class Trace : Object
    {
        public object correlationManager;

        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x7685DC0
        public void get_AutoFlush(){} // RVA: 0x7685E10
        public void get_CorrelationManager(){} // RVA: 0x7685EA0
        public void WriteLine(){} // RVA: 0x7685F80
    }

    public class TraceEventCache : Object
    {
        public object processId;
        public object processName;
        public object timeStamp;
        public object dateTime;
        public object stackTrace;

        // ── Methods ──
        public void get_Callstack(){} // RVA: 0x7685FD0
        public void get_LogicalOperationStack(){} // RVA: 0x76860B0
        public void get_DateTime(){} // RVA: 0x76861A0
        public void get_ProcessId(){} // RVA: 0x7686280
        public void get_ThreadId(){} // RVA: 0x76862D0
        public void get_Timestamp(){} // RVA: 0x7686450
        public void InitProcessInfo(){} // RVA: 0x76864B0
        public void GetProcessId(){} // RVA: 0x7686280
        public void GetThreadId(){} // RVA: 0x6975620
        public void .ctor(){} // RVA: 0x7686630
    }

    public class TraceFilter : Object
    {
        // ── Methods ──
        public void ShouldTrace(){} // RVA: 0x76866A0
    }

    public class TraceInternal : Object
    {
        public object appName;
        public object listeners;
        public object autoFlush;
        public object useGlobalLock;
        public object indentLevel;
        public object indentSize;
        public object critSec;

        // ── Methods ──
        public void get_Listeners(){} // RVA: 0x76866F0
        public void get_AutoFlush(){} // RVA: 0x7686BC0
        public void get_UseGlobalLock(){} // RVA: 0x7686C20
        public void get_IndentLevel(){} // RVA: 0x7686C80
        public void get_IndentSize(){} // RVA: 0x7686D20
        public void InitializeSettings(){} // RVA: 0xB43310
        public void WriteLine(){} // RVA: 0x7686D80
        public void .cctor(){} // RVA: 0x76875A0
    }

    public class TraceListener : MarshalByRefObject
    {
        public object indentLevel;
        public object indentSize;
        public object traceOptions;
        public object needIndent;
        public object listenerName;
        public object filter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76876D0
        public void get_IsThreadSafe(){} // RVA: 0xB43320
        public void Dispose(){} // RVA: 0xB43310
        public void Flush(){} // RVA: 0xB43310
        public void set_IndentLevel(){} // RVA: 0x76877A0
        public void set_IndentSize(){} // RVA: 0x76877C0
        public void get_Filter(){} // RVA: 0xD33E60
        public void get_NeedIndent(){} // RVA: 0xB5E030
        public void set_NeedIndent(){} // RVA: 0xD72F80
        public void get_TraceOutputOptions(){} // RVA: 0xFEAE90
        public void Write(){} // RVA: 0x894320
        public void WriteIndent(){} // RVA: 0x7687880
        public void WriteLine(){} // RVA: 0x894320
        public void TraceEvent(){} // RVA: 0x7687940
        public void WriteHeader(){} // RVA: 0x7687B60
        public void WriteFooter(){} // RVA: 0x7687D00
        public void IsEnabled(){} // RVA: 0x2548410
    }

    public class TraceListenerCollection : Object
    {
        public object list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7688750
        public void get_Count(){} // RVA: 0x6875CA0
        public void Add(){} // RVA: 0x7688890
        public void Clear(){} // RVA: 0x7688A40
        public void GetEnumerator(){} // RVA: 0x66459E0
        public void InitializeListener(){} // RVA: 0x7688AE0
        public void RemoveAt(){} // RVA: 0x7688C70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7688DF0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7688E20
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IList.Add(){} // RVA: 0x7688F40
        public void System.Collections.IList.Contains(){} // RVA: 0x6876210
        public void System.Collections.IList.IndexOf(){} // RVA: 0x68764B0
        public void System.Collections.IList.Insert(){} // RVA: 0x76891A0
        public void System.Collections.IList.Remove(){} // RVA: 0x76893F0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x2303260
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xC2E4C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7689580
    }

    public class TraceSwitch : Switch
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7689720
    }

    public class TypeNameHelper : Object
    {
        public object BuiltInTypeNames;
        public object FSharpTypeNames;

        // ── Methods ──
        public void GetTypeDisplayName(){} // RVA: 0x6EC56B0
        public void AppendTypeDisplayName(){} // RVA: 0x6EC5790
        public void GetTypeNameForGenericType(){} // RVA: 0x6EC5820
        public void ProcessType(){} // RVA: 0x6EC5940
        public void ProcessArrayType(){} // RVA: 0x6EC5F20
        public void ProcessGenericType(){} // RVA: 0x6EC6130
        public void .cctor(){} // RVA: 0x6EC6770
    }

    public class ValueTupleResolvedParameter : ResolvedParameter
    {
        public object _tupleNames;

        // ── Methods ──
        public void get_TupleNames(){} // RVA: 0xD33E60
        public void .ctor(){} // RVA: 0x6EC72C0
        public void AppendTypeName(){} // RVA: 0x6EC7370
        public void AppendValueTupleParameterName(){} // RVA: 0x6EC7650
    }

}